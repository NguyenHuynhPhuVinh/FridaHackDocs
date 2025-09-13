class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x2a5b3b8*/ EmbeddedAttribute();
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

                /*0x2a5ba58*/ NullableAttribute(byte );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x2a5bae4*/ NullableContextAttribute(byte );
            }
        }
    }
}

namespace UnityEngine
{
    namespace Purchasing
    {
        class AnalyticsAdapter : UnityEngine.Purchasing.IAnalyticsAdapter
        {
            /*0x10*/ Unity.Services.Analytics.IAnalyticsService m_Analytics;

            /*0x2a5a1bc*/ AnalyticsAdapter(Unity.Services.Analytics.IAnalyticsService analytics);
            /*0x2a5a1e8*/ void SendTransactionEvent(UnityEngine.Purchasing.Product product);
            /*0x2a5a430*/ Unity.Services.Analytics.TransactionParameters BuildTransactionParameters(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.UnifiedReceipt unifiedReceipt, UnityEngine.Purchasing.AnalyticsTransactionReceipt analyticsReceipt);
            /*0x2a5a770*/ void SendTransactionFailedEvent(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason reason);
            /*0x2a5a8a8*/ Unity.Services.Analytics.TransactionFailedParameters BuildTransactionFailedParameters(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason reason);
            /*0x2a5a56c*/ Unity.Services.Analytics.Product GenerateItemReceivedForPurchase(UnityEngine.Purchasing.Product product);
            /*0x2a5a6ac*/ Unity.Services.Analytics.Product GenerateRealCurrencySpentOnPurchase(UnityEngine.Purchasing.Product product);
            /*0x2a5aa1c*/ long ExtractRealCurrencyAmount(UnityEngine.Purchasing.Product product);
        }

        class AnalyticsClient : UnityEngine.Purchasing.IAnalyticsClient
        {
            /*0x10*/ UnityEngine.Purchasing.IAnalyticsAdapter m_Analytics;
            /*0x18*/ UnityEngine.Purchasing.IAnalyticsAdapter m_LegacyAnalytics;

            /*0x2a5ab3c*/ AnalyticsClient(UnityEngine.Purchasing.IAnalyticsAdapter analytics, UnityEngine.Purchasing.IAnalyticsAdapter legacyAnalytics);
            /*0x2a5ab74*/ void OnPurchaseSucceeded(UnityEngine.Purchasing.Product product);
            /*0x2a5acc0*/ void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason reason);
        }

        interface IAnalyticsAdapter
        {
            void SendTransactionEvent(UnityEngine.Purchasing.Product product);
            void SendTransactionFailedEvent(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason reason);
        }

