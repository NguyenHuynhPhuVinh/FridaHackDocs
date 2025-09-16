class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x7f3f30c*/ EmbeddedAttribute();
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

                /*0x7f3f314*/ NullableAttribute(byte );
                /*0x7f3f39c*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x7f3f3cc*/ NullableContextAttribute(byte );
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
            /*0x7f3fb7c*/ JsonProductDescriptionsDeserializer();
            /*0x7f3f3f4*/ System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> DeserializeProductDescriptions(string json);
            /*0x7f3f908*/ UnityEngine.Purchasing.ProductMetadata DeserializeMetadata(System.Collections.Generic.Dictionary<string, object> data);
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

            /*0x7f3fb84*/ AmazonAppStoreStoreExtensions(UnityEngine.AndroidJavaObject a);
        }

        class FakeAmazonExtensions : UnityEngine.Purchasing.IAmazonExtensions, UnityEngine.Purchasing.IStoreExtension, UnityEngine.Purchasing.IAmazonConfiguration, UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
            /*0x7f3fbb4*/ FakeAmazonExtensions();
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

            /*0x7f3fbbc*/ AndroidJavaStore(UnityEngine.AndroidJavaObject store);
            /*0x7f3fbec*/ void RetrieveProducts(string json);
            /*0x7f3fcbc*/ void Purchase(string productJSON, string developerPayload);
            /*0x7f3fdc4*/ void FinishTransaction(string productJSON, string transactionID);
        }

        class ListExtension
        {
            static /*0x38379c4*/ UnityEngine.AndroidJavaObject ToJava<T>(System.Collections.Generic.List<T> values);
            static /*0x38379c4*/ UnityEngine.AndroidJavaObject ToJavaArray<T>(System.Collections.Generic.List<T> values);
        }

        class UnityActivity
        {
            static /*0x0*/ UnityEngine.AndroidJavaClass s_UnityPlayerClass;

            static /*0x7f3fecc*/ UnityEngine.AndroidJavaClass GetUnityPlayerClass();
            static /*0x7f3ff80*/ UnityEngine.AndroidJavaObject GetCurrentActivity();
        }

        class GoogleCachedQueryProductDetailsService : UnityEngine.Purchasing.IGoogleCachedQueryProductDetailsService
        {
            /*0x10*/ System.Collections.Generic.Dictionary<string, UnityEngine.AndroidJavaObject> m_CachedQueriedProductDetails;

            /*0x7f40880*/ GoogleCachedQueryProductDetailsService();
            /*0x7f3ffdc*/ void Finalize();
            /*0x7f401b4*/ System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedProducts();
            /*0x7f40204*/ UnityEngine.AndroidJavaObject GetCachedQueriedProductDetails(string productId);
            /*0x7f4025c*/ System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedProductDetails(System.Collections.Generic.IEnumerable<string> productIds);
            /*0x7f40300*/ System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedProductDetails(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x7f40434*/ bool Contains(string productId);
            /*0x7f4048c*/ bool Contains(UnityEngine.Purchasing.ProductDefinition products);
            /*0x7f404a4*/ void AddCachedQueriedProductDetails(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> queriedProducts);

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.GoogleCachedQueryProductDetailsService.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.Purchasing.ProductDefinition, string> <>9__5_0;

                static /*0x7f40908*/ <>c();
                /*0x7f40970*/ <>c();
                /*0x7f40978*/ string <GetCachedQueriedProductDetails>b__5_0(UnityEngine.Purchasing.ProductDefinition product);
            }
        }

        class GoogleFinishTransactionService : UnityEngine.Purchasing.Interfaces.IGoogleFinishTransactionService
        {
            /*0x10*/ UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient;
            /*0x18*/ UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService m_GoogleQueryPurchasesService;

            /*0x7f40990*/ GoogleFinishTransactionService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService googleQueryPurchasesService);
            /*0x7f409d4*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished);
            /*0x7f40adc*/ System.Threading.Tasks.Task<UnityEngine.Purchasing.Interfaces.IGooglePurchase> FindPurchase(string purchaseToken);
            /*0x7f40bf4*/ void FinishTransactionForPurchase(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, UnityEngine.Purchasing.ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished);

            class <>c__DisplayClass4_0
            {
                /*0x10*/ string purchaseToken;

                /*0x7f40e84*/ <>c__DisplayClass4_0();
                /*0x7f40e8c*/ bool <FindPurchase>b__0(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase);
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished;
                /*0x18*/ UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase;

                /*0x7f40e7c*/ <>c__DisplayClass5_0();
                /*0x7f40f3c*/ void <FinishTransactionForPurchase>b__0(UnityEngine.Purchasing.Models.IGoogleBillingResult result);
                /*0x7f40f64*/ void <FinishTransactionForPurchase>b__1(UnityEngine.Purchasing.Models.IGoogleBillingResult result);
            }

            struct <FindPurchase>d__4 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<UnityEngine.Purchasing.Interfaces.IGooglePurchase> <>t__builder;
                /*0x30*/ string purchaseToken;
                /*0x38*/ UnityEngine.Purchasing.GoogleFinishTransactionService <>4__this;
                /*0x40*/ UnityEngine.Purchasing.GoogleFinishTransactionService.<> <>8__1;
                /*0x48*/ System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>u__1;

                /*0x7f40f8c*/ void MoveNext();
                /*0x7f41368*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x7f413e4*/ void MoveNext();
                /*0x7f416dc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class GoogleLastKnownProductService : UnityEngine.Purchasing.Interfaces.IGoogleLastKnownProductService
        {
            /*0x10*/ string <LastKnownOldProductId>k__BackingField;
            /*0x18*/ string <LastKnownProductId>k__BackingField;
            /*0x20*/ System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> <LastKnownProrationMode>k__BackingField;

            /*0x7f41718*/ GoogleLastKnownProductService();
            /*0x7f416e8*/ string get_LastKnownOldProductId();
            /*0x7f416f0*/ void set_LastKnownOldProductId(string value);
            /*0x7f416f8*/ string get_LastKnownProductId();
            /*0x7f41700*/ void set_LastKnownProductId(string value);
            /*0x7f41708*/ System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> get_LastKnownProrationMode();
            /*0x7f41710*/ void set_LastKnownProrationMode(System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> value);
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

            /*0x7f41788*/ GooglePlayStoreService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, UnityEngine.Purchasing.Interfaces.IQueryProductDetailsService queryProductDetailsService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseService purchaseService, UnityEngine.Purchasing.Interfaces.IGoogleFinishTransactionService finishTransactionService, UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService queryPurchasesService, UnityEngine.Purchasing.Interfaces.IBillingClientStateListener billingClientStateListener, UnityEngine.Purchasing.Interfaces.IGoogleLastKnownProductService lastKnownProductService, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics, UnityEngine.ILogger logger, UnityEngine.Purchasing.Stores.Util.IRetryPolicy retryPolicy, Uniject.IUtil util);
            /*0x7f41968*/ void InitConnectionWithGooglePlay();
            /*0x7f41b14*/ void StartConnection();
            /*0x7f41bc8*/ void ResumeConnection();
            /*0x7f41c84*/ void AttemptReconnection();
            /*0x7f41d88*/ bool AreConnectionAttemptsExhausted();
            /*0x7f41d98*/ void RetryConnection(System.Action ActionToRetry);
            /*0x7f41ee4*/ void RetryConnectionAttempt(System.Action ActionToRetry);
            /*0x7f41fc4*/ void OnConnected();
            /*0x7f41ff4*/ void DequeueQueryProducts(UnityEngine.Purchasing.Models.GoogleBillingResponseCode googleBillingResponseCode);
            /*0x7f42560*/ void DequeueFetchPurchases();
            /*0x7f42738*/ void OnDisconnected(UnityEngine.Purchasing.Models.GoogleBillingResponseCode googleBillingResponseCode);
            /*0x7f42758*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason, UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed);
            /*0x7f428b8*/ void HandleRetrieveProductsNotConnected(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason, UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed);
            /*0x7f42a08*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product);
            /*0x7f42a20*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode);
            /*0x7f42c58*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished);
            /*0x7f42668*/ void FetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed);
            /*0x7f42d18*/ System.Threading.Tasks.Task TryFetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed);
            /*0x7f42e14*/ UnityEngine.Purchasing.Interfaces.IGooglePurchase GetPurchase(string purchaseToken, string skuType);
            /*0x7f42ed0*/ void <AttemptReconnection>b__19_0(System.Action retryAction);

            class <>c__DisplayClass21_0
            {
                /*0x10*/ UnityEngine.Purchasing.GooglePlayStoreService <>4__this;
                /*0x18*/ System.Action ActionToRetry;

                /*0x7f41edc*/ <>c__DisplayClass21_0();
                /*0x7f42ed4*/ void <RetryConnection>b__0();
            }

            struct <FetchPurchases>d__33 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                /*0x38*/ UnityEngine.Purchasing.GooglePlayStoreService <>4__this;
                /*0x40*/ System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed;
                /*0x48*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                /*0x7f42ef4*/ void MoveNext();
                /*0x7f431b0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <TryFetchPurchases>d__34 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed;
                /*0x38*/ UnityEngine.Purchasing.GooglePlayStoreService <>4__this;
                /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>u__1;

                /*0x7f431bc*/ void MoveNext();
                /*0x7f43570*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class GooglePurchaseService : UnityEngine.Purchasing.Interfaces.IGooglePurchaseService
        {
            /*0x10*/ UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient;
            /*0x18*/ UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback m_GooglePurchaseCallback;
            /*0x20*/ UnityEngine.Purchasing.Interfaces.IQueryProductDetailsService m_QueryProductDetailsService;

            static /*0x7f43cc4*/ void VerifyAndWarnIfMoreThanOneSku(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> skus);
            /*0x7f435d8*/ GooglePurchaseService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback googlePurchaseCallback, UnityEngine.Purchasing.Interfaces.IQueryProductDetailsService queryProductDetailsService);
            /*0x7f43638*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode);
            /*0x7f437b8*/ void OnQueryProductDetailsResponse(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> productDetailsList, UnityEngine.Purchasing.ProductDefinition productToBuy, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode);
            /*0x7f4386c*/ bool ValidateQueryProductDetailsResponseParams(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> skus, UnityEngine.Purchasing.ProductDefinition productToBuy, UnityEngine.Purchasing.Product oldProduct);
            /*0x7f439e4*/ bool ValidateSkus(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> skus);
            /*0x7f43a3c*/ void PurchaseFailedSkuNotFound(UnityEngine.Purchasing.ProductDefinition productToBuy);
            /*0x7f43b38*/ bool ValidateOldProduct(UnityEngine.Purchasing.Product oldProduct);
            /*0x7f43b90*/ void PurchaseFailedInvalidOldProduct(UnityEngine.Purchasing.ProductDefinition productToBuy, UnityEngine.Purchasing.Product oldProduct);
            /*0x7f438cc*/ void LaunchGoogleBillingFlow(UnityEngine.AndroidJavaObject productToPurchase, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode);
            /*0x7f43e20*/ void HandleBillingFlowResult(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, UnityEngine.AndroidJavaObject sku);

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.Purchasing.GooglePurchaseService <>4__this;
                /*0x18*/ UnityEngine.Purchasing.ProductDefinition product;
                /*0x20*/ UnityEngine.Purchasing.Product oldProduct;
                /*0x28*/ System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode;

                /*0x7f437b0*/ <>c__DisplayClass4_0();
                /*0x7f44098*/ void <Purchase>b__0(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> productDetailsList, UnityEngine.Purchasing.Models.IGoogleBillingResult _);
            }
        }

        class GoogleQueryPurchasesService : UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService
        {
            /*0x10*/ UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient;
            /*0x18*/ UnityEngine.Purchasing.Interfaces.IGooglePurchaseBuilder m_PurchaseBuilder;

            static /*0x7f4459c*/ bool IsResultOk(UnityEngine.Purchasing.Models.IGoogleBillingResult result);
            /*0x7f440bc*/ GoogleQueryPurchasesService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, UnityEngine.Purchasing.Interfaces.IGooglePurchaseBuilder purchaseBuilder);
            /*0x7f44100*/ System.Threading.Tasks.Task<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> QueryPurchases();
            /*0x7f441fc*/ System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> QueryPurchasesWithSkuType(string skuType);
            /*0x7f443b0*/ UnityEngine.Purchasing.Interfaces.IGooglePurchase GetPurchaseByToken(string purchaseToken, string skuType);

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.GoogleQueryPurchasesService.<> <>9;
                static /*0x8*/ System.Func<System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>9__3_0;

                static /*0x7f44644*/ <>c();
                /*0x7f446ac*/ <>c();
                /*0x7f446b4*/ System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> <QueryPurchases>b__3_0(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> result);
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.Purchasing.GoogleQueryPurchasesService <>4__this;
                /*0x18*/ System.Threading.Tasks.TaskCompletionSource<System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> taskCompletion;

                /*0x7f443a8*/ <>c__DisplayClass4_0();
                /*0x7f446bc*/ void <QueryPurchasesWithSkuType>b__0(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> purchases);
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ string purchaseToken;
                /*0x18*/ UnityEngine.Purchasing.GoogleQueryPurchasesService <>4__this;
                /*0x20*/ System.Threading.Tasks.TaskCompletionSource<UnityEngine.Purchasing.Interfaces.IGooglePurchase> taskCompletion;
                /*0x28*/ System.Func<UnityEngine.AndroidJavaObject, bool> <>9__1;

                /*0x7f44594*/ <>c__DisplayClass5_0();
                /*0x7f44814*/ void <GetPurchaseByToken>b__0(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> purchases);
                /*0x7f449a4*/ bool <GetPurchaseByToken>b__1(UnityEngine.AndroidJavaObject purchase);
            }

            struct <QueryPurchases>d__3 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>t__builder;
                /*0x30*/ UnityEngine.Purchasing.GoogleQueryPurchasesService <>4__this;
                /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>[]> <>u__1;

                /*0x7f44a98*/ void MoveNext();
                /*0x7f44f14*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        interface IGoogleCachedQueryProductDetailsService
        {
            /*0x38148bc*/ System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedProducts();
            /*0x3814a3c*/ System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedProductDetails(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x38141c4*/ bool Contains(UnityEngine.Purchasing.ProductDefinition products);
            /*0x3816710*/ void AddCachedQueriedProductDetails(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> queriedProducts);
        }

        class BillingClientStateListener : UnityEngine.AndroidJavaProxy, UnityEngine.Purchasing.Interfaces.IBillingClientStateListener
        {
            static string k_AndroidBillingClientStateListenerClassName = "com.android.billingclient.api.BillingClientStateListener";
            /*0x20*/ System.Action m_OnConnected;
            /*0x28*/ System.Action<UnityEngine.Purchasing.Models.GoogleBillingResponseCode> m_Disconnect;

            /*0x7f44f90*/ BillingClientStateListener();
            /*0x7f45000*/ void RegisterOnConnected(System.Action onConnected);
            /*0x7f45008*/ void RegisterOnDisconnected(System.Action<UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onDisconnected);
            /*0x7f45010*/ void onBillingSetupFinished(UnityEngine.AndroidJavaObject billingResult);
            /*0x7f45188*/ void onBillingServiceDisconnected();
        }

        class GoogleAcknowledgePurchaseListener : UnityEngine.AndroidJavaProxy
        {
            static string k_AndroidAcknowledgePurchaseResponseListenerClassName = "com.android.billingclient.api.AcknowledgePurchaseResponseListener";
            /*0x20*/ System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> m_OnAcknowledgePurchaseResponse;

            /*0x7f451b0*/ GoogleAcknowledgePurchaseListener(System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onAcknowledgePurchaseResponseAction);
            /*0x7f4523c*/ void onAcknowledgePurchaseResponse(UnityEngine.AndroidJavaObject billingResult);
        }

        class GoogleConsumeResponseListener : UnityEngine.AndroidJavaProxy
        {
            static string k_AndroidConsumeResponseListenerClassName = "com.android.billingclient.api.ConsumeResponseListener";
            /*0x20*/ System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> m_OnConsumeResponse;

            /*0x7f452cc*/ GoogleConsumeResponseListener(System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onConsumeResponseAction);
            /*0x7f45358*/ void onConsumeResponse(UnityEngine.AndroidJavaObject billingResult, string purchaseToken);
        }

        class GooglePurchasesResponseListener : UnityEngine.AndroidJavaProxy
        {
            static string k_AndroidPurchasesResponseListenerClassName = "com.android.billingclient.api.PurchasesResponseListener";
            /*0x20*/ System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> m_OnQueryPurchasesResponse;

            /*0x7f453e8*/ GooglePurchasesResponseListener(System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> onQueryPurchasesResponse);
            /*0x7f45474*/ void onQueryPurchasesResponse(UnityEngine.AndroidJavaObject billingResult, UnityEngine.AndroidJavaObject purchases);
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

            /*0x7f4565c*/ GooglePurchaseUpdatedListener(UnityEngine.Purchasing.Interfaces.IGoogleLastKnownProductService googleLastKnownProductService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback googlePurchaseCallback, UnityEngine.Purchasing.Interfaces.IGooglePurchaseBuilder purchaseBuilder, UnityEngine.Purchasing.IGoogleCachedQueryProductDetailsService googleCachedQueryProductDetailsService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider, UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService googleQueryPurchasesService);
            /*0x7f4575c*/ void SetGoogleQueryPurchaseService(UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService googleFetchPurchases);
            /*0x7f45764*/ void onPurchasesUpdated(UnityEngine.AndroidJavaObject billingResult, UnityEngine.AndroidJavaObject javaPurchasesList);
            /*0x7f459d0*/ void OnPurchasesUpdated(UnityEngine.Purchasing.Models.IGoogleBillingResult result, System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases);
            /*0x7f45c2c*/ void HandleResultOkCases(UnityEngine.Purchasing.Models.IGoogleBillingResult result, System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases);
            /*0x7f45e44*/ void HandleErrorCases(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases);
            /*0x7f45f0c*/ void HandleErrorGoogleBillingResult(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult);
            /*0x7f46978*/ void HandleUserCancelledPurchaseFailure(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult);
            /*0x7f46a48*/ void HandleUserCancelledPurchaseFailure(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> googlePurchases);
            /*0x7f45cf4*/ void ApplyOnPurchases(System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases, System.Action<UnityEngine.Purchasing.Interfaces.IGooglePurchase> action);
            /*0x7f465fc*/ void ApplyOnPurchases(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases, UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Action<UnityEngine.Purchasing.Interfaces.IGooglePurchase, string> action);
            /*0x7f46b94*/ void OnPurchaseOk(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase);
            /*0x7f471e8*/ void HandlePurchasedProduct(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase);
            /*0x7f47480*/ bool IsDeferredSubscriptionChange(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase);
            /*0x7f475c8*/ bool IsLastProrationModeDeferred();
            /*0x7f47008*/ void OnPurchaseCancelled(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult);
            /*0x7f476a0*/ void OnPurchaseCancelled(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase);
            /*0x7f47818*/ void OnPurchaseAlreadyOwned(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase);
            /*0x7f47990*/ void OnPurchaseFailed(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase, string debugMessage);
            /*0x7f47b20*/ bool <HandleUserCancelledPurchaseFailure>b__15_0(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase);

            struct <HandleUserCancelledPurchaseFailure>d__14 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                /*0x38*/ UnityEngine.Purchasing.GooglePurchaseUpdatedListener <>4__this;
                /*0x40*/ UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult;
                /*0x48*/ System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>u__1;

                /*0x7f47c50*/ void MoveNext();
                /*0x7f47eb4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class ProductDetailsResponseListener : UnityEngine.AndroidJavaProxy
        {
            static string k_AndroidProductDetailsResponseListenerClassName = "com.android.billingclient.api.ProductDetailsResponseListener";
            /*0x20*/ System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> m_OnProductDetailsResponse;
            /*0x28*/ Uniject.IUtil m_Util;
            /*0x30*/ UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics;

            /*0x7f47ec0*/ ProductDetailsResponseListener(System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onProductDetailsResponseAction, Uniject.IUtil util, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics);
            /*0x7f47f7c*/ void onProductDetailsResponse(UnityEngine.AndroidJavaObject billingResult, UnityEngine.AndroidJavaObject productDetails);

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.AndroidJavaObject productDetails;
                /*0x18*/ UnityEngine.Purchasing.ProductDetailsResponseListener <>4__this;
                /*0x20*/ UnityEngine.AndroidJavaObject billingResult;

                /*0x7f480dc*/ <>c__DisplayClass5_0();
                /*0x7f480e4*/ void <onProductDetailsResponse>b__0();
            }
        }

        class MetricizedGooglePlayStoreService : UnityEngine.Purchasing.GooglePlayStoreService
        {
            /*0x80*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService m_TelemetryMetricsService;
            /*0x88*/ UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics;

            /*0x7f48400*/ MetricizedGooglePlayStoreService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, UnityEngine.Purchasing.Interfaces.IQueryProductDetailsService queryProductDetailsService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseService purchaseService, UnityEngine.Purchasing.Interfaces.IGoogleFinishTransactionService finishTransactionService, UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService queryPurchasesService, UnityEngine.Purchasing.Interfaces.IBillingClientStateListener billingClientStateListener, UnityEngine.Purchasing.Interfaces.IGoogleLastKnownProductService lastKnownProductService, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics, UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService telemetryMetricsService, UnityEngine.ILogger logger, UnityEngine.Purchasing.Stores.Util.IRetryPolicy retryPolicy, Uniject.IUtil util);
            /*0x7f48458*/ void DequeueQueryProducts(UnityEngine.Purchasing.Models.GoogleBillingResponseCode googleBillingResponseCode);
            /*0x7f485d4*/ void DequeueFetchPurchases();
            /*0x7f486fc*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason, UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed);
            /*0x7f488b4*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode);
            /*0x7f48a60*/ void <>n__0(UnityEngine.Purchasing.Models.GoogleBillingResponseCode googleBillingResponseCode);
            /*0x7f48a64*/ void <>n__1(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason, UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed);
            /*0x7f48a68*/ void <>n__2(UnityEngine.Purchasing.ProductDefinition product, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode);

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedGooglePlayStoreService <>4__this;
                /*0x18*/ UnityEngine.Purchasing.Models.GoogleBillingResponseCode googleBillingResponseCode;

                /*0x7f485cc*/ <>c__DisplayClass3_0();
                /*0x7f48a6c*/ void <DequeueQueryProducts>b__0();
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedGooglePlayStoreService <>4__this;
                /*0x18*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;
                /*0x20*/ System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived;
                /*0x28*/ System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason, UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed;

                /*0x7f488ac*/ <>c__DisplayClass5_0();
                /*0x7f48a8c*/ void <RetrieveProducts>b__0();
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedGooglePlayStoreService <>4__this;
                /*0x18*/ UnityEngine.Purchasing.ProductDefinition product;
                /*0x20*/ UnityEngine.Purchasing.Product oldProduct;
                /*0x28*/ System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode;

                /*0x7f48a58*/ <>c__DisplayClass6_0();
                /*0x7f48ab0*/ void <Purchase>b__0();
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

            static /*0x7f49720*/ bool IsRecoverable(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult);
            /*0x7f49830*/ ProductDetailsQueryResponse();
            /*0x7f48ad4*/ void Finalize();
            /*0x7f49074*/ void AddResponse(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails);
            /*0x7f49208*/ System.Collections.Generic.List<UnityEngine.AndroidJavaObject> ProductDetails();
            /*0x7f493e8*/ bool IsRecoverable();
            /*0x7f49564*/ UnityEngine.Purchasing.Models.IGoogleBillingResult GetGoogleBillingResult();

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.ProductDetailsQueryResponse.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.AndroidJavaObject, UnityEngine.AndroidJavaObject> <>9__2_0;
                static /*0x10*/ System.Func<System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>>, bool> <>9__3_0;
                static /*0x18*/ System.Func<System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>>, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> <>9__3_1;
                static /*0x20*/ System.Func<System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>>, UnityEngine.Purchasing.Models.IGoogleBillingResult> <>9__4_0;
                static /*0x28*/ System.Func<System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>>, UnityEngine.Purchasing.Models.IGoogleBillingResult> <>9__5_0;
                static /*0x30*/ System.Func<UnityEngine.Purchasing.Models.IGoogleBillingResult, bool> <>9__5_1;

                static /*0x7f498b8*/ <>c();
                /*0x7f49920*/ <>c();
                /*0x7f49928*/ UnityEngine.AndroidJavaObject <AddResponse>b__2_0(UnityEngine.AndroidJavaObject product);
                /*0x7f49940*/ bool <ProductDetails>b__3_0(System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> response);
                /*0x7f499e8*/ System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> <ProductDetails>b__3_1(System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> response);
                /*0x7f499f0*/ UnityEngine.Purchasing.Models.IGoogleBillingResult <IsRecoverable>b__4_0(System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> response);
                /*0x7f499f8*/ UnityEngine.Purchasing.Models.IGoogleBillingResult <GetGoogleBillingResult>b__5_0(System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> response);
                /*0x7f49a00*/ bool <GetGoogleBillingResult>b__5_1(UnityEngine.Purchasing.Models.IGoogleBillingResult response);
            }
        }

        class ProductDetailsResponseConsolidator : UnityEngine.Purchasing.Interfaces.IProductDetailsResponseConsolidator
        {
            /*0x10*/ int m_NumberReceivedCallbacks;
            /*0x18*/ System.Action<UnityEngine.Purchasing.Interfaces.IProductDetailsQueryResponse> m_OnProductDetailsResponseConsolidated;
            /*0x20*/ UnityEngine.Purchasing.Interfaces.IProductDetailsQueryResponse m_Responses;
            /*0x28*/ Uniject.IUtil m_Util;
            /*0x30*/ UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics;

            /*0x7f49aa8*/ ProductDetailsResponseConsolidator(Uniject.IUtil util, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics, System.Action<UnityEngine.Purchasing.Interfaces.IProductDetailsQueryResponse> onProductDetailsResponseConsolidated);
            /*0x7f49b5c*/ void Consolidate(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails);
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

            /*0x7f49d5c*/ QueryProductDetailsService(UnityEngine.Purchasing.Interfaces.IGoogleBillingClient billingClient, UnityEngine.Purchasing.IGoogleCachedQueryProductDetailsService googleCachedQueryProductDetailsService, UnityEngine.Purchasing.Interfaces.IProductDetailsConverter productDetailsConverter, UnityEngine.Purchasing.Stores.Util.IRetryPolicy retryPolicy, UnityEngine.Purchasing.Interfaces.IGoogleProductCallback googleProductCallback, Uniject.IUtil util, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics);
            /*0x7f49e1c*/ void QueryAsyncProduct(UnityEngine.Purchasing.ProductDefinition product, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse);
            /*0x7f4a0f0*/ void QueryAsyncProduct(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse);
            /*0x7f49f40*/ void QueryAsyncProduct(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse);
            /*0x7f4a1e4*/ void QueryAsyncProductWithRetries(System.Collections.Generic.IReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse, System.Action retryQuery);
            /*0x7f4a350*/ void TryQueryAsyncProductWithRetries(System.Collections.Generic.IReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse, System.Action retryQuery);
            /*0x7f4a8c8*/ bool ShouldRetryQuery(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> requestedProducts, UnityEngine.Purchasing.Interfaces.IProductDetailsQueryResponse queryResponse);
            /*0x7f4a99c*/ bool AreAllProductDetailsCached(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x7f4ab6c*/ System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedProductDetails(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x7f4a4b0*/ void QueryInAppsAsync(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products, UnityEngine.Purchasing.Interfaces.IProductDetailsResponseConsolidator consolidator);
            /*0x7f4a6bc*/ void QuerySubsAsync(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products, UnityEngine.Purchasing.Interfaces.IProductDetailsResponseConsolidator consolidator);
            /*0x7f4acf8*/ void QueryProductDetails(System.Collections.Generic.List<string> productList, string type, UnityEngine.Purchasing.Interfaces.IProductDetailsResponseConsolidator consolidator);

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.QueryProductDetailsService.<> <>9;
                static /*0x8*/ System.Func<bool, bool> <>9__14_0;
                static /*0x10*/ System.Func<UnityEngine.Purchasing.ProductDefinition, bool> <>9__16_0;
                static /*0x18*/ System.Func<UnityEngine.Purchasing.ProductDefinition, string> <>9__16_1;
                static /*0x20*/ System.Func<UnityEngine.Purchasing.ProductDefinition, bool> <>9__17_0;
                static /*0x28*/ System.Func<UnityEngine.Purchasing.ProductDefinition, string> <>9__17_1;

                static /*0x7f4af50*/ <>c();
                /*0x7f4afb8*/ <>c();
                /*0x7f4afc0*/ bool <AreAllProductDetailsCached>b__14_0(bool isCached);
                /*0x7f4afc8*/ bool <QueryInAppsAsync>b__16_0(UnityEngine.Purchasing.ProductDefinition product);
                /*0x7f4afe8*/ string <QueryInAppsAsync>b__16_1(UnityEngine.Purchasing.ProductDefinition product);
                /*0x7f4b000*/ bool <QuerySubsAsync>b__17_0(UnityEngine.Purchasing.ProductDefinition product);
                /*0x7f4b020*/ string <QuerySubsAsync>b__17_1(UnityEngine.Purchasing.ProductDefinition product);
            }

            class <>c__DisplayClass10_0
            {
                /*0x10*/ UnityEngine.Purchasing.QueryProductDetailsService <>4__this;
                /*0x18*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;
                /*0x20*/ System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse;
                /*0x28*/ int retryCount;

                /*0x7f4a1dc*/ <>c__DisplayClass10_0();
                /*0x7f4b038*/ void <QueryAsyncProduct>b__0(System.Action retryAction);
                /*0x7f4b05c*/ void <QueryAsyncProduct>g__OnActionRetry|1();
            }

            class <>c__DisplayClass12_0
            {
                /*0x10*/ UnityEngine.Purchasing.QueryProductDetailsService <>4__this;
                /*0x18*/ System.Collections.Generic.IReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;
                /*0x20*/ System.Action retryQuery;
                /*0x28*/ System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse;

                /*0x7f4a4a8*/ <>c__DisplayClass12_0();
                /*0x7f4b118*/ void <TryQueryAsyncProductWithRetries>b__0(UnityEngine.Purchasing.Interfaces.IProductDetailsQueryResponse productDetailsQueryResponse);
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse;
                /*0x18*/ UnityEngine.Purchasing.QueryProductDetailsService <>4__this;

                /*0x7f4a1d4*/ <>c__DisplayClass9_0();
                /*0x7f4b334*/ void <QueryAsyncProduct>b__0(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> productDetails, UnityEngine.Purchasing.Models.IGoogleBillingResult responseCode);
            }
        }

        class FakeGooglePlayStoreConfiguration : UnityEngine.Purchasing.IGooglePlayConfiguration, UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
            /*0x7f4b410*/ FakeGooglePlayStoreConfiguration();
        }

        class FakeGooglePlayStoreExtensions : UnityEngine.Purchasing.IGooglePlayStoreExtensions, UnityEngine.Purchasing.IStoreExtension
        {
            /*0x7f4b420*/ FakeGooglePlayStoreExtensions();
            /*0x7f4b418*/ bool IsPurchasedProductDeferred(UnityEngine.Purchasing.Product product);
        }

        class GetGoogleProductMetadataExtension
        {
            static /*0x7f4b428*/ UnityEngine.Purchasing.GoogleProductMetadata GetGoogleProductMetadata(UnityEngine.Purchasing.ProductMetadata productMetadata);
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

            /*0x7f4b4a0*/ GooglePlayConfiguration(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService);
            /*0x7f4b4d8*/ void NotifyInitializationConnectionFailed();
            /*0x7f4b4f4*/ void NotifyQueryProductDetailsFailed(int retryCount);
            /*0x7f4b510*/ void NotifyDeferredProrationUpgradeDowngradeSubscription(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback, string productId);
            /*0x7f4b6e0*/ bool IsFetchPurchasesAtInitializeSkipped();
            /*0x7f4b6f0*/ bool DoesRetrievePurchasesExcludeDeferred();
            /*0x7f4b6f8*/ void NotifyDeferredPurchase(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback, UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, string receipt, string transactionId);
        }

        class GooglePlayProductCallback : UnityEngine.Purchasing.Interfaces.IGoogleProductCallback
        {
            /*0x10*/ UnityEngine.Purchasing.IGooglePlayConfigurationInternal m_GooglePlayConfigurationInternal;

            /*0x7f4b8f4*/ GooglePlayProductCallback();
            /*0x7f4b838*/ void SetStoreConfiguration(UnityEngine.Purchasing.IGooglePlayConfigurationInternal configuration);
            /*0x7f4b840*/ void NotifyQueryProductDetailsFailed(int retryCount);
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

            /*0x7f4b8fc*/ GooglePlayPurchaseCallback(Uniject.IUtil util);
            /*0x7f4b92c*/ void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
            /*0x7f4b934*/ void SetStoreConfiguration(UnityEngine.Purchasing.IGooglePlayConfigurationInternal configuration);
            /*0x7f4b93c*/ void OnPurchaseSuccessful(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, string receipt, string purchaseToken);
            /*0x7f4baa0*/ void OnPurchaseFailed(UnityEngine.Purchasing.Extension.PurchaseFailureDescription purchaseFailureDescription);
            /*0x7f4bb54*/ void NotifyDeferredPurchase(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, string receipt, string purchaseToken);
            /*0x7f4bcd0*/ void NotifyDeferredProrationUpgradeDowngradeSubscription(string sku);

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.Purchasing.GooglePlayPurchaseCallback <>4__this;
                /*0x18*/ UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase;
                /*0x20*/ string receipt;
                /*0x28*/ string purchaseToken;

                /*0x7f4bcc8*/ <>c__DisplayClass8_0();
                /*0x7f4be1c*/ void <NotifyDeferredPurchase>b__0();
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ UnityEngine.Purchasing.GooglePlayPurchaseCallback <>4__this;
                /*0x18*/ string sku;

                /*0x7f4be14*/ <>c__DisplayClass9_0();
                /*0x7f4befc*/ void <NotifyDeferredProrationUpgradeDowngradeSubscription>b__0();
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

            /*0x7f4bfc4*/ GooglePlayStore(UnityEngine.Purchasing.IGooglePlayStoreRetrieveProductsService retrieveProductsService, UnityEngine.Purchasing.IGooglePlayStorePurchaseService storePurchaseService, UnityEngine.Purchasing.IGoogleFetchPurchases fetchPurchases, UnityEngine.Purchasing.IGooglePlayStoreFinishTransactionService transactionService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback googlePurchaseCallback, UnityEngine.Purchasing.IGooglePlayConfigurationInternal googlePlayConfigurationInternal, UnityEngine.Purchasing.IGooglePlayStoreExtensionsInternal googlePlayStoreExtensions, Uniject.IUtil util);
            /*0x7f4c098*/ void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback callback);
            /*0x7f4c39c*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x7f4c51c*/ bool HasInitiallyRetrievedProducts();
            /*0x7f4c458*/ bool ShouldFetchPurchasesNext();
            /*0x7f4c5c0*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, string dummy);
            /*0x7f4c668*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId);
            /*0x7f4c724*/ void OnPause(bool isPaused);
        }

        class GooglePlayStoreExtensions : UnityEngine.Purchasing.IGooglePlayStoreExtensions, UnityEngine.Purchasing.IStoreExtension, UnityEngine.Purchasing.IGooglePlayStoreExtensionsInternal
        {
            /*0x10*/ UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService;
            /*0x18*/ UnityEngine.Purchasing.Interfaces.IGooglePurchaseStateEnumProvider m_GooglePurchaseStateEnumProvider;
            /*0x20*/ UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics;
            /*0x28*/ UnityEngine.ILogger m_Logger;
            /*0x30*/ UnityEngine.Purchasing.Extension.IStoreCallback m_StoreCallback;

            /*0x7f4c854*/ GooglePlayStoreExtensions(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider, UnityEngine.ILogger logger, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics);
            /*0x7f4c8c8*/ void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
            /*0x7f4c8d0*/ bool IsPurchasedProductDeferred(UnityEngine.Purchasing.Product product);
            /*0x7f4ca88*/ bool TryIsPurchasedProductDeferred(UnityEngine.Purchasing.Product product);
            /*0x7f4caac*/ UnityEngine.Purchasing.Security.GooglePurchaseState GetPurchaseState(UnityEngine.Purchasing.Product product);
            /*0x7f4ccb4*/ UnityEngine.Purchasing.Interfaces.IGooglePurchase GooglePurchaseFromProduct(UnityEngine.Purchasing.Product product);
        }

        interface IGooglePlayConfiguration : UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
        }

        interface IGooglePlayConfigurationInternal
        {
            /*0x38159dc*/ void NotifyInitializationConnectionFailed();
            /*0x3816958*/ void NotifyDeferredPurchase(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback, UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, string receipt, string transactionId);
            /*0x3816810*/ void NotifyDeferredProrationUpgradeDowngradeSubscription(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback, string productId);
            /*0x3813ffc*/ bool IsFetchPurchasesAtInitializeSkipped();
            /*0x3813ffc*/ bool DoesRetrievePurchasesExcludeDeferred();
            /*0x3815ed0*/ void NotifyQueryProductDetailsFailed(int retryCount);
        }

        interface IGooglePlayStoreExtensions : UnityEngine.Purchasing.IStoreExtension
        {
            /*0x38141c4*/ bool IsPurchasedProductDeferred(UnityEngine.Purchasing.Product product);
        }

        interface IGooglePlayStoreExtensionsInternal
        {
            /*0x3816710*/ void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
        }

        interface IGoogleFetchPurchases
        {
            /*0x3816710*/ void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
            /*0x38159dc*/ void FetchPurchases();
            /*0x3816710*/ void FetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> onQueryPurchaseSucceed);
        }

        interface IGooglePlayStoreFinishTransactionService
        {
            /*0x3816710*/ void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
            /*0x3816810*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string purchaseToken);
        }

        interface IGooglePlayStorePurchaseService
        {
            /*0x3816710*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product);
        }

        interface IGooglePlayStoreRetrieveProductsService
        {
            /*0x3816710*/ void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
            void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, bool wantPurchases);
            /*0x38159dc*/ void ResumeConnection();
            /*0x3813ffc*/ bool HasInitiallyRetrievedProducts();
        }

        class MetricizedGooglePlayStoreExtensions : UnityEngine.Purchasing.GooglePlayStoreExtensions
        {
            /*0x38*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService m_TelemetryMetricsService;

            /*0x7f4cd98*/ MetricizedGooglePlayStoreExtensions(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider, UnityEngine.ILogger logger, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics, UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService telemetryMetricsService);
        }

        class GoogleProductMetadata : UnityEngine.Purchasing.ProductMetadata
        {
            /*0x40*/ string <originalJson>k__BackingField;
            /*0x48*/ string <subscriptionPeriod>k__BackingField;
            /*0x50*/ string <freeTrialPeriod>k__BackingField;
            /*0x58*/ string <introductoryPrice>k__BackingField;
            /*0x60*/ string <introductoryPricePeriod>k__BackingField;
            /*0x68*/ int <introductoryPriceCycles>k__BackingField;

            /*0x7f4cdfc*/ GoogleProductMetadata(string priceString, string title, string description, string currencyCode, decimal localizedPrice);
            /*0x7f4cdc4*/ string get_originalJson();
            /*0x7f4cdcc*/ void set_originalJson(string value);
            /*0x7f4cdd4*/ void set_subscriptionPeriod(string value);
            /*0x7f4cddc*/ void set_freeTrialPeriod(string value);
            /*0x7f4cde4*/ void set_introductoryPrice(string value);
            /*0x7f4cdec*/ void set_introductoryPricePeriod(string value);
            /*0x7f4cdf4*/ void set_introductoryPriceCycles(int value);
        }

        class GoogleFetchPurchases : UnityEngine.Purchasing.IGoogleFetchPurchases
        {
            /*0x10*/ UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService;
            /*0x18*/ UnityEngine.Purchasing.Extension.IStoreCallback m_StoreCallback;
            /*0x20*/ Uniject.IUtil m_Util;

            static /*0x7f4d368*/ UnityEngine.Purchasing.Product CompleteProductInfoWithPurchase(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase);
            static /*0x7f4d74c*/ System.Func<UnityEngine.Purchasing.Interfaces.IGooglePurchase, bool> PurchaseIsPurchased();
            static /*0x7f4d81c*/ System.Func<UnityEngine.Purchasing.Interfaces.IGooglePurchase, bool> PurchaseIsPending();
            /*0x7f4ce04*/ GoogleFetchPurchases(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService, Uniject.IUtil util);
            /*0x7f4ce48*/ void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
            /*0x7f4ce50*/ void FetchPurchases();
            /*0x7f4cf44*/ void FetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> onQueryPurchaseSucceed);
            /*0x7f4d090*/ System.Collections.Generic.List<UnityEngine.Purchasing.Product> FillProductsWithPurchases(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases);
            /*0x7f4d150*/ System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Product> BuildProductsFromPurchase(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase);
            /*0x7f4d4d8*/ void OnFetchedPurchase(System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases);
            /*0x7f4d8ec*/ void UpdateDeferredProductsByPurchases(System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> deferredPurchases);
            /*0x7f4da28*/ void UpdateDeferredProductsByPurchase(UnityEngine.Purchasing.Interfaces.IGooglePurchase deferredPurchase);
            /*0x7f4dbd8*/ void UpdateDeferredProduct(UnityEngine.Purchasing.Interfaces.IGooglePurchase deferredPurchase, string sku);

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.GoogleFetchPurchases.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.Purchasing.Interfaces.IGooglePurchase, bool> <>9__11_0;
                static /*0x10*/ System.Func<UnityEngine.Purchasing.Interfaces.IGooglePurchase, bool> <>9__12_0;

                static /*0x7f4dd2c*/ <>c();
                /*0x7f4dd94*/ <>c();
                /*0x7f4dd9c*/ bool <PurchaseIsPurchased>b__11_0(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase);
                /*0x7f4de3c*/ bool <PurchaseIsPending>b__12_0(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase);
            }

            class <>c__DisplayClass10_0
            {
                /*0x10*/ UnityEngine.Purchasing.GoogleFetchPurchases <>4__this;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> deferredPurchases;

                /*0x7f4d744*/ <>c__DisplayClass10_0();
                /*0x7f4dedc*/ void <OnFetchedPurchase>b__0();
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> onQueryPurchaseSucceed;
                /*0x18*/ UnityEngine.Purchasing.GoogleFetchPurchases <>4__this;

                /*0x7f4d088*/ <>c__DisplayClass6_0();
                /*0x7f4defc*/ void <FetchPurchases>b__0(System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> googlePurchases);
            }

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.Purchasing.GoogleFetchPurchases <>4__this;
                /*0x18*/ UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase;

                /*0x7f4d360*/ <>c__DisplayClass8_0();
                /*0x7f4df34*/ UnityEngine.Purchasing.Product <BuildProductsFromPurchase>b__0(string sku);
                /*0x7f4df5c*/ UnityEngine.Purchasing.Product <BuildProductsFromPurchase>b__1(UnityEngine.Purchasing.Product product);
            }
        }

        class GooglePlayStoreFinishTransactionService : UnityEngine.Purchasing.IGooglePlayStoreFinishTransactionService
        {
            /*0x10*/ System.Collections.Generic.HashSet<string> m_ProcessedPurchaseToken;
            /*0x18*/ UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService;
            /*0x20*/ UnityEngine.Purchasing.Extension.IStoreCallback m_StoreCallback;
            /*0x28*/ int m_RetryCount;

            static /*0x7f4e840*/ bool IsResponseCodeInRecoverableState(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult);
            /*0x7f4df6c*/ GooglePlayStoreFinishTransactionService(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService);
            /*0x7f4e008*/ void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
            /*0x7f4e010*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string purchaseToken);
            /*0x7f4e178*/ void HandleFinishTransaction(UnityEngine.Purchasing.ProductDefinition product, UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase);
            /*0x7f4e624*/ void CallPurchaseSucceededUpdateReceipt(UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase);

            class <>c__DisplayClass7_0
            {
                /*0x10*/ UnityEngine.Purchasing.GooglePlayStoreFinishTransactionService <>4__this;
                /*0x18*/ UnityEngine.Purchasing.ProductDefinition product;

                /*0x7f4e170*/ <>c__DisplayClass7_0();
                /*0x7f4e9b0*/ void <FinishTransaction>b__0(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase googlePurchase);
            }
        }

        class GooglePlayStorePurchaseService : UnityEngine.Purchasing.IGooglePlayStorePurchaseService
        {
            /*0x10*/ UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService;

            /*0x7f4e9d8*/ GooglePlayStorePurchaseService(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService);
            /*0x7f4ea08*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product);
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

            /*0x7f4eab4*/ GooglePlayStoreRetrieveProductsService(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService, UnityEngine.Purchasing.IGoogleFetchPurchases googleFetchPurchases, UnityEngine.Purchasing.IGooglePlayConfigurationInternal googlePlayConfigurationInternal, UnityEngine.Purchasing.IGooglePlayStoreExtensions googlePlayStoreExtensions);
            /*0x7f4eb30*/ void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
            /*0x7f4eb38*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, bool wantPurchases);
            /*0x7f4ed18*/ void OnProductsRetrievedWithPurchaseFetch(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> retrievedProducts, UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult);
            /*0x7f4f130*/ void OnProductsRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> retrievedProducts, UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult);
            /*0x7f4ef78*/ void OnRetrieveProductsFailed(UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason reason, UnityEngine.Purchasing.Models.GoogleBillingResponseCode responseCode);
            /*0x7f4f300*/ void ResumeConnection();
            /*0x7f4f3a4*/ System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> MakePurchasesIntoProducts(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> retrievedProducts, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Product> purchaseProducts);
            /*0x7f4f900*/ bool IsPurchasedProductDeferred(UnityEngine.Purchasing.Product product);
            /*0x7f4f9a8*/ bool HasInitiallyRetrievedProducts();

            class <>c__DisplayClass10_0
            {
                /*0x10*/ UnityEngine.Purchasing.GooglePlayStoreRetrieveProductsService <>4__this;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> retrievedProducts;

                /*0x7f4ef70*/ <>c__DisplayClass10_0();
                /*0x7f4f9b0*/ void <OnProductsRetrievedWithPurchaseFetch>b__0(System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchaseProducts);
            }

            class <>c__DisplayClass14_0
            {
                /*0x10*/ UnityEngine.Purchasing.Product purchaseProduct;

                /*0x7f4f8f8*/ <>c__DisplayClass14_0();
                /*0x7f4fa88*/ bool <MakePurchasesIntoProducts>b__0(UnityEngine.Purchasing.Extension.ProductDescription product);
            }
        }

        class StoreCallbackExtensionMethods
        {
            static /*0x7f4b550*/ UnityEngine.Purchasing.Product FindProductById(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback, string sku);
        }

        interface IAndroidStoreSelection : UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
        }

        interface IUnityCallback
        {
            /*0x3816710*/ void OnSetupFailed(string json);
            /*0x3816710*/ void OnProductsRetrieved(string json);
            /*0x3816920*/ void OnPurchaseSucceeded(string id, string receipt, string transactionID);
            /*0x3816710*/ void OnPurchaseFailed(string json);
        }

        class JavaBridge : UnityEngine.AndroidJavaProxy, UnityEngine.Purchasing.IUnityCallback
        {
            /*0x20*/ UnityEngine.Purchasing.IUnityCallback forwardTo;

            /*0x7f4fab8*/ JavaBridge(UnityEngine.Purchasing.IUnityCallback forwardTo);
            /*0x7f4fb44*/ JavaBridge(UnityEngine.Purchasing.IUnityCallback forwardTo, string javaInterface);
            /*0x7f4fbc0*/ void OnSetupFailed(string json);
            /*0x7f4fc68*/ void OnProductsRetrieved(string json);
            /*0x7f4fd14*/ void OnPurchaseSucceeded(string id, string receipt, string transactionID);
            /*0x7f4fdd8*/ void OnPurchaseFailed(string json);
        }

        class SerializationExtensions
        {
            static /*0x7f3f854*/ string TryGetString(System.Collections.Generic.Dictionary<string, object> dic, string key);
        }

        class JSONSerializer
        {
            static /*0x7f4fe84*/ string SerializeProductDef(UnityEngine.Purchasing.ProductDefinition product);
            static /*0x7f50750*/ string SerializeProductDefs(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products);
            static /*0x7f50ad8*/ string SerializeProductDescs(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Extension.ProductDescription> products);
            static /*0x7f51058*/ UnityEngine.Purchasing.Extension.PurchaseFailureDescription DeserializeFailureReason(string json);
            static /*0x7f513b4*/ string BuildPurchaseFailureDescriptionMessage(System.Collections.Generic.Dictionary<string, object> dic);
            static /*0x7f4fe98*/ System.Collections.Generic.Dictionary<string, object> EncodeProductDef(UnityEngine.Purchasing.ProductDefinition product);
            static /*0x7f50e60*/ System.Collections.Generic.Dictionary<string, object> EncodeProductDesc(UnityEngine.Purchasing.Extension.ProductDescription product);
            static /*0x7f5147c*/ System.Collections.Generic.Dictionary<string, object> EncodeProductMeta(UnityEngine.Purchasing.ProductMetadata product);
        }

        class ScriptingStoreCallback : UnityEngine.Purchasing.Extension.IStoreCallback
        {
            /*0x10*/ UnityEngine.Purchasing.Extension.IStoreCallback m_ForwardTo;
            /*0x18*/ Uniject.IUtil m_Util;

            /*0x7f4c358*/ ScriptingStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback forwardTo, Uniject.IUtil util);
            /*0x7f51638*/ UnityEngine.Purchasing.ProductCollection get_products();
            /*0x7f516d8*/ void OnSetupFailed(UnityEngine.Purchasing.InitializationFailureReason reason, string message);
            /*0x7f51834*/ void OnProductsRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products);
            /*0x7f51980*/ void OnPurchaseSucceeded(string id, string receipt, string transactionID);
            /*0x7f51afc*/ void OnAllPurchasesRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchasedProducts);
            /*0x7f51c48*/ void OnPurchaseFailed(UnityEngine.Purchasing.Extension.PurchaseFailureDescription desc);

            class <>c__DisplayClass10_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingStoreCallback <>4__this;
                /*0x18*/ UnityEngine.Purchasing.Extension.PurchaseFailureDescription desc;

                /*0x7f51d8c*/ <>c__DisplayClass10_0();
                /*0x7f51d94*/ void <OnPurchaseFailed>b__0();
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingStoreCallback <>4__this;
                /*0x18*/ UnityEngine.Purchasing.InitializationFailureReason reason;
                /*0x20*/ string message;

                /*0x7f5182c*/ <>c__DisplayClass6_0();
                /*0x7f51e48*/ void <OnSetupFailed>b__0();
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingStoreCallback <>4__this;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products;

                /*0x7f51978*/ <>c__DisplayClass7_0();
                /*0x7f51f04*/ void <OnProductsRetrieved>b__0();
            }

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingStoreCallback <>4__this;
                /*0x18*/ string id;
                /*0x20*/ string receipt;
                /*0x28*/ string transactionID;

                /*0x7f51af4*/ <>c__DisplayClass8_0();
                /*0x7f51fb8*/ void <OnPurchaseSucceeded>b__0();
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingStoreCallback <>4__this;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchasedProducts;

                /*0x7f51c40*/ <>c__DisplayClass9_0();
                /*0x7f52080*/ void <OnAllPurchasesRetrieved>b__0();
            }
        }

        class ScriptingUnityCallback : UnityEngine.Purchasing.IUnityCallback
        {
            /*0x10*/ UnityEngine.Purchasing.IUnityCallback forwardTo;
            /*0x18*/ Uniject.IUtil util;

            /*0x7f52134*/ ScriptingUnityCallback(UnityEngine.Purchasing.IUnityCallback forwardTo, Uniject.IUtil util);
            /*0x7f52178*/ void OnSetupFailed(string json);
            /*0x7f522c4*/ void OnProductsRetrieved(string json);
            /*0x7f52410*/ void OnPurchaseSucceeded(string id, string receipt, string transactionID);
            /*0x7f5258c*/ void OnPurchaseFailed(string json);

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingUnityCallback <>4__this;
                /*0x18*/ string json;

                /*0x7f522bc*/ <>c__DisplayClass3_0();
                /*0x7f526d8*/ void <OnSetupFailed>b__0();
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingUnityCallback <>4__this;
                /*0x18*/ string json;

                /*0x7f52408*/ <>c__DisplayClass4_0();
                /*0x7f52788*/ void <OnProductsRetrieved>b__0();
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingUnityCallback <>4__this;
                /*0x18*/ string id;
                /*0x20*/ string receipt;
                /*0x28*/ string transactionID;

                /*0x7f52584*/ <>c__DisplayClass5_0();
                /*0x7f5283c*/ void <OnPurchaseSucceeded>b__0();
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ UnityEngine.Purchasing.ScriptingUnityCallback <>4__this;
                /*0x18*/ string json;

                /*0x7f526d0*/ <>c__DisplayClass6_0();
                /*0x7f52904*/ void <OnPurchaseFailed>b__0();
            }
        }

        class FakeUDPExtension : UnityEngine.Purchasing.IUDPExtensions, UnityEngine.Purchasing.IStoreExtension
        {
            /*0x7f529b8*/ FakeUDPExtension();
        }

        interface INativeUDPStore : UnityEngine.Purchasing.INativeStore
        {
            /*0x3816710*/ void Initialize(System.Action<bool, string> callback);
            /*0x3816920*/ void Purchase(string productId, System.Action<bool, string> callback, string developerPayload);
            /*0x3816810*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<bool, string> callback);
            /*0x3816810*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition productDefinition, string transactionID);
        }

        interface IUDPExtensions : UnityEngine.Purchasing.IStoreExtension
        {
        }

        class UDP
        {
            static /*0x7f529c0*/ string get_Name();
        }

        class UDPBindings : UnityEngine.Purchasing.INativeUDPStore, UnityEngine.Purchasing.INativeStore
        {
            /*0x10*/ object m_Bridge;
            /*0x18*/ System.Action<bool, string> m_RetrieveProductsCallbackCache;

            static /*0x7f5443c*/ System.Collections.Generic.Dictionary<string, string> StringPropertyToDictionary(object info);
            /*0x7f52acc*/ UDPBindings();
            /*0x7f52c70*/ void Initialize(System.Action<bool, string> callback);
            /*0x7f52de4*/ void Purchase(string productId, System.Action<bool, string> callback, string developerPayload);
            /*0x7f52fd0*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<bool, string> callback);
            /*0x7f535a8*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition productDefinition, string transactionID);
            /*0x7f5371c*/ void OnInventoryQueried(bool success, object payload);
            /*0x7f54600*/ void RetrieveProducts(string json);
            /*0x7f54638*/ void Purchase(string productJSON, string developerPayload);
            /*0x7f54670*/ void FinishTransaction(string productJSON, string transactionID);
        }

        class UDPImpl : UnityEngine.Purchasing.JSONStore, UnityEngine.Purchasing.IUDPExtensions, UnityEngine.Purchasing.IStoreExtension
        {
            /*0x48*/ UnityEngine.Purchasing.INativeUDPStore m_Bindings;
            /*0x50*/ object m_UserInfo;
            /*0x58*/ string m_LastInitError;
            /*0x60*/ bool m_Initialized;
            /*0x68*/ System.Action<UnityEngine.Purchasing.Product> m_DeferredCallback;

            static /*0x7f54c00*/ void DictionaryToStringProperty(System.Collections.Generic.Dictionary<string, object> dic, object info);
            /*0x7f54d58*/ UDPImpl();
            /*0x7f546a8*/ void SetNativeStore(UnityEngine.Purchasing.INativeUDPStore nativeUdpStore);
            /*0x7f546b0*/ void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback callback);
            /*0x7f546b8*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x7f548b0*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);
            /*0x7f54a18*/ void OnPurchaseDeferred(string productId);
            /*0x7f54b24*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId);

            class <>c__DisplayClass10_0
            {
                /*0x10*/ UnityEngine.Purchasing.UDPImpl <>4__this;
                /*0x18*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;

                /*0x7f548a8*/ <>c__DisplayClass10_0();
                /*0x7f54dd0*/ void <RetrieveProducts>g__retrieveCallback|0(bool success, string json);
                /*0x7f54e88*/ void <RetrieveProducts>b__1(bool success, string message);
            }

            class <>c__DisplayClass11_0
            {
                /*0x10*/ UnityEngine.Purchasing.ProductDefinition product;
                /*0x18*/ UnityEngine.Purchasing.UDPImpl <>4__this;

                /*0x7f54a10*/ <>c__DisplayClass11_0();
                /*0x7f5522c*/ void <Purchase>b__0(bool success, string message);
            }
        }

        class UDPReflectionUtils
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<System.Reflection.Assembly, System.Type[]> s_assemblyTypeCache;
            static /*0x8*/ System.Collections.Generic.Dictionary<string, System.Type> s_typeCache;
            static /*0x10*/ string[] k_whiteListedAssemblies;

            static /*0x7f56260*/ UDPReflectionUtils();
            static /*0x7f55900*/ System.Type GetTypeByName(string typeName);
            static /*0x7f56138*/ System.Collections.Generic.IEnumerable<System.Reflection.Assembly> GetAllAssemblies();
            static /*0x7f56160*/ System.Collections.Generic.IEnumerable<System.Type> GetTypes(System.Reflection.Assembly assembly);

            class <>c__DisplayClass6_0
            {
                /*0x10*/ System.Reflection.Assembly assembly;

                /*0x7f56158*/ <>c__DisplayClass6_0();
                /*0x7f5645c*/ bool <GetTypeByName>b__0(string x);
            }
        }

        class InventoryInterface
        {
            static /*0x0*/ System.Type s_typeCache;

            static /*0x7f540b4*/ System.Type GetClassType();
            static /*0x7f54190*/ System.Reflection.MethodInfo GetProductListMethod();
            static /*0x7f543f0*/ System.Reflection.MethodInfo GetPurchaseInfoMethod();
            static /*0x7f543a4*/ System.Reflection.MethodInfo HasPurchaseMethod();
        }

        class ProductInfoInterface
        {
            static /*0x0*/ System.Type s_typeCache;

            static /*0x7f56490*/ System.Type GetClassType();
            static /*0x7f542c0*/ System.Reflection.PropertyInfo GetCurrencyProp();
            static /*0x7f54274*/ System.Reflection.PropertyInfo GetDescriptionProp();
            static /*0x7f541dc*/ System.Reflection.PropertyInfo GetPriceProp();
            static /*0x7f5430c*/ System.Reflection.PropertyInfo GetPriceAmountMicrosProp();
            static /*0x7f54358*/ System.Reflection.PropertyInfo GetProductIdProp();
            static /*0x7f54228*/ System.Reflection.PropertyInfo GetTitleProp();
        }

        class StoreServiceInterface
        {
            static /*0x0*/ System.Type s_typeCache;

            static /*0x7f5656c*/ System.Type GetClassType();
            static /*0x7f56648*/ System.Reflection.PropertyInfo GetNameProp();
            static /*0x7f52a80*/ string GetName();
        }

        class UdpIapBridgeInterface
        {
            static /*0x0*/ System.Type s_typeCache;

            static /*0x7f52b94*/ System.Type GetClassType();
            static /*0x7f52d98*/ System.Reflection.MethodInfo GetInitMethod();
            static /*0x7f52f84*/ System.Reflection.MethodInfo GetPurchaseMethod();
            static /*0x7f5355c*/ System.Reflection.MethodInfo GetRetrieveProductsMethod();
            static /*0x7f536d0*/ System.Reflection.MethodInfo GetFinishTransactionMethod();
        }

        class UserInfoInterface
        {
            static /*0x0*/ System.Type s_typeCache;

            static /*0x7f55150*/ System.Type GetClassType();
        }

        class AppleJsonProductDescriptionsDeserializer : Stores.Util.JsonProductDescriptionsDeserializer
        {
            /*0x7f567a8*/ AppleJsonProductDescriptionsDeserializer();
            /*0x7f56698*/ UnityEngine.Purchasing.ProductMetadata DeserializeMetadata(System.Collections.Generic.Dictionary<string, object> data);
        }

        class AppleProductMetadata : UnityEngine.Purchasing.ProductMetadata
        {
            /*0x40*/ bool <isFamilyShareable>k__BackingField;

            /*0x7f56730*/ AppleProductMetadata(UnityEngine.Purchasing.ProductMetadata baseProductMetadata, string isFamilyShareable);
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

            static /*0x7f57a00*/ UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt FindMostRecentReceipt(UnityEngine.Purchasing.Security.AppleReceipt appleReceipt, string productId);
            static /*0x7f5852c*/ UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt FirstNonCancelledReceipt(UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt[] foundReceipts);
            static /*0x7f567b0*/ void MessageCallback(string subject, string payload, string receipt, string transactionId, string originalTransactionId, bool isRestored);
            static /*0x7f59ca8*/ bool IsValidPurchaseState(UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt mostRecentReceipt, string productId);
            static /*0x7f5a0d4*/ bool IsSubscriptionRestored(UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt productReceipt, UnityEngine.Purchasing.Product previousProduct);
            static /*0x7f5a0b4*/ bool IsNonSubscriptionRestored(string transactionId, string originalTransactionId);
            /*0x7f56984*/ AppleStoreImpl(Uniject.IUtil util, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics);
            /*0x7f56a58*/ void SetNativeStore(UnityEngine.Purchasing.INativeAppleStore apple);
            /*0x7f56b68*/ string get_appReceipt();
            /*0x7f56d64*/ System.Nullable<double> get_appReceiptModificationDate();
            /*0x7f56e40*/ bool get_canMakePayments();
            /*0x7f56ef0*/ string GetTransactionReceiptForProduct(UnityEngine.Purchasing.Product product);
            /*0x7f56fc8*/ void OnProductsRetrieved(string json);
            /*0x7f573a8*/ bool HasInAppPurchaseReceipts(UnityEngine.Purchasing.Security.AppleReceipt appleReceipt);
            /*0x7f573cc*/ System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> EnrichProductDescriptions(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> productDescriptions, UnityEngine.Purchasing.Security.AppleReceipt appleReceipt);
            /*0x7f585ec*/ void RestoreTransactions(System.Action<bool, string> callback);
            /*0x7f586ac*/ void RegisterPurchaseDeferredListener(System.Action<UnityEngine.Purchasing.Product> callback);
            /*0x7f586b4*/ void OnPurchaseDeferred(string productId);
            /*0x7f5879c*/ void OnPromotionalPurchaseAttempted(string productId);
            /*0x7f58884*/ void OnTransactionsRestoredSuccess();
            /*0x7f588d4*/ void OnTransactionsRestoredFail(string error);
            /*0x7f58934*/ void OnAppReceiptRetrieved(string receipt);
            /*0x7f58950*/ void OnAppReceiptRefreshedFailed(string error);
            /*0x7f5896c*/ void OnEntitlementsRevoked(string productIds);
            /*0x7f58c18*/ void RevokeEntitlement(UnityEngine.Purchasing.Security.AppleReceipt appleReceipt, string productId, System.Collections.Generic.List<UnityEngine.Purchasing.Product> revokedProducts, UnityEngine.Purchasing.Product product);
            /*0x7f58d20*/ bool RestoreActiveEntitlement(UnityEngine.Purchasing.Security.AppleReceipt appleReceipt, string productId);
            /*0x7f58e24*/ void OnFetchStorePromotionOrderSucceeded(string productIds);
            /*0x7f59120*/ void OnFetchStorePromotionOrderFailed();
            /*0x7f5913c*/ void OnFetchStorePromotionVisibilitySucceeded(string result);
            /*0x7f59410*/ void OnFetchStorePromotionVisibilityFailed();
            /*0x7f59434*/ void ProcessMessage(string subject, string payload, string receipt, string transactionId, string originalTransactionId, bool isRestored);
            /*0x7f59bb8*/ void OnPurchaseSucceeded(string id, string receipt, string transactionId, string originalTransactionId, bool isRestored);
            /*0x7f571dc*/ UnityEngine.Purchasing.Security.AppleReceipt GetAppleReceiptFromBase64String(string receipt);
            /*0x7f59dec*/ bool IsRestored(string productId, UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt productReceipt, string transactionId, string originalTransactionId);
            /*0x7f58438*/ void UpdateAppleProductFields(string id, string originalTransactionId, bool isRestored);

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.AppleStoreImpl.<> <>9;
                static /*0x8*/ System.Comparison<UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt> <>9__39_1;
                static /*0x10*/ System.Func<System.Collections.Generic.KeyValuePair<string, object>, string> <>9__62_0;
                static /*0x18*/ System.Func<System.Collections.Generic.KeyValuePair<string, object>, string> <>9__62_1;

                static /*0x7f5a54c*/ <>c();
                /*0x7f5a5b4*/ <>c();
                /*0x7f5a5bc*/ int <FindMostRecentReceipt>b__39_1(UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt b, UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt a);
                /*0x7f5a644*/ string <OnFetchStorePromotionVisibilitySucceeded>b__62_0(System.Collections.Generic.KeyValuePair<string, object> k);
                /*0x7f5a680*/ string <OnFetchStorePromotionVisibilitySucceeded>b__62_1(System.Collections.Generic.KeyValuePair<string, object> k);
            }

            class <>c__DisplayClass39_0
            {
                /*0x10*/ string productId;

                /*0x7f58524*/ <>c__DisplayClass39_0();
                /*0x7f5a6cc*/ bool <FindMostRecentReceipt>b__0(UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt r);
            }

            class <>c__DisplayClass64_0
            {
                /*0x10*/ string subject;
                /*0x18*/ string payload;
                /*0x20*/ string receipt;
                /*0x28*/ string transactionId;
                /*0x30*/ string originalTransactionId;
                /*0x38*/ bool isRestored;

                /*0x7f5942c*/ <>c__DisplayClass64_0();
                /*0x7f5a6f0*/ void <MessageCallback>b__0();
            }
        }

        class FakeAppleConfiguration : UnityEngine.Purchasing.IAppleConfiguration, UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
            /*0x7f5a764*/ FakeAppleConfiguration();
            /*0x7f5a75c*/ bool get_canMakePayments();
        }

        class FakeAppleExtensions : UnityEngine.Purchasing.IAppleExtensions, UnityEngine.Purchasing.IStoreExtension
        {
            /*0x7f5a7d0*/ FakeAppleExtensions();
            /*0x7f5a76c*/ void RestoreTransactions(System.Action<bool, string> callback);
            /*0x7f5a78c*/ void RegisterPurchaseDeferredListener(System.Action<UnityEngine.Purchasing.Product> callback);
            /*0x7f5a790*/ string GetTransactionReceiptForProduct(UnityEngine.Purchasing.Product product);
        }

        interface IAppleConfiguration : UnityEngine.Purchasing.Extension.IStoreConfiguration
        {
            /*0x3813ffc*/ bool get_canMakePayments();
        }

        interface IAppleExtensions : UnityEngine.Purchasing.IStoreExtension
        {
            /*0x3814a3c*/ string GetTransactionReceiptForProduct(UnityEngine.Purchasing.Product product);
            /*0x3816710*/ void RestoreTransactions(System.Action<bool, string> callback);
            /*0x3816710*/ void RegisterPurchaseDeferredListener(System.Action<UnityEngine.Purchasing.Product> callback);
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

            /*0x7f5a7d8*/ MetricizedAppleStoreImpl(Uniject.IUtil util, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics, UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService telemetryMetricsService);
            /*0x7f5a804*/ void RestoreTransactions(System.Action<bool, string> callback);
            /*0x7f5a98c*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x7f5ab14*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);
            /*0x7f5acb0*/ void <>n__4(System.Action<bool, string> callback);
            /*0x7f5acb4*/ void <>n__6(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x7f5ad6c*/ void <>n__7(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);

            class <>c__DisplayClass10_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedAppleStoreImpl <>4__this;
                /*0x18*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;

                /*0x7f5ab0c*/ <>c__DisplayClass10_0();
                /*0x7f5ae40*/ void <RetrieveProducts>b__0();
            }

            class <>c__DisplayClass11_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedAppleStoreImpl <>4__this;
                /*0x18*/ UnityEngine.Purchasing.ProductDefinition product;
                /*0x20*/ string developerPayload;

                /*0x7f5aca8*/ <>c__DisplayClass11_0();
                /*0x7f5ae60*/ void <Purchase>b__0();
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedAppleStoreImpl <>4__this;
                /*0x18*/ System.Action<bool, string> callback;

                /*0x7f5a984*/ <>c__DisplayClass6_0();
                /*0x7f5ae80*/ void <RestoreTransactions>b__0();
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
            /*0x3814a3c*/ UnityEngine.Purchasing.INativeAppleStore GetStorekit(UnityEngine.Purchasing.IUnityCallback callback);
        }

        interface IStoreInternal
        {
            /*0x3816710*/ void SetModule(UnityEngine.Purchasing.StandardPurchasingModule module);
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

            /*0x7f54d5c*/ JSONStore();
            /*0x7f5aea0*/ void SetNativeStore(UnityEngine.Purchasing.INativeStore native);
            /*0x7f5aea8*/ void UnityEngine.Purchasing.IStoreInternal.SetModule(UnityEngine.Purchasing.StandardPurchasingModule module);
            /*0x7f5af68*/ void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback callback);
            /*0x7f5acb8*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x7f5ad70*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);
            /*0x7f59fe0*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId);
            /*0x7f59a5c*/ void OnSetupFailed(string reason);
            /*0x7f5aff0*/ void OnProductsRetrieved(string json);
            /*0x7f59f1c*/ void OnPurchaseSucceeded(string id, string receipt, string transactionID);
            /*0x7f59c78*/ void OnPurchaseFailed(string json);
            /*0x7f5b0b0*/ void OnPurchaseFailed(UnityEngine.Purchasing.Extension.PurchaseFailureDescription failure, string json);
            /*0x7f5b184*/ UnityEngine.Purchasing.StoreSpecificPurchaseErrorCode ParseStoreSpecificPurchaseErrorCode(string json);
        }

        class MetricizedJsonStore : UnityEngine.Purchasing.JSONStore
        {
            /*0x48*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService m_TelemetryMetricsService;

            /*0x7f5b3c0*/ MetricizedJsonStore(UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService telemetryMetricsService);
            /*0x7f5b3ec*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x7f5b574*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);
            /*0x7f5b710*/ void <>n__0(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
            /*0x7f5b714*/ void <>n__1(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedJsonStore <>4__this;
                /*0x18*/ System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products;

                /*0x7f5b56c*/ <>c__DisplayClass2_0();
                /*0x7f5b718*/ void <RetrieveProducts>b__0();
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Purchasing.MetricizedJsonStore <>4__this;
                /*0x18*/ UnityEngine.Purchasing.ProductDefinition product;
                /*0x20*/ string developerPayload;

                /*0x7f5b708*/ <>c__DisplayClass3_0();
                /*0x7f5b738*/ void <Purchase>b__0();
            }
        }

        class NativeStoreProvider : UnityEngine.Purchasing.INativeStoreProvider
        {
            /*0x7f5bf58*/ NativeStoreProvider();
            /*0x7f5b758*/ UnityEngine.Purchasing.INativeStore GetAndroidStore(UnityEngine.Purchasing.IUnityCallback callback, UnityEngine.Purchasing.AppStore store, UnityEngine.Purchasing.Extension.IPurchasingBinder binder, Uniject.IUtil util);
            /*0x7f5b888*/ UnityEngine.Purchasing.INativeStore GetAndroidStoreHelper(UnityEngine.Purchasing.IUnityCallback callback, UnityEngine.Purchasing.AppStore store, UnityEngine.Purchasing.Extension.IPurchasingBinder binder, Uniject.IUtil util);
            /*0x7f5be84*/ UnityEngine.Purchasing.INativeAppleStore GetStorekit(UnityEngine.Purchasing.IUnityCallback callback);
        }

        class DialogRequest
        {
            /*0x10*/ string QueryText;
            /*0x18*/ string OkayButtonText;
            /*0x20*/ string CancelButtonText;
            /*0x28*/ System.Collections.Generic.List<string> Options;
            /*0x30*/ System.Action<bool, int> Callback;

            /*0x7f5bf60*/ DialogRequest();
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

            /*0x7f5d3cc*/ FakeStore();
            /*0x7f5bf68*/ string get_unavailableProductId();
            /*0x7f5bf70*/ void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback biller);
            /*0x7f5bfac*/ void RetrieveProducts(string json);
            /*0x7f5c0c4*/ void StoreRetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> productDefinitions);
            /*0x7f5ccc0*/ void Purchase(string productJSON, string developerPayload);
            /*0x7f5cf74*/ void FakePurchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);
            /*0x7f5d3c4*/ void FinishTransaction(string productJSON, string transactionID);
            /*0x7f5d3c8*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId);
            bool StartUI<T>(object model, UnityEngine.Purchasing.FakeStore.DialogType dialogType, System.Action<bool, T> callback);
            /*0x7f5d450*/ void <>n__0(string id, string receipt, string transactionID);

            enum DialogType
            {
                Purchase = 0,
                RetrieveProducts = 1,
            }

            class <>c__DisplayClass13_0
            {
                /*0x10*/ UnityEngine.Purchasing.FakeStore <>4__this;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products;

                /*0x7f5caa8*/ <>c__DisplayClass13_0();
                /*0x7f5cb7c*/ void <StoreRetrieveProducts>g__handleAllowInitializeOrRetrieveProducts|0(bool allow, UnityEngine.Purchasing.InitializationFailureReason failureReason);
            }

            class <>c__DisplayClass15_0
            {
                /*0x10*/ UnityEngine.Purchasing.FakeStore <>4__this;
                /*0x18*/ UnityEngine.Purchasing.ProductDefinition product;

                /*0x7f5d1ec*/ <>c__DisplayClass15_0();
                /*0x7f5d1f4*/ void <FakePurchase>g__handleAllowPurchase|0(bool allow, UnityEngine.Purchasing.PurchaseFailureReason failureReason);
            }
        }

        class LifecycleNotifier : UnityEngine.MonoBehaviour
        {
            /*0x20*/ System.Action OnDestroyCallback;

            /*0x7f5d470*/ LifecycleNotifier();
            /*0x7f5d454*/ void OnDestroy();
        }

        class UIFakeStore : UnityEngine.Purchasing.FakeStore
        {
            /*0x70*/ UnityEngine.Purchasing.DialogRequest m_CurrentDialog;
            /*0x78*/ int m_LastSelectedDropdownIndex;
            /*0x80*/ UnityEngine.GameObject m_UIFakeStoreWindowObject;
            /*0x88*/ UnityEngine.GameObject m_EventSystem;

            /*0x7f5d478*/ UIFakeStore();
            bool StartUI<T>(object model, UnityEngine.Purchasing.FakeStore.DialogType dialogType, System.Action<bool, T> callback);
            /*0x7f5d47c*/ bool StartUI(string queryText, string okayButtonText, string cancelButtonText, System.Collections.Generic.List<string> options, System.Action<bool, int> callback);
            /*0x7f5d590*/ void InstantiateDialog();
            /*0x7f5d67c*/ UnityEngine.Purchasing.UIFakeStoreWindow GetOrCreateFakeStoreWindow();
            /*0x7f5d82c*/ void AddLifeCycleNotifierAndSetDestroyCallback(UnityEngine.GameObject gameObject);
            /*0x7f5d8e8*/ void EnsureEventSystemCreated(UnityEngine.Transform rootTransform);
            /*0x7f5d988*/ void ConfigureDialogWindow(UnityEngine.Purchasing.UIFakeStoreWindow dialogWindow);
            /*0x7f5dcc4*/ void ConfigureDialogWindowCallbacks(UnityEngine.Purchasing.UIFakeStoreWindow dialogWindow, bool assignCancelCallback, bool assignDropDownCallback);
            /*0x7f5d9fc*/ void CreateEventSystem(UnityEngine.Transform rootTransform);
            /*0x7f5de50*/ string CreatePurchaseQuestion(UnityEngine.Purchasing.ProductDefinition definition);
            /*0x7f5debc*/ string CreateRetrieveProductsQuestion(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> definitions);
            /*0x7f5e0e0*/ void OkayButtonClicked();
            /*0x7f5e234*/ void CancelButtonClicked();
            /*0x7f5e2c8*/ void DropdownValueChanged(int selectedItem);
            /*0x7f5e190*/ void CloseDialog();
            /*0x7f5d580*/ bool IsShowingDialog();
            /*0x7f5e2d0*/ void <AddLifeCycleNotifierAndSetDestroyCallback>b__14_0();

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.UIFakeStore.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.Purchasing.ProductDefinition, string> <>9__20_0;

                static /*0x7f5e2dc*/ <>c();
                /*0x7f5e344*/ <>c();
                /*0x7f5e34c*/ string <CreateRetrieveProductsQuestion>b__20_0(UnityEngine.Purchasing.ProductDefinition pid);
            }

            class <>c__DisplayClass10_0<T>
            {
                /*0x0*/ System.Action<bool, T> callback;

                /*0x38159dc*/ <>c__DisplayClass10_0();
                void <StartUI>b__0(bool result, int codeValue);
            }
        }

        class UIFakeStoreDropdown
        {
            /*0x10*/ System.Collections.Generic.List<string> m_Options;
            /*0x18*/ System.Action<int, string> m_OnDropdown;
            /*0x20*/ UnityEngine.Vector2 scrollPosition;

            /*0x7f5e714*/ UIFakeStoreDropdown();
            /*0x7f5e364*/ void DoPopup(int windowID);
            /*0x7f5e600*/ void OnOptionSelected(int optionIndex);
            /*0x7f5e688*/ void SetOptions(System.Collections.Generic.List<string> options);
            /*0x7f5e70c*/ void SetSelectionAction(System.Action<int, string> onDropdown);
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

            /*0x7f5ecb4*/ UIFakeStoreWindow();
            /*0x7f5e71c*/ void OnGUI();
            /*0x7f5e890*/ UnityEngine.Rect CreateCenteredWindowRect();
            /*0x7f5e904*/ void DoMainGUI(int windowID);
            /*0x7f5ec20*/ void DoDropDown();
            /*0x7f5ec2c*/ void OnOkClicked();
            /*0x7f5ec48*/ void OnCancelClicked();
            /*0x7f5db80*/ void ConfigureMainDialogText(string queryText, string okText, string cancelText);
            /*0x7f5dbc4*/ void ConfigureDropdownOptions(System.Collections.Generic.List<string> options);
            /*0x7f5ec64*/ void OnDropdown(int index, string selectionText);
            /*0x7f5ddf4*/ void AssignCallbacks(System.Action onOk, System.Action onCancel, System.Action<int> onDropdown);
        }

        class Price : UnityEngine.ISerializationCallbackReceiver
        {
            /*0x10*/ decimal value;
            /*0x20*/ int[] data;
            /*0x28*/ double num;

            /*0x7f5ee10*/ Price();
            /*0x7f5ed20*/ void OnBeforeSerialize();
            /*0x7f5eda4*/ void OnAfterDeserialize();
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

            static /*0x7f5ee18*/ string DecodeNonLatinCharacters(string s);
            /*0x7f5ef60*/ LocalizedProductDescription();
            /*0x7f5cb6c*/ string get_Title();
            /*0x7f5cb74*/ string get_Description();

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.LocalizedProductDescription.<> <>9;
                static /*0x8*/ System.Text.RegularExpressions.MatchEvaluator <>9__11_0;

                static /*0x7f5ef70*/ <>c();
                /*0x7f5efd8*/ <>c();
                /*0x7f5efe0*/ string <DecodeNonLatinCharacters>b__11_0(System.Text.RegularExpressions.Match m);
            }
        }

        class ProductCatalogPayout
        {
            /*0x10*/ string t;
            /*0x18*/ string st;
            /*0x20*/ string d;

            /*0x7f5f090*/ ProductCatalogPayout();

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

            /*0x7f5f148*/ ProductCatalogItem();
        }

        class ProductCatalog
        {
            static /*0x0*/ UnityEngine.Purchasing.IProductCatalogImpl instance;
            /*0x10*/ bool enableCodelessAutoInitialization;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Purchasing.ProductCatalogItem> products;

            static /*0x7f5f324*/ void Initialize();
            static /*0x7f5f3e4*/ void Initialize(UnityEngine.Purchasing.IProductCatalogImpl productCatalogImpl);
            static /*0x7f5f43c*/ UnityEngine.Purchasing.ProductCatalog Deserialize(string catalogJSON);
            static /*0x7f5f484*/ UnityEngine.Purchasing.ProductCatalog FromTextAsset(UnityEngine.TextAsset asset);
            static /*0x7f5cab0*/ UnityEngine.Purchasing.ProductCatalog LoadDefaultCatalog();
            /*0x7f5f4a0*/ ProductCatalog();
            /*0x7f5f31c*/ System.Collections.Generic.ICollection<UnityEngine.Purchasing.ProductCatalogItem> get_allProducts();
        }

        interface IProductCatalogImpl
        {
            /*0x38148bc*/ UnityEngine.Purchasing.ProductCatalog LoadDefaultCatalog();
        }

        class ProductCatalogImpl : UnityEngine.Purchasing.IProductCatalogImpl
        {
            /*0x7f5f3dc*/ ProductCatalogImpl();
            /*0x7f5f530*/ UnityEngine.Purchasing.ProductCatalog LoadDefaultCatalog();
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

            static /*0x7f615a8*/ StandardPurchasingModule();
            static /*0x7f5f7a8*/ UnityEngine.Purchasing.StandardPurchasingModule Instance();
            static /*0x7f5f7f8*/ UnityEngine.Purchasing.StandardPurchasingModule Instance(UnityEngine.Purchasing.AppStore androidStore);
            static /*0x7f612c0*/ UnityEngine.Purchasing.GooglePlayConfiguration BuildGooglePlayStoreConfiguration(UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService googlePlayStoreService, UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback googlePurchaseCallback, UnityEngine.Purchasing.Interfaces.IGoogleProductCallback googleProductCallback);
            /*0x7f5f684*/ StandardPurchasingModule(Uniject.IUtil util, UnityEngine.ILogger logger, UnityEngine.Purchasing.INativeStoreProvider nativeStoreProvider, UnityEngine.RuntimePlatform platform, UnityEngine.Purchasing.AppStore android, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper telemetryDiagnosticsInstanceWrapper, UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper);
            /*0x7f5f634*/ Uniject.IUtil get_util();
            /*0x7f5f63c*/ void set_util(Uniject.IUtil value);
            /*0x7f5f644*/ UnityEngine.ILogger get_logger();
            /*0x7f5f64c*/ void set_logger(UnityEngine.ILogger value);
            /*0x7f5f654*/ UnityEngine.Purchasing.StandardPurchasingModule.StoreInstance get_storeInstance();
            /*0x7f5f65c*/ void set_storeInstance(UnityEngine.Purchasing.StandardPurchasingModule.StoreInstance value);
            /*0x7f5f664*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper get_telemetryMetricsInstanceWrapper();
            /*0x7f5f66c*/ void set_telemetryMetricsInstanceWrapper(UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper value);
            /*0x7f5f674*/ UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper get_telemetryDiagnosticsInstanceWrapper();
            /*0x7f5f67c*/ void set_telemetryDiagnosticsInstanceWrapper(UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper value);
            /*0x7f5f774*/ UnityEngine.Purchasing.AppStore get_appStore();
            /*0x7f5f77c*/ void set_appStore(UnityEngine.Purchasing.AppStore value);
            /*0x7f5f784*/ UnityEngine.Purchasing.FakeStoreUIMode get_useFakeStoreUIMode();
            /*0x7f5f78c*/ void set_useFakeStoreUIMode(UnityEngine.Purchasing.FakeStoreUIMode value);
            /*0x7f5f794*/ bool get_useFakeStoreAlways();
            /*0x7f5f79c*/ void set_useFakeStoreAlways(bool value);
            /*0x7f5fdbc*/ void Configure();
            /*0x7f6037c*/ UnityEngine.Purchasing.StandardPurchasingModule.StoreInstance InstantiateStore();
            /*0x7f608f0*/ UnityEngine.Purchasing.Extension.IStore InstantiateAndroid();
            /*0x7f60b18*/ UnityEngine.Purchasing.Extension.IStore InstantiateGoogleStore();
            /*0x7f61488*/ void BindGoogleExtension(UnityEngine.Purchasing.GooglePlayStoreExtensions googlePlayStoreExtensions);
            /*0x7f61430*/ void BindGoogleConfiguration(UnityEngine.Purchasing.GooglePlayConfiguration googlePlayConfiguration);
            /*0x7f60f14*/ UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService BuildAndInitGooglePlayStoreServiceAar(UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback googlePurchaseCallback, UnityEngine.Purchasing.Interfaces.IGoogleProductCallback googleProductCallback, UnityEngine.Purchasing.Interfaces.IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider);
            /*0x7f6080c*/ UnityEngine.Purchasing.Extension.IStore InstantiateUDP();
            /*0x7f60ee4*/ UnityEngine.Purchasing.Extension.IStore InstantiateAndroidHelper(UnityEngine.Purchasing.JSONStore store);
            /*0x7f614e0*/ UnityEngine.Purchasing.INativeStore GetAndroidNativeStore(UnityEngine.Purchasing.JSONStore store);
            /*0x7f60678*/ UnityEngine.Purchasing.Extension.IStore InstantiateApple();
            /*0x7f609b0*/ UnityEngine.Purchasing.Extension.IStore instantiateWindowsStore();
            /*0x7f6059c*/ UnityEngine.Purchasing.Extension.IStore InstantiateFakeStore();

            class StoreInstance
            {
                /*0x10*/ string <storeName>k__BackingField;
                /*0x18*/ UnityEngine.Purchasing.Extension.IStore <instance>k__BackingField;

                /*0x7f60634*/ StoreInstance(string name, UnityEngine.Purchasing.Extension.IStore instance);
                /*0x7f616d0*/ string get_storeName();
                /*0x7f616d8*/ UnityEngine.Purchasing.Extension.IStore get_instance();
            }

            class MicrosoftConfiguration : UnityEngine.Purchasing.IMicrosoftConfiguration, UnityEngine.Purchasing.Extension.IStoreConfiguration
            {
                /*0x10*/ UnityEngine.Purchasing.StandardPurchasingModule module;

                /*0x7f6034c*/ MicrosoftConfiguration(UnityEngine.Purchasing.StandardPurchasingModule module);
            }
        }

        class StoreConfiguration
        {
            /*0x10*/ UnityEngine.Purchasing.AppStore <androidStore>k__BackingField;

            static /*0x7f5fb74*/ UnityEngine.Purchasing.StoreConfiguration Deserialize(string json);
            /*0x7f616f0*/ StoreConfiguration(UnityEngine.Purchasing.AppStore store);
            /*0x7f616e0*/ UnityEngine.Purchasing.AppStore get_androidStore();
            /*0x7f616e8*/ void set_androidStore(UnityEngine.Purchasing.AppStore value);
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

            /*0x7f61718*/ TimeSpanUnits(double d, int m, int y);
        }

        class SubscriptionManager
        {
            /*0x10*/ string receipt;
            /*0x18*/ string productId;
            /*0x20*/ string intro_json;

            /*0x7f5a218*/ SubscriptionManager(UnityEngine.Purchasing.Product product, string intro_json);
            /*0x7f5a27c*/ UnityEngine.Purchasing.SubscriptionInfo getSubscriptionInfo();
            /*0x7f62240*/ UnityEngine.Purchasing.SubscriptionInfo getAmazonAppStoreSubInfo(string productId);
            /*0x7f61dac*/ UnityEngine.Purchasing.SubscriptionInfo getAppleAppStoreSubInfo(string payload, string productId);
            /*0x7f6235c*/ UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt findMostRecentReceipt(System.Collections.Generic.List<UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt> receipts);
            /*0x7f61754*/ UnityEngine.Purchasing.SubscriptionInfo getGooglePlayStoreSubInfo(string payload);

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.SubscriptionManager.<> <>9;
                static /*0x8*/ System.Comparison<UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt> <>9__11_0;
                static /*0x10*/ System.Func<object, string> <>9__12_0;

                static /*0x7f62cc4*/ <>c();
                /*0x7f62d2c*/ <>c();
                /*0x7f62d34*/ int <findMostRecentReceipt>b__11_0(UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt b, UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt a);
                /*0x7f62dbc*/ string <getGooglePlayStoreSubInfo>b__12_0(object obj);
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

            /*0x7f57bd4*/ SubscriptionInfo(UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt r, string intro_json);
            /*0x7f62480*/ SubscriptionInfo(string skuDetails, bool isAutoRenewing, System.DateTime purchaseDate, bool isFreeTrial, bool hasIntroductoryPriceTrial, bool purchaseHistorySupported, string updateMetadata);
            /*0x7f62298*/ SubscriptionInfo(string productId);
            /*0x7f63670*/ UnityEngine.Purchasing.Result isExpired();
            /*0x7f63678*/ UnityEngine.Purchasing.Result isCancelled();
            /*0x7f63680*/ System.DateTime getExpireDate();
            /*0x7f6352c*/ System.DateTime nextBillingDate(System.DateTime billing_begin_date, UnityEngine.Purchasing.TimeSpanUnits units);
            /*0x7f63224*/ System.TimeSpan accumulateIntroductoryDuration(UnityEngine.Purchasing.TimeSpanUnits units, long cycles);
            /*0x7f63014*/ System.TimeSpan computePeriodTimeSpan(UnityEngine.Purchasing.TimeSpanUnits units);
            /*0x7f632d8*/ double computeExtraTime(string metadata, double new_sku_period_in_seconds);
            /*0x7f630d0*/ System.TimeSpan parseTimeSpan(string period_string);
            /*0x7f62de4*/ UnityEngine.Purchasing.TimeSpanUnits parsePeriodTimeSpanUnits(string time_span);
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
            /*0x7f63688*/ ReceiptParserException();
            /*0x7f636e0*/ ReceiptParserException(string message);
        }

        class InvalidProductTypeException : UnityEngine.Purchasing.ReceiptParserException
        {
            /*0x7f63748*/ InvalidProductTypeException();
        }

        class NullProductIdException : UnityEngine.Purchasing.ReceiptParserException
        {
            /*0x7f6374c*/ NullProductIdException();
        }

        class NullReceiptException : UnityEngine.Purchasing.ReceiptParserException
        {
            /*0x7f63750*/ NullReceiptException();
        }

        class StoreSubscriptionInfoNotSupportedException : UnityEngine.Purchasing.ReceiptParserException
        {
            /*0x7f63754*/ StoreSubscriptionInfoNotSupportedException(string message);
        }

        class FakeTransactionHistoryExtensions : UnityEngine.Purchasing.ITransactionHistoryExtensions, UnityEngine.Purchasing.IStoreExtension
        {
            /*0x7f63758*/ FakeTransactionHistoryExtensions();
        }

        interface ITransactionHistoryExtensions : UnityEngine.Purchasing.IStoreExtension
        {
        }

        class EnumerableExtensions
        {
            static /*0x38379c4*/ System.Collections.Generic.IEnumerable<T> NonNull<T>(System.Collections.Generic.IEnumerable<T> enumerable);
            static /*0x38395d4*/ System.Collections.Generic.IEnumerable<T> IgnoreExceptions<T, TException>(System.Collections.Generic.IEnumerable<T> enumerable, System.Action<TException> onException);

            class <>c__0<T>
            {
                static /*0x0*/ UnityEngine.Purchasing.EnumerableExtensions.<>c__0<T> <>9;
                static /*0x0*/ System.Func<T, bool> <>9__0_0;

                static /*0x383e7a0*/ <>c__0();
                /*0x38159dc*/ <>c__0();
                /*0x3910ae8*/ bool <NonNull>b__0_0(T obj);
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

                /*0x3815ed0*/ <IgnoreExceptions>d__1(int <>1__state);
                /*0x38159dc*/ void System.IDisposable.Dispose();
                /*0x3813ffc*/ bool MoveNext();
                /*0x38159dc*/ void <>m__Finally1();
                /*0x3910ae8*/ T System.Collections.Generic.IEnumerator<T>.get_Current();
                /*0x38159dc*/ void System.Collections.IEnumerator.Reset();
                /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
                /*0x38148bc*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class ExponentialRetryPolicy : UnityEngine.Purchasing.Stores.Util.IRetryPolicy
        {
            /*0x10*/ int m_BaseRetryDelay;
            /*0x14*/ int m_MaxRetryDelay;
            /*0x18*/ int m_ExponentialFactor;

            /*0x7f63760*/ ExponentialRetryPolicy(int baseRetryDelay, int maxRetryDelay, int exponentialFactor);
            /*0x7f6379c*/ void Invoke(System.Action<System.Action> actionToTry, System.Action onRetryAction);
            /*0x7f638b0*/ int AdjustDelay(int delay);

            class <>c__DisplayClass4_0
            {
                /*0x10*/ System.Action onRetryAction;
                /*0x18*/ int currentRetryDelay;
                /*0x20*/ UnityEngine.Purchasing.ExponentialRetryPolicy <>4__this;
                /*0x28*/ System.Action<System.Action> actionToTry;

                /*0x7f638a8*/ <>c__DisplayClass4_0();
                /*0x7f6391c*/ void <Invoke>g__Retry|0();
                /*0x7f639d0*/ System.Threading.Tasks.Task <Invoke>g__WaitAndRetry|1();

                struct <<Invoke>g__Retry|0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                    /*0x38*/ UnityEngine.Purchasing.ExponentialRetryPolicy.<> <>4__this;
                    /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                    /*0x7f63ab4*/ void MoveNext();
                    /*0x7f63c58*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <<Invoke>g__WaitAndRetry|1>d : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ UnityEngine.Purchasing.ExponentialRetryPolicy.<> <>4__this;
                    /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                    /*0x7f63c64*/ void MoveNext();
                    /*0x7f63f10*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }
        }

        class GoogleConnectionRetryPolicy : UnityEngine.Purchasing.Stores.Util.IRetryPolicy
        {
            /*0x10*/ int m_BaseRetryDelay;
            /*0x14*/ int m_MaxRetryDelay;
            /*0x18*/ int m_ExponentialFactor;

            /*0x7f63f78*/ GoogleConnectionRetryPolicy(int baseRetryDelay, int maxRetryDelay, int exponentialFactor);
            /*0x7f63fb4*/ void Invoke(System.Action<System.Action> actionToTry, System.Action onRetryAction);
            /*0x7f6411c*/ int AdjustDelay(int delay);

            class <>c__DisplayClass4_0
            {
                /*0x10*/ int currentRetryDelay;
                /*0x18*/ UnityEngine.Purchasing.GoogleConnectionRetryPolicy <>4__this;
                /*0x20*/ System.Action<System.Action> actionToTry;
                /*0x28*/ System.Action onRetryAction;
                /*0x30*/ int retryAttempts;

                /*0x7f64060*/ <>c__DisplayClass4_0();
                /*0x7f64068*/ void <Invoke>g__WaitAndRetry|0();

                struct <<Invoke>g__WaitAndRetry|0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                    /*0x38*/ UnityEngine.Purchasing.GoogleConnectionRetryPolicy.<> <>4__this;
                    /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                    /*0x7f64188*/ void MoveNext();
                    /*0x7f64404*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }
        }

        class ProductDefinitionExtensions
        {
            static /*0x7f64410*/ System.Collections.Generic.List<UnityEngine.Purchasing.ProductDefinition> DecodeJSON(System.Collections.Generic.List<object> productsList, string storeName);
        }

        class FakeMicrosoftExtensions : UnityEngine.Purchasing.IMicrosoftExtensions, UnityEngine.Purchasing.IStoreExtension
        {
            /*0x7f64b60*/ FakeMicrosoftExtensions();
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

            /*0x7f64b68*/ WinRTStore(UnityEngine.Purchasing.Default.IWindowsIAP win8, Uniject.IUtil util, UnityEngine.ILogger logger);
            /*0x7f64bc8*/ void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback biller);
            /*0x7f64bd0*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> productDefs);
            /*0x7f64f48*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId);
            /*0x7f64e38*/ void init(int delay);
            /*0x7f64ff4*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);
            /*0x7f650a8*/ void restoreTransactions(bool pausing);

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.WinRTStore.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.Purchasing.ProductDefinition, bool> <>9__8_0;
                static /*0x10*/ System.Func<UnityEngine.Purchasing.ProductDefinition, UnityEngine.Purchasing.Default.WinProductDescription> <>9__8_1;

                static /*0x7f6516c*/ <>c();
                /*0x7f651d4*/ <>c();
                /*0x7f651dc*/ bool <RetrieveProducts>b__8_0(UnityEngine.Purchasing.ProductDefinition def);
                /*0x7f651fc*/ UnityEngine.Purchasing.Default.WinProductDescription <RetrieveProducts>b__8_1(UnityEngine.Purchasing.ProductDefinition def);
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

                static /*0x7f66098*/ UnityUtil();
                static /*0x3910ae8*/ T FindInstanceOfType<T>();
                static /*0x3910ae8*/ T LoadResourceInstanceOfType<T>();
                static /*0x7f65a0c*/ bool PcPlatform();
                /*0x7f66010*/ UnityUtil();
                /*0x38148bc*/ T[] GetAnyComponentsOfType<T>();
                /*0x7f6536c*/ System.DateTime get_currentTime();
                /*0x7f653bc*/ string get_persistentDataPath();
                /*0x7f6540c*/ string get_deviceUniqueIdentifier();
                /*0x7f65414*/ string get_unityVersion();
                /*0x7f65464*/ string get_cloudProjectId();
                /*0x7f654b4*/ string get_userId();
                /*0x7f6550c*/ string get_gameVersion();
                /*0x7f6555c*/ ulong get_sessionId();
                /*0x7f655c0*/ UnityEngine.RuntimePlatform get_platform();
                /*0x7f65610*/ bool get_isEditor();
                /*0x7f65660*/ string get_deviceModel();
                /*0x7f65668*/ string get_deviceName();
                /*0x7f65670*/ UnityEngine.DeviceType get_deviceType();
                /*0x7f65678*/ string get_operatingSystem();
                /*0x7f65680*/ int get_screenWidth();
                /*0x7f65688*/ int get_screenHeight();
                /*0x7f65690*/ float get_screenDpi();
                /*0x7f65698*/ string get_screenOrientation();
                /*0x7f65700*/ object Uniject.IUtil.InitiateCoroutine(System.Collections.IEnumerator start);
                /*0x7f65708*/ void Uniject.IUtil.InitiateCoroutine(System.Collections.IEnumerator start, int delay);
                /*0x7f6579c*/ void RunOnMainThread(System.Action runnable);
                /*0x7f65944*/ object GetWaitForSeconds(int seconds);
                /*0x7f659a0*/ void Start();
                /*0x7f6570c*/ System.Collections.IEnumerator DelayedCoroutine(System.Collections.IEnumerator coroutine, int delay);
                /*0x7f65ae4*/ void Update();
                /*0x7f65d94*/ void AddPauseListener(System.Action<bool> runnable);
                /*0x7f65e40*/ void OnApplicationPause(bool paused);
                /*0x7f65fa0*/ bool IsClassOrSubclass(System.Type potentialBase, System.Type potentialDescendant);

                class <DelayedCoroutine>d__48 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ int delay;
                    /*0x28*/ UnityEngine.Purchasing.Extension.UnityUtil <>4__this;
                    /*0x30*/ System.Collections.IEnumerator coroutine;

                    /*0x7f65abc*/ <DelayedCoroutine>d__48(int <>1__state);
                    /*0x7f66388*/ void System.IDisposable.Dispose();
                    /*0x7f6638c*/ bool MoveNext();
                    /*0x7f66448*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x7f66450*/ void System.Collections.IEnumerator.Reset();
                    /*0x7f66488*/ object System.Collections.IEnumerator.get_Current();
                }
            }
        }

        namespace Stores
        {
            namespace Util
            {
                interface IRetryPolicy
                {
                    /*0x3816810*/ void Invoke(System.Action<System.Action> actionToTry, System.Action onRetryAction);
                }
            }
        }

        namespace Registration
        {
            class IapCoreInitializeCallback : Unity.Services.Core.Internal.IInitializablePackage
            {
                static /*0x7f66490*/ void Register();
                static /*0x7f66834*/ void CacheInitializedEnvironment(Unity.Services.Core.Internal.CoreRegistry registry);
                static /*0x7f66860*/ string GetCurrentEnvironment(Unity.Services.Core.Internal.CoreRegistry registry);
                static /*0x7f669a8*/ void InitializeTelemetryComponents(UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper metricsInstanceWrapper, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper diagnosticsInstanceWrapper);
                /*0x7f665cc*/ IapCoreInitializeCallback();
                /*0x7f665d4*/ System.Threading.Tasks.Task Initialize(Unity.Services.Core.Internal.CoreRegistry registry);

                class <>c__DisplayClass2_0
                {
                    /*0x10*/ Unity.Services.Core.Internal.CoreRegistry registry;
                    /*0x18*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper metricsInstanceWrapper;
                    /*0x20*/ UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper diagnosticsInstanceWrapper;

                    /*0x7f6682c*/ <>c__DisplayClass2_0();
                    /*0x7f66c80*/ void <Initialize>b__0();
                }
            }
        }

        namespace Utils
        {
            class GooglePurchaseBuilder : UnityEngine.Purchasing.Interfaces.IGooglePurchaseBuilder
            {
                /*0x10*/ UnityEngine.Purchasing.IGoogleCachedQueryProductDetailsService m_CachedQueryProductDetailsService;
                /*0x18*/ UnityEngine.ILogger m_Logger;

                static /*0x7f67428*/ System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> TryFindAllProductDetails(System.Collections.Generic.IEnumerable<string> skus, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails);
                /*0x7f66c9c*/ GooglePurchaseBuilder(UnityEngine.Purchasing.IGoogleCachedQueryProductDetailsService cachedQueryProductDetailsService, UnityEngine.ILogger logger);
                /*0x7f66ce0*/ System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> BuildPurchases(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> purchases);
                /*0x7f66e10*/ void LogWarningForException(System.Exception exception);
                /*0x7f66e48*/ UnityEngine.Purchasing.Interfaces.IGooglePurchase BuildPurchase(UnityEngine.AndroidJavaObject purchase);

                class <>c__DisplayClass6_0
                {
                    /*0x10*/ System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails;

                    /*0x7f67db8*/ <>c__DisplayClass6_0();
                    /*0x7f67dc0*/ UnityEngine.AndroidJavaObject <TryFindAllProductDetails>b__0(string sku);
                }

                class <>c__DisplayClass6_1
                {
                    /*0x10*/ string sku;

                    /*0x7f67ea8*/ <>c__DisplayClass6_1();
                    /*0x7f67eb0*/ bool <TryFindAllProductDetails>b__1(UnityEngine.AndroidJavaObject productDetail);
                }
            }

            class GoogleReceiptEncoder
            {
                static /*0x7f67f9c*/ string EncodeReceipt(string purchaseOriginalJson, string purchaseSignature, System.Collections.Generic.List<string> productDetailsJson);
            }

            class ProductDetailsConverter : UnityEngine.Purchasing.Interfaces.IProductDetailsConverter
            {
                static /*0x7f68174*/ UnityEngine.Purchasing.Extension.ProductDescription ToProductDescription(UnityEngine.AndroidJavaObject productDetails);
                static /*0x7f68218*/ UnityEngine.Purchasing.Extension.ProductDescription BuildProductDescription(UnityEngine.AndroidJavaObject productDetails);
                /*0x7f69bb8*/ ProductDetailsConverter();
                /*0x7f680b8*/ System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> ConvertOnQueryProductDetailsResponse(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails);
            }
        }

        namespace Interfaces
        {
            interface IBillingClientStateListener
            {
                /*0x3816710*/ void RegisterOnConnected(System.Action onConnected);
                /*0x3816710*/ void RegisterOnDisconnected(System.Action<UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onDisconnected);
            }

            interface IGoogleBillingClient
            {
                /*0x3816710*/ void StartConnection(UnityEngine.Purchasing.Interfaces.IBillingClientStateListener billingClientStateListener);
                /*0x3814574*/ UnityEngine.Purchasing.GoogleBillingConnectionState GetConnectionState();
                /*0x3816810*/ void QueryPurchasesAsync(string skuType, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> onQueryPurchasesResponse);
                /*0x3816920*/ void QueryProductDetailsAsync(System.Collections.Generic.List<string> skus, string type, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onProductDetailsResponseAction);
                UnityEngine.AndroidJavaObject LaunchBillingFlow(UnityEngine.AndroidJavaObject productDetails, string oldPurchaseToken, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> prorationMode);
                /*0x3816810*/ void ConsumeAsync(string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onConsume);
                /*0x3816810*/ void AcknowledgePurchase(string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onAcknowledge);
            }

            interface IGoogleFinishTransactionService
            {
                /*0x3816920*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished);
            }

            interface IGoogleLastKnownProductService
            {
                /*0x38148bc*/ string get_LastKnownOldProductId();
                /*0x3816710*/ void set_LastKnownOldProductId(string value);
                /*0x38148bc*/ string get_LastKnownProductId();
                /*0x3816710*/ void set_LastKnownProductId(string value);
                /*0x381385c*/ System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> get_LastKnownProrationMode();
                /*0x3815b04*/ void set_LastKnownProrationMode(System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> value);
            }

            interface IGooglePlayStoreService
            {
                /*0x3816920*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason, UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductFailed);
                /*0x3816710*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product);
                /*0x3816920*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished);
                /*0x3816710*/ void FetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed);
                /*0x3814b90*/ UnityEngine.Purchasing.Interfaces.IGooglePurchase GetPurchase(string purchaseToken, string skuType);
                /*0x38159dc*/ void ResumeConnection();
            }

            interface IGoogleProductCallback
            {
                /*0x3816710*/ void SetStoreConfiguration(UnityEngine.Purchasing.IGooglePlayConfigurationInternal configuration);
                /*0x3815ed0*/ void NotifyQueryProductDetailsFailed(int retryCount);
            }

            interface IGooglePurchase
            {
                /*0x3814574*/ int get_purchaseState();
                /*0x38148bc*/ System.Collections.Generic.List<string> get_skus();
                /*0x38148bc*/ string get_receipt();
                /*0x38148bc*/ string get_purchaseToken();
                /*0x38148bc*/ string get_sku();
                /*0x3813ffc*/ bool IsAcknowledged();
                /*0x3813ffc*/ bool IsPurchased();
                /*0x3813ffc*/ bool IsPending();
            }

            interface IGooglePurchaseBuilder
            {
                /*0x3814a3c*/ System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> BuildPurchases(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> purchases);
                /*0x3814a3c*/ UnityEngine.Purchasing.Interfaces.IGooglePurchase BuildPurchase(UnityEngine.AndroidJavaObject purchase);
            }

            interface IGooglePurchaseCallback
            {
                /*0x3816710*/ void SetStoreCallback(UnityEngine.Purchasing.Extension.IStoreCallback storeCallback);
                /*0x3816710*/ void SetStoreConfiguration(UnityEngine.Purchasing.IGooglePlayConfigurationInternal configuration);
                /*0x3816920*/ void OnPurchaseSuccessful(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, string receipt, string purchaseToken);
                /*0x3816710*/ void OnPurchaseFailed(UnityEngine.Purchasing.Extension.PurchaseFailureDescription purchaseFailureDescription);
                /*0x3816920*/ void NotifyDeferredPurchase(UnityEngine.Purchasing.Interfaces.IGooglePurchase purchase, string receipt, string purchaseToken);
                /*0x3816710*/ void NotifyDeferredProrationUpgradeDowngradeSubscription(string sku);
            }

            interface IGooglePurchaseService
            {
                void Purchase(UnityEngine.Purchasing.ProductDefinition product, UnityEngine.Purchasing.Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode);
            }

            interface IGooglePurchaseStateEnumProvider
            {
                /*0x3814574*/ int Purchased();
                /*0x3814574*/ int Pending();
            }

            interface IGooglePurchaseUpdatedListener
            {
            }

            interface IGoogleQueryPurchasesService
            {
                /*0x38148bc*/ System.Threading.Tasks.Task<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> QueryPurchases();
                /*0x3814b90*/ UnityEngine.Purchasing.Interfaces.IGooglePurchase GetPurchaseByToken(string token, string skuType);
            }

            interface IProductDetailsConverter
            {
                /*0x3814a3c*/ System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> ConvertOnQueryProductDetailsResponse(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails);
            }

            interface IProductDetailsResponseConsolidator
            {
                /*0x3816810*/ void Consolidate(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails);
            }

            interface IQueryProductDetailsService
            {
                /*0x3816810*/ void QueryAsyncProduct(UnityEngine.Purchasing.ProductDefinition product, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse);
                /*0x3816810*/ void QueryAsyncProduct(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse);
            }

            interface IProductDetailsQueryResponse
            {
                /*0x3816810*/ void AddResponse(UnityEngine.Purchasing.Models.IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails);
                /*0x38148bc*/ System.Collections.Generic.List<UnityEngine.AndroidJavaObject> ProductDetails();
                /*0x3813ffc*/ bool IsRecoverable();
                /*0x38148bc*/ UnityEngine.Purchasing.Models.IGoogleBillingResult GetGoogleBillingResult();
            }
        }

        namespace Models
        {
            class AndroidJavaObjectExtensions
            {
                static /*0x38379c4*/ System.Collections.Generic.IEnumerable<T> Enumerate<T>(UnityEngine.AndroidJavaObject androidJavaList);
                static /*0x7f69b70*/ System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> Enumerate(UnityEngine.AndroidJavaObject androidJavaList);

                class <>c__DisplayClass0_0<T>
                {
                    /*0x0*/ UnityEngine.AndroidJavaObject androidJavaList;

                    /*0x38159dc*/ <>c__DisplayClass0_0();
                    /*0x3910ae8*/ T <Enumerate>b__0(int i);
                }
            }

            interface IGoogleBillingResult
            {
                /*0x3814574*/ UnityEngine.Purchasing.Models.GoogleBillingResponseCode get_responseCode();
                /*0x38148bc*/ string get_debugMessage();
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

                static /*0x7f69bc0*/ UnityEngine.AndroidJavaClass GetProductParamsClass();
                static /*0x7f69c74*/ UnityEngine.AndroidJavaClass GetQueryProductDetailsParamsParamsClass();
                static /*0x7f69d20*/ UnityEngine.AndroidJavaClass GetBillingFlowParamClass();
                static /*0x7f69dcc*/ UnityEngine.AndroidJavaClass GetProductDetailsParamsClass();
                static /*0x7f69e78*/ UnityEngine.AndroidJavaClass GetSubscriptionUpdateParamClass();
                static /*0x7f69f24*/ UnityEngine.AndroidJavaClass GetConsumeParamsClass();
                static /*0x7f69fd0*/ UnityEngine.AndroidJavaClass GetAcknowledgePurchaseParamsClass();
                static /*0x7f6a07c*/ UnityEngine.AndroidJavaClass GetBillingClientClass();
                static /*0x7f6aaf0*/ UnityEngine.AndroidJavaObject QueryProductDetailsParams(System.Collections.Generic.List<string> products, string type);
                static /*0x7f6af88*/ UnityEngine.AndroidJavaObject QueryProductDetailsParamsProductList(System.Collections.Generic.List<string> products, string type);
                static /*0x7f6b0b4*/ UnityEngine.AndroidJavaObject QueryProductDetailsParamsProduct(string type, string product);
                static /*0x7f6c390*/ UnityEngine.AndroidJavaObject BuildSubscriptionUpdateParams(string oldPurchaseToken, UnityEngine.Purchasing.GooglePlayProrationMode prorationMode);
                /*0x7f6a128*/ GoogleBillingClient(UnityEngine.Purchasing.Interfaces.IGooglePurchaseUpdatedListener googlePurchaseUpdatedListener, Uniject.IUtil util, UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics telemetryDiagnostics);
                /*0x7f6a568*/ void StartConnection(UnityEngine.Purchasing.Interfaces.IBillingClientStateListener billingClientStateListener);
                /*0x7f6a638*/ UnityEngine.Purchasing.GoogleBillingConnectionState GetConnectionState();
                /*0x7f6a708*/ void QueryPurchasesAsync(string skuType, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> onQueryPurchasesResponse);
                /*0x7f6a844*/ void QueryProductDetailsAsync(System.Collections.Generic.List<string> products, string type, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult, System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onProductDetailsResponseAction);
                /*0x7f6b4bc*/ UnityEngine.AndroidJavaObject LaunchBillingFlow(UnityEngine.AndroidJavaObject productDetails, string oldPurchaseToken, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> prorationMode);
                /*0x7f6bea4*/ UnityEngine.AndroidJavaObject MakeBillingFlowParams(UnityEngine.AndroidJavaObject productDetailsParamsList, string oldPurchaseToken, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> prorationMode);
                /*0x7f6c29c*/ UnityEngine.AndroidJavaObject SetObfuscatedProfileIdIfNeeded(UnityEngine.AndroidJavaObject billingFlowParams);
                /*0x7f6c1a8*/ UnityEngine.AndroidJavaObject SetObfuscatedAccountIdIfNeeded(UnityEngine.AndroidJavaObject billingFlowParams);
                /*0x7f6c644*/ void ConsumeAsync(string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onConsume);
                /*0x7f6cbc8*/ void AcknowledgePurchase(string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onAcknowledge);

                class <>c__DisplayClass39_0
                {
                    /*0x10*/ string type;

                    /*0x7f6b0ac*/ <>c__DisplayClass39_0();
                    /*0x7f6d14c*/ UnityEngine.AndroidJavaObject <QueryProductDetailsParamsProductList>b__0(string product);
                }
            }

            class GoogleBillingResult : UnityEngine.Purchasing.Models.IGoogleBillingResult
            {
                /*0x10*/ UnityEngine.Purchasing.Models.GoogleBillingResponseCode <responseCode>k__BackingField;
                /*0x18*/ string <debugMessage>k__BackingField;

                /*0x7f6d164*/ GoogleBillingResult(UnityEngine.AndroidJavaObject billingResult);
                /*0x7f6d154*/ UnityEngine.Purchasing.Models.GoogleBillingResponseCode get_responseCode();
                /*0x7f6d15c*/ string get_debugMessage();
            }

            class GoogleBillingStrings
            {
                static /*0x7f6d2f0*/ string getWarningMessageMoreThanOneSkuFound(string sku);
            }

            class GoogleProductTypeEnum
            {
                static /*0x7f6d35c*/ string InApp();
                static /*0x7f6d39c*/ string Sub();
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

                /*0x7f6750c*/ GooglePurchase(UnityEngine.AndroidJavaObject purchase, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetailsEnum);
                /*0x7f6d3dc*/ bool get_isAcknowledged();
                /*0x7f6d3e4*/ int get_purchaseState();
                /*0x7f6d3ec*/ System.Collections.Generic.List<string> get_skus();
                /*0x7f6d3f4*/ string get_receipt();
                /*0x7f6d3fc*/ string get_signature();
                /*0x7f6d404*/ string get_originalJson();
                /*0x7f6d40c*/ string get_purchaseToken();
                /*0x7f6d414*/ string get_sku();
                /*0x7f6d45c*/ bool IsAcknowledged();
                /*0x7f6d464*/ bool IsPurchased();
                /*0x7f6d6b4*/ bool IsPending();

                class <>c
                {
                    static /*0x0*/ UnityEngine.Purchasing.Models.GooglePurchase.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.AndroidJavaObject, string> <>9__32_0;

                    static /*0x7f6d908*/ <>c();
                    /*0x7f6d970*/ <>c();
                    /*0x7f6d978*/ string <.ctor>b__32_0(UnityEngine.AndroidJavaObject productDetails);
                }
            }

            class GooglePurchaseStateEnum
            {
                static /*0x0*/ System.Nullable<int> s_Purchased;
                static /*0x8*/ System.Nullable<int> s_Pending;

                static /*0x7f6d9a8*/ UnityEngine.AndroidJavaObject GetPurchaseStateJavaObject();
                static /*0x7f6d480*/ int Purchased();
                static /*0x7f6d6d0*/ int Pending();
            }

            class GooglePurchaseStateEnumProvider : UnityEngine.Purchasing.Interfaces.IGooglePurchaseStateEnumProvider
            {
                /*0x7f6da1c*/ GooglePurchaseStateEnumProvider();
                /*0x7f6da14*/ int Purchased();
                /*0x7f6da18*/ int Pending();
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

                /*0x7f6da24*/ ProductDescriptionQuery(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>, UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason, UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed);
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
    static /*0x7f6da84*/ uint ComputeStringHash(string s);
}
