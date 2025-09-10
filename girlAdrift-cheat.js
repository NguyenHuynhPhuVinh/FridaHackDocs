import "frida-il2cpp-bridge";

console.log("[*] Il2Cpp-Bridge Cheat for 'A Girl Adrift' is starting...");

Il2Cpp.perform(() => {
  console.log("[+] Il2Cpp Bridge is ready!");

  try {
    const assembly = Il2Cpp.domain.assembly("Assembly-CSharp");
    const PlayerCurrencyElement = assembly.image.class(
      "player_currency_element"
    );
    console.log(
      `[+] Found Target Class: ${PlayerCurrencyElement.name} @ ${PlayerCurrencyElement.handle}`
    );

    const useMethod =
      PlayerCurrencyElement.method("Use").overload("System.Double");
    console.log(
      `[+] Found Target Method: ${useMethod.name} @ ${useMethod.virtualAddress}`
    );

    Interceptor.replace(
      useMethod.virtualAddress,
      new NativeCallback(
        (this_ptr, amount_to_spend_double) => {
          const reversedAmount = -amount_to_spend_double;
          console.log(
            `[*] Intercepted 'Use' call. Original spend: ${amount_to_spend_double}, Patched to: ${reversedAmount}`
          );

          // SỬA LỖI Ở ĐÂY: Dùng invokeRaw và truyền this_ptr vào
          // invokeRaw(con_trỏ_this, các_tham_số_còn_lại)
          return useMethod.invokeRaw(this_ptr, reversedAmount);
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
