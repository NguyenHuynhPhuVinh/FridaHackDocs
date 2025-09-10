# Hướng dẫn Toàn tập: Tạo Mod Menu cho Game Unity (A Girl Adrift) trên Windows cho Người mới bắt đầu

**Tác giả:** Tomis & Trợ lý AI
**Thành quả:** Một tệp `A Girl Adrift.apk` đã được tích hợp Mod Menu nổi, cho phép bật/tắt cheat "Mua sắm miễn phí".
**Bài học kinh nghiệm:** Quá trình này đầy thử thách, đặc biệt với các thiết bị Android có HĐH tùy biến sâu (như ColorOS). Sự kiên nhẫn và gỡ lỗi có hệ thống là chìa khóa thành công.

---

## Phần I: Chuẩn bị "Chiến trường" - Thiết lập Môi trường từ Con số Không

### 1. Cài đặt các Công cụ trên Windows

#### a. Kích hoạt Chế độ Nhà phát triển

- Mở **Start Menu**, tìm `Developer settings` và bật **Developer Mode**.

#### b. Cài đặt Android Studio & Công cụ cần thiết

- Truy cập [developer.android.com/studio](https://developer.android.com/studio) và tải về **Android Studio**.
- Chạy trình cài đặt. Ở màn hình "Welcome", chọn **More Actions -> SDK Manager**.
- Trong tab **"SDK Tools"**, đánh dấu vào ô **NDK (Side by side)** và **CMake**.
- Nhấn **Apply** để cài đặt.

#### c. Cài đặt Python & Frida Tools

- Truy cập [python.org](https://www.python.org/downloads/) và tải Python.
- Khi cài đặt, **đánh dấu vào ô "Add Python to PATH"**.
- Mở **Command Prompt (CMD)** và chạy: `pip install frida-tools`

#### d. Cài đặt Android Platform Tools (ADB)

- Tải về "SDK Platform Tools for Windows" từ [trang chủ Android](https://developer.android.com/tools/sdk/platform-tools).
- Giải nén vào `C:\platform-tools`.
- Thêm `C:\platform-tools` vào **System Environment Variables Path**.
- **Khởi động lại máy tính** để áp dụng thay đổi.

### 2. Cài đặt và Cấu hình Môi trường Linux (WSL)

#### a. Cài đặt WSL

- Mở **PowerShell (với quyền Administrator)**.
- Chạy: `wsl --install`.
- Khởi động lại máy. Mở ứng dụng **Ubuntu** từ Start Menu, tạo username và password.

#### b. Cài đặt Công cụ USB (`usbipd`)

- Mở **PowerShell (Admin)**.
- Chạy: `winget install --interactive --exact dorssel.usbipd-win`.

#### c. Cài đặt các Gói cần thiết trong WSL

- Mở terminal **Ubuntu**.
- Chạy lệnh sau để cài đặt mọi thứ cần thiết cho việc biên dịch và patch:
  ```bash
  sudo apt update
  sudo apt install git unzip openjdk-17-jdk dos2unix patchelf -y
  ```

### 3. Chuẩn bị Điện thoại Android

- **Bật Tùy chọn Nhà phát triển:** Vào Cài đặt -> Giới thiệu -> Nhấn 7 lần vào "Số bản dựng".
- **Bật Gỡ lỗi USB:** Vào Cài đặt -> Hệ thống -> Tùy chọn nhà phát triển -> Bật "Gỡ lỗi USB".
- **Cài đặt game gốc** "A Girl Adrift" lên điện thoại.

---

## Phần II: "Phẫu thuật" - Phân tích Game và Xây dựng Mod

### 1. Tải và Thiết lập Dự án Mod Menu

- Tải về dự án **LGL Mod Menu** từ GitHub dưới dạng `.zip`.
- Giải nén vào `C:\ModMenuProject\`.
- Mở thư mục này trong **Android Studio**.

### 2. Trinh sát Game (Reconnaissance)

- **Chia sẻ thiết bị với WSL:**
  - Cắm điện thoại vào máy. Mở **PowerShell (Admin)**.
  - Chạy `usbipd list` để tìm **BUSID** của điện thoại.
  - Chạy `usbipd bind --force --busid <BUSID>` và `usbipd attach --wsl --busid <BUSID>`.
- **Kéo tệp APK về WSL:**
  - Mở terminal **Ubuntu**.
  - Clone dự án `apk.sh` và cấp quyền:
    ```bash
    git clone https://github.com/ax/apk.sh.git && cd apk.sh
    dos2unix apk.sh && chmod +x apk.sh
    ```
  - Chạy lệnh `pull` với `sudo` (do `usbipd` yêu cầu quyền cao):
    ```bash
    # Khởi động adb server với sudo
    sudo ~/.apk.sh/sdk_root/platform-tools/adb start-server
    # Chạy pull
    sudo ./apk.sh pull exize.tapas.girlAdrift
    ```
  - Bạn sẽ có tệp `file.single.apk`. Đổi tên thành `girlAdrift.apk`.

### 3. Phân tích Tĩnh (Static Analysis) với Il2CppDumper

- **Tải Il2CppDumper** từ GitHub và giải nén vào một thư mục trên Windows.
- **Trích xuất các tệp quan trọng từ APK:**
  - Dùng 7-Zip hoặc `unzip` để giải nén `girlAdrift.apk`.
  - Lấy ra 2 tệp: `lib/arm64-v8a/libil2cpp.so` và `assets/bin/Data/Managed/metadata/global-metadata.dat`.
  - Đặt chúng vào cùng thư mục với `Il2CppDumper.exe`.
- **Chạy Il2CppDumper.exe.** Nó sẽ tạo ra các tệp phân tích, quan trọng nhất là `dump.cs`.
- **"Đi săn":** Mở `dump.cs` và tìm kiếm để xác định các offset quan trọng. Dựa trên quá trình của chúng ta, offset cho hàm `player_currency_element.Use(double num)` là **`0x18B93DC`**.

### 4. Lập trình Cheat trong Mod Menu

- Quay lại **Android Studio** và dự án LGL Mod Menu.
- Mở tệp `app/src/main/jni/Main.cpp`.
- **Dán toàn bộ mã nguồn C++** đã được hoàn thiện từ các bước trước vào (mã nguồn hook hàm `Use()` ở offset `0x18B93DC`).

### 5. Biên dịch Mod Menu

- Trong Android Studio, vào **Build -> Build Bundle(s) / APK(s) -> Build APK(s)**.
- Nhấn **"locate"** để tìm tệp `app-debug.apk`.

---

## Phần III: "Cấy ghép" - Tích hợp Mod Menu vào Game

### 1. Chuẩn bị các thành phần

- Sử dụng **APK Easy Tool** trên Windows.
- **Giải nén** cả hai tệp: `girlAdrift.apk` (game gốc) và `app-debug.apk` (mod menu).
- Từ thư mục `app-debug` đã giải nén, lấy ra:
  - Thư viện: `lib/arm64-v8a/libMyLibName.so`
  - **Toàn bộ** các thư mục Smali: `smali`, `smali_classes2`, v.v.

### 2. Thực hiện "Cấy ghép"

- **Sao chép thư viện:** Dán `libMyLibName.so` vào `girlAdrift/lib/arm64-v8a/`.
- **Hợp nhất Smali:**
  - Sao chép toàn bộ nội dung của `app-debug/smali/` và dán vào `girlAdrift/smali/`.
  - Sao chép toàn bộ nội dung của `app-debug/smali_classes2/` và dán vào `girlAdrift/smali_classes2/`.
  - Lặp lại cho tất cả các thư mục `smali_classesX`. Chọn **"Merge"** và **"Yes to all"** nếu được hỏi.
- **Sửa `AndroidManifest.xml`:**
  - Mở `girlAdrift/AndroidManifest.xml`.
  - Thêm quyền: `<uses-permission android:name="android.permission.SYSTEM_ALERT_WINDOW"/>`.
  - Thêm service: `<service android:name="com.android.support.Launcher" />` vào bên trong thẻ `<application>`.
- **Sửa Smali để Khởi động Menu:**
  - Tìm tệp smali của Activity chính (`com.unity3d.player.UnityPlayerActivity.smali`, có thể nằm trong `smali_classes2`).
  - Mở nó, tìm phương thức `.method protected onCreate`.
  - Thêm dòng sau vào ngay sau dòng định nghĩa phương thức:
    ```smali
    invoke-static {p0}, Lcom/android/support/Main;->Start(Landroid/content/Context;)V
    ```

### 3. Đóng gói và Hoàn thiện

- Trong **APK Easy Tool**, chọn thư mục `girlAdrift` đã được sửa đổi.
- Nhấn nút **Compile**.
- Tệp `girlAdrift_signed.apk` (hoặc tên tương tự) trong thư mục `2-Recompiled APKs` chính là thành quả cuối cùng của bạn.

---

## Phần IV: Triển khai và Sử dụng

1.  **Gỡ thiết bị khỏi WSL:**
    - Mở **PowerShell (Admin)**, chạy: `usbipd detach --busid <BUSID>`.
2.  **Cài đặt APK Modded:**
    - Mở **CMD**, chạy:
      ```cmd
      adb uninstall exize.tapas.girlAdrift
      adb install "đường_dẫn_đến_tệp_apk_modded_của_bạn.apk"
      ```
3.  **Chạy Game:**
    - Mở game, cấp quyền "Vẽ trên các ứng dụng khác".
    - Icon nổi của Mod Menu sẽ xuất hiện.
4.  **Kích hoạt Cheat:**
    - Nhấn vào icon để mở menu.
    - Bật "Free Shopping".
    - Vào cửa hàng, mua một món đồ. Thay vì mất tiền, bạn sẽ được cộng thêm tiền.

**XIN CHÚC MỪNG! BẠN ĐÃ LÀ MỘT MODDER!**
