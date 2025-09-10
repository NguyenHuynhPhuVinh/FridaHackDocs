class <Module>
{
}

namespace LCLib
{
    namespace Asn1Processor
    {
        class Asn1Util
        {
            static /*0xf93250*/ int BytePrecision(ulong value);
            static /*0xf9327c*/ int DERLengthEncode(System.IO.Stream xdata, ulong length);
            static /*0xf93378*/ long DerLengthDecode(System.IO.Stream bt);
            /*0xf93474*/ Asn1Util();
        }
    }
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

            class Asn1Node : LipingShare.LCLib.Asn1Processor.IAsn1Node
            {
                static int indentStep = 3;
                static int defaultLineLen = 80;
                static int minLineLen = 60;
                static int k_EndOfStream = -1;
                static int k_InvalidIndeterminateContentLength = -1;
                static int k_IndefiniteLengthFooterSize = 2;
                static int TagLength = 1;
                static int BitStringUnusedFiledLength = 1;
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

                static /*0xf94408*/ long GetDescendantNodeCount(LipingShare.LCLib.Asn1Processor.Asn1Node node);
                static /*0xf976e0*/ LipingShare.LCLib.Asn1Processor.Asn1Node GetDecendantNodeByOid(string oid, LipingShare.LCLib.Asn1Processor.Asn1Node startNode);
                static /*0xf977fc*/ long ResetBranchDataLength(LipingShare.LCLib.Asn1Processor.Asn1Node node);
                static /*0xf979f0*/ void ResetDataLengthFieldWidth(LipingShare.LCLib.Asn1Processor.Asn1Node node);
                /*0xf9347c*/ Asn1Node(LipingShare.LCLib.Asn1Processor.Asn1Node parentNode, long dataOffset);
                /*0xf93fb4*/ Asn1Node();
                /*0xf93510*/ void Init();
                /*0xf9359c*/ string GetHexPrintingStr(LipingShare.LCLib.Asn1Processor.Asn1Node startNode, string baseLine, string lStr, int lineLen);
                /*0xf93c54*/ string FormatLineString(string lStr, int indent, int lineLen, string msg);
                /*0xf93a00*/ string FormatLineHexString(string lStr, int indent, int lineLen, string msg);
                /*0xf94020*/ bool get_IsIndefiniteLength();
                /*0xf94028*/ void set_IsIndefiniteLength(bool value);
                /*0xf94034*/ LipingShare.LCLib.Asn1Processor.Asn1Node Clone();
                /*0xf942bc*/ byte get_Tag();
                /*0xf942c4*/ void set_Tag(byte value);
                /*0xf942cc*/ byte get_MaskedTag();
                /*0xf942d8*/ bool LoadData(byte[] byteData);
                /*0xf94218*/ bool LoadData(System.IO.Stream xdata);
                /*0xf94648*/ byte[] GetRawData();
                /*0xf94754*/ bool get_IsEmptyData();
                /*0xf940ec*/ bool SaveData(System.IO.Stream xdata);
                /*0xf948a8*/ void ClearAll();
                /*0xf949e8*/ void AddChild(LipingShare.LCLib.Asn1Processor.Asn1Node xdata);
                /*0xf94a18*/ int InsertChild(LipingShare.LCLib.Asn1Processor.Asn1Node xdata, int index);
                /*0xf94a64*/ int InsertChild(LipingShare.LCLib.Asn1Processor.Asn1Node xdata, LipingShare.LCLib.Asn1Processor.Asn1Node indexNode);
                /*0xf94ad8*/ int InsertChildAfter(LipingShare.LCLib.Asn1Processor.Asn1Node xdata, LipingShare.LCLib.Asn1Processor.Asn1Node indexNode);
                /*0xf94b4c*/ int InsertChildAfter(LipingShare.LCLib.Asn1Processor.Asn1Node xdata, int index);
                /*0xf94b9c*/ LipingShare.LCLib.Asn1Processor.Asn1Node RemoveChild(int index);
                /*0xf94cc0*/ LipingShare.LCLib.Asn1Processor.Asn1Node GetLastChild();
                /*0xf94d6c*/ LipingShare.LCLib.Asn1Processor.Asn1Node RemoveChild(LipingShare.LCLib.Asn1Processor.Asn1Node node);
                /*0xf94490*/ long get_ChildNodeCount();
                /*0xf944bc*/ LipingShare.LCLib.Asn1Processor.Asn1Node GetChildNode(int index);
                /*0xf94da0*/ string get_TagName();
                /*0xf951d0*/ LipingShare.LCLib.Asn1Processor.Asn1Node get_ParentNode();
                /*0xf951d8*/ string GetText(LipingShare.LCLib.Asn1Processor.Asn1Node startNode, int lineLen);
                /*0xf967c4*/ string get_Path();
                /*0xf967cc*/ string GetDataStr(bool pureHexMode);
                /*0xf96b34*/ string GetLabel(uint mask);
                /*0xf972f0*/ long get_DataLength();
                /*0xf972f8*/ long get_LengthFieldBytes();
                /*0xf97300*/ byte[] get_Data();
                /*0xf97480*/ void set_Data(byte[] value);
                /*0xf9752c*/ long get_Deepness();
                /*0xf97534*/ long get_DataOffset();
                /*0xf9753c*/ byte get_UnusedBits();
                /*0xf97544*/ void set_UnusedBits(byte value);
                /*0xf9754c*/ LipingShare.LCLib.Asn1Processor.Asn1Node GetDescendantNodeByPath(string nodePath);
                /*0xf977e8*/ bool get_RequireRecalculatePar();
                /*0xf977f0*/ void set_RequireRecalculatePar(bool value);
                /*0xf9498c*/ void RecalculateTreePar();
                /*0xf978c8*/ void ResetChildNodePar(LipingShare.LCLib.Asn1Processor.Asn1Node xNode, long subOffset);
                /*0xf966ac*/ string GetListStr(LipingShare.LCLib.Asn1Processor.Asn1Node startNode, int lineLen);
                /*0xf937f4*/ string GetIndentStr(LipingShare.LCLib.Asn1Processor.Asn1Node startNode);
                /*0xf97aa8*/ bool GeneralDecode(System.IO.Stream xdata);
                /*0xf97ca0*/ bool AreTagsOk();
                /*0xf97d2c*/ bool GeneralDecodeKnownLengthWithChecks(System.IO.Stream xdata, long start, long nodeMaxLen);
                /*0xf97d68*/ bool IsGeneralStreamLengthOk(System.IO.Stream xdata, long start, long nodeMaxLen);
                /*0xf97dd4*/ bool GeneralDecodeKnownLength(System.IO.Stream xdata);
                /*0xf97e54*/ void ReadStreamDataDefiniteLength(System.IO.Stream xdata, int length);
                /*0xf97cd0*/ bool GeneralDecodeIndefiniteLength(System.IO.Stream xdata, long nodeMaxLen);
                /*0xf97ed8*/ bool ReadStreamDataIndefiniteLength(System.IO.Stream xdata, long nodeMaxLen);
                /*0xf97f50*/ long MeasureContentLength(System.IO.Stream xdata);
                /*0xf97fcc*/ void ReadMeasuredLengthDataFromStart(System.IO.Stream xdata, long startPosition, long length);
                /*0xf9807c*/ bool ListDecode(System.IO.Stream xdata);
                /*0xf982ec*/ bool ListDecodeKnownLengthWithChecks(System.IO.Stream xdata, long start, long childNodeMaxLen);
                /*0xf98308*/ bool IsListStreamLengthOk(System.IO.Stream xdata, long childNodeMaxLen);
                /*0xf98324*/ bool ListDecodeKnownLength(System.IO.Stream xdata, long start);
                /*0xf983c8*/ long CalculateListEncodeFieldBytesAndOffset(System.IO.Stream xdata, long start);
                /*0xf98414*/ bool HandleBitStringTag(System.IO.Stream xdata, ref long offset);
                /*0xf98484*/ bool ListDecodeKnownLengthInternal(System.IO.Stream xdata, long offset);
                /*0xf984b0*/ System.IO.Stream CreateAndPrepareListDecodeMemoryStreamKnownLength(System.IO.Stream xdata);
                /*0xf985cc*/ bool ListDecodeChildNodesWithKnownLength(System.IO.Stream secData, long offset);
                /*0xf98648*/ bool CreateAndAddChildNode(System.IO.Stream secData, ref long offset);
                /*0xf98268*/ bool ListDecodeIndefiniteLength(System.IO.Stream xdata, long start, long childNodeMaxLen);
                /*0xf98724*/ bool ListDecodeIndefiniteLengthInternal(System.IO.Stream xdata, long offset, long childNodeMaxLen);
                /*0xf987a0*/ bool ReadNextChildNodeOrEndFooterOfIndefiniteListClearIfInvalid(System.IO.Stream xdata, ref long offset, long childNodeMaxLen);
                /*0xf9882c*/ LipingShare.LCLib.Asn1Processor.Asn1EndOfIndefiniteLengthNodeType DetectEndOfIndefiniteListContents(System.IO.Stream xdata);
                /*0xf988a0*/ bool ReadNextChildNodeOfIndefiniteListClearIfInvalid(System.IO.Stream xdata, ref long offset, long childNodeMaxLen);
                /*0xf97484*/ void SetData(byte[] xdata);
                /*0xf94578*/ bool InternalLoadData(System.IO.Stream xdata);
                /*0xf98964*/ bool get_ParseEncapsulatedData();
                /*0xf9896c*/ void set_ParseEncapsulatedData(bool value);

