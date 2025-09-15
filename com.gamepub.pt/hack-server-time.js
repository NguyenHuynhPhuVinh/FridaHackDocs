/*
 * Script Frida TỐI THƯỢNG để phân tích API game.
 * Kết hợp Il2Cpp (tầng cao) và Stalker (tầng thấp) để tạo bản đồ API.
 * Cách chạy: frida -U "Chuyện Công Chúa" -l api_analyzer.js
 */

"use strict";

// ======================= Stalker (Tầng Thấp) =======================
// Stalker sẽ chạy ở chế độ nền để bắt tất cả dữ liệu gửi đi.
function startStalker() {
  console.log("[Stalker] Starting to monitor syscalls...");
  const SYSCALL_SENDTO = 206; // aarch64

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
                      console.log(
                        hexdump(buffer, { length: Math.min(len, 128) })
                      );
                      console.log(`--- [END STALKER] ---`);
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
        /* Ignore threads we can't stalk */
      }
    },
    onComplete: function () {},
  });
}

// ======================= Il2Cpp Hooks (Tầng Cao) =======================
import "frida-il2cpp-bridge";

Il2Cpp.perform(() => {
  console.log("[Il2Cpp] Bridge is ready. Hooking NetworkManager...");

  try {
    const assemblyCSharp = Il2Cpp.domain.assembly("Assembly-CSharp");
    const NetworkManager = assemblyCSharp.image.class("NetworkManager");

    // Hook tất cả các hàm Send_... trong NetworkManager
    let hookedCount = 0;
    NetworkManager.methods.forEach((method) => {
      if (method.name.startsWith("Send_") && !method.virtualAddress.isNull()) {
        try {
          Interceptor.attach(method.virtualAddress, {
            onEnter(args) {
              console.log(`\n\n<<<<<<<<<< [API CALL DETECTED] >>>>>>>>>>`);
              console.log(
                `[Il2Cpp Hook] Method: NetworkManager::${method.name}`
              );
              try {
                // Tham số request thường là args[2]
                const requestObject = new Il2Cpp.Object(args[2]);
                console.log(
                  `[Il2Cpp Hook] Request Object Type: ${requestObject.class.fullName}`
                );
                console.log("[Il2Cpp Hook] Request Data (Fields):");

                // In ra tất cả các trường của request
                requestObject.class.fields.forEach((field) => {
                  if (!field.isStatic) {
                    try {
                      const value = field.bind(requestObject).value;
                      console.log(`    - ${field.name}: ${value}`);
                    } catch (e) {
                      console.log(
                        `    - ${field.name}: (Could not read value)`
                      );
                    }
                  }
                });
              } catch (e) {
                console.log(
                  `[Il2Cpp Hook] Could not parse request object for ${method.name}.`
                );
              }
              console.log("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
            },
          });
          hookedCount++;
        } catch (e) {}
      }
    });

    console.log(
      `[Il2Cpp] Hooked ${hookedCount} Send_ methods in NetworkManager.`
    );
    console.log("[OK] API Analyzer is active. Play the game.");

    // Khởi động Stalker sau khi Il2Cpp đã sẵn sàng
    startStalker();
  } catch (err) {
    console.error(
      `[!!!] An Il2Cpp error occurred: ${err.message}\nStack: ${err.stack}`
    );
  }
});
