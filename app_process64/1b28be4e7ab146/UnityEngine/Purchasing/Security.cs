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

                static /*0x7f3a924*/ long ResetBranchDataLength(LipingShare.LCLib.Asn1Processor.Asn1Node node);
                static /*0x7f3ab2c*/ void ResetDataLengthFieldWidth(LipingShare.LCLib.Asn1Processor.Asn1Node node);
                /*0x7f377a0*/ Asn1Node(LipingShare.LCLib.Asn1Processor.Asn1Node parentNode, long dataOffset);
                /*0x7f38218*/ Asn1Node();
                /*0x7f37848*/ void Init();
                /*0x7f37900*/ string GetHexPrintingStr(LipingShare.LCLib.Asn1Processor.Asn1Node startNode, string baseLine, string lStr, int lineLen);
                /*0x7f37f24*/ string FormatLineString(string lStr, int indent, int lineLen, string msg);
                /*0x7f37d2c*/ string FormatLineHexString(string lStr, int indent, int lineLen, string msg);
                /*0x7f3828c*/ bool get_IsIndefiniteLength();
                /*0x7f38294*/ byte get_Tag();
                /*0x7f3829c*/ byte get_MaskedTag();
                /*0x7f382a8*/ bool LoadData(System.IO.Stream xdata);
                /*0x7f38420*/ bool SaveData(System.IO.Stream xdata);
                /*0x7f38764*/ void ClearAll();
                /*0x7f388b4*/ void AddChild(LipingShare.LCLib.Asn1Processor.Asn1Node xdata);
                /*0x7f388e4*/ LipingShare.LCLib.Asn1Processor.Asn1Node GetLastChild();
                /*0x7f3854c*/ long get_ChildNodeCount();
                /*0x7f386a8*/ LipingShare.LCLib.Asn1Processor.Asn1Node GetChildNode(int index);
                /*0x7f38990*/ string get_TagName();
                /*0x7f38de8*/ LipingShare.LCLib.Asn1Processor.Asn1Node get_ParentNode();
                /*0x7f38df0*/ string GetText(LipingShare.LCLib.Asn1Processor.Asn1Node startNode, int lineLen);
                /*0x7f3a42c*/ string GetDataStr(bool pureHexMode);
                /*0x7f3a780*/ long get_DataLength();
                /*0x7f3a788*/ byte[] get_Data();
                /*0x7f3a910*/ long get_Deepness();
                /*0x7f3a918*/ void set_RequireRecalculatePar(bool value);
                /*0x7f38858*/ void RecalculateTreePar();
                /*0x7f3a9f0*/ void ResetChildNodePar(LipingShare.LCLib.Asn1Processor.Asn1Node xNode, long subOffset);
                /*0x7f3a314*/ string GetListStr(LipingShare.LCLib.Asn1Processor.Asn1Node startNode, int lineLen);
                /*0x7f37b20*/ string GetIndentStr(LipingShare.LCLib.Asn1Processor.Asn1Node startNode);
                /*0x7f3abe4*/ bool GeneralDecode(System.IO.Stream xdata);
                /*0x7f3ade8*/ bool AreTagsOk();
                /*0x7f3ae74*/ bool GeneralDecodeKnownLengthWithChecks(System.IO.Stream xdata, long start, long nodeMaxLen);
                /*0x7f3aeb0*/ bool IsGeneralStreamLengthOk(System.IO.Stream xdata, long start, long nodeMaxLen);
                /*0x7f3af20*/ bool GeneralDecodeKnownLength(System.IO.Stream xdata);
                /*0x7f3afa0*/ void ReadStreamDataDefiniteLength(System.IO.Stream xdata, int length);
                /*0x7f3ae18*/ bool GeneralDecodeIndefiniteLength(System.IO.Stream xdata, long nodeMaxLen);
                /*0x7f3b030*/ bool ReadStreamDataIndefiniteLength(System.IO.Stream xdata, long nodeMaxLen);
                /*0x7f3b0bc*/ long MeasureContentLength(System.IO.Stream xdata);
                /*0x7f3b150*/ void ReadMeasuredLengthDataFromStart(System.IO.Stream xdata, long startPosition, long length);
                /*0x7f3b20c*/ bool ListDecode(System.IO.Stream xdata);
                /*0x7f3b48c*/ bool ListDecodeKnownLengthWithChecks(System.IO.Stream xdata, long start, long childNodeMaxLen);
                /*0x7f3b4a8*/ bool IsListStreamLengthOk(System.IO.Stream xdata, long childNodeMaxLen);
                /*0x7f3b4c4*/ bool ListDecodeKnownLength(System.IO.Stream xdata, long start);
                /*0x7f3b56c*/ long CalculateListEncodeFieldBytesAndOffset(System.IO.Stream xdata, long start);
                /*0x7f3b5bc*/ bool HandleBitStringTag(System.IO.Stream xdata, ref long offset);
                /*0x7f3b628*/ bool ListDecodeKnownLengthInternal(System.IO.Stream xdata, long offset);
                /*0x7f3b654*/ System.IO.Stream CreateAndPrepareListDecodeMemoryStreamKnownLength(System.IO.Stream xdata);
                /*0x7f3b770*/ bool ListDecodeChildNodesWithKnownLength(System.IO.Stream secData, long offset);
                /*0x7f3b7f0*/ bool CreateAndAddChildNode(System.IO.Stream secData, ref long offset);
                /*0x7f3b404*/ bool ListDecodeIndefiniteLength(System.IO.Stream xdata, long start, long childNodeMaxLen);
                /*0x7f3b8d8*/ bool ListDecodeIndefiniteLengthInternal(System.IO.Stream xdata, long offset, long childNodeMaxLen);
                /*0x7f3b954*/ bool ReadNextChildNodeOrEndFooterOfIndefiniteListClearIfInvalid(System.IO.Stream xdata, ref long offset, long childNodeMaxLen);
                /*0x7f3b9e0*/ LipingShare.LCLib.Asn1Processor.Asn1EndOfIndefiniteLengthNodeType DetectEndOfIndefiniteListContents(System.IO.Stream xdata);
                /*0x7f3ba54*/ bool ReadNextChildNodeOfIndefiniteListClearIfInvalid(System.IO.Stream xdata, ref long offset, long childNodeMaxLen);
                /*0x7f3834c*/ bool InternalLoadData(System.IO.Stream xdata);
            }

            class Asn1Parser
            {
                /*0x10*/ byte[] rawData;
                /*0x18*/ LipingShare.LCLib.Asn1Processor.Asn1Node rootNode;

                static /*0x7f3bcc0*/ string GetNodeTextHeader(int lineLen);
                static /*0x7f3bdf8*/ string GetNodeText(LipingShare.LCLib.Asn1Processor.Asn1Node node, int lineLen);
                /*0x7f3bb1c*/ Asn1Parser();
                /*0x7f3bb84*/ void LoadData(System.IO.Stream stream);
                /*0x7f3bcb8*/ LipingShare.LCLib.Asn1Processor.Asn1Node get_RootNode();
                /*0x7f3bdec*/ string ToString();
            }

            class Asn1Util
            {
                static /*0x0*/ char[] hexDigits;

                static /*0x7f3be70*/ Asn1Util();
                static /*0x7f3a5ec*/ string FormatString(string inStr, int lineLen, int groupLen);
                static /*0x7f38178*/ string GenStr(int len, char xch);
                static /*0x7f3a2bc*/ long BytesToLong(byte[] bytes);
                static /*0x7f3a1c4*/ string BytesToString(byte[] bytes);
                static /*0x7f37bc0*/ string ToHexString(byte[] bytes);
                static /*0x7f3be44*/ int BytePrecision(ulong value);
                static /*0x7f38578*/ int DERLengthEncode(System.IO.Stream xdata, ulong length);
                static /*0x7f3ad34*/ long DerLengthDecode(System.IO.Stream bt, ref bool isIndefiniteLength);
                static /*0x7f389e8*/ string GetTagName(byte tag);
            }

            class Oid
            {
                static /*0x0*/ System.Collections.Specialized.StringDictionary oidDictionary;

                /*0x7f3a100*/ Oid();
                /*0x7f3a108*/ string GetOidName(string inOidStr);
                /*0x7f3bf10*/ string Decode(byte[] data);
                /*0x7f3bfc4*/ string Decode(System.IO.Stream bt);
                /*0x7f3c228*/ int DecodeValue(System.IO.Stream bt, ref ulong v);
            }

            class RelativeOid : LipingShare.LCLib.Asn1Processor.Oid
            {
                /*0x7f3a1bc*/ RelativeOid();
                /*0x7f3c284*/ string Decode(System.IO.Stream bt);
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

                static /*0x7f3d6c4*/ AppleReceiptParser();
                static /*0x7f3cb68*/ System.Globalization.CultureInfo PushInvariantCultureOnThread();
                static /*0x7f3d11c*/ void PopCultureOffThread(System.Globalization.CultureInfo originalCulture);
                static /*0x7f3d5d4*/ System.DateTime TryParseDateTimeNode(LipingShare.LCLib.Asn1Processor.Asn1Node node);
                static /*0x3825b78*/ bool ArrayEquals<T>(T[] a, T[] b);
                /*0x7f3d6bc*/ AppleReceiptParser();
                /*0x7f3c48c*/ UnityEngine.Purchasing.Security.AppleReceipt Parse(byte[] receiptData);
                /*0x7f3c4a4*/ UnityEngine.Purchasing.Security.AppleReceipt Parse(byte[] receiptData, ref UnityEngine.Purchasing.Security.PKCS7 receipt);
                /*0x7f3cc38*/ UnityEngine.Purchasing.Security.AppleReceipt ParseReceipt(LipingShare.LCLib.Asn1Processor.Asn1Node data);
                /*0x7f3d14c*/ LipingShare.LCLib.Asn1Processor.Asn1Node GetSetNode(LipingShare.LCLib.Asn1Processor.Asn1Node data);
                /*0x7f3d1a8*/ UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt ParseInAppReceipt(LipingShare.LCLib.Asn1Processor.Asn1Node inApp);
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

                /*0x7f3d7c4*/ DistinguishedName(LipingShare.LCLib.Asn1Processor.Asn1Node n);
                /*0x7f3d75c*/ string get_Country();
                /*0x7f3d764*/ void set_Country(string value);
                /*0x7f3d76c*/ string get_Organization();
                /*0x7f3d774*/ void set_Organization(string value);
                /*0x7f3d77c*/ string get_OrganizationalUnit();
                /*0x7f3d784*/ void set_OrganizationalUnit(string value);
                /*0x7f3d78c*/ string get_Dnq();
                /*0x7f3d794*/ void set_Dnq(string value);
                /*0x7f3d79c*/ string get_State();
                /*0x7f3d7a4*/ void set_State(string value);
                /*0x7f3d7ac*/ string get_CommonName();
                /*0x7f3d7b4*/ void set_CommonName(string value);
                /*0x7f3d7bc*/ void set_SerialNumber(string value);
                /*0x7f3ddb4*/ bool Equals(UnityEngine.Purchasing.Security.DistinguishedName n2);
                /*0x7f3de58*/ string ToString();
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

                /*0x7f3e058*/ X509Cert(LipingShare.LCLib.Asn1Processor.Asn1Node n);
                /*0x7f3e004*/ void set_SerialNumber(string value);
                /*0x7f3e00c*/ void set_ValidAfter(System.DateTime value);
                /*0x7f3e014*/ void set_ValidBefore(System.DateTime value);
                /*0x7f3e01c*/ void set_PubKey(UnityEngine.Purchasing.Security.RSAKey value);
                /*0x7f3e024*/ void set_SelfSigned(bool value);
                /*0x7f3e030*/ UnityEngine.Purchasing.Security.DistinguishedName get_Subject();
                /*0x7f3e038*/ void set_Subject(UnityEngine.Purchasing.Security.DistinguishedName value);
                /*0x7f3e040*/ UnityEngine.Purchasing.Security.DistinguishedName get_Issuer();
                /*0x7f3e048*/ void set_Issuer(UnityEngine.Purchasing.Security.DistinguishedName value);
                /*0x7f3e050*/ void set_Signature(LipingShare.LCLib.Asn1Processor.Asn1Node value);
                /*0x7f3e084*/ void ParseNode(LipingShare.LCLib.Asn1Processor.Asn1Node root);
                /*0x7f3e3e0*/ System.DateTime ParseTime(LipingShare.LCLib.Asn1Processor.Asn1Node n);
            }

            class InvalidTimeFormat : UnityEngine.Purchasing.Security.IAPSecurityException
            {
                /*0x7f3e648*/ InvalidTimeFormat();
            }

            class InvalidX509Data : UnityEngine.Purchasing.Security.IAPSecurityException
            {
                /*0x7f3dd30*/ InvalidX509Data();
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

                /*0x7f3cc00*/ PKCS7(LipingShare.LCLib.Asn1Processor.Asn1Node node);
                /*0x7f3e650*/ LipingShare.LCLib.Asn1Processor.Asn1Node get_data();
                /*0x7f3e658*/ void set_data(LipingShare.LCLib.Asn1Processor.Asn1Node value);
                /*0x7f3e660*/ System.Collections.Generic.List<UnityEngine.Purchasing.Security.SignerInfo> get_sinfos();
                /*0x7f3e668*/ void set_sinfos(System.Collections.Generic.List<UnityEngine.Purchasing.Security.SignerInfo> value);
                /*0x7f3e670*/ System.Collections.Generic.List<UnityEngine.Purchasing.Security.X509Cert> get_certChain();
                /*0x7f3e678*/ void set_certChain(System.Collections.Generic.List<UnityEngine.Purchasing.Security.X509Cert> value);
                /*0x7f3e680*/ void CheckStructure();
            }

            class SignerInfo
            {
                /*0x10*/ int <Version>k__BackingField;
                /*0x18*/ string <IssuerSerialNumber>k__BackingField;
                /*0x20*/ byte[] <EncryptedDigest>k__BackingField;

                /*0x7f3ebcc*/ SignerInfo(LipingShare.LCLib.Asn1Processor.Asn1Node n);
                /*0x7f3edbc*/ int get_Version();
                /*0x7f3edc4*/ void set_Version(int value);
                /*0x7f3edcc*/ void set_IssuerSerialNumber(string value);
                /*0x7f3edd4*/ void set_EncryptedDigest(byte[] value);
            }

            class InvalidPKCS7Data : UnityEngine.Purchasing.Security.IAPSecurityException
            {
                /*0x7f3d144*/ InvalidPKCS7Data();
            }

            class UnsupportedSignerInfoVersion : UnityEngine.Purchasing.Security.IAPSecurityException
            {
                /*0x7f3eddc*/ UnsupportedSignerInfoVersion();
            }

            class RSAKey
            {
                /*0x10*/ System.Security.Cryptography.RSACryptoServiceProvider <rsa>k__BackingField;

                /*0x7f3e60c*/ RSAKey(LipingShare.LCLib.Asn1Processor.Asn1Node n);
                /*0x7f3ede4*/ void set_rsa(System.Security.Cryptography.RSACryptoServiceProvider value);
                /*0x7f3edec*/ System.Security.Cryptography.RSACryptoServiceProvider ParseNode(LipingShare.LCLib.Asn1Processor.Asn1Node n);
                /*0x7f3f088*/ string ToXML(string modulus, string exponent);
            }

            class InvalidRSAData : UnityEngine.Purchasing.Security.IAPSecurityException
            {
                /*0x7f3f1cc*/ InvalidRSAData();
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 2EF83B43314F8CD03190EEE30ECCF048DA37791237F27C62A579F23EACE9FD70;

    static /*0x7f3dd38*/ uint ComputeStringHash(string s);

    struct __StaticArrayInitTypeSize=32
    {
    }
}
