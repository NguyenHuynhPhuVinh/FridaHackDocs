import frida
import sys
import time

def on_message(message, data):
    if message['type'] == 'error':
        print(f"[Lỗi Frida] {message['description']}")

def main(target_process):
    session = None
    try:
        print(f"[*] Đang kết nối với '{target_process}'...")
        device = frida.get_usb_device(timeout=5)
        session = device.attach(target_process)
        
        with open("compiled-dump-text.js", "r", encoding="utf-8") as f:
            script_content = f.read()
            
        script = session.create_script(script_content)
        script.on('message', on_message)
        print("[*] Đang nạp script điều tra bộ nhớ...")
        script.load()
        
        print(f"[*] Đã inject thành công.")
        print("[*] Hướng dẫn:")
        print("    1. Trong game, hãy đi đến màn hình có chứa một từ tiếng Anh đơn giản (ví dụ: 'Shop', 'Setting').")
        print("    2. Quay lại đây, gõ từ đó vào và nhấn Enter để bắt đầu quét.")
        print("    3. Gõ 'exit' để thoát.")

        while True:
            text_to_find = input("\nNhập chuỗi cần tìm trong bộ nhớ (hoặc 'exit'): ").strip()
            if text_to_find.lower() == 'exit':
                break
            if text_to_find:
                script.exports_sync.scan(text_to_find)
            
    except frida.ProcessNotFoundError:
        print(f"[Lỗi] Không tìm thấy tiến trình '{target_process}'. Bạn đã mở game chưa?")
    except Exception as e:
        print(f"[Lỗi] {e}")
    finally:
        print("\n[*] Đang thoát...")
        if session:
            session.detach()

if __name__ == '__main__':
    if len(sys.argv) < 2:
        print(f"Sử dụng: python {sys.argv[0]} <tên_tiến_trình>")
        sys.exit(1)
    main(sys.argv[1])