                class TagTextMask
                {
                    static uint SHOW_OFFSET = 1;
                    static uint SHOW_DATA = 2;
                    static uint USE_HEX_OFFSET = 4;
                    static uint SHOW_TAG_NUMBER = 8;
                    static uint SHOW_PATH = 16;

                    /*0xf98aec*/ TagTextMask();
                }
            }

            class Asn1Parser
            {
                /*0x10*/ byte[] rawData;
                /*0x18*/ LipingShare.LCLib.Asn1Processor.Asn1Node rootNode;

                static /*0xf9920c*/ string GetNodeTextHeader(int lineLen);
                static /*0xf99334*/ string GetNodeText(LipingShare.LCLib.Asn1Processor.Asn1Node node, int lineLen);
                /*0xf98b2c*/ Asn1Parser();
                /*0xf98af4*/ bool get_ParseEncapsulatedData();
                /*0xf98b10*/ void set_ParseEncapsulatedData(bool value);
                /*0xf98b90*/ byte[] get_RawData();
                /*0xf98b98*/ void LoadData(string fileName);
                /*0xf98dfc*/ void LoadPemData(string fileName);
                /*0xf98cd0*/ void LoadData(System.IO.Stream stream);
                /*0xf9914c*/ void SaveData(string fileName);
                /*0xf991dc*/ LipingShare.LCLib.Asn1Processor.Asn1Node get_RootNode();
                /*0xf991e4*/ LipingShare.LCLib.Asn1Processor.Asn1Node GetNodeByPath(string nodePath);
                /*0xf991fc*/ LipingShare.LCLib.Asn1Processor.Asn1Node GetNodeByOid(string oid);
                /*0xf99328*/ string ToString();
            }

