class <Module>
{
}

class SR
{
    static /*0x7635ea0*/ string GetString(string name, object[] args);
    static /*0x7635f10*/ string GetString(System.Globalization.CultureInfo culture, string name, object[] args);
}

namespace Microsoft
{
    namespace CSharp
    {
        class CodeDomProvider
        {
            /*0x7635f18*/ CodeDomProvider();
        }

        class CSharpCodeProvider : Microsoft.CSharp.CodeDomProvider
        {
            /*0x7635f20*/ CSharpCodeProvider();
        }
    }
}

namespace System
{
    class MonoTODOAttribute : System.Attribute
    {
        /*0x7635f28*/ MonoTODOAttribute();
    }

    class LocalAppContextSwitches
    {
        static /*0x0*/ bool IgnoreEmptyKeySequences;
        static /*0x1*/ bool DontThrowOnInvalidSurrogatePairs;
    }

    namespace Xml
    {
        class AsyncHelper
        {
            static /*0x0*/ System.Threading.Tasks.Task DoneTask;
            static /*0x8*/ System.Threading.Tasks.Task<bool> DoneTaskTrue;
            static /*0x10*/ System.Threading.Tasks.Task<bool> DoneTaskFalse;
            static /*0x18*/ System.Threading.Tasks.Task<int> DoneTaskZero;

            static /*0x7635f30*/ AsyncHelper();
        }

        class Base64Decoder : System.Xml.IncrementalReadDecoder
        {
            static /*0x0*/ string CharsBase64;
            static /*0x8*/ byte[] MapBase64;
            /*0x10*/ byte[] buffer;
            /*0x18*/ int startIndex;
            /*0x1c*/ int curIndex;
            /*0x20*/ int endIndex;
            /*0x24*/ int bits;
            /*0x28*/ int bitsFilled;

            static /*0x76367a8*/ Base64Decoder();
            static /*0x7636680*/ byte[] ConstructMapBase64();
            /*0x76367a0*/ Base64Decoder();
            /*0x7636048*/ int get_DecodedCount();
            /*0x7636054*/ bool get_IsFull();
            /*0x7636064*/ int Decode(char[] chars, int startPos, int len);
            /*0x7636448*/ int Decode(string str, int startPos, int len);
            /*0x76365a8*/ void Reset();
            /*0x76365b0*/ void SetNextOutputBuffer(System.Array buffer, int index, int count);
            /*0x76361b0*/ void Decode(char* pChars, char* pCharsEndPos, byte* pBytes, byte* pBytesEndPos, ref int charsDecoded, ref int bytesDecoded);
        }

        class Base64Encoder
        {
            /*0x10*/ byte[] leftOverBytes;
            /*0x18*/ int leftOverBytesCount;
            /*0x20*/ char[] charsLine;

            /*0x7636830*/ Base64Encoder();
            void WriteChars(char[] chars, int index, int count);
            /*0x7636894*/ void Encode(byte[] buffer, int index, int count);
            /*0x7636bec*/ void Flush();
        }

        class XmlRawWriterBase64Encoder : System.Xml.Base64Encoder
        {
            /*0x28*/ System.Xml.XmlRawWriter rawWriter;

            /*0x7636c94*/ XmlRawWriterBase64Encoder(System.Xml.XmlRawWriter rawWriter);
            /*0x7636cc0*/ void WriteChars(char[] chars, int index, int count);
        }

        class XmlTextWriterBase64Encoder : System.Xml.Base64Encoder
        {
            /*0x28*/ System.Xml.XmlTextEncoder xmlTextEncoder;

            /*0x7636ce4*/ XmlTextWriterBase64Encoder(System.Xml.XmlTextEncoder xmlTextEncoder);
            /*0x7636d10*/ void WriteChars(char[] chars, int index, int count);
        }

        class BinHexDecoder : System.Xml.IncrementalReadDecoder
        {
            /*0x10*/ byte[] buffer;
            /*0x18*/ int startIndex;
            /*0x1c*/ int curIndex;
            /*0x20*/ int endIndex;
            /*0x24*/ bool hasHalfByteCached;
            /*0x25*/ byte cachedHalfByte;

            static /*0x763729c*/ byte[] Decode(char[] chars, bool allowOddChars);
            static /*0x7636e94*/ void Decode(char* pChars, char* pCharsEndPos, byte* pBytes, byte* pBytesEndPos, ref bool hasHalfByteCached, ref byte cachedHalfByte, ref int charsDecoded, ref int bytesDecoded);
            /*0x763747c*/ BinHexDecoder();
            /*0x7636d2c*/ int get_DecodedCount();
            /*0x7636d38*/ bool get_IsFull();
            /*0x7636d48*/ int Decode(char[] chars, int startPos, int len);
            /*0x763705c*/ int Decode(string str, int startPos, int len);
            /*0x76371c4*/ void Reset();
            /*0x76371cc*/ void SetNextOutputBuffer(System.Array buffer, int index, int count);
        }

        class BinHexEncoder
        {
            static /*0x7637484*/ void Encode(byte[] buffer, int index, int count, System.Xml.XmlWriter writer);
            static /*0x7637744*/ string Encode(byte[] inArray, int offsetIn, int count);
            static /*0x7637620*/ int Encode(byte[] inArray, int offsetIn, int count, char[] outArray);
        }

        enum BinXmlToken
        {
            Error = 0,
            NotImpl = -2,
            EOF = -1,
            XmlDecl = 254,
            Encoding = 253,
            DocType = 252,
            System = 251,
            Public = 250,
            Subset = 249,
            Element = 248,
            EndElem = 247,
            Attr = 246,
            EndAttrs = 245,
            PI = 244,
            Comment = 243,
            CData = 242,
            EndCData = 241,
            Name = 240,
            QName = 239,
            XmlText = 237,
            Nest = 236,
            EndNest = 235,
            Extn = 234,
            NmFlush = 233,
            SQL_BIT = 6,
            SQL_TINYINT = 7,
            SQL_SMALLINT = 1,
            SQL_INT = 2,
            SQL_BIGINT = 8,
            SQL_REAL = 3,
            SQL_FLOAT = 4,
            SQL_MONEY = 5,
            SQL_SMALLMONEY = 20,
            SQL_DATETIME = 18,
            SQL_SMALLDATETIME = 19,
            SQL_DECIMAL = 10,
            SQL_NUMERIC = 11,
            SQL_UUID = 9,
            SQL_VARBINARY = 15,
            SQL_BINARY = 12,
            SQL_IMAGE = 23,
            SQL_CHAR = 13,
            SQL_VARCHAR = 16,
            SQL_TEXT = 22,
            SQL_NVARCHAR = 17,
            SQL_NCHAR = 14,
            SQL_NTEXT = 24,
            SQL_UDT = 27,
            XSD_KATMAI_DATE = 127,
            XSD_KATMAI_DATETIME = 126,
            XSD_KATMAI_TIME = 125,
            XSD_KATMAI_DATEOFFSET = 124,
            XSD_KATMAI_DATETIMEOFFSET = 123,
            XSD_KATMAI_TIMEOFFSET = 122,
            XSD_BOOLEAN = 134,
            XSD_TIME = 129,
            XSD_DATETIME = 130,
            XSD_DATE = 131,
            XSD_BINHEX = 132,
            XSD_BASE64 = 133,
            XSD_DECIMAL = 135,
            XSD_BYTE = 136,
            XSD_UNSIGNEDSHORT = 137,
            XSD_UNSIGNEDINT = 138,
            XSD_UNSIGNEDLONG = 139,
            XSD_QNAME = 140,
        }

        struct BinXmlSqlDecimal
        {
            static /*0x0*/ byte NUMERIC_MAX_PRECISION;
            static /*0x1*/ byte MaxPrecision;
            static /*0x2*/ byte MaxScale;
            static /*0x4*/ int x_cNumeMax;
            static /*0x8*/ long x_lInt32Base;
            static /*0x10*/ ulong x_ulInt32Base;
            static /*0x18*/ ulong x_ulInt32BaseForMod;
            static /*0x20*/ ulong x_llMax;
            static /*0x28*/ double DUINT_BASE;
            static /*0x30*/ double DUINT_BASE2;
            static /*0x38*/ double DUINT_BASE3;
            static /*0x40*/ uint[] x_rgulShiftBase;
            static /*0x48*/ byte[] rgCLenFromPrec;
            /*0x10*/ byte m_bLen;
            /*0x11*/ byte m_bPrec;
            /*0x12*/ byte m_bScale;
            /*0x13*/ byte m_bSign;
            /*0x14*/ uint m_data1;
            /*0x18*/ uint m_data2;
            /*0x1c*/ uint m_data3;
            /*0x20*/ uint m_data4;

            static /*0x7638280*/ BinXmlSqlDecimal();
            static /*0x7637b30*/ uint UIntFromByteArray(byte[] data, int offset);
            static /*0x7637d6c*/ void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, ref uint iulR);
            static /*0x7637e44*/ void MpNormalize(uint[] rgulU, ref int ciulU);
            static /*0x7637e9c*/ char ChFromDigit(uint uiDigit);
            /*0x7637894*/ BinXmlSqlDecimal(byte[] data, int offset, bool trim);
            /*0x7637884*/ bool get_IsPositive();
            /*0x7637ea4*/ decimal ToDecimal();
            /*0x7637ba4*/ void TrimTrailingZeros();
            /*0x7637fbc*/ string ToString();
        }

        struct BinXmlSqlMoney
        {
            /*0x10*/ long data;

            /*0x76383c4*/ BinXmlSqlMoney(int v);
            /*0x76383d0*/ BinXmlSqlMoney(long v);
            /*0x76383d8*/ decimal ToDecimal();
            /*0x763843c*/ string ToString();
        }

        class BinXmlDateTime
        {
            static /*0x0*/ int[] KatmaiTimeScaleMultiplicator;
            static /*0x8*/ double SQLTicksPerMillisecond;
            static /*0x10*/ int SQLTicksPerSecond;
            static /*0x14*/ int SQLTicksPerMinute;
            static /*0x18*/ int SQLTicksPerHour;
            static /*0x1c*/ int SQLTicksPerDay;

            static /*0x763aba4*/ BinXmlDateTime();
            static /*0x763852c*/ void Write2Dig(System.Text.StringBuilder sb, int val);
            static /*0x7638588*/ void Write4DigNeg(System.Text.StringBuilder sb, int val);
            static /*0x763862c*/ void Write3Dec(System.Text.StringBuilder sb, int val);
            static /*0x76386d8*/ void WriteDate(System.Text.StringBuilder sb, int yr, int mnth, int day);
            static /*0x763878c*/ void WriteTime(System.Text.StringBuilder sb, int hr, int min, int sec, int ms);
            static /*0x7638878*/ void WriteTimeFullPrecision(System.Text.StringBuilder sb, int hr, int min, int sec, int fraction);
            static /*0x7638a6c*/ void WriteTimeZone(System.Text.StringBuilder sb, System.TimeSpan zone);
            static /*0x7638b68*/ void WriteTimeZone(System.Text.StringBuilder sb, bool negTimeZone, int hr, int min);
            static /*0x7638c3c*/ void BreakDownXsdDateTime(long val, ref int yr, ref int mnth, ref int day, ref int hr, ref int min, ref int sec, ref int ms);
            static /*0x7638e0c*/ void BreakDownXsdDate(long val, ref int yr, ref int mnth, ref int day, ref bool negTimeZone, ref int hr, ref int min);
            static /*0x7638f7c*/ void BreakDownXsdTime(long val, ref int hr, ref int min, ref int sec, ref int ms);
            static /*0x7639084*/ string XsdDateTimeToString(long val);
            static /*0x763918c*/ System.DateTime XsdDateTimeToDateTime(long val);
            static /*0x7639240*/ string XsdDateToString(long val);
            static /*0x7639324*/ System.DateTime XsdDateToDateTime(long val);
            static /*0x7639470*/ string XsdTimeToString(long val);
            static /*0x7639544*/ System.DateTime XsdTimeToDateTime(long val);
            static /*0x76395e8*/ string SqlDateTimeToString(int dateticks, uint timeticks);
            static /*0x7639728*/ System.DateTime SqlDateTimeToDateTime(int dateticks, uint timeticks);
            static /*0x763981c*/ string SqlSmallDateTimeToString(short dateticks, ushort timeticks);
            static /*0x7639910*/ System.DateTime SqlSmallDateTimeToDateTime(short dateticks, ushort timeticks);
            static /*0x7639984*/ System.DateTime XsdKatmaiDateToDateTime(byte[] data, int offset);
            static /*0x7639a78*/ System.DateTime XsdKatmaiDateTimeToDateTime(byte[] data, int offset);
            static /*0x7639d30*/ System.DateTime XsdKatmaiTimeToDateTime(byte[] data, int offset);
            static /*0x7639d94*/ System.DateTime XsdKatmaiDateOffsetToDateTime(byte[] data, int offset);
            static /*0x7639ea4*/ System.DateTime XsdKatmaiDateTimeOffsetToDateTime(byte[] data, int offset);
            static /*0x7639ff8*/ System.DateTime XsdKatmaiTimeOffsetToDateTime(byte[] data, int offset);
            static /*0x7639e40*/ System.DateTimeOffset XsdKatmaiDateOffsetToDateTimeOffset(byte[] data, int offset);
            static /*0x7639f50*/ System.DateTimeOffset XsdKatmaiDateTimeOffsetToDateTimeOffset(byte[] data, int offset);
            static /*0x763a0a4*/ System.DateTimeOffset XsdKatmaiTimeOffsetToDateTimeOffset(byte[] data, int offset);
            static /*0x763a15c*/ string XsdKatmaiDateToString(byte[] data, int offset);
            static /*0x763a278*/ string XsdKatmaiDateTimeToString(byte[] data, int offset);
            static /*0x763a50c*/ string XsdKatmaiTimeToString(byte[] data, int offset);
            static /*0x763a63c*/ string XsdKatmaiDateOffsetToString(byte[] data, int offset);
            static /*0x763a778*/ string XsdKatmaiDateTimeOffsetToString(byte[] data, int offset);
            static /*0x763aa54*/ string XsdKatmaiTimeOffsetToString(byte[] data, int offset);
            static /*0x7639a04*/ long GetKatmaiDateTicks(byte[] data, ref int pos);
            static /*0x7639b08*/ long GetKatmaiTimeTicks(byte[] data, ref int pos);
            static /*0x763a108*/ long GetKatmaiTimeZoneTicks(byte[] data, int pos);
            static /*0x763a3f8*/ int GetFractions(System.DateTime dt);
            static /*0x763a918*/ int GetFractions(System.DateTimeOffset dt);
        }

        class XmlSqlBinaryReader : System.Xml.XmlReader, System.Xml.IXmlNamespaceResolver
        {
            static /*0x0*/ System.Type TypeOfObject;
            static /*0x8*/ System.Type TypeOfString;
            static /*0x10*/ System.Type[] TokenTypeMap;
            static /*0x18*/ byte[] XsdKatmaiTimeScaleToValueLengthMap;
            static /*0x20*/ System.Xml.ReadState[] ScanState2ReadState;
            /*0x10*/ System.IO.Stream inStrm;
            /*0x18*/ byte[] data;
            /*0x20*/ int pos;
            /*0x24*/ int mark;
            /*0x28*/ int end;
            /*0x30*/ long offset;
            /*0x38*/ bool eof;
            /*0x39*/ bool sniffed;
            /*0x3a*/ bool isEmpty;
            /*0x3c*/ int docState;
            /*0x40*/ System.Xml.XmlSqlBinaryReader.SymbolTables symbolTables;
            /*0x60*/ System.Xml.XmlNameTable xnt;
            /*0x68*/ bool xntFromSettings;
            /*0x70*/ string xml;
            /*0x78*/ string xmlns;
            /*0x80*/ string nsxmlns;
            /*0x88*/ string baseUri;
            /*0x90*/ System.Xml.XmlSqlBinaryReader.ScanState state;
            /*0x94*/ System.Xml.XmlNodeType nodetype;
            /*0x98*/ System.Xml.BinXmlToken token;
            /*0x9c*/ int attrIndex;
            /*0xa0*/ System.Xml.XmlSqlBinaryReader.QName qnameOther;
            /*0xb8*/ System.Xml.XmlSqlBinaryReader.QName qnameElement;
            /*0xd0*/ System.Xml.XmlNodeType parentNodeType;
            /*0xd8*/ System.Xml.XmlSqlBinaryReader.ElemInfo[] elementStack;
            /*0xe0*/ int elemDepth;
            /*0xe8*/ System.Xml.XmlSqlBinaryReader.AttrInfo[] attributes;
            /*0xf0*/ int[] attrHashTbl;
            /*0xf8*/ int attrCount;
            /*0xfc*/ int posAfterAttrs;
            /*0x100*/ bool xmlspacePreserve;
            /*0x104*/ int tokLen;
            /*0x108*/ int tokDataPos;
            /*0x10c*/ bool hasTypedValue;
            /*0x110*/ System.Type valueType;
            /*0x118*/ string stringValue;
            /*0x120*/ System.Collections.Generic.Dictionary<string, System.Xml.XmlSqlBinaryReader.NamespaceDecl> namespaces;
            /*0x128*/ System.Xml.XmlSqlBinaryReader.NestedBinXml prevNameInfo;
            /*0x130*/ System.Xml.XmlReader textXmlReader;
            /*0x138*/ bool closeInput;
            /*0x139*/ bool checkCharacters;
            /*0x13a*/ bool ignoreWhitespace;
            /*0x13b*/ bool ignorePIs;
            /*0x13c*/ bool ignoreComments;
            /*0x140*/ System.Xml.DtdProcessing dtdProcessing;
            /*0x148*/ System.Xml.SecureStringHasher hasher;
            /*0x150*/ System.Xml.XmlCharType xmlCharType;
            /*0x158*/ System.Text.Encoding unicode;
            /*0x160*/ byte version;

            static /*0x7646fcc*/ XmlSqlBinaryReader();
            /*0x763ac68*/ XmlSqlBinaryReader(System.IO.Stream stream, byte[] data, int len, string baseUri, bool closeInput, System.Xml.XmlReaderSettings settings);
            /*0x763bdf4*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x763bf10*/ System.Xml.XmlNodeType get_NodeType();
            /*0x763bf18*/ string get_LocalName();
            /*0x763bf20*/ string get_NamespaceURI();
            /*0x763bf28*/ string get_Prefix();
            /*0x763bf30*/ string get_Value();
            /*0x763cbec*/ int get_Depth();
            /*0x763cc90*/ string get_BaseURI();
            /*0x763cc98*/ bool get_IsEmptyElement();
            /*0x763ccbc*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x763cd3c*/ string get_XmlLang();
            /*0x763cdcc*/ System.Type get_ValueType();
            /*0x763cdd4*/ int get_AttributeCount();
            /*0x763ce28*/ string GetAttribute(string name, string ns);
            /*0x763cf84*/ string GetAttribute(string name);
            /*0x763d0d4*/ string GetAttribute(int i);
            /*0x763d164*/ bool MoveToAttribute(string name, string ns);
            /*0x763d340*/ bool MoveToAttribute(string name);
            /*0x763d3bc*/ void MoveToAttribute(int i);
            /*0x763d460*/ bool MoveToFirstAttribute();
            /*0x763d4d8*/ bool MoveToNextAttribute();
            /*0x763d55c*/ bool MoveToElement();
            /*0x763d62c*/ bool get_EOF();
            /*0x763d63c*/ bool ReadAttributeValue();
            /*0x763d988*/ void Close();
            /*0x763da28*/ System.Xml.XmlNameTable get_NameTable();
            /*0x763da30*/ string LookupNamespace(string prefix);
            /*0x763dae4*/ void ResolveEntity();
            /*0x763db1c*/ System.Xml.ReadState get_ReadState();
            /*0x763db9c*/ bool Read();
            /*0x763e5ac*/ bool SetupContentAsXXX(string name);
            /*0x763e79c*/ int FinishContentAsXXX(int origPos);
            /*0x763e8e8*/ bool ReadContentAsBoolean();
            /*0x763ed68*/ System.DateTime ReadContentAsDateTime();
            /*0x763f5b0*/ double ReadContentAsDouble();
            /*0x763fbfc*/ float ReadContentAsFloat();
            /*0x764010c*/ decimal ReadContentAsDecimal();
            /*0x7640830*/ int ReadContentAsInt();
            /*0x7640f78*/ long ReadContentAsLong();
            /*0x764149c*/ object ReadContentAsObject();
            /*0x7641e98*/ object ReadContentAs(System.Type returnType, System.Xml.IXmlNamespaceResolver namespaceResolver);
            /*0x7642a28*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x7642dd0*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            /*0x7642f6c*/ void VerifyVersion(int requiredVersion, System.Xml.BinXmlToken token);
            /*0x763b1b4*/ void AddInitNamespace(string prefix, string uri);
            /*0x7642fec*/ void AddName();
            /*0x76431d8*/ void AddQName();
            /*0x7643504*/ void NameFlush();
            /*0x7643554*/ void SkipExtn();
            /*0x7643628*/ int ReadQNameRef();
            /*0x7643478*/ int ReadNameRef();
            /*0x76436b4*/ bool FillAllowEOF();
            /*0x76438f4*/ void Fill_(int require);
            /*0x764360c*/ void Fill(int require);
            /*0x76439e0*/ byte ReadByte();
            /*0x7643a3c*/ ushort ReadUShort();
            /*0x76435e0*/ int ParseMB32();
            /*0x7643ab0*/ int ParseMB32_(byte b);
            /*0x7643b48*/ int ParseMB32(int pos);
            /*0x7643c34*/ int ParseMB64();
            /*0x7643c60*/ System.Xml.BinXmlToken PeekToken();
            /*0x7643cc8*/ System.Xml.BinXmlToken ReadToken();
            /*0x7643d38*/ System.Xml.BinXmlToken NextToken2(System.Xml.BinXmlToken token);
            /*0x7643db0*/ System.Xml.BinXmlToken NextToken1();
            /*0x7643e28*/ System.Xml.BinXmlToken NextToken();
            /*0x7643e8c*/ System.Xml.BinXmlToken PeekNextToken();
            /*0x763d7b4*/ System.Xml.BinXmlToken RescanNextToken();
            /*0x7643114*/ string ParseText();
            /*0x7643eb4*/ int ScanText(ref int start);
            /*0x763c03c*/ string GetString(int pos, int cch);
            /*0x7643f6c*/ string GetStringAligned(byte[] data, int offset, int cch);
            /*0x763cac8*/ string GetAttributeText(int i);
            /*0x763cef8*/ int LocateAttribute(string name, string ns);
            /*0x763cff0*/ int LocateAttribute(string name);
            /*0x763d260*/ void PositionOnAttribute(int i);
            /*0x7643f98*/ void GrowElements();
            /*0x7644028*/ void GrowAttributes();
            /*0x76440b8*/ void ClearAttributes();
            /*0x76440c8*/ void PushNamespace(string prefix, string ns, bool implied);
            /*0x76442f8*/ void PopNamespaces(System.Xml.XmlSqlBinaryReader.NamespaceDecl firstInScopeChain);
            /*0x76443c4*/ void GenerateImpliedXmlnsAttrs();
            /*0x763dd64*/ bool ReadInit(bool skipXmlDecl);
            /*0x7644518*/ void ScanAttributes();
            /*0x7644bf8*/ void SimpleCheckForDuplicateAttributes();
            /*0x7644d60*/ void HashCheckForDuplicateAttributes();
            /*0x763c2ac*/ string XmlDeclValue();
            /*0x763c19c*/ string CDATAValue();
            /*0x7644fb0*/ void FinishCDATA();
            /*0x7645054*/ void FinishEndElement();
            /*0x763e24c*/ bool ReadDoc();
            /*0x7645c2c*/ void ImplReadData(System.Xml.BinXmlToken tokenType);
            /*0x76450b0*/ void ImplReadElement();
            /*0x7645340*/ void ImplReadEndElement();
            /*0x7645420*/ void ImplReadDoctype();
            /*0x76456e4*/ void ImplReadPI();
            /*0x7645750*/ void ImplReadComment();
            /*0x764577c*/ void ImplReadCDATA();
            /*0x76457b0*/ void ImplReadNest();
            /*0x7645868*/ void ImplReadEndNest();
            /*0x76458b8*/ void ImplReadXmlText();
            /*0x7645e14*/ void UpdateFromTextReader();
            /*0x763d244*/ bool UpdateFromTextReader(bool needUpdate);
            /*0x7645dac*/ void CheckAllowContent();
            /*0x763b290*/ void GenerateTokenTypeMap();
            /*0x763d8a8*/ System.Type GetValueType(System.Xml.BinXmlToken token);
            /*0x763d89c*/ void ReScanOverValue(System.Xml.BinXmlToken token);
            /*0x7644ad0*/ System.Xml.XmlNodeType ScanOverValue(System.Xml.BinXmlToken token, bool attr, bool checkChars);
            /*0x7646148*/ System.Xml.XmlNodeType ScanOverAnyValue(System.Xml.BinXmlToken token, bool attr, bool checkChars);
            /*0x7645eec*/ System.Xml.XmlNodeType CheckText(bool attr);
            /*0x76460b0*/ System.Xml.XmlNodeType CheckTextIsWS();
            /*0x7646550*/ void CheckValueTokenBounds();
            /*0x7646468*/ int GetXsdKatmaiTokenLength(System.Xml.BinXmlToken token);
            /*0x76465b0*/ int XsdKatmaiTimeScaleToValueLength(byte scale);
            /*0x7640d80*/ long ValueAsLong();
            /*0x7646994*/ ulong ValueAsULong();
            /*0x7640644*/ decimal ValueAsDecimal();
            /*0x763fac8*/ double ValueAsDouble();
            /*0x763f28c*/ System.DateTime ValueAsDateTime();
            /*0x7646b30*/ System.DateTimeOffset ValueAsDateTimeOffset();
            /*0x7646c40*/ string ValueAsDateTimeString();
            /*0x763c3ec*/ string ValueAsString(System.Xml.BinXmlToken token);
            /*0x7641804*/ object ValueAsObject(System.Xml.BinXmlToken token, bool returnInternalTypes);
            /*0x7646f64*/ System.Xml.Schema.XmlValueConverter GetValueConverter(System.Xml.Schema.XmlTypeCode typeCode);
            /*0x7642300*/ object ValueAs(System.Xml.BinXmlToken token, System.Type returnType, System.Xml.IXmlNamespaceResolver namespaceResolver);
            /*0x7646684*/ short GetInt16(int pos);
            /*0x764680c*/ ushort GetUInt16(int pos);
            /*0x76466c8*/ int GetInt32(int pos);
            /*0x7646850*/ uint GetUInt32(int pos);
            /*0x764673c*/ long GetInt64(int pos);
            /*0x76468c4*/ ulong GetUInt64(int pos);
            /*0x76469e4*/ float GetSingle(int offset);
            /*0x7646a5c*/ double GetDouble(int offset);
            /*0x7642fa4*/ System.Exception ThrowUnexpectedToken(System.Xml.BinXmlToken token);
            /*0x764396c*/ System.Exception ThrowXmlException(string res);
            /*0x76449e4*/ System.Exception ThrowXmlException(string res, string arg1, string arg2);
            /*0x763e864*/ System.Exception ThrowNotSupported(string res);

            enum ScanState
            {
                Doc = 0,
                XmlText = 1,
                Attr = 2,
                AttrVal = 3,
                AttrValPseudoValue = 4,
                Init = 5,
                Error = 6,
                EOF = 7,
                Closed = 8,
            }

            struct QName
            {
                /*0x10*/ string prefix;
                /*0x18*/ string localname;
                /*0x20*/ string namespaceUri;

                static /*0x7650590*/ bool op_Equality(System.Xml.XmlSqlBinaryReader.QName a, System.Xml.XmlSqlBinaryReader.QName b);
                /*0x765012c*/ QName(string prefix, string lname, string nsUri);
                /*0x7650170*/ void Set(string prefix, string lname, string nsUri);
                /*0x76501b4*/ void Clear();
                /*0x7650208*/ bool MatchNs(string lname, string nsUri);
                /*0x7650258*/ bool MatchPrefix(string prefix, string lname);
                /*0x76502a8*/ void CheckPrefixNS(string prefix, string namespaceUri);
                /*0x76503a0*/ int GetHashCode();
                /*0x76503e8*/ int GetNSHashCode(System.Xml.SecureStringHasher hasher);
                /*0x76504d8*/ bool Equals(object other);
                /*0x76505f0*/ string ToString();
            }

            struct ElemInfo
            {
                /*0x10*/ System.Xml.XmlSqlBinaryReader.QName name;
                /*0x28*/ string xmlLang;
                /*0x30*/ System.Xml.XmlSpace xmlSpace;
                /*0x34*/ bool xmlspacePreserve;
                /*0x38*/ System.Xml.XmlSqlBinaryReader.NamespaceDecl nsdecls;

                /*0x7650660*/ void Set(System.Xml.XmlSqlBinaryReader.QName name, bool xmlspacePreserve);
                /*0x76506ac*/ System.Xml.XmlSqlBinaryReader.NamespaceDecl Clear();
            }

            struct AttrInfo
            {
                /*0x10*/ System.Xml.XmlSqlBinaryReader.QName name;
                /*0x28*/ string val;
                /*0x30*/ int contentPos;
                /*0x34*/ int hashCode;
                /*0x38*/ int prevHash;

                /*0x76506cc*/ void Set(System.Xml.XmlSqlBinaryReader.QName n, string v);
                /*0x7650718*/ void Set(System.Xml.XmlSqlBinaryReader.QName n, int pos);
                /*0x7650764*/ void GetLocalnameAndNamespaceUri(ref string localname, ref string namespaceUri);
                /*0x76507a0*/ int GetLocalnameAndNamespaceUriAndHash(System.Xml.SecureStringHasher hasher, ref string localname, ref string namespaceUri);
                /*0x76507f0*/ bool MatchNS(string localname, string namespaceUri);
                /*0x76507f4*/ bool MatchHashNS(int hash, string localname, string namespaceUri);
                /*0x7650814*/ void AdjustPosition(int adj);
            }

            class NamespaceDecl
            {
                /*0x10*/ string prefix;
                /*0x18*/ string uri;
                /*0x20*/ System.Xml.XmlSqlBinaryReader.NamespaceDecl scopeLink;
                /*0x28*/ System.Xml.XmlSqlBinaryReader.NamespaceDecl prevLink;
                /*0x30*/ int scope;
                /*0x34*/ bool implied;

                /*0x7650828*/ NamespaceDecl(string prefix, string nsuri, System.Xml.XmlSqlBinaryReader.NamespaceDecl nextInScope, System.Xml.XmlSqlBinaryReader.NamespaceDecl prevDecl, int scope, bool implied);
            }

            struct SymbolTables
            {
                /*0x10*/ string[] symtable;
                /*0x18*/ int symCount;
                /*0x20*/ System.Xml.XmlSqlBinaryReader.QName[] qnametable;
                /*0x28*/ int qnameCount;

                /*0x76508b8*/ void Init();
            }

            class NestedBinXml
            {
                /*0x10*/ System.Xml.XmlSqlBinaryReader.SymbolTables symbolTables;
                /*0x30*/ int docState;
                /*0x38*/ System.Xml.XmlSqlBinaryReader.NestedBinXml next;

                /*0x765098c*/ NestedBinXml(System.Xml.XmlSqlBinaryReader.SymbolTables symbolTables, int docState, System.Xml.XmlSqlBinaryReader.NestedBinXml next);
            }
        }

        class BitStack
        {
            /*0x10*/ uint[] bitStack;
            /*0x18*/ int stackPos;
            /*0x1c*/ uint curr;

            /*0x76509e4*/ BitStack();
            /*0x7650a04*/ void PushBit(bool bit);
            /*0x7650b34*/ bool PopBit();
            /*0x7650ba0*/ bool PeekBit();
            /*0x7650a3c*/ void PushCurr();
            /*0x7650b5c*/ void PopCurr();
        }

        class Bits
        {
            static /*0x0*/ uint MASK_0101010101010101;
            static /*0x4*/ uint MASK_0011001100110011;
            static /*0x8*/ uint MASK_0000111100001111;
            static /*0xc*/ uint MASK_0000000011111111;
            static /*0x10*/ uint MASK_1111111111111111;

            static /*0x7650cb4*/ Bits();
            static /*0x7650bac*/ int Count(uint num);
            static /*0x7650c48*/ int LeastPosition(uint num);
        }

        class ByteStack
        {
            /*0x10*/ byte[] stack;
            /*0x18*/ int growthRate;
            /*0x1c*/ int top;
            /*0x20*/ int size;

            /*0x7650d0c*/ ByteStack(int growthRate);
            /*0x7650d88*/ void Push(byte data);
            /*0x7650e68*/ byte Pop();
        }

        class CharEntityEncoderFallback : System.Text.EncoderFallback
        {
            /*0x10*/ System.Xml.CharEntityEncoderFallbackBuffer fallbackBuffer;
            /*0x18*/ int[] textContentMarks;
            /*0x20*/ int endMarkPos;
            /*0x24*/ int curMarkPos;
            /*0x28*/ int startOffset;

            /*0x7650eb0*/ CharEntityEncoderFallback();
            /*0x7650eb8*/ System.Text.EncoderFallbackBuffer CreateFallbackBuffer();
            /*0x7650f84*/ int get_MaxCharCount();
            /*0x7650f8c*/ void set_StartOffset(int value);
            /*0x7650f94*/ void Reset(int[] textContentMarks, int endMarkPos);
            /*0x7650fc0*/ bool CanReplaceAt(int index);
        }

        class CharEntityEncoderFallbackBuffer : System.Text.EncoderFallbackBuffer
        {
            /*0x30*/ System.Xml.CharEntityEncoderFallback parent;
            /*0x38*/ string charEntity;
            /*0x40*/ int charEntityIndex;

            /*0x7650f2c*/ CharEntityEncoderFallbackBuffer(System.Xml.CharEntityEncoderFallback parent);
            /*0x7651040*/ bool Fallback(char charUnknown, int index);
            /*0x765123c*/ bool Fallback(char charUnknownHigh, char charUnknownLow, int index);
            /*0x76514cc*/ char GetNextChar();
            /*0x7651524*/ bool MovePrevious();
            /*0x7651540*/ int get_Remaining();
            /*0x7651574*/ void Reset();
            /*0x76514bc*/ int SurrogateCharToUtf32(char highSurrogate, char lowSurrogate);
        }

        enum ConformanceLevel
        {
            Auto = 0,
            Fragment = 1,
            Document = 2,
        }

        enum DtdProcessing
        {
            Prohibit = 0,
            Ignore = 1,
            Parse = 2,
        }

        enum EntityHandling
        {
            ExpandEntities = 1,
            ExpandCharEntities = 2,
        }

        class HtmlEncodedRawTextWriter : System.Xml.XmlEncodedRawTextWriter
        {
            static /*0x0*/ System.Xml.TernaryTreeReadOnly elementPropertySearch;
            static /*0x8*/ System.Xml.TernaryTreeReadOnly attributePropertySearch;
            /*0xc0*/ System.Xml.ByteStack elementScope;
            /*0xc8*/ System.Xml.ElementProperties currentElementProperties;
            /*0xcc*/ System.Xml.AttributeProperties currentAttributeProperties;
            /*0xd0*/ bool endsWithAmpersand;
            /*0xd8*/ byte[] uriEscapingBuffer;
            /*0xe0*/ string mediaType;
            /*0xe8*/ bool doNotEscapeUriAttributes;

            /*0x7651580*/ HtmlEncodedRawTextWriter(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings);
            /*0x765186c*/ HtmlEncodedRawTextWriter(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x7651ba0*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x7651ba4*/ void WriteXmlDeclaration(string xmldecl);
            /*0x7651ba8*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x7651e80*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x765218c*/ void StartElementContent();
            /*0x76522e4*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x765254c*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x765274c*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x76529dc*/ void WriteEndAttribute();
            /*0x7652b00*/ void WriteProcessingInstruction(string target, string text);
            /*0x7652f30*/ void WriteString(string text);
            /*0x7652fec*/ void WriteEntityRef(string name);
            /*0x7653044*/ void WriteCharEntity(char ch);
            /*0x765309c*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x76530f4*/ void WriteChars(char[] buffer, int index, int count);
            /*0x76516a8*/ void Init(System.Xml.XmlWriterSettings settings);
            /*0x76521e0*/ void WriteMetaElement();
            /*0x7652fdc*/ void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd);
            /*0x7652f9c*/ void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd);
            /*0x7653c04*/ void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd);
            /*0x76538a0*/ void WriteUriAttributeText(char* pSrc, char* pSrcEnd);
            /*0x7652a6c*/ void OutputRestAmps();
        }

        class HtmlEncodedRawTextWriterIndent : System.Xml.HtmlEncodedRawTextWriter
        {
            /*0xec*/ int indentLevel;
            /*0xf0*/ int endBlockPos;
            /*0xf8*/ string indentChars;
            /*0x100*/ bool newLineOnAttributes;

            /*0x7654014*/ HtmlEncodedRawTextWriterIndent(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings);
            /*0x7654088*/ HtmlEncodedRawTextWriterIndent(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x76540bc*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x76540d8*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x76542d4*/ void StartElementContent();
            /*0x7654344*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x76543dc*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x765444c*/ void FlushBuffer();
            /*0x7654048*/ void Init(System.Xml.XmlWriterSettings settings);
            /*0x765428c*/ void WriteIndent();
        }

        class HtmlTernaryTree
        {
            static /*0x0*/ byte[] htmlElements;
            static /*0x8*/ byte[] htmlAttributes;

            static /*0x7654680*/ HtmlTernaryTree();
        }

        class HtmlUtf8RawTextWriter : System.Xml.XmlUtf8RawTextWriter
        {
            static /*0x0*/ System.Xml.TernaryTreeReadOnly elementPropertySearch;
            static /*0x8*/ System.Xml.TernaryTreeReadOnly attributePropertySearch;
            /*0x90*/ System.Xml.ByteStack elementScope;
            /*0x98*/ System.Xml.ElementProperties currentElementProperties;
            /*0x9c*/ System.Xml.AttributeProperties currentAttributeProperties;
            /*0xa0*/ bool endsWithAmpersand;
            /*0xa8*/ byte[] uriEscapingBuffer;
            /*0xb0*/ string mediaType;
            /*0xb8*/ bool doNotEscapeUriAttributes;

            /*0x7654764*/ HtmlUtf8RawTextWriter(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x7654954*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x7654958*/ void WriteXmlDeclaration(string xmldecl);
            /*0x765495c*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x7654ba4*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x7654cac*/ void StartElementContent();
            /*0x7654e20*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x7654f04*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x7654fe8*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x7655158*/ void WriteEndAttribute();
            /*0x7655294*/ void WriteProcessingInstruction(string target, string text);
            /*0x76553b4*/ void WriteString(string text);
            /*0x7655460*/ void WriteEntityRef(string name);
            /*0x76554b8*/ void WriteCharEntity(char ch);
            /*0x7655510*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x7655568*/ void WriteChars(char[] buffer, int index, int count);
            /*0x7654790*/ void Init(System.Xml.XmlWriterSettings settings);
            /*0x7654d04*/ void WriteMetaElement();
            /*0x7655448*/ void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd);
            /*0x7655404*/ void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd);
            /*0x76558c8*/ void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd);
            /*0x76555ac*/ void WriteUriAttributeText(char* pSrc, char* pSrcEnd);
            /*0x76551d0*/ void OutputRestAmps();
        }

        class HtmlUtf8RawTextWriterIndent : System.Xml.HtmlUtf8RawTextWriter
        {
            /*0xbc*/ int indentLevel;
            /*0xc0*/ int endBlockPos;
            /*0xc8*/ string indentChars;
            /*0xd0*/ bool newLineOnAttributes;

            /*0x7655b20*/ HtmlUtf8RawTextWriterIndent(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x7655b98*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x7655bb4*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x7655da8*/ void StartElementContent();
            /*0x7655e1c*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x7655eb4*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x7655f28*/ void FlushBuffer();
            /*0x7655b58*/ void Init(System.Xml.XmlWriterSettings settings);
            /*0x7655d58*/ void WriteIndent();
        }

        interface IDtdInfo
        {
            /*0x38148bc*/ System.Xml.XmlQualifiedName get_Name();
            /*0x38148bc*/ string get_InternalDtdSubset();
            /*0x3813ffc*/ bool get_HasDefaultAttributes();
            /*0x3813ffc*/ bool get_HasNonCDataAttributes();
            /*0x3814b90*/ System.Xml.IDtdAttributeListInfo LookupAttributeList(string prefix, string localName);
            /*0x3814a3c*/ System.Xml.IDtdEntityInfo LookupEntity(string name);
        }

        interface IDtdAttributeListInfo
        {
            /*0x3813ffc*/ bool get_HasNonCDataAttributes();
            /*0x3814b90*/ System.Xml.IDtdAttributeInfo LookupAttribute(string prefix, string localName);
            /*0x38148bc*/ System.Collections.Generic.IEnumerable<System.Xml.IDtdDefaultAttributeInfo> LookupDefaultAttributes();
        }

        interface IDtdAttributeInfo
        {
            /*0x38148bc*/ string get_Prefix();
            /*0x38148bc*/ string get_LocalName();
            /*0x3814574*/ int get_LineNumber();
            /*0x3814574*/ int get_LinePosition();
            /*0x3813ffc*/ bool get_IsNonCDataType();
            /*0x3813ffc*/ bool get_IsDeclaredInExternal();
            /*0x3813ffc*/ bool get_IsXmlAttribute();
        }

        interface IDtdDefaultAttributeInfo : System.Xml.IDtdAttributeInfo
        {
            /*0x38148bc*/ string get_DefaultValueExpanded();
            /*0x38148bc*/ object get_DefaultValueTyped();
            /*0x3814574*/ int get_ValueLineNumber();
            /*0x3814574*/ int get_ValueLinePosition();
        }

        interface IDtdEntityInfo
        {
            /*0x38148bc*/ string get_Name();
            /*0x3813ffc*/ bool get_IsExternal();
            /*0x3813ffc*/ bool get_IsDeclaredInExternal();
            /*0x3813ffc*/ bool get_IsUnparsedEntity();
            /*0x3813ffc*/ bool get_IsParameterEntity();
            /*0x38148bc*/ string get_BaseUriString();
            /*0x38148bc*/ string get_DeclaredUriString();
            /*0x38148bc*/ string get_SystemId();
            /*0x38148bc*/ string get_PublicId();
            /*0x38148bc*/ string get_Text();
            /*0x3814574*/ int get_LineNumber();
            /*0x3814574*/ int get_LinePosition();
        }

        interface IDtdParser
        {
            /*0x3814a74*/ System.Xml.IDtdInfo ParseInternalDtd(System.Xml.IDtdParserAdapter adapter, bool saveInternalSubset);
            /*0x3814cc8*/ System.Xml.IDtdInfo ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, System.Xml.IDtdParserAdapter adapter);
        }

        interface IDtdParserAdapter
        {
            /*0x38148bc*/ System.Xml.XmlNameTable get_NameTable();
            /*0x38148bc*/ System.Xml.IXmlNamespaceResolver get_NamespaceResolver();
            /*0x38148bc*/ System.Uri get_BaseUri();
            /*0x38148bc*/ char[] get_ParsingBuffer();
            /*0x3814574*/ int get_ParsingBufferLength();
            /*0x3814574*/ int get_CurrentPosition();
            /*0x3815ed0*/ void set_CurrentPosition(int value);
            /*0x3814574*/ int get_LineNo();
            /*0x3814574*/ int get_LineStartPosition();
            /*0x3813ffc*/ bool get_IsEof();
            /*0x3814574*/ int get_EntityStackLength();
            /*0x3813ffc*/ bool get_IsEntityEolNormalized();
            /*0x3814574*/ int ReadData();
            /*0x3815ed0*/ void OnNewLine(int pos);
            /*0x381467c*/ int ParseNumericCharRef(System.Text.StringBuilder internalSubsetBuilder);
            int ParseNamedCharRef(bool expand, System.Text.StringBuilder internalSubsetBuilder);
            /*0x3816710*/ void ParsePI(System.Text.StringBuilder sb);
            /*0x3816710*/ void ParseComment(System.Text.StringBuilder sb);
            /*0x3814200*/ bool PushEntity(System.Xml.IDtdEntityInfo entity, ref int entityId);
            /*0x3814200*/ bool PopEntity(ref System.Xml.IDtdEntityInfo oldEntity, ref int newEntityId);
            /*0x3814200*/ bool PushExternalSubset(string systemId, string publicId);
            /*0x3816810*/ void PushInternalDtd(string baseUri, string internalDtd);
            void OnSystemId(string systemId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo systemLiteralLineInfo);
            void OnPublicId(string publicId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo publicLiteralLineInfo);
            /*0x3816710*/ void Throw(System.Exception e);
        }

        interface IDtdParserAdapterWithValidation : System.Xml.IDtdParserAdapter
        {
            /*0x3813ffc*/ bool get_DtdValidation();
            /*0x38148bc*/ System.Xml.IValidationEventHandling get_ValidationEventHandling();
        }

        interface IDtdParserAdapterV1 : System.Xml.IDtdParserAdapterWithValidation, System.Xml.IDtdParserAdapter
        {
            /*0x3813ffc*/ bool get_V1CompatibilityMode();
            /*0x3813ffc*/ bool get_Normalization();
            /*0x3813ffc*/ bool get_Namespaces();
        }

        class OnRemoveWriter : System.MulticastDelegate
        {
            /*0x7655f54*/ OnRemoveWriter(object object, nint method);
            /*0x765605c*/ void Invoke(System.Xml.XmlRawWriter writer);
        }

        interface IValidationEventHandling
        {
            /*0x38148bc*/ object get_EventHandler();
            /*0x381678c*/ void SendEvent(System.Exception exception, System.Xml.Schema.XmlSeverityType severity);
        }

        class IncrementalReadDecoder
        {
            /*0x7656070*/ IncrementalReadDecoder();
            /*0x3814574*/ int get_DecodedCount();
            /*0x3813ffc*/ bool get_IsFull();
            void SetNextOutputBuffer(System.Array array, int offset, int len);
            int Decode(char[] chars, int startPos, int len);
            int Decode(string str, int startPos, int len);
            /*0x38159dc*/ void Reset();
        }

        class IncrementalReadDummyDecoder : System.Xml.IncrementalReadDecoder
        {
            /*0x76560a0*/ IncrementalReadDummyDecoder();
            /*0x7656078*/ int get_DecodedCount();
            /*0x7656080*/ bool get_IsFull();
            /*0x7656088*/ void SetNextOutputBuffer(System.Array array, int offset, int len);
            /*0x765608c*/ int Decode(char[] chars, int startPos, int len);
            /*0x7656094*/ int Decode(string str, int startPos, int len);
            /*0x765609c*/ void Reset();
        }

        enum NamespaceHandling
        {
            Default = 0,
            OmitDuplicates = 1,
        }

        enum NewLineHandling
        {
            Replace = 0,
            Entitize = 1,
            None = 2,
        }

        class QueryOutputWriter : System.Xml.XmlRawWriter
        {
            /*0x28*/ System.Xml.XmlRawWriter wrapped;
            /*0x30*/ bool inCDataSection;
            /*0x38*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, int> lookupCDataElems;
            /*0x40*/ System.Xml.BitStack bitsCData;
            /*0x48*/ System.Xml.XmlQualifiedName qnameCData;
            /*0x50*/ bool outputDocType;
            /*0x51*/ bool checkWellFormedDoc;
            /*0x52*/ bool hasDocElem;
            /*0x53*/ bool inAttr;
            /*0x58*/ string systemId;
            /*0x60*/ string publicId;
            /*0x68*/ int depth;

            /*0x76560a8*/ QueryOutputWriter(System.Xml.XmlRawWriter writer, System.Xml.XmlWriterSettings settings);
            /*0x76563cc*/ void set_NamespaceResolver(System.Xml.IXmlNamespaceResolver value);
            /*0x7656410*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x7656434*/ void WriteXmlDeclaration(string xmldecl);
            /*0x7656458*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x7656490*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x765665c*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x76566cc*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x765673c*/ void StartElementContent();
            /*0x7656760*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x765678c*/ void WriteEndAttribute();
            /*0x76567b8*/ void WriteNamespaceDeclaration(string prefix, string ns);
            /*0x76567dc*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0x7656800*/ void WriteStartNamespaceDeclaration(string prefix);
            /*0x7656824*/ void WriteEndNamespaceDeclaration();
            /*0x7656848*/ void WriteCData(string text);
            /*0x765686c*/ void WriteComment(string text);
            /*0x7656898*/ void WriteProcessingInstruction(string name, string text);
            /*0x76568c4*/ void WriteWhitespace(string ws);
            /*0x7656970*/ void WriteString(string text);
            /*0x76569e0*/ void WriteChars(char[] buffer, int index, int count);
            /*0x7656a68*/ void WriteEntityRef(string name);
            /*0x7656a94*/ void WriteCharEntity(char ch);
            /*0x7656ac0*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x7656aec*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x7656b74*/ void WriteRaw(string data);
            /*0x7656be4*/ void Close();
            /*0x7656c88*/ void Flush();
            /*0x7656934*/ bool StartCDataSection();
            /*0x7656654*/ void EndCDataSection();
        }

        class ReadContentAsBinaryHelper
        {
            /*0x10*/ System.Xml.XmlReader reader;
            /*0x18*/ System.Xml.ReadContentAsBinaryHelper.State state;
            /*0x1c*/ int valueOffset;
            /*0x20*/ bool isEnd;
            /*0x21*/ bool canReadValueChunk;
            /*0x28*/ char[] valueChunk;
            /*0x30*/ int valueChunkLength;
            /*0x38*/ System.Xml.IncrementalReadDecoder decoder;
            /*0x40*/ System.Xml.Base64Decoder base64Decoder;
            /*0x48*/ System.Xml.BinHexDecoder binHexDecoder;

            static /*0x7656d58*/ System.Xml.ReadContentAsBinaryHelper CreateOrReset(System.Xml.ReadContentAsBinaryHelper helper, System.Xml.XmlReader reader);
            /*0x7656cac*/ ReadContentAsBinaryHelper(System.Xml.XmlReader reader);
            /*0x7656dd0*/ int ReadContentAsBase64(byte[] buffer, int index, int count);
            /*0x76571dc*/ int ReadContentAsBinHex(byte[] buffer, int index, int count);
            /*0x7657458*/ void Finish();
            /*0x7656dc4*/ void Reset();
            /*0x7656fbc*/ bool Init();
            /*0x7657150*/ void InitBase64Decoder();
            /*0x76573cc*/ void InitBinHexDecoder();
            /*0x7656fe8*/ int ReadContentAsBinary(byte[] buffer, int index, int count);
            /*0x7657594*/ bool MoveToNextContentNode(bool moveIfOnContentNode);

            enum State
            {
                None = 0,
                InReadContent = 1,
                InReadElementContent = 2,
            }
        }

        enum ElementProperties
        {
            DEFAULT = 0,
            URI_PARENT = 1,
            BOOL_PARENT = 2,
            NAME_PARENT = 4,
            EMPTY = 8,
            NO_ENTITIES = 16,
            HEAD = 32,
            BLOCK_WS = 64,
            HAS_NS = 128,
        }

        enum AttributeProperties
        {
            DEFAULT = 0,
            URI = 1,
            BOOLEAN = 2,
            NAME = 4,
        }

        class TernaryTreeReadOnly
        {
            /*0x10*/ byte[] nodeBuffer;

            /*0x7653708*/ TernaryTreeReadOnly(byte[] nodeBuffer);
            /*0x7651f98*/ byte FindCaseInsensitiveString(string stringToFind);
        }

        enum ReadState
        {
            Initial = 0,
            Interactive = 1,
            Error = 2,
            EndOfFile = 3,
            Closed = 4,
        }

        class SecureStringHasher : System.Collections.Generic.IEqualityComparer<string>
        {
            static /*0x0*/ System.Xml.SecureStringHasher.HashCodeOfStringDelegate hashCodeDelegate;
            /*0x10*/ int hashCodeRandomizer;

            static /*0x76577e0*/ int GetHashCodeOfString(string key, int sLen, long additionalEntropy);
            static /*0x76576a8*/ System.Xml.SecureStringHasher.HashCodeOfStringDelegate GetHashCodeDelegate();
            /*0x765766c*/ SecureStringHasher();
            /*0x7657690*/ bool Equals(string x, string y);
            /*0x765042c*/ int GetHashCode(string key);

            class HashCodeOfStringDelegate : System.MulticastDelegate
            {
                /*0x765784c*/ HashCodeOfStringDelegate(object object, nint method);
                /*0x7657900*/ int Invoke(string s, int sLen, long additionalEntropy);
            }
        }

        class TextEncodedRawTextWriter : System.Xml.XmlEncodedRawTextWriter
        {
            /*0x7657914*/ TextEncodedRawTextWriter(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings);
            /*0x7657918*/ TextEncodedRawTextWriter(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x765791c*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x7657920*/ void WriteXmlDeclaration(string xmldecl);
            /*0x7657924*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x7657928*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x765792c*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x7657930*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x7657934*/ void StartElementContent();
            /*0x7657938*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x7657944*/ void WriteEndAttribute();
            /*0x765794c*/ void WriteNamespaceDeclaration(string prefix, string ns);
            /*0x7657950*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0x7657958*/ void WriteCData(string text);
            /*0x76579c0*/ void WriteComment(string text);
            /*0x76579c4*/ void WriteProcessingInstruction(string name, string text);
            /*0x76579c8*/ void WriteEntityRef(string name);
            /*0x76579cc*/ void WriteCharEntity(char ch);
            /*0x76579d0*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x76579d4*/ void WriteWhitespace(string ws);
            /*0x76579e4*/ void WriteString(string textBlock);
            /*0x76579f4*/ void WriteChars(char[] buffer, int index, int count);
            /*0x7657a80*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x7657a90*/ void WriteRaw(string data);
        }

        class TextUtf8RawTextWriter : System.Xml.XmlUtf8RawTextWriter
        {
            /*0x7657aa0*/ TextUtf8RawTextWriter(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x7657aa8*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x7657aac*/ void WriteXmlDeclaration(string xmldecl);
            /*0x7657ab0*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x7657ab4*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x7657ab8*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x7657abc*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x7657ac0*/ void StartElementContent();
            /*0x7657ac4*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x7657ad0*/ void WriteEndAttribute();
            /*0x7657ad8*/ void WriteNamespaceDeclaration(string prefix, string ns);
            /*0x7657adc*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0x7657ae4*/ void WriteCData(string text);
            /*0x7657aec*/ void WriteComment(string text);
            /*0x7657af0*/ void WriteProcessingInstruction(string name, string text);
            /*0x7657af4*/ void WriteEntityRef(string name);
            /*0x7657af8*/ void WriteCharEntity(char ch);
            /*0x7657afc*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x7657b00*/ void WriteWhitespace(string ws);
            /*0x7657b14*/ void WriteString(string textBlock);
            /*0x7657b28*/ void WriteChars(char[] buffer, int index, int count);
            /*0x7657b3c*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x7657b50*/ void WriteRaw(string data);
        }

        class ValidatingReaderNodeData
        {
            /*0x10*/ string localName;
            /*0x18*/ string namespaceUri;
            /*0x20*/ string prefix;
            /*0x28*/ string nameWPrefix;
            /*0x30*/ string rawValue;
            /*0x38*/ string originalStringValue;
            /*0x40*/ int depth;
            /*0x48*/ System.Xml.AttributePSVIInfo attributePSVIInfo;
            /*0x50*/ System.Xml.XmlNodeType nodeType;
            /*0x54*/ int lineNo;
            /*0x58*/ int linePos;

            /*0x7657b64*/ ValidatingReaderNodeData();
            /*0x7657c2c*/ ValidatingReaderNodeData(System.Xml.XmlNodeType nodeType);
            /*0x7657c58*/ string get_LocalName();
            /*0x7657c60*/ void set_LocalName(string value);
            /*0x7657c68*/ string get_Namespace();
            /*0x7657c70*/ void set_Namespace(string value);
            /*0x7657c78*/ string get_Prefix();
            /*0x7657c80*/ void set_Prefix(string value);
            /*0x7657c88*/ string GetAtomizedNameWPrefix(System.Xml.XmlNameTable nameTable);
            /*0x7657d2c*/ int get_Depth();
            /*0x7657d34*/ void set_Depth(int value);
            /*0x7657d3c*/ string get_RawValue();
            /*0x7657d44*/ void set_RawValue(string value);
            /*0x7657d4c*/ string get_OriginalStringValue();
            /*0x7657d54*/ System.Xml.XmlNodeType get_NodeType();
            /*0x7657d5c*/ void set_NodeType(System.Xml.XmlNodeType value);
            /*0x7657d64*/ System.Xml.AttributePSVIInfo get_AttInfo();
            /*0x7657d6c*/ void set_AttInfo(System.Xml.AttributePSVIInfo value);
            /*0x7657d74*/ int get_LineNumber();
            /*0x7657d7c*/ int get_LinePosition();
            /*0x7657b84*/ void Clear(System.Xml.XmlNodeType nodeType);
            /*0x7657d84*/ void SetLineInfo(int lineNo, int linePos);
            /*0x7657d8c*/ void SetLineInfo(System.Xml.IXmlLineInfo lineInfo);
            /*0x7657e94*/ void SetItemData(string localName, string prefix, string ns, int depth);
            /*0x7657f08*/ void SetItemData(string value);
            /*0x7657f38*/ void SetItemData(string value, string originalStringValue);
        }

        enum ValidationType
        {
            None = 0,
            Auto = 1,
            DTD = 2,
            XDR = 3,
            Schema = 4,
        }

        enum WhitespaceHandling
        {
            All = 0,
            Significant = 1,
            None = 2,
        }

        class XmlAsyncCheckReader : System.Xml.XmlReader
        {
            /*0x10*/ System.Xml.XmlReader coreReader;
            /*0x18*/ System.Threading.Tasks.Task lastTask;

            static /*0x7657f70*/ System.Xml.XmlAsyncCheckReader CreateAsyncCheckWrapper(System.Xml.XmlReader reader);
            /*0x7658394*/ XmlAsyncCheckReader(System.Xml.XmlReader reader);
            /*0x7657f68*/ System.Xml.XmlReader get_CoreReader();
            /*0x7658444*/ void CheckAsync();
            /*0x76584c0*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x7658560*/ System.Xml.XmlNodeType get_NodeType();
            /*0x7658588*/ string get_Name();
            /*0x76585b0*/ string get_LocalName();
            /*0x76585d8*/ string get_NamespaceURI();
            /*0x7658600*/ string get_Prefix();
            /*0x7658628*/ string get_Value();
            /*0x7658650*/ int get_Depth();
            /*0x7658678*/ string get_BaseURI();
            /*0x76586a4*/ bool get_IsEmptyElement();
            /*0x76586d0*/ bool get_IsDefault();
            /*0x76586fc*/ char get_QuoteChar();
            /*0x7658728*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x7658754*/ string get_XmlLang();
            /*0x7658780*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x76587ac*/ System.Type get_ValueType();
            /*0x76587d8*/ object ReadContentAsObject();
            /*0x7658804*/ bool ReadContentAsBoolean();
            /*0x7658830*/ System.DateTime ReadContentAsDateTime();
            /*0x765885c*/ double ReadContentAsDouble();
            /*0x7658888*/ float ReadContentAsFloat();
            /*0x76588b4*/ decimal ReadContentAsDecimal();
            /*0x76588e0*/ int ReadContentAsInt();
            /*0x765890c*/ long ReadContentAsLong();
            /*0x7658938*/ string ReadContentAsString();
            /*0x7658964*/ object ReadContentAs(System.Type returnType, System.Xml.IXmlNamespaceResolver namespaceResolver);
            /*0x76589a8*/ bool ReadElementContentAsBoolean();
            /*0x76589d4*/ System.DateTime ReadElementContentAsDateTime();
            /*0x7658a00*/ double ReadElementContentAsDouble();
            /*0x7658a2c*/ float ReadElementContentAsFloat();
            /*0x7658a58*/ decimal ReadElementContentAsDecimal();
            /*0x7658a84*/ int ReadElementContentAsInt();
            /*0x7658ab0*/ long ReadElementContentAsLong();
            /*0x7658adc*/ string ReadElementContentAsString();
            /*0x7658b08*/ int get_AttributeCount();
            /*0x7658b34*/ string GetAttribute(string name);
            /*0x7658b70*/ string GetAttribute(string name, string namespaceURI);
            /*0x7658bb4*/ string GetAttribute(int i);
            /*0x7658bf0*/ bool MoveToAttribute(string name);
            /*0x7658c2c*/ bool MoveToAttribute(string name, string ns);
            /*0x7658c70*/ void MoveToAttribute(int i);
            /*0x7658cac*/ bool MoveToFirstAttribute();
            /*0x7658cd8*/ bool MoveToNextAttribute();
            /*0x7658d04*/ bool MoveToElement();
            /*0x7658d30*/ bool ReadAttributeValue();
            /*0x7658d5c*/ bool Read();
            /*0x7658d88*/ bool get_EOF();
            /*0x7658db4*/ void Close();
            /*0x7658de0*/ System.Xml.ReadState get_ReadState();
            /*0x7658e0c*/ void Skip();
            /*0x7658e38*/ System.Xml.XmlNameTable get_NameTable();
            /*0x7658e64*/ string LookupNamespace(string prefix);
            /*0x7658ea0*/ bool get_CanResolveEntity();
            /*0x7658ecc*/ void ResolveEntity();
            /*0x7658ef8*/ int ReadContentAsBase64(byte[] buffer, int index, int count);
            /*0x7658f4c*/ int ReadContentAsBinHex(byte[] buffer, int index, int count);
            /*0x7658fa0*/ bool get_CanReadValueChunk();
            /*0x7658fcc*/ int ReadValueChunk(char[] buffer, int index, int count);
            /*0x7659020*/ string ReadString();
            /*0x765904c*/ System.Xml.XmlNodeType MoveToContent();
            /*0x7659078*/ void ReadStartElement();
            /*0x76590a4*/ string ReadElementString();
            /*0x76590d0*/ void ReadEndElement();
            /*0x76590fc*/ bool IsStartElement();
            /*0x7659128*/ bool IsStartElement(string localname, string ns);
            /*0x765916c*/ string ReadInnerXml();
            /*0x7659198*/ bool get_HasAttributes();
            /*0x76591c4*/ void Dispose(bool disposing);
            /*0x76591e8*/ System.Xml.XmlNamespaceManager get_NamespaceManager();
            /*0x7659214*/ System.Xml.IDtdInfo get_DtdInfo();
        }

        class XmlAsyncCheckReaderWithNS : System.Xml.XmlAsyncCheckReader, System.Xml.IXmlNamespaceResolver
        {
            /*0x20*/ System.Xml.IXmlNamespaceResolver readerAsIXmlNamespaceResolver;

            /*0x76582ec*/ XmlAsyncCheckReaderWithNS(System.Xml.XmlReader reader);
            /*0x7659240*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x76592e8*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0x7659394*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
        }

        class XmlAsyncCheckReaderWithLineInfo : System.Xml.XmlAsyncCheckReader, System.Xml.IXmlLineInfo
        {
            /*0x20*/ System.Xml.IXmlLineInfo readerAsIXmlLineInfo;

            /*0x7658244*/ XmlAsyncCheckReaderWithLineInfo(System.Xml.XmlReader reader);
            /*0x7659440*/ bool HasLineInfo();
            /*0x76594e0*/ int get_LineNumber();
            /*0x7659584*/ int get_LinePosition();
        }

        class XmlAsyncCheckReaderWithLineInfoNS : System.Xml.XmlAsyncCheckReaderWithLineInfo, System.Xml.IXmlNamespaceResolver
        {
            /*0x28*/ System.Xml.IXmlNamespaceResolver readerAsIXmlNamespaceResolver;

            /*0x765819c*/ XmlAsyncCheckReaderWithLineInfoNS(System.Xml.XmlReader reader);
            /*0x7659628*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x76596d0*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0x765977c*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
        }

        class XmlAsyncCheckReaderWithLineInfoNSSchema : System.Xml.XmlAsyncCheckReaderWithLineInfoNS, System.Xml.Schema.IXmlSchemaInfo
        {
            /*0x30*/ System.Xml.Schema.IXmlSchemaInfo readerAsIXmlSchemaInfo;

            /*0x76580f4*/ XmlAsyncCheckReaderWithLineInfoNSSchema(System.Xml.XmlReader reader);
            /*0x7659828*/ System.Xml.Schema.XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity();
            /*0x76598c8*/ bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault();
            /*0x765996c*/ bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil();
            /*0x7659a10*/ System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType();
            /*0x7659ab4*/ System.Xml.Schema.XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType();
            /*0x7659b58*/ System.Xml.Schema.XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement();
            /*0x7659bfc*/ System.Xml.Schema.XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute();
        }

        class XmlAsyncCheckWriter : System.Xml.XmlWriter
        {
            /*0x18*/ System.Xml.XmlWriter coreWriter;
            /*0x20*/ System.Threading.Tasks.Task lastTask;

            /*0x7659ca0*/ XmlAsyncCheckWriter(System.Xml.XmlWriter writer);
            /*0x7659d2c*/ void CheckAsync();
            /*0x7659da8*/ void WriteStartDocument();
            /*0x7659dd0*/ void WriteStartDocument(bool standalone);
            /*0x7659e08*/ void WriteEndDocument();
            /*0x7659e30*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x7659e88*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x7659ed8*/ void WriteEndElement();
            /*0x7659f00*/ void WriteFullEndElement();
            /*0x7659f28*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x7659f78*/ void WriteEndAttribute();
            /*0x7659fa4*/ void WriteCData(string text);
            /*0x7659fe0*/ void WriteComment(string text);
            /*0x765a01c*/ void WriteProcessingInstruction(string name, string text);
            /*0x765a060*/ void WriteEntityRef(string name);
            /*0x765a09c*/ void WriteCharEntity(char ch);
            /*0x765a0d8*/ void WriteWhitespace(string ws);
            /*0x765a114*/ void WriteString(string text);
            /*0x765a150*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x765a194*/ void WriteChars(char[] buffer, int index, int count);
            /*0x765a1e8*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x765a23c*/ void WriteRaw(string data);
            /*0x765a278*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x765a2cc*/ void WriteBinHex(byte[] buffer, int index, int count);
            /*0x765a320*/ System.Xml.WriteState get_WriteState();
            /*0x765a34c*/ void Close();
            /*0x765a378*/ void Flush();
            /*0x765a3a4*/ string LookupPrefix(string ns);
            /*0x765a3e0*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x765a40c*/ string get_XmlLang();
            /*0x765a438*/ void WriteQualifiedName(string localName, string ns);
            /*0x765a47c*/ void WriteValue(string value);
            /*0x765a4b8*/ void WriteValue(bool value);
            /*0x765a4f4*/ void WriteValue(System.DateTime value);
            /*0x765a530*/ void WriteValue(double value);
            /*0x765a56c*/ void WriteValue(float value);
            /*0x765a5a8*/ void WriteValue(decimal value);
            /*0x765a5ec*/ void WriteValue(int value);
            /*0x765a628*/ void WriteValue(long value);
            /*0x765a664*/ void WriteAttributes(System.Xml.XmlReader reader, bool defattr);
            /*0x765a6a8*/ void WriteNode(System.Xml.XmlReader reader, bool defattr);
            /*0x765a6ec*/ void Dispose(bool disposing);
        }

        class XmlAutoDetectWriter : System.Xml.XmlRawWriter
        {
            /*0x28*/ System.Xml.XmlRawWriter wrapped;
            /*0x30*/ System.Xml.OnRemoveWriter onRemove;
            /*0x38*/ System.Xml.XmlWriterSettings writerSettings;
            /*0x40*/ System.Xml.XmlEventCache eventCache;
            /*0x48*/ System.IO.TextWriter textWriter;
            /*0x50*/ System.IO.Stream strm;

            static /*0x765a97c*/ bool IsHtmlTag(string tagName);
            /*0x765a710*/ XmlAutoDetectWriter(System.Xml.XmlWriterSettings writerSettings);
            /*0x765a824*/ XmlAutoDetectWriter(System.IO.TextWriter textWriter, System.Xml.XmlWriterSettings writerSettings);
            /*0x765a854*/ XmlAutoDetectWriter(System.IO.Stream strm, System.Xml.XmlWriterSettings writerSettings);
            /*0x765a884*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x765a8fc*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x765abd8*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x765ac38*/ void WriteEndAttribute();
            /*0x765ac5c*/ void WriteCData(string text);
            /*0x765ad04*/ void WriteComment(string text);
            /*0x765ad34*/ void WriteProcessingInstruction(string name, string text);
            /*0x765ad64*/ void WriteWhitespace(string ws);
            /*0x765ad94*/ void WriteString(string text);
            /*0x765addc*/ void WriteChars(char[] buffer, int index, int count);
            /*0x765ae0c*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x765ae3c*/ void WriteRaw(string data);
            /*0x765ae84*/ void WriteEntityRef(string name);
            /*0x765aed0*/ void WriteCharEntity(char ch);
            /*0x765af1c*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x765af70*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x765afd4*/ void WriteBinHex(byte[] buffer, int index, int count);
            /*0x765b038*/ void Close();
            /*0x765b074*/ void Flush();
            /*0x765b0b0*/ void WriteValue(string value);
            /*0x765b0fc*/ void WriteValue(bool value);
            /*0x765b148*/ void WriteValue(System.DateTime value);
            /*0x765b194*/ void WriteValue(double value);
            /*0x765b1e0*/ void WriteValue(float value);
            /*0x765b22c*/ void WriteValue(decimal value);
            /*0x765b280*/ void WriteValue(int value);
            /*0x765b2cc*/ void WriteValue(long value);
            /*0x765b318*/ void set_NamespaceResolver(System.Xml.IXmlNamespaceResolver value);
            /*0x765b368*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x765b3b4*/ void WriteXmlDeclaration(string xmldecl);
            /*0x765b400*/ void StartElementContent();
            /*0x765b424*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x765b448*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x765b46c*/ void WriteNamespaceDeclaration(string prefix, string ns);
            /*0x765b4c0*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0x765b4e4*/ void WriteStartNamespaceDeclaration(string prefix);
            /*0x765b530*/ void WriteEndNamespaceDeclaration();
            /*0x765a8ec*/ void EnsureWrappedWriter(System.Xml.XmlOutputMethod outMethod);
            /*0x765aca4*/ bool TextBlockCreatesWriter(string textBlock);
            /*0x765aa90*/ void CreateWrappedWriter(System.Xml.XmlOutputMethod outMethod);
        }

        class XmlEncodedRawTextWriter : System.Xml.XmlRawWriter
        {
            /*0x28*/ bool useAsync;
            /*0x30*/ byte[] bufBytes;
            /*0x38*/ System.IO.Stream stream;
            /*0x40*/ System.Text.Encoding encoding;
            /*0x48*/ System.Xml.XmlCharType xmlCharType;
            /*0x50*/ int bufPos;
            /*0x54*/ int textPos;
            /*0x58*/ int contentPos;
            /*0x5c*/ int cdataPos;
            /*0x60*/ int attrEndPos;
            /*0x64*/ int bufLen;
            /*0x68*/ bool writeToNull;
            /*0x69*/ bool hadDoubleBracket;
            /*0x6a*/ bool inAttributeValue;
            /*0x6c*/ int bufBytesUsed;
            /*0x70*/ char[] bufChars;
            /*0x78*/ System.Text.Encoder encoder;
            /*0x80*/ System.IO.TextWriter writer;
            /*0x88*/ bool trackTextContent;
            /*0x89*/ bool inTextContent;
            /*0x8c*/ int lastMarkPos;
            /*0x90*/ int[] textContentMarks;
            /*0x98*/ System.Xml.CharEntityEncoderFallback charEntityFallback;
            /*0xa0*/ System.Xml.NewLineHandling newLineHandling;
            /*0xa4*/ bool closeOutput;
            /*0xa5*/ bool omitXmlDeclaration;
            /*0xa8*/ string newLineChars;
            /*0xb0*/ bool checkCharacters;
            /*0xb4*/ System.Xml.XmlStandalone standalone;
            /*0xb8*/ System.Xml.XmlOutputMethod outputMethod;
            /*0xbc*/ bool autoXmlDeclaration;
            /*0xbd*/ bool mergeCDataSections;

            static /*0x765d890*/ char* EncodeSurrogate(char* pSrc, char* pSrcEnd, char* pDst);
            static /*0x765d838*/ char* LtEntity(char* pDst);
            static /*0x765d850*/ char* GtEntity(char* pDst);
            static /*0x7653ecc*/ char* AmpEntity(char* pDst);
            static /*0x7653ef4*/ char* QuoteEntity(char* pDst);
            static /*0x765d868*/ char* TabEntity(char* pDst);
            static /*0x7653f48*/ char* LineFeedEntity(char* pDst);
            static /*0x7653f20*/ char* CarriageReturnEntity(char* pDst);
            static /*0x765db08*/ char* CharEntity(char* pDst, char ch);
            static /*0x765dad0*/ char* RawStartCData(char* pDst);
            static /*0x765dab0*/ char* RawEndCData(char* pDst);
            /*0x765bc3c*/ XmlEncodedRawTextWriter(System.Xml.XmlWriterSettings settings);
            /*0x76515a8*/ XmlEncodedRawTextWriter(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings);
            /*0x7651894*/ XmlEncodedRawTextWriter(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x765c088*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x765c1f8*/ void WriteXmlDeclaration(string xmldecl);
            /*0x765c270*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x76520c4*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x765c45c*/ void StartElementContent();
            /*0x76523dc*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x7652644*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x76528bc*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x765c4a0*/ void WriteEndAttribute();
            /*0x765c508*/ void WriteNamespaceDeclaration(string prefix, string namespaceName);
            /*0x765c55c*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0x765c564*/ void WriteStartNamespaceDeclaration(string prefix);
            /*0x765c688*/ void WriteEndNamespaceDeclaration();
            /*0x765c6f0*/ void WriteCData(string text);
            /*0x765cbec*/ void WriteComment(string text);
            /*0x765cd18*/ void WriteProcessingInstruction(string name, string text);
            /*0x765ce44*/ void WriteEntityRef(string name);
            /*0x765cf10*/ void WriteCharEntity(char ch);
            /*0x765d0d4*/ void WriteWhitespace(string ws);
            /*0x765d140*/ void WriteString(string text);
            /*0x765d1ac*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x765d2f4*/ void WriteChars(char[] buffer, int index, int count);
            /*0x7657a04*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x765795c*/ void WriteRaw(string data);
            /*0x765d594*/ void Close();
            /*0x765d6ac*/ void Flush();
            /*0x7654474*/ void FlushBuffer();
            /*0x765d704*/ void EncodeChars(int startOffset, int endOffset, bool writeAllToStream);
            /*0x765d610*/ void FlushEncoder();
            /*0x765317c*/ void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd);
            /*0x7653464*/ void WriteElementTextBlock(char* pSrc, char* pSrcEnd);
            /*0x7651e44*/ void RawText(string s);
            /*0x7653738*/ void RawText(char* pSrcBegin, char* pSrcEnd);
            /*0x765d37c*/ void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd);
            /*0x7652c28*/ void WriteCommentOrPi(string text, int stopChar);
            /*0x765c8d0*/ void WriteCDataSection(string text);
            /*0x765d9e8*/ char* InvalidXmlChar(int ch, char* pDst, bool entitize);
            /*0x7653f70*/ void EncodeChar(ref char* pSrc, char* pSrcEnd, ref char* pDst);
            /*0x7651dd0*/ void ChangeTextContentMark(bool value);
            /*0x765dbb8*/ void GrowTextContentMarks();
            /*0x765da54*/ char* WriteNewLine(char* pDst);
            /*0x765bd3c*/ void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace);
        }

        class XmlEncodedRawTextWriterIndent : System.Xml.XmlEncodedRawTextWriter
        {
            /*0xc0*/ int indentLevel;
            /*0xc4*/ bool newLineOnAttributes;
            /*0xc8*/ string indentChars;
            /*0xd0*/ bool mixedContent;
            /*0xd8*/ System.Xml.BitStack mixedContentStack;
            /*0xe0*/ System.Xml.ConformanceLevel conformanceLevel;

            /*0x765dc40*/ XmlEncodedRawTextWriterIndent(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings);
            /*0x765dd94*/ XmlEncodedRawTextWriterIndent(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x765ddbc*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x765de64*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x765defc*/ void StartElementContent();
            /*0x765df40*/ void OnRootElement(System.Xml.ConformanceLevel currentConformanceLevel);
            /*0x765df48*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x765dfe0*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x765e078*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x765e0b4*/ void WriteCData(string text);
            /*0x765e0c0*/ void WriteComment(string text);
            /*0x765e100*/ void WriteProcessingInstruction(string target, string text);
            /*0x765e148*/ void WriteEntityRef(string name);
            /*0x765e154*/ void WriteCharEntity(char ch);
            /*0x765e160*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x765e16c*/ void WriteWhitespace(string ws);
            /*0x765e178*/ void WriteString(string text);
            /*0x765e184*/ void WriteChars(char[] buffer, int index, int count);
            /*0x765e190*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x765e19c*/ void WriteRaw(string data);
            /*0x765e1a8*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x765dc68*/ void Init(System.Xml.XmlWriterSettings settings);
            /*0x765de1c*/ void WriteIndent();
        }

        class XmlEventCache : System.Xml.XmlRawWriter
        {
            /*0x28*/ System.Collections.Generic.List<System.Xml.XmlEventCache.XmlEvent[]> pages;
            /*0x30*/ System.Xml.XmlEventCache.XmlEvent[] pageCurr;
            /*0x38*/ int pageSize;
            /*0x3c*/ bool hasRootNode;
            /*0x40*/ System.Xml.Xsl.Runtime.StringConcat singleText;
            /*0x78*/ string baseUri;

            static /*0x765e618*/ byte[] ToBytes(byte[] buffer, int index, int count);
            /*0x765a7e8*/ XmlEventCache(string baseUri, bool hasRootNode);
            /*0x765b554*/ void EndEvents();
            /*0x765b568*/ void EventsToWriter(System.Xml.XmlWriter writer);
            /*0x765e200*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x765e298*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x765e31c*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x765e330*/ void WriteEndAttribute();
            /*0x765e338*/ void WriteCData(string text);
            /*0x765e39c*/ void WriteComment(string text);
            /*0x765e3a8*/ void WriteProcessingInstruction(string name, string text);
            /*0x765e420*/ void WriteWhitespace(string ws);
            /*0x765e42c*/ void WriteString(string text);
            /*0x765e450*/ void WriteChars(char[] buffer, int index, int count);
            /*0x765e480*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x765e4b0*/ void WriteRaw(string data);
            /*0x765e4bc*/ void WriteEntityRef(string name);
            /*0x765e4c8*/ void WriteCharEntity(char ch);
            /*0x765e560*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x765e5ec*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x765e6cc*/ void WriteBinHex(byte[] buffer, int index, int count);
            /*0x765e6f8*/ void Close();
            /*0x765e700*/ void Flush();
            /*0x765e708*/ void WriteValue(string value);
            /*0x765e718*/ void Dispose(bool disposing);
            /*0x765e7c8*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x765e834*/ void WriteXmlDeclaration(string xmldecl);
            /*0x765e840*/ void StartElementContent();
            /*0x765e848*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x765e85c*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x765e870*/ void WriteNamespaceDeclaration(string prefix, string ns);
            /*0x765e880*/ void WriteEndBase64();
            /*0x765e1b8*/ void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType);
            /*0x765e344*/ void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1);
            /*0x765e3b8*/ void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1, string s2);
            /*0x765e2ac*/ void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1, string s2, string s3);
            /*0x765e218*/ void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o);
            /*0x765e508*/ void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, object o);
            /*0x765e888*/ int NewEvent();

            enum XmlEventType
            {
                Unknown = 0,
                DocType = 1,
                StartElem = 2,
                StartAttr = 3,
                EndAttr = 4,
                CData = 5,
                Comment = 6,
                PI = 7,
                Whitespace = 8,
                String = 9,
                Raw = 10,
                EntRef = 11,
                CharEnt = 12,
                SurrCharEnt = 13,
                Base64 = 14,
                BinHex = 15,
                XmlDecl1 = 16,
                XmlDecl2 = 17,
                StartContent = 18,
                EndElem = 19,
                FullEndElem = 20,
                Nmsp = 21,
                EndBase64 = 22,
                Close = 23,
                Flush = 24,
                Dispose = 25,
            }

            struct XmlEvent
            {
                /*0x10*/ System.Xml.XmlEventCache.XmlEventType eventType;
                /*0x18*/ string s1;
                /*0x20*/ string s2;
                /*0x28*/ string s3;
                /*0x30*/ object o;

                /*0x773cca8*/ void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType);
                /*0x773ccb0*/ void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1);
                /*0x773ccc0*/ void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1, string s2);
                /*0x773ccf8*/ void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1, string s2, string s3);
                /*0x773cd44*/ void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o);
                /*0x773cdac*/ void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, object o);
                /*0x773cdbc*/ System.Xml.XmlEventCache.XmlEventType get_EventType();
                /*0x773cdc4*/ string get_String1();
                /*0x773cdcc*/ string get_String2();
                /*0x773cdd4*/ string get_String3();
                /*0x773cddc*/ object get_Object();
            }
        }

        class XmlParserContext
        {
            /*0x10*/ System.Xml.XmlNameTable _nt;
            /*0x18*/ System.Xml.XmlNamespaceManager _nsMgr;
            /*0x20*/ string _docTypeName;
            /*0x28*/ string _pubId;
            /*0x30*/ string _sysId;
            /*0x38*/ string _internalSubset;
            /*0x40*/ string _xmlLang;
            /*0x48*/ System.Xml.XmlSpace _xmlSpace;
            /*0x50*/ string _baseURI;
            /*0x58*/ System.Text.Encoding _encoding;

            /*0x773cde4*/ XmlParserContext(System.Xml.XmlNameTable nt, System.Xml.XmlNamespaceManager nsMgr, string xmlLang, System.Xml.XmlSpace xmlSpace);
            /*0x773ce2c*/ XmlParserContext(System.Xml.XmlNameTable nt, System.Xml.XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, System.Xml.XmlSpace xmlSpace);
            /*0x773ce58*/ XmlParserContext(System.Xml.XmlNameTable nt, System.Xml.XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, System.Xml.XmlSpace xmlSpace, System.Text.Encoding enc);
            /*0x773d110*/ System.Xml.XmlNameTable get_NameTable();
            /*0x773d118*/ System.Xml.XmlNamespaceManager get_NamespaceManager();
            /*0x773d120*/ string get_DocTypeName();
            /*0x773d128*/ string get_PublicId();
            /*0x773d130*/ string get_SystemId();
            /*0x773d138*/ string get_BaseURI();
            /*0x773d140*/ string get_InternalSubset();
            /*0x773d148*/ string get_XmlLang();
            /*0x773d150*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x773d158*/ System.Text.Encoding get_Encoding();
            /*0x773d160*/ bool get_HasDtdInfo();
        }

        class XmlRawWriter : System.Xml.XmlWriter
        {
            /*0x18*/ System.Xml.XmlRawWriterBase64Encoder base64Encoder;
            /*0x20*/ System.Xml.IXmlNamespaceResolver resolver;

            /*0x773d9f0*/ XmlRawWriter();
            /*0x773d1dc*/ void WriteStartDocument();
            /*0x773d234*/ void WriteStartDocument(bool standalone);
            /*0x773d28c*/ void WriteEndDocument();
            /*0x773d2e4*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x773d2e8*/ void WriteEndElement();
            /*0x773d340*/ void WriteFullEndElement();
            /*0x773d398*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x773d444*/ string LookupPrefix(string ns);
            /*0x773d49c*/ System.Xml.WriteState get_WriteState();
            /*0x773d4f4*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x773d54c*/ string get_XmlLang();
            /*0x773d5a4*/ void WriteQualifiedName(string localName, string ns);
            /*0x773d5fc*/ void WriteCData(string text);
            /*0x773d60c*/ void WriteCharEntity(char ch);
            /*0x773d6a0*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x773d744*/ void WriteWhitespace(string ws);
            /*0x773d754*/ void WriteChars(char[] buffer, int index, int count);
            /*0x773d784*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x773d7b4*/ void WriteRaw(string data);
            /*0x773d7c4*/ void WriteValue(string value);
            /*0x773d7d4*/ void WriteAttributes(System.Xml.XmlReader reader, bool defattr);
            /*0x773d82c*/ void WriteNode(System.Xml.XmlReader reader, bool defattr);
            /*0x773d884*/ void set_NamespaceResolver(System.Xml.IXmlNamespaceResolver value);
            /*0x773d88c*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x773d890*/ void WriteXmlDeclaration(string xmldecl);
            /*0x38159dc*/ void StartElementContent();
            /*0x773d894*/ void OnRootElement(System.Xml.ConformanceLevel conformanceLevel);
            /*0x3816920*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x773d898*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x773d8a8*/ void WriteQualifiedName(string prefix, string localName, string ns);
            /*0x3816810*/ void WriteNamespaceDeclaration(string prefix, string ns);
            /*0x773d94c*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0x773d954*/ void WriteStartNamespaceDeclaration(string prefix);
            /*0x773d98c*/ void WriteEndNamespaceDeclaration();
            /*0x773d9c4*/ void WriteEndBase64();
            /*0x773d9e0*/ void Close(System.Xml.WriteState currentState);
        }

        class XmlReader : System.IDisposable
        {
            static /*0x0*/ uint IsTextualNodeBitmap;
            static /*0x4*/ uint CanReadContentAsBitmap;
            static /*0x8*/ uint HasValueBitmap;

            static /*0x7741ba8*/ XmlReader();
            static /*0x773fa40*/ bool IsTextualNode(System.Xml.XmlNodeType nodeType);
            static /*0x7740ba8*/ bool CanReadContentAs(System.Xml.XmlNodeType nodeType);
            static /*0x7740c0c*/ bool HasValueInternal(System.Xml.XmlNodeType nodeType);
            static /*0x7740c70*/ System.Exception CreateReadContentAsException(string methodName, System.Xml.XmlNodeType nodeType, System.Xml.IXmlLineInfo lineInfo);
            static /*0x7740e88*/ System.Exception CreateReadElementContentAsException(string methodName, System.Xml.XmlNodeType nodeType, System.Xml.IXmlLineInfo lineInfo);
            static /*0x7741000*/ string AddLineInfo(string message, System.Xml.IXmlLineInfo lineInfo);
            static /*0x7741314*/ System.Xml.XmlReader Create(System.IO.Stream input, System.Xml.XmlReaderSettings settings, string baseUri);
            static /*0x7741564*/ System.Xml.XmlReader Create(System.IO.TextReader input, System.Xml.XmlReaderSettings settings, string baseUri);
            static /*0x7741708*/ System.Xml.XmlReader CreateSqlReader(System.IO.Stream input, System.Xml.XmlReaderSettings settings, System.Xml.XmlParserContext inputContext);
            static /*0x7741a20*/ int CalcBufferSize(System.IO.Stream input);
            /*0x7741ba0*/ XmlReader();
            /*0x773d9f8*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x3814574*/ System.Xml.XmlNodeType get_NodeType();
            /*0x773da00*/ string get_Name();
            /*0x38148bc*/ string get_LocalName();
            /*0x38148bc*/ string get_NamespaceURI();
            /*0x38148bc*/ string get_Prefix();
            /*0x38148bc*/ string get_Value();
            /*0x3814574*/ int get_Depth();
            /*0x38148bc*/ string get_BaseURI();
            /*0x3813ffc*/ bool get_IsEmptyElement();
            /*0x773dae4*/ bool get_IsDefault();
            /*0x773daec*/ char get_QuoteChar();
            /*0x773daf4*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x773dafc*/ string get_XmlLang();
            /*0x773db14*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x773db5c*/ System.Type get_ValueType();
            /*0x773db8c*/ object ReadContentAsObject();
            /*0x773de94*/ bool ReadContentAsBoolean();
            /*0x773e03c*/ System.DateTime ReadContentAsDateTime();
            /*0x773e1e4*/ double ReadContentAsDouble();
            /*0x773e388*/ float ReadContentAsFloat();
            /*0x773e52c*/ decimal ReadContentAsDecimal();
            /*0x773e6d0*/ int ReadContentAsInt();
            /*0x773e874*/ long ReadContentAsLong();
            /*0x773ea18*/ string ReadContentAsString();
            /*0x773ea68*/ object ReadContentAs(System.Type returnType, System.Xml.IXmlNamespaceResolver namespaceResolver);
            /*0x773ecd4*/ bool ReadElementContentAsBoolean();
            /*0x773efb0*/ System.DateTime ReadElementContentAsDateTime();
            /*0x773f074*/ double ReadElementContentAsDouble();
            /*0x773f140*/ float ReadElementContentAsFloat();
            /*0x773f20c*/ decimal ReadElementContentAsDecimal();
            /*0x773f2d4*/ int ReadElementContentAsInt();
            /*0x773f394*/ long ReadElementContentAsLong();
            /*0x773f454*/ string ReadElementContentAsString();
            /*0x3814574*/ int get_AttributeCount();
            /*0x3814a3c*/ string GetAttribute(string name);
            /*0x3814b90*/ string GetAttribute(string name, string namespaceURI);
            /*0x3814964*/ string GetAttribute(int i);
            /*0x38141c4*/ bool MoveToAttribute(string name);
            /*0x3814200*/ bool MoveToAttribute(string name, string ns);
            /*0x773f4e0*/ void MoveToAttribute(int i);
            /*0x3813ffc*/ bool MoveToFirstAttribute();
            /*0x3813ffc*/ bool MoveToNextAttribute();
            /*0x3813ffc*/ bool MoveToElement();
            /*0x3813ffc*/ bool ReadAttributeValue();
            /*0x3813ffc*/ bool Read();
            /*0x3813ffc*/ bool get_EOF();
            /*0x773f5ac*/ void Close();
            /*0x3814574*/ System.Xml.ReadState get_ReadState();
            /*0x773f5b0*/ void Skip();
            /*0x38148bc*/ System.Xml.XmlNameTable get_NameTable();
            /*0x3814a3c*/ string LookupNamespace(string prefix);
            /*0x773f6b8*/ bool get_CanResolveEntity();
            /*0x38159dc*/ void ResolveEntity();
            /*0x773f6c0*/ int ReadContentAsBase64(byte[] buffer, int index, int count);
            /*0x773f76c*/ int ReadContentAsBinHex(byte[] buffer, int index, int count);
            /*0x773f818*/ bool get_CanReadValueChunk();
            /*0x773f820*/ int ReadValueChunk(char[] buffer, int index, int count);
            /*0x773f878*/ string ReadString();
            /*0x773faa4*/ System.Xml.XmlNodeType MoveToContent();
            /*0x773fb28*/ void ReadStartElement();
            /*0x773fc1c*/ string ReadElementString();
            /*0x773fe74*/ void ReadEndElement();
            /*0x773ff68*/ bool IsStartElement();
            /*0x773ff8c*/ bool IsStartElement(string localname, string ns);
            /*0x7740010*/ string ReadInnerXml();
            /*0x7740488*/ void WriteNode(System.Xml.XmlWriter xtw, bool defattr);
            /*0x77403b4*/ void WriteAttributeValue(System.Xml.XmlWriter xtw);
            /*0x77402b8*/ System.Xml.XmlWriter CreateWriterForInnerOuterXml(System.IO.StringWriter sw);
            /*0x774098c*/ void SetNamespacesFlag(System.Xml.XmlTextWriter xtw);
            /*0x7740b24*/ bool get_HasAttributes();
            /*0x7740b48*/ void Dispose();
            /*0x7740b5c*/ void Dispose(bool disposing);
            /*0x7740ba0*/ System.Xml.XmlNamespaceManager get_NamespaceManager();
            /*0x773f5e4*/ bool SkipSubtree();
            /*0x773dc48*/ System.Exception CreateReadContentAsException(string methodName);
            /*0x7740de8*/ System.Exception CreateReadElementContentAsException(string methodName);
            /*0x773dbdc*/ bool CanReadContentAs();
            /*0x773dce8*/ string InternalReadContentAsString();
            /*0x773ed94*/ bool SetupReadElementContentAsXxx(string methodName);
            /*0x773eee8*/ void FinishReadElementContentAsXxx();
            /*0x774122c*/ bool get_IsDefaultInternal();
            /*0x774130c*/ System.Xml.IDtdInfo get_DtdInfo();
        }

        class XmlReaderSettings
        {
            static /*0x0*/ System.Nullable<bool> s_enableLegacyXmlSettings;
            /*0x10*/ bool useAsync;
            /*0x18*/ System.Xml.XmlNameTable nameTable;
            /*0x20*/ System.Xml.XmlResolver xmlResolver;
            /*0x28*/ int lineNumberOffset;
            /*0x2c*/ int linePositionOffset;
            /*0x30*/ System.Xml.ConformanceLevel conformanceLevel;
            /*0x34*/ bool checkCharacters;
            /*0x38*/ long maxCharactersInDocument;
            /*0x40*/ long maxCharactersFromEntities;
            /*0x48*/ bool ignoreWhitespace;
            /*0x49*/ bool ignorePIs;
            /*0x4a*/ bool ignoreComments;
            /*0x4c*/ System.Xml.DtdProcessing dtdProcessing;
            /*0x50*/ System.Xml.ValidationType validationType;
            /*0x54*/ System.Xml.Schema.XmlSchemaValidationFlags validationFlags;
            /*0x58*/ System.Xml.Schema.XmlSchemaSet schemas;
            /*0x60*/ System.Xml.Schema.ValidationEventHandler valEventHandler;
            /*0x68*/ bool closeInput;
            /*0x69*/ bool isReadOnly;
            /*0x6a*/ bool <IsXmlResolverSet>k__BackingField;

            static /*0x7742844*/ System.Xml.XmlResolver CreateDefaultResolver();
            static /*0x7742750*/ bool EnableLegacyXmlSettings();
            /*0x77413a4*/ XmlReaderSettings();
            /*0x7741c0c*/ bool get_Async();
            /*0x7741c14*/ void set_Async(bool value);
            /*0x7741d28*/ System.Xml.XmlNameTable get_NameTable();
            /*0x7741d30*/ void set_NameTable(System.Xml.XmlNameTable value);
            /*0x7741d94*/ bool get_IsXmlResolverSet();
            /*0x7741d9c*/ void set_IsXmlResolverSet(bool value);
            /*0x7741da8*/ void set_XmlResolver(System.Xml.XmlResolver value);
            /*0x7741e18*/ System.Xml.XmlResolver GetXmlResolver();
            /*0x7741e20*/ System.Xml.XmlResolver GetXmlResolver_CheckConfig();
            /*0x7741e50*/ int get_LineNumberOffset();
            /*0x7741e58*/ void set_LineNumberOffset(int value);
            /*0x7741eb4*/ int get_LinePositionOffset();
            /*0x7741ebc*/ void set_LinePositionOffset(int value);
            /*0x7741f18*/ System.Xml.ConformanceLevel get_ConformanceLevel();
            /*0x7741f20*/ void set_ConformanceLevel(System.Xml.ConformanceLevel value);
            /*0x7741fcc*/ bool get_CheckCharacters();
            /*0x7741fd4*/ void set_CheckCharacters(bool value);
            /*0x7742034*/ long get_MaxCharactersInDocument();
            /*0x774203c*/ void set_MaxCharactersInDocument(long value);
            /*0x77420e4*/ long get_MaxCharactersFromEntities();
            /*0x77420ec*/ void set_MaxCharactersFromEntities(long value);
            /*0x7742194*/ bool get_IgnoreWhitespace();
            /*0x774219c*/ void set_IgnoreWhitespace(bool value);
            /*0x77421fc*/ bool get_IgnoreProcessingInstructions();
            /*0x7742204*/ void set_IgnoreProcessingInstructions(bool value);
            /*0x7742264*/ bool get_IgnoreComments();
            /*0x774226c*/ void set_IgnoreComments(bool value);
            /*0x77422cc*/ System.Xml.DtdProcessing get_DtdProcessing();
            /*0x77422d4*/ void set_DtdProcessing(System.Xml.DtdProcessing value);
            /*0x7742380*/ bool get_CloseInput();
            /*0x7742388*/ void set_CloseInput(bool value);
            /*0x77423e8*/ System.Xml.ValidationType get_ValidationType();
            /*0x77423f0*/ void set_ValidationType(System.Xml.ValidationType value);
            /*0x774249c*/ System.Xml.Schema.XmlSchemaValidationFlags get_ValidationFlags();
            /*0x77424a4*/ void set_ValidationFlags(System.Xml.Schema.XmlSchemaValidationFlags value);
            /*0x7742550*/ System.Xml.Schema.XmlSchemaSet get_Schemas();
            /*0x77425c0*/ void set_Schemas(System.Xml.Schema.XmlSchemaSet value);
            /*0x7742624*/ System.Xml.XmlReaderSettings Clone();
            /*0x774268c*/ System.Xml.Schema.ValidationEventHandler GetEventHandler();
            /*0x77413c4*/ System.Xml.XmlReader CreateReader(System.IO.Stream input, System.Uri baseUri, string baseUriString, System.Xml.XmlParserContext inputContext);
            /*0x77415f0*/ System.Xml.XmlReader CreateReader(System.IO.TextReader input, string baseUriString, System.Xml.XmlParserContext inputContext);
            /*0x7742694*/ void set_ReadOnly(bool value);
            /*0x7741c74*/ void CheckReadOnly(string propertyName);
            /*0x7741c04*/ void Initialize();
            /*0x77426a0*/ void Initialize(System.Xml.XmlResolver resolver);
            /*0x7741aa4*/ System.Xml.XmlReader AddValidation(System.Xml.XmlReader reader);
            /*0x7742898*/ System.Xml.XmlValidatingReaderImpl CreateDtdValidatingReader(System.Xml.XmlReader baseReader);
        }

        enum XmlSpace
        {
            None = 0,
            Default = 1,
            Preserve = 2,
        }

        class XmlTextEncoder
        {
            /*0x10*/ System.IO.TextWriter textWriter;
            /*0x18*/ bool inAttribute;
            /*0x1a*/ char quoteChar;
            /*0x20*/ System.Text.StringBuilder attrValue;
            /*0x28*/ bool cacheAttrValue;
            /*0x30*/ System.Xml.XmlCharType xmlCharType;

            /*0x7742910*/ XmlTextEncoder(System.IO.TextWriter textWriter);
            /*0x7742960*/ void set_QuoteChar(char value);
            /*0x7742968*/ void StartAttribute(bool cacheAttrValue);
            /*0x7742a18*/ void EndAttribute();
            /*0x7742a50*/ string get_AttributeValue();
            /*0x7742a94*/ void WriteSurrogateChar(char lowChar, char highChar);
            /*0x7742b48*/ void Write(char[] array, int offset, int count);
            /*0x7743054*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x77431e4*/ void Write(string text);
            /*0x77436c8*/ void WriteRawWithSurrogateChecking(string text);
            /*0x77438b8*/ void WriteRaw(char[] array, int offset, int count);
            /*0x77439e4*/ void WriteCharEntity(char ch);
            /*0x7743bbc*/ void WriteEntityRef(string name);
            /*0x7743620*/ void WriteStringFragment(string str, int offset, int count, char[] helperBuffer);
            /*0x7742f68*/ void WriteCharEntityImpl(char ch);
            /*0x7743b24*/ void WriteCharEntityImpl(string strVal);
            /*0x7742fe4*/ void WriteEntityRefImpl(string name);
        }

        class XmlTextReader : System.Xml.XmlReader, System.Xml.IXmlLineInfo, System.Xml.IXmlNamespaceResolver
        {
            /*0x10*/ System.Xml.XmlTextReaderImpl impl;

            /*0x7743c28*/ XmlTextReader(System.IO.Stream input);
            /*0x7743ce8*/ XmlTextReader(string url, System.IO.Stream input, System.Xml.XmlNameTable nt);
            /*0x7743dc0*/ XmlTextReader(System.IO.TextReader input);
            /*0x7743e80*/ XmlTextReader(System.IO.TextReader input, System.Xml.XmlNameTable nt);
            /*0x7743f48*/ System.Xml.XmlNodeType get_NodeType();
            /*0x7743f68*/ string get_Name();
            /*0x7743f88*/ string get_LocalName();
            /*0x7743fa8*/ string get_NamespaceURI();
            /*0x7743fc8*/ string get_Prefix();
            /*0x7743fe8*/ string get_Value();
            /*0x7744008*/ int get_Depth();
            /*0x7744028*/ string get_BaseURI();
            /*0x774404c*/ bool get_IsEmptyElement();
            /*0x7744070*/ bool get_IsDefault();
            /*0x7744094*/ char get_QuoteChar();
            /*0x77440b8*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x77440dc*/ string get_XmlLang();
            /*0x7744100*/ int get_AttributeCount();
            /*0x7744124*/ string GetAttribute(string name);
            /*0x7744148*/ string GetAttribute(string localName, string namespaceURI);
            /*0x774416c*/ string GetAttribute(int i);
            /*0x7744190*/ bool MoveToAttribute(string name);
            /*0x77441b4*/ bool MoveToAttribute(string localName, string namespaceURI);
            /*0x77441d8*/ void MoveToAttribute(int i);
            /*0x77441fc*/ bool MoveToFirstAttribute();
            /*0x7744220*/ bool MoveToNextAttribute();
            /*0x7744244*/ bool MoveToElement();
            /*0x7744268*/ bool ReadAttributeValue();
            /*0x774428c*/ bool Read();
            /*0x77442b0*/ bool get_EOF();
            /*0x77442d4*/ void Close();
            /*0x77442f8*/ System.Xml.ReadState get_ReadState();
            /*0x774431c*/ void Skip();
            /*0x7744340*/ System.Xml.XmlNameTable get_NameTable();
            /*0x7744364*/ string LookupNamespace(string prefix);
            /*0x774439c*/ bool get_CanResolveEntity();
            /*0x77443a4*/ void ResolveEntity();
            /*0x77443c8*/ int ReadContentAsBase64(byte[] buffer, int index, int count);
            /*0x77443ec*/ int ReadContentAsBinHex(byte[] buffer, int index, int count);
            /*0x7744410*/ bool get_CanReadValueChunk();
            /*0x7744418*/ string ReadString();
            /*0x7744440*/ bool HasLineInfo();
            /*0x7744448*/ int get_LineNumber();
            /*0x7744464*/ int get_LinePosition();
            /*0x7744480*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x774449c*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0x77444c0*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            /*0x7740a78*/ bool get_Namespaces();
            /*0x77444dc*/ bool get_Normalization();
            /*0x77444f8*/ void set_Normalization(bool value);
            /*0x7744518*/ System.Xml.WhitespaceHandling get_WhitespaceHandling();
            /*0x7744534*/ void set_WhitespaceHandling(System.Xml.WhitespaceHandling value);
            /*0x7744550*/ void set_EntityHandling(System.Xml.EntityHandling value);
            /*0x774456c*/ void set_XmlResolver(System.Xml.XmlResolver value);
            /*0x7744588*/ System.Xml.XmlTextReaderImpl get_Impl();
            /*0x7744590*/ System.Xml.XmlNamespaceManager get_NamespaceManager();
            /*0x77445b4*/ void set_XmlValidatingReaderCompatibilityMode(bool value);
            /*0x77445d4*/ System.Xml.IDtdInfo get_DtdInfo();
        }

        class XmlTextReaderImpl : System.Xml.XmlReader, System.Xml.IXmlLineInfo, System.Xml.IXmlNamespaceResolver
        {
            /*0x10*/ bool useAsync;
            /*0x18*/ System.Xml.XmlTextReaderImpl.LaterInitParam laterInitParam;
            /*0x20*/ System.Xml.XmlCharType xmlCharType;
            /*0x28*/ System.Xml.XmlTextReaderImpl.ParsingState ps;
            /*0xa0*/ System.Xml.XmlTextReaderImpl.ParsingFunction parsingFunction;
            /*0xa4*/ System.Xml.XmlTextReaderImpl.ParsingFunction nextParsingFunction;
            /*0xa8*/ System.Xml.XmlTextReaderImpl.ParsingFunction nextNextParsingFunction;
            /*0xb0*/ System.Xml.XmlTextReaderImpl.NodeData[] nodes;
            /*0xb8*/ System.Xml.XmlTextReaderImpl.NodeData curNode;
            /*0xc0*/ int index;
            /*0xc4*/ int curAttrIndex;
            /*0xc8*/ int attrCount;
            /*0xcc*/ int attrHashtable;
            /*0xd0*/ int attrDuplWalkCount;
            /*0xd4*/ bool attrNeedNamespaceLookup;
            /*0xd5*/ bool fullAttrCleanup;
            /*0xd8*/ System.Xml.XmlTextReaderImpl.NodeData[] attrDuplSortingArray;
            /*0xe0*/ System.Xml.XmlNameTable nameTable;
            /*0xe8*/ bool nameTableFromSettings;
            /*0xf0*/ System.Xml.XmlResolver xmlResolver;
            /*0xf8*/ string url;
            /*0x100*/ bool normalize;
            /*0x101*/ bool supportNamespaces;
            /*0x104*/ System.Xml.WhitespaceHandling whitespaceHandling;
            /*0x108*/ System.Xml.DtdProcessing dtdProcessing;
            /*0x10c*/ System.Xml.EntityHandling entityHandling;
            /*0x110*/ bool ignorePIs;
            /*0x111*/ bool ignoreComments;
            /*0x112*/ bool checkCharacters;
            /*0x114*/ int lineNumberOffset;
            /*0x118*/ int linePositionOffset;
            /*0x11c*/ bool closeInput;
            /*0x120*/ long maxCharactersInDocument;
            /*0x128*/ long maxCharactersFromEntities;
            /*0x130*/ bool v1Compat;
            /*0x138*/ System.Xml.XmlNamespaceManager namespaceManager;
            /*0x140*/ string lastPrefix;
            /*0x148*/ System.Xml.XmlTextReaderImpl.XmlContext xmlContext;
            /*0x150*/ System.Xml.XmlTextReaderImpl.ParsingState[] parsingStatesStack;
            /*0x158*/ int parsingStatesStackTop;
            /*0x160*/ string reportedBaseUri;
            /*0x168*/ System.Text.Encoding reportedEncoding;
            /*0x170*/ System.Xml.IDtdInfo dtdInfo;
            /*0x178*/ System.Xml.XmlNodeType fragmentType;
            /*0x180*/ System.Xml.XmlParserContext fragmentParserContext;
            /*0x188*/ bool fragment;
            /*0x190*/ System.Xml.IncrementalReadDecoder incReadDecoder;
            /*0x198*/ System.Xml.XmlTextReaderImpl.IncrementalReadState incReadState;
            /*0x19c*/ System.Xml.LineInfo incReadLineInfo;
            /*0x1a8*/ System.Xml.BinHexDecoder binHexDecoder;
            /*0x1b0*/ System.Xml.Base64Decoder base64Decoder;
            /*0x1b8*/ int incReadDepth;
            /*0x1bc*/ int incReadLeftStartPos;
            /*0x1c0*/ int incReadLeftEndPos;
            /*0x1c4*/ int attributeValueBaseEntityId;
            /*0x1c8*/ bool emptyEntityInAttributeResolved;
            /*0x1d0*/ System.Xml.IValidationEventHandling validationEventHandling;
            /*0x1d8*/ System.Xml.XmlTextReaderImpl.OnDefaultAttributeUseDelegate onDefaultAttributeUse;
            /*0x1e0*/ bool validatingReaderCompatFlag;
            /*0x1e1*/ bool addDefaultAttributesAndNormalize;
            /*0x1e8*/ System.Text.StringBuilder stringBuilder;
            /*0x1f0*/ bool rootElementParsed;
            /*0x1f1*/ bool standalone;
            /*0x1f4*/ int nextEntityId;
            /*0x1f8*/ System.Xml.XmlTextReaderImpl.ParsingMode parsingMode;
            /*0x1fc*/ System.Xml.ReadState readState;
            /*0x200*/ System.Xml.IDtdEntityInfo lastEntity;
            /*0x208*/ bool afterResetState;
            /*0x20c*/ int documentStartBytePos;
            /*0x210*/ int readValueOffset;
            /*0x218*/ long charactersInDocument;
            /*0x220*/ long charactersFromEntities;
            /*0x228*/ System.Collections.Generic.Dictionary<System.Xml.IDtdEntityInfo, System.Xml.IDtdEntityInfo> currentEntities;
            /*0x230*/ bool disableUndeclaredEntityCheck;
            /*0x238*/ System.Xml.XmlReader outerReader;
            /*0x240*/ bool xmlResolverIsSet;
            /*0x248*/ string Xml;
            /*0x250*/ string XmlNs;
            /*0x258*/ System.Threading.Tasks.Task<System.Tuple<int, int, int, bool>> parseText_dummyTask;

            static /*0x773c87c*/ void AdjustLineInfo(char[] chars, int startPos, int endPos, bool isNormalized, ref System.Xml.LineInfo lineInfo);
            static /*0x773c930*/ void AdjustLineInfo(string str, int startPos, int endPos, bool isNormalized, ref System.Xml.LineInfo lineInfo);
            static /*0x773c8b4*/ void AdjustLineInfo(char* pChars, int length, bool isNormalized, ref System.Xml.LineInfo lineInfo);
            static /*0x773c980*/ string StripSpaces(string value);
            static /*0x773cb98*/ void StripSpaces(char[] value, int index, ref int len);
            static /*0x7730258*/ void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count);
            static /*0x7734108*/ void BlockCopy(byte[] src, int srcOffset, byte[] dst, int dstOffset, int count);
            /*0x7728aa8*/ XmlTextReaderImpl(System.Xml.XmlNameTable nt);
            /*0x7728ecc*/ XmlTextReaderImpl(System.Xml.XmlResolver resolver, System.Xml.XmlReaderSettings settings, System.Xml.XmlParserContext context);
            /*0x772964c*/ XmlTextReaderImpl(System.IO.Stream input);
            /*0x77296d0*/ XmlTextReaderImpl(string url, System.IO.Stream input, System.Xml.XmlNameTable nt);
            /*0x7729810*/ XmlTextReaderImpl(System.IO.TextReader input);
            /*0x772996c*/ XmlTextReaderImpl(System.IO.TextReader input, System.Xml.XmlNameTable nt);
            /*0x7729894*/ XmlTextReaderImpl(string url, System.IO.TextReader input, System.Xml.XmlNameTable nt);
            /*0x7729998*/ XmlTextReaderImpl(string xmlFragment, System.Xml.XmlNodeType fragType, System.Xml.XmlParserContext context);
            /*0x7729e18*/ XmlTextReaderImpl(string xmlFragment, System.Xml.XmlParserContext context);
            /*0x772a58c*/ XmlTextReaderImpl(System.IO.Stream stream, byte[] bytes, int byteCount, System.Xml.XmlReaderSettings settings, System.Uri baseUri, string baseUriStr, System.Xml.XmlParserContext context, bool closeInput);
            /*0x772a8f4*/ XmlTextReaderImpl(System.IO.TextReader input, System.Xml.XmlReaderSettings settings, string baseUriStr, System.Xml.XmlParserContext context);
            /*0x772aaa0*/ XmlTextReaderImpl(string xmlFragment, System.Xml.XmlParserContext context, System.Xml.XmlReaderSettings settings);
            /*0x7729f68*/ void FinishInitUriString();
            /*0x772a858*/ void FinishInitStream();
            /*0x772aa20*/ void FinishInitTextReader();
            /*0x772ab1c*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x772ac90*/ System.Xml.XmlNodeType get_NodeType();
            /*0x772acac*/ string get_Name();
            /*0x772acd0*/ string get_LocalName();
            /*0x772acec*/ string get_NamespaceURI();
            /*0x772ad08*/ string get_Prefix();
            /*0x772ad24*/ string get_Value();
            /*0x772af18*/ int get_Depth();
            /*0x772af34*/ string get_BaseURI();
            /*0x772af3c*/ bool get_IsEmptyElement();
            /*0x772af58*/ bool get_IsDefault();
            /*0x772af74*/ char get_QuoteChar();
            /*0x772afa4*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x772afc0*/ string get_XmlLang();
            /*0x772afdc*/ System.Xml.ReadState get_ReadState();
            /*0x772afe4*/ bool get_EOF();
            /*0x772aff4*/ System.Xml.XmlNameTable get_NameTable();
            /*0x772affc*/ bool get_CanResolveEntity();
            /*0x772b004*/ int get_AttributeCount();
            /*0x772b00c*/ string GetAttribute(string name);
            /*0x772b23c*/ string GetAttribute(string localName, string namespaceURI);
            /*0x772b398*/ string GetAttribute(int i);
            /*0x772b434*/ bool MoveToAttribute(string name);
            /*0x772b5bc*/ bool MoveToAttribute(string localName, string namespaceURI);
            /*0x772b758*/ void MoveToAttribute(int i);
            /*0x772b824*/ bool MoveToFirstAttribute();
            /*0x772b8a4*/ bool MoveToNextAttribute();
            /*0x772b944*/ bool MoveToElement();
            /*0x772b9d4*/ void FinishInit();
            /*0x772ba1c*/ bool Read();
            /*0x772dbec*/ void Close();
            /*0x772dcc0*/ void Skip();
            /*0x772de48*/ string LookupNamespace(string prefix);
            /*0x772de80*/ bool ReadAttributeValue();
            /*0x772e5ac*/ void ResolveEntity();
            /*0x772ec98*/ void set_OuterReader(System.Xml.XmlReader value);
            /*0x772eca8*/ void MoveOffEntityReference();
            /*0x772ed58*/ string ReadString();
            /*0x772ed74*/ int ReadContentAsBase64(byte[] buffer, int index, int count);
            /*0x772f58c*/ int ReadContentAsBinHex(byte[] buffer, int index, int count);
            /*0x772f834*/ bool get_CanReadValueChunk();
            /*0x772f83c*/ int ReadValueChunk(char[] buffer, int index, int count);
            /*0x773026c*/ bool HasLineInfo();
            /*0x7730274*/ int get_LineNumber();
            /*0x7730290*/ int get_LinePosition();
            /*0x77302ac*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x77302f4*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0x7730304*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            /*0x77302d0*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x7730328*/ string LookupPrefix(string namespaceName);
            /*0x773034c*/ bool get_Namespaces();
            /*0x7730354*/ void set_Namespaces(bool value);
            /*0x7730534*/ bool get_Normalization();
            /*0x773053c*/ void set_Normalization(bool value);
            /*0x7730658*/ System.Xml.WhitespaceHandling get_WhitespaceHandling();
            /*0x7730660*/ void set_WhitespaceHandling(System.Xml.WhitespaceHandling value);
            /*0x7730728*/ void set_EntityHandling(System.Xml.EntityHandling value);
            /*0x77307ac*/ bool get_IsResolverSet();
            /*0x77307b4*/ void set_XmlResolver(System.Xml.XmlResolver value);
            /*0x773083c*/ System.Xml.XmlNameTable get_DtdParserProxy_NameTable();
            /*0x7730844*/ System.Xml.IXmlNamespaceResolver get_DtdParserProxy_NamespaceResolver();
            /*0x773084c*/ bool get_DtdParserProxy_DtdValidation();
            /*0x773086c*/ bool get_DtdParserProxy_Normalization();
            /*0x7730874*/ bool get_DtdParserProxy_Namespaces();
            /*0x773087c*/ bool get_DtdParserProxy_V1CompatibilityMode();
            /*0x7730884*/ System.Uri get_DtdParserProxy_BaseUri();
            /*0x7730938*/ bool get_DtdParserProxy_IsEof();
            /*0x7730940*/ char[] get_DtdParserProxy_ParsingBuffer();
            /*0x7730948*/ int get_DtdParserProxy_ParsingBufferLength();
            /*0x7730950*/ int get_DtdParserProxy_CurrentPosition();
            /*0x7730958*/ void set_DtdParserProxy_CurrentPosition(int value);
            /*0x7730960*/ int get_DtdParserProxy_EntityStackLength();
            /*0x773096c*/ bool get_DtdParserProxy_IsEntityEolNormalized();
            /*0x7730974*/ System.Xml.IValidationEventHandling get_DtdParserProxy_ValidationEventHandling();
            /*0x773097c*/ void DtdParserProxy_OnNewLine(int pos);
            /*0x77309a4*/ int get_DtdParserProxy_LineNo();
            /*0x77309ac*/ int get_DtdParserProxy_LineStartPosition();
            /*0x77309b4*/ int DtdParserProxy_ReadData();
            /*0x7730e10*/ int DtdParserProxy_ParseNumericCharRef(System.Text.StringBuilder internalSubsetBuilder);
            /*0x7730edc*/ int DtdParserProxy_ParseNamedCharRef(bool expand, System.Text.StringBuilder internalSubsetBuilder);
            /*0x7730f48*/ void DtdParserProxy_ParsePI(System.Text.StringBuilder sb);
            /*0x77312fc*/ void DtdParserProxy_ParseComment(System.Text.StringBuilder sb);
            /*0x77316a8*/ bool get_IsResolverNull();
            /*0x77316e8*/ System.Xml.XmlResolver GetTempResolver();
            /*0x7731748*/ bool DtdParserProxy_PushEntity(System.Xml.IDtdEntityInfo entity, ref int entityId);
            /*0x7731ef4*/ bool DtdParserProxy_PopEntity(ref System.Xml.IDtdEntityInfo oldEntity, ref int newEntityId);
            /*0x7731fa4*/ bool DtdParserProxy_PushExternalSubset(string systemId, string publicId);
            /*0x77326cc*/ void DtdParserProxy_PushInternalDtd(string baseUri, string internalDtd);
            /*0x7732974*/ void DtdParserProxy_Throw(System.Exception e);
            /*0x7732a04*/ void DtdParserProxy_OnSystemId(string systemId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo systemLiteralLineInfo);
            /*0x7732b0c*/ void DtdParserProxy_OnPublicId(string publicId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo publicLiteralLineInfo);
            /*0x7732b98*/ void Throw(int pos, string res, string arg);
            /*0x7732c40*/ void Throw(int pos, string res, string[] args);
            /*0x7732ce8*/ void Throw(int pos, string res);
            /*0x772a83c*/ void Throw(string res);
            /*0x7732d10*/ void Throw(string res, int lineNo, int linePos);
            /*0x7732bac*/ void Throw(string res, string arg);
            /*0x7732da4*/ void Throw(string res, string arg, int lineNo, int linePos);
            /*0x7732c54*/ void Throw(string res, string[] args);
            /*0x7732e28*/ void Throw(string res, string arg, System.Exception innerException);
            /*0x7732ea8*/ void Throw(string res, string[] args, System.Exception innerException);
            /*0x773297c*/ void Throw(System.Exception e);
            /*0x7732f5c*/ void ReThrow(System.Exception e, int lineNo, int linePos);
            /*0x772d9f4*/ void ThrowWithoutLineInfo(string res);
            /*0x7732ffc*/ void ThrowWithoutLineInfo(string res, string arg);
            /*0x773306c*/ void ThrowWithoutLineInfo(string res, string[] args, System.Exception innerException);
            /*0x77330f0*/ void ThrowInvalidChar(char[] data, int length, int invCharPos);
            /*0x7732f48*/ void SetErrorState();
            /*0x7731604*/ void SendValidationEvent(System.Xml.Schema.XmlSeverityType severity, string code, string arg, int lineNo, int linePos);
            /*0x7733160*/ void SendValidationEvent(System.Xml.Schema.XmlSeverityType severity, System.Xml.Schema.XmlSchemaException exception);
            /*0x772b4f8*/ bool get_InAttributeValueIterator();
            /*0x772b51c*/ void FinishAttributeValueIterator();
            /*0x773085c*/ bool get_DtdValidation();
            /*0x77297c8*/ void InitStreamInput(System.IO.Stream stream, System.Text.Encoding encoding);
            /*0x77297f4*/ void InitStreamInput(string baseUriStr, System.IO.Stream stream, System.Text.Encoding encoding);
            /*0x7733370*/ void InitStreamInput(System.Uri baseUri, System.IO.Stream stream, System.Text.Encoding encoding);
            /*0x77333d0*/ void InitStreamInput(System.Uri baseUri, string baseUriStr, System.IO.Stream stream, System.Text.Encoding encoding);
            /*0x772a248*/ void InitStreamInput(System.Uri baseUri, string baseUriStr, System.IO.Stream stream, byte[] bytes, int byteCount, System.Text.Encoding encoding);
            /*0x772998c*/ void InitTextReaderInput(string baseUriStr, System.IO.TextReader input);
            /*0x7733774*/ void InitTextReaderInput(string baseUriStr, System.Uri baseUri, System.IO.TextReader input);
            /*0x7729aa0*/ void InitStringInput(string baseUriStr, System.Text.Encoding originalEncoding, string str);
            /*0x7729ba8*/ void InitFragmentReader(System.Xml.XmlNodeType fragmentType, System.Xml.XmlParserContext parserContext, bool allowXmlDeclFragment);
            /*0x772a520*/ void ProcessDtdFromParserContext(System.Xml.XmlParserContext context);
            /*0x772c670*/ void OpenUrl();
            /*0x7733a9c*/ void OpenUrlDelegate(object xmlResolver);
            /*0x77333e0*/ System.Text.Encoding DetectEncoding();
            /*0x7733608*/ void SetupEncoding(System.Text.Encoding encoding);
            /*0x7733bc4*/ void SwitchEncoding(System.Text.Encoding newEncoding);
            /*0x7733d60*/ System.Text.Encoding CheckEncoding(string newEncodingName);
            /*0x7733cb4*/ void UnDecodeChars();
            /*0x77340a4*/ void SwitchEncodingToUTF8();
            /*0x77309b8*/ int ReadData();
            /*0x7734110*/ int GetChars(int maxCharsCount);
            /*0x7734228*/ void InvalidCharRecovery(ref int bytesCount, ref int charsCount);
            /*0x772dbf4*/ void Close(bool closeInput);
            /*0x7734418*/ void ShiftBuffer(int sourcePos, int destPos, int count);
            /*0x772c828*/ bool ParseXmlDeclaration(bool isTextDecl);
            /*0x772c180*/ bool ParseDocumentContent();
            /*0x772be48*/ bool ParseElementContent();
            /*0x77359a4*/ void ThrowUnclosedElements();
            /*0x77348ac*/ void ParseElement();
            /*0x7736190*/ void AddDefaultAttributesAndNormalize();
            /*0x77355ac*/ void ParseEndElement();
            /*0x773731c*/ void ThrowTagMismatch(System.Xml.XmlTextReaderImpl.NodeData startTag);
            /*0x7735b4c*/ void ParseAttributes();
            /*0x7736ba8*/ void ElementNamespaceLookup();
            /*0x773726c*/ void AttributeNamespaceLookup();
            /*0x77383f8*/ void AttributeDuplCheck();
            /*0x7738024*/ void OnDefaultNamespaceDecl(System.Xml.XmlTextReaderImpl.NodeData attr);
            /*0x7738128*/ void OnNamespaceDecl(System.Xml.XmlTextReaderImpl.NodeData attr);
            /*0x77381f8*/ void OnXmlReservedAttribute(System.Xml.XmlTextReaderImpl.NodeData attr);
            /*0x7737708*/ void ParseAttributeValueSlow(int curPos, char quoteChar, System.Xml.XmlTextReaderImpl.NodeData attr);
            /*0x7738b28*/ void AddAttributeChunkToList(System.Xml.XmlTextReaderImpl.NodeData attr, System.Xml.XmlTextReaderImpl.NodeData chunk, ref System.Xml.XmlTextReaderImpl.NodeData lastChunk);
            /*0x773503c*/ bool ParseText();
            /*0x772fc78*/ bool ParseText(ref int startPos, ref int endPos, ref int outOrChars);
            /*0x772ad6c*/ void FinishPartialValue();
            /*0x772ae28*/ void FinishOtherValueIterator();
            /*0x772da74*/ void SkipPartialTextValue();
            /*0x772dab4*/ void FinishReadValueChunk();
            /*0x772dad4*/ void FinishReadContentAsBinary();
            /*0x772db24*/ void FinishReadElementContentAsBinary();
            /*0x77353b0*/ bool ParseRootLevelWhitespace();
            /*0x772d5bc*/ void ParseEntityReference();
            /*0x7734d74*/ System.Xml.XmlTextReaderImpl.EntityType HandleEntityReference(bool isInAttributeValue, System.Xml.XmlTextReaderImpl.EntityExpandType expandType, ref int charRefEndPos);
            /*0x772e7f4*/ System.Xml.XmlTextReaderImpl.EntityType HandleGeneralEntityReference(string name, bool isInAttributeValue, bool pushFakeEntityIfNullResolver, int entityStartLinePos);
            /*0x7734094*/ bool get_InEntity();
            /*0x7733228*/ bool HandleEntityEnd(bool checkEntityNesting);
            /*0x772d630*/ void SetupEndEntityNodeInContent();
            /*0x7738ef8*/ void SetupEndEntityNodeInAttribute();
            /*0x77345a4*/ bool ParsePI();
            /*0x7730f8c*/ bool ParsePI(System.Text.StringBuilder piInDtdStringBuilder);
            /*0x7738f70*/ bool ParsePIValue(ref int outStartPos, ref int outEndPos);
            /*0x77345ac*/ bool ParseComment();
            /*0x7734610*/ void ParseCData();
            /*0x77314ac*/ void ParseCDataOrComment(System.Xml.XmlNodeType type);
            /*0x7739300*/ bool ParseCDataOrComment(System.Xml.XmlNodeType type, ref int outStartPos, ref int outEndPos);
            /*0x7734618*/ bool ParseDoctypeDecl();
            /*0x773973c*/ void ParseDtd();
            /*0x7739a58*/ void SkipDtd();
            /*0x7739db8*/ void SkipPublicOrSystemIdLiteral();
            /*0x7739e70*/ void SkipUntil(char stopChar, bool recognizeLiterals);
            /*0x7732474*/ int EatWhitespaces(System.Text.StringBuilder sb);
            /*0x7738d20*/ int ParseCharRefInline(int startPos, ref int charCount, ref System.Xml.XmlTextReaderImpl.EntityType entityType);
            /*0x7730e30*/ int ParseNumericCharRef(bool expand, System.Text.StringBuilder internalSubsetBuilder, ref System.Xml.XmlTextReaderImpl.EntityType entityType);
            /*0x773a2ac*/ int ParseNumericCharRefInline(int startPos, bool expand, System.Text.StringBuilder internalSubsetBuilder, ref int charCount, ref System.Xml.XmlTextReaderImpl.EntityType entityType);
            /*0x7730ee4*/ int ParseNamedCharRef(bool expand, System.Text.StringBuilder internalSubsetBuilder);
            /*0x773a930*/ int ParseNamedCharRefInline(int startPos, bool expand, System.Text.StringBuilder internalSubsetBuilder);
            /*0x7734440*/ int ParseName();
            /*0x7735b3c*/ int ParseQName(ref int colonPos);
            /*0x773ac0c*/ int ParseQName(bool isQName, int startOffset, ref int colonPos);
            /*0x773aea0*/ bool ReadDataInName(ref int pos);
            /*0x7738b8c*/ string ParseEntityName();
            /*0x772d534*/ System.Xml.XmlTextReaderImpl.NodeData AddNode(int nodeIndex, int nodeDepth);
            /*0x773aee0*/ System.Xml.XmlTextReaderImpl.NodeData AllocNode(int nodeIndex, int nodeDepth);
            /*0x7732a90*/ System.Xml.XmlTextReaderImpl.NodeData AddAttributeNoChecks(string name, int attrDepth);
            /*0x7737564*/ System.Xml.XmlTextReaderImpl.NodeData AddAttribute(int endNamePos, int colonPos);
            /*0x773b034*/ System.Xml.XmlTextReaderImpl.NodeData AddAttribute(string localName, string prefix, string nameWPrefix);
            /*0x772d578*/ void PopElementContext();
            /*0x7730990*/ void OnNewLine(int pos);
            /*0x772d954*/ void OnEof();
            /*0x773877c*/ string LookupNamespace(System.Xml.XmlTextReaderImpl.NodeData node);
            /*0x77388cc*/ void AddNamespace(string prefix, string uri, System.Xml.XmlTextReaderImpl.NodeData attr);
            /*0x772d508*/ void ResetAttributes();
            /*0x773b1a0*/ void FullAttributeCleanup();
            /*0x7738840*/ void PushXmlContext();
            /*0x773b168*/ void PopXmlContext();
            /*0x7738eb0*/ System.Xml.XmlNodeType GetWhitespaceType();
            /*0x7738cc8*/ System.Xml.XmlNodeType GetTextNodeType(int orChars);
            /*0x77320ec*/ void PushExternalEntityOrSubset(string publicId, string systemId, System.Uri baseUri, string entityName);
            /*0x773b228*/ bool OpenAndPush(System.Uri uri);
            /*0x7731854*/ bool PushExternalEntity(System.Xml.IDtdEntityInfo entity);
            /*0x7731bd8*/ void PushInternalEntity(System.Xml.IDtdEntityInfo entity);
            /*0x7731f58*/ void PopEntity();
            /*0x773b450*/ void RegisterEntity(System.Xml.IDtdEntityInfo entity);
            /*0x773b660*/ void UnregisterEntity();
            /*0x773273c*/ void PushParsingState();
            /*0x77343a4*/ void PopParsingState();
            /*0x773b6c4*/ int IncrementalRead();
            /*0x772d794*/ void FinishIncrementalRead();
            /*0x772d810*/ bool ParseFragmentAttribute();
            /*0x772e110*/ bool ParseAttributeValueChunk();
            /*0x772d898*/ void ParseXmlDeclarationFragment();
            /*0x7734600*/ void ThrowUnexpectedToken(int pos, string expectedToken);
            /*0x7734438*/ void ThrowUnexpectedToken(string expectedToken1);
            /*0x773489c*/ void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2);
            /*0x7734460*/ void ThrowUnexpectedToken(string expectedToken1, string expectedToken2);
            /*0x7734894*/ string ParseUnexpectedToken(int pos);
            /*0x773c00c*/ string ParseUnexpectedToken();
            /*0x77374e4*/ void ThrowExpectingWhitespace(int pos);
            /*0x772b0a0*/ int GetIndexOfAttributeWithoutPrefix(string name);
            /*0x772b188*/ int GetIndexOfAttributeWithPrefix(string name);
            /*0x7738d8c*/ bool ZeroEndingStream(int pos);
            /*0x7733868*/ void ParseDtdFromParserContext();
            /*0x772f390*/ bool InitReadContentAsBinary();
            /*0x7738e08*/ bool MoveToNextContentNode(bool moveIfOnContentNode);
            /*0x773c0d4*/ void SetupReadContentAsBinaryState(System.Xml.XmlTextReaderImpl.ParsingFunction inReadBinaryFunction);
            /*0x77293fc*/ void SetupFromParserContext(System.Xml.XmlParserContext context, System.Xml.XmlReaderSettings settings);
            /*0x773c108*/ System.Xml.IDtdInfo get_DtdInfo();
            /*0x773c110*/ void SetDtdInfo(System.Xml.IDtdInfo newDtdInfo);
            /*0x773c260*/ void set_ValidationEventHandling(System.Xml.IValidationEventHandling value);
            /*0x773c270*/ void set_OnDefaultAttributeUse(System.Xml.XmlTextReaderImpl.OnDefaultAttributeUseDelegate value);
            /*0x773c280*/ void set_XmlValidatingReaderCompatibilityMode(bool value);
            /*0x773c358*/ System.Xml.XmlNodeType get_FragmentType();
            /*0x773c360*/ void ChangeCurrentNodeType(System.Xml.XmlNodeType newNodeType);
            /*0x773c37c*/ System.Xml.XmlResolver GetResolver();
            /*0x773c3b4*/ void set_InternalSchemaType(object value);
            /*0x773c3d0*/ object get_InternalTypedValue();
            /*0x773c3ec*/ void set_InternalTypedValue(object value);
            /*0x773c408*/ bool get_StandAlone();
            /*0x773c410*/ System.Xml.XmlNamespaceManager get_NamespaceManager();
            /*0x773c418*/ bool get_V1Compat();
            /*0x7736bf4*/ bool AddDefaultAttributeDtd(System.Xml.IDtdDefaultAttributeInfo defAttrInfo, bool definedInDtd, System.Xml.XmlTextReaderImpl.NodeData[] nameSortedNodeData);
            /*0x773c67c*/ bool AddDefaultAttributeNonDtd(System.Xml.Schema.SchemaAttDef attrDef);
            /*0x773c420*/ System.Xml.XmlTextReaderImpl.NodeData AddDefaultAttributeInternal(string localName, string ns, string prefix, string value, int lineNo, int linePos, int valueLineNo, int valueLinePos, bool isXmlAttribute);
            /*0x773c870*/ void set_DisableUndeclaredEntityCheck(bool value);
            /*0x772ef90*/ int ReadContentAsBinary(byte[] buffer, int index, int count);
            /*0x772f500*/ void InitBase64Decoder();
            /*0x772f7a8*/ void InitBinHexDecoder();
            /*0x772a758*/ bool UriEqual(System.Uri uri1, string uri1Str, string uri2Str, System.Xml.XmlResolver resolver);
            /*0x773288c*/ void RegisterConsumedCharacters(long characters, bool inEntityReference);

            enum ParsingFunction
            {
                ElementContent = 0,
                NoData = 1,
                OpenUrl = 2,
                SwitchToInteractive = 3,
                SwitchToInteractiveXmlDecl = 4,
                DocumentContent = 5,
                MoveToElementContent = 6,
                PopElementContext = 7,
                PopEmptyElementContext = 8,
                ResetAttributesRootLevel = 9,
                Error = 10,
                Eof = 11,
                ReaderClosed = 12,
                EntityReference = 13,
                InIncrementalRead = 14,
                FragmentAttribute = 15,
                ReportEndEntity = 16,
                AfterResolveEntityInContent = 17,
                AfterResolveEmptyEntityInContent = 18,
                XmlDeclarationFragment = 19,
                GoToEof = 20,
                PartialTextValue = 21,
                InReadAttributeValue = 22,
                InReadValueChunk = 23,
                InReadContentAsBinary = 24,
                InReadElementContentAsBinary = 25,
            }

            enum ParsingMode
            {
                Full = 0,
                SkipNode = 1,
                SkipContent = 2,
            }

            enum EntityType
            {
                CharacterDec = 0,
                CharacterHex = 1,
                CharacterNamed = 2,
                Expanded = 3,
                Skipped = 4,
                FakeExpanded = 5,
                Unexpanded = 6,
                ExpandedInAttribute = 7,
            }

            enum EntityExpandType
            {
                All = 0,
                OnlyGeneral = 1,
                OnlyCharacter = 2,
            }

            enum IncrementalReadState
            {
                Text = 0,
                StartTag = 1,
                PI = 2,
                CDATA = 3,
                Comment = 4,
                Attributes = 5,
                AttributeValue = 6,
                ReadData = 7,
                EndElement = 8,
                End = 9,
                ReadValueChunk_OnCachedValue = 10,
                ReadValueChunk_OnPartialValue = 11,
                ReadContentAsBinary_OnCachedValue = 12,
                ReadContentAsBinary_OnPartialValue = 13,
                ReadContentAsBinary_End = 14,
            }

            class LaterInitParam
            {
                /*0x10*/ bool useAsync;
                /*0x18*/ System.IO.Stream inputStream;
                /*0x20*/ byte[] inputBytes;
                /*0x28*/ int inputByteCount;
                /*0x30*/ System.Uri inputbaseUri;
                /*0x38*/ string inputUriStr;
                /*0x40*/ System.Xml.XmlResolver inputUriResolver;
                /*0x48*/ System.Xml.XmlParserContext inputContext;
                /*0x50*/ System.IO.TextReader inputTextReader;
                /*0x58*/ System.Xml.XmlTextReaderImpl.InitInputType initType;

                /*0x77445f8*/ LaterInitParam();
            }

            enum InitInputType
            {
                UriString = 0,
                Stream = 1,
                TextReader = 2,
                Invalid = 3,
            }

            struct ParsingState
            {
                /*0x10*/ char[] chars;
                /*0x18*/ int charPos;
                /*0x1c*/ int charsUsed;
                /*0x20*/ System.Text.Encoding encoding;
                /*0x28*/ bool appendMode;
                /*0x30*/ System.IO.Stream stream;
                /*0x38*/ System.Text.Decoder decoder;
                /*0x40*/ byte[] bytes;
                /*0x48*/ int bytePos;
                /*0x4c*/ int bytesUsed;
                /*0x50*/ System.IO.TextReader textReader;
                /*0x58*/ int lineNo;
                /*0x5c*/ int lineStartPos;
                /*0x60*/ string baseUriStr;
                /*0x68*/ System.Uri baseUri;
                /*0x70*/ bool isEof;
                /*0x71*/ bool isStreamEof;
                /*0x78*/ System.Xml.IDtdEntityInfo entity;
                /*0x80*/ int entityId;
                /*0x84*/ bool eolNormalized;
                /*0x85*/ bool entityResolvedManually;

                /*0x7744608*/ void Clear();
                /*0x77446c4*/ void Close(bool closeInput);
                /*0x77446fc*/ int get_LineNo();
                /*0x7744704*/ int get_LinePos();
            }

            class XmlContext
            {
                /*0x10*/ System.Xml.XmlSpace xmlSpace;
                /*0x18*/ string xmlLang;
                /*0x20*/ string defaultNamespace;
                /*0x28*/ System.Xml.XmlTextReaderImpl.XmlContext previousContext;

                /*0x7744714*/ XmlContext();
                /*0x774477c*/ XmlContext(System.Xml.XmlTextReaderImpl.XmlContext previousContext);
            }

            class NoNamespaceManager : System.Xml.XmlNamespaceManager
            {
                /*0x77447dc*/ NoNamespaceManager();
                /*0x77447e4*/ string get_DefaultNamespace();
                /*0x77447fc*/ void PushScope();
                /*0x7744800*/ bool PopScope();
                /*0x7744808*/ void AddNamespace(string prefix, string uri);
                /*0x774480c*/ void RemoveNamespace(string prefix, string uri);
                /*0x7744810*/ System.Collections.IEnumerator GetEnumerator();
                /*0x7744818*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
                /*0x7744820*/ string LookupNamespace(string prefix);
                /*0x7744838*/ string LookupPrefix(string uri);
            }

            class DtdParserProxy : System.Xml.IDtdParserAdapterV1, System.Xml.IDtdParserAdapterWithValidation, System.Xml.IDtdParserAdapter
            {
                /*0x10*/ System.Xml.XmlTextReaderImpl reader;

                /*0x7744840*/ DtdParserProxy(System.Xml.XmlTextReaderImpl reader);
                /*0x7744870*/ System.Xml.XmlNameTable System.Xml.IDtdParserAdapter.get_NameTable();
                /*0x774488c*/ System.Xml.IXmlNamespaceResolver System.Xml.IDtdParserAdapter.get_NamespaceResolver();
                /*0x77448a8*/ System.Uri System.Xml.IDtdParserAdapter.get_BaseUri();
                /*0x77448c4*/ bool System.Xml.IDtdParserAdapter.get_IsEof();
                /*0x77448e0*/ char[] System.Xml.IDtdParserAdapter.get_ParsingBuffer();
                /*0x77448fc*/ int System.Xml.IDtdParserAdapter.get_ParsingBufferLength();
                /*0x7744918*/ int System.Xml.IDtdParserAdapter.get_CurrentPosition();
                /*0x7744934*/ void System.Xml.IDtdParserAdapter.set_CurrentPosition(int value);
                /*0x7744950*/ int System.Xml.IDtdParserAdapter.get_EntityStackLength();
                /*0x774496c*/ bool System.Xml.IDtdParserAdapter.get_IsEntityEolNormalized();
                /*0x7744988*/ void System.Xml.IDtdParserAdapter.OnNewLine(int pos);
                /*0x77449a4*/ int System.Xml.IDtdParserAdapter.get_LineNo();
                /*0x77449c0*/ int System.Xml.IDtdParserAdapter.get_LineStartPosition();
                /*0x77449dc*/ int System.Xml.IDtdParserAdapter.ReadData();
                /*0x77449f8*/ int System.Xml.IDtdParserAdapter.ParseNumericCharRef(System.Text.StringBuilder internalSubsetBuilder);
                /*0x7744a14*/ int System.Xml.IDtdParserAdapter.ParseNamedCharRef(bool expand, System.Text.StringBuilder internalSubsetBuilder);
                /*0x7744a34*/ void System.Xml.IDtdParserAdapter.ParsePI(System.Text.StringBuilder sb);
                /*0x7744a50*/ void System.Xml.IDtdParserAdapter.ParseComment(System.Text.StringBuilder sb);
                /*0x7744a6c*/ bool System.Xml.IDtdParserAdapter.PushEntity(System.Xml.IDtdEntityInfo entity, ref int entityId);
                /*0x7744a88*/ bool System.Xml.IDtdParserAdapter.PopEntity(ref System.Xml.IDtdEntityInfo oldEntity, ref int newEntityId);
                /*0x7744aa4*/ bool System.Xml.IDtdParserAdapter.PushExternalSubset(string systemId, string publicId);
                /*0x7744ac0*/ void System.Xml.IDtdParserAdapter.PushInternalDtd(string baseUri, string internalDtd);
                /*0x7744adc*/ void System.Xml.IDtdParserAdapter.Throw(System.Exception e);
                /*0x7744af8*/ void System.Xml.IDtdParserAdapter.OnSystemId(string systemId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo systemLiteralLineInfo);
                /*0x7744b14*/ void System.Xml.IDtdParserAdapter.OnPublicId(string publicId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo publicLiteralLineInfo);
                /*0x7744b30*/ bool System.Xml.IDtdParserAdapterWithValidation.get_DtdValidation();
                /*0x7744b4c*/ System.Xml.IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.get_ValidationEventHandling();
                /*0x7744b68*/ bool System.Xml.IDtdParserAdapterV1.get_Normalization();
                /*0x7744b84*/ bool System.Xml.IDtdParserAdapterV1.get_Namespaces();
                /*0x7744ba0*/ bool System.Xml.IDtdParserAdapterV1.get_V1CompatibilityMode();
            }

            class NodeData : System.IComparable
            {
                static /*0x0*/ System.Xml.XmlTextReaderImpl.NodeData s_None;
                /*0x10*/ System.Xml.XmlNodeType type;
                /*0x18*/ string localName;
                /*0x20*/ string prefix;
                /*0x28*/ string ns;
                /*0x30*/ string nameWPrefix;
                /*0x38*/ string value;
                /*0x40*/ char[] chars;
                /*0x48*/ int valueStartPos;
                /*0x4c*/ int valueLength;
                /*0x50*/ System.Xml.LineInfo lineInfo;
                /*0x58*/ System.Xml.LineInfo lineInfo2;
                /*0x60*/ char quoteChar;
                /*0x64*/ int depth;
                /*0x68*/ bool isEmptyOrDefault;
                /*0x6c*/ int entityId;
                /*0x70*/ bool xmlContextPushed;
                /*0x78*/ System.Xml.XmlTextReaderImpl.NodeData nextAttrValueChunk;
                /*0x80*/ object schemaType;
                /*0x88*/ object typedValue;

                static /*0x7744bbc*/ System.Xml.XmlTextReaderImpl.NodeData get_None();
                /*0x7744c64*/ NodeData();
                /*0x7744d08*/ int get_LineNo();
                /*0x7744d10*/ int get_LinePos();
                /*0x7744d18*/ bool get_IsEmptyElement();
                /*0x7744d3c*/ void set_IsEmptyElement(bool value);
                /*0x7744d48*/ bool get_IsDefaultAttribute();
                /*0x7744d6c*/ void set_IsDefaultAttribute(bool value);
                /*0x7744d78*/ bool get_ValueBuffered();
                /*0x7744d88*/ string get_StringValue();
                /*0x7744dd0*/ void TrimSpacesInValue();
                /*0x7744c8c*/ void Clear(System.Xml.XmlNodeType type);
                /*0x7744e1c*/ void ClearName();
                /*0x7744e94*/ void SetLineInfo(int lineNo, int linePos);
                /*0x7744ea0*/ void SetLineInfo2(int lineNo, int linePos);
                /*0x7744eac*/ void SetValueNode(System.Xml.XmlNodeType type, string value);
                /*0x7744ee8*/ void SetValueNode(System.Xml.XmlNodeType type, char[] chars, int startPos, int len);
                /*0x7744f40*/ void SetNamedNode(System.Xml.XmlNodeType type, string localName);
                /*0x7744f5c*/ void SetNamedNode(System.Xml.XmlNodeType type, string localName, string prefix, string nameWPrefix);
                /*0x7744fec*/ void SetValue(string value);
                /*0x7744ffc*/ void SetValue(char[] chars, int startPos, int len);
                /*0x7745048*/ void OnBufferInvalidated();
                /*0x7745098*/ void CopyTo(int valueOffset, System.Text.StringBuilder sb);
                /*0x7745118*/ int CopyTo(int valueOffset, char[] buffer, int offset, int length);
                /*0x7745178*/ int CopyToBinary(System.Xml.IncrementalReadDecoder decoder, int valueOffset);
                /*0x77451d8*/ void AdjustLineInfo(int valueOffset, bool isNormalized, ref System.Xml.LineInfo lineInfo);
                /*0x7745224*/ string GetNameWPrefix(System.Xml.XmlNameTable nt);
                /*0x7745238*/ string CreateNameWPrefix(System.Xml.XmlNameTable nt);
                /*0x77452d0*/ int System.IComparable.CompareTo(object obj);
            }

            class DtdDefaultAttributeInfoToNodeDataComparer : System.Collections.Generic.IComparer<object>
            {
                static /*0x0*/ System.Collections.Generic.IComparer<object> s_instance;

                static /*0x7745748*/ DtdDefaultAttributeInfoToNodeDataComparer();
                static /*0x77453a8*/ System.Collections.Generic.IComparer<object> get_Instance();
                /*0x7745740*/ DtdDefaultAttributeInfoToNodeDataComparer();
                /*0x7745400*/ int Compare(object x, object y);
            }

            class OnDefaultAttributeUseDelegate : System.MulticastDelegate
            {
                /*0x77457b0*/ OnDefaultAttributeUseDelegate(object object, nint method);
                /*0x77458bc*/ void Invoke(System.Xml.IDtdDefaultAttributeInfo defaultAttribute, System.Xml.XmlTextReaderImpl coreReader);
            }
        }

        enum Formatting
        {
            None = 0,
            Indented = 1,
        }

        class XmlTextWriter : System.Xml.XmlWriter
        {
            static /*0x0*/ string[] stateName;
            static /*0x8*/ string[] tokenName;
            static /*0x10*/ System.Xml.XmlTextWriter.State[] stateTableDefault;
            static /*0x18*/ System.Xml.XmlTextWriter.State[] stateTableDocument;
            /*0x18*/ System.IO.TextWriter textWriter;
            /*0x20*/ System.Xml.XmlTextEncoder xmlEncoder;
            /*0x28*/ System.Text.Encoding encoding;
            /*0x30*/ System.Xml.Formatting formatting;
            /*0x34*/ bool indented;
            /*0x38*/ int indentation;
            /*0x3c*/ char indentChar;
            /*0x40*/ System.Xml.XmlTextWriter.TagInfo[] stack;
            /*0x48*/ int top;
            /*0x50*/ System.Xml.XmlTextWriter.State[] stateTable;
            /*0x58*/ System.Xml.XmlTextWriter.State currentState;
            /*0x5c*/ System.Xml.XmlTextWriter.Token lastToken;
            /*0x60*/ System.Xml.XmlTextWriterBase64Encoder base64Encoder;
            /*0x68*/ char quoteChar;
            /*0x6a*/ char curQuoteChar;
            /*0x6c*/ bool namespaces;
            /*0x70*/ System.Xml.XmlTextWriter.SpecialAttr specialAttr;
            /*0x78*/ string prefixForXmlNs;
            /*0x80*/ bool flush;
            /*0x88*/ System.Xml.XmlTextWriter.Namespace[] nsStack;
            /*0x90*/ int nsTop;
            /*0x98*/ System.Collections.Generic.Dictionary<string, int> nsHashtable;
            /*0xa0*/ bool useNsHashtable;
            /*0xa8*/ System.Xml.XmlCharType xmlCharType;

            static /*0x774a4f4*/ XmlTextWriter();
            /*0x77458d0*/ XmlTextWriter();
            /*0x7745a90*/ XmlTextWriter(System.IO.Stream w, System.Text.Encoding encoding);
            /*0x7745b8c*/ XmlTextWriter(string filename, System.Text.Encoding encoding);
            /*0x77408cc*/ XmlTextWriter(System.IO.TextWriter w);
            /*0x7745c0c*/ System.IO.Stream get_BaseStream();
            /*0x7740a94*/ void set_Namespaces(bool value);
            /*0x7745ca8*/ void set_Formatting(System.Xml.Formatting value);
            /*0x7740328*/ void set_QuoteChar(char value);
            /*0x7745cbc*/ void WriteStartDocument();
            /*0x7746054*/ void WriteStartDocument(bool standalone);
            /*0x7746068*/ void WriteEndDocument();
            /*0x7746280*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x7746d60*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x7747814*/ void WriteEndElement();
            /*0x7747af8*/ void WriteFullEndElement();
            /*0x7747b00*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x77483dc*/ void WriteEndAttribute();
            /*0x774847c*/ void WriteCData(string text);
            /*0x774863c*/ void WriteComment(string text);
            /*0x7748838*/ void WriteProcessingInstruction(string name, string text);
            /*0x7748b60*/ void WriteEntityRef(string name);
            /*0x7748c28*/ void WriteCharEntity(char ch);
            /*0x7748ce4*/ void WriteWhitespace(string ws);
            /*0x7748e2c*/ void WriteString(string text);
            /*0x7748ef4*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x7748fb8*/ void WriteChars(char[] buffer, int index, int count);
            /*0x774908c*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x7749160*/ void WriteRaw(string data);
            /*0x774921c*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x7749374*/ void WriteBinHex(byte[] buffer, int index, int count);
            /*0x7749444*/ System.Xml.WriteState get_WriteState();
            /*0x7749468*/ void Close();
            /*0x77495a0*/ void Flush();
            /*0x77495c0*/ void WriteQualifiedName(string localName, string ns);
            /*0x77498e0*/ string LookupPrefix(string ns);
            /*0x77499bc*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x7749a14*/ string get_XmlLang();
            /*0x7745cc4*/ void StartDocument(int standalone);
            /*0x7746864*/ void AutoComplete(System.Xml.XmlTextWriter.Token token);
            /*0x774622c*/ void AutoCompleteAll();
            /*0x774781c*/ void InternalWriteEndElement(bool longFormat);
            /*0x7749b84*/ void WriteEndStartTag(bool empty);
            /*0x7749b3c*/ void WriteEndAttributeQuote();
            /*0x7749a6c*/ void Indent(bool beforeEndElement);
            /*0x774745c*/ void PushNamespace(string prefix, string ns, bool declared);
            /*0x774a1f4*/ void AddNamespace(string prefix, string ns, bool declared);
            /*0x774a40c*/ void AddToNamespaceHashtable(int namespaceIndex);
            /*0x7749f08*/ void PopNamespaces(int indexFrom, int indexTo);
            /*0x77482c8*/ string GeneratePrefix();
            /*0x7748a68*/ void InternalWriteProcessingInstruction(string name, string text);
            /*0x77472b0*/ int LookupNamespace(string prefix);
            /*0x774819c*/ int LookupNamespaceInCurrentScope(string prefix);
            /*0x774738c*/ string FindPrefix(string ns);
            /*0x77498a0*/ void InternalWriteName(string name, bool isNCName);
            /*0x77466ac*/ void ValidateName(string name, bool isNCName);
            /*0x7749fdc*/ void HandleSpecialAttribute();
            /*0x77476b4*/ void VerifyPrefixXml(string prefix, string ns);
            /*0x77471d0*/ void PushStack();
            /*0x7749ee4*/ void FlushEncoders();

            enum NamespaceState
            {
                Uninitialized = 0,
                NotDeclaredButInScope = 1,
                DeclaredButNotWrittenOut = 2,
                DeclaredAndWrittenOut = 3,
            }

            struct TagInfo
            {
                /*0x10*/ string name;
                /*0x18*/ string prefix;
                /*0x20*/ string defaultNs;
                /*0x28*/ System.Xml.XmlTextWriter.NamespaceState defaultNsState;
                /*0x2c*/ System.Xml.XmlSpace xmlSpace;
                /*0x30*/ string xmlLang;
                /*0x38*/ int prevNsTop;
                /*0x3c*/ int prefixCount;
                /*0x40*/ bool mixed;

                /*0x7745a2c*/ void Init(int nsTop);
            }

            struct Namespace
            {
                /*0x10*/ string prefix;
                /*0x18*/ string ns;
                /*0x20*/ bool declared;
                /*0x24*/ int prevNsIndex;

                /*0x774a3c8*/ void Set(string prefix, string ns, bool declared);
            }

            enum SpecialAttr
            {
                None = 0,
                XmlSpace = 1,
                XmlLang = 2,
                XmlNs = 3,
            }

            enum State
            {
                Start = 0,
                Prolog = 1,
                PostDTD = 2,
                Element = 3,
                Attribute = 4,
                Content = 5,
                AttrOnly = 6,
                Epilog = 7,
                Error = 8,
                Closed = 9,
            }

            enum Token
            {
                PI = 0,
                Doctype = 1,
                Comment = 2,
                CData = 3,
                StartElement = 4,
                EndElement = 5,
                LongEndElement = 6,
                StartAttribute = 7,
                EndAttribute = 8,
                Content = 9,
                Base64 = 10,
                RawData = 11,
                Whitespace = 12,
                Empty = 13,
            }
        }

        class XmlUtf8RawTextWriter : System.Xml.XmlRawWriter
        {
            /*0x28*/ bool useAsync;
            /*0x30*/ byte[] bufBytes;
            /*0x38*/ System.IO.Stream stream;
            /*0x40*/ System.Text.Encoding encoding;
            /*0x48*/ System.Xml.XmlCharType xmlCharType;
            /*0x50*/ int bufPos;
            /*0x54*/ int textPos;
            /*0x58*/ int contentPos;
            /*0x5c*/ int cdataPos;
            /*0x60*/ int attrEndPos;
            /*0x64*/ int bufLen;
            /*0x68*/ bool writeToNull;
            /*0x69*/ bool hadDoubleBracket;
            /*0x6a*/ bool inAttributeValue;
            /*0x6c*/ System.Xml.NewLineHandling newLineHandling;
            /*0x70*/ bool closeOutput;
            /*0x71*/ bool omitXmlDeclaration;
            /*0x78*/ string newLineChars;
            /*0x80*/ bool checkCharacters;
            /*0x84*/ System.Xml.XmlStandalone standalone;
            /*0x88*/ System.Xml.XmlOutputMethod outputMethod;
            /*0x8c*/ bool autoXmlDeclaration;
            /*0x8d*/ bool mergeCDataSections;

            static /*0x774db90*/ bool IsSurrogateByte(byte b);
            static /*0x774d6f8*/ byte* EncodeSurrogate(char* pSrc, char* pSrcEnd, byte* pDst);
            static /*0x774d93c*/ byte* EncodeMultibyteUTF8(int ch, byte* pDst);
            static /*0x774dd28*/ void CharToUTF8(ref char* pSrc, char* pSrcEnd, ref byte* pDst);
            static /*0x774d658*/ byte* LtEntity(byte* pDst);
            static /*0x774d668*/ byte* GtEntity(byte* pDst);
            static /*0x774d638*/ byte* AmpEntity(byte* pDst);
            static /*0x774d678*/ byte* QuoteEntity(byte* pDst);
            static /*0x774d698*/ byte* TabEntity(byte* pDst);
            static /*0x774d6d8*/ byte* LineFeedEntity(byte* pDst);
            static /*0x774d6b8*/ byte* CarriageReturnEntity(byte* pDst);
            static /*0x774dba0*/ byte* CharEntity(byte* pDst, char ch);
            static /*0x774db68*/ byte* RawStartCData(byte* pDst);
            static /*0x774db4c*/ byte* RawEndCData(byte* pDst);
            /*0x774ab00*/ XmlUtf8RawTextWriter(System.Xml.XmlWriterSettings settings);
            /*0x774af4c*/ XmlUtf8RawTextWriter(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x774b0b8*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x774b248*/ void WriteXmlDeclaration(string xmldecl);
            /*0x774b2c0*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x774b4b0*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x774b554*/ void StartElementContent();
            /*0x774b59c*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x774b6f4*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x774b7e8*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x774b8f4*/ void WriteEndAttribute();
            /*0x774b940*/ void WriteNamespaceDeclaration(string prefix, string namespaceName);
            /*0x774b994*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0x774b99c*/ void WriteStartNamespaceDeclaration(string prefix);
            /*0x774ba90*/ void WriteEndNamespaceDeclaration();
            /*0x774badc*/ void WriteCData(string text);
            /*0x774c06c*/ void WriteComment(string text);
            /*0x774c4f0*/ void WriteProcessingInstruction(string name, string text);
            /*0x774c618*/ void WriteEntityRef(string name);
            /*0x774c6b8*/ void WriteCharEntity(char ch);
            /*0x774c884*/ void WriteWhitespace(string ws);
            /*0x774ce74*/ void WriteString(string text);
            /*0x774cec4*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x774d014*/ void WriteChars(char[] buffer, int index, int count);
            /*0x774d054*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x774d2d4*/ void WriteRaw(string data);
            /*0x774d31c*/ void Close();
            /*0x774d484*/ void Flush();
            /*0x774d4c0*/ void FlushBuffer();
            /*0x774d480*/ void FlushEncoder();
            /*0x774c8d4*/ void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd);
            /*0x774cbbc*/ void WriteElementTextBlock(char* pSrc, char* pSrcEnd);
            /*0x774b20c*/ void RawText(string s);
            /*0x774d9d0*/ void RawText(char* pSrcBegin, char* pSrcEnd);
            /*0x774d094*/ void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd);
            /*0x774c1c4*/ void WriteCommentOrPi(string text, int stopChar);
            /*0x774bd38*/ void WriteCDataSection(string text);
            /*0x774d888*/ byte* InvalidXmlChar(int ch, byte* pDst, bool entitize);
            /*0x774dc4c*/ void EncodeChar(ref char* pSrc, char* pSrcEnd, ref byte* pDst);
            /*0x774d97c*/ byte* WriteNewLine(byte* pDst);
            /*0x774ac00*/ void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace);
        }

        class XmlUtf8RawTextWriterIndent : System.Xml.XmlUtf8RawTextWriter
        {
            /*0x90*/ int indentLevel;
            /*0x94*/ bool newLineOnAttributes;
            /*0x98*/ string indentChars;
            /*0xa0*/ bool mixedContent;
            /*0xa8*/ System.Xml.BitStack mixedContentStack;
            /*0xb0*/ System.Xml.ConformanceLevel conformanceLevel;

            /*0x774ddf8*/ XmlUtf8RawTextWriterIndent(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x774df44*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x774dfec*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x774e058*/ void StartElementContent();
            /*0x774e0a8*/ void OnRootElement(System.Xml.ConformanceLevel currentConformanceLevel);
            /*0x774e0b0*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x774e130*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x774e1b0*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x774e1ec*/ void WriteCData(string text);
            /*0x774e1f8*/ void WriteComment(string text);
            /*0x774e238*/ void WriteProcessingInstruction(string target, string text);
            /*0x774e280*/ void WriteEntityRef(string name);
            /*0x774e28c*/ void WriteCharEntity(char ch);
            /*0x774e298*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x774e2a4*/ void WriteWhitespace(string ws);
            /*0x774e2b0*/ void WriteString(string text);
            /*0x774e2bc*/ void WriteChars(char[] buffer, int index, int count);
            /*0x774e2c8*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x774e2d4*/ void WriteRaw(string data);
            /*0x774e2e0*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x774de20*/ void Init(System.Xml.XmlWriterSettings settings);
            /*0x774dfa4*/ void WriteIndent();
        }

        class XmlValidatingReader : System.Xml.XmlReader
        {
            /*0x10*/ System.Xml.XmlValidatingReaderImpl impl;

            /*0x774e2ec*/ System.Xml.XmlNodeType get_NodeType();
            /*0x774e30c*/ string get_LocalName();
            /*0x774e32c*/ string get_NamespaceURI();
            /*0x774e34c*/ string get_Prefix();
            /*0x774e36c*/ string get_Value();
            /*0x774e38c*/ int get_Depth();
            /*0x774e3ac*/ string get_BaseURI();
            /*0x774e3d0*/ bool get_IsEmptyElement();
            /*0x774e3f4*/ int get_AttributeCount();
            /*0x774e418*/ string GetAttribute(string name);
            /*0x774e43c*/ string GetAttribute(string localName, string namespaceURI);
            /*0x774e460*/ string GetAttribute(int i);
            /*0x774e484*/ bool MoveToAttribute(string name);
            /*0x774e4a8*/ bool MoveToAttribute(string localName, string namespaceURI);
            /*0x774e4cc*/ bool MoveToFirstAttribute();
            /*0x774e4f0*/ bool MoveToNextAttribute();
            /*0x774e514*/ bool MoveToElement();
            /*0x774e538*/ bool ReadAttributeValue();
            /*0x774e55c*/ bool Read();
            /*0x774e580*/ bool get_EOF();
            /*0x774e5a4*/ System.Xml.ReadState get_ReadState();
            /*0x774e5c8*/ System.Xml.XmlNameTable get_NameTable();
            /*0x774e5ec*/ string LookupNamespace(string prefix);
            /*0x774e624*/ void ResolveEntity();
            /*0x7740b08*/ bool get_Namespaces();
        }

        class XmlValidatingReaderImpl : System.Xml.XmlReader, System.Xml.IXmlLineInfo, System.Xml.IXmlNamespaceResolver
        {
            static /*0x0*/ System.Xml.XmlResolver s_tempResolver;
            /*0x10*/ System.Xml.XmlReader coreReader;
            /*0x18*/ System.Xml.XmlTextReaderImpl coreReaderImpl;
            /*0x20*/ System.Xml.IXmlNamespaceResolver coreReaderNSResolver;
            /*0x28*/ System.Xml.ValidationType validationType;
            /*0x30*/ System.Xml.Schema.BaseValidator validator;
            /*0x38*/ System.Xml.Schema.XmlSchemaCollection schemaCollection;
            /*0x40*/ bool processIdentityConstraints;
            /*0x44*/ System.Xml.XmlValidatingReaderImpl.ParsingFunction parsingFunction;
            /*0x48*/ System.Xml.XmlValidatingReaderImpl.ValidationEventHandling eventHandling;
            /*0x50*/ System.Xml.XmlParserContext parserContext;
            /*0x58*/ System.Xml.ReadContentAsBinaryHelper readBinaryHelper;
            /*0x60*/ System.Xml.XmlReader outerReader;

            /*0x774e648*/ XmlValidatingReaderImpl(System.Xml.XmlReader reader, System.Xml.Schema.ValidationEventHandler settingsEventHandler, bool processIdentityConstraints);
            /*0x774ed74*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x774ee44*/ System.Xml.XmlNodeType get_NodeType();
            /*0x774ee64*/ string get_Name();
            /*0x774ee84*/ string get_LocalName();
            /*0x774eea4*/ string get_NamespaceURI();
            /*0x774eec4*/ string get_Prefix();
            /*0x774eee4*/ string get_Value();
            /*0x774ef04*/ int get_Depth();
            /*0x774ef24*/ string get_BaseURI();
            /*0x774ef48*/ bool get_IsEmptyElement();
            /*0x774ef6c*/ bool get_IsDefault();
            /*0x774ef90*/ char get_QuoteChar();
            /*0x774efb4*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x774efd8*/ string get_XmlLang();
            /*0x774effc*/ System.Xml.ReadState get_ReadState();
            /*0x774f038*/ bool get_EOF();
            /*0x774f05c*/ System.Xml.XmlNameTable get_NameTable();
            /*0x774f080*/ int get_AttributeCount();
            /*0x774f0a4*/ string GetAttribute(string name);
            /*0x774f0c8*/ string GetAttribute(string localName, string namespaceURI);
            /*0x774f0ec*/ string GetAttribute(int i);
            /*0x774f110*/ bool MoveToAttribute(string name);
            /*0x774f148*/ bool MoveToAttribute(string localName, string namespaceURI);
            /*0x774f180*/ void MoveToAttribute(int i);
            /*0x774f1b0*/ bool MoveToFirstAttribute();
            /*0x774f1e8*/ bool MoveToNextAttribute();
            /*0x774f220*/ bool MoveToElement();
            /*0x774f258*/ bool Read();
            /*0x774f618*/ void Close();
            /*0x774f64c*/ string LookupNamespace(string prefix);
            /*0x774f670*/ bool ReadAttributeValue();
            /*0x774f6c8*/ int ReadContentAsBase64(byte[] buffer, int index, int count);
            /*0x774f774*/ int ReadContentAsBinHex(byte[] buffer, int index, int count);
            /*0x774f820*/ bool get_CanResolveEntity();
            /*0x774f828*/ void ResolveEntity();
            /*0x774f85c*/ void MoveOffEntityReference();
            /*0x774f90c*/ string ReadString();
            /*0x774f928*/ bool HasLineInfo();
            /*0x774f930*/ int get_LineNumber();
            /*0x774fa18*/ int get_LinePosition();
            /*0x774fb00*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x774fbac*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0x774fbbc*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            /*0x774fb04*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x774fbc0*/ string LookupPrefix(string namespaceName);
            /*0x774fc6c*/ System.Xml.ValidationType get_ValidationType();
            /*0x774fc74*/ System.Xml.Schema.XmlSchemaCollection get_Schemas();
            /*0x774fc7c*/ bool get_Namespaces();
            /*0x774f41c*/ void ParseDtdFromParserContext();
            /*0x774fc98*/ void ValidateDtd();
            /*0x774f590*/ void ResolveEntityInternally();
            /*0x774ec0c*/ void SetupValidation(System.Xml.ValidationType valType);
            /*0x774ea68*/ System.Xml.XmlResolver GetResolver();
            /*0x774f330*/ void ProcessCoreReaderEvent();
            /*0x774fd14*/ System.Xml.Schema.BaseValidator get_Validator();
            /*0x774fd1c*/ void set_Validator(System.Xml.Schema.BaseValidator value);
            /*0x774fd24*/ System.Xml.XmlNamespaceManager get_NamespaceManager();
            /*0x774fd48*/ bool get_StandAlone();
            /*0x774fd64*/ void set_SchemaTypeObject(object value);
            /*0x774fd80*/ object get_TypedValueObject();
            /*0x774fd9c*/ void set_TypedValueObject(object value);
            /*0x774fdb8*/ bool AddDefaultAttribute(System.Xml.Schema.SchemaAttDef attdef);
            /*0x774fdd4*/ System.Xml.IDtdInfo get_DtdInfo();
            /*0x774fdf8*/ void ValidateDefaultAttributeOnUse(System.Xml.IDtdDefaultAttributeInfo defaultAttribute, System.Xml.XmlTextReaderImpl coreReader);

            enum ParsingFunction
            {
                Read = 0,
                Init = 1,
                ParseDtdFromContext = 2,
                ResolveEntityInternally = 3,
                InReadBinaryContent = 4,
                ReaderClosed = 5,
                Error = 6,
                None = 7,
            }

            class ValidationEventHandling : System.Xml.IValidationEventHandling
            {
                /*0x10*/ System.Xml.XmlValidatingReaderImpl reader;
                /*0x18*/ System.Xml.Schema.ValidationEventHandler eventHandler;

                /*0x774eb4c*/ ValidationEventHandling(System.Xml.XmlValidatingReaderImpl reader);
                /*0x774ff38*/ object System.Xml.IValidationEventHandling.get_EventHandler();
                /*0x774ff40*/ void System.Xml.IValidationEventHandling.SendEvent(System.Exception exception, System.Xml.Schema.XmlSeverityType severity);
                /*0x774eb7c*/ void AddHandler(System.Xml.Schema.ValidationEventHandler handler);
            }
        }

        class XmlWellFormedWriter : System.Xml.XmlWriter
        {
            static /*0x0*/ string[] stateName;
            static /*0x8*/ string[] tokenName;
            static /*0x10*/ System.Xml.WriteState[] state2WriteState;
            static /*0x18*/ System.Xml.XmlWellFormedWriter.State[] StateTableDocument;
            static /*0x20*/ System.Xml.XmlWellFormedWriter.State[] StateTableAuto;
            /*0x18*/ System.Xml.XmlWriter writer;
            /*0x20*/ System.Xml.XmlRawWriter rawWriter;
            /*0x28*/ System.Xml.IXmlNamespaceResolver predefinedNamespaces;
            /*0x30*/ System.Xml.XmlWellFormedWriter.Namespace[] nsStack;
            /*0x38*/ int nsTop;
            /*0x40*/ System.Collections.Generic.Dictionary<string, int> nsHashtable;
            /*0x48*/ bool useNsHashtable;
            /*0x50*/ System.Xml.XmlWellFormedWriter.ElementScope[] elemScopeStack;
            /*0x58*/ int elemTop;
            /*0x60*/ System.Xml.XmlWellFormedWriter.AttrName[] attrStack;
            /*0x68*/ int attrCount;
            /*0x70*/ System.Collections.Generic.Dictionary<string, int> attrHashTable;
            /*0x78*/ System.Xml.XmlWellFormedWriter.SpecialAttribute specAttr;
            /*0x80*/ System.Xml.XmlWellFormedWriter.AttributeValueCache attrValueCache;
            /*0x88*/ string curDeclPrefix;
            /*0x90*/ System.Xml.XmlWellFormedWriter.State[] stateTable;
            /*0x98*/ System.Xml.XmlWellFormedWriter.State currentState;
            /*0x9c*/ bool checkCharacters;
            /*0x9d*/ bool omitDuplNamespaces;
            /*0x9e*/ bool writeEndDocumentOnClose;
            /*0xa0*/ System.Xml.ConformanceLevel conformanceLevel;
            /*0xa4*/ bool dtdWritten;
            /*0xa5*/ bool xmlDeclFollows;
            /*0xa8*/ System.Xml.XmlCharType xmlCharType;
            /*0xb0*/ System.Xml.SecureStringHasher hasher;

            static /*0x775784c*/ XmlWellFormedWriter();
            static /*0x7756eb0*/ System.Xml.XmlException DupAttrException(string prefix, string localName);
            static /*0x77570a8*/ string GetStateName(System.Xml.XmlWellFormedWriter.State state);
            static /*0x775751c*/ System.Exception InvalidCharsException(string name, int badCharIndex);
            /*0x775005c*/ XmlWellFormedWriter(System.Xml.XmlWriter writer, System.Xml.XmlWriterSettings settings);
            /*0x7750658*/ System.Xml.WriteState get_WriteState();
            /*0x77506ec*/ void WriteStartDocument();
            /*0x77508a8*/ void WriteStartDocument(bool standalone);
            /*0x77508c4*/ void WriteEndDocument();
            /*0x7750d18*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x77511d4*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x7751bc0*/ void WriteEndElement();
            /*0x7751ea4*/ void WriteFullEndElement();
            /*0x77520b4*/ void WriteStartAttribute(string prefix, string localName, string namespaceName);
            /*0x7752cc8*/ void WriteEndAttribute();
            /*0x77541cc*/ void WriteCData(string text);
            /*0x77542b0*/ void WriteComment(string text);
            /*0x7754394*/ void WriteProcessingInstruction(string name, string text);
            /*0x775462c*/ void WriteEntityRef(string name);
            /*0x7754938*/ void WriteCharEntity(char ch);
            /*0x7754b20*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x7754d64*/ void WriteWhitespace(string ws);
            /*0x7754f48*/ void WriteString(string text);
            /*0x77550ac*/ void WriteChars(char[] buffer, int index, int count);
            /*0x77553c0*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x77556d4*/ void WriteRaw(string data);
            /*0x7755814*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x7755a44*/ void Close();
            /*0x7755c28*/ void Flush();
            /*0x7755cdc*/ string LookupPrefix(string ns);
            /*0x7755f58*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x7755fc8*/ string get_XmlLang();
            /*0x7756044*/ void WriteQualifiedName(string localName, string ns);
            /*0x775635c*/ void WriteValue(bool value);
            /*0x7756424*/ void WriteValue(System.DateTime value);
            /*0x77564ec*/ void WriteValue(double value);
            /*0x77565bc*/ void WriteValue(float value);
            /*0x775668c*/ void WriteValue(decimal value);
            /*0x775675c*/ void WriteValue(int value);
            /*0x7756824*/ void WriteValue(long value);
            /*0x77568ec*/ void WriteValue(string value);
            /*0x7756a3c*/ void WriteBinHex(byte[] buffer, int index, int count);
            /*0x7756b94*/ System.Xml.XmlRawWriter get_RawWriter();
            /*0x775478c*/ bool get_SaveAttrValue();
            /*0x7755c00*/ bool get_InBase64();
            /*0x7752788*/ void SetSpecialAttribute(System.Xml.XmlWellFormedWriter.SpecialAttribute special);
            /*0x77506f4*/ void WriteStartDocumentImpl(System.Xml.XmlStandalone standalone);
            /*0x7756c10*/ void StartFragment();
            /*0x77517c4*/ void PushNamespaceImplicit(string prefix, string ns);
            /*0x7753554*/ bool PushNamespaceExplicit(string prefix, string ns);
            /*0x7756cf8*/ void AddNamespace(string prefix, string ns, System.Xml.XmlWellFormedWriter.NamespaceKind kind);
            /*0x7756fc0*/ void AddToNamespaceHashtable(int namespaceIndex);
            /*0x7756c1c*/ int LookupNamespaceIndex(string prefix);
            /*0x7751dd0*/ void PopNamespaces(int indexFrom, int indexTo);
            /*0x7750a14*/ void AdvanceState(System.Xml.XmlWellFormedWriter.Token token);
            /*0x7757324*/ void StartElementContent();
            /*0x7751684*/ string LookupNamespace(string prefix);
            /*0x775295c*/ string LookupLocalNamespace(string prefix);
            /*0x7752824*/ string GeneratePrefix();
            /*0x7751584*/ void CheckNCName(string ncname);
            /*0x7757148*/ void ThrowInvalidStateTransition(System.Xml.XmlWellFormedWriter.Token token, System.Xml.XmlWellFormedWriter.State currentState);
            /*0x7756b68*/ bool get_IsClosedOrErrorState();
            /*0x7752a2c*/ void AddAttribute(string prefix, string localName, string namespaceName);
            /*0x7757718*/ void AddToAttrHashTable(int attributeIndex);

            enum State
            {
                Start = 0,
                TopLevel = 1,
                Document = 2,
                Element = 3,
                Content = 4,
                B64Content = 5,
                B64Attribute = 6,
                AfterRootEle = 7,
                Attribute = 8,
                SpecialAttr = 9,
                EndDocument = 10,
                RootLevelAttr = 11,
                RootLevelSpecAttr = 12,
                RootLevelB64Attr = 13,
                AfterRootLevelAttr = 14,
                Closed = 15,
                Error = 16,
                StartContent = 101,
                StartContentEle = 102,
                StartContentB64 = 103,
                StartDoc = 104,
                StartDocEle = 106,
                EndAttrSEle = 107,
                EndAttrEEle = 108,
                EndAttrSCont = 109,
                EndAttrSAttr = 111,
                PostB64Cont = 112,
                PostB64Attr = 113,
                PostB64RootAttr = 114,
                StartFragEle = 115,
                StartFragCont = 116,
                StartFragB64 = 117,
                StartRootLevelAttr = 118,
            }

            enum Token
            {
                StartDocument = 0,
                EndDocument = 1,
                PI = 2,
                Comment = 3,
                Dtd = 4,
                StartElement = 5,
                EndElement = 6,
                StartAttribute = 7,
                EndAttribute = 8,
                Text = 9,
                CData = 10,
                AtomicValue = 11,
                Base64 = 12,
                RawData = 13,
                Whitespace = 14,
            }

            class NamespaceResolverProxy : System.Xml.IXmlNamespaceResolver
            {
                /*0x10*/ System.Xml.XmlWellFormedWriter wfWriter;

                /*0x7750588*/ NamespaceResolverProxy(System.Xml.XmlWellFormedWriter wfWriter);
                /*0x7758044*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
                /*0x775807c*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
                /*0x7758094*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            }

            struct ElementScope
            {
                /*0x10*/ int prevNSTop;
                /*0x18*/ string prefix;
                /*0x20*/ string localName;
                /*0x28*/ string namespaceUri;
                /*0x30*/ System.Xml.XmlSpace xmlSpace;
                /*0x38*/ string xmlLang;

                /*0x77505f8*/ void Set(string prefix, string localName, string namespaceUri, int prevNSTop);
                /*0x7751da0*/ void WriteEndElement(System.Xml.XmlRawWriter rawWriter);
                /*0x7752084*/ void WriteFullEndElement(System.Xml.XmlRawWriter rawWriter);
            }

            enum NamespaceKind
            {
                Written = 0,
                NeedToWrite = 1,
                Implied = 2,
                Special = 3,
            }

            struct Namespace
            {
                /*0x10*/ string prefix;
                /*0x18*/ string namespaceUri;
                /*0x20*/ System.Xml.XmlWellFormedWriter.NamespaceKind kind;
                /*0x24*/ int prevNsIndex;

                /*0x77505b8*/ void Set(string prefix, string namespaceUri, System.Xml.XmlWellFormedWriter.NamespaceKind kind);
                /*0x77573ec*/ void WriteDecl(System.Xml.XmlWriter writer, System.Xml.XmlRawWriter rawWriter);
            }

            struct AttrName
            {
                /*0x10*/ string prefix;
                /*0x18*/ string namespaceUri;
                /*0x20*/ string localName;
                /*0x28*/ int prev;

                /*0x7757660*/ void Set(string prefix, string localName, string namespaceUri);
                /*0x77576ac*/ bool IsDuplicate(string prefix, string localName, string namespaceUri);
            }

            enum SpecialAttribute
            {
                No = 0,
                DefaultXmlns = 1,
                PrefixedXmlns = 2,
                XmlSpace = 3,
                XmlLang = 4,
            }

            class AttributeValueCache
            {
                /*0x10*/ System.Text.StringBuilder stringValue;
                /*0x18*/ string singleStringValue;
                /*0x20*/ System.Xml.XmlWellFormedWriter.AttributeValueCache.Item[] items;
                /*0x28*/ int firstItem;
                /*0x2c*/ int lastItem;

                /*0x7756b9c*/ AttributeValueCache();
                /*0x7753520*/ string get_StringValue();
                /*0x775479c*/ void WriteEntityRef(string name);
                /*0x7754ab4*/ void WriteCharEntity(char ch);
                /*0x7754ca0*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
                /*0x7754ef8*/ void WriteWhitespace(string ws);
                /*0x7755038*/ void WriteString(string text);
                /*0x7755308*/ void WriteChars(char[] buffer, int index, int count);
                /*0x775561c*/ void WriteRaw(char[] buffer, int index, int count);
                /*0x77557c4*/ void WriteRaw(string data);
                /*0x77569ec*/ void WriteValue(string value);
                /*0x7753a0c*/ void Replay(System.Xml.XmlWriter writer);
                /*0x7753d04*/ void Trim();
                /*0x7754190*/ void Clear();
                /*0x77580b8*/ void StartComplexValue();
                /*0x7758108*/ void AddItem(System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType type, object data);

                enum ItemType
                {
                    EntityRef = 0,
                    CharEntity = 1,
                    SurrogateCharEntity = 2,
                    Whitespace = 3,
                    String = 4,
                    StringChars = 5,
                    Raw = 6,
                    RawChars = 7,
                    ValueString = 8,
                }

                class Item
                {
                    /*0x10*/ System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType type;
                    /*0x18*/ object data;

                    /*0x77582f0*/ Item();
                    /*0x77582f8*/ void Set(System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType type, object data);
                }

                class BufferChunk
                {
                    /*0x10*/ char[] buffer;
                    /*0x18*/ int index;
                    /*0x1c*/ int count;

                    /*0x77582a8*/ BufferChunk(char[] buffer, int index, int count);
                }
            }
        }

        enum WriteState
        {
            Start = 0,
            Prolog = 1,
            Element = 2,
            Attribute = 3,
            Content = 4,
            Closed = 5,
            Error = 6,
        }

        class XmlWriter : System.IDisposable
        {
            /*0x10*/ char[] writeNodeBuffer;

            static /*0x77590f0*/ System.Xml.XmlWriter Create(System.IO.Stream output, System.Xml.XmlWriterSettings settings);
            static /*0x775965c*/ System.Xml.XmlWriter Create(System.IO.TextWriter output, System.Xml.XmlWriterSettings settings);
            /*0x7750580*/ XmlWriter();
            /*0x38159dc*/ void WriteStartDocument();
            /*0x3815cc4*/ void WriteStartDocument(bool standalone);
            /*0x38159dc*/ void WriteEndDocument();
            /*0x3816958*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x7758308*/ void WriteStartElement(string localName, string ns);
            /*0x3816920*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x7758320*/ void WriteStartElement(string localName);
            /*0x38159dc*/ void WriteEndElement();
            /*0x38159dc*/ void WriteFullEndElement();
            /*0x7758338*/ void WriteAttributeString(string localName, string ns, string value);
            /*0x7758394*/ void WriteAttributeString(string localName, string value);
            /*0x77583f0*/ void WriteAttributeString(string prefix, string localName, string ns, string value);
            /*0x3816920*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x38159dc*/ void WriteEndAttribute();
            /*0x3816710*/ void WriteCData(string text);
            /*0x3816710*/ void WriteComment(string text);
            /*0x3816810*/ void WriteProcessingInstruction(string name, string text);
            /*0x3816710*/ void WriteEntityRef(string name);
            void WriteCharEntity(char ch);
            /*0x3816710*/ void WriteWhitespace(string ws);
            /*0x3816710*/ void WriteString(string text);
            void WriteSurrogateCharEntity(char lowChar, char highChar);
            void WriteChars(char[] buffer, int index, int count);
            void WriteRaw(char[] buffer, int index, int count);
            /*0x3816710*/ void WriteRaw(string data);
            void WriteBase64(byte[] buffer, int index, int count);
            /*0x7756b78*/ void WriteBinHex(byte[] buffer, int index, int count);
            /*0x3814574*/ System.Xml.WriteState get_WriteState();
            /*0x7758440*/ void Close();
            /*0x38159dc*/ void Flush();
            /*0x3814a3c*/ string LookupPrefix(string ns);
            /*0x7758444*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x775844c*/ string get_XmlLang();
            /*0x7758464*/ void WriteQualifiedName(string localName, string ns);
            /*0x77585b0*/ void WriteValue(string value);
            /*0x77585c8*/ void WriteValue(bool value);
            /*0x7758644*/ void WriteValue(System.DateTime value);
            /*0x77586c4*/ void WriteValue(double value);
            /*0x7758740*/ void WriteValue(float value);
            /*0x77587bc*/ void WriteValue(decimal value);
            /*0x7758840*/ void WriteValue(int value);
            /*0x77588bc*/ void WriteValue(long value);
            /*0x7758938*/ void WriteAttributes(System.Xml.XmlReader reader, bool defattr);
            /*0x7758bb4*/ void WriteNode(System.Xml.XmlReader reader, bool defattr);
            /*0x7759028*/ void WriteElementString(string localName, string value);
            /*0x7759034*/ void WriteElementString(string localName, string ns, string value);
            /*0x7759098*/ void Dispose();
            /*0x77590ac*/ void Dispose(bool disposing);
        }

        enum XmlOutputMethod
        {
            Xml = 0,
            Html = 1,
            Text = 2,
            AutoDetect = 3,
        }

        enum TriState
        {
            Unknown = -1,
            False = 0,
            True = 1,
        }

        enum XmlStandalone
        {
            Omit = 0,
            Yes = 1,
            No = 2,
        }

        class XmlWriterSettings
        {
            /*0x10*/ bool useAsync;
            /*0x18*/ System.Text.Encoding encoding;
            /*0x20*/ bool omitXmlDecl;
            /*0x24*/ System.Xml.NewLineHandling newLineHandling;
            /*0x28*/ string newLineChars;
            /*0x30*/ System.Xml.TriState indent;
            /*0x38*/ string indentChars;
            /*0x40*/ bool newLineOnAttributes;
            /*0x41*/ bool closeOutput;
            /*0x44*/ System.Xml.NamespaceHandling namespaceHandling;
            /*0x48*/ System.Xml.ConformanceLevel conformanceLevel;
            /*0x4c*/ bool checkCharacters;
            /*0x4d*/ bool writeEndDocumentOnClose;
            /*0x50*/ System.Xml.XmlOutputMethod outputMethod;
            /*0x58*/ System.Collections.Generic.List<System.Xml.XmlQualifiedName> cdataSections;
            /*0x60*/ bool doNotEscapeUriAttributes;
            /*0x61*/ bool mergeCDataSections;
            /*0x68*/ string mediaType;
            /*0x70*/ string docTypeSystem;
            /*0x78*/ string docTypePublic;
            /*0x80*/ System.Xml.XmlStandalone standalone;
            /*0x84*/ bool autoXmlDecl;
            /*0x85*/ bool isReadOnly;

            /*0x7759158*/ XmlWriterSettings();
            /*0x7759aec*/ bool get_Async();
            /*0x7759af4*/ System.Text.Encoding get_Encoding();
            /*0x7759afc*/ bool get_OmitXmlDeclaration();
            /*0x7759b04*/ void set_OmitXmlDeclaration(bool value);
            /*0x7759c18*/ System.Xml.NewLineHandling get_NewLineHandling();
            /*0x7759c20*/ string get_NewLineChars();
            /*0x7759c28*/ bool get_Indent();
            /*0x7759c38*/ void set_Indent(bool value);
            /*0x7759ca0*/ string get_IndentChars();
            /*0x7759ca8*/ bool get_NewLineOnAttributes();
            /*0x7759cb0*/ bool get_CloseOutput();
            /*0x7759cb8*/ System.Xml.ConformanceLevel get_ConformanceLevel();
            /*0x7759cc0*/ void set_ConformanceLevel(System.Xml.ConformanceLevel value);
            /*0x7759d6c*/ bool get_CheckCharacters();
            /*0x7759d74*/ System.Xml.NamespaceHandling get_NamespaceHandling();
            /*0x7759d7c*/ void set_NamespaceHandling(System.Xml.NamespaceHandling value);
            /*0x7759e28*/ bool get_WriteEndDocumentOnClose();
            /*0x7759e30*/ System.Xml.XmlOutputMethod get_OutputMethod();
            /*0x7759e38*/ void set_OutputMethod(System.Xml.XmlOutputMethod value);
            /*0x7759e40*/ System.Xml.XmlWriterSettings Clone();
            /*0x7759f14*/ System.Collections.Generic.List<System.Xml.XmlQualifiedName> get_CDataSectionElements();
            /*0x7759f1c*/ bool get_DoNotEscapeUriAttributes();
            /*0x7759f24*/ bool get_MergeCDataSections();
            /*0x7759f2c*/ string get_MediaType();
            /*0x7759f34*/ string get_DocTypeSystem();
            /*0x7759f3c*/ string get_DocTypePublic();
            /*0x7759f44*/ System.Xml.XmlStandalone get_Standalone();
            /*0x7759f4c*/ bool get_AutoXmlDeclaration();
            /*0x7759f54*/ System.Xml.TriState get_IndentInternal();
            /*0x7759f5c*/ bool get_IsQuerySpecific();
            /*0x77591e8*/ System.Xml.XmlWriter CreateWriter(System.IO.Stream output);
            /*0x77596c4*/ System.Xml.XmlWriter CreateWriter(System.IO.TextWriter output);
            /*0x7759fcc*/ void set_ReadOnly(bool value);
            /*0x7759b64*/ void CheckReadOnly(string propertyName);
            /*0x77599bc*/ void Initialize();
        }

        class XsdCachingReader : System.Xml.XmlReader, System.Xml.IXmlLineInfo
        {
            /*0x10*/ System.Xml.XmlReader coreReader;
            /*0x18*/ System.Xml.XmlNameTable coreReaderNameTable;
            /*0x20*/ System.Xml.ValidatingReaderNodeData[] contentEvents;
            /*0x28*/ System.Xml.ValidatingReaderNodeData[] attributeEvents;
            /*0x30*/ System.Xml.ValidatingReaderNodeData cachedNode;
            /*0x38*/ System.Xml.XsdCachingReader.CachingReaderState cacheState;
            /*0x3c*/ int contentIndex;
            /*0x40*/ int attributeCount;
            /*0x44*/ bool returnOriginalStringValues;
            /*0x48*/ System.Xml.CachingEventHandler cacheHandler;
            /*0x50*/ int currentAttrIndex;
            /*0x54*/ int currentContentIndex;
            /*0x58*/ bool readAhead;
            /*0x60*/ System.Xml.IXmlLineInfo lineInfo;
            /*0x68*/ System.Xml.ValidatingReaderNodeData textNode;

            /*0x7759fd8*/ XsdCachingReader(System.Xml.XmlReader reader, System.Xml.IXmlLineInfo lineInfo, System.Xml.CachingEventHandler handlerMethod);
            /*0x775a0d0*/ void Init();
            /*0x775a550*/ void Reset(System.Xml.XmlReader reader);
            /*0x775a56c*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x775a58c*/ System.Xml.XmlNodeType get_NodeType();
            /*0x775a5a8*/ string get_Name();
            /*0x775a5cc*/ string get_LocalName();
            /*0x775a5e8*/ string get_NamespaceURI();
            /*0x775a604*/ string get_Prefix();
            /*0x775a620*/ string get_Value();
            /*0x775a650*/ int get_Depth();
            /*0x775a66c*/ string get_BaseURI();
            /*0x775a690*/ bool get_IsEmptyElement();
            /*0x775a698*/ bool get_IsDefault();
            /*0x775a6a0*/ char get_QuoteChar();
            /*0x775a6c4*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x775a6e8*/ string get_XmlLang();
            /*0x775a70c*/ int get_AttributeCount();
            /*0x775a714*/ string GetAttribute(string name);
            /*0x775a8f0*/ string GetAttribute(string name, string namespaceURI);
            /*0x775a9e8*/ string GetAttribute(int i);
            /*0x775aa78*/ bool MoveToAttribute(string name);
            /*0x775ab10*/ bool MoveToAttribute(string name, string ns);
            /*0x775ac40*/ void MoveToAttribute(int i);
            /*0x775acd0*/ bool MoveToFirstAttribute();
            /*0x775ad14*/ bool MoveToNextAttribute();
            /*0x775ad74*/ bool MoveToElement();
            /*0x775adc8*/ bool Read();
            /*0x775b0b8*/ System.Xml.ValidatingReaderNodeData RecordTextNode(string textValue, string originalStringValue, int depth, int lineNo, int linePos);
            /*0x775b130*/ void SwitchTextNodeAndEndElement(string textValue, string originalStringValue);
            /*0x775b240*/ void RecordEndElementNode();
            /*0x775b370*/ string ReadOriginalContentAsString();
            /*0x775b394*/ bool get_EOF();
            /*0x775b3d0*/ void Close();
            /*0x775b404*/ System.Xml.ReadState get_ReadState();
            /*0x775b428*/ void Skip();
            /*0x775b53c*/ System.Xml.XmlNameTable get_NameTable();
            /*0x775b544*/ string LookupNamespace(string prefix);
            /*0x775b568*/ void ResolveEntity();
            /*0x775b5a0*/ bool ReadAttributeValue();
            /*0x775b69c*/ bool System.Xml.IXmlLineInfo.HasLineInfo();
            /*0x775b6a4*/ int System.Xml.IXmlLineInfo.get_LineNumber();
            /*0x775b6c0*/ int System.Xml.IXmlLineInfo.get_LinePosition();
            /*0x775b6dc*/ void SetToReplayMode();
            /*0x775b6fc*/ System.Xml.XmlReader GetCoreReader();
            /*0x775b704*/ System.Xml.IXmlLineInfo GetLineInfo();
            /*0x775b0a8*/ void ClearAttributesInfo();
            /*0x775b70c*/ System.Xml.ValidatingReaderNodeData AddAttribute(int attIndex);
            /*0x775a23c*/ System.Xml.ValidatingReaderNodeData AddContent(System.Xml.XmlNodeType nodeType);
            /*0x775a3cc*/ void RecordAttributes();
            /*0x775a7a0*/ int GetAttributeIndexWithoutPrefix(string name);
            /*0x775a850*/ int GetAttributeIndexWithPrefix(string name);
            /*0x775b5fc*/ System.Xml.ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth);

            enum CachingReaderState
            {
                None = 0,
                Init = 1,
                Record = 2,
                Replay = 3,
                ReaderClosed = 4,
                Error = 5,
            }
        }

        class CachingEventHandler : System.MulticastDelegate
        {
            /*0x775b880*/ CachingEventHandler(object object, nint method);
            /*0x775b988*/ void Invoke(System.Xml.XsdCachingReader cachingReader);
        }

        class AttributePSVIInfo
        {
            /*0x10*/ string localName;
            /*0x18*/ string namespaceUri;
            /*0x20*/ object typedAttributeValue;
            /*0x28*/ System.Xml.Schema.XmlSchemaInfo attributeSchemaInfo;

            /*0x775b99c*/ AttributePSVIInfo();
            /*0x775ba08*/ void Reset();
        }

        class XsdValidatingReader : System.Xml.XmlReader, System.Xml.Schema.IXmlSchemaInfo, System.Xml.IXmlLineInfo, System.Xml.IXmlNamespaceResolver
        {
            static /*0x0*/ System.Type TypeOfString;
            /*0x10*/ System.Xml.XmlReader coreReader;
            /*0x18*/ System.Xml.IXmlNamespaceResolver coreReaderNSResolver;
            /*0x20*/ System.Xml.IXmlNamespaceResolver thisNSResolver;
            /*0x28*/ System.Xml.Schema.XmlSchemaValidator validator;
            /*0x30*/ System.Xml.XmlResolver xmlResolver;
            /*0x38*/ System.Xml.Schema.ValidationEventHandler validationEvent;
            /*0x40*/ System.Xml.XsdValidatingReader.ValidatingReaderState validationState;
            /*0x48*/ System.Xml.Schema.XmlValueGetter valueGetter;
            /*0x50*/ System.Xml.XmlNamespaceManager nsManager;
            /*0x58*/ bool manageNamespaces;
            /*0x59*/ bool processInlineSchema;
            /*0x5a*/ bool replayCache;
            /*0x60*/ System.Xml.ValidatingReaderNodeData cachedNode;
            /*0x68*/ System.Xml.AttributePSVIInfo attributePSVI;
            /*0x70*/ int attributeCount;
            /*0x74*/ int coreReaderAttributeCount;
            /*0x78*/ int currentAttrIndex;
            /*0x80*/ System.Xml.AttributePSVIInfo[] attributePSVINodes;
            /*0x88*/ System.Collections.ArrayList defaultAttributes;
            /*0x90*/ System.Xml.Schema.Parser inlineSchemaParser;
            /*0x98*/ object atomicValue;
            /*0xa0*/ System.Xml.Schema.XmlSchemaInfo xmlSchemaInfo;
            /*0xa8*/ string originalAtomicValueString;
            /*0xb0*/ System.Xml.XmlNameTable coreReaderNameTable;
            /*0xb8*/ System.Xml.XsdCachingReader cachingReader;
            /*0xc0*/ System.Xml.ValidatingReaderNodeData textNode;
            /*0xc8*/ string NsXmlNs;
            /*0xd0*/ string NsXs;
            /*0xd8*/ string NsXsi;
            /*0xe0*/ string XsiType;
            /*0xe8*/ string XsiNil;
            /*0xf0*/ string XsdSchema;
            /*0xf8*/ string XsiSchemaLocation;
            /*0x100*/ string XsiNoNamespaceSchemaLocation;
            /*0x108*/ System.Xml.XmlCharType xmlCharType;
            /*0x110*/ System.Xml.IXmlLineInfo lineInfo;
            /*0x118*/ System.Xml.ReadContentAsBinaryHelper readBinaryHelper;
            /*0x120*/ System.Xml.XsdValidatingReader.ValidatingReaderState savedState;

            /*0x775ba74*/ XsdValidatingReader(System.Xml.XmlReader reader, System.Xml.XmlResolver xmlResolver, System.Xml.XmlReaderSettings readerSettings, System.Xml.Schema.XmlSchemaObject partialValidationType);
            /*0x775c230*/ XsdValidatingReader(System.Xml.XmlReader reader, System.Xml.XmlResolver xmlResolver, System.Xml.XmlReaderSettings readerSettings);
            /*0x775bc80*/ void Init();
            /*0x775c020*/ void SetupValidator(System.Xml.XmlReaderSettings readerSettings, System.Xml.XmlReader reader, System.Xml.Schema.XmlSchemaObject partialValidationType);
            /*0x775c238*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x775c308*/ System.Xml.XmlNodeType get_NodeType();
            /*0x775c390*/ string get_Name();
            /*0x775c4a8*/ string get_LocalName();
            /*0x775c4e4*/ string get_NamespaceURI();
            /*0x775c520*/ string get_Prefix();
            /*0x775c55c*/ string get_Value();
            /*0x775c598*/ int get_Depth();
            /*0x775c5d4*/ string get_BaseURI();
            /*0x775c5f8*/ bool get_IsEmptyElement();
            /*0x775c61c*/ bool get_IsDefault();
            /*0x775c658*/ char get_QuoteChar();
            /*0x775c67c*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x775c6a0*/ string get_XmlLang();
            /*0x775c6c4*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x775c6c8*/ System.Type get_ValueType();
            /*0x775c7ac*/ object ReadContentAsObject();
            /*0x775c894*/ bool ReadContentAsBoolean();
            /*0x775cb98*/ System.DateTime ReadContentAsDateTime();
            /*0x775ce38*/ double ReadContentAsDouble();
            /*0x775d0d8*/ float ReadContentAsFloat();
            /*0x775d378*/ decimal ReadContentAsDecimal();
            /*0x775d618*/ int ReadContentAsInt();
            /*0x775d8b8*/ long ReadContentAsLong();
            /*0x775db58*/ string ReadContentAsString();
            /*0x775ddc4*/ object ReadContentAs(System.Type returnType, System.Xml.IXmlNamespaceResolver namespaceResolver);
            /*0x775e394*/ bool ReadElementContentAsBoolean();
            /*0x775e5f8*/ System.DateTime ReadElementContentAsDateTime();
            /*0x775e844*/ double ReadElementContentAsDouble();
            /*0x775ea90*/ float ReadElementContentAsFloat();
            /*0x775ecdc*/ decimal ReadElementContentAsDecimal();
            /*0x775ef28*/ int ReadElementContentAsInt();
            /*0x775f174*/ long ReadElementContentAsLong();
            /*0x775f3c0*/ string ReadElementContentAsString();
            /*0x775f5bc*/ int get_AttributeCount();
            /*0x775f5c4*/ string GetAttribute(string name);
            /*0x775f7a8*/ string GetAttribute(string name, string namespaceURI);
            /*0x775f9bc*/ string GetAttribute(int i);
            /*0x775fa98*/ bool MoveToAttribute(string name);
            /*0x775fce8*/ bool MoveToAttribute(string name, string ns);
            /*0x775fee0*/ void MoveToAttribute(int i);
            /*0x77600ac*/ bool MoveToFirstAttribute();
            /*0x776023c*/ bool MoveToNextAttribute();
            /*0x77603cc*/ bool MoveToElement();
            /*0x7760420*/ bool Read();
            /*0x7760828*/ bool get_EOF();
            /*0x776084c*/ void Close();
            /*0x7760880*/ System.Xml.ReadState get_ReadState();
            /*0x77608bc*/ void Skip();
            /*0x7760a28*/ System.Xml.XmlNameTable get_NameTable();
            /*0x7760a30*/ string LookupNamespace(string prefix);
            /*0x7760adc*/ void ResolveEntity();
            /*0x7760b14*/ bool ReadAttributeValue();
            /*0x7760c7c*/ int ReadContentAsBase64(byte[] buffer, int index, int count);
            /*0x7760d40*/ int ReadContentAsBinHex(byte[] buffer, int index, int count);
            /*0x7760e04*/ bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault();
            /*0x776112c*/ bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil();
            /*0x7761178*/ System.Xml.Schema.XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity();
            /*0x776120c*/ System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType();
            /*0x7761394*/ System.Xml.Schema.XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType();
            /*0x77613f0*/ System.Xml.Schema.XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement();
            /*0x7761444*/ System.Xml.Schema.XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute();
            /*0x7761488*/ bool HasLineInfo();
            /*0x7761490*/ int get_LineNumber();
            /*0x7761540*/ int get_LinePosition();
            /*0x77615f0*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x77616b0*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0x7761774*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            /*0x7761838*/ object GetStringValue();
            /*0x775cb4c*/ System.Xml.Schema.XmlSchemaType get_ElementXmlType();
            /*0x775cb68*/ System.Xml.Schema.XmlSchemaType get_AttributeXmlType();
            /*0x775c790*/ System.Xml.Schema.XmlSchemaInfo get_AttributeSchemaInfo();
            /*0x7760570*/ void ProcessReaderEvent();
            /*0x7761858*/ void ProcessElementEvent();
            /*0x7761d10*/ void ProcessEndElementEvent();
            /*0x7761ec4*/ void ValidateAttributes();
            /*0x77607e4*/ void ClearAttributesInfo();
            /*0x775fb74*/ System.Xml.AttributePSVIInfo GetAttributePSVI(string name);
            /*0x775fe38*/ System.Xml.AttributePSVIInfo GetAttributePSVI(string localName, string ns);
            /*0x775f630*/ System.Xml.ValidatingReaderNodeData GetDefaultAttribute(string name, bool updatePosition);
            /*0x775f878*/ System.Xml.ValidatingReaderNodeData GetDefaultAttribute(string attrLocalName, string ns, bool updatePosition);
            /*0x77621f0*/ System.Xml.AttributePSVIInfo AddAttributePSVI(int attIndex);
            /*0x7761e74*/ bool IsXSDRoot(string localName, string ns);
            /*0x776071c*/ void ProcessInlineSchema();
            /*0x775cb30*/ object InternalReadContentAsObject();
            /*0x775c878*/ object InternalReadContentAsObject(bool unwrapTypedValue);
            /*0x775e13c*/ object InternalReadContentAsObject(bool unwrapTypedValue, ref string originalStringValue);
            /*0x775e5dc*/ object InternalReadElementContentAsObject(ref System.Xml.Schema.XmlSchemaType xmlType);
            /*0x7762678*/ object InternalReadElementContentAsObject(ref System.Xml.Schema.XmlSchemaType xmlType, bool unwrapTypedValue);
            /*0x7762694*/ object InternalReadElementContentAsObject(ref System.Xml.Schema.XmlSchemaType xmlType, bool unwrapTypedValue, ref string originalString);
            /*0x776249c*/ object ReadTillEndElement();
            /*0x7762870*/ void SwitchReader();
            /*0x77628f8*/ void ReadAheadForMemberType();
            /*0x7760e8c*/ void GetIsDefault();
            /*0x776128c*/ void GetMemberType();
            /*0x7762354*/ object ReturnBoxedValue(object typedValue, System.Xml.Schema.XmlSchemaType xmlType, bool unWrap);
            /*0x77620f0*/ System.Xml.XsdCachingReader GetCachingReader();
            /*0x7760bdc*/ System.Xml.ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth);
            /*0x7762aec*/ void CachingCallBack(System.Xml.XsdCachingReader cachingReader);
            /*0x7762090*/ string GetOriginalAtomicValueStringOfElement();

            enum ValidatingReaderState
            {
                None = 0,
                Init = 1,
                Read = 2,
                OnDefaultAttribute = -1,
                OnReadAttributeValue = -2,
                OnAttribute = 3,
                ClearAttributes = 4,
                ParseInlineSchema = 5,
                ReadAhead = 6,
                OnReadBinaryContent = 7,
                ReaderClosed = 8,
                EOF = 9,
                Error = 10,
            }
        }

        class DocumentXPathNavigator : System.Xml.XPath.XPathNavigator
        {
            /*0x10*/ System.Xml.XmlDocument document;
            /*0x18*/ System.Xml.XmlNode source;
            /*0x20*/ int attributeIndex;
            /*0x28*/ System.Xml.XmlElement namespaceParent;

            static /*0x776389c*/ bool MoveToFirstNamespaceLocal(System.Xml.XmlAttributeCollection attributes, ref int index);
            static /*0x7763a3c*/ bool MoveToFirstNamespaceGlobal(ref System.Xml.XmlAttributeCollection attributes, ref int index);
            static /*0x77640e4*/ bool MoveToNextNamespaceLocal(System.Xml.XmlAttributeCollection attributes, ref int index);
            static /*0x7763b90*/ bool MoveToNextNamespaceGlobal(ref System.Xml.XmlAttributeCollection attributes, ref int index);
            static /*0x7764050*/ bool ResetAttributePosition(System.Xml.XmlAttribute attribute, System.Xml.XmlAttributeCollection attributes, ref int index);
            static /*0x7763fa0*/ bool CheckAttributePosition(System.Xml.XmlAttribute attribute, ref System.Xml.XmlAttributeCollection attributes, int index);
            /*0x7762b34*/ DocumentXPathNavigator(System.Xml.XmlDocument document, System.Xml.XmlNode node);
            /*0x7762ca0*/ DocumentXPathNavigator(System.Xml.DocumentXPathNavigator other);
            /*0x7762d44*/ System.Xml.XPath.XPathNavigator Clone();
            /*0x7762d9c*/ System.Xml.XmlNameTable get_NameTable();
            /*0x7762ddc*/ System.Xml.XPath.XPathNodeType get_NodeType();
            /*0x7762e50*/ string get_LocalName();
            /*0x7762e74*/ string get_NamespaceURI();
            /*0x7762f54*/ string get_Prefix();
            /*0x7763008*/ string get_Value();
            /*0x77630a0*/ string get_ValueDocument();
            /*0x77630e8*/ string get_ValueText();
            /*0x77632e8*/ object get_UnderlyingObject();
            /*0x7763300*/ bool MoveToNamespace(string name);
            /*0x7763630*/ bool MoveToFirstNamespace(System.Xml.XPath.XPathNamespaceScope scope);
            /*0x7763ce4*/ bool MoveToNextNamespace(System.Xml.XPath.XPathNamespaceScope scope);
            /*0x7764138*/ bool PathHasDuplicateNamespace(System.Xml.XmlElement top, System.Xml.XmlElement bottom, string localName);
            /*0x776422c*/ string LookupNamespace(string prefix);
            /*0x7764288*/ bool MoveToParent();
            /*0x77643fc*/ bool IsSamePosition(System.Xml.XPath.XPathNavigator other);
            /*0x776448c*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x7762bb8*/ void ResetPosition(System.Xml.XmlNode node);
            /*0x7762e08*/ void CalibrateText();
            /*0x7764384*/ System.Xml.XmlNode ParentNode(System.Xml.XmlNode node);
            /*0x776450c*/ System.Xml.XmlNode ParentNodeTail(System.Xml.XmlNode parent);
            /*0x776328c*/ System.Xml.XmlNode NextSibling(System.Xml.XmlNode node);
            /*0x7764554*/ System.Xml.XmlNode NextSiblingTail(System.Xml.XmlNode node, System.Xml.XmlNode sibling);
            /*0x77644b0*/ System.Xml.XmlNode PreviousText(System.Xml.XmlNode node);
            /*0x7764608*/ System.Xml.XmlNode PreviousTextTail(System.Xml.XmlNode node, System.Xml.XmlNode text);
        }

        class DomNameTable
        {
            /*0x10*/ System.Xml.XmlName[] entries;
            /*0x18*/ int count;
            /*0x1c*/ int mask;
            /*0x20*/ System.Xml.XmlDocument ownerDocument;
            /*0x28*/ System.Xml.XmlNameTable nameTable;

            /*0x776470c*/ DomNameTable(System.Xml.XmlDocument document);
            /*0x77647b0*/ System.Xml.XmlName GetName(string prefix, string localName, string ns, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            /*0x7764954*/ System.Xml.XmlName AddName(string prefix, string localName, string ns, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            /*0x7764c88*/ void Grow();
        }

        class XmlAttribute : System.Xml.XmlNode
        {
            /*0x18*/ System.Xml.XmlName name;
            /*0x20*/ System.Xml.XmlLinkedNode lastChild;

            /*0x7764ddc*/ XmlAttribute(System.Xml.XmlName name, System.Xml.XmlDocument doc);
            /*0x7765068*/ XmlAttribute(string prefix, string localName, string namespaceURI, System.Xml.XmlDocument doc);
            /*0x776504c*/ int get_LocalNameHash();
            /*0x77651b8*/ System.Xml.XmlName get_XmlName();
            /*0x77651c0*/ void set_XmlName(System.Xml.XmlName value);
            /*0x77651c8*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x7765290*/ System.Xml.XmlNode get_ParentNode();
            /*0x7765298*/ string get_Name();
            /*0x7765484*/ string get_LocalName();
            /*0x77654a0*/ string get_NamespaceURI();
            /*0x77654bc*/ string get_Prefix();
            /*0x77654d8*/ void set_Prefix(string value);
            /*0x7765580*/ System.Xml.XmlNodeType get_NodeType();
            /*0x7765588*/ System.Xml.XmlDocument get_OwnerDocument();
            /*0x77655a4*/ string get_Value();
            /*0x77655b4*/ void set_Value(string value);
            /*0x77655c4*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x77655cc*/ void set_InnerText(string value);
            /*0x7765624*/ bool PrepareOwnerElementInElementIdAttrMap();
            /*0x77658a0*/ void ResetOwnerElementInElementIdAttrMap(string oldInnerText);
            /*0x7765ad0*/ bool get_IsContainer();
            /*0x7765ad8*/ System.Xml.XmlNode AppendChildForLoad(System.Xml.XmlNode newChild, System.Xml.XmlDocument doc);
            /*0x7765d58*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x7765d60*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x7765d68*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x7765d80*/ bool get_Specified();
            /*0x7765d88*/ System.Xml.XmlNode InsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x77663c4*/ System.Xml.XmlNode InsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x77669d0*/ System.Xml.XmlNode RemoveChild(System.Xml.XmlNode oldChild);
            /*0x7766e10*/ System.Xml.XmlNode PrependChild(System.Xml.XmlNode newChild);
            /*0x7766f0c*/ System.Xml.XmlNode AppendChild(System.Xml.XmlNode newChild);
            /*0x7767454*/ System.Xml.XmlElement get_OwnerElement();
            /*0x77674d0*/ void set_InnerXml(string value);
            /*0x776756c*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x7767620*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x7767688*/ string get_BaseURI();
            /*0x77676f0*/ void SetParent(System.Xml.XmlNode node);
            /*0x77676f8*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x776774c*/ string get_XmlLang();
            /*0x77677b4*/ System.Xml.XPath.XPathNodeType get_XPNodeType();
            /*0x77677d0*/ string get_XPLocalName();
            /*0x7762f28*/ bool get_IsNamespace();
        }

        class XmlAttributeCollection : System.Xml.XmlNamedNodeMap, System.Collections.ICollection, System.Collections.IEnumerable
        {
            /*0x7767864*/ XmlAttributeCollection(System.Xml.XmlNode parent);
            /*0x77638fc*/ System.Xml.XmlAttribute get_ItemOf(int i);
            /*0x77679a0*/ System.Xml.XmlAttribute get_ItemOf(string name);
            /*0x7767b5c*/ System.Xml.XmlAttribute get_ItemOf(string localName, string namespaceURI);
            /*0x7767ca4*/ int FindNodeOffsetNS(System.Xml.XmlAttribute node);
            /*0x7767e1c*/ System.Xml.XmlNode SetNamedItem(System.Xml.XmlNode node);
            /*0x77682cc*/ System.Xml.XmlAttribute Append(System.Xml.XmlAttribute node);
            /*0x7768620*/ System.Xml.XmlAttribute Remove(System.Xml.XmlAttribute node);
            /*0x77686a0*/ System.Xml.XmlAttribute RemoveAt(int i);
            /*0x776874c*/ void RemoveAll();
            /*0x7768794*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
            /*0x7768814*/ bool System.Collections.ICollection.get_IsSynchronized();
            /*0x776881c*/ object System.Collections.ICollection.get_SyncRoot();
            /*0x7768820*/ int System.Collections.ICollection.get_Count();
            /*0x7768830*/ System.Xml.XmlNode AddNode(System.Xml.XmlNode node);
            /*0x7768b80*/ System.Xml.XmlNode InsertNodeAt(int i, System.Xml.XmlNode node);
            /*0x7768dc0*/ System.Xml.XmlNode RemoveNodeAt(int i);
            /*0x77683dc*/ void Detach(System.Xml.XmlAttribute attr);
            /*0x77684c8*/ void InsertParentIntoElementIdAttrMap(System.Xml.XmlAttribute attr);
            /*0x7768f5c*/ void RemoveParentFromElementIdAttrMap(System.Xml.XmlAttribute attr);
            /*0x7768904*/ int RemoveDuplicateAttribute(System.Xml.XmlAttribute attr);
            /*0x776591c*/ bool PrepareParentInElementIdAttrMap(string attrPrefix, string attrLocalName);
            /*0x7765a10*/ void ResetParentInElementIdAttrMap(string oldVal, string newVal);
            /*0x77680cc*/ System.Xml.XmlAttribute InternalAppendAttribute(System.Xml.XmlAttribute node);
        }

        class XmlCDataSection : System.Xml.XmlCharacterData
        {
            /*0x7769694*/ XmlCDataSection(string data, System.Xml.XmlDocument doc);
            /*0x77696d8*/ string get_Name();
            /*0x7769700*/ string get_LocalName();
            /*0x7769728*/ System.Xml.XmlNodeType get_NodeType();
            /*0x7769730*/ System.Xml.XmlNode get_ParentNode();
            /*0x77697b4*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x7769810*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x7769850*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x7769854*/ System.Xml.XPath.XPathNodeType get_XPNodeType();
            /*0x776985c*/ bool get_IsText();
            /*0x7769864*/ System.Xml.XmlNode get_PreviousText();
        }

        class XmlCharacterData : System.Xml.XmlLinkedNode
        {
            /*0x20*/ string data;

            /*0x7769698*/ XmlCharacterData(string data, System.Xml.XmlDocument doc);
            /*0x77698c0*/ string get_Value();
            /*0x77698d0*/ void set_Value(string value);
            /*0x77698e0*/ string get_InnerText();
            /*0x77698ec*/ void set_InnerText(string value);
            /*0x77698f8*/ string get_Data();
            /*0x776991c*/ void set_Data(string value);
            /*0x77699e0*/ bool CheckOnData(string data);
            /*0x7769a1c*/ bool DecideXPNodeTypeForTextNodes(System.Xml.XmlNode node, ref System.Xml.XPath.XPathNodeType xnt);
        }

        class XmlChildEnumerator : System.Collections.IEnumerator
        {
            /*0x10*/ System.Xml.XmlNode container;
            /*0x18*/ System.Xml.XmlNode child;
            /*0x20*/ bool isFirst;

            /*0x7769af0*/ XmlChildEnumerator(System.Xml.XmlNode container);
            /*0x7769b58*/ bool System.Collections.IEnumerator.MoveNext();
            /*0x7769b5c*/ bool MoveNext();
            /*0x7769bec*/ void System.Collections.IEnumerator.Reset();
            /*0x7769c2c*/ object System.Collections.IEnumerator.get_Current();
            /*0x7769c30*/ System.Xml.XmlNode get_Current();
        }

        class XmlChildNodes : System.Xml.XmlNodeList
        {
            /*0x10*/ System.Xml.XmlNode container;

            /*0x7769ca4*/ XmlChildNodes(System.Xml.XmlNode container);
            /*0x7769cdc*/ System.Xml.XmlNode Item(int i);
            /*0x7769d38*/ int get_Count();
            /*0x7769d84*/ System.Collections.IEnumerator GetEnumerator();
        }

        class XmlComment : System.Xml.XmlCharacterData
        {
            /*0x7769e34*/ XmlComment(string comment, System.Xml.XmlDocument doc);
            /*0x7769e38*/ string get_Name();
            /*0x7769e60*/ string get_LocalName();
            /*0x7769e88*/ System.Xml.XmlNodeType get_NodeType();
            /*0x7769e90*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x7769eec*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x7769f2c*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x7769f30*/ System.Xml.XPath.XPathNodeType get_XPNodeType();
        }

        class XmlDeclaration : System.Xml.XmlLinkedNode
        {
            /*0x20*/ string version;
            /*0x28*/ string encoding;
            /*0x30*/ string standalone;

            /*0x7769f38*/ XmlDeclaration(string version, string encoding, string standalone, System.Xml.XmlDocument doc);
            /*0x776a2c4*/ string get_Version();
            /*0x776a2cc*/ void set_Version(string value);
            /*0x776a2d4*/ string get_Encoding();
            /*0x776a150*/ void set_Encoding(string value);
            /*0x776a2dc*/ string get_Standalone();
            /*0x776a180*/ void set_Standalone(string value);
            /*0x776a2e4*/ string get_Value();
            /*0x776a2f4*/ void set_Value(string value);
            /*0x776a304*/ string get_InnerText();
            /*0x776a478*/ void set_InnerText(string value);
            /*0x776a868*/ string get_Name();
            /*0x776a8a8*/ string get_LocalName();
            /*0x776a8b4*/ System.Xml.XmlNodeType get_NodeType();
            /*0x776a8bc*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x776a8f8*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x776a95c*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x776a0d4*/ bool IsValidXmlVersion(string ver);
        }

        class XmlDocument : System.Xml.XmlNode
        {
            static /*0x0*/ System.Xml.EmptyEnumerator EmptyEnumerator;
            static /*0x8*/ System.Xml.Schema.IXmlSchemaInfo NotKnownSchemaInfo;
            static /*0x10*/ System.Xml.Schema.IXmlSchemaInfo ValidSchemaInfo;
            static /*0x18*/ System.Xml.Schema.IXmlSchemaInfo InvalidSchemaInfo;
            /*0x18*/ System.Xml.XmlImplementation implementation;
            /*0x20*/ System.Xml.DomNameTable domNameTable;
            /*0x28*/ System.Xml.XmlLinkedNode lastChild;
            /*0x30*/ System.Xml.XmlNamedNodeMap entities;
            /*0x38*/ System.Collections.Hashtable htElementIdMap;
            /*0x40*/ System.Collections.Hashtable htElementIDAttrDecl;
            /*0x48*/ System.Xml.Schema.SchemaInfo schemaInfo;
            /*0x50*/ System.Xml.Schema.XmlSchemaSet schemas;
            /*0x58*/ bool reportValidity;
            /*0x59*/ bool actualLoadingStatus;
            /*0x60*/ System.Xml.XmlNodeChangedEventHandler onNodeInsertingDelegate;
            /*0x68*/ System.Xml.XmlNodeChangedEventHandler onNodeInsertedDelegate;
            /*0x70*/ System.Xml.XmlNodeChangedEventHandler onNodeRemovingDelegate;
            /*0x78*/ System.Xml.XmlNodeChangedEventHandler onNodeRemovedDelegate;
            /*0x80*/ System.Xml.XmlNodeChangedEventHandler onNodeChangingDelegate;
            /*0x88*/ System.Xml.XmlNodeChangedEventHandler onNodeChangedDelegate;
            /*0x90*/ bool fEntRefNodesPresent;
            /*0x91*/ bool fCDataNodesPresent;
            /*0x92*/ bool preserveWhitespace;
            /*0x93*/ bool isLoading;
            /*0x98*/ string strDocumentName;
            /*0xa0*/ string strDocumentFragmentName;
            /*0xa8*/ string strCommentName;
            /*0xb0*/ string strTextName;
            /*0xb8*/ string strCDataSectionName;
            /*0xc0*/ string strEntityName;
            /*0xc8*/ string strID;
            /*0xd0*/ string strXmlns;
            /*0xd8*/ string strXml;
            /*0xe0*/ string strSpace;
            /*0xe8*/ string strLang;
            /*0xf0*/ string strEmpty;
            /*0xf8*/ string strNonSignificantWhitespaceName;
            /*0x100*/ string strSignificantWhitespaceName;
            /*0x108*/ string strReservedXmlns;
            /*0x110*/ string strReservedXml;
            /*0x118*/ string baseURI;
            /*0x120*/ System.Xml.XmlResolver resolver;
            /*0x128*/ bool bSetResolver;
            /*0x130*/ object objLock;
            /*0x138*/ System.Xml.XmlAttribute namespaceXml;

            static /*0x776f058*/ XmlDocument();
            static /*0x7764f78*/ void CheckName(string name);
            static /*0x776d0e4*/ bool IsTextNode(System.Xml.XmlNodeType nt);
            /*0x776a960*/ XmlDocument();
            /*0x776aec4*/ XmlDocument(System.Xml.XmlNameTable nt);
            /*0x776aa24*/ XmlDocument(System.Xml.XmlImplementation imp);
            /*0x776af74*/ System.Xml.Schema.SchemaInfo get_DtdSchemaInfo();
            /*0x776af7c*/ void set_DtdSchemaInfo(System.Xml.Schema.SchemaInfo value);
            /*0x776af84*/ System.Xml.XmlName AddXmlName(string prefix, string localName, string namespaceURI, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            /*0x776af9c*/ System.Xml.XmlName GetXmlName(string prefix, string localName, string namespaceURI, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            /*0x77650a4*/ System.Xml.XmlName AddAttrXmlName(string prefix, string localName, string namespaceURI, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            /*0x776afb4*/ bool AddIdInfo(System.Xml.XmlName eleName, System.Xml.XmlName attrName);
            /*0x776b080*/ System.Xml.XmlName GetIDInfoByElement_(System.Xml.XmlName eleName);
            /*0x7769348*/ System.Xml.XmlName GetIDInfoByElement(System.Xml.XmlName eleName);
            /*0x776b148*/ System.WeakReference GetElement(System.Collections.ArrayList elementList, System.Xml.XmlElement elem);
            /*0x776935c*/ void AddElementWithId(string id, System.Xml.XmlElement elem);
            /*0x7769550*/ void RemoveElementWithId(string id, System.Xml.XmlElement elem);
            /*0x776b7a4*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x776b8a8*/ System.Xml.XmlNodeType get_NodeType();
            /*0x776b8b0*/ System.Xml.XmlNode get_ParentNode();
            /*0x776b8b8*/ System.Xml.XmlDocumentType get_DocumentType();
            /*0x776b944*/ System.Xml.XmlDeclaration get_Declaration();
            /*0x776b9e8*/ System.Xml.XmlImplementation get_Implementation();
            /*0x776b9f0*/ string get_Name();
            /*0x776b9f8*/ string get_LocalName();
            /*0x7763200*/ System.Xml.XmlElement get_DocumentElement();
            /*0x776ba00*/ bool get_IsContainer();
            /*0x776ba08*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x776ba10*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x776ba18*/ System.Xml.XmlDocument get_OwnerDocument();
            /*0x776ba20*/ void set_Schemas(System.Xml.Schema.XmlSchemaSet value);
            /*0x776ba28*/ bool get_CanReportValidity();
            /*0x776ba30*/ bool get_HasSetResolver();
            /*0x776ba38*/ System.Xml.XmlResolver GetResolver();
            /*0x776ba40*/ void set_XmlResolver(System.Xml.XmlResolver value);
            /*0x776bbd8*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x776bcc0*/ bool HasNodeTypeInPrevSiblings(System.Xml.XmlNodeType nt, System.Xml.XmlNode refNode);
            /*0x776bd70*/ bool HasNodeTypeInNextSiblings(System.Xml.XmlNodeType nt, System.Xml.XmlNode refNode);
            /*0x776bdd4*/ bool CanInsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x776bf3c*/ bool CanInsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x776c038*/ System.Xml.XmlAttribute CreateAttribute(string name);
            /*0x776c18c*/ void SetDefaultNamespace(string prefix, string localName, ref string namespaceURI);
            /*0x776c230*/ System.Xml.XmlCDataSection CreateCDataSection(string data);
            /*0x776c2a0*/ System.Xml.XmlComment CreateComment(string data);
            /*0x776c308*/ System.Xml.XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset);
            /*0x776c498*/ System.Xml.XmlDocumentFragment CreateDocumentFragment();
            /*0x776c574*/ System.Xml.XmlElement CreateElement(string name);
            /*0x776c5f8*/ void AddDefaultAttributes(System.Xml.XmlElement elem);
            /*0x776c874*/ System.Xml.Schema.SchemaElementDecl GetSchemaElementDecl(System.Xml.XmlElement elem);
            /*0x776c980*/ System.Xml.XmlAttribute PrepareDefaultAttribute(System.Xml.Schema.SchemaAttDef attdef, string attrPrefix, string attrLocalname, string attrNamespaceURI);
            /*0x776ca7c*/ System.Xml.XmlEntityReference CreateEntityReference(string name);
            /*0x776cbe0*/ System.Xml.XmlProcessingInstruction CreateProcessingInstruction(string target, string data);
            /*0x776cc54*/ System.Xml.XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone);
            /*0x776ccd4*/ System.Xml.XmlText CreateTextNode(string text);
            /*0x776cd40*/ System.Xml.XmlSignificantWhitespace CreateSignificantWhitespace(string text);
            /*0x776cdac*/ System.Xml.XPath.XPathNavigator CreateNavigator();
            /*0x776cdc0*/ System.Xml.XPath.XPathNavigator CreateNavigator(System.Xml.XmlNode node);
            /*0x776cf34*/ System.Xml.XmlNode NormalizeText(System.Xml.XmlNode n);
            /*0x776d108*/ System.Xml.XmlWhitespace CreateWhitespace(string text);
            /*0x776d174*/ System.Xml.XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI);
            /*0x776d1f4*/ System.Xml.XmlElement CreateElement(string qualifiedName, string namespaceURI);
            /*0x776d274*/ System.Xml.XmlNode ImportNodeInternal(System.Xml.XmlNode node, bool deep);
            /*0x776d71c*/ void ImportAttributes(System.Xml.XmlNode fromElem, System.Xml.XmlNode toElem);
            /*0x776b80c*/ void ImportChildren(System.Xml.XmlNode fromNode, System.Xml.XmlNode toNode, bool deep);
            /*0x7762dc0*/ System.Xml.XmlNameTable get_NameTable();
            /*0x776d830*/ System.Xml.XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI);
            /*0x776d8c8*/ System.Xml.XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI);
            /*0x776d94c*/ System.Xml.XmlElement CreateElement(string prefix, string localName, string namespaceURI);
            /*0x776db4c*/ bool get_IsReadOnly();
            /*0x776db54*/ System.Xml.XmlNamedNodeMap get_Entities();
            /*0x776dbd8*/ void set_Entities(System.Xml.XmlNamedNodeMap value);
            /*0x776dbe0*/ bool get_IsLoading();
            /*0x776dbe8*/ void set_IsLoading(bool value);
            /*0x776dbf4*/ bool get_ActualLoadingStatus();
            /*0x776dbfc*/ System.Xml.XmlNode ReadNode(System.Xml.XmlReader reader);
            /*0x776de18*/ System.Xml.XmlTextReader SetupReader(System.Xml.XmlTextReader tr);
            /*0x776de78*/ void Load(System.Xml.XmlReader reader);
            /*0x776e1e8*/ void LoadXml(string xml);
            /*0x776e338*/ void set_InnerText(string value);
            /*0x776e390*/ void set_InnerXml(string value);
            /*0x776e3a0*/ void Save(System.Xml.XmlWriter w);
            /*0x776e5b8*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x776e5c8*/ void WriteContentTo(System.Xml.XmlWriter xw);
            /*0x776e8ec*/ System.Xml.XmlNodeChangedEventArgs GetEventArgs(System.Xml.XmlNode node, System.Xml.XmlNode oldParent, System.Xml.XmlNode newParent, string oldValue, string newValue, System.Xml.XmlNodeChangedAction action);
            /*0x7765c80*/ System.Xml.XmlNodeChangedEventArgs GetInsertEventArgsForLoad(System.Xml.XmlNode node, System.Xml.XmlNode newParent);
            /*0x776eabc*/ void BeforeEvent(System.Xml.XmlNodeChangedEventArgs args);
            /*0x776eb10*/ void AfterEvent(System.Xml.XmlNodeChangedEventArgs args);
            /*0x77690b4*/ System.Xml.XmlAttribute GetDefaultAttribute(System.Xml.XmlElement elem, string attrPrefix, string attrLocalname, string attrNamespaceURI);
            /*0x776eb64*/ string get_Version();
            /*0x776eb88*/ string get_Encoding();
            /*0x776e594*/ string get_Standalone();
            /*0x776ebac*/ System.Xml.XmlEntity GetEntityNode(string name);
            /*0x776ecf4*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x776ee38*/ string get_BaseURI();
            /*0x776ee40*/ void SetBaseURI(string inBaseURI);
            /*0x776ee50*/ System.Xml.XmlNode AppendChildForLoad(System.Xml.XmlNode newChild, System.Xml.XmlDocument doc);
            /*0x776f048*/ System.Xml.XPath.XPathNodeType get_XPNodeType();
            /*0x776f050*/ bool get_HasEntityReferences();
            /*0x7763578*/ System.Xml.XmlAttribute get_NamespaceXml();
        }

        class XmlDocumentFragment : System.Xml.XmlNode
        {
            /*0x18*/ System.Xml.XmlLinkedNode lastChild;

            /*0x776c4f0*/ XmlDocumentFragment(System.Xml.XmlDocument ownerDocument);
            /*0x776f174*/ string get_Name();
            /*0x776f19c*/ string get_LocalName();
            /*0x776f1c4*/ System.Xml.XmlNodeType get_NodeType();
            /*0x776f1cc*/ System.Xml.XmlNode get_ParentNode();
            /*0x776f1d4*/ System.Xml.XmlDocument get_OwnerDocument();
            /*0x776f24c*/ void set_InnerXml(string value);
            /*0x776f4f8*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x776f57c*/ bool get_IsContainer();
            /*0x776f584*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x776f58c*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x776f594*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x776f600*/ bool CanInsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x776f670*/ bool CanInsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x776f6d8*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x776f6e8*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x776f9b4*/ System.Xml.XPath.XPathNodeType get_XPNodeType();
        }

        class XmlDocumentType : System.Xml.XmlLinkedNode
        {
            /*0x20*/ string name;
            /*0x28*/ string publicId;
            /*0x30*/ string systemId;
            /*0x38*/ string internalSubset;
            /*0x40*/ bool namespaces;
            /*0x48*/ System.Xml.XmlNamedNodeMap entities;
            /*0x50*/ System.Xml.XmlNamedNodeMap notations;
            /*0x58*/ System.Xml.Schema.SchemaInfo schemaInfo;

            /*0x776c390*/ XmlDocumentType(string name, string publicId, string systemId, string internalSubset, System.Xml.XmlDocument doc);
            /*0x776fa24*/ string get_Name();
            /*0x776fa2c*/ string get_LocalName();
            /*0x776fa34*/ System.Xml.XmlNodeType get_NodeType();
            /*0x776fa3c*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x776fa78*/ bool get_IsReadOnly();
            /*0x776ec70*/ System.Xml.XmlNamedNodeMap get_Entities();
            /*0x776fa80*/ System.Xml.XmlNamedNodeMap get_Notations();
            /*0x776fb04*/ string get_PublicId();
            /*0x776fb0c*/ string get_SystemId();
            /*0x776fb14*/ string get_InternalSubset();
            /*0x776fb1c*/ bool get_ParseWithNamespaces();
            /*0x776fb24*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x776fb50*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x776fb54*/ System.Xml.Schema.SchemaInfo get_DtdSchemaInfo();
            /*0x776fb5c*/ void set_DtdSchemaInfo(System.Xml.Schema.SchemaInfo value);
        }

        class XmlElement : System.Xml.XmlLinkedNode
        {
            /*0x20*/ System.Xml.XmlName name;
            /*0x28*/ System.Xml.XmlAttributeCollection attributes;
            /*0x30*/ System.Xml.XmlLinkedNode lastChild;

            static /*0x7770be4*/ void WriteElementTo(System.Xml.XmlWriter writer, System.Xml.XmlElement e);
            /*0x776d9fc*/ XmlElement(System.Xml.XmlName name, bool empty, System.Xml.XmlDocument doc);
            /*0x776fb64*/ XmlElement(string prefix, string localName, string namespaceURI, System.Xml.XmlDocument doc);
            /*0x776fba8*/ System.Xml.XmlName get_XmlName();
            /*0x776fbb0*/ void set_XmlName(System.Xml.XmlName value);
            /*0x776fbb8*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x777016c*/ string get_Name();
            /*0x7770184*/ string get_LocalName();
            /*0x77701a0*/ string get_NamespaceURI();
            /*0x77701bc*/ string get_Prefix();
            /*0x77701d8*/ void set_Prefix(string value);
            /*0x7770284*/ System.Xml.XmlNodeType get_NodeType();
            /*0x777028c*/ System.Xml.XmlNode get_ParentNode();
            /*0x7770294*/ System.Xml.XmlDocument get_OwnerDocument();
            /*0x77702b0*/ bool get_IsContainer();
            /*0x77702b8*/ System.Xml.XmlNode AppendChildForLoad(System.Xml.XmlNode newChild, System.Xml.XmlDocument doc);
            /*0x77700f8*/ bool get_IsEmpty();
            /*0x7770108*/ void set_IsEmpty(bool value);
            /*0x7770474*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x7770484*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x777048c*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x77704b0*/ System.Xml.XmlAttributeCollection get_Attributes();
            /*0x77705fc*/ bool get_HasAttributes();
            /*0x7770624*/ string GetAttribute(string name);
            /*0x7770668*/ void SetAttribute(string name, string value);
            /*0x777070c*/ System.Xml.XmlAttribute GetAttributeNode(string name);
            /*0x7770770*/ System.Xml.XmlAttribute SetAttributeNode(System.Xml.XmlAttribute newAttr);
            /*0x7770880*/ string GetAttribute(string localName, string namespaceURI);
            /*0x77708c4*/ string SetAttribute(string localName, string namespaceURI, string value);
            /*0x777099c*/ System.Xml.XmlAttribute GetAttributeNode(string localName, string namespaceURI);
            /*0x7770a08*/ System.Xml.XmlAttribute SetAttributeNode(string localName, string namespaceURI);
            /*0x7770ab8*/ bool HasAttribute(string name);
            /*0x7770adc*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x7770dc0*/ void WriteStartElement(System.Xml.XmlWriter w);
            /*0x7770ed8*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x7770f40*/ void RemoveAllAttributes();
            /*0x7770f78*/ void RemoveAll();
            /*0x7770470*/ void RemoveAllChildren();
            /*0x7771004*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x777100c*/ void set_InnerXml(string value);
            /*0x77710fc*/ string get_InnerText();
            /*0x7771100*/ void set_InnerText(string value);
            /*0x77711b8*/ System.Xml.XmlNode get_NextSibling();
            /*0x77711f4*/ void SetParent(System.Xml.XmlNode node);
            /*0x77711fc*/ System.Xml.XPath.XPathNodeType get_XPNodeType();
            /*0x7771204*/ string get_XPLocalName();
        }

        class XmlEntity : System.Xml.XmlNode
        {
            /*0x18*/ string publicId;
            /*0x20*/ string systemId;
            /*0x28*/ string notationName;
            /*0x30*/ string name;
            /*0x38*/ string unparsedReplacementStr;
            /*0x40*/ string baseURI;
            /*0x48*/ System.Xml.XmlLinkedNode lastChild;
            /*0x50*/ bool childrenFoliating;

            /*0x7771214*/ XmlEntity(string name, string strdata, string publicId, string systemId, string notationName, System.Xml.XmlDocument doc);
            /*0x77712d8*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x7771330*/ bool get_IsReadOnly();
            /*0x7771338*/ string get_Name();
            /*0x7771340*/ string get_LocalName();
            /*0x7771348*/ string get_InnerText();
            /*0x777134c*/ void set_InnerText(string value);
            /*0x77713a4*/ bool get_IsContainer();
            /*0x77713ac*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x7771484*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x777148c*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x77714b0*/ System.Xml.XmlNodeType get_NodeType();
            /*0x77714b8*/ string get_SystemId();
            /*0x77714c0*/ void set_InnerXml(string value);
            /*0x7771518*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x777151c*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x7771520*/ string get_BaseURI();
            /*0x7771528*/ void SetBaseURI(string inBaseURI);
        }

        class XmlEntityReference : System.Xml.XmlLinkedNode
        {
            /*0x20*/ string name;
            /*0x28*/ System.Xml.XmlLinkedNode lastChild;

            /*0x776cae4*/ XmlEntityReference(string name, System.Xml.XmlDocument doc);
            /*0x7771530*/ string get_Name();
            /*0x7771538*/ string get_LocalName();
            /*0x7771540*/ string get_Value();
            /*0x7771548*/ void set_Value(string value);
            /*0x77715a0*/ System.Xml.XmlNodeType get_NodeType();
            /*0x77715a8*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x77715e0*/ bool get_IsReadOnly();
            /*0x77715e8*/ bool get_IsContainer();
            /*0x77715f0*/ void SetParent(System.Xml.XmlNode node);
            /*0x7771d00*/ void SetParentForLoad(System.Xml.XmlNode node);
            /*0x7771d10*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x7771d18*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x7771d20*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x7771d44*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x7771d70*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x777203c*/ string get_BaseURI();
            /*0x777206c*/ string ConstructBaseURI(string baseURI, string systemId);
            /*0x7772140*/ string get_ChildBaseURI();
        }

        enum XmlNodeChangedAction
        {
            Insert = 0,
            Remove = 1,
            Change = 2,
        }

        class XmlImplementation
        {
            /*0x10*/ System.Xml.XmlNameTable nameTable;

            /*0x776a9b8*/ XmlImplementation();
            /*0x776af3c*/ XmlImplementation(System.Xml.XmlNameTable nt);
            /*0x77721dc*/ System.Xml.XmlDocument CreateDocument();
            /*0x7772234*/ System.Xml.XmlNameTable get_NameTable();
        }

        class XmlLinkedNode : System.Xml.XmlNode
        {
            /*0x18*/ System.Xml.XmlLinkedNode next;

            /*0x77698a0*/ XmlLinkedNode(System.Xml.XmlDocument doc);
            /*0x777223c*/ System.Xml.XmlNode get_PreviousSibling();
            /*0x77722a4*/ System.Xml.XmlNode get_NextSibling();
        }

        class XmlLoader
        {
            /*0x10*/ System.Xml.XmlDocument doc;
            /*0x18*/ System.Xml.XmlReader reader;
            /*0x20*/ bool preserveWhitespace;

            static /*0x776a610*/ void ParseXmlDeclarationValue(string strValue, ref string version, ref string encoding, ref string standalone);
            static /*0x7773124*/ System.Exception UnexpectedNodeType(System.Xml.XmlNodeType nodetype);
            /*0x776755c*/ XmlLoader();
            /*0x776df84*/ void Load(System.Xml.XmlDocument doc, System.Xml.XmlReader reader, bool preserveWhitespace);
            /*0x77722f4*/ void LoadDocSequence(System.Xml.XmlDocument parentDoc);
            /*0x776dcd4*/ System.Xml.XmlNode ReadCurrentNode(System.Xml.XmlDocument doc, System.Xml.XmlReader reader);
            /*0x7772360*/ System.Xml.XmlNode LoadNode(bool skipOverWhitespace);
            /*0x77728e4*/ System.Xml.XmlAttribute LoadAttributeNode();
            /*0x7773234*/ System.Xml.XmlAttribute LoadDefaultAttribute();
            /*0x77733d0*/ void LoadAttributeValue(System.Xml.XmlNode parent, bool direct);
            /*0x7772bf8*/ System.Xml.XmlEntityReference LoadEntityReferenceNode(bool direct);
            /*0x7772dd4*/ System.Xml.XmlDeclaration LoadDeclarationNode();
            /*0x7772f78*/ System.Xml.XmlDocumentType LoadDocumentTypeNode();
            /*0x77736d0*/ System.Xml.XmlNode LoadNodeDirect();
            /*0x7774654*/ System.Xml.XmlAttribute LoadAttributeNodeDirect();
            /*0x776f9bc*/ void ParseDocumentType(System.Xml.XmlDocumentType dtNode);
            /*0x7774794*/ void ParseDocumentType(System.Xml.XmlDocumentType dtNode, bool bUseResolver, System.Xml.XmlResolver resolver);
            /*0x7773b0c*/ void LoadDocumentType(System.Xml.IDtdInfo dtdInfo, System.Xml.XmlDocumentType dtNode);
            /*0x7774a60*/ System.Xml.XmlParserContext GetContext(System.Xml.XmlNode node);
            /*0x776f2d8*/ System.Xml.XmlNamespaceManager ParsePartialContent(System.Xml.XmlNode parentNode, string innerxmltext, System.Xml.XmlNodeType nt);
            /*0x7771088*/ void LoadInnerXmlElement(System.Xml.XmlElement node, string innerxmltext);
            /*0x7767564*/ void LoadInnerXmlAttribute(System.Xml.XmlAttribute node, string innerxmltext);
            /*0x77755c4*/ void RemoveDuplicateNamespace(System.Xml.XmlElement elem, System.Xml.XmlNamespaceManager mgr, bool fCheckElemAttrs);
            /*0x7775864*/ string EntitizeName(string name);
            /*0x7771438*/ void ExpandEntity(System.Xml.XmlEntity ent);
            /*0x77716e4*/ void ExpandEntityReference(System.Xml.XmlEntityReference eref);
            /*0x777533c*/ System.Xml.XmlReader CreateInnerXmlReader(string xmlFragment, System.Xml.XmlNodeType nt, System.Xml.XmlParserContext context, System.Xml.XmlDocument doc);
        }

        class XmlName : System.Xml.Schema.IXmlSchemaInfo
        {
            /*0x10*/ string prefix;
            /*0x18*/ string localName;
            /*0x20*/ string ns;
            /*0x28*/ string name;
            /*0x30*/ int hashCode;
            /*0x38*/ System.Xml.XmlDocument ownerDoc;
            /*0x40*/ System.Xml.XmlName next;

            static /*0x7764b98*/ System.Xml.XmlName Create(string prefix, string localName, string ns, int hashCode, System.Xml.XmlDocument ownerDoc, System.Xml.XmlName next, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            static /*0x77648f0*/ int GetHashCode(string name);
            /*0x77758d0*/ XmlName(string prefix, string localName, string ns, int hashCode, System.Xml.XmlDocument ownerDoc, System.Xml.XmlName next);
            /*0x7775d78*/ string get_LocalName();
            /*0x7775d80*/ string get_NamespaceURI();
            /*0x7775d88*/ string get_Prefix();
            /*0x7775d90*/ int get_HashCode();
            /*0x7775d98*/ System.Xml.XmlDocument get_OwnerDocument();
            /*0x77652b0*/ string get_Name();
            /*0x7775da0*/ System.Xml.Schema.XmlSchemaValidity get_Validity();
            /*0x7775da8*/ bool get_IsDefault();
            /*0x7775db0*/ bool get_IsNil();
            /*0x7775db8*/ System.Xml.Schema.XmlSchemaSimpleType get_MemberType();
            /*0x7775dc0*/ System.Xml.Schema.XmlSchemaType get_SchemaType();
            /*0x7775dc8*/ System.Xml.Schema.XmlSchemaElement get_SchemaElement();
            /*0x7775dd0*/ System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute();
            /*0x7775dd8*/ bool Equals(System.Xml.Schema.IXmlSchemaInfo schemaInfo);
        }

        class XmlNameEx : System.Xml.XmlName
        {
            /*0x48*/ byte flags;
            /*0x50*/ System.Xml.Schema.XmlSchemaSimpleType memberType;
            /*0x58*/ System.Xml.Schema.XmlSchemaType schemaType;
            /*0x60*/ object decl;

            /*0x7775978*/ XmlNameEx(string prefix, string localName, string ns, int hashCode, System.Xml.XmlDocument ownerDoc, System.Xml.XmlName next, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            /*0x7775e38*/ System.Xml.Schema.XmlSchemaValidity get_Validity();
            /*0x7775e68*/ bool get_IsDefault();
            /*0x7775e74*/ bool get_IsNil();
            /*0x7775e80*/ System.Xml.Schema.XmlSchemaSimpleType get_MemberType();
            /*0x7775e88*/ System.Xml.Schema.XmlSchemaType get_SchemaType();
            /*0x7775e90*/ System.Xml.Schema.XmlSchemaElement get_SchemaElement();
            /*0x7775f0c*/ System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute();
            /*0x7775de4*/ void SetValidity(System.Xml.Schema.XmlSchemaValidity value);
            /*0x7775df8*/ void SetIsDefault(bool value);
            /*0x7775e18*/ void SetIsNil(bool value);
            /*0x7775f88*/ bool Equals(System.Xml.Schema.IXmlSchemaInfo schemaInfo);
        }

        class XmlNamedNodeMap : System.Collections.IEnumerable
        {
            /*0x10*/ System.Xml.XmlNode parent;
            /*0x18*/ System.Xml.XmlNamedNodeMap.SmallXmlNodeList nodes;

            /*0x7767894*/ XmlNamedNodeMap(System.Xml.XmlNode parent);
            /*0x7776364*/ System.Xml.XmlNode GetNamedItem(string name);
            /*0x77764e0*/ System.Xml.XmlNode SetNamedItem(System.Xml.XmlNode node);
            /*0x7768828*/ int get_Count();
            /*0x77765f0*/ System.Collections.IEnumerator GetEnumerator();
            /*0x77763fc*/ int FindNodeOffset(string name);
            /*0x7767fa8*/ int FindNodeOffset(string localName, string namespaceURI);
            /*0x77689fc*/ System.Xml.XmlNode AddNode(System.Xml.XmlNode node);
            /*0x7768424*/ System.Xml.XmlNode AddNodeForLoad(System.Xml.XmlNode node, System.Xml.XmlDocument doc);
            /*0x7768164*/ System.Xml.XmlNode RemoveNodeAt(int i);
            /*0x777659c*/ System.Xml.XmlNode ReplaceNodeAt(int i, System.Xml.XmlNode node);
            /*0x7768c28*/ System.Xml.XmlNode InsertNodeAt(int i, System.Xml.XmlNode node);

            struct SmallXmlNodeList
            {
                /*0x10*/ object field;

                /*0x7767ab8*/ int get_Count();
                /*0x77678c4*/ object get_Item(int index);
                /*0x77766fc*/ void Add(object value);
                /*0x7776828*/ void RemoveAt(int index);
                /*0x7776910*/ void Insert(int index, object value);
                /*0x77765f8*/ System.Collections.IEnumerator GetEnumerator();

                class SingleObjectEnumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ object loneValue;
                    /*0x18*/ int position;

                    /*0x7776ab8*/ SingleObjectEnumerator(object value);
                    /*0x7776af0*/ object get_Current();
                    /*0x7776b3c*/ bool MoveNext();
                    /*0x7776b58*/ void Reset();
                }
            }
        }

        class XmlNode : System.ICloneable, System.Collections.IEnumerable
        {
            /*0x10*/ System.Xml.XmlNode parentNode;

            static /*0x77772cc*/ bool HasReadOnlyParent(System.Xml.XmlNode n);
            static /*0x776c0c0*/ void SplitName(string name, ref string prefix, ref string localName);
            static /*0x7765d34*/ void NestTextNodes(System.Xml.XmlNode prevNode, System.Xml.XmlNode nextNode);
            static /*0x7776f9c*/ void UnnestTextNodes(System.Xml.XmlNode prevNode, System.Xml.XmlNode nextNode);
            /*0x776af6c*/ XmlNode();
            /*0x7764ef4*/ XmlNode(System.Xml.XmlDocument doc);
            /*0x7776b64*/ System.Xml.XPath.XPathNavigator CreateNavigator();
            /*0x38148bc*/ string get_Name();
            /*0x7776c08*/ string get_Value();
            /*0x7776c10*/ void set_Value(string value);
            /*0x3814574*/ System.Xml.XmlNodeType get_NodeType();
            /*0x7776cdc*/ System.Xml.XmlNode get_ParentNode();
            /*0x7776dc0*/ System.Xml.XmlNodeList get_ChildNodes();
            /*0x7776e28*/ System.Xml.XmlNode get_PreviousSibling();
            /*0x7776e30*/ System.Xml.XmlNode get_NextSibling();
            /*0x7776e38*/ System.Xml.XmlAttributeCollection get_Attributes();
            /*0x7776e40*/ System.Xml.XmlDocument get_OwnerDocument();
            /*0x7776ef8*/ System.Xml.XmlNode get_FirstChild();
            /*0x7776f1c*/ System.Xml.XmlNode get_LastChild();
            /*0x7776f2c*/ bool get_IsContainer();
            /*0x7776f34*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x7776f3c*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x7776f40*/ bool AncestorNode(System.Xml.XmlNode node);
            /*0x7765e10*/ System.Xml.XmlNode InsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x776644c*/ System.Xml.XmlNode InsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x7766a38*/ System.Xml.XmlNode RemoveChild(System.Xml.XmlNode oldChild);
            /*0x7766ec4*/ System.Xml.XmlNode PrependChild(System.Xml.XmlNode newChild);
            /*0x7766f7c*/ System.Xml.XmlNode AppendChild(System.Xml.XmlNode newChild);
            /*0x7776fd0*/ System.Xml.XmlNode AppendChildForLoad(System.Xml.XmlNode newChild, System.Xml.XmlDocument doc);
            /*0x7777198*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x77771a0*/ bool CanInsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x77771a8*/ bool CanInsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x77771b0*/ bool get_HasChildNodes();
            System.Xml.XmlNode CloneNode(bool deep);
            /*0x77771d4*/ void CopyChildren(System.Xml.XmlDocument doc, System.Xml.XmlNode container, bool deep);
            /*0x7777274*/ string get_NamespaceURI();
            /*0x777728c*/ string get_Prefix();
            /*0x77772a4*/ void set_Prefix(string value);
            /*0x38148bc*/ string get_LocalName();
            /*0x77772a8*/ bool get_IsReadOnly();
            /*0x7777398*/ object System.ICloneable.Clone();
            /*0x77773ac*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x776e894*/ System.Collections.IEnumerator GetEnumerator();
            /*0x7777404*/ void AppendChildText(System.Text.StringBuilder builder);
            /*0x77656d4*/ string get_InnerText();
            /*0x77657d0*/ void set_InnerText(string value);
            /*0x7777508*/ void set_InnerXml(string value);
            /*0x7777560*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x77775b8*/ string get_BaseURI();
            /*0x3816710*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x3816710*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x7770f9c*/ void RemoveAll();
            /*0x77776d0*/ System.Xml.XmlDocument get_Document();
            /*0x777777c*/ string GetPrefixOfNamespace(string namespaceURI);
            /*0x77777a4*/ string GetPrefixOfNamespaceStrict(string namespaceURI);
            /*0x77716a8*/ void SetParent(System.Xml.XmlNode node);
            /*0x7777b0c*/ void SetParentForLoad(System.Xml.XmlNode node);
            /*0x7777b14*/ System.Xml.XmlNode FindChild(System.Xml.XmlNodeType type);
            /*0x7777b78*/ System.Xml.XmlNodeChangedEventArgs GetEventArgs(System.Xml.XmlNode node, System.Xml.XmlNode oldParent, System.Xml.XmlNode newParent, string oldValue, string newValue, System.Xml.XmlNodeChangedAction action);
            /*0x7777c9c*/ void BeforeEvent(System.Xml.XmlNodeChangedEventArgs args);
            /*0x7777ce0*/ void AfterEvent(System.Xml.XmlNodeChangedEventArgs args);
            /*0x7777d24*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x7777e9c*/ string get_XmlLang();
            /*0x7777f88*/ System.Xml.XPath.XPathNodeType get_XPNodeType();
            /*0x7777f90*/ string get_XPLocalName();
            /*0x7777fa8*/ bool get_IsText();
            /*0x7777fb0*/ System.Xml.XmlNode get_PreviousText();
        }

        class XmlNodeChangedEventArgs : System.EventArgs
        {
            /*0x10*/ System.Xml.XmlNodeChangedAction action;
            /*0x18*/ System.Xml.XmlNode node;
            /*0x20*/ System.Xml.XmlNode oldParent;
            /*0x28*/ System.Xml.XmlNode newParent;
            /*0x30*/ string oldValue;
            /*0x38*/ string newValue;

            /*0x776e9e0*/ XmlNodeChangedEventArgs(System.Xml.XmlNode node, System.Xml.XmlNode oldParent, System.Xml.XmlNode newParent, string oldValue, string newValue, System.Xml.XmlNodeChangedAction action);
            /*0x7777fb8*/ System.Xml.XmlNodeChangedAction get_Action();
        }

        class XmlNodeChangedEventHandler : System.MulticastDelegate
        {
            /*0x7777fc0*/ XmlNodeChangedEventHandler(object object, nint method);
            /*0x77780cc*/ void Invoke(object sender, System.Xml.XmlNodeChangedEventArgs e);
        }

        class XmlNodeList : System.Collections.IEnumerable, System.IDisposable
        {
            /*0x7769cd4*/ XmlNodeList();
            /*0x3814964*/ System.Xml.XmlNode Item(int index);
            /*0x3814574*/ int get_Count();
            /*0x38148bc*/ System.Collections.IEnumerator GetEnumerator();
            /*0x77780e0*/ System.Xml.XmlNode get_ItemOf(int i);
            /*0x77780ec*/ void System.IDisposable.Dispose();
            /*0x77780f8*/ void PrivateDisposeNodeList();
        }

        class XmlNodeReaderNavigator
        {
            /*0x10*/ System.Xml.XmlNode curNode;
            /*0x18*/ System.Xml.XmlNode elemNode;
            /*0x20*/ System.Xml.XmlNode logNode;
            /*0x28*/ int attrIndex;
            /*0x2c*/ int logAttrIndex;
            /*0x30*/ System.Xml.XmlNameTable nameTable;
            /*0x38*/ System.Xml.XmlDocument doc;
            /*0x40*/ int nAttrInd;
            /*0x44*/ int nDeclarationAttrCount;
            /*0x48*/ int nDocTypeAttrCount;
            /*0x4c*/ int nLogLevel;
            /*0x50*/ int nLogAttrInd;
            /*0x54*/ bool bLogOnAttrVal;
            /*0x55*/ bool bCreatedOnAttribute;
            /*0x58*/ System.Xml.XmlNodeReaderNavigator.VirtualAttribute[] decNodeAttributes;
            /*0x60*/ System.Xml.XmlNodeReaderNavigator.VirtualAttribute[] docTypeNodeAttributes;
            /*0x68*/ bool bOnAttrVal;

            /*0x77780fc*/ XmlNodeReaderNavigator(System.Xml.XmlNode node);
            /*0x7778438*/ System.Xml.XmlNodeType get_NodeType();
            /*0x777847c*/ string get_NamespaceURI();
            /*0x77784a0*/ string get_Name();
            /*0x7778588*/ string get_LocalName();
            /*0x7778604*/ bool get_CreatedOnAttribute();
            /*0x7778564*/ bool IsLocalNameEmpty(System.Xml.XmlNodeType nt);
            /*0x777860c*/ string get_Prefix();
            /*0x7778630*/ string get_Value();
            /*0x7778a94*/ string get_BaseURI();
            /*0x7778ab8*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x7778adc*/ string get_XmlLang();
            /*0x7778b00*/ bool get_IsEmptyElement();
            /*0x7778bac*/ bool get_IsDefault();
            /*0x7778c60*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x7778c84*/ System.Xml.XmlNameTable get_NameTable();
            /*0x7778c8c*/ int get_AttributeCount();
            /*0x7778efc*/ void CheckIndexCondition(int attributeIndex);
            /*0x77788a4*/ void InitDecAttr();
            /*0x7778f64*/ string GetDeclarationAttr(System.Xml.XmlDeclaration decl, string name);
            /*0x7779044*/ string GetDeclarationAttr(int i);
            /*0x7779098*/ int GetDecAttrInd(string name);
            /*0x7778dc8*/ void InitDocTypeAttr();
            /*0x7779130*/ string GetDocumentTypeAttr(System.Xml.XmlDocumentType docType, string name);
            /*0x77791dc*/ string GetDocumentTypeAttr(int i);
            /*0x7779230*/ int GetDocTypeAttrInd(string name);
            /*0x77792c8*/ string GetAttributeFromElement(System.Xml.XmlElement elem, string name);
            /*0x777930c*/ string GetAttribute(string name);
            /*0x77794a8*/ string GetAttributeFromElement(System.Xml.XmlElement elem, string name, string ns);
            /*0x77794f0*/ string GetAttribute(string name, string ns);
            /*0x77796c0*/ string GetAttribute(int attributeIndex);
            /*0x7779864*/ void LogMove(int level);
            /*0x77798a8*/ void RollBackMove(ref int level);
            /*0x77798f4*/ bool get_IsOnDeclOrDocType();
            /*0x777992c*/ void ResetToAttribute(ref int level);
            /*0x77799e0*/ void ResetMove(ref int level, ref System.Xml.XmlNodeType nt);
            /*0x7779bc0*/ bool MoveToAttribute(string name);
            /*0x7779d30*/ bool MoveToAttributeFromElement(System.Xml.XmlElement elem, string name, string ns);
            /*0x7779bd8*/ bool MoveToAttribute(string name, string namespaceURI);
            /*0x7779e00*/ void MoveToAttribute(int attributeIndex);
            /*0x7779fb8*/ bool MoveToNextAttribute(ref int level);
            /*0x777a19c*/ bool MoveToParent();
            /*0x777a1f4*/ bool MoveToFirstChild();
            /*0x777a254*/ bool MoveToNextSibling(System.Xml.XmlNode node);
            /*0x777a2b8*/ bool MoveToNext();
            /*0x777a2f8*/ bool MoveToElement();
            /*0x777a38c*/ string LookupNamespace(string prefix);
            /*0x777a624*/ string DefaultLookupNamespace(string prefix);
            /*0x777a750*/ string LookupPrefix(string namespaceName);
            /*0x777ab08*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x777afcc*/ bool ReadAttributeValue(ref int level, ref bool bResolveEntity, ref System.Xml.XmlNodeType nt);
            /*0x777b1d4*/ System.Xml.XmlDocument get_Document();

            struct VirtualAttribute
            {
                /*0x10*/ string name;
                /*0x18*/ string value;

                /*0x777b1e4*/ VirtualAttribute(string name, string value);
            }
        }

        class XmlNodeReader : System.Xml.XmlReader, System.Xml.IXmlNamespaceResolver
        {
            /*0x10*/ System.Xml.XmlNodeReaderNavigator readerNav;
            /*0x18*/ System.Xml.XmlNodeType nodeType;
            /*0x1c*/ int curDepth;
            /*0x20*/ System.Xml.ReadState readState;
            /*0x24*/ bool fEOF;
            /*0x25*/ bool bResolveEntity;
            /*0x26*/ bool bStartFromDocument;
            /*0x27*/ bool bInReadBinary;
            /*0x28*/ System.Xml.ReadContentAsBinaryHelper readBinaryHelper;

            /*0x777b214*/ XmlNodeReader(System.Xml.XmlNode node);
            /*0x777b30c*/ bool IsInReadingStates();
            /*0x777b31c*/ System.Xml.XmlNodeType get_NodeType();
            /*0x777b338*/ string get_Name();
            /*0x777b37c*/ string get_LocalName();
            /*0x777b3c0*/ string get_NamespaceURI();
            /*0x777b404*/ string get_Prefix();
            /*0x777b448*/ string get_Value();
            /*0x777b48c*/ int get_Depth();
            /*0x777b494*/ string get_BaseURI();
            /*0x777b4b0*/ bool get_CanResolveEntity();
            /*0x777b4b8*/ bool get_IsEmptyElement();
            /*0x777b4ec*/ bool get_IsDefault();
            /*0x777b520*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x777b554*/ string get_XmlLang();
            /*0x777b598*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x777b5cc*/ int get_AttributeCount();
            /*0x777b60c*/ string GetAttribute(string name);
            /*0x777b640*/ string GetAttribute(string name, string namespaceURI);
            /*0x777b68c*/ string GetAttribute(int attributeIndex);
            /*0x777b6fc*/ bool MoveToAttribute(string name);
            /*0x777b7d0*/ bool MoveToAttribute(string name, string namespaceURI);
            /*0x777b8a8*/ void MoveToAttribute(int attributeIndex);
            /*0x777ba90*/ bool MoveToFirstAttribute();
            /*0x777bb54*/ bool MoveToNextAttribute();
            /*0x777bc10*/ bool MoveToElement();
            /*0x777bcc8*/ bool Read();
            /*0x777bcd0*/ bool Read(bool fSkipChildren);
            /*0x777bde0*/ bool ReadNextNode(bool fSkipChildren);
            /*0x777c0d4*/ void SetEndOfFile();
            /*0x777c0ec*/ bool ReadAtZeroLevel(bool fSkipChildren);
            /*0x777bfdc*/ bool ReadForward(bool fSkipChildren);
            /*0x777bfb4*/ void ReSetReadingMarks();
            /*0x777c164*/ bool get_EOF();
            /*0x777c188*/ void Close();
            /*0x777c194*/ System.Xml.ReadState get_ReadState();
            /*0x777c19c*/ void Skip();
            /*0x777c1a4*/ string ReadString();
            /*0x777c248*/ bool get_HasAttributes();
            /*0x777c26c*/ System.Xml.XmlNameTable get_NameTable();
            /*0x777c288*/ string LookupNamespace(string prefix);
            /*0x777c2c4*/ void ResolveEntity();
            /*0x777c348*/ bool ReadAttributeValue();
            /*0x777c398*/ int ReadContentAsBase64(byte[] buffer, int index, int count);
            /*0x777c430*/ int ReadContentAsBinHex(byte[] buffer, int index, int count);
            /*0x777b7ac*/ void FinishReadBinary();
            /*0x777c4c8*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x777c4e4*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            /*0x777c500*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0x777c564*/ System.Xml.IDtdInfo get_DtdInfo();
        }

        class XmlNotation : System.Xml.XmlNode
        {
            /*0x18*/ string publicId;
            /*0x20*/ string systemId;
            /*0x28*/ string name;

            /*0x777c588*/ XmlNotation(string name, string publicId, string systemId, System.Xml.XmlDocument doc);
            /*0x777c618*/ string get_Name();
            /*0x777c620*/ string get_LocalName();
            /*0x777c628*/ System.Xml.XmlNodeType get_NodeType();
            /*0x777c630*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x777c688*/ bool get_IsReadOnly();
            /*0x777c690*/ void set_InnerXml(string value);
            /*0x777c6e8*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x777c6ec*/ void WriteContentTo(System.Xml.XmlWriter w);
        }

        class XmlProcessingInstruction : System.Xml.XmlLinkedNode
        {
            /*0x20*/ string target;
            /*0x28*/ string data;

            /*0x777c6f0*/ XmlProcessingInstruction(string target, string data, System.Xml.XmlDocument doc);
            /*0x777c738*/ string get_Name();
            /*0x777c75c*/ string get_LocalName();
            /*0x777c768*/ string get_Value();
            /*0x777c770*/ void set_Value(string value);
            /*0x777c774*/ void set_Data(string value);
            /*0x777c838*/ string get_InnerText();
            /*0x777c840*/ void set_InnerText(string value);
            /*0x777c844*/ System.Xml.XmlNodeType get_NodeType();
            /*0x777c84c*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x777c884*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x777c8b0*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x777c8b4*/ string get_XPLocalName();
            /*0x777c8c0*/ System.Xml.XPath.XPathNodeType get_XPNodeType();
        }

        class XmlSignificantWhitespace : System.Xml.XmlCharacterData
        {
            /*0x777c8c8*/ XmlSignificantWhitespace(string strData, System.Xml.XmlDocument doc);
            /*0x777c964*/ string get_Name();
            /*0x777c98c*/ string get_LocalName();
            /*0x777c9b4*/ System.Xml.XmlNodeType get_NodeType();
            /*0x777c9bc*/ System.Xml.XmlNode get_ParentNode();
            /*0x777ca48*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x777caa4*/ string get_Value();
            /*0x777cab4*/ void set_Value(string value);
            /*0x777cb40*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x777cb80*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x777cb84*/ System.Xml.XPath.XPathNodeType get_XPNodeType();
            /*0x777cbac*/ bool get_IsText();
            /*0x777cbb4*/ System.Xml.XmlNode get_PreviousText();
        }

        class XmlText : System.Xml.XmlCharacterData
        {
            /*0x777cbf0*/ XmlText(string strData);
            /*0x777cbfc*/ XmlText(string strData, System.Xml.XmlDocument doc);
            /*0x777cc04*/ string get_Name();
            /*0x777cc2c*/ string get_LocalName();
            /*0x777cc54*/ System.Xml.XmlNodeType get_NodeType();
            /*0x777cc5c*/ System.Xml.XmlNode get_ParentNode();
            /*0x777cce0*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x777cd3c*/ string get_Value();
            /*0x777cd4c*/ void set_Value(string value);
            /*0x777ce10*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x777ce50*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x777ce54*/ System.Xml.XPath.XPathNodeType get_XPNodeType();
            /*0x777ce5c*/ bool get_IsText();
            /*0x777ce64*/ System.Xml.XmlNode get_PreviousText();
        }

        class XmlUnspecifiedAttribute : System.Xml.XmlAttribute
        {
            /*0x28*/ bool fSpecified;

            /*0x777cea0*/ XmlUnspecifiedAttribute(string prefix, string localName, string namespaceURI, System.Xml.XmlDocument doc);
            /*0x777cea8*/ bool get_Specified();
            /*0x777ceb0*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x777cfe0*/ void set_InnerText(string value);
            /*0x777d000*/ System.Xml.XmlNode InsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x777d020*/ System.Xml.XmlNode InsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x777d040*/ System.Xml.XmlNode RemoveChild(System.Xml.XmlNode oldChild);
            /*0x777d060*/ System.Xml.XmlNode AppendChild(System.Xml.XmlNode newChild);
            /*0x777d080*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x777d094*/ void SetSpecified(bool f);
        }

        class XmlWhitespace : System.Xml.XmlCharacterData
        {
            /*0x777d0a0*/ XmlWhitespace(string strData, System.Xml.XmlDocument doc);
            /*0x777d13c*/ string get_Name();
            /*0x777d164*/ string get_LocalName();
            /*0x777d18c*/ System.Xml.XmlNodeType get_NodeType();
            /*0x777d194*/ System.Xml.XmlNode get_ParentNode();
            /*0x777d220*/ string get_Value();
            /*0x777d230*/ void set_Value(string value);
            /*0x777d2bc*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x777d318*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x777d358*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x777d35c*/ System.Xml.XPath.XPathNodeType get_XPNodeType();
            /*0x777d384*/ bool get_IsText();
            /*0x777d38c*/ System.Xml.XmlNode get_PreviousText();
        }

        class EmptyEnumerator : System.Collections.IEnumerator
        {
            /*0x777d42c*/ EmptyEnumerator();
            /*0x777d3c8*/ bool System.Collections.IEnumerator.MoveNext();
            /*0x777d3d0*/ void System.Collections.IEnumerator.Reset();
            /*0x777d3d4*/ object System.Collections.IEnumerator.get_Current();
        }

        class HWStack : System.ICloneable
        {
            /*0x10*/ object[] stack;
            /*0x18*/ int growthRate;
            /*0x1c*/ int used;
            /*0x20*/ int size;
            /*0x24*/ int limit;

            /*0x777d434*/ HWStack(int GrowthRate);
            /*0x777d43c*/ HWStack(int GrowthRate, int limit);
            /*0x777d82c*/ HWStack(object[] stack, int growthRate, int used, int size);
            /*0x777d4bc*/ object Push();
            /*0x777d5fc*/ object Pop();
            /*0x777d644*/ object Peek();
            /*0x777d688*/ void AddToTop(object o);
            /*0x777d704*/ object get_Item(int index);
            /*0x777d778*/ void set_Item(int index, object value);
            /*0x777d824*/ int get_Length();
            /*0x777d87c*/ object Clone();
        }

        interface IXmlLineInfo
        {
            /*0x3813ffc*/ bool HasLineInfo();
            /*0x3814574*/ int get_LineNumber();
            /*0x3814574*/ int get_LinePosition();
        }

        class PositionInfo : System.Xml.IXmlLineInfo
        {
            static /*0x777d97c*/ System.Xml.PositionInfo GetPositionInfo(object o);
            /*0x777da68*/ PositionInfo();
            /*0x777d964*/ bool HasLineInfo();
            /*0x777d96c*/ int get_LineNumber();
            /*0x777d974*/ int get_LinePosition();
        }

        class ReaderPositionInfo : System.Xml.PositionInfo
        {
            /*0x10*/ System.Xml.IXmlLineInfo lineInfo;

            /*0x777da38*/ ReaderPositionInfo(System.Xml.IXmlLineInfo lineInfo);
            /*0x777da70*/ bool HasLineInfo();
            /*0x777db10*/ int get_LineNumber();
            /*0x777dbb4*/ int get_LinePosition();
        }

        interface IXmlNamespaceResolver
        {
            /*0x3814964*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x3814a3c*/ string LookupNamespace(string prefix);
            /*0x3814a3c*/ string LookupPrefix(string namespaceName);
        }

        struct LineInfo
        {
            /*0x10*/ int lineNo;
            /*0x14*/ int linePos;

            /*0x777dc58*/ LineInfo(int lineNo, int linePos);
            /*0x777dc60*/ void Set(int lineNo, int linePos);
        }

        class NameTable : System.Xml.XmlNameTable
        {
            /*0x10*/ System.Xml.NameTable.Entry[] entries;
            /*0x18*/ int count;
            /*0x1c*/ int mask;
            /*0x20*/ int hashCodeRandomizer;

            static /*0x777e0ac*/ bool TextEquals(string str1, char[] str2, int str2Start, int str2Length);
            /*0x777dc68*/ NameTable();
            /*0x777dce4*/ string Add(string key);
            /*0x777df4c*/ string Add(char[] key, int start, int len);
            /*0x777e168*/ string Get(string value);
            /*0x777e2ac*/ string Get(char[] key, int start, int len);
            /*0x777de3c*/ string AddEntry(string str, int hashCode);
            /*0x777e424*/ void Grow();

            class Entry
            {
                /*0x10*/ string str;
                /*0x18*/ int hashCode;
                /*0x20*/ System.Xml.NameTable.Entry next;

                /*0x777e3d0*/ Entry(string str, int hashCode, System.Xml.NameTable.Entry next);
            }
        }

        class Ref
        {
            static /*0x777e578*/ bool Equal(string strA, string strB);
        }

        class DtdParser : System.Xml.IDtdParser
        {
            /*0x10*/ System.Xml.IDtdParserAdapter readerAdapter;
            /*0x18*/ System.Xml.IDtdParserAdapterWithValidation readerAdapterWithValidation;
            /*0x20*/ System.Xml.XmlNameTable nameTable;
            /*0x28*/ System.Xml.Schema.SchemaInfo schemaInfo;
            /*0x30*/ System.Xml.XmlCharType xmlCharType;
            /*0x38*/ string systemId;
            /*0x40*/ string publicId;
            /*0x48*/ bool normalize;
            /*0x49*/ bool validate;
            /*0x4a*/ bool supportNamespaces;
            /*0x4b*/ bool v1Compat;
            /*0x50*/ char[] chars;
            /*0x58*/ int charsUsed;
            /*0x5c*/ int curPos;
            /*0x60*/ System.Xml.DtdParser.ScanningFunction scanningFunction;
            /*0x64*/ System.Xml.DtdParser.ScanningFunction nextScaningFunction;
            /*0x68*/ System.Xml.DtdParser.ScanningFunction savedScanningFunction;
            /*0x6c*/ bool whitespaceSeen;
            /*0x70*/ int tokenStartPos;
            /*0x74*/ int colonPos;
            /*0x78*/ System.Text.StringBuilder internalSubsetValueSb;
            /*0x80*/ int externalEntitiesDepth;
            /*0x84*/ int currentEntityId;
            /*0x88*/ bool freeFloatingDtd;
            /*0x89*/ bool hasFreeFloatingInternalSubset;
            /*0x90*/ System.Text.StringBuilder stringBuilder;
            /*0x98*/ int condSectionDepth;
            /*0x9c*/ System.Xml.LineInfo literalLineInfo;
            /*0xa4*/ char literalQuoteChar;
            /*0xa8*/ string documentBaseUri;
            /*0xb0*/ string externalDtdBaseUri;
            /*0xb8*/ System.Collections.Generic.Dictionary<string, System.Xml.DtdParser.UndeclaredNotation> undeclaredNotations;
            /*0xc0*/ int[] condSectionEntityIds;

            static /*0x777e6b4*/ System.Xml.IDtdParser Create();
            static /*0x7788680*/ string StripSpaces(string value);
            /*0x777e584*/ DtdParser();
            /*0x777e704*/ void Initialize(System.Xml.IDtdParserAdapter readerAdapter);
            /*0x777eb24*/ void InitializeFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, System.Xml.IDtdParserAdapter adapter);
            /*0x777f0c8*/ System.Xml.IDtdInfo System.Xml.IDtdParser.ParseInternalDtd(System.Xml.IDtdParserAdapter adapter, bool saveInternalSubset);
            /*0x777f334*/ System.Xml.IDtdInfo System.Xml.IDtdParser.ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, System.Xml.IDtdParserAdapter adapter);
            /*0x777f358*/ bool get_ParsingInternalSubset();
            /*0x777f368*/ bool get_IgnoreEntityReferences();
            /*0x777f378*/ bool get_SaveInternalSubsetValue();
            /*0x777f438*/ bool get_ParsingTopLevelMarkup();
            /*0x777f468*/ bool get_SupportNamespaces();
            /*0x777f470*/ bool get_Normalize();
            /*0x777f0f8*/ void Parse(bool saveInternalSubset);
            /*0x777f4cc*/ void ParseInDocumentDtd(bool saveInternalSubset);
            /*0x777f478*/ void ParseFreeFloatingDtd();
            /*0x77809c4*/ void ParseInternalSubset();
            /*0x77809c8*/ void ParseExternalSubset();
            /*0x7780b78*/ void ParseSubset();
            /*0x7780f18*/ void ParseAttlistDecl();
            /*0x7782960*/ void ParseAttlistType(System.Xml.Schema.SchemaAttDef attrDef, System.Xml.Schema.SchemaElementDecl elementDecl, bool ignoreErrors);
            /*0x7782ee4*/ void ParseAttlistDefault(System.Xml.Schema.SchemaAttDef attrDef, bool ignoreErrors);
            /*0x77814c8*/ void ParseElementDecl();
            /*0x7783660*/ void ParseElementOnlyContent(System.Xml.Schema.ParticleContentValidator pcv, int startParenEntityId);
            /*0x77839fc*/ void ParseHowMany(System.Xml.Schema.ParticleContentValidator pcv);
            /*0x77833d8*/ void ParseElementMixedContent(System.Xml.Schema.ParticleContentValidator pcv, int startParenEntityId);
            /*0x7781870*/ void ParseEntityDecl();
            /*0x7781bf8*/ void ParseNotationDecl();
            /*0x7783180*/ void AddUndeclaredNotation(string notationName);
            /*0x7781dfc*/ void ParseComment();
            /*0x7782048*/ void ParsePI();
            /*0x77821c4*/ void ParseCondSection();
            /*0x778049c*/ void ParseExternalId(System.Xml.DtdParser.Token idTokenType, System.Xml.DtdParser.Token declType, ref string publicId, ref string systemId);
            /*0x777fa18*/ System.Xml.DtdParser.Token GetToken(bool needWhiteSpace);
            /*0x778421c*/ System.Xml.DtdParser.Token ScanSubsetContent();
            /*0x77841b4*/ System.Xml.DtdParser.Token ScanNameExpected();
            /*0x77841d8*/ System.Xml.DtdParser.Token ScanQNameExpected();
            /*0x77841fc*/ System.Xml.DtdParser.Token ScanNmtokenExpected();
            /*0x7784990*/ System.Xml.DtdParser.Token ScanDoctype1();
            /*0x7784af8*/ System.Xml.DtdParser.Token ScanDoctype2();
            /*0x7786f3c*/ System.Xml.DtdParser.Token ScanClosingTag();
            /*0x7784bb4*/ System.Xml.DtdParser.Token ScanElement1();
            /*0x7784dac*/ System.Xml.DtdParser.Token ScanElement2();
            /*0x7784f70*/ System.Xml.DtdParser.Token ScanElement3();
            /*0x7784ff0*/ System.Xml.DtdParser.Token ScanElement4();
            /*0x77850d0*/ System.Xml.DtdParser.Token ScanElement5();
            /*0x77851d0*/ System.Xml.DtdParser.Token ScanElement6();
            /*0x77852a0*/ System.Xml.DtdParser.Token ScanElement7();
            /*0x7785300*/ System.Xml.DtdParser.Token ScanAttlist1();
            /*0x77853c4*/ System.Xml.DtdParser.Token ScanAttlist2();
            /*0x7785ab8*/ System.Xml.DtdParser.Token ScanAttlist3();
            /*0x7785b58*/ System.Xml.DtdParser.Token ScanAttlist4();
            /*0x7785c28*/ System.Xml.DtdParser.Token ScanAttlist5();
            /*0x7785cf8*/ System.Xml.DtdParser.Token ScanAttlist6();
            /*0x77860b8*/ System.Xml.DtdParser.Token ScanAttlist7();
            /*0x7787574*/ System.Xml.DtdParser.Token ScanLiteral(System.Xml.DtdParser.LiteralType literalType);
            /*0x7787ff0*/ System.Xml.XmlQualifiedName ScanEntityName();
            /*0x7786174*/ System.Xml.DtdParser.Token ScanNotation1();
            /*0x77862b0*/ System.Xml.DtdParser.Token ScanSystemId();
            /*0x7786480*/ System.Xml.DtdParser.Token ScanEntity1();
            /*0x77864f4*/ System.Xml.DtdParser.Token ScanEntity2();
            /*0x7786664*/ System.Xml.DtdParser.Token ScanEntity3();
            /*0x7786364*/ System.Xml.DtdParser.Token ScanPublicId1();
            /*0x7786418*/ System.Xml.DtdParser.Token ScanPublicId2();
            /*0x7786778*/ System.Xml.DtdParser.Token ScanCondSection1();
            /*0x7786a58*/ System.Xml.DtdParser.Token ScanCondSection2();
            /*0x7786af0*/ System.Xml.DtdParser.Token ScanCondSection3();
            /*0x778723c*/ void ScanName();
            /*0x7787244*/ void ScanQName();
            /*0x77883bc*/ void ScanQName(bool isQName);
            /*0x778863c*/ bool ReadDataInName();
            /*0x778724c*/ void ScanNmtoken();
            /*0x77873ac*/ bool EatPublicKeyword();
            /*0x7787490*/ bool EatSystemKeyword();
            /*0x7780328*/ System.Xml.XmlQualifiedName GetNameQualified(bool canHavePrefix);
            /*0x7783164*/ string GetNameString();
            /*0x7783300*/ string GetNmtokenString();
            /*0x778337c*/ string GetValue();
            /*0x778331c*/ string GetValueWithStrippedSpaces();
            /*0x7786fd0*/ int ReadData();
            /*0x777f88c*/ void LoadParsingBuffer();
            /*0x77809bc*/ void SaveParsingBuffer();
            /*0x77824ec*/ void SaveParsingBuffer(int internalSubsetValueEndPos);
            /*0x77840b0*/ bool HandleEntityReference(bool paramEntity, bool inLiteral, bool inAttribute);
            /*0x7788898*/ bool HandleEntityReference(System.Xml.XmlQualifiedName entityName, bool paramEntity, bool inLiteral, bool inAttribute);
            /*0x7787094*/ bool HandleEntityEnd(bool inLiteral);
            /*0x7788150*/ System.Xml.Schema.SchemaEntity VerifyEntityReference(System.Xml.XmlQualifiedName entityName, bool paramEntity, bool mustBeDeclared, bool inAttribute);
            /*0x7782418*/ void SendValidationEvent(int pos, System.Xml.Schema.XmlSeverityType severity, string code, string arg);
            /*0x77830a4*/ void SendValidationEvent(System.Xml.Schema.XmlSeverityType severity, string code, string arg);
            /*0x777f748*/ void SendValidationEvent(System.Xml.Schema.XmlSeverityType severity, System.Xml.Schema.XmlSchemaException e);
            /*0x7783098*/ bool IsAttributeValueType(System.Xml.DtdParser.Token token);
            /*0x7782640*/ int get_LineNo();
            /*0x77826e4*/ int get_LinePos();
            /*0x777f630*/ string get_BaseUriStr();
            /*0x77802c8*/ void OnUnexpectedError();
            /*0x77821ac*/ void Throw(int curPos, string res);
            /*0x7783a6c*/ void Throw(int curPos, string res, string arg);
            /*0x7783e18*/ void Throw(int curPos, string res, string[] args);
            /*0x7782794*/ void Throw(string res, string arg, int lineNo, int linePos);
            /*0x777efec*/ void ThrowInvalidChar(int pos, string data, int invCharPos);
            /*0x7783ffc*/ void ThrowInvalidChar(char[] data, int length, int invCharPos);
            /*0x7782638*/ void ThrowUnexpectedToken(int pos, string expectedToken);
            /*0x7783ca4*/ void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2);
            /*0x7784100*/ string ParseUnexpectedToken(int startPos);

            enum Token
            {
                CDATA = 0,
                ID = 1,
                IDREF = 2,
                IDREFS = 3,
                ENTITY = 4,
                ENTITIES = 5,
                NMTOKEN = 6,
                NMTOKENS = 7,
                NOTATION = 8,
                None = 9,
                PERef = 10,
                AttlistDecl = 11,
                ElementDecl = 12,
                EntityDecl = 13,
                NotationDecl = 14,
                Comment = 15,
                PI = 16,
                CondSectionStart = 17,
                CondSectionEnd = 18,
                Eof = 19,
                REQUIRED = 20,
                IMPLIED = 21,
                FIXED = 22,
                QName = 23,
                Name = 24,
                Nmtoken = 25,
                Quote = 26,
                LeftParen = 27,
                RightParen = 28,
                GreaterThan = 29,
                Or = 30,
                LeftBracket = 31,
                RightBracket = 32,
                PUBLIC = 33,
                SYSTEM = 34,
                Literal = 35,
                DOCTYPE = 36,
                NData = 37,
                Percent = 38,
                Star = 39,
                QMark = 40,
                Plus = 41,
                PCDATA = 42,
                Comma = 43,
                ANY = 44,
                EMPTY = 45,
                IGNORE = 46,
                INCLUDE = 47,
            }

            enum ScanningFunction
            {
                SubsetContent = 0,
                Name = 1,
                QName = 2,
                Nmtoken = 3,
                Doctype1 = 4,
                Doctype2 = 5,
                Element1 = 6,
                Element2 = 7,
                Element3 = 8,
                Element4 = 9,
                Element5 = 10,
                Element6 = 11,
                Element7 = 12,
                Attlist1 = 13,
                Attlist2 = 14,
                Attlist3 = 15,
                Attlist4 = 16,
                Attlist5 = 17,
                Attlist6 = 18,
                Attlist7 = 19,
                Entity1 = 20,
                Entity2 = 21,
                Entity3 = 22,
                Notation1 = 23,
                CondSection1 = 24,
                CondSection2 = 25,
                CondSection3 = 26,
                Literal = 27,
                SystemId = 28,
                PublicId1 = 29,
                PublicId2 = 30,
                ClosingTag = 31,
                ParamEntitySpace = 32,
                None = 33,
            }

            enum LiteralType
            {
                AttributeValue = 0,
                EntityReplText = 1,
                SystemOrPublicID = 2,
            }

            class UndeclaredNotation
            {
                /*0x10*/ string name;
                /*0x18*/ int lineNo;
                /*0x1c*/ int linePos;
                /*0x20*/ System.Xml.DtdParser.UndeclaredNotation next;

                /*0x7783c50*/ UndeclaredNotation(string name, int lineNo, int linePos);
            }

            class ParseElementOnlyContent_LocalFrame
            {
                /*0x10*/ int startParenEntityId;
                /*0x14*/ System.Xml.DtdParser.Token parsingSchema;

                /*0x77839d0*/ ParseElementOnlyContent_LocalFrame(int startParentEntityIdParam);
            }
        }

        enum XmlTokenizedType
        {
            CDATA = 0,
            ID = 1,
            IDREF = 2,
            IDREFS = 3,
            ENTITY = 4,
            ENTITIES = 5,
            NMTOKEN = 6,
            NMTOKENS = 7,
            NOTATION = 8,
            ENUMERATION = 9,
            QName = 10,
            NCName = 11,
            None = 12,
        }

        class ValidateNames
        {
            static /*0x0*/ System.Xml.XmlCharType xmlCharType;

            static /*0x7789750*/ ValidateNames();
            static /*0x7788b80*/ int ParseNmtoken(string s, int offset);
            static /*0x7788c48*/ int ParseNmtokenNoNamespaces(string s, int offset);
            static /*0x7788d2c*/ int ParseNameNoNamespaces(string s, int offset);
            static /*0x7788e84*/ bool IsNameNoNamespaces(string s);
            static /*0x7788f04*/ int ParseNCName(string s, int offset);
            static /*0x7789020*/ int ParseNCName(string s);
            static /*0x7789078*/ int ParseQName(string s, int offset, ref int colonOffset);
            static /*0x7789154*/ void ParseQNameThrow(string s, ref string prefix, ref string localName);
            static /*0x778928c*/ void ThrowInvalidName(string s, int offsetStartChar, int offsetBadChar);
            static /*0x778943c*/ System.Exception GetInvalidNameException(string s, int offsetStartChar, int offsetBadChar);
            static /*0x7789600*/ void SplitQName(string name, ref string prefix, ref string lname);
        }

        struct XmlCharType
        {
            static /*0x0*/ object s_Lock;
            static /*0x8*/ byte[] s_CharProperties;
            /*0x10*/ byte[] charProperties;

            static /*0x77897a8*/ object get_StaticLock();
            static /*0x778983c*/ void InitInstance();
            static /*0x7789aa0*/ void SetProperties(byte[] chProps, string ranges, byte value);
            static /*0x777e63c*/ System.Xml.XmlCharType get_Instance();
            static /*0x7789d00*/ bool IsDigit(char ch);
            static /*0x7788378*/ bool IsHighSurrogate(int ch);
            static /*0x7788388*/ bool IsLowSurrogate(int ch);
            static /*0x7789d28*/ bool IsSurrogate(int ch);
            static /*0x7789d38*/ int CombineSurrogateChar(int lowChar, int highChar);
            static /*0x7789d50*/ void SplitSurrogateChar(int combinedChar, ref char lowChar, ref char highChar);
            static /*0x7789e24*/ bool IsOnlyDigits(string str, int startPos, int len);
            static /*0x7789d14*/ bool InRange(int value, int start, int end);
            /*0x7789b64*/ XmlCharType(byte[] charProperties);
            /*0x778407c*/ bool IsWhiteSpace(char ch);
            /*0x7788b4c*/ bool IsNCNameSingleChar(char ch);
            /*0x7789408*/ bool IsStartNCNameSingleChar(char ch);
            /*0x7788398*/ bool IsNameSingleChar(char ch);
            /*0x7789b6c*/ bool IsCharData(char ch);
            /*0x7789ba0*/ bool IsPubidChar(char ch);
            /*0x7789c1c*/ bool IsTextChar(char ch);
            /*0x7789c50*/ bool IsLetter(char ch);
            /*0x7789c84*/ bool IsNCNameCharXml4e(char ch);
            /*0x7789cb8*/ bool IsStartNCNameCharXml4e(char ch);
            /*0x7789cdc*/ bool IsNameCharXml4e(char ch);
            /*0x7789d84*/ bool IsOnlyWhitespace(string str);
            /*0x7789d9c*/ int IsOnlyWhitespaceWithPos(string str);
            /*0x777ef14*/ int IsOnlyCharData(string str);
            /*0x777f068*/ int IsPublicId(string str);
        }

        class XmlComplianceUtil
        {
            static /*0x7789ecc*/ string NonCDataNormalize(string value);
            static /*0x778a148*/ string CDataNormalize(string value);
        }

        enum ExceptionType
        {
            ArgumentException = 0,
            XmlException = 1,
        }

        enum XmlDateTimeSerializationMode
        {
            Local = 0,
            Utc = 1,
            Unspecified = 2,
            RoundtripKind = 3,
        }

        class XmlConvert
        {
            static /*0x0*/ System.Xml.XmlCharType xmlCharType;
            static /*0x8*/ char[] crt;
            static /*0x10*/ int c_EncodedCharLength;
            static /*0x18*/ System.Text.RegularExpressions.Regex c_EncodeCharPattern;
            static /*0x20*/ System.Text.RegularExpressions.Regex c_DecodeCharPattern;
            static /*0x28*/ string[] s_allDateTimeFormats;
            static /*0x30*/ char[] WhitespaceChars;

            static /*0x7791320*/ XmlConvert();
            static /*0x778a31c*/ string EncodeName(string name);
            static /*0x778ad58*/ string EncodeLocalName(string name);
            static /*0x778adb4*/ string DecodeName(string name);
            static /*0x778a378*/ string EncodeName(string name, bool first, bool local);
            static /*0x778b6c0*/ int FromHex(char digit);
            static /*0x778b6f0*/ byte[] FromBinHexString(string s);
            static /*0x778b748*/ byte[] FromBinHexString(string s, bool allowOddCount);
            static /*0x778b7b4*/ string ToBinHexString(byte[] inArray);
            static /*0x778b818*/ string VerifyName(string name);
            static /*0x778ba30*/ System.Exception TryVerifyName(string name);
            static /*0x778bc90*/ string VerifyQName(string name, System.Xml.ExceptionType exceptionType);
            static /*0x778be98*/ string VerifyNCName(string name);
            static /*0x778bef0*/ string VerifyNCName(string name, System.Xml.ExceptionType exceptionType);
            static /*0x778c044*/ System.Exception TryVerifyNCName(string name);
            static /*0x778c0ec*/ string VerifyTOKEN(string token);
            static /*0x778c220*/ System.Exception TryVerifyTOKEN(string token);
            static /*0x778c354*/ System.Exception TryVerifyNMTOKEN(string name);
            static /*0x778c47c*/ System.Exception TryVerifyNormalizedString(string str);
            static /*0x778c544*/ string ToString(bool value);
            static /*0x778c5ac*/ string ToString(char value);
            static /*0x778c5e8*/ string ToString(decimal value);
            static /*0x778c684*/ string ToString(sbyte value);
            static /*0x778c6b0*/ string ToString(short value);
            static /*0x778c6dc*/ string ToString(int value);
            static /*0x778c708*/ string ToString(long value);
            static /*0x778c734*/ string ToString(byte value);
            static /*0x778c760*/ string ToString(ushort value);
            static /*0x778c78c*/ string ToString(uint value);
            static /*0x778c7b8*/ string ToString(ulong value);
            static /*0x778c7e4*/ string ToString(float value);
            static /*0x778c954*/ string ToString(double value);
            static /*0x778ca50*/ string ToString(System.TimeSpan value);
            static /*0x778caa8*/ string ToString(System.DateTime value, string format);
            static /*0x778cb4c*/ string ToString(System.DateTime value, System.Xml.XmlDateTimeSerializationMode dateTimeOption);
            static /*0x778cf34*/ string ToString(System.DateTimeOffset value);
            static /*0x778cfbc*/ string ToString(System.Guid value);
            static /*0x778cfe0*/ bool ToBoolean(string s);
            static /*0x778d214*/ System.Exception TryToBoolean(string s, ref bool result);
            static /*0x778d450*/ char ToChar(string s);
            static /*0x778d50c*/ System.Exception TryToChar(string s, ref char result);
            static /*0x778d684*/ decimal ToDecimal(string s);
            static /*0x778d6f4*/ System.Exception TryToDecimal(string s, ref decimal result);
            static /*0x778d898*/ decimal ToInteger(string s);
            static /*0x778d908*/ System.Exception TryToInteger(string s, ref decimal result);
            static /*0x778daac*/ sbyte ToSByte(string s);
            static /*0x778dad4*/ System.Exception TryToSByte(string s, ref sbyte result);
            static /*0x778dc44*/ short ToInt16(string s);
            static /*0x778dc6c*/ System.Exception TryToInt16(string s, ref short result);
            static /*0x778dddc*/ int ToInt32(string s);
            static /*0x778de04*/ System.Exception TryToInt32(string s, ref int result);
            static /*0x778df74*/ long ToInt64(string s);
            static /*0x778df9c*/ System.Exception TryToInt64(string s, ref long result);
            static /*0x778e10c*/ byte ToByte(string s);
            static /*0x778e134*/ System.Exception TryToByte(string s, ref byte result);
            static /*0x778e2a4*/ ushort ToUInt16(string s);
            static /*0x778e2cc*/ System.Exception TryToUInt16(string s, ref ushort result);
            static /*0x778e43c*/ uint ToUInt32(string s);
            static /*0x778e464*/ System.Exception TryToUInt32(string s, ref uint result);
            static /*0x778e5d4*/ ulong ToUInt64(string s);
            static /*0x778e5fc*/ System.Exception TryToUInt64(string s, ref ulong result);
            static /*0x778e76c*/ float ToSingle(string s);
            static /*0x778e884*/ System.Exception TryToSingle(string s, ref float result);
            static /*0x778ead4*/ double ToDouble(string s);
            static /*0x778ebec*/ System.Exception TryToDouble(string s, ref double result);
            static /*0x778ee3c*/ double ToXPathDouble(object o);
            static /*0x778f05c*/ System.TimeSpan ToTimeSpan(string s);
            static /*0x778f1f0*/ System.Exception TryToTimeSpan(string s, ref System.TimeSpan result);
            static /*0x778f29c*/ string[] get_AllDateTimeFormats();
            static /*0x778f334*/ void CreateAllDateTimeFormats();
            static /*0x778f8cc*/ System.DateTime ToDateTime(string s);
            static /*0x778f928*/ System.DateTime ToDateTime(string s, string[] formats);
            static /*0x778f9cc*/ System.DateTime ToDateTime(string s, System.Xml.XmlDateTimeSerializationMode dateTimeOption);
            static /*0x778fc10*/ System.DateTimeOffset ToDateTimeOffset(string s);
            static /*0x778fcd8*/ System.Guid ToGuid(string s);
            static /*0x778fd04*/ System.Exception TryToGuid(string s, ref System.Guid result);
            static /*0x778cd7c*/ System.DateTime SwitchToLocalTime(System.DateTime value);
            static /*0x778ce50*/ System.DateTime SwitchToUtcTime(System.DateTime value);
            static /*0x778fefc*/ System.Uri ToUri(string s);
            static /*0x77900b0*/ System.Exception TryToUri(string s, ref System.Uri result);
            static /*0x77902e4*/ bool StrEqual(char[] chars, int strPos1, int strLen1, string str2);
            static /*0x778d1a8*/ string TrimString(string value);
            static /*0x77903b0*/ string TrimStringStart(string value);
            static /*0x779041c*/ string TrimStringEnd(string value);
            static /*0x7790488*/ string[] SplitString(string value);
            static /*0x778c8e0*/ bool IsNegativeZero(double value);
            static /*0x77904f8*/ long DoubleToInt64Bits(double value);
            static /*0x7790500*/ void VerifyCharData(string data, System.Xml.ExceptionType invCharExceptionType, System.Xml.ExceptionType invSurrogateExceptionType);
            static /*0x77906f8*/ System.Exception CreateException(string res, System.Xml.ExceptionType exceptionType, int lineNo, int linePos);
            static /*0x7790a98*/ System.Exception CreateException(string res, string arg, System.Xml.ExceptionType exceptionType, int lineNo, int linePos);
            static /*0x7790bd4*/ System.Exception CreateException(string res, string[] args, System.Xml.ExceptionType exceptionType);
            static /*0x778bdc0*/ System.Exception CreateException(string res, string[] args, System.Xml.ExceptionType exceptionType, int lineNo, int linePos);
            static /*0x7790c5c*/ System.Exception CreateInvalidSurrogatePairException(char low, char hi);
            static /*0x7790cc4*/ System.Exception CreateInvalidSurrogatePairException(char low, char hi, System.Xml.ExceptionType exceptionType);
            static /*0x77907b8*/ System.Exception CreateInvalidSurrogatePairException(char low, char hi, System.Xml.ExceptionType exceptionType, int lineNo, int linePos);
            static /*0x7790d38*/ System.Exception CreateInvalidHighSurrogateCharException(char hi);
            static /*0x7790d90*/ System.Exception CreateInvalidHighSurrogateCharException(char hi, System.Xml.ExceptionType exceptionType);
            static /*0x7790dfc*/ System.Exception CreateInvalidHighSurrogateCharException(char hi, System.Xml.ExceptionType exceptionType, int lineNo, int linePos);
            static /*0x779094c*/ System.Exception CreateInvalidCharException(string data, int invCharPos, System.Xml.ExceptionType exceptionType);
            static /*0x7790ef8*/ System.Exception CreateInvalidCharException(char invChar, char nextChar);
            static /*0x7790f60*/ System.Exception CreateInvalidCharException(char invChar, char nextChar, System.Xml.ExceptionType exceptionType);
            static /*0x778b96c*/ System.Exception CreateInvalidNameCharException(string name, int index, System.Xml.ExceptionType exceptionType);
            static /*0x779126c*/ System.ArgumentException CreateInvalidNameArgumentException(string name, string argumentName);
        }

        class XmlDownloadManager
        {
            /*0x10*/ System.Collections.Hashtable connections;

            /*0x7792034*/ XmlDownloadManager();
            /*0x7791430*/ System.IO.Stream GetStream(System.Uri uri, System.Net.ICredentials credentials, System.Net.IWebProxy proxy, System.Net.Cache.RequestCachePolicy cachePolicy);
            /*0x7791530*/ System.IO.Stream GetNonFileStream(System.Uri uri, System.Net.ICredentials credentials, System.Net.IWebProxy proxy, System.Net.Cache.RequestCachePolicy cachePolicy);
            /*0x7791bd0*/ void Remove(string host);
            /*0x7791d3c*/ System.Threading.Tasks.Task<System.IO.Stream> GetStreamAsync(System.Uri uri, System.Net.ICredentials credentials, System.Net.IWebProxy proxy, System.Net.Cache.RequestCachePolicy cachePolicy);
            /*0x7791eb4*/ System.Threading.Tasks.Task<System.IO.Stream> GetNonFileStreamAsync(System.Uri uri, System.Net.ICredentials credentials, System.Net.IWebProxy proxy, System.Net.Cache.RequestCachePolicy cachePolicy);

            class <>c__DisplayClass4_0
            {
                /*0x10*/ System.Uri uri;

                /*0x7791eac*/ <>c__DisplayClass4_0();
                /*0x779203c*/ System.IO.Stream <GetStreamAsync>b__0();
            }

            struct <GetNonFileStreamAsync>d__5 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.IO.Stream> <>t__builder;
                /*0x30*/ System.Uri uri;
                /*0x38*/ System.Net.ICredentials credentials;
                /*0x40*/ System.Net.IWebProxy proxy;
                /*0x48*/ System.Net.Cache.RequestCachePolicy cachePolicy;
                /*0x50*/ System.Xml.XmlDownloadManager <>4__this;
                /*0x58*/ System.Net.WebRequest <req>5__2;
                /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Net.WebResponse> <>u__1;

                /*0x77920c8*/ void MoveNext();
                /*0x77928a8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class OpenedHost
        {
            /*0x10*/ int nonCachedConnectionsCount;

            /*0x77919ac*/ OpenedHost();
        }

        class XmlRegisteredNonCachedStream : System.IO.Stream
        {
            /*0x28*/ System.IO.Stream stream;
            /*0x30*/ System.Xml.XmlDownloadManager downloadManager;
            /*0x38*/ string host;

            /*0x77919b4*/ XmlRegisteredNonCachedStream(System.IO.Stream stream, System.Xml.XmlDownloadManager downloadManager, string host);
            /*0x7792924*/ void Finalize();
            /*0x77929d8*/ void Dispose(bool disposing);
            /*0x7792b1c*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state);
            /*0x7792b40*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state);
            /*0x7792b64*/ int EndRead(System.IAsyncResult asyncResult);
            /*0x7792b88*/ void EndWrite(System.IAsyncResult asyncResult);
            /*0x7792bac*/ void Flush();
            /*0x7792bd0*/ int Read(byte[] buffer, int offset, int count);
            /*0x7792bf4*/ int ReadByte();
            /*0x7792c18*/ long Seek(long offset, System.IO.SeekOrigin origin);
            /*0x7792c3c*/ void SetLength(long value);
            /*0x7792c60*/ void Write(byte[] buffer, int offset, int count);
            /*0x7792c84*/ void WriteByte(byte value);
            /*0x7792ca8*/ bool get_CanRead();
            /*0x7792cc8*/ bool get_CanSeek();
            /*0x7792ce8*/ bool get_CanWrite();
            /*0x7792d08*/ long get_Length();
            /*0x7792d28*/ long get_Position();
            /*0x7792d4c*/ void set_Position(long value);
        }

        class XmlCachedStream : System.IO.MemoryStream
        {
            /*0x50*/ System.Uri uri;

            /*0x7791a58*/ XmlCachedStream(System.Uri uri, System.IO.Stream stream);
        }

        class UTF16Decoder : System.Text.Decoder
        {
            /*0x20*/ bool bigEndian;
            /*0x24*/ int lastByte;

            /*0x7792d70*/ UTF16Decoder(bool bigEndian);
            /*0x7792da0*/ int GetCharCount(byte[] bytes, int index, int count);
            /*0x7792db0*/ int GetCharCount(byte[] bytes, int index, int count, bool flush);
            /*0x7792e94*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0x7793008*/ void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, ref int bytesUsed, ref int charsUsed, ref bool completed);
        }

        class SafeAsciiDecoder : System.Text.Decoder
        {
            /*0x77931d4*/ SafeAsciiDecoder();
            /*0x77931dc*/ int GetCharCount(byte[] bytes, int index, int count);
            /*0x77931e4*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0x7793250*/ void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, ref int bytesUsed, ref int charsUsed, ref bool completed);
        }

        class Ucs4Encoding : System.Text.Encoding
        {
            /*0x38*/ System.Xml.Ucs4Decoder ucs4Decoder;

            static /*0x77933cc*/ System.Text.Encoding get_UCS4_Littleendian();
            static /*0x7793484*/ System.Text.Encoding get_UCS4_Bigendian();
            static /*0x779353c*/ System.Text.Encoding get_UCS4_2143();
            static /*0x77935f4*/ System.Text.Encoding get_UCS4_3412();
            /*0x77936ac*/ Ucs4Encoding();
            /*0x77932d8*/ string get_WebName();
            /*0x77932e4*/ System.Text.Decoder GetDecoder();
            /*0x77932ec*/ int GetByteCount(char[] chars, int index, int count);
            /*0x779334c*/ byte[] GetBytes(string s);
            /*0x7793354*/ int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);
            /*0x779335c*/ int GetMaxByteCount(int charCount);
            /*0x7793364*/ int GetCharCount(byte[] bytes, int index, int count);
            /*0x7793384*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0x77933a4*/ int GetMaxCharCount(int byteCount);
            /*0x77933bc*/ int get_CodePage();
            /*0x77933c4*/ System.Text.Encoder GetEncoder();
        }

        class Ucs4Encoding1234 : System.Xml.Ucs4Encoding
        {
            /*0x77934d4*/ Ucs4Encoding1234();
            /*0x77936b8*/ string get_EncodingName();
            /*0x77936f8*/ byte[] GetPreamble();
        }

        class Ucs4Encoding4321 : System.Xml.Ucs4Encoding
        {
            /*0x779341c*/ Ucs4Encoding4321();
            /*0x7793774*/ string get_EncodingName();
            /*0x77937b4*/ byte[] GetPreamble();
        }

        class Ucs4Encoding2143 : System.Xml.Ucs4Encoding
        {
            /*0x779358c*/ Ucs4Encoding2143();
            /*0x779382c*/ string get_EncodingName();
            /*0x779386c*/ byte[] GetPreamble();
        }

        class Ucs4Encoding3412 : System.Xml.Ucs4Encoding
        {
            /*0x7793644*/ Ucs4Encoding3412();
            /*0x77938e8*/ string get_EncodingName();
            /*0x7793928*/ byte[] GetPreamble();
        }

        class Ucs4Decoder : System.Text.Decoder
        {
            /*0x20*/ byte[] lastBytes;
            /*0x28*/ int lastBytesCount;

            /*0x7793dcc*/ Ucs4Decoder();
            /*0x779399c*/ int GetCharCount(byte[] bytes, int index, int count);
            int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0x77939b8*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0x7793b60*/ void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, ref int bytesUsed, ref int charsUsed, ref bool completed);
            /*0x7793d74*/ void Ucs4ToUTF16(uint code, char[] chars, int charIndex);
        }

        class Ucs4Decoder4321 : System.Xml.Ucs4Decoder
        {
            /*0x7793770*/ Ucs4Decoder4321();
            /*0x7793e30*/ int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
        }

        class Ucs4Decoder1234 : System.Xml.Ucs4Decoder
        {
            /*0x77936b4*/ Ucs4Decoder1234();
            /*0x7794048*/ int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
        }

        class Ucs4Decoder2143 : System.Xml.Ucs4Decoder
        {
            /*0x7793828*/ Ucs4Decoder2143();
            /*0x7794260*/ int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
        }

        class Ucs4Decoder3412 : System.Xml.Ucs4Decoder
        {
            /*0x77938e4*/ Ucs4Decoder3412();
            /*0x7794478*/ int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
        }

        class XmlException : System.SystemException
        {
            /*0x90*/ string res;
            /*0x98*/ string[] args;
            /*0xa0*/ int lineNumber;
            /*0xa4*/ int linePosition;
            /*0xa8*/ string sourceUri;
            /*0xb0*/ string message;

            static /*0x7794fcc*/ string FormatUserMessage(string message, int lineNumber, int linePosition);
            static /*0x7794a80*/ string CreateMessage(string res, string[] args, int lineNumber, int linePosition);
            static /*0x778bc20*/ string[] BuildCharExceptionArgs(string data, int invCharIndex);
            static /*0x77956ec*/ string[] BuildCharExceptionArgs(char[] data, int length, int invCharIndex);
            static /*0x7790ff4*/ string[] BuildCharExceptionArgs(char invChar, char nextChar);
            /*0x7794690*/ XmlException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x7794e4c*/ XmlException();
            /*0x7794e64*/ XmlException(string message);
            /*0x7794e80*/ XmlException(string message, System.Exception innerException);
            /*0x7794e78*/ XmlException(string message, System.Exception innerException, int lineNumber, int linePosition);
            /*0x7794e90*/ XmlException(string message, System.Exception innerException, int lineNumber, int linePosition, string sourceUri);
            /*0x778bc7c*/ XmlException(string res, string[] args);
            /*0x778bb80*/ XmlException(string res, string arg);
            /*0x7795158*/ XmlException(string res, string arg, string sourceUri);
            /*0x7795204*/ XmlException(string res, string arg, System.Xml.IXmlLineInfo lineInfo);
            /*0x779542c*/ XmlException(string res, string arg, System.Exception innerException, System.Xml.IXmlLineInfo lineInfo);
            /*0x779560c*/ XmlException(string res, string[] args, System.Xml.IXmlLineInfo lineInfo);
            /*0x77952a8*/ XmlException(string res, string[] args, System.Xml.IXmlLineInfo lineInfo, string sourceUri);
            /*0x77909e8*/ XmlException(string res, string arg, int lineNumber, int linePosition);
            /*0x7795614*/ XmlException(string res, string arg, int lineNumber, int linePosition, string sourceUri);
            /*0x7790c48*/ XmlException(string res, string[] args, int lineNumber, int linePosition);
            /*0x77956d0*/ XmlException(string res, string[] args, int lineNumber, int linePosition, string sourceUri);
            /*0x77956e4*/ XmlException(string res, string[] args, System.Exception innerException, int lineNumber, int linePosition);
            /*0x77950b0*/ XmlException(string res, string[] args, System.Exception innerException, int lineNumber, int linePosition, string sourceUri);
            /*0x7794cdc*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x7795740*/ int get_LineNumber();
            /*0x7795748*/ int get_LinePosition();
            /*0x7795750*/ string get_Message();
            /*0x7795768*/ string get_ResString();
        }

        class XmlNameTable
        {
            /*0x7795770*/ XmlNameTable();
            string Get(char[] array, int offset, int length);
            /*0x3814a3c*/ string Get(string array);
            string Add(char[] array, int offset, int length);
            /*0x3814a3c*/ string Add(string array);
        }

        enum XmlNamespaceScope
        {
            All = 0,
            ExcludeXml = 1,
            Local = 2,
        }

        class XmlNamespaceManager : System.Xml.IXmlNamespaceResolver, System.Collections.IEnumerable
        {
            /*0x10*/ System.Xml.XmlNamespaceManager.NamespaceDeclaration[] nsdecls;
            /*0x18*/ int lastDecl;
            /*0x20*/ System.Xml.XmlNameTable nameTable;
            /*0x28*/ int scopeId;
            /*0x30*/ System.Collections.Generic.Dictionary<string, int> hashTable;
            /*0x38*/ bool useHashtable;
            /*0x40*/ string xml;
            /*0x48*/ string xmlNs;

            /*0x7795778*/ XmlNamespaceManager();
            /*0x7795780*/ XmlNamespaceManager(System.Xml.XmlNameTable nameTable);
            /*0x7795a24*/ System.Xml.XmlNameTable get_NameTable();
            /*0x7795a2c*/ string get_DefaultNamespace();
            /*0x7795a6c*/ void PushScope();
            /*0x7795a7c*/ bool PopScope();
            /*0x7795b50*/ void AddNamespace(string prefix, string uri);
            /*0x77960c8*/ void RemoveNamespace(string prefix, string uri);
            /*0x7796204*/ System.Collections.IEnumerator GetEnumerator();
            /*0x7796378*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x7796530*/ string LookupNamespace(string prefix);
            /*0x7795f38*/ int LookupNamespaceDecl(string prefix);
            /*0x779657c*/ string LookupPrefix(string uri);

            struct NamespaceDeclaration
            {
                /*0x10*/ string prefix;
                /*0x18*/ string uri;
                /*0x20*/ int scopeId;
                /*0x24*/ int previousNsIndex;

                /*0x77959dc*/ void Set(string prefix, string uri, int scopeId, int previousNsIndex);
            }
        }

        enum XmlNodeType
        {
            None = 0,
            Element = 1,
            Attribute = 2,
            Text = 3,
            CDATA = 4,
            EntityReference = 5,
            Entity = 6,
            ProcessingInstruction = 7,
            Comment = 8,
            Document = 9,
            DocumentType = 10,
            DocumentFragment = 11,
            Notation = 12,
            Whitespace = 13,
            SignificantWhitespace = 14,
            EndElement = 15,
            EndEntity = 16,
            XmlDeclaration = 17,
        }

        class XmlQualifiedName
        {
            static /*0x0*/ System.Xml.XmlQualifiedName.HashCodeOfStringDelegate hashCodeDelegate;
            static /*0x8*/ System.Xml.XmlQualifiedName Empty;
            /*0x10*/ string name;
            /*0x18*/ string ns;
            /*0x20*/ int hash;

            static /*0x7797048*/ XmlQualifiedName();
            static /*0x7796b34*/ bool op_Equality(System.Xml.XmlQualifiedName a, System.Xml.XmlQualifiedName b);
            static /*0x7796ac4*/ bool op_Inequality(System.Xml.XmlQualifiedName a, System.Xml.XmlQualifiedName b);
            static /*0x7796b9c*/ string ToString(string name, string ns);
            static /*0x77967dc*/ System.Xml.XmlQualifiedName.HashCodeOfStringDelegate GetHashCodeDelegate();
            static /*0x7796c0c*/ bool IsRandomizedHashingDisabled();
            static /*0x7796cc8*/ int GetHashCodeOfString(string s, int length, long additionalEntropy);
            static /*0x7796e20*/ System.Xml.XmlQualifiedName Parse(string s, System.Xml.IXmlNamespaceResolver nsmgr, ref string prefix);
            /*0x7796640*/ XmlQualifiedName();
            /*0x77966d8*/ XmlQualifiedName(string name);
            /*0x779665c*/ XmlQualifiedName(string name, string ns);
            /*0x77966f0*/ string get_Namespace();
            /*0x77966f8*/ string get_Name();
            /*0x7796700*/ int GetHashCode();
            /*0x7796938*/ bool get_IsEmpty();
            /*0x7796974*/ string ToString();
            /*0x77969e4*/ bool Equals(object other);
            /*0x7796ce4*/ void Init(string name, string ns);
            /*0x7796d1c*/ void SetNamespace(string ns);
            /*0x7796d24*/ void Verify();
            /*0x7796db4*/ void Atomize(System.Xml.XmlNameTable nameTable);
            /*0x7796fc8*/ System.Xml.XmlQualifiedName Clone();

            class HashCodeOfStringDelegate : System.MulticastDelegate
            {
                /*0x7796c14*/ HashCodeOfStringDelegate(object object, nint method);
                /*0x77970e4*/ int Invoke(string s, int sLen, long additionalEntropy);
            }
        }

        class XmlResolver
        {
            /*0x7797434*/ XmlResolver();
            /*0x3814c14*/ object GetEntity(System.Uri absoluteUri, string role, System.Type ofObjectToReturn);
            /*0x77970f8*/ System.Uri ResolveUri(System.Uri baseUri, string relativeUri);
            /*0x77972c4*/ bool SupportsType(System.Uri absoluteUri, System.Type type);
            /*0x77973fc*/ System.Threading.Tasks.Task<object> GetEntityAsync(System.Uri absoluteUri, string role, System.Type ofObjectToReturn);
        }

        class XmlUrlResolver : System.Xml.XmlResolver
        {
            static /*0x0*/ object s_DownloadManager;
            /*0x10*/ System.Net.ICredentials _credentials;
            /*0x18*/ System.Net.IWebProxy _proxy;
            /*0x20*/ System.Net.Cache.RequestCachePolicy _cachePolicy;

            static /*0x779743c*/ System.Xml.XmlDownloadManager get_DownloadManager();
            /*0x7797508*/ XmlUrlResolver();
            /*0x7797510*/ object GetEntity(System.Uri absoluteUri, string role, System.Type ofObjectToReturn);
            /*0x7797664*/ System.Uri ResolveUri(System.Uri baseUri, string relativeUri);
            /*0x7797668*/ System.Threading.Tasks.Task<object> GetEntityAsync(System.Uri absoluteUri, string role, System.Type ofObjectToReturn);

            struct <GetEntityAsync>d__15 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object> <>t__builder;
                /*0x30*/ System.Type ofObjectToReturn;
                /*0x38*/ System.Uri absoluteUri;
                /*0x40*/ System.Xml.XmlUrlResolver <>4__this;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.IO.Stream> <>u__1;

                /*0x77977b4*/ void MoveNext();
                /*0x7797b64*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class BinaryCompatibility
        {
            static /*0x7797be0*/ bool get_TargetsAtLeast_Desktop_V4_5_2();
        }

        class Res
        {
            static /*0x778b968*/ string GetString(string name);
            static /*0x778cf24*/ string GetString(string name, object[] args);
        }

        namespace XPath
        {
            class XPathDocument
            {
                /*0x10*/ MS.Internal.Xml.Cache.XPathNode[] pageXmlNmsp;
                /*0x18*/ int idxXmlNmsp;
                /*0x20*/ System.Xml.XmlNameTable nameTable;
                /*0x28*/ bool hasLineInfo;
                /*0x30*/ System.Collections.Generic.Dictionary<MS.Internal.Xml.Cache.XPathNodeRef, MS.Internal.Xml.Cache.XPathNodeRef> mapNmsp;

                /*0x7797be8*/ System.Xml.XmlNameTable get_NameTable();
                /*0x7797bf0*/ bool get_HasLineInfo();
                /*0x7797bf8*/ int GetXmlNamespaceNode(ref MS.Internal.Xml.Cache.XPathNode[] pageXmlNmsp);
                /*0x7797c20*/ int LookupNamespaces(MS.Internal.Xml.Cache.XPathNode[] pageElem, int idxElem, ref MS.Internal.Xml.Cache.XPathNode[] pageNmsp);
            }

            class XPathException : System.SystemException
            {
                /*0x90*/ string res;
                /*0x98*/ string[] args;
                /*0xa0*/ string message;

                static /*0x77982e4*/ System.Xml.XPath.XPathException Create(string res);
                static /*0x779834c*/ System.Xml.XPath.XPathException Create(string res, string arg);
                static /*0x7798400*/ System.Xml.XPath.XPathException Create(string res, string arg, string arg2);
                static /*0x7797f88*/ string CreateMessage(string res, string[] args);
                /*0x7797d0c*/ XPathException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x77981ac*/ XPathException();
                /*0x77981c8*/ XPathException(string message, System.Exception innerException);
                /*0x7798344*/ XPathException(string res, string[] args);
                /*0x7798270*/ XPathException(string res, string[] args, System.Exception inner);
                /*0x77980c4*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x77984d8*/ string get_Message();
            }

            enum XPathResultType
            {
                Number = 0,
                String = 1,
                Boolean = 2,
                NodeSet = 3,
                Navigator = 1,
                Any = 5,
                Error = 6,
            }

            class XPathItem
            {
                /*0x7798504*/ XPathItem();
                /*0x38148bc*/ System.Xml.Schema.XmlSchemaType get_XmlType();
                /*0x38148bc*/ string get_Value();
                /*0x38148bc*/ object get_TypedValue();
                /*0x38148bc*/ System.Type get_ValueType();
                /*0x3813ffc*/ bool get_ValueAsBoolean();
                /*0x381440c*/ System.DateTime get_ValueAsDateTime();
                /*0x3814438*/ double get_ValueAsDouble();
                /*0x3814574*/ int get_ValueAsInt();
                /*0x38146fc*/ long get_ValueAsLong();
                /*0x77984f0*/ object ValueAs(System.Type returnType);
                /*0x3814b90*/ object ValueAs(System.Type returnType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            enum XPathNamespaceScope
            {
                All = 0,
                ExcludeXml = 1,
                Local = 2,
            }

            class XPathNavigator : System.Xml.XPath.XPathItem, System.ICloneable, System.Xml.IXmlNamespaceResolver
            {
                static /*0x0*/ System.Xml.XPath.XPathNavigatorKeyComparer comparer;
                static /*0x8*/ char[] NodeTypeLetter;
                static /*0x10*/ char[] UniqueIdTbl;
                static /*0x18*/ int[] ContentKindMasks;

                static /*0x779a2fc*/ XPathNavigator();
                static /*0x779a2e4*/ bool IsText(System.Xml.XPath.XPathNodeType type);
                /*0x779a2f4*/ XPathNavigator();
                /*0x779850c*/ string ToString();
                /*0x7798518*/ System.Xml.Schema.XmlSchemaType get_XmlType();
                /*0x77986a0*/ object get_TypedValue();
                /*0x779897c*/ System.Type get_ValueType();
                /*0x7798b6c*/ bool get_ValueAsBoolean();
                /*0x7798e30*/ System.DateTime get_ValueAsDateTime();
                /*0x77990fc*/ double get_ValueAsDouble();
                /*0x77993c8*/ int get_ValueAsInt();
                /*0x7799694*/ long get_ValueAsLong();
                /*0x7799960*/ object ValueAs(System.Type returnType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x7799c4c*/ object System.ICloneable.Clone();
                /*0x38148bc*/ System.Xml.XmlNameTable get_NameTable();
                /*0x7799c5c*/ string LookupNamespace(string prefix);
                /*0x7799df4*/ string LookupPrefix(string namespaceURI);
                /*0x7799fd8*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
                /*0x38148bc*/ System.Xml.XPath.XPathNavigator Clone();
                /*0x3814574*/ System.Xml.XPath.XPathNodeType get_NodeType();
                /*0x38148bc*/ string get_LocalName();
                /*0x38148bc*/ string get_NamespaceURI();
                /*0x38148bc*/ string get_Prefix();
                /*0x779a1f4*/ object get_UnderlyingObject();
                /*0x779a1fc*/ bool MoveToNamespace(string name);
                /*0x38140fc*/ bool MoveToFirstNamespace(System.Xml.XPath.XPathNamespaceScope namespaceScope);
                /*0x38140fc*/ bool MoveToNextNamespace(System.Xml.XPath.XPathNamespaceScope namespaceScope);
                /*0x3813ffc*/ bool MoveToParent();
                /*0x38141c4*/ bool IsSamePosition(System.Xml.XPath.XPathNavigator other);
                /*0x779a29c*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            }

            class XPathNavigatorKeyComparer : System.Collections.IEqualityComparer
            {
                /*0x779a484*/ XPathNavigatorKeyComparer();
                /*0x779a48c*/ bool System.Collections.IEqualityComparer.Equals(object obj1, object obj2);
                /*0x779a568*/ int System.Collections.IEqualityComparer.GetHashCode(object obj);
            }

            enum XPathNodeType
            {
                Root = 0,
                Element = 1,
                Attribute = 2,
                Namespace = 3,
                Text = 4,
                SignificantWhitespace = 5,
                Whitespace = 6,
                ProcessingInstruction = 7,
                Comment = 8,
                All = 9,
            }
        }

        namespace Serialization
        {
            class CodeIdentifier
            {
                static /*0x0*/ Microsoft.CSharp.CodeDomProvider csharp;

                static /*0x779aaf4*/ CodeIdentifier();
                static /*0x779a734*/ string MakePascal(string identifier);
                static /*0x779a8d8*/ string MakeValid(string identifier);
                static /*0x779aab4*/ bool IsValidStart(char c);
                static /*0x779aa5c*/ bool IsValid(char c);
            }

            class XmlSerializerNamespaces
            {
                /*0x10*/ System.Collections.Hashtable namespaces;

                /*0x779ab70*/ XmlSerializerNamespaces();
                /*0x779ab78*/ void Add(string prefix, string ns);
                /*0x779ac2c*/ void AddInternal(string prefix, string ns);
                /*0x779acd8*/ System.Xml.XmlQualifiedName[] ToArray();
                /*0x779b1f0*/ int get_Count();
                /*0x779adc8*/ System.Collections.ArrayList get_NamespaceList();
                /*0x779ac68*/ System.Collections.Hashtable get_Namespaces();
                /*0x779b214*/ void set_Namespaces(System.Collections.Hashtable value);
            }

            class XmlAttributeEventHandler : System.MulticastDelegate
            {
                /*0x779b21c*/ XmlAttributeEventHandler(object object, nint method);
                /*0x779b328*/ void Invoke(object sender, System.Xml.Serialization.XmlAttributeEventArgs e);
            }

            class XmlAttributeEventArgs : System.EventArgs
            {
                /*0x10*/ object o;
                /*0x18*/ System.Xml.XmlAttribute attr;
                /*0x20*/ string qnames;
                /*0x28*/ int lineNumber;
                /*0x2c*/ int linePosition;

                /*0x779b33c*/ XmlAttributeEventArgs(System.Xml.XmlAttribute attr, int lineNumber, int linePosition, object o, string qnames);
            }

            class XmlElementEventHandler : System.MulticastDelegate
            {
                /*0x779b3f8*/ XmlElementEventHandler(object object, nint method);
                /*0x779b504*/ void Invoke(object sender, System.Xml.Serialization.XmlElementEventArgs e);
            }

            class XmlElementEventArgs : System.EventArgs
            {
                /*0x10*/ object o;
                /*0x18*/ System.Xml.XmlElement elem;
                /*0x20*/ string qnames;
                /*0x28*/ int lineNumber;
                /*0x2c*/ int linePosition;

                /*0x779b518*/ XmlElementEventArgs(System.Xml.XmlElement elem, int lineNumber, int linePosition, object o, string qnames);
            }

            class XmlNodeEventHandler : System.MulticastDelegate
            {
                /*0x779b5d4*/ XmlNodeEventHandler(object object, nint method);
                /*0x779b6e0*/ void Invoke(object sender, System.Xml.Serialization.XmlNodeEventArgs e);
            }

            class XmlNodeEventArgs : System.EventArgs
            {
                /*0x10*/ object o;
                /*0x18*/ System.Xml.XmlNode xmlNode;
                /*0x20*/ int lineNumber;
                /*0x24*/ int linePosition;

                /*0x779b6f4*/ XmlNodeEventArgs(System.Xml.XmlNode xmlNode, int lineNumber, int linePosition, object o);
            }

            class UnreferencedObjectEventHandler : System.MulticastDelegate
            {
                /*0x779b794*/ UnreferencedObjectEventHandler(object object, nint method);
                /*0x779b8a0*/ void Invoke(object sender, System.Xml.Serialization.UnreferencedObjectEventArgs e);
            }

            class UnreferencedObjectEventArgs : System.EventArgs
            {
                /*0x10*/ object o;
                /*0x18*/ string id;

                /*0x779b8b4*/ UnreferencedObjectEventArgs(object o, string id);
            }

            interface IXmlSerializable
            {
                /*0x38148bc*/ System.Xml.Schema.XmlSchema GetSchema();
                /*0x3816710*/ void ReadXml(System.Xml.XmlReader reader);
                /*0x3816710*/ void WriteXml(System.Xml.XmlWriter writer);
            }

            interface IXmlTextParser
            {
                /*0x3813ffc*/ bool get_Normalized();
                /*0x3815cc4*/ void set_Normalized(bool value);
                /*0x3814574*/ System.Xml.WhitespaceHandling get_WhitespaceHandling();
                /*0x3815ed0*/ void set_WhitespaceHandling(System.Xml.WhitespaceHandling value);
            }

            class KeyHelper
            {
                static /*0x779b93c*/ void AddField(System.Text.StringBuilder sb, int n, string val);
                static /*0x779b944*/ void AddField(System.Text.StringBuilder sb, int n, string val, string def);
                static /*0x779ba28*/ void AddField(System.Text.StringBuilder sb, int n, bool val);
                static /*0x779ba34*/ void AddField(System.Text.StringBuilder sb, int n, bool val, bool def);
                static /*0x779ba84*/ void AddField(System.Text.StringBuilder sb, int n, int val, int def);
                static /*0x779bb3c*/ void AddField(System.Text.StringBuilder sb, int n, System.Type val);
            }

            class ReflectionHelper
            {
                static /*0x0*/ System.Reflection.ParameterModifier[] empty_modifiers;
                /*0x10*/ System.Collections.Hashtable _clrTypes;
                /*0x18*/ System.Collections.Hashtable _schemaTypes;

                static /*0x779c3fc*/ ReflectionHelper();
                static /*0x779c030*/ void CheckSerializableType(System.Type type, bool allowPrivateConstructors);
                /*0x779c36c*/ ReflectionHelper();
                /*0x779bc1c*/ void RegisterSchemaType(System.Xml.Serialization.XmlTypeMapping map, string xmlType, string ns);
                /*0x779bce8*/ System.Xml.Serialization.XmlTypeMapping GetRegisteredSchemaType(string xmlType, string ns);
                /*0x779bdbc*/ void RegisterClrType(System.Xml.Serialization.XmlTypeMapping map, System.Type type, string ns);
                /*0x779beec*/ System.Xml.Serialization.XmlTypeMapping GetRegisteredClrType(System.Type type, string ns);
            }

            enum SchemaTypes
            {
                NotSet = 0,
                Primitive = 1,
                Enum = 2,
                Array = 3,
                Class = 4,
                XmlSerializable = 5,
                XmlNode = 6,
                Void = 7,
            }

            class SerializationSource
            {
                /*0x10*/ System.Type[] includedTypes;
                /*0x18*/ string namspace;
                /*0x20*/ bool canBeGenerated;

                /*0x779c470*/ SerializationSource(string namspace, System.Type[] includedTypes);
                /*0x779c4bc*/ bool BaseEquals(System.Xml.Serialization.SerializationSource other);
            }

            class XmlTypeSerializationSource : System.Xml.Serialization.SerializationSource
            {
                /*0x28*/ string attributeOverridesHash;
                /*0x30*/ System.Type type;
                /*0x38*/ string rootHash;

                /*0x779c5c8*/ XmlTypeSerializationSource(System.Type type, System.Xml.Serialization.XmlRootAttribute root, System.Xml.Serialization.XmlAttributeOverrides attributeOverrides, string namspace, System.Type[] includedTypes);
                /*0x779cbec*/ bool Equals(object o);
                /*0x779cccc*/ int GetHashCode();
            }

            class XmlTypeConvertorAttribute : System.Attribute
            {
                /*0x10*/ string <Method>k__BackingField;

                /*0x779ccfc*/ XmlTypeConvertorAttribute(string method);
                /*0x779ccec*/ string get_Method();
                /*0x779ccf4*/ void set_Method(string value);
            }

            class TypeData
            {
                static /*0x0*/ string[] keywords;
                /*0x10*/ System.Type type;
                /*0x18*/ string elementName;
                /*0x20*/ System.Xml.Serialization.SchemaTypes sType;
                /*0x28*/ System.Type listItemType;
                /*0x30*/ string typeName;
                /*0x38*/ string fullTypeName;
                /*0x40*/ System.Xml.Serialization.TypeData listItemTypeData;
                /*0x48*/ System.Xml.Serialization.TypeData mappedType;
                /*0x50*/ System.Xml.Schema.XmlSchemaPatternFacet facet;
                /*0x58*/ System.Reflection.MethodInfo typeConvertor;
                /*0x60*/ bool hasPublicConstructor;
                /*0x61*/ bool nullableOverride;

                static /*0x779e198*/ TypeData();
                static /*0x779df78*/ System.Reflection.PropertyInfo GetIndexerProperty(System.Type collectionType);
                static /*0x779e07c*/ System.InvalidOperationException CreateMissingAddMethodException(System.Type type, string inheritFrom, System.Type argumentType);
                static /*0x779dd90*/ System.Type GetGenericListItemType(System.Type type);
                /*0x779cd2c*/ TypeData(System.Type type, string elementName, bool isPrimitive);
                /*0x779cd3c*/ TypeData(System.Type type, string elementName, bool isPrimitive, System.Xml.Serialization.TypeData mappedType, System.Xml.Schema.XmlSchemaPatternFacet facet);
                /*0x779d308*/ void LookupTypeConvertor();
                /*0x779d3bc*/ void ConvertForAssignment(ref object value);
                /*0x779d4b0*/ string get_TypeName();
                /*0x779d4b8*/ string get_XmlType();
                /*0x779d4c0*/ System.Type get_Type();
                /*0x779d4c8*/ string get_FullTypeName();
                /*0x779d4d0*/ System.Xml.Serialization.SchemaTypes get_SchemaType();
                /*0x779c35c*/ bool get_IsListType();
                /*0x779d4d8*/ bool get_IsComplexType();
                /*0x779d510*/ bool get_IsValueType();
                /*0x779d584*/ bool get_IsNullable();
                /*0x779d68c*/ void set_IsNullable(bool value);
                /*0x779d14c*/ System.Xml.Serialization.TypeData get_ListItemTypeData();
                /*0x779d698*/ System.Type get_ListItemType();
                /*0x779d500*/ bool get_IsXsdType();
                /*0x779e190*/ bool get_HasPublicConstructor();
            }

            class TypeMember
            {
                /*0x10*/ System.Type type;
                /*0x18*/ string member;

                static /*0x779f284*/ bool Equals(System.Xml.Serialization.TypeMember tm1, System.Xml.Serialization.TypeMember tm2);
                /*0x779f188*/ TypeMember(System.Type type, string member);
                /*0x779f1cc*/ int GetHashCode();
                /*0x779f214*/ bool Equals(object obj);
                /*0x779f310*/ string ToString();
            }

            class TypeTranslator
            {
                static /*0x0*/ System.Collections.Hashtable nameCache;
                static /*0x8*/ System.Collections.Hashtable primitiveTypes;
                static /*0x10*/ System.Collections.Hashtable primitiveArrayTypes;
                static /*0x18*/ System.Collections.Hashtable nullableTypes;

                static /*0x779f374*/ TypeTranslator();
                static /*0x779c300*/ System.Xml.Serialization.TypeData GetTypeData(System.Type type);
                static /*0x77a1764*/ System.Xml.Serialization.TypeData GetTypeData(System.Type runtimeType, string xmlDataType, bool underlyingEnumType);
                static /*0x77a20e0*/ System.Xml.Serialization.TypeData GetPrimitiveTypeData(string typeName);
                static /*0x77a2138*/ System.Xml.Serialization.TypeData GetPrimitiveTypeData(string typeName, bool nullable);
                static /*0x77a2338*/ System.Xml.Serialization.TypeData FindPrimitiveTypeData(string typeName);
                static /*0x779d204*/ string GetArrayName(string elemName);
                static /*0x77a23f8*/ void ParseArrayType(string arrayType, ref string type, ref string ns, ref string dimensions);
            }

            class XmlAnyAttributeAttribute : System.Attribute
            {
                /*0x77a2590*/ XmlAnyAttributeAttribute();
            }

            class XmlAnyElementAttribute : System.Attribute
            {
                /*0x10*/ string elementName;
                /*0x18*/ string ns;
                /*0x20*/ int order;

                /*0x77a2598*/ XmlAnyElementAttribute();
                /*0x77a25a8*/ string get_Name();
                /*0x77a25cc*/ string get_Namespace();
                /*0x77a25d4*/ int get_Order();
                /*0x77a25dc*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlAnyElementAttributes : System.Collections.CollectionBase
            {
                /*0x77a2bbc*/ XmlAnyElementAttributes();
                /*0x77a266c*/ System.Xml.Serialization.XmlAnyElementAttribute get_Item(int index);
                /*0x77a276c*/ int Add(System.Xml.Serialization.XmlAnyElementAttribute attribute);
                /*0x77a2824*/ void AddKeyHash(System.Text.StringBuilder sb);
                /*0x77a28f0*/ int get_Order();
            }

            class XmlArrayAttribute : System.Attribute
            {
                /*0x10*/ string elementName;
                /*0x18*/ System.Xml.Schema.XmlSchemaForm form;
                /*0x1c*/ bool isNullable;
                /*0x20*/ string ns;
                /*0x28*/ int order;

                /*0x77a2bc4*/ string get_ElementName();
                /*0x77a2be8*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0x77a2bf0*/ bool get_IsNullable();
                /*0x77a2bf8*/ string get_Namespace();
                /*0x77a2c00*/ int get_Order();
                /*0x77a2c08*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlArrayItemAttribute : System.Attribute
            {
                /*0x10*/ string dataType;
                /*0x18*/ string elementName;
                /*0x20*/ System.Xml.Schema.XmlSchemaForm form;
                /*0x28*/ string ns;
                /*0x30*/ bool isNullable;
                /*0x31*/ bool isNullableSpecified;
                /*0x34*/ int nestingLevel;
                /*0x38*/ System.Type type;

                /*0x77a2d24*/ string get_DataType();
                /*0x77a2d48*/ string get_ElementName();
                /*0x77a2d6c*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0x77a2d74*/ string get_Namespace();
                /*0x77a2d7c*/ bool get_IsNullable();
                /*0x77a2d84*/ bool get_IsNullableSpecified();
                /*0x77a2d8c*/ System.Type get_Type();
                /*0x77a2d94*/ int get_NestingLevel();
                /*0x77a2d9c*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlArrayItemAttributes : System.Collections.CollectionBase
            {
                /*0x77a3174*/ XmlArrayItemAttributes();
                /*0x77a2ef0*/ System.Xml.Serialization.XmlArrayItemAttribute get_Item(int index);
                /*0x77a2ff0*/ int Add(System.Xml.Serialization.XmlArrayItemAttribute attribute);
                /*0x77a30a8*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlAttributeAttribute : System.Attribute
            {
                /*0x10*/ string attributeName;
                /*0x18*/ string dataType;
                /*0x20*/ System.Type type;
                /*0x28*/ System.Xml.Schema.XmlSchemaForm form;
                /*0x30*/ string ns;

                /*0x77a317c*/ XmlAttributeAttribute(string attributeName);
                /*0x77a31ac*/ string get_AttributeName();
                /*0x77a31d0*/ string get_DataType();
                /*0x77a31f4*/ void set_DataType(string value);
                /*0x77a31fc*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0x77a3204*/ string get_Namespace();
                /*0x77a320c*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlAttributeOverrides
            {
                /*0x10*/ System.Collections.Hashtable overrides;

                /*0x77a3338*/ XmlAttributeOverrides();
                /*0x77a33a4*/ System.Xml.Serialization.XmlAttributes get_Item(System.Type type);
                /*0x77a33bc*/ System.Xml.Serialization.XmlAttributes get_Item(System.Type type, string member);
                /*0x77a3470*/ System.Xml.Serialization.TypeMember GetKey(System.Type type, string member);
                /*0x779c6e0*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlAttributes
            {
                /*0x10*/ System.Xml.Serialization.XmlAnyAttributeAttribute xmlAnyAttribute;
                /*0x18*/ System.Xml.Serialization.XmlAnyElementAttributes xmlAnyElements;
                /*0x20*/ System.Xml.Serialization.XmlArrayAttribute xmlArray;
                /*0x28*/ System.Xml.Serialization.XmlArrayItemAttributes xmlArrayItems;
                /*0x30*/ System.Xml.Serialization.XmlAttributeAttribute xmlAttribute;
                /*0x38*/ System.Xml.Serialization.XmlChoiceIdentifierAttribute xmlChoiceIdentifier;
                /*0x40*/ object xmlDefaultValue;
                /*0x48*/ System.Xml.Serialization.XmlElementAttributes xmlElements;
                /*0x50*/ System.Xml.Serialization.XmlEnumAttribute xmlEnum;
                /*0x58*/ bool xmlIgnore;
                /*0x59*/ bool xmlns;
                /*0x60*/ System.Xml.Serialization.XmlRootAttribute xmlRoot;
                /*0x68*/ System.Xml.Serialization.XmlTextAttribute xmlText;
                /*0x70*/ System.Xml.Serialization.XmlTypeAttribute xmlType;

                /*0x77a3754*/ XmlAttributes();
                /*0x77a3874*/ XmlAttributes(System.Reflection.ICustomAttributeProvider provider);
                /*0x77a40b8*/ System.Xml.Serialization.XmlAnyAttributeAttribute get_XmlAnyAttribute();
                /*0x77a40c0*/ System.Xml.Serialization.XmlAnyElementAttributes get_XmlAnyElements();
                /*0x77a40c8*/ System.Xml.Serialization.XmlArrayAttribute get_XmlArray();
                /*0x77a40d0*/ System.Xml.Serialization.XmlArrayItemAttributes get_XmlArrayItems();
                /*0x77a40d8*/ System.Xml.Serialization.XmlAttributeAttribute get_XmlAttribute();
                /*0x77a40e0*/ System.Xml.Serialization.XmlChoiceIdentifierAttribute get_XmlChoiceIdentifier();
                /*0x77a40e8*/ object get_XmlDefaultValue();
                /*0x77a40f0*/ System.Xml.Serialization.XmlElementAttributes get_XmlElements();
                /*0x77a40f8*/ bool get_XmlIgnore();
                /*0x77a4100*/ bool get_Xmlns();
                /*0x77a4108*/ System.Xml.Serialization.XmlRootAttribute get_XmlRoot();
                /*0x77a4110*/ System.Xml.Serialization.XmlTextAttribute get_XmlText();
                /*0x77a4118*/ System.Xml.Serialization.XmlTypeAttribute get_XmlType();
                /*0x77a34d8*/ void AddKeyHash(System.Text.StringBuilder sb);
                /*0x77a4120*/ System.Nullable<int> get_Order();
                /*0x77a41dc*/ int get_SortableOrder();
            }

            class XmlChoiceIdentifierAttribute : System.Attribute
            {
                /*0x10*/ string memberName;

                /*0x77a4260*/ string get_MemberName();
                /*0x77a4284*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlCustomFormatter
            {
                static /*0x0*/ string[] allTimeFormats;

                static /*0x77a5de0*/ XmlCustomFormatter();
                static /*0x77a4300*/ string FromEnum(long value, string[] values, long[] ids, string typeName);
                static /*0x77a457c*/ string FromXmlName(string name);
                static /*0x77a45d4*/ string FromXmlNCName(string ncName);
                static /*0x77a462c*/ string ToXmlString(System.Xml.Serialization.TypeData type, object value);
                static /*0x77a5344*/ object FromXmlString(System.Xml.Serialization.TypeData type, string value);
            }

            class XmlElementAttribute : System.Attribute
            {
                /*0x10*/ string dataType;
                /*0x18*/ string elementName;
                /*0x20*/ System.Xml.Schema.XmlSchemaForm form;
                /*0x28*/ string ns;
                /*0x30*/ bool isNullable;
                /*0x38*/ System.Type type;
                /*0x40*/ int order;

                /*0x77a633c*/ XmlElementAttribute(string elementName);
                /*0x77a6374*/ XmlElementAttribute(string elementName, System.Type type);
                /*0x77a63c0*/ string get_DataType();
                /*0x77a63e4*/ string get_ElementName();
                /*0x77a6408*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0x77a6410*/ string get_Namespace();
                /*0x77a6418*/ bool get_IsNullable();
                /*0x77a6420*/ int get_Order();
                /*0x77a6428*/ System.Type get_Type();
                /*0x77a6430*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlElementAttributes : System.Collections.CollectionBase
            {
                /*0x77a6ac8*/ XmlElementAttributes();
                /*0x77a6578*/ System.Xml.Serialization.XmlElementAttribute get_Item(int index);
                /*0x77a6678*/ int Add(System.Xml.Serialization.XmlElementAttribute attribute);
                /*0x77a6730*/ void AddKeyHash(System.Text.StringBuilder sb);
                /*0x77a67fc*/ int get_Order();
            }

            class XmlEnumAttribute : System.Attribute
            {
                /*0x10*/ string name;

                /*0x77a6ad0*/ XmlEnumAttribute(string name);
                /*0x77a6b00*/ string get_Name();
                /*0x77a6b08*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlIgnoreAttribute : System.Attribute
            {
                /*0x77a6b84*/ XmlIgnoreAttribute();
            }

            class XmlIncludeAttribute : System.Attribute
            {
                /*0x10*/ System.Type type;

                /*0x77a6b8c*/ System.Type get_Type();
            }

            class XmlMapping
            {
                /*0x10*/ System.Xml.Serialization.ObjectMap map;
                /*0x18*/ System.Collections.ArrayList relatedMaps;
                /*0x20*/ System.Xml.Serialization.SerializationFormat format;
                /*0x28*/ System.Xml.Serialization.SerializationSource source;
                /*0x30*/ string _elementName;
                /*0x38*/ string _namespace;
                /*0x40*/ string key;

                /*0x77a6b94*/ XmlMapping(string elementName, string ns);
                /*0x77a6bd8*/ string get_ElementName();
                /*0x77a6be0*/ string get_Namespace();
                /*0x77a6be8*/ void SetKey(string key);
                /*0x77a6bf0*/ System.Xml.Serialization.ObjectMap get_ObjectMap();
                /*0x77a6bf8*/ void set_ObjectMap(System.Xml.Serialization.ObjectMap value);
                /*0x77a6c00*/ System.Collections.ArrayList get_RelatedMaps();
                /*0x77a6c08*/ void set_RelatedMaps(System.Collections.ArrayList value);
                /*0x77a6c10*/ System.Xml.Serialization.SerializationFormat get_Format();
                /*0x77a6c18*/ void set_Format(System.Xml.Serialization.SerializationFormat value);
                /*0x77a6c20*/ System.Xml.Serialization.SerializationSource get_Source();
            }

            class ObjectMap
            {
                /*0x77a6c28*/ ObjectMap();
            }

            enum SerializationFormat
            {
                Encoded = 0,
                Literal = 1,
            }

            class XmlMemberMapping
            {
            }

            class XmlMembersMapping : System.Xml.Serialization.XmlMapping
            {
                /*0x48*/ bool _hasWrapperElement;
                /*0x50*/ System.Xml.Serialization.XmlMemberMapping[] _mapping;

                /*0x77a6c30*/ int get_Count();
                /*0x77a6c4c*/ bool get_HasWrapperElement();
            }

            class XmlNamespaceDeclarationsAttribute : System.Attribute
            {
                /*0x77a6c54*/ XmlNamespaceDeclarationsAttribute();
            }

            class XmlReflectionImporter
            {
                static /*0x0*/ string errSimple;
                static /*0x8*/ string errSimple2;
                /*0x10*/ string initialDefaultNamespace;
                /*0x18*/ System.Xml.Serialization.XmlAttributeOverrides attributeOverrides;
                /*0x20*/ System.Collections.ArrayList includedTypes;
                /*0x28*/ System.Xml.Serialization.ReflectionHelper helper;
                /*0x30*/ int arrayChoiceCount;
                /*0x38*/ System.Collections.ArrayList relatedMaps;
                /*0x40*/ bool allowPrivateTypes;

                static /*0x77adb2c*/ XmlReflectionImporter();
                /*0x77a6c5c*/ XmlReflectionImporter(System.Xml.Serialization.XmlAttributeOverrides attributeOverrides, string defaultNamespace);
                /*0x77a6d90*/ System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Type type);
                /*0x77a6f54*/ System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Type type, string defaultNamespace);
                /*0x77a6d9c*/ System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Type type, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0x77a6f60*/ System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0x77a99b4*/ System.Xml.Serialization.XmlTypeMapping CreateTypeMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultXmlType, string defaultNamespace);
                /*0x77a9e48*/ System.Xml.Serialization.XmlTypeMapping ImportClassMapping(System.Type type, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace, bool isBaseType);
                /*0x77a73ac*/ System.Xml.Serialization.XmlTypeMapping ImportClassMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace, bool isBaseType);
                /*0x77ab788*/ void RegisterDerivedMap(System.Xml.Serialization.XmlTypeMapping map, System.Xml.Serialization.XmlTypeMapping derivedMap);
                /*0x77a9ed8*/ string GetTypeNamespace(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0x77ab994*/ System.Xml.Serialization.XmlTypeMapping ImportListMapping(System.Type type, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace, System.Xml.Serialization.XmlAttributes atts, int nestingLevel);
                /*0x77a8364*/ System.Xml.Serialization.XmlTypeMapping ImportListMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace, System.Xml.Serialization.XmlAttributes atts, int nestingLevel);
                /*0x77a9080*/ System.Xml.Serialization.XmlTypeMapping ImportXmlNodeMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0x77a921c*/ System.Xml.Serialization.XmlTypeMapping ImportPrimitiveMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0x77a92d0*/ System.Xml.Serialization.XmlTypeMapping ImportEnumMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0x77a98a0*/ System.Xml.Serialization.XmlTypeMapping ImportXmlSerializableMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0x77ab870*/ void ImportIncludedTypes(System.Type type, string defaultNamespace);
                /*0x77a9fec*/ System.Collections.Generic.List<System.Xml.Serialization.XmlReflectionMember> GetReflectionMembers(System.Type type);
                /*0x77aadd0*/ System.Xml.Serialization.XmlTypeMapMember CreateMapMember(System.Type declaringType, System.Xml.Serialization.XmlReflectionMember rmember, string defaultNamespace);
                /*0x77ac128*/ System.Xml.Serialization.XmlTypeMapElementInfoList ImportElementInfo(System.Type cls, string defaultName, string defaultNamespace, System.Type defaultType, System.Xml.Serialization.XmlTypeMapMemberElement member, System.Xml.Serialization.XmlAttributes atts);
                /*0x77aba94*/ System.Xml.Serialization.XmlTypeMapElementInfoList ImportAnyElementInfo(string defaultNamespace, System.Xml.Serialization.XmlReflectionMember rmember, System.Xml.Serialization.XmlTypeMapMemberElement member, System.Xml.Serialization.XmlAttributes atts);
                /*0x77ad314*/ void ImportTextElementInfo(System.Xml.Serialization.XmlTypeMapElementInfoList list, System.Type defaultType, System.Xml.Serialization.XmlTypeMapMemberElement member, System.Xml.Serialization.XmlAttributes atts, string defaultNamespace);
                /*0x77a9de4*/ bool CanBeNull(System.Xml.Serialization.TypeData type);
                /*0x77ad654*/ void IncludeType(System.Type type);
                /*0x77ad154*/ object GetDefaultValue(System.Xml.Serialization.TypeData typeData, object defaultValue);

                class <>c
                {
                    static /*0x0*/ System.Xml.Serialization.XmlReflectionImporter.<> <>9;
                    static /*0x8*/ System.Comparison<System.Xml.Serialization.XmlReflectionMember> <>9__28_0;

                    static /*0x77adbc8*/ <>c();
                    /*0x77adc30*/ <>c();
                    /*0x77adc38*/ int <ImportClassMapping>b__28_0(System.Xml.Serialization.XmlReflectionMember m1, System.Xml.Serialization.XmlReflectionMember m2);
                }
            }

            class XmlReflectionMember
            {
                /*0x10*/ bool isReturnValue;
                /*0x18*/ string memberName;
                /*0x20*/ System.Type memberType;
                /*0x28*/ System.Xml.Serialization.XmlAttributes xmlAttributes;
                /*0x30*/ System.Type declaringType;

                /*0x77aba34*/ XmlReflectionMember(string name, System.Type type, System.Xml.Serialization.XmlAttributes attributes);
                /*0x77adc8c*/ bool get_IsReturnValue();
                /*0x77adc94*/ string get_MemberName();
                /*0x77adc9c*/ System.Type get_MemberType();
                /*0x77aad60*/ System.Xml.Serialization.XmlAttributes get_XmlAttributes();
                /*0x77adca4*/ System.Type get_DeclaringType();
                /*0x77adcac*/ void set_DeclaringType(System.Type value);
            }

            class XmlRootAttribute : System.Attribute
            {
                /*0x10*/ string dataType;
                /*0x18*/ string elementName;
                /*0x20*/ bool isNullable;
                /*0x28*/ string ns;

                /*0x77adcb4*/ XmlRootAttribute();
                /*0x77adcc4*/ XmlRootAttribute(string elementName);
                /*0x77adcfc*/ string get_DataType();
                /*0x77add20*/ void set_DataType(string value);
                /*0x77a9e24*/ string get_ElementName();
                /*0x77add28*/ void set_ElementName(string value);
                /*0x77add30*/ bool get_IsNullable();
                /*0x77add38*/ void set_IsNullable(bool value);
                /*0x77add44*/ string get_Namespace();
                /*0x77add4c*/ void set_Namespace(string value);
                /*0x77add54*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlSchemaProviderAttribute : System.Attribute
            {
                /*0x10*/ string _methodName;
                /*0x18*/ bool _isAny;

                /*0x77ade0c*/ XmlSchemaProviderAttribute(string methodName);
                /*0x77ade3c*/ string get_MethodName();
                /*0x77ade44*/ bool get_IsAny();
                /*0x77ade4c*/ void set_IsAny(bool value);
            }

            class XmlSerializationCollectionFixupCallback : System.MulticastDelegate
            {
                /*0x77ade58*/ XmlSerializationCollectionFixupCallback(object object, nint method);
                /*0x77adf64*/ void Invoke(object collection, object collectionItems);
            }

            class XmlSerializationFixupCallback : System.MulticastDelegate
            {
                /*0x77adf78*/ XmlSerializationFixupCallback(object object, nint method);
                /*0x77ae080*/ void Invoke(object fixup);
            }

            class XmlSerializationGeneratedCode
            {
                /*0x77ae094*/ XmlSerializationGeneratedCode();
            }

            class XmlSerializationReadCallback : System.MulticastDelegate
            {
                /*0x77ae09c*/ XmlSerializationReadCallback(object object, nint method);
                /*0x77ae138*/ object Invoke();
            }

            class XmlSerializationReader : System.Xml.Serialization.XmlSerializationGeneratedCode
            {
                /*0x10*/ System.Xml.XmlDocument document;
                /*0x18*/ System.Xml.XmlReader reader;
                /*0x20*/ System.Collections.ArrayList fixups;
                /*0x28*/ System.Collections.Hashtable collFixups;
                /*0x30*/ System.Collections.ArrayList collItemFixups;
                /*0x38*/ System.Collections.Hashtable typesCallbacks;
                /*0x40*/ System.Collections.ArrayList noIDTargets;
                /*0x48*/ System.Collections.Hashtable targets;
                /*0x50*/ System.Collections.Hashtable delayedListFixups;
                /*0x58*/ System.Xml.Serialization.XmlSerializer eventSource;
                /*0x60*/ int delayedFixupId;
                /*0x68*/ System.Collections.Hashtable referencedObjects;
                /*0x70*/ int readCount;
                /*0x74*/ int whileIterationCount;
                /*0x78*/ string w3SchemaNS;
                /*0x80*/ string w3InstanceNS;
                /*0x88*/ string w3InstanceNS2000;
                /*0x90*/ string w3InstanceNS1999;
                /*0x98*/ string soapNS;
                /*0xa0*/ string wsdlNS;
                /*0xa8*/ string nullX;
                /*0xb0*/ string nil;
                /*0xb8*/ string typeX;
                /*0xc0*/ string arrayType;
                /*0xc8*/ System.Xml.XmlQualifiedName arrayQName;

                /*0x77ae5c4*/ XmlSerializationReader();
                /*0x77ae14c*/ void Initialize(System.Xml.XmlReader reader, System.Xml.Serialization.XmlSerializer eventSource);
                /*0x77ae50c*/ System.Collections.ArrayList EnsureArrayList(System.Collections.ArrayList list);
                /*0x77ae568*/ System.Collections.Hashtable EnsureHashtable(System.Collections.Hashtable hash);
                /*0x77ae5cc*/ System.Xml.XmlDocument get_Document();
                /*0x77ae668*/ System.Xml.XmlReader get_Reader();
                /*0x77ae670*/ void AddFixup(System.Xml.Serialization.XmlSerializationReader.CollectionFixup fixup);
                /*0x77ae744*/ void AddFixup(System.Xml.Serialization.XmlSerializationReader.Fixup fixup);
                /*0x77ae798*/ void AddFixup(System.Xml.Serialization.XmlSerializationReader.CollectionItemFixup fixup);
                /*0x77ae7ec*/ void AddReadCallback(string name, string ns, System.Type type, System.Xml.Serialization.XmlSerializationReadCallback read);
                /*0x77ae918*/ void AddTarget(string id, object o);
                /*0x77ae9e0*/ string CurrentTag();
                /*0x77aeb40*/ System.Exception CreateReadOnlyCollectionException(string name);
                /*0x77aebd0*/ System.Exception CreateUnknownConstantException(string value, System.Type enumType);
                /*0x77aec68*/ System.Exception CreateUnknownNodeException();
                /*0x77aecfc*/ System.Exception CreateUnknownTypeException(System.Xml.XmlQualifiedName type);
                /*0x77aeea4*/ System.Array EnsureArrayIndex(System.Array a, int index, System.Type elementType);
                /*0x77aef30*/ bool GetNullAttr();
                /*0x77aefd8*/ object GetTarget(string id);
                /*0x77af09c*/ bool TargetReady(string id);
                /*0x77af0b8*/ System.Xml.XmlQualifiedName GetXsiType();
                /*0x38159dc*/ void InitCallbacks();
                /*0x38159dc*/ void InitIDs();
                /*0x77af2c0*/ bool IsXmlnsAttribute(string name);
                /*0x77af360*/ void ParseWsdlArrayType(System.Xml.XmlAttribute attr);
                /*0x77af4e4*/ System.Xml.XmlQualifiedName ReadElementQualifiedName();
                /*0x77af7d4*/ void ReadEndElement();
                /*0x77af86c*/ bool ReadNull();
                /*0x77af968*/ System.Xml.XmlQualifiedName ReadNullableQualifiedName();
                /*0x77af990*/ string ReadNullableString();
                /*0x77af9d8*/ object ReadReferencedElement();
                /*0x77afcf8*/ System.Xml.Serialization.XmlSerializationReader.WriteCallbackInfo GetCallbackInfo(System.Xml.XmlQualifiedName qname);
                /*0x77afa30*/ object ReadReferencedElement(string name, string ns);
                /*0x77afdec*/ bool ReadList(ref object resultList);
                /*0x77b0ca4*/ void ReadReferencedElements();
                /*0x77b1bd4*/ object ReadReferencingElement(ref string fixupReference);
                /*0x77b0c44*/ object ReadReferencingElement(string name, string ns, ref string fixupReference);
                /*0x77b1c38*/ object ReadReferencingElement(string name, string ns, bool elementCanBeType, ref string fixupReference);
                /*0x77b1f7c*/ System.Xml.Serialization.IXmlSerializable ReadSerializable(System.Xml.Serialization.IXmlSerializable serializable);
                /*0x77b210c*/ object ReadTypedPrimitive(System.Xml.XmlQualifiedName type);
                /*0x77b02c0*/ object ReadTypedPrimitive(System.Xml.XmlQualifiedName qname, bool reportUnknown);
                /*0x77b238c*/ System.Xml.XmlNode ReadXmlNode(bool wrapped);
                /*0x77b23f4*/ System.Xml.XmlDocument ReadXmlDocument(bool wrapped);
                /*0x77b2510*/ System.Array ShrinkArray(System.Array a, int length, System.Type elementType, bool isNullable);
                /*0x77af5b4*/ System.Xml.XmlQualifiedName ToXmlQualifiedName(string value);
                /*0x77b25a0*/ void UnknownAttribute(object o, System.Xml.XmlAttribute attr, string qnames);
                /*0x77b26fc*/ void UnknownElement(object o, System.Xml.XmlElement elem, string qnames);
                /*0x77af934*/ void UnknownNode(object o);
                /*0x77b2858*/ void UnknownNode(object o, string qnames);
                /*0x77b2114*/ void OnUnknownNode(System.Xml.XmlNode node, object o, string qnames);
                /*0x77b1b40*/ void UnreferencedObject(string id, object o);

                class WriteCallbackInfo
                {
                    /*0x10*/ System.Type Type;
                    /*0x18*/ string TypeName;
                    /*0x20*/ string TypeNs;
                    /*0x28*/ System.Xml.Serialization.XmlSerializationReadCallback Callback;

                    /*0x77ae910*/ WriteCallbackInfo();
                }

                class CollectionFixup
                {
                    /*0x10*/ System.Xml.Serialization.XmlSerializationCollectionFixupCallback callback;
                    /*0x18*/ object collection;
                    /*0x20*/ object collectionItems;
                    /*0x28*/ string id;

                    /*0x77b2890*/ CollectionFixup(object collection, System.Xml.Serialization.XmlSerializationCollectionFixupCallback callback, string id);
                    /*0x77b28f0*/ System.Xml.Serialization.XmlSerializationCollectionFixupCallback get_Callback();
                    /*0x77b28f8*/ object get_Collection();
                    /*0x77b2900*/ object get_Id();
                    /*0x77b2908*/ object get_CollectionItems();
                    /*0x77b2910*/ void set_CollectionItems(object value);
                }

                class Fixup
                {
                    /*0x10*/ object source;
                    /*0x18*/ string[] ids;
                    /*0x20*/ System.Xml.Serialization.XmlSerializationFixupCallback callback;

                    /*0x77b2918*/ Fixup(object o, System.Xml.Serialization.XmlSerializationFixupCallback callback, int count);
                    /*0x77b29b8*/ System.Xml.Serialization.XmlSerializationFixupCallback get_Callback();
                    /*0x77b29c0*/ string[] get_Ids();
                    /*0x77b29c8*/ object get_Source();
                }

                class CollectionItemFixup
                {
                    /*0x10*/ System.Array list;
                    /*0x18*/ int index;
                    /*0x20*/ string id;

                    /*0x77b0c50*/ CollectionItemFixup(System.Array list, int index, string id);
                    /*0x77b29d0*/ System.Array get_Collection();
                    /*0x77b29d8*/ int get_Index();
                    /*0x77b29e0*/ string get_Id();
                }
            }

            class XmlSerializationReaderInterpreter : System.Xml.Serialization.XmlSerializationReader
            {
                static /*0x0*/ System.Xml.XmlQualifiedName AnyType;
                static /*0x8*/ object[] empty_array;
                /*0xd0*/ System.Xml.Serialization.XmlMapping _typeMap;
                /*0xd8*/ System.Xml.Serialization.SerializationFormat _format;

                static /*0x77b8018*/ XmlSerializationReaderInterpreter();
                static /*0x77b664c*/ object CreateInstance(System.Type type, bool nonPublic);
                /*0x77b29e8*/ XmlSerializationReaderInterpreter(System.Xml.Serialization.XmlMapping typeMap);
                /*0x77b2a2c*/ void InitCallbacks();
                /*0x77b2e48*/ void InitIDs();
                /*0x77b2e4c*/ object ReadRoot();
                /*0x77b302c*/ object ReadEncodedObject(System.Xml.Serialization.XmlTypeMapping typeMap);
                /*0x77b3130*/ object ReadMessage(System.Xml.Serialization.XmlMembersMapping typeMap);
                /*0x77b2f54*/ object ReadRoot(System.Xml.Serialization.XmlTypeMapping rootMap);
                /*0x77b5c3c*/ object ReadObject(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable, bool checkType);
                /*0x77b6390*/ object ReadClassInstance(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable, bool checkType);
                /*0x77b6658*/ void ReadClassInstanceMembers(System.Xml.Serialization.XmlTypeMapping typeMap, object ob);
                /*0x77b36bc*/ void ReadAttributeMembers(System.Xml.Serialization.ClassMap map, object ob, bool isValueList);
                /*0x77b3ab8*/ void ReadMembers(System.Xml.Serialization.ClassMap map, object ob, bool isValueList, bool readBySoapOrder);
                /*0x77b6d84*/ void SetListMembersDefaults(System.Xml.Serialization.ClassMap map, object ob, bool isValueList);
                /*0x77b72fc*/ void FixupMembers(System.Xml.Serialization.ClassMap map, object obfixup, bool isValueList);
                /*0x77b76fc*/ void ProcessUnknownAttribute(object target);
                /*0x77b7730*/ void ProcessUnknownElement(object target);
                /*0x77b6ecc*/ bool IsReadOnly(System.Xml.Serialization.XmlTypeMapMember member, System.Xml.Serialization.TypeData memType, object ob, bool isValueList);
                /*0x77b682c*/ void SetMemberValue(System.Xml.Serialization.XmlTypeMapMember member, object ob, object value, bool isValueList);
                /*0x77b361c*/ void SetMemberValueFromAttr(System.Xml.Serialization.XmlTypeMapMember member, object ob, object value, bool isValueList);
                /*0x77b69c0*/ object GetMemberValue(System.Xml.Serialization.XmlTypeMapMember member, object ob, bool isValueList);
                /*0x77b70b0*/ object ReadObjectElement(System.Xml.Serialization.XmlTypeMapElementInfo elem);
                /*0x77b7764*/ object ReadPrimitiveValue(System.Xml.Serialization.XmlTypeMapElementInfo elem);
                /*0x77b6700*/ object GetValueFromXmlString(string value, System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlTypeMapping typeMap);
                /*0x77b5d20*/ object ReadListElement(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable, object list, bool canCreateInstance);
                /*0x77b7870*/ object ReadListString(System.Xml.Serialization.XmlTypeMapping typeMap, string values);
                /*0x77b6a8c*/ void AddListValue(System.Xml.Serialization.TypeData listType, ref object list, int index, object value, bool canCreateInstance);
                /*0x77b35b8*/ object CreateInstance(System.Type type);
                /*0x77b7014*/ object CreateList(System.Type listType);
                /*0x77b6f30*/ object InitializeList(System.Xml.Serialization.TypeData listType);
                /*0x77b7bb8*/ void FillList(object list, object items);
                /*0x77b7bc8*/ void CopyEnumerableList(object source, object dest);
                /*0x77b5c20*/ object ReadXmlNodeElement(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable);
                /*0x77b7248*/ object ReadXmlNode(System.Xml.Serialization.TypeData type, bool wrapped);
                /*0x77b60d4*/ object ReadPrimitiveElement(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable);
                /*0x77b618c*/ object ReadEnumElement(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable);
                /*0x77b7a94*/ object GetEnumValue(System.Xml.Serialization.XmlTypeMapping typeMap, string val);
                /*0x77b61fc*/ object ReadXmlSerializableElement(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable);

                class FixupCallbackInfo
                {
                    /*0x10*/ System.Xml.Serialization.XmlSerializationReaderInterpreter _sri;
                    /*0x18*/ System.Xml.Serialization.ClassMap _map;
                    /*0x20*/ bool _isValueList;

                    /*0x77b6fbc*/ FixupCallbackInfo(System.Xml.Serialization.XmlSerializationReaderInterpreter sri, System.Xml.Serialization.ClassMap map, bool isValueList);
                    /*0x77b810c*/ void FixupMembers(object fixup);
                }

                class ReaderCallbackInfo
                {
                    /*0x10*/ System.Xml.Serialization.XmlSerializationReaderInterpreter _sri;
                    /*0x18*/ System.Xml.Serialization.XmlTypeMapping _typeMap;

                    /*0x77b2e04*/ ReaderCallbackInfo(System.Xml.Serialization.XmlSerializationReaderInterpreter sri, System.Xml.Serialization.XmlTypeMapping typeMap);
                    /*0x77b8134*/ object ReadObject();
                }
            }

            class XmlSerializationWriteCallback : System.MulticastDelegate
            {
                /*0x77b8164*/ XmlSerializationWriteCallback(object object, nint method);
                /*0x77b826c*/ void Invoke(object o);
            }

            class XmlSerializationWriter : System.Xml.Serialization.XmlSerializationGeneratedCode
            {
                /*0x10*/ System.Runtime.Serialization.ObjectIDGenerator idGenerator;
                /*0x18*/ int qnameCount;
                /*0x1c*/ bool topLevelElement;
                /*0x20*/ System.Collections.ArrayList namespaces;
                /*0x28*/ System.Xml.XmlWriter writer;
                /*0x30*/ System.Collections.Queue referencedElements;
                /*0x38*/ System.Collections.Hashtable callbacks;
                /*0x40*/ System.Collections.Hashtable serializedObjects;

                /*0x77b8280*/ XmlSerializationWriter();
                /*0x77b82f0*/ void Initialize(System.Xml.XmlWriter writer, System.Xml.Serialization.XmlSerializerNamespaces nss);
                /*0x77b8420*/ System.Xml.XmlWriter get_Writer();
                /*0x77b8428*/ void AddWriteCallback(System.Type type, string typeName, string typeNs, System.Xml.Serialization.XmlSerializationWriteCallback callback);
                /*0x77b8540*/ System.Exception CreateUnknownAnyElementException(string name, string ns);
                /*0x77b85d8*/ System.Exception CreateUnknownTypeException(object o);
                /*0x77b85fc*/ System.Exception CreateUnknownTypeException(System.Type type);
                /*0x77b868c*/ string FromXmlQualifiedName(System.Xml.XmlQualifiedName xmlQualifiedName);
                /*0x77b880c*/ string GetId(object o, bool addToReferencesList);
                /*0x77b8920*/ bool AlreadyQueued(object ob);
                /*0x77b8954*/ string GetNamespacePrefix(string ns);
                /*0x77b874c*/ string GetQualifiedName(string name, string ns);
                /*0x38159dc*/ void InitCallbacks();
                /*0x77b8a8c*/ void TopLevelElement();
                /*0x77b8a98*/ void WriteAttribute(string localName, string ns, string value);
                /*0x77b8a64*/ void WriteAttribute(string prefix, string localName, string ns, string value);
                /*0x77b8aac*/ void WriteXmlNode(System.Xml.XmlNode node);
                /*0x77b8b4c*/ void WriteElementEncoded(System.Xml.XmlNode node, string name, string ns, bool isNullable, bool any);
                /*0x77b8d00*/ void WriteElementLiteral(System.Xml.XmlNode node, string name, string ns, bool isNullable, bool any);
                /*0x77b8eb8*/ void WriteElementQualifiedName(string localName, string ns, System.Xml.XmlQualifiedName value);
                /*0x77b8ec0*/ void WriteElementQualifiedName(string localName, string ns, System.Xml.XmlQualifiedName value, System.Xml.XmlQualifiedName xsiType);
                /*0x77b90c0*/ void WriteElementString(string localName, string ns, string value);
                /*0x77b90c8*/ void WriteElementString(string localName, string ns, string value, System.Xml.XmlQualifiedName xsiType);
                /*0x77b90a0*/ void WriteEndElement();
                /*0x77b9218*/ void WriteEndElement(object o);
                /*0x77b9258*/ void WriteNamespaceDeclarations(System.Xml.Serialization.XmlSerializerNamespaces xmlns);
                /*0x77b9678*/ void WriteNullableQualifiedNameEncoded(string name, string ns, System.Xml.XmlQualifiedName value, System.Xml.XmlQualifiedName xsiType);
                /*0x77b9730*/ void WriteNullableQualifiedNameLiteral(string name, string ns, System.Xml.XmlQualifiedName value);
                /*0x77b97e4*/ void WriteNullableStringEncoded(string name, string ns, string value, System.Xml.XmlQualifiedName xsiType);
                /*0x77b97f0*/ void WriteNullableStringLiteral(string name, string ns, string value);
                /*0x77b8c40*/ void WriteNullTagEncoded(string name, string ns);
                /*0x77b8df4*/ void WriteNullTagLiteral(string name, string ns);
                /*0x77b9800*/ void WritePotentiallyReferencingElement(string n, string ns, object o, System.Type ambientType, bool suppressReference, bool isNullable);
                /*0x77b9dd4*/ void WriteReferencedElements();
                /*0x77b9d14*/ bool IsPrimitiveArray(System.Xml.Serialization.TypeData td);
                /*0x77b9ff0*/ void WriteArray(object o, System.Xml.Serialization.TypeData td);
                /*0x77ba2e0*/ void WriteReferencingElement(string n, string ns, object o, bool isNullable);
                /*0x77b9c8c*/ void CheckReferenceQueue();
                /*0x77ba43c*/ void WriteSerializable(System.Xml.Serialization.IXmlSerializable serializable, string name, string ns, bool isNullable);
                /*0x77ba448*/ void WriteSerializable(System.Xml.Serialization.IXmlSerializable serializable, string name, string ns, bool isNullable, bool wrapped);
                /*0x77ba5fc*/ void WriteStartDocument();
                /*0x77b8fdc*/ void WriteStartElement(string name, string ns);
                /*0x77b9c7c*/ void WriteStartElement(string name, string ns, bool writePrefixed);
                /*0x77ba650*/ void WriteStartElement(string name, string ns, object o);
                /*0x77ba644*/ void WriteStartElement(string name, string ns, object o, bool writePrefixed);
                /*0x77ba65c*/ void WriteStartElement(string name, string ns, object o, bool writePrefixed, System.Collections.ICollection namespaces);
                /*0x77baf50*/ void WriteTypedPrimitive(string name, string ns, object o, bool xsiType);
                /*0x77bb21c*/ void WriteValue(string value);
                /*0x77bb24c*/ void WriteXmlAttribute(System.Xml.XmlNode node, object container);
                /*0x77b8fec*/ void WriteXsiType(string name, string ns);

                class WriteCallbackInfo
                {
                    /*0x10*/ System.Type Type;
                    /*0x18*/ string TypeName;
                    /*0x20*/ string TypeNs;
                    /*0x28*/ System.Xml.Serialization.XmlSerializationWriteCallback Callback;

                    /*0x77bb4cc*/ WriteCallbackInfo();
                }
            }

            class XmlSerializationWriterInterpreter : System.Xml.Serialization.XmlSerializationWriter
            {
                /*0x48*/ System.Xml.Serialization.XmlMapping _typeMap;
                /*0x50*/ System.Xml.Serialization.SerializationFormat _format;

                static /*0x77bc360*/ object ImplicitConvert(object obj, System.Type type);
                /*0x77bb4d4*/ XmlSerializationWriterInterpreter(System.Xml.Serialization.XmlMapping typeMap);
                /*0x77bb518*/ void InitCallbacks();
                /*0x77bb978*/ void WriteRoot(object ob);
                /*0x77bbb8c*/ void WriteObject(System.Xml.Serialization.XmlTypeMapping typeMap, object ob, string element, string namesp, bool isNullable, bool needType, bool writeWrappingElem);
                /*0x77bc7bc*/ void WriteMessage(System.Xml.Serialization.XmlMembersMapping membersMap, object[] parameters);
                /*0x77bc9f0*/ void WriteObjectElement(System.Xml.Serialization.XmlTypeMapping typeMap, object ob, string element, string namesp);
                /*0x77bcc28*/ void WriteObjectElementAttributes(System.Xml.Serialization.XmlTypeMapping typeMap, object ob);
                /*0x77bd42c*/ void WriteObjectElementElements(System.Xml.Serialization.XmlTypeMapping typeMap, object ob);
                /*0x77bc9ac*/ void WriteMembers(System.Xml.Serialization.ClassMap map, object ob, bool isValueList);
                /*0x77bcccc*/ void WriteAttributeMembers(System.Xml.Serialization.ClassMap map, object ob, bool isValueList);
                /*0x77bd4d0*/ void WriteElementMembers(System.Xml.Serialization.ClassMap map, object ob, bool isValueList);
                /*0x77bde3c*/ object GetMemberValue(System.Xml.Serialization.XmlTypeMapMember member, object ob, bool isValueList);
                /*0x77bdc20*/ bool MemberHasValue(System.Xml.Serialization.XmlTypeMapMember member, object ob, bool isValueList);
                /*0x77be5d8*/ void WriteMemberElement(System.Xml.Serialization.XmlTypeMapElementInfo elem, object memberValue);
                /*0x77c02a4*/ void WritePrimitiveValueLiteral(object memberValue, string name, string ns, System.Xml.Serialization.XmlTypeMapping mappedType, System.Xml.Serialization.TypeData typeData, bool wrapped, bool isNullable);
                /*0x77c0580*/ void WritePrimitiveValueEncoded(object memberValue, string name, string ns, System.Xml.XmlQualifiedName xsiType, System.Xml.Serialization.XmlTypeMapping mappedType, System.Xml.Serialization.TypeData typeData, bool wrapped, bool isNullable);
                /*0x77c07f0*/ void WriteListElement(System.Xml.Serialization.XmlTypeMapping typeMap, object ob, string element, string namesp);
                /*0x77beb30*/ void WriteListContent(object container, System.Xml.Serialization.TypeData listType, System.Xml.Serialization.ListMap map, object ob, System.Text.StringBuilder targetString);
                /*0x77c09d0*/ int GetListCount(System.Xml.Serialization.TypeData listType, object ob);
                /*0x77bf32c*/ void WriteAnyElementContent(System.Xml.Serialization.XmlTypeMapMemberAnyElement member, object memberValue);
                /*0x77c18ac*/ void WritePrimitiveElement(System.Xml.Serialization.XmlTypeMapping typeMap, object ob, string element, string namesp);
                /*0x77c18e8*/ void WriteEnumElement(System.Xml.Serialization.XmlTypeMapping typeMap, object ob, string element, string namesp);
                /*0x77be32c*/ string GetStringValue(System.Xml.Serialization.XmlTypeMapping typeMap, System.Xml.Serialization.TypeData type, object value);
                /*0x77c1918*/ string GetEnumXmlValue(System.Xml.Serialization.XmlTypeMapping typeMap, object ob);

                class CallbackInfo
                {
                    /*0x10*/ System.Xml.Serialization.XmlSerializationWriterInterpreter _swi;
                    /*0x18*/ System.Xml.Serialization.XmlTypeMapping _typeMap;

                    /*0x77bb934*/ CallbackInfo(System.Xml.Serialization.XmlSerializationWriterInterpreter swi, System.Xml.Serialization.XmlTypeMapping typeMap);
                    /*0x77c1d3c*/ void WriteObject(object ob);
                    /*0x77c1d8c*/ void WriteEnum(object ob);
                }
            }

            class XmlSerializer
            {
                static /*0x0*/ int generationThreshold;
                static /*0x4*/ bool backgroundGeneration;
                static /*0x5*/ bool deleteTempFiles;
                static /*0x6*/ bool generatorFallback;
                static /*0x8*/ System.Collections.Hashtable serializerTypes;
                /*0x10*/ bool customSerializer;
                /*0x18*/ System.Xml.Serialization.XmlMapping typeMapping;
                /*0x20*/ System.Xml.Serialization.XmlSerializer.SerializerData serializerData;
                /*0x28*/ System.Xml.Serialization.UnreferencedObjectEventHandler onUnreferencedObject;
                /*0x30*/ System.Xml.Serialization.XmlAttributeEventHandler onUnknownAttribute;
                /*0x38*/ System.Xml.Serialization.XmlElementEventHandler onUnknownElement;
                /*0x40*/ System.Xml.Serialization.XmlNodeEventHandler onUnknownNode;

                static /*0x77c1ddc*/ XmlSerializer();
                /*0x77c1e90*/ XmlSerializer(System.Type type, System.Xml.Serialization.XmlAttributeOverrides overrides, System.Type[] extraTypes, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0x77c2014*/ System.Xml.Serialization.XmlMapping get_Mapping();
                /*0x77c201c*/ void OnUnknownAttribute(System.Xml.Serialization.XmlAttributeEventArgs e);
                /*0x77c2044*/ void OnUnknownElement(System.Xml.Serialization.XmlElementEventArgs e);
                /*0x77c206c*/ void OnUnknownNode(System.Xml.Serialization.XmlNodeEventArgs e);
                /*0x77c2094*/ void OnUnreferencedObject(System.Xml.Serialization.UnreferencedObjectEventArgs e);
                /*0x77c20bc*/ System.Xml.Serialization.XmlSerializationReader CreateReader();
                /*0x77c20f4*/ System.Xml.Serialization.XmlSerializationWriter CreateWriter();
                /*0x77c212c*/ object Deserialize(System.IO.TextReader textReader);
                /*0x77c21c0*/ object Deserialize(System.Xml.XmlReader xmlReader);
                /*0x77c228c*/ object Deserialize(System.Xml.Serialization.XmlSerializationReader reader);
                /*0x77c2570*/ void Serialize(object o, System.Xml.Serialization.XmlSerializationWriter writer);
                /*0x77c2768*/ void Serialize(System.IO.TextWriter textWriter, object o);
                /*0x77c2b04*/ void Serialize(System.Xml.XmlWriter xmlWriter, object o);
                /*0x77c27f8*/ void Serialize(System.Xml.XmlWriter xmlWriter, object o, System.Xml.Serialization.XmlSerializerNamespaces namespaces);
                /*0x77c2b0c*/ System.Xml.Serialization.XmlSerializationWriter CreateWriter(System.Xml.Serialization.XmlMapping typeMapping);
                /*0x77c2230*/ System.Xml.Serialization.XmlSerializationReader CreateReader(System.Xml.Serialization.XmlMapping typeMapping);

                class SerializerData
                {
                    /*0x10*/ System.Reflection.MethodInfo ReaderMethod;
                    /*0x18*/ System.Type WriterType;
                    /*0x20*/ System.Reflection.MethodInfo WriterMethod;
                    /*0x28*/ System.Xml.Serialization.XmlSerializerImplementation Implementation;

                    /*0x77c2d10*/ System.Xml.Serialization.XmlSerializationWriter CreateWriter();
                }
            }

            class XmlSerializerFactory
            {
                static /*0x0*/ System.Collections.Hashtable serializersBySource;

                static /*0x77c307c*/ XmlSerializerFactory();
                /*0x77c2ddc*/ XmlSerializerFactory();
                /*0x77c2de4*/ System.Xml.Serialization.XmlSerializer CreateSerializer(System.Type type);
                /*0x77c3068*/ System.Xml.Serialization.XmlSerializer CreateSerializer(System.Type type, System.Xml.Serialization.XmlRootAttribute root);
                /*0x77c2df8*/ System.Xml.Serialization.XmlSerializer CreateSerializer(System.Type type, System.Xml.Serialization.XmlAttributeOverrides overrides, System.Type[] extraTypes, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
            }

            class XmlSerializerImplementation
            {
                /*0x77c30f8*/ System.Xml.Serialization.XmlSerializationWriter get_Writer();
            }

            class XmlTextAttribute : System.Attribute
            {
                /*0x10*/ string dataType;
                /*0x18*/ System.Type type;

                /*0x77c3130*/ XmlTextAttribute();
                /*0x77c3138*/ string get_DataType();
                /*0x77c315c*/ System.Type get_Type();
                /*0x77c3164*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlTypeAttribute : System.Attribute
            {
                /*0x10*/ bool includeInSchema;
                /*0x18*/ string ns;
                /*0x20*/ string typeName;

                /*0x77c31f4*/ bool get_IncludeInSchema();
                /*0x77c31fc*/ string get_Namespace();
                /*0x77c3204*/ string get_TypeName();
                /*0x77c3228*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlTypeMapElementInfo
            {
                /*0x10*/ string _elementName;
                /*0x18*/ string _namespace;
                /*0x20*/ System.Xml.Schema.XmlSchemaForm _form;
                /*0x28*/ System.Xml.Serialization.XmlTypeMapMember _member;
                /*0x30*/ object _choiceValue;
                /*0x38*/ bool _isNullable;
                /*0x3c*/ int _nestingLevel;
                /*0x40*/ System.Xml.Serialization.XmlTypeMapping _mappedType;
                /*0x48*/ System.Xml.Serialization.TypeData _type;
                /*0x50*/ bool _wrappedElement;
                /*0x54*/ int _explicitOrder;

                /*0x77c32cc*/ XmlTypeMapElementInfo(System.Xml.Serialization.XmlTypeMapMember member, System.Xml.Serialization.TypeData type);
                /*0x77c3398*/ System.Xml.Serialization.TypeData get_TypeData();
                /*0x77c33a0*/ object get_ChoiceValue();
                /*0x77c33a8*/ void set_ChoiceValue(object value);
                /*0x77c33b0*/ string get_ElementName();
                /*0x77c33b8*/ void set_ElementName(string value);
                /*0x77c33c0*/ string get_Namespace();
                /*0x77c33c8*/ void set_Namespace(string value);
                /*0x77c0518*/ string get_DataTypeNamespace();
                /*0x77c04e8*/ string get_DataTypeName();
                /*0x77c33d0*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0x77c33d8*/ void set_Form(System.Xml.Schema.XmlSchemaForm value);
                /*0x77c33e0*/ System.Xml.Serialization.XmlTypeMapping get_MappedType();
                /*0x77c33e8*/ void set_MappedType(System.Xml.Serialization.XmlTypeMapping value);
                /*0x77c33f0*/ bool get_IsNullable();
                /*0x77c33f8*/ void set_IsNullable(bool value);
                /*0x77c3404*/ System.Xml.Serialization.XmlTypeMapMember get_Member();
                /*0x77c340c*/ void set_NestingLevel(int value);
                /*0x77c3414*/ bool get_MultiReferenceType();
                /*0x77c3434*/ bool get_WrappedElement();
                /*0x77c343c*/ void set_WrappedElement(bool value);
                /*0x77c3448*/ bool get_IsTextElement();
                /*0x77c3494*/ void set_IsTextElement(bool value);
                /*0x77c3550*/ bool get_IsUnnamedAnyElement();
                /*0x77c3570*/ void set_IsUnnamedAnyElement(bool value);
                /*0x77c3604*/ int get_ExplicitOrder();
                /*0x77c360c*/ void set_ExplicitOrder(int value);
                /*0x77c3614*/ bool Equals(object other);
                /*0x77c374c*/ int GetHashCode();
            }

            class XmlTypeMapElementInfoList : System.Collections.ArrayList
            {
                /*0x77c3754*/ XmlTypeMapElementInfoList();
            }

            class XmlTypeMapMember
            {
                /*0x10*/ string _name;
                /*0x18*/ int _index;
                /*0x1c*/ int _globalIndex;
                /*0x20*/ int _specifiedGlobalIndex;
                /*0x28*/ System.Xml.Serialization.TypeData _typeData;
                /*0x30*/ System.Reflection.MemberInfo _member;
                /*0x38*/ System.Reflection.MemberInfo _specifiedMember;
                /*0x40*/ System.Reflection.MethodInfo _shouldSerialize;
                /*0x48*/ object _defaultValue;
                /*0x50*/ int _flags;

                static /*0x77c3afc*/ object GetValue(object ob, string name);
                static /*0x77c3d4c*/ void SetValue(object ob, string name, object value);
                /*0x77c375c*/ XmlTypeMapMember();
                /*0x77c37d4*/ string get_Name();
                /*0x77c37dc*/ void set_Name(string value);
                /*0x77c37e4*/ object get_DefaultValue();
                /*0x77c37ec*/ void set_DefaultValue(object value);
                /*0x77c37f4*/ bool IsReadOnly(System.Type type);
                /*0x77bcb18*/ object GetValue(object ob);
                /*0x77c3c18*/ void SetValue(object ob, object value);
                /*0x77c38a8*/ void InitMember(System.Type type);
                /*0x77c3e7c*/ System.Xml.Serialization.TypeData get_TypeData();
                /*0x77c3e84*/ void set_TypeData(System.Xml.Serialization.TypeData value);
                /*0x77c3e8c*/ int get_Index();
                /*0x77c3e94*/ void set_Index(int value);
                /*0x77c3e9c*/ int get_GlobalIndex();
                /*0x77c3ea4*/ void set_GlobalIndex(int value);
                /*0x77c006c*/ bool get_IsOptionalValueType();
                /*0x77c3eac*/ void set_IsOptionalValueType(bool value);
                /*0x77c3ecc*/ bool get_IsReturnValue();
                /*0x77c3ed8*/ void set_IsReturnValue(bool value);
                /*0x77c3f08*/ void CheckOptionalValueType(System.Type type);
                /*0x77c0078*/ bool GetValueSpecified(object ob);
                /*0x77c3f84*/ void SetValueSpecified(object ob, bool value);
            }

            class XmlTypeMapMemberAttribute : System.Xml.Serialization.XmlTypeMapMember
            {
                /*0x58*/ string _attributeName;
                /*0x60*/ string _namespace;
                /*0x68*/ System.Xml.Schema.XmlSchemaForm _form;
                /*0x70*/ System.Xml.Serialization.XmlTypeMapping _mappedType;

                /*0x77c41fc*/ XmlTypeMapMemberAttribute();
                /*0x77c4250*/ string get_AttributeName();
                /*0x77c4258*/ void set_AttributeName(string value);
                /*0x77c4260*/ string get_Namespace();
                /*0x77c4268*/ void set_Namespace(string value);
                /*0x77c4270*/ void set_Form(System.Xml.Schema.XmlSchemaForm value);
                /*0x77c4278*/ System.Xml.Serialization.XmlTypeMapping get_MappedType();
                /*0x77c4280*/ void set_MappedType(System.Xml.Serialization.XmlTypeMapping value);
            }

            class XmlTypeMapMemberElement : System.Xml.Serialization.XmlTypeMapMember
            {
                /*0x58*/ System.Xml.Serialization.XmlTypeMapElementInfoList _elementInfo;
                /*0x60*/ string _choiceMember;
                /*0x68*/ bool _isTextCollector;
                /*0x70*/ System.Xml.Serialization.TypeData _choiceTypeData;

                /*0x77c4288*/ XmlTypeMapMemberElement();
                /*0x77be568*/ System.Xml.Serialization.XmlTypeMapElementInfoList get_ElementInfo();
                /*0x77c428c*/ void set_ElementInfo(System.Xml.Serialization.XmlTypeMapElementInfoList value);
                /*0x77c4294*/ string get_ChoiceMember();
                /*0x77c429c*/ void set_ChoiceMember(string value);
                /*0x77c42a4*/ System.Xml.Serialization.TypeData get_ChoiceTypeData();
                /*0x77c42ac*/ void set_ChoiceTypeData(System.Xml.Serialization.TypeData value);
                /*0x77bf970*/ System.Xml.Serialization.XmlTypeMapElementInfo FindElement(object ob, object memberValue);
                /*0x77c42b4*/ void SetChoice(object ob, object choice);
                /*0x77c42c4*/ bool get_IsXmlTextCollector();
                /*0x77c42cc*/ void set_IsXmlTextCollector(bool value);
            }

            class XmlTypeMapMemberList : System.Xml.Serialization.XmlTypeMapMemberElement
            {
                /*0x77c42d8*/ XmlTypeMapMemberList();
            }

            class XmlTypeMapMemberExpandable : System.Xml.Serialization.XmlTypeMapMemberElement
            {
                /*0x78*/ int _flatArrayIndex;

                /*0x77c42ec*/ XmlTypeMapMemberExpandable();
                /*0x77c42dc*/ int get_FlatArrayIndex();
                /*0x77c42e4*/ void set_FlatArrayIndex(int value);
            }

            class XmlTypeMapMemberFlatList : System.Xml.Serialization.XmlTypeMapMemberExpandable
            {
                /*0x80*/ System.Xml.Serialization.ListMap _listMap;

                /*0x77c4300*/ XmlTypeMapMemberFlatList();
                /*0x77c42f0*/ System.Xml.Serialization.ListMap get_ListMap();
                /*0x77c42f8*/ void set_ListMap(System.Xml.Serialization.ListMap value);
            }

            class XmlTypeMapMemberAnyElement : System.Xml.Serialization.XmlTypeMapMemberExpandable
            {
                /*0x77c460c*/ XmlTypeMapMemberAnyElement();
                /*0x77c1558*/ bool IsElementDefined(string name, string ns);
                /*0x77c4304*/ bool get_IsDefaultAny();
            }

            class XmlTypeMapMemberAnyAttribute : System.Xml.Serialization.XmlTypeMapMember
            {
                /*0x77c4610*/ XmlTypeMapMemberAnyAttribute();
            }

            class XmlTypeMapMemberNamespaces : System.Xml.Serialization.XmlTypeMapMember
            {
                /*0x77c4614*/ XmlTypeMapMemberNamespaces();
            }

            class XmlTypeMapping : System.Xml.Serialization.XmlMapping
            {
                /*0x48*/ string xmlType;
                /*0x50*/ string xmlTypeNamespace;
                /*0x58*/ System.Xml.Serialization.TypeData type;
                /*0x60*/ System.Xml.Serialization.XmlTypeMapping baseMap;
                /*0x68*/ bool multiReferenceType;
                /*0x69*/ bool includeInSchema;
                /*0x6a*/ bool isNullable;
                /*0x6b*/ bool isAny;
                /*0x70*/ System.Collections.ArrayList _derivedTypes;

                /*0x77c4618*/ XmlTypeMapping(string elementName, string ns, System.Xml.Serialization.TypeData typeData, string xmlType, string xmlTypeNamespace);
                /*0x77c19c0*/ string get_TypeFullName();
                /*0x77c46f0*/ System.Xml.Serialization.TypeData get_TypeData();
                /*0x77c46f8*/ string get_XmlType();
                /*0x77c4700*/ void set_XmlType(string value);
                /*0x77bc798*/ string get_XmlTypeNamespace();
                /*0x77c4708*/ void set_XmlTypeNamespace(string value);
                /*0x77c4710*/ bool get_HasXmlTypeNamespace();
                /*0x77c4720*/ System.Collections.ArrayList get_DerivedTypes();
                /*0x77c4728*/ bool get_MultiReferenceType();
                /*0x77c4730*/ System.Xml.Serialization.XmlTypeMapping get_BaseMap();
                /*0x77c4738*/ void set_BaseMap(System.Xml.Serialization.XmlTypeMapping value);
                /*0x77c4740*/ void set_IncludeInSchema(bool value);
                /*0x77c474c*/ bool get_IsNullable();
                /*0x77c4754*/ void set_IsNullable(bool value);
                /*0x77c4760*/ bool get_IsAny();
                /*0x77c4768*/ void set_IsAny(bool value);
                /*0x77bc634*/ System.Xml.Serialization.XmlTypeMapping GetRealTypeMap(System.Type objectType);
                /*0x77c4774*/ System.Xml.Serialization.XmlTypeMapping GetRealElementMap(string name, string ens);
                /*0x77c4af0*/ void UpdateRoot(System.Xml.XmlQualifiedName qname);
            }

            class XmlSerializableMapping : System.Xml.Serialization.XmlTypeMapping
            {
                /*0x78*/ System.Xml.Schema.XmlSchema _schema;
                /*0x80*/ System.Xml.Schema.XmlSchemaComplexType _schemaType;
                /*0x88*/ System.Xml.XmlQualifiedName _schemaTypeName;

                /*0x77c4b94*/ XmlSerializableMapping(System.Xml.Serialization.XmlRootAttribute root, string elementName, string ns, System.Xml.Serialization.TypeData typeData, string xmlType, string xmlTypeNamespace);
            }

            class ClassMap : System.Xml.Serialization.ObjectMap
            {
                /*0x10*/ System.Collections.Hashtable _elements;
                /*0x18*/ System.Collections.ArrayList _elementMembers;
                /*0x20*/ System.Collections.Hashtable _attributeMembers;
                /*0x28*/ System.Xml.Serialization.XmlTypeMapMemberAttribute[] _attributeMembersArray;
                /*0x30*/ System.Collections.ArrayList _flatLists;
                /*0x38*/ System.Collections.ArrayList _allMembers;
                /*0x40*/ System.Collections.ArrayList _membersWithDefault;
                /*0x48*/ System.Collections.ArrayList _listMembers;
                /*0x50*/ System.Xml.Serialization.XmlTypeMapMemberAnyElement _defaultAnyElement;
                /*0x58*/ System.Xml.Serialization.XmlTypeMapMemberAnyAttribute _defaultAnyAttribute;
                /*0x60*/ System.Xml.Serialization.XmlTypeMapMemberNamespaces _namespaceDeclarations;
                /*0x68*/ System.Xml.Serialization.XmlTypeMapMember _xmlTextCollector;
                /*0x70*/ System.Xml.Serialization.XmlTypeMapMember _returnMember;
                /*0x78*/ bool _ignoreMemberNamespace;
                /*0x79*/ bool _canBeSimpleType;
                /*0x7a*/ System.Nullable<bool> _isOrderDependentMap;

                /*0x77c6f7c*/ ClassMap();
                /*0x77c5384*/ void AddMember(System.Xml.Serialization.XmlTypeMapMember member);
                /*0x77c6040*/ void RegisterFlatList(System.Xml.Serialization.XmlTypeMapMemberExpandable member);
                /*0x77c60ec*/ System.Xml.Serialization.XmlTypeMapMemberAttribute GetAttribute(string name, string ns);
                /*0x77c61a8*/ System.Xml.Serialization.XmlTypeMapElementInfo GetElement(string name, string ns, int minimalOrder);
                /*0x77c6570*/ System.Xml.Serialization.XmlTypeMapElementInfo GetElement(string name, string ns);
                /*0x77c5f60*/ string BuildKey(string name, string ns, int explicitOrder);
                /*0x77c6908*/ bool get_IsOrderDependentMap();
                /*0x77c6ce8*/ System.Xml.Serialization.XmlTypeMapMemberAnyElement get_DefaultAnyElementMember();
                /*0x77c6cf0*/ System.Xml.Serialization.XmlTypeMapMemberAnyAttribute get_DefaultAnyAttributeMember();
                /*0x77c6cf8*/ System.Xml.Serialization.XmlTypeMapMemberNamespaces get_NamespaceDeclarations();
                /*0x77bdf04*/ System.Collections.ICollection get_AttributeMembers();
                /*0x77c6d00*/ System.Collections.ICollection get_ElementMembers();
                /*0x77c6d08*/ System.Collections.ArrayList get_AllMembers();
                /*0x77c6d10*/ System.Collections.ArrayList get_FlatLists();
                /*0x77c6d18*/ System.Collections.ArrayList get_ListMembers();
                /*0x77c6d20*/ System.Xml.Serialization.XmlTypeMapMember get_XmlTextCollector();
                /*0x77c6d28*/ System.Xml.Serialization.XmlTypeMapMember get_ReturnMember();
                /*0x77c6d30*/ System.Xml.XmlQualifiedName get_SimpleContentBaseType();
                /*0x77c6f04*/ void SetCanBeSimpleType(bool can);
                /*0x77c6f10*/ bool get_HasSimpleContent();
            }

            class ListMap : System.Xml.Serialization.ObjectMap
            {
                /*0x10*/ System.Xml.Serialization.XmlTypeMapElementInfoList _itemInfo;
                /*0x18*/ string _choiceMember;

                /*0x77c77bc*/ ListMap();
                /*0x77c7030*/ void set_ChoiceMember(string value);
                /*0x77c7038*/ System.Xml.Serialization.XmlTypeMapElementInfoList get_ItemInfo();
                /*0x77c7040*/ void set_ItemInfo(System.Xml.Serialization.XmlTypeMapElementInfoList value);
                /*0x77c0d10*/ System.Xml.Serialization.XmlTypeMapElementInfo FindElement(object ob, int index, object memberValue);
                /*0x77c7048*/ System.Xml.Serialization.XmlTypeMapElementInfo FindElement(string elementName, string ns);
                /*0x77c7364*/ System.Xml.Serialization.XmlTypeMapElementInfo FindTextElement();
                /*0x77c0ae0*/ void GetArrayType(int itemCount, ref string localName, ref string ns);
                /*0x77c7650*/ bool Equals(object other);
                /*0x77c77b4*/ int GetHashCode();
            }

            class EnumMap : System.Xml.Serialization.ObjectMap
            {
                /*0x10*/ System.Xml.Serialization.EnumMap.EnumMapMember[] _members;
                /*0x18*/ bool _isFlags;
                /*0x20*/ string[] _enumNames;
                /*0x28*/ string[] _xmlNames;
                /*0x30*/ long[] _values;

                /*0x77c77c4*/ EnumMap(System.Xml.Serialization.EnumMap.EnumMapMember[] members, bool isFlags);
                /*0x77c796c*/ bool get_IsFlags();
                /*0x77c7974*/ string[] get_EnumNames();
                /*0x77c797c*/ string[] get_XmlNames();
                /*0x77c7984*/ long[] get_Values();
                /*0x77c19dc*/ string GetXmlName(string typeName, object enumValue);
                /*0x77c798c*/ string GetEnumName(string typeName, string xmlName);

                class EnumMapMember
                {
                    /*0x10*/ string _xmlName;
                    /*0x18*/ string _enumName;
                    /*0x20*/ long _value;

                    /*0x77c7c5c*/ EnumMapMember(string xmlName, string enumName, long value);
                    /*0x77c7cb4*/ string get_XmlName();
                    /*0x77c7cbc*/ string get_EnumName();
                    /*0x77c7cc4*/ long get_Value();
                }
            }
        }

        namespace XmlConfiguration
        {
            class XmlReaderSection
            {
                static /*0x77c7ccc*/ bool get_ProhibitDefaultUrlResolver();
                static /*0x77c7cd4*/ System.Xml.XmlResolver CreateDefaultResolver();
                static /*0x77c7d28*/ bool get_CollapseWhiteSpaceIntoEmptyString();
            }
        }

        namespace Xsl
        {
            namespace Runtime
            {
                struct StringConcat
                {
                    /*0x10*/ string s1;
                    /*0x18*/ string s2;
                    /*0x20*/ string s3;
                    /*0x28*/ string s4;
                    /*0x30*/ string delimiter;
                    /*0x38*/ System.Collections.Generic.List<string> strList;
                    /*0x40*/ int idxStr;

                    /*0x77c7d30*/ void Clear();
                    /*0x77c7d40*/ int get_Count();
                    /*0x77c7d48*/ string GetResult();
                    /*0x77c7e30*/ void ConcatNoDelimiter(string s);
                }
            }
        }

        namespace Schema
        {
            class AxisElement
            {
                /*0x10*/ System.Xml.Schema.DoubleLinkAxis curNode;
                /*0x18*/ int rootDepth;
                /*0x1c*/ int curDepth;
                /*0x20*/ bool isMatch;

                /*0x77c812c*/ AxisElement(System.Xml.Schema.DoubleLinkAxis node, int depth);
                /*0x77c8124*/ System.Xml.Schema.DoubleLinkAxis get_CurNode();
                /*0x77c816c*/ void SetDepth(int depth);
                /*0x77c8174*/ void MoveToParent(int depth, System.Xml.Schema.ForwardAxis parent);
                /*0x77c82a0*/ bool MoveToChild(string name, string URN, int depth, System.Xml.Schema.ForwardAxis parent);
            }

            class AxisStack
            {
                /*0x10*/ System.Collections.ArrayList _stack;
                /*0x18*/ System.Xml.Schema.ForwardAxis _subtree;
                /*0x20*/ System.Xml.Schema.ActiveAxis _parent;

                static /*0x77c8448*/ bool Equal(string thisname, string thisURN, string name, string URN);
                /*0x77c84f0*/ AxisStack(System.Xml.Schema.ForwardAxis faxis, System.Xml.Schema.ActiveAxis parent);
                /*0x77c84c4*/ System.Xml.Schema.ForwardAxis get_Subtree();
                /*0x77c84cc*/ int get_Length();
                /*0x77c85b8*/ void Push(int depth);
                /*0x77c8658*/ void Pop();
                /*0x77c8698*/ void MoveToParent(string name, string URN, int depth);
                /*0x77c87e0*/ bool MoveToChild(string name, string URN, int depth);
                /*0x77c8920*/ bool MoveToAttribute(string name, string URN, int depth);
            }

            class ActiveAxis
            {
                /*0x10*/ int _currentDepth;
                /*0x14*/ bool _isActive;
                /*0x18*/ System.Xml.Schema.Asttree _axisTree;
                /*0x20*/ System.Collections.ArrayList _axisStack;

                /*0x77c8ab0*/ ActiveAxis(System.Xml.Schema.Asttree axisTree);
                /*0x77c8a94*/ int get_CurrentDepth();
                /*0x77c8a9c*/ void Reactivate();
                /*0x77c8c70*/ bool MoveToStartElement(string localname, string URN);
                /*0x77c8db0*/ bool EndElement(string localname, string URN);
                /*0x77c8ec0*/ bool MoveToAttribute(string localname, string URN);
            }

            class DoubleLinkAxis : MS.Internal.Xml.XPath.Axis
            {
                /*0x40*/ MS.Internal.Xml.XPath.Axis next;

                static /*0x77c906c*/ System.Xml.Schema.DoubleLinkAxis ConvertTree(MS.Internal.Xml.XPath.Axis axis);
                /*0x77c8fdc*/ DoubleLinkAxis(MS.Internal.Xml.XPath.Axis axis, System.Xml.Schema.DoubleLinkAxis inputaxis);
                /*0x77c8fcc*/ MS.Internal.Xml.XPath.Axis get_Next();
                /*0x77c8fd4*/ void set_Next(MS.Internal.Xml.XPath.Axis value);
            }

            class ForwardAxis
            {
                /*0x10*/ System.Xml.Schema.DoubleLinkAxis _topNode;
                /*0x18*/ System.Xml.Schema.DoubleLinkAxis _rootNode;
                /*0x20*/ bool _isAttribute;
                /*0x21*/ bool _isDss;
                /*0x22*/ bool _isSelfAxis;

                /*0x77c9154*/ ForwardAxis(System.Xml.Schema.DoubleLinkAxis axis, bool isdesorself);
                /*0x77c912c*/ System.Xml.Schema.DoubleLinkAxis get_RootNode();
                /*0x77c9134*/ System.Xml.Schema.DoubleLinkAxis get_TopNode();
                /*0x77c913c*/ bool get_IsAttribute();
                /*0x77c9144*/ bool get_IsDss();
                /*0x77c914c*/ bool get_IsSelfAxis();
            }

            class Asttree
            {
                /*0x10*/ System.Collections.ArrayList _fAxisArray;
                /*0x18*/ string _xpathexpr;
                /*0x20*/ bool _isField;
                /*0x28*/ System.Xml.XmlNamespaceManager _nsmgr;

                static /*0x77c9b64*/ bool IsNameTest(MS.Internal.Xml.XPath.Axis ast);
                static /*0x77c8414*/ bool IsAttribute(MS.Internal.Xml.XPath.Axis ast);
                static /*0x77c9b98*/ bool IsDescendantOrSelf(MS.Internal.Xml.XPath.Axis ast);
                static /*0x77c92bc*/ bool IsSelf(MS.Internal.Xml.XPath.Axis ast);
                /*0x77c9304*/ Asttree(string xPath, bool isField, System.Xml.XmlNamespaceManager nsmgr);
                /*0x77c92fc*/ System.Collections.ArrayList get_SubtreeArray();
                /*0x77c9370*/ void CompileXPath(string xPath, bool isField, System.Xml.XmlNamespaceManager nsmgr);
                /*0x77c9bd8*/ void SetURN(MS.Internal.Xml.XPath.Axis axis, System.Xml.XmlNamespaceManager nsmgr);
            }

            class AutoValidator : System.Xml.Schema.BaseValidator
            {
                /*0x77c9cf8*/ AutoValidator(System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling);
                /*0x77c9e80*/ bool get_PreserveWhitespace();
                /*0x77c9e88*/ void Validate();
                /*0x77ca2b4*/ void CompleteValidation();
                /*0x77ca2b8*/ object FindId(string name);
                /*0x77c9f70*/ System.Xml.ValidationType DetectValidationType();
            }

            class BaseProcessor
            {
                /*0x10*/ System.Xml.XmlNameTable nameTable;
                /*0x18*/ System.Xml.Schema.SchemaNames schemaNames;
                /*0x20*/ System.Xml.Schema.ValidationEventHandler eventHandler;
                /*0x28*/ System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings;
                /*0x30*/ int errorCount;
                /*0x38*/ string NsXml;

                /*0x77ca360*/ BaseProcessor(System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler);
                /*0x77ca3e4*/ BaseProcessor(System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler, System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings);
                /*0x77ca4b8*/ System.Xml.XmlNameTable get_NameTable();
                /*0x77ca4c0*/ System.Xml.Schema.SchemaNames get_SchemaNames();
                /*0x77ca544*/ System.Xml.Schema.ValidationEventHandler get_EventHandler();
                /*0x77ca54c*/ System.Xml.Schema.XmlSchemaCompilationSettings get_CompilationSettings();
                /*0x77ca554*/ bool get_HasErrors();
                /*0x77ca564*/ void AddToTable(System.Xml.Schema.XmlSchemaObjectTable table, System.Xml.XmlQualifiedName qname, System.Xml.Schema.XmlSchemaObject item);
                /*0x77ca9c4*/ bool IsValidAttributeGroupRedefine(System.Xml.Schema.XmlSchemaObject existingObject, System.Xml.Schema.XmlSchemaObject item, System.Xml.Schema.XmlSchemaObjectTable table);
                /*0x77cac14*/ bool IsValidGroupRedefine(System.Xml.Schema.XmlSchemaObject existingObject, System.Xml.Schema.XmlSchemaObject item, System.Xml.Schema.XmlSchemaObjectTable table);
                /*0x77caaec*/ bool IsValidTypeRedefine(System.Xml.Schema.XmlSchemaObject existingObject, System.Xml.Schema.XmlSchemaObject item, System.Xml.Schema.XmlSchemaObjectTable table);
                /*0x77cadb0*/ void SendValidationEvent(string code, System.Xml.Schema.XmlSchemaObject source);
                /*0x77cad28*/ void SendValidationEvent(string code, string msg, System.Xml.Schema.XmlSchemaObject source);
                /*0x77caef0*/ void SendValidationEvent(string code, string msg1, string msg2, System.Xml.Schema.XmlSchemaObject source);
                /*0x77cafe4*/ void SendValidationEvent(string code, string[] args, System.Exception innerException, System.Xml.Schema.XmlSchemaObject source);
                /*0x77cb0a0*/ void SendValidationEvent(string code, string msg1, string msg2, string sourceUri, int lineNumber, int linePosition);
                /*0x77cb1ac*/ void SendValidationEvent(string code, System.Xml.Schema.XmlSchemaObject source, System.Xml.Schema.XmlSeverityType severity);
                /*0x77cb230*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e);
                /*0x77cb238*/ void SendValidationEvent(string code, string msg, System.Xml.Schema.XmlSchemaObject source, System.Xml.Schema.XmlSeverityType severity);
                /*0x77cae28*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity);
                /*0x77cb2c4*/ void SendValidationEventNoThrow(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity);
            }

            class BaseValidator
            {
                /*0x10*/ System.Xml.Schema.XmlSchemaCollection schemaCollection;
                /*0x18*/ System.Xml.IValidationEventHandling eventHandling;
                /*0x20*/ System.Xml.XmlNameTable nameTable;
                /*0x28*/ System.Xml.Schema.SchemaNames schemaNames;
                /*0x30*/ System.Xml.PositionInfo positionInfo;
                /*0x38*/ System.Xml.XmlResolver xmlResolver;
                /*0x40*/ System.Uri baseUri;
                /*0x48*/ System.Xml.Schema.SchemaInfo schemaInfo;
                /*0x50*/ System.Xml.XmlValidatingReaderImpl reader;
                /*0x58*/ System.Xml.XmlQualifiedName elementName;
                /*0x60*/ System.Xml.Schema.ValidationState context;
                /*0x68*/ System.Text.StringBuilder textValue;
                /*0x70*/ string textString;
                /*0x78*/ bool hasSibling;
                /*0x79*/ bool checkDatatype;

                static /*0x77cbf18*/ void ProcessEntity(System.Xml.Schema.SchemaInfo sinfo, string name, object sender, System.Xml.Schema.ValidationEventHandler eventhandler, string baseUri, int lineNumber, int linePosition);
                static /*0x77cc0d8*/ void ProcessEntity(System.Xml.Schema.SchemaInfo sinfo, string name, System.Xml.IValidationEventHandling eventHandling, string baseUriStr, int lineNumber, int linePosition);
                static /*0x77cc2cc*/ System.Xml.Schema.BaseValidator CreateInstance(System.Xml.ValidationType valType, System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling, bool processIdentityConstraints);
                /*0x77cb36c*/ BaseValidator(System.Xml.Schema.BaseValidator other);
                /*0x77c9d88*/ BaseValidator(System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling);
                /*0x77cb424*/ System.Xml.XmlValidatingReaderImpl get_Reader();
                /*0x77cb42c*/ System.Xml.Schema.XmlSchemaCollection get_SchemaCollection();
                /*0x77cb434*/ System.Xml.XmlNameTable get_NameTable();
                /*0x77ca2c0*/ System.Xml.Schema.SchemaNames get_SchemaNames();
                /*0x77cb43c*/ System.Xml.PositionInfo get_PositionInfo();
                /*0x77cb444*/ System.Xml.XmlResolver get_XmlResolver();
                /*0x77cb44c*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x77cb454*/ System.Uri get_BaseUri();
                /*0x77cb45c*/ void set_BaseUri(System.Uri value);
                /*0x77cb464*/ System.Xml.Schema.ValidationEventHandler get_EventHandler();
                /*0x77cb534*/ System.Xml.Schema.SchemaInfo get_SchemaInfo();
                /*0x77cb53c*/ void set_DtdInfo(System.Xml.IDtdInfo value);
                /*0x77cb61c*/ bool get_PreserveWhitespace();
                /*0x77cb624*/ void Validate();
                /*0x77cb628*/ void CompleteValidation();
                /*0x77cb62c*/ object FindId(string name);
                /*0x77cb634*/ void ValidateText();
                /*0x77cbafc*/ void ValidateWhitespace();
                /*0x77cba84*/ void SaveTextValue(string value);
                /*0x77cbc2c*/ void SendValidationEvent(string code);
                /*0x77cb99c*/ void SendValidationEvent(string code, string[] args);
                /*0x77cb8b4*/ void SendValidationEvent(string code, string arg);
                /*0x77cbc44*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e);
                /*0x77cbd30*/ void SendValidationEvent(string code, string msg, System.Xml.Schema.XmlSeverityType severity);
                /*0x77cbe24*/ void SendValidationEvent(string code, string[] args, System.Xml.Schema.XmlSeverityType severity);
                /*0x77cbc4c*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity);
            }

            class BitSet
            {
                /*0x10*/ int count;
                /*0x18*/ uint[] bits;

                /*0x77cc458*/ BitSet();
                /*0x77cc460*/ BitSet(int count);
                /*0x77cc4e0*/ int get_Count();
                /*0x77cc4e8*/ bool get_Item(int index);
                /*0x77cc53c*/ void Clear();
                /*0x77cc590*/ void Set(int index);
                /*0x77cc4ec*/ bool Get(int index);
                /*0x77cc694*/ int NextSet(int startFrom);
                /*0x77cc72c*/ void And(System.Xml.Schema.BitSet other);
                /*0x77cc7e8*/ void Or(System.Xml.Schema.BitSet other);
                /*0x77cc88c*/ int GetHashCode();
                /*0x77cc8c4*/ bool Equals(object obj);
                /*0x77cca20*/ System.Xml.Schema.BitSet Clone();
                /*0x77ccb1c*/ bool get_IsEmpty();
                /*0x77ccb84*/ bool Intersects(System.Xml.Schema.BitSet other);
                /*0x77cc4d8*/ int Subscript(int bitIndex);
                /*0x77cc5ec*/ void EnsureLength(int nRequiredLength);
            }

            class ChameleonKey
            {
                /*0x10*/ string targetNS;
                /*0x18*/ System.Uri chameleonLocation;
                /*0x20*/ System.Xml.Schema.XmlSchema originalSchema;
                /*0x28*/ int hashCode;

                /*0x77ccc60*/ ChameleonKey(string ns, System.Xml.Schema.XmlSchema originalSchema);
                /*0x77ccce8*/ int GetHashCode();
                /*0x77ccd68*/ bool Equals(object obj);
            }

            class CompiledIdentityConstraint
            {
                static /*0x0*/ System.Xml.Schema.CompiledIdentityConstraint Empty;
                /*0x10*/ System.Xml.XmlQualifiedName name;
                /*0x18*/ System.Xml.Schema.CompiledIdentityConstraint.ConstraintRole role;
                /*0x20*/ System.Xml.Schema.Asttree selector;
                /*0x28*/ System.Xml.Schema.Asttree[] fields;
                /*0x30*/ System.Xml.XmlQualifiedName refer;

                static /*0x77cd3d4*/ CompiledIdentityConstraint();
                /*0x77cce5c*/ CompiledIdentityConstraint();
                /*0x77ccee4*/ CompiledIdentityConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint constraint, System.Xml.XmlNamespaceManager nsmgr);
                /*0x77cce44*/ System.Xml.Schema.CompiledIdentityConstraint.ConstraintRole get_Role();
                /*0x77cce4c*/ System.Xml.Schema.Asttree get_Selector();
                /*0x77cce54*/ System.Xml.Schema.Asttree[] get_Fields();

                enum ConstraintRole
                {
                    Unique = 0,
                    Key = 1,
                    Keyref = 2,
                }
            }

            class ConstraintStruct
            {
                /*0x10*/ System.Xml.Schema.CompiledIdentityConstraint constraint;
                /*0x18*/ System.Xml.Schema.SelectorActiveAxis axisSelector;
                /*0x20*/ System.Collections.ArrayList axisFields;
                /*0x28*/ System.Collections.Hashtable qualifiedTable;
                /*0x30*/ System.Collections.Hashtable keyrefTable;
                /*0x38*/ int tableDim;

                /*0x77cd440*/ ConstraintStruct(System.Xml.Schema.CompiledIdentityConstraint constraint);
                /*0x77cd438*/ int get_TableDim();
            }

            class LocatedActiveAxis : System.Xml.Schema.ActiveAxis
            {
                /*0x28*/ int column;
                /*0x2c*/ bool isMatched;
                /*0x30*/ System.Xml.Schema.KeySequence Ks;

                /*0x77cd614*/ LocatedActiveAxis(System.Xml.Schema.Asttree astfield, System.Xml.Schema.KeySequence ks, int column);
                /*0x77cd60c*/ int get_Column();
                /*0x77cd650*/ void Reactivate(System.Xml.Schema.KeySequence ks);
            }

            class SelectorActiveAxis : System.Xml.Schema.ActiveAxis
            {
                /*0x28*/ System.Xml.Schema.ConstraintStruct cs;
                /*0x30*/ System.Collections.ArrayList KSs;
                /*0x38*/ int KSpointer;

                /*0x77cd580*/ SelectorActiveAxis(System.Xml.Schema.Asttree axisTree, System.Xml.Schema.ConstraintStruct cs);
                /*0x77cd668*/ int get_lastDepth();
                /*0x77cd710*/ bool EndElement(string localname, string URN);
                /*0x77cd758*/ int PushKS(int errline, int errcol);
                /*0x77cdb74*/ System.Xml.Schema.KeySequence PopKS();
            }

            class KSStruct
            {
                /*0x10*/ int depth;
                /*0x18*/ System.Xml.Schema.KeySequence ks;
                /*0x20*/ System.Xml.Schema.LocatedActiveAxis[] fields;

                /*0x77cdaf0*/ KSStruct(System.Xml.Schema.KeySequence ks, int dim);
            }

            class TypedObject
            {
                /*0x10*/ System.Xml.Schema.TypedObject.DecimalStruct dstruct;
                /*0x18*/ object ovalue;
                /*0x20*/ string svalue;
                /*0x28*/ System.Xml.Schema.XmlSchemaDatatype xsdtype;
                /*0x30*/ int dim;
                /*0x34*/ bool isList;

                /*0x77cdc6c*/ TypedObject(object obj, string svalue, System.Xml.Schema.XmlSchemaDatatype xsdtype);
                /*0x77cdc14*/ int get_Dim();
                /*0x77cdc1c*/ bool get_IsList();
                /*0x77cdc24*/ bool get_IsDecimal();
                /*0x77cdc40*/ decimal[] get_Dvalue();
                /*0x77cdc5c*/ object get_Value();
                /*0x77cdc64*/ System.Xml.Schema.XmlSchemaDatatype get_Type();
                /*0x77cdde4*/ string ToString();
                /*0x77cddec*/ void SetDecimal();
                /*0x77ce168*/ bool ListDValueEquals(System.Xml.Schema.TypedObject other);
                /*0x77ce27c*/ bool Equals(System.Xml.Schema.TypedObject other);

                class DecimalStruct
                {
                    /*0x10*/ bool isDecimal;
                    /*0x18*/ decimal[] dvalue;

                    /*0x77ce104*/ DecimalStruct();
                    /*0x77ce094*/ DecimalStruct(int dim);
                    /*0x77ce4e0*/ bool get_IsDecimal();
                    /*0x77ce4e8*/ void set_IsDecimal(bool value);
                    /*0x77ce4f4*/ decimal[] get_Dvalue();
                }
            }

            class KeySequence
            {
                /*0x10*/ System.Xml.Schema.TypedObject[] ks;
                /*0x18*/ int dim;
                /*0x1c*/ int hashcode;
                /*0x20*/ int posline;
                /*0x24*/ int poscol;

                /*0x77cda5c*/ KeySequence(int dim, int line, int col);
                /*0x77ce4fc*/ int get_PosLine();
                /*0x77ce504*/ int get_PosCol();
                /*0x77ce50c*/ object get_Item(int index);
                /*0x77ce53c*/ void set_Item(int index, object value);
                /*0x77ce638*/ bool IsQualified();
                /*0x77ce698*/ int GetHashCode();
                /*0x77cea00*/ bool Equals(object other);
                /*0x77ceaf0*/ string ToString();
            }

            class UpaException : System.Exception
            {
                /*0x90*/ object particle1;
                /*0x98*/ object particle2;

                /*0x77cec1c*/ UpaException(object particle1, object particle2);
                /*0x77ceca4*/ object get_Particle1();
                /*0x77cecac*/ object get_Particle2();
            }

            class SymbolsDictionary
            {
                /*0x10*/ int last;
                /*0x18*/ System.Collections.Hashtable names;
                /*0x20*/ System.Collections.Hashtable wildcards;
                /*0x28*/ System.Collections.ArrayList particles;
                /*0x30*/ object particleLast;
                /*0x38*/ bool isUpaEnforced;

                /*0x77cecb4*/ SymbolsDictionary();
                /*0x77ced68*/ int get_Count();
                /*0x77ced74*/ bool get_IsUpaEnforced();
                /*0x77ced7c*/ void set_IsUpaEnforced(bool value);
                /*0x77ced88*/ int AddName(System.Xml.XmlQualifiedName name, object particle);
                /*0x77cee98*/ void AddNamespaceList(System.Xml.Schema.NamespaceList list, object particle, bool allowLocal);
                /*0x77cf240*/ void AddWildcard(string wildcard, object particle);
                /*0x77cf3b4*/ System.Collections.ICollection GetNamespaceListSymbols(System.Xml.Schema.NamespaceList list);
                /*0x77cfb40*/ int get_Item(System.Xml.XmlQualifiedName name);
                /*0x77cfbd4*/ bool Exists(System.Xml.XmlQualifiedName name);
                /*0x77cfc04*/ object GetParticle(int symbol);
                /*0x77cfc40*/ string NameOf(int symbol);
            }

            struct Position
            {
                /*0x10*/ int symbol;
                /*0x18*/ object particle;

                /*0x77d02f4*/ Position(int symbol, object particle);
            }

            class Positions
            {
                /*0x10*/ System.Collections.ArrayList positions;

                /*0x77d0460*/ Positions();
                /*0x77d0304*/ int Add(int symbol, object particle);
                /*0x77d03ac*/ System.Xml.Schema.Position get_Item(int pos);
                /*0x77d043c*/ int get_Count();
            }

            class SyntaxTreeNode
            {
                /*0x77d04d4*/ SyntaxTreeNode();
                /*0x3816920*/ void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
                /*0x3816920*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x3813ffc*/ bool get_IsNullable();
                /*0x77d04cc*/ bool get_IsRangeNode();
            }

            class LeafNode : System.Xml.Schema.SyntaxTreeNode
            {
                /*0x10*/ int pos;

                /*0x77d04dc*/ LeafNode(int pos);
                /*0x77d0504*/ int get_Pos();
                /*0x77d050c*/ void set_Pos(int value);
                /*0x77d0514*/ void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
                /*0x77d0518*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x77d0558*/ bool get_IsNullable();
            }

            class NamespaceListNode : System.Xml.Schema.SyntaxTreeNode
            {
                /*0x10*/ System.Xml.Schema.NamespaceList namespaceList;
                /*0x18*/ object particle;

                /*0x77d0560*/ NamespaceListNode(System.Xml.Schema.NamespaceList namespaceList, object particle);
                /*0x77d05a4*/ System.Collections.ICollection GetResolvedSymbols(System.Xml.Schema.SymbolsDictionary symbols);
                /*0x77d05c4*/ void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
                /*0x77d0a88*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x77d0ac0*/ bool get_IsNullable();
            }

            class InteriorNode : System.Xml.Schema.SyntaxTreeNode
            {
                /*0x10*/ System.Xml.Schema.SyntaxTreeNode leftChild;
                /*0x18*/ System.Xml.Schema.SyntaxTreeNode rightChild;

                /*0x77d0d64*/ InteriorNode();
                /*0x77d0af8*/ System.Xml.Schema.SyntaxTreeNode get_LeftChild();
                /*0x77d0b00*/ void set_LeftChild(System.Xml.Schema.SyntaxTreeNode value);
                /*0x77d0b08*/ System.Xml.Schema.SyntaxTreeNode get_RightChild();
                /*0x77d0b10*/ void set_RightChild(System.Xml.Schema.SyntaxTreeNode value);
                /*0x77d0b18*/ void ExpandTreeNoRecursive(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
                /*0x77d0d00*/ void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
            }

            class SequenceNode : System.Xml.Schema.InteriorNode
            {
                /*0x77d1348*/ SequenceNode();
                /*0x77d0d6c*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x77d11d8*/ bool get_IsNullable();
                /*0x77d1344*/ void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);

                struct SequenceConstructPosContext
                {
                    /*0x10*/ System.Xml.Schema.SequenceNode this_;
                    /*0x18*/ System.Xml.Schema.BitSet firstpos;
                    /*0x20*/ System.Xml.Schema.BitSet lastpos;
                    /*0x28*/ System.Xml.Schema.BitSet lastposLeft;
                    /*0x30*/ System.Xml.Schema.BitSet firstposRight;

                    /*0x77d1174*/ SequenceConstructPosContext(System.Xml.Schema.SequenceNode node, System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos);
                }
            }

            class ChoiceNode : System.Xml.Schema.InteriorNode
            {
                static /*0x77d1350*/ void ConstructChildPos(System.Xml.Schema.SyntaxTreeNode child, System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x77d0a80*/ ChoiceNode();
                /*0x77d1424*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x77d1550*/ bool get_IsNullable();
                /*0x77d15e8*/ void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
            }

            class PlusNode : System.Xml.Schema.InteriorNode
            {
                /*0x77d16a8*/ PlusNode();
                /*0x77d15ec*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x77d1688*/ bool get_IsNullable();
            }

            class QmarkNode : System.Xml.Schema.InteriorNode
            {
                /*0x77d16d8*/ QmarkNode();
                /*0x77d16b0*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x77d16d0*/ bool get_IsNullable();
            }

            class StarNode : System.Xml.Schema.InteriorNode
            {
                /*0x77d1784*/ StarNode();
                /*0x77d16e0*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x77d177c*/ bool get_IsNullable();
            }

            class LeafRangeNode : System.Xml.Schema.LeafNode
            {
                /*0x18*/ decimal min;
                /*0x28*/ decimal max;
                /*0x38*/ System.Xml.Schema.BitSet nextIteration;

                /*0x77d178c*/ LeafRangeNode(decimal min, decimal max);
                /*0x77d17d4*/ LeafRangeNode(int pos, decimal min, decimal max);
                /*0x77d1824*/ decimal get_Max();
                /*0x77d1830*/ decimal get_Min();
                /*0x77d183c*/ System.Xml.Schema.BitSet get_NextIteration();
                /*0x77d1844*/ void set_NextIteration(System.Xml.Schema.BitSet value);
                /*0x77d184c*/ bool get_IsRangeNode();
                /*0x77d1854*/ void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
            }

            class ContentValidator
            {
                static /*0x0*/ System.Xml.Schema.ContentValidator Empty;
                static /*0x8*/ System.Xml.Schema.ContentValidator TextOnly;
                static /*0x10*/ System.Xml.Schema.ContentValidator Mixed;
                static /*0x18*/ System.Xml.Schema.ContentValidator Any;
                /*0x10*/ System.Xml.Schema.XmlSchemaContentType contentType;
                /*0x14*/ bool isOpen;
                /*0x15*/ bool isEmptiable;

                static /*0x77d1c38*/ ContentValidator();
                static /*0x77d19a0*/ void AddParticleToExpected(System.Xml.Schema.XmlSchemaParticle p, System.Xml.Schema.XmlSchemaSet schemaSet, System.Collections.ArrayList particles);
                static /*0x77d1a10*/ void AddParticleToExpected(System.Xml.Schema.XmlSchemaParticle p, System.Xml.Schema.XmlSchemaSet schemaSet, System.Collections.ArrayList particles, bool global);
                /*0x77d1888*/ ContentValidator(System.Xml.Schema.XmlSchemaContentType contentType);
                /*0x77d18b8*/ ContentValidator(System.Xml.Schema.XmlSchemaContentType contentType, bool isOpen, bool isEmptiable);
                /*0x77d18f8*/ System.Xml.Schema.XmlSchemaContentType get_ContentType();
                /*0x77d1900*/ bool get_PreserveWhitespace();
                /*0x77d191c*/ bool get_IsEmptiable();
                /*0x77d1924*/ bool get_IsOpen();
                /*0x77d1948*/ void set_IsOpen(bool value);
                /*0x77d1954*/ void InitValidation(System.Xml.Schema.ValidationState context);
                /*0x77d1958*/ object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, ref int errorCode);
                /*0x77d1988*/ bool CompleteValidation(System.Xml.Schema.ValidationState context);
                /*0x77d1990*/ System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, bool isRequiredOnly);
                /*0x77d1998*/ System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, bool isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet);
            }

            class ParticleContentValidator : System.Xml.Schema.ContentValidator
            {
                /*0x18*/ System.Xml.Schema.SymbolsDictionary symbols;
                /*0x20*/ System.Xml.Schema.Positions positions;
                /*0x28*/ System.Collections.Stack stack;
                /*0x30*/ System.Xml.Schema.SyntaxTreeNode contentNode;
                /*0x38*/ bool isPartial;
                /*0x3c*/ int minMaxNodesCount;
                /*0x40*/ bool enableUpaCheck;

                /*0x77d1d4c*/ ParticleContentValidator(System.Xml.Schema.XmlSchemaContentType contentType);
                /*0x77d1d54*/ ParticleContentValidator(System.Xml.Schema.XmlSchemaContentType contentType, bool enableUpaCheck);
                /*0x77d1dd4*/ void InitValidation(System.Xml.Schema.ValidationState context);
                /*0x77d1e0c*/ object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, ref int errorCode);
                /*0x77d1e44*/ bool CompleteValidation(System.Xml.Schema.ValidationState context);
                /*0x77d1e7c*/ void Start();
                /*0x77d1f4c*/ void OpenGroup();
                /*0x77d1f74*/ void CloseGroup();
                /*0x77d20e8*/ bool Exists(System.Xml.XmlQualifiedName name);
                /*0x77d2120*/ void AddName(System.Xml.XmlQualifiedName name, object particle);
                /*0x77d22b8*/ void AddNamespaceList(System.Xml.Schema.NamespaceList namespaceList, object particle);
                /*0x77d21c8*/ void AddLeafNode(System.Xml.Schema.SyntaxTreeNode node);
                /*0x77d2344*/ void AddChoice();
                /*0x77d2430*/ void AddSequence();
                /*0x77d251c*/ void AddStar();
                /*0x77d2714*/ void AddPlus();
                /*0x77d2770*/ void AddQMark();
                /*0x77d27cc*/ void AddLeafRange(decimal min, decimal max);
                /*0x77d2578*/ void Closure(System.Xml.Schema.InteriorNode node);
                /*0x77d28c0*/ System.Xml.Schema.ContentValidator Finish(bool useDFA);
                /*0x77d2e4c*/ System.Xml.Schema.BitSet[] CalculateTotalFollowposForRangeNodes(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos, ref System.Xml.Schema.BitSet posWithRangeTerminals);
                /*0x77d3274*/ void CheckCMUPAWithLeafRangeNodes(System.Xml.Schema.BitSet curpos);
                /*0x77d3104*/ System.Xml.Schema.BitSet GetApplicableMinMaxFollowPos(System.Xml.Schema.BitSet curpos, System.Xml.Schema.BitSet posWithRangeTerminals, System.Xml.Schema.BitSet[] minmaxFollowPos);
                /*0x77d33e0*/ void CheckUniqueParticleAttribution(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos);
                /*0x77d3aa4*/ void CheckUniqueParticleAttribution(System.Xml.Schema.BitSet curpos);
                /*0x77d3468*/ int[][] BuildTransitionTable(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos, int endMarkerPos);
            }

            class DfaContentValidator : System.Xml.Schema.ContentValidator
            {
                /*0x18*/ int[][] transitionTable;
                /*0x20*/ System.Xml.Schema.SymbolsDictionary symbols;

                /*0x77d39ec*/ DfaContentValidator(int[][] transitionTable, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.XmlSchemaContentType contentType, bool isOpen, bool isEmptiable);
                /*0x77d3c64*/ void InitValidation(System.Xml.Schema.ValidationState context);
                /*0x77d3cc8*/ object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, ref int errorCode);
                /*0x77d3dd8*/ bool CompleteValidation(System.Xml.Schema.ValidationState context);
                /*0x77d3df0*/ System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, bool isRequiredOnly);
                /*0x77d3fbc*/ System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, bool isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet);
            }

            class NfaContentValidator : System.Xml.Schema.ContentValidator
            {
                /*0x18*/ System.Xml.Schema.BitSet firstpos;
                /*0x20*/ System.Xml.Schema.BitSet[] followpos;
                /*0x28*/ System.Xml.Schema.SymbolsDictionary symbols;
                /*0x30*/ System.Xml.Schema.Positions positions;
                /*0x38*/ int endMarkerPos;

                /*0x765eacc*/ NfaContentValidator(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions, int endMarkerPos, System.Xml.Schema.XmlSchemaContentType contentType, bool isOpen, bool isEmptiable);
                /*0x765ebb8*/ void InitValidation(System.Xml.Schema.ValidationState context);
                /*0x765ec8c*/ object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, ref int errorCode);
                /*0x765ee3c*/ bool CompleteValidation(System.Xml.Schema.ValidationState context);
                /*0x765ee84*/ System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, bool isRequiredOnly);
                /*0x765f068*/ System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, bool isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet);
            }

            struct RangePositionInfo
            {
                /*0x10*/ System.Xml.Schema.BitSet curpos;
                /*0x18*/ decimal[] rangeCounters;
            }

            class RangeContentValidator : System.Xml.Schema.ContentValidator
            {
                /*0x18*/ System.Xml.Schema.BitSet firstpos;
                /*0x20*/ System.Xml.Schema.BitSet[] followpos;
                /*0x28*/ System.Xml.Schema.BitSet positionsWithRangeTerminals;
                /*0x30*/ System.Xml.Schema.SymbolsDictionary symbols;
                /*0x38*/ System.Xml.Schema.Positions positions;
                /*0x40*/ int minMaxNodesCount;
                /*0x44*/ int endMarkerPos;

                /*0x765f1e4*/ RangeContentValidator(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions, int endMarkerPos, System.Xml.Schema.XmlSchemaContentType contentType, bool isEmptiable, System.Xml.Schema.BitSet positionsWithRangeTerminals, int minmaxNodesCount);
                /*0x765f2e4*/ void InitValidation(System.Xml.Schema.ValidationState context);
                /*0x765f4c0*/ object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, ref int errorCode);
                /*0x765fda0*/ bool CompleteValidation(System.Xml.Schema.ValidationState context);
                /*0x765fdb8*/ System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, bool isRequiredOnly);
                /*0x7660020*/ System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, bool isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet);
            }

            class AllElementsContentValidator : System.Xml.Schema.ContentValidator
            {
                /*0x18*/ System.Collections.Hashtable elements;
                /*0x20*/ object[] particles;
                /*0x28*/ System.Xml.Schema.BitSet isRequired;
                /*0x30*/ int countRequired;

                /*0x7660224*/ AllElementsContentValidator(System.Xml.Schema.XmlSchemaContentType contentType, int size, bool isEmptiable);
                /*0x766034c*/ bool AddElement(System.Xml.XmlQualifiedName name, object particle, bool isEmptiable);
                /*0x7660478*/ bool get_IsEmptiable();
                /*0x7660498*/ void InitValidation(System.Xml.Schema.ValidationState context);
                /*0x7660534*/ object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, ref int errorCode);
                /*0x7660654*/ bool CompleteValidation(System.Xml.Schema.ValidationState context);
                /*0x76606a4*/ System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, bool isRequiredOnly);
                /*0x7660ac8*/ System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, bool isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet);
            }

            enum XmlSchemaDatatypeVariety
            {
                Atomic = 0,
                List = 1,
                Union = 2,
            }

            class XsdSimpleValue
            {
                /*0x10*/ System.Xml.Schema.XmlSchemaSimpleType xmlType;
                /*0x18*/ object typedValue;

                /*0x7660f94*/ XsdSimpleValue(System.Xml.Schema.XmlSchemaSimpleType st, object value);
                /*0x7660fd8*/ System.Xml.Schema.XmlSchemaSimpleType get_XmlType();
                /*0x7660fe0*/ object get_TypedValue();
            }

            enum RestrictionFlags
            {
                Length = 1,
                MinLength = 2,
                MaxLength = 4,
                Pattern = 8,
                Enumeration = 16,
                WhiteSpace = 32,
                MaxInclusive = 64,
                MaxExclusive = 128,
                MinInclusive = 256,
                MinExclusive = 512,
                TotalDigits = 1024,
                FractionDigits = 2048,
            }

            enum XmlSchemaWhiteSpace
            {
                Preserve = 0,
                Replace = 1,
                Collapse = 2,
            }

            class RestrictionFacets
            {
                /*0x10*/ int Length;
                /*0x14*/ int MinLength;
                /*0x18*/ int MaxLength;
                /*0x20*/ System.Collections.ArrayList Patterns;
                /*0x28*/ System.Collections.ArrayList Enumeration;
                /*0x30*/ System.Xml.Schema.XmlSchemaWhiteSpace WhiteSpace;
                /*0x38*/ object MaxInclusive;
                /*0x40*/ object MaxExclusive;
                /*0x48*/ object MinInclusive;
                /*0x50*/ object MinExclusive;
                /*0x58*/ int TotalDigits;
                /*0x5c*/ int FractionDigits;
                /*0x60*/ System.Xml.Schema.RestrictionFlags Flags;
                /*0x64*/ System.Xml.Schema.RestrictionFlags FixedFlags;

                /*0x7660fe8*/ RestrictionFacets();
            }

            class DatatypeImplementation : System.Xml.Schema.XmlSchemaDatatype
            {
                static /*0x0*/ System.Collections.Hashtable builtinTypes;
                static /*0x8*/ System.Xml.Schema.XmlSchemaSimpleType[] enumToTypeCode;
                static /*0x10*/ System.Xml.Schema.XmlSchemaSimpleType anySimpleType;
                static /*0x18*/ System.Xml.Schema.XmlSchemaSimpleType anyAtomicType;
                static /*0x20*/ System.Xml.Schema.XmlSchemaSimpleType untypedAtomicType;
                static /*0x28*/ System.Xml.Schema.XmlSchemaSimpleType yearMonthDurationType;
                static /*0x30*/ System.Xml.Schema.XmlSchemaSimpleType dayTimeDurationType;
                static /*0x38*/ System.Xml.Schema.XmlSchemaSimpleType normalizedStringTypeV1Compat;
                static /*0x40*/ System.Xml.Schema.XmlSchemaSimpleType tokenTypeV1Compat;
                static /*0x48*/ System.Xml.XmlQualifiedName QnAnySimpleType;
                static /*0x50*/ System.Xml.XmlQualifiedName QnAnyType;
                static /*0x58*/ System.Xml.Schema.FacetsChecker stringFacetsChecker;
                static /*0x60*/ System.Xml.Schema.FacetsChecker miscFacetsChecker;
                static /*0x68*/ System.Xml.Schema.FacetsChecker numeric2FacetsChecker;
                static /*0x70*/ System.Xml.Schema.FacetsChecker binaryFacetsChecker;
                static /*0x78*/ System.Xml.Schema.FacetsChecker dateTimeFacetsChecker;
                static /*0x80*/ System.Xml.Schema.FacetsChecker durationFacetsChecker;
                static /*0x88*/ System.Xml.Schema.FacetsChecker listFacetsChecker;
                static /*0x90*/ System.Xml.Schema.FacetsChecker qnameFacetsChecker;
                static /*0x98*/ System.Xml.Schema.FacetsChecker unionFacetsChecker;
                static /*0xa0*/ System.Xml.Schema.DatatypeImplementation c_anySimpleType;
                static /*0xa8*/ System.Xml.Schema.DatatypeImplementation c_anyURI;
                static /*0xb0*/ System.Xml.Schema.DatatypeImplementation c_base64Binary;
                static /*0xb8*/ System.Xml.Schema.DatatypeImplementation c_boolean;
                static /*0xc0*/ System.Xml.Schema.DatatypeImplementation c_byte;
                static /*0xc8*/ System.Xml.Schema.DatatypeImplementation c_char;
                static /*0xd0*/ System.Xml.Schema.DatatypeImplementation c_date;
                static /*0xd8*/ System.Xml.Schema.DatatypeImplementation c_dateTime;
                static /*0xe0*/ System.Xml.Schema.DatatypeImplementation c_dateTimeNoTz;
                static /*0xe8*/ System.Xml.Schema.DatatypeImplementation c_dateTimeTz;
                static /*0xf0*/ System.Xml.Schema.DatatypeImplementation c_day;
                static /*0xf8*/ System.Xml.Schema.DatatypeImplementation c_decimal;
                static /*0x100*/ System.Xml.Schema.DatatypeImplementation c_double;
                static /*0x108*/ System.Xml.Schema.DatatypeImplementation c_doubleXdr;
                static /*0x110*/ System.Xml.Schema.DatatypeImplementation c_duration;
                static /*0x118*/ System.Xml.Schema.DatatypeImplementation c_ENTITY;
                static /*0x120*/ System.Xml.Schema.DatatypeImplementation c_ENTITIES;
                static /*0x128*/ System.Xml.Schema.DatatypeImplementation c_ENUMERATION;
                static /*0x130*/ System.Xml.Schema.DatatypeImplementation c_fixed;
                static /*0x138*/ System.Xml.Schema.DatatypeImplementation c_float;
                static /*0x140*/ System.Xml.Schema.DatatypeImplementation c_floatXdr;
                static /*0x148*/ System.Xml.Schema.DatatypeImplementation c_hexBinary;
                static /*0x150*/ System.Xml.Schema.DatatypeImplementation c_ID;
                static /*0x158*/ System.Xml.Schema.DatatypeImplementation c_IDREF;
                static /*0x160*/ System.Xml.Schema.DatatypeImplementation c_IDREFS;
                static /*0x168*/ System.Xml.Schema.DatatypeImplementation c_int;
                static /*0x170*/ System.Xml.Schema.DatatypeImplementation c_integer;
                static /*0x178*/ System.Xml.Schema.DatatypeImplementation c_language;
                static /*0x180*/ System.Xml.Schema.DatatypeImplementation c_long;
                static /*0x188*/ System.Xml.Schema.DatatypeImplementation c_month;
                static /*0x190*/ System.Xml.Schema.DatatypeImplementation c_monthDay;
                static /*0x198*/ System.Xml.Schema.DatatypeImplementation c_Name;
                static /*0x1a0*/ System.Xml.Schema.DatatypeImplementation c_NCName;
                static /*0x1a8*/ System.Xml.Schema.DatatypeImplementation c_negativeInteger;
                static /*0x1b0*/ System.Xml.Schema.DatatypeImplementation c_NMTOKEN;
                static /*0x1b8*/ System.Xml.Schema.DatatypeImplementation c_NMTOKENS;
                static /*0x1c0*/ System.Xml.Schema.DatatypeImplementation c_nonNegativeInteger;
                static /*0x1c8*/ System.Xml.Schema.DatatypeImplementation c_nonPositiveInteger;
                static /*0x1d0*/ System.Xml.Schema.DatatypeImplementation c_normalizedString;
                static /*0x1d8*/ System.Xml.Schema.DatatypeImplementation c_NOTATION;
                static /*0x1e0*/ System.Xml.Schema.DatatypeImplementation c_positiveInteger;
                static /*0x1e8*/ System.Xml.Schema.DatatypeImplementation c_QName;
                static /*0x1f0*/ System.Xml.Schema.DatatypeImplementation c_QNameXdr;
                static /*0x1f8*/ System.Xml.Schema.DatatypeImplementation c_short;
                static /*0x200*/ System.Xml.Schema.DatatypeImplementation c_string;
                static /*0x208*/ System.Xml.Schema.DatatypeImplementation c_time;
                static /*0x210*/ System.Xml.Schema.DatatypeImplementation c_timeNoTz;
                static /*0x218*/ System.Xml.Schema.DatatypeImplementation c_timeTz;
                static /*0x220*/ System.Xml.Schema.DatatypeImplementation c_token;
                static /*0x228*/ System.Xml.Schema.DatatypeImplementation c_unsignedByte;
                static /*0x230*/ System.Xml.Schema.DatatypeImplementation c_unsignedInt;
                static /*0x238*/ System.Xml.Schema.DatatypeImplementation c_unsignedLong;
                static /*0x240*/ System.Xml.Schema.DatatypeImplementation c_unsignedShort;
                static /*0x248*/ System.Xml.Schema.DatatypeImplementation c_uuid;
                static /*0x250*/ System.Xml.Schema.DatatypeImplementation c_year;
                static /*0x258*/ System.Xml.Schema.DatatypeImplementation c_yearMonth;
                static /*0x260*/ System.Xml.Schema.DatatypeImplementation c_normalizedStringV1Compat;
                static /*0x268*/ System.Xml.Schema.DatatypeImplementation c_tokenV1Compat;
                static /*0x270*/ System.Xml.Schema.DatatypeImplementation c_anyAtomicType;
                static /*0x278*/ System.Xml.Schema.DatatypeImplementation c_dayTimeDuration;
                static /*0x280*/ System.Xml.Schema.DatatypeImplementation c_untypedAtomicType;
                static /*0x288*/ System.Xml.Schema.DatatypeImplementation c_yearMonthDuration;
                static /*0x290*/ System.Xml.Schema.DatatypeImplementation[] c_tokenizedTypes;
                static /*0x298*/ System.Xml.Schema.DatatypeImplementation[] c_tokenizedTypesXsd;
                static /*0x2a0*/ System.Xml.Schema.DatatypeImplementation.SchemaDatatypeMap[] c_XdrTypes;
                static /*0x2a8*/ System.Xml.Schema.DatatypeImplementation.SchemaDatatypeMap[] c_XsdTypes;
                /*0x10*/ System.Xml.Schema.XmlSchemaDatatypeVariety variety;
                /*0x18*/ System.Xml.Schema.RestrictionFacets restriction;
                /*0x20*/ System.Xml.Schema.DatatypeImplementation baseType;
                /*0x28*/ System.Xml.Schema.XmlValueConverter valueConverter;
                /*0x30*/ System.Xml.Schema.XmlSchemaType parentSchemaType;

                static /*0x7660ff0*/ DatatypeImplementation();
                static /*0x76666ec*/ System.Xml.Schema.XmlSchemaSimpleType get_AnySimpleType();
                static /*0x7666744*/ System.Xml.Schema.XmlSchemaSimpleType get_UntypedAtomicType();
                static /*0x766679c*/ System.Xml.Schema.DatatypeImplementation FromXmlTokenizedType(System.Xml.XmlTokenizedType token);
                static /*0x7666818*/ System.Xml.Schema.DatatypeImplementation FromXmlTokenizedTypeXsd(System.Xml.XmlTokenizedType token);
                static /*0x7666894*/ System.Xml.Schema.DatatypeImplementation FromXdrName(string name);
                static /*0x7666954*/ System.Xml.Schema.DatatypeImplementation FromTypeName(string name);
                static /*0x7666a14*/ System.Xml.Schema.XmlSchemaSimpleType StartBuiltinType(System.Xml.XmlQualifiedName qname, System.Xml.Schema.XmlSchemaDatatype dataType);
                static /*0x7666af8*/ void FinishBuiltinType(System.Xml.Schema.XmlSchemaSimpleType derivedType, System.Xml.Schema.XmlSchemaSimpleType baseType);
                static /*0x7665e1c*/ void CreateBuiltinTypes();
                static /*0x7666d3c*/ System.Xml.Schema.XmlSchemaSimpleType GetSimpleTypeFromTypeCode(System.Xml.Schema.XmlTypeCode typeCode);
                static /*0x7666db8*/ System.Xml.Schema.XmlSchemaSimpleType GetSimpleTypeFromXsdType(System.Xml.XmlQualifiedName qname);
                static /*0x7666e78*/ System.Xml.Schema.XmlSchemaSimpleType GetNormalizedStringTypeV1Compat();
                static /*0x7667010*/ System.Xml.Schema.XmlSchemaSimpleType GetTokenTypeV1Compat();
                static /*0x76671a8*/ System.Xml.Schema.XmlSchemaSimpleType[] GetBuiltInTypes();
                static /*0x7667200*/ System.Xml.Schema.XmlTypeCode GetPrimitiveTypeCode(System.Xml.Schema.XmlTypeCode typeCode);
                static /*0x7667550*/ System.Xml.Schema.DatatypeImplementation DeriveByUnion(System.Xml.Schema.XmlSchemaSimpleType[] types, System.Xml.Schema.XmlSchemaType schemaType);
                /*0x7668354*/ DatatypeImplementation();
                /*0x7667330*/ System.Xml.Schema.XmlSchemaDatatype DeriveByRestriction(System.Xml.Schema.XmlSchemaObjectCollection facets, System.Xml.XmlNameTable nameTable, System.Xml.Schema.XmlSchemaType schemaType);
                /*0x766744c*/ System.Xml.Schema.XmlSchemaDatatype DeriveByList(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x7665258*/ System.Xml.Schema.XmlSchemaDatatype DeriveByList(int minSize, System.Xml.Schema.XmlSchemaType schemaType);
                /*0x7667680*/ void VerifySchemaValid(System.Xml.Schema.XmlSchemaObjectTable notations, System.Xml.Schema.XmlSchemaObject caller);
                /*0x7667684*/ bool IsDerivedFrom(System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7667910*/ bool IsEqual(object o1, object o2);
                /*0x7667934*/ bool IsComparable(System.Xml.Schema.XmlSchemaDatatype dtype);
                /*0x7667a20*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x7667a28*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x7667a80*/ System.Xml.Schema.XmlValueConverter get_ValueConverter();
                /*0x7667ad0*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x7667ad8*/ System.Type get_ValueType();
                /*0x7667b08*/ System.Xml.Schema.XmlSchemaDatatypeVariety get_Variety();
                /*0x7667b10*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x7667b18*/ System.Xml.Schema.RestrictionFacets get_Restriction();
                /*0x7667b20*/ bool get_HasLexicalFacets();
                /*0x7667b48*/ bool get_HasValueFacets();
                /*0x7667b70*/ System.Xml.Schema.DatatypeImplementation get_Base();
                /*0x38148bc*/ System.Type get_ListValueType();
                /*0x3814574*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x7667b78*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x7667b80*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
                /*0x7667dc0*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, bool createAtomicValue);
                /*0x7667f14*/ System.Exception TryParseValue(object value, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver namespaceResolver, ref object typedValue);
                /*0x7667d54*/ string GetTypeName();
                /*0x76682e0*/ int Compare(byte[] value1, byte[] value2);

                class SchemaDatatypeMap : System.IComparable
                {
                    /*0x10*/ string name;
                    /*0x18*/ System.Xml.Schema.DatatypeImplementation type;
                    /*0x20*/ int parentIndex;

                    static /*0x766835c*/ System.Xml.Schema.DatatypeImplementation op_Explicit(System.Xml.Schema.DatatypeImplementation.SchemaDatatypeMap sdm);
                    /*0x7665d80*/ SchemaDatatypeMap(string name, System.Xml.Schema.DatatypeImplementation type);
                    /*0x7665dc4*/ SchemaDatatypeMap(string name, System.Xml.Schema.DatatypeImplementation type, int parentIndex);
                    /*0x7668374*/ string get_Name();
                    /*0x766837c*/ int get_ParentIndex();
                    /*0x7668384*/ int CompareTo(object obj);
                }
            }

            class Datatype_List : System.Xml.Schema.Datatype_anySimpleType
            {
                /*0x38*/ System.Xml.Schema.DatatypeImplementation itemType;
                /*0x40*/ int minListSize;

                /*0x76674d4*/ Datatype_List(System.Xml.Schema.DatatypeImplementation type, int minListSize);
                /*0x76683c4*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x7668660*/ int Compare(object value1, object value2);
                /*0x7668904*/ System.Type get_ValueType();
                /*0x7668914*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x7668934*/ System.Type get_ListValueType();
                /*0x7668958*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x76689b0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x76689d0*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x76689d8*/ System.Xml.Schema.DatatypeImplementation get_ItemType();
                /*0x76689e0*/ System.Exception TryParseValue(object value, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver namespaceResolver, ref object typedValue);
                /*0x7668f90*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_union : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                /*0x38*/ System.Xml.Schema.XmlSchemaSimpleType[] types;

                static /*0x7669c68*/ Datatype_union();
                /*0x7667610*/ Datatype_union(System.Xml.Schema.XmlSchemaSimpleType[] types);
                /*0x76693b8*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x76693c4*/ int Compare(object value1, object value2);
                /*0x76694c8*/ System.Type get_ValueType();
                /*0x7669520*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x7669528*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x7669580*/ System.Type get_ListValueType();
                /*0x76695d8*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x76695e0*/ System.Xml.Schema.XmlSchemaSimpleType[] get_BaseMemberTypes();
                /*0x7667458*/ bool HasAtomicMembers();
                /*0x7667888*/ bool IsUnionBaseOf(System.Xml.Schema.DatatypeImplementation derivedType);
                /*0x76695e8*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
                /*0x76697ec*/ System.Exception TryParseValue(object value, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_anySimpleType : System.Xml.Schema.DatatypeImplementation
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x7669f28*/ Datatype_anySimpleType();
                /*0x7664d50*/ Datatype_anySimpleType();
                /*0x7669d1c*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x7669d74*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x7669dcc*/ System.Type get_ValueType();
                /*0x7669e24*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x7669e2c*/ System.Type get_ListValueType();
                /*0x7669e84*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x7669e8c*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x7669e94*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x7669e9c*/ int Compare(object value1, object value2);
                /*0x7669ef8*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_anyAtomicType : System.Xml.Schema.Datatype_anySimpleType
            {
                /*0x7665c80*/ Datatype_anyAtomicType();
                /*0x7669fdc*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x766a034*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x766a03c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_untypedAtomicType : System.Xml.Schema.Datatype_anyAtomicType
            {
                /*0x7665d28*/ Datatype_untypedAtomicType();
                /*0x766a044*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x766a09c*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x766a0a4*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_string : System.Xml.Schema.Datatype_anySimpleType
            {
                /*0x76658c4*/ Datatype_string();
                /*0x766a0ac*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x766a0b8*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x766a0c0*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x766a118*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x766a120*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x766a128*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x766a130*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_boolean : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x766a4d8*/ Datatype_boolean();
                /*0x7664e50*/ Datatype_boolean();
                /*0x766a21c*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x766a228*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x766a280*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x766a288*/ System.Type get_ValueType();
                /*0x766a2e0*/ System.Type get_ListValueType();
                /*0x766a338*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x766a340*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x766a348*/ int Compare(object value1, object value2);
                /*0x766a3c8*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_float : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x766a870*/ Datatype_float();
                /*0x7665450*/ Datatype_float();
                /*0x766a58c*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x766a598*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x766a5f0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x766a5f8*/ System.Type get_ValueType();
                /*0x766a650*/ System.Type get_ListValueType();
                /*0x766a6a8*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x766a6b0*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x766a6b8*/ int Compare(object value1, object value2);
                /*0x766a728*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_double : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x766ac08*/ Datatype_double();
                /*0x7665158*/ Datatype_double();
                /*0x766a924*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x766a930*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x766a988*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x766a990*/ System.Type get_ValueType();
                /*0x766a9e8*/ System.Type get_ListValueType();
                /*0x766aa40*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x766aa48*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x766aa50*/ int Compare(object value1, object value2);
                /*0x766aac0*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_decimal : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x766b02c*/ Datatype_decimal();
                /*0x7665104*/ Datatype_decimal();
                /*0x766acbc*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x766acc8*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x766ad20*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x766ad28*/ System.Type get_ValueType();
                /*0x766ad80*/ System.Type get_ListValueType();
                /*0x766add8*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x766ade0*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x766ade8*/ int Compare(object value1, object value2);
                /*0x766aeb4*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_duration : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x766b5a4*/ Datatype_duration();
                /*0x7665200*/ Datatype_duration();
                /*0x766b204*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x766b210*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x766b268*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x766b270*/ System.Type get_ValueType();
                /*0x766b2c8*/ System.Type get_ListValueType();
                /*0x766b320*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x766b328*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x766b330*/ int Compare(object value1, object value2);
                /*0x766b3d4*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_yearMonthDuration : System.Xml.Schema.Datatype_duration
            {
                /*0x7665d2c*/ Datatype_yearMonthDuration();
                /*0x766b66c*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
                /*0x766b840*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_dayTimeDuration : System.Xml.Schema.Datatype_duration
            {
                /*0x7665cd4*/ Datatype_dayTimeDuration();
                /*0x766b848*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
                /*0x766ba1c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_dateTimeBase : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                /*0x38*/ System.Xml.Schema.XsdDateTimeFlags dateTimeFlags;

                static /*0x766c050*/ Datatype_dateTimeBase();
                /*0x766ba90*/ Datatype_dateTimeBase(System.Xml.Schema.XsdDateTimeFlags dateTimeFlags);
                /*0x766ba24*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x766ba30*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x766ba88*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x766baf8*/ System.Type get_ValueType();
                /*0x766bb50*/ System.Type get_ListValueType();
                /*0x766bba8*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x766bbb0*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x766bbb8*/ int Compare(object value1, object value2);
                /*0x766bd00*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_dateTimeNoTimeZone : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x7664ffc*/ Datatype_dateTimeNoTimeZone();
            }

            class Datatype_dateTimeTimeZone : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x7665054*/ Datatype_dateTimeTimeZone();
            }

            class Datatype_dateTime : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x7664fa4*/ Datatype_dateTime();
            }

            class Datatype_timeNoTimeZone : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x7665970*/ Datatype_timeNoTimeZone();
            }

            class Datatype_timeTimeZone : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x76659c8*/ Datatype_timeTimeZone();
            }

            class Datatype_time : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x7665918*/ Datatype_time();
                /*0x766c118*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_date : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x7664f4c*/ Datatype_date();
                /*0x766c120*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_yearMonth : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x7665c20*/ Datatype_yearMonth();
                /*0x766c128*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_year : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x7665bc8*/ Datatype_year();
                /*0x766c130*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_monthDay : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x766565c*/ Datatype_monthDay();
                /*0x766c138*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_day : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x76650ac*/ Datatype_day();
                /*0x766c140*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_month : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x7665604*/ Datatype_month();
                /*0x766c148*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_hexBinary : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x766c4e4*/ Datatype_hexBinary();
                /*0x76654f8*/ Datatype_hexBinary();
                /*0x766c150*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x766c15c*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x766c1b4*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x766c1bc*/ System.Type get_ValueType();
                /*0x766c214*/ System.Type get_ListValueType();
                /*0x766c26c*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x766c274*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x766c27c*/ int Compare(object value1, object value2);
                /*0x766c324*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_base64Binary : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x766c93c*/ Datatype_base64Binary();
                /*0x7664dfc*/ Datatype_base64Binary();
                /*0x766c5ac*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x766c5b8*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x766c610*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x766c618*/ System.Type get_ValueType();
                /*0x766c670*/ System.Type get_ListValueType();
                /*0x766c6c8*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x766c6d0*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x766c6d8*/ int Compare(object value1, object value2);
                /*0x766c780*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_anyURI : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x766cfa8*/ Datatype_anyURI();
                /*0x7664da8*/ Datatype_anyURI();
                /*0x766ca04*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x766ca10*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x766ca68*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x766ca70*/ System.Type get_ValueType();
                /*0x766cac8*/ bool get_HasValueFacets();
                /*0x766cad0*/ System.Type get_ListValueType();
                /*0x766cb28*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x766cb30*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x766cb38*/ int Compare(object value1, object value2);
                /*0x766cbfc*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_QName : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x766d3e8*/ Datatype_QName();
                /*0x76657c8*/ Datatype_QName();
                /*0x766d070*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x766d07c*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x766d0d4*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x766d0dc*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x766d0e4*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x766d0ec*/ System.Type get_ValueType();
                /*0x766d144*/ System.Type get_ListValueType();
                /*0x766d19c*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x766d1a4*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_normalizedString : System.Xml.Schema.Datatype_string
            {
                /*0x766571c*/ Datatype_normalizedString();
                /*0x766d4b0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x766d4b8*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x766d4c0*/ bool get_HasValueFacets();
            }

            class Datatype_normalizedStringV1Compat : System.Xml.Schema.Datatype_string
            {
                /*0x7665c78*/ Datatype_normalizedStringV1Compat();
                /*0x766d4c8*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x766d4d0*/ bool get_HasValueFacets();
            }

            class Datatype_token : System.Xml.Schema.Datatype_normalizedString
            {
                /*0x7665a20*/ Datatype_token();
                /*0x766d4d8*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x766d4e0*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
            }

            class Datatype_tokenV1Compat : System.Xml.Schema.Datatype_normalizedStringV1Compat
            {
                /*0x7665c7c*/ Datatype_tokenV1Compat();
                /*0x766d4e8*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_language : System.Xml.Schema.Datatype_token
            {
                /*0x76655fc*/ Datatype_language();
                /*0x766d4f0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_NMTOKEN : System.Xml.Schema.Datatype_token
            {
                /*0x7665710*/ Datatype_NMTOKEN();
                /*0x766d4f8*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x766d500*/ System.Xml.XmlTokenizedType get_TokenizedType();
            }

            class Datatype_Name : System.Xml.Schema.Datatype_token
            {
                /*0x76656b4*/ Datatype_Name();
                /*0x766d508*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_NCName : System.Xml.Schema.Datatype_Name
            {
                /*0x76656b8*/ Datatype_NCName();
                /*0x766d510*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x766d518*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_ID : System.Xml.Schema.Datatype_NCName
            {
                /*0x766554c*/ Datatype_ID();
                /*0x766d628*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x766d630*/ System.Xml.XmlTokenizedType get_TokenizedType();
            }

            class Datatype_IDREF : System.Xml.Schema.Datatype_NCName
            {
                /*0x7665550*/ Datatype_IDREF();
                /*0x766d638*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x766d640*/ System.Xml.XmlTokenizedType get_TokenizedType();
            }

            class Datatype_ENTITY : System.Xml.Schema.Datatype_NCName
            {
                /*0x7665254*/ Datatype_ENTITY();
                /*0x766d648*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x766d650*/ System.Xml.XmlTokenizedType get_TokenizedType();
            }

            class Datatype_NOTATION : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x766dbdc*/ Datatype_NOTATION();
                /*0x7665720*/ Datatype_NOTATION();
                /*0x766d658*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x766d664*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x766d6bc*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x766d6c4*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x766d6cc*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x766d6d4*/ System.Type get_ValueType();
                /*0x766d72c*/ System.Type get_ListValueType();
                /*0x766d784*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x766d78c*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
                /*0x766d9d0*/ void VerifySchemaValid(System.Xml.Schema.XmlSchemaObjectTable notations, System.Xml.Schema.XmlSchemaObject caller);
            }

            class Datatype_integer : System.Xml.Schema.Datatype_decimal
            {
                /*0x76655a8*/ Datatype_integer();
                /*0x766dca4*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x766dcac*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_nonPositiveInteger : System.Xml.Schema.Datatype_integer
            {
                static /*0x0*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x766de68*/ Datatype_nonPositiveInteger();
                /*0x7665718*/ Datatype_nonPositiveInteger();
                /*0x766de00*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x766de58*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x766de60*/ bool get_HasValueFacets();
            }

            class Datatype_negativeInteger : System.Xml.Schema.Datatype_nonPositiveInteger
            {
                static /*0x0*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x766dfe0*/ Datatype_negativeInteger();
                /*0x76656bc*/ Datatype_negativeInteger();
                /*0x766df80*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x766dfd8*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_long : System.Xml.Schema.Datatype_integer
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x766e3c8*/ Datatype_long();
                /*0x7665600*/ Datatype_long();
                /*0x766e0f8*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x766e150*/ bool get_HasValueFacets();
                /*0x766e158*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x766e160*/ int Compare(object value1, object value2);
                /*0x766e1d0*/ System.Type get_ValueType();
                /*0x766e228*/ System.Type get_ListValueType();
                /*0x766e280*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_int : System.Xml.Schema.Datatype_long
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x766e7f4*/ Datatype_int();
                /*0x7665554*/ Datatype_int();
                /*0x766e52c*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x766e584*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x766e58c*/ int Compare(object value1, object value2);
                /*0x766e5fc*/ System.Type get_ValueType();
                /*0x766e654*/ System.Type get_ListValueType();
                /*0x766e6ac*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_short : System.Xml.Schema.Datatype_int
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x766ec20*/ Datatype_short();
                /*0x7665870*/ Datatype_short();
                /*0x766e958*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x766e9b0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x766e9b8*/ int Compare(object value1, object value2);
                /*0x766ea28*/ System.Type get_ValueType();
                /*0x766ea80*/ System.Type get_ListValueType();
                /*0x766ead8*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_byte : System.Xml.Schema.Datatype_short
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x766f04c*/ Datatype_byte();
                /*0x7664ea4*/ Datatype_byte();
                /*0x766ed84*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x766eddc*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x766ede4*/ int Compare(object value1, object value2);
                /*0x766ee54*/ System.Type get_ValueType();
                /*0x766eeac*/ System.Type get_ListValueType();
                /*0x766ef04*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_nonNegativeInteger : System.Xml.Schema.Datatype_integer
            {
                static /*0x0*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x766f218*/ Datatype_nonNegativeInteger();
                /*0x7665714*/ Datatype_nonNegativeInteger();
                /*0x766f1b0*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x766f208*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x766f210*/ bool get_HasValueFacets();
            }

            class Datatype_unsignedLong : System.Xml.Schema.Datatype_nonNegativeInteger
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x766f63c*/ Datatype_unsignedLong();
                /*0x7665acc*/ Datatype_unsignedLong();
                /*0x766f330*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x766f388*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x766f390*/ int Compare(object value1, object value2);
                /*0x766f400*/ System.Type get_ValueType();
                /*0x766f458*/ System.Type get_ListValueType();
                /*0x766f4b0*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_unsignedInt : System.Xml.Schema.Datatype_unsignedLong
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x766fa84*/ Datatype_unsignedInt();
                /*0x7665a78*/ Datatype_unsignedInt();
                /*0x766f7bc*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x766f814*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x766f81c*/ int Compare(object value1, object value2);
                /*0x766f88c*/ System.Type get_ValueType();
                /*0x766f8e4*/ System.Type get_ListValueType();
                /*0x766f93c*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_unsignedShort : System.Xml.Schema.Datatype_unsignedInt
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x766fecc*/ Datatype_unsignedShort();
                /*0x7665b20*/ Datatype_unsignedShort();
                /*0x766fc04*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x766fc5c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x766fc64*/ int Compare(object value1, object value2);
                /*0x766fcd4*/ System.Type get_ValueType();
                /*0x766fd2c*/ System.Type get_ListValueType();
                /*0x766fd84*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_unsignedByte : System.Xml.Schema.Datatype_unsignedShort
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x7670314*/ Datatype_unsignedByte();
                /*0x7665a24*/ Datatype_unsignedByte();
                /*0x767004c*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x76700a4*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x76700ac*/ int Compare(object value1, object value2);
                /*0x767011c*/ System.Type get_ValueType();
                /*0x7670174*/ System.Type get_ListValueType();
                /*0x76701cc*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_positiveInteger : System.Xml.Schema.Datatype_nonNegativeInteger
            {
                static /*0x0*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x76704f4*/ Datatype_positiveInteger();
                /*0x7665774*/ Datatype_positiveInteger();
                /*0x7670494*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x76704ec*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_doubleXdr : System.Xml.Schema.Datatype_double
            {
                /*0x76651ac*/ Datatype_doubleXdr();
                /*0x767060c*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
            }

            class Datatype_floatXdr : System.Xml.Schema.Datatype_float
            {
                /*0x76654a4*/ Datatype_floatXdr();
                /*0x76707e8*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
            }

            class Datatype_QNameXdr : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x7670ce8*/ Datatype_QNameXdr();
                /*0x766581c*/ Datatype_QNameXdr();
                /*0x76709c4*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x76709cc*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
                /*0x7670c38*/ System.Type get_ValueType();
                /*0x7670c90*/ System.Type get_ListValueType();
            }

            class Datatype_ENUMERATION : System.Xml.Schema.Datatype_NMTOKEN
            {
                /*0x76653f8*/ Datatype_ENUMERATION();
                /*0x7670db0*/ System.Xml.XmlTokenizedType get_TokenizedType();
            }

            class Datatype_char : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x767116c*/ Datatype_char();
                /*0x7664ef8*/ Datatype_char();
                /*0x7670db8*/ System.Type get_ValueType();
                /*0x7670e10*/ System.Type get_ListValueType();
                /*0x7670e68*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x7670e70*/ int Compare(object value1, object value2);
                /*0x7670ef0*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
                /*0x76710b4*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_fixed : System.Xml.Schema.Datatype_decimal
            {
                /*0x76653fc*/ Datatype_fixed();
                /*0x7671220*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
                /*0x767172c*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_uuid : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x7671c88*/ Datatype_uuid();
                /*0x7665b74*/ Datatype_uuid();
                /*0x7671898*/ System.Type get_ValueType();
                /*0x76718f0*/ System.Type get_ListValueType();
                /*0x7671948*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x7671950*/ int Compare(object value1, object value2);
                /*0x76719ec*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
                /*0x7671bbc*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class DtdValidator : System.Xml.Schema.BaseValidator
            {
                static /*0x0*/ System.Xml.Schema.DtdValidator.NamespaceManager namespaceManager;
                /*0x80*/ System.Xml.HWStack validationStack;
                /*0x88*/ System.Collections.Hashtable attPresence;
                /*0x90*/ System.Xml.XmlQualifiedName name;
                /*0x98*/ System.Collections.Hashtable IDs;
                /*0xa0*/ System.Xml.Schema.IdRefNode idRefListHead;
                /*0xa8*/ bool processIdentityConstraints;

                static /*0x7674354*/ DtdValidator();
                static /*0x7673b8c*/ void SetDefaultTypedValue(System.Xml.Schema.SchemaAttDef attdef, System.Xml.IDtdParserAdapter readerAdapter);
                static /*0x7673f4c*/ void CheckDefaultValue(System.Xml.Schema.SchemaAttDef attdef, System.Xml.Schema.SchemaInfo sinfo, System.Xml.IValidationEventHandling eventHandling, string baseUriStr);
                /*0x7671d50*/ DtdValidator(System.Xml.XmlValidatingReaderImpl reader, System.Xml.IValidationEventHandling eventHandling, bool processIdentityConstraints);
                /*0x7671df8*/ void Init();
                /*0x767208c*/ void Validate();
                /*0x767238c*/ bool MeetsStandAloneConstraint();
                /*0x767242c*/ void ValidatePIComment();
                /*0x7672284*/ void ValidateElement();
                /*0x76727d0*/ void ValidateChildElement();
                /*0x7672a34*/ void ValidateStartElement();
                /*0x76733f4*/ void ValidateEndStartElement();
                /*0x7672918*/ void ProcessElement();
                /*0x76735b0*/ void CompleteValidation();
                /*0x7672630*/ void ValidateEndElement();
                /*0x76737d4*/ bool get_PreserveWhitespace();
                /*0x767380c*/ void ProcessTokenizedType(System.Xml.XmlTokenizedType ttype, string name);
                /*0x7672e90*/ void CheckValue(string value, System.Xml.Schema.SchemaAttDef attdef);
                /*0x7673a40*/ void AddID(string name, object node);
                /*0x7673adc*/ object FindId(string name);
                /*0x76724dc*/ bool GenEntity(System.Xml.XmlQualifiedName qname);
                /*0x7673af8*/ System.Xml.Schema.SchemaEntity GetEntity(System.Xml.XmlQualifiedName qname, bool fParameterEntity);
                /*0x76736b0*/ void CheckForwardRefs();
                /*0x7671f64*/ void Push(System.Xml.XmlQualifiedName elementName);
                /*0x76735f8*/ bool Pop();

                class NamespaceManager : System.Xml.XmlNamespaceManager
                {
                    /*0x76743d0*/ NamespaceManager();
                    /*0x76743d8*/ string LookupNamespace(string prefix);
                }
            }

            class FacetsChecker
            {
                static /*0x7677150*/ decimal Power(int x, int y);
                /*0x767727c*/ FacetsChecker();
                /*0x76743e0*/ System.Exception CheckLexicalFacets(ref string parseString, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x767466c*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7674674*/ System.Exception CheckValueFacets(decimal value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x767467c*/ System.Exception CheckValueFacets(long value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7674684*/ System.Exception CheckValueFacets(int value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x767468c*/ System.Exception CheckValueFacets(short value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7674694*/ System.Exception CheckValueFacets(System.DateTime value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x767469c*/ System.Exception CheckValueFacets(double value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x76746a4*/ System.Exception CheckValueFacets(float value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x76746ac*/ System.Exception CheckValueFacets(string value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x76746b4*/ System.Exception CheckValueFacets(byte[] value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x76746bc*/ System.Exception CheckValueFacets(System.TimeSpan value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x76746c4*/ System.Exception CheckValueFacets(System.Xml.XmlQualifiedName value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7674424*/ void CheckWhitespaceFacets(ref string s, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x767451c*/ System.Exception CheckPatternFacets(System.Xml.Schema.RestrictionFacets restriction, string value);
                /*0x76746cc*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x76746d4*/ System.Xml.Schema.RestrictionFacets ConstructRestriction(System.Xml.Schema.DatatypeImplementation datatype, System.Xml.Schema.XmlSchemaObjectCollection facets, System.Xml.XmlNameTable nameTable);

                struct FacetsCompiler
                {
                    static /*0x0*/ System.Xml.Schema.FacetsChecker.FacetsCompiler.Map[] c_map;
                    /*0x10*/ System.Xml.Schema.DatatypeImplementation datatype;
                    /*0x18*/ System.Xml.Schema.RestrictionFacets derivedRestriction;
                    /*0x20*/ System.Xml.Schema.RestrictionFlags baseFlags;
                    /*0x24*/ System.Xml.Schema.RestrictionFlags baseFixedFlags;
                    /*0x28*/ System.Xml.Schema.RestrictionFlags validRestrictionFlags;
                    /*0x30*/ System.Xml.Schema.XmlSchemaDatatype nonNegativeInt;
                    /*0x38*/ System.Xml.Schema.XmlSchemaDatatype builtInType;
                    /*0x40*/ System.Xml.Schema.XmlTypeCode builtInEnum;
                    /*0x44*/ bool firstPattern;
                    /*0x48*/ System.Text.StringBuilder regStr;
                    /*0x50*/ System.Xml.Schema.XmlSchemaPatternFacet pattern_facet;

                    static /*0x7678050*/ FacetsCompiler();
                    static /*0x76779c0*/ string Preprocess(string pattern);
                    /*0x7674af0*/ FacetsCompiler(System.Xml.Schema.DatatypeImplementation baseDatatype, System.Xml.Schema.RestrictionFacets restriction);
                    /*0x7674d38*/ void CompileLengthFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x767508c*/ void CompileMinLengthFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x76753a4*/ void CompileMaxLengthFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x76756bc*/ void CompilePatternFacet(System.Xml.Schema.XmlSchemaPatternFacet facet);
                    /*0x7675840*/ void CompileEnumerationFacet(System.Xml.Schema.XmlSchemaFacet facet, System.Xml.IXmlNamespaceResolver nsmgr, System.Xml.XmlNameTable nameTable);
                    /*0x7675998*/ void CompileWhitespaceFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x76760a0*/ void CompileMaxInclusiveFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x7676270*/ void CompileMaxExclusiveFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x7675d00*/ void CompileMinInclusiveFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x7675ed0*/ void CompileMinExclusiveFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x7676440*/ void CompileTotalDigitsFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x7676750*/ void CompileFractionDigitsFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x7676a04*/ void FinishFacetCompile();
                    /*0x767752c*/ void CheckValue(object value, System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x7676d78*/ void CompileFacetCombinations();
                    /*0x7677c1c*/ void CopyFacetsFromBaseType();
                    /*0x7677380*/ object ParseFacetValue(System.Xml.Schema.XmlSchemaDatatype datatype, System.Xml.Schema.XmlSchemaFacet facet, string code, System.Xml.IXmlNamespaceResolver nsmgr, System.Xml.XmlNameTable nameTable);
                    /*0x7677284*/ void CheckProhibitedFlag(System.Xml.Schema.XmlSchemaFacet facet, System.Xml.Schema.RestrictionFlags flag, string errorCode);
                    /*0x7677310*/ void CheckDupFlag(System.Xml.Schema.XmlSchemaFacet facet, System.Xml.Schema.RestrictionFlags flag, string errorCode);
                    /*0x76774c4*/ void SetFlag(System.Xml.Schema.XmlSchemaFacet facet, System.Xml.Schema.RestrictionFlags flag);
                    /*0x7678014*/ void SetFlag(System.Xml.Schema.RestrictionFlags flag);

                    struct Map
                    {
                        /*0x10*/ char match;
                        /*0x18*/ string replacement;

                        /*0x767835c*/ Map(char m, string r);
                    }
                }
            }

            class Numeric10FacetsChecker : System.Xml.Schema.FacetsChecker
            {
                static /*0x0*/ char[] signs;
                /*0x10*/ decimal maxValue;
                /*0x20*/ decimal minValue;

                static /*0x7678ce4*/ Numeric10FacetsChecker();
                /*0x766b1c4*/ Numeric10FacetsChecker(decimal minVal, decimal maxVal);
                /*0x767836c*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x76783dc*/ System.Exception CheckValueFacets(decimal value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7678abc*/ System.Exception CheckValueFacets(long value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7678b48*/ System.Exception CheckValueFacets(int value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7678bd4*/ System.Exception CheckValueFacets(short value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7678c60*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7678998*/ bool MatchEnumeration(decimal value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlValueConverter valueConverter);
                /*0x76714c8*/ System.Exception CheckTotalAndFractionDigits(decimal value, int totalDigits, int fractionDigits, bool checkTotal, bool checkFraction);
            }

            class Numeric2FacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x7664d38*/ Numeric2FacetsChecker();
                /*0x7678d84*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7678de4*/ System.Exception CheckValueFacets(double value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7679154*/ System.Exception CheckValueFacets(float value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7679164*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7679090*/ bool MatchEnumeration(double value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlValueConverter valueConverter);
            }

            class DurationFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x7664d48*/ DurationFacetsChecker();
                /*0x76791dc*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x76792e4*/ System.Exception CheckValueFacets(System.TimeSpan value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7679750*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7679638*/ bool MatchEnumeration(System.TimeSpan value, System.Collections.ArrayList enumeration);
            }

            class DateTimeFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x7664d40*/ DateTimeFacetsChecker();
                /*0x76797c8*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x767982c*/ System.Exception CheckValueFacets(System.DateTime value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7679d54*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7679c14*/ bool MatchEnumeration(System.DateTime value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
            }

            class StringFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                static /*0x0*/ System.Text.RegularExpressions.Regex languagePattern;

                static /*0x7679db0*/ System.Text.RegularExpressions.Regex get_LanguagePattern();
                /*0x7664d30*/ StringFacetsChecker();
                /*0x7679e60*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7679ec0*/ System.Exception CheckValueFacets(string value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x766cd80*/ System.Exception CheckValueFacets(string value, System.Xml.Schema.XmlSchemaDatatype datatype, bool verifyUri);
                /*0x767a2d4*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x767a104*/ bool MatchEnumeration(string value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7679ec8*/ System.Exception CheckBuiltInFacets(string s, System.Xml.Schema.XmlTypeCode typeCode, bool verifyUri);
            }

            class QNameFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x767a840*/ QNameFacetsChecker();
                /*0x767a330*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x767a450*/ System.Exception CheckValueFacets(System.Xml.XmlQualifiedName value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x767a738*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x767a624*/ bool MatchEnumeration(System.Xml.XmlQualifiedName value, System.Collections.ArrayList enumeration);
            }

            class MiscFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x767a848*/ MiscFacetsChecker();
            }

            class BinaryFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x767ac48*/ BinaryFacetsChecker();
                /*0x767a850*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x767a8e0*/ System.Exception CheckValueFacets(byte[] value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x767abc4*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x767aaa0*/ bool MatchEnumeration(byte[] value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
            }

            class ListFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x767af24*/ ListFacetsChecker();
                /*0x767ac50*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x767ae68*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
            }

            class UnionFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x767b0d4*/ UnionFacetsChecker();
                /*0x767af2c*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x767b018*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
            }

            interface IXmlSchemaInfo
            {
                /*0x3814574*/ System.Xml.Schema.XmlSchemaValidity get_Validity();
                /*0x3813ffc*/ bool get_IsDefault();
                /*0x3813ffc*/ bool get_IsNil();
                /*0x38148bc*/ System.Xml.Schema.XmlSchemaSimpleType get_MemberType();
                /*0x38148bc*/ System.Xml.Schema.XmlSchemaType get_SchemaType();
                /*0x38148bc*/ System.Xml.Schema.XmlSchemaElement get_SchemaElement();
                /*0x38148bc*/ System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute();
            }

            class XmlSchemaInference
            {
                static /*0x0*/ System.Xml.XmlQualifiedName ST_boolean;
                static /*0x8*/ System.Xml.XmlQualifiedName ST_byte;
                static /*0x10*/ System.Xml.XmlQualifiedName ST_unsignedByte;
                static /*0x18*/ System.Xml.XmlQualifiedName ST_short;
                static /*0x20*/ System.Xml.XmlQualifiedName ST_unsignedShort;
                static /*0x28*/ System.Xml.XmlQualifiedName ST_int;
                static /*0x30*/ System.Xml.XmlQualifiedName ST_unsignedInt;
                static /*0x38*/ System.Xml.XmlQualifiedName ST_long;
                static /*0x40*/ System.Xml.XmlQualifiedName ST_unsignedLong;
                static /*0x48*/ System.Xml.XmlQualifiedName ST_integer;
                static /*0x50*/ System.Xml.XmlQualifiedName ST_decimal;
                static /*0x58*/ System.Xml.XmlQualifiedName ST_float;
                static /*0x60*/ System.Xml.XmlQualifiedName ST_double;
                static /*0x68*/ System.Xml.XmlQualifiedName ST_duration;
                static /*0x70*/ System.Xml.XmlQualifiedName ST_dateTime;
                static /*0x78*/ System.Xml.XmlQualifiedName ST_time;
                static /*0x80*/ System.Xml.XmlQualifiedName ST_date;
                static /*0x88*/ System.Xml.XmlQualifiedName ST_gYearMonth;
                static /*0x90*/ System.Xml.XmlQualifiedName ST_string;
                static /*0x98*/ System.Xml.XmlQualifiedName ST_anySimpleType;
                static /*0xa0*/ System.Xml.XmlQualifiedName[] SimpleTypes;
                /*0x10*/ System.Xml.Schema.XmlSchema rootSchema;
                /*0x18*/ System.Xml.Schema.XmlSchemaSet schemaSet;
                /*0x20*/ System.Xml.XmlReader xtr;
                /*0x28*/ System.Xml.NameTable nametable;
                /*0x30*/ string TargetNamespace;
                /*0x38*/ System.Xml.XmlNamespaceManager NamespaceManager;
                /*0x40*/ System.Collections.ArrayList schemaList;
                /*0x48*/ System.Xml.Schema.XmlSchemaInference.InferenceOption occurrence;
                /*0x4c*/ System.Xml.Schema.XmlSchemaInference.InferenceOption typeInference;

                static /*0x76841fc*/ XmlSchemaInference();
                static /*0x7682b40*/ int InferSimpleType(string s, ref bool bNeedsRangeCheck);
                static /*0x76840e8*/ int DateTime(string s, bool bDate, bool bTime);
                static /*0x767f8a0*/ int GetSchemaType(System.Xml.XmlQualifiedName qname);
                /*0x767b0f4*/ XmlSchemaInference();
                /*0x767b0dc*/ void set_Occurrence(System.Xml.Schema.XmlSchemaInference.InferenceOption value);
                /*0x767b0e4*/ System.Xml.Schema.XmlSchemaInference.InferenceOption get_Occurrence();
                /*0x767b0ec*/ void set_TypeInference(System.Xml.Schema.XmlSchemaInference.InferenceOption value);
                /*0x767b230*/ System.Xml.Schema.XmlSchemaSet InferSchema(System.Xml.XmlReader instanceDocument);
                /*0x767b2a4*/ System.Xml.Schema.XmlSchemaSet InferSchema1(System.Xml.XmlReader instanceDocument, System.Xml.Schema.XmlSchemaSet schemas);
                /*0x767d790*/ System.Xml.Schema.XmlSchemaAttribute AddAttribute(string localName, string prefix, string childURI, string attrValue, bool bCreatingNewType, System.Xml.Schema.XmlSchema parentSchema, System.Xml.Schema.XmlSchemaObjectCollection addLocation, System.Xml.Schema.XmlSchemaObjectTable compiledAttributes);
                /*0x7680074*/ System.Xml.Schema.XmlSchema CreateXmlSchema(string targetNS);
                /*0x767bd10*/ System.Xml.Schema.XmlSchemaElement AddElement(string localName, string prefix, string childURI, System.Xml.Schema.XmlSchema parentSchema, System.Xml.Schema.XmlSchemaObjectCollection addLocation, int positionWithinCollection);
                /*0x767c324*/ void InferElement(System.Xml.Schema.XmlSchemaElement xse, bool bCreatingNewType, System.Xml.Schema.XmlSchema parentSchema);
                /*0x7680d7c*/ System.Xml.Schema.XmlSchemaSimpleContentExtension CheckSimpleContentExtension(System.Xml.Schema.XmlSchemaComplexType ct);
                /*0x76804b4*/ System.Xml.Schema.XmlSchemaType GetEffectiveSchemaType(System.Xml.Schema.XmlSchemaElement elem, bool bCreatingNewType);
                /*0x7681344*/ System.Xml.Schema.XmlSchemaElement FindMatchingElement(bool bCreatingNewType, System.Xml.XmlReader xtr, System.Xml.Schema.XmlSchemaComplexType ct, ref int lastUsedSeqItem, ref bool bParticleChanged, System.Xml.Schema.XmlSchema parentSchema, bool setMaxoccurs);
                /*0x76805ec*/ void ProcessAttributes(ref System.Xml.Schema.XmlSchemaElement xse, System.Xml.Schema.XmlSchemaType effectiveSchemaType, bool bCreatingNewType, System.Xml.Schema.XmlSchema parentSchema);
                /*0x76812a8*/ void MoveAttributes(System.Xml.Schema.XmlSchemaSimpleContentExtension scExtension, System.Xml.Schema.XmlSchemaComplexType ct);
                /*0x7680eb4*/ void MoveAttributes(System.Xml.Schema.XmlSchemaComplexType ct, System.Xml.Schema.XmlSchemaSimpleContentExtension simpleContentExtension, bool bCreatingNewType);
                /*0x767e378*/ System.Xml.Schema.XmlSchemaAttribute FindAttribute(System.Collections.ICollection attributes, string attrName);
                /*0x7680110*/ System.Xml.Schema.XmlSchemaElement FindGlobalElement(string namespaceURI, string localName, ref System.Xml.Schema.XmlSchema parentSchema);
                /*0x76824b4*/ System.Xml.Schema.XmlSchemaElement FindElement(System.Xml.Schema.XmlSchemaObjectCollection elements, string elementName);
                /*0x767dfb0*/ System.Xml.Schema.XmlSchemaAttribute FindAttributeRef(System.Collections.ICollection attributes, string attributeName, string nsURI);
                /*0x76825e4*/ System.Xml.Schema.XmlSchemaElement FindElementRef(System.Xml.Schema.XmlSchemaObjectCollection elements, string elementName, string nsURI);
                /*0x7680cec*/ void MakeExistingAttributesOptional(System.Xml.Schema.XmlSchemaComplexType ct, System.Xml.Schema.XmlSchemaObjectCollection attributesInInstance);
                /*0x7682a1c*/ void SwitchUseToOptional(System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaObjectCollection attributesInInstance);
                /*0x767e6fc*/ System.Xml.XmlQualifiedName RefineSimpleType(string s, ref int iTypeFlags);
                /*0x7682744*/ System.Xml.Schema.XmlSchemaElement CreateNewElementforChoice(System.Xml.Schema.XmlSchemaElement copyElement);
                /*0x7682328*/ void SetMinMaxOccurs(System.Xml.Schema.XmlSchemaElement el, bool setMaxOccurs);

                enum InferenceOption
                {
                    Restricted = 0,
                    Relaxed = 1,
                }
            }

            class XmlSchemaInferenceException : System.Xml.Schema.XmlSchemaException
            {
                /*0x7684ce0*/ XmlSchemaInferenceException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x7684cf0*/ XmlSchemaInferenceException();
                /*0x7682968*/ XmlSchemaInferenceException(string res, string arg);
                /*0x767bcdc*/ XmlSchemaInferenceException(string res, int lineNumber, int linePosition);
                /*0x7684ce8*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            class NamespaceList
            {
                /*0x10*/ System.Xml.Schema.NamespaceList.ListType type;
                /*0x18*/ System.Collections.Hashtable set;
                /*0x20*/ string targetNamespace;

                static /*0x7685700*/ bool IsSubset(System.Xml.Schema.NamespaceList sub, System.Xml.Schema.NamespaceList super);
                static /*0x7685ad8*/ System.Xml.Schema.NamespaceList Union(System.Xml.Schema.NamespaceList o1, System.Xml.Schema.NamespaceList o2, bool v1Compat);
                static /*0x7686184*/ System.Xml.Schema.NamespaceList Intersection(System.Xml.Schema.NamespaceList o1, System.Xml.Schema.NamespaceList o2, bool v1Compat);
                /*0x7684cfc*/ NamespaceList();
                /*0x7684d04*/ NamespaceList(string namespaces, string targetNamespace);
                /*0x7684fac*/ System.Xml.Schema.NamespaceList Clone();
                /*0x76850ec*/ System.Xml.Schema.NamespaceList.ListType get_Type();
                /*0x76850f4*/ string get_Excluded();
                /*0x76850fc*/ System.Collections.ICollection get_Enumerate();
                /*0x7685160*/ bool Allows(string ns);
                /*0x76851e4*/ bool Allows(System.Xml.XmlQualifiedName qname);
                /*0x7685204*/ string ToString();
                /*0x7686064*/ System.Xml.Schema.NamespaceList CompareSetToOther(System.Xml.Schema.NamespaceList other);
                /*0x76866d0*/ void RemoveNamespace(string tns);

                enum ListType
                {
                    Any = 0,
                    Other = 1,
                    Set = 2,
                }
            }

            class NamespaceListV1Compat : System.Xml.Schema.NamespaceList
            {
                /*0x7686730*/ NamespaceListV1Compat(string namespaces, string targetNamespace);
                /*0x7686734*/ bool Allows(string ns);
            }

            class Parser
            {
                /*0x10*/ System.Xml.Schema.SchemaType schemaType;
                /*0x18*/ System.Xml.XmlNameTable nameTable;
                /*0x20*/ System.Xml.Schema.SchemaNames schemaNames;
                /*0x28*/ System.Xml.Schema.ValidationEventHandler eventHandler;
                /*0x30*/ System.Xml.XmlNamespaceManager namespaceManager;
                /*0x38*/ System.Xml.XmlReader reader;
                /*0x40*/ System.Xml.PositionInfo positionInfo;
                /*0x48*/ bool isProcessNamespaces;
                /*0x4c*/ int schemaXmlDepth;
                /*0x50*/ int markupDepth;
                /*0x58*/ System.Xml.Schema.SchemaBuilder builder;
                /*0x60*/ System.Xml.Schema.XmlSchema schema;
                /*0x68*/ System.Xml.Schema.SchemaInfo xdrSchema;
                /*0x70*/ System.Xml.XmlResolver xmlResolver;
                /*0x78*/ System.Xml.XmlDocument dummyDocument;
                /*0x80*/ bool processMarkup;
                /*0x88*/ System.Xml.XmlNode parentNode;
                /*0x90*/ System.Xml.XmlNamespaceManager annotationNSManager;
                /*0x98*/ string xmlns;
                /*0xa0*/ System.Xml.XmlCharType xmlCharType;

                /*0x7686758*/ Parser(System.Xml.Schema.SchemaType schemaType, System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler);
                /*0x7686854*/ System.Xml.Schema.SchemaType Parse(System.Xml.XmlReader reader, string targetNamespace);
                /*0x76868a4*/ void StartParsing(System.Xml.XmlReader reader, string targetNamespace);
                /*0x7687384*/ bool CheckSchemaRoot(System.Xml.Schema.SchemaType rootType, ref string code);
                /*0x76874a8*/ System.Xml.Schema.SchemaType FinishParsing();
                /*0x76874b0*/ System.Xml.Schema.XmlSchema get_XmlSchema();
                /*0x76874b8*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x76874c0*/ System.Xml.Schema.SchemaInfo get_XdrSchema();
                /*0x7686cdc*/ bool ParseReaderNode();
                /*0x76874c8*/ void ProcessAppInfoDocMarkup(bool root);
                /*0x76876fc*/ System.Xml.XmlElement LoadElementNode(bool root);
                /*0x7687c3c*/ System.Xml.XmlAttribute CreateXmlNsAttribute(string prefix, string value);
                /*0x7687ac8*/ System.Xml.XmlAttribute LoadAttributeNode();
                /*0x7687d4c*/ System.Xml.XmlEntityReference LoadEntityReferenceInAttribute();
            }

            enum Compositor
            {
                Root = 0,
                Include = 1,
                Import = 2,
                Redefine = 3,
            }

            class RedefineEntry
            {
                /*0x10*/ System.Xml.Schema.XmlSchemaRedefine redefine;
                /*0x18*/ System.Xml.Schema.XmlSchema schemaToUpdate;

                /*0x7687f34*/ RedefineEntry(System.Xml.Schema.XmlSchemaRedefine external, System.Xml.Schema.XmlSchema schema);
            }

            class Preprocessor : System.Xml.Schema.BaseProcessor
            {
                static /*0x0*/ System.Xml.Schema.XmlSchema builtInSchemaForXmlNS;
                /*0x40*/ string Xmlns;
                /*0x48*/ string NsXsi;
                /*0x50*/ string targetNamespace;
                /*0x58*/ System.Xml.Schema.XmlSchema rootSchema;
                /*0x60*/ System.Xml.Schema.XmlSchema currentSchema;
                /*0x68*/ System.Xml.Schema.XmlSchemaForm elementFormDefault;
                /*0x6c*/ System.Xml.Schema.XmlSchemaForm attributeFormDefault;
                /*0x70*/ System.Xml.Schema.XmlSchemaDerivationMethod blockDefault;
                /*0x74*/ System.Xml.Schema.XmlSchemaDerivationMethod finalDefault;
                /*0x78*/ System.Collections.Hashtable schemaLocations;
                /*0x80*/ System.Collections.Hashtable chameleonSchemas;
                /*0x88*/ System.Collections.Hashtable referenceNamespaces;
                /*0x90*/ System.Collections.Hashtable processedExternals;
                /*0x98*/ System.Collections.SortedList lockList;
                /*0xa0*/ System.Xml.XmlReaderSettings readerSettings;
                /*0xa8*/ System.Xml.Schema.XmlSchema rootSchemaForRedefine;
                /*0xb0*/ System.Collections.ArrayList redefinedList;
                /*0xb8*/ System.Xml.XmlResolver xmlResolver;

                static /*0x768b3b0*/ System.Xml.Schema.XmlSchema GetBuildInSchema();
                static /*0x768edfc*/ System.Xml.Schema.XmlSchema GetParentSchema(System.Xml.Schema.XmlSchemaObject currentSchemaObject);
                /*0x7687f78*/ Preprocessor(System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler, System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings);
                /*0x7688078*/ bool Execute(System.Xml.Schema.XmlSchema schema, string targetNamespace, bool loadExternals);
                /*0x768b2dc*/ void Cleanup(System.Xml.Schema.XmlSchema schema);
                /*0x768b9b0*/ void CleanupRedefine(System.Xml.Schema.XmlSchemaExternal include);
                /*0x768ba50*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x768ba58*/ void set_ReaderSettings(System.Xml.XmlReaderSettings value);
                /*0x768ba60*/ void set_SchemaLocations(System.Collections.Hashtable value);
                /*0x768ba68*/ void set_ChameleonSchemas(System.Collections.Hashtable value);
                /*0x768ba70*/ System.Xml.Schema.XmlSchema get_RootSchema();
                /*0x7689360*/ void BuildSchemaList(System.Xml.Schema.XmlSchema schema);
                /*0x76886bc*/ void LoadExternals(System.Xml.Schema.XmlSchema schema);
                /*0x768bae0*/ void BuildRefNamespaces(System.Xml.Schema.XmlSchema schema);
                /*0x768bcf4*/ void ParseUri(string uri, string code, System.Xml.Schema.XmlSchemaObject sourceSchemaObject);
                /*0x76894cc*/ void Preprocess(System.Xml.Schema.XmlSchema schema, string targetNamespace, System.Collections.ArrayList imports);
                /*0x768c320*/ void CopyIncludedComponents(System.Xml.Schema.XmlSchema includedSchema, System.Xml.Schema.XmlSchema schema);
                /*0x768a778*/ void PreprocessRedefine(System.Xml.Schema.RedefineEntry redefineEntry);
                /*0x768ee90*/ void GetIncludedSet(System.Xml.Schema.XmlSchema schema, System.Collections.ArrayList includesList);
                /*0x768c214*/ void SetSchemaDefaults(System.Xml.Schema.XmlSchema schema);
                /*0x768f5d4*/ int CountGroupSelfReference(System.Xml.Schema.XmlSchemaObjectCollection items, System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaGroup redefined);
                /*0x768efbc*/ void CheckRefinedGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x768f05c*/ void CheckRefinedAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x768f4c8*/ void CheckRefinedSimpleType(System.Xml.Schema.XmlSchemaSimpleType stype);
                /*0x768f1b4*/ void CheckRefinedComplexType(System.Xml.Schema.XmlSchemaComplexType ctype);
                /*0x768d5e4*/ void PreprocessAttribute(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x768fdb4*/ void PreprocessLocalAttribute(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x768fb84*/ void PreprocessAttributeContent(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x768d754*/ void PreprocessAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x768e6f8*/ void PreprocessElement(System.Xml.Schema.XmlSchemaElement element);
                /*0x769089c*/ void PreprocessLocalElement(System.Xml.Schema.XmlSchemaElement element);
                /*0x7690564*/ void PreprocessElementContent(System.Xml.Schema.XmlSchemaElement element);
                /*0x7690c3c*/ void PreprocessIdentityConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint constraint);
                /*0x768e124*/ void PreprocessSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType, bool local);
                /*0x768d858*/ void PreprocessComplexType(System.Xml.Schema.XmlSchemaComplexType complexType, bool local);
                /*0x768e94c*/ void PreprocessGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x768eb1c*/ void PreprocessNotation(System.Xml.Schema.XmlSchemaNotation notation);
                /*0x7690f9c*/ void PreprocessParticle(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x76901dc*/ void PreprocessAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute, System.Xml.Schema.XmlSchemaObject parent);
                /*0x768bf08*/ void ValidateIdAttribute(System.Xml.Schema.XmlSchemaObject xso);
                /*0x768f8c4*/ void ValidateNameAttribute(System.Xml.Schema.XmlSchemaObject xso);
                /*0x768ffa0*/ void ValidateQNameAttribute(System.Xml.Schema.XmlSchemaObject xso, string attributeName, System.Xml.XmlQualifiedName value);
                /*0x768ba78*/ System.Uri ResolveSchemaLocationUri(System.Xml.Schema.XmlSchema enclosingSchema, string location);
                /*0x768bab8*/ object GetSchemaEntity(System.Uri ruri);
                /*0x768857c*/ System.Xml.Schema.XmlSchema GetChameleonSchema(string targetNamespace, System.Xml.Schema.XmlSchema schema);
                /*0x768be48*/ void SetParent(System.Xml.Schema.XmlSchemaObject child, System.Xml.Schema.XmlSchemaObject parent);
                /*0x768be68*/ void PreprocessAnnotation(System.Xml.Schema.XmlSchemaObject schemaObject);
                /*0x768ed84*/ void PreprocessAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
            }

            class SchemaAttDef : System.Xml.Schema.SchemaDeclBase, System.Xml.IDtdDefaultAttributeInfo, System.Xml.IDtdAttributeInfo
            {
                static /*0x0*/ System.Xml.Schema.SchemaAttDef Empty;
                /*0x60*/ string defExpanded;
                /*0x68*/ int lineNum;
                /*0x6c*/ int linePos;
                /*0x70*/ int valueLineNum;
                /*0x74*/ int valueLinePos;
                /*0x78*/ System.Xml.Schema.SchemaAttDef.Reserve reserved;
                /*0x7c*/ bool defaultValueChecked;
                /*0x80*/ System.Xml.Schema.XmlSchemaAttribute schemaAttribute;

                static /*0x7691d0c*/ SchemaAttDef();
                /*0x7691890*/ SchemaAttDef(System.Xml.XmlQualifiedName name, string prefix);
                /*0x7691898*/ SchemaAttDef(System.Xml.XmlQualifiedName name);
                /*0x76918a4*/ SchemaAttDef();
                /*0x76918ac*/ string System.Xml.IDtdAttributeInfo.get_Prefix();
                /*0x76918b4*/ string System.Xml.IDtdAttributeInfo.get_LocalName();
                /*0x76918d0*/ int System.Xml.IDtdAttributeInfo.get_LineNumber();
                /*0x76918d8*/ int System.Xml.IDtdAttributeInfo.get_LinePosition();
                /*0x76918e0*/ bool System.Xml.IDtdAttributeInfo.get_IsNonCDataType();
                /*0x769192c*/ bool System.Xml.IDtdAttributeInfo.get_IsDeclaredInExternal();
                /*0x7691934*/ bool System.Xml.IDtdAttributeInfo.get_IsXmlAttribute();
                /*0x7691944*/ string System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueExpanded();
                /*0x769198c*/ object System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueTyped();
                /*0x7691994*/ int System.Xml.IDtdDefaultAttributeInfo.get_ValueLineNumber();
                /*0x769199c*/ int System.Xml.IDtdDefaultAttributeInfo.get_ValueLinePosition();
                /*0x76919a4*/ int get_LinePosition();
                /*0x76919ac*/ void set_LinePosition(int value);
                /*0x76919b4*/ int get_LineNumber();
                /*0x76919bc*/ void set_LineNumber(int value);
                /*0x76919c4*/ int get_ValueLinePosition();
                /*0x76919cc*/ void set_ValueLinePosition(int value);
                /*0x76919d4*/ int get_ValueLineNumber();
                /*0x76919dc*/ void set_ValueLineNumber(int value);
                /*0x7691968*/ string get_DefaultValueExpanded();
                /*0x76919e4*/ void set_DefaultValueExpanded(string value);
                /*0x769190c*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x76919ec*/ void set_TokenizedType(System.Xml.XmlTokenizedType value);
                /*0x7691a14*/ System.Xml.Schema.SchemaAttDef.Reserve get_Reserved();
                /*0x7691a1c*/ void set_Reserved(System.Xml.Schema.SchemaAttDef.Reserve value);
                /*0x7691a24*/ bool get_DefaultValueChecked();
                /*0x7691a2c*/ System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute();
                /*0x7691a34*/ void set_SchemaAttribute(System.Xml.Schema.XmlSchemaAttribute value);
                /*0x7691a3c*/ void CheckXmlSpace(System.Xml.IValidationEventHandling validationEventHandling);
                /*0x7691ca8*/ System.Xml.Schema.SchemaAttDef Clone();

                enum Reserve
                {
                    None = 0,
                    XmlSpace = 1,
                    XmlLang = 2,
                }
            }

            class SchemaBuilder
            {
                /*0x7691d74*/ SchemaBuilder();
                bool ProcessElement(string prefix, string name, string ns);
                /*0x3816958*/ void ProcessAttribute(string prefix, string name, string ns, string value);
                /*0x3813ffc*/ bool IsContentParsed();
                /*0x3816710*/ void ProcessMarkup(System.Xml.XmlNode[] markup);
                /*0x3816710*/ void ProcessCData(string value);
                /*0x38159dc*/ void StartChildren();
                /*0x38159dc*/ void EndChildren();
            }

            class SchemaCollectionCompiler : System.Xml.Schema.BaseProcessor
            {
                /*0x40*/ bool compileContentModel;
                /*0x48*/ System.Xml.Schema.XmlSchemaObjectTable examplars;
                /*0x50*/ System.Collections.Stack complexTypeStack;
                /*0x58*/ System.Xml.Schema.XmlSchema schema;

                static /*0x7696848*/ void Cleanup(System.Xml.Schema.XmlSchema schema);
                static /*0x7696810*/ void CleanupAttribute(System.Xml.Schema.XmlSchemaAttribute attribute);
                static /*0x76962f8*/ void CleanupAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                static /*0x769633c*/ void CleanupComplexType(System.Xml.Schema.XmlSchemaComplexType complexType);
                static /*0x7696674*/ void CleanupSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType);
                static /*0x769668c*/ void CleanupElement(System.Xml.Schema.XmlSchemaElement element);
                static /*0x769b39c*/ void CleanupAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes);
                static /*0x76962cc*/ void CleanupGroup(System.Xml.Schema.XmlSchemaGroup group);
                static /*0x769b460*/ void CleanupParticle(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x7691d7c*/ SchemaCollectionCompiler(System.Xml.XmlNameTable nameTable, System.Xml.Schema.ValidationEventHandler eventHandler);
                /*0x7691e44*/ bool Execute(System.Xml.Schema.XmlSchema schema, System.Xml.Schema.SchemaInfo schemaInfo, bool compileContentModel);
                /*0x7691eb8*/ void Prepare();
                /*0x7692340*/ void Cleanup();
                /*0x769323c*/ void Compile();
                /*0x7695294*/ void Output(System.Xml.Schema.SchemaInfo schemaInfo);
                /*0x7696e58*/ void CompileSubstitutionGroup(System.Xml.Schema.XmlSchemaSubstitutionGroupV1Compat substitutionGroup);
                /*0x769b1c8*/ void CheckSubstitutionGroup(System.Xml.Schema.XmlSchemaSubstitutionGroup substitutionGroup);
                /*0x76972d8*/ void CompileGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x769881c*/ void CompileSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType);
                /*0x769b95c*/ System.Xml.Schema.XmlSchemaSimpleType[] CompileBaseMemberTypes(System.Xml.Schema.XmlSchemaSimpleType simpleType);
                /*0x769bd00*/ void CheckUnionType(System.Xml.Schema.XmlSchemaSimpleType unionMember, System.Collections.ArrayList memberTypeDefinitions, System.Xml.Schema.XmlSchemaSimpleType parentType);
                /*0x7697b18*/ void CompileComplexType(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x769be18*/ void CompileSimpleContentExtension(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaSimpleContentExtension simpleExtension);
                /*0x769c070*/ void CompileSimpleContentRestriction(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaSimpleContentRestriction simpleRestriction);
                /*0x769c4bc*/ void CompileComplexContentExtension(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaComplexContentExtension complexExtension);
                /*0x769c8a8*/ void CompileComplexContentRestriction(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaComplexContentRestriction complexRestriction);
                /*0x769b09c*/ void CheckParticleDerivation(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x769e0cc*/ System.Xml.Schema.XmlSchemaParticle CompileContentTypeParticle(System.Xml.Schema.XmlSchemaParticle particle, bool substitution);
                /*0x769b5c4*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeParticle(System.Xml.Schema.XmlSchemaParticle particle, bool root, bool substitution);
                /*0x769f4ac*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeElement(System.Xml.Schema.XmlSchemaElement element, bool substitution);
                /*0x769f5fc*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeGroupRef(System.Xml.Schema.XmlSchemaGroupRef groupRef, bool root, bool substitution);
                /*0x769fb50*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeAll(System.Xml.Schema.XmlSchemaAll all, bool root, bool substitution);
                /*0x769fff0*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeChoice(System.Xml.Schema.XmlSchemaChoice choice, bool root, bool substitution);
                /*0x76a04f0*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeSequence(System.Xml.Schema.XmlSchemaSequence sequence, bool root, bool substitution);
                /*0x769eee4*/ bool IsValidRestriction(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle);
                /*0x76a0a54*/ bool IsElementFromElement(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaElement baseElement);
                /*0x76a0b68*/ bool IsElementFromAny(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaAny baseAny);
                /*0x76a0bc4*/ bool IsAnyFromAny(System.Xml.Schema.XmlSchemaAny derivedAny, System.Xml.Schema.XmlSchemaAny baseAny);
                /*0x76a0c10*/ bool IsGroupBaseFromAny(System.Xml.Schema.XmlSchemaGroupBase derivedGroupBase, System.Xml.Schema.XmlSchemaAny baseAny);
                /*0x76a0e18*/ bool IsElementFromGroupBase(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly);
                /*0x76a1180*/ bool IsGroupBaseFromGroupBase(System.Xml.Schema.XmlSchemaGroupBase derivedGroupBase, System.Xml.Schema.XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly);
                /*0x76a13f4*/ bool IsSequenceFromAll(System.Xml.Schema.XmlSchemaSequence derivedSequence, System.Xml.Schema.XmlSchemaAll baseAll);
                /*0x76a1700*/ bool IsSequenceFromChoice(System.Xml.Schema.XmlSchemaSequence derivedSequence, System.Xml.Schema.XmlSchemaChoice baseChoice);
                /*0x76a22f8*/ void CalculateSequenceRange(System.Xml.Schema.XmlSchemaSequence sequence, ref decimal minOccurs, ref decimal maxOccurs);
                /*0x76a1900*/ bool IsValidOccurrenceRangeRestriction(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle);
                /*0x76a211c*/ bool IsValidOccurrenceRangeRestriction(decimal minOccurs, decimal maxOccurs, decimal baseMinOccurs, decimal baseMaxOccurs);
                /*0x76a2204*/ int GetMappingParticle(System.Xml.Schema.XmlSchemaParticle particle, System.Xml.Schema.XmlSchemaObjectCollection collection);
                /*0x76a0990*/ bool IsParticleEmptiable(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x76a1944*/ void CalculateEffectiveTotalRange(System.Xml.Schema.XmlSchemaParticle particle, ref decimal minOccurs, ref decimal maxOccurs);
                /*0x76a26b4*/ void PushComplexType(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x769e230*/ System.Xml.Schema.XmlSchemaContentType GetSchemaContentType(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaParticle particle);
                /*0x76973c0*/ void CompileAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x769cb98*/ void CompileLocalAttributes(System.Xml.Schema.XmlSchemaComplexType baseType, System.Xml.Schema.XmlSchemaComplexType derivedType, System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute, System.Xml.Schema.XmlSchemaDerivationMethod derivedBy);
                /*0x76a276c*/ System.Xml.Schema.XmlSchemaAnyAttribute CompileAnyAttributeUnion(System.Xml.Schema.XmlSchemaAnyAttribute a, System.Xml.Schema.XmlSchemaAnyAttribute b);
                /*0x76a26d8*/ System.Xml.Schema.XmlSchemaAnyAttribute CompileAnyAttributeIntersection(System.Xml.Schema.XmlSchemaAnyAttribute a, System.Xml.Schema.XmlSchemaAnyAttribute b);
                /*0x7699e7c*/ void CompileAttribute(System.Xml.Schema.XmlSchemaAttribute xa);
                /*0x769a920*/ void CompileIdentityConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint xi);
                /*0x7699178*/ void CompileElement(System.Xml.Schema.XmlSchemaElement xe);
                /*0x769e2a0*/ System.Xml.Schema.ContentValidator CompileComplexContent(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x76a2800*/ void BuildParticleContentModel(System.Xml.Schema.ParticleContentValidator contentValidator, System.Xml.Schema.XmlSchemaParticle particle);
                /*0x76a2cf4*/ void CompileParticleElements(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaParticle particle);
                /*0x769afc8*/ void CompileCompexTypeElements(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x769b810*/ System.Xml.Schema.XmlSchemaSimpleType GetSimpleType(System.Xml.XmlQualifiedName name);
                /*0x769ee30*/ System.Xml.Schema.XmlSchemaComplexType GetComplexType(System.Xml.XmlQualifiedName name);
                /*0x769eccc*/ System.Xml.Schema.XmlSchemaType GetAnySchemaType(System.Xml.XmlQualifiedName name);
            }

            class SchemaCollectionPreprocessor : System.Xml.Schema.BaseProcessor
            {
                /*0x40*/ System.Xml.Schema.XmlSchema schema;
                /*0x48*/ string targetNamespace;
                /*0x50*/ bool buildinIncluded;
                /*0x54*/ System.Xml.Schema.XmlSchemaForm elementFormDefault;
                /*0x58*/ System.Xml.Schema.XmlSchemaForm attributeFormDefault;
                /*0x5c*/ System.Xml.Schema.XmlSchemaDerivationMethod blockDefault;
                /*0x60*/ System.Xml.Schema.XmlSchemaDerivationMethod finalDefault;
                /*0x68*/ System.Collections.Hashtable schemaLocations;
                /*0x70*/ System.Collections.Hashtable referenceNamespaces;
                /*0x78*/ string Xmlns;
                /*0x80*/ System.Xml.XmlResolver xmlResolver;

                /*0x76a2f48*/ SchemaCollectionPreprocessor(System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler);
                /*0x76a2f50*/ bool Execute(System.Xml.Schema.XmlSchema schema, string targetNamespace, bool loadExternals, System.Xml.Schema.XmlSchemaCollection xsc);
                /*0x76a319c*/ void Cleanup(System.Xml.Schema.XmlSchema schema);
                /*0x76a6588*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x76a33b8*/ void LoadExternals(System.Xml.Schema.XmlSchema schema, System.Xml.Schema.XmlSchemaCollection xsc);
                /*0x76a6750*/ void BuildRefNamespaces(System.Xml.Schema.XmlSchema schema);
                /*0x76a3ffc*/ void Preprocess(System.Xml.Schema.XmlSchema schema, string targetNamespace, System.Xml.Schema.SchemaCollectionPreprocessor.Compositor compositor);
                /*0x76a6a60*/ void PreprocessRedefine(System.Xml.Schema.XmlSchemaRedefine redefine);
                /*0x76a9a0c*/ int CountGroupSelfReference(System.Xml.Schema.XmlSchemaObjectCollection items, System.Xml.XmlQualifiedName name);
                /*0x76a93ec*/ void CheckRefinedGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x76a9484*/ void CheckRefinedAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x76a9900*/ void CheckRefinedSimpleType(System.Xml.Schema.XmlSchemaSimpleType stype);
                /*0x76a95ec*/ void CheckRefinedComplexType(System.Xml.Schema.XmlSchemaComplexType ctype);
                /*0x76a7c04*/ void PreprocessAttribute(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x76aa1d8*/ void PreprocessLocalAttribute(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x76a9f98*/ void PreprocessAttributeContent(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x76a7d74*/ void PreprocessAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x76a8d20*/ void PreprocessElement(System.Xml.Schema.XmlSchemaElement element);
                /*0x76aabc8*/ void PreprocessLocalElement(System.Xml.Schema.XmlSchemaElement element);
                /*0x76aa870*/ void PreprocessElementContent(System.Xml.Schema.XmlSchemaElement element);
                /*0x76aaf64*/ void PreprocessIdentityConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint constraint);
                /*0x76a8734*/ void PreprocessSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType, bool local);
                /*0x76a7e74*/ void PreprocessComplexType(System.Xml.Schema.XmlSchemaComplexType complexType, bool local);
                /*0x76a8f74*/ void PreprocessGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x76a9140*/ void PreprocessNotation(System.Xml.Schema.XmlSchemaNotation notation);
                /*0x76ab2c0*/ void PreprocessParticle(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x76aa548*/ void PreprocessAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute, System.Xml.Schema.XmlSchemaObject parent);
                /*0x76a3da0*/ void ValidateIdAttribute(System.Xml.Schema.XmlSchemaObject xso);
                /*0x76a9cd8*/ void ValidateNameAttribute(System.Xml.Schema.XmlSchemaObject xso);
                /*0x76aa3c0*/ void ValidateQNameAttribute(System.Xml.Schema.XmlSchemaObject xso, string attributeName, System.Xml.XmlQualifiedName value);
                /*0x76a6954*/ void SetParent(System.Xml.Schema.XmlSchemaObject child, System.Xml.Schema.XmlSchemaObject parent);
                /*0x76a6974*/ void PreprocessAnnotation(System.Xml.Schema.XmlSchemaObject schemaObject);
                /*0x76a6590*/ System.Uri ResolveSchemaLocationUri(System.Xml.Schema.XmlSchema enclosingSchema, string location);
                /*0x76a663c*/ System.IO.Stream GetSchemaEntity(System.Uri ruri);

                enum Compositor
                {
                    Root = 0,
                    Include = 1,
                    Import = 2,
                }
            }

            class SchemaDeclBase
            {
                /*0x10*/ System.Xml.XmlQualifiedName name;
                /*0x18*/ string prefix;
                /*0x20*/ bool isDeclaredInExternal;
                /*0x24*/ System.Xml.Schema.SchemaDeclBase.Use presence;
                /*0x28*/ System.Xml.Schema.XmlSchemaType schemaType;
                /*0x30*/ System.Xml.Schema.XmlSchemaDatatype datatype;
                /*0x38*/ string defaultValueRaw;
                /*0x40*/ object defaultValueTyped;
                /*0x48*/ long maxLength;
                /*0x50*/ long minLength;
                /*0x58*/ System.Collections.Generic.List<string> values;

                /*0x76abb28*/ SchemaDeclBase(System.Xml.XmlQualifiedName name, string prefix);
                /*0x76abbd8*/ SchemaDeclBase();
                /*0x76abc48*/ System.Xml.XmlQualifiedName get_Name();
                /*0x76abc50*/ void set_Name(System.Xml.XmlQualifiedName value);
                /*0x76abc58*/ string get_Prefix();
                /*0x76abc7c*/ void set_Prefix(string value);
                /*0x76abc84*/ bool get_IsDeclaredInExternal();
                /*0x76abc8c*/ void set_IsDeclaredInExternal(bool value);
                /*0x76abc98*/ System.Xml.Schema.SchemaDeclBase.Use get_Presence();
                /*0x76abca0*/ void set_Presence(System.Xml.Schema.SchemaDeclBase.Use value);
                /*0x76abca8*/ long get_MaxLength();
                /*0x76abcb0*/ void set_MaxLength(long value);
                /*0x76abcb8*/ long get_MinLength();
                /*0x76abcc0*/ void set_MinLength(long value);
                /*0x76abcc8*/ System.Xml.Schema.XmlSchemaType get_SchemaType();
                /*0x76abcd0*/ void set_SchemaType(System.Xml.Schema.XmlSchemaType value);
                /*0x76abcd8*/ System.Xml.Schema.XmlSchemaDatatype get_Datatype();
                /*0x76abce0*/ void set_Datatype(System.Xml.Schema.XmlSchemaDatatype value);
                /*0x76abce8*/ void AddValue(string value);
                /*0x76abde8*/ System.Collections.Generic.List<string> get_Values();
                /*0x76abdf0*/ void set_Values(System.Collections.Generic.List<string> value);
                /*0x76abdf8*/ string get_DefaultValueRaw();
                /*0x76abe1c*/ void set_DefaultValueRaw(string value);
                /*0x76abe24*/ object get_DefaultValueTyped();
                /*0x76abe2c*/ void set_DefaultValueTyped(object value);
                /*0x76abe34*/ bool CheckEnumeration(object pVal);
                /*0x76abeec*/ bool CheckValue(object pVal);

                enum Use
                {
                    Default = 0,
                    Required = 1,
                    Implied = 2,
                    Fixed = 3,
                    RequiredFixed = 4,
                }
            }

            class SchemaElementDecl : System.Xml.Schema.SchemaDeclBase, System.Xml.IDtdAttributeListInfo
            {
                static /*0x0*/ System.Xml.Schema.SchemaElementDecl Empty;
                /*0x60*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaAttDef> attdefs;
                /*0x68*/ System.Collections.Generic.List<System.Xml.IDtdDefaultAttributeInfo> defaultAttdefs;
                /*0x70*/ bool isIdDeclared;
                /*0x71*/ bool hasNonCDataAttribute;
                /*0x72*/ bool isAbstract;
                /*0x73*/ bool isNillable;
                /*0x74*/ bool hasRequiredAttribute;
                /*0x75*/ bool isNotationDeclared;
                /*0x78*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.XmlQualifiedName> prohibitedAttributes;
                /*0x80*/ System.Xml.Schema.ContentValidator contentValidator;
                /*0x88*/ System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;
                /*0x90*/ System.Xml.Schema.XmlSchemaDerivationMethod block;
                /*0x98*/ System.Xml.Schema.CompiledIdentityConstraint[] constraints;
                /*0xa0*/ System.Xml.Schema.XmlSchemaElement schemaElement;

                static /*0x76ac988*/ SchemaElementDecl();
                static /*0x76ac234*/ System.Xml.Schema.SchemaElementDecl CreateAnyTypeElementDecl();
                /*0x76abf3c*/ SchemaElementDecl();
                /*0x76ac014*/ SchemaElementDecl(System.Xml.Schema.XmlSchemaDatatype dtype);
                /*0x76ac144*/ SchemaElementDecl(System.Xml.XmlQualifiedName name, string prefix);
                /*0x76ac300*/ bool System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes();
                /*0x76ac308*/ System.Xml.IDtdAttributeInfo System.Xml.IDtdAttributeListInfo.LookupAttribute(string prefix, string localName);
                /*0x76ac3bc*/ System.Collections.Generic.IEnumerable<System.Xml.IDtdDefaultAttributeInfo> System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes();
                /*0x76ac3c4*/ bool get_IsIdDeclared();
                /*0x76ac3cc*/ void set_IsIdDeclared(bool value);
                /*0x76ac3d8*/ bool get_HasNonCDataAttribute();
                /*0x76ac3e0*/ void set_HasNonCDataAttribute(bool value);
                /*0x76ac3ec*/ System.Xml.Schema.SchemaElementDecl Clone();
                /*0x76ac450*/ bool get_IsAbstract();
                /*0x76ac458*/ void set_IsAbstract(bool value);
                /*0x76ac464*/ bool get_IsNillable();
                /*0x76ac46c*/ void set_IsNillable(bool value);
                /*0x76ac478*/ System.Xml.Schema.XmlSchemaDerivationMethod get_Block();
                /*0x76ac480*/ void set_Block(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x76ac488*/ bool get_IsNotationDeclared();
                /*0x76ac490*/ void set_IsNotationDeclared(bool value);
                /*0x76ac49c*/ bool get_HasDefaultAttribute();
                /*0x76ac4ac*/ bool get_HasRequiredAttribute();
                /*0x76ac4b4*/ System.Xml.Schema.ContentValidator get_ContentValidator();
                /*0x76ac4bc*/ void set_ContentValidator(System.Xml.Schema.ContentValidator value);
                /*0x76ac4c4*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0x76ac4cc*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x76ac4d4*/ System.Xml.Schema.CompiledIdentityConstraint[] get_Constraints();
                /*0x76ac4dc*/ void set_Constraints(System.Xml.Schema.CompiledIdentityConstraint[] value);
                /*0x76ac4e4*/ System.Xml.Schema.XmlSchemaElement get_SchemaElement();
                /*0x76ac4ec*/ void set_SchemaElement(System.Xml.Schema.XmlSchemaElement value);
                /*0x76ac4f4*/ void AddAttDef(System.Xml.Schema.SchemaAttDef attdef);
                /*0x76ac664*/ System.Xml.Schema.SchemaAttDef GetAttDef(System.Xml.XmlQualifiedName qname);
                /*0x76ac6dc*/ System.Collections.Generic.IList<System.Xml.IDtdDefaultAttributeInfo> get_DefaultAttDefs();
                /*0x76ac6e4*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaAttDef> get_AttDefs();
                /*0x76ac6ec*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.XmlQualifiedName> get_ProhibitedAttributes();
                /*0x76ac6f4*/ void CheckAttributes(System.Collections.Hashtable presence, bool standalone);
            }

            class SchemaEntity : System.Xml.IDtdEntityInfo
            {
                /*0x10*/ System.Xml.XmlQualifiedName qname;
                /*0x18*/ string url;
                /*0x20*/ string pubid;
                /*0x28*/ string text;
                /*0x30*/ System.Xml.XmlQualifiedName ndata;
                /*0x38*/ int lineNumber;
                /*0x3c*/ int linePosition;
                /*0x40*/ bool isParameter;
                /*0x41*/ bool isExternal;
                /*0x42*/ bool parsingInProgress;
                /*0x43*/ bool isDeclaredInExternal;
                /*0x48*/ string baseURI;
                /*0x50*/ string declaredURI;

                static /*0x76acb9c*/ bool IsPredefinedEntity(string n);
                /*0x76ac9ec*/ SchemaEntity(System.Xml.XmlQualifiedName qname, bool isParameter);
                /*0x76aca88*/ string System.Xml.IDtdEntityInfo.get_Name();
                /*0x76acaa4*/ bool System.Xml.IDtdEntityInfo.get_IsExternal();
                /*0x76acaac*/ bool System.Xml.IDtdEntityInfo.get_IsDeclaredInExternal();
                /*0x76acab4*/ bool System.Xml.IDtdEntityInfo.get_IsUnparsedEntity();
                /*0x76acadc*/ bool System.Xml.IDtdEntityInfo.get_IsParameterEntity();
                /*0x76acae4*/ string System.Xml.IDtdEntityInfo.get_BaseUriString();
                /*0x76acb2c*/ string System.Xml.IDtdEntityInfo.get_DeclaredUriString();
                /*0x76acb74*/ string System.Xml.IDtdEntityInfo.get_SystemId();
                /*0x76acb7c*/ string System.Xml.IDtdEntityInfo.get_PublicId();
                /*0x76acb84*/ string System.Xml.IDtdEntityInfo.get_Text();
                /*0x76acb8c*/ int System.Xml.IDtdEntityInfo.get_LineNumber();
                /*0x76acb94*/ int System.Xml.IDtdEntityInfo.get_LinePosition();
                /*0x76acc98*/ System.Xml.XmlQualifiedName get_Name();
                /*0x76acca0*/ string get_Url();
                /*0x76acca8*/ void set_Url(string value);
                /*0x76acccc*/ string get_Pubid();
                /*0x76accd4*/ void set_Pubid(string value);
                /*0x76accdc*/ bool get_IsExternal();
                /*0x76acce4*/ void set_IsExternal(bool value);
                /*0x76accf0*/ bool get_DeclaredInExternal();
                /*0x76accf8*/ void set_DeclaredInExternal(bool value);
                /*0x76acd04*/ System.Xml.XmlQualifiedName get_NData();
                /*0x76acd0c*/ void set_NData(System.Xml.XmlQualifiedName value);
                /*0x76acd14*/ string get_Text();
                /*0x76acd1c*/ void set_Text(string value);
                /*0x76acd3c*/ int get_Line();
                /*0x76acd44*/ void set_Line(int value);
                /*0x76acd4c*/ int get_Pos();
                /*0x76acd54*/ void set_Pos(int value);
                /*0x76acb08*/ string get_BaseURI();
                /*0x76acd5c*/ void set_BaseURI(string value);
                /*0x76acd64*/ bool get_ParsingInProgress();
                /*0x76acd6c*/ void set_ParsingInProgress(bool value);
                /*0x76acb50*/ string get_DeclaredURI();
                /*0x76acd78*/ void set_DeclaredURI(string value);
            }

            enum AttributeMatchState
            {
                AttributeFound = 0,
                AnyIdAttributeFound = 1,
                UndeclaredElementAndAttribute = 2,
                UndeclaredAttribute = 3,
                AnyAttributeLax = 4,
                AnyAttributeSkip = 5,
                ProhibitedAnyAttribute = 6,
                ProhibitedAttribute = 7,
                AttributeNameMismatch = 8,
                ValidateAttributeInvalidCall = 9,
            }

            class SchemaInfo : System.Xml.IDtdInfo
            {
                /*0x10*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaElementDecl> elementDecls;
                /*0x18*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaElementDecl> undeclaredElementDecls;
                /*0x20*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaEntity> generalEntities;
                /*0x28*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaEntity> parameterEntities;
                /*0x30*/ System.Xml.XmlQualifiedName docTypeName;
                /*0x38*/ string internalDtdSubset;
                /*0x40*/ bool hasNonCDataAttributes;
                /*0x41*/ bool hasDefaultAttributes;
                /*0x48*/ System.Collections.Generic.Dictionary<string, bool> targetNamespaces;
                /*0x50*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaAttDef> attributeDecls;
                /*0x58*/ int errorCount;
                /*0x5c*/ System.Xml.Schema.SchemaType schemaType;
                /*0x60*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaElementDecl> elementDeclsByType;
                /*0x68*/ System.Collections.Generic.Dictionary<string, System.Xml.Schema.SchemaNotation> notations;

                /*0x76acd80*/ SchemaInfo();
                /*0x76acf5c*/ System.Xml.XmlQualifiedName get_DocTypeName();
                /*0x76acf64*/ void set_DocTypeName(System.Xml.XmlQualifiedName value);
                /*0x76acf6c*/ void set_InternalDtdSubset(string value);
                /*0x76acf74*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaElementDecl> get_ElementDecls();
                /*0x76acf7c*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaElementDecl> get_UndeclaredElementDecls();
                /*0x76acf84*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaEntity> get_GeneralEntities();
                /*0x76ad008*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaEntity> get_ParameterEntities();
                /*0x76ad08c*/ System.Xml.Schema.SchemaType get_SchemaType();
                /*0x76ad094*/ void set_SchemaType(System.Xml.Schema.SchemaType value);
                /*0x76ad09c*/ System.Collections.Generic.Dictionary<string, bool> get_TargetNamespaces();
                /*0x76ad0a4*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaElementDecl> get_ElementDeclsByType();
                /*0x76ad0ac*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaAttDef> get_AttributeDecls();
                /*0x76ad0b4*/ System.Collections.Generic.Dictionary<string, System.Xml.Schema.SchemaNotation> get_Notations();
                /*0x76ad138*/ int get_ErrorCount();
                /*0x76ad140*/ void set_ErrorCount(int value);
                /*0x76ad148*/ System.Xml.Schema.SchemaElementDecl GetElementDecl(System.Xml.XmlQualifiedName qname);
                /*0x76ad1c0*/ System.Xml.Schema.SchemaElementDecl GetTypeDecl(System.Xml.XmlQualifiedName qname);
                /*0x76ad238*/ System.Xml.Schema.XmlSchemaElement GetElement(System.Xml.XmlQualifiedName qname);
                /*0x76ad250*/ bool HasSchema(string ns);
                /*0x76ad2a8*/ bool Contains(string ns);
                /*0x76ad300*/ System.Xml.Schema.SchemaAttDef GetAttributeXdr(System.Xml.Schema.SchemaElementDecl ed, System.Xml.XmlQualifiedName qname);
                /*0x76ad44c*/ System.Xml.Schema.SchemaAttDef GetAttributeXsd(System.Xml.Schema.SchemaElementDecl ed, System.Xml.XmlQualifiedName qname, System.Xml.Schema.XmlSchemaObject partialValidationType, ref System.Xml.Schema.AttributeMatchState attributeMatchState);
                /*0x76ad66c*/ System.Xml.Schema.SchemaAttDef GetAttributeXsd(System.Xml.Schema.SchemaElementDecl ed, System.Xml.XmlQualifiedName qname, ref bool skip);
                /*0x76ad764*/ void Add(System.Xml.Schema.SchemaInfo sinfo, System.Xml.Schema.ValidationEventHandler eventhandler);
                /*0x76ae030*/ void Finish();
                /*0x76ae1e4*/ bool System.Xml.IDtdInfo.get_HasDefaultAttributes();
                /*0x76ae1ec*/ bool System.Xml.IDtdInfo.get_HasNonCDataAttributes();
                /*0x76ae1f4*/ System.Xml.IDtdAttributeListInfo System.Xml.IDtdInfo.LookupAttributeList(string prefix, string localName);
                /*0x76ae2bc*/ System.Xml.IDtdEntityInfo System.Xml.IDtdInfo.LookupEntity(string name);
                /*0x76ae370*/ System.Xml.XmlQualifiedName System.Xml.IDtdInfo.get_Name();
                /*0x76ae378*/ string System.Xml.IDtdInfo.get_InternalDtdSubset();
            }

            class SchemaNames
            {
                /*0x10*/ System.Xml.XmlNameTable nameTable;
                /*0x18*/ string NsDataType;
                /*0x20*/ string NsDataTypeAlias;
                /*0x28*/ string NsDataTypeOld;
                /*0x30*/ string NsXml;
                /*0x38*/ string NsXmlNs;
                /*0x40*/ string NsXdr;
                /*0x48*/ string NsXdrAlias;
                /*0x50*/ string NsXs;
                /*0x58*/ string NsXsi;
                /*0x60*/ string XsiType;
                /*0x68*/ string XsiNil;
                /*0x70*/ string XsiSchemaLocation;
                /*0x78*/ string XsiNoNamespaceSchemaLocation;
                /*0x80*/ string XsdSchema;
                /*0x88*/ string XdrSchema;
                /*0x90*/ System.Xml.XmlQualifiedName QnPCData;
                /*0x98*/ System.Xml.XmlQualifiedName QnXml;
                /*0xa0*/ System.Xml.XmlQualifiedName QnXmlNs;
                /*0xa8*/ System.Xml.XmlQualifiedName QnDtDt;
                /*0xb0*/ System.Xml.XmlQualifiedName QnXmlLang;
                /*0xb8*/ System.Xml.XmlQualifiedName QnName;
                /*0xc0*/ System.Xml.XmlQualifiedName QnType;
                /*0xc8*/ System.Xml.XmlQualifiedName QnMaxOccurs;
                /*0xd0*/ System.Xml.XmlQualifiedName QnMinOccurs;
                /*0xd8*/ System.Xml.XmlQualifiedName QnInfinite;
                /*0xe0*/ System.Xml.XmlQualifiedName QnModel;
                /*0xe8*/ System.Xml.XmlQualifiedName QnOpen;
                /*0xf0*/ System.Xml.XmlQualifiedName QnClosed;
                /*0xf8*/ System.Xml.XmlQualifiedName QnContent;
                /*0x100*/ System.Xml.XmlQualifiedName QnMixed;
                /*0x108*/ System.Xml.XmlQualifiedName QnEmpty;
                /*0x110*/ System.Xml.XmlQualifiedName QnEltOnly;
                /*0x118*/ System.Xml.XmlQualifiedName QnTextOnly;
                /*0x120*/ System.Xml.XmlQualifiedName QnOrder;
                /*0x128*/ System.Xml.XmlQualifiedName QnSeq;
                /*0x130*/ System.Xml.XmlQualifiedName QnOne;
                /*0x138*/ System.Xml.XmlQualifiedName QnMany;
                /*0x140*/ System.Xml.XmlQualifiedName QnRequired;
                /*0x148*/ System.Xml.XmlQualifiedName QnYes;
                /*0x150*/ System.Xml.XmlQualifiedName QnNo;
                /*0x158*/ System.Xml.XmlQualifiedName QnString;
                /*0x160*/ System.Xml.XmlQualifiedName QnID;
                /*0x168*/ System.Xml.XmlQualifiedName QnIDRef;
                /*0x170*/ System.Xml.XmlQualifiedName QnIDRefs;
                /*0x178*/ System.Xml.XmlQualifiedName QnEntity;
                /*0x180*/ System.Xml.XmlQualifiedName QnEntities;
                /*0x188*/ System.Xml.XmlQualifiedName QnNmToken;
                /*0x190*/ System.Xml.XmlQualifiedName QnNmTokens;
                /*0x198*/ System.Xml.XmlQualifiedName QnEnumeration;
                /*0x1a0*/ System.Xml.XmlQualifiedName QnDefault;
                /*0x1a8*/ System.Xml.XmlQualifiedName QnXdrSchema;
                /*0x1b0*/ System.Xml.XmlQualifiedName QnXdrElementType;
                /*0x1b8*/ System.Xml.XmlQualifiedName QnXdrElement;
                /*0x1c0*/ System.Xml.XmlQualifiedName QnXdrGroup;
                /*0x1c8*/ System.Xml.XmlQualifiedName QnXdrAttributeType;
                /*0x1d0*/ System.Xml.XmlQualifiedName QnXdrAttribute;
                /*0x1d8*/ System.Xml.XmlQualifiedName QnXdrDataType;
                /*0x1e0*/ System.Xml.XmlQualifiedName QnXdrDescription;
                /*0x1e8*/ System.Xml.XmlQualifiedName QnXdrExtends;
                /*0x1f0*/ System.Xml.XmlQualifiedName QnXdrAliasSchema;
                /*0x1f8*/ System.Xml.XmlQualifiedName QnDtType;
                /*0x200*/ System.Xml.XmlQualifiedName QnDtValues;
                /*0x208*/ System.Xml.XmlQualifiedName QnDtMaxLength;
                /*0x210*/ System.Xml.XmlQualifiedName QnDtMinLength;
                /*0x218*/ System.Xml.XmlQualifiedName QnDtMax;
                /*0x220*/ System.Xml.XmlQualifiedName QnDtMin;
                /*0x228*/ System.Xml.XmlQualifiedName QnDtMinExclusive;
                /*0x230*/ System.Xml.XmlQualifiedName QnDtMaxExclusive;
                /*0x238*/ System.Xml.XmlQualifiedName QnTargetNamespace;
                /*0x240*/ System.Xml.XmlQualifiedName QnVersion;
                /*0x248*/ System.Xml.XmlQualifiedName QnFinalDefault;
                /*0x250*/ System.Xml.XmlQualifiedName QnBlockDefault;
                /*0x258*/ System.Xml.XmlQualifiedName QnFixed;
                /*0x260*/ System.Xml.XmlQualifiedName QnAbstract;
                /*0x268*/ System.Xml.XmlQualifiedName QnBlock;
                /*0x270*/ System.Xml.XmlQualifiedName QnSubstitutionGroup;
                /*0x278*/ System.Xml.XmlQualifiedName QnFinal;
                /*0x280*/ System.Xml.XmlQualifiedName QnNillable;
                /*0x288*/ System.Xml.XmlQualifiedName QnRef;
                /*0x290*/ System.Xml.XmlQualifiedName QnBase;
                /*0x298*/ System.Xml.XmlQualifiedName QnDerivedBy;
                /*0x2a0*/ System.Xml.XmlQualifiedName QnNamespace;
                /*0x2a8*/ System.Xml.XmlQualifiedName QnProcessContents;
                /*0x2b0*/ System.Xml.XmlQualifiedName QnRefer;
                /*0x2b8*/ System.Xml.XmlQualifiedName QnPublic;
                /*0x2c0*/ System.Xml.XmlQualifiedName QnSystem;
                /*0x2c8*/ System.Xml.XmlQualifiedName QnSchemaLocation;
                /*0x2d0*/ System.Xml.XmlQualifiedName QnValue;
                /*0x2d8*/ System.Xml.XmlQualifiedName QnUse;
                /*0x2e0*/ System.Xml.XmlQualifiedName QnForm;
                /*0x2e8*/ System.Xml.XmlQualifiedName QnElementFormDefault;
                /*0x2f0*/ System.Xml.XmlQualifiedName QnAttributeFormDefault;
                /*0x2f8*/ System.Xml.XmlQualifiedName QnItemType;
                /*0x300*/ System.Xml.XmlQualifiedName QnMemberTypes;
                /*0x308*/ System.Xml.XmlQualifiedName QnXPath;
                /*0x310*/ System.Xml.XmlQualifiedName QnXsdSchema;
                /*0x318*/ System.Xml.XmlQualifiedName QnXsdAnnotation;
                /*0x320*/ System.Xml.XmlQualifiedName QnXsdInclude;
                /*0x328*/ System.Xml.XmlQualifiedName QnXsdImport;
                /*0x330*/ System.Xml.XmlQualifiedName QnXsdElement;
                /*0x338*/ System.Xml.XmlQualifiedName QnXsdAttribute;
                /*0x340*/ System.Xml.XmlQualifiedName QnXsdAttributeGroup;
                /*0x348*/ System.Xml.XmlQualifiedName QnXsdAnyAttribute;
                /*0x350*/ System.Xml.XmlQualifiedName QnXsdGroup;
                /*0x358*/ System.Xml.XmlQualifiedName QnXsdAll;
                /*0x360*/ System.Xml.XmlQualifiedName QnXsdChoice;
                /*0x368*/ System.Xml.XmlQualifiedName QnXsdSequence;
                /*0x370*/ System.Xml.XmlQualifiedName QnXsdAny;
                /*0x378*/ System.Xml.XmlQualifiedName QnXsdNotation;
                /*0x380*/ System.Xml.XmlQualifiedName QnXsdSimpleType;
                /*0x388*/ System.Xml.XmlQualifiedName QnXsdComplexType;
                /*0x390*/ System.Xml.XmlQualifiedName QnXsdUnique;
                /*0x398*/ System.Xml.XmlQualifiedName QnXsdKey;
                /*0x3a0*/ System.Xml.XmlQualifiedName QnXsdKeyRef;
                /*0x3a8*/ System.Xml.XmlQualifiedName QnXsdSelector;
                /*0x3b0*/ System.Xml.XmlQualifiedName QnXsdField;
                /*0x3b8*/ System.Xml.XmlQualifiedName QnXsdMinExclusive;
                /*0x3c0*/ System.Xml.XmlQualifiedName QnXsdMinInclusive;
                /*0x3c8*/ System.Xml.XmlQualifiedName QnXsdMaxInclusive;
                /*0x3d0*/ System.Xml.XmlQualifiedName QnXsdMaxExclusive;
                /*0x3d8*/ System.Xml.XmlQualifiedName QnXsdTotalDigits;
                /*0x3e0*/ System.Xml.XmlQualifiedName QnXsdFractionDigits;
                /*0x3e8*/ System.Xml.XmlQualifiedName QnXsdLength;
                /*0x3f0*/ System.Xml.XmlQualifiedName QnXsdMinLength;
                /*0x3f8*/ System.Xml.XmlQualifiedName QnXsdMaxLength;
                /*0x400*/ System.Xml.XmlQualifiedName QnXsdEnumeration;
                /*0x408*/ System.Xml.XmlQualifiedName QnXsdPattern;
                /*0x410*/ System.Xml.XmlQualifiedName QnXsdDocumentation;
                /*0x418*/ System.Xml.XmlQualifiedName QnXsdAppinfo;
                /*0x420*/ System.Xml.XmlQualifiedName QnSource;
                /*0x428*/ System.Xml.XmlQualifiedName QnXsdComplexContent;
                /*0x430*/ System.Xml.XmlQualifiedName QnXsdSimpleContent;
                /*0x438*/ System.Xml.XmlQualifiedName QnXsdRestriction;
                /*0x440*/ System.Xml.XmlQualifiedName QnXsdExtension;
                /*0x448*/ System.Xml.XmlQualifiedName QnXsdUnion;
                /*0x450*/ System.Xml.XmlQualifiedName QnXsdList;
                /*0x458*/ System.Xml.XmlQualifiedName QnXsdWhiteSpace;
                /*0x460*/ System.Xml.XmlQualifiedName QnXsdRedefine;
                /*0x468*/ System.Xml.XmlQualifiedName QnXsdAnyType;
                /*0x470*/ System.Xml.XmlQualifiedName[] TokenToQName;

                /*0x76ae380*/ SchemaNames(System.Xml.XmlNameTable nameTable);
                /*0x76b1348*/ void CreateTokenToQNameTable();
                /*0x76b3274*/ System.Xml.Schema.SchemaType SchemaTypeFromRoot(string localName, string ns);
                /*0x76b32d4*/ bool IsXSDRoot(string localName, string ns);
                /*0x76b3324*/ bool IsXDRRoot(string localName, string ns);

                enum Token
                {
                    Empty = 0,
                    SchemaName = 1,
                    SchemaType = 2,
                    SchemaMaxOccurs = 3,
                    SchemaMinOccurs = 4,
                    SchemaInfinite = 5,
                    SchemaModel = 6,
                    SchemaOpen = 7,
                    SchemaClosed = 8,
                    SchemaContent = 9,
                    SchemaMixed = 10,
                    SchemaEmpty = 11,
                    SchemaElementOnly = 12,
                    SchemaTextOnly = 13,
                    SchemaOrder = 14,
                    SchemaSeq = 15,
                    SchemaOne = 16,
                    SchemaMany = 17,
                    SchemaRequired = 18,
                    SchemaYes = 19,
                    SchemaNo = 20,
                    SchemaString = 21,
                    SchemaId = 22,
                    SchemaIdref = 23,
                    SchemaIdrefs = 24,
                    SchemaEntity = 25,
                    SchemaEntities = 26,
                    SchemaNmtoken = 27,
                    SchemaNmtokens = 28,
                    SchemaEnumeration = 29,
                    SchemaDefault = 30,
                    XdrRoot = 31,
                    XdrElementType = 32,
                    XdrElement = 33,
                    XdrGroup = 34,
                    XdrAttributeType = 35,
                    XdrAttribute = 36,
                    XdrDatatype = 37,
                    XdrDescription = 38,
                    XdrExtends = 39,
                    SchemaXdrRootAlias = 40,
                    SchemaDtType = 41,
                    SchemaDtValues = 42,
                    SchemaDtMaxLength = 43,
                    SchemaDtMinLength = 44,
                    SchemaDtMax = 45,
                    SchemaDtMin = 46,
                    SchemaDtMinExclusive = 47,
                    SchemaDtMaxExclusive = 48,
                    SchemaTargetNamespace = 49,
                    SchemaVersion = 50,
                    SchemaFinalDefault = 51,
                    SchemaBlockDefault = 52,
                    SchemaFixed = 53,
                    SchemaAbstract = 54,
                    SchemaBlock = 55,
                    SchemaSubstitutionGroup = 56,
                    SchemaFinal = 57,
                    SchemaNillable = 58,
                    SchemaRef = 59,
                    SchemaBase = 60,
                    SchemaDerivedBy = 61,
                    SchemaNamespace = 62,
                    SchemaProcessContents = 63,
                    SchemaRefer = 64,
                    SchemaPublic = 65,
                    SchemaSystem = 66,
                    SchemaSchemaLocation = 67,
                    SchemaValue = 68,
                    SchemaSource = 69,
                    SchemaAttributeFormDefault = 70,
                    SchemaElementFormDefault = 71,
                    SchemaUse = 72,
                    SchemaForm = 73,
                    XsdSchema = 74,
                    XsdAnnotation = 75,
                    XsdInclude = 76,
                    XsdImport = 77,
                    XsdElement = 78,
                    XsdAttribute = 79,
                    xsdAttributeGroup = 80,
                    XsdAnyAttribute = 81,
                    XsdGroup = 82,
                    XsdAll = 83,
                    XsdChoice = 84,
                    XsdSequence = 85,
                    XsdAny = 86,
                    XsdNotation = 87,
                    XsdSimpleType = 88,
                    XsdComplexType = 89,
                    XsdUnique = 90,
                    XsdKey = 91,
                    XsdKeyref = 92,
                    XsdSelector = 93,
                    XsdField = 94,
                    XsdMinExclusive = 95,
                    XsdMinInclusive = 96,
                    XsdMaxExclusive = 97,
                    XsdMaxInclusive = 98,
                    XsdTotalDigits = 99,
                    XsdFractionDigits = 100,
                    XsdLength = 101,
                    XsdMinLength = 102,
                    XsdMaxLength = 103,
                    XsdEnumeration = 104,
                    XsdPattern = 105,
                    XsdDocumentation = 106,
                    XsdAppInfo = 107,
                    XsdComplexContent = 108,
                    XsdComplexContentExtension = 109,
                    XsdComplexContentRestriction = 110,
                    XsdSimpleContent = 111,
                    XsdSimpleContentExtension = 112,
                    XsdSimpleContentRestriction = 113,
                    XsdSimpleTypeList = 114,
                    XsdSimpleTypeRestriction = 115,
                    XsdSimpleTypeUnion = 116,
                    XsdWhitespace = 117,
                    XsdRedefine = 118,
                    SchemaItemType = 119,
                    SchemaMemberTypes = 120,
                    SchemaXPath = 121,
                    XmlLang = 122,
                }
            }

            class SchemaNamespaceManager : System.Xml.XmlNamespaceManager
            {
                /*0x50*/ System.Xml.Schema.XmlSchemaObject node;

                /*0x76b3374*/ SchemaNamespaceManager(System.Xml.Schema.XmlSchemaObject node);
                /*0x76b33a4*/ string LookupNamespace(string prefix);
                /*0x76b34c8*/ string LookupPrefix(string ns);
            }

            class SchemaNotation
            {
                /*0x10*/ System.Xml.XmlQualifiedName name;
                /*0x18*/ string systemLiteral;
                /*0x20*/ string pubid;

                /*0x76b38b8*/ SchemaNotation(System.Xml.XmlQualifiedName name);
                /*0x76b38e8*/ System.Xml.XmlQualifiedName get_Name();
                /*0x76b38f0*/ string get_SystemLiteral();
                /*0x76b38f8*/ void set_SystemLiteral(string value);
                /*0x76b3900*/ string get_Pubid();
                /*0x76b3908*/ void set_Pubid(string value);
            }

            class Compiler : System.Xml.Schema.BaseProcessor
            {
                /*0x40*/ string restrictionErrorMsg;
                /*0x48*/ System.Xml.Schema.XmlSchemaObjectTable attributes;
                /*0x50*/ System.Xml.Schema.XmlSchemaObjectTable attributeGroups;
                /*0x58*/ System.Xml.Schema.XmlSchemaObjectTable elements;
                /*0x60*/ System.Xml.Schema.XmlSchemaObjectTable schemaTypes;
                /*0x68*/ System.Xml.Schema.XmlSchemaObjectTable groups;
                /*0x70*/ System.Xml.Schema.XmlSchemaObjectTable notations;
                /*0x78*/ System.Xml.Schema.XmlSchemaObjectTable examplars;
                /*0x80*/ System.Xml.Schema.XmlSchemaObjectTable identityConstraints;
                /*0x88*/ System.Collections.Stack complexTypeStack;
                /*0x90*/ System.Collections.Hashtable schemasToCompile;
                /*0x98*/ System.Collections.Hashtable importedSchemas;
                /*0xa0*/ System.Xml.Schema.XmlSchema schemaForSchema;

                /*0x76b3910*/ Compiler(System.Xml.XmlNameTable nameTable, System.Xml.Schema.ValidationEventHandler eventHandler, System.Xml.Schema.XmlSchema schemaForSchema, System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings);
                /*0x76b3b54*/ bool Execute(System.Xml.Schema.XmlSchemaSet schemaSet, System.Xml.Schema.SchemaInfo schemaCompiledInfo);
                /*0x76b6cec*/ void Prepare(System.Xml.Schema.XmlSchema schema, bool cleanup);
                /*0x76b8b40*/ void UpdateSForSSimpleTypes();
                /*0x76b5bfc*/ void Output(System.Xml.Schema.SchemaInfo schemaInfo);
                /*0x76b8c90*/ void ImportAllCompiledSchemas(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x76b3bf0*/ bool Compile();
                /*0x76b8580*/ void CleanupAttribute(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x76b85f8*/ void CleanupAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x76b8658*/ void CleanupComplexType(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x76b8a8c*/ void CleanupSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType);
                /*0x76b83e8*/ void CleanupElement(System.Xml.Schema.XmlSchemaElement element);
                /*0x76bd9b8*/ void CleanupAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes);
                /*0x76b85b0*/ void CleanupGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x76bda90*/ void CleanupParticle(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x76bc9e4*/ void ProcessSubstitutionGroups();
                /*0x76bdc2c*/ void CompileSubstitutionGroup(System.Xml.Schema.XmlSchemaSubstitutionGroup substitutionGroup);
                /*0x76bd864*/ void RecursivelyCheckRedefinedGroups(System.Xml.Schema.XmlSchemaGroup redefinedGroup, System.Xml.Schema.XmlSchemaGroup baseGroup);
                /*0x76bd940*/ void RecursivelyCheckRedefinedAttributeGroups(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup, System.Xml.Schema.XmlSchemaAttributeGroup baseAttributeGroup);
                /*0x76b8d98*/ void CompileGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x76ba1ec*/ void CompileSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType);
                /*0x76bf03c*/ System.Xml.Schema.XmlSchemaSimpleType[] CompileBaseMemberTypes(System.Xml.Schema.XmlSchemaSimpleType simpleType);
                /*0x76bf3e0*/ void CheckUnionType(System.Xml.Schema.XmlSchemaSimpleType unionMember, System.Collections.ArrayList memberTypeDefinitions, System.Xml.Schema.XmlSchemaSimpleType parentType);
                /*0x76b970c*/ void CompileComplexType(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x76bf4f8*/ void CompileSimpleContentExtension(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaSimpleContentExtension simpleExtension);
                /*0x76bf750*/ void CompileSimpleContentRestriction(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaSimpleContentRestriction simpleRestriction);
                /*0x76bfb9c*/ void CompileComplexContentExtension(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaComplexContentExtension complexExtension);
                /*0x76bff3c*/ void CompileComplexContentRestriction(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaComplexContentRestriction complexRestriction);
                /*0x76bd260*/ void CheckParticleDerivation(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x76be4d8*/ void CheckParticleDerivation(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle);
                /*0x76c17c0*/ System.Xml.Schema.XmlSchemaParticle CompileContentTypeParticle(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x76be134*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeParticle(System.Xml.Schema.XmlSchemaParticle particle, bool root);
                /*0x76c4418*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeElement(System.Xml.Schema.XmlSchemaElement element);
                /*0x76c32cc*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeGroupRef(System.Xml.Schema.XmlSchemaGroupRef groupRef, bool root);
                /*0x76c37ec*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeAll(System.Xml.Schema.XmlSchemaAll all, bool root);
                /*0x76c3a70*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeChoice(System.Xml.Schema.XmlSchemaChoice choice, bool root);
                /*0x76c3f64*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeSequence(System.Xml.Schema.XmlSchemaSequence sequence, bool root);
                /*0x76c25d8*/ System.Xml.Schema.XmlSchemaParticle CannonicalizePointlessRoot(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x76c283c*/ bool IsValidRestriction(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle);
                /*0x76c4754*/ bool IsElementFromElement(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaElement baseElement);
                /*0x76c4960*/ bool IsElementFromAny(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaAny baseAny);
                /*0x76c4b14*/ bool IsAnyFromAny(System.Xml.Schema.XmlSchemaAny derivedAny, System.Xml.Schema.XmlSchemaAny baseAny);
                /*0x76c4c14*/ bool IsGroupBaseFromAny(System.Xml.Schema.XmlSchemaGroupBase derivedGroupBase, System.Xml.Schema.XmlSchemaAny baseAny);
                /*0x76c501c*/ bool IsElementFromGroupBase(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaGroupBase baseGroupBase);
                /*0x76c5edc*/ bool IsChoiceFromChoiceSubstGroup(System.Xml.Schema.XmlSchemaChoice derivedChoice, System.Xml.Schema.XmlSchemaChoice baseChoice);
                /*0x76c58e0*/ bool IsGroupBaseFromGroupBase(System.Xml.Schema.XmlSchemaGroupBase derivedGroupBase, System.Xml.Schema.XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly);
                /*0x76c5bd0*/ bool IsSequenceFromAll(System.Xml.Schema.XmlSchemaSequence derivedSequence, System.Xml.Schema.XmlSchemaAll baseAll);
                /*0x76c6070*/ bool IsSequenceFromChoice(System.Xml.Schema.XmlSchemaSequence derivedSequence, System.Xml.Schema.XmlSchemaChoice baseChoice);
                /*0x76c63b4*/ bool IsValidOccurrenceRangeRestriction(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle);
                /*0x76c6d18*/ bool IsValidOccurrenceRangeRestriction(decimal minOccurs, decimal maxOccurs, decimal baseMinOccurs, decimal baseMaxOccurs);
                /*0x76c6e00*/ int GetMappingParticle(System.Xml.Schema.XmlSchemaParticle particle, System.Xml.Schema.XmlSchemaObjectCollection collection);
                /*0x76c4690*/ bool IsParticleEmptiable(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x76c6554*/ void CalculateEffectiveTotalRange(System.Xml.Schema.XmlSchemaParticle particle, ref decimal minOccurs, ref decimal maxOccurs);
                /*0x76c6ef4*/ void PushComplexType(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x76c191c*/ System.Xml.Schema.XmlSchemaContentType GetSchemaContentType(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaParticle particle);
                /*0x76b8e7c*/ void CompileAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x76c0204*/ void CompileLocalAttributes(System.Xml.Schema.XmlSchemaComplexType baseType, System.Xml.Schema.XmlSchemaComplexType derivedType, System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute, System.Xml.Schema.XmlSchemaDerivationMethod derivedBy);
                /*0x76be5bc*/ void CheckAtrributeGroupRestriction(System.Xml.Schema.XmlSchemaAttributeGroup baseAttributeGroup, System.Xml.Schema.XmlSchemaAttributeGroup derivedAttributeGroup);
                /*0x76c7040*/ bool IsProcessContentsRestricted(System.Xml.Schema.XmlSchemaComplexType baseType, System.Xml.Schema.XmlSchemaAnyAttribute derivedAttributeWildcard, System.Xml.Schema.XmlSchemaAnyAttribute baseAttributeWildcard);
                /*0x76c6fac*/ System.Xml.Schema.XmlSchemaAnyAttribute CompileAnyAttributeUnion(System.Xml.Schema.XmlSchemaAnyAttribute a, System.Xml.Schema.XmlSchemaAnyAttribute b);
                /*0x76c6f18*/ System.Xml.Schema.XmlSchemaAnyAttribute CompileAnyAttributeIntersection(System.Xml.Schema.XmlSchemaAnyAttribute a, System.Xml.Schema.XmlSchemaAnyAttribute b);
                /*0x76bb998*/ void CompileAttribute(System.Xml.Schema.XmlSchemaAttribute xa);
                /*0x76c711c*/ void SetDefaultFixed(System.Xml.Schema.XmlSchemaAttribute xa, System.Xml.Schema.SchemaAttDef decl);
                /*0x76bc224*/ void CompileIdentityConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint xi);
                /*0x76bab80*/ void CompileElement(System.Xml.Schema.XmlSchemaElement xe);
                /*0x76c198c*/ System.Xml.Schema.ContentValidator CompileComplexContent(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x76c72dc*/ bool BuildParticleContentModel(System.Xml.Schema.ParticleContentValidator contentValidator, System.Xml.Schema.XmlSchemaParticle particle);
                /*0x76c77dc*/ void CompileParticleElements(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaParticle particle);
                /*0x76be350*/ void CompileParticleElements(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x76bc8c8*/ void CompileComplexTypeElements(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x76bef64*/ System.Xml.Schema.XmlSchemaSimpleType GetSimpleType(System.Xml.XmlQualifiedName name);
                /*0x76c2530*/ System.Xml.Schema.XmlSchemaComplexType GetComplexType(System.Xml.XmlQualifiedName name);
                /*0x76c23d8*/ System.Xml.Schema.XmlSchemaType GetAnySchemaType(System.Xml.XmlQualifiedName name);
                /*0x76c461c*/ void CopyPosition(System.Xml.Schema.XmlSchemaAnnotated to, System.Xml.Schema.XmlSchemaAnnotated from, bool copyParent);
                /*0x76c63f8*/ bool IsFixedEqual(System.Xml.Schema.SchemaDeclBase baseDecl, System.Xml.Schema.SchemaDeclBase derivedDecl);
            }

            enum SchemaType
            {
                None = 0,
                DTD = 1,
                XDR = 2,
                XSD = 3,
            }

            class ValidationEventArgs : System.EventArgs
            {
                /*0x10*/ System.Xml.Schema.XmlSchemaException ex;
                /*0x18*/ System.Xml.Schema.XmlSeverityType severity;

                /*0x76c7a30*/ ValidationEventArgs(System.Xml.Schema.XmlSchemaException ex);
                /*0x76c7aac*/ ValidationEventArgs(System.Xml.Schema.XmlSchemaException ex, System.Xml.Schema.XmlSeverityType severity);
                /*0x76c7b2c*/ System.Xml.Schema.XmlSeverityType get_Severity();
                /*0x76c7b34*/ System.Xml.Schema.XmlSchemaException get_Exception();
            }

            class ValidationEventHandler : System.MulticastDelegate
            {
                /*0x76c7b3c*/ ValidationEventHandler(object object, nint method);
                /*0x76c7c48*/ void Invoke(object sender, System.Xml.Schema.ValidationEventArgs e);
            }

            struct StateUnion
            {
                /*0x10*/ int State;
                /*0x10*/ int AllElementsRequired;
                /*0x10*/ int CurPosIndex;
                /*0x10*/ int NumberOfRunningPos;
            }

            class ValidationState
            {
                /*0x10*/ bool IsNill;
                /*0x11*/ bool IsDefault;
                /*0x12*/ bool NeedValidateChildren;
                /*0x13*/ bool CheckRequiredAttribute;
                /*0x14*/ bool ValidationSkipped;
                /*0x18*/ System.Xml.Schema.XmlSchemaContentProcessing ProcessContents;
                /*0x1c*/ System.Xml.Schema.XmlSchemaValidity Validity;
                /*0x20*/ System.Xml.Schema.SchemaElementDecl ElementDecl;
                /*0x28*/ System.Xml.Schema.SchemaElementDecl ElementDeclBeforeXsi;
                /*0x30*/ string LocalName;
                /*0x38*/ string Namespace;
                /*0x40*/ System.Xml.Schema.ConstraintStruct[] Constr;
                /*0x48*/ System.Xml.Schema.StateUnion CurrentState;
                /*0x4c*/ bool HasMatched;
                /*0x50*/ System.Xml.Schema.BitSet[] CurPos;
                /*0x58*/ System.Xml.Schema.BitSet AllElementsSet;
                /*0x60*/ System.Collections.Generic.List<System.Xml.Schema.RangePositionInfo> RunningPositions;
                /*0x68*/ bool TooComplex;

                /*0x76c7c5c*/ ValidationState();
            }

            class XdrBuilder : System.Xml.Schema.SchemaBuilder
            {
                static /*0x0*/ int[] S_XDR_Root_Element;
                static /*0x8*/ int[] S_XDR_Root_SubElements;
                static /*0x10*/ int[] S_XDR_ElementType_SubElements;
                static /*0x18*/ int[] S_XDR_AttributeType_SubElements;
                static /*0x20*/ int[] S_XDR_Group_SubElements;
                static /*0x28*/ System.Xml.Schema.XdrBuilder.XdrAttributeEntry[] S_XDR_Root_Attributes;
                static /*0x30*/ System.Xml.Schema.XdrBuilder.XdrAttributeEntry[] S_XDR_ElementType_Attributes;
                static /*0x38*/ System.Xml.Schema.XdrBuilder.XdrAttributeEntry[] S_XDR_AttributeType_Attributes;
                static /*0x40*/ System.Xml.Schema.XdrBuilder.XdrAttributeEntry[] S_XDR_Element_Attributes;
                static /*0x48*/ System.Xml.Schema.XdrBuilder.XdrAttributeEntry[] S_XDR_Attribute_Attributes;
                static /*0x50*/ System.Xml.Schema.XdrBuilder.XdrAttributeEntry[] S_XDR_Group_Attributes;
                static /*0x58*/ System.Xml.Schema.XdrBuilder.XdrAttributeEntry[] S_XDR_ElementDataType_Attributes;
                static /*0x60*/ System.Xml.Schema.XdrBuilder.XdrAttributeEntry[] S_XDR_AttributeDataType_Attributes;
                static /*0x68*/ System.Xml.Schema.XdrBuilder.XdrEntry[] S_SchemaEntries;
                /*0x10*/ System.Xml.Schema.SchemaInfo _SchemaInfo;
                /*0x18*/ string _TargetNamespace;
                /*0x20*/ System.Xml.XmlReader _reader;
                /*0x28*/ System.Xml.PositionInfo positionInfo;
                /*0x30*/ System.Xml.Schema.ParticleContentValidator _contentValidator;
                /*0x38*/ System.Xml.Schema.XdrBuilder.XdrEntry _CurState;
                /*0x40*/ System.Xml.Schema.XdrBuilder.XdrEntry _NextState;
                /*0x48*/ System.Xml.HWStack _StateHistory;
                /*0x50*/ System.Xml.HWStack _GroupStack;
                /*0x58*/ string _XdrName;
                /*0x60*/ string _XdrPrefix;
                /*0x68*/ System.Xml.Schema.XdrBuilder.ElementContent _ElementDef;
                /*0x70*/ System.Xml.Schema.XdrBuilder.GroupContent _GroupDef;
                /*0x78*/ System.Xml.Schema.XdrBuilder.AttributeContent _AttributeDef;
                /*0x80*/ System.Xml.Schema.XdrBuilder.DeclBaseInfo _UndefinedAttributeTypes;
                /*0x88*/ System.Xml.Schema.XdrBuilder.DeclBaseInfo _BaseDecl;
                /*0x90*/ System.Xml.XmlNameTable _NameTable;
                /*0x98*/ System.Xml.Schema.SchemaNames _SchemaNames;
                /*0xa0*/ System.Xml.XmlNamespaceManager _CurNsMgr;
                /*0xa8*/ string _Text;
                /*0xb0*/ System.Xml.Schema.ValidationEventHandler validationEventHandler;
                /*0xb8*/ System.Collections.Hashtable _UndeclaredElements;
                /*0xc0*/ System.Xml.XmlResolver xmlResolver;

                static /*0x76cd8e0*/ XdrBuilder();
                static /*0x76c897c*/ bool IsXdrSchema(string uri);
                static /*0x76c9454*/ void XDR_InitRoot(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x76c94b4*/ void XDR_BuildRoot_Name(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76c952c*/ void XDR_BuildRoot_ID(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76c9530*/ void XDR_BeginRoot(System.Xml.Schema.XdrBuilder builder);
                static /*0x76c960c*/ void XDR_EndRoot(System.Xml.Schema.XdrBuilder builder);
                static /*0x76c9b8c*/ void XDR_InitElementType(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x76c9cb8*/ void XDR_BuildElementType_Name(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76c9e84*/ void XDR_BuildElementType_Content(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76ca0a8*/ void XDR_BuildElementType_Model(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76ca224*/ void XDR_BuildElementType_Order(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76ca3f4*/ void XDR_BuildElementType_DtType(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76ca574*/ void XDR_BuildElementType_DtValues(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76ca658*/ void XDR_BuildElementType_DtMaxLength(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76ca800*/ void XDR_BuildElementType_DtMinLength(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76ca9a8*/ void XDR_BeginElementType(System.Xml.Schema.XdrBuilder builder);
                static /*0x76cacac*/ void XDR_EndElementType(System.Xml.Schema.XdrBuilder builder);
                static /*0x76cb140*/ void XDR_InitAttributeType(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x76cb24c*/ void XDR_BuildAttributeType_Name(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76cb4a4*/ void XDR_BuildAttributeType_Required(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76cb630*/ void XDR_BuildAttributeType_Default(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76cb650*/ void XDR_BuildAttributeType_DtType(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76cb84c*/ void XDR_BuildAttributeType_DtValues(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76cb930*/ void XDR_BuildAttributeType_DtMaxLength(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76cb9a0*/ void XDR_BuildAttributeType_DtMinLength(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76cba10*/ void XDR_BeginAttributeType(System.Xml.Schema.XdrBuilder builder);
                static /*0x76cba9c*/ void XDR_EndAttributeType(System.Xml.Schema.XdrBuilder builder);
                static /*0x76cbe30*/ void XDR_InitElement(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x76cbed0*/ void XDR_BuildElement_Type(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76cc110*/ void XDR_BuildElement_MinOccurs(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76cc274*/ void XDR_BuildElement_MaxOccurs(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76cc410*/ void XDR_EndElement(System.Xml.Schema.XdrBuilder builder);
                static /*0x76cc4f8*/ void XDR_InitAttribute(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x76cc59c*/ void XDR_BuildAttribute_Type(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76cc674*/ void XDR_BuildAttribute_Required(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76cc6f8*/ void XDR_BuildAttribute_Default(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76cc718*/ void XDR_BeginAttribute(System.Xml.Schema.XdrBuilder builder);
                static /*0x76cca2c*/ void XDR_EndAttribute(System.Xml.Schema.XdrBuilder builder);
                static /*0x76ccb40*/ void XDR_InitGroup(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x76ccc0c*/ void XDR_BuildGroup_Order(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76ccd0c*/ void XDR_BuildGroup_MinOccurs(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76ccd90*/ void XDR_BuildGroup_MaxOccurs(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76cce14*/ void XDR_EndGroup(System.Xml.Schema.XdrBuilder builder);
                static /*0x76ccf6c*/ void XDR_InitElementDtType(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x76cd030*/ void XDR_EndElementDtType(System.Xml.Schema.XdrBuilder builder);
                static /*0x76cd114*/ void XDR_InitAttributeDtType(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x76cd194*/ void XDR_EndAttributeDtType(System.Xml.Schema.XdrBuilder builder);
                static /*0x76cb51c*/ bool IsYes(object obj, System.Xml.Schema.XdrBuilder builder);
                static /*0x76cc184*/ uint ParseMinOccurs(object obj, System.Xml.Schema.XdrBuilder builder);
                static /*0x76cc2e8*/ uint ParseMaxOccurs(object obj, System.Xml.Schema.XdrBuilder builder);
                static /*0x76cc4c8*/ void HandleMinMax(System.Xml.Schema.ParticleContentValidator pContent, uint cMin, uint cMax);
                static /*0x76ca6c8*/ void ParseDtMaxLength(ref uint cVal, object obj, System.Xml.Schema.XdrBuilder builder);
                static /*0x76ca870*/ void ParseDtMinLength(ref uint cVal, object obj, System.Xml.Schema.XdrBuilder builder);
                static /*0x76cb0ac*/ void CompareMinMaxLength(uint cMin, uint cMax, System.Xml.Schema.XdrBuilder builder);
                static /*0x76cd288*/ bool ParseInteger(string str, ref uint n);
                /*0x76c7cc0*/ XdrBuilder(System.Xml.XmlReader reader, System.Xml.XmlNamespaceManager curmgr, System.Xml.Schema.SchemaInfo sinfo, string targetNamspace, System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventhandler);
                /*0x76c7f84*/ bool ProcessElement(string prefix, string name, string ns);
                /*0x76c8604*/ void ProcessAttribute(string prefix, string name, string ns, string value);
                /*0x76c9028*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x76c8a34*/ bool LoadSchema(string uri);
                /*0x76c9130*/ bool IsContentParsed();
                /*0x76c9138*/ void ProcessMarkup(System.Xml.XmlNode[] markup);
                /*0x76c9190*/ void ProcessCData(string value);
                /*0x76c920c*/ void StartChildren();
                /*0x76c9244*/ void EndChildren();
                /*0x76c8414*/ void Push();
                /*0x76c9280*/ void Pop();
                /*0x76c9310*/ void PushGroupInfo();
                /*0x76c93c4*/ void PopGroupInfo();
                /*0x76c8270*/ bool GetNextState(System.Xml.XmlQualifiedName qname);
                /*0x76c8460*/ bool IsSkipableElement(System.Xml.XmlQualifiedName qname);
                /*0x76c8ef0*/ bool IsSkipableAttribute(System.Xml.XmlQualifiedName qname);
                /*0x76ca2d0*/ int GetOrder(System.Xml.XmlQualifiedName qname);
                /*0x76cc054*/ void AddOrder();
                /*0x76c9aec*/ void XDR_CheckAttributeDefault(System.Xml.Schema.XdrBuilder.DeclBaseInfo decl, System.Xml.Schema.SchemaAttDef pAttdef);
                /*0x76cbde0*/ void SetAttributePresence(System.Xml.Schema.SchemaAttDef pAttdef, bool fRequired);
                /*0x76c9f20*/ int GetContent(System.Xml.XmlQualifiedName qname);
                /*0x76ca148*/ bool GetModel(System.Xml.XmlQualifiedName qname);
                /*0x76cb708*/ System.Xml.Schema.XmlSchemaDatatype CheckDatatype(string str);
                /*0x76cbcf0*/ void CheckDefaultAttValue(System.Xml.Schema.SchemaAttDef attDef);
                /*0x76c8970*/ bool IsGlobal(int flags);
                /*0x76c9030*/ void SendValidationEvent(string code, string[] args, System.Xml.Schema.XmlSeverityType severity);
                /*0x76ca504*/ void SendValidationEvent(string code);
                /*0x76c8520*/ void SendValidationEvent(string code, string msg);
                /*0x76cd74c*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity);

                class DeclBaseInfo
                {
                    /*0x10*/ System.Xml.XmlQualifiedName _Name;
                    /*0x18*/ string _Prefix;
                    /*0x20*/ System.Xml.XmlQualifiedName _TypeName;
                    /*0x28*/ string _TypePrefix;
                    /*0x30*/ object _Default;
                    /*0x38*/ object _Revises;
                    /*0x40*/ uint _MaxOccurs;
                    /*0x44*/ uint _MinOccurs;
                    /*0x48*/ bool _Checking;
                    /*0x50*/ System.Xml.Schema.SchemaElementDecl _ElementDecl;
                    /*0x58*/ System.Xml.Schema.SchemaAttDef _Attdef;
                    /*0x60*/ System.Xml.Schema.XdrBuilder.DeclBaseInfo _Next;

                    /*0x76cc580*/ DeclBaseInfo();
                    /*0x76cca48*/ void Reset();
                }

                class GroupContent
                {
                    /*0x10*/ uint _MinVal;
                    /*0x14*/ uint _MaxVal;
                    /*0x18*/ bool _HasMaxAttr;
                    /*0x19*/ bool _HasMinAttr;
                    /*0x1c*/ int _Order;

                    static /*0x76cf520*/ void Copy(System.Xml.Schema.XdrBuilder.GroupContent from, System.Xml.Schema.XdrBuilder.GroupContent to);
                    static /*0x76c9360*/ System.Xml.Schema.XdrBuilder.GroupContent Copy(System.Xml.Schema.XdrBuilder.GroupContent other);
                    /*0x76c7f7c*/ GroupContent();
                }

                class ElementContent
                {
                    /*0x10*/ System.Xml.Schema.SchemaElementDecl _ElementDecl;
                    /*0x18*/ int _ContentAttr;
                    /*0x1c*/ int _OrderAttr;
                    /*0x20*/ bool _MasterGroupRequired;
                    /*0x21*/ bool _ExistTerminal;
                    /*0x22*/ bool _AllowDataType;
                    /*0x23*/ bool _HasDataType;
                    /*0x24*/ bool _HasType;
                    /*0x25*/ bool _EnumerationRequired;
                    /*0x28*/ uint _MinVal;
                    /*0x2c*/ uint _MaxVal;
                    /*0x30*/ uint _MaxLength;
                    /*0x34*/ uint _MinLength;
                    /*0x38*/ System.Collections.Hashtable _AttDefList;

                    /*0x76c7f6c*/ ElementContent();
                }

                class AttributeContent
                {
                    /*0x10*/ System.Xml.Schema.SchemaAttDef _AttDef;
                    /*0x18*/ System.Xml.XmlQualifiedName _Name;
                    /*0x20*/ string _Prefix;
                    /*0x28*/ bool _Required;
                    /*0x2c*/ uint _MinVal;
                    /*0x30*/ uint _MaxVal;
                    /*0x34*/ uint _MaxLength;
                    /*0x38*/ uint _MinLength;
                    /*0x3c*/ bool _EnumerationRequired;
                    /*0x3d*/ bool _HasDataType;
                    /*0x3e*/ bool _Global;
                    /*0x40*/ object _Default;

                    /*0x76c7f74*/ AttributeContent();
                }

                class XdrBuildFunction : System.MulticastDelegate
                {
                    /*0x76cf0e8*/ XdrBuildFunction(object object, nint method);
                    /*0x76cf548*/ void Invoke(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                }

                class XdrInitFunction : System.MulticastDelegate
                {
                    /*0x76cf30c*/ XdrInitFunction(object object, nint method);
                    /*0x76cf55c*/ void Invoke(System.Xml.Schema.XdrBuilder builder, object obj);
                }

                class XdrBeginChildFunction : System.MulticastDelegate
                {
                    /*0x76cf3c0*/ XdrBeginChildFunction(object object, nint method);
                    /*0x76cf570*/ void Invoke(System.Xml.Schema.XdrBuilder builder);
                }

                class XdrEndChildFunction : System.MulticastDelegate
                {
                    /*0x76cf470*/ XdrEndChildFunction(object object, nint method);
                    /*0x76cf584*/ void Invoke(System.Xml.Schema.XdrBuilder builder);
                }

                class XdrAttributeEntry
                {
                    /*0x10*/ System.Xml.Schema.SchemaNames.Token _Attribute;
                    /*0x14*/ int _SchemaFlags;
                    /*0x18*/ System.Xml.Schema.XmlSchemaDatatype _Datatype;
                    /*0x20*/ System.Xml.Schema.XdrBuilder.XdrBuildFunction _BuildFunc;

                    /*0x76cf19c*/ XdrAttributeEntry(System.Xml.Schema.SchemaNames.Token a, System.Xml.XmlTokenizedType ttype, System.Xml.Schema.XdrBuilder.XdrBuildFunction build);
                    /*0x76cf1fc*/ XdrAttributeEntry(System.Xml.Schema.SchemaNames.Token a, System.Xml.XmlTokenizedType ttype, int schemaFlags, System.Xml.Schema.XdrBuilder.XdrBuildFunction build);
                }

                class XdrEntry
                {
                    /*0x10*/ System.Xml.Schema.SchemaNames.Token _Name;
                    /*0x18*/ int[] _NextStates;
                    /*0x20*/ System.Xml.Schema.XdrBuilder.XdrAttributeEntry[] _Attributes;
                    /*0x28*/ System.Xml.Schema.XdrBuilder.XdrInitFunction _InitFunc;
                    /*0x30*/ System.Xml.Schema.XdrBuilder.XdrBeginChildFunction _BeginChildFunc;
                    /*0x38*/ System.Xml.Schema.XdrBuilder.XdrEndChildFunction _EndChildFunc;
                    /*0x40*/ bool _AllowText;

                    /*0x76cf260*/ XdrEntry(System.Xml.Schema.SchemaNames.Token n, int[] states, System.Xml.Schema.XdrBuilder.XdrAttributeEntry[] attributes, System.Xml.Schema.XdrBuilder.XdrInitFunction init, System.Xml.Schema.XdrBuilder.XdrBeginChildFunction begin, System.Xml.Schema.XdrBuilder.XdrEndChildFunction end, bool fText);
                }
            }

            class XdrValidator : System.Xml.Schema.BaseValidator
            {
                /*0x80*/ System.Xml.HWStack validationStack;
                /*0x88*/ System.Collections.Hashtable attPresence;
                /*0x90*/ System.Xml.XmlQualifiedName name;
                /*0x98*/ System.Xml.XmlNamespaceManager nsManager;
                /*0xa0*/ bool isProcessContents;
                /*0xa8*/ System.Collections.Hashtable IDs;
                /*0xb0*/ System.Xml.Schema.IdRefNode idRefListHead;
                /*0xb8*/ System.Xml.Schema.Parser inlineSchemaParser;

                static /*0x76cd2c0*/ void CheckDefaultValue(string value, System.Xml.Schema.SchemaAttDef attdef, System.Xml.Schema.SchemaInfo sinfo, System.Xml.XmlNamespaceManager nsManager, System.Xml.XmlNameTable NameTable, object sender, System.Xml.Schema.ValidationEventHandler eventhandler, string baseUri, int lineNo, int linePos);
                /*0x76cf598*/ XdrValidator(System.Xml.Schema.BaseValidator validator);
                /*0x76cf814*/ XdrValidator(System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling);
                /*0x76cf620*/ void Init();
                /*0x76cf9d8*/ void Validate();
                /*0x76cfcc8*/ void ValidateElement();
                /*0x76d0024*/ void ValidateChildElement();
                /*0x76cfa90*/ bool get_IsInlineSchemaStarted();
                /*0x76cfaa0*/ void ProcessInlineSchema();
                /*0x76d016c*/ void ProcessElement();
                /*0x76cfe68*/ void ValidateEndElement();
                /*0x76d022c*/ System.Xml.Schema.SchemaElementDecl ThoroughGetElementDecl();
                /*0x76d054c*/ void ValidateStartElement();
                /*0x76d0944*/ void ValidateEndStartElement();
                /*0x76d159c*/ void LoadSchemaFromLocation(string uri);
                /*0x76d1344*/ void LoadSchema(string uri);
                /*0x76d1c14*/ bool get_HasSchema();
                /*0x76d1c38*/ bool get_PreserveWhitespace();
                /*0x76d1c70*/ void ProcessTokenizedType(System.Xml.XmlTokenizedType ttype, string name);
                /*0x76d1f30*/ void CompleteValidation();
                /*0x76d0cac*/ void CheckValue(string value, System.Xml.Schema.SchemaAttDef attdef);
                /*0x76d1e94*/ void AddID(string name, object node);
                /*0x76d21b4*/ object FindId(string name);
                /*0x76cf8b4*/ void Push(System.Xml.XmlQualifiedName elementName);
                /*0x76d128c*/ void Pop();
                /*0x76d1fe4*/ void CheckForwardRefs();
                /*0x76d14d4*/ System.Xml.XmlQualifiedName QualifiedName(string name, string ns);
            }

            class XmlAtomicValue : System.Xml.XPath.XPathItem, System.ICloneable
            {
                /*0x10*/ System.Xml.Schema.XmlSchemaType xmlType;
                /*0x18*/ object objVal;
                /*0x20*/ System.TypeCode clrType;
                /*0x28*/ System.Xml.Schema.XmlAtomicValue.Union unionVal;
                /*0x30*/ System.Xml.Schema.XmlAtomicValue.NamespacePrefixForQName nsPrefix;

                /*0x76d21d0*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, bool value);
                /*0x76d2264*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, System.DateTime value);
                /*0x76d22f4*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, double value);
                /*0x76d238c*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, int value);
                /*0x76d241c*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, long value);
                /*0x76d24ac*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, string value);
                /*0x76d2560*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, string value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76d284c*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, object value);
                /*0x76d2900*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76d2b2c*/ object System.ICloneable.Clone();
                /*0x76d2b30*/ System.Xml.Schema.XmlSchemaType get_XmlType();
                /*0x76d2b38*/ System.Type get_ValueType();
                /*0x76d2b60*/ object get_TypedValue();
                /*0x76d2d28*/ bool get_ValueAsBoolean();
                /*0x76d2df8*/ System.DateTime get_ValueAsDateTime();
                /*0x76d2edc*/ double get_ValueAsDouble();
                /*0x76d2fbc*/ int get_ValueAsInt();
                /*0x76d3094*/ long get_ValueAsLong();
                /*0x76d3178*/ object ValueAs(System.Type type, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76d33a0*/ string get_Value();
                /*0x76d3498*/ string ToString();
                /*0x76d2748*/ string GetPrefixFromQName(string value);

                struct Union
                {
                    /*0x10*/ bool boolVal;
                    /*0x10*/ double dblVal;
                    /*0x10*/ long i64Val;
                    /*0x10*/ int i32Val;
                    /*0x10*/ System.DateTime dtVal;
                }

                class NamespacePrefixForQName : System.Xml.IXmlNamespaceResolver
                {
                    /*0x10*/ string prefix;
                    /*0x18*/ string ns;

                    /*0x76d2808*/ NamespacePrefixForQName(string prefix, string ns);
                    /*0x76d34a4*/ string LookupNamespace(string prefix);
                    /*0x76d34d8*/ string LookupPrefix(string namespaceName);
                    /*0x76d3504*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
                }
            }

            class XmlSchema : System.Xml.Schema.XmlSchemaObject
            {
                static /*0x0*/ int globalIdCounter;
                /*0x34*/ System.Xml.Schema.XmlSchemaForm attributeFormDefault;
                /*0x38*/ System.Xml.Schema.XmlSchemaForm elementFormDefault;
                /*0x3c*/ System.Xml.Schema.XmlSchemaDerivationMethod blockDefault;
                /*0x40*/ System.Xml.Schema.XmlSchemaDerivationMethod finalDefault;
                /*0x48*/ string targetNs;
                /*0x50*/ string version;
                /*0x58*/ System.Xml.Schema.XmlSchemaObjectCollection includes;
                /*0x60*/ System.Xml.Schema.XmlSchemaObjectCollection items;
                /*0x68*/ string id;
                /*0x70*/ System.Xml.XmlAttribute[] moreAttributes;
                /*0x78*/ bool isCompiled;
                /*0x79*/ bool isCompiledBySet;
                /*0x7a*/ bool isPreprocessed;
                /*0x7b*/ bool isRedefined;
                /*0x7c*/ int errorCount;
                /*0x80*/ System.Xml.Schema.XmlSchemaObjectTable attributes;
                /*0x88*/ System.Xml.Schema.XmlSchemaObjectTable attributeGroups;
                /*0x90*/ System.Xml.Schema.XmlSchemaObjectTable elements;
                /*0x98*/ System.Xml.Schema.XmlSchemaObjectTable types;
                /*0xa0*/ System.Xml.Schema.XmlSchemaObjectTable groups;
                /*0xa8*/ System.Xml.Schema.XmlSchemaObjectTable notations;
                /*0xb0*/ System.Xml.Schema.XmlSchemaObjectTable identityConstraints;
                /*0xb8*/ System.Collections.ArrayList importedSchemas;
                /*0xc0*/ System.Collections.ArrayList importedNamespaces;
                /*0xc8*/ int schemaId;
                /*0xd0*/ System.Uri baseUri;
                /*0xd8*/ bool isChameleon;
                /*0xe0*/ System.Collections.Hashtable ids;
                /*0xe8*/ System.Xml.XmlDocument document;

                static /*0x76d5290*/ XmlSchema();
                static /*0x76d3784*/ System.Xml.Schema.XmlSchema Read(System.Xml.XmlReader reader, System.Xml.Schema.ValidationEventHandler validationEventHandler);
                /*0x76d35a8*/ XmlSchema();
                /*0x76d3938*/ bool CompileSchema(System.Xml.Schema.XmlSchemaCollection xsc, System.Xml.XmlResolver resolver, System.Xml.Schema.SchemaInfo schemaInfo, string ns, System.Xml.Schema.ValidationEventHandler validationEventHandler, System.Xml.XmlNameTable nameTable, bool CompileContentModel);
                /*0x76d3b20*/ void CompileSchemaInSet(System.Xml.XmlNameTable nameTable, System.Xml.Schema.ValidationEventHandler eventHandler, System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings);
                /*0x76d3bd0*/ System.Xml.Schema.XmlSchemaForm get_AttributeFormDefault();
                /*0x76d3bd8*/ void set_AttributeFormDefault(System.Xml.Schema.XmlSchemaForm value);
                /*0x76d3be0*/ System.Xml.Schema.XmlSchemaDerivationMethod get_BlockDefault();
                /*0x76d3be8*/ void set_BlockDefault(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x76d3bf0*/ System.Xml.Schema.XmlSchemaDerivationMethod get_FinalDefault();
                /*0x76d3bf8*/ void set_FinalDefault(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x76d3c00*/ System.Xml.Schema.XmlSchemaForm get_ElementFormDefault();
                /*0x76d3c08*/ void set_ElementFormDefault(System.Xml.Schema.XmlSchemaForm value);
                /*0x76d3c10*/ string get_TargetNamespace();
                /*0x76d3c18*/ void set_TargetNamespace(string value);
                /*0x76d3c20*/ string get_Version();
                /*0x76d3c28*/ void set_Version(string value);
                /*0x76d3c30*/ System.Xml.Schema.XmlSchemaObjectCollection get_Includes();
                /*0x76d3c38*/ System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                /*0x76d3c40*/ bool get_IsCompiledBySet();
                /*0x76d3c48*/ void set_IsCompiledBySet(bool value);
                /*0x76d3c54*/ bool get_IsPreprocessed();
                /*0x76d3c5c*/ void set_IsPreprocessed(bool value);
                /*0x76d3c68*/ bool get_IsRedefined();
                /*0x76d3c70*/ void set_IsRedefined(bool value);
                /*0x76d3c7c*/ System.Xml.Schema.XmlSchemaObjectTable get_Attributes();
                /*0x76d3cec*/ System.Xml.Schema.XmlSchemaObjectTable get_AttributeGroups();
                /*0x76d3d5c*/ System.Xml.Schema.XmlSchemaObjectTable get_SchemaTypes();
                /*0x76d3dcc*/ System.Xml.Schema.XmlSchemaObjectTable get_Elements();
                /*0x76d3e3c*/ string get_Id();
                /*0x76d3e44*/ void set_Id(string value);
                /*0x76d3e4c*/ System.Xml.Schema.XmlSchemaObjectTable get_Groups();
                /*0x76d3e54*/ System.Xml.Schema.XmlSchemaObjectTable get_Notations();
                /*0x76d3e5c*/ System.Xml.Schema.XmlSchemaObjectTable get_IdentityConstraints();
                /*0x76d3e64*/ System.Uri get_BaseUri();
                /*0x76d3e6c*/ void set_BaseUri(System.Uri value);
                /*0x76d3e74*/ int get_SchemaId();
                /*0x76d3ee4*/ bool get_IsChameleon();
                /*0x76d3eec*/ void set_IsChameleon(bool value);
                /*0x76d3ef8*/ System.Collections.Hashtable get_Ids();
                /*0x76d3f00*/ System.Xml.XmlDocument get_Document();
                /*0x76d3f70*/ int get_ErrorCount();
                /*0x76d3f78*/ void set_ErrorCount(int value);
                /*0x76d3f80*/ System.Xml.Schema.XmlSchema Clone();
                /*0x76d40c8*/ System.Xml.Schema.XmlSchema DeepClone();
                /*0x76d4fb4*/ string get_IdAttribute();
                /*0x76d4fbc*/ void set_IdAttribute(string value);
                /*0x76d4fc4*/ void SetIsCompiled(bool isCompiled);
                /*0x76d4fd0*/ void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes);
                /*0x76d4fd8*/ void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
                /*0x76d4ff0*/ System.Collections.ArrayList get_ImportedSchemas();
                /*0x76d5060*/ System.Collections.ArrayList get_ImportedNamespaces();
                /*0x76d50d0*/ void GetExternalSchemasList(System.Collections.IList extList, System.Xml.Schema.XmlSchema schema);
            }

            class XmlSchemaAll : System.Xml.Schema.XmlSchemaGroupBase
            {
                /*0x78*/ System.Xml.Schema.XmlSchemaObjectCollection items;

                /*0x76d532c*/ XmlSchemaAll();
                /*0x76d52dc*/ System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                /*0x76d52e4*/ bool get_IsEmpty();
                /*0x76d5324*/ void SetItems(System.Xml.Schema.XmlSchemaObjectCollection newItems);
            }

            class XmlSchemaAnnotated : System.Xml.Schema.XmlSchemaObject
            {
                /*0x38*/ string id;
                /*0x40*/ System.Xml.Schema.XmlSchemaAnnotation annotation;
                /*0x48*/ System.Xml.XmlAttribute[] moreAttributes;

                /*0x76d543c*/ XmlSchemaAnnotated();
                /*0x76d53ec*/ string get_Id();
                /*0x76d53f4*/ void set_Id(string value);
                /*0x76d53fc*/ System.Xml.Schema.XmlSchemaAnnotation get_Annotation();
                /*0x76d5404*/ void set_Annotation(System.Xml.Schema.XmlSchemaAnnotation value);
                /*0x76d540c*/ System.Xml.XmlAttribute[] get_UnhandledAttributes();
                /*0x76d5414*/ void set_UnhandledAttributes(System.Xml.XmlAttribute[] value);
                /*0x76d541c*/ string get_IdAttribute();
                /*0x76d5424*/ void set_IdAttribute(string value);
                /*0x76d542c*/ void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes);
                /*0x76d5434*/ void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
            }

            class XmlSchemaAnnotation : System.Xml.Schema.XmlSchemaObject
            {
                /*0x38*/ string id;
                /*0x40*/ System.Xml.Schema.XmlSchemaObjectCollection items;
                /*0x48*/ System.Xml.XmlAttribute[] moreAttributes;

                /*0x76d5474*/ XmlSchemaAnnotation();
                /*0x76d5444*/ string get_Id();
                /*0x76d544c*/ void set_Id(string value);
                /*0x76d5454*/ System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                /*0x76d545c*/ string get_IdAttribute();
                /*0x76d5464*/ void set_IdAttribute(string value);
                /*0x76d546c*/ void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes);
            }

            class XmlSchemaAny : System.Xml.Schema.XmlSchemaParticle
            {
                /*0x78*/ string ns;
                /*0x80*/ System.Xml.Schema.XmlSchemaContentProcessing processContents;
                /*0x88*/ System.Xml.Schema.NamespaceList namespaceList;

                /*0x76d5bd0*/ XmlSchemaAny();
                /*0x76d54e0*/ string get_Namespace();
                /*0x76d54e8*/ void set_Namespace(string value);
                /*0x76d54f0*/ void set_ProcessContents(System.Xml.Schema.XmlSchemaContentProcessing value);
                /*0x76d54f8*/ System.Xml.Schema.NamespaceList get_NamespaceList();
                /*0x76d5500*/ string get_ResolvedNamespace();
                /*0x76d5558*/ System.Xml.Schema.XmlSchemaContentProcessing get_ProcessContentsCorrect();
                /*0x76d556c*/ string get_NameString();
                /*0x76d5a78*/ void BuildNamespaceList(string targetNamespace);
                /*0x76d5b00*/ void BuildNamespaceListV1Compat(string targetNamespace);
                /*0x76d5ba8*/ bool Allows(System.Xml.XmlQualifiedName qname);
            }

            class XmlSchemaAnyAttribute : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ string ns;
                /*0x58*/ System.Xml.Schema.XmlSchemaContentProcessing processContents;
                /*0x60*/ System.Xml.Schema.NamespaceList namespaceList;

                static /*0x76d5db4*/ bool IsSubset(System.Xml.Schema.XmlSchemaAnyAttribute sub, System.Xml.Schema.XmlSchemaAnyAttribute super);
                static /*0x76d5dd8*/ System.Xml.Schema.XmlSchemaAnyAttribute Intersection(System.Xml.Schema.XmlSchemaAnyAttribute o1, System.Xml.Schema.XmlSchemaAnyAttribute o2, bool v1Compat);
                static /*0x76d5ea4*/ System.Xml.Schema.XmlSchemaAnyAttribute Union(System.Xml.Schema.XmlSchemaAnyAttribute o1, System.Xml.Schema.XmlSchemaAnyAttribute o2, bool v1Compat);
                /*0x76d5e9c*/ XmlSchemaAnyAttribute();
                /*0x76d5c28*/ void set_Namespace(string value);
                /*0x76d5c30*/ System.Xml.Schema.XmlSchemaContentProcessing get_ProcessContents();
                /*0x76d5c38*/ void set_ProcessContents(System.Xml.Schema.XmlSchemaContentProcessing value);
                /*0x76d5c40*/ System.Xml.Schema.NamespaceList get_NamespaceList();
                /*0x76d5c48*/ System.Xml.Schema.XmlSchemaContentProcessing get_ProcessContentsCorrect();
                /*0x76d5c5c*/ void BuildNamespaceList(string targetNamespace);
                /*0x76d5ce4*/ void BuildNamespaceListV1Compat(string targetNamespace);
                /*0x76d5d8c*/ bool Allows(System.Xml.XmlQualifiedName qname);
            }

            class XmlSchemaAppInfo : System.Xml.Schema.XmlSchemaObject
            {
                /*0x38*/ string source;
                /*0x40*/ System.Xml.XmlNode[] markup;

                /*0x76d5f80*/ XmlSchemaAppInfo();
                /*0x76d5f68*/ void set_Source(string value);
                /*0x76d5f70*/ System.Xml.XmlNode[] get_Markup();
                /*0x76d5f78*/ void set_Markup(System.Xml.XmlNode[] value);
            }

            class XmlSchemaAttribute : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ string defaultValue;
                /*0x58*/ string fixedValue;
                /*0x60*/ string name;
                /*0x68*/ System.Xml.Schema.XmlSchemaForm form;
                /*0x6c*/ System.Xml.Schema.XmlSchemaUse use;
                /*0x70*/ System.Xml.XmlQualifiedName refName;
                /*0x78*/ System.Xml.XmlQualifiedName typeName;
                /*0x80*/ System.Xml.XmlQualifiedName qualifiedName;
                /*0x88*/ System.Xml.Schema.XmlSchemaSimpleType type;
                /*0x90*/ System.Xml.Schema.XmlSchemaSimpleType attributeType;
                /*0x98*/ System.Xml.Schema.SchemaAttDef attDef;

                /*0x76d6284*/ XmlSchemaAttribute();
                /*0x76d5f88*/ string get_DefaultValue();
                /*0x76d5f90*/ void set_DefaultValue(string value);
                /*0x76d5f98*/ string get_FixedValue();
                /*0x76d5fa0*/ void set_FixedValue(string value);
                /*0x76d5fa8*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0x76d5fb0*/ void set_Form(System.Xml.Schema.XmlSchemaForm value);
                /*0x76d5fb8*/ string get_Name();
                /*0x76d5fc0*/ void set_Name(string value);
                /*0x76d5fc8*/ System.Xml.XmlQualifiedName get_RefName();
                /*0x76d5fd0*/ void set_RefName(System.Xml.XmlQualifiedName value);
                /*0x76d6070*/ System.Xml.XmlQualifiedName get_SchemaTypeName();
                /*0x76d6078*/ void set_SchemaTypeName(System.Xml.XmlQualifiedName value);
                /*0x76d6118*/ System.Xml.Schema.XmlSchemaSimpleType get_SchemaType();
                /*0x76d6120*/ void set_SchemaType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0x76d6128*/ System.Xml.Schema.XmlSchemaUse get_Use();
                /*0x76d6130*/ void set_Use(System.Xml.Schema.XmlSchemaUse value);
                /*0x76d6138*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0x76d6140*/ System.Xml.Schema.XmlSchemaSimpleType get_AttributeSchemaType();
                /*0x76d6148*/ System.Xml.Schema.XmlSchemaDatatype get_Datatype();
                /*0x76d6160*/ void SetQualifiedName(System.Xml.XmlQualifiedName value);
                /*0x76d6168*/ void SetAttributeType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0x76d6170*/ System.Xml.Schema.SchemaAttDef get_AttDef();
                /*0x76d6178*/ void set_AttDef(System.Xml.Schema.SchemaAttDef value);
                /*0x76d6180*/ string get_NameAttribute();
                /*0x76d6188*/ void set_NameAttribute(string value);
                /*0x76d6190*/ System.Xml.Schema.XmlSchemaObject Clone();
            }

            class XmlSchemaAttributeGroup : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ string name;
                /*0x58*/ System.Xml.Schema.XmlSchemaObjectCollection attributes;
                /*0x60*/ System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;
                /*0x68*/ System.Xml.XmlQualifiedName qname;
                /*0x70*/ System.Xml.Schema.XmlSchemaAttributeGroup redefined;
                /*0x78*/ System.Xml.Schema.XmlSchemaObjectTable attributeUses;
                /*0x80*/ System.Xml.Schema.XmlSchemaAnyAttribute attributeWildcard;
                /*0x88*/ int selfReferenceCount;

                /*0x76d68ac*/ XmlSchemaAttributeGroup();
                /*0x76d6324*/ string get_Name();
                /*0x76d632c*/ void set_Name(string value);
                /*0x76d6334*/ System.Xml.Schema.XmlSchemaObjectCollection get_Attributes();
                /*0x76d633c*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0x76d6344*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x76d634c*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0x76d6354*/ System.Xml.Schema.XmlSchemaObjectTable get_AttributeUses();
                /*0x76d63c4*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AttributeWildcard();
                /*0x76d63cc*/ void set_AttributeWildcard(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x76d63d4*/ System.Xml.Schema.XmlSchemaAttributeGroup get_RedefinedAttributeGroup();
                /*0x76d63dc*/ System.Xml.Schema.XmlSchemaAttributeGroup get_Redefined();
                /*0x76d63e4*/ void set_Redefined(System.Xml.Schema.XmlSchemaAttributeGroup value);
                /*0x76d63ec*/ int get_SelfReferenceCount();
                /*0x76d63f4*/ void set_SelfReferenceCount(int value);
                /*0x76d63fc*/ string get_NameAttribute();
                /*0x76d6404*/ void set_NameAttribute(string value);
                /*0x76d640c*/ void SetQualifiedName(System.Xml.XmlQualifiedName value);
                /*0x76d6414*/ System.Xml.Schema.XmlSchemaObject Clone();
            }

            class XmlSchemaAttributeGroupRef : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ System.Xml.XmlQualifiedName refName;

                /*0x76d6a04*/ XmlSchemaAttributeGroupRef();
                /*0x76d695c*/ System.Xml.XmlQualifiedName get_RefName();
                /*0x76d6964*/ void set_RefName(System.Xml.XmlQualifiedName value);
            }

            class XmlSchemaChoice : System.Xml.Schema.XmlSchemaGroupBase
            {
                /*0x78*/ System.Xml.Schema.XmlSchemaObjectCollection items;

                /*0x76d6a8c*/ XmlSchemaChoice();
                /*0x76d6a74*/ System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                /*0x76d6a7c*/ bool get_IsEmpty();
                /*0x76d6a84*/ void SetItems(System.Xml.Schema.XmlSchemaObjectCollection newItems);
            }

            class XmlSchemaCollection : System.Collections.ICollection, System.Collections.IEnumerable
            {
                /*0x10*/ System.Collections.Hashtable collection;
                /*0x18*/ System.Xml.XmlNameTable nameTable;
                /*0x20*/ System.Xml.Schema.SchemaNames schemaNames;
                /*0x28*/ System.Threading.ReaderWriterLock wLock;
                /*0x30*/ int timeout;
                /*0x34*/ bool isThreadSafe;
                /*0x38*/ System.Xml.Schema.ValidationEventHandler validationEventHandler;
                /*0x40*/ System.Xml.XmlResolver xmlResolver;

                /*0x76d6af4*/ XmlSchemaCollection(System.Xml.XmlNameTable nametable);
                /*0x76d6c38*/ int get_Count();
                /*0x76d6c5c*/ System.Xml.XmlNameTable get_NameTable();
                /*0x76d6c64*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x76d6c6c*/ System.Xml.Schema.XmlSchema get_Item(string ns);
                /*0x76d6d04*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x76d6dac*/ System.Xml.Schema.XmlSchemaCollectionEnumerator GetEnumerator();
                /*0x76d6e08*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x76d7094*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x76d709c*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x76d70a0*/ int System.Collections.ICollection.get_Count();
                /*0x76d1b7c*/ System.Xml.Schema.SchemaInfo GetSchemaInfo(string ns);
                /*0x76d70c4*/ System.Xml.Schema.SchemaNames GetSchemaNames(System.Xml.XmlNameTable nt);
                /*0x76d0220*/ System.Xml.Schema.XmlSchema Add(string ns, System.Xml.Schema.SchemaInfo schemaInfo, System.Xml.Schema.XmlSchema schema, bool compile);
                /*0x76d7168*/ System.Xml.Schema.XmlSchema Add(string ns, System.Xml.Schema.SchemaInfo schemaInfo, System.Xml.Schema.XmlSchema schema, bool compile, System.Xml.XmlResolver resolver);
                /*0x76d72d4*/ void Add(string ns, System.Xml.Schema.XmlSchemaCollectionNode node);
                /*0x76d7410*/ System.Xml.Schema.ValidationEventHandler get_EventHandler();
                /*0x76d7418*/ void set_EventHandler(System.Xml.Schema.ValidationEventHandler value);
            }

            class XmlSchemaCollectionNode
            {
                /*0x10*/ string namespaceUri;
                /*0x18*/ System.Xml.Schema.SchemaInfo schemaInfo;
                /*0x20*/ System.Xml.Schema.XmlSchema schema;

                /*0x76d72cc*/ XmlSchemaCollectionNode();
                /*0x76d7420*/ void set_NamespaceURI(string value);
                /*0x76d7428*/ System.Xml.Schema.SchemaInfo get_SchemaInfo();
                /*0x76d7430*/ void set_SchemaInfo(System.Xml.Schema.SchemaInfo value);
                /*0x76d7438*/ System.Xml.Schema.XmlSchema get_Schema();
                /*0x76d7440*/ void set_Schema(System.Xml.Schema.XmlSchema value);
            }

            class XmlSchemaCollectionEnumerator : System.Collections.IEnumerator
            {
                /*0x10*/ System.Collections.IDictionaryEnumerator enumerator;

                /*0x76d6d60*/ XmlSchemaCollectionEnumerator(System.Collections.Hashtable collection);
                /*0x76d7448*/ void System.Collections.IEnumerator.Reset();
                /*0x76d74ec*/ bool System.Collections.IEnumerator.MoveNext();
                /*0x76d6ff4*/ bool MoveNext();
                /*0x76d758c*/ object System.Collections.IEnumerator.get_Current();
                /*0x76d6f1c*/ System.Xml.Schema.XmlSchema get_Current();
                /*0x76d7590*/ System.Xml.Schema.XmlSchemaCollectionNode get_CurrentNode();
            }

            class XmlSchemaCompilationSettings
            {
                /*0x10*/ bool enableUpaCheck;

                /*0x76d7664*/ XmlSchemaCompilationSettings();
                /*0x76d7684*/ bool get_EnableUpaCheck();
            }

            class XmlSchemaComplexContent : System.Xml.Schema.XmlSchemaContentModel
            {
                /*0x50*/ System.Xml.Schema.XmlSchemaContent content;
                /*0x58*/ bool isMixed;
                /*0x59*/ bool hasMixedAttribute;

                /*0x76d76c0*/ XmlSchemaComplexContent();
                /*0x76d768c*/ bool get_IsMixed();
                /*0x76d7694*/ void set_IsMixed(bool value);
                /*0x76d76a8*/ System.Xml.Schema.XmlSchemaContent get_Content();
                /*0x76d76b0*/ void set_Content(System.Xml.Schema.XmlSchemaContent value);
                /*0x76d76b8*/ bool get_HasMixedAttribute();
            }

            class XmlSchemaComplexContentExtension : System.Xml.Schema.XmlSchemaContent
            {
                /*0x50*/ System.Xml.Schema.XmlSchemaParticle particle;
                /*0x58*/ System.Xml.Schema.XmlSchemaObjectCollection attributes;
                /*0x60*/ System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;
                /*0x68*/ System.Xml.XmlQualifiedName baseTypeName;

                /*0x76d77a8*/ XmlSchemaComplexContentExtension();
                /*0x76d76d0*/ System.Xml.XmlQualifiedName get_BaseTypeName();
                /*0x76d76d8*/ void set_BaseTypeName(System.Xml.XmlQualifiedName value);
                /*0x76d7778*/ System.Xml.Schema.XmlSchemaParticle get_Particle();
                /*0x76d7780*/ void set_Particle(System.Xml.Schema.XmlSchemaParticle value);
                /*0x76d7788*/ System.Xml.Schema.XmlSchemaObjectCollection get_Attributes();
                /*0x76d7790*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0x76d7798*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x76d77a0*/ void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes);
            }

            class XmlSchemaComplexContentRestriction : System.Xml.Schema.XmlSchemaContent
            {
                /*0x50*/ System.Xml.Schema.XmlSchemaParticle particle;
                /*0x58*/ System.Xml.Schema.XmlSchemaObjectCollection attributes;
                /*0x60*/ System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;
                /*0x68*/ System.Xml.XmlQualifiedName baseTypeName;

                /*0x76d7938*/ XmlSchemaComplexContentRestriction();
                /*0x76d7860*/ System.Xml.XmlQualifiedName get_BaseTypeName();
                /*0x76d7868*/ void set_BaseTypeName(System.Xml.XmlQualifiedName value);
                /*0x76d7908*/ System.Xml.Schema.XmlSchemaParticle get_Particle();
                /*0x76d7910*/ void set_Particle(System.Xml.Schema.XmlSchemaParticle value);
                /*0x76d7918*/ System.Xml.Schema.XmlSchemaObjectCollection get_Attributes();
                /*0x76d7920*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0x76d7928*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x76d7930*/ void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes);
            }

            class XmlSchemaComplexType : System.Xml.Schema.XmlSchemaType
            {
                static /*0x0*/ System.Xml.Schema.XmlSchemaComplexType anyTypeLax;
                static /*0x8*/ System.Xml.Schema.XmlSchemaComplexType anyTypeSkip;
                static /*0x10*/ System.Xml.Schema.XmlSchemaComplexType untypedAnyType;
                /*0x94*/ System.Xml.Schema.XmlSchemaDerivationMethod block;
                /*0x98*/ System.Xml.Schema.XmlSchemaContentModel contentModel;
                /*0xa0*/ System.Xml.Schema.XmlSchemaParticle particle;
                /*0xa8*/ System.Xml.Schema.XmlSchemaObjectCollection attributes;
                /*0xb0*/ System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;
                /*0xb8*/ System.Xml.Schema.XmlSchemaParticle contentTypeParticle;
                /*0xc0*/ System.Xml.Schema.XmlSchemaDerivationMethod blockResolved;
                /*0xc8*/ System.Xml.Schema.XmlSchemaObjectTable localElements;
                /*0xd0*/ System.Xml.Schema.XmlSchemaObjectTable attributeUses;
                /*0xd8*/ System.Xml.Schema.XmlSchemaAnyAttribute attributeWildcard;
                /*0xe0*/ byte pvFlags;

                static /*0x76d79e8*/ XmlSchemaComplexType();
                static /*0x76d7c0c*/ System.Xml.Schema.XmlSchemaComplexType CreateAnyType(System.Xml.Schema.XmlSchemaContentProcessing processContents);
                static /*0x76d8038*/ System.Xml.Schema.XmlSchemaComplexType get_AnyType();
                static /*0x76d8090*/ System.Xml.Schema.XmlSchemaComplexType get_UntypedAnyType();
                static /*0x76d7fc8*/ System.Xml.Schema.ContentValidator get_AnyTypeContentValidator();
                static /*0x76d667c*/ System.Xml.Schema.XmlSchemaObjectCollection CloneAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes);
                static /*0x76d8d08*/ System.Xml.Schema.XmlSchemaObjectCollection CloneGroupBaseParticles(System.Xml.Schema.XmlSchemaObjectCollection groupBaseParticles, System.Xml.Schema.XmlSchema parentSchema);
                static /*0x76d8940*/ System.Xml.Schema.XmlSchemaParticle CloneParticle(System.Xml.Schema.XmlSchemaParticle particle, System.Xml.Schema.XmlSchema parentSchema);
                static /*0x76d8ee8*/ System.Xml.Schema.XmlSchemaForm GetResolvedElementForm(System.Xml.Schema.XmlSchema parentSchema, System.Xml.Schema.XmlSchemaElement element);
                static /*0x76d86c4*/ bool HasParticleRef(System.Xml.Schema.XmlSchemaParticle particle, System.Xml.Schema.XmlSchema parentSchema);
                static /*0x76d6520*/ bool HasAttributeQNameRef(System.Xml.Schema.XmlSchemaObjectCollection attributes);
                /*0x76d7f50*/ XmlSchemaComplexType();
                /*0x76d80e8*/ bool get_IsAbstract();
                /*0x76d80f4*/ void set_IsAbstract(bool value);
                /*0x76d8114*/ System.Xml.Schema.XmlSchemaDerivationMethod get_Block();
                /*0x76d811c*/ void set_Block(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x76d8124*/ bool get_IsMixed();
                /*0x76d8130*/ void set_IsMixed(bool value);
                /*0x76d8150*/ System.Xml.Schema.XmlSchemaContentModel get_ContentModel();
                /*0x76d8158*/ void set_ContentModel(System.Xml.Schema.XmlSchemaContentModel value);
                /*0x76d8160*/ System.Xml.Schema.XmlSchemaParticle get_Particle();
                /*0x76d8168*/ void set_Particle(System.Xml.Schema.XmlSchemaParticle value);
                /*0x76d8170*/ System.Xml.Schema.XmlSchemaObjectCollection get_Attributes();
                /*0x76d81e0*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0x76d81e8*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x76d81f0*/ System.Xml.Schema.XmlSchemaContentType get_ContentType();
                /*0x76d81f8*/ System.Xml.Schema.XmlSchemaParticle get_ContentTypeParticle();
                /*0x76d8200*/ System.Xml.Schema.XmlSchemaDerivationMethod get_BlockResolved();
                /*0x76d8208*/ System.Xml.Schema.XmlSchemaObjectTable get_AttributeUses();
                /*0x76d8278*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AttributeWildcard();
                /*0x76d8280*/ System.Xml.Schema.XmlSchemaObjectTable get_LocalElements();
                /*0x76d82f0*/ void SetContentTypeParticle(System.Xml.Schema.XmlSchemaParticle value);
                /*0x76d82f8*/ void SetBlockResolved(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x76d8300*/ void SetAttributeWildcard(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x76d8308*/ void set_HasWildCard(bool value);
                /*0x76d8318*/ void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes);
                /*0x76d8320*/ bool ContainsIdAttribute(bool findAll);
                /*0x76d86bc*/ System.Xml.Schema.XmlSchemaObject Clone();
                /*0x76d43f8*/ System.Xml.Schema.XmlSchemaObject Clone(System.Xml.Schema.XmlSchema parentSchema);
                /*0x76d8be8*/ void ClearCompiledState();
            }

            class XmlSchemaContent : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x76d7858*/ XmlSchemaContent();
            }

            class XmlSchemaContentModel : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x76d76c8*/ XmlSchemaContentModel();
                /*0x38148bc*/ System.Xml.Schema.XmlSchemaContent get_Content();
                /*0x3816710*/ void set_Content(System.Xml.Schema.XmlSchemaContent value);
            }

            enum XmlSchemaContentProcessing
            {
                None = 0,
                Skip = 1,
                Lax = 2,
                Strict = 3,
            }

            enum XmlSchemaContentType
            {
                TextOnly = 0,
                Empty = 1,
                ElementOnly = 2,
                Mixed = 3,
            }

            class XmlSchemaDatatype
            {
                static /*0x76d94f0*/ string ConcatenatedToString(object value);
                static /*0x76cbc98*/ System.Xml.Schema.XmlSchemaDatatype FromXmlTokenizedType(System.Xml.XmlTokenizedType token);
                static /*0x76d9b94*/ System.Xml.Schema.XmlSchemaDatatype FromXmlTokenizedTypeXsd(System.Xml.XmlTokenizedType token);
                static /*0x76ca51c*/ System.Xml.Schema.XmlSchemaDatatype FromXdrName(string name);
                static /*0x76d9bec*/ System.Xml.Schema.XmlSchemaDatatype DeriveByUnion(System.Xml.Schema.XmlSchemaSimpleType[] types, System.Xml.Schema.XmlSchemaType schemaType);
                static /*0x76c80b4*/ string XdrCanonizeUri(string uri, System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames);
                /*0x76d9c54*/ XmlSchemaDatatype();
                /*0x38148bc*/ System.Type get_ValueType();
                /*0x3814574*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x3814c14*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
                /*0x76d8f10*/ System.Xml.Schema.XmlSchemaDatatypeVariety get_Variety();
                /*0x76d8f18*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x76d8f20*/ bool IsDerivedFrom(System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3813ffc*/ bool get_HasLexicalFacets();
                /*0x3813ffc*/ bool get_HasValueFacets();
                /*0x38148bc*/ System.Xml.Schema.XmlValueConverter get_ValueConverter();
                /*0x38148bc*/ System.Xml.Schema.RestrictionFacets get_Restriction();
                int Compare(object value1, object value2);
                object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, bool createAtomicValue);
                /*0x3814c50*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
                /*0x3814c50*/ System.Exception TryParseValue(object value, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver namespaceResolver, ref object typedValue);
                /*0x38148bc*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x3814574*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x3814c14*/ System.Xml.Schema.XmlSchemaDatatype DeriveByRestriction(System.Xml.Schema.XmlSchemaObjectCollection facets, System.Xml.XmlNameTable nameTable, System.Xml.Schema.XmlSchemaType schemaType);
                /*0x3814a3c*/ System.Xml.Schema.XmlSchemaDatatype DeriveByList(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x3816810*/ void VerifySchemaValid(System.Xml.Schema.XmlSchemaObjectTable notations, System.Xml.Schema.XmlSchemaObject caller);
                /*0x3814200*/ bool IsEqual(object o1, object o2);
                /*0x38141c4*/ bool IsComparable(System.Xml.Schema.XmlSchemaDatatype dtype);
                /*0x76d8f28*/ string get_TypeCodeString();
                /*0x76d9044*/ string TypeCodeToString(System.Xml.Schema.XmlTypeCode typeCode);
            }

            enum XmlSchemaDerivationMethod
            {
                Empty = 0,
                Substitution = 1,
                Extension = 2,
                Restriction = 4,
                List = 8,
                Union = 16,
                All = 255,
                None = 256,
            }

            class XmlSchemaDocumentation : System.Xml.Schema.XmlSchemaObject
            {
                static /*0x0*/ System.Xml.Schema.XmlSchemaSimpleType languageType;
                /*0x38*/ string source;
                /*0x40*/ string language;
                /*0x48*/ System.Xml.XmlNode[] markup;

                static /*0x76d9d48*/ XmlSchemaDocumentation();
                /*0x76d9d40*/ XmlSchemaDocumentation();
                /*0x76d9c5c*/ void set_Source(string value);
                /*0x76d9c64*/ void set_Language(string value);
                /*0x76d9d38*/ void set_Markup(System.Xml.XmlNode[] value);
            }

            class XmlSchemaElement : System.Xml.Schema.XmlSchemaParticle
            {
                /*0x74*/ bool isAbstract;
                /*0x75*/ bool hasAbstractAttribute;
                /*0x76*/ bool isNillable;
                /*0x77*/ bool hasNillableAttribute;
                /*0x78*/ bool isLocalTypeDerivationChecked;
                /*0x7c*/ System.Xml.Schema.XmlSchemaDerivationMethod block;
                /*0x80*/ System.Xml.Schema.XmlSchemaDerivationMethod final;
                /*0x84*/ System.Xml.Schema.XmlSchemaForm form;
                /*0x88*/ string defaultValue;
                /*0x90*/ string fixedValue;
                /*0x98*/ string name;
                /*0xa0*/ System.Xml.XmlQualifiedName refName;
                /*0xa8*/ System.Xml.XmlQualifiedName substitutionGroup;
                /*0xb0*/ System.Xml.XmlQualifiedName typeName;
                /*0xb8*/ System.Xml.Schema.XmlSchemaType type;
                /*0xc0*/ System.Xml.XmlQualifiedName qualifiedName;
                /*0xc8*/ System.Xml.Schema.XmlSchemaType elementType;
                /*0xd0*/ System.Xml.Schema.XmlSchemaDerivationMethod blockResolved;
                /*0xd4*/ System.Xml.Schema.XmlSchemaDerivationMethod finalResolved;
                /*0xd8*/ System.Xml.Schema.XmlSchemaObjectCollection constraints;
                /*0xe0*/ System.Xml.Schema.SchemaElementDecl elementDecl;

                /*0x76da20c*/ XmlSchemaElement();
                /*0x76d9e2c*/ bool get_IsAbstract();
                /*0x76d9e34*/ void set_IsAbstract(bool value);
                /*0x76d9e48*/ System.Xml.Schema.XmlSchemaDerivationMethod get_Block();
                /*0x76d9e50*/ void set_Block(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x76d9e58*/ string get_DefaultValue();
                /*0x76d9e60*/ void set_DefaultValue(string value);
                /*0x76d9e68*/ System.Xml.Schema.XmlSchemaDerivationMethod get_Final();
                /*0x76d9e70*/ void set_Final(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x76d9e78*/ string get_FixedValue();
                /*0x76d9e80*/ void set_FixedValue(string value);
                /*0x76d9e88*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0x76d9e90*/ void set_Form(System.Xml.Schema.XmlSchemaForm value);
                /*0x76d9e98*/ string get_Name();
                /*0x76d9ea0*/ void set_Name(string value);
                /*0x76d9ea8*/ bool get_IsNillable();
                /*0x76d9eb0*/ void set_IsNillable(bool value);
                /*0x76d9ec4*/ bool get_HasNillableAttribute();
                /*0x76d9ecc*/ bool get_HasAbstractAttribute();
                /*0x76d9ed4*/ System.Xml.XmlQualifiedName get_RefName();
                /*0x76d9edc*/ void set_RefName(System.Xml.XmlQualifiedName value);
                /*0x76d9f7c*/ System.Xml.XmlQualifiedName get_SubstitutionGroup();
                /*0x76d9f84*/ void set_SubstitutionGroup(System.Xml.XmlQualifiedName value);
                /*0x76da024*/ System.Xml.XmlQualifiedName get_SchemaTypeName();
                /*0x76da02c*/ void set_SchemaTypeName(System.Xml.XmlQualifiedName value);
                /*0x76da0cc*/ System.Xml.Schema.XmlSchemaType get_SchemaType();
                /*0x76da0d4*/ void set_SchemaType(System.Xml.Schema.XmlSchemaType value);
                /*0x76da0dc*/ System.Xml.Schema.XmlSchemaObjectCollection get_Constraints();
                /*0x76da14c*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0x76da154*/ System.Xml.Schema.XmlSchemaType get_ElementSchemaType();
                /*0x76da15c*/ System.Xml.Schema.XmlSchemaDerivationMethod get_BlockResolved();
                /*0x76da164*/ System.Xml.Schema.XmlSchemaDerivationMethod get_FinalResolved();
                /*0x76da16c*/ void SetQualifiedName(System.Xml.XmlQualifiedName value);
                /*0x76da174*/ void SetElementType(System.Xml.Schema.XmlSchemaType value);
                /*0x76da17c*/ void SetBlockResolved(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x76da184*/ void SetFinalResolved(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x76da18c*/ bool get_HasConstraints();
                /*0x76da1b0*/ bool get_IsLocalTypeDerivationChecked();
                /*0x76da1b8*/ void set_IsLocalTypeDerivationChecked(bool value);
                /*0x76da1c4*/ System.Xml.Schema.SchemaElementDecl get_ElementDecl();
                /*0x76da1cc*/ void set_ElementDecl(System.Xml.Schema.SchemaElementDecl value);
                /*0x76da1d4*/ string get_NameAttribute();
                /*0x76da1dc*/ void set_NameAttribute(string value);
                /*0x76da1e4*/ string get_NameString();
                /*0x76da204*/ System.Xml.Schema.XmlSchemaObject Clone();
                /*0x76d4b0c*/ System.Xml.Schema.XmlSchemaObject Clone(System.Xml.Schema.XmlSchema parentSchema);
            }

            class XmlSchemaException : System.SystemException
            {
                /*0x90*/ string res;
                /*0x98*/ string[] args;
                /*0xa0*/ string sourceUri;
                /*0xa8*/ int lineNumber;
                /*0xac*/ int linePosition;
                /*0xb0*/ System.Xml.Schema.XmlSchemaObject sourceSchemaObject;
                /*0xb8*/ string message;

                static /*0x76da6a4*/ string CreateMessage(string res, string[] args);
                /*0x76da2f0*/ XmlSchemaException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x76da8d8*/ XmlSchemaException();
                /*0x76da8ec*/ XmlSchemaException(string message);
                /*0x76da9fc*/ XmlSchemaException(string message, System.Exception innerException);
                /*0x76da8fc*/ XmlSchemaException(string message, System.Exception innerException, int lineNumber, int linePosition);
                /*0x76daac0*/ XmlSchemaException(string res, string[] args);
                /*0x76d2104*/ XmlSchemaException(string res, string arg);
                /*0x76cd814*/ XmlSchemaException(string res, string arg, string sourceUri, int lineNumber, int linePosition);
                /*0x76daaec*/ XmlSchemaException(string res, string sourceUri, int lineNumber, int linePosition);
                /*0x76cd720*/ XmlSchemaException(string res, string[] args, string sourceUri, int lineNumber, int linePosition);
                /*0x76dab1c*/ XmlSchemaException(string res, System.Xml.Schema.XmlSchemaObject source);
                /*0x76dab58*/ XmlSchemaException(string res, string arg, System.Xml.Schema.XmlSchemaObject source);
                /*0x76dab28*/ XmlSchemaException(string res, string[] args, System.Xml.Schema.XmlSchemaObject source);
                /*0x76daa08*/ XmlSchemaException(string res, string[] args, System.Exception innerException, string sourceUri, int lineNumber, int linePosition, System.Xml.Schema.XmlSchemaObject source);
                /*0x76da768*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x76dabf8*/ string get_GetRes();
                /*0x76dac00*/ string[] get_Args();
                /*0x76dac08*/ string get_SourceUri();
                /*0x76dac10*/ int get_LineNumber();
                /*0x76dac18*/ int get_LinePosition();
                /*0x76dac20*/ System.Xml.Schema.XmlSchemaObject get_SourceSchemaObject();
                /*0x76d156c*/ void SetSource(string sourceUri, int lineNumber, int linePosition);
                /*0x76dac28*/ void SetSchemaObject(System.Xml.Schema.XmlSchemaObject source);
                /*0x76dac30*/ void SetSource(System.Xml.Schema.XmlSchemaObject source);
                /*0x76dac74*/ string get_Message();
            }

            class XmlSchemaExternal : System.Xml.Schema.XmlSchemaObject
            {
                /*0x38*/ string location;
                /*0x40*/ System.Uri baseUri;
                /*0x48*/ System.Xml.Schema.XmlSchema schema;
                /*0x50*/ string id;
                /*0x58*/ System.Xml.XmlAttribute[] moreAttributes;
                /*0x60*/ System.Xml.Schema.Compositor compositor;

                /*0x76dacf4*/ XmlSchemaExternal();
                /*0x76dac8c*/ string get_SchemaLocation();
                /*0x76dac94*/ void set_SchemaLocation(string value);
                /*0x76dac9c*/ System.Xml.Schema.XmlSchema get_Schema();
                /*0x76daca4*/ void set_Schema(System.Xml.Schema.XmlSchema value);
                /*0x76dacac*/ string get_Id();
                /*0x76dacb4*/ void set_Id(string value);
                /*0x76dacbc*/ System.Uri get_BaseUri();
                /*0x76dacc4*/ void set_BaseUri(System.Uri value);
                /*0x76daccc*/ string get_IdAttribute();
                /*0x76dacd4*/ void set_IdAttribute(string value);
                /*0x76dacdc*/ void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes);
                /*0x76dace4*/ System.Xml.Schema.Compositor get_Compositor();
                /*0x76dacec*/ void set_Compositor(System.Xml.Schema.Compositor value);
            }

            enum FacetType
            {
                None = 0,
                Length = 1,
                MinLength = 2,
                MaxLength = 3,
                Pattern = 4,
                Whitespace = 5,
                Enumeration = 6,
                MinExclusive = 7,
                MinInclusive = 8,
                MaxExclusive = 9,
                MaxInclusive = 10,
                TotalDigits = 11,
                FractionDigits = 12,
            }

            class XmlSchemaFacet : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ string value;
                /*0x58*/ bool isFixed;
                /*0x5c*/ System.Xml.Schema.FacetType facetType;

                /*0x76dadd8*/ XmlSchemaFacet();
                /*0x76dacfc*/ string get_Value();
                /*0x76dad04*/ void set_Value(string value);
                /*0x76dad0c*/ bool get_IsFixed();
                /*0x76dad14*/ void set_IsFixed(bool value);
                /*0x76dadc8*/ System.Xml.Schema.FacetType get_FacetType();
                /*0x76dadd0*/ void set_FacetType(System.Xml.Schema.FacetType value);
            }

            class XmlSchemaNumericFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x76dade0*/ XmlSchemaNumericFacet();
            }

            class XmlSchemaLengthFacet : System.Xml.Schema.XmlSchemaNumericFacet
            {
                /*0x76dade8*/ XmlSchemaLengthFacet();
            }

            class XmlSchemaMinLengthFacet : System.Xml.Schema.XmlSchemaNumericFacet
            {
                /*0x76dae08*/ XmlSchemaMinLengthFacet();
            }

            class XmlSchemaMaxLengthFacet : System.Xml.Schema.XmlSchemaNumericFacet
            {
                /*0x76dae28*/ XmlSchemaMaxLengthFacet();
            }

            class XmlSchemaPatternFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x76dae48*/ XmlSchemaPatternFacet();
            }

            class XmlSchemaEnumerationFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x76dae68*/ XmlSchemaEnumerationFacet();
            }

            class XmlSchemaMinExclusiveFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x76dae88*/ XmlSchemaMinExclusiveFacet();
            }

            class XmlSchemaMinInclusiveFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x76daea8*/ XmlSchemaMinInclusiveFacet();
            }

            class XmlSchemaMaxExclusiveFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x76daec8*/ XmlSchemaMaxExclusiveFacet();
            }

            class XmlSchemaMaxInclusiveFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x76daee8*/ XmlSchemaMaxInclusiveFacet();
            }

            class XmlSchemaTotalDigitsFacet : System.Xml.Schema.XmlSchemaNumericFacet
            {
                /*0x76daf08*/ XmlSchemaTotalDigitsFacet();
            }

            class XmlSchemaFractionDigitsFacet : System.Xml.Schema.XmlSchemaNumericFacet
            {
                /*0x76daf28*/ XmlSchemaFractionDigitsFacet();
            }

            class XmlSchemaWhiteSpaceFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x76daf48*/ XmlSchemaWhiteSpaceFacet();
            }

            enum XmlSchemaForm
            {
                None = 0,
                Qualified = 1,
                Unqualified = 2,
            }

            class XmlSchemaGroup : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ string name;
                /*0x58*/ System.Xml.Schema.XmlSchemaGroupBase particle;
                /*0x60*/ System.Xml.Schema.XmlSchemaParticle canonicalParticle;
                /*0x68*/ System.Xml.XmlQualifiedName qname;
                /*0x70*/ System.Xml.Schema.XmlSchemaGroup redefined;
                /*0x78*/ int selfReferenceCount;

                /*0x76dafe0*/ XmlSchemaGroup();
                /*0x76daf68*/ string get_Name();
                /*0x76daf70*/ void set_Name(string value);
                /*0x76daf78*/ System.Xml.Schema.XmlSchemaGroupBase get_Particle();
                /*0x76daf80*/ void set_Particle(System.Xml.Schema.XmlSchemaGroupBase value);
                /*0x76daf88*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0x76daf90*/ System.Xml.Schema.XmlSchemaParticle get_CanonicalParticle();
                /*0x76daf98*/ void set_CanonicalParticle(System.Xml.Schema.XmlSchemaParticle value);
                /*0x76dafa0*/ System.Xml.Schema.XmlSchemaGroup get_Redefined();
                /*0x76dafa8*/ void set_Redefined(System.Xml.Schema.XmlSchemaGroup value);
                /*0x76dafb0*/ int get_SelfReferenceCount();
                /*0x76dafb8*/ void set_SelfReferenceCount(int value);
                /*0x76dafc0*/ string get_NameAttribute();
                /*0x76dafc8*/ void set_NameAttribute(string value);
                /*0x76dafd0*/ void SetQualifiedName(System.Xml.XmlQualifiedName value);
                /*0x76dafd8*/ System.Xml.Schema.XmlSchemaObject Clone();
                /*0x76d4d2c*/ System.Xml.Schema.XmlSchemaObject Clone(System.Xml.Schema.XmlSchema parentSchema);
            }

            class XmlSchemaGroupBase : System.Xml.Schema.XmlSchemaParticle
            {
                /*0x76d5394*/ XmlSchemaGroupBase();
                /*0x38148bc*/ System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                /*0x3816710*/ void SetItems(System.Xml.Schema.XmlSchemaObjectCollection newItems);
            }

            class XmlSchemaGroupRef : System.Xml.Schema.XmlSchemaParticle
            {
                /*0x78*/ System.Xml.XmlQualifiedName refName;
                /*0x80*/ System.Xml.Schema.XmlSchemaGroupBase particle;
                /*0x88*/ System.Xml.Schema.XmlSchemaGroup refined;

                /*0x76db078*/ XmlSchemaGroupRef();
                /*0x76db050*/ System.Xml.XmlQualifiedName get_RefName();
                /*0x76d8e48*/ void set_RefName(System.Xml.XmlQualifiedName value);
                /*0x76db058*/ System.Xml.Schema.XmlSchemaGroupBase get_Particle();
                /*0x76db060*/ void SetParticle(System.Xml.Schema.XmlSchemaGroupBase value);
                /*0x76db068*/ System.Xml.Schema.XmlSchemaGroup get_Redefined();
                /*0x76db070*/ void set_Redefined(System.Xml.Schema.XmlSchemaGroup value);
            }

            class XmlSchemaIdentityConstraint : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ string name;
                /*0x58*/ System.Xml.Schema.XmlSchemaXPath selector;
                /*0x60*/ System.Xml.Schema.XmlSchemaObjectCollection fields;
                /*0x68*/ System.Xml.XmlQualifiedName qualifiedName;
                /*0x70*/ System.Xml.Schema.CompiledIdentityConstraint compiledConstraint;

                /*0x76db164*/ XmlSchemaIdentityConstraint();
                /*0x76db10c*/ string get_Name();
                /*0x76db114*/ void set_Name(string value);
                /*0x76db11c*/ System.Xml.Schema.XmlSchemaXPath get_Selector();
                /*0x76db124*/ void set_Selector(System.Xml.Schema.XmlSchemaXPath value);
                /*0x76db12c*/ System.Xml.Schema.XmlSchemaObjectCollection get_Fields();
                /*0x76db134*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0x76db13c*/ void SetQualifiedName(System.Xml.XmlQualifiedName value);
                /*0x76db144*/ System.Xml.Schema.CompiledIdentityConstraint get_CompiledConstraint();
                /*0x76db14c*/ void set_CompiledConstraint(System.Xml.Schema.CompiledIdentityConstraint value);
                /*0x76db154*/ string get_NameAttribute();
                /*0x76db15c*/ void set_NameAttribute(string value);
            }

            class XmlSchemaXPath : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ string xpath;

                /*0x76db224*/ XmlSchemaXPath();
                /*0x76db214*/ string get_XPath();
                /*0x76db21c*/ void set_XPath(string value);
            }

            class XmlSchemaUnique : System.Xml.Schema.XmlSchemaIdentityConstraint
            {
                /*0x76db22c*/ XmlSchemaUnique();
            }

            class XmlSchemaKey : System.Xml.Schema.XmlSchemaIdentityConstraint
            {
                /*0x76db230*/ XmlSchemaKey();
            }

            class XmlSchemaKeyref : System.Xml.Schema.XmlSchemaIdentityConstraint
            {
                /*0x78*/ System.Xml.XmlQualifiedName refer;

                /*0x76db2dc*/ XmlSchemaKeyref();
                /*0x76db234*/ System.Xml.XmlQualifiedName get_Refer();
                /*0x76db23c*/ void set_Refer(System.Xml.XmlQualifiedName value);
            }

            class XmlSchemaImport : System.Xml.Schema.XmlSchemaExternal
            {
                /*0x68*/ string ns;
                /*0x70*/ System.Xml.Schema.XmlSchemaAnnotation annotation;

                /*0x76db348*/ XmlSchemaImport();
                /*0x76db368*/ string get_Namespace();
                /*0x76db370*/ void set_Namespace(string value);
                /*0x76db378*/ void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
            }

            class XmlSchemaInclude : System.Xml.Schema.XmlSchemaExternal
            {
                /*0x68*/ System.Xml.Schema.XmlSchemaAnnotation annotation;

                /*0x76db380*/ XmlSchemaInclude();
                /*0x76db3a0*/ void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
            }

            class XmlSchemaInfo : System.Xml.Schema.IXmlSchemaInfo
            {
                /*0x10*/ bool isDefault;
                /*0x11*/ bool isNil;
                /*0x18*/ System.Xml.Schema.XmlSchemaElement schemaElement;
                /*0x20*/ System.Xml.Schema.XmlSchemaAttribute schemaAttribute;
                /*0x28*/ System.Xml.Schema.XmlSchemaType schemaType;
                /*0x30*/ System.Xml.Schema.XmlSchemaSimpleType memberType;
                /*0x38*/ System.Xml.Schema.XmlSchemaValidity validity;
                /*0x3c*/ System.Xml.Schema.XmlSchemaContentType contentType;

                /*0x76db3a8*/ XmlSchemaInfo();
                /*0x76db420*/ XmlSchemaInfo(System.Xml.Schema.XmlSchemaValidity validity);
                /*0x76db450*/ System.Xml.Schema.XmlSchemaValidity get_Validity();
                /*0x76db458*/ void set_Validity(System.Xml.Schema.XmlSchemaValidity value);
                /*0x76db460*/ bool get_IsDefault();
                /*0x76db468*/ void set_IsDefault(bool value);
                /*0x76db474*/ bool get_IsNil();
                /*0x76db47c*/ void set_IsNil(bool value);
                /*0x76db488*/ System.Xml.Schema.XmlSchemaSimpleType get_MemberType();
                /*0x76db490*/ void set_MemberType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0x76db498*/ System.Xml.Schema.XmlSchemaType get_SchemaType();
                /*0x76db4a0*/ void set_SchemaType(System.Xml.Schema.XmlSchemaType value);
                /*0x76db4e0*/ System.Xml.Schema.XmlSchemaElement get_SchemaElement();
                /*0x76db4e8*/ void set_SchemaElement(System.Xml.Schema.XmlSchemaElement value);
                /*0x76db528*/ System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute();
                /*0x76db530*/ void set_SchemaAttribute(System.Xml.Schema.XmlSchemaAttribute value);
                /*0x76db570*/ System.Xml.Schema.XmlSchemaContentType get_ContentType();
                /*0x76db578*/ System.Xml.Schema.XmlSchemaType get_XmlType();
                /*0x76db594*/ bool get_HasDefaultValue();
                /*0x76db5c8*/ bool get_IsUnionType();
                /*0x76db3c4*/ void Clear();
            }

            class XmlSchemaNotation : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ string name;
                /*0x58*/ string publicId;
                /*0x60*/ string systemId;
                /*0x68*/ System.Xml.XmlQualifiedName qname;

                /*0x76db650*/ XmlSchemaNotation();
                /*0x76db600*/ string get_Name();
                /*0x76db608*/ void set_Name(string value);
                /*0x76db610*/ string get_Public();
                /*0x76db618*/ void set_Public(string value);
                /*0x76db620*/ string get_System();
                /*0x76db628*/ void set_System(string value);
                /*0x76db630*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0x76db638*/ void set_QualifiedName(System.Xml.XmlQualifiedName value);
                /*0x76db640*/ string get_NameAttribute();
                /*0x76db648*/ void set_NameAttribute(string value);
            }

            class XmlSchemaObject
            {
                /*0x10*/ int lineNum;
                /*0x14*/ int linePos;
                /*0x18*/ string sourceUri;
                /*0x20*/ System.Xml.Serialization.XmlSerializerNamespaces namespaces;
                /*0x28*/ System.Xml.Schema.XmlSchemaObject parent;
                /*0x30*/ bool isProcessing;

                /*0x76d377c*/ XmlSchemaObject();
                /*0x76db6c0*/ int get_LineNumber();
                /*0x76db6c8*/ void set_LineNumber(int value);
                /*0x76db6d0*/ int get_LinePosition();
                /*0x76db6d8*/ void set_LinePosition(int value);
                /*0x76db6e0*/ string get_SourceUri();
                /*0x76db6e8*/ void set_SourceUri(string value);
                /*0x76db6f0*/ System.Xml.Schema.XmlSchemaObject get_Parent();
                /*0x76db6f8*/ void set_Parent(System.Xml.Schema.XmlSchemaObject value);
                /*0x76d4058*/ System.Xml.Serialization.XmlSerializerNamespaces get_Namespaces();
                /*0x76db700*/ void set_Namespaces(System.Xml.Serialization.XmlSerializerNamespaces value);
                /*0x76db708*/ void OnAdd(System.Xml.Schema.XmlSchemaObjectCollection container, object item);
                /*0x76db70c*/ void OnRemove(System.Xml.Schema.XmlSchemaObjectCollection container, object item);
                /*0x76db710*/ void OnClear(System.Xml.Schema.XmlSchemaObjectCollection container);
                /*0x76db714*/ string get_IdAttribute();
                /*0x76db71c*/ void set_IdAttribute(string value);
                /*0x76db720*/ void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes);
                /*0x76db724*/ void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
                /*0x76db728*/ string get_NameAttribute();
                /*0x76db730*/ void set_NameAttribute(string value);
                /*0x76db734*/ bool get_IsProcessing();
                /*0x76db73c*/ void set_IsProcessing(bool value);
                /*0x76db748*/ System.Xml.Schema.XmlSchemaObject Clone();
            }

            class XmlSchemaObjectCollection : System.Collections.CollectionBase
            {
                /*0x18*/ System.Xml.Schema.XmlSchemaObject parent;

                /*0x76d3774*/ XmlSchemaObjectCollection();
                /*0x76db7c8*/ System.Xml.Schema.XmlSchemaObject get_Item(int index);
                /*0x76db8c8*/ void set_Item(int index, System.Xml.Schema.XmlSchemaObject value);
                /*0x76db990*/ System.Xml.Schema.XmlSchemaObjectEnumerator GetEnumerator();
                /*0x76d4efc*/ int Add(System.Xml.Schema.XmlSchemaObject item);
                /*0x76dba10*/ void Insert(int index, System.Xml.Schema.XmlSchemaObject item);
                /*0x76dbad8*/ void Remove(System.Xml.Schema.XmlSchemaObject item);
                /*0x76dbb90*/ void OnInsert(int index, object item);
                /*0x76dbbac*/ void OnSet(int index, object oldValue, object newValue);
                /*0x76dbc08*/ void OnClear();
                /*0x76dbc24*/ void OnRemove(int index, object item);
                /*0x76d8c88*/ System.Xml.Schema.XmlSchemaObjectCollection Clone();
                /*0x76dbc40*/ void Add(System.Xml.Schema.XmlSchemaObjectCollection collToAdd);
            }

            class XmlSchemaObjectEnumerator : System.Collections.IEnumerator
            {
                /*0x10*/ System.Collections.IEnumerator enumerator;

                /*0x76dbc6c*/ XmlSchemaObjectEnumerator(System.Collections.IEnumerator enumerator);
                /*0x76dbc9c*/ bool MoveNext();
                /*0x76dbd3c*/ System.Xml.Schema.XmlSchemaObject get_Current();
                /*0x76dbe2c*/ void System.Collections.IEnumerator.Reset();
                /*0x76dbed0*/ bool System.Collections.IEnumerator.MoveNext();
                /*0x76dbf70*/ object System.Collections.IEnumerator.get_Current();
            }

            class XmlSchemaObjectTable
            {
                /*0x10*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.XmlSchemaObject> table;
                /*0x18*/ System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries;

                /*0x76dc014*/ XmlSchemaObjectTable();
                /*0x76dc0f0*/ void Add(System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaObject value);
                /*0x76dc238*/ void Insert(System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaObject value);
                /*0x76dc3f8*/ void Replace(System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaObject value);
                /*0x76dc508*/ void Clear();
                /*0x76dc59c*/ void Remove(System.Xml.XmlQualifiedName name);
                /*0x76dc35c*/ int FindIndexByValue(System.Xml.Schema.XmlSchemaObject xso);
                /*0x76dc66c*/ int get_Count();
                /*0x76dc6bc*/ bool Contains(System.Xml.XmlQualifiedName name);
                /*0x76dc714*/ System.Xml.Schema.XmlSchemaObject get_Item(System.Xml.XmlQualifiedName name);
                /*0x76dc78c*/ System.Collections.ICollection get_Values();
                /*0x76dc868*/ System.Collections.IDictionaryEnumerator GetEnumerator();

                enum EnumeratorType
                {
                    Keys = 0,
                    Values = 1,
                    DictionaryEntry = 2,
                }

                struct XmlSchemaObjectEntry
                {
                    /*0x10*/ System.Xml.XmlQualifiedName qname;
                    /*0x18*/ System.Xml.Schema.XmlSchemaObject xso;

                    /*0x76dc208*/ XmlSchemaObjectEntry(System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaObject value);
                }

                class ValuesCollection : System.Collections.ICollection, System.Collections.IEnumerable
                {
                    /*0x10*/ System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries;
                    /*0x18*/ int size;

                    /*0x76dc82c*/ ValuesCollection(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size);
                    /*0x76dc964*/ int get_Count();
                    /*0x76dc96c*/ object get_SyncRoot();
                    /*0x76dca10*/ bool get_IsSynchronized();
                    /*0x76dcab4*/ void CopyTo(System.Array array, int arrayIndex);
                    /*0x76dcbdc*/ System.Collections.IEnumerator GetEnumerator();
                }

                class XSOEnumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries;
                    /*0x18*/ System.Xml.Schema.XmlSchemaObjectTable.EnumeratorType enumType;
                    /*0x1c*/ int currentIndex;
                    /*0x20*/ int size;
                    /*0x28*/ System.Xml.XmlQualifiedName currentKey;
                    /*0x30*/ System.Xml.Schema.XmlSchemaObject currentValue;

                    /*0x76dcc64*/ XSOEnumerator(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, System.Xml.Schema.XmlSchemaObjectTable.EnumeratorType enumType);
                    /*0x76dccb4*/ object get_Current();
                    /*0x76dce64*/ bool MoveNext();
                    /*0x76dcf34*/ void Reset();
                }

                class XSODictionaryEnumerator : System.Xml.Schema.XmlSchemaObjectTable.XSOEnumerator, System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator
                {
                    /*0x76dc914*/ XSODictionaryEnumerator(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, System.Xml.Schema.XmlSchemaObjectTable.EnumeratorType enumType);
                    /*0x76dcf64*/ System.Collections.DictionaryEntry get_Entry();
                    /*0x76dd0a8*/ object get_Key();
                    /*0x76dd1d0*/ object get_Value();
                }
            }

            class XmlSchemaParticle : System.Xml.Schema.XmlSchemaAnnotated
            {
                static /*0x0*/ System.Xml.Schema.XmlSchemaParticle Empty;
                /*0x50*/ decimal minOccurs;
                /*0x60*/ decimal maxOccurs;
                /*0x70*/ System.Xml.Schema.XmlSchemaParticle.Occurs flags;

                static /*0x76ddd18*/ XmlSchemaParticle();
                /*0x76ddca4*/ XmlSchemaParticle();
                /*0x76dd2f8*/ string get_MinOccursString();
                /*0x76dd370*/ void set_MinOccursString(string value);
                /*0x76dd4c4*/ string get_MaxOccursString();
                /*0x76dd5e8*/ void set_MaxOccursString(string value);
                /*0x76dd804*/ decimal get_MinOccurs();
                /*0x76dd810*/ void set_MinOccurs(decimal value);
                /*0x76dd93c*/ decimal get_MaxOccurs();
                /*0x76dd948*/ void set_MaxOccurs(decimal value);
                /*0x76ddaac*/ bool get_IsEmpty();
                /*0x76ddb18*/ string get_NameString();
                /*0x76ddb30*/ System.Xml.XmlQualifiedName GetQualifiedName();

                enum Occurs
                {
                    None = 0,
                    Min = 1,
                    Max = 2,
                }

                class EmptyParticle : System.Xml.Schema.XmlSchemaParticle
                {
                    /*0x76ddd90*/ EmptyParticle();
                    /*0x76ddde4*/ bool get_IsEmpty();
                }
            }

            class XmlSchemaRedefine : System.Xml.Schema.XmlSchemaExternal
            {
                /*0x68*/ System.Xml.Schema.XmlSchemaObjectCollection items;
                /*0x70*/ System.Xml.Schema.XmlSchemaObjectTable attributeGroups;
                /*0x78*/ System.Xml.Schema.XmlSchemaObjectTable types;
                /*0x80*/ System.Xml.Schema.XmlSchemaObjectTable groups;

                /*0x76dddec*/ XmlSchemaRedefine();
                /*0x76ddee0*/ System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                /*0x76ddee8*/ System.Xml.Schema.XmlSchemaObjectTable get_AttributeGroups();
                /*0x76ddef0*/ System.Xml.Schema.XmlSchemaObjectTable get_SchemaTypes();
                /*0x76ddef8*/ System.Xml.Schema.XmlSchemaObjectTable get_Groups();
                /*0x76ddf00*/ void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
            }

            class XmlSchemaSequence : System.Xml.Schema.XmlSchemaGroupBase
            {
                /*0x78*/ System.Xml.Schema.XmlSchemaObjectCollection items;

                /*0x76ddf68*/ XmlSchemaSequence();
                /*0x76ddf1c*/ System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                /*0x76ddf24*/ bool get_IsEmpty();
                /*0x76ddf60*/ void SetItems(System.Xml.Schema.XmlSchemaObjectCollection newItems);
            }

            class XmlSchemaSet
            {
                /*0x10*/ System.Xml.XmlNameTable nameTable;
                /*0x18*/ System.Xml.Schema.SchemaNames schemaNames;
                /*0x20*/ System.Collections.SortedList schemas;
                /*0x28*/ System.Xml.Schema.ValidationEventHandler internalEventHandler;
                /*0x30*/ System.Xml.Schema.ValidationEventHandler eventHandler;
                /*0x38*/ bool isCompiled;
                /*0x40*/ System.Collections.Hashtable schemaLocations;
                /*0x48*/ System.Collections.Hashtable chameleonSchemas;
                /*0x50*/ System.Collections.Hashtable targetNamespaces;
                /*0x58*/ bool compileAll;
                /*0x60*/ System.Xml.Schema.SchemaInfo cachedCompiledInfo;
                /*0x68*/ System.Xml.XmlReaderSettings readerSettings;
                /*0x70*/ System.Xml.Schema.XmlSchema schemaForSchema;
                /*0x78*/ System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings;
                /*0x80*/ System.Xml.Schema.XmlSchemaObjectTable elements;
                /*0x88*/ System.Xml.Schema.XmlSchemaObjectTable attributes;
                /*0x90*/ System.Xml.Schema.XmlSchemaObjectTable schemaTypes;
                /*0x98*/ System.Xml.Schema.XmlSchemaObjectTable substitutionGroups;
                /*0xa0*/ System.Xml.Schema.XmlSchemaObjectTable typeExtensions;
                /*0xa8*/ object internalSyncObject;

                /*0x76de044*/ XmlSchemaSet();
                /*0x76de0a0*/ XmlSchemaSet(System.Xml.XmlNameTable nameTable);
                /*0x76ddfd4*/ object get_InternalSyncObject();
                /*0x76de398*/ void add_ValidationEventHandler(System.Xml.Schema.ValidationEventHandler value);
                /*0x76de4a8*/ void remove_ValidationEventHandler(System.Xml.Schema.ValidationEventHandler value);
                /*0x76de560*/ bool get_IsCompiled();
                /*0x76de568*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x76de584*/ System.Xml.Schema.XmlSchemaCompilationSettings get_CompilationSettings();
                /*0x76de58c*/ void set_CompilationSettings(System.Xml.Schema.XmlSchemaCompilationSettings value);
                /*0x76de594*/ int get_Count();
                /*0x76de5b8*/ System.Xml.Schema.XmlSchemaObjectTable get_GlobalElements();
                /*0x76de624*/ System.Xml.Schema.XmlSchemaObjectTable get_GlobalAttributes();
                /*0x76de690*/ System.Xml.Schema.XmlSchemaObjectTable get_GlobalTypes();
                /*0x76de6fc*/ System.Xml.Schema.XmlSchemaObjectTable get_SubstitutionGroups();
                /*0x76de768*/ System.Collections.Hashtable get_SchemaLocations();
                /*0x76de770*/ System.Xml.Schema.XmlSchemaObjectTable get_TypeExtensions();
                /*0x76de7dc*/ void Add(System.Xml.Schema.XmlSchemaSet schemas);
                /*0x76e0ed4*/ System.Xml.Schema.XmlSchema Add(System.Xml.Schema.XmlSchema schema);
                /*0x76e1058*/ bool RemoveRecursive(System.Xml.Schema.XmlSchema schemaToRemove);
                /*0x76e1eb8*/ bool Contains(string targetNamespace);
                /*0x76e1f00*/ void Compile();
                /*0x76e2420*/ System.Xml.Schema.XmlSchema Reprocess(System.Xml.Schema.XmlSchema schema);
                /*0x76e3ec0*/ void CopyTo(System.Xml.Schema.XmlSchema[] schemas, int index);
                /*0x76e4024*/ System.Collections.ICollection Schemas();
                /*0x76e3c30*/ System.Collections.ICollection Schemas(string targetNamespace);
                /*0x76e0e7c*/ System.Xml.Schema.XmlSchema Add(string targetNamespace, System.Xml.Schema.XmlSchema schema);
                /*0x76e43dc*/ void Add(string targetNamespace, System.Xml.XmlReader reader, System.Collections.Hashtable validatedNamespaces);
                /*0x76e0c08*/ System.Xml.Schema.XmlSchema FindSchemaByNSAndUrl(System.Uri schemaUri, string ns, System.Collections.DictionaryEntry[] locationsTable);
                /*0x76e4048*/ void AddSchemaToSet(System.Xml.Schema.XmlSchema schema);
                /*0x76e4b80*/ void ProcessNewSubstitutionGroups(System.Xml.Schema.XmlSchemaObjectTable substitutionGroupsTable, bool resolve);
                /*0x76e5058*/ void ResolveSubstitutionGroup(System.Xml.Schema.XmlSchemaSubstitutionGroup substitutionGroup, System.Xml.Schema.XmlSchemaObjectTable substTable);
                /*0x76e1b5c*/ System.Xml.Schema.XmlSchema Remove(System.Xml.Schema.XmlSchema schema, bool forceCompile);
                /*0x76e23c4*/ void ClearTables();
                /*0x76e3d94*/ bool PreprocessSchema(ref System.Xml.Schema.XmlSchema schema, string targetNamespace);
                /*0x76e4a08*/ System.Xml.Schema.XmlSchema ParseSchema(string targetNamespace, System.Xml.XmlReader reader);
                /*0x76df12c*/ void CopyFromCompiledSet(System.Xml.Schema.XmlSchemaSet otherSet);
                /*0x76e58d0*/ System.Xml.Schema.SchemaInfo get_CompiledInfo();
                /*0x76e58d8*/ System.Xml.XmlReaderSettings get_ReaderSettings();
                /*0x76e58e0*/ System.Xml.XmlResolver GetResolver();
                /*0x76e58fc*/ System.Xml.Schema.ValidationEventHandler GetEventHandler();
                /*0x76e5708*/ System.Xml.Schema.SchemaNames GetSchemaNames(System.Xml.XmlNameTable nt);
                /*0x76e4764*/ bool IsSchemaLoaded(System.Uri schemaUri, string targetNamespace, ref System.Xml.Schema.XmlSchema schema);
                /*0x76e5904*/ bool GetSchemaByUri(System.Uri schemaUri, ref System.Xml.Schema.XmlSchema schema);
                /*0x76e1a8c*/ string GetTargetNamespace(System.Xml.Schema.XmlSchema schema);
                /*0x76e5a68*/ System.Collections.SortedList get_SortedSchemas();
                /*0x76e3628*/ void RemoveSchemaFromCaches(System.Xml.Schema.XmlSchema schema);
                /*0x76e2b98*/ void RemoveSchemaFromGlobalTables(System.Xml.Schema.XmlSchema schema);
                /*0x76e5434*/ bool AddToTable(System.Xml.Schema.XmlSchemaObjectTable table, System.Xml.XmlQualifiedName qname, System.Xml.Schema.XmlSchemaObject item);
                /*0x76e57ac*/ void VerifyTables();
                /*0x76e5a70*/ void InternalValidationCallback(object sender, System.Xml.Schema.ValidationEventArgs e);
                /*0x76e1abc*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity);
            }

            class XmlSchemaSimpleContent : System.Xml.Schema.XmlSchemaContentModel
            {
                /*0x50*/ System.Xml.Schema.XmlSchemaContent content;

                /*0x76e5ac4*/ XmlSchemaSimpleContent();
                /*0x76e5ab4*/ System.Xml.Schema.XmlSchemaContent get_Content();
                /*0x76e5abc*/ void set_Content(System.Xml.Schema.XmlSchemaContent value);
            }

            class XmlSchemaSimpleContentExtension : System.Xml.Schema.XmlSchemaContent
            {
                /*0x50*/ System.Xml.Schema.XmlSchemaObjectCollection attributes;
                /*0x58*/ System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;
                /*0x60*/ System.Xml.XmlQualifiedName baseTypeName;

                /*0x76e5b94*/ XmlSchemaSimpleContentExtension();
                /*0x76e5acc*/ System.Xml.XmlQualifiedName get_BaseTypeName();
                /*0x76e5ad4*/ void set_BaseTypeName(System.Xml.XmlQualifiedName value);
                /*0x76e5b74*/ System.Xml.Schema.XmlSchemaObjectCollection get_Attributes();
                /*0x76e5b7c*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0x76e5b84*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x76e5b8c*/ void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes);
            }

            class XmlSchemaSimpleContentRestriction : System.Xml.Schema.XmlSchemaContent
            {
                /*0x50*/ System.Xml.XmlQualifiedName baseTypeName;
                /*0x58*/ System.Xml.Schema.XmlSchemaSimpleType baseType;
                /*0x60*/ System.Xml.Schema.XmlSchemaObjectCollection facets;
                /*0x68*/ System.Xml.Schema.XmlSchemaObjectCollection attributes;
                /*0x70*/ System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;

                /*0x76e5d24*/ XmlSchemaSimpleContentRestriction();
                /*0x76e5c44*/ System.Xml.XmlQualifiedName get_BaseTypeName();
                /*0x76e5c4c*/ void set_BaseTypeName(System.Xml.XmlQualifiedName value);
                /*0x76e5cec*/ System.Xml.Schema.XmlSchemaSimpleType get_BaseType();
                /*0x76e5cf4*/ void set_BaseType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0x76e5cfc*/ System.Xml.Schema.XmlSchemaObjectCollection get_Facets();
                /*0x76e5d04*/ System.Xml.Schema.XmlSchemaObjectCollection get_Attributes();
                /*0x76e5d0c*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0x76e5d14*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x76e5d1c*/ void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes);
            }

            class XmlSchemaSimpleType : System.Xml.Schema.XmlSchemaType
            {
                /*0x98*/ System.Xml.Schema.XmlSchemaSimpleTypeContent content;

                /*0x76e5df0*/ XmlSchemaSimpleType();
                /*0x76e5e74*/ System.Xml.Schema.XmlSchemaSimpleTypeContent get_Content();
                /*0x76e5e7c*/ void set_Content(System.Xml.Schema.XmlSchemaSimpleTypeContent value);
                /*0x76e5e84*/ System.Xml.Schema.XmlSchemaObject Clone();
            }

            class XmlSchemaSimpleTypeContent : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x76e5f90*/ XmlSchemaSimpleTypeContent();
            }

            class XmlSchemaSimpleTypeList : System.Xml.Schema.XmlSchemaSimpleTypeContent
            {
                /*0x50*/ System.Xml.XmlQualifiedName itemTypeName;
                /*0x58*/ System.Xml.Schema.XmlSchemaSimpleType itemType;
                /*0x60*/ System.Xml.Schema.XmlSchemaSimpleType baseItemType;

                /*0x76e6110*/ XmlSchemaSimpleTypeList();
                /*0x76e5f98*/ System.Xml.XmlQualifiedName get_ItemTypeName();
                /*0x76e5fa0*/ void set_ItemTypeName(System.Xml.XmlQualifiedName value);
                /*0x76e6040*/ System.Xml.Schema.XmlSchemaSimpleType get_ItemType();
                /*0x76e6048*/ void set_ItemType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0x76e6050*/ System.Xml.Schema.XmlSchemaSimpleType get_BaseItemType();
                /*0x76e6058*/ void set_BaseItemType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0x76e6060*/ System.Xml.Schema.XmlSchemaObject Clone();
            }

            class XmlSchemaSimpleTypeRestriction : System.Xml.Schema.XmlSchemaSimpleTypeContent
            {
                /*0x50*/ System.Xml.XmlQualifiedName baseTypeName;
                /*0x58*/ System.Xml.Schema.XmlSchemaSimpleType baseType;
                /*0x60*/ System.Xml.Schema.XmlSchemaObjectCollection facets;

                /*0x76e62f0*/ XmlSchemaSimpleTypeRestriction();
                /*0x76e6180*/ System.Xml.XmlQualifiedName get_BaseTypeName();
                /*0x76e6188*/ void set_BaseTypeName(System.Xml.XmlQualifiedName value);
                /*0x76e6228*/ System.Xml.Schema.XmlSchemaSimpleType get_BaseType();
                /*0x76e6230*/ void set_BaseType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0x76e6238*/ System.Xml.Schema.XmlSchemaObjectCollection get_Facets();
                /*0x76e6240*/ System.Xml.Schema.XmlSchemaObject Clone();
            }

            class XmlSchemaSimpleTypeUnion : System.Xml.Schema.XmlSchemaSimpleTypeContent
            {
                /*0x50*/ System.Xml.Schema.XmlSchemaObjectCollection baseTypes;
                /*0x58*/ System.Xml.XmlQualifiedName[] memberTypes;
                /*0x60*/ System.Xml.Schema.XmlSchemaSimpleType[] baseMemberTypes;

                /*0x76e6540*/ XmlSchemaSimpleTypeUnion();
                /*0x76e6398*/ System.Xml.Schema.XmlSchemaObjectCollection get_BaseTypes();
                /*0x76e63a0*/ System.Xml.XmlQualifiedName[] get_MemberTypes();
                /*0x76e63a8*/ void set_MemberTypes(System.Xml.XmlQualifiedName[] value);
                /*0x76e63b0*/ System.Xml.Schema.XmlSchemaSimpleType[] get_BaseMemberTypes();
                /*0x76e63b8*/ void SetBaseMemberTypes(System.Xml.Schema.XmlSchemaSimpleType[] baseMemberTypes);
                /*0x76e63c0*/ System.Xml.Schema.XmlSchemaObject Clone();
            }

            class XmlSchemaSubstitutionGroup : System.Xml.Schema.XmlSchemaObject
            {
                /*0x38*/ System.Collections.ArrayList membersList;
                /*0x40*/ System.Xml.XmlQualifiedName examplar;

                /*0x76e65c4*/ XmlSchemaSubstitutionGroup();
                /*0x76e65ac*/ System.Collections.ArrayList get_Members();
                /*0x76e65b4*/ System.Xml.XmlQualifiedName get_Examplar();
                /*0x76e65bc*/ void set_Examplar(System.Xml.XmlQualifiedName value);
            }

            class XmlSchemaSubstitutionGroupV1Compat : System.Xml.Schema.XmlSchemaSubstitutionGroup
            {
                /*0x48*/ System.Xml.Schema.XmlSchemaChoice choice;

                /*0x76e667c*/ XmlSchemaSubstitutionGroupV1Compat();
                /*0x76e6674*/ System.Xml.Schema.XmlSchemaChoice get_Choice();
            }

            class XmlSchemaType : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ string name;
                /*0x58*/ System.Xml.Schema.XmlSchemaDerivationMethod final;
                /*0x5c*/ System.Xml.Schema.XmlSchemaDerivationMethod derivedBy;
                /*0x60*/ System.Xml.Schema.XmlSchemaType baseSchemaType;
                /*0x68*/ System.Xml.Schema.XmlSchemaDatatype datatype;
                /*0x70*/ System.Xml.Schema.XmlSchemaDerivationMethod finalResolved;
                /*0x78*/ System.Xml.Schema.SchemaElementDecl elementDecl;
                /*0x80*/ System.Xml.XmlQualifiedName qname;
                /*0x88*/ System.Xml.Schema.XmlSchemaType redefined;
                /*0x90*/ System.Xml.Schema.XmlSchemaContentType contentType;

                static /*0x76e66e4*/ System.Xml.Schema.XmlSchemaSimpleType GetBuiltInSimpleType(System.Xml.XmlQualifiedName qualifiedName);
                static /*0x76e67bc*/ System.Xml.Schema.XmlSchemaSimpleType GetBuiltInSimpleType(System.Xml.Schema.XmlTypeCode typeCode);
                static /*0x76e6814*/ System.Xml.Schema.XmlSchemaComplexType GetBuiltInComplexType(System.Xml.XmlQualifiedName qualifiedName);
                static /*0x76e6c84*/ bool IsDerivedFrom(System.Xml.Schema.XmlSchemaType derivedType, System.Xml.Schema.XmlSchemaType baseType, System.Xml.Schema.XmlSchemaDerivationMethod except);
                static /*0x76e6e7c*/ bool IsDerivedFromDatatype(System.Xml.Schema.XmlSchemaDatatype derivedDataType, System.Xml.Schema.XmlSchemaDatatype baseDataType, System.Xml.Schema.XmlSchemaDerivationMethod except);
                /*0x76e5df4*/ XmlSchemaType();
                /*0x76e6a5c*/ string get_Name();
                /*0x76e6a64*/ void set_Name(string value);
                /*0x76e6a6c*/ System.Xml.Schema.XmlSchemaDerivationMethod get_Final();
                /*0x76e6a74*/ void set_Final(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x76e58b8*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0x76e6a7c*/ System.Xml.Schema.XmlSchemaDerivationMethod get_FinalResolved();
                /*0x76e6a84*/ System.Xml.Schema.XmlSchemaType get_BaseXmlSchemaType();
                /*0x76e6a8c*/ System.Xml.Schema.XmlSchemaDerivationMethod get_DerivedBy();
                /*0x76e6a94*/ System.Xml.Schema.XmlSchemaDatatype get_Datatype();
                /*0x76e6a9c*/ bool get_IsMixed();
                /*0x76e6aa4*/ void set_IsMixed(bool value);
                /*0x76e6aa8*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x76e6b5c*/ System.Xml.Schema.XmlValueConverter get_ValueConverter();
                /*0x76e6bd4*/ System.Xml.Schema.XmlSchemaContentType get_SchemaContentType();
                /*0x76e6bdc*/ void SetQualifiedName(System.Xml.XmlQualifiedName value);
                /*0x76e6c08*/ void SetFinalResolved(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x76e6c10*/ void SetBaseSchemaType(System.Xml.Schema.XmlSchemaType value);
                /*0x76e6c18*/ void SetDerivedBy(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x76e6c20*/ void SetDatatype(System.Xml.Schema.XmlSchemaDatatype value);
                /*0x76e6c28*/ System.Xml.Schema.SchemaElementDecl get_ElementDecl();
                /*0x76e6c40*/ void set_ElementDecl(System.Xml.Schema.SchemaElementDecl value);
                /*0x76e6c6c*/ System.Xml.Schema.XmlSchemaType get_Redefined();
                /*0x76e6c74*/ void set_Redefined(System.Xml.Schema.XmlSchemaType value);
                /*0x76e6c7c*/ void SetContentType(System.Xml.Schema.XmlSchemaContentType value);
                /*0x76e6f50*/ string get_NameAttribute();
                /*0x76e6f58*/ void set_NameAttribute(string value);
            }

            enum XmlSchemaUse
            {
                None = 0,
                Optional = 1,
                Prohibited = 2,
                Required = 3,
            }

            class XmlSchemaValidationException : System.Xml.Schema.XmlSchemaException
            {
                /*0x76e6f60*/ XmlSchemaValidationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x76e6f70*/ XmlSchemaValidationException();
                /*0x76e6f7c*/ XmlSchemaValidationException(string res, string arg, string sourceUri, int lineNumber, int linePosition);
                /*0x76e704c*/ XmlSchemaValidationException(string res, string[] args, string sourceUri, int lineNumber, int linePosition);
                /*0x76e707c*/ XmlSchemaValidationException(string res, string[] args, System.Exception innerException, string sourceUri, int lineNumber, int linePosition);
                /*0x76e6f68*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            class XmlValueGetter : System.MulticastDelegate
            {
                /*0x76e709c*/ XmlValueGetter(object object, nint method);
                /*0x76e7138*/ object Invoke();
            }

            enum XmlSchemaValidationFlags
            {
                None = 0,
                ProcessInlineSchema = 1,
                ProcessSchemaLocation = 2,
                ReportValidationWarnings = 4,
                ProcessIdentityConstraints = 8,
                AllowXmlAttributes = 16,
            }

            enum ValidatorState
            {
                None = 0,
                Start = 1,
                TopLevelAttribute = 2,
                TopLevelTextOrWS = 3,
                Element = 4,
                Attribute = 5,
                EndOfAttributes = 6,
                Text = 7,
                Whitespace = 8,
                EndElement = 9,
                SkipToEndElement = 10,
                Finish = 11,
            }

            class IdRefNode
            {
                /*0x10*/ string Id;
                /*0x18*/ int LineNo;
                /*0x1c*/ int LinePos;
                /*0x20*/ System.Xml.Schema.IdRefNode Next;

                /*0x76e714c*/ IdRefNode(System.Xml.Schema.IdRefNode next, string id, int lineNo, int linePos);
            }

            class XmlSchemaValidator
            {
                static /*0x0*/ System.Xml.Schema.XmlSchemaDatatype dtQName;
                static /*0x8*/ System.Xml.Schema.XmlSchemaDatatype dtCDATA;
                static /*0x10*/ System.Xml.Schema.XmlSchemaDatatype dtStringArray;
                static /*0x18*/ System.Xml.Schema.XmlSchemaParticle[] EmptyParticleArray;
                static /*0x20*/ System.Xml.Schema.XmlSchemaAttribute[] EmptyAttributeArray;
                static /*0x28*/ bool[,] ValidStates;
                static /*0x30*/ string[] MethodNames;
                /*0x10*/ System.Xml.Schema.XmlSchemaSet schemaSet;
                /*0x18*/ System.Xml.Schema.XmlSchemaValidationFlags validationFlags;
                /*0x1c*/ int startIDConstraint;
                /*0x20*/ bool isRoot;
                /*0x21*/ bool rootHasSchema;
                /*0x22*/ bool attrValid;
                /*0x23*/ bool checkEntity;
                /*0x28*/ System.Xml.Schema.SchemaInfo compiledSchemaInfo;
                /*0x30*/ System.Xml.IDtdInfo dtdSchemaInfo;
                /*0x38*/ System.Collections.Hashtable validatedNamespaces;
                /*0x40*/ System.Xml.HWStack validationStack;
                /*0x48*/ System.Xml.Schema.ValidationState context;
                /*0x50*/ System.Xml.Schema.ValidatorState currentState;
                /*0x58*/ System.Collections.Hashtable attPresence;
                /*0x60*/ System.Xml.Schema.SchemaAttDef wildID;
                /*0x68*/ System.Collections.Hashtable IDs;
                /*0x70*/ System.Xml.Schema.IdRefNode idRefListHead;
                /*0x78*/ System.Xml.XmlQualifiedName contextQName;
                /*0x80*/ string NsXs;
                /*0x88*/ string NsXsi;
                /*0x90*/ string NsXmlNs;
                /*0x98*/ string NsXml;
                /*0xa0*/ System.Xml.Schema.XmlSchemaObject partialValidationType;
                /*0xa8*/ System.Text.StringBuilder textValue;
                /*0xb0*/ System.Xml.Schema.ValidationEventHandler eventHandler;
                /*0xb8*/ object validationEventSender;
                /*0xc0*/ System.Xml.XmlNameTable nameTable;
                /*0xc8*/ System.Xml.IXmlLineInfo positionInfo;
                /*0xd0*/ System.Xml.IXmlLineInfo dummyPositionInfo;
                /*0xd8*/ System.Xml.XmlResolver xmlResolver;
                /*0xe0*/ System.Uri sourceUri;
                /*0xe8*/ string sourceUriString;
                /*0xf0*/ System.Xml.IXmlNamespaceResolver nsResolver;
                /*0xf8*/ System.Xml.Schema.XmlSchemaContentProcessing processContents;
                /*0x100*/ string xsiTypeString;
                /*0x108*/ string xsiNilString;
                /*0x110*/ string xsiSchemaLocationString;
                /*0x118*/ string xsiNoNamespaceSchemaLocationString;
                /*0x120*/ System.Xml.XmlCharType xmlCharType;

                static /*0x76f1974*/ XmlSchemaValidator();
                static /*0x76ef720*/ void ElementValidationError(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, System.Xml.Schema.ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, System.Xml.Schema.XmlSchemaSet schemaSet);
                static /*0x76ede20*/ void CompleteValidationError(System.Xml.Schema.ValidationState context, System.Xml.Schema.ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, System.Xml.Schema.XmlSchemaSet schemaSet);
                static /*0x76ebcb4*/ string PrintExpectedElements(System.Collections.ArrayList expected, bool getParticles);
                static /*0x76f15b8*/ string PrintNames(System.Collections.ArrayList expected);
                static /*0x76f1100*/ void PrintNamesWithNS(System.Collections.ArrayList expected, System.Text.StringBuilder builder);
                static /*0x76f1734*/ void EnumerateAny(System.Text.StringBuilder builder, string namespaces);
                static /*0x76ebab0*/ string QNameString(string localName, string ns);
                static /*0x76ef4c8*/ string BuildElementName(System.Xml.XmlQualifiedName qname);
                static /*0x76ebb64*/ string BuildElementName(string localName, string ns);
                static /*0x76f104c*/ void SendValidationEvent(System.Xml.Schema.ValidationEventHandler eventHandler, object sender, System.Xml.Schema.XmlSchemaValidationException e, System.Xml.Schema.XmlSeverityType severity);
                /*0x76e71a4*/ XmlSchemaValidator(System.Xml.XmlNameTable nameTable, System.Xml.Schema.XmlSchemaSet schemas, System.Xml.IXmlNamespaceResolver namespaceResolver, System.Xml.Schema.XmlSchemaValidationFlags validationFlags);
                /*0x76e73d4*/ void Init();
                /*0x76e78e8*/ void Reset();
                /*0x76e7a64*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x76e7a6c*/ void set_LineInfoProvider(System.Xml.IXmlLineInfo value);
                /*0x76e7a7c*/ void set_SourceUri(System.Uri value);
                /*0x76e7ac8*/ void set_ValidationEventSender(object value);
                /*0x76e7ad0*/ void add_ValidationEventHandler(System.Xml.Schema.ValidationEventHandler value);
                /*0x76e7b60*/ void remove_ValidationEventHandler(System.Xml.Schema.ValidationEventHandler value);
                /*0x76e7bf0*/ void AddSchema(System.Xml.Schema.XmlSchema schema);
                /*0x76e8344*/ void Initialize();
                /*0x76e8484*/ void Initialize(System.Xml.Schema.XmlSchemaObject partialValidationType);
                /*0x76e8724*/ void ValidateElement(string localName, string namespaceUri, System.Xml.Schema.XmlSchemaInfo schemaInfo, string xsiType, string xsiNil, string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation);
                /*0x76e9fd4*/ object ValidateAttribute(string localName, string namespaceUri, System.Xml.Schema.XmlValueGetter attributeValue, System.Xml.Schema.XmlSchemaInfo schemaInfo);
                /*0x76ea030*/ object ValidateAttribute(string lName, string ns, System.Xml.Schema.XmlValueGetter attributeValueGetter, string attributeStringValue, System.Xml.Schema.XmlSchemaInfo schemaInfo);
                /*0x76eb440*/ void ValidateEndOfAttributes(System.Xml.Schema.XmlSchemaInfo schemaInfo);
                /*0x76eb70c*/ void ValidateText(System.Xml.Schema.XmlValueGetter elementValue);
                /*0x76eb768*/ void ValidateText(string elementStringValue, System.Xml.Schema.XmlValueGetter elementValueGetter);
                /*0x76ec094*/ void ValidateWhitespace(System.Xml.Schema.XmlValueGetter elementValue);
                /*0x76ec0f0*/ void ValidateWhitespace(string elementStringValue, System.Xml.Schema.XmlValueGetter elementValueGetter);
                /*0x76ec2b0*/ object ValidateEndElement(System.Xml.Schema.XmlSchemaInfo schemaInfo);
                /*0x76ec7a4*/ void SkipToEndElement(System.Xml.Schema.XmlSchemaInfo schemaInfo);
                /*0x76ecadc*/ void EndValidation();
                /*0x76eccd0*/ void GetUnspecifiedDefaultAttributes(System.Collections.ArrayList defaultAttributes, bool createNodeData);
                /*0x76ed69c*/ System.Xml.Schema.XmlSchemaSet get_SchemaSet();
                /*0x76ed6a4*/ System.Xml.Schema.XmlSchemaValidationFlags get_ValidationFlags();
                /*0x76ed6ac*/ System.Xml.Schema.XmlSchemaContentType get_CurrentContentType();
                /*0x76ed6e0*/ void SetDtdSchemaInfo(System.Xml.IDtdInfo dtdSchemaInfo);
                /*0x76ed704*/ bool get_StrictlyAssessed();
                /*0x76ed748*/ bool get_HasSchema();
                /*0x76ed790*/ string GetConcatenatedValue();
                /*0x76ec2b8*/ object InternalValidateEndElement(System.Xml.Schema.XmlSchemaInfo schemaInfo, object typedValue);
                /*0x76e935c*/ void ProcessSchemaLocations(string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation);
                /*0x76e8ce8*/ object ValidateElementContext(System.Xml.XmlQualifiedName elementName, ref bool invalidElementInContext);
                /*0x76ef2dc*/ System.Xml.Schema.XmlSchemaElement GetSubstitutionGroupHead(System.Xml.XmlQualifiedName member);
                /*0x76ed7b0*/ object ValidateAtomicValue(string stringValue, ref System.Xml.Schema.XmlSchemaSimpleType memberType);
                /*0x76eda34*/ object ValidateAtomicValue(object parsedValue, ref System.Xml.Schema.XmlSchemaSimpleType memberType);
                /*0x76f0030*/ string GetTypeName(System.Xml.Schema.SchemaDeclBase decl);
                /*0x76ebb24*/ void SaveTextValue(object value);
                /*0x76e7794*/ void Push(System.Xml.XmlQualifiedName elementName);
                /*0x76ec9ac*/ void Pop();
                /*0x76e9118*/ System.Xml.Schema.SchemaElementDecl FastGetElementDecl(System.Xml.XmlQualifiedName elementName, object particle);
                /*0x76e9678*/ System.Xml.Schema.SchemaElementDecl CheckXsiTypeAndNil(System.Xml.Schema.SchemaElementDecl elementDecl, string xsiType, string xsiNil, ref bool declFound);
                /*0x76e9c5c*/ void ThrowDeclNotFoundWarningOrError(bool declFound);
                /*0x76e9d9c*/ void CheckElementProperties();
                /*0x76e9e50*/ void ValidateStartElementIdentityConstraints();
                /*0x76eab6c*/ System.Xml.Schema.SchemaAttDef CheckIsXmlAttribute(System.Xml.XmlQualifiedName attQName);
                /*0x76f0870*/ void AddXmlNamespaceSchema();
                /*0x76edd44*/ object CheckMixedValueConstraint(string elementValue);
                /*0x76eedd8*/ void LoadSchema(string uri, string url);
                /*0x76e7990*/ void RecompileSchemaSet();
                /*0x76f0ac0*/ void ProcessTokenizedType(System.Xml.XmlTokenizedType ttype, string name, bool attrValue);
                /*0x76eadc0*/ object CheckAttributeValue(object value, System.Xml.Schema.SchemaAttDef attdef);
                /*0x76efe14*/ object CheckElementValue(string stringValue);
                /*0x76eaffc*/ void CheckTokenizedTypes(System.Xml.Schema.XmlSchemaDatatype dtype, object typedValue, bool attrValue);
                /*0x76f0d8c*/ object FindId(string name);
                /*0x76ecbc8*/ void CheckForwardRefs();
                /*0x76eb17c*/ bool get_HasIdentityConstraints();
                /*0x76f00b0*/ bool get_ProcessIdentityConstraints();
                /*0x76f1038*/ bool get_ReportValidationWarnings();
                /*0x76e7a54*/ bool get_ProcessSchemaHints();
                /*0x76e8a84*/ void CheckStateTransition(System.Xml.Schema.ValidatorState toState, string methodName);
                /*0x76e8c9c*/ void ClearPSVI();
                /*0x76eb508*/ void CheckRequiredAttributes(System.Xml.Schema.SchemaElementDecl currentElementDecl);
                /*0x76e9eac*/ System.Xml.Schema.XmlSchemaElement GetSchemaElement();
                /*0x76ed2d0*/ string GetDefaultAttributePrefix(string attributeNS);
                /*0x76f00bc*/ void AddIdentityConstraints();
                /*0x76f04c0*/ void ElementIdentityConstraints();
                /*0x76eb19c*/ void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x76ee244*/ void EndElementIdentityConstraints(object typedValue, string stringValue, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x76f0da8*/ void ProcessEntity(string name);
                /*0x76f0098*/ void SendValidationEvent(string code);
                /*0x76eac34*/ void SendValidationEvent(string code, string[] args);
                /*0x76ea9f4*/ void SendValidationEvent(string code, string arg);
                /*0x76ef52c*/ void SendValidationEvent(string code, string arg1, string arg2);
                /*0x76f08f8*/ void SendValidationEvent(string code, string[] args, System.Exception innerException, System.Xml.Schema.XmlSeverityType severity);
                /*0x76e81ac*/ void SendValidationEvent(string code, string[] args, System.Exception innerException);
                /*0x76f1044*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaValidationException e);
                /*0x76ef230*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e);
                /*0x76e8000*/ void SendValidationEvent(string code, string msg, System.Xml.Schema.XmlSeverityType severity);
                /*0x76f0f1c*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaValidationException e, System.Xml.Schema.XmlSeverityType severity);
            }

            enum XmlSchemaValidity
            {
                NotKnown = 0,
                Valid = 1,
                Invalid = 2,
            }

            enum XmlSeverityType
            {
                Error = 0,
                Warning = 1,
            }

            enum XmlTypeCode
            {
                None = 0,
                Item = 1,
                Node = 2,
                Document = 3,
                Element = 4,
                Attribute = 5,
                Namespace = 6,
                ProcessingInstruction = 7,
                Comment = 8,
                Text = 9,
                AnyAtomicType = 10,
                UntypedAtomic = 11,
                String = 12,
                Boolean = 13,
                Decimal = 14,
                Float = 15,
                Double = 16,
                Duration = 17,
                DateTime = 18,
                Time = 19,
                Date = 20,
                GYearMonth = 21,
                GYear = 22,
                GMonthDay = 23,
                GDay = 24,
                GMonth = 25,
                HexBinary = 26,
                Base64Binary = 27,
                AnyUri = 28,
                QName = 29,
                Notation = 30,
                NormalizedString = 31,
                Token = 32,
                Language = 33,
                NmToken = 34,
                Name = 35,
                NCName = 36,
                Id = 37,
                Idref = 38,
                Entity = 39,
                Integer = 40,
                NonPositiveInteger = 41,
                NegativeInteger = 42,
                Long = 43,
                Int = 44,
                Short = 45,
                Byte = 46,
                NonNegativeInteger = 47,
                UnsignedLong = 48,
                UnsignedInt = 49,
                UnsignedShort = 50,
                UnsignedByte = 51,
                PositiveInteger = 52,
                YearMonthDuration = 53,
                DayTimeDuration = 54,
            }

            class XmlValueConverter
            {
                /*0x76f1dd4*/ XmlValueConverter();
                bool ToBoolean(long value);
                /*0x38140fc*/ bool ToBoolean(int value);
                bool ToBoolean(double value);
                bool ToBoolean(System.DateTime value);
                /*0x38141c4*/ bool ToBoolean(string value);
                /*0x38141c4*/ bool ToBoolean(object value);
                int ToInt32(bool value);
                int ToInt32(long value);
                int ToInt32(double value);
                int ToInt32(System.DateTime value);
                /*0x381467c*/ int ToInt32(string value);
                /*0x381467c*/ int ToInt32(object value);
                long ToInt64(bool value);
                long ToInt64(int value);
                long ToInt64(double value);
                long ToInt64(System.DateTime value);
                long ToInt64(string value);
                long ToInt64(object value);
                decimal ToDecimal(string value);
                decimal ToDecimal(object value);
                double ToDouble(bool value);
                double ToDouble(int value);
                double ToDouble(long value);
                double ToDouble(System.DateTime value);
                double ToDouble(string value);
                double ToDouble(object value);
                float ToSingle(double value);
                float ToSingle(string value);
                float ToSingle(object value);
                System.DateTime ToDateTime(bool value);
                System.DateTime ToDateTime(int value);
                System.DateTime ToDateTime(long value);
                System.DateTime ToDateTime(double value);
                System.DateTime ToDateTime(System.DateTimeOffset value);
                System.DateTime ToDateTime(string value);
                System.DateTime ToDateTime(object value);
                System.DateTimeOffset ToDateTimeOffset(System.DateTime value);
                System.DateTimeOffset ToDateTimeOffset(string value);
                System.DateTimeOffset ToDateTimeOffset(object value);
                string ToString(bool value);
                /*0x3814964*/ string ToString(int value);
                string ToString(long value);
                string ToString(decimal value);
                string ToString(float value);
                string ToString(double value);
                string ToString(System.DateTime value);
                string ToString(System.DateTimeOffset value);
                /*0x3814a3c*/ string ToString(object value);
                /*0x3814b90*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                object ChangeType(bool value, System.Type destinationType);
                object ChangeType(int value, System.Type destinationType);
                object ChangeType(long value, System.Type destinationType);
                object ChangeType(decimal value, System.Type destinationType);
                object ChangeType(double value, System.Type destinationType);
                object ChangeType(System.DateTime value, System.Type destinationType);
                /*0x3814c14*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x3814b90*/ object ChangeType(object value, System.Type destinationType);
                /*0x3814c14*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlBaseConverter : System.Xml.Schema.XmlValueConverter
            {
                static /*0x0*/ System.Type ICollectionType;
                static /*0x8*/ System.Type IEnumerableType;
                static /*0x10*/ System.Type IListType;
                static /*0x18*/ System.Type ObjectArrayType;
                static /*0x20*/ System.Type StringArrayType;
                static /*0x28*/ System.Type XmlAtomicValueArrayType;
                static /*0x30*/ System.Type DecimalType;
                static /*0x38*/ System.Type Int32Type;
                static /*0x40*/ System.Type Int64Type;
                static /*0x48*/ System.Type StringType;
                static /*0x50*/ System.Type XmlAtomicValueType;
                static /*0x58*/ System.Type ObjectType;
                static /*0x60*/ System.Type ByteType;
                static /*0x68*/ System.Type Int16Type;
                static /*0x70*/ System.Type SByteType;
                static /*0x78*/ System.Type UInt16Type;
                static /*0x80*/ System.Type UInt32Type;
                static /*0x88*/ System.Type UInt64Type;
                static /*0x90*/ System.Type XPathItemType;
                static /*0x98*/ System.Type DoubleType;
                static /*0xa0*/ System.Type SingleType;
                static /*0xa8*/ System.Type DateTimeType;
                static /*0xb0*/ System.Type DateTimeOffsetType;
                static /*0xb8*/ System.Type BooleanType;
                static /*0xc0*/ System.Type ByteArrayType;
                static /*0xc8*/ System.Type XmlQualifiedNameType;
                static /*0xd0*/ System.Type UriType;
                static /*0xd8*/ System.Type TimeSpanType;
                static /*0xe0*/ System.Type XPathNavigatorType;
                /*0x10*/ System.Xml.Schema.XmlSchemaType schemaType;
                /*0x18*/ System.Xml.Schema.XmlTypeCode typeCode;
                /*0x20*/ System.Type clrTypeDefault;

                static /*0x76f762c*/ XmlBaseConverter();
                static /*0x76f4c90*/ bool IsDerivedFrom(System.Type derivedType, System.Type baseType);
                static /*0x76f4b68*/ string QNameToString(System.Xml.XmlQualifiedName name);
                static /*0x76f5008*/ byte[] StringToBase64Binary(string value);
                static /*0x76f5098*/ System.DateTime StringToDate(string value);
                static /*0x76f5114*/ System.DateTime StringToDateTime(string value);
                static /*0x76f5190*/ System.TimeSpan StringToDayTimeDuration(string value);
                static /*0x76f51f0*/ System.TimeSpan StringToDuration(string value);
                static /*0x76f5250*/ System.DateTime StringToGDay(string value);
                static /*0x76f52cc*/ System.DateTime StringToGMonth(string value);
                static /*0x76f5348*/ System.DateTime StringToGMonthDay(string value);
                static /*0x76f53c4*/ System.DateTime StringToGYear(string value);
                static /*0x76f5440*/ System.DateTime StringToGYearMonth(string value);
                static /*0x76f54bc*/ System.DateTimeOffset StringToDateOffset(string value);
                static /*0x76f5538*/ System.DateTimeOffset StringToDateTimeOffset(string value);
                static /*0x76f55b4*/ System.DateTimeOffset StringToGDayOffset(string value);
                static /*0x76f5630*/ System.DateTimeOffset StringToGMonthOffset(string value);
                static /*0x76f56ac*/ System.DateTimeOffset StringToGMonthDayOffset(string value);
                static /*0x76f5728*/ System.DateTimeOffset StringToGYearOffset(string value);
                static /*0x76f57a4*/ System.DateTimeOffset StringToGYearMonthOffset(string value);
                static /*0x76f5820*/ byte[] StringToHexBinary(string value);
                static /*0x76f5954*/ System.Xml.XmlQualifiedName StringToQName(string value, System.Xml.IXmlNamespaceResolver nsResolver);
                static /*0x76f5c04*/ System.DateTime StringToTime(string value);
                static /*0x76f5c80*/ System.DateTimeOffset StringToTimeOffset(string value);
                static /*0x76f5cfc*/ System.TimeSpan StringToYearMonthDuration(string value);
                static /*0x76f5d5c*/ string AnyUriToString(System.Uri value);
                static /*0x76f5d70*/ string Base64BinaryToString(byte[] value);
                static /*0x76f5dc8*/ string DateToString(System.DateTime value);
                static /*0x76f5e50*/ string DateTimeToString(System.DateTime value);
                static /*0x76f5ed8*/ string DayTimeDurationToString(System.TimeSpan value);
                static /*0x76f5f38*/ string DurationToString(System.TimeSpan value);
                static /*0x76f5f98*/ string GDayToString(System.DateTime value);
                static /*0x76f6020*/ string GMonthToString(System.DateTime value);
                static /*0x76f60a8*/ string GMonthDayToString(System.DateTime value);
                static /*0x76f6130*/ string GYearToString(System.DateTime value);
                static /*0x76f61b8*/ string GYearMonthToString(System.DateTime value);
                static /*0x76f6240*/ string DateOffsetToString(System.DateTimeOffset value);
                static /*0x76f62d8*/ string DateTimeOffsetToString(System.DateTimeOffset value);
                static /*0x76f6370*/ string GDayOffsetToString(System.DateTimeOffset value);
                static /*0x76f6408*/ string GMonthOffsetToString(System.DateTimeOffset value);
                static /*0x76f64a0*/ string GMonthDayOffsetToString(System.DateTimeOffset value);
                static /*0x76f6538*/ string GYearOffsetToString(System.DateTimeOffset value);
                static /*0x76f65d0*/ string GYearMonthOffsetToString(System.DateTimeOffset value);
                static /*0x76f6668*/ string QNameToString(System.Xml.XmlQualifiedName qname, System.Xml.IXmlNamespaceResolver nsResolver);
                static /*0x76f687c*/ string TimeToString(System.DateTime value);
                static /*0x76f6904*/ string TimeOffsetToString(System.DateTimeOffset value);
                static /*0x76f699c*/ string YearMonthDurationToString(System.TimeSpan value);
                static /*0x76f69fc*/ System.DateTime DateTimeOffsetToDateTime(System.DateTimeOffset value);
                static /*0x76f6a60*/ int DecimalToInt32(decimal value);
                static /*0x76f6c38*/ long DecimalToInt64(decimal value);
                static /*0x76f6e10*/ ulong DecimalToUInt64(decimal value);
                static /*0x76f6fdc*/ byte Int32ToByte(int value);
                static /*0x76f70c0*/ short Int32ToInt16(int value);
                static /*0x76f71a4*/ sbyte Int32ToSByte(int value);
                static /*0x76f7288*/ ushort Int32ToUInt16(int value);
                static /*0x76f736c*/ int Int64ToInt32(long value);
                static /*0x76f7450*/ uint Int64ToUInt32(long value);
                static /*0x76f7534*/ System.DateTime UntypedAtomicToDateTime(string value);
                static /*0x76f75b0*/ System.DateTimeOffset UntypedAtomicToDateTimeOffset(string value);
                /*0x76f1ddc*/ XmlBaseConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x76f1ec4*/ XmlBaseConverter(System.Xml.Schema.XmlTypeCode typeCode);
                /*0x76f1fa8*/ XmlBaseConverter(System.Xml.Schema.XmlBaseConverter converterAtomic);
                /*0x76f2018*/ XmlBaseConverter(System.Xml.Schema.XmlBaseConverter converterAtomic, System.Type clrTypeDefault);
                /*0x76f206c*/ bool ToBoolean(System.DateTime value);
                /*0x76f2158*/ bool ToBoolean(double value);
                /*0x76f2238*/ bool ToBoolean(int value);
                /*0x76f2308*/ bool ToBoolean(long value);
                /*0x76f23d8*/ bool ToBoolean(string value);
                /*0x76f2490*/ bool ToBoolean(object value);
                /*0x76f2548*/ System.DateTime ToDateTime(bool value);
                /*0x76f2630*/ System.DateTime ToDateTime(System.DateTimeOffset value);
                /*0x76f2734*/ System.DateTime ToDateTime(double value);
                /*0x76f2818*/ System.DateTime ToDateTime(int value);
                /*0x76f28fc*/ System.DateTime ToDateTime(long value);
                /*0x76f29e0*/ System.DateTime ToDateTime(string value);
                /*0x76f2aa4*/ System.DateTime ToDateTime(object value);
                /*0x76f2b68*/ System.DateTimeOffset ToDateTimeOffset(System.DateTime value);
                /*0x76f2c64*/ System.DateTimeOffset ToDateTimeOffset(string value);
                /*0x76f2d2c*/ System.DateTimeOffset ToDateTimeOffset(object value);
                /*0x76f2df4*/ decimal ToDecimal(string value);
                /*0x76f2ebc*/ decimal ToDecimal(object value);
                /*0x76f2f84*/ double ToDouble(bool value);
                /*0x76f3058*/ double ToDouble(System.DateTime value);
                /*0x76f3144*/ double ToDouble(int value);
                /*0x76f3214*/ double ToDouble(long value);
                /*0x76f32e4*/ double ToDouble(string value);
                /*0x76f339c*/ double ToDouble(object value);
                /*0x76f3454*/ int ToInt32(bool value);
                /*0x76f3528*/ int ToInt32(System.DateTime value);
                /*0x76f3614*/ int ToInt32(double value);
                /*0x76f36f4*/ int ToInt32(long value);
                /*0x76f37c4*/ int ToInt32(string value);
                /*0x76f387c*/ int ToInt32(object value);
                /*0x76f3934*/ long ToInt64(bool value);
                /*0x76f3a08*/ long ToInt64(System.DateTime value);
                /*0x76f3af4*/ long ToInt64(double value);
                /*0x76f3bd4*/ long ToInt64(int value);
                /*0x76f3ca4*/ long ToInt64(string value);
                /*0x76f3d5c*/ long ToInt64(object value);
                /*0x76f3e14*/ float ToSingle(double value);
                /*0x76f3ef4*/ float ToSingle(string value);
                /*0x76f3fac*/ float ToSingle(object value);
                /*0x76f4064*/ string ToString(bool value);
                /*0x76f4124*/ string ToString(System.DateTime value);
                /*0x76f41fc*/ string ToString(System.DateTimeOffset value);
                /*0x76f42e0*/ string ToString(decimal value);
                /*0x76f43e4*/ string ToString(double value);
                /*0x76f44b0*/ string ToString(int value);
                /*0x76f456c*/ string ToString(long value);
                /*0x76f4628*/ string ToString(float value);
                /*0x76f46f4*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76f479c*/ string ToString(object value);
                /*0x76f47b0*/ object ChangeType(bool value, System.Type destinationType);
                /*0x76f4808*/ object ChangeType(System.DateTime value, System.Type destinationType);
                /*0x76f4890*/ object ChangeType(decimal value, System.Type destinationType);
                /*0x76f4944*/ object ChangeType(double value, System.Type destinationType);
                /*0x76f4998*/ object ChangeType(int value, System.Type destinationType);
                /*0x76f49ec*/ object ChangeType(long value, System.Type destinationType);
                /*0x76f4a40*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76f4a50*/ object ChangeType(object value, System.Type destinationType);
                /*0x76f4a64*/ System.Xml.Schema.XmlSchemaType get_SchemaType();
                /*0x76f4a6c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x76f4a74*/ string get_XmlTypeName();
                /*0x76f4c88*/ System.Type get_DefaultClrType();
                /*0x76f4d30*/ System.Exception CreateInvalidClrMappingException(System.Type sourceType, System.Type destinationType);
                /*0x76f4fb4*/ object ChangeListType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlNumeric10Converter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0x76f7c94*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x76f7c2c*/ XmlNumeric10Converter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x76f7cec*/ decimal ToDecimal(string value);
                /*0x76f7db0*/ decimal ToDecimal(object value);
                /*0x76f853c*/ int ToInt32(long value);
                /*0x76f8594*/ int ToInt32(string value);
                /*0x76f8694*/ int ToInt32(object value);
                /*0x76f8a34*/ long ToInt64(int value);
                /*0x76f8a3c*/ long ToInt64(string value);
                /*0x76f8b3c*/ long ToInt64(object value);
                /*0x76f8ec0*/ string ToString(decimal value);
                /*0x76f8f7c*/ string ToString(int value);
                /*0x76f8fd4*/ string ToString(long value);
                /*0x76f902c*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76f93dc*/ object ChangeType(decimal value, System.Type destinationType);
                /*0x76f9bd4*/ object ChangeType(int value, System.Type destinationType);
                /*0x76f9fb4*/ object ChangeType(long value, System.Type destinationType);
                /*0x76fa3a4*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76fa798*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76f8160*/ object ChangeTypeWildcardDestination(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76f97ec*/ object ChangeTypeWildcardSource(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlNumeric2Converter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0x76fb614*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x76fb5ac*/ XmlNumeric2Converter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x76fb66c*/ double ToDouble(string value);
                /*0x76fb738*/ double ToDouble(object value);
                /*0x76fba2c*/ float ToSingle(double value);
                /*0x76fba34*/ float ToSingle(string value);
                /*0x76fbb00*/ float ToSingle(object value);
                /*0x76fbdfc*/ string ToString(double value);
                /*0x76fbeb0*/ string ToString(float value);
                /*0x76fbf38*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76fc230*/ object ChangeType(double value, System.Type destinationType);
                /*0x76fc554*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76fc8b4*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlDateTimeConverter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0x76fcf98*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x76fcf30*/ XmlDateTimeConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x76fcff0*/ System.DateTime ToDateTime(System.DateTimeOffset value);
                /*0x76fd058*/ System.DateTime ToDateTime(string value);
                /*0x76fd25c*/ System.DateTime ToDateTime(object value);
                /*0x76fd59c*/ System.DateTimeOffset ToDateTimeOffset(System.DateTime value);
                /*0x76fd5c4*/ System.DateTimeOffset ToDateTimeOffset(string value);
                /*0x76fd7c8*/ System.DateTimeOffset ToDateTimeOffset(object value);
                /*0x76fdb14*/ string ToString(System.DateTime value);
                /*0x76fdccc*/ string ToString(System.DateTimeOffset value);
                /*0x76fdecc*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76fe1ec*/ object ChangeType(System.DateTime value, System.Type destinationType);
                /*0x76fe568*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76fe8ec*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlBooleanConverter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0x76ff040*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x76fefd8*/ XmlBooleanConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x76ff098*/ bool ToBoolean(string value);
                /*0x76ff13c*/ bool ToBoolean(object value);
                /*0x76ff3e0*/ string ToString(bool value);
                /*0x76ff438*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76ff6bc*/ object ChangeType(bool value, System.Type destinationType);
                /*0x76ff9b4*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76ffcc8*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlMiscConverter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0x7700280*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x7700218*/ XmlMiscConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x77002d8*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x7700924*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x7700f74*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x77007f4*/ object ChangeTypeWildcardDestination(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x7700e1c*/ object ChangeTypeWildcardSource(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlStringConverter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0x7701cb0*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x7701c48*/ XmlStringConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x7701d08*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x7701ee8*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x770215c*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlUntypedConverter : System.Xml.Schema.XmlListConverter
            {
                static /*0x0*/ System.Xml.Schema.XmlValueConverter Untyped;
                static /*0x8*/ System.Xml.Schema.XmlValueConverter UntypedList;
                /*0x30*/ bool allowListToList;

                static /*0x7708c80*/ XmlUntypedConverter();
                /*0x7702560*/ XmlUntypedConverter();
                /*0x7702658*/ XmlUntypedConverter(System.Xml.Schema.XmlUntypedConverter atomicConverter, bool allowListToList);
                /*0x7702764*/ bool ToBoolean(string value);
                /*0x7702808*/ bool ToBoolean(object value);
                /*0x7702adc*/ System.DateTime ToDateTime(string value);
                /*0x7702b80*/ System.DateTime ToDateTime(object value);
                /*0x7702d20*/ System.DateTimeOffset ToDateTimeOffset(string value);
                /*0x7702dc4*/ System.DateTimeOffset ToDateTimeOffset(object value);
                /*0x7702f60*/ decimal ToDecimal(string value);
                /*0x7703004*/ decimal ToDecimal(object value);
                /*0x77031b8*/ double ToDouble(string value);
                /*0x770325c*/ double ToDouble(object value);
                /*0x7703400*/ int ToInt32(string value);
                /*0x77034a4*/ int ToInt32(object value);
                /*0x7703648*/ long ToInt64(string value);
                /*0x77036ec*/ long ToInt64(object value);
                /*0x7703890*/ float ToSingle(string value);
                /*0x7703934*/ float ToSingle(object value);
                /*0x7703ad8*/ string ToString(bool value);
                /*0x7703b30*/ string ToString(System.DateTime value);
                /*0x7703b88*/ string ToString(System.DateTimeOffset value);
                /*0x7703bf0*/ string ToString(decimal value);
                /*0x7703c58*/ string ToString(double value);
                /*0x7703cb8*/ string ToString(int value);
                /*0x7703d10*/ string ToString(long value);
                /*0x7703d68*/ string ToString(float value);
                /*0x7703dc8*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x7704a78*/ object ChangeType(bool value, System.Type destinationType);
                /*0x7704dbc*/ object ChangeType(System.DateTime value, System.Type destinationType);
                /*0x7704f78*/ object ChangeType(decimal value, System.Type destinationType);
                /*0x7705174*/ object ChangeType(double value, System.Type destinationType);
                /*0x7705330*/ object ChangeType(int value, System.Type destinationType);
                /*0x77054ec*/ object ChangeType(long value, System.Type destinationType);
                /*0x77056a8*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x7706228*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x77029ac*/ object ChangeTypeWildcardDestination(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x7704c38*/ object ChangeTypeWildcardSource(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x7707690*/ object ChangeListType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x7707984*/ bool SupportsType(System.Type clrType);
            }

            class XmlAnyConverter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0x0*/ System.Xml.Schema.XmlValueConverter Item;
                static /*0x8*/ System.Xml.Schema.XmlValueConverter AnyAtomic;

                static /*0x770bf24*/ XmlAnyConverter();
                /*0x7708d38*/ XmlAnyConverter(System.Xml.Schema.XmlTypeCode typeCode);
                /*0x7708da0*/ bool ToBoolean(object value);
                /*0x770906c*/ System.DateTime ToDateTime(object value);
                /*0x7709210*/ System.DateTimeOffset ToDateTimeOffset(object value);
                /*0x77093c0*/ decimal ToDecimal(object value);
                /*0x7709570*/ double ToDouble(object value);
                /*0x770970c*/ int ToInt32(object value);
                /*0x77098a8*/ long ToInt64(object value);
                /*0x7709a44*/ float ToSingle(object value);
                /*0x7709be8*/ object ChangeType(bool value, System.Type destinationType);
                /*0x7709f10*/ object ChangeType(System.DateTime value, System.Type destinationType);
                /*0x770a0f0*/ object ChangeType(decimal value, System.Type destinationType);
                /*0x770a320*/ object ChangeType(double value, System.Type destinationType);
                /*0x770a4ec*/ object ChangeType(int value, System.Type destinationType);
                /*0x770a6b8*/ object ChangeType(long value, System.Type destinationType);
                /*0x770a884*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x770aa70*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x7708f3c*/ object ChangeTypeWildcardDestination(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x7709db8*/ object ChangeTypeWildcardSource(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x770be9c*/ System.Xml.XPath.XPathNavigator ToNavigator(System.Xml.XPath.XPathNavigator nav);
            }

            class XmlAnyListConverter : System.Xml.Schema.XmlListConverter
            {
                static /*0x0*/ System.Xml.Schema.XmlValueConverter ItemList;
                static /*0x8*/ System.Xml.Schema.XmlValueConverter AnyAtomicList;

                static /*0x770c280*/ XmlAnyListConverter();
                /*0x770bfb4*/ XmlAnyListConverter(System.Xml.Schema.XmlBaseConverter atomicConverter);
                /*0x770c030*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlListConverter : System.Xml.Schema.XmlBaseConverter
            {
                /*0x28*/ System.Xml.Schema.XmlValueConverter atomicConverter;

                static /*0x770c3e0*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlValueConverter atomicConverter);
                /*0x770bfb8*/ XmlListConverter(System.Xml.Schema.XmlBaseConverter atomicConverter);
                /*0x77026e4*/ XmlListConverter(System.Xml.Schema.XmlBaseConverter atomicConverter, System.Type clrTypeDefault);
                /*0x77025f0*/ XmlListConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x770c58c*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x7707ea8*/ object ChangeListType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x770c66c*/ bool IsListType(System.Type type);
                /*0x3814b90*/ T[] ToArray<T>(object list, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x770cedc*/ System.Collections.IList ToList(object list, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x770ce34*/ System.Collections.Generic.List<string> StringAsList(string value);
                /*0x770ca7c*/ string ListAsString(System.Collections.IEnumerable list, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x770c7f0*/ System.Exception CreateInvalidClrMappingException(System.Type sourceType, System.Type destinationType);
            }

            class XmlUnionConverter : System.Xml.Schema.XmlBaseConverter
            {
                /*0x28*/ System.Xml.Schema.XmlValueConverter[] converters;
                /*0x30*/ bool hasAtomicMember;
                /*0x31*/ bool hasListMember;

                static /*0x770d794*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x770d534*/ XmlUnionConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x770d7ec*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XsdBuilder : System.Xml.Schema.SchemaBuilder
            {
                static /*0x0*/ System.Xml.Schema.XsdBuilder.State[] SchemaElement;
                static /*0x8*/ System.Xml.Schema.XsdBuilder.State[] SchemaSubelements;
                static /*0x10*/ System.Xml.Schema.XsdBuilder.State[] AttributeSubelements;
                static /*0x18*/ System.Xml.Schema.XsdBuilder.State[] ElementSubelements;
                static /*0x20*/ System.Xml.Schema.XsdBuilder.State[] ComplexTypeSubelements;
                static /*0x28*/ System.Xml.Schema.XsdBuilder.State[] SimpleContentSubelements;
                static /*0x30*/ System.Xml.Schema.XsdBuilder.State[] SimpleContentExtensionSubelements;
                static /*0x38*/ System.Xml.Schema.XsdBuilder.State[] SimpleContentRestrictionSubelements;
                static /*0x40*/ System.Xml.Schema.XsdBuilder.State[] ComplexContentSubelements;
                static /*0x48*/ System.Xml.Schema.XsdBuilder.State[] ComplexContentExtensionSubelements;
                static /*0x50*/ System.Xml.Schema.XsdBuilder.State[] ComplexContentRestrictionSubelements;
                static /*0x58*/ System.Xml.Schema.XsdBuilder.State[] SimpleTypeSubelements;
                static /*0x60*/ System.Xml.Schema.XsdBuilder.State[] SimpleTypeRestrictionSubelements;
                static /*0x68*/ System.Xml.Schema.XsdBuilder.State[] SimpleTypeListSubelements;
                static /*0x70*/ System.Xml.Schema.XsdBuilder.State[] SimpleTypeUnionSubelements;
                static /*0x78*/ System.Xml.Schema.XsdBuilder.State[] RedefineSubelements;
                static /*0x80*/ System.Xml.Schema.XsdBuilder.State[] AttributeGroupSubelements;
                static /*0x88*/ System.Xml.Schema.XsdBuilder.State[] GroupSubelements;
                static /*0x90*/ System.Xml.Schema.XsdBuilder.State[] AllSubelements;
                static /*0x98*/ System.Xml.Schema.XsdBuilder.State[] ChoiceSequenceSubelements;
                static /*0xa0*/ System.Xml.Schema.XsdBuilder.State[] IdentityConstraintSubelements;
                static /*0xa8*/ System.Xml.Schema.XsdBuilder.State[] AnnotationSubelements;
                static /*0xb0*/ System.Xml.Schema.XsdBuilder.State[] AnnotatedSubelements;
                static /*0xb8*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] SchemaAttributes;
                static /*0xc0*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] AttributeAttributes;
                static /*0xc8*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] ElementAttributes;
                static /*0xd0*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] ComplexTypeAttributes;
                static /*0xd8*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] SimpleContentAttributes;
                static /*0xe0*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] SimpleContentExtensionAttributes;
                static /*0xe8*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] SimpleContentRestrictionAttributes;
                static /*0xf0*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] ComplexContentAttributes;
                static /*0xf8*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] ComplexContentExtensionAttributes;
                static /*0x100*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] ComplexContentRestrictionAttributes;
                static /*0x108*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] SimpleTypeAttributes;
                static /*0x110*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] SimpleTypeRestrictionAttributes;
                static /*0x118*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] SimpleTypeUnionAttributes;
                static /*0x120*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] SimpleTypeListAttributes;
                static /*0x128*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] AttributeGroupAttributes;
                static /*0x130*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] AttributeGroupRefAttributes;
                static /*0x138*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] GroupAttributes;
                static /*0x140*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] GroupRefAttributes;
                static /*0x148*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] ParticleAttributes;
                static /*0x150*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] AnyAttributes;
                static /*0x158*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] IdentityConstraintAttributes;
                static /*0x160*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] SelectorAttributes;
                static /*0x168*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] FieldAttributes;
                static /*0x170*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] NotationAttributes;
                static /*0x178*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] IncludeAttributes;
                static /*0x180*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] ImportAttributes;
                static /*0x188*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] FacetAttributes;
                static /*0x190*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] AnyAttributeAttributes;
                static /*0x198*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] DocumentationAttributes;
                static /*0x1a0*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] AppinfoAttributes;
                static /*0x1a8*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] RedefineAttributes;
                static /*0x1b0*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] AnnotationAttributes;
                static /*0x1b8*/ System.Xml.Schema.XsdBuilder.XsdEntry[] SchemaEntries;
                static /*0x1c0*/ int[] DerivationMethodValues;
                static /*0x1c8*/ string[] DerivationMethodStrings;
                static /*0x1d0*/ string[] FormStringValues;
                static /*0x1d8*/ string[] UseStringValues;
                static /*0x1e0*/ string[] ProcessContentsStringValues;
                /*0x10*/ System.Xml.XmlReader reader;
                /*0x18*/ System.Xml.PositionInfo positionInfo;
                /*0x20*/ System.Xml.Schema.XsdBuilder.XsdEntry currentEntry;
                /*0x28*/ System.Xml.Schema.XsdBuilder.XsdEntry nextEntry;
                /*0x30*/ bool hasChild;
                /*0x38*/ System.Xml.HWStack stateHistory;
                /*0x40*/ System.Collections.Stack containerStack;
                /*0x48*/ System.Xml.XmlNameTable nameTable;
                /*0x50*/ System.Xml.Schema.SchemaNames schemaNames;
                /*0x58*/ System.Xml.XmlNamespaceManager namespaceManager;
                /*0x60*/ bool canIncludeImport;
                /*0x68*/ System.Xml.Schema.XmlSchema schema;
                /*0x70*/ System.Xml.Schema.XmlSchemaObject xso;
                /*0x78*/ System.Xml.Schema.XmlSchemaElement element;
                /*0x80*/ System.Xml.Schema.XmlSchemaAny anyElement;
                /*0x88*/ System.Xml.Schema.XmlSchemaAttribute attribute;
                /*0x90*/ System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;
                /*0x98*/ System.Xml.Schema.XmlSchemaComplexType complexType;
                /*0xa0*/ System.Xml.Schema.XmlSchemaSimpleType simpleType;
                /*0xa8*/ System.Xml.Schema.XmlSchemaComplexContent complexContent;
                /*0xb0*/ System.Xml.Schema.XmlSchemaComplexContentExtension complexContentExtension;
                /*0xb8*/ System.Xml.Schema.XmlSchemaComplexContentRestriction complexContentRestriction;
                /*0xc0*/ System.Xml.Schema.XmlSchemaSimpleContent simpleContent;
                /*0xc8*/ System.Xml.Schema.XmlSchemaSimpleContentExtension simpleContentExtension;
                /*0xd0*/ System.Xml.Schema.XmlSchemaSimpleContentRestriction simpleContentRestriction;
                /*0xd8*/ System.Xml.Schema.XmlSchemaSimpleTypeUnion simpleTypeUnion;
                /*0xe0*/ System.Xml.Schema.XmlSchemaSimpleTypeList simpleTypeList;
                /*0xe8*/ System.Xml.Schema.XmlSchemaSimpleTypeRestriction simpleTypeRestriction;
                /*0xf0*/ System.Xml.Schema.XmlSchemaGroup group;
                /*0xf8*/ System.Xml.Schema.XmlSchemaGroupRef groupRef;
                /*0x100*/ System.Xml.Schema.XmlSchemaAll all;
                /*0x108*/ System.Xml.Schema.XmlSchemaChoice choice;
                /*0x110*/ System.Xml.Schema.XmlSchemaSequence sequence;
                /*0x118*/ System.Xml.Schema.XmlSchemaParticle particle;
                /*0x120*/ System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup;
                /*0x128*/ System.Xml.Schema.XmlSchemaAttributeGroupRef attributeGroupRef;
                /*0x130*/ System.Xml.Schema.XmlSchemaNotation notation;
                /*0x138*/ System.Xml.Schema.XmlSchemaIdentityConstraint identityConstraint;
                /*0x140*/ System.Xml.Schema.XmlSchemaXPath xpath;
                /*0x148*/ System.Xml.Schema.XmlSchemaInclude include;
                /*0x150*/ System.Xml.Schema.XmlSchemaImport import;
                /*0x158*/ System.Xml.Schema.XmlSchemaAnnotation annotation;
                /*0x160*/ System.Xml.Schema.XmlSchemaAppInfo appInfo;
                /*0x168*/ System.Xml.Schema.XmlSchemaDocumentation documentation;
                /*0x170*/ System.Xml.Schema.XmlSchemaFacet facet;
                /*0x178*/ System.Xml.XmlNode[] markup;
                /*0x180*/ System.Xml.Schema.XmlSchemaRedefine redefine;
                /*0x188*/ System.Xml.Schema.ValidationEventHandler validationEventHandler;
                /*0x190*/ System.Collections.ArrayList unhandledAttributes;
                /*0x198*/ System.Collections.Hashtable namespaces;

                static /*0x77144a0*/ XsdBuilder();
                static /*0x770fbac*/ void BuildAnnotated_Id(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x770fbd0*/ void BuildSchema_AttributeFormDefault(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x770fd44*/ void BuildSchema_ElementFormDefault(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x770fde4*/ void BuildSchema_TargetNamespace(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x770fe04*/ void BuildSchema_Version(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x770fe24*/ void BuildSchema_FinalDefault(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x77100e0*/ void BuildSchema_BlockDefault(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7710148*/ void InitSchema(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x771016c*/ void InitInclude(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7710230*/ void BuildInclude_SchemaLocation(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7710250*/ void InitImport(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7710314*/ void BuildImport_Namespace(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7710334*/ void BuildImport_SchemaLocation(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7710354*/ void InitRedefine(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7710418*/ void BuildRedefine_SchemaLocation(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7710438*/ void EndRedefine(System.Xml.Schema.XsdBuilder builder);
                static /*0x7710454*/ void InitAttribute(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7710744*/ void BuildAttribute_Default(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7710764*/ void BuildAttribute_Fixed(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7710784*/ void BuildAttribute_Form(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7710824*/ void BuildAttribute_Use(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x77108c4*/ void BuildAttribute_Ref(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7710a98*/ void BuildAttribute_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7710ab8*/ void BuildAttribute_Type(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7710b28*/ void InitElement(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7710c38*/ void BuildElement_Abstract(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7710db4*/ void BuildElement_Block(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7710e1c*/ void BuildElement_Default(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7710e3c*/ void BuildElement_Form(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7710edc*/ void BuildElement_SubstitutionGroup(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7710f4c*/ void BuildElement_Final(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7710fb4*/ void BuildElement_Fixed(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7710fd4*/ void BuildElement_MaxOccurs(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x77110b0*/ void BuildElement_MinOccurs(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x771118c*/ void BuildElement_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x77111ac*/ void BuildElement_Nillable(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x771121c*/ void BuildElement_Ref(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x771128c*/ void BuildElement_Type(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x77112fc*/ void InitSimpleType(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7711628*/ void BuildSimpleType_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7711648*/ void BuildSimpleType_Final(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x77116b0*/ void InitSimpleTypeUnion(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7711774*/ void BuildSimpleTypeUnion_MemberTypes(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7711964*/ void InitSimpleTypeList(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7711a28*/ void BuildSimpleTypeList_ItemType(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7711a98*/ void InitSimpleTypeRestriction(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7711b5c*/ void BuildSimpleTypeRestriction_Base(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7711bcc*/ void InitComplexType(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7711d50*/ void BuildComplexType_Abstract(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7711dc0*/ void BuildComplexType_Block(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7711e28*/ void BuildComplexType_Final(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7711e90*/ void BuildComplexType_Mixed(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7711f08*/ void BuildComplexType_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7711f28*/ void InitComplexContent(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7712030*/ void BuildComplexContent_Mixed(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x77120a0*/ void InitComplexContentExtension(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x771218c*/ void BuildComplexContentExtension_Base(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x77121fc*/ void InitComplexContentRestriction(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7712294*/ void BuildComplexContentRestriction_Base(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7712304*/ void InitSimpleContent(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x771240c*/ void InitSimpleContentExtension(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x77124f8*/ void BuildSimpleContentExtension_Base(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7712568*/ void InitSimpleContentRestriction(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7712654*/ void BuildSimpleContentRestriction_Base(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x77126c4*/ void InitAttributeGroup(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7712798*/ void BuildAttributeGroup_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x77127b8*/ void InitAttributeGroupRef(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x771283c*/ void BuildAttributeGroupRef_Ref(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x77128ac*/ void InitAnyAttribute(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7712b4c*/ void BuildAnyAttribute_Namespace(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7712b6c*/ void BuildAnyAttribute_ProcessContents(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7712c0c*/ void InitGroup(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7712ce0*/ void BuildGroup_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7712d00*/ void InitGroupRef(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7713080*/ void BuildParticle_MaxOccurs(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x771309c*/ void BuildParticle_MinOccurs(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x77130b8*/ void BuildGroupRef_Ref(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7713128*/ void InitAll(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x77131bc*/ void InitChoice(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7713250*/ void InitSequence(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x77132e4*/ void InitAny(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x771337c*/ void BuildAny_Namespace(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x771339c*/ void BuildAny_ProcessContents(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x771343c*/ void InitNotation(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x77134d8*/ void BuildNotation_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x77134f8*/ void BuildNotation_Public(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7713518*/ void BuildNotation_System(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7713538*/ void InitFacet(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x771384c*/ void BuildFacet_Fixed(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x77138c4*/ void BuildFacet_Value(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x77138e4*/ void InitIdentityConstraint(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7713a38*/ void BuildIdentityConstraint_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7713a58*/ void BuildIdentityConstraint_Refer(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7713b78*/ void InitSelector(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7713c50*/ void BuildSelector_XPath(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7713c70*/ void InitField(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7713d48*/ void BuildField_XPath(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7713d68*/ void InitAnnotation(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7713e4c*/ void InitAppinfo(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7713f14*/ void BuildAppinfo_Source(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7713f88*/ void EndAppinfo(System.Xml.Schema.XsdBuilder builder);
                static /*0x7713fb0*/ void InitDocumentation(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7714078*/ void BuildDocumentation_Source(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x77140e8*/ void BuildDocumentation_XmlLang(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x7714228*/ void EndDocumentation(System.Xml.Schema.XsdBuilder builder);
                static /*0x7713f84*/ string ParseUriReference(string s);
                /*0x770dbe0*/ XsdBuilder(System.Xml.XmlReader reader, System.Xml.XmlNamespaceManager curmgr, System.Xml.Schema.XmlSchema schema, System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventhandler);
                /*0x770de3c*/ bool ProcessElement(string prefix, string name, string ns);
                /*0x770e33c*/ void ProcessAttribute(string prefix, string name, string ns, string value);
                /*0x770e8b4*/ bool IsContentParsed();
                /*0x770e8d0*/ void ProcessMarkup(System.Xml.XmlNode[] markup);
                /*0x770e8e0*/ void ProcessCData(string value);
                /*0x770e938*/ void StartChildren();
                /*0x770eac4*/ void EndChildren();
                /*0x770e0c8*/ void Push();
                /*0x770eb00*/ void Pop();
                /*0x770fa88*/ System.Xml.Schema.SchemaNames.Token get_CurrentElement();
                /*0x770faa4*/ System.Xml.Schema.SchemaNames.Token get_ParentElement();
                /*0x770fb1c*/ System.Xml.Schema.XmlSchemaObject get_ParentContainer();
                /*0x770ebd8*/ System.Xml.Schema.XmlSchemaObject GetContainer(System.Xml.Schema.XsdBuilder.State state);
                /*0x770ed10*/ void SetContainer(System.Xml.Schema.XsdBuilder.State state, object container);
                /*0x7710514*/ void AddAttribute(System.Xml.Schema.XmlSchemaObject value);
                /*0x7712d98*/ void AddParticle(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x770df64*/ bool GetNextState(System.Xml.XmlQualifiedName qname);
                /*0x770e22c*/ bool IsSkipableElement(System.Xml.XmlQualifiedName qname);
                /*0x77110cc*/ void SetMinOccurs(System.Xml.Schema.XmlSchemaParticle particle, string value);
                /*0x7710ff0*/ void SetMaxOccurs(System.Xml.Schema.XmlSchemaParticle particle, string value);
                /*0x7710ca8*/ bool ParseBoolean(string value, string attributeName);
                /*0x770fc70*/ int ParseEnum(string value, string attributeName, string[] values);
                /*0x7710934*/ System.Xml.XmlQualifiedName ParseQName(string value, string attributeName);
                /*0x770fe8c*/ int ParseBlockFinalEnum(string value, string attributeName);
                /*0x7714250*/ void SendValidationEvent(string code, string arg0, string arg1, string arg2);
                /*0x770e254*/ void SendValidationEvent(string code, string msg);
                /*0x770e7c0*/ void SendValidationEvent(string code, string[] args, System.Xml.Schema.XmlSeverityType severity);
                /*0x77143c4*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity);
                /*0x771195c*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e);
                /*0x770e170*/ void RecordPosition();

                enum State
                {
                    Root = 0,
                    Schema = 1,
                    Annotation = 2,
                    Include = 3,
                    Import = 4,
                    Element = 5,
                    Attribute = 6,
                    AttributeGroup = 7,
                    AttributeGroupRef = 8,
                    AnyAttribute = 9,
                    Group = 10,
                    GroupRef = 11,
                    All = 12,
                    Choice = 13,
                    Sequence = 14,
                    Any = 15,
                    Notation = 16,
                    SimpleType = 17,
                    ComplexType = 18,
                    ComplexContent = 19,
                    ComplexContentRestriction = 20,
                    ComplexContentExtension = 21,
                    SimpleContent = 22,
                    SimpleContentExtension = 23,
                    SimpleContentRestriction = 24,
                    SimpleTypeUnion = 25,
                    SimpleTypeList = 26,
                    SimpleTypeRestriction = 27,
                    Unique = 28,
                    Key = 29,
                    KeyRef = 30,
                    Selector = 31,
                    Field = 32,
                    MinExclusive = 33,
                    MinInclusive = 34,
                    MaxExclusive = 35,
                    MaxInclusive = 36,
                    TotalDigits = 37,
                    FractionDigits = 38,
                    Length = 39,
                    MinLength = 40,
                    MaxLength = 41,
                    Enumeration = 42,
                    Pattern = 43,
                    WhiteSpace = 44,
                    AppInfo = 45,
                    Documentation = 46,
                    Redefine = 47,
                }

                class XsdBuildFunction : System.MulticastDelegate
                {
                    /*0x771966c*/ XsdBuildFunction(object object, nint method);
                    /*0x7719720*/ void Invoke(System.Xml.Schema.XsdBuilder builder, string value);
                }

                class XsdInitFunction : System.MulticastDelegate
                {
                    /*0x7719734*/ XsdInitFunction(object object, nint method);
                    /*0x77197e8*/ void Invoke(System.Xml.Schema.XsdBuilder builder, string value);
                }

                class XsdEndChildFunction : System.MulticastDelegate
                {
                    /*0x77197fc*/ XsdEndChildFunction(object object, nint method);
                    /*0x77198ac*/ void Invoke(System.Xml.Schema.XsdBuilder builder);
                }

                class XsdAttributeEntry
                {
                    /*0x10*/ System.Xml.Schema.SchemaNames.Token Attribute;
                    /*0x18*/ System.Xml.Schema.XsdBuilder.XsdBuildFunction BuildFunc;

                    /*0x77198c0*/ XsdAttributeEntry(System.Xml.Schema.SchemaNames.Token a, System.Xml.Schema.XsdBuilder.XsdBuildFunction build);
                }

                class XsdEntry
                {
                    /*0x10*/ System.Xml.Schema.SchemaNames.Token Name;
                    /*0x14*/ System.Xml.Schema.XsdBuilder.State CurrentState;
                    /*0x18*/ System.Xml.Schema.XsdBuilder.State[] NextStates;
                    /*0x20*/ System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] Attributes;
                    /*0x28*/ System.Xml.Schema.XsdBuilder.XsdInitFunction InitFunc;
                    /*0x30*/ System.Xml.Schema.XsdBuilder.XsdEndChildFunction EndChildFunc;
                    /*0x38*/ bool ParseContent;

                    /*0x77198f8*/ XsdEntry(System.Xml.Schema.SchemaNames.Token n, System.Xml.Schema.XsdBuilder.State state, System.Xml.Schema.XsdBuilder.State[] nextStates, System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] attributes, System.Xml.Schema.XsdBuilder.XsdInitFunction init, System.Xml.Schema.XsdBuilder.XsdEndChildFunction end, bool parseContent);
                }

                class BuilderNamespaceManager : System.Xml.XmlNamespaceManager
                {
                    /*0x50*/ System.Xml.XmlNamespaceManager nsMgr;
                    /*0x58*/ System.Xml.XmlReader reader;

                    /*0x7719994*/ BuilderNamespaceManager(System.Xml.XmlNamespaceManager nsMgr, System.Xml.XmlReader reader);
                    /*0x77199d8*/ string LookupNamespace(string prefix);
                }
            }

            enum XsdDateTimeFlags
            {
                DateTime = 1,
                Time = 2,
                Date = 4,
                GYearMonth = 8,
                GYear = 16,
                GMonthDay = 32,
                GDay = 64,
                GMonth = 128,
                XdrDateTimeNoTz = 256,
                XdrDateTime = 512,
                XdrTimeNoTz = 1024,
                AllXsd = 255,
            }

            struct XsdDateTime
            {
                static /*0x0*/ int Lzyyyy;
                static /*0x4*/ int Lzyyyy_;
                static /*0x8*/ int Lzyyyy_MM;
                static /*0xc*/ int Lzyyyy_MM_;
                static /*0x10*/ int Lzyyyy_MM_dd;
                static /*0x14*/ int Lzyyyy_MM_ddT;
                static /*0x18*/ int LzHH;
                static /*0x1c*/ int LzHH_;
                static /*0x20*/ int LzHH_mm;
                static /*0x24*/ int LzHH_mm_;
                static /*0x28*/ int LzHH_mm_ss;
                static /*0x2c*/ int Lz_;
                static /*0x30*/ int Lz_zz;
                static /*0x34*/ int Lz_zz_;
                static /*0x38*/ int Lz_zz_zz;
                static /*0x3c*/ int Lz__;
                static /*0x40*/ int Lz__mm;
                static /*0x44*/ int Lz__mm_;
                static /*0x48*/ int Lz__mm__;
                static /*0x4c*/ int Lz__mm_dd;
                static /*0x50*/ int Lz___;
                static /*0x54*/ int Lz___dd;
                static /*0x58*/ System.Xml.Schema.XmlTypeCode[] typeCodes;
                /*0x10*/ System.DateTime dt;
                /*0x18*/ uint extra;

                static /*0x771c32c*/ XsdDateTime();
                static /*0x771a87c*/ bool TryParse(string text, System.Xml.Schema.XsdDateTimeFlags kinds, ref System.Xml.Schema.XsdDateTime result);
                static /*0x771b048*/ System.DateTime op_Implicit(System.Xml.Schema.XsdDateTime xdt);
                static /*0x771b584*/ System.DateTimeOffset op_Implicit(System.Xml.Schema.XsdDateTime xdt);
                /*0x7719a38*/ XsdDateTime(string text, System.Xml.Schema.XsdDateTimeFlags kinds);
                /*0x771a7e8*/ XsdDateTime(System.Xml.Schema.XsdDateTime.Parser parser);
                /*0x771a93c*/ XsdDateTime(System.DateTime dateTime, System.Xml.Schema.XsdDateTimeFlags kinds);
                /*0x771ab00*/ XsdDateTime(System.DateTimeOffset dateTimeOffset);
                /*0x771ab70*/ XsdDateTime(System.DateTimeOffset dateTimeOffset, System.Xml.Schema.XsdDateTimeFlags kinds);
                /*0x771a72c*/ void InitiateXsdDateTime(System.Xml.Schema.XsdDateTime.Parser parser);
                /*0x771ad00*/ System.Xml.Schema.XsdDateTime.DateTimeTypeCode get_InternalTypeCode();
                /*0x771ad08*/ System.Xml.Schema.XsdDateTime.XsdDateTimeKind get_InternalKind();
                /*0x771ad10*/ int get_Year();
                /*0x771ad68*/ int get_Month();
                /*0x771adc0*/ int get_Day();
                /*0x771ae18*/ int get_Hour();
                /*0x771ae70*/ int get_Minute();
                /*0x771aec8*/ int get_Second();
                /*0x771af20*/ int get_Fraction();
                /*0x771b038*/ int get_ZoneHour();
                /*0x771b040*/ int get_ZoneMinute();
                /*0x771b8e0*/ string ToString();
                /*0x771bd24*/ void PrintDate(System.Text.StringBuilder sb);
                /*0x771be68*/ void PrintTime(System.Text.StringBuilder sb);
                /*0x771c18c*/ void PrintZone(System.Text.StringBuilder sb);
                /*0x771c0bc*/ void IntToCharArray(char[] text, int start, int value, int digits);
                /*0x771c124*/ void ShortToCharArray(char[] text, int start, int value);

                enum DateTimeTypeCode
                {
                    DateTime = 0,
                    Time = 1,
                    Date = 2,
                    GYearMonth = 3,
                    GYear = 4,
                    GMonthDay = 5,
                    GDay = 6,
                    GMonth = 7,
                    XdrDateTime = 8,
                }

                enum XsdDateTimeKind
                {
                    Unspecified = 0,
                    Zulu = 1,
                    LocalWestOfZulu = 2,
                    LocalEastOfZulu = 3,
                }

                struct Parser
                {
                    static /*0x0*/ int[] Power10;
                    /*0x10*/ System.Xml.Schema.XsdDateTime.DateTimeTypeCode typeCode;
                    /*0x14*/ int year;
                    /*0x18*/ int month;
                    /*0x1c*/ int day;
                    /*0x20*/ int hour;
                    /*0x24*/ int minute;
                    /*0x28*/ int second;
                    /*0x2c*/ int fraction;
                    /*0x30*/ System.Xml.Schema.XsdDateTime.XsdDateTimeKind kind;
                    /*0x34*/ int zoneHour;
                    /*0x38*/ int zoneMinute;
                    /*0x40*/ string text;
                    /*0x48*/ int length;

                    static /*0x771d22c*/ Parser();
                    static /*0x771c6e0*/ bool Test(System.Xml.Schema.XsdDateTimeFlags left, System.Xml.Schema.XsdDateTimeFlags right);
                    /*0x7719be8*/ bool Parse(string text, System.Xml.Schema.XsdDateTimeFlags kinds);
                    /*0x771c6ec*/ bool ParseDate(int start);
                    /*0x771c94c*/ bool ParseTimeAndZoneAndWhitespace(int start);
                    /*0x771cc48*/ bool ParseTimeAndWhitespace(int start);
                    /*0x771ceb4*/ bool ParseTime(ref int start);
                    /*0x771c9e8*/ bool ParseZoneAndWhitespace(int start);
                    /*0x771cce4*/ bool Parse4Dig(int start, ref int num);
                    /*0x771ce0c*/ bool Parse2Dig(int start, ref int num);
                    /*0x771c908*/ bool ParseChar(int start, char ch);
                }
            }

            struct XsdDuration
            {
                /*0x10*/ int years;
                /*0x14*/ int months;
                /*0x18*/ int days;
                /*0x1c*/ int hours;
                /*0x20*/ int minutes;
                /*0x24*/ int seconds;
                /*0x28*/ uint nanoseconds;

                static /*0x771e784*/ System.Exception TryParse(string s, ref System.Xml.Schema.XsdDuration result);
                static /*0x771d67c*/ System.Exception TryParse(string s, System.Xml.Schema.XsdDuration.DurationType durationType, ref System.Xml.Schema.XsdDuration result);
                static /*0x771e790*/ string TryParseDigits(string s, ref int offset, bool eatDigits, ref int result, ref int numDigits);
                /*0x771d2cc*/ XsdDuration(bool isNegative, int years, int months, int days, int hours, int minutes, int seconds, int nanoseconds);
                /*0x771d428*/ XsdDuration(System.TimeSpan timeSpan);
                /*0x771d430*/ XsdDuration(System.TimeSpan timeSpan, System.Xml.Schema.XsdDuration.DurationType durationType);
                /*0x771d600*/ XsdDuration(string s);
                /*0x771d608*/ XsdDuration(string s, System.Xml.Schema.XsdDuration.DurationType durationType);
                /*0x771ddf4*/ bool get_IsNegative();
                /*0x771de00*/ int get_Years();
                /*0x771de08*/ int get_Months();
                /*0x771de10*/ int get_Days();
                /*0x771de18*/ int get_Hours();
                /*0x771de20*/ int get_Minutes();
                /*0x771de28*/ int get_Seconds();
                /*0x771dde8*/ int get_Nanoseconds();
                /*0x771de30*/ System.TimeSpan ToTimeSpan();
                /*0x771de38*/ System.TimeSpan ToTimeSpan(System.Xml.Schema.XsdDuration.DurationType durationType);
                /*0x771e344*/ System.Exception TryToTimeSpan(ref System.TimeSpan result);
                /*0x771de80*/ System.Exception TryToTimeSpan(System.Xml.Schema.XsdDuration.DurationType durationType, ref System.TimeSpan result);
                /*0x771e350*/ string ToString();
                /*0x771e358*/ string ToString(System.Xml.Schema.XsdDuration.DurationType durationType);

                enum Parts
                {
                    HasNone = 0,
                    HasYears = 1,
                    HasMonths = 2,
                    HasDays = 4,
                    HasHours = 8,
                    HasMinutes = 16,
                    HasSeconds = 32,
                }

                enum DurationType
                {
                    Duration = 0,
                    YearMonthDuration = 1,
                    DayTimeDuration = 2,
                }
            }

            class XsdValidator : System.Xml.Schema.BaseValidator
            {
                static /*0x0*/ System.Xml.Schema.XmlSchemaDatatype dtCDATA;
                static /*0x8*/ System.Xml.Schema.XmlSchemaDatatype dtQName;
                static /*0x10*/ System.Xml.Schema.XmlSchemaDatatype dtStringArray;
                /*0x7c*/ int startIDConstraint;
                /*0x80*/ System.Xml.HWStack validationStack;
                /*0x88*/ System.Collections.Hashtable attPresence;
                /*0x90*/ System.Xml.XmlNamespaceManager nsManager;
                /*0x98*/ bool bManageNamespaces;
                /*0xa0*/ System.Collections.Hashtable IDs;
                /*0xa8*/ System.Xml.Schema.IdRefNode idRefListHead;
                /*0xb0*/ System.Xml.Schema.Parser inlineSchemaParser;
                /*0xb8*/ System.Xml.Schema.XmlSchemaContentProcessing processContents;
                /*0xc0*/ string NsXmlNs;
                /*0xc8*/ string NsXs;
                /*0xd0*/ string NsXsi;
                /*0xd8*/ string XsiType;
                /*0xe0*/ string XsiNil;
                /*0xe8*/ string XsiSchemaLocation;
                /*0xf0*/ string XsiNoNamespaceSchemaLocation;
                /*0xf8*/ string XsdSchema;

                static /*0x7723998*/ XsdValidator();
                /*0x771e94c*/ XsdValidator(System.Xml.Schema.BaseValidator validator);
                /*0x771ed58*/ XsdValidator(System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling);
                /*0x771e970*/ void Init();
                /*0x771eeb4*/ void Validate();
                /*0x771f560*/ void CompleteValidation();
                /*0x771ef6c*/ bool get_IsInlineSchemaStarted();
                /*0x771ef7c*/ void ProcessInlineSchema();
                /*0x771f214*/ void ValidateElement();
                /*0x771f688*/ object ValidateChildElement();
                /*0x771f8c4*/ void ProcessElement(object particle);
                /*0x771fbd0*/ void ProcessXsiAttributes(ref System.Xml.XmlQualifiedName xsiType, ref string xsiNil);
                /*0x771f380*/ void ValidateEndElement();
                /*0x771faf4*/ System.Xml.Schema.SchemaElementDecl FastGetElementDecl(object particle);
                /*0x77203d8*/ System.Xml.Schema.SchemaElementDecl ThoroughGetElementDecl(System.Xml.Schema.SchemaElementDecl elementDecl, System.Xml.XmlQualifiedName xsiType, string xsiNil);
                /*0x7720830*/ void ValidateStartElement();
                /*0x7720ef8*/ void ValidateEndStartElement();
                /*0x77229b4*/ void LoadSchemaFromLocation(string uri, string url);
                /*0x77212d8*/ void LoadSchema(string uri, string url);
                /*0x77207c0*/ bool get_HasSchema();
                /*0x7722f2c*/ bool get_PreserveWhitespace();
                /*0x7722f64*/ void ProcessTokenizedType(System.Xml.XmlTokenizedType ttype, string name);
                /*0x7721498*/ void CheckValue(string value, System.Xml.Schema.SchemaAttDef attdef);
                /*0x7723188*/ void AddID(string name, object node);
                /*0x7723224*/ object FindId(string name);
                /*0x771f874*/ bool IsXSDRoot(string localName, string ns);
                /*0x771ed7c*/ void Push(System.Xml.XmlQualifiedName elementName);
                /*0x7722574*/ void Pop();
                /*0x771f564*/ void CheckForwardRefs();
                /*0x77207e4*/ void ValidateStartElementIdentityConstraints();
                /*0x77218f0*/ bool get_HasIdentityConstraints();
                /*0x7723240*/ void AddIdentityConstraints();
                /*0x7723650*/ void ElementIdentityConstraints();
                /*0x77226d8*/ void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, System.Xml.Schema.SchemaAttDef attdef);
                /*0x7722654*/ object UnWrapUnion(object typedValue);
                /*0x7721900*/ void EndElementIdentityConstraints();
            }
        }
    }
}

namespace MS
{
    namespace Internal
    {
        namespace Xml
        {
            namespace XPath
            {
                class AstNode
                {
                    /*0x7723a5c*/ AstNode();
                    /*0x3814574*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x3814574*/ System.Xml.XPath.XPathResultType get_ReturnType();

                    enum AstType
                    {
                        Axis = 0,
                        Operator = 1,
                        Filter = 2,
                        ConstantOperand = 3,
                        Function = 4,
                        Group = 5,
                        Root = 6,
                        Variable = 7,
                        Error = 8,
                    }
                }

                class Axis : MS.Internal.Xml.XPath.AstNode
                {
                    /*0x10*/ MS.Internal.Xml.XPath.Axis.AxisType _axisType;
                    /*0x18*/ MS.Internal.Xml.XPath.AstNode _input;
                    /*0x20*/ string _prefix;
                    /*0x28*/ string _name;
                    /*0x30*/ System.Xml.XPath.XPathNodeType _nodeType;
                    /*0x34*/ bool abbrAxis;
                    /*0x38*/ string _urn;

                    /*0x7723a64*/ Axis(MS.Internal.Xml.XPath.Axis.AxisType axisType, MS.Internal.Xml.XPath.AstNode input, string prefix, string name, System.Xml.XPath.XPathNodeType nodetype);
                    /*0x7723b00*/ Axis(MS.Internal.Xml.XPath.Axis.AxisType axisType, MS.Internal.Xml.XPath.AstNode input);
                    /*0x7723b38*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x7723b40*/ System.Xml.XPath.XPathResultType get_ReturnType();
                    /*0x7723b48*/ MS.Internal.Xml.XPath.AstNode get_Input();
                    /*0x7723b50*/ void set_Input(MS.Internal.Xml.XPath.AstNode value);
                    /*0x7723b58*/ string get_Prefix();
                    /*0x7723b60*/ string get_Name();
                    /*0x7723b68*/ System.Xml.XPath.XPathNodeType get_NodeType();
                    /*0x7723b70*/ MS.Internal.Xml.XPath.Axis.AxisType get_TypeOfAxis();
                    /*0x7723b78*/ bool get_AbbrAxis();
                    /*0x7723b80*/ string get_Urn();
                    /*0x7723b88*/ void set_Urn(string value);

                    enum AxisType
                    {
                        Ancestor = 0,
                        AncestorOrSelf = 1,
                        Attribute = 2,
                        Child = 3,
                        Descendant = 4,
                        DescendantOrSelf = 5,
                        Following = 6,
                        FollowingSibling = 7,
                        Namespace = 8,
                        Parent = 9,
                        Preceding = 10,
                        PrecedingSibling = 11,
                        Self = 12,
                        None = 13,
                    }
                }

                class Filter : MS.Internal.Xml.XPath.AstNode
                {
                    /*0x10*/ MS.Internal.Xml.XPath.AstNode _input;
                    /*0x18*/ MS.Internal.Xml.XPath.AstNode _condition;

                    /*0x7723b90*/ Filter(MS.Internal.Xml.XPath.AstNode input, MS.Internal.Xml.XPath.AstNode condition);
                    /*0x7723bd4*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x7723bdc*/ System.Xml.XPath.XPathResultType get_ReturnType();
                }

                class Function : MS.Internal.Xml.XPath.AstNode
                {
                    static /*0x0*/ System.Xml.XPath.XPathResultType[] ReturnTypes;
                    /*0x10*/ MS.Internal.Xml.XPath.Function.FunctionType _functionType;
                    /*0x18*/ System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> _argumentList;
                    /*0x20*/ string _name;
                    /*0x28*/ string _prefix;

                    static /*0x7723ef8*/ Function();
                    /*0x7723be4*/ Function(MS.Internal.Xml.XPath.Function.FunctionType ftype, System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> argumentList);
                    /*0x7723c84*/ Function(string prefix, string name, System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> argumentList);
                    /*0x7723d4c*/ Function(MS.Internal.Xml.XPath.Function.FunctionType ftype, MS.Internal.Xml.XPath.AstNode arg);
                    /*0x7723e70*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x7723e78*/ System.Xml.XPath.XPathResultType get_ReturnType();

                    enum FunctionType
                    {
                        FuncLast = 0,
                        FuncPosition = 1,
                        FuncCount = 2,
                        FuncID = 3,
                        FuncLocalName = 4,
                        FuncNameSpaceUri = 5,
                        FuncName = 6,
                        FuncString = 7,
                        FuncBoolean = 8,
                        FuncNumber = 9,
                        FuncTrue = 10,
                        FuncFalse = 11,
                        FuncNot = 12,
                        FuncConcat = 13,
                        FuncStartsWith = 14,
                        FuncContains = 15,
                        FuncSubstringBefore = 16,
                        FuncSubstringAfter = 17,
                        FuncSubstring = 18,
                        FuncStringLength = 19,
                        FuncNormalize = 20,
                        FuncTranslate = 21,
                        FuncLang = 22,
                        FuncSum = 23,
                        FuncFloor = 24,
                        FuncCeiling = 25,
                        FuncRound = 26,
                        FuncUserDefined = 27,
                    }
                }

                class Group : MS.Internal.Xml.XPath.AstNode
                {
                    /*0x10*/ MS.Internal.Xml.XPath.AstNode _groupNode;

                    /*0x7723f98*/ Group(MS.Internal.Xml.XPath.AstNode groupNode);
                    /*0x7723fc8*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x7723fd0*/ System.Xml.XPath.XPathResultType get_ReturnType();
                }

                class Operand : MS.Internal.Xml.XPath.AstNode
                {
                    /*0x10*/ System.Xml.XPath.XPathResultType _type;
                    /*0x18*/ object _val;

                    /*0x7723fd8*/ Operand(string val);
                    /*0x7724010*/ Operand(double val);
                    /*0x7724060*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x7724068*/ System.Xml.XPath.XPathResultType get_ReturnType();
                }

                class Operator : MS.Internal.Xml.XPath.AstNode
                {
                    static /*0x0*/ MS.Internal.Xml.XPath.Operator.Op[] s_invertOp;
                    /*0x10*/ MS.Internal.Xml.XPath.Operator.Op _opType;
                    /*0x18*/ MS.Internal.Xml.XPath.AstNode _opnd1;
                    /*0x20*/ MS.Internal.Xml.XPath.AstNode _opnd2;

                    static /*0x77240f0*/ Operator();
                    /*0x7724070*/ Operator(MS.Internal.Xml.XPath.Operator.Op op, MS.Internal.Xml.XPath.AstNode opnd1, MS.Internal.Xml.XPath.AstNode opnd2);
                    /*0x77240c4*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x77240cc*/ System.Xml.XPath.XPathResultType get_ReturnType();

                    enum Op
                    {
                        INVALID = 0,
                        OR = 1,
                        AND = 2,
                        EQ = 3,
                        NE = 4,
                        LT = 5,
                        LE = 6,
                        GT = 7,
                        GE = 8,
                        PLUS = 9,
                        MINUS = 10,
                        MUL = 11,
                        DIV = 12,
                        MOD = 13,
                        UNION = 14,
                    }
                }

                class Root : MS.Internal.Xml.XPath.AstNode
                {
                    /*0x7724190*/ Root();
                    /*0x7724198*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x77241a0*/ System.Xml.XPath.XPathResultType get_ReturnType();
                }

                class Variable : MS.Internal.Xml.XPath.AstNode
                {
                    /*0x10*/ string _localname;
                    /*0x18*/ string _prefix;

                    /*0x77241a8*/ Variable(string name, string prefix);
                    /*0x77241ec*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x77241f4*/ System.Xml.XPath.XPathResultType get_ReturnType();
                }

                class XPathParser
                {
                    static /*0x0*/ System.Xml.XPath.XPathResultType[] s_temparray1;
                    static /*0x8*/ System.Xml.XPath.XPathResultType[] s_temparray2;
                    static /*0x10*/ System.Xml.XPath.XPathResultType[] s_temparray3;
                    static /*0x18*/ System.Xml.XPath.XPathResultType[] s_temparray4;
                    static /*0x20*/ System.Xml.XPath.XPathResultType[] s_temparray5;
                    static /*0x28*/ System.Xml.XPath.XPathResultType[] s_temparray6;
                    static /*0x30*/ System.Xml.XPath.XPathResultType[] s_temparray7;
                    static /*0x38*/ System.Xml.XPath.XPathResultType[] s_temparray8;
                    static /*0x40*/ System.Xml.XPath.XPathResultType[] s_temparray9;
                    static /*0x48*/ System.Collections.Generic.Dictionary<string, MS.Internal.Xml.XPath.XPathParser.ParamInfo> s_functionTable;
                    static /*0x50*/ System.Collections.Generic.Dictionary<string, MS.Internal.Xml.XPath.Axis.AxisType> s_AxesTable;
                    /*0x10*/ MS.Internal.Xml.XPath.XPathScanner _scanner;
                    /*0x18*/ int _parseDepth;

                    static /*0x7727354*/ XPathParser();
                    static /*0x772422c*/ MS.Internal.Xml.XPath.AstNode ParseXPathExpression(string xpathExpression);
                    static /*0x7724da8*/ bool IsNodeType(MS.Internal.Xml.XPath.XPathScanner scaner);
                    static /*0x7725500*/ bool IsStep(MS.Internal.Xml.XPath.XPathScanner.LexKind lexKind);
                    static /*0x7724e9c*/ bool IsPrimaryExpr(MS.Internal.Xml.XPath.XPathScanner scanner);
                    static /*0x7726478*/ System.Collections.Generic.Dictionary<string, MS.Internal.Xml.XPath.XPathParser.ParamInfo> CreateFunctionTable();
                    static /*0x77270a4*/ System.Collections.Generic.Dictionary<string, MS.Internal.Xml.XPath.Axis.AxisType> CreateAxesTable();
                    /*0x77241fc*/ XPathParser(MS.Internal.Xml.XPath.XPathScanner scanner);
                    /*0x77243d4*/ MS.Internal.Xml.XPath.AstNode ParseExpression(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x7724438*/ MS.Internal.Xml.XPath.AstNode ParseOrExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x772451c*/ MS.Internal.Xml.XPath.AstNode ParseAndExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x7724664*/ MS.Internal.Xml.XPath.AstNode ParseEqualityExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x772473c*/ MS.Internal.Xml.XPath.AstNode ParseRelationalExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x772483c*/ MS.Internal.Xml.XPath.AstNode ParseAdditiveExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x7724914*/ MS.Internal.Xml.XPath.AstNode ParseMultiplicativeExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x7724a40*/ MS.Internal.Xml.XPath.AstNode ParseUnaryExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x7724b10*/ MS.Internal.Xml.XPath.AstNode ParseUnionExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x7724c10*/ MS.Internal.Xml.XPath.AstNode ParsePathExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x7724f4c*/ MS.Internal.Xml.XPath.AstNode ParseFilterExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x7725474*/ MS.Internal.Xml.XPath.AstNode ParsePredicate(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x77250f0*/ MS.Internal.Xml.XPath.AstNode ParseLocationPath(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x7724ffc*/ MS.Internal.Xml.XPath.AstNode ParseRelativeLocationPath(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x7725544*/ MS.Internal.Xml.XPath.AstNode ParseStep(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x77257d4*/ MS.Internal.Xml.XPath.AstNode ParseNodeTest(MS.Internal.Xml.XPath.AstNode qyInput, MS.Internal.Xml.XPath.Axis.AxisType axisType, System.Xml.XPath.XPathNodeType nodeType);
                    /*0x7725254*/ MS.Internal.Xml.XPath.AstNode ParsePrimaryExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x7725b30*/ MS.Internal.Xml.XPath.AstNode ParseMethod(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x7725acc*/ void CheckToken(MS.Internal.Xml.XPath.XPathScanner.LexKind t);
                    /*0x77254e0*/ void PassToken(MS.Internal.Xml.XPath.XPathScanner.LexKind t);
                    /*0x772464c*/ void NextLex();
                    /*0x7724600*/ bool TestOp(string op);
                    /*0x7724d4c*/ void CheckNodeSet(System.Xml.XPath.XPathResultType t);
                    /*0x77256ec*/ MS.Internal.Xml.XPath.Axis.AxisType GetAxis();

                    class ParamInfo
                    {
                        /*0x10*/ MS.Internal.Xml.XPath.Function.FunctionType _ftype;
                        /*0x14*/ int _minargs;
                        /*0x18*/ int _maxargs;
                        /*0x20*/ System.Xml.XPath.XPathResultType[] _argTypes;

                        /*0x7727058*/ ParamInfo(MS.Internal.Xml.XPath.Function.FunctionType ftype, int minargs, int maxargs, System.Xml.XPath.XPathResultType[] argTypes);
                        /*0x7727608*/ MS.Internal.Xml.XPath.Function.FunctionType get_FType();
                        /*0x7727610*/ int get_Minargs();
                        /*0x7727618*/ int get_Maxargs();
                        /*0x7727620*/ System.Xml.XPath.XPathResultType[] get_ArgTypes();
                    }
                }

                class XPathScanner
                {
                    /*0x10*/ string _xpathExpr;
                    /*0x18*/ int _xpathExprIndex;
                    /*0x1c*/ MS.Internal.Xml.XPath.XPathScanner.LexKind _kind;
                    /*0x20*/ char _currentChar;
                    /*0x28*/ string _name;
                    /*0x30*/ string _prefix;
                    /*0x38*/ string _stringValue;
                    /*0x40*/ double _numberValue;
                    /*0x48*/ bool _canBeFunction;
                    /*0x50*/ System.Xml.XmlCharType _xmlCharType;

                    /*0x7724320*/ XPathScanner(string xpathExpr);
                    /*0x7727688*/ string get_SourceText();
                    /*0x7727690*/ char get_CurrentChar();
                    /*0x7727628*/ bool NextChar();
                    /*0x7727698*/ MS.Internal.Xml.XPath.XPathScanner.LexKind get_Kind();
                    /*0x77276a0*/ string get_Name();
                    /*0x77276a8*/ string get_Prefix();
                    /*0x77276b0*/ string get_StringValue();
                    /*0x77276b8*/ double get_NumberValue();
                    /*0x77276c0*/ bool get_CanBeFunction();
                    /*0x77276c8*/ void SkipSpace();
                    /*0x7726094*/ bool NextLex();
                    /*0x7727864*/ double ScanNumber();
                    /*0x7727704*/ double ScanFraction();
                    /*0x77277b4*/ string ScanString();
                    /*0x772793c*/ string ScanName();

                    enum LexKind
                    {
                        Comma = 44,
                        Slash = 47,
                        At = 64,
                        Dot = 46,
                        LParens = 40,
                        RParens = 41,
                        LBracket = 91,
                        RBracket = 93,
                        Star = 42,
                        Plus = 43,
                        Minus = 45,
                        Eq = 61,
                        Lt = 60,
                        Gt = 62,
                        Bang = 33,
                        Dollar = 36,
                        Apos = 39,
                        Quote = 34,
                        Union = 124,
                        Ne = 78,
                        Le = 76,
                        Ge = 71,
                        And = 65,
                        Or = 79,
                        DotDot = 68,
                        SlashSlash = 83,
                        Name = 110,
                        String = 115,
                        Number = 100,
                        Axe = 97,
                        Eof = 69,
                    }
                }
            }

            namespace Cache
            {
                class XPathDocumentNavigator : System.Xml.XPath.XPathNavigator, System.Xml.IXmlLineInfo
                {
                    /*0x10*/ MS.Internal.Xml.Cache.XPathNode[] _pageCurrent;
                    /*0x18*/ MS.Internal.Xml.Cache.XPathNode[] _pageParent;
                    /*0x20*/ int _idxCurrent;
                    /*0x24*/ int _idxParent;

                    /*0x77279b4*/ XPathDocumentNavigator(MS.Internal.Xml.Cache.XPathNode[] pageCurrent, int idxCurrent, MS.Internal.Xml.Cache.XPathNode[] pageParent, int idxParent);
                    /*0x7727a54*/ string get_Value();
                    /*0x7727e60*/ System.Xml.XPath.XPathNavigator Clone();
                    /*0x7727ed4*/ System.Xml.XPath.XPathNodeType get_NodeType();
                    /*0x7727f18*/ string get_LocalName();
                    /*0x7727f70*/ string get_NamespaceURI();
                    /*0x7727fc8*/ string get_Prefix();
                    /*0x7728020*/ System.Xml.XmlNameTable get_NameTable();
                    /*0x7728080*/ bool MoveToFirstNamespace(System.Xml.XPath.XPathNamespaceScope namespaceScope);
                    /*0x772839c*/ bool MoveToNextNamespace(System.Xml.XPath.XPathNamespaceScope scope);
                    /*0x7728518*/ bool MoveToParent();
                    /*0x7728600*/ bool IsSamePosition(System.Xml.XPath.XPathNavigator other);
                    /*0x77286a4*/ object get_UnderlyingObject();
                    /*0x77286b4*/ bool HasLineInfo();
                    /*0x77286f8*/ int get_LineNumber();
                    /*0x77287a4*/ int get_LinePosition();
                    /*0x7728898*/ int GetPositionHashCode();
                }

                struct XPathNode
                {
                    /*0x10*/ MS.Internal.Xml.Cache.XPathNodeInfoAtom _info;
                    /*0x18*/ ushort _idxSibling;
                    /*0x1a*/ ushort _idxParent;
                    /*0x1c*/ ushort _idxSimilar;
                    /*0x1e*/ ushort _posOffset;
                    /*0x20*/ uint _props;
                    /*0x28*/ string _value;

                    /*0x7727f0c*/ System.Xml.XPath.XPathNodeType get_NodeType();
                    /*0x7728004*/ string get_Prefix();
                    /*0x7727f54*/ string get_LocalName();
                    /*0x7727fac*/ string get_NamespaceUri();
                    /*0x7728064*/ System.Xml.XPath.XPathDocument get_Document();
                    /*0x772877c*/ int get_LineNumber();
                    /*0x7728874*/ int get_LinePosition();
                    /*0x7728848*/ int get_CollapsedLinePosition();
                    /*0x77288a4*/ MS.Internal.Xml.Cache.XPathNodePageInfo get_PageInfo();
                    /*0x77284e4*/ int GetParent(ref MS.Internal.Xml.Cache.XPathNode[] pageNode);
                    /*0x7728368*/ int GetSibling(ref MS.Internal.Xml.Cache.XPathNode[] pageNode);
                    /*0x77282e0*/ bool get_IsXmlNamespaceNode();
                    /*0x77288c0*/ bool get_HasSibling();
                    /*0x77288d0*/ bool get_HasCollapsedText();
                    /*0x77288dc*/ bool get_IsText();
                    /*0x7728938*/ bool get_HasNamespaceDecls();
                    /*0x7728944*/ string get_Value();
                }

                struct XPathNodeRef
                {
                    /*0x10*/ MS.Internal.Xml.Cache.XPathNode[] _page;
                    /*0x18*/ int _idx;

                    /*0x772894c*/ XPathNodeRef(MS.Internal.Xml.Cache.XPathNode[] page, int idx);
                    /*0x7728974*/ MS.Internal.Xml.Cache.XPathNode[] get_Page();
                    /*0x772897c*/ int get_Index();
                    /*0x7728984*/ int GetHashCode();
                }

                class XPathNodeHelper
                {
                    static /*0x7728190*/ int GetLocalNamespaces(MS.Internal.Xml.Cache.XPathNode[] pageElem, int idxElem, ref MS.Internal.Xml.Cache.XPathNode[] pageNmsp);
                    static /*0x7728200*/ int GetInScopeNamespaces(MS.Internal.Xml.Cache.XPathNode[] pageElem, int idxElem, ref MS.Internal.Xml.Cache.XPathNode[] pageNmsp);
                    static /*0x7728580*/ bool GetParent(ref MS.Internal.Xml.Cache.XPathNode[] pageNode, ref int idxNode);
                    static /*0x7728994*/ int GetLocation(MS.Internal.Xml.Cache.XPathNode[] pageNode, int idxNode);
                    static /*0x7727cf4*/ bool GetTextFollowing(ref MS.Internal.Xml.Cache.XPathNode[] pageCurrent, ref int idxCurrent, MS.Internal.Xml.Cache.XPathNode[] pageEnd, int idxEnd);
                    static /*0x7727c44*/ bool GetNonDescendant(ref MS.Internal.Xml.Cache.XPathNode[] pageNode, ref int idxNode);
                }

                class XPathNodePageInfo
                {
                    /*0x10*/ int _pageNum;
                    /*0x14*/ int _nodeCount;
                    /*0x18*/ MS.Internal.Xml.Cache.XPathNode[] _pageNext;

                    /*0x77289cc*/ int get_PageNumber();
                    /*0x77289d4*/ int get_NodeCount();
                    /*0x77289dc*/ MS.Internal.Xml.Cache.XPathNode[] get_NextPage();
                }

                class XPathNodeInfoAtom
                {
                    /*0x10*/ string _localName;
                    /*0x18*/ string _namespaceUri;
                    /*0x20*/ string _prefix;
                    /*0x28*/ MS.Internal.Xml.Cache.XPathNode[] _pageParent;
                    /*0x30*/ MS.Internal.Xml.Cache.XPathNode[] _pageSibling;
                    /*0x38*/ System.Xml.XPath.XPathDocument _doc;
                    /*0x40*/ int _lineNumBase;
                    /*0x44*/ int _linePosBase;
                    /*0x48*/ MS.Internal.Xml.Cache.XPathNodePageInfo _pageInfo;

                    /*0x77289e4*/ MS.Internal.Xml.Cache.XPathNodePageInfo get_PageInfo();
                    /*0x77289ec*/ string get_LocalName();
                    /*0x77289f4*/ string get_NamespaceUri();
                    /*0x77289fc*/ string get_Prefix();
                    /*0x7728a04*/ MS.Internal.Xml.Cache.XPathNode[] get_SiblingPage();
                    /*0x7728a0c*/ MS.Internal.Xml.Cache.XPathNode[] get_ParentPage();
                    /*0x7728a14*/ System.Xml.XPath.XPathDocument get_Document();
                    /*0x7728a1c*/ int get_LineNumberBase();
                    /*0x7728a24*/ int get_LinePositionBase();
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 0C682AB2EF0F1E326972C95528BBDE965F5D2DA9232E7A946F6E8A978A2871B5;
    static /*0x44*/ <PrivateImplementationDetails> 11047585FE102FBB5CADB42446612A578D88C6EF5ED076BB7AC360C4F9E4373D;
    static /*0x50*/ <PrivateImplementationDetails> 21AFB7EF8B4B88C006C54601484BC15AE5A8DBD2C0DD8C6622109208F8511B82;
    static /*0x410*/ <PrivateImplementationDetails> 24F70FC64555D9B7646AD4C0EEB8DF5286779F0E39C15ACA61305BC4A5E40BE6;
    static /*0x438*/ <PrivateImplementationDetails> 28045F5AB2D9A9593F1D95B0FCB77E7F5F5435DD654BAFEF68972344B51C71BD;
    static /*0x4c8*/ <PrivateImplementationDetails> 28057B619BAF672A05E1585ED28F174E67FE946D81BDAA0691F07AB772057B02;
    static /*0x538*/ <PrivateImplementationDetails> 2809A17B374DF1926EA539548F5B3750AA8ADB2BD59F5066AD6F9D439A231122;
    static /*0x9f4*/ <PrivateImplementationDetails> 2AE470BFECE0EB971895252403237B3B989F74AD83E2B858E9CEA0482E776123;
    static /*0xa08*/ <PrivateImplementationDetails> 2BA62518D59E3AF30E09E458218C4A05E5DFA2949B8B8F9B5E68CC793DBFA882;
    static /*0xa30*/ <PrivateImplementationDetails> 2D902EC9D8EA71E1193C1C8315B1553D5154744F651BD366F1E1F437F6594A94;
    static /*0xa54*/ <PrivateImplementationDetails> 3B3045573362001FA1CDA1F381A331DB2A88DD59FDD9C497404D59995AA377EA;
    static /*0xa60*/ <PrivateImplementationDetails> 3EB9B3AB77D567D5CEBF38C4C91CDF79845F0691D47A516CE6981BF091025179;
    static /*0xa78*/ <PrivateImplementationDetails> 499E4F5C84E20C7347E10100E0EC90C1945EA21C7C80809E4F7F474179B39DF6;
    static /*0xa94*/ <PrivateImplementationDetails> 540CD885F06B2760118EA5544E069ACE0C5D184B85D9D104417C14F1E536376D;
    static /*0xaba*/ <PrivateImplementationDetails> 58E18897FE5FF048E82310FB4F57ADB2D53AEE59CB49B1E7094439808A1EF3F6;
    static /*0xafe*/ <PrivateImplementationDetails> 5B7F03A977BE72EBD5C1702238238AEB01DFFB019B05EFAAC147EF886732EDC7;
    static /*0xb0a*/ <PrivateImplementationDetails> 652CA39E9310E001C2C4AF271610032A5638C58598F727066CCF4E666D424CD4;
    static /*0xb2a*/ <PrivateImplementationDetails> 6536D9B2447DFCF9BA37F9E5A7FAB08CB5552C5AD5B20E019AEC4872283A542A;
    static /*0xb4e*/ <PrivateImplementationDetails> 77186ED8B389D5640B5AFAC4A22526ABA2422DCBE2986D0032E3B035D175758D;
    static /*0xf10*/ long 8A36CBC1D17EC6E1CCFE7D67F79FA9C8B2D7A41B04DD58A76970CEDC8189210D;
    static /*0xf18*/ <PrivateImplementationDetails> 8D4DC488705859D6A837A660BDBA9E88D1BD229BC39DB97734072D04BD513ECD;
    static /*0xf3c*/ <PrivateImplementationDetails> 92E9BC30656BF079FC6B0A200B019FF46941857D786F4C391470394CFDC95F0B;
    static /*0xf5c*/ <PrivateImplementationDetails> 9DA6B2C4638D1DC7611B7F458BBFE7FD49FE1B36B67239B00B8A051F4E49558F;
    static /*0xf7c*/ <PrivateImplementationDetails> AD6E77E234021D825C77689D82D414CDA3ABAE1ACC346D4BA2D6B1876CFC5FBC;
    static /*0xfbc*/ <PrivateImplementationDetails> B21FC5E8DB69C99CDEFB2C460E7C26D2D29A5ADC302365C59766D13688236919;
    static /*0xfd0*/ <PrivateImplementationDetails> B6E5AC1B0927F4259775820D36453E7BD957F110874896C133234263D312D88E;
    static /*0xffc*/ <PrivateImplementationDetails> C332DD23F2CF4DE6107A93045ACACD787E2D9EB18B213298B98F23357F4FEA41;
    static /*0x100c*/ <PrivateImplementationDetails> C3B2BED2599F3C79640DE44BA4EC7AEBB4856DBF74059DF382CF1D3026D272DA;
    static /*0x1018*/ <PrivateImplementationDetails> D1D9AF18AFC4E3074AF5E4C44B81B73889D033D7AF6DFEB387BBCC76B36FE8B9;
    static /*0x11b8*/ <PrivateImplementationDetails> DA285BBFE8FD0AA22C7CB92A1E911A4206CEDB14132FE3B6EE4DB32A42CAA41D;
    static /*0x11d0*/ long DACC0E6568D9B10337A1A693F10D42C3175E80C378154406C6FBFA989F919F51;
    static /*0x11d8*/ <PrivateImplementationDetails> DB047CC748613CCCB120DE7385E37D542A79C3BF8F0E64FE6DAD349B4D26E5D7;
    static /*0x1210*/ <PrivateImplementationDetails> DB7DD2341DB9D4574E432AAAFF03FB0A3E8FF2F645A337077EDF0C6FE902E660;
    static /*0x13b0*/ <PrivateImplementationDetails> DBBF94CCF4250B303976041627BB8FC302CE57D55373C469F41F97318412037D;
    static /*0x13b6*/ <PrivateImplementationDetails> DD4E9C7C140CABCA5A25F4DA1F6F5BAC5D74E4568F954BF728471E711A35163E;
    static /*0x164e*/ <PrivateImplementationDetails> EC3DA4AD81BE65581D24158F5E1FCDA45D908C27EC29FDFA744995062C501501;
    static /*0x165e*/ <PrivateImplementationDetails> EE2DCBE09BA7FF21BF36DD7FC218E094C9B3EF228148D28D21D77A0FE51553C6;
    static /*0x1676*/ <PrivateImplementationDetails> F1A5C5E949D525C31B086947AF16513F4999646B513457629847081D039048ED;
    static /*0x1686*/ <PrivateImplementationDetails> FFF813C50ED1BEC943E2CA58860CC34E0A14A5C0E858B97C7670A384005CC064;

    static /*0x7728a2c*/ uint ComputeStringHash(string s);

    struct __StaticArrayInitTypeSize=6
    {
    }

    struct __StaticArrayInitTypeSize=12
    {
    }

    struct __StaticArrayInitTypeSize=16
    {
    }

    struct __StaticArrayInitTypeSize=20
    {
    }

    struct __StaticArrayInitTypeSize=24
    {
    }

    struct __StaticArrayInitTypeSize=28
    {
    }

    struct __StaticArrayInitTypeSize=32
    {
    }

    struct __StaticArrayInitTypeSize=36
    {
    }

    struct __StaticArrayInitTypeSize=38
    {
    }

    struct __StaticArrayInitTypeSize=40
    {
    }

    struct __StaticArrayInitTypeSize=44
    {
    }

    struct __StaticArrayInitTypeSize=56
    {
    }

    struct __StaticArrayInitTypeSize=64
    {
    }

    struct __StaticArrayInitTypeSize=68
    {
    }

    struct __StaticArrayInitTypeSize=112
    {
    }

    struct __StaticArrayInitTypeSize=144
    {
    }

    struct __StaticArrayInitTypeSize=416
    {
    }

    struct __StaticArrayInitTypeSize=664
    {
    }

    struct __StaticArrayInitTypeSize=960
    {
    }

    struct __StaticArrayInitTypeSize=1212
    {
    }
}
