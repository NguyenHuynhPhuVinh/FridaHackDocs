import subprocess
import sys
import datetime

def save_log_file(lines, package_name):
    """Lưu các dòng log vào một file với timestamp."""
    if not lines:
        print("\n[INFO] Không có dòng log nào được ghi lại. Không tạo file.")
        return

    # Tạo tên file duy nhất dựa vào ngày giờ
    timestamp = datetime.datetime.now().strftime('%Y-%m-%d_%H-%M-%S')
    filename = f"log_{package_name}_{timestamp}.txt"

    try:
        with open(filename, 'w', encoding='utf-8') as f:
            f.writelines(lines)
        print(f"\n[SUCCESS] Đã lưu thành công {len(lines)} dòng log vào file: {filename}")
    except IOError as e:
        print(f"\n[ERROR] Không thể ghi file: {e}")

def main():
    # Kiểm tra xem người dùng đã cung cấp tên package chưa
    if len(sys.argv) < 2:
        print("Sử dụng: python get_log.py <tên_package_của_game>")
        print("Ví dụ: python get_log.py com.gamepub.pt")
        sys.exit(1)

    package_name = sys.argv[1]
    log_lines = []
    process = None

    try:
        # Xóa bộ đệm logcat cũ để bắt đầu với log mới
        subprocess.run(['adb', 'logcat', '-c'], check=True)
        
        # Bắt đầu tiến trình adb logcat
        # stdout=subprocess.PIPE để chúng ta có thể đọc output của nó
        process = subprocess.Popen(['adb', 'logcat'], stdout=subprocess.PIPE, stderr=subprocess.PIPE, text=False)

        print(f"[*] Bắt đầu ghi log cho package: '{package_name}'")
        print("[*] Nhấn Ctrl+C để dừng và lưu file log.")
        print("-" * 50)

        # Đọc output từ logcat từng dòng một
        for line in iter(process.stdout.readline, b''):
            # Decode dòng byte thành string, bỏ qua các lỗi ký tự
            decoded_line = line.decode('utf-8', errors='ignore')

            # Nếu tên package có trong dòng log, xử lý nó
            if package_name in decoded_line:
                # In ra màn hình để theo dõi trực tiếp
                print(decoded_line, end='')
                # Thêm vào danh sách để lưu sau này
                log_lines.append(decoded_line)

    except FileNotFoundError:
        print("[ERROR] Lệnh 'adb' không được tìm thấy.")
        print("Hãy chắc chắn rằng bạn đã cài đặt Android SDK và thêm 'adb' vào biến môi trường PATH.")
    except subprocess.CalledProcessError:
         print("[ERROR] Lệnh 'adb' thất bại. Thiết bị đã được kết nối và bật USB Debugging chưa?")
    except KeyboardInterrupt:
        # Người dùng nhấn Ctrl+C, tiến hành lưu file
        print("\n[*] Đang dừng ghi log...")
        save_log_file(log_lines, package_name)
    except Exception as e:
        print(f"\n[ERROR] Đã có lỗi xảy ra: {e}")
    finally:
        # Dù có lỗi hay không, luôn đảm bảo tiến trình adb được đóng lại
        if process:
            process.terminate()

if __name__ == "__main__":
    main()