            class Asn1Tag
            {
                static byte TAG_MASK = 31;
                static byte TAG_END_OF_CONTENTS = 0;
                static byte BOOLEAN = 1;
                static byte INTEGER = 2;
                static byte BIT_STRING = 3;
                static byte OCTET_STRING = 4;
                static byte TAG_NULL = 5;
                static byte OBJECT_IDENTIFIER = 6;
                static byte OBJECT_DESCRIPTOR = 7;
                static byte EXTERNAL = 8;
                static byte REAL = 9;
                static byte ENUMERATED = 10;
                static byte UTF8_STRING = 12;
                static byte RELATIVE_OID = 13;
                static byte SEQUENCE = 16;
                static byte SET = 17;
                static byte NUMERIC_STRING = 18;
                static byte PRINTABLE_STRING = 19;
                static byte T61_STRING = 20;
                static byte VIDEOTEXT_STRING = 21;
                static byte IA5_STRING = 22;
                static byte UTC_TIME = 23;
                static byte GENERALIZED_TIME = 24;
                static byte GRAPHIC_STRING = 25;
                static byte VISIBLE_STRING = 26;
                static byte GENERAL_STRING = 27;
                static byte UNIVERSAL_STRING = 28;
                static byte BMPSTRING = 30;

                /*0xf99380*/ Asn1Tag();
            }

