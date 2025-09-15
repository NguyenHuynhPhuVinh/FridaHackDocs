"use strict";
console.log("[STALKER SPY] Starting Syscall Network Spy using Stalker...");
const SYSCALLS_ARM64 = { connect: 203, sendto: 206, recvfrom: 207 };
function traceThread(threadId) {
  try {
    Stalker.follow(threadId, {
      transform: function (iterator) {
        let instruction = iterator.next();
        while (instruction !== null) {
          if (instruction.mnemonic === "svc" && instruction.opStr === "#0") {
            iterator.putCallout(function (context) {
              const syscall_nr = context.x8.toInt32();
              if (syscall_nr === SYSCALLS_ARM64.sendto) {
                try {
                  const fd = context.x0.toInt32();
                  const buffer = context.x1;
                  const len = context.x2.toInt32();
                  if (len > 0) {
                    // Gửi message về Python/console thay vì log trực tiếp
                    send({
                      type: "stalker",
                      direction: "send",
                      length: len,
                      data: buffer.readByteArray(Math.min(len, 256)),
                    });
                  }
                } catch (e) {}
              }
            });
          }
          iterator.keep();
          instruction = iterator.next();
        }
      },
    });
  } catch (e) {}
}
const mainThreadId = Process.id;
traceThread(mainThreadId);
Process.enumerateThreads({
  onMatch: function (thread) {
    if (thread.id !== mainThreadId) {
      traceThread(thread.id);
    }
  },
  onComplete: function () {},
});
console.log("[STALKER SPY] Stalker is active.");
