class <Module>
{
}

namespace UnityEngine
{
    namespace Purchasing
    {
        class OSXStoreBindings : UnityEngine.Purchasing.INativeAppleStore, UnityEngine.Purchasing.INativeStore
        {
            /*0x7f301b4*/ OSXStoreBindings();
            /*0x7f2ff4c*/ void SetUnityPurchasingCallback(UnityEngine.Purchasing.UnityPurchasingCallback AsyncCallback);
            /*0x7f2ff84*/ void RestoreTransactions();
            /*0x7f2ffbc*/ void AddTransactionObserver();
            /*0x7f2fff4*/ void RetrieveProducts(string json);
            /*0x7f3002c*/ void Purchase(string productJSON, string developerPayload);
            /*0x7f30064*/ void FinishTransaction(string productJSON, string transactionID);
            /*0x7f3009c*/ string get_appReceipt();
            /*0x7f300d4*/ double get_appReceiptModificationDate();
            /*0x7f3010c*/ bool get_canMakePayments();
            /*0x7f30144*/ string GetTransactionReceiptForProductId(string productId);
            /*0x7f3017c*/ void InterceptPromotionalPurchases();
        }
    }
}
