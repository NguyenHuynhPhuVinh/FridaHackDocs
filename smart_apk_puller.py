import subprocess
import os
import argparse
import urllib.request
import shutil
import xml.etree.ElementTree as ET
import sys

# --- CẤU HÌNH ---
APKTOOL_VERSION = "2.9.3"
APKTOOL_JAR_NAME = f"apktool_{APKTOOL_VERSION}.jar"
TOOLS_DIR = os.path.join(os.path.dirname(os.path.realpath(__file__)), "tools")

# --- CÁC HÀM TIỆN ÍCH ---
def run_command(command, cwd=None):
    """Chạy một lệnh và in output, thoát nếu có lỗi."""
    print(f"\n[EXEC] {' '.join(command)}")
    try:
        process = subprocess.Popen(command, stdout=subprocess.PIPE, stderr=subprocess.STDOUT, text=True, encoding='utf-8', errors='replace', cwd=cwd)
        for line in iter(process.stdout.readline, ''):
            sys.stdout.write(line)
        process.wait()
        if process.returncode != 0:
            print(f"\n[!!!] Lệnh thất bại với mã lỗi: {process.returncode}")
            sys.exit(1)
    except FileNotFoundError:
        print(f"[!!!] Lỗi: Không tìm thấy lệnh '{command[0]}'. Hãy đảm bảo nó đã được cài đặt và có trong PATH.")
        sys.exit(1)
    except Exception as e:
        print(f"[!!!] Một lỗi không xác định đã xảy ra: {e}")
        sys.exit(1)

def download_file(url, path):
    """Tải file từ URL."""
    print(f"[*] Đang tải {os.path.basename(path)} từ {url}...")
    try:
        with urllib.request.urlopen(url) as response, open(path, 'wb') as out_file:
            shutil.copyfileobj(response, out_file)
        print(f"[+] Tải thành công!")
    except Exception as e:
        print(f"[!!!] Tải thất bại: {e}")
        sys.exit(1)

def setup_apktool():
    """Kiểm tra và tải Apktool nếu cần."""
    os.makedirs(TOOLS_DIR, exist_ok=True)
    apktool_path = os.path.join(TOOLS_DIR, APKTOOL_JAR_NAME)
    if not os.path.exists(apktool_path):
        print("[!] Không tìm thấy Apktool.")
        download_file(f"https://github.com/iBotPeaches/Apktool/releases/download/v{APKTOOL_VERSION}/{APKTOOL_JAR_NAME}", apktool_path)
    return apktool_path
    
def patch_manifest(manifest_path):
    """Sửa AndroidManifest.xml để vô hiệu hóa split."""
    print(f"[*] Đang sửa file Manifest: {manifest_path}")
    try:
        ET.register_namespace('android', "http://schemas.android.com/apk/res/android")
        tree = ET.parse(manifest_path)
        root = tree.getroot()
        application_node = root.find('application')
        
        if application_node is not None:
            # Sửa các thuộc tính nếu có
            android_ns = {'android': "http://schemas.android.com/apk/res/android"}
            if application_node.get('{http://schemas.android.com/apk/res/android}isSplitRequired') == 'true':
                application_node.set('{http://schemas.android.com/apk/res/android}isSplitRequired', 'false')
                print("    - Đã đổi isSplitRequired thành 'false'")

            # Tìm và sửa meta-data
            meta_data_node = application_node.find('meta-data[@android:name="com.android.vending.splits.required"]', android_ns)
            if meta_data_node is not None and meta_data_node.get('{http://schemas.android.com/apk/res/android}value') == 'true':
                 meta_data_node.set('{http://schemas.android.com/apk/res/android}value', 'false')
                 print("    - Đã đổi meta-data com.android.vending.splits.required thành 'false'")
            
            tree.write(manifest_path, encoding='utf-8', xml_declaration=True)
            print("[+] Sửa Manifest thành công.")
        else:
            print("[!] Không tìm thấy thẻ <application> trong Manifest.")

    except Exception as e:
        print(f"[!!!] Sửa Manifest thất bại: {e}")
        sys.exit(1)