            class Asn1TagClasses
            {
                static byte CLASS_MASK = 192;
                static byte UNIVERSAL = 0;
                static byte CONSTRUCTED = 32;
                static byte APPLICATION = 64;
                static byte CONTEXT_SPECIFIC = 128;
                static byte PRIVATE = 192;

                /*0xf99388*/ Asn1TagClasses();
            }

            class Asn1Util
            {
                static string PemStartStr = "-----BEGIN";
                static string PemEndStr = "-----END";
                static /*0x0*/ char[] hexDigits;

                static /*0xf9a6ec*/ Asn1Util();
                static /*0xf99390*/ bool IsAsn1EncodedHexStr(string dataStr);
                static /*0xf969a0*/ string FormatString(string inStr, int lineLen, int groupLen);
                static /*0xf93f14*/ string GenStr(int len, char xch);
                static /*0xf9664c*/ long BytesToLong(byte[] bytes);
                static /*0xf96554*/ string BytesToString(byte[] bytes);
                static /*0xf997c4*/ byte[] StringToBytes(string msg);
                static /*0xf99874*/ bool IsEqual(byte[] source, byte[] target);
                static /*0xf93894*/ string ToHexString(byte[] bytes);
                static /*0xf998ec*/ bool IsValidHexDigits(char ch);
                static /*0xf999ac*/ byte GetHexDigitsVal(char ch);
                static /*0xf994c0*/ byte[] HexStrToBytes(string hexStr);
                static /*0xf99a6c*/ bool IsHexStr(string hexStr);
                static /*0xf98fb8*/ bool IsPemFormated(string pemStr);
                static /*0xf99e10*/ bool IsPemFormatedFile(string fileName);
                static /*0xf9909c*/ System.IO.Stream PemToStream(string pemStr);
                static /*0xf99b4c*/ byte[] PemToBytes(string pemStr);
                static /*0xf99fb8*/ string BytesToPem(byte[] data);
                static /*0xf9a2fc*/ string GetPemFileHeader(string fileName);
                static /*0xf9a4ac*/ string GetPemHeader(string pemStr);
                static /*0xf9a024*/ string BytesToPem(byte[] data, string pemHeader);
                static /*0xf9a678*/ int BitPrecision(ulong ivalue);
                static /*0xf9a6b8*/ int BytePrecision(ulong value);
                static /*0xf94774*/ int DERLengthEncode(System.IO.Stream xdata, ulong length);
                static /*0xf97bf0*/ long DerLengthDecode(System.IO.Stream bt, ref bool isIndefiniteLength);
                static /*0xf94df8*/ string GetTagName(byte tag);
                /*0xf9a6e4*/ Asn1Util();
            }

            interface IAsn1Node
            {
                bool LoadData(System.IO.Stream xdata);
                bool SaveData(System.IO.Stream xdata);
                LipingShare.LCLib.Asn1Processor.Asn1Node get_ParentNode();
                void AddChild(LipingShare.LCLib.Asn1Processor.Asn1Node xdata);
                int InsertChild(LipingShare.LCLib.Asn1Processor.Asn1Node xdata, int index);
                int InsertChild(LipingShare.LCLib.Asn1Processor.Asn1Node xdata, LipingShare.LCLib.Asn1Processor.Asn1Node indexNode);
                int InsertChildAfter(LipingShare.LCLib.Asn1Processor.Asn1Node xdata, int index);
                int InsertChildAfter(LipingShare.LCLib.Asn1Processor.Asn1Node xdata, LipingShare.LCLib.Asn1Processor.Asn1Node indexNode);
                LipingShare.LCLib.Asn1Processor.Asn1Node RemoveChild(int index);
                LipingShare.LCLib.Asn1Processor.Asn1Node RemoveChild(LipingShare.LCLib.Asn1Processor.Asn1Node node);
                long get_ChildNodeCount();
                LipingShare.LCLib.Asn1Processor.Asn1Node GetChildNode(int index);
                LipingShare.LCLib.Asn1Processor.Asn1Node GetDescendantNodeByPath(string nodePath);
                byte get_Tag();
                void set_Tag(byte value);
                byte get_MaskedTag();
                string get_TagName();
                long get_DataLength();
                long get_LengthFieldBytes();
                long get_DataOffset();
                byte get_UnusedBits();
                byte[] get_Data();
                void set_Data(byte[] value);
                bool get_ParseEncapsulatedData();
                void set_ParseEncapsulatedData(bool value);
                long get_Deepness();
                string get_Path();
                string GetText(LipingShare.LCLib.Asn1Processor.Asn1Node startNode, int lineLen);
                string GetDataStr(bool pureHexMode);
                string GetLabel(uint mask);
                LipingShare.LCLib.Asn1Processor.Asn1Node Clone();
                void ClearAll();
            }

