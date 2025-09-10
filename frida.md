# Hướng dẫn Toàn tập: Hack Game Unity (A Girl Adrift) bằng Frida trên Thiết bị Chưa Root

**Mục tiêu:** Tạo script Frida để có tiền tệ không giới hạn trong game "A Girl Adrift" bằng cách can thiệp vào logic game trong thời gian thực.
**Công cụ chính:** Frida, `apk.sh` (để tự động hóa việc patch), Ghidra/Il2CppDumper (để phân tích).
**Yêu cầu:** Một laptop Windows đã cài đặt đầy đủ môi trường (WSL, Python, ADB, ... như trong tài liệu Mod Menu).

---

## Phần I: Phân tích và Chuẩn bị "Vũ khí"

### 1. Trinh sát và Lấy APK

- Sử dụng WSL và `apk.sh` để kéo tệp APK đã được gộp từ điện thoại. Đổi tên thành `girlAdrift.apk`.
  ```bash
  # Trong WSL
  sudo ./apk.sh pull exize.tapas.girlAdrift
  sudo mv file.single.apk girlAdrift.apk
  ```

### 2. Phân tích Tĩnh (Static Analysis)

- **Xác định công nghệ:** Game sử dụng Unity/Il2Cpp. Logic chính nằm trong `libil2cpp.so`.
- **Sử dụng Il2CppDumper:**
  - Trích xuất `libil2cpp.so` và `global-metadata.dat` từ `girlAdrift.apk`.
  - Chạy `Il2CppDumper.exe` để tạo ra "bản đồ" `dump.cs`.
- **"Đi săn" trong `dump.cs`:**
  - **Mục tiêu:** Tìm hàm xử lý việc **trừ** tiền, vì nó ít bị kiểm tra hơn việc cộng tiền.
  - **Từ khóa tìm kiếm:** `UseCurrency`, `Spend`, `Buy`, `Use`.
  - **Kết quả:** Tìm thấy hàm `public void player_currency_element.Use(double num)` tại offset **`0x18B93DC`**. Đây là mục tiêu hoàn hảo.

---

## Phần II: "Cấy Ghép" Frida Gadget vào Game

Chúng ta sẽ nhúng `frida-gadget` vào APK để Frida có thể kết nối. Do game phức tạp và việc sửa mã Smali dễ lỗi, chúng ta sẽ sử dụng phương pháp **`patchelf`**, chèn gadget như một thư viện phụ thuộc.

### 1. Tải về Frida Gadget

- Trong **WSL**, tải về phiên bản `frida-gadget` mới nhất (phải khớp với phiên bản `frida-tools` trên máy tính của bạn, ví dụ: 17.2.17).
  ```bash
  wget https://github.com/frida/frida/releases/download/17.2.17/frida-gadget-17.2.17-android-arm64.so.xz
  unxz frida-gadget-17.2.17-android-arm64.so.xz
  ```

### 2. Giải nén và Patch APK

- **Giải nén APK gốc:**

  ```bash
  # Trong thư mục ~/apk.sh
  sudo ./apk.sh decode girlAdrift.apk
  ```

  Thao tác này tạo ra thư mục `girlAdrift`.

- **Cấy Gadget và Cấu hình:**

  - Tạo tệp `config.json` để game không bị treo:
    ```bash
    echo '{"interaction": {"type": "listen", "on_load": "resume"}}' > config.json
    ```
  - Sao chép gadget và config vào thư mục đã giải nén:
    ```bash
    sudo cp frida-gadget-*.so ./girlAdrift/lib/arm64-v8a/libfrida-gadget.so
    sudo cp config.json ./girlAdrift/lib/arm64-v8a/libfrida-gadget.config.so
    ```

- **Sử dụng `patchelf`:**
  - Ra lệnh cho `libil2cpp.so` phải tải `libfrida-gadget.so` khi khởi động.
    ```bash
    cd girlAdrift/lib/arm64-v8a/
    sudo patchelf --add-needed libfrida-gadget.so libil2cpp.so
    cd ../../../
    ```

### 3. Đóng gói và Ký APK đã Patch

- **Biên dịch lại:**

  ```bash
  sudo ./apk.sh build girlAdrift
  ```

  Thao tác này tạo ra tệp `file.apk`.

- **Ký:**
  ```bash
  sudo ./apk.sh sign file.apk
  ```
  Tệp `file.apk` bây giờ đã sẵn sàng.

---

## Phần III: Triển khai và Chạy Cheat

### 1. Cài đặt và Kiểm tra Kết nối

