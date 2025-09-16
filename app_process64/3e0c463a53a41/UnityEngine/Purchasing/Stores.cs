class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x7f27edc*/ EmbeddedAttribute();
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

                /*0x7f27ee4*/ NullableAttribute(byte );
                /*0x7f27f6c*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x7f27f9c*/ NullableContextAttribute(byte );
            }
        }
    }
}

namespace Stores
{
    namespace Util
    {
        class JsonProductDescriptionsDeserializer
        {
            /*0x7f2874c*/ JsonProductDescriptionsDeserializer();
            /*0x7f27fc4*/ System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> DeserializeProductDescriptions(string json);
            /*0x7f284d8*/ UnityEngine.Purchasing.ProductMetadata DeserializeMetadata(System.Collections.Generic.Dictionary<string, object> data);
        }
    }
}

namespace UnityEngine
{
    namespace Purchasing
    {
        class AmazonAppStoreStoreExtensions : UnityEngine.Purchasing.IAmazonExtensions, UnityEngine.Purchasing.IStoreExtension, UnityEngine.Purchasing.IAmazonConfiguration, UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
            /*0x10*/ UnityEngine.AndroidJavaObject android;

            /*0x7f28754*/ AmazonAppStoreStoreExtensions(UnityEngine.AndroidJavaObject a);
        }

        class FakeAmazonExtensions : UnityEngine.Purchasing.IAmazonExtensions, UnityEngine.Purchasing.IStoreExtension, UnityEngine.Purchasing.IAmazonConfiguration, UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
            /*0x7f28784*/ FakeAmazonExtensions();
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