            class Oid
            {
                static /*0x0*/ System.Collections.Specialized.StringDictionary oidDictionary;

                /*0xf9649c*/ Oid();
                /*0xf964a4*/ string GetOidName(string inOidStr);
                /*0xf9a780*/ byte[] Encode(string oidStr);
                /*0xf9723c*/ string Decode(byte[] data);
                /*0xf9a898*/ void Encode(System.IO.Stream bt, string oidStr);
                /*0xf9ab98*/ string Decode(System.IO.Stream bt);
                /*0xf9aa7c*/ void EncodeValue(System.IO.Stream bt, ulong v);
                /*0xf9ae00*/ int DecodeValue(System.IO.Stream bt, ref ulong v);
            }

            class RelativeOid : LipingShare.LCLib.Asn1Processor.Oid
            {
                /*0xf9654c*/ RelativeOid();
                /*0xf9ae5c*/ void Encode(System.IO.Stream bt, string oidStr);
                /*0xf9afb0*/ string Decode(System.IO.Stream bt);
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
            class AppleValidator
            {
                /*0x10*/ UnityEngine.Purchasing.Security.X509Cert cert;
                /*0x18*/ UnityEngine.Purchasing.Security.AppleReceiptParser parser;

                /*0xf9b1b8*/ AppleValidator(byte[] appleRootCertificate);
                /*0xf9b448*/ UnityEngine.Purchasing.Security.AppleReceipt Validate(byte[] receiptData);
            }

            class AppleReceiptParser
            {
                static string k_AppleReceiptKey = "k_AppleReceiptKey";
                static string k_PKCS7Key = "k_PKCS7Key";
                static string k_ReceiptBytesKey = "k_ReceiptBytesKey";
                static /*0x0*/ System.Collections.Generic.Dictionary<string, object> _mostRecentReceiptData;

                static /*0xf9caa4*/ AppleReceiptParser();
                static /*0xf9c00c*/ System.Globalization.CultureInfo PushInvariantCultureOnThread();
                static /*0xf9c554*/ void PopCultureOffThread(System.Globalization.CultureInfo originalCulture);
                static /*0xf9c9bc*/ System.DateTime TryParseDateTimeNode(LipingShare.LCLib.Asn1Processor.Asn1Node node);
                static bool ArrayEquals<T>(T[] a, T[] b);
                /*0xf9b260*/ AppleReceiptParser();
                /*0xf9bff4*/ UnityEngine.Purchasing.Security.AppleReceipt Parse(byte[] receiptData);
                /*0xf9b4d8*/ UnityEngine.Purchasing.Security.AppleReceipt Parse(byte[] receiptData, ref UnityEngine.Purchasing.Security.PKCS7 receipt);
                /*0xf9c0d0*/ UnityEngine.Purchasing.Security.AppleReceipt ParseReceipt(LipingShare.LCLib.Asn1Processor.Asn1Node data);
                /*0xf9c584*/ LipingShare.LCLib.Asn1Processor.Asn1Node GetSetNode(LipingShare.LCLib.Asn1Processor.Asn1Node data);
                /*0xf9c5e0*/ UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt ParseInAppReceipt(LipingShare.LCLib.Asn1Processor.Asn1Node inApp);
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

