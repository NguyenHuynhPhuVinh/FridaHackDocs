# Hướng dẫn chi tiết Hack Game Android (Assault Cube) trên Thiết bị Chưa Root bằng Frida và `apk.sh` trên Windows WSL

Tài liệu này tổng hợp lại toàn bộ quy trình để chèn `frida-gadget` vào một ứng dụng Android, cho phép can thiệp động (dynamic instrumentation) trên các thiết bị chưa root. Quy trình này sử dụng Windows Subsystem for Linux (WSL) và script tự động hóa `apk.sh`.

## Phần 1: Chuẩn bị Môi trường

Đây là phần quan trọng nhất và thường gặp nhiều lỗi nhất. Chúng ta sẽ thiết lập một môi trường WSL hoàn chỉnh để làm việc.

### 1.1. Cài đặt WSL và các công cụ cần thiết

1.  **Cài đặt WSL:**
    Mở **PowerShell** với quyền **Administrator** và chạy:

    ```powershell
    wsl --install
    ```

    Khởi động lại máy nếu được yêu cầu. Sau đó, mở ứng dụng **Ubuntu** từ Start Menu để hoàn tất cài đặt (tạo username và password).

2.  **Cài đặt các gói cần thiết trong WSL:**
    Mở terminal Ubuntu (WSL) và chạy các lệnh sau để cài đặt các công cụ nền tảng:
    ```bash
    sudo apt update
    sudo apt install git unzip openjdk-17-jdk -y
    ```
    - **Ghi chú:** `openjdk-17-jdk` là cần thiết để các công cụ Android (như `sdkmanager`) có thể chạy.

### 1.2. Cài đặt và cấu hình `usbipd` để WSL nhận diện thiết bị Android

Vì WSL không thể truy cập trực tiếp thiết bị USB, chúng ta cần "chia sẻ" nó từ Windows.

1.  **Cài đặt `usbipd-win` trên Windows:**
    Mở **PowerShell** với quyền **Administrator** và chạy:

    ```powershell
    winget install --interactive --exact dorssel.usbipd-win
    ```

2.  **Chia sẻ thiết bị Android với WSL:**

    - Cắm điện thoại vào máy tính và bật **USB Debugging**.
    - Trong **PowerShell (Admin)**, liệt kê các thiết bị USB:
      ```powershell
      usbipd list
      ```
    - Tìm thiết bị Android của bạn và ghi lại giá trị **BUSID** (ví dụ: `1-4`).
    - Chạy các lệnh sau để chia sẻ thiết bị (thay `<BUSID>` bằng giá trị của bạn):

      ```powershell
      # Dừng adb server trên Windows để tránh xung đột
      adb kill-server

      # Ràng buộc và đính kèm thiết bị vào WSL
      usbipd bind --force --busid <BUSID>
      usbipd attach --wsl --busID <BUSID>
      ```

    - **Ghi chú lỗi:** Nếu lệnh `attach` báo lỗi `Device busy`, hãy chắc chắn bạn đã chạy `adb kill-server` trên Windows và thử lại với cờ `--force` ở lệnh `bind`.

### 1.3. Cài đặt và chuẩn bị `apk.sh`

1.  **Clone dự án `apk.sh` vào WSL:**
    Trong terminal WSL:

    ```bash
    git clone https://github.com/ax/apk.sh.git
    cd apk.sh
    ```

2.  **Chuyển đổi định dạng script và cấp quyền:**
    Các tệp được clone từ Git trên Windows có thể có định dạng dòng không tương thích với Linux.

    ```bash
    # Cài đặt công cụ chuyển đổi (nếu chưa có)
    sudo apt install dos2unix -y

    # Chuyển đổi và cấp quyền thực thi
    dos2unix apk.sh
    chmod +x apk.sh
    ```

    - **Ghi chú lỗi:** Nếu bạn gặp lỗi `cannot execute: required file not found` mặc dù tệp tồn tại, nguyên nhân chính là do định dạng dấu xuống dòng (CRLF). Lệnh `dos2unix` sẽ khắc phục điều này.

## Phần 2: Sử dụng `apk.sh` để Patch ứng dụng

Bây giờ môi trường đã sẵn sàng, chúng ta có thể sử dụng sức mạnh tự động hóa của `apk.sh`.

