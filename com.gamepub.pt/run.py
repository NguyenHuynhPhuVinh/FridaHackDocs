import frida
import sys
from pathlib import Path

# --- CẤU HÌNH ---
TARGET_APP = "Chuyện Công Chúa" 
LOG_FILE = Path.home() / "grpc_exports.log"
# ----------------

def on_message(message, data):
    """Hàm callback để xử lý message từ script JavaScript."""
    if message['type'] == 'send':
        payload = message['payload']
        status = payload.get('status', 'unknown')
        
        if status == 'error' or status == 'info' or status == 'done':
            log_and_print(payload['message'], status)
        elif status == 'export_item':
            # Nhận từng item và ghi ngay vào file
            exp = payload['data']
            log_text = f"    - {exp['type']}: {exp['name']} (Address: {exp['address']})"
            # Chỉ ghi vào file, không in ra console để tránh spam
            with open(LOG_FILE, "a", encoding="utf-8") as f:
                f.write(log_text + "\n")
        else:
            log_and_print(str(payload))

    elif message['type'] == 'error':
        log_and_print(f"JAVASCRIPT ERROR: {message['stack']}", "error")

def log_and_print(text, level="info"):
    """In ra console và ghi vào file log."""
    colors = {
        "info": "\033[92m",
        "error": "\033[91m",
        "done": "\033[95m",
        "endc": "\033[0m",
    }
    
    color = colors.get(level, colors["info"])
    print(f"{color}{text}{colors['endc']}")
    
    with open(LOG_FILE, "a", encoding="utf-8") as f:
        f.write(text + "\n")
        
def main():
    if Path(LOG_FILE).exists():
        Path(LOG_FILE).unlink()
        
    log_and_print(f"Starting gRPC export scanner (v2) for '{TARGET_APP}'...", "info")
    log_and_print(f"Log will be saved to '{LOG_FILE}'", "info")

    session = None
    try:
        device = frida.get_usb_device(timeout=5)
        print(f"Connected to device: {device.name}")
        
        print(f"Attaching to '{TARGET_APP}'...")
        session = device.attach(TARGET_APP)
        
        script_path = Path("compiled-hack-server-time.js")
        if not script_path.exists():
            print(f"\033[91mERROR: agent.js not found.\033[0m")
            return
            
        with open(script_path, "r", encoding="utf-8") as f:
            jscode = f.read()
            
        script = session.create_script(jscode)
        script.on('message', on_message)
        script.load()
        
        print("\n[+] Script loaded. Waiting for messages...")
        print("[+] Press Ctrl+C to exit when you see the 'Finished' message.")
        
        sys.stdin.read()

    except Exception as e:
        print(f"\033[91mAn error occurred: {e}\033[0m")
    finally:
        print("\nDetaching and exiting...")
        if session:
            session.detach()

if __name__ == '__main__':
    main()