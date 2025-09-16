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

                /*0x7f27dd4*/ AppleReceipt();
                /*0x7f27da4*/ void set_bundleID(string value);
                /*0x7f27dac*/ void set_appVersion(string value);
                /*0x7f27db4*/ void set_opaque(byte[] value);
                /*0x7f27dbc*/ void set_hash(byte[] value);
                /*0x7f27dc4*/ void set_originalApplicationVersion(string value);
                /*0x7f27dcc*/ void set_receiptCreationDate(System.DateTime value);
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

                /*0x7f27e7c*/ AppleInAppPurchaseReceipt();
                /*0x7f27ddc*/ void set_quantity(int value);
                /*0x7f27de4*/ string get_productID();
                /*0x7f27dec*/ void set_productID(string value);
                /*0x7f27df4*/ string get_transactionID();
                /*0x7f27dfc*/ void set_transactionID(string value);
                /*0x7f27e04*/ string get_originalTransactionIdentifier();
                /*0x7f27e0c*/ void set_originalTransactionIdentifier(string value);
                /*0x7f27e14*/ System.DateTime get_purchaseDate();
                /*0x7f27e1c*/ void set_purchaseDate(System.DateTime value);
                /*0x7f27e24*/ void set_originalPurchaseDate(System.DateTime value);
                /*0x7f27e2c*/ System.DateTime get_subscriptionExpirationDate();
                /*0x7f27e34*/ void set_subscriptionExpirationDate(System.DateTime value);
                /*0x7f27e3c*/ System.DateTime get_cancellationDate();
                /*0x7f27e44*/ void set_cancellationDate(System.DateTime value);
                /*0x7f27e4c*/ int get_isFreeTrial();
                /*0x7f27e54*/ void set_isFreeTrial(int value);
                /*0x7f27e5c*/ int get_productType();
                /*0x7f27e64*/ void set_productType(int value);
                /*0x7f27e6c*/ int get_isIntroductoryPricePeriod();
                /*0x7f27e74*/ void set_isIntroductoryPricePeriod(int value);
            }

            class IAPSecurityException : System.Exception
            {
                /*0x7f27e84*/ IAPSecurityException();
            }
        }
    }
}
