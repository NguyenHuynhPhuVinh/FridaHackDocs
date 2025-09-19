console.log("[*] Frida script started.");

// Sử dụng setImmediate để đảm bảo script chạy sau khi Frida đã khởi tạo xong hoàn toàn
setImmediate(function () {
  console.log("[*] In setImmediate. Starting Java.perform...");
  Java.perform(function () {
    console.log("[*] Inside Java.perform().");

    try {
      // Cố gắng lấy handle của lớp. Hành động này sẽ ép ClassLoader phải nạp nó nếu chưa có.
      const SignatureCheck = Java.use("com.pairip.SignatureCheck");
      console.log("[+] Successfully got handle for com.pairip.SignatureCheck.");

      // Ngay lập tức ghi đè phương thức.
      SignatureCheck.verifyIntegrity.implementation = function (context) {
        console.log(
          "[SUCCESS] SignatureCheck.verifyIntegrity() HOOKED AND BYPASSED!"
        );
        // Không làm gì cả và return.
        return;
      };

      console.log("[+] Hook for SignatureCheck.verifyIntegrity is now active.");
    } catch (error) {
      console.error("[ERROR] Failed to hook SignatureCheck:");
      console.error(error);
      console.error(error.stack);
    }
  });
});
