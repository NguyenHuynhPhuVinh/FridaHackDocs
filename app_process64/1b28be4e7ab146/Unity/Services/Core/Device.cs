class <Module>
{
}

namespace Unity
{
    namespace Services
    {
        namespace Core
        {
            namespace Device
            {
                class InstallationId : Unity.Services.Core.Device.Internal.IInstallationId, Unity.Services.Core.Internal.IServiceComponent
                {
                    /*0x10*/ string Identifier;
                    /*0x18*/ Unity.Services.Core.Device.IUserIdentifierProvider UnityAdsIdentifierProvider;
                    /*0x20*/ Unity.Services.Core.Device.IUserIdentifierProvider UnityAnalyticsIdentifierProvider;

                    static /*0x7d0fbb8*/ string ReadIdentifierFromFile();
                    static /*0x7d0fc2c*/ void WriteIdentifierToFile(string identifier);
                    static /*0x7d0fbfc*/ string GenerateGuid();
                    /*0x7d0f84c*/ InstallationId();
                    /*0x7d0f908*/ void CreateIdentifier();
                }

                class AndroidUtils
                {
                    static /*0x7d0fc80*/ UnityEngine.AndroidJavaObject GetUnityActivity();
                    static /*0x7d0fe60*/ UnityEngine.AndroidJavaObject GetSharedPreferences(UnityEngine.AndroidJavaObject context, string name, int mode);
                    static /*0x7d0ffa0*/ UnityEngine.AndroidJavaObject GetSharedPreferences(string name, int mode);
                    static /*0x7d1011c*/ string SharedPreferencesGetString(string name, string key, string defValue);
                    static /*0x7d102a4*/ string SharedPreferencesGetString(UnityEngine.AndroidJavaObject preferences, string key, string defValue);
                    static /*0x7d104f4*/ void SharedPreferencesPutString(string name, string key, string value);
                    static /*0x7d1066c*/ void SharedPreferencesPutString(UnityEngine.AndroidJavaObject preferences, string key, string value);
                }

                interface IUserIdentifierProvider
                {
                    /*0x38148bc*/ string get_UserId();
                    /*0x3816710*/ void set_UserId(string value);
                }

                class UnityAdsIdentifier : Unity.Services.Core.Device.IUserIdentifierProvider
                {
                    static /*0x7d108c0*/ string get_IdentifierForInstallAndroid();
                    static /*0x7d10940*/ void set_IdentifierForInstallAndroid(string value);
                    /*0x7d0f8f8*/ UnityAdsIdentifier();
                    /*0x7d108bc*/ string get_UserId();
                    /*0x7d10938*/ void set_UserId(string value);
                }

                class UnityAnalyticsIdentifier : Unity.Services.Core.Device.IUserIdentifierProvider
                {
                    /*0x7d0f900*/ UnityAnalyticsIdentifier();
                    /*0x7d109a8*/ string get_UserId();
                    /*0x7d109ec*/ void set_UserId(string value);
                }
            }
        }
    }
}
