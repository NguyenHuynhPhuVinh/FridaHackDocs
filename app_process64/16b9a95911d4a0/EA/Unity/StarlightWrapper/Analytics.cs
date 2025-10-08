class <Module>
{
}

namespace EA
{
    namespace Unity
    {
        namespace StarlightWrapper
        {
            namespace Analytics
            {
                class Analytics : EA.Unity.StarlightWrapper.Wrapper<EA.Unity.StarlightWrapper.Analytics.AnalyticsInitData, EA.Unity.StarlightWrapper.Analytics.Analytics, Glu.Plugins.GluAnalytics.IGluAnalytics, EA.Unity.StarlightWrapper.ConfigData>, EA.Unity.StarlightWrapper.Analytics.IAnalytics, EA.Unity.StarlightWrapper.IWrapper<Glu.Plugins.GluAnalytics.IGluAnalytics>, EA.Unity.StarlightWrapper.IWrapperBase
                {
                    static /*0x0*/ System.Collections.Generic.Dictionary<string, object> extraData;
                    static /*0x8*/ System.Collections.Generic.Dictionary<string, EA.Unity.StarlightWrapper.Analytics.PerformanceAnalytic> activePerformanceAnalytics;
                    static /*0x10*/ System.Action<string, string, Glu.Plugins.GluAnalytics.PerfType, System.String[]> startPerfSampleInstance;
                    static /*0x18*/ System.Action<string, string, bool, System.String[]> endPerfSampleInstance;
                    static /*0x20*/ System.Action setExtraDataInstance;
                    static /*0x28*/ Glu.Plugins.GluAnalytics.GeoLocation nullGeoLocation;
                    /*0x48*/ System.Collections.Generic.Dictionary<string, System.Action<string, System.Collections.Generic.IDictionary<string, object>>> extraAnalyticsLoggers;
                    /*0x50*/ System.Collections.Generic.Dictionary<string, object> setCustomPropertyDictionary;
                    /*0x58*/ System.Action<System.Collections.Generic.IDictionary<string, object>> OnAddCustomPersistentData;

                    static /*0x2bf527c*/ Analytics();
                    static /*0x2bf2ccc*/ void SetExtraData(System.Action<System.Collections.Generic.IDictionary<string, object>> onAddCustomData);
                    /*0x2bf51e0*/ Analytics();
                    /*0x2bf20f4*/ System.Collections.Generic.Dictionary<string, object> get_SetCustomPropertyDictionary();
                    /*0x2bf2178*/ Csdk.Revenue.RevSDKComponent get_StarlightComponentType();
                    /*0x2bf2180*/ void add_OnAddCustomPersistentData(System.Action<System.Collections.Generic.IDictionary<string, object>> value);
                    /*0x2bf2230*/ void remove_OnAddCustomPersistentData(System.Action<System.Collections.Generic.IDictionary<string, object>> value);
                    /*0x2bf22e0*/ string get_AnalyticsDeviceIdentifier();
                    /*0x2bf23e8*/ bool get_UsageSharingEnabled();
                    /*0x2bf245c*/ void set_UsageSharingEnabled(bool value);
                    /*0x2bf257c*/ bool get_InternalTargetedAdsEnabled();
                    /*0x2bf25f0*/ void set_InternalTargetedAdsEnabled(bool value);
                    /*0x2bf2668*/ Glu.Plugins.GluAnalytics.GeoLocation get_GeoLocation();
                    /*0x2bf2760*/ void RegisterExtraAnalyticsLogger(string analyticsLoggerId, System.Action<string, System.Collections.Generic.IDictionary<string, object>> onLogAnalytic);
                    /*0x2bf27c8*/ void UnregisterExtraAnalyticsLogger(string analyticsLoggerId);
                    /*0x2bf2820*/ void LogGluAnalyticsEvent(string n, string st1, string st2, string st3, System.Nullable<long> v, System.Nullable<long> l, System.Action<System.Collections.Generic.IDictionary<string, object>> onAddCustomData, string[] extraLoggers);
                    /*0x2bf24d4*/ void SetCustomProperty(string key, object value);
                    /*0x2bf3234*/ void SetCustomProperties(System.Collections.Generic.IDictionary<string, object> properties);
                    /*0x1ffc854*/ T GetCustomProperty<T>(string key);
                    /*0x2bf333c*/ System.Collections.Generic.IDictionary<string, object> GetCustomProperties();
                    /*0x2bf3434*/ void InitializeInternal(Glu.Plugins.GluAnalytics.IGluAnalytics gluAnalytics, System.Action onComplete);
                    /*0x2bf4a9c*/ void DoDispose(Glu.Plugins.GluAnalytics.IGluAnalytics gluAnalytics);
                    /*0x2bf2e1c*/ void LogToExtraLoggers(string name, System.Collections.Generic.IDictionary<string, object> data, System.Collections.Generic.IReadOnlyList<string> extraLoggers);
                    /*0x2bf3ac4*/ void SendQueuedFinishedPerformanceAnalytics();
                    /*0x2bf4d2c*/ void StartPerformanceSampleInstance(string placement, string placementKey, Glu.Plugins.GluAnalytics.PerfType perfType, string[] extraLoggers);
                    /*0x2bf4eb0*/ void EndPerformanceSampleInstance(string placement, string placementKey, bool logToDebugLogger, string[] extraLoggers);
                    /*0x2bf5164*/ void SetExtraDataInstance();
                }

