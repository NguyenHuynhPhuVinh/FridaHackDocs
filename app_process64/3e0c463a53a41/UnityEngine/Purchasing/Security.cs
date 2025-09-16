class <Module>
{
}

namespace LipingShare
{
    namespace LCLib
    {
        namespace Asn1Processor
        {
            enum Asn1EndOfIndefiniteLengthNodeType
            {
                EndOfStream = 0,
                EndOfNodeFooter = 1,
                NotEnd = 2,
            }

            class Asn1Node
            {
                /*0x10*/ byte tag;
                /*0x18*/ long dataOffset;
                /*0x20*/ long dataLength;
                /*0x28*/ long lengthFieldBytes;
                /*0x30*/ byte[] data;
                /*0x38*/ System.Collections.ArrayList childNodeList;
                /*0x40*/ byte unusedBits;
                /*0x48*/ long deepness;
                /*0x50*/ string path;
                /*0x58*/ LipingShare.LCLib.Asn1Processor.Asn1Node parentNode;
                /*0x60*/ bool requireRecalculatePar;
                /*0x61*/ bool isIndefiniteLength;
                /*0x62*/ bool parseEncapsulatedData;

                static /*0x7f234f4*/ long ResetBranchDataLength(LipingShare.LCLib.Asn1Processor.Asn1Node node);
                static /*0x7f236fc*/ void ResetDataLengthFieldWidth(LipingShare.LCLib.Asn1Processor.Asn1Node node);
                /*0x7f20370*/ Asn1Node(LipingShare.LCLib.Asn1Processor.Asn1Node parentNode, long dataOffset);
                /*0x7f20de8*/ Asn1Node();
                /*0x7f20418*/ void Init();
                /*0x7f204d0*/ string GetHexPrintingStr(LipingShare.LCLib.Asn1Processor.Asn1Node startNode, string baseLine, string lStr, int lineLen);
                /*0x7f20af4*/ string FormatLineString(string lStr, int indent, int lineLen, string msg);
                /*0x7f208fc*/ string FormatLineHexString(string lStr, int indent, int lineLen, string msg);
                /*0x7f20e5c*/ bool get_IsIndefiniteLength();
                /*0x7f20e64*/ byte get_Tag();
                /*0x7f20e6c*/ byte get_MaskedTag();
                /*0x7f20e78*/ bool LoadData(System.IO.Stream xdata);
                /*0x7f20ff0*/ bool SaveData(System.IO.Stream xdata);
                /*0x7f21334*/ void ClearAll();
                /*0x7f21484*/ void AddChild(LipingShare.LCLib.Asn1Processor.Asn1Node xdata);
                /*0x7f214b4*/ LipingShare.LCLib.Asn1Processor.Asn1Node GetLastChild();
                /*0x7f2111c*/ long get_ChildNodeCount();
                /*0x7f21278*/ LipingShare.LCLib.Asn1Processor.Asn1Node GetChildNode(int index);
                /*0x7f21560*/ string get_TagName();
                /*0x7f219b8*/ LipingShare.LCLib.Asn1Processor.Asn1Node get_ParentNode();
                /*0x7f219c0*/ string GetText(LipingShare.LCLib.Asn1Processor.Asn1Node startNode, int lineLen);
                /*0x7f22ffc*/ string GetDataStr(bool pureHexMode);
                /*0x7f23350*/ long get_DataLength();
                /*0x7f23358*/ byte[] get_Data();
                /*0x7f234e0*/ long get_Deepness();
                /*0x7f234e8*/ void set_RequireRecalculatePar(bool value);
                /*0x7f21428*/ void RecalculateTreePar();
                /*0x7f235c0*/ void ResetChildNodePar(LipingShare.LCLib.Asn1Processor.Asn1Node xNode, long subOffset);
                /*0x7f22ee4*/ string GetListStr(LipingShare.LCLib.Asn1Processor.Asn1Node startNode, int lineLen);
                /*0x7f206f0*/ string GetIndentStr(LipingShare.LCLib.Asn1Processor.Asn1Node startNode);
                /*0x7f237b4*/ bool GeneralDecode(System.IO.Stream xdata);
                /*0x7f239b8*/ bool AreTagsOk();
                /*0x7f23a44*/ bool GeneralDecodeKnownLengthWithChecks(System.IO.Stream xdata, long start, long nodeMaxLen);
                /*0x7f23a80*/ bool IsGeneralStreamLengthOk(System.IO.Stream xdata, long start, long nodeMaxLen);
                /*0x7f23af0*/ bool GeneralDecodeKnownLength(System.IO.Stream xdata);
                /*0x7f23b70*/ void ReadStreamDataDefiniteLength(System.IO.Stream xdata, int length);
                /*0x7f239e8*/ bool GeneralDecodeIndefiniteLength(System.IO.Stream xdata, long nodeMaxLen);
                /*0x7f23c00*/ bool ReadStreamDataIndefiniteLength(System.IO.Stream xdata, long nodeMaxLen);
                /*0x7f23c8c*/ long MeasureContentLength(System.IO.Stream xdata);
                /*0x7f23d20*/ void ReadMeasuredLengthDataFromStart(System.IO.Stream xdata, long startPosition, long length);
                /*0x7f23ddc*/ bool ListDecode(System.IO.Stream xdata);
                /*0x7f2405c*/ bool ListDecodeKnownLengthWithChecks(System.IO.Stream xdata, long start, long childNodeMaxLen);
                /*0x7f24078*/ bool IsListStreamLengthOk(System.IO.Stream xdata, long childNodeMaxLen);
                /*0x7f24094*/ bool ListDecodeKnownLength(System.IO.Stream xdata, long start);
                /*0x7f2413c*/ long CalculateListEncodeFieldBytesAndOffset(System.IO.Stream xdata, long start);
                /*0x7f2418c*/ bool HandleBitStringTag(System.IO.Stream xdata, ref long offset);
                /*0x7f241f8*/ bool ListDecodeKnownLengthInternal(System.IO.Stream xdata, long offset);
                /*0x7f24224*/ System.IO.Stream CreateAndPrepareListDecodeMemoryStreamKnownLength(System.IO.Stream xdata);
                /*0x7f24340*/ bool ListDecodeChildNodesWithKnownLength(System.IO.Stream secData, long offset);
                /*0x7f243c0*/ bool CreateAndAddChildNode(System.IO.Stream secData, ref long offset);
                /*0x7f23fd4*/ bool ListDecodeIndefiniteLength(System.IO.Stream xdata, long start, long childNodeMaxLen);
                /*0x7f244a8*/ bool ListDecodeIndefiniteLengthInternal(System.IO.Stream xdata, long offset, long childNodeMaxLen);
                /*0x7f24524*/ bool ReadNextChildNodeOrEndFooterOfIndefiniteListClearIfInvalid(System.IO.Stream xdata, ref long offset, long childNodeMaxLen);
                /*0x7f245b0*/ LipingShare.LCLib.Asn1Processor.Asn1EndOfIndefiniteLengthNodeType DetectEndOfIndefiniteListContents(System.IO.Stream xdata);
                /*0x7f24624*/ bool ReadNextChildNodeOfIndefiniteListClearIfInvalid(System.IO.Stream xdata, ref long offset, long childNodeMaxLen);
                /*0x7f20f1c*/ bool InternalLoadData(System.IO.Stream xdata);
            }

