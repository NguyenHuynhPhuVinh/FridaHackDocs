class <Module>
{
}

namespace EA
{
    namespace Unity
    {
        namespace StarlightWrapper
        {
            class BuildSettings : UnityEngine.ScriptableObject
            {
                static string DEFAULT_SCRIPTABLE_OBJECT_NAME = "StarlightWrapper-BuildSettings";
                /*0x18*/ bool doBuildPostProcess;
                /*0x19*/ bool updateGradleProperties;
                /*0x1a*/ bool forceEnableAndroidJetifier;
                /*0x1b*/ bool mergeAndroidManifestFiles;
                /*0x1c*/ bool useCustomAndroidPushNotificationMessagingService;
                /*0x20*/ string googleAdManagerAppIdIos;
                /*0x28*/ string googleAdManagerAppIdAndroid;
                /*0x30*/ bool updatePlistForGoogleAdManager;
                /*0x31*/ bool includeNetworkSecurityConfig;
                /*0x32*/ bool networkSecurityConfigDebugOverridesEnabled;
                /*0x34*/ EA.Unity.StarlightWrapper.AdReviewConfigs adReviewConfig;
                /*0x38*/ string jsonAdsDataPath;
                /*0x40*/ bool deleteDuplicateGsonLibrary;
                /*0x41*/ bool removeEmbeddedFirebaseComponentsFromXcodeProject;
                /*0x42*/ bool deleteDuplicateInstallReferrerLibrary;
                /*0x43*/ bool doPostProcessAttLocalization;
                /*0x48*/ EA.Unity.StarlightWrapper.LocalizedTextSet localizedUserTrackingUsageDescriptions;
                /*0x50*/ string photoLibraryUsageDescription;
                /*0x58*/ EA.Unity.StarlightWrapper.LocalizedTextSet localizedPhotoLibraryUsageDescriptions;
                /*0x60*/ string cameraUsageDescription;
                /*0x68*/ EA.Unity.StarlightWrapper.LocalizedTextSet localizedCameraUsageDescriptions;
                /*0x70*/ bool enableHardwareAccelerationForHelpshiftActivity;
                /*0x78*/ UnityEngine.Texture2D androidNotificationIcon;
                /*0x80*/ UnityEngine.Texture2D androidLargeNotificationIcon;

                /*0x2bf7664*/ BuildSettings();
                /*0x2bf75ac*/ bool get_DoBuildPostProcess();
                /*0x2bf75b4*/ bool get_UpdateGradleProperties();
                /*0x2bf75bc*/ bool get_ForceEnableAndroidJetifier();
                /*0x2bf75c4*/ bool get_MergeAndroidManifestFiles();
                /*0x2bf75cc*/ bool get_UseCustomAndroidPushNotificationMessagingService();
                /*0x2bf75d4*/ string get_GoogleAdManagerAppId();
                /*0x2bf75dc*/ bool get_UpdatePlistForGoogleAdManager();
                /*0x2bf75e4*/ EA.Unity.StarlightWrapper.AdReviewConfigs get_AdReviewConfig();
                /*0x2bf75ec*/ bool get_IncludeNetworkSecurityConfig();
                /*0x2bf75f4*/ bool get_NetworkSecurityConfigDebugOverridesEnabled();
                /*0x2bf75fc*/ void set_NetworkSecurityConfigDebugOverridesEnabled(bool value);
                /*0x2bf7604*/ bool get_DeleteDuplicateGsonLibrary();
                /*0x2bf760c*/ bool get_RemoveEmbeddedFirebaseComponentsFromXcodeProject();
                /*0x2bf7614*/ bool get_DeleteDuplicateInstallReferrerLibrary();
                /*0x2bf761c*/ bool get_DoPostProcessAttLocalization();
                /*0x2bf7624*/ EA.Unity.StarlightWrapper.LocalizedTextSet get_LocalizedUserTrackingUsageDescriptions();
                /*0x2bf762c*/ string get_PhotoLibraryUsageDescription();
                /*0x2bf7634*/ EA.Unity.StarlightWrapper.LocalizedTextSet get_LocalizedPhotoLibraryUsageDescriptions();
                /*0x2bf763c*/ string get_CameraUsageDescription();
                /*0x2bf7644*/ EA.Unity.StarlightWrapper.LocalizedTextSet get_LocalizedCameraUsageDescriptions();
                /*0x2bf764c*/ bool get_EnableHardwareAccelerationForHelpshiftActivity();
                /*0x2bf7654*/ UnityEngine.Texture2D get_AndroidNotificationIcon();
                /*0x2bf765c*/ UnityEngine.Texture2D get_AndroidLargeNotificationIcon();
            }

