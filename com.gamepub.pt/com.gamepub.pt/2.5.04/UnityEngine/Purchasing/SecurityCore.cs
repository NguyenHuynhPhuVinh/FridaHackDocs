class <Module>
{
}

namespace UnityEngine
{
    namespace Purchasing
    {
        namespace Security
        {
            class AppleReceipt
            {
                /*0x10*/ string <bundleID>k__BackingField;
                /*0x18*/ string <appVersion>k__BackingField;
                /*0x20*/ byte[] <opaque>k__BackingField;
                /*0x28*/ byte[] <hash>k__BackingField;
                /*0x30*/ string <originalApplicationVersion>k__BackingField;
                /*0x38*/ System.DateTime <receiptCreationDate>k__BackingField;
                /*0x40*/ UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt[] inAppPurchaseReceipts;

                /*0x2b38790*/ AppleReceipt();
                /*0x2b38760*/ void set_bundleID(string value);
                /*0x2b38768*/ void set_appVersion(string value);
                /*0x2b38770*/ void set_opaque(byte[] value);
                /*0x2b38778*/ void set_hash(byte[] value);
                /*0x2b38780*/ void set_originalApplicationVersion(string value);
                /*0x2b38788*/ void set_receiptCreationDate(System.DateTime value);
            }

            class AppleInAppPurchaseReceipt
            {
                /*0x10*/ int <quantity>k__BackingField;
                /*0x18*/ string <productID>k__BackingField;
                /*0x20*/ string <transactionID>k__BackingField;
                /*0x28*/ string <originalTransactionIdentifier>k__BackingField;
                /*0x30*/ System.DateTime <purchaseDate>k__BackingField;
                /*0x38*/ System.DateTime <originalPurchaseDate>k__BackingField;
                /*0x40*/ System.DateTime <subscriptionExpirationDate>k__BackingField;
                /*0x48*/ System.DateTime <cancellationDate>k__BackingField;
                /*0x50*/ int <isFreeTrial>k__BackingField;
                /*0x54*/ int <productType>k__BackingField;
                /*0x58*/ int <isIntroductoryPricePeriod>k__BackingField;

                /*0x2b38758*/ AppleInAppPurchaseReceipt();
                /*0x2b386c0*/ void set_quantity(int value);
                /*0x2b386c8*/ string get_productID();
                /*0x2b386d0*/ void set_productID(string value);
                /*0x2b386d8*/ string get_transactionID();
                /*0x2b386e0*/ void set_transactionID(string value);
                /*0x2b386e8*/ void set_originalTransactionIdentifier(string value);
                /*0x2b386f0*/ System.DateTime get_purchaseDate();
                /*0x2b386f8*/ void set_purchaseDate(System.DateTime value);
                /*0x2b38700*/ void set_originalPurchaseDate(System.DateTime value);
                /*0x2b38708*/ System.DateTime get_subscriptionExpirationDate();
                /*0x2b38710*/ void set_subscriptionExpirationDate(System.DateTime value);
                /*0x2b38718*/ System.DateTime get_cancellationDate();
                /*0x2b38720*/ void set_cancellationDate(System.DateTime value);
                /*0x2b38728*/ int get_isFreeTrial();
                /*0x2b38730*/ void set_isFreeTrial(int value);
                /*0x2b38738*/ int get_productType();
                /*0x2b38740*/ void set_productType(int value);
                /*0x2b38748*/ int get_isIntroductoryPricePeriod();
                /*0x2b38750*/ void set_isIntroductoryPricePeriod(int value);
            }

            class IAPSecurityException : System.Exception
            {
                /*0x2b38798*/ IAPSecurityException();
            }
        }
    }
}