            class Asn1Parser
            {
                /*0x10*/ byte[] rawData;
                /*0x18*/ LipingShare.LCLib.Asn1Processor.Asn1Node rootNode;

                static /*0x7f24890*/ string GetNodeTextHeader(int lineLen);
                static /*0x7f249c8*/ string GetNodeText(LipingShare.LCLib.Asn1Processor.Asn1Node node, int lineLen);
                /*0x7f246ec*/ Asn1Parser();
                /*0x7f24754*/ void LoadData(System.IO.Stream stream);
                /*0x7f24888*/ LipingShare.LCLib.Asn1Processor.Asn1Node get_RootNode();
                /*0x7f249bc*/ string ToString();
            }

            class Asn1Util
            {
                static /*0x0*/ char[] hexDigits;

                static /*0x7f24a40*/ Asn1Util();
                static /*0x7f231bc*/ string FormatString(string inStr, int lineLen, int groupLen);
                static /*0x7f20d48*/ string GenStr(int len, char xch);
                static /*0x7f22e8c*/ long BytesToLong(byte[] bytes);
                static /*0x7f22d94*/ string BytesToString(byte[] bytes);
                static /*0x7f20790*/ string ToHexString(byte[] bytes);
                static /*0x7f24a14*/ int BytePrecision(ulong value);
                static /*0x7f21148*/ int DERLengthEncode(System.IO.Stream xdata, ulong length);
                static /*0x7f23904*/ long DerLengthDecode(System.IO.Stream bt, ref bool isIndefiniteLength);
                static /*0x7f215b8*/ string GetTagName(byte tag);
            }

            class Oid
            {
                static /*0x0*/ System.Collections.Specialized.StringDictionary oidDictionary;

                /*0x7f22cd0*/ Oid();
                /*0x7f22cd8*/ string GetOidName(string inOidStr);
                /*0x7f24ae0*/ string Decode(byte[] data);
                /*0x7f24b94*/ string Decode(System.IO.Stream bt);
                /*0x7f24df8*/ int DecodeValue(System.IO.Stream bt, ref ulong v);
            }

