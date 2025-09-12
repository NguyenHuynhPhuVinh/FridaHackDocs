import "frida-il2cpp-bridge";

console.log("[*] Bắt đầu script Frida HOÀN CHỈNH v7 cho 'A Girl Adrift'...");

let skinsAdded = false;
let rankMaxed = false;

Il2Cpp.perform(() => {
  console.log("[+] Il2Cpp Bridge đã sẵn sàng!");
  const assembly = Il2Cpp.domain.assembly("Assembly-CSharp");
  const playerIns = assembly.image.class("player").field("ins");
  const dataIns = assembly.image.class("data").field("ins");

  // ===================================================================
  // CHỨC NĂNG 6 (MỚI): MAX RANK & LEVEL - TỰ ĐỘNG KHI MỞ CÀI ĐẶT
  // ===================================================================
  try {
    const UiWinSetting = assembly.image.class("ui_win_setting");
    const onEnableSettingMethod = UiWinSetting.method("OnEnable");

    onEnableSettingMethod.implementation = function () {
      if (!rankMaxed) {
        rankMaxed = true;
        console.log(
          "[*] Cửa sổ Cài đặt đã mở. Bắt đầu mô phỏng lên Rank & Level..."
        );
        try {
          const playerCharacter = playerIns.value.field("character").value;
          const DataSetting = assembly.image.class("data_setting");
          const MAX_RANK = DataSetting.field("MAX_RANK").value;

          const currentRank = playerCharacter.method("get_rank").invoke();
          const ranksToAdd = MAX_RANK - currentRank;

          if (ranksToAdd > 0) {
            console.log(`[+] Cần lên ${ranksToAdd} rank. Bắt đầu quá trình...`);
            const addRankMethod = playerCharacter.method("Add_Rank");
            for (let i = 0; i < ranksToAdd; i++) {
              addRankMethod.invoke();
            }
            console.log(`[+] Đã lên đủ ${ranksToAdd} rank!`);
          } else {
            console.log(`[+] Rank đã ở mức tối đa (${currentRank}).`);
          }

          console.log(`[+] Đặt Level tối đa theo Rank...`);
          playerCharacter.method("Godmod_Set_Lv_Max").invoke();

          console.log(
            "[SUCCESS] Đã hack Rank và Level thành công! Giao diện sẽ tự cập nhật."
          );
        } catch (e) {
          console.error("[ERROR] Lỗi khi đang hack Rank & Level:", e.stack);
        }
      }

      return onEnableSettingMethod.bind(this).invoke();
    };
    console.log(
      "[SUCCESS] Chức năng MAX RANK & LEVEL đã sẵn sàng! Hãy mở cửa sổ Cài đặt (Settings)."
    );
  } catch (error) {
    console.error("[ERROR] Không thể kích hoạt Max Rank & Level:", error.stack);
  }

  // ===================================================================
  // CÁC CHỨC NĂNG CŨ (Đã hoạt động tốt)
  // ===================================================================
  try {
    const PlayerCurrencyElement = assembly.image.class(
      "player_currency_element"
    );
    const useMethod =
      PlayerCurrencyElement.method("Use").overload("System.Double");
    useMethod.implementation = function (amount) {
      return this.method("Use").invoke(-amount);
    };
    console.log("[SUCCESS] Chức năng MUA SẮM MIỄN PHÍ đã được kích hoạt!");

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
      maxField.value = ObscuredDouble.method("op_Implicit").invoke(
        Number.MAX_SAFE_INTEGER
      );
      let hackedAmount = num > 0 ? num * GOLD_MULTIPLIER : num;
      if (num > 0)
        console.log(
          `[*] Phần thưởng: Gốc ${num.toFixed(
            2
          )} -> Hack ${hackedAmount.toFixed(2)}`
        );
      const result = addMethod
        .bind(this)
        .invoke(hackedAmount, effect_pos, isWorldPos);
      maxField.value = originalMax;
      return result;
    };
    console.log(
      "[SUCCESS] Chức năng HACK VÀNG & GỠ BỎ GIỚI HẠN TÀI NGUYÊN đã được kích hoạt!"
    );

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

    const UiWinSkin = assembly.image.class("ui_win_skin");
    const onEnableSkinMethod = UiWinSkin.method("OnEnable");
    onEnableSkinMethod.implementation = function () {
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
          for (let i = 0; i < count; i++)
            addSkinMethod.invoke(allSkinsList.method("get_Item").invoke(i));
          console.log(`[+] Đã thêm thành công ${count} skins!`);
        } catch (e) {
          console.error("[ERROR] Lỗi khi đang thêm skin:", e.stack);
        }
      }
      return onEnableSkinMethod.bind(this).invoke();
    };
    console.log(
      "[SUCCESS] Chức năng THÊM SKINS đã sẵn sàng! Hãy mở cửa hàng/kho đồ skin."
    );

    const PlayerQuest = assembly.image.class("player_quest");
    const isCompletedMethod =
      PlayerQuest.method("Is_Completed_Quest").overload("data_quest_element");
    isCompletedMethod.implementation = function (quest_element) {
      if (isCompletedMethod.bind(this).invoke(quest_element)) return true;
      console.log(`[*] Vượt qua yêu cầu nhiệm vụ.`);
      return true;
    };
    console.log(
      "[SUCCESS] Chức năng VƯỢT QUA YÊU CẦU NHIỆM VỤ đã được kích hoạt!"
    );
  } catch (error) {
    console.error(
      "[ERROR] Lỗi khi thiết lập các chức năng cơ bản:",
      error.stack
    );
  }

  console.log(
    "\n[***] SCRIPT HOÀN CHỈNH ĐÃ KÍCH HOẠT. TẤT CẢ TÍNH NĂNG ĐÃ SẴN SÀNG! [***]"
  );
});
