class <Module>
{
}

namespace UnityEngine
{
    namespace Purchasing
    {
        class iOSStoreBindings : UnityEngine.Purchasing.INativeAppleStore, UnityEngine.Purchasing.INativeStore
        {
            /*0x7f18ff4*/ iOSStoreBindings();
            /*0x7f18d8c*/ void SetUnityPurchasingCallback(UnityEngine.Purchasing.UnityPurchasingCallback AsyncCallback);
            /*0x7f18dc4*/ void RestoreTransactions();
            /*0x7f18dfc*/ void AddTransactionObserver();
            /*0x7f18e34*/ void RetrieveProducts(string json);
            /*0x7f18e6c*/ void Purchase(string productJSON, string developerPayload);
            /*0x7f18ea4*/ void FinishTransaction(string productJSON, string transactionID);
            /*0x7f18edc*/ string get_appReceipt();
            /*0x7f18f14*/ double get_appReceiptModificationDate();
            /*0x7f18f4c*/ bool get_canMakePayments();
            /*0x7f18f84*/ string GetTransactionReceiptForProductId(string productId);
            /*0x7f18fbc*/ void InterceptPromotionalPurchases();
        }
    }
}
