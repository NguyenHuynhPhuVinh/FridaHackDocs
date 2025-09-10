console.log("[*] Final Cheat (Interceptor.replace) Initializing...");
console.log("[*] This script will reverse transactions in the shop.");

const libName = "libil2cpp.so";
// === OFFSET CỦA hàm player_currency_element.Use(double num) ===
// Dựa trên tài liệu bạn đã phân tích:
const useCurrencyOffset = 0x18b93dc;

function tryHook() {
  const lib = Process.findModuleByName(libName);
  if (lib) {
    try {
      const useAddress = lib.base.add(useCurrencyOffset);
      console.log(`[*] Found target function Use() at: ${useAddress}`);

      // Tạo một con trỏ hàm đến hàm Use() gốc để chúng ta có thể gọi lại nó
      const originalUseFunction = new NativeFunction(useAddress, "void", [
        "pointer",
        "double",
      ]);

      // Thay thế hoàn toàn hàm Use() gốc bằng hàm của chúng ta
      Interceptor.replace(
        useAddress,
        new NativeCallback(
          (self_ptr, amount_to_spend) => {
            console.log(`\n--- [Transaction Intercepted!] ---`);
            console.log(`[*] Game tried to spend: ${amount_to_spend}`);

            // === LOGIC CHEAT: BIẾN TRỪ THÀNH CỘNG ===
            // Thay vì trừ đi 'amount_to_spend', chúng ta sẽ trừ đi một số âm,
            // điều này tương đương với một phép cộng.
            const amountToGain = -amount_to_spend;

            console.log(
              `[*] Reversing transaction. You will now GAIN this amount instead.`
            );

            // Gọi lại hàm gốc với giá trị đã được đảo ngược
            originalUseFunction(self_ptr, amountToGain);
          },
          "void",
          ["pointer", "double"]
        )
      );

      console.log(
        "[+] Cheat is active. Go to the shop and buy something to gain currency."
      );
    } catch (e) {
      console.error(`[!] An error occurred during hooking: ${e.stack}`);
    }
  } else {
    console.log(`[!] ${libName} not found yet. Retrying in 1 second...`);
    setTimeout(tryHook, 1000);
  }
}

// Chờ 2 giây để game tải xong rồi mới hook
setTimeout(tryHook, 2000);