            class ConfigData
            {
                /*0x10*/ System.Collections.Generic.List<EA.Unity.StarlightWrapper.ConfigData.ConfigInfo> configs;

                /*0x2bf7e64*/ ConfigData();
                /*0x2bf7884*/ string GetConfig(string configKey);
                /*0x2bf7aac*/ string ToString();

                struct ConfigInfo
                {
                    /*0x10*/ System.Collections.Generic.List<string> configKeys;
                    /*0x18*/ UnityEngine.TextAsset androidConfig;
                    /*0x20*/ UnityEngine.TextAsset iosConfig;

                    /*0x2bf7990*/ bool IsForKey(string configKey, bool singleConfig);
                    /*0x2bf7a24*/ string get_Config();
                    /*0x2bf7bf0*/ string ToString();
                }
            }

            class Constants
            {
                static /*0x0*/ System.Collections.Generic.List<EA.Unity.StarlightWrapper.LocalizedText> DefaultLocalizedUserTrackingUsageDescriptions;

                static /*0x2bf7e6c*/ Constants();
            }

            class DateTimeHelpers
            {
                static /*0x0*/ System.DateTime epochTimeZero;

                static /*0x2bf8be8*/ DateTimeHelpers();
                static /*0x2bf8afc*/ uint GetEpochTimeNow();
            }

            enum WrapperInitializationStates
            {
                NotStarted = 0,
                Started = 1,
                Initialized = 2,
                Disposed = 3,
            }

            enum AdReviewConfigs
            {
                Glu = 0,
                Ea = 1,
            }

            enum LanguageCodes
            {
                ar = 0,
                cs = 1,
                da = 2,
                de = 3,
                el = 4,
                en = 5,
                esCO = 6,
                esMX = 7,
                es = 8,
                fi = 9,
                frCA = 10,
                fr = 11,
                he = 12,
                hr = 13,
                hu = 14,
                id = 15,
                it = 16,
                ja = 17,
                ko = 18,
                ms = 19,
                nb = 20,
                nl = 21,
                pl = 22,
                ptBR = 23,
                pt = 24,
                ro = 25,
                ru = 26,
                sk = 27,
                sv = 28,
                th = 29,
                tr = 30,
                uk = 31,
                vi = 32,
                zhHans = 33,
                zhHant = 34,
            }

            class InitData
            {
                /*0x2bf8cc0*/ InitData();
                /*0x2bf8c50*/ string get_ExceptionMessage();
            }

            interface IWrapperBase
            {
                /*0x1f2ffc8*/ Csdk.Revenue.RevSDKComponent get_StarlightComponentType();
                /*0x1f2ffc8*/ EA.Unity.StarlightWrapper.WrapperInitializationStates get_InitializationState();
                /*0x1f2fe14*/ bool get_IsEnabled();
                /*0x1f30ebc*/ void add_IsEnabledChecks(System.Func<bool> value);
                /*0x1f30ebc*/ void remove_IsEnabledChecks(System.Func<bool> value);
                /*0x1f302cc*/ string GetConfig(string configKey);
                /*0x1f30ebc*/ void UpdateRuntimeConfig(System.Collections.Generic.Dictionary<string, object> runtimeConfig);
                /*0x1f309e4*/ void Initialize();
                /*0x1f309e4*/ void Dispose();
                /*0x1f30ebc*/ void SetupWrapperInterdependencies(System.Collections.Generic.Dictionary<Csdk.Revenue.RevSDKComponent, EA.Unity.StarlightWrapper.IWrapperBase> wrappers);
            }

