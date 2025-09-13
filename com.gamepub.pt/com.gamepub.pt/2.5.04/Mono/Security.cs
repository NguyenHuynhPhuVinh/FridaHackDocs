class <Module>
{
}

class Locale
{
    static /*0x25d7d0c*/ string GetText(string msg);
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

            /*0x25d144c*/ ASN1(byte tag);
            /*0x25d147c*/ ASN1(byte tag, byte[] data);
            /*0x25d14b8*/ ASN1(byte[] data);
            /*0x25d1768*/ int get_Count();
            /*0x25d1784*/ byte get_Tag();
            /*0x25d178c*/ int get_Length();
            /*0x25d17a4*/ byte[] get_Value();
            /*0x25d1838*/ void set_Value(byte[] value);
            /*0x25d18c0*/ bool CompareArray(byte[] array1, byte[] array2);
            /*0x25d193c*/ bool CompareValue(byte[] value);
            /*0x25d194c*/ Mono.Security.ASN1 Add(Mono.Security.ASN1 asn1);
            /*0x25d19e4*/ byte[] GetBytes();
            /*0x25d1640*/ void Decode(byte[] asn1, ref int anPos, int anLength);
            /*0x25d2050*/ void DecodeTLV(byte[] asn1, ref int pos, ref byte tag, ref int length, ref byte[] content);
            /*0x25d218c*/ Mono.Security.ASN1 get_Item(int index);
            /*0x25d22c8*/ Mono.Security.ASN1 Element(int index, byte anTag);
            /*0x25d2420*/ string ToString();
        }

        class ASN1Convert
        {
            static /*0x25d26fc*/ Mono.Security.ASN1 FromInt32(int value);
            static /*0x25d28a8*/ Mono.Security.ASN1 FromOid(string oid);
            static /*0x25d2964*/ Mono.Security.ASN1 FromUnsignedBigInteger(byte[] big);
            static /*0x25d2a80*/ int ToInt32(Mono.Security.ASN1 asn1);
            static /*0x25d2b9c*/ string ToOid(Mono.Security.ASN1 asn1);
            static /*0x25d2e44*/ System.DateTime ToDateTime(Mono.Security.ASN1 time);
        }

        class BitConverterLE
        {
            static /*0x25d4f78*/ byte[] GetUIntBytes(byte* bytes);
            static /*0x25d509c*/ byte[] GetULongBytes(byte* bytes);
            static /*0x25d2884*/ byte[] GetBytes(int value);
            static /*0x25d5240*/ byte[] GetBytes(long value);
            static /*0x25d5264*/ void UShortFromBytes(byte* dst, byte[] src, int startIndex);
            static /*0x25d5354*/ void UIntFromBytes(byte* dst, byte[] src, int startIndex);
            static /*0x25d54b4*/ ushort ToUInt16(byte[] value, int startIndex);
            static /*0x25d54e4*/ uint ToUInt32(byte[] value, int startIndex);
        }

        class PKCS7
        {
            class ContentInfo
            {
                /*0x10*/ string contentType;
                /*0x18*/ Mono.Security.ASN1 content;

                /*0x2ae8f18*/ ContentInfo();
                /*0x2ae8f84*/ ContentInfo(string oid);
                /*0x2ae8fac*/ ContentInfo(byte[] data);
                /*0x2ae901c*/ ContentInfo(Mono.Security.ASN1 asn1);
                /*0x2ae918c*/ Mono.Security.ASN1 get_ASN1();
                /*0x2ae923c*/ Mono.Security.ASN1 get_Content();
                /*0x2ae9244*/ void set_Content(Mono.Security.ASN1 value);
                /*0x2ae924c*/ string get_ContentType();
                /*0x2ae9254*/ void set_ContentType(string value);
                /*0x2ae9190*/ Mono.Security.ASN1 GetASN1();
            }

            class EncryptedData
            {
                /*0x10*/ byte _version;
                /*0x18*/ Mono.Security.PKCS7.ContentInfo _content;
                /*0x20*/ Mono.Security.PKCS7.ContentInfo _encryptionAlgorithm;
                /*0x28*/ byte[] _encrypted;

                /*0x2ae925c*/ EncryptedData();
                /*0x2ae9284*/ EncryptedData(Mono.Security.ASN1 asn1);
                /*0x2ae9578*/ Mono.Security.PKCS7.ContentInfo get_EncryptionAlgorithm();
                /*0x2ae9580*/ byte[] get_EncryptedContent();
            }
        }

        namespace X509
        {
            class SafeBag
            {
                /*0x10*/ string _bagOID;
                /*0x18*/ Mono.Security.ASN1 _asn1;

                /*0x25ddc58*/ SafeBag(string bagOID, Mono.Security.ASN1 asn1);
                /*0x25e2a00*/ string get_BagOID();
                /*0x25e2a08*/ Mono.Security.ASN1 get_ASN1();
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

                static /*0x25e13bc*/ PKCS12();
                static /*0x25e1358*/ int get_MaximumPasswordLength();
                /*0x25daaec*/ PKCS12();
                /*0x25dabd0*/ PKCS12(byte[] data);
                /*0x25db480*/ PKCS12(byte[] data, string password);
                /*0x25dade8*/ void Decode(byte[] data);
                /*0x25dbe3c*/ void Finalize();
                /*0x25dac08*/ void set_Password(string value);
                /*0x25dbebc*/ int get_IterationCount();
                /*0x25dbec4*/ void set_IterationCount(int value);
                /*0x25dbecc*/ System.Collections.ArrayList get_Keys();
                /*0x25dc780*/ Mono.Security.X509.X509CertificateCollection get_Certificates();
                /*0x25dcdd4*/ System.Security.Cryptography.RandomNumberGenerator get_RNG();
                /*0x25db62c*/ bool Compare(byte[] expected, byte[] actual);
                /*0x25dce00*/ System.Security.Cryptography.SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount);
                /*0x25dc5c0*/ byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData);
                /*0x25dbd9c*/ byte[] Decrypt(Mono.Security.PKCS7.EncryptedData ed);
                /*0x25dd394*/ byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data);
                /*0x25dd5b4*/ System.Security.Cryptography.DSAParameters GetExistingParameters(ref bool found);
                /*0x25ddaec*/ void AddPrivateKey(Mono.Security.Cryptography.PKCS8.PrivateKeyInfo pki);
                /*0x25db6a8*/ void ReadSafeBag(Mono.Security.ASN1 safeBag);
                /*0x25ddc90*/ Mono.Security.ASN1 CertificateSafeBag(Mono.Security.X509.X509Certificate x509, System.Collections.IDictionary attributes);
                /*0x25db4c4*/ byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data);
                /*0x25de88c*/ byte[] GetBytes();
                /*0x25e0810*/ Mono.Security.PKCS7.ContentInfo EncryptedContentInfo(Mono.Security.ASN1 safeBags, string algorithmOid);
                /*0x25e0808*/ void AddCertificate(Mono.Security.X509.X509Certificate cert);
                /*0x25e0b1c*/ void AddCertificate(Mono.Security.X509.X509Certificate cert, System.Collections.IDictionary attributes);
                /*0x25e0800*/ void RemoveCertificate(Mono.Security.X509.X509Certificate cert);
                /*0x25e0d70*/ void RemoveCertificate(Mono.Security.X509.X509Certificate cert, System.Collections.IDictionary attrs);
                /*0x25e1284*/ object Clone();

                class DeriveBytes
                {
                    static /*0x0*/ byte[] keyDiversifier;
                    static /*0x8*/ byte[] ivDiversifier;
                    static /*0x10*/ byte[] macDiversifier;
                    /*0x10*/ string _hashName;
                    /*0x18*/ int _iterations;
                    /*0x20*/ byte[] _password;
                    /*0x28*/ byte[] _salt;

                    static /*0x2ae8e08*/ DeriveBytes();
                    /*0x2ae8614*/ DeriveBytes();
                    /*0x2ae861c*/ void set_HashName(string value);
                    /*0x2ae8624*/ void set_IterationCount(int value);
                    /*0x2ae862c*/ void set_Password(byte[] value);
                    /*0x2ae86c8*/ void set_Salt(byte[] value);
                    /*0x2ae8758*/ void Adjust(byte[] a, int aOff, byte[] b);
                    /*0x2ae8840*/ byte[] Derive(byte[] diversifier, int n);
                    /*0x2ae8c94*/ byte[] DeriveKey(int size);
                    /*0x2ae8d10*/ byte[] DeriveIV(int size);
                    /*0x2ae8d8c*/ byte[] DeriveMAC(int size);
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
                static /*0x38*/ byte[] domainComponent;
                static /*0x40*/ byte[] userid;
                static /*0x48*/ byte[] email;
                static /*0x50*/ byte[] dnQualifier;
                static /*0x58*/ byte[] title;
                static /*0x60*/ byte[] surname;
                static /*0x68*/ byte[] givenName;
                static /*0x70*/ byte[] initial;

                static /*0x25e4ee8*/ X501();
                static /*0x25e43e4*/ string ToString(Mono.Security.ASN1 seq);
                static /*0x25e4d10*/ string ToString(Mono.Security.ASN1 seq, bool reversed, string separator, bool quotes);
                static /*0x25e452c*/ void AppendEntry(System.Text.StringBuilder sb, Mono.Security.ASN1 entry, bool quotes);
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
                /*0x80*/ System.Security.Cryptography.RSA _rsa;
                /*0x88*/ System.Security.Cryptography.DSA _dsa;
                /*0x90*/ int version;
                /*0x98*/ byte[] serialnumber;
                /*0xa0*/ byte[] issuerUniqueID;
                /*0xa8*/ byte[] subjectUniqueID;
                /*0xb0*/ Mono.Security.X509.X509ExtensionCollection extensions;

                static /*0x25e6264*/ X509Certificate();
                static /*0x25e5c20*/ byte[] PEM(string type, byte[] data);
                /*0x25dcb78*/ X509Certificate(byte[] data);
                /*0x25e52c8*/ void Parse(byte[] data);
                /*0x25e5d60*/ byte[] GetUnsignedBigInteger(byte[] integer);
                /*0x25dd848*/ System.Security.Cryptography.DSA get_DSA();
                /*0x25e5e08*/ void set_DSA(System.Security.Cryptography.DSA value);
                /*0x25e5e18*/ string get_IssuerName();
                /*0x25e5e20*/ string get_KeyAlgorithm();
                /*0x25e5e28*/ byte[] get_KeyAlgorithmParameters();
                /*0x25e5ea0*/ byte[] get_PublicKey();
                /*0x25e5f18*/ System.Security.Cryptography.RSA get_RSA();
                /*0x25e60c4*/ void set_RSA(System.Security.Cryptography.RSA value);
                /*0x25e60d4*/ byte[] get_RawData();
                /*0x25e614c*/ byte[] get_SerialNumber();
                /*0x25e61c4*/ string get_SignatureAlgorithm();
                /*0x25e61cc*/ string get_SubjectName();
                /*0x25e61d4*/ System.DateTime get_ValidFrom();
                /*0x25e61dc*/ System.DateTime get_ValidUntil();
                /*0x25e61e4*/ int get_Version();
                /*0x25e61ec*/ Mono.Security.ASN1 GetIssuerName();
                /*0x25e61f4*/ Mono.Security.ASN1 GetSubjectName();
                /*0x25e61fc*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            class X509CertificateCollection : System.Collections.CollectionBase, System.Collections.IEnumerable
            {
                /*0x25dabc8*/ X509CertificateCollection();
                /*0x25e62c8*/ Mono.Security.X509.X509Certificate get_Item(int index);
                /*0x25dcd4c*/ int Add(Mono.Security.X509.X509Certificate value);
                /*0x25dd7e8*/ Mono.Security.X509.X509CertificateCollection.X509CertificateEnumerator GetEnumerator();
                /*0x25e6374*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x25e63a0*/ int GetHashCode();

                class X509CertificateEnumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ System.Collections.IEnumerator enumerator;

                    /*0x2aeab90*/ X509CertificateEnumerator(Mono.Security.X509.X509CertificateCollection mappings);
                    /*0x2aeac58*/ Mono.Security.X509.X509Certificate get_Current();
                    /*0x2aead54*/ object System.Collections.IEnumerator.get_Current();
                    /*0x2aeae04*/ bool System.Collections.IEnumerator.MoveNext();
                    /*0x2aeaeb0*/ void System.Collections.IEnumerator.Reset();
                    /*0x2aeaf60*/ bool MoveNext();
                }
            }

            class X509Extension
            {
                /*0x10*/ string extnOid;
                /*0x18*/ bool extnCritical;
                /*0x20*/ Mono.Security.ASN1 extnValue;

                /*0x25e63c8*/ X509Extension(Mono.Security.ASN1 asn1);
                /*0x25e6694*/ void Decode();
                /*0x25e6698*/ bool Equals(object obj);
                /*0x25e67ec*/ int GetHashCode();
                /*0x25e680c*/ void WriteLine(System.Text.StringBuilder sb, int n, int pos);
                /*0x25e6a58*/ string ToString();
            }

            class X509ExtensionCollection : System.Collections.CollectionBase, System.Collections.IEnumerable
            {
                /*0x18*/ bool readOnly;

                /*0x2ae6184*/ X509ExtensionCollection();
                /*0x2ae618c*/ X509ExtensionCollection(Mono.Security.ASN1 asn1);
                /*0x2ae62d8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class X509Store
            {
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

                    static /*0x25d6514*/ ChallengeResponse();
                    /*0x25d5614*/ ChallengeResponse();
                    /*0x25d5688*/ ChallengeResponse(string password, byte[] challenge);
                    /*0x25d5c30*/ void Finalize();
                    /*0x25d56cc*/ void set_Password(string value);
                    /*0x25d5b24*/ void set_Challenge(byte[] value);
                    /*0x25d5ec8*/ byte[] get_LM();
                    /*0x25d6234*/ byte[] get_NT();
                    /*0x25d5ca4*/ void Dispose();
                    /*0x25d6298*/ void Dispose(bool disposing);
                    /*0x25d5f2c*/ byte[] GetResponse(byte[] pwd);
                    /*0x25d6310*/ byte[] PrepareDESKey(byte[] key56bits, int position);
                    /*0x25d5d14*/ byte[] PasswordToKey(string password, int position);
                }

                class ChallengeResponse2
                {
                    static /*0x0*/ byte[] magic;
                    static /*0x8*/ byte[] nullEncMagic;

                    static /*0x25d7ae0*/ ChallengeResponse2();
                    static /*0x25d65e8*/ byte[] Compute_LM(string password, byte[] challenge);
                    static /*0x25d6e24*/ byte[] Compute_NTLM_Password(string password);
                    static /*0x25d6f28*/ byte[] Compute_NTLM(string password, byte[] challenge);
                    static /*0x25d6fa0*/ void Compute_NTLMv2_Session(string password, byte[] challenge, ref byte[] lm, ref byte[] ntlm);
                    static /*0x25d7178*/ byte[] Compute_NTLMv2(Mono.Security.Protocol.Ntlm.Type2Message type2, string username, string password, string domain);
                    static /*0x25d76c8*/ void Compute(Mono.Security.Protocol.Ntlm.Type2Message type2, Mono.Security.Protocol.Ntlm.NtlmAuthLevel level, string username, string password, string domain, ref byte[] lm, ref byte[] ntlm);
                    static /*0x25d6b04*/ byte[] GetResponse(byte[] challenge, byte[] pwd);
                    static /*0x25d78dc*/ byte[] PrepareDESKey(byte[] key56bits, int position);
                    static /*0x25d6978*/ byte[] PasswordToKey(string password, int position);
                }

                class MessageBase
                {
                    static /*0x0*/ byte[] header;
                    /*0x10*/ int _type;
                    /*0x14*/ Mono.Security.Protocol.Ntlm.NtlmFlags _flags;

                    static /*0x25d9640*/ MessageBase();
                    /*0x25d9214*/ MessageBase(int messageType);
                    /*0x25d9240*/ Mono.Security.Protocol.Ntlm.NtlmFlags get_Flags();
                    /*0x25d9248*/ void set_Flags(Mono.Security.Protocol.Ntlm.NtlmFlags value);
                    /*0x25d9250*/ int get_Type();
                    /*0x25d9258*/ byte[] PrepareMessage(int messageSize);
                    /*0x25d936c*/ void Decode(byte[] message);
                    /*0x25d9508*/ bool CheckHeader(byte[] message);
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

                    static /*0x25da560*/ NtlmSettings();
                    static /*0x25da4fc*/ Mono.Security.Protocol.Ntlm.NtlmAuthLevel get_DefaultAuthLevel();
                }

                class Type1Message : Mono.Security.Protocol.Ntlm.MessageBase
                {
                    /*0x18*/ string _host;
                    /*0x20*/ string _domain;

                    /*0x25e2e9c*/ Type1Message();
                    /*0x25e2f2c*/ void set_Domain(string value);
                    /*0x25e2fb0*/ void set_Host(string value);
                    /*0x25e3034*/ void Decode(byte[] message);
                    /*0x25e3128*/ byte[] GetBytes();
                }

                class Type2Message : Mono.Security.Protocol.Ntlm.MessageBase
                {
                    /*0x18*/ byte[] _nonce;
                    /*0x20*/ string _targetName;
                    /*0x28*/ byte[] _targetInfo;

                    /*0x25e3390*/ Type2Message(byte[] message);
                    /*0x25e3440*/ void Finalize();
                    /*0x25d764c*/ byte[] get_Nonce();
                    /*0x25e34bc*/ string get_TargetName();
                    /*0x25d75d0*/ byte[] get_TargetInfo();
                    /*0x25e34c4*/ void Decode(byte[] message);
                    /*0x25e3648*/ byte[] GetBytes();
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

                    /*0x25e370c*/ Type3Message(Mono.Security.Protocol.Ntlm.Type2Message type2);
                    /*0x25e3924*/ void Finalize();
                    /*0x25e39d8*/ void set_Domain(string value);
                    /*0x25e3a5c*/ void set_Password(string value);
                    /*0x25e3a64*/ void set_Username(string value);
                    /*0x25e3a6c*/ void Decode(byte[] message);
                    /*0x25e3c90*/ string DecodeString(byte[] buffer, int offset, int len);
                    /*0x25e3cf4*/ byte[] EncodeString(string text);
                    /*0x25e3d94*/ byte[] GetBytes();
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

                /*0x25d340c*/ Alert(Mono.Security.Interface.AlertDescription description);
                /*0x25d33fc*/ Mono.Security.Interface.AlertLevel get_Level();
                /*0x25d3404*/ Mono.Security.Interface.AlertDescription get_Description();
                /*0x25d3484*/ void inferAlertLevel();
                /*0x25d34c4*/ string ToString();
            }

            class ValidationResult
            {
                /*0x10*/ bool trusted;
                /*0x11*/ bool user_denied;
                /*0x14*/ int error_code;
                /*0x18*/ System.Nullable<Mono.Security.Interface.MonoSslPolicyErrors> policy_errors;

                /*0x25e4378*/ ValidationResult(bool trusted, bool user_denied, int error_code, System.Nullable<Mono.Security.Interface.MonoSslPolicyErrors> policy_errors);
                /*0x25e43d4*/ bool get_Trusted();
                /*0x25e43dc*/ bool get_UserDenied();
            }

            interface ICertificateValidator
            {
                Mono.Security.Interface.MonoTlsSettings get_Settings();
                bool SelectClientCertificate(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers, ref System.Security.Cryptography.X509Certificates.X509Certificate clientCertificate);
            }

            interface ICertificateValidator2 : Mono.Security.Interface.ICertificateValidator
            {
                Mono.Security.Interface.ValidationResult ValidateCertificate(string targetHost, bool serverMode, System.Security.Cryptography.X509Certificates.X509Certificate leaf, System.Security.Cryptography.X509Certificates.X509Chain chain);
            }

            class CertificateValidationHelper
            {
                static /*0x0*/ bool noX509Chain;
                static /*0x1*/ bool supportsTrustAnchors;

                static /*0x25d5514*/ CertificateValidationHelper();
                static /*0x25d5590*/ Mono.Security.Interface.ICertificateValidator2 GetInternalValidator(Mono.Security.Interface.MonoTlsSettings settings, Mono.Security.Interface.MonoTlsProvider provider);
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

            interface IMonoSslStream : System.IDisposable
            {
                void AuthenticateAsClient(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation);
                System.Threading.Tasks.Task AuthenticateAsClientAsync(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation);
                int Read(byte[] buffer, int offset, int count);
                void Write(byte[] buffer, int offset, int count);
                System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                int EndRead(System.IAsyncResult asyncResult);
                System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState);
                void EndWrite(System.IAsyncResult asyncResult);
                System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, System.Threading.CancellationToken cancellationToken);
                bool get_IsAuthenticated();
                bool get_CanRead();
                bool get_CanWrite();
                long get_Length();
                long get_Position();
                System.Net.Security.AuthenticatedStream get_AuthenticatedStream();
                int get_ReadTimeout();
                void set_ReadTimeout(int value);
                int get_WriteTimeout();
                System.Security.Cryptography.X509Certificates.X509Certificate get_InternalLocalCertificate();
            }

            class MonoTlsConnectionInfo
            {
                /*0x10*/ Mono.Security.Interface.CipherSuiteCode <CipherSuiteCode>k__BackingField;
                /*0x14*/ Mono.Security.Interface.TlsProtocols <ProtocolVersion>k__BackingField;
                /*0x18*/ string <PeerDomainName>k__BackingField;

                /*0x25da14c*/ MonoTlsConnectionInfo();
                /*0x25da06c*/ Mono.Security.Interface.CipherSuiteCode get_CipherSuiteCode();
                /*0x25da074*/ void set_CipherSuiteCode(Mono.Security.Interface.CipherSuiteCode value);
                /*0x25da07c*/ Mono.Security.Interface.TlsProtocols get_ProtocolVersion();
                /*0x25da084*/ void set_ProtocolVersion(Mono.Security.Interface.TlsProtocols value);
                /*0x25da08c*/ void set_PeerDomainName(string value);
                /*0x25da094*/ string ToString();
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
                /*0x25d9b50*/ MonoRemoteCertificateValidationCallback(object object, nint method);
                /*0x25d9bb0*/ bool Invoke(string targetHost, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, Mono.Security.Interface.MonoSslPolicyErrors sslPolicyErrors);
                /*0x25d9f94*/ System.IAsyncResult BeginInvoke(string targetHost, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, Mono.Security.Interface.MonoSslPolicyErrors sslPolicyErrors, System.AsyncCallback callback, object object);
                /*0x25da040*/ bool EndInvoke(System.IAsyncResult result);
            }

            class MonoLocalCertificateSelectionCallback : System.MulticastDelegate
            {
                /*0x25d96d0*/ MonoLocalCertificateSelectionCallback(object object, nint method);
                /*0x25d9730*/ System.Security.Cryptography.X509Certificates.X509Certificate Invoke(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers);
                /*0x25d9b10*/ System.IAsyncResult BeginInvoke(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection localCertificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string[] acceptableIssuers, System.AsyncCallback callback, object object);
                /*0x25d9b44*/ System.Security.Cryptography.X509Certificates.X509Certificate EndInvoke(System.IAsyncResult result);
            }

            class MonoTlsProvider
            {
                /*0x25da154*/ MonoTlsProvider();
                System.Guid get_ID();
                string get_Name();
                bool get_SupportsSslStream();
                bool get_SupportsConnectionInfo();
                bool get_SupportsMonoExtensions();
                System.Security.Authentication.SslProtocols get_SupportedProtocols();
                Mono.Security.Interface.IMonoSslStream CreateSslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, Mono.Security.Interface.MonoTlsSettings settings);
                Mono.Security.Interface.IMonoSslStream CreateSslStreamInternal(System.Net.Security.SslStream sslStream, System.IO.Stream innerStream, bool leaveInnerStreamOpen, Mono.Security.Interface.MonoTlsSettings settings);
                bool ValidateCertificate(Mono.Security.Interface.ICertificateValidator2 validator, string targetHost, bool serverMode, System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, bool wantsChain, ref System.Security.Cryptography.X509Certificates.X509Chain chain, ref Mono.Security.Interface.MonoSslPolicyErrors errors, ref int status11);
                bool get_SupportsCleanShutdown();
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
                /*0x4c*/ System.Nullable<Mono.Security.Interface.TlsProtocols> <EnabledProtocols>k__BackingField;
                /*0x58*/ Mono.Security.Interface.CipherSuiteCode[] <EnabledCiphers>k__BackingField;
                /*0x60*/ bool cloned;
                /*0x61*/ bool checkCertName;
                /*0x62*/ bool checkCertRevocationStatus;
                /*0x63*/ System.Nullable<bool> useServicePointManagerCallback;
                /*0x65*/ bool skipSystemValidators;
                /*0x66*/ bool callbackNeedsChain;
                /*0x68*/ Mono.Security.Interface.ICertificateValidator certificateValidator;

                static /*0x25da220*/ Mono.Security.Interface.MonoTlsSettings get_DefaultSettings();
                static /*0x25da2b0*/ Mono.Security.Interface.MonoTlsSettings CopyDefaultSettings();
                /*0x25da20c*/ MonoTlsSettings();
                /*0x25da3bc*/ MonoTlsSettings(Mono.Security.Interface.MonoTlsSettings other);
                /*0x25da15c*/ Mono.Security.Interface.MonoRemoteCertificateValidationCallback get_RemoteCertificateValidationCallback();
                /*0x25da164*/ void set_RemoteCertificateValidationCallback(Mono.Security.Interface.MonoRemoteCertificateValidationCallback value);
                /*0x25da16c*/ Mono.Security.Interface.MonoLocalCertificateSelectionCallback get_ClientCertificateSelectionCallback();
                /*0x25da174*/ void set_ClientCertificateSelectionCallback(Mono.Security.Interface.MonoLocalCertificateSelectionCallback value);
                /*0x25da17c*/ System.Nullable<bool> get_UseServicePointManagerCallback();
                /*0x25da184*/ void set_UseServicePointManagerCallback(System.Nullable<bool> value);
                /*0x25da18c*/ bool get_CallbackNeedsCertificateChain();
                /*0x25da194*/ System.Nullable<System.DateTime> get_CertificateValidationTime();
                /*0x25da1a0*/ void set_CertificateValidationTime(System.Nullable<System.DateTime> value);
                /*0x25da1a8*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_TrustAnchors();
                /*0x25da1b0*/ void set_TrustAnchors(System.Security.Cryptography.X509Certificates.X509CertificateCollection value);
                /*0x25da1b8*/ object get_UserSettings();
                /*0x25da1c0*/ void set_UserSettings(object value);
                /*0x25da1c8*/ string[] get_CertificateSearchPaths();
                /*0x25da1d0*/ void set_CertificateSearchPaths(string[] value);
                /*0x25da1d8*/ bool get_SendCloseNotify();
                /*0x25da1e0*/ void set_SendCloseNotify(bool value);
                /*0x25da1ec*/ System.Nullable<Mono.Security.Interface.TlsProtocols> get_EnabledProtocols();
                /*0x25da1f4*/ void set_EnabledProtocols(System.Nullable<Mono.Security.Interface.TlsProtocols> value);
                /*0x25da1fc*/ Mono.Security.Interface.CipherSuiteCode[] get_EnabledCiphers();
                /*0x25da204*/ void set_EnabledCiphers(Mono.Security.Interface.CipherSuiteCode[] value);
                /*0x25da328*/ Mono.Security.Interface.ICertificateValidator get_CertificateValidator();
                /*0x25da330*/ Mono.Security.Interface.MonoTlsSettings CloneWithValidator(Mono.Security.Interface.ICertificateValidator validator);
                /*0x25da2cc*/ Mono.Security.Interface.MonoTlsSettings Clone();
            }

            class TlsException : System.Exception
            {
                /*0x88*/ Mono.Security.Interface.Alert alert;

                /*0x25e2da8*/ TlsException(Mono.Security.Interface.Alert alert, string message);
                /*0x25e2e28*/ TlsException(Mono.Security.Interface.AlertDescription description, string message);
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
                static /*0x25d7bb4*/ string ToHex(byte[] input);
            }

            class MD2 : System.Security.Cryptography.HashAlgorithm
            {
                static /*0x25d7d3c*/ Mono.Security.Cryptography.MD2 Create();
                /*0x25d7d10*/ MD2();
            }

            class MD2Managed : Mono.Security.Cryptography.MD2
            {
                static /*0x0*/ byte[] PI_SUBST;
                /*0x28*/ byte[] state;
                /*0x30*/ byte[] checksum;
                /*0x38*/ byte[] buffer;
                /*0x40*/ int count;
                /*0x48*/ byte[] x;

                static /*0x25d83a0*/ MD2Managed();
                /*0x25d7d90*/ MD2Managed();
                /*0x25d7e38*/ byte[] Padding(int nLength);
                /*0x25d7ee0*/ void Initialize();
                /*0x25d7f4c*/ void HashCore(byte[] array, int ibStart, int cbSize);
                /*0x25d82ac*/ byte[] HashFinal();
                /*0x25d8020*/ void MD2Transform(byte[] state, byte[] checksum, byte[] block, int index);
            }

            class MD4 : System.Security.Cryptography.HashAlgorithm
            {
                static /*0x25d5e74*/ Mono.Security.Cryptography.MD4 Create();
                /*0x25d8430*/ MD4();
            }

            class MD4Managed : Mono.Security.Cryptography.MD4
            {
                /*0x28*/ uint[] state;
                /*0x30*/ byte[] buffer;
                /*0x38*/ uint[] count;
                /*0x40*/ uint[] x;
                /*0x48*/ byte[] digest;

                /*0x25d845c*/ MD4Managed();
                /*0x25d8530*/ void Initialize();
                /*0x25d8628*/ void HashCore(byte[] array, int ibStart, int cbSize);
                /*0x25d8df0*/ byte[] HashFinal();
                /*0x25d9004*/ byte[] Padding(int nLength);
                /*0x25d9088*/ uint F(uint x, uint y, uint z);
                /*0x25d9098*/ uint G(uint x, uint y, uint z);
                /*0x25d90ac*/ uint H(uint x, uint y, uint z);
                /*0x25d90b8*/ uint ROL(uint x, byte n);
                /*0x25d90c4*/ void FF(ref uint a, uint b, uint c, uint d, uint x, byte s);
                /*0x25d90ec*/ void GG(ref uint a, uint b, uint c, uint d, uint x, byte s);
                /*0x25d9124*/ void HH(ref uint a, uint b, uint c, uint d, uint x, byte s);
                /*0x25d8f00*/ void Encode(byte[] output, uint[] input);
                /*0x25d9154*/ void Decode(uint[] output, byte[] input, int index);
                /*0x25d876c*/ void MD4Transform(uint[] state, byte[] block, int index);
            }

            class PKCS1
            {
                static /*0x0*/ byte[] emptySHA1;
                static /*0x8*/ byte[] emptySHA256;
                static /*0x10*/ byte[] emptySHA384;
                static /*0x18*/ byte[] emptySHA512;

                static /*0x25da9a0*/ PKCS1();
                static /*0x25da5b0*/ System.Security.Cryptography.HashAlgorithm CreateFromName(string name);
            }

            class PKCS8
            {
                class PrivateKeyInfo
                {
                    /*0x10*/ int _version;
                    /*0x18*/ string _algorithm;
                    /*0x20*/ byte[] _key;
                    /*0x28*/ System.Collections.ArrayList _list;

                    static /*0x2ae9d9c*/ byte[] RemoveLeadingZero(byte[] bigInt);
                    static /*0x2ae9e44*/ byte[] Normalize(byte[] bigInt, int length);
                    static /*0x2ae9ef4*/ System.Security.Cryptography.RSA DecodeRSA(byte[] keypair);
                    static /*0x2aea2bc*/ byte[] Encode(System.Security.Cryptography.RSA rsa);
                    static /*0x2aea4bc*/ System.Security.Cryptography.DSA DecodeDSA(byte[] privateKey, System.Security.Cryptography.DSAParameters dsaParameters);
                    static /*0x2aea5e8*/ byte[] Encode(System.Security.Cryptography.DSA dsa);
                    static /*0x2aea638*/ byte[] Encode(System.Security.Cryptography.AsymmetricAlgorithm aa);
                    /*0x2ae9a28*/ PrivateKeyInfo();
                    /*0x2ae9a94*/ PrivateKeyInfo(byte[] data);
                    /*0x2ae9d24*/ byte[] get_PrivateKey();
                    /*0x2ae9ac0*/ void Decode(byte[] data);
                }

                class EncryptedPrivateKeyInfo
                {
                    /*0x10*/ string _algorithm;
                    /*0x18*/ byte[] _salt;
                    /*0x20*/ int _iterations;
                    /*0x28*/ byte[] _data;

                    /*0x2ae95f8*/ EncryptedPrivateKeyInfo();
                    /*0x2ae9600*/ EncryptedPrivateKeyInfo(byte[] data);
                    /*0x2ae98e0*/ string get_Algorithm();
                    /*0x2ae98e8*/ byte[] get_EncryptedData();
                    /*0x2ae9960*/ byte[] get_Salt();
                    /*0x2ae9a20*/ int get_IterationCount();
                    /*0x2ae9630*/ void Decode(byte[] data);
                }
            }

            class RSAManaged : System.Security.Cryptography.RSA
            {
                /*0x20*/ bool isCRTpossible;
                /*0x21*/ bool keypairGenerated;
                /*0x22*/ bool m_disposed;
                /*0x28*/ Mono.Math.BigInteger d;
                /*0x30*/ Mono.Math.BigInteger p;
                /*0x38*/ Mono.Math.BigInteger q;
                /*0x40*/ Mono.Math.BigInteger dp;
                /*0x48*/ Mono.Math.BigInteger dq;
                /*0x50*/ Mono.Math.BigInteger qInv;
                /*0x58*/ Mono.Math.BigInteger n;
                /*0x60*/ Mono.Math.BigInteger e;
                /*0x68*/ Mono.Security.Cryptography.RSAManaged.KeyGeneratedEventHandler KeyGenerated;

                /*0x25e1de4*/ void GenerateKeyPair();
                /*0x25e20a0*/ bool get_PublicOnly();
                /*0x25e2160*/ System.Security.Cryptography.RSAParameters ExportParameters(bool includePrivateParameters);
                /*0x25e2578*/ void ImportParameters(System.Security.Cryptography.RSAParameters parameters);
                /*0x25e24bc*/ byte[] GetPaddedValue(Mono.Math.BigInteger value, int length);

                class KeyGeneratedEventHandler : System.MulticastDelegate
                {
                    /*0x2aea760*/ KeyGeneratedEventHandler(object object, nint method);
                    /*0x2aea7c0*/ void Invoke(object sender, System.EventArgs e);
                    /*0x2aeab54*/ System.IAsyncResult BeginInvoke(object sender, System.EventArgs e, System.AsyncCallback callback, object object);
                    /*0x2aeab84*/ void EndInvoke(System.IAsyncResult result);
                }
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

            static /*0x25d4ee8*/ BigInteger();
            static /*0x25d3b14*/ Mono.Math.BigInteger op_Implicit(uint value);
            static /*0x25d3b70*/ Mono.Math.BigInteger op_Implicit(int value);
            static /*0x25d3c18*/ Mono.Math.BigInteger op_Subtraction(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x25d3e20*/ uint op_Modulus(Mono.Math.BigInteger bi, uint ui);
            static /*0x25d3e28*/ Mono.Math.BigInteger op_Modulus(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x25d3e64*/ Mono.Math.BigInteger op_Division(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x25d3e9c*/ Mono.Math.BigInteger op_Multiply(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x25d4070*/ Mono.Math.BigInteger op_LeftShift(Mono.Math.BigInteger bi1, int shiftVal);
            static /*0x25d4078*/ Mono.Math.BigInteger op_RightShift(Mono.Math.BigInteger bi1, int shiftVal);
            static /*0x25d4080*/ System.Security.Cryptography.RandomNumberGenerator get_Rng();
            static /*0x25d4144*/ Mono.Math.BigInteger GenerateRandom(int bits, System.Security.Cryptography.RandomNumberGenerator rng);
            static /*0x25d42d4*/ Mono.Math.BigInteger GenerateRandom(int bits);
            static /*0x25d3da8*/ bool op_Equality(Mono.Math.BigInteger bi1, uint ui);
            static /*0x25d46a0*/ bool op_Inequality(Mono.Math.BigInteger bi1, uint ui);
            static /*0x25d4718*/ bool op_Equality(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x25d47e8*/ bool op_Inequality(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x25d48b8*/ bool op_GreaterThan(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x25d48d8*/ bool op_LessThan(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x25d48f4*/ bool op_GreaterThanOrEqual(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x25d4914*/ bool op_LessThanOrEqual(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
            static /*0x25d4da0*/ Mono.Math.BigInteger GeneratePseudoPrime(int bits);
            /*0x25d357c*/ BigInteger(Mono.Math.BigInteger.Sign sign, uint len);
            /*0x25d35f4*/ BigInteger(Mono.Math.BigInteger bi);
            /*0x25d36a0*/ BigInteger(Mono.Math.BigInteger bi, uint len);
            /*0x25d3784*/ BigInteger(byte[] inData);
            /*0x25d3a80*/ BigInteger(uint ui);
            /*0x25d433c*/ int BitCount();
            /*0x25d43bc*/ bool TestBit(int bitNum);
            /*0x25d4464*/ void SetBit(uint bitNum);
            /*0x25d446c*/ void SetBit(uint bitNum, bool value);
            /*0x25d44d4*/ int LowestSetBit();
            /*0x25d455c*/ byte[] GetBytes();
            /*0x25d4934*/ string ToString(uint radix);
            /*0x25d4990*/ string ToString(uint radix, string characterSet);
            /*0x25d3a1c*/ void Normalize();
            /*0x25d4bc0*/ int GetHashCode();
            /*0x25d4c24*/ string ToString();
            /*0x25d4c2c*/ bool Equals(object o);
            /*0x25d4d98*/ Mono.Math.BigInteger ModInverse(Mono.Math.BigInteger modulus);
            /*0x25d4e18*/ void Incr2();

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

                /*0x2ae7cd4*/ ModulusRing(Mono.Math.BigInteger modulus);
                /*0x2ae7fec*/ void BarrettReduction(Mono.Math.BigInteger x);
                /*0x2ae8288*/ Mono.Math.BigInteger Multiply(Mono.Math.BigInteger a, Mono.Math.BigInteger b);
                /*0x2ae7dc8*/ Mono.Math.BigInteger Difference(Mono.Math.BigInteger a, Mono.Math.BigInteger b);
                /*0x2ae846c*/ Mono.Math.BigInteger Pow(Mono.Math.BigInteger a, Mono.Math.BigInteger k);
                /*0x2ae859c*/ Mono.Math.BigInteger Pow(uint b, Mono.Math.BigInteger exp);
            }

            class Kernel
            {
                static /*0x2ae6304*/ Mono.Math.BigInteger Subtract(Mono.Math.BigInteger big, Mono.Math.BigInteger small);
                static /*0x2ae64d0*/ void MinusEq(Mono.Math.BigInteger big, Mono.Math.BigInteger small);
                static /*0x2ae65f0*/ void PlusEq(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
                static /*0x2ae677c*/ Mono.Math.BigInteger.Sign Compare(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
                static /*0x2ae68cc*/ uint SingleByteDivideInPlace(Mono.Math.BigInteger n, uint d);
                static /*0x2ae6968*/ uint DwordMod(Mono.Math.BigInteger n, uint d);
                static /*0x2ae69e0*/ Mono.Math.BigInteger[] DwordDivMod(Mono.Math.BigInteger n, uint d);
                static /*0x2ae6ba4*/ Mono.Math.BigInteger[] multiByteDivide(Mono.Math.BigInteger bi1, Mono.Math.BigInteger bi2);
                static /*0x2ae70ac*/ Mono.Math.BigInteger LeftShift(Mono.Math.BigInteger bi, int n);
                static /*0x2ae72a8*/ Mono.Math.BigInteger RightShift(Mono.Math.BigInteger bi, int n);
                static /*0x2ae7470*/ void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset);
                static /*0x2ae756c*/ void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod);
                static /*0x2ae769c*/ uint modInverse(Mono.Math.BigInteger bi, uint modulus);
                static /*0x2ae776c*/ Mono.Math.BigInteger modInverse(Mono.Math.BigInteger bi, Mono.Math.BigInteger modulus);
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
                /*0x25e140c*/ PrimalityTest(object object, nint method);
                /*0x25e146c*/ bool Invoke(Mono.Math.BigInteger bi, Mono.Math.Prime.ConfidenceFactor confidence);
                /*0x25e180c*/ System.IAsyncResult BeginInvoke(Mono.Math.BigInteger bi, Mono.Math.Prime.ConfidenceFactor confidence, System.AsyncCallback callback, object object);
                /*0x25e18a4*/ bool EndInvoke(System.IAsyncResult result);
            }

            class PrimalityTests
            {
                static /*0x25e18d0*/ int GetSPPRounds(Mono.Math.BigInteger bi, Mono.Math.Prime.ConfidenceFactor confidence);
                static /*0x25e1a64*/ bool RabinMillerTest(Mono.Math.BigInteger n, Mono.Math.Prime.ConfidenceFactor confidence);
            }

            namespace Generator
            {
                class PrimeGeneratorBase
                {
                    /*0x25e1ddc*/ PrimeGeneratorBase();
                    /*0x25e1d5c*/ Mono.Math.Prime.ConfidenceFactor get_Confidence();
                    /*0x25e1d64*/ Mono.Math.Prime.PrimalityTest get_PrimalityTest();
                    /*0x25e1dd4*/ int get_TrialDivisionBounds();
                    Mono.Math.BigInteger GenerateNewPrime(int bits);
                }

                class SequentialSearchPrimeGeneratorBase : Mono.Math.Prime.Generator.PrimeGeneratorBase
                {
                    /*0x25d4e10*/ SequentialSearchPrimeGeneratorBase();
                    /*0x25e2a10*/ Mono.Math.BigInteger GenerateSearchBase(int bits, object context);
                    /*0x25e2a90*/ Mono.Math.BigInteger GenerateNewPrime(int bits);
                    /*0x25e2aa0*/ Mono.Math.BigInteger GenerateNewPrime(int bits, object context);
                    /*0x25e2da0*/ bool IsPrimeAcceptable(Mono.Math.BigInteger bi, object context);
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 12D04472A8285260EA12FD3813CDFA9F2D2B548C;
    static /*0x3*/ <PrivateImplementationDetails> 13A35EF1A549297C70E2AD46045BBD2ECA17852D;
    static /*0x8*/ long 16968835DEF6DD3BB86EABA9DEC53BF41851CD6D;
    static /*0x10*/ <PrivateImplementationDetails> 1A84029C80CB5518379F199F53FF08A7B764F8FD;
    static /*0x13*/ <PrivateImplementationDetails> 235D99572263B22ADFEE10FDA0C25E12F4D94FFC;
    static /*0x16*/ <PrivateImplementationDetails> 2D3CF0F15AC2DDEC2956EA1B7BBE43FB8B923130;
    static /*0x24*/ <PrivateImplementationDetails> 320B018758ECE3752FFEDBAEB1A6DB67C80B9359;
    static /*0x64*/ <PrivateImplementationDetails> 3E3442C7396F3F2BB4C7348F4A2074C7DC677D68;
    static /*0x67*/ <PrivateImplementationDetails> 4E3B533C39447AAEB59A8E48FABD7E15B5B5D195;
    static /*0x97*/ <PrivateImplementationDetails> 56DFA5053B3131883637F53219E7D88CCEF35949;
    static /*0xa1*/ <PrivateImplementationDetails> 6D49C9D487D7AD3491ECE08732D68A593CC2038D;
    static /*0xaa*/ <PrivateImplementationDetails> 6E5DC824F803F8565AF31B42199DAE39FE7F4EA9;
    static /*0xce8*/ long 6FA00AC9FFFD87F82A38A7F9ECC8134F4A7052AF;
    static /*0xcf0*/ <PrivateImplementationDetails> 736D39815215889F11249D9958F6ED12D37B9F57;
    static /*0xcf3*/ <PrivateImplementationDetails> 86F4F563FA2C61798AE6238D789139739428463A;
    static /*0xcf6*/ <PrivateImplementationDetails> 97FB30C84FF4A41CD4625B44B2940BFC8DB43003;
    static /*0xcf9*/ <PrivateImplementationDetails> 9A9C3962CD4753376E3507C8CB5FD8FCC4B4EDB5;
    static /*0xd39*/ <PrivateImplementationDetails> 9BB00D1FCCBAF03165447FC8028E7CA07CA9FE88;
    static /*0xd3c*/ <PrivateImplementationDetails> A323DB0813C4D072957BA6FDA79D9776674CD06B;
    static /*0xd40*/ long AEA5F1CC5CFE1660539EDD691FE017F775F63A0D;
    static /*0xd48*/ <PrivateImplementationDetails> BE1BDEC0AA74B4DCB079943E70528096CCA985F8;
    static /*0xd5c*/ <PrivateImplementationDetails> BF477463CE2F5EF38FC4C644BBBF4DF109E7670A;
    static /*0xd5f*/ <PrivateImplementationDetails> CF0B42666EF5E37EDEA0AB8E173E42C196D03814;
    static /*0xd9f*/ <PrivateImplementationDetails> D28E8ABDBD777A482CE0EE5C24814ACAE52AABFE;
    static /*0xdbf*/ <PrivateImplementationDetails> D2C5BAE967587C6F3D9F2C4551911E0575A1101F;
    static /*0xebf*/ <PrivateImplementationDetails> E75835D001C843F156FBA01B001DFE1B8029AC17;
    static /*0xeff*/ <PrivateImplementationDetails> EC5BB4F59D4B9B2E9ECD3904D44A8275F23AFB11;
    static /*0xf09*/ <PrivateImplementationDetails> EC83FB16C20052BEE2B4025159BC2ED45C9C70C3;

    static /*0x25d13cc*/ uint ComputeStringHash(string s);

    struct __StaticArrayInitTypeSize=3
    {
    }

    struct __StaticArrayInitTypeSize=9
    {
    }

    struct __StaticArrayInitTypeSize=10
    {
    }

    struct __StaticArrayInitTypeSize=14
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
