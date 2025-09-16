class <Module>
{
}

namespace UnityEngine
{
    namespace Purchasing
    {
        interface INativeAppleStore : UnityEngine.Purchasing.INativeStore
        {
            /*0x3816710*/ void SetUnityPurchasingCallback(UnityEngine.Purchasing.UnityPurchasingCallback AsyncCallback);
            /*0x38159dc*/ void RestoreTransactions();
            /*0x38159dc*/ void AddTransactionObserver();
            /*0x38148bc*/ string get_appReceipt();
            /*0x3814438*/ double get_appReceiptModificationDate();
            /*0x3813ffc*/ bool get_canMakePayments();
            /*0x3814a3c*/ string GetTransactionReceiptForProductId(string productId);
            /*0x38159dc*/ void InterceptPromotionalPurchases();
        }
    }
}
