/*
 * Script Frida HOÀN CHỈNH để mở khóa tất cả các cảnh H trong game.
 * Dựa trên phân tích mã nguồn từ Assembly-CSharp.cs và part11.cs.
 *
 * --- CÁC CHIẾN LƯỢC HOOK ---
 * 1. Hook Yêu Cầu Độ Thân Mật: Gỡ bỏ việc kiểm tra cấp độ thân mật để mở khóa các nút bấm xem kịch bản nhân vật. Đây là phương pháp trực tiếp và có khả năng thành công cao nhất.
 * 2. Hook "Đã Xem": Ép game nghĩ rằng tất cả các kịch bản (episode) tiên quyết đã được xem, mở khóa các nội dung phụ thuộc.
 * 3. Hook "Mở Khóa Tính Năng": Một phương pháp tổng quát để mở khóa các tính năng bị giới hạn trong game, có thể bao gồm cả các cảnh đặc biệt.
 *
 * Cách chạy: frida -U "Tên Game Của Bạn" --no-pause -l unlock_h_scenes.js
 */

import "frida-il2cpp-bridge";

// ======================= CẤU HÌNH =======================
// Bạn không cần thay đổi gì ở đây. Script được thiết kế để tự động hóa.
// ==========================================================

Il2Cpp.perform(() => {
  console.log("[+] Il2Cpp Bridge đã sẵn sàng. Bắt đầu quá trình mở khóa...");

  // --- CHIẾN LƯỢC 1: Bỏ qua kiểm tra độ thân mật (Affection Check Bypass) ---
  try {
    const CharacterDetailParameterController = Il2Cpp.domain
      .assembly("Assembly-CSharp")
      .image.class(
        "Assets.GameUi.CharacterDetail.Parameter.CharacterDetailParameterController"
      );

    // Tìm phương thức có 2 tham số (int, int)
    const applyLockMethod = CharacterDetailParameterController.method(
      "ApplyCharacterEpisodeButtonLock",
      2
    );

    console.log(
      `[+] Tìm thấy phương thức khóa nút kịch bản tại: ${applyLockMethod.virtualAddress}`
    );

    Interceptor.attach(applyLockMethod.virtualAddress, {
      onEnter(args) {
        // args[0] là 'this', args[1] là affectionLevelToUnlockScenario, args[2] là affectionLevel
        const requiredLevel = new Il2Cpp.Value(args[1], "int32").value;
        const currentLevel = new Il2Cpp.Value(args[2], "int32").value;

        console.log(`[HOOK 1] Đang kiểm tra nút kịch bản...`);
        console.log(
          `    - Yêu cầu: Cấp ${requiredLevel}, Hiện tại: Cấp ${currentLevel}`
        );

        // Sửa đổi tham số 'affectionLevel' để nó luôn bằng mức yêu cầu
        if (currentLevel < requiredLevel) {
          console.log(
            `    - [!] Độ thân mật không đủ. Đang sửa đổi để mở khóa...`
          );
          args[2] = args[1]; // Gán giá trị yêu cầu cho giá trị hiện tại
        }
      },
    });

    console.log(
      "[OK] Chiến lược 1: Đã hook thành công vào việc kiểm tra độ thân mật."
    );
  } catch (err) {
    console.error(`[!!!] Lỗi ở Chiến lược 1 (Affection Hook): ${err.message}`);
  }

  // --- CHIẾN LƯỢC 2: Ép game nghĩ rằng mọi kịch bản đã được xem (IsReadEpisode Bypass) ---
  try {
    const EpisodeService = Il2Cpp.domain
      .assembly("Assembly-CSharp")
      .image.class("Assets.GameUi.Service.EpisodeService");

    const isReadMethod = EpisodeService.method("IsReadEpisode", 1);
    console.log(
      `[+] Tìm thấy phương thức kiểm tra kịch bản tại: ${isReadMethod.virtualAddress}`
    );

    isReadMethod.implementation = function (episodeMasterId) {
      // Bỏ qua logic gốc và luôn trả về true
      console.log(
        `[HOOK 2] Ép IsReadEpisode cho ID ${this.arg0.value} trả về TRUE.`
      );
      return true;
    };

    console.log("[OK] Chiến lược 2: Đã hook thành công vào IsReadEpisode.");
  } catch (err) {
    console.error(`[!!!] Lỗi ở Chiến lược 2 (IsRead Hook): ${err.message}`);
  }

  // --- CHIẾN LƯỢC 3: Mở khóa tất cả các tính năng bị giới hạn (General Unlock) ---
  try {
    const UnlockFunctionService = Il2Cpp.domain
      .assembly("Assembly-CSharp")
      .image.class("Assets.GameUi.Service.UnlockFunctionService");

    // Hook vào phiên bản đơn giản nhất của CanAccess
    const canAccessMethod = UnlockFunctionService.method("CanAccess", 1);
    console.log(
      `[+] Tìm thấy phương thức mở khóa tính năng tại: ${canAccessMethod.virtualAddress}`
    );

    canAccessMethod.implementation = function (type) {
      console.log(
        `[HOOK 3] Ép UnlockFunctionService.CanAccess cho loại ${this.arg0.value} trả về TRUE.`
      );
      return true;
    };

    console.log("[OK] Chiến lược 3: Đã hook thành công vào CanAccess.");
  } catch (err) {
    console.error(`[!!!] Lỗi ở Chiến lược 3 (General Unlock): ${err.message}`);
  }

  console.log(
    "\n[SUCCESS] Tất cả các hook đã được áp dụng. Hãy vào game và kiểm tra kết quả!"
  );
  console.log(
    "Gợi ý: Vào màn hình Hồ sơ nhân vật (Character Profile) hoặc Album để xem các kịch bản đã mở khóa."
  );
});
