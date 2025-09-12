import frida
import sys
import time
import json
import os

DUMP_FILE = "game_texts_en.json"
script = None
session = None
newly_found_strings = {}
should_exit = False

def load_existing_data():
    if os.path.exists(DUMP_FILE):
        try:
            with open(DUMP_FILE, "r", encoding="utf-8") as f:
                print(f"[*] Đã tìm thấy file '{DUMP_FILE}', đang đọc dữ liệu cũ...")
                return json.load(f)
        except json.JSONDecodeError:
            print(f"[CẢNH BÁO] File '{DUMP_FILE}' bị lỗi. Sẽ tạo file mới.")
            return {}
    print(f"[*] Không tìm thấy file '{DUMP_FILE}'. Sẽ tạo file mới.")
    return {}

def save_data(all_data):
    try:
        with open(DUMP_FILE, "w", encoding="utf-8") as f:
            json.dump(all_data, f, ensure_ascii=False, indent=2, sort_keys=True)
        print(f"\n[SUCCESS] Đã cập nhật và lưu thành công {len(all_data)} chuỗi vào '{DUMP_FILE}'")
    except Exception as e:
        print(f"[LỖI] Không thể lưu file: {e}")

def on_message(message, data):
    global should_exit, newly_found_strings
    if message['type'] == 'send' and message['payload'].get('type') == 'dump_result':
        count = message['payload'].get('count', 0)
        print(f"[+] Nhận được {count} chuỗi mới từ Frida.")
        newly_found_strings = message['payload'].get('payload', {})
        should_exit = True

def main(target_process):
    global script, session
    
    existing_data = load_existing_data()
    
    try:
        print(f"[*] Đang cố gắng kết nối với '{target_process}'...")
        device = frida.get_usb_device(timeout=5)
        session = device.attach(target_process)
        
        with open("compiled-dump-text.js", "r", encoding="utf-8") as f:
            script_content = f.read()
            
        script = session.create_script(script_content)
        script.on('message', on_message)
        print("[*] Đang nạp script agent...")
        script.load()
        
        # Gửi các key đã biết cho agent
        script.exports_sync.initialize(list(existing_data.keys()))

        print(f"[*] Đã kết nối và nạp script thành công.")
        print("[*] Hãy chơi game để tìm các chuỗi văn bản mới.")
        print("[*] Khi xong, nhấn Ctrl+C ở đây để LƯU và THOÁT.")
        sys.stdin.read()

    except KeyboardInterrupt:
        print("\n[*] Đã nhận tín hiệu dừng. Yêu cầu lưu dữ liệu từ agent...")
    except frida.ProcessNotFoundError:
        print(f"[Lỗi] Không tìm thấy tiến trình '{target_process}'. Bạn đã mở game chưa?")
    except Exception as e:
        print(f"[Lỗi] {e}")
    finally:
        if script and not script.is_destroyed:
            script.exports_sync.get_new_strings()
            # Đợi on_message xử lý
            timeout = 5
            while not should_exit and timeout > 0:
                time.sleep(0.5)
                timeout -= 0.5
        
        # Cập nhật và lưu lại file
        existing_data.update(newly_found_strings)
        save_data(existing_data)
        
        if session:
            session.detach()
        print("[*] Hoàn tất.")

if __name__ == '__main__':
    if len(sys.argv) < 2:
        print(f"Sử dụng: python {sys.argv[0]} <tên_tiến_trình>")
        sys.exit(1)
    main(sys.argv[1])