import "frida-il2cpp-bridge";

console.log(
  "[*] Bắt đầu script Frida TỰ ĐỘNG HOÀN TOÀN v17 cho 'A Girl Adrift'..."
);

// Các biến cờ để đảm bảo các hành động chỉ chạy một lần
let featuresUnlocked = false;
let skinsAdded = false;

Il2Cpp.perform(() => {
  console.log("[+] Il2Cpp Bridge đã sẵn sàng!");
  const assembly = Il2Cpp.domain.assembly("Assembly-CSharp");
  const playerIns = assembly.image.class("player").field("ins");
  const dataIns = assembly.image.class("data").field("ins");
  const gameIns = assembly.image.class("game").field("ins");

  // ===================================================================
  // KÍCH HOẠT TẤT CẢ TÍNH NĂNG MỘT LẦN KHI MỞ CÀI ĐẶT
  // ===================================================================
  try {
    const UiWinSetting = assembly.image.class("ui_win_setting");
    const onEnableSettingMethod = UiWinSetting.method("OnEnable");

    onEnableSettingMethod.implementation = function () {
      if (!featuresUnlocked) {
        featuresUnlocked = true;
        console.log(
          "[*] Cửa sổ Cài đặt đã mở. Kích hoạt toàn bộ hack một lần..."
        );

        // --- BƯỚC 1: MAX RANK & LEVEL ---
        try {
          console.log("[*] Bắt đầu hack Rank & Level...");
          const playerCharacter = playerIns.value.field("character").value;
          const DataSettingClass = assembly.image.class("data_setting");
          const dataSettingInstance = dataIns.value.field("setting").value;
          const MAX_RANK = DataSettingClass.field("MAX_RANK").value;
          let currentRank = playerCharacter.method("get_rank").invoke();
          if (MAX_RANK > currentRank) {
            playerCharacter.method("Godmod_Set_Rank").invoke(MAX_RANK);
          }
          playerCharacter.method("Godmod_Set_Lv_Max").invoke();
          console.log("[+] Đã hack Rank và Level thành công!");
        } catch (e) {
          console.error("[ERROR] Lỗi khi đang hack Rank & Level:", e.stack);
        }

        // --- BƯỚC 2: HOÀN THÀNH TẤT CẢ NHIỆM VỤ ---
        try {
          console.log("[*] Bắt đầu hoàn thành tất cả nhiệm vụ...");
          const playerQuest = playerIns.value.field("quest").value;
          const finishQuestMethod = playerQuest
            .method("Finish_Quest")
            .overload("data_quest_element", "UnityEngine.Vector3");
          const allQuestsList = dataIns.value
            .field("quest")
            .value.method("get_quest_list")
            .invoke();
          const questsIterator = allQuestsList.method("GetEnumerator").invoke();

          // SỬA LỖI: Tạo một đối tượng Vector3 rỗng để truyền vào
          const Vector3 = Il2Cpp.domain
            .assembly("UnityEngine.CoreModule")
            .image.class("UnityEngine.Vector3");
          const zeroVector = Vector3.alloc();
          zeroVector.method(".ctor").invoke(0, 0, 0);

          let completedCount = 0;
          while (questsIterator.method("MoveNext").invoke()) {
            const questElement = questsIterator.method("get_Current").invoke();
            finishQuestMethod.invoke(questElement, zeroVector.unbox());
            completedCount++;
          }
          console.log(
            `[+] Đã hoàn thành ${completedCount} nhiệm vụ! Tất cả tính năng đã được mở khóa.`
          );
        } catch (e) {
          console.error("[ERROR] Lỗi khi hoàn thành nhiệm vụ:", e.stack);
        }
      }
      return onEnableSettingMethod.bind(this).invoke();
    };
    console.log(
      "[SUCCESS] Chức năng MAX RANK/LEVEL & UNLOCK ALL FEATURES đã sẵn sàng! Hãy mở cửa sổ Cài đặt."
    );
  } catch (error) {
    console.error("[ERROR] Không thể kích hoạt hook Cài đặt:", error.stack);
  }

  // ===================================================================
  // CÁC CHỨC NĂNG HACK LUÔN CHẠY
  // ===================================================================
  try {
    const gameClass = assembly.image.class("game");
    const fightAttackMethod = gameClass
      .method("Fight_Attack")
      .overload("System.Double", "System.Boolean");
    fightAttackMethod.implementation = function (original_damage, isCrit) {
      try {
        const gameFish = gameIns.value.field("fish").value;
        const fishMaxHealthObscured = gameFish.field(
          "<life>k__BackingField"
        ).value;
        const fishMaxHealth = fishMaxHealthObscured
          .method("InternalDecrypt")
          .invoke();
        return fightAttackMethod.bind(this).invoke(fishMaxHealth, true);
      } catch (e) {
        return fightAttackMethod.bind(this).invoke(original_damage, isCrit);
      }
    };
    console.log("[SUCCESS] Chức năng ONE-HIT KILL đã được kích hoạt!");
  } catch (error) {
    console.error("[ERROR] Không thể kích hoạt One-Hit Kill:", error.stack);
  }

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
      const dataElement = this.field("<element>k__BackingField").value;
      const maxField = dataElement.field("max");
      const originalMax = maxField.value;
      const ObscuredDouble = assembly.image.class(
        "CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble"
      );
      maxField.value = ObscuredDouble.method("op_Implicit").invoke(
        Number.MAX_SAFE_INTEGER
      );
      let hackedAmount = num > 0 ? num * GOLD_MULTIPLIER : num;
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
      const playerCurrency = playerIns.value.field("currency").value;
      const addsMethod = playerCurrency
        .method("Adds")
        .overload("System.Collections.Generic.List<CurNumPair>");
      addsMethod.invoke(iapElement.field("reward").value);
    };
    console.log("[SUCCESS] Chức năng MỞ KHÓA IAP đã được kích hoạt!");
  } catch (error) {
    console.error("[ERROR] Lỗi ở chức năng Tiền tệ/Vàng/IAP:", error.stack);
  }

  try {
    const UiWinSkin = assembly.image.class("ui_win_skin");
    const onEnableSkinMethod = UiWinSkin.method("OnEnable");
    onEnableSkinMethod.implementation = function () {
      if (!skinsAdded) {
        skinsAdded = true;
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
    console.log("[SUCCESS] Chức năng THÊM SKINS đã sẵn sàng!");
  } catch (error) {
    console.error("[ERROR] Lỗi khi hook chức năng thêm skin:", error.stack);
  }

  console.log(
    "\n[***] SCRIPT HOÀN CHỈNH ĐÃ KÍCH HOẠT. TẤT CẢ TÍNH NĂNG ĐÃ SẴN SÀNG! [***]"
  );
});