                /*0xf9cba0*/ DistinguishedName(LipingShare.LCLib.Asn1Processor.Asn1Node n);
                /*0xf9cb30*/ string get_Country();
                /*0xf9cb38*/ void set_Country(string value);
                /*0xf9cb40*/ string get_Organization();
                /*0xf9cb48*/ void set_Organization(string value);
                /*0xf9cb50*/ string get_OrganizationalUnit();
                /*0xf9cb58*/ void set_OrganizationalUnit(string value);
                /*0xf9cb60*/ string get_Dnq();
                /*0xf9cb68*/ void set_Dnq(string value);
                /*0xf9cb70*/ string get_State();
                /*0xf9cb78*/ void set_State(string value);
                /*0xf9cb80*/ string get_CommonName();
                /*0xf9cb88*/ void set_CommonName(string value);
                /*0xf9cb90*/ string get_SerialNumber();
                /*0xf9cb98*/ void set_SerialNumber(string value);
                /*0xf9d134*/ bool Equals(UnityEngine.Purchasing.Security.DistinguishedName n2);
                /*0xf9d1d8*/ string ToString();
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

                /*0xf9d480*/ X509Cert(LipingShare.LCLib.Asn1Processor.Asn1Node n);
                /*0xf9b268*/ X509Cert(byte[] data);
                /*0xf9d3fc*/ string get_SerialNumber();
                /*0xf9d404*/ void set_SerialNumber(string value);
                /*0xf9d40c*/ System.DateTime get_ValidAfter();
                /*0xf9d414*/ void set_ValidAfter(System.DateTime value);
                /*0xf9d41c*/ System.DateTime get_ValidBefore();
                /*0xf9d424*/ void set_ValidBefore(System.DateTime value);
                /*0xf9d42c*/ UnityEngine.Purchasing.Security.RSAKey get_PubKey();
                /*0xf9d434*/ void set_PubKey(UnityEngine.Purchasing.Security.RSAKey value);
                /*0xf9d43c*/ bool get_SelfSigned();
                /*0xf9d444*/ void set_SelfSigned(bool value);
                /*0xf9d450*/ UnityEngine.Purchasing.Security.DistinguishedName get_Subject();
                /*0xf9d458*/ void set_Subject(UnityEngine.Purchasing.Security.DistinguishedName value);
                /*0xf9d460*/ UnityEngine.Purchasing.Security.DistinguishedName get_Issuer();
                /*0xf9d468*/ void set_Issuer(UnityEngine.Purchasing.Security.DistinguishedName value);
                /*0xf9d470*/ LipingShare.LCLib.Asn1Processor.Asn1Node get_Signature();
                /*0xf9d478*/ void set_Signature(LipingShare.LCLib.Asn1Processor.Asn1Node value);
                /*0xf9d7c8*/ bool CheckCertTime(System.DateTime time);
                /*0xf9d818*/ bool CheckSignature(UnityEngine.Purchasing.Security.X509Cert signer);
                /*0xf9d91c*/ bool CheckSignature256(UnityEngine.Purchasing.Security.X509Cert signer);
                /*0xf9d4ac*/ void ParseNode(LipingShare.LCLib.Asn1Processor.Asn1Node root);
                /*0xf9da74*/ System.DateTime ParseTime(LipingShare.LCLib.Asn1Processor.Asn1Node n);
            }

            class InvalidTimeFormat : UnityEngine.Purchasing.Security.IAPSecurityException
            {
                /*0xf9dcdc*/ InvalidTimeFormat();
            }

            class InvalidX509Data : UnityEngine.Purchasing.Security.IAPSecurityException
            {
                /*0xf9d0b0*/ InvalidX509Data();
            }

            class StoreNotSupportedException : UnityEngine.Purchasing.Security.IAPSecurityException
            {
                /*0xf9dce4*/ StoreNotSupportedException(string message);
            }

            class InvalidBundleIdException : UnityEngine.Purchasing.Security.IAPSecurityException
            {
                /*0xf9dcec*/ InvalidBundleIdException();
            }

            class InvalidReceiptDataException : UnityEngine.Purchasing.Security.IAPSecurityException
            {
                /*0xf9dcf4*/ InvalidReceiptDataException();
            }

            class MissingStoreSecretException : UnityEngine.Purchasing.Security.IAPSecurityException
            {
                /*0xf9dcfc*/ MissingStoreSecretException(string message);
            }

            class InvalidPublicKeyException : UnityEngine.Purchasing.Security.IAPSecurityException
            {
                /*0xf9dd04*/ InvalidPublicKeyException(string message);
            }

            class GenericValidationException : UnityEngine.Purchasing.Security.IAPSecurityException
            {
                /*0xf9dd0c*/ GenericValidationException(string message);
            }

