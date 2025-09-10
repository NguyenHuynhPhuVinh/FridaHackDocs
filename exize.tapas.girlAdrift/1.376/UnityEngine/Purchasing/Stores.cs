class <Module>
{
}

class <>f__AnonymousType0<<product>j__TPar, <metadata>j__TPar>
{
    /*0x0*/ <product> <product>i__Field;
    /*0x0*/ <metadata> <metadata>i__Field;

    <>f__AnonymousType0(<product> product, <metadata> metadata);
    <product> get_product();
    <metadata> get_metadata();
    bool Equals(object value);
    int GetHashCode();
    string ToString();
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x199066c*/ EmbeddedAttribute();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class NullableAttribute : System.Attribute
            {
                /*0x10*/ byte[] NullableFlags;

                /*0x1990674*/ NullableAttribute(byte );
                /*0x19906f4*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x199071c*/ NullableContextAttribute(byte );
            }
        }
    }
}

namespace Uniject
{
    interface IUtil
    {
        UnityEngine.RuntimePlatform get_platform();
        bool get_isEditor();
        string get_persistentDataPath();
        string get_cloudProjectId();
        string get_deviceUniqueIdentifier();
        string get_unityVersion();
        string get_userId();
        string get_gameVersion();
        ulong get_sessionId();
        System.DateTime get_currentTime();
        string get_deviceModel();
        string get_deviceName();
        UnityEngine.DeviceType get_deviceType();
        string get_operatingSystem();
        int get_screenWidth();
        int get_screenHeight();
        float get_screenDpi();
        string get_screenOrientation();
        T[] GetAnyComponentsOfType<T>();
        object InitiateCoroutine(System.Collections.IEnumerator start);
        object GetWaitForSeconds(int seconds);
        void InitiateCoroutine(System.Collections.IEnumerator start, int delayInSeconds);
        void RunOnMainThread(System.Action runnable);
        void AddPauseListener(System.Action<bool> runnable);
        bool IsClassOrSubclass(System.Type potentialBase, System.Type potentialDescendant);
    }
}

namespace UnityEngine
{
    namespace Purchasing
    {
        class AmazonApps
        {
            static string Name = "AmazonApps";

            /*0x1990744*/ AmazonApps();
        }

        class AmazonAppStoreStoreExtensions : UnityEngine.Purchasing.IAmazonExtensions, UnityEngine.Purchasing.IStoreExtension, UnityEngine.Purchasing.IAmazonConfiguration, UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
            /*0x10*/ UnityEngine.AndroidJavaObject android;

            /*0x199074c*/ AmazonAppStoreStoreExtensions(UnityEngine.AndroidJavaObject a);
            /*0x1990774*/ void WriteSandboxJSON(System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x1990bcc*/ void NotifyUnableToFulfillUnavailableProduct(string transactionID);
            /*0x1990c90*/ string get_amazonUserId();
        }

        class FakeAmazonExtensions : UnityEngine.Purchasing.IAmazonExtensions, UnityEngine.Purchasing.IStoreExtension, UnityEngine.Purchasing.IAmazonConfiguration, UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
            /*0x1990d98*/ FakeAmazonExtensions();
            /*0x1990d50*/ void WriteSandboxJSON(System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x1990d54*/ void NotifyUnableToFulfillUnavailableProduct(string transactionID);
            /*0x1990d58*/ string get_amazonUserId();
        }

        interface IAmazonConfiguration : UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
            void WriteSandboxJSON(System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> products);
        }

        interface IAmazonExtensions : UnityEngine.Purchasing.IStoreExtension
        {
            string get_amazonUserId();
            void NotifyUnableToFulfillUnavailableProduct(string transactionID);
        }

        class AndroidJavaStore : UnityEngine.Purchasing.INativeStore
        {
            /*0x10*/ UnityEngine.AndroidJavaObject m_Store;

            /*0x1990da8*/ AndroidJavaStore(UnityEngine.AndroidJavaObject store);
            /*0x1990da0*/ UnityEngine.AndroidJavaObject GetStore();
            /*0x1990dd0*/ void RetrieveProducts(string json);
            /*0x1990e94*/ void Purchase(string productJSON, string developerPayload);
            /*0x1990f84*/ void FinishTransaction(string productJSON, string transactionID);
        }

        enum AndroidStore
        {
            GooglePlay = 0,
            AmazonAppStore = 1,
            UDP = 2,
            NotSpecified = 3,
        }

        enum AndroidStoreMeta
        {
            AndroidStoreStart = 0,
            AndroidStoreEnd = 2,
        }

        class ListExtension
        {
            static /*0x1991074*/ UnityEngine.AndroidJavaObject ToJava(System.Collections.Generic.List<string> values);
            static /*0x1991078*/ UnityEngine.AndroidJavaObject ToJavaArray(System.Collections.Generic.List<string> values);
        }

        class UnityActivity
        {
            static string k_AndroidClassName = "com.unity3d.player.UnityPlayer";

            static /*0x1991310*/ UnityEngine.AndroidJavaClass GetUnityPlayerClass();
            static /*0x1991384*/ UnityEngine.AndroidJavaObject GetCurrentActivity();
            /*0x19913e0*/ UnityActivity();
        }

        class GoogleCachedQuerySkuDetailsService : UnityEngine.Purchasing.IGoogleCachedQuerySkuDetailsService
        {
            /*0x10*/ System.Collections.Generic.Dictionary<string, UnityEngine.AndroidJavaObject> m_CachedQueriedSkus;

            /*0x1991a64*/ GoogleCachedQuerySkuDetailsService();
            /*0x19913e8*/ System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedSkus();
            /*0x1991438*/ UnityEngine.AndroidJavaObject GetCachedQueriedSku(string sku);
            /*0x1991490*/ System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedSkus(System.Collections.Generic.IEnumerable<string> skus);
            /*0x1991534*/ System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedSkus(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x1991640*/ bool Contains(string sku);
            /*0x1991698*/ bool Contains(UnityEngine.Purchasing.ProductDefinition products);
            /*0x19916b0*/ void AddCachedQueriedSkus(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> queriedSkus);

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.GoogleCachedQuerySkuDetailsService.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.Purchasing.ProductDefinition, string> <>9__4_0;

                static /*0x1991ae0*/ <>c();
                /*0x1991b44*/ <>c();
                /*0x1991b4c*/ string <GetCachedQueriedSkus>b__4_0(UnityEngine.Purchasing.ProductDefinition product);
            }
        }

        class GoogleFinishTransactionService : UnityEngine.Purchasing.Interfaces.IGoogleFinishTransactionService
        {
            /*0x10*/ UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient;
            /*0x18*/ UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService m_GoogleQueryPurchasesService;

            /*0x1991b64*/ GoogleFinishTransactionService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService googleQueryPurchasesService);
            /*0x1991b90*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished);
            /*0x1991c44*/ System.Threading.Tasks.Task<UnityEngine.Purchasing.Interfaces.IGooglePurchase> FindPurchase(string purchaseToken);
            /*0x1991d3c*/ void FinishTransactionForPurchase(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, UnityEngine.Purchasing.ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished);

            struct <FinishTransaction>d__3 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                /*0x38*/ UnityEngine.Purchasing.GoogleFinishTransactionService <>4__this;
                /*0x40*/ string purchaseToken;
                /*0x48*/ UnityEngine.Purchasing.ProductDefinition product;
                /*0x50*/ System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished;
                /*0x58*/ System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Purchasing.Interfaces.IGooglePurchase> <>u__1;

