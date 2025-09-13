class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x13f3b98*/ EmbeddedAttribute();
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

                /*0x14062f8*/ NullableAttribute(byte );
                /*0x1406384*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x14063b0*/ NullableContextAttribute(byte );
            }
        }
    }
}

namespace Uniject
{
    interface IUtil
    {
        object InitiateCoroutine(System.Collections.IEnumerator start);
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
        class AmazonAppStoreStoreExtensions : UnityEngine.Purchasing.IAmazonExtensions, UnityEngine.Purchasing.IStoreExtension, UnityEngine.Purchasing.IAmazonConfiguration, UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
            /*0x10*/ UnityEngine.AndroidJavaObject android;

            /*0x13f0358*/ AmazonAppStoreStoreExtensions(UnityEngine.AndroidJavaObject a);
        }

        class FakeAmazonExtensions : UnityEngine.Purchasing.IAmazonExtensions, UnityEngine.Purchasing.IStoreExtension, UnityEngine.Purchasing.IAmazonConfiguration, UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
            /*0x13f3d48*/ FakeAmazonExtensions();
        }

        interface IAmazonConfiguration : UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
        }

        interface IAmazonExtensions : UnityEngine.Purchasing.IStoreExtension
        {
        }

        class AndroidJavaStore : UnityEngine.Purchasing.INativeStore
        {
            /*0x10*/ UnityEngine.AndroidJavaObject m_Store;

            /*0x13f0580*/ AndroidJavaStore(UnityEngine.AndroidJavaObject store);
            /*0x13f05ac*/ void RetrieveProducts(string json);
            /*0x13f067c*/ void Purchase(string productJSON, string developerPayload);
            /*0x13f0778*/ void FinishTransaction(string productJSON, string transactionID);
        }

        class ListExtension
        {
            static /*0x13f6550*/ UnityEngine.AndroidJavaObject ToJava(System.Collections.Generic.List<string> values);
            static /*0x1404820*/ UnityEngine.AndroidJavaObject ToJavaArray(System.Collections.Generic.List<string> values);
        }

        class UnityActivity
        {
            static /*0x1410294*/ UnityEngine.AndroidJavaClass GetUnityPlayerClass();
            static /*0x13f5d80*/ UnityEngine.AndroidJavaObject GetCurrentActivity();
        }

        class GoogleCachedQuerySkuDetailsService : UnityEngine.Purchasing.IGoogleCachedQuerySkuDetailsService
        {
            /*0x10*/ System.Collections.Generic.Dictionary<string, UnityEngine.AndroidJavaObject> m_CachedQueriedSkus;

            /*0x13f7e28*/ GoogleCachedQuerySkuDetailsService();
            /*0x13f772c*/ System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedSkus();
            /*0x13f7780*/ UnityEngine.AndroidJavaObject GetCachedQueriedSku(string sku);
            /*0x13f77e4*/ System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedSkus(System.Collections.Generic.IEnumerable<string> skus);
            /*0x13f7898*/ System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedSkus(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x13f79d0*/ bool Contains(string sku);
            /*0x13f7a34*/ bool Contains(UnityEngine.Purchasing.ProductDefinition products);
            /*0x13f7a4c*/ void AddCachedQueriedSkus(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> queriedSkus);

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.GoogleCachedQuerySkuDetailsService.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.Purchasing.ProductDefinition, string> <>9__4_0;

                static /*0x1411e78*/ <>c();
                /*0x1411ed8*/ <>c();
                /*0x1411ee0*/ string <GetCachedQueriedSkus>b__4_0(UnityEngine.Purchasing.ProductDefinition product);
            }
        }

        class GoogleFinishTransactionService : UnityEngine.Purchasing.Interfaces.IGoogleFinishTransactionService
        {
            /*0x10*/ UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient;
            /*0x18*/ UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService m_GoogleQueryPurchasesService;

            /*0x13f8734*/ GoogleFinishTransactionService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService googleQueryPurchasesService);
            /*0x13f876c*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished);
            /*0x13f884c*/ System.Threading.Tasks.Task<UnityEngine.Purchasing.Interfaces.IGooglePurchase> FindPurchase(string purchaseToken);
            /*0x13f8978*/ void FinishTransactionForPurchase(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, UnityEngine.Purchasing.ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished);

            struct <FinishTransaction>d__3 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                /*0x38*/ UnityEngine.Purchasing.GoogleFinishTransactionService <>4__this;
                /*0x40*/ string purchaseToken;
                /*0x48*/ UnityEngine.Purchasing.ProductDefinition product;
                /*0x50*/ System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished;
                /*0x58*/ System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Purchasing.Interfaces.IGooglePurchase> <>u__1;

                /*0xa99b54*/ void MoveNext();
                /*0xa99b5c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ string purchaseToken;

                /*0x1411fa4*/ <>c__DisplayClass4_0();
                /*0x1411fac*/ bool <FindPurchase>b__0(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase);
            }

            struct <FindPurchase>d__4 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<UnityEngine.Purchasing.Interfaces.IGooglePurchase> <>t__builder;
                /*0x30*/ string purchaseToken;
                /*0x38*/ UnityEngine.Purchasing.GoogleFinishTransactionService <>4__this;
                /*0x40*/ UnityEngine.Purchasing.GoogleFinishTransactionService.<> <>8__1;
                /*0x48*/ System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>u__1;

                /*0xa99b44*/ void MoveNext();
                /*0xa99b4c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished;
                /*0x18*/ UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase;

                /*0x13f8c14*/ <>c__DisplayClass5_0();
                /*0x1412070*/ void <FinishTransactionForPurchase>b__0(UnityEngine.Purchasing.Models.IGoogleBillingResult result);
                /*0x14120d8*/ void <FinishTransactionForPurchase>b__1(UnityEngine.Purchasing.Models.IGoogleBillingResult result);
            }
        }

        class GoogleLastKnownProductService : UnityEngine.Purchasing.Interfaces.IGoogleLastKnownProductService
        {
            /*0x10*/ string <LastKnownOldProductId>k__BackingField;
            /*0x18*/ string <LastKnownProductId>k__BackingField;
            /*0x20*/ System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> <LastKnownProrationMode>k__BackingField;

            /*0x13f8c4c*/ GoogleLastKnownProductService();
            /*0x13f8c1c*/ string get_LastKnownOldProductId();
            /*0x13f8c24*/ void set_LastKnownOldProductId(string value);
            /*0x13f8c2c*/ string get_LastKnownProductId();
            /*0x13f8c34*/ void set_LastKnownProductId(string value);
            /*0x13f8c3c*/ System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> get_LastKnownProrationMode();
            /*0x13f8c44*/ void set_LastKnownProrationMode(System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> value);
        }

        class GooglePlayStoreService : UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService
        {
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

            /*0x13fb6cc*/ GooglePlayStoreService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, UnityEngine.Purchasing.Interfaces.IQuerySkuDetailsService querySkuDetailsService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseService purchaseService, UnityEngine.Purchasing.Interfaces.IGoogleFinishTransactionService finishTransactionService, UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService queryPurchasesService, UnityEngine.Purchasing.Interfaces.IBillingClientStateListener billingClientStateListener, UnityEngine.Purchasing.IGooglePriceChangeService priceChangeService, UnityEngine.Purchasing.Interfaces.IGoogleLastKnownProductService lastKnownProductService, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics, UnityEngine.ILogger logger);
            /*0x13fb7f4*/ void InitConnectionWithGooglePlay();
            /*0x13fb9a0*/ void StartConnection();
            /*0x13fba60*/ void ResumeConnection();
            /*0x13fbb28*/ void OnConnected();
            /*0x13fbb60*/ void DequeueQueryProducts();
            /*0x13fbf68*/ void DequeueFetchPurchases();
            /*0x13fc0b0*/ void OnDisconnected();
            /*0x13fc100*/ void AttemptReconnection();
            /*0x13fbf58*/ bool AreConnectionAttemptsExhausted();
            /*0x13fc11c*/ void OnReconnectionFailure();
            /*0x13fc128*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason> onRetrieveProductsFailed);
            /*0x13fc2a8*/ void HandleRetrieveProductsNotConnected(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason> onRetrieveProductsFailed);
            /*0x13fc444*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product);
            /*0x13fc458*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode);
            /*0x13fc6bc*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished);
            /*0x13fbfe8*/ void FetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed);
            /*0x13fc790*/ System.Threading.Tasks.Task TryFetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed);

            struct <FetchPurchases>d__31 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                /*0x38*/ UnityEngine.Purchasing.GooglePlayStoreService <>4__this;
                /*0x40*/ System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed;
                /*0x48*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                /*0xa99b68*/ void MoveNext();
                /*0xa99b70*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <TryFetchPurchases>d__32 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed;
                /*0x38*/ UnityEngine.Purchasing.GooglePlayStoreService <>4__this;
                /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>u__1;

                /*0xa99b7c*/ void MoveNext();
                /*0xa99b84*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class GooglePriceChangeService : UnityEngine.Purchasing.IGooglePriceChangeService
        {
            /*0x10*/ UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient;
            /*0x18*/ UnityEngine.Purchasing.Interfaces.IQuerySkuDetailsService m_QuerySkuDetailsService;

            /*0x13fc9cc*/ GooglePriceChangeService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, UnityEngine.Purchasing.Interfaces.IQuerySkuDetailsService querySkuDetailsService);
        }

        class GooglePurchaseService : UnityEngine.Purchasing.Interfaces.IGooglePurchaseService
        {
            /*0x10*/ UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient;
            /*0x18*/ UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback m_GooglePurchaseCallback;
            /*0x20*/ UnityEngine.Purchasing.Interfaces.IQuerySkuDetailsService m_QuerySkuDetailsService;

            static /*0x13fe3ec*/ void VerifyAndWarnIfMoreThanOneSku(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> skus);
            /*0x13fdd00*/ GooglePurchaseService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback googlePurchaseCallback, UnityEngine.Purchasing.Interfaces.IQuerySkuDetailsService querySkuDetailsService);
            /*0x13fdd40*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode);
            /*0x13fdea4*/ void OnQuerySkuDetailsResponse(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> skus, UnityEngine.Purchasing.ProductDefinition productToBuy, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode);
            /*0x13fdf58*/ bool ValidateQuerySkuDetailsResponseParams(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> skus, UnityEngine.Purchasing.ProductDefinition productToBuy, UnityEngine.Purchasing.Product oldProduct);
            /*0x13fe0e4*/ bool ValidateSkus(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> skus);
            /*0x13fe140*/ void PurchaseFailedSkuNotFound(UnityEngine.Purchasing.ProductDefinition productToBuy);
            /*0x13fe250*/ bool ValidateOldProduct(UnityEngine.Purchasing.Product oldProduct);
            /*0x13fe2ac*/ void PurchaseFailedInvalidOldProduct(UnityEngine.Purchasing.ProductDefinition productToBuy, UnityEngine.Purchasing.Product oldProduct);
            /*0x13fdfc4*/ void LaunchGoogleBillingFlow(UnityEngine.AndroidJavaObject productToPurchase, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode);
            /*0x13fe57c*/ void HandleBillingFlowResult(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, UnityEngine.AndroidJavaObject sku);

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.Purchasing.GooglePurchaseService <>4__this;
                /*0x18*/ UnityEngine.Purchasing.ProductDefinition product;
                /*0x20*/ UnityEngine.Purchasing.Product oldProduct;
                /*0x28*/ System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode;

                /*0x13fde9c*/ <>c__DisplayClass4_0();
                /*0x1413660*/ void <Purchase>b__0(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> skus);
            }
        }

        class GoogleQueryPurchasesService : UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService
        {
            /*0x10*/ UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient;
            /*0x18*/ UnityEngine.Purchasing.Interfaces.IGooglePurchaseBuilder m_PurchaseBuilder;

            static /*0x1401090*/ bool IsResultOk(UnityEngine.Purchasing.Models.IGoogleBillingResult result);
            /*0x1400d88*/ GoogleQueryPurchasesService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, UnityEngine.Purchasing.Interfaces.IGooglePurchaseBuilder purchaseBuilder);
            /*0x1400dc0*/ System.Threading.Tasks.Task<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> QueryPurchases();
            /*0x1400ee0*/ System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> QueryPurchasesWithSkuType(string skuType);

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.GoogleQueryPurchasesService.<> <>9;
                static /*0x8*/ System.Func<System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>9__3_0;

                static /*0x14138f0*/ <>c();
                /*0x1413950*/ <>c();
                /*0x1413958*/ System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> <QueryPurchases>b__3_0(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> result);
            }

            struct <QueryPurchases>d__3 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>t__builder;
                /*0x30*/ UnityEngine.Purchasing.GoogleQueryPurchasesService <>4__this;
                /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>[]> <>u__1;

                /*0xa99ba4*/ void MoveNext();
                /*0xa99bac*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.Purchasing.GoogleQueryPurchasesService <>4__this;
                /*0x18*/ System.Threading.Tasks.TaskCompletionSource<System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> taskCompletion;

                /*0x1401088*/ <>c__DisplayClass4_0();
                /*0x1413960*/ void <QueryPurchasesWithSkuType>b__0(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper> purchases);
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
        }

        class BillingClientStateListener : UnityEngine.AndroidJavaProxy, UnityEngine.Purchasing.Interfaces.IBillingClientStateListener
        {
            static string k_AndroidBillingClientStateListenerClassName = "com.android.billingclient.api.BillingClientStateListener";
            /*0x20*/ System.Action m_OnConnected;
            /*0x28*/ System.Action m_Disconnect;

            /*0x13f3808*/ BillingClientStateListener();
            /*0x13f3884*/ void RegisterOnConnected(System.Action onConnected);
            /*0x13f388c*/ void RegisterOnDisconnected(System.Action onDisconnected);
            /*0x13f3894*/ void onBillingSetupFinished(UnityEngine.AndroidJavaObject billingResult);
            /*0x13f3b74*/ void onBillingServiceDisconnected();
        }

        class GoogleAcknowledgePurchaseListener : UnityEngine.AndroidJavaProxy
        {
            static string k_AndroidAcknowledgePurchaseResponseListenerClassName = "com.android.billingclient.api.AcknowledgePurchaseResponseListener";
            /*0x20*/ System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> m_OnAcknowledgePurchaseResponse;

            /*0x13f56b4*/ GoogleAcknowledgePurchaseListener(System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onAcknowledgePurchaseResponseAction);
            /*0x13f5744*/ void onAcknowledgePurchaseResponse(UnityEngine.AndroidJavaObject billingResult);
        }

        class GoogleConsumeResponseListener : UnityEngine.AndroidJavaProxy
        {
            static string k_AndroidConsumeResponseListenerClassName = "com.android.billingclient.api.ConsumeResponseListener";
            /*0x20*/ System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> m_OnConsumeResponse;

            /*0x13f72dc*/ GoogleConsumeResponseListener(System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onConsumeResponseAction);
            /*0x13f7ea0*/ void onConsumeResponse(UnityEngine.AndroidJavaObject billingResult, string purchaseToken);
        }

        class GooglePriceChangeConfirmationListener : UnityEngine.AndroidJavaProxy
        {
            static string k_AndroidPriceChangeConfirmationListenerClassName = "com.android.billingclient.api.PriceChangeConfirmationListener";
            /*0x20*/ System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> m_OnPriceChangeConfirmationResult;

            /*0x13fc8b0*/ GooglePriceChangeConfirmationListener(System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onPriceChangeConfirmationResult);
            /*0x13fc940*/ void onPriceChangeConfirmationResult(UnityEngine.AndroidJavaObject javaBillingResult);
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

            /*0x13fe938*/ GooglePurchaseUpdatedListener(UnityEngine.Purchasing.Interfaces.IGoogleLastKnownProductService googleLastKnownProductService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback googlePurchaseCallback, UnityEngine.Purchasing.Interfaces.IGooglePurchaseBuilder purchaseBuilder, UnityEngine.Purchasing.IGoogleCachedQuerySkuDetailsService googleCachedQuerySkuDetailsService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider, UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService googleQueryPurchasesService);
            /*0x13fe9f4*/ void SetGoogleQueryPurchaseService(UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService googleFetchPurchases);
            /*0x13fe9fc*/ void onPurchasesUpdated(UnityEngine.AndroidJavaObject billingResult, UnityEngine.AndroidJavaObject javaPurchasesList);
            /*0x13feb1c*/ void OnPurchasesUpdated(UnityEngine.Purchasing.Models.IGoogleBillingResult result, System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases);
            /*0x13feda8*/ void HandleResultOkCases(UnityEngine.Purchasing.Models.IGoogleBillingResult result, System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases);
            /*0x13fefc4*/ void HandleErrorCases(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases);
            /*0x13ff578*/ void HandleUserCancelledPurchaseFailure(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult);
            /*0x13ff9b8*/ void HandleUserCancelledPurchaseFailure(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> googlePurchases);
            /*0x13fee88*/ void ApplyOnPurchases(System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases, System.Action<UnityEngine.Purchasing.Interfaces.IGooglePurchase> action);
            /*0x13ff640*/ void ApplyOnPurchases(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases, UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Action<UnityEngine.Purchasing.Interfaces.IGooglePurchase, string> action);
            /*0x13ffb18*/ void OnPurchaseOk(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase);
            /*0x14001d4*/ void HandlePurchasedProduct(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase);
            /*0x1400498*/ bool IsDeferredSubscriptionChange(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase);
            /*0x1400600*/ bool IsLastProrationModeDeferred();
            /*0x13fffd8*/ void OnPurchaseCancelled(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult);
            /*0x14006e0*/ void OnPurchaseCancelled(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase);
            /*0x140086c*/ void OnPurchaseAlreadyOwned(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase);
            /*0x14009f8*/ void OnPurchaseFailed(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase, string debugMessage);
            /*0x1400b9c*/ bool <HandleUserCancelledPurchaseFailure>b__14_0(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase);

            struct <HandleUserCancelledPurchaseFailure>d__13 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                /*0x38*/ UnityEngine.Purchasing.GooglePurchaseUpdatedListener <>4__this;
                /*0x40*/ UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult;
                /*0x48*/ System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>u__1;

                /*0xa99b90*/ void MoveNext();
                /*0xa99b98*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class GooglePurchasesResponseListener : UnityEngine.AndroidJavaProxy
        {
            static string k_AndroidSkuDetailsResponseListenerClassName = "com.android.billingclient.api.PurchasesResponseListener";
            /*0x20*/ System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper>> m_OnQueryPurchasesResponse;

            /*0x13f60ec*/ GooglePurchasesResponseListener(System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper>> onQueryPurchasesResponse);
            /*0x1400ce8*/ void onQueryPurchasesResponse(UnityEngine.AndroidJavaObject billingResult, UnityEngine.AndroidJavaObject purchases);
        }

        class SkuDetailsResponseListener : UnityEngine.AndroidJavaProxy
        {
            static string k_AndroidSkuDetailsResponseListenerClassName = "com.android.billingclient.api.SkuDetailsResponseListener";
            /*0x20*/ System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> m_OnSkuDetailsResponse;
            /*0x28*/ Uniject.IUtil m_Util;

            /*0x13f6554*/ SkuDetailsResponseListener(System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onSkuDetailsResponseAction, Uniject.IUtil util);
            /*0x140a150*/ void onSkuDetailsResponse(UnityEngine.AndroidJavaObject billingResult, UnityEngine.AndroidJavaObject skuDetails);

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.AndroidJavaObject skuDetails;
                /*0x18*/ UnityEngine.Purchasing.SkuDetailsResponseListener <>4__this;
                /*0x20*/ UnityEngine.AndroidJavaObject billingResult;

                /*0x140a28c*/ <>c__DisplayClass4_0();
                /*0x1414e48*/ void <onSkuDetailsResponse>b__0();
            }
        }

        class MetricizedGooglePlayStoreService : UnityEngine.Purchasing.GooglePlayStoreService
        {
            /*0x78*/ UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics;
            /*0x80*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService m_TelemetryMetricsService;

            /*0x1404fcc*/ MetricizedGooglePlayStoreService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, UnityEngine.Purchasing.Interfaces.IQuerySkuDetailsService querySkuDetailsService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseService purchaseService, UnityEngine.Purchasing.Interfaces.IGoogleFinishTransactionService finishTransactionService, UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService queryPurchasesService, UnityEngine.Purchasing.Interfaces.IBillingClientStateListener billingClientStateListener, UnityEngine.Purchasing.IGooglePriceChangeService priceChangeService, UnityEngine.Purchasing.Interfaces.IGoogleLastKnownProductService lastKnownProductService, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics, UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService telemetryMetricsService, UnityEngine.ILogger logger);
            /*0x1405014*/ void DequeueQueryProducts();
            /*0x1405150*/ void DequeueFetchPurchases();
            /*0x140528c*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason> onRetrieveProductsFailed);
            /*0x1405418*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode);
            /*0x14055a4*/ void <>n__0(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason> onRetrieveProductsFailed);
            /*0x14055a8*/ void <>n__1(UnityEngine.Purchasing.ProductDefinition product, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode);

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedGooglePlayStoreService <>4__this;
                /*0x18*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;
                /*0x20*/ System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>> onProductsReceived;
                /*0x28*/ System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason> onRetrieveProductsFailed;

                /*0x1405410*/ <>c__DisplayClass5_0();
                /*0x1414118*/ void <RetrieveProducts>b__0();
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedGooglePlayStoreService <>4__this;
                /*0x18*/ UnityEngine.Purchasing.ProductDefinition product;
                /*0x20*/ UnityEngine.Purchasing.Product oldProduct;
                /*0x28*/ System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode;

                /*0x140559c*/ <>c__DisplayClass6_0();
                /*0x141413c*/ void <Purchase>b__0();
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

            /*0x1406d08*/ QuerySkuDetailsService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, UnityEngine.Purchasing.IGoogleCachedQuerySkuDetailsService googleCachedQuerySkuDetailsService, UnityEngine.Purchasing.Interfaces.ISkuDetailsConverter skuDetailsConverter, UnityEngine.Purchasing.Stores.Util.IRetryPolicy retryPolicy, UnityEngine.Purchasing.Interfaces.IGoogleProductCallback googleProductCallback);
            /*0x1406d5c*/ void QueryAsyncSku(UnityEngine.Purchasing.ProductDefinition product, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onSkuDetailsResponse);
            /*0x1406fc8*/ void QueryAsyncSku(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>> onSkuDetailsResponse);
            /*0x1406e30*/ void QueryAsyncSku(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onSkuDetailsResponse);
            /*0x14070b0*/ void QueryAsyncSkuWithRetries(System.Collections.Generic.IReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onSkuDetailsResponse, System.Action retryQuery);
            /*0x140770c*/ bool ShouldRetryQuery(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> requestedProducts, UnityEngine.Purchasing.Interfaces.ISkuDetailsQueryResponse queryResponse);
            /*0x14077ec*/ bool AreAllSkuDetailsCached(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x14079f8*/ System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedSkuDetails(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x140724c*/ void QueryInAppsAsync(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products, UnityEngine.Purchasing.Interfaces.ISkuDetailsResponseConsolidator consolidator);
            /*0x14074ac*/ void QuerySubsAsync(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products, UnityEngine.Purchasing.Interfaces.ISkuDetailsResponseConsolidator consolidator);
            /*0x1407b90*/ void QuerySkuDetails(System.Collections.Generic.List<string> skus, string type, UnityEngine.Purchasing.Interfaces.ISkuDetailsResponseConsolidator consolidator);

            class <>c__DisplayClass7_0
            {
                /*0x10*/ System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>> onSkuDetailsResponse;
                /*0x18*/ UnityEngine.Purchasing.QuerySkuDetailsService <>4__this;

                /*0x14070a0*/ <>c__DisplayClass7_0();
                /*0x1414280*/ void <QueryAsyncSku>b__0(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> skus);
            }

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.Purchasing.QuerySkuDetailsService <>4__this;
                /*0x18*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;
                /*0x20*/ System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onSkuDetailsResponse;
                /*0x28*/ int retryCount;

                /*0x14070a8*/ <>c__DisplayClass8_0();
                /*0x1414370*/ void <QueryAsyncSku>b__0(System.Action retryAction);
                /*0x1414394*/ void <QueryAsyncSku>g__OnActionRetry|1();
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ UnityEngine.Purchasing.QuerySkuDetailsService <>4__this;
                /*0x18*/ System.Collections.Generic.IReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;
                /*0x20*/ System.Action retryQuery;
                /*0x28*/ System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onSkuDetailsResponse;

                /*0x14071d0*/ <>c__DisplayClass9_0();
                /*0x1414464*/ void <QueryAsyncSkuWithRetries>b__0(UnityEngine.Purchasing.Interfaces.ISkuDetailsQueryResponse skuDetailsQueryResponse);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.QuerySkuDetailsService.<> <>9;
                static /*0x8*/ System.Func<bool, bool> <>9__11_0;
                static /*0x10*/ System.Func<UnityEngine.Purchasing.ProductDefinition, bool> <>9__13_0;
                static /*0x18*/ System.Func<UnityEngine.Purchasing.ProductDefinition, string> <>9__13_1;
                static /*0x20*/ System.Func<UnityEngine.Purchasing.ProductDefinition, bool> <>9__14_0;
                static /*0x28*/ System.Func<UnityEngine.Purchasing.ProductDefinition, string> <>9__14_1;

                static /*0x14141a0*/ <>c();
                /*0x1414200*/ <>c();
                /*0x1414208*/ bool <AreAllSkuDetailsCached>b__11_0(bool isCached);
                /*0x1414210*/ bool <QueryInAppsAsync>b__13_0(UnityEngine.Purchasing.ProductDefinition product);
                /*0x1414230*/ string <QueryInAppsAsync>b__13_1(UnityEngine.Purchasing.ProductDefinition product);
                /*0x1414248*/ bool <QuerySubsAsync>b__14_0(UnityEngine.Purchasing.ProductDefinition product);
                /*0x1414268*/ string <QuerySubsAsync>b__14_1(UnityEngine.Purchasing.ProductDefinition product);
            }
        }

        class SkuDetailsQueryResponse : UnityEngine.Purchasing.Interfaces.ISkuDetailsQueryResponse
        {
            /*0x10*/ System.Collections.Generic.List<System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>>> m_Responses;

            static /*0x1409ea0*/ bool IsRecoverable(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult);
            /*0x1409fc4*/ SkuDetailsQueryResponse();
            /*0x1409a48*/ void AddResponse(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> skuDetails);
            /*0x1409aec*/ System.Collections.Generic.List<UnityEngine.AndroidJavaObject> SkuDetails();
            /*0x1409d00*/ bool IsRecoverable();

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.SkuDetailsQueryResponse.<> <>9;
                static /*0x8*/ System.Func<System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>>, bool> <>9__2_0;
                static /*0x10*/ System.Func<System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>>, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> <>9__2_1;
                static /*0x18*/ System.Func<System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>>, UnityEngine.Purchasing.Models.IGoogleBillingResult> <>9__3_0;

                static /*0x1414d1c*/ <>c();
                /*0x1414d7c*/ <>c();
                /*0x1414d84*/ bool <SkuDetails>b__2_0(System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> response);
                /*0x1414e38*/ System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> <SkuDetails>b__2_1(System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> response);
                /*0x1414e40*/ UnityEngine.Purchasing.Models.IGoogleBillingResult <IsRecoverable>b__3_0(System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> response);
            }
        }

        class SkuDetailsResponseConsolidator : UnityEngine.Purchasing.Interfaces.ISkuDetailsResponseConsolidator
        {
            /*0x10*/ int m_NumberReceivedCallbacks;
            /*0x18*/ System.Action<UnityEngine.Purchasing.Interfaces.ISkuDetailsQueryResponse> m_OnSkuDetailsResponseConsolidated;
            /*0x20*/ UnityEngine.Purchasing.Interfaces.ISkuDetailsQueryResponse m_Responses;

            /*0x14071d8*/ SkuDetailsResponseConsolidator(System.Action<UnityEngine.Purchasing.Interfaces.ISkuDetailsQueryResponse> onSkuDetailsResponseConsolidated);
            /*0x140a03c*/ void Consolidate(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> skuDetails);
        }

        class FakeGooglePlayStoreConfiguration : UnityEngine.Purchasing.IGooglePlayConfiguration, UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
            /*0x13f3d60*/ FakeGooglePlayStoreConfiguration();
        }

        class FakeGooglePlayStoreExtensions : UnityEngine.Purchasing.IGooglePlayStoreExtensions, UnityEngine.Purchasing.IStoreExtension
        {
            /*0x13f3d68*/ FakeGooglePlayStoreExtensions();
        }

        class GooglePlayConfiguration : UnityEngine.Purchasing.IGooglePlayConfiguration, UnityEngine.Purchasing.Extension.IStoreConfiguration, UnityEngine.Purchasing.IGooglePlayConfigurationInternal
        {
            /*0x10*/ System.Action m_InitializationConnectionLister;
            /*0x18*/ UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService;
            /*0x20*/ System.Action<UnityEngine.Purchasing.Product> m_DeferredPurchaseAction;
            /*0x28*/ System.Action<UnityEngine.Purchasing.Product> m_DeferredProrationUpgradeDowngradeSubscriptionAction;
            /*0x30*/ System.Action<int> m_QueryProductDetailsFailedListener;
            /*0x38*/ bool m_FetchPurchasesAtInitialize;

            /*0x13f8cc0*/ GooglePlayConfiguration(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService);
            /*0x13f8cf4*/ void NotifyInitializationConnectionFailed();
            /*0x13f8d08*/ void NotifyQueryProductDetailsFailed(int retryCount);
            /*0x13f8d78*/ void NotifyDeferredProrationUpgradeDowngradeSubscription(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback, string productId);
            /*0x13f8fb4*/ bool IsFetchPurchasesAtInitializeSkipped();
            /*0x13f8fc4*/ void NotifyDeferredPurchase(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback, UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, string receipt, string transactionId);
        }

        class GooglePlayProductCallback : UnityEngine.Purchasing.Interfaces.IGoogleProductCallback
        {
            /*0x10*/ UnityEngine.Purchasing.IGooglePlayConfigurationInternal m_GooglePlayConfigurationInternal;

            /*0x13f91f0*/ GooglePlayProductCallback();
            /*0x13f911c*/ void SetStoreConfiguration(UnityEngine.Purchasing.IGooglePlayConfigurationInternal configuration);
            /*0x13f9124*/ void NotifyQueryProductDetailsFailed(int retryCount);
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

            /*0x13f91f8*/ GooglePlayPurchaseCallback(Uniject.IUtil util);
            /*0x13f9224*/ void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
            /*0x13f922c*/ void SetStoreConfiguration(UnityEngine.Purchasing.IGooglePlayConfigurationInternal configuration);
            /*0x13f9234*/ void OnPurchaseSuccessful(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, string receipt, string purchaseToken);
            /*0x13f93a0*/ void OnPurchaseFailed(UnityEngine.Purchasing.Extension.PurchaseFailureDescription purchaseFailureDescription);
            /*0x13f946c*/ void NotifyDeferredPurchase(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, string receipt, string purchaseToken);
            /*0x13f95bc*/ void NotifyDeferredProrationUpgradeDowngradeSubscription(string sku);

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.Purchasing.GooglePlayPurchaseCallback <>4__this;
                /*0x18*/ UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase;
                /*0x20*/ string receipt;
                /*0x28*/ string purchaseToken;

                /*0x13f95b4*/ <>c__DisplayClass8_0();
                /*0x1412844*/ void <NotifyDeferredPurchase>b__0();
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ UnityEngine.Purchasing.GooglePlayPurchaseCallback <>4__this;
                /*0x18*/ string sku;

                /*0x13f96f0*/ <>c__DisplayClass9_0();
                /*0x141293c*/ void <NotifyDeferredProrationUpgradeDowngradeSubscription>b__0();
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

            /*0x13f96f8*/ GooglePlayStore(UnityEngine.Purchasing.IGooglePlayStoreRetrieveProductsService retrieveProductsService, UnityEngine.Purchasing.IGooglePlayStorePurchaseService storePurchaseService, UnityEngine.Purchasing.IGoogleFetchPurchases fetchPurchases, UnityEngine.Purchasing.IGooglePlayStoreFinishTransactionService transactionService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback googlePurchaseCallback, UnityEngine.Purchasing.IGooglePlayConfigurationInternal googlePlayConfigurationInternal, UnityEngine.Purchasing.IGooglePlayStoreExtensionsInternal googlePlayStoreExtensions, Uniject.IUtil util);
            /*0x13f976c*/ void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback callback);
            /*0x13f9a90*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x13f9c30*/ bool HasInitiallyRetrievedProducts();
            /*0x13f9b60*/ bool ShouldFetchPurchasesNext();
            /*0x13f9ce0*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, string dummy);
            /*0x13f9d9c*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId);
            /*0x13f9e64*/ void OnPause(bool isPaused);
        }

        class GooglePlayStoreExtensions : UnityEngine.Purchasing.IGooglePlayStoreExtensions, UnityEngine.Purchasing.IStoreExtension, UnityEngine.Purchasing.IGooglePlayStoreExtensionsInternal
        {
            /*0x10*/ UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService;
            /*0x18*/ UnityEngine.Purchasing.IGooglePlayStoreFinishTransactionService m_GooglePlayStoreFinishTransactionService;
            /*0x20*/ UnityEngine.ILogger m_Logger;
            /*0x28*/ UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics;
            /*0x30*/ UnityEngine.Purchasing.Extension.IStoreCallback m_StoreCallback;

            /*0x13f9fb4*/ GooglePlayStoreExtensions(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService, UnityEngine.Purchasing.IGooglePlayStoreFinishTransactionService googlePlayStoreFinishTransactionService, UnityEngine.ILogger logger, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics);
            /*0x13fa000*/ void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
        }

        interface IGooglePlayConfiguration : UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
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
            /*0x38*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService m_TelemetryMetricsService;

            /*0x1404f78*/ MetricizedGooglePlayStoreExtensions(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService, UnityEngine.Purchasing.IGooglePlayStoreFinishTransactionService googlePlayStoreFinishTransactionService, UnityEngine.ILogger logger, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics, UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService telemetryMetricsService);
        }

        class GoogleProductMetadata : UnityEngine.Purchasing.ProductMetadata
        {
            /*0x40*/ string <originalJson>k__BackingField;
            /*0x48*/ string <subscriptionPeriod>k__BackingField;
            /*0x50*/ string <freeTrialPeriod>k__BackingField;
            /*0x58*/ string <introductoryPrice>k__BackingField;
            /*0x60*/ string <introductoryPricePeriod>k__BackingField;
            /*0x68*/ int <introductoryPriceCycles>k__BackingField;

            /*0x13fca34*/ GoogleProductMetadata(string priceString, string title, string description, string currencyCode, decimal localizedPrice);
            /*0x13fca04*/ void set_originalJson(string value);
            /*0x13fca0c*/ void set_subscriptionPeriod(string value);
            /*0x13fca14*/ void set_freeTrialPeriod(string value);
            /*0x13fca1c*/ void set_introductoryPrice(string value);
            /*0x13fca24*/ void set_introductoryPricePeriod(string value);
            /*0x13fca2c*/ void set_introductoryPriceCycles(int value);
        }

        class GoogleFetchPurchases : UnityEngine.Purchasing.IGoogleFetchPurchases
        {
            /*0x10*/ UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService;
            /*0x18*/ UnityEngine.Purchasing.Extension.IStoreCallback m_StoreCallback;

            static /*0x13f84c0*/ UnityEngine.Purchasing.Product CompleteProductInfoWithPurchase(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase);
            /*0x13f7f30*/ GoogleFetchPurchases(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService);
            /*0x13f7f5c*/ void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
            /*0x13f7f64*/ void FetchPurchases();
            /*0x13f8078*/ void FetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> onQueryPurchaseSucceed);
            /*0x13f81c8*/ System.Collections.Generic.List<UnityEngine.Purchasing.Product> FillProductsWithPurchases(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases);
            /*0x13f8298*/ System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Product> BuildProductsFromPurchase(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase);
            /*0x13f8638*/ void OnFetchedPurchase(System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases);

            class <>c__DisplayClass5_0
            {
                /*0x10*/ System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> onQueryPurchaseSucceed;
                /*0x18*/ UnityEngine.Purchasing.GoogleFetchPurchases <>4__this;

                /*0x13f81c0*/ <>c__DisplayClass5_0();
                /*0x1411ef8*/ void <FetchPurchases>b__0(System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> googlePurchases);
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ UnityEngine.Purchasing.GoogleFetchPurchases <>4__this;
                /*0x18*/ UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase;

                /*0x13f84b8*/ <>c__DisplayClass7_0();
                /*0x1411f70*/ UnityEngine.Purchasing.Product <BuildProductsFromPurchase>b__0(string sku);
                /*0x1411f94*/ UnityEngine.Purchasing.Product <BuildProductsFromPurchase>b__1(UnityEngine.Purchasing.Product product);
            }
        }

        class GooglePlayStoreFinishTransactionService : UnityEngine.Purchasing.IGooglePlayStoreFinishTransactionService
        {
            /*0x10*/ System.Collections.Generic.HashSet<string> m_ProcessedPurchaseToken;
            /*0x18*/ UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService;
            /*0x20*/ UnityEngine.Purchasing.Extension.IStoreCallback m_StoreCallback;

            static /*0x13fa8f4*/ bool IsResponseCodeInRecoverableState(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult);
            /*0x13fa008*/ GooglePlayStoreFinishTransactionService(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService);
            /*0x13fa090*/ void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
            /*0x13fa098*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string purchaseToken);
            /*0x13fa1fc*/ void HandleFinishTransaction(UnityEngine.Purchasing.ProductDefinition product, UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase);
            /*0x13fa6cc*/ void CallPurchaseSucceededUpdateReceipt(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase);

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.Purchasing.GooglePlayStoreFinishTransactionService <>4__this;
                /*0x18*/ UnityEngine.Purchasing.ProductDefinition product;

                /*0x13fa1f4*/ <>c__DisplayClass5_0();
                /*0x1412a1c*/ void <FinishTransaction>b__0(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase);
            }
        }

        class GooglePlayStorePurchaseService : UnityEngine.Purchasing.IGooglePlayStorePurchaseService
        {
            /*0x10*/ UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService;

            /*0x13faa80*/ GooglePlayStorePurchaseService(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService);
            /*0x13faaac*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product);
        }

        class GooglePlayStoreRetrieveProductsService : UnityEngine.Purchasing.IGooglePlayStoreRetrieveProductsService
        {
            /*0x10*/ UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService;
            /*0x18*/ UnityEngine.Purchasing.IGoogleFetchPurchases m_GoogleFetchPurchases;
            /*0x20*/ UnityEngine.Purchasing.Extension.IStoreCallback m_StoreCallback;
            /*0x28*/ UnityEngine.Purchasing.IGooglePlayConfigurationInternal m_GooglePlayConfigurationInternal;
            /*0x30*/ bool m_HasInitiallyRetrievedProducts;

            static /*0x13fb224*/ System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> MakePurchasesIntoProducts(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> retrievedProducts, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Product> purchaseProducts);
            /*0x13fab6c*/ GooglePlayStoreRetrieveProductsService(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService, UnityEngine.Purchasing.IGoogleFetchPurchases googleFetchPurchases, UnityEngine.Purchasing.IGooglePlayConfigurationInternal googlePlayConfigurationInternal);
            /*0x13fabb0*/ void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
            /*0x13fabb8*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, bool wantPurchases);
            /*0x13fadec*/ void OnProductsRetrievedWithPurchaseFetch(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> retrievedProducts);
            /*0x13faf44*/ void OnProductsRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> retrievedProducts);
            /*0x13fb018*/ void OnRetrieveProductsFailed(UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason reason);
            /*0x13fb174*/ void ResumeConnection();
            /*0x13fb6c4*/ bool HasInitiallyRetrievedProducts();

            class <>c__DisplayClass8_0
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> retrievedProducts;
                /*0x18*/ UnityEngine.Purchasing.GooglePlayStoreRetrieveProductsService <>4__this;

                /*0x13faf3c*/ <>c__DisplayClass8_0();
                /*0x1412a78*/ void <OnProductsRetrievedWithPurchaseFetch>b__0(System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchaseProducts);
            }

            class <>c__DisplayClass12_0
            {
                /*0x10*/ UnityEngine.Purchasing.Product purchaseProduct;

                /*0x13fb6bc*/ <>c__DisplayClass12_0();
                /*0x1412a44*/ bool <MakePurchasesIntoProducts>b__0(UnityEngine.Purchasing.Extension.ProductDescription product);
            }
        }

        class StoreCallbackExtensionMethods
        {
            static /*0x13f8dfc*/ UnityEngine.Purchasing.Product FindProductById(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback, string sku);
        }

        interface IAndroidStoreSelection : UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
        }

        interface IUnityCallback
        {
            void OnSetupFailed(string json);
            void OnProductsRetrieved(string json);
            void OnPurchaseSucceeded(string id, string receipt, string transactionID);
            void OnPurchaseFailed(string json);
        }

        class SerializationExtensions
        {
            static /*0x14036bc*/ string TryGetString(System.Collections.Generic.Dictionary<string, object> dic, string key);
        }

        class JSONSerializer
        {
            static /*0x1402344*/ string SerializeProductDef(UnityEngine.Purchasing.ProductDefinition product);
            static /*0x1402c04*/ string SerializeProductDefs(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products);
            static /*0x1402f24*/ string SerializeProductDescs(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Extension.ProductDescription> products);
            static /*0x13f13ec*/ System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> DeserializeProductDescriptions(string json);
            static /*0x1403780*/ UnityEngine.Purchasing.Extension.PurchaseFailureDescription DeserializeFailureReason(string json);
            static /*0x1403454*/ UnityEngine.Purchasing.ProductMetadata DeserializeMetadata(System.Collections.Generic.Dictionary<string, object> data);
            static /*0x140235c*/ System.Collections.Generic.Dictionary<string, object> EncodeProductDef(UnityEngine.Purchasing.ProductDefinition product);
            static /*0x1403244*/ System.Collections.Generic.Dictionary<string, object> EncodeProductDesc(UnityEngine.Purchasing.Extension.ProductDescription product);
            static /*0x1403b64*/ System.Collections.Generic.Dictionary<string, object> EncodeProductMeta(UnityEngine.Purchasing.ProductMetadata product);
        }

        class JavaBridge : UnityEngine.AndroidJavaProxy, UnityEngine.Purchasing.IUnityCallback
        {
            /*0x20*/ UnityEngine.Purchasing.IUnityCallback forwardTo;

            /*0x14043e0*/ JavaBridge(UnityEngine.Purchasing.IUnityCallback forwardTo);
            /*0x1404470*/ JavaBridge(UnityEngine.Purchasing.IUnityCallback forwardTo, string javaInterface);
            /*0x14044f0*/ void OnSetupFailed(string json);
            /*0x14045ac*/ void OnProductsRetrieved(string json);
            /*0x140466c*/ void OnPurchaseSucceeded(string id, string receipt, string transactionID);
            /*0x1404744*/ void OnPurchaseFailed(string json);
        }

        class ScriptingStoreCallback : UnityEngine.Purchasing.Extension.IStoreCallback
        {
            /*0x10*/ UnityEngine.Purchasing.Extension.IStoreCallback m_ForwardTo;
            /*0x18*/ Uniject.IUtil m_Util;

            /*0x13f9a58*/ ScriptingStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback forwardTo, Uniject.IUtil util);
            /*0x1407d1c*/ UnityEngine.Purchasing.ProductCollection get_products();
            /*0x1407dc8*/ void OnSetupFailed(UnityEngine.Purchasing.InitializationFailureReason reason);
            /*0x1407f08*/ void OnProductsRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products);
            /*0x1408044*/ void OnPurchaseSucceeded(string id, string receipt, string transactionID);
            /*0x1408194*/ void OnAllPurchasesRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchasedProducts);
            /*0x14082d0*/ void OnPurchaseFailed(UnityEngine.Purchasing.Extension.PurchaseFailureDescription desc);

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingStoreCallback <>4__this;
                /*0x18*/ UnityEngine.Purchasing.InitializationFailureReason reason;

                /*0x1407f00*/ <>c__DisplayClass5_0();
                /*0x1414638*/ void <OnSetupFailed>b__0();
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingStoreCallback <>4__this;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products;

                /*0x140803c*/ <>c__DisplayClass6_0();
                /*0x14146f8*/ void <OnProductsRetrieved>b__0();
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingStoreCallback <>4__this;
                /*0x18*/ string id;
                /*0x20*/ string receipt;
                /*0x28*/ string transactionID;

                /*0x140818c*/ <>c__DisplayClass7_0();
                /*0x14147b8*/ void <OnPurchaseSucceeded>b__0();
            }

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingStoreCallback <>4__this;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchasedProducts;

                /*0x14082c8*/ <>c__DisplayClass8_0();
                /*0x141488c*/ void <OnAllPurchasesRetrieved>b__0();
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingStoreCallback <>4__this;
                /*0x18*/ UnityEngine.Purchasing.Extension.PurchaseFailureDescription desc;

                /*0x1408404*/ <>c__DisplayClass9_0();
                /*0x141494c*/ void <OnPurchaseFailed>b__0();
            }
        }

        class ScriptingUnityCallback : UnityEngine.Purchasing.IUnityCallback
        {
            /*0x10*/ UnityEngine.Purchasing.IUnityCallback forwardTo;
            /*0x18*/ Uniject.IUtil util;

            /*0x1406000*/ ScriptingUnityCallback(UnityEngine.Purchasing.IUnityCallback forwardTo, Uniject.IUtil util);
            /*0x140840c*/ void OnSetupFailed(string json);
            /*0x1408548*/ void OnProductsRetrieved(string json);
            /*0x1408684*/ void OnPurchaseSucceeded(string id, string receipt, string transactionID);
            /*0x14087d4*/ void OnPurchaseFailed(string json);

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingUnityCallback <>4__this;
                /*0x18*/ string json;

                /*0x1408540*/ <>c__DisplayClass3_0();
                /*0x1414a0c*/ void <OnSetupFailed>b__0();
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingUnityCallback <>4__this;
                /*0x18*/ string json;

                /*0x140867c*/ <>c__DisplayClass4_0();
                /*0x1414ac8*/ void <OnProductsRetrieved>b__0();
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingUnityCallback <>4__this;
                /*0x18*/ string id;
                /*0x20*/ string receipt;
                /*0x28*/ string transactionID;

                /*0x14087cc*/ <>c__DisplayClass5_0();
                /*0x1414b88*/ void <OnPurchaseSucceeded>b__0();
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingUnityCallback <>4__this;
                /*0x18*/ string json;

                /*0x1408908*/ <>c__DisplayClass6_0();
                /*0x1414c5c*/ void <OnPurchaseFailed>b__0();
            }
        }

        class FakeUDPExtension : UnityEngine.Purchasing.IUDPExtensions, UnityEngine.Purchasing.IStoreExtension
        {
            /*0x13f56ac*/ FakeUDPExtension();
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
        }

        class UDP
        {
            static /*0x140c37c*/ string get_Name();
        }

        class UDPBindings : UnityEngine.Purchasing.INativeUDPStore, UnityEngine.Purchasing.INativeStore
        {
            /*0x10*/ object m_Bridge;
            /*0x18*/ System.Action<bool, string> m_RetrieveProductsCallbackCache;

            static /*0x140dad0*/ System.Collections.Generic.Dictionary<string, string> StringPropertyToDictionary(object info);
            /*0x1406134*/ UDPBindings();
            /*0x140c650*/ void Initialize(System.Action<bool, string> callback);
            /*0x140c7f8*/ void Purchase(string productId, System.Action<bool, string> callback, string developerPayload);
            /*0x140ca00*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<bool, string> callback);
            /*0x140cf60*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition productDefinition, string transactionID);
            /*0x140d108*/ void OnInventoryQueried(bool success, object payload);
            /*0x140dce4*/ void RetrieveProducts(string json);
            /*0x140dd24*/ void Purchase(string productJSON, string developerPayload);
            /*0x140dd64*/ void FinishTransaction(string productJSON, string transactionID);
        }

        class UDPImpl : UnityEngine.Purchasing.JSONStore, UnityEngine.Purchasing.IUDPExtensions, UnityEngine.Purchasing.IStoreExtension
        {
            /*0x40*/ UnityEngine.Purchasing.INativeUDPStore m_Bindings;
            /*0x48*/ object m_UserInfo;
            /*0x50*/ string m_LastInitError;
            /*0x58*/ bool m_Initialized;
            /*0x60*/ System.Action<UnityEngine.Purchasing.Product> m_DeferredCallback;

            static /*0x140e344*/ void DictionaryToStringProperty(System.Collections.Generic.Dictionary<string, object> dic, object info);
            /*0x1406124*/ UDPImpl();
            /*0x140dda4*/ void SetNativeStore(UnityEngine.Purchasing.INativeUDPStore nativeUdpStore);
            /*0x140ddac*/ void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback callback);
            /*0x140ddb4*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x140dfc8*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);
            /*0x140e12c*/ void OnPurchaseDeferred(string productId);
            /*0x140e25c*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId);

            class <>c__DisplayClass10_0
            {
                /*0x10*/ UnityEngine.Purchasing.UDPImpl <>4__this;
                /*0x18*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;
                /*0x20*/ System.Action<bool, string> retrieveCallback;

                /*0x2b07c8c*/ <>c__DisplayClass10_0();
                /*0x2b07c94*/ void <RetrieveProducts>b__0(bool success, string json);
                /*0x2b07d50*/ void <RetrieveProducts>b__1(bool success, string message);
            }

            class <>c__DisplayClass11_0
            {
                /*0x10*/ UnityEngine.Purchasing.ProductDefinition product;
                /*0x18*/ UnityEngine.Purchasing.UDPImpl <>4__this;

                /*0x2b07fe8*/ <>c__DisplayClass11_0();
                /*0x2b07ff0*/ void <Purchase>b__0(bool success, string message);
            }
        }

        class UDPReflectionUtils
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<System.Reflection.Assembly, System.Type[]> s_assemblyTypeCache;
            static /*0x8*/ System.Collections.Generic.Dictionary<string, System.Type> s_typeCache;
            static /*0x10*/ string[] k_whiteListedAssemblies;

            static /*0x140e610*/ UDPReflectionUtils();
            static /*0x14019b0*/ System.Type GetTypeByName(string typeName);
            static /*0x140e4d8*/ System.Collections.Generic.IEnumerable<System.Reflection.Assembly> GetAllAssemblies();
            static /*0x140e4fc*/ System.Collections.Generic.IEnumerable<System.Type> GetTypes(System.Reflection.Assembly assembly);

            class <>c__DisplayClass6_0
            {
                /*0x10*/ System.Reflection.Assembly assembly;

                /*0x2b086f8*/ <>c__DisplayClass6_0();
                /*0x2b08700*/ bool <GetTypeByName>b__0(string x);
            }
        }

        class InventoryInterface
        {
            static /*0x0*/ System.Type s_typeCache;

            static /*0x14018c4*/ System.Type GetClassType();
            static /*0x140223c*/ System.Reflection.MethodInfo GetProductListMethod();
            static /*0x1402294*/ System.Reflection.MethodInfo GetPurchaseInfoMethod();
            static /*0x14022ec*/ System.Reflection.MethodInfo HasPurchaseMethod();
        }

        class ProductInfoInterface
        {
            static /*0x0*/ System.Type s_typeCache;

            static /*0x1406a0c*/ System.Type GetClassType();
            static /*0x1406af8*/ System.Reflection.PropertyInfo GetCurrencyProp();
            static /*0x1406b50*/ System.Reflection.PropertyInfo GetDescriptionProp();
            static /*0x1406ba8*/ System.Reflection.PropertyInfo GetPriceProp();
            static /*0x1406c00*/ System.Reflection.PropertyInfo GetPriceAmountMicrosProp();
            static /*0x1406c58*/ System.Reflection.PropertyInfo GetProductIdProp();
            static /*0x1406cb0*/ System.Reflection.PropertyInfo GetTitleProp();
        }

        class StoreServiceInterface
        {
            static /*0x0*/ System.Type s_typeCache;

            static /*0x140c484*/ System.Type GetClassType();
            static /*0x140c570*/ System.Reflection.PropertyInfo GetNameProp();
            static /*0x140c5d0*/ string GetName();
        }

        class UdpIapBridgeInterface
        {
            static /*0x0*/ System.Type s_typeCache;

            static /*0x1406038*/ System.Type GetClassType();
            static /*0x140c7a0*/ System.Reflection.MethodInfo GetInitMethod();
            static /*0x140c9a8*/ System.Reflection.MethodInfo GetPurchaseMethod();
            static /*0x140cf08*/ System.Reflection.MethodInfo GetRetrieveProductsMethod();
            static /*0x140d0b0*/ System.Reflection.MethodInfo GetFinishTransactionMethod();
        }

        class UserInfoInterface
        {
            static /*0x0*/ System.Type s_typeCache;

            static /*0x1410f64*/ System.Type GetClassType();
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

        class AppleStoreImpl : UnityEngine.Purchasing.JSONStore, UnityEngine.Purchasing.IAppleExtensions, UnityEngine.Purchasing.IStoreExtension, UnityEngine.Purchasing.IAppleConfiguration, UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
            static /*0x0*/ Uniject.IUtil util;
            static /*0x8*/ UnityEngine.Purchasing.AppleStoreImpl instance;
            /*0x40*/ System.Action<UnityEngine.Purchasing.Product> m_DeferredCallback;
            /*0x48*/ System.Action m_RefreshReceiptError;
            /*0x50*/ System.Action<string> m_RefreshReceiptSuccess;
            /*0x58*/ System.Action<bool> m_RestoreCallback;
            /*0x60*/ System.Action m_FetchStorePromotionOrderError;
            /*0x68*/ System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> m_FetchStorePromotionOrderSuccess;
            /*0x70*/ System.Action<UnityEngine.Purchasing.Product> m_PromotionalPurchaseCallback;
            /*0x78*/ System.Action m_FetchStorePromotionVisibilityError;
            /*0x80*/ System.Action<string, UnityEngine.Purchasing.AppleStorePromotionVisibility> m_FetchStorePromotionVisibilitySuccess;
            /*0x88*/ UnityEngine.Purchasing.INativeAppleStore m_Native;
            /*0x90*/ UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics;
            /*0x98*/ string products_json;

            static /*0x13f0874*/ void MessageCallback(string subject, string payload, string receipt, string transactionId);
            /*0x13f09d8*/ AppleStoreImpl(Uniject.IUtil util, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics);
            /*0x13f0a6c*/ void SetNativeStore(UnityEngine.Purchasing.INativeAppleStore apple);
            /*0x13f0b70*/ void OnProductsRetrieved(string json);
            /*0x13f220c*/ void OnPurchaseDeferred(string productId);
            /*0x13f2318*/ void OnPromotionalPurchaseAttempted(string productId);
            /*0x13f2424*/ void OnTransactionsRestoredSuccess();
            /*0x13f2484*/ void OnTransactionsRestoredFail(string error);
            /*0x13f24e4*/ void OnAppReceiptRetrieved(string receipt);
            /*0x13f2558*/ void OnAppReceiptRefreshedFailed();
            /*0x13f256c*/ void OnFetchStorePromotionOrderSucceeded(string productIds);
            /*0x13f281c*/ void OnFetchStorePromotionOrderFailed();
            /*0x13f2830*/ void OnFetchStorePromotionVisibilitySucceeded(string result);
            /*0x13f2b54*/ void OnFetchStorePromotionVisibilityFailed();
            /*0x13f2b70*/ void ProcessMessage(string subject, string payload, string receipt, string transactionId);
            /*0x13f3284*/ void OnPurchaseSucceeded(string id, string receipt, string transactionId);
            /*0x13f17b8*/ UnityEngine.Purchasing.Security.AppleReceipt getAppleReceiptFromBase64String(string receipt);
            /*0x13f32f8*/ bool isValidPurchaseState(UnityEngine.Purchasing.Security.AppleReceipt appleReceipt, string id);

            class <>c__DisplayClass30_0
            {
                /*0x10*/ UnityEngine.Purchasing.Extension.ProductDescription productDescription;

                /*0x13f1998*/ <>c__DisplayClass30_0();
                /*0x141187c*/ bool <OnProductsRetrieved>b__0(UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt r);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.AppleStoreImpl.<> <>9;
                static /*0x8*/ System.Comparison<UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt> <>9__30_1;
                static /*0x10*/ System.Func<System.Collections.Generic.KeyValuePair<string, object>, string> <>9__46_0;
                static /*0x18*/ System.Func<System.Collections.Generic.KeyValuePair<string, object>, string> <>9__46_1;
                static /*0x20*/ System.Comparison<UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt> <>9__52_1;

                static /*0x1411704*/ <>c();
                /*0x1411764*/ <>c();
                /*0x141176c*/ int <OnProductsRetrieved>b__30_1(UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt b, UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt a);
                /*0x14117ac*/ string <OnFetchStorePromotionVisibilitySucceeded>b__46_0(System.Collections.Generic.KeyValuePair<string, object> k);
                /*0x14117ec*/ string <OnFetchStorePromotionVisibilitySucceeded>b__46_1(System.Collections.Generic.KeyValuePair<string, object> k);
                /*0x141183c*/ int <isValidPurchaseState>b__52_1(UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt b, UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt a);
            }

            class <>c__DisplayClass48_0
            {
                /*0x10*/ string subject;
                /*0x18*/ string payload;
                /*0x20*/ string receipt;
                /*0x28*/ string transactionId;

                /*0x13f2b68*/ <>c__DisplayClass48_0();
                /*0x14118a8*/ void <MessageCallback>b__0();
            }

            class <>c__DisplayClass52_0
            {
                /*0x10*/ string id;

                /*0x13f3800*/ <>c__DisplayClass52_0();
                /*0x1411908*/ bool <isValidPurchaseState>b__0(UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt r);
            }
        }

        class FakeAppleConfiguation : UnityEngine.Purchasing.IAppleConfiguration, UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
            /*0x13f3d50*/ FakeAppleConfiguation();
        }

        class FakeAppleExtensions : UnityEngine.Purchasing.IAppleExtensions, UnityEngine.Purchasing.IStoreExtension
        {
            /*0x13f3d58*/ FakeAppleExtensions();
        }

        interface IAppleConfiguration : UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
        }

        interface IAppleExtensions : UnityEngine.Purchasing.IStoreExtension
        {
        }

        enum AppleStorePromotionVisibility
        {
            Default = 0,
            Hide = 1,
            Show = 2,
        }

        class MetricizedAppleStoreImpl : UnityEngine.Purchasing.AppleStoreImpl
        {
            /*0xa0*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService m_TelemetryMetricsService;

            /*0x1404c50*/ MetricizedAppleStoreImpl(Uniject.IUtil util, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics, UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService telemetryMetricsService);
            /*0x1404c78*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x1404df0*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);
            /*0x1404f70*/ void <>n__5(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x1404f74*/ void <>n__6(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);

            class <>c__DisplayClass9_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedAppleStoreImpl <>4__this;
                /*0x18*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;

                /*0x1404de8*/ <>c__DisplayClass9_0();
                /*0x14140f8*/ void <RetrieveProducts>b__0();
            }

            class <>c__DisplayClass10_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedAppleStoreImpl <>4__this;
                /*0x18*/ UnityEngine.Purchasing.ProductDefinition product;
                /*0x20*/ string developerPayload;

                /*0x1404f68*/ <>c__DisplayClass10_0();
                /*0x14140d8*/ void <Purchase>b__0();
            }
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
            /*0x10*/ UnityEngine.Purchasing.Extension.IStoreCallback unity;
            /*0x18*/ UnityEngine.Purchasing.INativeStore m_Store;
            /*0x20*/ UnityEngine.Purchasing.StandardPurchasingModule m_Module;
            /*0x28*/ UnityEngine.ILogger m_Logger;
            /*0x30*/ UnityEngine.Purchasing.Extension.PurchaseFailureDescription m_LastPurchaseFailureDescription;
            /*0x38*/ UnityEngine.Purchasing.StoreSpecificPurchaseErrorCode m_LastPurchaseErrorCode;

            /*0x13f0a5c*/ JSONStore();
            /*0x1403d30*/ void SetNativeStore(UnityEngine.Purchasing.INativeStore native);
            /*0x1403d38*/ void UnityEngine.Purchasing.IStoreInternal.SetModule(UnityEngine.Purchasing.StandardPurchasingModule module);
            /*0x13f3da8*/ void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback callback);
            /*0x1403df8*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x1403ec0*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);
            /*0x13f3720*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId);
            /*0x13f30bc*/ void OnSetupFailed(string reason);
            /*0x1403f9c*/ void OnProductsRetrieved(string json);
            /*0x13f3648*/ void OnPurchaseSucceeded(string id, string receipt, string transactionID);
            /*0x13f3250*/ void OnPurchaseFailed(string json);
            /*0x1404068*/ void OnPurchaseFailed(UnityEngine.Purchasing.Extension.PurchaseFailureDescription failure, string json);
            /*0x140413c*/ UnityEngine.Purchasing.StoreSpecificPurchaseErrorCode ParseStoreSpecificPurchaseErrorCode(string json);
        }

        class MetricizedJsonStore : UnityEngine.Purchasing.JSONStore
        {
            /*0x40*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService m_TelemetryMetricsService;

            /*0x14055ac*/ MetricizedJsonStore(UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService telemetryMetricsService);
            /*0x14055e0*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x1405758*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);
            /*0x14058d8*/ void <>n__0(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x14058dc*/ void <>n__1(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedJsonStore <>4__this;
                /*0x18*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;

                /*0x1405750*/ <>c__DisplayClass2_0();
                /*0x1414160*/ void <RetrieveProducts>b__0();
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedJsonStore <>4__this;
                /*0x18*/ UnityEngine.Purchasing.ProductDefinition product;
                /*0x20*/ string developerPayload;

                /*0x14058d0*/ <>c__DisplayClass3_0();
                /*0x1414180*/ void <Purchase>b__0();
            }
        }

        class NativeStoreProvider : UnityEngine.Purchasing.INativeStoreProvider
        {
            /*0x14062f0*/ NativeStoreProvider();
            /*0x14058e0*/ UnityEngine.Purchasing.INativeStore GetAndroidStore(UnityEngine.Purchasing.IUnityCallback callback, UnityEngine.Purchasing.AppStore store, UnityEngine.Purchasing.Extension.IPurchasingBinder binder, Uniject.IUtil util);
            /*0x1405a14*/ UnityEngine.Purchasing.INativeStore GetAndroidStoreHelper(UnityEngine.Purchasing.IUnityCallback callback, UnityEngine.Purchasing.AppStore store, UnityEngine.Purchasing.Extension.IPurchasingBinder binder, Uniject.IUtil util);
            /*0x140624c*/ UnityEngine.Purchasing.INativeAppleStore GetStorekit(UnityEngine.Purchasing.IUnityCallback callback);
        }

        class DialogRequest
        {
            /*0x10*/ string QueryText;
            /*0x18*/ string OkayButtonText;
            /*0x20*/ string CancelButtonText;
            /*0x28*/ System.Collections.Generic.List<string> Options;
            /*0x30*/ System.Action<bool, int> Callback;

            /*0x13f3b90*/ DialogRequest();
        }

        enum FakeStoreUIMode
        {
            Default = 0,
            StandardUser = 1,
            DeveloperUser = 2,
        }

        class FakeStore : UnityEngine.Purchasing.JSONStore, UnityEngine.Purchasing.IStoreExtension, UnityEngine.Purchasing.INativeStore
        {
            /*0x40*/ UnityEngine.Purchasing.Extension.IStoreCallback m_Biller;
            /*0x48*/ System.Collections.Generic.List<string> m_PurchasedProducts;
            /*0x50*/ bool purchaseCalled;
            /*0x58*/ string <unavailableProductId>k__BackingField;
            /*0x60*/ UnityEngine.Purchasing.FakeStoreUIMode UIMode;

            /*0x13f5620*/ FakeStore();
            /*0x13f3d78*/ string get_unavailableProductId();
            /*0x13f3d80*/ void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback biller);
            /*0x13f3e30*/ void RetrieveProducts(string json);
            /*0x13f46ac*/ void StoreRetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> productDefinitions);
            /*0x13f509c*/ void Purchase(string productJSON, string developerPayload);
            /*0x13f53a0*/ void FakePurchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);
            /*0x13f5618*/ void FinishTransaction(string productJSON, string transactionID);
            /*0x13f561c*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId);
            bool StartUI<T>(object model, UnityEngine.Purchasing.FakeStore.DialogType dialogType, System.Action<bool, T> callback);
            /*0x13f56a0*/ void <>n__0(string id, string receipt, string transactionID);

            enum DialogType
            {
                Purchase = 0,
                RetrieveProducts = 1,
            }

            class <>c__DisplayClass13_0
            {
                /*0x10*/ UnityEngine.Purchasing.FakeStore <>4__this;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products;

                /*0x13f4fbc*/ <>c__DisplayClass13_0();
                /*0x1411af4*/ void <StoreRetrieveProducts>b__0(bool allow, UnityEngine.Purchasing.InitializationFailureReason failureReason);
            }

            class <>c__DisplayClass15_0
            {
                /*0x10*/ UnityEngine.Purchasing.FakeStore <>4__this;
                /*0x18*/ UnityEngine.Purchasing.ProductDefinition product;

                /*0x13f5610*/ <>c__DisplayClass15_0();
                /*0x1411c48*/ void <FakePurchase>b__0(bool allow, UnityEngine.Purchasing.PurchaseFailureReason failureReason);
            }
        }

        class LifecycleNotifier : UnityEngine.MonoBehaviour
        {
            /*0x18*/ System.Action OnDestroyCallback;

            /*0x1404818*/ LifecycleNotifier();
            /*0x1404804*/ void OnDestroy();
        }

        class UIFakeStore : UnityEngine.Purchasing.FakeStore
        {
            /*0x68*/ UnityEngine.Purchasing.DialogRequest m_CurrentDialog;
            /*0x70*/ int m_LastSelectedDropdownIndex;
            /*0x78*/ UnityEngine.GameObject m_UIFakeStoreWindowObject;
            /*0x80*/ UnityEngine.GameObject m_EventSystem;

            /*0x140c250*/ UIFakeStore();
            bool StartUI<T>(object model, UnityEngine.Purchasing.FakeStore.DialogType dialogType, System.Action<bool, T> callback);
            /*0x140e834*/ bool StartUI(string queryText, string okayButtonText, string cancelButtonText, System.Collections.Generic.List<string> options, System.Action<bool, int> callback);
            /*0x140e8fc*/ void InstantiateDialog();
            /*0x140e9f4*/ UnityEngine.Purchasing.UIFakeStoreWindow GetOrCreateFakeStoreWindow();
            /*0x140ebbc*/ void AddLifeCycleNotifierAndSetDestroyCallback(UnityEngine.GameObject gameObject);
            /*0x140ec74*/ void EnsureEventSystemCreated(UnityEngine.Transform rootTransform);
            /*0x140ed20*/ void ConfigureDialogWindow(UnityEngine.Purchasing.UIFakeStoreWindow dialogWindow);
            /*0x140f024*/ void ConfigureDialogWindowCallbacks(UnityEngine.Purchasing.UIFakeStoreWindow dialogWindow, bool assignCancelCallback, bool assignDropDownCallback);
            /*0x140eda0*/ void CreateEventSystem(UnityEngine.Transform rootTransform);
            /*0x140f1a8*/ string CreatePurchaseQuestion(UnityEngine.Purchasing.ProductDefinition definition);
            /*0x140f218*/ string CreateRetrieveProductsQuestion(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> definitions);
            /*0x140f45c*/ void OkayButtonClicked();
            /*0x140f5e0*/ void CancelButtonClicked();
            /*0x140f68c*/ void DropdownValueChanged(int selectedItem);
            /*0x140f52c*/ void CloseDialog();
            /*0x140e8ec*/ bool IsShowingDialog();
            /*0x140f694*/ void <AddLifeCycleNotifierAndSetDestroyCallback>b__14_0();

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

                static /*0x2b08740*/ <>c();
                /*0x2b087a0*/ <>c();
                /*0x2b087a8*/ string <CreateRetrieveProductsQuestion>b__20_0(UnityEngine.Purchasing.ProductDefinition pid);
            }
        }

        class UIFakeStoreDropdown
        {
            /*0x10*/ System.Collections.Generic.List<string> m_Options;
            /*0x18*/ System.Action<int, string> m_OnDropdown;
            /*0x20*/ UnityEngine.Vector2 scrollPosition;

            /*0x140fb30*/ UIFakeStoreDropdown();
            /*0x140f69c*/ void DoPopup(int windowID);
            /*0x140f9fc*/ void OnOptionSelected(int optionIndex);
            /*0x140faa8*/ void SetOptions(System.Collections.Generic.List<string> options);
            /*0x140fb28*/ void SetSelectionAction(System.Action<int, string> onDropdown);
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

            /*0x1410230*/ UIFakeStoreWindow();
            /*0x140fb38*/ void OnGUI();
            /*0x140fcc8*/ UnityEngine.Rect CreateCenteredWindowRect();
            /*0x140fd68*/ void DoMainGUI(int windowID);
            /*0x141018c*/ void DoDropDown();
            /*0x1410198*/ void OnOkClicked();
            /*0x14101ac*/ void OnCancelClicked();
            /*0x140ef24*/ void ConfigureMainDialogText(string queryText, string okText, string cancelText);
            /*0x140ef30*/ void ConfigureDropdownOptions(System.Collections.Generic.List<string> options);
            /*0x14101c0*/ void OnDropdown(int index, string selectionText);
            /*0x140f184*/ void AssignCallbacks(System.Action onOk, System.Action onCancel, System.Action<int> onDropdown);
        }

        class Price : UnityEngine.ISerializationCallbackReceiver
        {
            /*0x10*/ decimal value;
            /*0x20*/ int[] data;
            /*0x28*/ double num;

            /*0x14064bc*/ Price();
            /*0x14063dc*/ void OnBeforeSerialize();
            /*0x140646c*/ void OnAfterDeserialize();
        }

        class StoreID
        {
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

        class LocalizedProductDescription
        {
            /*0x10*/ UnityEngine.Purchasing.TranslationLocale googleLocale;
            /*0x18*/ string title;
            /*0x20*/ string description;

            static /*0x1404ae4*/ string DecodeNonLatinCharacters(string s);
            /*0x1404c40*/ LocalizedProductDescription();
            /*0x13f508c*/ string get_Title();
            /*0x13f5094*/ string get_Description();

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.LocalizedProductDescription.<> <>9;
                static /*0x8*/ System.Text.RegularExpressions.MatchEvaluator <>9__11_0;

                static /*0x1413fd0*/ <>c();
                /*0x1414030*/ <>c();
                /*0x1414038*/ string <DecodeNonLatinCharacters>b__11_0(System.Text.RegularExpressions.Match m);
            }
        }

        class ProductCatalogPayout
        {
            /*0x10*/ string t;
            /*0x18*/ string st;
            /*0x20*/ string d;

            /*0x1406944*/ ProductCatalogPayout();

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
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Purchasing.StoreID> storeIDs;
            /*0x20*/ UnityEngine.Purchasing.LocalizedProductDescription defaultDescription;
            /*0x28*/ UnityEngine.Purchasing.Price googlePrice;
            /*0x30*/ System.Collections.Generic.List<UnityEngine.Purchasing.LocalizedProductDescription> descriptions;
            /*0x38*/ UnityEngine.Purchasing.Price udpPrice;
            /*0x40*/ System.Collections.Generic.List<UnityEngine.Purchasing.ProductCatalogPayout> payouts;

            /*0x14067cc*/ ProductCatalogItem();
        }

        class ProductCatalog
        {
            static /*0x0*/ UnityEngine.Purchasing.IProductCatalogImpl instance;
            /*0x10*/ bool enableCodelessAutoInitialization;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Purchasing.ProductCatalogItem> products;

            static /*0x14064cc*/ void Initialize();
            static /*0x1406580*/ void Initialize(UnityEngine.Purchasing.IProductCatalogImpl productCatalogImpl);
            static /*0x14065d0*/ UnityEngine.Purchasing.ProductCatalog Deserialize(string catalogJSON);
            static /*0x140661c*/ UnityEngine.Purchasing.ProductCatalog FromTextAsset(UnityEngine.TextAsset asset);
            static /*0x13f4fc4*/ UnityEngine.Purchasing.ProductCatalog LoadDefaultCatalog();
            /*0x140663c*/ ProductCatalog();
            /*0x14064c4*/ System.Collections.Generic.ICollection<UnityEngine.Purchasing.ProductCatalogItem> get_allProducts();
        }

        interface IProductCatalogImpl
        {
            UnityEngine.Purchasing.ProductCatalog LoadDefaultCatalog();
        }

        class ProductCatalogImpl : UnityEngine.Purchasing.IProductCatalogImpl
        {
            /*0x1406578*/ ProductCatalogImpl();
            /*0x14066bc*/ UnityEngine.Purchasing.ProductCatalog LoadDefaultCatalog();
        }

        class StandardPurchasingModule : UnityEngine.Purchasing.Extension.AbstractPurchasingModule, UnityEngine.Purchasing.IAndroidStoreSelection, UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
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
            /*0x60*/ UnityEngine.Purchasing.FakeStoreUIMode <useFakeStoreUIMode>k__BackingField;
            /*0x64*/ bool <useFakeStoreAlways>k__BackingField;
            /*0x68*/ UnityEngine.Purchasing.WinRTStore windowsStore;

            static /*0x140c254*/ StandardPurchasingModule();
            static /*0x14014fc*/ UnityEngine.Purchasing.StandardPurchasingModule Instance();
            static /*0x140a3b8*/ UnityEngine.Purchasing.StandardPurchasingModule Instance(UnityEngine.Purchasing.AppStore androidStore);
            static /*0x140bf04*/ UnityEngine.Purchasing.GooglePlayConfiguration BuildGooglePlayStoreConfiguration(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback googlePurchaseCallback, UnityEngine.Purchasing.Interfaces.IGoogleProductCallback googleProductCallback);
            /*0x140a2e4*/ StandardPurchasingModule(Uniject.IUtil util, UnityEngine.ILogger logger, UnityEngine.Purchasing.INativeStoreProvider nativeStoreProvider, UnityEngine.RuntimePlatform platform, UnityEngine.Purchasing.AppStore android, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper telemetryDiagnosticsInstanceWrapper, UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper);
            /*0x140a294*/ Uniject.IUtil get_util();
            /*0x140a29c*/ void set_util(Uniject.IUtil value);
            /*0x140a2a4*/ UnityEngine.ILogger get_logger();
            /*0x140a2ac*/ void set_logger(UnityEngine.ILogger value);
            /*0x140a2b4*/ UnityEngine.Purchasing.StandardPurchasingModule.StoreInstance get_storeInstance();
            /*0x140a2bc*/ void set_storeInstance(UnityEngine.Purchasing.StandardPurchasingModule.StoreInstance value);
            /*0x140a2c4*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper get_telemetryMetricsInstanceWrapper();
            /*0x140a2cc*/ void set_telemetryMetricsInstanceWrapper(UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper value);
            /*0x140a2d4*/ UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper get_telemetryDiagnosticsInstanceWrapper();
            /*0x140a2dc*/ void set_telemetryDiagnosticsInstanceWrapper(UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper value);
            /*0x140a394*/ UnityEngine.Purchasing.FakeStoreUIMode get_useFakeStoreUIMode();
            /*0x140a39c*/ void set_useFakeStoreUIMode(UnityEngine.Purchasing.FakeStoreUIMode value);
            /*0x140a3a4*/ bool get_useFakeStoreAlways();
            /*0x140a3ac*/ void set_useFakeStoreAlways(bool value);
            /*0x140a9dc*/ void Configure();
            /*0x140af88*/ UnityEngine.Purchasing.StandardPurchasingModule.StoreInstance InstantiateStore();
            /*0x140b540*/ UnityEngine.Purchasing.Extension.IStore InstantiateAndroid();
            /*0x140b788*/ UnityEngine.Purchasing.Extension.IStore InstantiateGoogleStore();
            /*0x140c0d8*/ void BindGoogleExtension(UnityEngine.Purchasing.GooglePlayStoreExtensions googlePlayStoreExtensions);
            /*0x140c07c*/ void BindGoogleConfiguration(UnityEngine.Purchasing.GooglePlayConfiguration googlePlayConfiguration);
            /*0x140bb58*/ UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService BuildGooglePlayStoreServiceAar(UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback googlePurchaseCallback, UnityEngine.Purchasing.Interfaces.IGoogleProductCallback googleProductCallback);
            /*0x140b460*/ UnityEngine.Purchasing.Extension.IStore InstantiateUDP();
            /*0x140bb28*/ UnityEngine.Purchasing.Extension.IStore InstantiateAndroidHelper(UnityEngine.Purchasing.JSONStore store);
            /*0x140c134*/ UnityEngine.Purchasing.INativeStore GetAndroidNativeStore(UnityEngine.Purchasing.JSONStore store);
            /*0x140b2cc*/ UnityEngine.Purchasing.Extension.IStore InstantiateApple();
            /*0x140b618*/ UnityEngine.Purchasing.Extension.IStore instantiateWindowsStore();
            /*0x140b1fc*/ UnityEngine.Purchasing.Extension.IStore InstantiateFakeStore();

            class StoreInstance
            {
                /*0x10*/ string <storeName>k__BackingField;
                /*0x18*/ UnityEngine.Purchasing.Extension.IStore <instance>k__BackingField;

                /*0x140b294*/ StoreInstance(string name, UnityEngine.Purchasing.Extension.IStore instance);
                /*0x1414f24*/ string get_storeName();
                /*0x1414f2c*/ UnityEngine.Purchasing.Extension.IStore get_instance();
            }

            class MicrosoftConfiguration : UnityEngine.Purchasing.IMicrosoftConfiguration, UnityEngine.Purchasing.Extension.IStoreConfiguration
            {
                /*0x10*/ UnityEngine.Purchasing.StandardPurchasingModule module;

                /*0x140af5c*/ MicrosoftConfiguration(UnityEngine.Purchasing.StandardPurchasingModule module);
            }
        }

        class StoreConfiguration
        {
            /*0x10*/ UnityEngine.Purchasing.AppStore <androidStore>k__BackingField;

            static /*0x140a728*/ UnityEngine.Purchasing.StoreConfiguration Deserialize(string json);
            /*0x140c458*/ StoreConfiguration(UnityEngine.Purchasing.AppStore store);
            /*0x140c448*/ UnityEngine.Purchasing.AppStore get_androidStore();
            /*0x140c450*/ void set_androidStore(UnityEngine.Purchasing.AppStore value);
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

            /*0x13f19a0*/ SubscriptionInfo(UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt r, string intro_json);
            /*0x140c648*/ UnityEngine.Purchasing.Result isExpired();
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
            /*0x1401860*/ ReceiptParserException();
        }

        class InvalidProductTypeException : UnityEngine.Purchasing.ReceiptParserException
        {
            /*0x140185c*/ InvalidProductTypeException();
        }

        class FakeTransactionHistoryExtensions : UnityEngine.Purchasing.ITransactionHistoryExtensions, UnityEngine.Purchasing.IStoreExtension
        {
            /*0x13f56a4*/ FakeTransactionHistoryExtensions();
        }

        interface ITransactionHistoryExtensions : UnityEngine.Purchasing.IStoreExtension
        {
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

            /*0x13f3ba0*/ ExponentialRetryPolicy(int baseRetryDelay, int maxRetryDelay, int exponentialFactor);
            /*0x13f3be0*/ void Invoke(System.Action<System.Action> actionToTry, System.Action onRetryAction);
            /*0x13f3cd0*/ int AdjustDelay(int delay);

            class <>c__DisplayClass4_0
            {
                /*0x10*/ System.Action onRetryAction;
                /*0x18*/ int currentRetryDelay;
                /*0x20*/ UnityEngine.Purchasing.ExponentialRetryPolicy <>4__this;
                /*0x28*/ System.Action<System.Action> actionToTry;

                /*0x13f3cc8*/ <>c__DisplayClass4_0();
                /*0x141192c*/ void <Invoke>g__Retry|0();
                /*0x14119f0*/ System.Threading.Tasks.Task <Invoke>g__WaitAndRetry|1();

                struct <<Invoke>g__Retry|0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                    /*0x38*/ UnityEngine.Purchasing.ExponentialRetryPolicy.<> <>4__this;
                    /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                    /*0xb41ca0*/ void MoveNext();
                    /*0xb41ca8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <<Invoke>g__WaitAndRetry|1>d : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ UnityEngine.Purchasing.ExponentialRetryPolicy.<> <>4__this;
                    /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                    /*0xb41cb4*/ void MoveNext();
                    /*0xb41cbc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }
        }

        class ProductDefinitionExtensions
        {
            static /*0x13f3f48*/ System.Collections.Generic.List<UnityEngine.Purchasing.ProductDefinition> DecodeJSON(System.Collections.Generic.List<object> productsList, string storeName);
        }

        class FakeMicrosoftExtensions : UnityEngine.Purchasing.IMicrosoftExtensions, UnityEngine.Purchasing.IStoreExtension
        {
            /*0x13f3d70*/ FakeMicrosoftExtensions();
        }

        interface IMicrosoftConfiguration : UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
        }

        interface IMicrosoftExtensions : UnityEngine.Purchasing.IStoreExtension
        {
        }

        class WinRTStore : UnityEngine.Purchasing.Extension.AbstractStore, UnityEngine.Purchasing.Default.IWindowsIAPCallback, UnityEngine.Purchasing.IMicrosoftExtensions, UnityEngine.Purchasing.IStoreExtension
        {
            /*0x10*/ UnityEngine.Purchasing.Default.IWindowsIAP win8;
            /*0x18*/ UnityEngine.Purchasing.Extension.IStoreCallback callback;
            /*0x20*/ Uniject.IUtil util;
            /*0x28*/ UnityEngine.ILogger logger;
            /*0x30*/ bool m_CanReceivePurchases;

            /*0x140c210*/ WinRTStore(UnityEngine.Purchasing.Default.IWindowsIAP win8, Uniject.IUtil util, UnityEngine.ILogger logger);
            /*0x1411050*/ void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback biller);
            /*0x1411058*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> productDefs);
            /*0x1411430*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId);
            /*0x1411304*/ void init(int delay);
            /*0x14114f0*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);
            /*0x14115b8*/ void restoreTransactions(bool pausing);

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.WinRTStore.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.Purchasing.ProductDefinition, bool> <>9__8_0;
                static /*0x10*/ System.Func<UnityEngine.Purchasing.ProductDefinition, UnityEngine.Purchasing.Default.WinProductDescription> <>9__8_1;

                static /*0x2b088f4*/ <>c();
                /*0x2b08954*/ <>c();
                /*0x2b0895c*/ bool <RetrieveProducts>b__8_0(UnityEngine.Purchasing.ProductDefinition def);
                /*0x2b0897c*/ UnityEngine.Purchasing.Default.WinProductDescription <RetrieveProducts>b__8_1(UnityEngine.Purchasing.ProductDefinition def);
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

                static /*0x1410e20*/ UnityUtil();
                static T FindInstanceOfType<T>();
                static T LoadResourceInstanceOfType<T>();
                static /*0x14107f8*/ bool PcPlatform();
                /*0x1410da8*/ UnityUtil();
                T[] GetAnyComponentsOfType<T>();
                /*0x1410304*/ System.DateTime get_currentTime();
                /*0x1410360*/ string get_persistentDataPath();
                /*0x1410368*/ string get_deviceUniqueIdentifier();
                /*0x1410370*/ string get_unityVersion();
                /*0x1410378*/ string get_cloudProjectId();
                /*0x1410380*/ string get_userId();
                /*0x14103e8*/ string get_gameVersion();
                /*0x14103f0*/ ulong get_sessionId();
                /*0x1410458*/ UnityEngine.RuntimePlatform get_platform();
                /*0x1410460*/ bool get_isEditor();
                /*0x1410468*/ string get_deviceModel();
                /*0x1410470*/ string get_deviceName();
                /*0x1410478*/ UnityEngine.DeviceType get_deviceType();
                /*0x1410480*/ string get_operatingSystem();
                /*0x1410488*/ int get_screenWidth();
                /*0x1410490*/ int get_screenHeight();
                /*0x1410498*/ float get_screenDpi();
                /*0x14104a0*/ string get_screenOrientation();
                /*0x141052c*/ object Uniject.IUtil.InitiateCoroutine(System.Collections.IEnumerator start);
                /*0x1410534*/ void Uniject.IUtil.InitiateCoroutine(System.Collections.IEnumerator start, int delay);
                /*0x14105b8*/ void RunOnMainThread(System.Action runnable);
                /*0x1410720*/ object GetWaitForSeconds(int seconds);
                /*0x1410780*/ void Start();
                /*0x1410538*/ System.Collections.IEnumerator DelayedCoroutine(System.Collections.IEnumerator coroutine, int delay);
                /*0x141088c*/ void Update();
                /*0x1410b58*/ void AddPauseListener(System.Action<bool> runnable);
                /*0x1410bbc*/ void OnApplicationPause(bool paused);
                /*0x1410cfc*/ bool IsClassOrSubclass(System.Type potentialBase, System.Type potentialDescendant);

                class <DelayedCoroutine>d__48 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ int delay;
                    /*0x28*/ UnityEngine.Purchasing.Extension.UnityUtil <>4__this;
                    /*0x30*/ System.Collections.IEnumerator coroutine;

                    /*0x2b087c0*/ <DelayedCoroutine>d__48(int <>1__state);
                    /*0x2b087ec*/ void System.IDisposable.Dispose();
                    /*0x2b087f0*/ bool MoveNext();
                    /*0x2b088a4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x2b088ac*/ void System.Collections.IEnumerator.Reset();
                    /*0x2b088ec*/ object System.Collections.IEnumerator.get_Current();
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

                static /*0x14011cc*/ void Register();
                static /*0x1401558*/ void InitializeTelemetryComponents(UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper metricsInstanceWrapper, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper diagnosticsInstanceWrapper);
                /*0x14012dc*/ IapCoreInitializeCallback();
                /*0x14012e4*/ System.Threading.Tasks.Task Initialize(Unity.Services.Core.Internal.CoreRegistry registry);

                class <>c__DisplayClass2_0
                {
                    /*0x10*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper metricsInstanceWrapper;
                    /*0x18*/ UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper diagnosticsInstanceWrapper;

                    /*0x14014f4*/ <>c__DisplayClass2_0();
                    /*0x1413fc4*/ void <Initialize>b__0();
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
                UnityEngine.Purchasing.GoogleBillingConnectionState GetConnectionState();
                void QueryPurchasesAsync(string skuType, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper>> onQueryPurchasesResponse);
                void QuerySkuDetailsAsync(System.Collections.Generic.List<string> skus, string type, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onSkuDetailsResponseAction);
                UnityEngine.AndroidJavaObject LaunchBillingFlow(UnityEngine.AndroidJavaObject sku, string oldPurchaseToken, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> prorationMode);
                void ConsumeAsync(string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onConsume);
                void AcknowledgePurchase(string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onAcknowledge);
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
                void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished);
                void FetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed);
                void ResumeConnection();
            }

            interface IGoogleProductCallback
            {
                void SetStoreConfiguration(UnityEngine.Purchasing.IGooglePlayConfigurationInternal configuration);
                void NotifyQueryProductDetailsFailed(int retryCount);
            }

            interface IGooglePurchase
            {
                int get_purchaseState();
                System.Collections.Generic.List<string> get_skus();
                string get_receipt();
                string get_purchaseToken();
                string get_sku();
                bool IsAcknowledged();
                bool IsPurchased();
            }

            interface IGooglePurchaseBuilder
            {
                System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> BuildPurchases(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper> purchases);
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

                /*0x13f054c*/ AndroidJavaObjectWrapper(UnityEngine.AndroidJavaObject obj);
                /*0x13f0578*/ System.IDisposable get_androidJavaObject();
                ReturnType Call<ReturnType>(string methodName, object[] args);
            }

            class GooglePurchaseBuilder : UnityEngine.Purchasing.Interfaces.IGooglePurchaseBuilder
            {
                /*0x10*/ UnityEngine.Purchasing.IGoogleCachedQuerySkuDetailsService m_CachedQuerySkuDetailsService;
                /*0x18*/ UnityEngine.ILogger m_Logger;

                static /*0x13fdc10*/ System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper> TryFindAllSkuDetails(System.Collections.Generic.IEnumerable<string> skus, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper> skuDetails);
                /*0x13fd6cc*/ GooglePurchaseBuilder(UnityEngine.Purchasing.IGoogleCachedQuerySkuDetailsService cachedQuerySkuDetailsService, UnityEngine.ILogger logger);
                /*0x13fd704*/ System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> BuildPurchases(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper> purchases);
                /*0x13fd834*/ void LogWarningForException(System.Exception exception);
                /*0x13fd878*/ UnityEngine.Purchasing.Interfaces.IGooglePurchase BuildPurchase(UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper purchase);

                class <>c__DisplayClass6_0
                {
                    /*0x10*/ System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper> skuDetails;

                    /*0x13fdcf8*/ <>c__DisplayClass6_0();
                    /*0x14133cc*/ UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper <TryFindAllSkuDetails>b__0(string sku);
                }

                class <>c__DisplayClass6_1
                {
                    /*0x10*/ string sku;

                    /*0x14134b8*/ <>c__DisplayClass6_1();
                    /*0x14134c0*/ bool <TryFindAllSkuDetails>b__1(UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper skuDetail);
                }
            }

            class GoogleReceiptEncoder
            {
                static /*0x13fd378*/ string EncodeReceipt(string purchaseOriginalJson, string purchaseSignature, System.Collections.Generic.List<string> skuDetailsJson);
            }

            class SkuDetailsConverter : UnityEngine.Purchasing.Interfaces.ISkuDetailsConverter
            {
                static /*0x14089d4*/ UnityEngine.Purchasing.Extension.ProductDescription ToProductDescription(UnityEngine.AndroidJavaObject skusDetails);
                static /*0x14089e8*/ UnityEngine.Purchasing.Extension.ProductDescription BuildProductDescription(UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper skuDetails);
                /*0x1409a40*/ SkuDetailsConverter();
                /*0x1408910*/ System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> ConvertOnQuerySkuDetailsResponse(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> skus);
            }
        }

        namespace Models
        {
            class AndroidJavaObjectExtensions
            {
                static System.Collections.Generic.IEnumerable<T> Enumerate<T>(UnityEngine.AndroidJavaObject androidJavaList);
                static /*0x13f0384*/ System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper> EnumerateAndWrap(UnityEngine.AndroidJavaObject androidJavaList);
                static /*0x13f03d4*/ System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper> Wrap(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> androidJavaList);
                static /*0x13f04ec*/ UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper Wrap(UnityEngine.AndroidJavaObject androidJavaObject);

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

                    static /*0x1411694*/ <>c();
                    /*0x14116f4*/ <>c();
                    /*0x14116fc*/ UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper <Wrap>b__2_0(UnityEngine.AndroidJavaObject javaObject);
                }
            }

            interface IGoogleBillingResult
            {
                UnityEngine.Purchasing.Models.GoogleBillingResponseCode get_responseCode();
                string get_debugMessage();
            }

            class GoogleBillingClient : UnityEngine.Purchasing.Interfaces.IGoogleBillingClient
            {
                /*0x10*/ UnityEngine.AndroidJavaObject m_BillingClient;
                /*0x18*/ string m_ObfuscatedAccountId;
                /*0x20*/ string m_ObfuscatedProfileId;
                /*0x28*/ Uniject.IUtil m_Util;

                static /*0x13f57d4*/ UnityEngine.AndroidJavaClass GetSkuDetailsParamClass();
                static /*0x13f5844*/ UnityEngine.AndroidJavaClass GetBillingFlowParamClass();
                static /*0x13f58b4*/ UnityEngine.AndroidJavaClass GetSubscriptionUpdateParamClass();
                static /*0x13f5924*/ UnityEngine.AndroidJavaClass GetConsumeParamsClass();
                static /*0x13f5994*/ UnityEngine.AndroidJavaClass GetAcknowledgePurchaseParamsClass();
                static /*0x13f5a04*/ UnityEngine.AndroidJavaClass GetBillingClientClass();
                static /*0x13f6c78*/ UnityEngine.AndroidJavaObject BuildSubscriptionUpdateParams(string oldPurchaseToken, UnityEngine.Purchasing.GooglePlayProrationMode prorationMode);
                /*0x13f5a74*/ GoogleBillingClient(UnityEngine.Purchasing.Interfaces.IGooglePurchaseUpdatedListener googlePurchaseUpdatedListener, Uniject.IUtil util);
                /*0x13f5de8*/ void StartConnection(UnityEngine.Purchasing.Interfaces.IBillingClientStateListener billingClientStateListener);
                /*0x13f5eb8*/ UnityEngine.Purchasing.GoogleBillingConnectionState GetConnectionState();
                /*0x13f5fc8*/ void QueryPurchasesAsync(string skuType, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper>> onQueryPurchasesResponse);
                /*0x13f617c*/ void QuerySkuDetailsAsync(System.Collections.Generic.List<string> skus, string type, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onSkuDetailsResponseAction);
                /*0x13f65e8*/ UnityEngine.AndroidJavaObject LaunchBillingFlow(UnityEngine.AndroidJavaObject sku, string oldPurchaseToken, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> prorationMode);
                /*0x13f672c*/ UnityEngine.AndroidJavaObject MakeBillingFlowParams(UnityEngine.AndroidJavaObject sku, string oldPurchaseToken, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> prorationMode);
                /*0x13f6b80*/ UnityEngine.AndroidJavaObject SetObfuscatedProfileIdIfNeeded(UnityEngine.AndroidJavaObject billingFlowParams);
                /*0x13f6a88*/ UnityEngine.AndroidJavaObject SetObfuscatedAccountIdIfNeeded(UnityEngine.AndroidJavaObject billingFlowParams);
                /*0x13f6f94*/ void ConsumeAsync(string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onConsume);
                /*0x13f736c*/ void AcknowledgePurchase(string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onAcknowledge);
            }

            class GoogleBillingResult : UnityEngine.Purchasing.Models.IGoogleBillingResult
            {
                /*0x10*/ UnityEngine.Purchasing.Models.GoogleBillingResponseCode <responseCode>k__BackingField;
                /*0x18*/ string <debugMessage>k__BackingField;

                /*0x13f398c*/ GoogleBillingResult(UnityEngine.AndroidJavaObject billingResult);
                /*0x13f76b4*/ UnityEngine.Purchasing.Models.GoogleBillingResponseCode get_responseCode();
                /*0x13f76bc*/ string get_debugMessage();
            }

            class GoogleBillingStrings
            {
                static /*0x13f76c4*/ string getWarningMessageMoreThanOneSkuFound(string sku);
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

                /*0x13fcac0*/ GooglePurchase(UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper purchase, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper> skuDetails);
                /*0x13fca3c*/ UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper get_javaPurchase();
                /*0x13fca44*/ int get_purchaseState();
                /*0x13fca4c*/ System.Collections.Generic.List<string> get_skus();
                /*0x13fca54*/ string get_receipt();
                /*0x13fca5c*/ string get_signature();
                /*0x13fca64*/ string get_originalJson();
                /*0x13fca6c*/ string get_purchaseToken();
                /*0x13fca74*/ string get_sku();
                /*0x13fd498*/ bool IsAcknowledged();
                /*0x13fd62c*/ bool IsPurchased();

                class <>c
                {
                    static /*0x0*/ UnityEngine.Purchasing.Models.GooglePurchase.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper, string> <>9__26_0;

                    static /*0x14131e4*/ <>c();
                    /*0x1413244*/ <>c();
                    /*0x141324c*/ string <.ctor>b__26_0(UnityEngine.Purchasing.Utils.IAndroidJavaObjectWrapper skuDetail);
                }
            }

            class GooglePurchaseStateEnum
            {
                static /*0x13fe850*/ UnityEngine.AndroidJavaObject GetPurchaseStateJavaObject();
                static /*0x13fd664*/ int Purchased();
                static /*0x13fe8c0*/ int Pending();
            }

            class GooglePurchaseStateEnumProvider : UnityEngine.Purchasing.Interfaces.IGooglePurchaseStateEnumProvider
            {
                /*0x13fe930*/ GooglePurchaseStateEnumProvider();
                /*0x13fe928*/ int Purchased();
                /*0x13fe92c*/ int Pending();
            }

            enum GoogleRetrieveProductsFailureReason
            {
                BillingServiceDisconnected = 0,
                BillingServiceUnavailable = 1,
            }

            class GoogleSkuTypeEnum
            {
                static /*0x1401144*/ string InApp();
                static /*0x1401188*/ string Sub();
            }

            class ProductDescriptionQuery
            {
                /*0x10*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;
                /*0x18*/ System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>> onProductsReceived;
                /*0x20*/ System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason> onRetrieveProductsFailed;

                /*0x13fc404*/ ProductDescriptionQuery(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason> onRetrieveProductsFailed);
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
    static /*0x13f02d8*/ uint ComputeStringHash(string s);
}
