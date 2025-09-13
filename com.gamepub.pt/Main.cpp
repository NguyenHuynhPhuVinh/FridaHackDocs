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
#include "KittyMemory/KittyInclude.hpp" // THÊM DÒNG NÀY

// Dobby/Substrate/And64InlineHook
#if defined(__aarch64__)
#include "And64InlineHook/And64InlineHook.hpp"
#else
#include "Substrate/SubstrateHook.h"
#include "Substrate/CydiaSubstrate.h"
#endif

#define targetLibName OBFUSCATE("libil2cpp.so")

// ===============================================================================================
// === MOD MENU CHO GAME "CHUYỆN CÔNG CHÚA" (com.gamepub.pt) ===
// Dựa trên phân tích từ Frida
// ===============================================================================================

// === ĐỊNH NGHĨA CÁC STRUCT C# TRONG C++ ===

struct Battle_StatTransfer_o {
    char padding[0x1c];
    float Damage;
};

struct Battle_DamageResult_o {
    char data[8];
};

bool isGodModeEnabled = false;
bool isOneHitKillEnabled = false;
const float DAMAGE_MULTIPLIER = 1000.0f;

bool (*isPlayer_ptr)(void *instance);

bool isPlayer(void *characterBaseInstance) {
    if (characterBaseInstance != nullptr && isPlayer_ptr != nullptr) {
        return isPlayer_ptr(characterBaseInstance);
    }
    return false;
}

// === KHAI BÁO HÀM GỐC VÀ HÀM GIẢ (HOOK) ===
Battle_DamageResult_o (*orig_RecieveDamage)(void *instance, void *attacker, void *statTransfer, bool bAddDamage, void *vAttackPOS);
Battle_DamageResult_o fake_RecieveDamage(void *instance, void *attacker, void *statTransfer, bool bAddDamage, void *vAttackPOS) {
    bool receiverIsPlayer = isPlayer(instance);
    bool attackerIsPlayer = isPlayer(attacker);

    Battle_StatTransfer_o *pStat = (Battle_StatTransfer_o *)statTransfer;
    float originalDamage = pStat->Damage;

    if (isGodModeEnabled && receiverIsPlayer && !attackerIsPlayer) {
        if (originalDamage > 1.0f) {
            LOGD(OBFUSCATE("[God Mode] Blocked damage: %.0f -> 1"), originalDamage);
            pStat->Damage = 1.0f;
        }
    }

    if (isOneHitKillEnabled && !receiverIsPlayer && attackerIsPlayer) {
        if (originalDamage > 0.0f) {
            float newDamage = originalDamage * DAMAGE_MULTIPLIER;
            LOGD(OBFUSCATE("[One-Hit] Modified damage: %.0f -> %.0f"), originalDamage, newDamage);
            pStat->Damage = newDamage;
        }
    }

    return orig_RecieveDamage(instance, attacker, statTransfer, bAddDamage, vAttackPOS);
}

// ===============================================================================================
// === TÍCH HỢP VÀO MENU ===
// ===============================================================================================

jobjectArray GetFeatureList(JNIEnv *env, jobject context) {
    jobjectArray ret;

    const char *features[] = {
            OBFUSCATE("Category_Mod Chuyện Công Chúa by TomiSakae!"),
            OBFUSCATE("0_Toggle_God Mode (Bất Tử)"),
            OBFUSCATE("1_Toggle_One-Hit Kill (Sát thương x1000)"),
    };

    int Total_Feature = (sizeof features / sizeof features[0]);
    ret = (jobjectArray)
            env->NewObjectArray(Total_Feature, env->FindClass(OBFUSCATE("java/lang/String")),
                                env->NewStringUTF(""));

    for (int i = 0; i < Total_Feature; i++)
        env->SetObjectArrayElement(ret, i, env->NewStringUTF(features[i]));

    return (ret);
}

void Changes(JNIEnv *env, jclass clazz, jobject obj, jint featNum, jstring featName, jint value, jlong Lvalue, jboolean boolean, jstring text) {
    switch (featNum) {
        case 0:
            isGodModeEnabled = boolean;
            break;
        case 1:
            isOneHitKillEnabled = boolean;
            break;
    }
}

void hack_thread() {
    LOGI(OBFUSCATE("Hack thread started. Waiting for %s"), (const char *) targetLibName);

    do {
        sleep(1);
    } while (!isLibraryLoaded(targetLibName));

    // SỬA LỖI Ở ĐÂY: Dùng KittyMemory để lấy địa chỉ cơ sở
    KittyMemory::ProcMap il2cppMap = KittyMemory::getElfBaseMap(targetLibName);
    while (!il2cppMap.isValid()) {
        LOGD(OBFUSCATE("Waiting for %s to be fully loaded in memory..."), (const char *) targetLibName);
        il2cppMap = KittyMemory::getElfBaseMap(targetLibName);
        sleep(1);
    }
    uintptr_t il2cpp_base = il2cppMap.startAddress;

    LOGI(OBFUSCATE("%s has been loaded at %p. Applying hooks..."), (const char *) targetLibName, (void*)il2cpp_base);

#if defined(__aarch64__)
    isPlayer_ptr = (bool (*)(void*)) (il2cpp_base + 0xd71e70);
    LOGI(OBFUSCATE("get_IsPlayer function located at: %p"), isPlayer_ptr);

    HOOK(targetLibName, 0xd7f560, fake_RecieveDamage, orig_RecieveDamage);
#elif defined(__arm__)
    // Thêm offset cho ARMv7 nếu cần
#endif

    LOGI(OBFUSCATE("Hacks applied successfully!"));
}

__attribute__((constructor))
void lib_main() {
    std::thread(hack_thread).detach();
}