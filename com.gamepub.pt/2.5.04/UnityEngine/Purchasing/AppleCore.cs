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
            void AddTransactionObserver();
            string get_appReceipt();
            void InterceptPromotionalPurchases();
        }
    }
}