                /*0x1991fa0*/ void MoveNext();
                /*0x1992288*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ string purchaseToken;

                /*0x1992294*/ <>c__DisplayClass4_0();
                /*0x199229c*/ bool <FindPurchase>b__0(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase);
            }

            struct <FindPurchase>d__4 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<UnityEngine.Purchasing.Interfaces.IGooglePurchase> <>t__builder;
                /*0x30*/ string purchaseToken;
                /*0x38*/ UnityEngine.Purchasing.GoogleFinishTransactionService <>4__this;
                /*0x40*/ UnityEngine.Purchasing.GoogleFinishTransactionService.<> <>8__1;
                /*0x48*/ System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>u__1;

                /*0x199234c*/ void MoveNext();
                /*0x1992698*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished;
                /*0x18*/ UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase;

                /*0x1991f98*/ <>c__DisplayClass5_0();
                /*0x19926f0*/ void <FinishTransactionForPurchase>b__0(UnityEngine.Purchasing.Models.IGoogleBillingResult result);
                /*0x1992718*/ void <FinishTransactionForPurchase>b__1(UnityEngine.Purchasing.Models.IGoogleBillingResult result);
            }
        }

        class GoogleLastKnownProductService : UnityEngine.Purchasing.Interfaces.IGoogleLastKnownProductService
        {
            /*0x10*/ string <LastKnownOldProductId>k__BackingField;
            /*0x18*/ string <LastKnownProductId>k__BackingField;
            /*0x20*/ System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> <LastKnownProrationMode>k__BackingField;

            /*0x1992770*/ GoogleLastKnownProductService();
            /*0x1992740*/ string get_LastKnownOldProductId();
            /*0x1992748*/ void set_LastKnownOldProductId(string value);
            /*0x1992750*/ string get_LastKnownProductId();
            /*0x1992758*/ void set_LastKnownProductId(string value);
            /*0x1992760*/ System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> get_LastKnownProrationMode();
            /*0x1992768*/ void set_LastKnownProrationMode(System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> value);
        }

        class GooglePlayStoreService : UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService
        {
            static int k_MaxConnectionAttempts = 1;
            /*0x10*/ int m_CurrentConnectionAttempts;
            /*0x18*/ UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient;
            /*0x20*/ UnityEngine.Purchasing.Interfaces.IBillingClientStateListener m_BillingClientStateListener;
            /*0x28*/ UnityEngine.Purchasing.Interfaces.IQuerySkuDetailsService m_QuerySkuDetailsService;
            /*0x30*/ System.Collections.Generic.Queue<UnityEngine.Purchasing.Models.ProductDescriptionQuery> m_ProductsToQuery;
            /*0x38*/ System.Collections.Concurrent.ConcurrentQueue<System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>>> m_OnPurchaseSucceededQueue;
            /*0x40*/ UnityEngine.Purchasing.Interfaces.IGooglePurchaseService m_GooglePurchaseService;
            /*0x48*/ UnityEngine.Purchasing.Interfaces.IGoogleFinishTransactionService m_GoogleFinishTransactionService;
            /*0x50*/ UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService m_GoogleQueryPurchasesService;
            /*0x58*/ UnityEngine.Purchasing.IGooglePriceChangeService m_GooglePriceChangeService;
            /*0x60*/ UnityEngine.Purchasing.Interfaces.IGoogleLastKnownProductService m_GoogleLastKnownProductService;
            /*0x68*/ UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics;
            /*0x70*/ UnityEngine.ILogger m_Logger;

            /*0x19927e0*/ GooglePlayStoreService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, UnityEngine.Purchasing.Interfaces.IQuerySkuDetailsService querySkuDetailsService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseService purchaseService, UnityEngine.Purchasing.Interfaces.IGoogleFinishTransactionService finishTransactionService, UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService queryPurchasesService, UnityEngine.Purchasing.Interfaces.IBillingClientStateListener billingClientStateListener, UnityEngine.Purchasing.IGooglePriceChangeService priceChangeService, UnityEngine.Purchasing.Interfaces.IGoogleLastKnownProductService lastKnownProductService, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics, UnityEngine.ILogger logger);
            /*0x1992910*/ void InitConnectionWithGooglePlay();
            /*0x1992aa8*/ void StartConnection();
            /*0x1992b5c*/ void ResumeConnection();
            /*0x1992c18*/ bool IsConnectionReady();
            /*0x1992cbc*/ void OnConnected();
            /*0x1992cf0*/ void DequeueQueryProducts();
            /*0x1993108*/ void DequeueFetchPurchases();
            /*0x1993218*/ void OnDisconnected();
            /*0x1993260*/ void AttemptReconnection();
            /*0x19930f8*/ bool AreConnectionAttemptsExhausted();
            /*0x1993280*/ void OnReconnectionFailure();
            /*0x1993290*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason> onRetrieveProductsFailed);
            /*0x19933f0*/ void HandleRetrieveProductsNotConnected(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason> onRetrieveProductsFailed);
            /*0x1993530*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product);
            /*0x1993548*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode);
            /*0x1993780*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished);
            /*0x199317c*/ void FetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed);
            /*0x1993840*/ System.Threading.Tasks.Task TryFetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed);
            /*0x199391c*/ void SetObfuscatedAccountId(string obfuscatedAccountId);
            /*0x19939c8*/ void SetObfuscatedProfileId(string obfuscatedProfileId);
            /*0x1993a74*/ void ConfirmSubscriptionPriceChange(UnityEngine.Purchasing.ProductDefinition product, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onPriceChangeAction);

            struct <FetchPurchases>d__31 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                /*0x38*/ UnityEngine.Purchasing.GooglePlayStoreService <>4__this;
                /*0x40*/ System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed;
                /*0x48*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                /*0x1993b2c*/ void MoveNext();
                /*0x1993dd8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <TryFetchPurchases>d__32 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed;
                /*0x38*/ UnityEngine.Purchasing.GooglePlayStoreService <>4__this;
                /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>u__1;

                /*0x1993de4*/ void MoveNext();
                /*0x199413c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class GooglePriceChangeService : UnityEngine.Purchasing.IGooglePriceChangeService
        {
            /*0x10*/ UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient;
            /*0x18*/ UnityEngine.Purchasing.Interfaces.IQuerySkuDetailsService m_QuerySkuDetailsService;

            /*0x1994148*/ GooglePriceChangeService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, UnityEngine.Purchasing.Interfaces.IQuerySkuDetailsService querySkuDetailsService);
            /*0x1994174*/ void PriceChange(UnityEngine.Purchasing.ProductDefinition product, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onPriceChangedListener);

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Purchasing.GooglePriceChangeService <>4__this;
                /*0x18*/ System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onPriceChangedListener;

                /*0x19942a4*/ <>c__DisplayClass3_0();
                /*0x19942ac*/ void <PriceChange>b__0(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> skuDetailsList);
            }
        }

        class GooglePurchaseService : UnityEngine.Purchasing.Interfaces.IGooglePurchaseService
        {
            /*0x10*/ UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient;
            /*0x18*/ UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback m_GooglePurchaseCallback;
            /*0x20*/ UnityEngine.Purchasing.Interfaces.IQuerySkuDetailsService m_QuerySkuDetailsService;

            static /*0x1994bf0*/ void VerifyAndWarnIfMoreThanOneSku(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> skus);
            /*0x1994554*/ GooglePurchaseService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback googlePurchaseCallback, UnityEngine.Purchasing.Interfaces.IQuerySkuDetailsService querySkuDetailsService);
            /*0x1994590*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode);
            /*0x19946d8*/ void OnQuerySkuDetailsResponse(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> skus, UnityEngine.Purchasing.ProductDefinition productToBuy, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode);
            /*0x199478c*/ bool ValidateQuerySkuDetailsResponseParams(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> skus, UnityEngine.Purchasing.ProductDefinition productToBuy, UnityEngine.Purchasing.Product oldProduct);
            /*0x1994908*/ bool ValidateSkus(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> skus);
            /*0x1994960*/ void PurchaseFailedSkuNotFound(UnityEngine.Purchasing.ProductDefinition productToBuy);
            /*0x1994a60*/ bool ValidateOldProduct(UnityEngine.Purchasing.Product oldProduct);
            /*0x1994ab8*/ void PurchaseFailedInvalidOldProduct(UnityEngine.Purchasing.ProductDefinition productToBuy, UnityEngine.Purchasing.Product oldProduct);
            /*0x19947ec*/ void LaunchGoogleBillingFlow(UnityEngine.AndroidJavaObject productToPurchase, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode);
            /*0x1994d48*/ void HandleBillingFlowResult(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, UnityEngine.AndroidJavaObject sku);

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.Purchasing.GooglePurchaseService <>4__this;
                /*0x18*/ UnityEngine.Purchasing.ProductDefinition product;
                /*0x20*/ UnityEngine.Purchasing.Product oldProduct;
                /*0x28*/ System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode;

                /*0x19946d0*/ <>c__DisplayClass4_0();
                /*0x1994fb4*/ void <Purchase>b__0(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> skus);
            }
        }

        class GoogleQueryPurchasesService : UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService
        {
            /*0x10*/ UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient;
            /*0x18*/ UnityEngine.Purchasing.Interfaces.IGooglePurchaseBuilder m_PurchaseBuilder;

            static /*0x199528c*/ bool IsResultOk(UnityEngine.Purchasing.Models.IGoogleBillingResult result);
            /*0x1994fd8*/ GoogleQueryPurchasesService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, UnityEngine.Purchasing.Interfaces.IGooglePurchaseBuilder purchaseBuilder);
            /*0x1995004*/ System.Threading.Tasks.Task<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> QueryPurchases();
            /*0x19950f4*/ System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> QueryPurchasesWithSkuType(string skuType);

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.GoogleQueryPurchasesService.<> <>9;
                static /*0x8*/ System.Func<System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>9__3_0;

                static /*0x1995334*/ <>c();
                /*0x1995398*/ <>c();
                /*0x19953a0*/ System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> <QueryPurchases>b__3_0(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> result);
            }

            struct <QueryPurchases>d__3 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>t__builder;
                /*0x30*/ UnityEngine.Purchasing.GoogleQueryPurchasesService <>4__this;
                /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>[]> <>u__1;

                /*0x19953a8*/ void MoveNext();
                /*0x19957ac*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.Purchasing.GoogleQueryPurchasesService <>4__this;
                /*0x18*/ System.Threading.Tasks.TaskCompletionSource<System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> taskCompletion;

                /*0x1995284*/ <>c__DisplayClass4_0();
                /*0x1995804*/ void <QueryPurchasesWithSkuType>b__0(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper> purchases);
            }
        }

        interface IGoogleCachedQuerySkuDetailsService
        {
            System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedSkus();
            System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedSkus(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products);
            bool Contains(UnityEngine.Purchasing.ProductDefinition products);
            void AddCachedQueriedSkus(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> queriedSkus);
        }

        interface IGooglePriceChangeService
        {
            void PriceChange(UnityEngine.Purchasing.ProductDefinition product, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onPriceChangedListener);
        }

        class BillingClientStateListener : UnityEngine.AndroidJavaProxy, UnityEngine.Purchasing.Interfaces.IBillingClientStateListener
        {
            static string k_AndroidBillingClientStateListenerClassName = "com.android.billingclient.api.BillingClientStateListener";
            /*0x20*/ System.Action m_OnConnected;
            /*0x28*/ System.Action m_Disconnect;

            /*0x199594c*/ BillingClientStateListener();
            /*0x19959bc*/ void RegisterOnConnected(System.Action onConnected);
            /*0x19959c4*/ void RegisterOnDisconnected(System.Action onDisconnected);
            /*0x19959cc*/ void onBillingSetupFinished(UnityEngine.AndroidJavaObject billingResult);
            /*0x1995ac4*/ void onBillingServiceDisconnected();
        }

        class GoogleAcknowledgePurchaseListener : UnityEngine.AndroidJavaProxy
        {
            static string k_AndroidAcknowledgePurchaseResponseListenerClassName = "com.android.billingclient.api.AcknowledgePurchaseResponseListener";
            /*0x20*/ System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> m_OnAcknowledgePurchaseResponse;

            /*0x1995ae8*/ GoogleAcknowledgePurchaseListener(System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onAcknowledgePurchaseResponseAction);
            /*0x1995b6c*/ void onAcknowledgePurchaseResponse(UnityEngine.AndroidJavaObject billingResult);
        }

        class GoogleConsumeResponseListener : UnityEngine.AndroidJavaProxy
        {
            static string k_AndroidConsumeResponseListenerClassName = "com.android.billingclient.api.ConsumeResponseListener";
            /*0x20*/ System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> m_OnConsumeResponse;

            /*0x1995bf0*/ GoogleConsumeResponseListener(System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onConsumeResponseAction);
            /*0x1995c74*/ void onConsumeResponse(UnityEngine.AndroidJavaObject billingResult, string purchaseToken);
        }

        class GooglePriceChangeConfirmationListener : UnityEngine.AndroidJavaProxy
        {
            static string k_AndroidPriceChangeConfirmationListenerClassName = "com.android.billingclient.api.PriceChangeConfirmationListener";
            /*0x20*/ System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> m_OnPriceChangeConfirmationResult;

            /*0x19944d0*/ GooglePriceChangeConfirmationListener(System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onPriceChangeConfirmationResult);
            /*0x1995cf8*/ void onPriceChangeConfirmationResult(UnityEngine.AndroidJavaObject javaBillingResult);
        }

        class GooglePurchasesResponseListener : UnityEngine.AndroidJavaProxy
        {
            static string k_AndroidSkuDetailsResponseListenerClassName = "com.android.billingclient.api.PurchasesResponseListener";
            /*0x20*/ System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper>> m_OnQueryPurchasesResponse;

            /*0x1995d7c*/ GooglePurchasesResponseListener(System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper>> onQueryPurchasesResponse);
            /*0x1995e00*/ void onQueryPurchasesResponse(UnityEngine.AndroidJavaObject billingResult, UnityEngine.AndroidJavaObject purchases);
        }

        class GooglePurchaseUpdatedListener : UnityEngine.AndroidJavaProxy, UnityEngine.Purchasing.Interfaces.IGooglePurchaseUpdatedListener
        {
            static string k_AndroidPurchaseListenerClassName = "com.android.billingclient.api.PurchasesUpdatedListener";
            /*0x20*/ UnityEngine.Purchasing.Interfaces.IGoogleLastKnownProductService m_LastKnownProductService;
            /*0x28*/ UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback m_GooglePurchaseCallback;
            /*0x30*/ UnityEngine.Purchasing.Interfaces.IGooglePurchaseBuilder m_PurchaseBuilder;
            /*0x38*/ UnityEngine.Purchasing.IGoogleCachedQuerySkuDetailsService m_GoogleCachedQuerySkuDetailsService;
            /*0x40*/ UnityEngine.Purchasing.Interfaces.IGooglePurchaseStateEnumProvider m_GooglePurchaseStateEnumProvider;
            /*0x48*/ UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService m_GoogleQueryPurchasesService;

            /*0x1995e98*/ GooglePurchaseUpdatedListener(UnityEngine.Purchasing.Interfaces.IGoogleLastKnownProductService googleLastKnownProductService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback googlePurchaseCallback, UnityEngine.Purchasing.Interfaces.IGooglePurchaseBuilder purchaseBuilder, UnityEngine.Purchasing.IGoogleCachedQuerySkuDetailsService googleCachedQuerySkuDetailsService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider, UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService googleQueryPurchasesService);
            /*0x1995f48*/ void SetGoogleQueryPurchaseService(UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService googleFetchPurchases);
            /*0x1995f50*/ void onPurchasesUpdated(UnityEngine.AndroidJavaObject billingResult, UnityEngine.AndroidJavaObject javaPurchasesList);
            /*0x1996070*/ void OnPurchasesUpdated(UnityEngine.Purchasing.Models.IGoogleBillingResult result, System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases);
            /*0x19962d8*/ void HandleResultOkCases(UnityEngine.Purchasing.Models.IGoogleBillingResult result, System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases);
            /*0x19964f8*/ void HandleErrorCases(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases);
            /*0x1996a98*/ void HandleUserCancelledPurchaseFailure(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult);
            /*0x1996eb4*/ void HandleUserCancelledPurchaseFailure(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> googlePurchases);
            /*0x19963a8*/ void ApplyOnPurchases(System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases, System.Action<UnityEngine.Purchasing.Interfaces.IGooglePurchase> action);
            /*0x1996b34*/ void ApplyOnPurchases(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases, UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Action<UnityEngine.Purchasing.Interfaces.IGooglePurchase, string> action);
            /*0x1996ffc*/ void OnPurchaseOk(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase);
            /*0x1997658*/ void HandlePurchasedProduct(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase);
            /*0x19978e8*/ bool IsDeferredSubscriptionChange(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase);
            /*0x1997a30*/ bool IsLastProrationModeDeferred();
            /*0x1997474*/ void OnPurchaseCancelled(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult);
            /*0x1997b08*/ void OnPurchaseCancelled(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase);
            /*0x1997c7c*/ void OnPurchaseAlreadyOwned(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase);
            /*0x1997df0*/ void OnPurchaseFailed(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase, string debugMessage);
            /*0x1997f84*/ bool <HandleUserCancelledPurchaseFailure>b__14_0(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase);

            struct <HandleUserCancelledPurchaseFailure>d__13 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                /*0x38*/ UnityEngine.Purchasing.GooglePurchaseUpdatedListener <>4__this;
                /*0x40*/ UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult;
                /*0x48*/ System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>u__1;

                /*0x19980b4*/ void MoveNext();
                /*0x1998308*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class SkuDetailsResponseListener : UnityEngine.AndroidJavaProxy
        {
            static string k_AndroidSkuDetailsResponseListenerClassName = "com.android.billingclient.api.SkuDetailsResponseListener";
            /*0x20*/ System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> m_OnSkuDetailsResponse;
            /*0x28*/ Uniject.IUtil m_Util;

            /*0x1998314*/ SkuDetailsResponseListener(System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onSkuDetailsResponseAction, Uniject.IUtil util);
            /*0x199839c*/ void onSkuDetailsResponse(UnityEngine.AndroidJavaObject billingResult, UnityEngine.AndroidJavaObject skuDetails);

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.AndroidJavaObject skuDetails;
                /*0x18*/ UnityEngine.Purchasing.SkuDetailsResponseListener <>4__this;
                /*0x20*/ UnityEngine.AndroidJavaObject billingResult;

                /*0x19984d0*/ <>c__DisplayClass4_0();
                /*0x19984d8*/ void <onSkuDetailsResponse>b__0();
            }
        }

        class MetricizedGooglePlayStoreService : UnityEngine.Purchasing.GooglePlayStoreService
        {
            /*0x78*/ UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics;
            /*0x80*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService m_TelemetryMetricsService;

            /*0x19985a8*/ MetricizedGooglePlayStoreService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, UnityEngine.Purchasing.Interfaces.IQuerySkuDetailsService querySkuDetailsService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseService purchaseService, UnityEngine.Purchasing.Interfaces.IGoogleFinishTransactionService finishTransactionService, UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService queryPurchasesService, UnityEngine.Purchasing.Interfaces.IBillingClientStateListener billingClientStateListener, UnityEngine.Purchasing.IGooglePriceChangeService priceChangeService, UnityEngine.Purchasing.Interfaces.IGoogleLastKnownProductService lastKnownProductService, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics, UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService telemetryMetricsService, UnityEngine.ILogger logger);
            /*0x19985e4*/ void DequeueQueryProducts();
            /*0x1998710*/ void DequeueFetchPurchases();
            /*0x199883c*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason> onRetrieveProductsFailed);
            /*0x19989b8*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode);
            /*0x1998b34*/ void ConfirmSubscriptionPriceChange(UnityEngine.Purchasing.ProductDefinition product, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onPriceChangeAction);
            /*0x1998ca4*/ void <>n__0(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason> onRetrieveProductsFailed);
            /*0x1998ca8*/ void <>n__1(UnityEngine.Purchasing.ProductDefinition product, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode);
            /*0x1998cac*/ void <>n__2(UnityEngine.Purchasing.ProductDefinition product, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onPriceChangeAction);

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedGooglePlayStoreService <>4__this;
                /*0x18*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;
                /*0x20*/ System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>> onProductsReceived;
                /*0x28*/ System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason> onRetrieveProductsFailed;

                /*0x19989b0*/ <>c__DisplayClass5_0();
                /*0x1998cb0*/ void <RetrieveProducts>b__0();
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedGooglePlayStoreService <>4__this;
                /*0x18*/ UnityEngine.Purchasing.ProductDefinition product;
                /*0x20*/ UnityEngine.Purchasing.Product oldProduct;
                /*0x28*/ System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode;

                /*0x1998b2c*/ <>c__DisplayClass6_0();
                /*0x1998cd4*/ void <Purchase>b__0();
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedGooglePlayStoreService <>4__this;
                /*0x18*/ UnityEngine.Purchasing.ProductDefinition product;
                /*0x20*/ System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onPriceChangeAction;

                /*0x1998c9c*/ <>c__DisplayClass7_0();
                /*0x1998cf8*/ void <ConfirmSubscriptionPriceChange>b__0();
            }
        }

        enum GoogleBillingConnectionState
        {
            Disconnected = 0,
            Connecting = 1,
            Connected = 2,
            Closed = 3,
        }

        class QuerySkuDetailsService : UnityEngine.Purchasing.Interfaces.IQuerySkuDetailsService
        {
            /*0x10*/ UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient;
            /*0x18*/ UnityEngine.Purchasing.IGoogleCachedQuerySkuDetailsService m_GoogleCachedQuerySkuDetailsService;
            /*0x20*/ UnityEngine.Purchasing.Interfaces.ISkuDetailsConverter m_SkuDetailsConverter;
            /*0x28*/ UnityEngine.Purchasing.Stores.Util.IRetryPolicy m_RetryPolicy;
            /*0x30*/ UnityEngine.Purchasing.Interfaces.IGoogleProductCallback m_GoogleProductCallback;

            /*0x1998d18*/ QuerySkuDetailsService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, UnityEngine.Purchasing.IGoogleCachedQuerySkuDetailsService googleCachedQuerySkuDetailsService, UnityEngine.Purchasing.Interfaces.ISkuDetailsConverter skuDetailsConverter, UnityEngine.Purchasing.Stores.Util.IRetryPolicy retryPolicy, UnityEngine.Purchasing.Interfaces.IGoogleProductCallback googleProductCallback);
            /*0x1998d68*/ void QueryAsyncSku(UnityEngine.Purchasing.ProductDefinition product, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onSkuDetailsResponse);
            /*0x1999000*/ void QueryAsyncSku(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>> onSkuDetailsResponse);
            /*0x1998e80*/ void QueryAsyncSku(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onSkuDetailsResponse);
            /*0x19990d4*/ void QueryAsyncSkuWithRetries(System.Collections.Generic.IReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onSkuDetailsResponse, System.Action retryQuery);
            /*0x1999664*/ bool ShouldRetryQuery(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> requestedProducts, UnityEngine.Purchasing.Interfaces.ISkuDetailsQueryResponse queryResponse);
            /*0x1999738*/ bool AreAllSkuDetailsCached(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x1999908*/ System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedSkuDetails(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x1999264*/ void QueryInAppsAsync(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products, UnityEngine.Purchasing.Interfaces.ISkuDetailsResponseConsolidator consolidator);
            /*0x1999464*/ void QuerySubsAsync(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products, UnityEngine.Purchasing.Interfaces.ISkuDetailsResponseConsolidator consolidator);
            /*0x1999a7c*/ void QuerySkuDetails(System.Collections.Generic.List<string> skus, string type, UnityEngine.Purchasing.Interfaces.ISkuDetailsResponseConsolidator consolidator);

            class <>c__DisplayClass7_0
            {
                /*0x10*/ System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>> onSkuDetailsResponse;
                /*0x18*/ UnityEngine.Purchasing.QuerySkuDetailsService <>4__this;

                /*0x19990c4*/ <>c__DisplayClass7_0();
                /*0x1999be4*/ void <QueryAsyncSku>b__0(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> skus);
            }

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.Purchasing.QuerySkuDetailsService <>4__this;
                /*0x18*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;
                /*0x20*/ System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onSkuDetailsResponse;
                /*0x28*/ int retryCount;

                /*0x19990cc*/ <>c__DisplayClass8_0();
                /*0x1999cb0*/ void <QueryAsyncSku>b__0(System.Action retryAction);
                /*0x1999cd4*/ void <QueryAsyncSku>g__OnActionRetry|1();
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ UnityEngine.Purchasing.QuerySkuDetailsService <>4__this;
                /*0x18*/ System.Collections.Generic.IReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;
                /*0x20*/ System.Action retryQuery;
                /*0x28*/ System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onSkuDetailsResponse;

                /*0x19991e4*/ <>c__DisplayClass9_0();
                /*0x1999d90*/ void <QueryAsyncSkuWithRetries>b__0(UnityEngine.Purchasing.Interfaces.ISkuDetailsQueryResponse skuDetailsQueryResponse);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.QuerySkuDetailsService.<> <>9;
                static /*0x8*/ System.Func<bool, bool> <>9__11_0;
                static /*0x10*/ System.Func<UnityEngine.Purchasing.ProductDefinition, bool> <>9__13_0;
                static /*0x18*/ System.Func<UnityEngine.Purchasing.ProductDefinition, string> <>9__13_1;
                static /*0x20*/ System.Func<UnityEngine.Purchasing.ProductDefinition, bool> <>9__14_0;
                static /*0x28*/ System.Func<UnityEngine.Purchasing.ProductDefinition, string> <>9__14_1;

                static /*0x1999f48*/ <>c();
                /*0x1999fac*/ <>c();
                /*0x1999fb4*/ bool <AreAllSkuDetailsCached>b__11_0(bool isCached);
                /*0x1999fbc*/ bool <QueryInAppsAsync>b__13_0(UnityEngine.Purchasing.ProductDefinition product);
                /*0x1999fdc*/ string <QueryInAppsAsync>b__13_1(UnityEngine.Purchasing.ProductDefinition product);
                /*0x1999ff4*/ bool <QuerySubsAsync>b__14_0(UnityEngine.Purchasing.ProductDefinition product);
                /*0x199a014*/ string <QuerySubsAsync>b__14_1(UnityEngine.Purchasing.ProductDefinition product);
            }
        }

        class SkuDetailsQueryResponse : UnityEngine.Purchasing.Interfaces.ISkuDetailsQueryResponse
        {
            /*0x10*/ System.Collections.Generic.List<System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>>> m_Responses;

            static /*0x199a458*/ bool IsRecoverable(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult);
            /*0x199a568*/ SkuDetailsQueryResponse();
            /*0x199a02c*/ void AddResponse(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> skuDetails);
            /*0x199a114*/ System.Collections.Generic.List<UnityEngine.AndroidJavaObject> SkuDetails();
            /*0x199a2e8*/ bool IsRecoverable();

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.SkuDetailsQueryResponse.<> <>9;
                static /*0x8*/ System.Func<System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>>, bool> <>9__2_0;
                static /*0x10*/ System.Func<System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>>, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> <>9__2_1;
                static /*0x18*/ System.Func<System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>>, UnityEngine.Purchasing.Models.IGoogleBillingResult> <>9__3_0;

                static /*0x199a5e4*/ <>c();
                /*0x199a648*/ <>c();
                /*0x199a650*/ bool <SkuDetails>b__2_0(System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> response);
                /*0x199a6f8*/ System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> <SkuDetails>b__2_1(System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> response);
                /*0x199a700*/ UnityEngine.Purchasing.Models.IGoogleBillingResult <IsRecoverable>b__3_0(System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> response);
            }
        }

        class SkuDetailsResponseConsolidator : UnityEngine.Purchasing.Interfaces.ISkuDetailsResponseConsolidator
        {
            static int k_RequiredNumberOfCallbacks = 2;
            /*0x10*/ int m_NumberReceivedCallbacks;
            /*0x18*/ System.Action<UnityEngine.Purchasing.Interfaces.ISkuDetailsQueryResponse> m_OnSkuDetailsResponseConsolidated;
            /*0x20*/ UnityEngine.Purchasing.Interfaces.ISkuDetailsQueryResponse m_Responses;

            /*0x19991ec*/ SkuDetailsResponseConsolidator(System.Action<UnityEngine.Purchasing.Interfaces.ISkuDetailsQueryResponse> onSkuDetailsResponseConsolidated);
            /*0x199a708*/ void Consolidate(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> skuDetails);
        }

        class FakeGooglePlayStoreConfiguration : UnityEngine.Purchasing.IGooglePlayConfiguration, UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
            /*0x199a820*/ FakeGooglePlayStoreConfiguration();
            /*0x199a804*/ void SetServiceDisconnectAtInitializeListener(System.Action action);
            /*0x199a808*/ void SetQueryProductDetailsFailedListener(System.Action<int> action);
            /*0x199a80c*/ void SetDeferredPurchaseListener(System.Action<UnityEngine.Purchasing.Product> action);
            /*0x199a810*/ void SetDeferredProrationUpgradeDowngradeSubscriptionListener(System.Action<UnityEngine.Purchasing.Product> action);
            /*0x199a814*/ void SetObfuscatedAccountId(string accountId);
            /*0x199a818*/ void SetObfuscatedProfileId(string profileId);
            /*0x199a81c*/ void SetFetchPurchasesAtInitialize(bool enable);
        }

        class FakeGooglePlayStoreExtensions : UnityEngine.Purchasing.IGooglePlayStoreExtensions, UnityEngine.Purchasing.IStoreExtension
        {
            /*0x199a844*/ FakeGooglePlayStoreExtensions();
            /*0x199a828*/ void UpgradeDowngradeSubscription(string oldSku, string newSku);
            /*0x199a82c*/ void UpgradeDowngradeSubscription(string oldSku, string newSku, int desiredProrationMode);
            /*0x199a830*/ void UpgradeDowngradeSubscription(string oldSku, string newSku, UnityEngine.Purchasing.GooglePlayProrationMode desiredProrationMode);
            /*0x199a834*/ void RestoreTransactions(System.Action<bool> callback);
            /*0x199a838*/ void ConfirmSubscriptionPriceChange(string productId, System.Action<bool> callback);
            /*0x199a83c*/ bool IsPurchasedProductDeferred(UnityEngine.Purchasing.Product product);
        }

        class GetGoogleProductMetadataExtension
        {
            static /*0x199a84c*/ UnityEngine.Purchasing.GoogleProductMetadata GetGoogleProductMetadata(UnityEngine.Purchasing.ProductMetadata productMetadata);
        }

        class GooglePlay
        {
            static string Name = "GooglePlay";

            /*0x199a93c*/ GooglePlay();
        }

        class GooglePlayConfiguration : UnityEngine.Purchasing.IGooglePlayConfiguration, UnityEngine.Purchasing.Extension.IStoreConfiguration, UnityEngine.Purchasing.IGooglePlayConfigurationInternal
        {
            /*0x10*/ System.Action m_InitializationConnectionLister;
            /*0x18*/ UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService;
            /*0x20*/ System.Action<UnityEngine.Purchasing.Product> m_DeferredPurchaseAction;
            /*0x28*/ System.Action<UnityEngine.Purchasing.Product> m_DeferredProrationUpgradeDowngradeSubscriptionAction;
            /*0x30*/ System.Action<int> m_QueryProductDetailsFailedListener;
            /*0x38*/ bool m_FetchPurchasesAtInitialize;

            /*0x199a944*/ GooglePlayConfiguration(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService);
            /*0x199a974*/ void SetServiceDisconnectAtInitializeListener(System.Action action);
            /*0x199a97c*/ void NotifyInitializationConnectionFailed();
            /*0x199a998*/ void SetQueryProductDetailsFailedListener(System.Action<int> action);
            /*0x199a9a0*/ void NotifyQueryProductDetailsFailed(int retryCount);
            /*0x199a9bc*/ void SetDeferredPurchaseListener(System.Action<UnityEngine.Purchasing.Product> action);
            /*0x199a9c4*/ void NotifyDeferredProrationUpgradeDowngradeSubscription(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback, string productId);
            /*0x199ab94*/ bool IsFetchPurchasesAtInitializeSkipped();
            /*0x199aba4*/ void NotifyDeferredPurchase(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback, UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, string receipt, string transactionId);
            /*0x199ace4*/ void SetDeferredProrationUpgradeDowngradeSubscriptionListener(System.Action<UnityEngine.Purchasing.Product> action);
            /*0x199acec*/ void SetObfuscatedAccountId(string accountId);
            /*0x199ad98*/ void SetObfuscatedProfileId(string profileId);
            /*0x199ae44*/ void SetFetchPurchasesAtInitialize(bool enable);
        }

        class GooglePlayProductCallback : UnityEngine.Purchasing.Interfaces.IGoogleProductCallback
        {
            /*0x10*/ UnityEngine.Purchasing.IGooglePlayConfigurationInternal m_GooglePlayConfigurationInternal;

            /*0x199af0c*/ GooglePlayProductCallback();
            /*0x199ae50*/ void SetStoreConfiguration(UnityEngine.Purchasing.IGooglePlayConfigurationInternal configuration);
            /*0x199ae58*/ void NotifyQueryProductDetailsFailed(int retryCount);
        }

        enum GooglePlayProrationMode
        {
            UnknownSubscriptionUpgradeDowngradePolicy = 0,
            ImmediateWithTimeProration = 1,
            ImmediateAndChargeProratedPrice = 2,
            ImmediateWithoutProration = 3,
            Deferred = 4,
            ImmediateAndChargeFullPrice = 5,
        }

        class GooglePlayPurchaseCallback : UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback
        {
            /*0x10*/ UnityEngine.Purchasing.Extension.IStoreCallback m_StoreCallback;
            /*0x18*/ UnityEngine.Purchasing.IGooglePlayConfigurationInternal m_GooglePlayConfigurationInternal;
            /*0x20*/ Uniject.IUtil m_Util;

            /*0x199af14*/ GooglePlayPurchaseCallback(Uniject.IUtil util);
            /*0x199af3c*/ void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
            /*0x199af44*/ void SetStoreConfiguration(UnityEngine.Purchasing.IGooglePlayConfigurationInternal configuration);
            /*0x199af4c*/ void OnPurchaseSuccessful(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, string receipt, string purchaseToken);
            /*0x199b098*/ void OnPurchaseFailed(UnityEngine.Purchasing.Extension.PurchaseFailureDescription purchaseFailureDescription);
            /*0x199b14c*/ void NotifyDeferredPurchase(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, string receipt, string purchaseToken);
            /*0x199b294*/ void NotifyDeferredProrationUpgradeDowngradeSubscription(string sku);

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.Purchasing.GooglePlayPurchaseCallback <>4__this;
                /*0x18*/ UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase;
                /*0x20*/ string receipt;
                /*0x28*/ string purchaseToken;

                /*0x199b28c*/ <>c__DisplayClass8_0();
                /*0x199b3c8*/ void <NotifyDeferredPurchase>b__0();
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ UnityEngine.Purchasing.GooglePlayPurchaseCallback <>4__this;
                /*0x18*/ string sku;

                /*0x199b3c0*/ <>c__DisplayClass9_0();
                /*0x199b4a8*/ void <NotifyDeferredProrationUpgradeDowngradeSubscription>b__0();
            }
        }

        class GooglePlayStore : UnityEngine.Purchasing.Extension.AbstractStore
        {
            /*0x10*/ UnityEngine.Purchasing.IGooglePlayStoreRetrieveProductsService m_RetrieveProductsService;
            /*0x18*/ UnityEngine.Purchasing.IGooglePlayStorePurchaseService m_StorePurchaseService;
            /*0x20*/ UnityEngine.Purchasing.IGoogleFetchPurchases m_FetchPurchases;
            /*0x28*/ UnityEngine.Purchasing.IGooglePlayStoreFinishTransactionService m_FinishTransactionService;
            /*0x30*/ UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback m_GooglePurchaseCallback;
            /*0x38*/ UnityEngine.Purchasing.IGooglePlayStoreExtensionsInternal m_GooglePlayStoreExtensions;
            /*0x40*/ UnityEngine.Purchasing.IGooglePlayConfigurationInternal m_GooglePlayConfigurationInternal;
            /*0x48*/ Uniject.IUtil m_Util;

            /*0x199b570*/ GooglePlayStore(UnityEngine.Purchasing.IGooglePlayStoreRetrieveProductsService retrieveProductsService, UnityEngine.Purchasing.IGooglePlayStorePurchaseService storePurchaseService, UnityEngine.Purchasing.IGoogleFetchPurchases fetchPurchases, UnityEngine.Purchasing.IGooglePlayStoreFinishTransactionService transactionService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback googlePurchaseCallback, UnityEngine.Purchasing.IGooglePlayConfigurationInternal googlePlayConfigurationInternal, UnityEngine.Purchasing.IGooglePlayStoreExtensionsInternal googlePlayStoreExtensions, Uniject.IUtil util);
            /*0x199b5d8*/ void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback callback);
            /*0x199b8c8*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x199ba48*/ bool HasInitiallyRetrievedProducts();
            /*0x199b984*/ bool ShouldFetchPurchasesNext();
            /*0x199baec*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, string dummy);
            /*0x199bb94*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId);
            /*0x199bc50*/ void OnPause(bool isPaused);
        }

        class GooglePlayStoreExtensions : UnityEngine.Purchasing.IGooglePlayStoreExtensions, UnityEngine.Purchasing.IStoreExtension, UnityEngine.Purchasing.IGooglePlayStoreExtensionsInternal
        {
            /*0x10*/ UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService;
            /*0x18*/ UnityEngine.Purchasing.IGooglePlayStoreFinishTransactionService m_GooglePlayStoreFinishTransactionService;
            /*0x20*/ UnityEngine.ILogger m_Logger;
            /*0x28*/ UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics;
            /*0x30*/ UnityEngine.Purchasing.Extension.IStoreCallback m_StoreCallback;
            /*0x38*/ System.Action<UnityEngine.Purchasing.Product> m_DeferredPurchaseAction;
            /*0x40*/ System.Action<UnityEngine.Purchasing.Product> m_DeferredProrationUpgradeDowngradeSubscriptionAction;

            /*0x199bd80*/ GooglePlayStoreExtensions(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService, UnityEngine.Purchasing.IGooglePlayStoreFinishTransactionService googlePlayStoreFinishTransactionService, UnityEngine.ILogger logger, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics);
            /*0x199bdc0*/ void UpgradeDowngradeSubscription(string oldSku, string newSku);
            /*0x199bdd0*/ void UpgradeDowngradeSubscription(string oldSku, string newSku, int desiredProrationMode);
            /*0x199bddc*/ void UpgradeDowngradeSubscription(string oldSku, string newSku, UnityEngine.Purchasing.GooglePlayProrationMode desiredProrationMode);
            /*0x199c10c*/ void RestoreTransactions(System.Action<bool> callback);
            /*0x199c268*/ void ConfirmSubscriptionPriceChange(string productId, System.Action<bool> callback);
            /*0x199c3c8*/ void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
            /*0x199c3d0*/ bool IsPurchasedProductDeferred(UnityEngine.Purchasing.Product product);

            class <>c__DisplayClass11_0
            {
                /*0x10*/ System.Action<bool> callback;

                /*0x199c260*/ <>c__DisplayClass11_0();
                /*0x199c7d4*/ void <RestoreTransactions>b__0(System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> _);
            }

            class <>c__DisplayClass12_0
            {
                /*0x10*/ System.Action<bool> callback;

                /*0x199c3c0*/ <>c__DisplayClass12_0();
                /*0x199c7f4*/ void <ConfirmSubscriptionPriceChange>b__0(UnityEngine.Purchasing.Models.IGoogleBillingResult result);
            }
        }

        interface IGooglePlayConfiguration : UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
            void SetServiceDisconnectAtInitializeListener(System.Action action);
            void SetQueryProductDetailsFailedListener(System.Action<int> action);
            void SetDeferredPurchaseListener(System.Action<UnityEngine.Purchasing.Product> action);
            void SetDeferredProrationUpgradeDowngradeSubscriptionListener(System.Action<UnityEngine.Purchasing.Product> action);
            void SetObfuscatedAccountId(string accountId);
            void SetObfuscatedProfileId(string profileId);
            void SetFetchPurchasesAtInitialize(bool enable);
        }

        interface IGooglePlayConfigurationInternal
        {
            void NotifyInitializationConnectionFailed();
            void NotifyDeferredPurchase(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback, UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, string receipt, string transactionId);
            void NotifyDeferredProrationUpgradeDowngradeSubscription(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback, string productId);
            bool IsFetchPurchasesAtInitializeSkipped();
            void NotifyQueryProductDetailsFailed(int retryCount);
        }

        interface IGooglePlayStoreExtensions : UnityEngine.Purchasing.IStoreExtension
        {
            void UpgradeDowngradeSubscription(string oldSku, string newSku);
            void UpgradeDowngradeSubscription(string oldSku, string newSku, int desiredProrationMode);
            void UpgradeDowngradeSubscription(string oldSku, string newSku, UnityEngine.Purchasing.GooglePlayProrationMode desiredProrationMode);
            void RestoreTransactions(System.Action<bool> callback);
            void ConfirmSubscriptionPriceChange(string productId, System.Action<bool> callback);
            bool IsPurchasedProductDeferred(UnityEngine.Purchasing.Product product);
        }

        interface IGooglePlayStoreExtensionsInternal
        {
            void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
        }

        interface IGoogleFetchPurchases
        {
            void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
            void FetchPurchases();
            void FetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> onQueryPurchaseSucceed);
        }

        interface IGooglePlayStoreFinishTransactionService
        {
            void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
            void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string purchaseToken);
        }

        interface IGooglePlayStorePurchaseService
        {
            void Purchase(UnityEngine.Purchasing.ProductDefinition product);
        }

        interface IGooglePlayStoreRetrieveProductsService
        {
            void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
            void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, bool wantPurchases);
            void ResumeConnection();
            bool HasInitiallyRetrievedProducts();
        }

        class MetricizedGooglePlayStoreExtensions : UnityEngine.Purchasing.GooglePlayStoreExtensions
        {
            /*0x48*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService m_TelemetryMetricsService;

            /*0x199c8b8*/ MetricizedGooglePlayStoreExtensions(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService, UnityEngine.Purchasing.IGooglePlayStoreFinishTransactionService googlePlayStoreFinishTransactionService, UnityEngine.ILogger logger, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics, UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService telemetryMetricsService);
            /*0x199c908*/ void UpgradeDowngradeSubscription(string oldSku, string newSku, UnityEngine.Purchasing.GooglePlayProrationMode desiredProrationMode);
            /*0x199ca88*/ void RestoreTransactions(System.Action<bool> callback);
            /*0x199cbf0*/ void <>n__0(string oldSku, string newSku, UnityEngine.Purchasing.GooglePlayProrationMode desiredProrationMode);
            /*0x199cbf4*/ void <>n__1(System.Action<bool> callback);

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedGooglePlayStoreExtensions <>4__this;
                /*0x18*/ string oldSku;
                /*0x20*/ string newSku;
                /*0x28*/ UnityEngine.Purchasing.GooglePlayProrationMode desiredProrationMode;

                /*0x199ca80*/ <>c__DisplayClass2_0();
                /*0x199cbf8*/ void <UpgradeDowngradeSubscription>b__0();
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedGooglePlayStoreExtensions <>4__this;
                /*0x18*/ System.Action<bool> callback;

                /*0x199cbe8*/ <>c__DisplayClass3_0();
                /*0x199cc1c*/ void <RestoreTransactions>b__0();
            }
        }

        class GoogleProductMetadata : UnityEngine.Purchasing.ProductMetadata
        {
            /*0x40*/ string <originalJson>k__BackingField;
            /*0x48*/ string <subscriptionPeriod>k__BackingField;
            /*0x50*/ string <freeTrialPeriod>k__BackingField;
            /*0x58*/ string <introductoryPrice>k__BackingField;
            /*0x60*/ string <introductoryPricePeriod>k__BackingField;
            /*0x68*/ int <introductoryPriceCycles>k__BackingField;

            /*0x199cc9c*/ GoogleProductMetadata(string priceString, string title, string description, string currencyCode, decimal localizedPrice);
            /*0x199cc3c*/ string get_originalJson();
            /*0x199cc44*/ void set_originalJson(string value);
            /*0x199cc4c*/ string get_subscriptionPeriod();
            /*0x199cc54*/ void set_subscriptionPeriod(string value);
            /*0x199cc5c*/ string get_freeTrialPeriod();
            /*0x199cc64*/ void set_freeTrialPeriod(string value);
            /*0x199cc6c*/ string get_introductoryPrice();
            /*0x199cc74*/ void set_introductoryPrice(string value);
            /*0x199cc7c*/ string get_introductoryPricePeriod();
            /*0x199cc84*/ void set_introductoryPricePeriod(string value);
            /*0x199cc8c*/ int get_introductoryPriceCycles();
            /*0x199cc94*/ void set_introductoryPriceCycles(int value);
        }

        class GoogleFetchPurchases : UnityEngine.Purchasing.IGoogleFetchPurchases
        {
            /*0x10*/ UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService;
            /*0x18*/ UnityEngine.Purchasing.Extension.IStoreCallback m_StoreCallback;

            static /*0x199d1b4*/ UnityEngine.Purchasing.Product CompleteProductInfoWithPurchase(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase);
            /*0x199cca4*/ GoogleFetchPurchases(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService);
            /*0x199cccc*/ void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
            /*0x199ccd4*/ void FetchPurchases();
            /*0x199cdc4*/ void FetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> onQueryPurchaseSucceed);
            /*0x199cef8*/ System.Collections.Generic.List<UnityEngine.Purchasing.Product> FillProductsWithPurchases(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases);
            /*0x199cfb8*/ System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Product> BuildProductsFromPurchase(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase);
            /*0x199d318*/ void OnFetchedPurchase(System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases);

            class <>c__DisplayClass5_0
            {
                /*0x10*/ System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> onQueryPurchaseSucceed;
                /*0x18*/ UnityEngine.Purchasing.GoogleFetchPurchases <>4__this;

                /*0x199cef0*/ <>c__DisplayClass5_0();
                /*0x199d408*/ void <FetchPurchases>b__0(System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> googlePurchases);
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ UnityEngine.Purchasing.GoogleFetchPurchases <>4__this;
                /*0x18*/ UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase;

                /*0x199d1ac*/ <>c__DisplayClass7_0();
                /*0x199d440*/ UnityEngine.Purchasing.Product <BuildProductsFromPurchase>b__0(string sku);
                /*0x199d468*/ UnityEngine.Purchasing.Product <BuildProductsFromPurchase>b__1(UnityEngine.Purchasing.Product product);
            }
        }

        class GooglePlayStoreFinishTransactionService : UnityEngine.Purchasing.IGooglePlayStoreFinishTransactionService
        {
            /*0x10*/ System.Collections.Generic.HashSet<string> m_ProcessedPurchaseToken;
            /*0x18*/ UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService;
            /*0x20*/ UnityEngine.Purchasing.Extension.IStoreCallback m_StoreCallback;

            static /*0x199dcf8*/ bool IsResponseCodeInRecoverableState(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult);
            /*0x199d478*/ GooglePlayStoreFinishTransactionService(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService);
            /*0x199d504*/ void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
            /*0x199d50c*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string purchaseToken);
            /*0x199d64c*/ void HandleFinishTransaction(UnityEngine.Purchasing.ProductDefinition product, UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase);
            /*0x199daf4*/ void CallPurchaseSucceededUpdateReceipt(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase);

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.Purchasing.GooglePlayStoreFinishTransactionService <>4__this;
                /*0x18*/ UnityEngine.Purchasing.ProductDefinition product;

                /*0x199d644*/ <>c__DisplayClass5_0();
                /*0x199de68*/ void <FinishTransaction>b__0(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase);
            }
        }

        class GooglePlayStorePurchaseService : UnityEngine.Purchasing.IGooglePlayStorePurchaseService
        {
            /*0x10*/ UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService;

            /*0x199de90*/ GooglePlayStorePurchaseService(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService);
            /*0x199deb8*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product);
        }

        class GooglePlayStoreRetrieveProductsService : UnityEngine.Purchasing.IGooglePlayStoreRetrieveProductsService
        {
            /*0x10*/ UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService;
            /*0x18*/ UnityEngine.Purchasing.IGoogleFetchPurchases m_GoogleFetchPurchases;
            /*0x20*/ UnityEngine.Purchasing.Extension.IStoreCallback m_StoreCallback;
            /*0x28*/ UnityEngine.Purchasing.IGooglePlayConfigurationInternal m_GooglePlayConfigurationInternal;
            /*0x30*/ bool m_HasInitiallyRetrievedProducts;

            static /*0x199e568*/ System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> MakePurchasesIntoProducts(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> retrievedProducts, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Product> purchaseProducts);
            /*0x199df64*/ GooglePlayStoreRetrieveProductsService(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService, UnityEngine.Purchasing.IGoogleFetchPurchases googleFetchPurchases, UnityEngine.Purchasing.IGooglePlayConfigurationInternal googlePlayConfigurationInternal);
            /*0x199dfa4*/ void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
            /*0x199dfac*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, bool wantPurchases);
            /*0x199e190*/ void OnProductsRetrievedWithPurchaseFetch(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> retrievedProducts);
            /*0x199e2cc*/ void OnProductsRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> retrievedProducts);
            /*0x199e388*/ void OnRetrieveProductsFailed(UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason reason);
            /*0x199e4c4*/ void ResumeConnection();
            /*0x199ea30*/ bool HasInitiallyRetrievedProducts();

            class <>c__DisplayClass8_0
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> retrievedProducts;
                /*0x18*/ UnityEngine.Purchasing.GooglePlayStoreRetrieveProductsService <>4__this;

                /*0x199e2c4*/ <>c__DisplayClass8_0();
                /*0x199ea38*/ void <OnProductsRetrievedWithPurchaseFetch>b__0(System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchaseProducts);
            }

            class <>c__DisplayClass12_0
            {
                /*0x10*/ UnityEngine.Purchasing.Product purchaseProduct;

                /*0x199ea28*/ <>c__DisplayClass12_0();
                /*0x199eb08*/ bool <MakePurchasesIntoProducts>b__0(UnityEngine.Purchasing.Extension.ProductDescription product);
            }
        }

        class StoreCallbackExtensionMethods
        {
            static /*0x199aa04*/ UnityEngine.Purchasing.Product FindProductById(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback, string sku);
        }

        interface IAndroidStoreSelection : UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
            UnityEngine.Purchasing.AppStore get_appStore();
        }

        interface IUnityCallback
        {
            void OnSetupFailed(string json);
            void OnProductsRetrieved(string json);
            void OnPurchaseSucceeded(string id, string receipt, string transactionID);
            void OnPurchaseFailed(string json);
        }

        class JavaBridge : UnityEngine.AndroidJavaProxy, UnityEngine.Purchasing.IUnityCallback
        {
            /*0x20*/ UnityEngine.Purchasing.IUnityCallback forwardTo;

            /*0x199eb38*/ JavaBridge(UnityEngine.Purchasing.IUnityCallback forwardTo);
            /*0x199ebbc*/ JavaBridge(UnityEngine.Purchasing.IUnityCallback forwardTo, string javaInterface);
            /*0x199ec30*/ void OnSetupFailed(string json);
            /*0x199ecd8*/ void OnProductsRetrieved(string json);
            /*0x199ed84*/ void OnPurchaseSucceeded(string id, string receipt, string transactionID);
            /*0x199ee48*/ void OnPurchaseFailed(string json);
        }

        class SerializationExtensions
        {
            static /*0x199eef4*/ string TryGetString(System.Collections.Generic.Dictionary<string, object> dic, string key);
        }

        class JSONSerializer
        {
            static /*0x199efa8*/ string SerializeProductDef(UnityEngine.Purchasing.ProductDefinition product);
            static /*0x1990844*/ string SerializeProductDefs(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products);
            static /*0x199f8b4*/ string SerializeProductDescs(UnityEngine.Purchasing.Extension.ProductDescription product);
            static /*0x199facc*/ string SerializeProductDescs(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Extension.ProductDescription> products);
            static /*0x199fe54*/ System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> DeserializeProductDescriptions(string json);
            static /*0x19a0524*/ System.Collections.Generic.Dictionary<string, string> DeserializeSubscriptionDescriptions(string json);
            static /*0x19a0b90*/ System.Collections.Generic.Dictionary<string, string> DeserializeProductDetails(string json);
            static /*0x19a13f0*/ UnityEngine.Purchasing.Extension.PurchaseFailureDescription DeserializeFailureReason(string json);
            static /*0x19a02a0*/ UnityEngine.Purchasing.ProductMetadata DeserializeMetadata(System.Collections.Generic.Dictionary<string, object> data);
            static /*0x199efbc*/ System.Collections.Generic.Dictionary<string, object> EncodeProductDef(UnityEngine.Purchasing.ProductDefinition product);
            static /*0x199f8c8*/ System.Collections.Generic.Dictionary<string, object> EncodeProductDesc(UnityEngine.Purchasing.Extension.ProductDescription product);
            static /*0x19a17b0*/ System.Collections.Generic.Dictionary<string, object> EncodeProductMeta(UnityEngine.Purchasing.ProductMetadata product);
            /*0x19a1980*/ JSONSerializer();
        }

        class ScriptingStoreCallback : UnityEngine.Purchasing.Extension.IStoreCallback
        {
            /*0x10*/ UnityEngine.Purchasing.Extension.IStoreCallback m_ForwardTo;
            /*0x18*/ Uniject.IUtil m_Util;
            /*0x20*/ bool <useTransactionLog>k__BackingField;

            /*0x199b89c*/ ScriptingStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback forwardTo, Uniject.IUtil util);
            /*0x19a1988*/ UnityEngine.Purchasing.ProductCollection get_products();
            /*0x19a1a28*/ void OnSetupFailed(UnityEngine.Purchasing.InitializationFailureReason reason);
            /*0x19a1b60*/ void OnProductsRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products);
            /*0x19a1c94*/ void OnPurchaseSucceeded(string id, string receipt, string transactionID);
            /*0x19a1ddc*/ void OnAllPurchasesRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchasedProducts);
            /*0x19a1f10*/ void OnPurchaseFailed(UnityEngine.Purchasing.Extension.PurchaseFailureDescription desc);
            /*0x19a2044*/ bool get_useTransactionLog();
            /*0x19a204c*/ void set_useTransactionLog(bool value);

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingStoreCallback <>4__this;
                /*0x18*/ UnityEngine.Purchasing.InitializationFailureReason reason;

                /*0x19a1b58*/ <>c__DisplayClass5_0();
                /*0x19a2058*/ void <OnSetupFailed>b__0();
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingStoreCallback <>4__this;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products;

                /*0x19a1c8c*/ <>c__DisplayClass6_0();
                /*0x19a210c*/ void <OnProductsRetrieved>b__0();
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingStoreCallback <>4__this;
                /*0x18*/ string id;
                /*0x20*/ string receipt;
                /*0x28*/ string transactionID;

                /*0x19a1dd4*/ <>c__DisplayClass7_0();
                /*0x19a21c0*/ void <OnPurchaseSucceeded>b__0();
            }

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingStoreCallback <>4__this;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchasedProducts;

                /*0x19a1f08*/ <>c__DisplayClass8_0();
                /*0x19a2288*/ void <OnAllPurchasesRetrieved>b__0();
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingStoreCallback <>4__this;
                /*0x18*/ UnityEngine.Purchasing.Extension.PurchaseFailureDescription desc;

                /*0x19a203c*/ <>c__DisplayClass9_0();
                /*0x19a233c*/ void <OnPurchaseFailed>b__0();
            }
        }

        class ScriptingUnityCallback : UnityEngine.Purchasing.IUnityCallback
        {
            /*0x10*/ UnityEngine.Purchasing.IUnityCallback forwardTo;
            /*0x18*/ Uniject.IUtil util;

            /*0x19a23f0*/ ScriptingUnityCallback(UnityEngine.Purchasing.IUnityCallback forwardTo, Uniject.IUtil util);
            /*0x19a241c*/ void OnSetupFailed(string json);
            /*0x19a2550*/ void OnProductsRetrieved(string json);
            /*0x19a2684*/ void OnPurchaseSucceeded(string id, string receipt, string transactionID);
            /*0x19a27cc*/ void OnPurchaseFailed(string json);

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingUnityCallback <>4__this;
                /*0x18*/ string json;

                /*0x19a2548*/ <>c__DisplayClass3_0();
                /*0x19a2900*/ void <OnSetupFailed>b__0();
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingUnityCallback <>4__this;
                /*0x18*/ string json;

                /*0x19a267c*/ <>c__DisplayClass4_0();
                /*0x19a29b0*/ void <OnProductsRetrieved>b__0();
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingUnityCallback <>4__this;
                /*0x18*/ string id;
                /*0x20*/ string receipt;
                /*0x28*/ string transactionID;

                /*0x19a27c4*/ <>c__DisplayClass5_0();
                /*0x19a2a64*/ void <OnPurchaseSucceeded>b__0();
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingUnityCallback <>4__this;
                /*0x18*/ string json;

                /*0x19a28f8*/ <>c__DisplayClass6_0();
                /*0x19a2b2c*/ void <OnPurchaseFailed>b__0();
            }
        }

        class FakeUDPExtension : UnityEngine.Purchasing.IUDPExtensions, UnityEngine.Purchasing.IStoreExtension
        {
            /*0x19a2f08*/ FakeUDPExtension();
            /*0x19a2be0*/ object GetUserInfo();
            /*0x19a2e80*/ string GetLastInitializationError();
            /*0x19a2ec0*/ string GetLastPurchaseError();
            /*0x19a2f00*/ void EnableDebugLog(bool enable);
            /*0x19a2f04*/ void RegisterPurchaseDeferredListener(System.Action<UnityEngine.Purchasing.Product> action);
        }

        interface INativeUDPStore : UnityEngine.Purchasing.INativeStore
        {
            void Initialize(System.Action<bool, string> callback);
            void Purchase(string productId, System.Action<bool, string> callback, string developerPayload);
            void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<bool, string> callback);
            void FinishTransaction(UnityEngine.Purchasing.ProductDefinition productDefinition, string transactionID);
        }

        interface IUDPExtensions : UnityEngine.Purchasing.IStoreExtension
        {
            object GetUserInfo();
            string GetLastInitializationError();
            void EnableDebugLog(bool enable);
            void RegisterPurchaseDeferredListener(System.Action<UnityEngine.Purchasing.Product> action);
        }

        class UDP
        {
            static /*0x19a2f10*/ string get_Name();
            /*0x19a303c*/ UDP();
        }

        class UDPBindings : UnityEngine.Purchasing.INativeUDPStore, UnityEngine.Purchasing.INativeStore
        {
            /*0x10*/ object m_Bridge;
            /*0x18*/ System.Action<bool, string> m_RetrieveProductsCallbackCache;

            static /*0x19a49d8*/ System.Collections.Generic.Dictionary<string, string> StringPropertyToDictionary(object info);
            /*0x19a3044*/ UDPBindings();
            /*0x19a3208*/ void Initialize(System.Action<bool, string> callback);
            /*0x19a3378*/ void Purchase(string productId, System.Action<bool, string> callback, string developerPayload);
            /*0x19a3548*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<bool, string> callback);
            /*0x19a3afc*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition productDefinition, string transactionID);
            /*0x19a3c6c*/ void OnInventoryQueried(bool success, object payload);
            /*0x19a4bd8*/ void RetrieveProducts(string json);
            /*0x19a4c18*/ void Purchase(string productJSON, string developerPayload);
            /*0x19a4c58*/ void FinishTransaction(string productJSON, string transactionID);
        }

        class UDPImpl : UnityEngine.Purchasing.JSONStore, UnityEngine.Purchasing.IUDPExtensions, UnityEngine.Purchasing.IStoreExtension
        {
            static string k_Unknown = "Unknown";
            static int PURCHASE_PENDING_CODE = -303;
            static string k_Errorcode = "errorCode";
            /*0x58*/ UnityEngine.Purchasing.INativeUDPStore m_Bindings;
            /*0x60*/ object m_UserInfo;
            /*0x68*/ string m_LastInitError;
            /*0x70*/ bool m_Initialized;
            /*0x78*/ System.Action<UnityEngine.Purchasing.Product> m_DeferredCallback;

            static /*0x19a5474*/ void DictionaryToStringProperty(System.Collections.Generic.Dictionary<string, object> dic, object info);
            /*0x19a55f4*/ UDPImpl();
            /*0x19a4c98*/ void SetNativeStore(UnityEngine.Purchasing.INativeUDPStore nativeUdpStore);
            /*0x19a4ca0*/ void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback callback);
            /*0x19a4ca8*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x19a4e90*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);
            /*0x19a4fd8*/ void OnPurchaseDeferred(string productId);
            /*0x19a50e4*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId);
            /*0x19a51c0*/ string GetLastInitializationError();
            /*0x19a51c8*/ object GetUserInfo();
            /*0x19a51d0*/ void RegisterPurchaseDeferredListener(System.Action<UnityEngine.Purchasing.Product> callback);
            /*0x19a51d8*/ void EnableDebugLog(bool enable);

            class <>c__DisplayClass10_0
            {
                /*0x10*/ UnityEngine.Purchasing.UDPImpl <>4__this;
                /*0x18*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;
                /*0x20*/ System.Action<bool, string> retrieveCallback;

                /*0x19a4e88*/ <>c__DisplayClass10_0();
                /*0x19a5614*/ void <RetrieveProducts>b__0(bool success, string json);
                /*0x19a56cc*/ void <RetrieveProducts>b__1(bool success, string message);
            }

            class <>c__DisplayClass11_0
            {
                /*0x10*/ UnityEngine.Purchasing.ProductDefinition product;
                /*0x18*/ UnityEngine.Purchasing.UDPImpl <>4__this;

                /*0x19a4fd0*/ <>c__DisplayClass11_0();
                /*0x19a591c*/ void <Purchase>b__0(bool success, string message);
            }
        }

        struct UDPReflectionConsts
        {
            static string k_UdpEngineNamespace = "UnityEngine.UDP";
            static string k_AppStoreSettingsType = "UnityEngine.UDP.AppStoreSettings";
            static string k_BuildConfigType = "UnityEngine.UDP.BuildConfig";
            static string k_InventoryType = "UnityEngine.UDP.Inventory";
            static string k_ProductInfoType = "UnityEngine.UDP.ProductInfo";
            static string k_StoreServiceType = "UnityEngine.UDP.StoreService";
            static string k_UdpIapBridgeType = "UnityEngine.UDP.UdpIapBridge";
            static string k_UserInfoType = "UnityEngine.UDP.UserInfo";
            static string k_AppStoreSettingsClientIDField = "UnityClientID";
            static string k_AppStoreSettingsAppSlugField = "AppSlug";
            static string k_AppStoreSettingsAssetPathField = "appStoreSettingsAssetPath";
            static string k_BuildConfigApiEndpointField = "API_ENDPOINT";
            static string k_BuildConfigIdEndpointField = "ID_ENDPOINT";
            static string k_BuildConfigUdpEndpointField = "UDP_ENDPOINT";
            static string k_BuildConfigVersionField = "VERSION";
            static string k_InventoryGetProductListMethod = "GetProductList";
            static string k_InventoryGetPurchaseInfoMethod = "GetPurchaseInfo";
            static string k_InventoryHasPurchaseMethod = "HasPurchase";
            static string k_ProductInfoCurrencyProp = "Currency";
            static string k_ProductInfoDescProp = "Description";
            static string k_ProductInfoPriceProp = "Price";
            static string k_ProductnfoPriceAmountMicrosProp = "PriceAmountMicros";
            static string k_ProductInfoIdProp = "ProductId";
            static string k_ProductInfoTitleProp = "Title";
            static string k_StoreServiceNameProp = "StoreName";
            static string k_StoreServiceEnableDebugLoggingMethod = "EnableDebugLogging";
            static string k_UdpIapBridgeInitMethod = "Initialize";
            static string k_UdpIapBridgePurchaseMethod = "Purchase";
            static string k_UdpIapBridgeRetrieveProductsMethod = "RetrieveProducts";
            static string k_UdpIapBridgeFinishTransactionMethod = "FinishTransaction";
            static string k_UserInfoChannelProp = "Channel";
            static string k_UserInfoIdProp = "UserId";
            static string k_UserInfoLoginTokenProp = "UserLoginToken";
        }

        class UDPReflectionUtils
        {
            static System.Reflection.BindingFlags k_InstanceBindingFlags = 20;
            static System.Reflection.BindingFlags k_StaticBindingFlags = 24;
            static System.Reflection.BindingFlags k_PrivateStaticBindingFlags = 40;
            static /*0x0*/ System.Collections.Generic.Dictionary<System.Reflection.Assembly, System.Type[]> s_assemblyTypeCache;
            static /*0x8*/ System.Collections.Generic.Dictionary<string, System.Type> s_typeCache;
            static /*0x10*/ string[] k_whiteListedAssemblies;

            static /*0x19a6974*/ UDPReflectionUtils();
            static /*0x19a5ff4*/ System.Type GetTypeByName(string typeName);
            static /*0x19a6844*/ System.Collections.Generic.IEnumerable<System.Reflection.Assembly> GetAllAssemblies();
            static /*0x19a686c*/ System.Collections.Generic.IEnumerable<System.Type> GetTypes(System.Reflection.Assembly assembly);
            /*0x19a696c*/ UDPReflectionUtils();

            class <>c__DisplayClass6_0
            {
                /*0x10*/ System.Reflection.Assembly assembly;

                /*0x19a6864*/ <>c__DisplayClass6_0();
                /*0x19a6b8c*/ bool <GetTypeByName>b__0(string x);
            }
        }

        class AppStoreSettingsInterface
        {
            static /*0x0*/ System.Type s_typeCache;

            static /*0x19a6bc0*/ System.Type GetClassType();
            static /*0x19a6c98*/ System.Reflection.FieldInfo GetClientIDField();
            static /*0x19a6cec*/ System.Reflection.FieldInfo GetAppSlugField();
            static /*0x19a6d40*/ System.Reflection.FieldInfo GetAssetPathField();
            /*0x19a6d94*/ AppStoreSettingsInterface();
        }

        class BuildConfigInterface
        {
            static /*0x0*/ System.Type s_typeCache;

            static /*0x19a6d9c*/ System.Type GetClassType();
            static /*0x19a6e74*/ System.Reflection.FieldInfo GetApiEndpointField();
            static /*0x19a6ec8*/ string GetApiEndpoint();
            static /*0x19a6f34*/ System.Reflection.FieldInfo GetIdEndpointField();
            static /*0x19a6f88*/ string GetIdEndpoint();
            static /*0x19a6ff4*/ System.Reflection.FieldInfo GetUdpEndpointField();
            static /*0x19a7048*/ string GetUdpEndpoint();
            static /*0x19a70b4*/ System.Reflection.FieldInfo GetVersionField();
            static /*0x19a7108*/ string GetVersion();
            /*0x19a7174*/ BuildConfigInterface();
        }

        class InventoryInterface
        {
            static /*0x0*/ System.Type s_typeCache;

            static /*0x19a4654*/ System.Type GetClassType();
            static /*0x19a472c*/ System.Reflection.MethodInfo GetProductListMethod();
            static /*0x19a498c*/ System.Reflection.MethodInfo GetPurchaseInfoMethod();
            static /*0x19a4940*/ System.Reflection.MethodInfo HasPurchaseMethod();
            /*0x19a717c*/ InventoryInterface();
        }

        class ProductInfoInterface
        {
            static /*0x0*/ System.Type s_typeCache;

            static /*0x19a7184*/ System.Type GetClassType();
            static /*0x19a485c*/ System.Reflection.PropertyInfo GetCurrencyProp();
            static /*0x19a4810*/ System.Reflection.PropertyInfo GetDescriptionProp();
            static /*0x19a4778*/ System.Reflection.PropertyInfo GetPriceProp();
            static /*0x19a48a8*/ System.Reflection.PropertyInfo GetPriceAmountMicrosProp();
            static /*0x19a48f4*/ System.Reflection.PropertyInfo GetProductIdProp();
            static /*0x19a47c4*/ System.Reflection.PropertyInfo GetTitleProp();
            /*0x19a725c*/ ProductInfoInterface();
        }

        class StoreServiceInterface
        {
            static /*0x0*/ System.Type s_typeCache;

            static /*0x19a5350*/ System.Type GetClassType();
            static /*0x19a7264*/ System.Reflection.PropertyInfo GetNameProp();
            static /*0x19a2fd0*/ string GetName();
            static /*0x19a5428*/ System.Reflection.MethodInfo GetEnableDebugLoggingMethod();
            /*0x19a72b4*/ StoreServiceInterface();
        }

        class UdpIapBridgeInterface
        {
            static /*0x0*/ System.Type s_typeCache;

            static /*0x19a3130*/ System.Type GetClassType();
            static /*0x19a332c*/ System.Reflection.MethodInfo GetInitMethod();
            static /*0x19a34fc*/ System.Reflection.MethodInfo GetPurchaseMethod();
            static /*0x19a3ab0*/ System.Reflection.MethodInfo GetRetrieveProductsMethod();
            static /*0x19a3c20*/ System.Reflection.MethodInfo GetFinishTransactionMethod();
            /*0x19a72bc*/ UdpIapBridgeInterface();
        }

        class UserInfoInterface
        {
            static /*0x0*/ System.Type s_typeCache;

            static /*0x19a2d10*/ System.Type GetClassType();
            static /*0x19a2de8*/ System.Reflection.PropertyInfo GetChannelProp();
            static /*0x19a2e34*/ System.Reflection.PropertyInfo GetIdProp();
            static /*0x19a72c4*/ System.Reflection.PropertyInfo GetLoginTokenProp();
            /*0x19a7310*/ UserInfoInterface();
        }

        class AppleAppStore
        {
            static string Name = "AppleAppStore";

            /*0x19a7318*/ AppleAppStore();
        }

        class AppleStoreImpl : UnityEngine.Purchasing.JSONStore, UnityEngine.Purchasing.IAppleExtensions, UnityEngine.Purchasing.IStoreExtension, UnityEngine.Purchasing.IAppleConfiguration, UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
            static /*0x0*/ Uniject.IUtil util;
            static /*0x8*/ UnityEngine.Purchasing.AppleStoreImpl instance;
            /*0x58*/ System.Action<UnityEngine.Purchasing.Product> m_DeferredCallback;
            /*0x60*/ System.Action m_RefreshReceiptError;
            /*0x68*/ System.Action<string> m_RefreshReceiptSuccess;
            /*0x70*/ System.Action<bool> m_RestoreCallback;
            /*0x78*/ System.Action m_FetchStorePromotionOrderError;
            /*0x80*/ System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> m_FetchStorePromotionOrderSuccess;
            /*0x88*/ System.Action<UnityEngine.Purchasing.Product> m_PromotionalPurchaseCallback;
            /*0x90*/ System.Action m_FetchStorePromotionVisibilityError;
            /*0x98*/ System.Action<string, UnityEngine.Purchasing.AppleStorePromotionVisibility> m_FetchStorePromotionVisibilitySuccess;
            /*0xa0*/ UnityEngine.Purchasing.INativeAppleStore m_Native;
            /*0xa8*/ UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics;
            /*0xb0*/ string products_json;

            static /*0x19a7320*/ void MessageCallback(string subject, string payload, string receipt, string transactionId);
            /*0x19a747c*/ AppleStoreImpl(Uniject.IUtil util, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics);
            /*0x19a74fc*/ void SetNativeStore(UnityEngine.Purchasing.INativeAppleStore apple);
            /*0x19a75f8*/ string get_appReceipt();
            /*0x19a769c*/ bool get_canMakePayments();
            /*0x19a7740*/ void SetApplePromotionalPurchaseInterceptorCallback(System.Action<UnityEngine.Purchasing.Product> callback);
            /*0x19a7748*/ bool get_simulateAskToBuy();
            /*0x19a77ec*/ void set_simulateAskToBuy(bool value);
            /*0x19a7898*/ void FetchStorePromotionOrder(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> successCallback, System.Action errorCallback);
            /*0x19a7950*/ void FetchStorePromotionVisibility(UnityEngine.Purchasing.Product product, System.Action<string, UnityEngine.Purchasing.AppleStorePromotionVisibility> successCallback, System.Action errorCallback);
            /*0x19a7a20*/ void SetStorePromotionOrder(System.Collections.Generic.List<UnityEngine.Purchasing.Product> products);
            /*0x19a7d80*/ void SetStorePromotionVisibility(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.AppleStorePromotionVisibility visibility);
            /*0x19a7f18*/ string GetTransactionReceiptForProduct(UnityEngine.Purchasing.Product product);
            /*0x19a7fd4*/ void SetApplicationUsername(string applicationUsername);
            /*0x19a8080*/ void OnProductsRetrieved(string json);
            /*0x19a8bf8*/ void RestoreTransactions(System.Action<bool> callback);
            /*0x19a8ca4*/ void RefreshAppReceipt(System.Action<string> successCallback, System.Action errorCallback);
            /*0x19a8d5c*/ void RegisterPurchaseDeferredListener(System.Action<UnityEngine.Purchasing.Product> callback);
            /*0x19a8d64*/ void ContinuePromotionalPurchases();
            /*0x19a8e08*/ System.Collections.Generic.Dictionary<string, string> GetIntroductoryPriceDictionary();
            /*0x19a8e10*/ System.Collections.Generic.Dictionary<string, string> GetProductDetails();
            /*0x19a8e18*/ void PresentCodeRedemptionSheet();
            /*0x19a8ebc*/ void OnPurchaseDeferred(string productId);
            /*0x19a8fa4*/ void OnPromotionalPurchaseAttempted(string productId);
            /*0x19a908c*/ void OnTransactionsRestoredSuccess();
            /*0x19a90ac*/ void OnTransactionsRestoredFail(string error);
            /*0x19a90cc*/ void OnAppReceiptRetrieved(string receipt);
            /*0x19a90ec*/ void OnAppReceiptRefreshedFailed();
            /*0x19a9108*/ void OnFetchStorePromotionOrderSucceeded(string productIds);
            /*0x19a9420*/ void OnFetchStorePromotionOrderFailed();
            /*0x19a943c*/ void OnFetchStorePromotionVisibilitySucceeded(string result);
            /*0x19a970c*/ void OnFetchStorePromotionVisibilityFailed();
            /*0x19a9730*/ void ProcessMessage(string subject, string payload, string receipt, string transactionId);
            /*0x19a9e40*/ void OnPurchaseSucceeded(string id, string receipt, string transactionId);
            /*0x19a8a28*/ UnityEngine.Purchasing.Security.AppleReceipt getAppleReceiptFromBase64String(string receipt);
            /*0x19a9eb0*/ bool isValidPurchaseState(UnityEngine.Purchasing.Security.AppleReceipt appleReceipt, string id);

            class <>c__DisplayClass30_0
            {
                /*0x10*/ UnityEngine.Purchasing.Extension.ProductDescription productDescription;

                /*0x19a8bf0*/ <>c__DisplayClass30_0();
                /*0x19aa350*/ bool <OnProductsRetrieved>b__0(UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt r);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.AppleStoreImpl.<> <>9;
                static /*0x8*/ System.Comparison<UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt> <>9__30_1;
                static /*0x10*/ System.Func<System.Collections.Generic.KeyValuePair<string, object>, string> <>9__46_0;
                static /*0x18*/ System.Func<System.Collections.Generic.KeyValuePair<string, object>, string> <>9__46_1;
                static /*0x20*/ System.Comparison<UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt> <>9__52_1;

                static /*0x19aa378*/ <>c();
                /*0x19aa3dc*/ <>c();
                /*0x19aa3e4*/ int <OnProductsRetrieved>b__30_1(UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt b, UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt a);
                /*0x19aa418*/ string <OnFetchStorePromotionVisibilitySucceeded>b__46_0(System.Collections.Generic.KeyValuePair<string, object> k);
                /*0x19aa454*/ string <OnFetchStorePromotionVisibilitySucceeded>b__46_1(System.Collections.Generic.KeyValuePair<string, object> k);
                /*0x19aa4a0*/ int <isValidPurchaseState>b__52_1(UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt b, UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt a);
            }

            class <>c__DisplayClass48_0
            {
                /*0x10*/ string subject;
                /*0x18*/ string payload;
                /*0x20*/ string receipt;
                /*0x28*/ string transactionId;

                /*0x19a9728*/ <>c__DisplayClass48_0();
                /*0x19aa4d4*/ void <MessageCallback>b__0();
            }

            class <>c__DisplayClass52_0
            {
                /*0x10*/ string id;

                /*0x19aa348*/ <>c__DisplayClass52_0();
                /*0x19aa530*/ bool <isValidPurchaseState>b__0(UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt r);
            }
        }

        class FakeAppleConfiguation : UnityEngine.Purchasing.IAppleConfiguration, UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
            /*0x19aa5a0*/ FakeAppleConfiguation();
            /*0x19aa554*/ string get_appReceipt();
            /*0x19aa594*/ bool get_canMakePayments();
            /*0x19aa59c*/ void SetApplePromotionalPurchaseInterceptorCallback(System.Action<UnityEngine.Purchasing.Product> callback);
        }

        class FakeAppleExtensions : UnityEngine.Purchasing.IAppleExtensions, UnityEngine.Purchasing.IStoreExtension
        {
            /*0x10*/ bool m_FailRefresh;
            /*0x11*/ bool <simulateAskToBuy>k__BackingField;

            /*0x19aa7f0*/ FakeAppleExtensions();
            /*0x19aa5a8*/ void RefreshAppReceipt(System.Action<string> successCallback, System.Action errorCallback);
            /*0x19aa640*/ void RestoreTransactions(System.Action<bool> callback);
            /*0x19aa664*/ void RegisterPurchaseDeferredListener(System.Action<UnityEngine.Purchasing.Product> callback);
            /*0x19aa668*/ bool get_simulateAskToBuy();
            /*0x19aa670*/ void set_simulateAskToBuy(bool value);
            /*0x19aa67c*/ void FetchStorePromotionOrder(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> successCallback, System.Action errorCallback);
            /*0x19aa69c*/ void SetStorePromotionOrder(System.Collections.Generic.List<UnityEngine.Purchasing.Product> products);
            /*0x19aa6a0*/ void FetchStorePromotionVisibility(UnityEngine.Purchasing.Product product, System.Action<string, UnityEngine.Purchasing.AppleStorePromotionVisibility> successCallback, System.Action errorCallback);
            /*0x19aa6c0*/ void SetStorePromotionVisibility(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.AppleStorePromotionVisibility visible);
            /*0x19aa6c4*/ void SetApplicationUsername(string applicationUsername);
            /*0x19aa6c8*/ string GetTransactionReceiptForProduct(UnityEngine.Purchasing.Product product);
            /*0x19aa708*/ void ContinuePromotionalPurchases();
            /*0x19aa70c*/ System.Collections.Generic.Dictionary<string, string> GetIntroductoryPriceDictionary();
            /*0x19aa77c*/ System.Collections.Generic.Dictionary<string, string> GetProductDetails();
            /*0x19aa7ec*/ void PresentCodeRedemptionSheet();
        }

        interface IAppleConfiguration : UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
            string get_appReceipt();
            bool get_canMakePayments();
            void SetApplePromotionalPurchaseInterceptorCallback(System.Action<UnityEngine.Purchasing.Product> callback);
        }

        interface IAppleExtensions : UnityEngine.Purchasing.IStoreExtension
        {
            void RefreshAppReceipt(System.Action<string> successCallback, System.Action errorCallback);
            string GetTransactionReceiptForProduct(UnityEngine.Purchasing.Product product);
            void RestoreTransactions(System.Action<bool> callback);
            void RegisterPurchaseDeferredListener(System.Action<UnityEngine.Purchasing.Product> callback);
            void SetApplicationUsername(string applicationUsername);
            bool get_simulateAskToBuy();
            void set_simulateAskToBuy(bool value);
            void FetchStorePromotionOrder(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> successCallback, System.Action errorCallback);
            void SetStorePromotionOrder(System.Collections.Generic.List<UnityEngine.Purchasing.Product> products);
            void FetchStorePromotionVisibility(UnityEngine.Purchasing.Product product, System.Action<string, UnityEngine.Purchasing.AppleStorePromotionVisibility> successCallback, System.Action errorCallback);
            void SetStorePromotionVisibility(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.AppleStorePromotionVisibility visible);
            void ContinuePromotionalPurchases();
            System.Collections.Generic.Dictionary<string, string> GetIntroductoryPriceDictionary();
            System.Collections.Generic.Dictionary<string, string> GetProductDetails();
            void PresentCodeRedemptionSheet();
        }

        enum AppleStorePromotionVisibility
        {
            Default = 0,
            Hide = 1,
            Show = 2,
        }

        class MacAppStore
        {
            static string Name = "MacAppStore";

            /*0x19aa7f8*/ MacAppStore();
        }

        class MetricizedAppleStoreImpl : UnityEngine.Purchasing.AppleStoreImpl
        {
            /*0xb8*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService m_TelemetryMetricsService;

            /*0x19aa800*/ MetricizedAppleStoreImpl(Uniject.IUtil util, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics, UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService telemetryMetricsService);
            /*0x19aa824*/ void FetchStorePromotionOrder(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> successCallback, System.Action errorCallback);
            /*0x19aa994*/ void FetchStorePromotionVisibility(UnityEngine.Purchasing.Product product, System.Action<string, UnityEngine.Purchasing.AppleStorePromotionVisibility> successCallback, System.Action errorCallback);
            /*0x19aab10*/ void SetStorePromotionOrder(System.Collections.Generic.List<UnityEngine.Purchasing.Product> products);
            /*0x19aac78*/ void RestoreTransactions(System.Action<bool> callback);
            /*0x19aade0*/ void RefreshAppReceipt(System.Action<string> successCallback, System.Action errorCallback);
            /*0x19aaf50*/ void ContinuePromotionalPurchases();
            /*0x19ab07c*/ void PresentCodeRedemptionSheet();
            /*0x19ab1a8*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x19ab310*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);
            /*0x19ab480*/ void <>n__0(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> successCallback, System.Action errorCallback);
            /*0x19ab484*/ void <>n__1(UnityEngine.Purchasing.Product product, System.Action<string, UnityEngine.Purchasing.AppleStorePromotionVisibility> successCallback, System.Action errorCallback);
            /*0x19ab488*/ void <>n__2(System.Collections.Generic.List<UnityEngine.Purchasing.Product> products);
            /*0x19ab48c*/ void <>n__3(System.Action<bool> callback);
            /*0x19ab490*/ void <>n__4(System.Action<string> successCallback, System.Action errorCallback);
            /*0x19ab494*/ void <>n__5(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x19ab54c*/ void <>n__6(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedAppleStoreImpl <>4__this;
                /*0x18*/ System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> successCallback;
                /*0x20*/ System.Action errorCallback;

                /*0x19aa98c*/ <>c__DisplayClass2_0();
                /*0x19ab620*/ void <FetchStorePromotionOrder>b__0();
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedAppleStoreImpl <>4__this;
                /*0x18*/ UnityEngine.Purchasing.Product product;
                /*0x20*/ System.Action<string, UnityEngine.Purchasing.AppleStorePromotionVisibility> successCallback;
                /*0x28*/ System.Action errorCallback;

                /*0x19aab08*/ <>c__DisplayClass3_0();
                /*0x19ab640*/ void <FetchStorePromotionVisibility>b__0();
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedAppleStoreImpl <>4__this;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Purchasing.Product> products;

                /*0x19aac70*/ <>c__DisplayClass4_0();
                /*0x19ab664*/ void <SetStorePromotionOrder>b__0();
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedAppleStoreImpl <>4__this;
                /*0x18*/ System.Action<bool> callback;

                /*0x19aadd8*/ <>c__DisplayClass5_0();
                /*0x19ab684*/ void <RestoreTransactions>b__0();
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedAppleStoreImpl <>4__this;
                /*0x18*/ System.Action<string> successCallback;
                /*0x20*/ System.Action errorCallback;

                /*0x19aaf48*/ <>c__DisplayClass6_0();
                /*0x19ab6a4*/ void <RefreshAppReceipt>b__0();
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedAppleStoreImpl <>4__this;
                /*0x18*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;

                /*0x19ab308*/ <>c__DisplayClass9_0();
                /*0x19ab6c4*/ void <RetrieveProducts>b__0();
            }

            class <>c__DisplayClass10_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedAppleStoreImpl <>4__this;
                /*0x18*/ UnityEngine.Purchasing.ProductDefinition product;
                /*0x20*/ string developerPayload;

                /*0x19ab478*/ <>c__DisplayClass10_0();
                /*0x19ab6e4*/ void <Purchase>b__0();
            }
        }

        enum AppStore
        {
            NotSpecified = 0,
            GooglePlay = 1,
            AmazonAppStore = 2,
            UDP = 3,
            MacAppStore = 4,
            AppleAppStore = 5,
            WinRT = 6,
            fake = 7,
        }

        enum AppStoreMeta
        {
            AndroidStoreStart = 1,
            AndroidStoreEnd = 3,
        }

        interface INativeStoreProvider
        {
            UnityEngine.Purchasing.INativeStore GetAndroidStore(UnityEngine.Purchasing.IUnityCallback callback, UnityEngine.Purchasing.AppStore store, UnityEngine.Purchasing.Extension.IPurchasingBinder binder, Uniject.IUtil util);
            UnityEngine.Purchasing.INativeAppleStore GetStorekit(UnityEngine.Purchasing.IUnityCallback callback);
        }

        interface IStoreInternal
        {
            void SetModule(UnityEngine.Purchasing.StandardPurchasingModule module);
        }

        class JSONStore : UnityEngine.Purchasing.Extension.AbstractStore, UnityEngine.Purchasing.IUnityCallback, UnityEngine.Purchasing.IStoreInternal, UnityEngine.Purchasing.ITransactionHistoryExtensions, UnityEngine.Purchasing.IStoreExtension
        {
            static string k_StoreSpecificErrorCodeKey = "storeSpecificErrorCode";
            /*0x10*/ UnityEngine.Purchasing.Extension.IStoreCallback unity;
            /*0x18*/ UnityEngine.Purchasing.INativeStore m_Store;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.Purchasing.ProductDefinition> m_StoreCatalog;
            /*0x28*/ bool m_IsRefreshing;
            /*0x30*/ System.Action m_RefreshCallback;
            /*0x38*/ UnityEngine.Purchasing.StandardPurchasingModule m_Module;
            /*0x40*/ UnityEngine.ILogger m_Logger;
            /*0x48*/ UnityEngine.Purchasing.Extension.PurchaseFailureDescription m_LastPurchaseFailureDescription;
            /*0x50*/ UnityEngine.Purchasing.StoreSpecificPurchaseErrorCode m_LastPurchaseErrorCode;

            /*0x19a5604*/ JSONStore();
            /*0x19ab704*/ UnityEngine.Purchasing.Product[] get_storeCatalog();
            /*0x19abb00*/ void SetNativeStore(UnityEngine.Purchasing.INativeStore native);
            /*0x19abb08*/ void UnityEngine.Purchasing.IStoreInternal.SetModule(UnityEngine.Purchasing.StandardPurchasingModule module);
            /*0x19abbac*/ void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback callback);
            /*0x19ab498*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x19abc24*/ void ProcessManagedStoreResponse(System.Collections.Generic.List<UnityEngine.Purchasing.ProductDefinition> storeProducts);
            /*0x19ab550*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);
            /*0x19aa274*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId);
            /*0x19a9c98*/ void OnSetupFailed(string reason);
            /*0x19abd8c*/ void OnProductsRetrieved(string json);
            /*0x19aa1b0*/ void OnPurchaseSucceeded(string id, string receipt, string transactionID);
            /*0x19a9e10*/ void OnPurchaseFailed(string json);
            /*0x19abe44*/ void OnPurchaseFailed(UnityEngine.Purchasing.Extension.PurchaseFailureDescription failure, string json);
            /*0x19ac184*/ UnityEngine.Purchasing.Extension.PurchaseFailureDescription GetLastPurchaseFailureDescription();
            /*0x19ac18c*/ UnityEngine.Purchasing.StoreSpecificPurchaseErrorCode GetLastStoreSpecificPurchaseErrorCode();
            /*0x19abf0c*/ UnityEngine.Purchasing.StoreSpecificPurchaseErrorCode ParseStoreSpecificPurchaseErrorCode(string json);
        }

        class MetricizedJsonStore : UnityEngine.Purchasing.JSONStore
        {
            /*0x58*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService m_TelemetryMetricsService;

            /*0x19ac194*/ MetricizedJsonStore(UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService telemetryMetricsService);
            /*0x19ac1c4*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x19ac32c*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);
            /*0x19ac49c*/ void <>n__0(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x19ac4a0*/ void <>n__1(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedJsonStore <>4__this;
                /*0x18*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;

                /*0x19ac324*/ <>c__DisplayClass2_0();
                /*0x19ac4a4*/ void <RetrieveProducts>b__0();
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedJsonStore <>4__this;
                /*0x18*/ UnityEngine.Purchasing.ProductDefinition product;
                /*0x20*/ string developerPayload;

                /*0x19ac494*/ <>c__DisplayClass3_0();
                /*0x19ac4c4*/ void <Purchase>b__0();
            }
        }

        class NativeStoreProvider : UnityEngine.Purchasing.INativeStoreProvider
        {
            /*0x19accdc*/ NativeStoreProvider();
            /*0x19ac4e4*/ UnityEngine.Purchasing.INativeStore GetAndroidStore(UnityEngine.Purchasing.IUnityCallback callback, UnityEngine.Purchasing.AppStore store, UnityEngine.Purchasing.Extension.IPurchasingBinder binder, Uniject.IUtil util);
            /*0x19ac624*/ UnityEngine.Purchasing.INativeStore GetAndroidStoreHelper(UnityEngine.Purchasing.IUnityCallback callback, UnityEngine.Purchasing.AppStore store, UnityEngine.Purchasing.Extension.IPurchasingBinder binder, Uniject.IUtil util);
            /*0x19acc38*/ UnityEngine.Purchasing.INativeAppleStore GetStorekit(UnityEngine.Purchasing.IUnityCallback callback);
        }

        class DialogRequest
        {
            /*0x10*/ string QueryText;
            /*0x18*/ string OkayButtonText;
            /*0x20*/ string CancelButtonText;
            /*0x28*/ System.Collections.Generic.List<string> Options;
            /*0x30*/ System.Action<bool, int> Callback;

            /*0x19acce4*/ DialogRequest();
        }

        enum FakeStoreUIMode
        {
            Default = 0,
            StandardUser = 1,
            DeveloperUser = 2,
        }

        class FakeStore : UnityEngine.Purchasing.JSONStore, UnityEngine.Purchasing.IFakeExtensions, UnityEngine.Purchasing.IStoreExtension, UnityEngine.Purchasing.INativeStore
        {
            static string Name = "fake";
            /*0x58*/ UnityEngine.Purchasing.Extension.IStoreCallback m_Biller;
            /*0x60*/ System.Collections.Generic.List<string> m_PurchasedProducts;
            /*0x68*/ bool purchaseCalled;
            /*0x69*/ bool restoreCalled;
            /*0x70*/ string <unavailableProductId>k__BackingField;
            /*0x78*/ UnityEngine.Purchasing.FakeStoreUIMode UIMode;

            /*0x19ae124*/ FakeStore();
            /*0x19accec*/ string get_unavailableProductId();
            /*0x19accf4*/ void set_unavailableProductId(string value);
            /*0x19accfc*/ void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback biller);
            /*0x19acd18*/ void RetrieveProducts(string json);
            /*0x19ace30*/ void StoreRetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> productDefinitions);
            /*0x19ad8e4*/ void Purchase(string productJSON, string developerPayload);
            /*0x19adbbc*/ void FakePurchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);
            /*0x19ade3c*/ void RestoreTransactions(System.Action<bool> callback);
            /*0x19ae074*/ void FinishTransaction(string productJSON, string transactionID);
            /*0x19ae078*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId);
            /*0x19ae07c*/ void RegisterPurchaseForRestore(string productId);
            bool StartUI<T>(object model, UnityEngine.Purchasing.FakeStore.DialogType dialogType, System.Action<bool, T> callback);
            /*0x19ae1a8*/ void <>n__0(string id, string receipt, string transactionID);

            enum DialogType
            {
                Purchase = 0,
                RetrieveProducts = 1,
            }

            class <>c__DisplayClass13_0
            {
                /*0x10*/ UnityEngine.Purchasing.FakeStore <>4__this;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products;

                /*0x19ad810*/ <>c__DisplayClass13_0();
                /*0x19ae1ac*/ void <StoreRetrieveProducts>b__0(bool allow, UnityEngine.Purchasing.InitializationFailureReason failureReason);
            }

            class <>c__DisplayClass15_0
            {
                /*0x10*/ UnityEngine.Purchasing.FakeStore <>4__this;
                /*0x18*/ UnityEngine.Purchasing.ProductDefinition product;

                /*0x19ade34*/ <>c__DisplayClass15_0();
                /*0x19ae2e4*/ void <FakePurchase>b__0(bool allow, UnityEngine.Purchasing.PurchaseFailureReason failureReason);
            }
        }

        interface IFakeExtensions : UnityEngine.Purchasing.IStoreExtension
        {
            string get_unavailableProductId();
            void set_unavailableProductId(string value);
        }

        class LifecycleNotifier : UnityEngine.MonoBehaviour
        {
            /*0x18*/ System.Action OnDestroyCallback;

            /*0x19ae4f4*/ LifecycleNotifier();
            /*0x19ae4d8*/ void OnDestroy();
        }

        class UIFakeStore : UnityEngine.Purchasing.FakeStore
        {
            static string EnvironmentDescriptionPostfix = "

[Environment: FakeStore]";
            static string SuccessString = "Success";
            static int RetrieveProductsDescriptionCount = 2;
            /*0x80*/ UnityEngine.Purchasing.DialogRequest m_CurrentDialog;
            /*0x88*/ int m_LastSelectedDropdownIndex;
            /*0x90*/ UnityEngine.GameObject m_UIFakeStoreWindowObject;
            /*0x98*/ UnityEngine.GameObject m_EventSystem;
            /*0xa0*/ Uniject.IUtil m_Util;

            /*0x19ae4fc*/ UIFakeStore();
            /*0x19ae500*/ UIFakeStore(Uniject.IUtil util);
            bool StartUI<T>(object model, UnityEngine.Purchasing.FakeStore.DialogType dialogType, System.Action<bool, T> callback);
            /*0x19ae524*/ bool StartUI(string queryText, string okayButtonText, string cancelButtonText, System.Collections.Generic.List<string> options, System.Action<bool, int> callback);
            /*0x19ae5e0*/ void InstantiateDialog();
            /*0x19ae6cc*/ UnityEngine.Purchasing.UIFakeStoreWindow GetOrCreateFakeStoreWindow();
            /*0x19ae878*/ void AddLifeCycleNotifierAndSetDestroyCallback(UnityEngine.GameObject gameObject);
            /*0x19ae928*/ void EnsureEventSystemCreated(UnityEngine.Transform rootTransform);
            /*0x19ae9c8*/ void ConfigureDialogWindow(UnityEngine.Purchasing.UIFakeStoreWindow dialogWindow);
            /*0x19aec98*/ void ConfigureDialogWindowCallbacks(UnityEngine.Purchasing.UIFakeStoreWindow dialogWindow, bool assignCancelCallback, bool assignDropDownCallback);
            /*0x19aea34*/ void CreateEventSystem(UnityEngine.Transform rootTransform);
            /*0x19aee00*/ string CreatePurchaseQuestion(UnityEngine.Purchasing.ProductDefinition definition);
            /*0x19aee6c*/ string CreateRetrieveProductsQuestion(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> definitions);
            /*0x19af084*/ void OkayButtonClicked();
            /*0x19af1c8*/ void CancelButtonClicked();
            /*0x19af25c*/ void DropdownValueChanged(int selectedItem);
            /*0x19af134*/ void CloseDialog();
            /*0x19ae5d0*/ bool IsShowingDialog();
            /*0x19af264*/ void <AddLifeCycleNotifierAndSetDestroyCallback>b__14_0();

            class <>c__DisplayClass10_0<T>
            {
                /*0x0*/ System.Action<bool, T> callback;

                <>c__DisplayClass10_0();
                void <StartUI>b__0(bool result, int codeValue);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.UIFakeStore.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.Purchasing.ProductDefinition, string> <>9__20_0;

                static /*0x19af26c*/ <>c();
                /*0x19af2d0*/ <>c();
                /*0x19af2d8*/ string <CreateRetrieveProductsQuestion>b__20_0(UnityEngine.Purchasing.ProductDefinition pid);
            }
        }

        class UIFakeStoreDropdown
        {
            /*0x10*/ System.Collections.Generic.List<string> m_Options;
            /*0x18*/ System.Action<int, string> m_OnDropdown;
            /*0x20*/ UnityEngine.Vector2 scrollPosition;

            /*0x19af688*/ UIFakeStoreDropdown();
            /*0x19af2f0*/ void DoPopup(int windowID);
            /*0x19af574*/ void OnOptionSelected(int optionIndex);
            /*0x19af5fc*/ void SetOptions(System.Collections.Generic.List<string> options);
            /*0x19af680*/ void SetSelectionAction(System.Action<int, string> onDropdown);
        }

        class UIFakeStoreWindow : UnityEngine.MonoBehaviour
        {
            static float k_MenuScreenRatio = 0.6000000238418579;
            /*0x18*/ string m_QueryText;
            /*0x20*/ string m_OkText;
            /*0x28*/ string m_CancelText;
            /*0x30*/ string m_LastSelectedOptionText;
            /*0x38*/ System.Action m_OnOk;
            /*0x40*/ System.Action m_OnCancel;
            /*0x48*/ System.Action<int> m_OnDropdown;
            /*0x50*/ bool m_CancelEnabled;
            /*0x51*/ bool m_DropdownEnabled;
            /*0x52*/ bool m_DoDropdown;
            /*0x58*/ UnityEngine.Purchasing.UIFakeStoreDropdown m_Dropdown;
            /*0x60*/ UnityEngine.Vector2 scrollPosition;

            /*0x19afbf0*/ UIFakeStoreWindow();
            /*0x19af690*/ void OnGUI();
            /*0x19af810*/ UnityEngine.Rect CreateCenteredWindowRect();
            /*0x19af8a4*/ void DoMainGUI(int windowID);
            /*0x19afb7c*/ void DoDropDown();
            /*0x19afb88*/ void OnOkClicked();
            /*0x19afba4*/ void OnCancelClicked();
            /*0x19aebac*/ void ConfigureMainDialogText(string queryText, string okText, string cancelText);
            /*0x19aebb8*/ void ConfigureDropdownOptions(System.Collections.Generic.List<string> options);
            /*0x19afbc0*/ void OnDropdown(int index, string selectionText);
            /*0x19aeddc*/ void AssignCallbacks(System.Action onOk, System.Action onCancel, System.Action<int> onDropdown);
        }

        class QueryHelper
        {
            static /*0x19afc58*/ string ToQueryString(System.Collections.Generic.Dictionary<string, object> parameters);
        }

        class Price : UnityEngine.ISerializationCallbackReceiver
        {
            /*0x10*/ decimal value;
            /*0x20*/ int[] data;
            /*0x28*/ double num;

            /*0x19b000c*/ Price();
            /*0x19aff24*/ void OnBeforeSerialize();
            /*0x19affa0*/ void OnAfterDeserialize();
        }

        class StoreID
        {
            /*0x10*/ string store;
            /*0x18*/ string id;

            /*0x19b0014*/ StoreID(string store_, string id_);
        }

        enum TranslationLocale
        {
            zh_TW = 0,
            cs_CZ = 1,
            da_DK = 2,
            nl_NL = 3,
            en_US = 4,
            fr_FR = 5,
            fi_FI = 6,
            de_DE = 7,
            iw_IL = 8,
            hi_IN = 9,
            it_IT = 10,
            ja_JP = 11,
            ko_KR = 12,
            no_NO = 13,
            pl_PL = 14,
            pt_PT = 15,
            ru_RU = 16,
            es_ES = 17,
            sv_SE = 18,
            zh_CN = 19,
            en_AU = 20,
            en_CA = 21,
            en_GB = 22,
            fr_CA = 23,
            el_GR = 24,
            id_ID = 25,
            ms_MY = 26,
            pt_BR = 27,
            es_MX = 28,
            th_TH = 29,
            tr_TR = 30,
            vi_VN = 31,
        }

        class LocaleExtensions
        {
            static /*0x0*/ string[] Labels;
            static /*0x8*/ UnityEngine.Purchasing.TranslationLocale[] GoogleLocales;
            static /*0x10*/ UnityEngine.Purchasing.TranslationLocale[] AppleLocales;
            static /*0x18*/ string[] LabelsWithSupportedPlatforms;

            static /*0x19b08a0*/ LocaleExtensions();
            static /*0x19b0040*/ string[] GetLabelsWithSupportedPlatforms();
            static /*0x19b07b0*/ bool SupportedOnApple(UnityEngine.Purchasing.TranslationLocale locale);
            static /*0x19b0828*/ bool SupportedOnGoogle(UnityEngine.Purchasing.TranslationLocale locale);
        }

        class LocalizedProductDescription
        {
            /*0x10*/ UnityEngine.Purchasing.TranslationLocale googleLocale;
            /*0x18*/ string title;
            /*0x20*/ string description;

            static /*0x19b13cc*/ string EncodeNonLatinCharacters(string s);
            static /*0x19b1290*/ string DecodeNonLatinCharacters(string s);
            /*0x19b1248*/ LocalizedProductDescription();
            /*0x19b11b8*/ UnityEngine.Purchasing.LocalizedProductDescription Clone();
            /*0x19ad8d4*/ string get_Title();
            /*0x19b1258*/ void set_Title(string value);
            /*0x19ad8dc*/ string get_Description();
            /*0x19b1274*/ void set_Description(string value);

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.LocalizedProductDescription.<> <>9;
                static /*0x8*/ System.Text.RegularExpressions.MatchEvaluator <>9__11_0;

                static /*0x19b1508*/ <>c();
                /*0x19b156c*/ <>c();
                /*0x19b1574*/ string <DecodeNonLatinCharacters>b__11_0(System.Text.RegularExpressions.Match m);
            }
        }

        class ProductCatalogPayout
        {
            static int MaxSubtypeLength = 64;
            static int MaxDataLength = 1024;
            /*0x10*/ string t;
            /*0x18*/ string st;
            /*0x20*/ double q;
            /*0x28*/ string d;

            /*0x19b1950*/ ProductCatalogPayout();
            /*0x19b1608*/ UnityEngine.Purchasing.ProductCatalogPayout.ProductCatalogPayoutType get_type();
            /*0x19b1764*/ void set_type(UnityEngine.Purchasing.ProductCatalogPayout.ProductCatalogPayoutType value);
            /*0x19b17d8*/ string get_typeString();
            /*0x19b17e0*/ string get_subtype();
            /*0x19b17e8*/ void set_subtype(string value);
            /*0x19b1890*/ double get_quantity();
            /*0x19b1898*/ void set_quantity(double value);
            /*0x19b18a0*/ string get_data();
            /*0x19b18a8*/ void set_data(string value);

            enum ProductCatalogPayoutType
            {
                Other = 0,
                Currency = 1,
                Item = 2,
                Resource = 3,
            }
        }

        class ProductCatalogItem
        {
            /*0x10*/ string id;
            /*0x18*/ UnityEngine.Purchasing.ProductType type;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.Purchasing.StoreID> storeIDs;
            /*0x28*/ UnityEngine.Purchasing.LocalizedProductDescription defaultDescription;
            /*0x30*/ string screenshotPath;
            /*0x38*/ int applePriceTier;
            /*0x40*/ UnityEngine.Purchasing.Price googlePrice;
            /*0x48*/ string pricingTemplateID;
            /*0x50*/ System.Collections.Generic.List<UnityEngine.Purchasing.LocalizedProductDescription> descriptions;
            /*0x58*/ UnityEngine.Purchasing.Price udpPrice;
            /*0x60*/ System.Collections.Generic.List<UnityEngine.Purchasing.ProductCatalogPayout> payouts;

            /*0x19b1dbc*/ ProductCatalogItem();
            /*0x19b19f4*/ void AddPayout();
            /*0x19b1ac4*/ void RemovePayout(UnityEngine.Purchasing.ProductCatalogPayout payout);
            /*0x19b1b1c*/ System.Collections.Generic.IList<UnityEngine.Purchasing.ProductCatalogPayout> get_Payouts();
            /*0x19b1b24*/ UnityEngine.Purchasing.ProductCatalogItem Clone();
            /*0x19b2400*/ void SetStoreID(string aStore, string aId);
            /*0x19b25ac*/ string GetStoreID(string store);
            /*0x19b269c*/ System.Collections.Generic.ICollection<UnityEngine.Purchasing.StoreID> get_allStoreIDs();
            /*0x19b1f4c*/ void SetStoreIDs(System.Collections.Generic.ICollection<UnityEngine.Purchasing.StoreID> storeIds);
            /*0x19b26ac*/ UnityEngine.Purchasing.LocalizedProductDescription GetDescription(UnityEngine.Purchasing.TranslationLocale locale);
            /*0x19b2790*/ UnityEngine.Purchasing.LocalizedProductDescription GetOrCreateDescription(UnityEngine.Purchasing.TranslationLocale locale);
            /*0x19b27c8*/ UnityEngine.Purchasing.LocalizedProductDescription AddDescription(UnityEngine.Purchasing.TranslationLocale locale);
            /*0x19b28bc*/ void RemoveDescription(UnityEngine.Purchasing.TranslationLocale locale);
            /*0x19b29a0*/ bool get_HasAvailableLocale();
            /*0x19b2a88*/ UnityEngine.Purchasing.TranslationLocale get_NextAvailableLocale();
            /*0x19b2e10*/ System.Collections.Generic.ICollection<UnityEngine.Purchasing.LocalizedProductDescription> get_translatedDescriptions();

            class <>c__DisplayClass16_0
            {
                /*0x10*/ string aStore;

                /*0x19b25a4*/ <>c__DisplayClass16_0();
                /*0x19b2e18*/ bool <SetStoreID>b__0(UnityEngine.Purchasing.StoreID obj);
            }

            class <>c__DisplayClass17_0
            {
                /*0x10*/ string store;

                /*0x19b2694*/ <>c__DisplayClass17_0();
                /*0x19b2e3c*/ bool <GetStoreID>b__0(UnityEngine.Purchasing.StoreID obj);
            }

            class <>c__DisplayClass20_0
            {
                /*0x10*/ UnityEngine.Purchasing.StoreID storeId;

                /*0x19b26a4*/ <>c__DisplayClass20_0();
                /*0x19b2e60*/ bool <SetStoreIDs>b__0(UnityEngine.Purchasing.StoreID obj);
            }

            class <>c__DisplayClass21_0
            {
                /*0x10*/ UnityEngine.Purchasing.TranslationLocale locale;

                /*0x19b2788*/ <>c__DisplayClass21_0();
                /*0x19b2e88*/ bool <GetDescription>b__0(UnityEngine.Purchasing.LocalizedProductDescription obj);
            }

            class <>c__DisplayClass24_0
            {
                /*0x10*/ UnityEngine.Purchasing.TranslationLocale locale;

                /*0x19b2998*/ <>c__DisplayClass24_0();
                /*0x19b2eac*/ bool <RemoveDescription>b__0(UnityEngine.Purchasing.LocalizedProductDescription obj);
            }
        }

        class ProductCatalog
        {
            static string kCatalogPath = "Assets/Resources/IAPProductCatalog.json";
            static string kPrevCatalogPath = "Assets/Plugins/UnityPurchasing/Resources/IAPProductCatalog.json";
            static /*0x0*/ UnityEngine.Purchasing.IProductCatalogImpl instance;
            /*0x10*/ string appleSKU;
            /*0x18*/ string appleTeamID;
            /*0x20*/ bool enableCodelessAutoInitialization;
            /*0x21*/ bool enableUnityGamingServicesAutoInitialization;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.Purchasing.ProductCatalogItem> products;

            static /*0x19b2ff0*/ void Initialize();
            static /*0x19b3098*/ void Initialize(UnityEngine.Purchasing.IProductCatalogImpl productCatalogImpl);
            static /*0x19b3348*/ string Serialize(UnityEngine.Purchasing.ProductCatalog catalog);
            static /*0x19b3350*/ UnityEngine.Purchasing.ProductCatalog Deserialize(string catalogJSON);
            static /*0x19b3398*/ UnityEngine.Purchasing.ProductCatalog FromTextAsset(UnityEngine.TextAsset asset);
            static /*0x19ad818*/ UnityEngine.Purchasing.ProductCatalog LoadDefaultCatalog();
            /*0x19b33b4*/ ProductCatalog();
            /*0x19b2ed0*/ System.Collections.Generic.ICollection<UnityEngine.Purchasing.ProductCatalogItem> get_allProducts();
            /*0x19b2ed8*/ System.Collections.Generic.ICollection<UnityEngine.Purchasing.ProductCatalogItem> get_allValidProducts();
            /*0x19b30e4*/ void Add(UnityEngine.Purchasing.ProductCatalogItem item);
            /*0x19b318c*/ void Remove(UnityEngine.Purchasing.ProductCatalogItem item);
            /*0x19b31e4*/ bool IsEmpty();

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.ProductCatalog.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.Purchasing.ProductCatalogItem, bool> <>9__9_0;

                static /*0x19b3438*/ <>c();
                /*0x19b349c*/ <>c();
                /*0x19b34a4*/ bool <get_allValidProducts>b__9_0(UnityEngine.Purchasing.ProductCatalogItem x);
            }
        }

        interface IProductCatalogImpl
        {
            UnityEngine.Purchasing.ProductCatalog LoadDefaultCatalog();
        }

        class ProductCatalogImpl : UnityEngine.Purchasing.IProductCatalogImpl
        {
            /*0x1625dc4*/ ProductCatalogImpl();
            /*0x1625cb0*/ UnityEngine.Purchasing.ProductCatalog LoadDefaultCatalog();
        }

        class StandardPurchasingModule : UnityEngine.Purchasing.Extension.AbstractPurchasingModule, UnityEngine.Purchasing.IAndroidStoreSelection, UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
            static string k_PackageVersion = "3.0.1";
            static /*0x0*/ UnityEngine.Purchasing.StandardPurchasingModule ModuleInstance;
            static /*0x8*/ System.Collections.Generic.Dictionary<UnityEngine.Purchasing.AppStore, string> AndroidStoreNameMap;
            /*0x18*/ string k_Version;
            /*0x20*/ UnityEngine.Purchasing.AppStore m_AppStorePlatform;
            /*0x28*/ UnityEngine.Purchasing.INativeStoreProvider m_NativeStoreProvider;
            /*0x30*/ UnityEngine.RuntimePlatform m_RuntimePlatform;
            /*0x38*/ Uniject.IUtil <util>k__BackingField;
            /*0x40*/ UnityEngine.ILogger <logger>k__BackingField;
            /*0x48*/ UnityEngine.Purchasing.StandardPurchasingModule.StoreInstance <storeInstance>k__BackingField;
            /*0x50*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper <telemetryMetricsInstanceWrapper>k__BackingField;
            /*0x58*/ UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper <telemetryDiagnosticsInstanceWrapper>k__BackingField;
            /*0x60*/ bool usingMockMicrosoft;
            /*0x64*/ UnityEngine.Purchasing.FakeStoreUIMode <useFakeStoreUIMode>k__BackingField;
            /*0x68*/ bool <useFakeStoreAlways>k__BackingField;
            /*0x70*/ UnityEngine.Purchasing.WinRTStore windowsStore;

            static /*0x1628090*/ StandardPurchasingModule();
            static /*0x1625efc*/ UnityEngine.Purchasing.StandardPurchasingModule Instance();
            static /*0x1625f4c*/ UnityEngine.Purchasing.StandardPurchasingModule Instance(UnityEngine.Purchasing.AppStore androidStore);
            static /*0x1627a3c*/ UnityEngine.Purchasing.GooglePlayConfiguration BuildGooglePlayStoreConfiguration(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback googlePurchaseCallback, UnityEngine.Purchasing.Interfaces.IGoogleProductCallback googleProductCallback);
            /*0x1625e24*/ StandardPurchasingModule(Uniject.IUtil util, UnityEngine.ILogger logger, UnityEngine.Purchasing.INativeStoreProvider nativeStoreProvider, UnityEngine.RuntimePlatform platform, UnityEngine.Purchasing.AppStore android, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper telemetryDiagnosticsInstanceWrapper, UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper);
            /*0x1625dcc*/ string get_Version();
            /*0x1625dd4*/ Uniject.IUtil get_util();
            /*0x1625ddc*/ void set_util(Uniject.IUtil value);
            /*0x1625de4*/ UnityEngine.ILogger get_logger();
            /*0x1625dec*/ void set_logger(UnityEngine.ILogger value);
            /*0x1625df4*/ UnityEngine.Purchasing.StandardPurchasingModule.StoreInstance get_storeInstance();
            /*0x1625dfc*/ void set_storeInstance(UnityEngine.Purchasing.StandardPurchasingModule.StoreInstance value);
            /*0x1625e04*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper get_telemetryMetricsInstanceWrapper();
            /*0x1625e0c*/ void set_telemetryMetricsInstanceWrapper(UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper value);
            /*0x1625e14*/ UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper get_telemetryDiagnosticsInstanceWrapper();
            /*0x1625e1c*/ void set_telemetryDiagnosticsInstanceWrapper(UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper value);
            /*0x1625ed0*/ UnityEngine.Purchasing.AppStore get_appStore();
            /*0x1625ed8*/ UnityEngine.Purchasing.FakeStoreUIMode get_useFakeStoreUIMode();
            /*0x1625ee0*/ void set_useFakeStoreUIMode(UnityEngine.Purchasing.FakeStoreUIMode value);
            /*0x1625ee8*/ bool get_useFakeStoreAlways();
            /*0x1625ef0*/ void set_useFakeStoreAlways(bool value);
            /*0x1626518*/ void Configure();
            /*0x1626ad0*/ UnityEngine.Purchasing.StandardPurchasingModule.StoreInstance InstantiateStore();
            /*0x162702c*/ UnityEngine.Purchasing.Extension.IStore InstantiateAndroid();
            /*0x1627254*/ UnityEngine.Purchasing.Extension.IStore InstantiateGoogleStore();
            /*0x1627bf4*/ void BindGoogleExtension(UnityEngine.Purchasing.GooglePlayStoreExtensions googlePlayStoreExtensions);
            /*0x1627b9c*/ void BindGoogleConfiguration(UnityEngine.Purchasing.GooglePlayConfiguration googlePlayConfiguration);
            /*0x1627628*/ UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService BuildGooglePlayStoreServiceAar(UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback googlePurchaseCallback, UnityEngine.Purchasing.Interfaces.IGoogleProductCallback googleProductCallback);
            /*0x1626f60*/ UnityEngine.Purchasing.Extension.IStore InstantiateUDP();
            /*0x1627604*/ UnityEngine.Purchasing.Extension.IStore InstantiateAndroidHelper(UnityEngine.Purchasing.JSONStore store);
            /*0x1627f58*/ UnityEngine.Purchasing.INativeStore GetAndroidNativeStore(UnityEngine.Purchasing.JSONStore store);
            /*0x1626dc8*/ UnityEngine.Purchasing.Extension.IStore InstantiateApple();
            /*0x1628020*/ void UseMockWindowsStore(bool value);
            /*0x16270fc*/ UnityEngine.Purchasing.Extension.IStore instantiateWindowsStore();
            /*0x1626cfc*/ UnityEngine.Purchasing.Extension.IStore InstantiateFakeStore();

            class StoreInstance
            {
                /*0x10*/ string <storeName>k__BackingField;
                /*0x18*/ UnityEngine.Purchasing.Extension.IStore <instance>k__BackingField;

                /*0x1626d9c*/ StoreInstance(string name, UnityEngine.Purchasing.Extension.IStore instance);
                /*0x16281b8*/ string get_storeName();
                /*0x16281c0*/ UnityEngine.Purchasing.Extension.IStore get_instance();
            }

            class MicrosoftConfiguration : UnityEngine.Purchasing.IMicrosoftConfiguration, UnityEngine.Purchasing.Extension.IStoreConfiguration
            {
                /*0x10*/ bool useMock;
                /*0x18*/ UnityEngine.Purchasing.StandardPurchasingModule module;

                /*0x1626a98*/ MicrosoftConfiguration(UnityEngine.Purchasing.StandardPurchasingModule module);
                /*0x16281c8*/ bool get_useMockBillingSystem();
                /*0x16281d0*/ void set_useMockBillingSystem(bool value);
            }
        }

        class StoreConfiguration
        {
            /*0x10*/ UnityEngine.Purchasing.AppStore <androidStore>k__BackingField;

            static /*0x162823c*/ string Serialize(UnityEngine.Purchasing.StoreConfiguration store);
            static /*0x1626290*/ UnityEngine.Purchasing.StoreConfiguration Deserialize(string json);
            /*0x1628214*/ StoreConfiguration(UnityEngine.Purchasing.AppStore store);
            /*0x1628204*/ UnityEngine.Purchasing.AppStore get_androidStore();
            /*0x162820c*/ void set_androidStore(UnityEngine.Purchasing.AppStore value);
        }

        enum StoreSpecificPurchaseErrorCode
        {
            SKErrorUnknown = 0,
            SKErrorClientInvalid = 1,
            SKErrorPaymentCancelled = 2,
            SKErrorPaymentInvalid = 3,
            SKErrorPaymentNotAllowed = 4,
            SKErrorStoreProductNotAvailable = 5,
            SKErrorCloudServicePermissionDenied = 6,
            SKErrorCloudServiceNetworkConnectionFailed = 7,
            SKErrorCloudServiceRevoked = 8,
            BILLING_RESPONSE_RESULT_OK = 9,
            BILLING_RESPONSE_RESULT_USER_CANCELED = 10,
            BILLING_RESPONSE_RESULT_SERVICE_UNAVAILABLE = 11,
            BILLING_RESPONSE_RESULT_BILLING_UNAVAILABLE = 12,
            BILLING_RESPONSE_RESULT_ITEM_UNAVAILABLE = 13,
            BILLING_RESPONSE_RESULT_DEVELOPER_ERROR = 14,
            BILLING_RESPONSE_RESULT_ERROR = 15,
            BILLING_RESPONSE_RESULT_ITEM_ALREADY_OWNED = 16,
            BILLING_RESPONSE_RESULT_ITEM_NOT_OWNED = 17,
            IABHELPER_ERROR_BASE = 18,
            IABHELPER_REMOTE_EXCEPTION = 19,
            IABHELPER_BAD_RESPONSE = 20,
            IABHELPER_VERIFICATION_FAILED = 21,
            IABHELPER_SEND_INTENT_FAILED = 22,
            IABHELPER_USER_CANCELLED = 23,
            IABHELPER_UNKNOWN_PURCHASE_RESPONSE = 24,
            IABHELPER_MISSING_TOKEN = 25,
            IABHELPER_UNKNOWN_ERROR = 26,
            IABHELPER_SUBSCRIPTIONS_NOT_AVAILABLE = 27,
            IABHELPER_INVALID_CONSUMPTION = 28,
            Amazon_ALREADY_PURCHASED = 29,
            Amazon_FAILED = 30,
            Amazon_INVALID_SKU = 31,
            Amazon_NOT_SUPPORTED = 32,
            Unknown = 33,
        }

        class TimeSpanUnits
        {
            /*0x10*/ double days;
            /*0x18*/ int months;
            /*0x1c*/ int years;

            /*0x162833c*/ TimeSpanUnits(double d, int m, int y);
        }

        class SubscriptionManager
        {
            /*0x10*/ string receipt;
            /*0x18*/ string productId;
            /*0x20*/ string intro_json;

            static /*0x1628378*/ void UpdateSubscription(UnityEngine.Purchasing.Product newProduct, UnityEngine.Purchasing.Product oldProduct, string developerPayload, System.Action<UnityEngine.Purchasing.Product, string> appleStore, System.Action<string, string> googleStore);
            static /*0x1628d58*/ void UpdateSubscriptionInGooglePlayStore(UnityEngine.Purchasing.Product oldProduct, UnityEngine.Purchasing.Product newProduct, System.Action<string, string> googlePlayUpdateCallback);
            static /*0x1628f50*/ void UpdateSubscriptionInAppleStore(UnityEngine.Purchasing.Product newProduct, string developerPayload, System.Action<UnityEngine.Purchasing.Product, string> appleStoreUpdateCallback);
            /*0x1628848*/ SubscriptionManager(UnityEngine.Purchasing.Product product, string intro_json);
            /*0x1628f7c*/ SubscriptionManager(string receipt, string id, string intro_json);
            /*0x1628890*/ UnityEngine.Purchasing.SubscriptionInfo getSubscriptionInfo();
            /*0x1629aac*/ UnityEngine.Purchasing.SubscriptionInfo getAmazonAppStoreSubInfo(string productId);
            /*0x1629618*/ UnityEngine.Purchasing.SubscriptionInfo getAppleAppStoreSubInfo(string payload, string productId);
            /*0x1629bb8*/ UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt findMostRecentReceipt(System.Collections.Generic.List<UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt> receipts);
            /*0x1628fb8*/ UnityEngine.Purchasing.SubscriptionInfo getGooglePlayStoreSubInfo(string payload);

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.SubscriptionManager.<> <>9;
                static /*0x8*/ System.Comparison<UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt> <>9__11_0;
                static /*0x10*/ System.Func<object, string> <>9__12_0;

                static /*0x162ac0c*/ <>c();
                /*0x162ac70*/ <>c();
                /*0x162ac78*/ int <findMostRecentReceipt>b__11_0(UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt b, UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt a);
                /*0x162acac*/ string <getGooglePlayStoreSubInfo>b__12_0(object obj);
            }
        }

        class SubscriptionInfo
        {
            /*0x10*/ UnityEngine.Purchasing.Result is_subscribed;
            /*0x14*/ UnityEngine.Purchasing.Result is_expired;
            /*0x18*/ UnityEngine.Purchasing.Result is_cancelled;
            /*0x1c*/ UnityEngine.Purchasing.Result is_free_trial;
            /*0x20*/ UnityEngine.Purchasing.Result is_auto_renewing;
            /*0x24*/ UnityEngine.Purchasing.Result is_introductory_price_period;
            /*0x28*/ string productId;
            /*0x30*/ System.DateTime purchaseDate;
            /*0x38*/ System.DateTime subscriptionExpireDate;
            /*0x40*/ System.DateTime subscriptionCancelDate;
            /*0x48*/ System.TimeSpan remainedTime;
            /*0x50*/ string introductory_price;
            /*0x58*/ System.TimeSpan introductory_price_period;
            /*0x60*/ long introductory_price_cycles;
            /*0x68*/ System.TimeSpan freeTrialPeriod;
            /*0x70*/ System.TimeSpan subscriptionPeriod;
            /*0x78*/ string free_trial_period_string;
            /*0x80*/ string sku_details;

            /*0x1629cd8*/ SubscriptionInfo(UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt r, string intro_json);
            /*0x162a4b0*/ SubscriptionInfo(string skuDetails, bool isAutoRenewing, System.DateTime purchaseDate, bool isFreeTrial, bool hasIntroductoryPriceTrial, bool purchaseHistorySupported, string updateMetadata);
            /*0x1629b14*/ SubscriptionInfo(string productId);
            /*0x162b564*/ string getProductId();
            /*0x162b56c*/ System.DateTime getPurchaseDate();
            /*0x162b574*/ UnityEngine.Purchasing.Result isSubscribed();
            /*0x162b57c*/ UnityEngine.Purchasing.Result isExpired();
            /*0x162b584*/ UnityEngine.Purchasing.Result isCancelled();
            /*0x162b58c*/ UnityEngine.Purchasing.Result isFreeTrial();
            /*0x162b594*/ UnityEngine.Purchasing.Result isAutoRenewing();
            /*0x162b59c*/ System.TimeSpan getRemainingTime();
            /*0x162b5a4*/ UnityEngine.Purchasing.Result isIntroductoryPricePeriod();
            /*0x162b5ac*/ System.TimeSpan getIntroductoryPricePeriod();
            /*0x162b5b4*/ string getIntroductoryPrice();
            /*0x162b60c*/ long getIntroductoryPricePeriodCycles();
            /*0x162b614*/ System.DateTime getExpireDate();
            /*0x162b61c*/ System.DateTime getCancelDate();
            /*0x162b624*/ System.TimeSpan getFreeTrialPeriod();
            /*0x162b62c*/ System.TimeSpan getSubscriptionPeriod();
            /*0x162b634*/ string getFreeTrialPeriodString();
            /*0x162b63c*/ string getSkuDetails();
            /*0x1628b78*/ string getSubscriptionInfoJsonString();
            /*0x162b43c*/ System.DateTime nextBillingDate(System.DateTime billing_begin_date, UnityEngine.Purchasing.TimeSpanUnits units);
            /*0x162b15c*/ System.TimeSpan accumulateIntroductoryDuration(UnityEngine.Purchasing.TimeSpanUnits units, long cycles);
            /*0x162af30*/ System.TimeSpan computePeriodTimeSpan(UnityEngine.Purchasing.TimeSpanUnits units);
            /*0x162b1f8*/ double computeExtraTime(string metadata, double new_sku_period_in_seconds);
            /*0x162afec*/ System.TimeSpan parseTimeSpan(string period_string);
            /*0x162ad0c*/ UnityEngine.Purchasing.TimeSpanUnits parsePeriodTimeSpanUnits(string time_span);
        }

        enum Result
        {
            True = 0,
            False = 1,
            Unsupported = 2,
        }

        enum SubscriptionPeriodUnit
        {
            Day = 0,
            Month = 1,
            Week = 2,
            Year = 3,
            NotAvailable = 4,
        }

        enum AppleStoreProductType
        {
            NonConsumable = 0,
            Consumable = 1,
            NonRenewingSubscription = 2,
            AutoRenewingSubscription = 3,
        }

        class ReceiptParserException : System.Exception
        {
            /*0x162b644*/ ReceiptParserException();
            /*0x162b69c*/ ReceiptParserException(string message);
        }

        class InvalidProductTypeException : UnityEngine.Purchasing.ReceiptParserException
        {
            /*0x162ad08*/ InvalidProductTypeException();
        }

        class NullProductIdException : UnityEngine.Purchasing.ReceiptParserException
        {
            /*0x1629614*/ NullProductIdException();
        }

        class NullReceiptException : UnityEngine.Purchasing.ReceiptParserException
        {
            /*0x1629b10*/ NullReceiptException();
        }

        class StoreSubscriptionInfoNotSupportedException : UnityEngine.Purchasing.ReceiptParserException
        {
            /*0x1629b0c*/ StoreSubscriptionInfoNotSupportedException(string message);
        }

        class FakeTransactionHistoryExtensions : UnityEngine.Purchasing.ITransactionHistoryExtensions, UnityEngine.Purchasing.IStoreExtension
        {
            /*0x1626ac8*/ FakeTransactionHistoryExtensions();
            /*0x162b704*/ UnityEngine.Purchasing.Extension.PurchaseFailureDescription GetLastPurchaseFailureDescription();
            /*0x162b70c*/ UnityEngine.Purchasing.StoreSpecificPurchaseErrorCode GetLastStoreSpecificPurchaseErrorCode();
        }

        interface ITransactionHistoryExtensions : UnityEngine.Purchasing.IStoreExtension
        {
            UnityEngine.Purchasing.Extension.PurchaseFailureDescription GetLastPurchaseFailureDescription();
            UnityEngine.Purchasing.StoreSpecificPurchaseErrorCode GetLastStoreSpecificPurchaseErrorCode();
        }

        class EnumerableExtensions
        {
            static System.Collections.Generic.IEnumerable<T> NonNull<T>(System.Collections.Generic.IEnumerable<T> enumerable);
            static System.Collections.Generic.IEnumerable<T> IgnoreExceptions<T, TException>(System.Collections.Generic.IEnumerable<T> enumerable, System.Action<TException> onException);

            class <>c__0<T>
            {
                static /*0x0*/ UnityEngine.Purchasing.EnumerableExtensions.<>c__0<T> <>9;
                static /*0x0*/ System.Func<T, bool> <>9__0_0;

                static <>c__0();
                <>c__0();
                bool <NonNull>b__0_0(T obj);
            }

            class <IgnoreExceptions>d__1<T, TException> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ T <>2__current;
                /*0x0*/ int <>l__initialThreadId;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> enumerable;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__enumerable;
                /*0x0*/ System.Action<TException> onException;
                /*0x0*/ System.Action<TException> <>3__onException;
                /*0x0*/ System.Collections.Generic.IEnumerator<T> <enumerator>5__2;
                /*0x0*/ bool <hasNext>5__3;

                <IgnoreExceptions>d__1(int <>1__state);
                void System.IDisposable.Dispose();
                bool MoveNext();
                void <>m__Finally1();
                T System.Collections.Generic.IEnumerator<T>.get_Current();
                void System.Collections.IEnumerator.Reset();
                object System.Collections.IEnumerator.get_Current();
                System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class ExponentialRetryPolicy : UnityEngine.Purchasing.Stores.Util.IRetryPolicy
        {
            /*0x10*/ int m_BaseRetryDelay;
            /*0x14*/ int m_MaxRetryDelay;
            /*0x18*/ int m_ExponentialFactor;

            /*0x1627f1c*/ ExponentialRetryPolicy(int baseRetryDelay, int maxRetryDelay, int exponentialFactor);
            /*0x162b714*/ void Invoke(System.Action<System.Action> actionToTry, System.Action onRetryAction);
            /*0x162b7f4*/ int AdjustDelay(int delay);

            class <>c__DisplayClass4_0
            {
                /*0x10*/ System.Action onRetryAction;
                /*0x18*/ int currentRetryDelay;
                /*0x20*/ UnityEngine.Purchasing.ExponentialRetryPolicy <>4__this;
                /*0x28*/ System.Action<System.Action> actionToTry;

                /*0x162b7ec*/ <>c__DisplayClass4_0();
                /*0x162b860*/ void <Invoke>g__Retry|0();
                /*0x162b8f4*/ System.Threading.Tasks.Task <Invoke>g__WaitAndRetry|1();

                struct <<Invoke>g__Retry|0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                    /*0x38*/ UnityEngine.Purchasing.ExponentialRetryPolicy.<> <>4__this;
                    /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                    /*0x162b9bc*/ void MoveNext();
                    /*0x162bb50*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <<Invoke>g__WaitAndRetry|1>d : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ UnityEngine.Purchasing.ExponentialRetryPolicy.<> <>4__this;
                    /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                    /*0x162bb5c*/ void MoveNext();
                    /*0x162bdb0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }
        }

        class FileReference
        {
            /*0x10*/ string m_FilePath;
            /*0x18*/ UnityEngine.ILogger m_Logger;

            static /*0x162bdbc*/ UnityEngine.Purchasing.FileReference CreateInstance(string filename, UnityEngine.ILogger logger, Uniject.IUtil util);
            /*0x162c03c*/ FileReference(string filePath, UnityEngine.ILogger logger);
            /*0x162c068*/ void Save(string payload);
            /*0x162c1a0*/ string Load();
            /*0x162c22c*/ void Delete();
        }

        class ProductDefinitionExtensions
        {
            static /*0x162c364*/ System.Collections.Generic.List<UnityEngine.Purchasing.ProductDefinition> DecodeJSON(System.Collections.Generic.List<object> productsList, string storeName);
        }

        class FakeMicrosoftExtensions : UnityEngine.Purchasing.IMicrosoftExtensions, UnityEngine.Purchasing.IStoreExtension
        {
            /*0x1626ac0*/ FakeMicrosoftExtensions();
            /*0x162caf4*/ void RestoreTransactions();
        }

        interface IMicrosoftConfiguration : UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
            bool get_useMockBillingSystem();
            void set_useMockBillingSystem(bool value);
        }

        interface IMicrosoftExtensions : UnityEngine.Purchasing.IStoreExtension
        {
            void RestoreTransactions();
        }

        class WindowsStore
        {
            static string Name = "WinRT";

            /*0x162caf8*/ WindowsStore();
        }

        class WinRTStore : UnityEngine.Purchasing.Extension.AbstractStore, UnityEngine.Purchasing.Default.IWindowsIAPCallback, UnityEngine.Purchasing.IMicrosoftExtensions, UnityEngine.Purchasing.IStoreExtension
        {
            static /*0x0*/ int count;
            /*0x10*/ UnityEngine.Purchasing.Default.IWindowsIAP win8;
            /*0x18*/ UnityEngine.Purchasing.Extension.IStoreCallback callback;
            /*0x20*/ Uniject.IUtil util;
            /*0x28*/ UnityEngine.ILogger logger;
            /*0x30*/ bool m_CanReceivePurchases;

            /*0x1628054*/ WinRTStore(UnityEngine.Purchasing.Default.IWindowsIAP win8, Uniject.IUtil util, UnityEngine.ILogger logger);
            /*0x162cb00*/ void SetWindowsIAP(UnityEngine.Purchasing.Default.IWindowsIAP iap);
            /*0x162cb08*/ void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback biller);
            /*0x162cb10*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> productDefs);
            /*0x162ce78*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId);
            /*0x162cd68*/ void init(int delay);
            /*0x162cf24*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);
            /*0x162cfd8*/ void restoreTransactions(bool pausing);
            /*0x162d09c*/ void RestoreTransactions();
            /*0x162d150*/ void logError(string error);
            /*0x162d218*/ void OnProductListReceived(UnityEngine.Purchasing.Default.WinProductDescription[] winProducts);
            /*0x162d34c*/ void log(string message);
            /*0x162d480*/ void OnPurchaseFailed(string productId, string error);
            /*0x162d5bc*/ void OnPurchaseSucceeded(string productId, string receipt, string tranId);
            /*0x162d704*/ void OnProductListError(string message);

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.WinRTStore.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.Purchasing.ProductDefinition, bool> <>9__8_0;
                static /*0x10*/ System.Func<UnityEngine.Purchasing.ProductDefinition, UnityEngine.Purchasing.Default.WinProductDescription> <>9__8_1;
                static /*0x18*/ System.Func<UnityEngine.Purchasing.Default.WinProductDescription, <>f__AnonymousType0<UnityEngine.Purchasing.Default.WinProductDescription, UnityEngine.Purchasing.ProductMetadata>> <>9__15_1;
                static /*0x20*/ System.Func<<>f__AnonymousType0<UnityEngine.Purchasing.Default.WinProductDescription, UnityEngine.Purchasing.ProductMetadata>, UnityEngine.Purchasing.Extension.ProductDescription> <>9__15_2;

                static /*0x162d838*/ <>c();
                /*0x162d89c*/ <>c();
                /*0x162d8a4*/ bool <RetrieveProducts>b__8_0(UnityEngine.Purchasing.ProductDefinition def);
                /*0x162d8c4*/ UnityEngine.Purchasing.Default.WinProductDescription <RetrieveProducts>b__8_1(UnityEngine.Purchasing.ProductDefinition def);
                /*0x162da30*/ <>f__AnonymousType0<UnityEngine.Purchasing.Default.WinProductDescription, UnityEngine.Purchasing.ProductMetadata> <OnProductListReceived>b__15_1(UnityEngine.Purchasing.Default.WinProductDescription product);
                /*0x162db18*/ UnityEngine.Purchasing.Extension.ProductDescription <OnProductListReceived>b__15_2(<>f__AnonymousType0<UnityEngine.Purchasing.Default.WinProductDescription, UnityEngine.Purchasing.ProductMetadata> <>h__TransparentIdentifier0);
            }

            class <>c__DisplayClass15_0
            {
                /*0x10*/ UnityEngine.Purchasing.Default.WinProductDescription[] winProducts;
                /*0x18*/ UnityEngine.Purchasing.WinRTStore <>4__this;

                /*0x162d344*/ <>c__DisplayClass15_0();
                /*0x162dbc0*/ void <OnProductListReceived>b__0();
            }

            class <>c__DisplayClass16_0
            {
                /*0x10*/ UnityEngine.Purchasing.WinRTStore <>4__this;
                /*0x18*/ string message;

                /*0x162d478*/ <>c__DisplayClass16_0();
                /*0x162de1c*/ void <log>b__0();
            }

            class <>c__DisplayClass17_0
            {
                /*0x10*/ UnityEngine.Purchasing.WinRTStore <>4__this;
                /*0x18*/ string productId;
                /*0x20*/ string error;

                /*0x162d5b4*/ <>c__DisplayClass17_0();
                /*0x162ded0*/ void <OnPurchaseFailed>b__0();
            }

            class <>c__DisplayClass19_0
            {
                /*0x10*/ UnityEngine.Purchasing.WinRTStore <>4__this;
                /*0x18*/ string productId;
                /*0x20*/ string receipt;
                /*0x28*/ string tranId;

                /*0x162d6fc*/ <>c__DisplayClass19_0();
                /*0x162e5f8*/ void <OnPurchaseSucceeded>b__0();
            }

            class <>c__DisplayClass20_0
            {
                /*0x10*/ string message;
                /*0x18*/ UnityEngine.Purchasing.WinRTStore <>4__this;

                /*0x162d830*/ <>c__DisplayClass20_0();
                /*0x162e6c8*/ void <OnProductListError>b__0();
            }
        }

        namespace Extension
        {
            class UnityUtil : UnityEngine.MonoBehaviour, Uniject.IUtil
            {
                static /*0x0*/ System.Collections.Generic.List<System.Action> s_Callbacks;
                static /*0x8*/ bool s_CallbacksPending;
                static /*0x10*/ System.Collections.Generic.List<UnityEngine.RuntimePlatform> s_PcControlledPlatforms;
                /*0x18*/ System.Collections.Generic.List<System.Action<bool>> pauseListeners;

                static /*0x162f348*/ UnityUtil();
                static T FindInstanceOfType<T>();
                static T LoadResourceInstanceOfType<T>();
                static /*0x162ecd0*/ bool PcPlatform();
                /*0x162f2cc*/ UnityUtil();
                T[] GetAnyComponentsOfType<T>();
                /*0x162e7e8*/ System.DateTime get_currentTime();
                /*0x162e838*/ string get_persistentDataPath();
                /*0x162e840*/ string get_deviceUniqueIdentifier();
                /*0x162e848*/ string get_unityVersion();
                /*0x162e850*/ string get_cloudProjectId();
                /*0x162e858*/ string get_userId();
                /*0x162e8bc*/ string get_gameVersion();
                /*0x162e8c4*/ ulong get_sessionId();
                /*0x162e928*/ UnityEngine.RuntimePlatform get_platform();
                /*0x162e930*/ bool get_isEditor();
                /*0x162e938*/ string get_deviceModel();
                /*0x162e940*/ string get_deviceName();
                /*0x162e948*/ UnityEngine.DeviceType get_deviceType();
                /*0x162e950*/ string get_operatingSystem();
                /*0x162e958*/ int get_screenWidth();
                /*0x162e960*/ int get_screenHeight();
                /*0x162e968*/ float get_screenDpi();
                /*0x162e970*/ string get_screenOrientation();
                /*0x162e9d8*/ object Uniject.IUtil.InitiateCoroutine(System.Collections.IEnumerator start);
                /*0x162e9e0*/ void Uniject.IUtil.InitiateCoroutine(System.Collections.IEnumerator start, int delay);
                /*0x162ea60*/ void RunOnMainThread(System.Action runnable);
                /*0x162ec00*/ object GetWaitForSeconds(int seconds);
                /*0x162ec64*/ void Start();
                /*0x162e9e4*/ System.Collections.IEnumerator DelayedCoroutine(System.Collections.IEnumerator coroutine, int delay);
                /*0x162ed80*/ void Update();
                /*0x162f030*/ void AddPauseListener(System.Action<bool> runnable);
                /*0x162f0d8*/ void OnApplicationPause(bool paused);
                /*0x162f238*/ bool IsClassOrSubclass(System.Type potentialBase, System.Type potentialDescendant);

                class <DelayedCoroutine>d__48 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ int delay;
                    /*0x28*/ UnityEngine.Purchasing.Extension.UnityUtil <>4__this;
                    /*0x30*/ System.Collections.IEnumerator coroutine;

                    /*0x162ed58*/ <DelayedCoroutine>d__48(int <>1__state);
                    /*0x162f62c*/ void System.IDisposable.Dispose();
                    /*0x162f630*/ bool MoveNext();
                    /*0x162f6dc*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x162f6e4*/ void System.Collections.IEnumerator.Reset();
                    /*0x162f724*/ object System.Collections.IEnumerator.get_Current();
                }
            }
        }

        namespace Stores
        {
            namespace Util
            {
                interface IRetryPolicy
                {
                    void Invoke(System.Action<System.Action> actionToTry, System.Action onRetryAction);
                }
            }
        }

        namespace Registration
        {
            class IapCoreInitializeCallback : Unity.Services.Core.Internal.IInitializablePackage
            {
                static string k_PurchasingPackageName = "com.unity.purchasing";

                static /*0x162f72c*/ void Register();
                static /*0x162fa7c*/ void InitializeTelemetryComponents(UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper metricsInstanceWrapper, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper diagnosticsInstanceWrapper);
                /*0x162f844*/ IapCoreInitializeCallback();
                /*0x162f84c*/ System.Threading.Tasks.Task Initialize(Unity.Services.Core.Internal.CoreRegistry registry);

                class <>c__DisplayClass2_0
                {
                    /*0x10*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper metricsInstanceWrapper;
                    /*0x18*/ UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper diagnosticsInstanceWrapper;

                    /*0x162fa74*/ <>c__DisplayClass2_0();
                    /*0x162fd5c*/ void <Initialize>b__0();
                }
            }
        }

        namespace Interfaces
        {
            interface IBillingClientStateListener
            {
                void RegisterOnConnected(System.Action onConnected);
                void RegisterOnDisconnected(System.Action onDisconnected);
            }

            interface IGoogleBillingClient
            {
                void StartConnection(UnityEngine.Purchasing.Interfaces.IBillingClientStateListener billingClientStateListener);
                void EndConnection();
                bool IsReady();
                UnityEngine.Purchasing.GoogleBillingConnectionState GetConnectionState();
                void QueryPurchasesAsync(string skuType, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper>> onQueryPurchasesResponse);
                void QuerySkuDetailsAsync(System.Collections.Generic.List<string> skus, string type, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onSkuDetailsResponseAction);
                UnityEngine.AndroidJavaObject LaunchBillingFlow(UnityEngine.AndroidJavaObject sku, string oldPurchaseToken, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> prorationMode);
                void ConsumeAsync(string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onConsume);
                void AcknowledgePurchase(string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onAcknowledge);
                void SetObfuscationAccountId(string obfuscationAccountId);
                void SetObfuscationProfileId(string obfuscationProfileId);
                void LaunchPriceChangeConfirmationFlow(UnityEngine.AndroidJavaObject skuDetails, UnityEngine.Purchasing.GooglePriceChangeConfirmationListener listener);
            }

            interface IGoogleFinishTransactionService
            {
                void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished);
            }

            interface IGoogleLastKnownProductService
            {
                string get_LastKnownOldProductId();
                void set_LastKnownOldProductId(string value);
                string get_LastKnownProductId();
                void set_LastKnownProductId(string value);
                System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> get_LastKnownProrationMode();
                void set_LastKnownProrationMode(System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> value);
            }

            interface IGooglePlayStoreService
            {
                void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason> onRetrieveProductFailed);
                void Purchase(UnityEngine.Purchasing.ProductDefinition product);
                void Purchase(UnityEngine.Purchasing.ProductDefinition product, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode);
                void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished);
                void FetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed);
                void SetObfuscatedAccountId(string obfuscatedAccountId);
                void SetObfuscatedProfileId(string obfuscatedProfileId);
                void ConfirmSubscriptionPriceChange(UnityEngine.Purchasing.ProductDefinition product, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onPriceChangeAction);
                void ResumeConnection();
                bool IsConnectionReady();
            }

            interface IGoogleProductCallback
            {
                void SetStoreConfiguration(UnityEngine.Purchasing.IGooglePlayConfigurationInternal configuration);
                void NotifyQueryProductDetailsFailed(int retryCount);
            }

            interface IGooglePurchase
            {
                UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper get_javaPurchase();
                int get_purchaseState();
                System.Collections.Generic.List<string> get_skus();
                string get_orderId();
                string get_receipt();
                string get_signature();
                string get_originalJson();
                string get_purchaseToken();
                string get_sku();
                bool IsAcknowledged();
                bool IsPurchased();
            }

            interface IGooglePurchaseBuilder
            {
                System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> BuildPurchases(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper> purchases);
                UnityEngine.Purchasing.Interfaces.IGooglePurchase BuildPurchase(UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper purchase);
            }

            interface IGooglePurchaseCallback
            {
                void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
                void SetStoreConfiguration(UnityEngine.Purchasing.IGooglePlayConfigurationInternal configuration);
                void OnPurchaseSuccessful(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, string receipt, string purchaseToken);
                void OnPurchaseFailed(UnityEngine.Purchasing.Extension.PurchaseFailureDescription purchaseFailureDescription);
                void NotifyDeferredPurchase(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, string receipt, string purchaseToken);
                void NotifyDeferredProrationUpgradeDowngradeSubscription(string sku);
            }

            interface IGooglePurchaseService
            {
                void Purchase(UnityEngine.Purchasing.ProductDefinition product, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode);
            }

            interface IGooglePurchaseStateEnumProvider
            {
                int Purchased();
                int Pending();
            }

            interface IGooglePurchaseUpdatedListener
            {
            }

            interface IGoogleQueryPurchasesService
            {
                System.Threading.Tasks.Task<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> QueryPurchases();
            }

            interface IQuerySkuDetailsService
            {
                void QueryAsyncSku(UnityEngine.Purchasing.ProductDefinition product, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onSkuDetailsResponse);
                void QueryAsyncSku(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onSkuDetailsResponse);
                void QueryAsyncSku(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>> onSkuDetailsResponse);
            }

            interface ISkuDetailsConverter
            {
                System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> ConvertOnQuerySkuDetailsResponse(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> skus);
            }

            interface ISkuDetailsQueryResponse
            {
                void AddResponse(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> skuDetails);
                System.Collections.Generic.List<UnityEngine.AndroidJavaObject> SkuDetails();
                bool IsRecoverable();
            }

            interface ISkuDetailsResponseConsolidator
            {
                void Consolidate(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> skuDetails);
            }
        }

        namespace Utils
        {
            interface IAndroidJavaObjectWrapper
            {
                ReturnType Call<ReturnType>(string methodName, object[] args);
            }

            class AndroidJavaObjectWrapper : UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper
            {
                /*0x10*/ System.IDisposable <androidJavaObject>k__BackingField;

                /*0x162fd70*/ AndroidJavaObjectWrapper(UnityEngine.AndroidJavaObject obj);
                /*0x162fd68*/ System.IDisposable get_androidJavaObject();
                ReturnType Call<ReturnType>(string methodName, object[] args);
            }

            class GooglePurchaseBuilder : UnityEngine.Purchasing.Interfaces.IGooglePurchaseBuilder
            {
                /*0x10*/ UnityEngine.Purchasing.IGoogleCachedQuerySkuDetailsService m_CachedQuerySkuDetailsService;
                /*0x18*/ UnityEngine.ILogger m_Logger;

                static /*0x163033c*/ System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper> TryFindAllSkuDetails(System.Collections.Generic.IEnumerable<string> skus, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper> skuDetails);
                /*0x1627c54*/ GooglePurchaseBuilder(UnityEngine.Purchasing.IGoogleCachedQuerySkuDetailsService cachedQuerySkuDetailsService, UnityEngine.ILogger logger);
                /*0x162fd98*/ System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> BuildPurchases(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper> purchases);
                /*0x162fea4*/ void LogWarningForException(System.Exception exception);
                /*0x162fedc*/ UnityEngine.Purchasing.Interfaces.IGooglePurchase BuildPurchase(UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper purchase);

                class <>c__DisplayClass6_0
                {
                    /*0x10*/ System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper> skuDetails;

                    /*0x1630adc*/ <>c__DisplayClass6_0();
                    /*0x1630ae4*/ UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper <TryFindAllSkuDetails>b__0(string sku);
                }

                class <>c__DisplayClass6_1
                {
                    /*0x10*/ string sku;

                    /*0x1630bbc*/ <>c__DisplayClass6_1();
                    /*0x1630bc4*/ bool <TryFindAllSkuDetails>b__1(UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper skuDetail);
                }
            }

            class GoogleReceiptEncoder
            {
                static /*0x1630d1c*/ string EncodeReceipt(string purchaseOriginalJson, string purchaseSignature, System.Collections.Generic.List<string> skuDetailsJson);
            }

            class SkuDetailsConverter : UnityEngine.Purchasing.Interfaces.ISkuDetailsConverter
            {
                static /*0x1630efc*/ UnityEngine.Purchasing.Extension.ProductDescription ToProductDescription(UnityEngine.AndroidJavaObject skusDetails);
                static /*0x1630f70*/ UnityEngine.Purchasing.Extension.ProductDescription BuildProductDescription(UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper skuDetails);
                /*0x1627f14*/ SkuDetailsConverter();
                /*0x1630e40*/ System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> ConvertOnQuerySkuDetailsResponse(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> skus);
            }
        }

        namespace Models
        {
            class AndroidJavaObjectExtensions
            {
                static System.Collections.Generic.IEnumerable<T> Enumerate<T>(UnityEngine.AndroidJavaObject androidJavaList);
                static /*0x1631c7c*/ System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper> EnumerateAndWrap(UnityEngine.AndroidJavaObject androidJavaList);
                static /*0x1630244*/ System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper> Wrap(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> androidJavaList);
                static /*0x1630f0c*/ UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper Wrap(UnityEngine.AndroidJavaObject androidJavaObject);

                class <>c__DisplayClass0_0<T>
                {
                    /*0x0*/ UnityEngine.AndroidJavaObject androidJavaList;

                    <>c__DisplayClass0_0();
                    T <Enumerate>b__0(int i);
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Purchasing.Models.AndroidJavaObjectExtensions.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.AndroidJavaObject, UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper> <>9__2_0;

                    static /*0x1631cc8*/ <>c();
                    /*0x1631d2c*/ <>c();
                    /*0x1631d34*/ UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper <Wrap>b__2_0(UnityEngine.AndroidJavaObject javaObject);
                }
            }

            interface IGoogleBillingResult
            {
                UnityEngine.Purchasing.Models.GoogleBillingResponseCode get_responseCode();
                string get_debugMessage();
            }

            class GoogleBillingClient : UnityEngine.Purchasing.Interfaces.IGoogleBillingClient
            {
                static string k_AndroidSkuDetailsParamClassName = "com.android.billingclient.api.SkuDetailsParams";
                static string k_AndroidBillingFlowParamClassName = "com.android.billingclient.api.BillingFlowParams";
                static string k_AndroidSubscriptionUpdateParamClassName = "com.android.billingclient.api.BillingFlowParams$SubscriptionUpdateParams";
                static string k_AndroidPriceChangeFlowParamClassName = "com.android.billingclient.api.PriceChangeFlowParams";
                static string k_AndroidConsumeParamsClassName = "com.android.billingclient.api.ConsumeParams";
                static string k_AndroidAcknowledgePurchaseParamsClassName = "com.android.billingclient.api.AcknowledgePurchaseParams";
                static string k_AndroidBillingClientClassName = "com.android.billingclient.api.BillingClient";
                /*0x10*/ UnityEngine.AndroidJavaObject m_BillingClient;
                /*0x18*/ string m_ObfuscatedAccountId;
                /*0x20*/ string m_ObfuscatedProfileId;
                /*0x28*/ Uniject.IUtil m_Util;

                static /*0x1631d3c*/ UnityEngine.AndroidJavaClass GetSkuDetailsParamClass();
                static /*0x1631db0*/ UnityEngine.AndroidJavaClass GetBillingFlowParamClass();
                static /*0x1631e24*/ UnityEngine.AndroidJavaClass GetSubscriptionUpdateParamClass();
                static /*0x1631e98*/ UnityEngine.AndroidJavaClass GetPriceChangeFlowParamClass();
                static /*0x1631f0c*/ UnityEngine.AndroidJavaClass GetConsumeParamsClass();
                static /*0x1631f80*/ UnityEngine.AndroidJavaClass GetAcknowledgePurchaseParamsClass();
                static /*0x1631ff4*/ UnityEngine.AndroidJavaClass GetBillingClientClass();
                static /*0x1632db8*/ UnityEngine.AndroidJavaObject BuildSubscriptionUpdateParams(string oldPurchaseToken, UnityEngine.Purchasing.GooglePlayProrationMode prorationMode);
                /*0x1627c80*/ GoogleBillingClient(UnityEngine.Purchasing.Interfaces.IGooglePurchaseUpdatedListener googlePurchaseUpdatedListener, Uniject.IUtil util);
                /*0x1632068*/ void SetObfuscationAccountId(string obfuscationAccountId);
                /*0x1632070*/ void SetObfuscationProfileId(string obfuscationProfileId);
                /*0x1632078*/ void StartConnection(UnityEngine.Purchasing.Interfaces.IBillingClientStateListener billingClientStateListener);
                /*0x163213c*/ void EndConnection();
                /*0x16321e8*/ bool IsReady();
                /*0x16322a8*/ UnityEngine.Purchasing.GoogleBillingConnectionState GetConnectionState();
                /*0x1632368*/ void QueryPurchasesAsync(string skuType, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper>> onQueryPurchasesResponse);
                /*0x1632484*/ void QuerySkuDetailsAsync(System.Collections.Generic.List<string> skus, string type, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onSkuDetailsResponseAction);
                /*0x16327dc*/ UnityEngine.AndroidJavaObject LaunchBillingFlow(UnityEngine.AndroidJavaObject sku, string oldPurchaseToken, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> prorationMode);
                /*0x1632910*/ UnityEngine.AndroidJavaObject MakeBillingFlowParams(UnityEngine.AndroidJavaObject sku, string oldPurchaseToken, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> prorationMode);
                /*0x1632cd0*/ UnityEngine.AndroidJavaObject SetObfuscatedProfileIdIfNeeded(UnityEngine.AndroidJavaObject billingFlowParams);
                /*0x1632be8*/ UnityEngine.AndroidJavaObject SetObfuscatedAccountIdIfNeeded(UnityEngine.AndroidJavaObject billingFlowParams);
                /*0x1633058*/ void ConsumeAsync(string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onConsume);
                /*0x1633328*/ void AcknowledgePurchase(string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onAcknowledge);
                /*0x16335f8*/ void LaunchPriceChangeConfirmationFlow(UnityEngine.AndroidJavaObject skuDetails, UnityEngine.Purchasing.GooglePriceChangeConfirmationListener listener);
                /*0x1633728*/ UnityEngine.AndroidJavaObject MakePriceChangeFlowParams(UnityEngine.AndroidJavaObject skuDetails);
            }

            class GoogleBillingResult : UnityEngine.Purchasing.Models.IGoogleBillingResult
            {
                /*0x10*/ UnityEngine.Purchasing.Models.GoogleBillingResponseCode <responseCode>k__BackingField;
                /*0x18*/ string <debugMessage>k__BackingField;

                /*0x163392c*/ GoogleBillingResult(UnityEngine.AndroidJavaObject billingResult);
                /*0x163391c*/ UnityEngine.Purchasing.Models.GoogleBillingResponseCode get_responseCode();
                /*0x1633924*/ string get_debugMessage();
            }

            class GoogleBillingStrings
            {
                static string errorPurchaseStateUnspecified = "PurchaseState is UNSPECIFIED_STATE, no more details exists";
                static string errorUserCancelled = "User cancelled purchase";
                static string errorItemAlreadyOwned = "Item already owned";

                static /*0x1633a80*/ string getWarningMessageMoreThanOneSkuFound(string sku);
            }

            class GooglePurchase : UnityEngine.Purchasing.Interfaces.IGooglePurchase
            {
                /*0x10*/ UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper <javaPurchase>k__BackingField;
                /*0x18*/ int <purchaseState>k__BackingField;
                /*0x20*/ System.Collections.Generic.List<string> <skus>k__BackingField;
                /*0x28*/ string <orderId>k__BackingField;
                /*0x30*/ string <receipt>k__BackingField;
                /*0x38*/ string <signature>k__BackingField;
                /*0x40*/ string <originalJson>k__BackingField;
                /*0x48*/ string <purchaseToken>k__BackingField;

                /*0x1630410*/ GooglePurchase(UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper purchase, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper> skuDetails);
                /*0x1633aec*/ UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper get_javaPurchase();
                /*0x1633af4*/ int get_purchaseState();
                /*0x1633afc*/ System.Collections.Generic.List<string> get_skus();
                /*0x1633b04*/ string get_orderId();
                /*0x1633b0c*/ string get_receipt();
                /*0x1633b14*/ string get_signature();
                /*0x1633b1c*/ string get_originalJson();
                /*0x1633b24*/ string get_purchaseToken();
                /*0x1633b2c*/ string get_sku();
                /*0x1633b74*/ bool IsAcknowledged();
                /*0x1633cbc*/ bool IsPurchased();

                class <>c
                {
                    static /*0x0*/ UnityEngine.Purchasing.Models.GooglePurchase.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper, string> <>9__26_0;

                    static /*0x1633d44*/ <>c();
                    /*0x1633da8*/ <>c();
                    /*0x1633db0*/ string <.ctor>b__26_0(UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper skuDetail);
                }
            }

            class GooglePurchaseStateEnum
            {
                static string k_AndroidPurchaseStateClassName = "com.android.billingclient.api.Purchase$PurchaseState";

                static /*0x1633eec*/ UnityEngine.AndroidJavaObject GetPurchaseStateJavaObject();
                static /*0x1633ce8*/ int Purchased();
                static /*0x1633f60*/ int Pending();
            }

            class GooglePurchaseStateEnumProvider : UnityEngine.Purchasing.Interfaces.IGooglePurchaseStateEnumProvider
            {
                /*0x1627c4c*/ GooglePurchaseStateEnumProvider();
                /*0x1633fbc*/ int Purchased();
                /*0x1633fc0*/ int Pending();
            }

            enum GoogleRetrieveProductsFailureReason
            {
                BillingServiceDisconnected = 0,
                BillingServiceUnavailable = 1,
            }

            class GoogleSkuTypeEnum
            {
                static /*0x1633fc4*/ string InApp();
                static /*0x1634004*/ string Sub();
            }

            class ProductDescriptionQuery
            {
                /*0x10*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;
                /*0x18*/ System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>> onProductsReceived;
                /*0x20*/ System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason> onRetrieveProductsFailed;

                /*0x1634044*/ ProductDescriptionQuery(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason> onRetrieveProductsFailed);
            }

            enum GoogleBillingResponseCode
            {
                Ok = 0,
                UserCanceled = 1,
                ServiceUnavailable = 2,
                DeveloperError = 5,
                FatalError = 6,
                ItemAlreadyOwned = 7,
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 64E402E7D8F13D589722D4368AD99BC4134C7B4F479B01925E258B03358BC87C;
    static /*0x4c*/ <PrivateImplementationDetails> CBA27012B0DFF992F7858C87D9D4D5EF5E79A27A359B56B8F4AC4E4CBFEC69F5;

    static /*0x1634080*/ uint ComputeStringHash(string s);

    struct __StaticArrayInitTypeSize=76
    {
    }

    struct __StaticArrayInitTypeSize=112
    {
    }
}
