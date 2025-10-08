class <Module>
{
}

namespace EA
{
    namespace Unity
    {
        namespace StarlightWrapper
        {
            namespace AppTracking
            {
                class AppTracking : EA.Unity.StarlightWrapper.Wrapper<EA.Unity.StarlightWrapper.AppTracking.AppTrackingInitData, EA.Unity.StarlightWrapper.AppTracking.AppTracking, Csdk.GluAppTracking.IGluAppTracking, EA.Unity.StarlightWrapper.ConfigData>, EA.Unity.StarlightWrapper.AppTracking.IAppTracking, EA.Unity.StarlightWrapper.IWrapper<Csdk.GluAppTracking.IGluAppTracking>, EA.Unity.StarlightWrapper.IWrapperBase
                {
                    /*0x48*/ System.Collections.Generic.Dictionary<string, object> dummyAnalyticsLogData;
                    /*0x50*/ EA.Unity.StarlightWrapper.Analytics.IAnalytics analytics;

                    /*0x2bf5bf8*/ AppTracking();
                    /*0x2bf5464*/ Csdk.Revenue.RevSDKComponent get_StarlightComponentType();
                    /*0x2bf546c*/ void LogEvent(string eventName);
                    /*0x2bf5570*/ void LogEvent(string eventName, System.Collections.Generic.IDictionary<string, object> extra);
                    /*0x2bf5780*/ void TrackRevenue(string currency, decimal price, System.Collections.Generic.IDictionary<string, object> extra);
                    /*0x2bf58ac*/ void SetupInterdependencies(System.Collections.Generic.Dictionary<Csdk.Revenue.RevSDKComponent, EA.Unity.StarlightWrapper.IWrapperBase> wrappers);
                    /*0x2bf5964*/ void InitializeInternal(Csdk.GluAppTracking.IGluAppTracking appTracking, System.Action onComplete);
                    /*0x2bf5b08*/ void DoDispose(Csdk.GluAppTracking.IGluAppTracking appTracking);
                    /*0x2bf5bf0*/ void LogAnalyticsEvent(string s, System.Collections.Generic.IDictionary<string, object> _);
                }

                class AppTrackingInitData : EA.Unity.StarlightWrapper.WrapperInitData<EA.Unity.StarlightWrapper.AppTracking.AppTracking, Csdk.GluAppTracking.IGluAppTracking>
                {
                    /*0x28*/ bool <RegisterExtraAnalyticsLogger>k__BackingField;

                    /*0x2bf5c48*/ AppTrackingInitData();
                    /*0x2bf5c40*/ bool get_RegisterExtraAnalyticsLogger();
                }

                interface IAppTracking : EA.Unity.StarlightWrapper.IWrapper<Csdk.GluAppTracking.IGluAppTracking>, EA.Unity.StarlightWrapper.IWrapperBase
                {
                    /*0x1f30ebc*/ void LogEvent(string eventName);
                    void TrackRevenue(string currency, decimal price, System.Collections.Generic.IDictionary<string, object> extra);
                }
            }
        }
    }
}
