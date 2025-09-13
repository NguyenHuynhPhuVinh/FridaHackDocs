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
                /*0x40*/ string androidKeystorePath;
                /*0x48*/ string iosURLSuffix;
                /*0x50*/ System.Collections.Generic.List<Facebook.Unity.Settings.FacebookSettings.UrlSchemes> appLinkSchemes;
                /*0x58*/ string uploadAccessToken;
                /*0x60*/ bool autoLogAppEventsEnabled;
                /*0x61*/ bool advertiserIDCollectionEnabled;
                /*0x64*/ Facebook.Unity.Settings.FacebookSettings.BuildTarget editorBuildTargetName;

                static /*0x2b2d0cc*/ FacebookSettings();
                static /*0x2b2b5c4*/ Facebook.Unity.Settings.FacebookSettings.BuildTarget get_EditorBuildTarget();
                static /*0x2b2b750*/ void set_EditorBuildTarget(Facebook.Unity.Settings.FacebookSettings.BuildTarget value);
                static /*0x2b2b7bc*/ int get_SelectedAppIndex();
                static /*0x2b2b824*/ void set_SelectedAppIndex(int value);
                static /*0x2b2ba20*/ System.Collections.Generic.List<string> get_AppIds();
                static /*0x2b2ba88*/ void set_AppIds(System.Collections.Generic.List<string> value);
                static /*0x2b2bb2c*/ System.Collections.Generic.List<string> get_AppLabels();
                static /*0x2b2bb94*/ void set_AppLabels(System.Collections.Generic.List<string> value);
                static /*0x2b2bc38*/ System.Collections.Generic.List<string> get_ClientTokens();
                static /*0x2b2bca0*/ void set_ClientTokens(System.Collections.Generic.List<string> value);
                static /*0x2b2bd44*/ string get_AppId();
                static /*0x2b2bde8*/ string get_ClientToken();
                static /*0x2b2be8c*/ bool get_IsValidAppId();
                static /*0x2b2bf6c*/ bool get_Cookie();
                static /*0x2b2bfd4*/ void set_Cookie(bool value);
                static /*0x2b2c084*/ bool get_Logging();
                static /*0x2b2c0ec*/ void set_Logging(bool value);
                static /*0x2b2c19c*/ bool get_Status();
                static /*0x2b2c204*/ void set_Status(bool value);
                static /*0x2b2c2b4*/ bool get_Xfbml();
                static /*0x2b2c31c*/ void set_Xfbml(bool value);
                static /*0x2b2c3cc*/ string get_AndroidKeystorePath();
                static /*0x2b2c434*/ void set_AndroidKeystorePath(string value);
                static /*0x2b2c4e0*/ string get_IosURLSuffix();
                static /*0x2b2c548*/ void set_IosURLSuffix(string value);
                static /*0x2b2c5f4*/ string get_ChannelUrl();
                static /*0x2b2c638*/ bool get_FrictionlessRequests();
                static /*0x2b2c6a0*/ void set_FrictionlessRequests(bool value);
                static /*0x2b2c750*/ System.Collections.Generic.List<Facebook.Unity.Settings.FacebookSettings.UrlSchemes> get_AppLinkSchemes();
                static /*0x2b2c7b8*/ void set_AppLinkSchemes(System.Collections.Generic.List<Facebook.Unity.Settings.FacebookSettings.UrlSchemes> value);
                static /*0x2b2c85c*/ string get_UploadAccessToken();
                static /*0x2b2c8c4*/ void set_UploadAccessToken(string value);
                static /*0x2b2c970*/ bool get_AutoLogAppEventsEnabled();
                static /*0x2b2c9d8*/ void set_AutoLogAppEventsEnabled(bool value);
                static /*0x2b2ca88*/ bool get_AdvertiserIDCollectionEnabled();
                static /*0x2b2caf0*/ void set_AdvertiserIDCollectionEnabled(bool value);
                static /*0x2b2b62c*/ Facebook.Unity.Settings.FacebookSettings get_Instance();
                static /*0x2b2cba0*/ Facebook.Unity.Settings.FacebookSettings get_NullableInstance();
                static /*0x2b2ccf4*/ void RegisterChangeEventCallback(Facebook.Unity.Settings.FacebookSettings.OnChangeCallback callback);
                static /*0x2b2cd80*/ void UnregisterChangeEventCallback(Facebook.Unity.Settings.FacebookSettings.OnChangeCallback callback);
                static /*0x2b2b8c8*/ void SettingsChanged();
                /*0x2b2ce0c*/ FacebookSettings();

                enum BuildTarget
                {
                    StandaloneOSX = 0,
                    StandaloneWindows = 1,
                    iOS = 2,
                    Android = 3,
                    StandaloneWindows64 = 4,
                    WebGL = 5,
                    WSAPlayer = 6,
                    StandaloneLinux64 = 7,
                    PS4 = 8,
                    XboxOne = 9,
                    tvOS = 10,
                    Switch = 11,
                    Stadia = 12,
                    CloudRendering = 13,
                    PS5 = 14,
                    none = 15,
                }

                class OnChangeCallback : System.MulticastDelegate
                {
                    /*0x2b2d3e0*/ OnChangeCallback(object object, nint method);
                    /*0x2b2d1d4*/ void Invoke();
                    /*0x2b2d440*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                    /*0x2b2d46c*/ void EndInvoke(System.IAsyncResult result);
                }

                class UrlSchemes
                {
                    /*0x10*/ System.Collections.Generic.List<string> list;

                    /*0x2b2d038*/ UrlSchemes(System.Collections.Generic.List<string> schemes);
                    /*0x2b2d478*/ System.Collections.Generic.List<string> get_Schemes();
                    /*0x2b2d480*/ void set_Schemes(System.Collections.Generic.List<string> value);
                }

                class <>c
                {
                    static /*0x0*/ Facebook.Unity.Settings.FacebookSettings.<> <>9;
                    static /*0x8*/ System.Action<Facebook.Unity.Settings.FacebookSettings.OnChangeCallback> <>9__85_0;

                    static /*0x2b2d154*/ <>c();
                    /*0x2b2d1b4*/ <>c();
                    /*0x2b2d1bc*/ void <SettingsChanged>b__85_0(Facebook.Unity.Settings.FacebookSettings.OnChangeCallback callback);
                }
            }
        }
    }
}
