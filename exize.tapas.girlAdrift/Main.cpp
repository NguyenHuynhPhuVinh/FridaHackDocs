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

// Dobby/Substrate/And64InlineHook
#if defined(__aarch64__)
#include "And64InlineHook/And64InlineHook.hpp"
#else
#include "Substrate/SubstrateHook.h"
#include "Substrate/CydiaSubstrate.h"
#endif

#define targetLibName OBFUSCATE("libil2cpp.so")

// ===============================================================================================
// === MOD MENU CHO GAME "A GIRL ADRIFT" ===
// ===============================================================================================

// Định nghĩa một struct giữ chỗ cho System.Nullable<UnityEngine.Vector3>
// Dựa trên cấu trúc C#: 3 float cho Vector3 và 1 bool cho has_value.
struct System_Nullable_Vector3_o {
    float x, y, z;
    bool has_value;
    char padding[3]; // Căn chỉnh bộ nhớ (padding) để đảm bảo kích thước đúng
};

// Các biến để bật/tắt cheat từ menu
bool isGoldHackEnabled = false;
bool isFreeShoppingEnabled = false;
const int GOLD_MULTIPLIER = 100;

// === KHAI BÁO HÀM GỐC VÀ HÀM GIẢ (HOOK) ===

// 1. Khai báo cho Fish Reward Hack (player_currency_element.Add)
// Chữ ký C++ tương ứng: void Add(void *instance, double num, System_Nullable_Vector3_o *effect_pos, bool isWorldPos)
void (*orig_Add)(void *instance, double num, System_Nullable_Vector3_o *effect_pos, bool isWorldPos);
void fake_Add(void *instance, double num, System_Nullable_Vector3_o *effect_pos, bool isWorldPos) {
    if (isGoldHackEnabled && num > 0) {
        double hackedGold = num * GOLD_MULTIPLIER;
        LOGD(OBFUSCATE("[Fish Hack] Original: %.2f -> Hacked: %.2f"), num, hackedGold);
        return orig_Add(instance, hackedGold, effect_pos, isWorldPos);
    }
    return orig_Add(instance, num, effect_pos, isWorldPos);
}

// 2. Khai báo cho Free Shopping Hack (player_currency_element.Use)
// Chữ ký C++ tương ứng: void Use(void *instance, double amount_to_spend)
void (*orig_Use)(void *instance, double amount_to_spend);
void fake_Use(void *instance, double amount_to_spend) {
    if (isFreeShoppingEnabled && amount_to_spend > 0) {
        double reversedAmount = -amount_to_spend;
        LOGD(OBFUSCATE("[Shopping Hack] Original spend: %.2f -> Patched to: %.2f"), amount_to_spend, reversedAmount);
        return orig_Use(instance, reversedAmount);
    }
    return orig_Use(instance, amount_to_spend);
}

// ===============================================================================================
// === TÍCH HỢP VÀO MENU ===
// ===============================================================================================

jobjectArray GetFeatureList(JNIEnv *env, jobject context) {
    jobjectArray ret;

    const char *features[] = {
            OBFUSCATE("Category_Mod A Girl Adrift by TomiSakae!"),
            OBFUSCATE("0_Toggle_Tăng Vàng Câu Cá (x100)"),
            OBFUSCATE("1_Toggle_Mua Sắm Miễn Phí"),
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
            isGoldHackEnabled = boolean;
            break;
        case 1:
            isFreeShoppingEnabled = boolean;
            break;
    }
}

void hack_thread() {
    LOGI(OBFUSCATE("Hack thread started. Waiting for %s"), (const char *) targetLibName);

    do {
        sleep(1);
    } while (!isLibraryLoaded(targetLibName));

    LOGI(OBFUSCATE("%s has been loaded. Applying hooks..."), (const char *) targetLibName);

#if defined(__aarch64__)
    // === CÁC OFFSET CHÍNH XÁC TỪ FILE DUMP C# ===

    // Offset cho hàm: player_currency_element$$Add(double, Nullable<Vector3>, bool)
    // RVA của bạn: 0x18B9070
    HOOK(targetLibName, 0x18B9070, fake_Add, orig_Add);

    // Offset cho hàm: player_currency_element$$Use(double)
    // RVA của bạn: 0x18B93DC
    HOOK(targetLibName, 0x18B93DC, fake_Use, orig_Use);

#elif defined(__arm__)
    // Nếu game có thư viện ARMv7, bạn sẽ cần tìm offset cho nó riêng
    // HOOK(targetLibName, 0xOFFSET_ARMv7_ADD, fake_Add, orig_Add);
    // HOOK(targetLibName, 0xOFFSET_ARMv7_USE, fake_Use, orig_Use);
#endif

    LOGI(OBFUSCATE("Hacks applied successfully!"));
}

__attribute__((constructor))
void lib_main() {
    std::thread(hack_thread).detach();
}