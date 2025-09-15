import frida
import sys
import time
from pathlib import Path

# --- CẤU HÌNH ---
TARGET_APP = "Chuyện Công Chúa"
LOG_FILE = Path.home() / "api_map.log"
# ----------------

# Dùng một biến toàn cục để lưu lại API call gần nhất
last_api_call = "[No API Call yet]"

def on_message(script_name):
    """Tạo một hàm callback riêng cho mỗi script để phân biệt log."""
    def process_message(message, data):
        global last_api_call
        if message['type'] == 'send':
            payload = message['payload']
            msg_type = payload.get('type')
            
            if msg_type == 'il2cpp':
                api_name = payload.get('apiName', 'Unknown API')
                log_text = f"\n[IL2CPP] ---> API Call: {api_name}"
                log_and_print(log_text, "header")
                last_api_call = api_name # Lưu lại
                
            elif msg_type == 'stalker':
                direction = payload.get('direction', 'data')
                length = payload.get('length', 0)
                # Dữ liệu được gửi dưới dạng list các số, cần chuyển lại thành bytes
                raw_data = bytes(payload['data']) if 'data' in payload else b''
                
                log_text = f"[STALKER] Raw Packet Sent (Corresponds to: {last_api_call})"
                log_and_print(log_text, "stalker")
                
                # In hexdump
                hexdump_log = hexdump(raw_data)
                log_and_print(hexdump_log)

    return process_message

def log_and_print(text, level="info"):
    """In và ghi log."""
    colors = {
        "header": "\033[95m", # Màu tím
        "stalker": "\033[94m", # Màu xanh dương
        "info": "\033[92m",
        "error": "\033[91m",
        "endc": "\033[0m",
    }
    color = colors.get(level, "")
    print(f"{color}{text}{colors['endc']}")
    with open(LOG_FILE, "a", encoding="utf-8") as f:
        f.write(text + "\n")

def hexdump(src, length=16):
    """Tạo hexdump từ bytes."""
    FILTER = ''.join([(len(repr(chr(x))) == 3) and chr(x) or '.' for x in range(256)])
    lines = []
    for c in range(0, len(src), length):
        chars = src[c:c+length]
        hex_part = ' '.join(["%02x" % x for x in chars])
        printable_part = ''.join(["%s" % ((x <= 127 and FILTER[x]) or '.') for x in chars])
        lines.append("%04x  %-*s  %s" % (c, length*3, hex_part, printable_part))
    return '\n'.join(lines)
    
def main():
    if Path(LOG_FILE).exists():
        Path(LOG_FILE).unlink()
        
    log_and_print(f"Starting Ultimate API Mapper for '{TARGET_APP}'...", "info")
    log_and_print(f"Log will be saved to: '{LOG_FILE}'", "info")

    session = None
    try:
        device = frida.get_usb_device(timeout=5)
        print(f"Connected to device: {device.name}")
        
        print(f"Attaching to '{TARGET_APP}'...")
        session = device.attach(TARGET_APP)
        
        # Tiêm script Stalker
        with open("stalker_spy_final.js", "r", encoding="utf-8") as f:
            stalker_code = f.read()
        stalker_script = session.create_script(stalker_code)
        stalker_script.on('message', on_message("Stalker"))
        stalker_script.load()
        print("[+] Stalker script injected.")
        
        # Tiêm script Il2Cpp
        with open("compiled_il2cpp_logger.js", "r", encoding="utf-8") as f:
            il2cpp_code = f.read()
        il2cpp_script = session.create_script(il2cpp_code)
        il2cpp_script.on('message', on_message("Il2Cpp"))
        il2cpp_script.load()
        print("[+] Il2Cpp logger injected.")
        
        print("\n[OK] Both scripts are active. Play the game.")
        print("[+] Press Ctrl+C to exit.")
        sys.stdin.read()

    except Exception as e:
        print(f"\033[91mAn error occurred: {e}\033[0m")
    finally:
        print("\nDetaching and exiting...")
        if session:
            session.detach()

if __name__ == '__main__':
    main()