### 2.1. Kéo (Pull) tệp APK từ thiết bị

Đây là cách tốt nhất để lấy tệp cài đặt, vì nó xử lý được cả các ứng dụng dạng App Bundle/Split APKs.

1.  **Chạy lệnh `pull`:**
    Trong thư mục `~/apk.sh` (WSL):
    ```bash
    ./apk.sh pull net.cubers.assaultcube
    ```
    - Script sẽ tự động tải tất cả các công cụ cần thiết (`apktool`, `Android Build Tools`, `platform-tools`, `dexpatch`). Quá trình này có thể mất vài phút.
    - Sau khi hoàn tất, bạn sẽ có một tệp `base.apk` (hoặc `file.single.apk` nếu là split APK) trong thư mục `~/apk.sh`.

### 2.2. Tạo tệp cấu hình cho Frida Gadget

Để tránh lỗi ứng dụng không phản hồi (ANR), chúng ta cần cấu hình `frida-gadget` để không chặn luồng chính của ứng dụng khi khởi động.

1.  **Tạo tệp `config.json`:**
    Trong thư mục `~/apk.sh`, chạy lệnh sau để tạo và ghi nội dung vào tệp:
    ```bash
    echo '{"interaction": {"type": "listen", "on_load": "resume"}}' > config.json
    ```

### 2.3. Patch APK với `frida-gadget`

Đây là bước cốt lõi. Chúng ta sẽ sử dụng phương pháp vá bytecode trực tiếp để đảm bảo ổn định.

1.  **Đổi tên tệp APK (tùy chọn):**

    ```bash
    mv base.apk assaultcube.apk
    ```

2.  **Chạy lệnh `patch`:**
    ```bash
    ./apk.sh patch assaultcube.apk --arch arm64 -s --gadget-conf config.json
    ```
    - `--arch arm64`: Chỉ định kiến trúc CPU (hầu hết điện thoại hiện đại).
    - `-s`: **Quan trọng!** Kích hoạt chế độ vá bytecode trực tiếp, tránh lỗi khi giải nén/biên dịch lại Smali.
    - `--gadget-conf config.json`: Nhúng tệp cấu hình chúng ta vừa tạo vào APK.

### 2.4. Ký (Sign) tệp APK đã patch

Script `patch` sẽ tạo ra tệp `assaultcube.gadget.apk`. Chúng ta cần ký nó.

1.  **Chạy lệnh `sign`:**
    ```bash
    ./apk.sh sign assaultcube.gadget.apk
    ```
    - **Ghi chú lỗi:** Nếu bạn gặp lỗi `INSTALL_PARSE_FAILED_NO_CERTIFICATES` khi cài đặt, điều đó có nghĩa là bạn đã quên bước này.

## Phần 3: Cài đặt và Chạy Cheat

### 3.1. Cài đặt ứng dụng đã patch

1.  **Gỡ thiết bị khỏi WSL:**
    Trong **PowerShell (Admin)**, chạy:

    ```powershell
    usbipd detach --busid <BUSID>
    ```

2.  **Sao chép APK ra Windows:**
    Trong **WSL**:

    ```bash
    cp assaultcube.gadget.apk /mnt/c/Users/tomis/Documents/
    ```

3.  **Cài đặt lên điện thoại:**
    Trong **CMD** trên Windows:
    ```cmd
    adb uninstall net.cubers.assaultcube
    adb install "C:\Users\tomis\Documents\assaultcube.gadget.apk"
    ```

### 3.2. Kiểm tra và chạy Cheat

1.  **Mở ứng dụng** Assault Cube đã cài đặt trên điện thoại.
2.  **Kiểm tra kết nối Frida (Rất quan trọng):**
    Trên máy tính (CMD), chạy:

    ```cmd
    frida-ps -Uai
    ```

    Tìm dòng `AssaultCube` trong danh sách. Nếu bạn thấy **biểu tượng viên thuốc 💊** và một **PID** hợp lệ, bạn đã thành công.

3.  **Tạo và chạy script `s1.js`:**
    - Chuẩn bị tệp script `s1.js` với logic God Mode như trong video.
    - Chạy lệnh sau để tiêm cheat vào game đang chạy:
      ```cmd
      frida -U "AssaultCube" -l s1.js
      ```

Bây giờ, bạn có thể vào game và tận hưởng chế độ bất tử
