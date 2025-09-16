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
                /*0x380d83c*/ void BuildDummyProducts(System.Collections.Generic.List<UnityEngine.Purchasing.Default.WinProductDescription> products);
                /*0x380d83c*/ void Initialize(UnityEngine.Purchasing.Default.IWindowsIAPCallback callback);
                /*0x380cdf0*/ void RetrieveProducts(bool retryIfOffline);
                /*0x380d83c*/ void Purchase(string productId);
                /*0x380d83c*/ void FinaliseTransaction(string transactionId);
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

                /*0x7f5671c*/ WinProductDescription(string id, string price, string title, string description, string isoCode, decimal priceD, string receipt, string transactionId, bool consumable);
                /*0x7f566d0*/ void set_platformSpecificID(string value);
                /*0x7f566d8*/ void set_price(string value);
                /*0x7f566e0*/ void set_title(string value);
                /*0x7f566e8*/ void set_description(string value);
                /*0x7f566f0*/ void set_ISOCurrencyCode(string value);
                /*0x7f566f8*/ void set_priceDecimal(decimal value);
                /*0x7f56700*/ void set_receipt(string value);
                /*0x7f56708*/ void set_transactionID(string value);
                /*0x7f56710*/ void set_consumable(bool value);
            }
        }
    }
}
