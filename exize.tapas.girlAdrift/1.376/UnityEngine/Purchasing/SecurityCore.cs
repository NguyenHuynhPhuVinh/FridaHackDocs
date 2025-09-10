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
                /*0x20*/ System.DateTime <expirationDate>k__BackingField;
                /*0x28*/ byte[] <opaque>k__BackingField;
                /*0x30*/ byte[] <hash>k__BackingField;
                /*0x38*/ string <originalApplicationVersion>k__BackingField;
                /*0x40*/ System.DateTime <receiptCreationDate>k__BackingField;
                /*0x48*/ UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt[] inAppPurchaseReceipts;

                /*0x170b40c*/ AppleReceipt();
                /*0x170b39c*/ string get_bundleID();
                /*0x170b3a4*/ void set_bundleID(string value);
                /*0x170b3ac*/ string get_appVersion();
                /*0x170b3b4*/ void set_appVersion(string value);
                /*0x170b3bc*/ System.DateTime get_expirationDate();
                /*0x170b3c4*/ void set_expirationDate(System.DateTime value);
                /*0x170b3cc*/ byte[] get_opaque();
                /*0x170b3d4*/ void set_opaque(byte[] value);
                /*0x170b3dc*/ byte[] get_hash();
                /*0x170b3e4*/ void set_hash(byte[] value);
                /*0x170b3ec*/ string get_originalApplicationVersion();
                /*0x170b3f4*/ void set_originalApplicationVersion(string value);
                /*0x170b3fc*/ System.DateTime get_receiptCreationDate();
                /*0x170b404*/ void set_receiptCreationDate(System.DateTime value);
            }

            class AppleInAppPurchaseReceipt : UnityEngine.Purchasing.Security.IPurchaseReceipt
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

                /*0x170b4c4*/ AppleInAppPurchaseReceipt();
                /*0x170b414*/ int get_quantity();
                /*0x170b41c*/ void set_quantity(int value);
                /*0x170b424*/ string get_productID();
                /*0x170b42c*/ void set_productID(string value);
                /*0x170b434*/ string get_transactionID();
                /*0x170b43c*/ void set_transactionID(string value);
                /*0x170b444*/ string get_originalTransactionIdentifier();
                /*0x170b44c*/ void set_originalTransactionIdentifier(string value);
                /*0x170b454*/ System.DateTime get_purchaseDate();
                /*0x170b45c*/ void set_purchaseDate(System.DateTime value);
                /*0x170b464*/ System.DateTime get_originalPurchaseDate();
                /*0x170b46c*/ void set_originalPurchaseDate(System.DateTime value);
                /*0x170b474*/ System.DateTime get_subscriptionExpirationDate();
                /*0x170b47c*/ void set_subscriptionExpirationDate(System.DateTime value);
                /*0x170b484*/ System.DateTime get_cancellationDate();
                /*0x170b48c*/ void set_cancellationDate(System.DateTime value);
                /*0x170b494*/ int get_isFreeTrial();
                /*0x170b49c*/ void set_isFreeTrial(int value);
                /*0x170b4a4*/ int get_productType();
                /*0x170b4ac*/ void set_productType(int value);
                /*0x170b4b4*/ int get_isIntroductoryPricePeriod();
                /*0x170b4bc*/ void set_isIntroductoryPricePeriod(int value);
            }

            class IAPSecurityException : System.Exception
            {
                /*0x170b4cc*/ IAPSecurityException();
                /*0x170b524*/ IAPSecurityException(string message);
            }

            class InvalidSignatureException : UnityEngine.Purchasing.Security.IAPSecurityException
            {
                /*0x170b58c*/ InvalidSignatureException();
            }

            interface IPurchaseReceipt
            {
                string get_transactionID();
                string get_productID();
                System.DateTime get_purchaseDate();
            }
        }
    }
}
