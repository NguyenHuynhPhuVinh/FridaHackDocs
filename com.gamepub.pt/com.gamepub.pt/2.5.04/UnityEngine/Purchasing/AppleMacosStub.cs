class <Module>
{
}

namespace UnityEngine
{
    namespace Purchasing
    {
        class OSXStoreBindings : UnityEngine.Purchasing.INativeAppleStore, UnityEngine.Purchasing.INativeStore
        {
            /*0x2b39c28*/ OSXStoreBindings();
            /*0x2b39a68*/ void SetUnityPurchasingCallback(UnityEngine.Purchasing.UnityPurchasingCallback AsyncCallback);
            /*0x2b39aa8*/ void AddTransactionObserver();
            /*0x2b39ae8*/ void RetrieveProducts(string json);
            /*0x2b39b28*/ void Purchase(string productJSON, string developerPayload);
            /*0x2b39b68*/ void FinishTransaction(string productJSON, string transactionID);
            /*0x2b39ba8*/ string get_appReceipt();
            /*0x2b39be8*/ void InterceptPromotionalPurchases();
        }
    }
}
