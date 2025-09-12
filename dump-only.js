import "frida-il2cpp-bridge";

console.log("[*] Bắt đầu script DUMP VĂN BẢN (v2 - Đã sửa lỗi)...");
const dumpedStrings = new Map();
let dumpCounter = 0;

Il2Cpp.perform(() => {
  console.log("[+] Đã kết nối. Đang hook để dump...");
  try {
    const StringFormat = Il2Cpp.domain
      .assembly("Assembly-CSharp")
      .image.class("stringFormat");
    const getLanguageMethod =
      StringFormat.method("get_language").overload("System.String");

    getLanguageMethod.implementation = function (code) {
      // SỬA LỖI: Gọi hàm gốc đúng cách cho phương thức static
      const originalText = getLanguageMethod.invoke(code);

      // Kiểm tra xem kết quả có hợp lệ không trước khi truy cập
      if (originalText && !originalText.handle.isNull()) {
        const codeContent = code.content;
        const originalTextContent = originalText.content;

        if (
          codeContent &&
          originalTextContent &&
          !dumpedStrings.has(codeContent)
        ) {
          dumpedStrings.set(codeContent, originalTextContent);
          dumpCounter++;
          if (dumpCounter % 100 === 0)
            console.log(`[+] Đã dump ${dumpCounter} chuỗi...`);
        }
      }

      // Luôn trả về kết quả gốc để game không bị lỗi
      return originalText;
    };
    console.log("[SUCCESS] Hook dump đã được cài đặt.");
  } catch (e) {
    console.error("[ERROR] Hook dump thất bại:", e.stack);
  }
});

rpc.exports.saveDump = function () {
  if (dumpCounter > 0) {
    const outputObject = Object.fromEntries(dumpedStrings);
    const jsonString = JSON.stringify(outputObject, null, 2);
    // Gửi dữ liệu về cho Python xử lý
    send({ type: "dump_result", payload: jsonString });
    console.log(`\n[SUCCESS] Đã gửi ${dumpCounter} chuỗi về Python.`);
  } else {
    console.log("\n[*] Không có chuỗi nào để dump.");
    // Gửi một thông báo rỗng để Python có thể thoát
    send({ type: "dump_result", payload: "{}" });
  }
};
