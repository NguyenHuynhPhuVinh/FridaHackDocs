class <Module>
{
}

class SR
{
    static /*0x761ea70*/ string GetString(string name, object[] args);
    static /*0x761eae0*/ string GetString(System.Globalization.CultureInfo culture, string name, object[] args);
}

namespace Microsoft
{
    namespace CSharp
    {
        class CodeDomProvider
        {
            /*0x761eae8*/ CodeDomProvider();
        }

        class CSharpCodeProvider : Microsoft.CSharp.CodeDomProvider
        {
            /*0x761eaf0*/ CSharpCodeProvider();
        }
    }
}

namespace System
{
    class MonoTODOAttribute : System.Attribute
    {
        /*0x761eaf8*/ MonoTODOAttribute();
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

            static /*0x761eb00*/ AsyncHelper();
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

            static /*0x761f378*/ Base64Decoder();
            static /*0x761f250*/ byte[] ConstructMapBase64();
            /*0x761f370*/ Base64Decoder();
            /*0x761ec18*/ int get_DecodedCount();
            /*0x761ec24*/ bool get_IsFull();
            /*0x761ec34*/ int Decode(char[] chars, int startPos, int len);
            /*0x761f018*/ int Decode(string str, int startPos, int len);
            /*0x761f178*/ void Reset();
            /*0x761f180*/ void SetNextOutputBuffer(System.Array buffer, int index, int count);
            /*0x761ed80*/ void Decode(char* pChars, char* pCharsEndPos, byte* pBytes, byte* pBytesEndPos, ref int charsDecoded, ref int bytesDecoded);
        }

        class Base64Encoder
        {
            /*0x10*/ byte[] leftOverBytes;
            /*0x18*/ int leftOverBytesCount;
            /*0x20*/ char[] charsLine;

            /*0x761f400*/ Base64Encoder();
            void WriteChars(char[] chars, int index, int count);
            /*0x761f464*/ void Encode(byte[] buffer, int index, int count);
            /*0x761f7bc*/ void Flush();
        }

        class XmlRawWriterBase64Encoder : System.Xml.Base64Encoder
        {
            /*0x28*/ System.Xml.XmlRawWriter rawWriter;

            /*0x761f864*/ XmlRawWriterBase64Encoder(System.Xml.XmlRawWriter rawWriter);
            /*0x761f890*/ void WriteChars(char[] chars, int index, int count);
        }

        class XmlTextWriterBase64Encoder : System.Xml.Base64Encoder
        {
            /*0x28*/ System.Xml.XmlTextEncoder xmlTextEncoder;

            /*0x761f8b4*/ XmlTextWriterBase64Encoder(System.Xml.XmlTextEncoder xmlTextEncoder);
            /*0x761f8e0*/ void WriteChars(char[] chars, int index, int count);
        }

        class BinHexDecoder : System.Xml.IncrementalReadDecoder
        {
            /*0x10*/ byte[] buffer;
            /*0x18*/ int startIndex;
            /*0x1c*/ int curIndex;
            /*0x20*/ int endIndex;
            /*0x24*/ bool hasHalfByteCached;
            /*0x25*/ byte cachedHalfByte;

            static /*0x761fe6c*/ byte[] Decode(char[] chars, bool allowOddChars);
            static /*0x761fa64*/ void Decode(char* pChars, char* pCharsEndPos, byte* pBytes, byte* pBytesEndPos, ref bool hasHalfByteCached, ref byte cachedHalfByte, ref int charsDecoded, ref int bytesDecoded);
            /*0x762004c*/ BinHexDecoder();
            /*0x761f8fc*/ int get_DecodedCount();
            /*0x761f908*/ bool get_IsFull();
            /*0x761f918*/ int Decode(char[] chars, int startPos, int len);
            /*0x761fc2c*/ int Decode(string str, int startPos, int len);
            /*0x761fd94*/ void Reset();
            /*0x761fd9c*/ void SetNextOutputBuffer(System.Array buffer, int index, int count);
        }

        class BinHexEncoder
        {
            static /*0x7620054*/ void Encode(byte[] buffer, int index, int count, System.Xml.XmlWriter writer);
            static /*0x7620314*/ string Encode(byte[] inArray, int offsetIn, int count);
            static /*0x76201f0*/ int Encode(byte[] inArray, int offsetIn, int count, char[] outArray);
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

            static /*0x7620e50*/ BinXmlSqlDecimal();
            static /*0x7620700*/ uint UIntFromByteArray(byte[] data, int offset);
            static /*0x762093c*/ void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, ref uint iulR);
            static /*0x7620a14*/ void MpNormalize(uint[] rgulU, ref int ciulU);
            static /*0x7620a6c*/ char ChFromDigit(uint uiDigit);
            /*0x7620464*/ BinXmlSqlDecimal(byte[] data, int offset, bool trim);
            /*0x7620454*/ bool get_IsPositive();
            /*0x7620a74*/ decimal ToDecimal();
            /*0x7620774*/ void TrimTrailingZeros();
            /*0x7620b8c*/ string ToString();
        }

        struct BinXmlSqlMoney
        {
            /*0x10*/ long data;

            /*0x7620f94*/ BinXmlSqlMoney(int v);
            /*0x7620fa0*/ BinXmlSqlMoney(long v);
            /*0x7620fa8*/ decimal ToDecimal();
            /*0x762100c*/ string ToString();
        }

        class BinXmlDateTime
        {
            static /*0x0*/ int[] KatmaiTimeScaleMultiplicator;
            static /*0x8*/ double SQLTicksPerMillisecond;
            static /*0x10*/ int SQLTicksPerSecond;
            static /*0x14*/ int SQLTicksPerMinute;
            static /*0x18*/ int SQLTicksPerHour;
            static /*0x1c*/ int SQLTicksPerDay;

            static /*0x7623774*/ BinXmlDateTime();
            static /*0x76210fc*/ void Write2Dig(System.Text.StringBuilder sb, int val);
            static /*0x7621158*/ void Write4DigNeg(System.Text.StringBuilder sb, int val);
            static /*0x76211fc*/ void Write3Dec(System.Text.StringBuilder sb, int val);
            static /*0x76212a8*/ void WriteDate(System.Text.StringBuilder sb, int yr, int mnth, int day);
            static /*0x762135c*/ void WriteTime(System.Text.StringBuilder sb, int hr, int min, int sec, int ms);
            static /*0x7621448*/ void WriteTimeFullPrecision(System.Text.StringBuilder sb, int hr, int min, int sec, int fraction);
            static /*0x762163c*/ void WriteTimeZone(System.Text.StringBuilder sb, System.TimeSpan zone);
            static /*0x7621738*/ void WriteTimeZone(System.Text.StringBuilder sb, bool negTimeZone, int hr, int min);
            static /*0x762180c*/ void BreakDownXsdDateTime(long val, ref int yr, ref int mnth, ref int day, ref int hr, ref int min, ref int sec, ref int ms);
            static /*0x76219dc*/ void BreakDownXsdDate(long val, ref int yr, ref int mnth, ref int day, ref bool negTimeZone, ref int hr, ref int min);
            static /*0x7621b4c*/ void BreakDownXsdTime(long val, ref int hr, ref int min, ref int sec, ref int ms);
            static /*0x7621c54*/ string XsdDateTimeToString(long val);
            static /*0x7621d5c*/ System.DateTime XsdDateTimeToDateTime(long val);
            static /*0x7621e10*/ string XsdDateToString(long val);
            static /*0x7621ef4*/ System.DateTime XsdDateToDateTime(long val);
            static /*0x7622040*/ string XsdTimeToString(long val);
            static /*0x7622114*/ System.DateTime XsdTimeToDateTime(long val);
            static /*0x76221b8*/ string SqlDateTimeToString(int dateticks, uint timeticks);
            static /*0x76222f8*/ System.DateTime SqlDateTimeToDateTime(int dateticks, uint timeticks);
            static /*0x76223ec*/ string SqlSmallDateTimeToString(short dateticks, ushort timeticks);
            static /*0x76224e0*/ System.DateTime SqlSmallDateTimeToDateTime(short dateticks, ushort timeticks);
            static /*0x7622554*/ System.DateTime XsdKatmaiDateToDateTime(byte[] data, int offset);
            static /*0x7622648*/ System.DateTime XsdKatmaiDateTimeToDateTime(byte[] data, int offset);
            static /*0x7622900*/ System.DateTime XsdKatmaiTimeToDateTime(byte[] data, int offset);
            static /*0x7622964*/ System.DateTime XsdKatmaiDateOffsetToDateTime(byte[] data, int offset);
            static /*0x7622a74*/ System.DateTime XsdKatmaiDateTimeOffsetToDateTime(byte[] data, int offset);
            static /*0x7622bc8*/ System.DateTime XsdKatmaiTimeOffsetToDateTime(byte[] data, int offset);
            static /*0x7622a10*/ System.DateTimeOffset XsdKatmaiDateOffsetToDateTimeOffset(byte[] data, int offset);
            static /*0x7622b20*/ System.DateTimeOffset XsdKatmaiDateTimeOffsetToDateTimeOffset(byte[] data, int offset);
            static /*0x7622c74*/ System.DateTimeOffset XsdKatmaiTimeOffsetToDateTimeOffset(byte[] data, int offset);
            static /*0x7622d2c*/ string XsdKatmaiDateToString(byte[] data, int offset);
            static /*0x7622e48*/ string XsdKatmaiDateTimeToString(byte[] data, int offset);
            static /*0x76230dc*/ string XsdKatmaiTimeToString(byte[] data, int offset);
            static /*0x762320c*/ string XsdKatmaiDateOffsetToString(byte[] data, int offset);
            static /*0x7623348*/ string XsdKatmaiDateTimeOffsetToString(byte[] data, int offset);
            static /*0x7623624*/ string XsdKatmaiTimeOffsetToString(byte[] data, int offset);
            static /*0x76225d4*/ long GetKatmaiDateTicks(byte[] data, ref int pos);
            static /*0x76226d8*/ long GetKatmaiTimeTicks(byte[] data, ref int pos);
            static /*0x7622cd8*/ long GetKatmaiTimeZoneTicks(byte[] data, int pos);
            static /*0x7622fc8*/ int GetFractions(System.DateTime dt);
            static /*0x76234e8*/ int GetFractions(System.DateTimeOffset dt);
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

            static /*0x762fb9c*/ XmlSqlBinaryReader();
            /*0x7623838*/ XmlSqlBinaryReader(System.IO.Stream stream, byte[] data, int len, string baseUri, bool closeInput, System.Xml.XmlReaderSettings settings);
            /*0x76249c4*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x7624ae0*/ System.Xml.XmlNodeType get_NodeType();
            /*0x7624ae8*/ string get_LocalName();
            /*0x7624af0*/ string get_NamespaceURI();
            /*0x7624af8*/ string get_Prefix();
            /*0x7624b00*/ string get_Value();
            /*0x76257bc*/ int get_Depth();
            /*0x7625860*/ string get_BaseURI();
            /*0x7625868*/ bool get_IsEmptyElement();
            /*0x762588c*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x762590c*/ string get_XmlLang();
            /*0x762599c*/ System.Type get_ValueType();
            /*0x76259a4*/ int get_AttributeCount();
            /*0x76259f8*/ string GetAttribute(string name, string ns);
            /*0x7625b54*/ string GetAttribute(string name);
            /*0x7625ca4*/ string GetAttribute(int i);
            /*0x7625d34*/ bool MoveToAttribute(string name, string ns);
            /*0x7625f10*/ bool MoveToAttribute(string name);
            /*0x7625f8c*/ void MoveToAttribute(int i);
            /*0x7626030*/ bool MoveToFirstAttribute();
            /*0x76260a8*/ bool MoveToNextAttribute();
            /*0x762612c*/ bool MoveToElement();
            /*0x76261fc*/ bool get_EOF();
            /*0x762620c*/ bool ReadAttributeValue();
            /*0x7626558*/ void Close();
            /*0x76265f8*/ System.Xml.XmlNameTable get_NameTable();
            /*0x7626600*/ string LookupNamespace(string prefix);
            /*0x76266b4*/ void ResolveEntity();
            /*0x76266ec*/ System.Xml.ReadState get_ReadState();
            /*0x762676c*/ bool Read();
            /*0x762717c*/ bool SetupContentAsXXX(string name);
            /*0x762736c*/ int FinishContentAsXXX(int origPos);
            /*0x76274b8*/ bool ReadContentAsBoolean();
            /*0x7627938*/ System.DateTime ReadContentAsDateTime();
            /*0x7628180*/ double ReadContentAsDouble();
            /*0x76287cc*/ float ReadContentAsFloat();
            /*0x7628cdc*/ decimal ReadContentAsDecimal();
            /*0x7629400*/ int ReadContentAsInt();
            /*0x7629b48*/ long ReadContentAsLong();
            /*0x762a06c*/ object ReadContentAsObject();
            /*0x762aa68*/ object ReadContentAs(System.Type returnType, System.Xml.IXmlNamespaceResolver namespaceResolver);
            /*0x762b5f8*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x762b9a0*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            /*0x762bb3c*/ void VerifyVersion(int requiredVersion, System.Xml.BinXmlToken token);
            /*0x7623d84*/ void AddInitNamespace(string prefix, string uri);
            /*0x762bbbc*/ void AddName();
            /*0x762bda8*/ void AddQName();
            /*0x762c0d4*/ void NameFlush();
            /*0x762c124*/ void SkipExtn();
            /*0x762c1f8*/ int ReadQNameRef();
            /*0x762c048*/ int ReadNameRef();
            /*0x762c284*/ bool FillAllowEOF();
            /*0x762c4c4*/ void Fill_(int require);
            /*0x762c1dc*/ void Fill(int require);
            /*0x762c5b0*/ byte ReadByte();
            /*0x762c60c*/ ushort ReadUShort();
            /*0x762c1b0*/ int ParseMB32();
            /*0x762c680*/ int ParseMB32_(byte b);
            /*0x762c718*/ int ParseMB32(int pos);
            /*0x762c804*/ int ParseMB64();
            /*0x762c830*/ System.Xml.BinXmlToken PeekToken();
            /*0x762c898*/ System.Xml.BinXmlToken ReadToken();
            /*0x762c908*/ System.Xml.BinXmlToken NextToken2(System.Xml.BinXmlToken token);
            /*0x762c980*/ System.Xml.BinXmlToken NextToken1();
            /*0x762c9f8*/ System.Xml.BinXmlToken NextToken();
            /*0x762ca5c*/ System.Xml.BinXmlToken PeekNextToken();
            /*0x7626384*/ System.Xml.BinXmlToken RescanNextToken();
            /*0x762bce4*/ string ParseText();
            /*0x762ca84*/ int ScanText(ref int start);
            /*0x7624c0c*/ string GetString(int pos, int cch);
            /*0x762cb3c*/ string GetStringAligned(byte[] data, int offset, int cch);
            /*0x7625698*/ string GetAttributeText(int i);
            /*0x7625ac8*/ int LocateAttribute(string name, string ns);
            /*0x7625bc0*/ int LocateAttribute(string name);
            /*0x7625e30*/ void PositionOnAttribute(int i);
            /*0x762cb68*/ void GrowElements();
            /*0x762cbf8*/ void GrowAttributes();
            /*0x762cc88*/ void ClearAttributes();
            /*0x762cc98*/ void PushNamespace(string prefix, string ns, bool implied);
            /*0x762cec8*/ void PopNamespaces(System.Xml.XmlSqlBinaryReader.NamespaceDecl firstInScopeChain);
            /*0x762cf94*/ void GenerateImpliedXmlnsAttrs();
            /*0x7626934*/ bool ReadInit(bool skipXmlDecl);
            /*0x762d0e8*/ void ScanAttributes();
            /*0x762d7c8*/ void SimpleCheckForDuplicateAttributes();
            /*0x762d930*/ void HashCheckForDuplicateAttributes();
            /*0x7624e7c*/ string XmlDeclValue();
            /*0x7624d6c*/ string CDATAValue();
            /*0x762db80*/ void FinishCDATA();
            /*0x762dc24*/ void FinishEndElement();
            /*0x7626e1c*/ bool ReadDoc();
            /*0x762e7fc*/ void ImplReadData(System.Xml.BinXmlToken tokenType);
            /*0x762dc80*/ void ImplReadElement();
            /*0x762df10*/ void ImplReadEndElement();
            /*0x762dff0*/ void ImplReadDoctype();
            /*0x762e2b4*/ void ImplReadPI();
            /*0x762e320*/ void ImplReadComment();
            /*0x762e34c*/ void ImplReadCDATA();
            /*0x762e380*/ void ImplReadNest();
            /*0x762e438*/ void ImplReadEndNest();
            /*0x762e488*/ void ImplReadXmlText();
            /*0x762e9e4*/ void UpdateFromTextReader();
            /*0x7625e14*/ bool UpdateFromTextReader(bool needUpdate);
            /*0x762e97c*/ void CheckAllowContent();
            /*0x7623e60*/ void GenerateTokenTypeMap();
            /*0x7626478*/ System.Type GetValueType(System.Xml.BinXmlToken token);
            /*0x762646c*/ void ReScanOverValue(System.Xml.BinXmlToken token);
            /*0x762d6a0*/ System.Xml.XmlNodeType ScanOverValue(System.Xml.BinXmlToken token, bool attr, bool checkChars);
            /*0x762ed18*/ System.Xml.XmlNodeType ScanOverAnyValue(System.Xml.BinXmlToken token, bool attr, bool checkChars);
            /*0x762eabc*/ System.Xml.XmlNodeType CheckText(bool attr);
            /*0x762ec80*/ System.Xml.XmlNodeType CheckTextIsWS();
            /*0x762f120*/ void CheckValueTokenBounds();
            /*0x762f038*/ int GetXsdKatmaiTokenLength(System.Xml.BinXmlToken token);
            /*0x762f180*/ int XsdKatmaiTimeScaleToValueLength(byte scale);
            /*0x7629950*/ long ValueAsLong();
            /*0x762f564*/ ulong ValueAsULong();
            /*0x7629214*/ decimal ValueAsDecimal();
            /*0x7628698*/ double ValueAsDouble();
            /*0x7627e5c*/ System.DateTime ValueAsDateTime();
            /*0x762f700*/ System.DateTimeOffset ValueAsDateTimeOffset();
            /*0x762f810*/ string ValueAsDateTimeString();
            /*0x7624fbc*/ string ValueAsString(System.Xml.BinXmlToken token);
            /*0x762a3d4*/ object ValueAsObject(System.Xml.BinXmlToken token, bool returnInternalTypes);
            /*0x762fb34*/ System.Xml.Schema.XmlValueConverter GetValueConverter(System.Xml.Schema.XmlTypeCode typeCode);
            /*0x762aed0*/ object ValueAs(System.Xml.BinXmlToken token, System.Type returnType, System.Xml.IXmlNamespaceResolver namespaceResolver);
            /*0x762f254*/ short GetInt16(int pos);
            /*0x762f3dc*/ ushort GetUInt16(int pos);
            /*0x762f298*/ int GetInt32(int pos);
            /*0x762f420*/ uint GetUInt32(int pos);
            /*0x762f30c*/ long GetInt64(int pos);
            /*0x762f494*/ ulong GetUInt64(int pos);
            /*0x762f5b4*/ float GetSingle(int offset);
            /*0x762f62c*/ double GetDouble(int offset);
            /*0x762bb74*/ System.Exception ThrowUnexpectedToken(System.Xml.BinXmlToken token);
            /*0x762c53c*/ System.Exception ThrowXmlException(string res);
            /*0x762d5b4*/ System.Exception ThrowXmlException(string res, string arg1, string arg2);
            /*0x7627434*/ System.Exception ThrowNotSupported(string res);

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

                static /*0x7639160*/ bool op_Equality(System.Xml.XmlSqlBinaryReader.QName a, System.Xml.XmlSqlBinaryReader.QName b);
                /*0x7638cfc*/ QName(string prefix, string lname, string nsUri);
                /*0x7638d40*/ void Set(string prefix, string lname, string nsUri);
                /*0x7638d84*/ void Clear();
                /*0x7638dd8*/ bool MatchNs(string lname, string nsUri);
                /*0x7638e28*/ bool MatchPrefix(string prefix, string lname);
                /*0x7638e78*/ void CheckPrefixNS(string prefix, string namespaceUri);
                /*0x7638f70*/ int GetHashCode();
                /*0x7638fb8*/ int GetNSHashCode(System.Xml.SecureStringHasher hasher);
                /*0x76390a8*/ bool Equals(object other);
                /*0x76391c0*/ string ToString();
            }

            struct ElemInfo
            {
                /*0x10*/ System.Xml.XmlSqlBinaryReader.QName name;
                /*0x28*/ string xmlLang;
                /*0x30*/ System.Xml.XmlSpace xmlSpace;
                /*0x34*/ bool xmlspacePreserve;
                /*0x38*/ System.Xml.XmlSqlBinaryReader.NamespaceDecl nsdecls;

                /*0x7639230*/ void Set(System.Xml.XmlSqlBinaryReader.QName name, bool xmlspacePreserve);
                /*0x763927c*/ System.Xml.XmlSqlBinaryReader.NamespaceDecl Clear();
            }

            struct AttrInfo
            {
                /*0x10*/ System.Xml.XmlSqlBinaryReader.QName name;
                /*0x28*/ string val;
                /*0x30*/ int contentPos;
                /*0x34*/ int hashCode;
                /*0x38*/ int prevHash;

                /*0x763929c*/ void Set(System.Xml.XmlSqlBinaryReader.QName n, string v);
                /*0x76392e8*/ void Set(System.Xml.XmlSqlBinaryReader.QName n, int pos);
                /*0x7639334*/ void GetLocalnameAndNamespaceUri(ref string localname, ref string namespaceUri);
                /*0x7639370*/ int GetLocalnameAndNamespaceUriAndHash(System.Xml.SecureStringHasher hasher, ref string localname, ref string namespaceUri);
                /*0x76393c0*/ bool MatchNS(string localname, string namespaceUri);
                /*0x76393c4*/ bool MatchHashNS(int hash, string localname, string namespaceUri);
                /*0x76393e4*/ void AdjustPosition(int adj);
            }

            class NamespaceDecl
            {
                /*0x10*/ string prefix;
                /*0x18*/ string uri;
                /*0x20*/ System.Xml.XmlSqlBinaryReader.NamespaceDecl scopeLink;
                /*0x28*/ System.Xml.XmlSqlBinaryReader.NamespaceDecl prevLink;
                /*0x30*/ int scope;
                /*0x34*/ bool implied;

                /*0x76393f8*/ NamespaceDecl(string prefix, string nsuri, System.Xml.XmlSqlBinaryReader.NamespaceDecl nextInScope, System.Xml.XmlSqlBinaryReader.NamespaceDecl prevDecl, int scope, bool implied);
            }

            struct SymbolTables
            {
                /*0x10*/ string[] symtable;
                /*0x18*/ int symCount;
                /*0x20*/ System.Xml.XmlSqlBinaryReader.QName[] qnametable;
                /*0x28*/ int qnameCount;

                /*0x7639488*/ void Init();
            }

            class NestedBinXml
            {
                /*0x10*/ System.Xml.XmlSqlBinaryReader.SymbolTables symbolTables;
                /*0x30*/ int docState;
                /*0x38*/ System.Xml.XmlSqlBinaryReader.NestedBinXml next;

                /*0x763955c*/ NestedBinXml(System.Xml.XmlSqlBinaryReader.SymbolTables symbolTables, int docState, System.Xml.XmlSqlBinaryReader.NestedBinXml next);
            }
        }

        class BitStack
        {
            /*0x10*/ uint[] bitStack;
            /*0x18*/ int stackPos;
            /*0x1c*/ uint curr;

            /*0x76395b4*/ BitStack();
            /*0x76395d4*/ void PushBit(bool bit);
            /*0x7639704*/ bool PopBit();
            /*0x7639770*/ bool PeekBit();
            /*0x763960c*/ void PushCurr();
            /*0x763972c*/ void PopCurr();
        }

        class Bits
        {
            static /*0x0*/ uint MASK_0101010101010101;
            static /*0x4*/ uint MASK_0011001100110011;
            static /*0x8*/ uint MASK_0000111100001111;
            static /*0xc*/ uint MASK_0000000011111111;
            static /*0x10*/ uint MASK_1111111111111111;

            static /*0x7639884*/ Bits();
            static /*0x763977c*/ int Count(uint num);
            static /*0x7639818*/ int LeastPosition(uint num);
        }

        class ByteStack
        {
            /*0x10*/ byte[] stack;
            /*0x18*/ int growthRate;
            /*0x1c*/ int top;
            /*0x20*/ int size;

            /*0x76398dc*/ ByteStack(int growthRate);
            /*0x7639958*/ void Push(byte data);
            /*0x7639a38*/ byte Pop();
        }

        class CharEntityEncoderFallback : System.Text.EncoderFallback
        {
            /*0x10*/ System.Xml.CharEntityEncoderFallbackBuffer fallbackBuffer;
            /*0x18*/ int[] textContentMarks;
            /*0x20*/ int endMarkPos;
            /*0x24*/ int curMarkPos;
            /*0x28*/ int startOffset;

            /*0x7639a80*/ CharEntityEncoderFallback();
            /*0x7639a88*/ System.Text.EncoderFallbackBuffer CreateFallbackBuffer();
            /*0x7639b54*/ int get_MaxCharCount();
            /*0x7639b5c*/ void set_StartOffset(int value);
            /*0x7639b64*/ void Reset(int[] textContentMarks, int endMarkPos);
            /*0x7639b90*/ bool CanReplaceAt(int index);
        }

        class CharEntityEncoderFallbackBuffer : System.Text.EncoderFallbackBuffer
        {
            /*0x30*/ System.Xml.CharEntityEncoderFallback parent;
            /*0x38*/ string charEntity;
            /*0x40*/ int charEntityIndex;

            /*0x7639afc*/ CharEntityEncoderFallbackBuffer(System.Xml.CharEntityEncoderFallback parent);
            /*0x7639c10*/ bool Fallback(char charUnknown, int index);
            /*0x7639e0c*/ bool Fallback(char charUnknownHigh, char charUnknownLow, int index);
            /*0x763a09c*/ char GetNextChar();
            /*0x763a0f4*/ bool MovePrevious();
            /*0x763a110*/ int get_Remaining();
            /*0x763a144*/ void Reset();
            /*0x763a08c*/ int SurrogateCharToUtf32(char highSurrogate, char lowSurrogate);
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

            /*0x763a150*/ HtmlEncodedRawTextWriter(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings);
            /*0x763a43c*/ HtmlEncodedRawTextWriter(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x763a770*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x763a774*/ void WriteXmlDeclaration(string xmldecl);
            /*0x763a778*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x763aa50*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x763ad5c*/ void StartElementContent();
            /*0x763aeb4*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x763b11c*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x763b31c*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x763b5ac*/ void WriteEndAttribute();
            /*0x763b6d0*/ void WriteProcessingInstruction(string target, string text);
            /*0x763bb00*/ void WriteString(string text);
            /*0x763bbbc*/ void WriteEntityRef(string name);
            /*0x763bc14*/ void WriteCharEntity(char ch);
            /*0x763bc6c*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x763bcc4*/ void WriteChars(char[] buffer, int index, int count);
            /*0x763a278*/ void Init(System.Xml.XmlWriterSettings settings);
            /*0x763adb0*/ void WriteMetaElement();
            /*0x763bbac*/ void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd);
            /*0x763bb6c*/ void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd);
            /*0x763c7d4*/ void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd);
            /*0x763c470*/ void WriteUriAttributeText(char* pSrc, char* pSrcEnd);
            /*0x763b63c*/ void OutputRestAmps();
        }

        class HtmlEncodedRawTextWriterIndent : System.Xml.HtmlEncodedRawTextWriter
        {
            /*0xec*/ int indentLevel;
            /*0xf0*/ int endBlockPos;
            /*0xf8*/ string indentChars;
            /*0x100*/ bool newLineOnAttributes;

            /*0x763cbe4*/ HtmlEncodedRawTextWriterIndent(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings);
            /*0x763cc58*/ HtmlEncodedRawTextWriterIndent(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x763cc8c*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x763cca8*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x763cea4*/ void StartElementContent();
            /*0x763cf14*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x763cfac*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x763d01c*/ void FlushBuffer();
            /*0x763cc18*/ void Init(System.Xml.XmlWriterSettings settings);
            /*0x763ce5c*/ void WriteIndent();
        }

        class HtmlTernaryTree
        {
            static /*0x0*/ byte[] htmlElements;
            static /*0x8*/ byte[] htmlAttributes;

            static /*0x763d250*/ HtmlTernaryTree();
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

            /*0x763d334*/ HtmlUtf8RawTextWriter(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x763d524*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x763d528*/ void WriteXmlDeclaration(string xmldecl);
            /*0x763d52c*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x763d774*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x763d87c*/ void StartElementContent();
            /*0x763d9f0*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x763dad4*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x763dbb8*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x763dd28*/ void WriteEndAttribute();
            /*0x763de64*/ void WriteProcessingInstruction(string target, string text);
            /*0x763df84*/ void WriteString(string text);
            /*0x763e030*/ void WriteEntityRef(string name);
            /*0x763e088*/ void WriteCharEntity(char ch);
            /*0x763e0e0*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x763e138*/ void WriteChars(char[] buffer, int index, int count);
            /*0x763d360*/ void Init(System.Xml.XmlWriterSettings settings);
            /*0x763d8d4*/ void WriteMetaElement();
            /*0x763e018*/ void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd);
            /*0x763dfd4*/ void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd);
            /*0x763e498*/ void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd);
            /*0x763e17c*/ void WriteUriAttributeText(char* pSrc, char* pSrcEnd);
            /*0x763dda0*/ void OutputRestAmps();
        }

        class HtmlUtf8RawTextWriterIndent : System.Xml.HtmlUtf8RawTextWriter
        {
            /*0xbc*/ int indentLevel;
            /*0xc0*/ int endBlockPos;
            /*0xc8*/ string indentChars;
            /*0xd0*/ bool newLineOnAttributes;

            /*0x763e6f0*/ HtmlUtf8RawTextWriterIndent(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x763e768*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x763e784*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x763e978*/ void StartElementContent();
            /*0x763e9ec*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x763ea84*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x763eaf8*/ void FlushBuffer();
            /*0x763e728*/ void Init(System.Xml.XmlWriterSettings settings);
            /*0x763e928*/ void WriteIndent();
        }

        interface IDtdInfo
        {
            /*0x380b9e8*/ System.Xml.XmlQualifiedName get_Name();
            /*0x380b9e8*/ string get_InternalDtdSubset();
            /*0x380b128*/ bool get_HasDefaultAttributes();
            /*0x380b128*/ bool get_HasNonCDataAttributes();
            /*0x380bcbc*/ System.Xml.IDtdAttributeListInfo LookupAttributeList(string prefix, string localName);
            /*0x380bb68*/ System.Xml.IDtdEntityInfo LookupEntity(string name);
        }

        interface IDtdAttributeListInfo
        {
            /*0x380b128*/ bool get_HasNonCDataAttributes();
            /*0x380bcbc*/ System.Xml.IDtdAttributeInfo LookupAttribute(string prefix, string localName);
            /*0x380b9e8*/ System.Collections.Generic.IEnumerable<System.Xml.IDtdDefaultAttributeInfo> LookupDefaultAttributes();
        }

        interface IDtdAttributeInfo
        {
            /*0x380b9e8*/ string get_Prefix();
            /*0x380b9e8*/ string get_LocalName();
            /*0x380b6a0*/ int get_LineNumber();
            /*0x380b6a0*/ int get_LinePosition();
            /*0x380b128*/ bool get_IsNonCDataType();
            /*0x380b128*/ bool get_IsDeclaredInExternal();
            /*0x380b128*/ bool get_IsXmlAttribute();
        }

        interface IDtdDefaultAttributeInfo : System.Xml.IDtdAttributeInfo
        {
            /*0x380b9e8*/ string get_DefaultValueExpanded();
            /*0x380b9e8*/ object get_DefaultValueTyped();
            /*0x380b6a0*/ int get_ValueLineNumber();
            /*0x380b6a0*/ int get_ValueLinePosition();
        }

        interface IDtdEntityInfo
        {
            /*0x380b9e8*/ string get_Name();
            /*0x380b128*/ bool get_IsExternal();
            /*0x380b128*/ bool get_IsDeclaredInExternal();
            /*0x380b128*/ bool get_IsUnparsedEntity();
            /*0x380b128*/ bool get_IsParameterEntity();
            /*0x380b9e8*/ string get_BaseUriString();
            /*0x380b9e8*/ string get_DeclaredUriString();
            /*0x380b9e8*/ string get_SystemId();
            /*0x380b9e8*/ string get_PublicId();
            /*0x380b9e8*/ string get_Text();
            /*0x380b6a0*/ int get_LineNumber();
            /*0x380b6a0*/ int get_LinePosition();
        }

        interface IDtdParser
        {
            /*0x380bba0*/ System.Xml.IDtdInfo ParseInternalDtd(System.Xml.IDtdParserAdapter adapter, bool saveInternalSubset);
            /*0x380bdf4*/ System.Xml.IDtdInfo ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, System.Xml.IDtdParserAdapter adapter);
        }

        interface IDtdParserAdapter
        {
            /*0x380b9e8*/ System.Xml.XmlNameTable get_NameTable();
            /*0x380b9e8*/ System.Xml.IXmlNamespaceResolver get_NamespaceResolver();
            /*0x380b9e8*/ System.Uri get_BaseUri();
            /*0x380b9e8*/ char[] get_ParsingBuffer();
            /*0x380b6a0*/ int get_ParsingBufferLength();
            /*0x380b6a0*/ int get_CurrentPosition();
            /*0x380cffc*/ void set_CurrentPosition(int value);
            /*0x380b6a0*/ int get_LineNo();
            /*0x380b6a0*/ int get_LineStartPosition();
            /*0x380b128*/ bool get_IsEof();
            /*0x380b6a0*/ int get_EntityStackLength();
            /*0x380b128*/ bool get_IsEntityEolNormalized();
            /*0x380b6a0*/ int ReadData();
            /*0x380cffc*/ void OnNewLine(int pos);
            /*0x380b7a8*/ int ParseNumericCharRef(System.Text.StringBuilder internalSubsetBuilder);
            int ParseNamedCharRef(bool expand, System.Text.StringBuilder internalSubsetBuilder);
            /*0x380d83c*/ void ParsePI(System.Text.StringBuilder sb);
            /*0x380d83c*/ void ParseComment(System.Text.StringBuilder sb);
            /*0x380b32c*/ bool PushEntity(System.Xml.IDtdEntityInfo entity, ref int entityId);
            /*0x380b32c*/ bool PopEntity(ref System.Xml.IDtdEntityInfo oldEntity, ref int newEntityId);
            /*0x380b32c*/ bool PushExternalSubset(string systemId, string publicId);
            /*0x380d93c*/ void PushInternalDtd(string baseUri, string internalDtd);
            void OnSystemId(string systemId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo systemLiteralLineInfo);
            void OnPublicId(string publicId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo publicLiteralLineInfo);
            /*0x380d83c*/ void Throw(System.Exception e);
        }

        interface IDtdParserAdapterWithValidation : System.Xml.IDtdParserAdapter
        {
            /*0x380b128*/ bool get_DtdValidation();
            /*0x380b9e8*/ System.Xml.IValidationEventHandling get_ValidationEventHandling();
        }

        interface IDtdParserAdapterV1 : System.Xml.IDtdParserAdapterWithValidation, System.Xml.IDtdParserAdapter
        {
            /*0x380b128*/ bool get_V1CompatibilityMode();
            /*0x380b128*/ bool get_Normalization();
            /*0x380b128*/ bool get_Namespaces();
        }

        class OnRemoveWriter : System.MulticastDelegate
        {
            /*0x763eb24*/ OnRemoveWriter(object object, nint method);
            /*0x763ec2c*/ void Invoke(System.Xml.XmlRawWriter writer);
        }

        interface IValidationEventHandling
        {
            /*0x380b9e8*/ object get_EventHandler();
            /*0x380d8b8*/ void SendEvent(System.Exception exception, System.Xml.Schema.XmlSeverityType severity);
        }

        class IncrementalReadDecoder
        {
            /*0x763ec40*/ IncrementalReadDecoder();
            /*0x380b6a0*/ int get_DecodedCount();
            /*0x380b128*/ bool get_IsFull();
            void SetNextOutputBuffer(System.Array array, int offset, int len);
            int Decode(char[] chars, int startPos, int len);
            int Decode(string str, int startPos, int len);
            /*0x380cb08*/ void Reset();
        }

        class IncrementalReadDummyDecoder : System.Xml.IncrementalReadDecoder
        {
            /*0x763ec70*/ IncrementalReadDummyDecoder();
            /*0x763ec48*/ int get_DecodedCount();
            /*0x763ec50*/ bool get_IsFull();
            /*0x763ec58*/ void SetNextOutputBuffer(System.Array array, int offset, int len);
            /*0x763ec5c*/ int Decode(char[] chars, int startPos, int len);
            /*0x763ec64*/ int Decode(string str, int startPos, int len);
            /*0x763ec6c*/ void Reset();
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

            /*0x763ec78*/ QueryOutputWriter(System.Xml.XmlRawWriter writer, System.Xml.XmlWriterSettings settings);
            /*0x763ef9c*/ void set_NamespaceResolver(System.Xml.IXmlNamespaceResolver value);
            /*0x763efe0*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x763f004*/ void WriteXmlDeclaration(string xmldecl);
            /*0x763f028*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x763f060*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x763f22c*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x763f29c*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x763f30c*/ void StartElementContent();
            /*0x763f330*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x763f35c*/ void WriteEndAttribute();
            /*0x763f388*/ void WriteNamespaceDeclaration(string prefix, string ns);
            /*0x763f3ac*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0x763f3d0*/ void WriteStartNamespaceDeclaration(string prefix);
            /*0x763f3f4*/ void WriteEndNamespaceDeclaration();
            /*0x763f418*/ void WriteCData(string text);
            /*0x763f43c*/ void WriteComment(string text);
            /*0x763f468*/ void WriteProcessingInstruction(string name, string text);
            /*0x763f494*/ void WriteWhitespace(string ws);
            /*0x763f540*/ void WriteString(string text);
            /*0x763f5b0*/ void WriteChars(char[] buffer, int index, int count);
            /*0x763f638*/ void WriteEntityRef(string name);
            /*0x763f664*/ void WriteCharEntity(char ch);
            /*0x763f690*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x763f6bc*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x763f744*/ void WriteRaw(string data);
            /*0x763f7b4*/ void Close();
            /*0x763f858*/ void Flush();
            /*0x763f504*/ bool StartCDataSection();
            /*0x763f224*/ void EndCDataSection();
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

            static /*0x763f928*/ System.Xml.ReadContentAsBinaryHelper CreateOrReset(System.Xml.ReadContentAsBinaryHelper helper, System.Xml.XmlReader reader);
            /*0x763f87c*/ ReadContentAsBinaryHelper(System.Xml.XmlReader reader);
            /*0x763f9a0*/ int ReadContentAsBase64(byte[] buffer, int index, int count);
            /*0x763fdac*/ int ReadContentAsBinHex(byte[] buffer, int index, int count);
            /*0x7640028*/ void Finish();
            /*0x763f994*/ void Reset();
            /*0x763fb8c*/ bool Init();
            /*0x763fd20*/ void InitBase64Decoder();
            /*0x763ff9c*/ void InitBinHexDecoder();
            /*0x763fbb8*/ int ReadContentAsBinary(byte[] buffer, int index, int count);
            /*0x7640164*/ bool MoveToNextContentNode(bool moveIfOnContentNode);

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

            /*0x763c2d8*/ TernaryTreeReadOnly(byte[] nodeBuffer);
            /*0x763ab68*/ byte FindCaseInsensitiveString(string stringToFind);
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

            static /*0x76403b0*/ int GetHashCodeOfString(string key, int sLen, long additionalEntropy);
            static /*0x7640278*/ System.Xml.SecureStringHasher.HashCodeOfStringDelegate GetHashCodeDelegate();
            /*0x764023c*/ SecureStringHasher();
            /*0x7640260*/ bool Equals(string x, string y);
            /*0x7638ffc*/ int GetHashCode(string key);

            class HashCodeOfStringDelegate : System.MulticastDelegate
            {
                /*0x764041c*/ HashCodeOfStringDelegate(object object, nint method);
                /*0x76404d0*/ int Invoke(string s, int sLen, long additionalEntropy);
            }
        }

        class TextEncodedRawTextWriter : System.Xml.XmlEncodedRawTextWriter
        {
            /*0x76404e4*/ TextEncodedRawTextWriter(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings);
            /*0x76404e8*/ TextEncodedRawTextWriter(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x76404ec*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x76404f0*/ void WriteXmlDeclaration(string xmldecl);
            /*0x76404f4*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x76404f8*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x76404fc*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x7640500*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x7640504*/ void StartElementContent();
            /*0x7640508*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x7640514*/ void WriteEndAttribute();
            /*0x764051c*/ void WriteNamespaceDeclaration(string prefix, string ns);
            /*0x7640520*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0x7640528*/ void WriteCData(string text);
            /*0x7640590*/ void WriteComment(string text);
            /*0x7640594*/ void WriteProcessingInstruction(string name, string text);
            /*0x7640598*/ void WriteEntityRef(string name);
            /*0x764059c*/ void WriteCharEntity(char ch);
            /*0x76405a0*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x76405a4*/ void WriteWhitespace(string ws);
            /*0x76405b4*/ void WriteString(string textBlock);
            /*0x76405c4*/ void WriteChars(char[] buffer, int index, int count);
            /*0x7640650*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x7640660*/ void WriteRaw(string data);
        }

        class TextUtf8RawTextWriter : System.Xml.XmlUtf8RawTextWriter
        {
            /*0x7640670*/ TextUtf8RawTextWriter(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x7640678*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x764067c*/ void WriteXmlDeclaration(string xmldecl);
            /*0x7640680*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x7640684*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x7640688*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x764068c*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x7640690*/ void StartElementContent();
            /*0x7640694*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x76406a0*/ void WriteEndAttribute();
            /*0x76406a8*/ void WriteNamespaceDeclaration(string prefix, string ns);
            /*0x76406ac*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0x76406b4*/ void WriteCData(string text);
            /*0x76406bc*/ void WriteComment(string text);
            /*0x76406c0*/ void WriteProcessingInstruction(string name, string text);
            /*0x76406c4*/ void WriteEntityRef(string name);
            /*0x76406c8*/ void WriteCharEntity(char ch);
            /*0x76406cc*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x76406d0*/ void WriteWhitespace(string ws);
            /*0x76406e4*/ void WriteString(string textBlock);
            /*0x76406f8*/ void WriteChars(char[] buffer, int index, int count);
            /*0x764070c*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x7640720*/ void WriteRaw(string data);
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

            /*0x7640734*/ ValidatingReaderNodeData();
            /*0x76407fc*/ ValidatingReaderNodeData(System.Xml.XmlNodeType nodeType);
            /*0x7640828*/ string get_LocalName();
            /*0x7640830*/ void set_LocalName(string value);
            /*0x7640838*/ string get_Namespace();
            /*0x7640840*/ void set_Namespace(string value);
            /*0x7640848*/ string get_Prefix();
            /*0x7640850*/ void set_Prefix(string value);
            /*0x7640858*/ string GetAtomizedNameWPrefix(System.Xml.XmlNameTable nameTable);
            /*0x76408fc*/ int get_Depth();
            /*0x7640904*/ void set_Depth(int value);
            /*0x764090c*/ string get_RawValue();
            /*0x7640914*/ void set_RawValue(string value);
            /*0x764091c*/ string get_OriginalStringValue();
            /*0x7640924*/ System.Xml.XmlNodeType get_NodeType();
            /*0x764092c*/ void set_NodeType(System.Xml.XmlNodeType value);
            /*0x7640934*/ System.Xml.AttributePSVIInfo get_AttInfo();
            /*0x764093c*/ void set_AttInfo(System.Xml.AttributePSVIInfo value);
            /*0x7640944*/ int get_LineNumber();
            /*0x764094c*/ int get_LinePosition();
            /*0x7640754*/ void Clear(System.Xml.XmlNodeType nodeType);
            /*0x7640954*/ void SetLineInfo(int lineNo, int linePos);
            /*0x764095c*/ void SetLineInfo(System.Xml.IXmlLineInfo lineInfo);
            /*0x7640a64*/ void SetItemData(string localName, string prefix, string ns, int depth);
            /*0x7640ad8*/ void SetItemData(string value);
            /*0x7640b08*/ void SetItemData(string value, string originalStringValue);
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

            static /*0x7640b40*/ System.Xml.XmlAsyncCheckReader CreateAsyncCheckWrapper(System.Xml.XmlReader reader);
            /*0x7640f64*/ XmlAsyncCheckReader(System.Xml.XmlReader reader);
            /*0x7640b38*/ System.Xml.XmlReader get_CoreReader();
            /*0x7641014*/ void CheckAsync();
            /*0x7641090*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x7641130*/ System.Xml.XmlNodeType get_NodeType();
            /*0x7641158*/ string get_Name();
            /*0x7641180*/ string get_LocalName();
            /*0x76411a8*/ string get_NamespaceURI();
            /*0x76411d0*/ string get_Prefix();
            /*0x76411f8*/ string get_Value();
            /*0x7641220*/ int get_Depth();
            /*0x7641248*/ string get_BaseURI();
            /*0x7641274*/ bool get_IsEmptyElement();
            /*0x76412a0*/ bool get_IsDefault();
            /*0x76412cc*/ char get_QuoteChar();
            /*0x76412f8*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x7641324*/ string get_XmlLang();
            /*0x7641350*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x764137c*/ System.Type get_ValueType();
            /*0x76413a8*/ object ReadContentAsObject();
            /*0x76413d4*/ bool ReadContentAsBoolean();
            /*0x7641400*/ System.DateTime ReadContentAsDateTime();
            /*0x764142c*/ double ReadContentAsDouble();
            /*0x7641458*/ float ReadContentAsFloat();
            /*0x7641484*/ decimal ReadContentAsDecimal();
            /*0x76414b0*/ int ReadContentAsInt();
            /*0x76414dc*/ long ReadContentAsLong();
            /*0x7641508*/ string ReadContentAsString();
            /*0x7641534*/ object ReadContentAs(System.Type returnType, System.Xml.IXmlNamespaceResolver namespaceResolver);
            /*0x7641578*/ bool ReadElementContentAsBoolean();
            /*0x76415a4*/ System.DateTime ReadElementContentAsDateTime();
            /*0x76415d0*/ double ReadElementContentAsDouble();
            /*0x76415fc*/ float ReadElementContentAsFloat();
            /*0x7641628*/ decimal ReadElementContentAsDecimal();
            /*0x7641654*/ int ReadElementContentAsInt();
            /*0x7641680*/ long ReadElementContentAsLong();
            /*0x76416ac*/ string ReadElementContentAsString();
            /*0x76416d8*/ int get_AttributeCount();
            /*0x7641704*/ string GetAttribute(string name);
            /*0x7641740*/ string GetAttribute(string name, string namespaceURI);
            /*0x7641784*/ string GetAttribute(int i);
            /*0x76417c0*/ bool MoveToAttribute(string name);
            /*0x76417fc*/ bool MoveToAttribute(string name, string ns);
            /*0x7641840*/ void MoveToAttribute(int i);
            /*0x764187c*/ bool MoveToFirstAttribute();
            /*0x76418a8*/ bool MoveToNextAttribute();
            /*0x76418d4*/ bool MoveToElement();
            /*0x7641900*/ bool ReadAttributeValue();
            /*0x764192c*/ bool Read();
            /*0x7641958*/ bool get_EOF();
            /*0x7641984*/ void Close();
            /*0x76419b0*/ System.Xml.ReadState get_ReadState();
            /*0x76419dc*/ void Skip();
            /*0x7641a08*/ System.Xml.XmlNameTable get_NameTable();
            /*0x7641a34*/ string LookupNamespace(string prefix);
            /*0x7641a70*/ bool get_CanResolveEntity();
            /*0x7641a9c*/ void ResolveEntity();
            /*0x7641ac8*/ int ReadContentAsBase64(byte[] buffer, int index, int count);
            /*0x7641b1c*/ int ReadContentAsBinHex(byte[] buffer, int index, int count);
            /*0x7641b70*/ bool get_CanReadValueChunk();
            /*0x7641b9c*/ int ReadValueChunk(char[] buffer, int index, int count);
            /*0x7641bf0*/ string ReadString();
            /*0x7641c1c*/ System.Xml.XmlNodeType MoveToContent();
            /*0x7641c48*/ void ReadStartElement();
            /*0x7641c74*/ string ReadElementString();
            /*0x7641ca0*/ void ReadEndElement();
            /*0x7641ccc*/ bool IsStartElement();
            /*0x7641cf8*/ bool IsStartElement(string localname, string ns);
            /*0x7641d3c*/ string ReadInnerXml();
            /*0x7641d68*/ bool get_HasAttributes();
            /*0x7641d94*/ void Dispose(bool disposing);
            /*0x7641db8*/ System.Xml.XmlNamespaceManager get_NamespaceManager();
            /*0x7641de4*/ System.Xml.IDtdInfo get_DtdInfo();
        }

        class XmlAsyncCheckReaderWithNS : System.Xml.XmlAsyncCheckReader, System.Xml.IXmlNamespaceResolver
        {
            /*0x20*/ System.Xml.IXmlNamespaceResolver readerAsIXmlNamespaceResolver;

            /*0x7640ebc*/ XmlAsyncCheckReaderWithNS(System.Xml.XmlReader reader);
            /*0x7641e10*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x7641eb8*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0x7641f64*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
        }

        class XmlAsyncCheckReaderWithLineInfo : System.Xml.XmlAsyncCheckReader, System.Xml.IXmlLineInfo
        {
            /*0x20*/ System.Xml.IXmlLineInfo readerAsIXmlLineInfo;

            /*0x7640e14*/ XmlAsyncCheckReaderWithLineInfo(System.Xml.XmlReader reader);
            /*0x7642010*/ bool HasLineInfo();
            /*0x76420b0*/ int get_LineNumber();
            /*0x7642154*/ int get_LinePosition();
        }

        class XmlAsyncCheckReaderWithLineInfoNS : System.Xml.XmlAsyncCheckReaderWithLineInfo, System.Xml.IXmlNamespaceResolver
        {
            /*0x28*/ System.Xml.IXmlNamespaceResolver readerAsIXmlNamespaceResolver;

            /*0x7640d6c*/ XmlAsyncCheckReaderWithLineInfoNS(System.Xml.XmlReader reader);
            /*0x76421f8*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x76422a0*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0x764234c*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
        }

        class XmlAsyncCheckReaderWithLineInfoNSSchema : System.Xml.XmlAsyncCheckReaderWithLineInfoNS, System.Xml.Schema.IXmlSchemaInfo
        {
            /*0x30*/ System.Xml.Schema.IXmlSchemaInfo readerAsIXmlSchemaInfo;

            /*0x7640cc4*/ XmlAsyncCheckReaderWithLineInfoNSSchema(System.Xml.XmlReader reader);
            /*0x76423f8*/ System.Xml.Schema.XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity();
            /*0x7642498*/ bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault();
            /*0x764253c*/ bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil();
            /*0x76425e0*/ System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType();
            /*0x7642684*/ System.Xml.Schema.XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType();
            /*0x7642728*/ System.Xml.Schema.XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement();
            /*0x76427cc*/ System.Xml.Schema.XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute();
        }

        class XmlAsyncCheckWriter : System.Xml.XmlWriter
        {
            /*0x18*/ System.Xml.XmlWriter coreWriter;
            /*0x20*/ System.Threading.Tasks.Task lastTask;

            /*0x7642870*/ XmlAsyncCheckWriter(System.Xml.XmlWriter writer);
            /*0x76428fc*/ void CheckAsync();
            /*0x7642978*/ void WriteStartDocument();
            /*0x76429a0*/ void WriteStartDocument(bool standalone);
            /*0x76429d8*/ void WriteEndDocument();
            /*0x7642a00*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x7642a58*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x7642aa8*/ void WriteEndElement();
            /*0x7642ad0*/ void WriteFullEndElement();
            /*0x7642af8*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x7642b48*/ void WriteEndAttribute();
            /*0x7642b74*/ void WriteCData(string text);
            /*0x7642bb0*/ void WriteComment(string text);
            /*0x7642bec*/ void WriteProcessingInstruction(string name, string text);
            /*0x7642c30*/ void WriteEntityRef(string name);
            /*0x7642c6c*/ void WriteCharEntity(char ch);
            /*0x7642ca8*/ void WriteWhitespace(string ws);
            /*0x7642ce4*/ void WriteString(string text);
            /*0x7642d20*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x7642d64*/ void WriteChars(char[] buffer, int index, int count);
            /*0x7642db8*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x7642e0c*/ void WriteRaw(string data);
            /*0x7642e48*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x7642e9c*/ void WriteBinHex(byte[] buffer, int index, int count);
            /*0x7642ef0*/ System.Xml.WriteState get_WriteState();
            /*0x7642f1c*/ void Close();
            /*0x7642f48*/ void Flush();
            /*0x7642f74*/ string LookupPrefix(string ns);
            /*0x7642fb0*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x7642fdc*/ string get_XmlLang();
            /*0x7643008*/ void WriteQualifiedName(string localName, string ns);
            /*0x764304c*/ void WriteValue(string value);
            /*0x7643088*/ void WriteValue(bool value);
            /*0x76430c4*/ void WriteValue(System.DateTime value);
            /*0x7643100*/ void WriteValue(double value);
            /*0x764313c*/ void WriteValue(float value);
            /*0x7643178*/ void WriteValue(decimal value);
            /*0x76431bc*/ void WriteValue(int value);
            /*0x76431f8*/ void WriteValue(long value);
            /*0x7643234*/ void WriteAttributes(System.Xml.XmlReader reader, bool defattr);
            /*0x7643278*/ void WriteNode(System.Xml.XmlReader reader, bool defattr);
            /*0x76432bc*/ void Dispose(bool disposing);
        }

        class XmlAutoDetectWriter : System.Xml.XmlRawWriter
        {
            /*0x28*/ System.Xml.XmlRawWriter wrapped;
            /*0x30*/ System.Xml.OnRemoveWriter onRemove;
            /*0x38*/ System.Xml.XmlWriterSettings writerSettings;
            /*0x40*/ System.Xml.XmlEventCache eventCache;
            /*0x48*/ System.IO.TextWriter textWriter;
            /*0x50*/ System.IO.Stream strm;

            static /*0x764354c*/ bool IsHtmlTag(string tagName);
            /*0x76432e0*/ XmlAutoDetectWriter(System.Xml.XmlWriterSettings writerSettings);
            /*0x76433f4*/ XmlAutoDetectWriter(System.IO.TextWriter textWriter, System.Xml.XmlWriterSettings writerSettings);
            /*0x7643424*/ XmlAutoDetectWriter(System.IO.Stream strm, System.Xml.XmlWriterSettings writerSettings);
            /*0x7643454*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x76434cc*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x76437a8*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x7643808*/ void WriteEndAttribute();
            /*0x764382c*/ void WriteCData(string text);
            /*0x76438d4*/ void WriteComment(string text);
            /*0x7643904*/ void WriteProcessingInstruction(string name, string text);
            /*0x7643934*/ void WriteWhitespace(string ws);
            /*0x7643964*/ void WriteString(string text);
            /*0x76439ac*/ void WriteChars(char[] buffer, int index, int count);
            /*0x76439dc*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x7643a0c*/ void WriteRaw(string data);
            /*0x7643a54*/ void WriteEntityRef(string name);
            /*0x7643aa0*/ void WriteCharEntity(char ch);
            /*0x7643aec*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x7643b40*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x7643ba4*/ void WriteBinHex(byte[] buffer, int index, int count);
            /*0x7643c08*/ void Close();
            /*0x7643c44*/ void Flush();
            /*0x7643c80*/ void WriteValue(string value);
            /*0x7643ccc*/ void WriteValue(bool value);
            /*0x7643d18*/ void WriteValue(System.DateTime value);
            /*0x7643d64*/ void WriteValue(double value);
            /*0x7643db0*/ void WriteValue(float value);
            /*0x7643dfc*/ void WriteValue(decimal value);
            /*0x7643e50*/ void WriteValue(int value);
            /*0x7643e9c*/ void WriteValue(long value);
            /*0x7643ee8*/ void set_NamespaceResolver(System.Xml.IXmlNamespaceResolver value);
            /*0x7643f38*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x7643f84*/ void WriteXmlDeclaration(string xmldecl);
            /*0x7643fd0*/ void StartElementContent();
            /*0x7643ff4*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x7644018*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x764403c*/ void WriteNamespaceDeclaration(string prefix, string ns);
            /*0x7644090*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0x76440b4*/ void WriteStartNamespaceDeclaration(string prefix);
            /*0x7644100*/ void WriteEndNamespaceDeclaration();
            /*0x76434bc*/ void EnsureWrappedWriter(System.Xml.XmlOutputMethod outMethod);
            /*0x7643874*/ bool TextBlockCreatesWriter(string textBlock);
            /*0x7643660*/ void CreateWrappedWriter(System.Xml.XmlOutputMethod outMethod);
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

            static /*0x7646460*/ char* EncodeSurrogate(char* pSrc, char* pSrcEnd, char* pDst);
            static /*0x7646408*/ char* LtEntity(char* pDst);
            static /*0x7646420*/ char* GtEntity(char* pDst);
            static /*0x763ca9c*/ char* AmpEntity(char* pDst);
            static /*0x763cac4*/ char* QuoteEntity(char* pDst);
            static /*0x7646438*/ char* TabEntity(char* pDst);
            static /*0x763cb18*/ char* LineFeedEntity(char* pDst);
            static /*0x763caf0*/ char* CarriageReturnEntity(char* pDst);
            static /*0x76466d8*/ char* CharEntity(char* pDst, char ch);
            static /*0x76466a0*/ char* RawStartCData(char* pDst);
            static /*0x7646680*/ char* RawEndCData(char* pDst);
            /*0x764480c*/ XmlEncodedRawTextWriter(System.Xml.XmlWriterSettings settings);
            /*0x763a178*/ XmlEncodedRawTextWriter(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings);
            /*0x763a464*/ XmlEncodedRawTextWriter(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x7644c58*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x7644dc8*/ void WriteXmlDeclaration(string xmldecl);
            /*0x7644e40*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x763ac94*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x764502c*/ void StartElementContent();
            /*0x763afac*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x763b214*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x763b48c*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x7645070*/ void WriteEndAttribute();
            /*0x76450d8*/ void WriteNamespaceDeclaration(string prefix, string namespaceName);
            /*0x764512c*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0x7645134*/ void WriteStartNamespaceDeclaration(string prefix);
            /*0x7645258*/ void WriteEndNamespaceDeclaration();
            /*0x76452c0*/ void WriteCData(string text);
            /*0x76457bc*/ void WriteComment(string text);
            /*0x76458e8*/ void WriteProcessingInstruction(string name, string text);
            /*0x7645a14*/ void WriteEntityRef(string name);
            /*0x7645ae0*/ void WriteCharEntity(char ch);
            /*0x7645ca4*/ void WriteWhitespace(string ws);
            /*0x7645d10*/ void WriteString(string text);
            /*0x7645d7c*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x7645ec4*/ void WriteChars(char[] buffer, int index, int count);
            /*0x76405d4*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x764052c*/ void WriteRaw(string data);
            /*0x7646164*/ void Close();
            /*0x764627c*/ void Flush();
            /*0x763d044*/ void FlushBuffer();
            /*0x76462d4*/ void EncodeChars(int startOffset, int endOffset, bool writeAllToStream);
            /*0x76461e0*/ void FlushEncoder();
            /*0x763bd4c*/ void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd);
            /*0x763c034*/ void WriteElementTextBlock(char* pSrc, char* pSrcEnd);
            /*0x763aa14*/ void RawText(string s);
            /*0x763c308*/ void RawText(char* pSrcBegin, char* pSrcEnd);
            /*0x7645f4c*/ void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd);
            /*0x763b7f8*/ void WriteCommentOrPi(string text, int stopChar);
            /*0x76454a0*/ void WriteCDataSection(string text);
            /*0x76465b8*/ char* InvalidXmlChar(int ch, char* pDst, bool entitize);
            /*0x763cb40*/ void EncodeChar(ref char* pSrc, char* pSrcEnd, ref char* pDst);
            /*0x763a9a0*/ void ChangeTextContentMark(bool value);
            /*0x7646788*/ void GrowTextContentMarks();
            /*0x7646624*/ char* WriteNewLine(char* pDst);
            /*0x764490c*/ void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace);
        }

        class XmlEncodedRawTextWriterIndent : System.Xml.XmlEncodedRawTextWriter
        {
            /*0xc0*/ int indentLevel;
            /*0xc4*/ bool newLineOnAttributes;
            /*0xc8*/ string indentChars;
            /*0xd0*/ bool mixedContent;
            /*0xd8*/ System.Xml.BitStack mixedContentStack;
            /*0xe0*/ System.Xml.ConformanceLevel conformanceLevel;

            /*0x7646810*/ XmlEncodedRawTextWriterIndent(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings);
            /*0x7646964*/ XmlEncodedRawTextWriterIndent(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x764698c*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x7646a34*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x7646acc*/ void StartElementContent();
            /*0x7646b10*/ void OnRootElement(System.Xml.ConformanceLevel currentConformanceLevel);
            /*0x7646b18*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x7646bb0*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x7646c48*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x7646c84*/ void WriteCData(string text);
            /*0x7646c90*/ void WriteComment(string text);
            /*0x7646cd0*/ void WriteProcessingInstruction(string target, string text);
            /*0x7646d18*/ void WriteEntityRef(string name);
            /*0x7646d24*/ void WriteCharEntity(char ch);
            /*0x7646d30*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x7646d3c*/ void WriteWhitespace(string ws);
            /*0x7646d48*/ void WriteString(string text);
            /*0x7646d54*/ void WriteChars(char[] buffer, int index, int count);
            /*0x7646d60*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x7646d6c*/ void WriteRaw(string data);
            /*0x7646d78*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x7646838*/ void Init(System.Xml.XmlWriterSettings settings);
            /*0x76469ec*/ void WriteIndent();
        }

        class XmlEventCache : System.Xml.XmlRawWriter
        {
            /*0x28*/ System.Collections.Generic.List<System.Xml.XmlEventCache.XmlEvent[]> pages;
            /*0x30*/ System.Xml.XmlEventCache.XmlEvent[] pageCurr;
            /*0x38*/ int pageSize;
            /*0x3c*/ bool hasRootNode;
            /*0x40*/ System.Xml.Xsl.Runtime.StringConcat singleText;
            /*0x78*/ string baseUri;

            static /*0x76471e8*/ byte[] ToBytes(byte[] buffer, int index, int count);
            /*0x76433b8*/ XmlEventCache(string baseUri, bool hasRootNode);
            /*0x7644124*/ void EndEvents();
            /*0x7644138*/ void EventsToWriter(System.Xml.XmlWriter writer);
            /*0x7646dd0*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x7646e68*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x7646eec*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x7646f00*/ void WriteEndAttribute();
            /*0x7646f08*/ void WriteCData(string text);
            /*0x7646f6c*/ void WriteComment(string text);
            /*0x7646f78*/ void WriteProcessingInstruction(string name, string text);
            /*0x7646ff0*/ void WriteWhitespace(string ws);
            /*0x7646ffc*/ void WriteString(string text);
            /*0x7647020*/ void WriteChars(char[] buffer, int index, int count);
            /*0x7647050*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x7647080*/ void WriteRaw(string data);
            /*0x764708c*/ void WriteEntityRef(string name);
            /*0x7647098*/ void WriteCharEntity(char ch);
            /*0x7647130*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x76471bc*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x764729c*/ void WriteBinHex(byte[] buffer, int index, int count);
            /*0x76472c8*/ void Close();
            /*0x76472d0*/ void Flush();
            /*0x76472d8*/ void WriteValue(string value);
            /*0x76472e8*/ void Dispose(bool disposing);
            /*0x7647398*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x7647404*/ void WriteXmlDeclaration(string xmldecl);
            /*0x7647410*/ void StartElementContent();
            /*0x7647418*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x764742c*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x7647440*/ void WriteNamespaceDeclaration(string prefix, string ns);
            /*0x7647450*/ void WriteEndBase64();
            /*0x7646d88*/ void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType);
            /*0x7646f14*/ void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1);
            /*0x7646f88*/ void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1, string s2);
            /*0x7646e7c*/ void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1, string s2, string s3);
            /*0x7646de8*/ void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o);
            /*0x76470d8*/ void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, object o);
            /*0x7647458*/ int NewEvent();

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

                /*0x7725878*/ void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType);
                /*0x7725880*/ void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1);
                /*0x7725890*/ void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1, string s2);
                /*0x77258c8*/ void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1, string s2, string s3);
                /*0x7725914*/ void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o);
                /*0x772597c*/ void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, object o);
                /*0x772598c*/ System.Xml.XmlEventCache.XmlEventType get_EventType();
                /*0x7725994*/ string get_String1();
                /*0x772599c*/ string get_String2();
                /*0x77259a4*/ string get_String3();
                /*0x77259ac*/ object get_Object();
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

            /*0x77259b4*/ XmlParserContext(System.Xml.XmlNameTable nt, System.Xml.XmlNamespaceManager nsMgr, string xmlLang, System.Xml.XmlSpace xmlSpace);
            /*0x77259fc*/ XmlParserContext(System.Xml.XmlNameTable nt, System.Xml.XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, System.Xml.XmlSpace xmlSpace);
            /*0x7725a28*/ XmlParserContext(System.Xml.XmlNameTable nt, System.Xml.XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, System.Xml.XmlSpace xmlSpace, System.Text.Encoding enc);
            /*0x7725ce0*/ System.Xml.XmlNameTable get_NameTable();
            /*0x7725ce8*/ System.Xml.XmlNamespaceManager get_NamespaceManager();
            /*0x7725cf0*/ string get_DocTypeName();
            /*0x7725cf8*/ string get_PublicId();
            /*0x7725d00*/ string get_SystemId();
            /*0x7725d08*/ string get_BaseURI();
            /*0x7725d10*/ string get_InternalSubset();
            /*0x7725d18*/ string get_XmlLang();
            /*0x7725d20*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x7725d28*/ System.Text.Encoding get_Encoding();
            /*0x7725d30*/ bool get_HasDtdInfo();
        }

        class XmlRawWriter : System.Xml.XmlWriter
        {
            /*0x18*/ System.Xml.XmlRawWriterBase64Encoder base64Encoder;
            /*0x20*/ System.Xml.IXmlNamespaceResolver resolver;

            /*0x77265c0*/ XmlRawWriter();
            /*0x7725dac*/ void WriteStartDocument();
            /*0x7725e04*/ void WriteStartDocument(bool standalone);
            /*0x7725e5c*/ void WriteEndDocument();
            /*0x7725eb4*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x7725eb8*/ void WriteEndElement();
            /*0x7725f10*/ void WriteFullEndElement();
            /*0x7725f68*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x7726014*/ string LookupPrefix(string ns);
            /*0x772606c*/ System.Xml.WriteState get_WriteState();
            /*0x77260c4*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x772611c*/ string get_XmlLang();
            /*0x7726174*/ void WriteQualifiedName(string localName, string ns);
            /*0x77261cc*/ void WriteCData(string text);
            /*0x77261dc*/ void WriteCharEntity(char ch);
            /*0x7726270*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x7726314*/ void WriteWhitespace(string ws);
            /*0x7726324*/ void WriteChars(char[] buffer, int index, int count);
            /*0x7726354*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x7726384*/ void WriteRaw(string data);
            /*0x7726394*/ void WriteValue(string value);
            /*0x77263a4*/ void WriteAttributes(System.Xml.XmlReader reader, bool defattr);
            /*0x77263fc*/ void WriteNode(System.Xml.XmlReader reader, bool defattr);
            /*0x7726454*/ void set_NamespaceResolver(System.Xml.IXmlNamespaceResolver value);
            /*0x772645c*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x7726460*/ void WriteXmlDeclaration(string xmldecl);
            /*0x380cb08*/ void StartElementContent();
            /*0x7726464*/ void OnRootElement(System.Xml.ConformanceLevel conformanceLevel);
            /*0x380da4c*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x7726468*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x7726478*/ void WriteQualifiedName(string prefix, string localName, string ns);
            /*0x380d93c*/ void WriteNamespaceDeclaration(string prefix, string ns);
            /*0x772651c*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0x7726524*/ void WriteStartNamespaceDeclaration(string prefix);
            /*0x772655c*/ void WriteEndNamespaceDeclaration();
            /*0x7726594*/ void WriteEndBase64();
            /*0x77265b0*/ void Close(System.Xml.WriteState currentState);
        }

        class XmlReader : System.IDisposable
        {
            static /*0x0*/ uint IsTextualNodeBitmap;
            static /*0x4*/ uint CanReadContentAsBitmap;
            static /*0x8*/ uint HasValueBitmap;

            static /*0x772a778*/ XmlReader();
            static /*0x7728610*/ bool IsTextualNode(System.Xml.XmlNodeType nodeType);
            static /*0x7729778*/ bool CanReadContentAs(System.Xml.XmlNodeType nodeType);
            static /*0x77297dc*/ bool HasValueInternal(System.Xml.XmlNodeType nodeType);
            static /*0x7729840*/ System.Exception CreateReadContentAsException(string methodName, System.Xml.XmlNodeType nodeType, System.Xml.IXmlLineInfo lineInfo);
            static /*0x7729a58*/ System.Exception CreateReadElementContentAsException(string methodName, System.Xml.XmlNodeType nodeType, System.Xml.IXmlLineInfo lineInfo);
            static /*0x7729bd0*/ string AddLineInfo(string message, System.Xml.IXmlLineInfo lineInfo);
            static /*0x7729ee4*/ System.Xml.XmlReader Create(System.IO.Stream input, System.Xml.XmlReaderSettings settings, string baseUri);
            static /*0x772a134*/ System.Xml.XmlReader Create(System.IO.TextReader input, System.Xml.XmlReaderSettings settings, string baseUri);
            static /*0x772a2d8*/ System.Xml.XmlReader CreateSqlReader(System.IO.Stream input, System.Xml.XmlReaderSettings settings, System.Xml.XmlParserContext inputContext);
            static /*0x772a5f0*/ int CalcBufferSize(System.IO.Stream input);
            /*0x772a770*/ XmlReader();
            /*0x77265c8*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x380b6a0*/ System.Xml.XmlNodeType get_NodeType();
            /*0x77265d0*/ string get_Name();
            /*0x380b9e8*/ string get_LocalName();
            /*0x380b9e8*/ string get_NamespaceURI();
            /*0x380b9e8*/ string get_Prefix();
            /*0x380b9e8*/ string get_Value();
            /*0x380b6a0*/ int get_Depth();
            /*0x380b9e8*/ string get_BaseURI();
            /*0x380b128*/ bool get_IsEmptyElement();
            /*0x77266b4*/ bool get_IsDefault();
            /*0x77266bc*/ char get_QuoteChar();
            /*0x77266c4*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x77266cc*/ string get_XmlLang();
            /*0x77266e4*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x772672c*/ System.Type get_ValueType();
            /*0x772675c*/ object ReadContentAsObject();
            /*0x7726a64*/ bool ReadContentAsBoolean();
            /*0x7726c0c*/ System.DateTime ReadContentAsDateTime();
            /*0x7726db4*/ double ReadContentAsDouble();
            /*0x7726f58*/ float ReadContentAsFloat();
            /*0x77270fc*/ decimal ReadContentAsDecimal();
            /*0x77272a0*/ int ReadContentAsInt();
            /*0x7727444*/ long ReadContentAsLong();
            /*0x77275e8*/ string ReadContentAsString();
            /*0x7727638*/ object ReadContentAs(System.Type returnType, System.Xml.IXmlNamespaceResolver namespaceResolver);
            /*0x77278a4*/ bool ReadElementContentAsBoolean();
            /*0x7727b80*/ System.DateTime ReadElementContentAsDateTime();
            /*0x7727c44*/ double ReadElementContentAsDouble();
            /*0x7727d10*/ float ReadElementContentAsFloat();
            /*0x7727ddc*/ decimal ReadElementContentAsDecimal();
            /*0x7727ea4*/ int ReadElementContentAsInt();
            /*0x7727f64*/ long ReadElementContentAsLong();
            /*0x7728024*/ string ReadElementContentAsString();
            /*0x380b6a0*/ int get_AttributeCount();
            /*0x380bb68*/ string GetAttribute(string name);
            /*0x380bcbc*/ string GetAttribute(string name, string namespaceURI);
            /*0x380ba90*/ string GetAttribute(int i);
            /*0x380b2f0*/ bool MoveToAttribute(string name);
            /*0x380b32c*/ bool MoveToAttribute(string name, string ns);
            /*0x77280b0*/ void MoveToAttribute(int i);
            /*0x380b128*/ bool MoveToFirstAttribute();
            /*0x380b128*/ bool MoveToNextAttribute();
            /*0x380b128*/ bool MoveToElement();
            /*0x380b128*/ bool ReadAttributeValue();
            /*0x380b128*/ bool Read();
            /*0x380b128*/ bool get_EOF();
            /*0x772817c*/ void Close();
            /*0x380b6a0*/ System.Xml.ReadState get_ReadState();
            /*0x7728180*/ void Skip();
            /*0x380b9e8*/ System.Xml.XmlNameTable get_NameTable();
            /*0x380bb68*/ string LookupNamespace(string prefix);
            /*0x7728288*/ bool get_CanResolveEntity();
            /*0x380cb08*/ void ResolveEntity();
            /*0x7728290*/ int ReadContentAsBase64(byte[] buffer, int index, int count);
            /*0x772833c*/ int ReadContentAsBinHex(byte[] buffer, int index, int count);
            /*0x77283e8*/ bool get_CanReadValueChunk();
            /*0x77283f0*/ int ReadValueChunk(char[] buffer, int index, int count);
            /*0x7728448*/ string ReadString();
            /*0x7728674*/ System.Xml.XmlNodeType MoveToContent();
            /*0x77286f8*/ void ReadStartElement();
            /*0x77287ec*/ string ReadElementString();
            /*0x7728a44*/ void ReadEndElement();
            /*0x7728b38*/ bool IsStartElement();
            /*0x7728b5c*/ bool IsStartElement(string localname, string ns);
            /*0x7728be0*/ string ReadInnerXml();
            /*0x7729058*/ void WriteNode(System.Xml.XmlWriter xtw, bool defattr);
            /*0x7728f84*/ void WriteAttributeValue(System.Xml.XmlWriter xtw);
            /*0x7728e88*/ System.Xml.XmlWriter CreateWriterForInnerOuterXml(System.IO.StringWriter sw);
            /*0x772955c*/ void SetNamespacesFlag(System.Xml.XmlTextWriter xtw);
            /*0x77296f4*/ bool get_HasAttributes();
            /*0x7729718*/ void Dispose();
            /*0x772972c*/ void Dispose(bool disposing);
            /*0x7729770*/ System.Xml.XmlNamespaceManager get_NamespaceManager();
            /*0x77281b4*/ bool SkipSubtree();
            /*0x7726818*/ System.Exception CreateReadContentAsException(string methodName);
            /*0x77299b8*/ System.Exception CreateReadElementContentAsException(string methodName);
            /*0x77267ac*/ bool CanReadContentAs();
            /*0x77268b8*/ string InternalReadContentAsString();
            /*0x7727964*/ bool SetupReadElementContentAsXxx(string methodName);
            /*0x7727ab8*/ void FinishReadElementContentAsXxx();
            /*0x7729dfc*/ bool get_IsDefaultInternal();
            /*0x7729edc*/ System.Xml.IDtdInfo get_DtdInfo();
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

            static /*0x772b414*/ System.Xml.XmlResolver CreateDefaultResolver();
            static /*0x772b320*/ bool EnableLegacyXmlSettings();
            /*0x7729f74*/ XmlReaderSettings();
            /*0x772a7dc*/ bool get_Async();
            /*0x772a7e4*/ void set_Async(bool value);
            /*0x772a8f8*/ System.Xml.XmlNameTable get_NameTable();
            /*0x772a900*/ void set_NameTable(System.Xml.XmlNameTable value);
            /*0x772a964*/ bool get_IsXmlResolverSet();
            /*0x772a96c*/ void set_IsXmlResolverSet(bool value);
            /*0x772a978*/ void set_XmlResolver(System.Xml.XmlResolver value);
            /*0x772a9e8*/ System.Xml.XmlResolver GetXmlResolver();
            /*0x772a9f0*/ System.Xml.XmlResolver GetXmlResolver_CheckConfig();
            /*0x772aa20*/ int get_LineNumberOffset();
            /*0x772aa28*/ void set_LineNumberOffset(int value);
            /*0x772aa84*/ int get_LinePositionOffset();
            /*0x772aa8c*/ void set_LinePositionOffset(int value);
            /*0x772aae8*/ System.Xml.ConformanceLevel get_ConformanceLevel();
            /*0x772aaf0*/ void set_ConformanceLevel(System.Xml.ConformanceLevel value);
            /*0x772ab9c*/ bool get_CheckCharacters();
            /*0x772aba4*/ void set_CheckCharacters(bool value);
            /*0x772ac04*/ long get_MaxCharactersInDocument();
            /*0x772ac0c*/ void set_MaxCharactersInDocument(long value);
            /*0x772acb4*/ long get_MaxCharactersFromEntities();
            /*0x772acbc*/ void set_MaxCharactersFromEntities(long value);
            /*0x772ad64*/ bool get_IgnoreWhitespace();
            /*0x772ad6c*/ void set_IgnoreWhitespace(bool value);
            /*0x772adcc*/ bool get_IgnoreProcessingInstructions();
            /*0x772add4*/ void set_IgnoreProcessingInstructions(bool value);
            /*0x772ae34*/ bool get_IgnoreComments();
            /*0x772ae3c*/ void set_IgnoreComments(bool value);
            /*0x772ae9c*/ System.Xml.DtdProcessing get_DtdProcessing();
            /*0x772aea4*/ void set_DtdProcessing(System.Xml.DtdProcessing value);
            /*0x772af50*/ bool get_CloseInput();
            /*0x772af58*/ void set_CloseInput(bool value);
            /*0x772afb8*/ System.Xml.ValidationType get_ValidationType();
            /*0x772afc0*/ void set_ValidationType(System.Xml.ValidationType value);
            /*0x772b06c*/ System.Xml.Schema.XmlSchemaValidationFlags get_ValidationFlags();
            /*0x772b074*/ void set_ValidationFlags(System.Xml.Schema.XmlSchemaValidationFlags value);
            /*0x772b120*/ System.Xml.Schema.XmlSchemaSet get_Schemas();
            /*0x772b190*/ void set_Schemas(System.Xml.Schema.XmlSchemaSet value);
            /*0x772b1f4*/ System.Xml.XmlReaderSettings Clone();
            /*0x772b25c*/ System.Xml.Schema.ValidationEventHandler GetEventHandler();
            /*0x7729f94*/ System.Xml.XmlReader CreateReader(System.IO.Stream input, System.Uri baseUri, string baseUriString, System.Xml.XmlParserContext inputContext);
            /*0x772a1c0*/ System.Xml.XmlReader CreateReader(System.IO.TextReader input, string baseUriString, System.Xml.XmlParserContext inputContext);
            /*0x772b264*/ void set_ReadOnly(bool value);
            /*0x772a844*/ void CheckReadOnly(string propertyName);
            /*0x772a7d4*/ void Initialize();
            /*0x772b270*/ void Initialize(System.Xml.XmlResolver resolver);
            /*0x772a674*/ System.Xml.XmlReader AddValidation(System.Xml.XmlReader reader);
            /*0x772b468*/ System.Xml.XmlValidatingReaderImpl CreateDtdValidatingReader(System.Xml.XmlReader baseReader);
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

            /*0x772b4e0*/ XmlTextEncoder(System.IO.TextWriter textWriter);
            /*0x772b530*/ void set_QuoteChar(char value);
            /*0x772b538*/ void StartAttribute(bool cacheAttrValue);
            /*0x772b5e8*/ void EndAttribute();
            /*0x772b620*/ string get_AttributeValue();
            /*0x772b664*/ void WriteSurrogateChar(char lowChar, char highChar);
            /*0x772b718*/ void Write(char[] array, int offset, int count);
            /*0x772bc24*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x772bdb4*/ void Write(string text);
            /*0x772c298*/ void WriteRawWithSurrogateChecking(string text);
            /*0x772c488*/ void WriteRaw(char[] array, int offset, int count);
            /*0x772c5b4*/ void WriteCharEntity(char ch);
            /*0x772c78c*/ void WriteEntityRef(string name);
            /*0x772c1f0*/ void WriteStringFragment(string str, int offset, int count, char[] helperBuffer);
            /*0x772bb38*/ void WriteCharEntityImpl(char ch);
            /*0x772c6f4*/ void WriteCharEntityImpl(string strVal);
            /*0x772bbb4*/ void WriteEntityRefImpl(string name);
        }

        class XmlTextReader : System.Xml.XmlReader, System.Xml.IXmlLineInfo, System.Xml.IXmlNamespaceResolver
        {
            /*0x10*/ System.Xml.XmlTextReaderImpl impl;

            /*0x772c7f8*/ XmlTextReader(System.IO.Stream input);
            /*0x772c8b8*/ XmlTextReader(string url, System.IO.Stream input, System.Xml.XmlNameTable nt);
            /*0x772c990*/ XmlTextReader(System.IO.TextReader input);
            /*0x772ca50*/ XmlTextReader(System.IO.TextReader input, System.Xml.XmlNameTable nt);
            /*0x772cb18*/ System.Xml.XmlNodeType get_NodeType();
            /*0x772cb38*/ string get_Name();
            /*0x772cb58*/ string get_LocalName();
            /*0x772cb78*/ string get_NamespaceURI();
            /*0x772cb98*/ string get_Prefix();
            /*0x772cbb8*/ string get_Value();
            /*0x772cbd8*/ int get_Depth();
            /*0x772cbf8*/ string get_BaseURI();
            /*0x772cc1c*/ bool get_IsEmptyElement();
            /*0x772cc40*/ bool get_IsDefault();
            /*0x772cc64*/ char get_QuoteChar();
            /*0x772cc88*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x772ccac*/ string get_XmlLang();
            /*0x772ccd0*/ int get_AttributeCount();
            /*0x772ccf4*/ string GetAttribute(string name);
            /*0x772cd18*/ string GetAttribute(string localName, string namespaceURI);
            /*0x772cd3c*/ string GetAttribute(int i);
            /*0x772cd60*/ bool MoveToAttribute(string name);
            /*0x772cd84*/ bool MoveToAttribute(string localName, string namespaceURI);
            /*0x772cda8*/ void MoveToAttribute(int i);
            /*0x772cdcc*/ bool MoveToFirstAttribute();
            /*0x772cdf0*/ bool MoveToNextAttribute();
            /*0x772ce14*/ bool MoveToElement();
            /*0x772ce38*/ bool ReadAttributeValue();
            /*0x772ce5c*/ bool Read();
            /*0x772ce80*/ bool get_EOF();
            /*0x772cea4*/ void Close();
            /*0x772cec8*/ System.Xml.ReadState get_ReadState();
            /*0x772ceec*/ void Skip();
            /*0x772cf10*/ System.Xml.XmlNameTable get_NameTable();
            /*0x772cf34*/ string LookupNamespace(string prefix);
            /*0x772cf6c*/ bool get_CanResolveEntity();
            /*0x772cf74*/ void ResolveEntity();
            /*0x772cf98*/ int ReadContentAsBase64(byte[] buffer, int index, int count);
            /*0x772cfbc*/ int ReadContentAsBinHex(byte[] buffer, int index, int count);
            /*0x772cfe0*/ bool get_CanReadValueChunk();
            /*0x772cfe8*/ string ReadString();
            /*0x772d010*/ bool HasLineInfo();
            /*0x772d018*/ int get_LineNumber();
            /*0x772d034*/ int get_LinePosition();
            /*0x772d050*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x772d06c*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0x772d090*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            /*0x7729648*/ bool get_Namespaces();
            /*0x772d0ac*/ bool get_Normalization();
            /*0x772d0c8*/ void set_Normalization(bool value);
            /*0x772d0e8*/ System.Xml.WhitespaceHandling get_WhitespaceHandling();
            /*0x772d104*/ void set_WhitespaceHandling(System.Xml.WhitespaceHandling value);
            /*0x772d120*/ void set_EntityHandling(System.Xml.EntityHandling value);
            /*0x772d13c*/ void set_XmlResolver(System.Xml.XmlResolver value);
            /*0x772d158*/ System.Xml.XmlTextReaderImpl get_Impl();
            /*0x772d160*/ System.Xml.XmlNamespaceManager get_NamespaceManager();
            /*0x772d184*/ void set_XmlValidatingReaderCompatibilityMode(bool value);
            /*0x772d1a4*/ System.Xml.IDtdInfo get_DtdInfo();
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

            static /*0x772544c*/ void AdjustLineInfo(char[] chars, int startPos, int endPos, bool isNormalized, ref System.Xml.LineInfo lineInfo);
            static /*0x7725500*/ void AdjustLineInfo(string str, int startPos, int endPos, bool isNormalized, ref System.Xml.LineInfo lineInfo);
            static /*0x7725484*/ void AdjustLineInfo(char* pChars, int length, bool isNormalized, ref System.Xml.LineInfo lineInfo);
            static /*0x7725550*/ string StripSpaces(string value);
            static /*0x7725768*/ void StripSpaces(char[] value, int index, ref int len);
            static /*0x7718e28*/ void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count);
            static /*0x771ccd8*/ void BlockCopy(byte[] src, int srcOffset, byte[] dst, int dstOffset, int count);
            /*0x7711678*/ XmlTextReaderImpl(System.Xml.XmlNameTable nt);
            /*0x7711a9c*/ XmlTextReaderImpl(System.Xml.XmlResolver resolver, System.Xml.XmlReaderSettings settings, System.Xml.XmlParserContext context);
            /*0x771221c*/ XmlTextReaderImpl(System.IO.Stream input);
            /*0x77122a0*/ XmlTextReaderImpl(string url, System.IO.Stream input, System.Xml.XmlNameTable nt);
            /*0x77123e0*/ XmlTextReaderImpl(System.IO.TextReader input);
            /*0x771253c*/ XmlTextReaderImpl(System.IO.TextReader input, System.Xml.XmlNameTable nt);
            /*0x7712464*/ XmlTextReaderImpl(string url, System.IO.TextReader input, System.Xml.XmlNameTable nt);
            /*0x7712568*/ XmlTextReaderImpl(string xmlFragment, System.Xml.XmlNodeType fragType, System.Xml.XmlParserContext context);
            /*0x77129e8*/ XmlTextReaderImpl(string xmlFragment, System.Xml.XmlParserContext context);
            /*0x771315c*/ XmlTextReaderImpl(System.IO.Stream stream, byte[] bytes, int byteCount, System.Xml.XmlReaderSettings settings, System.Uri baseUri, string baseUriStr, System.Xml.XmlParserContext context, bool closeInput);
            /*0x77134c4*/ XmlTextReaderImpl(System.IO.TextReader input, System.Xml.XmlReaderSettings settings, string baseUriStr, System.Xml.XmlParserContext context);
            /*0x7713670*/ XmlTextReaderImpl(string xmlFragment, System.Xml.XmlParserContext context, System.Xml.XmlReaderSettings settings);
            /*0x7712b38*/ void FinishInitUriString();
            /*0x7713428*/ void FinishInitStream();
            /*0x77135f0*/ void FinishInitTextReader();
            /*0x77136ec*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x7713860*/ System.Xml.XmlNodeType get_NodeType();
            /*0x771387c*/ string get_Name();
            /*0x77138a0*/ string get_LocalName();
            /*0x77138bc*/ string get_NamespaceURI();
            /*0x77138d8*/ string get_Prefix();
            /*0x77138f4*/ string get_Value();
            /*0x7713ae8*/ int get_Depth();
            /*0x7713b04*/ string get_BaseURI();
            /*0x7713b0c*/ bool get_IsEmptyElement();
            /*0x7713b28*/ bool get_IsDefault();
            /*0x7713b44*/ char get_QuoteChar();
            /*0x7713b74*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x7713b90*/ string get_XmlLang();
            /*0x7713bac*/ System.Xml.ReadState get_ReadState();
            /*0x7713bb4*/ bool get_EOF();
            /*0x7713bc4*/ System.Xml.XmlNameTable get_NameTable();
            /*0x7713bcc*/ bool get_CanResolveEntity();
            /*0x7713bd4*/ int get_AttributeCount();
            /*0x7713bdc*/ string GetAttribute(string name);
            /*0x7713e0c*/ string GetAttribute(string localName, string namespaceURI);
            /*0x7713f68*/ string GetAttribute(int i);
            /*0x7714004*/ bool MoveToAttribute(string name);
            /*0x771418c*/ bool MoveToAttribute(string localName, string namespaceURI);
            /*0x7714328*/ void MoveToAttribute(int i);
            /*0x77143f4*/ bool MoveToFirstAttribute();
            /*0x7714474*/ bool MoveToNextAttribute();
            /*0x7714514*/ bool MoveToElement();
            /*0x77145a4*/ void FinishInit();
            /*0x77145ec*/ bool Read();
            /*0x77167bc*/ void Close();
            /*0x7716890*/ void Skip();
            /*0x7716a18*/ string LookupNamespace(string prefix);
            /*0x7716a50*/ bool ReadAttributeValue();
            /*0x771717c*/ void ResolveEntity();
            /*0x7717868*/ void set_OuterReader(System.Xml.XmlReader value);
            /*0x7717878*/ void MoveOffEntityReference();
            /*0x7717928*/ string ReadString();
            /*0x7717944*/ int ReadContentAsBase64(byte[] buffer, int index, int count);
            /*0x771815c*/ int ReadContentAsBinHex(byte[] buffer, int index, int count);
            /*0x7718404*/ bool get_CanReadValueChunk();
            /*0x771840c*/ int ReadValueChunk(char[] buffer, int index, int count);
            /*0x7718e3c*/ bool HasLineInfo();
            /*0x7718e44*/ int get_LineNumber();
            /*0x7718e60*/ int get_LinePosition();
            /*0x7718e7c*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x7718ec4*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0x7718ed4*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            /*0x7718ea0*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x7718ef8*/ string LookupPrefix(string namespaceName);
            /*0x7718f1c*/ bool get_Namespaces();
            /*0x7718f24*/ void set_Namespaces(bool value);
            /*0x7719104*/ bool get_Normalization();
            /*0x771910c*/ void set_Normalization(bool value);
            /*0x7719228*/ System.Xml.WhitespaceHandling get_WhitespaceHandling();
            /*0x7719230*/ void set_WhitespaceHandling(System.Xml.WhitespaceHandling value);
            /*0x77192f8*/ void set_EntityHandling(System.Xml.EntityHandling value);
            /*0x771937c*/ bool get_IsResolverSet();
            /*0x7719384*/ void set_XmlResolver(System.Xml.XmlResolver value);
            /*0x771940c*/ System.Xml.XmlNameTable get_DtdParserProxy_NameTable();
            /*0x7719414*/ System.Xml.IXmlNamespaceResolver get_DtdParserProxy_NamespaceResolver();
            /*0x771941c*/ bool get_DtdParserProxy_DtdValidation();
            /*0x771943c*/ bool get_DtdParserProxy_Normalization();
            /*0x7719444*/ bool get_DtdParserProxy_Namespaces();
            /*0x771944c*/ bool get_DtdParserProxy_V1CompatibilityMode();
            /*0x7719454*/ System.Uri get_DtdParserProxy_BaseUri();
            /*0x7719508*/ bool get_DtdParserProxy_IsEof();
            /*0x7719510*/ char[] get_DtdParserProxy_ParsingBuffer();
            /*0x7719518*/ int get_DtdParserProxy_ParsingBufferLength();
            /*0x7719520*/ int get_DtdParserProxy_CurrentPosition();
            /*0x7719528*/ void set_DtdParserProxy_CurrentPosition(int value);
            /*0x7719530*/ int get_DtdParserProxy_EntityStackLength();
            /*0x771953c*/ bool get_DtdParserProxy_IsEntityEolNormalized();
            /*0x7719544*/ System.Xml.IValidationEventHandling get_DtdParserProxy_ValidationEventHandling();
            /*0x771954c*/ void DtdParserProxy_OnNewLine(int pos);
            /*0x7719574*/ int get_DtdParserProxy_LineNo();
            /*0x771957c*/ int get_DtdParserProxy_LineStartPosition();
            /*0x7719584*/ int DtdParserProxy_ReadData();
            /*0x77199e0*/ int DtdParserProxy_ParseNumericCharRef(System.Text.StringBuilder internalSubsetBuilder);
            /*0x7719aac*/ int DtdParserProxy_ParseNamedCharRef(bool expand, System.Text.StringBuilder internalSubsetBuilder);
            /*0x7719b18*/ void DtdParserProxy_ParsePI(System.Text.StringBuilder sb);
            /*0x7719ecc*/ void DtdParserProxy_ParseComment(System.Text.StringBuilder sb);
            /*0x771a278*/ bool get_IsResolverNull();
            /*0x771a2b8*/ System.Xml.XmlResolver GetTempResolver();
            /*0x771a318*/ bool DtdParserProxy_PushEntity(System.Xml.IDtdEntityInfo entity, ref int entityId);
            /*0x771aac4*/ bool DtdParserProxy_PopEntity(ref System.Xml.IDtdEntityInfo oldEntity, ref int newEntityId);
            /*0x771ab74*/ bool DtdParserProxy_PushExternalSubset(string systemId, string publicId);
            /*0x771b29c*/ void DtdParserProxy_PushInternalDtd(string baseUri, string internalDtd);
            /*0x771b544*/ void DtdParserProxy_Throw(System.Exception e);
            /*0x771b5d4*/ void DtdParserProxy_OnSystemId(string systemId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo systemLiteralLineInfo);
            /*0x771b6dc*/ void DtdParserProxy_OnPublicId(string publicId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo publicLiteralLineInfo);
            /*0x771b768*/ void Throw(int pos, string res, string arg);
            /*0x771b810*/ void Throw(int pos, string res, string[] args);
            /*0x771b8b8*/ void Throw(int pos, string res);
            /*0x771340c*/ void Throw(string res);
            /*0x771b8e0*/ void Throw(string res, int lineNo, int linePos);
            /*0x771b77c*/ void Throw(string res, string arg);
            /*0x771b974*/ void Throw(string res, string arg, int lineNo, int linePos);
            /*0x771b824*/ void Throw(string res, string[] args);
            /*0x771b9f8*/ void Throw(string res, string arg, System.Exception innerException);
            /*0x771ba78*/ void Throw(string res, string[] args, System.Exception innerException);
            /*0x771b54c*/ void Throw(System.Exception e);
            /*0x771bb2c*/ void ReThrow(System.Exception e, int lineNo, int linePos);
            /*0x77165c4*/ void ThrowWithoutLineInfo(string res);
            /*0x771bbcc*/ void ThrowWithoutLineInfo(string res, string arg);
            /*0x771bc3c*/ void ThrowWithoutLineInfo(string res, string[] args, System.Exception innerException);
            /*0x771bcc0*/ void ThrowInvalidChar(char[] data, int length, int invCharPos);
            /*0x771bb18*/ void SetErrorState();
            /*0x771a1d4*/ void SendValidationEvent(System.Xml.Schema.XmlSeverityType severity, string code, string arg, int lineNo, int linePos);
            /*0x771bd30*/ void SendValidationEvent(System.Xml.Schema.XmlSeverityType severity, System.Xml.Schema.XmlSchemaException exception);
            /*0x77140c8*/ bool get_InAttributeValueIterator();
            /*0x77140ec*/ void FinishAttributeValueIterator();
            /*0x771942c*/ bool get_DtdValidation();
            /*0x7712398*/ void InitStreamInput(System.IO.Stream stream, System.Text.Encoding encoding);
            /*0x77123c4*/ void InitStreamInput(string baseUriStr, System.IO.Stream stream, System.Text.Encoding encoding);
            /*0x771bf40*/ void InitStreamInput(System.Uri baseUri, System.IO.Stream stream, System.Text.Encoding encoding);
            /*0x771bfa0*/ void InitStreamInput(System.Uri baseUri, string baseUriStr, System.IO.Stream stream, System.Text.Encoding encoding);
            /*0x7712e18*/ void InitStreamInput(System.Uri baseUri, string baseUriStr, System.IO.Stream stream, byte[] bytes, int byteCount, System.Text.Encoding encoding);
            /*0x771255c*/ void InitTextReaderInput(string baseUriStr, System.IO.TextReader input);
            /*0x771c344*/ void InitTextReaderInput(string baseUriStr, System.Uri baseUri, System.IO.TextReader input);
            /*0x7712670*/ void InitStringInput(string baseUriStr, System.Text.Encoding originalEncoding, string str);
            /*0x7712778*/ void InitFragmentReader(System.Xml.XmlNodeType fragmentType, System.Xml.XmlParserContext parserContext, bool allowXmlDeclFragment);
            /*0x77130f0*/ void ProcessDtdFromParserContext(System.Xml.XmlParserContext context);
            /*0x7715240*/ void OpenUrl();
            /*0x771c66c*/ void OpenUrlDelegate(object xmlResolver);
            /*0x771bfb0*/ System.Text.Encoding DetectEncoding();
            /*0x771c1d8*/ void SetupEncoding(System.Text.Encoding encoding);
            /*0x771c794*/ void SwitchEncoding(System.Text.Encoding newEncoding);
            /*0x771c930*/ System.Text.Encoding CheckEncoding(string newEncodingName);
            /*0x771c884*/ void UnDecodeChars();
            /*0x771cc74*/ void SwitchEncodingToUTF8();
            /*0x7719588*/ int ReadData();
            /*0x771cce0*/ int GetChars(int maxCharsCount);
            /*0x771cdf8*/ void InvalidCharRecovery(ref int bytesCount, ref int charsCount);
            /*0x77167c4*/ void Close(bool closeInput);
            /*0x771cfe8*/ void ShiftBuffer(int sourcePos, int destPos, int count);
            /*0x77153f8*/ bool ParseXmlDeclaration(bool isTextDecl);
            /*0x7714d50*/ bool ParseDocumentContent();
            /*0x7714a18*/ bool ParseElementContent();
            /*0x771e574*/ void ThrowUnclosedElements();
            /*0x771d47c*/ void ParseElement();
            /*0x771ed60*/ void AddDefaultAttributesAndNormalize();
            /*0x771e17c*/ void ParseEndElement();
            /*0x771feec*/ void ThrowTagMismatch(System.Xml.XmlTextReaderImpl.NodeData startTag);
            /*0x771e71c*/ void ParseAttributes();
            /*0x771f778*/ void ElementNamespaceLookup();
            /*0x771fe3c*/ void AttributeNamespaceLookup();
            /*0x7720fc8*/ void AttributeDuplCheck();
            /*0x7720bf4*/ void OnDefaultNamespaceDecl(System.Xml.XmlTextReaderImpl.NodeData attr);
            /*0x7720cf8*/ void OnNamespaceDecl(System.Xml.XmlTextReaderImpl.NodeData attr);
            /*0x7720dc8*/ void OnXmlReservedAttribute(System.Xml.XmlTextReaderImpl.NodeData attr);
            /*0x77202d8*/ void ParseAttributeValueSlow(int curPos, char quoteChar, System.Xml.XmlTextReaderImpl.NodeData attr);
            /*0x77216f8*/ void AddAttributeChunkToList(System.Xml.XmlTextReaderImpl.NodeData attr, System.Xml.XmlTextReaderImpl.NodeData chunk, ref System.Xml.XmlTextReaderImpl.NodeData lastChunk);
            /*0x771dc0c*/ bool ParseText();
            /*0x7718848*/ bool ParseText(ref int startPos, ref int endPos, ref int outOrChars);
            /*0x771393c*/ void FinishPartialValue();
            /*0x77139f8*/ void FinishOtherValueIterator();
            /*0x7716644*/ void SkipPartialTextValue();
            /*0x7716684*/ void FinishReadValueChunk();
            /*0x77166a4*/ void FinishReadContentAsBinary();
            /*0x77166f4*/ void FinishReadElementContentAsBinary();
            /*0x771df80*/ bool ParseRootLevelWhitespace();
            /*0x771618c*/ void ParseEntityReference();
            /*0x771d944*/ System.Xml.XmlTextReaderImpl.EntityType HandleEntityReference(bool isInAttributeValue, System.Xml.XmlTextReaderImpl.EntityExpandType expandType, ref int charRefEndPos);
            /*0x77173c4*/ System.Xml.XmlTextReaderImpl.EntityType HandleGeneralEntityReference(string name, bool isInAttributeValue, bool pushFakeEntityIfNullResolver, int entityStartLinePos);
            /*0x771cc64*/ bool get_InEntity();
            /*0x771bdf8*/ bool HandleEntityEnd(bool checkEntityNesting);
            /*0x7716200*/ void SetupEndEntityNodeInContent();
            /*0x7721ac8*/ void SetupEndEntityNodeInAttribute();
            /*0x771d174*/ bool ParsePI();
            /*0x7719b5c*/ bool ParsePI(System.Text.StringBuilder piInDtdStringBuilder);
            /*0x7721b40*/ bool ParsePIValue(ref int outStartPos, ref int outEndPos);
            /*0x771d17c*/ bool ParseComment();
            /*0x771d1e0*/ void ParseCData();
            /*0x771a07c*/ void ParseCDataOrComment(System.Xml.XmlNodeType type);
            /*0x7721ed0*/ bool ParseCDataOrComment(System.Xml.XmlNodeType type, ref int outStartPos, ref int outEndPos);
            /*0x771d1e8*/ bool ParseDoctypeDecl();
            /*0x772230c*/ void ParseDtd();
            /*0x7722628*/ void SkipDtd();
            /*0x7722988*/ void SkipPublicOrSystemIdLiteral();
            /*0x7722a40*/ void SkipUntil(char stopChar, bool recognizeLiterals);
            /*0x771b044*/ int EatWhitespaces(System.Text.StringBuilder sb);
            /*0x77218f0*/ int ParseCharRefInline(int startPos, ref int charCount, ref System.Xml.XmlTextReaderImpl.EntityType entityType);
            /*0x7719a00*/ int ParseNumericCharRef(bool expand, System.Text.StringBuilder internalSubsetBuilder, ref System.Xml.XmlTextReaderImpl.EntityType entityType);
            /*0x7722e7c*/ int ParseNumericCharRefInline(int startPos, bool expand, System.Text.StringBuilder internalSubsetBuilder, ref int charCount, ref System.Xml.XmlTextReaderImpl.EntityType entityType);
            /*0x7719ab4*/ int ParseNamedCharRef(bool expand, System.Text.StringBuilder internalSubsetBuilder);
            /*0x7723500*/ int ParseNamedCharRefInline(int startPos, bool expand, System.Text.StringBuilder internalSubsetBuilder);
            /*0x771d010*/ int ParseName();
            /*0x771e70c*/ int ParseQName(ref int colonPos);
            /*0x77237dc*/ int ParseQName(bool isQName, int startOffset, ref int colonPos);
            /*0x7723a70*/ bool ReadDataInName(ref int pos);
            /*0x772175c*/ string ParseEntityName();
            /*0x7716104*/ System.Xml.XmlTextReaderImpl.NodeData AddNode(int nodeIndex, int nodeDepth);
            /*0x7723ab0*/ System.Xml.XmlTextReaderImpl.NodeData AllocNode(int nodeIndex, int nodeDepth);
            /*0x771b660*/ System.Xml.XmlTextReaderImpl.NodeData AddAttributeNoChecks(string name, int attrDepth);
            /*0x7720134*/ System.Xml.XmlTextReaderImpl.NodeData AddAttribute(int endNamePos, int colonPos);
            /*0x7723c04*/ System.Xml.XmlTextReaderImpl.NodeData AddAttribute(string localName, string prefix, string nameWPrefix);
            /*0x7716148*/ void PopElementContext();
            /*0x7719560*/ void OnNewLine(int pos);
            /*0x7716524*/ void OnEof();
            /*0x772134c*/ string LookupNamespace(System.Xml.XmlTextReaderImpl.NodeData node);
            /*0x772149c*/ void AddNamespace(string prefix, string uri, System.Xml.XmlTextReaderImpl.NodeData attr);
            /*0x77160d8*/ void ResetAttributes();
            /*0x7723d70*/ void FullAttributeCleanup();
            /*0x7721410*/ void PushXmlContext();
            /*0x7723d38*/ void PopXmlContext();
            /*0x7721a80*/ System.Xml.XmlNodeType GetWhitespaceType();
            /*0x7721898*/ System.Xml.XmlNodeType GetTextNodeType(int orChars);
            /*0x771acbc*/ void PushExternalEntityOrSubset(string publicId, string systemId, System.Uri baseUri, string entityName);
            /*0x7723df8*/ bool OpenAndPush(System.Uri uri);
            /*0x771a424*/ bool PushExternalEntity(System.Xml.IDtdEntityInfo entity);
            /*0x771a7a8*/ void PushInternalEntity(System.Xml.IDtdEntityInfo entity);
            /*0x771ab28*/ void PopEntity();
            /*0x7724020*/ void RegisterEntity(System.Xml.IDtdEntityInfo entity);
            /*0x7724230*/ void UnregisterEntity();
            /*0x771b30c*/ void PushParsingState();
            /*0x771cf74*/ void PopParsingState();
            /*0x7724294*/ int IncrementalRead();
            /*0x7716364*/ void FinishIncrementalRead();
            /*0x77163e0*/ bool ParseFragmentAttribute();
            /*0x7716ce0*/ bool ParseAttributeValueChunk();
            /*0x7716468*/ void ParseXmlDeclarationFragment();
            /*0x771d1d0*/ void ThrowUnexpectedToken(int pos, string expectedToken);
            /*0x771d008*/ void ThrowUnexpectedToken(string expectedToken1);
            /*0x771d46c*/ void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2);
            /*0x771d030*/ void ThrowUnexpectedToken(string expectedToken1, string expectedToken2);
            /*0x771d464*/ string ParseUnexpectedToken(int pos);
            /*0x7724bdc*/ string ParseUnexpectedToken();
            /*0x77200b4*/ void ThrowExpectingWhitespace(int pos);
            /*0x7713c70*/ int GetIndexOfAttributeWithoutPrefix(string name);
            /*0x7713d58*/ int GetIndexOfAttributeWithPrefix(string name);
            /*0x772195c*/ bool ZeroEndingStream(int pos);
            /*0x771c438*/ void ParseDtdFromParserContext();
            /*0x7717f60*/ bool InitReadContentAsBinary();
            /*0x77219d8*/ bool MoveToNextContentNode(bool moveIfOnContentNode);
            /*0x7724ca4*/ void SetupReadContentAsBinaryState(System.Xml.XmlTextReaderImpl.ParsingFunction inReadBinaryFunction);
            /*0x7711fcc*/ void SetupFromParserContext(System.Xml.XmlParserContext context, System.Xml.XmlReaderSettings settings);
            /*0x7724cd8*/ System.Xml.IDtdInfo get_DtdInfo();
            /*0x7724ce0*/ void SetDtdInfo(System.Xml.IDtdInfo newDtdInfo);
            /*0x7724e30*/ void set_ValidationEventHandling(System.Xml.IValidationEventHandling value);
            /*0x7724e40*/ void set_OnDefaultAttributeUse(System.Xml.XmlTextReaderImpl.OnDefaultAttributeUseDelegate value);
            /*0x7724e50*/ void set_XmlValidatingReaderCompatibilityMode(bool value);
            /*0x7724f28*/ System.Xml.XmlNodeType get_FragmentType();
            /*0x7724f30*/ void ChangeCurrentNodeType(System.Xml.XmlNodeType newNodeType);
            /*0x7724f4c*/ System.Xml.XmlResolver GetResolver();
            /*0x7724f84*/ void set_InternalSchemaType(object value);
            /*0x7724fa0*/ object get_InternalTypedValue();
            /*0x7724fbc*/ void set_InternalTypedValue(object value);
            /*0x7724fd8*/ bool get_StandAlone();
            /*0x7724fe0*/ System.Xml.XmlNamespaceManager get_NamespaceManager();
            /*0x7724fe8*/ bool get_V1Compat();
            /*0x771f7c4*/ bool AddDefaultAttributeDtd(System.Xml.IDtdDefaultAttributeInfo defAttrInfo, bool definedInDtd, System.Xml.XmlTextReaderImpl.NodeData[] nameSortedNodeData);
            /*0x772524c*/ bool AddDefaultAttributeNonDtd(System.Xml.Schema.SchemaAttDef attrDef);
            /*0x7724ff0*/ System.Xml.XmlTextReaderImpl.NodeData AddDefaultAttributeInternal(string localName, string ns, string prefix, string value, int lineNo, int linePos, int valueLineNo, int valueLinePos, bool isXmlAttribute);
            /*0x7725440*/ void set_DisableUndeclaredEntityCheck(bool value);
            /*0x7717b60*/ int ReadContentAsBinary(byte[] buffer, int index, int count);
            /*0x77180d0*/ void InitBase64Decoder();
            /*0x7718378*/ void InitBinHexDecoder();
            /*0x7713328*/ bool UriEqual(System.Uri uri1, string uri1Str, string uri2Str, System.Xml.XmlResolver resolver);
            /*0x771b45c*/ void RegisterConsumedCharacters(long characters, bool inEntityReference);

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

                /*0x772d1c8*/ LaterInitParam();
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

                /*0x772d1d8*/ void Clear();
                /*0x772d294*/ void Close(bool closeInput);
                /*0x772d2cc*/ int get_LineNo();
                /*0x772d2d4*/ int get_LinePos();
            }

            class XmlContext
            {
                /*0x10*/ System.Xml.XmlSpace xmlSpace;
                /*0x18*/ string xmlLang;
                /*0x20*/ string defaultNamespace;
                /*0x28*/ System.Xml.XmlTextReaderImpl.XmlContext previousContext;

                /*0x772d2e4*/ XmlContext();
                /*0x772d34c*/ XmlContext(System.Xml.XmlTextReaderImpl.XmlContext previousContext);
            }

            class NoNamespaceManager : System.Xml.XmlNamespaceManager
            {
                /*0x772d3ac*/ NoNamespaceManager();
                /*0x772d3b4*/ string get_DefaultNamespace();
                /*0x772d3cc*/ void PushScope();
                /*0x772d3d0*/ bool PopScope();
                /*0x772d3d8*/ void AddNamespace(string prefix, string uri);
                /*0x772d3dc*/ void RemoveNamespace(string prefix, string uri);
                /*0x772d3e0*/ System.Collections.IEnumerator GetEnumerator();
                /*0x772d3e8*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
                /*0x772d3f0*/ string LookupNamespace(string prefix);
                /*0x772d408*/ string LookupPrefix(string uri);
            }

            class DtdParserProxy : System.Xml.IDtdParserAdapterV1, System.Xml.IDtdParserAdapterWithValidation, System.Xml.IDtdParserAdapter
            {
                /*0x10*/ System.Xml.XmlTextReaderImpl reader;

                /*0x772d410*/ DtdParserProxy(System.Xml.XmlTextReaderImpl reader);
                /*0x772d440*/ System.Xml.XmlNameTable System.Xml.IDtdParserAdapter.get_NameTable();
                /*0x772d45c*/ System.Xml.IXmlNamespaceResolver System.Xml.IDtdParserAdapter.get_NamespaceResolver();
                /*0x772d478*/ System.Uri System.Xml.IDtdParserAdapter.get_BaseUri();
                /*0x772d494*/ bool System.Xml.IDtdParserAdapter.get_IsEof();
                /*0x772d4b0*/ char[] System.Xml.IDtdParserAdapter.get_ParsingBuffer();
                /*0x772d4cc*/ int System.Xml.IDtdParserAdapter.get_ParsingBufferLength();
                /*0x772d4e8*/ int System.Xml.IDtdParserAdapter.get_CurrentPosition();
                /*0x772d504*/ void System.Xml.IDtdParserAdapter.set_CurrentPosition(int value);
                /*0x772d520*/ int System.Xml.IDtdParserAdapter.get_EntityStackLength();
                /*0x772d53c*/ bool System.Xml.IDtdParserAdapter.get_IsEntityEolNormalized();
                /*0x772d558*/ void System.Xml.IDtdParserAdapter.OnNewLine(int pos);
                /*0x772d574*/ int System.Xml.IDtdParserAdapter.get_LineNo();
                /*0x772d590*/ int System.Xml.IDtdParserAdapter.get_LineStartPosition();
                /*0x772d5ac*/ int System.Xml.IDtdParserAdapter.ReadData();
                /*0x772d5c8*/ int System.Xml.IDtdParserAdapter.ParseNumericCharRef(System.Text.StringBuilder internalSubsetBuilder);
                /*0x772d5e4*/ int System.Xml.IDtdParserAdapter.ParseNamedCharRef(bool expand, System.Text.StringBuilder internalSubsetBuilder);
                /*0x772d604*/ void System.Xml.IDtdParserAdapter.ParsePI(System.Text.StringBuilder sb);
                /*0x772d620*/ void System.Xml.IDtdParserAdapter.ParseComment(System.Text.StringBuilder sb);
                /*0x772d63c*/ bool System.Xml.IDtdParserAdapter.PushEntity(System.Xml.IDtdEntityInfo entity, ref int entityId);
                /*0x772d658*/ bool System.Xml.IDtdParserAdapter.PopEntity(ref System.Xml.IDtdEntityInfo oldEntity, ref int newEntityId);
                /*0x772d674*/ bool System.Xml.IDtdParserAdapter.PushExternalSubset(string systemId, string publicId);
                /*0x772d690*/ void System.Xml.IDtdParserAdapter.PushInternalDtd(string baseUri, string internalDtd);
                /*0x772d6ac*/ void System.Xml.IDtdParserAdapter.Throw(System.Exception e);
                /*0x772d6c8*/ void System.Xml.IDtdParserAdapter.OnSystemId(string systemId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo systemLiteralLineInfo);
                /*0x772d6e4*/ void System.Xml.IDtdParserAdapter.OnPublicId(string publicId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo publicLiteralLineInfo);
                /*0x772d700*/ bool System.Xml.IDtdParserAdapterWithValidation.get_DtdValidation();
                /*0x772d71c*/ System.Xml.IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.get_ValidationEventHandling();
                /*0x772d738*/ bool System.Xml.IDtdParserAdapterV1.get_Normalization();
                /*0x772d754*/ bool System.Xml.IDtdParserAdapterV1.get_Namespaces();
                /*0x772d770*/ bool System.Xml.IDtdParserAdapterV1.get_V1CompatibilityMode();
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

                static /*0x772d78c*/ System.Xml.XmlTextReaderImpl.NodeData get_None();
                /*0x772d834*/ NodeData();
                /*0x772d8d8*/ int get_LineNo();
                /*0x772d8e0*/ int get_LinePos();
                /*0x772d8e8*/ bool get_IsEmptyElement();
                /*0x772d90c*/ void set_IsEmptyElement(bool value);
                /*0x772d918*/ bool get_IsDefaultAttribute();
                /*0x772d93c*/ void set_IsDefaultAttribute(bool value);
                /*0x772d948*/ bool get_ValueBuffered();
                /*0x772d958*/ string get_StringValue();
                /*0x772d9a0*/ void TrimSpacesInValue();
                /*0x772d85c*/ void Clear(System.Xml.XmlNodeType type);
                /*0x772d9ec*/ void ClearName();
                /*0x772da64*/ void SetLineInfo(int lineNo, int linePos);
                /*0x772da70*/ void SetLineInfo2(int lineNo, int linePos);
                /*0x772da7c*/ void SetValueNode(System.Xml.XmlNodeType type, string value);
                /*0x772dab8*/ void SetValueNode(System.Xml.XmlNodeType type, char[] chars, int startPos, int len);
                /*0x772db10*/ void SetNamedNode(System.Xml.XmlNodeType type, string localName);
                /*0x772db2c*/ void SetNamedNode(System.Xml.XmlNodeType type, string localName, string prefix, string nameWPrefix);
                /*0x772dbbc*/ void SetValue(string value);
                /*0x772dbcc*/ void SetValue(char[] chars, int startPos, int len);
                /*0x772dc18*/ void OnBufferInvalidated();
                /*0x772dc68*/ void CopyTo(int valueOffset, System.Text.StringBuilder sb);
                /*0x772dce8*/ int CopyTo(int valueOffset, char[] buffer, int offset, int length);
                /*0x772dd48*/ int CopyToBinary(System.Xml.IncrementalReadDecoder decoder, int valueOffset);
                /*0x772dda8*/ void AdjustLineInfo(int valueOffset, bool isNormalized, ref System.Xml.LineInfo lineInfo);
                /*0x772ddf4*/ string GetNameWPrefix(System.Xml.XmlNameTable nt);
                /*0x772de08*/ string CreateNameWPrefix(System.Xml.XmlNameTable nt);
                /*0x772dea0*/ int System.IComparable.CompareTo(object obj);
            }

            class DtdDefaultAttributeInfoToNodeDataComparer : System.Collections.Generic.IComparer<object>
            {
                static /*0x0*/ System.Collections.Generic.IComparer<object> s_instance;

                static /*0x772e318*/ DtdDefaultAttributeInfoToNodeDataComparer();
                static /*0x772df78*/ System.Collections.Generic.IComparer<object> get_Instance();
                /*0x772e310*/ DtdDefaultAttributeInfoToNodeDataComparer();
                /*0x772dfd0*/ int Compare(object x, object y);
            }

            class OnDefaultAttributeUseDelegate : System.MulticastDelegate
            {
                /*0x772e380*/ OnDefaultAttributeUseDelegate(object object, nint method);
                /*0x772e48c*/ void Invoke(System.Xml.IDtdDefaultAttributeInfo defaultAttribute, System.Xml.XmlTextReaderImpl coreReader);
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

            static /*0x77330c4*/ XmlTextWriter();
            /*0x772e4a0*/ XmlTextWriter();
            /*0x772e660*/ XmlTextWriter(System.IO.Stream w, System.Text.Encoding encoding);
            /*0x772e75c*/ XmlTextWriter(string filename, System.Text.Encoding encoding);
            /*0x772949c*/ XmlTextWriter(System.IO.TextWriter w);
            /*0x772e7dc*/ System.IO.Stream get_BaseStream();
            /*0x7729664*/ void set_Namespaces(bool value);
            /*0x772e878*/ void set_Formatting(System.Xml.Formatting value);
            /*0x7728ef8*/ void set_QuoteChar(char value);
            /*0x772e88c*/ void WriteStartDocument();
            /*0x772ec24*/ void WriteStartDocument(bool standalone);
            /*0x772ec38*/ void WriteEndDocument();
            /*0x772ee50*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x772f930*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x77303e4*/ void WriteEndElement();
            /*0x77306c8*/ void WriteFullEndElement();
            /*0x77306d0*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x7730fac*/ void WriteEndAttribute();
            /*0x773104c*/ void WriteCData(string text);
            /*0x773120c*/ void WriteComment(string text);
            /*0x7731408*/ void WriteProcessingInstruction(string name, string text);
            /*0x7731730*/ void WriteEntityRef(string name);
            /*0x77317f8*/ void WriteCharEntity(char ch);
            /*0x77318b4*/ void WriteWhitespace(string ws);
            /*0x77319fc*/ void WriteString(string text);
            /*0x7731ac4*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x7731b88*/ void WriteChars(char[] buffer, int index, int count);
            /*0x7731c5c*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x7731d30*/ void WriteRaw(string data);
            /*0x7731dec*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x7731f44*/ void WriteBinHex(byte[] buffer, int index, int count);
            /*0x7732014*/ System.Xml.WriteState get_WriteState();
            /*0x7732038*/ void Close();
            /*0x7732170*/ void Flush();
            /*0x7732190*/ void WriteQualifiedName(string localName, string ns);
            /*0x77324b0*/ string LookupPrefix(string ns);
            /*0x773258c*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x77325e4*/ string get_XmlLang();
            /*0x772e894*/ void StartDocument(int standalone);
            /*0x772f434*/ void AutoComplete(System.Xml.XmlTextWriter.Token token);
            /*0x772edfc*/ void AutoCompleteAll();
            /*0x77303ec*/ void InternalWriteEndElement(bool longFormat);
            /*0x7732754*/ void WriteEndStartTag(bool empty);
            /*0x773270c*/ void WriteEndAttributeQuote();
            /*0x773263c*/ void Indent(bool beforeEndElement);
            /*0x773002c*/ void PushNamespace(string prefix, string ns, bool declared);
            /*0x7732dc4*/ void AddNamespace(string prefix, string ns, bool declared);
            /*0x7732fdc*/ void AddToNamespaceHashtable(int namespaceIndex);
            /*0x7732ad8*/ void PopNamespaces(int indexFrom, int indexTo);
            /*0x7730e98*/ string GeneratePrefix();
            /*0x7731638*/ void InternalWriteProcessingInstruction(string name, string text);
            /*0x772fe80*/ int LookupNamespace(string prefix);
            /*0x7730d6c*/ int LookupNamespaceInCurrentScope(string prefix);
            /*0x772ff5c*/ string FindPrefix(string ns);
            /*0x7732470*/ void InternalWriteName(string name, bool isNCName);
            /*0x772f27c*/ void ValidateName(string name, bool isNCName);
            /*0x7732bac*/ void HandleSpecialAttribute();
            /*0x7730284*/ void VerifyPrefixXml(string prefix, string ns);
            /*0x772fda0*/ void PushStack();
            /*0x7732ab4*/ void FlushEncoders();

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

                /*0x772e5fc*/ void Init(int nsTop);
            }

            struct Namespace
            {
                /*0x10*/ string prefix;
                /*0x18*/ string ns;
                /*0x20*/ bool declared;
                /*0x24*/ int prevNsIndex;

                /*0x7732f98*/ void Set(string prefix, string ns, bool declared);
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

            static /*0x7736760*/ bool IsSurrogateByte(byte b);
            static /*0x77362c8*/ byte* EncodeSurrogate(char* pSrc, char* pSrcEnd, byte* pDst);
            static /*0x773650c*/ byte* EncodeMultibyteUTF8(int ch, byte* pDst);
            static /*0x77368f8*/ void CharToUTF8(ref char* pSrc, char* pSrcEnd, ref byte* pDst);
            static /*0x7736228*/ byte* LtEntity(byte* pDst);
            static /*0x7736238*/ byte* GtEntity(byte* pDst);
            static /*0x7736208*/ byte* AmpEntity(byte* pDst);
            static /*0x7736248*/ byte* QuoteEntity(byte* pDst);
            static /*0x7736268*/ byte* TabEntity(byte* pDst);
            static /*0x77362a8*/ byte* LineFeedEntity(byte* pDst);
            static /*0x7736288*/ byte* CarriageReturnEntity(byte* pDst);
            static /*0x7736770*/ byte* CharEntity(byte* pDst, char ch);
            static /*0x7736738*/ byte* RawStartCData(byte* pDst);
            static /*0x773671c*/ byte* RawEndCData(byte* pDst);
            /*0x77336d0*/ XmlUtf8RawTextWriter(System.Xml.XmlWriterSettings settings);
            /*0x7733b1c*/ XmlUtf8RawTextWriter(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x7733c88*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x7733e18*/ void WriteXmlDeclaration(string xmldecl);
            /*0x7733e90*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x7734080*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x7734124*/ void StartElementContent();
            /*0x773416c*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x77342c4*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x77343b8*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x77344c4*/ void WriteEndAttribute();
            /*0x7734510*/ void WriteNamespaceDeclaration(string prefix, string namespaceName);
            /*0x7734564*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0x773456c*/ void WriteStartNamespaceDeclaration(string prefix);
            /*0x7734660*/ void WriteEndNamespaceDeclaration();
            /*0x77346ac*/ void WriteCData(string text);
            /*0x7734c3c*/ void WriteComment(string text);
            /*0x77350c0*/ void WriteProcessingInstruction(string name, string text);
            /*0x77351e8*/ void WriteEntityRef(string name);
            /*0x7735288*/ void WriteCharEntity(char ch);
            /*0x7735454*/ void WriteWhitespace(string ws);
            /*0x7735a44*/ void WriteString(string text);
            /*0x7735a94*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x7735be4*/ void WriteChars(char[] buffer, int index, int count);
            /*0x7735c24*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x7735ea4*/ void WriteRaw(string data);
            /*0x7735eec*/ void Close();
            /*0x7736054*/ void Flush();
            /*0x7736090*/ void FlushBuffer();
            /*0x7736050*/ void FlushEncoder();
            /*0x77354a4*/ void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd);
            /*0x773578c*/ void WriteElementTextBlock(char* pSrc, char* pSrcEnd);
            /*0x7733ddc*/ void RawText(string s);
            /*0x77365a0*/ void RawText(char* pSrcBegin, char* pSrcEnd);
            /*0x7735c64*/ void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd);
            /*0x7734d94*/ void WriteCommentOrPi(string text, int stopChar);
            /*0x7734908*/ void WriteCDataSection(string text);
            /*0x7736458*/ byte* InvalidXmlChar(int ch, byte* pDst, bool entitize);
            /*0x773681c*/ void EncodeChar(ref char* pSrc, char* pSrcEnd, ref byte* pDst);
            /*0x773654c*/ byte* WriteNewLine(byte* pDst);
            /*0x77337d0*/ void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace);
        }

        class XmlUtf8RawTextWriterIndent : System.Xml.XmlUtf8RawTextWriter
        {
            /*0x90*/ int indentLevel;
            /*0x94*/ bool newLineOnAttributes;
            /*0x98*/ string indentChars;
            /*0xa0*/ bool mixedContent;
            /*0xa8*/ System.Xml.BitStack mixedContentStack;
            /*0xb0*/ System.Xml.ConformanceLevel conformanceLevel;

            /*0x77369c8*/ XmlUtf8RawTextWriterIndent(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x7736b14*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x7736bbc*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x7736c28*/ void StartElementContent();
            /*0x7736c78*/ void OnRootElement(System.Xml.ConformanceLevel currentConformanceLevel);
            /*0x7736c80*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x7736d00*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x7736d80*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x7736dbc*/ void WriteCData(string text);
            /*0x7736dc8*/ void WriteComment(string text);
            /*0x7736e08*/ void WriteProcessingInstruction(string target, string text);
            /*0x7736e50*/ void WriteEntityRef(string name);
            /*0x7736e5c*/ void WriteCharEntity(char ch);
            /*0x7736e68*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x7736e74*/ void WriteWhitespace(string ws);
            /*0x7736e80*/ void WriteString(string text);
            /*0x7736e8c*/ void WriteChars(char[] buffer, int index, int count);
            /*0x7736e98*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x7736ea4*/ void WriteRaw(string data);
            /*0x7736eb0*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x77369f0*/ void Init(System.Xml.XmlWriterSettings settings);
            /*0x7736b74*/ void WriteIndent();
        }

        class XmlValidatingReader : System.Xml.XmlReader
        {
            /*0x10*/ System.Xml.XmlValidatingReaderImpl impl;

            /*0x7736ebc*/ System.Xml.XmlNodeType get_NodeType();
            /*0x7736edc*/ string get_LocalName();
            /*0x7736efc*/ string get_NamespaceURI();
            /*0x7736f1c*/ string get_Prefix();
            /*0x7736f3c*/ string get_Value();
            /*0x7736f5c*/ int get_Depth();
            /*0x7736f7c*/ string get_BaseURI();
            /*0x7736fa0*/ bool get_IsEmptyElement();
            /*0x7736fc4*/ int get_AttributeCount();
            /*0x7736fe8*/ string GetAttribute(string name);
            /*0x773700c*/ string GetAttribute(string localName, string namespaceURI);
            /*0x7737030*/ string GetAttribute(int i);
            /*0x7737054*/ bool MoveToAttribute(string name);
            /*0x7737078*/ bool MoveToAttribute(string localName, string namespaceURI);
            /*0x773709c*/ bool MoveToFirstAttribute();
            /*0x77370c0*/ bool MoveToNextAttribute();
            /*0x77370e4*/ bool MoveToElement();
            /*0x7737108*/ bool ReadAttributeValue();
            /*0x773712c*/ bool Read();
            /*0x7737150*/ bool get_EOF();
            /*0x7737174*/ System.Xml.ReadState get_ReadState();
            /*0x7737198*/ System.Xml.XmlNameTable get_NameTable();
            /*0x77371bc*/ string LookupNamespace(string prefix);
            /*0x77371f4*/ void ResolveEntity();
            /*0x77296d8*/ bool get_Namespaces();
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

            /*0x7737218*/ XmlValidatingReaderImpl(System.Xml.XmlReader reader, System.Xml.Schema.ValidationEventHandler settingsEventHandler, bool processIdentityConstraints);
            /*0x7737944*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x7737a14*/ System.Xml.XmlNodeType get_NodeType();
            /*0x7737a34*/ string get_Name();
            /*0x7737a54*/ string get_LocalName();
            /*0x7737a74*/ string get_NamespaceURI();
            /*0x7737a94*/ string get_Prefix();
            /*0x7737ab4*/ string get_Value();
            /*0x7737ad4*/ int get_Depth();
            /*0x7737af4*/ string get_BaseURI();
            /*0x7737b18*/ bool get_IsEmptyElement();
            /*0x7737b3c*/ bool get_IsDefault();
            /*0x7737b60*/ char get_QuoteChar();
            /*0x7737b84*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x7737ba8*/ string get_XmlLang();
            /*0x7737bcc*/ System.Xml.ReadState get_ReadState();
            /*0x7737c08*/ bool get_EOF();
            /*0x7737c2c*/ System.Xml.XmlNameTable get_NameTable();
            /*0x7737c50*/ int get_AttributeCount();
            /*0x7737c74*/ string GetAttribute(string name);
            /*0x7737c98*/ string GetAttribute(string localName, string namespaceURI);
            /*0x7737cbc*/ string GetAttribute(int i);
            /*0x7737ce0*/ bool MoveToAttribute(string name);
            /*0x7737d18*/ bool MoveToAttribute(string localName, string namespaceURI);
            /*0x7737d50*/ void MoveToAttribute(int i);
            /*0x7737d80*/ bool MoveToFirstAttribute();
            /*0x7737db8*/ bool MoveToNextAttribute();
            /*0x7737df0*/ bool MoveToElement();
            /*0x7737e28*/ bool Read();
            /*0x77381e8*/ void Close();
            /*0x773821c*/ string LookupNamespace(string prefix);
            /*0x7738240*/ bool ReadAttributeValue();
            /*0x7738298*/ int ReadContentAsBase64(byte[] buffer, int index, int count);
            /*0x7738344*/ int ReadContentAsBinHex(byte[] buffer, int index, int count);
            /*0x77383f0*/ bool get_CanResolveEntity();
            /*0x77383f8*/ void ResolveEntity();
            /*0x773842c*/ void MoveOffEntityReference();
            /*0x77384dc*/ string ReadString();
            /*0x77384f8*/ bool HasLineInfo();
            /*0x7738500*/ int get_LineNumber();
            /*0x77385e8*/ int get_LinePosition();
            /*0x77386d0*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x773877c*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0x773878c*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            /*0x77386d4*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x7738790*/ string LookupPrefix(string namespaceName);
            /*0x773883c*/ System.Xml.ValidationType get_ValidationType();
            /*0x7738844*/ System.Xml.Schema.XmlSchemaCollection get_Schemas();
            /*0x773884c*/ bool get_Namespaces();
            /*0x7737fec*/ void ParseDtdFromParserContext();
            /*0x7738868*/ void ValidateDtd();
            /*0x7738160*/ void ResolveEntityInternally();
            /*0x77377dc*/ void SetupValidation(System.Xml.ValidationType valType);
            /*0x7737638*/ System.Xml.XmlResolver GetResolver();
            /*0x7737f00*/ void ProcessCoreReaderEvent();
            /*0x77388e4*/ System.Xml.Schema.BaseValidator get_Validator();
            /*0x77388ec*/ void set_Validator(System.Xml.Schema.BaseValidator value);
            /*0x77388f4*/ System.Xml.XmlNamespaceManager get_NamespaceManager();
            /*0x7738918*/ bool get_StandAlone();
            /*0x7738934*/ void set_SchemaTypeObject(object value);
            /*0x7738950*/ object get_TypedValueObject();
            /*0x773896c*/ void set_TypedValueObject(object value);
            /*0x7738988*/ bool AddDefaultAttribute(System.Xml.Schema.SchemaAttDef attdef);
            /*0x77389a4*/ System.Xml.IDtdInfo get_DtdInfo();
            /*0x77389c8*/ void ValidateDefaultAttributeOnUse(System.Xml.IDtdDefaultAttributeInfo defaultAttribute, System.Xml.XmlTextReaderImpl coreReader);

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

                /*0x773771c*/ ValidationEventHandling(System.Xml.XmlValidatingReaderImpl reader);
                /*0x7738b08*/ object System.Xml.IValidationEventHandling.get_EventHandler();
                /*0x7738b10*/ void System.Xml.IValidationEventHandling.SendEvent(System.Exception exception, System.Xml.Schema.XmlSeverityType severity);
                /*0x773774c*/ void AddHandler(System.Xml.Schema.ValidationEventHandler handler);
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

            static /*0x774041c*/ XmlWellFormedWriter();
            static /*0x773fa80*/ System.Xml.XmlException DupAttrException(string prefix, string localName);
            static /*0x773fc78*/ string GetStateName(System.Xml.XmlWellFormedWriter.State state);
            static /*0x77400ec*/ System.Exception InvalidCharsException(string name, int badCharIndex);
            /*0x7738c2c*/ XmlWellFormedWriter(System.Xml.XmlWriter writer, System.Xml.XmlWriterSettings settings);
            /*0x7739228*/ System.Xml.WriteState get_WriteState();
            /*0x77392bc*/ void WriteStartDocument();
            /*0x7739478*/ void WriteStartDocument(bool standalone);
            /*0x7739494*/ void WriteEndDocument();
            /*0x77398e8*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x7739da4*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x773a790*/ void WriteEndElement();
            /*0x773aa74*/ void WriteFullEndElement();
            /*0x773ac84*/ void WriteStartAttribute(string prefix, string localName, string namespaceName);
            /*0x773b898*/ void WriteEndAttribute();
            /*0x773cd9c*/ void WriteCData(string text);
            /*0x773ce80*/ void WriteComment(string text);
            /*0x773cf64*/ void WriteProcessingInstruction(string name, string text);
            /*0x773d1fc*/ void WriteEntityRef(string name);
            /*0x773d508*/ void WriteCharEntity(char ch);
            /*0x773d6f0*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x773d934*/ void WriteWhitespace(string ws);
            /*0x773db18*/ void WriteString(string text);
            /*0x773dc7c*/ void WriteChars(char[] buffer, int index, int count);
            /*0x773df90*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x773e2a4*/ void WriteRaw(string data);
            /*0x773e3e4*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x773e614*/ void Close();
            /*0x773e7f8*/ void Flush();
            /*0x773e8ac*/ string LookupPrefix(string ns);
            /*0x773eb28*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x773eb98*/ string get_XmlLang();
            /*0x773ec14*/ void WriteQualifiedName(string localName, string ns);
            /*0x773ef2c*/ void WriteValue(bool value);
            /*0x773eff4*/ void WriteValue(System.DateTime value);
            /*0x773f0bc*/ void WriteValue(double value);
            /*0x773f18c*/ void WriteValue(float value);
            /*0x773f25c*/ void WriteValue(decimal value);
            /*0x773f32c*/ void WriteValue(int value);
            /*0x773f3f4*/ void WriteValue(long value);
            /*0x773f4bc*/ void WriteValue(string value);
            /*0x773f60c*/ void WriteBinHex(byte[] buffer, int index, int count);
            /*0x773f764*/ System.Xml.XmlRawWriter get_RawWriter();
            /*0x773d35c*/ bool get_SaveAttrValue();
            /*0x773e7d0*/ bool get_InBase64();
            /*0x773b358*/ void SetSpecialAttribute(System.Xml.XmlWellFormedWriter.SpecialAttribute special);
            /*0x77392c4*/ void WriteStartDocumentImpl(System.Xml.XmlStandalone standalone);
            /*0x773f7e0*/ void StartFragment();
            /*0x773a394*/ void PushNamespaceImplicit(string prefix, string ns);
            /*0x773c124*/ bool PushNamespaceExplicit(string prefix, string ns);
            /*0x773f8c8*/ void AddNamespace(string prefix, string ns, System.Xml.XmlWellFormedWriter.NamespaceKind kind);
            /*0x773fb90*/ void AddToNamespaceHashtable(int namespaceIndex);
            /*0x773f7ec*/ int LookupNamespaceIndex(string prefix);
            /*0x773a9a0*/ void PopNamespaces(int indexFrom, int indexTo);
            /*0x77395e4*/ void AdvanceState(System.Xml.XmlWellFormedWriter.Token token);
            /*0x773fef4*/ void StartElementContent();
            /*0x773a254*/ string LookupNamespace(string prefix);
            /*0x773b52c*/ string LookupLocalNamespace(string prefix);
            /*0x773b3f4*/ string GeneratePrefix();
            /*0x773a154*/ void CheckNCName(string ncname);
            /*0x773fd18*/ void ThrowInvalidStateTransition(System.Xml.XmlWellFormedWriter.Token token, System.Xml.XmlWellFormedWriter.State currentState);
            /*0x773f738*/ bool get_IsClosedOrErrorState();
            /*0x773b5fc*/ void AddAttribute(string prefix, string localName, string namespaceName);
            /*0x77402e8*/ void AddToAttrHashTable(int attributeIndex);

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

                /*0x7739158*/ NamespaceResolverProxy(System.Xml.XmlWellFormedWriter wfWriter);
                /*0x7740c14*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
                /*0x7740c4c*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
                /*0x7740c64*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            }

            struct ElementScope
            {
                /*0x10*/ int prevNSTop;
                /*0x18*/ string prefix;
                /*0x20*/ string localName;
                /*0x28*/ string namespaceUri;
                /*0x30*/ System.Xml.XmlSpace xmlSpace;
                /*0x38*/ string xmlLang;

                /*0x77391c8*/ void Set(string prefix, string localName, string namespaceUri, int prevNSTop);
                /*0x773a970*/ void WriteEndElement(System.Xml.XmlRawWriter rawWriter);
                /*0x773ac54*/ void WriteFullEndElement(System.Xml.XmlRawWriter rawWriter);
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

                /*0x7739188*/ void Set(string prefix, string namespaceUri, System.Xml.XmlWellFormedWriter.NamespaceKind kind);
                /*0x773ffbc*/ void WriteDecl(System.Xml.XmlWriter writer, System.Xml.XmlRawWriter rawWriter);
            }

            struct AttrName
            {
                /*0x10*/ string prefix;
                /*0x18*/ string namespaceUri;
                /*0x20*/ string localName;
                /*0x28*/ int prev;

                /*0x7740230*/ void Set(string prefix, string localName, string namespaceUri);
                /*0x774027c*/ bool IsDuplicate(string prefix, string localName, string namespaceUri);
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

                /*0x773f76c*/ AttributeValueCache();
                /*0x773c0f0*/ string get_StringValue();
                /*0x773d36c*/ void WriteEntityRef(string name);
                /*0x773d684*/ void WriteCharEntity(char ch);
                /*0x773d870*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
                /*0x773dac8*/ void WriteWhitespace(string ws);
                /*0x773dc08*/ void WriteString(string text);
                /*0x773ded8*/ void WriteChars(char[] buffer, int index, int count);
                /*0x773e1ec*/ void WriteRaw(char[] buffer, int index, int count);
                /*0x773e394*/ void WriteRaw(string data);
                /*0x773f5bc*/ void WriteValue(string value);
                /*0x773c5dc*/ void Replay(System.Xml.XmlWriter writer);
                /*0x773c8d4*/ void Trim();
                /*0x773cd60*/ void Clear();
                /*0x7740c88*/ void StartComplexValue();
                /*0x7740cd8*/ void AddItem(System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType type, object data);

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

                    /*0x7740ec0*/ Item();
                    /*0x7740ec8*/ void Set(System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType type, object data);
                }

                class BufferChunk
                {
                    /*0x10*/ char[] buffer;
                    /*0x18*/ int index;
                    /*0x1c*/ int count;

                    /*0x7740e78*/ BufferChunk(char[] buffer, int index, int count);
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

            static /*0x7741cc0*/ System.Xml.XmlWriter Create(System.IO.Stream output, System.Xml.XmlWriterSettings settings);
            static /*0x774222c*/ System.Xml.XmlWriter Create(System.IO.TextWriter output, System.Xml.XmlWriterSettings settings);
            /*0x7739150*/ XmlWriter();
            /*0x380cb08*/ void WriteStartDocument();
            /*0x380cdf0*/ void WriteStartDocument(bool standalone);
            /*0x380cb08*/ void WriteEndDocument();
            /*0x380da84*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x7740ed8*/ void WriteStartElement(string localName, string ns);
            /*0x380da4c*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x7740ef0*/ void WriteStartElement(string localName);
            /*0x380cb08*/ void WriteEndElement();
            /*0x380cb08*/ void WriteFullEndElement();
            /*0x7740f08*/ void WriteAttributeString(string localName, string ns, string value);
            /*0x7740f64*/ void WriteAttributeString(string localName, string value);
            /*0x7740fc0*/ void WriteAttributeString(string prefix, string localName, string ns, string value);
            /*0x380da4c*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x380cb08*/ void WriteEndAttribute();
            /*0x380d83c*/ void WriteCData(string text);
            /*0x380d83c*/ void WriteComment(string text);
            /*0x380d93c*/ void WriteProcessingInstruction(string name, string text);
            /*0x380d83c*/ void WriteEntityRef(string name);
            void WriteCharEntity(char ch);
            /*0x380d83c*/ void WriteWhitespace(string ws);
            /*0x380d83c*/ void WriteString(string text);
            void WriteSurrogateCharEntity(char lowChar, char highChar);
            void WriteChars(char[] buffer, int index, int count);
            void WriteRaw(char[] buffer, int index, int count);
            /*0x380d83c*/ void WriteRaw(string data);
            void WriteBase64(byte[] buffer, int index, int count);
            /*0x773f748*/ void WriteBinHex(byte[] buffer, int index, int count);
            /*0x380b6a0*/ System.Xml.WriteState get_WriteState();
            /*0x7741010*/ void Close();
            /*0x380cb08*/ void Flush();
            /*0x380bb68*/ string LookupPrefix(string ns);
            /*0x7741014*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x774101c*/ string get_XmlLang();
            /*0x7741034*/ void WriteQualifiedName(string localName, string ns);
            /*0x7741180*/ void WriteValue(string value);
            /*0x7741198*/ void WriteValue(bool value);
            /*0x7741214*/ void WriteValue(System.DateTime value);
            /*0x7741294*/ void WriteValue(double value);
            /*0x7741310*/ void WriteValue(float value);
            /*0x774138c*/ void WriteValue(decimal value);
            /*0x7741410*/ void WriteValue(int value);
            /*0x774148c*/ void WriteValue(long value);
            /*0x7741508*/ void WriteAttributes(System.Xml.XmlReader reader, bool defattr);
            /*0x7741784*/ void WriteNode(System.Xml.XmlReader reader, bool defattr);
            /*0x7741bf8*/ void WriteElementString(string localName, string value);
            /*0x7741c04*/ void WriteElementString(string localName, string ns, string value);
            /*0x7741c68*/ void Dispose();
            /*0x7741c7c*/ void Dispose(bool disposing);
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

            /*0x7741d28*/ XmlWriterSettings();
            /*0x77426bc*/ bool get_Async();
            /*0x77426c4*/ System.Text.Encoding get_Encoding();
            /*0x77426cc*/ bool get_OmitXmlDeclaration();
            /*0x77426d4*/ void set_OmitXmlDeclaration(bool value);
            /*0x77427e8*/ System.Xml.NewLineHandling get_NewLineHandling();
            /*0x77427f0*/ string get_NewLineChars();
            /*0x77427f8*/ bool get_Indent();
            /*0x7742808*/ void set_Indent(bool value);
            /*0x7742870*/ string get_IndentChars();
            /*0x7742878*/ bool get_NewLineOnAttributes();
            /*0x7742880*/ bool get_CloseOutput();
            /*0x7742888*/ System.Xml.ConformanceLevel get_ConformanceLevel();
            /*0x7742890*/ void set_ConformanceLevel(System.Xml.ConformanceLevel value);
            /*0x774293c*/ bool get_CheckCharacters();
            /*0x7742944*/ System.Xml.NamespaceHandling get_NamespaceHandling();
            /*0x774294c*/ void set_NamespaceHandling(System.Xml.NamespaceHandling value);
            /*0x77429f8*/ bool get_WriteEndDocumentOnClose();
            /*0x7742a00*/ System.Xml.XmlOutputMethod get_OutputMethod();
            /*0x7742a08*/ void set_OutputMethod(System.Xml.XmlOutputMethod value);
            /*0x7742a10*/ System.Xml.XmlWriterSettings Clone();
            /*0x7742ae4*/ System.Collections.Generic.List<System.Xml.XmlQualifiedName> get_CDataSectionElements();
            /*0x7742aec*/ bool get_DoNotEscapeUriAttributes();
            /*0x7742af4*/ bool get_MergeCDataSections();
            /*0x7742afc*/ string get_MediaType();
            /*0x7742b04*/ string get_DocTypeSystem();
            /*0x7742b0c*/ string get_DocTypePublic();
            /*0x7742b14*/ System.Xml.XmlStandalone get_Standalone();
            /*0x7742b1c*/ bool get_AutoXmlDeclaration();
            /*0x7742b24*/ System.Xml.TriState get_IndentInternal();
            /*0x7742b2c*/ bool get_IsQuerySpecific();
            /*0x7741db8*/ System.Xml.XmlWriter CreateWriter(System.IO.Stream output);
            /*0x7742294*/ System.Xml.XmlWriter CreateWriter(System.IO.TextWriter output);
            /*0x7742b9c*/ void set_ReadOnly(bool value);
            /*0x7742734*/ void CheckReadOnly(string propertyName);
            /*0x774258c*/ void Initialize();
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

            /*0x7742ba8*/ XsdCachingReader(System.Xml.XmlReader reader, System.Xml.IXmlLineInfo lineInfo, System.Xml.CachingEventHandler handlerMethod);
            /*0x7742ca0*/ void Init();
            /*0x7743120*/ void Reset(System.Xml.XmlReader reader);
            /*0x774313c*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x774315c*/ System.Xml.XmlNodeType get_NodeType();
            /*0x7743178*/ string get_Name();
            /*0x774319c*/ string get_LocalName();
            /*0x77431b8*/ string get_NamespaceURI();
            /*0x77431d4*/ string get_Prefix();
            /*0x77431f0*/ string get_Value();
            /*0x7743220*/ int get_Depth();
            /*0x774323c*/ string get_BaseURI();
            /*0x7743260*/ bool get_IsEmptyElement();
            /*0x7743268*/ bool get_IsDefault();
            /*0x7743270*/ char get_QuoteChar();
            /*0x7743294*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x77432b8*/ string get_XmlLang();
            /*0x77432dc*/ int get_AttributeCount();
            /*0x77432e4*/ string GetAttribute(string name);
            /*0x77434c0*/ string GetAttribute(string name, string namespaceURI);
            /*0x77435b8*/ string GetAttribute(int i);
            /*0x7743648*/ bool MoveToAttribute(string name);
            /*0x77436e0*/ bool MoveToAttribute(string name, string ns);
            /*0x7743810*/ void MoveToAttribute(int i);
            /*0x77438a0*/ bool MoveToFirstAttribute();
            /*0x77438e4*/ bool MoveToNextAttribute();
            /*0x7743944*/ bool MoveToElement();
            /*0x7743998*/ bool Read();
            /*0x7743c88*/ System.Xml.ValidatingReaderNodeData RecordTextNode(string textValue, string originalStringValue, int depth, int lineNo, int linePos);
            /*0x7743d00*/ void SwitchTextNodeAndEndElement(string textValue, string originalStringValue);
            /*0x7743e10*/ void RecordEndElementNode();
            /*0x7743f40*/ string ReadOriginalContentAsString();
            /*0x7743f64*/ bool get_EOF();
            /*0x7743fa0*/ void Close();
            /*0x7743fd4*/ System.Xml.ReadState get_ReadState();
            /*0x7743ff8*/ void Skip();
            /*0x774410c*/ System.Xml.XmlNameTable get_NameTable();
            /*0x7744114*/ string LookupNamespace(string prefix);
            /*0x7744138*/ void ResolveEntity();
            /*0x7744170*/ bool ReadAttributeValue();
            /*0x774426c*/ bool System.Xml.IXmlLineInfo.HasLineInfo();
            /*0x7744274*/ int System.Xml.IXmlLineInfo.get_LineNumber();
            /*0x7744290*/ int System.Xml.IXmlLineInfo.get_LinePosition();
            /*0x77442ac*/ void SetToReplayMode();
            /*0x77442cc*/ System.Xml.XmlReader GetCoreReader();
            /*0x77442d4*/ System.Xml.IXmlLineInfo GetLineInfo();
            /*0x7743c78*/ void ClearAttributesInfo();
            /*0x77442dc*/ System.Xml.ValidatingReaderNodeData AddAttribute(int attIndex);
            /*0x7742e0c*/ System.Xml.ValidatingReaderNodeData AddContent(System.Xml.XmlNodeType nodeType);
            /*0x7742f9c*/ void RecordAttributes();
            /*0x7743370*/ int GetAttributeIndexWithoutPrefix(string name);
            /*0x7743420*/ int GetAttributeIndexWithPrefix(string name);
            /*0x77441cc*/ System.Xml.ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth);

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
            /*0x7744450*/ CachingEventHandler(object object, nint method);
            /*0x7744558*/ void Invoke(System.Xml.XsdCachingReader cachingReader);
        }

        class AttributePSVIInfo
        {
            /*0x10*/ string localName;
            /*0x18*/ string namespaceUri;
            /*0x20*/ object typedAttributeValue;
            /*0x28*/ System.Xml.Schema.XmlSchemaInfo attributeSchemaInfo;

            /*0x774456c*/ AttributePSVIInfo();
            /*0x77445d8*/ void Reset();
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

            /*0x7744644*/ XsdValidatingReader(System.Xml.XmlReader reader, System.Xml.XmlResolver xmlResolver, System.Xml.XmlReaderSettings readerSettings, System.Xml.Schema.XmlSchemaObject partialValidationType);
            /*0x7744e00*/ XsdValidatingReader(System.Xml.XmlReader reader, System.Xml.XmlResolver xmlResolver, System.Xml.XmlReaderSettings readerSettings);
            /*0x7744850*/ void Init();
            /*0x7744bf0*/ void SetupValidator(System.Xml.XmlReaderSettings readerSettings, System.Xml.XmlReader reader, System.Xml.Schema.XmlSchemaObject partialValidationType);
            /*0x7744e08*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x7744ed8*/ System.Xml.XmlNodeType get_NodeType();
            /*0x7744f60*/ string get_Name();
            /*0x7745078*/ string get_LocalName();
            /*0x77450b4*/ string get_NamespaceURI();
            /*0x77450f0*/ string get_Prefix();
            /*0x774512c*/ string get_Value();
            /*0x7745168*/ int get_Depth();
            /*0x77451a4*/ string get_BaseURI();
            /*0x77451c8*/ bool get_IsEmptyElement();
            /*0x77451ec*/ bool get_IsDefault();
            /*0x7745228*/ char get_QuoteChar();
            /*0x774524c*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x7745270*/ string get_XmlLang();
            /*0x7745294*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x7745298*/ System.Type get_ValueType();
            /*0x774537c*/ object ReadContentAsObject();
            /*0x7745464*/ bool ReadContentAsBoolean();
            /*0x7745768*/ System.DateTime ReadContentAsDateTime();
            /*0x7745a08*/ double ReadContentAsDouble();
            /*0x7745ca8*/ float ReadContentAsFloat();
            /*0x7745f48*/ decimal ReadContentAsDecimal();
            /*0x77461e8*/ int ReadContentAsInt();
            /*0x7746488*/ long ReadContentAsLong();
            /*0x7746728*/ string ReadContentAsString();
            /*0x7746994*/ object ReadContentAs(System.Type returnType, System.Xml.IXmlNamespaceResolver namespaceResolver);
            /*0x7746f64*/ bool ReadElementContentAsBoolean();
            /*0x77471c8*/ System.DateTime ReadElementContentAsDateTime();
            /*0x7747414*/ double ReadElementContentAsDouble();
            /*0x7747660*/ float ReadElementContentAsFloat();
            /*0x77478ac*/ decimal ReadElementContentAsDecimal();
            /*0x7747af8*/ int ReadElementContentAsInt();
            /*0x7747d44*/ long ReadElementContentAsLong();
            /*0x7747f90*/ string ReadElementContentAsString();
            /*0x774818c*/ int get_AttributeCount();
            /*0x7748194*/ string GetAttribute(string name);
            /*0x7748378*/ string GetAttribute(string name, string namespaceURI);
            /*0x774858c*/ string GetAttribute(int i);
            /*0x7748668*/ bool MoveToAttribute(string name);
            /*0x77488b8*/ bool MoveToAttribute(string name, string ns);
            /*0x7748ab0*/ void MoveToAttribute(int i);
            /*0x7748c7c*/ bool MoveToFirstAttribute();
            /*0x7748e0c*/ bool MoveToNextAttribute();
            /*0x7748f9c*/ bool MoveToElement();
            /*0x7748ff0*/ bool Read();
            /*0x77493f8*/ bool get_EOF();
            /*0x774941c*/ void Close();
            /*0x7749450*/ System.Xml.ReadState get_ReadState();
            /*0x774948c*/ void Skip();
            /*0x77495f8*/ System.Xml.XmlNameTable get_NameTable();
            /*0x7749600*/ string LookupNamespace(string prefix);
            /*0x77496ac*/ void ResolveEntity();
            /*0x77496e4*/ bool ReadAttributeValue();
            /*0x774984c*/ int ReadContentAsBase64(byte[] buffer, int index, int count);
            /*0x7749910*/ int ReadContentAsBinHex(byte[] buffer, int index, int count);
            /*0x77499d4*/ bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault();
            /*0x7749cfc*/ bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil();
            /*0x7749d48*/ System.Xml.Schema.XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity();
            /*0x7749ddc*/ System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType();
            /*0x7749f64*/ System.Xml.Schema.XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType();
            /*0x7749fc0*/ System.Xml.Schema.XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement();
            /*0x774a014*/ System.Xml.Schema.XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute();
            /*0x774a058*/ bool HasLineInfo();
            /*0x774a060*/ int get_LineNumber();
            /*0x774a110*/ int get_LinePosition();
            /*0x774a1c0*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x774a280*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0x774a344*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            /*0x774a408*/ object GetStringValue();
            /*0x774571c*/ System.Xml.Schema.XmlSchemaType get_ElementXmlType();
            /*0x7745738*/ System.Xml.Schema.XmlSchemaType get_AttributeXmlType();
            /*0x7745360*/ System.Xml.Schema.XmlSchemaInfo get_AttributeSchemaInfo();
            /*0x7749140*/ void ProcessReaderEvent();
            /*0x774a428*/ void ProcessElementEvent();
            /*0x774a8e0*/ void ProcessEndElementEvent();
            /*0x774aa94*/ void ValidateAttributes();
            /*0x77493b4*/ void ClearAttributesInfo();
            /*0x7748744*/ System.Xml.AttributePSVIInfo GetAttributePSVI(string name);
            /*0x7748a08*/ System.Xml.AttributePSVIInfo GetAttributePSVI(string localName, string ns);
            /*0x7748200*/ System.Xml.ValidatingReaderNodeData GetDefaultAttribute(string name, bool updatePosition);
            /*0x7748448*/ System.Xml.ValidatingReaderNodeData GetDefaultAttribute(string attrLocalName, string ns, bool updatePosition);
            /*0x774adc0*/ System.Xml.AttributePSVIInfo AddAttributePSVI(int attIndex);
            /*0x774aa44*/ bool IsXSDRoot(string localName, string ns);
            /*0x77492ec*/ void ProcessInlineSchema();
            /*0x7745700*/ object InternalReadContentAsObject();
            /*0x7745448*/ object InternalReadContentAsObject(bool unwrapTypedValue);
            /*0x7746d0c*/ object InternalReadContentAsObject(bool unwrapTypedValue, ref string originalStringValue);
            /*0x77471ac*/ object InternalReadElementContentAsObject(ref System.Xml.Schema.XmlSchemaType xmlType);
            /*0x774b248*/ object InternalReadElementContentAsObject(ref System.Xml.Schema.XmlSchemaType xmlType, bool unwrapTypedValue);
            /*0x774b264*/ object InternalReadElementContentAsObject(ref System.Xml.Schema.XmlSchemaType xmlType, bool unwrapTypedValue, ref string originalString);
            /*0x774b06c*/ object ReadTillEndElement();
            /*0x774b440*/ void SwitchReader();
            /*0x774b4c8*/ void ReadAheadForMemberType();
            /*0x7749a5c*/ void GetIsDefault();
            /*0x7749e5c*/ void GetMemberType();
            /*0x774af24*/ object ReturnBoxedValue(object typedValue, System.Xml.Schema.XmlSchemaType xmlType, bool unWrap);
            /*0x774acc0*/ System.Xml.XsdCachingReader GetCachingReader();
            /*0x77497ac*/ System.Xml.ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth);
            /*0x774b6bc*/ void CachingCallBack(System.Xml.XsdCachingReader cachingReader);
            /*0x774ac60*/ string GetOriginalAtomicValueStringOfElement();

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

            static /*0x774c46c*/ bool MoveToFirstNamespaceLocal(System.Xml.XmlAttributeCollection attributes, ref int index);
            static /*0x774c60c*/ bool MoveToFirstNamespaceGlobal(ref System.Xml.XmlAttributeCollection attributes, ref int index);
            static /*0x774ccb4*/ bool MoveToNextNamespaceLocal(System.Xml.XmlAttributeCollection attributes, ref int index);
            static /*0x774c760*/ bool MoveToNextNamespaceGlobal(ref System.Xml.XmlAttributeCollection attributes, ref int index);
            static /*0x774cc20*/ bool ResetAttributePosition(System.Xml.XmlAttribute attribute, System.Xml.XmlAttributeCollection attributes, ref int index);
            static /*0x774cb70*/ bool CheckAttributePosition(System.Xml.XmlAttribute attribute, ref System.Xml.XmlAttributeCollection attributes, int index);
            /*0x774b704*/ DocumentXPathNavigator(System.Xml.XmlDocument document, System.Xml.XmlNode node);
            /*0x774b870*/ DocumentXPathNavigator(System.Xml.DocumentXPathNavigator other);
            /*0x774b914*/ System.Xml.XPath.XPathNavigator Clone();
            /*0x774b96c*/ System.Xml.XmlNameTable get_NameTable();
            /*0x774b9ac*/ System.Xml.XPath.XPathNodeType get_NodeType();
            /*0x774ba20*/ string get_LocalName();
            /*0x774ba44*/ string get_NamespaceURI();
            /*0x774bb24*/ string get_Prefix();
            /*0x774bbd8*/ string get_Value();
            /*0x774bc70*/ string get_ValueDocument();
            /*0x774bcb8*/ string get_ValueText();
            /*0x774beb8*/ object get_UnderlyingObject();
            /*0x774bed0*/ bool MoveToNamespace(string name);
            /*0x774c200*/ bool MoveToFirstNamespace(System.Xml.XPath.XPathNamespaceScope scope);
            /*0x774c8b4*/ bool MoveToNextNamespace(System.Xml.XPath.XPathNamespaceScope scope);
            /*0x774cd08*/ bool PathHasDuplicateNamespace(System.Xml.XmlElement top, System.Xml.XmlElement bottom, string localName);
            /*0x774cdfc*/ string LookupNamespace(string prefix);
            /*0x774ce58*/ bool MoveToParent();
            /*0x774cfcc*/ bool IsSamePosition(System.Xml.XPath.XPathNavigator other);
            /*0x774d05c*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x774b788*/ void ResetPosition(System.Xml.XmlNode node);
            /*0x774b9d8*/ void CalibrateText();
            /*0x774cf54*/ System.Xml.XmlNode ParentNode(System.Xml.XmlNode node);
            /*0x774d0dc*/ System.Xml.XmlNode ParentNodeTail(System.Xml.XmlNode parent);
            /*0x774be5c*/ System.Xml.XmlNode NextSibling(System.Xml.XmlNode node);
            /*0x774d124*/ System.Xml.XmlNode NextSiblingTail(System.Xml.XmlNode node, System.Xml.XmlNode sibling);
            /*0x774d080*/ System.Xml.XmlNode PreviousText(System.Xml.XmlNode node);
            /*0x774d1d8*/ System.Xml.XmlNode PreviousTextTail(System.Xml.XmlNode node, System.Xml.XmlNode text);
        }

        class DomNameTable
        {
            /*0x10*/ System.Xml.XmlName[] entries;
            /*0x18*/ int count;
            /*0x1c*/ int mask;
            /*0x20*/ System.Xml.XmlDocument ownerDocument;
            /*0x28*/ System.Xml.XmlNameTable nameTable;

            /*0x774d2dc*/ DomNameTable(System.Xml.XmlDocument document);
            /*0x774d380*/ System.Xml.XmlName GetName(string prefix, string localName, string ns, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            /*0x774d524*/ System.Xml.XmlName AddName(string prefix, string localName, string ns, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            /*0x774d858*/ void Grow();
        }

        class XmlAttribute : System.Xml.XmlNode
        {
            /*0x18*/ System.Xml.XmlName name;
            /*0x20*/ System.Xml.XmlLinkedNode lastChild;

            /*0x774d9ac*/ XmlAttribute(System.Xml.XmlName name, System.Xml.XmlDocument doc);
            /*0x774dc38*/ XmlAttribute(string prefix, string localName, string namespaceURI, System.Xml.XmlDocument doc);
            /*0x774dc1c*/ int get_LocalNameHash();
            /*0x774dd88*/ System.Xml.XmlName get_XmlName();
            /*0x774dd90*/ void set_XmlName(System.Xml.XmlName value);
            /*0x774dd98*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x774de60*/ System.Xml.XmlNode get_ParentNode();
            /*0x774de68*/ string get_Name();
            /*0x774e054*/ string get_LocalName();
            /*0x774e070*/ string get_NamespaceURI();
            /*0x774e08c*/ string get_Prefix();
            /*0x774e0a8*/ void set_Prefix(string value);
            /*0x774e150*/ System.Xml.XmlNodeType get_NodeType();
            /*0x774e158*/ System.Xml.XmlDocument get_OwnerDocument();
            /*0x774e174*/ string get_Value();
            /*0x774e184*/ void set_Value(string value);
            /*0x774e194*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x774e19c*/ void set_InnerText(string value);
            /*0x774e1f4*/ bool PrepareOwnerElementInElementIdAttrMap();
            /*0x774e470*/ void ResetOwnerElementInElementIdAttrMap(string oldInnerText);
            /*0x774e6a0*/ bool get_IsContainer();
            /*0x774e6a8*/ System.Xml.XmlNode AppendChildForLoad(System.Xml.XmlNode newChild, System.Xml.XmlDocument doc);
            /*0x774e928*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x774e930*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x774e938*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x774e950*/ bool get_Specified();
            /*0x774e958*/ System.Xml.XmlNode InsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x774ef94*/ System.Xml.XmlNode InsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x774f5a0*/ System.Xml.XmlNode RemoveChild(System.Xml.XmlNode oldChild);
            /*0x774f9e0*/ System.Xml.XmlNode PrependChild(System.Xml.XmlNode newChild);
            /*0x774fadc*/ System.Xml.XmlNode AppendChild(System.Xml.XmlNode newChild);
            /*0x7750024*/ System.Xml.XmlElement get_OwnerElement();
            /*0x77500a0*/ void set_InnerXml(string value);
            /*0x775013c*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x77501f0*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x7750258*/ string get_BaseURI();
            /*0x77502c0*/ void SetParent(System.Xml.XmlNode node);
            /*0x77502c8*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x775031c*/ string get_XmlLang();
            /*0x7750384*/ System.Xml.XPath.XPathNodeType get_XPNodeType();
            /*0x77503a0*/ string get_XPLocalName();
            /*0x774baf8*/ bool get_IsNamespace();
        }

        class XmlAttributeCollection : System.Xml.XmlNamedNodeMap, System.Collections.ICollection, System.Collections.IEnumerable
        {
            /*0x7750434*/ XmlAttributeCollection(System.Xml.XmlNode parent);
            /*0x774c4cc*/ System.Xml.XmlAttribute get_ItemOf(int i);
            /*0x7750570*/ System.Xml.XmlAttribute get_ItemOf(string name);
            /*0x775072c*/ System.Xml.XmlAttribute get_ItemOf(string localName, string namespaceURI);
            /*0x7750874*/ int FindNodeOffsetNS(System.Xml.XmlAttribute node);
            /*0x77509ec*/ System.Xml.XmlNode SetNamedItem(System.Xml.XmlNode node);
            /*0x7750e9c*/ System.Xml.XmlAttribute Append(System.Xml.XmlAttribute node);
            /*0x77511f0*/ System.Xml.XmlAttribute Remove(System.Xml.XmlAttribute node);
            /*0x7751270*/ System.Xml.XmlAttribute RemoveAt(int i);
            /*0x775131c*/ void RemoveAll();
            /*0x7751364*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
            /*0x77513e4*/ bool System.Collections.ICollection.get_IsSynchronized();
            /*0x77513ec*/ object System.Collections.ICollection.get_SyncRoot();
            /*0x77513f0*/ int System.Collections.ICollection.get_Count();
            /*0x7751400*/ System.Xml.XmlNode AddNode(System.Xml.XmlNode node);
            /*0x7751750*/ System.Xml.XmlNode InsertNodeAt(int i, System.Xml.XmlNode node);
            /*0x7751990*/ System.Xml.XmlNode RemoveNodeAt(int i);
            /*0x7750fac*/ void Detach(System.Xml.XmlAttribute attr);
            /*0x7751098*/ void InsertParentIntoElementIdAttrMap(System.Xml.XmlAttribute attr);
            /*0x7751b2c*/ void RemoveParentFromElementIdAttrMap(System.Xml.XmlAttribute attr);
            /*0x77514d4*/ int RemoveDuplicateAttribute(System.Xml.XmlAttribute attr);
            /*0x774e4ec*/ bool PrepareParentInElementIdAttrMap(string attrPrefix, string attrLocalName);
            /*0x774e5e0*/ void ResetParentInElementIdAttrMap(string oldVal, string newVal);
            /*0x7750c9c*/ System.Xml.XmlAttribute InternalAppendAttribute(System.Xml.XmlAttribute node);
        }

        class XmlCDataSection : System.Xml.XmlCharacterData
        {
            /*0x7752264*/ XmlCDataSection(string data, System.Xml.XmlDocument doc);
            /*0x77522a8*/ string get_Name();
            /*0x77522d0*/ string get_LocalName();
            /*0x77522f8*/ System.Xml.XmlNodeType get_NodeType();
            /*0x7752300*/ System.Xml.XmlNode get_ParentNode();
            /*0x7752384*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x77523e0*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x7752420*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x7752424*/ System.Xml.XPath.XPathNodeType get_XPNodeType();
            /*0x775242c*/ bool get_IsText();
            /*0x7752434*/ System.Xml.XmlNode get_PreviousText();
        }

        class XmlCharacterData : System.Xml.XmlLinkedNode
        {
            /*0x20*/ string data;

            /*0x7752268*/ XmlCharacterData(string data, System.Xml.XmlDocument doc);
            /*0x7752490*/ string get_Value();
            /*0x77524a0*/ void set_Value(string value);
            /*0x77524b0*/ string get_InnerText();
            /*0x77524bc*/ void set_InnerText(string value);
            /*0x77524c8*/ string get_Data();
            /*0x77524ec*/ void set_Data(string value);
            /*0x77525b0*/ bool CheckOnData(string data);
            /*0x77525ec*/ bool DecideXPNodeTypeForTextNodes(System.Xml.XmlNode node, ref System.Xml.XPath.XPathNodeType xnt);
        }

        class XmlChildEnumerator : System.Collections.IEnumerator
        {
            /*0x10*/ System.Xml.XmlNode container;
            /*0x18*/ System.Xml.XmlNode child;
            /*0x20*/ bool isFirst;

            /*0x77526c0*/ XmlChildEnumerator(System.Xml.XmlNode container);
            /*0x7752728*/ bool System.Collections.IEnumerator.MoveNext();
            /*0x775272c*/ bool MoveNext();
            /*0x77527bc*/ void System.Collections.IEnumerator.Reset();
            /*0x77527fc*/ object System.Collections.IEnumerator.get_Current();
            /*0x7752800*/ System.Xml.XmlNode get_Current();
        }

        class XmlChildNodes : System.Xml.XmlNodeList
        {
            /*0x10*/ System.Xml.XmlNode container;

            /*0x7752874*/ XmlChildNodes(System.Xml.XmlNode container);
            /*0x77528ac*/ System.Xml.XmlNode Item(int i);
            /*0x7752908*/ int get_Count();
            /*0x7752954*/ System.Collections.IEnumerator GetEnumerator();
        }

        class XmlComment : System.Xml.XmlCharacterData
        {
            /*0x7752a04*/ XmlComment(string comment, System.Xml.XmlDocument doc);
            /*0x7752a08*/ string get_Name();
            /*0x7752a30*/ string get_LocalName();
            /*0x7752a58*/ System.Xml.XmlNodeType get_NodeType();
            /*0x7752a60*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x7752abc*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x7752afc*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x7752b00*/ System.Xml.XPath.XPathNodeType get_XPNodeType();
        }

        class XmlDeclaration : System.Xml.XmlLinkedNode
        {
            /*0x20*/ string version;
            /*0x28*/ string encoding;
            /*0x30*/ string standalone;

            /*0x7752b08*/ XmlDeclaration(string version, string encoding, string standalone, System.Xml.XmlDocument doc);
            /*0x7752e94*/ string get_Version();
            /*0x7752e9c*/ void set_Version(string value);
            /*0x7752ea4*/ string get_Encoding();
            /*0x7752d20*/ void set_Encoding(string value);
            /*0x7752eac*/ string get_Standalone();
            /*0x7752d50*/ void set_Standalone(string value);
            /*0x7752eb4*/ string get_Value();
            /*0x7752ec4*/ void set_Value(string value);
            /*0x7752ed4*/ string get_InnerText();
            /*0x7753048*/ void set_InnerText(string value);
            /*0x7753438*/ string get_Name();
            /*0x7753478*/ string get_LocalName();
            /*0x7753484*/ System.Xml.XmlNodeType get_NodeType();
            /*0x775348c*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x77534c8*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x775352c*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x7752ca4*/ bool IsValidXmlVersion(string ver);
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

            static /*0x7757c28*/ XmlDocument();
            static /*0x774db48*/ void CheckName(string name);
            static /*0x7755cb4*/ bool IsTextNode(System.Xml.XmlNodeType nt);
            /*0x7753530*/ XmlDocument();
            /*0x7753a94*/ XmlDocument(System.Xml.XmlNameTable nt);
            /*0x77535f4*/ XmlDocument(System.Xml.XmlImplementation imp);
            /*0x7753b44*/ System.Xml.Schema.SchemaInfo get_DtdSchemaInfo();
            /*0x7753b4c*/ void set_DtdSchemaInfo(System.Xml.Schema.SchemaInfo value);
            /*0x7753b54*/ System.Xml.XmlName AddXmlName(string prefix, string localName, string namespaceURI, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            /*0x7753b6c*/ System.Xml.XmlName GetXmlName(string prefix, string localName, string namespaceURI, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            /*0x774dc74*/ System.Xml.XmlName AddAttrXmlName(string prefix, string localName, string namespaceURI, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            /*0x7753b84*/ bool AddIdInfo(System.Xml.XmlName eleName, System.Xml.XmlName attrName);
            /*0x7753c50*/ System.Xml.XmlName GetIDInfoByElement_(System.Xml.XmlName eleName);
            /*0x7751f18*/ System.Xml.XmlName GetIDInfoByElement(System.Xml.XmlName eleName);
            /*0x7753d18*/ System.WeakReference GetElement(System.Collections.ArrayList elementList, System.Xml.XmlElement elem);
            /*0x7751f2c*/ void AddElementWithId(string id, System.Xml.XmlElement elem);
            /*0x7752120*/ void RemoveElementWithId(string id, System.Xml.XmlElement elem);
            /*0x7754374*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x7754478*/ System.Xml.XmlNodeType get_NodeType();
            /*0x7754480*/ System.Xml.XmlNode get_ParentNode();
            /*0x7754488*/ System.Xml.XmlDocumentType get_DocumentType();
            /*0x7754514*/ System.Xml.XmlDeclaration get_Declaration();
            /*0x77545b8*/ System.Xml.XmlImplementation get_Implementation();
            /*0x77545c0*/ string get_Name();
            /*0x77545c8*/ string get_LocalName();
            /*0x774bdd0*/ System.Xml.XmlElement get_DocumentElement();
            /*0x77545d0*/ bool get_IsContainer();
            /*0x77545d8*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x77545e0*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x77545e8*/ System.Xml.XmlDocument get_OwnerDocument();
            /*0x77545f0*/ void set_Schemas(System.Xml.Schema.XmlSchemaSet value);
            /*0x77545f8*/ bool get_CanReportValidity();
            /*0x7754600*/ bool get_HasSetResolver();
            /*0x7754608*/ System.Xml.XmlResolver GetResolver();
            /*0x7754610*/ void set_XmlResolver(System.Xml.XmlResolver value);
            /*0x77547a8*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x7754890*/ bool HasNodeTypeInPrevSiblings(System.Xml.XmlNodeType nt, System.Xml.XmlNode refNode);
            /*0x7754940*/ bool HasNodeTypeInNextSiblings(System.Xml.XmlNodeType nt, System.Xml.XmlNode refNode);
            /*0x77549a4*/ bool CanInsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x7754b0c*/ bool CanInsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x7754c08*/ System.Xml.XmlAttribute CreateAttribute(string name);
            /*0x7754d5c*/ void SetDefaultNamespace(string prefix, string localName, ref string namespaceURI);
            /*0x7754e00*/ System.Xml.XmlCDataSection CreateCDataSection(string data);
            /*0x7754e70*/ System.Xml.XmlComment CreateComment(string data);
            /*0x7754ed8*/ System.Xml.XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset);
            /*0x7755068*/ System.Xml.XmlDocumentFragment CreateDocumentFragment();
            /*0x7755144*/ System.Xml.XmlElement CreateElement(string name);
            /*0x77551c8*/ void AddDefaultAttributes(System.Xml.XmlElement elem);
            /*0x7755444*/ System.Xml.Schema.SchemaElementDecl GetSchemaElementDecl(System.Xml.XmlElement elem);
            /*0x7755550*/ System.Xml.XmlAttribute PrepareDefaultAttribute(System.Xml.Schema.SchemaAttDef attdef, string attrPrefix, string attrLocalname, string attrNamespaceURI);
            /*0x775564c*/ System.Xml.XmlEntityReference CreateEntityReference(string name);
            /*0x77557b0*/ System.Xml.XmlProcessingInstruction CreateProcessingInstruction(string target, string data);
            /*0x7755824*/ System.Xml.XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone);
            /*0x77558a4*/ System.Xml.XmlText CreateTextNode(string text);
            /*0x7755910*/ System.Xml.XmlSignificantWhitespace CreateSignificantWhitespace(string text);
            /*0x775597c*/ System.Xml.XPath.XPathNavigator CreateNavigator();
            /*0x7755990*/ System.Xml.XPath.XPathNavigator CreateNavigator(System.Xml.XmlNode node);
            /*0x7755b04*/ System.Xml.XmlNode NormalizeText(System.Xml.XmlNode n);
            /*0x7755cd8*/ System.Xml.XmlWhitespace CreateWhitespace(string text);
            /*0x7755d44*/ System.Xml.XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI);
            /*0x7755dc4*/ System.Xml.XmlElement CreateElement(string qualifiedName, string namespaceURI);
            /*0x7755e44*/ System.Xml.XmlNode ImportNodeInternal(System.Xml.XmlNode node, bool deep);
            /*0x77562ec*/ void ImportAttributes(System.Xml.XmlNode fromElem, System.Xml.XmlNode toElem);
            /*0x77543dc*/ void ImportChildren(System.Xml.XmlNode fromNode, System.Xml.XmlNode toNode, bool deep);
            /*0x774b990*/ System.Xml.XmlNameTable get_NameTable();
            /*0x7756400*/ System.Xml.XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI);
            /*0x7756498*/ System.Xml.XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI);
            /*0x775651c*/ System.Xml.XmlElement CreateElement(string prefix, string localName, string namespaceURI);
            /*0x775671c*/ bool get_IsReadOnly();
            /*0x7756724*/ System.Xml.XmlNamedNodeMap get_Entities();
            /*0x77567a8*/ void set_Entities(System.Xml.XmlNamedNodeMap value);
            /*0x77567b0*/ bool get_IsLoading();
            /*0x77567b8*/ void set_IsLoading(bool value);
            /*0x77567c4*/ bool get_ActualLoadingStatus();
            /*0x77567cc*/ System.Xml.XmlNode ReadNode(System.Xml.XmlReader reader);
            /*0x77569e8*/ System.Xml.XmlTextReader SetupReader(System.Xml.XmlTextReader tr);
            /*0x7756a48*/ void Load(System.Xml.XmlReader reader);
            /*0x7756db8*/ void LoadXml(string xml);
            /*0x7756f08*/ void set_InnerText(string value);
            /*0x7756f60*/ void set_InnerXml(string value);
            /*0x7756f70*/ void Save(System.Xml.XmlWriter w);
            /*0x7757188*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x7757198*/ void WriteContentTo(System.Xml.XmlWriter xw);
            /*0x77574bc*/ System.Xml.XmlNodeChangedEventArgs GetEventArgs(System.Xml.XmlNode node, System.Xml.XmlNode oldParent, System.Xml.XmlNode newParent, string oldValue, string newValue, System.Xml.XmlNodeChangedAction action);
            /*0x774e850*/ System.Xml.XmlNodeChangedEventArgs GetInsertEventArgsForLoad(System.Xml.XmlNode node, System.Xml.XmlNode newParent);
            /*0x775768c*/ void BeforeEvent(System.Xml.XmlNodeChangedEventArgs args);
            /*0x77576e0*/ void AfterEvent(System.Xml.XmlNodeChangedEventArgs args);
            /*0x7751c84*/ System.Xml.XmlAttribute GetDefaultAttribute(System.Xml.XmlElement elem, string attrPrefix, string attrLocalname, string attrNamespaceURI);
            /*0x7757734*/ string get_Version();
            /*0x7757758*/ string get_Encoding();
            /*0x7757164*/ string get_Standalone();
            /*0x775777c*/ System.Xml.XmlEntity GetEntityNode(string name);
            /*0x77578c4*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x7757a08*/ string get_BaseURI();
            /*0x7757a10*/ void SetBaseURI(string inBaseURI);
            /*0x7757a20*/ System.Xml.XmlNode AppendChildForLoad(System.Xml.XmlNode newChild, System.Xml.XmlDocument doc);
            /*0x7757c18*/ System.Xml.XPath.XPathNodeType get_XPNodeType();
            /*0x7757c20*/ bool get_HasEntityReferences();
            /*0x774c148*/ System.Xml.XmlAttribute get_NamespaceXml();
        }

        class XmlDocumentFragment : System.Xml.XmlNode
        {
            /*0x18*/ System.Xml.XmlLinkedNode lastChild;

            /*0x77550c0*/ XmlDocumentFragment(System.Xml.XmlDocument ownerDocument);
            /*0x7757d44*/ string get_Name();
            /*0x7757d6c*/ string get_LocalName();
            /*0x7757d94*/ System.Xml.XmlNodeType get_NodeType();
            /*0x7757d9c*/ System.Xml.XmlNode get_ParentNode();
            /*0x7757da4*/ System.Xml.XmlDocument get_OwnerDocument();
            /*0x7757e1c*/ void set_InnerXml(string value);
            /*0x77580c8*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x775814c*/ bool get_IsContainer();
            /*0x7758154*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x775815c*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x7758164*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x77581d0*/ bool CanInsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x7758240*/ bool CanInsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x77582a8*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x77582b8*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x7758584*/ System.Xml.XPath.XPathNodeType get_XPNodeType();
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

            /*0x7754f60*/ XmlDocumentType(string name, string publicId, string systemId, string internalSubset, System.Xml.XmlDocument doc);
            /*0x77585f4*/ string get_Name();
            /*0x77585fc*/ string get_LocalName();
            /*0x7758604*/ System.Xml.XmlNodeType get_NodeType();
            /*0x775860c*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x7758648*/ bool get_IsReadOnly();
            /*0x7757840*/ System.Xml.XmlNamedNodeMap get_Entities();
            /*0x7758650*/ System.Xml.XmlNamedNodeMap get_Notations();
            /*0x77586d4*/ string get_PublicId();
            /*0x77586dc*/ string get_SystemId();
            /*0x77586e4*/ string get_InternalSubset();
            /*0x77586ec*/ bool get_ParseWithNamespaces();
            /*0x77586f4*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x7758720*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x7758724*/ System.Xml.Schema.SchemaInfo get_DtdSchemaInfo();
            /*0x775872c*/ void set_DtdSchemaInfo(System.Xml.Schema.SchemaInfo value);
        }

        class XmlElement : System.Xml.XmlLinkedNode
        {
            /*0x20*/ System.Xml.XmlName name;
            /*0x28*/ System.Xml.XmlAttributeCollection attributes;
            /*0x30*/ System.Xml.XmlLinkedNode lastChild;

            static /*0x77597b4*/ void WriteElementTo(System.Xml.XmlWriter writer, System.Xml.XmlElement e);
            /*0x77565cc*/ XmlElement(System.Xml.XmlName name, bool empty, System.Xml.XmlDocument doc);
            /*0x7758734*/ XmlElement(string prefix, string localName, string namespaceURI, System.Xml.XmlDocument doc);
            /*0x7758778*/ System.Xml.XmlName get_XmlName();
            /*0x7758780*/ void set_XmlName(System.Xml.XmlName value);
            /*0x7758788*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x7758d3c*/ string get_Name();
            /*0x7758d54*/ string get_LocalName();
            /*0x7758d70*/ string get_NamespaceURI();
            /*0x7758d8c*/ string get_Prefix();
            /*0x7758da8*/ void set_Prefix(string value);
            /*0x7758e54*/ System.Xml.XmlNodeType get_NodeType();
            /*0x7758e5c*/ System.Xml.XmlNode get_ParentNode();
            /*0x7758e64*/ System.Xml.XmlDocument get_OwnerDocument();
            /*0x7758e80*/ bool get_IsContainer();
            /*0x7758e88*/ System.Xml.XmlNode AppendChildForLoad(System.Xml.XmlNode newChild, System.Xml.XmlDocument doc);
            /*0x7758cc8*/ bool get_IsEmpty();
            /*0x7758cd8*/ void set_IsEmpty(bool value);
            /*0x7759044*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x7759054*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x775905c*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x7759080*/ System.Xml.XmlAttributeCollection get_Attributes();
            /*0x77591cc*/ bool get_HasAttributes();
            /*0x77591f4*/ string GetAttribute(string name);
            /*0x7759238*/ void SetAttribute(string name, string value);
            /*0x77592dc*/ System.Xml.XmlAttribute GetAttributeNode(string name);
            /*0x7759340*/ System.Xml.XmlAttribute SetAttributeNode(System.Xml.XmlAttribute newAttr);
            /*0x7759450*/ string GetAttribute(string localName, string namespaceURI);
            /*0x7759494*/ string SetAttribute(string localName, string namespaceURI, string value);
            /*0x775956c*/ System.Xml.XmlAttribute GetAttributeNode(string localName, string namespaceURI);
            /*0x77595d8*/ System.Xml.XmlAttribute SetAttributeNode(string localName, string namespaceURI);
            /*0x7759688*/ bool HasAttribute(string name);
            /*0x77596ac*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x7759990*/ void WriteStartElement(System.Xml.XmlWriter w);
            /*0x7759aa8*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x7759b10*/ void RemoveAllAttributes();
            /*0x7759b48*/ void RemoveAll();
            /*0x7759040*/ void RemoveAllChildren();
            /*0x7759bd4*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x7759bdc*/ void set_InnerXml(string value);
            /*0x7759ccc*/ string get_InnerText();
            /*0x7759cd0*/ void set_InnerText(string value);
            /*0x7759d88*/ System.Xml.XmlNode get_NextSibling();
            /*0x7759dc4*/ void SetParent(System.Xml.XmlNode node);
            /*0x7759dcc*/ System.Xml.XPath.XPathNodeType get_XPNodeType();
            /*0x7759dd4*/ string get_XPLocalName();
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

            /*0x7759de4*/ XmlEntity(string name, string strdata, string publicId, string systemId, string notationName, System.Xml.XmlDocument doc);
            /*0x7759ea8*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x7759f00*/ bool get_IsReadOnly();
            /*0x7759f08*/ string get_Name();
            /*0x7759f10*/ string get_LocalName();
            /*0x7759f18*/ string get_InnerText();
            /*0x7759f1c*/ void set_InnerText(string value);
            /*0x7759f74*/ bool get_IsContainer();
            /*0x7759f7c*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x775a054*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x775a05c*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x775a080*/ System.Xml.XmlNodeType get_NodeType();
            /*0x775a088*/ string get_SystemId();
            /*0x775a090*/ void set_InnerXml(string value);
            /*0x775a0e8*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x775a0ec*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x775a0f0*/ string get_BaseURI();
            /*0x775a0f8*/ void SetBaseURI(string inBaseURI);
        }

        class XmlEntityReference : System.Xml.XmlLinkedNode
        {
            /*0x20*/ string name;
            /*0x28*/ System.Xml.XmlLinkedNode lastChild;

            /*0x77556b4*/ XmlEntityReference(string name, System.Xml.XmlDocument doc);
            /*0x775a100*/ string get_Name();
            /*0x775a108*/ string get_LocalName();
            /*0x775a110*/ string get_Value();
            /*0x775a118*/ void set_Value(string value);
            /*0x775a170*/ System.Xml.XmlNodeType get_NodeType();
            /*0x775a178*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x775a1b0*/ bool get_IsReadOnly();
            /*0x775a1b8*/ bool get_IsContainer();
            /*0x775a1c0*/ void SetParent(System.Xml.XmlNode node);
            /*0x775a8d0*/ void SetParentForLoad(System.Xml.XmlNode node);
            /*0x775a8e0*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x775a8e8*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x775a8f0*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x775a914*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x775a940*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x775ac0c*/ string get_BaseURI();
            /*0x775ac3c*/ string ConstructBaseURI(string baseURI, string systemId);
            /*0x775ad10*/ string get_ChildBaseURI();
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

            /*0x7753588*/ XmlImplementation();
            /*0x7753b0c*/ XmlImplementation(System.Xml.XmlNameTable nt);
            /*0x775adac*/ System.Xml.XmlDocument CreateDocument();
            /*0x775ae04*/ System.Xml.XmlNameTable get_NameTable();
        }

        class XmlLinkedNode : System.Xml.XmlNode
        {
            /*0x18*/ System.Xml.XmlLinkedNode next;

            /*0x7752470*/ XmlLinkedNode(System.Xml.XmlDocument doc);
            /*0x775ae0c*/ System.Xml.XmlNode get_PreviousSibling();
            /*0x775ae74*/ System.Xml.XmlNode get_NextSibling();
        }

        class XmlLoader
        {
            /*0x10*/ System.Xml.XmlDocument doc;
            /*0x18*/ System.Xml.XmlReader reader;
            /*0x20*/ bool preserveWhitespace;

            static /*0x77531e0*/ void ParseXmlDeclarationValue(string strValue, ref string version, ref string encoding, ref string standalone);
            static /*0x775bcf4*/ System.Exception UnexpectedNodeType(System.Xml.XmlNodeType nodetype);
            /*0x775012c*/ XmlLoader();
            /*0x7756b54*/ void Load(System.Xml.XmlDocument doc, System.Xml.XmlReader reader, bool preserveWhitespace);
            /*0x775aec4*/ void LoadDocSequence(System.Xml.XmlDocument parentDoc);
            /*0x77568a4*/ System.Xml.XmlNode ReadCurrentNode(System.Xml.XmlDocument doc, System.Xml.XmlReader reader);
            /*0x775af30*/ System.Xml.XmlNode LoadNode(bool skipOverWhitespace);
            /*0x775b4b4*/ System.Xml.XmlAttribute LoadAttributeNode();
            /*0x775be04*/ System.Xml.XmlAttribute LoadDefaultAttribute();
            /*0x775bfa0*/ void LoadAttributeValue(System.Xml.XmlNode parent, bool direct);
            /*0x775b7c8*/ System.Xml.XmlEntityReference LoadEntityReferenceNode(bool direct);
            /*0x775b9a4*/ System.Xml.XmlDeclaration LoadDeclarationNode();
            /*0x775bb48*/ System.Xml.XmlDocumentType LoadDocumentTypeNode();
            /*0x775c2a0*/ System.Xml.XmlNode LoadNodeDirect();
            /*0x775d224*/ System.Xml.XmlAttribute LoadAttributeNodeDirect();
            /*0x775858c*/ void ParseDocumentType(System.Xml.XmlDocumentType dtNode);
            /*0x775d364*/ void ParseDocumentType(System.Xml.XmlDocumentType dtNode, bool bUseResolver, System.Xml.XmlResolver resolver);
            /*0x775c6dc*/ void LoadDocumentType(System.Xml.IDtdInfo dtdInfo, System.Xml.XmlDocumentType dtNode);
            /*0x775d630*/ System.Xml.XmlParserContext GetContext(System.Xml.XmlNode node);
            /*0x7757ea8*/ System.Xml.XmlNamespaceManager ParsePartialContent(System.Xml.XmlNode parentNode, string innerxmltext, System.Xml.XmlNodeType nt);
            /*0x7759c58*/ void LoadInnerXmlElement(System.Xml.XmlElement node, string innerxmltext);
            /*0x7750134*/ void LoadInnerXmlAttribute(System.Xml.XmlAttribute node, string innerxmltext);
            /*0x775e194*/ void RemoveDuplicateNamespace(System.Xml.XmlElement elem, System.Xml.XmlNamespaceManager mgr, bool fCheckElemAttrs);
            /*0x775e434*/ string EntitizeName(string name);
            /*0x775a008*/ void ExpandEntity(System.Xml.XmlEntity ent);
            /*0x775a2b4*/ void ExpandEntityReference(System.Xml.XmlEntityReference eref);
            /*0x775df0c*/ System.Xml.XmlReader CreateInnerXmlReader(string xmlFragment, System.Xml.XmlNodeType nt, System.Xml.XmlParserContext context, System.Xml.XmlDocument doc);
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

            static /*0x774d768*/ System.Xml.XmlName Create(string prefix, string localName, string ns, int hashCode, System.Xml.XmlDocument ownerDoc, System.Xml.XmlName next, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            static /*0x774d4c0*/ int GetHashCode(string name);
            /*0x775e4a0*/ XmlName(string prefix, string localName, string ns, int hashCode, System.Xml.XmlDocument ownerDoc, System.Xml.XmlName next);
            /*0x775e948*/ string get_LocalName();
            /*0x775e950*/ string get_NamespaceURI();
            /*0x775e958*/ string get_Prefix();
            /*0x775e960*/ int get_HashCode();
            /*0x775e968*/ System.Xml.XmlDocument get_OwnerDocument();
            /*0x774de80*/ string get_Name();
            /*0x775e970*/ System.Xml.Schema.XmlSchemaValidity get_Validity();
            /*0x775e978*/ bool get_IsDefault();
            /*0x775e980*/ bool get_IsNil();
            /*0x775e988*/ System.Xml.Schema.XmlSchemaSimpleType get_MemberType();
            /*0x775e990*/ System.Xml.Schema.XmlSchemaType get_SchemaType();
            /*0x775e998*/ System.Xml.Schema.XmlSchemaElement get_SchemaElement();
            /*0x775e9a0*/ System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute();
            /*0x775e9a8*/ bool Equals(System.Xml.Schema.IXmlSchemaInfo schemaInfo);
        }

        class XmlNameEx : System.Xml.XmlName
        {
            /*0x48*/ byte flags;
            /*0x50*/ System.Xml.Schema.XmlSchemaSimpleType memberType;
            /*0x58*/ System.Xml.Schema.XmlSchemaType schemaType;
            /*0x60*/ object decl;

            /*0x775e548*/ XmlNameEx(string prefix, string localName, string ns, int hashCode, System.Xml.XmlDocument ownerDoc, System.Xml.XmlName next, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            /*0x775ea08*/ System.Xml.Schema.XmlSchemaValidity get_Validity();
            /*0x775ea38*/ bool get_IsDefault();
            /*0x775ea44*/ bool get_IsNil();
            /*0x775ea50*/ System.Xml.Schema.XmlSchemaSimpleType get_MemberType();
            /*0x775ea58*/ System.Xml.Schema.XmlSchemaType get_SchemaType();
            /*0x775ea60*/ System.Xml.Schema.XmlSchemaElement get_SchemaElement();
            /*0x775eadc*/ System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute();
            /*0x775e9b4*/ void SetValidity(System.Xml.Schema.XmlSchemaValidity value);
            /*0x775e9c8*/ void SetIsDefault(bool value);
            /*0x775e9e8*/ void SetIsNil(bool value);
            /*0x775eb58*/ bool Equals(System.Xml.Schema.IXmlSchemaInfo schemaInfo);
        }

        class XmlNamedNodeMap : System.Collections.IEnumerable
        {
            /*0x10*/ System.Xml.XmlNode parent;
            /*0x18*/ System.Xml.XmlNamedNodeMap.SmallXmlNodeList nodes;

            /*0x7750464*/ XmlNamedNodeMap(System.Xml.XmlNode parent);
            /*0x775ef34*/ System.Xml.XmlNode GetNamedItem(string name);
            /*0x775f0b0*/ System.Xml.XmlNode SetNamedItem(System.Xml.XmlNode node);
            /*0x77513f8*/ int get_Count();
            /*0x775f1c0*/ System.Collections.IEnumerator GetEnumerator();
            /*0x775efcc*/ int FindNodeOffset(string name);
            /*0x7750b78*/ int FindNodeOffset(string localName, string namespaceURI);
            /*0x77515cc*/ System.Xml.XmlNode AddNode(System.Xml.XmlNode node);
            /*0x7750ff4*/ System.Xml.XmlNode AddNodeForLoad(System.Xml.XmlNode node, System.Xml.XmlDocument doc);
            /*0x7750d34*/ System.Xml.XmlNode RemoveNodeAt(int i);
            /*0x775f16c*/ System.Xml.XmlNode ReplaceNodeAt(int i, System.Xml.XmlNode node);
            /*0x77517f8*/ System.Xml.XmlNode InsertNodeAt(int i, System.Xml.XmlNode node);

            struct SmallXmlNodeList
            {
                /*0x10*/ object field;

                /*0x7750688*/ int get_Count();
                /*0x7750494*/ object get_Item(int index);
                /*0x775f2cc*/ void Add(object value);
                /*0x775f3f8*/ void RemoveAt(int index);
                /*0x775f4e0*/ void Insert(int index, object value);
                /*0x775f1c8*/ System.Collections.IEnumerator GetEnumerator();

                class SingleObjectEnumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ object loneValue;
                    /*0x18*/ int position;

                    /*0x775f688*/ SingleObjectEnumerator(object value);
                    /*0x775f6c0*/ object get_Current();
                    /*0x775f70c*/ bool MoveNext();
                    /*0x775f728*/ void Reset();
                }
            }
        }

        class XmlNode : System.ICloneable, System.Collections.IEnumerable
        {
            /*0x10*/ System.Xml.XmlNode parentNode;

            static /*0x775fe9c*/ bool HasReadOnlyParent(System.Xml.XmlNode n);
            static /*0x7754c90*/ void SplitName(string name, ref string prefix, ref string localName);
            static /*0x774e904*/ void NestTextNodes(System.Xml.XmlNode prevNode, System.Xml.XmlNode nextNode);
            static /*0x775fb6c*/ void UnnestTextNodes(System.Xml.XmlNode prevNode, System.Xml.XmlNode nextNode);
            /*0x7753b3c*/ XmlNode();
            /*0x774dac4*/ XmlNode(System.Xml.XmlDocument doc);
            /*0x775f734*/ System.Xml.XPath.XPathNavigator CreateNavigator();
            /*0x380b9e8*/ string get_Name();
            /*0x775f7d8*/ string get_Value();
            /*0x775f7e0*/ void set_Value(string value);
            /*0x380b6a0*/ System.Xml.XmlNodeType get_NodeType();
            /*0x775f8ac*/ System.Xml.XmlNode get_ParentNode();
            /*0x775f990*/ System.Xml.XmlNodeList get_ChildNodes();
            /*0x775f9f8*/ System.Xml.XmlNode get_PreviousSibling();
            /*0x775fa00*/ System.Xml.XmlNode get_NextSibling();
            /*0x775fa08*/ System.Xml.XmlAttributeCollection get_Attributes();
            /*0x775fa10*/ System.Xml.XmlDocument get_OwnerDocument();
            /*0x775fac8*/ System.Xml.XmlNode get_FirstChild();
            /*0x775faec*/ System.Xml.XmlNode get_LastChild();
            /*0x775fafc*/ bool get_IsContainer();
            /*0x775fb04*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x775fb0c*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x775fb10*/ bool AncestorNode(System.Xml.XmlNode node);
            /*0x774e9e0*/ System.Xml.XmlNode InsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x774f01c*/ System.Xml.XmlNode InsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x774f608*/ System.Xml.XmlNode RemoveChild(System.Xml.XmlNode oldChild);
            /*0x774fa94*/ System.Xml.XmlNode PrependChild(System.Xml.XmlNode newChild);
            /*0x774fb4c*/ System.Xml.XmlNode AppendChild(System.Xml.XmlNode newChild);
            /*0x775fba0*/ System.Xml.XmlNode AppendChildForLoad(System.Xml.XmlNode newChild, System.Xml.XmlDocument doc);
            /*0x775fd68*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x775fd70*/ bool CanInsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x775fd78*/ bool CanInsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x775fd80*/ bool get_HasChildNodes();
            System.Xml.XmlNode CloneNode(bool deep);
            /*0x775fda4*/ void CopyChildren(System.Xml.XmlDocument doc, System.Xml.XmlNode container, bool deep);
            /*0x775fe44*/ string get_NamespaceURI();
            /*0x775fe5c*/ string get_Prefix();
            /*0x775fe74*/ void set_Prefix(string value);
            /*0x380b9e8*/ string get_LocalName();
            /*0x775fe78*/ bool get_IsReadOnly();
            /*0x775ff68*/ object System.ICloneable.Clone();
            /*0x775ff7c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x7757464*/ System.Collections.IEnumerator GetEnumerator();
            /*0x775ffd4*/ void AppendChildText(System.Text.StringBuilder builder);
            /*0x774e2a4*/ string get_InnerText();
            /*0x774e3a0*/ void set_InnerText(string value);
            /*0x77600d8*/ void set_InnerXml(string value);
            /*0x7760130*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x7760188*/ string get_BaseURI();
            /*0x380d83c*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x380d83c*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x7759b6c*/ void RemoveAll();
            /*0x77602a0*/ System.Xml.XmlDocument get_Document();
            /*0x776034c*/ string GetPrefixOfNamespace(string namespaceURI);
            /*0x7760374*/ string GetPrefixOfNamespaceStrict(string namespaceURI);
            /*0x775a278*/ void SetParent(System.Xml.XmlNode node);
            /*0x77606dc*/ void SetParentForLoad(System.Xml.XmlNode node);
            /*0x77606e4*/ System.Xml.XmlNode FindChild(System.Xml.XmlNodeType type);
            /*0x7760748*/ System.Xml.XmlNodeChangedEventArgs GetEventArgs(System.Xml.XmlNode node, System.Xml.XmlNode oldParent, System.Xml.XmlNode newParent, string oldValue, string newValue, System.Xml.XmlNodeChangedAction action);
            /*0x776086c*/ void BeforeEvent(System.Xml.XmlNodeChangedEventArgs args);
            /*0x77608b0*/ void AfterEvent(System.Xml.XmlNodeChangedEventArgs args);
            /*0x77608f4*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x7760a6c*/ string get_XmlLang();
            /*0x7760b58*/ System.Xml.XPath.XPathNodeType get_XPNodeType();
            /*0x7760b60*/ string get_XPLocalName();
            /*0x7760b78*/ bool get_IsText();
            /*0x7760b80*/ System.Xml.XmlNode get_PreviousText();
        }

        class XmlNodeChangedEventArgs : System.EventArgs
        {
            /*0x10*/ System.Xml.XmlNodeChangedAction action;
            /*0x18*/ System.Xml.XmlNode node;
            /*0x20*/ System.Xml.XmlNode oldParent;
            /*0x28*/ System.Xml.XmlNode newParent;
            /*0x30*/ string oldValue;
            /*0x38*/ string newValue;

            /*0x77575b0*/ XmlNodeChangedEventArgs(System.Xml.XmlNode node, System.Xml.XmlNode oldParent, System.Xml.XmlNode newParent, string oldValue, string newValue, System.Xml.XmlNodeChangedAction action);
            /*0x7760b88*/ System.Xml.XmlNodeChangedAction get_Action();
        }

        class XmlNodeChangedEventHandler : System.MulticastDelegate
        {
            /*0x7760b90*/ XmlNodeChangedEventHandler(object object, nint method);
            /*0x7760c9c*/ void Invoke(object sender, System.Xml.XmlNodeChangedEventArgs e);
        }

        class XmlNodeList : System.Collections.IEnumerable, System.IDisposable
        {
            /*0x77528a4*/ XmlNodeList();
            /*0x380ba90*/ System.Xml.XmlNode Item(int index);
            /*0x380b6a0*/ int get_Count();
            /*0x380b9e8*/ System.Collections.IEnumerator GetEnumerator();
            /*0x7760cb0*/ System.Xml.XmlNode get_ItemOf(int i);
            /*0x7760cbc*/ void System.IDisposable.Dispose();
            /*0x7760cc8*/ void PrivateDisposeNodeList();
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

            /*0x7760ccc*/ XmlNodeReaderNavigator(System.Xml.XmlNode node);
            /*0x7761008*/ System.Xml.XmlNodeType get_NodeType();
            /*0x776104c*/ string get_NamespaceURI();
            /*0x7761070*/ string get_Name();
            /*0x7761158*/ string get_LocalName();
            /*0x77611d4*/ bool get_CreatedOnAttribute();
            /*0x7761134*/ bool IsLocalNameEmpty(System.Xml.XmlNodeType nt);
            /*0x77611dc*/ string get_Prefix();
            /*0x7761200*/ string get_Value();
            /*0x7761664*/ string get_BaseURI();
            /*0x7761688*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x77616ac*/ string get_XmlLang();
            /*0x77616d0*/ bool get_IsEmptyElement();
            /*0x776177c*/ bool get_IsDefault();
            /*0x7761830*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x7761854*/ System.Xml.XmlNameTable get_NameTable();
            /*0x776185c*/ int get_AttributeCount();
            /*0x7761acc*/ void CheckIndexCondition(int attributeIndex);
            /*0x7761474*/ void InitDecAttr();
            /*0x7761b34*/ string GetDeclarationAttr(System.Xml.XmlDeclaration decl, string name);
            /*0x7761c14*/ string GetDeclarationAttr(int i);
            /*0x7761c68*/ int GetDecAttrInd(string name);
            /*0x7761998*/ void InitDocTypeAttr();
            /*0x7761d00*/ string GetDocumentTypeAttr(System.Xml.XmlDocumentType docType, string name);
            /*0x7761dac*/ string GetDocumentTypeAttr(int i);
            /*0x7761e00*/ int GetDocTypeAttrInd(string name);
            /*0x7761e98*/ string GetAttributeFromElement(System.Xml.XmlElement elem, string name);
            /*0x7761edc*/ string GetAttribute(string name);
            /*0x7762078*/ string GetAttributeFromElement(System.Xml.XmlElement elem, string name, string ns);
            /*0x77620c0*/ string GetAttribute(string name, string ns);
            /*0x7762290*/ string GetAttribute(int attributeIndex);
            /*0x7762434*/ void LogMove(int level);
            /*0x7762478*/ void RollBackMove(ref int level);
            /*0x77624c4*/ bool get_IsOnDeclOrDocType();
            /*0x77624fc*/ void ResetToAttribute(ref int level);
            /*0x77625b0*/ void ResetMove(ref int level, ref System.Xml.XmlNodeType nt);
            /*0x7762790*/ bool MoveToAttribute(string name);
            /*0x7762900*/ bool MoveToAttributeFromElement(System.Xml.XmlElement elem, string name, string ns);
            /*0x77627a8*/ bool MoveToAttribute(string name, string namespaceURI);
            /*0x77629d0*/ void MoveToAttribute(int attributeIndex);
            /*0x7762b88*/ bool MoveToNextAttribute(ref int level);
            /*0x7762d6c*/ bool MoveToParent();
            /*0x7762dc4*/ bool MoveToFirstChild();
            /*0x7762e24*/ bool MoveToNextSibling(System.Xml.XmlNode node);
            /*0x7762e88*/ bool MoveToNext();
            /*0x7762ec8*/ bool MoveToElement();
            /*0x7762f5c*/ string LookupNamespace(string prefix);
            /*0x77631f4*/ string DefaultLookupNamespace(string prefix);
            /*0x7763320*/ string LookupPrefix(string namespaceName);
            /*0x77636d8*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x7763b9c*/ bool ReadAttributeValue(ref int level, ref bool bResolveEntity, ref System.Xml.XmlNodeType nt);
            /*0x7763da4*/ System.Xml.XmlDocument get_Document();

            struct VirtualAttribute
            {
                /*0x10*/ string name;
                /*0x18*/ string value;

                /*0x7763db4*/ VirtualAttribute(string name, string value);
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

            /*0x7763de4*/ XmlNodeReader(System.Xml.XmlNode node);
            /*0x7763edc*/ bool IsInReadingStates();
            /*0x7763eec*/ System.Xml.XmlNodeType get_NodeType();
            /*0x7763f08*/ string get_Name();
            /*0x7763f4c*/ string get_LocalName();
            /*0x7763f90*/ string get_NamespaceURI();
            /*0x7763fd4*/ string get_Prefix();
            /*0x7764018*/ string get_Value();
            /*0x776405c*/ int get_Depth();
            /*0x7764064*/ string get_BaseURI();
            /*0x7764080*/ bool get_CanResolveEntity();
            /*0x7764088*/ bool get_IsEmptyElement();
            /*0x77640bc*/ bool get_IsDefault();
            /*0x77640f0*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x7764124*/ string get_XmlLang();
            /*0x7764168*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x776419c*/ int get_AttributeCount();
            /*0x77641dc*/ string GetAttribute(string name);
            /*0x7764210*/ string GetAttribute(string name, string namespaceURI);
            /*0x776425c*/ string GetAttribute(int attributeIndex);
            /*0x77642cc*/ bool MoveToAttribute(string name);
            /*0x77643a0*/ bool MoveToAttribute(string name, string namespaceURI);
            /*0x7764478*/ void MoveToAttribute(int attributeIndex);
            /*0x7764660*/ bool MoveToFirstAttribute();
            /*0x7764724*/ bool MoveToNextAttribute();
            /*0x77647e0*/ bool MoveToElement();
            /*0x7764898*/ bool Read();
            /*0x77648a0*/ bool Read(bool fSkipChildren);
            /*0x77649b0*/ bool ReadNextNode(bool fSkipChildren);
            /*0x7764ca4*/ void SetEndOfFile();
            /*0x7764cbc*/ bool ReadAtZeroLevel(bool fSkipChildren);
            /*0x7764bac*/ bool ReadForward(bool fSkipChildren);
            /*0x7764b84*/ void ReSetReadingMarks();
            /*0x7764d34*/ bool get_EOF();
            /*0x7764d58*/ void Close();
            /*0x7764d64*/ System.Xml.ReadState get_ReadState();
            /*0x7764d6c*/ void Skip();
            /*0x7764d74*/ string ReadString();
            /*0x7764e18*/ bool get_HasAttributes();
            /*0x7764e3c*/ System.Xml.XmlNameTable get_NameTable();
            /*0x7764e58*/ string LookupNamespace(string prefix);
            /*0x7764e94*/ void ResolveEntity();
            /*0x7764f18*/ bool ReadAttributeValue();
            /*0x7764f68*/ int ReadContentAsBase64(byte[] buffer, int index, int count);
            /*0x7765000*/ int ReadContentAsBinHex(byte[] buffer, int index, int count);
            /*0x776437c*/ void FinishReadBinary();
            /*0x7765098*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x77650b4*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            /*0x77650d0*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0x7765134*/ System.Xml.IDtdInfo get_DtdInfo();
        }

        class XmlNotation : System.Xml.XmlNode
        {
            /*0x18*/ string publicId;
            /*0x20*/ string systemId;
            /*0x28*/ string name;

            /*0x7765158*/ XmlNotation(string name, string publicId, string systemId, System.Xml.XmlDocument doc);
            /*0x77651e8*/ string get_Name();
            /*0x77651f0*/ string get_LocalName();
            /*0x77651f8*/ System.Xml.XmlNodeType get_NodeType();
            /*0x7765200*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x7765258*/ bool get_IsReadOnly();
            /*0x7765260*/ void set_InnerXml(string value);
            /*0x77652b8*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x77652bc*/ void WriteContentTo(System.Xml.XmlWriter w);
        }

        class XmlProcessingInstruction : System.Xml.XmlLinkedNode
        {
            /*0x20*/ string target;
            /*0x28*/ string data;

            /*0x77652c0*/ XmlProcessingInstruction(string target, string data, System.Xml.XmlDocument doc);
            /*0x7765308*/ string get_Name();
            /*0x776532c*/ string get_LocalName();
            /*0x7765338*/ string get_Value();
            /*0x7765340*/ void set_Value(string value);
            /*0x7765344*/ void set_Data(string value);
            /*0x7765408*/ string get_InnerText();
            /*0x7765410*/ void set_InnerText(string value);
            /*0x7765414*/ System.Xml.XmlNodeType get_NodeType();
            /*0x776541c*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x7765454*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x7765480*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x7765484*/ string get_XPLocalName();
            /*0x7765490*/ System.Xml.XPath.XPathNodeType get_XPNodeType();
        }

        class XmlSignificantWhitespace : System.Xml.XmlCharacterData
        {
            /*0x7765498*/ XmlSignificantWhitespace(string strData, System.Xml.XmlDocument doc);
            /*0x7765534*/ string get_Name();
            /*0x776555c*/ string get_LocalName();
            /*0x7765584*/ System.Xml.XmlNodeType get_NodeType();
            /*0x776558c*/ System.Xml.XmlNode get_ParentNode();
            /*0x7765618*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x7765674*/ string get_Value();
            /*0x7765684*/ void set_Value(string value);
            /*0x7765710*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x7765750*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x7765754*/ System.Xml.XPath.XPathNodeType get_XPNodeType();
            /*0x776577c*/ bool get_IsText();
            /*0x7765784*/ System.Xml.XmlNode get_PreviousText();
        }

        class XmlText : System.Xml.XmlCharacterData
        {
            /*0x77657c0*/ XmlText(string strData);
            /*0x77657cc*/ XmlText(string strData, System.Xml.XmlDocument doc);
            /*0x77657d4*/ string get_Name();
            /*0x77657fc*/ string get_LocalName();
            /*0x7765824*/ System.Xml.XmlNodeType get_NodeType();
            /*0x776582c*/ System.Xml.XmlNode get_ParentNode();
            /*0x77658b0*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x776590c*/ string get_Value();
            /*0x776591c*/ void set_Value(string value);
            /*0x77659e0*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x7765a20*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x7765a24*/ System.Xml.XPath.XPathNodeType get_XPNodeType();
            /*0x7765a2c*/ bool get_IsText();
            /*0x7765a34*/ System.Xml.XmlNode get_PreviousText();
        }

        class XmlUnspecifiedAttribute : System.Xml.XmlAttribute
        {
            /*0x28*/ bool fSpecified;

            /*0x7765a70*/ XmlUnspecifiedAttribute(string prefix, string localName, string namespaceURI, System.Xml.XmlDocument doc);
            /*0x7765a78*/ bool get_Specified();
            /*0x7765a80*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x7765bb0*/ void set_InnerText(string value);
            /*0x7765bd0*/ System.Xml.XmlNode InsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x7765bf0*/ System.Xml.XmlNode InsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x7765c10*/ System.Xml.XmlNode RemoveChild(System.Xml.XmlNode oldChild);
            /*0x7765c30*/ System.Xml.XmlNode AppendChild(System.Xml.XmlNode newChild);
            /*0x7765c50*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x7765c64*/ void SetSpecified(bool f);
        }

        class XmlWhitespace : System.Xml.XmlCharacterData
        {
            /*0x7765c70*/ XmlWhitespace(string strData, System.Xml.XmlDocument doc);
            /*0x7765d0c*/ string get_Name();
            /*0x7765d34*/ string get_LocalName();
            /*0x7765d5c*/ System.Xml.XmlNodeType get_NodeType();
            /*0x7765d64*/ System.Xml.XmlNode get_ParentNode();
            /*0x7765df0*/ string get_Value();
            /*0x7765e00*/ void set_Value(string value);
            /*0x7765e8c*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x7765ee8*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x7765f28*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x7765f2c*/ System.Xml.XPath.XPathNodeType get_XPNodeType();
            /*0x7765f54*/ bool get_IsText();
            /*0x7765f5c*/ System.Xml.XmlNode get_PreviousText();
        }

        class EmptyEnumerator : System.Collections.IEnumerator
        {
            /*0x7765ffc*/ EmptyEnumerator();
            /*0x7765f98*/ bool System.Collections.IEnumerator.MoveNext();
            /*0x7765fa0*/ void System.Collections.IEnumerator.Reset();
            /*0x7765fa4*/ object System.Collections.IEnumerator.get_Current();
        }

        class HWStack : System.ICloneable
        {
            /*0x10*/ object[] stack;
            /*0x18*/ int growthRate;
            /*0x1c*/ int used;
            /*0x20*/ int size;
            /*0x24*/ int limit;

            /*0x7766004*/ HWStack(int GrowthRate);
            /*0x776600c*/ HWStack(int GrowthRate, int limit);
            /*0x77663fc*/ HWStack(object[] stack, int growthRate, int used, int size);
            /*0x776608c*/ object Push();
            /*0x77661cc*/ object Pop();
            /*0x7766214*/ object Peek();
            /*0x7766258*/ void AddToTop(object o);
            /*0x77662d4*/ object get_Item(int index);
            /*0x7766348*/ void set_Item(int index, object value);
            /*0x77663f4*/ int get_Length();
            /*0x776644c*/ object Clone();
        }

        interface IXmlLineInfo
        {
            /*0x380b128*/ bool HasLineInfo();
            /*0x380b6a0*/ int get_LineNumber();
            /*0x380b6a0*/ int get_LinePosition();
        }

        class PositionInfo : System.Xml.IXmlLineInfo
        {
            static /*0x776654c*/ System.Xml.PositionInfo GetPositionInfo(object o);
            /*0x7766638*/ PositionInfo();
            /*0x7766534*/ bool HasLineInfo();
            /*0x776653c*/ int get_LineNumber();
            /*0x7766544*/ int get_LinePosition();
        }

        class ReaderPositionInfo : System.Xml.PositionInfo
        {
            /*0x10*/ System.Xml.IXmlLineInfo lineInfo;

            /*0x7766608*/ ReaderPositionInfo(System.Xml.IXmlLineInfo lineInfo);
            /*0x7766640*/ bool HasLineInfo();
            /*0x77666e0*/ int get_LineNumber();
            /*0x7766784*/ int get_LinePosition();
        }

        interface IXmlNamespaceResolver
        {
            /*0x380ba90*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x380bb68*/ string LookupNamespace(string prefix);
            /*0x380bb68*/ string LookupPrefix(string namespaceName);
        }

        struct LineInfo
        {
            /*0x10*/ int lineNo;
            /*0x14*/ int linePos;

            /*0x7766828*/ LineInfo(int lineNo, int linePos);
            /*0x7766830*/ void Set(int lineNo, int linePos);
        }

        class NameTable : System.Xml.XmlNameTable
        {
            /*0x10*/ System.Xml.NameTable.Entry[] entries;
            /*0x18*/ int count;
            /*0x1c*/ int mask;
            /*0x20*/ int hashCodeRandomizer;

            static /*0x7766c7c*/ bool TextEquals(string str1, char[] str2, int str2Start, int str2Length);
            /*0x7766838*/ NameTable();
            /*0x77668b4*/ string Add(string key);
            /*0x7766b1c*/ string Add(char[] key, int start, int len);
            /*0x7766d38*/ string Get(string value);
            /*0x7766e7c*/ string Get(char[] key, int start, int len);
            /*0x7766a0c*/ string AddEntry(string str, int hashCode);
            /*0x7766ff4*/ void Grow();

            class Entry
            {
                /*0x10*/ string str;
                /*0x18*/ int hashCode;
                /*0x20*/ System.Xml.NameTable.Entry next;

                /*0x7766fa0*/ Entry(string str, int hashCode, System.Xml.NameTable.Entry next);
            }
        }

        class Ref
        {
            static /*0x7767148*/ bool Equal(string strA, string strB);
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

            static /*0x7767284*/ System.Xml.IDtdParser Create();
            static /*0x7771250*/ string StripSpaces(string value);
            /*0x7767154*/ DtdParser();
            /*0x77672d4*/ void Initialize(System.Xml.IDtdParserAdapter readerAdapter);
            /*0x77676f4*/ void InitializeFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, System.Xml.IDtdParserAdapter adapter);
            /*0x7767c98*/ System.Xml.IDtdInfo System.Xml.IDtdParser.ParseInternalDtd(System.Xml.IDtdParserAdapter adapter, bool saveInternalSubset);
            /*0x7767f04*/ System.Xml.IDtdInfo System.Xml.IDtdParser.ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, System.Xml.IDtdParserAdapter adapter);
            /*0x7767f28*/ bool get_ParsingInternalSubset();
            /*0x7767f38*/ bool get_IgnoreEntityReferences();
            /*0x7767f48*/ bool get_SaveInternalSubsetValue();
            /*0x7768008*/ bool get_ParsingTopLevelMarkup();
            /*0x7768038*/ bool get_SupportNamespaces();
            /*0x7768040*/ bool get_Normalize();
            /*0x7767cc8*/ void Parse(bool saveInternalSubset);
            /*0x776809c*/ void ParseInDocumentDtd(bool saveInternalSubset);
            /*0x7768048*/ void ParseFreeFloatingDtd();
            /*0x7769594*/ void ParseInternalSubset();
            /*0x7769598*/ void ParseExternalSubset();
            /*0x7769748*/ void ParseSubset();
            /*0x7769ae8*/ void ParseAttlistDecl();
            /*0x776b530*/ void ParseAttlistType(System.Xml.Schema.SchemaAttDef attrDef, System.Xml.Schema.SchemaElementDecl elementDecl, bool ignoreErrors);
            /*0x776bab4*/ void ParseAttlistDefault(System.Xml.Schema.SchemaAttDef attrDef, bool ignoreErrors);
            /*0x776a098*/ void ParseElementDecl();
            /*0x776c230*/ void ParseElementOnlyContent(System.Xml.Schema.ParticleContentValidator pcv, int startParenEntityId);
            /*0x776c5cc*/ void ParseHowMany(System.Xml.Schema.ParticleContentValidator pcv);
            /*0x776bfa8*/ void ParseElementMixedContent(System.Xml.Schema.ParticleContentValidator pcv, int startParenEntityId);
            /*0x776a440*/ void ParseEntityDecl();
            /*0x776a7c8*/ void ParseNotationDecl();
            /*0x776bd50*/ void AddUndeclaredNotation(string notationName);
            /*0x776a9cc*/ void ParseComment();
            /*0x776ac18*/ void ParsePI();
            /*0x776ad94*/ void ParseCondSection();
            /*0x776906c*/ void ParseExternalId(System.Xml.DtdParser.Token idTokenType, System.Xml.DtdParser.Token declType, ref string publicId, ref string systemId);
            /*0x77685e8*/ System.Xml.DtdParser.Token GetToken(bool needWhiteSpace);
            /*0x776cdec*/ System.Xml.DtdParser.Token ScanSubsetContent();
            /*0x776cd84*/ System.Xml.DtdParser.Token ScanNameExpected();
            /*0x776cda8*/ System.Xml.DtdParser.Token ScanQNameExpected();
            /*0x776cdcc*/ System.Xml.DtdParser.Token ScanNmtokenExpected();
            /*0x776d560*/ System.Xml.DtdParser.Token ScanDoctype1();
            /*0x776d6c8*/ System.Xml.DtdParser.Token ScanDoctype2();
            /*0x776fb0c*/ System.Xml.DtdParser.Token ScanClosingTag();
            /*0x776d784*/ System.Xml.DtdParser.Token ScanElement1();
            /*0x776d97c*/ System.Xml.DtdParser.Token ScanElement2();
            /*0x776db40*/ System.Xml.DtdParser.Token ScanElement3();
            /*0x776dbc0*/ System.Xml.DtdParser.Token ScanElement4();
            /*0x776dca0*/ System.Xml.DtdParser.Token ScanElement5();
            /*0x776dda0*/ System.Xml.DtdParser.Token ScanElement6();
            /*0x776de70*/ System.Xml.DtdParser.Token ScanElement7();
            /*0x776ded0*/ System.Xml.DtdParser.Token ScanAttlist1();
            /*0x776df94*/ System.Xml.DtdParser.Token ScanAttlist2();
            /*0x776e688*/ System.Xml.DtdParser.Token ScanAttlist3();
            /*0x776e728*/ System.Xml.DtdParser.Token ScanAttlist4();
            /*0x776e7f8*/ System.Xml.DtdParser.Token ScanAttlist5();
            /*0x776e8c8*/ System.Xml.DtdParser.Token ScanAttlist6();
            /*0x776ec88*/ System.Xml.DtdParser.Token ScanAttlist7();
            /*0x7770144*/ System.Xml.DtdParser.Token ScanLiteral(System.Xml.DtdParser.LiteralType literalType);
            /*0x7770bc0*/ System.Xml.XmlQualifiedName ScanEntityName();
            /*0x776ed44*/ System.Xml.DtdParser.Token ScanNotation1();
            /*0x776ee80*/ System.Xml.DtdParser.Token ScanSystemId();
            /*0x776f050*/ System.Xml.DtdParser.Token ScanEntity1();
            /*0x776f0c4*/ System.Xml.DtdParser.Token ScanEntity2();
            /*0x776f234*/ System.Xml.DtdParser.Token ScanEntity3();
            /*0x776ef34*/ System.Xml.DtdParser.Token ScanPublicId1();
            /*0x776efe8*/ System.Xml.DtdParser.Token ScanPublicId2();
            /*0x776f348*/ System.Xml.DtdParser.Token ScanCondSection1();
            /*0x776f628*/ System.Xml.DtdParser.Token ScanCondSection2();
            /*0x776f6c0*/ System.Xml.DtdParser.Token ScanCondSection3();
            /*0x776fe0c*/ void ScanName();
            /*0x776fe14*/ void ScanQName();
            /*0x7770f8c*/ void ScanQName(bool isQName);
            /*0x777120c*/ bool ReadDataInName();
            /*0x776fe1c*/ void ScanNmtoken();
            /*0x776ff7c*/ bool EatPublicKeyword();
            /*0x7770060*/ bool EatSystemKeyword();
            /*0x7768ef8*/ System.Xml.XmlQualifiedName GetNameQualified(bool canHavePrefix);
            /*0x776bd34*/ string GetNameString();
            /*0x776bed0*/ string GetNmtokenString();
            /*0x776bf4c*/ string GetValue();
            /*0x776beec*/ string GetValueWithStrippedSpaces();
            /*0x776fba0*/ int ReadData();
            /*0x776845c*/ void LoadParsingBuffer();
            /*0x776958c*/ void SaveParsingBuffer();
            /*0x776b0bc*/ void SaveParsingBuffer(int internalSubsetValueEndPos);
            /*0x776cc80*/ bool HandleEntityReference(bool paramEntity, bool inLiteral, bool inAttribute);
            /*0x7771468*/ bool HandleEntityReference(System.Xml.XmlQualifiedName entityName, bool paramEntity, bool inLiteral, bool inAttribute);
            /*0x776fc64*/ bool HandleEntityEnd(bool inLiteral);
            /*0x7770d20*/ System.Xml.Schema.SchemaEntity VerifyEntityReference(System.Xml.XmlQualifiedName entityName, bool paramEntity, bool mustBeDeclared, bool inAttribute);
            /*0x776afe8*/ void SendValidationEvent(int pos, System.Xml.Schema.XmlSeverityType severity, string code, string arg);
            /*0x776bc74*/ void SendValidationEvent(System.Xml.Schema.XmlSeverityType severity, string code, string arg);
            /*0x7768318*/ void SendValidationEvent(System.Xml.Schema.XmlSeverityType severity, System.Xml.Schema.XmlSchemaException e);
            /*0x776bc68*/ bool IsAttributeValueType(System.Xml.DtdParser.Token token);
            /*0x776b210*/ int get_LineNo();
            /*0x776b2b4*/ int get_LinePos();
            /*0x7768200*/ string get_BaseUriStr();
            /*0x7768e98*/ void OnUnexpectedError();
            /*0x776ad7c*/ void Throw(int curPos, string res);
            /*0x776c63c*/ void Throw(int curPos, string res, string arg);
            /*0x776c9e8*/ void Throw(int curPos, string res, string[] args);
            /*0x776b364*/ void Throw(string res, string arg, int lineNo, int linePos);
            /*0x7767bbc*/ void ThrowInvalidChar(int pos, string data, int invCharPos);
            /*0x776cbcc*/ void ThrowInvalidChar(char[] data, int length, int invCharPos);
            /*0x776b208*/ void ThrowUnexpectedToken(int pos, string expectedToken);
            /*0x776c874*/ void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2);
            /*0x776ccd0*/ string ParseUnexpectedToken(int startPos);

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

                /*0x776c820*/ UndeclaredNotation(string name, int lineNo, int linePos);
            }

            class ParseElementOnlyContent_LocalFrame
            {
                /*0x10*/ int startParenEntityId;
                /*0x14*/ System.Xml.DtdParser.Token parsingSchema;

                /*0x776c5a0*/ ParseElementOnlyContent_LocalFrame(int startParentEntityIdParam);
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

            static /*0x7772320*/ ValidateNames();
            static /*0x7771750*/ int ParseNmtoken(string s, int offset);
            static /*0x7771818*/ int ParseNmtokenNoNamespaces(string s, int offset);
            static /*0x77718fc*/ int ParseNameNoNamespaces(string s, int offset);
            static /*0x7771a54*/ bool IsNameNoNamespaces(string s);
            static /*0x7771ad4*/ int ParseNCName(string s, int offset);
            static /*0x7771bf0*/ int ParseNCName(string s);
            static /*0x7771c48*/ int ParseQName(string s, int offset, ref int colonOffset);
            static /*0x7771d24*/ void ParseQNameThrow(string s, ref string prefix, ref string localName);
            static /*0x7771e5c*/ void ThrowInvalidName(string s, int offsetStartChar, int offsetBadChar);
            static /*0x777200c*/ System.Exception GetInvalidNameException(string s, int offsetStartChar, int offsetBadChar);
            static /*0x77721d0*/ void SplitQName(string name, ref string prefix, ref string lname);
        }

        struct XmlCharType
        {
            static /*0x0*/ object s_Lock;
            static /*0x8*/ byte[] s_CharProperties;
            /*0x10*/ byte[] charProperties;

            static /*0x7772378*/ object get_StaticLock();
            static /*0x777240c*/ void InitInstance();
            static /*0x7772670*/ void SetProperties(byte[] chProps, string ranges, byte value);
            static /*0x776720c*/ System.Xml.XmlCharType get_Instance();
            static /*0x77728d0*/ bool IsDigit(char ch);
            static /*0x7770f48*/ bool IsHighSurrogate(int ch);
            static /*0x7770f58*/ bool IsLowSurrogate(int ch);
            static /*0x77728f8*/ bool IsSurrogate(int ch);
            static /*0x7772908*/ int CombineSurrogateChar(int lowChar, int highChar);
            static /*0x7772920*/ void SplitSurrogateChar(int combinedChar, ref char lowChar, ref char highChar);
            static /*0x77729f4*/ bool IsOnlyDigits(string str, int startPos, int len);
            static /*0x77728e4*/ bool InRange(int value, int start, int end);
            /*0x7772734*/ XmlCharType(byte[] charProperties);
            /*0x776cc4c*/ bool IsWhiteSpace(char ch);
            /*0x777171c*/ bool IsNCNameSingleChar(char ch);
            /*0x7771fd8*/ bool IsStartNCNameSingleChar(char ch);
            /*0x7770f68*/ bool IsNameSingleChar(char ch);
            /*0x777273c*/ bool IsCharData(char ch);
            /*0x7772770*/ bool IsPubidChar(char ch);
            /*0x77727ec*/ bool IsTextChar(char ch);
            /*0x7772820*/ bool IsLetter(char ch);
            /*0x7772854*/ bool IsNCNameCharXml4e(char ch);
            /*0x7772888*/ bool IsStartNCNameCharXml4e(char ch);
            /*0x77728ac*/ bool IsNameCharXml4e(char ch);
            /*0x7772954*/ bool IsOnlyWhitespace(string str);
            /*0x777296c*/ int IsOnlyWhitespaceWithPos(string str);
            /*0x7767ae4*/ int IsOnlyCharData(string str);
            /*0x7767c38*/ int IsPublicId(string str);
        }

        class XmlComplianceUtil
        {
            static /*0x7772a9c*/ string NonCDataNormalize(string value);
            static /*0x7772d18*/ string CDataNormalize(string value);
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

            static /*0x7779ef0*/ XmlConvert();
            static /*0x7772eec*/ string EncodeName(string name);
            static /*0x7773928*/ string EncodeLocalName(string name);
            static /*0x7773984*/ string DecodeName(string name);
            static /*0x7772f48*/ string EncodeName(string name, bool first, bool local);
            static /*0x7774290*/ int FromHex(char digit);
            static /*0x77742c0*/ byte[] FromBinHexString(string s);
            static /*0x7774318*/ byte[] FromBinHexString(string s, bool allowOddCount);
            static /*0x7774384*/ string ToBinHexString(byte[] inArray);
            static /*0x77743e8*/ string VerifyName(string name);
            static /*0x7774600*/ System.Exception TryVerifyName(string name);
            static /*0x7774860*/ string VerifyQName(string name, System.Xml.ExceptionType exceptionType);
            static /*0x7774a68*/ string VerifyNCName(string name);
            static /*0x7774ac0*/ string VerifyNCName(string name, System.Xml.ExceptionType exceptionType);
            static /*0x7774c14*/ System.Exception TryVerifyNCName(string name);
            static /*0x7774cbc*/ string VerifyTOKEN(string token);
            static /*0x7774df0*/ System.Exception TryVerifyTOKEN(string token);
            static /*0x7774f24*/ System.Exception TryVerifyNMTOKEN(string name);
            static /*0x777504c*/ System.Exception TryVerifyNormalizedString(string str);
            static /*0x7775114*/ string ToString(bool value);
            static /*0x777517c*/ string ToString(char value);
            static /*0x77751b8*/ string ToString(decimal value);
            static /*0x7775254*/ string ToString(sbyte value);
            static /*0x7775280*/ string ToString(short value);
            static /*0x77752ac*/ string ToString(int value);
            static /*0x77752d8*/ string ToString(long value);
            static /*0x7775304*/ string ToString(byte value);
            static /*0x7775330*/ string ToString(ushort value);
            static /*0x777535c*/ string ToString(uint value);
            static /*0x7775388*/ string ToString(ulong value);
            static /*0x77753b4*/ string ToString(float value);
            static /*0x7775524*/ string ToString(double value);
            static /*0x7775620*/ string ToString(System.TimeSpan value);
            static /*0x7775678*/ string ToString(System.DateTime value, string format);
            static /*0x777571c*/ string ToString(System.DateTime value, System.Xml.XmlDateTimeSerializationMode dateTimeOption);
            static /*0x7775b04*/ string ToString(System.DateTimeOffset value);
            static /*0x7775b8c*/ string ToString(System.Guid value);
            static /*0x7775bb0*/ bool ToBoolean(string s);
            static /*0x7775de4*/ System.Exception TryToBoolean(string s, ref bool result);
            static /*0x7776020*/ char ToChar(string s);
            static /*0x77760dc*/ System.Exception TryToChar(string s, ref char result);
            static /*0x7776254*/ decimal ToDecimal(string s);
            static /*0x77762c4*/ System.Exception TryToDecimal(string s, ref decimal result);
            static /*0x7776468*/ decimal ToInteger(string s);
            static /*0x77764d8*/ System.Exception TryToInteger(string s, ref decimal result);
            static /*0x777667c*/ sbyte ToSByte(string s);
            static /*0x77766a4*/ System.Exception TryToSByte(string s, ref sbyte result);
            static /*0x7776814*/ short ToInt16(string s);
            static /*0x777683c*/ System.Exception TryToInt16(string s, ref short result);
            static /*0x77769ac*/ int ToInt32(string s);
            static /*0x77769d4*/ System.Exception TryToInt32(string s, ref int result);
            static /*0x7776b44*/ long ToInt64(string s);
            static /*0x7776b6c*/ System.Exception TryToInt64(string s, ref long result);
            static /*0x7776cdc*/ byte ToByte(string s);
            static /*0x7776d04*/ System.Exception TryToByte(string s, ref byte result);
            static /*0x7776e74*/ ushort ToUInt16(string s);
            static /*0x7776e9c*/ System.Exception TryToUInt16(string s, ref ushort result);
            static /*0x777700c*/ uint ToUInt32(string s);
            static /*0x7777034*/ System.Exception TryToUInt32(string s, ref uint result);
            static /*0x77771a4*/ ulong ToUInt64(string s);
            static /*0x77771cc*/ System.Exception TryToUInt64(string s, ref ulong result);
            static /*0x777733c*/ float ToSingle(string s);
            static /*0x7777454*/ System.Exception TryToSingle(string s, ref float result);
            static /*0x77776a4*/ double ToDouble(string s);
            static /*0x77777bc*/ System.Exception TryToDouble(string s, ref double result);
            static /*0x7777a0c*/ double ToXPathDouble(object o);
            static /*0x7777c2c*/ System.TimeSpan ToTimeSpan(string s);
            static /*0x7777dc0*/ System.Exception TryToTimeSpan(string s, ref System.TimeSpan result);
            static /*0x7777e6c*/ string[] get_AllDateTimeFormats();
            static /*0x7777f04*/ void CreateAllDateTimeFormats();
            static /*0x777849c*/ System.DateTime ToDateTime(string s);
            static /*0x77784f8*/ System.DateTime ToDateTime(string s, string[] formats);
            static /*0x777859c*/ System.DateTime ToDateTime(string s, System.Xml.XmlDateTimeSerializationMode dateTimeOption);
            static /*0x77787e0*/ System.DateTimeOffset ToDateTimeOffset(string s);
            static /*0x77788a8*/ System.Guid ToGuid(string s);
            static /*0x77788d4*/ System.Exception TryToGuid(string s, ref System.Guid result);
            static /*0x777594c*/ System.DateTime SwitchToLocalTime(System.DateTime value);
            static /*0x7775a20*/ System.DateTime SwitchToUtcTime(System.DateTime value);
            static /*0x7778acc*/ System.Uri ToUri(string s);
            static /*0x7778c80*/ System.Exception TryToUri(string s, ref System.Uri result);
            static /*0x7778eb4*/ bool StrEqual(char[] chars, int strPos1, int strLen1, string str2);
            static /*0x7775d78*/ string TrimString(string value);
            static /*0x7778f80*/ string TrimStringStart(string value);
            static /*0x7778fec*/ string TrimStringEnd(string value);
            static /*0x7779058*/ string[] SplitString(string value);
            static /*0x77754b0*/ bool IsNegativeZero(double value);
            static /*0x77790c8*/ long DoubleToInt64Bits(double value);
            static /*0x77790d0*/ void VerifyCharData(string data, System.Xml.ExceptionType invCharExceptionType, System.Xml.ExceptionType invSurrogateExceptionType);
            static /*0x77792c8*/ System.Exception CreateException(string res, System.Xml.ExceptionType exceptionType, int lineNo, int linePos);
            static /*0x7779668*/ System.Exception CreateException(string res, string arg, System.Xml.ExceptionType exceptionType, int lineNo, int linePos);
            static /*0x77797a4*/ System.Exception CreateException(string res, string[] args, System.Xml.ExceptionType exceptionType);
            static /*0x7774990*/ System.Exception CreateException(string res, string[] args, System.Xml.ExceptionType exceptionType, int lineNo, int linePos);
            static /*0x777982c*/ System.Exception CreateInvalidSurrogatePairException(char low, char hi);
            static /*0x7779894*/ System.Exception CreateInvalidSurrogatePairException(char low, char hi, System.Xml.ExceptionType exceptionType);
            static /*0x7779388*/ System.Exception CreateInvalidSurrogatePairException(char low, char hi, System.Xml.ExceptionType exceptionType, int lineNo, int linePos);
            static /*0x7779908*/ System.Exception CreateInvalidHighSurrogateCharException(char hi);
            static /*0x7779960*/ System.Exception CreateInvalidHighSurrogateCharException(char hi, System.Xml.ExceptionType exceptionType);
            static /*0x77799cc*/ System.Exception CreateInvalidHighSurrogateCharException(char hi, System.Xml.ExceptionType exceptionType, int lineNo, int linePos);
            static /*0x777951c*/ System.Exception CreateInvalidCharException(string data, int invCharPos, System.Xml.ExceptionType exceptionType);
            static /*0x7779ac8*/ System.Exception CreateInvalidCharException(char invChar, char nextChar);
            static /*0x7779b30*/ System.Exception CreateInvalidCharException(char invChar, char nextChar, System.Xml.ExceptionType exceptionType);
            static /*0x777453c*/ System.Exception CreateInvalidNameCharException(string name, int index, System.Xml.ExceptionType exceptionType);
            static /*0x7779e3c*/ System.ArgumentException CreateInvalidNameArgumentException(string name, string argumentName);
        }

        class XmlDownloadManager
        {
            /*0x10*/ System.Collections.Hashtable connections;

            /*0x777ac04*/ XmlDownloadManager();
            /*0x777a000*/ System.IO.Stream GetStream(System.Uri uri, System.Net.ICredentials credentials, System.Net.IWebProxy proxy, System.Net.Cache.RequestCachePolicy cachePolicy);
            /*0x777a100*/ System.IO.Stream GetNonFileStream(System.Uri uri, System.Net.ICredentials credentials, System.Net.IWebProxy proxy, System.Net.Cache.RequestCachePolicy cachePolicy);
            /*0x777a7a0*/ void Remove(string host);
            /*0x777a90c*/ System.Threading.Tasks.Task<System.IO.Stream> GetStreamAsync(System.Uri uri, System.Net.ICredentials credentials, System.Net.IWebProxy proxy, System.Net.Cache.RequestCachePolicy cachePolicy);
            /*0x777aa84*/ System.Threading.Tasks.Task<System.IO.Stream> GetNonFileStreamAsync(System.Uri uri, System.Net.ICredentials credentials, System.Net.IWebProxy proxy, System.Net.Cache.RequestCachePolicy cachePolicy);

            class <>c__DisplayClass4_0
            {
                /*0x10*/ System.Uri uri;

                /*0x777aa7c*/ <>c__DisplayClass4_0();
                /*0x777ac0c*/ System.IO.Stream <GetStreamAsync>b__0();
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

                /*0x777ac98*/ void MoveNext();
                /*0x777b478*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class OpenedHost
        {
            /*0x10*/ int nonCachedConnectionsCount;

            /*0x777a57c*/ OpenedHost();
        }

        class XmlRegisteredNonCachedStream : System.IO.Stream
        {
            /*0x28*/ System.IO.Stream stream;
            /*0x30*/ System.Xml.XmlDownloadManager downloadManager;
            /*0x38*/ string host;

            /*0x777a584*/ XmlRegisteredNonCachedStream(System.IO.Stream stream, System.Xml.XmlDownloadManager downloadManager, string host);
            /*0x777b4f4*/ void Finalize();
            /*0x777b5a8*/ void Dispose(bool disposing);
            /*0x777b6ec*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state);
            /*0x777b710*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state);
            /*0x777b734*/ int EndRead(System.IAsyncResult asyncResult);
            /*0x777b758*/ void EndWrite(System.IAsyncResult asyncResult);
            /*0x777b77c*/ void Flush();
            /*0x777b7a0*/ int Read(byte[] buffer, int offset, int count);
            /*0x777b7c4*/ int ReadByte();
            /*0x777b7e8*/ long Seek(long offset, System.IO.SeekOrigin origin);
            /*0x777b80c*/ void SetLength(long value);
            /*0x777b830*/ void Write(byte[] buffer, int offset, int count);
            /*0x777b854*/ void WriteByte(byte value);
            /*0x777b878*/ bool get_CanRead();
            /*0x777b898*/ bool get_CanSeek();
            /*0x777b8b8*/ bool get_CanWrite();
            /*0x777b8d8*/ long get_Length();
            /*0x777b8f8*/ long get_Position();
            /*0x777b91c*/ void set_Position(long value);
        }

        class XmlCachedStream : System.IO.MemoryStream
        {
            /*0x50*/ System.Uri uri;

            /*0x777a628*/ XmlCachedStream(System.Uri uri, System.IO.Stream stream);
        }

        class UTF16Decoder : System.Text.Decoder
        {
            /*0x20*/ bool bigEndian;
            /*0x24*/ int lastByte;

            /*0x777b940*/ UTF16Decoder(bool bigEndian);
            /*0x777b970*/ int GetCharCount(byte[] bytes, int index, int count);
            /*0x777b980*/ int GetCharCount(byte[] bytes, int index, int count, bool flush);
            /*0x777ba64*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0x777bbd8*/ void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, ref int bytesUsed, ref int charsUsed, ref bool completed);
        }

        class SafeAsciiDecoder : System.Text.Decoder
        {
            /*0x777bda4*/ SafeAsciiDecoder();
            /*0x777bdac*/ int GetCharCount(byte[] bytes, int index, int count);
            /*0x777bdb4*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0x777be20*/ void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, ref int bytesUsed, ref int charsUsed, ref bool completed);
        }

        class Ucs4Encoding : System.Text.Encoding
        {
            /*0x38*/ System.Xml.Ucs4Decoder ucs4Decoder;

            static /*0x777bf9c*/ System.Text.Encoding get_UCS4_Littleendian();
            static /*0x777c054*/ System.Text.Encoding get_UCS4_Bigendian();
            static /*0x777c10c*/ System.Text.Encoding get_UCS4_2143();
            static /*0x777c1c4*/ System.Text.Encoding get_UCS4_3412();
            /*0x777c27c*/ Ucs4Encoding();
            /*0x777bea8*/ string get_WebName();
            /*0x777beb4*/ System.Text.Decoder GetDecoder();
            /*0x777bebc*/ int GetByteCount(char[] chars, int index, int count);
            /*0x777bf1c*/ byte[] GetBytes(string s);
            /*0x777bf24*/ int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);
            /*0x777bf2c*/ int GetMaxByteCount(int charCount);
            /*0x777bf34*/ int GetCharCount(byte[] bytes, int index, int count);
            /*0x777bf54*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0x777bf74*/ int GetMaxCharCount(int byteCount);
            /*0x777bf8c*/ int get_CodePage();
            /*0x777bf94*/ System.Text.Encoder GetEncoder();
        }

        class Ucs4Encoding1234 : System.Xml.Ucs4Encoding
        {
            /*0x777c0a4*/ Ucs4Encoding1234();
            /*0x777c288*/ string get_EncodingName();
            /*0x777c2c8*/ byte[] GetPreamble();
        }

        class Ucs4Encoding4321 : System.Xml.Ucs4Encoding
        {
            /*0x777bfec*/ Ucs4Encoding4321();
            /*0x777c344*/ string get_EncodingName();
            /*0x777c384*/ byte[] GetPreamble();
        }

        class Ucs4Encoding2143 : System.Xml.Ucs4Encoding
        {
            /*0x777c15c*/ Ucs4Encoding2143();
            /*0x777c3fc*/ string get_EncodingName();
            /*0x777c43c*/ byte[] GetPreamble();
        }

        class Ucs4Encoding3412 : System.Xml.Ucs4Encoding
        {
            /*0x777c214*/ Ucs4Encoding3412();
            /*0x777c4b8*/ string get_EncodingName();
            /*0x777c4f8*/ byte[] GetPreamble();
        }

        class Ucs4Decoder : System.Text.Decoder
        {
            /*0x20*/ byte[] lastBytes;
            /*0x28*/ int lastBytesCount;

            /*0x777c99c*/ Ucs4Decoder();
            /*0x777c56c*/ int GetCharCount(byte[] bytes, int index, int count);
            int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0x777c588*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0x777c730*/ void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, ref int bytesUsed, ref int charsUsed, ref bool completed);
            /*0x777c944*/ void Ucs4ToUTF16(uint code, char[] chars, int charIndex);
        }

        class Ucs4Decoder4321 : System.Xml.Ucs4Decoder
        {
            /*0x777c340*/ Ucs4Decoder4321();
            /*0x777ca00*/ int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
        }

        class Ucs4Decoder1234 : System.Xml.Ucs4Decoder
        {
            /*0x777c284*/ Ucs4Decoder1234();
            /*0x777cc18*/ int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
        }

        class Ucs4Decoder2143 : System.Xml.Ucs4Decoder
        {
            /*0x777c3f8*/ Ucs4Decoder2143();
            /*0x777ce30*/ int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
        }

        class Ucs4Decoder3412 : System.Xml.Ucs4Decoder
        {
            /*0x777c4b4*/ Ucs4Decoder3412();
            /*0x777d048*/ int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
        }

        class XmlException : System.SystemException
        {
            /*0x90*/ string res;
            /*0x98*/ string[] args;
            /*0xa0*/ int lineNumber;
            /*0xa4*/ int linePosition;
            /*0xa8*/ string sourceUri;
            /*0xb0*/ string message;

            static /*0x777db9c*/ string FormatUserMessage(string message, int lineNumber, int linePosition);
            static /*0x777d650*/ string CreateMessage(string res, string[] args, int lineNumber, int linePosition);
            static /*0x77747f0*/ string[] BuildCharExceptionArgs(string data, int invCharIndex);
            static /*0x777e2bc*/ string[] BuildCharExceptionArgs(char[] data, int length, int invCharIndex);
            static /*0x7779bc4*/ string[] BuildCharExceptionArgs(char invChar, char nextChar);
            /*0x777d260*/ XmlException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x777da1c*/ XmlException();
            /*0x777da34*/ XmlException(string message);
            /*0x777da50*/ XmlException(string message, System.Exception innerException);
            /*0x777da48*/ XmlException(string message, System.Exception innerException, int lineNumber, int linePosition);
            /*0x777da60*/ XmlException(string message, System.Exception innerException, int lineNumber, int linePosition, string sourceUri);
            /*0x777484c*/ XmlException(string res, string[] args);
            /*0x7774750*/ XmlException(string res, string arg);
            /*0x777dd28*/ XmlException(string res, string arg, string sourceUri);
            /*0x777ddd4*/ XmlException(string res, string arg, System.Xml.IXmlLineInfo lineInfo);
            /*0x777dffc*/ XmlException(string res, string arg, System.Exception innerException, System.Xml.IXmlLineInfo lineInfo);
            /*0x777e1dc*/ XmlException(string res, string[] args, System.Xml.IXmlLineInfo lineInfo);
            /*0x777de78*/ XmlException(string res, string[] args, System.Xml.IXmlLineInfo lineInfo, string sourceUri);
            /*0x77795b8*/ XmlException(string res, string arg, int lineNumber, int linePosition);
            /*0x777e1e4*/ XmlException(string res, string arg, int lineNumber, int linePosition, string sourceUri);
            /*0x7779818*/ XmlException(string res, string[] args, int lineNumber, int linePosition);
            /*0x777e2a0*/ XmlException(string res, string[] args, int lineNumber, int linePosition, string sourceUri);
            /*0x777e2b4*/ XmlException(string res, string[] args, System.Exception innerException, int lineNumber, int linePosition);
            /*0x777dc80*/ XmlException(string res, string[] args, System.Exception innerException, int lineNumber, int linePosition, string sourceUri);
            /*0x777d8ac*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x777e310*/ int get_LineNumber();
            /*0x777e318*/ int get_LinePosition();
            /*0x777e320*/ string get_Message();
            /*0x777e338*/ string get_ResString();
        }

        class XmlNameTable
        {
            /*0x777e340*/ XmlNameTable();
            string Get(char[] array, int offset, int length);
            /*0x380bb68*/ string Get(string array);
            string Add(char[] array, int offset, int length);
            /*0x380bb68*/ string Add(string array);
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

            /*0x777e348*/ XmlNamespaceManager();
            /*0x777e350*/ XmlNamespaceManager(System.Xml.XmlNameTable nameTable);
            /*0x777e5f4*/ System.Xml.XmlNameTable get_NameTable();
            /*0x777e5fc*/ string get_DefaultNamespace();
            /*0x777e63c*/ void PushScope();
            /*0x777e64c*/ bool PopScope();
            /*0x777e720*/ void AddNamespace(string prefix, string uri);
            /*0x777ec98*/ void RemoveNamespace(string prefix, string uri);
            /*0x777edd4*/ System.Collections.IEnumerator GetEnumerator();
            /*0x777ef48*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x777f100*/ string LookupNamespace(string prefix);
            /*0x777eb08*/ int LookupNamespaceDecl(string prefix);
            /*0x777f14c*/ string LookupPrefix(string uri);

            struct NamespaceDeclaration
            {
                /*0x10*/ string prefix;
                /*0x18*/ string uri;
                /*0x20*/ int scopeId;
                /*0x24*/ int previousNsIndex;

                /*0x777e5ac*/ void Set(string prefix, string uri, int scopeId, int previousNsIndex);
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

            static /*0x777fc18*/ XmlQualifiedName();
            static /*0x777f704*/ bool op_Equality(System.Xml.XmlQualifiedName a, System.Xml.XmlQualifiedName b);
            static /*0x777f694*/ bool op_Inequality(System.Xml.XmlQualifiedName a, System.Xml.XmlQualifiedName b);
            static /*0x777f76c*/ string ToString(string name, string ns);
            static /*0x777f3ac*/ System.Xml.XmlQualifiedName.HashCodeOfStringDelegate GetHashCodeDelegate();
            static /*0x777f7dc*/ bool IsRandomizedHashingDisabled();
            static /*0x777f898*/ int GetHashCodeOfString(string s, int length, long additionalEntropy);
            static /*0x777f9f0*/ System.Xml.XmlQualifiedName Parse(string s, System.Xml.IXmlNamespaceResolver nsmgr, ref string prefix);
            /*0x777f210*/ XmlQualifiedName();
            /*0x777f2a8*/ XmlQualifiedName(string name);
            /*0x777f22c*/ XmlQualifiedName(string name, string ns);
            /*0x777f2c0*/ string get_Namespace();
            /*0x777f2c8*/ string get_Name();
            /*0x777f2d0*/ int GetHashCode();
            /*0x777f508*/ bool get_IsEmpty();
            /*0x777f544*/ string ToString();
            /*0x777f5b4*/ bool Equals(object other);
            /*0x777f8b4*/ void Init(string name, string ns);
            /*0x777f8ec*/ void SetNamespace(string ns);
            /*0x777f8f4*/ void Verify();
            /*0x777f984*/ void Atomize(System.Xml.XmlNameTable nameTable);
            /*0x777fb98*/ System.Xml.XmlQualifiedName Clone();

            class HashCodeOfStringDelegate : System.MulticastDelegate
            {
                /*0x777f7e4*/ HashCodeOfStringDelegate(object object, nint method);
                /*0x777fcb4*/ int Invoke(string s, int sLen, long additionalEntropy);
            }
        }

        class XmlResolver
        {
            /*0x7780004*/ XmlResolver();
            /*0x380bd40*/ object GetEntity(System.Uri absoluteUri, string role, System.Type ofObjectToReturn);
            /*0x777fcc8*/ System.Uri ResolveUri(System.Uri baseUri, string relativeUri);
            /*0x777fe94*/ bool SupportsType(System.Uri absoluteUri, System.Type type);
            /*0x777ffcc*/ System.Threading.Tasks.Task<object> GetEntityAsync(System.Uri absoluteUri, string role, System.Type ofObjectToReturn);
        }

        class XmlUrlResolver : System.Xml.XmlResolver
        {
            static /*0x0*/ object s_DownloadManager;
            /*0x10*/ System.Net.ICredentials _credentials;
            /*0x18*/ System.Net.IWebProxy _proxy;
            /*0x20*/ System.Net.Cache.RequestCachePolicy _cachePolicy;

            static /*0x778000c*/ System.Xml.XmlDownloadManager get_DownloadManager();
            /*0x77800d8*/ XmlUrlResolver();
            /*0x77800e0*/ object GetEntity(System.Uri absoluteUri, string role, System.Type ofObjectToReturn);
            /*0x7780234*/ System.Uri ResolveUri(System.Uri baseUri, string relativeUri);
            /*0x7780238*/ System.Threading.Tasks.Task<object> GetEntityAsync(System.Uri absoluteUri, string role, System.Type ofObjectToReturn);

            struct <GetEntityAsync>d__15 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object> <>t__builder;
                /*0x30*/ System.Type ofObjectToReturn;
                /*0x38*/ System.Uri absoluteUri;
                /*0x40*/ System.Xml.XmlUrlResolver <>4__this;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.IO.Stream> <>u__1;

                /*0x7780384*/ void MoveNext();
                /*0x7780734*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class BinaryCompatibility
        {
            static /*0x77807b0*/ bool get_TargetsAtLeast_Desktop_V4_5_2();
        }

        class Res
        {
            static /*0x7774538*/ string GetString(string name);
            static /*0x7775af4*/ string GetString(string name, object[] args);
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

                /*0x77807b8*/ System.Xml.XmlNameTable get_NameTable();
                /*0x77807c0*/ bool get_HasLineInfo();
                /*0x77807c8*/ int GetXmlNamespaceNode(ref MS.Internal.Xml.Cache.XPathNode[] pageXmlNmsp);
                /*0x77807f0*/ int LookupNamespaces(MS.Internal.Xml.Cache.XPathNode[] pageElem, int idxElem, ref MS.Internal.Xml.Cache.XPathNode[] pageNmsp);
            }

            class XPathException : System.SystemException
            {
                /*0x90*/ string res;
                /*0x98*/ string[] args;
                /*0xa0*/ string message;

                static /*0x7780eb4*/ System.Xml.XPath.XPathException Create(string res);
                static /*0x7780f1c*/ System.Xml.XPath.XPathException Create(string res, string arg);
                static /*0x7780fd0*/ System.Xml.XPath.XPathException Create(string res, string arg, string arg2);
                static /*0x7780b58*/ string CreateMessage(string res, string[] args);
                /*0x77808dc*/ XPathException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x7780d7c*/ XPathException();
                /*0x7780d98*/ XPathException(string message, System.Exception innerException);
                /*0x7780f14*/ XPathException(string res, string[] args);
                /*0x7780e40*/ XPathException(string res, string[] args, System.Exception inner);
                /*0x7780c94*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x77810a8*/ string get_Message();
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
                /*0x77810d4*/ XPathItem();
                /*0x380b9e8*/ System.Xml.Schema.XmlSchemaType get_XmlType();
                /*0x380b9e8*/ string get_Value();
                /*0x380b9e8*/ object get_TypedValue();
                /*0x380b9e8*/ System.Type get_ValueType();
                /*0x380b128*/ bool get_ValueAsBoolean();
                /*0x380b538*/ System.DateTime get_ValueAsDateTime();
                /*0x380b564*/ double get_ValueAsDouble();
                /*0x380b6a0*/ int get_ValueAsInt();
                /*0x380b828*/ long get_ValueAsLong();
                /*0x77810c0*/ object ValueAs(System.Type returnType);
                /*0x380bcbc*/ object ValueAs(System.Type returnType, System.Xml.IXmlNamespaceResolver nsResolver);
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

                static /*0x7782ecc*/ XPathNavigator();
                static /*0x7782eb4*/ bool IsText(System.Xml.XPath.XPathNodeType type);
                /*0x7782ec4*/ XPathNavigator();
                /*0x77810dc*/ string ToString();
                /*0x77810e8*/ System.Xml.Schema.XmlSchemaType get_XmlType();
                /*0x7781270*/ object get_TypedValue();
                /*0x778154c*/ System.Type get_ValueType();
                /*0x778173c*/ bool get_ValueAsBoolean();
                /*0x7781a00*/ System.DateTime get_ValueAsDateTime();
                /*0x7781ccc*/ double get_ValueAsDouble();
                /*0x7781f98*/ int get_ValueAsInt();
                /*0x7782264*/ long get_ValueAsLong();
                /*0x7782530*/ object ValueAs(System.Type returnType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x778281c*/ object System.ICloneable.Clone();
                /*0x380b9e8*/ System.Xml.XmlNameTable get_NameTable();
                /*0x778282c*/ string LookupNamespace(string prefix);
                /*0x77829c4*/ string LookupPrefix(string namespaceURI);
                /*0x7782ba8*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
                /*0x380b9e8*/ System.Xml.XPath.XPathNavigator Clone();
                /*0x380b6a0*/ System.Xml.XPath.XPathNodeType get_NodeType();
                /*0x380b9e8*/ string get_LocalName();
                /*0x380b9e8*/ string get_NamespaceURI();
                /*0x380b9e8*/ string get_Prefix();
                /*0x7782dc4*/ object get_UnderlyingObject();
                /*0x7782dcc*/ bool MoveToNamespace(string name);
                /*0x380b228*/ bool MoveToFirstNamespace(System.Xml.XPath.XPathNamespaceScope namespaceScope);
                /*0x380b228*/ bool MoveToNextNamespace(System.Xml.XPath.XPathNamespaceScope namespaceScope);
                /*0x380b128*/ bool MoveToParent();
                /*0x380b2f0*/ bool IsSamePosition(System.Xml.XPath.XPathNavigator other);
                /*0x7782e6c*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            }

            class XPathNavigatorKeyComparer : System.Collections.IEqualityComparer
            {
                /*0x7783054*/ XPathNavigatorKeyComparer();
                /*0x778305c*/ bool System.Collections.IEqualityComparer.Equals(object obj1, object obj2);
                /*0x7783138*/ int System.Collections.IEqualityComparer.GetHashCode(object obj);
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

                static /*0x77836c4*/ CodeIdentifier();
                static /*0x7783304*/ string MakePascal(string identifier);
                static /*0x77834a8*/ string MakeValid(string identifier);
                static /*0x7783684*/ bool IsValidStart(char c);
                static /*0x778362c*/ bool IsValid(char c);
            }

            class XmlSerializerNamespaces
            {
                /*0x10*/ System.Collections.Hashtable namespaces;

                /*0x7783740*/ XmlSerializerNamespaces();
                /*0x7783748*/ void Add(string prefix, string ns);
                /*0x77837fc*/ void AddInternal(string prefix, string ns);
                /*0x77838a8*/ System.Xml.XmlQualifiedName[] ToArray();
                /*0x7783dc0*/ int get_Count();
                /*0x7783998*/ System.Collections.ArrayList get_NamespaceList();
                /*0x7783838*/ System.Collections.Hashtable get_Namespaces();
                /*0x7783de4*/ void set_Namespaces(System.Collections.Hashtable value);
            }

            class XmlAttributeEventHandler : System.MulticastDelegate
            {
                /*0x7783dec*/ XmlAttributeEventHandler(object object, nint method);
                /*0x7783ef8*/ void Invoke(object sender, System.Xml.Serialization.XmlAttributeEventArgs e);
            }

            class XmlAttributeEventArgs : System.EventArgs
            {
                /*0x10*/ object o;
                /*0x18*/ System.Xml.XmlAttribute attr;
                /*0x20*/ string qnames;
                /*0x28*/ int lineNumber;
                /*0x2c*/ int linePosition;

                /*0x7783f0c*/ XmlAttributeEventArgs(System.Xml.XmlAttribute attr, int lineNumber, int linePosition, object o, string qnames);
            }

            class XmlElementEventHandler : System.MulticastDelegate
            {
                /*0x7783fc8*/ XmlElementEventHandler(object object, nint method);
                /*0x77840d4*/ void Invoke(object sender, System.Xml.Serialization.XmlElementEventArgs e);
            }

            class XmlElementEventArgs : System.EventArgs
            {
                /*0x10*/ object o;
                /*0x18*/ System.Xml.XmlElement elem;
                /*0x20*/ string qnames;
                /*0x28*/ int lineNumber;
                /*0x2c*/ int linePosition;

                /*0x77840e8*/ XmlElementEventArgs(System.Xml.XmlElement elem, int lineNumber, int linePosition, object o, string qnames);
            }

            class XmlNodeEventHandler : System.MulticastDelegate
            {
                /*0x77841a4*/ XmlNodeEventHandler(object object, nint method);
                /*0x77842b0*/ void Invoke(object sender, System.Xml.Serialization.XmlNodeEventArgs e);
            }

            class XmlNodeEventArgs : System.EventArgs
            {
                /*0x10*/ object o;
                /*0x18*/ System.Xml.XmlNode xmlNode;
                /*0x20*/ int lineNumber;
                /*0x24*/ int linePosition;

                /*0x77842c4*/ XmlNodeEventArgs(System.Xml.XmlNode xmlNode, int lineNumber, int linePosition, object o);
            }

            class UnreferencedObjectEventHandler : System.MulticastDelegate
            {
                /*0x7784364*/ UnreferencedObjectEventHandler(object object, nint method);
                /*0x7784470*/ void Invoke(object sender, System.Xml.Serialization.UnreferencedObjectEventArgs e);
            }

            class UnreferencedObjectEventArgs : System.EventArgs
            {
                /*0x10*/ object o;
                /*0x18*/ string id;

                /*0x7784484*/ UnreferencedObjectEventArgs(object o, string id);
            }

            interface IXmlSerializable
            {
                /*0x380b9e8*/ System.Xml.Schema.XmlSchema GetSchema();
                /*0x380d83c*/ void ReadXml(System.Xml.XmlReader reader);
                /*0x380d83c*/ void WriteXml(System.Xml.XmlWriter writer);
            }

            interface IXmlTextParser
            {
                /*0x380b128*/ bool get_Normalized();
                /*0x380cdf0*/ void set_Normalized(bool value);
                /*0x380b6a0*/ System.Xml.WhitespaceHandling get_WhitespaceHandling();
                /*0x380cffc*/ void set_WhitespaceHandling(System.Xml.WhitespaceHandling value);
            }

            class KeyHelper
            {
                static /*0x778450c*/ void AddField(System.Text.StringBuilder sb, int n, string val);
                static /*0x7784514*/ void AddField(System.Text.StringBuilder sb, int n, string val, string def);
                static /*0x77845f8*/ void AddField(System.Text.StringBuilder sb, int n, bool val);
                static /*0x7784604*/ void AddField(System.Text.StringBuilder sb, int n, bool val, bool def);
                static /*0x7784654*/ void AddField(System.Text.StringBuilder sb, int n, int val, int def);
                static /*0x778470c*/ void AddField(System.Text.StringBuilder sb, int n, System.Type val);
            }

            class ReflectionHelper
            {
                static /*0x0*/ System.Reflection.ParameterModifier[] empty_modifiers;
                /*0x10*/ System.Collections.Hashtable _clrTypes;
                /*0x18*/ System.Collections.Hashtable _schemaTypes;

                static /*0x7784fcc*/ ReflectionHelper();
                static /*0x7784c00*/ void CheckSerializableType(System.Type type, bool allowPrivateConstructors);
                /*0x7784f3c*/ ReflectionHelper();
                /*0x77847ec*/ void RegisterSchemaType(System.Xml.Serialization.XmlTypeMapping map, string xmlType, string ns);
                /*0x77848b8*/ System.Xml.Serialization.XmlTypeMapping GetRegisteredSchemaType(string xmlType, string ns);
                /*0x778498c*/ void RegisterClrType(System.Xml.Serialization.XmlTypeMapping map, System.Type type, string ns);
                /*0x7784abc*/ System.Xml.Serialization.XmlTypeMapping GetRegisteredClrType(System.Type type, string ns);
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

                /*0x7785040*/ SerializationSource(string namspace, System.Type[] includedTypes);
                /*0x778508c*/ bool BaseEquals(System.Xml.Serialization.SerializationSource other);
            }

            class XmlTypeSerializationSource : System.Xml.Serialization.SerializationSource
            {
                /*0x28*/ string attributeOverridesHash;
                /*0x30*/ System.Type type;
                /*0x38*/ string rootHash;

                /*0x7785198*/ XmlTypeSerializationSource(System.Type type, System.Xml.Serialization.XmlRootAttribute root, System.Xml.Serialization.XmlAttributeOverrides attributeOverrides, string namspace, System.Type[] includedTypes);
                /*0x77857bc*/ bool Equals(object o);
                /*0x778589c*/ int GetHashCode();
            }

            class XmlTypeConvertorAttribute : System.Attribute
            {
                /*0x10*/ string <Method>k__BackingField;

                /*0x77858cc*/ XmlTypeConvertorAttribute(string method);
                /*0x77858bc*/ string get_Method();
                /*0x77858c4*/ void set_Method(string value);
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

                static /*0x7786d68*/ TypeData();
                static /*0x7786b48*/ System.Reflection.PropertyInfo GetIndexerProperty(System.Type collectionType);
                static /*0x7786c4c*/ System.InvalidOperationException CreateMissingAddMethodException(System.Type type, string inheritFrom, System.Type argumentType);
                static /*0x7786960*/ System.Type GetGenericListItemType(System.Type type);
                /*0x77858fc*/ TypeData(System.Type type, string elementName, bool isPrimitive);
                /*0x778590c*/ TypeData(System.Type type, string elementName, bool isPrimitive, System.Xml.Serialization.TypeData mappedType, System.Xml.Schema.XmlSchemaPatternFacet facet);
                /*0x7785ed8*/ void LookupTypeConvertor();
                /*0x7785f8c*/ void ConvertForAssignment(ref object value);
                /*0x7786080*/ string get_TypeName();
                /*0x7786088*/ string get_XmlType();
                /*0x7786090*/ System.Type get_Type();
                /*0x7786098*/ string get_FullTypeName();
                /*0x77860a0*/ System.Xml.Serialization.SchemaTypes get_SchemaType();
                /*0x7784f2c*/ bool get_IsListType();
                /*0x77860a8*/ bool get_IsComplexType();
                /*0x77860e0*/ bool get_IsValueType();
                /*0x7786154*/ bool get_IsNullable();
                /*0x778625c*/ void set_IsNullable(bool value);
                /*0x7785d1c*/ System.Xml.Serialization.TypeData get_ListItemTypeData();
                /*0x7786268*/ System.Type get_ListItemType();
                /*0x77860d0*/ bool get_IsXsdType();
                /*0x7786d60*/ bool get_HasPublicConstructor();
            }

            class TypeMember
            {
                /*0x10*/ System.Type type;
                /*0x18*/ string member;

                static /*0x7787e54*/ bool Equals(System.Xml.Serialization.TypeMember tm1, System.Xml.Serialization.TypeMember tm2);
                /*0x7787d58*/ TypeMember(System.Type type, string member);
                /*0x7787d9c*/ int GetHashCode();
                /*0x7787de4*/ bool Equals(object obj);
                /*0x7787ee0*/ string ToString();
            }

            class TypeTranslator
            {
                static /*0x0*/ System.Collections.Hashtable nameCache;
                static /*0x8*/ System.Collections.Hashtable primitiveTypes;
                static /*0x10*/ System.Collections.Hashtable primitiveArrayTypes;
                static /*0x18*/ System.Collections.Hashtable nullableTypes;

                static /*0x7787f44*/ TypeTranslator();
                static /*0x7784ed0*/ System.Xml.Serialization.TypeData GetTypeData(System.Type type);
                static /*0x778a334*/ System.Xml.Serialization.TypeData GetTypeData(System.Type runtimeType, string xmlDataType, bool underlyingEnumType);
                static /*0x778acb0*/ System.Xml.Serialization.TypeData GetPrimitiveTypeData(string typeName);
                static /*0x778ad08*/ System.Xml.Serialization.TypeData GetPrimitiveTypeData(string typeName, bool nullable);
                static /*0x778af08*/ System.Xml.Serialization.TypeData FindPrimitiveTypeData(string typeName);
                static /*0x7785dd4*/ string GetArrayName(string elemName);
                static /*0x778afc8*/ void ParseArrayType(string arrayType, ref string type, ref string ns, ref string dimensions);
            }

            class XmlAnyAttributeAttribute : System.Attribute
            {
                /*0x778b160*/ XmlAnyAttributeAttribute();
            }

            class XmlAnyElementAttribute : System.Attribute
            {
                /*0x10*/ string elementName;
                /*0x18*/ string ns;
                /*0x20*/ int order;

                /*0x778b168*/ XmlAnyElementAttribute();
                /*0x778b178*/ string get_Name();
                /*0x778b19c*/ string get_Namespace();
                /*0x778b1a4*/ int get_Order();
                /*0x778b1ac*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlAnyElementAttributes : System.Collections.CollectionBase
            {
                /*0x778b78c*/ XmlAnyElementAttributes();
                /*0x778b23c*/ System.Xml.Serialization.XmlAnyElementAttribute get_Item(int index);
                /*0x778b33c*/ int Add(System.Xml.Serialization.XmlAnyElementAttribute attribute);
                /*0x778b3f4*/ void AddKeyHash(System.Text.StringBuilder sb);
                /*0x778b4c0*/ int get_Order();
            }

            class XmlArrayAttribute : System.Attribute
            {
                /*0x10*/ string elementName;
                /*0x18*/ System.Xml.Schema.XmlSchemaForm form;
                /*0x1c*/ bool isNullable;
                /*0x20*/ string ns;
                /*0x28*/ int order;

                /*0x778b794*/ string get_ElementName();
                /*0x778b7b8*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0x778b7c0*/ bool get_IsNullable();
                /*0x778b7c8*/ string get_Namespace();
                /*0x778b7d0*/ int get_Order();
                /*0x778b7d8*/ void AddKeyHash(System.Text.StringBuilder sb);
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

                /*0x778b8f4*/ string get_DataType();
                /*0x778b918*/ string get_ElementName();
                /*0x778b93c*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0x778b944*/ string get_Namespace();
                /*0x778b94c*/ bool get_IsNullable();
                /*0x778b954*/ bool get_IsNullableSpecified();
                /*0x778b95c*/ System.Type get_Type();
                /*0x778b964*/ int get_NestingLevel();
                /*0x778b96c*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlArrayItemAttributes : System.Collections.CollectionBase
            {
                /*0x778bd44*/ XmlArrayItemAttributes();
                /*0x778bac0*/ System.Xml.Serialization.XmlArrayItemAttribute get_Item(int index);
                /*0x778bbc0*/ int Add(System.Xml.Serialization.XmlArrayItemAttribute attribute);
                /*0x778bc78*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlAttributeAttribute : System.Attribute
            {
                /*0x10*/ string attributeName;
                /*0x18*/ string dataType;
                /*0x20*/ System.Type type;
                /*0x28*/ System.Xml.Schema.XmlSchemaForm form;
                /*0x30*/ string ns;

                /*0x778bd4c*/ XmlAttributeAttribute(string attributeName);
                /*0x778bd7c*/ string get_AttributeName();
                /*0x778bda0*/ string get_DataType();
                /*0x778bdc4*/ void set_DataType(string value);
                /*0x778bdcc*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0x778bdd4*/ string get_Namespace();
                /*0x778bddc*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlAttributeOverrides
            {
                /*0x10*/ System.Collections.Hashtable overrides;

                /*0x778bf08*/ XmlAttributeOverrides();
                /*0x778bf74*/ System.Xml.Serialization.XmlAttributes get_Item(System.Type type);
                /*0x778bf8c*/ System.Xml.Serialization.XmlAttributes get_Item(System.Type type, string member);
                /*0x778c040*/ System.Xml.Serialization.TypeMember GetKey(System.Type type, string member);
                /*0x77852b0*/ void AddKeyHash(System.Text.StringBuilder sb);
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

                /*0x778c324*/ XmlAttributes();
                /*0x778c444*/ XmlAttributes(System.Reflection.ICustomAttributeProvider provider);
                /*0x778cc88*/ System.Xml.Serialization.XmlAnyAttributeAttribute get_XmlAnyAttribute();
                /*0x778cc90*/ System.Xml.Serialization.XmlAnyElementAttributes get_XmlAnyElements();
                /*0x778cc98*/ System.Xml.Serialization.XmlArrayAttribute get_XmlArray();
                /*0x778cca0*/ System.Xml.Serialization.XmlArrayItemAttributes get_XmlArrayItems();
                /*0x778cca8*/ System.Xml.Serialization.XmlAttributeAttribute get_XmlAttribute();
                /*0x778ccb0*/ System.Xml.Serialization.XmlChoiceIdentifierAttribute get_XmlChoiceIdentifier();
                /*0x778ccb8*/ object get_XmlDefaultValue();
                /*0x778ccc0*/ System.Xml.Serialization.XmlElementAttributes get_XmlElements();
                /*0x778ccc8*/ bool get_XmlIgnore();
                /*0x778ccd0*/ bool get_Xmlns();
                /*0x778ccd8*/ System.Xml.Serialization.XmlRootAttribute get_XmlRoot();
                /*0x778cce0*/ System.Xml.Serialization.XmlTextAttribute get_XmlText();
                /*0x778cce8*/ System.Xml.Serialization.XmlTypeAttribute get_XmlType();
                /*0x778c0a8*/ void AddKeyHash(System.Text.StringBuilder sb);
                /*0x778ccf0*/ System.Nullable<int> get_Order();
                /*0x778cdac*/ int get_SortableOrder();
            }

            class XmlChoiceIdentifierAttribute : System.Attribute
            {
                /*0x10*/ string memberName;

                /*0x778ce30*/ string get_MemberName();
                /*0x778ce54*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlCustomFormatter
            {
                static /*0x0*/ string[] allTimeFormats;

                static /*0x778e9b0*/ XmlCustomFormatter();
                static /*0x778ced0*/ string FromEnum(long value, string[] values, long[] ids, string typeName);
                static /*0x778d14c*/ string FromXmlName(string name);
                static /*0x778d1a4*/ string FromXmlNCName(string ncName);
                static /*0x778d1fc*/ string ToXmlString(System.Xml.Serialization.TypeData type, object value);
                static /*0x778df14*/ object FromXmlString(System.Xml.Serialization.TypeData type, string value);
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

                /*0x778ef0c*/ XmlElementAttribute(string elementName);
                /*0x778ef44*/ XmlElementAttribute(string elementName, System.Type type);
                /*0x778ef90*/ string get_DataType();
                /*0x778efb4*/ string get_ElementName();
                /*0x778efd8*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0x778efe0*/ string get_Namespace();
                /*0x778efe8*/ bool get_IsNullable();
                /*0x778eff0*/ int get_Order();
                /*0x778eff8*/ System.Type get_Type();
                /*0x778f000*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlElementAttributes : System.Collections.CollectionBase
            {
                /*0x778f698*/ XmlElementAttributes();
                /*0x778f148*/ System.Xml.Serialization.XmlElementAttribute get_Item(int index);
                /*0x778f248*/ int Add(System.Xml.Serialization.XmlElementAttribute attribute);
                /*0x778f300*/ void AddKeyHash(System.Text.StringBuilder sb);
                /*0x778f3cc*/ int get_Order();
            }

            class XmlEnumAttribute : System.Attribute
            {
                /*0x10*/ string name;

                /*0x778f6a0*/ XmlEnumAttribute(string name);
                /*0x778f6d0*/ string get_Name();
                /*0x778f6d8*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlIgnoreAttribute : System.Attribute
            {
                /*0x778f754*/ XmlIgnoreAttribute();
            }

            class XmlIncludeAttribute : System.Attribute
            {
                /*0x10*/ System.Type type;

                /*0x778f75c*/ System.Type get_Type();
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

                /*0x778f764*/ XmlMapping(string elementName, string ns);
                /*0x778f7a8*/ string get_ElementName();
                /*0x778f7b0*/ string get_Namespace();
                /*0x778f7b8*/ void SetKey(string key);
                /*0x778f7c0*/ System.Xml.Serialization.ObjectMap get_ObjectMap();
                /*0x778f7c8*/ void set_ObjectMap(System.Xml.Serialization.ObjectMap value);
                /*0x778f7d0*/ System.Collections.ArrayList get_RelatedMaps();
                /*0x778f7d8*/ void set_RelatedMaps(System.Collections.ArrayList value);
                /*0x778f7e0*/ System.Xml.Serialization.SerializationFormat get_Format();
                /*0x778f7e8*/ void set_Format(System.Xml.Serialization.SerializationFormat value);
                /*0x778f7f0*/ System.Xml.Serialization.SerializationSource get_Source();
            }

            class ObjectMap
            {
                /*0x778f7f8*/ ObjectMap();
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

                /*0x778f800*/ int get_Count();
                /*0x778f81c*/ bool get_HasWrapperElement();
            }

            class XmlNamespaceDeclarationsAttribute : System.Attribute
            {
                /*0x778f824*/ XmlNamespaceDeclarationsAttribute();
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

                static /*0x77966fc*/ XmlReflectionImporter();
                /*0x778f82c*/ XmlReflectionImporter(System.Xml.Serialization.XmlAttributeOverrides attributeOverrides, string defaultNamespace);
                /*0x778f960*/ System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Type type);
                /*0x778fb24*/ System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Type type, string defaultNamespace);
                /*0x778f96c*/ System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Type type, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0x778fb30*/ System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0x7792584*/ System.Xml.Serialization.XmlTypeMapping CreateTypeMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultXmlType, string defaultNamespace);
                /*0x7792a18*/ System.Xml.Serialization.XmlTypeMapping ImportClassMapping(System.Type type, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace, bool isBaseType);
                /*0x778ff7c*/ System.Xml.Serialization.XmlTypeMapping ImportClassMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace, bool isBaseType);
                /*0x7794358*/ void RegisterDerivedMap(System.Xml.Serialization.XmlTypeMapping map, System.Xml.Serialization.XmlTypeMapping derivedMap);
                /*0x7792aa8*/ string GetTypeNamespace(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0x7794564*/ System.Xml.Serialization.XmlTypeMapping ImportListMapping(System.Type type, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace, System.Xml.Serialization.XmlAttributes atts, int nestingLevel);
                /*0x7790f34*/ System.Xml.Serialization.XmlTypeMapping ImportListMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace, System.Xml.Serialization.XmlAttributes atts, int nestingLevel);
                /*0x7791c50*/ System.Xml.Serialization.XmlTypeMapping ImportXmlNodeMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0x7791dec*/ System.Xml.Serialization.XmlTypeMapping ImportPrimitiveMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0x7791ea0*/ System.Xml.Serialization.XmlTypeMapping ImportEnumMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0x7792470*/ System.Xml.Serialization.XmlTypeMapping ImportXmlSerializableMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0x7794440*/ void ImportIncludedTypes(System.Type type, string defaultNamespace);
                /*0x7792bbc*/ System.Collections.Generic.List<System.Xml.Serialization.XmlReflectionMember> GetReflectionMembers(System.Type type);
                /*0x77939a0*/ System.Xml.Serialization.XmlTypeMapMember CreateMapMember(System.Type declaringType, System.Xml.Serialization.XmlReflectionMember rmember, string defaultNamespace);
                /*0x7794cf8*/ System.Xml.Serialization.XmlTypeMapElementInfoList ImportElementInfo(System.Type cls, string defaultName, string defaultNamespace, System.Type defaultType, System.Xml.Serialization.XmlTypeMapMemberElement member, System.Xml.Serialization.XmlAttributes atts);
                /*0x7794664*/ System.Xml.Serialization.XmlTypeMapElementInfoList ImportAnyElementInfo(string defaultNamespace, System.Xml.Serialization.XmlReflectionMember rmember, System.Xml.Serialization.XmlTypeMapMemberElement member, System.Xml.Serialization.XmlAttributes atts);
                /*0x7795ee4*/ void ImportTextElementInfo(System.Xml.Serialization.XmlTypeMapElementInfoList list, System.Type defaultType, System.Xml.Serialization.XmlTypeMapMemberElement member, System.Xml.Serialization.XmlAttributes atts, string defaultNamespace);
                /*0x77929b4*/ bool CanBeNull(System.Xml.Serialization.TypeData type);
                /*0x7796224*/ void IncludeType(System.Type type);
                /*0x7795d24*/ object GetDefaultValue(System.Xml.Serialization.TypeData typeData, object defaultValue);

                class <>c
                {
                    static /*0x0*/ System.Xml.Serialization.XmlReflectionImporter.<> <>9;
                    static /*0x8*/ System.Comparison<System.Xml.Serialization.XmlReflectionMember> <>9__28_0;

                    static /*0x7796798*/ <>c();
                    /*0x7796800*/ <>c();
                    /*0x7796808*/ int <ImportClassMapping>b__28_0(System.Xml.Serialization.XmlReflectionMember m1, System.Xml.Serialization.XmlReflectionMember m2);
                }
            }

            class XmlReflectionMember
            {
                /*0x10*/ bool isReturnValue;
                /*0x18*/ string memberName;
                /*0x20*/ System.Type memberType;
                /*0x28*/ System.Xml.Serialization.XmlAttributes xmlAttributes;
                /*0x30*/ System.Type declaringType;

                /*0x7794604*/ XmlReflectionMember(string name, System.Type type, System.Xml.Serialization.XmlAttributes attributes);
                /*0x779685c*/ bool get_IsReturnValue();
                /*0x7796864*/ string get_MemberName();
                /*0x779686c*/ System.Type get_MemberType();
                /*0x7793930*/ System.Xml.Serialization.XmlAttributes get_XmlAttributes();
                /*0x7796874*/ System.Type get_DeclaringType();
                /*0x779687c*/ void set_DeclaringType(System.Type value);
            }

            class XmlRootAttribute : System.Attribute
            {
                /*0x10*/ string dataType;
                /*0x18*/ string elementName;
                /*0x20*/ bool isNullable;
                /*0x28*/ string ns;

                /*0x7796884*/ XmlRootAttribute();
                /*0x7796894*/ XmlRootAttribute(string elementName);
                /*0x77968cc*/ string get_DataType();
                /*0x77968f0*/ void set_DataType(string value);
                /*0x77929f4*/ string get_ElementName();
                /*0x77968f8*/ void set_ElementName(string value);
                /*0x7796900*/ bool get_IsNullable();
                /*0x7796908*/ void set_IsNullable(bool value);
                /*0x7796914*/ string get_Namespace();
                /*0x779691c*/ void set_Namespace(string value);
                /*0x7796924*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlSchemaProviderAttribute : System.Attribute
            {
                /*0x10*/ string _methodName;
                /*0x18*/ bool _isAny;

                /*0x77969dc*/ XmlSchemaProviderAttribute(string methodName);
                /*0x7796a0c*/ string get_MethodName();
                /*0x7796a14*/ bool get_IsAny();
                /*0x7796a1c*/ void set_IsAny(bool value);
            }

            class XmlSerializationCollectionFixupCallback : System.MulticastDelegate
            {
                /*0x7796a28*/ XmlSerializationCollectionFixupCallback(object object, nint method);
                /*0x7796b34*/ void Invoke(object collection, object collectionItems);
            }

            class XmlSerializationFixupCallback : System.MulticastDelegate
            {
                /*0x7796b48*/ XmlSerializationFixupCallback(object object, nint method);
                /*0x7796c50*/ void Invoke(object fixup);
            }

            class XmlSerializationGeneratedCode
            {
                /*0x7796c64*/ XmlSerializationGeneratedCode();
            }

            class XmlSerializationReadCallback : System.MulticastDelegate
            {
                /*0x7796c6c*/ XmlSerializationReadCallback(object object, nint method);
                /*0x7796d08*/ object Invoke();
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

                /*0x7797194*/ XmlSerializationReader();
                /*0x7796d1c*/ void Initialize(System.Xml.XmlReader reader, System.Xml.Serialization.XmlSerializer eventSource);
                /*0x77970dc*/ System.Collections.ArrayList EnsureArrayList(System.Collections.ArrayList list);
                /*0x7797138*/ System.Collections.Hashtable EnsureHashtable(System.Collections.Hashtable hash);
                /*0x779719c*/ System.Xml.XmlDocument get_Document();
                /*0x7797238*/ System.Xml.XmlReader get_Reader();
                /*0x7797240*/ void AddFixup(System.Xml.Serialization.XmlSerializationReader.CollectionFixup fixup);
                /*0x7797314*/ void AddFixup(System.Xml.Serialization.XmlSerializationReader.Fixup fixup);
                /*0x7797368*/ void AddFixup(System.Xml.Serialization.XmlSerializationReader.CollectionItemFixup fixup);
                /*0x77973bc*/ void AddReadCallback(string name, string ns, System.Type type, System.Xml.Serialization.XmlSerializationReadCallback read);
                /*0x77974e8*/ void AddTarget(string id, object o);
                /*0x77975b0*/ string CurrentTag();
                /*0x7797710*/ System.Exception CreateReadOnlyCollectionException(string name);
                /*0x77977a0*/ System.Exception CreateUnknownConstantException(string value, System.Type enumType);
                /*0x7797838*/ System.Exception CreateUnknownNodeException();
                /*0x77978cc*/ System.Exception CreateUnknownTypeException(System.Xml.XmlQualifiedName type);
                /*0x7797a74*/ System.Array EnsureArrayIndex(System.Array a, int index, System.Type elementType);
                /*0x7797b00*/ bool GetNullAttr();
                /*0x7797ba8*/ object GetTarget(string id);
                /*0x7797c6c*/ bool TargetReady(string id);
                /*0x7797c88*/ System.Xml.XmlQualifiedName GetXsiType();
                /*0x380cb08*/ void InitCallbacks();
                /*0x380cb08*/ void InitIDs();
                /*0x7797e90*/ bool IsXmlnsAttribute(string name);
                /*0x7797f30*/ void ParseWsdlArrayType(System.Xml.XmlAttribute attr);
                /*0x77980b4*/ System.Xml.XmlQualifiedName ReadElementQualifiedName();
                /*0x77983a4*/ void ReadEndElement();
                /*0x779843c*/ bool ReadNull();
                /*0x7798538*/ System.Xml.XmlQualifiedName ReadNullableQualifiedName();
                /*0x7798560*/ string ReadNullableString();
                /*0x77985a8*/ object ReadReferencedElement();
                /*0x77988c8*/ System.Xml.Serialization.XmlSerializationReader.WriteCallbackInfo GetCallbackInfo(System.Xml.XmlQualifiedName qname);
                /*0x7798600*/ object ReadReferencedElement(string name, string ns);
                /*0x77989bc*/ bool ReadList(ref object resultList);
                /*0x7799874*/ void ReadReferencedElements();
                /*0x779a7a4*/ object ReadReferencingElement(ref string fixupReference);
                /*0x7799814*/ object ReadReferencingElement(string name, string ns, ref string fixupReference);
                /*0x779a808*/ object ReadReferencingElement(string name, string ns, bool elementCanBeType, ref string fixupReference);
                /*0x779ab4c*/ System.Xml.Serialization.IXmlSerializable ReadSerializable(System.Xml.Serialization.IXmlSerializable serializable);
                /*0x779acdc*/ object ReadTypedPrimitive(System.Xml.XmlQualifiedName type);
                /*0x7798e90*/ object ReadTypedPrimitive(System.Xml.XmlQualifiedName qname, bool reportUnknown);
                /*0x779af5c*/ System.Xml.XmlNode ReadXmlNode(bool wrapped);
                /*0x779afc4*/ System.Xml.XmlDocument ReadXmlDocument(bool wrapped);
                /*0x779b0e0*/ System.Array ShrinkArray(System.Array a, int length, System.Type elementType, bool isNullable);
                /*0x7798184*/ System.Xml.XmlQualifiedName ToXmlQualifiedName(string value);
                /*0x779b170*/ void UnknownAttribute(object o, System.Xml.XmlAttribute attr, string qnames);
                /*0x779b2cc*/ void UnknownElement(object o, System.Xml.XmlElement elem, string qnames);
                /*0x7798504*/ void UnknownNode(object o);
                /*0x779b428*/ void UnknownNode(object o, string qnames);
                /*0x779ace4*/ void OnUnknownNode(System.Xml.XmlNode node, object o, string qnames);
                /*0x779a710*/ void UnreferencedObject(string id, object o);

                class WriteCallbackInfo
                {
                    /*0x10*/ System.Type Type;
                    /*0x18*/ string TypeName;
                    /*0x20*/ string TypeNs;
                    /*0x28*/ System.Xml.Serialization.XmlSerializationReadCallback Callback;

                    /*0x77974e0*/ WriteCallbackInfo();
                }

                class CollectionFixup
                {
                    /*0x10*/ System.Xml.Serialization.XmlSerializationCollectionFixupCallback callback;
                    /*0x18*/ object collection;
                    /*0x20*/ object collectionItems;
                    /*0x28*/ string id;

                    /*0x779b460*/ CollectionFixup(object collection, System.Xml.Serialization.XmlSerializationCollectionFixupCallback callback, string id);
                    /*0x779b4c0*/ System.Xml.Serialization.XmlSerializationCollectionFixupCallback get_Callback();
                    /*0x779b4c8*/ object get_Collection();
                    /*0x779b4d0*/ object get_Id();
                    /*0x779b4d8*/ object get_CollectionItems();
                    /*0x779b4e0*/ void set_CollectionItems(object value);
                }

                class Fixup
                {
                    /*0x10*/ object source;
                    /*0x18*/ string[] ids;
                    /*0x20*/ System.Xml.Serialization.XmlSerializationFixupCallback callback;

                    /*0x779b4e8*/ Fixup(object o, System.Xml.Serialization.XmlSerializationFixupCallback callback, int count);
                    /*0x779b588*/ System.Xml.Serialization.XmlSerializationFixupCallback get_Callback();
                    /*0x779b590*/ string[] get_Ids();
                    /*0x779b598*/ object get_Source();
                }

                class CollectionItemFixup
                {
                    /*0x10*/ System.Array list;
                    /*0x18*/ int index;
                    /*0x20*/ string id;

                    /*0x7799820*/ CollectionItemFixup(System.Array list, int index, string id);
                    /*0x779b5a0*/ System.Array get_Collection();
                    /*0x779b5a8*/ int get_Index();
                    /*0x779b5b0*/ string get_Id();
                }
            }

            class XmlSerializationReaderInterpreter : System.Xml.Serialization.XmlSerializationReader
            {
                static /*0x0*/ System.Xml.XmlQualifiedName AnyType;
                static /*0x8*/ object[] empty_array;
                /*0xd0*/ System.Xml.Serialization.XmlMapping _typeMap;
                /*0xd8*/ System.Xml.Serialization.SerializationFormat _format;

                static /*0x77a0be8*/ XmlSerializationReaderInterpreter();
                static /*0x779f21c*/ object CreateInstance(System.Type type, bool nonPublic);
                /*0x779b5b8*/ XmlSerializationReaderInterpreter(System.Xml.Serialization.XmlMapping typeMap);
                /*0x779b5fc*/ void InitCallbacks();
                /*0x779ba18*/ void InitIDs();
                /*0x779ba1c*/ object ReadRoot();
                /*0x779bbfc*/ object ReadEncodedObject(System.Xml.Serialization.XmlTypeMapping typeMap);
                /*0x779bd00*/ object ReadMessage(System.Xml.Serialization.XmlMembersMapping typeMap);
                /*0x779bb24*/ object ReadRoot(System.Xml.Serialization.XmlTypeMapping rootMap);
                /*0x779e80c*/ object ReadObject(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable, bool checkType);
                /*0x779ef60*/ object ReadClassInstance(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable, bool checkType);
                /*0x779f228*/ void ReadClassInstanceMembers(System.Xml.Serialization.XmlTypeMapping typeMap, object ob);
                /*0x779c28c*/ void ReadAttributeMembers(System.Xml.Serialization.ClassMap map, object ob, bool isValueList);
                /*0x779c688*/ void ReadMembers(System.Xml.Serialization.ClassMap map, object ob, bool isValueList, bool readBySoapOrder);
                /*0x779f954*/ void SetListMembersDefaults(System.Xml.Serialization.ClassMap map, object ob, bool isValueList);
                /*0x779fecc*/ void FixupMembers(System.Xml.Serialization.ClassMap map, object obfixup, bool isValueList);
                /*0x77a02cc*/ void ProcessUnknownAttribute(object target);
                /*0x77a0300*/ void ProcessUnknownElement(object target);
                /*0x779fa9c*/ bool IsReadOnly(System.Xml.Serialization.XmlTypeMapMember member, System.Xml.Serialization.TypeData memType, object ob, bool isValueList);
                /*0x779f3fc*/ void SetMemberValue(System.Xml.Serialization.XmlTypeMapMember member, object ob, object value, bool isValueList);
                /*0x779c1ec*/ void SetMemberValueFromAttr(System.Xml.Serialization.XmlTypeMapMember member, object ob, object value, bool isValueList);
                /*0x779f590*/ object GetMemberValue(System.Xml.Serialization.XmlTypeMapMember member, object ob, bool isValueList);
                /*0x779fc80*/ object ReadObjectElement(System.Xml.Serialization.XmlTypeMapElementInfo elem);
                /*0x77a0334*/ object ReadPrimitiveValue(System.Xml.Serialization.XmlTypeMapElementInfo elem);
                /*0x779f2d0*/ object GetValueFromXmlString(string value, System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlTypeMapping typeMap);
                /*0x779e8f0*/ object ReadListElement(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable, object list, bool canCreateInstance);
                /*0x77a0440*/ object ReadListString(System.Xml.Serialization.XmlTypeMapping typeMap, string values);
                /*0x779f65c*/ void AddListValue(System.Xml.Serialization.TypeData listType, ref object list, int index, object value, bool canCreateInstance);
                /*0x779c188*/ object CreateInstance(System.Type type);
                /*0x779fbe4*/ object CreateList(System.Type listType);
                /*0x779fb00*/ object InitializeList(System.Xml.Serialization.TypeData listType);
                /*0x77a0788*/ void FillList(object list, object items);
                /*0x77a0798*/ void CopyEnumerableList(object source, object dest);
                /*0x779e7f0*/ object ReadXmlNodeElement(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable);
                /*0x779fe18*/ object ReadXmlNode(System.Xml.Serialization.TypeData type, bool wrapped);
                /*0x779eca4*/ object ReadPrimitiveElement(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable);
                /*0x779ed5c*/ object ReadEnumElement(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable);
                /*0x77a0664*/ object GetEnumValue(System.Xml.Serialization.XmlTypeMapping typeMap, string val);
                /*0x779edcc*/ object ReadXmlSerializableElement(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable);

                class FixupCallbackInfo
                {
                    /*0x10*/ System.Xml.Serialization.XmlSerializationReaderInterpreter _sri;
                    /*0x18*/ System.Xml.Serialization.ClassMap _map;
                    /*0x20*/ bool _isValueList;

                    /*0x779fb8c*/ FixupCallbackInfo(System.Xml.Serialization.XmlSerializationReaderInterpreter sri, System.Xml.Serialization.ClassMap map, bool isValueList);
                    /*0x77a0cdc*/ void FixupMembers(object fixup);
                }

                class ReaderCallbackInfo
                {
                    /*0x10*/ System.Xml.Serialization.XmlSerializationReaderInterpreter _sri;
                    /*0x18*/ System.Xml.Serialization.XmlTypeMapping _typeMap;

                    /*0x779b9d4*/ ReaderCallbackInfo(System.Xml.Serialization.XmlSerializationReaderInterpreter sri, System.Xml.Serialization.XmlTypeMapping typeMap);
                    /*0x77a0d04*/ object ReadObject();
                }
            }

            class XmlSerializationWriteCallback : System.MulticastDelegate
            {
                /*0x77a0d34*/ XmlSerializationWriteCallback(object object, nint method);
                /*0x77a0e3c*/ void Invoke(object o);
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

                /*0x77a0e50*/ XmlSerializationWriter();
                /*0x77a0ec0*/ void Initialize(System.Xml.XmlWriter writer, System.Xml.Serialization.XmlSerializerNamespaces nss);
                /*0x77a0ff0*/ System.Xml.XmlWriter get_Writer();
                /*0x77a0ff8*/ void AddWriteCallback(System.Type type, string typeName, string typeNs, System.Xml.Serialization.XmlSerializationWriteCallback callback);
                /*0x77a1110*/ System.Exception CreateUnknownAnyElementException(string name, string ns);
                /*0x77a11a8*/ System.Exception CreateUnknownTypeException(object o);
                /*0x77a11cc*/ System.Exception CreateUnknownTypeException(System.Type type);
                /*0x77a125c*/ string FromXmlQualifiedName(System.Xml.XmlQualifiedName xmlQualifiedName);
                /*0x77a13dc*/ string GetId(object o, bool addToReferencesList);
                /*0x77a14f0*/ bool AlreadyQueued(object ob);
                /*0x77a1524*/ string GetNamespacePrefix(string ns);
                /*0x77a131c*/ string GetQualifiedName(string name, string ns);
                /*0x380cb08*/ void InitCallbacks();
                /*0x77a165c*/ void TopLevelElement();
                /*0x77a1668*/ void WriteAttribute(string localName, string ns, string value);
                /*0x77a1634*/ void WriteAttribute(string prefix, string localName, string ns, string value);
                /*0x77a167c*/ void WriteXmlNode(System.Xml.XmlNode node);
                /*0x77a171c*/ void WriteElementEncoded(System.Xml.XmlNode node, string name, string ns, bool isNullable, bool any);
                /*0x77a18d0*/ void WriteElementLiteral(System.Xml.XmlNode node, string name, string ns, bool isNullable, bool any);
                /*0x77a1a88*/ void WriteElementQualifiedName(string localName, string ns, System.Xml.XmlQualifiedName value);
                /*0x77a1a90*/ void WriteElementQualifiedName(string localName, string ns, System.Xml.XmlQualifiedName value, System.Xml.XmlQualifiedName xsiType);
                /*0x77a1c90*/ void WriteElementString(string localName, string ns, string value);
                /*0x77a1c98*/ void WriteElementString(string localName, string ns, string value, System.Xml.XmlQualifiedName xsiType);
                /*0x77a1c70*/ void WriteEndElement();
                /*0x77a1de8*/ void WriteEndElement(object o);
                /*0x77a1e28*/ void WriteNamespaceDeclarations(System.Xml.Serialization.XmlSerializerNamespaces xmlns);
                /*0x77a2248*/ void WriteNullableQualifiedNameEncoded(string name, string ns, System.Xml.XmlQualifiedName value, System.Xml.XmlQualifiedName xsiType);
                /*0x77a2300*/ void WriteNullableQualifiedNameLiteral(string name, string ns, System.Xml.XmlQualifiedName value);
                /*0x77a23b4*/ void WriteNullableStringEncoded(string name, string ns, string value, System.Xml.XmlQualifiedName xsiType);
                /*0x77a23c0*/ void WriteNullableStringLiteral(string name, string ns, string value);
                /*0x77a1810*/ void WriteNullTagEncoded(string name, string ns);
                /*0x77a19c4*/ void WriteNullTagLiteral(string name, string ns);
                /*0x77a23d0*/ void WritePotentiallyReferencingElement(string n, string ns, object o, System.Type ambientType, bool suppressReference, bool isNullable);
                /*0x77a29a4*/ void WriteReferencedElements();
                /*0x77a28e4*/ bool IsPrimitiveArray(System.Xml.Serialization.TypeData td);
                /*0x77a2bc0*/ void WriteArray(object o, System.Xml.Serialization.TypeData td);
                /*0x77a2eb0*/ void WriteReferencingElement(string n, string ns, object o, bool isNullable);
                /*0x77a285c*/ void CheckReferenceQueue();
                /*0x77a300c*/ void WriteSerializable(System.Xml.Serialization.IXmlSerializable serializable, string name, string ns, bool isNullable);
                /*0x77a3018*/ void WriteSerializable(System.Xml.Serialization.IXmlSerializable serializable, string name, string ns, bool isNullable, bool wrapped);
                /*0x77a31cc*/ void WriteStartDocument();
                /*0x77a1bac*/ void WriteStartElement(string name, string ns);
                /*0x77a284c*/ void WriteStartElement(string name, string ns, bool writePrefixed);
                /*0x77a3220*/ void WriteStartElement(string name, string ns, object o);
                /*0x77a3214*/ void WriteStartElement(string name, string ns, object o, bool writePrefixed);
                /*0x77a322c*/ void WriteStartElement(string name, string ns, object o, bool writePrefixed, System.Collections.ICollection namespaces);
                /*0x77a3b20*/ void WriteTypedPrimitive(string name, string ns, object o, bool xsiType);
                /*0x77a3dec*/ void WriteValue(string value);
                /*0x77a3e1c*/ void WriteXmlAttribute(System.Xml.XmlNode node, object container);
                /*0x77a1bbc*/ void WriteXsiType(string name, string ns);

                class WriteCallbackInfo
                {
                    /*0x10*/ System.Type Type;
                    /*0x18*/ string TypeName;
                    /*0x20*/ string TypeNs;
                    /*0x28*/ System.Xml.Serialization.XmlSerializationWriteCallback Callback;

                    /*0x77a409c*/ WriteCallbackInfo();
                }
            }

            class XmlSerializationWriterInterpreter : System.Xml.Serialization.XmlSerializationWriter
            {
                /*0x48*/ System.Xml.Serialization.XmlMapping _typeMap;
                /*0x50*/ System.Xml.Serialization.SerializationFormat _format;

                static /*0x77a4f30*/ object ImplicitConvert(object obj, System.Type type);
                /*0x77a40a4*/ XmlSerializationWriterInterpreter(System.Xml.Serialization.XmlMapping typeMap);
                /*0x77a40e8*/ void InitCallbacks();
                /*0x77a4548*/ void WriteRoot(object ob);
                /*0x77a475c*/ void WriteObject(System.Xml.Serialization.XmlTypeMapping typeMap, object ob, string element, string namesp, bool isNullable, bool needType, bool writeWrappingElem);
                /*0x77a538c*/ void WriteMessage(System.Xml.Serialization.XmlMembersMapping membersMap, object[] parameters);
                /*0x77a55c0*/ void WriteObjectElement(System.Xml.Serialization.XmlTypeMapping typeMap, object ob, string element, string namesp);
                /*0x77a57f8*/ void WriteObjectElementAttributes(System.Xml.Serialization.XmlTypeMapping typeMap, object ob);
                /*0x77a5ffc*/ void WriteObjectElementElements(System.Xml.Serialization.XmlTypeMapping typeMap, object ob);
                /*0x77a557c*/ void WriteMembers(System.Xml.Serialization.ClassMap map, object ob, bool isValueList);
                /*0x77a589c*/ void WriteAttributeMembers(System.Xml.Serialization.ClassMap map, object ob, bool isValueList);
                /*0x77a60a0*/ void WriteElementMembers(System.Xml.Serialization.ClassMap map, object ob, bool isValueList);
                /*0x77a6a0c*/ object GetMemberValue(System.Xml.Serialization.XmlTypeMapMember member, object ob, bool isValueList);
                /*0x77a67f0*/ bool MemberHasValue(System.Xml.Serialization.XmlTypeMapMember member, object ob, bool isValueList);
                /*0x77a71a8*/ void WriteMemberElement(System.Xml.Serialization.XmlTypeMapElementInfo elem, object memberValue);
                /*0x77a8e74*/ void WritePrimitiveValueLiteral(object memberValue, string name, string ns, System.Xml.Serialization.XmlTypeMapping mappedType, System.Xml.Serialization.TypeData typeData, bool wrapped, bool isNullable);
                /*0x77a9150*/ void WritePrimitiveValueEncoded(object memberValue, string name, string ns, System.Xml.XmlQualifiedName xsiType, System.Xml.Serialization.XmlTypeMapping mappedType, System.Xml.Serialization.TypeData typeData, bool wrapped, bool isNullable);
                /*0x77a93c0*/ void WriteListElement(System.Xml.Serialization.XmlTypeMapping typeMap, object ob, string element, string namesp);
                /*0x77a7700*/ void WriteListContent(object container, System.Xml.Serialization.TypeData listType, System.Xml.Serialization.ListMap map, object ob, System.Text.StringBuilder targetString);
                /*0x77a95a0*/ int GetListCount(System.Xml.Serialization.TypeData listType, object ob);
                /*0x77a7efc*/ void WriteAnyElementContent(System.Xml.Serialization.XmlTypeMapMemberAnyElement member, object memberValue);
                /*0x77aa47c*/ void WritePrimitiveElement(System.Xml.Serialization.XmlTypeMapping typeMap, object ob, string element, string namesp);
                /*0x77aa4b8*/ void WriteEnumElement(System.Xml.Serialization.XmlTypeMapping typeMap, object ob, string element, string namesp);
                /*0x77a6efc*/ string GetStringValue(System.Xml.Serialization.XmlTypeMapping typeMap, System.Xml.Serialization.TypeData type, object value);
                /*0x77aa4e8*/ string GetEnumXmlValue(System.Xml.Serialization.XmlTypeMapping typeMap, object ob);

                class CallbackInfo
                {
                    /*0x10*/ System.Xml.Serialization.XmlSerializationWriterInterpreter _swi;
                    /*0x18*/ System.Xml.Serialization.XmlTypeMapping _typeMap;

                    /*0x77a4504*/ CallbackInfo(System.Xml.Serialization.XmlSerializationWriterInterpreter swi, System.Xml.Serialization.XmlTypeMapping typeMap);
                    /*0x77aa90c*/ void WriteObject(object ob);
                    /*0x77aa95c*/ void WriteEnum(object ob);
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

                static /*0x77aa9ac*/ XmlSerializer();
                /*0x77aaa60*/ XmlSerializer(System.Type type, System.Xml.Serialization.XmlAttributeOverrides overrides, System.Type[] extraTypes, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0x77aabe4*/ System.Xml.Serialization.XmlMapping get_Mapping();
                /*0x77aabec*/ void OnUnknownAttribute(System.Xml.Serialization.XmlAttributeEventArgs e);
                /*0x77aac14*/ void OnUnknownElement(System.Xml.Serialization.XmlElementEventArgs e);
                /*0x77aac3c*/ void OnUnknownNode(System.Xml.Serialization.XmlNodeEventArgs e);
                /*0x77aac64*/ void OnUnreferencedObject(System.Xml.Serialization.UnreferencedObjectEventArgs e);
                /*0x77aac8c*/ System.Xml.Serialization.XmlSerializationReader CreateReader();
                /*0x77aacc4*/ System.Xml.Serialization.XmlSerializationWriter CreateWriter();
                /*0x77aacfc*/ object Deserialize(System.IO.TextReader textReader);
                /*0x77aad90*/ object Deserialize(System.Xml.XmlReader xmlReader);
                /*0x77aae5c*/ object Deserialize(System.Xml.Serialization.XmlSerializationReader reader);
                /*0x77ab140*/ void Serialize(object o, System.Xml.Serialization.XmlSerializationWriter writer);
                /*0x77ab338*/ void Serialize(System.IO.TextWriter textWriter, object o);
                /*0x77ab6d4*/ void Serialize(System.Xml.XmlWriter xmlWriter, object o);
                /*0x77ab3c8*/ void Serialize(System.Xml.XmlWriter xmlWriter, object o, System.Xml.Serialization.XmlSerializerNamespaces namespaces);
                /*0x77ab6dc*/ System.Xml.Serialization.XmlSerializationWriter CreateWriter(System.Xml.Serialization.XmlMapping typeMapping);
                /*0x77aae00*/ System.Xml.Serialization.XmlSerializationReader CreateReader(System.Xml.Serialization.XmlMapping typeMapping);

                class SerializerData
                {
                    /*0x10*/ System.Reflection.MethodInfo ReaderMethod;
                    /*0x18*/ System.Type WriterType;
                    /*0x20*/ System.Reflection.MethodInfo WriterMethod;
                    /*0x28*/ System.Xml.Serialization.XmlSerializerImplementation Implementation;

                    /*0x77ab8e0*/ System.Xml.Serialization.XmlSerializationWriter CreateWriter();
                }
            }

            class XmlSerializerFactory
            {
                static /*0x0*/ System.Collections.Hashtable serializersBySource;

                static /*0x77abc4c*/ XmlSerializerFactory();
                /*0x77ab9ac*/ XmlSerializerFactory();
                /*0x77ab9b4*/ System.Xml.Serialization.XmlSerializer CreateSerializer(System.Type type);
                /*0x77abc38*/ System.Xml.Serialization.XmlSerializer CreateSerializer(System.Type type, System.Xml.Serialization.XmlRootAttribute root);
                /*0x77ab9c8*/ System.Xml.Serialization.XmlSerializer CreateSerializer(System.Type type, System.Xml.Serialization.XmlAttributeOverrides overrides, System.Type[] extraTypes, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
            }

            class XmlSerializerImplementation
            {
                /*0x77abcc8*/ System.Xml.Serialization.XmlSerializationWriter get_Writer();
            }

            class XmlTextAttribute : System.Attribute
            {
                /*0x10*/ string dataType;
                /*0x18*/ System.Type type;

                /*0x77abd00*/ XmlTextAttribute();
                /*0x77abd08*/ string get_DataType();
                /*0x77abd2c*/ System.Type get_Type();
                /*0x77abd34*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlTypeAttribute : System.Attribute
            {
                /*0x10*/ bool includeInSchema;
                /*0x18*/ string ns;
                /*0x20*/ string typeName;

                /*0x77abdc4*/ bool get_IncludeInSchema();
                /*0x77abdcc*/ string get_Namespace();
                /*0x77abdd4*/ string get_TypeName();
                /*0x77abdf8*/ void AddKeyHash(System.Text.StringBuilder sb);
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

                /*0x77abe9c*/ XmlTypeMapElementInfo(System.Xml.Serialization.XmlTypeMapMember member, System.Xml.Serialization.TypeData type);
                /*0x77abf68*/ System.Xml.Serialization.TypeData get_TypeData();
                /*0x77abf70*/ object get_ChoiceValue();
                /*0x77abf78*/ void set_ChoiceValue(object value);
                /*0x77abf80*/ string get_ElementName();
                /*0x77abf88*/ void set_ElementName(string value);
                /*0x77abf90*/ string get_Namespace();
                /*0x77abf98*/ void set_Namespace(string value);
                /*0x77a90e8*/ string get_DataTypeNamespace();
                /*0x77a90b8*/ string get_DataTypeName();
                /*0x77abfa0*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0x77abfa8*/ void set_Form(System.Xml.Schema.XmlSchemaForm value);
                /*0x77abfb0*/ System.Xml.Serialization.XmlTypeMapping get_MappedType();
                /*0x77abfb8*/ void set_MappedType(System.Xml.Serialization.XmlTypeMapping value);
                /*0x77abfc0*/ bool get_IsNullable();
                /*0x77abfc8*/ void set_IsNullable(bool value);
                /*0x77abfd4*/ System.Xml.Serialization.XmlTypeMapMember get_Member();
                /*0x77abfdc*/ void set_NestingLevel(int value);
                /*0x77abfe4*/ bool get_MultiReferenceType();
                /*0x77ac004*/ bool get_WrappedElement();
                /*0x77ac00c*/ void set_WrappedElement(bool value);
                /*0x77ac018*/ bool get_IsTextElement();
                /*0x77ac064*/ void set_IsTextElement(bool value);
                /*0x77ac120*/ bool get_IsUnnamedAnyElement();
                /*0x77ac140*/ void set_IsUnnamedAnyElement(bool value);
                /*0x77ac1d4*/ int get_ExplicitOrder();
                /*0x77ac1dc*/ void set_ExplicitOrder(int value);
                /*0x77ac1e4*/ bool Equals(object other);
                /*0x77ac31c*/ int GetHashCode();
            }

            class XmlTypeMapElementInfoList : System.Collections.ArrayList
            {
                /*0x77ac324*/ XmlTypeMapElementInfoList();
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

                static /*0x77ac6cc*/ object GetValue(object ob, string name);
                static /*0x77ac91c*/ void SetValue(object ob, string name, object value);
                /*0x77ac32c*/ XmlTypeMapMember();
                /*0x77ac3a4*/ string get_Name();
                /*0x77ac3ac*/ void set_Name(string value);
                /*0x77ac3b4*/ object get_DefaultValue();
                /*0x77ac3bc*/ void set_DefaultValue(object value);
                /*0x77ac3c4*/ bool IsReadOnly(System.Type type);
                /*0x77a56e8*/ object GetValue(object ob);
                /*0x77ac7e8*/ void SetValue(object ob, object value);
                /*0x77ac478*/ void InitMember(System.Type type);
                /*0x77aca4c*/ System.Xml.Serialization.TypeData get_TypeData();
                /*0x77aca54*/ void set_TypeData(System.Xml.Serialization.TypeData value);
                /*0x77aca5c*/ int get_Index();
                /*0x77aca64*/ void set_Index(int value);
                /*0x77aca6c*/ int get_GlobalIndex();
                /*0x77aca74*/ void set_GlobalIndex(int value);
                /*0x77a8c3c*/ bool get_IsOptionalValueType();
                /*0x77aca7c*/ void set_IsOptionalValueType(bool value);
                /*0x77aca9c*/ bool get_IsReturnValue();
                /*0x77acaa8*/ void set_IsReturnValue(bool value);
                /*0x77acad8*/ void CheckOptionalValueType(System.Type type);
                /*0x77a8c48*/ bool GetValueSpecified(object ob);
                /*0x77acb54*/ void SetValueSpecified(object ob, bool value);
            }

            class XmlTypeMapMemberAttribute : System.Xml.Serialization.XmlTypeMapMember
            {
                /*0x58*/ string _attributeName;
                /*0x60*/ string _namespace;
                /*0x68*/ System.Xml.Schema.XmlSchemaForm _form;
                /*0x70*/ System.Xml.Serialization.XmlTypeMapping _mappedType;

                /*0x77acdcc*/ XmlTypeMapMemberAttribute();
                /*0x77ace20*/ string get_AttributeName();
                /*0x77ace28*/ void set_AttributeName(string value);
                /*0x77ace30*/ string get_Namespace();
                /*0x77ace38*/ void set_Namespace(string value);
                /*0x77ace40*/ void set_Form(System.Xml.Schema.XmlSchemaForm value);
                /*0x77ace48*/ System.Xml.Serialization.XmlTypeMapping get_MappedType();
                /*0x77ace50*/ void set_MappedType(System.Xml.Serialization.XmlTypeMapping value);
            }

            class XmlTypeMapMemberElement : System.Xml.Serialization.XmlTypeMapMember
            {
                /*0x58*/ System.Xml.Serialization.XmlTypeMapElementInfoList _elementInfo;
                /*0x60*/ string _choiceMember;
                /*0x68*/ bool _isTextCollector;
                /*0x70*/ System.Xml.Serialization.TypeData _choiceTypeData;

                /*0x77ace58*/ XmlTypeMapMemberElement();
                /*0x77a7138*/ System.Xml.Serialization.XmlTypeMapElementInfoList get_ElementInfo();
                /*0x77ace5c*/ void set_ElementInfo(System.Xml.Serialization.XmlTypeMapElementInfoList value);
                /*0x77ace64*/ string get_ChoiceMember();
                /*0x77ace6c*/ void set_ChoiceMember(string value);
                /*0x77ace74*/ System.Xml.Serialization.TypeData get_ChoiceTypeData();
                /*0x77ace7c*/ void set_ChoiceTypeData(System.Xml.Serialization.TypeData value);
                /*0x77a8540*/ System.Xml.Serialization.XmlTypeMapElementInfo FindElement(object ob, object memberValue);
                /*0x77ace84*/ void SetChoice(object ob, object choice);
                /*0x77ace94*/ bool get_IsXmlTextCollector();
                /*0x77ace9c*/ void set_IsXmlTextCollector(bool value);
            }

            class XmlTypeMapMemberList : System.Xml.Serialization.XmlTypeMapMemberElement
            {
                /*0x77acea8*/ XmlTypeMapMemberList();
            }

            class XmlTypeMapMemberExpandable : System.Xml.Serialization.XmlTypeMapMemberElement
            {
                /*0x78*/ int _flatArrayIndex;

                /*0x77acebc*/ XmlTypeMapMemberExpandable();
                /*0x77aceac*/ int get_FlatArrayIndex();
                /*0x77aceb4*/ void set_FlatArrayIndex(int value);
            }

            class XmlTypeMapMemberFlatList : System.Xml.Serialization.XmlTypeMapMemberExpandable
            {
                /*0x80*/ System.Xml.Serialization.ListMap _listMap;

                /*0x77aced0*/ XmlTypeMapMemberFlatList();
                /*0x77acec0*/ System.Xml.Serialization.ListMap get_ListMap();
                /*0x77acec8*/ void set_ListMap(System.Xml.Serialization.ListMap value);
            }

            class XmlTypeMapMemberAnyElement : System.Xml.Serialization.XmlTypeMapMemberExpandable
            {
                /*0x77ad1dc*/ XmlTypeMapMemberAnyElement();
                /*0x77aa128*/ bool IsElementDefined(string name, string ns);
                /*0x77aced4*/ bool get_IsDefaultAny();
            }

            class XmlTypeMapMemberAnyAttribute : System.Xml.Serialization.XmlTypeMapMember
            {
                /*0x77ad1e0*/ XmlTypeMapMemberAnyAttribute();
            }

            class XmlTypeMapMemberNamespaces : System.Xml.Serialization.XmlTypeMapMember
            {
                /*0x77ad1e4*/ XmlTypeMapMemberNamespaces();
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

                /*0x77ad1e8*/ XmlTypeMapping(string elementName, string ns, System.Xml.Serialization.TypeData typeData, string xmlType, string xmlTypeNamespace);
                /*0x77aa590*/ string get_TypeFullName();
                /*0x77ad2c0*/ System.Xml.Serialization.TypeData get_TypeData();
                /*0x77ad2c8*/ string get_XmlType();
                /*0x77ad2d0*/ void set_XmlType(string value);
                /*0x77a5368*/ string get_XmlTypeNamespace();
                /*0x77ad2d8*/ void set_XmlTypeNamespace(string value);
                /*0x77ad2e0*/ bool get_HasXmlTypeNamespace();
                /*0x77ad2f0*/ System.Collections.ArrayList get_DerivedTypes();
                /*0x77ad2f8*/ bool get_MultiReferenceType();
                /*0x77ad300*/ System.Xml.Serialization.XmlTypeMapping get_BaseMap();
                /*0x77ad308*/ void set_BaseMap(System.Xml.Serialization.XmlTypeMapping value);
                /*0x77ad310*/ void set_IncludeInSchema(bool value);
                /*0x77ad31c*/ bool get_IsNullable();
                /*0x77ad324*/ void set_IsNullable(bool value);
                /*0x77ad330*/ bool get_IsAny();
                /*0x77ad338*/ void set_IsAny(bool value);
                /*0x77a5204*/ System.Xml.Serialization.XmlTypeMapping GetRealTypeMap(System.Type objectType);
                /*0x77ad344*/ System.Xml.Serialization.XmlTypeMapping GetRealElementMap(string name, string ens);
                /*0x77ad6c0*/ void UpdateRoot(System.Xml.XmlQualifiedName qname);
            }

            class XmlSerializableMapping : System.Xml.Serialization.XmlTypeMapping
            {
                /*0x78*/ System.Xml.Schema.XmlSchema _schema;
                /*0x80*/ System.Xml.Schema.XmlSchemaComplexType _schemaType;
                /*0x88*/ System.Xml.XmlQualifiedName _schemaTypeName;

                /*0x77ad764*/ XmlSerializableMapping(System.Xml.Serialization.XmlRootAttribute root, string elementName, string ns, System.Xml.Serialization.TypeData typeData, string xmlType, string xmlTypeNamespace);
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

                /*0x77afb4c*/ ClassMap();
                /*0x77adf54*/ void AddMember(System.Xml.Serialization.XmlTypeMapMember member);
                /*0x77aec10*/ void RegisterFlatList(System.Xml.Serialization.XmlTypeMapMemberExpandable member);
                /*0x77aecbc*/ System.Xml.Serialization.XmlTypeMapMemberAttribute GetAttribute(string name, string ns);
                /*0x77aed78*/ System.Xml.Serialization.XmlTypeMapElementInfo GetElement(string name, string ns, int minimalOrder);
                /*0x77af140*/ System.Xml.Serialization.XmlTypeMapElementInfo GetElement(string name, string ns);
                /*0x77aeb30*/ string BuildKey(string name, string ns, int explicitOrder);
                /*0x77af4d8*/ bool get_IsOrderDependentMap();
                /*0x77af8b8*/ System.Xml.Serialization.XmlTypeMapMemberAnyElement get_DefaultAnyElementMember();
                /*0x77af8c0*/ System.Xml.Serialization.XmlTypeMapMemberAnyAttribute get_DefaultAnyAttributeMember();
                /*0x77af8c8*/ System.Xml.Serialization.XmlTypeMapMemberNamespaces get_NamespaceDeclarations();
                /*0x77a6ad4*/ System.Collections.ICollection get_AttributeMembers();
                /*0x77af8d0*/ System.Collections.ICollection get_ElementMembers();
                /*0x77af8d8*/ System.Collections.ArrayList get_AllMembers();
                /*0x77af8e0*/ System.Collections.ArrayList get_FlatLists();
                /*0x77af8e8*/ System.Collections.ArrayList get_ListMembers();
                /*0x77af8f0*/ System.Xml.Serialization.XmlTypeMapMember get_XmlTextCollector();
                /*0x77af8f8*/ System.Xml.Serialization.XmlTypeMapMember get_ReturnMember();
                /*0x77af900*/ System.Xml.XmlQualifiedName get_SimpleContentBaseType();
                /*0x77afad4*/ void SetCanBeSimpleType(bool can);
                /*0x77afae0*/ bool get_HasSimpleContent();
            }

            class ListMap : System.Xml.Serialization.ObjectMap
            {
                /*0x10*/ System.Xml.Serialization.XmlTypeMapElementInfoList _itemInfo;
                /*0x18*/ string _choiceMember;

                /*0x77b038c*/ ListMap();
                /*0x77afc00*/ void set_ChoiceMember(string value);
                /*0x77afc08*/ System.Xml.Serialization.XmlTypeMapElementInfoList get_ItemInfo();
                /*0x77afc10*/ void set_ItemInfo(System.Xml.Serialization.XmlTypeMapElementInfoList value);
                /*0x77a98e0*/ System.Xml.Serialization.XmlTypeMapElementInfo FindElement(object ob, int index, object memberValue);
                /*0x77afc18*/ System.Xml.Serialization.XmlTypeMapElementInfo FindElement(string elementName, string ns);
                /*0x77aff34*/ System.Xml.Serialization.XmlTypeMapElementInfo FindTextElement();
                /*0x77a96b0*/ void GetArrayType(int itemCount, ref string localName, ref string ns);
                /*0x77b0220*/ bool Equals(object other);
                /*0x77b0384*/ int GetHashCode();
            }

            class EnumMap : System.Xml.Serialization.ObjectMap
            {
                /*0x10*/ System.Xml.Serialization.EnumMap.EnumMapMember[] _members;
                /*0x18*/ bool _isFlags;
                /*0x20*/ string[] _enumNames;
                /*0x28*/ string[] _xmlNames;
                /*0x30*/ long[] _values;

                /*0x77b0394*/ EnumMap(System.Xml.Serialization.EnumMap.EnumMapMember[] members, bool isFlags);
                /*0x77b053c*/ bool get_IsFlags();
                /*0x77b0544*/ string[] get_EnumNames();
                /*0x77b054c*/ string[] get_XmlNames();
                /*0x77b0554*/ long[] get_Values();
                /*0x77aa5ac*/ string GetXmlName(string typeName, object enumValue);
                /*0x77b055c*/ string GetEnumName(string typeName, string xmlName);

                class EnumMapMember
                {
                    /*0x10*/ string _xmlName;
                    /*0x18*/ string _enumName;
                    /*0x20*/ long _value;

                    /*0x77b082c*/ EnumMapMember(string xmlName, string enumName, long value);
                    /*0x77b0884*/ string get_XmlName();
                    /*0x77b088c*/ string get_EnumName();
                    /*0x77b0894*/ long get_Value();
                }
            }
        }

        namespace XmlConfiguration
        {
            class XmlReaderSection
            {
                static /*0x77b089c*/ bool get_ProhibitDefaultUrlResolver();
                static /*0x77b08a4*/ System.Xml.XmlResolver CreateDefaultResolver();
                static /*0x77b08f8*/ bool get_CollapseWhiteSpaceIntoEmptyString();
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

                    /*0x77b0900*/ void Clear();
                    /*0x77b0910*/ int get_Count();
                    /*0x77b0918*/ string GetResult();
                    /*0x77b0a00*/ void ConcatNoDelimiter(string s);
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

                /*0x77b0cfc*/ AxisElement(System.Xml.Schema.DoubleLinkAxis node, int depth);
                /*0x77b0cf4*/ System.Xml.Schema.DoubleLinkAxis get_CurNode();
                /*0x77b0d3c*/ void SetDepth(int depth);
                /*0x77b0d44*/ void MoveToParent(int depth, System.Xml.Schema.ForwardAxis parent);
                /*0x77b0e70*/ bool MoveToChild(string name, string URN, int depth, System.Xml.Schema.ForwardAxis parent);
            }

            class AxisStack
            {
                /*0x10*/ System.Collections.ArrayList _stack;
                /*0x18*/ System.Xml.Schema.ForwardAxis _subtree;
                /*0x20*/ System.Xml.Schema.ActiveAxis _parent;

                static /*0x77b1018*/ bool Equal(string thisname, string thisURN, string name, string URN);
                /*0x77b10c0*/ AxisStack(System.Xml.Schema.ForwardAxis faxis, System.Xml.Schema.ActiveAxis parent);
                /*0x77b1094*/ System.Xml.Schema.ForwardAxis get_Subtree();
                /*0x77b109c*/ int get_Length();
                /*0x77b1188*/ void Push(int depth);
                /*0x77b1228*/ void Pop();
                /*0x77b1268*/ void MoveToParent(string name, string URN, int depth);
                /*0x77b13b0*/ bool MoveToChild(string name, string URN, int depth);
                /*0x77b14f0*/ bool MoveToAttribute(string name, string URN, int depth);
            }

            class ActiveAxis
            {
                /*0x10*/ int _currentDepth;
                /*0x14*/ bool _isActive;
                /*0x18*/ System.Xml.Schema.Asttree _axisTree;
                /*0x20*/ System.Collections.ArrayList _axisStack;

                /*0x77b1680*/ ActiveAxis(System.Xml.Schema.Asttree axisTree);
                /*0x77b1664*/ int get_CurrentDepth();
                /*0x77b166c*/ void Reactivate();
                /*0x77b1840*/ bool MoveToStartElement(string localname, string URN);
                /*0x77b1980*/ bool EndElement(string localname, string URN);
                /*0x77b1a90*/ bool MoveToAttribute(string localname, string URN);
            }

            class DoubleLinkAxis : MS.Internal.Xml.XPath.Axis
            {
                /*0x40*/ MS.Internal.Xml.XPath.Axis next;

                static /*0x77b1c3c*/ System.Xml.Schema.DoubleLinkAxis ConvertTree(MS.Internal.Xml.XPath.Axis axis);
                /*0x77b1bac*/ DoubleLinkAxis(MS.Internal.Xml.XPath.Axis axis, System.Xml.Schema.DoubleLinkAxis inputaxis);
                /*0x77b1b9c*/ MS.Internal.Xml.XPath.Axis get_Next();
                /*0x77b1ba4*/ void set_Next(MS.Internal.Xml.XPath.Axis value);
            }

            class ForwardAxis
            {
                /*0x10*/ System.Xml.Schema.DoubleLinkAxis _topNode;
                /*0x18*/ System.Xml.Schema.DoubleLinkAxis _rootNode;
                /*0x20*/ bool _isAttribute;
                /*0x21*/ bool _isDss;
                /*0x22*/ bool _isSelfAxis;

                /*0x77b1d24*/ ForwardAxis(System.Xml.Schema.DoubleLinkAxis axis, bool isdesorself);
                /*0x77b1cfc*/ System.Xml.Schema.DoubleLinkAxis get_RootNode();
                /*0x77b1d04*/ System.Xml.Schema.DoubleLinkAxis get_TopNode();
                /*0x77b1d0c*/ bool get_IsAttribute();
                /*0x77b1d14*/ bool get_IsDss();
                /*0x77b1d1c*/ bool get_IsSelfAxis();
            }

            class Asttree
            {
                /*0x10*/ System.Collections.ArrayList _fAxisArray;
                /*0x18*/ string _xpathexpr;
                /*0x20*/ bool _isField;
                /*0x28*/ System.Xml.XmlNamespaceManager _nsmgr;

                static /*0x77b2734*/ bool IsNameTest(MS.Internal.Xml.XPath.Axis ast);
                static /*0x77b0fe4*/ bool IsAttribute(MS.Internal.Xml.XPath.Axis ast);
                static /*0x77b2768*/ bool IsDescendantOrSelf(MS.Internal.Xml.XPath.Axis ast);
                static /*0x77b1e8c*/ bool IsSelf(MS.Internal.Xml.XPath.Axis ast);
                /*0x77b1ed4*/ Asttree(string xPath, bool isField, System.Xml.XmlNamespaceManager nsmgr);
                /*0x77b1ecc*/ System.Collections.ArrayList get_SubtreeArray();
                /*0x77b1f40*/ void CompileXPath(string xPath, bool isField, System.Xml.XmlNamespaceManager nsmgr);
                /*0x77b27a8*/ void SetURN(MS.Internal.Xml.XPath.Axis axis, System.Xml.XmlNamespaceManager nsmgr);
            }

            class AutoValidator : System.Xml.Schema.BaseValidator
            {
                /*0x77b28c8*/ AutoValidator(System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling);
                /*0x77b2a50*/ bool get_PreserveWhitespace();
                /*0x77b2a58*/ void Validate();
                /*0x77b2e84*/ void CompleteValidation();
                /*0x77b2e88*/ object FindId(string name);
                /*0x77b2b40*/ System.Xml.ValidationType DetectValidationType();
            }

            class BaseProcessor
            {
                /*0x10*/ System.Xml.XmlNameTable nameTable;
                /*0x18*/ System.Xml.Schema.SchemaNames schemaNames;
                /*0x20*/ System.Xml.Schema.ValidationEventHandler eventHandler;
                /*0x28*/ System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings;
                /*0x30*/ int errorCount;
                /*0x38*/ string NsXml;

                /*0x77b2f30*/ BaseProcessor(System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler);
                /*0x77b2fb4*/ BaseProcessor(System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler, System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings);
                /*0x77b3088*/ System.Xml.XmlNameTable get_NameTable();
                /*0x77b3090*/ System.Xml.Schema.SchemaNames get_SchemaNames();
                /*0x77b3114*/ System.Xml.Schema.ValidationEventHandler get_EventHandler();
                /*0x77b311c*/ System.Xml.Schema.XmlSchemaCompilationSettings get_CompilationSettings();
                /*0x77b3124*/ bool get_HasErrors();
                /*0x77b3134*/ void AddToTable(System.Xml.Schema.XmlSchemaObjectTable table, System.Xml.XmlQualifiedName qname, System.Xml.Schema.XmlSchemaObject item);
                /*0x77b3594*/ bool IsValidAttributeGroupRedefine(System.Xml.Schema.XmlSchemaObject existingObject, System.Xml.Schema.XmlSchemaObject item, System.Xml.Schema.XmlSchemaObjectTable table);
                /*0x77b37e4*/ bool IsValidGroupRedefine(System.Xml.Schema.XmlSchemaObject existingObject, System.Xml.Schema.XmlSchemaObject item, System.Xml.Schema.XmlSchemaObjectTable table);
                /*0x77b36bc*/ bool IsValidTypeRedefine(System.Xml.Schema.XmlSchemaObject existingObject, System.Xml.Schema.XmlSchemaObject item, System.Xml.Schema.XmlSchemaObjectTable table);
                /*0x77b3980*/ void SendValidationEvent(string code, System.Xml.Schema.XmlSchemaObject source);
                /*0x77b38f8*/ void SendValidationEvent(string code, string msg, System.Xml.Schema.XmlSchemaObject source);
                /*0x77b3ac0*/ void SendValidationEvent(string code, string msg1, string msg2, System.Xml.Schema.XmlSchemaObject source);
                /*0x77b3bb4*/ void SendValidationEvent(string code, string[] args, System.Exception innerException, System.Xml.Schema.XmlSchemaObject source);
                /*0x77b3c70*/ void SendValidationEvent(string code, string msg1, string msg2, string sourceUri, int lineNumber, int linePosition);
                /*0x77b3d7c*/ void SendValidationEvent(string code, System.Xml.Schema.XmlSchemaObject source, System.Xml.Schema.XmlSeverityType severity);
                /*0x77b3e00*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e);
                /*0x77b3e08*/ void SendValidationEvent(string code, string msg, System.Xml.Schema.XmlSchemaObject source, System.Xml.Schema.XmlSeverityType severity);
                /*0x77b39f8*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity);
                /*0x77b3e94*/ void SendValidationEventNoThrow(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity);
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

                static /*0x77b4ae8*/ void ProcessEntity(System.Xml.Schema.SchemaInfo sinfo, string name, object sender, System.Xml.Schema.ValidationEventHandler eventhandler, string baseUri, int lineNumber, int linePosition);
                static /*0x77b4ca8*/ void ProcessEntity(System.Xml.Schema.SchemaInfo sinfo, string name, System.Xml.IValidationEventHandling eventHandling, string baseUriStr, int lineNumber, int linePosition);
                static /*0x77b4e9c*/ System.Xml.Schema.BaseValidator CreateInstance(System.Xml.ValidationType valType, System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling, bool processIdentityConstraints);
                /*0x77b3f3c*/ BaseValidator(System.Xml.Schema.BaseValidator other);
                /*0x77b2958*/ BaseValidator(System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling);
                /*0x77b3ff4*/ System.Xml.XmlValidatingReaderImpl get_Reader();
                /*0x77b3ffc*/ System.Xml.Schema.XmlSchemaCollection get_SchemaCollection();
                /*0x77b4004*/ System.Xml.XmlNameTable get_NameTable();
                /*0x77b2e90*/ System.Xml.Schema.SchemaNames get_SchemaNames();
                /*0x77b400c*/ System.Xml.PositionInfo get_PositionInfo();
                /*0x77b4014*/ System.Xml.XmlResolver get_XmlResolver();
                /*0x77b401c*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x77b4024*/ System.Uri get_BaseUri();
                /*0x77b402c*/ void set_BaseUri(System.Uri value);
                /*0x77b4034*/ System.Xml.Schema.ValidationEventHandler get_EventHandler();
                /*0x77b4104*/ System.Xml.Schema.SchemaInfo get_SchemaInfo();
                /*0x77b410c*/ void set_DtdInfo(System.Xml.IDtdInfo value);
                /*0x77b41ec*/ bool get_PreserveWhitespace();
                /*0x77b41f4*/ void Validate();
                /*0x77b41f8*/ void CompleteValidation();
                /*0x77b41fc*/ object FindId(string name);
                /*0x77b4204*/ void ValidateText();
                /*0x77b46cc*/ void ValidateWhitespace();
                /*0x77b4654*/ void SaveTextValue(string value);
                /*0x77b47fc*/ void SendValidationEvent(string code);
                /*0x77b456c*/ void SendValidationEvent(string code, string[] args);
                /*0x77b4484*/ void SendValidationEvent(string code, string arg);
                /*0x77b4814*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e);
                /*0x77b4900*/ void SendValidationEvent(string code, string msg, System.Xml.Schema.XmlSeverityType severity);
                /*0x77b49f4*/ void SendValidationEvent(string code, string[] args, System.Xml.Schema.XmlSeverityType severity);
                /*0x77b481c*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity);
            }

            class BitSet
            {
                /*0x10*/ int count;
                /*0x18*/ uint[] bits;

                /*0x77b5028*/ BitSet();
                /*0x77b5030*/ BitSet(int count);
                /*0x77b50b0*/ int get_Count();
                /*0x77b50b8*/ bool get_Item(int index);
                /*0x77b510c*/ void Clear();
                /*0x77b5160*/ void Set(int index);
                /*0x77b50bc*/ bool Get(int index);
                /*0x77b5264*/ int NextSet(int startFrom);
                /*0x77b52fc*/ void And(System.Xml.Schema.BitSet other);
                /*0x77b53b8*/ void Or(System.Xml.Schema.BitSet other);
                /*0x77b545c*/ int GetHashCode();
                /*0x77b5494*/ bool Equals(object obj);
                /*0x77b55f0*/ System.Xml.Schema.BitSet Clone();
                /*0x77b56ec*/ bool get_IsEmpty();
                /*0x77b5754*/ bool Intersects(System.Xml.Schema.BitSet other);
                /*0x77b50a8*/ int Subscript(int bitIndex);
                /*0x77b51bc*/ void EnsureLength(int nRequiredLength);
            }

            class ChameleonKey
            {
                /*0x10*/ string targetNS;
                /*0x18*/ System.Uri chameleonLocation;
                /*0x20*/ System.Xml.Schema.XmlSchema originalSchema;
                /*0x28*/ int hashCode;

                /*0x77b5830*/ ChameleonKey(string ns, System.Xml.Schema.XmlSchema originalSchema);
                /*0x77b58b8*/ int GetHashCode();
                /*0x77b5938*/ bool Equals(object obj);
            }

            class CompiledIdentityConstraint
            {
                static /*0x0*/ System.Xml.Schema.CompiledIdentityConstraint Empty;
                /*0x10*/ System.Xml.XmlQualifiedName name;
                /*0x18*/ System.Xml.Schema.CompiledIdentityConstraint.ConstraintRole role;
                /*0x20*/ System.Xml.Schema.Asttree selector;
                /*0x28*/ System.Xml.Schema.Asttree[] fields;
                /*0x30*/ System.Xml.XmlQualifiedName refer;

                static /*0x77b5fa4*/ CompiledIdentityConstraint();
                /*0x77b5a2c*/ CompiledIdentityConstraint();
                /*0x77b5ab4*/ CompiledIdentityConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint constraint, System.Xml.XmlNamespaceManager nsmgr);
                /*0x77b5a14*/ System.Xml.Schema.CompiledIdentityConstraint.ConstraintRole get_Role();
                /*0x77b5a1c*/ System.Xml.Schema.Asttree get_Selector();
                /*0x77b5a24*/ System.Xml.Schema.Asttree[] get_Fields();

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

                /*0x77b6010*/ ConstraintStruct(System.Xml.Schema.CompiledIdentityConstraint constraint);
                /*0x77b6008*/ int get_TableDim();
            }

            class LocatedActiveAxis : System.Xml.Schema.ActiveAxis
            {
                /*0x28*/ int column;
                /*0x2c*/ bool isMatched;
                /*0x30*/ System.Xml.Schema.KeySequence Ks;

                /*0x77b61e4*/ LocatedActiveAxis(System.Xml.Schema.Asttree astfield, System.Xml.Schema.KeySequence ks, int column);
                /*0x77b61dc*/ int get_Column();
                /*0x77b6220*/ void Reactivate(System.Xml.Schema.KeySequence ks);
            }

            class SelectorActiveAxis : System.Xml.Schema.ActiveAxis
            {
                /*0x28*/ System.Xml.Schema.ConstraintStruct cs;
                /*0x30*/ System.Collections.ArrayList KSs;
                /*0x38*/ int KSpointer;

                /*0x77b6150*/ SelectorActiveAxis(System.Xml.Schema.Asttree axisTree, System.Xml.Schema.ConstraintStruct cs);
                /*0x77b6238*/ int get_lastDepth();
                /*0x77b62e0*/ bool EndElement(string localname, string URN);
                /*0x77b6328*/ int PushKS(int errline, int errcol);
                /*0x77b6744*/ System.Xml.Schema.KeySequence PopKS();
            }

            class KSStruct
            {
                /*0x10*/ int depth;
                /*0x18*/ System.Xml.Schema.KeySequence ks;
                /*0x20*/ System.Xml.Schema.LocatedActiveAxis[] fields;

                /*0x77b66c0*/ KSStruct(System.Xml.Schema.KeySequence ks, int dim);
            }

            class TypedObject
            {
                /*0x10*/ System.Xml.Schema.TypedObject.DecimalStruct dstruct;
                /*0x18*/ object ovalue;
                /*0x20*/ string svalue;
                /*0x28*/ System.Xml.Schema.XmlSchemaDatatype xsdtype;
                /*0x30*/ int dim;
                /*0x34*/ bool isList;

                /*0x77b683c*/ TypedObject(object obj, string svalue, System.Xml.Schema.XmlSchemaDatatype xsdtype);
                /*0x77b67e4*/ int get_Dim();
                /*0x77b67ec*/ bool get_IsList();
                /*0x77b67f4*/ bool get_IsDecimal();
                /*0x77b6810*/ decimal[] get_Dvalue();
                /*0x77b682c*/ object get_Value();
                /*0x77b6834*/ System.Xml.Schema.XmlSchemaDatatype get_Type();
                /*0x77b69b4*/ string ToString();
                /*0x77b69bc*/ void SetDecimal();
                /*0x77b6d38*/ bool ListDValueEquals(System.Xml.Schema.TypedObject other);
                /*0x77b6e4c*/ bool Equals(System.Xml.Schema.TypedObject other);

                class DecimalStruct
                {
                    /*0x10*/ bool isDecimal;
                    /*0x18*/ decimal[] dvalue;

                    /*0x77b6cd4*/ DecimalStruct();
                    /*0x77b6c64*/ DecimalStruct(int dim);
                    /*0x77b70b0*/ bool get_IsDecimal();
                    /*0x77b70b8*/ void set_IsDecimal(bool value);
                    /*0x77b70c4*/ decimal[] get_Dvalue();
                }
            }

            class KeySequence
            {
                /*0x10*/ System.Xml.Schema.TypedObject[] ks;
                /*0x18*/ int dim;
                /*0x1c*/ int hashcode;
                /*0x20*/ int posline;
                /*0x24*/ int poscol;

                /*0x77b662c*/ KeySequence(int dim, int line, int col);
                /*0x77b70cc*/ int get_PosLine();
                /*0x77b70d4*/ int get_PosCol();
                /*0x77b70dc*/ object get_Item(int index);
                /*0x77b710c*/ void set_Item(int index, object value);
                /*0x77b7208*/ bool IsQualified();
                /*0x77b7268*/ int GetHashCode();
                /*0x77b75d0*/ bool Equals(object other);
                /*0x77b76c0*/ string ToString();
            }

            class UpaException : System.Exception
            {
                /*0x90*/ object particle1;
                /*0x98*/ object particle2;

                /*0x77b77ec*/ UpaException(object particle1, object particle2);
                /*0x77b7874*/ object get_Particle1();
                /*0x77b787c*/ object get_Particle2();
            }

            class SymbolsDictionary
            {
                /*0x10*/ int last;
                /*0x18*/ System.Collections.Hashtable names;
                /*0x20*/ System.Collections.Hashtable wildcards;
                /*0x28*/ System.Collections.ArrayList particles;
                /*0x30*/ object particleLast;
                /*0x38*/ bool isUpaEnforced;

                /*0x77b7884*/ SymbolsDictionary();
                /*0x77b7938*/ int get_Count();
                /*0x77b7944*/ bool get_IsUpaEnforced();
                /*0x77b794c*/ void set_IsUpaEnforced(bool value);
                /*0x77b7958*/ int AddName(System.Xml.XmlQualifiedName name, object particle);
                /*0x77b7a68*/ void AddNamespaceList(System.Xml.Schema.NamespaceList list, object particle, bool allowLocal);
                /*0x77b7e10*/ void AddWildcard(string wildcard, object particle);
                /*0x77b7f84*/ System.Collections.ICollection GetNamespaceListSymbols(System.Xml.Schema.NamespaceList list);
                /*0x77b8710*/ int get_Item(System.Xml.XmlQualifiedName name);
                /*0x77b87a4*/ bool Exists(System.Xml.XmlQualifiedName name);
                /*0x77b87d4*/ object GetParticle(int symbol);
                /*0x77b8810*/ string NameOf(int symbol);
            }

            struct Position
            {
                /*0x10*/ int symbol;
                /*0x18*/ object particle;

                /*0x77b8ec4*/ Position(int symbol, object particle);
            }

            class Positions
            {
                /*0x10*/ System.Collections.ArrayList positions;

                /*0x77b9030*/ Positions();
                /*0x77b8ed4*/ int Add(int symbol, object particle);
                /*0x77b8f7c*/ System.Xml.Schema.Position get_Item(int pos);
                /*0x77b900c*/ int get_Count();
            }

            class SyntaxTreeNode
            {
                /*0x77b90a4*/ SyntaxTreeNode();
                /*0x380da4c*/ void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
                /*0x380da4c*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x380b128*/ bool get_IsNullable();
                /*0x77b909c*/ bool get_IsRangeNode();
            }

            class LeafNode : System.Xml.Schema.SyntaxTreeNode
            {
                /*0x10*/ int pos;

                /*0x77b90ac*/ LeafNode(int pos);
                /*0x77b90d4*/ int get_Pos();
                /*0x77b90dc*/ void set_Pos(int value);
                /*0x77b90e4*/ void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
                /*0x77b90e8*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x77b9128*/ bool get_IsNullable();
            }

            class NamespaceListNode : System.Xml.Schema.SyntaxTreeNode
            {
                /*0x10*/ System.Xml.Schema.NamespaceList namespaceList;
                /*0x18*/ object particle;

                /*0x77b9130*/ NamespaceListNode(System.Xml.Schema.NamespaceList namespaceList, object particle);
                /*0x77b9174*/ System.Collections.ICollection GetResolvedSymbols(System.Xml.Schema.SymbolsDictionary symbols);
                /*0x77b9194*/ void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
                /*0x77b9658*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x77b9690*/ bool get_IsNullable();
            }

            class InteriorNode : System.Xml.Schema.SyntaxTreeNode
            {
                /*0x10*/ System.Xml.Schema.SyntaxTreeNode leftChild;
                /*0x18*/ System.Xml.Schema.SyntaxTreeNode rightChild;

                /*0x77b9934*/ InteriorNode();
                /*0x77b96c8*/ System.Xml.Schema.SyntaxTreeNode get_LeftChild();
                /*0x77b96d0*/ void set_LeftChild(System.Xml.Schema.SyntaxTreeNode value);
                /*0x77b96d8*/ System.Xml.Schema.SyntaxTreeNode get_RightChild();
                /*0x77b96e0*/ void set_RightChild(System.Xml.Schema.SyntaxTreeNode value);
                /*0x77b96e8*/ void ExpandTreeNoRecursive(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
                /*0x77b98d0*/ void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
            }

            class SequenceNode : System.Xml.Schema.InteriorNode
            {
                /*0x77b9f18*/ SequenceNode();
                /*0x77b993c*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x77b9da8*/ bool get_IsNullable();
                /*0x77b9f14*/ void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);

                struct SequenceConstructPosContext
                {
                    /*0x10*/ System.Xml.Schema.SequenceNode this_;
                    /*0x18*/ System.Xml.Schema.BitSet firstpos;
                    /*0x20*/ System.Xml.Schema.BitSet lastpos;
                    /*0x28*/ System.Xml.Schema.BitSet lastposLeft;
                    /*0x30*/ System.Xml.Schema.BitSet firstposRight;

                    /*0x77b9d44*/ SequenceConstructPosContext(System.Xml.Schema.SequenceNode node, System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos);
                }
            }

            class ChoiceNode : System.Xml.Schema.InteriorNode
            {
                static /*0x77b9f20*/ void ConstructChildPos(System.Xml.Schema.SyntaxTreeNode child, System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x77b9650*/ ChoiceNode();
                /*0x77b9ff4*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x77ba120*/ bool get_IsNullable();
                /*0x77ba1b8*/ void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
            }

            class PlusNode : System.Xml.Schema.InteriorNode
            {
                /*0x77ba278*/ PlusNode();
                /*0x77ba1bc*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x77ba258*/ bool get_IsNullable();
            }

            class QmarkNode : System.Xml.Schema.InteriorNode
            {
                /*0x77ba2a8*/ QmarkNode();
                /*0x77ba280*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x77ba2a0*/ bool get_IsNullable();
            }

            class StarNode : System.Xml.Schema.InteriorNode
            {
                /*0x77ba354*/ StarNode();
                /*0x77ba2b0*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x77ba34c*/ bool get_IsNullable();
            }

            class LeafRangeNode : System.Xml.Schema.LeafNode
            {
                /*0x18*/ decimal min;
                /*0x28*/ decimal max;
                /*0x38*/ System.Xml.Schema.BitSet nextIteration;

                /*0x77ba35c*/ LeafRangeNode(decimal min, decimal max);
                /*0x77ba3a4*/ LeafRangeNode(int pos, decimal min, decimal max);
                /*0x77ba3f4*/ decimal get_Max();
                /*0x77ba400*/ decimal get_Min();
                /*0x77ba40c*/ System.Xml.Schema.BitSet get_NextIteration();
                /*0x77ba414*/ void set_NextIteration(System.Xml.Schema.BitSet value);
                /*0x77ba41c*/ bool get_IsRangeNode();
                /*0x77ba424*/ void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
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

                static /*0x77ba808*/ ContentValidator();
                static /*0x77ba570*/ void AddParticleToExpected(System.Xml.Schema.XmlSchemaParticle p, System.Xml.Schema.XmlSchemaSet schemaSet, System.Collections.ArrayList particles);
                static /*0x77ba5e0*/ void AddParticleToExpected(System.Xml.Schema.XmlSchemaParticle p, System.Xml.Schema.XmlSchemaSet schemaSet, System.Collections.ArrayList particles, bool global);
                /*0x77ba458*/ ContentValidator(System.Xml.Schema.XmlSchemaContentType contentType);
                /*0x77ba488*/ ContentValidator(System.Xml.Schema.XmlSchemaContentType contentType, bool isOpen, bool isEmptiable);
                /*0x77ba4c8*/ System.Xml.Schema.XmlSchemaContentType get_ContentType();
                /*0x77ba4d0*/ bool get_PreserveWhitespace();
                /*0x77ba4ec*/ bool get_IsEmptiable();
                /*0x77ba4f4*/ bool get_IsOpen();
                /*0x77ba518*/ void set_IsOpen(bool value);
                /*0x77ba524*/ void InitValidation(System.Xml.Schema.ValidationState context);
                /*0x77ba528*/ object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, ref int errorCode);
                /*0x77ba558*/ bool CompleteValidation(System.Xml.Schema.ValidationState context);
                /*0x77ba560*/ System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, bool isRequiredOnly);
                /*0x77ba568*/ System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, bool isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet);
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

                /*0x77ba91c*/ ParticleContentValidator(System.Xml.Schema.XmlSchemaContentType contentType);
                /*0x77ba924*/ ParticleContentValidator(System.Xml.Schema.XmlSchemaContentType contentType, bool enableUpaCheck);
                /*0x77ba9a4*/ void InitValidation(System.Xml.Schema.ValidationState context);
                /*0x77ba9dc*/ object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, ref int errorCode);
                /*0x77baa14*/ bool CompleteValidation(System.Xml.Schema.ValidationState context);
                /*0x77baa4c*/ void Start();
                /*0x77bab1c*/ void OpenGroup();
                /*0x77bab44*/ void CloseGroup();
                /*0x77bacb8*/ bool Exists(System.Xml.XmlQualifiedName name);
                /*0x77bacf0*/ void AddName(System.Xml.XmlQualifiedName name, object particle);
                /*0x77bae88*/ void AddNamespaceList(System.Xml.Schema.NamespaceList namespaceList, object particle);
                /*0x77bad98*/ void AddLeafNode(System.Xml.Schema.SyntaxTreeNode node);
                /*0x77baf14*/ void AddChoice();
                /*0x77bb000*/ void AddSequence();
                /*0x77bb0ec*/ void AddStar();
                /*0x77bb2e4*/ void AddPlus();
                /*0x77bb340*/ void AddQMark();
                /*0x77bb39c*/ void AddLeafRange(decimal min, decimal max);
                /*0x77bb148*/ void Closure(System.Xml.Schema.InteriorNode node);
                /*0x77bb490*/ System.Xml.Schema.ContentValidator Finish(bool useDFA);
                /*0x77bba1c*/ System.Xml.Schema.BitSet[] CalculateTotalFollowposForRangeNodes(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos, ref System.Xml.Schema.BitSet posWithRangeTerminals);
                /*0x77bbe44*/ void CheckCMUPAWithLeafRangeNodes(System.Xml.Schema.BitSet curpos);
                /*0x77bbcd4*/ System.Xml.Schema.BitSet GetApplicableMinMaxFollowPos(System.Xml.Schema.BitSet curpos, System.Xml.Schema.BitSet posWithRangeTerminals, System.Xml.Schema.BitSet[] minmaxFollowPos);
                /*0x77bbfb0*/ void CheckUniqueParticleAttribution(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos);
                /*0x77bc674*/ void CheckUniqueParticleAttribution(System.Xml.Schema.BitSet curpos);
                /*0x77bc038*/ int[][] BuildTransitionTable(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos, int endMarkerPos);
            }

            class DfaContentValidator : System.Xml.Schema.ContentValidator
            {
                /*0x18*/ int[][] transitionTable;
                /*0x20*/ System.Xml.Schema.SymbolsDictionary symbols;

                /*0x77bc5bc*/ DfaContentValidator(int[][] transitionTable, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.XmlSchemaContentType contentType, bool isOpen, bool isEmptiable);
                /*0x77bc834*/ void InitValidation(System.Xml.Schema.ValidationState context);
                /*0x77bc898*/ object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, ref int errorCode);
                /*0x77bc9a8*/ bool CompleteValidation(System.Xml.Schema.ValidationState context);
                /*0x77bc9c0*/ System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, bool isRequiredOnly);
                /*0x77bcb8c*/ System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, bool isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet);
            }

            class NfaContentValidator : System.Xml.Schema.ContentValidator
            {
                /*0x18*/ System.Xml.Schema.BitSet firstpos;
                /*0x20*/ System.Xml.Schema.BitSet[] followpos;
                /*0x28*/ System.Xml.Schema.SymbolsDictionary symbols;
                /*0x30*/ System.Xml.Schema.Positions positions;
                /*0x38*/ int endMarkerPos;

                /*0x764769c*/ NfaContentValidator(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions, int endMarkerPos, System.Xml.Schema.XmlSchemaContentType contentType, bool isOpen, bool isEmptiable);
                /*0x7647788*/ void InitValidation(System.Xml.Schema.ValidationState context);
                /*0x764785c*/ object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, ref int errorCode);
                /*0x7647a0c*/ bool CompleteValidation(System.Xml.Schema.ValidationState context);
                /*0x7647a54*/ System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, bool isRequiredOnly);
                /*0x7647c38*/ System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, bool isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet);
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

                /*0x7647db4*/ RangeContentValidator(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions, int endMarkerPos, System.Xml.Schema.XmlSchemaContentType contentType, bool isEmptiable, System.Xml.Schema.BitSet positionsWithRangeTerminals, int minmaxNodesCount);
                /*0x7647eb4*/ void InitValidation(System.Xml.Schema.ValidationState context);
                /*0x7648090*/ object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, ref int errorCode);
                /*0x7648970*/ bool CompleteValidation(System.Xml.Schema.ValidationState context);
                /*0x7648988*/ System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, bool isRequiredOnly);
                /*0x7648bf0*/ System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, bool isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet);
            }

            class AllElementsContentValidator : System.Xml.Schema.ContentValidator
            {
                /*0x18*/ System.Collections.Hashtable elements;
                /*0x20*/ object[] particles;
                /*0x28*/ System.Xml.Schema.BitSet isRequired;
                /*0x30*/ int countRequired;

                /*0x7648df4*/ AllElementsContentValidator(System.Xml.Schema.XmlSchemaContentType contentType, int size, bool isEmptiable);
                /*0x7648f1c*/ bool AddElement(System.Xml.XmlQualifiedName name, object particle, bool isEmptiable);
                /*0x7649048*/ bool get_IsEmptiable();
                /*0x7649068*/ void InitValidation(System.Xml.Schema.ValidationState context);
                /*0x7649104*/ object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, ref int errorCode);
                /*0x7649224*/ bool CompleteValidation(System.Xml.Schema.ValidationState context);
                /*0x7649274*/ System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, bool isRequiredOnly);
                /*0x7649698*/ System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, bool isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet);
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

                /*0x7649b64*/ XsdSimpleValue(System.Xml.Schema.XmlSchemaSimpleType st, object value);
                /*0x7649ba8*/ System.Xml.Schema.XmlSchemaSimpleType get_XmlType();
                /*0x7649bb0*/ object get_TypedValue();
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

                /*0x7649bb8*/ RestrictionFacets();
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

                static /*0x7649bc0*/ DatatypeImplementation();
                static /*0x764f2bc*/ System.Xml.Schema.XmlSchemaSimpleType get_AnySimpleType();
                static /*0x764f314*/ System.Xml.Schema.XmlSchemaSimpleType get_UntypedAtomicType();
                static /*0x764f36c*/ System.Xml.Schema.DatatypeImplementation FromXmlTokenizedType(System.Xml.XmlTokenizedType token);
                static /*0x764f3e8*/ System.Xml.Schema.DatatypeImplementation FromXmlTokenizedTypeXsd(System.Xml.XmlTokenizedType token);
                static /*0x764f464*/ System.Xml.Schema.DatatypeImplementation FromXdrName(string name);
                static /*0x764f524*/ System.Xml.Schema.DatatypeImplementation FromTypeName(string name);
                static /*0x764f5e4*/ System.Xml.Schema.XmlSchemaSimpleType StartBuiltinType(System.Xml.XmlQualifiedName qname, System.Xml.Schema.XmlSchemaDatatype dataType);
                static /*0x764f6c8*/ void FinishBuiltinType(System.Xml.Schema.XmlSchemaSimpleType derivedType, System.Xml.Schema.XmlSchemaSimpleType baseType);
                static /*0x764e9ec*/ void CreateBuiltinTypes();
                static /*0x764f90c*/ System.Xml.Schema.XmlSchemaSimpleType GetSimpleTypeFromTypeCode(System.Xml.Schema.XmlTypeCode typeCode);
                static /*0x764f988*/ System.Xml.Schema.XmlSchemaSimpleType GetSimpleTypeFromXsdType(System.Xml.XmlQualifiedName qname);
                static /*0x764fa48*/ System.Xml.Schema.XmlSchemaSimpleType GetNormalizedStringTypeV1Compat();
                static /*0x764fbe0*/ System.Xml.Schema.XmlSchemaSimpleType GetTokenTypeV1Compat();
                static /*0x764fd78*/ System.Xml.Schema.XmlSchemaSimpleType[] GetBuiltInTypes();
                static /*0x764fdd0*/ System.Xml.Schema.XmlTypeCode GetPrimitiveTypeCode(System.Xml.Schema.XmlTypeCode typeCode);
                static /*0x7650120*/ System.Xml.Schema.DatatypeImplementation DeriveByUnion(System.Xml.Schema.XmlSchemaSimpleType[] types, System.Xml.Schema.XmlSchemaType schemaType);
                /*0x7650f24*/ DatatypeImplementation();
                /*0x764ff00*/ System.Xml.Schema.XmlSchemaDatatype DeriveByRestriction(System.Xml.Schema.XmlSchemaObjectCollection facets, System.Xml.XmlNameTable nameTable, System.Xml.Schema.XmlSchemaType schemaType);
                /*0x765001c*/ System.Xml.Schema.XmlSchemaDatatype DeriveByList(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x764de28*/ System.Xml.Schema.XmlSchemaDatatype DeriveByList(int minSize, System.Xml.Schema.XmlSchemaType schemaType);
                /*0x7650250*/ void VerifySchemaValid(System.Xml.Schema.XmlSchemaObjectTable notations, System.Xml.Schema.XmlSchemaObject caller);
                /*0x7650254*/ bool IsDerivedFrom(System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x76504e0*/ bool IsEqual(object o1, object o2);
                /*0x7650504*/ bool IsComparable(System.Xml.Schema.XmlSchemaDatatype dtype);
                /*0x76505f0*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x76505f8*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x7650650*/ System.Xml.Schema.XmlValueConverter get_ValueConverter();
                /*0x76506a0*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x76506a8*/ System.Type get_ValueType();
                /*0x76506d8*/ System.Xml.Schema.XmlSchemaDatatypeVariety get_Variety();
                /*0x76506e0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x76506e8*/ System.Xml.Schema.RestrictionFacets get_Restriction();
                /*0x76506f0*/ bool get_HasLexicalFacets();
                /*0x7650718*/ bool get_HasValueFacets();
                /*0x7650740*/ System.Xml.Schema.DatatypeImplementation get_Base();
                /*0x380b9e8*/ System.Type get_ListValueType();
                /*0x380b6a0*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x7650748*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x7650750*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
                /*0x7650990*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, bool createAtomicValue);
                /*0x7650ae4*/ System.Exception TryParseValue(object value, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver namespaceResolver, ref object typedValue);
                /*0x7650924*/ string GetTypeName();
                /*0x7650eb0*/ int Compare(byte[] value1, byte[] value2);

                class SchemaDatatypeMap : System.IComparable
                {
                    /*0x10*/ string name;
                    /*0x18*/ System.Xml.Schema.DatatypeImplementation type;
                    /*0x20*/ int parentIndex;

                    static /*0x7650f2c*/ System.Xml.Schema.DatatypeImplementation op_Explicit(System.Xml.Schema.DatatypeImplementation.SchemaDatatypeMap sdm);
                    /*0x764e950*/ SchemaDatatypeMap(string name, System.Xml.Schema.DatatypeImplementation type);
                    /*0x764e994*/ SchemaDatatypeMap(string name, System.Xml.Schema.DatatypeImplementation type, int parentIndex);
                    /*0x7650f44*/ string get_Name();
                    /*0x7650f4c*/ int get_ParentIndex();
                    /*0x7650f54*/ int CompareTo(object obj);
                }
            }

            class Datatype_List : System.Xml.Schema.Datatype_anySimpleType
            {
                /*0x38*/ System.Xml.Schema.DatatypeImplementation itemType;
                /*0x40*/ int minListSize;

                /*0x76500a4*/ Datatype_List(System.Xml.Schema.DatatypeImplementation type, int minListSize);
                /*0x7650f94*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x7651230*/ int Compare(object value1, object value2);
                /*0x76514d4*/ System.Type get_ValueType();
                /*0x76514e4*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x7651504*/ System.Type get_ListValueType();
                /*0x7651528*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x7651580*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x76515a0*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x76515a8*/ System.Xml.Schema.DatatypeImplementation get_ItemType();
                /*0x76515b0*/ System.Exception TryParseValue(object value, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver namespaceResolver, ref object typedValue);
                /*0x7651b60*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_union : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                /*0x38*/ System.Xml.Schema.XmlSchemaSimpleType[] types;

                static /*0x7652838*/ Datatype_union();
                /*0x76501e0*/ Datatype_union(System.Xml.Schema.XmlSchemaSimpleType[] types);
                /*0x7651f88*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x7651f94*/ int Compare(object value1, object value2);
                /*0x7652098*/ System.Type get_ValueType();
                /*0x76520f0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x76520f8*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x7652150*/ System.Type get_ListValueType();
                /*0x76521a8*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x76521b0*/ System.Xml.Schema.XmlSchemaSimpleType[] get_BaseMemberTypes();
                /*0x7650028*/ bool HasAtomicMembers();
                /*0x7650458*/ bool IsUnionBaseOf(System.Xml.Schema.DatatypeImplementation derivedType);
                /*0x76521b8*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
                /*0x76523bc*/ System.Exception TryParseValue(object value, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_anySimpleType : System.Xml.Schema.DatatypeImplementation
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x7652af8*/ Datatype_anySimpleType();
                /*0x764d920*/ Datatype_anySimpleType();
                /*0x76528ec*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x7652944*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x765299c*/ System.Type get_ValueType();
                /*0x76529f4*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x76529fc*/ System.Type get_ListValueType();
                /*0x7652a54*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x7652a5c*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x7652a64*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x7652a6c*/ int Compare(object value1, object value2);
                /*0x7652ac8*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_anyAtomicType : System.Xml.Schema.Datatype_anySimpleType
            {
                /*0x764e850*/ Datatype_anyAtomicType();
                /*0x7652bac*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x7652c04*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x7652c0c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_untypedAtomicType : System.Xml.Schema.Datatype_anyAtomicType
            {
                /*0x764e8f8*/ Datatype_untypedAtomicType();
                /*0x7652c14*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x7652c6c*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x7652c74*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_string : System.Xml.Schema.Datatype_anySimpleType
            {
                /*0x764e494*/ Datatype_string();
                /*0x7652c7c*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x7652c88*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x7652c90*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x7652ce8*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x7652cf0*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x7652cf8*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x7652d00*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_boolean : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x76530a8*/ Datatype_boolean();
                /*0x764da20*/ Datatype_boolean();
                /*0x7652dec*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x7652df8*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x7652e50*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x7652e58*/ System.Type get_ValueType();
                /*0x7652eb0*/ System.Type get_ListValueType();
                /*0x7652f08*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x7652f10*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x7652f18*/ int Compare(object value1, object value2);
                /*0x7652f98*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_float : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x7653440*/ Datatype_float();
                /*0x764e020*/ Datatype_float();
                /*0x765315c*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x7653168*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x76531c0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x76531c8*/ System.Type get_ValueType();
                /*0x7653220*/ System.Type get_ListValueType();
                /*0x7653278*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x7653280*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x7653288*/ int Compare(object value1, object value2);
                /*0x76532f8*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_double : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x76537d8*/ Datatype_double();
                /*0x764dd28*/ Datatype_double();
                /*0x76534f4*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x7653500*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x7653558*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x7653560*/ System.Type get_ValueType();
                /*0x76535b8*/ System.Type get_ListValueType();
                /*0x7653610*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x7653618*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x7653620*/ int Compare(object value1, object value2);
                /*0x7653690*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_decimal : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x7653bfc*/ Datatype_decimal();
                /*0x764dcd4*/ Datatype_decimal();
                /*0x765388c*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x7653898*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x76538f0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x76538f8*/ System.Type get_ValueType();
                /*0x7653950*/ System.Type get_ListValueType();
                /*0x76539a8*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x76539b0*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x76539b8*/ int Compare(object value1, object value2);
                /*0x7653a84*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_duration : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x7654174*/ Datatype_duration();
                /*0x764ddd0*/ Datatype_duration();
                /*0x7653dd4*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x7653de0*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x7653e38*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x7653e40*/ System.Type get_ValueType();
                /*0x7653e98*/ System.Type get_ListValueType();
                /*0x7653ef0*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x7653ef8*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x7653f00*/ int Compare(object value1, object value2);
                /*0x7653fa4*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_yearMonthDuration : System.Xml.Schema.Datatype_duration
            {
                /*0x764e8fc*/ Datatype_yearMonthDuration();
                /*0x765423c*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
                /*0x7654410*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_dayTimeDuration : System.Xml.Schema.Datatype_duration
            {
                /*0x764e8a4*/ Datatype_dayTimeDuration();
                /*0x7654418*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
                /*0x76545ec*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_dateTimeBase : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                /*0x38*/ System.Xml.Schema.XsdDateTimeFlags dateTimeFlags;

                static /*0x7654c20*/ Datatype_dateTimeBase();
                /*0x7654660*/ Datatype_dateTimeBase(System.Xml.Schema.XsdDateTimeFlags dateTimeFlags);
                /*0x76545f4*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x7654600*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x7654658*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x76546c8*/ System.Type get_ValueType();
                /*0x7654720*/ System.Type get_ListValueType();
                /*0x7654778*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x7654780*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x7654788*/ int Compare(object value1, object value2);
                /*0x76548d0*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_dateTimeNoTimeZone : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x764dbcc*/ Datatype_dateTimeNoTimeZone();
            }

            class Datatype_dateTimeTimeZone : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x764dc24*/ Datatype_dateTimeTimeZone();
            }

            class Datatype_dateTime : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x764db74*/ Datatype_dateTime();
            }

            class Datatype_timeNoTimeZone : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x764e540*/ Datatype_timeNoTimeZone();
            }

            class Datatype_timeTimeZone : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x764e598*/ Datatype_timeTimeZone();
            }

            class Datatype_time : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x764e4e8*/ Datatype_time();
                /*0x7654ce8*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_date : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x764db1c*/ Datatype_date();
                /*0x7654cf0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_yearMonth : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x764e7f0*/ Datatype_yearMonth();
                /*0x7654cf8*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_year : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x764e798*/ Datatype_year();
                /*0x7654d00*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_monthDay : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x764e22c*/ Datatype_monthDay();
                /*0x7654d08*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_day : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x764dc7c*/ Datatype_day();
                /*0x7654d10*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_month : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x764e1d4*/ Datatype_month();
                /*0x7654d18*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_hexBinary : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x76550b4*/ Datatype_hexBinary();
                /*0x764e0c8*/ Datatype_hexBinary();
                /*0x7654d20*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x7654d2c*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x7654d84*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x7654d8c*/ System.Type get_ValueType();
                /*0x7654de4*/ System.Type get_ListValueType();
                /*0x7654e3c*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x7654e44*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x7654e4c*/ int Compare(object value1, object value2);
                /*0x7654ef4*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_base64Binary : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x765550c*/ Datatype_base64Binary();
                /*0x764d9cc*/ Datatype_base64Binary();
                /*0x765517c*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x7655188*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x76551e0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x76551e8*/ System.Type get_ValueType();
                /*0x7655240*/ System.Type get_ListValueType();
                /*0x7655298*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x76552a0*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x76552a8*/ int Compare(object value1, object value2);
                /*0x7655350*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_anyURI : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x7655b78*/ Datatype_anyURI();
                /*0x764d978*/ Datatype_anyURI();
                /*0x76555d4*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x76555e0*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x7655638*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x7655640*/ System.Type get_ValueType();
                /*0x7655698*/ bool get_HasValueFacets();
                /*0x76556a0*/ System.Type get_ListValueType();
                /*0x76556f8*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x7655700*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x7655708*/ int Compare(object value1, object value2);
                /*0x76557cc*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_QName : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x7655fb8*/ Datatype_QName();
                /*0x764e398*/ Datatype_QName();
                /*0x7655c40*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x7655c4c*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x7655ca4*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x7655cac*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x7655cb4*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x7655cbc*/ System.Type get_ValueType();
                /*0x7655d14*/ System.Type get_ListValueType();
                /*0x7655d6c*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x7655d74*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_normalizedString : System.Xml.Schema.Datatype_string
            {
                /*0x764e2ec*/ Datatype_normalizedString();
                /*0x7656080*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x7656088*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x7656090*/ bool get_HasValueFacets();
            }

            class Datatype_normalizedStringV1Compat : System.Xml.Schema.Datatype_string
            {
                /*0x764e848*/ Datatype_normalizedStringV1Compat();
                /*0x7656098*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x76560a0*/ bool get_HasValueFacets();
            }

            class Datatype_token : System.Xml.Schema.Datatype_normalizedString
            {
                /*0x764e5f0*/ Datatype_token();
                /*0x76560a8*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x76560b0*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
            }

            class Datatype_tokenV1Compat : System.Xml.Schema.Datatype_normalizedStringV1Compat
            {
                /*0x764e84c*/ Datatype_tokenV1Compat();
                /*0x76560b8*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_language : System.Xml.Schema.Datatype_token
            {
                /*0x764e1cc*/ Datatype_language();
                /*0x76560c0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_NMTOKEN : System.Xml.Schema.Datatype_token
            {
                /*0x764e2e0*/ Datatype_NMTOKEN();
                /*0x76560c8*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x76560d0*/ System.Xml.XmlTokenizedType get_TokenizedType();
            }

            class Datatype_Name : System.Xml.Schema.Datatype_token
            {
                /*0x764e284*/ Datatype_Name();
                /*0x76560d8*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_NCName : System.Xml.Schema.Datatype_Name
            {
                /*0x764e288*/ Datatype_NCName();
                /*0x76560e0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x76560e8*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_ID : System.Xml.Schema.Datatype_NCName
            {
                /*0x764e11c*/ Datatype_ID();
                /*0x76561f8*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x7656200*/ System.Xml.XmlTokenizedType get_TokenizedType();
            }

            class Datatype_IDREF : System.Xml.Schema.Datatype_NCName
            {
                /*0x764e120*/ Datatype_IDREF();
                /*0x7656208*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x7656210*/ System.Xml.XmlTokenizedType get_TokenizedType();
            }

            class Datatype_ENTITY : System.Xml.Schema.Datatype_NCName
            {
                /*0x764de24*/ Datatype_ENTITY();
                /*0x7656218*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x7656220*/ System.Xml.XmlTokenizedType get_TokenizedType();
            }

            class Datatype_NOTATION : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x76567ac*/ Datatype_NOTATION();
                /*0x764e2f0*/ Datatype_NOTATION();
                /*0x7656228*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x7656234*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x765628c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x7656294*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x765629c*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x76562a4*/ System.Type get_ValueType();
                /*0x76562fc*/ System.Type get_ListValueType();
                /*0x7656354*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x765635c*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
                /*0x76565a0*/ void VerifySchemaValid(System.Xml.Schema.XmlSchemaObjectTable notations, System.Xml.Schema.XmlSchemaObject caller);
            }

            class Datatype_integer : System.Xml.Schema.Datatype_decimal
            {
                /*0x764e178*/ Datatype_integer();
                /*0x7656874*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x765687c*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_nonPositiveInteger : System.Xml.Schema.Datatype_integer
            {
                static /*0x0*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x7656a38*/ Datatype_nonPositiveInteger();
                /*0x764e2e8*/ Datatype_nonPositiveInteger();
                /*0x76569d0*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x7656a28*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x7656a30*/ bool get_HasValueFacets();
            }

            class Datatype_negativeInteger : System.Xml.Schema.Datatype_nonPositiveInteger
            {
                static /*0x0*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x7656bb0*/ Datatype_negativeInteger();
                /*0x764e28c*/ Datatype_negativeInteger();
                /*0x7656b50*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x7656ba8*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_long : System.Xml.Schema.Datatype_integer
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x7656f98*/ Datatype_long();
                /*0x764e1d0*/ Datatype_long();
                /*0x7656cc8*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x7656d20*/ bool get_HasValueFacets();
                /*0x7656d28*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x7656d30*/ int Compare(object value1, object value2);
                /*0x7656da0*/ System.Type get_ValueType();
                /*0x7656df8*/ System.Type get_ListValueType();
                /*0x7656e50*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_int : System.Xml.Schema.Datatype_long
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x76573c4*/ Datatype_int();
                /*0x764e124*/ Datatype_int();
                /*0x76570fc*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x7657154*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x765715c*/ int Compare(object value1, object value2);
                /*0x76571cc*/ System.Type get_ValueType();
                /*0x7657224*/ System.Type get_ListValueType();
                /*0x765727c*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_short : System.Xml.Schema.Datatype_int
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x76577f0*/ Datatype_short();
                /*0x764e440*/ Datatype_short();
                /*0x7657528*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x7657580*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x7657588*/ int Compare(object value1, object value2);
                /*0x76575f8*/ System.Type get_ValueType();
                /*0x7657650*/ System.Type get_ListValueType();
                /*0x76576a8*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_byte : System.Xml.Schema.Datatype_short
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x7657c1c*/ Datatype_byte();
                /*0x764da74*/ Datatype_byte();
                /*0x7657954*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x76579ac*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x76579b4*/ int Compare(object value1, object value2);
                /*0x7657a24*/ System.Type get_ValueType();
                /*0x7657a7c*/ System.Type get_ListValueType();
                /*0x7657ad4*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_nonNegativeInteger : System.Xml.Schema.Datatype_integer
            {
                static /*0x0*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x7657de8*/ Datatype_nonNegativeInteger();
                /*0x764e2e4*/ Datatype_nonNegativeInteger();
                /*0x7657d80*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x7657dd8*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x7657de0*/ bool get_HasValueFacets();
            }

            class Datatype_unsignedLong : System.Xml.Schema.Datatype_nonNegativeInteger
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x765820c*/ Datatype_unsignedLong();
                /*0x764e69c*/ Datatype_unsignedLong();
                /*0x7657f00*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x7657f58*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x7657f60*/ int Compare(object value1, object value2);
                /*0x7657fd0*/ System.Type get_ValueType();
                /*0x7658028*/ System.Type get_ListValueType();
                /*0x7658080*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_unsignedInt : System.Xml.Schema.Datatype_unsignedLong
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x7658654*/ Datatype_unsignedInt();
                /*0x764e648*/ Datatype_unsignedInt();
                /*0x765838c*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x76583e4*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x76583ec*/ int Compare(object value1, object value2);
                /*0x765845c*/ System.Type get_ValueType();
                /*0x76584b4*/ System.Type get_ListValueType();
                /*0x765850c*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_unsignedShort : System.Xml.Schema.Datatype_unsignedInt
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x7658a9c*/ Datatype_unsignedShort();
                /*0x764e6f0*/ Datatype_unsignedShort();
                /*0x76587d4*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x765882c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x7658834*/ int Compare(object value1, object value2);
                /*0x76588a4*/ System.Type get_ValueType();
                /*0x76588fc*/ System.Type get_ListValueType();
                /*0x7658954*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_unsignedByte : System.Xml.Schema.Datatype_unsignedShort
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x7658ee4*/ Datatype_unsignedByte();
                /*0x764e5f4*/ Datatype_unsignedByte();
                /*0x7658c1c*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x7658c74*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x7658c7c*/ int Compare(object value1, object value2);
                /*0x7658cec*/ System.Type get_ValueType();
                /*0x7658d44*/ System.Type get_ListValueType();
                /*0x7658d9c*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_positiveInteger : System.Xml.Schema.Datatype_nonNegativeInteger
            {
                static /*0x0*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x76590c4*/ Datatype_positiveInteger();
                /*0x764e344*/ Datatype_positiveInteger();
                /*0x7659064*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x76590bc*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_doubleXdr : System.Xml.Schema.Datatype_double
            {
                /*0x764dd7c*/ Datatype_doubleXdr();
                /*0x76591dc*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
            }

            class Datatype_floatXdr : System.Xml.Schema.Datatype_float
            {
                /*0x764e074*/ Datatype_floatXdr();
                /*0x76593b8*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
            }

            class Datatype_QNameXdr : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x76598b8*/ Datatype_QNameXdr();
                /*0x764e3ec*/ Datatype_QNameXdr();
                /*0x7659594*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x765959c*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
                /*0x7659808*/ System.Type get_ValueType();
                /*0x7659860*/ System.Type get_ListValueType();
            }

            class Datatype_ENUMERATION : System.Xml.Schema.Datatype_NMTOKEN
            {
                /*0x764dfc8*/ Datatype_ENUMERATION();
                /*0x7659980*/ System.Xml.XmlTokenizedType get_TokenizedType();
            }

            class Datatype_char : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x7659d3c*/ Datatype_char();
                /*0x764dac8*/ Datatype_char();
                /*0x7659988*/ System.Type get_ValueType();
                /*0x76599e0*/ System.Type get_ListValueType();
                /*0x7659a38*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x7659a40*/ int Compare(object value1, object value2);
                /*0x7659ac0*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
                /*0x7659c84*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_fixed : System.Xml.Schema.Datatype_decimal
            {
                /*0x764dfcc*/ Datatype_fixed();
                /*0x7659df0*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
                /*0x765a2fc*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_uuid : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x765a858*/ Datatype_uuid();
                /*0x764e744*/ Datatype_uuid();
                /*0x765a468*/ System.Type get_ValueType();
                /*0x765a4c0*/ System.Type get_ListValueType();
                /*0x765a518*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x765a520*/ int Compare(object value1, object value2);
                /*0x765a5bc*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
                /*0x765a78c*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
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

                static /*0x765cf24*/ DtdValidator();
                static /*0x765c75c*/ void SetDefaultTypedValue(System.Xml.Schema.SchemaAttDef attdef, System.Xml.IDtdParserAdapter readerAdapter);
                static /*0x765cb1c*/ void CheckDefaultValue(System.Xml.Schema.SchemaAttDef attdef, System.Xml.Schema.SchemaInfo sinfo, System.Xml.IValidationEventHandling eventHandling, string baseUriStr);
                /*0x765a920*/ DtdValidator(System.Xml.XmlValidatingReaderImpl reader, System.Xml.IValidationEventHandling eventHandling, bool processIdentityConstraints);
                /*0x765a9c8*/ void Init();
                /*0x765ac5c*/ void Validate();
                /*0x765af5c*/ bool MeetsStandAloneConstraint();
                /*0x765affc*/ void ValidatePIComment();
                /*0x765ae54*/ void ValidateElement();
                /*0x765b3a0*/ void ValidateChildElement();
                /*0x765b604*/ void ValidateStartElement();
                /*0x765bfc4*/ void ValidateEndStartElement();
                /*0x765b4e8*/ void ProcessElement();
                /*0x765c180*/ void CompleteValidation();
                /*0x765b200*/ void ValidateEndElement();
                /*0x765c3a4*/ bool get_PreserveWhitespace();
                /*0x765c3dc*/ void ProcessTokenizedType(System.Xml.XmlTokenizedType ttype, string name);
                /*0x765ba60*/ void CheckValue(string value, System.Xml.Schema.SchemaAttDef attdef);
                /*0x765c610*/ void AddID(string name, object node);
                /*0x765c6ac*/ object FindId(string name);
                /*0x765b0ac*/ bool GenEntity(System.Xml.XmlQualifiedName qname);
                /*0x765c6c8*/ System.Xml.Schema.SchemaEntity GetEntity(System.Xml.XmlQualifiedName qname, bool fParameterEntity);
                /*0x765c280*/ void CheckForwardRefs();
                /*0x765ab34*/ void Push(System.Xml.XmlQualifiedName elementName);
                /*0x765c1c8*/ bool Pop();

                class NamespaceManager : System.Xml.XmlNamespaceManager
                {
                    /*0x765cfa0*/ NamespaceManager();
                    /*0x765cfa8*/ string LookupNamespace(string prefix);
                }
            }

            class FacetsChecker
            {
                static /*0x765fd20*/ decimal Power(int x, int y);
                /*0x765fe4c*/ FacetsChecker();
                /*0x765cfb0*/ System.Exception CheckLexicalFacets(ref string parseString, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x765d23c*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x765d244*/ System.Exception CheckValueFacets(decimal value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x765d24c*/ System.Exception CheckValueFacets(long value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x765d254*/ System.Exception CheckValueFacets(int value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x765d25c*/ System.Exception CheckValueFacets(short value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x765d264*/ System.Exception CheckValueFacets(System.DateTime value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x765d26c*/ System.Exception CheckValueFacets(double value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x765d274*/ System.Exception CheckValueFacets(float value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x765d27c*/ System.Exception CheckValueFacets(string value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x765d284*/ System.Exception CheckValueFacets(byte[] value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x765d28c*/ System.Exception CheckValueFacets(System.TimeSpan value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x765d294*/ System.Exception CheckValueFacets(System.Xml.XmlQualifiedName value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x765cff4*/ void CheckWhitespaceFacets(ref string s, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x765d0ec*/ System.Exception CheckPatternFacets(System.Xml.Schema.RestrictionFacets restriction, string value);
                /*0x765d29c*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x765d2a4*/ System.Xml.Schema.RestrictionFacets ConstructRestriction(System.Xml.Schema.DatatypeImplementation datatype, System.Xml.Schema.XmlSchemaObjectCollection facets, System.Xml.XmlNameTable nameTable);

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

                    static /*0x7660c20*/ FacetsCompiler();
                    static /*0x7660590*/ string Preprocess(string pattern);
                    /*0x765d6c0*/ FacetsCompiler(System.Xml.Schema.DatatypeImplementation baseDatatype, System.Xml.Schema.RestrictionFacets restriction);
                    /*0x765d908*/ void CompileLengthFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x765dc5c*/ void CompileMinLengthFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x765df74*/ void CompileMaxLengthFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x765e28c*/ void CompilePatternFacet(System.Xml.Schema.XmlSchemaPatternFacet facet);
                    /*0x765e410*/ void CompileEnumerationFacet(System.Xml.Schema.XmlSchemaFacet facet, System.Xml.IXmlNamespaceResolver nsmgr, System.Xml.XmlNameTable nameTable);
                    /*0x765e568*/ void CompileWhitespaceFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x765ec70*/ void CompileMaxInclusiveFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x765ee40*/ void CompileMaxExclusiveFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x765e8d0*/ void CompileMinInclusiveFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x765eaa0*/ void CompileMinExclusiveFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x765f010*/ void CompileTotalDigitsFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x765f320*/ void CompileFractionDigitsFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x765f5d4*/ void FinishFacetCompile();
                    /*0x76600fc*/ void CheckValue(object value, System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x765f948*/ void CompileFacetCombinations();
                    /*0x76607ec*/ void CopyFacetsFromBaseType();
                    /*0x765ff50*/ object ParseFacetValue(System.Xml.Schema.XmlSchemaDatatype datatype, System.Xml.Schema.XmlSchemaFacet facet, string code, System.Xml.IXmlNamespaceResolver nsmgr, System.Xml.XmlNameTable nameTable);
                    /*0x765fe54*/ void CheckProhibitedFlag(System.Xml.Schema.XmlSchemaFacet facet, System.Xml.Schema.RestrictionFlags flag, string errorCode);
                    /*0x765fee0*/ void CheckDupFlag(System.Xml.Schema.XmlSchemaFacet facet, System.Xml.Schema.RestrictionFlags flag, string errorCode);
                    /*0x7660094*/ void SetFlag(System.Xml.Schema.XmlSchemaFacet facet, System.Xml.Schema.RestrictionFlags flag);
                    /*0x7660be4*/ void SetFlag(System.Xml.Schema.RestrictionFlags flag);

                    struct Map
                    {
                        /*0x10*/ char match;
                        /*0x18*/ string replacement;

                        /*0x7660f2c*/ Map(char m, string r);
                    }
                }
            }

            class Numeric10FacetsChecker : System.Xml.Schema.FacetsChecker
            {
                static /*0x0*/ char[] signs;
                /*0x10*/ decimal maxValue;
                /*0x20*/ decimal minValue;

                static /*0x76618b4*/ Numeric10FacetsChecker();
                /*0x7653d94*/ Numeric10FacetsChecker(decimal minVal, decimal maxVal);
                /*0x7660f3c*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7660fac*/ System.Exception CheckValueFacets(decimal value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x766168c*/ System.Exception CheckValueFacets(long value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7661718*/ System.Exception CheckValueFacets(int value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x76617a4*/ System.Exception CheckValueFacets(short value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7661830*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7661568*/ bool MatchEnumeration(decimal value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlValueConverter valueConverter);
                /*0x765a098*/ System.Exception CheckTotalAndFractionDigits(decimal value, int totalDigits, int fractionDigits, bool checkTotal, bool checkFraction);
            }

            class Numeric2FacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x764d908*/ Numeric2FacetsChecker();
                /*0x7661954*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x76619b4*/ System.Exception CheckValueFacets(double value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7661d24*/ System.Exception CheckValueFacets(float value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7661d34*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7661c60*/ bool MatchEnumeration(double value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlValueConverter valueConverter);
            }

            class DurationFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x764d918*/ DurationFacetsChecker();
                /*0x7661dac*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7661eb4*/ System.Exception CheckValueFacets(System.TimeSpan value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7662320*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7662208*/ bool MatchEnumeration(System.TimeSpan value, System.Collections.ArrayList enumeration);
            }

            class DateTimeFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x764d910*/ DateTimeFacetsChecker();
                /*0x7662398*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x76623fc*/ System.Exception CheckValueFacets(System.DateTime value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7662924*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x76627e4*/ bool MatchEnumeration(System.DateTime value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
            }

            class StringFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                static /*0x0*/ System.Text.RegularExpressions.Regex languagePattern;

                static /*0x7662980*/ System.Text.RegularExpressions.Regex get_LanguagePattern();
                /*0x764d900*/ StringFacetsChecker();
                /*0x7662a30*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7662a90*/ System.Exception CheckValueFacets(string value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7655950*/ System.Exception CheckValueFacets(string value, System.Xml.Schema.XmlSchemaDatatype datatype, bool verifyUri);
                /*0x7662ea4*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7662cd4*/ bool MatchEnumeration(string value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7662a98*/ System.Exception CheckBuiltInFacets(string s, System.Xml.Schema.XmlTypeCode typeCode, bool verifyUri);
            }

            class QNameFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x7663410*/ QNameFacetsChecker();
                /*0x7662f00*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7663020*/ System.Exception CheckValueFacets(System.Xml.XmlQualifiedName value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7663308*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x76631f4*/ bool MatchEnumeration(System.Xml.XmlQualifiedName value, System.Collections.ArrayList enumeration);
            }

            class MiscFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x7663418*/ MiscFacetsChecker();
            }

            class BinaryFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x7663818*/ BinaryFacetsChecker();
                /*0x7663420*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x76634b0*/ System.Exception CheckValueFacets(byte[] value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7663794*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7663670*/ bool MatchEnumeration(byte[] value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
            }

            class ListFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x7663af4*/ ListFacetsChecker();
                /*0x7663820*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7663a38*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
            }

            class UnionFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x7663ca4*/ UnionFacetsChecker();
                /*0x7663afc*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x7663be8*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
            }

            interface IXmlSchemaInfo
            {
                /*0x380b6a0*/ System.Xml.Schema.XmlSchemaValidity get_Validity();
                /*0x380b128*/ bool get_IsDefault();
                /*0x380b128*/ bool get_IsNil();
                /*0x380b9e8*/ System.Xml.Schema.XmlSchemaSimpleType get_MemberType();
                /*0x380b9e8*/ System.Xml.Schema.XmlSchemaType get_SchemaType();
                /*0x380b9e8*/ System.Xml.Schema.XmlSchemaElement get_SchemaElement();
                /*0x380b9e8*/ System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute();
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

                static /*0x766cdcc*/ XmlSchemaInference();
                static /*0x766b710*/ int InferSimpleType(string s, ref bool bNeedsRangeCheck);
                static /*0x766ccb8*/ int DateTime(string s, bool bDate, bool bTime);
                static /*0x7668470*/ int GetSchemaType(System.Xml.XmlQualifiedName qname);
                /*0x7663cc4*/ XmlSchemaInference();
                /*0x7663cac*/ void set_Occurrence(System.Xml.Schema.XmlSchemaInference.InferenceOption value);
                /*0x7663cb4*/ System.Xml.Schema.XmlSchemaInference.InferenceOption get_Occurrence();
                /*0x7663cbc*/ void set_TypeInference(System.Xml.Schema.XmlSchemaInference.InferenceOption value);
                /*0x7663e00*/ System.Xml.Schema.XmlSchemaSet InferSchema(System.Xml.XmlReader instanceDocument);
                /*0x7663e74*/ System.Xml.Schema.XmlSchemaSet InferSchema1(System.Xml.XmlReader instanceDocument, System.Xml.Schema.XmlSchemaSet schemas);
                /*0x7666360*/ System.Xml.Schema.XmlSchemaAttribute AddAttribute(string localName, string prefix, string childURI, string attrValue, bool bCreatingNewType, System.Xml.Schema.XmlSchema parentSchema, System.Xml.Schema.XmlSchemaObjectCollection addLocation, System.Xml.Schema.XmlSchemaObjectTable compiledAttributes);
                /*0x7668c44*/ System.Xml.Schema.XmlSchema CreateXmlSchema(string targetNS);
                /*0x76648e0*/ System.Xml.Schema.XmlSchemaElement AddElement(string localName, string prefix, string childURI, System.Xml.Schema.XmlSchema parentSchema, System.Xml.Schema.XmlSchemaObjectCollection addLocation, int positionWithinCollection);
                /*0x7664ef4*/ void InferElement(System.Xml.Schema.XmlSchemaElement xse, bool bCreatingNewType, System.Xml.Schema.XmlSchema parentSchema);
                /*0x766994c*/ System.Xml.Schema.XmlSchemaSimpleContentExtension CheckSimpleContentExtension(System.Xml.Schema.XmlSchemaComplexType ct);
                /*0x7669084*/ System.Xml.Schema.XmlSchemaType GetEffectiveSchemaType(System.Xml.Schema.XmlSchemaElement elem, bool bCreatingNewType);
                /*0x7669f14*/ System.Xml.Schema.XmlSchemaElement FindMatchingElement(bool bCreatingNewType, System.Xml.XmlReader xtr, System.Xml.Schema.XmlSchemaComplexType ct, ref int lastUsedSeqItem, ref bool bParticleChanged, System.Xml.Schema.XmlSchema parentSchema, bool setMaxoccurs);
                /*0x76691bc*/ void ProcessAttributes(ref System.Xml.Schema.XmlSchemaElement xse, System.Xml.Schema.XmlSchemaType effectiveSchemaType, bool bCreatingNewType, System.Xml.Schema.XmlSchema parentSchema);
                /*0x7669e78*/ void MoveAttributes(System.Xml.Schema.XmlSchemaSimpleContentExtension scExtension, System.Xml.Schema.XmlSchemaComplexType ct);
                /*0x7669a84*/ void MoveAttributes(System.Xml.Schema.XmlSchemaComplexType ct, System.Xml.Schema.XmlSchemaSimpleContentExtension simpleContentExtension, bool bCreatingNewType);
                /*0x7666f48*/ System.Xml.Schema.XmlSchemaAttribute FindAttribute(System.Collections.ICollection attributes, string attrName);
                /*0x7668ce0*/ System.Xml.Schema.XmlSchemaElement FindGlobalElement(string namespaceURI, string localName, ref System.Xml.Schema.XmlSchema parentSchema);
                /*0x766b084*/ System.Xml.Schema.XmlSchemaElement FindElement(System.Xml.Schema.XmlSchemaObjectCollection elements, string elementName);
                /*0x7666b80*/ System.Xml.Schema.XmlSchemaAttribute FindAttributeRef(System.Collections.ICollection attributes, string attributeName, string nsURI);
                /*0x766b1b4*/ System.Xml.Schema.XmlSchemaElement FindElementRef(System.Xml.Schema.XmlSchemaObjectCollection elements, string elementName, string nsURI);
                /*0x76698bc*/ void MakeExistingAttributesOptional(System.Xml.Schema.XmlSchemaComplexType ct, System.Xml.Schema.XmlSchemaObjectCollection attributesInInstance);
                /*0x766b5ec*/ void SwitchUseToOptional(System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaObjectCollection attributesInInstance);
                /*0x76672cc*/ System.Xml.XmlQualifiedName RefineSimpleType(string s, ref int iTypeFlags);
                /*0x766b314*/ System.Xml.Schema.XmlSchemaElement CreateNewElementforChoice(System.Xml.Schema.XmlSchemaElement copyElement);
                /*0x766aef8*/ void SetMinMaxOccurs(System.Xml.Schema.XmlSchemaElement el, bool setMaxOccurs);

                enum InferenceOption
                {
                    Restricted = 0,
                    Relaxed = 1,
                }
            }

            class XmlSchemaInferenceException : System.Xml.Schema.XmlSchemaException
            {
                /*0x766d8b0*/ XmlSchemaInferenceException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x766d8c0*/ XmlSchemaInferenceException();
                /*0x766b538*/ XmlSchemaInferenceException(string res, string arg);
                /*0x76648ac*/ XmlSchemaInferenceException(string res, int lineNumber, int linePosition);
                /*0x766d8b8*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            class NamespaceList
            {
                /*0x10*/ System.Xml.Schema.NamespaceList.ListType type;
                /*0x18*/ System.Collections.Hashtable set;
                /*0x20*/ string targetNamespace;

                static /*0x766e2d0*/ bool IsSubset(System.Xml.Schema.NamespaceList sub, System.Xml.Schema.NamespaceList super);
                static /*0x766e6a8*/ System.Xml.Schema.NamespaceList Union(System.Xml.Schema.NamespaceList o1, System.Xml.Schema.NamespaceList o2, bool v1Compat);
                static /*0x766ed54*/ System.Xml.Schema.NamespaceList Intersection(System.Xml.Schema.NamespaceList o1, System.Xml.Schema.NamespaceList o2, bool v1Compat);
                /*0x766d8cc*/ NamespaceList();
                /*0x766d8d4*/ NamespaceList(string namespaces, string targetNamespace);
                /*0x766db7c*/ System.Xml.Schema.NamespaceList Clone();
                /*0x766dcbc*/ System.Xml.Schema.NamespaceList.ListType get_Type();
                /*0x766dcc4*/ string get_Excluded();
                /*0x766dccc*/ System.Collections.ICollection get_Enumerate();
                /*0x766dd30*/ bool Allows(string ns);
                /*0x766ddb4*/ bool Allows(System.Xml.XmlQualifiedName qname);
                /*0x766ddd4*/ string ToString();
                /*0x766ec34*/ System.Xml.Schema.NamespaceList CompareSetToOther(System.Xml.Schema.NamespaceList other);
                /*0x766f2a0*/ void RemoveNamespace(string tns);

                enum ListType
                {
                    Any = 0,
                    Other = 1,
                    Set = 2,
                }
            }

            class NamespaceListV1Compat : System.Xml.Schema.NamespaceList
            {
                /*0x766f300*/ NamespaceListV1Compat(string namespaces, string targetNamespace);
                /*0x766f304*/ bool Allows(string ns);
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

                /*0x766f328*/ Parser(System.Xml.Schema.SchemaType schemaType, System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler);
                /*0x766f424*/ System.Xml.Schema.SchemaType Parse(System.Xml.XmlReader reader, string targetNamespace);
                /*0x766f474*/ void StartParsing(System.Xml.XmlReader reader, string targetNamespace);
                /*0x766ff54*/ bool CheckSchemaRoot(System.Xml.Schema.SchemaType rootType, ref string code);
                /*0x7670078*/ System.Xml.Schema.SchemaType FinishParsing();
                /*0x7670080*/ System.Xml.Schema.XmlSchema get_XmlSchema();
                /*0x7670088*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x7670090*/ System.Xml.Schema.SchemaInfo get_XdrSchema();
                /*0x766f8ac*/ bool ParseReaderNode();
                /*0x7670098*/ void ProcessAppInfoDocMarkup(bool root);
                /*0x76702cc*/ System.Xml.XmlElement LoadElementNode(bool root);
                /*0x767080c*/ System.Xml.XmlAttribute CreateXmlNsAttribute(string prefix, string value);
                /*0x7670698*/ System.Xml.XmlAttribute LoadAttributeNode();
                /*0x767091c*/ System.Xml.XmlEntityReference LoadEntityReferenceInAttribute();
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

                /*0x7670b04*/ RedefineEntry(System.Xml.Schema.XmlSchemaRedefine external, System.Xml.Schema.XmlSchema schema);
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

                static /*0x7673f80*/ System.Xml.Schema.XmlSchema GetBuildInSchema();
                static /*0x76779cc*/ System.Xml.Schema.XmlSchema GetParentSchema(System.Xml.Schema.XmlSchemaObject currentSchemaObject);
                /*0x7670b48*/ Preprocessor(System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler, System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings);
                /*0x7670c48*/ bool Execute(System.Xml.Schema.XmlSchema schema, string targetNamespace, bool loadExternals);
                /*0x7673eac*/ void Cleanup(System.Xml.Schema.XmlSchema schema);
                /*0x7674580*/ void CleanupRedefine(System.Xml.Schema.XmlSchemaExternal include);
                /*0x7674620*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x7674628*/ void set_ReaderSettings(System.Xml.XmlReaderSettings value);
                /*0x7674630*/ void set_SchemaLocations(System.Collections.Hashtable value);
                /*0x7674638*/ void set_ChameleonSchemas(System.Collections.Hashtable value);
                /*0x7674640*/ System.Xml.Schema.XmlSchema get_RootSchema();
                /*0x7671f30*/ void BuildSchemaList(System.Xml.Schema.XmlSchema schema);
                /*0x767128c*/ void LoadExternals(System.Xml.Schema.XmlSchema schema);
                /*0x76746b0*/ void BuildRefNamespaces(System.Xml.Schema.XmlSchema schema);
                /*0x76748c4*/ void ParseUri(string uri, string code, System.Xml.Schema.XmlSchemaObject sourceSchemaObject);
                /*0x767209c*/ void Preprocess(System.Xml.Schema.XmlSchema schema, string targetNamespace, System.Collections.ArrayList imports);
                /*0x7674ef0*/ void CopyIncludedComponents(System.Xml.Schema.XmlSchema includedSchema, System.Xml.Schema.XmlSchema schema);
                /*0x7673348*/ void PreprocessRedefine(System.Xml.Schema.RedefineEntry redefineEntry);
                /*0x7677a60*/ void GetIncludedSet(System.Xml.Schema.XmlSchema schema, System.Collections.ArrayList includesList);
                /*0x7674de4*/ void SetSchemaDefaults(System.Xml.Schema.XmlSchema schema);
                /*0x76781a4*/ int CountGroupSelfReference(System.Xml.Schema.XmlSchemaObjectCollection items, System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaGroup redefined);
                /*0x7677b8c*/ void CheckRefinedGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x7677c2c*/ void CheckRefinedAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x7678098*/ void CheckRefinedSimpleType(System.Xml.Schema.XmlSchemaSimpleType stype);
                /*0x7677d84*/ void CheckRefinedComplexType(System.Xml.Schema.XmlSchemaComplexType ctype);
                /*0x76761b4*/ void PreprocessAttribute(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x7678984*/ void PreprocessLocalAttribute(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x7678754*/ void PreprocessAttributeContent(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x7676324*/ void PreprocessAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x76772c8*/ void PreprocessElement(System.Xml.Schema.XmlSchemaElement element);
                /*0x767946c*/ void PreprocessLocalElement(System.Xml.Schema.XmlSchemaElement element);
                /*0x7679134*/ void PreprocessElementContent(System.Xml.Schema.XmlSchemaElement element);
                /*0x767980c*/ void PreprocessIdentityConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint constraint);
                /*0x7676cf4*/ void PreprocessSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType, bool local);
                /*0x7676428*/ void PreprocessComplexType(System.Xml.Schema.XmlSchemaComplexType complexType, bool local);
                /*0x767751c*/ void PreprocessGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x76776ec*/ void PreprocessNotation(System.Xml.Schema.XmlSchemaNotation notation);
                /*0x7679b6c*/ void PreprocessParticle(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x7678dac*/ void PreprocessAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute, System.Xml.Schema.XmlSchemaObject parent);
                /*0x7674ad8*/ void ValidateIdAttribute(System.Xml.Schema.XmlSchemaObject xso);
                /*0x7678494*/ void ValidateNameAttribute(System.Xml.Schema.XmlSchemaObject xso);
                /*0x7678b70*/ void ValidateQNameAttribute(System.Xml.Schema.XmlSchemaObject xso, string attributeName, System.Xml.XmlQualifiedName value);
                /*0x7674648*/ System.Uri ResolveSchemaLocationUri(System.Xml.Schema.XmlSchema enclosingSchema, string location);
                /*0x7674688*/ object GetSchemaEntity(System.Uri ruri);
                /*0x767114c*/ System.Xml.Schema.XmlSchema GetChameleonSchema(string targetNamespace, System.Xml.Schema.XmlSchema schema);
                /*0x7674a18*/ void SetParent(System.Xml.Schema.XmlSchemaObject child, System.Xml.Schema.XmlSchemaObject parent);
                /*0x7674a38*/ void PreprocessAnnotation(System.Xml.Schema.XmlSchemaObject schemaObject);
                /*0x7677954*/ void PreprocessAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
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

                static /*0x767a8dc*/ SchemaAttDef();
                /*0x767a460*/ SchemaAttDef(System.Xml.XmlQualifiedName name, string prefix);
                /*0x767a468*/ SchemaAttDef(System.Xml.XmlQualifiedName name);
                /*0x767a474*/ SchemaAttDef();
                /*0x767a47c*/ string System.Xml.IDtdAttributeInfo.get_Prefix();
                /*0x767a484*/ string System.Xml.IDtdAttributeInfo.get_LocalName();
                /*0x767a4a0*/ int System.Xml.IDtdAttributeInfo.get_LineNumber();
                /*0x767a4a8*/ int System.Xml.IDtdAttributeInfo.get_LinePosition();
                /*0x767a4b0*/ bool System.Xml.IDtdAttributeInfo.get_IsNonCDataType();
                /*0x767a4fc*/ bool System.Xml.IDtdAttributeInfo.get_IsDeclaredInExternal();
                /*0x767a504*/ bool System.Xml.IDtdAttributeInfo.get_IsXmlAttribute();
                /*0x767a514*/ string System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueExpanded();
                /*0x767a55c*/ object System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueTyped();
                /*0x767a564*/ int System.Xml.IDtdDefaultAttributeInfo.get_ValueLineNumber();
                /*0x767a56c*/ int System.Xml.IDtdDefaultAttributeInfo.get_ValueLinePosition();
                /*0x767a574*/ int get_LinePosition();
                /*0x767a57c*/ void set_LinePosition(int value);
                /*0x767a584*/ int get_LineNumber();
                /*0x767a58c*/ void set_LineNumber(int value);
                /*0x767a594*/ int get_ValueLinePosition();
                /*0x767a59c*/ void set_ValueLinePosition(int value);
                /*0x767a5a4*/ int get_ValueLineNumber();
                /*0x767a5ac*/ void set_ValueLineNumber(int value);
                /*0x767a538*/ string get_DefaultValueExpanded();
                /*0x767a5b4*/ void set_DefaultValueExpanded(string value);
                /*0x767a4dc*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x767a5bc*/ void set_TokenizedType(System.Xml.XmlTokenizedType value);
                /*0x767a5e4*/ System.Xml.Schema.SchemaAttDef.Reserve get_Reserved();
                /*0x767a5ec*/ void set_Reserved(System.Xml.Schema.SchemaAttDef.Reserve value);
                /*0x767a5f4*/ bool get_DefaultValueChecked();
                /*0x767a5fc*/ System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute();
                /*0x767a604*/ void set_SchemaAttribute(System.Xml.Schema.XmlSchemaAttribute value);
                /*0x767a60c*/ void CheckXmlSpace(System.Xml.IValidationEventHandling validationEventHandling);
                /*0x767a878*/ System.Xml.Schema.SchemaAttDef Clone();

                enum Reserve
                {
                    None = 0,
                    XmlSpace = 1,
                    XmlLang = 2,
                }
            }

            class SchemaBuilder
            {
                /*0x767a944*/ SchemaBuilder();
                bool ProcessElement(string prefix, string name, string ns);
                /*0x380da84*/ void ProcessAttribute(string prefix, string name, string ns, string value);
                /*0x380b128*/ bool IsContentParsed();
                /*0x380d83c*/ void ProcessMarkup(System.Xml.XmlNode[] markup);
                /*0x380d83c*/ void ProcessCData(string value);
                /*0x380cb08*/ void StartChildren();
                /*0x380cb08*/ void EndChildren();
            }

            class SchemaCollectionCompiler : System.Xml.Schema.BaseProcessor
            {
                /*0x40*/ bool compileContentModel;
                /*0x48*/ System.Xml.Schema.XmlSchemaObjectTable examplars;
                /*0x50*/ System.Collections.Stack complexTypeStack;
                /*0x58*/ System.Xml.Schema.XmlSchema schema;

                static /*0x767f418*/ void Cleanup(System.Xml.Schema.XmlSchema schema);
                static /*0x767f3e0*/ void CleanupAttribute(System.Xml.Schema.XmlSchemaAttribute attribute);
                static /*0x767eec8*/ void CleanupAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                static /*0x767ef0c*/ void CleanupComplexType(System.Xml.Schema.XmlSchemaComplexType complexType);
                static /*0x767f244*/ void CleanupSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType);
                static /*0x767f25c*/ void CleanupElement(System.Xml.Schema.XmlSchemaElement element);
                static /*0x7683f6c*/ void CleanupAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes);
                static /*0x767ee9c*/ void CleanupGroup(System.Xml.Schema.XmlSchemaGroup group);
                static /*0x7684030*/ void CleanupParticle(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x767a94c*/ SchemaCollectionCompiler(System.Xml.XmlNameTable nameTable, System.Xml.Schema.ValidationEventHandler eventHandler);
                /*0x767aa14*/ bool Execute(System.Xml.Schema.XmlSchema schema, System.Xml.Schema.SchemaInfo schemaInfo, bool compileContentModel);
                /*0x767aa88*/ void Prepare();
                /*0x767af10*/ void Cleanup();
                /*0x767be0c*/ void Compile();
                /*0x767de64*/ void Output(System.Xml.Schema.SchemaInfo schemaInfo);
                /*0x767fa28*/ void CompileSubstitutionGroup(System.Xml.Schema.XmlSchemaSubstitutionGroupV1Compat substitutionGroup);
                /*0x7683d98*/ void CheckSubstitutionGroup(System.Xml.Schema.XmlSchemaSubstitutionGroup substitutionGroup);
                /*0x767fea8*/ void CompileGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x76813ec*/ void CompileSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType);
                /*0x768452c*/ System.Xml.Schema.XmlSchemaSimpleType[] CompileBaseMemberTypes(System.Xml.Schema.XmlSchemaSimpleType simpleType);
                /*0x76848d0*/ void CheckUnionType(System.Xml.Schema.XmlSchemaSimpleType unionMember, System.Collections.ArrayList memberTypeDefinitions, System.Xml.Schema.XmlSchemaSimpleType parentType);
                /*0x76806e8*/ void CompileComplexType(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x76849e8*/ void CompileSimpleContentExtension(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaSimpleContentExtension simpleExtension);
                /*0x7684c40*/ void CompileSimpleContentRestriction(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaSimpleContentRestriction simpleRestriction);
                /*0x768508c*/ void CompileComplexContentExtension(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaComplexContentExtension complexExtension);
                /*0x7685478*/ void CompileComplexContentRestriction(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaComplexContentRestriction complexRestriction);
                /*0x7683c6c*/ void CheckParticleDerivation(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x7686c9c*/ System.Xml.Schema.XmlSchemaParticle CompileContentTypeParticle(System.Xml.Schema.XmlSchemaParticle particle, bool substitution);
                /*0x7684194*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeParticle(System.Xml.Schema.XmlSchemaParticle particle, bool root, bool substitution);
                /*0x768807c*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeElement(System.Xml.Schema.XmlSchemaElement element, bool substitution);
                /*0x76881cc*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeGroupRef(System.Xml.Schema.XmlSchemaGroupRef groupRef, bool root, bool substitution);
                /*0x7688720*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeAll(System.Xml.Schema.XmlSchemaAll all, bool root, bool substitution);
                /*0x7688bc0*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeChoice(System.Xml.Schema.XmlSchemaChoice choice, bool root, bool substitution);
                /*0x76890c0*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeSequence(System.Xml.Schema.XmlSchemaSequence sequence, bool root, bool substitution);
                /*0x7687ab4*/ bool IsValidRestriction(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle);
                /*0x7689624*/ bool IsElementFromElement(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaElement baseElement);
                /*0x7689738*/ bool IsElementFromAny(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaAny baseAny);
                /*0x7689794*/ bool IsAnyFromAny(System.Xml.Schema.XmlSchemaAny derivedAny, System.Xml.Schema.XmlSchemaAny baseAny);
                /*0x76897e0*/ bool IsGroupBaseFromAny(System.Xml.Schema.XmlSchemaGroupBase derivedGroupBase, System.Xml.Schema.XmlSchemaAny baseAny);
                /*0x76899e8*/ bool IsElementFromGroupBase(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly);
                /*0x7689d50*/ bool IsGroupBaseFromGroupBase(System.Xml.Schema.XmlSchemaGroupBase derivedGroupBase, System.Xml.Schema.XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly);
                /*0x7689fc4*/ bool IsSequenceFromAll(System.Xml.Schema.XmlSchemaSequence derivedSequence, System.Xml.Schema.XmlSchemaAll baseAll);
                /*0x768a2d0*/ bool IsSequenceFromChoice(System.Xml.Schema.XmlSchemaSequence derivedSequence, System.Xml.Schema.XmlSchemaChoice baseChoice);
                /*0x768aec8*/ void CalculateSequenceRange(System.Xml.Schema.XmlSchemaSequence sequence, ref decimal minOccurs, ref decimal maxOccurs);
                /*0x768a4d0*/ bool IsValidOccurrenceRangeRestriction(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle);
                /*0x768acec*/ bool IsValidOccurrenceRangeRestriction(decimal minOccurs, decimal maxOccurs, decimal baseMinOccurs, decimal baseMaxOccurs);
                /*0x768add4*/ int GetMappingParticle(System.Xml.Schema.XmlSchemaParticle particle, System.Xml.Schema.XmlSchemaObjectCollection collection);
                /*0x7689560*/ bool IsParticleEmptiable(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x768a514*/ void CalculateEffectiveTotalRange(System.Xml.Schema.XmlSchemaParticle particle, ref decimal minOccurs, ref decimal maxOccurs);
                /*0x768b284*/ void PushComplexType(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x7686e00*/ System.Xml.Schema.XmlSchemaContentType GetSchemaContentType(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaParticle particle);
                /*0x767ff90*/ void CompileAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x7685768*/ void CompileLocalAttributes(System.Xml.Schema.XmlSchemaComplexType baseType, System.Xml.Schema.XmlSchemaComplexType derivedType, System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute, System.Xml.Schema.XmlSchemaDerivationMethod derivedBy);
                /*0x768b33c*/ System.Xml.Schema.XmlSchemaAnyAttribute CompileAnyAttributeUnion(System.Xml.Schema.XmlSchemaAnyAttribute a, System.Xml.Schema.XmlSchemaAnyAttribute b);
                /*0x768b2a8*/ System.Xml.Schema.XmlSchemaAnyAttribute CompileAnyAttributeIntersection(System.Xml.Schema.XmlSchemaAnyAttribute a, System.Xml.Schema.XmlSchemaAnyAttribute b);
                /*0x7682a4c*/ void CompileAttribute(System.Xml.Schema.XmlSchemaAttribute xa);
                /*0x76834f0*/ void CompileIdentityConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint xi);
                /*0x7681d48*/ void CompileElement(System.Xml.Schema.XmlSchemaElement xe);
                /*0x7686e70*/ System.Xml.Schema.ContentValidator CompileComplexContent(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x768b3d0*/ void BuildParticleContentModel(System.Xml.Schema.ParticleContentValidator contentValidator, System.Xml.Schema.XmlSchemaParticle particle);
                /*0x768b8c4*/ void CompileParticleElements(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaParticle particle);
                /*0x7683b98*/ void CompileCompexTypeElements(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x76843e0*/ System.Xml.Schema.XmlSchemaSimpleType GetSimpleType(System.Xml.XmlQualifiedName name);
                /*0x7687a00*/ System.Xml.Schema.XmlSchemaComplexType GetComplexType(System.Xml.XmlQualifiedName name);
                /*0x768789c*/ System.Xml.Schema.XmlSchemaType GetAnySchemaType(System.Xml.XmlQualifiedName name);
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

                /*0x768bb18*/ SchemaCollectionPreprocessor(System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler);
                /*0x768bb20*/ bool Execute(System.Xml.Schema.XmlSchema schema, string targetNamespace, bool loadExternals, System.Xml.Schema.XmlSchemaCollection xsc);
                /*0x768bd6c*/ void Cleanup(System.Xml.Schema.XmlSchema schema);
                /*0x768f158*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x768bf88*/ void LoadExternals(System.Xml.Schema.XmlSchema schema, System.Xml.Schema.XmlSchemaCollection xsc);
                /*0x768f320*/ void BuildRefNamespaces(System.Xml.Schema.XmlSchema schema);
                /*0x768cbcc*/ void Preprocess(System.Xml.Schema.XmlSchema schema, string targetNamespace, System.Xml.Schema.SchemaCollectionPreprocessor.Compositor compositor);
                /*0x768f630*/ void PreprocessRedefine(System.Xml.Schema.XmlSchemaRedefine redefine);
                /*0x76925dc*/ int CountGroupSelfReference(System.Xml.Schema.XmlSchemaObjectCollection items, System.Xml.XmlQualifiedName name);
                /*0x7691fbc*/ void CheckRefinedGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x7692054*/ void CheckRefinedAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x76924d0*/ void CheckRefinedSimpleType(System.Xml.Schema.XmlSchemaSimpleType stype);
                /*0x76921bc*/ void CheckRefinedComplexType(System.Xml.Schema.XmlSchemaComplexType ctype);
                /*0x76907d4*/ void PreprocessAttribute(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x7692da8*/ void PreprocessLocalAttribute(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x7692b68*/ void PreprocessAttributeContent(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x7690944*/ void PreprocessAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x76918f0*/ void PreprocessElement(System.Xml.Schema.XmlSchemaElement element);
                /*0x7693798*/ void PreprocessLocalElement(System.Xml.Schema.XmlSchemaElement element);
                /*0x7693440*/ void PreprocessElementContent(System.Xml.Schema.XmlSchemaElement element);
                /*0x7693b34*/ void PreprocessIdentityConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint constraint);
                /*0x7691304*/ void PreprocessSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType, bool local);
                /*0x7690a44*/ void PreprocessComplexType(System.Xml.Schema.XmlSchemaComplexType complexType, bool local);
                /*0x7691b44*/ void PreprocessGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x7691d10*/ void PreprocessNotation(System.Xml.Schema.XmlSchemaNotation notation);
                /*0x7693e90*/ void PreprocessParticle(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x7693118*/ void PreprocessAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute, System.Xml.Schema.XmlSchemaObject parent);
                /*0x768c970*/ void ValidateIdAttribute(System.Xml.Schema.XmlSchemaObject xso);
                /*0x76928a8*/ void ValidateNameAttribute(System.Xml.Schema.XmlSchemaObject xso);
                /*0x7692f90*/ void ValidateQNameAttribute(System.Xml.Schema.XmlSchemaObject xso, string attributeName, System.Xml.XmlQualifiedName value);
                /*0x768f524*/ void SetParent(System.Xml.Schema.XmlSchemaObject child, System.Xml.Schema.XmlSchemaObject parent);
                /*0x768f544*/ void PreprocessAnnotation(System.Xml.Schema.XmlSchemaObject schemaObject);
                /*0x768f160*/ System.Uri ResolveSchemaLocationUri(System.Xml.Schema.XmlSchema enclosingSchema, string location);
                /*0x768f20c*/ System.IO.Stream GetSchemaEntity(System.Uri ruri);

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

                /*0x76946f8*/ SchemaDeclBase(System.Xml.XmlQualifiedName name, string prefix);
                /*0x76947a8*/ SchemaDeclBase();
                /*0x7694818*/ System.Xml.XmlQualifiedName get_Name();
                /*0x7694820*/ void set_Name(System.Xml.XmlQualifiedName value);
                /*0x7694828*/ string get_Prefix();
                /*0x769484c*/ void set_Prefix(string value);
                /*0x7694854*/ bool get_IsDeclaredInExternal();
                /*0x769485c*/ void set_IsDeclaredInExternal(bool value);
                /*0x7694868*/ System.Xml.Schema.SchemaDeclBase.Use get_Presence();
                /*0x7694870*/ void set_Presence(System.Xml.Schema.SchemaDeclBase.Use value);
                /*0x7694878*/ long get_MaxLength();
                /*0x7694880*/ void set_MaxLength(long value);
                /*0x7694888*/ long get_MinLength();
                /*0x7694890*/ void set_MinLength(long value);
                /*0x7694898*/ System.Xml.Schema.XmlSchemaType get_SchemaType();
                /*0x76948a0*/ void set_SchemaType(System.Xml.Schema.XmlSchemaType value);
                /*0x76948a8*/ System.Xml.Schema.XmlSchemaDatatype get_Datatype();
                /*0x76948b0*/ void set_Datatype(System.Xml.Schema.XmlSchemaDatatype value);
                /*0x76948b8*/ void AddValue(string value);
                /*0x76949b8*/ System.Collections.Generic.List<string> get_Values();
                /*0x76949c0*/ void set_Values(System.Collections.Generic.List<string> value);
                /*0x76949c8*/ string get_DefaultValueRaw();
                /*0x76949ec*/ void set_DefaultValueRaw(string value);
                /*0x76949f4*/ object get_DefaultValueTyped();
                /*0x76949fc*/ void set_DefaultValueTyped(object value);
                /*0x7694a04*/ bool CheckEnumeration(object pVal);
                /*0x7694abc*/ bool CheckValue(object pVal);

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

                static /*0x7695558*/ SchemaElementDecl();
                static /*0x7694e04*/ System.Xml.Schema.SchemaElementDecl CreateAnyTypeElementDecl();
                /*0x7694b0c*/ SchemaElementDecl();
                /*0x7694be4*/ SchemaElementDecl(System.Xml.Schema.XmlSchemaDatatype dtype);
                /*0x7694d14*/ SchemaElementDecl(System.Xml.XmlQualifiedName name, string prefix);
                /*0x7694ed0*/ bool System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes();
                /*0x7694ed8*/ System.Xml.IDtdAttributeInfo System.Xml.IDtdAttributeListInfo.LookupAttribute(string prefix, string localName);
                /*0x7694f8c*/ System.Collections.Generic.IEnumerable<System.Xml.IDtdDefaultAttributeInfo> System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes();
                /*0x7694f94*/ bool get_IsIdDeclared();
                /*0x7694f9c*/ void set_IsIdDeclared(bool value);
                /*0x7694fa8*/ bool get_HasNonCDataAttribute();
                /*0x7694fb0*/ void set_HasNonCDataAttribute(bool value);
                /*0x7694fbc*/ System.Xml.Schema.SchemaElementDecl Clone();
                /*0x7695020*/ bool get_IsAbstract();
                /*0x7695028*/ void set_IsAbstract(bool value);
                /*0x7695034*/ bool get_IsNillable();
                /*0x769503c*/ void set_IsNillable(bool value);
                /*0x7695048*/ System.Xml.Schema.XmlSchemaDerivationMethod get_Block();
                /*0x7695050*/ void set_Block(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x7695058*/ bool get_IsNotationDeclared();
                /*0x7695060*/ void set_IsNotationDeclared(bool value);
                /*0x769506c*/ bool get_HasDefaultAttribute();
                /*0x769507c*/ bool get_HasRequiredAttribute();
                /*0x7695084*/ System.Xml.Schema.ContentValidator get_ContentValidator();
                /*0x769508c*/ void set_ContentValidator(System.Xml.Schema.ContentValidator value);
                /*0x7695094*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0x769509c*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x76950a4*/ System.Xml.Schema.CompiledIdentityConstraint[] get_Constraints();
                /*0x76950ac*/ void set_Constraints(System.Xml.Schema.CompiledIdentityConstraint[] value);
                /*0x76950b4*/ System.Xml.Schema.XmlSchemaElement get_SchemaElement();
                /*0x76950bc*/ void set_SchemaElement(System.Xml.Schema.XmlSchemaElement value);
                /*0x76950c4*/ void AddAttDef(System.Xml.Schema.SchemaAttDef attdef);
                /*0x7695234*/ System.Xml.Schema.SchemaAttDef GetAttDef(System.Xml.XmlQualifiedName qname);
                /*0x76952ac*/ System.Collections.Generic.IList<System.Xml.IDtdDefaultAttributeInfo> get_DefaultAttDefs();
                /*0x76952b4*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaAttDef> get_AttDefs();
                /*0x76952bc*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.XmlQualifiedName> get_ProhibitedAttributes();
                /*0x76952c4*/ void CheckAttributes(System.Collections.Hashtable presence, bool standalone);
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

                static /*0x769576c*/ bool IsPredefinedEntity(string n);
                /*0x76955bc*/ SchemaEntity(System.Xml.XmlQualifiedName qname, bool isParameter);
                /*0x7695658*/ string System.Xml.IDtdEntityInfo.get_Name();
                /*0x7695674*/ bool System.Xml.IDtdEntityInfo.get_IsExternal();
                /*0x769567c*/ bool System.Xml.IDtdEntityInfo.get_IsDeclaredInExternal();
                /*0x7695684*/ bool System.Xml.IDtdEntityInfo.get_IsUnparsedEntity();
                /*0x76956ac*/ bool System.Xml.IDtdEntityInfo.get_IsParameterEntity();
                /*0x76956b4*/ string System.Xml.IDtdEntityInfo.get_BaseUriString();
                /*0x76956fc*/ string System.Xml.IDtdEntityInfo.get_DeclaredUriString();
                /*0x7695744*/ string System.Xml.IDtdEntityInfo.get_SystemId();
                /*0x769574c*/ string System.Xml.IDtdEntityInfo.get_PublicId();
                /*0x7695754*/ string System.Xml.IDtdEntityInfo.get_Text();
                /*0x769575c*/ int System.Xml.IDtdEntityInfo.get_LineNumber();
                /*0x7695764*/ int System.Xml.IDtdEntityInfo.get_LinePosition();
                /*0x7695868*/ System.Xml.XmlQualifiedName get_Name();
                /*0x7695870*/ string get_Url();
                /*0x7695878*/ void set_Url(string value);
                /*0x769589c*/ string get_Pubid();
                /*0x76958a4*/ void set_Pubid(string value);
                /*0x76958ac*/ bool get_IsExternal();
                /*0x76958b4*/ void set_IsExternal(bool value);
                /*0x76958c0*/ bool get_DeclaredInExternal();
                /*0x76958c8*/ void set_DeclaredInExternal(bool value);
                /*0x76958d4*/ System.Xml.XmlQualifiedName get_NData();
                /*0x76958dc*/ void set_NData(System.Xml.XmlQualifiedName value);
                /*0x76958e4*/ string get_Text();
                /*0x76958ec*/ void set_Text(string value);
                /*0x769590c*/ int get_Line();
                /*0x7695914*/ void set_Line(int value);
                /*0x769591c*/ int get_Pos();
                /*0x7695924*/ void set_Pos(int value);
                /*0x76956d8*/ string get_BaseURI();
                /*0x769592c*/ void set_BaseURI(string value);
                /*0x7695934*/ bool get_ParsingInProgress();
                /*0x769593c*/ void set_ParsingInProgress(bool value);
                /*0x7695720*/ string get_DeclaredURI();
                /*0x7695948*/ void set_DeclaredURI(string value);
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

                /*0x7695950*/ SchemaInfo();
                /*0x7695b2c*/ System.Xml.XmlQualifiedName get_DocTypeName();
                /*0x7695b34*/ void set_DocTypeName(System.Xml.XmlQualifiedName value);
                /*0x7695b3c*/ void set_InternalDtdSubset(string value);
                /*0x7695b44*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaElementDecl> get_ElementDecls();
                /*0x7695b4c*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaElementDecl> get_UndeclaredElementDecls();
                /*0x7695b54*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaEntity> get_GeneralEntities();
                /*0x7695bd8*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaEntity> get_ParameterEntities();
                /*0x7695c5c*/ System.Xml.Schema.SchemaType get_SchemaType();
                /*0x7695c64*/ void set_SchemaType(System.Xml.Schema.SchemaType value);
                /*0x7695c6c*/ System.Collections.Generic.Dictionary<string, bool> get_TargetNamespaces();
                /*0x7695c74*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaElementDecl> get_ElementDeclsByType();
                /*0x7695c7c*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaAttDef> get_AttributeDecls();
                /*0x7695c84*/ System.Collections.Generic.Dictionary<string, System.Xml.Schema.SchemaNotation> get_Notations();
                /*0x7695d08*/ int get_ErrorCount();
                /*0x7695d10*/ void set_ErrorCount(int value);
                /*0x7695d18*/ System.Xml.Schema.SchemaElementDecl GetElementDecl(System.Xml.XmlQualifiedName qname);
                /*0x7695d90*/ System.Xml.Schema.SchemaElementDecl GetTypeDecl(System.Xml.XmlQualifiedName qname);
                /*0x7695e08*/ System.Xml.Schema.XmlSchemaElement GetElement(System.Xml.XmlQualifiedName qname);
                /*0x7695e20*/ bool HasSchema(string ns);
                /*0x7695e78*/ bool Contains(string ns);
                /*0x7695ed0*/ System.Xml.Schema.SchemaAttDef GetAttributeXdr(System.Xml.Schema.SchemaElementDecl ed, System.Xml.XmlQualifiedName qname);
                /*0x769601c*/ System.Xml.Schema.SchemaAttDef GetAttributeXsd(System.Xml.Schema.SchemaElementDecl ed, System.Xml.XmlQualifiedName qname, System.Xml.Schema.XmlSchemaObject partialValidationType, ref System.Xml.Schema.AttributeMatchState attributeMatchState);
                /*0x769623c*/ System.Xml.Schema.SchemaAttDef GetAttributeXsd(System.Xml.Schema.SchemaElementDecl ed, System.Xml.XmlQualifiedName qname, ref bool skip);
                /*0x7696334*/ void Add(System.Xml.Schema.SchemaInfo sinfo, System.Xml.Schema.ValidationEventHandler eventhandler);
                /*0x7696c00*/ void Finish();
                /*0x7696db4*/ bool System.Xml.IDtdInfo.get_HasDefaultAttributes();
                /*0x7696dbc*/ bool System.Xml.IDtdInfo.get_HasNonCDataAttributes();
                /*0x7696dc4*/ System.Xml.IDtdAttributeListInfo System.Xml.IDtdInfo.LookupAttributeList(string prefix, string localName);
                /*0x7696e8c*/ System.Xml.IDtdEntityInfo System.Xml.IDtdInfo.LookupEntity(string name);
                /*0x7696f40*/ System.Xml.XmlQualifiedName System.Xml.IDtdInfo.get_Name();
                /*0x7696f48*/ string System.Xml.IDtdInfo.get_InternalDtdSubset();
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

                /*0x7696f50*/ SchemaNames(System.Xml.XmlNameTable nameTable);
                /*0x7699f18*/ void CreateTokenToQNameTable();
                /*0x769be44*/ System.Xml.Schema.SchemaType SchemaTypeFromRoot(string localName, string ns);
                /*0x769bea4*/ bool IsXSDRoot(string localName, string ns);
                /*0x769bef4*/ bool IsXDRRoot(string localName, string ns);

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

                /*0x769bf44*/ SchemaNamespaceManager(System.Xml.Schema.XmlSchemaObject node);
                /*0x769bf74*/ string LookupNamespace(string prefix);
                /*0x769c098*/ string LookupPrefix(string ns);
            }

            class SchemaNotation
            {
                /*0x10*/ System.Xml.XmlQualifiedName name;
                /*0x18*/ string systemLiteral;
                /*0x20*/ string pubid;

                /*0x769c488*/ SchemaNotation(System.Xml.XmlQualifiedName name);
                /*0x769c4b8*/ System.Xml.XmlQualifiedName get_Name();
                /*0x769c4c0*/ string get_SystemLiteral();
                /*0x769c4c8*/ void set_SystemLiteral(string value);
                /*0x769c4d0*/ string get_Pubid();
                /*0x769c4d8*/ void set_Pubid(string value);
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

                /*0x769c4e0*/ Compiler(System.Xml.XmlNameTable nameTable, System.Xml.Schema.ValidationEventHandler eventHandler, System.Xml.Schema.XmlSchema schemaForSchema, System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings);
                /*0x769c724*/ bool Execute(System.Xml.Schema.XmlSchemaSet schemaSet, System.Xml.Schema.SchemaInfo schemaCompiledInfo);
                /*0x769f8bc*/ void Prepare(System.Xml.Schema.XmlSchema schema, bool cleanup);
                /*0x76a1710*/ void UpdateSForSSimpleTypes();
                /*0x769e7cc*/ void Output(System.Xml.Schema.SchemaInfo schemaInfo);
                /*0x76a1860*/ void ImportAllCompiledSchemas(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x769c7c0*/ bool Compile();
                /*0x76a1150*/ void CleanupAttribute(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x76a11c8*/ void CleanupAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x76a1228*/ void CleanupComplexType(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x76a165c*/ void CleanupSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType);
                /*0x76a0fb8*/ void CleanupElement(System.Xml.Schema.XmlSchemaElement element);
                /*0x76a6588*/ void CleanupAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes);
                /*0x76a1180*/ void CleanupGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x76a6660*/ void CleanupParticle(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x76a55b4*/ void ProcessSubstitutionGroups();
                /*0x76a67fc*/ void CompileSubstitutionGroup(System.Xml.Schema.XmlSchemaSubstitutionGroup substitutionGroup);
                /*0x76a6434*/ void RecursivelyCheckRedefinedGroups(System.Xml.Schema.XmlSchemaGroup redefinedGroup, System.Xml.Schema.XmlSchemaGroup baseGroup);
                /*0x76a6510*/ void RecursivelyCheckRedefinedAttributeGroups(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup, System.Xml.Schema.XmlSchemaAttributeGroup baseAttributeGroup);
                /*0x76a1968*/ void CompileGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x76a2dbc*/ void CompileSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType);
                /*0x76a7c0c*/ System.Xml.Schema.XmlSchemaSimpleType[] CompileBaseMemberTypes(System.Xml.Schema.XmlSchemaSimpleType simpleType);
                /*0x76a7fb0*/ void CheckUnionType(System.Xml.Schema.XmlSchemaSimpleType unionMember, System.Collections.ArrayList memberTypeDefinitions, System.Xml.Schema.XmlSchemaSimpleType parentType);
                /*0x76a22dc*/ void CompileComplexType(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x76a80c8*/ void CompileSimpleContentExtension(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaSimpleContentExtension simpleExtension);
                /*0x76a8320*/ void CompileSimpleContentRestriction(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaSimpleContentRestriction simpleRestriction);
                /*0x76a876c*/ void CompileComplexContentExtension(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaComplexContentExtension complexExtension);
                /*0x76a8b0c*/ void CompileComplexContentRestriction(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaComplexContentRestriction complexRestriction);
                /*0x76a5e30*/ void CheckParticleDerivation(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x76a70a8*/ void CheckParticleDerivation(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle);
                /*0x76aa390*/ System.Xml.Schema.XmlSchemaParticle CompileContentTypeParticle(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x76a6d04*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeParticle(System.Xml.Schema.XmlSchemaParticle particle, bool root);
                /*0x76acfe8*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeElement(System.Xml.Schema.XmlSchemaElement element);
                /*0x76abe9c*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeGroupRef(System.Xml.Schema.XmlSchemaGroupRef groupRef, bool root);
                /*0x76ac3bc*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeAll(System.Xml.Schema.XmlSchemaAll all, bool root);
                /*0x76ac640*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeChoice(System.Xml.Schema.XmlSchemaChoice choice, bool root);
                /*0x76acb34*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeSequence(System.Xml.Schema.XmlSchemaSequence sequence, bool root);
                /*0x76ab1a8*/ System.Xml.Schema.XmlSchemaParticle CannonicalizePointlessRoot(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x76ab40c*/ bool IsValidRestriction(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle);
                /*0x76ad324*/ bool IsElementFromElement(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaElement baseElement);
                /*0x76ad530*/ bool IsElementFromAny(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaAny baseAny);
                /*0x76ad6e4*/ bool IsAnyFromAny(System.Xml.Schema.XmlSchemaAny derivedAny, System.Xml.Schema.XmlSchemaAny baseAny);
                /*0x76ad7e4*/ bool IsGroupBaseFromAny(System.Xml.Schema.XmlSchemaGroupBase derivedGroupBase, System.Xml.Schema.XmlSchemaAny baseAny);
                /*0x76adbec*/ bool IsElementFromGroupBase(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaGroupBase baseGroupBase);
                /*0x76aeaac*/ bool IsChoiceFromChoiceSubstGroup(System.Xml.Schema.XmlSchemaChoice derivedChoice, System.Xml.Schema.XmlSchemaChoice baseChoice);
                /*0x76ae4b0*/ bool IsGroupBaseFromGroupBase(System.Xml.Schema.XmlSchemaGroupBase derivedGroupBase, System.Xml.Schema.XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly);
                /*0x76ae7a0*/ bool IsSequenceFromAll(System.Xml.Schema.XmlSchemaSequence derivedSequence, System.Xml.Schema.XmlSchemaAll baseAll);
                /*0x76aec40*/ bool IsSequenceFromChoice(System.Xml.Schema.XmlSchemaSequence derivedSequence, System.Xml.Schema.XmlSchemaChoice baseChoice);
                /*0x76aef84*/ bool IsValidOccurrenceRangeRestriction(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle);
                /*0x76af8e8*/ bool IsValidOccurrenceRangeRestriction(decimal minOccurs, decimal maxOccurs, decimal baseMinOccurs, decimal baseMaxOccurs);
                /*0x76af9d0*/ int GetMappingParticle(System.Xml.Schema.XmlSchemaParticle particle, System.Xml.Schema.XmlSchemaObjectCollection collection);
                /*0x76ad260*/ bool IsParticleEmptiable(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x76af124*/ void CalculateEffectiveTotalRange(System.Xml.Schema.XmlSchemaParticle particle, ref decimal minOccurs, ref decimal maxOccurs);
                /*0x76afac4*/ void PushComplexType(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x76aa4ec*/ System.Xml.Schema.XmlSchemaContentType GetSchemaContentType(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaParticle particle);
                /*0x76a1a4c*/ void CompileAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x76a8dd4*/ void CompileLocalAttributes(System.Xml.Schema.XmlSchemaComplexType baseType, System.Xml.Schema.XmlSchemaComplexType derivedType, System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute, System.Xml.Schema.XmlSchemaDerivationMethod derivedBy);
                /*0x76a718c*/ void CheckAtrributeGroupRestriction(System.Xml.Schema.XmlSchemaAttributeGroup baseAttributeGroup, System.Xml.Schema.XmlSchemaAttributeGroup derivedAttributeGroup);
                /*0x76afc10*/ bool IsProcessContentsRestricted(System.Xml.Schema.XmlSchemaComplexType baseType, System.Xml.Schema.XmlSchemaAnyAttribute derivedAttributeWildcard, System.Xml.Schema.XmlSchemaAnyAttribute baseAttributeWildcard);
                /*0x76afb7c*/ System.Xml.Schema.XmlSchemaAnyAttribute CompileAnyAttributeUnion(System.Xml.Schema.XmlSchemaAnyAttribute a, System.Xml.Schema.XmlSchemaAnyAttribute b);
                /*0x76afae8*/ System.Xml.Schema.XmlSchemaAnyAttribute CompileAnyAttributeIntersection(System.Xml.Schema.XmlSchemaAnyAttribute a, System.Xml.Schema.XmlSchemaAnyAttribute b);
                /*0x76a4568*/ void CompileAttribute(System.Xml.Schema.XmlSchemaAttribute xa);
                /*0x76afcec*/ void SetDefaultFixed(System.Xml.Schema.XmlSchemaAttribute xa, System.Xml.Schema.SchemaAttDef decl);
                /*0x76a4df4*/ void CompileIdentityConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint xi);
                /*0x76a3750*/ void CompileElement(System.Xml.Schema.XmlSchemaElement xe);
                /*0x76aa55c*/ System.Xml.Schema.ContentValidator CompileComplexContent(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x76afeac*/ bool BuildParticleContentModel(System.Xml.Schema.ParticleContentValidator contentValidator, System.Xml.Schema.XmlSchemaParticle particle);
                /*0x76b03ac*/ void CompileParticleElements(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaParticle particle);
                /*0x76a6f20*/ void CompileParticleElements(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x76a5498*/ void CompileComplexTypeElements(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x76a7b34*/ System.Xml.Schema.XmlSchemaSimpleType GetSimpleType(System.Xml.XmlQualifiedName name);
                /*0x76ab100*/ System.Xml.Schema.XmlSchemaComplexType GetComplexType(System.Xml.XmlQualifiedName name);
                /*0x76aafa8*/ System.Xml.Schema.XmlSchemaType GetAnySchemaType(System.Xml.XmlQualifiedName name);
                /*0x76ad1ec*/ void CopyPosition(System.Xml.Schema.XmlSchemaAnnotated to, System.Xml.Schema.XmlSchemaAnnotated from, bool copyParent);
                /*0x76aefc8*/ bool IsFixedEqual(System.Xml.Schema.SchemaDeclBase baseDecl, System.Xml.Schema.SchemaDeclBase derivedDecl);
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

                /*0x76b0600*/ ValidationEventArgs(System.Xml.Schema.XmlSchemaException ex);
                /*0x76b067c*/ ValidationEventArgs(System.Xml.Schema.XmlSchemaException ex, System.Xml.Schema.XmlSeverityType severity);
                /*0x76b06fc*/ System.Xml.Schema.XmlSeverityType get_Severity();
                /*0x76b0704*/ System.Xml.Schema.XmlSchemaException get_Exception();
            }

            class ValidationEventHandler : System.MulticastDelegate
            {
                /*0x76b070c*/ ValidationEventHandler(object object, nint method);
                /*0x76b0818*/ void Invoke(object sender, System.Xml.Schema.ValidationEventArgs e);
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

                /*0x76b082c*/ ValidationState();
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

                static /*0x76b64b0*/ XdrBuilder();
                static /*0x76b154c*/ bool IsXdrSchema(string uri);
                static /*0x76b2024*/ void XDR_InitRoot(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x76b2084*/ void XDR_BuildRoot_Name(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76b20fc*/ void XDR_BuildRoot_ID(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76b2100*/ void XDR_BeginRoot(System.Xml.Schema.XdrBuilder builder);
                static /*0x76b21dc*/ void XDR_EndRoot(System.Xml.Schema.XdrBuilder builder);
                static /*0x76b275c*/ void XDR_InitElementType(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x76b2888*/ void XDR_BuildElementType_Name(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76b2a54*/ void XDR_BuildElementType_Content(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76b2c78*/ void XDR_BuildElementType_Model(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76b2df4*/ void XDR_BuildElementType_Order(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76b2fc4*/ void XDR_BuildElementType_DtType(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76b3144*/ void XDR_BuildElementType_DtValues(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76b3228*/ void XDR_BuildElementType_DtMaxLength(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76b33d0*/ void XDR_BuildElementType_DtMinLength(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76b3578*/ void XDR_BeginElementType(System.Xml.Schema.XdrBuilder builder);
                static /*0x76b387c*/ void XDR_EndElementType(System.Xml.Schema.XdrBuilder builder);
                static /*0x76b3d10*/ void XDR_InitAttributeType(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x76b3e1c*/ void XDR_BuildAttributeType_Name(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76b4074*/ void XDR_BuildAttributeType_Required(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76b4200*/ void XDR_BuildAttributeType_Default(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76b4220*/ void XDR_BuildAttributeType_DtType(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76b441c*/ void XDR_BuildAttributeType_DtValues(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76b4500*/ void XDR_BuildAttributeType_DtMaxLength(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76b4570*/ void XDR_BuildAttributeType_DtMinLength(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76b45e0*/ void XDR_BeginAttributeType(System.Xml.Schema.XdrBuilder builder);
                static /*0x76b466c*/ void XDR_EndAttributeType(System.Xml.Schema.XdrBuilder builder);
                static /*0x76b4a00*/ void XDR_InitElement(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x76b4aa0*/ void XDR_BuildElement_Type(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76b4ce0*/ void XDR_BuildElement_MinOccurs(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76b4e44*/ void XDR_BuildElement_MaxOccurs(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76b4fe0*/ void XDR_EndElement(System.Xml.Schema.XdrBuilder builder);
                static /*0x76b50c8*/ void XDR_InitAttribute(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x76b516c*/ void XDR_BuildAttribute_Type(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76b5244*/ void XDR_BuildAttribute_Required(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76b52c8*/ void XDR_BuildAttribute_Default(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76b52e8*/ void XDR_BeginAttribute(System.Xml.Schema.XdrBuilder builder);
                static /*0x76b55fc*/ void XDR_EndAttribute(System.Xml.Schema.XdrBuilder builder);
                static /*0x76b5710*/ void XDR_InitGroup(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x76b57dc*/ void XDR_BuildGroup_Order(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76b58dc*/ void XDR_BuildGroup_MinOccurs(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76b5960*/ void XDR_BuildGroup_MaxOccurs(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x76b59e4*/ void XDR_EndGroup(System.Xml.Schema.XdrBuilder builder);
                static /*0x76b5b3c*/ void XDR_InitElementDtType(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x76b5c00*/ void XDR_EndElementDtType(System.Xml.Schema.XdrBuilder builder);
                static /*0x76b5ce4*/ void XDR_InitAttributeDtType(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x76b5d64*/ void XDR_EndAttributeDtType(System.Xml.Schema.XdrBuilder builder);
                static /*0x76b40ec*/ bool IsYes(object obj, System.Xml.Schema.XdrBuilder builder);
                static /*0x76b4d54*/ uint ParseMinOccurs(object obj, System.Xml.Schema.XdrBuilder builder);
                static /*0x76b4eb8*/ uint ParseMaxOccurs(object obj, System.Xml.Schema.XdrBuilder builder);
                static /*0x76b5098*/ void HandleMinMax(System.Xml.Schema.ParticleContentValidator pContent, uint cMin, uint cMax);
                static /*0x76b3298*/ void ParseDtMaxLength(ref uint cVal, object obj, System.Xml.Schema.XdrBuilder builder);
                static /*0x76b3440*/ void ParseDtMinLength(ref uint cVal, object obj, System.Xml.Schema.XdrBuilder builder);
                static /*0x76b3c7c*/ void CompareMinMaxLength(uint cMin, uint cMax, System.Xml.Schema.XdrBuilder builder);
                static /*0x76b5e58*/ bool ParseInteger(string str, ref uint n);
                /*0x76b0890*/ XdrBuilder(System.Xml.XmlReader reader, System.Xml.XmlNamespaceManager curmgr, System.Xml.Schema.SchemaInfo sinfo, string targetNamspace, System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventhandler);
                /*0x76b0b54*/ bool ProcessElement(string prefix, string name, string ns);
                /*0x76b11d4*/ void ProcessAttribute(string prefix, string name, string ns, string value);
                /*0x76b1bf8*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x76b1604*/ bool LoadSchema(string uri);
                /*0x76b1d00*/ bool IsContentParsed();
                /*0x76b1d08*/ void ProcessMarkup(System.Xml.XmlNode[] markup);
                /*0x76b1d60*/ void ProcessCData(string value);
                /*0x76b1ddc*/ void StartChildren();
                /*0x76b1e14*/ void EndChildren();
                /*0x76b0fe4*/ void Push();
                /*0x76b1e50*/ void Pop();
                /*0x76b1ee0*/ void PushGroupInfo();
                /*0x76b1f94*/ void PopGroupInfo();
                /*0x76b0e40*/ bool GetNextState(System.Xml.XmlQualifiedName qname);
                /*0x76b1030*/ bool IsSkipableElement(System.Xml.XmlQualifiedName qname);
                /*0x76b1ac0*/ bool IsSkipableAttribute(System.Xml.XmlQualifiedName qname);
                /*0x76b2ea0*/ int GetOrder(System.Xml.XmlQualifiedName qname);
                /*0x76b4c24*/ void AddOrder();
                /*0x76b26bc*/ void XDR_CheckAttributeDefault(System.Xml.Schema.XdrBuilder.DeclBaseInfo decl, System.Xml.Schema.SchemaAttDef pAttdef);
                /*0x76b49b0*/ void SetAttributePresence(System.Xml.Schema.SchemaAttDef pAttdef, bool fRequired);
                /*0x76b2af0*/ int GetContent(System.Xml.XmlQualifiedName qname);
                /*0x76b2d18*/ bool GetModel(System.Xml.XmlQualifiedName qname);
                /*0x76b42d8*/ System.Xml.Schema.XmlSchemaDatatype CheckDatatype(string str);
                /*0x76b48c0*/ void CheckDefaultAttValue(System.Xml.Schema.SchemaAttDef attDef);
                /*0x76b1540*/ bool IsGlobal(int flags);
                /*0x76b1c00*/ void SendValidationEvent(string code, string[] args, System.Xml.Schema.XmlSeverityType severity);
                /*0x76b30d4*/ void SendValidationEvent(string code);
                /*0x76b10f0*/ void SendValidationEvent(string code, string msg);
                /*0x76b631c*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity);

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

                    /*0x76b5150*/ DeclBaseInfo();
                    /*0x76b5618*/ void Reset();
                }

                class GroupContent
                {
                    /*0x10*/ uint _MinVal;
                    /*0x14*/ uint _MaxVal;
                    /*0x18*/ bool _HasMaxAttr;
                    /*0x19*/ bool _HasMinAttr;
                    /*0x1c*/ int _Order;

                    static /*0x76b80f0*/ void Copy(System.Xml.Schema.XdrBuilder.GroupContent from, System.Xml.Schema.XdrBuilder.GroupContent to);
                    static /*0x76b1f30*/ System.Xml.Schema.XdrBuilder.GroupContent Copy(System.Xml.Schema.XdrBuilder.GroupContent other);
                    /*0x76b0b4c*/ GroupContent();
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

                    /*0x76b0b3c*/ ElementContent();
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

                    /*0x76b0b44*/ AttributeContent();
                }

                class XdrBuildFunction : System.MulticastDelegate
                {
                    /*0x76b7cb8*/ XdrBuildFunction(object object, nint method);
                    /*0x76b8118*/ void Invoke(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                }

                class XdrInitFunction : System.MulticastDelegate
                {
                    /*0x76b7edc*/ XdrInitFunction(object object, nint method);
                    /*0x76b812c*/ void Invoke(System.Xml.Schema.XdrBuilder builder, object obj);
                }

                class XdrBeginChildFunction : System.MulticastDelegate
                {
                    /*0x76b7f90*/ XdrBeginChildFunction(object object, nint method);
                    /*0x76b8140*/ void Invoke(System.Xml.Schema.XdrBuilder builder);
                }

                class XdrEndChildFunction : System.MulticastDelegate
                {
                    /*0x76b8040*/ XdrEndChildFunction(object object, nint method);
                    /*0x76b8154*/ void Invoke(System.Xml.Schema.XdrBuilder builder);
                }

                class XdrAttributeEntry
                {
                    /*0x10*/ System.Xml.Schema.SchemaNames.Token _Attribute;
                    /*0x14*/ int _SchemaFlags;
                    /*0x18*/ System.Xml.Schema.XmlSchemaDatatype _Datatype;
                    /*0x20*/ System.Xml.Schema.XdrBuilder.XdrBuildFunction _BuildFunc;

                    /*0x76b7d6c*/ XdrAttributeEntry(System.Xml.Schema.SchemaNames.Token a, System.Xml.XmlTokenizedType ttype, System.Xml.Schema.XdrBuilder.XdrBuildFunction build);
                    /*0x76b7dcc*/ XdrAttributeEntry(System.Xml.Schema.SchemaNames.Token a, System.Xml.XmlTokenizedType ttype, int schemaFlags, System.Xml.Schema.XdrBuilder.XdrBuildFunction build);
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

                    /*0x76b7e30*/ XdrEntry(System.Xml.Schema.SchemaNames.Token n, int[] states, System.Xml.Schema.XdrBuilder.XdrAttributeEntry[] attributes, System.Xml.Schema.XdrBuilder.XdrInitFunction init, System.Xml.Schema.XdrBuilder.XdrBeginChildFunction begin, System.Xml.Schema.XdrBuilder.XdrEndChildFunction end, bool fText);
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

                static /*0x76b5e90*/ void CheckDefaultValue(string value, System.Xml.Schema.SchemaAttDef attdef, System.Xml.Schema.SchemaInfo sinfo, System.Xml.XmlNamespaceManager nsManager, System.Xml.XmlNameTable NameTable, object sender, System.Xml.Schema.ValidationEventHandler eventhandler, string baseUri, int lineNo, int linePos);
                /*0x76b8168*/ XdrValidator(System.Xml.Schema.BaseValidator validator);
                /*0x76b83e4*/ XdrValidator(System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling);
                /*0x76b81f0*/ void Init();
                /*0x76b85a8*/ void Validate();
                /*0x76b8898*/ void ValidateElement();
                /*0x76b8bf4*/ void ValidateChildElement();
                /*0x76b8660*/ bool get_IsInlineSchemaStarted();
                /*0x76b8670*/ void ProcessInlineSchema();
                /*0x76b8d3c*/ void ProcessElement();
                /*0x76b8a38*/ void ValidateEndElement();
                /*0x76b8dfc*/ System.Xml.Schema.SchemaElementDecl ThoroughGetElementDecl();
                /*0x76b911c*/ void ValidateStartElement();
                /*0x76b9514*/ void ValidateEndStartElement();
                /*0x76ba16c*/ void LoadSchemaFromLocation(string uri);
                /*0x76b9f14*/ void LoadSchema(string uri);
                /*0x76ba7e4*/ bool get_HasSchema();
                /*0x76ba808*/ bool get_PreserveWhitespace();
                /*0x76ba840*/ void ProcessTokenizedType(System.Xml.XmlTokenizedType ttype, string name);
                /*0x76bab00*/ void CompleteValidation();
                /*0x76b987c*/ void CheckValue(string value, System.Xml.Schema.SchemaAttDef attdef);
                /*0x76baa64*/ void AddID(string name, object node);
                /*0x76bad84*/ object FindId(string name);
                /*0x76b8484*/ void Push(System.Xml.XmlQualifiedName elementName);
                /*0x76b9e5c*/ void Pop();
                /*0x76babb4*/ void CheckForwardRefs();
                /*0x76ba0a4*/ System.Xml.XmlQualifiedName QualifiedName(string name, string ns);
            }

            class XmlAtomicValue : System.Xml.XPath.XPathItem, System.ICloneable
            {
                /*0x10*/ System.Xml.Schema.XmlSchemaType xmlType;
                /*0x18*/ object objVal;
                /*0x20*/ System.TypeCode clrType;
                /*0x28*/ System.Xml.Schema.XmlAtomicValue.Union unionVal;
                /*0x30*/ System.Xml.Schema.XmlAtomicValue.NamespacePrefixForQName nsPrefix;

                /*0x76bada0*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, bool value);
                /*0x76bae34*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, System.DateTime value);
                /*0x76baec4*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, double value);
                /*0x76baf5c*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, int value);
                /*0x76bafec*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, long value);
                /*0x76bb07c*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, string value);
                /*0x76bb130*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, string value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76bb41c*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, object value);
                /*0x76bb4d0*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76bb6fc*/ object System.ICloneable.Clone();
                /*0x76bb700*/ System.Xml.Schema.XmlSchemaType get_XmlType();
                /*0x76bb708*/ System.Type get_ValueType();
                /*0x76bb730*/ object get_TypedValue();
                /*0x76bb8f8*/ bool get_ValueAsBoolean();
                /*0x76bb9c8*/ System.DateTime get_ValueAsDateTime();
                /*0x76bbaac*/ double get_ValueAsDouble();
                /*0x76bbb8c*/ int get_ValueAsInt();
                /*0x76bbc64*/ long get_ValueAsLong();
                /*0x76bbd48*/ object ValueAs(System.Type type, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76bbf70*/ string get_Value();
                /*0x76bc068*/ string ToString();
                /*0x76bb318*/ string GetPrefixFromQName(string value);

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

                    /*0x76bb3d8*/ NamespacePrefixForQName(string prefix, string ns);
                    /*0x76bc074*/ string LookupNamespace(string prefix);
                    /*0x76bc0a8*/ string LookupPrefix(string namespaceName);
                    /*0x76bc0d4*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
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

                static /*0x76bde60*/ XmlSchema();
                static /*0x76bc354*/ System.Xml.Schema.XmlSchema Read(System.Xml.XmlReader reader, System.Xml.Schema.ValidationEventHandler validationEventHandler);
                /*0x76bc178*/ XmlSchema();
                /*0x76bc508*/ bool CompileSchema(System.Xml.Schema.XmlSchemaCollection xsc, System.Xml.XmlResolver resolver, System.Xml.Schema.SchemaInfo schemaInfo, string ns, System.Xml.Schema.ValidationEventHandler validationEventHandler, System.Xml.XmlNameTable nameTable, bool CompileContentModel);
                /*0x76bc6f0*/ void CompileSchemaInSet(System.Xml.XmlNameTable nameTable, System.Xml.Schema.ValidationEventHandler eventHandler, System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings);
                /*0x76bc7a0*/ System.Xml.Schema.XmlSchemaForm get_AttributeFormDefault();
                /*0x76bc7a8*/ void set_AttributeFormDefault(System.Xml.Schema.XmlSchemaForm value);
                /*0x76bc7b0*/ System.Xml.Schema.XmlSchemaDerivationMethod get_BlockDefault();
                /*0x76bc7b8*/ void set_BlockDefault(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x76bc7c0*/ System.Xml.Schema.XmlSchemaDerivationMethod get_FinalDefault();
                /*0x76bc7c8*/ void set_FinalDefault(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x76bc7d0*/ System.Xml.Schema.XmlSchemaForm get_ElementFormDefault();
                /*0x76bc7d8*/ void set_ElementFormDefault(System.Xml.Schema.XmlSchemaForm value);
                /*0x76bc7e0*/ string get_TargetNamespace();
                /*0x76bc7e8*/ void set_TargetNamespace(string value);
                /*0x76bc7f0*/ string get_Version();
                /*0x76bc7f8*/ void set_Version(string value);
                /*0x76bc800*/ System.Xml.Schema.XmlSchemaObjectCollection get_Includes();
                /*0x76bc808*/ System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                /*0x76bc810*/ bool get_IsCompiledBySet();
                /*0x76bc818*/ void set_IsCompiledBySet(bool value);
                /*0x76bc824*/ bool get_IsPreprocessed();
                /*0x76bc82c*/ void set_IsPreprocessed(bool value);
                /*0x76bc838*/ bool get_IsRedefined();
                /*0x76bc840*/ void set_IsRedefined(bool value);
                /*0x76bc84c*/ System.Xml.Schema.XmlSchemaObjectTable get_Attributes();
                /*0x76bc8bc*/ System.Xml.Schema.XmlSchemaObjectTable get_AttributeGroups();
                /*0x76bc92c*/ System.Xml.Schema.XmlSchemaObjectTable get_SchemaTypes();
                /*0x76bc99c*/ System.Xml.Schema.XmlSchemaObjectTable get_Elements();
                /*0x76bca0c*/ string get_Id();
                /*0x76bca14*/ void set_Id(string value);
                /*0x76bca1c*/ System.Xml.Schema.XmlSchemaObjectTable get_Groups();
                /*0x76bca24*/ System.Xml.Schema.XmlSchemaObjectTable get_Notations();
                /*0x76bca2c*/ System.Xml.Schema.XmlSchemaObjectTable get_IdentityConstraints();
                /*0x76bca34*/ System.Uri get_BaseUri();
                /*0x76bca3c*/ void set_BaseUri(System.Uri value);
                /*0x76bca44*/ int get_SchemaId();
                /*0x76bcab4*/ bool get_IsChameleon();
                /*0x76bcabc*/ void set_IsChameleon(bool value);
                /*0x76bcac8*/ System.Collections.Hashtable get_Ids();
                /*0x76bcad0*/ System.Xml.XmlDocument get_Document();
                /*0x76bcb40*/ int get_ErrorCount();
                /*0x76bcb48*/ void set_ErrorCount(int value);
                /*0x76bcb50*/ System.Xml.Schema.XmlSchema Clone();
                /*0x76bcc98*/ System.Xml.Schema.XmlSchema DeepClone();
                /*0x76bdb84*/ string get_IdAttribute();
                /*0x76bdb8c*/ void set_IdAttribute(string value);
                /*0x76bdb94*/ void SetIsCompiled(bool isCompiled);
                /*0x76bdba0*/ void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes);
                /*0x76bdba8*/ void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
                /*0x76bdbc0*/ System.Collections.ArrayList get_ImportedSchemas();
                /*0x76bdc30*/ System.Collections.ArrayList get_ImportedNamespaces();
                /*0x76bdca0*/ void GetExternalSchemasList(System.Collections.IList extList, System.Xml.Schema.XmlSchema schema);
            }

            class XmlSchemaAll : System.Xml.Schema.XmlSchemaGroupBase
            {
                /*0x78*/ System.Xml.Schema.XmlSchemaObjectCollection items;

                /*0x76bdefc*/ XmlSchemaAll();
                /*0x76bdeac*/ System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                /*0x76bdeb4*/ bool get_IsEmpty();
                /*0x76bdef4*/ void SetItems(System.Xml.Schema.XmlSchemaObjectCollection newItems);
            }

            class XmlSchemaAnnotated : System.Xml.Schema.XmlSchemaObject
            {
                /*0x38*/ string id;
                /*0x40*/ System.Xml.Schema.XmlSchemaAnnotation annotation;
                /*0x48*/ System.Xml.XmlAttribute[] moreAttributes;

                /*0x76be00c*/ XmlSchemaAnnotated();
                /*0x76bdfbc*/ string get_Id();
                /*0x76bdfc4*/ void set_Id(string value);
                /*0x76bdfcc*/ System.Xml.Schema.XmlSchemaAnnotation get_Annotation();
                /*0x76bdfd4*/ void set_Annotation(System.Xml.Schema.XmlSchemaAnnotation value);
                /*0x76bdfdc*/ System.Xml.XmlAttribute[] get_UnhandledAttributes();
                /*0x76bdfe4*/ void set_UnhandledAttributes(System.Xml.XmlAttribute[] value);
                /*0x76bdfec*/ string get_IdAttribute();
                /*0x76bdff4*/ void set_IdAttribute(string value);
                /*0x76bdffc*/ void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes);
                /*0x76be004*/ void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
            }

            class XmlSchemaAnnotation : System.Xml.Schema.XmlSchemaObject
            {
                /*0x38*/ string id;
                /*0x40*/ System.Xml.Schema.XmlSchemaObjectCollection items;
                /*0x48*/ System.Xml.XmlAttribute[] moreAttributes;

                /*0x76be044*/ XmlSchemaAnnotation();
                /*0x76be014*/ string get_Id();
                /*0x76be01c*/ void set_Id(string value);
                /*0x76be024*/ System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                /*0x76be02c*/ string get_IdAttribute();
                /*0x76be034*/ void set_IdAttribute(string value);
                /*0x76be03c*/ void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes);
            }

            class XmlSchemaAny : System.Xml.Schema.XmlSchemaParticle
            {
                /*0x78*/ string ns;
                /*0x80*/ System.Xml.Schema.XmlSchemaContentProcessing processContents;
                /*0x88*/ System.Xml.Schema.NamespaceList namespaceList;

                /*0x76be7a0*/ XmlSchemaAny();
                /*0x76be0b0*/ string get_Namespace();
                /*0x76be0b8*/ void set_Namespace(string value);
                /*0x76be0c0*/ void set_ProcessContents(System.Xml.Schema.XmlSchemaContentProcessing value);
                /*0x76be0c8*/ System.Xml.Schema.NamespaceList get_NamespaceList();
                /*0x76be0d0*/ string get_ResolvedNamespace();
                /*0x76be128*/ System.Xml.Schema.XmlSchemaContentProcessing get_ProcessContentsCorrect();
                /*0x76be13c*/ string get_NameString();
                /*0x76be648*/ void BuildNamespaceList(string targetNamespace);
                /*0x76be6d0*/ void BuildNamespaceListV1Compat(string targetNamespace);
                /*0x76be778*/ bool Allows(System.Xml.XmlQualifiedName qname);
            }

            class XmlSchemaAnyAttribute : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ string ns;
                /*0x58*/ System.Xml.Schema.XmlSchemaContentProcessing processContents;
                /*0x60*/ System.Xml.Schema.NamespaceList namespaceList;

                static /*0x76be984*/ bool IsSubset(System.Xml.Schema.XmlSchemaAnyAttribute sub, System.Xml.Schema.XmlSchemaAnyAttribute super);
                static /*0x76be9a8*/ System.Xml.Schema.XmlSchemaAnyAttribute Intersection(System.Xml.Schema.XmlSchemaAnyAttribute o1, System.Xml.Schema.XmlSchemaAnyAttribute o2, bool v1Compat);
                static /*0x76bea74*/ System.Xml.Schema.XmlSchemaAnyAttribute Union(System.Xml.Schema.XmlSchemaAnyAttribute o1, System.Xml.Schema.XmlSchemaAnyAttribute o2, bool v1Compat);
                /*0x76bea6c*/ XmlSchemaAnyAttribute();
                /*0x76be7f8*/ void set_Namespace(string value);
                /*0x76be800*/ System.Xml.Schema.XmlSchemaContentProcessing get_ProcessContents();
                /*0x76be808*/ void set_ProcessContents(System.Xml.Schema.XmlSchemaContentProcessing value);
                /*0x76be810*/ System.Xml.Schema.NamespaceList get_NamespaceList();
                /*0x76be818*/ System.Xml.Schema.XmlSchemaContentProcessing get_ProcessContentsCorrect();
                /*0x76be82c*/ void BuildNamespaceList(string targetNamespace);
                /*0x76be8b4*/ void BuildNamespaceListV1Compat(string targetNamespace);
                /*0x76be95c*/ bool Allows(System.Xml.XmlQualifiedName qname);
            }

            class XmlSchemaAppInfo : System.Xml.Schema.XmlSchemaObject
            {
                /*0x38*/ string source;
                /*0x40*/ System.Xml.XmlNode[] markup;

                /*0x76beb50*/ XmlSchemaAppInfo();
                /*0x76beb38*/ void set_Source(string value);
                /*0x76beb40*/ System.Xml.XmlNode[] get_Markup();
                /*0x76beb48*/ void set_Markup(System.Xml.XmlNode[] value);
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

                /*0x76bee54*/ XmlSchemaAttribute();
                /*0x76beb58*/ string get_DefaultValue();
                /*0x76beb60*/ void set_DefaultValue(string value);
                /*0x76beb68*/ string get_FixedValue();
                /*0x76beb70*/ void set_FixedValue(string value);
                /*0x76beb78*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0x76beb80*/ void set_Form(System.Xml.Schema.XmlSchemaForm value);
                /*0x76beb88*/ string get_Name();
                /*0x76beb90*/ void set_Name(string value);
                /*0x76beb98*/ System.Xml.XmlQualifiedName get_RefName();
                /*0x76beba0*/ void set_RefName(System.Xml.XmlQualifiedName value);
                /*0x76bec40*/ System.Xml.XmlQualifiedName get_SchemaTypeName();
                /*0x76bec48*/ void set_SchemaTypeName(System.Xml.XmlQualifiedName value);
                /*0x76bece8*/ System.Xml.Schema.XmlSchemaSimpleType get_SchemaType();
                /*0x76becf0*/ void set_SchemaType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0x76becf8*/ System.Xml.Schema.XmlSchemaUse get_Use();
                /*0x76bed00*/ void set_Use(System.Xml.Schema.XmlSchemaUse value);
                /*0x76bed08*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0x76bed10*/ System.Xml.Schema.XmlSchemaSimpleType get_AttributeSchemaType();
                /*0x76bed18*/ System.Xml.Schema.XmlSchemaDatatype get_Datatype();
                /*0x76bed30*/ void SetQualifiedName(System.Xml.XmlQualifiedName value);
                /*0x76bed38*/ void SetAttributeType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0x76bed40*/ System.Xml.Schema.SchemaAttDef get_AttDef();
                /*0x76bed48*/ void set_AttDef(System.Xml.Schema.SchemaAttDef value);
                /*0x76bed50*/ string get_NameAttribute();
                /*0x76bed58*/ void set_NameAttribute(string value);
                /*0x76bed60*/ System.Xml.Schema.XmlSchemaObject Clone();
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

                /*0x76bf47c*/ XmlSchemaAttributeGroup();
                /*0x76beef4*/ string get_Name();
                /*0x76beefc*/ void set_Name(string value);
                /*0x76bef04*/ System.Xml.Schema.XmlSchemaObjectCollection get_Attributes();
                /*0x76bef0c*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0x76bef14*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x76bef1c*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0x76bef24*/ System.Xml.Schema.XmlSchemaObjectTable get_AttributeUses();
                /*0x76bef94*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AttributeWildcard();
                /*0x76bef9c*/ void set_AttributeWildcard(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x76befa4*/ System.Xml.Schema.XmlSchemaAttributeGroup get_RedefinedAttributeGroup();
                /*0x76befac*/ System.Xml.Schema.XmlSchemaAttributeGroup get_Redefined();
                /*0x76befb4*/ void set_Redefined(System.Xml.Schema.XmlSchemaAttributeGroup value);
                /*0x76befbc*/ int get_SelfReferenceCount();
                /*0x76befc4*/ void set_SelfReferenceCount(int value);
                /*0x76befcc*/ string get_NameAttribute();
                /*0x76befd4*/ void set_NameAttribute(string value);
                /*0x76befdc*/ void SetQualifiedName(System.Xml.XmlQualifiedName value);
                /*0x76befe4*/ System.Xml.Schema.XmlSchemaObject Clone();
            }

            class XmlSchemaAttributeGroupRef : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ System.Xml.XmlQualifiedName refName;

                /*0x76bf5d4*/ XmlSchemaAttributeGroupRef();
                /*0x76bf52c*/ System.Xml.XmlQualifiedName get_RefName();
                /*0x76bf534*/ void set_RefName(System.Xml.XmlQualifiedName value);
            }

            class XmlSchemaChoice : System.Xml.Schema.XmlSchemaGroupBase
            {
                /*0x78*/ System.Xml.Schema.XmlSchemaObjectCollection items;

                /*0x76bf65c*/ XmlSchemaChoice();
                /*0x76bf644*/ System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                /*0x76bf64c*/ bool get_IsEmpty();
                /*0x76bf654*/ void SetItems(System.Xml.Schema.XmlSchemaObjectCollection newItems);
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

                /*0x76bf6c4*/ XmlSchemaCollection(System.Xml.XmlNameTable nametable);
                /*0x76bf808*/ int get_Count();
                /*0x76bf82c*/ System.Xml.XmlNameTable get_NameTable();
                /*0x76bf834*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x76bf83c*/ System.Xml.Schema.XmlSchema get_Item(string ns);
                /*0x76bf8d4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x76bf97c*/ System.Xml.Schema.XmlSchemaCollectionEnumerator GetEnumerator();
                /*0x76bf9d8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x76bfc64*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x76bfc6c*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x76bfc70*/ int System.Collections.ICollection.get_Count();
                /*0x76ba74c*/ System.Xml.Schema.SchemaInfo GetSchemaInfo(string ns);
                /*0x76bfc94*/ System.Xml.Schema.SchemaNames GetSchemaNames(System.Xml.XmlNameTable nt);
                /*0x76b8df0*/ System.Xml.Schema.XmlSchema Add(string ns, System.Xml.Schema.SchemaInfo schemaInfo, System.Xml.Schema.XmlSchema schema, bool compile);
                /*0x76bfd38*/ System.Xml.Schema.XmlSchema Add(string ns, System.Xml.Schema.SchemaInfo schemaInfo, System.Xml.Schema.XmlSchema schema, bool compile, System.Xml.XmlResolver resolver);
                /*0x76bfea4*/ void Add(string ns, System.Xml.Schema.XmlSchemaCollectionNode node);
                /*0x76bffe0*/ System.Xml.Schema.ValidationEventHandler get_EventHandler();
                /*0x76bffe8*/ void set_EventHandler(System.Xml.Schema.ValidationEventHandler value);
            }

            class XmlSchemaCollectionNode
            {
                /*0x10*/ string namespaceUri;
                /*0x18*/ System.Xml.Schema.SchemaInfo schemaInfo;
                /*0x20*/ System.Xml.Schema.XmlSchema schema;

                /*0x76bfe9c*/ XmlSchemaCollectionNode();
                /*0x76bfff0*/ void set_NamespaceURI(string value);
                /*0x76bfff8*/ System.Xml.Schema.SchemaInfo get_SchemaInfo();
                /*0x76c0000*/ void set_SchemaInfo(System.Xml.Schema.SchemaInfo value);
                /*0x76c0008*/ System.Xml.Schema.XmlSchema get_Schema();
                /*0x76c0010*/ void set_Schema(System.Xml.Schema.XmlSchema value);
            }

            class XmlSchemaCollectionEnumerator : System.Collections.IEnumerator
            {
                /*0x10*/ System.Collections.IDictionaryEnumerator enumerator;

                /*0x76bf930*/ XmlSchemaCollectionEnumerator(System.Collections.Hashtable collection);
                /*0x76c0018*/ void System.Collections.IEnumerator.Reset();
                /*0x76c00bc*/ bool System.Collections.IEnumerator.MoveNext();
                /*0x76bfbc4*/ bool MoveNext();
                /*0x76c015c*/ object System.Collections.IEnumerator.get_Current();
                /*0x76bfaec*/ System.Xml.Schema.XmlSchema get_Current();
                /*0x76c0160*/ System.Xml.Schema.XmlSchemaCollectionNode get_CurrentNode();
            }

            class XmlSchemaCompilationSettings
            {
                /*0x10*/ bool enableUpaCheck;

                /*0x76c0234*/ XmlSchemaCompilationSettings();
                /*0x76c0254*/ bool get_EnableUpaCheck();
            }

            class XmlSchemaComplexContent : System.Xml.Schema.XmlSchemaContentModel
            {
                /*0x50*/ System.Xml.Schema.XmlSchemaContent content;
                /*0x58*/ bool isMixed;
                /*0x59*/ bool hasMixedAttribute;

                /*0x76c0290*/ XmlSchemaComplexContent();
                /*0x76c025c*/ bool get_IsMixed();
                /*0x76c0264*/ void set_IsMixed(bool value);
                /*0x76c0278*/ System.Xml.Schema.XmlSchemaContent get_Content();
                /*0x76c0280*/ void set_Content(System.Xml.Schema.XmlSchemaContent value);
                /*0x76c0288*/ bool get_HasMixedAttribute();
            }

            class XmlSchemaComplexContentExtension : System.Xml.Schema.XmlSchemaContent
            {
                /*0x50*/ System.Xml.Schema.XmlSchemaParticle particle;
                /*0x58*/ System.Xml.Schema.XmlSchemaObjectCollection attributes;
                /*0x60*/ System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;
                /*0x68*/ System.Xml.XmlQualifiedName baseTypeName;

                /*0x76c0378*/ XmlSchemaComplexContentExtension();
                /*0x76c02a0*/ System.Xml.XmlQualifiedName get_BaseTypeName();
                /*0x76c02a8*/ void set_BaseTypeName(System.Xml.XmlQualifiedName value);
                /*0x76c0348*/ System.Xml.Schema.XmlSchemaParticle get_Particle();
                /*0x76c0350*/ void set_Particle(System.Xml.Schema.XmlSchemaParticle value);
                /*0x76c0358*/ System.Xml.Schema.XmlSchemaObjectCollection get_Attributes();
                /*0x76c0360*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0x76c0368*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x76c0370*/ void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes);
            }

            class XmlSchemaComplexContentRestriction : System.Xml.Schema.XmlSchemaContent
            {
                /*0x50*/ System.Xml.Schema.XmlSchemaParticle particle;
                /*0x58*/ System.Xml.Schema.XmlSchemaObjectCollection attributes;
                /*0x60*/ System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;
                /*0x68*/ System.Xml.XmlQualifiedName baseTypeName;

                /*0x76c0508*/ XmlSchemaComplexContentRestriction();
                /*0x76c0430*/ System.Xml.XmlQualifiedName get_BaseTypeName();
                /*0x76c0438*/ void set_BaseTypeName(System.Xml.XmlQualifiedName value);
                /*0x76c04d8*/ System.Xml.Schema.XmlSchemaParticle get_Particle();
                /*0x76c04e0*/ void set_Particle(System.Xml.Schema.XmlSchemaParticle value);
                /*0x76c04e8*/ System.Xml.Schema.XmlSchemaObjectCollection get_Attributes();
                /*0x76c04f0*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0x76c04f8*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x76c0500*/ void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes);
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

                static /*0x76c05b8*/ XmlSchemaComplexType();
                static /*0x76c07dc*/ System.Xml.Schema.XmlSchemaComplexType CreateAnyType(System.Xml.Schema.XmlSchemaContentProcessing processContents);
                static /*0x76c0c08*/ System.Xml.Schema.XmlSchemaComplexType get_AnyType();
                static /*0x76c0c60*/ System.Xml.Schema.XmlSchemaComplexType get_UntypedAnyType();
                static /*0x76c0b98*/ System.Xml.Schema.ContentValidator get_AnyTypeContentValidator();
                static /*0x76bf24c*/ System.Xml.Schema.XmlSchemaObjectCollection CloneAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes);
                static /*0x76c18d8*/ System.Xml.Schema.XmlSchemaObjectCollection CloneGroupBaseParticles(System.Xml.Schema.XmlSchemaObjectCollection groupBaseParticles, System.Xml.Schema.XmlSchema parentSchema);
                static /*0x76c1510*/ System.Xml.Schema.XmlSchemaParticle CloneParticle(System.Xml.Schema.XmlSchemaParticle particle, System.Xml.Schema.XmlSchema parentSchema);
                static /*0x76c1ab8*/ System.Xml.Schema.XmlSchemaForm GetResolvedElementForm(System.Xml.Schema.XmlSchema parentSchema, System.Xml.Schema.XmlSchemaElement element);
                static /*0x76c1294*/ bool HasParticleRef(System.Xml.Schema.XmlSchemaParticle particle, System.Xml.Schema.XmlSchema parentSchema);
                static /*0x76bf0f0*/ bool HasAttributeQNameRef(System.Xml.Schema.XmlSchemaObjectCollection attributes);
                /*0x76c0b20*/ XmlSchemaComplexType();
                /*0x76c0cb8*/ bool get_IsAbstract();
                /*0x76c0cc4*/ void set_IsAbstract(bool value);
                /*0x76c0ce4*/ System.Xml.Schema.XmlSchemaDerivationMethod get_Block();
                /*0x76c0cec*/ void set_Block(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x76c0cf4*/ bool get_IsMixed();
                /*0x76c0d00*/ void set_IsMixed(bool value);
                /*0x76c0d20*/ System.Xml.Schema.XmlSchemaContentModel get_ContentModel();
                /*0x76c0d28*/ void set_ContentModel(System.Xml.Schema.XmlSchemaContentModel value);
                /*0x76c0d30*/ System.Xml.Schema.XmlSchemaParticle get_Particle();
                /*0x76c0d38*/ void set_Particle(System.Xml.Schema.XmlSchemaParticle value);
                /*0x76c0d40*/ System.Xml.Schema.XmlSchemaObjectCollection get_Attributes();
                /*0x76c0db0*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0x76c0db8*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x76c0dc0*/ System.Xml.Schema.XmlSchemaContentType get_ContentType();
                /*0x76c0dc8*/ System.Xml.Schema.XmlSchemaParticle get_ContentTypeParticle();
                /*0x76c0dd0*/ System.Xml.Schema.XmlSchemaDerivationMethod get_BlockResolved();
                /*0x76c0dd8*/ System.Xml.Schema.XmlSchemaObjectTable get_AttributeUses();
                /*0x76c0e48*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AttributeWildcard();
                /*0x76c0e50*/ System.Xml.Schema.XmlSchemaObjectTable get_LocalElements();
                /*0x76c0ec0*/ void SetContentTypeParticle(System.Xml.Schema.XmlSchemaParticle value);
                /*0x76c0ec8*/ void SetBlockResolved(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x76c0ed0*/ void SetAttributeWildcard(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x76c0ed8*/ void set_HasWildCard(bool value);
                /*0x76c0ee8*/ void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes);
                /*0x76c0ef0*/ bool ContainsIdAttribute(bool findAll);
                /*0x76c128c*/ System.Xml.Schema.XmlSchemaObject Clone();
                /*0x76bcfc8*/ System.Xml.Schema.XmlSchemaObject Clone(System.Xml.Schema.XmlSchema parentSchema);
                /*0x76c17b8*/ void ClearCompiledState();
            }

            class XmlSchemaContent : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x76c0428*/ XmlSchemaContent();
            }

            class XmlSchemaContentModel : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x76c0298*/ XmlSchemaContentModel();
                /*0x380b9e8*/ System.Xml.Schema.XmlSchemaContent get_Content();
                /*0x380d83c*/ void set_Content(System.Xml.Schema.XmlSchemaContent value);
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
                static /*0x76c20c0*/ string ConcatenatedToString(object value);
                static /*0x76b4868*/ System.Xml.Schema.XmlSchemaDatatype FromXmlTokenizedType(System.Xml.XmlTokenizedType token);
                static /*0x76c2764*/ System.Xml.Schema.XmlSchemaDatatype FromXmlTokenizedTypeXsd(System.Xml.XmlTokenizedType token);
                static /*0x76b30ec*/ System.Xml.Schema.XmlSchemaDatatype FromXdrName(string name);
                static /*0x76c27bc*/ System.Xml.Schema.XmlSchemaDatatype DeriveByUnion(System.Xml.Schema.XmlSchemaSimpleType[] types, System.Xml.Schema.XmlSchemaType schemaType);
                static /*0x76b0c84*/ string XdrCanonizeUri(string uri, System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames);
                /*0x76c2824*/ XmlSchemaDatatype();
                /*0x380b9e8*/ System.Type get_ValueType();
                /*0x380b6a0*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x380bd40*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
                /*0x76c1ae0*/ System.Xml.Schema.XmlSchemaDatatypeVariety get_Variety();
                /*0x76c1ae8*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x76c1af0*/ bool IsDerivedFrom(System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x380b128*/ bool get_HasLexicalFacets();
                /*0x380b128*/ bool get_HasValueFacets();
                /*0x380b9e8*/ System.Xml.Schema.XmlValueConverter get_ValueConverter();
                /*0x380b9e8*/ System.Xml.Schema.RestrictionFacets get_Restriction();
                int Compare(object value1, object value2);
                object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, bool createAtomicValue);
                /*0x380bd7c*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
                /*0x380bd7c*/ System.Exception TryParseValue(object value, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver namespaceResolver, ref object typedValue);
                /*0x380b9e8*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x380b6a0*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x380bd40*/ System.Xml.Schema.XmlSchemaDatatype DeriveByRestriction(System.Xml.Schema.XmlSchemaObjectCollection facets, System.Xml.XmlNameTable nameTable, System.Xml.Schema.XmlSchemaType schemaType);
                /*0x380bb68*/ System.Xml.Schema.XmlSchemaDatatype DeriveByList(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x380d93c*/ void VerifySchemaValid(System.Xml.Schema.XmlSchemaObjectTable notations, System.Xml.Schema.XmlSchemaObject caller);
                /*0x380b32c*/ bool IsEqual(object o1, object o2);
                /*0x380b2f0*/ bool IsComparable(System.Xml.Schema.XmlSchemaDatatype dtype);
                /*0x76c1af8*/ string get_TypeCodeString();
                /*0x76c1c14*/ string TypeCodeToString(System.Xml.Schema.XmlTypeCode typeCode);
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

                static /*0x76c2918*/ XmlSchemaDocumentation();
                /*0x76c2910*/ XmlSchemaDocumentation();
                /*0x76c282c*/ void set_Source(string value);
                /*0x76c2834*/ void set_Language(string value);
                /*0x76c2908*/ void set_Markup(System.Xml.XmlNode[] value);
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

                /*0x76c2ddc*/ XmlSchemaElement();
                /*0x76c29fc*/ bool get_IsAbstract();
                /*0x76c2a04*/ void set_IsAbstract(bool value);
                /*0x76c2a18*/ System.Xml.Schema.XmlSchemaDerivationMethod get_Block();
                /*0x76c2a20*/ void set_Block(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x76c2a28*/ string get_DefaultValue();
                /*0x76c2a30*/ void set_DefaultValue(string value);
                /*0x76c2a38*/ System.Xml.Schema.XmlSchemaDerivationMethod get_Final();
                /*0x76c2a40*/ void set_Final(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x76c2a48*/ string get_FixedValue();
                /*0x76c2a50*/ void set_FixedValue(string value);
                /*0x76c2a58*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0x76c2a60*/ void set_Form(System.Xml.Schema.XmlSchemaForm value);
                /*0x76c2a68*/ string get_Name();
                /*0x76c2a70*/ void set_Name(string value);
                /*0x76c2a78*/ bool get_IsNillable();
                /*0x76c2a80*/ void set_IsNillable(bool value);
                /*0x76c2a94*/ bool get_HasNillableAttribute();
                /*0x76c2a9c*/ bool get_HasAbstractAttribute();
                /*0x76c2aa4*/ System.Xml.XmlQualifiedName get_RefName();
                /*0x76c2aac*/ void set_RefName(System.Xml.XmlQualifiedName value);
                /*0x76c2b4c*/ System.Xml.XmlQualifiedName get_SubstitutionGroup();
                /*0x76c2b54*/ void set_SubstitutionGroup(System.Xml.XmlQualifiedName value);
                /*0x76c2bf4*/ System.Xml.XmlQualifiedName get_SchemaTypeName();
                /*0x76c2bfc*/ void set_SchemaTypeName(System.Xml.XmlQualifiedName value);
                /*0x76c2c9c*/ System.Xml.Schema.XmlSchemaType get_SchemaType();
                /*0x76c2ca4*/ void set_SchemaType(System.Xml.Schema.XmlSchemaType value);
                /*0x76c2cac*/ System.Xml.Schema.XmlSchemaObjectCollection get_Constraints();
                /*0x76c2d1c*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0x76c2d24*/ System.Xml.Schema.XmlSchemaType get_ElementSchemaType();
                /*0x76c2d2c*/ System.Xml.Schema.XmlSchemaDerivationMethod get_BlockResolved();
                /*0x76c2d34*/ System.Xml.Schema.XmlSchemaDerivationMethod get_FinalResolved();
                /*0x76c2d3c*/ void SetQualifiedName(System.Xml.XmlQualifiedName value);
                /*0x76c2d44*/ void SetElementType(System.Xml.Schema.XmlSchemaType value);
                /*0x76c2d4c*/ void SetBlockResolved(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x76c2d54*/ void SetFinalResolved(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x76c2d5c*/ bool get_HasConstraints();
                /*0x76c2d80*/ bool get_IsLocalTypeDerivationChecked();
                /*0x76c2d88*/ void set_IsLocalTypeDerivationChecked(bool value);
                /*0x76c2d94*/ System.Xml.Schema.SchemaElementDecl get_ElementDecl();
                /*0x76c2d9c*/ void set_ElementDecl(System.Xml.Schema.SchemaElementDecl value);
                /*0x76c2da4*/ string get_NameAttribute();
                /*0x76c2dac*/ void set_NameAttribute(string value);
                /*0x76c2db4*/ string get_NameString();
                /*0x76c2dd4*/ System.Xml.Schema.XmlSchemaObject Clone();
                /*0x76bd6dc*/ System.Xml.Schema.XmlSchemaObject Clone(System.Xml.Schema.XmlSchema parentSchema);
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

                static /*0x76c3274*/ string CreateMessage(string res, string[] args);
                /*0x76c2ec0*/ XmlSchemaException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x76c34a8*/ XmlSchemaException();
                /*0x76c34bc*/ XmlSchemaException(string message);
                /*0x76c35cc*/ XmlSchemaException(string message, System.Exception innerException);
                /*0x76c34cc*/ XmlSchemaException(string message, System.Exception innerException, int lineNumber, int linePosition);
                /*0x76c3690*/ XmlSchemaException(string res, string[] args);
                /*0x76bacd4*/ XmlSchemaException(string res, string arg);
                /*0x76b63e4*/ XmlSchemaException(string res, string arg, string sourceUri, int lineNumber, int linePosition);
                /*0x76c36bc*/ XmlSchemaException(string res, string sourceUri, int lineNumber, int linePosition);
                /*0x76b62f0*/ XmlSchemaException(string res, string[] args, string sourceUri, int lineNumber, int linePosition);
                /*0x76c36ec*/ XmlSchemaException(string res, System.Xml.Schema.XmlSchemaObject source);
                /*0x76c3728*/ XmlSchemaException(string res, string arg, System.Xml.Schema.XmlSchemaObject source);
                /*0x76c36f8*/ XmlSchemaException(string res, string[] args, System.Xml.Schema.XmlSchemaObject source);
                /*0x76c35d8*/ XmlSchemaException(string res, string[] args, System.Exception innerException, string sourceUri, int lineNumber, int linePosition, System.Xml.Schema.XmlSchemaObject source);
                /*0x76c3338*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x76c37c8*/ string get_GetRes();
                /*0x76c37d0*/ string[] get_Args();
                /*0x76c37d8*/ string get_SourceUri();
                /*0x76c37e0*/ int get_LineNumber();
                /*0x76c37e8*/ int get_LinePosition();
                /*0x76c37f0*/ System.Xml.Schema.XmlSchemaObject get_SourceSchemaObject();
                /*0x76ba13c*/ void SetSource(string sourceUri, int lineNumber, int linePosition);
                /*0x76c37f8*/ void SetSchemaObject(System.Xml.Schema.XmlSchemaObject source);
                /*0x76c3800*/ void SetSource(System.Xml.Schema.XmlSchemaObject source);
                /*0x76c3844*/ string get_Message();
            }

            class XmlSchemaExternal : System.Xml.Schema.XmlSchemaObject
            {
                /*0x38*/ string location;
                /*0x40*/ System.Uri baseUri;
                /*0x48*/ System.Xml.Schema.XmlSchema schema;
                /*0x50*/ string id;
                /*0x58*/ System.Xml.XmlAttribute[] moreAttributes;
                /*0x60*/ System.Xml.Schema.Compositor compositor;

                /*0x76c38c4*/ XmlSchemaExternal();
                /*0x76c385c*/ string get_SchemaLocation();
                /*0x76c3864*/ void set_SchemaLocation(string value);
                /*0x76c386c*/ System.Xml.Schema.XmlSchema get_Schema();
                /*0x76c3874*/ void set_Schema(System.Xml.Schema.XmlSchema value);
                /*0x76c387c*/ string get_Id();
                /*0x76c3884*/ void set_Id(string value);
                /*0x76c388c*/ System.Uri get_BaseUri();
                /*0x76c3894*/ void set_BaseUri(System.Uri value);
                /*0x76c389c*/ string get_IdAttribute();
                /*0x76c38a4*/ void set_IdAttribute(string value);
                /*0x76c38ac*/ void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes);
                /*0x76c38b4*/ System.Xml.Schema.Compositor get_Compositor();
                /*0x76c38bc*/ void set_Compositor(System.Xml.Schema.Compositor value);
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

                /*0x76c39a8*/ XmlSchemaFacet();
                /*0x76c38cc*/ string get_Value();
                /*0x76c38d4*/ void set_Value(string value);
                /*0x76c38dc*/ bool get_IsFixed();
                /*0x76c38e4*/ void set_IsFixed(bool value);
                /*0x76c3998*/ System.Xml.Schema.FacetType get_FacetType();
                /*0x76c39a0*/ void set_FacetType(System.Xml.Schema.FacetType value);
            }

            class XmlSchemaNumericFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x76c39b0*/ XmlSchemaNumericFacet();
            }

            class XmlSchemaLengthFacet : System.Xml.Schema.XmlSchemaNumericFacet
            {
                /*0x76c39b8*/ XmlSchemaLengthFacet();
            }

            class XmlSchemaMinLengthFacet : System.Xml.Schema.XmlSchemaNumericFacet
            {
                /*0x76c39d8*/ XmlSchemaMinLengthFacet();
            }

            class XmlSchemaMaxLengthFacet : System.Xml.Schema.XmlSchemaNumericFacet
            {
                /*0x76c39f8*/ XmlSchemaMaxLengthFacet();
            }

            class XmlSchemaPatternFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x76c3a18*/ XmlSchemaPatternFacet();
            }

            class XmlSchemaEnumerationFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x76c3a38*/ XmlSchemaEnumerationFacet();
            }

            class XmlSchemaMinExclusiveFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x76c3a58*/ XmlSchemaMinExclusiveFacet();
            }

            class XmlSchemaMinInclusiveFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x76c3a78*/ XmlSchemaMinInclusiveFacet();
            }

            class XmlSchemaMaxExclusiveFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x76c3a98*/ XmlSchemaMaxExclusiveFacet();
            }

            class XmlSchemaMaxInclusiveFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x76c3ab8*/ XmlSchemaMaxInclusiveFacet();
            }

            class XmlSchemaTotalDigitsFacet : System.Xml.Schema.XmlSchemaNumericFacet
            {
                /*0x76c3ad8*/ XmlSchemaTotalDigitsFacet();
            }

            class XmlSchemaFractionDigitsFacet : System.Xml.Schema.XmlSchemaNumericFacet
            {
                /*0x76c3af8*/ XmlSchemaFractionDigitsFacet();
            }

            class XmlSchemaWhiteSpaceFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x76c3b18*/ XmlSchemaWhiteSpaceFacet();
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

                /*0x76c3bb0*/ XmlSchemaGroup();
                /*0x76c3b38*/ string get_Name();
                /*0x76c3b40*/ void set_Name(string value);
                /*0x76c3b48*/ System.Xml.Schema.XmlSchemaGroupBase get_Particle();
                /*0x76c3b50*/ void set_Particle(System.Xml.Schema.XmlSchemaGroupBase value);
                /*0x76c3b58*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0x76c3b60*/ System.Xml.Schema.XmlSchemaParticle get_CanonicalParticle();
                /*0x76c3b68*/ void set_CanonicalParticle(System.Xml.Schema.XmlSchemaParticle value);
                /*0x76c3b70*/ System.Xml.Schema.XmlSchemaGroup get_Redefined();
                /*0x76c3b78*/ void set_Redefined(System.Xml.Schema.XmlSchemaGroup value);
                /*0x76c3b80*/ int get_SelfReferenceCount();
                /*0x76c3b88*/ void set_SelfReferenceCount(int value);
                /*0x76c3b90*/ string get_NameAttribute();
                /*0x76c3b98*/ void set_NameAttribute(string value);
                /*0x76c3ba0*/ void SetQualifiedName(System.Xml.XmlQualifiedName value);
                /*0x76c3ba8*/ System.Xml.Schema.XmlSchemaObject Clone();
                /*0x76bd8fc*/ System.Xml.Schema.XmlSchemaObject Clone(System.Xml.Schema.XmlSchema parentSchema);
            }

            class XmlSchemaGroupBase : System.Xml.Schema.XmlSchemaParticle
            {
                /*0x76bdf64*/ XmlSchemaGroupBase();
                /*0x380b9e8*/ System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                /*0x380d83c*/ void SetItems(System.Xml.Schema.XmlSchemaObjectCollection newItems);
            }

            class XmlSchemaGroupRef : System.Xml.Schema.XmlSchemaParticle
            {
                /*0x78*/ System.Xml.XmlQualifiedName refName;
                /*0x80*/ System.Xml.Schema.XmlSchemaGroupBase particle;
                /*0x88*/ System.Xml.Schema.XmlSchemaGroup refined;

                /*0x76c3c48*/ XmlSchemaGroupRef();
                /*0x76c3c20*/ System.Xml.XmlQualifiedName get_RefName();
                /*0x76c1a18*/ void set_RefName(System.Xml.XmlQualifiedName value);
                /*0x76c3c28*/ System.Xml.Schema.XmlSchemaGroupBase get_Particle();
                /*0x76c3c30*/ void SetParticle(System.Xml.Schema.XmlSchemaGroupBase value);
                /*0x76c3c38*/ System.Xml.Schema.XmlSchemaGroup get_Redefined();
                /*0x76c3c40*/ void set_Redefined(System.Xml.Schema.XmlSchemaGroup value);
            }

            class XmlSchemaIdentityConstraint : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ string name;
                /*0x58*/ System.Xml.Schema.XmlSchemaXPath selector;
                /*0x60*/ System.Xml.Schema.XmlSchemaObjectCollection fields;
                /*0x68*/ System.Xml.XmlQualifiedName qualifiedName;
                /*0x70*/ System.Xml.Schema.CompiledIdentityConstraint compiledConstraint;

                /*0x76c3d34*/ XmlSchemaIdentityConstraint();
                /*0x76c3cdc*/ string get_Name();
                /*0x76c3ce4*/ void set_Name(string value);
                /*0x76c3cec*/ System.Xml.Schema.XmlSchemaXPath get_Selector();
                /*0x76c3cf4*/ void set_Selector(System.Xml.Schema.XmlSchemaXPath value);
                /*0x76c3cfc*/ System.Xml.Schema.XmlSchemaObjectCollection get_Fields();
                /*0x76c3d04*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0x76c3d0c*/ void SetQualifiedName(System.Xml.XmlQualifiedName value);
                /*0x76c3d14*/ System.Xml.Schema.CompiledIdentityConstraint get_CompiledConstraint();
                /*0x76c3d1c*/ void set_CompiledConstraint(System.Xml.Schema.CompiledIdentityConstraint value);
                /*0x76c3d24*/ string get_NameAttribute();
                /*0x76c3d2c*/ void set_NameAttribute(string value);
            }

            class XmlSchemaXPath : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ string xpath;

                /*0x76c3df4*/ XmlSchemaXPath();
                /*0x76c3de4*/ string get_XPath();
                /*0x76c3dec*/ void set_XPath(string value);
            }

            class XmlSchemaUnique : System.Xml.Schema.XmlSchemaIdentityConstraint
            {
                /*0x76c3dfc*/ XmlSchemaUnique();
            }

            class XmlSchemaKey : System.Xml.Schema.XmlSchemaIdentityConstraint
            {
                /*0x76c3e00*/ XmlSchemaKey();
            }

            class XmlSchemaKeyref : System.Xml.Schema.XmlSchemaIdentityConstraint
            {
                /*0x78*/ System.Xml.XmlQualifiedName refer;

                /*0x76c3eac*/ XmlSchemaKeyref();
                /*0x76c3e04*/ System.Xml.XmlQualifiedName get_Refer();
                /*0x76c3e0c*/ void set_Refer(System.Xml.XmlQualifiedName value);
            }

            class XmlSchemaImport : System.Xml.Schema.XmlSchemaExternal
            {
                /*0x68*/ string ns;
                /*0x70*/ System.Xml.Schema.XmlSchemaAnnotation annotation;

                /*0x76c3f18*/ XmlSchemaImport();
                /*0x76c3f38*/ string get_Namespace();
                /*0x76c3f40*/ void set_Namespace(string value);
                /*0x76c3f48*/ void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
            }

            class XmlSchemaInclude : System.Xml.Schema.XmlSchemaExternal
            {
                /*0x68*/ System.Xml.Schema.XmlSchemaAnnotation annotation;

                /*0x76c3f50*/ XmlSchemaInclude();
                /*0x76c3f70*/ void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
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

                /*0x76c3f78*/ XmlSchemaInfo();
                /*0x76c3ff0*/ XmlSchemaInfo(System.Xml.Schema.XmlSchemaValidity validity);
                /*0x76c4020*/ System.Xml.Schema.XmlSchemaValidity get_Validity();
                /*0x76c4028*/ void set_Validity(System.Xml.Schema.XmlSchemaValidity value);
                /*0x76c4030*/ bool get_IsDefault();
                /*0x76c4038*/ void set_IsDefault(bool value);
                /*0x76c4044*/ bool get_IsNil();
                /*0x76c404c*/ void set_IsNil(bool value);
                /*0x76c4058*/ System.Xml.Schema.XmlSchemaSimpleType get_MemberType();
                /*0x76c4060*/ void set_MemberType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0x76c4068*/ System.Xml.Schema.XmlSchemaType get_SchemaType();
                /*0x76c4070*/ void set_SchemaType(System.Xml.Schema.XmlSchemaType value);
                /*0x76c40b0*/ System.Xml.Schema.XmlSchemaElement get_SchemaElement();
                /*0x76c40b8*/ void set_SchemaElement(System.Xml.Schema.XmlSchemaElement value);
                /*0x76c40f8*/ System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute();
                /*0x76c4100*/ void set_SchemaAttribute(System.Xml.Schema.XmlSchemaAttribute value);
                /*0x76c4140*/ System.Xml.Schema.XmlSchemaContentType get_ContentType();
                /*0x76c4148*/ System.Xml.Schema.XmlSchemaType get_XmlType();
                /*0x76c4164*/ bool get_HasDefaultValue();
                /*0x76c4198*/ bool get_IsUnionType();
                /*0x76c3f94*/ void Clear();
            }

            class XmlSchemaNotation : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ string name;
                /*0x58*/ string publicId;
                /*0x60*/ string systemId;
                /*0x68*/ System.Xml.XmlQualifiedName qname;

                /*0x76c4220*/ XmlSchemaNotation();
                /*0x76c41d0*/ string get_Name();
                /*0x76c41d8*/ void set_Name(string value);
                /*0x76c41e0*/ string get_Public();
                /*0x76c41e8*/ void set_Public(string value);
                /*0x76c41f0*/ string get_System();
                /*0x76c41f8*/ void set_System(string value);
                /*0x76c4200*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0x76c4208*/ void set_QualifiedName(System.Xml.XmlQualifiedName value);
                /*0x76c4210*/ string get_NameAttribute();
                /*0x76c4218*/ void set_NameAttribute(string value);
            }

            class XmlSchemaObject
            {
                /*0x10*/ int lineNum;
                /*0x14*/ int linePos;
                /*0x18*/ string sourceUri;
                /*0x20*/ System.Xml.Serialization.XmlSerializerNamespaces namespaces;
                /*0x28*/ System.Xml.Schema.XmlSchemaObject parent;
                /*0x30*/ bool isProcessing;

                /*0x76bc34c*/ XmlSchemaObject();
                /*0x76c4290*/ int get_LineNumber();
                /*0x76c4298*/ void set_LineNumber(int value);
                /*0x76c42a0*/ int get_LinePosition();
                /*0x76c42a8*/ void set_LinePosition(int value);
                /*0x76c42b0*/ string get_SourceUri();
                /*0x76c42b8*/ void set_SourceUri(string value);
                /*0x76c42c0*/ System.Xml.Schema.XmlSchemaObject get_Parent();
                /*0x76c42c8*/ void set_Parent(System.Xml.Schema.XmlSchemaObject value);
                /*0x76bcc28*/ System.Xml.Serialization.XmlSerializerNamespaces get_Namespaces();
                /*0x76c42d0*/ void set_Namespaces(System.Xml.Serialization.XmlSerializerNamespaces value);
                /*0x76c42d8*/ void OnAdd(System.Xml.Schema.XmlSchemaObjectCollection container, object item);
                /*0x76c42dc*/ void OnRemove(System.Xml.Schema.XmlSchemaObjectCollection container, object item);
                /*0x76c42e0*/ void OnClear(System.Xml.Schema.XmlSchemaObjectCollection container);
                /*0x76c42e4*/ string get_IdAttribute();
                /*0x76c42ec*/ void set_IdAttribute(string value);
                /*0x76c42f0*/ void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes);
                /*0x76c42f4*/ void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
                /*0x76c42f8*/ string get_NameAttribute();
                /*0x76c4300*/ void set_NameAttribute(string value);
                /*0x76c4304*/ bool get_IsProcessing();
                /*0x76c430c*/ void set_IsProcessing(bool value);
                /*0x76c4318*/ System.Xml.Schema.XmlSchemaObject Clone();
            }

            class XmlSchemaObjectCollection : System.Collections.CollectionBase
            {
                /*0x18*/ System.Xml.Schema.XmlSchemaObject parent;

                /*0x76bc344*/ XmlSchemaObjectCollection();
                /*0x76c4398*/ System.Xml.Schema.XmlSchemaObject get_Item(int index);
                /*0x76c4498*/ void set_Item(int index, System.Xml.Schema.XmlSchemaObject value);
                /*0x76c4560*/ System.Xml.Schema.XmlSchemaObjectEnumerator GetEnumerator();
                /*0x76bdacc*/ int Add(System.Xml.Schema.XmlSchemaObject item);
                /*0x76c45e0*/ void Insert(int index, System.Xml.Schema.XmlSchemaObject item);
                /*0x76c46a8*/ void Remove(System.Xml.Schema.XmlSchemaObject item);
                /*0x76c4760*/ void OnInsert(int index, object item);
                /*0x76c477c*/ void OnSet(int index, object oldValue, object newValue);
                /*0x76c47d8*/ void OnClear();
                /*0x76c47f4*/ void OnRemove(int index, object item);
                /*0x76c1858*/ System.Xml.Schema.XmlSchemaObjectCollection Clone();
                /*0x76c4810*/ void Add(System.Xml.Schema.XmlSchemaObjectCollection collToAdd);
            }

            class XmlSchemaObjectEnumerator : System.Collections.IEnumerator
            {
                /*0x10*/ System.Collections.IEnumerator enumerator;

                /*0x76c483c*/ XmlSchemaObjectEnumerator(System.Collections.IEnumerator enumerator);
                /*0x76c486c*/ bool MoveNext();
                /*0x76c490c*/ System.Xml.Schema.XmlSchemaObject get_Current();
                /*0x76c49fc*/ void System.Collections.IEnumerator.Reset();
                /*0x76c4aa0*/ bool System.Collections.IEnumerator.MoveNext();
                /*0x76c4b40*/ object System.Collections.IEnumerator.get_Current();
            }

            class XmlSchemaObjectTable
            {
                /*0x10*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.XmlSchemaObject> table;
                /*0x18*/ System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries;

                /*0x76c4be4*/ XmlSchemaObjectTable();
                /*0x76c4cc0*/ void Add(System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaObject value);
                /*0x76c4e08*/ void Insert(System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaObject value);
                /*0x76c4fc8*/ void Replace(System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaObject value);
                /*0x76c50d8*/ void Clear();
                /*0x76c516c*/ void Remove(System.Xml.XmlQualifiedName name);
                /*0x76c4f2c*/ int FindIndexByValue(System.Xml.Schema.XmlSchemaObject xso);
                /*0x76c523c*/ int get_Count();
                /*0x76c528c*/ bool Contains(System.Xml.XmlQualifiedName name);
                /*0x76c52e4*/ System.Xml.Schema.XmlSchemaObject get_Item(System.Xml.XmlQualifiedName name);
                /*0x76c535c*/ System.Collections.ICollection get_Values();
                /*0x76c5438*/ System.Collections.IDictionaryEnumerator GetEnumerator();

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

                    /*0x76c4dd8*/ XmlSchemaObjectEntry(System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaObject value);
                }

                class ValuesCollection : System.Collections.ICollection, System.Collections.IEnumerable
                {
                    /*0x10*/ System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries;
                    /*0x18*/ int size;

                    /*0x76c53fc*/ ValuesCollection(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size);
                    /*0x76c5534*/ int get_Count();
                    /*0x76c553c*/ object get_SyncRoot();
                    /*0x76c55e0*/ bool get_IsSynchronized();
                    /*0x76c5684*/ void CopyTo(System.Array array, int arrayIndex);
                    /*0x76c57ac*/ System.Collections.IEnumerator GetEnumerator();
                }

                class XSOEnumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries;
                    /*0x18*/ System.Xml.Schema.XmlSchemaObjectTable.EnumeratorType enumType;
                    /*0x1c*/ int currentIndex;
                    /*0x20*/ int size;
                    /*0x28*/ System.Xml.XmlQualifiedName currentKey;
                    /*0x30*/ System.Xml.Schema.XmlSchemaObject currentValue;

                    /*0x76c5834*/ XSOEnumerator(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, System.Xml.Schema.XmlSchemaObjectTable.EnumeratorType enumType);
                    /*0x76c5884*/ object get_Current();
                    /*0x76c5a34*/ bool MoveNext();
                    /*0x76c5b04*/ void Reset();
                }

                class XSODictionaryEnumerator : System.Xml.Schema.XmlSchemaObjectTable.XSOEnumerator, System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator
                {
                    /*0x76c54e4*/ XSODictionaryEnumerator(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, System.Xml.Schema.XmlSchemaObjectTable.EnumeratorType enumType);
                    /*0x76c5b34*/ System.Collections.DictionaryEntry get_Entry();
                    /*0x76c5c78*/ object get_Key();
                    /*0x76c5da0*/ object get_Value();
                }
            }

            class XmlSchemaParticle : System.Xml.Schema.XmlSchemaAnnotated
            {
                static /*0x0*/ System.Xml.Schema.XmlSchemaParticle Empty;
                /*0x50*/ decimal minOccurs;
                /*0x60*/ decimal maxOccurs;
                /*0x70*/ System.Xml.Schema.XmlSchemaParticle.Occurs flags;

                static /*0x76c68e8*/ XmlSchemaParticle();
                /*0x76c6874*/ XmlSchemaParticle();
                /*0x76c5ec8*/ string get_MinOccursString();
                /*0x76c5f40*/ void set_MinOccursString(string value);
                /*0x76c6094*/ string get_MaxOccursString();
                /*0x76c61b8*/ void set_MaxOccursString(string value);
                /*0x76c63d4*/ decimal get_MinOccurs();
                /*0x76c63e0*/ void set_MinOccurs(decimal value);
                /*0x76c650c*/ decimal get_MaxOccurs();
                /*0x76c6518*/ void set_MaxOccurs(decimal value);
                /*0x76c667c*/ bool get_IsEmpty();
                /*0x76c66e8*/ string get_NameString();
                /*0x76c6700*/ System.Xml.XmlQualifiedName GetQualifiedName();

                enum Occurs
                {
                    None = 0,
                    Min = 1,
                    Max = 2,
                }

                class EmptyParticle : System.Xml.Schema.XmlSchemaParticle
                {
                    /*0x76c6960*/ EmptyParticle();
                    /*0x76c69b4*/ bool get_IsEmpty();
                }
            }

            class XmlSchemaRedefine : System.Xml.Schema.XmlSchemaExternal
            {
                /*0x68*/ System.Xml.Schema.XmlSchemaObjectCollection items;
                /*0x70*/ System.Xml.Schema.XmlSchemaObjectTable attributeGroups;
                /*0x78*/ System.Xml.Schema.XmlSchemaObjectTable types;
                /*0x80*/ System.Xml.Schema.XmlSchemaObjectTable groups;

                /*0x76c69bc*/ XmlSchemaRedefine();
                /*0x76c6ab0*/ System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                /*0x76c6ab8*/ System.Xml.Schema.XmlSchemaObjectTable get_AttributeGroups();
                /*0x76c6ac0*/ System.Xml.Schema.XmlSchemaObjectTable get_SchemaTypes();
                /*0x76c6ac8*/ System.Xml.Schema.XmlSchemaObjectTable get_Groups();
                /*0x76c6ad0*/ void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
            }

            class XmlSchemaSequence : System.Xml.Schema.XmlSchemaGroupBase
            {
                /*0x78*/ System.Xml.Schema.XmlSchemaObjectCollection items;

                /*0x76c6b38*/ XmlSchemaSequence();
                /*0x76c6aec*/ System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                /*0x76c6af4*/ bool get_IsEmpty();
                /*0x76c6b30*/ void SetItems(System.Xml.Schema.XmlSchemaObjectCollection newItems);
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

                /*0x76c6c14*/ XmlSchemaSet();
                /*0x76c6c70*/ XmlSchemaSet(System.Xml.XmlNameTable nameTable);
                /*0x76c6ba4*/ object get_InternalSyncObject();
                /*0x76c6f68*/ void add_ValidationEventHandler(System.Xml.Schema.ValidationEventHandler value);
                /*0x76c7078*/ void remove_ValidationEventHandler(System.Xml.Schema.ValidationEventHandler value);
                /*0x76c7130*/ bool get_IsCompiled();
                /*0x76c7138*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x76c7154*/ System.Xml.Schema.XmlSchemaCompilationSettings get_CompilationSettings();
                /*0x76c715c*/ void set_CompilationSettings(System.Xml.Schema.XmlSchemaCompilationSettings value);
                /*0x76c7164*/ int get_Count();
                /*0x76c7188*/ System.Xml.Schema.XmlSchemaObjectTable get_GlobalElements();
                /*0x76c71f4*/ System.Xml.Schema.XmlSchemaObjectTable get_GlobalAttributes();
                /*0x76c7260*/ System.Xml.Schema.XmlSchemaObjectTable get_GlobalTypes();
                /*0x76c72cc*/ System.Xml.Schema.XmlSchemaObjectTable get_SubstitutionGroups();
                /*0x76c7338*/ System.Collections.Hashtable get_SchemaLocations();
                /*0x76c7340*/ System.Xml.Schema.XmlSchemaObjectTable get_TypeExtensions();
                /*0x76c73ac*/ void Add(System.Xml.Schema.XmlSchemaSet schemas);
                /*0x76c9aa4*/ System.Xml.Schema.XmlSchema Add(System.Xml.Schema.XmlSchema schema);
                /*0x76c9c28*/ bool RemoveRecursive(System.Xml.Schema.XmlSchema schemaToRemove);
                /*0x76caa88*/ bool Contains(string targetNamespace);
                /*0x76caad0*/ void Compile();
                /*0x76caff0*/ System.Xml.Schema.XmlSchema Reprocess(System.Xml.Schema.XmlSchema schema);
                /*0x76cca90*/ void CopyTo(System.Xml.Schema.XmlSchema[] schemas, int index);
                /*0x76ccbf4*/ System.Collections.ICollection Schemas();
                /*0x76cc800*/ System.Collections.ICollection Schemas(string targetNamespace);
                /*0x76c9a4c*/ System.Xml.Schema.XmlSchema Add(string targetNamespace, System.Xml.Schema.XmlSchema schema);
                /*0x76ccfac*/ void Add(string targetNamespace, System.Xml.XmlReader reader, System.Collections.Hashtable validatedNamespaces);
                /*0x76c97d8*/ System.Xml.Schema.XmlSchema FindSchemaByNSAndUrl(System.Uri schemaUri, string ns, System.Collections.DictionaryEntry[] locationsTable);
                /*0x76ccc18*/ void AddSchemaToSet(System.Xml.Schema.XmlSchema schema);
                /*0x76cd750*/ void ProcessNewSubstitutionGroups(System.Xml.Schema.XmlSchemaObjectTable substitutionGroupsTable, bool resolve);
                /*0x76cdc28*/ void ResolveSubstitutionGroup(System.Xml.Schema.XmlSchemaSubstitutionGroup substitutionGroup, System.Xml.Schema.XmlSchemaObjectTable substTable);
                /*0x76ca72c*/ System.Xml.Schema.XmlSchema Remove(System.Xml.Schema.XmlSchema schema, bool forceCompile);
                /*0x76caf94*/ void ClearTables();
                /*0x76cc964*/ bool PreprocessSchema(ref System.Xml.Schema.XmlSchema schema, string targetNamespace);
                /*0x76cd5d8*/ System.Xml.Schema.XmlSchema ParseSchema(string targetNamespace, System.Xml.XmlReader reader);
                /*0x76c7cfc*/ void CopyFromCompiledSet(System.Xml.Schema.XmlSchemaSet otherSet);
                /*0x76ce4a0*/ System.Xml.Schema.SchemaInfo get_CompiledInfo();
                /*0x76ce4a8*/ System.Xml.XmlReaderSettings get_ReaderSettings();
                /*0x76ce4b0*/ System.Xml.XmlResolver GetResolver();
                /*0x76ce4cc*/ System.Xml.Schema.ValidationEventHandler GetEventHandler();
                /*0x76ce2d8*/ System.Xml.Schema.SchemaNames GetSchemaNames(System.Xml.XmlNameTable nt);
                /*0x76cd334*/ bool IsSchemaLoaded(System.Uri schemaUri, string targetNamespace, ref System.Xml.Schema.XmlSchema schema);
                /*0x76ce4d4*/ bool GetSchemaByUri(System.Uri schemaUri, ref System.Xml.Schema.XmlSchema schema);
                /*0x76ca65c*/ string GetTargetNamespace(System.Xml.Schema.XmlSchema schema);
                /*0x76ce638*/ System.Collections.SortedList get_SortedSchemas();
                /*0x76cc1f8*/ void RemoveSchemaFromCaches(System.Xml.Schema.XmlSchema schema);
                /*0x76cb768*/ void RemoveSchemaFromGlobalTables(System.Xml.Schema.XmlSchema schema);
                /*0x76ce004*/ bool AddToTable(System.Xml.Schema.XmlSchemaObjectTable table, System.Xml.XmlQualifiedName qname, System.Xml.Schema.XmlSchemaObject item);
                /*0x76ce37c*/ void VerifyTables();
                /*0x76ce640*/ void InternalValidationCallback(object sender, System.Xml.Schema.ValidationEventArgs e);
                /*0x76ca68c*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity);
            }

            class XmlSchemaSimpleContent : System.Xml.Schema.XmlSchemaContentModel
            {
                /*0x50*/ System.Xml.Schema.XmlSchemaContent content;

                /*0x76ce694*/ XmlSchemaSimpleContent();
                /*0x76ce684*/ System.Xml.Schema.XmlSchemaContent get_Content();
                /*0x76ce68c*/ void set_Content(System.Xml.Schema.XmlSchemaContent value);
            }

            class XmlSchemaSimpleContentExtension : System.Xml.Schema.XmlSchemaContent
            {
                /*0x50*/ System.Xml.Schema.XmlSchemaObjectCollection attributes;
                /*0x58*/ System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;
                /*0x60*/ System.Xml.XmlQualifiedName baseTypeName;

                /*0x76ce764*/ XmlSchemaSimpleContentExtension();
                /*0x76ce69c*/ System.Xml.XmlQualifiedName get_BaseTypeName();
                /*0x76ce6a4*/ void set_BaseTypeName(System.Xml.XmlQualifiedName value);
                /*0x76ce744*/ System.Xml.Schema.XmlSchemaObjectCollection get_Attributes();
                /*0x76ce74c*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0x76ce754*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x76ce75c*/ void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes);
            }

            class XmlSchemaSimpleContentRestriction : System.Xml.Schema.XmlSchemaContent
            {
                /*0x50*/ System.Xml.XmlQualifiedName baseTypeName;
                /*0x58*/ System.Xml.Schema.XmlSchemaSimpleType baseType;
                /*0x60*/ System.Xml.Schema.XmlSchemaObjectCollection facets;
                /*0x68*/ System.Xml.Schema.XmlSchemaObjectCollection attributes;
                /*0x70*/ System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;

                /*0x76ce8f4*/ XmlSchemaSimpleContentRestriction();
                /*0x76ce814*/ System.Xml.XmlQualifiedName get_BaseTypeName();
                /*0x76ce81c*/ void set_BaseTypeName(System.Xml.XmlQualifiedName value);
                /*0x76ce8bc*/ System.Xml.Schema.XmlSchemaSimpleType get_BaseType();
                /*0x76ce8c4*/ void set_BaseType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0x76ce8cc*/ System.Xml.Schema.XmlSchemaObjectCollection get_Facets();
                /*0x76ce8d4*/ System.Xml.Schema.XmlSchemaObjectCollection get_Attributes();
                /*0x76ce8dc*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0x76ce8e4*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x76ce8ec*/ void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes);
            }

            class XmlSchemaSimpleType : System.Xml.Schema.XmlSchemaType
            {
                /*0x98*/ System.Xml.Schema.XmlSchemaSimpleTypeContent content;

                /*0x76ce9c0*/ XmlSchemaSimpleType();
                /*0x76cea44*/ System.Xml.Schema.XmlSchemaSimpleTypeContent get_Content();
                /*0x76cea4c*/ void set_Content(System.Xml.Schema.XmlSchemaSimpleTypeContent value);
                /*0x76cea54*/ System.Xml.Schema.XmlSchemaObject Clone();
            }

            class XmlSchemaSimpleTypeContent : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x76ceb60*/ XmlSchemaSimpleTypeContent();
            }

            class XmlSchemaSimpleTypeList : System.Xml.Schema.XmlSchemaSimpleTypeContent
            {
                /*0x50*/ System.Xml.XmlQualifiedName itemTypeName;
                /*0x58*/ System.Xml.Schema.XmlSchemaSimpleType itemType;
                /*0x60*/ System.Xml.Schema.XmlSchemaSimpleType baseItemType;

                /*0x76cece0*/ XmlSchemaSimpleTypeList();
                /*0x76ceb68*/ System.Xml.XmlQualifiedName get_ItemTypeName();
                /*0x76ceb70*/ void set_ItemTypeName(System.Xml.XmlQualifiedName value);
                /*0x76cec10*/ System.Xml.Schema.XmlSchemaSimpleType get_ItemType();
                /*0x76cec18*/ void set_ItemType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0x76cec20*/ System.Xml.Schema.XmlSchemaSimpleType get_BaseItemType();
                /*0x76cec28*/ void set_BaseItemType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0x76cec30*/ System.Xml.Schema.XmlSchemaObject Clone();
            }

            class XmlSchemaSimpleTypeRestriction : System.Xml.Schema.XmlSchemaSimpleTypeContent
            {
                /*0x50*/ System.Xml.XmlQualifiedName baseTypeName;
                /*0x58*/ System.Xml.Schema.XmlSchemaSimpleType baseType;
                /*0x60*/ System.Xml.Schema.XmlSchemaObjectCollection facets;

                /*0x76ceec0*/ XmlSchemaSimpleTypeRestriction();
                /*0x76ced50*/ System.Xml.XmlQualifiedName get_BaseTypeName();
                /*0x76ced58*/ void set_BaseTypeName(System.Xml.XmlQualifiedName value);
                /*0x76cedf8*/ System.Xml.Schema.XmlSchemaSimpleType get_BaseType();
                /*0x76cee00*/ void set_BaseType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0x76cee08*/ System.Xml.Schema.XmlSchemaObjectCollection get_Facets();
                /*0x76cee10*/ System.Xml.Schema.XmlSchemaObject Clone();
            }

            class XmlSchemaSimpleTypeUnion : System.Xml.Schema.XmlSchemaSimpleTypeContent
            {
                /*0x50*/ System.Xml.Schema.XmlSchemaObjectCollection baseTypes;
                /*0x58*/ System.Xml.XmlQualifiedName[] memberTypes;
                /*0x60*/ System.Xml.Schema.XmlSchemaSimpleType[] baseMemberTypes;

                /*0x76cf110*/ XmlSchemaSimpleTypeUnion();
                /*0x76cef68*/ System.Xml.Schema.XmlSchemaObjectCollection get_BaseTypes();
                /*0x76cef70*/ System.Xml.XmlQualifiedName[] get_MemberTypes();
                /*0x76cef78*/ void set_MemberTypes(System.Xml.XmlQualifiedName[] value);
                /*0x76cef80*/ System.Xml.Schema.XmlSchemaSimpleType[] get_BaseMemberTypes();
                /*0x76cef88*/ void SetBaseMemberTypes(System.Xml.Schema.XmlSchemaSimpleType[] baseMemberTypes);
                /*0x76cef90*/ System.Xml.Schema.XmlSchemaObject Clone();
            }

            class XmlSchemaSubstitutionGroup : System.Xml.Schema.XmlSchemaObject
            {
                /*0x38*/ System.Collections.ArrayList membersList;
                /*0x40*/ System.Xml.XmlQualifiedName examplar;

                /*0x76cf194*/ XmlSchemaSubstitutionGroup();
                /*0x76cf17c*/ System.Collections.ArrayList get_Members();
                /*0x76cf184*/ System.Xml.XmlQualifiedName get_Examplar();
                /*0x76cf18c*/ void set_Examplar(System.Xml.XmlQualifiedName value);
            }

            class XmlSchemaSubstitutionGroupV1Compat : System.Xml.Schema.XmlSchemaSubstitutionGroup
            {
                /*0x48*/ System.Xml.Schema.XmlSchemaChoice choice;

                /*0x76cf24c*/ XmlSchemaSubstitutionGroupV1Compat();
                /*0x76cf244*/ System.Xml.Schema.XmlSchemaChoice get_Choice();
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

                static /*0x76cf2b4*/ System.Xml.Schema.XmlSchemaSimpleType GetBuiltInSimpleType(System.Xml.XmlQualifiedName qualifiedName);
                static /*0x76cf38c*/ System.Xml.Schema.XmlSchemaSimpleType GetBuiltInSimpleType(System.Xml.Schema.XmlTypeCode typeCode);
                static /*0x76cf3e4*/ System.Xml.Schema.XmlSchemaComplexType GetBuiltInComplexType(System.Xml.XmlQualifiedName qualifiedName);
                static /*0x76cf854*/ bool IsDerivedFrom(System.Xml.Schema.XmlSchemaType derivedType, System.Xml.Schema.XmlSchemaType baseType, System.Xml.Schema.XmlSchemaDerivationMethod except);
                static /*0x76cfa4c*/ bool IsDerivedFromDatatype(System.Xml.Schema.XmlSchemaDatatype derivedDataType, System.Xml.Schema.XmlSchemaDatatype baseDataType, System.Xml.Schema.XmlSchemaDerivationMethod except);
                /*0x76ce9c4*/ XmlSchemaType();
                /*0x76cf62c*/ string get_Name();
                /*0x76cf634*/ void set_Name(string value);
                /*0x76cf63c*/ System.Xml.Schema.XmlSchemaDerivationMethod get_Final();
                /*0x76cf644*/ void set_Final(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x76ce488*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0x76cf64c*/ System.Xml.Schema.XmlSchemaDerivationMethod get_FinalResolved();
                /*0x76cf654*/ System.Xml.Schema.XmlSchemaType get_BaseXmlSchemaType();
                /*0x76cf65c*/ System.Xml.Schema.XmlSchemaDerivationMethod get_DerivedBy();
                /*0x76cf664*/ System.Xml.Schema.XmlSchemaDatatype get_Datatype();
                /*0x76cf66c*/ bool get_IsMixed();
                /*0x76cf674*/ void set_IsMixed(bool value);
                /*0x76cf678*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x76cf72c*/ System.Xml.Schema.XmlValueConverter get_ValueConverter();
                /*0x76cf7a4*/ System.Xml.Schema.XmlSchemaContentType get_SchemaContentType();
                /*0x76cf7ac*/ void SetQualifiedName(System.Xml.XmlQualifiedName value);
                /*0x76cf7d8*/ void SetFinalResolved(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x76cf7e0*/ void SetBaseSchemaType(System.Xml.Schema.XmlSchemaType value);
                /*0x76cf7e8*/ void SetDerivedBy(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x76cf7f0*/ void SetDatatype(System.Xml.Schema.XmlSchemaDatatype value);
                /*0x76cf7f8*/ System.Xml.Schema.SchemaElementDecl get_ElementDecl();
                /*0x76cf810*/ void set_ElementDecl(System.Xml.Schema.SchemaElementDecl value);
                /*0x76cf83c*/ System.Xml.Schema.XmlSchemaType get_Redefined();
                /*0x76cf844*/ void set_Redefined(System.Xml.Schema.XmlSchemaType value);
                /*0x76cf84c*/ void SetContentType(System.Xml.Schema.XmlSchemaContentType value);
                /*0x76cfb20*/ string get_NameAttribute();
                /*0x76cfb28*/ void set_NameAttribute(string value);
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
                /*0x76cfb30*/ XmlSchemaValidationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x76cfb40*/ XmlSchemaValidationException();
                /*0x76cfb4c*/ XmlSchemaValidationException(string res, string arg, string sourceUri, int lineNumber, int linePosition);
                /*0x76cfc1c*/ XmlSchemaValidationException(string res, string[] args, string sourceUri, int lineNumber, int linePosition);
                /*0x76cfc4c*/ XmlSchemaValidationException(string res, string[] args, System.Exception innerException, string sourceUri, int lineNumber, int linePosition);
                /*0x76cfb38*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            class XmlValueGetter : System.MulticastDelegate
            {
                /*0x76cfc6c*/ XmlValueGetter(object object, nint method);
                /*0x76cfd08*/ object Invoke();
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

                /*0x76cfd1c*/ IdRefNode(System.Xml.Schema.IdRefNode next, string id, int lineNo, int linePos);
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

                static /*0x76da544*/ XmlSchemaValidator();
                static /*0x76d82f0*/ void ElementValidationError(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, System.Xml.Schema.ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, System.Xml.Schema.XmlSchemaSet schemaSet);
                static /*0x76d69f0*/ void CompleteValidationError(System.Xml.Schema.ValidationState context, System.Xml.Schema.ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, System.Xml.Schema.XmlSchemaSet schemaSet);
                static /*0x76d4884*/ string PrintExpectedElements(System.Collections.ArrayList expected, bool getParticles);
                static /*0x76da188*/ string PrintNames(System.Collections.ArrayList expected);
                static /*0x76d9cd0*/ void PrintNamesWithNS(System.Collections.ArrayList expected, System.Text.StringBuilder builder);
                static /*0x76da304*/ void EnumerateAny(System.Text.StringBuilder builder, string namespaces);
                static /*0x76d4680*/ string QNameString(string localName, string ns);
                static /*0x76d8098*/ string BuildElementName(System.Xml.XmlQualifiedName qname);
                static /*0x76d4734*/ string BuildElementName(string localName, string ns);
                static /*0x76d9c1c*/ void SendValidationEvent(System.Xml.Schema.ValidationEventHandler eventHandler, object sender, System.Xml.Schema.XmlSchemaValidationException e, System.Xml.Schema.XmlSeverityType severity);
                /*0x76cfd74*/ XmlSchemaValidator(System.Xml.XmlNameTable nameTable, System.Xml.Schema.XmlSchemaSet schemas, System.Xml.IXmlNamespaceResolver namespaceResolver, System.Xml.Schema.XmlSchemaValidationFlags validationFlags);
                /*0x76cffa4*/ void Init();
                /*0x76d04b8*/ void Reset();
                /*0x76d0634*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x76d063c*/ void set_LineInfoProvider(System.Xml.IXmlLineInfo value);
                /*0x76d064c*/ void set_SourceUri(System.Uri value);
                /*0x76d0698*/ void set_ValidationEventSender(object value);
                /*0x76d06a0*/ void add_ValidationEventHandler(System.Xml.Schema.ValidationEventHandler value);
                /*0x76d0730*/ void remove_ValidationEventHandler(System.Xml.Schema.ValidationEventHandler value);
                /*0x76d07c0*/ void AddSchema(System.Xml.Schema.XmlSchema schema);
                /*0x76d0f14*/ void Initialize();
                /*0x76d1054*/ void Initialize(System.Xml.Schema.XmlSchemaObject partialValidationType);
                /*0x76d12f4*/ void ValidateElement(string localName, string namespaceUri, System.Xml.Schema.XmlSchemaInfo schemaInfo, string xsiType, string xsiNil, string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation);
                /*0x76d2ba4*/ object ValidateAttribute(string localName, string namespaceUri, System.Xml.Schema.XmlValueGetter attributeValue, System.Xml.Schema.XmlSchemaInfo schemaInfo);
                /*0x76d2c00*/ object ValidateAttribute(string lName, string ns, System.Xml.Schema.XmlValueGetter attributeValueGetter, string attributeStringValue, System.Xml.Schema.XmlSchemaInfo schemaInfo);
                /*0x76d4010*/ void ValidateEndOfAttributes(System.Xml.Schema.XmlSchemaInfo schemaInfo);
                /*0x76d42dc*/ void ValidateText(System.Xml.Schema.XmlValueGetter elementValue);
                /*0x76d4338*/ void ValidateText(string elementStringValue, System.Xml.Schema.XmlValueGetter elementValueGetter);
                /*0x76d4c64*/ void ValidateWhitespace(System.Xml.Schema.XmlValueGetter elementValue);
                /*0x76d4cc0*/ void ValidateWhitespace(string elementStringValue, System.Xml.Schema.XmlValueGetter elementValueGetter);
                /*0x76d4e80*/ object ValidateEndElement(System.Xml.Schema.XmlSchemaInfo schemaInfo);
                /*0x76d5374*/ void SkipToEndElement(System.Xml.Schema.XmlSchemaInfo schemaInfo);
                /*0x76d56ac*/ void EndValidation();
                /*0x76d58a0*/ void GetUnspecifiedDefaultAttributes(System.Collections.ArrayList defaultAttributes, bool createNodeData);
                /*0x76d626c*/ System.Xml.Schema.XmlSchemaSet get_SchemaSet();
                /*0x76d6274*/ System.Xml.Schema.XmlSchemaValidationFlags get_ValidationFlags();
                /*0x76d627c*/ System.Xml.Schema.XmlSchemaContentType get_CurrentContentType();
                /*0x76d62b0*/ void SetDtdSchemaInfo(System.Xml.IDtdInfo dtdSchemaInfo);
                /*0x76d62d4*/ bool get_StrictlyAssessed();
                /*0x76d6318*/ bool get_HasSchema();
                /*0x76d6360*/ string GetConcatenatedValue();
                /*0x76d4e88*/ object InternalValidateEndElement(System.Xml.Schema.XmlSchemaInfo schemaInfo, object typedValue);
                /*0x76d1f2c*/ void ProcessSchemaLocations(string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation);
                /*0x76d18b8*/ object ValidateElementContext(System.Xml.XmlQualifiedName elementName, ref bool invalidElementInContext);
                /*0x76d7eac*/ System.Xml.Schema.XmlSchemaElement GetSubstitutionGroupHead(System.Xml.XmlQualifiedName member);
                /*0x76d6380*/ object ValidateAtomicValue(string stringValue, ref System.Xml.Schema.XmlSchemaSimpleType memberType);
                /*0x76d6604*/ object ValidateAtomicValue(object parsedValue, ref System.Xml.Schema.XmlSchemaSimpleType memberType);
                /*0x76d8c00*/ string GetTypeName(System.Xml.Schema.SchemaDeclBase decl);
                /*0x76d46f4*/ void SaveTextValue(object value);
                /*0x76d0364*/ void Push(System.Xml.XmlQualifiedName elementName);
                /*0x76d557c*/ void Pop();
                /*0x76d1ce8*/ System.Xml.Schema.SchemaElementDecl FastGetElementDecl(System.Xml.XmlQualifiedName elementName, object particle);
                /*0x76d2248*/ System.Xml.Schema.SchemaElementDecl CheckXsiTypeAndNil(System.Xml.Schema.SchemaElementDecl elementDecl, string xsiType, string xsiNil, ref bool declFound);
                /*0x76d282c*/ void ThrowDeclNotFoundWarningOrError(bool declFound);
                /*0x76d296c*/ void CheckElementProperties();
                /*0x76d2a20*/ void ValidateStartElementIdentityConstraints();
                /*0x76d373c*/ System.Xml.Schema.SchemaAttDef CheckIsXmlAttribute(System.Xml.XmlQualifiedName attQName);
                /*0x76d9440*/ void AddXmlNamespaceSchema();
                /*0x76d6914*/ object CheckMixedValueConstraint(string elementValue);
                /*0x76d79a8*/ void LoadSchema(string uri, string url);
                /*0x76d0560*/ void RecompileSchemaSet();
                /*0x76d9690*/ void ProcessTokenizedType(System.Xml.XmlTokenizedType ttype, string name, bool attrValue);
                /*0x76d3990*/ object CheckAttributeValue(object value, System.Xml.Schema.SchemaAttDef attdef);
                /*0x76d89e4*/ object CheckElementValue(string stringValue);
                /*0x76d3bcc*/ void CheckTokenizedTypes(System.Xml.Schema.XmlSchemaDatatype dtype, object typedValue, bool attrValue);
                /*0x76d995c*/ object FindId(string name);
                /*0x76d5798*/ void CheckForwardRefs();
                /*0x76d3d4c*/ bool get_HasIdentityConstraints();
                /*0x76d8c80*/ bool get_ProcessIdentityConstraints();
                /*0x76d9c08*/ bool get_ReportValidationWarnings();
                /*0x76d0624*/ bool get_ProcessSchemaHints();
                /*0x76d1654*/ void CheckStateTransition(System.Xml.Schema.ValidatorState toState, string methodName);
                /*0x76d186c*/ void ClearPSVI();
                /*0x76d40d8*/ void CheckRequiredAttributes(System.Xml.Schema.SchemaElementDecl currentElementDecl);
                /*0x76d2a7c*/ System.Xml.Schema.XmlSchemaElement GetSchemaElement();
                /*0x76d5ea0*/ string GetDefaultAttributePrefix(string attributeNS);
                /*0x76d8c8c*/ void AddIdentityConstraints();
                /*0x76d9090*/ void ElementIdentityConstraints();
                /*0x76d3d6c*/ void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x76d6e14*/ void EndElementIdentityConstraints(object typedValue, string stringValue, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x76d9978*/ void ProcessEntity(string name);
                /*0x76d8c68*/ void SendValidationEvent(string code);
                /*0x76d3804*/ void SendValidationEvent(string code, string[] args);
                /*0x76d35c4*/ void SendValidationEvent(string code, string arg);
                /*0x76d80fc*/ void SendValidationEvent(string code, string arg1, string arg2);
                /*0x76d94c8*/ void SendValidationEvent(string code, string[] args, System.Exception innerException, System.Xml.Schema.XmlSeverityType severity);
                /*0x76d0d7c*/ void SendValidationEvent(string code, string[] args, System.Exception innerException);
                /*0x76d9c14*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaValidationException e);
                /*0x76d7e00*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e);
                /*0x76d0bd0*/ void SendValidationEvent(string code, string msg, System.Xml.Schema.XmlSeverityType severity);
                /*0x76d9aec*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaValidationException e, System.Xml.Schema.XmlSeverityType severity);
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
                /*0x76da9a4*/ XmlValueConverter();
                bool ToBoolean(long value);
                /*0x380b228*/ bool ToBoolean(int value);
                bool ToBoolean(double value);
                bool ToBoolean(System.DateTime value);
                /*0x380b2f0*/ bool ToBoolean(string value);
                /*0x380b2f0*/ bool ToBoolean(object value);
                int ToInt32(bool value);
                int ToInt32(long value);
                int ToInt32(double value);
                int ToInt32(System.DateTime value);
                /*0x380b7a8*/ int ToInt32(string value);
                /*0x380b7a8*/ int ToInt32(object value);
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
                /*0x380ba90*/ string ToString(int value);
                string ToString(long value);
                string ToString(decimal value);
                string ToString(float value);
                string ToString(double value);
                string ToString(System.DateTime value);
                string ToString(System.DateTimeOffset value);
                /*0x380bb68*/ string ToString(object value);
                /*0x380bcbc*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                object ChangeType(bool value, System.Type destinationType);
                object ChangeType(int value, System.Type destinationType);
                object ChangeType(long value, System.Type destinationType);
                object ChangeType(decimal value, System.Type destinationType);
                object ChangeType(double value, System.Type destinationType);
                object ChangeType(System.DateTime value, System.Type destinationType);
                /*0x380bd40*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x380bcbc*/ object ChangeType(object value, System.Type destinationType);
                /*0x380bd40*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
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

                static /*0x76e01fc*/ XmlBaseConverter();
                static /*0x76dd860*/ bool IsDerivedFrom(System.Type derivedType, System.Type baseType);
                static /*0x76dd738*/ string QNameToString(System.Xml.XmlQualifiedName name);
                static /*0x76ddbd8*/ byte[] StringToBase64Binary(string value);
                static /*0x76ddc68*/ System.DateTime StringToDate(string value);
                static /*0x76ddce4*/ System.DateTime StringToDateTime(string value);
                static /*0x76ddd60*/ System.TimeSpan StringToDayTimeDuration(string value);
                static /*0x76dddc0*/ System.TimeSpan StringToDuration(string value);
                static /*0x76dde20*/ System.DateTime StringToGDay(string value);
                static /*0x76dde9c*/ System.DateTime StringToGMonth(string value);
                static /*0x76ddf18*/ System.DateTime StringToGMonthDay(string value);
                static /*0x76ddf94*/ System.DateTime StringToGYear(string value);
                static /*0x76de010*/ System.DateTime StringToGYearMonth(string value);
                static /*0x76de08c*/ System.DateTimeOffset StringToDateOffset(string value);
                static /*0x76de108*/ System.DateTimeOffset StringToDateTimeOffset(string value);
                static /*0x76de184*/ System.DateTimeOffset StringToGDayOffset(string value);
                static /*0x76de200*/ System.DateTimeOffset StringToGMonthOffset(string value);
                static /*0x76de27c*/ System.DateTimeOffset StringToGMonthDayOffset(string value);
                static /*0x76de2f8*/ System.DateTimeOffset StringToGYearOffset(string value);
                static /*0x76de374*/ System.DateTimeOffset StringToGYearMonthOffset(string value);
                static /*0x76de3f0*/ byte[] StringToHexBinary(string value);
                static /*0x76de524*/ System.Xml.XmlQualifiedName StringToQName(string value, System.Xml.IXmlNamespaceResolver nsResolver);
                static /*0x76de7d4*/ System.DateTime StringToTime(string value);
                static /*0x76de850*/ System.DateTimeOffset StringToTimeOffset(string value);
                static /*0x76de8cc*/ System.TimeSpan StringToYearMonthDuration(string value);
                static /*0x76de92c*/ string AnyUriToString(System.Uri value);
                static /*0x76de940*/ string Base64BinaryToString(byte[] value);
                static /*0x76de998*/ string DateToString(System.DateTime value);
                static /*0x76dea20*/ string DateTimeToString(System.DateTime value);
                static /*0x76deaa8*/ string DayTimeDurationToString(System.TimeSpan value);
                static /*0x76deb08*/ string DurationToString(System.TimeSpan value);
                static /*0x76deb68*/ string GDayToString(System.DateTime value);
                static /*0x76debf0*/ string GMonthToString(System.DateTime value);
                static /*0x76dec78*/ string GMonthDayToString(System.DateTime value);
                static /*0x76ded00*/ string GYearToString(System.DateTime value);
                static /*0x76ded88*/ string GYearMonthToString(System.DateTime value);
                static /*0x76dee10*/ string DateOffsetToString(System.DateTimeOffset value);
                static /*0x76deea8*/ string DateTimeOffsetToString(System.DateTimeOffset value);
                static /*0x76def40*/ string GDayOffsetToString(System.DateTimeOffset value);
                static /*0x76defd8*/ string GMonthOffsetToString(System.DateTimeOffset value);
                static /*0x76df070*/ string GMonthDayOffsetToString(System.DateTimeOffset value);
                static /*0x76df108*/ string GYearOffsetToString(System.DateTimeOffset value);
                static /*0x76df1a0*/ string GYearMonthOffsetToString(System.DateTimeOffset value);
                static /*0x76df238*/ string QNameToString(System.Xml.XmlQualifiedName qname, System.Xml.IXmlNamespaceResolver nsResolver);
                static /*0x76df44c*/ string TimeToString(System.DateTime value);
                static /*0x76df4d4*/ string TimeOffsetToString(System.DateTimeOffset value);
                static /*0x76df56c*/ string YearMonthDurationToString(System.TimeSpan value);
                static /*0x76df5cc*/ System.DateTime DateTimeOffsetToDateTime(System.DateTimeOffset value);
                static /*0x76df630*/ int DecimalToInt32(decimal value);
                static /*0x76df808*/ long DecimalToInt64(decimal value);
                static /*0x76df9e0*/ ulong DecimalToUInt64(decimal value);
                static /*0x76dfbac*/ byte Int32ToByte(int value);
                static /*0x76dfc90*/ short Int32ToInt16(int value);
                static /*0x76dfd74*/ sbyte Int32ToSByte(int value);
                static /*0x76dfe58*/ ushort Int32ToUInt16(int value);
                static /*0x76dff3c*/ int Int64ToInt32(long value);
                static /*0x76e0020*/ uint Int64ToUInt32(long value);
                static /*0x76e0104*/ System.DateTime UntypedAtomicToDateTime(string value);
                static /*0x76e0180*/ System.DateTimeOffset UntypedAtomicToDateTimeOffset(string value);
                /*0x76da9ac*/ XmlBaseConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x76daa94*/ XmlBaseConverter(System.Xml.Schema.XmlTypeCode typeCode);
                /*0x76dab78*/ XmlBaseConverter(System.Xml.Schema.XmlBaseConverter converterAtomic);
                /*0x76dabe8*/ XmlBaseConverter(System.Xml.Schema.XmlBaseConverter converterAtomic, System.Type clrTypeDefault);
                /*0x76dac3c*/ bool ToBoolean(System.DateTime value);
                /*0x76dad28*/ bool ToBoolean(double value);
                /*0x76dae08*/ bool ToBoolean(int value);
                /*0x76daed8*/ bool ToBoolean(long value);
                /*0x76dafa8*/ bool ToBoolean(string value);
                /*0x76db060*/ bool ToBoolean(object value);
                /*0x76db118*/ System.DateTime ToDateTime(bool value);
                /*0x76db200*/ System.DateTime ToDateTime(System.DateTimeOffset value);
                /*0x76db304*/ System.DateTime ToDateTime(double value);
                /*0x76db3e8*/ System.DateTime ToDateTime(int value);
                /*0x76db4cc*/ System.DateTime ToDateTime(long value);
                /*0x76db5b0*/ System.DateTime ToDateTime(string value);
                /*0x76db674*/ System.DateTime ToDateTime(object value);
                /*0x76db738*/ System.DateTimeOffset ToDateTimeOffset(System.DateTime value);
                /*0x76db834*/ System.DateTimeOffset ToDateTimeOffset(string value);
                /*0x76db8fc*/ System.DateTimeOffset ToDateTimeOffset(object value);
                /*0x76db9c4*/ decimal ToDecimal(string value);
                /*0x76dba8c*/ decimal ToDecimal(object value);
                /*0x76dbb54*/ double ToDouble(bool value);
                /*0x76dbc28*/ double ToDouble(System.DateTime value);
                /*0x76dbd14*/ double ToDouble(int value);
                /*0x76dbde4*/ double ToDouble(long value);
                /*0x76dbeb4*/ double ToDouble(string value);
                /*0x76dbf6c*/ double ToDouble(object value);
                /*0x76dc024*/ int ToInt32(bool value);
                /*0x76dc0f8*/ int ToInt32(System.DateTime value);
                /*0x76dc1e4*/ int ToInt32(double value);
                /*0x76dc2c4*/ int ToInt32(long value);
                /*0x76dc394*/ int ToInt32(string value);
                /*0x76dc44c*/ int ToInt32(object value);
                /*0x76dc504*/ long ToInt64(bool value);
                /*0x76dc5d8*/ long ToInt64(System.DateTime value);
                /*0x76dc6c4*/ long ToInt64(double value);
                /*0x76dc7a4*/ long ToInt64(int value);
                /*0x76dc874*/ long ToInt64(string value);
                /*0x76dc92c*/ long ToInt64(object value);
                /*0x76dc9e4*/ float ToSingle(double value);
                /*0x76dcac4*/ float ToSingle(string value);
                /*0x76dcb7c*/ float ToSingle(object value);
                /*0x76dcc34*/ string ToString(bool value);
                /*0x76dccf4*/ string ToString(System.DateTime value);
                /*0x76dcdcc*/ string ToString(System.DateTimeOffset value);
                /*0x76dceb0*/ string ToString(decimal value);
                /*0x76dcfb4*/ string ToString(double value);
                /*0x76dd080*/ string ToString(int value);
                /*0x76dd13c*/ string ToString(long value);
                /*0x76dd1f8*/ string ToString(float value);
                /*0x76dd2c4*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76dd36c*/ string ToString(object value);
                /*0x76dd380*/ object ChangeType(bool value, System.Type destinationType);
                /*0x76dd3d8*/ object ChangeType(System.DateTime value, System.Type destinationType);
                /*0x76dd460*/ object ChangeType(decimal value, System.Type destinationType);
                /*0x76dd514*/ object ChangeType(double value, System.Type destinationType);
                /*0x76dd568*/ object ChangeType(int value, System.Type destinationType);
                /*0x76dd5bc*/ object ChangeType(long value, System.Type destinationType);
                /*0x76dd610*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76dd620*/ object ChangeType(object value, System.Type destinationType);
                /*0x76dd634*/ System.Xml.Schema.XmlSchemaType get_SchemaType();
                /*0x76dd63c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x76dd644*/ string get_XmlTypeName();
                /*0x76dd858*/ System.Type get_DefaultClrType();
                /*0x76dd900*/ System.Exception CreateInvalidClrMappingException(System.Type sourceType, System.Type destinationType);
                /*0x76ddb84*/ object ChangeListType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlNumeric10Converter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0x76e0864*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x76e07fc*/ XmlNumeric10Converter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x76e08bc*/ decimal ToDecimal(string value);
                /*0x76e0980*/ decimal ToDecimal(object value);
                /*0x76e110c*/ int ToInt32(long value);
                /*0x76e1164*/ int ToInt32(string value);
                /*0x76e1264*/ int ToInt32(object value);
                /*0x76e1604*/ long ToInt64(int value);
                /*0x76e160c*/ long ToInt64(string value);
                /*0x76e170c*/ long ToInt64(object value);
                /*0x76e1a90*/ string ToString(decimal value);
                /*0x76e1b4c*/ string ToString(int value);
                /*0x76e1ba4*/ string ToString(long value);
                /*0x76e1bfc*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76e1fac*/ object ChangeType(decimal value, System.Type destinationType);
                /*0x76e27a4*/ object ChangeType(int value, System.Type destinationType);
                /*0x76e2b84*/ object ChangeType(long value, System.Type destinationType);
                /*0x76e2f74*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76e3368*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76e0d30*/ object ChangeTypeWildcardDestination(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76e23bc*/ object ChangeTypeWildcardSource(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlNumeric2Converter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0x76e41e4*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x76e417c*/ XmlNumeric2Converter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x76e423c*/ double ToDouble(string value);
                /*0x76e4308*/ double ToDouble(object value);
                /*0x76e45fc*/ float ToSingle(double value);
                /*0x76e4604*/ float ToSingle(string value);
                /*0x76e46d0*/ float ToSingle(object value);
                /*0x76e49cc*/ string ToString(double value);
                /*0x76e4a80*/ string ToString(float value);
                /*0x76e4b08*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76e4e00*/ object ChangeType(double value, System.Type destinationType);
                /*0x76e5124*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76e5484*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlDateTimeConverter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0x76e5b68*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x76e5b00*/ XmlDateTimeConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x76e5bc0*/ System.DateTime ToDateTime(System.DateTimeOffset value);
                /*0x76e5c28*/ System.DateTime ToDateTime(string value);
                /*0x76e5e2c*/ System.DateTime ToDateTime(object value);
                /*0x76e616c*/ System.DateTimeOffset ToDateTimeOffset(System.DateTime value);
                /*0x76e6194*/ System.DateTimeOffset ToDateTimeOffset(string value);
                /*0x76e6398*/ System.DateTimeOffset ToDateTimeOffset(object value);
                /*0x76e66e4*/ string ToString(System.DateTime value);
                /*0x76e689c*/ string ToString(System.DateTimeOffset value);
                /*0x76e6a9c*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76e6dbc*/ object ChangeType(System.DateTime value, System.Type destinationType);
                /*0x76e7138*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76e74bc*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlBooleanConverter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0x76e7c10*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x76e7ba8*/ XmlBooleanConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x76e7c68*/ bool ToBoolean(string value);
                /*0x76e7d0c*/ bool ToBoolean(object value);
                /*0x76e7fb0*/ string ToString(bool value);
                /*0x76e8008*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76e828c*/ object ChangeType(bool value, System.Type destinationType);
                /*0x76e8584*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76e8898*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlMiscConverter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0x76e8e50*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x76e8de8*/ XmlMiscConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x76e8ea8*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76e94f4*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76e9b44*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76e93c4*/ object ChangeTypeWildcardDestination(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76e99ec*/ object ChangeTypeWildcardSource(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlStringConverter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0x76ea880*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x76ea818*/ XmlStringConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x76ea8d8*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76eaab8*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76ead2c*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlUntypedConverter : System.Xml.Schema.XmlListConverter
            {
                static /*0x0*/ System.Xml.Schema.XmlValueConverter Untyped;
                static /*0x8*/ System.Xml.Schema.XmlValueConverter UntypedList;
                /*0x30*/ bool allowListToList;

                static /*0x76f1850*/ XmlUntypedConverter();
                /*0x76eb130*/ XmlUntypedConverter();
                /*0x76eb228*/ XmlUntypedConverter(System.Xml.Schema.XmlUntypedConverter atomicConverter, bool allowListToList);
                /*0x76eb334*/ bool ToBoolean(string value);
                /*0x76eb3d8*/ bool ToBoolean(object value);
                /*0x76eb6ac*/ System.DateTime ToDateTime(string value);
                /*0x76eb750*/ System.DateTime ToDateTime(object value);
                /*0x76eb8f0*/ System.DateTimeOffset ToDateTimeOffset(string value);
                /*0x76eb994*/ System.DateTimeOffset ToDateTimeOffset(object value);
                /*0x76ebb30*/ decimal ToDecimal(string value);
                /*0x76ebbd4*/ decimal ToDecimal(object value);
                /*0x76ebd88*/ double ToDouble(string value);
                /*0x76ebe2c*/ double ToDouble(object value);
                /*0x76ebfd0*/ int ToInt32(string value);
                /*0x76ec074*/ int ToInt32(object value);
                /*0x76ec218*/ long ToInt64(string value);
                /*0x76ec2bc*/ long ToInt64(object value);
                /*0x76ec460*/ float ToSingle(string value);
                /*0x76ec504*/ float ToSingle(object value);
                /*0x76ec6a8*/ string ToString(bool value);
                /*0x76ec700*/ string ToString(System.DateTime value);
                /*0x76ec758*/ string ToString(System.DateTimeOffset value);
                /*0x76ec7c0*/ string ToString(decimal value);
                /*0x76ec828*/ string ToString(double value);
                /*0x76ec888*/ string ToString(int value);
                /*0x76ec8e0*/ string ToString(long value);
                /*0x76ec938*/ string ToString(float value);
                /*0x76ec998*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76ed648*/ object ChangeType(bool value, System.Type destinationType);
                /*0x76ed98c*/ object ChangeType(System.DateTime value, System.Type destinationType);
                /*0x76edb48*/ object ChangeType(decimal value, System.Type destinationType);
                /*0x76edd44*/ object ChangeType(double value, System.Type destinationType);
                /*0x76edf00*/ object ChangeType(int value, System.Type destinationType);
                /*0x76ee0bc*/ object ChangeType(long value, System.Type destinationType);
                /*0x76ee278*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76eedf8*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76eb57c*/ object ChangeTypeWildcardDestination(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76ed808*/ object ChangeTypeWildcardSource(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76f0260*/ object ChangeListType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76f0554*/ bool SupportsType(System.Type clrType);
            }

            class XmlAnyConverter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0x0*/ System.Xml.Schema.XmlValueConverter Item;
                static /*0x8*/ System.Xml.Schema.XmlValueConverter AnyAtomic;

                static /*0x76f4af4*/ XmlAnyConverter();
                /*0x76f1908*/ XmlAnyConverter(System.Xml.Schema.XmlTypeCode typeCode);
                /*0x76f1970*/ bool ToBoolean(object value);
                /*0x76f1c3c*/ System.DateTime ToDateTime(object value);
                /*0x76f1de0*/ System.DateTimeOffset ToDateTimeOffset(object value);
                /*0x76f1f90*/ decimal ToDecimal(object value);
                /*0x76f2140*/ double ToDouble(object value);
                /*0x76f22dc*/ int ToInt32(object value);
                /*0x76f2478*/ long ToInt64(object value);
                /*0x76f2614*/ float ToSingle(object value);
                /*0x76f27b8*/ object ChangeType(bool value, System.Type destinationType);
                /*0x76f2ae0*/ object ChangeType(System.DateTime value, System.Type destinationType);
                /*0x76f2cc0*/ object ChangeType(decimal value, System.Type destinationType);
                /*0x76f2ef0*/ object ChangeType(double value, System.Type destinationType);
                /*0x76f30bc*/ object ChangeType(int value, System.Type destinationType);
                /*0x76f3288*/ object ChangeType(long value, System.Type destinationType);
                /*0x76f3454*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76f3640*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76f1b0c*/ object ChangeTypeWildcardDestination(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76f2988*/ object ChangeTypeWildcardSource(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76f4a6c*/ System.Xml.XPath.XPathNavigator ToNavigator(System.Xml.XPath.XPathNavigator nav);
            }

            class XmlAnyListConverter : System.Xml.Schema.XmlListConverter
            {
                static /*0x0*/ System.Xml.Schema.XmlValueConverter ItemList;
                static /*0x8*/ System.Xml.Schema.XmlValueConverter AnyAtomicList;

                static /*0x76f4e50*/ XmlAnyListConverter();
                /*0x76f4b84*/ XmlAnyListConverter(System.Xml.Schema.XmlBaseConverter atomicConverter);
                /*0x76f4c00*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlListConverter : System.Xml.Schema.XmlBaseConverter
            {
                /*0x28*/ System.Xml.Schema.XmlValueConverter atomicConverter;

                static /*0x76f4fb0*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlValueConverter atomicConverter);
                /*0x76f4b88*/ XmlListConverter(System.Xml.Schema.XmlBaseConverter atomicConverter);
                /*0x76eb2b4*/ XmlListConverter(System.Xml.Schema.XmlBaseConverter atomicConverter, System.Type clrTypeDefault);
                /*0x76eb1c0*/ XmlListConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x76f515c*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76f0a78*/ object ChangeListType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76f523c*/ bool IsListType(System.Type type);
                /*0x380bcbc*/ T[] ToArray<T>(object list, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76f5aac*/ System.Collections.IList ToList(object list, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76f5a04*/ System.Collections.Generic.List<string> StringAsList(string value);
                /*0x76f564c*/ string ListAsString(System.Collections.IEnumerable list, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x76f53c0*/ System.Exception CreateInvalidClrMappingException(System.Type sourceType, System.Type destinationType);
            }

            class XmlUnionConverter : System.Xml.Schema.XmlBaseConverter
            {
                /*0x28*/ System.Xml.Schema.XmlValueConverter[] converters;
                /*0x30*/ bool hasAtomicMember;
                /*0x31*/ bool hasListMember;

                static /*0x76f6364*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x76f6104*/ XmlUnionConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x76f63bc*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
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

                static /*0x76fd070*/ XsdBuilder();
                static /*0x76f877c*/ void BuildAnnotated_Id(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f87a0*/ void BuildSchema_AttributeFormDefault(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f8914*/ void BuildSchema_ElementFormDefault(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f89b4*/ void BuildSchema_TargetNamespace(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f89d4*/ void BuildSchema_Version(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f89f4*/ void BuildSchema_FinalDefault(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f8cb0*/ void BuildSchema_BlockDefault(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f8d18*/ void InitSchema(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f8d3c*/ void InitInclude(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f8e00*/ void BuildInclude_SchemaLocation(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f8e20*/ void InitImport(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f8ee4*/ void BuildImport_Namespace(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f8f04*/ void BuildImport_SchemaLocation(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f8f24*/ void InitRedefine(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f8fe8*/ void BuildRedefine_SchemaLocation(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f9008*/ void EndRedefine(System.Xml.Schema.XsdBuilder builder);
                static /*0x76f9024*/ void InitAttribute(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f9314*/ void BuildAttribute_Default(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f9334*/ void BuildAttribute_Fixed(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f9354*/ void BuildAttribute_Form(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f93f4*/ void BuildAttribute_Use(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f9494*/ void BuildAttribute_Ref(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f9668*/ void BuildAttribute_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f9688*/ void BuildAttribute_Type(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f96f8*/ void InitElement(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f9808*/ void BuildElement_Abstract(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f9984*/ void BuildElement_Block(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f99ec*/ void BuildElement_Default(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f9a0c*/ void BuildElement_Form(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f9aac*/ void BuildElement_SubstitutionGroup(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f9b1c*/ void BuildElement_Final(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f9b84*/ void BuildElement_Fixed(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f9ba4*/ void BuildElement_MaxOccurs(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f9c80*/ void BuildElement_MinOccurs(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f9d5c*/ void BuildElement_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f9d7c*/ void BuildElement_Nillable(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f9dec*/ void BuildElement_Ref(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f9e5c*/ void BuildElement_Type(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76f9ecc*/ void InitSimpleType(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fa1f8*/ void BuildSimpleType_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fa218*/ void BuildSimpleType_Final(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fa280*/ void InitSimpleTypeUnion(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fa344*/ void BuildSimpleTypeUnion_MemberTypes(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fa534*/ void InitSimpleTypeList(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fa5f8*/ void BuildSimpleTypeList_ItemType(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fa668*/ void InitSimpleTypeRestriction(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fa72c*/ void BuildSimpleTypeRestriction_Base(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fa79c*/ void InitComplexType(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fa920*/ void BuildComplexType_Abstract(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fa990*/ void BuildComplexType_Block(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fa9f8*/ void BuildComplexType_Final(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76faa60*/ void BuildComplexType_Mixed(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76faad8*/ void BuildComplexType_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76faaf8*/ void InitComplexContent(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fac00*/ void BuildComplexContent_Mixed(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fac70*/ void InitComplexContentExtension(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fad5c*/ void BuildComplexContentExtension_Base(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fadcc*/ void InitComplexContentRestriction(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fae64*/ void BuildComplexContentRestriction_Base(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76faed4*/ void InitSimpleContent(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fafdc*/ void InitSimpleContentExtension(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fb0c8*/ void BuildSimpleContentExtension_Base(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fb138*/ void InitSimpleContentRestriction(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fb224*/ void BuildSimpleContentRestriction_Base(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fb294*/ void InitAttributeGroup(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fb368*/ void BuildAttributeGroup_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fb388*/ void InitAttributeGroupRef(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fb40c*/ void BuildAttributeGroupRef_Ref(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fb47c*/ void InitAnyAttribute(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fb71c*/ void BuildAnyAttribute_Namespace(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fb73c*/ void BuildAnyAttribute_ProcessContents(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fb7dc*/ void InitGroup(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fb8b0*/ void BuildGroup_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fb8d0*/ void InitGroupRef(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fbc50*/ void BuildParticle_MaxOccurs(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fbc6c*/ void BuildParticle_MinOccurs(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fbc88*/ void BuildGroupRef_Ref(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fbcf8*/ void InitAll(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fbd8c*/ void InitChoice(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fbe20*/ void InitSequence(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fbeb4*/ void InitAny(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fbf4c*/ void BuildAny_Namespace(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fbf6c*/ void BuildAny_ProcessContents(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fc00c*/ void InitNotation(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fc0a8*/ void BuildNotation_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fc0c8*/ void BuildNotation_Public(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fc0e8*/ void BuildNotation_System(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fc108*/ void InitFacet(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fc41c*/ void BuildFacet_Fixed(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fc494*/ void BuildFacet_Value(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fc4b4*/ void InitIdentityConstraint(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fc608*/ void BuildIdentityConstraint_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fc628*/ void BuildIdentityConstraint_Refer(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fc748*/ void InitSelector(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fc820*/ void BuildSelector_XPath(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fc840*/ void InitField(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fc918*/ void BuildField_XPath(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fc938*/ void InitAnnotation(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fca1c*/ void InitAppinfo(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fcae4*/ void BuildAppinfo_Source(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fcb58*/ void EndAppinfo(System.Xml.Schema.XsdBuilder builder);
                static /*0x76fcb80*/ void InitDocumentation(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fcc48*/ void BuildDocumentation_Source(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fccb8*/ void BuildDocumentation_XmlLang(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x76fcdf8*/ void EndDocumentation(System.Xml.Schema.XsdBuilder builder);
                static /*0x76fcb54*/ string ParseUriReference(string s);
                /*0x76f67b0*/ XsdBuilder(System.Xml.XmlReader reader, System.Xml.XmlNamespaceManager curmgr, System.Xml.Schema.XmlSchema schema, System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventhandler);
                /*0x76f6a0c*/ bool ProcessElement(string prefix, string name, string ns);
                /*0x76f6f0c*/ void ProcessAttribute(string prefix, string name, string ns, string value);
                /*0x76f7484*/ bool IsContentParsed();
                /*0x76f74a0*/ void ProcessMarkup(System.Xml.XmlNode[] markup);
                /*0x76f74b0*/ void ProcessCData(string value);
                /*0x76f7508*/ void StartChildren();
                /*0x76f7694*/ void EndChildren();
                /*0x76f6c98*/ void Push();
                /*0x76f76d0*/ void Pop();
                /*0x76f8658*/ System.Xml.Schema.SchemaNames.Token get_CurrentElement();
                /*0x76f8674*/ System.Xml.Schema.SchemaNames.Token get_ParentElement();
                /*0x76f86ec*/ System.Xml.Schema.XmlSchemaObject get_ParentContainer();
                /*0x76f77a8*/ System.Xml.Schema.XmlSchemaObject GetContainer(System.Xml.Schema.XsdBuilder.State state);
                /*0x76f78e0*/ void SetContainer(System.Xml.Schema.XsdBuilder.State state, object container);
                /*0x76f90e4*/ void AddAttribute(System.Xml.Schema.XmlSchemaObject value);
                /*0x76fb968*/ void AddParticle(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x76f6b34*/ bool GetNextState(System.Xml.XmlQualifiedName qname);
                /*0x76f6dfc*/ bool IsSkipableElement(System.Xml.XmlQualifiedName qname);
                /*0x76f9c9c*/ void SetMinOccurs(System.Xml.Schema.XmlSchemaParticle particle, string value);
                /*0x76f9bc0*/ void SetMaxOccurs(System.Xml.Schema.XmlSchemaParticle particle, string value);
                /*0x76f9878*/ bool ParseBoolean(string value, string attributeName);
                /*0x76f8840*/ int ParseEnum(string value, string attributeName, string[] values);
                /*0x76f9504*/ System.Xml.XmlQualifiedName ParseQName(string value, string attributeName);
                /*0x76f8a5c*/ int ParseBlockFinalEnum(string value, string attributeName);
                /*0x76fce20*/ void SendValidationEvent(string code, string arg0, string arg1, string arg2);
                /*0x76f6e24*/ void SendValidationEvent(string code, string msg);
                /*0x76f7390*/ void SendValidationEvent(string code, string[] args, System.Xml.Schema.XmlSeverityType severity);
                /*0x76fcf94*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity);
                /*0x76fa52c*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e);
                /*0x76f6d40*/ void RecordPosition();

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
                    /*0x770223c*/ XsdBuildFunction(object object, nint method);
                    /*0x77022f0*/ void Invoke(System.Xml.Schema.XsdBuilder builder, string value);
                }

                class XsdInitFunction : System.MulticastDelegate
                {
                    /*0x7702304*/ XsdInitFunction(object object, nint method);
                    /*0x77023b8*/ void Invoke(System.Xml.Schema.XsdBuilder builder, string value);
                }

                class XsdEndChildFunction : System.MulticastDelegate
                {
                    /*0x77023cc*/ XsdEndChildFunction(object object, nint method);
                    /*0x770247c*/ void Invoke(System.Xml.Schema.XsdBuilder builder);
                }

                class XsdAttributeEntry
                {
                    /*0x10*/ System.Xml.Schema.SchemaNames.Token Attribute;
                    /*0x18*/ System.Xml.Schema.XsdBuilder.XsdBuildFunction BuildFunc;

                    /*0x7702490*/ XsdAttributeEntry(System.Xml.Schema.SchemaNames.Token a, System.Xml.Schema.XsdBuilder.XsdBuildFunction build);
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

                    /*0x77024c8*/ XsdEntry(System.Xml.Schema.SchemaNames.Token n, System.Xml.Schema.XsdBuilder.State state, System.Xml.Schema.XsdBuilder.State[] nextStates, System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] attributes, System.Xml.Schema.XsdBuilder.XsdInitFunction init, System.Xml.Schema.XsdBuilder.XsdEndChildFunction end, bool parseContent);
                }

                class BuilderNamespaceManager : System.Xml.XmlNamespaceManager
                {
                    /*0x50*/ System.Xml.XmlNamespaceManager nsMgr;
                    /*0x58*/ System.Xml.XmlReader reader;

                    /*0x7702564*/ BuilderNamespaceManager(System.Xml.XmlNamespaceManager nsMgr, System.Xml.XmlReader reader);
                    /*0x77025a8*/ string LookupNamespace(string prefix);
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

                static /*0x7704efc*/ XsdDateTime();
                static /*0x770344c*/ bool TryParse(string text, System.Xml.Schema.XsdDateTimeFlags kinds, ref System.Xml.Schema.XsdDateTime result);
                static /*0x7703c18*/ System.DateTime op_Implicit(System.Xml.Schema.XsdDateTime xdt);
                static /*0x7704154*/ System.DateTimeOffset op_Implicit(System.Xml.Schema.XsdDateTime xdt);
                /*0x7702608*/ XsdDateTime(string text, System.Xml.Schema.XsdDateTimeFlags kinds);
                /*0x77033b8*/ XsdDateTime(System.Xml.Schema.XsdDateTime.Parser parser);
                /*0x770350c*/ XsdDateTime(System.DateTime dateTime, System.Xml.Schema.XsdDateTimeFlags kinds);
                /*0x77036d0*/ XsdDateTime(System.DateTimeOffset dateTimeOffset);
                /*0x7703740*/ XsdDateTime(System.DateTimeOffset dateTimeOffset, System.Xml.Schema.XsdDateTimeFlags kinds);
                /*0x77032fc*/ void InitiateXsdDateTime(System.Xml.Schema.XsdDateTime.Parser parser);
                /*0x77038d0*/ System.Xml.Schema.XsdDateTime.DateTimeTypeCode get_InternalTypeCode();
                /*0x77038d8*/ System.Xml.Schema.XsdDateTime.XsdDateTimeKind get_InternalKind();
                /*0x77038e0*/ int get_Year();
                /*0x7703938*/ int get_Month();
                /*0x7703990*/ int get_Day();
                /*0x77039e8*/ int get_Hour();
                /*0x7703a40*/ int get_Minute();
                /*0x7703a98*/ int get_Second();
                /*0x7703af0*/ int get_Fraction();
                /*0x7703c08*/ int get_ZoneHour();
                /*0x7703c10*/ int get_ZoneMinute();
                /*0x77044b0*/ string ToString();
                /*0x77048f4*/ void PrintDate(System.Text.StringBuilder sb);
                /*0x7704a38*/ void PrintTime(System.Text.StringBuilder sb);
                /*0x7704d5c*/ void PrintZone(System.Text.StringBuilder sb);
                /*0x7704c8c*/ void IntToCharArray(char[] text, int start, int value, int digits);
                /*0x7704cf4*/ void ShortToCharArray(char[] text, int start, int value);

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

                    static /*0x7705dfc*/ Parser();
                    static /*0x77052b0*/ bool Test(System.Xml.Schema.XsdDateTimeFlags left, System.Xml.Schema.XsdDateTimeFlags right);
                    /*0x77027b8*/ bool Parse(string text, System.Xml.Schema.XsdDateTimeFlags kinds);
                    /*0x77052bc*/ bool ParseDate(int start);
                    /*0x770551c*/ bool ParseTimeAndZoneAndWhitespace(int start);
                    /*0x7705818*/ bool ParseTimeAndWhitespace(int start);
                    /*0x7705a84*/ bool ParseTime(ref int start);
                    /*0x77055b8*/ bool ParseZoneAndWhitespace(int start);
                    /*0x77058b4*/ bool Parse4Dig(int start, ref int num);
                    /*0x77059dc*/ bool Parse2Dig(int start, ref int num);
                    /*0x77054d8*/ bool ParseChar(int start, char ch);
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

                static /*0x7707354*/ System.Exception TryParse(string s, ref System.Xml.Schema.XsdDuration result);
                static /*0x770624c*/ System.Exception TryParse(string s, System.Xml.Schema.XsdDuration.DurationType durationType, ref System.Xml.Schema.XsdDuration result);
                static /*0x7707360*/ string TryParseDigits(string s, ref int offset, bool eatDigits, ref int result, ref int numDigits);
                /*0x7705e9c*/ XsdDuration(bool isNegative, int years, int months, int days, int hours, int minutes, int seconds, int nanoseconds);
                /*0x7705ff8*/ XsdDuration(System.TimeSpan timeSpan);
                /*0x7706000*/ XsdDuration(System.TimeSpan timeSpan, System.Xml.Schema.XsdDuration.DurationType durationType);
                /*0x77061d0*/ XsdDuration(string s);
                /*0x77061d8*/ XsdDuration(string s, System.Xml.Schema.XsdDuration.DurationType durationType);
                /*0x77069c4*/ bool get_IsNegative();
                /*0x77069d0*/ int get_Years();
                /*0x77069d8*/ int get_Months();
                /*0x77069e0*/ int get_Days();
                /*0x77069e8*/ int get_Hours();
                /*0x77069f0*/ int get_Minutes();
                /*0x77069f8*/ int get_Seconds();
                /*0x77069b8*/ int get_Nanoseconds();
                /*0x7706a00*/ System.TimeSpan ToTimeSpan();
                /*0x7706a08*/ System.TimeSpan ToTimeSpan(System.Xml.Schema.XsdDuration.DurationType durationType);
                /*0x7706f14*/ System.Exception TryToTimeSpan(ref System.TimeSpan result);
                /*0x7706a50*/ System.Exception TryToTimeSpan(System.Xml.Schema.XsdDuration.DurationType durationType, ref System.TimeSpan result);
                /*0x7706f20*/ string ToString();
                /*0x7706f28*/ string ToString(System.Xml.Schema.XsdDuration.DurationType durationType);

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

                static /*0x770c568*/ XsdValidator();
                /*0x770751c*/ XsdValidator(System.Xml.Schema.BaseValidator validator);
                /*0x7707928*/ XsdValidator(System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling);
                /*0x7707540*/ void Init();
                /*0x7707a84*/ void Validate();
                /*0x7708130*/ void CompleteValidation();
                /*0x7707b3c*/ bool get_IsInlineSchemaStarted();
                /*0x7707b4c*/ void ProcessInlineSchema();
                /*0x7707de4*/ void ValidateElement();
                /*0x7708258*/ object ValidateChildElement();
                /*0x7708494*/ void ProcessElement(object particle);
                /*0x77087a0*/ void ProcessXsiAttributes(ref System.Xml.XmlQualifiedName xsiType, ref string xsiNil);
                /*0x7707f50*/ void ValidateEndElement();
                /*0x77086c4*/ System.Xml.Schema.SchemaElementDecl FastGetElementDecl(object particle);
                /*0x7708fa8*/ System.Xml.Schema.SchemaElementDecl ThoroughGetElementDecl(System.Xml.Schema.SchemaElementDecl elementDecl, System.Xml.XmlQualifiedName xsiType, string xsiNil);
                /*0x7709400*/ void ValidateStartElement();
                /*0x7709ac8*/ void ValidateEndStartElement();
                /*0x770b584*/ void LoadSchemaFromLocation(string uri, string url);
                /*0x7709ea8*/ void LoadSchema(string uri, string url);
                /*0x7709390*/ bool get_HasSchema();
                /*0x770bafc*/ bool get_PreserveWhitespace();
                /*0x770bb34*/ void ProcessTokenizedType(System.Xml.XmlTokenizedType ttype, string name);
                /*0x770a068*/ void CheckValue(string value, System.Xml.Schema.SchemaAttDef attdef);
                /*0x770bd58*/ void AddID(string name, object node);
                /*0x770bdf4*/ object FindId(string name);
                /*0x7708444*/ bool IsXSDRoot(string localName, string ns);
                /*0x770794c*/ void Push(System.Xml.XmlQualifiedName elementName);
                /*0x770b144*/ void Pop();
                /*0x7708134*/ void CheckForwardRefs();
                /*0x77093b4*/ void ValidateStartElementIdentityConstraints();
                /*0x770a4c0*/ bool get_HasIdentityConstraints();
                /*0x770be10*/ void AddIdentityConstraints();
                /*0x770c220*/ void ElementIdentityConstraints();
                /*0x770b2a8*/ void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, System.Xml.Schema.SchemaAttDef attdef);
                /*0x770b224*/ object UnWrapUnion(object typedValue);
                /*0x770a4d0*/ void EndElementIdentityConstraints();
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
                    /*0x770c62c*/ AstNode();
                    /*0x380b6a0*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x380b6a0*/ System.Xml.XPath.XPathResultType get_ReturnType();

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

                    /*0x770c634*/ Axis(MS.Internal.Xml.XPath.Axis.AxisType axisType, MS.Internal.Xml.XPath.AstNode input, string prefix, string name, System.Xml.XPath.XPathNodeType nodetype);
                    /*0x770c6d0*/ Axis(MS.Internal.Xml.XPath.Axis.AxisType axisType, MS.Internal.Xml.XPath.AstNode input);
                    /*0x770c708*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x770c710*/ System.Xml.XPath.XPathResultType get_ReturnType();
                    /*0x770c718*/ MS.Internal.Xml.XPath.AstNode get_Input();
                    /*0x770c720*/ void set_Input(MS.Internal.Xml.XPath.AstNode value);
                    /*0x770c728*/ string get_Prefix();
                    /*0x770c730*/ string get_Name();
                    /*0x770c738*/ System.Xml.XPath.XPathNodeType get_NodeType();
                    /*0x770c740*/ MS.Internal.Xml.XPath.Axis.AxisType get_TypeOfAxis();
                    /*0x770c748*/ bool get_AbbrAxis();
                    /*0x770c750*/ string get_Urn();
                    /*0x770c758*/ void set_Urn(string value);

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

                    /*0x770c760*/ Filter(MS.Internal.Xml.XPath.AstNode input, MS.Internal.Xml.XPath.AstNode condition);
                    /*0x770c7a4*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x770c7ac*/ System.Xml.XPath.XPathResultType get_ReturnType();
                }

                class Function : MS.Internal.Xml.XPath.AstNode
                {
                    static /*0x0*/ System.Xml.XPath.XPathResultType[] ReturnTypes;
                    /*0x10*/ MS.Internal.Xml.XPath.Function.FunctionType _functionType;
                    /*0x18*/ System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> _argumentList;
                    /*0x20*/ string _name;
                    /*0x28*/ string _prefix;

                    static /*0x770cac8*/ Function();
                    /*0x770c7b4*/ Function(MS.Internal.Xml.XPath.Function.FunctionType ftype, System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> argumentList);
                    /*0x770c854*/ Function(string prefix, string name, System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> argumentList);
                    /*0x770c91c*/ Function(MS.Internal.Xml.XPath.Function.FunctionType ftype, MS.Internal.Xml.XPath.AstNode arg);
                    /*0x770ca40*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x770ca48*/ System.Xml.XPath.XPathResultType get_ReturnType();

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

                    /*0x770cb68*/ Group(MS.Internal.Xml.XPath.AstNode groupNode);
                    /*0x770cb98*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x770cba0*/ System.Xml.XPath.XPathResultType get_ReturnType();
                }

                class Operand : MS.Internal.Xml.XPath.AstNode
                {
                    /*0x10*/ System.Xml.XPath.XPathResultType _type;
                    /*0x18*/ object _val;

                    /*0x770cba8*/ Operand(string val);
                    /*0x770cbe0*/ Operand(double val);
                    /*0x770cc30*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x770cc38*/ System.Xml.XPath.XPathResultType get_ReturnType();
                }

                class Operator : MS.Internal.Xml.XPath.AstNode
                {
                    static /*0x0*/ MS.Internal.Xml.XPath.Operator.Op[] s_invertOp;
                    /*0x10*/ MS.Internal.Xml.XPath.Operator.Op _opType;
                    /*0x18*/ MS.Internal.Xml.XPath.AstNode _opnd1;
                    /*0x20*/ MS.Internal.Xml.XPath.AstNode _opnd2;

                    static /*0x770ccc0*/ Operator();
                    /*0x770cc40*/ Operator(MS.Internal.Xml.XPath.Operator.Op op, MS.Internal.Xml.XPath.AstNode opnd1, MS.Internal.Xml.XPath.AstNode opnd2);
                    /*0x770cc94*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x770cc9c*/ System.Xml.XPath.XPathResultType get_ReturnType();

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
                    /*0x770cd60*/ Root();
                    /*0x770cd68*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x770cd70*/ System.Xml.XPath.XPathResultType get_ReturnType();
                }

                class Variable : MS.Internal.Xml.XPath.AstNode
                {
                    /*0x10*/ string _localname;
                    /*0x18*/ string _prefix;

                    /*0x770cd78*/ Variable(string name, string prefix);
                    /*0x770cdbc*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x770cdc4*/ System.Xml.XPath.XPathResultType get_ReturnType();
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

                    static /*0x770ff24*/ XPathParser();
                    static /*0x770cdfc*/ MS.Internal.Xml.XPath.AstNode ParseXPathExpression(string xpathExpression);
                    static /*0x770d978*/ bool IsNodeType(MS.Internal.Xml.XPath.XPathScanner scaner);
                    static /*0x770e0d0*/ bool IsStep(MS.Internal.Xml.XPath.XPathScanner.LexKind lexKind);
                    static /*0x770da6c*/ bool IsPrimaryExpr(MS.Internal.Xml.XPath.XPathScanner scanner);
                    static /*0x770f048*/ System.Collections.Generic.Dictionary<string, MS.Internal.Xml.XPath.XPathParser.ParamInfo> CreateFunctionTable();
                    static /*0x770fc74*/ System.Collections.Generic.Dictionary<string, MS.Internal.Xml.XPath.Axis.AxisType> CreateAxesTable();
                    /*0x770cdcc*/ XPathParser(MS.Internal.Xml.XPath.XPathScanner scanner);
                    /*0x770cfa4*/ MS.Internal.Xml.XPath.AstNode ParseExpression(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x770d008*/ MS.Internal.Xml.XPath.AstNode ParseOrExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x770d0ec*/ MS.Internal.Xml.XPath.AstNode ParseAndExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x770d234*/ MS.Internal.Xml.XPath.AstNode ParseEqualityExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x770d30c*/ MS.Internal.Xml.XPath.AstNode ParseRelationalExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x770d40c*/ MS.Internal.Xml.XPath.AstNode ParseAdditiveExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x770d4e4*/ MS.Internal.Xml.XPath.AstNode ParseMultiplicativeExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x770d610*/ MS.Internal.Xml.XPath.AstNode ParseUnaryExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x770d6e0*/ MS.Internal.Xml.XPath.AstNode ParseUnionExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x770d7e0*/ MS.Internal.Xml.XPath.AstNode ParsePathExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x770db1c*/ MS.Internal.Xml.XPath.AstNode ParseFilterExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x770e044*/ MS.Internal.Xml.XPath.AstNode ParsePredicate(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x770dcc0*/ MS.Internal.Xml.XPath.AstNode ParseLocationPath(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x770dbcc*/ MS.Internal.Xml.XPath.AstNode ParseRelativeLocationPath(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x770e114*/ MS.Internal.Xml.XPath.AstNode ParseStep(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x770e3a4*/ MS.Internal.Xml.XPath.AstNode ParseNodeTest(MS.Internal.Xml.XPath.AstNode qyInput, MS.Internal.Xml.XPath.Axis.AxisType axisType, System.Xml.XPath.XPathNodeType nodeType);
                    /*0x770de24*/ MS.Internal.Xml.XPath.AstNode ParsePrimaryExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x770e700*/ MS.Internal.Xml.XPath.AstNode ParseMethod(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x770e69c*/ void CheckToken(MS.Internal.Xml.XPath.XPathScanner.LexKind t);
                    /*0x770e0b0*/ void PassToken(MS.Internal.Xml.XPath.XPathScanner.LexKind t);
                    /*0x770d21c*/ void NextLex();
                    /*0x770d1d0*/ bool TestOp(string op);
                    /*0x770d91c*/ void CheckNodeSet(System.Xml.XPath.XPathResultType t);
                    /*0x770e2bc*/ MS.Internal.Xml.XPath.Axis.AxisType GetAxis();

                    class ParamInfo
                    {
                        /*0x10*/ MS.Internal.Xml.XPath.Function.FunctionType _ftype;
                        /*0x14*/ int _minargs;
                        /*0x18*/ int _maxargs;
                        /*0x20*/ System.Xml.XPath.XPathResultType[] _argTypes;

                        /*0x770fc28*/ ParamInfo(MS.Internal.Xml.XPath.Function.FunctionType ftype, int minargs, int maxargs, System.Xml.XPath.XPathResultType[] argTypes);
                        /*0x77101d8*/ MS.Internal.Xml.XPath.Function.FunctionType get_FType();
                        /*0x77101e0*/ int get_Minargs();
                        /*0x77101e8*/ int get_Maxargs();
                        /*0x77101f0*/ System.Xml.XPath.XPathResultType[] get_ArgTypes();
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

                    /*0x770cef0*/ XPathScanner(string xpathExpr);
                    /*0x7710258*/ string get_SourceText();
                    /*0x7710260*/ char get_CurrentChar();
                    /*0x77101f8*/ bool NextChar();
                    /*0x7710268*/ MS.Internal.Xml.XPath.XPathScanner.LexKind get_Kind();
                    /*0x7710270*/ string get_Name();
                    /*0x7710278*/ string get_Prefix();
                    /*0x7710280*/ string get_StringValue();
                    /*0x7710288*/ double get_NumberValue();
                    /*0x7710290*/ bool get_CanBeFunction();
                    /*0x7710298*/ void SkipSpace();
                    /*0x770ec64*/ bool NextLex();
                    /*0x7710434*/ double ScanNumber();
                    /*0x77102d4*/ double ScanFraction();
                    /*0x7710384*/ string ScanString();
                    /*0x771050c*/ string ScanName();

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

                    /*0x7710584*/ XPathDocumentNavigator(MS.Internal.Xml.Cache.XPathNode[] pageCurrent, int idxCurrent, MS.Internal.Xml.Cache.XPathNode[] pageParent, int idxParent);
                    /*0x7710624*/ string get_Value();
                    /*0x7710a30*/ System.Xml.XPath.XPathNavigator Clone();
                    /*0x7710aa4*/ System.Xml.XPath.XPathNodeType get_NodeType();
                    /*0x7710ae8*/ string get_LocalName();
                    /*0x7710b40*/ string get_NamespaceURI();
                    /*0x7710b98*/ string get_Prefix();
                    /*0x7710bf0*/ System.Xml.XmlNameTable get_NameTable();
                    /*0x7710c50*/ bool MoveToFirstNamespace(System.Xml.XPath.XPathNamespaceScope namespaceScope);
                    /*0x7710f6c*/ bool MoveToNextNamespace(System.Xml.XPath.XPathNamespaceScope scope);
                    /*0x77110e8*/ bool MoveToParent();
                    /*0x77111d0*/ bool IsSamePosition(System.Xml.XPath.XPathNavigator other);
                    /*0x7711274*/ object get_UnderlyingObject();
                    /*0x7711284*/ bool HasLineInfo();
                    /*0x77112c8*/ int get_LineNumber();
                    /*0x7711374*/ int get_LinePosition();
                    /*0x7711468*/ int GetPositionHashCode();
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

                    /*0x7710adc*/ System.Xml.XPath.XPathNodeType get_NodeType();
                    /*0x7710bd4*/ string get_Prefix();
                    /*0x7710b24*/ string get_LocalName();
                    /*0x7710b7c*/ string get_NamespaceUri();
                    /*0x7710c34*/ System.Xml.XPath.XPathDocument get_Document();
                    /*0x771134c*/ int get_LineNumber();
                    /*0x7711444*/ int get_LinePosition();
                    /*0x7711418*/ int get_CollapsedLinePosition();
                    /*0x7711474*/ MS.Internal.Xml.Cache.XPathNodePageInfo get_PageInfo();
                    /*0x77110b4*/ int GetParent(ref MS.Internal.Xml.Cache.XPathNode[] pageNode);
                    /*0x7710f38*/ int GetSibling(ref MS.Internal.Xml.Cache.XPathNode[] pageNode);
                    /*0x7710eb0*/ bool get_IsXmlNamespaceNode();
                    /*0x7711490*/ bool get_HasSibling();
                    /*0x77114a0*/ bool get_HasCollapsedText();
                    /*0x77114ac*/ bool get_IsText();
                    /*0x7711508*/ bool get_HasNamespaceDecls();
                    /*0x7711514*/ string get_Value();
                }

                struct XPathNodeRef
                {
                    /*0x10*/ MS.Internal.Xml.Cache.XPathNode[] _page;
                    /*0x18*/ int _idx;

                    /*0x771151c*/ XPathNodeRef(MS.Internal.Xml.Cache.XPathNode[] page, int idx);
                    /*0x7711544*/ MS.Internal.Xml.Cache.XPathNode[] get_Page();
                    /*0x771154c*/ int get_Index();
                    /*0x7711554*/ int GetHashCode();
                }

                class XPathNodeHelper
                {
                    static /*0x7710d60*/ int GetLocalNamespaces(MS.Internal.Xml.Cache.XPathNode[] pageElem, int idxElem, ref MS.Internal.Xml.Cache.XPathNode[] pageNmsp);
                    static /*0x7710dd0*/ int GetInScopeNamespaces(MS.Internal.Xml.Cache.XPathNode[] pageElem, int idxElem, ref MS.Internal.Xml.Cache.XPathNode[] pageNmsp);
                    static /*0x7711150*/ bool GetParent(ref MS.Internal.Xml.Cache.XPathNode[] pageNode, ref int idxNode);
                    static /*0x7711564*/ int GetLocation(MS.Internal.Xml.Cache.XPathNode[] pageNode, int idxNode);
                    static /*0x77108c4*/ bool GetTextFollowing(ref MS.Internal.Xml.Cache.XPathNode[] pageCurrent, ref int idxCurrent, MS.Internal.Xml.Cache.XPathNode[] pageEnd, int idxEnd);
                    static /*0x7710814*/ bool GetNonDescendant(ref MS.Internal.Xml.Cache.XPathNode[] pageNode, ref int idxNode);
                }

                class XPathNodePageInfo
                {
                    /*0x10*/ int _pageNum;
                    /*0x14*/ int _nodeCount;
                    /*0x18*/ MS.Internal.Xml.Cache.XPathNode[] _pageNext;

                    /*0x771159c*/ int get_PageNumber();
                    /*0x77115a4*/ int get_NodeCount();
                    /*0x77115ac*/ MS.Internal.Xml.Cache.XPathNode[] get_NextPage();
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

                    /*0x77115b4*/ MS.Internal.Xml.Cache.XPathNodePageInfo get_PageInfo();
                    /*0x77115bc*/ string get_LocalName();
                    /*0x77115c4*/ string get_NamespaceUri();
                    /*0x77115cc*/ string get_Prefix();
                    /*0x77115d4*/ MS.Internal.Xml.Cache.XPathNode[] get_SiblingPage();
                    /*0x77115dc*/ MS.Internal.Xml.Cache.XPathNode[] get_ParentPage();
                    /*0x77115e4*/ System.Xml.XPath.XPathDocument get_Document();
                    /*0x77115ec*/ int get_LineNumberBase();
                    /*0x77115f4*/ int get_LinePositionBase();
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

    static /*0x77115fc*/ uint ComputeStringHash(string s);

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
