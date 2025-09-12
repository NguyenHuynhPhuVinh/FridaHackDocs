import "frida-il2cpp-bridge";

console.log("[*] Bắt đầu AGENT ĐIỀU TRA BỘ NHỚ...");

// Hàm để quét bộ nhớ tìm một chuỗi và các con trỏ trỏ đến nó
function findStringAndReferences(textToFind) {
  console.log(`\n[*] Bắt đầu quét bộ nhớ cho chuỗi: "${textToFind}"`);
  const pattern = Buffer.from(textToFind, "utf16le").toString("hex");
  const matches = [];

  // Chỉ quét trong các vùng heap có thể ghi được
  Process.enumerateRanges("rw-").forEach((range) => {
    try {
      const results = Memory.scanSync(range.base, range.size, pattern);
      results.forEach((match) => {
        matches.push(match.address);
      });
    } catch (e) {}
  });

  if (matches.length === 0) {
    console.log(`[!] Không tìm thấy chuỗi "${textToFind}" trong bộ nhớ.`);
    return;
  }

  console.log(
    `[+] Tìm thấy ${matches.length} địa chỉ chứa chuỗi "${textToFind}":`
  );
  matches.forEach((addr) => console.log(`    - String at: ${addr}`));

  console.log(`\n[*] Bắt đầu quét tìm các con trỏ trỏ đến các địa chỉ trên...`);
  const foundReferences = new Map();

  Process.enumerateRanges("rw-").forEach((range) => {
    matches.forEach((stringAddress) => {
      try {
        const results = Memory.scanSync(
          range.base,
          range.size,
          stringAddress.toString(16).match(/../g).reverse().join(" ")
        );
        results.forEach((refMatch) => {
          const refAddress = refMatch.address;
          // Giả sử con trỏ tới vtable nằm ở đầu đối tượng
          const vtablePtr = refAddress.readPointer();
          // Con trỏ tới Il2CppClass thường nằm ngay sau vtable
          const classPtr = vtablePtr.add(Process.pointerSize).readPointer();

          try {
            const klass = new Il2Cpp.Class(classPtr);
            const className = klass.fullName;

            if (!foundReferences.has(className)) {
              foundReferences.set(className, []);
            }
            foundReferences.get(className).push(refAddress);
          } catch (e) {
            // Bỏ qua nếu không phải là đối tượng Il2Cpp hợp lệ
          }
        });
      } catch (e) {}
    });
  });

  if (foundReferences.size === 0) {
    console.log("[!] Không tìm thấy con trỏ nào trỏ tới chuỗi này.");
  } else {
    console.log(
      "[SUCCESS] Tìm thấy các đối tượng sau có khả năng đang chứa chuỗi này:"
    );
    for (const [className, addresses] of foundReferences.entries()) {
      console.log(`    -> Lớp: ${className} (${addresses.length} đối tượng)`);
      console.log(`       -> Một ví dụ tại handle: ${addresses[0]}`);
    }
  }
}

// Cung cấp một hàm để Python có thể gọi
rpc.exports.scan = function (text) {
  Il2Cpp.perform(() => {
    findStringAndReferences(text);
  });
};

Il2Cpp.perform(() => {
  console.log("[+] Agent đã sẵn sàng. Chờ lệnh quét từ Python.");
});
