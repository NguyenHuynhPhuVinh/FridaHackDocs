import "frida-il2cpp-bridge";

console.log("[*] Bắt đầu script Frida HOÀN CHỈNH v3 cho 'A Girl Adrift'...");

let skinsAdded = false;

Il2Cpp.perform(() => {
  console.log("[+] Il2Cpp Bridge đã sẵn sàng!");
  const assembly = Il2Cpp.domain.assembly("Assembly-CSharp");
  const playerIns = assembly.image.class("player").field("ins");
  const dataIns = assembly.image.class("data").field("ins");

  // ===================================================================
  // CHỨC NĂNG 1, 2, 3: TIỀN TỆ, HACK VÀNG, IAP, GỠ BỎ GIỚI HẠN
  // ===================================================================
  try {
    const PlayerCurrencyElement = assembly.image.class(
      "player_currency_element"
    );

    // Mua sắm miễn phí
    const useMethod =
      PlayerCurrencyElement.method("Use").overload("System.Double");
    useMethod.implementation = function (amount) {
      console.log(
        `[*] Mua sắm: Chi tiêu gốc ${amount}, đã sửa thành ${-amount}`
      );
      return this.method("Use").invoke(-amount);
    };
    console.log("[SUCCESS] Chức năng MUA SẮM MIỄN PHÍ đã được kích hoạt!");

    // Hack vàng & GỠ BỎ GIỚI HẠN TÀI NGUYÊN
    const GOLD_MULTIPLIER = 1000;
    const addMethod = PlayerCurrencyElement.method("Add").overload(
      "System.Double",
      "System.Nullable<UnityEngine.Vector3>",
      "System.Boolean"
    );

    addMethod.implementation = function (num, effect_pos, isWorldPos) {
      const self = this;
      const dataElement = self.field("<element>k__BackingField").value;
      const maxField = dataElement.field("max");

      const originalMax = maxField.value;

      const ObscuredDouble = assembly.image.class(
        "CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble"
      );
      const newMax = ObscuredDouble.method("op_Implicit").invoke(
        Number.MAX_SAFE_INTEGER
      );
      maxField.value = newMax;

      let hackedAmount = num;
      if (num > 0) {
        hackedAmount = num * GOLD_MULTIPLIER;
        console.log(
          `[*] Phần thưởng: Gốc ${num.toFixed(
            2
          )} ---> Đã hack ${hackedAmount.toFixed(2)} (x${GOLD_MULTIPLIER})`
        );
      }

      // SỬA LỖI: Gọi hàm gốc bằng cách sử dụng lại chính đối tượng 'addMethod'
      const result = addMethod
        .bind(this)
        .invoke(hackedAmount, effect_pos, isWorldPos);

      maxField.value = originalMax;

      return result;
    };
    console.log(
      "[SUCCESS] Chức năng HACK VÀNG & GỠ BỎ GIỚI HẠN TÀI NGUYÊN đã được kích hoạt!"
    );

    // Mở khóa IAP
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
      const playerCurrency = playerIns.value.field("currency").value;
      const addsMethod = playerCurrency
        .method("Adds")
        .overload("System.Collections.Generic.List<CurNumPair>");
      addsMethod.invoke(rewardsList);
      console.log(
        `[+] Đã cấp thành công phần thưởng cho gói IAP "${iapName}"!`
      );
    };
    console.log("[SUCCESS] Chức năng MỞ KHÓA IAP đã được kích hoạt!");
  } catch (error) {
    console.error("[ERROR] Lỗi ở chức năng Tiền tệ/Vàng/IAP:", error.stack);
  }

  // ===================================================================
  // CHỨC NĂNG 4 & 5: SKINS & NHIỆM VỤ (Đã hoạt động tốt)
  // ===================================================================
  try {
    const UiWinSkin = assembly.image.class("ui_win_skin");
    const onEnableMethod = UiWinSkin.method("OnEnable");
    onEnableMethod.implementation = function () {
      if (!skinsAdded) {
        skinsAdded = true;
        console.log("[*] Cửa sổ skin đã mở. Bắt đầu thêm tất cả skins...");
        try {
          const playerSkin = playerIns.value.field("skin").value;
          const allSkinsList = dataIns.value
            .field("skin")
            .value.method("get_list")
            .invoke();
          const addSkinMethod = playerSkin
            .method("Add")
            .overload("data_skin_element");
          const count = allSkinsList.method("get_Count").invoke();
          for (let i = 0; i < count; i++) {
            addSkinMethod.invoke(allSkinsList.method("get_Item").invoke(i));
          }
          console.log(`[+] Đã thêm thành công ${count} skins!`);
        } catch (e) {
          console.error("[ERROR] Lỗi khi đang thêm skin:", e.stack);
        }
      }
      return onEnableMethod.bind(this).invoke();
    };
    console.log(
      "[SUCCESS] Chức năng THÊM SKINS đã sẵn sàng! Hãy mở cửa hàng/kho đồ skin."
    );

    const PlayerQuest = assembly.image.class("player_quest");
    const isCompletedMethod =
      PlayerQuest.method("Is_Completed_Quest").overload("data_quest_element");
    isCompletedMethod.implementation = function (quest_element) {
      if (isCompletedMethod.bind(this).invoke(quest_element)) return true;
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
    console.error("[ERROR] Lỗi ở chức năng Skins/Nhiệm vụ:", error.stack);
  }

  console.log(
    "\n[***] SCRIPT HOÀN CHỈNH ĐÃ KÍCH HOẠT. CHÚC BẠN TẬN HƯỞNG TRÒ CHƠI! [***]"
  );
});
