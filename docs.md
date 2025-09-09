## Hướng dẫn Hack Game Android (Assault Cube) trên Thiết bị Chưa Root từ A-Z

**Mục tiêu:** Tạo cheat "God Mode" (Bất tử) cho game Assault Cube trên điện thoại Android chưa root, sử dụng Frida.

**Đối tượng:** Người dùng laptop Windows mới, chưa có kinh nghiệm.

### Phần I: Chuẩn bị Môi trường trên Laptop Windows

Đây là phần nền tảng, thiết lập tất cả các công cụ cần thiết.

#### Bước 1: Kích hoạt Chế độ Nhà phát triển trên Windows

1.  Nhấn phím **Windows**, gõ `Developer settings` và mở nó lên.
2.  Bật tùy chọn **Developer Mode**.

#### Bước 2: Cài đặt Windows Subsystem for Linux (WSL)

WSL cho phép bạn chạy một môi trường Linux đầy đủ ngay trên Windows. Đây là công cụ cốt lõi.

1.  Nhấn phím **Windows**, gõ `PowerShell`.
2.  Nhấn chuột phải vào **Windows PowerShell** và chọn **Run as administrator**.
3.  Trong cửa sổ PowerShell hiện ra, gõ lệnh sau và nhấn Enter:
    ```powershell
    wsl --install
    ```
4.  Máy tính sẽ tự động tải và cài đặt Ubuntu. Sau khi hoàn tất, **hãy khởi động lại máy tính của bạn.**
5.  Sau khi khởi động lại, mở Start Menu, tìm và chạy ứng dụng **Ubuntu**. Lần đầu tiên chạy, nó sẽ yêu cầu bạn tạo một **username** và **password** cho môi trường Linux. Hãy ghi nhớ chúng.

#### Bước 3: Cài đặt và Cấu hình Công cụ USB (`usbipd`)

Công cụ này cho phép WSL "nhìn thấy" các thiết bị USB được cắm vào máy tính.

1.  Mở lại **PowerShell** với quyền **Administrator**.
2.  Chạy lệnh sau để cài đặt `usbipd-win`:
    ```powershell
    winget install --interactive --exact dorssel.usbipd-win
    ```
    Một trình cài đặt đồ họa sẽ hiện ra, hãy làm theo các bước để hoàn tất.

#### Bước 4: Cài đặt Python và Frida trên Windows

Chúng ta sẽ dùng Python và Frida trên Windows để điều khiển quá trình hack.

