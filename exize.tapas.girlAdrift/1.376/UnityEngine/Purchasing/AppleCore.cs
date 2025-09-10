class <Module>
{
}

namespace UnityEngine
{
    namespace Purchasing
    {
        interface INativeAppleStore : UnityEngine.Purchasing.INativeStore
        {
            void SetUnityPurchasingCallback(UnityEngine.Purchasing.UnityPurchasingCallback AsyncCallback);
            void RestoreTransactions();
            void RefreshAppReceipt();
            void AddTransactionObserver();
            void SetApplicationUsername(string applicationUsername);
            string get_appReceipt();
            bool get_canMakePayments();
            bool get_simulateAskToBuy();
            void set_simulateAskToBuy(bool value);
            void FetchStorePromotionOrder();
            void SetStorePromotionOrder(string json);
            void FetchStorePromotionVisibility(string productId);
            void SetStorePromotionVisibility(string productId, string visibility);
            string GetTransactionReceiptForProductId(string productId);
            void InterceptPromotionalPurchases();
            void ContinuePromotionalPurchases();
            void PresentCodeRedemptionSheet();
        }
    }
}
