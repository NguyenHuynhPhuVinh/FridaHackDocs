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

                    static /*0x2b37b60*/ string ReadIdentifierFromFile();
                    static /*0x2b37c24*/ void WriteIdentifierToFile(string identifier);
                    static /*0x2b37ba8*/ string GenerateGuid();
                    /*0x2b377ec*/ InstallationId();
                    /*0x2b37890*/ string GetOrCreateIdentifier();
                    /*0x2b378c8*/ void CreateIdentifier();
                }

                class AndroidUtils
                {
                    static /*0x2b36c38*/ UnityEngine.AndroidJavaObject GetUnityActivity();
                    static /*0x2b36de0*/ UnityEngine.AndroidJavaObject GetSharedPreferences(UnityEngine.AndroidJavaObject context, string name, int mode);
                    static /*0x2b36f20*/ UnityEngine.AndroidJavaObject GetSharedPreferences(string name, int mode);
                    static /*0x2b37064*/ string SharedPreferencesGetString(string name, string key, string defValue);
                    static /*0x2b371b4*/ string SharedPreferencesGetString(UnityEngine.AndroidJavaObject preferences, string key, string defValue);
                    static /*0x2b373fc*/ void SharedPreferencesPutString(string name, string key, string value);
                    static /*0x2b37540*/ void SharedPreferencesPutString(UnityEngine.AndroidJavaObject preferences, string key, string value);
                }

                interface IUserIdentifierProvider
                {
                    string get_UserId();
                    void set_UserId(string value);
                }

                class UnityAdsIdentifier : Unity.Services.Core.Device.IUserIdentifierProvider
                {
                    static /*0x2b37c80*/ string get_IdentifierForInstallAndroid();
                    static /*0x2b37cfc*/ void set_IdentifierForInstallAndroid(string value);
                    /*0x2b37880*/ UnityAdsIdentifier();
                    /*0x2b37c7c*/ string get_UserId();
                    /*0x2b37cf4*/ void set_UserId(string value);
                }

                class UnityAnalyticsIdentifier : Unity.Services.Core.Device.IUserIdentifierProvider
                {
                    /*0x2b37888*/ UnityAnalyticsIdentifier();
                    /*0x2b37d60*/ string get_UserId();
                    /*0x2b37da8*/ void set_UserId(string value);
                }
            }
        }
    }
}