1.  **Cài đặt Python:**

    - Truy cập [python.org](https://www.python.org/downloads/) và tải về phiên bản Python mới nhất.
    - Chạy tệp cài đặt. **Quan trọng:** Ở màn hình cài đặt đầu tiên, hãy đánh dấu vào ô **"Add Python to PATH"**.
    - Hoàn tất quá trình cài đặt.

2.  **Cài đặt Frida-tools:**
    - Nhấn phím **Windows**, gõ `cmd` và mở **Command Prompt**.
    - Chạy lệnh sau để cài đặt Frida:
      ```cmd
      pip install frida-tools
      ```

#### Bước 5: Cài đặt Android Platform Tools (ADB) trên Windows

ADB là cầu nối giao tiếp giữa máy tính và điện thoại.

1.  Truy cập trang web chính thức của Android: [SDK Platform Tools](https://developer.android.com/tools/sdk/platform-tools).
2.  Tải về gói "SDK Platform Tools for Windows".
3.  Giải nén tệp `.zip` vào một vị trí dễ nhớ, ví dụ: `C:\platform-tools`.
4.  **Thêm thư mục này vào PATH của hệ thống:**
    - Nhấn phím Windows, gõ `environment variables`, chọn "Edit the system environment variables".
    - Nhấn "Environment Variables...".
    - Trong phần "System variables", tìm biến `Path`, chọn nó, nhấn "Edit...".
    - Nhấn "New", gõ vào đường dẫn `C:\platform-tools` và nhấn OK trên tất cả các cửa sổ.
    - **Đóng và mở lại tất cả các cửa sổ CMD/PowerShell** để thay đổi có hiệu lực.

### Phần II: Chuẩn bị Môi trường trên Điện thoại Android

1.  **Bật Tùy chọn Nhà phát triển:**

    - Vào **Settings (Cài đặt) -> About phone (Giới thiệu về điện thoại)**.
    - Tìm mục **Build number (Số bản dựng)** và nhấn vào nó **7 lần** cho đến khi có thông báo bạn đã là nhà phát triển.

2.  **Bật Gỡ lỗi USB:**

    - Vào **Settings -> System (Hệ thống) -> Developer options (Tùy chọn nhà phát triển)**.
    - Tìm và **bật** tùy chọn **USB debugging (Gỡ lỗi USB)**.

3.  **Cài đặt game Assault Cube:**
    - Tải tệp `assaultcube.xapk` về điện thoại.
    - Bạn có thể cần một ứng dụng cài đặt XAPK từ Google Play (ví dụ: "XAPK Installer") để cài đặt game.

### Phần III: Quy trình Hack Game

Bây giờ mọi thứ đã sẵn sàng, chúng ta sẽ bắt đầu quy trình hack.

#### Bước 1: Thiết lập môi trường trong WSL

1.  Mở terminal **Ubuntu** (WSL).
2.  Cài đặt các công cụ cần thiết cho WSL:

    ```bash
    sudo apt update
    sudo apt install git unzip openjdk-17-jdk dos2unix patchelf -y
    ```

3.  Clone dự án `apk.sh`:
    ```bash
    git clone https://github.com/ax/apk.sh.git
    cd apk.sh
    dos2unix apk.sh
    chmod +x apk.sh
    ```

#### Bước 2: Chia sẻ thiết bị và Kéo tệp APK

1.  Cắm điện thoại vào máy tính.
2.  Mở **PowerShell (Admin)** trên Windows.
3.  Liệt kê thiết bị và ghi lại **BUSID** của điện thoại:
    ```powershell
    usbipd list
    ```
4.  Chia sẻ thiết bị với WSL (thay `<BUSID>`):
    ```powershell
    adb kill-server
    usbipd bind --force --busid <BUSID>
    usbipd attach --wsl --busid <BUSID>
    ```
5.  Quay lại terminal **WSL**.
6.  Chạy lệnh `pull` để lấy tệp APK. `apk.sh` sẽ tự động cài đặt các công cụ còn thiếu của Android. Quá trình này có thể mất vài phút.
    ```bash
    ./apk.sh pull net.cubers.assaultcube
    ```
7.  Sau khi xong, bạn sẽ có tệp `base.apk` trong thư mục `~/apk.sh`.

#### Bước 3: Patch APK với Frida Gadget

1.  Trong **WSL**, đổi tên tệp APK:
    ```bash
    mv base.apk assaultcube.apk
    ```
2.  Tạo tệp cấu hình để tránh game bị treo:
    ```bash
    echo '{"interaction": {"type": "listen", "on_load": "resume"}}' > config.json
    ```
3.  Chạy lệnh `patch` tự động:
    ```bash
    ./apk.sh patch assaultcube.apk --arch arm64 -s --gadget-conf config.json
    ```
4.  Ký lại tệp APK vừa được tạo:
    ```bash
    ./apk.sh sign assaultcube.gadget.apk
    ```

#### Bước 4: Cài đặt và Kiểm tra

1.  **Trả lại thiết bị cho Windows:**
    Trong **PowerShell (Admin)**:
    ```powershell
    usbipd detach --busid <BUSID>
    ```
2.  **Sao chép APK đã patch ra Windows:**
    Trong **WSL**:
    ```bash
    cp assaultcube.gadget.apk /mnt/c/Users/TênNgườiDùngCủaBạn/Documents/
    ```
3.  **Cài đặt lên điện thoại:**
    Trong **CMD** trên Windows:
    ```cmd
    adb uninstall net.cubers.assaultcube
    adb install "C:\Users\TênNgườiDùngCủaBạn\Documents\assaultcube.gadget.apk"
    ```
4.  **Mở game Assault Cube** trên điện thoại.
5.  **Kiểm tra xem Frida đã chạy chưa:**
    Trong **CMD**:
    ```cmd
    frida-ps -Uai
    ```
    Tìm dòng AssaultCube, bạn phải thấy **biểu tượng viên thuốc 💊** bên cạnh. Nếu thấy, bạn đã thành công.

#### Bước 5: Chạy Script Cheat

1.  Tạo một thư mục mới trên Desktop, ví dụ `AndroidCheat`.
2.  Bên trong thư mục đó, tạo 2 tệp:
    - **`loader.py`**: (Không cần thiết nếu dùng lệnh Frida trực tiếp, nhưng để tham khảo)
    - **`s1.js`**: Dán mã JavaScript từ video vào tệp này.
3.  Mở **CMD**, di chuyển đến thư mục `AndroidCheat`:
    ```cmd
    cd Desktop\AndroidCheat
    ```
4.  Chạy lệnh Frida để tiêm cheat:
    ```cmd
    frida -U "AssaultCube" -l s1.js
    ```
5.  Vào game, chơi một trận và bạn sẽ bất tử!

---

Bạn đã hoàn thành một quy trình khá phức tạp. Hãy kiên nhẫn và làm theo từng bước, bạn sẽ thành công
