/*
 * Script Frida HOÀN CHỈNH V4 để mở khóa tất cả các cảnh H trong game.
 * PHIÊN BẢN SỬA LỖI:
 *   - Đã xác định đúng assembly chứa lớp kiểm tra độ thân mật.
 *   - Các hook khác vẫn được giữ lại để đảm bảo hiệu quả tối đa.
 */

import "frida-il2cpp-bridge";

// ======================= CẤU HÌNH =======================
// !!! THAY THẾ TÊN ASSEMBLY BẠN TÌM ĐƯỢC Ở ĐÂY !!!
const CHARACTER_ASSEMBLY_NAME = "Assembly-CSharp"; // Thay thế bằng kết quả từ script find_class.js
// ==========================================================

Il2Cpp.perform(() => {
  console.log("[+] Il2Cpp Bridge đã sẵn sàng. Bắt đầu quá trình mở khóa...");

  // --- CHIẾN LƯỢC 1: Bỏ qua kiểm tra độ thân mật (Affection Check Bypass) ---
  try {
    const assembly = Il2Cpp.domain.assembly(CHARACTER_ASSEMBLY_NAME);
    const CharacterDetailParameterController = assembly.image.class(
      "Assets.GameUi.CharacterDetail.Parameter.CharacterDetailParameterController"
    );

    const applyLockMethod = CharacterDetailParameterController.method(
      "ApplyCharacterEpisodeButtonLock",
      2
    );

    console.log(
      `[+] Tìm thấy phương thức khóa nút kịch bản tại: ${applyLockMethod.virtualAddress} trong ${CHARACTER_ASSEMBLY_NAME}.dll`
    );

    Interceptor.attach(applyLockMethod.virtualAddress, {
      onEnter(args) {
        const requiredLevel = new Il2Cpp.Value(args[1], "int32").value;
        const currentLevel = new Il2Cpp.Value(args[2], "int32").value;

        if (currentLevel < requiredLevel) {
          console.log(
            `[HOOK 1] Đã phát hiện nút kịch bản bị khóa (Yêu cầu: ${requiredLevel}, Hiện tại: ${currentLevel}). Đang mở khóa...`
          );
          args[2] = args[1];
        }
      },
    });

    console.log(
      "[OK] Chiến lược 1: Đã hook thành công vào việc kiểm tra độ thân mật."
    );
  } catch (err) {
    console.error(`[!!!] Lỗi ở Chiến lược 1 (Affection Hook): ${err.message}`);
  }

  // --- CÁC CHIẾN LƯỢC KHÁC VẪN GIỮ NGUYÊN ---
  try {
    const assembly = Il2Cpp.domain.assembly("GameUi");
    const EpisodeService = assembly.image.class(
      "Assets.GameUi.Service.EpisodeService"
    );
    const isReadMethod = EpisodeService.method("IsReadEpisode", 1);
    isReadMethod.implementation = function (episodeMasterId) {
      const id = arguments[0].value;
      console.log(`[HOOK 2] Ép IsReadEpisode cho ID ${id} trả về TRUE.`);
      return true;
    };
    console.log("[OK] Chiến lược 2: Đã hook thành công vào IsReadEpisode.");
  } catch (err) {
    console.error(`[!!!] Lỗi ở Chiến lược 2 (IsRead Hook): ${err.message}`);
  }

  try {
    const assembly = Il2Cpp.domain.assembly("GameUi");
    const UnlockFunctionService = assembly.image.class(
      "Assets.GameUi.Service.UnlockFunctionService"
    );
    const canAccessMethod = UnlockFunctionService.method("CanAccess", 1);
    canAccessMethod.implementation = function (type) {
      try {
        const unlockType = arguments[0].value;
        console.log(
          `[HOOK 3] Ép UnlockFunctionService.CanAccess cho loại ${unlockType} trả về TRUE.`
        );
      } catch (e) {
        console.log(
          `[HOOK 3] Ép UnlockFunctionService.CanAccess (không có tham số) trả về TRUE.`
        );
      }
      return true;
    };
    console.log("[OK] Chiến lược 3: Đã hook thành công vào CanAccess.");
  } catch (err) {
    console.error(`[!!!] Lỗi ở Chiến lược 3 (General Unlock): ${err.message}`);
  }

  console.log(
    "\n[SUCCESS] Tất cả các hook đã được áp dụng. Hãy vào game và kiểm tra lại!"
  );
});
