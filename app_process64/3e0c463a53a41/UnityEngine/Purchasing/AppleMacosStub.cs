class <Module>
{
}

namespace UnityEngine
{
    namespace Purchasing
    {
        class OSXStoreBindings : UnityEngine.Purchasing.INativeAppleStore, UnityEngine.Purchasing.INativeStore
        {
            /*0x7f18d84*/ OSXStoreBindings();
            /*0x7f18b1c*/ void SetUnityPurchasingCallback(UnityEngine.Purchasing.UnityPurchasingCallback AsyncCallback);
            /*0x7f18b54*/ void RestoreTransactions();
            /*0x7f18b8c*/ void AddTransactionObserver();
            /*0x7f18bc4*/ void RetrieveProducts(string json);
            /*0x7f18bfc*/ void Purchase(string productJSON, string developerPayload);
            /*0x7f18c34*/ void FinishTransaction(string productJSON, string transactionID);
            /*0x7f18c6c*/ string get_appReceipt();
            /*0x7f18ca4*/ double get_appReceiptModificationDate();
            /*0x7f18cdc*/ bool get_canMakePayments();
            /*0x7f18d14*/ string GetTransactionReceiptForProductId(string productId);
            /*0x7f18d4c*/ void InterceptPromotionalPurchases();
        }
    }
}
