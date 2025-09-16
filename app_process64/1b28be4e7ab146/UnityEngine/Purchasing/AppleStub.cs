class <Module>
{
}

namespace UnityEngine
{
    namespace Purchasing
    {
        class iOSStoreBindings : UnityEngine.Purchasing.INativeAppleStore, UnityEngine.Purchasing.INativeStore
        {
            /*0x7f30424*/ iOSStoreBindings();
            /*0x7f301bc*/ void SetUnityPurchasingCallback(UnityEngine.Purchasing.UnityPurchasingCallback AsyncCallback);
            /*0x7f301f4*/ void RestoreTransactions();
            /*0x7f3022c*/ void AddTransactionObserver();
            /*0x7f30264*/ void RetrieveProducts(string json);
            /*0x7f3029c*/ void Purchase(string productJSON, string developerPayload);
            /*0x7f302d4*/ void FinishTransaction(string productJSON, string transactionID);
            /*0x7f3030c*/ string get_appReceipt();
            /*0x7f30344*/ double get_appReceiptModificationDate();
            /*0x7f3037c*/ bool get_canMakePayments();
            /*0x7f303b4*/ string GetTransactionReceiptForProductId(string productId);
            /*0x7f303ec*/ void InterceptPromotionalPurchases();
        }
    }
}