            class RelativeOid : LipingShare.LCLib.Asn1Processor.Oid
            {
                /*0x7f22d8c*/ RelativeOid();
                /*0x7f24e54*/ string Decode(System.IO.Stream bt);
            }
        }
    }
}

namespace UnityEngine
{
    namespace Purchasing
    {
        namespace Security
        {
            class AppleReceiptParser
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<string, object> _mostRecentReceiptData;

                static /*0x7f26294*/ AppleReceiptParser();
                static /*0x7f25738*/ System.Globalization.CultureInfo PushInvariantCultureOnThread();
                static /*0x7f25cec*/ void PopCultureOffThread(System.Globalization.CultureInfo originalCulture);
                static /*0x7f261a4*/ System.DateTime TryParseDateTimeNode(LipingShare.LCLib.Asn1Processor.Asn1Node node);
                static /*0x381cca4*/ bool ArrayEquals<T>(T[] a, T[] b);
                /*0x7f2628c*/ AppleReceiptParser();
                /*0x7f2505c*/ UnityEngine.Purchasing.Security.AppleReceipt Parse(byte[] receiptData);
                /*0x7f25074*/ UnityEngine.Purchasing.Security.AppleReceipt Parse(byte[] receiptData, ref UnityEngine.Purchasing.Security.PKCS7 receipt);
                /*0x7f25808*/ UnityEngine.Purchasing.Security.AppleReceipt ParseReceipt(LipingShare.LCLib.Asn1Processor.Asn1Node data);
                /*0x7f25d1c*/ LipingShare.LCLib.Asn1Processor.Asn1Node GetSetNode(LipingShare.LCLib.Asn1Processor.Asn1Node data);
                /*0x7f25d78*/ UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt ParseInAppReceipt(LipingShare.LCLib.Asn1Processor.Asn1Node inApp);
            }

            class DistinguishedName
            {
                /*0x10*/ string <Country>k__BackingField;
                /*0x18*/ string <Organization>k__BackingField;
                /*0x20*/ string <OrganizationalUnit>k__BackingField;
                /*0x28*/ string <Dnq>k__BackingField;
                /*0x30*/ string <State>k__BackingField;
                /*0x38*/ string <CommonName>k__BackingField;
                /*0x40*/ string <SerialNumber>k__BackingField;

                /*0x7f26394*/ DistinguishedName(LipingShare.LCLib.Asn1Processor.Asn1Node n);
                /*0x7f2632c*/ string get_Country();
                /*0x7f26334*/ void set_Country(string value);
                /*0x7f2633c*/ string get_Organization();
                /*0x7f26344*/ void set_Organization(string value);
                /*0x7f2634c*/ string get_OrganizationalUnit();
                /*0x7f26354*/ void set_OrganizationalUnit(string value);
                /*0x7f2635c*/ string get_Dnq();
                /*0x7f26364*/ void set_Dnq(string value);
                /*0x7f2636c*/ string get_State();
                /*0x7f26374*/ void set_State(string value);
                /*0x7f2637c*/ string get_CommonName();
                /*0x7f26384*/ void set_CommonName(string value);
                /*0x7f2638c*/ void set_SerialNumber(string value);
                /*0x7f26984*/ bool Equals(UnityEngine.Purchasing.Security.DistinguishedName n2);
                /*0x7f26a28*/ string ToString();
            }

            class X509Cert
            {
                /*0x10*/ string <SerialNumber>k__BackingField;
                /*0x18*/ System.DateTime <ValidAfter>k__BackingField;
                /*0x20*/ System.DateTime <ValidBefore>k__BackingField;
                /*0x28*/ UnityEngine.Purchasing.Security.RSAKey <PubKey>k__BackingField;
                /*0x30*/ bool <SelfSigned>k__BackingField;
                /*0x38*/ UnityEngine.Purchasing.Security.DistinguishedName <Subject>k__BackingField;
                /*0x40*/ UnityEngine.Purchasing.Security.DistinguishedName <Issuer>k__BackingField;
                /*0x48*/ LipingShare.LCLib.Asn1Processor.Asn1Node TbsCertificate;
                /*0x50*/ LipingShare.LCLib.Asn1Processor.Asn1Node <Signature>k__BackingField;
                /*0x58*/ byte[] rawTBSCertificate;