            /*0x7f2878c*/ AndroidJavaStore(UnityEngine.AndroidJavaObject store);
            /*0x7f287bc*/ void RetrieveProducts(string json);
            /*0x7f2888c*/ void Purchase(string productJSON, string developerPayload);
            /*0x7f28994*/ void FinishTransaction(string productJSON, string transactionID);
        }

        class ListExtension
        {
            static /*0x382eaf0*/ UnityEngine.AndroidJavaObject ToJava<T>(System.Collections.Generic.List<T> values);
            static /*0x382eaf0*/ UnityEngine.AndroidJavaObject ToJavaArray<T>(System.Collections.Generic.List<T> values);
        }

        class UnityActivity
        {
            static /*0x0*/ UnityEngine.AndroidJavaClass s_UnityPlayerClass;

            static /*0x7f28a9c*/ UnityEngine.AndroidJavaClass GetUnityPlayerClass();
            static /*0x7f28b50*/ UnityEngine.AndroidJavaObject GetCurrentActivity();
        }

        class GoogleCachedQueryProductDetailsService : UnityEngine.Purchasing.IGoogleCachedQueryProductDetailsService
        {
            /*0x10*/ System.Collections.Generic.Dictionary<string, UnityEngine.AndroidJavaObject> m_CachedQueriedProductDetails;

            /*0x7f29450*/ GoogleCachedQueryProductDetailsService();
            /*0x7f28bac*/ void Finalize();
            /*0x7f28d84*/ System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedProducts();
            /*0x7f28dd4*/ UnityEngine.AndroidJavaObject GetCachedQueriedProductDetails(string productId);
            /*0x7f28e2c*/ System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedProductDetails(System.Collections.Generic.IEnumerable<string> productIds);
            /*0x7f28ed0*/ System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedProductDetails(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x7f29004*/ bool Contains(string productId);
            /*0x7f2905c*/ bool Contains(UnityEngine.Purchasing.ProductDefinition products);
            /*0x7f29074*/ void AddCachedQueriedProductDetails(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> queriedProducts);

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.GoogleCachedQueryProductDetailsService.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.Purchasing.ProductDefinition, string> <>9__5_0;

                static /*0x7f294d8*/ <>c();
                /*0x7f29540*/ <>c();
                /*0x7f29548*/ string <GetCachedQueriedProductDetails>b__5_0(UnityEngine.Purchasing.ProductDefinition product);
            }
        }

        class GoogleFinishTransactionService : UnityEngine.Purchasing.Interfaces.IGoogleFinishTransactionService
        {
            /*0x10*/ UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient;
            /*0x18*/ UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService m_GoogleQueryPurchasesService;

            /*0x7f29560*/ GoogleFinishTransactionService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService googleQueryPurchasesService);
            /*0x7f295a4*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished);
            /*0x7f296ac*/ System.Threading.Tasks.Task<UnityEngine.Purchasing.Interfaces.IGooglePurchase> FindPurchase(string purchaseToken);
            /*0x7f297c4*/ void FinishTransactionForPurchase(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, UnityEngine.Purchasing.ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished);

            class <>c__DisplayClass4_0
            {
                /*0x10*/ string purchaseToken;

                /*0x7f29a54*/ <>c__DisplayClass4_0();
                /*0x7f29a5c*/ bool <FindPurchase>b__0(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase);
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished;
                /*0x18*/ UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase;

                /*0x7f29a4c*/ <>c__DisplayClass5_0();
                /*0x7f29b0c*/ void <FinishTransactionForPurchase>b__0(UnityEngine.Purchasing.Models.IGoogleBillingResult result);
                /*0x7f29b34*/ void <FinishTransactionForPurchase>b__1(UnityEngine.Purchasing.Models.IGoogleBillingResult result);
            }

            struct <FindPurchase>d__4 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<UnityEngine.Purchasing.Interfaces.IGooglePurchase> <>t__builder;
                /*0x30*/ string purchaseToken;
                /*0x38*/ UnityEngine.Purchasing.GoogleFinishTransactionService <>4__this;
                /*0x40*/ UnityEngine.Purchasing.GoogleFinishTransactionService.<> <>8__1;
                /*0x48*/ System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>u__1;

                /*0x7f29b5c*/ void MoveNext();
                /*0x7f29f38*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <FinishTransaction>d__3 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                /*0x38*/ UnityEngine.Purchasing.GoogleFinishTransactionService <>4__this;
                /*0x40*/ string purchaseToken;
                /*0x48*/ UnityEngine.Purchasing.ProductDefinition product;
                /*0x50*/ System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished;
                /*0x58*/ System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Purchasing.Interfaces.IGooglePurchase> <>u__1;

                /*0x7f29fb4*/ void MoveNext();
                /*0x7f2a2ac*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class GoogleLastKnownProductService : UnityEngine.Purchasing.Interfaces.IGoogleLastKnownProductService
        {
            /*0x10*/ string <LastKnownOldProductId>k__BackingField;
            /*0x18*/ string <LastKnownProductId>k__BackingField;
            /*0x20*/ System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> <LastKnownProrationMode>k__BackingField;

            /*0x7f2a2e8*/ GoogleLastKnownProductService();
            /*0x7f2a2b8*/ string get_LastKnownOldProductId();
            /*0x7f2a2c0*/ void set_LastKnownOldProductId(string value);
            /*0x7f2a2c8*/ string get_LastKnownProductId();
            /*0x7f2a2d0*/ void set_LastKnownProductId(string value);
            /*0x7f2a2d8*/ System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> get_LastKnownProrationMode();
            /*0x7f2a2e0*/ void set_LastKnownProrationMode(System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> value);
        }

        class GooglePlayStoreService : UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService
        {
            /*0x10*/ int m_CurrentConnectionAttempts;
            /*0x14*/ int m_MaxConnectionAttempts;
            /*0x18*/ UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient;
            /*0x20*/ UnityEngine.Purchasing.Interfaces.IBillingClientStateListener m_BillingClientStateListener;
            /*0x28*/ UnityEngine.Purchasing.Interfaces.IQueryProductDetailsService m_QueryProductDetailsService;
            /*0x30*/ System.Collections.Concurrent.ConcurrentQueue<UnityEngine.Purchasing.Models.ProductDescriptionQuery> m_ProductsToQuery;
            /*0x38*/ System.Collections.Concurrent.ConcurrentQueue<System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>>> m_OnPurchaseSucceededQueue;
            /*0x40*/ UnityEngine.Purchasing.Interfaces.IGooglePurchaseService m_GooglePurchaseService;
            /*0x48*/ UnityEngine.Purchasing.Interfaces.IGoogleFinishTransactionService m_GoogleFinishTransactionService;
            /*0x50*/ UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService m_GoogleQueryPurchasesService;
            /*0x58*/ UnityEngine.Purchasing.Interfaces.IGoogleLastKnownProductService m_GoogleLastKnownProductService;
            /*0x60*/ UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics;
            /*0x68*/ UnityEngine.ILogger m_Logger;
            /*0x70*/ UnityEngine.Purchasing.Stores.Util.IRetryPolicy m_RetryPolicy;
            /*0x78*/ Uniject.IUtil m_Util;

            /*0x7f2a358*/ GooglePlayStoreService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, UnityEngine.Purchasing.Interfaces.IQueryProductDetailsService queryProductDetailsService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseService purchaseService, UnityEngine.Purchasing.Interfaces.IGoogleFinishTransactionService finishTransactionService, UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService queryPurchasesService, UnityEngine.Purchasing.Interfaces.IBillingClientStateListener billingClientStateListener, UnityEngine.Purchasing.Interfaces.IGoogleLastKnownProductService lastKnownProductService, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics, UnityEngine.ILogger logger, UnityEngine.Purchasing.Stores.Util.IRetryPolicy retryPolicy, Uniject.IUtil util);
            /*0x7f2a538*/ void InitConnectionWithGooglePlay();
            /*0x7f2a6e4*/ void StartConnection();
            /*0x7f2a798*/ void ResumeConnection();
            /*0x7f2a854*/ void AttemptReconnection();
            /*0x7f2a958*/ bool AreConnectionAttemptsExhausted();
            /*0x7f2a968*/ void RetryConnection(System.Action ActionToRetry);
            /*0x7f2aab4*/ void RetryConnectionAttempt(System.Action ActionToRetry);
            /*0x7f2ab94*/ void OnConnected();
            /*0x7f2abc4*/ void DequeueQueryProducts(UnityEngine.Purchasing.Models.GoogleBillingResponseCode googleBillingResponseCode);
            /*0x7f2b130*/ void DequeueFetchPurchases();
            /*0x7f2b308*/ void OnDisconnected(UnityEngine.Purchasing.Models.GoogleBillingResponseCode googleBillingResponseCode);
            /*0x7f2b328*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason, UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed);
            /*0x7f2b488*/ void HandleRetrieveProductsNotConnected(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason, UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed);
            /*0x7f2b5d8*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product);
            /*0x7f2b5f0*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode);
            /*0x7f2b828*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished);
            /*0x7f2b238*/ void FetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed);
            /*0x7f2b8e8*/ System.Threading.Tasks.Task TryFetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed);
            /*0x7f2b9e4*/ UnityEngine.Purchasing.Interfaces.IGooglePurchase GetPurchase(string purchaseToken, string skuType);
            /*0x7f2baa0*/ void <AttemptReconnection>b__19_0(System.Action retryAction);

            class <>c__DisplayClass21_0
            {
                /*0x10*/ UnityEngine.Purchasing.GooglePlayStoreService <>4__this;
                /*0x18*/ System.Action ActionToRetry;

                /*0x7f2aaac*/ <>c__DisplayClass21_0();
                /*0x7f2baa4*/ void <RetryConnection>b__0();
            }

            struct <FetchPurchases>d__33 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                /*0x38*/ UnityEngine.Purchasing.GooglePlayStoreService <>4__this;
                /*0x40*/ System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed;
                /*0x48*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                /*0x7f2bac4*/ void MoveNext();
                /*0x7f2bd80*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <TryFetchPurchases>d__34 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed;
                /*0x38*/ UnityEngine.Purchasing.GooglePlayStoreService <>4__this;
                /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>u__1;

                /*0x7f2bd8c*/ void MoveNext();
                /*0x7f2c140*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class GooglePurchaseService : UnityEngine.Purchasing.Interfaces.IGooglePurchaseService
        {
            /*0x10*/ UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient;
            /*0x18*/ UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback m_GooglePurchaseCallback;
            /*0x20*/ UnityEngine.Purchasing.Interfaces.IQueryProductDetailsService m_QueryProductDetailsService;

            static /*0x7f2c894*/ void VerifyAndWarnIfMoreThanOneSku(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> skus);
            /*0x7f2c1a8*/ GooglePurchaseService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback googlePurchaseCallback, UnityEngine.Purchasing.Interfaces.IQueryProductDetailsService queryProductDetailsService);
            /*0x7f2c208*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode);
            /*0x7f2c388*/ void OnQueryProductDetailsResponse(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> productDetailsList, UnityEngine.Purchasing.ProductDefinition productToBuy, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode);
            /*0x7f2c43c*/ bool ValidateQueryProductDetailsResponseParams(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> skus, UnityEngine.Purchasing.ProductDefinition productToBuy, UnityEngine.Purchasing.Product oldProduct);
            /*0x7f2c5b4*/ bool ValidateSkus(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> skus);
            /*0x7f2c60c*/ void PurchaseFailedSkuNotFound(UnityEngine.Purchasing.ProductDefinition productToBuy);
            /*0x7f2c708*/ bool ValidateOldProduct(UnityEngine.Purchasing.Product oldProduct);
            /*0x7f2c760*/ void PurchaseFailedInvalidOldProduct(UnityEngine.Purchasing.ProductDefinition productToBuy, UnityEngine.Purchasing.Product oldProduct);
            /*0x7f2c49c*/ void LaunchGoogleBillingFlow(UnityEngine.AndroidJavaObject productToPurchase, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode);
            /*0x7f2c9f0*/ void HandleBillingFlowResult(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, UnityEngine.AndroidJavaObject sku);

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.Purchasing.GooglePurchaseService <>4__this;
                /*0x18*/ UnityEngine.Purchasing.ProductDefinition product;
                /*0x20*/ UnityEngine.Purchasing.Product oldProduct;
                /*0x28*/ System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode;

                /*0x7f2c380*/ <>c__DisplayClass4_0();
                /*0x7f2cc68*/ void <Purchase>b__0(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> productDetailsList, UnityEngine.Purchasing.Models.IGoogleBillingResult _);
            }
        }

        class GoogleQueryPurchasesService : UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService
        {
            /*0x10*/ UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient;
            /*0x18*/ UnityEngine.Purchasing.Interfaces.IGooglePurchaseBuilder m_PurchaseBuilder;

            static /*0x7f2d16c*/ bool IsResultOk(UnityEngine.Purchasing.Models.IGoogleBillingResult result);
            /*0x7f2cc8c*/ GoogleQueryPurchasesService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, UnityEngine.Purchasing.Interfaces.IGooglePurchaseBuilder purchaseBuilder);
            /*0x7f2ccd0*/ System.Threading.Tasks.Task<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> QueryPurchases();
            /*0x7f2cdcc*/ System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> QueryPurchasesWithSkuType(string skuType);
            /*0x7f2cf80*/ UnityEngine.Purchasing.Interfaces.IGooglePurchase GetPurchaseByToken(string purchaseToken, string skuType);

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.GoogleQueryPurchasesService.<> <>9;
                static /*0x8*/ System.Func<System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>9__3_0;

                static /*0x7f2d214*/ <>c();
                /*0x7f2d27c*/ <>c();
                /*0x7f2d284*/ System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> <QueryPurchases>b__3_0(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> result);
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.Purchasing.GoogleQueryPurchasesService <>4__this;
                /*0x18*/ System.Threading.Tasks.TaskCompletionSource<System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> taskCompletion;

                /*0x7f2cf78*/ <>c__DisplayClass4_0();
                /*0x7f2d28c*/ void <QueryPurchasesWithSkuType>b__0(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> purchases);
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ string purchaseToken;
                /*0x18*/ UnityEngine.Purchasing.GoogleQueryPurchasesService <>4__this;
                /*0x20*/ System.Threading.Tasks.TaskCompletionSource<UnityEngine.Purchasing.Interfaces.IGooglePurchase> taskCompletion;
                /*0x28*/ System.Func<UnityEngine.AndroidJavaObject, bool> <>9__1;

                /*0x7f2d164*/ <>c__DisplayClass5_0();
                /*0x7f2d3e4*/ void <GetPurchaseByToken>b__0(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> purchases);
                /*0x7f2d574*/ bool <GetPurchaseByToken>b__1(UnityEngine.AndroidJavaObject purchase);
            }

            struct <QueryPurchases>d__3 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>t__builder;
                /*0x30*/ UnityEngine.Purchasing.GoogleQueryPurchasesService <>4__this;
                /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>[]> <>u__1;

                /*0x7f2d668*/ void MoveNext();
                /*0x7f2dae4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        interface IGoogleCachedQueryProductDetailsService
        {
            /*0x380b9e8*/ System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedProducts();
            /*0x380bb68*/ System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedProductDetails(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x380b2f0*/ bool Contains(UnityEngine.Purchasing.ProductDefinition products);
            /*0x380d83c*/ void AddCachedQueriedProductDetails(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> queriedProducts);
        }

        class BillingClientStateListener : UnityEngine.AndroidJavaProxy, UnityEngine.Purchasing.Interfaces.IBillingClientStateListener
        {
            static string k_AndroidBillingClientStateListenerClassName = "com.android.billingclient.api.BillingClientStateListener";
            /*0x20*/ System.Action m_OnConnected;
            /*0x28*/ System.Action<UnityEngine.Purchasing.Models.GoogleBillingResponseCode> m_Disconnect;

            /*0x7f2db60*/ BillingClientStateListener();
            /*0x7f2dbd0*/ void RegisterOnConnected(System.Action onConnected);
            /*0x7f2dbd8*/ void RegisterOnDisconnected(System.Action<UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onDisconnected);
            /*0x7f2dbe0*/ void onBillingSetupFinished(UnityEngine.AndroidJavaObject billingResult);
            /*0x7f2dd58*/ void onBillingServiceDisconnected();
        }

        class GoogleAcknowledgePurchaseListener : UnityEngine.AndroidJavaProxy
        {
            static string k_AndroidAcknowledgePurchaseResponseListenerClassName = "com.android.billingclient.api.AcknowledgePurchaseResponseListener";
            /*0x20*/ System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> m_OnAcknowledgePurchaseResponse;

            /*0x7f2dd80*/ GoogleAcknowledgePurchaseListener(System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onAcknowledgePurchaseResponseAction);
            /*0x7f2de0c*/ void onAcknowledgePurchaseResponse(UnityEngine.AndroidJavaObject billingResult);
        }

        class GoogleConsumeResponseListener : UnityEngine.AndroidJavaProxy
        {
            static string k_AndroidConsumeResponseListenerClassName = "com.android.billingclient.api.ConsumeResponseListener";
            /*0x20*/ System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> m_OnConsumeResponse;

            /*0x7f2de9c*/ GoogleConsumeResponseListener(System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onConsumeResponseAction);
            /*0x7f2df28*/ void onConsumeResponse(UnityEngine.AndroidJavaObject billingResult, string purchaseToken);
        }

        class GooglePurchasesResponseListener : UnityEngine.AndroidJavaProxy
        {
            static string k_AndroidPurchasesResponseListenerClassName = "com.android.billingclient.api.PurchasesResponseListener";
            /*0x20*/ System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> m_OnQueryPurchasesResponse;

            /*0x7f2dfb8*/ GooglePurchasesResponseListener(System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> onQueryPurchasesResponse);
            /*0x7f2e044*/ void onQueryPurchasesResponse(UnityEngine.AndroidJavaObject billingResult, UnityEngine.AndroidJavaObject purchases);
        }

        class GooglePurchaseUpdatedListener : UnityEngine.AndroidJavaProxy, UnityEngine.Purchasing.Interfaces.IGooglePurchaseUpdatedListener
        {
            static string k_AndroidPurchaseListenerClassName = "com.android.billingclient.api.PurchasesUpdatedListener";
            /*0x20*/ UnityEngine.Purchasing.Interfaces.IGoogleLastKnownProductService m_LastKnownProductService;
            /*0x28*/ UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback m_GooglePurchaseCallback;
            /*0x30*/ UnityEngine.Purchasing.Interfaces.IGooglePurchaseBuilder m_PurchaseBuilder;
            /*0x38*/ UnityEngine.Purchasing.IGoogleCachedQueryProductDetailsService m_GoogleCachedQueryProductDetailsService;
            /*0x40*/ UnityEngine.Purchasing.Interfaces.IGooglePurchaseStateEnumProvider m_GooglePurchaseStateEnumProvider;
            /*0x48*/ UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService m_GoogleQueryPurchasesService;

            /*0x7f2e22c*/ GooglePurchaseUpdatedListener(UnityEngine.Purchasing.Interfaces.IGoogleLastKnownProductService googleLastKnownProductService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback googlePurchaseCallback, UnityEngine.Purchasing.Interfaces.IGooglePurchaseBuilder purchaseBuilder, UnityEngine.Purchasing.IGoogleCachedQueryProductDetailsService googleCachedQueryProductDetailsService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider, UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService googleQueryPurchasesService);
            /*0x7f2e32c*/ void SetGoogleQueryPurchaseService(UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService googleFetchPurchases);
            /*0x7f2e334*/ void onPurchasesUpdated(UnityEngine.AndroidJavaObject billingResult, UnityEngine.AndroidJavaObject javaPurchasesList);
            /*0x7f2e5a0*/ void OnPurchasesUpdated(UnityEngine.Purchasing.Models.IGoogleBillingResult result, System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases);
            /*0x7f2e7fc*/ void HandleResultOkCases(UnityEngine.Purchasing.Models.IGoogleBillingResult result, System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases);
            /*0x7f2ea14*/ void HandleErrorCases(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases);
            /*0x7f2eadc*/ void HandleErrorGoogleBillingResult(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult);
            /*0x7f2f548*/ void HandleUserCancelledPurchaseFailure(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult);
            /*0x7f2f618*/ void HandleUserCancelledPurchaseFailure(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> googlePurchases);
            /*0x7f2e8c4*/ void ApplyOnPurchases(System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases, System.Action<UnityEngine.Purchasing.Interfaces.IGooglePurchase> action);
            /*0x7f2f1cc*/ void ApplyOnPurchases(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases, UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Action<UnityEngine.Purchasing.Interfaces.IGooglePurchase, string> action);
            /*0x7f2f764*/ void OnPurchaseOk(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase);
            /*0x7f2fdb8*/ void HandlePurchasedProduct(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase);
            /*0x7f30050*/ bool IsDeferredSubscriptionChange(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase);
            /*0x7f30198*/ bool IsLastProrationModeDeferred();
            /*0x7f2fbd8*/ void OnPurchaseCancelled(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult);
            /*0x7f30270*/ void OnPurchaseCancelled(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase);
            /*0x7f303e8*/ void OnPurchaseAlreadyOwned(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase);
            /*0x7f30560*/ void OnPurchaseFailed(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase, string debugMessage);
            /*0x7f306f0*/ bool <HandleUserCancelledPurchaseFailure>b__15_0(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase);

            struct <HandleUserCancelledPurchaseFailure>d__14 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                /*0x38*/ UnityEngine.Purchasing.GooglePurchaseUpdatedListener <>4__this;
                /*0x40*/ UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult;
                /*0x48*/ System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>u__1;

                /*0x7f30820*/ void MoveNext();
                /*0x7f30a84*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class ProductDetailsResponseListener : UnityEngine.AndroidJavaProxy
        {
            static string k_AndroidProductDetailsResponseListenerClassName = "com.android.billingclient.api.ProductDetailsResponseListener";
            /*0x20*/ System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> m_OnProductDetailsResponse;
            /*0x28*/ Uniject.IUtil m_Util;
            /*0x30*/ UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics;

            /*0x7f30a90*/ ProductDetailsResponseListener(System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onProductDetailsResponseAction, Uniject.IUtil util, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics);
            /*0x7f30b4c*/ void onProductDetailsResponse(UnityEngine.AndroidJavaObject billingResult, UnityEngine.AndroidJavaObject productDetails);

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.AndroidJavaObject productDetails;
                /*0x18*/ UnityEngine.Purchasing.ProductDetailsResponseListener <>4__this;
                /*0x20*/ UnityEngine.AndroidJavaObject billingResult;

                /*0x7f30cac*/ <>c__DisplayClass5_0();
                /*0x7f30cb4*/ void <onProductDetailsResponse>b__0();
            }
        }

        class MetricizedGooglePlayStoreService : UnityEngine.Purchasing.GooglePlayStoreService
        {
            /*0x80*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService m_TelemetryMetricsService;
            /*0x88*/ UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics;

            /*0x7f30fd0*/ MetricizedGooglePlayStoreService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, UnityEngine.Purchasing.Interfaces.IQueryProductDetailsService queryProductDetailsService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseService purchaseService, UnityEngine.Purchasing.Interfaces.IGoogleFinishTransactionService finishTransactionService, UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService queryPurchasesService, UnityEngine.Purchasing.Interfaces.IBillingClientStateListener billingClientStateListener, UnityEngine.Purchasing.Interfaces.IGoogleLastKnownProductService lastKnownProductService, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics, UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService telemetryMetricsService, UnityEngine.ILogger logger, UnityEngine.Purchasing.Stores.Util.IRetryPolicy retryPolicy, Uniject.IUtil util);
            /*0x7f31028*/ void DequeueQueryProducts(UnityEngine.Purchasing.Models.GoogleBillingResponseCode googleBillingResponseCode);
            /*0x7f311a4*/ void DequeueFetchPurchases();
            /*0x7f312cc*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason, UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed);
            /*0x7f31484*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode);
            /*0x7f31630*/ void <>n__0(UnityEngine.Purchasing.Models.GoogleBillingResponseCode googleBillingResponseCode);
            /*0x7f31634*/ void <>n__1(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason, UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed);
            /*0x7f31638*/ void <>n__2(UnityEngine.Purchasing.ProductDefinition product, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode);

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedGooglePlayStoreService <>4__this;
                /*0x18*/ UnityEngine.Purchasing.Models.GoogleBillingResponseCode googleBillingResponseCode;

                /*0x7f3119c*/ <>c__DisplayClass3_0();
                /*0x7f3163c*/ void <DequeueQueryProducts>b__0();
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedGooglePlayStoreService <>4__this;
                /*0x18*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;
                /*0x20*/ System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived;
                /*0x28*/ System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason, UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed;

                /*0x7f3147c*/ <>c__DisplayClass5_0();
                /*0x7f3165c*/ void <RetrieveProducts>b__0();
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedGooglePlayStoreService <>4__this;
                /*0x18*/ UnityEngine.Purchasing.ProductDefinition product;
                /*0x20*/ UnityEngine.Purchasing.Product oldProduct;
                /*0x28*/ System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode;

                /*0x7f31628*/ <>c__DisplayClass6_0();
                /*0x7f31680*/ void <Purchase>b__0();
            }
        }

        enum GoogleBillingConnectionState
        {
            Disconnected = 0,
            Connecting = 1,
            Connected = 2,
            Closed = 3,
        }

        class ProductDetailsQueryResponse : UnityEngine.Purchasing.Interfaces.IProductDetailsQueryResponse
        {
            /*0x10*/ System.Collections.Concurrent.ConcurrentBag<System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>>> m_Responses;

            static /*0x7f322f0*/ bool IsRecoverable(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult);
            /*0x7f32400*/ ProductDetailsQueryResponse();
            /*0x7f316a4*/ void Finalize();
            /*0x7f31c44*/ void AddResponse(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails);
            /*0x7f31dd8*/ System.Collections.Generic.List<UnityEngine.AndroidJavaObject> ProductDetails();
            /*0x7f31fb8*/ bool IsRecoverable();
            /*0x7f32134*/ UnityEngine.Purchasing.Models.IGoogleBillingResult GetGoogleBillingResult();

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.ProductDetailsQueryResponse.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.AndroidJavaObject, UnityEngine.AndroidJavaObject> <>9__2_0;
                static /*0x10*/ System.Func<System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>>, bool> <>9__3_0;
                static /*0x18*/ System.Func<System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>>, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> <>9__3_1;
                static /*0x20*/ System.Func<System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>>, UnityEngine.Purchasing.Models.IGoogleBillingResult> <>9__4_0;
                static /*0x28*/ System.Func<System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>>, UnityEngine.Purchasing.Models.IGoogleBillingResult> <>9__5_0;
                static /*0x30*/ System.Func<UnityEngine.Purchasing.Models.IGoogleBillingResult, bool> <>9__5_1;

                static /*0x7f32488*/ <>c();
                /*0x7f324f0*/ <>c();
                /*0x7f324f8*/ UnityEngine.AndroidJavaObject <AddResponse>b__2_0(UnityEngine.AndroidJavaObject product);
                /*0x7f32510*/ bool <ProductDetails>b__3_0(System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> response);
                /*0x7f325b8*/ System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> <ProductDetails>b__3_1(System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> response);
                /*0x7f325c0*/ UnityEngine.Purchasing.Models.IGoogleBillingResult <IsRecoverable>b__4_0(System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> response);
                /*0x7f325c8*/ UnityEngine.Purchasing.Models.IGoogleBillingResult <GetGoogleBillingResult>b__5_0(System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> response);
                /*0x7f325d0*/ bool <GetGoogleBillingResult>b__5_1(UnityEngine.Purchasing.Models.IGoogleBillingResult response);
            }
        }

        class ProductDetailsResponseConsolidator : UnityEngine.Purchasing.Interfaces.IProductDetailsResponseConsolidator
        {
            /*0x10*/ int m_NumberReceivedCallbacks;
            /*0x18*/ System.Action<UnityEngine.Purchasing.Interfaces.IProductDetailsQueryResponse> m_OnProductDetailsResponseConsolidated;
            /*0x20*/ UnityEngine.Purchasing.Interfaces.IProductDetailsQueryResponse m_Responses;
            /*0x28*/ Uniject.IUtil m_Util;
            /*0x30*/ UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics;

            /*0x7f32678*/ ProductDetailsResponseConsolidator(Uniject.IUtil util, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics, System.Action<UnityEngine.Purchasing.Interfaces.IProductDetailsQueryResponse> onProductDetailsResponseConsolidated);
            /*0x7f3272c*/ void Consolidate(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails);
        }

        class QueryProductDetailsService : UnityEngine.Purchasing.Interfaces.IQueryProductDetailsService
        {
            /*0x10*/ UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient;
            /*0x18*/ UnityEngine.Purchasing.IGoogleCachedQueryProductDetailsService m_GoogleCachedQueryProductDetailsService;
            /*0x20*/ UnityEngine.Purchasing.Interfaces.IProductDetailsConverter m_ProductDetailsConverter;
            /*0x28*/ UnityEngine.Purchasing.Stores.Util.IRetryPolicy m_RetryPolicy;
            /*0x30*/ UnityEngine.Purchasing.Interfaces.IGoogleProductCallback m_GoogleProductCallback;
            /*0x38*/ Uniject.IUtil m_Util;
            /*0x40*/ UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics;

            /*0x7f3292c*/ QueryProductDetailsService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, UnityEngine.Purchasing.IGoogleCachedQueryProductDetailsService googleCachedQueryProductDetailsService, UnityEngine.Purchasing.Interfaces.IProductDetailsConverter productDetailsConverter, UnityEngine.Purchasing.Stores.Util.IRetryPolicy retryPolicy, UnityEngine.Purchasing.Interfaces.IGoogleProductCallback googleProductCallback, Uniject.IUtil util, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics);
            /*0x7f329ec*/ void QueryAsyncProduct(UnityEngine.Purchasing.ProductDefinition product, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse);
            /*0x7f32cc0*/ void QueryAsyncProduct(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse);
            /*0x7f32b10*/ void QueryAsyncProduct(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse);
            /*0x7f32db4*/ void QueryAsyncProductWithRetries(System.Collections.Generic.IReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse, System.Action retryQuery);
            /*0x7f32f20*/ void TryQueryAsyncProductWithRetries(System.Collections.Generic.IReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse, System.Action retryQuery);
            /*0x7f33498*/ bool ShouldRetryQuery(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> requestedProducts, UnityEngine.Purchasing.Interfaces.IProductDetailsQueryResponse queryResponse);
            /*0x7f3356c*/ bool AreAllProductDetailsCached(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x7f3373c*/ System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedProductDetails(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x7f33080*/ void QueryInAppsAsync(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products, UnityEngine.Purchasing.Interfaces.IProductDetailsResponseConsolidator consolidator);
            /*0x7f3328c*/ void QuerySubsAsync(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products, UnityEngine.Purchasing.Interfaces.IProductDetailsResponseConsolidator consolidator);
            /*0x7f338c8*/ void QueryProductDetails(System.Collections.Generic.List<string> productList, string type, UnityEngine.Purchasing.Interfaces.IProductDetailsResponseConsolidator consolidator);

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.QueryProductDetailsService.<> <>9;
                static /*0x8*/ System.Func<bool, bool> <>9__14_0;
                static /*0x10*/ System.Func<UnityEngine.Purchasing.ProductDefinition, bool> <>9__16_0;
                static /*0x18*/ System.Func<UnityEngine.Purchasing.ProductDefinition, string> <>9__16_1;
                static /*0x20*/ System.Func<UnityEngine.Purchasing.ProductDefinition, bool> <>9__17_0;
                static /*0x28*/ System.Func<UnityEngine.Purchasing.ProductDefinition, string> <>9__17_1;

                static /*0x7f33b20*/ <>c();
                /*0x7f33b88*/ <>c();
                /*0x7f33b90*/ bool <AreAllProductDetailsCached>b__14_0(bool isCached);
                /*0x7f33b98*/ bool <QueryInAppsAsync>b__16_0(UnityEngine.Purchasing.ProductDefinition product);
                /*0x7f33bb8*/ string <QueryInAppsAsync>b__16_1(UnityEngine.Purchasing.ProductDefinition product);
                /*0x7f33bd0*/ bool <QuerySubsAsync>b__17_0(UnityEngine.Purchasing.ProductDefinition product);
                /*0x7f33bf0*/ string <QuerySubsAsync>b__17_1(UnityEngine.Purchasing.ProductDefinition product);
            }

            class <>c__DisplayClass10_0
            {
                /*0x10*/ UnityEngine.Purchasing.QueryProductDetailsService <>4__this;
                /*0x18*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;
                /*0x20*/ System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse;
                /*0x28*/ int retryCount;

                /*0x7f32dac*/ <>c__DisplayClass10_0();
                /*0x7f33c08*/ void <QueryAsyncProduct>b__0(System.Action retryAction);
                /*0x7f33c2c*/ void <QueryAsyncProduct>g__OnActionRetry|1();
            }

            class <>c__DisplayClass12_0
            {
                /*0x10*/ UnityEngine.Purchasing.QueryProductDetailsService <>4__this;
                /*0x18*/ System.Collections.Generic.IReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;
                /*0x20*/ System.Action retryQuery;
                /*0x28*/ System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse;

                /*0x7f33078*/ <>c__DisplayClass12_0();
                /*0x7f33ce8*/ void <TryQueryAsyncProductWithRetries>b__0(UnityEngine.Purchasing.Interfaces.IProductDetailsQueryResponse productDetailsQueryResponse);
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse;
                /*0x18*/ UnityEngine.Purchasing.QueryProductDetailsService <>4__this;

                /*0x7f32da4*/ <>c__DisplayClass9_0();
                /*0x7f33f04*/ void <QueryAsyncProduct>b__0(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> productDetails, UnityEngine.Purchasing.Models.IGoogleBillingResult responseCode);
            }
        }

        class FakeGooglePlayStoreConfiguration : UnityEngine.Purchasing.IGooglePlayConfiguration, UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
            /*0x7f33fe0*/ FakeGooglePlayStoreConfiguration();
        }

        class FakeGooglePlayStoreExtensions : UnityEngine.Purchasing.IGooglePlayStoreExtensions, UnityEngine.Purchasing.IStoreExtension
        {
            /*0x7f33ff0*/ FakeGooglePlayStoreExtensions();
            /*0x7f33fe8*/ bool IsPurchasedProductDeferred(UnityEngine.Purchasing.Product product);
        }

        class GetGoogleProductMetadataExtension
        {
            static /*0x7f33ff8*/ UnityEngine.Purchasing.GoogleProductMetadata GetGoogleProductMetadata(UnityEngine.Purchasing.ProductMetadata productMetadata);
        }

        class GooglePlayConfiguration : UnityEngine.Purchasing.IGooglePlayConfiguration, UnityEngine.Purchasing.Extension.IStoreConfiguration, UnityEngine.Purchasing.IGooglePlayConfigurationInternal
        {
            /*0x10*/ System.Action m_InitializationConnectionLister;
            /*0x18*/ UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService;
            /*0x20*/ System.Action<UnityEngine.Purchasing.Product> m_DeferredPurchaseAction;
            /*0x28*/ System.Action<UnityEngine.Purchasing.Product> m_DeferredProrationUpgradeDowngradeSubscriptionAction;
            /*0x30*/ System.Action<int> m_QueryProductDetailsFailedListener;
            /*0x38*/ bool m_FetchPurchasesAtInitialize;
            /*0x39*/ bool m_FetchPurchasesExcludeDeferred;

            /*0x7f34070*/ GooglePlayConfiguration(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService);
            /*0x7f340a8*/ void NotifyInitializationConnectionFailed();
            /*0x7f340c4*/ void NotifyQueryProductDetailsFailed(int retryCount);
            /*0x7f340e0*/ void NotifyDeferredProrationUpgradeDowngradeSubscription(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback, string productId);
            /*0x7f342b0*/ bool IsFetchPurchasesAtInitializeSkipped();
            /*0x7f342c0*/ bool DoesRetrievePurchasesExcludeDeferred();
            /*0x7f342c8*/ void NotifyDeferredPurchase(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback, UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, string receipt, string transactionId);
        }

        class GooglePlayProductCallback : UnityEngine.Purchasing.Interfaces.IGoogleProductCallback
        {
            /*0x10*/ UnityEngine.Purchasing.IGooglePlayConfigurationInternal m_GooglePlayConfigurationInternal;

            /*0x7f344c4*/ GooglePlayProductCallback();
            /*0x7f34408*/ void SetStoreConfiguration(UnityEngine.Purchasing.IGooglePlayConfigurationInternal configuration);
            /*0x7f34410*/ void NotifyQueryProductDetailsFailed(int retryCount);
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

            /*0x7f344cc*/ GooglePlayPurchaseCallback(Uniject.IUtil util);
            /*0x7f344fc*/ void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
            /*0x7f34504*/ void SetStoreConfiguration(UnityEngine.Purchasing.IGooglePlayConfigurationInternal configuration);
            /*0x7f3450c*/ void OnPurchaseSuccessful(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, string receipt, string purchaseToken);
            /*0x7f34670*/ void OnPurchaseFailed(UnityEngine.Purchasing.Extension.PurchaseFailureDescription purchaseFailureDescription);
            /*0x7f34724*/ void NotifyDeferredPurchase(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, string receipt, string purchaseToken);
            /*0x7f348a0*/ void NotifyDeferredProrationUpgradeDowngradeSubscription(string sku);

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.Purchasing.GooglePlayPurchaseCallback <>4__this;
                /*0x18*/ UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase;
                /*0x20*/ string receipt;
                /*0x28*/ string purchaseToken;

                /*0x7f34898*/ <>c__DisplayClass8_0();
                /*0x7f349ec*/ void <NotifyDeferredPurchase>b__0();
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ UnityEngine.Purchasing.GooglePlayPurchaseCallback <>4__this;
                /*0x18*/ string sku;

                /*0x7f349e4*/ <>c__DisplayClass9_0();
                /*0x7f34acc*/ void <NotifyDeferredProrationUpgradeDowngradeSubscription>b__0();
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

            /*0x7f34b94*/ GooglePlayStore(UnityEngine.Purchasing.IGooglePlayStoreRetrieveProductsService retrieveProductsService, UnityEngine.Purchasing.IGooglePlayStorePurchaseService storePurchaseService, UnityEngine.Purchasing.IGoogleFetchPurchases fetchPurchases, UnityEngine.Purchasing.IGooglePlayStoreFinishTransactionService transactionService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback googlePurchaseCallback, UnityEngine.Purchasing.IGooglePlayConfigurationInternal googlePlayConfigurationInternal, UnityEngine.Purchasing.IGooglePlayStoreExtensionsInternal googlePlayStoreExtensions, Uniject.IUtil util);
            /*0x7f34c68*/ void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback callback);
            /*0x7f34f6c*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x7f350ec*/ bool HasInitiallyRetrievedProducts();
            /*0x7f35028*/ bool ShouldFetchPurchasesNext();
            /*0x7f35190*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, string dummy);
            /*0x7f35238*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId);
            /*0x7f352f4*/ void OnPause(bool isPaused);
        }

        class GooglePlayStoreExtensions : UnityEngine.Purchasing.IGooglePlayStoreExtensions, UnityEngine.Purchasing.IStoreExtension, UnityEngine.Purchasing.IGooglePlayStoreExtensionsInternal
        {
            /*0x10*/ UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService;
            /*0x18*/ UnityEngine.Purchasing.Interfaces.IGooglePurchaseStateEnumProvider m_GooglePurchaseStateEnumProvider;
            /*0x20*/ UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics;
            /*0x28*/ UnityEngine.ILogger m_Logger;
            /*0x30*/ UnityEngine.Purchasing.Extension.IStoreCallback m_StoreCallback;

            /*0x7f35424*/ GooglePlayStoreExtensions(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider, UnityEngine.ILogger logger, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics);
            /*0x7f35498*/ void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
            /*0x7f354a0*/ bool IsPurchasedProductDeferred(UnityEngine.Purchasing.Product product);
            /*0x7f35658*/ bool TryIsPurchasedProductDeferred(UnityEngine.Purchasing.Product product);
            /*0x7f3567c*/ UnityEngine.Purchasing.Security.GooglePurchaseState GetPurchaseState(UnityEngine.Purchasing.Product product);
            /*0x7f35884*/ UnityEngine.Purchasing.Interfaces.IGooglePurchase GooglePurchaseFromProduct(UnityEngine.Purchasing.Product product);
        }

        interface IGooglePlayConfiguration : UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
        }

        interface IGooglePlayConfigurationInternal
        {
            /*0x380cb08*/ void NotifyInitializationConnectionFailed();
            /*0x380da84*/ void NotifyDeferredPurchase(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback, UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, string receipt, string transactionId);
            /*0x380d93c*/ void NotifyDeferredProrationUpgradeDowngradeSubscription(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback, string productId);
            /*0x380b128*/ bool IsFetchPurchasesAtInitializeSkipped();
            /*0x380b128*/ bool DoesRetrievePurchasesExcludeDeferred();
            /*0x380cffc*/ void NotifyQueryProductDetailsFailed(int retryCount);
        }

        interface IGooglePlayStoreExtensions : UnityEngine.Purchasing.IStoreExtension
        {
            /*0x380b2f0*/ bool IsPurchasedProductDeferred(UnityEngine.Purchasing.Product product);
        }

        interface IGooglePlayStoreExtensionsInternal
        {
            /*0x380d83c*/ void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
        }

        interface IGoogleFetchPurchases
        {
            /*0x380d83c*/ void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
            /*0x380cb08*/ void FetchPurchases();
            /*0x380d83c*/ void FetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> onQueryPurchaseSucceed);
        }

        interface IGooglePlayStoreFinishTransactionService
        {
            /*0x380d83c*/ void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
            /*0x380d93c*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string purchaseToken);
        }

        interface IGooglePlayStorePurchaseService
        {
            /*0x380d83c*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product);
        }

        interface IGooglePlayStoreRetrieveProductsService
        {
            /*0x380d83c*/ void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
            void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, bool wantPurchases);
            /*0x380cb08*/ void ResumeConnection();
            /*0x380b128*/ bool HasInitiallyRetrievedProducts();
        }

        class MetricizedGooglePlayStoreExtensions : UnityEngine.Purchasing.GooglePlayStoreExtensions
        {
            /*0x38*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService m_TelemetryMetricsService;

            /*0x7f35968*/ MetricizedGooglePlayStoreExtensions(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider, UnityEngine.ILogger logger, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics, UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService telemetryMetricsService);
        }

        class GoogleProductMetadata : UnityEngine.Purchasing.ProductMetadata
        {
            /*0x40*/ string <originalJson>k__BackingField;
            /*0x48*/ string <subscriptionPeriod>k__BackingField;
            /*0x50*/ string <freeTrialPeriod>k__BackingField;
            /*0x58*/ string <introductoryPrice>k__BackingField;
            /*0x60*/ string <introductoryPricePeriod>k__BackingField;
            /*0x68*/ int <introductoryPriceCycles>k__BackingField;

            /*0x7f359cc*/ GoogleProductMetadata(string priceString, string title, string description, string currencyCode, decimal localizedPrice);
            /*0x7f35994*/ string get_originalJson();
            /*0x7f3599c*/ void set_originalJson(string value);
            /*0x7f359a4*/ void set_subscriptionPeriod(string value);
            /*0x7f359ac*/ void set_freeTrialPeriod(string value);
            /*0x7f359b4*/ void set_introductoryPrice(string value);
            /*0x7f359bc*/ void set_introductoryPricePeriod(string value);
            /*0x7f359c4*/ void set_introductoryPriceCycles(int value);
        }

        class GoogleFetchPurchases : UnityEngine.Purchasing.IGoogleFetchPurchases
        {
            /*0x10*/ UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService;
            /*0x18*/ UnityEngine.Purchasing.Extension.IStoreCallback m_StoreCallback;
            /*0x20*/ Uniject.IUtil m_Util;

            static /*0x7f35f38*/ UnityEngine.Purchasing.Product CompleteProductInfoWithPurchase(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase);
            static /*0x7f3631c*/ System.Func<UnityEngine.Purchasing.Interfaces.IGooglePurchase, bool> PurchaseIsPurchased();
            static /*0x7f363ec*/ System.Func<UnityEngine.Purchasing.Interfaces.IGooglePurchase, bool> PurchaseIsPending();
            /*0x7f359d4*/ GoogleFetchPurchases(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService, Uniject.IUtil util);
            /*0x7f35a18*/ void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
            /*0x7f35a20*/ void FetchPurchases();
            /*0x7f35b14*/ void FetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> onQueryPurchaseSucceed);
            /*0x7f35c60*/ System.Collections.Generic.List<UnityEngine.Purchasing.Product> FillProductsWithPurchases(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases);
            /*0x7f35d20*/ System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Product> BuildProductsFromPurchase(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase);
            /*0x7f360a8*/ void OnFetchedPurchase(System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases);
            /*0x7f364bc*/ void UpdateDeferredProductsByPurchases(System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> deferredPurchases);
            /*0x7f365f8*/ void UpdateDeferredProductsByPurchase(UnityEngine.Purchasing.Interfaces.IGooglePurchase deferredPurchase);
            /*0x7f367a8*/ void UpdateDeferredProduct(UnityEngine.Purchasing.Interfaces.IGooglePurchase deferredPurchase, string sku);

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.GoogleFetchPurchases.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.Purchasing.Interfaces.IGooglePurchase, bool> <>9__11_0;
                static /*0x10*/ System.Func<UnityEngine.Purchasing.Interfaces.IGooglePurchase, bool> <>9__12_0;

                static /*0x7f368fc*/ <>c();
                /*0x7f36964*/ <>c();
                /*0x7f3696c*/ bool <PurchaseIsPurchased>b__11_0(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase);
                /*0x7f36a0c*/ bool <PurchaseIsPending>b__12_0(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase);
            }

            class <>c__DisplayClass10_0
            {
                /*0x10*/ UnityEngine.Purchasing.GoogleFetchPurchases <>4__this;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> deferredPurchases;

                /*0x7f36314*/ <>c__DisplayClass10_0();
                /*0x7f36aac*/ void <OnFetchedPurchase>b__0();
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> onQueryPurchaseSucceed;
                /*0x18*/ UnityEngine.Purchasing.GoogleFetchPurchases <>4__this;

                /*0x7f35c58*/ <>c__DisplayClass6_0();
                /*0x7f36acc*/ void <FetchPurchases>b__0(System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> googlePurchases);
            }

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.Purchasing.GoogleFetchPurchases <>4__this;
                /*0x18*/ UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase;

                /*0x7f35f30*/ <>c__DisplayClass8_0();
                /*0x7f36b04*/ UnityEngine.Purchasing.Product <BuildProductsFromPurchase>b__0(string sku);
                /*0x7f36b2c*/ UnityEngine.Purchasing.Product <BuildProductsFromPurchase>b__1(UnityEngine.Purchasing.Product product);
            }
        }

        class GooglePlayStoreFinishTransactionService : UnityEngine.Purchasing.IGooglePlayStoreFinishTransactionService
        {
            /*0x10*/ System.Collections.Generic.HashSet<string> m_ProcessedPurchaseToken;
            /*0x18*/ UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService;
            /*0x20*/ UnityEngine.Purchasing.Extension.IStoreCallback m_StoreCallback;
            /*0x28*/ int m_RetryCount;

            static /*0x7f37410*/ bool IsResponseCodeInRecoverableState(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult);
            /*0x7f36b3c*/ GooglePlayStoreFinishTransactionService(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService);
            /*0x7f36bd8*/ void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
            /*0x7f36be0*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string purchaseToken);
            /*0x7f36d48*/ void HandleFinishTransaction(UnityEngine.Purchasing.ProductDefinition product, UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase);
            /*0x7f371f4*/ void CallPurchaseSucceededUpdateReceipt(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase);

            class <>c__DisplayClass7_0
            {
                /*0x10*/ UnityEngine.Purchasing.GooglePlayStoreFinishTransactionService <>4__this;
                /*0x18*/ UnityEngine.Purchasing.ProductDefinition product;

                /*0x7f36d40*/ <>c__DisplayClass7_0();
                /*0x7f37580*/ void <FinishTransaction>b__0(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase);
            }
        }

        class GooglePlayStorePurchaseService : UnityEngine.Purchasing.IGooglePlayStorePurchaseService
        {
            /*0x10*/ UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService;

            /*0x7f375a8*/ GooglePlayStorePurchaseService(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService);
            /*0x7f375d8*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product);
        }

        class GooglePlayStoreRetrieveProductsService : UnityEngine.Purchasing.IGooglePlayStoreRetrieveProductsService
        {
            /*0x10*/ UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService;
            /*0x18*/ UnityEngine.Purchasing.IGoogleFetchPurchases m_GoogleFetchPurchases;
            /*0x20*/ UnityEngine.Purchasing.Extension.IStoreCallback m_StoreCallback;
            /*0x28*/ UnityEngine.Purchasing.IGooglePlayConfigurationInternal m_GooglePlayConfigurationInternal;
            /*0x30*/ UnityEngine.Purchasing.IGooglePlayStoreExtensions m_GooglePlayStoreExtensions;
            /*0x38*/ bool m_HasInitiallyRetrievedProducts;
            /*0x39*/ bool m_RetrieveProductsFailed;

            /*0x7f37684*/ GooglePlayStoreRetrieveProductsService(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService, UnityEngine.Purchasing.IGoogleFetchPurchases googleFetchPurchases, UnityEngine.Purchasing.IGooglePlayConfigurationInternal googlePlayConfigurationInternal, UnityEngine.Purchasing.IGooglePlayStoreExtensions googlePlayStoreExtensions);
            /*0x7f37700*/ void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
            /*0x7f37708*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, bool wantPurchases);
            /*0x7f378e8*/ void OnProductsRetrievedWithPurchaseFetch(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> retrievedProducts, UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult);
            /*0x7f37d00*/ void OnProductsRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> retrievedProducts, UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult);
            /*0x7f37b48*/ void OnRetrieveProductsFailed(UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason reason, UnityEngine.Purchasing.Models.GoogleBillingResponseCode responseCode);
            /*0x7f37ed0*/ void ResumeConnection();
            /*0x7f37f74*/ System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> MakePurchasesIntoProducts(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> retrievedProducts, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Product> purchaseProducts);
            /*0x7f384d0*/ bool IsPurchasedProductDeferred(UnityEngine.Purchasing.Product product);
            /*0x7f38578*/ bool HasInitiallyRetrievedProducts();

            class <>c__DisplayClass10_0
            {
                /*0x10*/ UnityEngine.Purchasing.GooglePlayStoreRetrieveProductsService <>4__this;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> retrievedProducts;

                /*0x7f37b40*/ <>c__DisplayClass10_0();
                /*0x7f38580*/ void <OnProductsRetrievedWithPurchaseFetch>b__0(System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchaseProducts);
            }

            class <>c__DisplayClass14_0
            {
                /*0x10*/ UnityEngine.Purchasing.Product purchaseProduct;

                /*0x7f384c8*/ <>c__DisplayClass14_0();
                /*0x7f38658*/ bool <MakePurchasesIntoProducts>b__0(UnityEngine.Purchasing.Extension.ProductDescription product);
            }
        }

        class StoreCallbackExtensionMethods
        {
            static /*0x7f34120*/ UnityEngine.Purchasing.Product FindProductById(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback, string sku);
        }

        interface IAndroidStoreSelection : UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
        }

        interface IUnityCallback
        {
            /*0x380d83c*/ void OnSetupFailed(string json);
            /*0x380d83c*/ void OnProductsRetrieved(string json);
            /*0x380da4c*/ void OnPurchaseSucceeded(string id, string receipt, string transactionID);
            /*0x380d83c*/ void OnPurchaseFailed(string json);
        }

        class JavaBridge : UnityEngine.AndroidJavaProxy, UnityEngine.Purchasing.IUnityCallback
        {
            /*0x20*/ UnityEngine.Purchasing.IUnityCallback forwardTo;

            /*0x7f38688*/ JavaBridge(UnityEngine.Purchasing.IUnityCallback forwardTo);
            /*0x7f38714*/ JavaBridge(UnityEngine.Purchasing.IUnityCallback forwardTo, string javaInterface);
            /*0x7f38790*/ void OnSetupFailed(string json);
            /*0x7f38838*/ void OnProductsRetrieved(string json);
            /*0x7f388e4*/ void OnPurchaseSucceeded(string id, string receipt, string transactionID);
            /*0x7f389a8*/ void OnPurchaseFailed(string json);
        }

        class SerializationExtensions
        {
            static /*0x7f28424*/ string TryGetString(System.Collections.Generic.Dictionary<string, object> dic, string key);
        }

        class JSONSerializer
        {
            static /*0x7f38a54*/ string SerializeProductDef(UnityEngine.Purchasing.ProductDefinition product);
            static /*0x7f39320*/ string SerializeProductDefs(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products);
            static /*0x7f396a8*/ string SerializeProductDescs(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Extension.ProductDescription> products);
            static /*0x7f39c28*/ UnityEngine.Purchasing.Extension.PurchaseFailureDescription DeserializeFailureReason(string json);
            static /*0x7f39f84*/ string BuildPurchaseFailureDescriptionMessage(System.Collections.Generic.Dictionary<string, object> dic);
            static /*0x7f38a68*/ System.Collections.Generic.Dictionary<string, object> EncodeProductDef(UnityEngine.Purchasing.ProductDefinition product);
            static /*0x7f39a30*/ System.Collections.Generic.Dictionary<string, object> EncodeProductDesc(UnityEngine.Purchasing.Extension.ProductDescription product);
            static /*0x7f3a04c*/ System.Collections.Generic.Dictionary<string, object> EncodeProductMeta(UnityEngine.Purchasing.ProductMetadata product);
        }

        class ScriptingStoreCallback : UnityEngine.Purchasing.Extension.IStoreCallback
        {
            /*0x10*/ UnityEngine.Purchasing.Extension.IStoreCallback m_ForwardTo;
            /*0x18*/ Uniject.IUtil m_Util;

            /*0x7f34f28*/ ScriptingStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback forwardTo, Uniject.IUtil util);
            /*0x7f3a208*/ UnityEngine.Purchasing.ProductCollection get_products();
            /*0x7f3a2a8*/ void OnSetupFailed(UnityEngine.Purchasing.InitializationFailureReason reason, string message);
            /*0x7f3a404*/ void OnProductsRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products);
            /*0x7f3a550*/ void OnPurchaseSucceeded(string id, string receipt, string transactionID);
            /*0x7f3a6cc*/ void OnAllPurchasesRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchasedProducts);
            /*0x7f3a818*/ void OnPurchaseFailed(UnityEngine.Purchasing.Extension.PurchaseFailureDescription desc);

            class <>c__DisplayClass10_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingStoreCallback <>4__this;
                /*0x18*/ UnityEngine.Purchasing.Extension.PurchaseFailureDescription desc;

                /*0x7f3a95c*/ <>c__DisplayClass10_0();
                /*0x7f3a964*/ void <OnPurchaseFailed>b__0();
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingStoreCallback <>4__this;
                /*0x18*/ UnityEngine.Purchasing.InitializationFailureReason reason;
                /*0x20*/ string message;

                /*0x7f3a3fc*/ <>c__DisplayClass6_0();
                /*0x7f3aa18*/ void <OnSetupFailed>b__0();
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingStoreCallback <>4__this;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products;

                /*0x7f3a548*/ <>c__DisplayClass7_0();
                /*0x7f3aad4*/ void <OnProductsRetrieved>b__0();
            }

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingStoreCallback <>4__this;
                /*0x18*/ string id;
                /*0x20*/ string receipt;
                /*0x28*/ string transactionID;

                /*0x7f3a6c4*/ <>c__DisplayClass8_0();
                /*0x7f3ab88*/ void <OnPurchaseSucceeded>b__0();
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingStoreCallback <>4__this;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchasedProducts;

                /*0x7f3a810*/ <>c__DisplayClass9_0();
                /*0x7f3ac50*/ void <OnAllPurchasesRetrieved>b__0();
            }
        }

        class ScriptingUnityCallback : UnityEngine.Purchasing.IUnityCallback
        {
            /*0x10*/ UnityEngine.Purchasing.IUnityCallback forwardTo;
            /*0x18*/ Uniject.IUtil util;

            /*0x7f3ad04*/ ScriptingUnityCallback(UnityEngine.Purchasing.IUnityCallback forwardTo, Uniject.IUtil util);
            /*0x7f3ad48*/ void OnSetupFailed(string json);
            /*0x7f3ae94*/ void OnProductsRetrieved(string json);
            /*0x7f3afe0*/ void OnPurchaseSucceeded(string id, string receipt, string transactionID);
            /*0x7f3b15c*/ void OnPurchaseFailed(string json);

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingUnityCallback <>4__this;
                /*0x18*/ string json;

                /*0x7f3ae8c*/ <>c__DisplayClass3_0();
                /*0x7f3b2a8*/ void <OnSetupFailed>b__0();
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingUnityCallback <>4__this;
                /*0x18*/ string json;

                /*0x7f3afd8*/ <>c__DisplayClass4_0();
                /*0x7f3b358*/ void <OnProductsRetrieved>b__0();
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingUnityCallback <>4__this;
                /*0x18*/ string id;
                /*0x20*/ string receipt;
                /*0x28*/ string transactionID;

                /*0x7f3b154*/ <>c__DisplayClass5_0();
                /*0x7f3b40c*/ void <OnPurchaseSucceeded>b__0();
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingUnityCallback <>4__this;
                /*0x18*/ string json;

                /*0x7f3b2a0*/ <>c__DisplayClass6_0();
                /*0x7f3b4d4*/ void <OnPurchaseFailed>b__0();
            }
        }

        class FakeUDPExtension : UnityEngine.Purchasing.IUDPExtensions, UnityEngine.Purchasing.IStoreExtension
        {
            /*0x7f3b588*/ FakeUDPExtension();
        }

        interface INativeUDPStore : UnityEngine.Purchasing.INativeStore
        {
            /*0x380d83c*/ void Initialize(System.Action<bool, string> callback);
            /*0x380da4c*/ void Purchase(string productId, System.Action<bool, string> callback, string developerPayload);
            /*0x380d93c*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<bool, string> callback);
            /*0x380d93c*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition productDefinition, string transactionID);
        }

        interface IUDPExtensions : UnityEngine.Purchasing.IStoreExtension
        {
        }

        class UDP
        {
            static /*0x7f3b590*/ string get_Name();
        }

        class UDPBindings : UnityEngine.Purchasing.INativeUDPStore, UnityEngine.Purchasing.INativeStore
        {
            /*0x10*/ object m_Bridge;
            /*0x18*/ System.Action<bool, string> m_RetrieveProductsCallbackCache;

            static /*0x7f3d00c*/ System.Collections.Generic.Dictionary<string, string> StringPropertyToDictionary(object info);
            /*0x7f3b69c*/ UDPBindings();
            /*0x7f3b840*/ void Initialize(System.Action<bool, string> callback);
            /*0x7f3b9b4*/ void Purchase(string productId, System.Action<bool, string> callback, string developerPayload);
            /*0x7f3bba0*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<bool, string> callback);
            /*0x7f3c178*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition productDefinition, string transactionID);
            /*0x7f3c2ec*/ void OnInventoryQueried(bool success, object payload);
            /*0x7f3d1d0*/ void RetrieveProducts(string json);
            /*0x7f3d208*/ void Purchase(string productJSON, string developerPayload);
            /*0x7f3d240*/ void FinishTransaction(string productJSON, string transactionID);
        }

        class UDPImpl : UnityEngine.Purchasing.JSONStore, UnityEngine.Purchasing.IUDPExtensions, UnityEngine.Purchasing.IStoreExtension
        {
            /*0x48*/ UnityEngine.Purchasing.INativeUDPStore m_Bindings;
            /*0x50*/ object m_UserInfo;
            /*0x58*/ string m_LastInitError;
            /*0x60*/ bool m_Initialized;
            /*0x68*/ System.Action<UnityEngine.Purchasing.Product> m_DeferredCallback;

            static /*0x7f3d7d0*/ void DictionaryToStringProperty(System.Collections.Generic.Dictionary<string, object> dic, object info);
            /*0x7f3d928*/ UDPImpl();
            /*0x7f3d278*/ void SetNativeStore(UnityEngine.Purchasing.INativeUDPStore nativeUdpStore);
            /*0x7f3d280*/ void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback callback);
            /*0x7f3d288*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x7f3d480*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);
            /*0x7f3d5e8*/ void OnPurchaseDeferred(string productId);
            /*0x7f3d6f4*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId);

            class <>c__DisplayClass10_0
            {
                /*0x10*/ UnityEngine.Purchasing.UDPImpl <>4__this;
                /*0x18*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;

                /*0x7f3d478*/ <>c__DisplayClass10_0();
                /*0x7f3d9a0*/ void <RetrieveProducts>g__retrieveCallback|0(bool success, string json);
                /*0x7f3da58*/ void <RetrieveProducts>b__1(bool success, string message);
            }

            class <>c__DisplayClass11_0
            {
                /*0x10*/ UnityEngine.Purchasing.ProductDefinition product;
                /*0x18*/ UnityEngine.Purchasing.UDPImpl <>4__this;

                /*0x7f3d5e0*/ <>c__DisplayClass11_0();
                /*0x7f3ddfc*/ void <Purchase>b__0(bool success, string message);
            }
        }

        class UDPReflectionUtils
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<System.Reflection.Assembly, System.Type[]> s_assemblyTypeCache;
            static /*0x8*/ System.Collections.Generic.Dictionary<string, System.Type> s_typeCache;
            static /*0x10*/ string[] k_whiteListedAssemblies;

            static /*0x7f3ee30*/ UDPReflectionUtils();
            static /*0x7f3e4d0*/ System.Type GetTypeByName(string typeName);
            static /*0x7f3ed08*/ System.Collections.Generic.IEnumerable<System.Reflection.Assembly> GetAllAssemblies();
            static /*0x7f3ed30*/ System.Collections.Generic.IEnumerable<System.Type> GetTypes(System.Reflection.Assembly assembly);

            class <>c__DisplayClass6_0
            {
                /*0x10*/ System.Reflection.Assembly assembly;

                /*0x7f3ed28*/ <>c__DisplayClass6_0();
                /*0x7f3f02c*/ bool <GetTypeByName>b__0(string x);
            }
        }

        class InventoryInterface
        {
            static /*0x0*/ System.Type s_typeCache;

            static /*0x7f3cc84*/ System.Type GetClassType();
            static /*0x7f3cd60*/ System.Reflection.MethodInfo GetProductListMethod();
            static /*0x7f3cfc0*/ System.Reflection.MethodInfo GetPurchaseInfoMethod();
            static /*0x7f3cf74*/ System.Reflection.MethodInfo HasPurchaseMethod();
        }

        class ProductInfoInterface
        {
            static /*0x0*/ System.Type s_typeCache;

            static /*0x7f3f060*/ System.Type GetClassType();
            static /*0x7f3ce90*/ System.Reflection.PropertyInfo GetCurrencyProp();
            static /*0x7f3ce44*/ System.Reflection.PropertyInfo GetDescriptionProp();
            static /*0x7f3cdac*/ System.Reflection.PropertyInfo GetPriceProp();
            static /*0x7f3cedc*/ System.Reflection.PropertyInfo GetPriceAmountMicrosProp();
            static /*0x7f3cf28*/ System.Reflection.PropertyInfo GetProductIdProp();
            static /*0x7f3cdf8*/ System.Reflection.PropertyInfo GetTitleProp();
        }

        class StoreServiceInterface
        {
            static /*0x0*/ System.Type s_typeCache;

            static /*0x7f3f13c*/ System.Type GetClassType();
            static /*0x7f3f218*/ System.Reflection.PropertyInfo GetNameProp();
            static /*0x7f3b650*/ string GetName();
        }

        class UdpIapBridgeInterface
        {
            static /*0x0*/ System.Type s_typeCache;

            static /*0x7f3b764*/ System.Type GetClassType();
            static /*0x7f3b968*/ System.Reflection.MethodInfo GetInitMethod();
            static /*0x7f3bb54*/ System.Reflection.MethodInfo GetPurchaseMethod();
            static /*0x7f3c12c*/ System.Reflection.MethodInfo GetRetrieveProductsMethod();
            static /*0x7f3c2a0*/ System.Reflection.MethodInfo GetFinishTransactionMethod();
        }

        class UserInfoInterface
        {
            static /*0x0*/ System.Type s_typeCache;

            static /*0x7f3dd20*/ System.Type GetClassType();
        }

        class AppleJsonProductDescriptionsDeserializer : Stores.Util.JsonProductDescriptionsDeserializer
        {
            /*0x7f3f378*/ AppleJsonProductDescriptionsDeserializer();
            /*0x7f3f268*/ UnityEngine.Purchasing.ProductMetadata DeserializeMetadata(System.Collections.Generic.Dictionary<string, object> data);
        }

        class AppleProductMetadata : UnityEngine.Purchasing.ProductMetadata
        {
            /*0x40*/ bool <isFamilyShareable>k__BackingField;

            /*0x7f3f300*/ AppleProductMetadata(UnityEngine.Purchasing.ProductMetadata baseProductMetadata, string isFamilyShareable);
        }

        class AppleStoreImpl : UnityEngine.Purchasing.JSONStore, UnityEngine.Purchasing.IAppleExtensions, UnityEngine.Purchasing.IStoreExtension, UnityEngine.Purchasing.IAppleConfiguration, UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
            static /*0x0*/ Uniject.IUtil s_Util;
            static /*0x8*/ UnityEngine.Purchasing.AppleStoreImpl s_Instance;
            /*0x48*/ System.Action<UnityEngine.Purchasing.Product> m_DeferredCallback;
            /*0x50*/ System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> m_RevokedCallback;
            /*0x58*/ System.Action<string> m_RefreshReceiptError;
            /*0x60*/ System.Action<string> m_RefreshReceiptSuccess;
            /*0x68*/ System.Action<bool> m_ObsoleteRestoreCallback;
            /*0x70*/ System.Action<bool, string> m_RestoreCallback;
            /*0x78*/ System.Action m_FetchStorePromotionOrderError;
            /*0x80*/ System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> m_FetchStorePromotionOrderSuccess;
            /*0x88*/ System.Action<UnityEngine.Purchasing.Product> m_PromotionalPurchaseCallback;
            /*0x90*/ System.Action m_FetchStorePromotionVisibilityError;
            /*0x98*/ System.Action<string, UnityEngine.Purchasing.AppleStorePromotionVisibility> m_FetchStorePromotionVisibilitySuccess;
            /*0xa0*/ UnityEngine.Purchasing.INativeAppleStore m_Native;
            /*0xa8*/ UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics;
            /*0xb0*/ string m_CachedAppReceipt;
            /*0xb8*/ System.Nullable<double> m_CachedAppReceiptModificationDate;
            /*0xc8*/ string m_ProductsJson;

            static /*0x7f405d0*/ UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt FindMostRecentReceipt(UnityEngine.Purchasing.Security.AppleReceipt appleReceipt, string productId);
            static /*0x7f410fc*/ UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt FirstNonCancelledReceipt(UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt[] foundReceipts);
            static /*0x7f3f380*/ void MessageCallback(string subject, string payload, string receipt, string transactionId, string originalTransactionId, bool isRestored);
            static /*0x7f42878*/ bool IsValidPurchaseState(UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt mostRecentReceipt, string productId);
            static /*0x7f42ca4*/ bool IsSubscriptionRestored(UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt productReceipt, UnityEngine.Purchasing.Product previousProduct);
            static /*0x7f42c84*/ bool IsNonSubscriptionRestored(string transactionId, string originalTransactionId);
            /*0x7f3f554*/ AppleStoreImpl(Uniject.IUtil util, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics);
            /*0x7f3f628*/ void SetNativeStore(UnityEngine.Purchasing.INativeAppleStore apple);
            /*0x7f3f738*/ string get_appReceipt();
            /*0x7f3f934*/ System.Nullable<double> get_appReceiptModificationDate();
            /*0x7f3fa10*/ bool get_canMakePayments();
            /*0x7f3fac0*/ string GetTransactionReceiptForProduct(UnityEngine.Purchasing.Product product);
            /*0x7f3fb98*/ void OnProductsRetrieved(string json);
            /*0x7f3ff78*/ bool HasInAppPurchaseReceipts(UnityEngine.Purchasing.Security.AppleReceipt appleReceipt);
            /*0x7f3ff9c*/ System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> EnrichProductDescriptions(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> productDescriptions, UnityEngine.Purchasing.Security.AppleReceipt appleReceipt);
            /*0x7f411bc*/ void RestoreTransactions(System.Action<bool, string> callback);
            /*0x7f4127c*/ void RegisterPurchaseDeferredListener(System.Action<UnityEngine.Purchasing.Product> callback);
            /*0x7f41284*/ void OnPurchaseDeferred(string productId);
            /*0x7f4136c*/ void OnPromotionalPurchaseAttempted(string productId);
            /*0x7f41454*/ void OnTransactionsRestoredSuccess();
            /*0x7f414a4*/ void OnTransactionsRestoredFail(string error);
            /*0x7f41504*/ void OnAppReceiptRetrieved(string receipt);
            /*0x7f41520*/ void OnAppReceiptRefreshedFailed(string error);
            /*0x7f4153c*/ void OnEntitlementsRevoked(string productIds);
            /*0x7f417e8*/ void RevokeEntitlement(UnityEngine.Purchasing.Security.AppleReceipt appleReceipt, string productId, System.Collections.Generic.List<UnityEngine.Purchasing.Product> revokedProducts, UnityEngine.Purchasing.Product product);
            /*0x7f418f0*/ bool RestoreActiveEntitlement(UnityEngine.Purchasing.Security.AppleReceipt appleReceipt, string productId);
            /*0x7f419f4*/ void OnFetchStorePromotionOrderSucceeded(string productIds);
            /*0x7f41cf0*/ void OnFetchStorePromotionOrderFailed();
            /*0x7f41d0c*/ void OnFetchStorePromotionVisibilitySucceeded(string result);
            /*0x7f41fe0*/ void OnFetchStorePromotionVisibilityFailed();
            /*0x7f42004*/ void ProcessMessage(string subject, string payload, string receipt, string transactionId, string originalTransactionId, bool isRestored);
            /*0x7f42788*/ void OnPurchaseSucceeded(string id, string receipt, string transactionId, string originalTransactionId, bool isRestored);
            /*0x7f3fdac*/ UnityEngine.Purchasing.Security.AppleReceipt GetAppleReceiptFromBase64String(string receipt);
            /*0x7f429bc*/ bool IsRestored(string productId, UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt productReceipt, string transactionId, string originalTransactionId);
            /*0x7f41008*/ void UpdateAppleProductFields(string id, string originalTransactionId, bool isRestored);

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.AppleStoreImpl.<> <>9;
                static /*0x8*/ System.Comparison<UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt> <>9__39_1;
                static /*0x10*/ System.Func<System.Collections.Generic.KeyValuePair<string, object>, string> <>9__62_0;
                static /*0x18*/ System.Func<System.Collections.Generic.KeyValuePair<string, object>, string> <>9__62_1;

                static /*0x7f4311c*/ <>c();
                /*0x7f43184*/ <>c();
                /*0x7f4318c*/ int <FindMostRecentReceipt>b__39_1(UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt b, UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt a);
                /*0x7f43214*/ string <OnFetchStorePromotionVisibilitySucceeded>b__62_0(System.Collections.Generic.KeyValuePair<string, object> k);
                /*0x7f43250*/ string <OnFetchStorePromotionVisibilitySucceeded>b__62_1(System.Collections.Generic.KeyValuePair<string, object> k);
            }

            class <>c__DisplayClass39_0
            {
                /*0x10*/ string productId;

                /*0x7f410f4*/ <>c__DisplayClass39_0();
                /*0x7f4329c*/ bool <FindMostRecentReceipt>b__0(UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt r);
            }

            class <>c__DisplayClass64_0
            {
                /*0x10*/ string subject;
                /*0x18*/ string payload;
                /*0x20*/ string receipt;
                /*0x28*/ string transactionId;
                /*0x30*/ string originalTransactionId;
                /*0x38*/ bool isRestored;

                /*0x7f41ffc*/ <>c__DisplayClass64_0();
                /*0x7f432c0*/ void <MessageCallback>b__0();
            }
        }

        class FakeAppleConfiguration : UnityEngine.Purchasing.IAppleConfiguration, UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
            /*0x7f43334*/ FakeAppleConfiguration();
            /*0x7f4332c*/ bool get_canMakePayments();
        }

        class FakeAppleExtensions : UnityEngine.Purchasing.IAppleExtensions, UnityEngine.Purchasing.IStoreExtension
        {
            /*0x7f433a0*/ FakeAppleExtensions();
            /*0x7f4333c*/ void RestoreTransactions(System.Action<bool, string> callback);
            /*0x7f4335c*/ void RegisterPurchaseDeferredListener(System.Action<UnityEngine.Purchasing.Product> callback);
            /*0x7f43360*/ string GetTransactionReceiptForProduct(UnityEngine.Purchasing.Product product);
        }

        interface IAppleConfiguration : UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
            /*0x380b128*/ bool get_canMakePayments();
        }

        interface IAppleExtensions : UnityEngine.Purchasing.IStoreExtension
        {
            /*0x380bb68*/ string GetTransactionReceiptForProduct(UnityEngine.Purchasing.Product product);
            /*0x380d83c*/ void RestoreTransactions(System.Action<bool, string> callback);
            /*0x380d83c*/ void RegisterPurchaseDeferredListener(System.Action<UnityEngine.Purchasing.Product> callback);
        }

        enum AppleStorePromotionVisibility
        {
            Default = 0,
            Hide = 1,
            Show = 2,
        }

        class MetricizedAppleStoreImpl : UnityEngine.Purchasing.AppleStoreImpl
        {
            /*0xd0*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService m_TelemetryMetricsService;

            /*0x7f433a8*/ MetricizedAppleStoreImpl(Uniject.IUtil util, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics, UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService telemetryMetricsService);
            /*0x7f433d4*/ void RestoreTransactions(System.Action<bool, string> callback);
            /*0x7f4355c*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x7f436e4*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);
            /*0x7f43880*/ void <>n__4(System.Action<bool, string> callback);
            /*0x7f43884*/ void <>n__6(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x7f4393c*/ void <>n__7(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);

            class <>c__DisplayClass10_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedAppleStoreImpl <>4__this;
                /*0x18*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;

                /*0x7f436dc*/ <>c__DisplayClass10_0();
                /*0x7f43a10*/ void <RetrieveProducts>b__0();
            }

            class <>c__DisplayClass11_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedAppleStoreImpl <>4__this;
                /*0x18*/ UnityEngine.Purchasing.ProductDefinition product;
                /*0x20*/ string developerPayload;

                /*0x7f43878*/ <>c__DisplayClass11_0();
                /*0x7f43a30*/ void <Purchase>b__0();
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedAppleStoreImpl <>4__this;
                /*0x18*/ System.Action<bool, string> callback;

                /*0x7f43554*/ <>c__DisplayClass6_0();
                /*0x7f43a50*/ void <RestoreTransactions>b__0();
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

        interface INativeStoreProvider
        {
            UnityEngine.Purchasing.INativeStore GetAndroidStore(UnityEngine.Purchasing.IUnityCallback callback, UnityEngine.Purchasing.AppStore store, UnityEngine.Purchasing.Extension.IPurchasingBinder binder, Uniject.IUtil util);
            /*0x380bb68*/ UnityEngine.Purchasing.INativeAppleStore GetStorekit(UnityEngine.Purchasing.IUnityCallback callback);
        }

        interface IStoreInternal
        {
            /*0x380d83c*/ void SetModule(UnityEngine.Purchasing.StandardPurchasingModule module);
        }

        class JSONStore : UnityEngine.Purchasing.Extension.AbstractStore, UnityEngine.Purchasing.IUnityCallback, UnityEngine.Purchasing.IStoreInternal, UnityEngine.Purchasing.ITransactionHistoryExtensions, UnityEngine.Purchasing.IStoreExtension
        {
            /*0x10*/ UnityEngine.Purchasing.Extension.IStoreCallback unity;
            /*0x18*/ UnityEngine.Purchasing.INativeStore m_Store;
            /*0x20*/ UnityEngine.Purchasing.StandardPurchasingModule m_Module;
            /*0x28*/ UnityEngine.ILogger m_Logger;
            /*0x30*/ Stores.Util.JsonProductDescriptionsDeserializer m_ProductDescriptionsDeserializer;
            /*0x38*/ UnityEngine.Purchasing.Extension.PurchaseFailureDescription m_LastPurchaseFailureDescription;
            /*0x40*/ UnityEngine.Purchasing.StoreSpecificPurchaseErrorCode m_LastPurchaseErrorCode;

            /*0x7f3d92c*/ JSONStore();
            /*0x7f43a70*/ void SetNativeStore(UnityEngine.Purchasing.INativeStore native);
            /*0x7f43a78*/ void UnityEngine.Purchasing.IStoreInternal.SetModule(UnityEngine.Purchasing.StandardPurchasingModule module);
            /*0x7f43b38*/ void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback callback);
            /*0x7f43888*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x7f43940*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);
            /*0x7f42bb0*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId);
            /*0x7f4262c*/ void OnSetupFailed(string reason);
            /*0x7f43bc0*/ void OnProductsRetrieved(string json);
            /*0x7f42aec*/ void OnPurchaseSucceeded(string id, string receipt, string transactionID);
            /*0x7f42848*/ void OnPurchaseFailed(string json);
            /*0x7f43c80*/ void OnPurchaseFailed(UnityEngine.Purchasing.Extension.PurchaseFailureDescription failure, string json);
            /*0x7f43d54*/ UnityEngine.Purchasing.StoreSpecificPurchaseErrorCode ParseStoreSpecificPurchaseErrorCode(string json);
        }

        class MetricizedJsonStore : UnityEngine.Purchasing.JSONStore
        {
            /*0x48*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService m_TelemetryMetricsService;

            /*0x7f43f90*/ MetricizedJsonStore(UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService telemetryMetricsService);
            /*0x7f43fbc*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x7f44144*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);
            /*0x7f442e0*/ void <>n__0(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x7f442e4*/ void <>n__1(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedJsonStore <>4__this;
                /*0x18*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;

                /*0x7f4413c*/ <>c__DisplayClass2_0();
                /*0x7f442e8*/ void <RetrieveProducts>b__0();
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedJsonStore <>4__this;
                /*0x18*/ UnityEngine.Purchasing.ProductDefinition product;
                /*0x20*/ string developerPayload;

                /*0x7f442d8*/ <>c__DisplayClass3_0();
                /*0x7f44308*/ void <Purchase>b__0();
            }
        }

        class NativeStoreProvider : UnityEngine.Purchasing.INativeStoreProvider
        {
            /*0x7f44b28*/ NativeStoreProvider();
            /*0x7f44328*/ UnityEngine.Purchasing.INativeStore GetAndroidStore(UnityEngine.Purchasing.IUnityCallback callback, UnityEngine.Purchasing.AppStore store, UnityEngine.Purchasing.Extension.IPurchasingBinder binder, Uniject.IUtil util);
            /*0x7f44458*/ UnityEngine.Purchasing.INativeStore GetAndroidStoreHelper(UnityEngine.Purchasing.IUnityCallback callback, UnityEngine.Purchasing.AppStore store, UnityEngine.Purchasing.Extension.IPurchasingBinder binder, Uniject.IUtil util);
            /*0x7f44a54*/ UnityEngine.Purchasing.INativeAppleStore GetStorekit(UnityEngine.Purchasing.IUnityCallback callback);
        }

        class DialogRequest
        {
            /*0x10*/ string QueryText;
            /*0x18*/ string OkayButtonText;
            /*0x20*/ string CancelButtonText;
            /*0x28*/ System.Collections.Generic.List<string> Options;
            /*0x30*/ System.Action<bool, int> Callback;

            /*0x7f44b30*/ DialogRequest();
        }

        enum FakeStoreUIMode
        {
            Default = 0,
            StandardUser = 1,
            DeveloperUser = 2,
        }

        class FakeStore : UnityEngine.Purchasing.JSONStore, UnityEngine.Purchasing.IStoreExtension, UnityEngine.Purchasing.INativeStore
        {
            /*0x48*/ UnityEngine.Purchasing.Extension.IStoreCallback m_Biller;
            /*0x50*/ System.Collections.Generic.List<string> m_PurchasedProducts;
            /*0x58*/ bool purchaseCalled;
            /*0x60*/ string <unavailableProductId>k__BackingField;
            /*0x68*/ UnityEngine.Purchasing.FakeStoreUIMode UIMode;

            /*0x7f45f9c*/ FakeStore();
            /*0x7f44b38*/ string get_unavailableProductId();
            /*0x7f44b40*/ void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback biller);
            /*0x7f44b7c*/ void RetrieveProducts(string json);
            /*0x7f44c94*/ void StoreRetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> productDefinitions);
            /*0x7f45890*/ void Purchase(string productJSON, string developerPayload);
            /*0x7f45b44*/ void FakePurchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);
            /*0x7f45f94*/ void FinishTransaction(string productJSON, string transactionID);
            /*0x7f45f98*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId);
            bool StartUI<T>(object model, UnityEngine.Purchasing.FakeStore.DialogType dialogType, System.Action<bool, T> callback);
            /*0x7f46020*/ void <>n__0(string id, string receipt, string transactionID);

            enum DialogType
            {
                Purchase = 0,
                RetrieveProducts = 1,
            }

            class <>c__DisplayClass13_0
            {
                /*0x10*/ UnityEngine.Purchasing.FakeStore <>4__this;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products;

                /*0x7f45678*/ <>c__DisplayClass13_0();
                /*0x7f4574c*/ void <StoreRetrieveProducts>g__handleAllowInitializeOrRetrieveProducts|0(bool allow, UnityEngine.Purchasing.InitializationFailureReason failureReason);
            }

            class <>c__DisplayClass15_0
            {
                /*0x10*/ UnityEngine.Purchasing.FakeStore <>4__this;
                /*0x18*/ UnityEngine.Purchasing.ProductDefinition product;

                /*0x7f45dbc*/ <>c__DisplayClass15_0();
                /*0x7f45dc4*/ void <FakePurchase>g__handleAllowPurchase|0(bool allow, UnityEngine.Purchasing.PurchaseFailureReason failureReason);
            }
        }

        class LifecycleNotifier : UnityEngine.MonoBehaviour
        {
            /*0x20*/ System.Action OnDestroyCallback;

            /*0x7f46040*/ LifecycleNotifier();
            /*0x7f46024*/ void OnDestroy();
        }

        class UIFakeStore : UnityEngine.Purchasing.FakeStore
        {
            /*0x70*/ UnityEngine.Purchasing.DialogRequest m_CurrentDialog;
            /*0x78*/ int m_LastSelectedDropdownIndex;
            /*0x80*/ UnityEngine.GameObject m_UIFakeStoreWindowObject;
            /*0x88*/ UnityEngine.GameObject m_EventSystem;

            /*0x7f46048*/ UIFakeStore();
            bool StartUI<T>(object model, UnityEngine.Purchasing.FakeStore.DialogType dialogType, System.Action<bool, T> callback);
            /*0x7f4604c*/ bool StartUI(string queryText, string okayButtonText, string cancelButtonText, System.Collections.Generic.List<string> options, System.Action<bool, int> callback);
            /*0x7f46160*/ void InstantiateDialog();
            /*0x7f4624c*/ UnityEngine.Purchasing.UIFakeStoreWindow GetOrCreateFakeStoreWindow();
            /*0x7f463fc*/ void AddLifeCycleNotifierAndSetDestroyCallback(UnityEngine.GameObject gameObject);
            /*0x7f464b8*/ void EnsureEventSystemCreated(UnityEngine.Transform rootTransform);
            /*0x7f46558*/ void ConfigureDialogWindow(UnityEngine.Purchasing.UIFakeStoreWindow dialogWindow);
            /*0x7f46894*/ void ConfigureDialogWindowCallbacks(UnityEngine.Purchasing.UIFakeStoreWindow dialogWindow, bool assignCancelCallback, bool assignDropDownCallback);
            /*0x7f465cc*/ void CreateEventSystem(UnityEngine.Transform rootTransform);
            /*0x7f46a20*/ string CreatePurchaseQuestion(UnityEngine.Purchasing.ProductDefinition definition);
            /*0x7f46a8c*/ string CreateRetrieveProductsQuestion(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> definitions);
            /*0x7f46cb0*/ void OkayButtonClicked();
            /*0x7f46e04*/ void CancelButtonClicked();
            /*0x7f46e98*/ void DropdownValueChanged(int selectedItem);
            /*0x7f46d60*/ void CloseDialog();
            /*0x7f46150*/ bool IsShowingDialog();
            /*0x7f46ea0*/ void <AddLifeCycleNotifierAndSetDestroyCallback>b__14_0();

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.UIFakeStore.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.Purchasing.ProductDefinition, string> <>9__20_0;

                static /*0x7f46eac*/ <>c();
                /*0x7f46f14*/ <>c();
                /*0x7f46f1c*/ string <CreateRetrieveProductsQuestion>b__20_0(UnityEngine.Purchasing.ProductDefinition pid);
            }

            class <>c__DisplayClass10_0<T>
            {
                /*0x0*/ System.Action<bool, T> callback;

                /*0x380cb08*/ <>c__DisplayClass10_0();
                void <StartUI>b__0(bool result, int codeValue);
            }
        }

        class UIFakeStoreDropdown
        {
            /*0x10*/ System.Collections.Generic.List<string> m_Options;
            /*0x18*/ System.Action<int, string> m_OnDropdown;
            /*0x20*/ UnityEngine.Vector2 scrollPosition;

            /*0x7f472e4*/ UIFakeStoreDropdown();
            /*0x7f46f34*/ void DoPopup(int windowID);
            /*0x7f471d0*/ void OnOptionSelected(int optionIndex);
            /*0x7f47258*/ void SetOptions(System.Collections.Generic.List<string> options);
            /*0x7f472dc*/ void SetSelectionAction(System.Action<int, string> onDropdown);
        }

        class UIFakeStoreWindow : UnityEngine.MonoBehaviour
        {
            static float k_MenuScreenRatio = 0.6000000238418579;
            /*0x20*/ string m_QueryText;
            /*0x28*/ string m_OkText;
            /*0x30*/ string m_CancelText;
            /*0x38*/ string m_LastSelectedOptionText;
            /*0x40*/ System.Action m_OnOk;
            /*0x48*/ System.Action m_OnCancel;
            /*0x50*/ System.Action<int> m_OnDropdown;
            /*0x58*/ bool m_CancelEnabled;
            /*0x59*/ bool m_DropdownEnabled;
            /*0x5a*/ bool m_DoDropdown;
            /*0x60*/ UnityEngine.Purchasing.UIFakeStoreDropdown m_Dropdown;
            /*0x68*/ UnityEngine.Vector2 scrollPosition;

            /*0x7f47884*/ UIFakeStoreWindow();
            /*0x7f472ec*/ void OnGUI();
            /*0x7f47460*/ UnityEngine.Rect CreateCenteredWindowRect();
            /*0x7f474d4*/ void DoMainGUI(int windowID);
            /*0x7f477f0*/ void DoDropDown();
            /*0x7f477fc*/ void OnOkClicked();
            /*0x7f47818*/ void OnCancelClicked();
            /*0x7f46750*/ void ConfigureMainDialogText(string queryText, string okText, string cancelText);
            /*0x7f46794*/ void ConfigureDropdownOptions(System.Collections.Generic.List<string> options);
            /*0x7f47834*/ void OnDropdown(int index, string selectionText);
            /*0x7f469c4*/ void AssignCallbacks(System.Action onOk, System.Action onCancel, System.Action<int> onDropdown);
        }

        class Price : UnityEngine.ISerializationCallbackReceiver
        {
            /*0x10*/ decimal value;
            /*0x20*/ int[] data;
            /*0x28*/ double num;

            /*0x7f479e0*/ Price();
            /*0x7f478f0*/ void OnBeforeSerialize();
            /*0x7f47974*/ void OnAfterDeserialize();
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

            static /*0x7f479e8*/ string DecodeNonLatinCharacters(string s);
            /*0x7f47b30*/ LocalizedProductDescription();
            /*0x7f4573c*/ string get_Title();
            /*0x7f45744*/ string get_Description();

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.LocalizedProductDescription.<> <>9;
                static /*0x8*/ System.Text.RegularExpressions.MatchEvaluator <>9__11_0;

                static /*0x7f47b40*/ <>c();
                /*0x7f47ba8*/ <>c();
                /*0x7f47bb0*/ string <DecodeNonLatinCharacters>b__11_0(System.Text.RegularExpressions.Match m);
            }
        }

        class ProductCatalogPayout
        {
            /*0x10*/ string t;
            /*0x18*/ string st;
            /*0x20*/ string d;

            /*0x7f47c60*/ ProductCatalogPayout();

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

            /*0x7f47d18*/ ProductCatalogItem();
        }

        class ProductCatalog
        {
            static /*0x0*/ UnityEngine.Purchasing.IProductCatalogImpl instance;
            /*0x10*/ bool enableCodelessAutoInitialization;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Purchasing.ProductCatalogItem> products;

            static /*0x7f47ef4*/ void Initialize();
            static /*0x7f47fb4*/ void Initialize(UnityEngine.Purchasing.IProductCatalogImpl productCatalogImpl);
            static /*0x7f4800c*/ UnityEngine.Purchasing.ProductCatalog Deserialize(string catalogJSON);
            static /*0x7f48054*/ UnityEngine.Purchasing.ProductCatalog FromTextAsset(UnityEngine.TextAsset asset);
            static /*0x7f45680*/ UnityEngine.Purchasing.ProductCatalog LoadDefaultCatalog();
            /*0x7f48070*/ ProductCatalog();
            /*0x7f47eec*/ System.Collections.Generic.ICollection<UnityEngine.Purchasing.ProductCatalogItem> get_allProducts();
        }

        interface IProductCatalogImpl
        {
            /*0x380b9e8*/ UnityEngine.Purchasing.ProductCatalog LoadDefaultCatalog();
        }

        class ProductCatalogImpl : UnityEngine.Purchasing.IProductCatalogImpl
        {
            /*0x7f47fac*/ ProductCatalogImpl();
            /*0x7f48100*/ UnityEngine.Purchasing.ProductCatalog LoadDefaultCatalog();
        }

        class StandardPurchasingModule : UnityEngine.Purchasing.Extension.AbstractPurchasingModule, UnityEngine.Purchasing.IAndroidStoreSelection, UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
            static /*0x0*/ UnityEngine.Purchasing.StandardPurchasingModule ModuleInstance;
            static /*0x8*/ System.Collections.Generic.Dictionary<UnityEngine.Purchasing.AppStore, string> AndroidStoreNameMap;
            /*0x18*/ string k_Version;
            /*0x20*/ UnityEngine.Purchasing.INativeStoreProvider m_NativeStoreProvider;
            /*0x28*/ UnityEngine.RuntimePlatform m_RuntimePlatform;
            /*0x30*/ Uniject.IUtil <util>k__BackingField;
            /*0x38*/ UnityEngine.ILogger <logger>k__BackingField;
            /*0x40*/ UnityEngine.Purchasing.StandardPurchasingModule.StoreInstance <storeInstance>k__BackingField;
            /*0x48*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper <telemetryMetricsInstanceWrapper>k__BackingField;
            /*0x50*/ UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper <telemetryDiagnosticsInstanceWrapper>k__BackingField;
            /*0x58*/ UnityEngine.Purchasing.AppStore <appStore>k__BackingField;
            /*0x5c*/ UnityEngine.Purchasing.FakeStoreUIMode <useFakeStoreUIMode>k__BackingField;
            /*0x60*/ bool <useFakeStoreAlways>k__BackingField;
            /*0x68*/ UnityEngine.Purchasing.WinRTStore windowsStore;

            static /*0x7f4a178*/ StandardPurchasingModule();
            static /*0x7f48378*/ UnityEngine.Purchasing.StandardPurchasingModule Instance();
            static /*0x7f483c8*/ UnityEngine.Purchasing.StandardPurchasingModule Instance(UnityEngine.Purchasing.AppStore androidStore);
            static /*0x7f49e90*/ UnityEngine.Purchasing.GooglePlayConfiguration BuildGooglePlayStoreConfiguration(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback googlePurchaseCallback, UnityEngine.Purchasing.Interfaces.IGoogleProductCallback googleProductCallback);
            /*0x7f48254*/ StandardPurchasingModule(Uniject.IUtil util, UnityEngine.ILogger logger, UnityEngine.Purchasing.INativeStoreProvider nativeStoreProvider, UnityEngine.RuntimePlatform platform, UnityEngine.Purchasing.AppStore android, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper telemetryDiagnosticsInstanceWrapper, UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper);
            /*0x7f48204*/ Uniject.IUtil get_util();
            /*0x7f4820c*/ void set_util(Uniject.IUtil value);
            /*0x7f48214*/ UnityEngine.ILogger get_logger();
            /*0x7f4821c*/ void set_logger(UnityEngine.ILogger value);
            /*0x7f48224*/ UnityEngine.Purchasing.StandardPurchasingModule.StoreInstance get_storeInstance();
            /*0x7f4822c*/ void set_storeInstance(UnityEngine.Purchasing.StandardPurchasingModule.StoreInstance value);
            /*0x7f48234*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper get_telemetryMetricsInstanceWrapper();
            /*0x7f4823c*/ void set_telemetryMetricsInstanceWrapper(UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper value);
            /*0x7f48244*/ UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper get_telemetryDiagnosticsInstanceWrapper();
            /*0x7f4824c*/ void set_telemetryDiagnosticsInstanceWrapper(UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper value);
            /*0x7f48344*/ UnityEngine.Purchasing.AppStore get_appStore();
            /*0x7f4834c*/ void set_appStore(UnityEngine.Purchasing.AppStore value);
            /*0x7f48354*/ UnityEngine.Purchasing.FakeStoreUIMode get_useFakeStoreUIMode();
            /*0x7f4835c*/ void set_useFakeStoreUIMode(UnityEngine.Purchasing.FakeStoreUIMode value);
            /*0x7f48364*/ bool get_useFakeStoreAlways();
            /*0x7f4836c*/ void set_useFakeStoreAlways(bool value);
            /*0x7f4898c*/ void Configure();
            /*0x7f48f4c*/ UnityEngine.Purchasing.StandardPurchasingModule.StoreInstance InstantiateStore();
            /*0x7f494c0*/ UnityEngine.Purchasing.Extension.IStore InstantiateAndroid();
            /*0x7f496e8*/ UnityEngine.Purchasing.Extension.IStore InstantiateGoogleStore();
            /*0x7f4a058*/ void BindGoogleExtension(UnityEngine.Purchasing.GooglePlayStoreExtensions googlePlayStoreExtensions);
            /*0x7f4a000*/ void BindGoogleConfiguration(UnityEngine.Purchasing.GooglePlayConfiguration googlePlayConfiguration);
            /*0x7f49ae4*/ UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService BuildAndInitGooglePlayStoreServiceAar(UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback googlePurchaseCallback, UnityEngine.Purchasing.Interfaces.IGoogleProductCallback googleProductCallback, UnityEngine.Purchasing.Interfaces.IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider);
            /*0x7f493dc*/ UnityEngine.Purchasing.Extension.IStore InstantiateUDP();
            /*0x7f49ab4*/ UnityEngine.Purchasing.Extension.IStore InstantiateAndroidHelper(UnityEngine.Purchasing.JSONStore store);
            /*0x7f4a0b0*/ UnityEngine.Purchasing.INativeStore GetAndroidNativeStore(UnityEngine.Purchasing.JSONStore store);
            /*0x7f49248*/ UnityEngine.Purchasing.Extension.IStore InstantiateApple();
            /*0x7f49580*/ UnityEngine.Purchasing.Extension.IStore instantiateWindowsStore();
            /*0x7f4916c*/ UnityEngine.Purchasing.Extension.IStore InstantiateFakeStore();

            class StoreInstance
            {
                /*0x10*/ string <storeName>k__BackingField;
                /*0x18*/ UnityEngine.Purchasing.Extension.IStore <instance>k__BackingField;

                /*0x7f49204*/ StoreInstance(string name, UnityEngine.Purchasing.Extension.IStore instance);
                /*0x7f4a2a0*/ string get_storeName();
                /*0x7f4a2a8*/ UnityEngine.Purchasing.Extension.IStore get_instance();
            }

            class MicrosoftConfiguration : UnityEngine.Purchasing.IMicrosoftConfiguration, UnityEngine.Purchasing.Extension.IStoreConfiguration
            {
                /*0x10*/ UnityEngine.Purchasing.StandardPurchasingModule module;

                /*0x7f48f1c*/ MicrosoftConfiguration(UnityEngine.Purchasing.StandardPurchasingModule module);
            }
        }

        class StoreConfiguration
        {
            /*0x10*/ UnityEngine.Purchasing.AppStore <androidStore>k__BackingField;

            static /*0x7f48744*/ UnityEngine.Purchasing.StoreConfiguration Deserialize(string json);
            /*0x7f4a2c0*/ StoreConfiguration(UnityEngine.Purchasing.AppStore store);
            /*0x7f4a2b0*/ UnityEngine.Purchasing.AppStore get_androidStore();
            /*0x7f4a2b8*/ void set_androidStore(UnityEngine.Purchasing.AppStore value);
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

            /*0x7f4a2e8*/ TimeSpanUnits(double d, int m, int y);
        }

        class SubscriptionManager
        {
            /*0x10*/ string receipt;
            /*0x18*/ string productId;
            /*0x20*/ string intro_json;

            /*0x7f42de8*/ SubscriptionManager(UnityEngine.Purchasing.Product product, string intro_json);
            /*0x7f42e4c*/ UnityEngine.Purchasing.SubscriptionInfo getSubscriptionInfo();
            /*0x7f4ae10*/ UnityEngine.Purchasing.SubscriptionInfo getAmazonAppStoreSubInfo(string productId);
            /*0x7f4a97c*/ UnityEngine.Purchasing.SubscriptionInfo getAppleAppStoreSubInfo(string payload, string productId);
            /*0x7f4af2c*/ UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt findMostRecentReceipt(System.Collections.Generic.List<UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt> receipts);
            /*0x7f4a324*/ UnityEngine.Purchasing.SubscriptionInfo getGooglePlayStoreSubInfo(string payload);

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.SubscriptionManager.<> <>9;
                static /*0x8*/ System.Comparison<UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt> <>9__11_0;
                static /*0x10*/ System.Func<object, string> <>9__12_0;

                static /*0x7f4b894*/ <>c();
                /*0x7f4b8fc*/ <>c();
                /*0x7f4b904*/ int <findMostRecentReceipt>b__11_0(UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt b, UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt a);
                /*0x7f4b98c*/ string <getGooglePlayStoreSubInfo>b__12_0(object obj);
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

            /*0x7f407a4*/ SubscriptionInfo(UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt r, string intro_json);
            /*0x7f4b050*/ SubscriptionInfo(string skuDetails, bool isAutoRenewing, System.DateTime purchaseDate, bool isFreeTrial, bool hasIntroductoryPriceTrial, bool purchaseHistorySupported, string updateMetadata);
            /*0x7f4ae68*/ SubscriptionInfo(string productId);
            /*0x7f4c240*/ UnityEngine.Purchasing.Result isExpired();
            /*0x7f4c248*/ UnityEngine.Purchasing.Result isCancelled();
            /*0x7f4c250*/ System.DateTime getExpireDate();
            /*0x7f4c0fc*/ System.DateTime nextBillingDate(System.DateTime billing_begin_date, UnityEngine.Purchasing.TimeSpanUnits units);
            /*0x7f4bdf4*/ System.TimeSpan accumulateIntroductoryDuration(UnityEngine.Purchasing.TimeSpanUnits units, long cycles);
            /*0x7f4bbe4*/ System.TimeSpan computePeriodTimeSpan(UnityEngine.Purchasing.TimeSpanUnits units);
            /*0x7f4bea8*/ double computeExtraTime(string metadata, double new_sku_period_in_seconds);
            /*0x7f4bca0*/ System.TimeSpan parseTimeSpan(string period_string);
            /*0x7f4b9b4*/ UnityEngine.Purchasing.TimeSpanUnits parsePeriodTimeSpanUnits(string time_span);
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
            /*0x7f4c258*/ ReceiptParserException();
            /*0x7f4c2b0*/ ReceiptParserException(string message);
        }

        class InvalidProductTypeException : UnityEngine.Purchasing.ReceiptParserException
        {
            /*0x7f4c318*/ InvalidProductTypeException();
        }

        class NullProductIdException : UnityEngine.Purchasing.ReceiptParserException
        {
            /*0x7f4c31c*/ NullProductIdException();
        }

        class NullReceiptException : UnityEngine.Purchasing.ReceiptParserException
        {
            /*0x7f4c320*/ NullReceiptException();
        }

        class StoreSubscriptionInfoNotSupportedException : UnityEngine.Purchasing.ReceiptParserException
        {
            /*0x7f4c324*/ StoreSubscriptionInfoNotSupportedException(string message);
        }

        class FakeTransactionHistoryExtensions : UnityEngine.Purchasing.ITransactionHistoryExtensions, UnityEngine.Purchasing.IStoreExtension
        {
            /*0x7f4c328*/ FakeTransactionHistoryExtensions();
        }

        interface ITransactionHistoryExtensions : UnityEngine.Purchasing.IStoreExtension
        {
        }

        class EnumerableExtensions
        {
            static /*0x382eaf0*/ System.Collections.Generic.IEnumerable<T> NonNull<T>(System.Collections.Generic.IEnumerable<T> enumerable);
            static /*0x3830700*/ System.Collections.Generic.IEnumerable<T> IgnoreExceptions<T, TException>(System.Collections.Generic.IEnumerable<T> enumerable, System.Action<TException> onException);

            class <>c__0<T>
            {
                static /*0x0*/ UnityEngine.Purchasing.EnumerableExtensions.<>c__0<T> <>9;
                static /*0x0*/ System.Func<T, bool> <>9__0_0;

                static /*0x38358cc*/ <>c__0();
                /*0x380cb08*/ <>c__0();
                /*0x3907c14*/ bool <NonNull>b__0_0(T obj);
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

                /*0x380cffc*/ <IgnoreExceptions>d__1(int <>1__state);
                /*0x380cb08*/ void System.IDisposable.Dispose();
                /*0x380b128*/ bool MoveNext();
                /*0x380cb08*/ void <>m__Finally1();
                /*0x3907c14*/ T System.Collections.Generic.IEnumerator<T>.get_Current();
                /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
                /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                /*0x380b9e8*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class ExponentialRetryPolicy : UnityEngine.Purchasing.Stores.Util.IRetryPolicy
        {
            /*0x10*/ int m_BaseRetryDelay;
            /*0x14*/ int m_MaxRetryDelay;
            /*0x18*/ int m_ExponentialFactor;

            /*0x7f4c330*/ ExponentialRetryPolicy(int baseRetryDelay, int maxRetryDelay, int exponentialFactor);
            /*0x7f4c36c*/ void Invoke(System.Action<System.Action> actionToTry, System.Action onRetryAction);
            /*0x7f4c480*/ int AdjustDelay(int delay);

            class <>c__DisplayClass4_0
            {
                /*0x10*/ System.Action onRetryAction;
                /*0x18*/ int currentRetryDelay;
                /*0x20*/ UnityEngine.Purchasing.ExponentialRetryPolicy <>4__this;
                /*0x28*/ System.Action<System.Action> actionToTry;

                /*0x7f4c478*/ <>c__DisplayClass4_0();
                /*0x7f4c4ec*/ void <Invoke>g__Retry|0();
                /*0x7f4c5a0*/ System.Threading.Tasks.Task <Invoke>g__WaitAndRetry|1();

                struct <<Invoke>g__Retry|0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                    /*0x38*/ UnityEngine.Purchasing.ExponentialRetryPolicy.<> <>4__this;
                    /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                    /*0x7f4c684*/ void MoveNext();
                    /*0x7f4c828*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <<Invoke>g__WaitAndRetry|1>d : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ UnityEngine.Purchasing.ExponentialRetryPolicy.<> <>4__this;
                    /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                    /*0x7f4c834*/ void MoveNext();
                    /*0x7f4cae0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }
        }

        class GoogleConnectionRetryPolicy : UnityEngine.Purchasing.Stores.Util.IRetryPolicy
        {
            /*0x10*/ int m_BaseRetryDelay;
            /*0x14*/ int m_MaxRetryDelay;
            /*0x18*/ int m_ExponentialFactor;

            /*0x7f4cb48*/ GoogleConnectionRetryPolicy(int baseRetryDelay, int maxRetryDelay, int exponentialFactor);
            /*0x7f4cb84*/ void Invoke(System.Action<System.Action> actionToTry, System.Action onRetryAction);
            /*0x7f4ccec*/ int AdjustDelay(int delay);

            class <>c__DisplayClass4_0
            {
                /*0x10*/ int currentRetryDelay;
                /*0x18*/ UnityEngine.Purchasing.GoogleConnectionRetryPolicy <>4__this;
                /*0x20*/ System.Action<System.Action> actionToTry;
                /*0x28*/ System.Action onRetryAction;
                /*0x30*/ int retryAttempts;

                /*0x7f4cc30*/ <>c__DisplayClass4_0();
                /*0x7f4cc38*/ void <Invoke>g__WaitAndRetry|0();

                struct <<Invoke>g__WaitAndRetry|0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                    /*0x38*/ UnityEngine.Purchasing.GoogleConnectionRetryPolicy.<> <>4__this;
                    /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                    /*0x7f4cd58*/ void MoveNext();
                    /*0x7f4cfd4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }
        }

        class ProductDefinitionExtensions
        {
            static /*0x7f4cfe0*/ System.Collections.Generic.List<UnityEngine.Purchasing.ProductDefinition> DecodeJSON(System.Collections.Generic.List<object> productsList, string storeName);
        }

        class FakeMicrosoftExtensions : UnityEngine.Purchasing.IMicrosoftExtensions, UnityEngine.Purchasing.IStoreExtension
        {
            /*0x7f4d730*/ FakeMicrosoftExtensions();
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

            /*0x7f4d738*/ WinRTStore(UnityEngine.Purchasing.Default.IWindowsIAP win8, Uniject.IUtil util, UnityEngine.ILogger logger);
            /*0x7f4d798*/ void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback biller);
            /*0x7f4d7a0*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> productDefs);
            /*0x7f4db18*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId);
            /*0x7f4da08*/ void init(int delay);
            /*0x7f4dbc4*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);
            /*0x7f4dc78*/ void restoreTransactions(bool pausing);

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.WinRTStore.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.Purchasing.ProductDefinition, bool> <>9__8_0;
                static /*0x10*/ System.Func<UnityEngine.Purchasing.ProductDefinition, UnityEngine.Purchasing.Default.WinProductDescription> <>9__8_1;

                static /*0x7f4dd3c*/ <>c();
                /*0x7f4dda4*/ <>c();
                /*0x7f4ddac*/ bool <RetrieveProducts>b__8_0(UnityEngine.Purchasing.ProductDefinition def);
                /*0x7f4ddcc*/ UnityEngine.Purchasing.Default.WinProductDescription <RetrieveProducts>b__8_1(UnityEngine.Purchasing.ProductDefinition def);
            }
        }

        namespace Extension
        {
            class UnityUtil : UnityEngine.MonoBehaviour, Uniject.IUtil
            {
                static /*0x0*/ System.Collections.Generic.List<System.Action> s_Callbacks;
                static /*0x8*/ bool s_CallbacksPending;
                static /*0x10*/ System.Collections.Generic.List<UnityEngine.RuntimePlatform> s_PcControlledPlatforms;
                /*0x20*/ System.Collections.Generic.List<System.Action<bool>> pauseListeners;

                static /*0x7f4ec68*/ UnityUtil();
                static /*0x3907c14*/ T FindInstanceOfType<T>();
                static /*0x3907c14*/ T LoadResourceInstanceOfType<T>();
                static /*0x7f4e5dc*/ bool PcPlatform();
                /*0x7f4ebe0*/ UnityUtil();
                /*0x380b9e8*/ T[] GetAnyComponentsOfType<T>();
                /*0x7f4df3c*/ System.DateTime get_currentTime();
                /*0x7f4df8c*/ string get_persistentDataPath();
                /*0x7f4dfdc*/ string get_deviceUniqueIdentifier();
                /*0x7f4dfe4*/ string get_unityVersion();
                /*0x7f4e034*/ string get_cloudProjectId();
                /*0x7f4e084*/ string get_userId();
                /*0x7f4e0dc*/ string get_gameVersion();
                /*0x7f4e12c*/ ulong get_sessionId();
                /*0x7f4e190*/ UnityEngine.RuntimePlatform get_platform();
                /*0x7f4e1e0*/ bool get_isEditor();
                /*0x7f4e230*/ string get_deviceModel();
                /*0x7f4e238*/ string get_deviceName();
                /*0x7f4e240*/ UnityEngine.DeviceType get_deviceType();
                /*0x7f4e248*/ string get_operatingSystem();
                /*0x7f4e250*/ int get_screenWidth();
                /*0x7f4e258*/ int get_screenHeight();
                /*0x7f4e260*/ float get_screenDpi();
                /*0x7f4e268*/ string get_screenOrientation();
                /*0x7f4e2d0*/ object Uniject.IUtil.InitiateCoroutine(System.Collections.IEnumerator start);
                /*0x7f4e2d8*/ void Uniject.IUtil.InitiateCoroutine(System.Collections.IEnumerator start, int delay);
                /*0x7f4e36c*/ void RunOnMainThread(System.Action runnable);
                /*0x7f4e514*/ object GetWaitForSeconds(int seconds);
                /*0x7f4e570*/ void Start();
                /*0x7f4e2dc*/ System.Collections.IEnumerator DelayedCoroutine(System.Collections.IEnumerator coroutine, int delay);
                /*0x7f4e6b4*/ void Update();
                /*0x7f4e964*/ void AddPauseListener(System.Action<bool> runnable);
                /*0x7f4ea10*/ void OnApplicationPause(bool paused);
                /*0x7f4eb70*/ bool IsClassOrSubclass(System.Type potentialBase, System.Type potentialDescendant);

                class <DelayedCoroutine>d__48 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ int delay;
                    /*0x28*/ UnityEngine.Purchasing.Extension.UnityUtil <>4__this;
                    /*0x30*/ System.Collections.IEnumerator coroutine;

                    /*0x7f4e68c*/ <DelayedCoroutine>d__48(int <>1__state);
                    /*0x7f4ef58*/ void System.IDisposable.Dispose();
                    /*0x7f4ef5c*/ bool MoveNext();
                    /*0x7f4f018*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x7f4f020*/ void System.Collections.IEnumerator.Reset();
                    /*0x7f4f058*/ object System.Collections.IEnumerator.get_Current();
                }
            }
        }

        namespace Stores
        {
            namespace Util
            {
                interface IRetryPolicy
                {
                    /*0x380d93c*/ void Invoke(System.Action<System.Action> actionToTry, System.Action onRetryAction);
                }
            }
        }

        namespace Registration
        {
            class IapCoreInitializeCallback : Unity.Services.Core.Internal.IInitializablePackage
            {
                static /*0x7f4f060*/ void Register();
                static /*0x7f4f404*/ void CacheInitializedEnvironment(Unity.Services.Core.Internal.CoreRegistry registry);
                static /*0x7f4f430*/ string GetCurrentEnvironment(Unity.Services.Core.Internal.CoreRegistry registry);
                static /*0x7f4f578*/ void InitializeTelemetryComponents(UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper metricsInstanceWrapper, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper diagnosticsInstanceWrapper);
                /*0x7f4f19c*/ IapCoreInitializeCallback();
                /*0x7f4f1a4*/ System.Threading.Tasks.Task Initialize(Unity.Services.Core.Internal.CoreRegistry registry);

                class <>c__DisplayClass2_0
                {
                    /*0x10*/ Unity.Services.Core.Internal.CoreRegistry registry;
                    /*0x18*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper metricsInstanceWrapper;
                    /*0x20*/ UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper diagnosticsInstanceWrapper;

                    /*0x7f4f3fc*/ <>c__DisplayClass2_0();
                    /*0x7f4f850*/ void <Initialize>b__0();
                }
            }
        }

        namespace Utils
        {
            class GooglePurchaseBuilder : UnityEngine.Purchasing.Interfaces.IGooglePurchaseBuilder
            {
                /*0x10*/ UnityEngine.Purchasing.IGoogleCachedQueryProductDetailsService m_CachedQueryProductDetailsService;
                /*0x18*/ UnityEngine.ILogger m_Logger;

                static /*0x7f4fff8*/ System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> TryFindAllProductDetails(System.Collections.Generic.IEnumerable<string> skus, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails);
                /*0x7f4f86c*/ GooglePurchaseBuilder(UnityEngine.Purchasing.IGoogleCachedQueryProductDetailsService cachedQueryProductDetailsService, UnityEngine.ILogger logger);
                /*0x7f4f8b0*/ System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> BuildPurchases(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> purchases);
                /*0x7f4f9e0*/ void LogWarningForException(System.Exception exception);
                /*0x7f4fa18*/ UnityEngine.Purchasing.Interfaces.IGooglePurchase BuildPurchase(UnityEngine.AndroidJavaObject purchase);

                class <>c__DisplayClass6_0
                {
                    /*0x10*/ System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails;

                    /*0x7f50988*/ <>c__DisplayClass6_0();
                    /*0x7f50990*/ UnityEngine.AndroidJavaObject <TryFindAllProductDetails>b__0(string sku);
                }

                class <>c__DisplayClass6_1
                {
                    /*0x10*/ string sku;

                    /*0x7f50a78*/ <>c__DisplayClass6_1();
                    /*0x7f50a80*/ bool <TryFindAllProductDetails>b__1(UnityEngine.AndroidJavaObject productDetail);
                }
            }

            class GoogleReceiptEncoder
            {
                static /*0x7f50b6c*/ string EncodeReceipt(string purchaseOriginalJson, string purchaseSignature, System.Collections.Generic.List<string> productDetailsJson);
            }

            class ProductDetailsConverter : UnityEngine.Purchasing.Interfaces.IProductDetailsConverter
            {
                static /*0x7f50d44*/ UnityEngine.Purchasing.Extension.ProductDescription ToProductDescription(UnityEngine.AndroidJavaObject productDetails);
                static /*0x7f50de8*/ UnityEngine.Purchasing.Extension.ProductDescription BuildProductDescription(UnityEngine.AndroidJavaObject productDetails);
                /*0x7f52788*/ ProductDetailsConverter();
                /*0x7f50c88*/ System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> ConvertOnQueryProductDetailsResponse(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails);
            }
        }

        namespace Interfaces
        {
            interface IBillingClientStateListener
            {
                /*0x380d83c*/ void RegisterOnConnected(System.Action onConnected);
                /*0x380d83c*/ void RegisterOnDisconnected(System.Action<UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onDisconnected);
            }

            interface IGoogleBillingClient
            {
                /*0x380d83c*/ void StartConnection(UnityEngine.Purchasing.Interfaces.IBillingClientStateListener billingClientStateListener);
                /*0x380b6a0*/ UnityEngine.Purchasing.GoogleBillingConnectionState GetConnectionState();
                /*0x380d93c*/ void QueryPurchasesAsync(string skuType, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> onQueryPurchasesResponse);
                /*0x380da4c*/ void QueryProductDetailsAsync(System.Collections.Generic.List<string> skus, string type, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onProductDetailsResponseAction);
                UnityEngine.AndroidJavaObject LaunchBillingFlow(UnityEngine.AndroidJavaObject productDetails, string oldPurchaseToken, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> prorationMode);
                /*0x380d93c*/ void ConsumeAsync(string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onConsume);
                /*0x380d93c*/ void AcknowledgePurchase(string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onAcknowledge);
            }

            interface IGoogleFinishTransactionService
            {
                /*0x380da4c*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished);
            }

            interface IGoogleLastKnownProductService
            {
                /*0x380b9e8*/ string get_LastKnownOldProductId();
                /*0x380d83c*/ void set_LastKnownOldProductId(string value);
                /*0x380b9e8*/ string get_LastKnownProductId();
                /*0x380d83c*/ void set_LastKnownProductId(string value);
                /*0x380a988*/ System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> get_LastKnownProrationMode();
                /*0x380cc30*/ void set_LastKnownProrationMode(System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> value);
            }

            interface IGooglePlayStoreService
            {
                /*0x380da4c*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason, UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductFailed);
                /*0x380d83c*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product);
                /*0x380da4c*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished);
                /*0x380d83c*/ void FetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed);
                /*0x380bcbc*/ UnityEngine.Purchasing.Interfaces.IGooglePurchase GetPurchase(string purchaseToken, string skuType);
                /*0x380cb08*/ void ResumeConnection();
            }

            interface IGoogleProductCallback
            {
                /*0x380d83c*/ void SetStoreConfiguration(UnityEngine.Purchasing.IGooglePlayConfigurationInternal configuration);
                /*0x380cffc*/ void NotifyQueryProductDetailsFailed(int retryCount);
            }

            interface IGooglePurchase
            {
                /*0x380b6a0*/ int get_purchaseState();
                /*0x380b9e8*/ System.Collections.Generic.List<string> get_skus();
                /*0x380b9e8*/ string get_receipt();
                /*0x380b9e8*/ string get_purchaseToken();
                /*0x380b9e8*/ string get_sku();
                /*0x380b128*/ bool IsAcknowledged();
                /*0x380b128*/ bool IsPurchased();
                /*0x380b128*/ bool IsPending();
            }

            interface IGooglePurchaseBuilder
            {
                /*0x380bb68*/ System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> BuildPurchases(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> purchases);
                /*0x380bb68*/ UnityEngine.Purchasing.Interfaces.IGooglePurchase BuildPurchase(UnityEngine.AndroidJavaObject purchase);
            }

            interface IGooglePurchaseCallback
            {
                /*0x380d83c*/ void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
                /*0x380d83c*/ void SetStoreConfiguration(UnityEngine.Purchasing.IGooglePlayConfigurationInternal configuration);
                /*0x380da4c*/ void OnPurchaseSuccessful(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, string receipt, string purchaseToken);
                /*0x380d83c*/ void OnPurchaseFailed(UnityEngine.Purchasing.Extension.PurchaseFailureDescription purchaseFailureDescription);
                /*0x380da4c*/ void NotifyDeferredPurchase(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, string receipt, string purchaseToken);
                /*0x380d83c*/ void NotifyDeferredProrationUpgradeDowngradeSubscription(string sku);
            }

            interface IGooglePurchaseService
            {
                void Purchase(UnityEngine.Purchasing.ProductDefinition product, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode);
            }

            interface IGooglePurchaseStateEnumProvider
            {
                /*0x380b6a0*/ int Purchased();
                /*0x380b6a0*/ int Pending();
            }

            interface IGooglePurchaseUpdatedListener
            {
            }

            interface IGoogleQueryPurchasesService
            {
                /*0x380b9e8*/ System.Threading.Tasks.Task<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> QueryPurchases();
                /*0x380bcbc*/ UnityEngine.Purchasing.Interfaces.IGooglePurchase GetPurchaseByToken(string token, string skuType);
            }

            interface IProductDetailsConverter
            {
                /*0x380bb68*/ System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> ConvertOnQueryProductDetailsResponse(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails);
            }

            interface IProductDetailsResponseConsolidator
            {
                /*0x380d93c*/ void Consolidate(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails);
            }

            interface IQueryProductDetailsService
            {
                /*0x380d93c*/ void QueryAsyncProduct(UnityEngine.Purchasing.ProductDefinition product, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse);
                /*0x380d93c*/ void QueryAsyncProduct(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse);
            }

            interface IProductDetailsQueryResponse
            {
                /*0x380d93c*/ void AddResponse(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails);
                /*0x380b9e8*/ System.Collections.Generic.List<UnityEngine.AndroidJavaObject> ProductDetails();
                /*0x380b128*/ bool IsRecoverable();
                /*0x380b9e8*/ UnityEngine.Purchasing.Models.IGoogleBillingResult GetGoogleBillingResult();
            }
        }

        namespace Models
        {
            class AndroidJavaObjectExtensions
            {
                static /*0x382eaf0*/ System.Collections.Generic.IEnumerable<T> Enumerate<T>(UnityEngine.AndroidJavaObject androidJavaList);
                static /*0x7f52740*/ System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> Enumerate(UnityEngine.AndroidJavaObject androidJavaList);

                class <>c__DisplayClass0_0<T>
                {
                    /*0x0*/ UnityEngine.AndroidJavaObject androidJavaList;

                    /*0x380cb08*/ <>c__DisplayClass0_0();
                    /*0x3907c14*/ T <Enumerate>b__0(int i);
                }
            }

            interface IGoogleBillingResult
            {
                /*0x380b6a0*/ UnityEngine.Purchasing.Models.GoogleBillingResponseCode get_responseCode();
                /*0x380b9e8*/ string get_debugMessage();
            }

            class GoogleBillingClient : UnityEngine.Purchasing.Interfaces.IGoogleBillingClient
            {
                static /*0x0*/ UnityEngine.AndroidJavaClass s_AndroidProductClassName;
                static /*0x8*/ UnityEngine.AndroidJavaClass s_AndroidQueryProductDetailsParamsClassName;
                static /*0x10*/ UnityEngine.AndroidJavaClass s_BillingFlowParamsClass;
                static /*0x18*/ UnityEngine.AndroidJavaClass s_ProductDetailsParamsClass;
                static /*0x20*/ UnityEngine.AndroidJavaClass s_SubscriptionUpdateParamsClass;
                static /*0x28*/ UnityEngine.AndroidJavaClass s_ConsumeParamsClass;
                static /*0x30*/ UnityEngine.AndroidJavaClass s_AcknowledgePurchaseParamsClass;
                static /*0x38*/ UnityEngine.AndroidJavaClass s_BillingClientClass;
                /*0x10*/ UnityEngine.AndroidJavaObject m_BillingClient;
                /*0x18*/ string m_ObfuscatedAccountId;
                /*0x20*/ string m_ObfuscatedProfileId;
                /*0x28*/ Uniject.IUtil m_Util;
                /*0x30*/ UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics;

                static /*0x7f52790*/ UnityEngine.AndroidJavaClass GetProductParamsClass();
                static /*0x7f52844*/ UnityEngine.AndroidJavaClass GetQueryProductDetailsParamsParamsClass();
                static /*0x7f528f0*/ UnityEngine.AndroidJavaClass GetBillingFlowParamClass();
                static /*0x7f5299c*/ UnityEngine.AndroidJavaClass GetProductDetailsParamsClass();
                static /*0x7f52a48*/ UnityEngine.AndroidJavaClass GetSubscriptionUpdateParamClass();
                static /*0x7f52af4*/ UnityEngine.AndroidJavaClass GetConsumeParamsClass();
                static /*0x7f52ba0*/ UnityEngine.AndroidJavaClass GetAcknowledgePurchaseParamsClass();
                static /*0x7f52c4c*/ UnityEngine.AndroidJavaClass GetBillingClientClass();
                static /*0x7f536c0*/ UnityEngine.AndroidJavaObject QueryProductDetailsParams(System.Collections.Generic.List<string> products, string type);
                static /*0x7f53b58*/ UnityEngine.AndroidJavaObject QueryProductDetailsParamsProductList(System.Collections.Generic.List<string> products, string type);
                static /*0x7f53c84*/ UnityEngine.AndroidJavaObject QueryProductDetailsParamsProduct(string type, string product);
                static /*0x7f54f60*/ UnityEngine.AndroidJavaObject BuildSubscriptionUpdateParams(string oldPurchaseToken, UnityEngine.Purchasing.GooglePlayProrationMode prorationMode);
                /*0x7f52cf8*/ GoogleBillingClient(UnityEngine.Purchasing.Interfaces.IGooglePurchaseUpdatedListener googlePurchaseUpdatedListener, Uniject.IUtil util, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics);
                /*0x7f53138*/ void StartConnection(UnityEngine.Purchasing.Interfaces.IBillingClientStateListener billingClientStateListener);
                /*0x7f53208*/ UnityEngine.Purchasing.GoogleBillingConnectionState GetConnectionState();
                /*0x7f532d8*/ void QueryPurchasesAsync(string skuType, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> onQueryPurchasesResponse);
                /*0x7f53414*/ void QueryProductDetailsAsync(System.Collections.Generic.List<string> products, string type, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onProductDetailsResponseAction);
                /*0x7f5408c*/ UnityEngine.AndroidJavaObject LaunchBillingFlow(UnityEngine.AndroidJavaObject productDetails, string oldPurchaseToken, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> prorationMode);
                /*0x7f54a74*/ UnityEngine.AndroidJavaObject MakeBillingFlowParams(UnityEngine.AndroidJavaObject productDetailsParamsList, string oldPurchaseToken, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> prorationMode);
                /*0x7f54e6c*/ UnityEngine.AndroidJavaObject SetObfuscatedProfileIdIfNeeded(UnityEngine.AndroidJavaObject billingFlowParams);
                /*0x7f54d78*/ UnityEngine.AndroidJavaObject SetObfuscatedAccountIdIfNeeded(UnityEngine.AndroidJavaObject billingFlowParams);
                /*0x7f55214*/ void ConsumeAsync(string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onConsume);
                /*0x7f55798*/ void AcknowledgePurchase(string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onAcknowledge);

                class <>c__DisplayClass39_0
                {
                    /*0x10*/ string type;

                    /*0x7f53c7c*/ <>c__DisplayClass39_0();
                    /*0x7f55d1c*/ UnityEngine.AndroidJavaObject <QueryProductDetailsParamsProductList>b__0(string product);
                }
            }

            class GoogleBillingResult : UnityEngine.Purchasing.Models.IGoogleBillingResult
            {
                /*0x10*/ UnityEngine.Purchasing.Models.GoogleBillingResponseCode <responseCode>k__BackingField;
                /*0x18*/ string <debugMessage>k__BackingField;

                /*0x7f55d34*/ GoogleBillingResult(UnityEngine.AndroidJavaObject billingResult);
                /*0x7f55d24*/ UnityEngine.Purchasing.Models.GoogleBillingResponseCode get_responseCode();
                /*0x7f55d2c*/ string get_debugMessage();
            }

            class GoogleBillingStrings
            {
                static /*0x7f55ec0*/ string getWarningMessageMoreThanOneSkuFound(string sku);
            }

            class GoogleProductTypeEnum
            {
                static /*0x7f55f2c*/ string InApp();
                static /*0x7f55f6c*/ string Sub();
            }

            class GooglePurchase : UnityEngine.Purchasing.Interfaces.IGooglePurchase
            {
                /*0x10*/ bool <isAcknowledged>k__BackingField;
                /*0x14*/ int <purchaseState>k__BackingField;
                /*0x18*/ System.Collections.Generic.List<string> <skus>k__BackingField;
                /*0x20*/ string <orderId>k__BackingField;
                /*0x28*/ string <receipt>k__BackingField;
                /*0x30*/ string <signature>k__BackingField;
                /*0x38*/ string <originalJson>k__BackingField;
                /*0x40*/ string <purchaseToken>k__BackingField;
                /*0x48*/ string <obfuscatedAccountId>k__BackingField;
                /*0x50*/ string <obfuscatedProfileId>k__BackingField;

                /*0x7f500dc*/ GooglePurchase(UnityEngine.AndroidJavaObject purchase, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetailsEnum);
                /*0x7f55fac*/ bool get_isAcknowledged();
                /*0x7f55fb4*/ int get_purchaseState();
                /*0x7f55fbc*/ System.Collections.Generic.List<string> get_skus();
                /*0x7f55fc4*/ string get_receipt();
                /*0x7f55fcc*/ string get_signature();
                /*0x7f55fd4*/ string get_originalJson();
                /*0x7f55fdc*/ string get_purchaseToken();
                /*0x7f55fe4*/ string get_sku();
                /*0x7f5602c*/ bool IsAcknowledged();
                /*0x7f56034*/ bool IsPurchased();
                /*0x7f56284*/ bool IsPending();

                class <>c
                {
                    static /*0x0*/ UnityEngine.Purchasing.Models.GooglePurchase.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.AndroidJavaObject, string> <>9__32_0;

                    static /*0x7f564d8*/ <>c();
                    /*0x7f56540*/ <>c();
                    /*0x7f56548*/ string <.ctor>b__32_0(UnityEngine.AndroidJavaObject productDetails);
                }
            }

            class GooglePurchaseStateEnum
            {
                static /*0x0*/ System.Nullable<int> s_Purchased;
                static /*0x8*/ System.Nullable<int> s_Pending;

                static /*0x7f56578*/ UnityEngine.AndroidJavaObject GetPurchaseStateJavaObject();
                static /*0x7f56050*/ int Purchased();
                static /*0x7f562a0*/ int Pending();
            }

            class GooglePurchaseStateEnumProvider : UnityEngine.Purchasing.Interfaces.IGooglePurchaseStateEnumProvider
            {
                /*0x7f565ec*/ GooglePurchaseStateEnumProvider();
                /*0x7f565e4*/ int Purchased();
                /*0x7f565e8*/ int Pending();
            }

            enum GoogleRetrieveProductsFailureReason
            {
                BillingServiceDisconnected = 0,
                BillingServiceUnavailable = 1,
            }

            class ProductDescriptionQuery
            {
                /*0x10*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;
                /*0x18*/ System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived;
                /*0x20*/ System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason, UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed;

                /*0x7f565f4*/ ProductDescriptionQuery(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason, UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed);
            }

            enum GoogleBillingResponseCode
            {
                ServiceTimeout = -3,
                FeatureNotSupported = -2,
                ServiceDisconnected = -1,
                Ok = 0,
                UserCanceled = 1,
                ServiceUnavailable = 2,
                BillingUnavailable = 3,
                ItemUnavailable = 4,
                DeveloperError = 5,
                FatalError = 6,
                ItemAlreadyOwned = 7,
                ItemNotOwned = 8,
                NetworkError = 12,
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x7f56654*/ uint ComputeStringHash(string s);
}
