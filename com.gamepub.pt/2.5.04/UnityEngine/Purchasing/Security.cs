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

                static /*0x2a9bef8*/ long ResetBranchDataLength(LipingShare.LCLib.Asn1Processor.Asn1Node node);
                static /*0x2a9c0fc*/ void ResetDataLengthFieldWidth(LipingShare.LCLib.Asn1Processor.Asn1Node node);
                /*0x2a98f04*/ Asn1Node(LipingShare.LCLib.Asn1Processor.Asn1Node parentNode, long dataOffset);
                /*0x2a99b88*/ Asn1Node();
                /*0x2a98f9c*/ void Init();
                /*0x2a9902c*/ string GetHexPrintingStr(LipingShare.LCLib.Asn1Processor.Asn1Node startNode, string baseLine, string lStr, int lineLen);
                /*0x2a99788*/ string FormatLineString(string lStr, int indent, int lineLen, string msg);
                /*0x2a994d8*/ string FormatLineHexString(string lStr, int indent, int lineLen, string msg);
                /*0x2a99bf8*/ bool get_IsIndefiniteLength();
                /*0x2a99c00*/ byte get_Tag();
                /*0x2a99c08*/ byte get_MaskedTag();
                /*0x2a99c14*/ bool LoadData(System.IO.Stream xdata);
                /*0x2a99db0*/ bool SaveData(System.IO.Stream xdata);
                /*0x2a9a030*/ void ClearAll();
                /*0x2a9a120*/ void AddChild(LipingShare.LCLib.Asn1Processor.Asn1Node xdata);
                /*0x2a9a15c*/ LipingShare.LCLib.Asn1Processor.Asn1Node GetLastChild();
                /*0x2a985cc*/ long get_ChildNodeCount();
                /*0x2a9866c*/ LipingShare.LCLib.Asn1Processor.Asn1Node GetChildNode(int index);
                /*0x2a9a20c*/ string get_TagName();
                /*0x2a9a670*/ LipingShare.LCLib.Asn1Processor.Asn1Node get_ParentNode();
                /*0x2a9a678*/ string GetText(LipingShare.LCLib.Asn1Processor.Asn1Node startNode, int lineLen);
                /*0x2a9bac4*/ string GetDataStr(bool pureHexMode);
                /*0x2a9bedc*/ long get_DataLength();
                /*0x2a98734*/ byte[] get_Data();
                /*0x2a9bee4*/ long get_Deepness();
                /*0x2a9beec*/ void set_RequireRecalculatePar(bool value);
                /*0x2a99d58*/ void RecalculateTreePar();
                /*0x2a9bfd0*/ void ResetChildNodePar(LipingShare.LCLib.Asn1Processor.Asn1Node xNode, long subOffset);
                /*0x2a9b9a8*/ string GetListStr(LipingShare.LCLib.Asn1Processor.Asn1Node startNode, int lineLen);
                /*0x2a99290*/ string GetIndentStr(LipingShare.LCLib.Asn1Processor.Asn1Node startNode);
                /*0x2a9c1c8*/ bool GeneralDecode(System.IO.Stream xdata);
                /*0x2a9c3d0*/ bool AreTagsOk();
                /*0x2a9c468*/ bool GeneralDecodeKnownLengthWithChecks(System.IO.Stream xdata, long start, long nodeMaxLen);
                /*0x2a9c4a8*/ bool IsGeneralStreamLengthOk(System.IO.Stream xdata, long start, long nodeMaxLen);
                /*0x2a9c520*/ bool GeneralDecodeKnownLength(System.IO.Stream xdata);
                /*0x2a9c5a4*/ void ReadStreamDataDefiniteLength(System.IO.Stream xdata, int length);
                /*0x2a9c400*/ bool GeneralDecodeIndefiniteLength(System.IO.Stream xdata, long nodeMaxLen);
                /*0x2a9c62c*/ bool ReadStreamDataIndefiniteLength(System.IO.Stream xdata, long nodeMaxLen);
                /*0x2a9c6a8*/ long MeasureContentLength(System.IO.Stream xdata);
                /*0x2a9c728*/ void ReadMeasuredLengthDataFromStart(System.IO.Stream xdata, long startPosition, long length);
                /*0x2a9c7e4*/ bool ListDecode(System.IO.Stream xdata);
                /*0x2a9ca74*/ bool ListDecodeKnownLengthWithChecks(System.IO.Stream xdata, long start, long childNodeMaxLen);
                /*0x2a9ca90*/ bool IsListStreamLengthOk(System.IO.Stream xdata, long childNodeMaxLen);
                /*0x2a9caac*/ bool ListDecodeKnownLength(System.IO.Stream xdata, long start);
                /*0x2a9cb54*/ long CalculateListEncodeFieldBytesAndOffset(System.IO.Stream xdata, long start);
                /*0x2a9cba4*/ bool HandleBitStringTag(System.IO.Stream xdata, ref long offset);
                /*0x2a9cc18*/ bool ListDecodeKnownLengthInternal(System.IO.Stream xdata, long offset);
                /*0x2a9cc48*/ System.IO.Stream CreateAndPrepareListDecodeMemoryStreamKnownLength(System.IO.Stream xdata);
                /*0x2a9cd64*/ bool ListDecodeChildNodesWithKnownLength(System.IO.Stream secData, long offset);
                /*0x2a9cde4*/ bool CreateAndAddChildNode(System.IO.Stream secData, ref long offset);
                /*0x2a9c9dc*/ bool ListDecodeIndefiniteLength(System.IO.Stream xdata, long start, long childNodeMaxLen);
                /*0x2a9cecc*/ bool ListDecodeIndefiniteLengthInternal(System.IO.Stream xdata, long offset, long childNodeMaxLen);
                /*0x2a9cf54*/ bool ReadNextChildNodeOrEndFooterOfIndefiniteListClearIfInvalid(System.IO.Stream xdata, ref long offset, long childNodeMaxLen);
                /*0x2a9cfe4*/ LipingShare.LCLib.Asn1Processor.Asn1EndOfIndefiniteLengthNodeType DetectEndOfIndefiniteListContents(System.IO.Stream xdata);
                /*0x2a9d05c*/ bool ReadNextChildNodeOfIndefiniteListClearIfInvalid(System.IO.Stream xdata, ref long offset, long childNodeMaxLen);
                /*0x2a99c88*/ bool InternalLoadData(System.IO.Stream xdata);
            }

            class Asn1Parser
            {
                /*0x10*/ byte[] rawData;
                /*0x18*/ LipingShare.LCLib.Asn1Processor.Asn1Node rootNode;

                static /*0x2a9d128*/ string GetNodeTextHeader(int lineLen);
                static /*0x2a9d2a0*/ string GetNodeText(LipingShare.LCLib.Asn1Processor.Asn1Node node, int lineLen);
                /*0x2a97f7c*/ Asn1Parser();
                /*0x2a97fdc*/ void LoadData(System.IO.Stream stream);
                /*0x2a9d120*/ LipingShare.LCLib.Asn1Processor.Asn1Node get_RootNode();
                /*0x2a9d294*/ string ToString();
            }

            class Asn1Util
            {
                static /*0x0*/ char[] hexDigits;

                static /*0x2a9d324*/ Asn1Util();
                static /*0x2a9bcb8*/ string FormatString(string inStr, int lineLen, int groupLen);
                static /*0x2a99adc*/ string GenStr(int len, char xch);
                static /*0x2a988bc*/ long BytesToLong(byte[] bytes);
                static /*0x2a9b88c*/ string BytesToString(byte[] bytes);
                static /*0x2a99334*/ string ToHexString(byte[] bytes);
                static /*0x2a9d2f8*/ int BytePrecision(ulong value);
                static /*0x2a99ee8*/ int DERLengthEncode(System.IO.Stream xdata, ulong length);
                static /*0x2a9c31c*/ long DerLengthDecode(System.IO.Stream bt, ref bool isIndefiniteLength);
                static /*0x2a9a270*/ string GetTagName(byte tag);
            }

            class Oid
            {
                static /*0x0*/ System.Collections.Specialized.StringDictionary oidDictionary;

                /*0x2a9b7cc*/ Oid();
                /*0x2a9b7d4*/ string GetOidName(string inOidStr);
                /*0x2a9d974*/ string Decode(byte[] data);
                /*0x2a9dd10*/ string Decode(System.IO.Stream bt);
                /*0x2a9df7c*/ int DecodeValue(System.IO.Stream bt, ref ulong v);
            }

            class RelativeOid : LipingShare.LCLib.Asn1Processor.Oid
            {
                /*0x2a9b884*/ RelativeOid();
                /*0x2a9eb44*/ string Decode(System.IO.Stream bt);
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

                static /*0x2a98e7c*/ AppleReceiptParser();
                static /*0x2a97ed8*/ System.Globalization.CultureInfo PushInvariantCultureOnThread();
                static /*0x2a98598*/ void PopCultureOffThread(System.Globalization.CultureInfo originalCulture);
                static /*0x2a98d74*/ System.DateTime TryParseDateTimeNode(LipingShare.LCLib.Asn1Processor.Asn1Node node);
                static bool ArrayEquals<T>(T[] a, T[] b);
                /*0x2a98e74*/ AppleReceiptParser();
                /*0x2a9783c*/ UnityEngine.Purchasing.Security.AppleReceipt Parse(byte[] receiptData);
                /*0x2a97860*/ UnityEngine.Purchasing.Security.AppleReceipt Parse(byte[] receiptData, ref UnityEngine.Purchasing.Security.PKCS7 receipt);
                /*0x2a98138*/ UnityEngine.Purchasing.Security.AppleReceipt ParseReceipt(LipingShare.LCLib.Asn1Processor.Asn1Node data);
                /*0x2a98604*/ LipingShare.LCLib.Asn1Processor.Asn1Node GetSetNode(LipingShare.LCLib.Asn1Processor.Asn1Node data);
                /*0x2a98928*/ UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt ParseInAppReceipt(LipingShare.LCLib.Asn1Processor.Asn1Node inApp);
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

                /*0x2a9d41c*/ DistinguishedName(LipingShare.LCLib.Asn1Processor.Asn1Node n);
                /*0x2a9d3b4*/ string get_Country();
                /*0x2a9d3bc*/ void set_Country(string value);
                /*0x2a9d3c4*/ string get_Organization();
                /*0x2a9d3cc*/ void set_Organization(string value);
                /*0x2a9d3d4*/ string get_OrganizationalUnit();
                /*0x2a9d3dc*/ void set_OrganizationalUnit(string value);
                /*0x2a9d3e4*/ string get_Dnq();
                /*0x2a9d3ec*/ void set_Dnq(string value);
                /*0x2a9d3f4*/ string get_State();
                /*0x2a9d3fc*/ void set_State(string value);
                /*0x2a9d404*/ string get_CommonName();
                /*0x2a9d40c*/ void set_CommonName(string value);
                /*0x2a9d414*/ void set_SerialNumber(string value);
                /*0x2a9da28*/ bool Equals(UnityEngine.Purchasing.Security.DistinguishedName n2);
                /*0x2a9dad0*/ string ToString();
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

                /*0x2a9e4a0*/ X509Cert(LipingShare.LCLib.Asn1Processor.Asn1Node n);
                /*0x2a9ed78*/ void set_SerialNumber(string value);
                /*0x2a9ed80*/ void set_ValidAfter(System.DateTime value);
                /*0x2a9ed88*/ void set_ValidBefore(System.DateTime value);
                /*0x2a9ed90*/ void set_PubKey(UnityEngine.Purchasing.Security.RSAKey value);
                /*0x2a9ed98*/ void set_SelfSigned(bool value);
                /*0x2a9eda4*/ UnityEngine.Purchasing.Security.DistinguishedName get_Subject();
                /*0x2a9edac*/ void set_Subject(UnityEngine.Purchasing.Security.DistinguishedName value);
                /*0x2a9edb4*/ UnityEngine.Purchasing.Security.DistinguishedName get_Issuer();
                /*0x2a9edbc*/ void set_Issuer(UnityEngine.Purchasing.Security.DistinguishedName value);
                /*0x2a9edc4*/ void set_Signature(LipingShare.LCLib.Asn1Processor.Asn1Node value);
                /*0x2a9edcc*/ void ParseNode(LipingShare.LCLib.Asn1Processor.Asn1Node root);
                /*0x2a9f0e8*/ System.DateTime ParseTime(LipingShare.LCLib.Asn1Processor.Asn1Node n);
            }

            class InvalidTimeFormat : UnityEngine.Purchasing.Security.IAPSecurityException
            {
                /*0x2a9dd08*/ InvalidTimeFormat();
            }

            class InvalidX509Data : UnityEngine.Purchasing.Security.IAPSecurityException
            {
                /*0x2a9d96c*/ InvalidX509Data();
            }

            class PKCS7
            {
                /*0x10*/ LipingShare.LCLib.Asn1Processor.Asn1Node root;
                /*0x18*/ LipingShare.LCLib.Asn1Processor.Asn1Node <data>k__BackingField;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.Purchasing.Security.SignerInfo> <sinfos>k__BackingField;
                /*0x28*/ System.Collections.Generic.List<UnityEngine.Purchasing.Security.X509Cert> <certChain>k__BackingField;
                /*0x30*/ bool validStructure;

                /*0x2a98108*/ PKCS7(LipingShare.LCLib.Asn1Processor.Asn1Node node);
                /*0x2a9dfe4*/ LipingShare.LCLib.Asn1Processor.Asn1Node get_data();
                /*0x2a9dfec*/ void set_data(LipingShare.LCLib.Asn1Processor.Asn1Node value);
                /*0x2a9dff4*/ System.Collections.Generic.List<UnityEngine.Purchasing.Security.SignerInfo> get_sinfos();
                /*0x2a9dffc*/ void set_sinfos(System.Collections.Generic.List<UnityEngine.Purchasing.Security.SignerInfo> value);
                /*0x2a9e004*/ System.Collections.Generic.List<UnityEngine.Purchasing.Security.X509Cert> get_certChain();
                /*0x2a9e00c*/ void set_certChain(System.Collections.Generic.List<UnityEngine.Purchasing.Security.X509Cert> value);
                /*0x2a9e014*/ void CheckStructure();
            }

            class SignerInfo
            {
                /*0x10*/ int <Version>k__BackingField;
                /*0x18*/ string <IssuerSerialNumber>k__BackingField;
                /*0x20*/ byte[] <EncryptedDigest>k__BackingField;

                /*0x2a9e4d0*/ SignerInfo(LipingShare.LCLib.Asn1Processor.Asn1Node n);
                /*0x2a9ed50*/ int get_Version();
                /*0x2a9ed58*/ void set_Version(int value);
                /*0x2a9ed60*/ void set_IssuerSerialNumber(string value);
                /*0x2a9ed68*/ void set_EncryptedDigest(byte[] value);
            }

            class InvalidPKCS7Data : UnityEngine.Purchasing.Security.IAPSecurityException
            {
                /*0x2a985fc*/ InvalidPKCS7Data();
            }

            class UnsupportedSignerInfoVersion : UnityEngine.Purchasing.Security.IAPSecurityException
            {
                /*0x2a9ed70*/ UnsupportedSignerInfoVersion();
            }

            class RSAKey
            {
                /*0x10*/ System.Security.Cryptography.RSACryptoServiceProvider <rsa>k__BackingField;

                /*0x2a9e6d0*/ RSAKey(LipingShare.LCLib.Asn1Processor.Asn1Node n);
                /*0x2a9e6c8*/ void set_rsa(System.Security.Cryptography.RSACryptoServiceProvider value);
                /*0x2a9e708*/ System.Security.Cryptography.RSACryptoServiceProvider ParseNode(LipingShare.LCLib.Asn1Processor.Asn1Node n);
                /*0x2a9e9b0*/ string ToXML(string modulus, string exponent);
            }

            class InvalidRSAData : UnityEngine.Purchasing.Security.IAPSecurityException
            {
                /*0x2a9dd00*/ InvalidRSAData();
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 2EF83B43314F8CD03190EEE30ECCF048DA37791237F27C62A579F23EACE9FD70;

    static /*0x2a977bc*/ uint ComputeStringHash(string s);

    struct __StaticArrayInitTypeSize=32
    {
    }
}
