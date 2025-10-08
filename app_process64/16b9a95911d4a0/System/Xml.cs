class <Module>
{
}

class SR
{
    static /*0x37ec3cc*/ string GetString(string name, object[] args);
    static /*0x37ec43c*/ string GetString(System.Globalization.CultureInfo culture, string name, object[] args);
}

namespace Microsoft
{
    namespace CSharp
    {
        class CodeDomProvider
        {
            /*0x37ec444*/ CodeDomProvider();
        }

        class CSharpCodeProvider : Microsoft.CSharp.CodeDomProvider
        {
            /*0x37ec44c*/ CSharpCodeProvider();
        }
    }
}

namespace System
{
    class MonoTODOAttribute : System.Attribute
    {
        /*0x37ec454*/ MonoTODOAttribute();
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

            static /*0x37ec45c*/ AsyncHelper();
        }

        class Base64Encoder
        {
            /*0x10*/ byte[] leftOverBytes;
            /*0x18*/ int leftOverBytesCount;
            /*0x20*/ char[] charsLine;

            /*0x37ec59c*/ Base64Encoder();
            void WriteChars(char[] chars, int index, int count);
            /*0x37ec600*/ void Encode(byte[] buffer, int index, int count);
            /*0x37ec954*/ void Flush();
        }

        class XmlRawWriterBase64Encoder : System.Xml.Base64Encoder
        {
            /*0x28*/ System.Xml.XmlRawWriter rawWriter;

            /*0x37ec9fc*/ XmlRawWriterBase64Encoder(System.Xml.XmlRawWriter rawWriter);
            /*0x37eca28*/ void WriteChars(char[] chars, int index, int count);
        }

        class XmlTextWriterBase64Encoder : System.Xml.Base64Encoder
        {
            /*0x28*/ System.Xml.XmlTextEncoder xmlTextEncoder;

            /*0x37eca48*/ XmlTextWriterBase64Encoder(System.Xml.XmlTextEncoder xmlTextEncoder);
            /*0x37eca74*/ void WriteChars(char[] chars, int index, int count);
        }

        class BinHexDecoder : System.Xml.IncrementalReadDecoder
        {
            /*0x10*/ byte[] buffer;
            /*0x18*/ int curIndex;
            /*0x1c*/ int endIndex;
            /*0x20*/ bool hasHalfByteCached;
            /*0x21*/ byte cachedHalfByte;

            static /*0x37ecdb4*/ byte[] Decode(char[] chars, bool allowOddChars);
            static /*0x37ecbec*/ void Decode(char* pChars, char* pCharsEndPos, byte* pBytes, byte* pBytesEndPos, ref bool hasHalfByteCached, ref byte cachedHalfByte, ref int charsDecoded, ref int bytesDecoded);
            /*0x37eca8c*/ bool get_IsFull();
            /*0x37eca9c*/ int Decode(char[] chars, int startPos, int len);
        }

        class BinHexEncoder
        {
            static /*0x37ecf9c*/ void Encode(byte[] buffer, int index, int count, System.Xml.XmlWriter writer);
            static /*0x37ed270*/ string Encode(byte[] inArray, int offsetIn, int count);
            static /*0x37ed138*/ int Encode(byte[] inArray, int offsetIn, int count, char[] outArray);
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

            static /*0x37edda8*/ BinXmlSqlDecimal();
            static /*0x37ed654*/ uint UIntFromByteArray(byte[] data, int offset);
            static /*0x37ed890*/ void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, ref uint iulR);
            static /*0x37ed960*/ void MpNormalize(uint[] rgulU, ref int ciulU);
            static /*0x37ed9b8*/ char ChFromDigit(uint uiDigit);
            /*0x37ed3c0*/ BinXmlSqlDecimal(byte[] data, int offset, bool trim);
            /*0x37ed3b0*/ bool get_IsPositive();
            /*0x37ed9c0*/ decimal ToDecimal();
            /*0x37ed6c4*/ void TrimTrailingZeros();
            /*0x37edae8*/ string ToString();
        }

        struct BinXmlSqlMoney
        {
            /*0x10*/ long data;

            /*0x37edeec*/ BinXmlSqlMoney(int v);
            /*0x37edef8*/ BinXmlSqlMoney(long v);
            /*0x37edf00*/ decimal ToDecimal();
            /*0x37edf64*/ string ToString();
        }

        class BinXmlDateTime
        {
            static /*0x0*/ int[] KatmaiTimeScaleMultiplicator;
            static /*0x8*/ double SQLTicksPerMillisecond;
            static /*0x10*/ int SQLTicksPerSecond;
            static /*0x14*/ int SQLTicksPerMinute;
            static /*0x18*/ int SQLTicksPerHour;
            static /*0x1c*/ int SQLTicksPerDay;

            static /*0x37f0210*/ BinXmlDateTime();
            static /*0x37ee054*/ void Write2Dig(System.Text.StringBuilder sb, int val);
            static /*0x37ee0b0*/ void Write4DigNeg(System.Text.StringBuilder sb, int val);
            static /*0x37ee154*/ void Write3Dec(System.Text.StringBuilder sb, int val);
            static /*0x37ee200*/ void WriteDate(System.Text.StringBuilder sb, int yr, int mnth, int day);
            static /*0x37ee2b4*/ void WriteTime(System.Text.StringBuilder sb, int hr, int min, int sec, int ms);
            static /*0x37ee3a0*/ void WriteTimeFullPrecision(System.Text.StringBuilder sb, int hr, int min, int sec, int fraction);
            static /*0x37ee594*/ void WriteTimeZone(System.Text.StringBuilder sb, System.TimeSpan zone);
            static /*0x37ee694*/ void WriteTimeZone(System.Text.StringBuilder sb, bool negTimeZone, int hr, int min);
            static /*0x37ee768*/ void BreakDownXsdDateTime(long val, ref int yr, ref int mnth, ref int day, ref int hr, ref int min, ref int sec, ref int ms);
            static /*0x37ee930*/ void BreakDownXsdDate(long val, ref int yr, ref int mnth, ref int day, ref bool negTimeZone, ref int hr, ref int min);
            static /*0x37eea8c*/ void BreakDownXsdTime(long val, ref int hr, ref int min, ref int sec, ref int ms);
            static /*0x37eeb8c*/ string XsdDateTimeToString(long val);
            static /*0x37eec94*/ string XsdDateToString(long val);
            static /*0x37eed78*/ string XsdTimeToString(long val);
            static /*0x37eee50*/ string SqlDateTimeToString(int dateticks, uint timeticks);
            static /*0x37eef90*/ System.DateTime SqlDateTimeToDateTime(int dateticks, uint timeticks);
            static /*0x37ef084*/ string SqlSmallDateTimeToString(short dateticks, ushort timeticks);
            static /*0x37ef178*/ System.DateTime SqlSmallDateTimeToDateTime(short dateticks, ushort timeticks);
            static /*0x37ef1ec*/ System.DateTime XsdKatmaiDateToDateTime(byte[] data, int offset);
            static /*0x37ef2e0*/ System.DateTime XsdKatmaiDateTimeToDateTime(byte[] data, int offset);
            static /*0x37ef59c*/ System.DateTime XsdKatmaiTimeToDateTime(byte[] data, int offset);
            static /*0x37ef600*/ System.DateTimeOffset XsdKatmaiDateOffsetToDateTimeOffset(byte[] data, int offset);
            static /*0x37ef664*/ System.DateTimeOffset XsdKatmaiDateTimeOffsetToDateTimeOffset(byte[] data, int offset);
            static /*0x37ef760*/ System.DateTimeOffset XsdKatmaiTimeOffsetToDateTimeOffset(byte[] data, int offset);
            static /*0x37ef7c4*/ string XsdKatmaiDateToString(byte[] data, int offset);
            static /*0x37ef8e0*/ string XsdKatmaiDateTimeToString(byte[] data, int offset);
            static /*0x37efb78*/ string XsdKatmaiTimeToString(byte[] data, int offset);
            static /*0x37efca8*/ string XsdKatmaiDateOffsetToString(byte[] data, int offset);
            static /*0x37efde4*/ string XsdKatmaiDateTimeOffsetToString(byte[] data, int offset);
            static /*0x37f00c0*/ string XsdKatmaiTimeOffsetToString(byte[] data, int offset);
            static /*0x37ef26c*/ long GetKatmaiDateTicks(byte[] data, ref int pos);
            static /*0x37ef374*/ long GetKatmaiTimeTicks(byte[] data, ref int pos);
            static /*0x37ef70c*/ long GetKatmaiTimeZoneTicks(byte[] data, int pos);
            static /*0x37efa60*/ int GetFractions(System.DateTime dt);
            static /*0x37eff84*/ int GetFractions(System.DateTimeOffset dt);
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

            static /*0x37f8e94*/ XmlSqlBinaryReader();
            /*0x37f02d4*/ XmlSqlBinaryReader(System.IO.Stream stream, byte[] data, int len, string baseUri, bool closeInput, System.Xml.XmlReaderSettings settings);
            /*0x37f156c*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x37f1688*/ System.Xml.XmlNodeType get_NodeType();
            /*0x37f1690*/ string get_LocalName();
            /*0x37f1698*/ string get_NamespaceURI();
            /*0x37f16a0*/ string get_Prefix();
            /*0x37f16a8*/ string get_Value();
            /*0x37f2400*/ int get_Depth();
            /*0x37f249c*/ string get_BaseURI();
            /*0x37f24a4*/ bool get_IsEmptyElement();
            /*0x37f24c8*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x37f2548*/ string get_XmlLang();
            /*0x37f25d8*/ System.Type get_ValueType();
            /*0x37f25e0*/ int get_AttributeCount();
            /*0x37f262c*/ string GetAttribute(string name, string ns);
            /*0x37f2784*/ string GetAttribute(string name);
            /*0x37f28d0*/ string GetAttribute(int i);
            /*0x37f2960*/ bool MoveToAttribute(string name);
            /*0x37f2ad8*/ void MoveToAttribute(int i);
            /*0x37f2b7c*/ bool MoveToFirstAttribute();
            /*0x37f2bec*/ bool MoveToNextAttribute();
            /*0x37f2c70*/ bool MoveToElement();
            /*0x37f2d40*/ bool get_EOF();
            /*0x37f2d50*/ bool ReadAttributeValue();
            /*0x37f30a8*/ void Close();
            /*0x37f3144*/ System.Xml.XmlNameTable get_NameTable();
            /*0x37f314c*/ string LookupNamespace(string prefix);
            /*0x37f3208*/ void ResolveEntity();
            /*0x37f3240*/ System.Xml.ReadState get_ReadState();
            /*0x37f32c0*/ bool Read();
            /*0x37f3d20*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x37f4134*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            /*0x37f42d8*/ void VerifyVersion(int requiredVersion, System.Xml.BinXmlToken token);
            /*0x37f0934*/ void AddInitNamespace(string prefix, string uri);
            /*0x37f43e4*/ void AddName();
            /*0x37f45d0*/ void AddQName();
            /*0x37f4940*/ void NameFlush();
            /*0x37f4990*/ void SkipExtn();
            /*0x37f4a68*/ int ReadQNameRef();
            /*0x37f4870*/ int ReadNameRef();
            /*0x37f4af4*/ bool FillAllowEOF();
            /*0x37f4d24*/ void Fill_(int require);
            /*0x37f4a4c*/ void Fill(int require);
            /*0x37f4e10*/ byte ReadByte();
            /*0x37f4e6c*/ ushort ReadUShort();
            /*0x37f4a20*/ int ParseMB32();
            /*0x37f4ee0*/ int ParseMB32_(byte b);
            /*0x37f4f78*/ int ParseMB32(int pos);
            /*0x37f5064*/ int ParseMB64();
            /*0x37f5090*/ System.Xml.BinXmlToken PeekToken();
            /*0x37f50f8*/ System.Xml.BinXmlToken ReadToken();
            /*0x37f5168*/ System.Xml.BinXmlToken NextToken2(System.Xml.BinXmlToken token);
            /*0x37f51e0*/ System.Xml.BinXmlToken NextToken1();
            /*0x37f5258*/ System.Xml.BinXmlToken NextToken();
            /*0x37f52c0*/ System.Xml.BinXmlToken PeekNextToken();
            /*0x37f2ecc*/ System.Xml.BinXmlToken RescanNextToken();
            /*0x37f450c*/ string ParseText();
            /*0x37f52e8*/ int ScanText(ref int start);
            /*0x37f17d4*/ string GetString(int pos, int cch);
            /*0x37f53a4*/ string GetStringAligned(byte[] data, int offset, int cch);
            /*0x37f22d4*/ string GetAttributeText(int i);
            /*0x37f26fc*/ int LocateAttribute(string name, string ns);
            /*0x37f27f0*/ int LocateAttribute(string name);
            /*0x37f29f8*/ void PositionOnAttribute(int i);
            /*0x37f5474*/ void GrowElements();
            /*0x37f5504*/ void GrowAttributes();
            /*0x37f5594*/ void ClearAttributes();
            /*0x37f55a4*/ void PushNamespace(string prefix, string ns, bool implied);
            /*0x37f58ac*/ void PopNamespaces(System.Xml.XmlSqlBinaryReader.NamespaceDecl firstInScopeChain);
            /*0x37f597c*/ void GenerateImpliedXmlnsAttrs();
            /*0x37f348c*/ bool ReadInit(bool skipXmlDecl);
            /*0x37f5b60*/ void ScanAttributes();
            /*0x37f6330*/ void SimpleCheckForDuplicateAttributes();
            /*0x37f649c*/ void HashCheckForDuplicateAttributes();
            /*0x37f1a48*/ string XmlDeclValue();
            /*0x37f1938*/ string CDATAValue();
            /*0x37f6814*/ void FinishCDATA();
            /*0x37f68b8*/ void FinishEndElement();
            /*0x37f399c*/ bool ReadDoc();
            /*0x37f7538*/ void ImplReadData(System.Xml.BinXmlToken tokenType);
            /*0x37f6940*/ void ImplReadElement();
            /*0x37f6be4*/ void ImplReadEndElement();
            /*0x37f6cc4*/ void ImplReadDoctype();
            /*0x37f6fa8*/ void ImplReadPI();
            /*0x37f7014*/ void ImplReadComment();
            /*0x37f7040*/ void ImplReadCDATA();
            /*0x37f7074*/ void ImplReadNest();
            /*0x37f7114*/ void ImplReadEndNest();
            /*0x37f715c*/ void ImplReadXmlText();
            /*0x37f77c4*/ void UpdateFromTextReader();
            /*0x37f29dc*/ bool UpdateFromTextReader(bool needUpdate);
            /*0x37f76bc*/ void CheckAllowContent();
            /*0x37f0a0c*/ void GenerateTokenTypeMap();
            /*0x37f2fc8*/ System.Type GetValueType(System.Xml.BinXmlToken token);
            /*0x37f2fbc*/ void ReScanOverValue(System.Xml.BinXmlToken token);
            /*0x37f6180*/ System.Xml.XmlNodeType ScanOverValue(System.Xml.BinXmlToken token, bool attr, bool checkChars);
            /*0x37f7afc*/ System.Xml.XmlNodeType ScanOverAnyValue(System.Xml.BinXmlToken token, bool attr, bool checkChars);
            /*0x37f789c*/ System.Xml.XmlNodeType CheckText(bool attr);
            /*0x37f7a60*/ System.Xml.XmlNodeType CheckTextIsWS();
            /*0x37f7f70*/ void CheckValueTokenBounds();
            /*0x37f7e88*/ int GetXsdKatmaiTokenLength(System.Xml.BinXmlToken token);
            /*0x37f7fcc*/ int XsdKatmaiTimeScaleToValueLength(byte scale);
            /*0x37f80a0*/ long ValueAsLong();
            /*0x37f8998*/ ulong ValueAsULong();
            /*0x37f873c*/ decimal ValueAsDecimal();
            /*0x37f85e8*/ double ValueAsDouble();
            /*0x37f8b34*/ string ValueAsDateTimeString();
            /*0x37f1b88*/ string ValueAsString(System.Xml.BinXmlToken token);
            /*0x37f82d8*/ short GetInt16(int pos);
            /*0x37f8460*/ ushort GetUInt16(int pos);
            /*0x37f831c*/ int GetInt32(int pos);
            /*0x37f84a4*/ uint GetUInt32(int pos);
            /*0x37f8390*/ long GetInt64(int pos);
            /*0x37f8518*/ ulong GetUInt64(int pos);
            /*0x37f89e8*/ float GetSingle(int offset);
            /*0x37f8a60*/ double GetDouble(int offset);
            /*0x37f430c*/ System.Exception ThrowUnexpectedToken(System.Xml.BinXmlToken token);
            /*0x37f4d9c*/ System.Exception ThrowXmlException(string res);
            /*0x37f6094*/ System.Exception ThrowXmlException(string res, string arg1, string arg2);
            /*0x37f62ac*/ System.Exception ThrowNotSupported(string res);

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

                static /*0x37f9144*/ bool op_Equality(System.Xml.XmlSqlBinaryReader.QName a, System.Xml.XmlSqlBinaryReader.QName b);
                /*0x37f5ad0*/ QName(string prefix, string lname, string nsUri);
                /*0x37f48fc*/ void Set(string prefix, string lname, string nsUri);
                /*0x37f08e0*/ void Clear();
                /*0x37f53d4*/ bool MatchNs(string lname, string nsUri);
                /*0x37f5424*/ bool MatchPrefix(string prefix, string lname);
                /*0x37f57c8*/ void CheckPrefixNS(string prefix, string namespaceUri);
                /*0x37f9010*/ int GetHashCode();
                /*0x37f9058*/ int GetNSHashCode(System.Xml.SecureStringHasher hasher);
                /*0x37f90a4*/ bool Equals(object other);
                /*0x37f6734*/ string ToString();
            }

            struct ElemInfo
            {
                /*0x10*/ System.Xml.XmlSqlBinaryReader.QName name;
                /*0x28*/ string xmlLang;
                /*0x30*/ System.Xml.XmlSpace xmlSpace;
                /*0x34*/ bool xmlspacePreserve;
                /*0x38*/ System.Xml.XmlSqlBinaryReader.NamespaceDecl nsdecls;

                /*0x37f7720*/ void Set(System.Xml.XmlSqlBinaryReader.QName name, bool xmlspacePreserve);
                /*0x37f6920*/ System.Xml.XmlSqlBinaryReader.NamespaceDecl Clear();
            }

            struct AttrInfo
            {
                /*0x10*/ System.Xml.XmlSqlBinaryReader.QName name;
                /*0x28*/ string val;
                /*0x30*/ int contentPos;
                /*0x34*/ int hashCode;
                /*0x38*/ int prevHash;

                /*0x37f5b14*/ void Set(System.Xml.XmlSqlBinaryReader.QName n, string v);
                /*0x37f6048*/ void Set(System.Xml.XmlSqlBinaryReader.QName n, int pos);
                /*0x37f66f4*/ void GetLocalnameAndNamespaceUri(ref string localname, ref string namespaceUri);
                /*0x37f67a4*/ int GetLocalnameAndNamespaceUriAndHash(System.Xml.SecureStringHasher hasher, ref string localname, ref string namespaceUri);
                /*0x37f6730*/ bool MatchNS(string localname, string namespaceUri);
                /*0x37f67f4*/ bool MatchHashNS(int hash, string localname, string namespaceUri);
                /*0x37f4d10*/ void AdjustPosition(int adj);
            }

            class NamespaceDecl
            {
                /*0x10*/ string prefix;
                /*0x18*/ string uri;
                /*0x20*/ System.Xml.XmlSqlBinaryReader.NamespaceDecl scopeLink;
                /*0x28*/ System.Xml.XmlSqlBinaryReader.NamespaceDecl prevLink;
                /*0x30*/ int scope;
                /*0x34*/ bool implied;

                /*0x37f4354*/ NamespaceDecl(string prefix, string nsuri, System.Xml.XmlSqlBinaryReader.NamespaceDecl nextInScope, System.Xml.XmlSqlBinaryReader.NamespaceDecl prevDecl, int scope, bool implied);
            }

            struct SymbolTables
            {
                /*0x10*/ string[] symtable;
                /*0x18*/ int symCount;
                /*0x20*/ System.Xml.XmlSqlBinaryReader.QName[] qnametable;
                /*0x28*/ int qnameCount;

                /*0x37f080c*/ void Init();
            }

            class NestedBinXml
            {
                /*0x10*/ System.Xml.XmlSqlBinaryReader.SymbolTables symbolTables;
                /*0x30*/ int docState;
                /*0x38*/ System.Xml.XmlSqlBinaryReader.NestedBinXml next;

                /*0x37f776c*/ NestedBinXml(System.Xml.XmlSqlBinaryReader.SymbolTables symbolTables, int docState, System.Xml.XmlSqlBinaryReader.NestedBinXml next);
            }
        }

        class BitStack
        {
            /*0x10*/ uint[] bitStack;
            /*0x18*/ int stackPos;
            /*0x1c*/ uint curr;

            /*0x37f91a4*/ BitStack();
            /*0x37f91c4*/ void PushBit(bool bit);
            /*0x37f9304*/ bool PopBit();
            /*0x37f9370*/ bool PeekBit();
            /*0x37f91fc*/ void PushCurr();
            /*0x37f932c*/ void PopCurr();
        }

        class Bits
        {
            static /*0x0*/ uint MASK_0101010101010101;
            static /*0x4*/ uint MASK_0011001100110011;
            static /*0x8*/ uint MASK_0000111100001111;
            static /*0xc*/ uint MASK_0000000011111111;
            static /*0x10*/ uint MASK_1111111111111111;

            static /*0x37f9484*/ Bits();
            static /*0x37f937c*/ int Count(uint num);
            static /*0x37f9418*/ int LeastPosition(uint num);
        }

        class ByteStack
        {
            /*0x10*/ byte[] stack;
            /*0x18*/ int growthRate;
            /*0x1c*/ int top;
            /*0x20*/ int size;

            /*0x37f94dc*/ ByteStack(int growthRate);
            /*0x37f9558*/ void Push(byte data);
            /*0x37f9638*/ byte Pop();
        }

        class CharEntityEncoderFallback : System.Text.EncoderFallback
        {
            /*0x10*/ System.Xml.CharEntityEncoderFallbackBuffer fallbackBuffer;
            /*0x18*/ int[] textContentMarks;
            /*0x20*/ int endMarkPos;
            /*0x24*/ int curMarkPos;
            /*0x28*/ int startOffset;

            /*0x37f9680*/ CharEntityEncoderFallback();
            /*0x37f9688*/ System.Text.EncoderFallbackBuffer CreateFallbackBuffer();
            /*0x37f9754*/ int get_MaxCharCount();
            /*0x37f975c*/ void set_StartOffset(int value);
            /*0x37f9764*/ void Reset(int[] textContentMarks, int endMarkPos);
            /*0x37f9790*/ bool CanReplaceAt(int index);
        }

        class CharEntityEncoderFallbackBuffer : System.Text.EncoderFallbackBuffer
        {
            /*0x30*/ System.Xml.CharEntityEncoderFallback parent;
            /*0x38*/ string charEntity;
            /*0x40*/ int charEntityIndex;

            /*0x37f96fc*/ CharEntityEncoderFallbackBuffer(System.Xml.CharEntityEncoderFallback parent);
            /*0x37f9810*/ bool Fallback(char charUnknown, int index);
            /*0x37f9a0c*/ bool Fallback(char charUnknownHigh, char charUnknownLow, int index);
            /*0x37f9c9c*/ char GetNextChar();
            /*0x37f9cec*/ bool MovePrevious();
            /*0x37f9d08*/ int get_Remaining();
            /*0x37f9d38*/ void Reset();
            /*0x37f9c8c*/ int SurrogateCharToUtf32(char highSurrogate, char lowSurrogate);
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

            /*0x37f9d44*/ HtmlEncodedRawTextWriter(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings);
            /*0x37f9f1c*/ HtmlEncodedRawTextWriter(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x37f9f48*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x37f9f4c*/ void WriteXmlDeclaration(string xmldecl);
            /*0x37f9f50*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x37fa19c*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x37fa2c8*/ void StartElementContent();
            /*0x37fa440*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x37fa544*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x37fa648*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x37fa7cc*/ void WriteEndAttribute();
            /*0x37fa8f4*/ void WriteProcessingInstruction(string target, string text);
            /*0x37faa28*/ void WriteString(string text);
            /*0x37faaf4*/ void WriteEntityRef(string name);
            /*0x37fab4c*/ void WriteCharEntity(char ch);
            /*0x37faba4*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x37fabfc*/ void WriteChars(char[] buffer, int index, int count);
            /*0x37f9d70*/ void Init(System.Xml.XmlWriterSettings settings);
            /*0x37fa31c*/ void WriteMetaElement();
            /*0x37faadc*/ void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd);
            /*0x37faa98*/ void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd);
            /*0x37fafe4*/ void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd);
            /*0x37fac8c*/ void WriteUriAttributeText(char* pSrc, char* pSrcEnd);
            /*0x37fa860*/ void OutputRestAmps();
        }

        class HtmlEncodedRawTextWriterIndent : System.Xml.HtmlEncodedRawTextWriter
        {
            /*0xec*/ int indentLevel;
            /*0xf0*/ int endBlockPos;
            /*0xf8*/ string indentChars;
            /*0x100*/ bool newLineOnAttributes;

            /*0x37fb244*/ HtmlEncodedRawTextWriterIndent(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings);
            /*0x37fb2bc*/ HtmlEncodedRawTextWriterIndent(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x37fb2f4*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x37fb310*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x37fb524*/ void StartElementContent();
            /*0x37fb594*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x37fb634*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x37fb6a8*/ void FlushBuffer();
            /*0x37fb27c*/ void Init(System.Xml.XmlWriterSettings settings);
            /*0x37fb4d4*/ void WriteIndent();
        }

        class HtmlTernaryTree
        {
            static /*0x0*/ byte[] htmlElements;
            static /*0x8*/ byte[] htmlAttributes;

            static /*0x37fb6d0*/ HtmlTernaryTree();
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

            /*0x37fb7b4*/ HtmlUtf8RawTextWriter(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x37fb98c*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x37fb990*/ void WriteXmlDeclaration(string xmldecl);
            /*0x37fb994*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x37fbbdc*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x37fbce8*/ void StartElementContent();
            /*0x37fbe64*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x37fbf48*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x37fc02c*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x37fc1a0*/ void WriteEndAttribute();
            /*0x37fc2dc*/ void WriteProcessingInstruction(string target, string text);
            /*0x37fc3fc*/ void WriteString(string text);
            /*0x37fc4a8*/ void WriteEntityRef(string name);
            /*0x37fc500*/ void WriteCharEntity(char ch);
            /*0x37fc558*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x37fc5b0*/ void WriteChars(char[] buffer, int index, int count);
            /*0x37fb7e0*/ void Init(System.Xml.XmlWriterSettings settings);
            /*0x37fbd40*/ void WriteMetaElement();
            /*0x37fc490*/ void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd);
            /*0x37fc44c*/ void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd);
            /*0x37fc934*/ void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd);
            /*0x37fc5f4*/ void WriteUriAttributeText(char* pSrc, char* pSrcEnd);
            /*0x37fc218*/ void OutputRestAmps();
        }

        class HtmlUtf8RawTextWriterIndent : System.Xml.HtmlUtf8RawTextWriter
        {
            /*0xbc*/ int indentLevel;
            /*0xc0*/ int endBlockPos;
            /*0xc8*/ string indentChars;
            /*0xd0*/ bool newLineOnAttributes;

            /*0x38c5d28*/ HtmlUtf8RawTextWriterIndent(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x38c5d94*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x38c5db4*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x38c60dc*/ void StartElementContent();
            /*0x38c6154*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x38c61fc*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x38c6274*/ void FlushBuffer();
            /*0x38c5d54*/ void Init(System.Xml.XmlWriterSettings settings);
            /*0x38c608c*/ void WriteIndent();
        }

        interface IDtdInfo
        {
            /*0x1f30214*/ System.Xml.XmlQualifiedName get_Name();
            /*0x1f30214*/ string get_InternalDtdSubset();
            /*0x1f2fe14*/ bool get_HasDefaultAttributes();
            /*0x1f2fe14*/ bool get_HasNonCDataAttributes();
            /*0x1f30394*/ System.Xml.IDtdAttributeListInfo LookupAttributeList(string prefix, string localName);
            /*0x1f302cc*/ System.Xml.IDtdEntityInfo LookupEntity(string name);
        }

        interface IDtdAttributeListInfo
        {
            /*0x1f2fe14*/ bool get_HasNonCDataAttributes();
            /*0x1f30394*/ System.Xml.IDtdAttributeInfo LookupAttribute(string prefix, string localName);
            /*0x1f30214*/ System.Collections.Generic.IEnumerable<System.Xml.IDtdDefaultAttributeInfo> LookupDefaultAttributes();
        }

        interface IDtdAttributeInfo
        {
            /*0x1f30214*/ string get_Prefix();
            /*0x1f30214*/ string get_LocalName();
            /*0x1f2ffc8*/ int get_LineNumber();
            /*0x1f2ffc8*/ int get_LinePosition();
            /*0x1f2fe14*/ bool get_IsNonCDataType();
            /*0x1f2fe14*/ bool get_IsDeclaredInExternal();
            /*0x1f2fe14*/ bool get_IsXmlAttribute();
        }

        interface IDtdDefaultAttributeInfo : System.Xml.IDtdAttributeInfo
        {
            /*0x1f30214*/ string get_DefaultValueExpanded();
            /*0x1f30214*/ object get_DefaultValueTyped();
            /*0x1f2ffc8*/ int get_ValueLineNumber();
            /*0x1f2ffc8*/ int get_ValueLinePosition();
        }

        interface IDtdEntityInfo
        {
            /*0x1f30214*/ string get_Name();
            /*0x1f2fe14*/ bool get_IsExternal();
            /*0x1f2fe14*/ bool get_IsDeclaredInExternal();
            /*0x1f2fe14*/ bool get_IsUnparsedEntity();
            /*0x1f2fe14*/ bool get_IsParameterEntity();
            /*0x1f30214*/ string get_BaseUriString();
            /*0x1f30214*/ string get_DeclaredUriString();
            /*0x1f30214*/ string get_SystemId();
            /*0x1f30214*/ string get_PublicId();
            /*0x1f30214*/ string get_Text();
            /*0x1f2ffc8*/ int get_LineNumber();
            /*0x1f2ffc8*/ int get_LinePosition();
        }

        interface IDtdParser
        {
            System.Xml.IDtdInfo ParseInternalDtd(System.Xml.IDtdParserAdapter adapter, bool saveInternalSubset);
            /*0x1f30484*/ System.Xml.IDtdInfo ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, System.Xml.IDtdParserAdapter adapter);
        }

        interface IDtdParserAdapter
        {
            /*0x1f30214*/ System.Xml.XmlNameTable get_NameTable();
            /*0x1f30214*/ System.Xml.IXmlNamespaceResolver get_NamespaceResolver();
            /*0x1f30214*/ System.Uri get_BaseUri();
            /*0x1f30214*/ char[] get_ParsingBuffer();
            /*0x1f2ffc8*/ int get_ParsingBufferLength();
            /*0x1f2ffc8*/ int get_CurrentPosition();
            /*0x1f30b78*/ void set_CurrentPosition(int value);
            /*0x1f2ffc8*/ int get_LineNo();
            /*0x1f2ffc8*/ int get_LineStartPosition();
            /*0x1f2fe14*/ bool get_IsEof();
            /*0x1f2ffc8*/ int get_EntityStackLength();
            /*0x1f2fe14*/ bool get_IsEntityEolNormalized();
            /*0x1f2ffc8*/ int ReadData();
            /*0x1f30b78*/ void OnNewLine(int pos);
            /*0x1f3008c*/ int ParseNumericCharRef(System.Text.StringBuilder internalSubsetBuilder);
            int ParseNamedCharRef(bool expand, System.Text.StringBuilder internalSubsetBuilder);
            /*0x1f30ebc*/ void ParsePI(System.Text.StringBuilder sb);
            /*0x1f30ebc*/ void ParseComment(System.Text.StringBuilder sb);
            /*0x1f2ff00*/ bool PushEntity(System.Xml.IDtdEntityInfo entity, ref int entityId);
            /*0x1f2ff00*/ bool PopEntity(ref System.Xml.IDtdEntityInfo oldEntity, ref int newEntityId);
            /*0x1f2ff00*/ bool PushExternalSubset(string systemId, string publicId);
            /*0x1f30ff0*/ void PushInternalDtd(string baseUri, string internalDtd);
            void OnSystemId(string systemId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo systemLiteralLineInfo);
            void OnPublicId(string publicId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo publicLiteralLineInfo);
            /*0x1f30ebc*/ void Throw(System.Exception e);
        }

        interface IDtdParserAdapterWithValidation : System.Xml.IDtdParserAdapter
        {
            /*0x1f2fe14*/ bool get_DtdValidation();
            /*0x1f30214*/ System.Xml.IValidationEventHandling get_ValidationEventHandling();
        }

        interface IDtdParserAdapterV1 : System.Xml.IDtdParserAdapterWithValidation, System.Xml.IDtdParserAdapter
        {
            /*0x1f2fe14*/ bool get_V1CompatibilityMode();
            /*0x1f2fe14*/ bool get_Normalization();
            /*0x1f2fe14*/ bool get_Namespaces();
        }

        class OnRemoveWriter : System.MulticastDelegate
        {
            /*0x38c629c*/ OnRemoveWriter(object object, nint method);
            /*0x38c63a4*/ void Invoke(System.Xml.XmlRawWriter writer);
        }

        interface IValidationEventHandling
        {
            /*0x1f30214*/ object get_EventHandler();
            /*0x1f30ee8*/ void SendEvent(System.Exception exception, System.Xml.Schema.XmlSeverityType severity);
        }

        class IncrementalReadDecoder
        {
            /*0x38c63b8*/ IncrementalReadDecoder();
            /*0x1f2fe14*/ bool get_IsFull();
            int Decode(char[] chars, int startPos, int len);
        }

        class IncrementalReadDummyDecoder : System.Xml.IncrementalReadDecoder
        {
            /*0x38c63d0*/ IncrementalReadDummyDecoder();
            /*0x38c63c0*/ bool get_IsFull();
            /*0x38c63c8*/ int Decode(char[] chars, int startPos, int len);
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

            /*0x38c63d8*/ QueryOutputWriter(System.Xml.XmlRawWriter writer, System.Xml.XmlWriterSettings settings);
            /*0x38c675c*/ void set_NamespaceResolver(System.Xml.IXmlNamespaceResolver value);
            /*0x38c67a0*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x38c67c0*/ void WriteXmlDeclaration(string xmldecl);
            /*0x38c67e0*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x38c6810*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x38c69d8*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x38c6a38*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x38c6a98*/ void StartElementContent();
            /*0x38c6ab8*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x38c6ae0*/ void WriteEndAttribute();
            /*0x38c6b08*/ void WriteNamespaceDeclaration(string prefix, string ns);
            /*0x38c6b28*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0x38c6b48*/ void WriteStartNamespaceDeclaration(string prefix);
            /*0x38c6b68*/ void WriteEndNamespaceDeclaration();
            /*0x38c6b88*/ void WriteCData(string text);
            /*0x38c6ba8*/ void WriteComment(string text);
            /*0x38c6bd0*/ void WriteProcessingInstruction(string name, string text);
            /*0x38c6bf8*/ void WriteWhitespace(string ws);
            /*0x38c6ca4*/ void WriteString(string text);
            /*0x38c6d10*/ void WriteChars(char[] buffer, int index, int count);
            /*0x38c6dc0*/ void WriteEntityRef(string name);
            /*0x38c6de8*/ void WriteCharEntity(char ch);
            /*0x38c6e10*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x38c6e38*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x38c6ee8*/ void WriteRaw(string data);
            /*0x38c6f54*/ void Close();
            /*0x38c6ff8*/ void Flush();
            /*0x38c6c64*/ bool StartCDataSection();
            /*0x38c69d0*/ void EndCDataSection();
        }

        class ReadContentAsBinaryHelper
        {
            /*0x10*/ System.Xml.XmlReader reader;
            /*0x18*/ System.Xml.ReadContentAsBinaryHelper.State state;
            /*0x1c*/ int valueOffset;
            /*0x20*/ bool isEnd;

            /*0x38c7018*/ void Finish();
            /*0x38c7254*/ void Reset();
            /*0x38c7160*/ bool MoveToNextContentNode(bool moveIfOnContentNode);

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

            /*0x38c7260*/ TernaryTreeReadOnly(byte[] nodeBuffer);
            /*0x38c5f58*/ byte FindCaseInsensitiveString(string stringToFind);
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

            static /*0x38c74b0*/ int GetHashCodeOfString(string key, int sLen, long additionalEntropy);
            static /*0x38c7374*/ System.Xml.SecureStringHasher.HashCodeOfStringDelegate GetHashCodeDelegate();
            /*0x38c7290*/ SecureStringHasher();
            /*0x38c72b4*/ bool Equals(string x, string y);
            /*0x38c72c8*/ int GetHashCode(string key);

            class HashCodeOfStringDelegate : System.MulticastDelegate
            {
                /*0x38c751c*/ HashCodeOfStringDelegate(object object, nint method);
                /*0x38c75d0*/ int Invoke(string s, int sLen, long additionalEntropy);
            }
        }

        class TextEncodedRawTextWriter : System.Xml.XmlEncodedRawTextWriter
        {
            /*0x38c75e4*/ TextEncodedRawTextWriter(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings);
            /*0x38c76e4*/ TextEncodedRawTextWriter(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x38c79f4*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x38c79f8*/ void WriteXmlDeclaration(string xmldecl);
            /*0x38c79fc*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x38c7a00*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x38c7a04*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x38c7a08*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x38c7a0c*/ void StartElementContent();
            /*0x38c7a10*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x38c7a1c*/ void WriteEndAttribute();
            /*0x38c7a24*/ void WriteNamespaceDeclaration(string prefix, string ns);
            /*0x38c7a28*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0x38c7a30*/ void WriteCData(string text);
            /*0x38c7a98*/ void WriteComment(string text);
            /*0x38c7a9c*/ void WriteProcessingInstruction(string name, string text);
            /*0x38c7aa0*/ void WriteEntityRef(string name);
            /*0x38c7aa4*/ void WriteCharEntity(char ch);
            /*0x38c7aa8*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x38c7aac*/ void WriteWhitespace(string ws);
            /*0x38c7abc*/ void WriteString(string textBlock);
            /*0x38c7acc*/ void WriteChars(char[] buffer, int index, int count);
            /*0x38c7b58*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x38c7b68*/ void WriteRaw(string data);
        }

        class TextUtf8RawTextWriter : System.Xml.XmlUtf8RawTextWriter
        {
            /*0x38c7b78*/ TextUtf8RawTextWriter(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x38c7b80*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x38c7b84*/ void WriteXmlDeclaration(string xmldecl);
            /*0x38c7b88*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x38c7b8c*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x38c7b90*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x38c7b94*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x38c7b98*/ void StartElementContent();
            /*0x38c7b9c*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x38c7ba8*/ void WriteEndAttribute();
            /*0x38c7bb0*/ void WriteNamespaceDeclaration(string prefix, string ns);
            /*0x38c7bb4*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0x38c7bbc*/ void WriteCData(string text);
            /*0x38c7bc4*/ void WriteComment(string text);
            /*0x38c7bc8*/ void WriteProcessingInstruction(string name, string text);
            /*0x38c7bcc*/ void WriteEntityRef(string name);
            /*0x38c7bd0*/ void WriteCharEntity(char ch);
            /*0x38c7bd4*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x38c7bd8*/ void WriteWhitespace(string ws);
            /*0x38c7bec*/ void WriteString(string textBlock);
            /*0x38c7c00*/ void WriteChars(char[] buffer, int index, int count);
            /*0x38c7c14*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x38c7c28*/ void WriteRaw(string data);
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

            /*0x38c7c3c*/ ValidatingReaderNodeData();
            /*0x38c7d08*/ ValidatingReaderNodeData(System.Xml.XmlNodeType nodeType);
            /*0x38c7d34*/ string get_LocalName();
            /*0x38c7d3c*/ void set_LocalName(string value);
            /*0x38c7d44*/ string get_Namespace();
            /*0x38c7d4c*/ void set_Namespace(string value);
            /*0x38c7d54*/ string get_Prefix();
            /*0x38c7d5c*/ void set_Prefix(string value);
            /*0x38c7d64*/ string GetAtomizedNameWPrefix(System.Xml.XmlNameTable nameTable);
            /*0x38c7e08*/ int get_Depth();
            /*0x38c7e10*/ void set_Depth(int value);
            /*0x38c7e18*/ string get_RawValue();
            /*0x38c7e20*/ void set_RawValue(string value);
            /*0x38c7e28*/ string get_OriginalStringValue();
            /*0x38c7e30*/ System.Xml.XmlNodeType get_NodeType();
            /*0x38c7e38*/ void set_NodeType(System.Xml.XmlNodeType value);
            /*0x38c7e40*/ System.Xml.AttributePSVIInfo get_AttInfo();
            /*0x38c7e48*/ void set_AttInfo(System.Xml.AttributePSVIInfo value);
            /*0x38c7e50*/ int get_LineNumber();
            /*0x38c7e58*/ int get_LinePosition();
            /*0x38c7c5c*/ void Clear(System.Xml.XmlNodeType nodeType);
            /*0x38c7e60*/ void SetLineInfo(int lineNo, int linePos);
            /*0x38c7e68*/ void SetLineInfo(System.Xml.IXmlLineInfo lineInfo);
            /*0x38c7f70*/ void SetItemData(string localName, string prefix, string ns, int depth);
            /*0x38c7fe4*/ void SetItemData(string value);
            /*0x38c8014*/ void SetItemData(string value, string originalStringValue);
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

            static /*0x38c804c*/ System.Xml.XmlAsyncCheckReader CreateAsyncCheckWrapper(System.Xml.XmlReader reader);
            /*0x38c8470*/ XmlAsyncCheckReader(System.Xml.XmlReader reader);
            /*0x38c8044*/ System.Xml.XmlReader get_CoreReader();
            /*0x38c8528*/ void CheckAsync();
            /*0x38c85a4*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x38c8730*/ System.Xml.XmlNodeType get_NodeType();
            /*0x38c8758*/ string get_Name();
            /*0x38c8780*/ string get_LocalName();
            /*0x38c87a8*/ string get_NamespaceURI();
            /*0x38c87d0*/ string get_Prefix();
            /*0x38c87f8*/ string get_Value();
            /*0x38c8820*/ int get_Depth();
            /*0x38c8848*/ string get_BaseURI();
            /*0x38c8874*/ bool get_IsEmptyElement();
            /*0x38c88a0*/ bool get_IsDefault();
            /*0x38c88cc*/ char get_QuoteChar();
            /*0x38c88f8*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x38c8924*/ string get_XmlLang();
            /*0x38c8950*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x38c897c*/ System.Type get_ValueType();
            /*0x38c89a8*/ int get_AttributeCount();
            /*0x38c89d4*/ string GetAttribute(string name);
            /*0x38c8a10*/ string GetAttribute(string name, string namespaceURI);
            /*0x38c8a54*/ string GetAttribute(int i);
            /*0x38c8a90*/ bool MoveToAttribute(string name);
            /*0x38c8acc*/ void MoveToAttribute(int i);
            /*0x38c8b08*/ bool MoveToFirstAttribute();
            /*0x38c8b34*/ bool MoveToNextAttribute();
            /*0x38c8b60*/ bool MoveToElement();
            /*0x38c8b8c*/ bool ReadAttributeValue();
            /*0x38c8bb8*/ bool Read();
            /*0x38c8be4*/ bool get_EOF();
            /*0x38c8c10*/ void Close();
            /*0x38c8c3c*/ System.Xml.ReadState get_ReadState();
            /*0x38c8c68*/ void Skip();
            /*0x38c8c94*/ System.Xml.XmlNameTable get_NameTable();
            /*0x38c8cc0*/ string LookupNamespace(string prefix);
            /*0x38c8cfc*/ bool get_CanResolveEntity();
            /*0x38c8d28*/ void ResolveEntity();
            /*0x38c8d54*/ bool get_CanReadValueChunk();
            /*0x38c8d80*/ int ReadValueChunk(char[] buffer, int index, int count);
            /*0x38c8dd4*/ string ReadString();
            /*0x38c8e00*/ System.Xml.XmlNodeType MoveToContent();
            /*0x38c8e2c*/ void ReadStartElement();
            /*0x38c8e58*/ string ReadElementString();
            /*0x38c8e84*/ void ReadEndElement();
            /*0x38c8eb0*/ bool IsStartElement(string localname, string ns);
            /*0x38c8ef4*/ string ReadInnerXml();
            /*0x38c8f20*/ bool get_HasAttributes();
            /*0x38c8f4c*/ void Dispose(bool disposing);
            /*0x38c8f90*/ System.Xml.XmlNamespaceManager get_NamespaceManager();
            /*0x38c8fbc*/ System.Xml.IDtdInfo get_DtdInfo();
        }

        class XmlAsyncCheckReaderWithNS : System.Xml.XmlAsyncCheckReader, System.Xml.IXmlNamespaceResolver
        {
            /*0x20*/ System.Xml.IXmlNamespaceResolver readerAsIXmlNamespaceResolver;

            /*0x38c83c8*/ XmlAsyncCheckReaderWithNS(System.Xml.XmlReader reader);
            /*0x38c8fe8*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x38c9090*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0x38c913c*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
        }

        class XmlAsyncCheckReaderWithLineInfo : System.Xml.XmlAsyncCheckReader, System.Xml.IXmlLineInfo
        {
            /*0x20*/ System.Xml.IXmlLineInfo readerAsIXmlLineInfo;

            /*0x38c8320*/ XmlAsyncCheckReaderWithLineInfo(System.Xml.XmlReader reader);
            /*0x38c91e8*/ bool HasLineInfo();
            /*0x38c9288*/ int get_LineNumber();
            /*0x38c932c*/ int get_LinePosition();
        }

        class XmlAsyncCheckReaderWithLineInfoNS : System.Xml.XmlAsyncCheckReaderWithLineInfo, System.Xml.IXmlNamespaceResolver
        {
            /*0x28*/ System.Xml.IXmlNamespaceResolver readerAsIXmlNamespaceResolver;

            /*0x38c8278*/ XmlAsyncCheckReaderWithLineInfoNS(System.Xml.XmlReader reader);
            /*0x38c93d0*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x38c9478*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0x38c9524*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
        }

        class XmlAsyncCheckReaderWithLineInfoNSSchema : System.Xml.XmlAsyncCheckReaderWithLineInfoNS, System.Xml.Schema.IXmlSchemaInfo
        {
            /*0x30*/ System.Xml.Schema.IXmlSchemaInfo readerAsIXmlSchemaInfo;

            /*0x38c81d0*/ XmlAsyncCheckReaderWithLineInfoNSSchema(System.Xml.XmlReader reader);
            /*0x38c95d0*/ System.Xml.Schema.XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity();
            /*0x38c9670*/ bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault();
            /*0x38c9714*/ bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil();
            /*0x38c97b8*/ System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType();
            /*0x38c985c*/ System.Xml.Schema.XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType();
            /*0x38c9900*/ System.Xml.Schema.XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement();
            /*0x38c99a4*/ System.Xml.Schema.XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute();
        }

        class XmlAsyncCheckWriter : System.Xml.XmlWriter
        {
            /*0x18*/ System.Xml.XmlWriter coreWriter;
            /*0x20*/ System.Threading.Tasks.Task lastTask;

            /*0x38c9a48*/ XmlAsyncCheckWriter(System.Xml.XmlWriter writer);
            /*0x38c9ad4*/ void CheckAsync();
            /*0x38c9b50*/ void WriteStartDocument();
            /*0x38c9b78*/ void WriteStartDocument(bool standalone);
            /*0x38c9bb0*/ void WriteEndDocument();
            /*0x38c9bd8*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x38c9c30*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x38c9c80*/ void WriteEndElement();
            /*0x38c9ca8*/ void WriteFullEndElement();
            /*0x38c9cd0*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x38c9d20*/ void WriteEndAttribute();
            /*0x38c9d4c*/ void WriteCData(string text);
            /*0x38c9d88*/ void WriteComment(string text);
            /*0x38c9dc4*/ void WriteProcessingInstruction(string name, string text);
            /*0x38c9e08*/ void WriteEntityRef(string name);
            /*0x38c9e44*/ void WriteCharEntity(char ch);
            /*0x38c9e80*/ void WriteWhitespace(string ws);
            /*0x38c9ebc*/ void WriteString(string text);
            /*0x38c9ef8*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x38c9f3c*/ void WriteChars(char[] buffer, int index, int count);
            /*0x38c9f90*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x38c9fe4*/ void WriteRaw(string data);
            /*0x38ca020*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x38ca074*/ void WriteBinHex(byte[] buffer, int index, int count);
            /*0x38ca0c8*/ System.Xml.WriteState get_WriteState();
            /*0x38ca0f4*/ void Close();
            /*0x38ca120*/ void Flush();
            /*0x38ca14c*/ string LookupPrefix(string ns);
            /*0x38ca188*/ void WriteValue(string value);
            /*0x38ca1c4*/ void WriteAttributes(System.Xml.XmlReader reader, bool defattr);
            /*0x38ca208*/ void WriteNode(System.Xml.XmlReader reader, bool defattr);
            /*0x38ca24c*/ void Dispose(bool disposing);
        }

        class XmlAutoDetectWriter : System.Xml.XmlRawWriter
        {
            /*0x28*/ System.Xml.XmlRawWriter wrapped;
            /*0x30*/ System.Xml.OnRemoveWriter onRemove;
            /*0x38*/ System.Xml.XmlWriterSettings writerSettings;
            /*0x40*/ System.Xml.XmlEventCache eventCache;
            /*0x48*/ System.IO.TextWriter textWriter;
            /*0x50*/ System.IO.Stream strm;

            static /*0x38ca4dc*/ bool IsHtmlTag(string tagName);
            /*0x38ca270*/ XmlAutoDetectWriter(System.Xml.XmlWriterSettings writerSettings);
            /*0x38ca384*/ XmlAutoDetectWriter(System.IO.TextWriter textWriter, System.Xml.XmlWriterSettings writerSettings);
            /*0x38ca3b4*/ XmlAutoDetectWriter(System.IO.Stream strm, System.Xml.XmlWriterSettings writerSettings);
            /*0x38ca3e4*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x38ca45c*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x38ca730*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x38ca790*/ void WriteEndAttribute();
            /*0x38ca7b0*/ void WriteCData(string text);
            /*0x38ca858*/ void WriteComment(string text);
            /*0x38ca884*/ void WriteProcessingInstruction(string name, string text);
            /*0x38ca8b0*/ void WriteWhitespace(string ws);
            /*0x38ca8dc*/ void WriteString(string text);
            /*0x38ca924*/ void WriteChars(char[] buffer, int index, int count);
            /*0x38ca954*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x38ca984*/ void WriteRaw(string data);
            /*0x38ca9cc*/ void WriteEntityRef(string name);
            /*0x38caa18*/ void WriteCharEntity(char ch);
            /*0x38caa64*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x38caab8*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x38cab1c*/ void WriteBinHex(byte[] buffer, int index, int count);
            /*0x38cab80*/ void Close();
            /*0x38cabbc*/ void Flush();
            /*0x38cabf8*/ void WriteValue(string value);
            /*0x38cac44*/ void set_NamespaceResolver(System.Xml.IXmlNamespaceResolver value);
            /*0x38cac94*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x38cace0*/ void WriteXmlDeclaration(string xmldecl);
            /*0x38cad2c*/ void StartElementContent();
            /*0x38cad4c*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x38cad6c*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x38cad8c*/ void WriteNamespaceDeclaration(string prefix, string ns);
            /*0x38cade0*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0x38cae00*/ void WriteStartNamespaceDeclaration(string prefix);
            /*0x38cae4c*/ void WriteEndNamespaceDeclaration();
            /*0x38ca44c*/ void EnsureWrappedWriter(System.Xml.XmlOutputMethod outMethod);
            /*0x38ca7f8*/ bool TextBlockCreatesWriter(string textBlock);
            /*0x38ca5f0*/ void CreateWrappedWriter(System.Xml.XmlOutputMethod outMethod);
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

            static /*0x38ce1e8*/ char* EncodeSurrogate(char* pSrc, char* pSrcEnd, char* pDst);
            static /*0x38ce124*/ char* LtEntity(char* pDst);
            static /*0x38ce13c*/ char* GtEntity(char* pDst);
            static /*0x38ce100*/ char* AmpEntity(char* pDst);
            static /*0x38ce154*/ char* QuoteEntity(char* pDst);
            static /*0x38ce17c*/ char* TabEntity(char* pDst);
            static /*0x38ce1c4*/ char* LineFeedEntity(char* pDst);
            static /*0x38ce1a0*/ char* CarriageReturnEntity(char* pDst);
            static /*0x38ce5b8*/ char* CharEntity(char* pDst, char ch);
            static /*0x38ce580*/ char* RawStartCData(char* pDst);
            static /*0x38ce564*/ char* RawEndCData(char* pDst);
            /*0x38cb570*/ XmlEncodedRawTextWriter(System.Xml.XmlWriterSettings settings);
            /*0x38c75e8*/ XmlEncodedRawTextWriter(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings);
            /*0x38c76e8*/ XmlEncodedRawTextWriter(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x38cb9a8*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x38cbbc4*/ void WriteXmlDeclaration(string xmldecl);
            /*0x38cbc3c*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x38cbe2c*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x38cbef4*/ void StartElementContent();
            /*0x38cbf38*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x38cc0a8*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x38cc1b0*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x38cc2d0*/ void WriteEndAttribute();
            /*0x38cc338*/ void WriteNamespaceDeclaration(string prefix, string namespaceName);
            /*0x38cc38c*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0x38cc394*/ void WriteStartNamespaceDeclaration(string prefix);
            /*0x38cc4b8*/ void WriteEndNamespaceDeclaration();
            /*0x38cc520*/ void WriteCData(string text);
            /*0x38cca1c*/ void WriteComment(string text);
            /*0x38cce40*/ void WriteProcessingInstruction(string name, string text);
            /*0x38ccf6c*/ void WriteEntityRef(string name);
            /*0x38cd038*/ void WriteCharEntity(char ch);
            /*0x38cd1fc*/ void WriteWhitespace(string ws);
            /*0x38cd7f4*/ void WriteString(string text);
            /*0x38cd860*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x38cd9a8*/ void WriteChars(char[] buffer, int index, int count);
            /*0x38c7adc*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x38c7a34*/ void WriteRaw(string data);
            /*0x38cdc38*/ void Close();
            /*0x38cdd50*/ void Flush();
            /*0x38cdda8*/ void FlushBuffer();
            /*0x38cdfcc*/ void EncodeChars(int startOffset, int endOffset, bool writeAllToStream);
            /*0x38cdcb4*/ void FlushEncoder();
            /*0x38cd268*/ void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd);
            /*0x38cd564*/ void WriteElementTextBlock(char* pSrc, char* pSrcEnd);
            /*0x38cbb88*/ void RawText(string s);
            /*0x38ce3fc*/ void RawText(char* pSrcBegin, char* pSrcEnd);
            /*0x38cda30*/ void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd);
            /*0x38ccb48*/ void WriteCommentOrPi(string text, int stopChar);
            /*0x38cc700*/ void WriteCDataSection(string text);
            /*0x38ce33c*/ char* InvalidXmlChar(int ch, char* pDst, bool entitize);
            /*0x38ce678*/ void EncodeChar(ref char* pSrc, char* pSrcEnd, ref char* pDst);
            /*0x38cbb18*/ void ChangeTextContentMark(bool value);
            /*0x38ce71c*/ void GrowTextContentMarks();
            /*0x38ce3a0*/ char* WriteNewLine(char* pDst);
            /*0x38cb66c*/ void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace);
        }

        class XmlEncodedRawTextWriterIndent : System.Xml.XmlEncodedRawTextWriter
        {
            /*0xc0*/ int indentLevel;
            /*0xc4*/ bool newLineOnAttributes;
            /*0xc8*/ string indentChars;
            /*0xd0*/ bool mixedContent;
            /*0xd8*/ System.Xml.BitStack mixedContentStack;
            /*0xe0*/ System.Xml.ConformanceLevel conformanceLevel;

            /*0x38ce7a4*/ XmlEncodedRawTextWriterIndent(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings);
            /*0x38ce8dc*/ XmlEncodedRawTextWriterIndent(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x38ce904*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x38ce9ac*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x38cea18*/ void StartElementContent();
            /*0x38cea68*/ void OnRootElement(System.Xml.ConformanceLevel currentConformanceLevel);
            /*0x38cea70*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x38ceaf4*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x38ceb78*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x38cebb4*/ void WriteCData(string text);
            /*0x38cebc0*/ void WriteComment(string text);
            /*0x38cec00*/ void WriteProcessingInstruction(string target, string text);
            /*0x38cec48*/ void WriteEntityRef(string name);
            /*0x38cec54*/ void WriteCharEntity(char ch);
            /*0x38cec60*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x38cec6c*/ void WriteWhitespace(string ws);
            /*0x38cec78*/ void WriteString(string text);
            /*0x38cec84*/ void WriteChars(char[] buffer, int index, int count);
            /*0x38cec90*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x38cec9c*/ void WriteRaw(string data);
            /*0x38ceca8*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x38ce7cc*/ void Init(System.Xml.XmlWriterSettings settings);
            /*0x38ce964*/ void WriteIndent();
        }

        class XmlEventCache : System.Xml.XmlRawWriter
        {
            /*0x28*/ System.Collections.Generic.List<System.Xml.XmlEventCache.XmlEvent[]> pages;
            /*0x30*/ System.Xml.XmlEventCache.XmlEvent[] pageCurr;
            /*0x38*/ int pageSize;
            /*0x3c*/ bool hasRootNode;
            /*0x40*/ System.Xml.Xsl.Runtime.StringConcat singleText;
            /*0x78*/ string baseUri;

            static /*0x38cf1bc*/ byte[] ToBytes(byte[] buffer, int index, int count);
            /*0x38ca348*/ XmlEventCache(string baseUri, bool hasRootNode);
            /*0x38cae6c*/ void EndEvents();
            /*0x38cae80*/ void EventsToWriter(System.Xml.XmlWriter writer);
            /*0x38ceda8*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x38cee3c*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x38ceebc*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x38ceed0*/ void WriteEndAttribute();
            /*0x38ceed8*/ void WriteCData(string text);
            /*0x38cef38*/ void WriteComment(string text);
            /*0x38cef44*/ void WriteProcessingInstruction(string name, string text);
            /*0x38cefc8*/ void WriteWhitespace(string ws);
            /*0x38cefd4*/ void WriteString(string text);
            /*0x38ceff8*/ void WriteChars(char[] buffer, int index, int count);
            /*0x38cf028*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x38cf058*/ void WriteRaw(string data);
            /*0x38cf064*/ void WriteEntityRef(string name);
            /*0x38cf070*/ void WriteCharEntity(char ch);
            /*0x38cf104*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x38cf190*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x38cf270*/ void WriteBinHex(byte[] buffer, int index, int count);
            /*0x38cf29c*/ void Close();
            /*0x38cf2a4*/ void Flush();
            /*0x38cf2ac*/ void WriteValue(string value);
            /*0x38cf2bc*/ void Dispose(bool disposing);
            /*0x38cf364*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x38cf3d0*/ void WriteXmlDeclaration(string xmldecl);
            /*0x38cf3dc*/ void StartElementContent();
            /*0x38cf3e4*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x38cf3f8*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x38cf40c*/ void WriteNamespaceDeclaration(string prefix, string ns);
            /*0x38cf41c*/ void WriteEndBase64();
            /*0x38ced60*/ void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType);
            /*0x38ceee4*/ void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1);
            /*0x38cef54*/ void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1, string s2);
            /*0x38cee50*/ void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1, string s2, string s3);
            /*0x38cedc0*/ void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o);
            /*0x38cf0b0*/ void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, object o);
            /*0x38cf424*/ int NewEvent();

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

                /*0x38cf6dc*/ void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType);
                /*0x38cf5d0*/ void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1);
                /*0x38cf5e0*/ void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1, string s2);
                /*0x38cf618*/ void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1, string s2, string s3);
                /*0x38cf664*/ void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o);
                /*0x38cf6cc*/ void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, object o);
                /*0x38cf6e4*/ System.Xml.XmlEventCache.XmlEventType get_EventType();
                /*0x38cf6ec*/ string get_String1();
                /*0x38cf6f4*/ string get_String2();
                /*0x38cf6fc*/ string get_String3();
                /*0x38cf704*/ object get_Object();
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

            /*0x38cf70c*/ XmlParserContext(System.Xml.XmlNameTable nt, System.Xml.XmlNamespaceManager nsMgr, string xmlLang, System.Xml.XmlSpace xmlSpace);
            /*0x38cf75c*/ XmlParserContext(System.Xml.XmlNameTable nt, System.Xml.XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, System.Xml.XmlSpace xmlSpace);
            /*0x38cf788*/ XmlParserContext(System.Xml.XmlNameTable nt, System.Xml.XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, System.Xml.XmlSpace xmlSpace, System.Text.Encoding enc);
            /*0x38cfa40*/ System.Xml.XmlNameTable get_NameTable();
            /*0x38cfa48*/ System.Xml.XmlNamespaceManager get_NamespaceManager();
            /*0x38cfa50*/ string get_DocTypeName();
            /*0x38cfa58*/ string get_PublicId();
            /*0x38cfa60*/ string get_SystemId();
            /*0x38cfa68*/ string get_BaseURI();
            /*0x38cfa70*/ string get_InternalSubset();
            /*0x38cfa78*/ string get_XmlLang();
            /*0x38cfa80*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x38cfa88*/ System.Text.Encoding get_Encoding();
            /*0x38cfa90*/ bool get_HasDtdInfo();
        }

        class XmlRawWriter : System.Xml.XmlWriter
        {
            /*0x18*/ System.Xml.XmlRawWriterBase64Encoder base64Encoder;
            /*0x20*/ System.Xml.IXmlNamespaceResolver resolver;

            /*0x38c6754*/ XmlRawWriter();
            /*0x38cfb0c*/ void WriteStartDocument();
            /*0x38cfb64*/ void WriteStartDocument(bool standalone);
            /*0x38cfbbc*/ void WriteEndDocument();
            /*0x38cfc14*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x38cfc18*/ void WriteEndElement();
            /*0x38cfc70*/ void WriteFullEndElement();
            /*0x38cecb4*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x38cfcc8*/ string LookupPrefix(string ns);
            /*0x38cfd20*/ System.Xml.WriteState get_WriteState();
            /*0x38cfd78*/ void WriteCData(string text);
            /*0x38cfd88*/ void WriteCharEntity(char ch);
            /*0x38cfe1c*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x38cfec0*/ void WriteWhitespace(string ws);
            /*0x38cfed0*/ void WriteChars(char[] buffer, int index, int count);
            /*0x38cff00*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x38cff30*/ void WriteRaw(string data);
            /*0x38cff40*/ void WriteValue(string value);
            /*0x38cff50*/ void WriteAttributes(System.Xml.XmlReader reader, bool defattr);
            /*0x38cffa8*/ void WriteNode(System.Xml.XmlReader reader, bool defattr);
            /*0x38d0000*/ void set_NamespaceResolver(System.Xml.IXmlNamespaceResolver value);
            /*0x38d0008*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x38d000c*/ void WriteXmlDeclaration(string xmldecl);
            /*0x1f309e4*/ void StartElementContent();
            /*0x38d0010*/ void OnRootElement(System.Xml.ConformanceLevel conformanceLevel);
            /*0x1f310fc*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x38d0014*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x1f30ff0*/ void WriteNamespaceDeclaration(string prefix, string ns);
            /*0x38d0024*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0x38d002c*/ void WriteStartNamespaceDeclaration(string prefix);
            /*0x38d0064*/ void WriteEndNamespaceDeclaration();
            /*0x38d009c*/ void WriteEndBase64();
            /*0x38d00b4*/ void Close(System.Xml.WriteState currentState);
        }

        class XmlReader : System.IDisposable
        {
            static /*0x0*/ uint IsTextualNodeBitmap;
            static /*0x4*/ uint CanReadContentAsBitmap;
            static /*0x8*/ uint HasValueBitmap;

            static /*0x38d1f8c*/ XmlReader();
            static /*0x38d065c*/ bool IsTextualNode(System.Xml.XmlNodeType nodeType);
            static /*0x38d15e4*/ bool HasValueInternal(System.Xml.XmlNodeType nodeType);
            static /*0x38d1730*/ System.Xml.XmlReader Create(System.IO.Stream input, System.Xml.XmlReaderSettings settings, string baseUri);
            static /*0x38d195c*/ System.Xml.XmlReader Create(System.IO.TextReader input, System.Xml.XmlReaderSettings settings, string baseUri);
            static /*0x38d1afc*/ System.Xml.XmlReader CreateSqlReader(System.IO.Stream input, System.Xml.XmlReaderSettings settings, System.Xml.XmlParserContext inputContext);
            static /*0x38d1e0c*/ int CalcBufferSize(System.IO.Stream input);
            /*0x38c8520*/ XmlReader();
            /*0x38d00c4*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x1f2ffc8*/ System.Xml.XmlNodeType get_NodeType();
            /*0x38d00cc*/ string get_Name();
            /*0x1f30214*/ string get_LocalName();
            /*0x1f30214*/ string get_NamespaceURI();
            /*0x1f30214*/ string get_Prefix();
            /*0x1f30214*/ string get_Value();
            /*0x1f2ffc8*/ int get_Depth();
            /*0x1f30214*/ string get_BaseURI();
            /*0x1f2fe14*/ bool get_IsEmptyElement();
            /*0x38d01b0*/ bool get_IsDefault();
            /*0x38d01b8*/ char get_QuoteChar();
            /*0x38d01c0*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x38d01c8*/ string get_XmlLang();
            /*0x38d01e0*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x38d0228*/ System.Type get_ValueType();
            /*0x1f2ffc8*/ int get_AttributeCount();
            /*0x1f302cc*/ string GetAttribute(string name);
            /*0x1f30394*/ string GetAttribute(string name, string namespaceURI);
            /*0x1f30240*/ string GetAttribute(int i);
            /*0x1f2fec8*/ bool MoveToAttribute(string name);
            /*0x38d0258*/ void MoveToAttribute(int i);
            /*0x1f2fe14*/ bool MoveToFirstAttribute();
            /*0x1f2fe14*/ bool MoveToNextAttribute();
            /*0x1f2fe14*/ bool MoveToElement();
            /*0x1f2fe14*/ bool ReadAttributeValue();
            /*0x1f2fe14*/ bool Read();
            /*0x1f2fe14*/ bool get_EOF();
            /*0x38d0320*/ void Close();
            /*0x1f2ffc8*/ System.Xml.ReadState get_ReadState();
            /*0x38d0324*/ void Skip();
            /*0x1f30214*/ System.Xml.XmlNameTable get_NameTable();
            /*0x1f302cc*/ string LookupNamespace(string prefix);
            /*0x38d042c*/ bool get_CanResolveEntity();
            /*0x1f309e4*/ void ResolveEntity();
            /*0x38d0434*/ bool get_CanReadValueChunk();
            /*0x38d043c*/ int ReadValueChunk(char[] buffer, int index, int count);
            /*0x38d0494*/ string ReadString();
            /*0x38d06c0*/ System.Xml.XmlNodeType MoveToContent();
            /*0x38d0740*/ void ReadStartElement();
            /*0x38d0834*/ string ReadElementString();
            /*0x38d0a84*/ void ReadEndElement();
            /*0x38d0b78*/ bool IsStartElement(string localname, string ns);
            /*0x38d0bfc*/ string ReadInnerXml();
            /*0x38d0fe0*/ void WriteNode(System.Xml.XmlWriter xtw, bool defattr);
            /*0x38d0f08*/ void WriteAttributeValue(System.Xml.XmlWriter xtw);
            /*0x38d0e94*/ System.Xml.XmlWriter CreateWriterForInnerOuterXml(System.IO.StringWriter sw);
            /*0x38d1468*/ void SetNamespacesFlag(System.Xml.XmlTextWriter xtw);
            /*0x38d1574*/ bool get_HasAttributes();
            /*0x38c8f7c*/ void Dispose();
            /*0x38d1598*/ void Dispose(bool disposing);
            /*0x38d15dc*/ System.Xml.XmlNamespaceManager get_NamespaceManager();
            /*0x38d0358*/ bool SkipSubtree();
            /*0x38d1648*/ bool get_IsDefaultInternal();
            /*0x38d1728*/ System.Xml.IDtdInfo get_DtdInfo();
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

            static /*0x38d2bd8*/ System.Xml.XmlResolver CreateDefaultResolver();
            static /*0x38d2a64*/ bool EnableLegacyXmlSettings();
            /*0x38c86b0*/ XmlReaderSettings();
            /*0x38d1ff0*/ bool get_Async();
            /*0x38c86d0*/ void set_Async(bool value);
            /*0x38d20a4*/ System.Xml.XmlNameTable get_NameTable();
            /*0x38d20ac*/ void set_NameTable(System.Xml.XmlNameTable value);
            /*0x38d2110*/ bool get_IsXmlResolverSet();
            /*0x38d2118*/ void set_IsXmlResolverSet(bool value);
            /*0x38d2120*/ void set_XmlResolver(System.Xml.XmlResolver value);
            /*0x38d2190*/ System.Xml.XmlResolver GetXmlResolver();
            /*0x38d2198*/ System.Xml.XmlResolver GetXmlResolver_CheckConfig();
            /*0x38d21c8*/ int get_LineNumberOffset();
            /*0x38d21d0*/ void set_LineNumberOffset(int value);
            /*0x38d222c*/ int get_LinePositionOffset();
            /*0x38d2234*/ void set_LinePositionOffset(int value);
            /*0x38d2290*/ System.Xml.ConformanceLevel get_ConformanceLevel();
            /*0x38d2298*/ void set_ConformanceLevel(System.Xml.ConformanceLevel value);
            /*0x38d2344*/ bool get_CheckCharacters();
            /*0x38d234c*/ void set_CheckCharacters(bool value);
            /*0x38d23ac*/ long get_MaxCharactersInDocument();
            /*0x38d23b4*/ void set_MaxCharactersInDocument(long value);
            /*0x38d245c*/ long get_MaxCharactersFromEntities();
            /*0x38d2464*/ void set_MaxCharactersFromEntities(long value);
            /*0x38d250c*/ bool get_IgnoreWhitespace();
            /*0x38d2514*/ void set_IgnoreWhitespace(bool value);
            /*0x38d2574*/ bool get_IgnoreProcessingInstructions();
            /*0x38d257c*/ void set_IgnoreProcessingInstructions(bool value);
            /*0x38d25dc*/ bool get_IgnoreComments();
            /*0x38d25e4*/ void set_IgnoreComments(bool value);
            /*0x38d2644*/ System.Xml.DtdProcessing get_DtdProcessing();
            /*0x38d264c*/ void set_DtdProcessing(System.Xml.DtdProcessing value);
            /*0x38d26f8*/ bool get_CloseInput();
            /*0x38d2700*/ void set_CloseInput(bool value);
            /*0x38d2760*/ System.Xml.ValidationType get_ValidationType();
            /*0x38d2768*/ void set_ValidationType(System.Xml.ValidationType value);
            /*0x38d2814*/ System.Xml.Schema.XmlSchemaValidationFlags get_ValidationFlags();
            /*0x38d281c*/ void set_ValidationFlags(System.Xml.Schema.XmlSchemaValidationFlags value);
            /*0x38d28c8*/ System.Xml.Schema.XmlSchemaSet get_Schemas();
            /*0x38d2938*/ void set_Schemas(System.Xml.Schema.XmlSchemaSet value);
            /*0x38c8648*/ System.Xml.XmlReaderSettings Clone();
            /*0x38d299c*/ System.Xml.Schema.ValidationEventHandler GetEventHandler();
            /*0x38d17c0*/ System.Xml.XmlReader CreateReader(System.IO.Stream input, System.Uri baseUri, string baseUriString, System.Xml.XmlParserContext inputContext);
            /*0x38d19e8*/ System.Xml.XmlReader CreateReader(System.IO.TextReader input, string baseUriString, System.Xml.XmlParserContext inputContext);
            /*0x38d29a4*/ void set_ReadOnly(bool value);
            /*0x38d1ff8*/ void CheckReadOnly(string propertyName);
            /*0x38d1fe8*/ void Initialize();
            /*0x38d29ac*/ void Initialize(System.Xml.XmlResolver resolver);
            /*0x38d1e90*/ System.Xml.XmlReader AddValidation(System.Xml.XmlReader reader);
            /*0x38d2c2c*/ System.Xml.XmlValidatingReaderImpl CreateDtdValidatingReader(System.Xml.XmlReader baseReader);
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

            /*0x38d2ca4*/ XmlTextEncoder(System.IO.TextWriter textWriter);
            /*0x38d2cf4*/ void set_QuoteChar(char value);
            /*0x38d2cfc*/ void StartAttribute(bool cacheAttrValue);
            /*0x38d2dac*/ void EndAttribute();
            /*0x38d2de4*/ string get_AttributeValue();
            /*0x38d2e20*/ void WriteSurrogateChar(char lowChar, char highChar);
            /*0x38d2ed4*/ void Write(char[] array, int offset, int count);
            /*0x38d33e4*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x38d3564*/ void Write(string text);
            /*0x38d3a44*/ void WriteRawWithSurrogateChecking(string text);
            /*0x38d3c30*/ void WriteRaw(char[] array, int offset, int count);
            /*0x38d3d5c*/ void WriteCharEntity(char ch);
            /*0x38d3f34*/ void WriteEntityRef(string name);
            /*0x38d399c*/ void WriteStringFragment(string str, int offset, int count, char[] helperBuffer);
            /*0x38d32f8*/ void WriteCharEntityImpl(char ch);
            /*0x38d3e9c*/ void WriteCharEntityImpl(string strVal);
            /*0x38d3374*/ void WriteEntityRefImpl(string name);
        }

        class XmlTextReader : System.Xml.XmlReader, System.Xml.IXmlLineInfo, System.Xml.IXmlNamespaceResolver
        {
            /*0x10*/ System.Xml.XmlTextReaderImpl impl;

            /*0x38d3fa0*/ XmlTextReader(System.IO.Stream input);
            /*0x38d4060*/ XmlTextReader(string url, System.IO.Stream input, System.Xml.XmlNameTable nt);
            /*0x38d4138*/ XmlTextReader(System.IO.TextReader input);
            /*0x38d41f8*/ XmlTextReader(System.IO.TextReader input, System.Xml.XmlNameTable nt);
            /*0x38d42c0*/ System.Xml.XmlNodeType get_NodeType();
            /*0x38d42dc*/ string get_Name();
            /*0x38d42f8*/ string get_LocalName();
            /*0x38d4314*/ string get_NamespaceURI();
            /*0x38d4330*/ string get_Prefix();
            /*0x38d434c*/ string get_Value();
            /*0x38d4368*/ int get_Depth();
            /*0x38d4384*/ string get_BaseURI();
            /*0x38d43a4*/ bool get_IsEmptyElement();
            /*0x38d43c4*/ bool get_IsDefault();
            /*0x38d43e4*/ char get_QuoteChar();
            /*0x38d4404*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x38d4424*/ string get_XmlLang();
            /*0x38d4444*/ int get_AttributeCount();
            /*0x38d4464*/ string GetAttribute(string name);
            /*0x38d4484*/ string GetAttribute(string localName, string namespaceURI);
            /*0x38d44a4*/ string GetAttribute(int i);
            /*0x38d44c4*/ bool MoveToAttribute(string name);
            /*0x38d44e4*/ void MoveToAttribute(int i);
            /*0x38d4504*/ bool MoveToFirstAttribute();
            /*0x38d4524*/ bool MoveToNextAttribute();
            /*0x38d4544*/ bool MoveToElement();
            /*0x38d4564*/ bool ReadAttributeValue();
            /*0x38d4584*/ bool Read();
            /*0x38d45a4*/ bool get_EOF();
            /*0x38d45c4*/ void Close();
            /*0x38d45e4*/ System.Xml.ReadState get_ReadState();
            /*0x38d4604*/ void Skip();
            /*0x38d4624*/ System.Xml.XmlNameTable get_NameTable();
            /*0x38d4644*/ string LookupNamespace(string prefix);
            /*0x38d467c*/ bool get_CanResolveEntity();
            /*0x38d4684*/ void ResolveEntity();
            /*0x38d46a4*/ bool get_CanReadValueChunk();
            /*0x38d46ac*/ string ReadString();
            /*0x38d46d4*/ bool HasLineInfo();
            /*0x38d46dc*/ int get_LineNumber();
            /*0x38d46f4*/ int get_LinePosition();
            /*0x38d470c*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x38d4724*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0x38d4744*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            /*0x38d155c*/ bool get_Namespaces();
            /*0x38d475c*/ bool get_Normalization();
            /*0x38d4774*/ void set_Normalization(bool value);
            /*0x38d4790*/ void set_WhitespaceHandling(System.Xml.WhitespaceHandling value);
            /*0x38d47a8*/ void set_EntityHandling(System.Xml.EntityHandling value);
            /*0x38d47c0*/ void set_XmlResolver(System.Xml.XmlResolver value);
            /*0x38d47d8*/ System.Xml.XmlTextReaderImpl get_Impl();
            /*0x38d47e0*/ System.Xml.XmlNamespaceManager get_NamespaceManager();
            /*0x38d4800*/ void set_XmlValidatingReaderCompatibilityMode(bool value);
            /*0x38d481c*/ System.Xml.IDtdInfo get_DtdInfo();
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
            /*0x1a4*/ int incReadDepth;
            /*0x1a8*/ int incReadLeftStartPos;
            /*0x1ac*/ int incReadLeftEndPos;
            /*0x1b0*/ int attributeValueBaseEntityId;
            /*0x1b4*/ bool emptyEntityInAttributeResolved;
            /*0x1b8*/ System.Xml.IValidationEventHandling validationEventHandling;
            /*0x1c0*/ System.Xml.XmlTextReaderImpl.OnDefaultAttributeUseDelegate onDefaultAttributeUse;
            /*0x1c8*/ bool validatingReaderCompatFlag;
            /*0x1c9*/ bool addDefaultAttributesAndNormalize;
            /*0x1d0*/ System.Text.StringBuilder stringBuilder;
            /*0x1d8*/ bool rootElementParsed;
            /*0x1d9*/ bool standalone;
            /*0x1dc*/ int nextEntityId;
            /*0x1e0*/ System.Xml.XmlTextReaderImpl.ParsingMode parsingMode;
            /*0x1e4*/ System.Xml.ReadState readState;
            /*0x1e8*/ System.Xml.IDtdEntityInfo lastEntity;
            /*0x1f0*/ bool afterResetState;
            /*0x1f4*/ int documentStartBytePos;
            /*0x1f8*/ int readValueOffset;
            /*0x200*/ long charactersInDocument;
            /*0x208*/ long charactersFromEntities;
            /*0x210*/ System.Collections.Generic.Dictionary<System.Xml.IDtdEntityInfo, System.Xml.IDtdEntityInfo> currentEntities;
            /*0x218*/ bool disableUndeclaredEntityCheck;
            /*0x220*/ System.Xml.XmlReader outerReader;
            /*0x228*/ bool xmlResolverIsSet;
            /*0x230*/ string Xml;
            /*0x238*/ string XmlNs;
            /*0x240*/ System.Threading.Tasks.Task<System.Tuple<int, int, int, bool>> parseText_dummyTask;

            static /*0x38187dc*/ string StripSpaces(string value);
            static /*0x38189f4*/ void StripSpaces(char[] value, int index, ref int len);
            static /*0x380c268*/ void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count);
            static /*0x38100d0*/ void BlockCopy(byte[] src, int srcOffset, byte[] dst, int dstOffset, int count);
            /*0x3805798*/ XmlTextReaderImpl(System.Xml.XmlNameTable nt);
            /*0x3805bd4*/ XmlTextReaderImpl(System.Xml.XmlResolver resolver, System.Xml.XmlReaderSettings settings, System.Xml.XmlParserContext context);
            /*0x3806350*/ XmlTextReaderImpl(System.IO.Stream input);
            /*0x38063d4*/ XmlTextReaderImpl(string url, System.IO.Stream input, System.Xml.XmlNameTable nt);
            /*0x3806514*/ XmlTextReaderImpl(System.IO.TextReader input);
            /*0x3806670*/ XmlTextReaderImpl(System.IO.TextReader input, System.Xml.XmlNameTable nt);
            /*0x3806598*/ XmlTextReaderImpl(string url, System.IO.TextReader input, System.Xml.XmlNameTable nt);
            /*0x38066a0*/ XmlTextReaderImpl(string xmlFragment, System.Xml.XmlNodeType fragType, System.Xml.XmlParserContext context);
            /*0x3806b1c*/ XmlTextReaderImpl(string xmlFragment, System.Xml.XmlParserContext context);
            /*0x38072e4*/ XmlTextReaderImpl(System.IO.Stream stream, byte[] bytes, int byteCount, System.Xml.XmlReaderSettings settings, System.Uri baseUri, string baseUriStr, System.Xml.XmlParserContext context, bool closeInput);
            /*0x3807660*/ XmlTextReaderImpl(System.IO.TextReader input, System.Xml.XmlReaderSettings settings, string baseUriStr, System.Xml.XmlParserContext context);
            /*0x380780c*/ XmlTextReaderImpl(string xmlFragment, System.Xml.XmlParserContext context, System.Xml.XmlReaderSettings settings);
            /*0x3806c64*/ void FinishInitUriString();
            /*0x38075c4*/ void FinishInitStream();
            /*0x380778c*/ void FinishInitTextReader();
            /*0x3807888*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x38079fc*/ System.Xml.XmlNodeType get_NodeType();
            /*0x3807a14*/ string get_Name();
            /*0x3807a34*/ string get_LocalName();
            /*0x3807a4c*/ string get_NamespaceURI();
            /*0x3807a64*/ string get_Prefix();
            /*0x3807a7c*/ string get_Value();
            /*0x3807c88*/ int get_Depth();
            /*0x3807ca0*/ string get_BaseURI();
            /*0x3807ca8*/ bool get_IsEmptyElement();
            /*0x3807cc0*/ bool get_IsDefault();
            /*0x3807cd8*/ char get_QuoteChar();
            /*0x3807d04*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x3807d1c*/ string get_XmlLang();
            /*0x3807d34*/ System.Xml.ReadState get_ReadState();
            /*0x3807d3c*/ bool get_EOF();
            /*0x3807d4c*/ System.Xml.XmlNameTable get_NameTable();
            /*0x3807d54*/ bool get_CanResolveEntity();
            /*0x3807d5c*/ int get_AttributeCount();
            /*0x3807d64*/ string GetAttribute(string name);
            /*0x3807f84*/ string GetAttribute(string localName, string namespaceURI);
            /*0x38080dc*/ string GetAttribute(int i);
            /*0x3808178*/ bool MoveToAttribute(string name);
            /*0x3808300*/ void MoveToAttribute(int i);
            /*0x38083c4*/ bool MoveToFirstAttribute();
            /*0x3808444*/ bool MoveToNextAttribute();
            /*0x38084e4*/ bool MoveToElement();
            /*0x3808574*/ void FinishInit();
            /*0x38085ac*/ bool Read();
            /*0x380a6b8*/ void Close();
            /*0x380a784*/ void Skip();
            /*0x380a91c*/ string LookupNamespace(string prefix);
            /*0x380a94c*/ bool ReadAttributeValue();
            /*0x380b028*/ void ResolveEntity();
            /*0x380b74c*/ void set_OuterReader(System.Xml.XmlReader value);
            /*0x380b75c*/ void MoveOffEntityReference();
            /*0x380b80c*/ string ReadString();
            /*0x380b828*/ bool get_CanReadValueChunk();
            /*0x380b830*/ int ReadValueChunk(char[] buffer, int index, int count);
            /*0x380c27c*/ bool HasLineInfo();
            /*0x380c284*/ int get_LineNumber();
            /*0x380c29c*/ int get_LinePosition();
            /*0x380c2b4*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x380c2f4*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0x380c304*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            /*0x380c2d4*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x380c324*/ string LookupPrefix(string namespaceName);
            /*0x380c344*/ bool get_Namespaces();
            /*0x380c34c*/ void set_Namespaces(bool value);
            /*0x380c540*/ bool get_Normalization();
            /*0x380c548*/ void set_Normalization(bool value);
            /*0x380c664*/ void set_WhitespaceHandling(System.Xml.WhitespaceHandling value);
            /*0x380c72c*/ void set_EntityHandling(System.Xml.EntityHandling value);
            /*0x380c7a8*/ bool get_IsResolverSet();
            /*0x380c7b0*/ void set_XmlResolver(System.Xml.XmlResolver value);
            /*0x380c838*/ System.Xml.XmlNameTable get_DtdParserProxy_NameTable();
            /*0x380c840*/ System.Xml.IXmlNamespaceResolver get_DtdParserProxy_NamespaceResolver();
            /*0x380c848*/ bool get_DtdParserProxy_DtdValidation();
            /*0x380c868*/ bool get_DtdParserProxy_Normalization();
            /*0x380c870*/ bool get_DtdParserProxy_Namespaces();
            /*0x380c878*/ bool get_DtdParserProxy_V1CompatibilityMode();
            /*0x380c880*/ System.Uri get_DtdParserProxy_BaseUri();
            /*0x380c934*/ bool get_DtdParserProxy_IsEof();
            /*0x380c93c*/ char[] get_DtdParserProxy_ParsingBuffer();
            /*0x380c944*/ int get_DtdParserProxy_ParsingBufferLength();
            /*0x380c94c*/ int get_DtdParserProxy_CurrentPosition();
            /*0x380c954*/ void set_DtdParserProxy_CurrentPosition(int value);
            /*0x380c95c*/ int get_DtdParserProxy_EntityStackLength();
            /*0x380c968*/ bool get_DtdParserProxy_IsEntityEolNormalized();
            /*0x380c970*/ System.Xml.IValidationEventHandling get_DtdParserProxy_ValidationEventHandling();
            /*0x380c978*/ void DtdParserProxy_OnNewLine(int pos);
            /*0x380c9a0*/ int get_DtdParserProxy_LineNo();
            /*0x380c9a8*/ int get_DtdParserProxy_LineStartPosition();
            /*0x380c9b0*/ int DtdParserProxy_ReadData();
            /*0x380cdfc*/ int DtdParserProxy_ParseNumericCharRef(System.Text.StringBuilder internalSubsetBuilder);
            /*0x380cedc*/ int DtdParserProxy_ParseNamedCharRef(bool expand, System.Text.StringBuilder internalSubsetBuilder);
            /*0x380cf44*/ void DtdParserProxy_ParsePI(System.Text.StringBuilder sb);
            /*0x380d2ec*/ void DtdParserProxy_ParseComment(System.Text.StringBuilder sb);
            /*0x380d69c*/ bool get_IsResolverNull();
            /*0x380d6dc*/ System.Xml.XmlResolver GetTempResolver();
            /*0x380d73c*/ bool DtdParserProxy_PushEntity(System.Xml.IDtdEntityInfo entity, ref int entityId);
            /*0x380dee8*/ bool DtdParserProxy_PopEntity(ref System.Xml.IDtdEntityInfo oldEntity, ref int newEntityId);
            /*0x380df98*/ bool DtdParserProxy_PushExternalSubset(string systemId, string publicId);
            /*0x380e6b4*/ void DtdParserProxy_PushInternalDtd(string baseUri, string internalDtd);
            /*0x380e91c*/ void DtdParserProxy_Throw(System.Exception e);
            /*0x380e9ac*/ void DtdParserProxy_OnSystemId(string systemId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo systemLiteralLineInfo);
            /*0x380eab4*/ void DtdParserProxy_OnPublicId(string publicId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo publicLiteralLineInfo);
            /*0x380eb40*/ void Throw(int pos, string res, string arg);
            /*0x380ebe8*/ void Throw(int pos, string res, string[] args);
            /*0x380ec90*/ void Throw(int pos, string res);
            /*0x38075a8*/ void Throw(string res);
            /*0x380ecb8*/ void Throw(string res, int lineNo, int linePos);
            /*0x380eb54*/ void Throw(string res, string arg);
            /*0x380ed4c*/ void Throw(string res, string arg, int lineNo, int linePos);
            /*0x380ebfc*/ void Throw(string res, string[] args);
            /*0x380edd0*/ void Throw(string res, string arg, System.Exception innerException);
            /*0x380ee60*/ void Throw(string res, string[] args, System.Exception innerException);
            /*0x380e924*/ void Throw(System.Exception e);
            /*0x380ef14*/ void ReThrow(System.Exception e, int lineNo, int linePos);
            /*0x380a4cc*/ void ThrowWithoutLineInfo(string res);
            /*0x380efb4*/ void ThrowWithoutLineInfo(string res, string arg);
            /*0x380f024*/ void ThrowWithoutLineInfo(string res, string[] args, System.Exception innerException);
            /*0x380f0a8*/ void ThrowInvalidChar(char[] data, int length, int invCharPos);
            /*0x380ef00*/ void SetErrorState();
            /*0x380d5f8*/ void SendValidationEvent(System.Xml.Schema.XmlSeverityType severity, string code, string arg, int lineNo, int linePos);
            /*0x380f118*/ void SendValidationEvent(System.Xml.Schema.XmlSeverityType severity, System.Xml.Schema.XmlSchemaException exception);
            /*0x380823c*/ bool get_InAttributeValueIterator();
            /*0x3808260*/ void FinishAttributeValueIterator();
            /*0x380c858*/ bool get_DtdValidation();
            /*0x38064cc*/ void InitStreamInput(System.IO.Stream stream, System.Text.Encoding encoding);
            /*0x38064f8*/ void InitStreamInput(string baseUriStr, System.IO.Stream stream, System.Text.Encoding encoding);
            /*0x380f348*/ void InitStreamInput(System.Uri baseUri, System.IO.Stream stream, System.Text.Encoding encoding);
            /*0x380f3a8*/ void InitStreamInput(System.Uri baseUri, string baseUriStr, System.IO.Stream stream, System.Text.Encoding encoding);
            /*0x3806fa0*/ void InitStreamInput(System.Uri baseUri, string baseUriStr, System.IO.Stream stream, byte[] bytes, int byteCount, System.Text.Encoding encoding);
            /*0x3806694*/ void InitTextReaderInput(string baseUriStr, System.IO.TextReader input);
            /*0x380f73c*/ void InitTextReaderInput(string baseUriStr, System.Uri baseUri, System.IO.TextReader input);
            /*0x38067a8*/ void InitStringInput(string baseUriStr, System.Text.Encoding originalEncoding, string str);
            /*0x38068ac*/ void InitFragmentReader(System.Xml.XmlNodeType fragmentType, System.Xml.XmlParserContext parserContext, bool allowXmlDeclFragment);
            /*0x3807278*/ void ProcessDtdFromParserContext(System.Xml.XmlParserContext context);
            /*0x38091f0*/ void OpenUrl();
            /*0x380fa60*/ void OpenUrlDelegate(object xmlResolver);
            /*0x380f3b8*/ System.Text.Encoding DetectEncoding();
            /*0x380f5d0*/ void SetupEncoding(System.Text.Encoding encoding);
            /*0x380fb8c*/ void SwitchEncoding(System.Text.Encoding newEncoding);
            /*0x380fd24*/ System.Text.Encoding CheckEncoding(string newEncodingName);
            /*0x380fc7c*/ void UnDecodeChars();
            /*0x381006c*/ void SwitchEncodingToUTF8();
            /*0x380c9b4*/ int ReadData();
            /*0x38100d8*/ int GetChars(int maxCharsCount);
            /*0x3810210*/ void InvalidCharRecovery(ref int bytesCount, ref int charsCount);
            /*0x380a6c0*/ void Close(bool closeInput);
            /*0x381042c*/ void ShiftBuffer(int sourcePos, int destPos, int count);
            /*0x38093a8*/ bool ParseXmlDeclaration(bool isTextDecl);
            /*0x3808cdc*/ bool ParseDocumentContent();
            /*0x38089b8*/ bool ParseElementContent();
            /*0x38119e4*/ void ThrowUnclosedElements();
            /*0x3810924*/ void ParseElement();
            /*0x38121c8*/ void AddDefaultAttributesAndNormalize();
            /*0x3811650*/ void ParseEndElement();
            /*0x3813334*/ void ThrowTagMismatch(System.Xml.XmlTextReaderImpl.NodeData startTag);
            /*0x3811b90*/ void ParseAttributes();
            /*0x3812bac*/ void ElementNamespaceLookup();
            /*0x3813274*/ void AttributeNamespaceLookup();
            /*0x3814434*/ void AttributeDuplCheck();
            /*0x38140a8*/ void OnDefaultNamespaceDecl(System.Xml.XmlTextReaderImpl.NodeData attr);
            /*0x38141ac*/ void OnNamespaceDecl(System.Xml.XmlTextReaderImpl.NodeData attr);
            /*0x3814264*/ void OnXmlReservedAttribute(System.Xml.XmlTextReaderImpl.NodeData attr);
            /*0x3813734*/ void ParseAttributeValueSlow(int curPos, char quoteChar, System.Xml.XmlTextReaderImpl.NodeData attr);
            /*0x3814ae0*/ void AddAttributeChunkToList(System.Xml.XmlTextReaderImpl.NodeData attr, System.Xml.XmlTextReaderImpl.NodeData chunk, ref System.Xml.XmlTextReaderImpl.NodeData lastChunk);
            /*0x38110d0*/ bool ParseText();
            /*0x380bc8c*/ bool ParseText(ref int startPos, ref int endPos, ref int outOrChars);
            /*0x3807ac4*/ void FinishPartialValue();
            /*0x3807b98*/ void FinishOtherValueIterator();
            /*0x380a54c*/ void SkipPartialTextValue();
            /*0x380a58c*/ void FinishReadValueChunk();
            /*0x380a5ac*/ void FinishReadContentAsBinary();
            /*0x380a5fc*/ void FinishReadElementContentAsBinary();
            /*0x3811440*/ bool ParseRootLevelWhitespace();
            /*0x380a0ac*/ void ParseEntityReference();
            /*0x3810df4*/ System.Xml.XmlTextReaderImpl.EntityType HandleEntityReference(bool isInAttributeValue, System.Xml.XmlTextReaderImpl.EntityExpandType expandType, ref int charRefEndPos);
            /*0x380b270*/ System.Xml.XmlTextReaderImpl.EntityType HandleGeneralEntityReference(string name, bool isInAttributeValue, bool pushFakeEntityIfNullResolver, int entityStartLinePos);
            /*0x381005c*/ bool get_InEntity();
            /*0x380f1e0*/ bool HandleEntityEnd(bool checkEntityNesting);
            /*0x380a120*/ void SetupEndEntityNodeInContent();
            /*0x3814eec*/ void SetupEndEntityNodeInAttribute();
            /*0x3810604*/ bool ParsePI();
            /*0x380cf88*/ bool ParsePI(System.Text.StringBuilder piInDtdStringBuilder);
            /*0x3814f64*/ bool ParsePIValue(ref int outStartPos, ref int outEndPos);
            /*0x381060c*/ bool ParseComment();
            /*0x3810674*/ void ParseCData();
            /*0x380d49c*/ void ParseCDataOrComment(System.Xml.XmlNodeType type);
            /*0x38152e0*/ bool ParseCDataOrComment(System.Xml.XmlNodeType type, ref int outStartPos, ref int outEndPos);
            /*0x381067c*/ bool ParseDoctypeDecl();
            /*0x38156f8*/ void ParseDtd();
            /*0x3815a10*/ void SkipDtd();
            /*0x3815d58*/ void SkipPublicOrSystemIdLiteral();
            /*0x3815e04*/ void SkipUntil(char stopChar, bool recognizeLiterals);
            /*0x380e448*/ int EatWhitespaces(System.Text.StringBuilder sb);
            /*0x3814cf4*/ int ParseCharRefInline(int startPos, ref int charCount, ref System.Xml.XmlTextReaderImpl.EntityType entityType);
            /*0x380ce1c*/ int ParseNumericCharRef(bool expand, System.Text.StringBuilder internalSubsetBuilder, ref System.Xml.XmlTextReaderImpl.EntityType entityType);
            /*0x3816270*/ int ParseNumericCharRefInline(int startPos, bool expand, System.Text.StringBuilder internalSubsetBuilder, ref int charCount, ref System.Xml.XmlTextReaderImpl.EntityType entityType);
            /*0x380cee0*/ int ParseNamedCharRef(bool expand, System.Text.StringBuilder internalSubsetBuilder);
            /*0x3816860*/ int ParseNamedCharRefInline(int startPos, bool expand, System.Text.StringBuilder internalSubsetBuilder);
            /*0x3810458*/ int ParseName();
            /*0x3811b80*/ int ParseQName(ref int colonPos);
            /*0x3816b38*/ int ParseQName(bool isQName, int startOffset, ref int colonPos);
            /*0x3816da0*/ bool ReadDataInName(ref int pos);
            /*0x3814b40*/ string ParseEntityName();
            /*0x380a024*/ System.Xml.XmlTextReaderImpl.NodeData AddNode(int nodeIndex, int nodeDepth);
            /*0x3816de0*/ System.Xml.XmlTextReaderImpl.NodeData AllocNode(int nodeIndex, int nodeDepth);
            /*0x380ea38*/ System.Xml.XmlTextReaderImpl.NodeData AddAttributeNoChecks(string name, int attrDepth);
            /*0x3813594*/ System.Xml.XmlTextReaderImpl.NodeData AddAttribute(int endNamePos, int colonPos);
            /*0x3816f34*/ System.Xml.XmlTextReaderImpl.NodeData AddAttribute(string localName, string prefix, string nameWPrefix);
            /*0x380a068*/ void PopElementContext();
            /*0x380c98c*/ void OnNewLine(int pos);
            /*0x380a42c*/ void OnEof();
            /*0x38147b4*/ string LookupNamespace(System.Xml.XmlTextReaderImpl.NodeData node);
            /*0x38148e0*/ void AddNamespace(string prefix, string uri, System.Xml.XmlTextReaderImpl.NodeData attr);
            /*0x3809ff8*/ void ResetAttributes();
            /*0x381708c*/ void FullAttributeCleanup();
            /*0x3814860*/ void PushXmlContext();
            /*0x3817054*/ void PopXmlContext();
            /*0x3814ea8*/ System.Xml.XmlNodeType GetWhitespaceType();
            /*0x3814ca0*/ System.Xml.XmlNodeType GetTextNodeType(int orChars);
            /*0x380e0e0*/ void PushExternalEntityOrSubset(string publicId, string systemId, System.Uri baseUri, string entityName);
            /*0x3817128*/ bool OpenAndPush(System.Uri uri);
            /*0x380d848*/ bool PushExternalEntity(System.Xml.IDtdEntityInfo entity);
            /*0x380dbcc*/ void PushInternalEntity(System.Xml.IDtdEntityInfo entity);
            /*0x380df4c*/ void PopEntity();
            /*0x381734c*/ void RegisterEntity(System.Xml.IDtdEntityInfo entity);
            /*0x38175cc*/ void UnregisterEntity();
            /*0x380e724*/ void PushParsingState();
            /*0x38103c4*/ void PopParsingState();
            /*0x3817630*/ int IncrementalRead();
            /*0x380a280*/ void FinishIncrementalRead();
            /*0x380a2f8*/ bool ParseFragmentAttribute();
            /*0x380abc4*/ bool ParseAttributeValueChunk();
            /*0x380a380*/ void ParseXmlDeclarationFragment();
            /*0x3810660*/ void ThrowUnexpectedToken(int pos, string expectedToken);
            /*0x381044c*/ void ThrowUnexpectedToken(string expectedToken1);
            /*0x3810910*/ void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2);
            /*0x3810478*/ void ThrowUnexpectedToken(string expectedToken1, string expectedToken2);
            /*0x3810908*/ string ParseUnexpectedToken(int pos);
            /*0x3817f98*/ string ParseUnexpectedToken();
            /*0x3813508*/ void ThrowExpectingWhitespace(int pos);
            /*0x3807df8*/ int GetIndexOfAttributeWithoutPrefix(string name);
            /*0x3807ee0*/ int GetIndexOfAttributeWithPrefix(string name);
            /*0x3814d60*/ bool ZeroEndingStream(int pos);
            /*0x380f830*/ void ParseDtdFromParserContext();
            /*0x3814ddc*/ bool MoveToNextContentNode(bool moveIfOnContentNode);
            /*0x3806104*/ void SetupFromParserContext(System.Xml.XmlParserContext context, System.Xml.XmlReaderSettings settings);
            /*0x3818060*/ System.Xml.IDtdInfo get_DtdInfo();
            /*0x3818068*/ void SetDtdInfo(System.Xml.IDtdInfo newDtdInfo);
            /*0x38181ac*/ void set_ValidationEventHandling(System.Xml.IValidationEventHandling value);
            /*0x38181bc*/ void set_OnDefaultAttributeUse(System.Xml.XmlTextReaderImpl.OnDefaultAttributeUseDelegate value);
            /*0x38181cc*/ void set_XmlValidatingReaderCompatibilityMode(bool value);
            /*0x38182a4*/ System.Xml.XmlNodeType get_FragmentType();
            /*0x38182ac*/ void ChangeCurrentNodeType(System.Xml.XmlNodeType newNodeType);
            /*0x38182c4*/ System.Xml.XmlResolver GetResolver();
            /*0x3818304*/ void set_InternalSchemaType(object value);
            /*0x381831c*/ object get_InternalTypedValue();
            /*0x3818334*/ void set_InternalTypedValue(object value);
            /*0x381834c*/ bool get_StandAlone();
            /*0x3818354*/ System.Xml.XmlNamespaceManager get_NamespaceManager();
            /*0x381835c*/ bool get_V1Compat();
            /*0x3812bfc*/ bool AddDefaultAttributeDtd(System.Xml.IDtdDefaultAttributeInfo defAttrInfo, bool definedInDtd, System.Xml.XmlTextReaderImpl.NodeData[] nameSortedNodeData);
            /*0x38185c4*/ bool AddDefaultAttributeNonDtd(System.Xml.Schema.SchemaAttDef attrDef);
            /*0x3818364*/ System.Xml.XmlTextReaderImpl.NodeData AddDefaultAttributeInternal(string localName, string ns, string prefix, string value, int lineNo, int linePos, int valueLineNo, int valueLinePos, bool isXmlAttribute);
            /*0x38187d4*/ void set_DisableUndeclaredEntityCheck(bool value);
            /*0x38074c4*/ bool UriEqual(System.Uri uri1, string uri1Str, string uri2Str, System.Xml.XmlResolver resolver);
            /*0x380e834*/ void RegisterConsumedCharacters(long characters, bool inEntityReference);

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

                /*0x38d483c*/ LaterInitParam();
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

                /*0x38d484c*/ void Clear();
                /*0x38d4908*/ void Close(bool closeInput);
                /*0x38d4940*/ int get_LineNo();
                /*0x38d4948*/ int get_LinePos();
            }

            class XmlContext
            {
                /*0x10*/ System.Xml.XmlSpace xmlSpace;
                /*0x18*/ string xmlLang;
                /*0x20*/ string defaultNamespace;
                /*0x28*/ System.Xml.XmlTextReaderImpl.XmlContext previousContext;

                /*0x38d4958*/ XmlContext();
                /*0x38d49c0*/ XmlContext(System.Xml.XmlTextReaderImpl.XmlContext previousContext);
            }

            class NoNamespaceManager : System.Xml.XmlNamespaceManager
            {
                /*0x38d4a20*/ NoNamespaceManager();
                /*0x38d4a28*/ string get_DefaultNamespace();
                /*0x38d4a40*/ void PushScope();
                /*0x38d4a44*/ bool PopScope();
                /*0x38d4a4c*/ void AddNamespace(string prefix, string uri);
                /*0x38d4a50*/ void RemoveNamespace(string prefix, string uri);
                /*0x38d4a54*/ System.Collections.IEnumerator GetEnumerator();
                /*0x38d4a5c*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
                /*0x38d4a64*/ string LookupNamespace(string prefix);
                /*0x38d4a7c*/ string LookupPrefix(string uri);
            }

            class DtdParserProxy : System.Xml.IDtdParserAdapterV1, System.Xml.IDtdParserAdapterWithValidation, System.Xml.IDtdParserAdapter
            {
                /*0x10*/ System.Xml.XmlTextReaderImpl reader;

                /*0x38d4a84*/ DtdParserProxy(System.Xml.XmlTextReaderImpl reader);
                /*0x38d4ab4*/ System.Xml.XmlNameTable System.Xml.IDtdParserAdapter.get_NameTable();
                /*0x38d4acc*/ System.Xml.IXmlNamespaceResolver System.Xml.IDtdParserAdapter.get_NamespaceResolver();
                /*0x38d4ae4*/ System.Uri System.Xml.IDtdParserAdapter.get_BaseUri();
                /*0x38d4afc*/ bool System.Xml.IDtdParserAdapter.get_IsEof();
                /*0x38d4b14*/ char[] System.Xml.IDtdParserAdapter.get_ParsingBuffer();
                /*0x38d4b2c*/ int System.Xml.IDtdParserAdapter.get_ParsingBufferLength();
                /*0x38d4b44*/ int System.Xml.IDtdParserAdapter.get_CurrentPosition();
                /*0x38d4b5c*/ void System.Xml.IDtdParserAdapter.set_CurrentPosition(int value);
                /*0x38d4b74*/ int System.Xml.IDtdParserAdapter.get_EntityStackLength();
                /*0x38d4b8c*/ bool System.Xml.IDtdParserAdapter.get_IsEntityEolNormalized();
                /*0x38d4ba4*/ void System.Xml.IDtdParserAdapter.OnNewLine(int pos);
                /*0x38d4bbc*/ int System.Xml.IDtdParserAdapter.get_LineNo();
                /*0x38d4bd4*/ int System.Xml.IDtdParserAdapter.get_LineStartPosition();
                /*0x38d4bec*/ int System.Xml.IDtdParserAdapter.ReadData();
                /*0x38d4c04*/ int System.Xml.IDtdParserAdapter.ParseNumericCharRef(System.Text.StringBuilder internalSubsetBuilder);
                /*0x38d4c1c*/ int System.Xml.IDtdParserAdapter.ParseNamedCharRef(bool expand, System.Text.StringBuilder internalSubsetBuilder);
                /*0x38d4c38*/ void System.Xml.IDtdParserAdapter.ParsePI(System.Text.StringBuilder sb);
                /*0x38d4c50*/ void System.Xml.IDtdParserAdapter.ParseComment(System.Text.StringBuilder sb);
                /*0x38d4c68*/ bool System.Xml.IDtdParserAdapter.PushEntity(System.Xml.IDtdEntityInfo entity, ref int entityId);
                /*0x38d4c80*/ bool System.Xml.IDtdParserAdapter.PopEntity(ref System.Xml.IDtdEntityInfo oldEntity, ref int newEntityId);
                /*0x38d4c98*/ bool System.Xml.IDtdParserAdapter.PushExternalSubset(string systemId, string publicId);
                /*0x38d4cb0*/ void System.Xml.IDtdParserAdapter.PushInternalDtd(string baseUri, string internalDtd);
                /*0x38d4cc8*/ void System.Xml.IDtdParserAdapter.Throw(System.Exception e);
                /*0x38d4ce0*/ void System.Xml.IDtdParserAdapter.OnSystemId(string systemId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo systemLiteralLineInfo);
                /*0x38d4cf8*/ void System.Xml.IDtdParserAdapter.OnPublicId(string publicId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo publicLiteralLineInfo);
                /*0x38d4d10*/ bool System.Xml.IDtdParserAdapterWithValidation.get_DtdValidation();
                /*0x38d4d28*/ System.Xml.IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.get_ValidationEventHandling();
                /*0x38d4d40*/ bool System.Xml.IDtdParserAdapterV1.get_Normalization();
                /*0x38d4d58*/ bool System.Xml.IDtdParserAdapterV1.get_Namespaces();
                /*0x38d4d70*/ bool System.Xml.IDtdParserAdapterV1.get_V1CompatibilityMode();
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

                static /*0x38d4d88*/ System.Xml.XmlTextReaderImpl.NodeData get_None();
                /*0x38d4e30*/ NodeData();
                /*0x38d4ed4*/ int get_LineNo();
                /*0x38d4edc*/ int get_LinePos();
                /*0x38d4ee4*/ bool get_IsEmptyElement();
                /*0x38d4f08*/ void set_IsEmptyElement(bool value);
                /*0x38d4f10*/ bool get_IsDefaultAttribute();
                /*0x38d4f34*/ void set_IsDefaultAttribute(bool value);
                /*0x38d4f3c*/ bool get_ValueBuffered();
                /*0x38d4f4c*/ string get_StringValue();
                /*0x38d4f94*/ void TrimSpacesInValue();
                /*0x38d4e58*/ void Clear(System.Xml.XmlNodeType type);
                /*0x38d4fe0*/ void ClearName();
                /*0x38d5058*/ void SetLineInfo(int lineNo, int linePos);
                /*0x38d5064*/ void SetLineInfo2(int lineNo, int linePos);
                /*0x38d5070*/ void SetValueNode(System.Xml.XmlNodeType type, string value);
                /*0x38d50ac*/ void SetValueNode(System.Xml.XmlNodeType type, char[] chars, int startPos, int len);
                /*0x38d5104*/ void SetNamedNode(System.Xml.XmlNodeType type, string localName);
                /*0x38d5120*/ void SetNamedNode(System.Xml.XmlNodeType type, string localName, string prefix, string nameWPrefix);
                /*0x38d51b0*/ void SetValue(string value);
                /*0x38d51c0*/ void SetValue(char[] chars, int startPos, int len);
                /*0x38d520c*/ void OnBufferInvalidated();
                /*0x38d525c*/ void CopyTo(int valueOffset, System.Text.StringBuilder sb);
                /*0x38d52d8*/ int CopyTo(int valueOffset, char[] buffer, int offset, int length);
                /*0x38d5338*/ string GetNameWPrefix(System.Xml.XmlNameTable nt);
                /*0x38d534c*/ string CreateNameWPrefix(System.Xml.XmlNameTable nt);
                /*0x38d53f0*/ int System.IComparable.CompareTo(object obj);
            }

            class DtdDefaultAttributeInfoToNodeDataComparer : System.Collections.Generic.IComparer<object>
            {
                static /*0x0*/ System.Collections.Generic.IComparer<object> s_instance;

                static /*0x38d586c*/ DtdDefaultAttributeInfoToNodeDataComparer();
                static /*0x38d54cc*/ System.Collections.Generic.IComparer<object> get_Instance();
                /*0x38d5864*/ DtdDefaultAttributeInfoToNodeDataComparer();
                /*0x38d5524*/ int Compare(object x, object y);
            }

            class OnDefaultAttributeUseDelegate : System.MulticastDelegate
            {
                /*0x38d58d4*/ OnDefaultAttributeUseDelegate(object object, nint method);
                /*0x38d59e0*/ void Invoke(System.Xml.IDtdDefaultAttributeInfo defaultAttribute, System.Xml.XmlTextReaderImpl coreReader);
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

            static /*0x38da470*/ XmlTextWriter();
            /*0x38d59f4*/ XmlTextWriter();
            /*0x38d5bb4*/ XmlTextWriter(System.IO.Stream w, System.Text.Encoding encoding);
            /*0x38d5cc0*/ XmlTextWriter(string filename, System.Text.Encoding encoding);
            /*0x38d5d40*/ XmlTextWriter(System.IO.TextWriter w);
            /*0x38d5e00*/ System.IO.Stream get_BaseStream();
            /*0x38d5e8c*/ void set_Namespaces(bool value);
            /*0x38d5ef8*/ void set_Formatting(System.Xml.Formatting value);
            /*0x38d5f0c*/ void set_QuoteChar(char value);
            /*0x38d5f98*/ void WriteStartDocument();
            /*0x38d6324*/ void WriteStartDocument(bool standalone);
            /*0x38d6338*/ void WriteEndDocument();
            /*0x38d6550*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x38d705c*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x38d7b10*/ void WriteEndElement();
            /*0x38d7df4*/ void WriteFullEndElement();
            /*0x38d7dfc*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x38d8710*/ void WriteEndAttribute();
            /*0x38d87b0*/ void WriteCData(string text);
            /*0x38d8974*/ void WriteComment(string text);
            /*0x38d8b74*/ void WriteProcessingInstruction(string name, string text);
            /*0x38d8ea0*/ void WriteEntityRef(string name);
            /*0x38d8f6c*/ void WriteCharEntity(char ch);
            /*0x38d902c*/ void WriteWhitespace(string ws);
            /*0x38d9178*/ void WriteString(string text);
            /*0x38d9244*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x38d930c*/ void WriteChars(char[] buffer, int index, int count);
            /*0x38d93e4*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x38d94bc*/ void WriteRaw(string data);
            /*0x38d957c*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x38d96d4*/ void WriteBinHex(byte[] buffer, int index, int count);
            /*0x38d97a4*/ System.Xml.WriteState get_WriteState();
            /*0x38d97c8*/ void Close();
            /*0x38d98f4*/ void Flush();
            /*0x38d9910*/ string LookupPrefix(string ns);
            /*0x38d5fa0*/ void StartDocument(int standalone);
            /*0x38d6b3c*/ void AutoComplete(System.Xml.XmlTextWriter.Token token);
            /*0x38d64fc*/ void AutoCompleteAll();
            /*0x38d7b18*/ void InternalWriteEndElement(bool longFormat);
            /*0x38d9b08*/ void WriteEndStartTag(bool empty);
            /*0x38d9abc*/ void WriteEndAttributeQuote();
            /*0x38d99ec*/ void Indent(bool beforeEndElement);
            /*0x38d774c*/ void PushNamespace(string prefix, string ns, bool declared);
            /*0x38da16c*/ void AddNamespace(string prefix, string ns, bool declared);
            /*0x38da384*/ void AddToNamespaceHashtable(int namespaceIndex);
            /*0x38d9e70*/ void PopNamespaces(int indexFrom, int indexTo);
            /*0x38d85fc*/ string GeneratePrefix();
            /*0x38d8da4*/ void InternalWriteProcessingInstruction(string name, string text);
            /*0x38d75a8*/ int LookupNamespace(string prefix);
            /*0x38d84c8*/ int LookupNamespaceInCurrentScope(string prefix);
            /*0x38d7684*/ string FindPrefix(string ns);
            /*0x38d6974*/ void ValidateName(string name, bool isNCName);
            /*0x38d9f50*/ void HandleSpecialAttribute();
            /*0x38d79b0*/ void VerifyPrefixXml(string prefix, string ns);
            /*0x38d74c4*/ void PushStack();
            /*0x38d9e4c*/ void FlushEncoders();

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

                /*0x38d5b50*/ void Init(int nsTop);
            }

            struct Namespace
            {
                /*0x10*/ string prefix;
                /*0x18*/ string ns;
                /*0x20*/ bool declared;
                /*0x24*/ int prevNsIndex;

                /*0x38da340*/ void Set(string prefix, string ns, bool declared);
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

            static /*0x38dda84*/ bool IsSurrogateByte(byte b);
            static /*0x38dd5f0*/ byte* EncodeSurrogate(char* pSrc, char* pSrcEnd, byte* pDst);
            static /*0x38dd82c*/ byte* EncodeMultibyteUTF8(int ch, byte* pDst);
            static /*0x38ddc28*/ void CharToUTF8(ref char* pSrc, char* pSrcEnd, ref byte* pDst);
            static /*0x38dd560*/ byte* LtEntity(byte* pDst);
            static /*0x38dd570*/ byte* GtEntity(byte* pDst);
            static /*0x38dd544*/ byte* AmpEntity(byte* pDst);
            static /*0x38dd580*/ byte* QuoteEntity(byte* pDst);
            static /*0x38dd59c*/ byte* TabEntity(byte* pDst);
            static /*0x38dd5d4*/ byte* LineFeedEntity(byte* pDst);
            static /*0x38dd5b8*/ byte* CarriageReturnEntity(byte* pDst);
            static /*0x38dda94*/ byte* CharEntity(byte* pDst, char ch);
            static /*0x38dda60*/ byte* RawStartCData(byte* pDst);
            static /*0x38dda48*/ byte* RawEndCData(byte* pDst);
            /*0x38daa7c*/ XmlUtf8RawTextWriter(System.Xml.XmlWriterSettings settings);
            /*0x38daeb4*/ XmlUtf8RawTextWriter(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x38db01c*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x38db1ac*/ void WriteXmlDeclaration(string xmldecl);
            /*0x38db224*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x38db414*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x38db4b8*/ void StartElementContent();
            /*0x38db500*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x38db658*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x38db74c*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x38db858*/ void WriteEndAttribute();
            /*0x38db8a4*/ void WriteNamespaceDeclaration(string prefix, string namespaceName);
            /*0x38db8f8*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0x38db900*/ void WriteStartNamespaceDeclaration(string prefix);
            /*0x38db9f4*/ void WriteEndNamespaceDeclaration();
            /*0x38dba40*/ void WriteCData(string text);
            /*0x38dbfd4*/ void WriteComment(string text);
            /*0x38dc448*/ void WriteProcessingInstruction(string name, string text);
            /*0x38dc570*/ void WriteEntityRef(string name);
            /*0x38dc610*/ void WriteCharEntity(char ch);
            /*0x38dc7dc*/ void WriteWhitespace(string ws);
            /*0x38dcde0*/ void WriteString(string text);
            /*0x38dce30*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x38dcf80*/ void WriteChars(char[] buffer, int index, int count);
            /*0x38dcfc0*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x38dd238*/ void WriteRaw(string data);
            /*0x38dd280*/ void Close();
            /*0x38dd374*/ void Flush();
            /*0x38dd3b0*/ void FlushBuffer();
            /*0x38dd370*/ void FlushEncoder();
            /*0x38dc82c*/ void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd);
            /*0x38dcb34*/ void WriteElementTextBlock(char* pSrc, char* pSrcEnd);
            /*0x38db170*/ void RawText(string s);
            /*0x38dd8c4*/ void RawText(char* pSrcBegin, char* pSrcEnd);
            /*0x38dd000*/ void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd);
            /*0x38dc12c*/ void WriteCommentOrPi(string text, int stopChar);
            /*0x38dbc9c*/ void WriteCDataSection(string text);
            /*0x38dd77c*/ byte* InvalidXmlChar(int ch, byte* pDst, bool entitize);
            /*0x38ddb50*/ void EncodeChar(ref char* pSrc, char* pSrcEnd, ref byte* pDst);
            /*0x38dd870*/ byte* WriteNewLine(byte* pDst);
            /*0x38dab78*/ void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace);
        }

        class XmlUtf8RawTextWriterIndent : System.Xml.XmlUtf8RawTextWriter
        {
            /*0x90*/ int indentLevel;
            /*0x94*/ bool newLineOnAttributes;
            /*0x98*/ string indentChars;
            /*0xa0*/ bool mixedContent;
            /*0xa8*/ System.Xml.BitStack mixedContentStack;
            /*0xb0*/ System.Xml.ConformanceLevel conformanceLevel;

            /*0x38ddcf4*/ XmlUtf8RawTextWriterIndent(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x38dde2c*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x38dded4*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x38ddf40*/ void StartElementContent();
            /*0x38ddf90*/ void OnRootElement(System.Xml.ConformanceLevel currentConformanceLevel);
            /*0x38ddf98*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x38de01c*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x38de0a0*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x38de0dc*/ void WriteCData(string text);
            /*0x38de0e8*/ void WriteComment(string text);
            /*0x38de128*/ void WriteProcessingInstruction(string target, string text);
            /*0x38de170*/ void WriteEntityRef(string name);
            /*0x38de17c*/ void WriteCharEntity(char ch);
            /*0x38de188*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x38de194*/ void WriteWhitespace(string ws);
            /*0x38de1a0*/ void WriteString(string text);
            /*0x38de1ac*/ void WriteChars(char[] buffer, int index, int count);
            /*0x38de1b8*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x38de1c4*/ void WriteRaw(string data);
            /*0x38de1d0*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x38ddd1c*/ void Init(System.Xml.XmlWriterSettings settings);
            /*0x38dde8c*/ void WriteIndent();
        }

        class XmlValidatingReader : System.Xml.XmlReader
        {
            /*0x10*/ System.Xml.XmlValidatingReaderImpl impl;

            /*0x38de1e0*/ System.Xml.XmlNodeType get_NodeType();
            /*0x38de1fc*/ string get_LocalName();
            /*0x38de218*/ string get_NamespaceURI();
            /*0x38de234*/ string get_Prefix();
            /*0x38de250*/ string get_Value();
            /*0x38de26c*/ int get_Depth();
            /*0x38de288*/ string get_BaseURI();
            /*0x38de2a8*/ bool get_IsEmptyElement();
            /*0x38de2c8*/ int get_AttributeCount();
            /*0x38de2e8*/ string GetAttribute(string name);
            /*0x38de308*/ string GetAttribute(string localName, string namespaceURI);
            /*0x38de328*/ string GetAttribute(int i);
            /*0x38de348*/ bool MoveToAttribute(string name);
            /*0x38de368*/ bool MoveToFirstAttribute();
            /*0x38de388*/ bool MoveToNextAttribute();
            /*0x38de3a8*/ bool MoveToElement();
            /*0x38de3c8*/ bool ReadAttributeValue();
            /*0x38de3e8*/ bool Read();
            /*0x38de408*/ bool get_EOF();
            /*0x38de428*/ System.Xml.ReadState get_ReadState();
            /*0x38de448*/ System.Xml.XmlNameTable get_NameTable();
            /*0x38de468*/ string LookupNamespace(string prefix);
            /*0x38de4a0*/ void ResolveEntity();
            /*0x38de4c0*/ bool get_Namespaces();
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

            /*0x38de4fc*/ XmlValidatingReaderImpl(System.Xml.XmlReader reader, System.Xml.Schema.ValidationEventHandler settingsEventHandler, bool processIdentityConstraints);
            /*0x38dec3c*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x38ded0c*/ System.Xml.XmlNodeType get_NodeType();
            /*0x38ded28*/ string get_Name();
            /*0x38ded44*/ string get_LocalName();
            /*0x38ded60*/ string get_NamespaceURI();
            /*0x38ded7c*/ string get_Prefix();
            /*0x38ded98*/ string get_Value();
            /*0x38dedb4*/ int get_Depth();
            /*0x38dedd0*/ string get_BaseURI();
            /*0x38dedf0*/ bool get_IsEmptyElement();
            /*0x38dee10*/ bool get_IsDefault();
            /*0x38dee30*/ char get_QuoteChar();
            /*0x38dee50*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x38dee70*/ string get_XmlLang();
            /*0x38dee90*/ System.Xml.ReadState get_ReadState();
            /*0x38deec4*/ bool get_EOF();
            /*0x38deee4*/ System.Xml.XmlNameTable get_NameTable();
            /*0x38def04*/ int get_AttributeCount();
            /*0x38def24*/ string GetAttribute(string name);
            /*0x38def44*/ string GetAttribute(string localName, string namespaceURI);
            /*0x38def64*/ string GetAttribute(int i);
            /*0x38def84*/ bool MoveToAttribute(string name);
            /*0x38defbc*/ void MoveToAttribute(int i);
            /*0x38defec*/ bool MoveToFirstAttribute();
            /*0x38df024*/ bool MoveToNextAttribute();
            /*0x38df05c*/ bool MoveToElement();
            /*0x38df094*/ bool Read();
            /*0x38df464*/ void Close();
            /*0x38df498*/ string LookupNamespace(string prefix);
            /*0x38df4b8*/ bool ReadAttributeValue();
            /*0x38df510*/ bool get_CanResolveEntity();
            /*0x38df518*/ void ResolveEntity();
            /*0x38df548*/ void MoveOffEntityReference();
            /*0x38df5f8*/ string ReadString();
            /*0x38df614*/ bool HasLineInfo();
            /*0x38df61c*/ int get_LineNumber();
            /*0x38df704*/ int get_LinePosition();
            /*0x38df7ec*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x38df898*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0x38df8a8*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            /*0x38df7f0*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x38df8ac*/ string LookupPrefix(string namespaceName);
            /*0x38df958*/ System.Xml.ValidationType get_ValidationType();
            /*0x38df960*/ System.Xml.Schema.XmlSchemaCollection get_Schemas();
            /*0x38de4e4*/ bool get_Namespaces();
            /*0x38df268*/ void ParseDtdFromParserContext();
            /*0x38df968*/ void ValidateDtd();
            /*0x38df3dc*/ void ResolveEntityInternally();
            /*0x38deabc*/ void SetupValidation(System.Xml.ValidationType valType);
            /*0x38de918*/ System.Xml.XmlResolver GetResolver();
            /*0x38df17c*/ void ProcessCoreReaderEvent();
            /*0x38df9e4*/ System.Xml.Schema.BaseValidator get_Validator();
            /*0x38df9ec*/ void set_Validator(System.Xml.Schema.BaseValidator value);
            /*0x38df9f4*/ System.Xml.XmlNamespaceManager get_NamespaceManager();
            /*0x38dfa14*/ bool get_StandAlone();
            /*0x38dfa2c*/ void set_SchemaTypeObject(object value);
            /*0x38dfa44*/ object get_TypedValueObject();
            /*0x38dfa5c*/ void set_TypedValueObject(object value);
            /*0x38dfa74*/ bool AddDefaultAttribute(System.Xml.Schema.SchemaAttDef attdef);
            /*0x38dfa8c*/ System.Xml.IDtdInfo get_DtdInfo();
            /*0x38dfaac*/ void ValidateDefaultAttributeOnUse(System.Xml.IDtdDefaultAttributeInfo defaultAttribute, System.Xml.XmlTextReaderImpl coreReader);

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

                /*0x38de9fc*/ ValidationEventHandling(System.Xml.XmlValidatingReaderImpl reader);
                /*0x38dfbe4*/ object System.Xml.IValidationEventHandling.get_EventHandler();
                /*0x38dfbec*/ void System.Xml.IValidationEventHandling.SendEvent(System.Exception exception, System.Xml.Schema.XmlSeverityType severity);
                /*0x38dea2c*/ void AddHandler(System.Xml.Schema.ValidationEventHandler handler);
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

            static /*0x38e5d80*/ XmlWellFormedWriter();
            static /*0x38e5464*/ System.Xml.XmlException DupAttrException(string prefix, string localName);
            static /*0x38e5660*/ string GetStateName(System.Xml.XmlWellFormedWriter.State state);
            static /*0x38e5ad8*/ System.Exception InvalidCharsException(string name, int badCharIndex);
            /*0x38dfd00*/ XmlWellFormedWriter(System.Xml.XmlWriter writer, System.Xml.XmlWriterSettings settings);
            /*0x38e0310*/ System.Xml.WriteState get_WriteState();
            /*0x38e03a4*/ void WriteStartDocument();
            /*0x38e0560*/ void WriteStartDocument(bool standalone);
            /*0x38e057c*/ void WriteEndDocument();
            /*0x38e09b0*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x38e0e6c*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x38e1884*/ void WriteEndElement();
            /*0x38e1b70*/ void WriteFullEndElement();
            /*0x38e1d7c*/ void WriteStartAttribute(string prefix, string localName, string namespaceName);
            /*0x38e29ac*/ void WriteEndAttribute();
            /*0x38e3700*/ void WriteCData(string text);
            /*0x38e37e4*/ void WriteComment(string text);
            /*0x38e38c8*/ void WriteProcessingInstruction(string name, string text);
            /*0x38e3b58*/ void WriteEntityRef(string name);
            /*0x38e3ccc*/ void WriteCharEntity(char ch);
            /*0x38e3e4c*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x38e3fd0*/ void WriteWhitespace(string ws);
            /*0x38e4184*/ void WriteString(string text);
            /*0x38e4278*/ void WriteChars(char[] buffer, int index, int count);
            /*0x38e44d8*/ void WriteRaw(char[] buffer, int index, int count);
            /*0x38e4738*/ void WriteRaw(string data);
            /*0x38e482c*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0x38e4a5c*/ void Close();
            /*0x38e4c50*/ void Flush();
            /*0x38e4d04*/ string LookupPrefix(string ns);
            /*0x38e4f7c*/ void WriteValue(string value);
            /*0x38e5080*/ void WriteBinHex(byte[] buffer, int index, int count);
            /*0x38e51bc*/ System.Xml.XmlRawWriter get_RawWriter();
            /*0x38e3cbc*/ bool get_SaveAttrValue();
            /*0x38e4c34*/ bool get_InBase64();
            /*0x38e246c*/ void SetSpecialAttribute(System.Xml.XmlWellFormedWriter.SpecialAttribute special);
            /*0x38e03ac*/ void WriteStartDocumentImpl(System.Xml.XmlStandalone standalone);
            /*0x38e51c4*/ void StartFragment();
            /*0x38e147c*/ void PushNamespaceImplicit(string prefix, string ns);
            /*0x38e3248*/ bool PushNamespaceExplicit(string prefix, string ns);
            /*0x38e52ac*/ void AddNamespace(string prefix, string ns, System.Xml.XmlWellFormedWriter.NamespaceKind kind);
            /*0x38e5574*/ void AddToNamespaceHashtable(int namespaceIndex);
            /*0x38e51d0*/ int LookupNamespaceIndex(string prefix);
            /*0x38e1a90*/ void PopNamespaces(int indexFrom, int indexTo);
            /*0x38e06cc*/ void AdvanceState(System.Xml.XmlWellFormedWriter.Token token);
            /*0x38e58dc*/ void StartElementContent();
            /*0x38e1344*/ string LookupNamespace(string prefix);
            /*0x38e2640*/ string LookupLocalNamespace(string prefix);
            /*0x38e250c*/ string GeneratePrefix();
            /*0x38e1244*/ void CheckNCName(string ncname);
            /*0x38e5700*/ void ThrowInvalidStateTransition(System.Xml.XmlWellFormedWriter.Token token, System.Xml.XmlWellFormedWriter.State currentState);
            /*0x38e51ac*/ bool get_IsClosedOrErrorState();
            /*0x38e2704*/ void AddAttribute(string prefix, string localName, string namespaceName);
            /*0x38e5c1c*/ void AddToAttrHashTable(int attributeIndex);

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

                /*0x38e0240*/ NamespaceResolverProxy(System.Xml.XmlWellFormedWriter wfWriter);
                /*0x38e6578*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
                /*0x38e65b0*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
                /*0x38e65c4*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            }

            struct ElementScope
            {
                /*0x10*/ int prevNSTop;
                /*0x18*/ string prefix;
                /*0x20*/ string localName;
                /*0x28*/ string namespaceUri;
                /*0x30*/ System.Xml.XmlSpace xmlSpace;
                /*0x38*/ string xmlLang;

                /*0x38e02b0*/ void Set(string prefix, string localName, string namespaceUri, int prevNSTop);
                /*0x38e1a64*/ void WriteEndElement(System.Xml.XmlRawWriter rawWriter);
                /*0x38e1d50*/ void WriteFullEndElement(System.Xml.XmlRawWriter rawWriter);
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

                /*0x38e0270*/ void Set(string prefix, string namespaceUri, System.Xml.XmlWellFormedWriter.NamespaceKind kind);
                /*0x38e59a8*/ void WriteDecl(System.Xml.XmlWriter writer, System.Xml.XmlRawWriter rawWriter);
            }

            struct AttrName
            {
                /*0x10*/ string prefix;
                /*0x18*/ string namespaceUri;
                /*0x20*/ string localName;
                /*0x28*/ int prev;

                /*0x38e65e4*/ void Set(string prefix, string localName, string namespaceUri);
                /*0x38e6630*/ bool IsDuplicate(string prefix, string localName, string namespaceUri);
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

                /*0x38e76d4*/ AttributeValueCache();
                /*0x38e669c*/ string get_StringValue();
                /*0x38e66c8*/ void WriteEntityRef(string name);
                /*0x38e6a64*/ void WriteCharEntity(char ch);
                /*0x38e6ad0*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
                /*0x38e6b94*/ void WriteWhitespace(string ws);
                /*0x38e6be4*/ void WriteString(string text);
                /*0x38e6c58*/ void WriteChars(char[] buffer, int index, int count);
                /*0x38e6d58*/ void WriteRaw(char[] buffer, int index, int count);
                /*0x38e6e10*/ void WriteRaw(string data);
                /*0x38e6e60*/ void WriteValue(string value);
                /*0x38e6eb0*/ void Replay(System.Xml.XmlWriter writer);
                /*0x38e71e8*/ void Trim();
                /*0x38e767c*/ void Clear();
                /*0x38e686c*/ void StartComplexValue();
                /*0x38e68bc*/ void AddItem(System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType type, object data);

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

                    /*0x38e76b8*/ Item();
                    /*0x38e76c0*/ void Set(System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType type, object data);
                }

                class BufferChunk
                {
                    /*0x10*/ char[] buffer;
                    /*0x18*/ int index;
                    /*0x1c*/ int count;

                    /*0x38e6d10*/ BufferChunk(char[] buffer, int index, int count);
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

            static /*0x38e808c*/ System.Xml.XmlWriter Create(System.IO.Stream output, System.Xml.XmlWriterSettings settings);
            static /*0x38e85f8*/ System.Xml.XmlWriter Create(System.IO.TextWriter output, System.Xml.XmlWriterSettings settings);
            /*0x38e8964*/ XmlWriter();
            /*0x1f309e4*/ void WriteStartDocument();
            /*0x1f30a84*/ void WriteStartDocument(bool standalone);
            /*0x1f309e4*/ void WriteEndDocument();
            /*0x1f31134*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x38e7748*/ void WriteStartElement(string localName, string ns);
            /*0x1f310fc*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x1f309e4*/ void WriteEndElement();
            /*0x1f309e4*/ void WriteFullEndElement();
            /*0x38e7760*/ void WriteAttributeString(string localName, string ns, string value);
            /*0x38e77bc*/ void WriteAttributeString(string localName, string value);
            /*0x38e7818*/ void WriteAttributeString(string prefix, string localName, string ns, string value);
            /*0x1f310fc*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x1f309e4*/ void WriteEndAttribute();
            /*0x1f30ebc*/ void WriteCData(string text);
            /*0x1f30ebc*/ void WriteComment(string text);
            /*0x1f30ff0*/ void WriteProcessingInstruction(string name, string text);
            /*0x1f30ebc*/ void WriteEntityRef(string name);
            void WriteCharEntity(char ch);
            /*0x1f30ebc*/ void WriteWhitespace(string ws);
            /*0x1f30ebc*/ void WriteString(string text);
            void WriteSurrogateCharEntity(char lowChar, char highChar);
            void WriteChars(char[] buffer, int index, int count);
            void WriteRaw(char[] buffer, int index, int count);
            /*0x1f30ebc*/ void WriteRaw(string data);
            void WriteBase64(byte[] buffer, int index, int count);
            /*0x38e7868*/ void WriteBinHex(byte[] buffer, int index, int count);
            /*0x1f2ffc8*/ System.Xml.WriteState get_WriteState();
            /*0x38e7884*/ void Close();
            /*0x1f309e4*/ void Flush();
            /*0x1f302cc*/ string LookupPrefix(string ns);
            /*0x38e7888*/ void WriteValue(string value);
            /*0x38e78a0*/ void WriteAttributes(System.Xml.XmlReader reader, bool defattr);
            /*0x38e7b1c*/ void WriteNode(System.Xml.XmlReader reader, bool defattr);
            /*0x38e7fd0*/ void WriteElementString(string localName, string ns, string value);
            /*0x38e8034*/ void Dispose();
            /*0x38e8048*/ void Dispose(bool disposing);
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

            /*0x38e80f4*/ XmlWriterSettings();
            /*0x38e8acc*/ bool get_Async();
            /*0x38e8ad4*/ System.Text.Encoding get_Encoding();
            /*0x38e8adc*/ bool get_OmitXmlDeclaration();
            /*0x38e8ae4*/ void set_OmitXmlDeclaration(bool value);
            /*0x38e8bf0*/ System.Xml.NewLineHandling get_NewLineHandling();
            /*0x38e8bf8*/ string get_NewLineChars();
            /*0x38e8c00*/ bool get_Indent();
            /*0x38e8c10*/ void set_Indent(bool value);
            /*0x38e8c78*/ string get_IndentChars();
            /*0x38e8c80*/ bool get_NewLineOnAttributes();
            /*0x38e8c88*/ bool get_CloseOutput();
            /*0x38e8c90*/ System.Xml.ConformanceLevel get_ConformanceLevel();
            /*0x38e8c98*/ void set_ConformanceLevel(System.Xml.ConformanceLevel value);
            /*0x38e8d44*/ bool get_CheckCharacters();
            /*0x38e8d4c*/ System.Xml.NamespaceHandling get_NamespaceHandling();
            /*0x38e8d54*/ void set_NamespaceHandling(System.Xml.NamespaceHandling value);
            /*0x38e8e00*/ bool get_WriteEndDocumentOnClose();
            /*0x38e8e08*/ System.Xml.XmlOutputMethod get_OutputMethod();
            /*0x38e8e10*/ void set_OutputMethod(System.Xml.XmlOutputMethod value);
            /*0x38e8e18*/ System.Xml.XmlWriterSettings Clone();
            /*0x38e8eec*/ System.Collections.Generic.List<System.Xml.XmlQualifiedName> get_CDataSectionElements();
            /*0x38e8ef4*/ bool get_DoNotEscapeUriAttributes();
            /*0x38e8efc*/ bool get_MergeCDataSections();
            /*0x38e8f04*/ string get_MediaType();
            /*0x38e8f0c*/ string get_DocTypeSystem();
            /*0x38e8f14*/ string get_DocTypePublic();
            /*0x38e8f1c*/ System.Xml.XmlStandalone get_Standalone();
            /*0x38e8f24*/ bool get_AutoXmlDeclaration();
            /*0x38e8f2c*/ System.Xml.TriState get_IndentInternal();
            /*0x38e8f34*/ bool get_IsQuerySpecific();
            /*0x38e8184*/ System.Xml.XmlWriter CreateWriter(System.IO.Stream output);
            /*0x38e8660*/ System.Xml.XmlWriter CreateWriter(System.IO.TextWriter output);
            /*0x38e8fa4*/ void set_ReadOnly(bool value);
            /*0x38e8b44*/ void CheckReadOnly(string propertyName);
            /*0x38e896c*/ void Initialize();
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

            /*0x38e8fac*/ XsdCachingReader(System.Xml.XmlReader reader, System.Xml.IXmlLineInfo lineInfo, System.Xml.CachingEventHandler handlerMethod);
            /*0x38e90a4*/ void Init();
            /*0x38e9520*/ void Reset(System.Xml.XmlReader reader);
            /*0x38e953c*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x38e9558*/ System.Xml.XmlNodeType get_NodeType();
            /*0x38e9570*/ string get_Name();
            /*0x38e9590*/ string get_LocalName();
            /*0x38e95a8*/ string get_NamespaceURI();
            /*0x38e95c0*/ string get_Prefix();
            /*0x38e95d8*/ string get_Value();
            /*0x38e960c*/ int get_Depth();
            /*0x38e9624*/ string get_BaseURI();
            /*0x38e9644*/ bool get_IsEmptyElement();
            /*0x38e964c*/ bool get_IsDefault();
            /*0x38e9654*/ char get_QuoteChar();
            /*0x38e9674*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x38e9694*/ string get_XmlLang();
            /*0x38e96b4*/ int get_AttributeCount();
            /*0x38e96bc*/ string GetAttribute(string name);
            /*0x38e9898*/ string GetAttribute(string name, string namespaceURI);
            /*0x38e9990*/ string GetAttribute(int i);
            /*0x38e9a20*/ bool MoveToAttribute(string name);
            /*0x38e9ab8*/ void MoveToAttribute(int i);
            /*0x38e9b48*/ bool MoveToFirstAttribute();
            /*0x38e9b8c*/ bool MoveToNextAttribute();
            /*0x38e9bec*/ bool MoveToElement();
            /*0x38e9c40*/ bool Read();
            /*0x38e9f30*/ System.Xml.ValidatingReaderNodeData RecordTextNode(string textValue, string originalStringValue, int depth, int lineNo, int linePos);
            /*0x38e9fa8*/ void SwitchTextNodeAndEndElement(string textValue, string originalStringValue);
            /*0x38ea0c0*/ void RecordEndElementNode();
            /*0x38ea1f0*/ bool get_EOF();
            /*0x38ea224*/ void Close();
            /*0x38ea258*/ System.Xml.ReadState get_ReadState();
            /*0x38ea278*/ void Skip();
            /*0x38ea38c*/ System.Xml.XmlNameTable get_NameTable();
            /*0x38ea394*/ string LookupNamespace(string prefix);
            /*0x38ea3b4*/ void ResolveEntity();
            /*0x38ea3ec*/ bool ReadAttributeValue();
            /*0x38ea4e8*/ bool System.Xml.IXmlLineInfo.HasLineInfo();
            /*0x38ea4f0*/ int System.Xml.IXmlLineInfo.get_LineNumber();
            /*0x38ea508*/ int System.Xml.IXmlLineInfo.get_LinePosition();
            /*0x38ea520*/ void SetToReplayMode();
            /*0x38ea540*/ System.Xml.XmlReader GetCoreReader();
            /*0x38ea548*/ System.Xml.IXmlLineInfo GetLineInfo();
            /*0x38e9f20*/ void ClearAttributesInfo();
            /*0x38ea550*/ System.Xml.ValidatingReaderNodeData AddAttribute(int attIndex);
            /*0x38e9210*/ System.Xml.ValidatingReaderNodeData AddContent(System.Xml.XmlNodeType nodeType);
            /*0x38e939c*/ void RecordAttributes();
            /*0x38e9748*/ int GetAttributeIndexWithoutPrefix(string name);
            /*0x38e97f8*/ int GetAttributeIndexWithPrefix(string name);
            /*0x38ea448*/ System.Xml.ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth);

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
            /*0x38ea6c4*/ CachingEventHandler(object object, nint method);
            /*0x38ea7cc*/ void Invoke(System.Xml.XsdCachingReader cachingReader);
        }

        class AttributePSVIInfo
        {
            /*0x10*/ string localName;
            /*0x18*/ string namespaceUri;
            /*0x20*/ object typedAttributeValue;
            /*0x28*/ System.Xml.Schema.XmlSchemaInfo attributeSchemaInfo;

            /*0x38ea7e0*/ AttributePSVIInfo();
            /*0x38ea84c*/ void Reset();
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

            /*0x38ea8b8*/ XsdValidatingReader(System.Xml.XmlReader reader, System.Xml.XmlResolver xmlResolver, System.Xml.XmlReaderSettings readerSettings, System.Xml.Schema.XmlSchemaObject partialValidationType);
            /*0x38eb070*/ XsdValidatingReader(System.Xml.XmlReader reader, System.Xml.XmlResolver xmlResolver, System.Xml.XmlReaderSettings readerSettings);
            /*0x38eaac0*/ void Init();
            /*0x38eae5c*/ void SetupValidator(System.Xml.XmlReaderSettings readerSettings, System.Xml.XmlReader reader, System.Xml.Schema.XmlSchemaObject partialValidationType);
            /*0x38eb078*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x38eb148*/ System.Xml.XmlNodeType get_NodeType();
            /*0x38eb1d0*/ string get_Name();
            /*0x38eb2e8*/ string get_LocalName();
            /*0x38eb324*/ string get_NamespaceURI();
            /*0x38eb360*/ string get_Prefix();
            /*0x38eb39c*/ string get_Value();
            /*0x38eb3d8*/ int get_Depth();
            /*0x38eb414*/ string get_BaseURI();
            /*0x38eb434*/ bool get_IsEmptyElement();
            /*0x38eb454*/ bool get_IsDefault();
            /*0x38eb488*/ char get_QuoteChar();
            /*0x38eb4a8*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x38eb4c8*/ string get_XmlLang();
            /*0x38eb4e8*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x38eb4ec*/ System.Type get_ValueType();
            /*0x38eb5cc*/ int get_AttributeCount();
            /*0x38eb5d4*/ string GetAttribute(string name);
            /*0x38eb7bc*/ string GetAttribute(string name, string namespaceURI);
            /*0x38eb9cc*/ string GetAttribute(int i);
            /*0x38ebaa4*/ bool MoveToAttribute(string name);
            /*0x38ebcf8*/ void MoveToAttribute(int i);
            /*0x38ebec4*/ bool MoveToFirstAttribute();
            /*0x38ec058*/ bool MoveToNextAttribute();
            /*0x38ec1ec*/ bool MoveToElement();
            /*0x38ec240*/ bool Read();
            /*0x38ec698*/ bool get_EOF();
            /*0x38ec6b8*/ void Close();
            /*0x38ec6ec*/ System.Xml.ReadState get_ReadState();
            /*0x38ec720*/ void Skip();
            /*0x38ec87c*/ System.Xml.XmlNameTable get_NameTable();
            /*0x38ec884*/ string LookupNamespace(string prefix);
            /*0x38ec930*/ void ResolveEntity();
            /*0x38ec968*/ bool ReadAttributeValue();
            /*0x38ecad0*/ bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault();
            /*0x38ecdf8*/ bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil();
            /*0x38ece40*/ System.Xml.Schema.XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity();
            /*0x38eced0*/ System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType();
            /*0x38ed058*/ System.Xml.Schema.XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType();
            /*0x38ed0b4*/ System.Xml.Schema.XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement();
            /*0x38ed108*/ System.Xml.Schema.XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute();
            /*0x38ed14c*/ bool HasLineInfo();
            /*0x38ed154*/ int get_LineNumber();
            /*0x38ed204*/ int get_LinePosition();
            /*0x38ed2b4*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x38ed374*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0x38ed438*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            /*0x38ed4fc*/ object GetStringValue();
            /*0x38eb5b4*/ System.Xml.Schema.XmlSchemaInfo get_AttributeSchemaInfo();
            /*0x38ec3c4*/ void ProcessReaderEvent();
            /*0x38ed518*/ void ProcessElementEvent();
            /*0x38ed9d8*/ void ProcessEndElementEvent();
            /*0x38edb8c*/ void ValidateAttributes();
            /*0x38ec654*/ void ClearAttributesInfo();
            /*0x38ebb80*/ System.Xml.AttributePSVIInfo GetAttributePSVI(string name);
            /*0x38ee024*/ System.Xml.AttributePSVIInfo GetAttributePSVI(string localName, string ns);
            /*0x38eb640*/ System.Xml.ValidatingReaderNodeData GetDefaultAttribute(string name, bool updatePosition);
            /*0x38eb88c*/ System.Xml.ValidatingReaderNodeData GetDefaultAttribute(string attrLocalName, string ns, bool updatePosition);
            /*0x38edec0*/ System.Xml.AttributePSVIInfo AddAttributePSVI(int attIndex);
            /*0x38edb3c*/ bool IsXSDRoot(string localName, string ns);
            /*0x38ec58c*/ void ProcessInlineSchema();
            /*0x38ee0cc*/ void ReadAheadForMemberType();
            /*0x38ecb58*/ void GetIsDefault();
            /*0x38ecf50*/ void GetMemberType();
            /*0x38eddc0*/ System.Xml.XsdCachingReader GetCachingReader();
            /*0x38eca30*/ System.Xml.ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth);
            /*0x38ee2bc*/ void CachingCallBack(System.Xml.XsdCachingReader cachingReader);
            /*0x38edd60*/ string GetOriginalAtomicValueStringOfElement();

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

        class DomNameTable
        {
            /*0x10*/ System.Xml.XmlName[] entries;
            /*0x18*/ int count;
            /*0x1c*/ int mask;
            /*0x20*/ System.Xml.XmlDocument ownerDocument;
            /*0x28*/ System.Xml.XmlNameTable nameTable;

            /*0x38ee304*/ DomNameTable(System.Xml.XmlDocument document);
            /*0x38ee3c0*/ System.Xml.XmlName GetName(string prefix, string localName, string ns, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            /*0x38ee504*/ System.Xml.XmlName AddName(string prefix, string localName, string ns, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            /*0x38ee758*/ void Grow();
        }

        class XmlAttribute : System.Xml.XmlNode
        {
            /*0x18*/ System.Xml.XmlName name;
            /*0x20*/ System.Xml.XmlLinkedNode lastChild;

            /*0x38ee8b4*/ XmlAttribute(System.Xml.XmlName name, System.Xml.XmlDocument doc);
            /*0x38eeabc*/ XmlAttribute(string prefix, string localName, string namespaceURI, System.Xml.XmlDocument doc);
            /*0x38eeaa4*/ int get_LocalNameHash();
            /*0x38eec0c*/ System.Xml.XmlName get_XmlName();
            /*0x38eec14*/ void set_XmlName(System.Xml.XmlName value);
            /*0x38eec1c*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x38eece4*/ System.Xml.XmlNode get_ParentNode();
            /*0x38eecec*/ string get_Name();
            /*0x38eed04*/ string get_LocalName();
            /*0x38eed1c*/ string get_NamespaceURI();
            /*0x38eed34*/ string get_Prefix();
            /*0x38eed4c*/ void set_Prefix(string value);
            /*0x38eedf4*/ System.Xml.XmlNodeType get_NodeType();
            /*0x38eedfc*/ System.Xml.XmlDocument get_OwnerDocument();
            /*0x38eee14*/ string get_Value();
            /*0x38eee24*/ void set_Value(string value);
            /*0x38eee34*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x38eee3c*/ void set_InnerText(string value);
            /*0x38eeea0*/ bool PrepareOwnerElementInElementIdAttrMap();
            /*0x38eef50*/ void ResetOwnerElementInElementIdAttrMap(string oldInnerText);
            /*0x38ef178*/ bool get_IsContainer();
            /*0x38ef180*/ System.Xml.XmlNode AppendChildForLoad(System.Xml.XmlNode newChild, System.Xml.XmlDocument doc);
            /*0x38ef3e0*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x38ef3e8*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x38ef3f0*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x38ef400*/ bool get_Specified();
            /*0x38ef408*/ System.Xml.XmlNode InsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x38ef498*/ System.Xml.XmlNode InsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x38ef528*/ System.Xml.XmlNode RemoveChild(System.Xml.XmlNode oldChild);
            /*0x38ef5a0*/ System.Xml.XmlNode PrependChild(System.Xml.XmlNode newChild);
            /*0x38ef618*/ System.Xml.XmlNode AppendChild(System.Xml.XmlNode newChild);
            /*0x38ef690*/ System.Xml.XmlElement get_OwnerElement();
            /*0x38ef70c*/ void set_InnerXml(string value);
            /*0x38ef7a8*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x38ef85c*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x38ef8c4*/ string get_BaseURI();
            /*0x38ef92c*/ void SetParent(System.Xml.XmlNode node);
            /*0x38ef934*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x38ef988*/ string get_XmlLang();
        }

        class XmlAttributeCollection : System.Xml.XmlNamedNodeMap, System.Collections.ICollection, System.Collections.IEnumerable
        {
            /*0x38ef9f0*/ XmlAttributeCollection(System.Xml.XmlNode parent);
            /*0x38ef9f8*/ System.Xml.XmlAttribute get_ItemOf(int i);
            /*0x38efb3c*/ System.Xml.XmlAttribute get_ItemOf(string name);
            /*0x38efc5c*/ System.Xml.XmlAttribute get_ItemOf(string localName, string namespaceURI);
            /*0x38efdac*/ int FindNodeOffsetNS(System.Xml.XmlAttribute node);
            /*0x38eff28*/ System.Xml.XmlNode SetNamedItem(System.Xml.XmlNode node);
            /*0x38f015c*/ System.Xml.XmlAttribute Append(System.Xml.XmlAttribute node);
            /*0x38f040c*/ System.Xml.XmlAttribute Remove(System.Xml.XmlAttribute node);
            /*0x38f0490*/ System.Xml.XmlAttribute RemoveAt(int i);
            /*0x38f053c*/ void RemoveAll();
            /*0x38f0584*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
            /*0x38f0604*/ bool System.Collections.ICollection.get_IsSynchronized();
            /*0x38f060c*/ object System.Collections.ICollection.get_SyncRoot();
            /*0x38f0610*/ int System.Collections.ICollection.get_Count();
            /*0x38f0618*/ System.Xml.XmlNode AddNode(System.Xml.XmlNode node);
            /*0x38f0800*/ System.Xml.XmlNode InsertNodeAt(int i, System.Xml.XmlNode node);
            /*0x38f08b0*/ System.Xml.XmlNode RemoveNodeAt(int i);
            /*0x38f0270*/ void Detach(System.Xml.XmlAttribute attr);
            /*0x38f02b8*/ void InsertParentIntoElementIdAttrMap(System.Xml.XmlAttribute attr);
            /*0x38f0a50*/ void RemoveParentFromElementIdAttrMap(System.Xml.XmlAttribute attr);
            /*0x38f06fc*/ int RemoveDuplicateAttribute(System.Xml.XmlAttribute attr);
            /*0x38eefcc*/ bool PrepareParentInElementIdAttrMap(string attrPrefix, string attrLocalName);
            /*0x38ef0bc*/ void ResetParentInElementIdAttrMap(string oldVal, string newVal);
            /*0x38f00bc*/ System.Xml.XmlAttribute InternalAppendAttribute(System.Xml.XmlAttribute node);
        }

        class XmlCDataSection : System.Xml.XmlCharacterData
        {
            /*0x38f1184*/ XmlCDataSection(string data, System.Xml.XmlDocument doc);
            /*0x38f11cc*/ string get_Name();
            /*0x38f11f4*/ string get_LocalName();
            /*0x38f121c*/ System.Xml.XmlNodeType get_NodeType();
            /*0x38f1224*/ System.Xml.XmlNode get_ParentNode();
            /*0x38f12a8*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x38f1304*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x38f1344*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x38f1348*/ bool get_IsText();
        }

        class XmlCharacterData : System.Xml.XmlLinkedNode
        {
            /*0x20*/ string data;

            /*0x38f1188*/ XmlCharacterData(string data, System.Xml.XmlDocument doc);
            /*0x38f1374*/ string get_Value();
            /*0x38f1384*/ void set_Value(string value);
            /*0x38f1394*/ string get_InnerText();
            /*0x38f13a0*/ void set_InnerText(string value);
            /*0x38f13ac*/ string get_Data();
            /*0x38f13d0*/ void set_Data(string value);
            /*0x38f1494*/ bool CheckOnData(string data);
        }

        class XmlChildEnumerator : System.Collections.IEnumerator
        {
            /*0x10*/ System.Xml.XmlNode container;
            /*0x18*/ System.Xml.XmlNode child;
            /*0x20*/ bool isFirst;

            /*0x38f14d0*/ XmlChildEnumerator(System.Xml.XmlNode container);
            /*0x38f1538*/ bool System.Collections.IEnumerator.MoveNext();
            /*0x38f153c*/ bool MoveNext();
            /*0x38f15cc*/ void System.Collections.IEnumerator.Reset();
            /*0x38f160c*/ object System.Collections.IEnumerator.get_Current();
            /*0x38f1610*/ System.Xml.XmlNode get_Current();
        }

        class XmlChildNodes : System.Xml.XmlNodeList
        {
            /*0x10*/ System.Xml.XmlNode container;

            /*0x38f167c*/ XmlChildNodes(System.Xml.XmlNode container);
            /*0x38f16ac*/ System.Xml.XmlNode Item(int i);
            /*0x38f1708*/ int get_Count();
            /*0x38f1754*/ System.Collections.IEnumerator GetEnumerator();
        }

        class XmlComment : System.Xml.XmlCharacterData
        {
            /*0x38f1804*/ XmlComment(string comment, System.Xml.XmlDocument doc);
            /*0x38f1808*/ string get_Name();
            /*0x38f1830*/ string get_LocalName();
            /*0x38f1858*/ System.Xml.XmlNodeType get_NodeType();
            /*0x38f1860*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x38f18bc*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x38f18fc*/ void WriteContentTo(System.Xml.XmlWriter w);
        }

        class XmlDeclaration : System.Xml.XmlLinkedNode
        {
            /*0x20*/ string version;
            /*0x28*/ string encoding;
            /*0x30*/ string standalone;

            /*0x38f1900*/ XmlDeclaration(string version, string encoding, string standalone, System.Xml.XmlDocument doc);
            /*0x38f1c8c*/ string get_Version();
            /*0x38f1c94*/ void set_Version(string value);
            /*0x38f1c9c*/ string get_Encoding();
            /*0x38f1b1c*/ void set_Encoding(string value);
            /*0x38f1ca4*/ string get_Standalone();
            /*0x38f1b48*/ void set_Standalone(string value);
            /*0x38f1cac*/ string get_Value();
            /*0x38f1cbc*/ void set_Value(string value);
            /*0x38f1ccc*/ string get_InnerText();
            /*0x38f1e40*/ void set_InnerText(string value);
            /*0x38f2298*/ string get_Name();
            /*0x38f22d8*/ string get_LocalName();
            /*0x38f22e4*/ System.Xml.XmlNodeType get_NodeType();
            /*0x38f22ec*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x38f2328*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x38f238c*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x38f1aa0*/ bool IsValidXmlVersion(string ver);
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

            static /*0x38f6518*/ XmlDocument();
            static /*0x38ee9d0*/ void CheckName(string name);
            /*0x38f2390*/ XmlDocument();
            /*0x38f28f4*/ XmlDocument(System.Xml.XmlNameTable nt);
            /*0x38f2454*/ XmlDocument(System.Xml.XmlImplementation imp);
            /*0x38f299c*/ System.Xml.Schema.SchemaInfo get_DtdSchemaInfo();
            /*0x38f29a4*/ void set_DtdSchemaInfo(System.Xml.Schema.SchemaInfo value);
            /*0x38f29ac*/ System.Xml.XmlName AddXmlName(string prefix, string localName, string namespaceURI, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            /*0x38f29c0*/ System.Xml.XmlName GetXmlName(string prefix, string localName, string namespaceURI, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            /*0x38eeaf8*/ System.Xml.XmlName AddAttrXmlName(string prefix, string localName, string namespaceURI, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            /*0x38f29d4*/ bool AddIdInfo(System.Xml.XmlName eleName, System.Xml.XmlName attrName);
            /*0x38f2aa0*/ System.Xml.XmlName GetIDInfoByElement_(System.Xml.XmlName eleName);
            /*0x38f0e38*/ System.Xml.XmlName GetIDInfoByElement(System.Xml.XmlName eleName);
            /*0x38f2b68*/ System.WeakReference GetElement(System.Collections.ArrayList elementList, System.Xml.XmlElement elem);
            /*0x38f0e4c*/ void AddElementWithId(string id, System.Xml.XmlElement elem);
            /*0x38f1040*/ void RemoveElementWithId(string id, System.Xml.XmlElement elem);
            /*0x38f3150*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x38f3250*/ System.Xml.XmlNodeType get_NodeType();
            /*0x38f3258*/ System.Xml.XmlNode get_ParentNode();
            /*0x38f3260*/ System.Xml.XmlDocumentType get_DocumentType();
            /*0x38f32ec*/ System.Xml.XmlDeclaration get_Declaration();
            /*0x38f3390*/ System.Xml.XmlImplementation get_Implementation();
            /*0x38f3398*/ string get_Name();
            /*0x38f33a0*/ string get_LocalName();
            /*0x38f33a8*/ System.Xml.XmlElement get_DocumentElement();
            /*0x38f3434*/ bool get_IsContainer();
            /*0x38f343c*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x38f3444*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x38f344c*/ System.Xml.XmlDocument get_OwnerDocument();
            /*0x38f3454*/ void set_Schemas(System.Xml.Schema.XmlSchemaSet value);
            /*0x38f345c*/ bool get_CanReportValidity();
            /*0x38f3464*/ bool get_HasSetResolver();
            /*0x38f346c*/ System.Xml.XmlResolver GetResolver();
            /*0x38f3474*/ void set_XmlResolver(System.Xml.XmlResolver value);
            /*0x38f360c*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x38f36f8*/ bool HasNodeTypeInPrevSiblings(System.Xml.XmlNodeType nt, System.Xml.XmlNode refNode);
            /*0x38f37ac*/ bool HasNodeTypeInNextSiblings(System.Xml.XmlNodeType nt, System.Xml.XmlNode refNode);
            /*0x38f3810*/ bool CanInsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x38f3970*/ bool CanInsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x38f3a64*/ System.Xml.XmlAttribute CreateAttribute(string name);
            /*0x38f3ae4*/ void SetDefaultNamespace(string prefix, string localName, ref string namespaceURI);
            /*0x38f3b88*/ System.Xml.XmlCDataSection CreateCDataSection(string data);
            /*0x38f3bf8*/ System.Xml.XmlComment CreateComment(string data);
            /*0x38f3c60*/ System.Xml.XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset);
            /*0x38f3df4*/ System.Xml.XmlDocumentFragment CreateDocumentFragment();
            /*0x38f3ed0*/ System.Xml.XmlElement CreateElement(string name);
            /*0x38f3f50*/ void AddDefaultAttributes(System.Xml.XmlElement elem);
            /*0x38f41cc*/ System.Xml.Schema.SchemaElementDecl GetSchemaElementDecl(System.Xml.XmlElement elem);
            /*0x38f42dc*/ System.Xml.XmlAttribute PrepareDefaultAttribute(System.Xml.Schema.SchemaAttDef attdef, string attrPrefix, string attrLocalname, string attrNamespaceURI);
            /*0x38f43d8*/ System.Xml.XmlEntityReference CreateEntityReference(string name);
            /*0x38f4540*/ System.Xml.XmlProcessingInstruction CreateProcessingInstruction(string target, string data);
            /*0x38f45b4*/ System.Xml.XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone);
            /*0x38f4634*/ System.Xml.XmlText CreateTextNode(string text);
            /*0x38f46a0*/ System.Xml.XmlSignificantWhitespace CreateSignificantWhitespace(string text);
            /*0x38f470c*/ System.Xml.XmlWhitespace CreateWhitespace(string text);
            /*0x38f4778*/ System.Xml.XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI);
            /*0x38f47f8*/ System.Xml.XmlElement CreateElement(string qualifiedName, string namespaceURI);
            /*0x38f4878*/ System.Xml.XmlNode ImportNodeInternal(System.Xml.XmlNode node, bool deep);
            /*0x38f4d70*/ void ImportAttributes(System.Xml.XmlNode fromElem, System.Xml.XmlNode toElem);
            /*0x38f31b8*/ void ImportChildren(System.Xml.XmlNode fromNode, System.Xml.XmlNode toNode, bool deep);
            /*0x38ee3a8*/ System.Xml.XmlNameTable get_NameTable();
            /*0x38f4e84*/ System.Xml.XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI);
            /*0x38f4f1c*/ System.Xml.XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI);
            /*0x38f4fa0*/ System.Xml.XmlElement CreateElement(string prefix, string localName, string namespaceURI);
            /*0x38f51a4*/ bool get_IsReadOnly();
            /*0x38f51ac*/ System.Xml.XmlNamedNodeMap get_Entities();
            /*0x38f5224*/ void set_Entities(System.Xml.XmlNamedNodeMap value);
            /*0x38f522c*/ bool get_IsLoading();
            /*0x38f5234*/ void set_IsLoading(bool value);
            /*0x38f523c*/ bool get_ActualLoadingStatus();
            /*0x38f5244*/ System.Xml.XmlNode ReadNode(System.Xml.XmlReader reader);
            /*0x38f5460*/ System.Xml.XmlTextReader SetupReader(System.Xml.XmlTextReader tr);
            /*0x38f54c0*/ void Load(System.Xml.XmlReader reader);
            /*0x38f5830*/ void LoadXml(string xml);
            /*0x38f5978*/ void set_InnerText(string value);
            /*0x38f59d0*/ void set_InnerXml(string value);
            /*0x38f59e0*/ void Save(System.Xml.XmlWriter w);
            /*0x38f5bf8*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x38f5c08*/ void WriteContentTo(System.Xml.XmlWriter xw);
            /*0x38f5ea0*/ System.Xml.XmlNodeChangedEventArgs GetEventArgs(System.Xml.XmlNode node, System.Xml.XmlNode oldParent, System.Xml.XmlNode newParent, string oldValue, string newValue, System.Xml.XmlNodeChangedAction action);
            /*0x38ef328*/ System.Xml.XmlNodeChangedEventArgs GetInsertEventArgsForLoad(System.Xml.XmlNode node, System.Xml.XmlNode newParent);
            /*0x38f5f98*/ void BeforeEvent(System.Xml.XmlNodeChangedEventArgs args);
            /*0x38f5fec*/ void AfterEvent(System.Xml.XmlNodeChangedEventArgs args);
            /*0x38f0ba4*/ System.Xml.XmlAttribute GetDefaultAttribute(System.Xml.XmlElement elem, string attrPrefix, string attrLocalname, string attrNamespaceURI);
            /*0x38f6040*/ string get_Version();
            /*0x38f6064*/ string get_Encoding();
            /*0x38f5bd4*/ string get_Standalone();
            /*0x38f6088*/ System.Xml.XmlEntity GetEntityNode(string name);
            /*0x38f61c4*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x38f6310*/ string get_BaseURI();
            /*0x38f6318*/ void SetBaseURI(string inBaseURI);
            /*0x38f6328*/ System.Xml.XmlNode AppendChildForLoad(System.Xml.XmlNode newChild, System.Xml.XmlDocument doc);
        }

        class XmlDocumentFragment : System.Xml.XmlNode
        {
            /*0x18*/ System.Xml.XmlLinkedNode lastChild;

            /*0x38f3e4c*/ XmlDocumentFragment(System.Xml.XmlDocument ownerDocument);
            /*0x38f6634*/ string get_Name();
            /*0x38f665c*/ string get_LocalName();
            /*0x38f6684*/ System.Xml.XmlNodeType get_NodeType();
            /*0x38f668c*/ System.Xml.XmlNode get_ParentNode();
            /*0x38f6694*/ System.Xml.XmlDocument get_OwnerDocument();
            /*0x38f670c*/ void set_InnerXml(string value);
            /*0x38f69bc*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x38f6a40*/ bool get_IsContainer();
            /*0x38f6a48*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x38f6a50*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x38f6a58*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x38f6acc*/ bool CanInsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x38f6b3c*/ bool CanInsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x38f6ba4*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x38f6bb4*/ void WriteContentTo(System.Xml.XmlWriter w);
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

            /*0x38f3ce8*/ XmlDocumentType(string name, string publicId, string systemId, string internalSubset, System.Xml.XmlDocument doc);
            /*0x38f6eb4*/ string get_Name();
            /*0x38f6ebc*/ string get_LocalName();
            /*0x38f6ec4*/ System.Xml.XmlNodeType get_NodeType();
            /*0x38f6ecc*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x38f6f08*/ bool get_IsReadOnly();
            /*0x38f614c*/ System.Xml.XmlNamedNodeMap get_Entities();
            /*0x38f6f10*/ System.Xml.XmlNamedNodeMap get_Notations();
            /*0x38f6f88*/ string get_PublicId();
            /*0x38f6f90*/ string get_SystemId();
            /*0x38f6f98*/ string get_InternalSubset();
            /*0x38f6fa0*/ bool get_ParseWithNamespaces();
            /*0x38f6fa8*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x38f6fd0*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x38f6fd4*/ System.Xml.Schema.SchemaInfo get_DtdSchemaInfo();
            /*0x38f6fdc*/ void set_DtdSchemaInfo(System.Xml.Schema.SchemaInfo value);
        }

        class XmlElement : System.Xml.XmlLinkedNode
        {
            /*0x20*/ System.Xml.XmlName name;
            /*0x28*/ System.Xml.XmlAttributeCollection attributes;
            /*0x30*/ System.Xml.XmlLinkedNode lastChild;

            static /*0x38f7ffc*/ void WriteElementTo(System.Xml.XmlWriter writer, System.Xml.XmlElement e);
            /*0x38f5050*/ XmlElement(System.Xml.XmlName name, bool empty, System.Xml.XmlDocument doc);
            /*0x38f6fe4*/ XmlElement(string prefix, string localName, string namespaceURI, System.Xml.XmlDocument doc);
            /*0x38f7028*/ System.Xml.XmlName get_XmlName();
            /*0x38f7030*/ void set_XmlName(System.Xml.XmlName value);
            /*0x38f7038*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x38f75ac*/ string get_Name();
            /*0x38f75c4*/ string get_LocalName();
            /*0x38f75dc*/ string get_NamespaceURI();
            /*0x38f75f4*/ string get_Prefix();
            /*0x38f760c*/ void set_Prefix(string value);
            /*0x38f76b8*/ System.Xml.XmlNodeType get_NodeType();
            /*0x38f76c0*/ System.Xml.XmlNode get_ParentNode();
            /*0x38f76c8*/ System.Xml.XmlDocument get_OwnerDocument();
            /*0x38f76e0*/ bool get_IsContainer();
            /*0x38f76e8*/ System.Xml.XmlNode AppendChildForLoad(System.Xml.XmlNode newChild, System.Xml.XmlDocument doc);
            /*0x38f7534*/ bool get_IsEmpty();
            /*0x38f7544*/ void set_IsEmpty(bool value);
            /*0x38f78a0*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x38f78b0*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x38f78b8*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x38f78d0*/ System.Xml.XmlAttributeCollection get_Attributes();
            /*0x38f7a14*/ bool get_HasAttributes();
            /*0x38f7a3c*/ string GetAttribute(string name);
            /*0x38f7a80*/ void SetAttribute(string name, string value);
            /*0x38f7b24*/ System.Xml.XmlAttribute GetAttributeNode(string name);
            /*0x38f7b88*/ System.Xml.XmlAttribute SetAttributeNode(System.Xml.XmlAttribute newAttr);
            /*0x38f7c98*/ string GetAttribute(string localName, string namespaceURI);
            /*0x38f7cdc*/ string SetAttribute(string localName, string namespaceURI, string value);
            /*0x38f7db4*/ System.Xml.XmlAttribute GetAttributeNode(string localName, string namespaceURI);
            /*0x38f7e20*/ System.Xml.XmlAttribute SetAttributeNode(string localName, string namespaceURI);
            /*0x38f7ed0*/ bool HasAttribute(string name);
            /*0x38f7ef4*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x38f81d4*/ void WriteStartElement(System.Xml.XmlWriter w);
            /*0x38f82ec*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x38f8354*/ void RemoveAllAttributes();
            /*0x38f838c*/ void RemoveAll();
            /*0x38f7898*/ void RemoveAllChildren();
            /*0x38f83b4*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x38f83bc*/ void set_InnerXml(string value);
            /*0x38f84b0*/ string get_InnerText();
            /*0x38f84b8*/ void set_InnerText(string value);
            /*0x38f8574*/ System.Xml.XmlNode get_NextSibling();
            /*0x38f85b0*/ void SetParent(System.Xml.XmlNode node);
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

            /*0x38f85b8*/ XmlEntity(string name, string strdata, string publicId, string systemId, string notationName, System.Xml.XmlDocument doc);
            /*0x38f8680*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x38f86d8*/ bool get_IsReadOnly();
            /*0x38f86e0*/ string get_Name();
            /*0x38f86e8*/ string get_LocalName();
            /*0x38f86f0*/ string get_InnerText();
            /*0x38f86f8*/ void set_InnerText(string value);
            /*0x38f8750*/ bool get_IsContainer();
            /*0x38f8758*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x38f8830*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x38f8838*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x38f8850*/ System.Xml.XmlNodeType get_NodeType();
            /*0x38f8858*/ string get_SystemId();
            /*0x38f8860*/ void set_InnerXml(string value);
            /*0x38f88b8*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x38f88bc*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x38f88c0*/ string get_BaseURI();
            /*0x38f88c8*/ void SetBaseURI(string inBaseURI);
        }

        class XmlEntityReference : System.Xml.XmlLinkedNode
        {
            /*0x20*/ string name;
            /*0x28*/ System.Xml.XmlLinkedNode lastChild;

            /*0x38f4440*/ XmlEntityReference(string name, System.Xml.XmlDocument doc);
            /*0x38f88d0*/ string get_Name();
            /*0x38f88d8*/ string get_LocalName();
            /*0x38f88e0*/ string get_Value();
            /*0x38f88e8*/ void set_Value(string value);
            /*0x38f8940*/ System.Xml.XmlNodeType get_NodeType();
            /*0x38f8948*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x38f8980*/ bool get_IsReadOnly();
            /*0x38f8988*/ bool get_IsContainer();
            /*0x38f8990*/ void SetParent(System.Xml.XmlNode node);
            /*0x38f901c*/ void SetParentForLoad(System.Xml.XmlNode node);
            /*0x38f902c*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x38f9034*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x38f903c*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x38f9054*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x38f907c*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x38f9314*/ string get_BaseURI();
            /*0x38f9344*/ string ConstructBaseURI(string baseURI, string systemId);
            /*0x38f941c*/ string get_ChildBaseURI();
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

            /*0x38f23e8*/ XmlImplementation();
            /*0x38f296c*/ XmlImplementation(System.Xml.XmlNameTable nt);
            /*0x38f94b8*/ System.Xml.XmlDocument CreateDocument();
            /*0x38f9510*/ System.Xml.XmlNameTable get_NameTable();
        }

        class XmlLinkedNode : System.Xml.XmlNode
        {
            /*0x18*/ System.Xml.XmlLinkedNode next;

            /*0x38f1350*/ XmlLinkedNode(System.Xml.XmlDocument doc);
            /*0x38f9518*/ System.Xml.XmlNode get_PreviousSibling();
            /*0x38f9580*/ System.Xml.XmlNode get_NextSibling();
        }

        class XmlLoader
        {
            /*0x10*/ System.Xml.XmlDocument doc;
            /*0x18*/ System.Xml.XmlReader reader;
            /*0x20*/ bool preserveWhitespace;

            static /*0x38f1ff8*/ void ParseXmlDeclarationValue(string strValue, ref string version, ref string encoding, ref string standalone);
            static /*0x38fa3fc*/ System.Exception UnexpectedNodeType(System.Xml.XmlNodeType nodetype);
            /*0x38ef798*/ XmlLoader();
            /*0x38f55cc*/ void Load(System.Xml.XmlDocument doc, System.Xml.XmlReader reader, bool preserveWhitespace);
            /*0x38f95d0*/ void LoadDocSequence(System.Xml.XmlDocument parentDoc);
            /*0x38f531c*/ System.Xml.XmlNode ReadCurrentNode(System.Xml.XmlDocument doc, System.Xml.XmlReader reader);
            /*0x38f963c*/ System.Xml.XmlNode LoadNode(bool skipOverWhitespace);
            /*0x38f9bc0*/ System.Xml.XmlAttribute LoadAttributeNode();
            /*0x38fa50c*/ System.Xml.XmlAttribute LoadDefaultAttribute();
            /*0x38fa6bc*/ void LoadAttributeValue(System.Xml.XmlNode parent, bool direct);
            /*0x38f9ed4*/ System.Xml.XmlEntityReference LoadEntityReferenceNode(bool direct);
            /*0x38fa0b0*/ System.Xml.XmlDeclaration LoadDeclarationNode();
            /*0x38fa250*/ System.Xml.XmlDocumentType LoadDocumentTypeNode();
            /*0x38fa9bc*/ System.Xml.XmlNode LoadNodeDirect();
            /*0x38fbac4*/ System.Xml.XmlAttribute LoadAttributeNodeDirect();
            /*0x38f6e4c*/ void ParseDocumentType(System.Xml.XmlDocumentType dtNode);
            /*0x38fbc04*/ void ParseDocumentType(System.Xml.XmlDocumentType dtNode, bool bUseResolver, System.Xml.XmlResolver resolver);
            /*0x38fae44*/ void LoadDocumentType(System.Xml.IDtdInfo dtdInfo, System.Xml.XmlDocumentType dtNode);
            /*0x38fbed0*/ System.Xml.XmlParserContext GetContext(System.Xml.XmlNode node);
            /*0x38f6798*/ System.Xml.XmlNamespaceManager ParsePartialContent(System.Xml.XmlNode parentNode, string innerxmltext, System.Xml.XmlNodeType nt);
            /*0x38f843c*/ void LoadInnerXmlElement(System.Xml.XmlElement node, string innerxmltext);
            /*0x38ef7a0*/ void LoadInnerXmlAttribute(System.Xml.XmlAttribute node, string innerxmltext);
            /*0x38fc9f4*/ void RemoveDuplicateNamespace(System.Xml.XmlElement elem, System.Xml.XmlNamespaceManager mgr, bool fCheckElemAttrs);
            /*0x38fcc94*/ string EntitizeName(string name);
            /*0x38f87e4*/ void ExpandEntity(System.Xml.XmlEntity ent);
            /*0x38f8a4c*/ void ExpandEntityReference(System.Xml.XmlEntityReference eref);
            /*0x38fc764*/ System.Xml.XmlReader CreateInnerXmlReader(string xmlFragment, System.Xml.XmlNodeType nt, System.Xml.XmlParserContext context, System.Xml.XmlDocument doc);
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

            static /*0x38fcd08*/ System.Xml.XmlName Create(string prefix, string localName, string ns, int hashCode, System.Xml.XmlDocument ownerDoc, System.Xml.XmlName next, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            static /*0x38fd4c8*/ int GetHashCode(string name);
            /*0x38fcdf4*/ XmlName(string prefix, string localName, string ns, int hashCode, System.Xml.XmlDocument ownerDoc, System.Xml.XmlName next);
            /*0x38fd28c*/ string get_LocalName();
            /*0x38fd294*/ string get_NamespaceURI();
            /*0x38fd29c*/ string get_Prefix();
            /*0x38fd2a4*/ int get_HashCode();
            /*0x38fd2ac*/ System.Xml.XmlDocument get_OwnerDocument();
            /*0x38fd2b4*/ string get_Name();
            /*0x38fd484*/ System.Xml.Schema.XmlSchemaValidity get_Validity();
            /*0x38fd48c*/ bool get_IsDefault();
            /*0x38fd494*/ bool get_IsNil();
            /*0x38fd49c*/ System.Xml.Schema.XmlSchemaSimpleType get_MemberType();
            /*0x38fd4a4*/ System.Xml.Schema.XmlSchemaType get_SchemaType();
            /*0x38fd4ac*/ System.Xml.Schema.XmlSchemaElement get_SchemaElement();
            /*0x38fd4b4*/ System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute();
            /*0x38fd4bc*/ bool Equals(System.Xml.Schema.IXmlSchemaInfo schemaInfo);
        }

        class XmlNameEx : System.Xml.XmlName
        {
            /*0x48*/ byte flags;
            /*0x50*/ System.Xml.Schema.XmlSchemaSimpleType memberType;
            /*0x58*/ System.Xml.Schema.XmlSchemaType schemaType;
            /*0x60*/ object decl;

            /*0x38fce9c*/ XmlNameEx(string prefix, string localName, string ns, int hashCode, System.Xml.XmlDocument ownerDoc, System.Xml.XmlName next, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            /*0x38fd58c*/ System.Xml.Schema.XmlSchemaValidity get_Validity();
            /*0x38fd5b8*/ bool get_IsDefault();
            /*0x38fd5c4*/ bool get_IsNil();
            /*0x38fd5d0*/ System.Xml.Schema.XmlSchemaSimpleType get_MemberType();
            /*0x38fd5d8*/ System.Xml.Schema.XmlSchemaType get_SchemaType();
            /*0x38fd5e0*/ System.Xml.Schema.XmlSchemaElement get_SchemaElement();
            /*0x38fd65c*/ System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute();
            /*0x38fd538*/ void SetValidity(System.Xml.Schema.XmlSchemaValidity value);
            /*0x38fd54c*/ void SetIsDefault(bool value);
            /*0x38fd56c*/ void SetIsNil(bool value);
            /*0x38fd6d8*/ bool Equals(System.Xml.Schema.IXmlSchemaInfo schemaInfo);
        }

        class XmlNamedNodeMap : System.Collections.IEnumerable
        {
            /*0x10*/ System.Xml.XmlNode parent;
            /*0x18*/ System.Xml.XmlNamedNodeMap.SmallXmlNodeList nodes;

            /*0x38fda1c*/ XmlNamedNodeMap(System.Xml.XmlNode parent);
            /*0x38fda4c*/ System.Xml.XmlNode GetNamedItem(string name);
            /*0x38fdca0*/ System.Xml.XmlNode SetNamedItem(System.Xml.XmlNode node);
            /*0x38fdecc*/ int get_Count();
            /*0x38fdf60*/ System.Collections.IEnumerator GetEnumerator();
            /*0x38fdae4*/ int FindNodeOffset(string name);
            /*0x38fdd5c*/ int FindNodeOffset(string localName, string namespaceURI);
            /*0x38fe06c*/ System.Xml.XmlNode AddNode(System.Xml.XmlNode node);
            /*0x38fe328*/ System.Xml.XmlNode AddNodeForLoad(System.Xml.XmlNode node, System.Xml.XmlDocument doc);
            /*0x38fe3d0*/ System.Xml.XmlNode RemoveNodeAt(int i);
            /*0x38fde78*/ System.Xml.XmlNode ReplaceNodeAt(int i, System.Xml.XmlNode node);
            /*0x38fe618*/ System.Xml.XmlNode InsertNodeAt(int i, System.Xml.XmlNode node);

            struct SmallXmlNodeList
            {
                /*0x10*/ object field;

                /*0x38fded4*/ int get_Count();
                /*0x38fdbc4*/ object get_Item(int index);
                /*0x38fe1fc*/ void Add(object value);
                /*0x38fe530*/ void RemoveAt(int index);
                /*0x38fe7bc*/ void Insert(int index, object value);
                /*0x38fdf68*/ System.Collections.IEnumerator GetEnumerator();

                class SingleObjectEnumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ object loneValue;
                    /*0x18*/ int position;

                    /*0x38fe964*/ SingleObjectEnumerator(object value);
                    /*0x38fe99c*/ object get_Current();
                    /*0x38fe9e4*/ bool MoveNext();
                    /*0x38fea00*/ void Reset();
                }
            }
        }

        class XmlNode : System.ICloneable, System.Collections.IEnumerable
        {
            /*0x10*/ System.Xml.XmlNode parentNode;

            static /*0x39005a8*/ bool HasReadOnlyParent(System.Xml.XmlNode n);
            static /*0x39010cc*/ void SplitName(string name, ref string prefix, ref string localName);
            static /*0x38ff3e8*/ void NestTextNodes(System.Xml.XmlNode prevNode, System.Xml.XmlNode nextNode);
            static /*0x38ff408*/ void UnnestTextNodes(System.Xml.XmlNode prevNode, System.Xml.XmlNode nextNode);
            /*0x38fea0c*/ XmlNode();
            /*0x38fea14*/ XmlNode(System.Xml.XmlDocument doc);
            /*0x1f30214*/ string get_Name();
            /*0x38fea98*/ string get_Value();
            /*0x38feaa0*/ void set_Value(string value);
            /*0x1f2ffc8*/ System.Xml.XmlNodeType get_NodeType();
            /*0x38feb6c*/ System.Xml.XmlNode get_ParentNode();
            /*0x38fec54*/ System.Xml.XmlNodeList get_ChildNodes();
            /*0x38fecb0*/ System.Xml.XmlNode get_PreviousSibling();
            /*0x38fecb8*/ System.Xml.XmlNode get_NextSibling();
            /*0x38fecc0*/ System.Xml.XmlAttributeCollection get_Attributes();
            /*0x38fecc8*/ System.Xml.XmlDocument get_OwnerDocument();
            /*0x38fed80*/ System.Xml.XmlNode get_FirstChild();
            /*0x38feda4*/ System.Xml.XmlNode get_LastChild();
            /*0x38fedb4*/ bool get_IsContainer();
            /*0x38fedbc*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x38fedc4*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x38fedc8*/ bool AncestorNode(System.Xml.XmlNode node);
            /*0x38fee34*/ System.Xml.XmlNode InsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x38ff43c*/ System.Xml.XmlNode InsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x38ff9c4*/ System.Xml.XmlNode RemoveChild(System.Xml.XmlNode oldChild);
            /*0x38ffd94*/ System.Xml.XmlNode PrependChild(System.Xml.XmlNode newChild);
            /*0x38ffddc*/ System.Xml.XmlNode AppendChild(System.Xml.XmlNode newChild);
            /*0x39002ac*/ System.Xml.XmlNode AppendChildForLoad(System.Xml.XmlNode newChild, System.Xml.XmlDocument doc);
            /*0x3900478*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x3900480*/ bool CanInsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x3900488*/ bool CanInsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x3900490*/ bool get_HasChildNodes();
            System.Xml.XmlNode CloneNode(bool deep);
            /*0x39004b4*/ void CopyChildren(System.Xml.XmlDocument doc, System.Xml.XmlNode container, bool deep);
            /*0x3900550*/ string get_NamespaceURI();
            /*0x3900568*/ string get_Prefix();
            /*0x3900580*/ void set_Prefix(string value);
            /*0x1f30214*/ string get_LocalName();
            /*0x3900584*/ bool get_IsReadOnly();
            /*0x3900684*/ object System.ICloneable.Clone();
            /*0x3900698*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x39006f4*/ System.Collections.IEnumerator GetEnumerator();
            /*0x3900750*/ void AppendChildText(System.Text.StringBuilder builder);
            /*0x3900854*/ string get_InnerText();
            /*0x3900950*/ void set_InnerText(string value);
            /*0x3900a20*/ void set_InnerXml(string value);
            /*0x3900a78*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x3900ad0*/ string get_BaseURI();
            /*0x1f30ebc*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x1f30ebc*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x3900bf4*/ void RemoveAll();
            /*0x3900c5c*/ System.Xml.XmlDocument get_Document();
            /*0x3900d08*/ string GetPrefixOfNamespace(string namespaceURI);
            /*0x3900d30*/ string GetPrefixOfNamespaceStrict(string namespaceURI);
            /*0x3901088*/ void SetParent(System.Xml.XmlNode node);
            /*0x39010c4*/ void SetParentForLoad(System.Xml.XmlNode node);
            /*0x3901198*/ System.Xml.XmlNode FindChild(System.Xml.XmlNodeType type);
            /*0x39011fc*/ System.Xml.XmlNodeChangedEventArgs GetEventArgs(System.Xml.XmlNode node, System.Xml.XmlNode oldParent, System.Xml.XmlNode newParent, string oldValue, string newValue, System.Xml.XmlNodeChangedAction action);
            /*0x3901320*/ void BeforeEvent(System.Xml.XmlNodeChangedEventArgs args);
            /*0x3901364*/ void AfterEvent(System.Xml.XmlNodeChangedEventArgs args);
            /*0x39013a8*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x3901520*/ string get_XmlLang();
            /*0x3901608*/ bool get_IsText();
        }

        class XmlNodeChangedEventArgs : System.EventArgs
        {
            /*0x10*/ System.Xml.XmlNodeChangedAction action;
            /*0x18*/ System.Xml.XmlNode node;
            /*0x20*/ System.Xml.XmlNode oldParent;
            /*0x28*/ System.Xml.XmlNode newParent;
            /*0x30*/ string oldValue;
            /*0x38*/ string newValue;

            /*0x3901610*/ XmlNodeChangedEventArgs(System.Xml.XmlNode node, System.Xml.XmlNode oldParent, System.Xml.XmlNode newParent, string oldValue, string newValue, System.Xml.XmlNodeChangedAction action);
            /*0x39016ec*/ System.Xml.XmlNodeChangedAction get_Action();
        }

        class XmlNodeChangedEventHandler : System.MulticastDelegate
        {
            /*0x39016f4*/ XmlNodeChangedEventHandler(object object, nint method);
            /*0x3901800*/ void Invoke(object sender, System.Xml.XmlNodeChangedEventArgs e);
        }

        class XmlNodeList : System.Collections.IEnumerable, System.IDisposable
        {
            /*0x3901830*/ XmlNodeList();
            /*0x1f30240*/ System.Xml.XmlNode Item(int index);
            /*0x1f2ffc8*/ int get_Count();
            /*0x1f30214*/ System.Collections.IEnumerator GetEnumerator();
            /*0x3901814*/ System.Xml.XmlNode get_ItemOf(int i);
            /*0x3901820*/ void System.IDisposable.Dispose();
            /*0x390182c*/ void PrivateDisposeNodeList();
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

            /*0x3901838*/ XmlNodeReaderNavigator(System.Xml.XmlNode node);
            /*0x3901bf8*/ System.Xml.XmlNodeType get_NodeType();
            /*0x3901c3c*/ string get_NamespaceURI();
            /*0x3901c5c*/ string get_Name();
            /*0x3901d40*/ string get_LocalName();
            /*0x3901dbc*/ bool get_CreatedOnAttribute();
            /*0x3901d20*/ bool IsLocalNameEmpty(System.Xml.XmlNodeType nt);
            /*0x3901dc4*/ string get_Prefix();
            /*0x3901de4*/ string get_Value();
            /*0x3902218*/ string get_BaseURI();
            /*0x3902238*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x3902258*/ string get_XmlLang();
            /*0x3902278*/ bool get_IsEmptyElement();
            /*0x3902324*/ bool get_IsDefault();
            /*0x39023d8*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x39023f8*/ System.Xml.XmlNameTable get_NameTable();
            /*0x3902400*/ int get_AttributeCount();
            /*0x3902668*/ void CheckIndexCondition(int attributeIndex);
            /*0x3902058*/ void InitDecAttr();
            /*0x39026d0*/ string GetDeclarationAttr(System.Xml.XmlDeclaration decl, string name);
            /*0x39027b0*/ string GetDeclarationAttr(int i);
            /*0x3902804*/ int GetDecAttrInd(string name);
            /*0x390253c*/ void InitDocTypeAttr();
            /*0x390289c*/ string GetDocumentTypeAttr(System.Xml.XmlDocumentType docType, string name);
            /*0x3902948*/ string GetDocumentTypeAttr(int i);
            /*0x390299c*/ int GetDocTypeAttrInd(string name);
            /*0x3902a34*/ string GetAttributeFromElement(System.Xml.XmlElement elem, string name);
            /*0x3902a78*/ string GetAttribute(string name);
            /*0x3902c14*/ string GetAttributeFromElement(System.Xml.XmlElement elem, string name, string ns);
            /*0x3902c5c*/ string GetAttribute(string name, string ns);
            /*0x3902e2c*/ string GetAttribute(int attributeIndex);
            /*0x3902fd4*/ void LogMove(int level);
            /*0x3903018*/ void RollBackMove(ref int level);
            /*0x3903064*/ bool get_IsOnDeclOrDocType();
            /*0x3903094*/ void ResetToAttribute(ref int level);
            /*0x3903148*/ void ResetMove(ref int level, ref System.Xml.XmlNodeType nt);
            /*0x3903328*/ bool MoveToAttribute(string name);
            /*0x3903498*/ bool MoveToAttributeFromElement(System.Xml.XmlElement elem, string name, string ns);
            /*0x3903340*/ bool MoveToAttribute(string name, string namespaceURI);
            /*0x3903574*/ void MoveToAttribute(int attributeIndex);
            /*0x3903734*/ bool MoveToNextAttribute(ref int level);
            /*0x3903920*/ bool MoveToParent();
            /*0x3903980*/ bool MoveToFirstChild();
            /*0x39039e8*/ bool MoveToNextSibling(System.Xml.XmlNode node);
            /*0x3903a54*/ bool MoveToNext();
            /*0x3903a94*/ bool MoveToElement();
            /*0x3903b24*/ string LookupNamespace(string prefix);
            /*0x3903dc4*/ string DefaultLookupNamespace(string prefix);
            /*0x3903ee0*/ string LookupPrefix(string namespaceName);
            /*0x39042a8*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x3904784*/ bool ReadAttributeValue(ref int level, ref bool bResolveEntity, ref System.Xml.XmlNodeType nt);
            /*0x390499c*/ System.Xml.XmlDocument get_Document();

            struct VirtualAttribute
            {
                /*0x10*/ string name;
                /*0x18*/ string value;

                /*0x3901bc8*/ VirtualAttribute(string name, string value);
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

            /*0x39049a4*/ XmlNodeReader(System.Xml.XmlNode node);
            /*0x3904a98*/ bool IsInReadingStates();
            /*0x3904aa8*/ System.Xml.XmlNodeType get_NodeType();
            /*0x3904ac4*/ string get_Name();
            /*0x3904afc*/ string get_LocalName();
            /*0x3904b34*/ string get_NamespaceURI();
            /*0x3904b88*/ string get_Prefix();
            /*0x3904bdc*/ string get_Value();
            /*0x3904c14*/ int get_Depth();
            /*0x3904c1c*/ string get_BaseURI();
            /*0x3904c48*/ bool get_CanResolveEntity();
            /*0x3904c50*/ bool get_IsEmptyElement();
            /*0x3904c78*/ bool get_IsDefault();
            /*0x3904ca0*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x3904ce4*/ string get_XmlLang();
            /*0x3904d38*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x3904d7c*/ int get_AttributeCount();
            /*0x3904db0*/ string GetAttribute(string name);
            /*0x3904dd8*/ string GetAttribute(string name, string namespaceURI);
            /*0x3904e18*/ string GetAttribute(int attributeIndex);
            /*0x3904e84*/ bool MoveToAttribute(string name);
            /*0x3904f84*/ void MoveToAttribute(int attributeIndex);
            /*0x390514c*/ bool MoveToFirstAttribute();
            /*0x390522c*/ bool MoveToNextAttribute();
            /*0x3905328*/ bool MoveToElement();
            /*0x3905420*/ bool Read();
            /*0x3905428*/ bool Read(bool fSkipChildren);
            /*0x390552c*/ bool ReadNextNode(bool fSkipChildren);
            /*0x39057dc*/ void SetEndOfFile();
            /*0x39057f4*/ bool ReadAtZeroLevel(bool fSkipChildren);
            /*0x39056f0*/ bool ReadForward(bool fSkipChildren);
            /*0x39056d0*/ void ReSetReadingMarks();
            /*0x3905864*/ bool get_EOF();
            /*0x3905888*/ void Close();
            /*0x3905894*/ System.Xml.ReadState get_ReadState();
            /*0x390589c*/ void Skip();
            /*0x39058a4*/ string ReadString();
            /*0x3905948*/ bool get_HasAttributes();
            /*0x390596c*/ System.Xml.XmlNameTable get_NameTable();
            /*0x3905984*/ string LookupNamespace(string prefix);
            /*0x39059bc*/ void ResolveEntity();
            /*0x3905a38*/ bool ReadAttributeValue();
            /*0x3904f64*/ void FinishReadBinary();
            /*0x3905a84*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x3905a98*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            /*0x3905aac*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0x3905b0c*/ System.Xml.IDtdInfo get_DtdInfo();
        }

        class XmlNotation : System.Xml.XmlNode
        {
            /*0x18*/ string publicId;
            /*0x20*/ string systemId;
            /*0x28*/ string name;

            /*0x3905b30*/ XmlNotation(string name, string publicId, string systemId, System.Xml.XmlDocument doc);
            /*0x3905bbc*/ string get_Name();
            /*0x3905bc4*/ string get_LocalName();
            /*0x3905bcc*/ System.Xml.XmlNodeType get_NodeType();
            /*0x3905bd4*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x3905c2c*/ bool get_IsReadOnly();
            /*0x3905c34*/ void set_InnerXml(string value);
            /*0x3905c8c*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x3905c90*/ void WriteContentTo(System.Xml.XmlWriter w);
        }

        class XmlProcessingInstruction : System.Xml.XmlLinkedNode
        {
            /*0x20*/ string target;
            /*0x28*/ string data;

            /*0x3905c94*/ XmlProcessingInstruction(string target, string data, System.Xml.XmlDocument doc);
            /*0x3905cdc*/ string get_Name();
            /*0x3905d00*/ string get_LocalName();
            /*0x3905d0c*/ string get_Value();
            /*0x3905d14*/ void set_Value(string value);
            /*0x3905d18*/ void set_Data(string value);
            /*0x3905ddc*/ string get_InnerText();
            /*0x3905de4*/ void set_InnerText(string value);
            /*0x3905de8*/ System.Xml.XmlNodeType get_NodeType();
            /*0x3905df0*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x3905e28*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x3905e50*/ void WriteContentTo(System.Xml.XmlWriter w);
        }

        class XmlSignificantWhitespace : System.Xml.XmlCharacterData
        {
            /*0x3905e54*/ XmlSignificantWhitespace(string strData, System.Xml.XmlDocument doc);
            /*0x3905ef0*/ string get_Name();
            /*0x3905f18*/ string get_LocalName();
            /*0x3905f40*/ System.Xml.XmlNodeType get_NodeType();
            /*0x3905f48*/ System.Xml.XmlNode get_ParentNode();
            /*0x3905fd0*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x390602c*/ string get_Value();
            /*0x390603c*/ void set_Value(string value);
            /*0x39060c8*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x3906108*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x390610c*/ bool get_IsText();
        }

        class XmlText : System.Xml.XmlCharacterData
        {
            /*0x3906114*/ XmlText(string strData);
            /*0x3906120*/ XmlText(string strData, System.Xml.XmlDocument doc);
            /*0x3906128*/ string get_Name();
            /*0x3906150*/ string get_LocalName();
            /*0x3906178*/ System.Xml.XmlNodeType get_NodeType();
            /*0x3906180*/ System.Xml.XmlNode get_ParentNode();
            /*0x3906204*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x3906260*/ string get_Value();
            /*0x3906270*/ void set_Value(string value);
            /*0x3906338*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x3906378*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x390637c*/ bool get_IsText();
        }

        class XmlUnspecifiedAttribute : System.Xml.XmlAttribute
        {
            /*0x28*/ bool fSpecified;

            /*0x3906384*/ XmlUnspecifiedAttribute(string prefix, string localName, string namespaceURI, System.Xml.XmlDocument doc);
            /*0x390638c*/ bool get_Specified();
            /*0x3906394*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x39064c4*/ void set_InnerText(string value);
            /*0x39064e4*/ System.Xml.XmlNode InsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x3906504*/ System.Xml.XmlNode InsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x3906524*/ System.Xml.XmlNode RemoveChild(System.Xml.XmlNode oldChild);
            /*0x3906544*/ System.Xml.XmlNode AppendChild(System.Xml.XmlNode newChild);
            /*0x3906564*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x3906578*/ void SetSpecified(bool f);
        }

        class XmlWhitespace : System.Xml.XmlCharacterData
        {
            /*0x3906580*/ XmlWhitespace(string strData, System.Xml.XmlDocument doc);
            /*0x390661c*/ string get_Name();
            /*0x3906644*/ string get_LocalName();
            /*0x390666c*/ System.Xml.XmlNodeType get_NodeType();
            /*0x3906674*/ System.Xml.XmlNode get_ParentNode();
            /*0x39066fc*/ string get_Value();
            /*0x390670c*/ void set_Value(string value);
            /*0x3906798*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x39067f4*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x3906834*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x3906838*/ bool get_IsText();
        }

        class EmptyEnumerator : System.Collections.IEnumerator
        {
            /*0x39068a4*/ EmptyEnumerator();
            /*0x3906840*/ bool System.Collections.IEnumerator.MoveNext();
            /*0x3906848*/ void System.Collections.IEnumerator.Reset();
            /*0x390684c*/ object System.Collections.IEnumerator.get_Current();
        }

        class HWStack : System.ICloneable
        {
            /*0x10*/ object[] stack;
            /*0x18*/ int growthRate;
            /*0x1c*/ int used;
            /*0x20*/ int size;
            /*0x24*/ int limit;

            /*0x39068ac*/ HWStack(int GrowthRate);
            /*0x39068b4*/ HWStack(int GrowthRate, int limit);
            /*0x3906ca4*/ HWStack(object[] stack, int growthRate, int used, int size);
            /*0x3906934*/ object Push();
            /*0x3906a74*/ object Pop();
            /*0x3906abc*/ object Peek();
            /*0x3906b00*/ void AddToTop(object o);
            /*0x3906b7c*/ object get_Item(int index);
            /*0x3906bf0*/ void set_Item(int index, object value);
            /*0x3906c9c*/ int get_Length();
            /*0x3906cf4*/ object Clone();
        }

        interface IXmlLineInfo
        {
            /*0x1f2fe14*/ bool HasLineInfo();
            /*0x1f2ffc8*/ int get_LineNumber();
            /*0x1f2ffc8*/ int get_LinePosition();
        }

        class PositionInfo : System.Xml.IXmlLineInfo
        {
            static /*0x3906df4*/ System.Xml.PositionInfo GetPositionInfo(object o);
            /*0x3906ee0*/ PositionInfo();
            /*0x3906ddc*/ bool HasLineInfo();
            /*0x3906de4*/ int get_LineNumber();
            /*0x3906dec*/ int get_LinePosition();
        }

        class ReaderPositionInfo : System.Xml.PositionInfo
        {
            /*0x10*/ System.Xml.IXmlLineInfo lineInfo;

            /*0x3906eb0*/ ReaderPositionInfo(System.Xml.IXmlLineInfo lineInfo);
            /*0x3906ee8*/ bool HasLineInfo();
            /*0x3906f88*/ int get_LineNumber();
            /*0x390702c*/ int get_LinePosition();
        }

        interface IXmlNamespaceResolver
        {
            /*0x1f30240*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x1f302cc*/ string LookupNamespace(string prefix);
            /*0x1f302cc*/ string LookupPrefix(string namespaceName);
        }

        struct LineInfo
        {
            /*0x10*/ int lineNo;
            /*0x14*/ int linePos;

            /*0x39070d0*/ LineInfo(int lineNo, int linePos);
            /*0x39070d8*/ void Set(int lineNo, int linePos);
        }

        class NameTable : System.Xml.XmlNameTable
        {
            /*0x10*/ System.Xml.NameTable.Entry[] entries;
            /*0x18*/ int count;
            /*0x1c*/ int mask;
            /*0x20*/ int hashCodeRandomizer;

            static /*0x3907524*/ bool TextEquals(string str1, char[] str2, int str2Start, int str2Length);
            /*0x39070e0*/ NameTable();
            /*0x390715c*/ string Add(string key);
            /*0x39073c4*/ string Add(char[] key, int start, int len);
            /*0x39075e0*/ string Get(string value);
            /*0x39072b4*/ string AddEntry(string str, int hashCode);
            /*0x3907778*/ void Grow();

            class Entry
            {
                /*0x10*/ string str;
                /*0x18*/ int hashCode;
                /*0x20*/ System.Xml.NameTable.Entry next;

                /*0x3907724*/ Entry(string str, int hashCode, System.Xml.NameTable.Entry next);
            }
        }

        class Ref
        {
            static /*0x390107c*/ bool Equal(string strA, string strB);
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

            static /*0x3907990*/ System.Xml.IDtdParser Create();
            static /*0x3911760*/ string StripSpaces(string value);
            /*0x39078d4*/ DtdParser();
            /*0x39079e0*/ void Initialize(System.Xml.IDtdParserAdapter readerAdapter);
            /*0x3907e00*/ void InitializeFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, System.Xml.IDtdParserAdapter adapter);
            /*0x3908274*/ System.Xml.IDtdInfo System.Xml.IDtdParser.ParseInternalDtd(System.Xml.IDtdParserAdapter adapter, bool saveInternalSubset);
            /*0x3908544*/ System.Xml.IDtdInfo System.Xml.IDtdParser.ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, System.Xml.IDtdParserAdapter adapter);
            /*0x3908568*/ bool get_ParsingInternalSubset();
            /*0x3908578*/ bool get_IgnoreEntityReferences();
            /*0x3908588*/ bool get_SaveInternalSubsetValue();
            /*0x3908648*/ bool get_ParsingTopLevelMarkup();
            /*0x3908678*/ bool get_SupportNamespaces();
            /*0x3908680*/ bool get_Normalize();
            /*0x39082a4*/ void Parse(bool saveInternalSubset);
            /*0x39086dc*/ void ParseInDocumentDtd(bool saveInternalSubset);
            /*0x3908688*/ void ParseFreeFloatingDtd();
            /*0x3909b90*/ void ParseInternalSubset();
            /*0x3909b94*/ void ParseExternalSubset();
            /*0x3909d44*/ void ParseSubset();
            /*0x390a120*/ void ParseAttlistDecl();
            /*0x390bb20*/ void ParseAttlistType(System.Xml.Schema.SchemaAttDef attrDef, System.Xml.Schema.SchemaElementDecl elementDecl, bool ignoreErrors);
            /*0x390c0ac*/ void ParseAttlistDefault(System.Xml.Schema.SchemaAttDef attrDef, bool ignoreErrors);
            /*0x390a680*/ void ParseElementDecl();
            /*0x390c828*/ void ParseElementOnlyContent(System.Xml.Schema.ParticleContentValidator pcv, int startParenEntityId);
            /*0x390cba0*/ void ParseHowMany(System.Xml.Schema.ParticleContentValidator pcv);
            /*0x390c5a4*/ void ParseElementMixedContent(System.Xml.Schema.ParticleContentValidator pcv, int startParenEntityId);
            /*0x390aa28*/ void ParseEntityDecl();
            /*0x390adb8*/ void ParseNotationDecl();
            /*0x390c344*/ void AddUndeclaredNotation(string notationName);
            /*0x390afbc*/ void ParseComment();
            /*0x390b208*/ void ParsePI();
            /*0x390b384*/ void ParseCondSection();
            /*0x3909660*/ void ParseExternalId(System.Xml.DtdParser.Token idTokenType, System.Xml.DtdParser.Token declType, ref string publicId, ref string systemId);
            /*0x3908c28*/ System.Xml.DtdParser.Token GetToken(bool needWhiteSpace);
            /*0x390d334*/ System.Xml.DtdParser.Token ScanSubsetContent();
            /*0x390d2cc*/ System.Xml.DtdParser.Token ScanNameExpected();
            /*0x390d2f0*/ System.Xml.DtdParser.Token ScanQNameExpected();
            /*0x390d314*/ System.Xml.DtdParser.Token ScanNmtokenExpected();
            /*0x390da78*/ System.Xml.DtdParser.Token ScanDoctype1();
            /*0x390dbdc*/ System.Xml.DtdParser.Token ScanDoctype2();
            /*0x390ffec*/ System.Xml.DtdParser.Token ScanClosingTag();
            /*0x390dc94*/ System.Xml.DtdParser.Token ScanElement1();
            /*0x390de88*/ System.Xml.DtdParser.Token ScanElement2();
            /*0x390e04c*/ System.Xml.DtdParser.Token ScanElement3();
            /*0x390e0cc*/ System.Xml.DtdParser.Token ScanElement4();
            /*0x390e1ac*/ System.Xml.DtdParser.Token ScanElement5();
            /*0x390e2a4*/ System.Xml.DtdParser.Token ScanElement6();
            /*0x390e374*/ System.Xml.DtdParser.Token ScanElement7();
            /*0x390e3d4*/ System.Xml.DtdParser.Token ScanAttlist1();
            /*0x390e498*/ System.Xml.DtdParser.Token ScanAttlist2();
            /*0x390eb7c*/ System.Xml.DtdParser.Token ScanAttlist3();
            /*0x390ec1c*/ System.Xml.DtdParser.Token ScanAttlist4();
            /*0x390ecec*/ System.Xml.DtdParser.Token ScanAttlist5();
            /*0x390edbc*/ System.Xml.DtdParser.Token ScanAttlist6();
            /*0x390f17c*/ System.Xml.DtdParser.Token ScanAttlist7();
            /*0x3910624*/ System.Xml.DtdParser.Token ScanLiteral(System.Xml.DtdParser.LiteralType literalType);
            /*0x391110c*/ System.Xml.XmlQualifiedName ScanEntityName();
            /*0x390f238*/ System.Xml.DtdParser.Token ScanNotation1();
            /*0x390f374*/ System.Xml.DtdParser.Token ScanSystemId();
            /*0x390f544*/ System.Xml.DtdParser.Token ScanEntity1();
            /*0x390f5b8*/ System.Xml.DtdParser.Token ScanEntity2();
            /*0x390f728*/ System.Xml.DtdParser.Token ScanEntity3();
            /*0x390f428*/ System.Xml.DtdParser.Token ScanPublicId1();
            /*0x390f4dc*/ System.Xml.DtdParser.Token ScanPublicId2();
            /*0x390f82c*/ System.Xml.DtdParser.Token ScanCondSection1();
            /*0x390faf8*/ System.Xml.DtdParser.Token ScanCondSection2();
            /*0x390fb90*/ System.Xml.DtdParser.Token ScanCondSection3();
            /*0x39102e8*/ void ScanName();
            /*0x39102f0*/ void ScanQName();
            /*0x3911494*/ void ScanQName(bool isQName);
            /*0x391171c*/ bool ReadDataInName();
            /*0x39102f8*/ void ScanNmtoken();
            /*0x391045c*/ bool EatPublicKeyword();
            /*0x3910540*/ bool EatSystemKeyword();
            /*0x39094f0*/ System.Xml.XmlQualifiedName GetNameQualified(bool canHavePrefix);
            /*0x390c324*/ string GetNameString();
            /*0x390c4c8*/ string GetNmtokenString();
            /*0x390c548*/ string GetValue();
            /*0x390c4e8*/ string GetValueWithStrippedSpaces();
            /*0x3910080*/ int ReadData();
            /*0x3908a9c*/ void LoadParsingBuffer();
            /*0x3909b88*/ void SaveParsingBuffer();
            /*0x390b6ac*/ void SaveParsingBuffer(int internalSubsetValueEndPos);
            /*0x390d1c8*/ bool HandleEntityReference(bool paramEntity, bool inLiteral, bool inAttribute);
            /*0x3911978*/ bool HandleEntityReference(System.Xml.XmlQualifiedName entityName, bool paramEntity, bool inLiteral, bool inAttribute);
            /*0x3910144*/ bool HandleEntityEnd(bool inLiteral);
            /*0x391126c*/ System.Xml.Schema.SchemaEntity VerifyEntityReference(System.Xml.XmlQualifiedName entityName, bool paramEntity, bool mustBeDeclared, bool inAttribute);
            /*0x390b5d8*/ void SendValidationEvent(int pos, System.Xml.Schema.XmlSeverityType severity, string code, string arg);
            /*0x390c264*/ void SendValidationEvent(System.Xml.Schema.XmlSeverityType severity, string code, string arg);
            /*0x3908958*/ void SendValidationEvent(System.Xml.Schema.XmlSeverityType severity, System.Xml.Schema.XmlSchemaException e);
            /*0x390c258*/ bool IsAttributeValueType(System.Xml.DtdParser.Token token);
            /*0x390b800*/ int get_LineNo();
            /*0x390b8a4*/ int get_LinePos();
            /*0x3908840*/ string get_BaseUriStr();
            /*0x3909490*/ void OnUnexpectedError();
            /*0x390b36c*/ void Throw(int curPos, string res);
            /*0x390cc10*/ void Throw(int curPos, string res, string arg);
            /*0x390cf64*/ void Throw(int curPos, string res, string[] args);
            /*0x390b954*/ void Throw(string res, string arg, int lineNo, int linePos);
            /*0x39081f8*/ void ThrowInvalidChar(int pos, string data, int invCharPos);
            /*0x390d148*/ void ThrowInvalidChar(char[] data, int length, int invCharPos);
            /*0x390b7f8*/ void ThrowUnexpectedToken(int pos, string expectedToken);
            /*0x390cdf4*/ void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2);
            /*0x390d218*/ string ParseUnexpectedToken(int startPos);

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

                /*0x3911c2c*/ UndeclaredNotation(string name, int lineNo, int linePos);
            }

            class ParseElementOnlyContent_LocalFrame
            {
                /*0x10*/ int startParenEntityId;
                /*0x14*/ System.Xml.DtdParser.Token parsingSchema;

                /*0x3911c80*/ ParseElementOnlyContent_LocalFrame(int startParentEntityIdParam);
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

            static /*0x3912ca0*/ ValidateNames();
            static /*0x3911cac*/ int ParseNmtoken(string s, int offset);
            static /*0x3911d74*/ int ParseNmtokenNoNamespaces(string s, int offset);
            static /*0x3911e58*/ int ParseNameNoNamespaces(string s, int offset);
            static /*0x3911fb0*/ bool IsNameNoNamespaces(string s);
            static /*0x3912030*/ int ParseNCName(string s, int offset);
            static /*0x391214c*/ int ParseNCName(string s);
            static /*0x39121a4*/ int ParseQName(string s, int offset, ref int colonOffset);
            static /*0x3912280*/ void ParseQNameThrow(string s, ref string prefix, ref string localName);
            static /*0x39123b4*/ void ThrowInvalidName(string s, int offsetStartChar, int offsetBadChar);
            static /*0x3912710*/ System.Exception GetInvalidNameException(string s, int offsetStartChar, int offsetBadChar);
            static /*0x39128d4*/ void SplitQName(string name, ref string prefix, ref string lname);
        }

        struct XmlCharType
        {
            static /*0x0*/ object s_Lock;
            static /*0x8*/ byte[] s_CharProperties;
            /*0x10*/ byte[] charProperties;

            static /*0x3912cf8*/ object get_StaticLock();
            static /*0x3912d8c*/ void InitInstance();
            static /*0x3912ff4*/ void SetProperties(byte[] chProps, string ranges, byte value);
            static /*0x39125f4*/ System.Xml.XmlCharType get_Instance();
            static /*0x39132ac*/ bool IsDigit(char ch);
            static /*0x39132d4*/ bool IsHighSurrogate(int ch);
            static /*0x39132e4*/ bool IsLowSurrogate(int ch);
            static /*0x39132f4*/ bool IsSurrogate(int ch);
            static /*0x3913304*/ int CombineSurrogateChar(int lowChar, int highChar);
            static /*0x391331c*/ void SplitSurrogateChar(int combinedChar, ref char lowChar, ref char highChar);
            static /*0x39134cc*/ bool IsOnlyDigits(string str, int startPos, int len);
            static /*0x39132c0*/ bool InRange(int value, int start, int end);
            /*0x39130b8*/ XmlCharType(byte[] charProperties);
            /*0x39130c0*/ bool IsWhiteSpace(char ch);
            /*0x39125c0*/ bool IsNCNameSingleChar(char ch);
            /*0x391266c*/ bool IsStartNCNameSingleChar(char ch);
            /*0x39130f4*/ bool IsNameSingleChar(char ch);
            /*0x3913118*/ bool IsCharData(char ch);
            /*0x391314c*/ bool IsPubidChar(char ch);
            /*0x39131c8*/ bool IsTextChar(char ch);
            /*0x39131fc*/ bool IsLetter(char ch);
            /*0x3913230*/ bool IsNCNameCharXml4e(char ch);
            /*0x3913264*/ bool IsStartNCNameCharXml4e(char ch);
            /*0x3913288*/ bool IsNameCharXml4e(char ch);
            /*0x3913354*/ bool IsOnlyWhitespace(string str);
            /*0x391336c*/ int IsOnlyWhitespaceWithPos(string str);
            /*0x39133f4*/ int IsOnlyCharData(string str);
            /*0x3913574*/ int IsPublicId(string str);
        }

        class XmlComplianceUtil
        {
            static /*0x39135d4*/ string NonCDataNormalize(string value);
            static /*0x391386c*/ string CDataNormalize(string value);
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

            static /*0x391a5dc*/ XmlConvert();
            static /*0x3913a48*/ string EncodeName(string name);
            static /*0x3914478*/ string EncodeLocalName(string name);
            static /*0x39144d4*/ string DecodeName(string name);
            static /*0x3913aa4*/ string EncodeName(string name, bool first, bool local);
            static /*0x3914dd8*/ int FromHex(char digit);
            static /*0x3914e04*/ byte[] FromBinHexString(string s);
            static /*0x3914e5c*/ byte[] FromBinHexString(string s, bool allowOddCount);
            static /*0x3914ec8*/ string ToBinHexString(byte[] inArray);
            static /*0x3914f28*/ string VerifyName(string name);
            static /*0x391513c*/ System.Exception TryVerifyName(string name);
            static /*0x3915284*/ string VerifyQName(string name, System.Xml.ExceptionType exceptionType);
            static /*0x3915488*/ string VerifyNCName(string name);
            static /*0x39154e0*/ string VerifyNCName(string name, System.Xml.ExceptionType exceptionType);
            static /*0x3915630*/ System.Exception TryVerifyNCName(string name);
            static /*0x39156d0*/ string VerifyTOKEN(string token);
            static /*0x3915804*/ System.Exception TryVerifyTOKEN(string token);
            static /*0x3915938*/ System.Exception TryVerifyNMTOKEN(string name);
            static /*0x3915a60*/ System.Exception TryVerifyNormalizedString(string str);
            static /*0x3915b28*/ string ToString(bool value);
            static /*0x3915b90*/ string ToString(char value);
            static /*0x3915bcc*/ string ToString(decimal value);
            static /*0x3915c68*/ string ToString(sbyte value);
            static /*0x3915c94*/ string ToString(short value);
            static /*0x3915cc0*/ string ToString(int value);
            static /*0x3915cec*/ string ToString(long value);
            static /*0x3915d14*/ string ToString(byte value);
            static /*0x3915d40*/ string ToString(ushort value);
            static /*0x3915d6c*/ string ToString(uint value);
            static /*0x3915d98*/ string ToString(ulong value);
            static /*0x3915dc0*/ string ToString(float value);
            static /*0x3915f30*/ string ToString(double value);
            static /*0x391602c*/ string ToString(System.TimeSpan value);
            static /*0x3916084*/ string ToString(System.DateTime value, string format);
            static /*0x3916128*/ string ToString(System.DateTime value, System.Xml.XmlDateTimeSerializationMode dateTimeOption);
            static /*0x3916500*/ string ToString(System.DateTimeOffset value);
            static /*0x3916588*/ string ToString(System.Guid value);
            static /*0x39165ac*/ bool ToBoolean(string s);
            static /*0x39167d8*/ System.Exception TryToBoolean(string s, ref bool result);
            static /*0x3916a0c*/ char ToChar(string s);
            static /*0x3916ac8*/ System.Exception TryToChar(string s, ref char result);
            static /*0x3916c38*/ decimal ToDecimal(string s);
            static /*0x3916ca8*/ System.Exception TryToDecimal(string s, ref decimal result);
            static /*0x3916e44*/ decimal ToInteger(string s);
            static /*0x3916eb4*/ System.Exception TryToInteger(string s, ref decimal result);
            static /*0x3917050*/ sbyte ToSByte(string s);
            static /*0x3917078*/ System.Exception TryToSByte(string s, ref sbyte result);
            static /*0x39171e0*/ short ToInt16(string s);
            static /*0x3917208*/ System.Exception TryToInt16(string s, ref short result);
            static /*0x3917370*/ int ToInt32(string s);
            static /*0x3917398*/ System.Exception TryToInt32(string s, ref int result);
            static /*0x3917500*/ long ToInt64(string s);
            static /*0x3917528*/ System.Exception TryToInt64(string s, ref long result);
            static /*0x3917690*/ byte ToByte(string s);
            static /*0x39176b8*/ System.Exception TryToByte(string s, ref byte result);
            static /*0x3917820*/ ushort ToUInt16(string s);
            static /*0x3917848*/ System.Exception TryToUInt16(string s, ref ushort result);
            static /*0x39179b0*/ uint ToUInt32(string s);
            static /*0x39179d8*/ System.Exception TryToUInt32(string s, ref uint result);
            static /*0x3917b40*/ ulong ToUInt64(string s);
            static /*0x3917b68*/ System.Exception TryToUInt64(string s, ref ulong result);
            static /*0x3917cd0*/ float ToSingle(string s);
            static /*0x3917de8*/ System.Exception TryToSingle(string s, ref float result);
            static /*0x3918030*/ double ToDouble(string s);
            static /*0x3918148*/ System.Exception TryToDouble(string s, ref double result);
            static /*0x3918390*/ double ToXPathDouble(object o);
            static /*0x39185b0*/ System.TimeSpan ToTimeSpan(string s);
            static /*0x391875c*/ System.Exception TryToTimeSpan(string s, ref System.TimeSpan result);
            static /*0x3918808*/ string[] get_AllDateTimeFormats();
            static /*0x39188a0*/ void CreateAllDateTimeFormats();
            static /*0x3918e38*/ System.DateTime ToDateTime(string s);
            static /*0x3918e94*/ System.DateTime ToDateTime(string s, string[] formats);
            static /*0x3918f38*/ System.DateTime ToDateTime(string s, System.Xml.XmlDateTimeSerializationMode dateTimeOption);
            static /*0x3919174*/ System.DateTimeOffset ToDateTimeOffset(string s);
            static /*0x391923c*/ System.Guid ToGuid(string s);
            static /*0x3919268*/ System.Exception TryToGuid(string s, ref System.Guid result);
            static /*0x3916350*/ System.DateTime SwitchToLocalTime(System.DateTime value);
            static /*0x3916428*/ System.DateTime SwitchToUtcTime(System.DateTime value);
            static /*0x3919444*/ System.Uri ToUri(string s);
            static /*0x39195f0*/ System.Exception TryToUri(string s, ref System.Uri result);
            static /*0x391981c*/ bool StrEqual(char[] chars, int strPos1, int strLen1, string str2);
            static /*0x391676c*/ string TrimString(string value);
            static /*0x39198ec*/ string TrimStringStart(string value);
            static /*0x3919958*/ string TrimStringEnd(string value);
            static /*0x39199c4*/ string[] SplitString(string value);
            static /*0x3915ebc*/ bool IsNegativeZero(double value);
            static /*0x3919a34*/ long DoubleToInt64Bits(double value);
            static /*0x3919a3c*/ void VerifyCharData(string data, System.Xml.ExceptionType invCharExceptionType, System.Xml.ExceptionType invSurrogateExceptionType);
            static /*0x3919c2c*/ System.Exception CreateException(string res, System.Xml.ExceptionType exceptionType, int lineNo, int linePos);
            static /*0x3919fc8*/ System.Exception CreateException(string res, string arg, System.Xml.ExceptionType exceptionType, int lineNo, int linePos);
            static /*0x391a104*/ System.Exception CreateException(string res, string[] args, System.Xml.ExceptionType exceptionType);
            static /*0x39153b0*/ System.Exception CreateException(string res, string[] args, System.Xml.ExceptionType exceptionType, int lineNo, int linePos);
            static /*0x391a18c*/ System.Exception CreateInvalidSurrogatePairException(char low, char hi);
            static /*0x391a1f4*/ System.Exception CreateInvalidSurrogatePairException(char low, char hi, System.Xml.ExceptionType exceptionType);
            static /*0x3919cec*/ System.Exception CreateInvalidSurrogatePairException(char low, char hi, System.Xml.ExceptionType exceptionType, int lineNo, int linePos);
            static /*0x391a268*/ System.Exception CreateInvalidHighSurrogateCharException(char hi);
            static /*0x391a2c0*/ System.Exception CreateInvalidHighSurrogateCharException(char hi, System.Xml.ExceptionType exceptionType);
            static /*0x391a32c*/ System.Exception CreateInvalidHighSurrogateCharException(char hi, System.Xml.ExceptionType exceptionType, int lineNo, int linePos);
            static /*0x3919e7c*/ System.Exception CreateInvalidCharException(string data, int invCharPos, System.Xml.ExceptionType exceptionType);
            static /*0x391a430*/ System.Exception CreateInvalidCharException(char invChar, char nextChar);
            static /*0x391a498*/ System.Exception CreateInvalidCharException(char invChar, char nextChar, System.Xml.ExceptionType exceptionType);
            static /*0x3915078*/ System.Exception CreateInvalidNameCharException(string name, int index, System.Xml.ExceptionType exceptionType);
            static /*0x391a52c*/ System.ArgumentException CreateInvalidNameArgumentException(string name, string argumentName);
        }

        class XmlDownloadManager
        {
            /*0x10*/ System.Collections.Hashtable connections;

            /*0x391b2fc*/ XmlDownloadManager();
            /*0x391a6e8*/ System.IO.Stream GetStream(System.Uri uri, System.Net.ICredentials credentials, System.Net.IWebProxy proxy, System.Net.Cache.RequestCachePolicy cachePolicy);
            /*0x391a7e8*/ System.IO.Stream GetNonFileStream(System.Uri uri, System.Net.ICredentials credentials, System.Net.IWebProxy proxy, System.Net.Cache.RequestCachePolicy cachePolicy);
            /*0x391ae94*/ void Remove(string host);
            /*0x391b008*/ System.Threading.Tasks.Task<System.IO.Stream> GetStreamAsync(System.Uri uri, System.Net.ICredentials credentials, System.Net.IWebProxy proxy, System.Net.Cache.RequestCachePolicy cachePolicy);
            /*0x391b180*/ System.Threading.Tasks.Task<System.IO.Stream> GetNonFileStreamAsync(System.Uri uri, System.Net.ICredentials credentials, System.Net.IWebProxy proxy, System.Net.Cache.RequestCachePolicy cachePolicy);

            class <>c__DisplayClass4_0
            {
                /*0x10*/ System.Uri uri;

                /*0x391b178*/ <>c__DisplayClass4_0();
                /*0x391b304*/ System.IO.Stream <GetStreamAsync>b__0();
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

                /*0x391b390*/ void MoveNext();
                /*0x391bba8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class OpenedHost
        {
            /*0x10*/ int nonCachedConnectionsCount;

            /*0x391ac78*/ OpenedHost();
        }

        class XmlRegisteredNonCachedStream : System.IO.Stream
        {
            /*0x28*/ System.IO.Stream stream;
            /*0x30*/ System.Xml.XmlDownloadManager downloadManager;
            /*0x38*/ string host;

            /*0x391ac80*/ XmlRegisteredNonCachedStream(System.IO.Stream stream, System.Xml.XmlDownloadManager downloadManager, string host);
            /*0x391bc24*/ void Finalize();
            /*0x391bcc8*/ void Dispose(bool disposing);
            /*0x391be04*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state);
            /*0x391be24*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state);
            /*0x391be44*/ int EndRead(System.IAsyncResult asyncResult);
            /*0x391be64*/ void EndWrite(System.IAsyncResult asyncResult);
            /*0x391be84*/ void Flush();
            /*0x391bea4*/ int Read(byte[] buffer, int offset, int count);
            /*0x391bec4*/ int ReadByte();
            /*0x391bee4*/ long Seek(long offset, System.IO.SeekOrigin origin);
            /*0x391bf04*/ void SetLength(long value);
            /*0x391bf24*/ void Write(byte[] buffer, int offset, int count);
            /*0x391bf44*/ void WriteByte(byte value);
            /*0x391bf64*/ bool get_CanRead();
            /*0x391bf80*/ bool get_CanSeek();
            /*0x391bf9c*/ bool get_CanWrite();
            /*0x391bfb8*/ long get_Length();
            /*0x391bfd4*/ long get_Position();
            /*0x391bff0*/ void set_Position(long value);
        }

        class XmlCachedStream : System.IO.MemoryStream
        {
            /*0x50*/ System.Uri uri;

            /*0x391ad24*/ XmlCachedStream(System.Uri uri, System.IO.Stream stream);
        }

        class UTF16Decoder : System.Text.Decoder
        {
            /*0x20*/ bool bigEndian;
            /*0x24*/ int lastByte;

            /*0x391c010*/ UTF16Decoder(bool bigEndian);
            /*0x391c040*/ int GetCharCount(byte[] bytes, int index, int count);
            /*0x391c050*/ int GetCharCount(byte[] bytes, int index, int count, bool flush);
            /*0x391c12c*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0x391c2a4*/ void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, ref int bytesUsed, ref int charsUsed, ref bool completed);
        }

        class SafeAsciiDecoder : System.Text.Decoder
        {
            /*0x391c474*/ SafeAsciiDecoder();
            /*0x391c47c*/ int GetCharCount(byte[] bytes, int index, int count);
            /*0x391c484*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0x391c4f4*/ void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, ref int bytesUsed, ref int charsUsed, ref bool completed);
        }

        class Ucs4Encoding : System.Text.Encoding
        {
            /*0x38*/ System.Xml.Ucs4Decoder ucs4Decoder;

            static /*0x391c670*/ System.Text.Encoding get_UCS4_Littleendian();
            static /*0x391c728*/ System.Text.Encoding get_UCS4_Bigendian();
            static /*0x391c7e0*/ System.Text.Encoding get_UCS4_2143();
            static /*0x391c898*/ System.Text.Encoding get_UCS4_3412();
            /*0x391c950*/ Ucs4Encoding();
            /*0x391c580*/ string get_WebName();
            /*0x391c58c*/ System.Text.Decoder GetDecoder();
            /*0x391c594*/ int GetByteCount(char[] chars, int index, int count);
            /*0x391c5f8*/ byte[] GetBytes(string s);
            /*0x391c600*/ int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);
            /*0x391c608*/ int GetMaxByteCount(int charCount);
            /*0x391c610*/ int GetCharCount(byte[] bytes, int index, int count);
            /*0x391c62c*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0x391c648*/ int GetMaxCharCount(int byteCount);
            /*0x391c660*/ int get_CodePage();
            /*0x391c668*/ System.Text.Encoder GetEncoder();
        }

        class Ucs4Encoding1234 : System.Xml.Ucs4Encoding
        {
            /*0x391c778*/ Ucs4Encoding1234();
            /*0x391c95c*/ string get_EncodingName();
            /*0x391c99c*/ byte[] GetPreamble();
        }

        class Ucs4Encoding4321 : System.Xml.Ucs4Encoding
        {
            /*0x391c6c0*/ Ucs4Encoding4321();
            /*0x391ca18*/ string get_EncodingName();
            /*0x391ca58*/ byte[] GetPreamble();
        }

        class Ucs4Encoding2143 : System.Xml.Ucs4Encoding
        {
            /*0x391c830*/ Ucs4Encoding2143();
            /*0x391cad0*/ string get_EncodingName();
            /*0x391cb10*/ byte[] GetPreamble();
        }

        class Ucs4Encoding3412 : System.Xml.Ucs4Encoding
        {
            /*0x391c8e8*/ Ucs4Encoding3412();
            /*0x391cb8c*/ string get_EncodingName();
            /*0x391cbcc*/ byte[] GetPreamble();
        }

        class Ucs4Decoder : System.Text.Decoder
        {
            /*0x20*/ byte[] lastBytes;
            /*0x28*/ int lastBytesCount;

            /*0x391d098*/ Ucs4Decoder();
            /*0x391cc40*/ int GetCharCount(byte[] bytes, int index, int count);
            int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0x391cc5c*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0x391ce0c*/ void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, ref int bytesUsed, ref int charsUsed, ref bool completed);
            /*0x391d040*/ void Ucs4ToUTF16(uint code, char[] chars, int charIndex);
        }

        class Ucs4Decoder4321 : System.Xml.Ucs4Decoder
        {
            /*0x391ca14*/ Ucs4Decoder4321();
            /*0x391d0fc*/ int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
        }

        class Ucs4Decoder1234 : System.Xml.Ucs4Decoder
        {
            /*0x391c958*/ Ucs4Decoder1234();
            /*0x391d304*/ int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
        }

        class Ucs4Decoder2143 : System.Xml.Ucs4Decoder
        {
            /*0x391cacc*/ Ucs4Decoder2143();
            /*0x391d50c*/ int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
        }

        class Ucs4Decoder3412 : System.Xml.Ucs4Decoder
        {
            /*0x391cb88*/ Ucs4Decoder3412();
            /*0x391d714*/ int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
        }

        class XmlException : System.SystemException
        {
            /*0x90*/ string res;
            /*0x98*/ string[] args;
            /*0xa0*/ int lineNumber;
            /*0xa4*/ int linePosition;
            /*0xa8*/ string sourceUri;
            /*0xb0*/ string message;

            static /*0x391e27c*/ string FormatUserMessage(string message, int lineNumber, int linePosition);
            static /*0x391dd0c*/ string CreateMessage(string res, string[] args, int lineNumber, int linePosition);
            static /*0x39126a0*/ string[] BuildCharExceptionArgs(string data, int invCharIndex);
            static /*0x391e7bc*/ string[] BuildCharExceptionArgs(char[] data, int length, int invCharIndex);
            static /*0x3912a1c*/ string[] BuildCharExceptionArgs(char invChar, char nextChar);
            /*0x391d91c*/ XmlException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x391e0fc*/ XmlException();
            /*0x391e114*/ XmlException(string message);
            /*0x391e130*/ XmlException(string message, System.Exception innerException);
            /*0x391e128*/ XmlException(string message, System.Exception innerException, int lineNumber, int linePosition);
            /*0x391e140*/ XmlException(string message, System.Exception innerException, int lineNumber, int linePosition, string sourceUri);
            /*0x39126fc*/ XmlException(string res, string[] args);
            /*0x3912520*/ XmlException(string res, string arg);
            /*0x391e408*/ XmlException(string res, string arg, string sourceUri);
            /*0x391e4b4*/ XmlException(string res, string arg, System.Xml.IXmlLineInfo lineInfo);
            /*0x391e6dc*/ XmlException(string res, string[] args, System.Xml.IXmlLineInfo lineInfo);
            /*0x391e558*/ XmlException(string res, string[] args, System.Xml.IXmlLineInfo lineInfo, string sourceUri);
            /*0x3919f18*/ XmlException(string res, string arg, int lineNumber, int linePosition);
            /*0x391e6e4*/ XmlException(string res, string arg, int lineNumber, int linePosition, string sourceUri);
            /*0x391a178*/ XmlException(string res, string[] args, int lineNumber, int linePosition);
            /*0x391e7a0*/ XmlException(string res, string[] args, int lineNumber, int linePosition, string sourceUri);
            /*0x391e7b4*/ XmlException(string res, string[] args, System.Exception innerException, int lineNumber, int linePosition);
            /*0x391e360*/ XmlException(string res, string[] args, System.Exception innerException, int lineNumber, int linePosition, string sourceUri);
            /*0x391df8c*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0x391e810*/ int get_LineNumber();
            /*0x391e818*/ int get_LinePosition();
            /*0x391e820*/ string get_Message();
            /*0x391e838*/ string get_ResString();
        }

        class XmlNameTable
        {
            /*0x391e840*/ XmlNameTable();
            /*0x1f302cc*/ string Get(string array);
            /*0x1f30348*/ string Add(char[] array, int offset, int length);
            /*0x1f302cc*/ string Add(string array);
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

            /*0x391e848*/ XmlNamespaceManager();
            /*0x391e850*/ XmlNamespaceManager(System.Xml.XmlNameTable nameTable);
            /*0x391eaf4*/ System.Xml.XmlNameTable get_NameTable();
            /*0x391eafc*/ string get_DefaultNamespace();
            /*0x391eb3c*/ void PushScope();
            /*0x391eb4c*/ bool PopScope();
            /*0x391ec34*/ void AddNamespace(string prefix, string uri);
            /*0x391f1b4*/ void RemoveNamespace(string prefix, string uri);
            /*0x391f2f4*/ System.Collections.IEnumerator GetEnumerator();
            /*0x391f46c*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x391f628*/ string LookupNamespace(string prefix);
            /*0x391f020*/ int LookupNamespaceDecl(string prefix);
            /*0x391f674*/ string LookupPrefix(string uri);

            struct NamespaceDeclaration
            {
                /*0x10*/ string prefix;
                /*0x18*/ string uri;
                /*0x20*/ int scopeId;
                /*0x24*/ int previousNsIndex;

                /*0x391eaac*/ void Set(string prefix, string uri, int scopeId, int previousNsIndex);
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

            static /*0x392013c*/ XmlQualifiedName();
            static /*0x391fc30*/ bool op_Equality(System.Xml.XmlQualifiedName a, System.Xml.XmlQualifiedName b);
            static /*0x391fbc0*/ bool op_Inequality(System.Xml.XmlQualifiedName a, System.Xml.XmlQualifiedName b);
            static /*0x391fc98*/ string ToString(string name, string ns);
            static /*0x391f8d4*/ System.Xml.XmlQualifiedName.HashCodeOfStringDelegate GetHashCodeDelegate();
            static /*0x391fd08*/ bool IsRandomizedHashingDisabled();
            static /*0x391fdc4*/ int GetHashCodeOfString(string s, int length, long additionalEntropy);
            static /*0x391ff18*/ System.Xml.XmlQualifiedName Parse(string s, System.Xml.IXmlNamespaceResolver nsmgr, ref string prefix);
            /*0x391f738*/ XmlQualifiedName();
            /*0x391f7d0*/ XmlQualifiedName(string name);
            /*0x391f754*/ XmlQualifiedName(string name, string ns);
            /*0x391f7e8*/ string get_Namespace();
            /*0x391f7f0*/ string get_Name();
            /*0x391f7f8*/ int GetHashCode();
            /*0x391fa34*/ bool get_IsEmpty();
            /*0x391fa70*/ string ToString();
            /*0x391fae0*/ bool Equals(object other);
            /*0x391fddc*/ void Init(string name, string ns);
            /*0x391fe14*/ void SetNamespace(string ns);
            /*0x391fe1c*/ void Verify();
            /*0x391feac*/ void Atomize(System.Xml.XmlNameTable nameTable);
            /*0x39200bc*/ System.Xml.XmlQualifiedName Clone();

            class HashCodeOfStringDelegate : System.MulticastDelegate
            {
                /*0x391fd10*/ HashCodeOfStringDelegate(object object, nint method);
                /*0x39201d8*/ int Invoke(string s, int sLen, long additionalEntropy);
            }
        }

        class XmlResolver
        {
            /*0x3920524*/ XmlResolver();
            /*0x1f303d0*/ object GetEntity(System.Uri absoluteUri, string role, System.Type ofObjectToReturn);
            /*0x39201ec*/ System.Uri ResolveUri(System.Uri baseUri, string relativeUri);
            /*0x39203b4*/ bool SupportsType(System.Uri absoluteUri, System.Type type);
            /*0x39204ec*/ System.Threading.Tasks.Task<object> GetEntityAsync(System.Uri absoluteUri, string role, System.Type ofObjectToReturn);
        }

        class XmlUrlResolver : System.Xml.XmlResolver
        {
            static /*0x0*/ object s_DownloadManager;
            /*0x10*/ System.Net.ICredentials _credentials;
            /*0x18*/ System.Net.IWebProxy _proxy;
            /*0x20*/ System.Net.Cache.RequestCachePolicy _cachePolicy;

            static /*0x392052c*/ System.Xml.XmlDownloadManager get_DownloadManager();
            /*0x39205f8*/ XmlUrlResolver();
            /*0x3920600*/ object GetEntity(System.Uri absoluteUri, string role, System.Type ofObjectToReturn);
            /*0x3920750*/ System.Uri ResolveUri(System.Uri baseUri, string relativeUri);
            /*0x3920754*/ System.Threading.Tasks.Task<object> GetEntityAsync(System.Uri absoluteUri, string role, System.Type ofObjectToReturn);

            struct <GetEntityAsync>d__15 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object> <>t__builder;
                /*0x30*/ System.Type ofObjectToReturn;
                /*0x38*/ System.Uri absoluteUri;
                /*0x40*/ System.Xml.XmlUrlResolver <>4__this;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.IO.Stream> <>u__1;

                /*0x392089c*/ void MoveNext();
                /*0x3920c70*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class BinaryCompatibility
        {
            static /*0x3920cec*/ bool get_TargetsAtLeast_Desktop_V4_5_2();
        }

        class Res
        {
            static /*0x3915074*/ string GetString(string name);
            static /*0x3912c90*/ string GetString(string name, object[] args);
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

                /*0x3920cf4*/ System.Xml.XmlNameTable get_NameTable();
                /*0x3920cfc*/ bool get_HasLineInfo();
                /*0x3920d04*/ int GetXmlNamespaceNode(ref MS.Internal.Xml.Cache.XPathNode[] pageXmlNmsp);
                /*0x3920d2c*/ int LookupNamespaces(MS.Internal.Xml.Cache.XPathNode[] pageElem, int idxElem, ref MS.Internal.Xml.Cache.XPathNode[] pageNmsp);
            }

            class XPathException : System.SystemException
            {
                /*0x90*/ string res;
                /*0x98*/ string[] args;
                /*0xa0*/ string message;

                static /*0x39213f4*/ System.Xml.XPath.XPathException Create(string res);
                static /*0x392145c*/ System.Xml.XPath.XPathException Create(string res, string arg);
                static /*0x3921510*/ System.Xml.XPath.XPathException Create(string res, string arg, string arg2);
                static /*0x39210a4*/ string CreateMessage(string res, string[] args);
                /*0x3920e2c*/ XPathException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x39212bc*/ XPathException();
                /*0x39212d8*/ XPathException(string message, System.Exception innerException);
                /*0x3921454*/ XPathException(string res, string[] args);
                /*0x3921380*/ XPathException(string res, string[] args, System.Exception inner);
                /*0x39211d4*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x39215e8*/ string get_Message();
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
                /*0x3921614*/ XPathItem();
                /*0x1f30214*/ System.Xml.Schema.XmlSchemaType get_XmlType();
                /*0x1f30214*/ string get_Value();
                /*0x1f30214*/ object get_TypedValue();
                /*0x1f30214*/ System.Type get_ValueType();
                /*0x1f2fe14*/ bool get_ValueAsBoolean();
                System.DateTime get_ValueAsDateTime();
                double get_ValueAsDouble();
                /*0x1f2ffc8*/ int get_ValueAsInt();
                long get_ValueAsLong();
                /*0x3921600*/ object ValueAs(System.Type returnType);
                /*0x1f30394*/ object ValueAs(System.Type returnType, System.Xml.IXmlNamespaceResolver nsResolver);
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

                static /*0x39233c8*/ XPathNavigator();
                static /*0x39233b0*/ bool IsText(System.Xml.XPath.XPathNodeType type);
                /*0x39233c0*/ XPathNavigator();
                /*0x392161c*/ string ToString();
                /*0x3921628*/ System.Xml.Schema.XmlSchemaType get_XmlType();
                /*0x39217b0*/ object get_TypedValue();
                /*0x3921a84*/ System.Type get_ValueType();
                /*0x3921c68*/ bool get_ValueAsBoolean();
                /*0x3921f24*/ System.DateTime get_ValueAsDateTime();
                /*0x39221e8*/ double get_ValueAsDouble();
                /*0x39224ac*/ int get_ValueAsInt();
                /*0x3922770*/ long get_ValueAsLong();
                /*0x3922a34*/ object ValueAs(System.Type returnType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x3922d18*/ object System.ICloneable.Clone();
                /*0x1f30214*/ System.Xml.XmlNameTable get_NameTable();
                /*0x3922d28*/ string LookupNamespace(string prefix);
                /*0x3922ec0*/ string LookupPrefix(string namespaceURI);
                /*0x39230ac*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
                /*0x1f30214*/ System.Xml.XPath.XPathNavigator Clone();
                /*0x1f2ffc8*/ System.Xml.XPath.XPathNodeType get_NodeType();
                /*0x1f30214*/ string get_LocalName();
                /*0x1f30214*/ string get_NamespaceURI();
                /*0x1f30214*/ string get_Prefix();
                /*0x39232c0*/ object get_UnderlyingObject();
                /*0x39232c8*/ bool MoveToNamespace(string name);
                /*0x1f2fe40*/ bool MoveToFirstNamespace(System.Xml.XPath.XPathNamespaceScope namespaceScope);
                /*0x1f2fe40*/ bool MoveToNextNamespace(System.Xml.XPath.XPathNamespaceScope namespaceScope);
                /*0x1f2fe14*/ bool MoveToParent();
                /*0x1f2fec8*/ bool IsSamePosition(System.Xml.XPath.XPathNavigator other);
                /*0x3923368*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            }

            class XPathNavigatorKeyComparer : System.Collections.IEqualityComparer
            {
                /*0x3923550*/ XPathNavigatorKeyComparer();
                /*0x3923558*/ bool System.Collections.IEqualityComparer.Equals(object obj1, object obj2);
                /*0x3923634*/ int System.Collections.IEqualityComparer.GetHashCode(object obj);
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

                static /*0x3923bc0*/ CodeIdentifier();
                static /*0x3923800*/ string MakePascal(string identifier);
                static /*0x39239ac*/ string MakeValid(string identifier);
                static /*0x3923b80*/ bool IsValidStart(char c);
                static /*0x3923b30*/ bool IsValid(char c);
            }

            class XmlSerializerNamespaces
            {
                /*0x10*/ System.Collections.Hashtable namespaces;

                /*0x3923c3c*/ XmlSerializerNamespaces();
                /*0x3923c44*/ void Add(string prefix, string ns);
                /*0x3923cf8*/ void AddInternal(string prefix, string ns);
                /*0x3923da4*/ System.Xml.XmlQualifiedName[] ToArray();
                /*0x3924288*/ int get_Count();
                /*0x3923e94*/ System.Collections.ArrayList get_NamespaceList();
                /*0x3923d34*/ System.Collections.Hashtable get_Namespaces();
                /*0x39242ac*/ void set_Namespaces(System.Collections.Hashtable value);
            }

            class XmlAttributeEventHandler : System.MulticastDelegate
            {
                /*0x39242b4*/ XmlAttributeEventHandler(object object, nint method);
                /*0x39243c0*/ void Invoke(object sender, System.Xml.Serialization.XmlAttributeEventArgs e);
            }

            class XmlAttributeEventArgs : System.EventArgs
            {
                /*0x10*/ object o;
                /*0x18*/ System.Xml.XmlAttribute attr;
                /*0x20*/ string qnames;
                /*0x28*/ int lineNumber;
                /*0x2c*/ int linePosition;

                /*0x39243d4*/ XmlAttributeEventArgs(System.Xml.XmlAttribute attr, int lineNumber, int linePosition, object o, string qnames);
            }

            class XmlElementEventHandler : System.MulticastDelegate
            {
                /*0x3924490*/ XmlElementEventHandler(object object, nint method);
                /*0x392459c*/ void Invoke(object sender, System.Xml.Serialization.XmlElementEventArgs e);
            }

            class XmlElementEventArgs : System.EventArgs
            {
                /*0x10*/ object o;
                /*0x18*/ System.Xml.XmlElement elem;
                /*0x20*/ string qnames;
                /*0x28*/ int lineNumber;
                /*0x2c*/ int linePosition;

                /*0x39245b0*/ XmlElementEventArgs(System.Xml.XmlElement elem, int lineNumber, int linePosition, object o, string qnames);
            }

            class XmlNodeEventHandler : System.MulticastDelegate
            {
                /*0x392466c*/ XmlNodeEventHandler(object object, nint method);
                /*0x3924778*/ void Invoke(object sender, System.Xml.Serialization.XmlNodeEventArgs e);
            }

            class XmlNodeEventArgs : System.EventArgs
            {
                /*0x10*/ object o;
                /*0x18*/ System.Xml.XmlNode xmlNode;
                /*0x20*/ int lineNumber;
                /*0x24*/ int linePosition;

                /*0x392478c*/ XmlNodeEventArgs(System.Xml.XmlNode xmlNode, int lineNumber, int linePosition, object o);
            }

            class UnreferencedObjectEventHandler : System.MulticastDelegate
            {
                /*0x392482c*/ UnreferencedObjectEventHandler(object object, nint method);
                /*0x3924938*/ void Invoke(object sender, System.Xml.Serialization.UnreferencedObjectEventArgs e);
            }

            class UnreferencedObjectEventArgs : System.EventArgs
            {
                /*0x10*/ object o;
                /*0x18*/ string id;

                /*0x392494c*/ UnreferencedObjectEventArgs(object o, string id);
            }

            interface IXmlSerializable
            {
                /*0x1f30214*/ System.Xml.Schema.XmlSchema GetSchema();
                /*0x1f30ebc*/ void ReadXml(System.Xml.XmlReader reader);
                /*0x1f30ebc*/ void WriteXml(System.Xml.XmlWriter writer);
            }

            interface IXmlTextParser
            {
                /*0x1f2fe14*/ bool get_Normalized();
                /*0x1f30a84*/ void set_Normalized(bool value);
            }

            class KeyHelper
            {
                static /*0x39249d4*/ void AddField(System.Text.StringBuilder sb, int n, string val);
                static /*0x39249dc*/ void AddField(System.Text.StringBuilder sb, int n, string val, string def);
                static /*0x3924ac0*/ void AddField(System.Text.StringBuilder sb, int n, bool val);
                static /*0x3924ac8*/ void AddField(System.Text.StringBuilder sb, int n, bool val, bool def);
                static /*0x3924b18*/ void AddField(System.Text.StringBuilder sb, int n, int val, int def);
                static /*0x3924bd0*/ void AddField(System.Text.StringBuilder sb, int n, System.Type val);
            }

            class ReflectionHelper
            {
                static /*0x0*/ System.Reflection.ParameterModifier[] empty_modifiers;
                /*0x10*/ System.Collections.Hashtable _clrTypes;
                /*0x18*/ System.Collections.Hashtable _schemaTypes;

                static /*0x3925488*/ ReflectionHelper();
                static /*0x39250bc*/ void CheckSerializableType(System.Type type, bool allowPrivateConstructors);
                /*0x39253f8*/ ReflectionHelper();
                /*0x3924cb0*/ void RegisterSchemaType(System.Xml.Serialization.XmlTypeMapping map, string xmlType, string ns);
                /*0x3924d7c*/ System.Xml.Serialization.XmlTypeMapping GetRegisteredSchemaType(string xmlType, string ns);
                /*0x3924e50*/ void RegisterClrType(System.Xml.Serialization.XmlTypeMapping map, System.Type type, string ns);
                /*0x3924f7c*/ System.Xml.Serialization.XmlTypeMapping GetRegisteredClrType(System.Type type, string ns);
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

                /*0x39254fc*/ SerializationSource(string namspace, System.Type[] includedTypes);
                /*0x3925548*/ bool BaseEquals(System.Xml.Serialization.SerializationSource other);
            }

            class XmlTypeSerializationSource : System.Xml.Serialization.SerializationSource
            {
                /*0x28*/ string attributeOverridesHash;
                /*0x30*/ System.Type type;
                /*0x38*/ string rootHash;

                /*0x3925630*/ XmlTypeSerializationSource(System.Type type, System.Xml.Serialization.XmlRootAttribute root, System.Xml.Serialization.XmlAttributeOverrides attributeOverrides, string namspace, System.Type[] includedTypes);
                /*0x392574c*/ bool Equals(object o);
                /*0x3925824*/ int GetHashCode();
            }

            class XmlTypeConvertorAttribute : System.Attribute
            {
                /*0x10*/ string <Method>k__BackingField;

                /*0x3925850*/ XmlTypeConvertorAttribute(string method);
                /*0x3925840*/ string get_Method();
                /*0x3925848*/ void set_Method(string value);
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

                static /*0x3926cb0*/ TypeData();
                static /*0x3926a90*/ System.Reflection.PropertyInfo GetIndexerProperty(System.Type collectionType);
                static /*0x3926b94*/ System.InvalidOperationException CreateMissingAddMethodException(System.Type type, string inheritFrom, System.Type argumentType);
                static /*0x39268a8*/ System.Type GetGenericListItemType(System.Type type);
                /*0x3925880*/ TypeData(System.Type type, string elementName, bool isPrimitive);
                /*0x392588c*/ TypeData(System.Type type, string elementName, bool isPrimitive, System.Xml.Serialization.TypeData mappedType, System.Xml.Schema.XmlSchemaPatternFacet facet);
                /*0x3925e28*/ void LookupTypeConvertor();
                /*0x3925edc*/ void ConvertForAssignment(ref object value);
                /*0x3925fd0*/ string get_TypeName();
                /*0x3925fd8*/ string get_XmlType();
                /*0x3925fe0*/ System.Type get_Type();
                /*0x3925fe8*/ string get_FullTypeName();
                /*0x3925ff0*/ System.Xml.Serialization.SchemaTypes get_SchemaType();
                /*0x39253e8*/ bool get_IsListType();
                /*0x3925ff8*/ bool get_IsComplexType();
                /*0x3926030*/ bool get_IsValueType();
                /*0x39260a4*/ bool get_IsNullable();
                /*0x39261ac*/ void set_IsNullable(bool value);
                /*0x3925c6c*/ System.Xml.Serialization.TypeData get_ListItemTypeData();
                /*0x39261b4*/ System.Type get_ListItemType();
                /*0x3926020*/ bool get_IsXsdType();
                /*0x3926ca8*/ bool get_HasPublicConstructor();
            }

            class TypeMember
            {
                /*0x10*/ System.Type type;
                /*0x18*/ string member;

                static /*0x3927d9c*/ bool Equals(System.Xml.Serialization.TypeMember tm1, System.Xml.Serialization.TypeMember tm2);
                /*0x3927ca0*/ TypeMember(System.Type type, string member);
                /*0x3927ce4*/ int GetHashCode();
                /*0x3927d2c*/ bool Equals(object obj);
                /*0x3927e30*/ string ToString();
            }

            class TypeTranslator
            {
                static /*0x0*/ System.Collections.Hashtable nameCache;
                static /*0x8*/ System.Collections.Hashtable primitiveTypes;
                static /*0x10*/ System.Collections.Hashtable primitiveArrayTypes;
                static /*0x18*/ System.Collections.Hashtable nullableTypes;

                static /*0x3927e94*/ TypeTranslator();
                static /*0x392538c*/ System.Xml.Serialization.TypeData GetTypeData(System.Type type);
                static /*0x392a230*/ System.Xml.Serialization.TypeData GetTypeData(System.Type runtimeType, string xmlDataType, bool underlyingEnumType);
                static /*0x392ab38*/ System.Xml.Serialization.TypeData GetPrimitiveTypeData(string typeName);
                static /*0x392ab90*/ System.Xml.Serialization.TypeData GetPrimitiveTypeData(string typeName, bool nullable);
                static /*0x392ad90*/ System.Xml.Serialization.TypeData FindPrimitiveTypeData(string typeName);
                static /*0x3925d24*/ string GetArrayName(string elemName);
                static /*0x392ae50*/ void ParseArrayType(string arrayType, ref string type, ref string ns, ref string dimensions);
            }

            class XmlAnyAttributeAttribute : System.Attribute
            {
                /*0x392afdc*/ XmlAnyAttributeAttribute();
            }

            class XmlAnyElementAttribute : System.Attribute
            {
                /*0x10*/ string elementName;
                /*0x18*/ string ns;
                /*0x20*/ int order;

                /*0x392afe4*/ XmlAnyElementAttribute();
                /*0x392aff4*/ string get_Name();
                /*0x392b018*/ string get_Namespace();
                /*0x392b020*/ int get_Order();
                /*0x392b028*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlAnyElementAttributes : System.Collections.CollectionBase
            {
                /*0x392b5d8*/ XmlAnyElementAttributes();
                /*0x392b0b8*/ System.Xml.Serialization.XmlAnyElementAttribute get_Item(int index);
                /*0x392b1b8*/ int Add(System.Xml.Serialization.XmlAnyElementAttribute attribute);
                /*0x392b270*/ void AddKeyHash(System.Text.StringBuilder sb);
                /*0x392b33c*/ int get_Order();
            }

            class XmlArrayAttribute : System.Attribute
            {
                /*0x10*/ string elementName;
                /*0x18*/ System.Xml.Schema.XmlSchemaForm form;
                /*0x1c*/ bool isNullable;
                /*0x20*/ string ns;
                /*0x28*/ int order;

                /*0x392b5e0*/ string get_ElementName();
                /*0x392b604*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0x392b60c*/ bool get_IsNullable();
                /*0x392b614*/ string get_Namespace();
                /*0x392b61c*/ int get_Order();
                /*0x392b624*/ void AddKeyHash(System.Text.StringBuilder sb);
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

                /*0x392b744*/ string get_DataType();
                /*0x392b768*/ string get_ElementName();
                /*0x392b78c*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0x392b794*/ string get_Namespace();
                /*0x392b79c*/ bool get_IsNullable();
                /*0x392b7a4*/ bool get_IsNullableSpecified();
                /*0x392b7ac*/ System.Type get_Type();
                /*0x392b7b4*/ int get_NestingLevel();
                /*0x392b7bc*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlArrayItemAttributes : System.Collections.CollectionBase
            {
                /*0x392bba4*/ XmlArrayItemAttributes();
                /*0x392b920*/ System.Xml.Serialization.XmlArrayItemAttribute get_Item(int index);
                /*0x392ba20*/ int Add(System.Xml.Serialization.XmlArrayItemAttribute attribute);
                /*0x392bad8*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlAttributeAttribute : System.Attribute
            {
                /*0x10*/ string attributeName;
                /*0x18*/ string dataType;
                /*0x20*/ System.Type type;
                /*0x28*/ System.Xml.Schema.XmlSchemaForm form;
                /*0x30*/ string ns;

                /*0x392bbac*/ XmlAttributeAttribute(string attributeName);
                /*0x392bbdc*/ string get_AttributeName();
                /*0x392bc00*/ string get_DataType();
                /*0x392bc24*/ void set_DataType(string value);
                /*0x392bc2c*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0x392bc34*/ string get_Namespace();
                /*0x392bc3c*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlAttributeOverrides
            {
                /*0x10*/ System.Collections.Hashtable overrides;

                /*0x392bd70*/ XmlAttributeOverrides();
                /*0x392bddc*/ System.Xml.Serialization.XmlAttributes get_Item(System.Type type);
                /*0x392bdf4*/ System.Xml.Serialization.XmlAttributes get_Item(System.Type type, string member);
                /*0x392bea8*/ System.Xml.Serialization.TypeMember GetKey(System.Type type, string member);
                /*0x392bf14*/ void AddKeyHash(System.Text.StringBuilder sb);
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

                /*0x392c63c*/ XmlAttributes();
                /*0x392c764*/ XmlAttributes(System.Reflection.ICustomAttributeProvider provider);
                /*0x392d02c*/ System.Xml.Serialization.XmlAnyAttributeAttribute get_XmlAnyAttribute();
                /*0x392d034*/ System.Xml.Serialization.XmlAnyElementAttributes get_XmlAnyElements();
                /*0x392d03c*/ System.Xml.Serialization.XmlArrayAttribute get_XmlArray();
                /*0x392d044*/ System.Xml.Serialization.XmlArrayItemAttributes get_XmlArrayItems();
                /*0x392d04c*/ System.Xml.Serialization.XmlAttributeAttribute get_XmlAttribute();
                /*0x392d054*/ System.Xml.Serialization.XmlChoiceIdentifierAttribute get_XmlChoiceIdentifier();
                /*0x392d05c*/ object get_XmlDefaultValue();
                /*0x392d064*/ System.Xml.Serialization.XmlElementAttributes get_XmlElements();
                /*0x392d06c*/ bool get_XmlIgnore();
                /*0x392d074*/ bool get_Xmlns();
                /*0x392d07c*/ System.Xml.Serialization.XmlRootAttribute get_XmlRoot();
                /*0x392d084*/ System.Xml.Serialization.XmlTextAttribute get_XmlText();
                /*0x392d08c*/ System.Xml.Serialization.XmlTypeAttribute get_XmlType();
                /*0x392c3cc*/ void AddKeyHash(System.Text.StringBuilder sb);
                /*0x392df4c*/ System.Nullable<int> get_Order();
                /*0x392e2b4*/ int get_SortableOrder();
            }

            class XmlChoiceIdentifierAttribute : System.Attribute
            {
                /*0x10*/ string memberName;

                /*0x392e380*/ string get_MemberName();
                /*0x392ded0*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlCustomFormatter
            {
                static /*0x0*/ string[] allTimeFormats;

                static /*0x392f1cc*/ XmlCustomFormatter();
                static /*0x392e3a4*/ string FromEnum(long value, string[] values, long[] ids, string typeName);
                static /*0x392e618*/ string FromXmlName(string name);
                static /*0x392e670*/ string FromXmlNCName(string ncName);
                static /*0x392d160*/ string ToXmlString(System.Xml.Serialization.TypeData type, object value);
                static /*0x392e6c8*/ object FromXmlString(System.Xml.Serialization.TypeData type, string value);
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

                /*0x392f728*/ XmlElementAttribute(string elementName);
                /*0x392f760*/ XmlElementAttribute(string elementName, System.Type type);
                /*0x392f7ac*/ string get_DataType();
                /*0x392f7d0*/ string get_ElementName();
                /*0x392f7f4*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0x392f7fc*/ string get_Namespace();
                /*0x392f804*/ bool get_IsNullable();
                /*0x392f80c*/ int get_Order();
                /*0x392f814*/ System.Type get_Type();
                /*0x392f81c*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlElementAttributes : System.Collections.CollectionBase
            {
                /*0x392c75c*/ XmlElementAttributes();
                /*0x392f964*/ System.Xml.Serialization.XmlElementAttribute get_Item(int index);
                /*0x392cf74*/ int Add(System.Xml.Serialization.XmlElementAttribute attribute);
                /*0x392d094*/ void AddKeyHash(System.Text.StringBuilder sb);
                /*0x392e018*/ int get_Order();
            }

            class XmlEnumAttribute : System.Attribute
            {
                /*0x10*/ string name;

                /*0x392fa64*/ XmlEnumAttribute(string name);
                /*0x392fa94*/ string get_Name();
                /*0x392dd9c*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlIgnoreAttribute : System.Attribute
            {
                /*0x392fa9c*/ XmlIgnoreAttribute();
            }

            class XmlIncludeAttribute : System.Attribute
            {
                /*0x10*/ System.Type type;

                /*0x392faa4*/ System.Type get_Type();
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

                /*0x392faac*/ XmlMapping(string elementName, string ns);
                /*0x392faf0*/ string get_ElementName();
                /*0x392faf8*/ string get_Namespace();
                /*0x392fb00*/ void SetKey(string key);
                /*0x392fb08*/ System.Xml.Serialization.ObjectMap get_ObjectMap();
                /*0x392fb10*/ void set_ObjectMap(System.Xml.Serialization.ObjectMap value);
                /*0x392fb18*/ System.Collections.ArrayList get_RelatedMaps();
                /*0x392fb20*/ void set_RelatedMaps(System.Collections.ArrayList value);
                /*0x392fb28*/ System.Xml.Serialization.SerializationFormat get_Format();
                /*0x392fb30*/ void set_Format(System.Xml.Serialization.SerializationFormat value);
                /*0x392fb38*/ System.Xml.Serialization.SerializationSource get_Source();
            }

            class ObjectMap
            {
                /*0x392fb40*/ ObjectMap();
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

                /*0x392fb48*/ int get_Count();
                /*0x392fb60*/ bool get_HasWrapperElement();
            }

            class XmlNamespaceDeclarationsAttribute : System.Attribute
            {
                /*0x392fb68*/ XmlNamespaceDeclarationsAttribute();
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

                static /*0x39369b4*/ XmlReflectionImporter();
                /*0x392fb70*/ XmlReflectionImporter(System.Xml.Serialization.XmlAttributeOverrides attributeOverrides, string defaultNamespace);
                /*0x392fca0*/ System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Type type);
                /*0x392fe60*/ System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Type type, string defaultNamespace);
                /*0x392fcac*/ System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Type type, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0x392fe6c*/ System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0x3932b60*/ System.Xml.Serialization.XmlTypeMapping CreateTypeMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultXmlType, string defaultNamespace);
                /*0x3932fe0*/ System.Xml.Serialization.XmlTypeMapping ImportClassMapping(System.Type type, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace, bool isBaseType);
                /*0x39302e8*/ System.Xml.Serialization.XmlTypeMapping ImportClassMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace, bool isBaseType);
                /*0x3934844*/ void RegisterDerivedMap(System.Xml.Serialization.XmlTypeMapping map, System.Xml.Serialization.XmlTypeMapping derivedMap);
                /*0x3933070*/ string GetTypeNamespace(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0x3934a4c*/ System.Xml.Serialization.XmlTypeMapping ImportListMapping(System.Type type, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace, System.Xml.Serialization.XmlAttributes atts, int nestingLevel);
                /*0x3931514*/ System.Xml.Serialization.XmlTypeMapping ImportListMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace, System.Xml.Serialization.XmlAttributes atts, int nestingLevel);
                /*0x3932214*/ System.Xml.Serialization.XmlTypeMapping ImportXmlNodeMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0x39323b0*/ System.Xml.Serialization.XmlTypeMapping ImportPrimitiveMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0x3932464*/ System.Xml.Serialization.XmlTypeMapping ImportEnumMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0x3932a4c*/ System.Xml.Serialization.XmlTypeMapping ImportXmlSerializableMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0x3934928*/ void ImportIncludedTypes(System.Type type, string defaultNamespace);
                /*0x3933190*/ System.Collections.Generic.List<System.Xml.Serialization.XmlReflectionMember> GetReflectionMembers(System.Type type);
                /*0x3933e70*/ System.Xml.Serialization.XmlTypeMapMember CreateMapMember(System.Type declaringType, System.Xml.Serialization.XmlReflectionMember rmember, string defaultNamespace);
                /*0x3935148*/ System.Xml.Serialization.XmlTypeMapElementInfoList ImportElementInfo(System.Type cls, string defaultName, string defaultNamespace, System.Type defaultType, System.Xml.Serialization.XmlTypeMapMemberElement member, System.Xml.Serialization.XmlAttributes atts);
                /*0x3934b4c*/ System.Xml.Serialization.XmlTypeMapElementInfoList ImportAnyElementInfo(string defaultNamespace, System.Xml.Serialization.XmlReflectionMember rmember, System.Xml.Serialization.XmlTypeMapMemberElement member, System.Xml.Serialization.XmlAttributes atts);
                /*0x39361d0*/ void ImportTextElementInfo(System.Xml.Serialization.XmlTypeMapElementInfoList list, System.Type defaultType, System.Xml.Serialization.XmlTypeMapMemberElement member, System.Xml.Serialization.XmlAttributes atts, string defaultNamespace);
                /*0x3932f7c*/ bool CanBeNull(System.Xml.Serialization.TypeData type);
                /*0x3936510*/ void IncludeType(System.Type type);
                /*0x3936010*/ object GetDefaultValue(System.Xml.Serialization.TypeData typeData, object defaultValue);

                class <>c
                {
                    static /*0x0*/ System.Xml.Serialization.XmlReflectionImporter.<> <>9;
                    static /*0x8*/ System.Comparison<System.Xml.Serialization.XmlReflectionMember> <>9__28_0;

                    static /*0x3936a4c*/ <>c();
                    /*0x3936ab4*/ <>c();
                    /*0x3936abc*/ int <ImportClassMapping>b__28_0(System.Xml.Serialization.XmlReflectionMember m1, System.Xml.Serialization.XmlReflectionMember m2);
                }
            }

            class XmlReflectionMember
            {
                /*0x10*/ bool isReturnValue;
                /*0x18*/ string memberName;
                /*0x20*/ System.Type memberType;
                /*0x28*/ System.Xml.Serialization.XmlAttributes xmlAttributes;
                /*0x30*/ System.Type declaringType;

                /*0x3934aec*/ XmlReflectionMember(string name, System.Type type, System.Xml.Serialization.XmlAttributes attributes);
                /*0x3936b08*/ bool get_IsReturnValue();
                /*0x3936b10*/ string get_MemberName();
                /*0x3936b18*/ System.Type get_MemberType();
                /*0x3933e04*/ System.Xml.Serialization.XmlAttributes get_XmlAttributes();
                /*0x3936b20*/ System.Type get_DeclaringType();
                /*0x3936b28*/ void set_DeclaringType(System.Type value);
            }

            class XmlRootAttribute : System.Attribute
            {
                /*0x10*/ string dataType;
                /*0x18*/ string elementName;
                /*0x20*/ bool isNullable;
                /*0x28*/ string ns;

                /*0x3936b30*/ XmlRootAttribute();
                /*0x3936b40*/ XmlRootAttribute(string elementName);
                /*0x3936b78*/ string get_DataType();
                /*0x3936b9c*/ void set_DataType(string value);
                /*0x3932fbc*/ string get_ElementName();
                /*0x3936ba4*/ void set_ElementName(string value);
                /*0x3936bac*/ bool get_IsNullable();
                /*0x3936bb4*/ void set_IsNullable(bool value);
                /*0x3936bbc*/ string get_Namespace();
                /*0x3936bc4*/ void set_Namespace(string value);
                /*0x392de18*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlSchemaProviderAttribute : System.Attribute
            {
                /*0x10*/ string _methodName;
                /*0x18*/ bool _isAny;

                /*0x3936bcc*/ XmlSchemaProviderAttribute(string methodName);
                /*0x3936bfc*/ string get_MethodName();
                /*0x3936c04*/ bool get_IsAny();
                /*0x3936c0c*/ void set_IsAny(bool value);
            }

            class XmlSerializationCollectionFixupCallback : System.MulticastDelegate
            {
                /*0x3936c14*/ XmlSerializationCollectionFixupCallback(object object, nint method);
                /*0x3936d20*/ void Invoke(object collection, object collectionItems);
            }

            class XmlSerializationFixupCallback : System.MulticastDelegate
            {
                /*0x3936d34*/ XmlSerializationFixupCallback(object object, nint method);
                /*0x3936e3c*/ void Invoke(object fixup);
            }

            class XmlSerializationGeneratedCode
            {
                /*0x3936e50*/ XmlSerializationGeneratedCode();
            }

            class XmlSerializationReadCallback : System.MulticastDelegate
            {
                /*0x3936e58*/ XmlSerializationReadCallback(object object, nint method);
                /*0x3936ef4*/ object Invoke();
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

                /*0x3937380*/ XmlSerializationReader();
                /*0x3936f08*/ void Initialize(System.Xml.XmlReader reader, System.Xml.Serialization.XmlSerializer eventSource);
                /*0x39372c8*/ System.Collections.ArrayList EnsureArrayList(System.Collections.ArrayList list);
                /*0x3937324*/ System.Collections.Hashtable EnsureHashtable(System.Collections.Hashtable hash);
                /*0x3937388*/ System.Xml.XmlDocument get_Document();
                /*0x3937424*/ System.Xml.XmlReader get_Reader();
                /*0x393742c*/ void AddFixup(System.Xml.Serialization.XmlSerializationReader.CollectionFixup fixup);
                /*0x3937500*/ void AddFixup(System.Xml.Serialization.XmlSerializationReader.Fixup fixup);
                /*0x3937554*/ void AddFixup(System.Xml.Serialization.XmlSerializationReader.CollectionItemFixup fixup);
                /*0x39375a8*/ void AddReadCallback(string name, string ns, System.Type type, System.Xml.Serialization.XmlSerializationReadCallback read);
                /*0x39376d4*/ void AddTarget(string id, object o);
                /*0x393779c*/ string CurrentTag();
                /*0x3937910*/ System.Exception CreateReadOnlyCollectionException(string name);
                /*0x39379a0*/ System.Exception CreateUnknownConstantException(string value, System.Type enumType);
                /*0x3937a38*/ System.Exception CreateUnknownNodeException();
                /*0x3937acc*/ System.Exception CreateUnknownTypeException(System.Xml.XmlQualifiedName type);
                /*0x3937c74*/ System.Array EnsureArrayIndex(System.Array a, int index, System.Type elementType);
                /*0x3937d00*/ bool GetNullAttr();
                /*0x3937db0*/ object GetTarget(string id);
                /*0x3937e74*/ bool TargetReady(string id);
                /*0x3937e90*/ System.Xml.XmlQualifiedName GetXsiType();
                /*0x1f309e4*/ void InitCallbacks();
                /*0x1f309e4*/ void InitIDs();
                /*0x3938094*/ bool IsXmlnsAttribute(string name);
                /*0x3938134*/ void ParseWsdlArrayType(System.Xml.XmlAttribute attr);
                /*0x39382b8*/ System.Xml.XmlQualifiedName ReadElementQualifiedName();
                /*0x39385ac*/ void ReadEndElement();
                /*0x3938654*/ bool ReadNull();
                /*0x3938758*/ System.Xml.XmlQualifiedName ReadNullableQualifiedName();
                /*0x3938780*/ string ReadNullableString();
                /*0x39387c8*/ object ReadReferencedElement();
                /*0x3938aec*/ System.Xml.Serialization.XmlSerializationReader.WriteCallbackInfo GetCallbackInfo(System.Xml.XmlQualifiedName qname);
                /*0x3938820*/ object ReadReferencedElement(string name, string ns);
                /*0x3938be0*/ bool ReadList(ref object resultList);
                /*0x3939a34*/ void ReadReferencedElements();
                /*0x393a820*/ object ReadReferencingElement(ref string fixupReference);
                /*0x39399d4*/ object ReadReferencingElement(string name, string ns, ref string fixupReference);
                /*0x393a884*/ object ReadReferencingElement(string name, string ns, bool elementCanBeType, ref string fixupReference);
                /*0x393abf8*/ System.Xml.Serialization.IXmlSerializable ReadSerializable(System.Xml.Serialization.IXmlSerializable serializable);
                /*0x393ad8c*/ object ReadTypedPrimitive(System.Xml.XmlQualifiedName type);
                /*0x39390b4*/ object ReadTypedPrimitive(System.Xml.XmlQualifiedName qname, bool reportUnknown);
                /*0x393b00c*/ System.Xml.XmlNode ReadXmlNode(bool wrapped);
                /*0x393b074*/ System.Xml.XmlDocument ReadXmlDocument(bool wrapped);
                /*0x393b190*/ System.Array ShrinkArray(System.Array a, int length, System.Type elementType, bool isNullable);
                /*0x393838c*/ System.Xml.XmlQualifiedName ToXmlQualifiedName(string value);
                /*0x393b220*/ void UnknownAttribute(object o, System.Xml.XmlAttribute attr, string qnames);
                /*0x393b37c*/ void UnknownElement(object o, System.Xml.XmlElement elem, string qnames);
                /*0x3938724*/ void UnknownNode(object o);
                /*0x393b4d8*/ void UnknownNode(object o, string qnames);
                /*0x393ad94*/ void OnUnknownNode(System.Xml.XmlNode node, object o, string qnames);
                /*0x393a78c*/ void UnreferencedObject(string id, object o);

                class WriteCallbackInfo
                {
                    /*0x10*/ System.Type Type;
                    /*0x18*/ string TypeName;
                    /*0x20*/ string TypeNs;
                    /*0x28*/ System.Xml.Serialization.XmlSerializationReadCallback Callback;

                    /*0x39376cc*/ WriteCallbackInfo();
                }

                class CollectionFixup
                {
                    /*0x10*/ System.Xml.Serialization.XmlSerializationCollectionFixupCallback callback;
                    /*0x18*/ object collection;
                    /*0x20*/ object collectionItems;
                    /*0x28*/ string id;

                    /*0x393b510*/ CollectionFixup(object collection, System.Xml.Serialization.XmlSerializationCollectionFixupCallback callback, string id);
                    /*0x393b570*/ System.Xml.Serialization.XmlSerializationCollectionFixupCallback get_Callback();
                    /*0x393b578*/ object get_Collection();
                    /*0x393b580*/ object get_Id();
                    /*0x393b588*/ object get_CollectionItems();
                    /*0x393b590*/ void set_CollectionItems(object value);
                }

                class Fixup
                {
                    /*0x10*/ object source;
                    /*0x18*/ string[] ids;
                    /*0x20*/ System.Xml.Serialization.XmlSerializationFixupCallback callback;

                    /*0x393b598*/ Fixup(object o, System.Xml.Serialization.XmlSerializationFixupCallback callback, int count);
                    /*0x393b638*/ System.Xml.Serialization.XmlSerializationFixupCallback get_Callback();
                    /*0x393b640*/ string[] get_Ids();
                    /*0x393b648*/ object get_Source();
                }

                class CollectionItemFixup
                {
                    /*0x10*/ System.Array list;
                    /*0x18*/ int index;
                    /*0x20*/ string id;

                    /*0x39399e0*/ CollectionItemFixup(System.Array list, int index, string id);
                    /*0x393b650*/ System.Array get_Collection();
                    /*0x393b658*/ int get_Index();
                    /*0x393b660*/ string get_Id();
                }
            }

            class XmlSerializationReaderInterpreter : System.Xml.Serialization.XmlSerializationReader
            {
                static /*0x0*/ System.Xml.XmlQualifiedName AnyType;
                static /*0x8*/ object[] empty_array;
                /*0xd0*/ System.Xml.Serialization.XmlMapping _typeMap;
                /*0xd8*/ System.Xml.Serialization.SerializationFormat _format;

                static /*0x3940b38*/ XmlSerializationReaderInterpreter();
                static /*0x393f1bc*/ object CreateInstance(System.Type type, bool nonPublic);
                /*0x393b668*/ XmlSerializationReaderInterpreter(System.Xml.Serialization.XmlMapping typeMap);
                /*0x393b6ac*/ void InitCallbacks();
                /*0x393ba7c*/ void InitIDs();
                /*0x393ba80*/ object ReadRoot();
                /*0x393bc60*/ object ReadEncodedObject(System.Xml.Serialization.XmlTypeMapping typeMap);
                /*0x393bd64*/ object ReadMessage(System.Xml.Serialization.XmlMembersMapping typeMap);
                /*0x393bb88*/ object ReadRoot(System.Xml.Serialization.XmlTypeMapping rootMap);
                /*0x393e7b8*/ object ReadObject(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable, bool checkType);
                /*0x393ef08*/ object ReadClassInstance(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable, bool checkType);
                /*0x393f1c4*/ void ReadClassInstanceMembers(System.Xml.Serialization.XmlTypeMapping typeMap, object ob);
                /*0x393c2f4*/ void ReadAttributeMembers(System.Xml.Serialization.ClassMap map, object ob, bool isValueList);
                /*0x393c6e8*/ void ReadMembers(System.Xml.Serialization.ClassMap map, object ob, bool isValueList, bool readBySoapOrder);
                /*0x393f8fc*/ void SetListMembersDefaults(System.Xml.Serialization.ClassMap map, object ob, bool isValueList);
                /*0x393fe80*/ void FixupMembers(System.Xml.Serialization.ClassMap map, object obfixup, bool isValueList);
                /*0x3940248*/ void ProcessUnknownAttribute(object target);
                /*0x394027c*/ void ProcessUnknownElement(object target);
                /*0x393fa40*/ bool IsReadOnly(System.Xml.Serialization.XmlTypeMapMember member, System.Xml.Serialization.TypeData memType, object ob, bool isValueList);
                /*0x393f394*/ void SetMemberValue(System.Xml.Serialization.XmlTypeMapMember member, object ob, object value, bool isValueList);
                /*0x393c254*/ void SetMemberValueFromAttr(System.Xml.Serialization.XmlTypeMapMember member, object ob, object value, bool isValueList);
                /*0x393f528*/ object GetMemberValue(System.Xml.Serialization.XmlTypeMapMember member, object ob, bool isValueList);
                /*0x393fc24*/ object ReadObjectElement(System.Xml.Serialization.XmlTypeMapElementInfo elem);
                /*0x39402b0*/ object ReadPrimitiveValue(System.Xml.Serialization.XmlTypeMapElementInfo elem);
                /*0x393f26c*/ object GetValueFromXmlString(string value, System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlTypeMapping typeMap);
                /*0x393e8b0*/ object ReadListElement(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable, object list, bool canCreateInstance);
                /*0x39403bc*/ object ReadListString(System.Xml.Serialization.XmlTypeMapping typeMap, string values);
                /*0x393f5f8*/ void AddListValue(System.Xml.Serialization.TypeData listType, ref object list, int index, object value, bool canCreateInstance);
                /*0x393c1f0*/ object CreateInstance(System.Type type);
                /*0x393fb88*/ object CreateList(System.Type listType);
                /*0x393faa4*/ object InitializeList(System.Xml.Serialization.TypeData listType);
                /*0x3940718*/ void FillList(object list, object items);
                /*0x3940728*/ void CopyEnumerableList(object source, object dest);
                /*0x393e7a0*/ object ReadXmlNodeElement(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable);
                /*0x393fdcc*/ object ReadXmlNode(System.Xml.Serialization.TypeData type, bool wrapped);
                /*0x393ec50*/ object ReadPrimitiveElement(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable);
                /*0x393ed08*/ object ReadEnumElement(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable);
                /*0x39405e0*/ object GetEnumValue(System.Xml.Serialization.XmlTypeMapping typeMap, string val);
                /*0x393ed74*/ object ReadXmlSerializableElement(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable);

                class FixupCallbackInfo
                {
                    /*0x10*/ System.Xml.Serialization.XmlSerializationReaderInterpreter _sri;
                    /*0x18*/ System.Xml.Serialization.ClassMap _map;
                    /*0x20*/ bool _isValueList;

                    /*0x393fb30*/ FixupCallbackInfo(System.Xml.Serialization.XmlSerializationReaderInterpreter sri, System.Xml.Serialization.ClassMap map, bool isValueList);
                    /*0x3940c2c*/ void FixupMembers(object fixup);
                }

                class ReaderCallbackInfo
                {
                    /*0x10*/ System.Xml.Serialization.XmlSerializationReaderInterpreter _sri;
                    /*0x18*/ System.Xml.Serialization.XmlTypeMapping _typeMap;

                    /*0x393ba38*/ ReaderCallbackInfo(System.Xml.Serialization.XmlSerializationReaderInterpreter sri, System.Xml.Serialization.XmlTypeMapping typeMap);
                    /*0x3940c50*/ object ReadObject();
                }
            }

            class XmlSerializationWriteCallback : System.MulticastDelegate
            {
                /*0x3940c7c*/ XmlSerializationWriteCallback(object object, nint method);
                /*0x3940d84*/ void Invoke(object o);
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

                /*0x3940d98*/ XmlSerializationWriter();
                /*0x3940e08*/ void Initialize(System.Xml.XmlWriter writer, System.Xml.Serialization.XmlSerializerNamespaces nss);
                /*0x3940f38*/ System.Xml.XmlWriter get_Writer();
                /*0x3940f40*/ void AddWriteCallback(System.Type type, string typeName, string typeNs, System.Xml.Serialization.XmlSerializationWriteCallback callback);
                /*0x3941058*/ System.Exception CreateUnknownAnyElementException(string name, string ns);
                /*0x39410f0*/ System.Exception CreateUnknownTypeException(object o);
                /*0x3941114*/ System.Exception CreateUnknownTypeException(System.Type type);
                /*0x39411a4*/ string FromXmlQualifiedName(System.Xml.XmlQualifiedName xmlQualifiedName);
                /*0x3941324*/ string GetId(object o, bool addToReferencesList);
                /*0x3941438*/ bool AlreadyQueued(object ob);
                /*0x394146c*/ string GetNamespacePrefix(string ns);
                /*0x3941264*/ string GetQualifiedName(string name, string ns);
                /*0x1f309e4*/ void InitCallbacks();
                /*0x394159c*/ void TopLevelElement();
                /*0x39415a8*/ void WriteAttribute(string localName, string ns, string value);
                /*0x394157c*/ void WriteAttribute(string prefix, string localName, string ns, string value);
                /*0x39415bc*/ void WriteXmlNode(System.Xml.XmlNode node);
                /*0x394165c*/ void WriteElementEncoded(System.Xml.XmlNode node, string name, string ns, bool isNullable, bool any);
                /*0x3941810*/ void WriteElementLiteral(System.Xml.XmlNode node, string name, string ns, bool isNullable, bool any);
                /*0x39419c8*/ void WriteElementQualifiedName(string localName, string ns, System.Xml.XmlQualifiedName value);
                /*0x39419d0*/ void WriteElementQualifiedName(string localName, string ns, System.Xml.XmlQualifiedName value, System.Xml.XmlQualifiedName xsiType);
                /*0x3941bcc*/ void WriteElementString(string localName, string ns, string value);
                /*0x3941bd4*/ void WriteElementString(string localName, string ns, string value, System.Xml.XmlQualifiedName xsiType);
                /*0x3941bb0*/ void WriteEndElement();
                /*0x3941d24*/ void WriteEndElement(object o);
                /*0x3941d64*/ void WriteNamespaceDeclarations(System.Xml.Serialization.XmlSerializerNamespaces xmlns);
                /*0x3942150*/ void WriteNullableQualifiedNameEncoded(string name, string ns, System.Xml.XmlQualifiedName value, System.Xml.XmlQualifiedName xsiType);
                /*0x3942208*/ void WriteNullableQualifiedNameLiteral(string name, string ns, System.Xml.XmlQualifiedName value);
                /*0x39422bc*/ void WriteNullableStringEncoded(string name, string ns, string value, System.Xml.XmlQualifiedName xsiType);
                /*0x39422c8*/ void WriteNullableStringLiteral(string name, string ns, string value);
                /*0x3941750*/ void WriteNullTagEncoded(string name, string ns);
                /*0x3941904*/ void WriteNullTagLiteral(string name, string ns);
                /*0x39422d8*/ void WritePotentiallyReferencingElement(string n, string ns, object o, System.Type ambientType, bool suppressReference, bool isNullable);
                /*0x39428a4*/ void WriteReferencedElements();
                /*0x39427e8*/ bool IsPrimitiveArray(System.Xml.Serialization.TypeData td);
                /*0x3942abc*/ void WriteArray(object o, System.Xml.Serialization.TypeData td);
                /*0x3942db0*/ void WriteReferencingElement(string n, string ns, object o, bool isNullable);
                /*0x3942760*/ void CheckReferenceQueue();
                /*0x3942f0c*/ void WriteSerializable(System.Xml.Serialization.IXmlSerializable serializable, string name, string ns, bool isNullable);
                /*0x3942f14*/ void WriteSerializable(System.Xml.Serialization.IXmlSerializable serializable, string name, string ns, bool isNullable, bool wrapped);
                /*0x39430c8*/ void WriteStartDocument();
                /*0x3941aec*/ void WriteStartElement(string name, string ns);
                /*0x3942750*/ void WriteStartElement(string name, string ns, bool writePrefixed);
                /*0x3943118*/ void WriteStartElement(string name, string ns, object o);
                /*0x3943110*/ void WriteStartElement(string name, string ns, object o, bool writePrefixed);
                /*0x3943124*/ void WriteStartElement(string name, string ns, object o, bool writePrefixed, System.Collections.ICollection namespaces);
                /*0x3943988*/ void WriteTypedPrimitive(string name, string ns, object o, bool xsiType);
                /*0x3943c54*/ void WriteValue(string value);
                /*0x3943c7c*/ void WriteXmlAttribute(System.Xml.XmlNode node, object container);
                /*0x3941afc*/ void WriteXsiType(string name, string ns);

                class WriteCallbackInfo
                {
                    /*0x10*/ System.Type Type;
                    /*0x18*/ string TypeName;
                    /*0x20*/ string TypeNs;
                    /*0x28*/ System.Xml.Serialization.XmlSerializationWriteCallback Callback;

                    /*0x3943f0c*/ WriteCallbackInfo();
                }
            }

            class XmlSerializationWriterInterpreter : System.Xml.Serialization.XmlSerializationWriter
            {
                /*0x48*/ System.Xml.Serialization.XmlMapping _typeMap;
                /*0x50*/ System.Xml.Serialization.SerializationFormat _format;

                static /*0x3944c28*/ object ImplicitConvert(object obj, System.Type type);
                /*0x3943f14*/ XmlSerializationWriterInterpreter(System.Xml.Serialization.XmlMapping typeMap);
                /*0x3943f58*/ void InitCallbacks();
                /*0x394436c*/ void WriteRoot(object ob);
                /*0x3944578*/ void WriteObject(System.Xml.Serialization.XmlTypeMapping typeMap, object ob, string element, string namesp, bool isNullable, bool needType, bool writeWrappingElem);
                /*0x3945080*/ void WriteMessage(System.Xml.Serialization.XmlMembersMapping membersMap, object[] parameters);
                /*0x39452b0*/ void WriteObjectElement(System.Xml.Serialization.XmlTypeMapping typeMap, object ob, string element, string namesp);
                /*0x39454e8*/ void WriteObjectElementAttributes(System.Xml.Serialization.XmlTypeMapping typeMap, object ob);
                /*0x3945c54*/ void WriteObjectElementElements(System.Xml.Serialization.XmlTypeMapping typeMap, object ob);
                /*0x3945270*/ void WriteMembers(System.Xml.Serialization.ClassMap map, object ob, bool isValueList);
                /*0x394558c*/ void WriteAttributeMembers(System.Xml.Serialization.ClassMap map, object ob, bool isValueList);
                /*0x3945cf8*/ void WriteElementMembers(System.Xml.Serialization.ClassMap map, object ob, bool isValueList);
                /*0x3946620*/ object GetMemberValue(System.Xml.Serialization.XmlTypeMapMember member, object ob, bool isValueList);
                /*0x3946400*/ bool MemberHasValue(System.Xml.Serialization.XmlTypeMapMember member, object ob, bool isValueList);
                /*0x3946d88*/ void WriteMemberElement(System.Xml.Serialization.XmlTypeMapElementInfo elem, object memberValue);
                /*0x3948980*/ void WritePrimitiveValueLiteral(object memberValue, string name, string ns, System.Xml.Serialization.XmlTypeMapping mappedType, System.Xml.Serialization.TypeData typeData, bool wrapped, bool isNullable);
                /*0x3948ca0*/ void WritePrimitiveValueEncoded(object memberValue, string name, string ns, System.Xml.XmlQualifiedName xsiType, System.Xml.Serialization.XmlTypeMapping mappedType, System.Xml.Serialization.TypeData typeData, bool wrapped, bool isNullable);
                /*0x3948f58*/ void WriteListElement(System.Xml.Serialization.XmlTypeMapping typeMap, object ob, string element, string namesp);
                /*0x3947318*/ void WriteListContent(object container, System.Xml.Serialization.TypeData listType, System.Xml.Serialization.ListMap map, object ob, System.Text.StringBuilder targetString);
                /*0x3949138*/ int GetListCount(System.Xml.Serialization.TypeData listType, object ob);
                /*0x3947acc*/ void WriteAnyElementContent(System.Xml.Serialization.XmlTypeMapMemberAnyElement member, object memberValue);
                /*0x3949f84*/ void WritePrimitiveElement(System.Xml.Serialization.XmlTypeMapping typeMap, object ob, string element, string namesp);
                /*0x3949fc0*/ void WriteEnumElement(System.Xml.Serialization.XmlTypeMapping typeMap, object ob, string element, string namesp);
                /*0x3946adc*/ string GetStringValue(System.Xml.Serialization.XmlTypeMapping typeMap, System.Xml.Serialization.TypeData type, object value);
                /*0x3949ff0*/ string GetEnumXmlValue(System.Xml.Serialization.XmlTypeMapping typeMap, object ob);

                class CallbackInfo
                {
                    /*0x10*/ System.Xml.Serialization.XmlSerializationWriterInterpreter _swi;
                    /*0x18*/ System.Xml.Serialization.XmlTypeMapping _typeMap;

                    /*0x3944328*/ CallbackInfo(System.Xml.Serialization.XmlSerializationWriterInterpreter swi, System.Xml.Serialization.XmlTypeMapping typeMap);
                    /*0x394a414*/ void WriteObject(object ob);
                    /*0x394a464*/ void WriteEnum(object ob);
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

                static /*0x394a4b4*/ XmlSerializer();
                /*0x394a568*/ XmlSerializer(System.Type type, System.Xml.Serialization.XmlAttributeOverrides overrides, System.Type[] extraTypes, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0x394a6ec*/ System.Xml.Serialization.XmlMapping get_Mapping();
                /*0x394a6f4*/ void OnUnknownAttribute(System.Xml.Serialization.XmlAttributeEventArgs e);
                /*0x394a71c*/ void OnUnknownElement(System.Xml.Serialization.XmlElementEventArgs e);
                /*0x394a744*/ void OnUnknownNode(System.Xml.Serialization.XmlNodeEventArgs e);
                /*0x394a76c*/ void OnUnreferencedObject(System.Xml.Serialization.UnreferencedObjectEventArgs e);
                /*0x394a794*/ System.Xml.Serialization.XmlSerializationReader CreateReader();
                /*0x394a7cc*/ System.Xml.Serialization.XmlSerializationWriter CreateWriter();
                /*0x394a804*/ object Deserialize(System.IO.TextReader textReader);
                /*0x394a898*/ object Deserialize(System.Xml.XmlReader xmlReader);
                /*0x394a964*/ object Deserialize(System.Xml.Serialization.XmlSerializationReader reader);
                /*0x394ac3c*/ void Serialize(object o, System.Xml.Serialization.XmlSerializationWriter writer);
                /*0x394ae30*/ void Serialize(System.IO.TextWriter textWriter, object o);
                /*0x394b1d4*/ void Serialize(System.Xml.XmlWriter xmlWriter, object o);
                /*0x394aec0*/ void Serialize(System.Xml.XmlWriter xmlWriter, object o, System.Xml.Serialization.XmlSerializerNamespaces namespaces);
                /*0x394b1dc*/ System.Xml.Serialization.XmlSerializationWriter CreateWriter(System.Xml.Serialization.XmlMapping typeMapping);
                /*0x394a908*/ System.Xml.Serialization.XmlSerializationReader CreateReader(System.Xml.Serialization.XmlMapping typeMapping);

                class SerializerData
                {
                    /*0x10*/ System.Reflection.MethodInfo ReaderMethod;
                    /*0x18*/ System.Type WriterType;
                    /*0x20*/ System.Reflection.MethodInfo WriterMethod;
                    /*0x28*/ System.Xml.Serialization.XmlSerializerImplementation Implementation;

                    /*0x394b3dc*/ System.Xml.Serialization.XmlSerializationWriter CreateWriter();
                }
            }

            class XmlSerializerFactory
            {
                static /*0x0*/ System.Collections.Hashtable serializersBySource;

                static /*0x394b754*/ XmlSerializerFactory();
                /*0x394b4a8*/ XmlSerializerFactory();
                /*0x394b4b0*/ System.Xml.Serialization.XmlSerializer CreateSerializer(System.Type type);
                /*0x394b740*/ System.Xml.Serialization.XmlSerializer CreateSerializer(System.Type type, System.Xml.Serialization.XmlRootAttribute root);
                /*0x394b4c4*/ System.Xml.Serialization.XmlSerializer CreateSerializer(System.Type type, System.Xml.Serialization.XmlAttributeOverrides overrides, System.Type[] extraTypes, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
            }

            class XmlSerializerImplementation
            {
                /*0x394b7d0*/ System.Xml.Serialization.XmlSerializationWriter get_Writer();
            }

            class XmlTextAttribute : System.Attribute
            {
                /*0x10*/ string dataType;
                /*0x18*/ System.Type type;

                /*0x394b808*/ XmlTextAttribute();
                /*0x394b810*/ string get_DataType();
                /*0x394b834*/ System.Type get_Type();
                /*0x394b83c*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlTypeAttribute : System.Attribute
            {
                /*0x10*/ bool includeInSchema;
                /*0x18*/ string ns;
                /*0x20*/ string typeName;

                /*0x394b8cc*/ bool get_IncludeInSchema();
                /*0x394b8d4*/ string get_Namespace();
                /*0x394b8dc*/ string get_TypeName();
                /*0x394b900*/ void AddKeyHash(System.Text.StringBuilder sb);
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

                /*0x394b9a4*/ XmlTypeMapElementInfo(System.Xml.Serialization.XmlTypeMapMember member, System.Xml.Serialization.TypeData type);
                /*0x394ba70*/ System.Xml.Serialization.TypeData get_TypeData();
                /*0x394ba78*/ object get_ChoiceValue();
                /*0x394ba80*/ void set_ChoiceValue(object value);
                /*0x394ba88*/ string get_ElementName();
                /*0x394ba90*/ void set_ElementName(string value);
                /*0x394ba98*/ string get_Namespace();
                /*0x394baa0*/ void set_Namespace(string value);
                /*0x3948c38*/ string get_DataTypeNamespace();
                /*0x3948c0c*/ string get_DataTypeName();
                /*0x394baa8*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0x394bab0*/ void set_Form(System.Xml.Schema.XmlSchemaForm value);
                /*0x394bab8*/ System.Xml.Serialization.XmlTypeMapping get_MappedType();
                /*0x394bac0*/ void set_MappedType(System.Xml.Serialization.XmlTypeMapping value);
                /*0x394bac8*/ bool get_IsNullable();
                /*0x394bad0*/ void set_IsNullable(bool value);
                /*0x394bad8*/ System.Xml.Serialization.XmlTypeMapMember get_Member();
                /*0x394bae0*/ void set_NestingLevel(int value);
                /*0x394bae8*/ bool get_MultiReferenceType();
                /*0x394bb08*/ bool get_WrappedElement();
                /*0x394bb10*/ void set_WrappedElement(bool value);
                /*0x394bb18*/ bool get_IsTextElement();
                /*0x394bb64*/ void set_IsTextElement(bool value);
                /*0x394bc20*/ bool get_IsUnnamedAnyElement();
                /*0x394bc40*/ void set_IsUnnamedAnyElement(bool value);
                /*0x394bcd4*/ int get_ExplicitOrder();
                /*0x394bcdc*/ void set_ExplicitOrder(int value);
                /*0x394bce4*/ bool Equals(object other);
                /*0x394be1c*/ int GetHashCode();
            }

            class XmlTypeMapElementInfoList : System.Collections.ArrayList
            {
                /*0x394be24*/ XmlTypeMapElementInfoList();
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

                static /*0x394c1cc*/ object GetValue(object ob, string name);
                static /*0x394c41c*/ void SetValue(object ob, string name, object value);
                /*0x394be2c*/ XmlTypeMapMember();
                /*0x394bea4*/ string get_Name();
                /*0x394beac*/ void set_Name(string value);
                /*0x394beb4*/ object get_DefaultValue();
                /*0x394bebc*/ void set_DefaultValue(object value);
                /*0x394bec4*/ bool IsReadOnly(System.Type type);
                /*0x39453d8*/ object GetValue(object ob);
                /*0x394c2e8*/ void SetValue(object ob, object value);
                /*0x394bf78*/ void InitMember(System.Type type);
                /*0x394c54c*/ System.Xml.Serialization.TypeData get_TypeData();
                /*0x394c554*/ void set_TypeData(System.Xml.Serialization.TypeData value);
                /*0x394c55c*/ int get_Index();
                /*0x394c564*/ void set_Index(int value);
                /*0x394c56c*/ int get_GlobalIndex();
                /*0x394c574*/ void set_GlobalIndex(int value);
                /*0x3948744*/ bool get_IsOptionalValueType();
                /*0x394c57c*/ void set_IsOptionalValueType(bool value);
                /*0x394c58c*/ bool get_IsReturnValue();
                /*0x394c598*/ void set_IsReturnValue(bool value);
                /*0x394c5b8*/ void CheckOptionalValueType(System.Type type);
                /*0x3948750*/ bool GetValueSpecified(object ob);
                /*0x394c634*/ void SetValueSpecified(object ob, bool value);
            }

            class XmlTypeMapMemberAttribute : System.Xml.Serialization.XmlTypeMapMember
            {
                /*0x58*/ string _attributeName;
                /*0x60*/ string _namespace;
                /*0x68*/ System.Xml.Schema.XmlSchemaForm _form;
                /*0x70*/ System.Xml.Serialization.XmlTypeMapping _mappedType;

                /*0x394c8ac*/ XmlTypeMapMemberAttribute();
                /*0x394c900*/ string get_AttributeName();
                /*0x394c908*/ void set_AttributeName(string value);
                /*0x394c910*/ string get_Namespace();
                /*0x394c918*/ void set_Namespace(string value);
                /*0x394c920*/ void set_Form(System.Xml.Schema.XmlSchemaForm value);
                /*0x394c928*/ System.Xml.Serialization.XmlTypeMapping get_MappedType();
                /*0x394c930*/ void set_MappedType(System.Xml.Serialization.XmlTypeMapping value);
            }

            class XmlTypeMapMemberElement : System.Xml.Serialization.XmlTypeMapMember
            {
                /*0x58*/ System.Xml.Serialization.XmlTypeMapElementInfoList _elementInfo;
                /*0x60*/ string _choiceMember;
                /*0x68*/ bool _isTextCollector;
                /*0x70*/ System.Xml.Serialization.TypeData _choiceTypeData;

                /*0x394c938*/ XmlTypeMapMemberElement();
                /*0x3946d18*/ System.Xml.Serialization.XmlTypeMapElementInfoList get_ElementInfo();
                /*0x394c93c*/ void set_ElementInfo(System.Xml.Serialization.XmlTypeMapElementInfoList value);
                /*0x394c944*/ string get_ChoiceMember();
                /*0x394c94c*/ void set_ChoiceMember(string value);
                /*0x394c954*/ System.Xml.Serialization.TypeData get_ChoiceTypeData();
                /*0x394c95c*/ void set_ChoiceTypeData(System.Xml.Serialization.TypeData value);
                /*0x39480b8*/ System.Xml.Serialization.XmlTypeMapElementInfo FindElement(object ob, object memberValue);
                /*0x394c964*/ void SetChoice(object ob, object choice);
                /*0x394c974*/ bool get_IsXmlTextCollector();
                /*0x394c97c*/ void set_IsXmlTextCollector(bool value);
            }

            class XmlTypeMapMemberList : System.Xml.Serialization.XmlTypeMapMemberElement
            {
                /*0x394c984*/ XmlTypeMapMemberList();
            }

            class XmlTypeMapMemberExpandable : System.Xml.Serialization.XmlTypeMapMemberElement
            {
                /*0x78*/ int _flatArrayIndex;

                /*0x394c998*/ XmlTypeMapMemberExpandable();
                /*0x394c988*/ int get_FlatArrayIndex();
                /*0x394c990*/ void set_FlatArrayIndex(int value);
            }

            class XmlTypeMapMemberFlatList : System.Xml.Serialization.XmlTypeMapMemberExpandable
            {
                /*0x80*/ System.Xml.Serialization.ListMap _listMap;

                /*0x394c9ac*/ XmlTypeMapMemberFlatList();
                /*0x394c99c*/ System.Xml.Serialization.ListMap get_ListMap();
                /*0x394c9a4*/ void set_ListMap(System.Xml.Serialization.ListMap value);
            }

            class XmlTypeMapMemberAnyElement : System.Xml.Serialization.XmlTypeMapMemberExpandable
            {
                /*0x394cc8c*/ XmlTypeMapMemberAnyElement();
                /*0x3949c60*/ bool IsElementDefined(string name, string ns);
                /*0x394c9b0*/ bool get_IsDefaultAny();
            }

            class XmlTypeMapMemberAnyAttribute : System.Xml.Serialization.XmlTypeMapMember
            {
                /*0x394cc90*/ XmlTypeMapMemberAnyAttribute();
            }

            class XmlTypeMapMemberNamespaces : System.Xml.Serialization.XmlTypeMapMember
            {
                /*0x394cc94*/ XmlTypeMapMemberNamespaces();
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

                /*0x394cc98*/ XmlTypeMapping(string elementName, string ns, System.Xml.Serialization.TypeData typeData, string xmlType, string xmlTypeNamespace);
                /*0x394a098*/ string get_TypeFullName();
                /*0x394cd70*/ System.Xml.Serialization.TypeData get_TypeData();
                /*0x394cd78*/ string get_XmlType();
                /*0x394cd80*/ void set_XmlType(string value);
                /*0x394505c*/ string get_XmlTypeNamespace();
                /*0x394cd88*/ void set_XmlTypeNamespace(string value);
                /*0x394cd90*/ bool get_HasXmlTypeNamespace();
                /*0x394cda0*/ System.Collections.ArrayList get_DerivedTypes();
                /*0x394cda8*/ bool get_MultiReferenceType();
                /*0x394cdb0*/ System.Xml.Serialization.XmlTypeMapping get_BaseMap();
                /*0x394cdb8*/ void set_BaseMap(System.Xml.Serialization.XmlTypeMapping value);
                /*0x394cdc0*/ void set_IncludeInSchema(bool value);
                /*0x394cdc8*/ bool get_IsNullable();
                /*0x394cdd0*/ void set_IsNullable(bool value);
                /*0x394cdd8*/ bool get_IsAny();
                /*0x394cde0*/ void set_IsAny(bool value);
                /*0x3944ef8*/ System.Xml.Serialization.XmlTypeMapping GetRealTypeMap(System.Type objectType);
                /*0x394cde8*/ System.Xml.Serialization.XmlTypeMapping GetRealElementMap(string name, string ens);
                /*0x394d138*/ void UpdateRoot(System.Xml.XmlQualifiedName qname);
            }

            class XmlSerializableMapping : System.Xml.Serialization.XmlTypeMapping
            {
                /*0x78*/ System.Xml.Schema.XmlSchema _schema;
                /*0x80*/ System.Xml.Schema.XmlSchemaComplexType _schemaType;
                /*0x88*/ System.Xml.XmlQualifiedName _schemaTypeName;

                /*0x394d1dc*/ XmlSerializableMapping(System.Xml.Serialization.XmlRootAttribute root, string elementName, string ns, System.Xml.Serialization.TypeData typeData, string xmlType, string xmlTypeNamespace);
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

                /*0x394f4cc*/ ClassMap();
                /*0x394d9d4*/ void AddMember(System.Xml.Serialization.XmlTypeMapMember member);
                /*0x394e5e0*/ void RegisterFlatList(System.Xml.Serialization.XmlTypeMapMemberExpandable member);
                /*0x394e690*/ System.Xml.Serialization.XmlTypeMapMemberAttribute GetAttribute(string name, string ns);
                /*0x394e74c*/ System.Xml.Serialization.XmlTypeMapElementInfo GetElement(string name, string ns, int minimalOrder);
                /*0x394eaf8*/ System.Xml.Serialization.XmlTypeMapElementInfo GetElement(string name, string ns);
                /*0x394e500*/ string BuildKey(string name, string ns, int explicitOrder);
                /*0x394ee60*/ bool get_IsOrderDependentMap();
                /*0x394f23c*/ System.Xml.Serialization.XmlTypeMapMemberAnyElement get_DefaultAnyElementMember();
                /*0x394f244*/ System.Xml.Serialization.XmlTypeMapMemberAnyAttribute get_DefaultAnyAttributeMember();
                /*0x394f24c*/ System.Xml.Serialization.XmlTypeMapMemberNamespaces get_NamespaceDeclarations();
                /*0x39466ec*/ System.Collections.ICollection get_AttributeMembers();
                /*0x394f254*/ System.Collections.ICollection get_ElementMembers();
                /*0x394f25c*/ System.Collections.ArrayList get_AllMembers();
                /*0x394f264*/ System.Collections.ArrayList get_FlatLists();
                /*0x394f26c*/ System.Collections.ArrayList get_ListMembers();
                /*0x394f274*/ System.Xml.Serialization.XmlTypeMapMember get_XmlTextCollector();
                /*0x394f27c*/ System.Xml.Serialization.XmlTypeMapMember get_ReturnMember();
                /*0x394f284*/ System.Xml.XmlQualifiedName get_SimpleContentBaseType();
                /*0x394f458*/ void SetCanBeSimpleType(bool can);
                /*0x394f460*/ bool get_HasSimpleContent();
            }

            class ListMap : System.Xml.Serialization.ObjectMap
            {
                /*0x10*/ System.Xml.Serialization.XmlTypeMapElementInfoList _itemInfo;
                /*0x18*/ string _choiceMember;

                /*0x394fca0*/ ListMap();
                /*0x394f580*/ void set_ChoiceMember(string value);
                /*0x394f588*/ System.Xml.Serialization.XmlTypeMapElementInfoList get_ItemInfo();
                /*0x394f590*/ void set_ItemInfo(System.Xml.Serialization.XmlTypeMapElementInfoList value);
                /*0x3949480*/ System.Xml.Serialization.XmlTypeMapElementInfo FindElement(object ob, int index, object memberValue);
                /*0x394f598*/ System.Xml.Serialization.XmlTypeMapElementInfo FindElement(string elementName, string ns);
                /*0x394f884*/ System.Xml.Serialization.XmlTypeMapElementInfo FindTextElement();
                /*0x3949248*/ void GetArrayType(int itemCount, ref string localName, ref string ns);
                /*0x394fb40*/ bool Equals(object other);
                /*0x394fc98*/ int GetHashCode();
            }

            class EnumMap : System.Xml.Serialization.ObjectMap
            {
                /*0x10*/ System.Xml.Serialization.EnumMap.EnumMapMember[] _members;
                /*0x18*/ bool _isFlags;
                /*0x20*/ string[] _enumNames;
                /*0x28*/ string[] _xmlNames;
                /*0x30*/ long[] _values;

                /*0x394fca8*/ EnumMap(System.Xml.Serialization.EnumMap.EnumMapMember[] members, bool isFlags);
                /*0x394fe50*/ bool get_IsFlags();
                /*0x394fe58*/ string[] get_EnumNames();
                /*0x394fe60*/ string[] get_XmlNames();
                /*0x394fe68*/ long[] get_Values();
                /*0x394a0b0*/ string GetXmlName(string typeName, object enumValue);
                /*0x394fe70*/ string GetEnumName(string typeName, string xmlName);

                class EnumMapMember
                {
                    /*0x10*/ string _xmlName;
                    /*0x18*/ string _enumName;
                    /*0x20*/ long _value;

                    /*0x3950140*/ EnumMapMember(string xmlName, string enumName, long value);
                    /*0x3950198*/ string get_XmlName();
                    /*0x39501a0*/ string get_EnumName();
                    /*0x39501a8*/ long get_Value();
                }
            }
        }

        namespace XmlConfiguration
        {
            class XmlReaderSection
            {
                static /*0x39501b0*/ bool get_ProhibitDefaultUrlResolver();
                static /*0x39501b8*/ System.Xml.XmlResolver CreateDefaultResolver();
                static /*0x395020c*/ bool get_CollapseWhiteSpaceIntoEmptyString();
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

                    /*0x3950214*/ void Clear();
                    /*0x3950224*/ int get_Count();
                    /*0x395022c*/ string GetResult();
                    /*0x3950320*/ void ConcatNoDelimiter(string s);
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

                /*0x39504c0*/ AxisElement(System.Xml.Schema.DoubleLinkAxis node, int depth);
                /*0x39504b8*/ System.Xml.Schema.DoubleLinkAxis get_CurNode();
                /*0x3950500*/ void SetDepth(int depth);
                /*0x3950508*/ void MoveToParent(int depth, System.Xml.Schema.ForwardAxis parent);
                /*0x3950634*/ bool MoveToChild(string name, string URN, int depth, System.Xml.Schema.ForwardAxis parent);
            }

            class AxisStack
            {
                /*0x10*/ System.Collections.ArrayList _stack;
                /*0x18*/ System.Xml.Schema.ForwardAxis _subtree;
                /*0x20*/ System.Xml.Schema.ActiveAxis _parent;

                static /*0x39507d8*/ bool Equal(string thisname, string thisURN, string name, string URN);
                /*0x395087c*/ AxisStack(System.Xml.Schema.ForwardAxis faxis, System.Xml.Schema.ActiveAxis parent);
                /*0x3950854*/ System.Xml.Schema.ForwardAxis get_Subtree();
                /*0x395085c*/ int get_Length();
                /*0x3950944*/ void Push(int depth);
                /*0x39509e4*/ void Pop();
                /*0x3950a24*/ void MoveToParent(string name, string URN, int depth);
                /*0x3950b68*/ bool MoveToChild(string name, string URN, int depth);
                /*0x3950ca8*/ bool MoveToAttribute(string name, string URN, int depth);
            }

            class ActiveAxis
            {
                /*0x10*/ int _currentDepth;
                /*0x14*/ bool _isActive;
                /*0x18*/ System.Xml.Schema.Asttree _axisTree;
                /*0x20*/ System.Collections.ArrayList _axisStack;

                /*0x3950e30*/ ActiveAxis(System.Xml.Schema.Asttree axisTree);
                /*0x3950e14*/ int get_CurrentDepth();
                /*0x3950e1c*/ void Reactivate();
                /*0x3950ff0*/ bool MoveToStartElement(string localname, string URN);
                /*0x3951130*/ bool EndElement(string localname, string URN);
                /*0x3951240*/ bool MoveToAttribute(string localname, string URN);
            }

            class DoubleLinkAxis : MS.Internal.Xml.XPath.Axis
            {
                /*0x40*/ MS.Internal.Xml.XPath.Axis next;

                static /*0x39513ec*/ System.Xml.Schema.DoubleLinkAxis ConvertTree(MS.Internal.Xml.XPath.Axis axis);
                /*0x395135c*/ DoubleLinkAxis(MS.Internal.Xml.XPath.Axis axis, System.Xml.Schema.DoubleLinkAxis inputaxis);
                /*0x395134c*/ MS.Internal.Xml.XPath.Axis get_Next();
                /*0x3951354*/ void set_Next(MS.Internal.Xml.XPath.Axis value);
            }

            class ForwardAxis
            {
                /*0x10*/ System.Xml.Schema.DoubleLinkAxis _topNode;
                /*0x18*/ System.Xml.Schema.DoubleLinkAxis _rootNode;
                /*0x20*/ bool _isAttribute;
                /*0x21*/ bool _isDss;
                /*0x22*/ bool _isSelfAxis;

                /*0x39514d4*/ ForwardAxis(System.Xml.Schema.DoubleLinkAxis axis, bool isdesorself);
                /*0x39514ac*/ System.Xml.Schema.DoubleLinkAxis get_RootNode();
                /*0x39514b4*/ System.Xml.Schema.DoubleLinkAxis get_TopNode();
                /*0x39514bc*/ bool get_IsAttribute();
                /*0x39514c4*/ bool get_IsDss();
                /*0x39514cc*/ bool get_IsSelfAxis();
            }

            class Asttree
            {
                /*0x10*/ System.Collections.ArrayList _fAxisArray;
                /*0x18*/ string _xpathexpr;
                /*0x20*/ bool _isField;
                /*0x28*/ System.Xml.XmlNamespaceManager _nsmgr;

                static /*0x3951ed0*/ bool IsNameTest(MS.Internal.Xml.XPath.Axis ast);
                static /*0x39507a8*/ bool IsAttribute(MS.Internal.Xml.XPath.Axis ast);
                static /*0x3951f00*/ bool IsDescendantOrSelf(MS.Internal.Xml.XPath.Axis ast);
                static /*0x3951640*/ bool IsSelf(MS.Internal.Xml.XPath.Axis ast);
                /*0x3951684*/ Asttree(string xPath, bool isField, System.Xml.XmlNamespaceManager nsmgr);
                /*0x395167c*/ System.Collections.ArrayList get_SubtreeArray();
                /*0x39516ec*/ void CompileXPath(string xPath, bool isField, System.Xml.XmlNamespaceManager nsmgr);
                /*0x3951f3c*/ void SetURN(MS.Internal.Xml.XPath.Axis axis, System.Xml.XmlNamespaceManager nsmgr);
            }

            class AutoValidator : System.Xml.Schema.BaseValidator
            {
                /*0x395205c*/ AutoValidator(System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling);
                /*0x39521e4*/ bool get_PreserveWhitespace();
                /*0x39521ec*/ void Validate();
                /*0x3952620*/ void CompleteValidation();
                /*0x3952624*/ object FindId(string name);
                /*0x39522d4*/ System.Xml.ValidationType DetectValidationType();
            }

            class BaseProcessor
            {
                /*0x10*/ System.Xml.XmlNameTable nameTable;
                /*0x18*/ System.Xml.Schema.SchemaNames schemaNames;
                /*0x20*/ System.Xml.Schema.ValidationEventHandler eventHandler;
                /*0x28*/ System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings;
                /*0x30*/ int errorCount;
                /*0x38*/ string NsXml;

                /*0x39526c4*/ BaseProcessor(System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler);
                /*0x3952748*/ BaseProcessor(System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler, System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings);
                /*0x395281c*/ System.Xml.XmlNameTable get_NameTable();
                /*0x3952824*/ System.Xml.Schema.SchemaNames get_SchemaNames();
                /*0x39528a8*/ System.Xml.Schema.ValidationEventHandler get_EventHandler();
                /*0x39528b0*/ System.Xml.Schema.XmlSchemaCompilationSettings get_CompilationSettings();
                /*0x39528b8*/ bool get_HasErrors();
                /*0x39528c8*/ void AddToTable(System.Xml.Schema.XmlSchemaObjectTable table, System.Xml.XmlQualifiedName qname, System.Xml.Schema.XmlSchemaObject item);
                /*0x3952d28*/ bool IsValidAttributeGroupRedefine(System.Xml.Schema.XmlSchemaObject existingObject, System.Xml.Schema.XmlSchemaObject item, System.Xml.Schema.XmlSchemaObjectTable table);
                /*0x3952f80*/ bool IsValidGroupRedefine(System.Xml.Schema.XmlSchemaObject existingObject, System.Xml.Schema.XmlSchemaObject item, System.Xml.Schema.XmlSchemaObjectTable table);
                /*0x3952e54*/ bool IsValidTypeRedefine(System.Xml.Schema.XmlSchemaObject existingObject, System.Xml.Schema.XmlSchemaObject item, System.Xml.Schema.XmlSchemaObjectTable table);
                /*0x3953120*/ void SendValidationEvent(string code, System.Xml.Schema.XmlSchemaObject source);
                /*0x3953098*/ void SendValidationEvent(string code, string msg, System.Xml.Schema.XmlSchemaObject source);
                /*0x3953260*/ void SendValidationEvent(string code, string msg1, string msg2, System.Xml.Schema.XmlSchemaObject source);
                /*0x3953354*/ void SendValidationEvent(string code, string[] args, System.Exception innerException, System.Xml.Schema.XmlSchemaObject source);
                /*0x3953410*/ void SendValidationEvent(string code, string msg1, string msg2, string sourceUri, int lineNumber, int linePosition);
                /*0x395351c*/ void SendValidationEvent(string code, System.Xml.Schema.XmlSchemaObject source, System.Xml.Schema.XmlSeverityType severity);
                /*0x39535a0*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e);
                /*0x39535a8*/ void SendValidationEvent(string code, string msg, System.Xml.Schema.XmlSchemaObject source, System.Xml.Schema.XmlSeverityType severity);
                /*0x3953198*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity);
                /*0x3953634*/ void SendValidationEventNoThrow(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity);
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

                static /*0x3954288*/ void ProcessEntity(System.Xml.Schema.SchemaInfo sinfo, string name, object sender, System.Xml.Schema.ValidationEventHandler eventhandler, string baseUri, int lineNumber, int linePosition);
                static /*0x3954448*/ void ProcessEntity(System.Xml.Schema.SchemaInfo sinfo, string name, System.Xml.IValidationEventHandling eventHandling, string baseUriStr, int lineNumber, int linePosition);
                static /*0x395463c*/ System.Xml.Schema.BaseValidator CreateInstance(System.Xml.ValidationType valType, System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling, bool processIdentityConstraints);
                /*0x39536dc*/ BaseValidator(System.Xml.Schema.BaseValidator other);
                /*0x39520ec*/ BaseValidator(System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling);
                /*0x3953794*/ System.Xml.XmlValidatingReaderImpl get_Reader();
                /*0x395379c*/ System.Xml.Schema.XmlSchemaCollection get_SchemaCollection();
                /*0x39537a4*/ System.Xml.XmlNameTable get_NameTable();
                /*0x395262c*/ System.Xml.Schema.SchemaNames get_SchemaNames();
                /*0x39537ac*/ System.Xml.PositionInfo get_PositionInfo();
                /*0x39537b4*/ System.Xml.XmlResolver get_XmlResolver();
                /*0x39537bc*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x39537c4*/ System.Uri get_BaseUri();
                /*0x39537cc*/ void set_BaseUri(System.Uri value);
                /*0x39537d4*/ System.Xml.Schema.ValidationEventHandler get_EventHandler();
                /*0x39538a4*/ System.Xml.Schema.SchemaInfo get_SchemaInfo();
                /*0x39538ac*/ void set_DtdInfo(System.Xml.IDtdInfo value);
                /*0x395398c*/ bool get_PreserveWhitespace();
                /*0x3953994*/ void Validate();
                /*0x3953998*/ void CompleteValidation();
                /*0x395399c*/ object FindId(string name);
                /*0x39539a4*/ void ValidateText();
                /*0x3953e6c*/ void ValidateWhitespace();
                /*0x3953df4*/ void SaveTextValue(string value);
                /*0x3953f9c*/ void SendValidationEvent(string code);
                /*0x3953d0c*/ void SendValidationEvent(string code, string[] args);
                /*0x3953c24*/ void SendValidationEvent(string code, string arg);
                /*0x3953fb4*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e);
                /*0x39540a0*/ void SendValidationEvent(string code, string msg, System.Xml.Schema.XmlSeverityType severity);
                /*0x3954194*/ void SendValidationEvent(string code, string[] args, System.Xml.Schema.XmlSeverityType severity);
                /*0x3953fbc*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity);
            }

            class BitSet
            {
                /*0x10*/ int count;
                /*0x18*/ uint[] bits;

                /*0x39547c8*/ BitSet();
                /*0x39547d0*/ BitSet(int count);
                /*0x3954850*/ int get_Count();
                /*0x3954858*/ bool get_Item(int index);
                /*0x39548ac*/ void Clear();
                /*0x3954900*/ void Set(int index);
                /*0x395485c*/ bool Get(int index);
                /*0x3954a04*/ int NextSet(int startFrom);
                /*0x3954a9c*/ void And(System.Xml.Schema.BitSet other);
                /*0x3954b60*/ void Or(System.Xml.Schema.BitSet other);
                /*0x3954c04*/ int GetHashCode();
                /*0x3954c3c*/ bool Equals(object obj);
                /*0x3954d98*/ System.Xml.Schema.BitSet Clone();
                /*0x3954e94*/ bool get_IsEmpty();
                /*0x3954ef4*/ bool Intersects(System.Xml.Schema.BitSet other);
                /*0x3954848*/ int Subscript(int bitIndex);
                /*0x395495c*/ void EnsureLength(int nRequiredLength);
            }

            class ChameleonKey
            {
                /*0x10*/ string targetNS;
                /*0x18*/ System.Uri chameleonLocation;
                /*0x20*/ System.Xml.Schema.XmlSchema originalSchema;
                /*0x28*/ int hashCode;

                /*0x3954fd4*/ ChameleonKey(string ns, System.Xml.Schema.XmlSchema originalSchema);
                /*0x395505c*/ int GetHashCode();
                /*0x39550e0*/ bool Equals(object obj);
            }

            class CompiledIdentityConstraint
            {
                static /*0x0*/ System.Xml.Schema.CompiledIdentityConstraint Empty;
                /*0x10*/ System.Xml.XmlQualifiedName name;
                /*0x18*/ System.Xml.Schema.CompiledIdentityConstraint.ConstraintRole role;
                /*0x20*/ System.Xml.Schema.Asttree selector;
                /*0x28*/ System.Xml.Schema.Asttree[] fields;
                /*0x30*/ System.Xml.XmlQualifiedName refer;

                static /*0x3955740*/ CompiledIdentityConstraint();
                /*0x39551cc*/ CompiledIdentityConstraint();
                /*0x3955254*/ CompiledIdentityConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint constraint, System.Xml.XmlNamespaceManager nsmgr);
                /*0x39551b4*/ System.Xml.Schema.CompiledIdentityConstraint.ConstraintRole get_Role();
                /*0x39551bc*/ System.Xml.Schema.Asttree get_Selector();
                /*0x39551c4*/ System.Xml.Schema.Asttree[] get_Fields();

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

                /*0x39557ac*/ ConstraintStruct(System.Xml.Schema.CompiledIdentityConstraint constraint);
                /*0x39557a4*/ int get_TableDim();
            }

            class LocatedActiveAxis : System.Xml.Schema.ActiveAxis
            {
                /*0x28*/ int column;
                /*0x2c*/ bool isMatched;
                /*0x30*/ System.Xml.Schema.KeySequence Ks;

                /*0x3955980*/ LocatedActiveAxis(System.Xml.Schema.Asttree astfield, System.Xml.Schema.KeySequence ks, int column);
                /*0x3955978*/ int get_Column();
                /*0x39559bc*/ void Reactivate(System.Xml.Schema.KeySequence ks);
            }

            class SelectorActiveAxis : System.Xml.Schema.ActiveAxis
            {
                /*0x28*/ System.Xml.Schema.ConstraintStruct cs;
                /*0x30*/ System.Collections.ArrayList KSs;
                /*0x38*/ int KSpointer;

                /*0x39558ec*/ SelectorActiveAxis(System.Xml.Schema.Asttree axisTree, System.Xml.Schema.ConstraintStruct cs);
                /*0x39559d4*/ int get_lastDepth();
                /*0x3955a7c*/ bool EndElement(string localname, string URN);
                /*0x3955ac4*/ int PushKS(int errline, int errcol);
                /*0x3955ee0*/ System.Xml.Schema.KeySequence PopKS();
            }

            class KSStruct
            {
                /*0x10*/ int depth;
                /*0x18*/ System.Xml.Schema.KeySequence ks;
                /*0x20*/ System.Xml.Schema.LocatedActiveAxis[] fields;

                /*0x3955e5c*/ KSStruct(System.Xml.Schema.KeySequence ks, int dim);
            }

            class TypedObject
            {
                /*0x10*/ System.Xml.Schema.TypedObject.DecimalStruct dstruct;
                /*0x18*/ object ovalue;
                /*0x20*/ string svalue;
                /*0x28*/ System.Xml.Schema.XmlSchemaDatatype xsdtype;
                /*0x30*/ int dim;
                /*0x34*/ bool isList;

                /*0x3955fd0*/ TypedObject(object obj, string svalue, System.Xml.Schema.XmlSchemaDatatype xsdtype);
                /*0x3955f80*/ int get_Dim();
                /*0x3955f88*/ bool get_IsList();
                /*0x3955f90*/ bool get_IsDecimal();
                /*0x3955fa8*/ decimal[] get_Dvalue();
                /*0x3955fc0*/ object get_Value();
                /*0x3955fc8*/ System.Xml.Schema.XmlSchemaDatatype get_Type();
                /*0x3956148*/ string ToString();
                /*0x3956150*/ void SetDecimal();
                /*0x39564cc*/ bool ListDValueEquals(System.Xml.Schema.TypedObject other);
                /*0x39565e0*/ bool Equals(System.Xml.Schema.TypedObject other);

                class DecimalStruct
                {
                    /*0x10*/ bool isDecimal;
                    /*0x18*/ decimal[] dvalue;

                    /*0x3956468*/ DecimalStruct();
                    /*0x39563f8*/ DecimalStruct(int dim);
                    /*0x3956844*/ bool get_IsDecimal();
                    /*0x395684c*/ void set_IsDecimal(bool value);
                    /*0x3956854*/ decimal[] get_Dvalue();
                }
            }

            class KeySequence
            {
                /*0x10*/ System.Xml.Schema.TypedObject[] ks;
                /*0x18*/ int dim;
                /*0x1c*/ int hashcode;
                /*0x20*/ int posline;
                /*0x24*/ int poscol;

                /*0x3955dc8*/ KeySequence(int dim, int line, int col);
                /*0x395685c*/ int get_PosLine();
                /*0x3956864*/ int get_PosCol();
                /*0x395686c*/ object get_Item(int index);
                /*0x395689c*/ void set_Item(int index, object value);
                /*0x3956998*/ bool IsQualified();
                /*0x3956a00*/ int GetHashCode();
                /*0x3956d60*/ bool Equals(object other);
                /*0x3956e50*/ string ToString();
            }

            class UpaException : System.Exception
            {
                /*0x90*/ object particle1;
                /*0x98*/ object particle2;

                /*0x3956f7c*/ UpaException(object particle1, object particle2);
                /*0x3957004*/ object get_Particle1();
                /*0x395700c*/ object get_Particle2();
            }

            class SymbolsDictionary
            {
                /*0x10*/ int last;
                /*0x18*/ System.Collections.Hashtable names;
                /*0x20*/ System.Collections.Hashtable wildcards;
                /*0x28*/ System.Collections.ArrayList particles;
                /*0x30*/ object particleLast;
                /*0x38*/ bool isUpaEnforced;

                /*0x3957014*/ SymbolsDictionary();
                /*0x39570c8*/ int get_Count();
                /*0x39570d4*/ bool get_IsUpaEnforced();
                /*0x39570dc*/ void set_IsUpaEnforced(bool value);
                /*0x39570e4*/ int AddName(System.Xml.XmlQualifiedName name, object particle);
                /*0x39571ec*/ void AddNamespaceList(System.Xml.Schema.NamespaceList list, object particle, bool allowLocal);
                /*0x3957560*/ void AddWildcard(string wildcard, object particle);
                /*0x39576d4*/ System.Collections.ICollection GetNamespaceListSymbols(System.Xml.Schema.NamespaceList list);
                /*0x3957dec*/ int get_Item(System.Xml.XmlQualifiedName name);
                /*0x3957e80*/ bool Exists(System.Xml.XmlQualifiedName name);
                /*0x3957eb0*/ object GetParticle(int symbol);
                /*0x3957ee4*/ string NameOf(int symbol);
            }

            struct Position
            {
                /*0x10*/ int symbol;
                /*0x18*/ object particle;

                /*0x3958520*/ Position(int symbol, object particle);
            }

            class Positions
            {
                /*0x10*/ System.Collections.ArrayList positions;

                /*0x3958688*/ Positions();
                /*0x3958530*/ int Add(int symbol, object particle);
                /*0x39585d8*/ System.Xml.Schema.Position get_Item(int pos);
                /*0x3958668*/ int get_Count();
            }

            class SyntaxTreeNode
            {
                /*0x39586fc*/ SyntaxTreeNode();
                /*0x1f310fc*/ void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
                /*0x1f310fc*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x1f2fe14*/ bool get_IsNullable();
                /*0x39586f4*/ bool get_IsRangeNode();
            }

            class LeafNode : System.Xml.Schema.SyntaxTreeNode
            {
                /*0x10*/ int pos;

                /*0x3958704*/ LeafNode(int pos);
                /*0x395872c*/ int get_Pos();
                /*0x3958734*/ void set_Pos(int value);
                /*0x395873c*/ void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
                /*0x3958740*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x3958780*/ bool get_IsNullable();
            }

            class NamespaceListNode : System.Xml.Schema.SyntaxTreeNode
            {
                /*0x10*/ System.Xml.Schema.NamespaceList namespaceList;
                /*0x18*/ object particle;

                /*0x3958788*/ NamespaceListNode(System.Xml.Schema.NamespaceList namespaceList, object particle);
                /*0x39587cc*/ System.Collections.ICollection GetResolvedSymbols(System.Xml.Schema.SymbolsDictionary symbols);
                /*0x39587e8*/ void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
                /*0x3958c44*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x3958c7c*/ bool get_IsNullable();
            }

            class InteriorNode : System.Xml.Schema.SyntaxTreeNode
            {
                /*0x10*/ System.Xml.Schema.SyntaxTreeNode leftChild;
                /*0x18*/ System.Xml.Schema.SyntaxTreeNode rightChild;

                /*0x3958f0c*/ InteriorNode();
                /*0x3958cb4*/ System.Xml.Schema.SyntaxTreeNode get_LeftChild();
                /*0x3958cbc*/ void set_LeftChild(System.Xml.Schema.SyntaxTreeNode value);
                /*0x3958cc4*/ System.Xml.Schema.SyntaxTreeNode get_RightChild();
                /*0x3958ccc*/ void set_RightChild(System.Xml.Schema.SyntaxTreeNode value);
                /*0x3958cd4*/ void ExpandTreeNoRecursive(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
                /*0x3958ea8*/ void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
            }

            class SequenceNode : System.Xml.Schema.InteriorNode
            {
                /*0x39594c8*/ SequenceNode();
                /*0x3958f14*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x3959368*/ bool get_IsNullable();
                /*0x39594c4*/ void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);

                struct SequenceConstructPosContext
                {
                    /*0x10*/ System.Xml.Schema.SequenceNode this_;
                    /*0x18*/ System.Xml.Schema.BitSet firstpos;
                    /*0x20*/ System.Xml.Schema.BitSet lastpos;
                    /*0x28*/ System.Xml.Schema.BitSet lastposLeft;
                    /*0x30*/ System.Xml.Schema.BitSet firstposRight;

                    /*0x3959304*/ SequenceConstructPosContext(System.Xml.Schema.SequenceNode node, System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos);
                }
            }

            class ChoiceNode : System.Xml.Schema.InteriorNode
            {
                static /*0x39594d0*/ void ConstructChildPos(System.Xml.Schema.SyntaxTreeNode child, System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x3958c3c*/ ChoiceNode();
                /*0x39595a4*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x39596b4*/ bool get_IsNullable();
                /*0x3959744*/ void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
            }

            class PlusNode : System.Xml.Schema.InteriorNode
            {
                /*0x3959800*/ PlusNode();
                /*0x3959748*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x39597e4*/ bool get_IsNullable();
            }

            class QmarkNode : System.Xml.Schema.InteriorNode
            {
                /*0x395982c*/ QmarkNode();
                /*0x3959808*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x3959824*/ bool get_IsNullable();
            }

            class StarNode : System.Xml.Schema.InteriorNode
            {
                /*0x39598d8*/ StarNode();
                /*0x3959834*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x39598d0*/ bool get_IsNullable();
            }

            class LeafRangeNode : System.Xml.Schema.LeafNode
            {
                /*0x18*/ decimal min;
                /*0x28*/ decimal max;
                /*0x38*/ System.Xml.Schema.BitSet nextIteration;

                /*0x39598e0*/ LeafRangeNode(decimal min, decimal max);
                /*0x3959928*/ LeafRangeNode(int pos, decimal min, decimal max);
                /*0x3959978*/ decimal get_Max();
                /*0x3959984*/ decimal get_Min();
                /*0x3959990*/ System.Xml.Schema.BitSet get_NextIteration();
                /*0x3959998*/ void set_NextIteration(System.Xml.Schema.BitSet value);
                /*0x39599a0*/ bool get_IsRangeNode();
                /*0x39599a8*/ void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
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

                static /*0x3959d7c*/ ContentValidator();
                static /*0x3959ae4*/ void AddParticleToExpected(System.Xml.Schema.XmlSchemaParticle p, System.Xml.Schema.XmlSchemaSet schemaSet, System.Collections.ArrayList particles);
                static /*0x3959b54*/ void AddParticleToExpected(System.Xml.Schema.XmlSchemaParticle p, System.Xml.Schema.XmlSchemaSet schemaSet, System.Collections.ArrayList particles, bool global);
                /*0x39599dc*/ ContentValidator(System.Xml.Schema.XmlSchemaContentType contentType);
                /*0x3959a0c*/ ContentValidator(System.Xml.Schema.XmlSchemaContentType contentType, bool isOpen, bool isEmptiable);
                /*0x3959a4c*/ System.Xml.Schema.XmlSchemaContentType get_ContentType();
                /*0x3959a54*/ bool get_PreserveWhitespace();
                /*0x3959a68*/ bool get_IsEmptiable();
                /*0x3959a70*/ bool get_IsOpen();
                /*0x3959a94*/ void set_IsOpen(bool value);
                /*0x3959a9c*/ void InitValidation(System.Xml.Schema.ValidationState context);
                /*0x3959aa0*/ object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, ref int errorCode);
                /*0x3959acc*/ bool CompleteValidation(System.Xml.Schema.ValidationState context);
                /*0x3959ad4*/ System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, bool isRequiredOnly);
                /*0x3959adc*/ System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, bool isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet);
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

                /*0x3959e90*/ ParticleContentValidator(System.Xml.Schema.XmlSchemaContentType contentType);
                /*0x3959e98*/ ParticleContentValidator(System.Xml.Schema.XmlSchemaContentType contentType, bool enableUpaCheck);
                /*0x3959f18*/ void InitValidation(System.Xml.Schema.ValidationState context);
                /*0x3959f50*/ object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, ref int errorCode);
                /*0x3959f88*/ bool CompleteValidation(System.Xml.Schema.ValidationState context);
                /*0x3959fc0*/ void Start();
                /*0x395a090*/ void OpenGroup();
                /*0x395a0b4*/ void CloseGroup();
                /*0x395a228*/ bool Exists(System.Xml.XmlQualifiedName name);
                /*0x395a260*/ void AddName(System.Xml.XmlQualifiedName name, object particle);
                /*0x395a3fc*/ void AddNamespaceList(System.Xml.Schema.NamespaceList namespaceList, object particle);
                /*0x395a308*/ void AddLeafNode(System.Xml.Schema.SyntaxTreeNode node);
                /*0x395a488*/ void AddChoice();
                /*0x395a574*/ void AddSequence();
                /*0x395a660*/ void AddStar();
                /*0x395a858*/ void AddPlus();
                /*0x395a8b4*/ void AddQMark();
                /*0x395a910*/ void AddLeafRange(decimal min, decimal max);
                /*0x395a6bc*/ void Closure(System.Xml.Schema.InteriorNode node);
                /*0x395aa08*/ System.Xml.Schema.ContentValidator Finish(bool useDFA);
                /*0x395afa4*/ System.Xml.Schema.BitSet[] CalculateTotalFollowposForRangeNodes(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos, ref System.Xml.Schema.BitSet posWithRangeTerminals);
                /*0x395b3dc*/ void CheckCMUPAWithLeafRangeNodes(System.Xml.Schema.BitSet curpos);
                /*0x395b26c*/ System.Xml.Schema.BitSet GetApplicableMinMaxFollowPos(System.Xml.Schema.BitSet curpos, System.Xml.Schema.BitSet posWithRangeTerminals, System.Xml.Schema.BitSet[] minmaxFollowPos);
                /*0x395b558*/ void CheckUniqueParticleAttribution(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos);
                /*0x395bc1c*/ void CheckUniqueParticleAttribution(System.Xml.Schema.BitSet curpos);
                /*0x395b5e0*/ int[][] BuildTransitionTable(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos, int endMarkerPos);
            }

            class DfaContentValidator : System.Xml.Schema.ContentValidator
            {
                /*0x18*/ int[][] transitionTable;
                /*0x20*/ System.Xml.Schema.SymbolsDictionary symbols;

                /*0x395bb64*/ DfaContentValidator(int[][] transitionTable, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.XmlSchemaContentType contentType, bool isOpen, bool isEmptiable);
                /*0x395bdd8*/ void InitValidation(System.Xml.Schema.ValidationState context);
                /*0x395be3c*/ object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, ref int errorCode);
                /*0x395bf4c*/ bool CompleteValidation(System.Xml.Schema.ValidationState context);
                /*0x395bf60*/ System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, bool isRequiredOnly);
                /*0x395c12c*/ System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, bool isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet);
            }

            class NfaContentValidator : System.Xml.Schema.ContentValidator
            {
                /*0x18*/ System.Xml.Schema.BitSet firstpos;
                /*0x20*/ System.Xml.Schema.BitSet[] followpos;
                /*0x28*/ System.Xml.Schema.SymbolsDictionary symbols;
                /*0x30*/ System.Xml.Schema.Positions positions;
                /*0x38*/ int endMarkerPos;

                /*0x395c2b0*/ NfaContentValidator(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions, int endMarkerPos, System.Xml.Schema.XmlSchemaContentType contentType, bool isOpen, bool isEmptiable);
                /*0x395c39c*/ void InitValidation(System.Xml.Schema.ValidationState context);
                /*0x395c470*/ object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, ref int errorCode);
                /*0x395c618*/ bool CompleteValidation(System.Xml.Schema.ValidationState context);
                /*0x395c660*/ System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, bool isRequiredOnly);
                /*0x395c844*/ System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, bool isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet);
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

                /*0x395c9c0*/ RangeContentValidator(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions, int endMarkerPos, System.Xml.Schema.XmlSchemaContentType contentType, bool isEmptiable, System.Xml.Schema.BitSet positionsWithRangeTerminals, int minmaxNodesCount);
                /*0x395cac0*/ void InitValidation(System.Xml.Schema.ValidationState context);
                /*0x395cc84*/ object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, ref int errorCode);
                /*0x395d500*/ bool CompleteValidation(System.Xml.Schema.ValidationState context);
                /*0x395d514*/ System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, bool isRequiredOnly);
                /*0x395d78c*/ System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, bool isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet);
            }

            class AllElementsContentValidator : System.Xml.Schema.ContentValidator
            {
                /*0x18*/ System.Collections.Hashtable elements;
                /*0x20*/ object[] particles;
                /*0x28*/ System.Xml.Schema.BitSet isRequired;
                /*0x30*/ int countRequired;

                /*0x395d9a0*/ AllElementsContentValidator(System.Xml.Schema.XmlSchemaContentType contentType, int size, bool isEmptiable);
                /*0x395dac8*/ bool AddElement(System.Xml.XmlQualifiedName name, object particle, bool isEmptiable);
                /*0x395dbf8*/ bool get_IsEmptiable();
                /*0x395dc18*/ void InitValidation(System.Xml.Schema.ValidationState context);
                /*0x395dcb4*/ object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, ref int errorCode);
                /*0x395ddd4*/ bool CompleteValidation(System.Xml.Schema.ValidationState context);
                /*0x395de24*/ System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, bool isRequiredOnly);
                /*0x395e1f0*/ System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, bool isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet);
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

                /*0x395e674*/ XsdSimpleValue(System.Xml.Schema.XmlSchemaSimpleType st, object value);
                /*0x395e6b8*/ System.Xml.Schema.XmlSchemaSimpleType get_XmlType();
                /*0x395e6c0*/ object get_TypedValue();
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

                /*0x395e6c8*/ RestrictionFacets();
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

                static /*0x395e6d0*/ DatatypeImplementation();
                static /*0x3963de0*/ System.Xml.Schema.XmlSchemaSimpleType get_AnySimpleType();
                static /*0x3963e38*/ System.Xml.Schema.XmlSchemaSimpleType get_UntypedAtomicType();
                static /*0x3963e90*/ System.Xml.Schema.DatatypeImplementation FromXmlTokenizedType(System.Xml.XmlTokenizedType token);
                static /*0x3963f0c*/ System.Xml.Schema.DatatypeImplementation FromXmlTokenizedTypeXsd(System.Xml.XmlTokenizedType token);
                static /*0x3963f88*/ System.Xml.Schema.DatatypeImplementation FromXdrName(string name);
                static /*0x3964048*/ System.Xml.Schema.DatatypeImplementation FromTypeName(string name);
                static /*0x3964108*/ System.Xml.Schema.XmlSchemaSimpleType StartBuiltinType(System.Xml.XmlQualifiedName qname, System.Xml.Schema.XmlSchemaDatatype dataType);
                static /*0x39641ec*/ void FinishBuiltinType(System.Xml.Schema.XmlSchemaSimpleType derivedType, System.Xml.Schema.XmlSchemaSimpleType baseType);
                static /*0x39634fc*/ void CreateBuiltinTypes();
                static /*0x3964430*/ System.Xml.Schema.XmlSchemaSimpleType GetSimpleTypeFromTypeCode(System.Xml.Schema.XmlTypeCode typeCode);
                static /*0x39644ac*/ System.Xml.Schema.XmlSchemaSimpleType GetSimpleTypeFromXsdType(System.Xml.XmlQualifiedName qname);
                static /*0x396456c*/ System.Xml.Schema.XmlSchemaSimpleType GetNormalizedStringTypeV1Compat();
                static /*0x3964704*/ System.Xml.Schema.XmlSchemaSimpleType GetTokenTypeV1Compat();
                static /*0x396489c*/ System.Xml.Schema.XmlSchemaSimpleType[] GetBuiltInTypes();
                static /*0x39648f4*/ System.Xml.Schema.XmlTypeCode GetPrimitiveTypeCode(System.Xml.Schema.XmlTypeCode typeCode);
                static /*0x3964c44*/ System.Xml.Schema.DatatypeImplementation DeriveByUnion(System.Xml.Schema.XmlSchemaSimpleType[] types, System.Xml.Schema.XmlSchemaType schemaType);
                /*0x3965a30*/ DatatypeImplementation();
                /*0x3964a24*/ System.Xml.Schema.XmlSchemaDatatype DeriveByRestriction(System.Xml.Schema.XmlSchemaObjectCollection facets, System.Xml.XmlNameTable nameTable, System.Xml.Schema.XmlSchemaType schemaType);
                /*0x3964b40*/ System.Xml.Schema.XmlSchemaDatatype DeriveByList(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x3962938*/ System.Xml.Schema.XmlSchemaDatatype DeriveByList(int minSize, System.Xml.Schema.XmlSchemaType schemaType);
                /*0x3964d74*/ void VerifySchemaValid(System.Xml.Schema.XmlSchemaObjectTable notations, System.Xml.Schema.XmlSchemaObject caller);
                /*0x3964d78*/ bool IsDerivedFrom(System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3964ff0*/ bool IsEqual(object o1, object o2);
                /*0x3965014*/ bool IsComparable(System.Xml.Schema.XmlSchemaDatatype dtype);
                /*0x3965100*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x3965108*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x3965160*/ System.Xml.Schema.XmlValueConverter get_ValueConverter();
                /*0x39651b0*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x39651b8*/ System.Type get_ValueType();
                /*0x39651e8*/ System.Xml.Schema.XmlSchemaDatatypeVariety get_Variety();
                /*0x39651f0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x39651f8*/ System.Xml.Schema.RestrictionFacets get_Restriction();
                /*0x3965200*/ bool get_HasLexicalFacets();
                /*0x3965228*/ bool get_HasValueFacets();
                /*0x3965250*/ System.Xml.Schema.DatatypeImplementation get_Base();
                /*0x1f30214*/ System.Type get_ListValueType();
                /*0x1f2ffc8*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x3965258*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x3965260*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
                /*0x3965490*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, bool createAtomicValue);
                /*0x39655d4*/ System.Exception TryParseValue(object value, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver namespaceResolver, ref object typedValue);
                /*0x3965424*/ string GetTypeName();
                /*0x39659d4*/ int Compare(byte[] value1, byte[] value2);

                class SchemaDatatypeMap : System.IComparable
                {
                    /*0x10*/ string name;
                    /*0x18*/ System.Xml.Schema.DatatypeImplementation type;
                    /*0x20*/ int parentIndex;

                    static /*0x3965a38*/ System.Xml.Schema.DatatypeImplementation op_Explicit(System.Xml.Schema.DatatypeImplementation.SchemaDatatypeMap sdm);
                    /*0x3963460*/ SchemaDatatypeMap(string name, System.Xml.Schema.DatatypeImplementation type);
                    /*0x39634a4*/ SchemaDatatypeMap(string name, System.Xml.Schema.DatatypeImplementation type, int parentIndex);
                    /*0x3965a4c*/ string get_Name();
                    /*0x3965a54*/ int get_ParentIndex();
                    /*0x3965a5c*/ int CompareTo(object obj);
                }
            }

            class Datatype_List : System.Xml.Schema.Datatype_anySimpleType
            {
                /*0x38*/ System.Xml.Schema.DatatypeImplementation itemType;
                /*0x40*/ int minListSize;

                /*0x3964bc8*/ Datatype_List(System.Xml.Schema.DatatypeImplementation type, int minListSize);
                /*0x3965a98*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x3965d34*/ int Compare(object value1, object value2);
                /*0x3965fd8*/ System.Type get_ValueType();
                /*0x3965fe8*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x3966004*/ System.Type get_ListValueType();
                /*0x3966024*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x396607c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x3966098*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x39660a0*/ System.Exception TryParseValue(object value, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver namespaceResolver, ref object typedValue);
                /*0x3966680*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_union : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                /*0x38*/ System.Xml.Schema.XmlSchemaSimpleType[] types;

                static /*0x396739c*/ Datatype_union();
                /*0x3964d04*/ Datatype_union(System.Xml.Schema.XmlSchemaSimpleType[] types);
                /*0x3966abc*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x3966ac8*/ int Compare(object value1, object value2);
                /*0x3966bcc*/ System.Type get_ValueType();
                /*0x3966c24*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x3966c2c*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x3966c84*/ System.Type get_ListValueType();
                /*0x3966cdc*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x3966ce4*/ System.Xml.Schema.XmlSchemaSimpleType[] get_BaseMemberTypes();
                /*0x3964b4c*/ bool HasAtomicMembers();
                /*0x3964f68*/ bool IsUnionBaseOf(System.Xml.Schema.DatatypeImplementation derivedType);
                /*0x3966cec*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
                /*0x3966ef0*/ System.Exception TryParseValue(object value, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_anySimpleType : System.Xml.Schema.DatatypeImplementation
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x396765c*/ Datatype_anySimpleType();
                /*0x3962430*/ Datatype_anySimpleType();
                /*0x3967450*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x39674a8*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x3967500*/ System.Type get_ValueType();
                /*0x3967558*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x3967560*/ System.Type get_ListValueType();
                /*0x39675b8*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x39675c0*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x39675c8*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x39675d0*/ int Compare(object value1, object value2);
                /*0x396762c*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_anyAtomicType : System.Xml.Schema.Datatype_anySimpleType
            {
                /*0x3963360*/ Datatype_anyAtomicType();
                /*0x3967710*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x3967768*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x3967770*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_untypedAtomicType : System.Xml.Schema.Datatype_anyAtomicType
            {
                /*0x3963408*/ Datatype_untypedAtomicType();
                /*0x3967778*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x39677d0*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x39677d8*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_string : System.Xml.Schema.Datatype_anySimpleType
            {
                /*0x3962fa4*/ Datatype_string();
                /*0x39677e0*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x39677ec*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x39677f4*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x396784c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x3967854*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x396785c*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x3967864*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_boolean : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x3967c14*/ Datatype_boolean();
                /*0x3962530*/ Datatype_boolean();
                /*0x3967950*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x396795c*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x39679b4*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x39679bc*/ System.Type get_ValueType();
                /*0x3967a14*/ System.Type get_ListValueType();
                /*0x3967a6c*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x3967a74*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x3967a7c*/ int Compare(object value1, object value2);
                /*0x3967b00*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_float : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x3967fb0*/ Datatype_float();
                /*0x3962b30*/ Datatype_float();
                /*0x3967cc8*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x3967cd4*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x3967d2c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x3967d34*/ System.Type get_ValueType();
                /*0x3967d8c*/ System.Type get_ListValueType();
                /*0x3967de4*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x3967dec*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x3967df4*/ int Compare(object value1, object value2);
                /*0x3967e64*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_double : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x396834c*/ Datatype_double();
                /*0x3962838*/ Datatype_double();
                /*0x3968064*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x3968070*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x39680c8*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x39680d0*/ System.Type get_ValueType();
                /*0x3968128*/ System.Type get_ListValueType();
                /*0x3968180*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x3968188*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x3968190*/ int Compare(object value1, object value2);
                /*0x3968200*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_decimal : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x39687a8*/ Datatype_decimal();
                /*0x39627e4*/ Datatype_decimal();
                /*0x3968400*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x396840c*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x3968464*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x396846c*/ System.Type get_ValueType();
                /*0x39684c4*/ System.Type get_ListValueType();
                /*0x396851c*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x3968524*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x396852c*/ int Compare(object value1, object value2);
                /*0x3968620*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_duration : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x3968d24*/ Datatype_duration();
                /*0x39628e0*/ Datatype_duration();
                /*0x3968980*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x396898c*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x39689e4*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x39689ec*/ System.Type get_ValueType();
                /*0x3968a44*/ System.Type get_ListValueType();
                /*0x3968a9c*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x3968aa4*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x3968aac*/ int Compare(object value1, object value2);
                /*0x3968b54*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_yearMonthDuration : System.Xml.Schema.Datatype_duration
            {
                /*0x396340c*/ Datatype_yearMonthDuration();
                /*0x3968dec*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
                /*0x3968fc0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_dayTimeDuration : System.Xml.Schema.Datatype_duration
            {
                /*0x39633b4*/ Datatype_dayTimeDuration();
                /*0x3968fc8*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
                /*0x396919c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_dateTimeBase : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                /*0x38*/ System.Xml.Schema.XsdDateTimeFlags dateTimeFlags;

                static /*0x39697f0*/ Datatype_dateTimeBase();
                /*0x3969210*/ Datatype_dateTimeBase(System.Xml.Schema.XsdDateTimeFlags dateTimeFlags);
                /*0x39691a4*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x39691b0*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x3969208*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x3969278*/ System.Type get_ValueType();
                /*0x39692d0*/ System.Type get_ListValueType();
                /*0x3969328*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x3969330*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x3969338*/ int Compare(object value1, object value2);
                /*0x3969484*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_dateTimeNoTimeZone : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x39626dc*/ Datatype_dateTimeNoTimeZone();
            }

            class Datatype_dateTimeTimeZone : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x3962734*/ Datatype_dateTimeTimeZone();
            }

            class Datatype_dateTime : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x3962684*/ Datatype_dateTime();
            }

            class Datatype_timeNoTimeZone : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x3963050*/ Datatype_timeNoTimeZone();
            }

            class Datatype_timeTimeZone : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x39630a8*/ Datatype_timeTimeZone();
            }

            class Datatype_time : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x3962ff8*/ Datatype_time();
                /*0x39698b8*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_date : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x396262c*/ Datatype_date();
                /*0x39698c0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_yearMonth : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x3963300*/ Datatype_yearMonth();
                /*0x39698c8*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_year : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x39632a8*/ Datatype_year();
                /*0x39698d0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_monthDay : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x3962d3c*/ Datatype_monthDay();
                /*0x39698d8*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_day : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x396278c*/ Datatype_day();
                /*0x39698e0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_month : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x3962ce4*/ Datatype_month();
                /*0x39698e8*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_hexBinary : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x3969ca8*/ Datatype_hexBinary();
                /*0x3962bd8*/ Datatype_hexBinary();
                /*0x39698f0*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x39698fc*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x3969954*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x396995c*/ System.Type get_ValueType();
                /*0x39699b4*/ System.Type get_ListValueType();
                /*0x3969a0c*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x3969a14*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x3969a1c*/ int Compare(object value1, object value2);
                /*0x3969ac4*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_base64Binary : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x396a124*/ Datatype_base64Binary();
                /*0x39624dc*/ Datatype_base64Binary();
                /*0x3969d70*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x3969d7c*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x3969dd4*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x3969ddc*/ System.Type get_ValueType();
                /*0x3969e34*/ System.Type get_ListValueType();
                /*0x3969e8c*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x3969e94*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x3969e9c*/ int Compare(object value1, object value2);
                /*0x3969f44*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_anyURI : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x396a798*/ Datatype_anyURI();
                /*0x3962488*/ Datatype_anyURI();
                /*0x396a1ec*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x396a1f8*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x396a250*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x396a258*/ System.Type get_ValueType();
                /*0x396a2b0*/ bool get_HasValueFacets();
                /*0x396a2b8*/ System.Type get_ListValueType();
                /*0x396a310*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x396a318*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x396a320*/ int Compare(object value1, object value2);
                /*0x396a3e8*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_QName : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x396abf4*/ Datatype_QName();
                /*0x3962ea8*/ Datatype_QName();
                /*0x396a860*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x396a86c*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x396a8c4*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x396a8cc*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x396a8d4*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x396a8dc*/ System.Type get_ValueType();
                /*0x396a934*/ System.Type get_ListValueType();
                /*0x396a98c*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x396a994*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_normalizedString : System.Xml.Schema.Datatype_string
            {
                /*0x3962dfc*/ Datatype_normalizedString();
                /*0x396acbc*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x396acc4*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x396accc*/ bool get_HasValueFacets();
            }

            class Datatype_normalizedStringV1Compat : System.Xml.Schema.Datatype_string
            {
                /*0x3963358*/ Datatype_normalizedStringV1Compat();
                /*0x396acd4*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x396acdc*/ bool get_HasValueFacets();
            }

            class Datatype_token : System.Xml.Schema.Datatype_normalizedString
            {
                /*0x3963100*/ Datatype_token();
                /*0x396ace4*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x396acec*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
            }

            class Datatype_tokenV1Compat : System.Xml.Schema.Datatype_normalizedStringV1Compat
            {
                /*0x396335c*/ Datatype_tokenV1Compat();
                /*0x396acf4*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_language : System.Xml.Schema.Datatype_token
            {
                /*0x3962cdc*/ Datatype_language();
                /*0x396acfc*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_NMTOKEN : System.Xml.Schema.Datatype_token
            {
                /*0x3962df0*/ Datatype_NMTOKEN();
                /*0x396ad04*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x396ad0c*/ System.Xml.XmlTokenizedType get_TokenizedType();
            }

            class Datatype_Name : System.Xml.Schema.Datatype_token
            {
                /*0x3962d94*/ Datatype_Name();
                /*0x396ad14*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_NCName : System.Xml.Schema.Datatype_Name
            {
                /*0x3962d98*/ Datatype_NCName();
                /*0x396ad1c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x396ad24*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_ID : System.Xml.Schema.Datatype_NCName
            {
                /*0x3962c2c*/ Datatype_ID();
                /*0x396ae34*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x396ae3c*/ System.Xml.XmlTokenizedType get_TokenizedType();
            }

            class Datatype_IDREF : System.Xml.Schema.Datatype_NCName
            {
                /*0x3962c30*/ Datatype_IDREF();
                /*0x396ae44*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x396ae4c*/ System.Xml.XmlTokenizedType get_TokenizedType();
            }

            class Datatype_ENTITY : System.Xml.Schema.Datatype_NCName
            {
                /*0x3962934*/ Datatype_ENTITY();
                /*0x396ae54*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x396ae5c*/ System.Xml.XmlTokenizedType get_TokenizedType();
            }

            class Datatype_NOTATION : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x396b404*/ Datatype_NOTATION();
                /*0x3962e00*/ Datatype_NOTATION();
                /*0x396ae64*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x396ae70*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x396aec8*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x396aed0*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x396aed8*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x396aee0*/ System.Type get_ValueType();
                /*0x396af38*/ System.Type get_ListValueType();
                /*0x396af90*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x396af98*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
                /*0x396b1f8*/ void VerifySchemaValid(System.Xml.Schema.XmlSchemaObjectTable notations, System.Xml.Schema.XmlSchemaObject caller);
            }

            class Datatype_integer : System.Xml.Schema.Datatype_decimal
            {
                /*0x3962c88*/ Datatype_integer();
                /*0x396b4cc*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x396b4d4*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_nonPositiveInteger : System.Xml.Schema.Datatype_integer
            {
                static /*0x0*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x396b6a0*/ Datatype_nonPositiveInteger();
                /*0x3962df8*/ Datatype_nonPositiveInteger();
                /*0x396b638*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x396b690*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x396b698*/ bool get_HasValueFacets();
            }

            class Datatype_negativeInteger : System.Xml.Schema.Datatype_nonPositiveInteger
            {
                static /*0x0*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x396b818*/ Datatype_negativeInteger();
                /*0x3962d9c*/ Datatype_negativeInteger();
                /*0x396b7b8*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x396b810*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_long : System.Xml.Schema.Datatype_integer
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x396bc04*/ Datatype_long();
                /*0x3962ce0*/ Datatype_long();
                /*0x396b930*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x396b988*/ bool get_HasValueFacets();
                /*0x396b990*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x396b998*/ int Compare(object value1, object value2);
                /*0x396ba08*/ System.Type get_ValueType();
                /*0x396ba60*/ System.Type get_ListValueType();
                /*0x396bab8*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_int : System.Xml.Schema.Datatype_long
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x396c034*/ Datatype_int();
                /*0x3962c34*/ Datatype_int();
                /*0x396bd68*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x396bdc0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x396bdc8*/ int Compare(object value1, object value2);
                /*0x396be38*/ System.Type get_ValueType();
                /*0x396be90*/ System.Type get_ListValueType();
                /*0x396bee8*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_short : System.Xml.Schema.Datatype_int
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x396c464*/ Datatype_short();
                /*0x3962f50*/ Datatype_short();
                /*0x396c198*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x396c1f0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x396c1f8*/ int Compare(object value1, object value2);
                /*0x396c268*/ System.Type get_ValueType();
                /*0x396c2c0*/ System.Type get_ListValueType();
                /*0x396c318*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_byte : System.Xml.Schema.Datatype_short
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x396c894*/ Datatype_byte();
                /*0x3962584*/ Datatype_byte();
                /*0x396c5c8*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x396c620*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x396c628*/ int Compare(object value1, object value2);
                /*0x396c698*/ System.Type get_ValueType();
                /*0x396c6f0*/ System.Type get_ListValueType();
                /*0x396c748*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_nonNegativeInteger : System.Xml.Schema.Datatype_integer
            {
                static /*0x0*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x396ca60*/ Datatype_nonNegativeInteger();
                /*0x3962df4*/ Datatype_nonNegativeInteger();
                /*0x396c9f8*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x396ca50*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x396ca58*/ bool get_HasValueFacets();
            }

            class Datatype_unsignedLong : System.Xml.Schema.Datatype_nonNegativeInteger
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x396ce8c*/ Datatype_unsignedLong();
                /*0x39631ac*/ Datatype_unsignedLong();
                /*0x396cb78*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x396cbd0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x396cbd8*/ int Compare(object value1, object value2);
                /*0x396cc48*/ System.Type get_ValueType();
                /*0x396cca0*/ System.Type get_ListValueType();
                /*0x396ccf8*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_unsignedInt : System.Xml.Schema.Datatype_unsignedLong
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x396d2d4*/ Datatype_unsignedInt();
                /*0x3963158*/ Datatype_unsignedInt();
                /*0x396d008*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x396d060*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x396d068*/ int Compare(object value1, object value2);
                /*0x396d0d8*/ System.Type get_ValueType();
                /*0x396d130*/ System.Type get_ListValueType();
                /*0x396d188*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_unsignedShort : System.Xml.Schema.Datatype_unsignedInt
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x396d71c*/ Datatype_unsignedShort();
                /*0x3963200*/ Datatype_unsignedShort();
                /*0x396d450*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x396d4a8*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x396d4b0*/ int Compare(object value1, object value2);
                /*0x396d520*/ System.Type get_ValueType();
                /*0x396d578*/ System.Type get_ListValueType();
                /*0x396d5d0*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_unsignedByte : System.Xml.Schema.Datatype_unsignedShort
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x396db64*/ Datatype_unsignedByte();
                /*0x3963104*/ Datatype_unsignedByte();
                /*0x396d898*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x396d8f0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x396d8f8*/ int Compare(object value1, object value2);
                /*0x396d968*/ System.Type get_ValueType();
                /*0x396d9c0*/ System.Type get_ListValueType();
                /*0x396da18*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_positiveInteger : System.Xml.Schema.Datatype_nonNegativeInteger
            {
                static /*0x0*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x396dd40*/ Datatype_positiveInteger();
                /*0x3962e54*/ Datatype_positiveInteger();
                /*0x396dce0*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x396dd38*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_doubleXdr : System.Xml.Schema.Datatype_double
            {
                /*0x396288c*/ Datatype_doubleXdr();
                /*0x396de58*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
            }

            class Datatype_floatXdr : System.Xml.Schema.Datatype_float
            {
                /*0x3962b84*/ Datatype_floatXdr();
                /*0x396e034*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
            }

            class Datatype_QNameXdr : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x396e570*/ Datatype_QNameXdr();
                /*0x3962efc*/ Datatype_QNameXdr();
                /*0x396e210*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x396e218*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
                /*0x396e4c0*/ System.Type get_ValueType();
                /*0x396e518*/ System.Type get_ListValueType();
            }

            class Datatype_ENUMERATION : System.Xml.Schema.Datatype_NMTOKEN
            {
                /*0x3962ad8*/ Datatype_ENUMERATION();
                /*0x396e638*/ System.Xml.XmlTokenizedType get_TokenizedType();
            }

            class Datatype_char : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x396ea34*/ Datatype_char();
                /*0x39625d8*/ Datatype_char();
                /*0x396e640*/ System.Type get_ValueType();
                /*0x396e698*/ System.Type get_ListValueType();
                /*0x396e6f0*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x396e6f8*/ int Compare(object value1, object value2);
                /*0x396e77c*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
                /*0x396e97c*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_fixed : System.Xml.Schema.Datatype_decimal
            {
                /*0x3962adc*/ Datatype_fixed();
                /*0x396eae8*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
                /*0x396f08c*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_uuid : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x396f634*/ Datatype_uuid();
                /*0x3963254*/ Datatype_uuid();
                /*0x396f208*/ System.Type get_ValueType();
                /*0x396f260*/ System.Type get_ListValueType();
                /*0x396f2b8*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x396f2c0*/ int Compare(object value1, object value2);
                /*0x396f35c*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
                /*0x396f568*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
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

                static /*0x3971bd0*/ DtdValidator();
                static /*0x3971564*/ void SetDefaultTypedValue(System.Xml.Schema.SchemaAttDef attdef, System.Xml.IDtdParserAdapter readerAdapter);
                static /*0x3971860*/ void CheckDefaultValue(System.Xml.Schema.SchemaAttDef attdef, System.Xml.Schema.SchemaInfo sinfo, System.Xml.IValidationEventHandling eventHandling, string baseUriStr);
                /*0x396f6fc*/ DtdValidator(System.Xml.XmlValidatingReaderImpl reader, System.Xml.IValidationEventHandling eventHandling, bool processIdentityConstraints);
                /*0x396f7a4*/ void Init();
                /*0x396fa38*/ void Validate();
                /*0x396fd60*/ bool MeetsStandAloneConstraint();
                /*0x396fe00*/ void ValidatePIComment();
                /*0x396fc58*/ void ValidateElement();
                /*0x39701a4*/ void ValidateChildElement();
                /*0x397040c*/ void ValidateStartElement();
                /*0x3970dc0*/ void ValidateEndStartElement();
                /*0x39702ec*/ void ProcessElement();
                /*0x3970f7c*/ void CompleteValidation();
                /*0x3970004*/ void ValidateEndElement();
                /*0x39711a0*/ bool get_PreserveWhitespace();
                /*0x39711d8*/ void ProcessTokenizedType(System.Xml.XmlTokenizedType ttype, string name);
                /*0x3970868*/ void CheckValue(string value, System.Xml.Schema.SchemaAttDef attdef);
                /*0x397140c*/ void AddID(string name, object node);
                /*0x39714a8*/ object FindId(string name);
                /*0x396feb0*/ bool GenEntity(System.Xml.XmlQualifiedName qname);
                /*0x39714c4*/ System.Xml.Schema.SchemaEntity GetEntity(System.Xml.XmlQualifiedName qname, bool fParameterEntity);
                /*0x397107c*/ void CheckForwardRefs();
                /*0x396f910*/ void Push(System.Xml.XmlQualifiedName elementName);
                /*0x3970fc4*/ bool Pop();

                class NamespaceManager : System.Xml.XmlNamespaceManager
                {
                    /*0x3971c4c*/ NamespaceManager();
                    /*0x3971c54*/ string LookupNamespace(string prefix);
                }
            }

            class FacetsChecker
            {
                static /*0x3974a30*/ decimal Power(int x, int y);
                /*0x3974b5c*/ FacetsChecker();
                /*0x3971c5c*/ System.Exception CheckLexicalFacets(ref string parseString, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3971ee8*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3971ef0*/ System.Exception CheckValueFacets(decimal value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3971ef8*/ System.Exception CheckValueFacets(long value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3971f00*/ System.Exception CheckValueFacets(int value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3971f08*/ System.Exception CheckValueFacets(short value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3971f10*/ System.Exception CheckValueFacets(System.DateTime value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3971f18*/ System.Exception CheckValueFacets(double value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3971f20*/ System.Exception CheckValueFacets(float value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3971f28*/ System.Exception CheckValueFacets(string value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3971f30*/ System.Exception CheckValueFacets(byte[] value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3971f38*/ System.Exception CheckValueFacets(System.TimeSpan value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3971f40*/ System.Exception CheckValueFacets(System.Xml.XmlQualifiedName value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3971ca0*/ void CheckWhitespaceFacets(ref string s, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3971d98*/ System.Exception CheckPatternFacets(System.Xml.Schema.RestrictionFacets restriction, string value);
                /*0x3971f48*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3971f50*/ System.Xml.Schema.RestrictionFacets ConstructRestriction(System.Xml.Schema.DatatypeImplementation datatype, System.Xml.Schema.XmlSchemaObjectCollection facets, System.Xml.XmlNameTable nameTable);

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

                    static /*0x3975938*/ FacetsCompiler();
                    static /*0x3975298*/ string Preprocess(string pattern);
                    /*0x39723c0*/ FacetsCompiler(System.Xml.Schema.DatatypeImplementation baseDatatype, System.Xml.Schema.RestrictionFacets restriction);
                    /*0x397260c*/ void CompileLengthFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x3972960*/ void CompileMinLengthFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x3972c78*/ void CompileMaxLengthFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x3972f90*/ void CompilePatternFacet(System.Xml.Schema.XmlSchemaPatternFacet facet);
                    /*0x3973114*/ void CompileEnumerationFacet(System.Xml.Schema.XmlSchemaFacet facet, System.Xml.IXmlNamespaceResolver nsmgr, System.Xml.XmlNameTable nameTable);
                    /*0x397326c*/ void CompileWhitespaceFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x397397c*/ void CompileMaxInclusiveFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x3973b4c*/ void CompileMaxExclusiveFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x39735dc*/ void CompileMinInclusiveFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x39737ac*/ void CompileMinExclusiveFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x3973d1c*/ void CompileTotalDigitsFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x397402c*/ void CompileFractionDigitsFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x39742e0*/ void FinishFacetCompile();
                    /*0x3974e00*/ void CheckValue(object value, System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x3974654*/ void CompileFacetCombinations();
                    /*0x39754f4*/ void CopyFacetsFromBaseType();
                    /*0x3974c54*/ object ParseFacetValue(System.Xml.Schema.XmlSchemaDatatype datatype, System.Xml.Schema.XmlSchemaFacet facet, string code, System.Xml.IXmlNamespaceResolver nsmgr, System.Xml.XmlNameTable nameTable);
                    /*0x3974b64*/ void CheckProhibitedFlag(System.Xml.Schema.XmlSchemaFacet facet, System.Xml.Schema.RestrictionFlags flag, string errorCode);
                    /*0x3974be4*/ void CheckDupFlag(System.Xml.Schema.XmlSchemaFacet facet, System.Xml.Schema.RestrictionFlags flag, string errorCode);
                    /*0x3974d98*/ void SetFlag(System.Xml.Schema.XmlSchemaFacet facet, System.Xml.Schema.RestrictionFlags flag);
                    /*0x3975900*/ void SetFlag(System.Xml.Schema.RestrictionFlags flag);

                    struct Map
                    {
                        /*0x10*/ char match;
                        /*0x18*/ string replacement;

                        /*0x3975c44*/ Map(char m, string r);
                    }
                }
            }

            class Numeric10FacetsChecker : System.Xml.Schema.FacetsChecker
            {
                static /*0x0*/ char[] signs;
                /*0x10*/ decimal maxValue;
                /*0x20*/ decimal minValue;

                static /*0x3976618*/ Numeric10FacetsChecker();
                /*0x3968940*/ Numeric10FacetsChecker(decimal minVal, decimal maxVal);
                /*0x3975c54*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3975cc4*/ System.Exception CheckValueFacets(decimal value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x39763f0*/ System.Exception CheckValueFacets(long value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x397647c*/ System.Exception CheckValueFacets(int value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3976508*/ System.Exception CheckValueFacets(short value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3976594*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x39762cc*/ bool MatchEnumeration(decimal value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlValueConverter valueConverter);
                /*0x396ee00*/ System.Exception CheckTotalAndFractionDigits(decimal value, int totalDigits, int fractionDigits, bool checkTotal, bool checkFraction);
            }

            class Numeric2FacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x3962418*/ Numeric2FacetsChecker();
                /*0x39766b8*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3976718*/ System.Exception CheckValueFacets(double value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3976a88*/ System.Exception CheckValueFacets(float value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3976a98*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x39769c4*/ bool MatchEnumeration(double value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlValueConverter valueConverter);
            }

            class DurationFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x3962428*/ DurationFacetsChecker();
                /*0x3976b10*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3976c18*/ System.Exception CheckValueFacets(System.TimeSpan value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3977084*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3976f6c*/ bool MatchEnumeration(System.TimeSpan value, System.Collections.ArrayList enumeration);
            }

            class DateTimeFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x3962420*/ DateTimeFacetsChecker();
                /*0x39770fc*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3977160*/ System.Exception CheckValueFacets(System.DateTime value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3977688*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3977548*/ bool MatchEnumeration(System.DateTime value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
            }

            class StringFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                static /*0x0*/ System.Text.RegularExpressions.Regex languagePattern;

                static /*0x39776e4*/ System.Text.RegularExpressions.Regex get_LanguagePattern();
                /*0x3962410*/ StringFacetsChecker();
                /*0x3977794*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x39777f4*/ System.Exception CheckValueFacets(string value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x396a570*/ System.Exception CheckValueFacets(string value, System.Xml.Schema.XmlSchemaDatatype datatype, bool verifyUri);
                /*0x3977c58*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3977a88*/ bool MatchEnumeration(string value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x39777fc*/ System.Exception CheckBuiltInFacets(string s, System.Xml.Schema.XmlTypeCode typeCode, bool verifyUri);
            }

            class QNameFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x381902c*/ QNameFacetsChecker();
                /*0x3818b1c*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3818c3c*/ System.Exception CheckValueFacets(System.Xml.XmlQualifiedName value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3818f24*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3818e10*/ bool MatchEnumeration(System.Xml.XmlQualifiedName value, System.Collections.ArrayList enumeration);
            }

            class MiscFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x3819034*/ MiscFacetsChecker();
            }

            class BinaryFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x3819434*/ BinaryFacetsChecker();
                /*0x381903c*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x38190cc*/ System.Exception CheckValueFacets(byte[] value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x38193b0*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x381928c*/ bool MatchEnumeration(byte[] value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
            }

            class ListFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x3819710*/ ListFacetsChecker();
                /*0x381943c*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3819654*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
            }

            class UnionFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x38198c0*/ UnionFacetsChecker();
                /*0x3819718*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x3819804*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
            }

            interface IXmlSchemaInfo
            {
                /*0x1f2ffc8*/ System.Xml.Schema.XmlSchemaValidity get_Validity();
                /*0x1f2fe14*/ bool get_IsDefault();
                /*0x1f2fe14*/ bool get_IsNil();
                /*0x1f30214*/ System.Xml.Schema.XmlSchemaSimpleType get_MemberType();
                /*0x1f30214*/ System.Xml.Schema.XmlSchemaType get_SchemaType();
                /*0x1f30214*/ System.Xml.Schema.XmlSchemaElement get_SchemaElement();
                /*0x1f30214*/ System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute();
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

                static /*0x38229d8*/ XmlSchemaInference();
                static /*0x38212e8*/ int InferSimpleType(string s, ref bool bNeedsRangeCheck);
                static /*0x38228c4*/ int DateTime(string s, bool bDate, bool bTime);
                static /*0x381dfe0*/ int GetSchemaType(System.Xml.XmlQualifiedName qname);
                /*0x38198e0*/ XmlSchemaInference();
                /*0x38198c8*/ void set_Occurrence(System.Xml.Schema.XmlSchemaInference.InferenceOption value);
                /*0x38198d0*/ System.Xml.Schema.XmlSchemaInference.InferenceOption get_Occurrence();
                /*0x38198d8*/ void set_TypeInference(System.Xml.Schema.XmlSchemaInference.InferenceOption value);
                /*0x3819a1c*/ System.Xml.Schema.XmlSchemaSet InferSchema(System.Xml.XmlReader instanceDocument);
                /*0x3819a90*/ System.Xml.Schema.XmlSchemaSet InferSchema1(System.Xml.XmlReader instanceDocument, System.Xml.Schema.XmlSchemaSet schemas);
                /*0x381bf20*/ System.Xml.Schema.XmlSchemaAttribute AddAttribute(string localName, string prefix, string childURI, string attrValue, bool bCreatingNewType, System.Xml.Schema.XmlSchema parentSchema, System.Xml.Schema.XmlSchemaObjectCollection addLocation, System.Xml.Schema.XmlSchemaObjectTable compiledAttributes);
                /*0x381e7b4*/ System.Xml.Schema.XmlSchema CreateXmlSchema(string targetNS);
                /*0x381a4a4*/ System.Xml.Schema.XmlSchemaElement AddElement(string localName, string prefix, string childURI, System.Xml.Schema.XmlSchema parentSchema, System.Xml.Schema.XmlSchemaObjectCollection addLocation, int positionWithinCollection);
                /*0x381aab0*/ void InferElement(System.Xml.Schema.XmlSchemaElement xse, bool bCreatingNewType, System.Xml.Schema.XmlSchema parentSchema);
                /*0x381f484*/ System.Xml.Schema.XmlSchemaSimpleContentExtension CheckSimpleContentExtension(System.Xml.Schema.XmlSchemaComplexType ct);
                /*0x381ebbc*/ System.Xml.Schema.XmlSchemaType GetEffectiveSchemaType(System.Xml.Schema.XmlSchemaElement elem, bool bCreatingNewType);
                /*0x381fa10*/ System.Xml.Schema.XmlSchemaElement FindMatchingElement(bool bCreatingNewType, System.Xml.XmlReader xtr, System.Xml.Schema.XmlSchemaComplexType ct, ref int lastUsedSeqItem, ref bool bParticleChanged, System.Xml.Schema.XmlSchema parentSchema, bool setMaxoccurs);
                /*0x381ecf4*/ void ProcessAttributes(ref System.Xml.Schema.XmlSchemaElement xse, System.Xml.Schema.XmlSchemaType effectiveSchemaType, bool bCreatingNewType, System.Xml.Schema.XmlSchema parentSchema);
                /*0x381f974*/ void MoveAttributes(System.Xml.Schema.XmlSchemaSimpleContentExtension scExtension, System.Xml.Schema.XmlSchemaComplexType ct);
                /*0x381f5bc*/ void MoveAttributes(System.Xml.Schema.XmlSchemaComplexType ct, System.Xml.Schema.XmlSchemaSimpleContentExtension simpleContentExtension, bool bCreatingNewType);
                /*0x381cadc*/ System.Xml.Schema.XmlSchemaAttribute FindAttribute(System.Collections.ICollection attributes, string attrName);
                /*0x381e850*/ System.Xml.Schema.XmlSchemaElement FindGlobalElement(string namespaceURI, string localName, ref System.Xml.Schema.XmlSchema parentSchema);
                /*0x3820c5c*/ System.Xml.Schema.XmlSchemaElement FindElement(System.Xml.Schema.XmlSchemaObjectCollection elements, string elementName);
                /*0x381c740*/ System.Xml.Schema.XmlSchemaAttribute FindAttributeRef(System.Collections.ICollection attributes, string attributeName, string nsURI);
                /*0x3820d8c*/ System.Xml.Schema.XmlSchemaElement FindElementRef(System.Xml.Schema.XmlSchemaObjectCollection elements, string elementName, string nsURI);
                /*0x381f3f4*/ void MakeExistingAttributesOptional(System.Xml.Schema.XmlSchemaComplexType ct, System.Xml.Schema.XmlSchemaObjectCollection attributesInInstance);
                /*0x38211c4*/ void SwitchUseToOptional(System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaObjectCollection attributesInInstance);
                /*0x381ce30*/ System.Xml.XmlQualifiedName RefineSimpleType(string s, ref int iTypeFlags);
                /*0x3820eec*/ System.Xml.Schema.XmlSchemaElement CreateNewElementforChoice(System.Xml.Schema.XmlSchemaElement copyElement);
                /*0x3820a94*/ void SetMinMaxOccurs(System.Xml.Schema.XmlSchemaElement el, bool setMaxOccurs);

                enum InferenceOption
                {
                    Restricted = 0,
                    Relaxed = 1,
                }
            }

            class XmlSchemaInferenceException : System.Xml.Schema.XmlSchemaException
            {
                /*0x38234bc*/ XmlSchemaInferenceException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x38234cc*/ XmlSchemaInferenceException();
                /*0x3821110*/ XmlSchemaInferenceException(string res, string arg);
                /*0x381a470*/ XmlSchemaInferenceException(string res, int lineNumber, int linePosition);
                /*0x38234c4*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            class NamespaceList
            {
                /*0x10*/ System.Xml.Schema.NamespaceList.ListType type;
                /*0x18*/ System.Collections.Hashtable set;
                /*0x20*/ string targetNamespace;

                static /*0x3823e80*/ bool IsSubset(System.Xml.Schema.NamespaceList sub, System.Xml.Schema.NamespaceList super);
                static /*0x3824220*/ System.Xml.Schema.NamespaceList Union(System.Xml.Schema.NamespaceList o1, System.Xml.Schema.NamespaceList o2, bool v1Compat);
                static /*0x3824890*/ System.Xml.Schema.NamespaceList Intersection(System.Xml.Schema.NamespaceList o1, System.Xml.Schema.NamespaceList o2, bool v1Compat);
                /*0x38234d8*/ NamespaceList();
                /*0x38234e0*/ NamespaceList(string namespaces, string targetNamespace);
                /*0x3823788*/ System.Xml.Schema.NamespaceList Clone();
                /*0x38238cc*/ System.Xml.Schema.NamespaceList.ListType get_Type();
                /*0x38238d4*/ string get_Excluded();
                /*0x38238dc*/ System.Collections.ICollection get_Enumerate();
                /*0x3823940*/ bool Allows(string ns);
                /*0x38239c4*/ bool Allows(System.Xml.XmlQualifiedName qname);
                /*0x38239e0*/ string ToString();
                /*0x3824750*/ System.Xml.Schema.NamespaceList CompareSetToOther(System.Xml.Schema.NamespaceList other);
                /*0x3824dc4*/ void RemoveNamespace(string tns);

                enum ListType
                {
                    Any = 0,
                    Other = 1,
                    Set = 2,
                }
            }

            class NamespaceListV1Compat : System.Xml.Schema.NamespaceList
            {
                /*0x3824e24*/ NamespaceListV1Compat(string namespaces, string targetNamespace);
                /*0x3824e28*/ bool Allows(string ns);
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

                /*0x3824e4c*/ Parser(System.Xml.Schema.SchemaType schemaType, System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler);
                /*0x3824f48*/ System.Xml.Schema.SchemaType Parse(System.Xml.XmlReader reader, string targetNamespace);
                /*0x3824f98*/ void StartParsing(System.Xml.XmlReader reader, string targetNamespace);
                /*0x3825a64*/ bool CheckSchemaRoot(System.Xml.Schema.SchemaType rootType, ref string code);
                /*0x3825b80*/ System.Xml.Schema.SchemaType FinishParsing();
                /*0x3825b88*/ System.Xml.Schema.XmlSchema get_XmlSchema();
                /*0x3825b90*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x3825b98*/ System.Xml.Schema.SchemaInfo get_XdrSchema();
                /*0x38253d0*/ bool ParseReaderNode();
                /*0x3825ba0*/ void ProcessAppInfoDocMarkup(bool root);
                /*0x3825e1c*/ System.Xml.XmlElement LoadElementNode(bool root);
                /*0x3826360*/ System.Xml.XmlAttribute CreateXmlNsAttribute(string prefix, string value);
                /*0x38261ec*/ System.Xml.XmlAttribute LoadAttributeNode();
                /*0x3826470*/ System.Xml.XmlEntityReference LoadEntityReferenceInAttribute();
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

                /*0x3826658*/ RedefineEntry(System.Xml.Schema.XmlSchemaRedefine external, System.Xml.Schema.XmlSchema schema);
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

                static /*0x3829adc*/ System.Xml.Schema.XmlSchema GetBuildInSchema();
                static /*0x382d36c*/ System.Xml.Schema.XmlSchema GetParentSchema(System.Xml.Schema.XmlSchemaObject currentSchemaObject);
                /*0x382669c*/ Preprocessor(System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler, System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings);
                /*0x382679c*/ bool Execute(System.Xml.Schema.XmlSchema schema, string targetNamespace, bool loadExternals);
                /*0x3829a08*/ void Cleanup(System.Xml.Schema.XmlSchema schema);
                /*0x382a0dc*/ void CleanupRedefine(System.Xml.Schema.XmlSchemaExternal include);
                /*0x382a17c*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x382a184*/ void set_ReaderSettings(System.Xml.XmlReaderSettings value);
                /*0x382a18c*/ void set_SchemaLocations(System.Collections.Hashtable value);
                /*0x382a194*/ void set_ChameleonSchemas(System.Collections.Hashtable value);
                /*0x382a19c*/ System.Xml.Schema.XmlSchema get_RootSchema();
                /*0x3827a68*/ void BuildSchemaList(System.Xml.Schema.XmlSchema schema);
                /*0x3826ddc*/ void LoadExternals(System.Xml.Schema.XmlSchema schema);
                /*0x382a208*/ void BuildRefNamespaces(System.Xml.Schema.XmlSchema schema);
                /*0x382a41c*/ void ParseUri(string uri, string code, System.Xml.Schema.XmlSchemaObject sourceSchemaObject);
                /*0x3827bd4*/ void Preprocess(System.Xml.Schema.XmlSchema schema, string targetNamespace, System.Collections.ArrayList imports);
                /*0x382aa28*/ void CopyIncludedComponents(System.Xml.Schema.XmlSchema includedSchema, System.Xml.Schema.XmlSchema schema);
                /*0x3828e40*/ void PreprocessRedefine(System.Xml.Schema.RedefineEntry redefineEntry);
                /*0x382d400*/ void GetIncludedSet(System.Xml.Schema.XmlSchema schema, System.Collections.ArrayList includesList);
                /*0x382a91c*/ void SetSchemaDefaults(System.Xml.Schema.XmlSchema schema);
                /*0x382db50*/ int CountGroupSelfReference(System.Xml.Schema.XmlSchemaObjectCollection items, System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaGroup redefined);
                /*0x382d52c*/ void CheckRefinedGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x382d5cc*/ void CheckRefinedAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x382da44*/ void CheckRefinedSimpleType(System.Xml.Schema.XmlSchemaSimpleType stype);
                /*0x382d724*/ void CheckRefinedComplexType(System.Xml.Schema.XmlSchemaComplexType ctype);
                /*0x382bb64*/ void PreprocessAttribute(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x382e330*/ void PreprocessLocalAttribute(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x382e100*/ void PreprocessAttributeContent(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x382bcd4*/ void PreprocessAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x382cc78*/ void PreprocessElement(System.Xml.Schema.XmlSchemaElement element);
                /*0x382edb8*/ void PreprocessLocalElement(System.Xml.Schema.XmlSchemaElement element);
                /*0x382ea80*/ void PreprocessElementContent(System.Xml.Schema.XmlSchemaElement element);
                /*0x382f130*/ void PreprocessIdentityConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint constraint);
                /*0x382c690*/ void PreprocessSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType, bool local);
                /*0x382bdd8*/ void PreprocessComplexType(System.Xml.Schema.XmlSchemaComplexType complexType, bool local);
                /*0x382cecc*/ void PreprocessGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x382d09c*/ void PreprocessNotation(System.Xml.Schema.XmlSchemaNotation notation);
                /*0x382f48c*/ void PreprocessParticle(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x382e708*/ void PreprocessAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute, System.Xml.Schema.XmlSchemaObject parent);
                /*0x382a61c*/ void ValidateIdAttribute(System.Xml.Schema.XmlSchemaObject xso);
                /*0x382de40*/ void ValidateNameAttribute(System.Xml.Schema.XmlSchemaObject xso);
                /*0x382e4ec*/ void ValidateQNameAttribute(System.Xml.Schema.XmlSchemaObject xso, string attributeName, System.Xml.XmlQualifiedName value);
                /*0x382a1a4*/ System.Uri ResolveSchemaLocationUri(System.Xml.Schema.XmlSchema enclosingSchema, string location);
                /*0x382a1e4*/ object GetSchemaEntity(System.Uri ruri);
                /*0x3826c9c*/ System.Xml.Schema.XmlSchema GetChameleonSchema(string targetNamespace, System.Xml.Schema.XmlSchema schema);
                /*0x382a560*/ void SetParent(System.Xml.Schema.XmlSchemaObject child, System.Xml.Schema.XmlSchemaObject parent);
                /*0x382a57c*/ void PreprocessAnnotation(System.Xml.Schema.XmlSchemaObject schemaObject);
                /*0x382d2f4*/ void PreprocessAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
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

                static /*0x38301f8*/ SchemaAttDef();
                /*0x382fd7c*/ SchemaAttDef(System.Xml.XmlQualifiedName name, string prefix);
                /*0x382fd84*/ SchemaAttDef(System.Xml.XmlQualifiedName name);
                /*0x382fd90*/ SchemaAttDef();
                /*0x382fd98*/ string System.Xml.IDtdAttributeInfo.get_Prefix();
                /*0x382fda0*/ string System.Xml.IDtdAttributeInfo.get_LocalName();
                /*0x382fdb8*/ int System.Xml.IDtdAttributeInfo.get_LineNumber();
                /*0x382fdc0*/ int System.Xml.IDtdAttributeInfo.get_LinePosition();
                /*0x382fdc8*/ bool System.Xml.IDtdAttributeInfo.get_IsNonCDataType();
                /*0x382fe10*/ bool System.Xml.IDtdAttributeInfo.get_IsDeclaredInExternal();
                /*0x382fe18*/ bool System.Xml.IDtdAttributeInfo.get_IsXmlAttribute();
                /*0x382fe28*/ string System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueExpanded();
                /*0x382fe70*/ object System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueTyped();
                /*0x382fe78*/ int System.Xml.IDtdDefaultAttributeInfo.get_ValueLineNumber();
                /*0x382fe80*/ int System.Xml.IDtdDefaultAttributeInfo.get_ValueLinePosition();
                /*0x382fe88*/ int get_LinePosition();
                /*0x382fe90*/ void set_LinePosition(int value);
                /*0x382fe98*/ int get_LineNumber();
                /*0x382fea0*/ void set_LineNumber(int value);
                /*0x382fea8*/ int get_ValueLinePosition();
                /*0x382feb0*/ void set_ValueLinePosition(int value);
                /*0x382feb8*/ int get_ValueLineNumber();
                /*0x382fec0*/ void set_ValueLineNumber(int value);
                /*0x382fe4c*/ string get_DefaultValueExpanded();
                /*0x382fec8*/ void set_DefaultValueExpanded(string value);
                /*0x382fdf4*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x382fed0*/ void set_TokenizedType(System.Xml.XmlTokenizedType value);
                /*0x382fef8*/ System.Xml.Schema.SchemaAttDef.Reserve get_Reserved();
                /*0x382ff00*/ void set_Reserved(System.Xml.Schema.SchemaAttDef.Reserve value);
                /*0x382ff08*/ bool get_DefaultValueChecked();
                /*0x382ff10*/ System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute();
                /*0x382ff18*/ void set_SchemaAttribute(System.Xml.Schema.XmlSchemaAttribute value);
                /*0x382ff20*/ void CheckXmlSpace(System.Xml.IValidationEventHandling validationEventHandling);
                /*0x3830194*/ System.Xml.Schema.SchemaAttDef Clone();

                enum Reserve
                {
                    None = 0,
                    XmlSpace = 1,
                    XmlLang = 2,
                }
            }

            class SchemaBuilder
            {
                /*0x3830260*/ SchemaBuilder();
                bool ProcessElement(string prefix, string name, string ns);
                /*0x1f31134*/ void ProcessAttribute(string prefix, string name, string ns, string value);
                /*0x1f2fe14*/ bool IsContentParsed();
                /*0x1f30ebc*/ void ProcessMarkup(System.Xml.XmlNode[] markup);
                /*0x1f30ebc*/ void ProcessCData(string value);
                /*0x1f309e4*/ void StartChildren();
                /*0x1f309e4*/ void EndChildren();
            }

            class SchemaCollectionCompiler : System.Xml.Schema.BaseProcessor
            {
                /*0x40*/ bool compileContentModel;
                /*0x48*/ System.Xml.Schema.XmlSchemaObjectTable examplars;
                /*0x50*/ System.Collections.Stack complexTypeStack;
                /*0x58*/ System.Xml.Schema.XmlSchema schema;

                static /*0x38347f8*/ void Cleanup(System.Xml.Schema.XmlSchema schema);
                static /*0x38347c0*/ void CleanupAttribute(System.Xml.Schema.XmlSchemaAttribute attribute);
                static /*0x38342a0*/ void CleanupAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                static /*0x38342e4*/ void CleanupComplexType(System.Xml.Schema.XmlSchemaComplexType complexType);
                static /*0x3834624*/ void CleanupSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType);
                static /*0x383463c*/ void CleanupElement(System.Xml.Schema.XmlSchemaElement element);
                static /*0x383945c*/ void CleanupAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes);
                static /*0x3834274*/ void CleanupGroup(System.Xml.Schema.XmlSchemaGroup group);
                static /*0x3839520*/ void CleanupParticle(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x3830268*/ SchemaCollectionCompiler(System.Xml.XmlNameTable nameTable, System.Xml.Schema.ValidationEventHandler eventHandler);
                /*0x3830330*/ bool Execute(System.Xml.Schema.XmlSchema schema, System.Xml.Schema.SchemaInfo schemaInfo, bool compileContentModel);
                /*0x38303a0*/ void Prepare();
                /*0x38307f0*/ void Cleanup();
                /*0x38315c0*/ void Compile();
                /*0x3833384*/ void Output(System.Xml.Schema.SchemaInfo schemaInfo);
                /*0x3834e08*/ void CompileSubstitutionGroup(System.Xml.Schema.XmlSchemaSubstitutionGroupV1Compat substitutionGroup);
                /*0x3839294*/ void CheckSubstitutionGroup(System.Xml.Schema.XmlSchemaSubstitutionGroup substitutionGroup);
                /*0x3835288*/ void CompileGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x3836754*/ void CompileSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType);
                /*0x3839a2c*/ System.Xml.Schema.XmlSchemaSimpleType[] CompileBaseMemberTypes(System.Xml.Schema.XmlSchemaSimpleType simpleType);
                /*0x3839dd0*/ void CheckUnionType(System.Xml.Schema.XmlSchemaSimpleType unionMember, System.Collections.ArrayList memberTypeDefinitions, System.Xml.Schema.XmlSchemaSimpleType parentType);
                /*0x3835abc*/ void CompileComplexType(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x3839ee8*/ void CompileSimpleContentExtension(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaSimpleContentExtension simpleExtension);
                /*0x383a15c*/ void CompileSimpleContentRestriction(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaSimpleContentRestriction simpleRestriction);
                /*0x383a564*/ void CompileComplexContentExtension(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaComplexContentExtension complexExtension);
                /*0x383a96c*/ void CompileComplexContentRestriction(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaComplexContentRestriction complexRestriction);
                /*0x3839168*/ void CheckParticleDerivation(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x383c054*/ System.Xml.Schema.XmlSchemaParticle CompileContentTypeParticle(System.Xml.Schema.XmlSchemaParticle particle, bool substitution);
                /*0x3839684*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeParticle(System.Xml.Schema.XmlSchemaParticle particle, bool root, bool substitution);
                /*0x383d298*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeElement(System.Xml.Schema.XmlSchemaElement element, bool substitution);
                /*0x383d3ec*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeGroupRef(System.Xml.Schema.XmlSchemaGroupRef groupRef, bool root, bool substitution);
                /*0x383d958*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeAll(System.Xml.Schema.XmlSchemaAll all, bool root, bool substitution);
                /*0x383ddf4*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeChoice(System.Xml.Schema.XmlSchemaChoice choice, bool root, bool substitution);
                /*0x383e2d8*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeSequence(System.Xml.Schema.XmlSchemaSequence sequence, bool root, bool substitution);
                /*0x383cd04*/ bool IsValidRestriction(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle);
                /*0x383e820*/ bool IsElementFromElement(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaElement baseElement);
                /*0x383e934*/ bool IsElementFromAny(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaAny baseAny);
                /*0x383e990*/ bool IsAnyFromAny(System.Xml.Schema.XmlSchemaAny derivedAny, System.Xml.Schema.XmlSchemaAny baseAny);
                /*0x383e9dc*/ bool IsGroupBaseFromAny(System.Xml.Schema.XmlSchemaGroupBase derivedGroupBase, System.Xml.Schema.XmlSchemaAny baseAny);
                /*0x383ebfc*/ bool IsElementFromGroupBase(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly);
                /*0x383ef94*/ bool IsGroupBaseFromGroupBase(System.Xml.Schema.XmlSchemaGroupBase derivedGroupBase, System.Xml.Schema.XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly);
                /*0x383f208*/ bool IsSequenceFromAll(System.Xml.Schema.XmlSchemaSequence derivedSequence, System.Xml.Schema.XmlSchemaAll baseAll);
                /*0x383f50c*/ bool IsSequenceFromChoice(System.Xml.Schema.XmlSchemaSequence derivedSequence, System.Xml.Schema.XmlSchemaChoice baseChoice);
                /*0x384015c*/ void CalculateSequenceRange(System.Xml.Schema.XmlSchemaSequence sequence, ref decimal minOccurs, ref decimal maxOccurs);
                /*0x383f724*/ bool IsValidOccurrenceRangeRestriction(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle);
                /*0x383ff80*/ bool IsValidOccurrenceRangeRestriction(decimal minOccurs, decimal maxOccurs, decimal baseMinOccurs, decimal baseMaxOccurs);
                /*0x3840068*/ int GetMappingParticle(System.Xml.Schema.XmlSchemaParticle particle, System.Xml.Schema.XmlSchemaObjectCollection collection);
                /*0x383e75c*/ bool IsParticleEmptiable(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x383f768*/ void CalculateEffectiveTotalRange(System.Xml.Schema.XmlSchemaParticle particle, ref decimal minOccurs, ref decimal maxOccurs);
                /*0x3840540*/ void PushComplexType(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x383c1bc*/ System.Xml.Schema.XmlSchemaContentType GetSchemaContentType(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaParticle particle);
                /*0x3835370*/ void CompileAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x383ac6c*/ void CompileLocalAttributes(System.Xml.Schema.XmlSchemaComplexType baseType, System.Xml.Schema.XmlSchemaComplexType derivedType, System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute, System.Xml.Schema.XmlSchemaDerivationMethod derivedBy);
                /*0x38405f4*/ System.Xml.Schema.XmlSchemaAnyAttribute CompileAnyAttributeUnion(System.Xml.Schema.XmlSchemaAnyAttribute a, System.Xml.Schema.XmlSchemaAnyAttribute b);
                /*0x3840560*/ System.Xml.Schema.XmlSchemaAnyAttribute CompileAnyAttributeIntersection(System.Xml.Schema.XmlSchemaAnyAttribute a, System.Xml.Schema.XmlSchemaAnyAttribute b);
                /*0x3837df8*/ void CompileAttribute(System.Xml.Schema.XmlSchemaAttribute xa);
                /*0x38389f0*/ void CompileIdentityConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint xi);
                /*0x3837058*/ void CompileElement(System.Xml.Schema.XmlSchemaElement xe);
                /*0x383c22c*/ System.Xml.Schema.ContentValidator CompileComplexContent(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x3840688*/ void BuildParticleContentModel(System.Xml.Schema.ParticleContentValidator contentValidator, System.Xml.Schema.XmlSchemaParticle particle);
                /*0x3840bc4*/ void CompileParticleElements(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaParticle particle);
                /*0x3839094*/ void CompileCompexTypeElements(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x38398e0*/ System.Xml.Schema.XmlSchemaSimpleType GetSimpleType(System.Xml.XmlQualifiedName name);
                /*0x383cc50*/ System.Xml.Schema.XmlSchemaComplexType GetComplexType(System.Xml.XmlQualifiedName name);
                /*0x383caec*/ System.Xml.Schema.XmlSchemaType GetAnySchemaType(System.Xml.XmlQualifiedName name);
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

                /*0x3840e20*/ SchemaCollectionPreprocessor(System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler);
                /*0x3840e28*/ bool Execute(System.Xml.Schema.XmlSchema schema, string targetNamespace, bool loadExternals, System.Xml.Schema.XmlSchemaCollection xsc);
                /*0x3841074*/ void Cleanup(System.Xml.Schema.XmlSchema schema);
                /*0x38441bc*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x384128c*/ void LoadExternals(System.Xml.Schema.XmlSchema schema, System.Xml.Schema.XmlSchemaCollection xsc);
                /*0x3844384*/ void BuildRefNamespaces(System.Xml.Schema.XmlSchema schema);
                /*0x3841e9c*/ void Preprocess(System.Xml.Schema.XmlSchema schema, string targetNamespace, System.Xml.Schema.SchemaCollectionPreprocessor.Compositor compositor);
                /*0x3844690*/ void PreprocessRedefine(System.Xml.Schema.XmlSchemaRedefine redefine);
                /*0x3847550*/ int CountGroupSelfReference(System.Xml.Schema.XmlSchemaObjectCollection items, System.Xml.XmlQualifiedName name);
                /*0x3846f24*/ void CheckRefinedGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x3846fbc*/ void CheckRefinedAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x3847444*/ void CheckRefinedSimpleType(System.Xml.Schema.XmlSchemaSimpleType stype);
                /*0x3847124*/ void CheckRefinedComplexType(System.Xml.Schema.XmlSchemaComplexType ctype);
                /*0x3845744*/ void PreprocessAttribute(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x3847d30*/ void PreprocessLocalAttribute(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x3847af0*/ void PreprocessAttributeContent(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x38458b4*/ void PreprocessAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x3846858*/ void PreprocessElement(System.Xml.Schema.XmlSchemaElement element);
                /*0x38486ec*/ void PreprocessLocalElement(System.Xml.Schema.XmlSchemaElement element);
                /*0x3848394*/ void PreprocessElementContent(System.Xml.Schema.XmlSchemaElement element);
                /*0x3848a60*/ void PreprocessIdentityConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint constraint);
                /*0x3846260*/ void PreprocessSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType, bool local);
                /*0x38459b4*/ void PreprocessComplexType(System.Xml.Schema.XmlSchemaComplexType complexType, bool local);
                /*0x3846aac*/ void PreprocessGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x3846c78*/ void PreprocessNotation(System.Xml.Schema.XmlSchemaNotation notation);
                /*0x3848db8*/ void PreprocessParticle(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x3848070*/ void PreprocessAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute, System.Xml.Schema.XmlSchemaObject parent);
                /*0x3841c40*/ void ValidateIdAttribute(System.Xml.Schema.XmlSchemaObject xso);
                /*0x3847830*/ void ValidateNameAttribute(System.Xml.Schema.XmlSchemaObject xso);
                /*0x3847ee8*/ void ValidateQNameAttribute(System.Xml.Schema.XmlSchemaObject xso, string attributeName, System.Xml.XmlQualifiedName value);
                /*0x3844588*/ void SetParent(System.Xml.Schema.XmlSchemaObject child, System.Xml.Schema.XmlSchemaObject parent);
                /*0x38445a4*/ void PreprocessAnnotation(System.Xml.Schema.XmlSchemaObject schemaObject);
                /*0x38441c4*/ System.Uri ResolveSchemaLocationUri(System.Xml.Schema.XmlSchema enclosingSchema, string location);
                /*0x3844270*/ System.IO.Stream GetSchemaEntity(System.Uri ruri);

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

                /*0x38496d0*/ SchemaDeclBase(System.Xml.XmlQualifiedName name, string prefix);
                /*0x3849780*/ SchemaDeclBase();
                /*0x38497f0*/ System.Xml.XmlQualifiedName get_Name();
                /*0x38497f8*/ void set_Name(System.Xml.XmlQualifiedName value);
                /*0x3849800*/ string get_Prefix();
                /*0x3849824*/ void set_Prefix(string value);
                /*0x384982c*/ bool get_IsDeclaredInExternal();
                /*0x3849834*/ void set_IsDeclaredInExternal(bool value);
                /*0x384983c*/ System.Xml.Schema.SchemaDeclBase.Use get_Presence();
                /*0x3849844*/ void set_Presence(System.Xml.Schema.SchemaDeclBase.Use value);
                /*0x384984c*/ long get_MaxLength();
                /*0x3849854*/ void set_MaxLength(long value);
                /*0x384985c*/ long get_MinLength();
                /*0x3849864*/ void set_MinLength(long value);
                /*0x384986c*/ System.Xml.Schema.XmlSchemaType get_SchemaType();
                /*0x3849874*/ void set_SchemaType(System.Xml.Schema.XmlSchemaType value);
                /*0x384987c*/ System.Xml.Schema.XmlSchemaDatatype get_Datatype();
                /*0x3849884*/ void set_Datatype(System.Xml.Schema.XmlSchemaDatatype value);
                /*0x384988c*/ void AddValue(string value);
                /*0x3849938*/ System.Collections.Generic.List<string> get_Values();
                /*0x3849940*/ void set_Values(System.Collections.Generic.List<string> value);
                /*0x3849948*/ string get_DefaultValueRaw();
                /*0x384996c*/ void set_DefaultValueRaw(string value);
                /*0x3849974*/ object get_DefaultValueTyped();
                /*0x384997c*/ void set_DefaultValueTyped(object value);
                /*0x3849984*/ bool CheckEnumeration(object pVal);
                /*0x3849a3c*/ bool CheckValue(object pVal);

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

                static /*0x384a4e4*/ SchemaElementDecl();
                static /*0x3849d7c*/ System.Xml.Schema.SchemaElementDecl CreateAnyTypeElementDecl();
                /*0x3849a84*/ SchemaElementDecl();
                /*0x3849b5c*/ SchemaElementDecl(System.Xml.Schema.XmlSchemaDatatype dtype);
                /*0x3849c8c*/ SchemaElementDecl(System.Xml.XmlQualifiedName name, string prefix);
                /*0x3849e48*/ bool System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes();
                /*0x3849e50*/ System.Xml.IDtdAttributeInfo System.Xml.IDtdAttributeListInfo.LookupAttribute(string prefix, string localName);
                /*0x3849f04*/ System.Collections.Generic.IEnumerable<System.Xml.IDtdDefaultAttributeInfo> System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes();
                /*0x3849f0c*/ bool get_IsIdDeclared();
                /*0x3849f14*/ void set_IsIdDeclared(bool value);
                /*0x3849f1c*/ bool get_HasNonCDataAttribute();
                /*0x3849f24*/ void set_HasNonCDataAttribute(bool value);
                /*0x3849f2c*/ System.Xml.Schema.SchemaElementDecl Clone();
                /*0x3849f90*/ bool get_IsAbstract();
                /*0x3849f98*/ void set_IsAbstract(bool value);
                /*0x3849fa0*/ bool get_IsNillable();
                /*0x3849fa8*/ void set_IsNillable(bool value);
                /*0x3849fb0*/ System.Xml.Schema.XmlSchemaDerivationMethod get_Block();
                /*0x3849fb8*/ void set_Block(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x3849fc0*/ bool get_IsNotationDeclared();
                /*0x3849fc8*/ void set_IsNotationDeclared(bool value);
                /*0x3849fd0*/ bool get_HasDefaultAttribute();
                /*0x3849fe0*/ bool get_HasRequiredAttribute();
                /*0x3849fe8*/ System.Xml.Schema.ContentValidator get_ContentValidator();
                /*0x3849ff0*/ void set_ContentValidator(System.Xml.Schema.ContentValidator value);
                /*0x3849ff8*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0x384a000*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x384a008*/ System.Xml.Schema.CompiledIdentityConstraint[] get_Constraints();
                /*0x384a010*/ void set_Constraints(System.Xml.Schema.CompiledIdentityConstraint[] value);
                /*0x384a018*/ System.Xml.Schema.XmlSchemaElement get_SchemaElement();
                /*0x384a020*/ void set_SchemaElement(System.Xml.Schema.XmlSchemaElement value);
                /*0x384a028*/ void AddAttDef(System.Xml.Schema.SchemaAttDef attdef);
                /*0x384a14c*/ System.Xml.Schema.SchemaAttDef GetAttDef(System.Xml.XmlQualifiedName qname);
                /*0x384a1c4*/ System.Collections.Generic.IList<System.Xml.IDtdDefaultAttributeInfo> get_DefaultAttDefs();
                /*0x384a1cc*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaAttDef> get_AttDefs();
                /*0x384a1d4*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.XmlQualifiedName> get_ProhibitedAttributes();
                /*0x384a1dc*/ void CheckAttributes(System.Collections.Hashtable presence, bool standalone);
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

                static /*0x384a6f4*/ bool IsPredefinedEntity(string n);
                /*0x384a548*/ SchemaEntity(System.Xml.XmlQualifiedName qname, bool isParameter);
                /*0x384a5e4*/ string System.Xml.IDtdEntityInfo.get_Name();
                /*0x384a5fc*/ bool System.Xml.IDtdEntityInfo.get_IsExternal();
                /*0x384a604*/ bool System.Xml.IDtdEntityInfo.get_IsDeclaredInExternal();
                /*0x384a60c*/ bool System.Xml.IDtdEntityInfo.get_IsUnparsedEntity();
                /*0x384a634*/ bool System.Xml.IDtdEntityInfo.get_IsParameterEntity();
                /*0x384a63c*/ string System.Xml.IDtdEntityInfo.get_BaseUriString();
                /*0x384a684*/ string System.Xml.IDtdEntityInfo.get_DeclaredUriString();
                /*0x384a6cc*/ string System.Xml.IDtdEntityInfo.get_SystemId();
                /*0x384a6d4*/ string System.Xml.IDtdEntityInfo.get_PublicId();
                /*0x384a6dc*/ string System.Xml.IDtdEntityInfo.get_Text();
                /*0x384a6e4*/ int System.Xml.IDtdEntityInfo.get_LineNumber();
                /*0x384a6ec*/ int System.Xml.IDtdEntityInfo.get_LinePosition();
                /*0x384a7f0*/ System.Xml.XmlQualifiedName get_Name();
                /*0x384a7f8*/ string get_Url();
                /*0x384a800*/ void set_Url(string value);
                /*0x384a824*/ string get_Pubid();
                /*0x384a82c*/ void set_Pubid(string value);
                /*0x384a834*/ bool get_IsExternal();
                /*0x384a83c*/ void set_IsExternal(bool value);
                /*0x384a844*/ bool get_DeclaredInExternal();
                /*0x384a84c*/ void set_DeclaredInExternal(bool value);
                /*0x384a854*/ System.Xml.XmlQualifiedName get_NData();
                /*0x384a85c*/ void set_NData(System.Xml.XmlQualifiedName value);
                /*0x384a864*/ string get_Text();
                /*0x384a86c*/ void set_Text(string value);
                /*0x384a88c*/ int get_Line();
                /*0x384a894*/ void set_Line(int value);
                /*0x384a89c*/ int get_Pos();
                /*0x384a8a4*/ void set_Pos(int value);
                /*0x384a660*/ string get_BaseURI();
                /*0x384a8ac*/ void set_BaseURI(string value);
                /*0x384a8b4*/ bool get_ParsingInProgress();
                /*0x384a8bc*/ void set_ParsingInProgress(bool value);
                /*0x384a6a8*/ string get_DeclaredURI();
                /*0x384a8c4*/ void set_DeclaredURI(string value);
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

                /*0x384a8cc*/ SchemaInfo();
                /*0x384aaa8*/ System.Xml.XmlQualifiedName get_DocTypeName();
                /*0x384aab0*/ void set_DocTypeName(System.Xml.XmlQualifiedName value);
                /*0x384aab8*/ void set_InternalDtdSubset(string value);
                /*0x384aac0*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaElementDecl> get_ElementDecls();
                /*0x384aac8*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaElementDecl> get_UndeclaredElementDecls();
                /*0x384aad0*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaEntity> get_GeneralEntities();
                /*0x384ab54*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaEntity> get_ParameterEntities();
                /*0x384abd8*/ System.Xml.Schema.SchemaType get_SchemaType();
                /*0x384abe0*/ void set_SchemaType(System.Xml.Schema.SchemaType value);
                /*0x384abe8*/ System.Collections.Generic.Dictionary<string, bool> get_TargetNamespaces();
                /*0x384abf0*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaElementDecl> get_ElementDeclsByType();
                /*0x384abf8*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaAttDef> get_AttributeDecls();
                /*0x384ac00*/ System.Collections.Generic.Dictionary<string, System.Xml.Schema.SchemaNotation> get_Notations();
                /*0x384ac84*/ int get_ErrorCount();
                /*0x384ac8c*/ void set_ErrorCount(int value);
                /*0x384ac94*/ System.Xml.Schema.SchemaElementDecl GetElementDecl(System.Xml.XmlQualifiedName qname);
                /*0x384ad0c*/ System.Xml.Schema.SchemaElementDecl GetTypeDecl(System.Xml.XmlQualifiedName qname);
                /*0x384ad84*/ System.Xml.Schema.XmlSchemaElement GetElement(System.Xml.XmlQualifiedName qname);
                /*0x384ad9c*/ bool HasSchema(string ns);
                /*0x384adf4*/ bool Contains(string ns);
                /*0x384ae4c*/ System.Xml.Schema.SchemaAttDef GetAttributeXdr(System.Xml.Schema.SchemaElementDecl ed, System.Xml.XmlQualifiedName qname);
                /*0x384af98*/ System.Xml.Schema.SchemaAttDef GetAttributeXsd(System.Xml.Schema.SchemaElementDecl ed, System.Xml.XmlQualifiedName qname, System.Xml.Schema.XmlSchemaObject partialValidationType, ref System.Xml.Schema.AttributeMatchState attributeMatchState);
                /*0x384b1b4*/ System.Xml.Schema.SchemaAttDef GetAttributeXsd(System.Xml.Schema.SchemaElementDecl ed, System.Xml.XmlQualifiedName qname, ref bool skip);
                /*0x384b2ac*/ void Add(System.Xml.Schema.SchemaInfo sinfo, System.Xml.Schema.ValidationEventHandler eventhandler);
                /*0x384c088*/ void Finish();
                /*0x384c2b0*/ bool System.Xml.IDtdInfo.get_HasDefaultAttributes();
                /*0x384c2b8*/ bool System.Xml.IDtdInfo.get_HasNonCDataAttributes();
                /*0x384c2c0*/ System.Xml.IDtdAttributeListInfo System.Xml.IDtdInfo.LookupAttributeList(string prefix, string localName);
                /*0x384c388*/ System.Xml.IDtdEntityInfo System.Xml.IDtdInfo.LookupEntity(string name);
                /*0x384c43c*/ System.Xml.XmlQualifiedName System.Xml.IDtdInfo.get_Name();
                /*0x384c444*/ string System.Xml.IDtdInfo.get_InternalDtdSubset();
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

                /*0x384c44c*/ SchemaNames(System.Xml.XmlNameTable nameTable);
                /*0x384f414*/ void CreateTokenToQNameTable();
                /*0x3851340*/ System.Xml.Schema.SchemaType SchemaTypeFromRoot(string localName, string ns);
                /*0x38513a0*/ bool IsXSDRoot(string localName, string ns);
                /*0x38513f0*/ bool IsXDRRoot(string localName, string ns);

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

                /*0x3851440*/ SchemaNamespaceManager(System.Xml.Schema.XmlSchemaObject node);
                /*0x3851470*/ string LookupNamespace(string prefix);
                /*0x3851594*/ string LookupPrefix(string ns);
            }

            class SchemaNotation
            {
                /*0x10*/ System.Xml.XmlQualifiedName name;
                /*0x18*/ string systemLiteral;
                /*0x20*/ string pubid;

                /*0x3851974*/ SchemaNotation(System.Xml.XmlQualifiedName name);
                /*0x38519a4*/ System.Xml.XmlQualifiedName get_Name();
                /*0x38519ac*/ string get_SystemLiteral();
                /*0x38519b4*/ void set_SystemLiteral(string value);
                /*0x38519bc*/ string get_Pubid();
                /*0x38519c4*/ void set_Pubid(string value);
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

                /*0x38519cc*/ Compiler(System.Xml.XmlNameTable nameTable, System.Xml.Schema.ValidationEventHandler eventHandler, System.Xml.Schema.XmlSchema schemaForSchema, System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings);
                /*0x3851c10*/ bool Execute(System.Xml.Schema.XmlSchemaSet schemaSet, System.Xml.Schema.SchemaInfo schemaCompiledInfo);
                /*0x38549b4*/ void Prepare(System.Xml.Schema.XmlSchema schema, bool cleanup);
                /*0x38565c8*/ void UpdateSForSSimpleTypes();
                /*0x3853a34*/ void Output(System.Xml.Schema.SchemaInfo schemaInfo);
                /*0x3856710*/ void ImportAllCompiledSchemas(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x3851cac*/ bool Compile();
                /*0x3855ff4*/ void CleanupAttribute(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x385606c*/ void CleanupAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x38560cc*/ void CleanupComplexType(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x3856514*/ void CleanupSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType);
                /*0x3855e60*/ void CleanupElement(System.Xml.Schema.XmlSchemaElement element);
                /*0x385b610*/ void CleanupAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes);
                /*0x3856024*/ void CleanupGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x385b6e8*/ void CleanupParticle(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x385a6d4*/ void ProcessSubstitutionGroups();
                /*0x385b88c*/ void CompileSubstitutionGroup(System.Xml.Schema.XmlSchemaSubstitutionGroup substitutionGroup);
                /*0x385b4bc*/ void RecursivelyCheckRedefinedGroups(System.Xml.Schema.XmlSchemaGroup redefinedGroup, System.Xml.Schema.XmlSchemaGroup baseGroup);
                /*0x385b598*/ void RecursivelyCheckRedefinedAttributeGroups(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup, System.Xml.Schema.XmlSchemaAttributeGroup baseAttributeGroup);
                /*0x3856818*/ void CompileGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x3857d2c*/ void CompileSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType);
                /*0x385cc6c*/ System.Xml.Schema.XmlSchemaSimpleType[] CompileBaseMemberTypes(System.Xml.Schema.XmlSchemaSimpleType simpleType);
                /*0x385d010*/ void CheckUnionType(System.Xml.Schema.XmlSchemaSimpleType unionMember, System.Collections.ArrayList memberTypeDefinitions, System.Xml.Schema.XmlSchemaSimpleType parentType);
                /*0x38571e8*/ void CompileComplexType(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x385d128*/ void CompileSimpleContentExtension(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaSimpleContentExtension simpleExtension);
                /*0x385d39c*/ void CompileSimpleContentRestriction(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaSimpleContentRestriction simpleRestriction);
                /*0x385d7a4*/ void CompileComplexContentExtension(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaComplexContentExtension complexExtension);
                /*0x385db5c*/ void CompileComplexContentRestriction(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaComplexContentRestriction complexRestriction);
                /*0x385aee0*/ void CheckParticleDerivation(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x385c1ac*/ void CheckParticleDerivation(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle);
                /*0x385f2b4*/ System.Xml.Schema.XmlSchemaParticle CompileContentTypeParticle(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x385bdf8*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeParticle(System.Xml.Schema.XmlSchemaParticle particle, bool root);
                /*0x3861cec*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeElement(System.Xml.Schema.XmlSchemaElement element);
                /*0x3860bb8*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeGroupRef(System.Xml.Schema.XmlSchemaGroupRef groupRef, bool root);
                /*0x38610f0*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeAll(System.Xml.Schema.XmlSchemaAll all, bool root);
                /*0x3861374*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeChoice(System.Xml.Schema.XmlSchemaChoice choice, bool root);
                /*0x3861850*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeSequence(System.Xml.Schema.XmlSchemaSequence sequence, bool root);
                /*0x385ff80*/ System.Xml.Schema.XmlSchemaParticle CannonicalizePointlessRoot(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x38601c4*/ bool IsValidRestriction(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle);
                /*0x386202c*/ bool IsElementFromElement(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaElement baseElement);
                /*0x386224c*/ bool IsElementFromAny(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaAny baseAny);
                /*0x3862400*/ bool IsAnyFromAny(System.Xml.Schema.XmlSchemaAny derivedAny, System.Xml.Schema.XmlSchemaAny baseAny);
                /*0x3862500*/ bool IsGroupBaseFromAny(System.Xml.Schema.XmlSchemaGroupBase derivedGroupBase, System.Xml.Schema.XmlSchemaAny baseAny);
                /*0x3862948*/ bool IsElementFromGroupBase(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaGroupBase baseGroupBase);
                /*0x3863800*/ bool IsChoiceFromChoiceSubstGroup(System.Xml.Schema.XmlSchemaChoice derivedChoice, System.Xml.Schema.XmlSchemaChoice baseChoice);
                /*0x386320c*/ bool IsGroupBaseFromGroupBase(System.Xml.Schema.XmlSchemaGroupBase derivedGroupBase, System.Xml.Schema.XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly);
                /*0x38634fc*/ bool IsSequenceFromAll(System.Xml.Schema.XmlSchemaSequence derivedSequence, System.Xml.Schema.XmlSchemaAll baseAll);
                /*0x386398c*/ bool IsSequenceFromChoice(System.Xml.Schema.XmlSchemaSequence derivedSequence, System.Xml.Schema.XmlSchemaChoice baseChoice);
                /*0x3863ce8*/ bool IsValidOccurrenceRangeRestriction(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle);
                /*0x3864674*/ bool IsValidOccurrenceRangeRestriction(decimal minOccurs, decimal maxOccurs, decimal baseMinOccurs, decimal baseMaxOccurs);
                /*0x386475c*/ int GetMappingParticle(System.Xml.Schema.XmlSchemaParticle particle, System.Xml.Schema.XmlSchemaObjectCollection collection);
                /*0x3861f68*/ bool IsParticleEmptiable(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x3863e84*/ void CalculateEffectiveTotalRange(System.Xml.Schema.XmlSchemaParticle particle, ref decimal minOccurs, ref decimal maxOccurs);
                /*0x3864850*/ void PushComplexType(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x385f414*/ System.Xml.Schema.XmlSchemaContentType GetSchemaContentType(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaParticle particle);
                /*0x38568fc*/ void CompileAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x385de50*/ void CompileLocalAttributes(System.Xml.Schema.XmlSchemaComplexType baseType, System.Xml.Schema.XmlSchemaComplexType derivedType, System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute, System.Xml.Schema.XmlSchemaDerivationMethod derivedBy);
                /*0x385c294*/ void CheckAtrributeGroupRestriction(System.Xml.Schema.XmlSchemaAttributeGroup baseAttributeGroup, System.Xml.Schema.XmlSchemaAttributeGroup derivedAttributeGroup);
                /*0x3864998*/ bool IsProcessContentsRestricted(System.Xml.Schema.XmlSchemaComplexType baseType, System.Xml.Schema.XmlSchemaAnyAttribute derivedAttributeWildcard, System.Xml.Schema.XmlSchemaAnyAttribute baseAttributeWildcard);
                /*0x3864904*/ System.Xml.Schema.XmlSchemaAnyAttribute CompileAnyAttributeUnion(System.Xml.Schema.XmlSchemaAnyAttribute a, System.Xml.Schema.XmlSchemaAnyAttribute b);
                /*0x3864870*/ System.Xml.Schema.XmlSchemaAnyAttribute CompileAnyAttributeIntersection(System.Xml.Schema.XmlSchemaAnyAttribute a, System.Xml.Schema.XmlSchemaAnyAttribute b);
                /*0x3859534*/ void CompileAttribute(System.Xml.Schema.XmlSchemaAttribute xa);
                /*0x3864a74*/ void SetDefaultFixed(System.Xml.Schema.XmlSchemaAttribute xa, System.Xml.Schema.SchemaAttDef decl);
                /*0x3859ee8*/ void CompileIdentityConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint xi);
                /*0x3858668*/ void CompileElement(System.Xml.Schema.XmlSchemaElement xe);
                /*0x385f484*/ System.Xml.Schema.ContentValidator CompileComplexContent(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x3864c3c*/ bool BuildParticleContentModel(System.Xml.Schema.ParticleContentValidator contentValidator, System.Xml.Schema.XmlSchemaParticle particle);
                /*0x386515c*/ void CompileParticleElements(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaParticle particle);
                /*0x385c024*/ void CompileParticleElements(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x385a588*/ void CompileComplexTypeElements(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x385cb94*/ System.Xml.Schema.XmlSchemaSimpleType GetSimpleType(System.Xml.XmlQualifiedName name);
                /*0x385fed8*/ System.Xml.Schema.XmlSchemaComplexType GetComplexType(System.Xml.XmlQualifiedName name);
                /*0x385fd80*/ System.Xml.Schema.XmlSchemaType GetAnySchemaType(System.Xml.XmlQualifiedName name);
                /*0x3861ef4*/ void CopyPosition(System.Xml.Schema.XmlSchemaAnnotated to, System.Xml.Schema.XmlSchemaAnnotated from, bool copyParent);
                /*0x3863d2c*/ bool IsFixedEqual(System.Xml.Schema.SchemaDeclBase baseDecl, System.Xml.Schema.SchemaDeclBase derivedDecl);
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

                /*0x38653b8*/ ValidationEventArgs(System.Xml.Schema.XmlSchemaException ex);
                /*0x3865434*/ ValidationEventArgs(System.Xml.Schema.XmlSchemaException ex, System.Xml.Schema.XmlSeverityType severity);
                /*0x38654b4*/ System.Xml.Schema.XmlSeverityType get_Severity();
                /*0x38654bc*/ System.Xml.Schema.XmlSchemaException get_Exception();
            }

            class ValidationEventHandler : System.MulticastDelegate
            {
                /*0x38654c4*/ ValidationEventHandler(object object, nint method);
                /*0x38655d0*/ void Invoke(object sender, System.Xml.Schema.ValidationEventArgs e);
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

                /*0x38655e4*/ ValidationState();
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

                static /*0x386b294*/ XdrBuilder();
                static /*0x3866330*/ bool IsXdrSchema(string uri);
                static /*0x3866de8*/ void XDR_InitRoot(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x3866e48*/ void XDR_BuildRoot_Name(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x3866ec0*/ void XDR_BuildRoot_ID(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x3866ec4*/ void XDR_BeginRoot(System.Xml.Schema.XdrBuilder builder);
                static /*0x3866fb4*/ void XDR_EndRoot(System.Xml.Schema.XdrBuilder builder);
                static /*0x3867524*/ void XDR_InitElementType(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x3867650*/ void XDR_BuildElementType_Name(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x386781c*/ void XDR_BuildElementType_Content(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x3867a40*/ void XDR_BuildElementType_Model(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x3867bb8*/ void XDR_BuildElementType_Order(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x3867d88*/ void XDR_BuildElementType_DtType(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x3867f08*/ void XDR_BuildElementType_DtValues(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x3867fec*/ void XDR_BuildElementType_DtMaxLength(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x3868194*/ void XDR_BuildElementType_DtMinLength(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x386833c*/ void XDR_BeginElementType(System.Xml.Schema.XdrBuilder builder);
                static /*0x386865c*/ void XDR_EndElementType(System.Xml.Schema.XdrBuilder builder);
                static /*0x3868acc*/ void XDR_InitAttributeType(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x3868bd8*/ void XDR_BuildAttributeType_Name(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x3868e30*/ void XDR_BuildAttributeType_Required(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x3868fb8*/ void XDR_BuildAttributeType_Default(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x3868fd8*/ void XDR_BuildAttributeType_DtType(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x38691d4*/ void XDR_BuildAttributeType_DtValues(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x38692b8*/ void XDR_BuildAttributeType_DtMaxLength(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x3869328*/ void XDR_BuildAttributeType_DtMinLength(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x3869398*/ void XDR_BeginAttributeType(System.Xml.Schema.XdrBuilder builder);
                static /*0x3869424*/ void XDR_EndAttributeType(System.Xml.Schema.XdrBuilder builder);
                static /*0x38697e0*/ void XDR_InitElement(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x3869880*/ void XDR_BuildElement_Type(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x3869ac0*/ void XDR_BuildElement_MinOccurs(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x3869c24*/ void XDR_BuildElement_MaxOccurs(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x3869dc0*/ void XDR_EndElement(System.Xml.Schema.XdrBuilder builder);
                static /*0x3869ea8*/ void XDR_InitAttribute(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x3869f4c*/ void XDR_BuildAttribute_Type(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x386a028*/ void XDR_BuildAttribute_Required(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x386a0ac*/ void XDR_BuildAttribute_Default(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x386a0cc*/ void XDR_BeginAttribute(System.Xml.Schema.XdrBuilder builder);
                static /*0x386a3e0*/ void XDR_EndAttribute(System.Xml.Schema.XdrBuilder builder);
                static /*0x386a4f4*/ void XDR_InitGroup(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x386a5c0*/ void XDR_BuildGroup_Order(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x386a6c0*/ void XDR_BuildGroup_MinOccurs(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x386a744*/ void XDR_BuildGroup_MaxOccurs(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x386a7c8*/ void XDR_EndGroup(System.Xml.Schema.XdrBuilder builder);
                static /*0x386a920*/ void XDR_InitElementDtType(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x386a9e4*/ void XDR_EndElementDtType(System.Xml.Schema.XdrBuilder builder);
                static /*0x386aac8*/ void XDR_InitAttributeDtType(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x386ab48*/ void XDR_EndAttributeDtType(System.Xml.Schema.XdrBuilder builder);
                static /*0x3868ea8*/ bool IsYes(object obj, System.Xml.Schema.XdrBuilder builder);
                static /*0x3869b34*/ uint ParseMinOccurs(object obj, System.Xml.Schema.XdrBuilder builder);
                static /*0x3869c98*/ uint ParseMaxOccurs(object obj, System.Xml.Schema.XdrBuilder builder);
                static /*0x3869e78*/ void HandleMinMax(System.Xml.Schema.ParticleContentValidator pContent, uint cMin, uint cMax);
                static /*0x386805c*/ void ParseDtMaxLength(ref uint cVal, object obj, System.Xml.Schema.XdrBuilder builder);
                static /*0x3868204*/ void ParseDtMinLength(ref uint cVal, object obj, System.Xml.Schema.XdrBuilder builder);
                static /*0x3868a38*/ void CompareMinMaxLength(uint cMin, uint cMax, System.Xml.Schema.XdrBuilder builder);
                static /*0x386ac3c*/ bool ParseInteger(string str, ref uint n);
                /*0x3865648*/ XdrBuilder(System.Xml.XmlReader reader, System.Xml.XmlNamespaceManager curmgr, System.Xml.Schema.SchemaInfo sinfo, string targetNamspace, System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventhandler);
                /*0x386590c*/ bool ProcessElement(string prefix, string name, string ns);
                /*0x3865f88*/ void ProcessAttribute(string prefix, string name, string ns, string value);
                /*0x38669c4*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x38663e8*/ bool LoadSchema(string uri);
                /*0x3866acc*/ bool IsContentParsed();
                /*0x3866ad4*/ void ProcessMarkup(System.Xml.XmlNode[] markup);
                /*0x3866b2c*/ void ProcessCData(string value);
                /*0x3866ba8*/ void StartChildren();
                /*0x3866bd8*/ void EndChildren();
                /*0x3865d98*/ void Push();
                /*0x3866c14*/ void Pop();
                /*0x3866ca4*/ void PushGroupInfo();
                /*0x3866d58*/ void PopGroupInfo();
                /*0x3865bf8*/ bool GetNextState(System.Xml.XmlQualifiedName qname);
                /*0x3865de4*/ bool IsSkipableElement(System.Xml.XmlQualifiedName qname);
                /*0x386688c*/ bool IsSkipableAttribute(System.Xml.XmlQualifiedName qname);
                /*0x3867c64*/ int GetOrder(System.Xml.XmlQualifiedName qname);
                /*0x3869a04*/ void AddOrder();
                /*0x386745c*/ void XDR_CheckAttributeDefault(System.Xml.Schema.XdrBuilder.DeclBaseInfo decl, System.Xml.Schema.SchemaAttDef pAttdef);
                /*0x3869794*/ void SetAttributePresence(System.Xml.Schema.SchemaAttDef pAttdef, bool fRequired);
                /*0x38678b8*/ int GetContent(System.Xml.XmlQualifiedName qname);
                /*0x3867ae0*/ bool GetModel(System.Xml.XmlQualifiedName qname);
                /*0x3869090*/ System.Xml.Schema.XmlSchemaDatatype CheckDatatype(string str);
                /*0x38696a4*/ void CheckDefaultAttValue(System.Xml.Schema.SchemaAttDef attDef);
                /*0x3866324*/ bool IsGlobal(int flags);
                /*0x38669cc*/ void SendValidationEvent(string code, string[] args, System.Xml.Schema.XmlSeverityType severity);
                /*0x3867e98*/ void SendValidationEvent(string code);
                /*0x3865ea4*/ void SendValidationEvent(string code, string msg);
                /*0x386b100*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity);

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

                    /*0x3869f30*/ DeclBaseInfo();
                    /*0x386a3fc*/ void Reset();
                }

                class GroupContent
                {
                    /*0x10*/ uint _MinVal;
                    /*0x14*/ uint _MaxVal;
                    /*0x18*/ bool _HasMaxAttr;
                    /*0x19*/ bool _HasMinAttr;
                    /*0x1c*/ int _Order;

                    static /*0x386ced4*/ void Copy(System.Xml.Schema.XdrBuilder.GroupContent from, System.Xml.Schema.XdrBuilder.GroupContent to);
                    static /*0x3866cf4*/ System.Xml.Schema.XdrBuilder.GroupContent Copy(System.Xml.Schema.XdrBuilder.GroupContent other);
                    /*0x3865904*/ GroupContent();
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

                    /*0x38658f4*/ ElementContent();
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

                    /*0x38658fc*/ AttributeContent();
                }

                class XdrBuildFunction : System.MulticastDelegate
                {
                    /*0x386ca9c*/ XdrBuildFunction(object object, nint method);
                    /*0x386cefc*/ void Invoke(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                }

                class XdrInitFunction : System.MulticastDelegate
                {
                    /*0x386ccc0*/ XdrInitFunction(object object, nint method);
                    /*0x386cf10*/ void Invoke(System.Xml.Schema.XdrBuilder builder, object obj);
                }

                class XdrBeginChildFunction : System.MulticastDelegate
                {
                    /*0x386cd74*/ XdrBeginChildFunction(object object, nint method);
                    /*0x386cf24*/ void Invoke(System.Xml.Schema.XdrBuilder builder);
                }

                class XdrEndChildFunction : System.MulticastDelegate
                {
                    /*0x386ce24*/ XdrEndChildFunction(object object, nint method);
                    /*0x386cf38*/ void Invoke(System.Xml.Schema.XdrBuilder builder);
                }

                class XdrAttributeEntry
                {
                    /*0x10*/ System.Xml.Schema.SchemaNames.Token _Attribute;
                    /*0x14*/ int _SchemaFlags;
                    /*0x18*/ System.Xml.Schema.XmlSchemaDatatype _Datatype;
                    /*0x20*/ System.Xml.Schema.XdrBuilder.XdrBuildFunction _BuildFunc;

                    /*0x386cb50*/ XdrAttributeEntry(System.Xml.Schema.SchemaNames.Token a, System.Xml.XmlTokenizedType ttype, System.Xml.Schema.XdrBuilder.XdrBuildFunction build);
                    /*0x386cbb0*/ XdrAttributeEntry(System.Xml.Schema.SchemaNames.Token a, System.Xml.XmlTokenizedType ttype, int schemaFlags, System.Xml.Schema.XdrBuilder.XdrBuildFunction build);
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

                    /*0x386cc14*/ XdrEntry(System.Xml.Schema.SchemaNames.Token n, int[] states, System.Xml.Schema.XdrBuilder.XdrAttributeEntry[] attributes, System.Xml.Schema.XdrBuilder.XdrInitFunction init, System.Xml.Schema.XdrBuilder.XdrBeginChildFunction begin, System.Xml.Schema.XdrBuilder.XdrEndChildFunction end, bool fText);
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

                static /*0x386ac74*/ void CheckDefaultValue(string value, System.Xml.Schema.SchemaAttDef attdef, System.Xml.Schema.SchemaInfo sinfo, System.Xml.XmlNamespaceManager nsManager, System.Xml.XmlNameTable NameTable, object sender, System.Xml.Schema.ValidationEventHandler eventhandler, string baseUri, int lineNo, int linePos);
                /*0x386cf4c*/ XdrValidator(System.Xml.Schema.BaseValidator validator);
                /*0x386d1c8*/ XdrValidator(System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling);
                /*0x386cfd4*/ void Init();
                /*0x386d38c*/ void Validate();
                /*0x386d6e8*/ void ValidateElement();
                /*0x386da44*/ void ValidateChildElement();
                /*0x386d444*/ bool get_IsInlineSchemaStarted();
                /*0x386d454*/ void ProcessInlineSchema();
                /*0x386db8c*/ void ProcessElement();
                /*0x386d888*/ void ValidateEndElement();
                /*0x386dc48*/ System.Xml.Schema.SchemaElementDecl ThoroughGetElementDecl();
                /*0x386df58*/ void ValidateStartElement();
                /*0x386e350*/ void ValidateEndStartElement();
                /*0x386ef9c*/ void LoadSchemaFromLocation(string uri);
                /*0x386ed44*/ void LoadSchema(string uri);
                /*0x386f5a8*/ bool get_HasSchema();
                /*0x386f5c8*/ bool get_PreserveWhitespace();
                /*0x386f600*/ void ProcessTokenizedType(System.Xml.XmlTokenizedType ttype, string name);
                /*0x386f8c0*/ void CompleteValidation();
                /*0x386e6b8*/ void CheckValue(string value, System.Xml.Schema.SchemaAttDef attdef);
                /*0x386f824*/ void AddID(string name, object node);
                /*0x386fb44*/ object FindId(string name);
                /*0x386d268*/ void Push(System.Xml.XmlQualifiedName elementName);
                /*0x386ec8c*/ void Pop();
                /*0x386f974*/ void CheckForwardRefs();
                /*0x386eed4*/ System.Xml.XmlQualifiedName QualifiedName(string name, string ns);
            }

            class XmlAtomicValue : System.Xml.XPath.XPathItem, System.ICloneable
            {
                /*0x10*/ System.Xml.Schema.XmlSchemaType xmlType;
                /*0x18*/ object objVal;
                /*0x20*/ System.TypeCode clrType;
                /*0x28*/ System.Xml.Schema.XmlAtomicValue.Union unionVal;
                /*0x30*/ System.Xml.Schema.XmlAtomicValue.NamespacePrefixForQName nsPrefix;

                /*0x386fb60*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, bool value);
                /*0x386fbf4*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, System.DateTime value);
                /*0x386fc84*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, double value);
                /*0x386fd1c*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, int value);
                /*0x386fdac*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, long value);
                /*0x386fe3c*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, string value);
                /*0x386fef0*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, string value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x38701dc*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, object value);
                /*0x3870290*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x38704bc*/ object System.ICloneable.Clone();
                /*0x38704c0*/ System.Xml.Schema.XmlSchemaType get_XmlType();
                /*0x38704c8*/ System.Type get_ValueType();
                /*0x38704f0*/ object get_TypedValue();
                /*0x38706b8*/ bool get_ValueAsBoolean();
                /*0x3870788*/ System.DateTime get_ValueAsDateTime();
                /*0x387086c*/ double get_ValueAsDouble();
                /*0x387094c*/ int get_ValueAsInt();
                /*0x3870a24*/ long get_ValueAsLong();
                /*0x3870b08*/ object ValueAs(System.Type type, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x3870d30*/ string get_Value();
                /*0x3870e28*/ string ToString();
                /*0x38700d8*/ string GetPrefixFromQName(string value);

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

                    /*0x3870198*/ NamespacePrefixForQName(string prefix, string ns);
                    /*0x3870e34*/ string LookupNamespace(string prefix);
                    /*0x3870e68*/ string LookupPrefix(string namespaceName);
                    /*0x3870e94*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
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

                static /*0x3872c28*/ XmlSchema();
                static /*0x3871114*/ System.Xml.Schema.XmlSchema Read(System.Xml.XmlReader reader, System.Xml.Schema.ValidationEventHandler validationEventHandler);
                /*0x3870f38*/ XmlSchema();
                /*0x38712c8*/ bool CompileSchema(System.Xml.Schema.XmlSchemaCollection xsc, System.Xml.XmlResolver resolver, System.Xml.Schema.SchemaInfo schemaInfo, string ns, System.Xml.Schema.ValidationEventHandler validationEventHandler, System.Xml.XmlNameTable nameTable, bool CompileContentModel);
                /*0x38714bc*/ void CompileSchemaInSet(System.Xml.XmlNameTable nameTable, System.Xml.Schema.ValidationEventHandler eventHandler, System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings);
                /*0x387156c*/ System.Xml.Schema.XmlSchemaForm get_AttributeFormDefault();
                /*0x3871574*/ void set_AttributeFormDefault(System.Xml.Schema.XmlSchemaForm value);
                /*0x387157c*/ System.Xml.Schema.XmlSchemaDerivationMethod get_BlockDefault();
                /*0x3871584*/ void set_BlockDefault(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x387158c*/ System.Xml.Schema.XmlSchemaDerivationMethod get_FinalDefault();
                /*0x3871594*/ void set_FinalDefault(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x387159c*/ System.Xml.Schema.XmlSchemaForm get_ElementFormDefault();
                /*0x38715a4*/ void set_ElementFormDefault(System.Xml.Schema.XmlSchemaForm value);
                /*0x38715ac*/ string get_TargetNamespace();
                /*0x38715b4*/ void set_TargetNamespace(string value);
                /*0x38715bc*/ string get_Version();
                /*0x38715c4*/ void set_Version(string value);
                /*0x38715cc*/ System.Xml.Schema.XmlSchemaObjectCollection get_Includes();
                /*0x38715d4*/ System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                /*0x38715dc*/ bool get_IsCompiledBySet();
                /*0x38715e4*/ void set_IsCompiledBySet(bool value);
                /*0x38715ec*/ bool get_IsPreprocessed();
                /*0x38715f4*/ void set_IsPreprocessed(bool value);
                /*0x38715fc*/ bool get_IsRedefined();
                /*0x3871604*/ void set_IsRedefined(bool value);
                /*0x387160c*/ System.Xml.Schema.XmlSchemaObjectTable get_Attributes();
                /*0x387167c*/ System.Xml.Schema.XmlSchemaObjectTable get_AttributeGroups();
                /*0x38716ec*/ System.Xml.Schema.XmlSchemaObjectTable get_SchemaTypes();
                /*0x387175c*/ System.Xml.Schema.XmlSchemaObjectTable get_Elements();
                /*0x38717cc*/ string get_Id();
                /*0x38717d4*/ void set_Id(string value);
                /*0x38717dc*/ System.Xml.Schema.XmlSchemaObjectTable get_Groups();
                /*0x38717e4*/ System.Xml.Schema.XmlSchemaObjectTable get_Notations();
                /*0x38717ec*/ System.Xml.Schema.XmlSchemaObjectTable get_IdentityConstraints();
                /*0x38717f4*/ System.Uri get_BaseUri();
                /*0x38717fc*/ void set_BaseUri(System.Uri value);
                /*0x3871804*/ int get_SchemaId();
                /*0x3871874*/ bool get_IsChameleon();
                /*0x387187c*/ void set_IsChameleon(bool value);
                /*0x3871884*/ System.Collections.Hashtable get_Ids();
                /*0x387188c*/ System.Xml.XmlDocument get_Document();
                /*0x38718fc*/ int get_ErrorCount();
                /*0x3871904*/ void set_ErrorCount(int value);
                /*0x387190c*/ System.Xml.Schema.XmlSchema Clone();
                /*0x3871a54*/ System.Xml.Schema.XmlSchema DeepClone();
                /*0x3872954*/ string get_IdAttribute();
                /*0x387295c*/ void set_IdAttribute(string value);
                /*0x3872964*/ void SetIsCompiled(bool isCompiled);
                /*0x387296c*/ void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes);
                /*0x3872974*/ void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
                /*0x3872988*/ System.Collections.ArrayList get_ImportedSchemas();
                /*0x38729f8*/ System.Collections.ArrayList get_ImportedNamespaces();
                /*0x3872a68*/ void GetExternalSchemasList(System.Collections.IList extList, System.Xml.Schema.XmlSchema schema);
            }

            class XmlSchemaAll : System.Xml.Schema.XmlSchemaGroupBase
            {
                /*0x78*/ System.Xml.Schema.XmlSchemaObjectCollection items;

                /*0x3872cc4*/ XmlSchemaAll();
                /*0x3872c74*/ System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                /*0x3872c7c*/ bool get_IsEmpty();
                /*0x3872cbc*/ void SetItems(System.Xml.Schema.XmlSchemaObjectCollection newItems);
            }

            class XmlSchemaAnnotated : System.Xml.Schema.XmlSchemaObject
            {
                /*0x38*/ string id;
                /*0x40*/ System.Xml.Schema.XmlSchemaAnnotation annotation;
                /*0x48*/ System.Xml.XmlAttribute[] moreAttributes;

                /*0x3872dd4*/ XmlSchemaAnnotated();
                /*0x3872d84*/ string get_Id();
                /*0x3872d8c*/ void set_Id(string value);
                /*0x3872d94*/ System.Xml.Schema.XmlSchemaAnnotation get_Annotation();
                /*0x3872d9c*/ void set_Annotation(System.Xml.Schema.XmlSchemaAnnotation value);
                /*0x3872da4*/ System.Xml.XmlAttribute[] get_UnhandledAttributes();
                /*0x3872dac*/ void set_UnhandledAttributes(System.Xml.XmlAttribute[] value);
                /*0x3872db4*/ string get_IdAttribute();
                /*0x3872dbc*/ void set_IdAttribute(string value);
                /*0x3872dc4*/ void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes);
                /*0x3872dcc*/ void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
            }

            class XmlSchemaAnnotation : System.Xml.Schema.XmlSchemaObject
            {
                /*0x38*/ string id;
                /*0x40*/ System.Xml.Schema.XmlSchemaObjectCollection items;
                /*0x48*/ System.Xml.XmlAttribute[] moreAttributes;

                /*0x3872e0c*/ XmlSchemaAnnotation();
                /*0x3872ddc*/ string get_Id();
                /*0x3872de4*/ void set_Id(string value);
                /*0x3872dec*/ System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                /*0x3872df4*/ string get_IdAttribute();
                /*0x3872dfc*/ void set_IdAttribute(string value);
                /*0x3872e04*/ void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes);
            }

            class XmlSchemaAny : System.Xml.Schema.XmlSchemaParticle
            {
                /*0x78*/ string ns;
                /*0x80*/ System.Xml.Schema.XmlSchemaContentProcessing processContents;
                /*0x88*/ System.Xml.Schema.NamespaceList namespaceList;

                /*0x3873514*/ XmlSchemaAny();
                /*0x3872e78*/ string get_Namespace();
                /*0x3872e80*/ void set_Namespace(string value);
                /*0x3872e88*/ void set_ProcessContents(System.Xml.Schema.XmlSchemaContentProcessing value);
                /*0x3872e90*/ System.Xml.Schema.NamespaceList get_NamespaceList();
                /*0x3872e98*/ string get_ResolvedNamespace();
                /*0x3872ef0*/ System.Xml.Schema.XmlSchemaContentProcessing get_ProcessContentsCorrect();
                /*0x3872f04*/ string get_NameString();
                /*0x38733bc*/ void BuildNamespaceList(string targetNamespace);
                /*0x3873444*/ void BuildNamespaceListV1Compat(string targetNamespace);
                /*0x38734ec*/ bool Allows(System.Xml.XmlQualifiedName qname);
            }

            class XmlSchemaAnyAttribute : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ string ns;
                /*0x58*/ System.Xml.Schema.XmlSchemaContentProcessing processContents;
                /*0x60*/ System.Xml.Schema.NamespaceList namespaceList;

                static /*0x38736f8*/ bool IsSubset(System.Xml.Schema.XmlSchemaAnyAttribute sub, System.Xml.Schema.XmlSchemaAnyAttribute super);
                static /*0x387371c*/ System.Xml.Schema.XmlSchemaAnyAttribute Intersection(System.Xml.Schema.XmlSchemaAnyAttribute o1, System.Xml.Schema.XmlSchemaAnyAttribute o2, bool v1Compat);
                static /*0x38737e8*/ System.Xml.Schema.XmlSchemaAnyAttribute Union(System.Xml.Schema.XmlSchemaAnyAttribute o1, System.Xml.Schema.XmlSchemaAnyAttribute o2, bool v1Compat);
                /*0x38737e0*/ XmlSchemaAnyAttribute();
                /*0x387356c*/ void set_Namespace(string value);
                /*0x3873574*/ System.Xml.Schema.XmlSchemaContentProcessing get_ProcessContents();
                /*0x387357c*/ void set_ProcessContents(System.Xml.Schema.XmlSchemaContentProcessing value);
                /*0x3873584*/ System.Xml.Schema.NamespaceList get_NamespaceList();
                /*0x387358c*/ System.Xml.Schema.XmlSchemaContentProcessing get_ProcessContentsCorrect();
                /*0x38735a0*/ void BuildNamespaceList(string targetNamespace);
                /*0x3873628*/ void BuildNamespaceListV1Compat(string targetNamespace);
                /*0x38736d0*/ bool Allows(System.Xml.XmlQualifiedName qname);
            }

            class XmlSchemaAppInfo : System.Xml.Schema.XmlSchemaObject
            {
                /*0x38*/ string source;
                /*0x40*/ System.Xml.XmlNode[] markup;

                /*0x38738c4*/ XmlSchemaAppInfo();
                /*0x38738ac*/ void set_Source(string value);
                /*0x38738b4*/ System.Xml.XmlNode[] get_Markup();
                /*0x38738bc*/ void set_Markup(System.Xml.XmlNode[] value);
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

                /*0x3873bd8*/ XmlSchemaAttribute();
                /*0x38738cc*/ string get_DefaultValue();
                /*0x38738d4*/ void set_DefaultValue(string value);
                /*0x38738dc*/ string get_FixedValue();
                /*0x38738e4*/ void set_FixedValue(string value);
                /*0x38738ec*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0x38738f4*/ void set_Form(System.Xml.Schema.XmlSchemaForm value);
                /*0x38738fc*/ string get_Name();
                /*0x3873904*/ void set_Name(string value);
                /*0x387390c*/ System.Xml.XmlQualifiedName get_RefName();
                /*0x3873914*/ void set_RefName(System.Xml.XmlQualifiedName value);
                /*0x38739b4*/ System.Xml.XmlQualifiedName get_SchemaTypeName();
                /*0x38739bc*/ void set_SchemaTypeName(System.Xml.XmlQualifiedName value);
                /*0x3873a5c*/ System.Xml.Schema.XmlSchemaSimpleType get_SchemaType();
                /*0x3873a64*/ void set_SchemaType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0x3873a6c*/ System.Xml.Schema.XmlSchemaUse get_Use();
                /*0x3873a74*/ void set_Use(System.Xml.Schema.XmlSchemaUse value);
                /*0x3873a7c*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0x3873a84*/ System.Xml.Schema.XmlSchemaSimpleType get_AttributeSchemaType();
                /*0x3873a8c*/ System.Xml.Schema.XmlSchemaDatatype get_Datatype();
                /*0x3873aa4*/ void SetQualifiedName(System.Xml.XmlQualifiedName value);
                /*0x3873aac*/ void SetAttributeType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0x3873ab4*/ System.Xml.Schema.SchemaAttDef get_AttDef();
                /*0x3873abc*/ void set_AttDef(System.Xml.Schema.SchemaAttDef value);
                /*0x3873ac4*/ string get_NameAttribute();
                /*0x3873acc*/ void set_NameAttribute(string value);
                /*0x3873ad4*/ System.Xml.Schema.XmlSchemaObject Clone();
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

                /*0x387421c*/ XmlSchemaAttributeGroup();
                /*0x3873c78*/ string get_Name();
                /*0x3873c80*/ void set_Name(string value);
                /*0x3873c88*/ System.Xml.Schema.XmlSchemaObjectCollection get_Attributes();
                /*0x3873c90*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0x3873c98*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x3873ca0*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0x3873ca8*/ System.Xml.Schema.XmlSchemaObjectTable get_AttributeUses();
                /*0x3873d18*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AttributeWildcard();
                /*0x3873d20*/ void set_AttributeWildcard(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x3873d28*/ System.Xml.Schema.XmlSchemaAttributeGroup get_RedefinedAttributeGroup();
                /*0x3873d30*/ System.Xml.Schema.XmlSchemaAttributeGroup get_Redefined();
                /*0x3873d38*/ void set_Redefined(System.Xml.Schema.XmlSchemaAttributeGroup value);
                /*0x3873d40*/ int get_SelfReferenceCount();
                /*0x3873d48*/ void set_SelfReferenceCount(int value);
                /*0x3873d50*/ string get_NameAttribute();
                /*0x3873d58*/ void set_NameAttribute(string value);
                /*0x3873d60*/ void SetQualifiedName(System.Xml.XmlQualifiedName value);
                /*0x3873d68*/ System.Xml.Schema.XmlSchemaObject Clone();
            }

            class XmlSchemaAttributeGroupRef : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ System.Xml.XmlQualifiedName refName;

                /*0x3874374*/ XmlSchemaAttributeGroupRef();
                /*0x38742cc*/ System.Xml.XmlQualifiedName get_RefName();
                /*0x38742d4*/ void set_RefName(System.Xml.XmlQualifiedName value);
            }

            class XmlSchemaChoice : System.Xml.Schema.XmlSchemaGroupBase
            {
                /*0x78*/ System.Xml.Schema.XmlSchemaObjectCollection items;

                /*0x38743fc*/ XmlSchemaChoice();
                /*0x38743e4*/ System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                /*0x38743ec*/ bool get_IsEmpty();
                /*0x38743f4*/ void SetItems(System.Xml.Schema.XmlSchemaObjectCollection newItems);
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

                /*0x3874464*/ XmlSchemaCollection(System.Xml.XmlNameTable nametable);
                /*0x38745a8*/ int get_Count();
                /*0x38745c8*/ System.Xml.XmlNameTable get_NameTable();
                /*0x38745d0*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x38745d8*/ System.Xml.Schema.XmlSchema get_Item(string ns);
                /*0x3874670*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x3874718*/ System.Xml.Schema.XmlSchemaCollectionEnumerator GetEnumerator();
                /*0x3874774*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x3874a00*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x3874a08*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x3874a0c*/ int System.Collections.ICollection.get_Count();
                /*0x386f510*/ System.Xml.Schema.SchemaInfo GetSchemaInfo(string ns);
                /*0x3874a2c*/ System.Xml.Schema.SchemaNames GetSchemaNames(System.Xml.XmlNameTable nt);
                /*0x386dc40*/ System.Xml.Schema.XmlSchema Add(string ns, System.Xml.Schema.SchemaInfo schemaInfo, System.Xml.Schema.XmlSchema schema, bool compile);
                /*0x3874ad0*/ System.Xml.Schema.XmlSchema Add(string ns, System.Xml.Schema.SchemaInfo schemaInfo, System.Xml.Schema.XmlSchema schema, bool compile, System.Xml.XmlResolver resolver);
                /*0x3874c3c*/ void Add(string ns, System.Xml.Schema.XmlSchemaCollectionNode node);
                /*0x3874d7c*/ System.Xml.Schema.ValidationEventHandler get_EventHandler();
                /*0x3874d84*/ void set_EventHandler(System.Xml.Schema.ValidationEventHandler value);
            }

            class XmlSchemaCollectionNode
            {
                /*0x10*/ string namespaceUri;
                /*0x18*/ System.Xml.Schema.SchemaInfo schemaInfo;
                /*0x20*/ System.Xml.Schema.XmlSchema schema;

                /*0x3874c34*/ XmlSchemaCollectionNode();
                /*0x3874d8c*/ void set_NamespaceURI(string value);
                /*0x3874d94*/ System.Xml.Schema.SchemaInfo get_SchemaInfo();
                /*0x3874d9c*/ void set_SchemaInfo(System.Xml.Schema.SchemaInfo value);
                /*0x3874da4*/ System.Xml.Schema.XmlSchema get_Schema();
                /*0x3874dac*/ void set_Schema(System.Xml.Schema.XmlSchema value);
            }

            class XmlSchemaCollectionEnumerator : System.Collections.IEnumerator
            {
                /*0x10*/ System.Collections.IDictionaryEnumerator enumerator;

                /*0x38746cc*/ XmlSchemaCollectionEnumerator(System.Collections.Hashtable collection);
                /*0x3874db4*/ void System.Collections.IEnumerator.Reset();
                /*0x3874e58*/ bool System.Collections.IEnumerator.MoveNext();
                /*0x3874960*/ bool MoveNext();
                /*0x3874ef8*/ object System.Collections.IEnumerator.get_Current();
                /*0x3874888*/ System.Xml.Schema.XmlSchema get_Current();
                /*0x3874efc*/ System.Xml.Schema.XmlSchemaCollectionNode get_CurrentNode();
            }

            class XmlSchemaCompilationSettings
            {
                /*0x10*/ bool enableUpaCheck;

                /*0x3874fd0*/ XmlSchemaCompilationSettings();
                /*0x3874ff0*/ bool get_EnableUpaCheck();
            }

            class XmlSchemaComplexContent : System.Xml.Schema.XmlSchemaContentModel
            {
                /*0x50*/ System.Xml.Schema.XmlSchemaContent content;
                /*0x58*/ bool isMixed;
                /*0x59*/ bool hasMixedAttribute;

                /*0x3875028*/ XmlSchemaComplexContent();
                /*0x3874ff8*/ bool get_IsMixed();
                /*0x3875000*/ void set_IsMixed(bool value);
                /*0x3875010*/ System.Xml.Schema.XmlSchemaContent get_Content();
                /*0x3875018*/ void set_Content(System.Xml.Schema.XmlSchemaContent value);
                /*0x3875020*/ bool get_HasMixedAttribute();
            }

            class XmlSchemaComplexContentExtension : System.Xml.Schema.XmlSchemaContent
            {
                /*0x50*/ System.Xml.Schema.XmlSchemaParticle particle;
                /*0x58*/ System.Xml.Schema.XmlSchemaObjectCollection attributes;
                /*0x60*/ System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;
                /*0x68*/ System.Xml.XmlQualifiedName baseTypeName;

                /*0x3875110*/ XmlSchemaComplexContentExtension();
                /*0x3875038*/ System.Xml.XmlQualifiedName get_BaseTypeName();
                /*0x3875040*/ void set_BaseTypeName(System.Xml.XmlQualifiedName value);
                /*0x38750e0*/ System.Xml.Schema.XmlSchemaParticle get_Particle();
                /*0x38750e8*/ void set_Particle(System.Xml.Schema.XmlSchemaParticle value);
                /*0x38750f0*/ System.Xml.Schema.XmlSchemaObjectCollection get_Attributes();
                /*0x38750f8*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0x3875100*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x3875108*/ void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes);
            }

            class XmlSchemaComplexContentRestriction : System.Xml.Schema.XmlSchemaContent
            {
                /*0x50*/ System.Xml.Schema.XmlSchemaParticle particle;
                /*0x58*/ System.Xml.Schema.XmlSchemaObjectCollection attributes;
                /*0x60*/ System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;
                /*0x68*/ System.Xml.XmlQualifiedName baseTypeName;

                /*0x38752a0*/ XmlSchemaComplexContentRestriction();
                /*0x38751c8*/ System.Xml.XmlQualifiedName get_BaseTypeName();
                /*0x38751d0*/ void set_BaseTypeName(System.Xml.XmlQualifiedName value);
                /*0x3875270*/ System.Xml.Schema.XmlSchemaParticle get_Particle();
                /*0x3875278*/ void set_Particle(System.Xml.Schema.XmlSchemaParticle value);
                /*0x3875280*/ System.Xml.Schema.XmlSchemaObjectCollection get_Attributes();
                /*0x3875288*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0x3875290*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x3875298*/ void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes);
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

                static /*0x3875350*/ XmlSchemaComplexType();
                static /*0x3875574*/ System.Xml.Schema.XmlSchemaComplexType CreateAnyType(System.Xml.Schema.XmlSchemaContentProcessing processContents);
                static /*0x38759b0*/ System.Xml.Schema.XmlSchemaComplexType get_AnyType();
                static /*0x3875a08*/ System.Xml.Schema.XmlSchemaComplexType get_UntypedAnyType();
                static /*0x3875940*/ System.Xml.Schema.ContentValidator get_AnyTypeContentValidator();
                static /*0x3873fdc*/ System.Xml.Schema.XmlSchemaObjectCollection CloneAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes);
                static /*0x3876644*/ System.Xml.Schema.XmlSchemaObjectCollection CloneGroupBaseParticles(System.Xml.Schema.XmlSchemaObjectCollection groupBaseParticles, System.Xml.Schema.XmlSchema parentSchema);
                static /*0x3876280*/ System.Xml.Schema.XmlSchemaParticle CloneParticle(System.Xml.Schema.XmlSchemaParticle particle, System.Xml.Schema.XmlSchema parentSchema);
                static /*0x3876824*/ System.Xml.Schema.XmlSchemaForm GetResolvedElementForm(System.Xml.Schema.XmlSchema parentSchema, System.Xml.Schema.XmlSchemaElement element);
                static /*0x3876004*/ bool HasParticleRef(System.Xml.Schema.XmlSchemaParticle particle, System.Xml.Schema.XmlSchema parentSchema);
                static /*0x3873e74*/ bool HasAttributeQNameRef(System.Xml.Schema.XmlSchemaObjectCollection attributes);
                /*0x38758c8*/ XmlSchemaComplexType();
                /*0x3875a60*/ bool get_IsAbstract();
                /*0x3875a6c*/ void set_IsAbstract(bool value);
                /*0x3875a8c*/ System.Xml.Schema.XmlSchemaDerivationMethod get_Block();
                /*0x3875a94*/ void set_Block(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x3875a9c*/ bool get_IsMixed();
                /*0x3875aa8*/ void set_IsMixed(bool value);
                /*0x3875ac8*/ System.Xml.Schema.XmlSchemaContentModel get_ContentModel();
                /*0x3875ad0*/ void set_ContentModel(System.Xml.Schema.XmlSchemaContentModel value);
                /*0x3875ad8*/ System.Xml.Schema.XmlSchemaParticle get_Particle();
                /*0x3875ae0*/ void set_Particle(System.Xml.Schema.XmlSchemaParticle value);
                /*0x3875ae8*/ System.Xml.Schema.XmlSchemaObjectCollection get_Attributes();
                /*0x3875b58*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0x3875b60*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x3875b68*/ System.Xml.Schema.XmlSchemaContentType get_ContentType();
                /*0x3875b70*/ System.Xml.Schema.XmlSchemaParticle get_ContentTypeParticle();
                /*0x3875b78*/ System.Xml.Schema.XmlSchemaDerivationMethod get_BlockResolved();
                /*0x3875b80*/ System.Xml.Schema.XmlSchemaObjectTable get_AttributeUses();
                /*0x3875bf0*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AttributeWildcard();
                /*0x3875bf8*/ System.Xml.Schema.XmlSchemaObjectTable get_LocalElements();
                /*0x3875c68*/ void SetContentTypeParticle(System.Xml.Schema.XmlSchemaParticle value);
                /*0x3875c70*/ void SetBlockResolved(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x3875c78*/ void SetAttributeWildcard(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x3875c80*/ void set_HasWildCard(bool value);
                /*0x3875c94*/ void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes);
                /*0x3875c9c*/ bool ContainsIdAttribute(bool findAll);
                /*0x3875ffc*/ System.Xml.Schema.XmlSchemaObject Clone();
                /*0x3871d84*/ System.Xml.Schema.XmlSchemaObject Clone(System.Xml.Schema.XmlSchema parentSchema);
                /*0x3876524*/ void ClearCompiledState();
            }

            class XmlSchemaContent : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x38751c0*/ XmlSchemaContent();
            }

            class XmlSchemaContentModel : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x3875030*/ XmlSchemaContentModel();
                /*0x1f30214*/ System.Xml.Schema.XmlSchemaContent get_Content();
                /*0x1f30ebc*/ void set_Content(System.Xml.Schema.XmlSchemaContent value);
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
                static /*0x3876e28*/ string ConcatenatedToString(object value);
                static /*0x386964c*/ System.Xml.Schema.XmlSchemaDatatype FromXmlTokenizedType(System.Xml.XmlTokenizedType token);
                static /*0x38774c8*/ System.Xml.Schema.XmlSchemaDatatype FromXmlTokenizedTypeXsd(System.Xml.XmlTokenizedType token);
                static /*0x3867eb0*/ System.Xml.Schema.XmlSchemaDatatype FromXdrName(string name);
                static /*0x3877520*/ System.Xml.Schema.XmlSchemaDatatype DeriveByUnion(System.Xml.Schema.XmlSchemaSimpleType[] types, System.Xml.Schema.XmlSchemaType schemaType);
                static /*0x3865a3c*/ string XdrCanonizeUri(string uri, System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames);
                /*0x3877588*/ XmlSchemaDatatype();
                /*0x1f30214*/ System.Type get_ValueType();
                /*0x1f2ffc8*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x1f303d0*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
                /*0x3876848*/ System.Xml.Schema.XmlSchemaDatatypeVariety get_Variety();
                /*0x3876850*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x3876858*/ bool IsDerivedFrom(System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1f2fe14*/ bool get_HasLexicalFacets();
                /*0x1f2fe14*/ bool get_HasValueFacets();
                /*0x1f30214*/ System.Xml.Schema.XmlValueConverter get_ValueConverter();
                /*0x1f30214*/ System.Xml.Schema.RestrictionFacets get_Restriction();
                int Compare(object value1, object value2);
                object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, bool createAtomicValue);
                /*0x1f3040c*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
                /*0x1f3040c*/ System.Exception TryParseValue(object value, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver namespaceResolver, ref object typedValue);
                /*0x1f30214*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1f2ffc8*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1f303d0*/ System.Xml.Schema.XmlSchemaDatatype DeriveByRestriction(System.Xml.Schema.XmlSchemaObjectCollection facets, System.Xml.XmlNameTable nameTable, System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1f302cc*/ System.Xml.Schema.XmlSchemaDatatype DeriveByList(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1f30ff0*/ void VerifySchemaValid(System.Xml.Schema.XmlSchemaObjectTable notations, System.Xml.Schema.XmlSchemaObject caller);
                /*0x1f2ff00*/ bool IsEqual(object o1, object o2);
                /*0x1f2fec8*/ bool IsComparable(System.Xml.Schema.XmlSchemaDatatype dtype);
                /*0x3876860*/ string get_TypeCodeString();
                /*0x387697c*/ string TypeCodeToString(System.Xml.Schema.XmlTypeCode typeCode);
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

                static /*0x387767c*/ XmlSchemaDocumentation();
                /*0x3877674*/ XmlSchemaDocumentation();
                /*0x3877590*/ void set_Source(string value);
                /*0x3877598*/ void set_Language(string value);
                /*0x387766c*/ void set_Markup(System.Xml.XmlNode[] value);
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

                /*0x3877b30*/ XmlSchemaElement();
                /*0x3877760*/ bool get_IsAbstract();
                /*0x3877768*/ void set_IsAbstract(bool value);
                /*0x3877778*/ System.Xml.Schema.XmlSchemaDerivationMethod get_Block();
                /*0x3877780*/ void set_Block(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x3877788*/ string get_DefaultValue();
                /*0x3877790*/ void set_DefaultValue(string value);
                /*0x3877798*/ System.Xml.Schema.XmlSchemaDerivationMethod get_Final();
                /*0x38777a0*/ void set_Final(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x38777a8*/ string get_FixedValue();
                /*0x38777b0*/ void set_FixedValue(string value);
                /*0x38777b8*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0x38777c0*/ void set_Form(System.Xml.Schema.XmlSchemaForm value);
                /*0x38777c8*/ string get_Name();
                /*0x38777d0*/ void set_Name(string value);
                /*0x38777d8*/ bool get_IsNillable();
                /*0x38777e0*/ void set_IsNillable(bool value);
                /*0x38777f0*/ bool get_HasNillableAttribute();
                /*0x38777f8*/ bool get_HasAbstractAttribute();
                /*0x3877800*/ System.Xml.XmlQualifiedName get_RefName();
                /*0x3877808*/ void set_RefName(System.Xml.XmlQualifiedName value);
                /*0x38778a8*/ System.Xml.XmlQualifiedName get_SubstitutionGroup();
                /*0x38778b0*/ void set_SubstitutionGroup(System.Xml.XmlQualifiedName value);
                /*0x3877950*/ System.Xml.XmlQualifiedName get_SchemaTypeName();
                /*0x3877958*/ void set_SchemaTypeName(System.Xml.XmlQualifiedName value);
                /*0x38779f8*/ System.Xml.Schema.XmlSchemaType get_SchemaType();
                /*0x3877a00*/ void set_SchemaType(System.Xml.Schema.XmlSchemaType value);
                /*0x3877a08*/ System.Xml.Schema.XmlSchemaObjectCollection get_Constraints();
                /*0x3877a78*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0x3877a80*/ System.Xml.Schema.XmlSchemaType get_ElementSchemaType();
                /*0x3877a88*/ System.Xml.Schema.XmlSchemaDerivationMethod get_BlockResolved();
                /*0x3877a90*/ System.Xml.Schema.XmlSchemaDerivationMethod get_FinalResolved();
                /*0x3877a98*/ void SetQualifiedName(System.Xml.XmlQualifiedName value);
                /*0x3877aa0*/ void SetElementType(System.Xml.Schema.XmlSchemaType value);
                /*0x3877aa8*/ void SetBlockResolved(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x3877ab0*/ void SetFinalResolved(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x3877ab8*/ bool get_HasConstraints();
                /*0x3877adc*/ bool get_IsLocalTypeDerivationChecked();
                /*0x3877ae4*/ void set_IsLocalTypeDerivationChecked(bool value);
                /*0x3877aec*/ System.Xml.Schema.SchemaElementDecl get_ElementDecl();
                /*0x3877af4*/ void set_ElementDecl(System.Xml.Schema.SchemaElementDecl value);
                /*0x3877afc*/ string get_NameAttribute();
                /*0x3877b04*/ void set_NameAttribute(string value);
                /*0x3877b0c*/ string get_NameString();
                /*0x3877b28*/ System.Xml.Schema.XmlSchemaObject Clone();
                /*0x3872498*/ System.Xml.Schema.XmlSchemaObject Clone(System.Xml.Schema.XmlSchema parentSchema);
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

                static /*0x3877fc4*/ string CreateMessage(string res, string[] args);
                /*0x3877c14*/ XmlSchemaException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x38781f8*/ XmlSchemaException();
                /*0x387820c*/ XmlSchemaException(string message);
                /*0x387831c*/ XmlSchemaException(string message, System.Exception innerException);
                /*0x387821c*/ XmlSchemaException(string message, System.Exception innerException, int lineNumber, int linePosition);
                /*0x38783e0*/ XmlSchemaException(string res, string[] args);
                /*0x386fa94*/ XmlSchemaException(string res, string arg);
                /*0x386b1c8*/ XmlSchemaException(string res, string arg, string sourceUri, int lineNumber, int linePosition);
                /*0x387840c*/ XmlSchemaException(string res, string sourceUri, int lineNumber, int linePosition);
                /*0x386b0d4*/ XmlSchemaException(string res, string[] args, string sourceUri, int lineNumber, int linePosition);
                /*0x387843c*/ XmlSchemaException(string res, System.Xml.Schema.XmlSchemaObject source);
                /*0x3878478*/ XmlSchemaException(string res, string arg, System.Xml.Schema.XmlSchemaObject source);
                /*0x3878448*/ XmlSchemaException(string res, string[] args, System.Xml.Schema.XmlSchemaObject source);
                /*0x3878328*/ XmlSchemaException(string res, string[] args, System.Exception innerException, string sourceUri, int lineNumber, int linePosition, System.Xml.Schema.XmlSchemaObject source);
                /*0x3878088*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x3878518*/ string get_GetRes();
                /*0x3878520*/ string[] get_Args();
                /*0x3878528*/ string get_SourceUri();
                /*0x3878530*/ int get_LineNumber();
                /*0x3878538*/ int get_LinePosition();
                /*0x3878540*/ System.Xml.Schema.XmlSchemaObject get_SourceSchemaObject();
                /*0x386ef6c*/ void SetSource(string sourceUri, int lineNumber, int linePosition);
                /*0x3878548*/ void SetSchemaObject(System.Xml.Schema.XmlSchemaObject source);
                /*0x3878550*/ void SetSource(System.Xml.Schema.XmlSchemaObject source);
                /*0x3878594*/ string get_Message();
            }

            class XmlSchemaExternal : System.Xml.Schema.XmlSchemaObject
            {
                /*0x38*/ string location;
                /*0x40*/ System.Uri baseUri;
                /*0x48*/ System.Xml.Schema.XmlSchema schema;
                /*0x50*/ string id;
                /*0x58*/ System.Xml.XmlAttribute[] moreAttributes;
                /*0x60*/ System.Xml.Schema.Compositor compositor;

                /*0x3878614*/ XmlSchemaExternal();
                /*0x38785ac*/ string get_SchemaLocation();
                /*0x38785b4*/ void set_SchemaLocation(string value);
                /*0x38785bc*/ System.Xml.Schema.XmlSchema get_Schema();
                /*0x38785c4*/ void set_Schema(System.Xml.Schema.XmlSchema value);
                /*0x38785cc*/ string get_Id();
                /*0x38785d4*/ void set_Id(string value);
                /*0x38785dc*/ System.Uri get_BaseUri();
                /*0x38785e4*/ void set_BaseUri(System.Uri value);
                /*0x38785ec*/ string get_IdAttribute();
                /*0x38785f4*/ void set_IdAttribute(string value);
                /*0x38785fc*/ void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes);
                /*0x3878604*/ System.Xml.Schema.Compositor get_Compositor();
                /*0x387860c*/ void set_Compositor(System.Xml.Schema.Compositor value);
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

                /*0x38786f8*/ XmlSchemaFacet();
                /*0x387861c*/ string get_Value();
                /*0x3878624*/ void set_Value(string value);
                /*0x387862c*/ bool get_IsFixed();
                /*0x3878634*/ void set_IsFixed(bool value);
                /*0x38786e8*/ System.Xml.Schema.FacetType get_FacetType();
                /*0x38786f0*/ void set_FacetType(System.Xml.Schema.FacetType value);
            }

            class XmlSchemaNumericFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x3878700*/ XmlSchemaNumericFacet();
            }

            class XmlSchemaLengthFacet : System.Xml.Schema.XmlSchemaNumericFacet
            {
                /*0x3878708*/ XmlSchemaLengthFacet();
            }

            class XmlSchemaMinLengthFacet : System.Xml.Schema.XmlSchemaNumericFacet
            {
                /*0x3878728*/ XmlSchemaMinLengthFacet();
            }

            class XmlSchemaMaxLengthFacet : System.Xml.Schema.XmlSchemaNumericFacet
            {
                /*0x3878748*/ XmlSchemaMaxLengthFacet();
            }

            class XmlSchemaPatternFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x3878768*/ XmlSchemaPatternFacet();
            }

            class XmlSchemaEnumerationFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x3878788*/ XmlSchemaEnumerationFacet();
            }

            class XmlSchemaMinExclusiveFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x38787a8*/ XmlSchemaMinExclusiveFacet();
            }

            class XmlSchemaMinInclusiveFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x38787c8*/ XmlSchemaMinInclusiveFacet();
            }

            class XmlSchemaMaxExclusiveFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x38787e8*/ XmlSchemaMaxExclusiveFacet();
            }

            class XmlSchemaMaxInclusiveFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x3878808*/ XmlSchemaMaxInclusiveFacet();
            }

            class XmlSchemaTotalDigitsFacet : System.Xml.Schema.XmlSchemaNumericFacet
            {
                /*0x3878828*/ XmlSchemaTotalDigitsFacet();
            }

            class XmlSchemaFractionDigitsFacet : System.Xml.Schema.XmlSchemaNumericFacet
            {
                /*0x3878848*/ XmlSchemaFractionDigitsFacet();
            }

            class XmlSchemaWhiteSpaceFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x3878868*/ XmlSchemaWhiteSpaceFacet();
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

                /*0x3878900*/ XmlSchemaGroup();
                /*0x3878888*/ string get_Name();
                /*0x3878890*/ void set_Name(string value);
                /*0x3878898*/ System.Xml.Schema.XmlSchemaGroupBase get_Particle();
                /*0x38788a0*/ void set_Particle(System.Xml.Schema.XmlSchemaGroupBase value);
                /*0x38788a8*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0x38788b0*/ System.Xml.Schema.XmlSchemaParticle get_CanonicalParticle();
                /*0x38788b8*/ void set_CanonicalParticle(System.Xml.Schema.XmlSchemaParticle value);
                /*0x38788c0*/ System.Xml.Schema.XmlSchemaGroup get_Redefined();
                /*0x38788c8*/ void set_Redefined(System.Xml.Schema.XmlSchemaGroup value);
                /*0x38788d0*/ int get_SelfReferenceCount();
                /*0x38788d8*/ void set_SelfReferenceCount(int value);
                /*0x38788e0*/ string get_NameAttribute();
                /*0x38788e8*/ void set_NameAttribute(string value);
                /*0x38788f0*/ void SetQualifiedName(System.Xml.XmlQualifiedName value);
                /*0x38788f8*/ System.Xml.Schema.XmlSchemaObject Clone();
                /*0x38726cc*/ System.Xml.Schema.XmlSchemaObject Clone(System.Xml.Schema.XmlSchema parentSchema);
            }

            class XmlSchemaGroupBase : System.Xml.Schema.XmlSchemaParticle
            {
                /*0x3872d2c*/ XmlSchemaGroupBase();
                /*0x1f30214*/ System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                /*0x1f30ebc*/ void SetItems(System.Xml.Schema.XmlSchemaObjectCollection newItems);
            }

            class XmlSchemaGroupRef : System.Xml.Schema.XmlSchemaParticle
            {
                /*0x78*/ System.Xml.XmlQualifiedName refName;
                /*0x80*/ System.Xml.Schema.XmlSchemaGroupBase particle;
                /*0x88*/ System.Xml.Schema.XmlSchemaGroup refined;

                /*0x3878998*/ XmlSchemaGroupRef();
                /*0x3878970*/ System.Xml.XmlQualifiedName get_RefName();
                /*0x3876784*/ void set_RefName(System.Xml.XmlQualifiedName value);
                /*0x3878978*/ System.Xml.Schema.XmlSchemaGroupBase get_Particle();
                /*0x3878980*/ void SetParticle(System.Xml.Schema.XmlSchemaGroupBase value);
                /*0x3878988*/ System.Xml.Schema.XmlSchemaGroup get_Redefined();
                /*0x3878990*/ void set_Redefined(System.Xml.Schema.XmlSchemaGroup value);
            }

            class XmlSchemaIdentityConstraint : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ string name;
                /*0x58*/ System.Xml.Schema.XmlSchemaXPath selector;
                /*0x60*/ System.Xml.Schema.XmlSchemaObjectCollection fields;
                /*0x68*/ System.Xml.XmlQualifiedName qualifiedName;
                /*0x70*/ System.Xml.Schema.CompiledIdentityConstraint compiledConstraint;

                /*0x3878a84*/ XmlSchemaIdentityConstraint();
                /*0x3878a2c*/ string get_Name();
                /*0x3878a34*/ void set_Name(string value);
                /*0x3878a3c*/ System.Xml.Schema.XmlSchemaXPath get_Selector();
                /*0x3878a44*/ void set_Selector(System.Xml.Schema.XmlSchemaXPath value);
                /*0x3878a4c*/ System.Xml.Schema.XmlSchemaObjectCollection get_Fields();
                /*0x3878a54*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0x3878a5c*/ void SetQualifiedName(System.Xml.XmlQualifiedName value);
                /*0x3878a64*/ System.Xml.Schema.CompiledIdentityConstraint get_CompiledConstraint();
                /*0x3878a6c*/ void set_CompiledConstraint(System.Xml.Schema.CompiledIdentityConstraint value);
                /*0x3878a74*/ string get_NameAttribute();
                /*0x3878a7c*/ void set_NameAttribute(string value);
            }

            class XmlSchemaXPath : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ string xpath;

                /*0x3878b44*/ XmlSchemaXPath();
                /*0x3878b34*/ string get_XPath();
                /*0x3878b3c*/ void set_XPath(string value);
            }

            class XmlSchemaUnique : System.Xml.Schema.XmlSchemaIdentityConstraint
            {
                /*0x3878b4c*/ XmlSchemaUnique();
            }

            class XmlSchemaKey : System.Xml.Schema.XmlSchemaIdentityConstraint
            {
                /*0x3878b50*/ XmlSchemaKey();
            }

            class XmlSchemaKeyref : System.Xml.Schema.XmlSchemaIdentityConstraint
            {
                /*0x78*/ System.Xml.XmlQualifiedName refer;

                /*0x3878bfc*/ XmlSchemaKeyref();
                /*0x3878b54*/ System.Xml.XmlQualifiedName get_Refer();
                /*0x3878b5c*/ void set_Refer(System.Xml.XmlQualifiedName value);
            }

            class XmlSchemaImport : System.Xml.Schema.XmlSchemaExternal
            {
                /*0x68*/ string ns;
                /*0x70*/ System.Xml.Schema.XmlSchemaAnnotation annotation;

                /*0x3878c68*/ XmlSchemaImport();
                /*0x3878c88*/ string get_Namespace();
                /*0x3878c90*/ void set_Namespace(string value);
                /*0x3878c98*/ void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
            }

            class XmlSchemaInclude : System.Xml.Schema.XmlSchemaExternal
            {
                /*0x68*/ System.Xml.Schema.XmlSchemaAnnotation annotation;

                /*0x3878ca0*/ XmlSchemaInclude();
                /*0x3878cc0*/ void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
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

                /*0x3878cc8*/ XmlSchemaInfo();
                /*0x3878d40*/ XmlSchemaInfo(System.Xml.Schema.XmlSchemaValidity validity);
                /*0x3878d70*/ System.Xml.Schema.XmlSchemaValidity get_Validity();
                /*0x3878d78*/ void set_Validity(System.Xml.Schema.XmlSchemaValidity value);
                /*0x3878d80*/ bool get_IsDefault();
                /*0x3878d88*/ void set_IsDefault(bool value);
                /*0x3878d90*/ bool get_IsNil();
                /*0x3878d98*/ void set_IsNil(bool value);
                /*0x3878da0*/ System.Xml.Schema.XmlSchemaSimpleType get_MemberType();
                /*0x3878da8*/ void set_MemberType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0x3878db0*/ System.Xml.Schema.XmlSchemaType get_SchemaType();
                /*0x3878db8*/ void set_SchemaType(System.Xml.Schema.XmlSchemaType value);
                /*0x3878df8*/ System.Xml.Schema.XmlSchemaElement get_SchemaElement();
                /*0x3878e00*/ void set_SchemaElement(System.Xml.Schema.XmlSchemaElement value);
                /*0x3878e40*/ System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute();
                /*0x3878e48*/ void set_SchemaAttribute(System.Xml.Schema.XmlSchemaAttribute value);
                /*0x3878e88*/ System.Xml.Schema.XmlSchemaContentType get_ContentType();
                /*0x3878e90*/ System.Xml.Schema.XmlSchemaType get_XmlType();
                /*0x3878eac*/ bool get_HasDefaultValue();
                /*0x3878edc*/ bool get_IsUnionType();
                /*0x3878ce4*/ void Clear();
            }

            class XmlSchemaNotation : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ string name;
                /*0x58*/ string publicId;
                /*0x60*/ string systemId;
                /*0x68*/ System.Xml.XmlQualifiedName qname;

                /*0x3878f64*/ XmlSchemaNotation();
                /*0x3878f14*/ string get_Name();
                /*0x3878f1c*/ void set_Name(string value);
                /*0x3878f24*/ string get_Public();
                /*0x3878f2c*/ void set_Public(string value);
                /*0x3878f34*/ string get_System();
                /*0x3878f3c*/ void set_System(string value);
                /*0x3878f44*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0x3878f4c*/ void set_QualifiedName(System.Xml.XmlQualifiedName value);
                /*0x3878f54*/ string get_NameAttribute();
                /*0x3878f5c*/ void set_NameAttribute(string value);
            }

            class XmlSchemaObject
            {
                /*0x10*/ int lineNum;
                /*0x14*/ int linePos;
                /*0x18*/ string sourceUri;
                /*0x20*/ System.Xml.Serialization.XmlSerializerNamespaces namespaces;
                /*0x28*/ System.Xml.Schema.XmlSchemaObject parent;
                /*0x30*/ bool isProcessing;

                /*0x387110c*/ XmlSchemaObject();
                /*0x3878fd4*/ int get_LineNumber();
                /*0x3878fdc*/ void set_LineNumber(int value);
                /*0x3878fe4*/ int get_LinePosition();
                /*0x3878fec*/ void set_LinePosition(int value);
                /*0x3878ff4*/ string get_SourceUri();
                /*0x3878ffc*/ void set_SourceUri(string value);
                /*0x3879004*/ System.Xml.Schema.XmlSchemaObject get_Parent();
                /*0x387900c*/ void set_Parent(System.Xml.Schema.XmlSchemaObject value);
                /*0x38719e4*/ System.Xml.Serialization.XmlSerializerNamespaces get_Namespaces();
                /*0x3879014*/ void set_Namespaces(System.Xml.Serialization.XmlSerializerNamespaces value);
                /*0x387901c*/ void OnAdd(System.Xml.Schema.XmlSchemaObjectCollection container, object item);
                /*0x3879020*/ void OnRemove(System.Xml.Schema.XmlSchemaObjectCollection container, object item);
                /*0x3879024*/ void OnClear(System.Xml.Schema.XmlSchemaObjectCollection container);
                /*0x3879028*/ string get_IdAttribute();
                /*0x3879030*/ void set_IdAttribute(string value);
                /*0x3879034*/ void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes);
                /*0x3879038*/ void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
                /*0x387903c*/ string get_NameAttribute();
                /*0x3879044*/ void set_NameAttribute(string value);
                /*0x3879048*/ bool get_IsProcessing();
                /*0x3879050*/ void set_IsProcessing(bool value);
                /*0x3879058*/ System.Xml.Schema.XmlSchemaObject Clone();
            }

            class XmlSchemaObjectCollection : System.Collections.CollectionBase
            {
                /*0x18*/ System.Xml.Schema.XmlSchemaObject parent;

                /*0x3871104*/ XmlSchemaObjectCollection();
                /*0x38790d8*/ System.Xml.Schema.XmlSchemaObject get_Item(int index);
                /*0x38791d8*/ void set_Item(int index, System.Xml.Schema.XmlSchemaObject value);
                /*0x38792a0*/ System.Xml.Schema.XmlSchemaObjectEnumerator GetEnumerator();
                /*0x387289c*/ int Add(System.Xml.Schema.XmlSchemaObject item);
                /*0x3879320*/ void Insert(int index, System.Xml.Schema.XmlSchemaObject item);
                /*0x38793e8*/ void Remove(System.Xml.Schema.XmlSchemaObject item);
                /*0x38794a0*/ void OnInsert(int index, object item);
                /*0x38794bc*/ void OnSet(int index, object oldValue, object newValue);
                /*0x3879518*/ void OnClear();
                /*0x3879534*/ void OnRemove(int index, object item);
                /*0x38765c4*/ System.Xml.Schema.XmlSchemaObjectCollection Clone();
                /*0x3879550*/ void Add(System.Xml.Schema.XmlSchemaObjectCollection collToAdd);
            }

            class XmlSchemaObjectEnumerator : System.Collections.IEnumerator
            {
                /*0x10*/ System.Collections.IEnumerator enumerator;

                /*0x3879578*/ XmlSchemaObjectEnumerator(System.Collections.IEnumerator enumerator);
                /*0x38795a8*/ bool MoveNext();
                /*0x3879648*/ System.Xml.Schema.XmlSchemaObject get_Current();
                /*0x3879738*/ void System.Collections.IEnumerator.Reset();
                /*0x38797dc*/ bool System.Collections.IEnumerator.MoveNext();
                /*0x387987c*/ object System.Collections.IEnumerator.get_Current();
            }

            class XmlSchemaObjectTable
            {
                /*0x10*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.XmlSchemaObject> table;
                /*0x18*/ System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries;

                /*0x3879920*/ XmlSchemaObjectTable();
                /*0x38799fc*/ void Add(System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaObject value);
                /*0x3879af8*/ void Insert(System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaObject value);
                /*0x3879ccc*/ void Replace(System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaObject value);
                /*0x3879de0*/ void Clear();
                /*0x3879ea0*/ void Remove(System.Xml.XmlQualifiedName name);
                /*0x3879c20*/ int FindIndexByValue(System.Xml.Schema.XmlSchemaObject xso);
                /*0x3879f70*/ int get_Count();
                /*0x3879fc0*/ bool Contains(System.Xml.XmlQualifiedName name);
                /*0x387a018*/ System.Xml.Schema.XmlSchemaObject get_Item(System.Xml.XmlQualifiedName name);
                /*0x387a090*/ System.Collections.ICollection get_Values();
                /*0x387a16c*/ System.Collections.IDictionaryEnumerator GetEnumerator();

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

                    /*0x3879ac8*/ XmlSchemaObjectEntry(System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaObject value);
                }

                class ValuesCollection : System.Collections.ICollection, System.Collections.IEnumerable
                {
                    /*0x10*/ System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries;
                    /*0x18*/ int size;

                    /*0x387a130*/ ValuesCollection(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size);
                    /*0x387a268*/ int get_Count();
                    /*0x387a270*/ object get_SyncRoot();
                    /*0x387a314*/ bool get_IsSynchronized();
                    /*0x387a3b8*/ void CopyTo(System.Array array, int arrayIndex);
                    /*0x387a4e4*/ System.Collections.IEnumerator GetEnumerator();
                }

                class XSOEnumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries;
                    /*0x18*/ System.Xml.Schema.XmlSchemaObjectTable.EnumeratorType enumType;
                    /*0x1c*/ int currentIndex;
                    /*0x20*/ int size;
                    /*0x28*/ System.Xml.XmlQualifiedName currentKey;
                    /*0x30*/ System.Xml.Schema.XmlSchemaObject currentValue;

                    /*0x387a56c*/ XSOEnumerator(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, System.Xml.Schema.XmlSchemaObjectTable.EnumeratorType enumType);
                    /*0x387a5bc*/ object get_Current();
                    /*0x387a76c*/ bool MoveNext();
                    /*0x387a850*/ void Reset();
                }

                class XSODictionaryEnumerator : System.Xml.Schema.XmlSchemaObjectTable.XSOEnumerator, System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator
                {
                    /*0x387a218*/ XSODictionaryEnumerator(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, System.Xml.Schema.XmlSchemaObjectTable.EnumeratorType enumType);
                    /*0x387a880*/ System.Collections.DictionaryEntry get_Entry();
                    /*0x387a9c4*/ object get_Key();
                    /*0x387aaec*/ object get_Value();
                }
            }

            class XmlSchemaParticle : System.Xml.Schema.XmlSchemaAnnotated
            {
                static /*0x0*/ System.Xml.Schema.XmlSchemaParticle Empty;
                /*0x50*/ decimal minOccurs;
                /*0x60*/ decimal maxOccurs;
                /*0x70*/ System.Xml.Schema.XmlSchemaParticle.Occurs flags;

                static /*0x387b644*/ XmlSchemaParticle();
                /*0x387b5d0*/ XmlSchemaParticle();
                /*0x387ac14*/ string get_MinOccursString();
                /*0x387ac8c*/ void set_MinOccursString(string value);
                /*0x387ade0*/ string get_MaxOccursString();
                /*0x387af04*/ void set_MaxOccursString(string value);
                /*0x387b130*/ decimal get_MinOccurs();
                /*0x387b13c*/ void set_MinOccurs(decimal value);
                /*0x387b268*/ decimal get_MaxOccurs();
                /*0x387b274*/ void set_MaxOccurs(decimal value);
                /*0x387b3d8*/ bool get_IsEmpty();
                /*0x387b444*/ string get_NameString();
                /*0x387b45c*/ System.Xml.XmlQualifiedName GetQualifiedName();

                enum Occurs
                {
                    None = 0,
                    Min = 1,
                    Max = 2,
                }

                class EmptyParticle : System.Xml.Schema.XmlSchemaParticle
                {
                    /*0x387b6bc*/ EmptyParticle();
                    /*0x387b710*/ bool get_IsEmpty();
                }
            }

            class XmlSchemaRedefine : System.Xml.Schema.XmlSchemaExternal
            {
                /*0x68*/ System.Xml.Schema.XmlSchemaObjectCollection items;
                /*0x70*/ System.Xml.Schema.XmlSchemaObjectTable attributeGroups;
                /*0x78*/ System.Xml.Schema.XmlSchemaObjectTable types;
                /*0x80*/ System.Xml.Schema.XmlSchemaObjectTable groups;

                /*0x387b718*/ XmlSchemaRedefine();
                /*0x387b80c*/ System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                /*0x387b814*/ System.Xml.Schema.XmlSchemaObjectTable get_AttributeGroups();
                /*0x387b81c*/ System.Xml.Schema.XmlSchemaObjectTable get_SchemaTypes();
                /*0x387b824*/ System.Xml.Schema.XmlSchemaObjectTable get_Groups();
                /*0x387b82c*/ void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
            }

            class XmlSchemaSequence : System.Xml.Schema.XmlSchemaGroupBase
            {
                /*0x78*/ System.Xml.Schema.XmlSchemaObjectCollection items;

                /*0x387b890*/ XmlSchemaSequence();
                /*0x387b844*/ System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                /*0x387b84c*/ bool get_IsEmpty();
                /*0x387b888*/ void SetItems(System.Xml.Schema.XmlSchemaObjectCollection newItems);
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

                /*0x387b96c*/ XmlSchemaSet();
                /*0x387b9c8*/ XmlSchemaSet(System.Xml.XmlNameTable nameTable);
                /*0x387b8fc*/ object get_InternalSyncObject();
                /*0x387bcc0*/ void add_ValidationEventHandler(System.Xml.Schema.ValidationEventHandler value);
                /*0x387bdd0*/ void remove_ValidationEventHandler(System.Xml.Schema.ValidationEventHandler value);
                /*0x387be88*/ bool get_IsCompiled();
                /*0x387be90*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x387bea8*/ System.Xml.Schema.XmlSchemaCompilationSettings get_CompilationSettings();
                /*0x387beb0*/ void set_CompilationSettings(System.Xml.Schema.XmlSchemaCompilationSettings value);
                /*0x387beb8*/ int get_Count();
                /*0x387bed8*/ System.Xml.Schema.XmlSchemaObjectTable get_GlobalElements();
                /*0x387bf44*/ System.Xml.Schema.XmlSchemaObjectTable get_GlobalAttributes();
                /*0x387bfb0*/ System.Xml.Schema.XmlSchemaObjectTable get_GlobalTypes();
                /*0x387c01c*/ System.Xml.Schema.XmlSchemaObjectTable get_SubstitutionGroups();
                /*0x387c088*/ System.Collections.Hashtable get_SchemaLocations();
                /*0x387c090*/ System.Xml.Schema.XmlSchemaObjectTable get_TypeExtensions();
                /*0x387c0fc*/ void Add(System.Xml.Schema.XmlSchemaSet schemas);
                /*0x387e574*/ System.Xml.Schema.XmlSchema Add(System.Xml.Schema.XmlSchema schema);
                /*0x387e6fc*/ bool RemoveRecursive(System.Xml.Schema.XmlSchema schemaToRemove);
                /*0x387f500*/ bool Contains(string targetNamespace);
                /*0x387f548*/ void Compile();
                /*0x387fa60*/ System.Xml.Schema.XmlSchema Reprocess(System.Xml.Schema.XmlSchema schema);
                /*0x3881454*/ void CopyTo(System.Xml.Schema.XmlSchema[] schemas, int index);
                /*0x38815b8*/ System.Collections.ICollection Schemas();
                /*0x38811c4*/ System.Collections.ICollection Schemas(string targetNamespace);
                /*0x387e51c*/ System.Xml.Schema.XmlSchema Add(string targetNamespace, System.Xml.Schema.XmlSchema schema);
                /*0x388196c*/ void Add(string targetNamespace, System.Xml.XmlReader reader, System.Collections.Hashtable validatedNamespaces);
                /*0x387e2c8*/ System.Xml.Schema.XmlSchema FindSchemaByNSAndUrl(System.Uri schemaUri, string ns, System.Collections.DictionaryEntry[] locationsTable);
                /*0x38815d8*/ void AddSchemaToSet(System.Xml.Schema.XmlSchema schema);
                /*0x3882118*/ void ProcessNewSubstitutionGroups(System.Xml.Schema.XmlSchemaObjectTable substitutionGroupsTable, bool resolve);
                /*0x38825b8*/ void ResolveSubstitutionGroup(System.Xml.Schema.XmlSchemaSubstitutionGroup substitutionGroup, System.Xml.Schema.XmlSchemaObjectTable substTable);
                /*0x387f1a4*/ System.Xml.Schema.XmlSchema Remove(System.Xml.Schema.XmlSchema schema, bool forceCompile);
                /*0x387fa04*/ void ClearTables();
                /*0x3881328*/ bool PreprocessSchema(ref System.Xml.Schema.XmlSchema schema, string targetNamespace);
                /*0x3881fa0*/ System.Xml.Schema.XmlSchema ParseSchema(string targetNamespace, System.Xml.XmlReader reader);
                /*0x387ca00*/ void CopyFromCompiledSet(System.Xml.Schema.XmlSchemaSet otherSet);
                /*0x3882dcc*/ System.Xml.Schema.SchemaInfo get_CompiledInfo();
                /*0x3882dd4*/ System.Xml.XmlReaderSettings get_ReaderSettings();
                /*0x3882ddc*/ System.Xml.XmlResolver GetResolver();
                /*0x3882df4*/ System.Xml.Schema.ValidationEventHandler GetEventHandler();
                /*0x3882c04*/ System.Xml.Schema.SchemaNames GetSchemaNames(System.Xml.XmlNameTable nt);
                /*0x3881cf8*/ bool IsSchemaLoaded(System.Uri schemaUri, string targetNamespace, ref System.Xml.Schema.XmlSchema schema);
                /*0x3882dfc*/ bool GetSchemaByUri(System.Uri schemaUri, ref System.Xml.Schema.XmlSchema schema);
                /*0x387f0d4*/ string GetTargetNamespace(System.Xml.Schema.XmlSchema schema);
                /*0x3882f60*/ System.Collections.SortedList get_SortedSchemas();
                /*0x3880bc0*/ void RemoveSchemaFromCaches(System.Xml.Schema.XmlSchema schema);
                /*0x38801d8*/ void RemoveSchemaFromGlobalTables(System.Xml.Schema.XmlSchema schema);
                /*0x3882930*/ bool AddToTable(System.Xml.Schema.XmlSchemaObjectTable table, System.Xml.XmlQualifiedName qname, System.Xml.Schema.XmlSchemaObject item);
                /*0x3882ca8*/ void VerifyTables();
                /*0x3882f68*/ void InternalValidationCallback(object sender, System.Xml.Schema.ValidationEventArgs e);
                /*0x387f104*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity);
            }

            class XmlSchemaSimpleContent : System.Xml.Schema.XmlSchemaContentModel
            {
                /*0x50*/ System.Xml.Schema.XmlSchemaContent content;

                /*0x3882fbc*/ XmlSchemaSimpleContent();
                /*0x3882fac*/ System.Xml.Schema.XmlSchemaContent get_Content();
                /*0x3882fb4*/ void set_Content(System.Xml.Schema.XmlSchemaContent value);
            }

            class XmlSchemaSimpleContentExtension : System.Xml.Schema.XmlSchemaContent
            {
                /*0x50*/ System.Xml.Schema.XmlSchemaObjectCollection attributes;
                /*0x58*/ System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;
                /*0x60*/ System.Xml.XmlQualifiedName baseTypeName;

                /*0x388308c*/ XmlSchemaSimpleContentExtension();
                /*0x3882fc4*/ System.Xml.XmlQualifiedName get_BaseTypeName();
                /*0x3882fcc*/ void set_BaseTypeName(System.Xml.XmlQualifiedName value);
                /*0x388306c*/ System.Xml.Schema.XmlSchemaObjectCollection get_Attributes();
                /*0x3883074*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0x388307c*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x3883084*/ void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes);
            }

            class XmlSchemaSimpleContentRestriction : System.Xml.Schema.XmlSchemaContent
            {
                /*0x50*/ System.Xml.XmlQualifiedName baseTypeName;
                /*0x58*/ System.Xml.Schema.XmlSchemaSimpleType baseType;
                /*0x60*/ System.Xml.Schema.XmlSchemaObjectCollection facets;
                /*0x68*/ System.Xml.Schema.XmlSchemaObjectCollection attributes;
                /*0x70*/ System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;

                /*0x388321c*/ XmlSchemaSimpleContentRestriction();
                /*0x388313c*/ System.Xml.XmlQualifiedName get_BaseTypeName();
                /*0x3883144*/ void set_BaseTypeName(System.Xml.XmlQualifiedName value);
                /*0x38831e4*/ System.Xml.Schema.XmlSchemaSimpleType get_BaseType();
                /*0x38831ec*/ void set_BaseType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0x38831f4*/ System.Xml.Schema.XmlSchemaObjectCollection get_Facets();
                /*0x38831fc*/ System.Xml.Schema.XmlSchemaObjectCollection get_Attributes();
                /*0x3883204*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0x388320c*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x3883214*/ void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes);
            }

            class XmlSchemaSimpleType : System.Xml.Schema.XmlSchemaType
            {
                /*0x98*/ System.Xml.Schema.XmlSchemaSimpleTypeContent content;

                /*0x38832e8*/ XmlSchemaSimpleType();
                /*0x388336c*/ System.Xml.Schema.XmlSchemaSimpleTypeContent get_Content();
                /*0x3883374*/ void set_Content(System.Xml.Schema.XmlSchemaSimpleTypeContent value);
                /*0x388337c*/ System.Xml.Schema.XmlSchemaObject Clone();
            }

            class XmlSchemaSimpleTypeContent : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x3883488*/ XmlSchemaSimpleTypeContent();
            }

            class XmlSchemaSimpleTypeList : System.Xml.Schema.XmlSchemaSimpleTypeContent
            {
                /*0x50*/ System.Xml.XmlQualifiedName itemTypeName;
                /*0x58*/ System.Xml.Schema.XmlSchemaSimpleType itemType;
                /*0x60*/ System.Xml.Schema.XmlSchemaSimpleType baseItemType;

                /*0x3883618*/ XmlSchemaSimpleTypeList();
                /*0x3883490*/ System.Xml.XmlQualifiedName get_ItemTypeName();
                /*0x3883498*/ void set_ItemTypeName(System.Xml.XmlQualifiedName value);
                /*0x3883538*/ System.Xml.Schema.XmlSchemaSimpleType get_ItemType();
                /*0x3883540*/ void set_ItemType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0x3883548*/ System.Xml.Schema.XmlSchemaSimpleType get_BaseItemType();
                /*0x3883550*/ void set_BaseItemType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0x3883558*/ System.Xml.Schema.XmlSchemaObject Clone();
            }

            class XmlSchemaSimpleTypeRestriction : System.Xml.Schema.XmlSchemaSimpleTypeContent
            {
                /*0x50*/ System.Xml.XmlQualifiedName baseTypeName;
                /*0x58*/ System.Xml.Schema.XmlSchemaSimpleType baseType;
                /*0x60*/ System.Xml.Schema.XmlSchemaObjectCollection facets;

                /*0x3883808*/ XmlSchemaSimpleTypeRestriction();
                /*0x3883688*/ System.Xml.XmlQualifiedName get_BaseTypeName();
                /*0x3883690*/ void set_BaseTypeName(System.Xml.XmlQualifiedName value);
                /*0x3883730*/ System.Xml.Schema.XmlSchemaSimpleType get_BaseType();
                /*0x3883738*/ void set_BaseType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0x3883740*/ System.Xml.Schema.XmlSchemaObjectCollection get_Facets();
                /*0x3883748*/ System.Xml.Schema.XmlSchemaObject Clone();
            }

            class XmlSchemaSimpleTypeUnion : System.Xml.Schema.XmlSchemaSimpleTypeContent
            {
                /*0x50*/ System.Xml.Schema.XmlSchemaObjectCollection baseTypes;
                /*0x58*/ System.Xml.XmlQualifiedName[] memberTypes;
                /*0x60*/ System.Xml.Schema.XmlSchemaSimpleType[] baseMemberTypes;

                /*0x3883a68*/ XmlSchemaSimpleTypeUnion();
                /*0x38838b0*/ System.Xml.Schema.XmlSchemaObjectCollection get_BaseTypes();
                /*0x38838b8*/ System.Xml.XmlQualifiedName[] get_MemberTypes();
                /*0x38838c0*/ void set_MemberTypes(System.Xml.XmlQualifiedName[] value);
                /*0x38838c8*/ System.Xml.Schema.XmlSchemaSimpleType[] get_BaseMemberTypes();
                /*0x38838d0*/ void SetBaseMemberTypes(System.Xml.Schema.XmlSchemaSimpleType[] baseMemberTypes);
                /*0x38838d8*/ System.Xml.Schema.XmlSchemaObject Clone();
            }

            class XmlSchemaSubstitutionGroup : System.Xml.Schema.XmlSchemaObject
            {
                /*0x38*/ System.Collections.ArrayList membersList;
                /*0x40*/ System.Xml.XmlQualifiedName examplar;

                /*0x3883aec*/ XmlSchemaSubstitutionGroup();
                /*0x3883ad4*/ System.Collections.ArrayList get_Members();
                /*0x3883adc*/ System.Xml.XmlQualifiedName get_Examplar();
                /*0x3883ae4*/ void set_Examplar(System.Xml.XmlQualifiedName value);
            }

            class XmlSchemaSubstitutionGroupV1Compat : System.Xml.Schema.XmlSchemaSubstitutionGroup
            {
                /*0x48*/ System.Xml.Schema.XmlSchemaChoice choice;

                /*0x3883ba4*/ XmlSchemaSubstitutionGroupV1Compat();
                /*0x3883b9c*/ System.Xml.Schema.XmlSchemaChoice get_Choice();
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

                static /*0x3883c0c*/ System.Xml.Schema.XmlSchemaSimpleType GetBuiltInSimpleType(System.Xml.XmlQualifiedName qualifiedName);
                static /*0x3883ce4*/ System.Xml.Schema.XmlSchemaSimpleType GetBuiltInSimpleType(System.Xml.Schema.XmlTypeCode typeCode);
                static /*0x3883d3c*/ System.Xml.Schema.XmlSchemaComplexType GetBuiltInComplexType(System.Xml.XmlQualifiedName qualifiedName);
                static /*0x38841ac*/ bool IsDerivedFrom(System.Xml.Schema.XmlSchemaType derivedType, System.Xml.Schema.XmlSchemaType baseType, System.Xml.Schema.XmlSchemaDerivationMethod except);
                static /*0x3884368*/ bool IsDerivedFromDatatype(System.Xml.Schema.XmlSchemaDatatype derivedDataType, System.Xml.Schema.XmlSchemaDatatype baseDataType, System.Xml.Schema.XmlSchemaDerivationMethod except);
                /*0x38832ec*/ XmlSchemaType();
                /*0x3883f84*/ string get_Name();
                /*0x3883f8c*/ void set_Name(string value);
                /*0x3883f94*/ System.Xml.Schema.XmlSchemaDerivationMethod get_Final();
                /*0x3883f9c*/ void set_Final(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x3882db4*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0x3883fa4*/ System.Xml.Schema.XmlSchemaDerivationMethod get_FinalResolved();
                /*0x3883fac*/ System.Xml.Schema.XmlSchemaType get_BaseXmlSchemaType();
                /*0x3883fb4*/ System.Xml.Schema.XmlSchemaDerivationMethod get_DerivedBy();
                /*0x3883fbc*/ System.Xml.Schema.XmlSchemaDatatype get_Datatype();
                /*0x3883fc4*/ bool get_IsMixed();
                /*0x3883fcc*/ void set_IsMixed(bool value);
                /*0x3883fd0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x3884084*/ System.Xml.Schema.XmlValueConverter get_ValueConverter();
                /*0x38840fc*/ System.Xml.Schema.XmlSchemaContentType get_SchemaContentType();
                /*0x3884104*/ void SetQualifiedName(System.Xml.XmlQualifiedName value);
                /*0x3884130*/ void SetFinalResolved(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x3884138*/ void SetBaseSchemaType(System.Xml.Schema.XmlSchemaType value);
                /*0x3884140*/ void SetDerivedBy(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x3884148*/ void SetDatatype(System.Xml.Schema.XmlSchemaDatatype value);
                /*0x3884150*/ System.Xml.Schema.SchemaElementDecl get_ElementDecl();
                /*0x3884168*/ void set_ElementDecl(System.Xml.Schema.SchemaElementDecl value);
                /*0x3884194*/ System.Xml.Schema.XmlSchemaType get_Redefined();
                /*0x388419c*/ void set_Redefined(System.Xml.Schema.XmlSchemaType value);
                /*0x38841a4*/ void SetContentType(System.Xml.Schema.XmlSchemaContentType value);
                /*0x388443c*/ string get_NameAttribute();
                /*0x3884444*/ void set_NameAttribute(string value);
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
                /*0x388444c*/ XmlSchemaValidationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x388445c*/ XmlSchemaValidationException();
                /*0x3884468*/ XmlSchemaValidationException(string res, string arg, string sourceUri, int lineNumber, int linePosition);
                /*0x3884538*/ XmlSchemaValidationException(string res, string[] args, string sourceUri, int lineNumber, int linePosition);
                /*0x3884568*/ XmlSchemaValidationException(string res, string[] args, System.Exception innerException, string sourceUri, int lineNumber, int linePosition);
                /*0x3884454*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            class XmlValueGetter : System.MulticastDelegate
            {
                /*0x3884588*/ XmlValueGetter(object object, nint method);
                /*0x3884624*/ object Invoke();
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

                /*0x3884638*/ IdRefNode(System.Xml.Schema.IdRefNode next, string id, int lineNo, int linePos);
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

                static /*0x388ee68*/ XmlSchemaValidator();
                static /*0x388cc44*/ void ElementValidationError(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, System.Xml.Schema.ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, System.Xml.Schema.XmlSchemaSet schemaSet);
                static /*0x388b398*/ void CompleteValidationError(System.Xml.Schema.ValidationState context, System.Xml.Schema.ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, System.Xml.Schema.XmlSchemaSet schemaSet);
                static /*0x3889158*/ string PrintExpectedElements(System.Collections.ArrayList expected, bool getParticles);
                static /*0x388eaac*/ string PrintNames(System.Collections.ArrayList expected);
                static /*0x388e5f4*/ void PrintNamesWithNS(System.Collections.ArrayList expected, System.Text.StringBuilder builder);
                static /*0x388ec28*/ void EnumerateAny(System.Text.StringBuilder builder, string namespaces);
                static /*0x3888f54*/ string QNameString(string localName, string ns);
                static /*0x388c9e4*/ string BuildElementName(System.Xml.XmlQualifiedName qname);
                static /*0x3889008*/ string BuildElementName(string localName, string ns);
                static /*0x388e540*/ void SendValidationEvent(System.Xml.Schema.ValidationEventHandler eventHandler, object sender, System.Xml.Schema.XmlSchemaValidationException e, System.Xml.Schema.XmlSeverityType severity);
                /*0x3884690*/ XmlSchemaValidator(System.Xml.XmlNameTable nameTable, System.Xml.Schema.XmlSchemaSet schemas, System.Xml.IXmlNamespaceResolver namespaceResolver, System.Xml.Schema.XmlSchemaValidationFlags validationFlags);
                /*0x38848bc*/ void Init();
                /*0x3884dcc*/ void Reset();
                /*0x3884f48*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x3884f50*/ void set_LineInfoProvider(System.Xml.IXmlLineInfo value);
                /*0x3884f60*/ void set_SourceUri(System.Uri value);
                /*0x3884fac*/ void set_ValidationEventSender(object value);
                /*0x3884fb4*/ void add_ValidationEventHandler(System.Xml.Schema.ValidationEventHandler value);
                /*0x3885044*/ void remove_ValidationEventHandler(System.Xml.Schema.ValidationEventHandler value);
                /*0x38850d4*/ void AddSchema(System.Xml.Schema.XmlSchema schema);
                /*0x3885810*/ void Initialize();
                /*0x388593c*/ void Initialize(System.Xml.Schema.XmlSchemaObject partialValidationType);
                /*0x3885bd0*/ void ValidateElement(string localName, string namespaceUri, System.Xml.Schema.XmlSchemaInfo schemaInfo, string xsiType, string xsiNil, string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation);
                /*0x3887490*/ object ValidateAttribute(string localName, string namespaceUri, System.Xml.Schema.XmlValueGetter attributeValue, System.Xml.Schema.XmlSchemaInfo schemaInfo);
                /*0x38874ec*/ object ValidateAttribute(string lName, string ns, System.Xml.Schema.XmlValueGetter attributeValueGetter, string attributeStringValue, System.Xml.Schema.XmlSchemaInfo schemaInfo);
                /*0x3888894*/ void ValidateEndOfAttributes(System.Xml.Schema.XmlSchemaInfo schemaInfo);
                /*0x3888bc4*/ void ValidateText(System.Xml.Schema.XmlValueGetter elementValue);
                /*0x3888c20*/ void ValidateText(string elementStringValue, System.Xml.Schema.XmlValueGetter elementValueGetter);
                /*0x3889544*/ void ValidateWhitespace(System.Xml.Schema.XmlValueGetter elementValue);
                /*0x38895a0*/ void ValidateWhitespace(string elementStringValue, System.Xml.Schema.XmlValueGetter elementValueGetter);
                /*0x3889760*/ object ValidateEndElement(System.Xml.Schema.XmlSchemaInfo schemaInfo);
                /*0x3889c48*/ void SkipToEndElement(System.Xml.Schema.XmlSchemaInfo schemaInfo);
                /*0x3889f94*/ void EndValidation();
                /*0x388a188*/ void GetUnspecifiedDefaultAttributes(System.Collections.ArrayList defaultAttributes, bool createNodeData);
                /*0x388ac1c*/ System.Xml.Schema.XmlSchemaSet get_SchemaSet();
                /*0x388ac24*/ System.Xml.Schema.XmlSchemaValidationFlags get_ValidationFlags();
                /*0x388ac2c*/ System.Xml.Schema.XmlSchemaContentType get_CurrentContentType();
                /*0x388ac60*/ void SetDtdSchemaInfo(System.Xml.IDtdInfo dtdSchemaInfo);
                /*0x388ac84*/ bool get_StrictlyAssessed();
                /*0x388acc4*/ bool get_HasSchema();
                /*0x388ad0c*/ string GetConcatenatedValue();
                /*0x3889768*/ object InternalValidateEndElement(System.Xml.Schema.XmlSchemaInfo schemaInfo, object typedValue);
                /*0x38867f8*/ void ProcessSchemaLocations(string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation);
                /*0x3886170*/ object ValidateElementContext(System.Xml.XmlQualifiedName elementName, ref bool invalidElementInContext);
                /*0x388c810*/ System.Xml.Schema.XmlSchemaElement GetSubstitutionGroupHead(System.Xml.XmlQualifiedName member);
                /*0x388ad28*/ object ValidateAtomicValue(string stringValue, ref System.Xml.Schema.XmlSchemaSimpleType memberType);
                /*0x388afac*/ object ValidateAtomicValue(object parsedValue, ref System.Xml.Schema.XmlSchemaSimpleType memberType);
                /*0x388d51c*/ string GetTypeName(System.Xml.Schema.SchemaDeclBase decl);
                /*0x3888fc8*/ void SaveTextValue(object value);
                /*0x3884c7c*/ void Push(System.Xml.XmlQualifiedName elementName);
                /*0x3889e50*/ void Pop();
                /*0x388659c*/ System.Xml.Schema.SchemaElementDecl FastGetElementDecl(System.Xml.XmlQualifiedName elementName, object particle);
                /*0x3886b38*/ System.Xml.Schema.SchemaElementDecl CheckXsiTypeAndNil(System.Xml.Schema.SchemaElementDecl elementDecl, string xsiType, string xsiNil, ref bool declFound);
                /*0x3887118*/ void ThrowDeclNotFoundWarningOrError(bool declFound);
                /*0x3887258*/ void CheckElementProperties();
                /*0x388730c*/ void ValidateStartElementIdentityConstraints();
                /*0x3887fbc*/ System.Xml.Schema.SchemaAttDef CheckIsXmlAttribute(System.Xml.XmlQualifiedName attQName);
                /*0x388dd58*/ void AddXmlNamespaceSchema();
                /*0x388b2bc*/ object CheckMixedValueConstraint(string elementValue);
                /*0x388c340*/ void LoadSchema(string uri, string url);
                /*0x3884e74*/ void RecompileSchemaSet();
                /*0x388dfb4*/ void ProcessTokenizedType(System.Xml.XmlTokenizedType ttype, string name, bool attrValue);
                /*0x3888218*/ object CheckAttributeValue(object value, System.Xml.Schema.SchemaAttDef attdef);
                /*0x388d300*/ object CheckElementValue(string stringValue);
                /*0x3888454*/ void CheckTokenizedTypes(System.Xml.Schema.XmlSchemaDatatype dtype, object typedValue, bool attrValue);
                /*0x388e280*/ object FindId(string name);
                /*0x388a080*/ void CheckForwardRefs();
                /*0x38885d4*/ bool get_HasIdentityConstraints();
                /*0x388d59c*/ bool get_ProcessIdentityConstraints();
                /*0x388e52c*/ bool get_ReportValidationWarnings();
                /*0x3884f38*/ bool get_ProcessSchemaHints();
                /*0x3885f30*/ void CheckStateTransition(System.Xml.Schema.ValidatorState toState, string methodName);
                /*0x3886124*/ void ClearPSVI();
                /*0x388895c*/ void CheckRequiredAttributes(System.Xml.Schema.SchemaElementDecl currentElementDecl);
                /*0x3887368*/ System.Xml.Schema.XmlSchemaElement GetSchemaElement();
                /*0x388a788*/ string GetDefaultAttributePrefix(string attributeNS);
                /*0x388d5a8*/ void AddIdentityConstraints();
                /*0x388d9a8*/ void ElementIdentityConstraints();
                /*0x38885f4*/ void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x388b7c4*/ void EndElementIdentityConstraints(object typedValue, string stringValue, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x388e29c*/ void ProcessEntity(string name);
                /*0x388d584*/ void SendValidationEvent(string code);
                /*0x3888084*/ void SendValidationEvent(string code, string[] args);
                /*0x3887e3c*/ void SendValidationEvent(string code, string arg);
                /*0x388ca48*/ void SendValidationEvent(string code, string arg1, string arg2);
                /*0x388dde0*/ void SendValidationEvent(string code, string[] args, System.Exception innerException, System.Xml.Schema.XmlSeverityType severity);
                /*0x3885678*/ void SendValidationEvent(string code, string[] args, System.Exception innerException);
                /*0x388e538*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaValidationException e);
                /*0x388c764*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e);
                /*0x38854cc*/ void SendValidationEvent(string code, string msg, System.Xml.Schema.XmlSeverityType severity);
                /*0x388e410*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaValidationException e, System.Xml.Schema.XmlSeverityType severity);
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
                /*0x388f2c8*/ XmlValueConverter();
                bool ToBoolean(long value);
                /*0x1f2fe40*/ bool ToBoolean(int value);
                bool ToBoolean(double value);
                bool ToBoolean(System.DateTime value);
                /*0x1f2fec8*/ bool ToBoolean(string value);
                /*0x1f2fec8*/ bool ToBoolean(object value);
                int ToInt32(bool value);
                int ToInt32(long value);
                int ToInt32(double value);
                int ToInt32(System.DateTime value);
                /*0x1f3008c*/ int ToInt32(string value);
                /*0x1f3008c*/ int ToInt32(object value);
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
                /*0x1f30240*/ string ToString(int value);
                string ToString(long value);
                string ToString(decimal value);
                string ToString(float value);
                string ToString(double value);
                string ToString(System.DateTime value);
                string ToString(System.DateTimeOffset value);
                /*0x1f302cc*/ string ToString(object value);
                /*0x1f30394*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                object ChangeType(bool value, System.Type destinationType);
                object ChangeType(int value, System.Type destinationType);
                object ChangeType(long value, System.Type destinationType);
                object ChangeType(decimal value, System.Type destinationType);
                object ChangeType(double value, System.Type destinationType);
                object ChangeType(System.DateTime value, System.Type destinationType);
                /*0x1f303d0*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x1f30394*/ object ChangeType(object value, System.Type destinationType);
                /*0x1f303d0*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
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

                static /*0x3894b44*/ XmlBaseConverter();
                static /*0x38921a4*/ bool IsDerivedFrom(System.Type derivedType, System.Type baseType);
                static /*0x3892080*/ string QNameToString(System.Xml.XmlQualifiedName name);
                static /*0x3892520*/ byte[] StringToBase64Binary(string value);
                static /*0x38925b0*/ System.DateTime StringToDate(string value);
                static /*0x389262c*/ System.DateTime StringToDateTime(string value);
                static /*0x38926a8*/ System.TimeSpan StringToDayTimeDuration(string value);
                static /*0x3892708*/ System.TimeSpan StringToDuration(string value);
                static /*0x3892768*/ System.DateTime StringToGDay(string value);
                static /*0x38927e4*/ System.DateTime StringToGMonth(string value);
                static /*0x3892860*/ System.DateTime StringToGMonthDay(string value);
                static /*0x38928dc*/ System.DateTime StringToGYear(string value);
                static /*0x3892958*/ System.DateTime StringToGYearMonth(string value);
                static /*0x38929d4*/ System.DateTimeOffset StringToDateOffset(string value);
                static /*0x3892a50*/ System.DateTimeOffset StringToDateTimeOffset(string value);
                static /*0x3892acc*/ System.DateTimeOffset StringToGDayOffset(string value);
                static /*0x3892b48*/ System.DateTimeOffset StringToGMonthOffset(string value);
                static /*0x3892bc4*/ System.DateTimeOffset StringToGMonthDayOffset(string value);
                static /*0x3892c40*/ System.DateTimeOffset StringToGYearOffset(string value);
                static /*0x3892cbc*/ System.DateTimeOffset StringToGYearMonthOffset(string value);
                static /*0x3892d38*/ byte[] StringToHexBinary(string value);
                static /*0x3892e6c*/ System.Xml.XmlQualifiedName StringToQName(string value, System.Xml.IXmlNamespaceResolver nsResolver);
                static /*0x3893130*/ System.DateTime StringToTime(string value);
                static /*0x38931ac*/ System.DateTimeOffset StringToTimeOffset(string value);
                static /*0x3893228*/ System.TimeSpan StringToYearMonthDuration(string value);
                static /*0x3893288*/ string AnyUriToString(System.Uri value);
                static /*0x389329c*/ string Base64BinaryToString(byte[] value);
                static /*0x38932f4*/ string DateToString(System.DateTime value);
                static /*0x389337c*/ string DateTimeToString(System.DateTime value);
                static /*0x3893404*/ string DayTimeDurationToString(System.TimeSpan value);
                static /*0x3893464*/ string DurationToString(System.TimeSpan value);
                static /*0x38934c4*/ string GDayToString(System.DateTime value);
                static /*0x389354c*/ string GMonthToString(System.DateTime value);
                static /*0x38935d4*/ string GMonthDayToString(System.DateTime value);
                static /*0x389365c*/ string GYearToString(System.DateTime value);
                static /*0x38936e4*/ string GYearMonthToString(System.DateTime value);
                static /*0x389376c*/ string DateOffsetToString(System.DateTimeOffset value);
                static /*0x3893804*/ string DateTimeOffsetToString(System.DateTimeOffset value);
                static /*0x389389c*/ string GDayOffsetToString(System.DateTimeOffset value);
                static /*0x3893934*/ string GMonthOffsetToString(System.DateTimeOffset value);
                static /*0x38939cc*/ string GMonthDayOffsetToString(System.DateTimeOffset value);
                static /*0x3893a64*/ string GYearOffsetToString(System.DateTimeOffset value);
                static /*0x3893afc*/ string GYearMonthOffsetToString(System.DateTimeOffset value);
                static /*0x3893b94*/ string QNameToString(System.Xml.XmlQualifiedName qname, System.Xml.IXmlNamespaceResolver nsResolver);
                static /*0x3893da0*/ string TimeToString(System.DateTime value);
                static /*0x3893e28*/ string TimeOffsetToString(System.DateTimeOffset value);
                static /*0x3893ec0*/ string YearMonthDurationToString(System.TimeSpan value);
                static /*0x3893f20*/ System.DateTime DateTimeOffsetToDateTime(System.DateTimeOffset value);
                static /*0x3893f84*/ int DecimalToInt32(decimal value);
                static /*0x3894168*/ long DecimalToInt64(decimal value);
                static /*0x389434c*/ ulong DecimalToUInt64(decimal value);
                static /*0x3894524*/ byte Int32ToByte(int value);
                static /*0x3894600*/ short Int32ToInt16(int value);
                static /*0x38946dc*/ sbyte Int32ToSByte(int value);
                static /*0x38947b8*/ ushort Int32ToUInt16(int value);
                static /*0x3894894*/ int Int64ToInt32(long value);
                static /*0x3894970*/ uint Int64ToUInt32(long value);
                static /*0x3894a4c*/ System.DateTime UntypedAtomicToDateTime(string value);
                static /*0x3894ac8*/ System.DateTimeOffset UntypedAtomicToDateTimeOffset(string value);
                /*0x388f2d0*/ XmlBaseConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x388f3d0*/ XmlBaseConverter(System.Xml.Schema.XmlTypeCode typeCode);
                /*0x388f4b4*/ XmlBaseConverter(System.Xml.Schema.XmlBaseConverter converterAtomic);
                /*0x388f524*/ XmlBaseConverter(System.Xml.Schema.XmlBaseConverter converterAtomic, System.Type clrTypeDefault);
                /*0x388f578*/ bool ToBoolean(System.DateTime value);
                /*0x388f664*/ bool ToBoolean(double value);
                /*0x388f744*/ bool ToBoolean(int value);
                /*0x388f814*/ bool ToBoolean(long value);
                /*0x388f8e4*/ bool ToBoolean(string value);
                /*0x388f99c*/ bool ToBoolean(object value);
                /*0x388fa54*/ System.DateTime ToDateTime(bool value);
                /*0x388fb3c*/ System.DateTime ToDateTime(System.DateTimeOffset value);
                /*0x388fc40*/ System.DateTime ToDateTime(double value);
                /*0x388fd24*/ System.DateTime ToDateTime(int value);
                /*0x388fe08*/ System.DateTime ToDateTime(long value);
                /*0x388feec*/ System.DateTime ToDateTime(string value);
                /*0x388ffb0*/ System.DateTime ToDateTime(object value);
                /*0x3890074*/ System.DateTimeOffset ToDateTimeOffset(System.DateTime value);
                /*0x3890170*/ System.DateTimeOffset ToDateTimeOffset(string value);
                /*0x3890238*/ System.DateTimeOffset ToDateTimeOffset(object value);
                /*0x3890300*/ decimal ToDecimal(string value);
                /*0x38903c8*/ decimal ToDecimal(object value);
                /*0x3890490*/ double ToDouble(bool value);
                /*0x3890564*/ double ToDouble(System.DateTime value);
                /*0x3890650*/ double ToDouble(int value);
                /*0x3890720*/ double ToDouble(long value);
                /*0x38907f0*/ double ToDouble(string value);
                /*0x38908a8*/ double ToDouble(object value);
                /*0x3890960*/ int ToInt32(bool value);
                /*0x3890a34*/ int ToInt32(System.DateTime value);
                /*0x3890b20*/ int ToInt32(double value);
                /*0x3890c00*/ int ToInt32(long value);
                /*0x3890cd0*/ int ToInt32(string value);
                /*0x3890d88*/ int ToInt32(object value);
                /*0x3890e40*/ long ToInt64(bool value);
                /*0x3890f14*/ long ToInt64(System.DateTime value);
                /*0x3891000*/ long ToInt64(double value);
                /*0x38910e0*/ long ToInt64(int value);
                /*0x38911b0*/ long ToInt64(string value);
                /*0x3891268*/ long ToInt64(object value);
                /*0x3891320*/ float ToSingle(double value);
                /*0x3891400*/ float ToSingle(string value);
                /*0x38914b8*/ float ToSingle(object value);
                /*0x3891570*/ string ToString(bool value);
                /*0x3891630*/ string ToString(System.DateTime value);
                /*0x3891708*/ string ToString(System.DateTimeOffset value);
                /*0x38917ec*/ string ToString(decimal value);
                /*0x3891900*/ string ToString(double value);
                /*0x38919cc*/ string ToString(int value);
                /*0x3891a88*/ string ToString(long value);
                /*0x3891b44*/ string ToString(float value);
                /*0x3891c10*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x3891cb8*/ string ToString(object value);
                /*0x3891ccc*/ object ChangeType(bool value, System.Type destinationType);
                /*0x3891d20*/ object ChangeType(System.DateTime value, System.Type destinationType);
                /*0x3891da8*/ object ChangeType(decimal value, System.Type destinationType);
                /*0x3891e5c*/ object ChangeType(double value, System.Type destinationType);
                /*0x3891eb0*/ object ChangeType(int value, System.Type destinationType);
                /*0x3891f04*/ object ChangeType(long value, System.Type destinationType);
                /*0x3891f58*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x3891f68*/ object ChangeType(object value, System.Type destinationType);
                /*0x3891f7c*/ System.Xml.Schema.XmlSchemaType get_SchemaType();
                /*0x3891f84*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x3891f8c*/ string get_XmlTypeName();
                /*0x389219c*/ System.Type get_DefaultClrType();
                /*0x3892240*/ System.Exception CreateInvalidClrMappingException(System.Type sourceType, System.Type destinationType);
                /*0x38924cc*/ object ChangeListType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlNumeric10Converter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0x38951ac*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x3895144*/ XmlNumeric10Converter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x3895204*/ decimal ToDecimal(string value);
                /*0x38952d4*/ decimal ToDecimal(object value);
                /*0x3895a58*/ int ToInt32(long value);
                /*0x3895ab0*/ int ToInt32(string value);
                /*0x3895bbc*/ int ToInt32(object value);
                /*0x3895f68*/ long ToInt64(int value);
                /*0x3895f70*/ long ToInt64(string value);
                /*0x389607c*/ long ToInt64(object value);
                /*0x3896408*/ string ToString(decimal value);
                /*0x38964c4*/ string ToString(int value);
                /*0x389651c*/ string ToString(long value);
                /*0x3896574*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x3896928*/ object ChangeType(decimal value, System.Type destinationType);
                /*0x3897150*/ object ChangeType(int value, System.Type destinationType);
                /*0x3897554*/ object ChangeType(long value, System.Type destinationType);
                /*0x389796c*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x3897d88*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x3895690*/ object ChangeTypeWildcardDestination(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x3896d68*/ object ChangeTypeWildcardSource(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlNumeric2Converter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0x3898c04*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x3898b9c*/ XmlNumeric2Converter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x3898c5c*/ double ToDouble(string value);
                /*0x3898d34*/ double ToDouble(object value);
                /*0x389902c*/ float ToSingle(double value);
                /*0x3899034*/ float ToSingle(string value);
                /*0x389910c*/ float ToSingle(object value);
                /*0x3899414*/ string ToString(double value);
                /*0x38994c8*/ string ToString(float value);
                /*0x3899558*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x3899854*/ object ChangeType(double value, System.Type destinationType);
                /*0x3899b78*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x3899ed8*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlDateTimeConverter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0x389a5e4*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x389a57c*/ XmlDateTimeConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x389a63c*/ System.DateTime ToDateTime(System.DateTimeOffset value);
                /*0x389a6a4*/ System.DateTime ToDateTime(string value);
                /*0x389a85c*/ System.DateTime ToDateTime(object value);
                /*0x389aba0*/ System.DateTimeOffset ToDateTimeOffset(System.DateTime value);
                /*0x389abc8*/ System.DateTimeOffset ToDateTimeOffset(string value);
                /*0x389ad80*/ System.DateTimeOffset ToDateTimeOffset(object value);
                /*0x389b0cc*/ string ToString(System.DateTime value);
                /*0x389b25c*/ string ToString(System.DateTimeOffset value);
                /*0x389b410*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x389b734*/ object ChangeType(System.DateTime value, System.Type destinationType);
                /*0x389bab0*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x389be34*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlBooleanConverter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0x389c5a4*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x389c53c*/ XmlBooleanConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x389c5fc*/ bool ToBoolean(string value);
                /*0x389c6a0*/ bool ToBoolean(object value);
                /*0x389c948*/ string ToString(bool value);
                /*0x389c9a0*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x389cc28*/ object ChangeType(bool value, System.Type destinationType);
                /*0x389cf20*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x389d234*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlMiscConverter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0x389d7ec*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x389d784*/ XmlMiscConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x389d844*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x389de90*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x389e4e0*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x389dd60*/ object ChangeTypeWildcardDestination(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x389e388*/ object ChangeTypeWildcardSource(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlStringConverter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0x389f214*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x389f1ac*/ XmlStringConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x389f26c*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x389f450*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x389f6c4*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlUntypedConverter : System.Xml.Schema.XmlListConverter
            {
                static /*0x0*/ System.Xml.Schema.XmlValueConverter Untyped;
                static /*0x8*/ System.Xml.Schema.XmlValueConverter UntypedList;
                /*0x30*/ bool allowListToList;

                static /*0x38a607c*/ XmlUntypedConverter();
                /*0x389fac8*/ XmlUntypedConverter();
                /*0x389fbc0*/ XmlUntypedConverter(System.Xml.Schema.XmlUntypedConverter atomicConverter, bool allowListToList);
                /*0x389fce0*/ bool ToBoolean(string value);
                /*0x389fd84*/ bool ToBoolean(object value);
                /*0x38a0058*/ System.DateTime ToDateTime(string value);
                /*0x38a00fc*/ System.DateTime ToDateTime(object value);
                /*0x38a029c*/ System.DateTimeOffset ToDateTimeOffset(string value);
                /*0x38a0340*/ System.DateTimeOffset ToDateTimeOffset(object value);
                /*0x38a04dc*/ decimal ToDecimal(string value);
                /*0x38a0580*/ decimal ToDecimal(object value);
                /*0x38a0734*/ double ToDouble(string value);
                /*0x38a07d8*/ double ToDouble(object value);
                /*0x38a097c*/ int ToInt32(string value);
                /*0x38a0a20*/ int ToInt32(object value);
                /*0x38a0bc4*/ long ToInt64(string value);
                /*0x38a0c68*/ long ToInt64(object value);
                /*0x38a0e0c*/ float ToSingle(string value);
                /*0x38a0eb0*/ float ToSingle(object value);
                /*0x38a1054*/ string ToString(bool value);
                /*0x38a10ac*/ string ToString(System.DateTime value);
                /*0x38a1104*/ string ToString(System.DateTimeOffset value);
                /*0x38a116c*/ string ToString(decimal value);
                /*0x38a11d4*/ string ToString(double value);
                /*0x38a1234*/ string ToString(int value);
                /*0x38a128c*/ string ToString(long value);
                /*0x38a12e4*/ string ToString(float value);
                /*0x38a1344*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x38a1f08*/ object ChangeType(bool value, System.Type destinationType);
                /*0x38a224c*/ object ChangeType(System.DateTime value, System.Type destinationType);
                /*0x38a2408*/ object ChangeType(decimal value, System.Type destinationType);
                /*0x38a2638*/ object ChangeType(double value, System.Type destinationType);
                /*0x38a27f4*/ object ChangeType(int value, System.Type destinationType);
                /*0x38a29b0*/ object ChangeType(long value, System.Type destinationType);
                /*0x38a2b6c*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x38a379c*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x389ff28*/ object ChangeTypeWildcardDestination(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x38a20c8*/ object ChangeTypeWildcardSource(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x38a4cd0*/ object ChangeListType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x38a4fb4*/ bool SupportsType(System.Type clrType);
            }

            class XmlAnyConverter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0x0*/ System.Xml.Schema.XmlValueConverter Item;
                static /*0x8*/ System.Xml.Schema.XmlValueConverter AnyAtomic;

                static /*0x38a9388*/ XmlAnyConverter();
                /*0x38a6134*/ XmlAnyConverter(System.Xml.Schema.XmlTypeCode typeCode);
                /*0x38a619c*/ bool ToBoolean(object value);
                /*0x38a646c*/ System.DateTime ToDateTime(object value);
                /*0x38a6614*/ System.DateTimeOffset ToDateTimeOffset(object value);
                /*0x38a67d0*/ decimal ToDecimal(object value);
                /*0x38a698c*/ double ToDouble(object value);
                /*0x38a6b2c*/ int ToInt32(object value);
                /*0x38a6ccc*/ long ToInt64(object value);
                /*0x38a6e6c*/ float ToSingle(object value);
                /*0x38a701c*/ object ChangeType(bool value, System.Type destinationType);
                /*0x38a7344*/ object ChangeType(System.DateTime value, System.Type destinationType);
                /*0x38a7524*/ object ChangeType(decimal value, System.Type destinationType);
                /*0x38a7764*/ object ChangeType(double value, System.Type destinationType);
                /*0x38a7930*/ object ChangeType(int value, System.Type destinationType);
                /*0x38a7afc*/ object ChangeType(long value, System.Type destinationType);
                /*0x38a7cc8*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x38a7eb4*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x38a633c*/ object ChangeTypeWildcardDestination(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x38a71ec*/ object ChangeTypeWildcardSource(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x38a9308*/ System.Xml.XPath.XPathNavigator ToNavigator(System.Xml.XPath.XPathNavigator nav);
            }

            class XmlAnyListConverter : System.Xml.Schema.XmlListConverter
            {
                static /*0x0*/ System.Xml.Schema.XmlValueConverter ItemList;
                static /*0x8*/ System.Xml.Schema.XmlValueConverter AnyAtomicList;

                static /*0x38a96e8*/ XmlAnyListConverter();
                /*0x38a9418*/ XmlAnyListConverter(System.Xml.Schema.XmlBaseConverter atomicConverter);
                /*0x38a9494*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlListConverter : System.Xml.Schema.XmlBaseConverter
            {
                /*0x28*/ System.Xml.Schema.XmlValueConverter atomicConverter;

                static /*0x38a9848*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlValueConverter atomicConverter);
                /*0x38a941c*/ XmlListConverter(System.Xml.Schema.XmlBaseConverter atomicConverter);
                /*0x389fc60*/ XmlListConverter(System.Xml.Schema.XmlBaseConverter atomicConverter, System.Type clrTypeDefault);
                /*0x389fb58*/ XmlListConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x38a99f4*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x38a54d8*/ object ChangeListType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x38a9ad4*/ bool IsListType(System.Type type);
                /*0x1f30394*/ T[] ToArray<T>(object list, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x38aa310*/ System.Collections.IList ToList(object list, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x38aa268*/ System.Collections.Generic.List<string> StringAsList(string value);
                /*0x38a9eec*/ string ListAsString(System.Collections.IEnumerable list, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x38a9c58*/ System.Exception CreateInvalidClrMappingException(System.Type sourceType, System.Type destinationType);
            }

            class XmlUnionConverter : System.Xml.Schema.XmlBaseConverter
            {
                /*0x28*/ System.Xml.Schema.XmlValueConverter[] converters;
                /*0x30*/ bool hasAtomicMember;
                /*0x31*/ bool hasListMember;

                static /*0x38aab48*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x38aa8e8*/ XmlUnionConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x38aaba0*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
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

                static /*0x38b1880*/ XsdBuilder();
                static /*0x38acf38*/ void BuildAnnotated_Id(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38acf5c*/ void BuildSchema_AttributeFormDefault(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38ad0e0*/ void BuildSchema_ElementFormDefault(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38ad180*/ void BuildSchema_TargetNamespace(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38ad1a0*/ void BuildSchema_Version(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38ad1c0*/ void BuildSchema_FinalDefault(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38ad478*/ void BuildSchema_BlockDefault(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38ad4e0*/ void InitSchema(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38ad500*/ void InitInclude(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38ad5c4*/ void BuildInclude_SchemaLocation(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38ad5e4*/ void InitImport(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38ad6a8*/ void BuildImport_Namespace(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38ad6c8*/ void BuildImport_SchemaLocation(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38ad6e8*/ void InitRedefine(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38ad7ac*/ void BuildRedefine_SchemaLocation(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38ad7cc*/ void EndRedefine(System.Xml.Schema.XsdBuilder builder);
                static /*0x38ad7e4*/ void InitAttribute(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38adad8*/ void BuildAttribute_Default(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38adaf8*/ void BuildAttribute_Fixed(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38adb18*/ void BuildAttribute_Form(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38adbb8*/ void BuildAttribute_Use(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38adc58*/ void BuildAttribute_Ref(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38ade4c*/ void BuildAttribute_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38ade6c*/ void BuildAttribute_Type(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38adedc*/ void InitElement(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38adfec*/ void BuildElement_Abstract(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38ae168*/ void BuildElement_Block(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38ae1d0*/ void BuildElement_Default(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38ae1f0*/ void BuildElement_Form(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38ae290*/ void BuildElement_SubstitutionGroup(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38ae300*/ void BuildElement_Final(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38ae368*/ void BuildElement_Fixed(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38ae388*/ void BuildElement_MaxOccurs(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38ae460*/ void BuildElement_MinOccurs(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38ae538*/ void BuildElement_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38ae558*/ void BuildElement_Nillable(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38ae5c8*/ void BuildElement_Ref(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38ae638*/ void BuildElement_Type(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38ae6a8*/ void InitSimpleType(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38ae9dc*/ void BuildSimpleType_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38ae9fc*/ void BuildSimpleType_Final(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38aea64*/ void InitSimpleTypeUnion(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38aeb28*/ void BuildSimpleTypeUnion_MemberTypes(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38aed18*/ void InitSimpleTypeList(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38aeddc*/ void BuildSimpleTypeList_ItemType(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38aee4c*/ void InitSimpleTypeRestriction(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38aef10*/ void BuildSimpleTypeRestriction_Base(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38aef80*/ void InitComplexType(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38af104*/ void BuildComplexType_Abstract(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38af174*/ void BuildComplexType_Block(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38af1dc*/ void BuildComplexType_Final(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38af244*/ void BuildComplexType_Mixed(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38af2bc*/ void BuildComplexType_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38af2dc*/ void InitComplexContent(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38af3e4*/ void BuildComplexContent_Mixed(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38af454*/ void InitComplexContentExtension(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38af540*/ void BuildComplexContentExtension_Base(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38af5b0*/ void InitComplexContentRestriction(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38af648*/ void BuildComplexContentRestriction_Base(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38af6b8*/ void InitSimpleContent(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38af7c0*/ void InitSimpleContentExtension(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38af8ac*/ void BuildSimpleContentExtension_Base(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38af91c*/ void InitSimpleContentRestriction(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38afa08*/ void BuildSimpleContentRestriction_Base(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38afa78*/ void InitAttributeGroup(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38afb48*/ void BuildAttributeGroup_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38afb68*/ void InitAttributeGroupRef(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38afbec*/ void BuildAttributeGroupRef_Ref(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38afc5c*/ void InitAnyAttribute(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38aff00*/ void BuildAnyAttribute_Namespace(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38aff20*/ void BuildAnyAttribute_ProcessContents(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38affc0*/ void InitGroup(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38b0094*/ void BuildGroup_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38b00b4*/ void InitGroupRef(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38b0434*/ void BuildParticle_MaxOccurs(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38b044c*/ void BuildParticle_MinOccurs(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38b0464*/ void BuildGroupRef_Ref(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38b04d4*/ void InitAll(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38b0568*/ void InitChoice(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38b05fc*/ void InitSequence(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38b0690*/ void InitAny(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38b0728*/ void BuildAny_Namespace(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38b0748*/ void BuildAny_ProcessContents(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38b07e8*/ void InitNotation(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38b0884*/ void BuildNotation_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38b08a4*/ void BuildNotation_Public(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38b08c4*/ void BuildNotation_System(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38b08e4*/ void InitFacet(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38b0c4c*/ void BuildFacet_Fixed(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38b0cc4*/ void BuildFacet_Value(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38b0ce4*/ void InitIdentityConstraint(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38b0e38*/ void BuildIdentityConstraint_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38b0e58*/ void BuildIdentityConstraint_Refer(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38b0f78*/ void InitSelector(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38b1040*/ void BuildSelector_XPath(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38b1060*/ void InitField(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38b112c*/ void BuildField_XPath(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38b114c*/ void InitAnnotation(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38b122c*/ void InitAppinfo(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38b12f4*/ void BuildAppinfo_Source(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38b1368*/ void EndAppinfo(System.Xml.Schema.XsdBuilder builder);
                static /*0x38b1390*/ void InitDocumentation(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38b1458*/ void BuildDocumentation_Source(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38b14c8*/ void BuildDocumentation_XmlLang(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0x38b1608*/ void EndDocumentation(System.Xml.Schema.XsdBuilder builder);
                static /*0x38b1364*/ string ParseUriReference(string s);
                /*0x38aaf94*/ XsdBuilder(System.Xml.XmlReader reader, System.Xml.XmlNamespaceManager curmgr, System.Xml.Schema.XmlSchema schema, System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventhandler);
                /*0x38ab1f0*/ bool ProcessElement(string prefix, string name, string ns);
                /*0x38ab6ec*/ void ProcessAttribute(string prefix, string name, string ns, string value);
                /*0x38abc48*/ bool IsContentParsed();
                /*0x38abc60*/ void ProcessMarkup(System.Xml.XmlNode[] markup);
                /*0x38abc70*/ void ProcessCData(string value);
                /*0x38abcc8*/ void StartChildren();
                /*0x38abe50*/ void EndChildren();
                /*0x38ab478*/ void Push();
                /*0x38abe8c*/ void Pop();
                /*0x38ace18*/ System.Xml.Schema.SchemaNames.Token get_CurrentElement();
                /*0x38ace30*/ System.Xml.Schema.SchemaNames.Token get_ParentElement();
                /*0x38acea8*/ System.Xml.Schema.XmlSchemaObject get_ParentContainer();
                /*0x38abf64*/ System.Xml.Schema.XmlSchemaObject GetContainer(System.Xml.Schema.XsdBuilder.State state);
                /*0x38ac09c*/ void SetContainer(System.Xml.Schema.XsdBuilder.State state, object container);
                /*0x38ad8a4*/ void AddAttribute(System.Xml.Schema.XmlSchemaObject value);
                /*0x38b014c*/ void AddParticle(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x38ab318*/ bool GetNextState(System.Xml.XmlQualifiedName qname);
                /*0x38ab5e0*/ bool IsSkipableElement(System.Xml.XmlQualifiedName qname);
                /*0x38ae478*/ void SetMinOccurs(System.Xml.Schema.XmlSchemaParticle particle, string value);
                /*0x38ae3a0*/ void SetMaxOccurs(System.Xml.Schema.XmlSchemaParticle particle, string value);
                /*0x38ae05c*/ bool ParseBoolean(string value, string attributeName);
                /*0x38acffc*/ int ParseEnum(string value, string attributeName, string[] values);
                /*0x38adcc8*/ System.Xml.XmlQualifiedName ParseQName(string value, string attributeName);
                /*0x38ad228*/ int ParseBlockFinalEnum(string value, string attributeName);
                /*0x38b1630*/ void SendValidationEvent(string code, string arg0, string arg1, string arg2);
                /*0x38ab604*/ void SendValidationEvent(string code, string msg);
                /*0x38abb54*/ void SendValidationEvent(string code, string[] args, System.Xml.Schema.XmlSeverityType severity);
                /*0x38b17a4*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity);
                /*0x38aed10*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e);
                /*0x38ab520*/ void RecordPosition();

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
                    /*0x38b6a4c*/ XsdBuildFunction(object object, nint method);
                    /*0x38b6b00*/ void Invoke(System.Xml.Schema.XsdBuilder builder, string value);
                }

                class XsdInitFunction : System.MulticastDelegate
                {
                    /*0x38b6b14*/ XsdInitFunction(object object, nint method);
                    /*0x38b6bc8*/ void Invoke(System.Xml.Schema.XsdBuilder builder, string value);
                }

                class XsdEndChildFunction : System.MulticastDelegate
                {
                    /*0x38b6bdc*/ XsdEndChildFunction(object object, nint method);
                    /*0x38b6c8c*/ void Invoke(System.Xml.Schema.XsdBuilder builder);
                }

                class XsdAttributeEntry
                {
                    /*0x10*/ System.Xml.Schema.SchemaNames.Token Attribute;
                    /*0x18*/ System.Xml.Schema.XsdBuilder.XsdBuildFunction BuildFunc;

                    /*0x38b6ca0*/ XsdAttributeEntry(System.Xml.Schema.SchemaNames.Token a, System.Xml.Schema.XsdBuilder.XsdBuildFunction build);
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

                    /*0x38b6cd8*/ XsdEntry(System.Xml.Schema.SchemaNames.Token n, System.Xml.Schema.XsdBuilder.State state, System.Xml.Schema.XsdBuilder.State[] nextStates, System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] attributes, System.Xml.Schema.XsdBuilder.XsdInitFunction init, System.Xml.Schema.XsdBuilder.XsdEndChildFunction end, bool parseContent);
                }

                class BuilderNamespaceManager : System.Xml.XmlNamespaceManager
                {
                    /*0x50*/ System.Xml.XmlNamespaceManager nsMgr;
                    /*0x58*/ System.Xml.XmlReader reader;

                    /*0x38b6d74*/ BuilderNamespaceManager(System.Xml.XmlNamespaceManager nsMgr, System.Xml.XmlReader reader);
                    /*0x38b6db8*/ string LookupNamespace(string prefix);
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

                static /*0x38b96d8*/ XsdDateTime();
                static /*0x38b7c14*/ bool TryParse(string text, System.Xml.Schema.XsdDateTimeFlags kinds, ref System.Xml.Schema.XsdDateTime result);
                static /*0x38b83f4*/ System.DateTime op_Implicit(System.Xml.Schema.XsdDateTime xdt);
                static /*0x38b8910*/ System.DateTimeOffset op_Implicit(System.Xml.Schema.XsdDateTime xdt);
                /*0x38b6e18*/ XsdDateTime(string text, System.Xml.Schema.XsdDateTimeFlags kinds);
                /*0x38b7b90*/ XsdDateTime(System.Xml.Schema.XsdDateTime.Parser parser);
                /*0x38b7cd4*/ XsdDateTime(System.DateTime dateTime, System.Xml.Schema.XsdDateTimeFlags kinds);
                /*0x38b7ea8*/ XsdDateTime(System.DateTimeOffset dateTimeOffset);
                /*0x38b7f18*/ XsdDateTime(System.DateTimeOffset dateTimeOffset, System.Xml.Schema.XsdDateTimeFlags kinds);
                /*0x38b7ad4*/ void InitiateXsdDateTime(System.Xml.Schema.XsdDateTime.Parser parser);
                /*0x38b80ac*/ System.Xml.Schema.XsdDateTime.DateTimeTypeCode get_InternalTypeCode();
                /*0x38b80b4*/ System.Xml.Schema.XsdDateTime.XsdDateTimeKind get_InternalKind();
                /*0x38b80bc*/ int get_Year();
                /*0x38b8114*/ int get_Month();
                /*0x38b816c*/ int get_Day();
                /*0x38b81c4*/ int get_Hour();
                /*0x38b821c*/ int get_Minute();
                /*0x38b8274*/ int get_Second();
                /*0x38b82cc*/ int get_Fraction();
                /*0x38b83e4*/ int get_ZoneHour();
                /*0x38b83ec*/ int get_ZoneMinute();
                /*0x38b8c60*/ string ToString();
                /*0x38b90d0*/ void PrintDate(System.Text.StringBuilder sb);
                /*0x38b9214*/ void PrintTime(System.Text.StringBuilder sb);
                /*0x38b9534*/ void PrintZone(System.Text.StringBuilder sb);
                /*0x38b9464*/ void IntToCharArray(char[] text, int start, int value, int digits);
                /*0x38b94cc*/ void ShortToCharArray(char[] text, int start, int value);

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

                    static /*0x38ba58c*/ Parser();
                    static /*0x38b9a8c*/ bool Test(System.Xml.Schema.XsdDateTimeFlags left, System.Xml.Schema.XsdDateTimeFlags right);
                    /*0x38b6fa8*/ bool Parse(string text, System.Xml.Schema.XsdDateTimeFlags kinds);
                    /*0x38b9a98*/ bool ParseDate(int start);
                    /*0x38b9ce0*/ bool ParseTimeAndZoneAndWhitespace(int start);
                    /*0x38b9fd0*/ bool ParseTimeAndWhitespace(int start);
                    /*0x38ba230*/ bool ParseTime(ref int start);
                    /*0x38b9d7c*/ bool ParseZoneAndWhitespace(int start);
                    /*0x38ba05c*/ bool Parse4Dig(int start, ref int num);
                    /*0x38ba188*/ bool Parse2Dig(int start, ref int num);
                    /*0x38b9c9c*/ bool ParseChar(int start, char ch);
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

                static /*0x38bbac8*/ System.Exception TryParse(string s, ref System.Xml.Schema.XsdDuration result);
                static /*0x38ba9d8*/ System.Exception TryParse(string s, System.Xml.Schema.XsdDuration.DurationType durationType, ref System.Xml.Schema.XsdDuration result);
                static /*0x38bbad4*/ string TryParseDigits(string s, ref int offset, bool eatDigits, ref int result, ref int numDigits);
                /*0x38ba62c*/ XsdDuration(bool isNegative, int years, int months, int days, int hours, int minutes, int seconds, int nanoseconds);
                /*0x38ba788*/ XsdDuration(System.TimeSpan timeSpan);
                /*0x38ba790*/ XsdDuration(System.TimeSpan timeSpan, System.Xml.Schema.XsdDuration.DurationType durationType);
                /*0x38ba95c*/ XsdDuration(string s);
                /*0x38ba964*/ XsdDuration(string s, System.Xml.Schema.XsdDuration.DurationType durationType);
                /*0x38bb160*/ bool get_IsNegative();
                /*0x38bb16c*/ int get_Years();
                /*0x38bb174*/ int get_Months();
                /*0x38bb17c*/ int get_Days();
                /*0x38bb184*/ int get_Hours();
                /*0x38bb18c*/ int get_Minutes();
                /*0x38bb194*/ int get_Seconds();
                /*0x38bb154*/ int get_Nanoseconds();
                /*0x38bb19c*/ System.TimeSpan ToTimeSpan();
                /*0x38bb1a4*/ System.TimeSpan ToTimeSpan(System.Xml.Schema.XsdDuration.DurationType durationType);
                /*0x38bb694*/ System.Exception TryToTimeSpan(ref System.TimeSpan result);
                /*0x38bb1ec*/ System.Exception TryToTimeSpan(System.Xml.Schema.XsdDuration.DurationType durationType, ref System.TimeSpan result);
                /*0x38bb6a0*/ string ToString();
                /*0x38bb6a8*/ string ToString(System.Xml.Schema.XsdDuration.DurationType durationType);

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

                static /*0x38c0c30*/ XsdValidator();
                /*0x38bbc8c*/ XsdValidator(System.Xml.Schema.BaseValidator validator);
                /*0x38bc098*/ XsdValidator(System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling);
                /*0x38bbcb0*/ void Init();
                /*0x38bc1f4*/ void Validate();
                /*0x38bc888*/ void CompleteValidation();
                /*0x38bc2ac*/ bool get_IsInlineSchemaStarted();
                /*0x38bc2bc*/ void ProcessInlineSchema();
                /*0x38bc53c*/ void ValidateElement();
                /*0x38bc9b0*/ object ValidateChildElement();
                /*0x38bcbec*/ void ProcessElement(object particle);
                /*0x38bcef8*/ void ProcessXsiAttributes(ref System.Xml.XmlQualifiedName xsiType, ref string xsiNil);
                /*0x38bc6a8*/ void ValidateEndElement();
                /*0x38bce1c*/ System.Xml.Schema.SchemaElementDecl FastGetElementDecl(object particle);
                /*0x38bd6c8*/ System.Xml.Schema.SchemaElementDecl ThoroughGetElementDecl(System.Xml.Schema.SchemaElementDecl elementDecl, System.Xml.XmlQualifiedName xsiType, string xsiNil);
                /*0x38bdb1c*/ void ValidateStartElement();
                /*0x38be204*/ void ValidateEndStartElement();
                /*0x38bfc88*/ void LoadSchemaFromLocation(string uri, string url);
                /*0x38be5e4*/ void LoadSchema(string uri, string url);
                /*0x38bdab0*/ bool get_HasSchema();
                /*0x38c01c8*/ bool get_PreserveWhitespace();
                /*0x38c0200*/ void ProcessTokenizedType(System.Xml.XmlTokenizedType ttype, string name);
                /*0x38be7a4*/ void CheckValue(string value, System.Xml.Schema.SchemaAttDef attdef);
                /*0x38c0424*/ void AddID(string name, object node);
                /*0x38c04c0*/ object FindId(string name);
                /*0x38bcb9c*/ bool IsXSDRoot(string localName, string ns);
                /*0x38bc0bc*/ void Push(System.Xml.XmlQualifiedName elementName);
                /*0x38bf858*/ void Pop();
                /*0x38bc88c*/ void CheckForwardRefs();
                /*0x38bdad0*/ void ValidateStartElementIdentityConstraints();
                /*0x38bebf0*/ bool get_HasIdentityConstraints();
                /*0x38c04dc*/ void AddIdentityConstraints();
                /*0x38c08e8*/ void ElementIdentityConstraints();
                /*0x38bf9b0*/ void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, System.Xml.Schema.SchemaAttDef attdef);
                /*0x38bf938*/ object UnWrapUnion(object typedValue);
                /*0x38bec00*/ void EndElementIdentityConstraints();
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
                    /*0x38c0cf4*/ AstNode();
                    /*0x1f2ffc8*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x1f2ffc8*/ System.Xml.XPath.XPathResultType get_ReturnType();

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

                    /*0x38c0cfc*/ Axis(MS.Internal.Xml.XPath.Axis.AxisType axisType, MS.Internal.Xml.XPath.AstNode input, string prefix, string name, System.Xml.XPath.XPathNodeType nodetype);
                    /*0x38c0d98*/ Axis(MS.Internal.Xml.XPath.Axis.AxisType axisType, MS.Internal.Xml.XPath.AstNode input);
                    /*0x38c0dd0*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x38c0dd8*/ System.Xml.XPath.XPathResultType get_ReturnType();
                    /*0x38c0de0*/ MS.Internal.Xml.XPath.AstNode get_Input();
                    /*0x38c0de8*/ void set_Input(MS.Internal.Xml.XPath.AstNode value);
                    /*0x38c0df0*/ string get_Prefix();
                    /*0x38c0df8*/ string get_Name();
                    /*0x38c0e00*/ System.Xml.XPath.XPathNodeType get_NodeType();
                    /*0x38c0e08*/ MS.Internal.Xml.XPath.Axis.AxisType get_TypeOfAxis();
                    /*0x38c0e10*/ bool get_AbbrAxis();
                    /*0x38c0e18*/ string get_Urn();
                    /*0x38c0e20*/ void set_Urn(string value);

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

                    /*0x38c0e28*/ Filter(MS.Internal.Xml.XPath.AstNode input, MS.Internal.Xml.XPath.AstNode condition);
                    /*0x38c0e6c*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x38c0e74*/ System.Xml.XPath.XPathResultType get_ReturnType();
                }

                class Function : MS.Internal.Xml.XPath.AstNode
                {
                    static /*0x0*/ System.Xml.XPath.XPathResultType[] ReturnTypes;
                    /*0x10*/ MS.Internal.Xml.XPath.Function.FunctionType _functionType;
                    /*0x18*/ System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> _argumentList;
                    /*0x20*/ string _name;
                    /*0x28*/ string _prefix;

                    static /*0x38c1134*/ Function();
                    /*0x38c0e7c*/ Function(MS.Internal.Xml.XPath.Function.FunctionType ftype, System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> argumentList);
                    /*0x38c0f1c*/ Function(string prefix, string name, System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> argumentList);
                    /*0x38c0fe4*/ Function(MS.Internal.Xml.XPath.Function.FunctionType ftype, MS.Internal.Xml.XPath.AstNode arg);
                    /*0x38c10ac*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x38c10b4*/ System.Xml.XPath.XPathResultType get_ReturnType();

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

                    /*0x38c11d4*/ Group(MS.Internal.Xml.XPath.AstNode groupNode);
                    /*0x38c1204*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x38c120c*/ System.Xml.XPath.XPathResultType get_ReturnType();
                }

                class Operand : MS.Internal.Xml.XPath.AstNode
                {
                    /*0x10*/ System.Xml.XPath.XPathResultType _type;
                    /*0x18*/ object _val;

                    /*0x38c1214*/ Operand(string val);
                    /*0x38c124c*/ Operand(double val);
                    /*0x38c129c*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x38c12a4*/ System.Xml.XPath.XPathResultType get_ReturnType();
                }

                class Operator : MS.Internal.Xml.XPath.AstNode
                {
                    static /*0x0*/ MS.Internal.Xml.XPath.Operator.Op[] s_invertOp;
                    /*0x10*/ MS.Internal.Xml.XPath.Operator.Op _opType;
                    /*0x18*/ MS.Internal.Xml.XPath.AstNode _opnd1;
                    /*0x20*/ MS.Internal.Xml.XPath.AstNode _opnd2;

                    static /*0x38c1328*/ Operator();
                    /*0x38c12ac*/ Operator(MS.Internal.Xml.XPath.Operator.Op op, MS.Internal.Xml.XPath.AstNode opnd1, MS.Internal.Xml.XPath.AstNode opnd2);
                    /*0x38c1300*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x38c1308*/ System.Xml.XPath.XPathResultType get_ReturnType();

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
                    /*0x38c13c8*/ Root();
                    /*0x38c13d0*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x38c13d8*/ System.Xml.XPath.XPathResultType get_ReturnType();
                }

                class Variable : MS.Internal.Xml.XPath.AstNode
                {
                    /*0x10*/ string _localname;
                    /*0x18*/ string _prefix;

                    /*0x38c13e0*/ Variable(string name, string prefix);
                    /*0x38c1424*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x38c142c*/ System.Xml.XPath.XPathResultType get_ReturnType();
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

                    static /*0x38c45f8*/ XPathParser();
                    static /*0x38c1464*/ MS.Internal.Xml.XPath.AstNode ParseXPathExpression(string xpathExpression);
                    static /*0x38c1fe4*/ bool IsNodeType(MS.Internal.Xml.XPath.XPathScanner scaner);
                    static /*0x38c273c*/ bool IsStep(MS.Internal.Xml.XPath.XPathScanner.LexKind lexKind);
                    static /*0x38c20d8*/ bool IsPrimaryExpr(MS.Internal.Xml.XPath.XPathScanner scanner);
                    static /*0x38c36b0*/ System.Collections.Generic.Dictionary<string, MS.Internal.Xml.XPath.XPathParser.ParamInfo> CreateFunctionTable();
                    static /*0x38c42dc*/ System.Collections.Generic.Dictionary<string, MS.Internal.Xml.XPath.Axis.AxisType> CreateAxesTable();
                    /*0x38c1434*/ XPathParser(MS.Internal.Xml.XPath.XPathScanner scanner);
                    /*0x38c160c*/ MS.Internal.Xml.XPath.AstNode ParseExpression(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x38c1670*/ MS.Internal.Xml.XPath.AstNode ParseOrExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x38c1758*/ MS.Internal.Xml.XPath.AstNode ParseAndExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x38c18a0*/ MS.Internal.Xml.XPath.AstNode ParseEqualityExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x38c1978*/ MS.Internal.Xml.XPath.AstNode ParseRelationalExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x38c1a78*/ MS.Internal.Xml.XPath.AstNode ParseAdditiveExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x38c1b50*/ MS.Internal.Xml.XPath.AstNode ParseMultiplicativeExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x38c1c7c*/ MS.Internal.Xml.XPath.AstNode ParseUnaryExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x38c1d4c*/ MS.Internal.Xml.XPath.AstNode ParseUnionExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x38c1e4c*/ MS.Internal.Xml.XPath.AstNode ParsePathExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x38c2188*/ MS.Internal.Xml.XPath.AstNode ParseFilterExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x38c26b0*/ MS.Internal.Xml.XPath.AstNode ParsePredicate(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x38c232c*/ MS.Internal.Xml.XPath.AstNode ParseLocationPath(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x38c2238*/ MS.Internal.Xml.XPath.AstNode ParseRelativeLocationPath(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x38c277c*/ MS.Internal.Xml.XPath.AstNode ParseStep(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x38c2a04*/ MS.Internal.Xml.XPath.AstNode ParseNodeTest(MS.Internal.Xml.XPath.AstNode qyInput, MS.Internal.Xml.XPath.Axis.AxisType axisType, System.Xml.XPath.XPathNodeType nodeType);
                    /*0x38c2490*/ MS.Internal.Xml.XPath.AstNode ParsePrimaryExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x38c2d5c*/ MS.Internal.Xml.XPath.AstNode ParseMethod(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x38c2cf8*/ void CheckToken(MS.Internal.Xml.XPath.XPathScanner.LexKind t);
                    /*0x38c271c*/ void PassToken(MS.Internal.Xml.XPath.XPathScanner.LexKind t);
                    /*0x38c188c*/ void NextLex();
                    /*0x38c1840*/ bool TestOp(string op);
                    /*0x38c1f88*/ void CheckNodeSet(System.Xml.XPath.XPathResultType t);
                    /*0x38c291c*/ MS.Internal.Xml.XPath.Axis.AxisType GetAxis();

                    class ParamInfo
                    {
                        /*0x10*/ MS.Internal.Xml.XPath.Function.FunctionType _ftype;
                        /*0x14*/ int _minargs;
                        /*0x18*/ int _maxargs;
                        /*0x20*/ System.Xml.XPath.XPathResultType[] _argTypes;

                        /*0x38c4290*/ ParamInfo(MS.Internal.Xml.XPath.Function.FunctionType ftype, int minargs, int maxargs, System.Xml.XPath.XPathResultType[] argTypes);
                        /*0x38c48b4*/ MS.Internal.Xml.XPath.Function.FunctionType get_FType();
                        /*0x38c48bc*/ int get_Minargs();
                        /*0x38c48c4*/ int get_Maxargs();
                        /*0x38c48cc*/ System.Xml.XPath.XPathResultType[] get_ArgTypes();
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

                    /*0x38c1558*/ XPathScanner(string xpathExpr);
                    /*0x38c4934*/ string get_SourceText();
                    /*0x38c493c*/ char get_CurrentChar();
                    /*0x38c48d4*/ bool NextChar();
                    /*0x38c4944*/ MS.Internal.Xml.XPath.XPathScanner.LexKind get_Kind();
                    /*0x38c494c*/ string get_Name();
                    /*0x38c4954*/ string get_Prefix();
                    /*0x38c495c*/ string get_StringValue();
                    /*0x38c4964*/ double get_NumberValue();
                    /*0x38c496c*/ bool get_CanBeFunction();
                    /*0x38c4974*/ void SkipSpace();
                    /*0x38c3274*/ bool NextLex();
                    /*0x38c4b04*/ double ScanNumber();
                    /*0x38c49a4*/ double ScanFraction();
                    /*0x38c4a54*/ string ScanString();
                    /*0x38c4bdc*/ string ScanName();

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

                    /*0x38c4c48*/ XPathDocumentNavigator(MS.Internal.Xml.Cache.XPathNode[] pageCurrent, int idxCurrent, MS.Internal.Xml.Cache.XPathNode[] pageParent, int idxParent);
                    /*0x38c4ce8*/ string get_Value();
                    /*0x38c50f4*/ System.Xml.XPath.XPathNavigator Clone();
                    /*0x38c5168*/ System.Xml.XPath.XPathNodeType get_NodeType();
                    /*0x38c51ac*/ string get_LocalName();
                    /*0x38c5200*/ string get_NamespaceURI();
                    /*0x38c5254*/ string get_Prefix();
                    /*0x38c52a8*/ System.Xml.XmlNameTable get_NameTable();
                    /*0x38c5304*/ bool MoveToFirstNamespace(System.Xml.XPath.XPathNamespaceScope namespaceScope);
                    /*0x38c5624*/ bool MoveToNextNamespace(System.Xml.XPath.XPathNamespaceScope scope);
                    /*0x38c5798*/ bool MoveToParent();
                    /*0x38c587c*/ bool IsSamePosition(System.Xml.XPath.XPathNavigator other);
                    /*0x38c591c*/ object get_UnderlyingObject();
                    /*0x38c592c*/ bool HasLineInfo();
                    /*0x38c5970*/ int get_LineNumber();
                    /*0x38c5a20*/ int get_LinePosition();
                    /*0x38c5b1c*/ int GetPositionHashCode();
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

                    /*0x38c51a0*/ System.Xml.XPath.XPathNodeType get_NodeType();
                    /*0x38c5290*/ string get_Prefix();
                    /*0x38c51e8*/ string get_LocalName();
                    /*0x38c523c*/ string get_NamespaceUri();
                    /*0x38c52ec*/ System.Xml.XPath.XPathDocument get_Document();
                    /*0x38c59fc*/ int get_LineNumber();
                    /*0x38c5afc*/ int get_LinePosition();
                    /*0x38c5ad4*/ int get_CollapsedLinePosition();
                    /*0x38c5b28*/ MS.Internal.Xml.Cache.XPathNodePageInfo get_PageInfo();
                    /*0x38c5764*/ int GetParent(ref MS.Internal.Xml.Cache.XPathNode[] pageNode);
                    /*0x38c55f0*/ int GetSibling(ref MS.Internal.Xml.Cache.XPathNode[] pageNode);
                    /*0x38c5568*/ bool get_IsXmlNamespaceNode();
                    /*0x38c5b40*/ bool get_HasSibling();
                    /*0x38c5b50*/ bool get_HasCollapsedText();
                    /*0x38c5b5c*/ bool get_IsText();
                    /*0x38c5bb8*/ bool get_HasNamespaceDecls();
                    /*0x38c5bc4*/ string get_Value();
                }

                struct XPathNodeRef
                {
                    /*0x10*/ MS.Internal.Xml.Cache.XPathNode[] _page;
                    /*0x18*/ int _idx;

                    /*0x38c5bcc*/ XPathNodeRef(MS.Internal.Xml.Cache.XPathNode[] page, int idx);
                    /*0x38c5bf4*/ MS.Internal.Xml.Cache.XPathNode[] get_Page();
                    /*0x38c5bfc*/ int get_Index();
                    /*0x38c5c04*/ int GetHashCode();
                }

                class XPathNodeHelper
                {
                    static /*0x38c5408*/ int GetLocalNamespaces(MS.Internal.Xml.Cache.XPathNode[] pageElem, int idxElem, ref MS.Internal.Xml.Cache.XPathNode[] pageNmsp);
                    static /*0x38c5484*/ int GetInScopeNamespaces(MS.Internal.Xml.Cache.XPathNode[] pageElem, int idxElem, ref MS.Internal.Xml.Cache.XPathNode[] pageNmsp);
                    static /*0x38c5800*/ bool GetParent(ref MS.Internal.Xml.Cache.XPathNode[] pageNode, ref int idxNode);
                    static /*0x38c5c14*/ int GetLocation(MS.Internal.Xml.Cache.XPathNode[] pageNode, int idxNode);
                    static /*0x38c4f84*/ bool GetTextFollowing(ref MS.Internal.Xml.Cache.XPathNode[] pageCurrent, ref int idxCurrent, MS.Internal.Xml.Cache.XPathNode[] pageEnd, int idxEnd);
                    static /*0x38c4ed8*/ bool GetNonDescendant(ref MS.Internal.Xml.Cache.XPathNode[] pageNode, ref int idxNode);
                }

                class XPathNodePageInfo
                {
                    /*0x10*/ int _pageNum;
                    /*0x14*/ int _nodeCount;
                    /*0x18*/ MS.Internal.Xml.Cache.XPathNode[] _pageNext;

                    /*0x38c5c4c*/ int get_PageNumber();
                    /*0x38c5c54*/ int get_NodeCount();
                    /*0x38c5c5c*/ MS.Internal.Xml.Cache.XPathNode[] get_NextPage();
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

                    /*0x38c5c64*/ MS.Internal.Xml.Cache.XPathNodePageInfo get_PageInfo();
                    /*0x38c5c6c*/ string get_LocalName();
                    /*0x38c5c74*/ string get_NamespaceUri();
                    /*0x38c5c7c*/ string get_Prefix();
                    /*0x38c5c84*/ MS.Internal.Xml.Cache.XPathNode[] get_SiblingPage();
                    /*0x38c5c8c*/ MS.Internal.Xml.Cache.XPathNode[] get_ParentPage();
                    /*0x38c5c94*/ System.Xml.XPath.XPathDocument get_Document();
                    /*0x38c5c9c*/ int get_LineNumberBase();
                    /*0x38c5ca4*/ int get_LinePositionBase();
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

    static /*0x38c5cac*/ uint ComputeStringHash(string s);

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
