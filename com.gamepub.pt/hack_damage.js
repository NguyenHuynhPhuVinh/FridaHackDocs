/*
 * Script Frida HOÀN CHỈNH V8 để hook sát thương cho game com.gamepub.pt
 * Đã sửa lỗi truy cập sai tham số trong hàm RecieveDamage.
 * Cách chạy: frida -U "Chuyện công chúa" --no-pause -l hack_damage.js
 */

import "frida-il2cpp-bridge";

// ======================= CẤU HÌNH =======================
const GOD_MODE_ENABLED = true;
const ONE_HIT_KILL_ENABLED = true;
const DAMAGE_MULTIPLIER = 1000;
// ==========================================================

function isPlayer(characterObject) {
  try {
    if (characterObject.handle.isNull()) return false;
    return characterObject.method("get_IsPlayer").invoke();
  } catch (e) {
    return false;
  }
}

Il2Cpp.perform(() => {
  console.log("[+] il2cpp is ready. Deploying final hooks...");

  try {
    const assembly = Il2Cpp.domain.assembly("Assembly-CSharp");
    const CharacterBase = assembly.image.class("CharacterBase");
    const BattleStatTransfer = assembly.image.class("Battle.StatTransfer");

    const recieveDamageMethod = CharacterBase.method("RecieveDamage", 4);
    console.log(
      `[+] Found RecieveDamage at: ${recieveDamageMethod.virtualAddress}`
    );

    Interceptor.attach(recieveDamageMethod.virtualAddress, {
      onEnter(args) {
        try {
          // SỬA LỖI TRUY CẬP THAM SỐ:
          const receiver = new Il2Cpp.Object(args[0]); // this (người nhận) là args[0]
          const attacker = new Il2Cpp.Object(args[1]); // _attacker là args[1]
          const statTransferPtr = args[2]; // ref _statTransfer là args[2]

          const isAttackerPlayer = isPlayer(attacker);
          const isReceiverPlayer = isPlayer(receiver);

          // --- Logic God Mode ---
          // Kích hoạt khi Player bị tấn công (isReceiverPlayer = true)
          if (GOD_MODE_ENABLED && isReceiverPlayer && !isAttackerPlayer) {
            // Thêm điều kiện !isAttackerPlayer để chắc chắn
            const statTransferStruct = new Il2Cpp.ValueType(
              statTransferPtr,
              BattleStatTransfer.type
            );
            const damageField = statTransferStruct.field("Damage");
            const originalDamage = damageField.value;

            if (originalDamage > 1) {
              console.log(
                `[*] GOD MODE ACTIVATED: Player taking damage. Original: ${originalDamage.toFixed(
                  0
                )}, New: 1`
              );
              damageField.value = 1.0; // Dùng float
            }
          }

          // --- Logic One-Hit Kill ---
          // Kích hoạt khi Enemy bị tấn công (isReceiverPlayer = false)
          if (ONE_HIT_KILL_ENABLED && !isReceiverPlayer && isAttackerPlayer) {
            // Thêm điều kiện isAttackerPlayer
            const statTransferStruct = new Il2Cpp.ValueType(
              statTransferPtr,
              BattleStatTransfer.type
            );
            const damageField = statTransferStruct.field("Damage");
            const originalDamage = damageField.value;

            if (originalDamage > 0) {
              const newDamage = originalDamage * DAMAGE_MULTIPLIER;
              console.log(
                `[*] ONE-HIT KILL ACTIVATED: Enemy taking damage. Original: ${originalDamage.toFixed(
                  0
                )}, New: ${newDamage.toFixed(0)}`
              );
              damageField.value = newDamage;
            }
          }
        } catch (e) {
          // Thêm log chi tiết hơn để dễ gỡ lỗi nếu vẫn còn vấn đề
          console.error(
            `[!] Error inside RecieveDamage hook: ${e.message}\nStack: ${e.stack}`
          );
        }
      },
    });
    console.log("[OK] Universal Damage Hook is active.");
  } catch (err) {
    console.error(
      `[!!!] An error occurred during initialization: ${err.message}`
    );
  }
});
