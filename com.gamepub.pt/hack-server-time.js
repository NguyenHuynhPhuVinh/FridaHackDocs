/*
 * Script Frida để "trinh sát" các hàm mạng.
 * Mục tiêu: Tìm ra hàm nào thực sự được gọi khi game gửi dữ liệu.
 * Cách chạy: frida -U "Chuyện Công Chúa" --no-pause -l spy_network_generic.js
 */

import "frida-il2cpp-bridge";

Il2Cpp.perform(() => {
  console.log("[+] Il2Cpp Bridge is ready. Deploying Generic Network Spy...");

  try {
    const keywords = [
      "Send",
      "send",
      "Write",
      "write",
      "Request",
      "request",
      "Post",
      "post",
      "Connect",
      "connect",
      "BeginSend",
      "BeginWrite",
      "BeginConnect",
    ];

    // Các assembly có khả năng chứa hàm mạng
    const assembliesToScan = ["Assembly-CSharp", "mscorlib", "System"];

    let hookedCount = 0;

    assembliesToScan.forEach((assemblyName) => {
      const assembly = Il2Cpp.domain.tryAssembly(assemblyName);
      if (!assembly) {
        console.warn(`[!] Assembly not found: ${assemblyName}`);
        return;
      }

      console.log(`[*] Scanning assembly: ${assemblyName}...`);

      assembly.image.classes.forEach((klass) => {
        klass.methods.forEach((method) => {
          // Kiểm tra xem tên phương thức có chứa từ khóa nào không
          if (keywords.some((keyword) => method.name.includes(keyword))) {
            // Bỏ qua các hàm không hợp lệ hoặc quá nhỏ/nguy hiểm
            if (
              method.virtualAddress.isNull() ||
              method.name.startsWith("add_") ||
              method.name.startsWith("remove_")
            ) {
              return;
            }

            try {
              Interceptor.attach(method.virtualAddress, {
                onEnter(args) {
                  console.log(`\n>>> NETWORK ACTIVITY DETECTED <<<`);
                  console.log(`    Class: ${klass.fullName}`);
                  console.log(`    Method: ${method.name}`);
                  console.log(`    Address: ${method.virtualAddress}`);
                  // In ra backtrace để xem ai đã gọi hàm này
                  console.log(
                    "    Backtrace:\n" +
                      Thread.backtrace(this.context, Backtracer.ACCURATE)
                        .map(DebugSymbol.fromAddress)
                        .join("\n\t")
                  );
                  console.log(`>>> END <<<`);
                },
              });
              hookedCount++;
            } catch (e) {
              // Bỏ qua lỗi
            }
          }
        });
      });
    });

    console.log(
      `[OK] Generic Network Spy is active. Hooked ${hookedCount} potential methods.`
    );
    console.log(
      "[!] Play the game and trigger a network action (login, get reward, etc.)."
    );
  } catch (err) {
    console.error(
      `[!!!] An error occurred during initialization: ${err.message}\nStack: ${err.stack}`
    );
  }
});
