class <Module>
{
}

namespace UnityEngine
{
    namespace Purchasing
    {
        namespace Default
        {
            interface IWindowsIAPCallback
            {
                void OnProductListReceived(UnityEngine.Purchasing.Default.WinProductDescription[] winProducts);
                void OnProductListError(string message);
                void OnPurchaseSucceeded(string productId, string receipt, string transactionId);
                void OnPurchaseFailed(string productId, string error);
                void log(string message);
                void logError(string error);
            }

            interface IWindowsIAP
            {
                void BuildDummyProducts(System.Collections.Generic.List<UnityEngine.Purchasing.Default.WinProductDescription> products);
                void Initialize(UnityEngine.Purchasing.Default.IWindowsIAPCallback callback);
                void RetrieveProducts(bool retryIfOffline);
                void Purchase(string productId);
                void FinaliseTransaction(string transactionId);
            }

            class WinProductDescription
            {
                /*0x10*/ string <platformSpecificID>k__BackingField;
                /*0x18*/ string <price>k__BackingField;
                /*0x20*/ string <title>k__BackingField;
                /*0x28*/ string <description>k__BackingField;
                /*0x30*/ string <ISOCurrencyCode>k__BackingField;
                /*0x38*/ decimal <priceDecimal>k__BackingField;
                /*0x48*/ string <receipt>k__BackingField;
                /*0x50*/ string <transactionID>k__BackingField;
                /*0x58*/ bool <consumable>k__BackingField;

                /*0xe951ec*/ WinProductDescription(string id, string price, string title, string description, string isoCode, decimal priceD, string receipt, string transactionId, bool consumable);
                /*0xe95154*/ string get_platformSpecificID();
                /*0xe9515c*/ void set_platformSpecificID(string value);
                /*0xe95164*/ string get_price();
                /*0xe9516c*/ void set_price(string value);
                /*0xe95174*/ string get_title();
                /*0xe9517c*/ void set_title(string value);
                /*0xe95184*/ string get_description();
                /*0xe9518c*/ void set_description(string value);
                /*0xe95194*/ string get_ISOCurrencyCode();
                /*0xe9519c*/ void set_ISOCurrencyCode(string value);
                /*0xe951a4*/ decimal get_priceDecimal();
                /*0xe951b0*/ void set_priceDecimal(decimal value);
                /*0xe951b8*/ string get_receipt();
                /*0xe951c0*/ void set_receipt(string value);
                /*0xe951c8*/ string get_transactionID();
                /*0xe951d0*/ void set_transactionID(string value);
                /*0xe951d8*/ bool get_consumable();
                /*0xe951e0*/ void set_consumable(bool value);
            }
        }
    }
}
