class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x7f3042c*/ EmbeddedAttribute();
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

                /*0x7f30434*/ NullableAttribute(byte );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x7f304bc*/ NullableContextAttribute(byte );
            }
        }
    }
}

namespace Uniject
{
    interface IUtil
    {
        /*0x3814a3c*/ object InitiateCoroutine(System.Collections.IEnumerator start);
        /*0x381678c*/ void InitiateCoroutine(System.Collections.IEnumerator start, int delayInSeconds);
        /*0x3816710*/ void RunOnMainThread(System.Action runnable);
        /*0x3816710*/ void AddPauseListener(System.Action<bool> runnable);
        /*0x3814200*/ bool IsClassOrSubclass(System.Type potentialBase, System.Type potentialDescendant);
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

            /*0x7f304e4*/ AnalyticsClient(UnityEngine.Purchasing.IAnalyticsAdapter analytics, UnityEngine.Purchasing.IAnalyticsAdapter legacyAnalytics);
            /*0x7f30528*/ void OnPurchaseSucceeded(UnityEngine.Purchasing.Product product);
            /*0x7f30660*/ void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Extension.PurchaseFailureDescription description);
        }

        class EmptyAnalyticsAdapter : UnityEngine.Purchasing.IAnalyticsAdapter
        {
            /*0x7f30790*/ EmptyAnalyticsAdapter();
            /*0x7f30788*/ void SendTransactionEvent(UnityEngine.Purchasing.Product product);
            /*0x7f3078c*/ void SendTransactionFailedEvent(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Extension.PurchaseFailureDescription reason);
        }

        interface IAnalyticsAdapter
        {
            /*0x3816710*/ void SendTransactionEvent(UnityEngine.Purchasing.Product product);
            /*0x3816810*/ void SendTransactionFailedEvent(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Extension.PurchaseFailureDescription description);
        }

        interface IAnalyticsClient
        {
            /*0x3816710*/ void OnPurchaseSucceeded(UnityEngine.Purchasing.Product product);
            /*0x3816810*/ void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Extension.PurchaseFailureDescription purchaseFailureDescription);
        }

        interface ILegacyUnityAnalytics
        {
            void SendTransactionEvent(string productId, decimal amount, string currency, string receiptPurchaseData, string signature);
            /*0x3816810*/ void SendCustomEvent(string name, System.Collections.Generic.Dictionary<string, object> data);
        }

        class LegacyAnalyticsAdapter : UnityEngine.Purchasing.IAnalyticsAdapter
        {
            /*0x10*/ UnityEngine.Purchasing.ILegacyUnityAnalytics m_LegacyAnalytics;

            /*0x7f30798*/ LegacyAnalyticsAdapter(UnityEngine.Purchasing.ILegacyUnityAnalytics legacyAnalytics);
            /*0x7f307c8*/ void SendTransactionEvent(UnityEngine.Purchasing.Product product);
            /*0x7f308b8*/ void SendTransactionFailedEvent(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Extension.PurchaseFailureDescription description);
        }

        class LegacyAnalyticsWrapper : UnityEngine.Purchasing.IAnalyticsAdapter, UnityEngine.Purchasing.ICoreServicesEnvironmentObserver
        {
            /*0x10*/ bool m_Enabled;
            /*0x18*/ UnityEngine.Purchasing.IAnalyticsAdapter m_LegacyAdapter;
            /*0x20*/ UnityEngine.Purchasing.IAnalyticsAdapter m_EmptyAdapter;

            /*0x7f30b24*/ LegacyAnalyticsWrapper(UnityEngine.Purchasing.IAnalyticsAdapter legacyAdapter, UnityEngine.Purchasing.IAnalyticsAdapter emptyAdapter);
            /*0x7f30d60*/ void SendTransactionEvent(UnityEngine.Purchasing.Product product);
            /*0x7f30e38*/ void SendTransactionFailedEvent(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Extension.PurchaseFailureDescription description);
            /*0x7f30f08*/ void OnUpdatedCoreServicesEnvironment(string currentEnvironment);
            /*0x7f30e1c*/ UnityEngine.Purchasing.IAnalyticsAdapter get_m_AnalyticsAdapter();
        }

        class LegacyUnityAnalytics : UnityEngine.Purchasing.ILegacyUnityAnalytics
        {
            /*0x7f30fbc*/ LegacyUnityAnalytics();
            /*0x7f30f8c*/ void SendTransactionEvent(string productId, decimal amount, string currency, string receiptPurchaseData, string signature);
            /*0x7f30fac*/ void SendCustomEvent(string name, System.Collections.Generic.Dictionary<string, object> data);
        }

        class IDs : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>, System.Collections.IEnumerable
        {
            /*0x10*/ System.Collections.Generic.Dictionary<string, string> m_Dic;

            /*0x7f30fc4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x7f31058*/ string SpecificIDForStore(string store, string defaultValue);
            /*0x7f310fc*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>> GetEnumerator();
        }

        class ConfigurationBuilder
        {
            /*0x10*/ bool <useCatalogProvider>k__BackingField;
            /*0x11*/ bool <logUnavailableProducts>k__BackingField;
            /*0x18*/ System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> <products>k__BackingField;
            /*0x20*/ UnityEngine.Purchasing.PurchasingFactory <factory>k__BackingField;

            static /*0x7f31254*/ UnityEngine.Purchasing.ConfigurationBuilder Instance(UnityEngine.Purchasing.Extension.IPurchasingModule first, UnityEngine.Purchasing.Extension.IPurchasingModule[] rest);
            /*0x7f31190*/ ConfigurationBuilder(UnityEngine.Purchasing.PurchasingFactory factory);
            /*0x7f31234*/ bool get_useCatalogProvider();
            /*0x7f3123c*/ bool get_logUnavailableProducts();
            /*0x7f31244*/ System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> get_products();
            /*0x7f3124c*/ UnityEngine.Purchasing.PurchasingFactory get_factory();
            /*0x3910ae8*/ T Configure<T>();
            /*0x7f314e4*/ UnityEngine.Purchasing.ConfigurationBuilder AddProduct(string id, UnityEngine.Purchasing.ProductType type);
            /*0x7f314f0*/ UnityEngine.Purchasing.ConfigurationBuilder AddProduct(string id, UnityEngine.Purchasing.ProductType type, UnityEngine.Purchasing.IDs storeIDs);
            /*0x7f314f8*/ UnityEngine.Purchasing.ConfigurationBuilder AddProduct(string id, UnityEngine.Purchasing.ProductType type, UnityEngine.Purchasing.IDs storeIDs, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.PayoutDefinition> payouts);
        }

        class CoreServicesEnvironmentSubject
        {
            static /*0x0*/ UnityEngine.Purchasing.CoreServicesEnvironmentSubject s_Instance;
            /*0x10*/ string m_LastKnownEnvironment;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Purchasing.ICoreServicesEnvironmentObserver> m_Observers;

            static /*0x7f30b84*/ UnityEngine.Purchasing.CoreServicesEnvironmentSubject Instance();
            /*0x7f3168c*/ CoreServicesEnvironmentSubject();
            /*0x7f30c08*/ void SubscribeToUpdatesAndGetCurrent(UnityEngine.Purchasing.ICoreServicesEnvironmentObserver newObserver);
            /*0x7f31714*/ void UpdateCurrentEnvironment(string currentEnvironment);
            /*0x7f31730*/ void NotifyObservers();
            /*0x7f30f40*/ bool IsDefaultLiveEnvironment(string environment);
        }

        interface ICoreServicesEnvironmentObserver
        {
            /*0x3816710*/ void OnUpdatedCoreServicesEnvironment(string currentEnvironment);
        }

        interface IUnityServicesInitializationChecker
        {
            /*0x38159dc*/ void CheckAndLogWarning();
        }

        class UnityServicesInitializationChecker : UnityEngine.Purchasing.IUnityServicesInitializationChecker
        {
            /*0x10*/ UnityEngine.ILogger m_Logger;

            /*0x7f318e8*/ UnityServicesInitializationChecker(UnityEngine.ILogger logger);
            /*0x7f31918*/ void CheckAndLogWarning();
            /*0x7f3193c*/ bool IsUninitialized();
            /*0x7f31a5c*/ void LogWarning();
        }

        interface IStoreExtension
        {
        }

        interface IDetailedStoreListener : UnityEngine.Purchasing.IStoreListener
        {
            /*0x3816810*/ void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Extension.PurchaseFailureDescription failureDescription);
        }

        interface IExtensionProvider
        {
            /*0x3910ae8*/ T GetExtension<T>();
        }

        interface IInternalStoreListener
        {
            /*0x3816044*/ void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error, string message);
            /*0x381467c*/ UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e);
            /*0x3816810*/ void OnPurchaseFailed(UnityEngine.Purchasing.Product i, UnityEngine.Purchasing.Extension.PurchaseFailureDescription p);
            /*0x3816710*/ void OnInitialized(UnityEngine.Purchasing.IStoreController controller);
            /*0x3816710*/ void SendTransactionEvent(UnityEngine.Purchasing.Product product);
        }

        enum InitializationFailureReason
        {
            PurchasingUnavailable = 0,
            NoProductsAvailable = 1,
            AppNotKnown = 2,
        }

        interface IStoreController
        {
            /*0x38148bc*/ UnityEngine.Purchasing.ProductCollection get_products();
            /*0x3816810*/ void InitiatePurchase(string productId, string payload);
            /*0x3816710*/ void InitiatePurchase(UnityEngine.Purchasing.Product product);
            /*0x3816710*/ void ConfirmPendingPurchase(UnityEngine.Purchasing.Product product);
        }

        interface IStoreListener
        {
            /*0x3816044*/ void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error, string message);
            /*0x381467c*/ UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs purchaseEvent);
            /*0x381678c*/ void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason failureReason);
            /*0x3816810*/ void OnInitialized(UnityEngine.Purchasing.IStoreController controller, UnityEngine.Purchasing.IExtensionProvider extensions);
        }

        class PayoutDefinition
        {
            static int MaxSubtypeLength = 64;
            static int MaxDataLength = 1024;
            /*0x10*/ UnityEngine.Purchasing.PayoutType m_Type;
            /*0x18*/ string m_Subtype;
            /*0x20*/ double m_Quantity;
            /*0x28*/ string m_Data;

            /*0x7f31b68*/ PayoutDefinition();
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

            /*0x7f31bbc*/ Product(UnityEngine.Purchasing.ProductDefinition definition, UnityEngine.Purchasing.ProductMetadata metadata, string receipt);
            /*0x7f31c1c*/ Product(UnityEngine.Purchasing.ProductDefinition definition, UnityEngine.Purchasing.ProductMetadata metadata);
            /*0x7f31c24*/ UnityEngine.Purchasing.ProductDefinition get_definition();
            /*0x7f31c2c*/ void set_definition(UnityEngine.Purchasing.ProductDefinition value);
            /*0x7f31c34*/ UnityEngine.Purchasing.ProductMetadata get_metadata();
            /*0x7f31c3c*/ void set_metadata(UnityEngine.Purchasing.ProductMetadata value);
            /*0x7f31c44*/ bool get_availableToPurchase();
            /*0x7f31c4c*/ void set_availableToPurchase(bool value);
            /*0x7f31c58*/ string get_transactionID();
            /*0x7f31c60*/ void set_transactionID(string value);
            /*0x7f31c68*/ void set_appleOriginalTransactionID(string value);
            /*0x7f31c70*/ bool get_appleProductIsRestored();
            /*0x7f31c78*/ void set_appleProductIsRestored(bool value);
            /*0x7f31c84*/ bool get_hasReceipt();
            /*0x7f31ca4*/ string get_receipt();
            /*0x7f31cac*/ void set_receipt(string value);
            /*0x7f31cb4*/ bool Equals(object obj);
            /*0x7f31d58*/ int GetHashCode();
        }

        class ProductCollection
        {
            /*0x10*/ System.Collections.Generic.Dictionary<string, UnityEngine.Purchasing.Product> m_IdToProduct;
            /*0x18*/ System.Collections.Generic.Dictionary<string, UnityEngine.Purchasing.Product> m_StoreSpecificIdToProduct;
            /*0x20*/ System.Collections.Generic.HashSet<UnityEngine.Purchasing.Product> <set>k__BackingField;
            /*0x28*/ UnityEngine.Purchasing.Product[] <all>k__BackingField;

            /*0x7f31d78*/ ProductCollection(UnityEngine.Purchasing.Product[] products);
            /*0x7f31e10*/ void AddProducts(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Product> products);
            /*0x7f32034*/ System.Collections.Generic.HashSet<UnityEngine.Purchasing.Product> get_set();
            /*0x7f3203c*/ UnityEngine.Purchasing.Product[] get_all();
            /*0x7f32044*/ void set_all(UnityEngine.Purchasing.Product[] value);
            /*0x7f3204c*/ UnityEngine.Purchasing.Product WithID(string id);
            /*0x7f320bc*/ UnityEngine.Purchasing.Product WithStoreSpecificID(string id);

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.ProductCollection.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.Purchasing.Product, string> <>9__3_0;
                static /*0x10*/ System.Func<UnityEngine.Purchasing.Product, string> <>9__3_1;

                static /*0x7f32138*/ <>c();
                /*0x7f321a0*/ <>c();
                /*0x7f321a8*/ string <AddProducts>b__3_0(UnityEngine.Purchasing.Product x);
                /*0x7f321c8*/ string <AddProducts>b__3_1(UnityEngine.Purchasing.Product x);
            }
        }

        class ProductDefinition
        {
            /*0x10*/ string <id>k__BackingField;
            /*0x18*/ string <storeSpecificId>k__BackingField;
            /*0x20*/ UnityEngine.Purchasing.ProductType <type>k__BackingField;
            /*0x24*/ bool <enabled>k__BackingField;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.Purchasing.PayoutDefinition> m_Payouts;

            /*0x7f321e8*/ ProductDefinition();
            /*0x7f315e0*/ ProductDefinition(string id, string storeSpecificId, UnityEngine.Purchasing.ProductType type);
            /*0x7f32270*/ ProductDefinition(string id, string storeSpecificId, UnityEngine.Purchasing.ProductType type, bool enabled);
            /*0x7f3227c*/ ProductDefinition(string id, string storeSpecificId, UnityEngine.Purchasing.ProductType type, bool enabled, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.PayoutDefinition> payouts);
            /*0x7f32360*/ ProductDefinition(string id, UnityEngine.Purchasing.ProductType type);
            /*0x7f32374*/ string get_id();
            /*0x7f3237c*/ void set_id(string value);
            /*0x7f32384*/ string get_storeSpecificId();
            /*0x7f3238c*/ void set_storeSpecificId(string value);
            /*0x7f32394*/ UnityEngine.Purchasing.ProductType get_type();
            /*0x7f3239c*/ void set_type(UnityEngine.Purchasing.ProductType value);
            /*0x7f323a4*/ bool get_enabled();
            /*0x7f323ac*/ void set_enabled(bool value);
            /*0x7f323b8*/ bool Equals(object obj);
            /*0x7f32454*/ int GetHashCode();
            /*0x7f32474*/ System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.PayoutDefinition> get_payouts();
            /*0x7f315ec*/ void SetPayouts(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.PayoutDefinition> newPayouts);
        }

        class ProductMetadata
        {
            /*0x10*/ string <localizedPriceString>k__BackingField;
            /*0x18*/ string <localizedTitle>k__BackingField;
            /*0x20*/ string <localizedDescription>k__BackingField;
            /*0x28*/ string <isoCurrencyCode>k__BackingField;
            /*0x30*/ decimal <localizedPrice>k__BackingField;

            /*0x7f3247c*/ ProductMetadata(string priceString, string title, string description, string currencyCode, decimal localizedPrice);
            /*0x7f32508*/ ProductMetadata(UnityEngine.Purchasing.ProductMetadata productMetadata);
            /*0x7f3257c*/ ProductMetadata();
            /*0x7f32584*/ string get_localizedPriceString();
            /*0x7f3258c*/ void set_localizedPriceString(string value);
            /*0x7f32594*/ string get_localizedTitle();
            /*0x7f3259c*/ void set_localizedTitle(string value);
            /*0x7f325a4*/ string get_localizedDescription();
            /*0x7f325ac*/ void set_localizedDescription(string value);
            /*0x7f325b4*/ string get_isoCurrencyCode();
            /*0x7f325bc*/ void set_isoCurrencyCode(string value);
            /*0x7f325c4*/ decimal get_localizedPrice();
            /*0x7f325d0*/ void set_localizedPrice(decimal value);
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

            /*0x7f325d8*/ PurchaseEventArgs(UnityEngine.Purchasing.Product purchasedProduct);
            /*0x7f32608*/ UnityEngine.Purchasing.Product get_purchasedProduct();
            /*0x7f32610*/ void set_purchasedProduct(UnityEngine.Purchasing.Product value);
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

            /*0x7f312e4*/ PurchasingFactory(UnityEngine.Purchasing.Extension.IPurchasingModule first, UnityEngine.Purchasing.Extension.IPurchasingModule[] remainingModules);
            /*0x7f32618*/ string get_storeName();
            /*0x7f32620*/ void set_storeName(string value);
            /*0x7f32628*/ UnityEngine.Purchasing.Extension.IStore get_service();
            /*0x7f32684*/ void set_service(UnityEngine.Purchasing.Extension.IStore value);
            /*0x7f3268c*/ void RegisterStore(string name, UnityEngine.Purchasing.Extension.IStore s);
            /*0x3910ae8*/ void RegisterExtension<T>(T instance);
            /*0x3910ae8*/ void RegisterConfiguration<T>(T instance);
            /*0x3910ae8*/ T GetConfig<T>();
            /*0x3910ae8*/ T GetExtension<T>();
            /*0x7f326dc*/ UnityEngine.Purchasing.Extension.ICatalogProvider GetCatalogProvider();
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

            static /*0x7f33568*/ void OnEntitlementRevoked(UnityEngine.Purchasing.Product revokedProduct);
            static /*0x7f33538*/ void ClearProductReceipt(UnityEngine.Purchasing.Product product);
            /*0x7f326f8*/ PurchasingManager(UnityEngine.Purchasing.TransactionLog tDb, UnityEngine.ILogger logger, UnityEngine.Purchasing.Extension.IStore store, string storeName, UnityEngine.Purchasing.IUnityServicesInitializationChecker unityServicesInitializationChecker, bool logUnavailableProducts);
            /*0x7f326e4*/ bool get_useTransactionLog();
            /*0x7f326ec*/ void set_useTransactionLog(bool value);
            /*0x7f32810*/ void InitiatePurchase(UnityEngine.Purchasing.Product product);
            /*0x7f32828*/ void InitiatePurchase(UnityEngine.Purchasing.Product product, string developerPayload);
            /*0x7f32ac8*/ void InitiatePurchase(string purchasableId, string developerPayload);
            /*0x7f32c38*/ void ConfirmPendingPurchase(UnityEngine.Purchasing.Product product);
            /*0x7f33004*/ UnityEngine.Purchasing.ProductCollection get_products();
            /*0x7f3300c*/ void set_products(UnityEngine.Purchasing.ProductCollection value);
            /*0x7f33014*/ void OnPurchaseSucceeded(string id, string receipt, string transactionId);
            /*0x7f33124*/ void UpdateProductReceiptAndTransactionID(UnityEngine.Purchasing.Product product, string receipt, string transactionId);
            /*0x7f33368*/ void OnAllPurchasesRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchasedProducts);
            /*0x7f334d8*/ void HandlePurchaseRetrieved(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Product purchasedProduct);
            /*0x7f3356c*/ bool WasPurchaseAlreadyProcessed(string transactionId);
            /*0x7f335c4*/ void OnSetupFailed(UnityEngine.Purchasing.InitializationFailureReason reason, string message);
            /*0x7f336c4*/ void OnPurchaseFailed(UnityEngine.Purchasing.Extension.PurchaseFailureDescription description);
            /*0x7f33b1c*/ void OnProductsRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products);
            /*0x7f33354*/ string CreateUnifiedReceipt(string rawReceipt, string transactionId);
            /*0x7f34008*/ void ProcessPurchaseOnStart();
            /*0x7f33178*/ void ProcessPurchaseIfNew(UnityEngine.Purchasing.Product product);
            /*0x7f34224*/ bool HasRecordedTransaction(string transactionId);
            /*0x7f33e64*/ void CheckForInitialization(int productCount);
            /*0x7f342ac*/ bool HasAvailableProductsToPurchase();
            /*0x7f345c0*/ void Initialize(UnityEngine.Purchasing.IInternalStoreListener listener, System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> products);

            class <>c
            {
                static /*0x0*/ UnityEngine.Purchasing.PurchasingManager.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.Purchasing.ProductDefinition, UnityEngine.Purchasing.Product> <>9__45_0;

                static /*0x7f348a0*/ <>c();
                /*0x7f34908*/ <>c();
                /*0x7f34910*/ UnityEngine.Purchasing.Product <Initialize>b__45_0(UnityEngine.Purchasing.ProductDefinition x);
            }

            class <>c__DisplayClass27_0
            {
                /*0x10*/ UnityEngine.Purchasing.Product product;

                /*0x7f334d0*/ <>c__DisplayClass27_0();
                /*0x7f349a0*/ bool <OnAllPurchasesRetrieved>b__0(UnityEngine.Purchasing.Product firstPurchasedProduct);
            }
        }

        class StoreListenerProxy : UnityEngine.Purchasing.IInternalStoreListener
        {
            /*0x10*/ UnityEngine.Purchasing.IAnalyticsClient m_Analytics;
            /*0x18*/ UnityEngine.Purchasing.IStoreListener m_ForwardTo;
            /*0x20*/ UnityEngine.Purchasing.IExtensionProvider m_Extensions;

            /*0x7f349d8*/ StoreListenerProxy(UnityEngine.Purchasing.IStoreListener forwardTo, UnityEngine.Purchasing.IAnalyticsClient analytics, UnityEngine.Purchasing.IExtensionProvider extensions);
            /*0x7f34a38*/ void OnInitialized(UnityEngine.Purchasing.IStoreController controller);
            /*0x7f34aec*/ void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error, string message);
            /*0x7f34ba4*/ UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e);
            /*0x7f34c50*/ void OnPurchaseFailed(UnityEngine.Purchasing.Product i, UnityEngine.Purchasing.Extension.PurchaseFailureDescription p);
            /*0x7f34e28*/ void SendTransactionEvent(UnityEngine.Purchasing.Product product);
        }

        class TransactionLog
        {
            /*0x10*/ UnityEngine.ILogger logger;
            /*0x18*/ string persistentDataPath;

            static /*0x7f35038*/ string ComputeHash(string transactionID);
            /*0x7f34ed0*/ TransactionLog(UnityEngine.ILogger logger, string persistentDataPath);
            /*0x7f34250*/ bool HasRecordOf(string transactionID);
            /*0x7f32ec4*/ void Record(string transactionID);
            /*0x7f34fbc*/ string GetRecordPath(string transactionID);
        }

        class UnifiedReceipt
        {
            /*0x10*/ string Payload;
            /*0x18*/ string Store;
            /*0x20*/ string TransactionID;

            /*0x7f351b0*/ UnifiedReceipt();
        }

        class UnityPurchasing
        {
            static /*0x7f351b8*/ void Initialize(UnityEngine.Purchasing.IDetailedStoreListener listener, UnityEngine.Purchasing.ConfigurationBuilder builder);
            static /*0x7f353f4*/ UnityEngine.Purchasing.IAnalyticsAdapter GenerateUnityAnalytics(UnityEngine.ILogger logger);
            static /*0x7f35368*/ UnityEngine.Purchasing.IAnalyticsAdapter GenerateLegacyUnityAnalytics();
            static /*0x7f35448*/ void Initialize(UnityEngine.Purchasing.IStoreListener listener, UnityEngine.Purchasing.ConfigurationBuilder builder, UnityEngine.ILogger logger, string persistentDatapath, UnityEngine.Purchasing.IAnalyticsAdapter ugsAnalytics, UnityEngine.Purchasing.IAnalyticsAdapter legacyAnalytics, UnityEngine.Purchasing.Extension.ICatalogProvider catalog, UnityEngine.Purchasing.IUnityServicesInitializationChecker unityServicesInitializationChecker);
            static /*0x7f356d0*/ void FetchAndMergeProducts(bool useCatalog, System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> localProductSet, UnityEngine.Purchasing.Extension.ICatalogProvider catalog, System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>> callback);

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.Purchasing.PurchasingManager manager;
                /*0x18*/ UnityEngine.Purchasing.StoreListenerProxy proxy;

                /*0x7f356c8*/ <>c__DisplayClass5_0();
                /*0x7f3584c*/ void <Initialize>b__0(System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> response);
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> localProductSet;
                /*0x18*/ System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>> callback;

                /*0x7f35844*/ <>c__DisplayClass6_0();
                /*0x7f35870*/ void <FetchAndMergeProducts>b__0(System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> cloudProducts);
            }
        }

        class LoggerExtensions
        {
            static /*0x7f31aa4*/ void LogIAPWarning(UnityEngine.ILogger logger, string message);
            static /*0x7f32e00*/ void LogIAPError(UnityEngine.ILogger logger, string message);
        }

        class ProductPurchaseUpdater
        {
            static /*0x7f35a74*/ void UpdateProductReceiptAndTransactionID(UnityEngine.Purchasing.Product product, string receipt, string transactionId, string storeName);
        }

        class UnifiedReceiptFormatter
        {
            static /*0x7f34180*/ string FormatUnifiedReceipt(string platformReceipt, string transactionId, string storeName);
        }

        namespace Telemetry
        {
            interface ITelemetryDiagnostics
            {
                /*0x3816810*/ void SendDiagnostic(string diagnosticName, System.Exception e);
            }

            interface ITelemetryDiagnosticsInstanceWrapper
            {
                /*0x3816710*/ void SetDiagnosticsInstance(Unity.Services.Core.Telemetry.Internal.IDiagnostics diagnosticsInstance);
                /*0x3816810*/ void SendDiagnostic(string diagnosticName, string diagnosticException);
            }

            struct TelemetryDiagnosticParams
            {
                /*0x10*/ string name;
                /*0x18*/ string exception;

                /*0x7f35ac4*/ TelemetryDiagnosticParams(string diagnosticName, string diagnosticException);
            }

            class TelemetryDiagnostics : UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics
            {
                /*0x10*/ UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper m_TelemetryDiagnosticsInstanceWrapper;

                /*0x7f35af4*/ TelemetryDiagnostics(UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper telemetryDiagnosticsInstanceWrapper);
                /*0x7f35b24*/ void SendDiagnostic(string diagnosticName, System.Exception e);
            }

            class TelemetryDiagnosticsInstanceWrapper : UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper
            {
                /*0x10*/ Unity.Services.Core.Telemetry.Internal.IDiagnostics m_Instance;
                /*0x18*/ UnityEngine.ILogger m_Logger;
                /*0x20*/ Uniject.IUtil m_Util;
                /*0x28*/ UnityEngine.Purchasing.Telemetry.TelemetryQueue<UnityEngine.Purchasing.Telemetry.TelemetryDiagnosticParams> m_Queue;

                /*0x7f35d18*/ TelemetryDiagnosticsInstanceWrapper(UnityEngine.ILogger logger, Uniject.IUtil util);
                /*0x7f35e20*/ void SetDiagnosticsInstance(Unity.Services.Core.Telemetry.Internal.IDiagnostics diagnosticsInstance);
                /*0x7f35e84*/ void SendDiagnostic(string diagnosticName, string diagnosticException);
                /*0x7f35f34*/ void SendDiagnosticOnMainThread(UnityEngine.Purchasing.Telemetry.TelemetryDiagnosticParams diagnosticParams);
                /*0x7f36090*/ void SendDiagnosticAndCatchExceptions(UnityEngine.Purchasing.Telemetry.TelemetryDiagnosticParams diagnosticParams);

                class <>c__DisplayClass7_0
                {
                    /*0x10*/ UnityEngine.Purchasing.Telemetry.TelemetryDiagnosticsInstanceWrapper <>4__this;
                    /*0x18*/ UnityEngine.Purchasing.Telemetry.TelemetryDiagnosticParams diagnosticParams;

                    /*0x7f36088*/ <>c__DisplayClass7_0();
                    /*0x7f3622c*/ void <SendDiagnosticOnMainThread>b__0();
                }
            }

            class IapTelemetryException : System.Exception
            {
                /*0x7f3624c*/ IapTelemetryException(string message);
            }

            interface ITelemetryMetricEvent
            {
                /*0x38159dc*/ void StartMetric();
                /*0x38159dc*/ void StopAndSendMetric();
            }

            interface ITelemetryMetricsInstanceWrapper
            {
                /*0x3816710*/ void SetMetricsInstance(Unity.Services.Core.Telemetry.Internal.IMetrics metricsInstance);
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

                static /*0x7f362ec*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition op_Implicit(string name);
                /*0x7f362c4*/ TelemetryMetricDefinition(string metricName, UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes metricType);
                /*0x7f362b4*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes get_MetricType();
                /*0x7f362bc*/ string get_MetricName();
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

                static /*0x7f36320*/ TelemetryMetricDefinitions();
            }

            class TelemetryMetricEvent : UnityEngine.Purchasing.Telemetry.ITelemetryMetricEvent
            {
                /*0x10*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper m_TelemetryMetricsInstanceWrapper;
                /*0x18*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes m_MetricType;
                /*0x20*/ string m_MetricName;
                /*0x28*/ System.Diagnostics.Stopwatch m_Stopwatch;

                /*0x7f367cc*/ TelemetryMetricEvent(UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper, UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes metricType, string metricName);
                /*0x7f36878*/ void StartMetric();
                /*0x7f368fc*/ void StopAndSendMetric();
            }

            struct TelemetryMetricParams
            {
                /*0x10*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes type;
                /*0x18*/ string name;
                /*0x20*/ double timeSeconds;

                /*0x7f36a7c*/ TelemetryMetricParams(UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes metricType, string metricName, double metricTimeSeconds);
            }

            class TelemetryMetricsInstanceWrapper : UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper
            {
                /*0x10*/ Unity.Services.Core.Telemetry.Internal.IMetrics m_Instance;
                /*0x18*/ UnityEngine.ILogger m_Logger;
                /*0x20*/ Uniject.IUtil m_Util;
                /*0x28*/ UnityEngine.Purchasing.Telemetry.TelemetryQueue<UnityEngine.Purchasing.Telemetry.TelemetryMetricParams> m_Queue;

                /*0x7f36aac*/ TelemetryMetricsInstanceWrapper(UnityEngine.ILogger logger, Uniject.IUtil util);
                /*0x7f36bb4*/ void SetMetricsInstance(Unity.Services.Core.Telemetry.Internal.IMetrics metricsInstance);
                /*0x7f36c30*/ void SendMetric(UnityEngine.Purchasing.Telemetry.TelemetryMetricTypes metricType, string metricName, double metricTimeSeconds);
                /*0x7f36d14*/ void SendMetricOnMainThread(UnityEngine.Purchasing.Telemetry.TelemetryMetricParams metricParams);
                /*0x7f36e6c*/ void SendMetricByTypeAndCatchExceptions(UnityEngine.Purchasing.Telemetry.TelemetryMetricParams metricParams);
                /*0x7f36f94*/ void SendMetricByType(UnityEngine.Purchasing.Telemetry.TelemetryMetricParams metricParams);

                class <>c__DisplayClass7_0
                {
                    /*0x10*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper <>4__this;
                    /*0x18*/ UnityEngine.Purchasing.Telemetry.TelemetryMetricParams metricParams;

                    /*0x7f36e64*/ <>c__DisplayClass7_0();
                    /*0x7f3713c*/ void <SendMetricOnMainThread>b__0();
                }
            }

            class TelemetryMetricsService : UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService
            {
                /*0x10*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper m_TelemetryMetricsInstanceWrapper;

                /*0x7f37188*/ TelemetryMetricsService(UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper);
                /*0x7f371b8*/ void ExecuteTimedAction(System.Action timedAction, UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition metricDefinition);
                /*0x7f373ac*/ UnityEngine.Purchasing.Telemetry.ITelemetryMetricEvent CreateAndStartMetricEvent(UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition metricDefinition);
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

                /*0x3816710*/ TelemetryQueue(System.Action<TTelemetryEventParams> sendTelemetryEvent);
                /*0x3910ae8*/ void QueueEvent(TTelemetryEventParams telemetryEvent);
                /*0x38159dc*/ void SendQueuedEvents();
            }
        }

        namespace Extension
        {
            class AbstractPurchasingModule : UnityEngine.Purchasing.Extension.IPurchasingModule
            {
                /*0x10*/ UnityEngine.Purchasing.Extension.IPurchasingBinder m_Binder;

                /*0x7f3767c*/ AbstractPurchasingModule();
                /*0x7f375a0*/ void Configure(UnityEngine.Purchasing.Extension.IPurchasingBinder binder);
                /*0x7f375c4*/ void RegisterStore(string name, UnityEngine.Purchasing.Extension.IStore store);
                /*0x3910ae8*/ void BindExtension<T>(T instance);
                /*0x3910ae8*/ void BindConfiguration<T>(T instance);
                /*0x38159dc*/ void Configure();
            }

            class AbstractStore : UnityEngine.Purchasing.Extension.IStore
            {
                /*0x7f37684*/ AbstractStore();
                /*0x3816710*/ void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback callback);
                /*0x3816710*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
                /*0x3816810*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);
                /*0x3816810*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId);
            }

            interface ICatalogProvider
            {
                /*0x3816710*/ void FetchProducts(System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>> callback);
            }

            interface IPurchasingBinder
            {
                /*0x3816810*/ void RegisterStore(string name, UnityEngine.Purchasing.Extension.IStore store);
                /*0x3910ae8*/ void RegisterExtension<T>(T instance);
                /*0x3910ae8*/ void RegisterConfiguration<T>(T instance);
            }

            interface IPurchasingModule
            {
                /*0x3816710*/ void Configure(UnityEngine.Purchasing.Extension.IPurchasingBinder binder);
            }

            interface IStore
            {
                /*0x3816710*/ void Initialize(UnityEngine.Purchasing.Extension.IStoreCallback callback);
                /*0x3816710*/ void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products);
                /*0x3816810*/ void Purchase(UnityEngine.Purchasing.ProductDefinition product, string developerPayload);
                /*0x3816810*/ void FinishTransaction(UnityEngine.Purchasing.ProductDefinition product, string transactionId);
            }

            interface IStoreCallback
            {
                /*0x38148bc*/ UnityEngine.Purchasing.ProductCollection get_products();
                /*0x3816044*/ void OnSetupFailed(UnityEngine.Purchasing.InitializationFailureReason reason, string message);
                /*0x3816710*/ void OnProductsRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products);
                /*0x3816920*/ void OnPurchaseSucceeded(string storeSpecificId, string receipt, string transactionIdentifier);
                /*0x3816710*/ void OnAllPurchasesRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchasedProducts);
                /*0x3816710*/ void OnPurchaseFailed(UnityEngine.Purchasing.Extension.PurchaseFailureDescription desc);
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

                /*0x7f3768c*/ ProductDescription(string id, UnityEngine.Purchasing.ProductMetadata metadata, string receipt, string transactionId);
                /*0x7f37700*/ ProductDescription(string id, UnityEngine.Purchasing.ProductMetadata metadata, string receipt, string transactionId, UnityEngine.Purchasing.ProductType type);
                /*0x7f37724*/ ProductDescription(string id, UnityEngine.Purchasing.ProductMetadata metadata);
                /*0x7f37730*/ string get_storeSpecificId();
                /*0x7f37738*/ void set_storeSpecificId(string value);
                /*0x7f37740*/ UnityEngine.Purchasing.ProductMetadata get_metadata();
                /*0x7f37748*/ void set_metadata(UnityEngine.Purchasing.ProductMetadata value);
                /*0x7f37750*/ string get_receipt();
                /*0x7f37758*/ void set_receipt(string value);
                /*0x7f37760*/ string get_transactionId();
                /*0x7f37768*/ void set_transactionId(string value);
            }

            class PurchaseFailureDescription
            {
                /*0x10*/ string <productId>k__BackingField;
                /*0x18*/ UnityEngine.Purchasing.PurchaseFailureReason <reason>k__BackingField;
                /*0x20*/ string <message>k__BackingField;

                /*0x7f32a74*/ PurchaseFailureDescription(string productId, UnityEngine.Purchasing.PurchaseFailureReason reason, string message);
                /*0x7f37770*/ string get_productId();
                /*0x7f37778*/ void set_productId(string value);
                /*0x7f37780*/ UnityEngine.Purchasing.PurchaseFailureReason get_reason();
                /*0x7f37788*/ void set_reason(UnityEngine.Purchasing.PurchaseFailureReason value);
                /*0x7f37790*/ string get_message();
                /*0x7f37798*/ void set_message(string value);
            }
        }
    }
}
