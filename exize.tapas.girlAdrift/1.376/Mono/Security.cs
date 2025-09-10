class <Module>
{
}

class Locale
{
    static /*0x15568bc*/ string GetText(string msg);
    static /*0x15568c0*/ string GetText(string fmt, object[] args);
}

namespace Mono
{
    namespace Security
    {
        class ASN1
        {
            /*0x10*/ byte m_nTag;
            /*0x18*/ byte[] m_aValue;
            /*0x20*/ System.Collections.ArrayList elist;

            /*0x15568c8*/ ASN1(byte tag);
            /*0x15568f4*/ ASN1(byte tag, byte[] data);
            /*0x1556924*/ ASN1(byte[] data);
            /*0x1556bc0*/ int get_Count();
            /*0x1556bdc*/ byte get_Tag();
            /*0x1556be4*/ int get_Length();
            /*0x1556bfc*/ byte[] get_Value();
            /*0x1556c8c*/ void set_Value(byte[] value);
            /*0x1556d34*/ bool CompareArray(byte[] array1, byte[] array2);
            /*0x1556da8*/ bool CompareValue(byte[] value);
            /*0x1556db8*/ Mono.Security.ASN1 Add(Mono.Security.ASN1 asn1);
            /*0x1556e44*/ byte[] GetBytes();
            /*0x1556a9c*/ void Decode(byte[] asn1, ref int anPos, int anLength);
            /*0x15574dc*/ void DecodeTLV(byte[] asn1, ref int pos, ref byte tag, ref int length, ref byte[] content);
            /*0x1557600*/ Mono.Security.ASN1 get_Item(int index);
            /*0x1557730*/ Mono.Security.ASN1 Element(int index, byte anTag);
            /*0x1557884*/ string ToString();
        }

        class ASN1Convert
        {
            static /*0x1557b14*/ Mono.Security.ASN1 FromDateTime(System.DateTime dt);
            static /*0x1557ccc*/ Mono.Security.ASN1 FromInt32(int value);
            static /*0x1557e34*/ Mono.Security.ASN1 FromOid(string oid);
            static /*0x1557f1c*/ Mono.Security.ASN1 FromUnsignedBigInteger(byte[] big);
            static /*0x1558038*/ int ToInt32(Mono.Security.ASN1 asn1);
            static /*0x1558150*/ string ToOid(Mono.Security.ASN1 asn1);
            static /*0x15583dc*/ System.DateTime ToDateTime(Mono.Security.ASN1 time);
        }

        class BitConverterLE
        {
            static /*0x1558938*/ byte[] GetUIntBytes(byte* bytes);
            static /*0x1558a48*/ byte[] GetULongBytes(byte* bytes);
            static /*0x1557e1c*/ byte[] GetBytes(int value);
            static /*0x1558bd8*/ byte[] GetBytes(long value);
            static /*0x1558bf0*/ void UShortFromBytes(byte* dst, byte[] src, int startIndex);
            static /*0x1558ccc*/ void UIntFromBytes(byte* dst, byte[] src, int startIndex);
            static /*0x1558e18*/ int ToInt32(byte[] value, int startIndex);
            static /*0x1558e3c*/ ushort ToUInt16(byte[] value, int startIndex);
            static /*0x1558e60*/ uint ToUInt32(byte[] value, int startIndex);
        }

        class PKCS7
        {
            static /*0x1558e84*/ Mono.Security.ASN1 AlgorithmIdentifier(string oid);
            static /*0x1558f34*/ Mono.Security.ASN1 AlgorithmIdentifier(string oid, Mono.Security.ASN1 parameters);

            class ContentInfo
            {
                /*0x10*/ string contentType;
                /*0x18*/ Mono.Security.ASN1 content;

                /*0x1558fcc*/ ContentInfo();
                /*0x1559044*/ ContentInfo(string oid);
                /*0x1559068*/ ContentInfo(byte[] data);
                /*0x15590d8*/ ContentInfo(Mono.Security.ASN1 asn1);
                /*0x1559260*/ Mono.Security.ASN1 get_ASN1();
                /*0x1559318*/ Mono.Security.ASN1 get_Content();
                /*0x1559320*/ void set_Content(Mono.Security.ASN1 value);
                /*0x1559328*/ string get_ContentType();
                /*0x1559330*/ void set_ContentType(string value);
                /*0x1559264*/ Mono.Security.ASN1 GetASN1();
            }

            class EncryptedData
            {
                /*0x10*/ byte _version;
                /*0x18*/ Mono.Security.PKCS7.ContentInfo _content;
                /*0x20*/ Mono.Security.PKCS7.ContentInfo _encryptionAlgorithm;
                /*0x28*/ byte[] _encrypted;

                /*0x1559338*/ EncryptedData();
                /*0x1559354*/ EncryptedData(Mono.Security.ASN1 asn1);
                /*0x155962c*/ Mono.Security.PKCS7.ContentInfo get_EncryptionAlgorithm();
                /*0x1559634*/ byte[] get_EncryptedContent();
            }

            class SignedData
            {
                /*0x10*/ byte version;
                /*0x18*/ string hashAlgorithm;
                /*0x20*/ Mono.Security.PKCS7.ContentInfo contentInfo;
                /*0x28*/ Mono.Security.X509.X509CertificateCollection certs;
                /*0x30*/ System.Collections.ArrayList crls;
                /*0x38*/ Mono.Security.PKCS7.SignerInfo signerInfo;
                /*0x40*/ bool mda;

                /*0x15596a8*/ SignedData(Mono.Security.ASN1 asn1);
                /*0x155a300*/ Mono.Security.X509.X509CertificateCollection get_Certificates();
                /*0x155a308*/ Mono.Security.PKCS7.ContentInfo get_ContentInfo();
                /*0x155a2e0*/ void set_HashName(string value);
                /*0x155a310*/ Mono.Security.PKCS7.SignerInfo get_SignerInfo();
                /*0x155a12c*/ string OidToName(string oid);
            }

            class SignerInfo
            {
                /*0x10*/ byte version;
                /*0x18*/ string hashAlgorithm;
                /*0x20*/ System.Collections.ArrayList authenticatedAttributes;
                /*0x28*/ System.Collections.ArrayList unauthenticatedAttributes;
                /*0x30*/ byte[] signature;
                /*0x38*/ string issuer;
                /*0x40*/ byte[] serial;
                /*0x48*/ byte[] ski;

                /*0x155a09c*/ SignerInfo();
                /*0x1559d24*/ SignerInfo(Mono.Security.ASN1 asn1);
                /*0x155a450*/ string get_IssuerName();
                /*0x155a458*/ byte[] get_SerialNumber();
                /*0x155a4cc*/ System.Collections.ArrayList get_AuthenticatedAttributes();
                /*0x155a4d4*/ string get_HashName();
                /*0x155a4dc*/ void set_HashName(string value);
                /*0x155a4e4*/ byte[] get_Signature();
                /*0x155a558*/ System.Collections.ArrayList get_UnauthenticatedAttributes();
                /*0x155a560*/ byte get_Version();
            }
        }

        namespace X509
        {
            class PKCS5
            {
                static string pbeWithMD2AndDESCBC = "1.2.840.113549.1.5.1";
                static string pbeWithMD5AndDESCBC = "1.2.840.113549.1.5.3";
                static string pbeWithMD2AndRC2CBC = "1.2.840.113549.1.5.4";
                static string pbeWithMD5AndRC2CBC = "1.2.840.113549.1.5.6";
                static string pbeWithSHA1AndDESCBC = "1.2.840.113549.1.5.10";
                static string pbeWithSHA1AndRC2CBC = "1.2.840.113549.1.5.11";

                /*0x155a568*/ PKCS5();
            }

            class PKCS9
            {
                static string friendlyName = "1.2.840.113549.1.9.20";
                static string localKeyId = "1.2.840.113549.1.9.21";

                /*0x155a570*/ PKCS9();
            }

            class SafeBag
            {
                /*0x10*/ string _bagOID;
                /*0x18*/ Mono.Security.ASN1 _asn1;

                /*0x155a578*/ SafeBag(string bagOID, Mono.Security.ASN1 asn1);
                /*0x155a5a4*/ string get_BagOID();
                /*0x155a5ac*/ Mono.Security.ASN1 get_ASN1();
            }

            class PKCS12 : System.ICloneable
            {
                static string pbeWithSHAAnd128BitRC4 = "1.2.840.113549.1.12.1.1";
                static string pbeWithSHAAnd40BitRC4 = "1.2.840.113549.1.12.1.2";
                static string pbeWithSHAAnd3KeyTripleDESCBC = "1.2.840.113549.1.12.1.3";
                static string pbeWithSHAAnd2KeyTripleDESCBC = "1.2.840.113549.1.12.1.4";
                static string pbeWithSHAAnd128BitRC2CBC = "1.2.840.113549.1.12.1.5";
                static string pbeWithSHAAnd40BitRC2CBC = "1.2.840.113549.1.12.1.6";
                static string keyBag = "1.2.840.113549.1.12.10.1.1";
                static string pkcs8ShroudedKeyBag = "1.2.840.113549.1.12.10.1.2";
                static string certBag = "1.2.840.113549.1.12.10.1.3";
                static string crlBag = "1.2.840.113549.1.12.10.1.4";
                static string secretBag = "1.2.840.113549.1.12.10.1.5";
                static string safeContentsBag = "1.2.840.113549.1.12.10.1.6";
                static string x509Certificate = "1.2.840.113549.1.9.22.1";
                static string sdsiCertificate = "1.2.840.113549.1.9.22.2";
                static string x509Crl = "1.2.840.113549.1.9.23.1";
                static int recommendedIterationCount = 2000;
                static int CryptoApiPasswordLimit = 32;
                static /*0x0*/ int password_max_length;
                /*0x10*/ byte[] _password;
                /*0x18*/ System.Collections.ArrayList _keyBags;
                /*0x20*/ System.Collections.ArrayList _secretBags;
                /*0x28*/ Mono.Security.X509.X509CertificateCollection _certs;
                /*0x30*/ bool _keyBagsChanged;
                /*0x31*/ bool _secretBagsChanged;
                /*0x32*/ bool _certsChanged;
                /*0x34*/ int _iterations;
                /*0x38*/ System.Collections.ArrayList _safeBags;
                /*0x40*/ System.Security.Cryptography.RandomNumberGenerator _rng;

