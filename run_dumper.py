import frida
import sys
import time
import json

def on_message(message, data):
    if message['type'] == 'send' and message['payload'].get('type') == 'dump_result':
        print("[+] Nhận được dữ liệu dump từ Frida.")
        with open("game_texts_en.json", "w", encoding="utf-8") as f:
            # Parse lại để đảm bảo format đẹp
            parsed_json = json.loads(message['payload']['payload'])
            json.dump(parsed_json, f, ensure_ascii=False, indent=2)
        print("[SUCCESS] Đã lưu thành công vào file 'game_texts_en.json'")
        # Dừng script sau khi lưu
        global should_exit
        should_exit = True

def main(target_process):
    session = None
    global should_exit
    should_exit = False
    try:
        print(f"[*] Đang kết nối với '{target_process}' để dump text...")
        device = frida.get_usb_device(timeout=5)
        session = device.attach(target_process)
        
        with open("compiled-dump-text.js", "r", encoding="utf-8") as f:
            script = session.create_script(f.read())
        
        script.on('message', on_message)
        script.load()
        print("[*] Script dump đã được nạp. Vui lòng chơi game trong khoảng 1-2 phút để thu thập text.")
        print("[*] Sau khi chơi xong, nhấn Enter ở đây để lưu file dump.")
        input() # Chờ người dùng nhấn Enter
        
        script.exports_sync.save_dump()

        # Đợi tín hiệu từ on_message để thoát
        while not should_exit:
            time.sleep(0.1)

    except Exception as e:
        print(f"[Lỗi] {e}")
    finally:
        if session:
            session.detach()
        print("[*] Hoàn tất.")

if __name__ == '__main__':
    if len(sys.argv) < 2:
        print(f"Sử dụng: python {sys.argv[0]} <tên_tiến_trình>")
        sys.exit(1)
    main(sys.argv[1])