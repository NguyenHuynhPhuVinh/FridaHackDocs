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

                /*0x2b399d8*/ WinProductDescription(string id, string price, string title, string description, string isoCode, decimal priceD, string receipt, string transactionId, bool consumable);
                /*0x2b3998c*/ void set_platformSpecificID(string value);
                /*0x2b39994*/ void set_price(string value);
                /*0x2b3999c*/ void set_title(string value);
                /*0x2b399a4*/ void set_description(string value);
                /*0x2b399ac*/ void set_ISOCurrencyCode(string value);
                /*0x2b399b4*/ void set_priceDecimal(decimal value);
                /*0x2b399bc*/ void set_receipt(string value);
                /*0x2b399c4*/ void set_transactionID(string value);
                /*0x2b399cc*/ void set_consumable(bool value);
            }
        }
    }
}