- **Chuyển tệp qua Windows:**
  - Trong **WSL**:
    ```bash
    sudo cp file.apk /mnt/c/Users/TênCủaBạn/Documents/girlAdrift-Frida.apk
    ```
- **Cài đặt lên điện thoại:**
  - Trong **CMD**:
    ```cmd
    adb uninstall exize.tapas.girlAdrift
    adb install "C:\Users\TênCủaBạn\Documents\girlAdrift-Frida.apk"
    ```
- **Chạy thử Mod:**
  - Mở game "A Girl Adrift" trên điện thoại.
  - Trong **CMD**, chạy `frida-ps -Uai`.
  - **Kết quả mong đợi:** Thấy **biểu tượng viên thuốc 💊** bên cạnh tên game. Nếu có, bạn đã thành công.

### 2. Chuẩn bị Script Cheat

- Tạo một thư mục trên máy tính, ví dụ `C:\Users\TênCủaBạn\Documents\GirlAdriftCheat\`.
- Bên trong thư mục đó, tạo tệp `final_cheat.js` với nội dung sau:

  ```javascript
  console.log("[*] Final Cheat (Interceptor.replace) Initializing...");
  console.log("[*] This script will reverse transactions in the shop.");

  const libName = "libil2cpp.so";
  // Offset của hàm player_currency_element.Use(double num)
  const useCurrencyOffset = 0x18b93dc;

  function tryHook() {
    const lib = Process.findModuleByName(libName);
    if (lib) {
      try {
        const useAddress = lib.base.add(useCurrencyOffset);
        console.log(`[*] Found target function Use() at: ${useAddress}`);

        const originalUseFunction = new NativeFunction(useAddress, "void", [
          "pointer",
          "double",
        ]);

        Interceptor.replace(
          useAddress,
          new NativeCallback(
            (self_ptr, amount_to_spend) => {
              console.log(`\n--- [Transaction Intercepted!] ---`);
              console.log(`[*] Game tried to spend: ${amount_to_spend}`);

              // Logic Cheat: Biến trừ thành cộng
              const amountToGain = -amount_to_spend;

              console.log(
                `[*] Reversing transaction. You will now GAIN this amount instead.`
              );

              originalUseFunction(self_ptr, amountToGain);
            },
            "void",
            ["pointer", "double"]
          )
        );

        console.log("[+] Cheat is active. Go to the shop and buy something.");
      } catch (e) {
        console.error(`[!] An error occurred during hooking: ${e.stack}`);
      }
    } else {
      console.log(`[!] ${libName} not found yet. Retrying in 1 second...`);
      setTimeout(tryHook, 1000);
    }
  }

  setTimeout(tryHook, 2000);
  ```

### 3. Kích hoạt Cheat và Tận hưởng

1.  **Mở game "A Girl Adrift"** trên điện thoại.
2.  Mở **CMD**, di chuyển đến thư mục cheat của bạn:
    ```cmd
    cd C:\Users\TênCủaBạn\Documents\GirlAdriftCheat
    ```
3.  **Chạy Frida để đính kèm và tiêm script:**
    ```cmd
    frida -U "표류소녀" -l final_cheat.js
    ```
4.  **Vào cửa hàng trong game và mua một món đồ.**
5.  **Kết quả:** Thay vì mất tiền, số tiền của bạn sẽ được cộng thêm đúng bằng giá trị món đồ. Bạn đã có tiền vô hạn.

---

### Ghi chú Gỡ lỗi Quan trọng (Dựa trên Lịch sử)

- **`ClassNotFoundException` khi tạo Mod Menu:** Xảy ra khi mã Smali của menu không được hợp nhất đúng vào tất cả các tệp `classes.dex` của game.
- **`TypeError: not a function` trên Frida:** Dấu hiệu của sự không tương thích sâu giữa Frida và HĐH tùy biến (ColorOS). Giải pháp là tránh các phương thức thao tác `NativePointer` (`.add`, `.compare`, `.toInt32`, `.replace`) và ưu tiên sử dụng `Interceptor.replace` với chữ ký hàm được định nghĩa rõ ràng.
- **Game Crash khi `attach`:** Dấu hiệu của cơ chế anti-frida. Giải pháp là sử dụng chế độ `spawn` (`-f`) trên một APK đã được patch.
- **`Failed to spawn: need Gadget`:** Xảy ra khi cố gắng `spawn` một ứng dụng chưa được patch trên thiết bị chưa root.
- **Không có log gì cả:** Dấu hiệu game sử dụng cơ chế lưu trữ/cập nhật không đồng bộ. Cần tìm đúng thời điểm (trigger) để kích hoạt logic (ví dụ: minimize game).
