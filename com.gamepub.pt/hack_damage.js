/*
 * Script Frida HOÀN CHỈNH (đã sửa lỗi cú pháp TypeScript)
 * Yêu cầu: npm install frida-il2cpp-bridge
 * Cách chạy: frida -U "Chuyện công chúa" --no-pause -l final_hack.js
 */

import "frida-il2cpp-bridge";

// ======================= CẤU HÌNH =======================
const GOD_MODE_ENABLED = true; // Bật/tắt chế độ bất tử (nhận 0 sát thương)
const ONE_HIT_KILL_ENABLED = false; // Bật/tắt chế độ tăng sát thương gây ra
const NEW_DAMAGE_VALUE = 9999999.0; // Sát thương mới (dùng số float)
// ==========================================================

Il2Cpp.perform(() => {
  console.log("[+] il2cpp is ready. Starting hooks based on your analysis...");

  const assembly = Il2Cpp.domain.assembly("Assembly-CSharp");
  const CharacterBase = assembly.image.class("CharacterBase");
  const StatTransfer = assembly.image.class("Battle.StatTransfer");

  // --- Chức năng 1: GOD MODE (Bất tử) ---
  if (GOD_MODE_ENABLED) {
    try {
      const recieveDamageMethod = CharacterBase.method("RecieveDamage", 4);
      console.log(
        `[+] Found RecieveDamage at: ${recieveDamageMethod.virtualAddress}`
      );

      Interceptor.attach(recieveDamageMethod.virtualAddress, {
        onEnter(args) {
          const statTransferPointer = args[2];

          try {
            const statTransferStruct = new Il2Cpp.ValueType(
              statTransferPointer,
              StatTransfer.type
            );
            const damageField = statTransferStruct.field("Damage");
            const originalDamage = damageField.value;

            if (originalDamage > 0) {
              console.log(
                `[*] GOD MODE: Blocked incoming damage. Original: ${originalDamage.toFixed(
                  2
                )} -> New: 0`
              );
              damageField.value = 0.0;
            }
          } catch (e) {
            console.error(`[!] Error inside God Mode hook: ${e.message}`);
          }
        },
      });
      console.log("[OK] God Mode hook attached successfully!");
    } catch (e) {
      console.error(`[FAIL] Could not attach God Mode hook: ${e.message}`);
    }
  }

  // --- Chức năng 2: ONE-HIT KILL (Tăng sát thương) ---
  if (ONE_HIT_KILL_ENABLED) {
    try {
      const handleCheckHitDamageMethod = CharacterBase.method(
        "HandleCheckHitDamage",
        2
      );
      console.log(
        `[+] Found HandleCheckHitDamage at: ${handleCheckHitDamageMethod.virtualAddress}`
      );

      // === ĐÃ SỬA LỖI CÚ PHÁP TẠI ĐÂY ===
      handleCheckHitDamageMethod.implementation = function (
        attacker,
        originalDamage
      ) {
        if (originalDamage > 0) {
          console.log(
            `[*] ONE-HIT KILL: Modified outgoing damage. Original: ${originalDamage.toFixed(
              2
            )} -> New: ${NEW_DAMAGE_VALUE}`
          );
        }
        // 'this' ở đây sẽ tự động trỏ đến đúng instance của CharacterBase
        return this.method("HandleCheckHitDamage", 2).invoke(
          attacker,
          NEW_DAMAGE_VALUE
        );
      };

      console.log("[OK] One-Hit Kill hook attached successfully!");
    } catch (e) {
      console.error(`[FAIL] Could not attach One-Hit Kill hook: ${e.message}`);
    }
  }
});
