class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x7f18ffc*/ EmbeddedAttribute();
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

                /*0x7f19004*/ NullableAttribute(byte );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x7f1908c*/ NullableContextAttribute(byte );
            }
        }
    }
}

namespace Uniject
{
    interface IUtil
    {
        /*0x380bb68*/ object InitiateCoroutine(System.Collections.IEnumerator start);
        /*0x380d8b8*/ void InitiateCoroutine(System.Collections.IEnumerator start, int delayInSeconds);
        /*0x380d83c*/ void RunOnMainThread(System.Action runnable);
        /*0x380d83c*/ void AddPauseListener(System.Action<bool> runnable);
        /*0x380b32c*/ bool IsClassOrSubclass(System.Type potentialBase, System.Type potentialDescendant);
    }
}

namespace UnityEngine
{
    namespace Purchasing
    {
        class AnalyticsClient : UnityEngine.Purchasing.IAnalyticsClient
        {
            /*0x10*/ UnityEngine.Purchasing.IAnalyticsAdapter m_Analytics;
            /*0x18*/ UnityEngine.Purchasing.IAnalyticsAdapter m_LegacyAnalytics;

            /*0x7f190b4*/ AnalyticsClient(UnityEngine.Purchasing.IAnalyticsAdapter analytics, UnityEngine.Purchasing.IAnalyticsAdapter legacyAnalytics);
            /*0x7f190f8*/ void OnPurchaseSucceeded(UnityEngine.Purchasing.Product product);
            /*0x7f19230*/ void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Extension.PurchaseFailureDescription description);
        }

        class EmptyAnalyticsAdapter : UnityEngine.Purchasing.IAnalyticsAdapter
        {
            /*0x7f19360*/ EmptyAnalyticsAdapter();
            /*0x7f19358*/ void SendTransactionEvent(UnityEngine.Purchasing.Product product);
            /*0x7f1935c*/ void SendTransactionFailedEvent(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Extension.PurchaseFailureDescription reason);
        }

        interface IAnalyticsAdapter
        {
            /*0x380d83c*/ void SendTransactionEvent(UnityEngine.Purchasing.Product product);
            /*0x380d93c*/ void SendTransactionFailedEvent(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Extension.PurchaseFailureDescription description);
        }

