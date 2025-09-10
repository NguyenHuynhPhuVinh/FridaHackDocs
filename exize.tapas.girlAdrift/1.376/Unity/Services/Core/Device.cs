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

                    static /*0xdac830*/ string ReadIdentifierFromFile();
                    static /*0xdac8a0*/ void WriteIdentifierToFile(string identifier);
                    static /*0xdac874*/ string GenerateGuid();
                    /*0xdac4e0*/ InstallationId();
                    /*0xdac58c*/ string GetOrCreateIdentifier();
                    /*0xdac5b8*/ void CreateIdentifier();
                }

                class AndroidUtils
                {
                    static /*0xdac8f4*/ UnityEngine.AndroidJavaObject GetUnityActivity();
                    static /*0xdacac8*/ UnityEngine.AndroidJavaObject GetSharedPreferences(UnityEngine.AndroidJavaObject context, string name, int mode);
                    static /*0xdacbfc*/ UnityEngine.AndroidJavaObject GetSharedPreferences(string name, int mode);
                    static /*0xdacd7c*/ string SharedPreferencesGetString(string name, string key, string defValue);
                    static /*0xdacf08*/ string SharedPreferencesGetString(UnityEngine.AndroidJavaObject preferences, string key, string defValue);
                    static /*0xdad12c*/ void SharedPreferencesPutString(string name, string key, string value);
                    static /*0xdad2a8*/ void SharedPreferencesPutString(UnityEngine.AndroidJavaObject preferences, string key, string value);
                }

                interface IUserIdentifierProvider
                {
                    string get_UserId();
                    void set_UserId(string value);
                }

                class UnityAdsIdentifier : Unity.Services.Core.Device.IUserIdentifierProvider
                {
                    static /*0xdad4c4*/ string get_IdentifierForInstallAndroid();
                    static /*0xdad544*/ void set_IdentifierForInstallAndroid(string value);
                    /*0xdac57c*/ UnityAdsIdentifier();
                    /*0xdad4c0*/ string get_UserId();
                    /*0xdad53c*/ void set_UserId(string value);
                }

                class UnityAnalyticsIdentifier : Unity.Services.Core.Device.IUserIdentifierProvider
                {
                    /*0xdac584*/ UnityAnalyticsIdentifier();
                    /*0xdad5ac*/ string get_UserId();
                    /*0xdad5f0*/ void set_UserId(string value);
                }
            }
        }
    }
}
