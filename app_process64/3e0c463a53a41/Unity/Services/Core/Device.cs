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

                    static /*0x7cf8788*/ string ReadIdentifierFromFile();
                    static /*0x7cf87fc*/ void WriteIdentifierToFile(string identifier);
                    static /*0x7cf87cc*/ string GenerateGuid();
                    /*0x7cf841c*/ InstallationId();
                    /*0x7cf84d8*/ void CreateIdentifier();
                }

                class AndroidUtils
                {
                    static /*0x7cf8850*/ UnityEngine.AndroidJavaObject GetUnityActivity();
                    static /*0x7cf8a30*/ UnityEngine.AndroidJavaObject GetSharedPreferences(UnityEngine.AndroidJavaObject context, string name, int mode);
                    static /*0x7cf8b70*/ UnityEngine.AndroidJavaObject GetSharedPreferences(string name, int mode);
                    static /*0x7cf8cec*/ string SharedPreferencesGetString(string name, string key, string defValue);
                    static /*0x7cf8e74*/ string SharedPreferencesGetString(UnityEngine.AndroidJavaObject preferences, string key, string defValue);
                    static /*0x7cf90c4*/ void SharedPreferencesPutString(string name, string key, string value);
                    static /*0x7cf923c*/ void SharedPreferencesPutString(UnityEngine.AndroidJavaObject preferences, string key, string value);
                }

                interface IUserIdentifierProvider
                {
                    /*0x380b9e8*/ string get_UserId();
                    /*0x380d83c*/ void set_UserId(string value);
                }

                class UnityAdsIdentifier : Unity.Services.Core.Device.IUserIdentifierProvider
                {
                    static /*0x7cf9490*/ string get_IdentifierForInstallAndroid();
                    static /*0x7cf9510*/ void set_IdentifierForInstallAndroid(string value);
                    /*0x7cf84c8*/ UnityAdsIdentifier();
                    /*0x7cf948c*/ string get_UserId();
                    /*0x7cf9508*/ void set_UserId(string value);
                }

                class UnityAnalyticsIdentifier : Unity.Services.Core.Device.IUserIdentifierProvider
                {
                    /*0x7cf84d0*/ UnityAnalyticsIdentifier();
                    /*0x7cf9578*/ string get_UserId();
                    /*0x7cf95bc*/ void set_UserId(string value);
                }
            }
        }
    }
}
