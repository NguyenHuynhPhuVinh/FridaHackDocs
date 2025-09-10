class <Module>
{
}

namespace Facebook
{
    namespace Unity
    {
        namespace Settings
        {
            class FacebookSettings : UnityEngine.ScriptableObject
            {
                static string FacebookSettingsAssetName = "FacebookSettings";
                static string FacebookSettingsPath = "FacebookSDK/SDK/Resources";
                static string FacebookSettingsAssetExtension = ".asset";
                static /*0x0*/ System.Collections.Generic.List<Facebook.Unity.Settings.FacebookSettings.OnChangeCallback> onChangeCallbacks;
                static /*0x8*/ Facebook.Unity.Settings.FacebookSettings instance;
                /*0x18*/ int selectedAppIndex;
                /*0x20*/ System.Collections.Generic.List<string> clientTokens;
                /*0x28*/ System.Collections.Generic.List<string> appIds;
                /*0x30*/ System.Collections.Generic.List<string> appLabels;
                /*0x38*/ bool cookie;
                /*0x39*/ bool logging;
                /*0x3a*/ bool status;
                /*0x3b*/ bool xfbml;
                /*0x3c*/ bool frictionlessRequests;
                /*0x40*/ string iosURLSuffix;
                /*0x48*/ System.Collections.Generic.List<Facebook.Unity.Settings.FacebookSettings.UrlSchemes> appLinkSchemes;
                /*0x50*/ string uploadAccessToken;
                /*0x58*/ bool autoLogAppEventsEnabled;
                /*0x59*/ bool advertiserIDCollectionEnabled;

                static /*0x18b3630*/ FacebookSettings();
                static /*0x18b1e64*/ int get_SelectedAppIndex();
                static /*0x18b1fbc*/ void set_SelectedAppIndex(int value);
                static /*0x18b2178*/ System.Collections.Generic.List<string> get_AppIds();
                static /*0x18b21d4*/ void set_AppIds(System.Collections.Generic.List<string> value);
                static /*0x18b2264*/ System.Collections.Generic.List<string> get_AppLabels();
                static /*0x18b22c0*/ void set_AppLabels(System.Collections.Generic.List<string> value);
                static /*0x18b2350*/ System.Collections.Generic.List<string> get_ClientTokens();
                static /*0x18b23ac*/ void set_ClientTokens(System.Collections.Generic.List<string> value);
                static /*0x18b243c*/ string get_AppId();
                static /*0x18b24c8*/ string get_ClientToken();
                static /*0x18b2554*/ bool get_IsValidAppId();
                static /*0x18b2618*/ bool get_Cookie();
                static /*0x18b2674*/ void set_Cookie(bool value);
                static /*0x18b270c*/ bool get_Logging();
                static /*0x18b2768*/ void set_Logging(bool value);
                static /*0x18b2800*/ bool get_Status();
                static /*0x18b285c*/ void set_Status(bool value);
                static /*0x18b28f4*/ bool get_Xfbml();
                static /*0x18b2950*/ void set_Xfbml(bool value);
                static /*0x18b29e8*/ string get_IosURLSuffix();
                static /*0x18b2a44*/ void set_IosURLSuffix(string value);
                static /*0x18b2adc*/ string get_ChannelUrl();
                static /*0x18b2b1c*/ bool get_FrictionlessRequests();
                static /*0x18b2b78*/ void set_FrictionlessRequests(bool value);
                static /*0x18b2c10*/ System.Collections.Generic.List<Facebook.Unity.Settings.FacebookSettings.UrlSchemes> get_AppLinkSchemes();
                static /*0x18b2c6c*/ void set_AppLinkSchemes(System.Collections.Generic.List<Facebook.Unity.Settings.FacebookSettings.UrlSchemes> value);
                static /*0x18b2cfc*/ string get_UploadAccessToken();
                static /*0x18b2d58*/ void set_UploadAccessToken(string value);
                static /*0x18b2df0*/ bool get_AutoLogAppEventsEnabled();
                static /*0x18b2e4c*/ void set_AutoLogAppEventsEnabled(bool value);
                static /*0x18b2ee4*/ bool get_AdvertiserIDCollectionEnabled();
                static /*0x18b2f40*/ void set_AdvertiserIDCollectionEnabled(bool value);
                static /*0x18b1ec0*/ Facebook.Unity.Settings.FacebookSettings get_Instance();
                static /*0x18b2fd8*/ Facebook.Unity.Settings.FacebookSettings get_NullableInstance();
                static /*0x18b3118*/ void RegisterChangeEventCallback(Facebook.Unity.Settings.FacebookSettings.OnChangeCallback callback);
                static /*0x18b31e8*/ void UnregisterChangeEventCallback(Facebook.Unity.Settings.FacebookSettings.OnChangeCallback callback);
                static /*0x18b204c*/ void SettingsChanged();
                /*0x18b3268*/ FacebookSettings();

                class OnChangeCallback : System.MulticastDelegate
                {
                    /*0x18b36bc*/ OnChangeCallback(object object, nint method);
                    /*0x18b3778*/ void Invoke();
                    /*0x18b378c*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                    /*0x18b37ac*/ void EndInvoke(System.IAsyncResult result);
                }

                class UrlSchemes
                {
                    /*0x10*/ System.Collections.Generic.List<string> list;

                    /*0x18b35a4*/ UrlSchemes(System.Collections.Generic.List<string> schemes);
                    /*0x18b37b8*/ System.Collections.Generic.List<string> get_Schemes();
                    /*0x18b37c0*/ void set_Schemes(System.Collections.Generic.List<string> value);
                }

                class <>c
                {
                    static /*0x0*/ Facebook.Unity.Settings.FacebookSettings.<> <>9;
                    static /*0x8*/ System.Action<Facebook.Unity.Settings.FacebookSettings.OnChangeCallback> <>9__76_0;

                    static /*0x18b37c8*/ <>c();
                    /*0x18b382c*/ <>c();
                    /*0x18b3834*/ void <SettingsChanged>b__76_0(Facebook.Unity.Settings.FacebookSettings.OnChangeCallback callback);
                }
            }
        }
    }
}
