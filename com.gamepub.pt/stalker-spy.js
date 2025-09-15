/*
 * Script Frida để gián điệp syscall mạng bằng Stalker.
 * Đây là phương pháp theo dõi cấp thấp và toàn diện nhất.
 * Cách chạy: frida -U "Chuyện Công Chúa" --no-pause -l stalker_spy.js
 */

"use strict";

console.log("[*] Starting Syscall Network Spy using Stalker...");

// Số hiệu syscall cho kiến trúc aarch64
const SYSCALLS_ARM64 = {
  connect: 203,
  sendto: 206,
  recvfrom: 207,
};

// Hàm để theo dõi một luồng cụ thể
function traceThread(threadId) {
  console.log(`[+] Stalking thread ${threadId}`);

  Stalker.follow(threadId, {
    transform: function (iterator) {
      let instruction = iterator.next();
      // Lặp qua từng lệnh và kiểm tra
      while (instruction !== null) {
        // Kiểm tra xem có phải là lệnh 'svc #0' không
        // 'svc #0' có mã hex là 01 00 00 d4
        if (instruction.mnemonic === "svc" && instruction.opStr === "#0") {
          // Chèn một lời gọi đến hàm của chúng ta ngay trước lệnh svc
          iterator.putCallout(function (context) {
            // Thanh ghi x8 chứa số hiệu syscall trên aarch64
            const syscall_nr = context.x8.toInt32();

            if (syscall_nr === SYSCALLS_ARM64.connect) {
              try {
                const fd = context.x0.toInt32();
                const sockaddr = context.x1;
                const family = sockaddr.readU16();
                if (family === 2) {
                  // AF_INET
                  const port =
                    ((sockaddr.add(2).readU16() & 0xff) << 8) |
                    ((sockaddr.add(2).readU16() >> 8) & 0xff);
                  const ip = sockaddr.add(4).readU32();
                  const readableIp = `${ip & 0xff}.${(ip >> 8) & 0xff}.${
                    (ip >> 16) & 0xff
                  }.${(ip >> 24) & 0xff}`;
                  console.log(
                    `\n[STALKER] SYSCALL connect: fd=${fd}, addr=${readableIp}:${port}`
                  );
                }
              } catch (e) {}
            } else if (syscall_nr === SYSCALLS_ARM64.sendto) {
              try {
                const fd = context.x0.toInt32();
                const buffer = context.x1;
                const len = context.x2.toInt32();
                if (len > 0) {
                  console.log(
                    `\n============== [STALKER SEND] fd=${fd}, Bytes: ${len} ==============`
                  );
                  console.log(hexdump(buffer, { length: Math.min(len, 128) }));
                  console.log(
                    `========================================================================\n`
                  );
                }
              } catch (e) {}
            } else if (syscall_nr === SYSCALLS_ARM64.recvfrom) {
              // Việc bắt recvfrom khó hơn vì dữ liệu được ghi vào buffer sau khi syscall trả về.
              // Tạm thời chúng ta chỉ tập trung vào connect và send.
            }
          });
        }
        iterator.keep(); // Giữ lại lệnh gốc
        instruction = iterator.next();
      }
    },
  });
}

// Bắt đầu theo dõi luồng chính
// Lưu ý: Các hoạt động mạng có thể xảy ra trên các luồng khác.
// Để bắt tất cả, chúng ta cần theo dõi các luồng mới được tạo.
const mainThreadId = Process.id;
traceThread(mainThreadId);

// Theo dõi các luồng mới
Process.enumerateThreads({
  onMatch: function (thread) {
    if (thread.id !== mainThreadId) {
      try {
        // Thêm một chút delay để tránh stalk các luồng khởi tạo hệ thống
        setTimeout(() => traceThread(thread.id), 100);
      } catch (e) {}
    }
  },
  onComplete: function () {},
});

console.log(
  "[OK] Stalker is active. It will trace all threads. This may be slow."
);
console.log("[!] Play the game and trigger a network action.");
