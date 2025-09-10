class <Module>
{
}

namespace UnityEngine
{
    namespace Purchasing
    {
        class iOSStoreBindings : UnityEngine.Purchasing.INativeAppleStore, UnityEngine.Purchasing.INativeStore
        {
            /*0x15d55ac*/ iOSStoreBindings();
            /*0x15d50ac*/ void SetUnityPurchasingCallback(UnityEngine.Purchasing.UnityPurchasingCallback AsyncCallback);
            /*0x15d50ec*/ void RestoreTransactions();
            /*0x15d512c*/ void RefreshAppReceipt();
            /*0x15d516c*/ void AddTransactionObserver();
            /*0x15d51ac*/ void SetApplicationUsername(string applicationUsername);
            /*0x15d51ec*/ void RetrieveProducts(string json);
            /*0x15d522c*/ void Purchase(string productJSON, string developerPayload);
            /*0x15d526c*/ void FinishTransaction(string productJSON, string transactionID);
            /*0x15d52ac*/ string get_appReceipt();
            /*0x15d52ec*/ bool get_canMakePayments();
            /*0x15d532c*/ bool get_simulateAskToBuy();
            /*0x15d536c*/ void set_simulateAskToBuy(bool value);
            /*0x15d53ac*/ void FetchStorePromotionOrder();
            /*0x15d53ec*/ void SetStorePromotionOrder(string json);
            /*0x15d542c*/ void FetchStorePromotionVisibility(string productId);
            /*0x15d546c*/ void SetStorePromotionVisibility(string productId, string visibility);
            /*0x15d54ac*/ string GetTransactionReceiptForProductId(string productId);
            /*0x15d54ec*/ void InterceptPromotionalPurchases();
            /*0x15d552c*/ void ContinuePromotionalPurchases();
            /*0x15d556c*/ void PresentCodeRedemptionSheet();
        }
    }
}