        interface IAnalyticsClient
        {
            void OnPurchaseSucceeded(UnityEngine.Purchasing.Product product);
            void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason reason);
        }

        interface ILegacyUnityAnalytics
        {
            void SendTransactionEvent(string productId, decimal amount, string currency, string receiptPurchaseData, string signature);
            void SendCustomEvent(string name, System.Collections.Generic.Dictionary<string, object> data);
        }

        class LegacyAnalyticsAdapter : UnityEngine.Purchasing.IAnalyticsAdapter
        {
            /*0x10*/ UnityEngine.Purchasing.ILegacyUnityAnalytics m_LegacyAnalytics;

            /*0x2a5b4f8*/ LegacyAnalyticsAdapter(UnityEngine.Purchasing.ILegacyUnityAnalytics legacyAnalytics);
            /*0x2a5b524*/ void SendTransactionEvent(UnityEngine.Purchasing.Product product);
            /*0x2a5b620*/ void SendTransactionFailedEvent(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason reason);
        }

        class LegacyUnityAnalytics : UnityEngine.Purchasing.ILegacyUnityAnalytics
        {
            /*0x2a5b8a0*/ LegacyUnityAnalytics();
            /*0x2a5b870*/ void SendTransactionEvent(string productId, decimal amount, string currency, string receiptPurchaseData, string signature);
            /*0x2a5b890*/ void SendCustomEvent(string name, System.Collections.Generic.Dictionary<string, object> data);
        }

        class AnalyticsTransactionReceipt
        {
            /*0x10*/ string <transactionReceipt>k__BackingField;
            /*0x18*/ string <transactionReceiptSignature>k__BackingField;
            /*0x20*/ System.Nullable<Unity.Services.Analytics.TransactionServer> <transactionServer>k__BackingField;

            /*0x2a5ae34*/ AnalyticsTransactionReceipt();
            /*0x2a5ae04*/ string get_transactionReceipt();
            /*0x2a5ae0c*/ void set_transactionReceipt(string value);
            /*0x2a5ae14*/ string get_transactionReceiptSignature();
            /*0x2a5ae1c*/ void set_transactionReceiptSignature(string value);
            /*0x2a5ae24*/ System.Nullable<Unity.Services.Analytics.TransactionServer> get_transactionServer();
            /*0x2a5ae2c*/ void set_transactionServer(System.Nullable<Unity.Services.Analytics.TransactionServer> value);
        }

        class GoogleReceipt
        {
            /*0x10*/ string json;
            /*0x18*/ string signature;

            /*0x2a5b3c0*/ GoogleReceipt();
        }

        class IDs : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>, System.Collections.IEnumerable
        {
            /*0x10*/ System.Collections.Generic.Dictionary<string, string> m_Dic;

            /*0x2a5b3c8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x2a5b270*/ string SpecificIDForStore(string store, string defaultValue);
            /*0x2a5b460*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>> GetEnumerator();
        }

        class ConfigurationBuilder
        {
            /*0x10*/ UnityEngine.Purchasing.PurchasingFactory m_Factory;
            /*0x18*/ System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> m_Products;
            /*0x20*/ bool <useCatalogProvider>k__BackingField;

            static /*0x2a5aee0*/ UnityEngine.Purchasing.ConfigurationBuilder Instance(UnityEngine.Purchasing.Extension.IPurchasingModule first, UnityEngine.Purchasing.Extension.IPurchasingModule[] rest);
            /*0x2a5ae3c*/ ConfigurationBuilder(UnityEngine.Purchasing.PurchasingFactory factory);
            /*0x2a5aec8*/ bool get_useCatalogProvider();
            /*0x2a5aed0*/ System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> get_products();
            /*0x2a5aed8*/ UnityEngine.Purchasing.PurchasingFactory get_factory();
            /*0x2a5b170*/ UnityEngine.Purchasing.ConfigurationBuilder AddProduct(string id, UnityEngine.Purchasing.ProductType type);
            /*0x2a5b17c*/ UnityEngine.Purchasing.ConfigurationBuilder AddProduct(string id, UnityEngine.Purchasing.ProductType type, UnityEngine.Purchasing.IDs storeIDs);
            /*0x2a5b184*/ UnityEngine.Purchasing.ConfigurationBuilder AddProduct(string id, UnityEngine.Purchasing.ProductType type, UnityEngine.Purchasing.IDs storeIDs, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.PayoutDefinition> payouts);
        }

        interface IUnityServicesInitializationChecker
        {
            void CheckAndLogWarning();
        }

        class UnityServicesInitializationChecker : UnityEngine.Purchasing.IUnityServicesInitializationChecker
        {
            /*0x10*/ UnityEngine.ILogger m_Logger;

            /*0x2a5fafc*/ UnityServicesInitializationChecker(UnityEngine.ILogger logger);
            /*0x2a60098*/ void CheckAndLogWarning();
            /*0x2a600d0*/ bool IsUninitialized();
            /*0x2a600f0*/ void LogWarning();
        }

        interface IStoreExtension
        {
        }

        interface IExtensionProvider
        {
        }

        interface IInternalStoreListener
        {
            void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error);
            UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e);
            void OnPurchaseFailed(UnityEngine.Purchasing.Product i, UnityEngine.Purchasing.PurchaseFailureReason p);
            void OnInitialized(UnityEngine.Purchasing.IStoreController controller);
        }

        interface IStoreController
        {
            UnityEngine.Purchasing.ProductCollection get_products();
            void InitiatePurchase(UnityEngine.Purchasing.Product product, string payload);
        }

        interface IStoreListener
        {
            void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error);
            UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs purchaseEvent);
            void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason failureReason);
            void OnInitialized(UnityEngine.Purchasing.IStoreController controller, UnityEngine.Purchasing.IExtensionProvider extensions);
        }

        enum InitializationFailureReason
        {
            PurchasingUnavailable = 0,
            NoProductsAvailable = 1,
            AppNotKnown = 2,
        }

        class PayoutDefinition
        {
            static int MaxSubtypeLength = 64;
            static int MaxDataLength = 1024;
            /*0x10*/ UnityEngine.Purchasing.PayoutType m_Type;
            /*0x18*/ string m_Subtype;
            /*0x20*/ double m_Quantity;
            /*0x28*/ string m_Data;

            /*0x2a5bb10*/ PayoutDefinition();
        }

        enum PayoutType
        {
            Other = 0,
            Currency = 1,
            Item = 2,
            Resource = 3,
        }

        class Product
        {
            /*0x10*/ UnityEngine.Purchasing.ProductDefinition <definition>k__BackingField;
            /*0x18*/ UnityEngine.Purchasing.ProductMetadata <metadata>k__BackingField;
            /*0x20*/ bool <availableToPurchase>k__BackingField;
            /*0x28*/ string <transactionID>k__BackingField;
            /*0x30*/ string <receipt>k__BackingField;

            /*0x2a5bb78*/ Product(UnityEngine.Purchasing.ProductDefinition definition, UnityEngine.Purchasing.ProductMetadata metadata, string receipt);
            /*0x2a5bbb8*/ Product(UnityEngine.Purchasing.ProductDefinition definition, UnityEngine.Purchasing.ProductMetadata metadata);
            /*0x2a5bbf4*/ UnityEngine.Purchasing.ProductDefinition get_definition();
            /*0x2a5bbfc*/ void set_definition(UnityEngine.Purchasing.ProductDefinition value);
            /*0x2a5bc04*/ UnityEngine.Purchasing.ProductMetadata get_metadata();
            /*0x2a5bc0c*/ void set_metadata(UnityEngine.Purchasing.ProductMetadata value);
            /*0x2a5bc14*/ bool get_availableToPurchase();
            /*0x2a5bc1c*/ void set_availableToPurchase(bool value);
            /*0x2a5bc28*/ string get_transactionID();
            /*0x2a5bc30*/ void set_transactionID(string value);
            /*0x2a5bc38*/ string get_receipt();
            /*0x2a5bc40*/ void set_receipt(string value);
            /*0x2a5bc48*/ bool Equals(object obj);
            /*0x2a5bcfc*/ int GetHashCode();
        }

        class ProductCollection
        {
            /*0x10*/ System.Collections.Generic.Dictionary<string, UnityEngine.Purchasing.Product> m_IdToProduct;
            /*0x18*/ System.Collections.Generic.Dictionary<string, UnityEngine.Purchasing.Product> m_StoreSpecificIdToProduct;
            /*0x20*/ UnityEngine.Purchasing.Product[] m_Products;
            /*0x28*/ System.Collections.Generic.HashSet<UnityEngine.Purchasing.Product> m_ProductSet;

            /*0x2a5bd1c*/ ProductCollection(UnityEngine.Purchasing.Product[] products);
            /*0x2a5bdac*/ void AddProducts(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Product> products);
            /*0x2a5bfd8*/ System.Collections.Generic.HashSet<UnityEngine.Purchasing.Product> get_set();
            /*0x2a5bfe0*/ UnityEngine.Purchasing.Product[] get_all();
            /*0x2a5bfe8*/ UnityEngine.Purchasing.Product WithID(string id);
            /*0x2a5c05c*/ UnityEngine.Purchasing.Product WithStoreSpecificID(string id);

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.ProductCollection.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.Purchasing.Product, string> <>9__5_0;
                static /*0x10*/ System.Func<UnityEngine.Purchasing.Product, string> <>9__5_1;

                static /*0x2a6013c*/ <>c();
                /*0x2a6019c*/ <>c();
                /*0x2a601a4*/ string <AddProducts>b__5_0(UnityEngine.Purchasing.Product x);
                /*0x2a601c8*/ string <AddProducts>b__5_1(UnityEngine.Purchasing.Product x);
            }
        }

        class ProductDefinition
        {
            /*0x10*/ string <id>k__BackingField;
            /*0x18*/ string <storeSpecificId>k__BackingField;
            /*0x20*/ UnityEngine.Purchasing.ProductType <type>k__BackingField;
            /*0x24*/ bool <enabled>k__BackingField;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.Purchasing.PayoutDefinition> m_Payouts;

            /*0x2a5b310*/ ProductDefinition(string id, string storeSpecificId, UnityEngine.Purchasing.ProductType type);
            /*0x2a5c0dc*/ ProductDefinition(string id, string storeSpecificId, UnityEngine.Purchasing.ProductType type, bool enabled);
            /*0x2a5c0e8*/ ProductDefinition(string id, string storeSpecificId, UnityEngine.Purchasing.ProductType type, bool enabled, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.PayoutDefinition> payouts);
            /*0x2a5c1a8*/ ProductDefinition(string id, UnityEngine.Purchasing.ProductType type);
            /*0x2a5c1bc*/ string get_id();
            /*0x2a5c1c4*/ void set_id(string value);
            /*0x2a5c1cc*/ string get_storeSpecificId();
            /*0x2a5c1d4*/ void set_storeSpecificId(string value);
            /*0x2a5c1dc*/ UnityEngine.Purchasing.ProductType get_type();
            /*0x2a5c1e4*/ void set_type(UnityEngine.Purchasing.ProductType value);
            /*0x2a5c1ec*/ bool get_enabled();
            /*0x2a5c1f4*/ void set_enabled(bool value);
            /*0x2a5c200*/ bool Equals(object obj);
            /*0x2a5c2ac*/ int GetHashCode();
            /*0x2a5c2cc*/ System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.PayoutDefinition> get_payouts();
            /*0x2a5b31c*/ void SetPayouts(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.PayoutDefinition> newPayouts);
        }

        class ProductMetadata
        {
            /*0x10*/ string <localizedPriceString>k__BackingField;
            /*0x18*/ string <localizedTitle>k__BackingField;
            /*0x20*/ string <localizedDescription>k__BackingField;
            /*0x28*/ string <isoCurrencyCode>k__BackingField;
            /*0x30*/ decimal <localizedPrice>k__BackingField;

            /*0x2a5c3fc*/ ProductMetadata(string priceString, string title, string description, string currencyCode, decimal localizedPrice);
            /*0x2a5c45c*/ ProductMetadata();
            /*0x2a5c464*/ string get_localizedPriceString();
            /*0x2a5c46c*/ void set_localizedPriceString(string value);
            /*0x2a5c474*/ string get_localizedTitle();
            /*0x2a5c47c*/ void set_localizedTitle(string value);
            /*0x2a5c484*/ string get_localizedDescription();
            /*0x2a5c48c*/ void set_localizedDescription(string value);
            /*0x2a5c494*/ string get_isoCurrencyCode();
            /*0x2a5c49c*/ void set_isoCurrencyCode(string value);
            /*0x2a5c4a4*/ decimal get_localizedPrice();
            /*0x2a5c4b0*/ void set_localizedPrice(decimal value);
        }

        enum ProductType
        {
            Consumable = 0,
            NonConsumable = 1,
            Subscription = 2,
        }

        class PurchaseEventArgs
        {
            /*0x10*/ UnityEngine.Purchasing.Product <purchasedProduct>k__BackingField;

            /*0x2a5c574*/ PurchaseEventArgs(UnityEngine.Purchasing.Product purchasedProduct);
            /*0x2a5c5a0*/ UnityEngine.Purchasing.Product get_purchasedProduct();
            /*0x2a5c5a8*/ void set_purchasedProduct(UnityEngine.Purchasing.Product value);
        }

        enum PurchaseFailureReason
        {
            PurchasingUnavailable = 0,
            ExistingPurchasePending = 1,
            ProductUnavailable = 2,
            SignatureInvalid = 3,
            UserCancelled = 4,
            PaymentDeclined = 5,
            DuplicateTransaction = 6,
            Unknown = 7,
        }

        enum PurchaseProcessingResult
        {
            Complete = 0,
            Pending = 1,
        }

        class PurchasingFactory : UnityEngine.Purchasing.Extension.IPurchasingBinder, UnityEngine.Purchasing.IExtensionProvider
        {
            /*0x10*/ System.Collections.Generic.Dictionary<System.Type, UnityEngine.Purchasing.Extension.IStoreConfiguration> m_ConfigMap;
            /*0x18*/ System.Collections.Generic.Dictionary<System.Type, UnityEngine.Purchasing.IStoreExtension> m_ExtensionMap;
            /*0x20*/ UnityEngine.Purchasing.Extension.IStore m_Store;
            /*0x28*/ UnityEngine.Purchasing.Extension.ICatalogProvider m_CatalogProvider;
            /*0x30*/ string <storeName>k__BackingField;

            /*0x2a5af74*/ PurchasingFactory(UnityEngine.Purchasing.Extension.IPurchasingModule first, UnityEngine.Purchasing.Extension.IPurchasingModule[] remainingModules);
            /*0x2a5c624*/ string get_storeName();
            /*0x2a5c62c*/ void set_storeName(string value);
            /*0x2a5c634*/ UnityEngine.Purchasing.Extension.IStore get_service();
            /*0x2a5c694*/ void set_service(UnityEngine.Purchasing.Extension.IStore value);
            /*0x2a5c69c*/ void RegisterStore(string name, UnityEngine.Purchasing.Extension.IStore s);
            void RegisterExtension<T>(T instance);
            void RegisterConfiguration<T>(T instance);
            /*0x2a5c6b4*/ UnityEngine.Purchasing.Extension.ICatalogProvider GetCatalogProvider();
        }

        class PurchasingManager : UnityEngine.Purchasing.Extension.IStoreCallback, UnityEngine.Purchasing.IStoreController
        {
            /*0x10*/ UnityEngine.Purchasing.Extension.IStore m_Store;
            /*0x18*/ UnityEngine.Purchasing.IInternalStoreListener m_Listener;
            /*0x20*/ UnityEngine.ILogger m_Logger;
            /*0x28*/ UnityEngine.Purchasing.TransactionLog m_TransactionLog;
            /*0x30*/ string m_StoreName;
            /*0x38*/ UnityEngine.Purchasing.IUnityServicesInitializationChecker m_UnityServicesInitializationChecker;
            /*0x40*/ System.Action m_AdditionalProductsCallback;
            /*0x48*/ System.Action<UnityEngine.Purchasing.InitializationFailureReason> m_AdditionalProductsFailCallback;
            /*0x50*/ bool <useTransactionLog>k__BackingField;
            /*0x58*/ UnityEngine.Purchasing.ProductCollection <products>k__BackingField;
            /*0x60*/ bool initialized;

            static /*0x2a5d0cc*/ void ClearProductReceipt(UnityEngine.Purchasing.Product product);
            /*0x2a5c6d0*/ PurchasingManager(UnityEngine.Purchasing.TransactionLog tDb, UnityEngine.ILogger logger, UnityEngine.Purchasing.Extension.IStore store, string storeName, UnityEngine.Purchasing.IUnityServicesInitializationChecker unityServicesInitializationChecker);
            /*0x2a5c6bc*/ bool get_useTransactionLog();
            /*0x2a5c6c4*/ void set_useTransactionLog(bool value);
            /*0x2a5c72c*/ void InitiatePurchase(UnityEngine.Purchasing.Product product, string developerPayload);
            /*0x2a5c940*/ void ConfirmPendingPurchase(UnityEngine.Purchasing.Product product);
            /*0x2a5cbcc*/ UnityEngine.Purchasing.ProductCollection get_products();
            /*0x2a5cbd4*/ void set_products(UnityEngine.Purchasing.ProductCollection value);
            /*0x2a5cbdc*/ void OnPurchaseSucceeded(string id, string receipt, string transactionId);
            /*0x2a5ccf4*/ void UpdateProductReceiptAndTrandsactionID(UnityEngine.Purchasing.Product product, string receipt, string transactionId);
            /*0x2a5cf0c*/ void OnAllPurchasesRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchasedProducts);
            /*0x2a5d08c*/ void HandlePurchaseRetrieved(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Product purchasedProduct);
            /*0x2a5d0e4*/ void OnSetupFailed(UnityEngine.Purchasing.InitializationFailureReason reason);
            /*0x2a5d1ec*/ void OnPurchaseFailed(UnityEngine.Purchasing.Extension.PurchaseFailureDescription description);
            /*0x2a5d6ac*/ void OnProductsRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products);
            /*0x2a5cef8*/ string CreateUnifiedReceipt(string rawReceipt, string transactionId);
            /*0x2a5da78*/ void ProcessPurchaseOnStart();
            /*0x2a5cd30*/ void ProcessPurchaseIfNew(UnityEngine.Purchasing.Product product);
            /*0x2a5d978*/ void CheckForInitialization();
            /*0x2a5dc2c*/ bool HasAvailableProductsToPurchase(bool shouldLogUnavailableProducts);
            /*0x2a5df34*/ void Initialize(UnityEngine.Purchasing.IInternalStoreListener listener, System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> products);

            class <>c__DisplayClass24_0
            {
                /*0x10*/ UnityEngine.Purchasing.Product product;

                /*0x2a5d084*/ <>c__DisplayClass24_0();
                /*0x2a602e8*/ bool <OnAllPurchasesRetrieved>b__0(UnityEngine.Purchasing.Product firstPurchasedProduct);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.PurchasingManager.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.Purchasing.ProductDefinition, UnityEngine.Purchasing.Product> <>9__37_0;

                static /*0x2a601ec*/ <>c();
                /*0x2a6024c*/ <>c();
                /*0x2a60254*/ UnityEngine.Purchasing.Product <Initialize>b__37_0(UnityEngine.Purchasing.ProductDefinition x);
            }
        }

        class StoreListenerProxy : UnityEngine.Purchasing.IInternalStoreListener
        {
            /*0x10*/ UnityEngine.Purchasing.IAnalyticsClient m_Analytics;
            /*0x18*/ UnityEngine.Purchasing.IStoreListener m_ForwardTo;
            /*0x20*/ UnityEngine.Purchasing.IExtensionProvider m_Extensions;

            /*0x2a5e20c*/ StoreListenerProxy(UnityEngine.Purchasing.IStoreListener forwardTo, UnityEngine.Purchasing.IAnalyticsClient analytics, UnityEngine.Purchasing.IExtensionProvider extensions);
            /*0x2a5e24c*/ void OnInitialized(UnityEngine.Purchasing.IStoreController controller);
            /*0x2a5e314*/ void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error);
            /*0x2a5e3d0*/ UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e);
            /*0x2a5e518*/ void OnPurchaseFailed(UnityEngine.Purchasing.Product i, UnityEngine.Purchasing.PurchaseFailureReason p);
        }

        class TransactionLog
        {
            /*0x10*/ UnityEngine.ILogger logger;
            /*0x18*/ string persistentDataPath;

            static /*0x2a5f628*/ string ComputeHash(string transactionID);
            /*0x2a5f4cc*/ TransactionLog(UnityEngine.ILogger logger, string persistentDataPath);
            /*0x2a5dbcc*/ bool HasRecordOf(string transactionID);
            /*0x2a5ca80*/ void Record(string transactionID);
            /*0x2a5f5a0*/ string GetRecordPath(string transactionID);
        }

        class UnifiedReceipt
        {
            /*0x10*/ string Payload;
            /*0x18*/ string Store;
            /*0x20*/ string TransactionID;

            /*0x2a5f7ec*/ UnifiedReceipt();
        }

        class UnifiedReceiptExtensions
        {
            static /*0x2a5a340*/ UnityEngine.Purchasing.AnalyticsTransactionReceipt ToReceiptAndSignature(UnityEngine.Purchasing.UnifiedReceipt receipt);
            static /*0x2a5f7f4*/ System.Nullable<Unity.Services.Analytics.TransactionServer> ToTransactionServer(UnityEngine.Purchasing.UnifiedReceipt receipt);
            static /*0x2a5f94c*/ string EscapeEmbeddedQuotationMarks(string receipt);
        }

        class UnityPurchasing
        {
            static /*0x2a5f9c8*/ void Initialize(UnityEngine.Purchasing.IStoreListener listener, UnityEngine.Purchasing.ConfigurationBuilder builder);
            static /*0x2a5fb28*/ UnityEngine.Purchasing.IAnalyticsAdapter GenerateUnityAnalytics();
            static /*0x2a5fbf4*/ UnityEngine.Purchasing.IAnalyticsAdapter GenerateLegacyUnityAnalytics();
            static /*0x2a5fc78*/ void Initialize(UnityEngine.Purchasing.IStoreListener listener, UnityEngine.Purchasing.ConfigurationBuilder builder, UnityEngine.ILogger logger, string persistentDatapath, UnityEngine.Purchasing.IAnalyticsAdapter analytics, UnityEngine.Purchasing.IAnalyticsAdapter legacyAnalytics, UnityEngine.Purchasing.Extension.ICatalogProvider catalog, UnityEngine.Purchasing.IUnityServicesInitializationChecker unityServicesInitializationChecker);
            static /*0x2a5ff04*/ void FetchAndMergeProducts(bool useCatalog, System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> localProductSet, UnityEngine.Purchasing.Extension.ICatalogProvider catalog, System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>> callback);

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.Purchasing.PurchasingManager manager;
                /*0x18*/ UnityEngine.Purchasing.StoreListenerProxy proxy;

                /*0x2a5fefc*/ <>c__DisplayClass4_0();
                /*0x2a60324*/ void <Initialize>b__0(System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> response);
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> localProductSet;
                /*0x18*/ System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>> callback;

                /*0x2a60090*/ <>c__DisplayClass5_0();
                /*0x2a60348*/ void <FetchAndMergeProducts>b__0(System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> cloudProducts);
            }
        }

        class LoggerExtensions
        {
            static /*0x2a5b8a8*/ void LogIAPWarning(UnityEngine.ILogger logger, string message);
            static /*0x2a5b980*/ void LogIAPError(UnityEngine.ILogger logger, string message);
        }

        class ProductPurchaseUpdater
        {
            static /*0x2a5c4b8*/ void UpdateProductReceiptAndTransactionID(UnityEngine.Purchasing.Product product, string receipt, string transactionId, string storeName);
        }

        class UnifiedReceiptFormatter
        {
            static /*0x2a5c4f4*/ string FormatUnifiedReceipt(string platformReceipt, string transactionId, string storeName);
        }

        namespace Telemetry
        {
            interface ITelemetryDiagnostics
            {
                void SendDiagnostic(string diagnosticName, System.Exception e);
            }

            interface ITelemetryDiagnosticsInstanceWrapper
            {
                void SetDiagnosticsInstance(Unity.Services.Core.Telemetry.Internal.IDiagnostics diagnosticsInstance);
                void SendDiagnostic(string diagnosticName, string diagnosticException);
            }

            struct TelemetryDiagnosticParams
            {
                /*0x10*/ string name;
                /*0x18*/ string exception;

                /*0xb1fa4c*/ TelemetryDiagnosticParams(string diagnosticName, string diagnosticException);
            }

            class TelemetryDiagnostics : UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics
            {
                /*0x10*/ UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper m_TelemetryDiagnosticsInstanceWrapper;

                /*0x2a5e670*/ TelemetryDiagnostics(UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper telemetryDiagnosticsInstanceWrapper);
                /*0x2a5e69c*/ void SendDiagnostic(string diagnosticName, System.Exception e);
            }

            class TelemetryDiagnosticsInstanceWrapper : UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper
            {
                /*0x10*/ Unity.Services.Core.Telemetry.Internal.IDiagnostics m_Instance;
                /*0x18*/ UnityEngine.Purchasing.Telemetry.TelemetryQueue<UnityEngine.Purchasing.Telemetry.TelemetryDiagnosticParams> m_Queue;

                /*0x2a5e77c*/ TelemetryDiagnosticsInstanceWrapper();
                /*0x2a5e85c*/ void SetDiagnosticsInstance(Unity.Services.Core.Telemetry.Internal.IDiagnostics diagnosticsInstance);
                /*0x2a5e8c0*/ void SendDiagnostic(string diagnosticName, string diagnosticException);
                /*0x2a5e950*/ void SendDiagnostic(UnityEngine.Purchasing.Telemetry.TelemetryDiagnosticParams diagnosticParams);
            }

            interface ITelemetryMetricEvent
            {
                void StartMetric();
                void StopAndSendMetric();
            }

            interface ITelemetryMetricsInstanceWrapper
            {
                void SetMetricsInstance(Unity.Services.Core.Telemetry.Internal.IMetrics metricsInstance);
                void SendMetric(UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes telemetryMetricTypes, string metricName, double metricTimeSeconds);
            }

            interface ITelemetryMetricsService
            {
                void ExecuteTimedAction(System.Action timedAction, UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition metricDefinition);
            }

            struct TelemetryMetricDefinition
            {
                /*0x10*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes <MetricType>k__BackingField;
                /*0x18*/ string <MetricName>k__BackingField;

                static /*0x2a5ea34*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition op_Implicit(string name);
                /*0xb1faec*/ TelemetryMetricDefinition(string metricName, UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes metricType);
                /*0xb1fadc*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes get_MetricType();
                /*0xb1fae4*/ string get_MetricName();
            }

            class TelemetryMetricDefinitions
            {
                static /*0x0*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition confirmSubscriptionPriceChangeName;
                static /*0x10*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition continuePromotionalPurchasesName;
                static /*0x20*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition dequeueQueryProductsTimeName;
                static /*0x30*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition dequeueQueryPurchasesTimeName;
                static /*0x40*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition fetchStorePromotionOrderName;
                static /*0x50*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition fetchStorePromotionVisibilityName;
                static /*0x60*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition initPurchaseName;
                static /*0x70*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition packageInitTimeName;
                static /*0x80*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition presentCodeRedemptionSheetName;
                static /*0x90*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition refreshAppReceiptName;
                static /*0xa0*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition restoreTransactionName;
                static /*0xb0*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition retrieveProductsName;
                static /*0xc0*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition setStorePromotionOrderName;
                static /*0xd0*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition setStorePromotionVisibilityName;
                static /*0xe0*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition upgradeDowngradeSubscriptionName;

                static /*0x2a5ea40*/ TelemetryMetricDefinitions();
            }

            class TelemetryMetricEvent : UnityEngine.Purchasing.Telemetry.ITelemetryMetricEvent
            {
                /*0x10*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper m_TelemetryMetricsInstanceWrapper;
                /*0x18*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes m_MetricType;
                /*0x20*/ string m_MetricName;
                /*0x28*/ System.Diagnostics.Stopwatch m_Stopwatch;

                /*0x2a5ec6c*/ TelemetryMetricEvent(UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper, UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes metricType, string metricName);
                /*0x2a5ecfc*/ void StartMetric();
                /*0x2a5ed90*/ void StopAndSendMetric();
            }

            struct TelemetryMetricParams
            {
                /*0x10*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes type;
                /*0x18*/ string name;
                /*0x20*/ double timeSeconds;

                /*0xb1fb98*/ TelemetryMetricParams(UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes metricType, string metricName, double metricTimeSeconds);
            }

            enum TelemetryMetricTypes
            {
                Gauge = 0,
                Sum = 1,
                Histogram = 2,
            }

            class TelemetryMetricsInstanceWrapper : UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper
            {
                /*0x10*/ Unity.Services.Core.Telemetry.Internal.IMetrics m_Instance;
                /*0x18*/ UnityEngine.Purchasing.Telemetry.TelemetryQueue<UnityEngine.Purchasing.Telemetry.TelemetryMetricParams> m_Queue;

                /*0x2a5eee8*/ TelemetryMetricsInstanceWrapper();
                /*0x2a5efc8*/ void SetMetricsInstance(Unity.Services.Core.Telemetry.Internal.IMetrics metricsInstance);
                /*0x2a5f040*/ void SendMetric(UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes metricType, string metricName, double metricTimeSeconds);
                /*0x2a5f0f0*/ void SendMetricByType(UnityEngine.Purchasing.Telemetry.TelemetryMetricParams metricParams);
            }

            class TelemetryMetricsService : UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService
            {
                /*0x10*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper m_TelemetryMetricsInstanceWrapper;

                /*0x2a5f2c0*/ TelemetryMetricsService(UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper);
                /*0x2a5f2ec*/ void ExecuteTimedAction(System.Action timedAction, UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition metricDefinition);
                /*0x2a5f3d8*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricEvent CreateAndStartMetricEvent(UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition metricDefinition);
            }

            class TelemetryQueue<TTelemetryEventParams>
            {
                /*0x0*/ System.Action<TTelemetryEventParams> m_SendTelemetryEvent;
                /*0x0*/ System.Collections.Concurrent.ConcurrentQueue<TTelemetryEventParams> m_Queue;

                TelemetryQueue(System.Action<TTelemetryEventParams> sendTelemetryEvent);
                void QueueEvent(TTelemetryEventParams telemetryEvent);
                void SendQueuedEvents();
            }
        }

        namespace Extension
        {
            class AbstractPurchasingModule : UnityEngine.Purchasing.Extension.IPurchasingModule
            {
                /*0x10*/ UnityEngine.Purchasing.Extension.IPurchasingBinder m_Binder;

                /*0x2a5a1ac*/ AbstractPurchasingModule();
                /*0x2a5a0d8*/ void Configure(UnityEngine.Purchasing.Extension.IPurchasingBinder binder);
                /*0x2a5a0e8*/ void RegisterStore(string name, UnityEngine.Purchasing.Extension.IStore store);
                void BindExtension<T>(T instance);
                void BindConfiguration<T>(T instance);
                void Configure();
            }

            class AbstractStore : UnityEngine.Purchasing.Extension.IStore
            {
                /*0x2a5a1b4*/ AbstractStore();
                void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback callback);
                void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
                void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);
                void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId);
            }

            interface ICatalogProvider
            {
                void FetchProducts(System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>> callback);
            }

            interface IPurchasingBinder
            {
                void RegisterStore(string name, UnityEngine.Purchasing.Extension.IStore store);
                void RegisterExtension<T>(T instance);
                void RegisterConfiguration<T>(T instance);
            }

            interface IPurchasingModule
            {
                void Configure(UnityEngine.Purchasing.Extension.IPurchasingBinder binder);
            }

            interface IStore
            {
                void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback callback);
                void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
                void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);
                void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId);
            }

            interface IStoreCallback
            {
                UnityEngine.Purchasing.ProductCollection get_products();
                void OnSetupFailed(UnityEngine.Purchasing.InitializationFailureReason reason);
                void OnProductsRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products);
                void OnPurchaseSucceeded(string storeSpecificId, string receipt, string transactionIdentifier);
                void OnAllPurchasesRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchasedProducts);
                void OnPurchaseFailed(UnityEngine.Purchasing.Extension.PurchaseFailureDescription desc);
            }

            interface IStoreConfiguration
            {
            }

            class ProductDescription
            {
                /*0x10*/ string <storeSpecificId>k__BackingField;
                /*0x18*/ UnityEngine.Purchasing.ProductType type;
                /*0x20*/ UnityEngine.Purchasing.ProductMetadata <metadata>k__BackingField;
                /*0x28*/ string <receipt>k__BackingField;
                /*0x30*/ string <transactionId>k__BackingField;

                /*0x2a5c2d4*/ ProductDescription(string id, UnityEngine.Purchasing.ProductMetadata metadata, string receipt, string transactionId);
                /*0x2a5c324*/ ProductDescription(string id, UnityEngine.Purchasing.ProductMetadata metadata, string receipt, string transactionId, UnityEngine.Purchasing.ProductType type);
                /*0x2a5c37c*/ ProductDescription(string id, UnityEngine.Purchasing.ProductMetadata metadata);
                /*0x2a5c3bc*/ string get_storeSpecificId();
                /*0x2a5c3c4*/ void set_storeSpecificId(string value);
                /*0x2a5c3cc*/ UnityEngine.Purchasing.ProductMetadata get_metadata();
                /*0x2a5c3d4*/ void set_metadata(UnityEngine.Purchasing.ProductMetadata value);
                /*0x2a5c3dc*/ string get_receipt();
                /*0x2a5c3e4*/ void set_receipt(string value);
                /*0x2a5c3ec*/ string get_transactionId();
                /*0x2a5c3f4*/ void set_transactionId(string value);
            }

            class PurchaseFailureDescription
            {
                /*0x10*/ string <productId>k__BackingField;
                /*0x18*/ UnityEngine.Purchasing.PurchaseFailureReason <reason>k__BackingField;
                /*0x20*/ string <message>k__BackingField;

                /*0x2a5c5b0*/ PurchaseFailureDescription(string productId, UnityEngine.Purchasing.PurchaseFailureReason reason, string message);
                /*0x2a5c5f4*/ string get_productId();
                /*0x2a5c5fc*/ void set_productId(string value);
                /*0x2a5c604*/ UnityEngine.Purchasing.PurchaseFailureReason get_reason();
                /*0x2a5c60c*/ void set_reason(UnityEngine.Purchasing.PurchaseFailureReason value);
                /*0x2a5c614*/ string get_message();
                /*0x2a5c61c*/ void set_message(string value);
            }
        }
    }
}
