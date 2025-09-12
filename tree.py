import os

def export_tree(startpath, output_file):
    with open(output_file, 'w', encoding='utf-8') as f:
        for root, dirs, files in os.walk(startpath):
            level = root.replace(startpath, '').count(os.sep)
            indent = ' ' * 4 * level
            f.write(f'{indent}{os.path.basename(root)}/\n')
            subindent = ' ' * 4 * (level + 1)
            for file in files:
                f.write(f'{subindent}{file}\n')

# Sử dụng với thư mục exize.tapas.girlAdrift
export_tree(r'C:\Users\tomis\Documents\APK Easy Tool v1.60 Portable\1-Decompiled APKs\mwr', 'directory_tree_with_files.txt')