            interface IWrapper<TStarlightComponent> : EA.Unity.StarlightWrapper.IWrapperBase
            {
                /*0x1ffc854*/ TStarlightComponent get_StarlightComponent();
            }

            class LocalizedTextSet
            {
                /*0x10*/ System.Collections.Generic.List<EA.Unity.StarlightWrapper.LocalizedText> localizedTextList;

                /*0x2bf77fc*/ LocalizedTextSet();
                /*0x2bf776c*/ LocalizedTextSet(System.Collections.Generic.List<EA.Unity.StarlightWrapper.LocalizedText> localizedTextList);
            }

            class LocalizedText
            {
                /*0x10*/ EA.Unity.StarlightWrapper.LanguageCodes languageCode;
                /*0x18*/ string text;

                /*0x2bf8ac4*/ LocalizedText(EA.Unity.StarlightWrapper.LanguageCodes languageCode, string text);
            }

            class MulticastDelegateChecker : UnityEngine.MonoBehaviour
            {
                static /*0x2bf8cc8*/ bool CheckAllTrue(string valueToPass, System.Predicate<string> predicatesToCheck);
                static /*0x2bf8e30*/ bool CheckAllTrue(System.Func<bool> functionsToCheck);
                /*0x2bf8f80*/ MulticastDelegateChecker();
            }

            class StarlightWrapperException : System.Exception
            {
                /*0x2bf8f88*/ StarlightWrapperException();
                /*0x2bf8fe0*/ StarlightWrapperException(string message);
                /*0x2bf9048*/ StarlightWrapperException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            class StarlightWrapperInitData : EA.Unity.StarlightWrapper.InitData
            {
                /*0x10*/ UnityEngine.ILogger logger;
                /*0x18*/ string <ConfigKey>k__BackingField;
                /*0x20*/ string <UserId>k__BackingField;
                /*0x28*/ System.Func<bool> <IsEnabledChecks>k__BackingField;

                /*0x2bf917c*/ StarlightWrapperInitData();
                /*0x2bf90c8*/ string get_ConfigKey();
                /*0x2bf90d0*/ string get_UserId();
                /*0x2bf90d8*/ UnityEngine.ILogger get_Logger();
                /*0x2bf916c*/ void set_Logger(UnityEngine.ILogger value);
                /*0x2bf9174*/ System.Func<bool> get_IsEnabledChecks();
            }

            class Wrapper<TInitData, TWrapper, TStarlightComponent, TConfigData> : EA.Unity.StarlightWrapper.IWrapper<TStarlightComponent>, EA.Unity.StarlightWrapper.IWrapperBase
            {
                /*0x0*/ TConfigData <ConfigData>k__BackingField;
                /*0x0*/ TInitData <InitData>k__BackingField;
                /*0x0*/ System.Collections.Generic.Dictionary<string, string> <ConfigReplacements>k__BackingField;
                /*0x0*/ System.Collections.Generic.Dictionary<string, object> <RuntimeConfigOverrides>k__BackingField;
                /*0x0*/ UnityEngine.ILogger <Logger>k__BackingField;
                /*0x0*/ EA.Unity.StarlightWrapper.WrapperInitializationStates <InitializationState>k__BackingField;
                /*0x0*/ System.Func<bool> IsEnabledChecks;

