📦
3493 /stalker-spy.js
✄
var __getOwnPropNames = Object.getOwnPropertyNames;
var __esm = (fn, res) => function __init() {
  return fn && (res = (0, fn[__getOwnPropNames(fn)[0]])(fn = 0)), res;
};
var __commonJS = (cb, mod) => function __require() {
  return mod || (0, cb[__getOwnPropNames(cb)[0]])((mod = { exports: {} }).exports, mod), mod.exports;
};

// frida-builtins:/node-globals.js
var init_node_globals = __esm({
  "frida-builtins:/node-globals.js"() {
  }
});

// stalker-spy.js
var require_stalker_spy = __commonJS({
  "stalker-spy.js"() {
    init_node_globals();
    console.log("[*] Starting Syscall Network Spy using Stalker...");
    var SYSCALLS_ARM64 = {
      connect: 203,
      sendto: 206,
      recvfrom: 207
    };
    function traceThread(threadId) {
      console.log(`[+] Stalking thread ${threadId}`);
      Stalker.follow(threadId, {
        transform: function(iterator) {
          let instruction = iterator.next();
          while (instruction !== null) {
            if (instruction.mnemonic === "svc" && instruction.opStr === "#0") {
              iterator.putCallout(function(context) {
                const syscall_nr = context.x8.toInt32();
                if (syscall_nr === SYSCALLS_ARM64.connect) {
                  try {
                    const fd = context.x0.toInt32();
                    const sockaddr = context.x1;
                    const family = sockaddr.readU16();
                    if (family === 2) {
                      const port = (sockaddr.add(2).readU16() & 255) << 8 | sockaddr.add(2).readU16() >> 8 & 255;
                      const ip = sockaddr.add(4).readU32();
                      const readableIp = `${ip & 255}.${ip >> 8 & 255}.${ip >> 16 & 255}.${ip >> 24 & 255}`;
                      console.log(
                        `
[STALKER] SYSCALL connect: fd=${fd}, addr=${readableIp}:${port}`
                      );
                    }
                  } catch (e) {
                  }
                } else if (syscall_nr === SYSCALLS_ARM64.sendto) {
                  try {
                    const fd = context.x0.toInt32();
                    const buffer = context.x1;
                    const len = context.x2.toInt32();
                    if (len > 0) {
                      console.log(
                        `
============== [STALKER SEND] fd=${fd}, Bytes: ${len} ==============`
                      );
                      console.log(hexdump(buffer, { length: Math.min(len, 128) }));
                      console.log(
                        `========================================================================
`
                      );
                    }
                  } catch (e) {
                  }
                } else if (syscall_nr === SYSCALLS_ARM64.recvfrom) {
                }
              });
            }
            iterator.keep();
            instruction = iterator.next();
          }
        }
      });
    }
    var mainThreadId = Process.id;
    traceThread(mainThreadId);
    Process.enumerateThreads({
      onMatch: function(thread) {
        if (thread.id !== mainThreadId) {
          try {
            setTimeout(() => traceThread(thread.id), 100);
          } catch (e) {
          }
        }
      },
      onComplete: function() {
      }
    });
    console.log(
      "[OK] Stalker is active. It will trace all threads. This may be slow."
    );
    console.log("[!] Play the game and trigger a network action.");
  }
});
export default require_stalker_spy();
