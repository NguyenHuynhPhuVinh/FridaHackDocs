class <Module>
{
}

namespace Csdk
{
    namespace Revenue
    {
        enum RevSDKComponent
        {
            GluAds = 0,
            GluAnalytics = 1,
            GluAppTracking = 2,
            GluCentralServices = 3,
            GluIAP = 4,
            GluMarketing = 5,
            GluCustomerSupport = 6,
            StarlightMetrics = 7,
        }

        enum PrivacySetting
        {
            internalTargetedAds = 0,
            usageSharing = 1,
        }

        class RevSDK : UnityEngine.MonoBehaviour, System.IDisposable
        {
            static /*0x0*/ Csdk.Revenue.RevSDK sInstance;
            /*0x20*/ Csdk.GluAds.IAdvertising <GluAds>k__BackingField;
            /*0x28*/ Glu.Plugins.GluAnalytics.IGluAnalytics <GluAnalytics>k__BackingField;
            /*0x30*/ Csdk.GluAppTracking.IGluAppTracking <GluAppTracking>k__BackingField;
            /*0x38*/ Csdk.GluCentralServices.IGluCentralServices <GluCentralServices>k__BackingField;
            /*0x40*/ Csdk.GluCustomerSupport.ICustomerSupport <GluCustomerSupport>k__BackingField;

            static /*0x364fed0*/ Csdk.Revenue.RevSDK get_Instance();
            /*0x3650fc8*/ RevSDK();
            /*0x3650060*/ Csdk.GluAds.IAdvertising get_GluAds();
            /*0x3650068*/ void set_GluAds(Csdk.GluAds.IAdvertising value);
            /*0x3650070*/ Glu.Plugins.GluAnalytics.IGluAnalytics get_GluAnalytics();
            /*0x3650078*/ void set_GluAnalytics(Glu.Plugins.GluAnalytics.IGluAnalytics value);
            /*0x3650080*/ Csdk.GluAppTracking.IGluAppTracking get_GluAppTracking();
            /*0x3650088*/ void set_GluAppTracking(Csdk.GluAppTracking.IGluAppTracking value);
            /*0x3650090*/ Csdk.GluCentralServices.IGluCentralServices get_GluCentralServices();
            /*0x3650098*/ void set_GluCentralServices(Csdk.GluCentralServices.IGluCentralServices value);
            /*0x36500a0*/ Csdk.GluCustomerSupport.ICustomerSupport get_GluCustomerSupport();
            /*0x36500a8*/ void set_GluCustomerSupport(Csdk.GluCustomerSupport.ICustomerSupport value);
            /*0x36500b0*/ void Initialize(System.Collections.Generic.IDictionary<Csdk.Revenue.RevSDKComponent, string> jsonConfigs, System.Collections.Generic.IDictionary<string, object> runtimeConfig);
            /*0x36504fc*/ void SetUserID(string userID);
            /*0x365062c*/ void SetPrivacyStatus(Csdk.Revenue.PrivacySetting type, bool state);
            /*0x3650998*/ bool GetPrivacyStatus(Csdk.Revenue.PrivacySetting type);
            /*0x36507ec*/ void SetCustomProperties(System.Collections.Generic.IDictionary<string, object> properties);
            /*0x3650be0*/ System.Collections.Generic.IDictionary<string, object> GetCustomProperties();
            /*0x3650c90*/ void Dispose();
            /*0x3650d34*/ void OnDestroy();
        }
    }
}
