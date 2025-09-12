import "frida-il2cpp-bridge";

console.log("[*] Bắt đầu script Frida TOÀN DIỆN v21 cho 'A Girl Adrift'...");

let featuresUnlocked = false;
let skinsAdded = false;

Il2Cpp.perform(() => {
  console.log("[+] Il2Cpp Bridge đã sẵn sàng!");
  const assembly = Il2Cpp.domain.assembly("Assembly-CSharp");
  const playerIns = assembly.image.class("player").field("ins");
  const dataIns = assembly.image.class("data").field("ins");
  const gameIns = assembly.image.class("game").field("ins");

  // ===================================================================
  // KÍCH HOẠT MỞ KHÓA TOÀN DIỆN KHI MỞ CÀI ĐẶT
  // ===================================================================
  try {
    const UiWinSetting = assembly.image.class("ui_win_setting");
    const onEnableSettingMethod = UiWinSetting.method("OnEnable");

    onEnableSettingMethod.implementation = function () {
      if (!featuresUnlocked) {
        featuresUnlocked = true;
        console.log("[*] Cửa sổ Cài đặt đã mở. Kích hoạt mở khóa toàn diện...");

        // ... (Các bước 1, 2, 3 giữ nguyên)
        try {
          console.log("[*] Bắt đầu hack Rank & Level...");
          const playerCharacter = playerIns.value.field("character").value;
          const DataSettingClass = assembly.image.class("data_setting");
          const dataSettingInstance = dataIns.value.field("setting").value;
          const MAX_RANK = DataSettingClass.field("MAX_RANK").value;
          let currentRank = playerCharacter.method("get_rank").invoke();
          if (MAX_RANK > currentRank) {
            const addRankMethod = playerCharacter.method("Add_Rank");
            for (let i = 0; i < MAX_RANK - currentRank; i++)
              addRankMethod.invoke();
          }
          const getLvMaxMethod = dataSettingInstance
            .method("Get_lvMax")
            .overload("System.Int32");
          const maxLevelForRank = getLvMaxMethod.invoke(MAX_RANK);
          let currentLevel = playerCharacter.method("get_lv").invoke();
          const getExpNeedMethod = playerCharacter.method("get_exp_need");
          const addExpMethod = playerCharacter
            .method("Add_Exp")
            .overload("System.Single");
          while (currentLevel < maxLevelForRank) {
            addExpMethod.invoke(getExpNeedMethod.invoke());
            currentLevel = playerCharacter.method("get_lv").invoke();
          }
          console.log("[+] Đã max Rank và Level!");
        } catch (e) {
          console.error("[ERROR] Lỗi khi hack Rank & Level:", e.stack);
        }

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
          const zeroVector = Il2Cpp.domain
            .assembly("UnityEngine.CoreModule")
            .image.class("UnityEngine.Vector3")
            .alloc()
            .unbox();
          let completedCount = 0;
          while (questsIterator.method("MoveNext").invoke()) {
            finishQuestMethod.invoke(
              questsIterator.method("get_Current").invoke(),
              zeroVector
            );
            completedCount++;
          }
          console.log(`[+] Đã hoàn thành ${completedCount} nhiệm vụ!`);
        } catch (e) {
          console.error("[ERROR] Lỗi khi hoàn thành nhiệm vụ:", e.stack);
        }

        try {
          console.log("[*] Bắt đầu thêm tất cả cá vào bộ sưu tập...");
          const playerFish = playerIns.value.field("fish").value;
          const addFishMethod = playerFish
            .method("Add_fish")
            .overload("data_fish_element", "System.Int32", "System.Boolean");
          const allFishList = dataIns.value
            .field("fish")
            .value.field("list").value;
          const fishCount = allFishList.method("get_Count").invoke();
          for (let i = 0; i < fishCount; i++) {
            addFishMethod.invoke(
              allFishList.method("get_Item").invoke(i),
              1,
              false
            );
          }
          console.log(`[+] Đã thêm ${fishCount} loại cá!`);
        } catch (e) {
          console.error("[ERROR] Lỗi khi thêm cá:", e.stack);
        }

        // --- BƯỚC 4 (SỬA LỖI): MAX LEVEL TẤT CẢ VẬT PHẨM CHẾ TẠO (FARM) ---
        try {
          console.log(
            "[*] Bắt đầu max level tất cả vật phẩm chế tạo (Farm)..."
          );
          const playerCraft = playerIns.value.field("craft").value;
          const allCraftsList = dataIns.value
            .field("craft")
            .value.field("elements").value;
          const getPlayerCraftElementMethod = playerCraft
            .method("Get_element")
            .overload("data_craft_element");

          // Lấy class ObscuredInt để tạo giá trị mới
          const ObscuredInt = assembly.image.class(
            "CodeStage.AntiCheat.ObscuredTypes.ObscuredInt"
          );

          const craftCount = allCraftsList.method("get_Count").invoke();
          let maxedCount = 0;

          for (let i = 0; i < craftCount; i++) {
            const dataCraftElement = allCraftsList.method("get_Item").invoke(i);
            const playerCraftElement =
              getPlayerCraftElementMethod.invoke(dataCraftElement);
            const needsList = dataCraftElement.field("needs").value;
            const maxLevel = needsList.method("get_Count").invoke();

            // SỬA LỖI: Tạo một đối tượng ObscuredInt mới và gán nó
            const newLevelObscured =
              ObscuredInt.method("op_Implicit").invoke(maxLevel);
            playerCraftElement.field("lv").value = newLevelObscured;

            maxedCount++;
          }
          console.log(`[+] Đã max level ${maxedCount} vật phẩm chế tạo/farm!`);
        } catch (e) {
          console.error("[ERROR] Lỗi khi max level vật phẩm chế tạo:", e.stack);
        }

        console.log("\n[SUCCESS] Mở khóa toàn diện hoàn tất!");
      }
      return onEnableSettingMethod.bind(this).invoke();
    };
    console.log(
      "[SUCCESS] Chức năng MỞ KHÓA TOÀN DIỆN đã sẵn sàng! Hãy mở cửa sổ Cài đặt."
    );
  } catch (error) {
    console.error("[ERROR] Không thể kích hoạt hook Cài đặt:", error.stack);
  }

  // ... (Các chức năng khác giữ nguyên)
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
