class <Module>
{
}

namespace UnityEngine
{
    namespace Purchasing
    {
        class iOSStoreBindings : UnityEngine.Purchasing.INativeAppleStore, UnityEngine.Purchasing.INativeStore
        {
            /*0x2b39df0*/ iOSStoreBindings();
            /*0x2b39c30*/ void SetUnityPurchasingCallback(UnityEngine.Purchasing.UnityPurchasingCallback AsyncCallback);
            /*0x2b39c70*/ void AddTransactionObserver();
            /*0x2b39cb0*/ void RetrieveProducts(string json);
            /*0x2b39cf0*/ void Purchase(string productJSON, string developerPayload);
            /*0x2b39d30*/ void FinishTransaction(string productJSON, string transactionID);
            /*0x2b39d70*/ string get_appReceipt();
            /*0x2b39db0*/ void InterceptPromotionalPurchases();
        }
    }
}
