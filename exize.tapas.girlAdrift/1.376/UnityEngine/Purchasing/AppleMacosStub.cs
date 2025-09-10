class <Module>
{
}

namespace UnityEngine
{
    namespace Purchasing
    {
        class OSXStoreBindings : UnityEngine.Purchasing.INativeAppleStore, UnityEngine.Purchasing.INativeStore
        {
            /*0x14a2040*/ OSXStoreBindings();
            /*0x14a1b40*/ void SetUnityPurchasingCallback(UnityEngine.Purchasing.UnityPurchasingCallback AsyncCallback);
            /*0x14a1b80*/ void RestoreTransactions();
            /*0x14a1bc0*/ void RefreshAppReceipt();
            /*0x14a1c00*/ void AddTransactionObserver();
            /*0x14a1c40*/ void SetApplicationUsername(string applicationUsername);
            /*0x14a1c80*/ void RetrieveProducts(string json);
            /*0x14a1cc0*/ void Purchase(string productJSON, string developerPayload);
            /*0x14a1d00*/ void FinishTransaction(string productJSON, string transactionID);
            /*0x14a1d40*/ string get_appReceipt();
            /*0x14a1d80*/ bool get_canMakePayments();
            /*0x14a1dc0*/ bool get_simulateAskToBuy();
            /*0x14a1e00*/ void set_simulateAskToBuy(bool value);
            /*0x14a1e40*/ void FetchStorePromotionOrder();
            /*0x14a1e80*/ void SetStorePromotionOrder(string json);
            /*0x14a1ec0*/ void FetchStorePromotionVisibility(string productId);
            /*0x14a1f00*/ void SetStorePromotionVisibility(string productId, string visibility);
            /*0x14a1f40*/ string GetTransactionReceiptForProductId(string productId);
            /*0x14a1f80*/ void InterceptPromotionalPurchases();
            /*0x14a1fc0*/ void ContinuePromotionalPurchases();
            /*0x14a2000*/ void PresentCodeRedemptionSheet();
        }
    }
}
