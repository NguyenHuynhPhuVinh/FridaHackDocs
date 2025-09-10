import "frida-il2cpp-bridge";

console.log("[*] Fish Reward Hack for 'A Girl Adrift' is starting...");

// === CÀI ĐẶT CỦA BẠN ===
const GOLD_MULTIPLIER = 100;
// =======================

Il2Cpp.perform(() => {
  console.log("[+] Il2Cpp Bridge is ready!");

  try {
    const assembly = Il2Cpp.domain.assembly("Assembly-CSharp");
    const PlayerCurrencyElement = assembly.image.class(
      "player_currency_element"
    );

    const addMethod = PlayerCurrencyElement.method("Add").overload(
      "System.Double",
      "System.Nullable<UnityEngine.Vector3>",
      "System.Boolean"
    );

    console.log(
      `[+] Found Target Method: ${addMethod.name} @ ${addMethod.virtualAddress}`
    );

    addMethod.implementation = function (num, effect_pos, isWorldPos) {
      // 'this' trong hàm này là một Il2Cpp.Object

      let hackedGold = num;

      if (num > 0) {
        hackedGold = num * GOLD_MULTIPLIER;
        console.log(
          `[*] Fishing reward intercepted! Original: ${num.toFixed(
            2
          )} ---> Hacked: ${hackedGold.toFixed(2)} (x${GOLD_MULTIPLIER})`
        );
      }

      // SỬA LỖI Ở ĐÂY:
      // Thay vì this.method("Add"), chúng ta bind addMethod vào 'this'
      // rồi mới invoke. Điều này đảm bảo chúng ta gọi đúng overload.
      return addMethod.bind(this).invoke(hackedGold, effect_pos, isWorldPos);
    };

    console.log(
      `\n[SUCCESS] Gold Hack is ACTIVE. Go catch a fish! (Multiplier: x${GOLD_MULTIPLIER})`
    );
  } catch (error) {
    console.error(
      "[ERROR] Script failed. Maybe the game was updated or the method signature changed?"
    );
    console.error(error.stack);
  }
});