            class CrossPlatformValidator
            {
                /*0x10*/ UnityEngine.Purchasing.Security.GooglePlayValidator google;
                /*0x18*/ UnityEngine.Purchasing.Security.AppleValidator apple;
                /*0x20*/ string googleBundleId;
                /*0x28*/ string appleBundleId;

                /*0xf9dd14*/ CrossPlatformValidator(byte[] googlePublicKey, byte[] appleRootCert, string appBundleId);
                /*0xf9def4*/ CrossPlatformValidator(byte[] googlePublicKey, byte[] appleRootCert, byte[] unityChannelPublicKey_not_used, string appBundleId);
                /*0xf9defc*/ CrossPlatformValidator(byte[] googlePublicKey, byte[] appleRootCert, string googleBundleId, string appleBundleId);
                /*0xf9dd20*/ CrossPlatformValidator(byte[] googlePublicKey, byte[] appleRootCert, byte[] unityChannelPublicKey_not_used, string googleBundleId, string appleBundleId, string xiaomiBundleId_not_used);
                /*0xf9df80*/ UnityEngine.Purchasing.Security.IPurchaseReceipt[] Validate(string unityIAPReceipt);
            }

            enum GooglePurchaseState
            {
                Purchased = 0,
                Cancelled = 1,
                Refunded = 2,
            }

            class GooglePlayReceipt : UnityEngine.Purchasing.Security.IPurchaseReceipt
            {
                /*0x10*/ string <productID>k__BackingField;
                /*0x18*/ string <orderID>k__BackingField;
                /*0x20*/ string <packageName>k__BackingField;
                /*0x28*/ string <purchaseToken>k__BackingField;
                /*0x30*/ System.DateTime <purchaseDate>k__BackingField;
                /*0x38*/ UnityEngine.Purchasing.Security.GooglePurchaseState <purchaseState>k__BackingField;

                /*0xf9eafc*/ GooglePlayReceipt(string productID, string orderID, string packageName, string purchaseToken, System.DateTime purchaseTime, UnityEngine.Purchasing.Security.GooglePurchaseState purchaseState);
                /*0xf9ea94*/ string get_productID();
                /*0xf9ea9c*/ void set_productID(string value);
                /*0xf9eaa4*/ string get_orderID();
                /*0xf9eaac*/ void set_orderID(string value);
                /*0xf9eab4*/ string get_transactionID();
                /*0xf9eabc*/ string get_packageName();
                /*0xf9eac4*/ void set_packageName(string value);
                /*0xf9eacc*/ string get_purchaseToken();
                /*0xf9ead4*/ void set_purchaseToken(string value);
                /*0xf9eadc*/ System.DateTime get_purchaseDate();
                /*0xf9eae4*/ void set_purchaseDate(System.DateTime value);
                /*0xf9eaec*/ UnityEngine.Purchasing.Security.GooglePurchaseState get_purchaseState();
                /*0xf9eaf4*/ void set_purchaseState(UnityEngine.Purchasing.Security.GooglePurchaseState value);
            }

            class GooglePlayValidator
            {
                /*0x10*/ UnityEngine.Purchasing.Security.RSAKey key;

                /*0xf9df08*/ GooglePlayValidator(byte[] rsaKey);
                /*0xf9e6e4*/ UnityEngine.Purchasing.Security.GooglePlayReceipt Validate(string receipt, string signature);
            }

            class Obfuscator
            {
                static /*0xf9ed38*/ byte[] DeObfuscate(byte[] data, int[] order, int key);

                class <>c__DisplayClass0_0
                {
                    /*0x10*/ int key;

                    /*0xf9efdc*/ <>c__DisplayClass0_0();
                    /*0xf9efe4*/ byte <DeObfuscate>b__0(byte x);
                }
            }

            class PKCS7
            {
                /*0x10*/ LipingShare.LCLib.Asn1Processor.Asn1Node root;
                /*0x18*/ LipingShare.LCLib.Asn1Processor.Asn1Node <data>k__BackingField;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.Purchasing.Security.SignerInfo> <sinfos>k__BackingField;
                /*0x28*/ System.Collections.Generic.List<UnityEngine.Purchasing.Security.X509Cert> <certChain>k__BackingField;
                /*0x30*/ bool validStructure;

