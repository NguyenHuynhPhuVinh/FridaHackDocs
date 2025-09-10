class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x1739f84*/ EmbeddedAttribute();
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

                /*0x1739f8c*/ NullableAttribute(byte );
                /*0x173a00c*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x173a034*/ NullableContextAttribute(byte );
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

            /*0x173a05c*/ AnalyticsAdapter(Unity.Services.Analytics.IAnalyticsService analytics);
            /*0x173a084*/ void SendTransactionEvent(UnityEngine.Purchasing.Product product);
            /*0x173a2c4*/ Unity.Services.Analytics.TransactionParameters BuildTransactionParameters(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.UnifiedReceipt unifiedReceipt, UnityEngine.Purchasing.AnalyticsTransactionReceipt analyticsReceipt);
            /*0x173a638*/ void SendTransactionFailedEvent(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason reason);
            /*0x173a75c*/ Unity.Services.Analytics.TransactionFailedParameters BuildTransactionFailedParameters(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason reason);
            /*0x173a414*/ Unity.Services.Analytics.Product GenerateItemReceivedForPurchase(UnityEngine.Purchasing.Product product);
            /*0x173a578*/ Unity.Services.Analytics.Product GenerateRealCurrencySpentOnPurchase(UnityEngine.Purchasing.Product product);
            /*0x173a8dc*/ long ExtractRealCurrencyAmount(UnityEngine.Purchasing.Product product);
        }

        class AnalyticsClient : UnityEngine.Purchasing.IAnalyticsClient
        {
            /*0x10*/ UnityEngine.Purchasing.IAnalyticsAdapter m_Analytics;
            /*0x18*/ UnityEngine.Purchasing.IAnalyticsAdapter m_LegacyAnalytics;

            /*0x173a9e8*/ AnalyticsClient(UnityEngine.Purchasing.IAnalyticsAdapter analytics, UnityEngine.Purchasing.IAnalyticsAdapter legacyAnalytics);
            /*0x173aa14*/ void OnPurchaseSucceeded(UnityEngine.Purchasing.Product product);
            /*0x173ab4c*/ void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason reason);
        }

        class EmptyAnalyticsAdapter : UnityEngine.Purchasing.IAnalyticsAdapter
        {
            /*0x173ac7c*/ EmptyAnalyticsAdapter();
            /*0x173ac74*/ void SendTransactionEvent(UnityEngine.Purchasing.Product product);
            /*0x173ac78*/ void SendTransactionFailedEvent(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason reason);
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

            /*0x173ac84*/ LegacyAnalyticsAdapter(UnityEngine.Purchasing.ILegacyUnityAnalytics legacyAnalytics);
            /*0x173acac*/ void SendTransactionEvent(UnityEngine.Purchasing.Product product);
            /*0x173ad9c*/ void SendTransactionFailedEvent(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason reason);
        }

        class LegacyUnityAnalytics : UnityEngine.Purchasing.ILegacyUnityAnalytics
        {
            /*0x173b038*/ LegacyUnityAnalytics();
            /*0x173b008*/ void SendTransactionEvent(string productId, decimal amount, string currency, string receiptPurchaseData, string signature);
            /*0x173b028*/ void SendCustomEvent(string name, System.Collections.Generic.Dictionary<string, object> data);
        }

        class AnalyticsTransactionReceipt
        {
            /*0x10*/ string <transactionReceipt>k__BackingField;
            /*0x18*/ string <transactionReceiptSignature>k__BackingField;
            /*0x20*/ System.Nullable<Unity.Services.Analytics.TransactionServer> <transactionServer>k__BackingField;

            /*0x173b070*/ AnalyticsTransactionReceipt();
            /*0x173b040*/ string get_transactionReceipt();
            /*0x173b048*/ void set_transactionReceipt(string value);
            /*0x173b050*/ string get_transactionReceiptSignature();
            /*0x173b058*/ void set_transactionReceiptSignature(string value);
            /*0x173b060*/ System.Nullable<Unity.Services.Analytics.TransactionServer> get_transactionServer();
            /*0x173b068*/ void set_transactionServer(System.Nullable<Unity.Services.Analytics.TransactionServer> value);
        }

        class GoogleReceipt
        {
            /*0x10*/ string json;
            /*0x18*/ string signature;

            /*0x173b078*/ GoogleReceipt();
        }

        class IDs : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>, System.Collections.IEnumerable
        {
            /*0x10*/ System.Collections.Generic.Dictionary<string, string> m_Dic;

            /*0x173b3b8*/ IDs();
            /*0x173b080*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x173b114*/ void Add(string id, string[] stores);
            /*0x173b1c0*/ void Add(string id, object[] stores);
            /*0x173b280*/ string SpecificIDForStore(string store, string defaultValue);
            /*0x173b324*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>> GetEnumerator();
        }

        class ConfigurationBuilder
        {
            /*0x10*/ UnityEngine.Purchasing.PurchasingFactory m_Factory;
            /*0x18*/ System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> m_Products;
            /*0x20*/ bool <useCatalogProvider>k__BackingField;

            static /*0x173b4e8*/ UnityEngine.Purchasing.ConfigurationBuilder Instance(UnityEngine.Purchasing.Extension.IPurchasingModule first, UnityEngine.Purchasing.Extension.IPurchasingModule[] rest);
            /*0x173b434*/ ConfigurationBuilder(UnityEngine.Purchasing.PurchasingFactory factory);
            /*0x173b4c4*/ bool get_useCatalogProvider();
            /*0x173b4cc*/ void set_useCatalogProvider(bool value);
            /*0x173b4d8*/ System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> get_products();
            /*0x173b4e0*/ UnityEngine.Purchasing.PurchasingFactory get_factory();
            T Configure<T>();
            /*0x173b764*/ UnityEngine.Purchasing.ConfigurationBuilder AddProduct(string id, UnityEngine.Purchasing.ProductType type);
            /*0x173b770*/ UnityEngine.Purchasing.ConfigurationBuilder AddProduct(string id, UnityEngine.Purchasing.ProductType type, UnityEngine.Purchasing.IDs storeIDs);
            /*0x173b860*/ UnityEngine.Purchasing.ConfigurationBuilder AddProduct(string id, UnityEngine.Purchasing.ProductType type, UnityEngine.Purchasing.IDs storeIDs, UnityEngine.Purchasing.PayoutDefinition payout);
            /*0x173b778*/ UnityEngine.Purchasing.ConfigurationBuilder AddProduct(string id, UnityEngine.Purchasing.ProductType type, UnityEngine.Purchasing.IDs storeIDs, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.PayoutDefinition> payouts);
            /*0x173ba1c*/ UnityEngine.Purchasing.ConfigurationBuilder AddProducts(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products);
        }

        interface IUnityServicesInitializationChecker
        {
            void CheckAndLogWarning();
        }

        class UnityServicesInitializationChecker : UnityEngine.Purchasing.IUnityServicesInitializationChecker
        {
            static string UgsUninitializedMessage = "<b>Unity In-App Purchasing</b> requires <b>Unity Gaming Services</b> to have been initialized before use.
- Find out how to initialize <b>Unity Gaming Services</b> by following the documentation <i>https://docs.unity.com/ugs-overview/services-core-api.html#InitializationExample</i>
or download the <i>06 Initialize Gaming Services</i> sample from <i>Package Manager > In-App Purchasing > Samples</i>.
- If you are using the codeless API, you may want to enable the enable <b>Unity Gaming Services</b> automatic initialization by checking the <b>Automatically initialize Unity Gaming Services</b> checkbox at the bottom of the <b>IAP Catalog</b> window";
            /*0x10*/ UnityEngine.ILogger m_Logger;

            /*0x173bd1c*/ UnityServicesInitializationChecker(UnityEngine.ILogger logger);
            /*0x173bd44*/ void CheckAndLogWarning();
            /*0x173bd68*/ bool IsUninitialized();
            /*0x173bdc4*/ void LogWarning();
        }

        interface IStoreExtension
        {
        }

        interface IExtensionProvider
        {
            T GetExtension<T>();
        }

        interface IInternalStoreListener
        {
            void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error);
            UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e);
            void OnPurchaseFailed(UnityEngine.Purchasing.Product i, UnityEngine.Purchasing.PurchaseFailureReason p);
            void OnInitialized(UnityEngine.Purchasing.IStoreController controller);
        }

        enum InitializationFailureReason
        {
            PurchasingUnavailable = 0,
            NoProductsAvailable = 1,
            AppNotKnown = 2,
        }

        interface IStoreController
        {
            UnityEngine.Purchasing.ProductCollection get_products();
            void InitiatePurchase(UnityEngine.Purchasing.Product product, string payload);
            void InitiatePurchase(string productId, string payload);
            void InitiatePurchase(UnityEngine.Purchasing.Product product);
            void InitiatePurchase(string productId);
            void FetchAdditionalProducts(System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> additionalProducts, System.Action successCallback, System.Action<UnityEngine.Purchasing.InitializationFailureReason> failCallback);
            void ConfirmPendingPurchase(UnityEngine.Purchasing.Product product);
        }

        interface IStoreListener
        {
            void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error);
            UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs purchaseEvent);
            void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason failureReason);
            void OnInitialized(UnityEngine.Purchasing.IStoreController controller, UnityEngine.Purchasing.IExtensionProvider extensions);
        }

        class PayoutDefinition
        {
            static int MaxSubtypeLength = 64;
            static int MaxDataLength = 1024;
            /*0x10*/ UnityEngine.Purchasing.PayoutType m_Type;
            /*0x18*/ string m_Subtype;
            /*0x20*/ double m_Quantity;
            /*0x28*/ string m_Data;

            /*0x173c0b8*/ PayoutDefinition();
            /*0x173c114*/ PayoutDefinition(string typeString, string subtype, double quantity);
            /*0x173c18c*/ PayoutDefinition(string typeString, string subtype, double quantity, string data);
            /*0x173c350*/ PayoutDefinition(string subtype, double quantity);
            /*0x173c468*/ PayoutDefinition(string subtype, double quantity, string data);
            /*0x173c478*/ PayoutDefinition(UnityEngine.Purchasing.PayoutType type, string subtype, double quantity);
            /*0x173c3c4*/ PayoutDefinition(UnityEngine.Purchasing.PayoutType type, string subtype, double quantity, string data);
            /*0x173bed0*/ UnityEngine.Purchasing.PayoutType get_type();
            /*0x173bed8*/ void set_type(UnityEngine.Purchasing.PayoutType value);
            /*0x173bee0*/ string get_typeString();
            /*0x173bf48*/ string get_subtype();
            /*0x173bf50*/ void set_subtype(string value);
            /*0x173bff8*/ double get_quantity();
            /*0x173c000*/ void set_quantity(double value);
            /*0x173c008*/ string get_data();
            /*0x173c010*/ void set_data(string value);
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

            /*0x173c4f0*/ Product(UnityEngine.Purchasing.ProductDefinition definition, UnityEngine.Purchasing.ProductMetadata metadata, string receipt);
            /*0x173c52c*/ Product(UnityEngine.Purchasing.ProductDefinition definition, UnityEngine.Purchasing.ProductMetadata metadata);
            /*0x173c55c*/ UnityEngine.Purchasing.ProductDefinition get_definition();
            /*0x173c564*/ void set_definition(UnityEngine.Purchasing.ProductDefinition value);
            /*0x173c56c*/ UnityEngine.Purchasing.ProductMetadata get_metadata();
            /*0x173c574*/ void set_metadata(UnityEngine.Purchasing.ProductMetadata value);
            /*0x173c57c*/ bool get_availableToPurchase();
            /*0x173c584*/ void set_availableToPurchase(bool value);
            /*0x173c590*/ string get_transactionID();
            /*0x173c598*/ void set_transactionID(string value);
            /*0x173c5a0*/ bool get_hasReceipt();
            /*0x173c5c0*/ string get_receipt();
            /*0x173c5c8*/ void set_receipt(string value);
            /*0x173c5d0*/ bool Equals(object obj);
            /*0x173c674*/ int GetHashCode();
        }

        class ProductCollection
        {
            /*0x10*/ System.Collections.Generic.Dictionary<string, UnityEngine.Purchasing.Product> m_IdToProduct;
            /*0x18*/ System.Collections.Generic.Dictionary<string, UnityEngine.Purchasing.Product> m_StoreSpecificIdToProduct;
            /*0x20*/ UnityEngine.Purchasing.Product[] m_Products;
            /*0x28*/ System.Collections.Generic.HashSet<UnityEngine.Purchasing.Product> m_ProductSet;

            /*0x173c694*/ ProductCollection(UnityEngine.Purchasing.Product[] products);
            /*0x173c728*/ void AddProducts(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Product> products);
            /*0x173c914*/ System.Collections.Generic.HashSet<UnityEngine.Purchasing.Product> get_set();
            /*0x173c91c*/ UnityEngine.Purchasing.Product[] get_all();
            /*0x173c924*/ UnityEngine.Purchasing.Product WithID(string id);
            /*0x173c994*/ UnityEngine.Purchasing.Product WithStoreSpecificID(string id);

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.ProductCollection.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.Purchasing.Product, string> <>9__5_0;
                static /*0x10*/ System.Func<UnityEngine.Purchasing.Product, string> <>9__5_1;

                static /*0x173ca10*/ <>c();
                /*0x173ca74*/ <>c();
                /*0x173ca7c*/ string <AddProducts>b__5_0(UnityEngine.Purchasing.Product x);
                /*0x173ca9c*/ string <AddProducts>b__5_1(UnityEngine.Purchasing.Product x);
            }
        }

        class ProductDefinition
        {
            /*0x10*/ string <id>k__BackingField;
            /*0x18*/ string <storeSpecificId>k__BackingField;
            /*0x20*/ UnityEngine.Purchasing.ProductType <type>k__BackingField;
            /*0x24*/ bool <enabled>k__BackingField;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.Purchasing.PayoutDefinition> m_Payouts;

            /*0x173cabc*/ ProductDefinition();
            /*0x173b970*/ ProductDefinition(string id, string storeSpecificId, UnityEngine.Purchasing.ProductType type);
            /*0x173cb38*/ ProductDefinition(string id, string storeSpecificId, UnityEngine.Purchasing.ProductType type, bool enabled);
            /*0x173cc08*/ ProductDefinition(string id, string storeSpecificId, UnityEngine.Purchasing.ProductType type, bool enabled, UnityEngine.Purchasing.PayoutDefinition payout);
            /*0x173cb44*/ ProductDefinition(string id, string storeSpecificId, UnityEngine.Purchasing.ProductType type, bool enabled, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.PayoutDefinition> payouts);
            /*0x173cd28*/ ProductDefinition(string id, UnityEngine.Purchasing.ProductType type);
            /*0x173cd3c*/ string get_id();
            /*0x173cd44*/ void set_id(string value);
            /*0x173cd4c*/ string get_storeSpecificId();
            /*0x173cd54*/ void set_storeSpecificId(string value);
            /*0x173cd5c*/ UnityEngine.Purchasing.ProductType get_type();
            /*0x173cd64*/ void set_type(UnityEngine.Purchasing.ProductType value);
            /*0x173cd6c*/ bool get_enabled();
            /*0x173cd74*/ void set_enabled(bool value);
            /*0x173cd80*/ bool Equals(object obj);
            /*0x173ce1c*/ int GetHashCode();
            /*0x173ce3c*/ System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.PayoutDefinition> get_payouts();
            /*0x173ce44*/ UnityEngine.Purchasing.PayoutDefinition get_payout();
            /*0x173b97c*/ void SetPayouts(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.PayoutDefinition> newPayouts);
        }

        class ProductMetadata
        {
            /*0x10*/ string <localizedPriceString>k__BackingField;
            /*0x18*/ string <localizedTitle>k__BackingField;
            /*0x20*/ string <localizedDescription>k__BackingField;
            /*0x28*/ string <isoCurrencyCode>k__BackingField;
            /*0x30*/ decimal <localizedPrice>k__BackingField;

            /*0x173cec0*/ ProductMetadata(string priceString, string title, string description, string currencyCode, decimal localizedPrice);
            /*0x173cf14*/ ProductMetadata();
            /*0x173cf1c*/ string get_localizedPriceString();
            /*0x173cf24*/ void set_localizedPriceString(string value);
            /*0x173cf2c*/ string get_localizedTitle();
            /*0x173cf34*/ void set_localizedTitle(string value);
            /*0x173cf3c*/ string get_localizedDescription();
            /*0x173cf44*/ void set_localizedDescription(string value);
            /*0x173cf4c*/ string get_isoCurrencyCode();
            /*0x173cf54*/ void set_isoCurrencyCode(string value);
            /*0x173cf5c*/ decimal get_localizedPrice();
            /*0x173cf68*/ void set_localizedPrice(decimal value);
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

            /*0x173cf70*/ PurchaseEventArgs(UnityEngine.Purchasing.Product purchasedProduct);
            /*0x173cf98*/ UnityEngine.Purchasing.Product get_purchasedProduct();
            /*0x173cfa0*/ void set_purchasedProduct(UnityEngine.Purchasing.Product value);
        }

        class PurchaseFailedEventArgs
        {
            /*0x10*/ UnityEngine.Purchasing.Product <purchasedProduct>k__BackingField;
            /*0x18*/ UnityEngine.Purchasing.PurchaseFailureReason <reason>k__BackingField;
            /*0x20*/ string <message>k__BackingField;

            /*0x173cfa8*/ PurchaseFailedEventArgs(UnityEngine.Purchasing.Product purchasedProduct, UnityEngine.Purchasing.PurchaseFailureReason reason, string message);
            /*0x173cfe8*/ UnityEngine.Purchasing.Product get_purchasedProduct();
            /*0x173cff0*/ void set_purchasedProduct(UnityEngine.Purchasing.Product value);
            /*0x173cff8*/ UnityEngine.Purchasing.PurchaseFailureReason get_reason();
            /*0x173d000*/ void set_reason(UnityEngine.Purchasing.PurchaseFailureReason value);
            /*0x173d008*/ string get_message();
            /*0x173d010*/ void set_message(string value);
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

            /*0x173b584*/ PurchasingFactory(UnityEngine.Purchasing.Extension.IPurchasingModule first, UnityEngine.Purchasing.Extension.IPurchasingModule[] remainingModules);
            /*0x173d018*/ string get_storeName();
            /*0x173d020*/ void set_storeName(string value);
            /*0x173d028*/ UnityEngine.Purchasing.Extension.IStore get_service();
            /*0x173d088*/ void set_service(UnityEngine.Purchasing.Extension.IStore value);
            /*0x173d090*/ void RegisterStore(string name, UnityEngine.Purchasing.Extension.IStore s);
            void RegisterExtension<T>(T instance);
            void RegisterConfiguration<T>(T instance);
            T GetConfig<T>();
            T GetExtension<T>();
            /*0x173d0a8*/ void SetCatalogProvider(UnityEngine.Purchasing.Extension.ICatalogProvider provider);
            /*0x173d0b0*/ void SetCatalogProviderFunction(System.Action<System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>>> func);
            /*0x173d148*/ UnityEngine.Purchasing.Extension.ICatalogProvider GetCatalogProvider();
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

            static /*0x173ddd0*/ void ClearProductReceipt(UnityEngine.Purchasing.Product product);
            /*0x173d164*/ PurchasingManager(UnityEngine.Purchasing.TransactionLog tDb, UnityEngine.ILogger logger, UnityEngine.Purchasing.Extension.IStore store, string storeName, UnityEngine.Purchasing.IUnityServicesInitializationChecker unityServicesInitializationChecker);
            /*0x173d150*/ bool get_useTransactionLog();
            /*0x173d158*/ void set_useTransactionLog(bool value);
            /*0x173d1bc*/ void InitiatePurchase(UnityEngine.Purchasing.Product product);
            /*0x173d414*/ void InitiatePurchase(string productId);
            /*0x173d21c*/ void InitiatePurchase(UnityEngine.Purchasing.Product product, string developerPayload);
            /*0x173d474*/ void InitiatePurchase(string purchasableId, string developerPayload);
            /*0x173d5d8*/ void ConfirmPendingPurchase(UnityEngine.Purchasing.Product product);
            /*0x173d900*/ UnityEngine.Purchasing.ProductCollection get_products();
            /*0x173d908*/ void set_products(UnityEngine.Purchasing.ProductCollection value);
            /*0x173d910*/ void OnPurchaseSucceeded(string id, string receipt, string transactionId);
            /*0x173da2c*/ void UpdateProductReceiptAndTrandsactionID(UnityEngine.Purchasing.Product product, string receipt, string transactionId);
            /*0x173dc30*/ void OnAllPurchasesRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchasedProducts);
            /*0x173dd94*/ void HandlePurchaseRetrieved(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Product purchasedProduct);
            /*0x173dde8*/ void OnSetupFailed(UnityEngine.Purchasing.InitializationFailureReason reason);
            /*0x173debc*/ void OnPurchaseFailed(UnityEngine.Purchasing.Extension.PurchaseFailureDescription description);
            /*0x173e340*/ void OnProductsRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products);
            /*0x173dc1c*/ string CreateUnifiedReceipt(string rawReceipt, string transactionId);
            /*0x173e74c*/ void ProcessPurchaseOnStart();
            /*0x173e940*/ void FetchAdditionalProducts(System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> additionalProducts, System.Action successCallback, System.Action<UnityEngine.Purchasing.InitializationFailureReason> failCallback);
            /*0x173da64*/ void ProcessPurchaseIfNew(UnityEngine.Purchasing.Product product);
            /*0x173e650*/ void CheckForInitialization();
            /*0x173eba8*/ bool HasAvailableProductsToPurchase(bool shouldLogUnavailableProducts);
            /*0x173eec0*/ void Initialize(UnityEngine.Purchasing.IInternalStoreListener listener, System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> products);

            class <>c__DisplayClass24_0
            {
                /*0x10*/ UnityEngine.Purchasing.Product product;

                /*0x173dd8c*/ <>c__DisplayClass24_0();
                /*0x173f16c*/ bool <OnAllPurchasesRetrieved>b__0(UnityEngine.Purchasing.Product firstPurchasedProduct);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.PurchasingManager.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.Purchasing.ProductDefinition, UnityEngine.Purchasing.Product> <>9__32_0;
                static /*0x10*/ System.Func<UnityEngine.Purchasing.ProductDefinition, UnityEngine.Purchasing.Product> <>9__37_0;

                static /*0x173f1a4*/ <>c();
                /*0x173f208*/ <>c();
                /*0x173f210*/ UnityEngine.Purchasing.Product <FetchAdditionalProducts>b__32_0(UnityEngine.Purchasing.ProductDefinition x);
                /*0x173f2a4*/ UnityEngine.Purchasing.Product <Initialize>b__37_0(UnityEngine.Purchasing.ProductDefinition x);
            }
        }

        class SimpleCatalogProvider : UnityEngine.Purchasing.Extension.ICatalogProvider
        {
            /*0x10*/ System.Action<System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>>> m_Func;

            /*0x173d120*/ SimpleCatalogProvider(System.Action<System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>>> func);
            /*0x173f338*/ void FetchProducts(System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>> callback);
        }

        class StoreListenerProxy : UnityEngine.Purchasing.IInternalStoreListener
        {
            /*0x10*/ UnityEngine.Purchasing.IAnalyticsClient m_Analytics;
            /*0x18*/ UnityEngine.Purchasing.IStoreListener m_ForwardTo;
            /*0x20*/ UnityEngine.Purchasing.IExtensionProvider m_Extensions;

            /*0x173f354*/ StoreListenerProxy(UnityEngine.Purchasing.IStoreListener forwardTo, UnityEngine.Purchasing.IAnalyticsClient analytics, UnityEngine.Purchasing.IExtensionProvider extensions);
            /*0x173f390*/ void OnInitialized(UnityEngine.Purchasing.IStoreController controller);
            /*0x173f444*/ void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error);
            /*0x173f4ec*/ UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e);
            /*0x173f620*/ void OnPurchaseFailed(UnityEngine.Purchasing.Product i, UnityEngine.Purchasing.PurchaseFailureReason p);
        }

        class TransactionLog
        {
            /*0x10*/ UnityEngine.ILogger logger;
            /*0x18*/ string persistentDataPath;

            static /*0x173f8b0*/ string ComputeHash(string transactionID);
            /*0x173f75c*/ TransactionLog(UnityEngine.ILogger logger, string persistentDataPath);
            /*0x173f824*/ void Clear();
            /*0x173eb4c*/ bool HasRecordOf(string transactionID);
            /*0x173d7c0*/ void Record(string transactionID);
            /*0x173f834*/ string GetRecordPath(string transactionID);
        }

        class UnifiedReceipt
        {
            /*0x10*/ string Payload;
            /*0x18*/ string Store;
            /*0x20*/ string TransactionID;

            /*0x173fa54*/ UnifiedReceipt();
        }

        class UnifiedReceiptExtensions
        {
            static /*0x173a1d4*/ UnityEngine.Purchasing.AnalyticsTransactionReceipt ToReceiptAndSignature(UnityEngine.Purchasing.UnifiedReceipt receipt);
            static /*0x173fa5c*/ System.Nullable<Unity.Services.Analytics.TransactionServer> ToTransactionServer(UnityEngine.Purchasing.UnifiedReceipt receipt);
            static /*0x173fba0*/ string EscapeEmbeddedQuotationMarks(string receipt);
        }

        class UnityPurchasing
        {
            static /*0x173fc18*/ void Initialize(UnityEngine.Purchasing.IStoreListener listener, UnityEngine.Purchasing.ConfigurationBuilder builder);
            static /*0x173fd3c*/ UnityEngine.Purchasing.IAnalyticsAdapter GenerateUnityAnalytics();
            static /*0x173fdfc*/ UnityEngine.Purchasing.IAnalyticsAdapter GenerateLegacyUnityAnalytics();
            static /*0x1740108*/ void ClearTransactionLog();
            static /*0x173fe88*/ void Initialize(UnityEngine.Purchasing.IStoreListener listener, UnityEngine.Purchasing.ConfigurationBuilder builder, UnityEngine.ILogger logger, string persistentDatapath, UnityEngine.Purchasing.IAnalyticsAdapter analytics, UnityEngine.Purchasing.IAnalyticsAdapter legacyAnalytics, UnityEngine.Purchasing.Extension.ICatalogProvider catalog, UnityEngine.Purchasing.IUnityServicesInitializationChecker unityServicesInitializationChecker);
            static /*0x17401e8*/ void FetchAndMergeProducts(bool useCatalog, System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> localProductSet, UnityEngine.Purchasing.Extension.ICatalogProvider catalog, System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>> callback);
            /*0x174033c*/ UnityPurchasing();

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.Purchasing.PurchasingManager manager;
                /*0x18*/ UnityEngine.Purchasing.StoreListenerProxy proxy;

                /*0x17401e0*/ <>c__DisplayClass4_0();
                /*0x1740344*/ void <Initialize>b__0(System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> response);
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> localProductSet;
                /*0x18*/ System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>> callback;

                /*0x1740334*/ <>c__DisplayClass5_0();
                /*0x1740368*/ void <FetchAndMergeProducts>b__0(System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> cloudProducts);
            }
        }

        class LoggerExtensions
        {
            static string IAPLogTag = "Unity IAP";

            static /*0x173be0c*/ void LogIAPWarning(UnityEngine.ILogger logger, string message);
            static /*0x173d6fc*/ void LogIAPError(UnityEngine.ILogger logger, string message);
        }

        class ProductPurchaseUpdater
        {
            static /*0x1740564*/ void UpdateProductReceiptAndTransactionID(UnityEngine.Purchasing.Product product, string receipt, string transactionId, string storeName);
        }

        class UnifiedReceiptFormatter
        {
            static /*0x173e8c4*/ string FormatUnifiedReceipt(string platformReceipt, string transactionId, string storeName);
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

            class TelemetryDiagnosticNames
            {
                static string FetchPurchasesError = "fetch_purchases_error";
                static string InvalidProductError = "invalid_product_error";
                static string ParseReceiptTransactionError = "parse_receipt_transaction_error";
            }

            struct TelemetryDiagnosticParams
            {
                /*0x10*/ string name;
                /*0x18*/ string exception;

                /*0x174059c*/ TelemetryDiagnosticParams(string diagnosticName, string diagnosticException);
            }

            class TelemetryDiagnostics : UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics
            {
                /*0x10*/ UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper m_TelemetryDiagnosticsInstanceWrapper;

                /*0x17405a4*/ TelemetryDiagnostics(UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper telemetryDiagnosticsInstanceWrapper);
                /*0x17405cc*/ void SendDiagnostic(string diagnosticName, System.Exception e);
            }

            class TelemetryDiagnosticsInstanceWrapper : UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper
            {
                /*0x10*/ Unity.Services.Core.Telemetry.Internal.IDiagnostics m_Instance;
                /*0x18*/ UnityEngine.Purchasing.Telemetry.TelemetryQueue<UnityEngine.Purchasing.Telemetry.TelemetryDiagnosticParams> m_Queue;

                /*0x17406a0*/ TelemetryDiagnosticsInstanceWrapper();
                /*0x174076c*/ void SetDiagnosticsInstance(Unity.Services.Core.Telemetry.Internal.IDiagnostics diagnosticsInstance);
                /*0x17407c4*/ void SendDiagnostic(string diagnosticName, string diagnosticException);
                /*0x1740850*/ void SendDiagnostic(UnityEngine.Purchasing.Telemetry.TelemetryDiagnosticParams diagnosticParams);
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
                UnityEngine.Purchasing.Telemetry.ITelemetryMetricEvent CreateAndStartMetricEvent(UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition metricDefinition);
            }

            struct TelemetryMetricDefinition
            {
                /*0x10*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes <MetricType>k__BackingField;
                /*0x18*/ string <MetricName>k__BackingField;

                static /*0x1740928*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition op_Implicit(string name);
                /*0x174091c*/ TelemetryMetricDefinition(string metricName, UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes metricType);
                /*0x174090c*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes get_MetricType();
                /*0x1740914*/ string get_MetricName();
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

                static /*0x1740934*/ TelemetryMetricDefinitions();
            }

            class TelemetryMetricEvent : UnityEngine.Purchasing.Telemetry.ITelemetryMetricEvent
            {
                /*0x10*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper m_TelemetryMetricsInstanceWrapper;
                /*0x18*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes m_MetricType;
                /*0x20*/ string m_MetricName;
                /*0x28*/ System.Diagnostics.Stopwatch m_Stopwatch;

                /*0x1740bac*/ TelemetryMetricEvent(UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper, UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes metricType, string metricName);
                /*0x1740c40*/ void StartMetric();
                /*0x1740cd0*/ void StopAndSendMetric();
            }

            struct TelemetryMetricParams
            {
                /*0x10*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes type;
                /*0x18*/ string name;
                /*0x20*/ double timeSeconds;

                /*0x1740e10*/ TelemetryMetricParams(UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes metricType, string metricName, double metricTimeSeconds);
            }

            class TelemetryMetricsInstanceWrapper : UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper
            {
                /*0x10*/ Unity.Services.Core.Telemetry.Internal.IMetrics m_Instance;
                /*0x18*/ UnityEngine.Purchasing.Telemetry.TelemetryQueue<UnityEngine.Purchasing.Telemetry.TelemetryMetricParams> m_Queue;

                /*0x1740e20*/ TelemetryMetricsInstanceWrapper();
                /*0x1740eec*/ void SetMetricsInstance(Unity.Services.Core.Telemetry.Internal.IMetrics metricsInstance);
                /*0x1740f54*/ void SendMetric(UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes metricType, string metricName, double metricTimeSeconds);
                /*0x1741000*/ void SendMetricByType(UnityEngine.Purchasing.Telemetry.TelemetryMetricParams metricParams);
            }

            class TelemetryMetricsService : UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService
            {
                /*0x10*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper m_TelemetryMetricsInstanceWrapper;

                /*0x1741198*/ TelemetryMetricsService(UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper);
                /*0x17411c0*/ void ExecuteTimedAction(System.Action timedAction, UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition metricDefinition);
                /*0x174129c*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricEvent CreateAndStartMetricEvent(UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition metricDefinition);
            }

            enum TelemetryMetricTypes
            {
                Gauge = 0,
                Sum = 1,
                Histogram = 2,
            }

            class TelemetryQueue<TTelemetryEventParams>
            {
                static int k_maxQueueSize = 10;
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

                /*0x174144c*/ AbstractPurchasingModule();
                /*0x1741384*/ void Configure(UnityEngine.Purchasing.Extension.IPurchasingBinder binder);
                /*0x1741394*/ void RegisterStore(string name, UnityEngine.Purchasing.Extension.IStore store);
                void BindExtension<T>(T instance);
                void BindConfiguration<T>(T instance);
                void Configure();
            }

            class AbstractStore : UnityEngine.Purchasing.Extension.IStore
            {
                /*0x1741454*/ AbstractStore();
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
                void SetCatalogProvider(UnityEngine.Purchasing.Extension.ICatalogProvider provider);
                void SetCatalogProviderFunction(System.Action<System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>>> func);
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
                bool get_useTransactionLog();
                void set_useTransactionLog(bool value);
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

                /*0x174145c*/ ProductDescription(string id, UnityEngine.Purchasing.ProductMetadata metadata, string receipt, string transactionId);
                /*0x17414a0*/ ProductDescription(string id, UnityEngine.Purchasing.ProductMetadata metadata, string receipt, string transactionId, UnityEngine.Purchasing.ProductType type);
                /*0x17414f4*/ ProductDescription(string id, UnityEngine.Purchasing.ProductMetadata metadata);
                /*0x1741528*/ string get_storeSpecificId();
                /*0x1741530*/ void set_storeSpecificId(string value);
                /*0x1741538*/ UnityEngine.Purchasing.ProductMetadata get_metadata();
                /*0x1741540*/ void set_metadata(UnityEngine.Purchasing.ProductMetadata value);
                /*0x1741548*/ string get_receipt();
                /*0x1741550*/ void set_receipt(string value);
                /*0x1741558*/ string get_transactionId();
                /*0x1741560*/ void set_transactionId(string value);
            }

            class PurchaseFailureDescription
            {
                /*0x10*/ string <productId>k__BackingField;
                /*0x18*/ UnityEngine.Purchasing.PurchaseFailureReason <reason>k__BackingField;
                /*0x20*/ string <message>k__BackingField;

                /*0x1741568*/ PurchaseFailureDescription(string productId, UnityEngine.Purchasing.PurchaseFailureReason reason, string message);
                /*0x17415a8*/ string get_productId();
                /*0x17415b0*/ void set_productId(string value);
                /*0x17415b8*/ UnityEngine.Purchasing.PurchaseFailureReason get_reason();
                /*0x17415c0*/ void set_reason(UnityEngine.Purchasing.PurchaseFailureReason value);
                /*0x17415c8*/ string get_message();
                /*0x17415d0*/ void set_message(string value);
            }
        }
    }
}
