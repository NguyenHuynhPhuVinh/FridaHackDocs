import frida
import sys
import time
import json
import os
import colorama

colorama.init(autoreset=True)

ENGLISH_DUMP_FILE = "game_texts_en.json"
VIETNAMESE_TRANS_FILE = "translations_vi.json"

script = None
session = None
newly_found_strings = {}
should_exit = False

def load_json_file(filename, description):
    if os.path.exists(filename):
        try:
            with open(filename, "r", encoding="utf-8") as f:
                print(f"[*] Đang đọc {description} từ '{filename}'...")
                return json.load(f)
        except json.JSONDecodeError:
            print(f"{colorama.Fore.YELLOW}[CẢNH BÁO] File '{filename}' bị lỗi. Sẽ tạo file mới.")
            return {}
    print(f"[*] Không tìm thấy file '{filename}'. Sẽ tạo file mới.")
    return {}

def save_json_file(filename, data, description):
    try:
        with open(filename, "w", encoding="utf-8") as f:
            json.dump(data, f, ensure_ascii=False, indent=2, sort_keys=True)
        print(f"{colorama.Fore.GREEN}[SUCCESS] Đã lưu {description} vào '{filename}'")
    except Exception as e:
        print(f"{colorama.Fore.RED}[LỖI] Không thể lưu file '{filename}': {e}")

def on_message(message, data):
    global should_exit, newly_found_strings
    if message['type'] == 'send' and message['payload'].get('type') == 'dump_result':
        count = message['payload'].get('count', 0)
        print(f"\n[+] Nhận được {count} chuỗi mới từ Frida.")
        newly_found_strings = message['payload'].get('payload', {})
        should_exit = True
    elif message['type'] == 'error':
         print(f"{colorama.Fore.RED}[Lỗi Frida] {message['description']}")


def main(target_process):
    global script, session
    
    english_data = load_json_file(ENGLISH_DUMP_FILE, "văn bản gốc")
    vietnamese_data = load_json_file(VIETNAMESE_TRANS_FILE, "bản dịch Việt hóa")
    
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
        
        # Gửi bản dịch đã có cho agent
        script.exports_sync.initialize(vietnamese_data)

        print(f"{colorama.Fore.CYAN}[*] Đã inject thành công. Game hiện đang được Việt hóa.")
        print(f"{colorama.Fore.CYAN}[*] Chơi game để tìm các chuỗi văn bản mới chưa được dịch.")
        print(f"{colorama.Fore.YELLOW}[*] Khi xong, nhấn Ctrl+C ở đây để LƯU và XEM các chuỗi cần dịch.")
        sys.stdin.read()

    except KeyboardInterrupt:
        print("\n[*] Đã nhận tín hiệu dừng. Yêu cầu lưu dữ liệu mới...")
    except Exception as e:
        print(f"{colorama.Fore.RED}[Lỗi] {e}")
    finally:
        if script and not script.is_destroyed:
            script.exports_sync.get_new_strings()
            timeout = 5
            while not should_exit and timeout > 0:
                time.sleep(0.5)
                timeout -= 0.5
        
        # Cập nhật và lưu file text gốc
        if newly_found_strings:
            english_data.update(newly_found_strings)
            save_json_file(ENGLISH_DUMP_FILE, english_data, "văn bản gốc")

        # So sánh và hiển thị các chuỗi mới cần dịch
        print("\n" + "="*50)
        print("CÁC CHUỖI MỚI CẦN DỊCH:")
        print("="*50)
        
        new_keys_to_translate = 0
        for key, value in english_data.items():
            if key not in vietnamese_data:
                print(f"{colorama.Fore.YELLOW}\"{key}\": \"{value}\",")
                new_keys_to_translate += 1
        
        if new_keys_to_translate == 0:
            print(f"{colorama.Fore.GREEN}Không có chuỗi mới nào cần dịch. Bản dịch đã đầy đủ!")
        else:
            print(f"\n{colorama.Fore.YELLOW}Gợi ý: Copy {new_keys_to_translate} cặp key-value ở trên và dán vào file '{VIETNAMESE_TRANS_FILE}', sau đó dịch chúng.")

        print("="*50)
        
        if session:
            session.detach()
        print("[*] Hoàn tất.")

if __name__ == '__main__':
    if len(sys.argv) < 2:
        print(f"Sử dụng: python {sys.argv[0]} <tên_tiến_trình>")
        sys.exit(1)
    main(sys.argv[1])