/*
 * Script Frida HOÀN CHỈNH V8 để hack tốc độ game.
 * Mục tiêu: Tăng tốc độ game để farm tài nguyên nhanh hơn.
 * Đã sửa lỗi: 'this.detach is not a function'.
 * Cách chạy: frida -U "Chuyện Công Chúa" --no-pause -l hack_speed_final.js
 */

import "frida-il2cpp-bridge";

// ======================= CẤU HÌNH =======================
const GAME_SPEED_MULTIPLIER = 5.0;
// ==========================================================

Il2Cpp.perform(() => {
  console.log("[+] Il2Cpp Bridge is ready. Preparing to accelerate time...");

  try {
    const assembly = Il2Cpp.domain.assembly("UnityEngine.CoreModule");
    if (assembly.handle.isNull()) {
      console.error("[!!!] Could not find assembly 'UnityEngine.CoreModule'.");
      return;
    }

    const Time = assembly.image.class("UnityEngine.Time");
    const setTimeScaleMethod = Time.method("set_timeScale", 1);
    console.log(
      `[+] Found UnityEngine.Time.set_timeScale at: ${setTimeScaleMethod.virtualAddress}`
    );

    const InGameController = Il2Cpp.domain
      .assembly("Assembly-CSharp")
      .image.class("InGameController");
    const updateMethod = InGameController.method("Update");

    console.log(
      `[*] Hooking ${InGameController.name}::Update to safely set game speed.`
    );

    // Biến để lưu trữ listener và cờ
    let updateListener = null;
    let speedHasBeenSet = false;

    // Lưu listener trả về từ Interceptor.attach
    updateListener = Interceptor.attach(updateMethod.virtualAddress, {
      onEnter(args) {
        if (!speedHasBeenSet) {
          speedHasBeenSet = true;

          console.log(
            `[*] Setting Time.timeScale to: ${GAME_SPEED_MULTIPLIER}`
          );
          setTimeScaleMethod.invoke(GAME_SPEED_MULTIPLIER);

          // === PHẦN ĐÃ SỬA ===
          // Gọi detach() từ biến đã lưu listener
          if (updateListener) {
            updateListener.detach();
          }
          console.log(
            "[OK] Game speed has been set. The hook is now detached."
          );
        }
      },
    });
  } catch (err) {
    console.error(
      `[!!!] An error occurred during speed hack initialization: ${err.message}`
    );
    console.log("[!] Fallback: Trying to set speed directly.");
    try {
      Il2Cpp.domain
        .assembly("UnityEngine.CoreModule")
        .image.class("UnityEngine.Time")
        .method("set_timeScale", 1)
        .invoke(GAME_SPEED_MULTIPLIER);
      console.log("[OK] Game speed set via fallback method.");
    } catch (fallbackErr) {
      console.error(
        `[!!!] Fallback method also failed: ${fallbackErr.message}`
      );
    }
  }
});