        interface IAnalyticsClient
        {
            /*0x380d83c*/ void OnPurchaseSucceeded(UnityEngine.Purchasing.Product product);
            /*0x380d93c*/ void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Extension.PurchaseFailureDescription purchaseFailureDescription);
        }

        interface ILegacyUnityAnalytics
        {
            void SendTransactionEvent(string productId, decimal amount, string currency, string receiptPurchaseData, string signature);
            /*0x380d93c*/ void SendCustomEvent(string name, System.Collections.Generic.Dictionary<string, object> data);
        }

        class LegacyAnalyticsAdapter : UnityEngine.Purchasing.IAnalyticsAdapter
        {
            /*0x10*/ UnityEngine.Purchasing.ILegacyUnityAnalytics m_LegacyAnalytics;

            /*0x7f19368*/ LegacyAnalyticsAdapter(UnityEngine.Purchasing.ILegacyUnityAnalytics legacyAnalytics);
            /*0x7f19398*/ void SendTransactionEvent(UnityEngine.Purchasing.Product product);
            /*0x7f19488*/ void SendTransactionFailedEvent(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Extension.PurchaseFailureDescription description);
        }

        class LegacyAnalyticsWrapper : UnityEngine.Purchasing.IAnalyticsAdapter, UnityEngine.Purchasing.ICoreServicesEnvironmentObserver
        {
            /*0x10*/ bool m_Enabled;
            /*0x18*/ UnityEngine.Purchasing.IAnalyticsAdapter m_LegacyAdapter;
            /*0x20*/ UnityEngine.Purchasing.IAnalyticsAdapter m_EmptyAdapter;

            /*0x7f196f4*/ LegacyAnalyticsWrapper(UnityEngine.Purchasing.IAnalyticsAdapter legacyAdapter, UnityEngine.Purchasing.IAnalyticsAdapter emptyAdapter);
            /*0x7f19930*/ void SendTransactionEvent(UnityEngine.Purchasing.Product product);
            /*0x7f19a08*/ void SendTransactionFailedEvent(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Extension.PurchaseFailureDescription description);
            /*0x7f19ad8*/ void OnUpdatedCoreServicesEnvironment(string currentEnvironment);
            /*0x7f199ec*/ UnityEngine.Purchasing.IAnalyticsAdapter get_m_AnalyticsAdapter();
        }

        class LegacyUnityAnalytics : UnityEngine.Purchasing.ILegacyUnityAnalytics
        {
            /*0x7f19b8c*/ LegacyUnityAnalytics();
            /*0x7f19b5c*/ void SendTransactionEvent(string productId, decimal amount, string currency, string receiptPurchaseData, string signature);
            /*0x7f19b7c*/ void SendCustomEvent(string name, System.Collections.Generic.Dictionary<string, object> data);
        }

        class IDs : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>, System.Collections.IEnumerable
        {
            /*0x10*/ System.Collections.Generic.Dictionary<string, string> m_Dic;

            /*0x7f19b94*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x7f19c28*/ string SpecificIDForStore(string store, string defaultValue);
            /*0x7f19ccc*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>> GetEnumerator();
        }

        class ConfigurationBuilder
        {
            /*0x10*/ bool <useCatalogProvider>k__BackingField;
            /*0x11*/ bool <logUnavailableProducts>k__BackingField;
            /*0x18*/ System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> <products>k__BackingField;
            /*0x20*/ UnityEngine.Purchasing.PurchasingFactory <factory>k__BackingField;

            static /*0x7f19e24*/ UnityEngine.Purchasing.ConfigurationBuilder Instance(UnityEngine.Purchasing.Extension.IPurchasingModule first, UnityEngine.Purchasing.Extension.IPurchasingModule[] rest);
            /*0x7f19d60*/ ConfigurationBuilder(UnityEngine.Purchasing.PurchasingFactory factory);
            /*0x7f19e04*/ bool get_useCatalogProvider();
            /*0x7f19e0c*/ bool get_logUnavailableProducts();
            /*0x7f19e14*/ System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> get_products();
            /*0x7f19e1c*/ UnityEngine.Purchasing.PurchasingFactory get_factory();
            /*0x3907c14*/ T Configure<T>();
            /*0x7f1a0b4*/ UnityEngine.Purchasing.ConfigurationBuilder AddProduct(string id, UnityEngine.Purchasing.ProductType type);
            /*0x7f1a0c0*/ UnityEngine.Purchasing.ConfigurationBuilder AddProduct(string id, UnityEngine.Purchasing.ProductType type, UnityEngine.Purchasing.IDs storeIDs);
            /*0x7f1a0c8*/ UnityEngine.Purchasing.ConfigurationBuilder AddProduct(string id, UnityEngine.Purchasing.ProductType type, UnityEngine.Purchasing.IDs storeIDs, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.PayoutDefinition> payouts);
        }

        class CoreServicesEnvironmentSubject
        {
            static /*0x0*/ UnityEngine.Purchasing.CoreServicesEnvironmentSubject s_Instance;
            /*0x10*/ string m_LastKnownEnvironment;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Purchasing.ICoreServicesEnvironmentObserver> m_Observers;

            static /*0x7f19754*/ UnityEngine.Purchasing.CoreServicesEnvironmentSubject Instance();
            /*0x7f1a25c*/ CoreServicesEnvironmentSubject();
            /*0x7f197d8*/ void SubscribeToUpdatesAndGetCurrent(UnityEngine.Purchasing.ICoreServicesEnvironmentObserver newObserver);
            /*0x7f1a2e4*/ void UpdateCurrentEnvironment(string currentEnvironment);
            /*0x7f1a300*/ void NotifyObservers();
            /*0x7f19b10*/ bool IsDefaultLiveEnvironment(string environment);
        }

        interface ICoreServicesEnvironmentObserver
        {
            /*0x380d83c*/ void OnUpdatedCoreServicesEnvironment(string currentEnvironment);
        }

        interface IUnityServicesInitializationChecker
        {
            /*0x380cb08*/ void CheckAndLogWarning();
        }

        class UnityServicesInitializationChecker : UnityEngine.Purchasing.IUnityServicesInitializationChecker
        {
            /*0x10*/ UnityEngine.ILogger m_Logger;

            /*0x7f1a4b8*/ UnityServicesInitializationChecker(UnityEngine.ILogger logger);
            /*0x7f1a4e8*/ void CheckAndLogWarning();
            /*0x7f1a50c*/ bool IsUninitialized();
            /*0x7f1a62c*/ void LogWarning();
        }

        interface IStoreExtension
        {
        }

        interface IDetailedStoreListener : UnityEngine.Purchasing.IStoreListener
        {
            /*0x380d93c*/ void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Extension.PurchaseFailureDescription failureDescription);
        }

        interface IExtensionProvider
        {
            /*0x3907c14*/ T GetExtension<T>();
        }

        interface IInternalStoreListener
        {
            /*0x380d170*/ void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error, string message);
            /*0x380b7a8*/ UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e);
            /*0x380d93c*/ void OnPurchaseFailed(UnityEngine.Purchasing.Product i, UnityEngine.Purchasing.Extension.PurchaseFailureDescription p);
            /*0x380d83c*/ void OnInitialized(UnityEngine.Purchasing.IStoreController controller);
            /*0x380d83c*/ void SendTransactionEvent(UnityEngine.Purchasing.Product product);
        }

        enum InitializationFailureReason
        {
            PurchasingUnavailable = 0,
            NoProductsAvailable = 1,
            AppNotKnown = 2,
        }

        interface IStoreController
        {
            /*0x380b9e8*/ UnityEngine.Purchasing.ProductCollection get_products();
            /*0x380d93c*/ void InitiatePurchase(string productId, string payload);
            /*0x380d83c*/ void InitiatePurchase(UnityEngine.Purchasing.Product product);
            /*0x380d83c*/ void ConfirmPendingPurchase(UnityEngine.Purchasing.Product product);
        }

        interface IStoreListener
        {
            /*0x380d170*/ void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error, string message);
            /*0x380b7a8*/ UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs purchaseEvent);
            /*0x380d8b8*/ void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason failureReason);
            /*0x380d93c*/ void OnInitialized(UnityEngine.Purchasing.IStoreController controller, UnityEngine.Purchasing.IExtensionProvider extensions);
        }

        class PayoutDefinition
        {
            static int MaxSubtypeLength = 64;
            static int MaxDataLength = 1024;
            /*0x10*/ UnityEngine.Purchasing.PayoutType m_Type;
            /*0x18*/ string m_Subtype;
            /*0x20*/ double m_Quantity;
            /*0x28*/ string m_Data;

            /*0x7f1a738*/ PayoutDefinition();
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
            /*0x30*/ string <appleOriginalTransactionID>k__BackingField;
            /*0x38*/ bool <appleProductIsRestored>k__BackingField;
            /*0x40*/ string <receipt>k__BackingField;

            /*0x7f1a78c*/ Product(UnityEngine.Purchasing.ProductDefinition definition, UnityEngine.Purchasing.ProductMetadata metadata, string receipt);
            /*0x7f1a7ec*/ Product(UnityEngine.Purchasing.ProductDefinition definition, UnityEngine.Purchasing.ProductMetadata metadata);
            /*0x7f1a7f4*/ UnityEngine.Purchasing.ProductDefinition get_definition();
            /*0x7f1a7fc*/ void set_definition(UnityEngine.Purchasing.ProductDefinition value);
            /*0x7f1a804*/ UnityEngine.Purchasing.ProductMetadata get_metadata();
            /*0x7f1a80c*/ void set_metadata(UnityEngine.Purchasing.ProductMetadata value);
            /*0x7f1a814*/ bool get_availableToPurchase();
            /*0x7f1a81c*/ void set_availableToPurchase(bool value);
            /*0x7f1a828*/ string get_transactionID();
            /*0x7f1a830*/ void set_transactionID(string value);
            /*0x7f1a838*/ void set_appleOriginalTransactionID(string value);
            /*0x7f1a840*/ bool get_appleProductIsRestored();
            /*0x7f1a848*/ void set_appleProductIsRestored(bool value);
            /*0x7f1a854*/ bool get_hasReceipt();
            /*0x7f1a874*/ string get_receipt();
            /*0x7f1a87c*/ void set_receipt(string value);
            /*0x7f1a884*/ bool Equals(object obj);
            /*0x7f1a928*/ int GetHashCode();
        }

        class ProductCollection
        {
            /*0x10*/ System.Collections.Generic.Dictionary<string, UnityEngine.Purchasing.Product> m_IdToProduct;
            /*0x18*/ System.Collections.Generic.Dictionary<string, UnityEngine.Purchasing.Product> m_StoreSpecificIdToProduct;
            /*0x20*/ System.Collections.Generic.HashSet<UnityEngine.Purchasing.Product> <set>k__BackingField;
            /*0x28*/ UnityEngine.Purchasing.Product[] <all>k__BackingField;

            /*0x7f1a948*/ ProductCollection(UnityEngine.Purchasing.Product[] products);
            /*0x7f1a9e0*/ void AddProducts(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Product> products);
            /*0x7f1ac04*/ System.Collections.Generic.HashSet<UnityEngine.Purchasing.Product> get_set();
            /*0x7f1ac0c*/ UnityEngine.Purchasing.Product[] get_all();
            /*0x7f1ac14*/ void set_all(UnityEngine.Purchasing.Product[] value);
            /*0x7f1ac1c*/ UnityEngine.Purchasing.Product WithID(string id);
            /*0x7f1ac8c*/ UnityEngine.Purchasing.Product WithStoreSpecificID(string id);

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.ProductCollection.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.Purchasing.Product, string> <>9__3_0;
                static /*0x10*/ System.Func<UnityEngine.Purchasing.Product, string> <>9__3_1;

                static /*0x7f1ad08*/ <>c();
                /*0x7f1ad70*/ <>c();
                /*0x7f1ad78*/ string <AddProducts>b__3_0(UnityEngine.Purchasing.Product x);
                /*0x7f1ad98*/ string <AddProducts>b__3_1(UnityEngine.Purchasing.Product x);
            }
        }

        class ProductDefinition
        {
            /*0x10*/ string <id>k__BackingField;
            /*0x18*/ string <storeSpecificId>k__BackingField;
            /*0x20*/ UnityEngine.Purchasing.ProductType <type>k__BackingField;
            /*0x24*/ bool <enabled>k__BackingField;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.Purchasing.PayoutDefinition> m_Payouts;

            /*0x7f1adb8*/ ProductDefinition();
            /*0x7f1a1b0*/ ProductDefinition(string id, string storeSpecificId, UnityEngine.Purchasing.ProductType type);
            /*0x7f1ae40*/ ProductDefinition(string id, string storeSpecificId, UnityEngine.Purchasing.ProductType type, bool enabled);
            /*0x7f1ae4c*/ ProductDefinition(string id, string storeSpecificId, UnityEngine.Purchasing.ProductType type, bool enabled, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.PayoutDefinition> payouts);
            /*0x7f1af30*/ ProductDefinition(string id, UnityEngine.Purchasing.ProductType type);
            /*0x7f1af44*/ string get_id();
            /*0x7f1af4c*/ void set_id(string value);
            /*0x7f1af54*/ string get_storeSpecificId();
            /*0x7f1af5c*/ void set_storeSpecificId(string value);
            /*0x7f1af64*/ UnityEngine.Purchasing.ProductType get_type();
            /*0x7f1af6c*/ void set_type(UnityEngine.Purchasing.ProductType value);
            /*0x7f1af74*/ bool get_enabled();
            /*0x7f1af7c*/ void set_enabled(bool value);
            /*0x7f1af88*/ bool Equals(object obj);
            /*0x7f1b024*/ int GetHashCode();
            /*0x7f1b044*/ System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.PayoutDefinition> get_payouts();
            /*0x7f1a1bc*/ void SetPayouts(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.PayoutDefinition> newPayouts);
        }

        class ProductMetadata
        {
            /*0x10*/ string <localizedPriceString>k__BackingField;
            /*0x18*/ string <localizedTitle>k__BackingField;
            /*0x20*/ string <localizedDescription>k__BackingField;
            /*0x28*/ string <isoCurrencyCode>k__BackingField;
            /*0x30*/ decimal <localizedPrice>k__BackingField;

            /*0x7f1b04c*/ ProductMetadata(string priceString, string title, string description, string currencyCode, decimal localizedPrice);
            /*0x7f1b0d8*/ ProductMetadata(UnityEngine.Purchasing.ProductMetadata productMetadata);
            /*0x7f1b14c*/ ProductMetadata();
            /*0x7f1b154*/ string get_localizedPriceString();
            /*0x7f1b15c*/ void set_localizedPriceString(string value);
            /*0x7f1b164*/ string get_localizedTitle();
            /*0x7f1b16c*/ void set_localizedTitle(string value);
            /*0x7f1b174*/ string get_localizedDescription();
            /*0x7f1b17c*/ void set_localizedDescription(string value);
            /*0x7f1b184*/ string get_isoCurrencyCode();
            /*0x7f1b18c*/ void set_isoCurrencyCode(string value);
            /*0x7f1b194*/ decimal get_localizedPrice();
            /*0x7f1b1a0*/ void set_localizedPrice(decimal value);
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

            /*0x7f1b1a8*/ PurchaseEventArgs(UnityEngine.Purchasing.Product purchasedProduct);
            /*0x7f1b1d8*/ UnityEngine.Purchasing.Product get_purchasedProduct();
            /*0x7f1b1e0*/ void set_purchasedProduct(UnityEngine.Purchasing.Product value);
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

            /*0x7f19eb4*/ PurchasingFactory(UnityEngine.Purchasing.Extension.IPurchasingModule first, UnityEngine.Purchasing.Extension.IPurchasingModule[] remainingModules);
            /*0x7f1b1e8*/ string get_storeName();
            /*0x7f1b1f0*/ void set_storeName(string value);
            /*0x7f1b1f8*/ UnityEngine.Purchasing.Extension.IStore get_service();
            /*0x7f1b254*/ void set_service(UnityEngine.Purchasing.Extension.IStore value);
            /*0x7f1b25c*/ void RegisterStore(string name, UnityEngine.Purchasing.Extension.IStore s);
            /*0x3907c14*/ void RegisterExtension<T>(T instance);
            /*0x3907c14*/ void RegisterConfiguration<T>(T instance);
            /*0x3907c14*/ T GetConfig<T>();
            /*0x3907c14*/ T GetExtension<T>();
            /*0x7f1b2ac*/ UnityEngine.Purchasing.Extension.ICatalogProvider GetCatalogProvider();
        }

        class PurchasingManager : UnityEngine.Purchasing.Extension.IStoreCallback, UnityEngine.Purchasing.IStoreController
        {
            /*0x10*/ UnityEngine.Purchasing.Extension.IStore m_Store;
            /*0x18*/ UnityEngine.Purchasing.IInternalStoreListener m_Listener;
            /*0x20*/ UnityEngine.ILogger m_Logger;
            /*0x28*/ UnityEngine.Purchasing.TransactionLog m_TransactionLog;
            /*0x30*/ string m_StoreName;
            /*0x38*/ bool m_logUnavailableProducts;
            /*0x40*/ UnityEngine.Purchasing.IUnityServicesInitializationChecker m_UnityServicesInitializationChecker;
            /*0x48*/ System.Action m_AdditionalProductsCallback;
            /*0x50*/ System.Action<UnityEngine.Purchasing.InitializationFailureReason> m_AdditionalProductsFailCallback;
            /*0x58*/ System.Action<UnityEngine.Purchasing.InitializationFailureReason, string> m_AdditionalProductsDetailedFailCallback;
            /*0x60*/ System.Collections.Generic.HashSet<string> purchasesProcessedInSession;
            /*0x68*/ bool <useTransactionLog>k__BackingField;
            /*0x70*/ UnityEngine.Purchasing.ProductCollection <products>k__BackingField;
            /*0x78*/ bool initialized;

            static /*0x7f1c138*/ void OnEntitlementRevoked(UnityEngine.Purchasing.Product revokedProduct);
            static /*0x7f1c108*/ void ClearProductReceipt(UnityEngine.Purchasing.Product product);
            /*0x7f1b2c8*/ PurchasingManager(UnityEngine.Purchasing.TransactionLog tDb, UnityEngine.ILogger logger, UnityEngine.Purchasing.Extension.IStore store, string storeName, UnityEngine.Purchasing.IUnityServicesInitializationChecker unityServicesInitializationChecker, bool logUnavailableProducts);
            /*0x7f1b2b4*/ bool get_useTransactionLog();
            /*0x7f1b2bc*/ void set_useTransactionLog(bool value);
            /*0x7f1b3e0*/ void InitiatePurchase(UnityEngine.Purchasing.Product product);
            /*0x7f1b3f8*/ void InitiatePurchase(UnityEngine.Purchasing.Product product, string developerPayload);
            /*0x7f1b698*/ void InitiatePurchase(string purchasableId, string developerPayload);
            /*0x7f1b808*/ void ConfirmPendingPurchase(UnityEngine.Purchasing.Product product);
            /*0x7f1bbd4*/ UnityEngine.Purchasing.ProductCollection get_products();
            /*0x7f1bbdc*/ void set_products(UnityEngine.Purchasing.ProductCollection value);
            /*0x7f1bbe4*/ void OnPurchaseSucceeded(string id, string receipt, string transactionId);
            /*0x7f1bcf4*/ void UpdateProductReceiptAndTransactionID(UnityEngine.Purchasing.Product product, string receipt, string transactionId);
            /*0x7f1bf38*/ void OnAllPurchasesRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchasedProducts);
            /*0x7f1c0a8*/ void HandlePurchaseRetrieved(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Product purchasedProduct);
            /*0x7f1c13c*/ bool WasPurchaseAlreadyProcessed(string transactionId);
            /*0x7f1c194*/ void OnSetupFailed(UnityEngine.Purchasing.InitializationFailureReason reason, string message);
            /*0x7f1c294*/ void OnPurchaseFailed(UnityEngine.Purchasing.Extension.PurchaseFailureDescription description);
            /*0x7f1c6ec*/ void OnProductsRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products);
            /*0x7f1bf24*/ string CreateUnifiedReceipt(string rawReceipt, string transactionId);
            /*0x7f1cbd8*/ void ProcessPurchaseOnStart();
            /*0x7f1bd48*/ void ProcessPurchaseIfNew(UnityEngine.Purchasing.Product product);
            /*0x7f1cdf4*/ bool HasRecordedTransaction(string transactionId);
            /*0x7f1ca34*/ void CheckForInitialization(int productCount);
            /*0x7f1ce7c*/ bool HasAvailableProductsToPurchase();
            /*0x7f1d190*/ void Initialize(UnityEngine.Purchasing.IInternalStoreListener listener, System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> products);

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.PurchasingManager.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.Purchasing.ProductDefinition, UnityEngine.Purchasing.Product> <>9__45_0;

                static /*0x7f1d470*/ <>c();
                /*0x7f1d4d8*/ <>c();
                /*0x7f1d4e0*/ UnityEngine.Purchasing.Product <Initialize>b__45_0(UnityEngine.Purchasing.ProductDefinition x);
            }

            class <>c__DisplayClass27_0
            {
                /*0x10*/ UnityEngine.Purchasing.Product product;

                /*0x7f1c0a0*/ <>c__DisplayClass27_0();
                /*0x7f1d570*/ bool <OnAllPurchasesRetrieved>b__0(UnityEngine.Purchasing.Product firstPurchasedProduct);
            }
        }

        class StoreListenerProxy : UnityEngine.Purchasing.IInternalStoreListener
        {
            /*0x10*/ UnityEngine.Purchasing.IAnalyticsClient m_Analytics;
            /*0x18*/ UnityEngine.Purchasing.IStoreListener m_ForwardTo;
            /*0x20*/ UnityEngine.Purchasing.IExtensionProvider m_Extensions;

            /*0x7f1d5a8*/ StoreListenerProxy(UnityEngine.Purchasing.IStoreListener forwardTo, UnityEngine.Purchasing.IAnalyticsClient analytics, UnityEngine.Purchasing.IExtensionProvider extensions);
            /*0x7f1d608*/ void OnInitialized(UnityEngine.Purchasing.IStoreController controller);
            /*0x7f1d6bc*/ void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error, string message);
            /*0x7f1d774*/ UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e);
            /*0x7f1d820*/ void OnPurchaseFailed(UnityEngine.Purchasing.Product i, UnityEngine.Purchasing.Extension.PurchaseFailureDescription p);
            /*0x7f1d9f8*/ void SendTransactionEvent(UnityEngine.Purchasing.Product product);
        }

        class TransactionLog
        {
            /*0x10*/ UnityEngine.ILogger logger;
            /*0x18*/ string persistentDataPath;

            static /*0x7f1dc08*/ string ComputeHash(string transactionID);
            /*0x7f1daa0*/ TransactionLog(UnityEngine.ILogger logger, string persistentDataPath);
            /*0x7f1ce20*/ bool HasRecordOf(string transactionID);
            /*0x7f1ba94*/ void Record(string transactionID);
            /*0x7f1db8c*/ string GetRecordPath(string transactionID);
        }

        class UnifiedReceipt
        {
            /*0x10*/ string Payload;
            /*0x18*/ string Store;
            /*0x20*/ string TransactionID;

            /*0x7f1dd80*/ UnifiedReceipt();
        }

        class UnityPurchasing
        {
            static /*0x7f1dd88*/ void Initialize(UnityEngine.Purchasing.IDetailedStoreListener listener, UnityEngine.Purchasing.ConfigurationBuilder builder);
            static /*0x7f1dfc4*/ UnityEngine.Purchasing.IAnalyticsAdapter GenerateUnityAnalytics(UnityEngine.ILogger logger);
            static /*0x7f1df38*/ UnityEngine.Purchasing.IAnalyticsAdapter GenerateLegacyUnityAnalytics();
            static /*0x7f1e018*/ void Initialize(UnityEngine.Purchasing.IStoreListener listener, UnityEngine.Purchasing.ConfigurationBuilder builder, UnityEngine.ILogger logger, string persistentDatapath, UnityEngine.Purchasing.IAnalyticsAdapter ugsAnalytics, UnityEngine.Purchasing.IAnalyticsAdapter legacyAnalytics, UnityEngine.Purchasing.Extension.ICatalogProvider catalog, UnityEngine.Purchasing.IUnityServicesInitializationChecker unityServicesInitializationChecker);
            static /*0x7f1e2a0*/ void FetchAndMergeProducts(bool useCatalog, System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> localProductSet, UnityEngine.Purchasing.Extension.ICatalogProvider catalog, System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>> callback);

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.Purchasing.PurchasingManager manager;
                /*0x18*/ UnityEngine.Purchasing.StoreListenerProxy proxy;

                /*0x7f1e298*/ <>c__DisplayClass5_0();
                /*0x7f1e41c*/ void <Initialize>b__0(System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> response);
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> localProductSet;
                /*0x18*/ System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>> callback;

                /*0x7f1e414*/ <>c__DisplayClass6_0();
                /*0x7f1e440*/ void <FetchAndMergeProducts>b__0(System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> cloudProducts);
            }
        }

        class LoggerExtensions
        {
            static /*0x7f1a674*/ void LogIAPWarning(UnityEngine.ILogger logger, string message);
            static /*0x7f1b9d0*/ void LogIAPError(UnityEngine.ILogger logger, string message);
        }

        class ProductPurchaseUpdater
        {
            static /*0x7f1e644*/ void UpdateProductReceiptAndTransactionID(UnityEngine.Purchasing.Product product, string receipt, string transactionId, string storeName);
        }

        class UnifiedReceiptFormatter
        {
            static /*0x7f1cd50*/ string FormatUnifiedReceipt(string platformReceipt, string transactionId, string storeName);
        }

        namespace Telemetry
        {
            interface ITelemetryDiagnostics
            {
                /*0x380d93c*/ void SendDiagnostic(string diagnosticName, System.Exception e);
            }

            interface ITelemetryDiagnosticsInstanceWrapper
            {
                /*0x380d83c*/ void SetDiagnosticsInstance(Unity.Services.Core.Telemetry.Internal.IDiagnostics diagnosticsInstance);
                /*0x380d93c*/ void SendDiagnostic(string diagnosticName, string diagnosticException);
            }

            struct TelemetryDiagnosticParams
            {
                /*0x10*/ string name;
                /*0x18*/ string exception;

                /*0x7f1e694*/ TelemetryDiagnosticParams(string diagnosticName, string diagnosticException);
            }

            class TelemetryDiagnostics : UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics
            {
                /*0x10*/ UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper m_TelemetryDiagnosticsInstanceWrapper;

                /*0x7f1e6c4*/ TelemetryDiagnostics(UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper telemetryDiagnosticsInstanceWrapper);
                /*0x7f1e6f4*/ void SendDiagnostic(string diagnosticName, System.Exception e);
            }

            class TelemetryDiagnosticsInstanceWrapper : UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper
            {
                /*0x10*/ Unity.Services.Core.Telemetry.Internal.IDiagnostics m_Instance;
                /*0x18*/ UnityEngine.ILogger m_Logger;
                /*0x20*/ Uniject.IUtil m_Util;
                /*0x28*/ UnityEngine.Purchasing.Telemetry.TelemetryQueue<UnityEngine.Purchasing.Telemetry.TelemetryDiagnosticParams> m_Queue;

                /*0x7f1e8e8*/ TelemetryDiagnosticsInstanceWrapper(UnityEngine.ILogger logger, Uniject.IUtil util);
                /*0x7f1e9f0*/ void SetDiagnosticsInstance(Unity.Services.Core.Telemetry.Internal.IDiagnostics diagnosticsInstance);
                /*0x7f1ea54*/ void SendDiagnostic(string diagnosticName, string diagnosticException);
                /*0x7f1eb04*/ void SendDiagnosticOnMainThread(UnityEngine.Purchasing.Telemetry.TelemetryDiagnosticParams diagnosticParams);
                /*0x7f1ec60*/ void SendDiagnosticAndCatchExceptions(UnityEngine.Purchasing.Telemetry.TelemetryDiagnosticParams diagnosticParams);

                class <>c__DisplayClass7_0
                {
                    /*0x10*/ UnityEngine.Purchasing.Telemetry.TelemetryDiagnosticsInstanceWrapper <>4__this;
                    /*0x18*/ UnityEngine.Purchasing.Telemetry.TelemetryDiagnosticParams diagnosticParams;

                    /*0x7f1ec58*/ <>c__DisplayClass7_0();
                    /*0x7f1edfc*/ void <SendDiagnosticOnMainThread>b__0();
                }
            }

            class IapTelemetryException : System.Exception
            {
                /*0x7f1ee1c*/ IapTelemetryException(string message);
            }

            interface ITelemetryMetricEvent
            {
                /*0x380cb08*/ void StartMetric();
                /*0x380cb08*/ void StopAndSendMetric();
            }

            interface ITelemetryMetricsInstanceWrapper
            {
                /*0x380d83c*/ void SetMetricsInstance(Unity.Services.Core.Telemetry.Internal.IMetrics metricsInstance);
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

                static /*0x7f1eebc*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition op_Implicit(string name);
                /*0x7f1ee94*/ TelemetryMetricDefinition(string metricName, UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes metricType);
                /*0x7f1ee84*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes get_MetricType();
                /*0x7f1ee8c*/ string get_MetricName();
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

                static /*0x7f1eef0*/ TelemetryMetricDefinitions();
            }

            class TelemetryMetricEvent : UnityEngine.Purchasing.Telemetry.ITelemetryMetricEvent
            {
                /*0x10*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper m_TelemetryMetricsInstanceWrapper;
                /*0x18*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes m_MetricType;
                /*0x20*/ string m_MetricName;
                /*0x28*/ System.Diagnostics.Stopwatch m_Stopwatch;

                /*0x7f1f39c*/ TelemetryMetricEvent(UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper, UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes metricType, string metricName);
                /*0x7f1f448*/ void StartMetric();
                /*0x7f1f4cc*/ void StopAndSendMetric();
            }

            struct TelemetryMetricParams
            {
                /*0x10*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes type;
                /*0x18*/ string name;
                /*0x20*/ double timeSeconds;

                /*0x7f1f64c*/ TelemetryMetricParams(UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes metricType, string metricName, double metricTimeSeconds);
            }

            class TelemetryMetricsInstanceWrapper : UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper
            {
                /*0x10*/ Unity.Services.Core.Telemetry.Internal.IMetrics m_Instance;
                /*0x18*/ UnityEngine.ILogger m_Logger;
                /*0x20*/ Uniject.IUtil m_Util;
                /*0x28*/ UnityEngine.Purchasing.Telemetry.TelemetryQueue<UnityEngine.Purchasing.Telemetry.TelemetryMetricParams> m_Queue;

                /*0x7f1f67c*/ TelemetryMetricsInstanceWrapper(UnityEngine.ILogger logger, Uniject.IUtil util);
                /*0x7f1f784*/ void SetMetricsInstance(Unity.Services.Core.Telemetry.Internal.IMetrics metricsInstance);
                /*0x7f1f800*/ void SendMetric(UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes metricType, string metricName, double metricTimeSeconds);
                /*0x7f1f8e4*/ void SendMetricOnMainThread(UnityEngine.Purchasing.Telemetry.TelemetryMetricParams metricParams);
                /*0x7f1fa3c*/ void SendMetricByTypeAndCatchExceptions(UnityEngine.Purchasing.Telemetry.TelemetryMetricParams metricParams);
                /*0x7f1fb64*/ void SendMetricByType(UnityEngine.Purchasing.Telemetry.TelemetryMetricParams metricParams);

                class <>c__DisplayClass7_0
                {
                    /*0x10*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper <>4__this;
                    /*0x18*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricParams metricParams;

                    /*0x7f1fa34*/ <>c__DisplayClass7_0();
                    /*0x7f1fd0c*/ void <SendMetricOnMainThread>b__0();
                }
            }

            class TelemetryMetricsService : UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService
            {
                /*0x10*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper m_TelemetryMetricsInstanceWrapper;

                /*0x7f1fd58*/ TelemetryMetricsService(UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper);
                /*0x7f1fd88*/ void ExecuteTimedAction(System.Action timedAction, UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition metricDefinition);
                /*0x7f1ff7c*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricEvent CreateAndStartMetricEvent(UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition metricDefinition);
            }

            enum TelemetryMetricTypes
            {
                Gauge = 0,
                Sum = 1,
                Histogram = 2,
            }

            class TelemetryQueue<TTelemetryEventParams>
            {
                /*0x0*/ System.Action<TTelemetryEventParams> m_SendTelemetryEvent;
                /*0x0*/ System.Collections.Concurrent.ConcurrentQueue<TTelemetryEventParams> m_Queue;

                /*0x380d83c*/ TelemetryQueue(System.Action<TTelemetryEventParams> sendTelemetryEvent);
                /*0x3907c14*/ void QueueEvent(TTelemetryEventParams telemetryEvent);
                /*0x380cb08*/ void SendQueuedEvents();
            }
        }

        namespace Extension
        {
            class AbstractPurchasingModule : UnityEngine.Purchasing.Extension.IPurchasingModule
            {
                /*0x10*/ UnityEngine.Purchasing.Extension.IPurchasingBinder m_Binder;

                /*0x7f2024c*/ AbstractPurchasingModule();
                /*0x7f20170*/ void Configure(UnityEngine.Purchasing.Extension.IPurchasingBinder binder);
                /*0x7f20194*/ void RegisterStore(string name, UnityEngine.Purchasing.Extension.IStore store);
                /*0x3907c14*/ void BindExtension<T>(T instance);
                /*0x3907c14*/ void BindConfiguration<T>(T instance);
                /*0x380cb08*/ void Configure();
            }

            class AbstractStore : UnityEngine.Purchasing.Extension.IStore
            {
                /*0x7f20254*/ AbstractStore();
                /*0x380d83c*/ void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback callback);
                /*0x380d83c*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
                /*0x380d93c*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);
                /*0x380d93c*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId);
            }

            interface ICatalogProvider
            {
                /*0x380d83c*/ void FetchProducts(System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>> callback);
            }

            interface IPurchasingBinder
            {
                /*0x380d93c*/ void RegisterStore(string name, UnityEngine.Purchasing.Extension.IStore store);
                /*0x3907c14*/ void RegisterExtension<T>(T instance);
                /*0x3907c14*/ void RegisterConfiguration<T>(T instance);
            }

            interface IPurchasingModule
            {
                /*0x380d83c*/ void Configure(UnityEngine.Purchasing.Extension.IPurchasingBinder binder);
            }

            interface IStore
            {
                /*0x380d83c*/ void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback callback);
                /*0x380d83c*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
                /*0x380d93c*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);
                /*0x380d93c*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId);
            }

            interface IStoreCallback
            {
                /*0x380b9e8*/ UnityEngine.Purchasing.ProductCollection get_products();
                /*0x380d170*/ void OnSetupFailed(UnityEngine.Purchasing.InitializationFailureReason reason, string message);
                /*0x380d83c*/ void OnProductsRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products);
                /*0x380da4c*/ void OnPurchaseSucceeded(string storeSpecificId, string receipt, string transactionIdentifier);
                /*0x380d83c*/ void OnAllPurchasesRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchasedProducts);
                /*0x380d83c*/ void OnPurchaseFailed(UnityEngine.Purchasing.Extension.PurchaseFailureDescription desc);
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

                /*0x7f2025c*/ ProductDescription(string id, UnityEngine.Purchasing.ProductMetadata metadata, string receipt, string transactionId);
                /*0x7f202d0*/ ProductDescription(string id, UnityEngine.Purchasing.ProductMetadata metadata, string receipt, string transactionId, UnityEngine.Purchasing.ProductType type);
                /*0x7f202f4*/ ProductDescription(string id, UnityEngine.Purchasing.ProductMetadata metadata);
                /*0x7f20300*/ string get_storeSpecificId();
                /*0x7f20308*/ void set_storeSpecificId(string value);
                /*0x7f20310*/ UnityEngine.Purchasing.ProductMetadata get_metadata();
                /*0x7f20318*/ void set_metadata(UnityEngine.Purchasing.ProductMetadata value);
                /*0x7f20320*/ string get_receipt();
                /*0x7f20328*/ void set_receipt(string value);
                /*0x7f20330*/ string get_transactionId();
                /*0x7f20338*/ void set_transactionId(string value);
            }

            class PurchaseFailureDescription
            {
                /*0x10*/ string <productId>k__BackingField;
                /*0x18*/ UnityEngine.Purchasing.PurchaseFailureReason <reason>k__BackingField;
                /*0x20*/ string <message>k__BackingField;

                /*0x7f1b644*/ PurchaseFailureDescription(string productId, UnityEngine.Purchasing.PurchaseFailureReason reason, string message);
                /*0x7f20340*/ string get_productId();
                /*0x7f20348*/ void set_productId(string value);
                /*0x7f20350*/ UnityEngine.Purchasing.PurchaseFailureReason get_reason();
                /*0x7f20358*/ void set_reason(UnityEngine.Purchasing.PurchaseFailureReason value);
                /*0x7f20360*/ string get_message();
                /*0x7f20368*/ void set_message(string value);
            }
        }
    }
}
