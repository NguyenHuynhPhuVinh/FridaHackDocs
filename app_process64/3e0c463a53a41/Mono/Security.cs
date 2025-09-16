class <Module>
{
}

class Locale
{
    static /*0x6fdf144*/ string GetText(string msg);
    static /*0x6fdf148*/ string GetText(string fmt, object[] args);
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

            /*0x6fdf150*/ ASN1(byte tag);
            /*0x6fdf184*/ ASN1(byte tag, byte[] data);
            /*0x6fdf1bc*/ ASN1(byte[] data);
            /*0x6fdf468*/ int get_Count();
            /*0x6fdf484*/ byte get_Tag();
            /*0x6fdf48c*/ int get_Length();
            /*0x6fdf4a4*/ byte[] get_Value();
            /*0x6fdf534*/ void set_Value(byte[] value);
            /*0x6fdf5f0*/ bool CompareArray(byte[] array1, byte[] array2);
            /*0x6fdf678*/ bool CompareValue(byte[] value);
            /*0x6fdf688*/ Mono.Security.ASN1 Add(Mono.Security.ASN1 asn1);
            /*0x6fdf720*/ byte[] GetBytes();
            /*0x6fdf33c*/ void Decode(byte[] asn1, ref int anPos, int anLength);
            /*0x6fdfdb0*/ void DecodeTLV(byte[] asn1, ref int pos, ref byte tag, ref int length, ref byte[] content);
            /*0x6fdfee0*/ Mono.Security.ASN1 get_Item(int index);
            /*0x6fe0010*/ Mono.Security.ASN1 Element(int index, byte anTag);
            /*0x6fe0164*/ string ToString();
        }

        class ASN1Convert
        {
            static /*0x6fe03ec*/ Mono.Security.ASN1 FromInt32(int value);
            static /*0x6fe057c*/ Mono.Security.ASN1 FromOid(string oid);
            static /*0x6fe0658*/ Mono.Security.ASN1 FromUnsignedBigInteger(byte[] big);
            static /*0x6fe0774*/ int ToInt32(Mono.Security.ASN1 asn1);
            static /*0x6fe0884*/ string ToOid(Mono.Security.ASN1 asn1);
            static /*0x6fe0b0c*/ System.DateTime ToDateTime(Mono.Security.ASN1 time);
        }

        class BitConverterLE
        {
            static /*0x6fe10c4*/ byte[] GetUIntBytes(byte* bytes);
            static /*0x6fe115c*/ byte[] GetULongBytes(byte* bytes);
            static /*0x6fe0564*/ byte[] GetBytes(int value);
            static /*0x6fe1234*/ byte[] GetBytes(long value);
            static /*0x6fe124c*/ void UShortFromBytes(byte* dst, byte[] src, int startIndex);
            static /*0x6fe1298*/ void UIntFromBytes(byte* dst, byte[] src, int startIndex);
            static /*0x6fe131c*/ int ToInt32(byte[] value, int startIndex);
            static /*0x6fe1340*/ ushort ToUInt16(byte[] value, int startIndex);
            static /*0x6fe1364*/ uint ToUInt32(byte[] value, int startIndex);
        }

        class PKCS7
        {
            class ContentInfo
            {
                /*0x10*/ string contentType;
                /*0x18*/ Mono.Security.ASN1 content;

                /*0x6fe1388*/ ContentInfo();
                /*0x6fe140c*/ ContentInfo(string oid);
                /*0x6fe1438*/ ContentInfo(byte[] data);
                /*0x6fe14a0*/ ContentInfo(Mono.Security.ASN1 asn1);
                /*0x6fe163c*/ Mono.Security.ASN1 get_ASN1();
                /*0x6fe16f8*/ Mono.Security.ASN1 get_Content();
                /*0x6fe1700*/ void set_Content(Mono.Security.ASN1 value);
                /*0x6fe1708*/ string get_ContentType();
                /*0x6fe1710*/ void set_ContentType(string value);
                /*0x6fe1640*/ Mono.Security.ASN1 GetASN1();
            }

            class EncryptedData
            {
                /*0x10*/ byte _version;
                /*0x18*/ Mono.Security.PKCS7.ContentInfo _content;
                /*0x20*/ Mono.Security.PKCS7.ContentInfo _encryptionAlgorithm;
                /*0x28*/ byte[] _encrypted;

                /*0x6fe1718*/ EncryptedData();
                /*0x6fe1734*/ EncryptedData(Mono.Security.ASN1 asn1);
                /*0x6fe1a3c*/ Mono.Security.PKCS7.ContentInfo get_EncryptionAlgorithm();
                /*0x6fe1a44*/ byte[] get_EncryptedContent();
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

                /*0x6fe1ab8*/ SignedData(Mono.Security.ASN1 asn1);
                /*0x6fe27fc*/ Mono.Security.X509.X509CertificateCollection get_Certificates();
                /*0x6fe2804*/ Mono.Security.PKCS7.ContentInfo get_ContentInfo();
                /*0x6fe27c0*/ void set_HashName(string value);
                /*0x6fe280c*/ Mono.Security.PKCS7.SignerInfo get_SignerInfo();
                /*0x6fe260c*/ string OidToName(string oid);
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

                /*0x6fe2574*/ SignerInfo();
                /*0x6fe21cc*/ SignerInfo(Mono.Security.ASN1 asn1);
                /*0x6fe2950*/ string get_IssuerName();
                /*0x6fe2958*/ byte[] get_SerialNumber();
                /*0x6fe29cc*/ System.Collections.ArrayList get_AuthenticatedAttributes();
                /*0x6fe29d4*/ string get_HashName();
                /*0x6fe29dc*/ void set_HashName(string value);
                /*0x6fe29e4*/ byte[] get_Signature();
                /*0x6fe2a58*/ System.Collections.ArrayList get_UnauthenticatedAttributes();
                /*0x6fe2a60*/ byte get_Version();
            }
        }

        namespace X509
        {
            class SafeBag
            {
                /*0x10*/ string _bagOID;
                /*0x18*/ Mono.Security.ASN1 _asn1;

                /*0x6fe2a68*/ SafeBag(string bagOID, Mono.Security.ASN1 asn1);
                /*0x6fe2aac*/ string get_BagOID();
                /*0x6fe2ab4*/ Mono.Security.ASN1 get_ASN1();
            }

            class PKCS12 : System.ICloneable
            {
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

                static /*0x6fe9ba0*/ PKCS12();
                static /*0x6fe9b48*/ int get_MaximumPasswordLength();
                /*0x6fe2abc*/ PKCS12();
                /*0x6fe2bc0*/ PKCS12(byte[] data);
                /*0x6fe3478*/ PKCS12(byte[] data, string password);
                /*0x6fe2de4*/ void Decode(byte[] data);
                /*0x6fe3df0*/ void Finalize();
                /*0x6fe2bf4*/ void set_Password(string value);
                /*0x6fe3eb0*/ int get_IterationCount();
                /*0x6fe3eb8*/ void set_IterationCount(int value);
                /*0x6fe3ec0*/ System.Collections.ArrayList get_Keys();
                /*0x6fe4774*/ Mono.Security.X509.X509CertificateCollection get_Certificates();
                /*0x6fe4bb4*/ System.Security.Cryptography.RandomNumberGenerator get_RNG();
                /*0x6fe360c*/ bool Compare(byte[] expected, byte[] actual);
                /*0x6fe4be4*/ System.Security.Cryptography.SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount);
                /*0x6fe45c4*/ byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData);
                /*0x6fe3d60*/ byte[] Decrypt(Mono.Security.PKCS7.EncryptedData ed);
                /*0x6fe53e8*/ byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data);
                /*0x6fe5638*/ System.Security.Cryptography.DSAParameters GetExistingParameters(ref bool found);
                /*0x6fe5d9c*/ void AddPrivateKey(Mono.Security.Cryptography.PKCS8.PrivateKeyInfo pki);
                /*0x6fe3694*/ void ReadSafeBag(Mono.Security.ASN1 safeBag);
                /*0x6fe6004*/ Mono.Security.ASN1 CertificateSafeBag(Mono.Security.X509.X509Certificate x509, System.Collections.IDictionary attributes);
                /*0x6fe34b0*/ byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data);
                /*0x6fe6cc4*/ byte[] GetBytes();
                /*0x6fe8fdc*/ Mono.Security.PKCS7.ContentInfo EncryptedContentInfo(Mono.Security.ASN1 safeBags, string algorithmOid);
                /*0x6fe8fd4*/ void AddCertificate(Mono.Security.X509.X509Certificate cert);
                /*0x6fe932c*/ void AddCertificate(Mono.Security.X509.X509Certificate cert, System.Collections.IDictionary attributes);
                /*0x6fe8fcc*/ void RemoveCertificate(Mono.Security.X509.X509Certificate cert);
                /*0x6fe9574*/ void RemoveCertificate(Mono.Security.X509.X509Certificate cert, System.Collections.IDictionary attrs);
                /*0x6fe9a80*/ object Clone();

                class DeriveBytes
                {
                    static /*0x0*/ byte[] keyDiversifier;
                    static /*0x8*/ byte[] ivDiversifier;
                    static /*0x10*/ byte[] macDiversifier;
                    /*0x10*/ string _hashName;
                    /*0x18*/ int _iterations;
                    /*0x20*/ byte[] _password;
                    /*0x28*/ byte[] _salt;

                    static /*0x6fea0ec*/ DeriveBytes();
                    /*0x6fe5180*/ DeriveBytes();
                    /*0x6fe9bec*/ void set_HashName(string value);
                    /*0x6fe9bf4*/ void set_IterationCount(int value);
                    /*0x6fe5188*/ void set_Password(byte[] value);
                    /*0x6fe524c*/ void set_Salt(byte[] value);
                    /*0x6fe9bfc*/ void Adjust(byte[] a, int aOff, byte[] b);
                    /*0x6fe9cbc*/ byte[] Derive(byte[] diversifier, int n);
                    /*0x6fe5308*/ byte[] DeriveKey(int size);
                    /*0x6fe5378*/ byte[] DeriveIV(int size);
                    /*0x6fe6c54*/ byte[] DeriveMAC(int size);
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

                static /*0x6feaba4*/ X501();
                static /*0x6fe2814*/ string ToString(Mono.Security.ASN1 seq);
                static /*0x6fea9e4*/ string ToString(Mono.Security.ASN1 seq, bool reversed, string separator, bool quotes);
                static /*0x6fea21c*/ void AppendEntry(System.Text.StringBuilder sb, Mono.Security.ASN1 entry, bool quotes);
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

                /*0x6feb058*/ X509Crl(byte[] crl);
                /*0x6feb174*/ void Parse(byte[] crl);
                /*0x6feba50*/ Mono.Security.X509.X509ExtensionCollection get_Extensions();
                /*0x6feba58*/ byte[] get_Hash();
                /*0x6febc80*/ string get_IssuerName();
                /*0x6febc88*/ System.DateTime get_NextUpdate();
                /*0x6febc90*/ bool Compare(byte[] array1, byte[] array2);
                /*0x6febd20*/ Mono.Security.X509.X509Crl.X509CrlEntry GetCrlEntry(Mono.Security.X509.X509Certificate x509);
                /*0x6febd9c*/ Mono.Security.X509.X509Crl.X509CrlEntry GetCrlEntry(byte[] serialNumber);
                /*0x6febf58*/ bool VerifySignature(System.Security.Cryptography.DSA dsa);
                /*0x6fec21c*/ bool VerifySignature(System.Security.Cryptography.RSA rsa);
                /*0x6fec2f0*/ bool VerifySignature(System.Security.Cryptography.AsymmetricAlgorithm aa);

                class X509CrlEntry
                {
                    /*0x10*/ byte[] sn;
                    /*0x18*/ System.DateTime revocationDate;
                    /*0x20*/ Mono.Security.X509.X509ExtensionCollection extensions;

                    /*0x6feb82c*/ X509CrlEntry(Mono.Security.ASN1 entry);
                    /*0x6febee0*/ byte[] get_SerialNumber();
                    /*0x6fec464*/ System.DateTime get_RevocationDate();
                    /*0x6fec46c*/ Mono.Security.X509.X509ExtensionCollection get_Extensions();
                }
            }

            class X509Certificate : System.Runtime.Serialization.ISerializable
            {
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

                static /*0x6fee140*/ X509Certificate();
                static /*0x6fece4c*/ byte[] PEM(string type, byte[] data);
                /*0x6fe1fd0*/ X509Certificate(byte[] data);
                /*0x6fec474*/ void Parse(byte[] data);
                /*0x6fecf80*/ byte[] GetUnsignedBigInteger(byte[] integer);
                /*0x6fe5a08*/ System.Security.Cryptography.DSA get_DSA();
                /*0x6fed014*/ void set_DSA(System.Security.Cryptography.DSA value);
                /*0x6fed054*/ Mono.Security.X509.X509ExtensionCollection get_Extensions();
                /*0x6fed05c*/ byte[] get_Hash();
                /*0x6fed304*/ string get_IssuerName();
                /*0x6fed30c*/ string get_KeyAlgorithm();
                /*0x6fed314*/ byte[] get_KeyAlgorithmParameters();
                /*0x6fed388*/ void set_KeyAlgorithmParameters(byte[] value);
                /*0x6fed390*/ byte[] get_PublicKey();
                /*0x6fed404*/ System.Security.Cryptography.RSA get_RSA();
                /*0x6fed5c8*/ void set_RSA(System.Security.Cryptography.RSA value);
                /*0x6fed604*/ byte[] get_RawData();
                /*0x6fed678*/ byte[] get_SerialNumber();
                /*0x6fed6ec*/ byte[] get_Signature();
                /*0x6fedb20*/ string get_SubjectName();
                /*0x6fedb28*/ System.DateTime get_ValidFrom();
                /*0x6fedb30*/ System.DateTime get_ValidUntil();
                /*0x6fedb38*/ int get_Version();
                /*0x6fedb40*/ bool get_IsCurrent();
                /*0x6fedba0*/ bool WasCurrent(System.DateTime instant);
                /*0x6fedc78*/ bool VerifySignature(System.Security.Cryptography.DSA dsa);
                /*0x6fedd40*/ bool VerifySignature(System.Security.Cryptography.RSA rsa);
                /*0x6fede68*/ bool VerifySignature(System.Security.Cryptography.AsymmetricAlgorithm aa);
                /*0x6fedfdc*/ bool get_IsSelfSigned();
                /*0x6fee0e4*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            class X509CertificateCollection : System.Collections.CollectionBase, System.Collections.IEnumerable
            {
                /*0x6fe1fc8*/ X509CertificateCollection();
                /*0x6fee1a8*/ Mono.Security.X509.X509Certificate get_Item(int index);
                /*0x6fe215c*/ int Add(Mono.Security.X509.X509Certificate value);
                /*0x6fee240*/ void AddRange(Mono.Security.X509.X509CertificateCollection value);
                /*0x6fee310*/ bool Contains(Mono.Security.X509.X509Certificate value);
                /*0x6fe58c0*/ Mono.Security.X509.X509CertificateCollection.X509CertificateEnumerator GetEnumerator();
                /*0x6fee52c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x6fee550*/ int GetHashCode();
                /*0x6fee328*/ int IndexOf(Mono.Security.X509.X509Certificate value);
                /*0x6fee570*/ bool Compare(byte[] array1, byte[] array2);

                class X509CertificateEnumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ System.Collections.IEnumerator enumerator;

                    /*0x6fee470*/ X509CertificateEnumerator(Mono.Security.X509.X509CertificateCollection mappings);
                    /*0x6fe5918*/ Mono.Security.X509.X509Certificate get_Current();
                    /*0x6fee600*/ object System.Collections.IEnumerator.get_Current();
                    /*0x6fee6a4*/ bool System.Collections.IEnumerator.MoveNext();
                    /*0x6fee744*/ void System.Collections.IEnumerator.Reset();
                    /*0x6fe5cfc*/ bool MoveNext();
                }
            }

            class X509Chain
            {
                /*0x10*/ Mono.Security.X509.X509CertificateCollection roots;
                /*0x18*/ Mono.Security.X509.X509CertificateCollection certs;
                /*0x20*/ Mono.Security.X509.X509Certificate _root;
                /*0x28*/ Mono.Security.X509.X509CertificateCollection _chain;
                /*0x30*/ Mono.Security.X509.X509ChainStatusFlags _status;

                /*0x6fee7e8*/ X509Chain();
                /*0x6fee854*/ Mono.Security.X509.X509CertificateCollection get_TrustAnchors();
                /*0x6fee97c*/ void LoadCertificates(Mono.Security.X509.X509CertificateCollection collection);
                /*0x6fee994*/ bool Build(Mono.Security.X509.X509Certificate leaf);
                /*0x6fef370*/ void Reset();
                /*0x6fef2c4*/ bool IsValid(Mono.Security.X509.X509Certificate cert);
                /*0x6feed5c*/ Mono.Security.X509.X509Certificate FindCertificateParent(Mono.Security.X509.X509Certificate child);
                /*0x6feef38*/ Mono.Security.X509.X509Certificate FindCertificateRoot(Mono.Security.X509.X509Certificate potentialRoot);
                /*0x6fef3cc*/ bool IsTrusted(Mono.Security.X509.X509Certificate potentialTrusted);
                /*0x6fef180*/ bool IsParent(Mono.Security.X509.X509Certificate child, Mono.Security.X509.X509Certificate parent);
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

                /*0x6fef4ac*/ X509Extension(Mono.Security.ASN1 asn1);
                /*0x6fef78c*/ X509Extension(Mono.Security.X509.X509Extension extension);
                /*0x6fef90c*/ void Decode();
                /*0x6fef910*/ void Encode();
                /*0x6fef914*/ string get_Oid();
                /*0x6fef91c*/ bool get_Critical();
                /*0x6fef8e0*/ Mono.Security.ASN1 get_Value();
                /*0x6fef924*/ bool Equals(object obj);
                /*0x6fefa74*/ int GetHashCode();
                /*0x6fefa94*/ void WriteLine(System.Text.StringBuilder sb, int n, int pos);
                /*0x6fefcbc*/ string ToString();
            }

            class X509ExtensionCollection : System.Collections.CollectionBase, System.Collections.IEnumerable
            {
                /*0x18*/ bool readOnly;

                /*0x6fefd94*/ X509ExtensionCollection();
                /*0x6feb91c*/ X509ExtensionCollection(Mono.Security.ASN1 asn1);
                /*0x6fefd9c*/ int IndexOf(string oid);
                /*0x6fefed4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x6fef3f8*/ Mono.Security.X509.X509Extension get_Item(string oid);
            }

            class X509Store
            {
                /*0x10*/ string _storePath;
                /*0x18*/ Mono.Security.X509.X509CertificateCollection _certificates;
                /*0x20*/ System.Collections.ArrayList _crls;
                /*0x28*/ bool _crl;
                /*0x29*/ bool _newFormat;

                /*0x6fefef8*/ X509Store(string path, bool crl, bool newFormat);
                /*0x6feff44*/ Mono.Security.X509.X509CertificateCollection get_Certificates();
                /*0x6ff0160*/ System.Collections.ArrayList get_Crls();
                /*0x6ff03bc*/ byte[] Load(string filename);
                /*0x6ff05c4*/ Mono.Security.X509.X509Certificate LoadCertificate(string filename);
                /*0x6ff062c*/ Mono.Security.X509.X509Crl LoadCrl(string filename);
                /*0x6ff0694*/ bool CheckStore(string path, bool throwException);
                /*0x6feff88*/ Mono.Security.X509.X509CertificateCollection BuildCertificatesCollection(string storeName);
                /*0x6ff01f8*/ System.Collections.ArrayList BuildCrlsCollection(string storeName);
            }

            class X509StoreManager
            {
                static /*0x0*/ string _userPath;
                static /*0x8*/ string _localMachinePath;
                static /*0x10*/ Mono.Security.X509.X509Stores _userStore;
                static /*0x18*/ Mono.Security.X509.X509Stores _machineStore;

                static /*0x6ff0770*/ string get_CurrentUserPath();
                static /*0x6ff0888*/ string get_LocalMachinePath();
                static /*0x6ff0998*/ Mono.Security.X509.X509Stores get_CurrentUser();
                static /*0x6ff0a88*/ Mono.Security.X509.X509Stores get_LocalMachine();
                static /*0x6fee8e0*/ Mono.Security.X509.X509CertificateCollection get_TrustedRootCertificates();
            }

            class X509Stores
            {
                /*0x10*/ string _storePath;
                /*0x18*/ bool _newFormat;
                /*0x20*/ Mono.Security.X509.X509Store _trusted;

                /*0x6ff0a4c*/ X509Stores(string path, bool newFormat);
                /*0x6ff0b3c*/ Mono.Security.X509.X509Store get_TrustedRoot();
                /*0x6ff0c2c*/ Mono.Security.X509.X509Store Open(string storeName, bool create);
            }

            namespace Extensions
            {
                class AuthorityKeyIdentifierExtension : Mono.Security.X509.X509Extension
                {
                    /*0x28*/ byte[] aki;

                    /*0x6ff0d4c*/ AuthorityKeyIdentifierExtension(Mono.Security.X509.X509Extension extension);
                    /*0x6ff0d50*/ void Decode();
                    /*0x6ff0e74*/ void Encode();
                    /*0x6ff0fbc*/ byte[] get_Identifier();
                    /*0x6ff1030*/ string ToString();
                }

                class BasicConstraintsExtension : Mono.Security.X509.X509Extension
                {
                    /*0x28*/ bool cA;
                    /*0x2c*/ int pathLenConstraint;

                    /*0x6fef4a8*/ BasicConstraintsExtension(Mono.Security.X509.X509Extension extension);
                    /*0x6ff119c*/ void Decode();
                    /*0x6ff12d0*/ void Encode();
                    /*0x6ff142c*/ bool get_CertificateAuthority();
                    /*0x6ff1434*/ string ToString();
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

                    static /*0x6ff2410*/ ChallengeResponse();
                    /*0x6ff15d4*/ ChallengeResponse();
                    /*0x6ff1658*/ ChallengeResponse(string password, byte[] challenge);
                    /*0x6ff1bc8*/ void Finalize();
                    /*0x6ff1690*/ void set_Password(string value);
                    /*0x6ff1a98*/ void set_Challenge(byte[] value);
                    /*0x6ff1e10*/ byte[] get_LM();
                    /*0x6ff214c*/ byte[] get_NT();
                    /*0x6ff1c68*/ void Dispose();
                    /*0x6ff21ac*/ void Dispose(bool disposing);
                    /*0x6ff1e70*/ byte[] GetResponse(byte[] pwd);
                    /*0x6ff2218*/ byte[] PrepareDESKey(byte[] key56bits, int position);
                    /*0x6ff1ccc*/ byte[] PasswordToKey(string password, int position);
                }

                class ChallengeResponse2
                {
                    static /*0x0*/ byte[] magic;
                    static /*0x8*/ byte[] nullEncMagic;

                    static /*0x6ff3904*/ ChallengeResponse2();
                    static /*0x6ff24f4*/ byte[] Compute_LM(string password, byte[] challenge);
                    static /*0x6ff2c7c*/ byte[] Compute_NTLM_Password(string password);
                    static /*0x6ff2d80*/ byte[] Compute_NTLM(string password, byte[] challenge);
                    static /*0x6ff2dec*/ void Compute_NTLMv2_Session(string password, byte[] challenge, ref byte[] lm, ref byte[] ntlm);
                    static /*0x6ff2fd0*/ byte[] Compute_NTLMv2(Mono.Security.Protocol.Ntlm.Type2Message type2, string username, string password, string domain);
                    static /*0x6ff34f4*/ void Compute(Mono.Security.Protocol.Ntlm.Type2Message type2, Mono.Security.Protocol.Ntlm.NtlmAuthLevel level, string username, string password, string domain, ref byte[] lm, ref byte[] ntlm);
                    static /*0x6ff2988*/ byte[] GetResponse(byte[] challenge, byte[] pwd);
                    static /*0x6ff370c*/ byte[] PrepareDESKey(byte[] key56bits, int position);
                    static /*0x6ff2820*/ byte[] PasswordToKey(string password, int position);
                }

                class MessageBase
                {
                    static /*0x0*/ byte[] header;
                    /*0x10*/ int _type;
                    /*0x14*/ Mono.Security.Protocol.Ntlm.NtlmFlags _flags;

                    static /*0x6ff3dd4*/ MessageBase();
                    /*0x6ff39e8*/ MessageBase(int messageType);
                    /*0x6ff3a10*/ Mono.Security.Protocol.Ntlm.NtlmFlags get_Flags();
                    /*0x6ff3a18*/ void set_Flags(Mono.Security.Protocol.Ntlm.NtlmFlags value);
                    /*0x6ff3a20*/ int get_Type();
                    /*0x6ff3a28*/ byte[] PrepareMessage(int messageSize);
                    /*0x6ff3b28*/ void Decode(byte[] message);
                    /*0x6ff3cc0*/ bool CheckHeader(byte[] message);
                    /*0x380b9e8*/ byte[] GetBytes();
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

                    static /*0x6ff3ecc*/ NtlmSettings();
                    static /*0x6ff3e74*/ Mono.Security.Protocol.Ntlm.NtlmAuthLevel get_DefaultAuthLevel();
                }

                class Type1Message : Mono.Security.Protocol.Ntlm.MessageBase
                {
                    /*0x18*/ string _host;
                    /*0x20*/ string _domain;

                    /*0x6ff3f18*/ Type1Message();
                    /*0x6ff3fb4*/ void set_Domain(string value);
                    /*0x6ff4040*/ void set_Host(string value);
                    /*0x6ff40cc*/ void Decode(byte[] message);
                    /*0x6ff41d4*/ byte[] GetBytes();
                }

                class Type2Message : Mono.Security.Protocol.Ntlm.MessageBase
                {
                    /*0x18*/ byte[] _nonce;
                    /*0x20*/ string _targetName;
                    /*0x28*/ byte[] _targetInfo;

                    /*0x6ff4420*/ Type2Message(byte[] message);
                    /*0x6ff44d0*/ void Finalize();
                    /*0x6ff347c*/ byte[] get_Nonce();
                    /*0x6ff4578*/ string get_TargetName();
                    /*0x6ff3404*/ byte[] get_TargetInfo();
                    /*0x6ff4580*/ void Decode(byte[] message);
                    /*0x6ff4718*/ byte[] GetBytes();
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

                    /*0x6ff47d0*/ Type3Message(Mono.Security.Protocol.Ntlm.Type2Message type2);
                    /*0x6ff4a14*/ void Finalize();
                    /*0x6ff4af4*/ void set_Domain(string value);
                    /*0x6ff4b80*/ void set_Password(string value);
                    /*0x6ff4b88*/ void set_Username(string value);
                    /*0x6ff4b90*/ void Decode(byte[] message);
                    /*0x6ff4e00*/ string DecodeString(byte[] buffer, int offset, int len);
                    /*0x6ff4e58*/ byte[] EncodeString(string text);
                    /*0x6ff4ee8*/ byte[] GetBytes();
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

                /*0x6ff5528*/ Alert(Mono.Security.Interface.AlertDescription description);
                /*0x6ff5518*/ Mono.Security.Interface.AlertLevel get_Level();
                /*0x6ff5520*/ Mono.Security.Interface.AlertDescription get_Description();
                /*0x6ff5594*/ void inferAlertLevel();
                /*0x6ff55d4*/ string ToString();
            }

            class ValidationResult
            {
                /*0x10*/ bool trusted;
                /*0x11*/ bool user_denied;
                /*0x14*/ int error_code;
                /*0x18*/ System.Nullable<Mono.Security.Interface.MonoSslPolicyErrors> policy_errors;

                /*0x6ff5690*/ ValidationResult(bool trusted, bool user_denied, int error_code, System.Nullable<Mono.Security.Interface.MonoSslPolicyErrors> policy_errors);
                /*0x6ff56d8*/ bool get_Trusted();
                /*0x6ff56e0*/ bool get_UserDenied();
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

                /*0x6ff57cc*/ MonoTlsConnectionInfo();
                /*0x6ff56e8*/ Mono.Security.Interface.CipherSuiteCode get_CipherSuiteCode();
                /*0x6ff56f0*/ void set_CipherSuiteCode(Mono.Security.Interface.CipherSuiteCode value);
                /*0x6ff56f8*/ Mono.Security.Interface.TlsProtocols get_ProtocolVersion();
                /*0x6ff5700*/ void set_ProtocolVersion(Mono.Security.Interface.TlsProtocols value);
                /*0x6ff5708*/ void set_PeerDomainName(string value);
                /*0x6ff5710*/ string ToString();
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
                /*0x6ff57d4*/ MonoRemoteCertificateValidationCallback(object object, nint method);
                /*0x6ff5888*/ bool Invoke(string targetHost, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, Mono.Security.Interface.MonoSslPolicyErrors sslPolicyErrors);
            }

            class MonoLocalCertificateSelectionCallback : System.MulticastDelegate
            {
                /*0x6ff589c*/ MonoLocalCertificateSelectionCallback(object object, nint method);
                /*0x6ff5950*/ System.Security.Cryptography.X509Certificates.X509Certificate Invoke(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers);
            }

            class MonoTlsProvider
            {
                /*0x6ff5964*/ MonoTlsProvider();
                /*0x380b600*/ System.Guid get_ID();
                /*0x380b9e8*/ string get_Name();
                /*0x380b128*/ bool get_SupportsSslStream();
                /*0x380b128*/ bool get_SupportsConnectionInfo();
                /*0x380b128*/ bool get_SupportsMonoExtensions();
                /*0x380b6a0*/ System.Security.Authentication.SslProtocols get_SupportedProtocols();
                /*0x380b128*/ bool get_SupportsCleanShutdown();
            }

            class MonoTlsProviderFactory
            {
                static /*0x6ff596c*/ Mono.Security.Interface.MonoTlsProvider GetProvider();
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

                static /*0x6ff5ac4*/ Mono.Security.Interface.MonoTlsSettings get_DefaultSettings();
                static /*0x6ff5b50*/ Mono.Security.Interface.MonoTlsSettings CopyDefaultSettings();
                /*0x6ff5ab0*/ MonoTlsSettings();
                /*0x6ff5c54*/ MonoTlsSettings(Mono.Security.Interface.MonoTlsSettings other);
                /*0x6ff59dc*/ Mono.Security.Interface.MonoRemoteCertificateValidationCallback get_RemoteCertificateValidationCallback();
                /*0x6ff59e4*/ void set_RemoteCertificateValidationCallback(Mono.Security.Interface.MonoRemoteCertificateValidationCallback value);
                /*0x6ff59ec*/ Mono.Security.Interface.MonoLocalCertificateSelectionCallback get_ClientCertificateSelectionCallback();
                /*0x6ff59f4*/ void set_ClientCertificateSelectionCallback(Mono.Security.Interface.MonoLocalCertificateSelectionCallback value);
                /*0x6ff59fc*/ System.Nullable<bool> get_UseServicePointManagerCallback();
                /*0x6ff5a04*/ void set_UseServicePointManagerCallback(System.Nullable<bool> value);
                /*0x6ff5a0c*/ bool get_CallbackNeedsCertificateChain();
                /*0x6ff5a14*/ System.Nullable<System.DateTime> get_CertificateValidationTime();
                /*0x6ff5a20*/ void set_CertificateValidationTime(System.Nullable<System.DateTime> value);
                /*0x6ff5a28*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_TrustAnchors();
                /*0x6ff5a30*/ void set_TrustAnchors(System.Security.Cryptography.X509Certificates.X509CertificateCollection value);
                /*0x6ff5a38*/ object get_UserSettings();
                /*0x6ff5a40*/ void set_UserSettings(object value);
                /*0x6ff5a48*/ string[] get_CertificateSearchPaths();
                /*0x6ff5a50*/ void set_CertificateSearchPaths(string[] value);
                /*0x6ff5a58*/ bool get_SendCloseNotify();
                /*0x6ff5a60*/ void set_SendCloseNotify(bool value);
                /*0x6ff5a6c*/ string[] get_ClientCertificateIssuers();
                /*0x6ff5a74*/ void set_ClientCertificateIssuers(string[] value);
                /*0x6ff5a7c*/ bool get_DisallowUnauthenticatedCertificateRequest();
                /*0x6ff5a84*/ void set_DisallowUnauthenticatedCertificateRequest(bool value);
                /*0x6ff5a90*/ System.Nullable<Mono.Security.Interface.TlsProtocols> get_EnabledProtocols();
                /*0x6ff5a98*/ void set_EnabledProtocols(System.Nullable<Mono.Security.Interface.TlsProtocols> value);
                /*0x6ff5aa0*/ Mono.Security.Interface.CipherSuiteCode[] get_EnabledCiphers();
                /*0x6ff5aa8*/ void set_EnabledCiphers(Mono.Security.Interface.CipherSuiteCode[] value);
                /*0x6ff5bc0*/ Mono.Security.Interface.ICertificateValidator get_CertificateValidator();
                /*0x6ff5bc8*/ Mono.Security.Interface.MonoTlsSettings CloneWithValidator(Mono.Security.Interface.ICertificateValidator validator);
                /*0x6ff5b68*/ Mono.Security.Interface.MonoTlsSettings Clone();
            }

            class TlsException : System.Exception
            {
                /*0x90*/ Mono.Security.Interface.Alert alert;

                /*0x6ff5de8*/ TlsException(Mono.Security.Interface.Alert alert, string message);
                /*0x6ff5e64*/ TlsException(Mono.Security.Interface.AlertDescription description, string message);
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
                static /*0x6ff5ed8*/ string ToHex(byte[] input);
            }

            class MD2 : System.Security.Cryptography.HashAlgorithm
            {
                static /*0x6ff6034*/ Mono.Security.Cryptography.MD2 Create();
                /*0x6ff6014*/ MD2();
            }

            class MD2Managed : Mono.Security.Cryptography.MD2
            {
                static /*0x0*/ byte[] PI_SUBST;
                /*0x28*/ byte[] state;
                /*0x30*/ byte[] checksum;
                /*0x38*/ byte[] buffer;
                /*0x40*/ int count;
                /*0x48*/ byte[] x;

                static /*0x6ff6684*/ MD2Managed();
                /*0x6ff6084*/ MD2Managed();
                /*0x6ff6158*/ byte[] Padding(int nLength);
                /*0x6ff61f4*/ void Initialize();
                /*0x6ff6254*/ void HashCore(byte[] array, int ibStart, int cbSize);
                /*0x6ff6594*/ byte[] HashFinal();
                /*0x6ff6330*/ void MD2Transform(byte[] state, byte[] checksum, byte[] block, int index);
            }

            class MD4 : System.Security.Cryptography.HashAlgorithm
            {
                static /*0x6ff6744*/ Mono.Security.Cryptography.MD4 Create();
                /*0x6ff6724*/ MD4();
            }

            class MD4Managed : Mono.Security.Cryptography.MD4
            {
                /*0x28*/ uint[] state;
                /*0x30*/ byte[] buffer;
                /*0x38*/ uint[] count;
                /*0x40*/ uint[] x;
                /*0x48*/ byte[] digest;

                /*0x6ff6794*/ MD4Managed();
                /*0x6ff68a0*/ void Initialize();
                /*0x6ff6954*/ void HashCore(byte[] array, int ibStart, int cbSize);
                /*0x6ff70f0*/ byte[] HashFinal();
                /*0x6ff72e4*/ byte[] Padding(int nLength);
                /*0x6ff735c*/ uint F(uint x, uint y, uint z);
                /*0x6ff736c*/ uint G(uint x, uint y, uint z);
                /*0x6ff7380*/ uint H(uint x, uint y, uint z);
                /*0x6ff738c*/ uint ROL(uint x, byte n);
                /*0x6ff7398*/ void FF(ref uint a, uint b, uint c, uint d, uint x, byte s);
                /*0x6ff73c0*/ void GG(ref uint a, uint b, uint c, uint d, uint x, byte s);
                /*0x6ff73f8*/ void HH(ref uint a, uint b, uint c, uint d, uint x, byte s);
                /*0x6ff71ec*/ void Encode(byte[] output, uint[] input);
                /*0x6ff7428*/ void Decode(uint[] output, byte[] input, int index);
                /*0x6ff6a78*/ void MD4Transform(uint[] state, byte[] block, int index);
            }

            class PKCS1
            {
                static /*0x0*/ byte[] emptySHA1;
                static /*0x8*/ byte[] emptySHA256;
                static /*0x10*/ byte[] emptySHA384;
                static /*0x18*/ byte[] emptySHA512;

                static /*0x6ff8444*/ PKCS1();
                static /*0x6ff74f0*/ bool Compare(byte[] array1, byte[] array2);
                static /*0x6ff757c*/ byte[] I2OSP(byte[] x, int size);
                static /*0x6ff7608*/ byte[] OS2IP(byte[] x);
                static /*0x6ff76c8*/ byte[] RSAVP1(System.Security.Cryptography.RSA rsa, byte[] s);
                static /*0x6ff76e4*/ bool Verify_v15(System.Security.Cryptography.RSA rsa, System.Security.Cryptography.HashAlgorithm hash, byte[] hashValue, byte[] signature, bool tryNonStandardEncoding);
                static /*0x6ff78bc*/ byte[] Encode_v15(System.Security.Cryptography.HashAlgorithm hash, byte[] hashValue, int emLength);
                static /*0x6ff7bf0*/ string HashNameFromOid(string oid, bool throwOnError);
                static /*0x6ff7ff8*/ System.Security.Cryptography.HashAlgorithm CreateFromOid(string oid);
                static /*0x6ff8054*/ System.Security.Cryptography.HashAlgorithm CreateFromName(string name);
            }

            class PKCS8
            {
                class PrivateKeyInfo
                {
                    /*0x10*/ int _version;
                    /*0x18*/ string _algorithm;
                    /*0x20*/ byte[] _key;
                    /*0x28*/ System.Collections.ArrayList _list;

                    static /*0x6ff893c*/ byte[] RemoveLeadingZero(byte[] bigInt);
                    static /*0x6ff89d8*/ byte[] Normalize(byte[] bigInt, int length);
                    static /*0x6ff8a78*/ System.Security.Cryptography.RSA DecodeRSA(byte[] keypair);
                    static /*0x6ff8ed4*/ byte[] Encode(System.Security.Cryptography.RSA rsa);
                    static /*0x6ff90cc*/ System.Security.Cryptography.DSA DecodeDSA(byte[] privateKey, System.Security.Cryptography.DSAParameters dsaParameters);
                    static /*0x6ff9200*/ byte[] Encode(System.Security.Cryptography.DSA dsa);
                    static /*0x6ff924c*/ byte[] Encode(System.Security.Cryptography.AsymmetricAlgorithm aa);
                    /*0x6ff85b8*/ PrivateKeyInfo();
                    /*0x6ff8628*/ PrivateKeyInfo(byte[] data);
                    /*0x6ff88c0*/ string get_Algorithm();
                    /*0x6ff88c8*/ byte[] get_PrivateKey();
                    /*0x6ff8650*/ void Decode(byte[] data);
                }

                class EncryptedPrivateKeyInfo
                {
                    /*0x10*/ string _algorithm;
                    /*0x18*/ byte[] _salt;
                    /*0x20*/ int _iterations;
                    /*0x28*/ byte[] _data;

                    /*0x6ff9370*/ EncryptedPrivateKeyInfo();
                    /*0x6ff9378*/ EncryptedPrivateKeyInfo(byte[] data);
                    /*0x6ff9670*/ string get_Algorithm();
                    /*0x6ff9678*/ byte[] get_EncryptedData();
                    /*0x6ff96ec*/ byte[] get_Salt();
                    /*0x6ff97ac*/ int get_IterationCount();
                    /*0x6ff93a4*/ void Decode(byte[] data);
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

                /*0x6ff97b4*/ RSAManaged();
                /*0x6ff97bc*/ RSAManaged(int keySize);
                /*0x6ff98a4*/ void Finalize();
                /*0x6ff9944*/ void GenerateKeyPair();
                /*0x6ffa238*/ int get_KeySize();
                /*0x6ffa2d4*/ bool get_PublicOnly();
                /*0x6ffa424*/ byte[] EncryptValue(byte[] rgb);
                /*0x6ffa8dc*/ System.Security.Cryptography.RSAParameters ExportParameters(bool includePrivateParameters);
                /*0x6ffad9c*/ void ImportParameters(System.Security.Cryptography.RSAParameters parameters);
                /*0x6ffb2e4*/ void Dispose(bool disposing);
                /*0x6ffb568*/ string ToXmlString(bool includePrivateParameters);
                /*0x6ffa7dc*/ byte[] GetPaddedValue(Mono.Math.BigInteger value, int length);

                class KeyGeneratedEventHandler : System.MulticastDelegate
                {
                    /*0x6ffbbf0*/ KeyGeneratedEventHandler(object object, nint method);
                    /*0x6ffbcfc*/ void Invoke(object sender, System.EventArgs e);
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

                /*0x6ffbd10*/ AuthenticodeBase();
                /*0x6ffbd74*/ int get_PEOffset();
                /*0x6ffbe6c*/ void Open(string filename);
                /*0x6ffbf40*/ void Open(byte[] rawdata);
                /*0x6ffbf04*/ void Close();
                /*0x6ffbd9c*/ void ReadFirstBlock();
                /*0x6ffbfd0*/ int ProcessFirstBlock();
                /*0x6ffc208*/ byte[] GetSecurityEntry();
                /*0x6ffc2d8*/ byte[] GetHash(System.Security.Cryptography.HashAlgorithm hash);
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

                /*0x6ffc760*/ AuthenticodeDeformatter();
                /*0x6ffc7f4*/ AuthenticodeDeformatter(byte[] rawData);
                /*0x6ffc81c*/ void set_RawData(byte[] value);
                /*0x6ffccd4*/ Mono.Security.X509.X509Certificate get_SigningCertificate();
                /*0x6ffc9ec*/ bool CheckSignature();
                /*0x6ffd734*/ bool CompareIssuerSerial(string issuer, byte[] serial, Mono.Security.X509.X509Certificate x509);
                /*0x6ffccdc*/ bool VerifySignature(Mono.Security.PKCS7.SignedData sd, byte[] calculatedMessageDigest, System.Security.Cryptography.HashAlgorithm ha);
                /*0x6ffd830*/ bool VerifyCounterSignature(Mono.Security.PKCS7.SignerInfo cs, byte[] signature);
                /*0x6ffc8f8*/ void Reset();
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

            static /*0x7000438*/ BigInteger();
            static /*0x6ff9c58*/ Mono.Math.BigInteger op_Implicit(uint value);
            static /*0x6ff9ff8*/ Mono.Math.BigInteger op_Implicit(int value);
            static /*0x6ffa09c*/ Mono.Math.BigInteger op_Subtraction(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x6ff9d1c*/ uint op_Modulus(Mono.Math.BigInteger bi, uint ui);
            static /*0x6ffa20c*/ Mono.Math.BigInteger op_Modulus(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x6ffee00*/ Mono.Math.BigInteger op_Division(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x6ff9dd0*/ Mono.Math.BigInteger op_Multiply(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x6ffef24*/ Mono.Math.BigInteger op_LeftShift(Mono.Math.BigInteger bi1, int shiftVal);
            static /*0x6fff10c*/ Mono.Math.BigInteger op_RightShift(Mono.Math.BigInteger bi1, int shiftVal);
            static /*0x6fff288*/ System.Security.Cryptography.RandomNumberGenerator get_Rng();
            static /*0x6fff334*/ Mono.Math.BigInteger GenerateRandom(int bits, System.Security.Cryptography.RandomNumberGenerator rng);
            static /*0x6fff494*/ Mono.Math.BigInteger GenerateRandom(int bits);
            static /*0x6ffe554*/ bool op_Equality(Mono.Math.BigInteger bi1, uint ui);
            static /*0x6fff664*/ bool op_Inequality(Mono.Math.BigInteger bi1, uint ui);
            static /*0x6ffa374*/ bool op_Equality(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x6ff9d20*/ bool op_Inequality(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x6fff6d0*/ bool op_GreaterThan(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x6ff9fe4*/ bool op_LessThan(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x6fff6e8*/ bool op_GreaterThanOrEqual(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x6fff700*/ bool op_LessThanOrEqual(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x6ff9cb0*/ Mono.Math.BigInteger GeneratePseudoPrime(int bits);
            /*0x6ffe21c*/ BigInteger(Mono.Math.BigInteger.Sign sign, uint len);
            /*0x6ffe29c*/ BigInteger(Mono.Math.BigInteger bi);
            /*0x6ffe384*/ BigInteger(Mono.Math.BigInteger bi, uint len);
            /*0x6ffa52c*/ BigInteger(byte[] inData);
            /*0x6ffe4c4*/ BigInteger(uint ui);
            /*0x6ff9f78*/ int BitCount();
            /*0x6fff4f0*/ bool TestBit(int bitNum);
            /*0x6fff584*/ void SetBit(uint bitNum);
            /*0x6fff58c*/ void SetBit(uint bitNum, bool value);
            /*0x6fff5e8*/ int LowestSetBit();
            /*0x6ffac68*/ byte[] GetBytes();
            /*0x6fff718*/ string ToString(uint radix);
            /*0x6fff770*/ string ToString(uint radix, string characterSet);
            /*0x6ffe46c*/ void Normalize();
            /*0x6ffa88c*/ void Clear();
            /*0x6fffa04*/ int GetHashCode();
            /*0x6fffa5c*/ string ToString();
            /*0x6fffa64*/ bool Equals(object o);
            /*0x6ffa208*/ Mono.Math.BigInteger ModInverse(Mono.Math.BigInteger modulus);
            /*0x6ffa764*/ Mono.Math.BigInteger ModPow(Mono.Math.BigInteger exp, Mono.Math.BigInteger n);
            /*0x70003b0*/ void Incr2();

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

                /*0x70001a4*/ ModulusRing(Mono.Math.BigInteger modulus);
                /*0x70004d8*/ void BarrettReduction(Mono.Math.BigInteger x);
                /*0x7000b2c*/ Mono.Math.BigInteger Multiply(Mono.Math.BigInteger a, Mono.Math.BigInteger b);
                /*0x7000ca8*/ Mono.Math.BigInteger Difference(Mono.Math.BigInteger a, Mono.Math.BigInteger b);
                /*0x70002a4*/ Mono.Math.BigInteger Pow(Mono.Math.BigInteger a, Mono.Math.BigInteger k);
                /*0x7000e5c*/ Mono.Math.BigInteger Pow(uint b, Mono.Math.BigInteger exp);
            }

            class Kernel
            {
                static /*0x6ffe704*/ Mono.Math.BigInteger Subtract(Mono.Math.BigInteger big, Mono.Math.BigInteger small);
                static /*0x700086c*/ void MinusEq(Mono.Math.BigInteger big, Mono.Math.BigInteger small);
                static /*0x700099c*/ void PlusEq(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
                static /*0x6ffe5c0*/ Mono.Math.BigInteger.Sign Compare(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
                static /*0x6fff990*/ uint SingleByteDivideInPlace(Mono.Math.BigInteger n, uint d);
                static /*0x6ffe8c8*/ uint DwordMod(Mono.Math.BigInteger n, uint d);
                static /*0x7000ecc*/ Mono.Math.BigInteger[] DwordDivMod(Mono.Math.BigInteger n, uint d);
                static /*0x6ffe92c*/ Mono.Math.BigInteger[] multiByteDivide(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
                static /*0x6ffef28*/ Mono.Math.BigInteger LeftShift(Mono.Math.BigInteger bi, int n);
                static /*0x6fff110*/ Mono.Math.BigInteger RightShift(Mono.Math.BigInteger bi, int n);
                static /*0x6ffee28*/ void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset);
                static /*0x7000730*/ void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod);
                static /*0x700106c*/ uint modInverse(Mono.Math.BigInteger bi, uint modulus);
                static /*0x6fffb8c*/ Mono.Math.BigInteger modInverse(Mono.Math.BigInteger bi, Mono.Math.BigInteger modulus);
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
                /*0x700112c*/ PrimalityTest(object object, nint method);
                /*0x7001238*/ bool Invoke(Mono.Math.BigInteger bi, Mono.Math.Prime.ConfidenceFactor confidence);
            }

            class PrimalityTests
            {
                static /*0x700124c*/ int GetSPPRounds(Mono.Math.BigInteger bi, Mono.Math.Prime.ConfidenceFactor confidence);
                static /*0x70013d8*/ bool RabinMillerTest(Mono.Math.BigInteger n, Mono.Math.Prime.ConfidenceFactor confidence);
            }

            namespace Generator
            {
                class PrimeGeneratorBase
                {
                    /*0x70016ec*/ PrimeGeneratorBase();
                    /*0x7001670*/ Mono.Math.Prime.ConfidenceFactor get_Confidence();
                    /*0x7001678*/ Mono.Math.Prime.PrimalityTest get_PrimalityTest();
                    /*0x70016e4*/ int get_TrialDivisionBounds();
                    /*0x380ba90*/ Mono.Math.BigInteger GenerateNewPrime(int bits);
                }

                class SequentialSearchPrimeGeneratorBase : Mono.Math.Prime.Generator.PrimeGeneratorBase
                {
                    /*0x70003a8*/ SequentialSearchPrimeGeneratorBase();
                    /*0x70016f4*/ Mono.Math.BigInteger GenerateSearchBase(int bits, object context);
                    /*0x7001768*/ Mono.Math.BigInteger GenerateNewPrime(int bits);
                    /*0x7001778*/ Mono.Math.BigInteger GenerateNewPrime(int bits, object context);
                    /*0x7001a5c*/ bool IsPrimeAcceptable(Mono.Math.BigInteger bi, object context);
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

    static /*0x6ff7f7c*/ uint ComputeStringHash(string s);

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
