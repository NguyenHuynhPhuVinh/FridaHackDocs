# Import các thư viện cần thiết
from mitmproxy import http
import os

# ==================== PHẦN CÀI ĐẶT ====================

# 1. ĐƯỜNG DẪN ĐẾN FILE GAME ĐÃ MOD
#    Hãy thay đổi dòng này thành đường dẫn chính xác đến file index_mod.js của bạn.
#    Lưu ý: Luôn dùng dấu gạch chéo tới (/) cho đường dẫn.
#    Ví dụ: "C:/Users/Tomis/Desktop/GameMod/index_mod.js"
PATH_TO_MODDED_FILE = "C:/Users/tomis/Documents/FridaHackDocs/index.js"

# 2. MỘT PHẦN CỦA URL FILE GAME GỐC CẦN THAY THẾ
#    Dựa trên log, đây là chuỗi chính xác nhất.
TARGET_URL_PART = "assets/main/index.js"

# ======================================================


# Hàm này được gọi khi một client (điện thoại) kết nối tới proxy
def client_connected(client):
    print(f"[CONNECTION] Client da ket noi: {client.peername}")

def request(flow: http.HTTPFlow) -> None:
    if TARGET_URL_PART in flow.request.pretty_url:
        print(f"[*] >>> Đã chặn request đến file logic game: {flow.request.pretty_url}")
        # ... (phần còn lại của script giữ nguyên)
        if os.path.exists(PATH_TO_MODDED_FILE):
            try:
                with open(PATH_TO_MODDED_FILE, "rb") as f:
                    modded_content = f.read()
                flow.response = http.Response.make(
                    200,
                    modded_content,
                    {"Content-Type": "application/javascript;charset=UTF-8"}
                )
                print(f"[+] <<< THÀNH CÔNG: Đã thay thế bằng file mod.")
            except Exception as e:
                print(f"[!] <<< LỖI: Khong the doc file mod. Nguyen nhan: {e}")
        else:
            print(f"[!] <<< LỖI: Khong tim thay file mod tai duong dan da chi dinh.")