class <Module>
{
}

class Ua2CoreInitializeCallback : Unity.Services.Core.Internal.IInitializablePackage
{
    static /*0xf5cb04*/ void Register();
    /*0xf5cc9c*/ Ua2CoreInitializeCallback();
    /*0xf5cca4*/ System.Threading.Tasks.Task Initialize(Unity.Services.Core.Internal.CoreRegistry registry);

    struct <Initialize>d__1 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
        /*0x30*/ Unity.Services.Core.Internal.CoreRegistry registry;
        /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

        /*0xf5cd6c*/ void MoveNext();
        /*0xf5daa0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

namespace Unity
{
    namespace Services
    {
        namespace Analytics
        {
            class AnalyticsService
            {
                static /*0x0*/ Unity.Services.Analytics.AnalyticsServiceInstance internalInstance;

                static /*0xf5db04*/ AnalyticsService();
                static /*0xf5daac*/ Unity.Services.Analytics.IAnalyticsService get_Instance();
            }

            class AnalyticsServiceInstance : Unity.Services.Analytics.IAnalyticsService
            {
                static string k_CollectUrlPattern = "https://collect.analytics.unity3d.com/api/analytics/collect/v1/projects/{0}/environments/{1}";
                static string k_ForgetCallingId = "com.unity.services.analytics.Events.OptOut";
                /*0x10*/ Unity.Services.Analytics.Internal.IAnalyticsForgetter analyticsForgetter;
                /*0x18*/ Unity.Services.Authentication.Internal.IPlayerId <PlayerId>k__BackingField;
                /*0x20*/ Unity.Services.Core.Device.Internal.IInstallationId <InstallId>k__BackingField;
                /*0x28*/ Unity.Services.Core.Configuration.Internal.ICloudProjectId <CloudProjectIdProvider>k__BackingField;
                /*0x30*/ string <CustomAnalyticsId>k__BackingField;
                /*0x38*/ Unity.Services.Analytics.Internal.IBuffer dataBuffer;
                /*0x40*/ int m_BufferLengthAtLastGameRunning;
                /*0x48*/ Unity.Services.Analytics.Data.IDataGenerator dataGenerator;
                /*0x50*/ Unity.Services.Analytics.Internal.IDispatcher <dataDispatcher>k__BackingField;
                /*0x58*/ string m_CollectURL;
                /*0x60*/ Unity.Services.Analytics.Data.StdCommonParams m_CommonParams;
                /*0x68*/ string m_StartUpCallingId;
                /*0x70*/ Unity.Services.Analytics.Platform.IIDeviceIdentifiersInternal deviceIdentifiersInternal;
                /*0x78*/ bool <ServiceEnabled>k__BackingField;
                /*0x80*/ Unity.Services.Analytics.ICoreStatsHelper m_CoreStatsHelper;
                /*0x88*/ Unity.Services.Analytics.Internal.IConsentTracker ConsentTracker;
                /*0x90*/ string <SessionID>k__BackingField;
                /*0x98*/ Unity.Services.Analytics.TransactionCurrencyConverter converter;

                /*0xf5db78*/ AnalyticsServiceInstance();
                /*0xf5defc*/ System.Threading.Tasks.Task<System.Collections.Generic.List<string>> CheckForRequiredConsents();
                /*0xf5dfec*/ void ProvideOptInConsent(string identifier, bool consent);
                /*0xf5e790*/ void OptOut();
                /*0xf5e64c*/ void Revoke();
                /*0xf5e304*/ void RevokeWithForgetEvent();
                /*0xf5efdc*/ void ForgetMeEventUploaded();
                /*0xf5f084*/ string get_PrivacyUrl();
                /*0xf5f0c4*/ Unity.Services.Authentication.Internal.IPlayerId get_PlayerId();
                /*0xf5f0cc*/ void set_PlayerId(Unity.Services.Authentication.Internal.IPlayerId value);
                /*0xf5f0d4*/ Unity.Services.Core.Device.Internal.IInstallationId get_InstallId();
                /*0xf5f0dc*/ void set_InstallId(Unity.Services.Core.Device.Internal.IInstallationId value);
                /*0xf5f0e4*/ Unity.Services.Core.Configuration.Internal.ICloudProjectId get_CloudProjectIdProvider();
                /*0xf5f0ec*/ void set_CloudProjectIdProvider(Unity.Services.Core.Configuration.Internal.ICloudProjectId value);
                /*0xf5f0f4*/ string get_CloudProjectId();
                /*0xf5f1a8*/ string get_CustomAnalyticsId();
                /*0xf5f1b0*/ void set_CustomAnalyticsId(string value);
                /*0xf5f1b8*/ Unity.Services.Analytics.Internal.IDispatcher get_dataDispatcher();
                /*0xf5f1c0*/ void set_dataDispatcher(Unity.Services.Analytics.Internal.IDispatcher value);
                /*0xf5f1c8*/ bool get_ServiceEnabled();
                /*0xf5f1d0*/ void set_ServiceEnabled(bool value);
                /*0xf5f1dc*/ string get_SessionID();
                /*0xf5d4cc*/ void Flush();
                /*0xf5f4a4*/ void RecordInternalEvent(Unity.Services.Analytics.Internal.Event eventToRecord);
                /*0xf5f564*/ void SetDependencies(Unity.Services.Core.Configuration.Internal.ICloudProjectId cloudProjectId, Unity.Services.Core.Device.Internal.IInstallationId installId, Unity.Services.Authentication.Internal.IPlayerId playerId, string environment, string customAnalyticsId);
                /*0xf5d25c*/ System.Threading.Tasks.Task Initialize(Unity.Services.Core.Configuration.Internal.ICloudProjectId cloudProjectId, Unity.Services.Core.Device.Internal.IInstallationId installId, Unity.Services.Authentication.Internal.IPlayerId playerId, string environment, string customAnalyticsId);
                /*0xf5f620*/ System.Threading.Tasks.Task InitializeUser();
                /*0xf5f6e8*/ void Startup();
                /*0xf5d364*/ void NewPlayerEvent();
                /*0xf5fbac*/ void GameEnded();
                /*0xf5fd64*/ void RecordGameRunningIfNecessary();
                /*0xf60208*/ void InternalTick();
                /*0xf60018*/ void SetVariableCommonParams();
                /*0xf605a4*/ void GameEnded(Unity.Services.Analytics.Data.DataGenerator.SessionEndState quitState);
                /*0xf606dc*/ System.Threading.Tasks.Task SetAnalyticsEnabled(bool enabled);
                /*0xf5f3e4*/ string GetAnalyticsUserID();
                /*0xf607bc*/ void AcquisitionSource(Unity.Services.Analytics.AcquisitionSourceParameters acquisitionSourceParameters);
                /*0xf60a4c*/ void AdImpression(Unity.Services.Analytics.AdImpressionParameters adImpressionParameters);
                /*0xf60c54*/ void CustomData(string eventName, System.Collections.Generic.IDictionary<string, object> eventParams);
                /*0xf618d4*/ void Transaction(Unity.Services.Analytics.TransactionParameters transactionParameters);
                /*0xf61b98*/ long ConvertCurrencyToMinorUnits(string currencyCode, double value);
                /*0xf61d0c*/ void TransactionFailed(Unity.Services.Analytics.TransactionFailedParameters parameters);

                struct <CheckForRequiredConsents>d__1 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.List<string>> <>t__builder;
                    /*0x30*/ Unity.Services.Analytics.AnalyticsServiceInstance <>4__this;
                    /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter<Unity.Services.Analytics.Internal.GeoIPResponse> <>u__1;

                    /*0xf61fd0*/ void MoveNext();
                    /*0xf62500*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <Initialize>d__53 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ Unity.Services.Analytics.AnalyticsServiceInstance <>4__this;
                    /*0x38*/ Unity.Services.Core.Configuration.Internal.ICloudProjectId cloudProjectId;
                    /*0x40*/ Unity.Services.Core.Device.Internal.IInstallationId installId;
                    /*0x48*/ Unity.Services.Authentication.Internal.IPlayerId playerId;
                    /*0x50*/ string environment;
                    /*0x58*/ string customAnalyticsId;
                    /*0x60*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                    /*0xf62558*/ void MoveNext();
                    /*0xf626f0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <InitializeUser>d__54 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ Unity.Services.Analytics.AnalyticsServiceInstance <>4__this;
                    /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter<Unity.Services.Analytics.Internal.GeoIPResponse> <>u__1;

                    /*0xf626fc*/ void MoveNext();
                    /*0xf62b38*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <SetAnalyticsEnabled>d__62 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ bool enabled;
                    /*0x38*/ Unity.Services.Analytics.AnalyticsServiceInstance <>4__this;
                    /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                    /*0xf62b44*/ void MoveNext();
                    /*0xf62ef0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class AcquisitionSourceParameters
            {
                /*0x10*/ string Channel;
                /*0x18*/ string CampaignId;
                /*0x20*/ string CreativeId;
                /*0x28*/ string CampaignName;
                /*0x30*/ string Provider;
                /*0x38*/ System.Nullable<float> Cost;
                /*0x40*/ string CostCurrency;
                /*0x48*/ string Network;
                /*0x50*/ string CampaignType;

                /*0xf62efc*/ AcquisitionSourceParameters();
            }

            enum AdCompletionStatus
            {
                Completed = 0,
                Partial = 1,
                Incomplete = 2,
            }

            struct AdImpressionParameters
            {
                /*0x10*/ Unity.Services.Analytics.AdCompletionStatus AdCompletionStatus;
                /*0x14*/ Unity.Services.Analytics.AdProvider AdProvider;
                /*0x18*/ string PlacementID;
                /*0x20*/ string PlacementName;
                /*0x28*/ System.Nullable<Unity.Services.Analytics.AdPlacementType> PlacementType;
                /*0x30*/ System.Nullable<double> AdEcpmUsd;
                /*0x40*/ string SdkVersion;
                /*0x48*/ string AdImpressionID;
                /*0x50*/ string AdStoreDstID;
                /*0x58*/ string AdMediaType;
                /*0x60*/ System.Nullable<long> AdTimeWatchedMs;
                /*0x70*/ System.Nullable<long> AdTimeCloseButtonShownMs;
                /*0x80*/ System.Nullable<long> AdLengthMs;
                /*0x90*/ System.Nullable<bool> AdHasClicked;
                /*0x98*/ string AdSource;
                /*0xa0*/ string AdStatusCallback;
            }

            enum AdPlacementType
            {
                BANNER = 0,
                REWARDED = 1,
                INTERSTITIAL = 2,
                OTHER = 3,
            }

            enum AdProvider
            {
                AdColony = 0,
                AdMob = 1,
                Amazon = 2,
                AppLovin = 3,
                ChartBoost = 4,
                Facebook = 5,
                Fyber = 6,
                Hyprmx = 7,
                Inmobi = 8,
                Maio = 9,
                Pangle = 10,
                Tapjoy = 11,
                UnityAds = 12,
                Vungle = 13,
                IrnSource = 14,
                Other = 15,
            }

            struct Item
            {
                /*0x10*/ string ItemName;
                /*0x18*/ string ItemType;
                /*0x20*/ long ItemAmount;
            }

            struct Product
            {
                /*0x10*/ System.Nullable<Unity.Services.Analytics.RealCurrency> RealCurrency;
                /*0x28*/ System.Collections.Generic.List<Unity.Services.Analytics.VirtualCurrency> VirtualCurrencies;
                /*0x30*/ System.Collections.Generic.List<Unity.Services.Analytics.Item> Items;
            }

            struct RealCurrency
            {
                /*0x10*/ string RealCurrencyType;
                /*0x18*/ long RealCurrencyAmount;
            }

            class TransactionCurrencyConverter
            {
                /*0x10*/ System.Collections.Generic.Dictionary<string, int> m_CurrencyCodeToMinorUnits;

                /*0xf5f308*/ TransactionCurrencyConverter();
                /*0xf61bb0*/ long Convert(string currencyCode, double value);
                /*0xf62f04*/ void LoadCurrencyCodeDictionary();
            }

            struct TransactionParameters
            {
                /*0x10*/ string PaymentCountry;
                /*0x18*/ string ProductID;
                /*0x20*/ System.Nullable<long> RevenueValidated;
                /*0x30*/ string TransactionID;
                /*0x38*/ string TransactionReceipt;
                /*0x40*/ string TransactionReceiptSignature;
                /*0x48*/ System.Nullable<Unity.Services.Analytics.TransactionServer> TransactionServer;
                /*0x50*/ string TransactorID;
                /*0x58*/ string StoreItemSkuID;
                /*0x60*/ string StoreItemID;
                /*0x68*/ string StoreID;
                /*0x70*/ string StoreSourceID;
                /*0x78*/ string TransactionName;
                /*0x80*/ Unity.Services.Analytics.TransactionType TransactionType;
                /*0x88*/ Unity.Services.Analytics.Product ProductsReceived;
                /*0xb0*/ Unity.Services.Analytics.Product ProductsSpent;
            }

            enum TransactionServer
            {
                APPLE = 0,
                AMAZON = 1,
                GOOGLE = 2,
            }

            enum TransactionType
            {
                INVALID = 0,
                SALE = 1,
                PURCHASE = 2,
                TRADE = 3,
            }

            struct VirtualCurrency
            {
                /*0x10*/ string VirtualCurrencyName;
                /*0x18*/ Unity.Services.Analytics.VirtualCurrencyType VirtualCurrencyType;
                /*0x20*/ long VirtualCurrencyAmount;
            }

            enum VirtualCurrencyType
            {
                GRIND = 0,
                PREMIUM = 1,
                PREMIUM_GRIND = 2,
            }

            struct TransactionFailedParameters
            {
                /*0x10*/ string PaymentCountry;
                /*0x18*/ System.Nullable<long> EngagementID;
                /*0x28*/ System.Nullable<bool> IsInitiator;
                /*0x30*/ string StoreID;
                /*0x38*/ string StoreSourceID;
                /*0x40*/ string TransactionID;
                /*0x48*/ string StoreItemID;
                /*0x50*/ string AmazonUserID;
                /*0x58*/ string StoreItemSkuID;
                /*0x60*/ string ProductID;
                /*0x68*/ string GameStoreID;
                /*0x70*/ System.Nullable<Unity.Services.Analytics.TransactionServer> TransactionServer;
                /*0x78*/ System.Nullable<long> RevenueValidated;
                /*0x88*/ string TransactionName;
                /*0x90*/ Unity.Services.Analytics.TransactionType TransactionType;
                /*0x98*/ Unity.Services.Analytics.Product ProductsReceived;
                /*0xc0*/ Unity.Services.Analytics.Product ProductsSpent;
                /*0xe8*/ string FailureReason;
            }

            interface IAnalyticsService
            {
                string get_PrivacyUrl();
                void Flush();
                void AdImpression(Unity.Services.Analytics.AdImpressionParameters parameters);
                void Transaction(Unity.Services.Analytics.TransactionParameters transactionParameters);
                void TransactionFailed(Unity.Services.Analytics.TransactionFailedParameters parameters);
                void CustomData(string eventName, System.Collections.Generic.IDictionary<string, object> eventParams);
                System.Threading.Tasks.Task<System.Collections.Generic.List<string>> CheckForRequiredConsents();
                void ProvideOptInConsent(string identifier, bool consent);
                void OptOut();
                void RecordInternalEvent(Unity.Services.Analytics.Internal.Event eventToRecord);
                void AcquisitionSource(Unity.Services.Analytics.AcquisitionSourceParameters acquisitionSourceParameters);
                System.Threading.Tasks.Task SetAnalyticsEnabled(bool enabled);
                long ConvertCurrencyToMinorUnits(string currencyCode, double value);
                string GetAnalyticsUserID();
                string get_SessionID();
            }

            class InternalNewPlayerHelper
            {
                static string k_UnityAnalyticsInstallationIdKey = "UnityAnalyticsInstallationId";
                /*0x10*/ Unity.Services.Core.Device.Internal.IInstallationId <InstallId>k__BackingField;

                /*0xf5fa40*/ InternalNewPlayerHelper(Unity.Services.Core.Device.Internal.IInstallationId installId);
                /*0xf631d4*/ Unity.Services.Core.Device.Internal.IInstallationId get_InstallId();
                /*0xf5fac8*/ bool IsNewPlayer();
                /*0xf631dc*/ string ReadAnalyticsIdentifier();
                /*0xf63220*/ void WriteAnalyticsIdentifierToFile(string identifier);
            }

            class Events
            {
                static /*0x0*/ string PrivacyUrl;

                static /*0xf641ac*/ Events();
                static /*0xf63274*/ void AdImpression(Unity.Services.Analytics.Events.AdImpressionArgs args);
                static /*0xf6354c*/ System.Threading.Tasks.Task<System.Collections.Generic.List<string>> CheckForRequiredConsents();
                static /*0xf63630*/ void ProvideOptInConsent(string identifier, bool consent);
                static /*0xf63744*/ void CustomData(string eventName, System.Collections.Generic.IDictionary<string, object> eventParams);
                static /*0xf63858*/ void OptOut();
                static /*0xf63954*/ void Flush();
                static /*0xf63a50*/ void Transaction(Unity.Services.Analytics.Events.TransactionParameters transactionParameters);
                static /*0xf63e98*/ Unity.Services.Analytics.Product ConvertProduct(Unity.Services.Analytics.Events.Product from);
                static /*0xf64098*/ System.Collections.Generic.List<Unity.Services.Analytics.Item> ConvertItems(System.Collections.Generic.List<Unity.Services.Analytics.Events.Item> from);

                enum AdCompletionStatus
                {
                    Completed = 0,
                    Partial = 1,
                    Incomplete = 2,
                }

                enum AdProvider
                {
                    AdColony = 0,
                    AdMob = 1,
                    Amazon = 2,
                    AppLovin = 3,
                    ChartBoost = 4,
                    Facebook = 5,
                    Fyber = 6,
                    Hyprmx = 7,
                    Inmobi = 8,
                    Maio = 9,
                    Pangle = 10,
                    Tapjoy = 11,
                    UnityAds = 12,
                    Vungle = 13,
                    IrnSource = 14,
                    Other = 15,
                }

                class AdImpressionArgs
                {
                    /*0x10*/ Unity.Services.Analytics.Events.AdCompletionStatus <AdCompletionStatus>k__BackingField;
                    /*0x14*/ Unity.Services.Analytics.Events.AdProvider <AdProvider>k__BackingField;
                    /*0x18*/ string <PlacementID>k__BackingField;
                    /*0x20*/ string <PlacementName>k__BackingField;
                    /*0x28*/ string <PlacementType>k__BackingField;
                    /*0x30*/ System.Nullable<double> <AdEcpmUsd>k__BackingField;
                    /*0x40*/ string <SdkVersion>k__BackingField;
                    /*0x48*/ string <AdImpressionID>k__BackingField;
                    /*0x50*/ string <AdStoreDstID>k__BackingField;
                    /*0x58*/ string <AdMediaType>k__BackingField;
                    /*0x60*/ System.Nullable<long> <AdTimeWatchedMs>k__BackingField;
                    /*0x70*/ System.Nullable<long> <AdTimeCloseButtonShownMs>k__BackingField;
                    /*0x80*/ System.Nullable<long> <AdLengthMs>k__BackingField;
                    /*0x90*/ System.Nullable<bool> <AdHasClicked>k__BackingField;
                    /*0x98*/ string <AdSource>k__BackingField;
                    /*0xa0*/ string <AdStatusCallback>k__BackingField;

                    /*0xf6420c*/ AdImpressionArgs(Unity.Services.Analytics.Events.AdCompletionStatus adCompletionStatus, Unity.Services.Analytics.Events.AdProvider adProvider, string placementID, string placementName);
                    /*0xf6424c*/ Unity.Services.Analytics.Events.AdCompletionStatus get_AdCompletionStatus();
                    /*0xf64254*/ void set_AdCompletionStatus(Unity.Services.Analytics.Events.AdCompletionStatus value);
                    /*0xf6425c*/ Unity.Services.Analytics.Events.AdProvider get_AdProvider();
                    /*0xf64264*/ void set_AdProvider(Unity.Services.Analytics.Events.AdProvider value);
                    /*0xf6426c*/ string get_PlacementID();
                    /*0xf64274*/ void set_PlacementID(string value);
                    /*0xf6427c*/ string get_PlacementName();
                    /*0xf64284*/ void set_PlacementName(string value);
                    /*0xf6428c*/ string get_PlacementType();
                    /*0xf64294*/ void set_PlacementType(string value);
                    /*0xf6429c*/ System.Nullable<double> get_AdEcpmUsd();
                    /*0xf642a8*/ void set_AdEcpmUsd(System.Nullable<double> value);
                    /*0xf642b0*/ string get_SdkVersion();
                    /*0xf642b8*/ void set_SdkVersion(string value);
                    /*0xf642c0*/ string get_AdImpressionID();
                    /*0xf642c8*/ void set_AdImpressionID(string value);
                    /*0xf642d0*/ string get_AdStoreDstID();
                    /*0xf642d8*/ void set_AdStoreDstID(string value);
                    /*0xf642e0*/ string get_AdMediaType();
                    /*0xf642e8*/ void set_AdMediaType(string value);
                    /*0xf642f0*/ System.Nullable<long> get_AdTimeWatchedMs();
                    /*0xf642fc*/ void set_AdTimeWatchedMs(System.Nullable<long> value);
                    /*0xf64304*/ System.Nullable<long> get_AdTimeCloseButtonShownMs();
                    /*0xf64310*/ void set_AdTimeCloseButtonShownMs(System.Nullable<long> value);
                    /*0xf64318*/ System.Nullable<long> get_AdLengthMs();
                    /*0xf64324*/ void set_AdLengthMs(System.Nullable<long> value);
                    /*0xf6432c*/ System.Nullable<bool> get_AdHasClicked();
                    /*0xf64334*/ void set_AdHasClicked(System.Nullable<bool> value);
                    /*0xf6433c*/ string get_AdSource();
                    /*0xf64344*/ void set_AdSource(string value);
                    /*0xf6434c*/ string get_AdStatusCallback();
                    /*0xf64354*/ void set_AdStatusCallback(string value);
                }

                enum TransactionServer
                {
                    APPLE = 0,
                    AMAZON = 1,
                    GOOGLE = 2,
                }

                enum TransactionType
                {
                    INVALID = 0,
                    SALE = 1,
                    PURCHASE = 2,
                    TRADE = 3,
                }

                struct Item
                {
                    /*0x10*/ string itemName;
                    /*0x18*/ string itemType;
                    /*0x20*/ long itemAmount;
                }

                struct VirtualCurrency
                {
                    /*0x10*/ string virtualCurrencyName;
                    /*0x18*/ string virtualCurrencyType;
                    /*0x20*/ long virtualCurrencyAmount;
                }

                struct RealCurrency
                {
                    /*0x10*/ string realCurrencyType;
                    /*0x18*/ long realCurrencyAmount;
                }

                struct Product
                {
                    /*0x10*/ System.Nullable<Unity.Services.Analytics.Events.RealCurrency> realCurrency;
                    /*0x28*/ System.Collections.Generic.List<Unity.Services.Analytics.Events.VirtualCurrency> virtualCurrencies;
                    /*0x30*/ System.Collections.Generic.List<Unity.Services.Analytics.Events.Item> items;
                }

                struct TransactionParameters
                {
                    /*0x10*/ System.Nullable<bool> isInitiator;
                    /*0x18*/ string paymentCountry;
                    /*0x20*/ string productID;
                    /*0x28*/ System.Nullable<long> revenueValidated;
                    /*0x38*/ string transactionID;
                    /*0x40*/ string transactionReceipt;
                    /*0x48*/ string transactionReceiptSignature;
                    /*0x50*/ System.Nullable<Unity.Services.Analytics.Events.TransactionServer> transactionServer;
                    /*0x58*/ string transactorID;
                    /*0x60*/ string storeItemSkuID;
                    /*0x68*/ string storeItemID;
                    /*0x70*/ string storeID;
                    /*0x78*/ string storeSourceID;
                    /*0x80*/ string transactionName;
                    /*0x88*/ Unity.Services.Analytics.Events.TransactionType transactionType;
                    /*0x90*/ Unity.Services.Analytics.Events.Product productsReceived;
                    /*0xb8*/ Unity.Services.Analytics.Events.Product productsSpent;
                }

                struct <CheckForRequiredConsents>d__4 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.List<string>> <>t__builder;
                    /*0x30*/ System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.List<string>> <>u__1;

                    /*0xf6435c*/ void MoveNext();
                    /*0xf6460c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                class <>c
                {
                    static /*0x0*/ Unity.Services.Analytics.Events.<> <>9;
                    static /*0x8*/ System.Func<Unity.Services.Analytics.Events.VirtualCurrency, Unity.Services.Analytics.VirtualCurrency> <>9__18_0;
                    static /*0x10*/ System.Func<Unity.Services.Analytics.Events.Item, Unity.Services.Analytics.Item> <>9__19_0;

                    static /*0xf64664*/ <>c();
                    /*0xf646c8*/ <>c();
                    /*0xf646d0*/ Unity.Services.Analytics.VirtualCurrency <ConvertProduct>b__18_0(Unity.Services.Analytics.Events.VirtualCurrency vc);
                    /*0xf64790*/ Unity.Services.Analytics.Item <ConvertItems>b__19_0(Unity.Services.Analytics.Events.Item i);
                }
            }

            class AnalyticsLifetime : UnityEngine.MonoBehaviour
            {
                static float k_HeartbeatPeriod = 60;
                static float k_GameRunningPeriod = 60;
                static /*0x0*/ Unity.Services.Analytics.AnalyticsLifetime <Instance>k__BackingField;
                /*0x18*/ float m_HeartbeatTime;
                /*0x1c*/ float m_GameRunningTime;

                static /*0xf647a4*/ Unity.Services.Analytics.AnalyticsLifetime get_Instance();
                static /*0xf647ec*/ void set_Instance(Unity.Services.Analytics.AnalyticsLifetime value);
                /*0xf64b40*/ AnalyticsLifetime();
                /*0xf64838*/ float get_TimeUntilHeartbeat();
                /*0xf6484c*/ void Awake();
                /*0xf649fc*/ void Update();
                /*0xf64ae0*/ void OnDestroy();
            }

            class ContainerObject
            {
                static /*0x0*/ bool s_Created;
                static /*0x8*/ UnityEngine.GameObject s_Container;

                static /*0xf64b48*/ void Initialize();
                static /*0xf5eb80*/ void DestroyContainer();
            }

            enum ConsentCheckExceptionReason
            {
                Unknown = 0,
                DeserializationIssue = 1,
                NoInternetConnection = 2,
                InvalidConsentFlow = 3,
                ConsentFlowNotKnown = 4,
            }

            class ConsentCheckException : Unity.Services.Core.RequestFailedException
            {
                /*0x90*/ Unity.Services.Analytics.ConsentCheckExceptionReason <Reason>k__BackingField;

                /*0xf5e2d0*/ ConsentCheckException(Unity.Services.Analytics.ConsentCheckExceptionReason reason, int errorCode, string message, System.Exception innerException);
                /*0xf64c18*/ Unity.Services.Analytics.ConsentCheckExceptionReason get_Reason();
                /*0xf64c20*/ void set_Reason(Unity.Services.Analytics.ConsentCheckExceptionReason value);
            }

            interface ICoreStatsHelper
            {
                void SetCoreStatsConsent(bool userProvidedConsent);
            }

            class CoreStatsHelper : Unity.Services.Analytics.ICoreStatsHelper
            {
                /*0xf5f300*/ CoreStatsHelper();
                /*0xf64c28*/ void SetCoreStatsConsent(bool userProvidedConsent);
            }

            class SdkVersion
            {
                static /*0x0*/ string SDK_VERSION;

                static /*0xf64c2c*/ SdkVersion();
            }

            namespace Internal
            {
                class Locale
                {
                    static /*0xf64c8c*/ string CurrentLanguageCode();
                    static /*0xf5f9f8*/ string AnalyticsRegionLanguageCode();
                    static /*0xf64e18*/ System.Globalization.CultureInfo CurrentCulture();
                    static /*0xf64e68*/ System.Globalization.CultureInfo SystemCulture();
                }

                interface IAnalyticsForgetter
                {
                    void AttemptToForget();
                }

                class AnalyticsForgetter : Unity.Services.Analytics.Internal.IAnalyticsForgetter
                {
                    /*0x10*/ string s_CollectUrl;
                    /*0x18*/ byte[] s_Event;
                    /*0x20*/ System.Action s_Callback;
                    /*0x28*/ bool m_SuccessfullyUploaded;
                    /*0x30*/ UnityEngine.Networking.UnityWebRequestAsyncOperation m_Request;
                    /*0x38*/ Unity.Services.Analytics.Internal.IConsentTracker <ConsentTracker>k__BackingField;

                    /*0xf5ec84*/ AnalyticsForgetter(string collectUrl, string userId, string timestamp, string callingMethod, System.Action successfulUploadCallback, Unity.Services.Analytics.Internal.IConsentTracker consentTracker);
                    /*0xf64eb8*/ Unity.Services.Analytics.Internal.IConsentTracker get_ConsentTracker();
                    /*0xf64ec0*/ void AttemptToForget();
                    /*0xf652a0*/ void UploadComplete(UnityEngine.AsyncOperation _);
                }

                interface IBuffer
                {
                    string get_UserID();
                    void set_UserID(string value);
                    string get_InstallID();
                    void set_InstallID(string value);
                    string get_PlayerID();
                    void set_PlayerID(string value);
                    string get_SessionID();
                    void set_SessionID(string value);
                    int get_Length();
                    string Serialize(System.Collections.Generic.List<Unity.Services.Analytics.Internal.Buffer.Token> tokens);
                    void InsertTokens(System.Collections.Generic.List<Unity.Services.Analytics.Internal.Buffer.Token> tokens);
                    void PushStartEvent(string name, System.DateTime datetime, System.Nullable<long> eventVersion, bool addPlayerIdsToEventBody);
                    void PushEndEvent();
                    void PushObjectStart(string name);
                    void PushObjectEnd();
                    void PushArrayStart(string name);
                    void PushArrayEnd();
                    void PushDouble(double val, string name);
                    void PushFloat(float val, string name);
                    void PushString(string val, string name);
                    void PushInt64(long val, string name);
                    void PushInt(int val, string name);
                    void PushBool(bool val, string name);
                    void PushTimestamp(System.DateTime val, string name);
                    void FlushToDisk();
                    void ClearDiskCache();
                    void ClearBuffer();
                    void LoadFromDisk();
                    void PushEvent(Unity.Services.Analytics.Internal.Event evt);
                    System.Collections.Generic.List<Unity.Services.Analytics.Internal.Buffer.Token> CloneTokens();
                }

                class Buffer : Unity.Services.Analytics.Internal.IBuffer
                {
                    static string k_SecondDateFormat = "yyyy-MM-dd HH:mm:ss zzz";
                    static string k_MillisecondDateFormat = "yyyy-MM-dd HH:mm:ss.fff zzz";
                    static string k_NoBufferSupportMessage = "Unity Analytics cache is not supported on this platform, data will not be locally persisted.";
                    static /*0x0*/ string[] k_AllDateFormats;
                    /*0x10*/ string <UserID>k__BackingField;
                    /*0x18*/ string <SessionID>k__BackingField;
                    /*0x20*/ string <PlayerID>k__BackingField;
                    /*0x28*/ string <InstallID>k__BackingField;
                    /*0x30*/ System.Collections.Generic.List<Unity.Services.Analytics.Internal.Buffer.Token> m_Tokens;
                    /*0x38*/ string m_CacheFilePath;
                    /*0x40*/ long m_CacheFileMaximumSize;
                    /*0x48*/ int m_DiskCacheLastFlushedToken;
                    /*0x50*/ long m_DiskCacheSize;

                    static /*0xf6856c*/ Buffer();
                    static /*0xf5ec04*/ string SaveDateTime(System.DateTime dateTime);
                    static /*0xf669b0*/ System.DateTime ParseDateTime(string dateTime);
                    static /*0xf653c4*/ bool CanUseDiskPersistence();
                    /*0xf5f1e4*/ Buffer();
                    /*0xf6533c*/ string get_UserID();
                    /*0xf65344*/ void set_UserID(string value);
                    /*0xf6534c*/ string get_SessionID();
                    /*0xf65354*/ void set_SessionID(string value);
                    /*0xf6535c*/ string get_PlayerID();
                    /*0xf65364*/ void set_PlayerID(string value);
                    /*0xf6536c*/ string get_InstallID();
                    /*0xf65374*/ void set_InstallID(string value);
                    /*0xf6537c*/ int get_Length();
                    /*0xf65b44*/ System.Collections.Generic.List<Unity.Services.Analytics.Internal.Buffer.Token> CloneTokens();
                    /*0xf65bf8*/ void InsertTokens(System.Collections.Generic.List<Unity.Services.Analytics.Internal.Buffer.Token> tokens);
                    /*0xf65c50*/ string Serialize(System.Collections.Generic.List<Unity.Services.Analytics.Internal.Buffer.Token> tokens);
                    /*0xf66978*/ bool IsRequestOverSizeLimit(string data);
                    /*0xf66a7c*/ void PushStartEvent(string name, System.DateTime datetime, System.Nullable<long> eventVersion, bool addPlayerIdsToEventBody);
                    /*0xf66e08*/ void PushEndEvent();
                    /*0xf66f64*/ void PushObjectStart(string name);
                    /*0xf6703c*/ void PushObjectEnd();
                    /*0xf67110*/ void PushArrayStart(string name);
                    /*0xf671e8*/ void PushArrayEnd();
                    /*0xf672bc*/ void PushDouble(double val, string name);
                    /*0xf673d0*/ void PushFloat(float val, string name);
                    /*0xf673d8*/ void PushString(string val, string name);
                    /*0xf674bc*/ void PushInt64(long val, string name);
                    /*0xf675c8*/ void PushInt(int val, string name);
                    /*0xf675d0*/ void PushBool(bool val, string name);
                    /*0xf676dc*/ void PushTimestamp(System.DateTime val, string name);
                    /*0xf677e8*/ void FlushToDisk();
                    /*0xf65a78*/ void ClearDiskCache();
                    /*0xf67f4c*/ void ClearBuffer();
                    /*0xf65440*/ void LoadFromDisk();
                    /*0xf67cdc*/ void WriteToken(System.IO.BinaryWriter writer, Unity.Services.Analytics.Internal.Buffer.Token token);
                    /*0xf67fb8*/ Unity.Services.Analytics.Internal.Buffer.Token ReadToken(System.IO.BinaryReader reader);
                    /*0xf681a4*/ void PushEvent(Unity.Services.Analytics.Internal.Event evt);

                    enum TokenType
                    {
                        EventStart = 0,
                        EventEnd = 1,
                        EventParamsStart = 2,
                        EventParamsEnd = 3,
                        EventObjectStart = 4,
                        EventObjectEnd = 5,
                        EventArrayStart = 6,
                        EventArrayEnd = 7,
                        Boolean = 8,
                        Float64 = 9,
                        String = 10,
                        Int64 = 11,
                        Timestamp = 12,
                        EventTimestamp = 13,
                        StandardEventIds = 14,
                    }

                    struct Token
                    {
                        /*0x10*/ string Name;
                        /*0x18*/ Unity.Services.Analytics.Internal.Buffer.TokenType Type;
                        /*0x20*/ object Data;
                    }
                }

                class BufferRevoked : Unity.Services.Analytics.Internal.IBuffer
                {
                    /*0x10*/ string <UserID>k__BackingField;
                    /*0x18*/ string <InstallID>k__BackingField;
                    /*0x20*/ string <PlayerID>k__BackingField;
                    /*0x28*/ string <SessionID>k__BackingField;

                    /*0xf5eacc*/ BufferRevoked();
                    /*0xf6866c*/ string get_UserID();
                    /*0xf68674*/ void set_UserID(string value);
                    /*0xf6867c*/ string get_InstallID();
                    /*0xf68684*/ void set_InstallID(string value);
                    /*0xf6868c*/ string get_PlayerID();
                    /*0xf68694*/ void set_PlayerID(string value);
                    /*0xf6869c*/ string get_SessionID();
                    /*0xf686a4*/ void set_SessionID(string value);
                    /*0xf686ac*/ int get_Length();
                    /*0xf686b4*/ void ClearBuffer();
                    /*0xf686b8*/ void ClearDiskCache();
                    /*0xf686bc*/ System.Collections.Generic.List<Unity.Services.Analytics.Internal.Buffer.Token> CloneTokens();
                    /*0xf6872c*/ void InsertTokens(System.Collections.Generic.List<Unity.Services.Analytics.Internal.Buffer.Token> tokens);
                    /*0xf68730*/ void FlushToDisk();
                    /*0xf68734*/ void LoadFromDisk();
                    /*0xf68738*/ void PushArrayEnd();
                    /*0xf6873c*/ void PushArrayStart(string name);
                    /*0xf68740*/ void PushBool(bool val, string name);
                    /*0xf68744*/ void PushDouble(double val, string name);
                    /*0xf68748*/ void PushEndEvent();
                    /*0xf6874c*/ void PushEvent(Unity.Services.Analytics.Internal.Event evt);
                    /*0xf68750*/ void PushFloat(float val, string name);
                    /*0xf68754*/ void PushInt(int val, string name);
                    /*0xf68758*/ void PushInt64(long val, string name);
                    /*0xf6875c*/ void PushObjectEnd();
                    /*0xf68760*/ void PushObjectStart(string name);
                    /*0xf68764*/ void PushStartEvent(string name, System.DateTime datetime, System.Nullable<long> eventVersion, bool addPlayerIdsToEventBody);
                    /*0xf68768*/ void PushString(string val, string name);
                    /*0xf6876c*/ void PushTimestamp(System.DateTime val, string name);
                    /*0xf68770*/ string Serialize(System.Collections.Generic.List<Unity.Services.Analytics.Internal.Buffer.Token> tokens);
                }

                enum ConsentStatus
                {
                    Unknown = 0,
                    Forgetting = 1,
                    OptedOut = 2,
                    NotRequired = 3,
                    RequiredButUnchecked = 4,
                    ConsentGiven = 5,
                    ConsentDenied = 6,
                }

                interface IConsentTracker
                {
                    System.Threading.Tasks.Task<Unity.Services.Analytics.Internal.GeoIPResponse> CheckGeoIP();
                    void SetUserConsentStatus(string key, bool consentGiven);
                    System.Collections.Generic.Dictionary<string, string> get_requiredHeaders();
                    void BeginOptOutProcess(string identifier);
                    void BeginOptOutProcess();
                    void FinishOptOutProcess();
                    bool IsGeoIpChecked();
                    bool IsConsentGiven(string identifier);
                    bool IsConsentGiven();
                    bool IsConsentDenied();
                    bool IsOptingOutInProgress();
                    void SetDenyConsentToAll();
                }

                class Consent
                {
                    static /*0xf687b8*/ string get_Pipl();
                    static /*0xf624c0*/ string get_None();
                }

                class ConsentTracker : Unity.Services.Analytics.Internal.IConsentTracker
                {
                    static string optInPiplConsentStatusPrefKey = "unity.services.analytics.pipl_consent_status";
                    static string optOutConsentStatusPrefKey = "unity.services.analytics.consent_status";
                    /*0x10*/ Unity.Services.Analytics.Internal.IGeoAPI m_GeoAPI;
                    /*0x18*/ Unity.Services.Analytics.ICoreStatsHelper m_CoreStatsHelper;
                    /*0x20*/ Unity.Services.Analytics.Internal.ConsentStatus <optInPiplConsentStatus>k__BackingField;
                    /*0x24*/ Unity.Services.Analytics.Internal.ConsentStatus <optOutConsentStatus>k__BackingField;
                    /*0x28*/ Unity.Services.Analytics.Internal.GeoIPResponse response;

                    /*0xf5f310*/ ConsentTracker(Unity.Services.Analytics.ICoreStatsHelper coreStatsHelper);
                    /*0xf68a20*/ ConsentTracker(Unity.Services.Analytics.Internal.IGeoAPI geoApi, Unity.Services.Analytics.ICoreStatsHelper coreStatsHelper);
                    /*0xf687f8*/ Unity.Services.Analytics.Internal.ConsentStatus get_optInPiplConsentStatus();
                    /*0xf68800*/ void set_optInPiplConsentStatus(Unity.Services.Analytics.Internal.ConsentStatus value);
                    /*0xf68808*/ Unity.Services.Analytics.Internal.ConsentStatus get_optOutConsentStatus();
                    /*0xf68810*/ void set_optOutConsentStatus(Unity.Services.Analytics.Internal.ConsentStatus value);
                    /*0xf68818*/ System.Collections.Generic.Dictionary<string, string> get_piplHeaders();
                    /*0xf68908*/ System.Collections.Generic.Dictionary<string, string> get_requiredHeaders();
                    /*0xf68be8*/ System.Threading.Tasks.Task<Unity.Services.Analytics.Internal.GeoIPResponse> CheckGeoIP();
                    /*0xf68cd8*/ void SetUserConsentStatus(string identifier, bool consentGiven);
                    /*0xf68f68*/ bool IsGeoIpChecked();
                    /*0xf68f78*/ bool IsConsentGiven();
                    /*0xf69008*/ bool IsConsentGiven(string identifier);
                    /*0xf69080*/ bool IsConsentDenied();
                    /*0xf6910c*/ bool IsOptingOutInProgress();
                    /*0xf69194*/ void BeginOptOutProcess(string identifier);
                    /*0xf692c0*/ void BeginOptOutProcess();
                    /*0xf69370*/ void FinishOptOutProcess();
                    /*0xf69424*/ void SetDenyConsentToAll();
                    /*0xf68efc*/ void SetOptInPiplConsentStatus(bool consentGiven);
                    /*0xf68b28*/ void ReadOptInPiplConsentStatus();
                    /*0xf68b88*/ void ReadOptOutConsentStatus();
                    /*0xf694bc*/ System.Threading.Tasks.Task<Unity.Services.Analytics.Internal.GeoIPResponse> GetGeoIPResponse();
                    /*0xf68fa0*/ void ValidateConsentWasChecked();
                    /*0xf68db0*/ void ValidateConsentFlow(string identifier);

                    struct <CheckGeoIP>d__19 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Unity.Services.Analytics.Internal.GeoIPResponse> <>t__builder;
                        /*0x30*/ Unity.Services.Analytics.Internal.ConsentTracker <>4__this;
                        /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter<Unity.Services.Analytics.Internal.GeoIPResponse> <>u__1;

                        /*0xf695ac*/ void MoveNext();
                        /*0xf69988*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <GetGeoIPResponse>d__33 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Unity.Services.Analytics.Internal.GeoIPResponse> <>t__builder;
                        /*0x30*/ Unity.Services.Analytics.Internal.ConsentTracker <>4__this;
                        /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter<Unity.Services.Analytics.Internal.GeoIPResponse> <>u__1;

                        /*0xf699e0*/ void MoveNext();
                        /*0xf69cd8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                interface IGeoAPI
                {
                    System.Threading.Tasks.Task<Unity.Services.Analytics.Internal.GeoIPResponse> MakeRequest();
                }

                class GeoAPI : Unity.Services.Analytics.Internal.IGeoAPI
                {
                    /*0x10*/ string m_PrivacyEndpoint;

                    /*0xf689d0*/ GeoAPI();
                    /*0xf69d30*/ System.Threading.Tasks.Task<Unity.Services.Analytics.Internal.GeoIPResponse> MakeRequest();

                    class WebRequestTaskWrapper
                    {
                        /*0x10*/ UnityEngine.Networking.UnityWebRequestAsyncOperation m_AsyncOp;

                        /*0xf69e20*/ WebRequestTaskWrapper(UnityEngine.Networking.UnityWebRequest request);
                        /*0xf69e5c*/ System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Networking.UnityWebRequestAsyncOperation> GetAwaiter();

                        class <>c__DisplayClass2_0
                        {
                            /*0x10*/ Unity.Services.Analytics.Internal.GeoAPI.WebRequestTaskWrapper <>4__this;
                            /*0x18*/ System.Threading.Tasks.TaskCompletionSource<UnityEngine.Networking.UnityWebRequestAsyncOperation> tcs;

                            /*0xf69f9c*/ <>c__DisplayClass2_0();
                            /*0xf69fa4*/ void <GetAwaiter>b__0(UnityEngine.AsyncOperation obj);
                        }
                    }

                    struct <MakeRequest>d__1 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Unity.Services.Analytics.Internal.GeoIPResponse> <>t__builder;
                        /*0x30*/ Unity.Services.Analytics.Internal.GeoAPI <>4__this;
                        /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Networking.UnityWebRequestAsyncOperation> <>u__1;

                        /*0xf6a000*/ void MoveNext();
                        /*0xf6a4f0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class GeoIPResponse
                {
                    /*0x10*/ string identifier;
                    /*0x18*/ string country;
                    /*0x20*/ string region;
                    /*0x28*/ int ageGateLimit;

                    /*0xf6a548*/ GeoIPResponse();
                }

                interface IDispatcher
                {
                    string get_CollectUrl();
                    void set_CollectUrl(string value);
                    System.Threading.Tasks.Task Flush();
                }

                class Dispatcher : Unity.Services.Analytics.Internal.IDispatcher
                {
                    /*0x10*/ Unity.Services.Analytics.Internal.IBuffer m_DataBuffer;
                    /*0x18*/ Unity.Services.Analytics.Internal.IWebRequestHelper m_WebRequestHelper;
                    /*0x20*/ System.Collections.Generic.Dictionary<System.Guid, System.Collections.Generic.List<Unity.Services.Analytics.Internal.Buffer.Token>> Requests;
                    /*0x28*/ string <CollectUrl>k__BackingField;
                    /*0x30*/ Unity.Services.Analytics.Internal.IConsentTracker <ConsentTracker>k__BackingField;

                    /*0xf5eadc*/ Dispatcher(Unity.Services.Analytics.Internal.IBuffer buffer, Unity.Services.Analytics.Internal.IWebRequestHelper webRequestHelper, Unity.Services.Analytics.Internal.IConsentTracker consentTracker);
                    /*0xf6a550*/ string get_CollectUrl();
                    /*0xf6a558*/ void set_CollectUrl(string value);
                    /*0xf6a560*/ Unity.Services.Analytics.Internal.IConsentTracker get_ConsentTracker();
                    /*0xf6a568*/ System.Threading.Tasks.Task Flush();
                    /*0xf6a630*/ byte[] SerializeBuffer(System.Collections.Generic.List<Unity.Services.Analytics.Internal.Buffer.Token> tokens);
                    /*0xf6a71c*/ System.Threading.Tasks.Task FlushBufferToService();

                    struct <Flush>d__11 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                        /*0x30*/ Unity.Services.Analytics.Internal.Dispatcher <>4__this;
                        /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                        /*0xf6a7e8*/ void MoveNext();
                        /*0xf6ab24*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    class <>c__DisplayClass13_0
                    {
                        /*0x10*/ Unity.Services.Analytics.Internal.Dispatcher <>4__this;
                        /*0x18*/ System.Collections.Generic.List<Unity.Services.Analytics.Internal.Buffer.Token> tokens;
                        /*0x20*/ Unity.Services.Analytics.Internal.IWebRequest request;
                        /*0x28*/ System.Guid requestId;

                        /*0xf6ab30*/ <>c__DisplayClass13_0();
                        /*0xf6ab38*/ byte[] <FlushBufferToService>b__0();
                        /*0xf6ab58*/ void <FlushBufferToService>b__1(long responseCode);
                    }

                    struct <FlushBufferToService>d__13 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                        /*0x30*/ Unity.Services.Analytics.Internal.Dispatcher <>4__this;
                        /*0x38*/ Unity.Services.Analytics.Internal.Dispatcher.<> <>8__1;
                        /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter<System.Byte[]> <>u__1;

                        /*0xf6ae14*/ void MoveNext();
                        /*0xf6b6f4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class Event
                {
                    /*0x10*/ Unity.Services.Analytics.Internal.EventData <Parameters>k__BackingField;
                    /*0x18*/ string <Name>k__BackingField;
                    /*0x20*/ System.Nullable<int> <Version>k__BackingField;

                    /*0xf6b700*/ Event(string name, System.Nullable<int> version);
                    /*0xf6b7fc*/ Unity.Services.Analytics.Internal.EventData get_Parameters();
                    /*0xf6b804*/ void set_Parameters(Unity.Services.Analytics.Internal.EventData value);
                    /*0xf6b80c*/ string get_Name();
                    /*0xf6b814*/ void set_Name(string value);
                    /*0xf6b81c*/ System.Nullable<int> get_Version();
                    /*0xf6b824*/ void set_Version(System.Nullable<int> value);
                }

                class EventData
                {
                    /*0x10*/ System.Collections.Generic.Dictionary<string, object> <Data>k__BackingField;

                    /*0xf6b77c*/ EventData();
                    /*0xf6b82c*/ void Set(string key, float value);
                    /*0xf6b8d0*/ void Set(string key, double value);
                    /*0xf6b974*/ void Set(string key, bool value);
                    /*0xf6ba10*/ void Set(string key, int value);
                    /*0xf6baac*/ void Set(string key, object value);
                    /*0xf6bb14*/ void Set(string key, long value);
                    /*0xf6bbb0*/ void Set(string key, string value);
                    /*0xf6bc18*/ void AddPlatform();
                    /*0xf6bc68*/ void AddBatteryLoad();
                    /*0xf6bcb4*/ void AddConnectionType();
                    /*0xf6bd48*/ void AddUserCountry();
                    /*0xf6bdc4*/ void AddBuildGuuid();
                    /*0xf6be18*/ void AddClientVersion();
                    /*0xf6be6c*/ void AddGameBundleID();
                    /*0xf6bec0*/ void AddStdParamData(string sdkMethod, string uasID);
                    /*0xf6bfa8*/ System.Collections.Generic.Dictionary<string, object> get_Data();
                    /*0xf6bfb0*/ void set_Data(System.Collections.Generic.Dictionary<string, object> value);
                }

                interface IWebRequest
                {
                    UnityEngine.Networking.UnityWebRequestAsyncOperation SendWebRequest();
                    UnityEngine.Networking.UploadHandler get_uploadHandler();
                    void set_uploadHandler(UnityEngine.Networking.UploadHandler value);
                    void SetRequestHeader(string key, string value);
                    bool get_isNetworkError();
                    void Dispose();
                }

                interface IWebRequestHelper
                {
                    Unity.Services.Analytics.Internal.IWebRequest CreateWebRequest(string url, string method, byte[] postBytes);
                    void SendWebRequest(Unity.Services.Analytics.Internal.IWebRequest request, System.Action<long> onCompleted);
                }

                class AnalyticsWebRequest : UnityEngine.Networking.UnityWebRequest, Unity.Services.Analytics.Internal.IWebRequest
                {
                    /*0xf6bfb8*/ AnalyticsWebRequest(string url, string method);
                    /*0xf6bfc0*/ UnityEngine.Networking.UnityWebRequestAsyncOperation Unity.Services.Analytics.Internal.IWebRequest.SendWebRequest();
                    /*0xf6bfc8*/ UnityEngine.Networking.UploadHandler Unity.Services.Analytics.Internal.IWebRequest.get_uploadHandler();
                    /*0xf6bfd0*/ void Unity.Services.Analytics.Internal.IWebRequest.set_uploadHandler(UnityEngine.Networking.UploadHandler value);
                    /*0xf6bfd8*/ void Unity.Services.Analytics.Internal.IWebRequest.SetRequestHeader(string key, string value);
                    /*0xf6bfe0*/ bool Unity.Services.Analytics.Internal.IWebRequest.get_isNetworkError();
                }

                class WebRequestHelper : Unity.Services.Analytics.Internal.IWebRequestHelper
                {
                    /*0xf5ead4*/ WebRequestHelper();
                    /*0xf6bfe8*/ Unity.Services.Analytics.Internal.IWebRequest CreateWebRequest(string url, string method, byte[] postBytes);
                    /*0xf6c0c4*/ void SendWebRequest(Unity.Services.Analytics.Internal.IWebRequest request, System.Action<long> onCompleted);

                    class <>c__DisplayClass1_0
                    {
                        /*0x10*/ System.Action<long> onCompleted;
                        /*0x18*/ UnityEngine.Networking.UnityWebRequestAsyncOperation requestOp;

                        /*0xf6c200*/ <>c__DisplayClass1_0();
                        /*0xf6c208*/ void <SendWebRequest>b__0(UnityEngine.AsyncOperation <p0>);
                    }
                }

                namespace Platform
                {
                    class UserCountry
                    {
                        static /*0xf61b58*/ string Name();
                    }
                }
            }

            namespace Platform
            {
                class DebugDevice
                {
                    static /*0xf5f9f0*/ bool IsDebugDevice();
                }

                interface IIDeviceIdentifiersInternal
                {
                    string get_Idfv();
                }

                class DeviceIdentifiersInternal : Unity.Services.Analytics.Platform.IIDeviceIdentifiersInternal
                {
                    /*0xf5f2f8*/ DeviceIdentifiersInternal();
                    /*0xf6c24c*/ string get_Idfv();
                }

                class DeviceVolumeProvider
                {
                    static /*0xf602cc*/ System.Nullable<float> GetDeviceVolume();
                }

                enum UA2PlatformCode
                {
                    UNKNOWN = 0,
                    IOS = 1,
                    IOS_MOBILE = 2,
                    IOS_TABLET = 3,
                    IOS_TV = 4,
                    ANDROID = 5,
                    ANDROID_MOBILE = 6,
                    ANDROID_CONSOLE = 7,
                    WINDOWS_MOBILE = 8,
                    WINDOWS_TABLET = 9,
                    BLACKBERRY_MOBILE = 10,
                    BLACKBERRY_TABLET = 11,
                    FACEBOOK = 12,
                    AMAZON = 13,
                    WEB = 14,
                    PC_CLIENT = 15,
                    MAC_CLIENT = 16,
                    PS3 = 17,
                    PS4 = 18,
                    PSVITA = 19,
                    XBOX360 = 20,
                    XBOXONE = 21,
                    WIIU = 22,
                    SWITCH = 23,
                }

                class Runtime
                {
                    static /*0xf5f380*/ string Name();
                    static /*0xf6c254*/ Unity.Services.Analytics.Platform.UA2PlatformCode GetPlatform();
                }
            }

            namespace Data
            {
                class StdCommonParams
                {
                    /*0x10*/ string <GameStoreID>k__BackingField;
                    /*0x18*/ string <GameBundleID>k__BackingField;
                    /*0x20*/ string <Platform>k__BackingField;
                    /*0x28*/ string <UasUserID>k__BackingField;
                    /*0x30*/ string <Idfv>k__BackingField;
                    /*0x38*/ System.Nullable<double> <DeviceVolume>k__BackingField;
                    /*0x48*/ System.Nullable<double> <BatteryLoad>k__BackingField;
                    /*0x58*/ string <BuildGuuid>k__BackingField;
                    /*0x60*/ string <ClientVersion>k__BackingField;
                    /*0x68*/ string <UserCountry>k__BackingField;
                    /*0x70*/ string <ProjectID>k__BackingField;

                    /*0xf5f2f0*/ StdCommonParams();
                    /*0xf6c2fc*/ string get_GameStoreID();
                    /*0xf6c304*/ void set_GameStoreID(string value);
                    /*0xf6c30c*/ string get_GameBundleID();
                    /*0xf6c314*/ void set_GameBundleID(string value);
                    /*0xf6c31c*/ string get_Platform();
                    /*0xf6c324*/ void set_Platform(string value);
                    /*0xf6c32c*/ string get_UasUserID();
                    /*0xf6c334*/ void set_UasUserID(string value);
                    /*0xf6c33c*/ string get_Idfv();
                    /*0xf6c344*/ void set_Idfv(string value);
                    /*0xf6c34c*/ System.Nullable<double> get_DeviceVolume();
                    /*0xf6c358*/ void set_DeviceVolume(System.Nullable<double> value);
                    /*0xf6c360*/ System.Nullable<double> get_BatteryLoad();
                    /*0xf6c36c*/ void set_BatteryLoad(System.Nullable<double> value);
                    /*0xf6c374*/ string get_BuildGuuid();
                    /*0xf6c37c*/ void set_BuildGuuid(string value);
                    /*0xf6c384*/ string get_ClientVersion();
                    /*0xf6c38c*/ void set_ClientVersion(string value);
                    /*0xf6c394*/ string get_UserCountry();
                    /*0xf6c39c*/ void set_UserCountry(string value);
                    /*0xf6c3a4*/ string get_ProjectID();
                    /*0xf6c3ac*/ void set_ProjectID(string value);
                    /*0xf6c3b4*/ void SerializeCommonEventParams(ref Unity.Services.Analytics.Internal.IBuffer buf, string callingMethodIdentifier);
                }

                interface IDataGenerator
                {
                    void GameRunning(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier);
                    void SdkStartup(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier);
                    void NewPlayer(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier, string deviceModel);
                    void GameStarted(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier, string idLocalProject, string osVersion, bool isTiny, bool debugDevice, string userLocale);
                    void GameEnded(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier, Unity.Services.Analytics.Data.DataGenerator.SessionEndState quitState);
                    void AdImpression(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier, Unity.Services.Analytics.AdImpressionParameters adImpressionParameters);
                    void Transaction(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier, Unity.Services.Analytics.TransactionParameters transactionParameters);
                    void TransactionFailed(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier, Unity.Services.Analytics.TransactionFailedParameters transactionParameters);
                    void ClientDevice(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier, string cpuType, string gpuType, long cpuCores, long ramTotal, long screenWidth, long screenHeight, long screenDPI);
                    void AcquisitionSource(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier, Unity.Services.Analytics.AcquisitionSourceParameters acquisitionSourceParameters);
                }

                class DataGenerator : Unity.Services.Analytics.Data.IDataGenerator
                {
                    /*0xf5f2e8*/ DataGenerator();
                    /*0xf6cb70*/ void SdkStartup(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier);
                    /*0xf6ce6c*/ void GameRunning(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier);
                    /*0xf6d010*/ void NewPlayer(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier, string deviceModel);
                    /*0xf6d244*/ void GameStarted(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier, string idLocalProject, string osVersion, bool isTiny, bool debugDevice, string userLocale);
                    /*0xf6d6b4*/ void GameEnded(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier, Unity.Services.Analytics.Data.DataGenerator.SessionEndState quitState);
                    /*0xf6d91c*/ void AdImpression(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier, Unity.Services.Analytics.AdImpressionParameters adImpressionParameters);
                    /*0xf6e4dc*/ void AcquisitionSource(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier, Unity.Services.Analytics.AcquisitionSourceParameters acquisitionSourceParameters);
                    /*0xf6ebb0*/ void Transaction(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier, Unity.Services.Analytics.TransactionParameters transactionParameters);
                    /*0xf706d0*/ void TransactionFailed(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier, Unity.Services.Analytics.TransactionFailedParameters parameters);
                    /*0xf7143c*/ void ClientDevice(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier, string cpuType, string gpuType, long cpuCores, long ramTotal, long screenWidth, long screenHeight, long screenDPI);
                    /*0xf6f7d4*/ void SetProduct(ref Unity.Services.Analytics.Internal.IBuffer buf, string productName, Unity.Services.Analytics.Product product);

                    enum SessionEndState
                    {
                        PAUSED = 0,
                        KILLEDINBACKGROUND = 1,
                        KILLEDINFOREGROUND = 2,
                        QUIT = 3,
                    }
                }
            }
        }
    }
}
