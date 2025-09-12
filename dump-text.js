import "frida-il2cpp-bridge";

console.log("[*] Bắt đầu script trích xuất văn bản...");

// Sử dụng một Set để tránh các cặp key-value trùng lặp
const dumpedStrings = new Map();
let dumpCounter = 0;

Il2Cpp.perform(() => {
  console.log("[+] Il2Cpp Bridge đã sẵn sàng!");
  const assembly = Il2Cpp.domain.assembly("Assembly-CSharp");
  const StringFormat = assembly.image.class("stringFormat");

  const getLanguageMethod =
    StringFormat.method("get_language").overload("System.String");

  getLanguageMethod.implementation = function (code) {
    // Gọi hàm gốc để lấy văn bản
    const originalText = getLanguageMethod.invoke(code);

    const codeContent = code.content;
    const originalTextContent = originalText.content;

    // Chỉ thêm vào nếu key chưa tồn tại
    if (codeContent && originalTextContent && !dumpedStrings.has(codeContent)) {
      dumpedStrings.set(codeContent, originalTextContent);
      dumpCounter++;
      // Cứ mỗi 100 chuỗi mới thì in ra log
      if (dumpCounter % 100 === 0) {
        console.log(`[+] Đã trích xuất ${dumpCounter} chuỗi...`);
      }
    }

    return originalText;
  };

  console.log(
    "[SUCCESS] Đã hook vào stringFormat.get_language. Hãy chơi game để thu thập dữ liệu."
  );
});

// Hàm để lưu file khi script bị dừng (ví dụ: Ctrl+C)
function saveDump() {
  if (dumpCounter > 0) {
    const outputObject = Object.fromEntries(dumpedStrings);
    const jsonString = JSON.stringify(outputObject, null, 2);

    // Bạn có thể thay đổi đường dẫn file ở đây
    const filePath = "./game_texts.json";
    const file = new File(filePath, "w");
    file.write(jsonString);
    file.close();
    console.log(
      `\n[SUCCESS] Đã lưu thành công ${dumpCounter} chuỗi vào file: ${filePath}`
    );
  } else {
    console.log("\n[*] Không có chuỗi nào mới để lưu.");
  }
}

// Frida sẽ gọi hàm này khi script bị detach
rpc.exports.dispose = function () {
  saveDump();
};

// Bạn cũng có thể gọi hàm này thủ công từ Python/CLI nếu cần
rpc.exports.save = function () {
  saveDump();
};
