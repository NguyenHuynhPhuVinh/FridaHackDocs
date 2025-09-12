import "frida-il2cpp-bridge";

console.log("[*] Bắt đầu script Frida toàn diện v3 cho 'A Girl Adrift'...");

let skinsAdded = false;

Il2Cpp.perform(() => {
  console.log("[+] Il2Cpp Bridge đã sẵn sàng!");
  const assembly = Il2Cpp.domain.assembly("Assembly-CSharp");

  // ===================================================================
  // CHỨC NĂNG 1 & 2: MUA SẮM MIỄN PHÍ & HACK VÀNG (Đã hoạt động tốt)
  // ===================================================================
  try {
    const PlayerCurrencyElement = assembly.image.class(
      "player_currency_element"
    );
    const useMethod =
      PlayerCurrencyElement.method("Use").overload("System.Double");
    Interceptor.replace(
      useMethod.virtualAddress,
      new NativeCallback(
        (this_ptr, amount_to_spend_double) => {
          return useMethod.invokeRaw(this_ptr, -amount_to_spend_double);
        },
        "void",
        ["pointer", "double"]
      )
    );
    console.log("[SUCCESS] Chức năng MUA SẮM MIỄN PHÍ đã được kích hoạt!");

    const GOLD_MULTIPLIER = 1000;
    const addMethod = PlayerCurrencyElement.method("Add").overload(
      "System.Double",
      "System.Nullable<UnityEngine.Vector3>",
      "System.Boolean"
    );
    addMethod.implementation = function (num, effect_pos, isWorldPos) {
      let hackedAmount = num * (num > 0 ? GOLD_MULTIPLIER : 1);
      if (num > 0)
        console.log(
          `[*] Phần thưởng: Gốc ${num.toFixed(
            2
          )} ---> Đã hack ${hackedAmount.toFixed(2)} (x${GOLD_MULTIPLIER})`
        );
      return addMethod.bind(this).invoke(hackedAmount, effect_pos, isWorldPos);
    };
    console.log(
      `[SUCCESS] Chức năng HACK VÀNG (x${GOLD_MULTIPLIER}) đã được kích hoạt!`
    );
  } catch (error) {
    console.error("[ERROR] Lỗi ở chức năng Tiền tệ/Vàng:", error.stack);
  }

  // ===================================================================
  // CHỨC NĂNG 3 (SỬA LỖI): MỞ KHÓA IAP - GỌI ĐÚNG OVERLOAD
  // ===================================================================
  try {
    const addonIAP = assembly.image.class("addon_iap");
    const purchaseMethod = addonIAP
      .method("Purchase")
      .overload("data_iap_element");

    purchaseMethod.implementation = function (iap_element_obj) {
      const iapElement = new Il2Cpp.Object(iap_element_obj);
      const iapName = iapElement
        .method("get_name_withoutPrefix")
        .invoke().content;
      console.log(`[*] Chặn mua IAP: "${iapName}". Tự cấp phần thưởng...`);

      const rewardsList = iapElement.field("reward").value;
      const player_ins = assembly.image.class("player").field("ins").value;
      const playerCurrency = player_ins.field("currency").value;

      // SỬA LỖI: Chỉ định rõ overload cần dùng
      const addsMethod = playerCurrency
        .method("Adds")
        .overload(
          "System.Collections.Generic.List<CurNumPair>",
          "System.Nullable<UnityEngine.Vector3>",
          "System.Boolean"
        );

      addsMethod.invoke(rewardsList, NULL, false);
      console.log(
        `[+] Đã cấp thành công phần thưởng cho gói IAP "${iapName}"!`
      );
      return;
    };
    console.log("[SUCCESS] Chức năng MỞ KHÓA IAP (v3) đã được kích hoạt!");
  } catch (error) {
    console.error("[ERROR] Không thể kích hoạt Mở khóa IAP (v3):", error.stack);
  }

  // ===================================================================
  // CHỨC NĂNG 4 (SỬA LỖI): THÊM TẤT CẢ SKINS - GỌI ĐÚNG PHƯƠNG THỨC INSTANCE
  // ===================================================================
  try {
    const UiWinSkin = assembly.image.class("ui_win_skin");
    const onEnableMethod = UiWinSkin.method("OnEnable");

    onEnableMethod.implementation = function () {
      if (!skinsAdded) {
        skinsAdded = true;
        console.log("[*] Cửa sổ skin đã mở. Bắt đầu thêm tất cả skins...");
        try {
          const data_ins = assembly.image.class("data").field("ins").value;
          const player_ins = assembly.image.class("player").field("ins").value;
          const playerSkin = player_ins.field("skin").value;
          const allSkinsList = data_ins
            .field("skin")
            .value.method("get_list")
            .invoke();

          // SỬA LỖI: Lấy phương thức `Add` trực tiếp từ đối tượng `playerSkin`
          const addSkinMethod = playerSkin
            .method("Add")
            .overload("data_skin_element");

          const count = allSkinsList.method("get_Count").invoke();
          for (let i = 0; i < count; i++) {
            const skinElement = allSkinsList.method("get_Item").invoke(i);
            // Khi gọi, không cần truyền 'playerSkin' nữa vì Frida tự xử lý
            addSkinMethod.invoke(skinElement);
          }
          console.log(`[+] Đã thêm thành công ${count} skins!`);
        } catch (e) {
          console.error("[ERROR] Lỗi khi đang thêm skin:", e.stack);
        }
      }
      return onEnableMethod.bind(this).invoke();
    };
    console.log(
      "[SUCCESS] Chức năng THÊM SKINS (v3) đã sẵn sàng! Hãy mở cửa hàng/kho đồ skin."
    );
  } catch (error) {
    console.error("[ERROR] Không thể kích hoạt Thêm Skins (v3):", error.stack);
  }

  // ===================================================================
  // CHỨC NĂNG 5: VƯỢT QUA YÊU CẦU NHIỆM VỤ (Đã hoạt động tốt)
  // ===================================================================
  try {
    const PlayerQuest = assembly.image.class("player_quest");
    const isCompletedMethod =
      PlayerQuest.method("Is_Completed_Quest").overload("data_quest_element");
    isCompletedMethod.implementation = function (quest_element) {
      const originalResult = isCompletedMethod.bind(this).invoke(quest_element);
      if (originalResult) return true;

      const questName = new Il2Cpp.Object(quest_element)
        .method("get_name_withoutPrefix")
        .invoke().content;
      console.log(`[*] Vượt qua yêu cầu nhiệm vụ: "${questName}"`);
      return true;
    };
    console.log(
      "[SUCCESS] Chức năng VƯỢT QUA YÊU CẦU NHIỆM VỤ đã được kích hoạt!"
    );
  } catch (error) {
    console.error(
      "[ERROR] Không thể kích hoạt Vượt qua yêu cầu nhiệm vụ:",
      error.stack
    );
  }

  console.log(
    "\n[***] SCRIPT V3 ĐÃ KÍCH HOẠT. MỌI LỖI ĐÃ ĐƯỢC SỬA. CHÚC BẠN CHƠI GAME VUI VẺ! [***]"
  );
});
