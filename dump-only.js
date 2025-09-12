import "frida-il2cpp-bridge";

console.log("[*] Bắt đầu AGENT DỊCH & DUMP TĂNG TRƯỞNG...");

let translationDict = {};
const newlyDumpedStrings = new Map();
let newStringsCount = 0;

// RPC: Python sẽ gọi hàm này để gửi bản dịch đã có
rpc.exports.initialize = function (translations) {
  if (translations) {
    translationDict = translations;
    console.log(
      `[+] Đã nhận ${Object.keys(translationDict).length} chuỗi dịch từ Python.`
    );
  }
};

// RPC: Python gọi để lấy các chuỗi mới cần dịch
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
  console.log("[+] Đã kết nối. Đang cài đặt hook...");
  const assembly = Il2Cpp.domain.assembly("Assembly-CSharp");

  // Hook để DUMP các chuỗi chưa biết
  try {
    const StringFormat = assembly.image.class("stringFormat");
    const getLanguageMethod =
      StringFormat.method("get_language").overload("System.String");
    getLanguageMethod.implementation = function (code) {
      const originalText = getLanguageMethod.invoke(code);
      const textContent = originalText.content;

      // Nếu text gốc tồn tại và CHƯA CÓ trong từ điển dịch
      if (
        textContent &&
        !translationDict.hasOwnProperty(textContent) &&
        !newlyDumpedStrings.has(textContent)
      ) {
        const codeContent = code.content;
        if (codeContent) {
          newlyDumpedStrings.set(codeContent, textContent);
          newStringsCount++;
        }
      }
      return originalText;
    };
    console.log("[SUCCESS] Hook DUMP đã được cài đặt.");
  } catch (e) {
    console.error("[ERROR] Hook dump thất bại:", e.stack);
  }

  // Hook để DỊCH UI
  try {
    const HyperText = assembly.image.class("GarlicText.UI.HyperText");
    const setTextMethod = HyperText.method("set_text");
    const originalSetText = setTextMethod.implementation;

    setTextMethod.implementation = function (text) {
      if (text && !text.handle.isNull()) {
        const textContent = text.content;
        // Ưu tiên tra cứu bản dịch
        if (textContent && translationDict.hasOwnProperty(textContent)) {
          const translatedString = Il2Cpp.string(translationDict[textContent]);
          return setTextMethod.bind(this).invoke(translatedString);
        }
      }
      // Nếu không có bản dịch, gọi hàm gốc để hiển thị tiếng Anh
      return setTextMethod.bind(this).invoke(text);
    };
    console.log("[SUCCESS] Hook DỊCH đã được cài đặt.");
  } catch (e) {
    console.error("[ERROR] Hook dịch thất bại:", e.stack);
  }

  console.log("\n[***] AGENT ĐA NĂNG ĐÃ SẴN SÀNG! [***]");
});
