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

                /*0x7f3f204*/ AppleReceipt();
                /*0x7f3f1d4*/ void set_bundleID(string value);
                /*0x7f3f1dc*/ void set_appVersion(string value);
                /*0x7f3f1e4*/ void set_opaque(byte[] value);
                /*0x7f3f1ec*/ void set_hash(byte[] value);
                /*0x7f3f1f4*/ void set_originalApplicationVersion(string value);
                /*0x7f3f1fc*/ void set_receiptCreationDate(System.DateTime value);
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

                /*0x7f3f2ac*/ AppleInAppPurchaseReceipt();
                /*0x7f3f20c*/ void set_quantity(int value);
                /*0x7f3f214*/ string get_productID();
                /*0x7f3f21c*/ void set_productID(string value);
                /*0x7f3f224*/ string get_transactionID();
                /*0x7f3f22c*/ void set_transactionID(string value);
                /*0x7f3f234*/ string get_originalTransactionIdentifier();
                /*0x7f3f23c*/ void set_originalTransactionIdentifier(string value);
                /*0x7f3f244*/ System.DateTime get_purchaseDate();
                /*0x7f3f24c*/ void set_purchaseDate(System.DateTime value);
                /*0x7f3f254*/ void set_originalPurchaseDate(System.DateTime value);
                /*0x7f3f25c*/ System.DateTime get_subscriptionExpirationDate();
                /*0x7f3f264*/ void set_subscriptionExpirationDate(System.DateTime value);
                /*0x7f3f26c*/ System.DateTime get_cancellationDate();
                /*0x7f3f274*/ void set_cancellationDate(System.DateTime value);
                /*0x7f3f27c*/ int get_isFreeTrial();
                /*0x7f3f284*/ void set_isFreeTrial(int value);
                /*0x7f3f28c*/ int get_productType();
                /*0x7f3f294*/ void set_productType(int value);
                /*0x7f3f29c*/ int get_isIntroductoryPricePeriod();
                /*0x7f3f2a4*/ void set_isIntroductoryPricePeriod(int value);
            }

            class IAPSecurityException : System.Exception
            {
                /*0x7f3f2b4*/ IAPSecurityException();
            }
        }
    }
}
