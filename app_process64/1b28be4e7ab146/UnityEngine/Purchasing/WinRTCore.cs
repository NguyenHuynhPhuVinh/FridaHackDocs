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
                /*0x3816710*/ void BuildDummyProducts(System.Collections.Generic.List<UnityEngine.Purchasing.Default.WinProductDescription> products);
                /*0x3816710*/ void Initialize(UnityEngine.Purchasing.Default.IWindowsIAPCallback callback);
                /*0x3815cc4*/ void RetrieveProducts(bool retryIfOffline);
                /*0x3816710*/ void Purchase(string productId);
                /*0x3816710*/ void FinaliseTransaction(string transactionId);
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

                /*0x7f6db4c*/ WinProductDescription(string id, string price, string title, string description, string isoCode, decimal priceD, string receipt, string transactionId, bool consumable);
                /*0x7f6db00*/ void set_platformSpecificID(string value);
                /*0x7f6db08*/ void set_price(string value);
                /*0x7f6db10*/ void set_title(string value);
                /*0x7f6db18*/ void set_description(string value);
                /*0x7f6db20*/ void set_ISOCurrencyCode(string value);
                /*0x7f6db28*/ void set_priceDecimal(decimal value);
                /*0x7f6db30*/ void set_receipt(string value);
                /*0x7f6db38*/ void set_transactionID(string value);
                /*0x7f6db40*/ void set_consumable(bool value);
            }
        }
    }
}
