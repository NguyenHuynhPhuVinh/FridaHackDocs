import "frida-il2cpp-bridge";

console.log("[*] Bắt đầu script DUMP TĂNG TRƯỞNG...");

// Set để lưu các key đã dump từ các lần chạy trước + lần này
const knownKeys = new Set();
// Map để lưu các cặp key-value MỚI tìm thấy trong phiên này
const newlyDumpedStrings = new Map();
let newStringsCount = 0;

// RPC: Python sẽ gọi hàm này đầu tiên để gửi các key đã biết
rpc.exports.initialize = function (existingKeys) {
  if (existingKeys && Array.isArray(existingKeys)) {
    for (const key of existingKeys) {
      knownKeys.add(key);
    }
    console.log(`[+] Đã nhận ${knownKeys.size} key đã tồn tại từ Python.`);
  }
};

// RPC: Python sẽ gọi hàm này khi muốn lưu kết quả
rpc.exports.getNewStrings = function () {
  if (newStringsCount > 0) {
    const outputObject = Object.fromEntries(newlyDumpedStrings);
    send({
      type: "dump_result",
      payload: outputObject,
      count: newStringsCount,
    });
    console.log(`\n[SUCCESS] Đã gửi ${newStringsCount} chuỗi mới về Python.`);
  } else {
    console.log("\n[*] Không có chuỗi mới nào để gửi về.");
    send({ type: "dump_result", payload: {}, count: 0 });
  }
};

Il2Cpp.perform(() => {
  console.log("[+] Đã kết nối. Đang hook để dump...");
  try {
    const StringFormat = Il2Cpp.domain
      .assembly("Assembly-CSharp")
      .image.class("stringFormat");
    const getLanguageMethod =
      StringFormat.method("get_language").overload("System.String");

    getLanguageMethod.implementation = function (code) {
      const originalText = getLanguageMethod.invoke(code);

      if (originalText && !originalText.handle.isNull()) {
        const codeContent = code.content;

        // Chỉ xử lý nếu đây là một key mới
        if (codeContent && !knownKeys.has(codeContent)) {
          const originalTextContent = originalText.content;

          if (originalTextContent) {
            knownKeys.add(codeContent); // Thêm vào danh sách đã biết để không check lại
            newlyDumpedStrings.set(codeContent, originalTextContent);
            newStringsCount++;
            if (newStringsCount % 50 === 0) {
              console.log(`[+] Đã tìm thấy ${newStringsCount} chuỗi mới...`);
            }
          }
        }
      }
      return originalText;
    };
    console.log(
      "[SUCCESS] Hook dump đã được cài đặt. Hãy chơi game để thu thập text."
    );
  } catch (e) {
    console.error("[ERROR] Hook dump thất bại:", e.stack);
  }
});
