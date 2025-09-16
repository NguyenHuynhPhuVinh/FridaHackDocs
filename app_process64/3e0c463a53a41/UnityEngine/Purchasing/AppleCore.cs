class <Module>
{
}

namespace UnityEngine
{
    namespace Purchasing
    {
        interface INativeAppleStore : UnityEngine.Purchasing.INativeStore
        {
            /*0x380d83c*/ void SetUnityPurchasingCallback(UnityEngine.Purchasing.UnityPurchasingCallback AsyncCallback);
            /*0x380cb08*/ void RestoreTransactions();
            /*0x380cb08*/ void AddTransactionObserver();
            /*0x380b9e8*/ string get_appReceipt();
            /*0x380b564*/ double get_appReceiptModificationDate();
            /*0x380b128*/ bool get_canMakePayments();
            /*0x380bb68*/ string GetTransactionReceiptForProductId(string productId);
            /*0x380cb08*/ void InterceptPromotionalPurchases();
        }
    }
}