                /*0x1f309e4*/ Wrapper();
                /*0x1ffc854*/ TConfigData get_ConfigData();
                /*0x1ffc854*/ void set_ConfigData(TConfigData value);
                /*0x1f2fe14*/ bool get_CanUseRevSdkInstance();
                /*0x1f30214*/ string get_NotInitializedException();
                /*0x1ffc854*/ TInitData get_InitData();
                /*0x1ffc854*/ void set_InitData(TInitData value);
                /*0x1f30214*/ System.Collections.Generic.Dictionary<string, string> get_ConfigReplacements();
                /*0x1f30214*/ System.Collections.Generic.Dictionary<string, object> get_RuntimeConfigOverrides();
                /*0x1ffc854*/ TStarlightComponent get_InternalStarlightComponent();
                /*0x1f30214*/ UnityEngine.ILogger get_Logger();
                /*0x1f30ebc*/ void set_Logger(UnityEngine.ILogger value);
                /*0x1f2fe14*/ bool get_IsEnabledAndInitialized();
                /*0x1f309e4*/ void EnsureInitialized();
                /*0x1f2ffc8*/ EA.Unity.StarlightWrapper.WrapperInitializationStates get_InitializationState();
                /*0x1f30b78*/ void set_InitializationState(EA.Unity.StarlightWrapper.WrapperInitializationStates value);
                /*0x1f2ffc8*/ Csdk.Revenue.RevSDKComponent get_StarlightComponentType();
                /*0x1ffc854*/ TStarlightComponent get_StarlightComponent();
                /*0x1f30ebc*/ void add_IsEnabledChecks(System.Func<bool> value);
                /*0x1f30ebc*/ void remove_IsEnabledChecks(System.Func<bool> value);
                /*0x1f2fe14*/ bool get_IsEnabled();
                /*0x1f302cc*/ string GetConfig(string configKey);
                /*0x1f30ebc*/ void UpdateRuntimeConfig(System.Collections.Generic.Dictionary<string, object> runtimeConfig);
                /*0x1f309e4*/ void Initialize();
                /*0x1f30ebc*/ void SetupWrapperInterdependencies(System.Collections.Generic.Dictionary<Csdk.Revenue.RevSDKComponent, EA.Unity.StarlightWrapper.IWrapperBase> wrappers);
                /*0x1f309e4*/ void Finalize();
                /*0x1f309e4*/ void Dispose();
                /*0x1ffc854*/ void InitializeInternal(TStarlightComponent starlightComponent, System.Action onComplete);
                /*0x1f30ebc*/ void SetupInterdependencies(System.Collections.Generic.Dictionary<Csdk.Revenue.RevSDKComponent, EA.Unity.StarlightWrapper.IWrapperBase> wrappers);
                /*0x1f30ebc*/ void UpdateRuntimeConfigInternal(System.Collections.Generic.Dictionary<string, object> runtimeConfig);
                /*0x1ffc854*/ void DoDispose(TStarlightComponent starlightComponentInternal);
                /*0x1ffc854*/ void SetData(TConfigData configData, TInitData initData);
                /*0x1ffc854*/ TStarlightComponent get_DefaultStarlightComponent();
                /*0x1f309e4*/ void <Initialize>b__46_0();
            }

            class WrapperInitData<TWrapper, TStarlightComponent> : EA.Unity.StarlightWrapper.InitData
            {
                /*0x0*/ TWrapper <ExistingWrapper>k__BackingField;
                /*0x0*/ UnityEngine.ILogger <Logger>k__BackingField;
                /*0x0*/ System.Func<bool> <IsEnabledChecks>k__BackingField;

                /*0x1f309e4*/ WrapperInitData();
                /*0x1ffc854*/ TWrapper get_ExistingWrapper();
                /*0x1ffc854*/ void set_ExistingWrapper(TWrapper value);
                /*0x1f30214*/ UnityEngine.ILogger get_Logger();
                /*0x1f30ebc*/ void set_Logger(UnityEngine.ILogger value);
                /*0x1f30214*/ System.Func<bool> get_IsEnabledChecks();
            }

            namespace Editor
            {
                class EditorMockupPopup : UnityEngine.MonoBehaviour
                {
                    /*0x2bf9184*/ EditorMockupPopup();
                }
            }
        }
    }
}