# --- HÀM CHÍNH ---
def smart_pull_and_merge(device_id, package_name):
    print("--- BẮT ĐẦU QUY TRÌNH PULL & MERGE ---")
    apktool_path = setup_apktool()
    
    # 1. Lấy đường dẫn các file split APK
    print(f"\n[1/5] Tìm kiếm các file split APK cho '{package_name}'...")
    try:
        result = subprocess.run(["adb", "-s", device_id, "shell", "pm", "path", package_name], capture_output=True, text=True, check=True, encoding='utf-8')
        apk_paths = [path.replace("package:", "").strip() for path in result.stdout.strip().splitlines() if path]
        print(f"[+] Tìm thấy {len(apk_paths)} file split APK.")
    except Exception as e:
        print(f"[!!!] Lỗi khi tìm kiếm APK: {e}")
        return

    # 2. Kéo tất cả các file về thư mục tạm
    temp_dir = f"{package_name}_temp"
    if os.path.exists(temp_dir): shutil.rmtree(temp_dir)
    os.makedirs(temp_dir)
    print(f"\n[2/5] Kéo các file APK về thư mục tạm '{temp_dir}'...")
    for path in apk_paths:
        run_command(["adb", "-s", device_id, "pull", path, temp_dir])
    
    # 3. Giải nén tất cả các file APK (chế độ không dịch ngược code cho nhanh)
    print(f"\n[3/5] Giải nén tất cả các file split APK bằng Apktool...")
    extracted_dirs = []
    base_dir = ""
    for apk_file in os.listdir(temp_dir):
        apk_path = os.path.join(temp_dir, apk_file)
        output_dir = os.path.join(temp_dir, apk_file.replace('.apk', ''))
        extracted_dirs.append(output_dir)
        if "base" in apk_file:
            base_dir = output_dir
        # Dùng -s (no-source) để chỉ giải nén tài nguyên, nhanh hơn
        run_command(["java", "-jar", apktool_path, "d", "-f", "-s", apk_path, "-o", output_dir])
        
    if not base_dir:
        print("[!!!] Không tìm thấy thư mục 'base' sau khi giải nén. Dừng lại.")
        return

    # 4. Hợp nhất các thư mục đã giải nén vào thư mục 'base'
    print(f"\n[4/5] Hợp nhất các file vào thư mục '{os.path.basename(base_dir)}'...")
    for dir_path in extracted_dirs:
        if dir_path == base_dir:
            continue
        print(f"    - Hợp nhất từ '{os.path.basename(dir_path)}'")
        shutil.copytree(dir_path, base_dir, dirs_exist_ok=True)
    
    # Sửa AndroidManifest.xml
    patch_manifest(os.path.join(base_dir, "AndroidManifest.xml"))
    
    # 5. Đóng gói lại thành file APK cuối cùng (chưa ký)
    output_apk_name = f"{package_name}.full.unsigned.apk"
    final_apk_path = os.path.join(os.path.dirname(os.path.realpath(__file__)), output_apk_name)
    
    print(f"\n[5/5] Đóng gói lại thành file '{output_apk_name}'...")
    run_command(["java", "-jar", apktool_path, "b", base_dir, "-o", final_apk_path])
    
    # Dọn dẹp
    shutil.rmtree(temp_dir)
    
    print("\n--- HOÀN TẤT ---")
    print(f"[SUCCESS] File APK hoàn chỉnh (CHƯA KÝ) đã được tạo tại: {final_apk_path}")

# --- PHÂN TÍCH THAM SỐ DÒNG LỆNH ---
if __name__ == "__main__":
    parser = argparse.ArgumentParser(description="Tự động kéo và hợp nhất các file split APK từ một thiết bị Android.")
    parser.add_argument("-s", "--serial", required=True, help="ID của thiết bị (từ 'adb devices')")
    parser.add_argument("-p", "--package", required=True, help="Tên package của ứng dụng cần kéo")
    args = parser.parse_args()
    
    smart_pull_and_merge(args.serial, args.package)