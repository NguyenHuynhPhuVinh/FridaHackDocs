/*
 * Script Frida TỐI THƯỢỢNG để tạo bản đồ API (v2).
 * Stalker sẽ in ra tất cả các syscall để đảm bảo không bỏ sót.
 * Cách chạy: frida -U "Chuyện Công Chúa" -l ultimate_api_mapper_v2.js
 */

"use strict";

// ======================= Stalker (Tầng Thấp - Chế độ Brute-force) =======================
function startStalkerSpy() {
  console.log("[Stalker] Activating BRUTE-FORCE syscall monitoring...");

  // Một từ điển nhỏ để tra cứu tên syscall, không cần đầy đủ
  const syscallNames = {
    63: "read",
    64: "write",
    203: "connect",
    206: "sendto",
    207: "recvfrom",
    214: "sendmsg",
    215: "recvmsg",
  };

  Process.enumerateThreads({
    onMatch: function (thread) {
      try {
        Stalker.follow(thread.id, {
          events: {
            call: false,
            ret: false,
            exec: false,
            block: false,
            compile: true, // Chỉ cần compile một lần
          },
          onReceive: function (events) {
            // Chúng ta không cần phân tích sâu ở đây, chỉ cần biết syscall nào được gọi
          },
          transform: function (iterator) {
            let instruction = iterator.next();
            while (instruction !== null) {
              if (
                instruction.mnemonic === "svc" &&
                instruction.opStr === "#0"
              ) {
                iterator.putCallout(function (context) {
                  const syscall_nr = context.x8.toInt32();
                  const name = syscallNames[syscall_nr] || "UNKNOWN";

                  // In ra MỌI syscall để chúng ta có thể xem
                  console.log(`[Stalker] Syscall: ${name} (${syscall_nr})`);

                  // Nếu là một trong các syscall gửi dữ liệu, in hexdump
                  if (
                    syscall_nr === 206 ||
                    syscall_nr === 214 ||
                    syscall_nr === 64
                  ) {
                    // sendto, sendmsg, write
                    const buffer = context.x1;
                    const len = context.x2.toInt32();
                    if (len > 0) {
                      console.log(
                        `\n--- [STALKER: Raw Packet Sent via syscall ${syscall_nr}] ${len} bytes ---`
                      );
                      console.log(
                        hexdump(buffer, { length: Math.min(len, 128) })
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
      } catch (e) {}
    },
    onComplete: function () {},
  });
}

// ======================= Il2Cpp Hooks (Tầng Cao) =======================
import "frida-il2cpp-bridge";

Il2Cpp.perform(() => {
  console.log("[Il2Cpp] Bridge is ready. Hooking NetworkManager API calls...");

  try {
    const assemblyCSharp = Il2Cpp.domain.assembly("Assembly-CSharp");
    const NetworkManager = assemblyCSharp.image.class("NetworkManager");

    NetworkManager.methods.forEach((method) => {
      if (method.name.startsWith("Send_") && !method.virtualAddress.isNull()) {
        try {
          Interceptor.attach(method.virtualAddress, {
            onEnter(args) {
              console.log(
                `\n[Il2Cpp] API Call -> NetworkManager::${method.name}`
              );
            },
          });
        } catch (e) {}
      }
    });

    startStalkerSpy();

    console.log("\n[OK] Ultimate API Mapper v2 is active. Play the game.");
  } catch (err) {
    console.error(`[!!!] An Il2Cpp error occurred: ${err.message}`);
  }
});
