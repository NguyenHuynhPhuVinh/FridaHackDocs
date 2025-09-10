## Cẩm nang Mod Game Unity Toàn tập (Phiên bản Siêu chi tiết)

**Tác giả:** Tomis & Trợ lý AI
**Game mục tiêu:** A Girl Adrift (표류소녀)
**Thành quả:** Nắm vững toàn bộ quy trình từ phân tích động với Frida, xây dựng logic, đến đóng gói một Mod Menu ImGui hoàn chỉnh, tùy biến và chuyên nghiệp.

### Lời nói đầu: Triết lý "Hai Giai đoạn"

Mod game chuyên nghiệp không phải là một bước duy nhất, mà là một quy trình gồm hai giai đoạn tách biệt rõ ràng:

1.  **Giai đoạn Nghiên cứu (R&D - Research & Development):** Giống như một nhà khoa học trong phòng thí nghiệm. Chúng ta sử dụng các công cụ linh hoạt như **`frida-il2cpp-bridge`** để mổ xẻ, phân tích game trong thời gian thực. Giai đoạn này ưu tiên tốc độ thử nghiệm và khả năng gỡ lỗi nhanh chóng. Mục tiêu là tìm ra "công thức" hack chính xác: Class nào, Method nào, và can thiệp ra sao.

2.  **Giai đoạn Sản xuất (Production):** Giống như một kỹ sư trong nhà máy. Khi đã có "công thức" hoàn hảo, chúng ta sử dụng một nền tảng vững chắc như **`Android-ImGui-Mod-Menu`** để xây dựng một sản phẩm hoàn chỉnh. Giai đoạn này ưu tiên sự ổn định, giao diện thân thiện và khả năng phân phối dễ dàng dưới dạng một file `.apk` duy nhất.

Tài liệu này sẽ hướng dẫn bạn đi qua cả hai giai đoạn để trở thành một modder toàn diện.

---

## Phần I: "Phòng Thí nghiệm" - Nghiên cứu Game với `frida-il2cpp-bridge`

Đây là giai đoạn tìm ra "công thức" hack game một cách an toàn và nhanh chóng.

### 1. Chuẩn bị Môi trường

