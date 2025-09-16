import os
import sys

def find_keywords_in_dump(dump_file, keyword, output_file):
    """
    Đọc một tệp dump.cs, tìm tất cả các dòng chứa từ khóa và ghi ra tệp output.
    """
    print(f"\n[INFO] Đang mở tệp: {dump_file}")
    
    # Kiểm tra xem tệp dump có tồn tại không
    if not os.path.exists(dump_file):
        print(f"[LỖI] Không tìm thấy tệp '{dump_file}'. Hãy chắc chắn bạn đã đặt tệp này vào cùng thư mục với script.")
        return

    try:
        # Mở tệp dump để đọc và tệp output để ghi
        with open(dump_file, 'r', encoding='utf-8') as f_in, \
             open(output_file, 'w', encoding='utf-8') as f_out:
            
            print(f"[INFO] Đang tìm kiếm từ khóa '{keyword}'...")
            
            found_count = 0
            # Đọc từng dòng trong tệp dump.cs
            for line_num, line in enumerate(f_in, 1):
                # Kiểm tra xem từ khóa có trong dòng hiện tại không (không phân biệt hoa/thường)
                if keyword.lower() in line.lower():
                    # Ghi dòng tìm thấy vào tệp output, kèm theo số dòng
                    f_out.write(f"Dòng {line_num}: {line.strip()}\n")
                    found_count += 1
            
            if found_count > 0:
                print(f"\n[THÀNH CÔNG] Đã tìm thấy {found_count} kết quả.")
                print(f"[INFO] Kết quả đã được lưu vào tệp: '{output_file}'")
            else:
                print(f"\n[INFO] Không tìm thấy kết quả nào cho từ khóa '{keyword}'.")
                # Xóa tệp output nếu không có kết quả
                os.remove(output_file)

    except Exception as e:
        print(f"[LỖI] Đã xảy ra lỗi trong quá trình xử lý: {e}")

def main():
    """
    Hàm chính để chạy chương trình.
    """
    # Mặc định tên tệp dump và output
    dump_filename = r"C:\Users\tomis\Documents\FridaHackDocs\app_process64\3e0c463a53a41\GameUi.cs"
    output_filename = "ket_qua_tim_kiem.txt"

    print("--- CÔNG CỤ TÌM KIẾM HÀM TRONG DUMP.CS ---")

    # Kiểm tra xem có tệp dump.cs trong thư mục hiện tại không
    if not os.path.exists(dump_filename):
        print(f"\n[CẢNH BÁO] Không tìm thấy tệp '{dump_filename}' trong thư mục này.")
        dump_filename = input("Vui lòng nhập tên tệp dump (ví dụ: dump.cs): ")

    # Lấy từ khóa từ người dùng
    search_keyword = input("Nhập tên hàm hoặc từ khóa bạn muốn tìm (ví dụ: AddFishcake, Currency): ")

    if not search_keyword:
        print("[LỖI] Bạn chưa nhập từ khóa. Chương trình sẽ thoát.")
        sys.exit(1)

    find_keywords_in_dump(dump_filename, search_keyword, output_filename)
    
    print("\nChương trình đã kết thúc.")
    input("Nhấn Enter để thoát...")

if __name__ == "__main__":
    main()