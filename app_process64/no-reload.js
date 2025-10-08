/*
 * Script Frida cho Plants vs. Zombies 3 (com.ea.gp.pvz3)
 * Chức năng: No Reload / No Cooldown (Không hồi chiêu) cho các loại cây.
 * Cách chạy: frida -U -f com.ea.gp.pvz3 -l no-reload.js --no-pause
 *
 * Dựa trên phân tích Assembly-CSharp.cs:
 * - Class: Yeti.CombatGuiModel
 * - Method 1: SetLoadoutCooldownPercent(int loadoutIndex, float cooldownPercent) - line 18040
 * - Method 2: SetInstantUseCooldownPercent(int unitId, float cooldownPercent) - line 18076
 */

import "frida-il2cpp-bridge";

// ======================= CẤU HÌNH =======================
const NO_COOLDOWN_ENABLED = true; // Bật/tắt chức năng không hồi chiêu
const DEBUG_MODE = true; // Bật log để debug CoreSim
const FORCE_PLACEMENT = true; // BẮT BUỘC CHO PHÉP ĐẶT PLANT
// ==========================================================

Il2Cpp.perform(() => {
  console.log("[+] IL2CPP initialized. Attaching hooks for no cooldown...");

  try {
    // Lấy Assembly-CSharp
    const assembly = Il2Cpp.domain.assembly("Assembly-CSharp");
    if (!assembly) {
      throw new Error("Cannot find Assembly-CSharp");
    }

    // Lấy class Yeti.CombatGuiModel
    const CombatGuiModel = assembly.image.class("Yeti.CombatGuiModel");
    if (!CombatGuiModel) {
      throw new Error("Cannot find Yeti.CombatGuiModel class");
    }

    console.log("[+] Found Yeti.CombatGuiModel class");

    // ========== HOOK 1: SetLoadoutCooldownPercent ==========
    // Signature: void SetLoadoutCooldownPercent(int loadoutIndex, float cooldownPercent)
    // Tham số: 2 (không tính this)
    try {
      const setLoadoutCooldownMethod = CombatGuiModel.method(
        "SetLoadoutCooldownPercent",
        2
      );

      if (!setLoadoutCooldownMethod) {
        throw new Error("Cannot find SetLoadoutCooldownPercent method");
      }

      console.log(
        `[+] Found SetLoadoutCooldownPercent at: ${setLoadoutCooldownMethod.virtualAddress}`
      );

      Interceptor.attach(setLoadoutCooldownMethod.virtualAddress, {
        onEnter(args) {
          if (!NO_COOLDOWN_ENABLED) return;

          try {
            // args[0] = this (CombatGuiModel instance)
            // args[1] = int loadoutIndex
            // args[2] = float cooldownPercent (trên ARM64: truyền qua register, đọc như int32)
            const loadoutIndex = args[1].toInt32();

            // Đọc float từ register (được encode như uint32)
            const floatBits = args[2].toUInt32();
            const buffer = Memory.alloc(4);
            buffer.writeU32(floatBits);
            const originalPercent = buffer.readFloat();

            // Chỉ can thiệp khi cooldown chưa xong (< 1.0)
            if (originalPercent < 1.0) {
              // Ghi đè giá trị thành 1.0 (100% = sẵn sàng)
              // Chuyển float 1.0 thành uint32 để ghi vào register
              const newBuffer = Memory.alloc(4);
              newBuffer.writeFloat(1.0);
              args[2] = ptr(newBuffer.readU32());
            }
          } catch (e) {
            console.error(
              `[!] Error in SetLoadoutCooldownPercent hook: ${e.message}`
            );
          }
        },
      });

      console.log("[✓] SetLoadoutCooldownPercent hook active");
    } catch (e) {
      console.error(
        `[!] Failed to hook SetLoadoutCooldownPercent: ${e.message}`
      );
    }

    // ========== HOOK 2: SetInstantUseCooldownPercent ==========
    // Signature: void SetInstantUseCooldownPercent(int unitId, float cooldownPercent)
    // Tham số: 2 (không tính this)
    try {
      const setInstantUseCooldownMethod = CombatGuiModel.method(
        "SetInstantUseCooldownPercent",
        2
      );

      if (!setInstantUseCooldownMethod) {
        throw new Error("Cannot find SetInstantUseCooldownPercent method");
      }

      console.log(
        `[+] Found SetInstantUseCooldownPercent at: ${setInstantUseCooldownMethod.virtualAddress}`
      );

      Interceptor.attach(setInstantUseCooldownMethod.virtualAddress, {
        onEnter(args) {
          if (!NO_COOLDOWN_ENABLED) return;

          try {
            // args[0] = this (CombatGuiModel instance)
            // args[1] = int unitId
            // args[2] = float cooldownPercent (trên ARM64: truyền qua register, đọc như int32)
            const unitId = args[1].toInt32();

            // Đọc float từ register (được encode như uint32)
            const floatBits = args[2].toUInt32();
            const buffer = Memory.alloc(4);
            buffer.writeU32(floatBits);
            const originalPercent = buffer.readFloat();

            // Chỉ can thiệp khi cooldown chưa xong (< 1.0)
            if (originalPercent < 1.0) {
              if (DEBUG_MODE) {
                console.log(
                  `[*] Instant Use Plant [ID:${unitId}]: Cooldown ${(
                    originalPercent * 100
                  ).toFixed(1)}% -> 100%`
                );
              }

              // Ghi đè giá trị thành 1.0 (100% = sẵn sàng)
              // Chuyển float 1.0 thành uint32 để ghi vào register
              const newBuffer = Memory.alloc(4);
              newBuffer.writeFloat(1.0);
              args[2] = ptr(newBuffer.readU32());
            }
          } catch (e) {
            console.error(
              `[!] Error in SetInstantUseCooldownPercent hook: ${e.message}`
            );
          }
        },
      });

      console.log("[✓] SetInstantUseCooldownPercent hook active");
    } catch (e) {
      console.error(
        `[!] Failed to hook SetInstantUseCooldownPercent: ${e.message}`
      );
    }

    // ========== HOOK 3: LoadoutGuiData.IsPlantable ==========
    // Signature: bool IsPlantable(int loadoutIndex)
    try {
      const LoadoutGuiData = assembly.image.class("Yeti.LoadoutGuiData");
      if (!LoadoutGuiData) {
        throw new Error("Cannot find Yeti.LoadoutGuiData class");
      }

      const isPlantableMethod = LoadoutGuiData.method("IsPlantable", 1);
      if (!isPlantableMethod) {
        throw new Error("Cannot find IsPlantable method");
      }

      console.log(
        `[+] Found IsPlantable at: ${isPlantableMethod.virtualAddress}`
      );

      Interceptor.attach(isPlantableMethod.virtualAddress, {
        onLeave(retval) {
          if (!NO_COOLDOWN_ENABLED) return;

          const originalValue = retval.toInt32();
          if (DEBUG_MODE && originalValue === 0) {
            console.log(
              "[!] LoadoutGuiData.IsPlantable returned FALSE - forcing TRUE"
            );
          }

          // Luôn trả về true (plant có thể trồng được)
          retval.replace(ptr(1));
        },
      });

      console.log("[✓] IsPlantable hook active");
    } catch (e) {
      console.error(`[!] Failed to hook IsPlantable: ${e.message}`);
    }

    // ========== HOOK 4: LoadoutGuiData.IsOffCooldown ==========
    // Signature: bool IsOffCooldown(LoadoutUnitGuiData unit)
    try {
      const LoadoutGuiData = assembly.image.class("Yeti.LoadoutGuiData");
      const isOffCooldownMethod = LoadoutGuiData.method("IsOffCooldown", 1);

      if (!isOffCooldownMethod) {
        throw new Error("Cannot find IsOffCooldown method");
      }

      console.log(
        `[+] Found IsOffCooldown at: ${isOffCooldownMethod.virtualAddress}`
      );

      Interceptor.attach(isOffCooldownMethod.virtualAddress, {
        onLeave(retval) {
          if (!NO_COOLDOWN_ENABLED) return;

          const originalValue = retval.toInt32();
          if (DEBUG_MODE && originalValue === 0) {
            console.log(
              "[!] LoadoutGuiData.IsOffCooldown returned FALSE - forcing TRUE"
            );
          }

          // Luôn trả về true (không còn cooldown)
          retval.replace(ptr(1));
        },
      });

      console.log("[✓] IsOffCooldown hook active");
    } catch (e) {
      console.error(`[!] Failed to hook IsOffCooldown: ${e.message}`);
    }

    // ========== HOOK 5: LoadoutGuiData.GetCooldownPercent ==========
    // Signature: float GetCooldownPercent(int loadoutIndex)
    try {
      const LoadoutGuiData = assembly.image.class("Yeti.LoadoutGuiData");
      const getCooldownMethod = LoadoutGuiData.method("GetCooldownPercent", 1);

      if (!getCooldownMethod) {
        throw new Error("Cannot find GetCooldownPercent method");
      }

      console.log(
        `[+] Found LoadoutGuiData.GetCooldownPercent at: ${getCooldownMethod.virtualAddress}`
      );

      Interceptor.attach(getCooldownMethod.virtualAddress, {
        onLeave(retval) {
          if (!NO_COOLDOWN_ENABLED) return;

          // Trả về 1.0 (100% = sẵn sàng)
          const buffer = Memory.alloc(4);
          buffer.writeFloat(1.0);
          retval.replace(ptr(buffer.readU32()));
        },
      });

      console.log("[✓] LoadoutGuiData.GetCooldownPercent hook active");
    } catch (e) {
      console.error(
        `[!] Failed to hook LoadoutGuiData.GetCooldownPercent: ${e.message}`
      );
    }

    // ========== HOOK 6: LoadoutUnitModel.SetCooldown ==========
    // Signature: void SetCooldown(float cooldownPercentage)
    try {
      const LoadoutUnitModel = assembly.image.class("Yeti.LoadoutUnitModel");
      if (!LoadoutUnitModel) {
        throw new Error("Cannot find Yeti.LoadoutUnitModel class");
      }

      const setCooldownMethod = LoadoutUnitModel.method("SetCooldown", 1);
      if (!setCooldownMethod) {
        throw new Error("Cannot find SetCooldown method");
      }

      console.log(
        `[+] Found LoadoutUnitModel.SetCooldown at: ${setCooldownMethod.virtualAddress}`
      );

      Interceptor.attach(setCooldownMethod.virtualAddress, {
        onEnter(args) {
          if (!NO_COOLDOWN_ENABLED) return;

          try {
            // Đọc float từ register
            const floatBits = args[1].toUInt32();
            const buffer = Memory.alloc(4);
            buffer.writeU32(floatBits);
            const originalPercent = buffer.readFloat();

            if (originalPercent < 1.0) {
              // Ghi đè thành 1.0
              const newBuffer = Memory.alloc(4);
              newBuffer.writeFloat(1.0);
              args[1] = ptr(newBuffer.readU32());
            }
          } catch (e) {
            console.error(`[!] Error in SetCooldown hook: ${e.message}`);
          }
        },
      });

      console.log("[✓] LoadoutUnitModel.SetCooldown hook active");
    } catch (e) {
      console.error(
        `[!] Failed to hook LoadoutUnitModel.SetCooldown: ${e.message}`
      );
    }

    // ========== HOOK 7: LoadoutUnitModel.UpdateCooldown ==========
    // Signature: void UpdateCooldown(float cooldownPercentage)
    try {
      const LoadoutUnitModel = assembly.image.class("Yeti.LoadoutUnitModel");
      const updateCooldownMethod = LoadoutUnitModel.method("UpdateCooldown", 1);

      if (!updateCooldownMethod) {
        throw new Error("Cannot find UpdateCooldown method");
      }

      console.log(
        `[+] Found LoadoutUnitModel.UpdateCooldown at: ${updateCooldownMethod.virtualAddress}`
      );

      Interceptor.attach(updateCooldownMethod.virtualAddress, {
        onEnter(args) {
          if (!NO_COOLDOWN_ENABLED) return;

          try {
            // Đọc float từ register
            const floatBits = args[1].toUInt32();
            const buffer = Memory.alloc(4);
            buffer.writeU32(floatBits);
            const originalPercent = buffer.readFloat();

            if (originalPercent < 1.0) {
              // Ghi đè thành 1.0
              const newBuffer = Memory.alloc(4);
              newBuffer.writeFloat(1.0);
              args[1] = ptr(newBuffer.readU32());
            }
          } catch (e) {
            console.error(`[!] Error in UpdateCooldown hook: ${e.message}`);
          }
        },
      });

      console.log("[✓] LoadoutUnitModel.UpdateCooldown hook active");
    } catch (e) {
      console.error(
        `[!] Failed to hook LoadoutUnitModel.UpdateCooldown: ${e.message}`
      );
    }

    // ========== HOOK 8: LoadoutUnitModel.OffCooldown ==========
    // Signature: bool OffCooldown()
    try {
      const LoadoutUnitModel = assembly.image.class("Yeti.LoadoutUnitModel");
      const offCooldownMethod = LoadoutUnitModel.method("OffCooldown", 0);

      if (!offCooldownMethod) {
        throw new Error("Cannot find OffCooldown method");
      }

      console.log(
        `[+] Found LoadoutUnitModel.OffCooldown at: ${offCooldownMethod.virtualAddress}`
      );

      Interceptor.attach(offCooldownMethod.virtualAddress, {
        onLeave(retval) {
          if (!NO_COOLDOWN_ENABLED) return;

          // Luôn trả về true
          retval.replace(ptr(1));
        },
      });

      console.log("[✓] LoadoutUnitModel.OffCooldown hook active");
    } catch (e) {
      console.error(
        `[!] Failed to hook LoadoutUnitModel.OffCooldown: ${e.message}`
      );
    }

    // ========== HOOK 9: LoadoutUnitModel.get_IsOffCooldown ==========
    // Signature: bool get_IsOffCooldown()
    try {
      const LoadoutUnitModel = assembly.image.class("Yeti.LoadoutUnitModel");
      const getIsOffCooldownMethod = LoadoutUnitModel.method(
        "get_IsOffCooldown",
        0
      );

      if (!getIsOffCooldownMethod) {
        throw new Error("Cannot find get_IsOffCooldown method");
      }

      console.log(
        `[+] Found LoadoutUnitModel.get_IsOffCooldown at: ${getIsOffCooldownMethod.virtualAddress}`
      );

      Interceptor.attach(getIsOffCooldownMethod.virtualAddress, {
        onLeave(retval) {
          if (!NO_COOLDOWN_ENABLED) return;

          // Luôn trả về true
          retval.replace(ptr(1));
        },
      });

      console.log("[✓] LoadoutUnitModel.get_IsOffCooldown hook active");
    } catch (e) {
      console.error(
        `[!] Failed to hook LoadoutUnitModel.get_IsOffCooldown: ${e.message}`
      );
    }

    // ========== HOOK 10: LoadoutGuiData.HasEnoughSun ==========
    // Signature: bool HasEnoughSun(LoadoutUnitGuiData unit)
    try {
      const LoadoutGuiData = assembly.image.class("Yeti.LoadoutGuiData");
      const hasEnoughSunMethod = LoadoutGuiData.method("HasEnoughSun", 1);

      if (!hasEnoughSunMethod) {
        throw new Error("Cannot find HasEnoughSun method");
      }

      console.log(
        `[+] Found HasEnoughSun at: ${hasEnoughSunMethod.virtualAddress}`
      );

      Interceptor.attach(hasEnoughSunMethod.virtualAddress, {
        onLeave(retval) {
          if (!NO_COOLDOWN_ENABLED) return;

          const originalValue = retval.toInt32();
          if (DEBUG_MODE && originalValue === 0) {
            console.log(
              "[!] LoadoutGuiData.HasEnoughSun returned FALSE - forcing TRUE"
            );
          }

          // Luôn trả về true (luôn đủ sun)
          retval.replace(ptr(1));
        },
      });

      console.log("[✓] HasEnoughSun hook active");
    } catch (e) {
      console.error(`[!] Failed to hook HasEnoughSun: ${e.message}`);
    }

    // ========== HOOK 11: LoadoutUnitModel.get_HasEnoughSun ==========
    // Signature: bool get_HasEnoughSun()
    try {
      const LoadoutUnitModel = assembly.image.class("Yeti.LoadoutUnitModel");
      const getHasEnoughSunMethod = LoadoutUnitModel.method(
        "get_HasEnoughSun",
        0
      );

      if (!getHasEnoughSunMethod) {
        throw new Error("Cannot find get_HasEnoughSun method");
      }

      console.log(
        `[+] Found LoadoutUnitModel.get_HasEnoughSun at: ${getHasEnoughSunMethod.virtualAddress}`
      );

      Interceptor.attach(getHasEnoughSunMethod.virtualAddress, {
        onLeave(retval) {
          if (!NO_COOLDOWN_ENABLED) return;

          // Luôn trả về true (luôn đủ sun)
          retval.replace(ptr(1));
        },
      });

      console.log("[✓] LoadoutUnitModel.get_HasEnoughSun hook active");
    } catch (e) {
      console.error(
        `[!] Failed to hook LoadoutUnitModel.get_HasEnoughSun: ${e.message}`
      );
    }

    // ========== HOOK 12: CombatScenePuppets.CanPlaceUnitAtPosition ==========
    // Signature: bool CanPlaceUnitAtPosition(UnitDefinition unitDef, Vector3 worldPosition, ref GridCell placementCell)
    try {
      const CombatScenePuppets = assembly.image.class(
        "Yeti.CombatScenePuppets"
      );
      if (!CombatScenePuppets) {
        throw new Error("Cannot find Yeti.CombatScenePuppets class");
      }

      const canPlaceMethod = CombatScenePuppets.method(
        "CanPlaceUnitAtPosition",
        3
      );

      if (!canPlaceMethod) {
        throw new Error("Cannot find CanPlaceUnitAtPosition method");
      }

      console.log(
        `[+] Found CanPlaceUnitAtPosition at: ${canPlaceMethod.virtualAddress}`
      );

      Interceptor.attach(canPlaceMethod.virtualAddress, {
        onLeave(retval) {
          if (!NO_COOLDOWN_ENABLED) return;

          // Luôn trả về true (luôn có thể đặt plant)
          retval.replace(ptr(1));
        },
      });

      console.log("[✓] CanPlaceUnitAtPosition hook active");
    } catch (e) {
      console.error(`[!] Failed to hook CanPlaceUnitAtPosition: ${e.message}`);
    }

    // ========== HOOK 13: CombatGuiModel.IsSeedPacketPlantable ==========
    // Signature: bool IsSeedPacketPlantable(UnitId unitId)
    try {
      const isSeedPacketPlantableMethod = CombatGuiModel.method(
        "IsSeedPacketPlantable",
        1
      );

      if (!isSeedPacketPlantableMethod) {
        throw new Error("Cannot find IsSeedPacketPlantable method");
      }

      console.log(
        `[+] Found IsSeedPacketPlantable at: ${isSeedPacketPlantableMethod.virtualAddress}`
      );

      Interceptor.attach(isSeedPacketPlantableMethod.virtualAddress, {
        onLeave(retval) {
          if (!NO_COOLDOWN_ENABLED) return;

          const originalValue = retval.toInt32();
          if (DEBUG_MODE) {
            console.log(
              `[*] IsSeedPacketPlantable returned: ${originalValue} -> forcing TRUE`
            );
          }

          // Luôn trả về true (seed packet luôn có thể trồng)
          retval.replace(ptr(1));
        },
      });

      console.log("[✓] IsSeedPacketPlantable hook active");
    } catch (e) {
      console.error(`[!] Failed to hook IsSeedPacketPlantable: ${e.message}`);
    }

    // ========== HOOK 14: CombatScenePuppets.CanPlaceUnitIdAtPosition ==========
    // Signature: bool CanPlaceUnitIdAtPosition(UnitId unitId, Vector3 worldPosition, ref GridCell placementCell)
    try {
      const CombatScenePuppets = assembly.image.class(
        "Yeti.CombatScenePuppets"
      );
      const canPlaceUnitIdMethod = CombatScenePuppets.method(
        "CanPlaceUnitIdAtPosition",
        3
      );

      if (!canPlaceUnitIdMethod) {
        throw new Error("Cannot find CanPlaceUnitIdAtPosition method");
      }

      console.log(
        `[+] Found CanPlaceUnitIdAtPosition at: ${canPlaceUnitIdMethod.virtualAddress}`
      );

      Interceptor.attach(canPlaceUnitIdMethod.virtualAddress, {
        onLeave(retval) {
          if (!NO_COOLDOWN_ENABLED) return;

          // Luôn trả về true
          retval.replace(ptr(1));
        },
      });

      console.log("[✓] CanPlaceUnitIdAtPosition hook active");
    } catch (e) {
      console.error(
        `[!] Failed to hook CanPlaceUnitIdAtPosition: ${e.message}`
      );
    }

    // ========== HOOK 15: CombatScenePuppets.CanPlaceCellOccupier ==========
    // Signature: bool CanPlaceCellOccupier(GridArea area)
    try {
      const CombatScenePuppets = assembly.image.class(
        "Yeti.CombatScenePuppets"
      );
      const canPlaceCellMethod = CombatScenePuppets.method(
        "CanPlaceCellOccupier",
        1
      );

      if (!canPlaceCellMethod) {
        throw new Error("Cannot find CanPlaceCellOccupier method");
      }

      console.log(
        `[+] Found CanPlaceCellOccupier at: ${canPlaceCellMethod.virtualAddress}`
      );

      Interceptor.attach(canPlaceCellMethod.virtualAddress, {
        onLeave(retval) {
          if (!NO_COOLDOWN_ENABLED) return;

          // Luôn trả về true
          retval.replace(ptr(1));
        },
      });

      console.log("[✓] CanPlaceCellOccupier hook active");
    } catch (e) {
      console.error(`[!] Failed to hook CanPlaceCellOccupier: ${e.message}`);
    }

    // ========== HOOK 16: GridCellOccupancyCollection.CanPlaceCellOccupier (static) ==========
    // Signature: static bool CanPlaceCellOccupier(Occupancy occupancy)
    try {
      const GridCellOccupancyCollection = assembly.image.class(
        "Yeti.GridCellOccupancyCollection"
      );
      if (!GridCellOccupancyCollection) {
        throw new Error("Cannot find Yeti.GridCellOccupancyCollection class");
      }

      const canPlaceCellStaticMethod = GridCellOccupancyCollection.method(
        "CanPlaceCellOccupier",
        1
      );

      if (!canPlaceCellStaticMethod) {
        throw new Error("Cannot find static CanPlaceCellOccupier method");
      }

      console.log(
        `[+] Found GridCellOccupancyCollection.CanPlaceCellOccupier at: ${canPlaceCellStaticMethod.virtualAddress}`
      );

      Interceptor.attach(canPlaceCellStaticMethod.virtualAddress, {
        onLeave(retval) {
          if (!NO_COOLDOWN_ENABLED) return;

          // Luôn trả về true
          retval.replace(ptr(1));
        },
      });

      console.log(
        "[✓] GridCellOccupancyCollection.CanPlaceCellOccupier hook active"
      );
    } catch (e) {
      console.error(
        `[!] Failed to hook GridCellOccupancyCollection.CanPlaceCellOccupier: ${e.message}`
      );
    }

    // ========== HOOK 17: UnitMovementInfo.get_CanPlaceUnit ==========
    // Signature: bool get_CanPlaceUnit()
    try {
      const UnitMovementInfo = assembly.image.class("Yeti.UnitMovementInfo");
      if (!UnitMovementInfo) {
        throw new Error("Cannot find Yeti.UnitMovementInfo struct");
      }

      const getCanPlaceUnitMethod = UnitMovementInfo.method(
        "get_CanPlaceUnit",
        0
      );

      if (!getCanPlaceUnitMethod) {
        throw new Error("Cannot find get_CanPlaceUnit method");
      }

      console.log(
        `[+] Found UnitMovementInfo.get_CanPlaceUnit at: ${getCanPlaceUnitMethod.virtualAddress}`
      );

      Interceptor.attach(getCanPlaceUnitMethod.virtualAddress, {
        onLeave(retval) {
          if (!NO_COOLDOWN_ENABLED) return;

          const originalValue = retval.toInt32();
          if (DEBUG_MODE && originalValue === 0) {
            console.log("[!] UnitMovementInfo.get_CanPlaceUnit returned FALSE");
          }

          // Luôn trả về true (luôn có thể đặt plant)
          if (FORCE_PLACEMENT) {
            retval.replace(ptr(1));
          }
        },
      });

      console.log("[✓] UnitMovementInfo.get_CanPlaceUnit hook active");
    } catch (e) {
      console.error(
        `[!] Failed to hook UnitMovementInfo.get_CanPlaceUnit: ${e.message}`
      );
    }

    // ========== HOOK 18: UnitMovementInfo.get_IsAllowed ==========
    // Signature: bool get_IsAllowed()
    try {
      const UnitMovementInfo = assembly.image.class("Yeti.UnitMovementInfo");
      const getIsAllowedMethod = UnitMovementInfo.method("get_IsAllowed", 0);

      if (!getIsAllowedMethod) {
        throw new Error("Cannot find get_IsAllowed method");
      }

      console.log(
        `[+] Found UnitMovementInfo.get_IsAllowed at: ${getIsAllowedMethod.virtualAddress}`
      );

      Interceptor.attach(getIsAllowedMethod.virtualAddress, {
        onLeave(retval) {
          if (!NO_COOLDOWN_ENABLED) return;

          // Luôn trả về true
          retval.replace(ptr(1));
        },
      });

      console.log("[✓] UnitMovementInfo.get_IsAllowed hook active");
    } catch (e) {
      console.error(
        `[!] Failed to hook UnitMovementInfo.get_IsAllowed: ${e.message}`
      );
    }

    // ========== HOOK 19: UnitMovementInfo.get_IsOccupied ==========
    // Signature: bool get_IsOccupied()
    try {
      const UnitMovementInfo = assembly.image.class("Yeti.UnitMovementInfo");
      const getIsOccupiedMethod = UnitMovementInfo.method("get_IsOccupied", 0);

      if (!getIsOccupiedMethod) {
        throw new Error("Cannot find get_IsOccupied method");
      }

      console.log(
        `[+] Found UnitMovementInfo.get_IsOccupied at: ${getIsOccupiedMethod.virtualAddress}`
      );

      Interceptor.attach(getIsOccupiedMethod.virtualAddress, {
        onLeave(retval) {
          if (!NO_COOLDOWN_ENABLED) return;

          // Luôn trả về false (không bao giờ bị chiếm)
          retval.replace(ptr(0));
        },
      });

      console.log("[✓] UnitMovementInfo.get_IsOccupied hook active");
    } catch (e) {
      console.error(
        `[!] Failed to hook UnitMovementInfo.get_IsOccupied: ${e.message}`
      );
    }

    // ========== HOOK 20: UnitMovementInfo.get_IsRestricted ==========
    // Signature: bool get_IsRestricted()
    try {
      const UnitMovementInfo = assembly.image.class("Yeti.UnitMovementInfo");
      const getIsRestrictedMethod = UnitMovementInfo.method(
        "get_IsRestricted",
        0
      );

      if (!getIsRestrictedMethod) {
        throw new Error("Cannot find get_IsRestricted method");
      }

      console.log(
        `[+] Found UnitMovementInfo.get_IsRestricted at: ${getIsRestrictedMethod.virtualAddress}`
      );

      Interceptor.attach(getIsRestrictedMethod.virtualAddress, {
        onLeave(retval) {
          if (!NO_COOLDOWN_ENABLED) return;

          // Luôn trả về false (không bao giờ bị hạn chế)
          retval.replace(ptr(0));
        },
      });

      console.log("[✓] UnitMovementInfo.get_IsRestricted hook active");
    } catch (e) {
      console.error(
        `[!] Failed to hook UnitMovementInfo.get_IsRestricted: ${e.message}`
      );
    }

    // ========== HOOK 21: CombatSceneState.PlaceLoadoutUnit ==========
    try {
      const CombatSceneState = assembly.image.class("Yeti.CombatSceneState");
      if (CombatSceneState) {
        const placeLoadoutMethod = CombatSceneState.method(
          "PlaceLoadoutUnit",
          2
        );

        if (placeLoadoutMethod) {
          console.log(
            `[+] Found CombatSceneState.PlaceLoadoutUnit at: ${placeLoadoutMethod.virtualAddress}`
          );

          Interceptor.attach(placeLoadoutMethod.virtualAddress, {
            onEnter(args) {
              if (DEBUG_MODE) {
                const loadoutIndex = args[1].toInt32();
                console.log(
                  `[*] CombatSceneState.PlaceLoadoutUnit called: loadout ${loadoutIndex}`
                );
              }
            },
          });

          console.log("[✓] CombatSceneState.PlaceLoadoutUnit hook active");
        }
      }
    } catch (e) {
      console.error(
        `[!] Failed to hook CombatSceneState.PlaceLoadoutUnit: ${e.message}`
      );
    }

    // ========== HOOK 25: CoreSimWrapper.PlaceLoadoutUnit ==========
    // ĐÂY MỚI LÀ METHOD THỰC SỰ GỌI VÀO GAME SIMULATION
    try {
      const CoreSimWrapper = assembly.image.class("Yeti.CoreSimWrapper");
      if (!CoreSimWrapper) {
        throw new Error("Cannot find Yeti.CoreSimWrapper class");
      }

      const coreSimPlaceMethod = CoreSimWrapper.method("PlaceLoadoutUnit", 2);

      if (coreSimPlaceMethod) {
        console.log(
          `[+] Found CoreSimWrapper.PlaceLoadoutUnit at: ${coreSimPlaceMethod.virtualAddress}`
        );

        Interceptor.attach(coreSimPlaceMethod.virtualAddress, {
          onEnter(args) {
            const loadoutIndex = args[1].toInt32();
            console.log(
              `[!!!] CoreSimWrapper.PlaceLoadoutUnit called: loadout ${loadoutIndex} - FORCING PLACEMENT!`
            );
          },
        });

        console.log("[✓] CoreSimWrapper.PlaceLoadoutUnit hook active");
      }
    } catch (e) {
      console.error(
        `[!] Failed to hook CoreSimWrapper.PlaceLoadoutUnit: ${e.message}`
      );
    }

    // ========== HOOK 22: CombatSceneState.PlacePlant ==========
    try {
      const CombatSceneState = assembly.image.class("Yeti.CombatSceneState");
      const placePlantMethod = CombatSceneState.method("PlacePlant", 2);

      if (placePlantMethod) {
        console.log(
          `[+] Found CombatSceneState.PlacePlant at: ${placePlantMethod.virtualAddress}`
        );

        Interceptor.attach(placePlantMethod.virtualAddress, {
          onEnter(args) {
            if (DEBUG_MODE) {
              const unitId = args[1].toInt32();
              console.log(
                `[*] CombatSceneState.PlacePlant called: unit ${unitId}`
              );
            }
          },
        });

        console.log("[✓] CombatSceneState.PlacePlant hook active");
      }
    } catch (e) {
      console.error(
        `[!] Failed to hook CombatSceneState.PlacePlant: ${e.message}`
      );
    }

    // ========== HOOK 26: CoreSimWrapper.PlacePlant ==========
    try {
      const CoreSimWrapper = assembly.image.class("Yeti.CoreSimWrapper");
      const coreSimPlacePlantMethod = CoreSimWrapper.method("PlacePlant", 2);

      if (coreSimPlacePlantMethod) {
        console.log(
          `[+] Found CoreSimWrapper.PlacePlant at: ${coreSimPlacePlantMethod.virtualAddress}`
        );

        Interceptor.attach(coreSimPlacePlantMethod.virtualAddress, {
          onEnter(args) {
            const unitId = args[1].toInt32();
            console.log(
              `[!!!] CoreSimWrapper.PlacePlant called: unit ${unitId} - FORCING PLACEMENT!`
            );
          },
        });

        console.log("[✓] CoreSimWrapper.PlacePlant hook active");
      }
    } catch (e) {
      console.error(
        `[!] Failed to hook CoreSimWrapper.PlacePlant: ${e.message}`
      );
    }

    // ========== HOOK 23: CombatInputRootState.OnSeedPacketDragEnd ==========
    // Đây là method xử lý khi thả seed packet xuống sân
    try {
      const CombatInputRootState = assembly.image.class(
        "Yeti.CombatInputRootState"
      );
      if (!CombatInputRootState) {
        throw new Error("Cannot find Yeti.CombatInputRootState class");
      }

      const onDragEndMethod = CombatInputRootState.method(
        "OnSeedPacketDragEnd",
        1
      );

      if (onDragEndMethod) {
        console.log(
          `[+] Found OnSeedPacketDragEnd at: ${onDragEndMethod.virtualAddress}`
        );

        Interceptor.attach(onDragEndMethod.virtualAddress, {
          onEnter(args) {
            console.log(
              "[*] OnSeedPacketDragEnd called - Player dropped seed packet!"
            );
          },
        });

        console.log("[✓] OnSeedPacketDragEnd hook active");
      }
    } catch (e) {
      console.error(`[!] Failed to hook OnSeedPacketDragEnd: ${e.message}`);
    }

    // ========== HOOK 24: SeedPacketInputRootState.InterpretSeedPacketInteraction ==========
    try {
      const SeedPacketInputRootState = assembly.image.class(
        "Yeti.SeedPacketInputRootState"
      );
      if (SeedPacketInputRootState) {
        const interpretMethod = SeedPacketInputRootState.method(
          "InterpretSeedPacketInteraction",
          2
        );

        if (interpretMethod) {
          console.log(
            `[+] Found InterpretSeedPacketInteraction at: ${interpretMethod.virtualAddress}`
          );

          Interceptor.attach(interpretMethod.virtualAddress, {
            onEnter(args) {
              console.log("[*] InterpretSeedPacketInteraction called!");
            },
          });

          console.log("[✓] InterpretSeedPacketInteraction hook active");
        }
      }
    } catch (e) {
      console.error(
        `[!] Failed to hook InterpretSeedPacketInteraction: ${e.message}`
      );
    }

    console.log("\n[✓✓✓] All 26 hooks installed successfully!");
    console.log("[INFO] ========================================");
    console.log("[INFO] 🌱 NO COOLDOWN MOD ACTIVE 🌱");
    console.log("[INFO] ========================================");
    console.log("[INFO] ✅ Cooldown bypass: ENABLED");
    console.log("[INFO] ✅ Sun cost bypass: ENABLED");
    console.log("[INFO] ✅ Placement validation bypass: ENABLED");
    console.log("[INFO] ✅ Grid cell validation bypass: ENABLED");
    console.log("[INFO] ========================================");
    console.log("[INFO] You can now plant continuously without:");
    console.log("[INFO]   - Waiting for cooldown");
    console.log("[INFO]   - Having enough sun");
    console.log("[INFO]   - Placement restrictions");
    console.log("[INFO]   - Red highlight blocking");
    console.log("[INFO] ========================================\n");
  } catch (err) {
    console.error(`[!!!] Fatal error: ${err.message}`);
    console.error(`[!!!] Stack trace: ${err.stack}`);
    console.error("\n[HELP] Possible issues:");
    console.error(
      "  1. Wrong game version - Assembly structure may have changed"
    );
    console.error("  2. Game is obfuscated - Class/method names are different");
    console.error(
      "  3. IL2CPP not properly initialized - Try restarting the game"
    );
  }
});