                static /*0x1567b70*/ PKCS12();
                static /*0x156764c*/ int get_MaximumPasswordLength();
                static /*0x15676a4*/ void set_MaximumPasswordLength(int value);
                static /*0x15677bc*/ byte[] LoadFile(string filename);
                static /*0x15679c8*/ Mono.Security.X509.PKCS12 LoadFromFile(string filename);
                static /*0x1567a98*/ Mono.Security.X509.PKCS12 LoadFromFile(string filename, string password);
                /*0x155a5b4*/ PKCS12();
                /*0x155a6a0*/ PKCS12(byte[] data);
                /*0x155af38*/ PKCS12(byte[] data, string password);
                /*0x155af70*/ PKCS12(byte[] data, byte[] password);
                /*0x155a888*/ void Decode(byte[] data);
                /*0x155b8fc*/ void Finalize();
                /*0x155a6d4*/ void set_Password(string value);
                /*0x155b9a8*/ int get_IterationCount();
                /*0x155b9b0*/ void set_IterationCount(int value);
                /*0x155b9b8*/ System.Collections.ArrayList get_Keys();
                /*0x155c26c*/ System.Collections.ArrayList get_Secrets();
                /*0x155c628*/ Mono.Security.X509.X509CertificateCollection get_Certificates();
                /*0x155ca7c*/ System.Security.Cryptography.RandomNumberGenerator get_RNG();
                /*0x155b0f4*/ bool Compare(byte[] expected, byte[] actual);
                /*0x155ca9c*/ System.Security.Cryptography.SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount);
                /*0x155c0b8*/ byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData);
                /*0x155b86c*/ byte[] Decrypt(Mono.Security.PKCS7.EncryptedData ed);
                /*0x155d278*/ byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data);
                /*0x155d4cc*/ System.Security.Cryptography.DSAParameters GetExistingParameters(ref bool found);
                /*0x155da08*/ void AddPrivateKey(Mono.Security.Cryptography.PKCS8.PrivateKeyInfo pki);
                /*0x155b168*/ void ReadSafeBag(Mono.Security.ASN1 safeBag);
                /*0x155dc84*/ Mono.Security.ASN1 Pkcs8ShroudedKeyBagSafeBag(System.Security.Cryptography.AsymmetricAlgorithm aa, System.Collections.IDictionary attributes);
                /*0x155ea58*/ Mono.Security.ASN1 KeyBagSafeBag(System.Security.Cryptography.AsymmetricAlgorithm aa, System.Collections.IDictionary attributes);
                /*0x155f788*/ Mono.Security.ASN1 SecretBagSafeBag(byte[] secret, System.Collections.IDictionary attributes);
                /*0x15602d8*/ Mono.Security.ASN1 CertificateSafeBag(Mono.Security.X509.X509Certificate x509, System.Collections.IDictionary attributes);
                /*0x155afa0*/ byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data);
                /*0x1560f40*/ byte[] GetBytes();
                /*0x15631a8*/ Mono.Security.PKCS7.ContentInfo EncryptedContentInfo(Mono.Security.ASN1 safeBags, string algorithmOid);
                /*0x15631a0*/ void AddCertificate(Mono.Security.X509.X509Certificate cert);
                /*0x15634b8*/ void AddCertificate(Mono.Security.X509.X509Certificate cert, System.Collections.IDictionary attributes);
                /*0x1563198*/ void RemoveCertificate(Mono.Security.X509.X509Certificate cert);
                /*0x1563708*/ void RemoveCertificate(Mono.Security.X509.X509Certificate cert, System.Collections.IDictionary attrs);
                /*0x1563c14*/ bool CompareAsymmetricAlgorithm(System.Security.Cryptography.AsymmetricAlgorithm a1, System.Security.Cryptography.AsymmetricAlgorithm a2);
                /*0x1563cb0*/ void AddPkcs8ShroudedKeyBag(System.Security.Cryptography.AsymmetricAlgorithm aa);
                /*0x1563cb8*/ void AddPkcs8ShroudedKeyBag(System.Security.Cryptography.AsymmetricAlgorithm aa, System.Collections.IDictionary attributes);
                /*0x1564028*/ void RemovePkcs8ShroudedKeyBag(System.Security.Cryptography.AsymmetricAlgorithm aa);
                /*0x1564370*/ void AddKeyBag(System.Security.Cryptography.AsymmetricAlgorithm aa);
                /*0x1564378*/ void AddKeyBag(System.Security.Cryptography.AsymmetricAlgorithm aa, System.Collections.IDictionary attributes);
                /*0x1564634*/ void RemoveKeyBag(System.Security.Cryptography.AsymmetricAlgorithm aa);
                /*0x15648cc*/ void AddSecretBag(byte[] secret);
                /*0x15648d4*/ void AddSecretBag(byte[] secret, System.Collections.IDictionary attributes);
                /*0x1564a6c*/ void RemoveSecretBag(byte[] secret);
                /*0x1564bdc*/ System.Security.Cryptography.AsymmetricAlgorithm GetAsymmetricAlgorithm(System.Collections.IDictionary attrs);
                /*0x15655dc*/ byte[] GetSecret(System.Collections.IDictionary attrs);
                /*0x1565cbc*/ Mono.Security.X509.X509Certificate GetCertificate(System.Collections.IDictionary attrs);
                /*0x156643c*/ System.Collections.IDictionary GetAttributes(System.Security.Cryptography.AsymmetricAlgorithm aa);
                /*0x1566cf8*/ System.Collections.IDictionary GetAttributes(Mono.Security.X509.X509Certificate cert);
                /*0x1567380*/ void SaveToFile(string filename);
                /*0x1567578*/ object Clone();

                class DeriveBytes
                {
                    static /*0x0*/ byte[] keyDiversifier;
                    static /*0x8*/ byte[] ivDiversifier;
                    static /*0x10*/ byte[] macDiversifier;
                    /*0x10*/ string _hashName;
                    /*0x18*/ int _iterations;
                    /*0x20*/ byte[] _password;
                    /*0x28*/ byte[] _salt;

                    static /*0x15681d8*/ DeriveBytes();
                    /*0x155d02c*/ DeriveBytes();
                    /*0x1567bbc*/ string get_HashName();
                    /*0x1567bc4*/ void set_HashName(string value);
                    /*0x1567bcc*/ int get_IterationCount();
                    /*0x1567bd4*/ void set_IterationCount(int value);
                    /*0x1567bdc*/ byte[] get_Password();
                    /*0x155d034*/ void set_Password(byte[] value);
                    /*0x1567c54*/ byte[] get_Salt();
                    /*0x155d0f0*/ void set_Salt(byte[] value);
                    /*0x1567ccc*/ void Adjust(byte[] a, int aOff, byte[] b);
                    /*0x1567da8*/ byte[] Derive(byte[] diversifier, int n);
                    /*0x155d198*/ byte[] DeriveKey(int size);
                    /*0x155d208*/ byte[] DeriveIV(int size);
                    /*0x1560ed0*/ byte[] DeriveMAC(int size);

                    enum Purpose
                    {
                        Key = 0,
                        IV = 1,
                        MAC = 2,
                    }
                }
            }

            class X501
            {
                static /*0x0*/ byte[] countryName;
                static /*0x8*/ byte[] organizationName;
                static /*0x10*/ byte[] organizationalUnitName;
                static /*0x18*/ byte[] commonName;
                static /*0x20*/ byte[] localityName;
                static /*0x28*/ byte[] stateOrProvinceName;
                static /*0x30*/ byte[] streetAddress;
                static /*0x38*/ byte[] serialNumber;
                static /*0x40*/ byte[] domainComponent;
                static /*0x48*/ byte[] userid;
                static /*0x50*/ byte[] email;
                static /*0x58*/ byte[] dnQualifier;
                static /*0x60*/ byte[] title;
                static /*0x68*/ byte[] surname;
                static /*0x70*/ byte[] givenName;
                static /*0x78*/ byte[] initial;

                static /*0x1569ff0*/ X501();
                static /*0x155a318*/ string ToString(Mono.Security.ASN1 seq);
                static /*0x1568ab8*/ string ToString(Mono.Security.ASN1 seq, bool reversed, string separator, bool quotes);
                static /*0x15682f4*/ void AppendEntry(System.Text.StringBuilder sb, Mono.Security.ASN1 entry, bool quotes);
                static /*0x1568c60*/ Mono.Security.X509.X520.AttributeTypeAndValue GetAttributeFromOid(string attributeType);
                static /*0x1569450*/ bool IsOid(string oid);
                static /*0x15694e8*/ Mono.Security.X509.X520.AttributeTypeAndValue ReadAttribute(string value, ref int pos);
                static /*0x156963c*/ bool IsHex(char c);
                static /*0x1569708*/ string ReadHex(string value, ref int pos);
                static /*0x15698bc*/ int ReadEscaped(System.Text.StringBuilder sb, string value, int pos);
                static /*0x1569a58*/ int ReadQuoted(System.Text.StringBuilder sb, string value, int pos);
                static /*0x1569bc4*/ string ReadValue(string value, ref int pos);
                static /*0x1569e5c*/ Mono.Security.ASN1 FromString(string rdn);
                /*0x15682ec*/ X501();
            }

            class X509Builder
            {
                static string defaultHash = "SHA1";
                /*0x10*/ string hashName;

                /*0x156a420*/ X509Builder();
                Mono.Security.ASN1 ToBeSigned(string hashName);
                /*0x156a474*/ string GetOid(string hashName);
                /*0x156a79c*/ string get_Hash();
                /*0x156a7a4*/ void set_Hash(string value);
                /*0x156a800*/ byte[] Sign(System.Security.Cryptography.AsymmetricAlgorithm aa);
                /*0x156a940*/ byte[] Build(Mono.Security.ASN1 tbs, string hashoid, byte[] signature);
                /*0x156aa5c*/ byte[] Sign(System.Security.Cryptography.RSA key);
                /*0x156ab6c*/ byte[] Sign(System.Security.Cryptography.DSA key);
            }

            class X509Crl
            {
                /*0x10*/ string issuer;
                /*0x18*/ byte version;
                /*0x20*/ System.DateTime thisUpdate;
                /*0x28*/ System.DateTime nextUpdate;
                /*0x30*/ System.Collections.ArrayList entries;
                /*0x38*/ string signatureOID;
                /*0x40*/ byte[] signature;
                /*0x48*/ Mono.Security.X509.X509ExtensionCollection extensions;
                /*0x50*/ byte[] encoded;
                /*0x58*/ byte[] hash_value;

                static /*0x156c670*/ Mono.Security.X509.X509Crl CreateFromFile(string filename);
                /*0x156ae34*/ X509Crl(byte[] crl);
                /*0x156af2c*/ void Parse(byte[] crl);
                /*0x156b6c0*/ System.Collections.ArrayList get_Entries();
                /*0x156b6cc*/ Mono.Security.X509.X509Crl.X509CrlEntry get_Item(int index);
                /*0x156b764*/ Mono.Security.X509.X509Crl.X509CrlEntry get_Item(byte[] serialNumber);
                /*0x156b8b0*/ Mono.Security.X509.X509ExtensionCollection get_Extensions();
                /*0x156b8b8*/ byte[] get_Hash();
                /*0x156bacc*/ string get_IssuerName();
                /*0x156bad4*/ System.DateTime get_NextUpdate();
                /*0x156badc*/ System.DateTime get_ThisUpdate();
                /*0x156bae4*/ string get_SignatureAlgorithm();
                /*0x156baec*/ byte[] get_Signature();
                /*0x156bb60*/ byte[] get_RawData();
                /*0x156bbd8*/ byte get_Version();
                /*0x156bbe0*/ bool get_IsCurrent();
                /*0x156bc40*/ bool WasCurrent(System.DateTime instant);
                /*0x156bd24*/ byte[] GetBytes();
                /*0x156bd9c*/ bool Compare(byte[] array1, byte[] array2);
                /*0x156be18*/ Mono.Security.X509.X509Crl.X509CrlEntry GetCrlEntry(Mono.Security.X509.X509Certificate x509);
                /*0x156b768*/ Mono.Security.X509.X509Crl.X509CrlEntry GetCrlEntry(byte[] serialNumber);
                /*0x156bf10*/ bool VerifySignature(Mono.Security.X509.X509Certificate x509);
                /*0x156c144*/ bool VerifySignature(System.Security.Cryptography.DSA dsa);
                /*0x156c410*/ bool VerifySignature(System.Security.Cryptography.RSA rsa);
                /*0x156c4e4*/ bool VerifySignature(System.Security.Cryptography.AsymmetricAlgorithm aa);

                class X509CrlEntry
                {
                    /*0x10*/ byte[] sn;
                    /*0x18*/ System.DateTime revocationDate;
                    /*0x20*/ Mono.Security.X509.X509ExtensionCollection extensions;

                    /*0x156c8b8*/ X509CrlEntry(byte[] serialNumber, System.DateTime revocationDate, Mono.Security.X509.X509ExtensionCollection extensions);
                    /*0x156b5e4*/ X509CrlEntry(Mono.Security.ASN1 entry);
                    /*0x156be98*/ byte[] get_SerialNumber();
                    /*0x156c940*/ System.DateTime get_RevocationDate();
                    /*0x156c948*/ Mono.Security.X509.X509ExtensionCollection get_Extensions();
                    /*0x156c950*/ byte[] GetBytes();
                }
            }

            class X509Certificate : System.Runtime.Serialization.ISerializable
            {
                static string OID_DSA = "1.2.840.10040.4.1";
                static string OID_RSA = "1.2.840.113549.1.1.1";
                static string OID_ECC = "1.2.840.10045.2.1";
                static /*0x0*/ string encoding_error;
                /*0x10*/ Mono.Security.ASN1 decoder;
                /*0x18*/ byte[] m_encodedcert;
                /*0x20*/ System.DateTime m_from;
                /*0x28*/ System.DateTime m_until;
                /*0x30*/ Mono.Security.ASN1 issuer;
                /*0x38*/ string m_issuername;
                /*0x40*/ string m_keyalgo;
                /*0x48*/ byte[] m_keyalgoparams;
                /*0x50*/ Mono.Security.ASN1 subject;
                /*0x58*/ string m_subject;
                /*0x60*/ byte[] m_publickey;
                /*0x68*/ byte[] signature;
                /*0x70*/ string m_signaturealgo;
                /*0x78*/ byte[] m_signaturealgoparams;
                /*0x80*/ byte[] certhash;
                /*0x88*/ System.Security.Cryptography.RSA _rsa;
                /*0x90*/ System.Security.Cryptography.DSA _dsa;
                /*0x98*/ int version;
                /*0xa0*/ byte[] serialnumber;
                /*0xa8*/ byte[] issuerUniqueID;
                /*0xb0*/ byte[] subjectUniqueID;
                /*0xb8*/ Mono.Security.X509.X509ExtensionCollection extensions;

                static /*0x156e8e8*/ X509Certificate();
                static /*0x156d378*/ byte[] PEM(string type, byte[] data);
                /*0x1559b90*/ X509Certificate(byte[] data);
                /*0x156e78c*/ X509Certificate(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x156ca68*/ void Parse(byte[] data);
                /*0x156d4ac*/ byte[] GetUnsignedBigInteger(byte[] integer);
                /*0x155d76c*/ System.Security.Cryptography.DSA get_DSA();
                /*0x156d540*/ void set_DSA(System.Security.Cryptography.DSA value);
                /*0x156d550*/ Mono.Security.X509.X509ExtensionCollection get_Extensions();
                /*0x156d558*/ byte[] get_Hash();
                /*0x156d7ec*/ string get_IssuerName();
                /*0x156d7f4*/ string get_KeyAlgorithm();
                /*0x156d7fc*/ byte[] get_KeyAlgorithmParameters();
                /*0x156d870*/ void set_KeyAlgorithmParameters(byte[] value);
                /*0x156d878*/ byte[] get_PublicKey();
                /*0x156d8ec*/ System.Security.Cryptography.RSA get_RSA();
                /*0x156da78*/ void set_RSA(System.Security.Cryptography.RSA value);
                /*0x156da88*/ byte[] get_RawData();
                /*0x156dafc*/ byte[] get_SerialNumber();
                /*0x156db70*/ byte[] get_Signature();
                /*0x156dfac*/ string get_SignatureAlgorithm();
                /*0x156dfb4*/ byte[] get_SignatureAlgorithmParameters();
                /*0x156e028*/ string get_SubjectName();
                /*0x156e030*/ System.DateTime get_ValidFrom();
                /*0x156e038*/ System.DateTime get_ValidUntil();
                /*0x156e040*/ int get_Version();
                /*0x156e048*/ bool get_IsCurrent();
                /*0x156e0a8*/ bool WasCurrent(System.DateTime instant);
                /*0x156e180*/ byte[] get_IssuerUniqueIdentifier();
                /*0x156e1f4*/ byte[] get_SubjectUniqueIdentifier();
                /*0x156e268*/ bool VerifySignature(System.Security.Cryptography.DSA dsa);
                /*0x156e330*/ bool VerifySignature(System.Security.Cryptography.RSA rsa);
                /*0x156e458*/ bool VerifySignature(System.Security.Cryptography.AsymmetricAlgorithm aa);
                /*0x156e5e4*/ bool CheckSignature(byte[] hash, string hashAlgorithm, byte[] signature);
                /*0x156e674*/ bool get_IsSelfSigned();
                /*0x156e77c*/ Mono.Security.ASN1 GetIssuerName();
                /*0x156e784*/ Mono.Security.ASN1 GetSubjectName();
                /*0x156e88c*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            class X509CertificateBuilder : Mono.Security.X509.X509Builder
            {
                /*0x18*/ byte version;
                /*0x20*/ byte[] sn;
                /*0x28*/ string issuer;
                /*0x30*/ System.DateTime notBefore;
                /*0x38*/ System.DateTime notAfter;
                /*0x40*/ string subject;
                /*0x48*/ System.Security.Cryptography.AsymmetricAlgorithm aa;
                /*0x50*/ byte[] issuerUniqueID;
                /*0x58*/ byte[] subjectUniqueID;
                /*0x60*/ Mono.Security.X509.X509ExtensionCollection extensions;

                /*0x11a44c8*/ X509CertificateBuilder();
                /*0x11a44d0*/ X509CertificateBuilder(byte version);
                /*0x11a45a4*/ byte get_Version();
                /*0x11a45ac*/ void set_Version(byte value);
                /*0x11a45b4*/ byte[] get_SerialNumber();
                /*0x11a45bc*/ void set_SerialNumber(byte[] value);
                /*0x11a45c4*/ string get_IssuerName();
                /*0x11a45cc*/ void set_IssuerName(string value);
                /*0x11a45d4*/ System.DateTime get_NotBefore();
                /*0x11a45dc*/ void set_NotBefore(System.DateTime value);
                /*0x11a45e4*/ System.DateTime get_NotAfter();
                /*0x11a45ec*/ void set_NotAfter(System.DateTime value);
                /*0x11a45f4*/ string get_SubjectName();
                /*0x11a45fc*/ void set_SubjectName(string value);
                /*0x11a4604*/ System.Security.Cryptography.AsymmetricAlgorithm get_SubjectPublicKey();
                /*0x11a460c*/ void set_SubjectPublicKey(System.Security.Cryptography.AsymmetricAlgorithm value);
                /*0x11a4614*/ byte[] get_IssuerUniqueId();
                /*0x11a461c*/ void set_IssuerUniqueId(byte[] value);
                /*0x11a4624*/ byte[] get_SubjectUniqueId();
                /*0x11a462c*/ void set_SubjectUniqueId(byte[] value);
                /*0x11a4634*/ Mono.Security.X509.X509ExtensionCollection get_Extensions();
                /*0x11a463c*/ Mono.Security.ASN1 SubjectPublicKeyInfo();
                /*0x11a49e4*/ byte[] UniqueIdentifier(byte[] id);
                /*0x11a4aa8*/ Mono.Security.ASN1 ToBeSigned(string oid);
            }

            class X509CertificateCollection : System.Collections.CollectionBase, System.Collections.IEnumerable
            {
                /*0x11a4f58*/ X509CertificateCollection();
                /*0x11a4f60*/ X509CertificateCollection(Mono.Security.X509.X509Certificate[] value);
                /*0x11a5054*/ X509CertificateCollection(Mono.Security.X509.X509CertificateCollection value);
                /*0x11a5154*/ Mono.Security.X509.X509Certificate get_Item(int index);
                /*0x11a51ec*/ void set_Item(int index, Mono.Security.X509.X509Certificate value);
                /*0x11a5210*/ int Add(Mono.Security.X509.X509Certificate value);
                /*0x11a4f8c*/ void AddRange(Mono.Security.X509.X509Certificate[] value);
                /*0x11a5080*/ void AddRange(Mono.Security.X509.X509CertificateCollection value);
                /*0x11a5284*/ bool Contains(Mono.Security.X509.X509Certificate value);
                /*0x11a53f0*/ void CopyTo(Mono.Security.X509.X509Certificate[] array, int index);
                /*0x11a5414*/ Mono.Security.X509.X509CertificateCollection.X509CertificateEnumerator GetEnumerator();
                /*0x11a5528*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x11a554c*/ int GetHashCode();
                /*0x11a529c*/ int IndexOf(Mono.Security.X509.X509Certificate value);
                /*0x11a55e8*/ void Insert(int index, Mono.Security.X509.X509Certificate value);
                /*0x11a560c*/ void Remove(Mono.Security.X509.X509Certificate value);
                /*0x11a556c*/ bool Compare(byte[] array1, byte[] array2);

                class X509CertificateEnumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ System.Collections.IEnumerator enumerator;

                    /*0x11a5474*/ X509CertificateEnumerator(Mono.Security.X509.X509CertificateCollection mappings);
                    /*0x11a5630*/ Mono.Security.X509.X509Certificate get_Current();
                    /*0x11a5720*/ object System.Collections.IEnumerator.get_Current();
                    /*0x11a57c4*/ bool System.Collections.IEnumerator.MoveNext();
                    /*0x11a5864*/ void System.Collections.IEnumerator.Reset();
                    /*0x11a5908*/ bool MoveNext();
                    /*0x11a59a8*/ void Reset();
                }
            }

            class X509Chain
            {
                /*0x10*/ Mono.Security.X509.X509CertificateCollection roots;
                /*0x18*/ Mono.Security.X509.X509CertificateCollection certs;
                /*0x20*/ Mono.Security.X509.X509Certificate _root;
                /*0x28*/ Mono.Security.X509.X509CertificateCollection _chain;
                /*0x30*/ Mono.Security.X509.X509ChainStatusFlags _status;

                /*0x11a5a4c*/ X509Chain();
                /*0x11a5ab8*/ X509Chain(Mono.Security.X509.X509CertificateCollection chain);
                /*0x11a5b34*/ Mono.Security.X509.X509CertificateCollection get_Chain();
                /*0x11a5b3c*/ Mono.Security.X509.X509Certificate get_Root();
                /*0x11a5b44*/ Mono.Security.X509.X509ChainStatusFlags get_Status();
                /*0x11a5b4c*/ Mono.Security.X509.X509CertificateCollection get_TrustAnchors();
                /*0x11a5c94*/ void set_TrustAnchors(Mono.Security.X509.X509CertificateCollection value);
                /*0x11a5c9c*/ void LoadCertificate(Mono.Security.X509.X509Certificate x509);
                /*0x11a5cb4*/ void LoadCertificates(Mono.Security.X509.X509CertificateCollection collection);
                /*0x11a5ccc*/ Mono.Security.X509.X509Certificate FindByIssuerName(string issuerName);
                /*0x11a5ed8*/ bool Build(Mono.Security.X509.X509Certificate leaf);
                /*0x11a68b4*/ void Reset();
                /*0x11a6804*/ bool IsValid(Mono.Security.X509.X509Certificate cert);
                /*0x11a6288*/ Mono.Security.X509.X509Certificate FindCertificateParent(Mono.Security.X509.X509Certificate child);
                /*0x11a6478*/ Mono.Security.X509.X509Certificate FindCertificateRoot(Mono.Security.X509.X509Certificate potentialRoot);
                /*0x11a68f4*/ bool IsTrusted(Mono.Security.X509.X509Certificate potentialTrusted);
                /*0x11a66bc*/ bool IsParent(Mono.Security.X509.X509Certificate child, Mono.Security.X509.X509Certificate parent);
            }

            enum X509ChainStatusFlags
            {
                InvalidBasicConstraints = 1024,
                NoError = 0,
                NotSignatureValid = 8,
                NotTimeNested = 2,
                NotTimeValid = 1,
                PartialChain = 65536,
                UntrustedRoot = 32,
            }

            class X509Extension
            {
                /*0x10*/ string extnOid;
                /*0x18*/ bool extnCritical;
                /*0x20*/ Mono.Security.ASN1 extnValue;

                /*0x11a69d4*/ X509Extension();
                /*0x11a69f0*/ X509Extension(Mono.Security.ASN1 asn1);
                /*0x11a6cb0*/ X509Extension(Mono.Security.X509.X509Extension extension);
                /*0x11a6e20*/ void Decode();
                /*0x11a6e24*/ void Encode();
                /*0x11a6e28*/ Mono.Security.ASN1 get_ASN1();
                /*0x11a6f44*/ string get_Oid();
                /*0x11a6f4c*/ bool get_Critical();
                /*0x11a6f54*/ void set_Critical(bool value);
                /*0x11a6f60*/ string get_Name();
                /*0x11a6df4*/ Mono.Security.ASN1 get_Value();
                /*0x11a6f68*/ bool Equals(object obj);
                /*0x11a70b0*/ byte[] GetBytes();
                /*0x11a70d0*/ int GetHashCode();
                /*0x11a70f0*/ void WriteLine(System.Text.StringBuilder sb, int n, int pos);
                /*0x11a731c*/ string ToString();
            }

            class X509ExtensionCollection : System.Collections.CollectionBase, System.Collections.IEnumerable
            {
                /*0x18*/ bool readOnly;

                /*0x11a459c*/ X509ExtensionCollection();
                /*0x11a7410*/ X509ExtensionCollection(Mono.Security.ASN1 asn1);
                /*0x11a7554*/ int Add(Mono.Security.X509.X509Extension extension);
                /*0x11a7608*/ void AddRange(Mono.Security.X509.X509Extension[] extension);
                /*0x11a7710*/ void AddRange(Mono.Security.X509.X509ExtensionCollection collection);
                /*0x11a78bc*/ bool Contains(Mono.Security.X509.X509Extension extension);
                /*0x11a7a34*/ bool Contains(string oid);
                /*0x11a7b88*/ void CopyTo(Mono.Security.X509.X509Extension[] extensions, int index);
                /*0x11a78d4*/ int IndexOf(Mono.Security.X509.X509Extension extension);
                /*0x11a7a4c*/ int IndexOf(string oid);
                /*0x11a7bfc*/ void Insert(int index, Mono.Security.X509.X509Extension extension);
                /*0x11a7c70*/ void Remove(Mono.Security.X509.X509Extension extension);
                /*0x11a7ce4*/ void Remove(string oid);
                /*0x11a7d74*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x11a7824*/ Mono.Security.X509.X509Extension get_Item(int index);
                /*0x11a6920*/ Mono.Security.X509.X509Extension get_Item(string oid);
                /*0x11a4e08*/ byte[] GetBytes();
            }

            class X509Store
            {
                /*0x10*/ string _storePath;
                /*0x18*/ Mono.Security.X509.X509CertificateCollection _certificates;
                /*0x20*/ System.Collections.ArrayList _crls;
                /*0x28*/ bool _crl;
                /*0x29*/ bool _newFormat;
                /*0x30*/ string _name;

                /*0x11a7d98*/ X509Store(string path, bool crl, bool newFormat);
                /*0x11a7dd8*/ Mono.Security.X509.X509CertificateCollection get_Certificates();
                /*0x11a7fd8*/ System.Collections.ArrayList get_Crls();
                /*0x11a8228*/ string get_Name();
                /*0x11a82c0*/ void Clear();
                /*0x11a8300*/ void ClearCertificates();
                /*0x11a8324*/ void ClearCrls();
                /*0x11a8350*/ void Import(Mono.Security.X509.X509Certificate certificate);
                /*0x11a8e18*/ void Import(Mono.Security.X509.X509Crl crl);
                /*0x11a9150*/ void Remove(Mono.Security.X509.X509Certificate certificate);
                /*0x11a9500*/ void Remove(Mono.Security.X509.X509Crl crl);
                /*0x11a88d4*/ void ImportNewFormat(Mono.Security.X509.X509Certificate certificate);
                /*0x11a9278*/ void RemoveNewFormat(Mono.Security.X509.X509Certificate certificate);
                /*0x11a8d60*/ string GetUniqueNameWithSerial(Mono.Security.X509.X509Certificate certificate);
                /*0x11a8cb8*/ string GetUniqueName(Mono.Security.X509.X509Certificate certificate, byte[] serial);
                /*0x11a90ac*/ string GetUniqueName(Mono.Security.X509.X509Crl crl);
                /*0x11a9600*/ byte[] GetUniqueName(Mono.Security.X509.X509ExtensionCollection extensions, byte[] serial);
                /*0x11a9734*/ string GetUniqueName(string method, byte[] name, string fileExtension);
                /*0x11a9918*/ byte[] Load(string filename);
                /*0x11a8da4*/ Mono.Security.X509.X509Certificate LoadCertificate(string filename);
                /*0x11a9b24*/ Mono.Security.X509.X509Crl LoadCrl(string filename);
                /*0x11a87f8*/ bool CheckStore(string path, bool throwException);
                /*0x11a7e00*/ Mono.Security.X509.X509CertificateCollection BuildCertificatesCollection(string storeName);
                /*0x11a8068*/ System.Collections.ArrayList BuildCrlsCollection(string storeName);
            }

            class X509StoreManager
            {
                static /*0x0*/ string _userPath;
                static /*0x8*/ string _localMachinePath;
                static /*0x10*/ string _newUserPath;
                static /*0x18*/ string _newLocalMachinePath;
                static /*0x20*/ Mono.Security.X509.X509Stores _userStore;
                static /*0x28*/ Mono.Security.X509.X509Stores _machineStore;
                static /*0x30*/ Mono.Security.X509.X509Stores _newUserStore;
                static /*0x38*/ Mono.Security.X509.X509Stores _newMachineStore;

                static /*0x11a9ba0*/ string get_CurrentUserPath();
                static /*0x11a9ca0*/ string get_LocalMachinePath();
                static /*0x11a9d88*/ string get_NewCurrentUserPath();
                static /*0x11a9e70*/ string get_NewLocalMachinePath();
                static /*0x11a9f58*/ Mono.Security.X509.X509Stores get_CurrentUser();
                static /*0x11aa028*/ Mono.Security.X509.X509Stores get_LocalMachine();
                static /*0x11aa0c8*/ Mono.Security.X509.X509Stores get_NewCurrentUser();
                static /*0x11aa16c*/ Mono.Security.X509.X509Stores get_NewLocalMachine();
                static /*0x11aa210*/ Mono.Security.X509.X509CertificateCollection get_IntermediateCACertificates();
                static /*0x11aa3b8*/ System.Collections.ArrayList get_IntermediateCACrls();
                static /*0x11a5bc8*/ Mono.Security.X509.X509CertificateCollection get_TrustedRootCertificates();
                static /*0x11aa548*/ System.Collections.ArrayList get_TrustedRootCACrls();
                static /*0x11aa5fc*/ Mono.Security.X509.X509CertificateCollection get_UntrustedCertificates();
                /*0x11a9b98*/ X509StoreManager();
            }

            class X509Stores
            {
                /*0x10*/ string _storePath;
                /*0x18*/ bool _newFormat;
                /*0x20*/ Mono.Security.X509.X509Store _personal;
                /*0x28*/ Mono.Security.X509.X509Store _other;
                /*0x30*/ Mono.Security.X509.X509Store _intermediate;
                /*0x38*/ Mono.Security.X509.X509Store _trusted;
                /*0x40*/ Mono.Security.X509.X509Store _untrusted;

                /*0x11a9ff8*/ X509Stores(string path, bool newFormat);
                /*0x11aa7a0*/ Mono.Security.X509.X509Store get_Personal();
                /*0x11aa870*/ Mono.Security.X509.X509Store get_OtherPeople();
                /*0x11aa2dc*/ Mono.Security.X509.X509Store get_IntermediateCA();
                /*0x11aa46c*/ Mono.Security.X509.X509Store get_TrustedRoot();
                /*0x11aa6c8*/ Mono.Security.X509.X509Store get_Untrusted();
                /*0x11aa940*/ void Clear();
                /*0x11aa9a0*/ Mono.Security.X509.X509Store Open(string storeName, bool create);

                class Names
                {
                    static string Personal = "My";
                    static string OtherPeople = "AddressBook";
                    static string IntermediateCA = "CA";
                    static string TrustedRoot = "Trust";
                    static string Untrusted = "Disallowed";

                    /*0x11aaac0*/ Names();
                }
            }

            class X520
            {
                /*0x11aaac8*/ X520();

                class AttributeTypeAndValue
                {
                    /*0x10*/ string oid;
                    /*0x18*/ string attrValue;
                    /*0x20*/ int upperBound;
                    /*0x24*/ byte encoding;

                    /*0x11aaad0*/ AttributeTypeAndValue(string oid, int upperBound);
                    /*0x11aab08*/ AttributeTypeAndValue(string oid, int upperBound, byte encoding);
                    /*0x11aab48*/ string get_Value();
                    /*0x11aab50*/ void set_Value(string value);
                    /*0x11aac10*/ Mono.Security.ASN1 get_ASN1();
                    /*0x11aac20*/ Mono.Security.ASN1 GetASN1(byte encoding);
                    /*0x11aac18*/ Mono.Security.ASN1 GetASN1();
                    /*0x11aae40*/ byte[] GetBytes(byte encoding);
                    /*0x11aae60*/ byte[] GetBytes();
                    /*0x11aadbc*/ byte SelectBestEncoding();
                }

                class Name : Mono.Security.X509.X520.AttributeTypeAndValue
                {
                    /*0x11aae84*/ Name();
                }

                class CommonName : Mono.Security.X509.X520.AttributeTypeAndValue
                {
                    /*0x11aaee8*/ CommonName();
                }

                class SerialNumber : Mono.Security.X509.X520.AttributeTypeAndValue
                {
                    /*0x11aaf4c*/ SerialNumber();
                }

                class LocalityName : Mono.Security.X509.X520.AttributeTypeAndValue
                {
                    /*0x11aafb0*/ LocalityName();
                }

                class StateOrProvinceName : Mono.Security.X509.X520.AttributeTypeAndValue
                {
                    /*0x11ab014*/ StateOrProvinceName();
                }

                class OrganizationName : Mono.Security.X509.X520.AttributeTypeAndValue
                {
                    /*0x11ab078*/ OrganizationName();
                }

                class OrganizationalUnitName : Mono.Security.X509.X520.AttributeTypeAndValue
                {
                    /*0x11ab0dc*/ OrganizationalUnitName();
                }

                class EmailAddress : Mono.Security.X509.X520.AttributeTypeAndValue
                {
                    /*0x11ab140*/ EmailAddress();
                }

                class DomainComponent : Mono.Security.X509.X520.AttributeTypeAndValue
                {
                    /*0x11ab1a4*/ DomainComponent();
                }

                class UserId : Mono.Security.X509.X520.AttributeTypeAndValue
                {
                    /*0x11ab208*/ UserId();
                }

                class Oid : Mono.Security.X509.X520.AttributeTypeAndValue
                {
                    /*0x11ab26c*/ Oid(string oid);
                }

                class Title : Mono.Security.X509.X520.AttributeTypeAndValue
                {
                    /*0x11ab2a4*/ Title();
                }

                class CountryName : Mono.Security.X509.X520.AttributeTypeAndValue
                {
                    /*0x11ab308*/ CountryName();
                }

                class DnQualifier : Mono.Security.X509.X520.AttributeTypeAndValue
                {
                    /*0x11ab36c*/ DnQualifier();
                }

                class Surname : Mono.Security.X509.X520.AttributeTypeAndValue
                {
                    /*0x11ab3d0*/ Surname();
                }

                class GivenName : Mono.Security.X509.X520.AttributeTypeAndValue
                {
                    /*0x11ab434*/ GivenName();
                }

                class Initial : Mono.Security.X509.X520.AttributeTypeAndValue
                {
                    /*0x11ab498*/ Initial();
                }
            }

            namespace Extensions
            {
                class AuthorityKeyIdentifierExtension : Mono.Security.X509.X509Extension
                {
                    /*0x28*/ byte[] aki;

                    /*0x11ab4fc*/ AuthorityKeyIdentifierExtension(Mono.Security.X509.X509Extension extension);
                    /*0x11ab500*/ void Decode();
                    /*0x11ab62c*/ void Encode();
                    /*0x11ab744*/ string get_Name();
                    /*0x11ab784*/ byte[] get_Identifier();
                    /*0x11ab7f8*/ string ToString();
                }

                class BasicConstraintsExtension : Mono.Security.X509.X509Extension
                {
                    /*0x28*/ bool cA;
                    /*0x2c*/ int pathLenConstraint;

                    /*0x11a69d0*/ BasicConstraintsExtension(Mono.Security.X509.X509Extension extension);
                    /*0x11ab960*/ void Decode();
                    /*0x11abab0*/ void Encode();
                    /*0x11abbe0*/ bool get_CertificateAuthority();
                    /*0x11abbe8*/ string get_Name();
                    /*0x11abc28*/ string ToString();
                }

                enum KeyUsages
                {
                    digitalSignature = 128,
                    nonRepudiation = 64,
                    keyEncipherment = 32,
                    dataEncipherment = 16,
                    keyAgreement = 8,
                    keyCertSign = 4,
                    cRLSign = 2,
                    encipherOnly = 1,
                    decipherOnly = 2048,
                    none = 0,
                }

                class KeyUsageExtension : Mono.Security.X509.X509Extension
                {
                    /*0x28*/ int kubits;

                    /*0x11abdd0*/ KeyUsageExtension(Mono.Security.X509.X509Extension extension);
                    /*0x11abdd4*/ void Decode();
                    /*0x11abf14*/ void Encode();
                    /*0x11ac0a0*/ string get_Name();
                    /*0x11ac0e0*/ bool Support(Mono.Security.X509.Extensions.KeyUsages usage);
                    /*0x11ac1c0*/ string ToString();
                }

                class SubjectKeyIdentifierExtension : Mono.Security.X509.X509Extension
                {
                    /*0x28*/ byte[] ski;

                    /*0x11a98a0*/ SubjectKeyIdentifierExtension(Mono.Security.X509.X509Extension extension);
                    /*0x11ac608*/ void Decode();
                    /*0x11ac6e8*/ void Encode();
                    /*0x11ac7d4*/ string get_Name();
                    /*0x11a98a4*/ byte[] get_Identifier();
                    /*0x11ac814*/ string ToString();
                }
            }
        }

        namespace Protocol
        {
            namespace Ntlm
            {
                class ChallengeResponse : System.IDisposable
                {
                    static /*0x0*/ byte[] magic;
                    static /*0x8*/ byte[] nullEncMagic;
                    /*0x10*/ bool _disposed;
                    /*0x18*/ byte[] _challenge;
                    /*0x20*/ byte[] _lmpwd;
                    /*0x28*/ byte[] _ntpwd;

                    static /*0x11ad810*/ ChallengeResponse();
                    /*0x11ac970*/ ChallengeResponse();
                    /*0x11ac9e0*/ ChallengeResponse(string password, byte[] challenge);
                    /*0x11acf5c*/ void Finalize();
                    /*0x11aca18*/ void set_Password(string value);
                    /*0x11ace28*/ void set_Challenge(byte[] value);
                    /*0x11ad1fc*/ byte[] get_LM();
                    /*0x11ad548*/ byte[] get_NT();
                    /*0x11acffc*/ void Dispose();
                    /*0x11ad5ac*/ void Dispose(bool disposing);
                    /*0x11ad260*/ byte[] GetResponse(byte[] pwd);
                    /*0x11ad618*/ byte[] PrepareDESKey(byte[] key56bits, int position);
                    /*0x11ad060*/ byte[] PasswordToKey(string password, int position);
                }

                class ChallengeResponse2
                {
                    static /*0x0*/ byte[] magic;
                    static /*0x8*/ byte[] nullEncMagic;

                    static /*0x11aecb4*/ ChallengeResponse2();
                    static /*0x11ad8e0*/ byte[] Compute_LM(string password, byte[] challenge);
                    static /*0x11ae07c*/ byte[] Compute_NTLM_Password(string password);
                    static /*0x11ae17c*/ byte[] Compute_NTLM(string password, byte[] challenge);
                    static /*0x11ae1e8*/ void Compute_NTLMv2_Session(string password, byte[] challenge, ref byte[] lm, ref byte[] ntlm);
                    static /*0x11ae3b4*/ byte[] Compute_NTLMv2(Mono.Security.Protocol.Ntlm.Type2Message type2, string username, string password, string domain);
                    static /*0x11ae8d4*/ void Compute(Mono.Security.Protocol.Ntlm.Type2Message type2, Mono.Security.Protocol.Ntlm.NtlmAuthLevel level, string username, string password, string domain, ref byte[] lm, ref byte[] ntlm);
                    static /*0x11add7c*/ byte[] GetResponse(byte[] challenge, byte[] pwd);
                    static /*0x11aeabc*/ byte[] PrepareDESKey(byte[] key56bits, int position);
                    static /*0x11adc14*/ byte[] PasswordToKey(string password, int position);
                }

                class MessageBase
                {
                    static /*0x0*/ byte[] header;
                    /*0x10*/ int _type;
                    /*0x14*/ Mono.Security.Protocol.Ntlm.NtlmFlags _flags;

                    static /*0x11af188*/ MessageBase();
                    /*0x11aed84*/ MessageBase(int messageType);
                    /*0x11aedac*/ Mono.Security.Protocol.Ntlm.NtlmFlags get_Flags();
                    /*0x11aedb4*/ void set_Flags(Mono.Security.Protocol.Ntlm.NtlmFlags value);
                    /*0x11aedbc*/ int get_Type();
                    /*0x11aedc4*/ byte[] PrepareMessage(int messageSize);
                    /*0x11aeec4*/ void Decode(byte[] message);
                    /*0x11af078*/ bool CheckHeader(byte[] message);
                    byte[] GetBytes();
                }

                enum NtlmAuthLevel
                {
                    LM_and_NTLM = 0,
                    LM_and_NTLM_and_try_NTLMv2_Session = 1,
                    NTLM_only = 2,
                    NTLMv2_only = 3,
                }

                enum NtlmFlags
                {
                    NegotiateUnicode = 1,
                    NegotiateOem = 2,
                    RequestTarget = 4,
                    NegotiateNtlm = 512,
                    NegotiateDomainSupplied = 4096,
                    NegotiateWorkstationSupplied = 8192,
                    NegotiateAlwaysSign = 32768,
                    NegotiateNtlm2Key = 524288,
                    Negotiate128 = 536870912,
                    Negotiate56 = -2147483648,
                }

                class NtlmSettings
                {
                    static /*0x0*/ Mono.Security.Protocol.Ntlm.NtlmAuthLevel defaultAuthLevel;

                    static /*0x11af274*/ NtlmSettings();
                    static /*0x11af21c*/ Mono.Security.Protocol.Ntlm.NtlmAuthLevel get_DefaultAuthLevel();
                }

                class Type1Message : Mono.Security.Protocol.Ntlm.MessageBase
                {
                    /*0x18*/ string _host;
                    /*0x20*/ string _domain;

                    /*0x11af2c0*/ Type1Message();
                    /*0x11af344*/ void set_Domain(string value);
                    /*0x11af3c4*/ void set_Host(string value);
                    /*0x11af444*/ void Decode(byte[] message);
                    /*0x11af518*/ byte[] GetBytes();
                }

                class Type2Message : Mono.Security.Protocol.Ntlm.MessageBase
                {
                    /*0x18*/ byte[] _nonce;
                    /*0x20*/ string _targetName;
                    /*0x28*/ byte[] _targetInfo;

                    /*0x11af764*/ Type2Message(byte[] message);
                    /*0x11af808*/ void Finalize();
                    /*0x11ae85c*/ byte[] get_Nonce();
                    /*0x11af8b0*/ string get_TargetName();
                    /*0x11ae7e4*/ byte[] get_TargetInfo();
                    /*0x11af8b8*/ void Decode(byte[] message);
                    /*0x11afa30*/ byte[] GetBytes();
                }

                class Type3Message : Mono.Security.Protocol.Ntlm.MessageBase
                {
                    /*0x18*/ Mono.Security.Protocol.Ntlm.NtlmAuthLevel _level;
                    /*0x20*/ byte[] _challenge;
                    /*0x28*/ string _host;
                    /*0x30*/ string _domain;
                    /*0x38*/ string _username;
                    /*0x40*/ string _password;
                    /*0x48*/ Mono.Security.Protocol.Ntlm.Type2Message _type2;
                    /*0x50*/ byte[] _lm;
                    /*0x58*/ byte[] _nt;

                    /*0x11afae8*/ Type3Message(Mono.Security.Protocol.Ntlm.Type2Message type2);
                    /*0x11afcd4*/ void Finalize();
                    /*0x11afdb4*/ void set_Domain(string value);
                    /*0x11afe34*/ void set_Password(string value);
                    /*0x11afe3c*/ void set_Username(string value);
                    /*0x11afe44*/ void Decode(byte[] message);
                    /*0x11b0034*/ string DecodeString(byte[] buffer, int offset, int len);
                    /*0x11b008c*/ byte[] EncodeString(string text);
                    /*0x11b011c*/ byte[] GetBytes();
                }
            }
        }

        namespace Interface
        {
            enum AlertLevel
            {
                Warning = 1,
                Fatal = 2,
            }

            enum AlertDescription
            {
                CloseNotify = 0,
                UnexpectedMessage = 10,
                BadRecordMAC = 20,
                DecryptionFailed_RESERVED = 21,
                RecordOverflow = 22,
                DecompressionFailure = 30,
                HandshakeFailure = 40,
                NoCertificate_RESERVED = 41,
                BadCertificate = 42,
                UnsupportedCertificate = 43,
                CertificateRevoked = 44,
                CertificateExpired = 45,
                CertificateUnknown = 46,
                IlegalParameter = 47,
                UnknownCA = 48,
                AccessDenied = 49,
                DecodeError = 50,
                DecryptError = 51,
                ExportRestriction = 60,
                ProtocolVersion = 70,
                InsuficientSecurity = 71,
                InternalError = 80,
                UserCancelled = 90,
                NoRenegotiation = 100,
                UnsupportedExtension = 110,
            }

            class Alert
            {
                /*0x10*/ Mono.Security.Interface.AlertLevel level;
                /*0x11*/ Mono.Security.Interface.AlertDescription description;

                /*0x11b0754*/ Alert(Mono.Security.Interface.AlertDescription description);
                /*0x11b0744*/ Mono.Security.Interface.AlertLevel get_Level();
                /*0x11b074c*/ Mono.Security.Interface.AlertDescription get_Description();
                /*0x11b07c0*/ void inferAlertLevel();
                /*0x11b0800*/ string ToString();
            }

            class ValidationResult
            {
                /*0x10*/ bool trusted;
                /*0x11*/ bool user_denied;
                /*0x14*/ int error_code;
                /*0x18*/ System.Nullable<Mono.Security.Interface.MonoSslPolicyErrors> policy_errors;

                /*0x11b08bc*/ ValidationResult(bool trusted, bool user_denied, int error_code, System.Nullable<Mono.Security.Interface.MonoSslPolicyErrors> policy_errors);
                /*0x11b0904*/ bool get_Trusted();
                /*0x11b090c*/ bool get_UserDenied();
            }

            interface ICertificateValidator
            {
            }

            enum CipherSuiteCode
            {
                TLS_NULL_WITH_NULL_NULL = 0,
                TLS_RSA_WITH_NULL_MD5 = 1,
                TLS_RSA_WITH_NULL_SHA = 2,
                TLS_RSA_EXPORT_WITH_RC4_40_MD5 = 3,
                TLS_RSA_WITH_RC4_128_MD5 = 4,
                TLS_RSA_WITH_RC4_128_SHA = 5,
                TLS_RSA_EXPORT_WITH_RC2_CBC_40_MD5 = 6,
                TLS_RSA_WITH_IDEA_CBC_SHA = 7,
                TLS_RSA_EXPORT_WITH_DES40_CBC_SHA = 8,
                TLS_RSA_WITH_DES_CBC_SHA = 9,
                TLS_RSA_WITH_3DES_EDE_CBC_SHA = 10,
                TLS_DH_DSS_EXPORT_WITH_DES40_CBC_SHA = 11,
                TLS_DH_DSS_WITH_DES_CBC_SHA = 12,
                TLS_DH_DSS_WITH_3DES_EDE_CBC_SHA = 13,
                TLS_DH_RSA_EXPORT_WITH_DES40_CBC_SHA = 14,
                TLS_DH_RSA_WITH_DES_CBC_SHA = 15,
                TLS_DH_RSA_WITH_3DES_EDE_CBC_SHA = 16,
                TLS_DHE_DSS_EXPORT_WITH_DES40_CBC_SHA = 17,
                TLS_DHE_DSS_WITH_DES_CBC_SHA = 18,
                TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA = 19,
                TLS_DHE_RSA_EXPORT_WITH_DES40_CBC_SHA = 20,
                TLS_DHE_RSA_WITH_DES_CBC_SHA = 21,
                TLS_DHE_RSA_WITH_3DES_EDE_CBC_SHA = 22,
                TLS_DH_anon_EXPORT_WITH_RC4_40_MD5 = 23,
                TLS_DH_anon_WITH_RC4_128_MD5 = 24,
                TLS_DH_anon_EXPORT_WITH_DES40_CBC_SHA = 25,
                TLS_DH_anon_WITH_DES_CBC_SHA = 26,
                TLS_DH_anon_WITH_3DES_EDE_CBC_SHA = 27,
                TLS_RSA_WITH_AES_128_CBC_SHA = 47,
                TLS_DH_DSS_WITH_AES_128_CBC_SHA = 48,
                TLS_DH_RSA_WITH_AES_128_CBC_SHA = 49,
                TLS_DHE_DSS_WITH_AES_128_CBC_SHA = 50,
                TLS_DHE_RSA_WITH_AES_128_CBC_SHA = 51,
                TLS_DH_anon_WITH_AES_128_CBC_SHA = 52,
                TLS_RSA_WITH_AES_256_CBC_SHA = 53,
                TLS_DH_DSS_WITH_AES_256_CBC_SHA = 54,
                TLS_DH_RSA_WITH_AES_256_CBC_SHA = 55,
                TLS_DHE_DSS_WITH_AES_256_CBC_SHA = 56,
                TLS_DHE_RSA_WITH_AES_256_CBC_SHA = 57,
                TLS_DH_anon_WITH_AES_256_CBC_SHA = 58,
                TLS_RSA_WITH_CAMELLIA_128_CBC_SHA = 65,
                TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA = 66,
                TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA = 67,
                TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA = 68,
                TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA = 69,
                TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA = 70,
                TLS_RSA_WITH_CAMELLIA_256_CBC_SHA = 132,
                TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA = 133,
                TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA = 134,
                TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA = 135,
                TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA = 136,
                TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA = 137,
                TLS_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 186,
                TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA256 = 187,
                TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 188,
                TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA256 = 189,
                TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 190,
                TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA256 = 191,
                TLS_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 192,
                TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA256 = 193,
                TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 194,
                TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA256 = 195,
                TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 196,
                TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA256 = 197,
                TLS_RSA_WITH_SEED_CBC_SHA = 150,
                TLS_DH_DSS_WITH_SEED_CBC_SHA = 151,
                TLS_DH_RSA_WITH_SEED_CBC_SHA = 152,
                TLS_DHE_DSS_WITH_SEED_CBC_SHA = 153,
                TLS_DHE_RSA_WITH_SEED_CBC_SHA = 154,
                TLS_DH_anon_WITH_SEED_CBC_SHA = 155,
                TLS_PSK_WITH_RC4_128_SHA = 138,
                TLS_PSK_WITH_3DES_EDE_CBC_SHA = 139,
                TLS_PSK_WITH_AES_128_CBC_SHA = 140,
                TLS_PSK_WITH_AES_256_CBC_SHA = 141,
                TLS_DHE_PSK_WITH_RC4_128_SHA = 142,
                TLS_DHE_PSK_WITH_3DES_EDE_CBC_SHA = 143,
                TLS_DHE_PSK_WITH_AES_128_CBC_SHA = 144,
                TLS_DHE_PSK_WITH_AES_256_CBC_SHA = 145,
                TLS_RSA_PSK_WITH_RC4_128_SHA = 146,
                TLS_RSA_PSK_WITH_3DES_EDE_CBC_SHA = 147,
                TLS_RSA_PSK_WITH_AES_128_CBC_SHA = 148,
                TLS_RSA_PSK_WITH_AES_256_CBC_SHA = 149,
                TLS_ECDH_ECDSA_WITH_NULL_SHA = 49153,
                TLS_ECDH_ECDSA_WITH_RC4_128_SHA = 49154,
                TLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA = 49155,
                TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA = 49156,
                TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA = 49157,
                TLS_ECDHE_ECDSA_WITH_NULL_SHA = 49158,
                TLS_ECDHE_ECDSA_WITH_RC4_128_SHA = 49159,
                TLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA = 49160,
                TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA = 49161,
                TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA = 49162,
                TLS_ECDH_RSA_WITH_NULL_SHA = 49163,
                TLS_ECDH_RSA_WITH_RC4_128_SHA = 49164,
                TLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA = 49165,
                TLS_ECDH_RSA_WITH_AES_128_CBC_SHA = 49166,
                TLS_ECDH_RSA_WITH_AES_256_CBC_SHA = 49167,
                TLS_ECDHE_RSA_WITH_NULL_SHA = 49168,
                TLS_ECDHE_RSA_WITH_RC4_128_SHA = 49169,
                TLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA = 49170,
                TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA = 49171,
                TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA = 49172,
                TLS_ECDH_anon_WITH_NULL_SHA = 49173,
                TLS_ECDH_anon_WITH_RC4_128_SHA = 49174,
                TLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA = 49175,
                TLS_ECDH_anon_WITH_AES_128_CBC_SHA = 49176,
                TLS_ECDH_anon_WITH_AES_256_CBC_SHA = 49177,
                TLS_PSK_WITH_NULL_SHA = 44,
                TLS_DHE_PSK_WITH_NULL_SHA = 45,
                TLS_RSA_PSK_WITH_NULL_SHA = 46,
                TLS_SRP_SHA_WITH_3DES_EDE_CBC_SHA = 49178,
                TLS_SRP_SHA_RSA_WITH_3DES_EDE_CBC_SHA = 49179,
                TLS_SRP_SHA_DSS_WITH_3DES_EDE_CBC_SHA = 49180,
                TLS_SRP_SHA_WITH_AES_128_CBC_SHA = 49181,
                TLS_SRP_SHA_RSA_WITH_AES_128_CBC_SHA = 49182,
                TLS_SRP_SHA_DSS_WITH_AES_128_CBC_SHA = 49183,
                TLS_SRP_SHA_WITH_AES_256_CBC_SHA = 49184,
                TLS_SRP_SHA_RSA_WITH_AES_256_CBC_SHA = 49185,
                TLS_SRP_SHA_DSS_WITH_AES_256_CBC_SHA = 49186,
                TLS_RSA_WITH_NULL_SHA256 = 59,
                TLS_RSA_WITH_AES_128_CBC_SHA256 = 60,
                TLS_RSA_WITH_AES_256_CBC_SHA256 = 61,
                TLS_DH_DSS_WITH_AES_128_CBC_SHA256 = 62,
                TLS_DH_RSA_WITH_AES_128_CBC_SHA256 = 63,
                TLS_DHE_DSS_WITH_AES_128_CBC_SHA256 = 64,
                TLS_DHE_RSA_WITH_AES_128_CBC_SHA256 = 103,
                TLS_DH_DSS_WITH_AES_256_CBC_SHA256 = 104,
                TLS_DH_RSA_WITH_AES_256_CBC_SHA256 = 105,
                TLS_DHE_DSS_WITH_AES_256_CBC_SHA256 = 106,
                TLS_DHE_RSA_WITH_AES_256_CBC_SHA256 = 107,
                TLS_DH_anon_WITH_AES_128_CBC_SHA256 = 108,
                TLS_DH_anon_WITH_AES_256_CBC_SHA256 = 109,
                TLS_RSA_WITH_AES_128_GCM_SHA256 = 156,
                TLS_RSA_WITH_AES_256_GCM_SHA384 = 157,
                TLS_DHE_RSA_WITH_AES_128_GCM_SHA256 = 158,
                TLS_DHE_RSA_WITH_AES_256_GCM_SHA384 = 159,
                TLS_DH_RSA_WITH_AES_128_GCM_SHA256 = 160,
                TLS_DH_RSA_WITH_AES_256_GCM_SHA384 = 161,
                TLS_DHE_DSS_WITH_AES_128_GCM_SHA256 = 162,
                TLS_DHE_DSS_WITH_AES_256_GCM_SHA384 = 163,
                TLS_DH_DSS_WITH_AES_128_GCM_SHA256 = 164,
                TLS_DH_DSS_WITH_AES_256_GCM_SHA384 = 165,
                TLS_DH_anon_WITH_AES_128_GCM_SHA256 = 166,
                TLS_DH_anon_WITH_AES_256_GCM_SHA384 = 167,
                TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256 = 49187,
                TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384 = 49188,
                TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256 = 49189,
                TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384 = 49190,
                TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256 = 49191,
                TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384 = 49192,
                TLS_ECDH_RSA_WITH_AES_128_CBC_SHA256 = 49193,
                TLS_ECDH_RSA_WITH_AES_256_CBC_SHA384 = 49194,
                TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256 = 49195,
                TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384 = 49196,
                TLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256 = 49197,
                TLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384 = 49198,
                TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256 = 49199,
                TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384 = 49200,
                TLS_ECDH_RSA_WITH_AES_128_GCM_SHA256 = 49201,
                TLS_ECDH_RSA_WITH_AES_256_GCM_SHA384 = 49202,
                TLS_PSK_WITH_AES_128_GCM_SHA256 = 168,
                TLS_PSK_WITH_AES_256_GCM_SHA384 = 169,
                TLS_DHE_PSK_WITH_AES_128_GCM_SHA256 = 170,
                TLS_DHE_PSK_WITH_AES_256_GCM_SHA384 = 171,
                TLS_RSA_PSK_WITH_AES_128_GCM_SHA256 = 172,
                TLS_RSA_PSK_WITH_AES_256_GCM_SHA384 = 173,
                TLS_PSK_WITH_AES_128_CBC_SHA256 = 174,
                TLS_PSK_WITH_AES_256_CBC_SHA384 = 175,
                TLS_PSK_WITH_NULL_SHA256 = 176,
                TLS_PSK_WITH_NULL_SHA384 = 177,
                TLS_DHE_PSK_WITH_AES_128_CBC_SHA256 = 178,
                TLS_DHE_PSK_WITH_AES_256_CBC_SHA384 = 179,
                TLS_DHE_PSK_WITH_NULL_SHA256 = 180,
                TLS_DHE_PSK_WITH_NULL_SHA384 = 181,
                TLS_RSA_PSK_WITH_AES_128_CBC_SHA256 = 182,
                TLS_RSA_PSK_WITH_AES_256_CBC_SHA384 = 183,
                TLS_RSA_PSK_WITH_NULL_SHA256 = 184,
                TLS_RSA_PSK_WITH_NULL_SHA384 = 185,
                TLS_ECDHE_PSK_WITH_RC4_128_SHA = 49203,
                TLS_ECDHE_PSK_WITH_3DES_EDE_CBC_SHA = 49204,
                TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA = 49205,
                TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA = 49206,
                TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA256 = 49207,
                TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA384 = 49208,
                TLS_ECDHE_PSK_WITH_NULL_SHA = 49209,
                TLS_ECDHE_PSK_WITH_NULL_SHA256 = 49210,
                TLS_ECDHE_PSK_WITH_NULL_SHA384 = 49211,
                TLS_EMPTY_RENEGOTIATION_INFO_SCSV = 255,
                TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 49266,
                TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 49267,
                TLS_ECDH_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 49268,
                TLS_ECDH_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 49269,
                TLS_ECDHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 49270,
                TLS_ECDHE_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 49271,
                TLS_ECDH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 49272,
                TLS_ECDH_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 49273,
                TLS_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49274,
                TLS_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49275,
                TLS_DHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49276,
                TLS_DHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49277,
                TLS_DH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49278,
                TLS_DH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49279,
                TLS_DHE_DSS_WITH_CAMELLIA_128_GCM_SHA256 = 49280,
                TLS_DHE_DSS_WITH_CAMELLIA_256_GCM_SHA384 = 49281,
                TLS_DH_DSS_WITH_CAMELLIA_128_GCM_SHA256 = 49282,
                TLS_DH_DSS_WITH_CAMELLIA_256_GCM_SHA384 = 49283,
                TLS_DH_anon_WITH_CAMELLIA_128_GCM_SHA256 = 49284,
                TLS_DH_anon_WITH_CAMELLIA_256_GCM_SHA384 = 49285,
                TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 49286,
                TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 49287,
                TLS_ECDH_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 49288,
                TLS_ECDH_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 49289,
                TLS_ECDHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49290,
                TLS_ECDHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49291,
                TLS_ECDH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49292,
                TLS_ECDH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49293,
                TLS_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49294,
                TLS_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49295,
                TLS_DHE_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49296,
                TLS_DHE_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49297,
                TLS_RSA_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49298,
                TLS_RSA_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49299,
                TLS_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49300,
                TLS_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49301,
                TLS_DHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49302,
                TLS_DHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49303,
                TLS_RSA_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49304,
                TLS_RSA_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49305,
                TLS_ECDHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49306,
                TLS_ECDHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49307,
                TLS_RSA_WITH_AES_128_CCM = 49308,
                TLS_RSA_WITH_AES_256_CCM = 49309,
                TLS_DHE_RSA_WITH_AES_128_CCM = 49310,
                TLS_DHE_RSA_WITH_AES_256_CCM = 49311,
                TLS_RSA_WITH_AES_128_CCM_8 = 49312,
                TLS_RSA_WITH_AES_256_CCM_8 = 49313,
                TLS_DHE_RSA_WITH_AES_128_CCM_8 = 49314,
                TLS_DHE_RSA_WITH_AES_256_CCM_8 = 49315,
                TLS_PSK_WITH_AES_128_CCM = 49316,
                TLS_PSK_WITH_AES_256_CCM = 49317,
                TLS_DHE_PSK_WITH_AES_128_CCM = 49318,
                TLS_DHE_PSK_WITH_AES_256_CCM = 49319,
                TLS_PSK_WITH_AES_128_CCM_8 = 49320,
                TLS_PSK_WITH_AES_256_CCM_8 = 49321,
                TLS_PSK_DHE_WITH_AES_128_CCM_8 = 49322,
                TLS_PSK_DHE_WITH_AES_256_CCM_8 = 49323,
                TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52243,
                TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256 = 52244,
                TLS_DHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52245,
                TLS_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58384,
                TLS_RSA_WITH_SALSA20_SHA1 = 58385,
                TLS_ECDHE_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58386,
                TLS_ECDHE_RSA_WITH_SALSA20_SHA1 = 58387,
                TLS_ECDHE_ECDSA_WITH_ESTREAM_SALSA20_SHA1 = 58388,
                TLS_ECDHE_ECDSA_WITH_SALSA20_SHA1 = 58389,
                TLS_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58390,
                TLS_PSK_WITH_SALSA20_SHA1 = 58391,
                TLS_ECDHE_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58392,
                TLS_ECDHE_PSK_WITH_SALSA20_SHA1 = 58393,
                TLS_RSA_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58394,
                TLS_RSA_PSK_WITH_SALSA20_SHA1 = 58395,
                TLS_DHE_PSK_WITH_ESTREAM_SALSA20_SHA1 = 58396,
                TLS_DHE_PSK_WITH_SALSA20_SHA1 = 58397,
                TLS_DHE_RSA_WITH_ESTREAM_SALSA20_SHA1 = 58398,
                TLS_DHE_RSA_WITH_SALSA20_SHA1 = 58399,
                TLS_FALLBACK_SCSV = 22016,
            }

            class MonoTlsConnectionInfo
            {
                /*0x10*/ Mono.Security.Interface.CipherSuiteCode <CipherSuiteCode>k__BackingField;
                /*0x14*/ Mono.Security.Interface.TlsProtocols <ProtocolVersion>k__BackingField;
                /*0x18*/ string <PeerDomainName>k__BackingField;

                /*0x11b09f8*/ MonoTlsConnectionInfo();
                /*0x11b0914*/ Mono.Security.Interface.CipherSuiteCode get_CipherSuiteCode();
                /*0x11b091c*/ void set_CipherSuiteCode(Mono.Security.Interface.CipherSuiteCode value);
                /*0x11b0924*/ Mono.Security.Interface.TlsProtocols get_ProtocolVersion();
                /*0x11b092c*/ void set_ProtocolVersion(Mono.Security.Interface.TlsProtocols value);
                /*0x11b0934*/ void set_PeerDomainName(string value);
                /*0x11b093c*/ string ToString();
            }

            enum MonoSslPolicyErrors
            {
                None = 0,
                RemoteCertificateNotAvailable = 1,
                RemoteCertificateNameMismatch = 2,
                RemoteCertificateChainErrors = 4,
            }

            class MonoRemoteCertificateValidationCallback : System.MulticastDelegate
            {
                /*0x11b0a00*/ MonoRemoteCertificateValidationCallback(object object, nint method);
                /*0x11b0ad8*/ bool Invoke(string targetHost, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, Mono.Security.Interface.MonoSslPolicyErrors sslPolicyErrors);
            }

            class MonoLocalCertificateSelectionCallback : System.MulticastDelegate
            {
                /*0x11b0aec*/ MonoLocalCertificateSelectionCallback(object object, nint method);
                /*0x11b0bc4*/ System.Security.Cryptography.X509Certificates.X509Certificate Invoke(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers);
            }

            class MonoTlsProvider
            {
                /*0x11b0bd8*/ MonoTlsProvider();
                System.Guid get_ID();
                string get_Name();
                bool get_SupportsSslStream();
                bool get_SupportsConnectionInfo();
                bool get_SupportsMonoExtensions();
                System.Security.Authentication.SslProtocols get_SupportedProtocols();
                bool get_SupportsCleanShutdown();
            }

            class MonoTlsProviderFactory
            {
                static /*0x11b0be0*/ Mono.Security.Interface.MonoTlsProvider GetProvider();
            }

            class MonoTlsSettings
            {
                static /*0x0*/ Mono.Security.Interface.MonoTlsSettings defaultSettings;
                /*0x10*/ Mono.Security.Interface.MonoRemoteCertificateValidationCallback <RemoteCertificateValidationCallback>k__BackingField;
                /*0x18*/ Mono.Security.Interface.MonoLocalCertificateSelectionCallback <ClientCertificateSelectionCallback>k__BackingField;
                /*0x20*/ System.Nullable<System.DateTime> <CertificateValidationTime>k__BackingField;
                /*0x30*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection <TrustAnchors>k__BackingField;
                /*0x38*/ object <UserSettings>k__BackingField;
                /*0x40*/ string[] <CertificateSearchPaths>k__BackingField;
                /*0x48*/ bool <SendCloseNotify>k__BackingField;
                /*0x50*/ string[] <ClientCertificateIssuers>k__BackingField;
                /*0x58*/ bool <DisallowUnauthenticatedCertificateRequest>k__BackingField;
                /*0x5c*/ System.Nullable<Mono.Security.Interface.TlsProtocols> <EnabledProtocols>k__BackingField;
                /*0x68*/ Mono.Security.Interface.CipherSuiteCode[] <EnabledCiphers>k__BackingField;
                /*0x70*/ bool cloned;
                /*0x71*/ bool checkCertName;
                /*0x72*/ bool checkCertRevocationStatus;
                /*0x73*/ System.Nullable<bool> useServicePointManagerCallback;
                /*0x75*/ bool skipSystemValidators;
                /*0x76*/ bool callbackNeedsChain;
                /*0x78*/ Mono.Security.Interface.ICertificateValidator certificateValidator;

                static /*0x11b0d38*/ Mono.Security.Interface.MonoTlsSettings get_DefaultSettings();
                static /*0x11b0dcc*/ Mono.Security.Interface.MonoTlsSettings CopyDefaultSettings();
                /*0x11b0d24*/ MonoTlsSettings();
                /*0x11b0ecc*/ MonoTlsSettings(Mono.Security.Interface.MonoTlsSettings other);
                /*0x11b0c50*/ Mono.Security.Interface.MonoRemoteCertificateValidationCallback get_RemoteCertificateValidationCallback();
                /*0x11b0c58*/ void set_RemoteCertificateValidationCallback(Mono.Security.Interface.MonoRemoteCertificateValidationCallback value);
                /*0x11b0c60*/ Mono.Security.Interface.MonoLocalCertificateSelectionCallback get_ClientCertificateSelectionCallback();
                /*0x11b0c68*/ void set_ClientCertificateSelectionCallback(Mono.Security.Interface.MonoLocalCertificateSelectionCallback value);
                /*0x11b0c70*/ System.Nullable<bool> get_UseServicePointManagerCallback();
                /*0x11b0c78*/ void set_UseServicePointManagerCallback(System.Nullable<bool> value);
                /*0x11b0c80*/ bool get_CallbackNeedsCertificateChain();
                /*0x11b0c88*/ System.Nullable<System.DateTime> get_CertificateValidationTime();
                /*0x11b0c94*/ void set_CertificateValidationTime(System.Nullable<System.DateTime> value);
                /*0x11b0c9c*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_TrustAnchors();
                /*0x11b0ca4*/ void set_TrustAnchors(System.Security.Cryptography.X509Certificates.X509CertificateCollection value);
                /*0x11b0cac*/ object get_UserSettings();
                /*0x11b0cb4*/ void set_UserSettings(object value);
                /*0x11b0cbc*/ string[] get_CertificateSearchPaths();
                /*0x11b0cc4*/ void set_CertificateSearchPaths(string[] value);
                /*0x11b0ccc*/ bool get_SendCloseNotify();
                /*0x11b0cd4*/ void set_SendCloseNotify(bool value);
                /*0x11b0ce0*/ string[] get_ClientCertificateIssuers();
                /*0x11b0ce8*/ void set_ClientCertificateIssuers(string[] value);
                /*0x11b0cf0*/ bool get_DisallowUnauthenticatedCertificateRequest();
                /*0x11b0cf8*/ void set_DisallowUnauthenticatedCertificateRequest(bool value);
                /*0x11b0d04*/ System.Nullable<Mono.Security.Interface.TlsProtocols> get_EnabledProtocols();
                /*0x11b0d0c*/ void set_EnabledProtocols(System.Nullable<Mono.Security.Interface.TlsProtocols> value);
                /*0x11b0d14*/ Mono.Security.Interface.CipherSuiteCode[] get_EnabledCiphers();
                /*0x11b0d1c*/ void set_EnabledCiphers(Mono.Security.Interface.CipherSuiteCode[] value);
                /*0x11b0e44*/ Mono.Security.Interface.ICertificateValidator get_CertificateValidator();
                /*0x11b0e4c*/ Mono.Security.Interface.MonoTlsSettings CloneWithValidator(Mono.Security.Interface.ICertificateValidator validator);
                /*0x11b0de4*/ Mono.Security.Interface.MonoTlsSettings Clone();
            }

            class TlsException : System.Exception
            {
                /*0x90*/ Mono.Security.Interface.Alert alert;

                /*0x11b1014*/ TlsException(Mono.Security.Interface.Alert alert, string message);
                /*0x11b1088*/ TlsException(Mono.Security.Interface.AlertDescription description, string message);
            }

            enum TlsProtocols
            {
                Zero = 0,
                Tls10Client = 128,
                Tls10Server = 64,
                Tls10 = 192,
                Tls11Client = 512,
                Tls11Server = 256,
                Tls11 = 768,
                Tls12Client = 2048,
                Tls12Server = 1024,
                Tls12 = 3072,
                ClientMask = 2688,
                ServerMask = 1344,
            }
        }

        namespace Cryptography
        {
            class CryptoConvert
            {
                static /*0x11b1100*/ string ToHex(byte[] input);
                static /*0x11b1234*/ byte FromHexChar(char c);
                static /*0x11b12d0*/ byte[] FromHex(string hex);
            }

            class MD2 : System.Security.Cryptography.HashAlgorithm
            {
                static /*0x11b1434*/ Mono.Security.Cryptography.MD2 Create();
                /*0x11b1414*/ MD2();
            }

            class MD2Managed : Mono.Security.Cryptography.MD2
            {
                static /*0x0*/ byte[] PI_SUBST;
                /*0x28*/ byte[] state;
                /*0x30*/ byte[] checksum;
                /*0x38*/ byte[] buffer;
                /*0x40*/ int count;
                /*0x48*/ byte[] x;

                static /*0x11b1a50*/ MD2Managed();
                /*0x11b148c*/ MD2Managed();
                /*0x11b1530*/ byte[] Padding(int nLength);
                /*0x11b15cc*/ void Initialize();
                /*0x11b162c*/ void HashCore(byte[] array, int ibStart, int cbSize);
                /*0x11b1960*/ byte[] HashFinal();
                /*0x11b1708*/ void MD2Transform(byte[] state, byte[] checksum, byte[] block, int index);
            }

            class MD4 : System.Security.Cryptography.HashAlgorithm
            {
                static /*0x11ad1a4*/ Mono.Security.Cryptography.MD4 Create();
                /*0x11b1ae4*/ MD4();
            }

            class MD4Managed : Mono.Security.Cryptography.MD4
            {
                /*0x28*/ uint[] state;
                /*0x30*/ byte[] buffer;
                /*0x38*/ uint[] count;
                /*0x40*/ uint[] x;
                /*0x48*/ byte[] digest;

                /*0x11b1b04*/ MD4Managed();
                /*0x11b1bd4*/ void Initialize();
                /*0x11b1c88*/ void HashCore(byte[] array, int ibStart, int cbSize);
                /*0x11b2424*/ byte[] HashFinal();
                /*0x11b2618*/ byte[] Padding(int nLength);
                /*0x11b2690*/ uint F(uint x, uint y, uint z);
                /*0x11b26a0*/ uint G(uint x, uint y, uint z);
                /*0x11b26b4*/ uint H(uint x, uint y, uint z);
                /*0x11b26c0*/ uint ROL(uint x, byte n);
                /*0x11b26d0*/ void FF(ref uint a, uint b, uint c, uint d, uint x, byte s);
                /*0x11b26fc*/ void GG(ref uint a, uint b, uint c, uint d, uint x, byte s);
                /*0x11b2738*/ void HH(ref uint a, uint b, uint c, uint d, uint x, byte s);
                /*0x11b2520*/ void Encode(byte[] output, uint[] input);
                /*0x11b276c*/ void Decode(uint[] output, byte[] input, int index);
                /*0x11b1dac*/ void MD4Transform(uint[] state, byte[] block, int index);
            }

            class PKCS1
            {
                static /*0x0*/ byte[] emptySHA1;
                static /*0x8*/ byte[] emptySHA256;
                static /*0x10*/ byte[] emptySHA384;
                static /*0x18*/ byte[] emptySHA512;

                static /*0x11b372c*/ PKCS1();
                static /*0x11b2820*/ bool Compare(byte[] array1, byte[] array2);
                static /*0x11b2894*/ byte[] I2OSP(byte[] x, int size);
                static /*0x11b2920*/ byte[] OS2IP(byte[] x);
                static /*0x11b29dc*/ byte[] RSAVP1(System.Security.Cryptography.RSA rsa, byte[] s);
                static /*0x11b29fc*/ bool Verify_v15(System.Security.Cryptography.RSA rsa, System.Security.Cryptography.HashAlgorithm hash, byte[] hashValue, byte[] signature, bool tryNonStandardEncoding);
                static /*0x11b2be0*/ byte[] Encode_v15(System.Security.Cryptography.HashAlgorithm hash, byte[] hashValue, int emLength);
                static /*0x11b2f28*/ string HashNameFromOid(string oid, bool throwOnError);
                static /*0x11b32c0*/ System.Security.Cryptography.HashAlgorithm CreateFromOid(string oid);
                static /*0x11b331c*/ System.Security.Cryptography.HashAlgorithm CreateFromName(string name);
            }

            class PKCS8
            {
                class PrivateKeyInfo
                {
                    /*0x10*/ int _version;
                    /*0x18*/ string _algorithm;
                    /*0x20*/ byte[] _key;
                    /*0x28*/ System.Collections.ArrayList _list;

                    static /*0x11b4188*/ byte[] RemoveLeadingZero(byte[] bigInt);
                    static /*0x11b4224*/ byte[] Normalize(byte[] bigInt, int length);
                    static /*0x11b42c4*/ System.Security.Cryptography.RSA DecodeRSA(byte[] keypair);
                    static /*0x11b4694*/ byte[] Encode(System.Security.Cryptography.RSA rsa);
                    static /*0x11b4894*/ System.Security.Cryptography.DSA DecodeDSA(byte[] privateKey, System.Security.Cryptography.DSAParameters dsaParameters);
                    static /*0x11b49c0*/ byte[] Encode(System.Security.Cryptography.DSA dsa);
                    static /*0x11b4a10*/ byte[] Encode(System.Security.Cryptography.AsymmetricAlgorithm aa);
                    /*0x11b387c*/ PrivateKeyInfo();
                    /*0x11b38ec*/ PrivateKeyInfo(byte[] data);
                    /*0x11b3b7c*/ string get_Algorithm();
                    /*0x11b3b84*/ void set_Algorithm(string value);
                    /*0x11b3b8c*/ byte[] get_PrivateKey();
                    /*0x11b3c00*/ void set_PrivateKey(byte[] value);
                    /*0x11b3914*/ void Decode(byte[] data);
                    /*0x11b3cf4*/ byte[] GetBytes();
                }

                class EncryptedPrivateKeyInfo
                {
                    /*0x10*/ string _algorithm;
                    /*0x18*/ byte[] _salt;
                    /*0x20*/ int _iterations;
                    /*0x28*/ byte[] _data;

                    /*0x11b4b38*/ EncryptedPrivateKeyInfo();
                    /*0x11b4b40*/ EncryptedPrivateKeyInfo(byte[] data);
                    /*0x11b4e34*/ string get_Algorithm();
                    /*0x11b4e3c*/ void set_Algorithm(string value);
                    /*0x11b4e44*/ byte[] get_EncryptedData();
                    /*0x11b4eb8*/ void set_EncryptedData(byte[] value);
                    /*0x11b4f40*/ byte[] get_Salt();
                    /*0x11b4ff4*/ int get_IterationCount();
                    /*0x11b4ffc*/ void set_IterationCount(int value);
                    /*0x11b4b6c*/ void Decode(byte[] data);
                    /*0x11b5078*/ byte[] GetBytes();
                }
            }

            class RSAManaged : System.Security.Cryptography.RSA
            {
                /*0x20*/ bool isCRTpossible;
                /*0x21*/ bool keyBlinding;
                /*0x22*/ bool keypairGenerated;
                /*0x23*/ bool m_disposed;
                /*0x28*/ Mono.Math.BigInteger d;
                /*0x30*/ Mono.Math.BigInteger p;
                /*0x38*/ Mono.Math.BigInteger q;
                /*0x40*/ Mono.Math.BigInteger dp;
                /*0x48*/ Mono.Math.BigInteger dq;
                /*0x50*/ Mono.Math.BigInteger qInv;
                /*0x58*/ Mono.Math.BigInteger n;
                /*0x60*/ Mono.Math.BigInteger e;
                /*0x68*/ Mono.Security.Cryptography.RSAManaged.KeyGeneratedEventHandler KeyGenerated;

                /*0x11b5258*/ RSAManaged();
                /*0x11b5260*/ RSAManaged(int keySize);
                /*0x11b5350*/ void Finalize();
                /*0x11b53f0*/ void GenerateKeyPair();
                /*0x11b56a0*/ int get_KeySize();
                /*0x11b5748*/ string get_KeyExchangeAlgorithm();
                /*0x11b5788*/ bool get_PublicOnly();
                /*0x11b5830*/ string get_SignatureAlgorithm();
                /*0x11b5870*/ byte[] DecryptValue(byte[] rgb);
                /*0x11b5ca4*/ byte[] EncryptValue(byte[] rgb);
                /*0x11b5dc0*/ System.Security.Cryptography.RSAParameters ExportParameters(bool includePrivateParameters);
                /*0x11b611c*/ void ImportParameters(System.Security.Cryptography.RSAParameters parameters);
                /*0x11b65f8*/ void Dispose(bool disposing);
                /*0x11b683c*/ string ToXmlString(bool includePrivateParameters);
                /*0x11b5bf0*/ byte[] GetPaddedValue(Mono.Math.BigInteger value, int length);

                class KeyGeneratedEventHandler : System.MulticastDelegate
                {
                    /*0x11b6ec4*/ KeyGeneratedEventHandler(object object, nint method);
                    /*0x11b6ff4*/ void Invoke(object sender, System.EventArgs e);
                }
            }
        }

        namespace Authenticode
        {
            class AuthenticodeBase
            {
                /*0x10*/ byte[] fileblock;
                /*0x18*/ System.IO.Stream fs;
                /*0x20*/ int blockNo;
                /*0x24*/ int blockLength;
                /*0x28*/ int peOffset;
                /*0x2c*/ int dirSecurityOffset;
                /*0x30*/ int dirSecuritySize;
                /*0x34*/ int coffSymbolTableOffset;
                /*0x38*/ bool pe64;

                /*0x11b7008*/ AuthenticodeBase();
                /*0x11b7064*/ int get_PEOffset();
                /*0x11b7164*/ void Open(string filename);
                /*0x11b7224*/ void Open(byte[] rawdata);
                /*0x11b71f8*/ void Close();
                /*0x11b708c*/ void ReadFirstBlock();
                /*0x11b72b0*/ int ProcessFirstBlock();
                /*0x11b74f0*/ byte[] GetSecurityEntry();
                /*0x11b75c0*/ byte[] GetHash(System.Security.Cryptography.HashAlgorithm hash);
            }

            class AuthenticodeDeformatter : Mono.Security.Authenticode.AuthenticodeBase
            {
                /*0x40*/ string filename;
                /*0x48*/ byte[] rawdata;
                /*0x50*/ byte[] hash;
                /*0x58*/ Mono.Security.X509.X509CertificateCollection coll;
                /*0x60*/ Mono.Security.ASN1 signedHash;
                /*0x68*/ System.DateTime timestamp;
                /*0x70*/ Mono.Security.X509.X509Certificate signingCertificate;
                /*0x78*/ int reason;
                /*0x7c*/ bool trustedRoot;
                /*0x7d*/ bool trustedTimestampRoot;
                /*0x80*/ byte[] entry;
                /*0x88*/ Mono.Security.X509.X509Chain signerChain;
                /*0x90*/ Mono.Security.X509.X509Chain timestampChain;

                /*0x11b7a48*/ AuthenticodeDeformatter();
                /*0x11b7acc*/ AuthenticodeDeformatter(byte[] rawData);
                /*0x11b7af4*/ void set_RawData(byte[] value);
                /*0x11b7f54*/ Mono.Security.X509.X509Certificate get_SigningCertificate();
                /*0x11b7c60*/ bool CheckSignature();
                /*0x11b899c*/ bool CompareIssuerSerial(string issuer, byte[] serial, Mono.Security.X509.X509Certificate x509);
                /*0x11b7f5c*/ bool VerifySignature(Mono.Security.PKCS7.SignedData sd, byte[] calculatedMessageDigest, System.Security.Cryptography.HashAlgorithm ha);
                /*0x11b8a90*/ bool VerifyCounterSignature(Mono.Security.PKCS7.SignerInfo cs, byte[] signature);
                /*0x11b7bc4*/ void Reset();
            }
        }
    }

    namespace Math
    {
        class BigInteger
        {
            static /*0x0*/ uint[] smallPrimes;
            static /*0x8*/ System.Security.Cryptography.RandomNumberGenerator rng;
            /*0x10*/ uint length;
            /*0x18*/ uint[] data;

            static /*0x12966fc*/ BigInteger();
            static /*0x1293eb8*/ Mono.Math.BigInteger op_Implicit(uint value);
            static /*0x1293f18*/ Mono.Math.BigInteger op_Implicit(int value);
            static /*0x1293fc8*/ Mono.Math.BigInteger op_Addition(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x12942c8*/ Mono.Math.BigInteger op_Subtraction(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x1294730*/ uint op_Modulus(Mono.Math.BigInteger bi, uint ui);
            static /*0x12947a0*/ Mono.Math.BigInteger op_Modulus(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x1294c20*/ Mono.Math.BigInteger op_Division(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x1294c48*/ Mono.Math.BigInteger op_Multiply(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x1294ef4*/ Mono.Math.BigInteger op_LeftShift(Mono.Math.BigInteger bi1, int shiftVal);
            static /*0x12950c8*/ Mono.Math.BigInteger op_RightShift(Mono.Math.BigInteger bi1, int shiftVal);
            static /*0x1295248*/ System.Security.Cryptography.RandomNumberGenerator get_Rng();
            static /*0x12952f0*/ Mono.Math.BigInteger GenerateRandom(int bits, System.Security.Cryptography.RandomNumberGenerator rng);
            static /*0x1295454*/ Mono.Math.BigInteger GenerateRandom(int bits);
            static /*0x12940a8*/ bool op_Equality(Mono.Math.BigInteger bi1, uint ui);
            static /*0x12957c0*/ bool op_Inequality(Mono.Math.BigInteger bi1, uint ui);
            static /*0x129582c*/ bool op_Equality(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x12958dc*/ bool op_Inequality(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x129598c*/ bool op_GreaterThan(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x12959a4*/ bool op_LessThan(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x12959b8*/ bool op_GreaterThanOrEqual(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x12959d0*/ bool op_LessThanOrEqual(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x1296604*/ Mono.Math.BigInteger GeneratePseudoPrime(int bits);
            /*0x1293994*/ BigInteger(Mono.Math.BigInteger.Sign sign, uint len);
            /*0x1293a08*/ BigInteger(Mono.Math.BigInteger bi);
            /*0x1293ac8*/ BigInteger(Mono.Math.BigInteger bi, uint len);
            /*0x1293b9c*/ BigInteger(byte[] inData);
            /*0x1293e30*/ BigInteger(uint ui);
            /*0x12954b0*/ int BitCount();
            /*0x129551c*/ bool TestBit(int bitNum);
            /*0x12955b4*/ void SetBit(uint bitNum);
            /*0x12955bc*/ void SetBit(uint bitNum, bool value);
            /*0x1295618*/ int LowestSetBit();
            /*0x1295694*/ byte[] GetBytes();
            /*0x12959e8*/ string ToString(uint radix);
            /*0x1295a40*/ string ToString(uint radix, string characterSet);
            /*0x1293dd8*/ void Normalize();
            /*0x1295cd0*/ void Clear();
            /*0x1295d20*/ int GetHashCode();
            /*0x1295d78*/ string ToString();
            /*0x1295d80*/ bool Equals(object o);
            /*0x1295ec0*/ Mono.Math.BigInteger ModInverse(Mono.Math.BigInteger modulus);
            /*0x12963b4*/ Mono.Math.BigInteger ModPow(Mono.Math.BigInteger exp, Mono.Math.BigInteger n);
            /*0x1296678*/ void Incr2();

            enum Sign
            {
                Negative = -1,
                Zero = 0,
                Positive = 1,
            }

            class ModulusRing
            {
                /*0x10*/ Mono.Math.BigInteger mod;
                /*0x18*/ Mono.Math.BigInteger constant;

                /*0x129642c*/ ModulusRing(Mono.Math.BigInteger modulus);
                /*0x1296790*/ void BarrettReduction(Mono.Math.BigInteger x);
                /*0x1296d94*/ Mono.Math.BigInteger Multiply(Mono.Math.BigInteger a, Mono.Math.BigInteger b);
                /*0x1296f10*/ Mono.Math.BigInteger Difference(Mono.Math.BigInteger a, Mono.Math.BigInteger b);
                /*0x12964fc*/ Mono.Math.BigInteger Pow(Mono.Math.BigInteger a, Mono.Math.BigInteger k);
                /*0x12970cc*/ Mono.Math.BigInteger Pow(uint b, Mono.Math.BigInteger exp);
            }

            class Kernel
            {
                static /*0x1294114*/ Mono.Math.BigInteger AddSameSign(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
                static /*0x129458c*/ Mono.Math.BigInteger Subtract(Mono.Math.BigInteger big, Mono.Math.BigInteger small);
                static /*0x1296b1c*/ void MinusEq(Mono.Math.BigInteger big, Mono.Math.BigInteger small);
                static /*0x1296c1c*/ void PlusEq(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
                static /*0x1294448*/ Mono.Math.BigInteger.Sign Compare(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
                static /*0x1295c54*/ uint SingleByteDivideInPlace(Mono.Math.BigInteger n, uint d);
                static /*0x1294734*/ uint DwordMod(Mono.Math.BigInteger n, uint d);
                static /*0x1297144*/ Mono.Math.BigInteger[] DwordDivMod(Mono.Math.BigInteger n, uint d);
                static /*0x12947cc*/ Mono.Math.BigInteger[] multiByteDivide(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
                static /*0x1294ef8*/ Mono.Math.BigInteger LeftShift(Mono.Math.BigInteger bi, int n);
                static /*0x12950cc*/ Mono.Math.BigInteger RightShift(Mono.Math.BigInteger bi, int n);
                static /*0x1294df8*/ void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset);
                static /*0x12969ec*/ void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod);
                static /*0x12972d4*/ uint modInverse(Mono.Math.BigInteger bi, uint modulus);
                static /*0x1295ec4*/ Mono.Math.BigInteger modInverse(Mono.Math.BigInteger bi, Mono.Math.BigInteger modulus);
            }
        }

        namespace Prime
        {
            enum ConfidenceFactor
            {
                ExtraLow = 0,
                Low = 1,
                Medium = 2,
                High = 3,
                ExtraHigh = 4,
                Provable = 5,
            }

            class PrimalityTest : System.MulticastDelegate
            {
                /*0x1297394*/ PrimalityTest(object object, nint method);
                /*0x12974c4*/ bool Invoke(Mono.Math.BigInteger bi, Mono.Math.Prime.ConfidenceFactor confidence);
            }

            class PrimalityTests
            {
                static /*0x12974d8*/ int GetSPPRounds(Mono.Math.BigInteger bi, Mono.Math.Prime.ConfidenceFactor confidence);
                static /*0x129766c*/ bool RabinMillerTest(Mono.Math.BigInteger n, Mono.Math.Prime.ConfidenceFactor confidence);
            }

            namespace Generator
            {
                class PrimeGeneratorBase
                {
                    /*0x1297980*/ PrimeGeneratorBase();
                    /*0x12978fc*/ Mono.Math.Prime.ConfidenceFactor get_Confidence();
                    /*0x1297904*/ Mono.Math.Prime.PrimalityTest get_PrimalityTest();
                    /*0x1297978*/ int get_TrialDivisionBounds();
                    Mono.Math.BigInteger GenerateNewPrime(int bits);
                }

                class SequentialSearchPrimeGeneratorBase : Mono.Math.Prime.Generator.PrimeGeneratorBase
                {
                    /*0x1296670*/ SequentialSearchPrimeGeneratorBase();
                    /*0x1297988*/ Mono.Math.BigInteger GenerateSearchBase(int bits, object context);
                    /*0x12979fc*/ Mono.Math.BigInteger GenerateNewPrime(int bits);
                    /*0x1297a0c*/ Mono.Math.BigInteger GenerateNewPrime(int bits, object context);
                    /*0x1297cf0*/ bool IsPrimeAcceptable(Mono.Math.BigInteger bi, object context);
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 001D686DB504E20C792EAA07FE09224A45FF328E24A80072D04D16ABC5C2B5D2;
    static /*0x40*/ <PrivateImplementationDetails> 25E3E48132FBDBE9B7C0C6C54D7C10A5DE12A105AA3E5DE2A0DC808BF245B7A5;
    static /*0xc80*/ long 290C4A052C215D096172EB81AEE671FB3286E5C1DB5E73F96021FC09825DDB88;
    static /*0xc88*/ <PrivateImplementationDetails> 32D0830B8EE1D49A66F395C8EA80E02BFC07C2A12A8EA8C8B484AF02108A1950;
    static /*0xc8b*/ <PrivateImplementationDetails> 35BF50EEF3270FD8CA09E66FC5B0481C5A151B14F6A634854E32F63633D49DCB;
    static /*0xc8e*/ <PrivateImplementationDetails> 3C0C410618682C4DF0474E034114CC8E562F05A512B521AC367571017BDFA75D;
    static /*0xc91*/ <PrivateImplementationDetails> 44F5B1A2C48314502ACCBF186D1A2F9F7F176825898F32F1A2047B956194F174;
    static /*0xc94*/ <PrivateImplementationDetails> 4800FBFC4566EB02D1727A4B1C949CCBC7535C216A0766564C199308631B5DD6;
    static /*0xcc4*/ <PrivateImplementationDetails> 533B8C444F951E83EFF7305E3807B66CE0005DE0A2D0A44873C130895A3BE6AA;
    static /*0xcd8*/ <PrivateImplementationDetails> 55D0BF716B334D123E0088CFB3F8E2FEA17AF5025BB527F95EEB09BA978EA329;
    static /*0xdd8*/ <PrivateImplementationDetails> 59BE5A634187B8A57216EFF5371A47732C05744B1C1A0A6382A6D5622C9FFDCE;
    static /*0xddb*/ <PrivateImplementationDetails> 5DF6E0E2761359D30A8275058E299FCC0381534545F55CF43E41983F5D4C9456;
    static /*0xdfb*/ <PrivateImplementationDetails> 5F8C6B3C66B972606D85E7651F67ADBD02E8316876884674E8328FA710747E5B;
    static /*0xdfe*/ <PrivateImplementationDetails> 60C6ED13AF98DBFEEDA8F8197FFFCC349BB04395CC81DF0D477CBC57BF5B398B;
    static /*0xe08*/ <PrivateImplementationDetails> 64B3E7D737AFF47D4C3BBD81D2D06D697DDD8EB60F29E13E4425D19D8BBCA1F7;
    static /*0xe18*/ long 6772A9B8BF207A3CFE6EE68769D6985B69522183F24A2A3D41BC3B4602953426;
    static /*0xe20*/ <PrivateImplementationDetails> 684312AFB7719E57993D2826FFBAF7EA965614F20F91D999FB19B01E21AA62E6;
    static /*0xe29*/ <PrivateImplementationDetails> 6AA56C4BCD208911792AD24C7681FEFB93BED51903AFC54860C9BD37E41E5A31;
    static /*0xe69*/ <PrivateImplementationDetails> 796E63069E193A008CB4E85573AA1FE53C5F4E58B42A7F61FD0EEE1D89B5120B;
    static /*0xe6c*/ <PrivateImplementationDetails> 7C8975E1E60A5C8337F28EDF8C33C3B180360B7279644A9BC1AF3C51E6220BF5;
    static /*0xeac*/ <PrivateImplementationDetails> 850D7367E4FB0766E2CBC3ACF5AB42B4E98348E58E5A789845D4FCCDB63D2AEE;
    static /*0xeb0*/ long 992F16C986809AB68C7466CC3EC6F12B2506A962EA539753E5D84A2FB7FF8A24;
    static /*0xeb8*/ <PrivateImplementationDetails> 9A65C09A11757751BFED67A414E00B188DC4C7757FCB6CBD33A916DDE4A3D925;
    static /*0xebb*/ <PrivateImplementationDetails> 9ACEFCC0C950280B64AB9E045E38C34ABF71EC70A0DC61B9C621C6BFB4F78047;
    static /*0xecd*/ <PrivateImplementationDetails> B1E34F4A11EE411B83415EF0B252A0B2BBCFCAC2E592865E09C12E4252C93A75;
    static /*0xed0*/ <PrivateImplementationDetails> C92FAD7F348A682E7D5B7E74C76B5D019174EE7BC87545B25A1FDD49FBCC2D0B;
    static /*0xed3*/ <PrivateImplementationDetails> E17B8359E685992B0DE6242AAA24FCB7404173CBB7FF8646FF7D658139F41B5F;
    static /*0xed6*/ <PrivateImplementationDetails> F83B332BE4E6A5A4B1C56AAF6DB52657DA495E149870057D8590AB9D7A6167AD;
    static /*0xf16*/ <PrivateImplementationDetails> FB6D7301FFDCB5FBA5807A19B4F0606947897C1105240B6BBA815352DBBE2064;

    static /*0x1297cf8*/ uint ComputeStringHash(string s);

    struct __StaticArrayInitTypeSize=3
    {
    }

    struct __StaticArrayInitTypeSize=9
    {
    }

    struct __StaticArrayInitTypeSize=10
    {
    }

    struct __StaticArrayInitTypeSize=18
    {
    }

    struct __StaticArrayInitTypeSize=20
    {
    }

    struct __StaticArrayInitTypeSize=32
    {
    }

    struct __StaticArrayInitTypeSize=48
    {
    }

    struct __StaticArrayInitTypeSize=64
    {
    }

    struct __StaticArrayInitTypeSize=256
    {
    }

    struct __StaticArrayInitTypeSize=3132
    {
    }
}
