import "frida-il2cpp-bridge";
console.log("[*] Il2Cpp-Bridge Cheat for 'A Girl Adrift' is starting...");

// Đợi cho Il2Cpp sẵn sàng
Il2Cpp.perform(() => {
  console.log("[+] Il2Cpp Bridge is ready!");

  // Sử dụng try-catch để bắt lỗi nếu tên Class/Method thay đổi trong tương lai
  try {
    // 1. Lấy Assembly chứa logic game
    const assembly = Il2Cpp.domain.assembly("Assembly-CSharp");

    // 2. Tìm đến Class quản lý tiền tệ
    const PlayerCurrencyElement = assembly.image.class(
      "player_currency_element"
    );
    console.log(
      `[+] Found Target Class: ${PlayerCurrencyElement.name} @ ${PlayerCurrencyElement.handle}`
    );

    // 3. Tìm đến Method xử lý việc trừ tiền
    // Chính xác là phương thức "Use" nhận vào một tham số kiểu "System.Double"
    const useMethod =
      PlayerCurrencyElement.method("Use").overload("System.Double");
    console.log(
      `[+] Found Target Method: ${useMethod.name} @ ${useMethod.virtualAddress}`
    );

    // 4. Hook vào phương thức đó
    Interceptor.replace(
      useMethod.virtualAddress,
      new NativeCallback(
        (this_ptr, amount_to_spend_double) => {
          // Logic chính của cheat: Đảo ngược giá trị
          const reversedAmount = -amount_to_spend_double;

          console.log(
            `[*] Intercepted 'Use' call. Original spend: ${amount_to_spend_double}, Patched to: ${reversedAmount}`
          );

          // Gọi lại hàm gốc với giá trị đã được sửa đổi
          // Điều này sẽ biến việc trừ tiền thành cộng tiền
          return useMethod.invoke(this_ptr, reversedAmount);
        },
        "void",
        ["pointer", "double"]
      )
    );

    console.log("\n[SUCCESS] Free Shopping Cheat is ACTIVE. Go buy something!");
  } catch (error) {
    console.error("[ERROR] Script failed. Maybe the game was updated?");
    console.error(error.stack);
  }
});
