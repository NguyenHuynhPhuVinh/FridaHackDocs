/*
 * Script "Thẩm Vấn" để in ra thông tin chi tiết về các đối tượng.
 */
import "frida-il2cpp-bridge";

Il2Cpp.perform(() => {
  console.log("[+] il2cpp is ready. Starting interrogation...");

  const assembly = Il2Cpp.domain.assembly("Assembly-CSharp");
  const CharacterBase = assembly.image.class("CharacterBase");

  // --- Thẩm vấn hàm RecieveDamage ---
  try {
    const recieveDamageMethod = CharacterBase.method("RecieveDamage", 4);
    console.log(
      `[+] Attaching to RecieveDamage at: ${recieveDamageMethod.virtualAddress}`
    );

    Interceptor.attach(recieveDamageMethod.virtualAddress, {
      onEnter(args) {
        console.log("\n--- INTERROGATION: RecieveDamage TRIGGERED ---");
        try {
          const attacker = new Il2Cpp.Object(args[0]);
          const receiver = new Il2Cpp.Object(this.context.x0); // "this" object

          console.log(
            `[Attacker]: ${attacker.toString()} | Class: ${attacker.class.name}`
          );
          console.log(
            `          -> isPlayer? ${attacker.method("get_IsPlayer").invoke()}`
          );

          console.log(
            `[Receiver]: ${receiver.toString()} | Class: ${receiver.class.name}`
          );
          console.log(
            `          -> isPlayer? ${receiver.method("get_IsPlayer").invoke()}`
          );
        } catch (e) {
          console.error(`[!] Interrogation failed: ${e.message}`);
        }
        console.log("------------------------------------------");
      },
    });
  } catch (e) {
    console.error(`[FAIL] Could not attach to RecieveDamage: ${e.message}`);
  }
});