                class AnalyticsInitData : EA.Unity.StarlightWrapper.WrapperInitData<EA.Unity.StarlightWrapper.Analytics.Analytics, Glu.Plugins.GluAnalytics.IGluAnalytics>
                {
                    /*0x28*/ System.Action<System.Collections.Generic.IDictionary<string, object>> <OnAddCustomData>k__BackingField;
                    /*0x30*/ System.Collections.Generic.Dictionary<string, System.Action<string, System.Collections.Generic.IDictionary<string, object>>> <ExtraAnalyticsLoggers>k__BackingField;

                    /*0x2bf53d4*/ AnalyticsInitData();
                    /*0x2bf53c4*/ System.Action<System.Collections.Generic.IDictionary<string, object>> get_OnAddCustomData();
                    /*0x2bf53cc*/ System.Collections.Generic.Dictionary<string, System.Action<string, System.Collections.Generic.IDictionary<string, object>>> get_ExtraAnalyticsLoggers();
                }

                interface IAnalytics : EA.Unity.StarlightWrapper.IWrapper<Glu.Plugins.GluAnalytics.IGluAnalytics>, EA.Unity.StarlightWrapper.IWrapperBase
                {
                    /*0x1f30214*/ string get_AnalyticsDeviceIdentifier();
                    /*0x1f2fe14*/ bool get_UsageSharingEnabled();
                    /*0x1f30a84*/ void set_UsageSharingEnabled(bool value);
                    /*0x1f2fe14*/ bool get_InternalTargetedAdsEnabled();
                    /*0x1f30a84*/ void set_InternalTargetedAdsEnabled(bool value);
                    /*0x1f30214*/ Glu.Plugins.GluAnalytics.GeoLocation get_GeoLocation();
                    /*0x1f30ff0*/ void RegisterExtraAnalyticsLogger(string analyticsLoggerId, System.Action<string, System.Collections.Generic.IDictionary<string, object>> onLogAnalytic);
                    /*0x1f30ebc*/ void UnregisterExtraAnalyticsLogger(string analyticsLoggerId);
                    void LogGluAnalyticsEvent(string n, string st1, string st2, string st3, System.Nullable<long> v, System.Nullable<long> l, System.Action<System.Collections.Generic.IDictionary<string, object>> onAddCustomData, string[] extraLoggers);
                }

                class PerformanceAnalytic
                {
                    /*0x10*/ bool <SentGluAnalyticsStartPerfSample>k__BackingField;
                    /*0x11*/ bool <Ended>k__BackingField;
                    /*0x12*/ bool <LogToDebugLogger>k__BackingField;
                    /*0x18*/ string[] <ExtraLoggersStart>k__BackingField;
                    /*0x20*/ string[] <ExtraLoggersEnd>k__BackingField;
                    /*0x28*/ System.Collections.Generic.IDictionary<string, object> <StartExtraData>k__BackingField;
                    /*0x30*/ System.Collections.Generic.IDictionary<string, object> <EndExtraData>k__BackingField;
                    /*0x38*/ Glu.Plugins.GluAnalytics.PerfType <PerfType>k__BackingField;

                    /*0x2bf541c*/ bool get_SentGluAnalyticsStartPerfSample();
                    /*0x2bf5424*/ void set_SentGluAnalyticsStartPerfSample(bool value);
                    /*0x2bf542c*/ bool get_Ended();
                    /*0x2bf5434*/ bool get_LogToDebugLogger();
                    /*0x2bf543c*/ string[] get_ExtraLoggersStart();
                    /*0x2bf5444*/ string[] get_ExtraLoggersEnd();
                    /*0x2bf544c*/ System.Collections.Generic.IDictionary<string, object> get_StartExtraData();
                    /*0x2bf5454*/ System.Collections.Generic.IDictionary<string, object> get_EndExtraData();
                    /*0x2bf545c*/ Glu.Plugins.GluAnalytics.PerfType get_PerfType();
                }
            }
        }
    }
}