                static /*0xf9f020*/ UnityEngine.Purchasing.Security.PKCS7 Load(byte[] data);
                /*0xf9c0a4*/ PKCS7(LipingShare.LCLib.Asn1Processor.Asn1Node node);
                /*0xf9eff0*/ LipingShare.LCLib.Asn1Processor.Asn1Node get_data();
                /*0xf9eff8*/ void set_data(LipingShare.LCLib.Asn1Processor.Asn1Node value);
                /*0xf9f000*/ System.Collections.Generic.List<UnityEngine.Purchasing.Security.SignerInfo> get_sinfos();
                /*0xf9f008*/ void set_sinfos(System.Collections.Generic.List<UnityEngine.Purchasing.Security.SignerInfo> value);
                /*0xf9f010*/ System.Collections.Generic.List<UnityEngine.Purchasing.Security.X509Cert> get_certChain();
                /*0xf9f018*/ void set_certChain(System.Collections.Generic.List<UnityEngine.Purchasing.Security.X509Cert> value);
                /*0xf9bb80*/ bool Verify(UnityEngine.Purchasing.Security.X509Cert cert, System.DateTime certificateCreationTime);
                /*0xf9f758*/ bool IsStoreKitSimulatorData();
                /*0xf9f7a0*/ bool ValidateStorekitSimulatorCertRoot(UnityEngine.Purchasing.Security.X509Cert root, UnityEngine.Purchasing.Security.X509Cert cert);
                /*0xf9f7b4*/ bool ValidateChain(UnityEngine.Purchasing.Security.X509Cert root, UnityEngine.Purchasing.Security.X509Cert cert, System.DateTime certificateCreationTime);
                /*0xf9f230*/ void CheckStructure();
            }

            class SignerInfo
            {
                /*0x10*/ int <Version>k__BackingField;
                /*0x18*/ string <IssuerSerialNumber>k__BackingField;
                /*0x20*/ byte[] <EncryptedDigest>k__BackingField;

                /*0xf9fa18*/ SignerInfo(LipingShare.LCLib.Asn1Processor.Asn1Node n);
                /*0xf9fc04*/ int get_Version();
                /*0xf9fc0c*/ void set_Version(int value);
                /*0xf9fc14*/ string get_IssuerSerialNumber();
                /*0xf9fc1c*/ void set_IssuerSerialNumber(string value);
                /*0xf9fc24*/ byte[] get_EncryptedDigest();
                /*0xf9fc2c*/ void set_EncryptedDigest(byte[] value);
            }

            class InvalidPKCS7Data : UnityEngine.Purchasing.Security.IAPSecurityException
            {
                /*0xf9c57c*/ InvalidPKCS7Data();
            }

            class UnsupportedSignerInfoVersion : UnityEngine.Purchasing.Security.IAPSecurityException
            {
                /*0xf9fc34*/ UnsupportedSignerInfoVersion();
            }

            class RSAKey
            {
                /*0x10*/ System.Security.Cryptography.RSACryptoServiceProvider <rsa>k__BackingField;

                /*0xf9dca8*/ RSAKey(LipingShare.LCLib.Asn1Processor.Asn1Node n);
                /*0xf9eb54*/ RSAKey(byte[] data);
                /*0xf9fc3c*/ System.Security.Cryptography.RSACryptoServiceProvider get_rsa();
                /*0xf9fc44*/ void set_rsa(System.Security.Cryptography.RSACryptoServiceProvider value);
                /*0xf9d884*/ bool Verify(byte[] message, byte[] signature);
                /*0xf9d988*/ bool Verify256(byte[] message, byte[] signature);
                /*0xf9fc4c*/ System.Security.Cryptography.RSACryptoServiceProvider ParseNode(LipingShare.LCLib.Asn1Processor.Asn1Node n);
                /*0xf9fef0*/ string ToXML(string modulus, string exponent);
            }

            class InvalidRSAData : UnityEngine.Purchasing.Security.IAPSecurityException
            {
                /*0xfa0078*/ InvalidRSAData();
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 2EF83B43314F8CD03190EEE30ECCF048DA37791237F27C62A579F23EACE9FD70;

    static /*0xf9d0b8*/ uint ComputeStringHash(string s);

    struct __StaticArrayInitTypeSize=32
    {
    }
}
