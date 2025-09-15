/*
 * Script Frida TỐI THƯỢỢNG để tạo bản đồ API.
 * Kết hợp Il2Cpp để lấy tên API và Stalker để lấy dữ liệu thô.
 * Cách chạy: frida -U "Chuyện Công Chúa" --no-pause -l ultimate_api_mapper.js
 */

"use strict";

// ======================= Tầng Syscall (Stalker) =======================
function startStalkerSpy() {
  console.log("[Stalker] Activating syscall monitoring...");
  const SYSCALL_SENDTO = 206; // aarch64 syscall number for sendto

  Process.enumerateThreads({
    onMatch: function (thread) {
      try {
        Stalker.follow(thread.id, {
          transform: function (iterator) {
            let instruction = iterator.next();
            while (instruction !== null) {
              if (
                instruction.mnemonic === "svc" &&
                instruction.opStr === "#0"
              ) {
                iterator.putCallout(function (context) {
                  if (context.x8.toInt32() === SYSCALL_SENDTO) {
                    const buffer = context.x1;
                    const len = context.x2.toInt32();
                    if (len > 0) {
                      console.log(
                        `\n--- [STALKER: Raw Packet Sent] ${len} bytes ---`
                      );
                      // In ra hexdump. Dữ liệu này sẽ tương ứng với lời gọi API ngay trước đó.
                      console.log(
                        hexdump(buffer, { length: Math.min(len, 256) })
                      );
                      console.log(`------------------------------------------`);
                    }
                  }
                });
              }
              iterator.keep();
              instruction = iterator.next();
            }
          },
        });
      } catch (e) {
        /* Bỏ qua các luồng không thể theo dõi */
      }
    },
    onComplete: function () {},
  });
}

// ======================= Tầng Il2Cpp =======================
import "frida-il2cpp-bridge";

Il2Cpp.perform(() => {
  console.log("[Il2Cpp] Bridge is ready. Hooking NetworkManager API calls...");

  try {
    const assemblyCSharp = Il2Cpp.domain.assembly("Assembly-CSharp");
    const NetworkManager = assemblyCSharp.image.class("NetworkManager");

    let hookedCount = 0;
    NetworkManager.methods.forEach((method) => {
      // Chỉ hook các hàm Send_...
      if (method.name.startsWith("Send_") && !method.virtualAddress.isNull()) {
        try {
          Interceptor.attach(method.virtualAddress, {
            onEnter(args) {
              // Chỉ in ra tên của API được gọi
              console.log(
                `\n[Il2Cpp] API Call -> NetworkManager::${method.name}`
              );
            },
          });
          hookedCount++;
        } catch (e) {}
      }
    });

    console.log(`[Il2Cpp] Hooked ${hookedCount} Send_ methods.`);

    // Khởi động Stalker
    startStalkerSpy();

    console.log(
      "\n[OK] Ultimate API Mapper is active. Play the game to log API calls and their raw data."
    );
  } catch (err) {
    console.error(`[!!!] An Il2Cpp error occurred: ${err.message}`);
  }
});
