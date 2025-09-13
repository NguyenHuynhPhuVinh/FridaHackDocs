class <Module>
{
}

class Ua2CoreInitializeCallback : Unity.Services.Core.Internal.IInitializablePackage
{
    static /*0x2874f6c*/ void Register();
    /*0x28750cc*/ Ua2CoreInitializeCallback();
    /*0x28750d4*/ System.Threading.Tasks.Task Initialize(Unity.Services.Core.Internal.CoreRegistry registry);

    struct <Initialize>d__1 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
        /*0x30*/ Unity.Services.Core.Internal.CoreRegistry registry;
        /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

        /*0xaf1f20*/ void MoveNext();
        /*0xaf1f28*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                static /*0x286a07c*/ AnalyticsService();
                static /*0x286a018*/ Unity.Services.Analytics.IAnalyticsService get_Instance();
            }

            class AnalyticsServiceInstance : Unity.Services.Analytics.IAnalyticsService
            {
                /*0x10*/ Unity.Services.Analytics.Internal.IConsentTracker ConsentTracker;
                /*0x18*/ Unity.Services.Analytics.Internal.IAnalyticsForgetter analyticsForgetter;
                /*0x20*/ Unity.Services.Authentication.Internal.IPlayerId <PlayerId>k__BackingField;
                /*0x28*/ Unity.Services.Core.Device.Internal.IInstallationId <InstallId>k__BackingField;
                /*0x30*/ string <CustomAnalyticsId>k__BackingField;
                /*0x38*/ Unity.Services.Analytics.Internal.IBuffer dataBuffer;
                /*0x40*/ Unity.Services.Analytics.Data.IDataGenerator dataGenerator;
                /*0x48*/ Unity.Services.Analytics.Internal.IDispatcher <dataDispatcher>k__BackingField;
                /*0x50*/ string m_CollectURL;
                /*0x58*/ string m_SessionID;
                /*0x60*/ Unity.Services.Analytics.Data.StdCommonParams m_CommonParams;
                /*0x68*/ string m_StartUpCallingId;
                /*0x70*/ Unity.Services.Analytics.Platform.IIDeviceIdentifiersInternal deviceIdentifiersInternal;
                /*0x78*/ bool <ServiceEnabled>k__BackingField;
                /*0x80*/ Unity.Services.Analytics.TransactionCurrencyConverter converter;

                /*0x286a0ec*/ AnalyticsServiceInstance();
                /*0x286a464*/ void OptOut();
                /*0x286aa7c*/ void Revoke();
                /*0x286a750*/ void RevokeWithForgetEvent();
                /*0x286ad8c*/ void ForgetMeEventUploaded();
                /*0x286ae40*/ Unity.Services.Authentication.Internal.IPlayerId get_PlayerId();
                /*0x286ae48*/ void set_PlayerId(Unity.Services.Authentication.Internal.IPlayerId value);
                /*0x286ae50*/ Unity.Services.Core.Device.Internal.IInstallationId get_InstallId();
                /*0x286ae58*/ void set_InstallId(Unity.Services.Core.Device.Internal.IInstallationId value);
                /*0x286ae60*/ string get_CustomAnalyticsId();
                /*0x286ae68*/ void set_CustomAnalyticsId(string value);
                /*0x286ae70*/ Unity.Services.Analytics.Internal.IDispatcher get_dataDispatcher();
                /*0x286ae78*/ void set_dataDispatcher(Unity.Services.Analytics.Internal.IDispatcher value);
                /*0x286ae80*/ bool get_ServiceEnabled();
                /*0x286b07c*/ void Flush();
                /*0x286b734*/ void SetDependencies(Unity.Services.Core.Device.Internal.IInstallationId installId, Unity.Services.Authentication.Internal.IPlayerId playerId, string environment, string customAnalyticsId);
                /*0x286b7dc*/ System.Threading.Tasks.Task Initialize(Unity.Services.Core.Device.Internal.IInstallationId installId, Unity.Services.Authentication.Internal.IPlayerId playerId, string environment, string customAnalyticsId);
                /*0x286b914*/ System.Threading.Tasks.Task InitializeUser();
                /*0x2869820*/ void Startup();
                /*0x286ba6c*/ void NewPlayerEvent();
                /*0x2869e3c*/ void GameEnded();
                /*0x2869bfc*/ void InternalTick();
                /*0x286bd60*/ void SetVariableCommonParams();
                /*0x286c258*/ void Transaction(Unity.Services.Analytics.TransactionParameters transactionParameters);
                /*0x286c56c*/ long ConvertCurrencyToMinorUnits(string currencyCode, double value);
                /*0x286c6fc*/ void TransactionFailed(Unity.Services.Analytics.TransactionFailedParameters parameters);

                struct <Initialize>d__43 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ Unity.Services.Analytics.AnalyticsServiceInstance <>4__this;
                    /*0x38*/ Unity.Services.Core.Device.Internal.IInstallationId installId;
                    /*0x40*/ Unity.Services.Authentication.Internal.IPlayerId playerId;
                    /*0x48*/ string environment;
                    /*0x50*/ string customAnalyticsId;
                    /*0x58*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                    /*0xaf1d38*/ void MoveNext();
                    /*0xaf1d40*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <InitializeUser>d__44 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ Unity.Services.Analytics.AnalyticsServiceInstance <>4__this;
                    /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter<Unity.Services.Analytics.Internal.GeoIPResponse> <>u__1;

                    /*0xaf1d4c*/ void MoveNext();
                    /*0xaf1d54*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
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

                /*0x286afec*/ TransactionCurrencyConverter();
                /*0x286c584*/ long Convert(string currencyCode, double value);
                /*0x2874c70*/ void LoadCurrencyCodeDictionary();
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
                void Transaction(Unity.Services.Analytics.TransactionParameters transactionParameters);
                void TransactionFailed(Unity.Services.Analytics.TransactionFailedParameters parameters);
                long ConvertCurrencyToMinorUnits(string currencyCode, double value);
            }

            class InternalNewPlayerHelper
            {
                /*0x10*/ Unity.Services.Core.Device.Internal.IInstallationId <InstallId>k__BackingField;

                /*0x286bbe8*/ InternalNewPlayerHelper(Unity.Services.Core.Device.Internal.IInstallationId installId);
                /*0x2874808*/ Unity.Services.Core.Device.Internal.IInstallationId get_InstallId();
                /*0x286bc70*/ bool IsNewPlayer();
                /*0x2874810*/ string ReadAnalyticsIdentifier();
                /*0x2874858*/ void WriteAnalyticsIdentifierToFile(string identifier);
            }

            class AnalyticsLifetime : UnityEngine.MonoBehaviour
            {
                /*0x18*/ float m_Time;

                /*0x286a010*/ AnalyticsLifetime();
                /*0x286967c*/ void Awake();
                /*0x2869b58*/ void Update();
                /*0x2869dd0*/ void OnDestroy();
            }

            class ContainerObject
            {
                static /*0x0*/ bool s_Created;
                static /*0x8*/ UnityEngine.GameObject s_Container;

                static /*0x286fabc*/ void Initialize();
                static /*0x286ac70*/ void DestroyContainer();
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
                /*0x8c*/ Unity.Services.Analytics.ConsentCheckExceptionReason <Reason>k__BackingField;

                /*0x286f100*/ ConsentCheckException(Unity.Services.Analytics.ConsentCheckExceptionReason reason, int errorCode, string message, System.Exception innerException);
                /*0x286f0f0*/ Unity.Services.Analytics.ConsentCheckExceptionReason get_Reason();
                /*0x286f0f8*/ void set_Reason(Unity.Services.Analytics.ConsentCheckExceptionReason value);
            }

            class SdkVersion
            {
                static /*0x0*/ string SDK_VERSION;

                static /*0x2874b64*/ SdkVersion();
            }

            namespace Internal
            {
                class Locale
                {
                    static /*0x28748b0*/ string CurrentLanguageCode();
                    static /*0x286ba20*/ string AnalyticsRegionLanguageCode();
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

                    /*0x2868e74*/ AnalyticsForgetter(string collectUrl, string userId, string timestamp, string callingMethod, System.Action successfulUploadCallback, Unity.Services.Analytics.Internal.IConsentTracker consentTracker);
                    /*0x2868e6c*/ Unity.Services.Analytics.Internal.IConsentTracker get_ConsentTracker();
                    /*0x286920c*/ void AttemptToForget();
                    /*0x28695e4*/ void UploadComplete(UnityEngine.AsyncOperation _);
                }

                interface IBuffer
                {
                    void set_UserID(string value);
                    string get_InstallID();
                    void set_InstallID(string value);
                    void set_PlayerID(string value);
                    void set_SessionID(string value);
                    string Serialize(System.Collections.Generic.List<Unity.Services.Analytics.Internal.Buffer.Token> tokens);
                    void InsertTokens(System.Collections.Generic.List<Unity.Services.Analytics.Internal.Buffer.Token> tokens);
                    void PushStartEvent(string name, System.DateTime datetime, System.Nullable<long> eventVersion, bool addPlayerIdsToEventBody);
                    void PushEndEvent();
                    void PushObjectStart(string name);
                    void PushObjectEnd();
                    void PushArrayStart(string name);
                    void PushArrayEnd();
                    void PushDouble(double val, string name);
                    void PushString(string val, string name);
                    void PushInt64(long val, string name);
                    void PushBool(bool val, string name);
                    void FlushToDisk();
                    void ClearDiskCache();
                    void ClearBuffer();
                    System.Collections.Generic.List<Unity.Services.Analytics.Internal.Buffer.Token> CloneTokens();
                }

                class Buffer : Unity.Services.Analytics.Internal.IBuffer
                {
                    /*0x10*/ string <UserID>k__BackingField;
                    /*0x18*/ string <SessionID>k__BackingField;
                    /*0x20*/ string <PlayerID>k__BackingField;
                    /*0x28*/ string <InstallID>k__BackingField;
                    /*0x30*/ System.Collections.Generic.List<Unity.Services.Analytics.Internal.Buffer.Token> m_Tokens;
                    /*0x38*/ string m_CacheFilePath;
                    /*0x40*/ long m_CacheFileMaximumSize;
                    /*0x48*/ int m_DiskCacheLastFlushedToken;
                    /*0x50*/ long m_DiskCacheSize;

                    static /*0x286ad00*/ string SaveDateTime(System.DateTime dateTime);
                    static /*0x286df44*/ System.DateTime ParseDateTime(string dateTime);
                    static /*0x286ca7c*/ bool CanUseDiskPersistence();
                    /*0x286aef8*/ Buffer();
                    /*0x286ca3c*/ string get_UserID();
                    /*0x286ca44*/ void set_UserID(string value);
                    /*0x286ca4c*/ string get_SessionID();
                    /*0x286ca54*/ void set_SessionID(string value);
                    /*0x286ca5c*/ string get_PlayerID();
                    /*0x286ca64*/ void set_PlayerID(string value);
                    /*0x286ca6c*/ string get_InstallID();
                    /*0x286ca74*/ void set_InstallID(string value);
                    /*0x286d0f4*/ System.Collections.Generic.List<Unity.Services.Analytics.Internal.Buffer.Token> CloneTokens();
                    /*0x286d19c*/ void InsertTokens(System.Collections.Generic.List<Unity.Services.Analytics.Internal.Buffer.Token> tokens);
                    /*0x286d200*/ string Serialize(System.Collections.Generic.List<Unity.Services.Analytics.Internal.Buffer.Token> tokens);
                    /*0x286defc*/ bool IsRequestOverSizeLimit(string data);
                    /*0x286e000*/ void PushStartEvent(string name, System.DateTime datetime, System.Nullable<long> eventVersion, bool addPlayerIdsToEventBody);
                    /*0x286e1b8*/ void PushEndEvent();
                    /*0x286e258*/ void PushObjectStart(string name);
                    /*0x286e2dc*/ void PushObjectEnd();
                    /*0x286e354*/ void PushArrayStart(string name);
                    /*0x286e3d8*/ void PushArrayEnd();
                    /*0x286e450*/ void PushDouble(double val, string name);
                    /*0x286e508*/ void PushString(string val, string name);
                    /*0x286e590*/ void PushInt64(long val, string name);
                    /*0x286e640*/ void PushBool(bool val, string name);
                    /*0x286e6f0*/ void FlushToDisk();
                    /*0x286d040*/ void ClearDiskCache();
                    /*0x286ed7c*/ void ClearBuffer();
                    /*0x286caec*/ void LoadFromDisk();
                    /*0x286eb1c*/ void WriteToken(System.IO.BinaryWriter writer, Unity.Services.Analytics.Internal.Buffer.Token token);
                    /*0x286edd8*/ Unity.Services.Analytics.Internal.Buffer.Token ReadToken(System.IO.BinaryReader reader);

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

                    /*0x286abc0*/ BufferRevoked();
                    /*0x286ef94*/ void set_UserID(string value);
                    /*0x286ef9c*/ string get_InstallID();
                    /*0x286efa4*/ void set_InstallID(string value);
                    /*0x286efac*/ void set_PlayerID(string value);
                    /*0x286efb4*/ void set_SessionID(string value);
                    /*0x286efbc*/ void ClearBuffer();
                    /*0x286efc0*/ void ClearDiskCache();
                    /*0x286efc4*/ System.Collections.Generic.List<Unity.Services.Analytics.Internal.Buffer.Token> CloneTokens();
                    /*0x286f030*/ void InsertTokens(System.Collections.Generic.List<Unity.Services.Analytics.Internal.Buffer.Token> tokens);
                    /*0x286f034*/ void FlushToDisk();
                    /*0x286f038*/ void PushArrayEnd();
                    /*0x286f03c*/ void PushArrayStart(string name);
                    /*0x286f040*/ void PushBool(bool val, string name);
                    /*0x286f044*/ void PushDouble(double val, string name);
                    /*0x286f048*/ void PushEndEvent();
                    /*0x286f04c*/ void PushInt64(long val, string name);
                    /*0x286f050*/ void PushObjectEnd();
                    /*0x286f054*/ void PushObjectStart(string name);
                    /*0x286f058*/ void PushStartEvent(string name, System.DateTime datetime, System.Nullable<long> eventVersion, bool addPlayerIdsToEventBody);
                    /*0x286f05c*/ void PushString(string val, string name);
                    /*0x286f060*/ string Serialize(System.Collections.Generic.List<Unity.Services.Analytics.Internal.Buffer.Token> tokens);
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
                    System.Collections.Generic.Dictionary<string, string> get_requiredHeaders();
                    void BeginOptOutProcess();
                    void FinishOptOutProcess();
                    bool IsGeoIpChecked();
                    bool IsConsentGiven();
                    bool IsConsentDenied();
                    bool IsOptingOutInProgress();
                    void SetDenyConsentToAll();
                }

                class Consent
                {
                    static /*0x286f0ac*/ string get_Pipl();
                }

                class ConsentTracker : Unity.Services.Analytics.Internal.IConsentTracker
                {
                    /*0x10*/ Unity.Services.Analytics.Internal.IGeoAPI m_GeoAPI;
                    /*0x18*/ Unity.Services.Analytics.Internal.ConsentStatus <optInPiplConsentStatus>k__BackingField;
                    /*0x1c*/ Unity.Services.Analytics.Internal.ConsentStatus <optOutConsentStatus>k__BackingField;
                    /*0x20*/ Unity.Services.Analytics.Internal.GeoIPResponse response;

                    /*0x286ae88*/ ConsentTracker();
                    /*0x286f138*/ Unity.Services.Analytics.Internal.ConsentStatus get_optInPiplConsentStatus();
                    /*0x286f140*/ void set_optInPiplConsentStatus(Unity.Services.Analytics.Internal.ConsentStatus value);
                    /*0x286f148*/ Unity.Services.Analytics.Internal.ConsentStatus get_optOutConsentStatus();
                    /*0x286f150*/ void set_optOutConsentStatus(Unity.Services.Analytics.Internal.ConsentStatus value);
                    /*0x286f158*/ System.Collections.Generic.Dictionary<string, string> get_piplHeaders();
                    /*0x286f24c*/ System.Collections.Generic.Dictionary<string, string> get_requiredHeaders();
                    /*0x286f430*/ System.Threading.Tasks.Task<Unity.Services.Analytics.Internal.GeoIPResponse> CheckGeoIP();
                    /*0x286f550*/ bool IsGeoIpChecked();
                    /*0x286f560*/ bool IsConsentGiven();
                    /*0x286f5fc*/ bool IsConsentGiven(string identifier);
                    /*0x286f678*/ bool IsConsentDenied();
                    /*0x286f708*/ bool IsOptingOutInProgress();
                    /*0x286f794*/ void BeginOptOutProcess();
                    /*0x286f848*/ void FinishOptOutProcess();
                    /*0x286f900*/ void SetDenyConsentToAll();
                    /*0x286f368*/ void ReadOptInPiplConsentStatus();
                    /*0x286f3cc*/ void ReadOptOutConsentStatus();
                    /*0x286f99c*/ System.Threading.Tasks.Task<Unity.Services.Analytics.Internal.GeoIPResponse> GetGeoIPResponse();
                    /*0x286f594*/ void ValidateConsentWasChecked();

                    struct <CheckGeoIP>d__18 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Unity.Services.Analytics.Internal.GeoIPResponse> <>t__builder;
                        /*0x30*/ Unity.Services.Analytics.Internal.ConsentTracker <>4__this;
                        /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter<Unity.Services.Analytics.Internal.GeoIPResponse> <>u__1;

                        /*0xaf1ec8*/ void MoveNext();
                        /*0xaf1ed0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <GetGeoIPResponse>d__32 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Unity.Services.Analytics.Internal.GeoIPResponse> <>t__builder;
                        /*0x30*/ Unity.Services.Analytics.Internal.ConsentTracker <>4__this;
                        /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter<Unity.Services.Analytics.Internal.GeoIPResponse> <>u__1;

                        /*0xaf1ed8*/ void MoveNext();
                        /*0xaf1ee0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                interface IGeoAPI
                {
                    System.Threading.Tasks.Task<Unity.Services.Analytics.Internal.GeoIPResponse> MakeRequest();
                }

                class GeoAPI : Unity.Services.Analytics.Internal.IGeoAPI
                {
                    /*0x10*/ string m_PrivacyEndpoint;

                    /*0x286f314*/ GeoAPI();
                    /*0x28746c0*/ System.Threading.Tasks.Task<Unity.Services.Analytics.Internal.GeoIPResponse> MakeRequest();

                    struct <MakeRequest>d__1 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Unity.Services.Analytics.Internal.GeoIPResponse> <>t__builder;
                        /*0x30*/ Unity.Services.Analytics.Internal.GeoAPI <>4__this;
                        /*0x38*/ UnityEngine.Networking.UnityWebRequestAsyncOperation <async>5__2;
                        /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                        /*0xaf1f10*/ void MoveNext();
                        /*0xaf1f18*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class GeoIPResponse
                {
                    /*0x10*/ string identifier;

                    /*0x2874800*/ GeoIPResponse();
                }

                interface IDispatcher
                {
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

                    /*0x286abd0*/ Dispatcher(Unity.Services.Analytics.Internal.IBuffer buffer, Unity.Services.Analytics.Internal.IWebRequestHelper webRequestHelper, Unity.Services.Analytics.Internal.IConsentTracker consentTracker);
                    /*0x2874384*/ string get_CollectUrl();
                    /*0x287438c*/ void set_CollectUrl(string value);
                    /*0x2874394*/ Unity.Services.Analytics.Internal.IConsentTracker get_ConsentTracker();
                    /*0x287439c*/ System.Threading.Tasks.Task Flush();
                    /*0x28744a0*/ byte[] SerializeBuffer(System.Collections.Generic.List<Unity.Services.Analytics.Internal.Buffer.Token> tokens);
                    /*0x28745a4*/ System.Threading.Tasks.Task FlushBufferToService();

                    struct <Flush>d__11 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                        /*0x30*/ Unity.Services.Analytics.Internal.Dispatcher <>4__this;
                        /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                        /*0xaf1ee8*/ void MoveNext();
                        /*0xaf1ef0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    class <>c__DisplayClass13_0
                    {
                        /*0x10*/ Unity.Services.Analytics.Internal.Dispatcher <>4__this;
                        /*0x18*/ System.Collections.Generic.List<Unity.Services.Analytics.Internal.Buffer.Token> tokens;
                        /*0x20*/ Unity.Services.Analytics.Internal.IWebRequest request;
                        /*0x28*/ System.Guid requestId;

                        /*0x287620c*/ <>c__DisplayClass13_0();
                        /*0x2876214*/ byte[] <FlushBufferToService>b__0();
                        /*0x2876234*/ void <FlushBufferToService>b__1(long responseCode);
                    }

                    struct <FlushBufferToService>d__13 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                        /*0x30*/ Unity.Services.Analytics.Internal.Dispatcher <>4__this;
                        /*0x38*/ Unity.Services.Analytics.Internal.Dispatcher.<> <>8__1;
                        /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter<System.Byte[]> <>u__1;

                        /*0xaf1efc*/ void MoveNext();
                        /*0xaf1f04*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                interface IWebRequest
                {
                    UnityEngine.Networking.UnityWebRequestAsyncOperation SendWebRequest();
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
                    /*0x286ca1c*/ AnalyticsWebRequest(string url, string method);
                    /*0x286ca24*/ UnityEngine.Networking.UnityWebRequestAsyncOperation Unity.Services.Analytics.Internal.IWebRequest.SendWebRequest();
                    /*0x286ca2c*/ void Unity.Services.Analytics.Internal.IWebRequest.SetRequestHeader(string key, string value);
                    /*0x286ca34*/ bool Unity.Services.Analytics.Internal.IWebRequest.get_isNetworkError();
                }

                class WebRequestHelper : Unity.Services.Analytics.Internal.IWebRequestHelper
                {
                    /*0x286abc8*/ WebRequestHelper();
                    /*0x28751d8*/ Unity.Services.Analytics.Internal.IWebRequest CreateWebRequest(string url, string method, byte[] postBytes);
                    /*0x28752b8*/ void SendWebRequest(Unity.Services.Analytics.Internal.IWebRequest request, System.Action<long> onCompleted);

                    class <>c__DisplayClass1_0
                    {
                        /*0x10*/ System.Action<long> onCompleted;
                        /*0x18*/ UnityEngine.Networking.UnityWebRequestAsyncOperation requestOp;

                        /*0x2875410*/ <>c__DisplayClass1_0();
                        /*0x2877cec*/ void <SendWebRequest>b__0(UnityEngine.AsyncOperation <p0>);
                    }
                }

                namespace Platform
                {
                    class UserCountry
                    {
                        static /*0x286c528*/ string Name();
                    }
                }
            }

            namespace Platform
            {
                class DebugDevice
                {
                    static /*0x286ba18*/ bool IsDebugDevice();
                }

                interface IIDeviceIdentifiersInternal
                {
                    string get_Idfv();
                }

                class DeviceIdentifiersInternal : Unity.Services.Analytics.Platform.IIDeviceIdentifiersInternal
                {
                    /*0x286afe4*/ DeviceIdentifiersInternal();
                    /*0x287437c*/ string get_Idfv();
                }

                class DeviceVolumeProvider
                {
                    static /*0x286bf70*/ System.Nullable<float> GetDeviceVolume();
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
                    static /*0x286aff4*/ string Name();
                    static /*0x2874abc*/ Unity.Services.Analytics.Platform.UA2PlatformCode GetPlatform();
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

                    /*0x286afdc*/ StdCommonParams();
                    /*0x2874bc8*/ string get_GameStoreID();
                    /*0x2874bd0*/ string get_GameBundleID();
                    /*0x2874bd8*/ void set_GameBundleID(string value);
                    /*0x2874be0*/ string get_Platform();
                    /*0x2874be8*/ void set_Platform(string value);
                    /*0x2874bf0*/ string get_UasUserID();
                    /*0x2874bf8*/ void set_UasUserID(string value);
                    /*0x2874c00*/ string get_Idfv();
                    /*0x2874c08*/ void set_Idfv(string value);
                    /*0x2874c10*/ System.Nullable<double> get_DeviceVolume();
                    /*0x2874c1c*/ void set_DeviceVolume(System.Nullable<double> value);
                    /*0x2874c24*/ System.Nullable<double> get_BatteryLoad();
                    /*0x2874c30*/ void set_BatteryLoad(System.Nullable<double> value);
                    /*0x2874c38*/ string get_BuildGuuid();
                    /*0x2874c40*/ void set_BuildGuuid(string value);
                    /*0x2874c48*/ string get_ClientVersion();
                    /*0x2874c50*/ void set_ClientVersion(string value);
                    /*0x2874c58*/ string get_UserCountry();
                    /*0x2874c60*/ string get_ProjectID();
                    /*0x2874c68*/ void set_ProjectID(string value);
                    /*0x286febc*/ void SerializeCommonEventParams(ref Unity.Services.Analytics.Internal.IBuffer buf, string callingMethodIdentifier);
                }

                interface IDataGenerator
                {
                    void GameRunning(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier);
                    void SdkStartup(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier);
                    void NewPlayer(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier, string deviceModel);
                    void GameStarted(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier, string idLocalProject, string osVersion, bool isTiny, bool debugDevice, string userLocale);
                    void GameEnded(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier, Unity.Services.Analytics.Data.DataGenerator.SessionEndState quitState);
                    void Transaction(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier, Unity.Services.Analytics.TransactionParameters transactionParameters);
                    void TransactionFailed(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier, Unity.Services.Analytics.TransactionFailedParameters transactionParameters);
                    void ClientDevice(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier, string cpuType, string gpuType, long cpuCores, long ramTotal, long screenWidth, long screenHeight, long screenDPI);
                }

                class DataGenerator : Unity.Services.Analytics.Data.IDataGenerator
                {
                    /*0x286afd4*/ DataGenerator();
                    /*0x286fb94*/ void SdkStartup(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier);
                    /*0x287073c*/ void GameRunning(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier);
                    /*0x28708fc*/ void NewPlayer(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier, string deviceModel);
                    /*0x2870b4c*/ void GameStarted(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier, string idLocalProject, string osVersion, bool isTiny, bool debugDevice, string userLocale);
                    /*0x2870ff8*/ void GameEnded(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier, Unity.Services.Analytics.Data.DataGenerator.SessionEndState quitState);
                    /*0x2871290*/ void Transaction(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier, Unity.Services.Analytics.TransactionParameters transactionParameters);
                    /*0x2872f70*/ void TransactionFailed(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier, Unity.Services.Analytics.TransactionFailedParameters parameters);
                    /*0x2873dc8*/ void ClientDevice(ref Unity.Services.Analytics.Internal.IBuffer buf, System.DateTime datetime, Unity.Services.Analytics.Data.StdCommonParams commonParams, string callingMethodIdentifier, string cpuType, string gpuType, long cpuCores, long ramTotal, long screenWidth, long screenHeight, long screenDPI);
                    /*0x2871f88*/ void SetProduct(ref Unity.Services.Analytics.Internal.IBuffer buf, string productName, Unity.Services.Analytics.Product product);

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
