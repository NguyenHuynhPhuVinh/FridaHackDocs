import os

# === CÀI ĐẶT ===
input_file = "VietnameseFont.ttf"
output_file = "VietnameseFont.h"
array_name = "VietnameseFont_ttf"
# ===============

try:
    with open(input_file, 'rb') as f_in:
        font_data = f_in.read()

    with open(output_file, 'w') as f_out:
        f_out.write(f"// Font data for {os.path.basename(input_file)}\n")
        f_out.write(f"// Size: {len(font_data)} bytes\n")
        
        # Viết độ dài của mảng
        f_out.write(f"const unsigned int {array_name}_len = {len(font_data)};\n\n")
        
        # Viết mảng dữ liệu
        f_out.write(f"const unsigned char {array_name}[] = {{\n    ")
        
        line_len = 0
        for i, byte in enumerate(font_data):
            hex_val = f"0x{byte:02x},"
            f_out.write(hex_val)
            line_len += len(hex_val)
            
            if line_len > 80: # Ngắt dòng cho dễ nhìn
                f_out.write("\n    ")
                line_len = 0
            else:
                f_out.write(" ")

        f_out.write("\n};\n")

    print(f"Successfully converted '{input_file}' to '{output_file}'")

except FileNotFoundError:
    print(f"Error: Input file '{input_file}' not found.")
except Exception as e:
    print(f"An error occurred: {e}")