                /*0x7f26c28*/ X509Cert(LipingShare.LCLib.Asn1Processor.Asn1Node n);
                /*0x7f26bd4*/ void set_SerialNumber(string value);
                /*0x7f26bdc*/ void set_ValidAfter(System.DateTime value);
                /*0x7f26be4*/ void set_ValidBefore(System.DateTime value);
                /*0x7f26bec*/ void set_PubKey(UnityEngine.Purchasing.Security.RSAKey value);
                /*0x7f26bf4*/ void set_SelfSigned(bool value);
                /*0x7f26c00*/ UnityEngine.Purchasing.Security.DistinguishedName get_Subject();
                /*0x7f26c08*/ void set_Subject(UnityEngine.Purchasing.Security.DistinguishedName value);
                /*0x7f26c10*/ UnityEngine.Purchasing.Security.DistinguishedName get_Issuer();
                /*0x7f26c18*/ void set_Issuer(UnityEngine.Purchasing.Security.DistinguishedName value);
                /*0x7f26c20*/ void set_Signature(LipingShare.LCLib.Asn1Processor.Asn1Node value);
                /*0x7f26c54*/ void ParseNode(LipingShare.LCLib.Asn1Processor.Asn1Node root);
                /*0x7f26fb0*/ System.DateTime ParseTime(LipingShare.LCLib.Asn1Processor.Asn1Node n);
            }

            class InvalidTimeFormat : UnityEngine.Purchasing.Security.IAPSecurityException
            {
                /*0x7f27218*/ InvalidTimeFormat();
            }

            class InvalidX509Data : UnityEngine.Purchasing.Security.IAPSecurityException
            {
                /*0x7f26900*/ InvalidX509Data();
            }

            enum GooglePurchaseState
            {
                Purchased = 0,
                Cancelled = 1,
                Refunded = 2,
                Deferred = 4,
            }

            class PKCS7
            {
                /*0x10*/ LipingShare.LCLib.Asn1Processor.Asn1Node root;
                /*0x18*/ LipingShare.LCLib.Asn1Processor.Asn1Node <data>k__BackingField;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.Purchasing.Security.SignerInfo> <sinfos>k__BackingField;
                /*0x28*/ System.Collections.Generic.List<UnityEngine.Purchasing.Security.X509Cert> <certChain>k__BackingField;
                /*0x30*/ bool validStructure;

                /*0x7f257d0*/ PKCS7(LipingShare.LCLib.Asn1Processor.Asn1Node node);
                /*0x7f27220*/ LipingShare.LCLib.Asn1Processor.Asn1Node get_data();
                /*0x7f27228*/ void set_data(LipingShare.LCLib.Asn1Processor.Asn1Node value);
                /*0x7f27230*/ System.Collections.Generic.List<UnityEngine.Purchasing.Security.SignerInfo> get_sinfos();
                /*0x7f27238*/ void set_sinfos(System.Collections.Generic.List<UnityEngine.Purchasing.Security.SignerInfo> value);
                /*0x7f27240*/ System.Collections.Generic.List<UnityEngine.Purchasing.Security.X509Cert> get_certChain();
                /*0x7f27248*/ void set_certChain(System.Collections.Generic.List<UnityEngine.Purchasing.Security.X509Cert> value);
                /*0x7f27250*/ void CheckStructure();
            }

            class SignerInfo
            {
                /*0x10*/ int <Version>k__BackingField;
                /*0x18*/ string <IssuerSerialNumber>k__BackingField;
                /*0x20*/ byte[] <EncryptedDigest>k__BackingField;

                /*0x7f2779c*/ SignerInfo(LipingShare.LCLib.Asn1Processor.Asn1Node n);
                /*0x7f2798c*/ int get_Version();
                /*0x7f27994*/ void set_Version(int value);
                /*0x7f2799c*/ void set_IssuerSerialNumber(string value);
                /*0x7f279a4*/ void set_EncryptedDigest(byte[] value);
            }

            class InvalidPKCS7Data : UnityEngine.Purchasing.Security.IAPSecurityException
            {
                /*0x7f25d14*/ InvalidPKCS7Data();
            }

            class UnsupportedSignerInfoVersion : UnityEngine.Purchasing.Security.IAPSecurityException
            {
                /*0x7f279ac*/ UnsupportedSignerInfoVersion();
            }

            class RSAKey
            {
                /*0x10*/ System.Security.Cryptography.RSACryptoServiceProvider <rsa>k__BackingField;

                /*0x7f271dc*/ RSAKey(LipingShare.LCLib.Asn1Processor.Asn1Node n);
                /*0x7f279b4*/ void set_rsa(System.Security.Cryptography.RSACryptoServiceProvider value);
                /*0x7f279bc*/ System.Security.Cryptography.RSACryptoServiceProvider ParseNode(LipingShare.LCLib.Asn1Processor.Asn1Node n);
                /*0x7f27c58*/ string ToXML(string modulus, string exponent);
            }

            class InvalidRSAData : UnityEngine.Purchasing.Security.IAPSecurityException
            {
                /*0x7f27d9c*/ InvalidRSAData();
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 2EF83B43314F8CD03190EEE30ECCF048DA37791237F27C62A579F23EACE9FD70;

    static /*0x7f26908*/ uint ComputeStringHash(string s);

    struct __StaticArrayInitTypeSize=32
    {
    }
}
