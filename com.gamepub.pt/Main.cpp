// --- START OF FILE Main.cpp ---

#include <list>
#include <vector>
#include <cstring>
#include <pthread.h>
#include <thread>
#include <jni.h>
#include <unistd.h>
#include <fstream>
#include <iostream>
#include <dlfcn.h>
#include "Includes/Logger.h"
#include "Includes/obfuscate.h"
#include "Includes/Utils.hpp"
#include "Menu/Menu.hpp"
#include "Menu/Jni.hpp"
#include "Includes/Macros.h"
#include "KittyMemory/KittyInclude.hpp"

#if defined(__aarch64__)
#include "And64InlineHook/And64InlineHook.hpp"
#else
#include "Substrate/SubstrateHook.h"
#include "Substrate/CydiaSubstrate.h"
#endif

#define targetLibName OBFUSCATE("libil2cpp.so")

// ===============================================================================================
// === MOD MENU CHO GAME "CHUYỆN CÔNG CHÚA" (com.gamepub.pt) ===
// ===============================================================================================

namespace GameOffsets {
    const uintptr_t AddHP = 0xd7e10c;
    const uintptr_t get_IsPlayer = 0xd71e70;
}

// === KHAI BÁO BIẾN TOÀN CỤC CHO CÁC CHỨC NĂNG ===
// Thay thế các biến bool bằng các biến hệ số nhân
int defenseMultiplier = 1; // Mặc định là 1 (không giảm sát thương)
int damageMultiplier = 1; // Mặc định là 1 (không tăng sát thương)

bool (*isPlayer_ptr)(void *instance);

bool isPlayer(void *characterBaseInstance) {
    if (characterBaseInstance != nullptr && isPlayer_ptr != nullptr) {
        return isPlayer_ptr(characterBaseInstance);
    }
    return false;
}

// === HOOK HÀM ADDHP ĐỂ KIỂM SOÁT CẢ SÁT THƯƠNG NHẬN VÀO VÀ GÂY RA ===
void (*orig_AddHP)(void* instance, float addValue, void* caster, bool isAddDamage, int markType);

void fake_AddHP(void* instance, float addValue, void* caster, bool isAddDamage, int markType) {
    if (instance == nullptr || caster == nullptr) {
        return orig_AddHP(instance, addValue, caster, isAddDamage, markType);
    }

    // Chỉ can thiệp khi giá trị là âm (mất máu/nhận sát thương)
    if (addValue < 0) {
        bool receiverIsPlayer = isPlayer(instance);
        bool casterIsPlayer = isPlayer(caster);

        // --- LOGIC DEFENSE MULTIPLIER (Nâng cấp từ God Mode) ---
        // Nếu người chơi nhận sát thương từ một nguồn không phải người chơi
        if (defenseMultiplier > 1 && receiverIsPlayer && !casterIsPlayer) {
            float originalDamage = addValue; // Sát thương gốc là số âm
            // Chia sát thương nhận vào cho hệ số phòng thủ
            float reducedDamage = originalDamage / defenseMultiplier;
            LOGD(OBFUSCATE("[Defense x%d] Reduced incoming damage from %.0f to %.0f"), defenseMultiplier, originalDamage, reducedDamage);
            return orig_AddHP(instance, reducedDamage, caster, isAddDamage, markType);
        }

        // --- LOGIC DAMAGE MULTIPLIER ---
        // Nếu quái nhận sát thương từ người chơi
        if (damageMultiplier > 1 && !receiverIsPlayer && casterIsPlayer) {
            float originalDamage = addValue;
            float multipliedDamage = originalDamage * damageMultiplier;
            LOGD(OBFUSCATE("[Damage x%d] Overriding HP loss from %.0f to %.0f"), damageMultiplier, originalDamage, multipliedDamage);
            return orig_AddHP(instance, multipliedDamage, caster, isAddDamage, markType);
        }
    }

    // Đối với các trường hợp khác (hồi máu, tự gây sát thương, cheat tắt), gọi hàm gốc
    return orig_AddHP(instance, addValue, caster, isAddDamage, markType);
}

// ===============================================================================================
// === TÍCH HỢP VÀO MENU (ĐÃ CẬP NHẬT) ===
// ===============================================================================================

jobjectArray GetFeatureList(JNIEnv *env, jobject context) {
    jobjectArray ret;
    const char *features[] = {
            OBFUSCATE("Category_Mod Chuyện Công Chúa by TomiSakae!"),
            OBFUSCATE("0_SeekBar_Hệ Số Phòng Thủ_1_1000"), // Min: 1 (không giảm), Max: 1000
            OBFUSCATE("1_SeekBar_Hệ Số Sát Thương_1_1000"), // Min: 1 (không tăng), Max: 1000
    };
    int Total_Feature = (sizeof features / sizeof features[0]);
    ret = (jobjectArray)env->NewObjectArray(Total_Feature, env->FindClass(OBFUSCATE("java/lang/String")), env->NewStringUTF(""));
    for (int i = 0; i < Total_Feature; i++)
        env->SetObjectArrayElement(ret, i, env->NewStringUTF(features[i]));
    return (ret);
}

void Changes(JNIEnv *env, jclass clazz, jobject obj, jint featNum, jstring featName, jint value, jlong Lvalue, jboolean boolean, jstring text) {
    switch (featNum) {
        case 0:
            // Lấy giá trị từ thanh trượt phòng thủ
            defenseMultiplier = value;
            if (defenseMultiplier > 1) {
                LOGI("[+] Defense Multiplier set to x%d", defenseMultiplier);
            } else {
                LOGI("[+] Defense Multiplier DISABLED");
            }
            break;
        case 1:
            // Lấy giá trị từ thanh trượt sát thương
            damageMultiplier = value;
            if (damageMultiplier > 1) {
                LOGI("[+] Damage Multiplier set to x%d", damageMultiplier);
            } else {
                LOGI("[+] Damage Multiplier DISABLED");
            }
            break;
    }
}

// === HACK THREAD (KHÔNG THAY ĐỔI) ===
void hack_thread() {
    LOGI(OBFUSCATE("Hack thread started. Waiting for %s"), (const char *) targetLibName);

    do {
        sleep(1);
    } while (!isLibraryLoaded(targetLibName));
    LOGI(OBFUSCATE("%s is now loaded. Trying to get base address..."), (const char *) targetLibName);

    uintptr_t il2cpp_base = 0;
    do {
        il2cpp_base = findLibrary(targetLibName);
        if (il2cpp_base == 0) {
            LOGD("Still waiting for %s base address...", (const char *) targetLibName);
            sleep(1);
        }
    } while (il2cpp_base == 0);

    LOGI(OBFUSCATE("%s has been loaded at %p. Applying hooks..."), (const char *) targetLibName, (void*)il2cpp_base);

#if defined(__aarch64__)
    isPlayer_ptr = (bool (*)(void*)) (il2cpp_base + GameOffsets::get_IsPlayer);
    LOGI(OBFUSCATE("get_IsPlayer function located at: %p"), isPlayer_ptr);

    uintptr_t addHPAddr = il2cpp_base + GameOffsets::AddHP;
    LOGI(OBFUSCATE("Hooking AddHP at: %p"), (void*)addHPAddr);
    A64HookFunction((void *)addHPAddr, (void *)fake_AddHP, (void **)&orig_AddHP);

#elif defined(__arm__)
    // Thêm offset cho ARMv7 nếu cần
#endif

    LOGI(OBFUSCATE("Hacks applied successfully!"));
}

__attribute__((constructor))
void lib_main() {
    std::thread(hack_thread).detach();
}

// --- END OF FILE Main.cpp ---