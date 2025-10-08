import os

# Path to the file to split
file_path = "part1.cs"
# Read all lines from the file
with open(file_path, 'r', encoding='utf-8') as f:
    lines = f.readlines()

# Calculate the midpoint
mid = len(lines) // 2

# Write the first half to part1.cs
with open('part11.cs', 'w', encoding='utf-8') as f:
    f.writelines(lines[:mid])

# Write the second half to part2.cs
with open('part12.cs', 'w', encoding='utf-8') as f:
    f.writelines(lines[mid:])

print("File split into part1.cs and part2.cs")