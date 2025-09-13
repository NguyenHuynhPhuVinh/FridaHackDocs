/*
 * Script Frida để hook sát thương cho game com.gamepub.pt
 * Yêu cầu: npm install frida-il2cpp-bridge
 * Cách chạy: frida -U -f com.gamepub.pt --no-pause -l hack_damage.js
 */

// Import thư viện frida-il2cpp-bridge
import "frida-il2cpp-bridge";

// ======================= CẤU HÌNH =======================
const GOD_MODE_ENABLED = true; // Bật/tắt chế độ bất tử (nhận 0 sát thương)
const ONE_HIT_KILL_ENABLED = false; // Bật/tắt chế độ tăng sát thương gây ra
const NEW_DAMAGE_VALUE = 9999999; // Sát thương mới bạn muốn gây ra
// ==========================================================

// Bắt đầu thực thi khi thư viện il2cpp đã sẵn sàng
Il2Cpp.perform(() => {
  console.log("[+] il2cpp is ready. Starting hooks...");

  // Lấy tham chiếu đến assembly chính của game
  const assembly = Il2Cpp.domain.assembly("Assembly-CSharp");

  // --- Chức năng 1: GOD MODE (Bất tử) ---
  if (GOD_MODE_ENABLED) {
    try {
      // Dựa theo file Damage_Hook_Summary.md, hàm RecieveDamage là mục tiêu tốt nhất.
      // Chữ ký: RecieveDamage(CharacterBase _attacker, ref Battle.StatTransfer _statTransfer, ...)
      // Hàm này nằm trong lớp CharacterBase hoặc lớp kế thừa từ nó.
      const CharacterBase = assembly.image.class("CharacterBase");
      const recieveDamageMethod = CharacterBase.method("RecieveDamage", 4); // 4 là số lượng tham số

      console.log(
        `[+] Found RecieveDamage at: ${recieveDamageMethod.virtualAddress}`
      );

      Interceptor.attach(recieveDamageMethod.virtualAddress, {
        onEnter(args) {
          // Tham số thứ 2 (_statTransfer) là một con trỏ tới struct chứa thông tin sát thương.
          // args[1] chính là con trỏ đó.
          try {
            // Chúng ta cần biết cấu trúc của Battle.StatTransfer để sửa đúng trường (field).
            // Dựa vào kinh nghiệm, các trường sát thương thường có tên là fDamage, damage, m_damage...
            // Ở đây ta giả định tên trường là "fDamage".
            // Nếu không đúng, bạn cần dùng dumper của frida-il2cpp-bridge để xem tên chính xác.
            const statTransferStruct = new Il2Cpp.ValueType(
              args[1],
              assembly.image.class("Battle.StatTransfer").type
            );
            const damageField = statTransferStruct.field("fDamage");

            const originalDamage = damageField.value;
            if (originalDamage > 0) {
              console.log(
                `[*] GOD MODE: Intercepted incoming damage. Original: ${originalDamage}, New: 0`
              );
              // Ghi đè giá trị sát thương nhận vào bằng 0
              damageField.value = 0;
            }
          } catch (e) {
            console.error(
              `[!] Error inside RecieveDamage hook: ${e.message}. Field name "fDamage" might be incorrect.`
            );
          }
        },
      });
      console.log("[OK] God Mode hook attached.");
    } catch (e) {
      console.error(`[FAIL] Could not attach God Mode hook: ${e.message}`);
    }
  }

  // --- Chức năng 2: ONE-HIT KILL (Tăng sát thương) ---
  if (ONE_HIT_KILL_ENABLED) {
    try {
      // Dựa theo file Damage_Hook_Summary.md, hàm HandleCheckHitDamage là mục tiêu lý tưởng.
      // Chữ ký: HandleCheckHitDamage(CharacterBase _attacker, float _fDamage)
      // Lớp chứa hàm này có thể là Skill.TriggerComponent hoặc tương tự. Ta cần tìm nó.
      // Giả sử nó nằm trong class Skill.PlayerSkillComponent
      const PlayerSkillComponent = assembly.image.class(
        "Skill.PlayerSkillComponent"
      );
      const handleCheckHitDamageMethod = PlayerSkillComponent.method(
        "HandleCheckHitDamage",
        2
      );

      console.log(
        `[+] Found HandleCheckHitDamage at: ${handleCheckHitDamageMethod.virtualAddress}`
      );

      Interceptor.attach(handleCheckHitDamageMethod.virtualAddress, {
        onEnter(args) {
          // Tham số thứ 2 (_fDamage) là một số float.
          // args[1] là giá trị sát thương gốc (dạng NativePointer chứa giá trị số).
          try {
            const originalDamage = args[1].toInt32(); // Frida đọc float/int là number
            if (originalDamage > 0) {
              console.log(
                `[*] ONE-HIT KILL: Intercepted outgoing damage. Original: ${originalDamage}, New: ${NEW_DAMAGE_VALUE}`
              );
              // Ghi đè giá trị sát thương gây ra bằng giá trị mới
              args[1].replace(NEW_DAMAGE_VALUE);
            }
          } catch (e) {
            console.error(
              `[!] Error inside HandleCheckHitDamage hook: ${e.message}`
            );
          }
        },
      });
      console.log("[OK] One-Hit Kill hook attached.");
    } catch (e) {
      console.error(`[FAIL] Could not attach One-Hit Kill hook: ${e.message}`);
      console.error(
        "[INFO] Class 'Skill.PlayerSkillComponent' might be incorrect. Please check the dumped source."
      );
    }
  }
});
