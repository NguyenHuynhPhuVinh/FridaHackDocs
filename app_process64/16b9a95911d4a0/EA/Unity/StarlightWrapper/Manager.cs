class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x2bfbd40*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x2bfbe30*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace EA
{
    namespace Unity
    {
        namespace StarlightWrapper
        {
            namespace Manager
            {
                interface IStarlightWrapper
                {
                    /*0x1f30ff0*/ void Initialize(EA.Unity.StarlightWrapper.Manager.StarlightWrapperConfig starlightWrapperConfig, EA.Unity.StarlightWrapper.Manager.StarlightWrapperInit starlightWrapperInit);
                    /*0x1f30ebc*/ void SetUserId(string userId);
                    /*0x1f309e4*/ void Dispose();
                    /*0x1f2fe14*/ bool get_IsEnabled();
                    /*0x1f30ebc*/ void add_IsEnabledChecks(System.Func<bool> value);
                    /*0x1f30ebc*/ void remove_IsEnabledChecks(System.Func<bool> value);
                    /*0x1f30214*/ EA.Unity.StarlightWrapper.Ads.IAds get_Ads();
                    /*0x1f30214*/ EA.Unity.StarlightWrapper.Analytics.IAnalytics get_Analytics();
                    /*0x1f30214*/ EA.Unity.StarlightWrapper.AppTracking.IAppTracking get_AppTracking();
                    /*0x1f30214*/ EA.Unity.StarlightWrapper.CentralServices.ICentralServices get_CentralServices();
                    /*0x1f30214*/ EA.Unity.StarlightWrapper.CustomerSupport.ICustomerSupport get_CustomerSupport();
                }

                class StarlightWrapper : EA.Unity.StarlightWrapper.Manager.IStarlightWrapper
                {
                    static /*0x0*/ EA.Unity.StarlightWrapper.Manager.StarlightWrapper instance;
                    /*0x10*/ EA.Unity.StarlightWrapper.Manager.StarlightWrapperConfig StarlightWrapperConfig;
                    /*0x18*/ EA.Unity.StarlightWrapper.Manager.StarlightWrapperInit StarlightWrapperInit;
                    /*0x20*/ System.Collections.Generic.List<EA.Unity.StarlightWrapper.IWrapperBase> Wrappers;
                    /*0x28*/ System.Func<bool> IsEnabledChecks;
                    /*0x30*/ EA.Unity.StarlightWrapper.Ads.IAds <Ads>k__BackingField;
                    /*0x38*/ EA.Unity.StarlightWrapper.Analytics.IAnalytics <Analytics>k__BackingField;
                    /*0x40*/ EA.Unity.StarlightWrapper.AppTracking.IAppTracking <AppTracking>k__BackingField;
                    /*0x48*/ EA.Unity.StarlightWrapper.CentralServices.ICentralServices <CentralServices>k__BackingField;
                    /*0x50*/ EA.Unity.StarlightWrapper.CustomerSupport.ICustomerSupport <CustomerSupport>k__BackingField;

                    static /*0x2bfcc6c*/ EA.Unity.StarlightWrapper.Manager.IStarlightWrapper CreateAndInitializeInstance(EA.Unity.StarlightWrapper.Manager.StarlightWrapperConfig starlightWrapperConfig, EA.Unity.StarlightWrapper.Manager.StarlightWrapperInit starlightWrapperInit);
                    /*0x2bfbfa4*/ StarlightWrapper();
                    /*0x2bfbe38*/ void add_IsEnabledChecks(System.Func<bool> value);
                    /*0x2bfbee8*/ void remove_IsEnabledChecks(System.Func<bool> value);
                    /*0x2bfbf98*/ bool get_IsEnabled();
                    /*0x2bfc09c*/ void Initialize(EA.Unity.StarlightWrapper.Manager.StarlightWrapperConfig starlightWrapperConfig, EA.Unity.StarlightWrapper.Manager.StarlightWrapperInit starlightWrapperInit);
                    /*0x2bfcdc0*/ void SetUserId(string userId);
                    /*0x2bfcef8*/ void Dispose();
                    /*0x2bfc1a4*/ void CreateWrappers();
                    /*0x2bfc204*/ void SetupWrapperInterdependencies();
                    /*0x2bfc618*/ void InitializeStarlight();
                    /*0x2bfca58*/ void InitializeWrappers();
                    /*0x2bfddec*/ void Finalize();
                    /*0x2bfde70*/ EA.Unity.StarlightWrapper.Ads.IAds get_Ads();
                    /*0x2bfde78*/ void set_Ads(EA.Unity.StarlightWrapper.Ads.IAds value);
                    /*0x2bfde80*/ EA.Unity.StarlightWrapper.Analytics.IAnalytics get_Analytics();
                    /*0x2bfde88*/ void set_Analytics(EA.Unity.StarlightWrapper.Analytics.IAnalytics value);
                    /*0x2bfde90*/ EA.Unity.StarlightWrapper.AppTracking.IAppTracking get_AppTracking();
                    /*0x2bfde98*/ void set_AppTracking(EA.Unity.StarlightWrapper.AppTracking.IAppTracking value);
                    /*0x2bfdea0*/ EA.Unity.StarlightWrapper.CentralServices.ICentralServices get_CentralServices();
                    /*0x2bfdea8*/ void set_CentralServices(EA.Unity.StarlightWrapper.CentralServices.ICentralServices value);
                    /*0x2bfdeb0*/ EA.Unity.StarlightWrapper.CustomerSupport.ICustomerSupport get_CustomerSupport();
                    /*0x2bfdeb8*/ void set_CustomerSupport(EA.Unity.StarlightWrapper.CustomerSupport.ICustomerSupport value);
                    /*0x2bfd1b8*/ void DisposeAccessors();
                }

                class StarlightWrapperConfig : UnityEngine.ScriptableObject
                {
                    /*0x18*/ EA.Unity.StarlightWrapper.ConfigData adsConfigData;
                    /*0x20*/ EA.Unity.StarlightWrapper.Ads.Data.AdsDataContainer defaultAdsData;
                    /*0x28*/ EA.Unity.StarlightWrapper.Ads.Data.IgnoredErrors defaultIgnoredErrors;
                    /*0x30*/ EA.Unity.StarlightWrapper.ConfigData analyticsConfigData;
                    /*0x38*/ EA.Unity.StarlightWrapper.ConfigData appTrackingConfigData;
                    /*0x40*/ EA.Unity.StarlightWrapper.ConfigData centralServicesConfigData;
                    /*0x48*/ EA.Unity.StarlightWrapper.CustomerSupport.Data.CustomerSupportConfigData customerSupportConfigData;

                    /*0x2bfdf98*/ StarlightWrapperConfig();
                    /*0x2bfdec0*/ EA.Unity.StarlightWrapper.ConfigData get_AdsConfigData();
                    /*0x2bfdec8*/ EA.Unity.StarlightWrapper.Ads.Data.AdsDataContainer get_DefaultAdsData();
                    /*0x2bfdf70*/ EA.Unity.StarlightWrapper.Ads.Data.IgnoredErrors get_DefaultIgnoredErrors();
                    /*0x2bfdf78*/ EA.Unity.StarlightWrapper.ConfigData get_AnalyticsConfigData();
                    /*0x2bfdf80*/ EA.Unity.StarlightWrapper.ConfigData get_AppTrackingConfigData();
                    /*0x2bfdf88*/ EA.Unity.StarlightWrapper.ConfigData get_CentralServicesConfigData();
                    /*0x2bfdf90*/ EA.Unity.StarlightWrapper.CustomerSupport.Data.CustomerSupportConfigData get_CustomerSupportConfigData();
                }

                class StarlightWrapperInit
                {
                    /*0x10*/ EA.Unity.StarlightWrapper.StarlightWrapperInitData <StarlightWrapperInitData>k__BackingField;
                    /*0x18*/ EA.Unity.StarlightWrapper.Ads.Data.AdsInitData <AdsInitData>k__BackingField;
                    /*0x20*/ EA.Unity.StarlightWrapper.Analytics.AnalyticsInitData <AnalyticsInitData>k__BackingField;
                    /*0x28*/ EA.Unity.StarlightWrapper.AppTracking.AppTrackingInitData <AppTrackingInitData>k__BackingField;
                    /*0x30*/ EA.Unity.StarlightWrapper.CentralServices.CentralServicesInitData <CentralServicesInitData>k__BackingField;
                    /*0x38*/ EA.Unity.StarlightWrapper.CustomerSupport.CustomerSupportInitData <CustomerSupportInitData>k__BackingField;

                    /*0x2bfe064*/ StarlightWrapperInit();
                    /*0x2bfe004*/ EA.Unity.StarlightWrapper.StarlightWrapperInitData get_StarlightWrapperInitData();
                    /*0x2bfe00c*/ void set_StarlightWrapperInitData(EA.Unity.StarlightWrapper.StarlightWrapperInitData value);
                    /*0x2bfe014*/ EA.Unity.StarlightWrapper.Ads.Data.AdsInitData get_AdsInitData();
                    /*0x2bfe01c*/ void set_AdsInitData(EA.Unity.StarlightWrapper.Ads.Data.AdsInitData value);
                    /*0x2bfe024*/ EA.Unity.StarlightWrapper.Analytics.AnalyticsInitData get_AnalyticsInitData();
                    /*0x2bfe02c*/ void set_AnalyticsInitData(EA.Unity.StarlightWrapper.Analytics.AnalyticsInitData value);
                    /*0x2bfe034*/ EA.Unity.StarlightWrapper.AppTracking.AppTrackingInitData get_AppTrackingInitData();
                    /*0x2bfe03c*/ void set_AppTrackingInitData(EA.Unity.StarlightWrapper.AppTracking.AppTrackingInitData value);
                    /*0x2bfe044*/ EA.Unity.StarlightWrapper.CentralServices.CentralServicesInitData get_CentralServicesInitData();
                    /*0x2bfe04c*/ void set_CentralServicesInitData(EA.Unity.StarlightWrapper.CentralServices.CentralServicesInitData value);
                    /*0x2bfe054*/ EA.Unity.StarlightWrapper.CustomerSupport.CustomerSupportInitData get_CustomerSupportInitData();
                    /*0x2bfe05c*/ void set_CustomerSupportInitData(EA.Unity.StarlightWrapper.CustomerSupport.CustomerSupportInitData value);
                }

                class WrapperFactory
                {
                    static /*0x2bfd210*/ void CreateWrapper(Csdk.Revenue.RevSDKComponent componentType, EA.Unity.StarlightWrapper.Manager.StarlightWrapper manager);
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 3ECBC78B90BD80DBBE33BBE3F4251EBD1C27360F4CE7C0E00E9EBB91FB274AEF;
    static /*0x2a0*/ <PrivateImplementationDetails> 65BC5914CFB99E2B8698338CF5F0DC28601536CA0385D8C4CE2630317A8340A3;

    struct __StaticArrayInitTypeSize=339
    {
    }

    struct __StaticArrayInitTypeSize=672
    {
    }
}