- **Trên Windows:**
  - Cài đặt **Node.js** (bao gồm npm): [nodejs.org](https://nodejs.org/en/)
  - Cài đặt **Python:** [python.org](https://www.python.org/downloads/) (Nhớ tick vào ô "Add Python to PATH").
  - Cài đặt **Android Platform Tools (ADB):** Tải và thêm vào biến môi trường PATH.
- **Cài đặt các công cụ Frida & Bridge:** Mở Command Prompt (CMD) và chạy:
  ```cmd
  pip install frida-tools
  npm install -g frida-il2cpp-bridge
  npm install -g frida-compile
  ```
- **Thiết bị:** Điện thoại Android đã bật Gỡ lỗi USB. (Nếu chưa root, bạn cần patch game với `frida-gadget` như trong các hướng dẫn trước).

### 2. Trinh sát & Thu thập Thông tin

Mục tiêu của bước này là tạo ra một "bản đồ chi tiết" của game.

1.  Mở game "A Girl Adrift" trên điện thoại.
2.  Mở CMD và di chuyển đến một thư mục làm việc (ví dụ `C:\GameDumps`).

#### 2.1. Dump dạng `flat` - Trinh sát Nhanh

Đây là cách nhanh nhất để tìm kiếm. Nó sẽ tạo ra một file `dump.cs` duy nhất.

```cmd
frida-il2cpp-bridge -U "표류소녀" dump --cs-output flat
```

- **Kết quả:** Một file `dump.cs` duy nhất chứa tất cả các lớp của game.
- **Khi nào dùng:** Khi bạn muốn tìm nhanh một class/method bằng `Ctrl+F`. Rất lý tưởng cho việc tìm kiếm ban đầu.

#### 2.2. Dump dạng `tree` - Phân tích Cấu trúc

Cách này sẽ tạo ra một cấu trúc thư mục hoàn chỉnh, mô phỏng lại các assembly của game.

```cmd
frida-il2cpp-bridge -U "표류소녀" dump --cs-output tree
```

- **Kết quả:** Một thư mục mới sẽ được tạo (ví dụ `exize.tapas.girlAdrift\1.376`), bên trong chứa các file như `Assembly-CSharp.cs`, `UnityEngine.CoreModule.cs`, v.v.
- **Khi nào dùng:** Khi bạn muốn hiểu rõ hơn về kiến trúc của game, xem class nào thuộc về thư viện nào. Hữu ích khi phân tích các game phức tạp hoặc khi tìm kiếm trong file `flat` cho ra quá nhiều kết quả nhiễu.

#### 2.3. Phân tích & Xác định Mục tiêu

Dù dùng cách nào, bạn cũng sẽ mở file `Assembly-CSharp.cs` và tìm kiếm.

- **Mục tiêu 1 (Mua sắm):** Tìm `class player_currency_element` -> `void Use(double num)` -> Ghi lại offset (ví dụ `0x18B93DC`).
- **Mục tiêu 2 (Nhận thưởng):** Tìm `class player_currency_element` -> `void Add(double num, System.Nullable<UnityEngine.Vector3> effect_pos, bool isWorldPos)` -> Ghi lại offset (ví dụ `0x18B9070`).
- **Mục tiêu phụ:** Hàm `Add` đơn giản để thực hiện cheat mua sắm -> `void Add(double num)` -> Ghi lại offset (ví dụ `0x18C71C4`).

### 3. Viết và Thử nghiệm Script Frida

1.  **Thiết lập dự án script:**

    - Tạo một thư mục mới (ví dụ: `C:\FridaHacking`).
    - Mở CMD tại thư mục đó và chạy `npm init -y` để tạo file `package.json`.
    - Chạy `npm install frida-il2cpp-bridge` để cài đặt thư viện cục bộ.

2.  **Tạo file script (ví dụ `all_cheats.js`):**
    Dán đoạn mã hoàn chỉnh sau vào.

    ```javascript
    import "frida-il2cpp-bridge";

    console.log("[*] A Girl Adrift - All Cheats Test Script");

    Il2Cpp.perform(() => {
      try {
        console.log("[+] Il2Cpp Bridge is ready!");
        const assembly = Il2Cpp.domain.assembly("Assembly-CSharp");
        const PlayerCurrencyElement = assembly.image.class(
          "player_currency_element"
        );

        // --- CHEAT 1: MUA SẮM MIỄN PHÍ ---
        const useMethod =
          PlayerCurrencyElement.method("Use").overload("System.Double");
        const addSimpleMethod =
          PlayerCurrencyElement.method("Add").overload("System.Double");

        useMethod.implementation = function (num) {
          const reversedAmount = -num;
          console.log(
            `[SHOP] Intercepted Use(${num}). Reversing to Add(${reversedAmount})`
          );
          // Gọi hàm Add đơn giản để cộng tiền
          addSimpleMethod.bind(this).invoke(reversedAmount);
        };
        console.log(
          `[+] Free Shopping hook active at ${useMethod.virtualAddress}`
        );

        // --- CHEAT 2: NHÂN TIỀN THƯỞNG ---
        const rewardMethod = PlayerCurrencyElement.method("Add").overload(
          "System.Double",
          "System.Nullable<UnityEngine.Vector3>",
          "System.Boolean"
        );
        const GOLD_MULTIPLIER = 100;
        rewardMethod.implementation = function (num, effect_pos, isWorldPos) {
          let hackedGold = num;
          if (num > 0) {
            hackedGold = num * GOLD_MULTIPLIER;
            console.log(
              `[REWARD] Intercepted Add(${num}). Multiplying to ${hackedGold}`
            );
          }
          return rewardMethod
            .bind(this)
            .invoke(hackedGold, effect_pos, isWorldPos);
        };
        console.log(
          `[+] Reward Multiplier hook active at ${rewardMethod.virtualAddress}`
        );

        console.log("\n[SUCCESS] All cheats are active!");
      } catch (e) {
        console.error(e.stack);
      }
    });
    ```

3.  **Biên dịch và Chạy:**
    - Trong CMD, chạy: `frida-compile all_cheats.js -o compiled.js`
    - Chạy Frida: `frida -U "표류소녀" -l compiled.js`
    - Kiểm tra trong game xem các cheat đã hoạt động chưa.

Sau khi xác nhận "công thức" là chính xác, chúng ta sẽ chuyển sang giai đoạn sản xuất.

---

## Phần II: "Nhà máy" - Đóng gói Mod Menu với ImGui

### 1. Chuẩn bị Dự án

1.  Tải và giải nén dự án **`Android-ImGui-Mod-Menu`**.
2.  Mở dự án trong Android Studio.
3.  **Xử lý lỗi NDK:** Chắc chắn rằng bạn đã cài đúng phiên bản NDK mà dự án yêu cầu (ví dụ `24.0.7856742`) thông qua SDK Manager và đã trỏ đúng đường dẫn trong file `local.properties`.

### 2. Tùy biến Nâng cao: Thêm Font Tiếng Việt

#### 2.1. Chuyển đổi Font bằng Script Python

1.  Tạo một thư mục mới, ví dụ `C:\FontTool`.
2.  Chép một file font `.ttf` hỗ trợ tiếng Việt (ví dụ `arial.ttf`) vào thư mục này.
3.  Tạo file `convert_font.py` trong cùng thư mục với nội dung:

    ```python
    import os

    # === CÀI ĐẶT ===
    input_file = "arial.ttf"
    output_file = "VietnameseFont.h"
    array_name = "VietnameseFont_ttf"
    # ===============

    try:
        with open(input_file, 'rb') as f_in:
            font_data = f_in.read()

        with open(output_file, 'w', encoding='utf-8') as f_out:
            f_out.write(f"// Font: {os.path.basename(input_file)}, Size: {len(font_data)} bytes\n")
            f_out.write(f"const unsigned int {array_name}_len = {len(font_data)};\n\n")
            f_out.write(f"const unsigned char {array_name}[] = {{\n    ")

            for i, byte in enumerate(font_data):
                f_out.write(f"0x{byte:02x},")
                if (i + 1) % 16 == 0:
                    f_out.write("\n    ")
                else:
                    f_out.write(" ")

            f_out.write("\n};\n")
        print(f"Success: Converted '{input_file}' to '{output_file}'")
    except Exception as e:
        print(f"Error: {e}")
    ```

4.  Mở CMD, `cd C:\FontTool` và chạy `python convert_font.py`.
5.  Chép file `VietnameseFont.h` vừa tạo vào thư mục `app/src/main/jni/Include/` của dự án.

#### 2.2. Nạp Font trong Code

Mở file `app/src/main/jni/Include/ImGui.h` và sửa hàm `setupMenu()`:

```cpp
// ... các include khác ...
#include "VietnameseFont.h"

void setupMenu() {
    if (isInitialized) return;
    ImGui::CreateContext();
    ImGuiIO& io = ImGui::GetIO();
    io.DisplaySize = ImVec2((float)glWidth, (float)glHeight);
    ImGui_ImplAndroid_Init();
    ImGui_ImplOpenGL3_Init("#version 300 es");

    static const ImWchar vietnamese_glyph_ranges[] = {
        0x0020, 0x00FF, // Basic Latin + Latin Supplement
        0x0100, 0x017F, // Latin Extended-A
        0x0180, 0x024F, // Latin Extended-B
        0x1E00, 0x1EFF, // Latin Extended Additional
        0,
    };

    ImFontConfig font_cfg;
    font_cfg.FontDataOwnedByAtlas = false;
    float fontSize = 32.0f; // Chỉnh kích thước font
    io.Fonts->AddFontFromMemoryTTF((void*)VietnameseFont_ttf, VietnameseFont_ttf_len, fontSize, &font_cfg, vietnamese_glyph_ranges);

    ImGui::GetStyle().ScaleAllSizes(2.0f);
    isInitialized = true;
}
```

### 3. Tích hợp Logic Cheat và Giao diện

Mở file `app/src/main/jni/Main/Main.cpp` và thay thế toàn bộ nội dung bằng mã nguồn sau:

```cpp
#include "../Include/ImGui.h"
#include "../Include/Unity.h"

// ===================================
// ========== CÀI ĐẶT CHEAT ==========
// ===================================
bool feature_FreeShopping = false;
bool feature_RewardMultiplier = false;
float rewardMultiplier = 100.0f;

// ========== KHAI BÁO HÀM VÀ OFFSET ==========
void (*old_Use)(void *instance, double amount);
void (*old_Add_Simple)(void *instance, double amount);
void (*old_Add_WithFx)(void *instance, double amount, void* effect_pos, bool isWorldPos);

#define OFFSET_USE 0x18B93DC
#define OFFSET_ADD_SIMPLE 0x18C71C4
#define OFFSET_ADD_WITH_FX 0x18B9070

// ========== CÁC HÀM HOOK ============
void hook_Use(void *instance, double amount) {
    if (feature_FreeShopping) {
        old_Add_Simple(instance, -amount);
        return;
    }
    old_Use(instance, amount);
}

void hook_Add_WithFx(void *instance, double amount, void* effect_pos, bool isWorldPos) {
    if (feature_RewardMultiplier && amount > 0) {
        amount *= rewardMultiplier;
    }
    old_Add_WithFx(instance, amount, effect_pos, isWorldPos);
}

// ========== GIAO DIỆN MOD MENU ==========
void DrawMenu() {
    ImGui::Begin(u8"Mod Menu A Girl Adrift - Tomis");
    ImGui::Checkbox(u8"Mua Sắm Miễn Phí", &feature_FreeShopping);
    ImGui::Text(u8"Khi mua đồ sẽ được cộng tiền thay vì bị trừ.");
    ImGui::Separator();
    ImGui::Checkbox(u8"Nhân Tiền Thưởng", &feature_RewardMultiplier);
    ImGui::Text(u8"Nhân số tiền nhận được khi câu cá.");
    if (feature_RewardMultiplier) {
        ImGui::SliderFloat(u8"Hệ Số Nhân", &rewardMultiplier, 10.0f, 1000.0f, "x%.0f");
    }
    ImGui::End();
}

// ========== LUỒNG KHỞI TẠO CHÍNH ==========
void *thread(void *) {
    do { sleep(1); } while (!isLibraryLoaded(OBFUSCATE("libil2cpp.so")));

    uintptr_t use_addr = getAbsoluteAddress("libil2cpp.so", OFFSET_USE);
    uintptr_t add_simple_addr = getAbsoluteAddress("libil2cpp.so", OFFSET_ADD_SIMPLE);
    uintptr_t add_with_fx_addr = getAbsoluteAddress("libil2cpp.so", OFFSET_ADD_WITH_FX);

    if (use_addr && add_simple_addr) {
        DobbyHook((void *) use_addr, (void *) hook_Use, (void **) &old_Use);
        DobbyHook((void *) add_simple_addr, nullptr, (void **) &old_Add_Simple);
    }
    if (add_with_fx_addr) {
        DobbyHook((void *) add_with_fx_addr, (void *) hook_Add_WithFx, (void **) &old_Add_WithFx);
    }

    initModMenu((void *)DrawMenu);
    pthread_exit(0);
}

// ========== PHẦN KHỞI TẠO JNI (GIỮ NGUYÊN) ===============
extern "C" {
    JavaVM *jvm = nullptr; JNIEnv *env = nullptr;
    __attribute__((visibility ("default")))
    jint loadJNI(JavaVM *vm) {
        jvm = vm; vm->AttachCurrentThread(&env, nullptr);
        return JNI_VERSION_1_6;
    }
}
__attribute__((constructor))
void init() {
    pthread_t t;
    pthread_create(&t, nullptr, thread, nullptr);
    RemapTools::RemapLibrary("libLoader.so");
}
```

### 4. Biên dịch và "Phẫu thuật" APK

1.  **Biên dịch:** Trong Android Studio, chọn **Build -> Build APK(s)**.
2.  **Decompile:** Dùng **APK Easy Tool**. Decompile game gốc (`girlAdrift.apk`) và `app-debug.apk` vừa tạo.
3.  **Cấy ghép Thư viện:** Chép `libLoader.so` và `libModMenu.so` từ `app-debug/lib/arm64-v8a/` vào `girlAdrift/lib/arm64-v8a/`.
4.  **Kích hoạt Loader:** Sửa file `UnityPlayerActivity.smali` của game, thêm 2 dòng sau vào đầu phương thức `onCreate`:
    ```smali
    const-string v0, "Loader"
    invoke-static {v0}, Ljava/lang/System;->loadLibrary(Ljava/lang/String;)V
    ```
5.  **Compile:** Dùng APK Easy Tool để đóng gói lại thư mục game.

### 5. Cài đặt và Tận hưởng

Cài đặt file `.apk` đã mod lên điện thoại. Mở game và bạn sẽ thấy Mod Menu tiếng Việt hoàn chỉnh, hoạt động mượt mà, sẵn sàng để bạn tùy chỉnh và sử dụng.

**Chúc mừng bạn đã hoàn thành một quy trình mod game chuyên nghiệp từ A đến Z!**
