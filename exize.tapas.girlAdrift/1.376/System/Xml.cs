class <Module>
{
}

class SR
{
    static /*0x17770a4*/ string GetString(string name, object[] args);
    static /*0x1777114*/ string GetString(System.Globalization.CultureInfo culture, string name, object[] args);
}

namespace Microsoft
{
    namespace CSharp
    {
        class CodeDomProvider
        {
            /*0x177711c*/ CodeDomProvider();
        }

        class CSharpCodeProvider : Microsoft.CSharp.CodeDomProvider
        {
            /*0x1777124*/ CSharpCodeProvider();
        }
    }
}

namespace System
{
    class MonoTODOAttribute : System.Attribute
    {
        /*0x177712c*/ MonoTODOAttribute();
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

            static /*0x1777134*/ AsyncHelper();
        }

        class Base64Encoder
        {
            /*0x10*/ byte[] leftOverBytes;
            /*0x18*/ int leftOverBytesCount;
            /*0x20*/ char[] charsLine;

            /*0x177721c*/ Base64Encoder();
            void WriteChars(char[] chars, int index, int count);
            /*0x1777278*/ void Encode(byte[] buffer, int index, int count);
            /*0x17775ac*/ void Flush();
        }

        class XmlRawWriterBase64Encoder : System.Xml.Base64Encoder
        {
            /*0x28*/ System.Xml.XmlRawWriter rawWriter;

            /*0x1777654*/ XmlRawWriterBase64Encoder(System.Xml.XmlRawWriter rawWriter);
            /*0x1777678*/ void WriteChars(char[] chars, int index, int count);
        }

        class XmlTextWriterBase64Encoder : System.Xml.Base64Encoder
        {
            /*0x28*/ System.Xml.XmlTextEncoder xmlTextEncoder;

            /*0x177769c*/ XmlTextWriterBase64Encoder(System.Xml.XmlTextEncoder xmlTextEncoder);
            /*0x17776c0*/ void WriteChars(char[] chars, int index, int count);
        }

        class BinHexDecoder : System.Xml.IncrementalReadDecoder
        {
            /*0x10*/ byte[] buffer;
            /*0x18*/ int curIndex;
            /*0x1c*/ int endIndex;
            /*0x20*/ bool hasHalfByteCached;
            /*0x21*/ byte cachedHalfByte;

            static /*0x1777a10*/ byte[] Decode(char[] chars, bool allowOddChars);
            static /*0x1777844*/ void Decode(char* pChars, char* pCharsEndPos, byte* pBytes, byte* pBytesEndPos, ref bool hasHalfByteCached, ref byte cachedHalfByte, ref int charsDecoded, ref int bytesDecoded);
            /*0x17776dc*/ bool get_IsFull();
            /*0x17776ec*/ int Decode(char[] chars, int startPos, int len);
        }

        class BinHexEncoder
        {
            static /*0x1777bf8*/ void Encode(byte[] buffer, int index, int count, System.Xml.XmlWriter writer);
            static /*0x1777ec4*/ string Encode(byte[] inArray, int offsetIn, int count);
            static /*0x1777da0*/ int Encode(byte[] inArray, int offsetIn, int count, char[] outArray);
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

            static /*0x1778980*/ BinXmlSqlDecimal();
            static /*0x17782b0*/ uint UIntFromByteArray(byte[] data, int offset);
            static /*0x17784ec*/ void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, ref uint iulR);
            static /*0x17785c0*/ void MpNormalize(uint[] rgulU, ref int ciulU);
            static /*0x177860c*/ char ChFromDigit(uint uiDigit);
            /*0x1778020*/ BinXmlSqlDecimal(byte[] data, int offset, bool trim);
            /*0x1778010*/ bool get_IsPositive();
            /*0x1778614*/ decimal ToDecimal();
            /*0x1778324*/ void TrimTrailingZeros();
            /*0x17786d4*/ string ToString();
        }

        struct BinXmlSqlMoney
        {
            /*0x10*/ long data;

            /*0x1778ab8*/ BinXmlSqlMoney(int v);
            /*0x1778ac4*/ BinXmlSqlMoney(long v);
            /*0x1778acc*/ decimal ToDecimal();
            /*0x1778b30*/ string ToString();
        }

        class BinXmlDateTime
        {
            static /*0x0*/ int[] KatmaiTimeScaleMultiplicator;
            static /*0x8*/ double SQLTicksPerMillisecond;
            static /*0x10*/ int SQLTicksPerSecond;
            static /*0x14*/ int SQLTicksPerMinute;
            static /*0x18*/ int SQLTicksPerHour;
            static /*0x1c*/ int SQLTicksPerDay;

            static /*0x177ab78*/ BinXmlDateTime();
            static /*0x1778bf0*/ void Write2Dig(System.Text.StringBuilder sb, int val);
            static /*0x1778c4c*/ void Write4DigNeg(System.Text.StringBuilder sb, int val);
            static /*0x1778cf0*/ void Write3Dec(System.Text.StringBuilder sb, int val);
            static /*0x1778d9c*/ void WriteDate(System.Text.StringBuilder sb, int yr, int mnth, int day);
            static /*0x1778e50*/ void WriteTime(System.Text.StringBuilder sb, int hr, int min, int sec, int ms);
            static /*0x1778f3c*/ void WriteTimeFullPrecision(System.Text.StringBuilder sb, int hr, int min, int sec, int fraction);
            static /*0x1779128*/ void WriteTimeZone(System.Text.StringBuilder sb, System.TimeSpan zone);
            static /*0x17791e0*/ void WriteTimeZone(System.Text.StringBuilder sb, bool negTimeZone, int hr, int min);
            static /*0x17792b4*/ void BreakDownXsdDateTime(long val, ref int yr, ref int mnth, ref int day, ref int hr, ref int min, ref int sec, ref int ms);
            static /*0x1779488*/ void BreakDownXsdDate(long val, ref int yr, ref int mnth, ref int day, ref bool negTimeZone, ref int hr, ref int min);
            static /*0x17795f4*/ void BreakDownXsdTime(long val, ref int hr, ref int min, ref int sec, ref int ms);
            static /*0x1779700*/ string XsdDateTimeToString(long val);
            static /*0x1779808*/ string XsdDateToString(long val);
            static /*0x17798ec*/ string XsdTimeToString(long val);
            static /*0x17799c4*/ string SqlDateTimeToString(int dateticks, uint timeticks);
            static /*0x1779ac0*/ System.DateTime SqlDateTimeToDateTime(int dateticks, uint timeticks);
            static /*0x1779b90*/ string SqlSmallDateTimeToString(short dateticks, ushort timeticks);
            static /*0x1779c58*/ System.DateTime SqlSmallDateTimeToDateTime(short dateticks, ushort timeticks);
            static /*0x1779ccc*/ System.DateTime XsdKatmaiDateToDateTime(byte[] data, int offset);
            static /*0x1779dc0*/ System.DateTime XsdKatmaiDateTimeToDateTime(byte[] data, int offset);
            static /*0x177a07c*/ System.DateTime XsdKatmaiTimeToDateTime(byte[] data, int offset);
            static /*0x177a0e0*/ System.DateTimeOffset XsdKatmaiDateOffsetToDateTimeOffset(byte[] data, int offset);
            static /*0x177a144*/ System.DateTimeOffset XsdKatmaiDateTimeOffsetToDateTimeOffset(byte[] data, int offset);
            static /*0x177a240*/ System.DateTimeOffset XsdKatmaiTimeOffsetToDateTimeOffset(byte[] data, int offset);
            static /*0x177a2a4*/ string XsdKatmaiDateToString(byte[] data, int offset);
            static /*0x177a39c*/ string XsdKatmaiDateTimeToString(byte[] data, int offset);
            static /*0x177a5d0*/ string XsdKatmaiTimeToString(byte[] data, int offset);
            static /*0x177a6dc*/ string XsdKatmaiDateOffsetToString(byte[] data, int offset);
            static /*0x177a7f4*/ string XsdKatmaiDateTimeOffsetToString(byte[] data, int offset);
            static /*0x177aa4c*/ string XsdKatmaiTimeOffsetToString(byte[] data, int offset);
            static /*0x1779d4c*/ long GetKatmaiDateTicks(byte[] data, ref int pos);
            static /*0x1779e50*/ long GetKatmaiTimeTicks(byte[] data, ref int pos);
            static /*0x177a1ec*/ long GetKatmaiTimeZoneTicks(byte[] data, int pos);
            static /*0x177a4f8*/ int GetFractions(System.DateTime dt);
            static /*0x177a970*/ int GetFractions(System.DateTimeOffset dt);
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

            static /*0x1782e04*/ XmlSqlBinaryReader();
            /*0x177ac2c*/ XmlSqlBinaryReader(System.IO.Stream stream, byte[] data, int len, string baseUri, bool closeInput, System.Xml.XmlReaderSettings settings);
            /*0x177bd0c*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x177be0c*/ System.Xml.XmlNodeType get_NodeType();
            /*0x177be14*/ string get_LocalName();
            /*0x177be1c*/ string get_NamespaceURI();
            /*0x177be24*/ string get_Prefix();
            /*0x177be2c*/ string get_Value();
            /*0x177cabc*/ int get_Depth();
            /*0x177cb60*/ string get_BaseURI();
            /*0x177cb68*/ bool get_IsEmptyElement();
            /*0x177cb8c*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x177cc0c*/ string get_XmlLang();
            /*0x177ccd0*/ System.Type get_ValueType();
            /*0x177ccd8*/ int get_AttributeCount();
            /*0x177cd2c*/ string GetAttribute(string name, string ns);
            /*0x177cee0*/ string GetAttribute(string name);
            /*0x177d02c*/ string GetAttribute(int i);
            /*0x177d0c0*/ bool MoveToAttribute(string name);
            /*0x177d218*/ void MoveToAttribute(int i);
            /*0x177d2c0*/ bool MoveToFirstAttribute();
            /*0x177d338*/ bool MoveToNextAttribute();
            /*0x177d3bc*/ bool MoveToElement();
            /*0x177d474*/ bool get_EOF();
            /*0x177d484*/ bool ReadAttributeValue();
            /*0x177d7f0*/ void Close();
            /*0x177d85c*/ System.Xml.XmlNameTable get_NameTable();
            /*0x177d864*/ string LookupNamespace(string prefix);
            /*0x177d918*/ void ResolveEntity();
            /*0x177d958*/ System.Xml.ReadState get_ReadState();
            /*0x177d9d8*/ bool Read();
            /*0x177e2dc*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x177e65c*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            /*0x177e7f8*/ void VerifyVersion(int requiredVersion, System.Xml.BinXmlToken token);
            /*0x177b20c*/ void AddInitNamespace(string prefix, string uri);
            /*0x177e8d0*/ void AddName();
            /*0x177eacc*/ void AddQName();
            /*0x177ede4*/ void NameFlush();
            /*0x177ee34*/ void SkipExtn();
            /*0x177ef0c*/ int ReadQNameRef();
            /*0x177ed48*/ int ReadNameRef();
            /*0x177ef9c*/ bool FillAllowEOF();
            /*0x177f1d4*/ void Fill_(int require);
            /*0x177eef0*/ void Fill(int require);
            /*0x177f2c8*/ byte ReadByte();
            /*0x177f324*/ ushort ReadUShort();
            /*0x177eec0*/ int ParseMB32();
            /*0x177f398*/ int ParseMB32_(byte b);
            /*0x177f43c*/ int ParseMB32(int pos);
            /*0x177f52c*/ int ParseMB64();
            /*0x177f55c*/ System.Xml.BinXmlToken PeekToken();
            /*0x177f5c4*/ System.Xml.BinXmlToken ReadToken();
            /*0x177f634*/ System.Xml.BinXmlToken NextToken2(System.Xml.BinXmlToken token);
            /*0x177f6ac*/ System.Xml.BinXmlToken NextToken1();
            /*0x177f724*/ System.Xml.BinXmlToken NextToken();
            /*0x177f788*/ System.Xml.BinXmlToken PeekNextToken();
            /*0x177d610*/ System.Xml.BinXmlToken RescanNextToken();
            /*0x177ea04*/ string ParseText();
            /*0x177f7b0*/ int ScanText(ref int start);
            /*0x177bf40*/ string GetString(int pos, int cch);
            /*0x177f868*/ string GetStringAligned(byte[] data, int offset, int cch);
            /*0x177c998*/ string GetAttributeText(int i);
            /*0x177ce58*/ int LocateAttribute(string name, string ns);
            /*0x177cf4c*/ int LocateAttribute(string name);
            /*0x177d158*/ void PositionOnAttribute(int i);
            /*0x177f934*/ void GrowElements();
            /*0x177f9bc*/ void GrowAttributes();
            /*0x177fa40*/ void ClearAttributes();
            /*0x177fa50*/ void PushNamespace(string prefix, string ns, bool implied);
            /*0x177fda0*/ void PopNamespaces(System.Xml.XmlSqlBinaryReader.NamespaceDecl firstInScopeChain);
            /*0x177fe44*/ void GenerateImpliedXmlnsAttrs();
            /*0x177dba8*/ bool ReadInit(bool skipXmlDecl);
            /*0x177ff98*/ void ScanAttributes();
            /*0x1780730*/ void SimpleCheckForDuplicateAttributes();
            /*0x1780870*/ void HashCheckForDuplicateAttributes();
            /*0x177c1b8*/ string XmlDeclValue();
            /*0x177c0b4*/ string CDATAValue();
            /*0x1780b8c*/ void FinishCDATA();
            /*0x1780c34*/ void FinishEndElement();
            /*0x177df60*/ bool ReadDoc();
            /*0x1781708*/ void ImplReadData(System.Xml.BinXmlToken tokenType);
            /*0x1780c98*/ void ImplReadElement();
            /*0x1780ee0*/ void ImplReadEndElement();
            /*0x1780fa8*/ void ImplReadDoctype();
            /*0x178120c*/ void ImplReadPI();
            /*0x1781270*/ void ImplReadComment();
            /*0x178129c*/ void ImplReadCDATA();
            /*0x17812d0*/ void ImplReadNest();
            /*0x1781378*/ void ImplReadEndNest();
            /*0x17813a8*/ void ImplReadXmlText();
            /*0x1781944*/ void UpdateFromTextReader();
            /*0x177d13c*/ bool UpdateFromTextReader(bool needUpdate);
            /*0x1781878*/ void CheckAllowContent();
            /*0x177b2e4*/ void GenerateTokenTypeMap();
            /*0x177d704*/ System.Type GetValueType(System.Xml.BinXmlToken token);
            /*0x177d6f8*/ void ReScanOverValue(System.Xml.BinXmlToken token);
            /*0x178057c*/ System.Xml.XmlNodeType ScanOverValue(System.Xml.BinXmlToken token, bool attr, bool checkChars);
            /*0x1781c48*/ System.Xml.XmlNodeType ScanOverAnyValue(System.Xml.BinXmlToken token, bool attr, bool checkChars);
            /*0x17819ec*/ System.Xml.XmlNodeType CheckText(bool attr);
            /*0x1781bb0*/ System.Xml.XmlNodeType CheckTextIsWS();
            /*0x1782054*/ void CheckValueTokenBounds();
            /*0x1781f6c*/ int GetXsdKatmaiTokenLength(System.Xml.BinXmlToken token);
            /*0x17820b4*/ int XsdKatmaiTimeScaleToValueLength(byte scale);
            /*0x178218c*/ long ValueAsLong();
            /*0x1782964*/ ulong ValueAsULong();
            /*0x17827c4*/ decimal ValueAsDecimal();
            /*0x1782690*/ double ValueAsDouble();
            /*0x1782b00*/ string ValueAsDateTimeString();
            /*0x177c2ec*/ string ValueAsString(System.Xml.BinXmlToken token);
            /*0x1782380*/ short GetInt16(int pos);
            /*0x1782508*/ ushort GetUInt16(int pos);
            /*0x17823c4*/ int GetInt32(int pos);
            /*0x178254c*/ uint GetUInt32(int pos);
            /*0x1782438*/ long GetInt64(int pos);
            /*0x17825c0*/ ulong GetUInt64(int pos);
            /*0x17829b4*/ float GetSingle(int offset);
            /*0x1782a2c*/ double GetDouble(int offset);
            /*0x177e830*/ System.Exception ThrowUnexpectedToken(System.Xml.BinXmlToken token);
            /*0x177f24c*/ System.Exception ThrowXmlException(string res);
            /*0x178046c*/ System.Exception ThrowXmlException(string res, string arg1, string arg2);
            /*0x17806a4*/ System.Exception ThrowNotSupported(string res);

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

                static /*0x17830cc*/ bool op_Equality(System.Xml.XmlSqlBinaryReader.QName a, System.Xml.XmlSqlBinaryReader.QName b);
                /*0x177ff70*/ QName(string prefix, string lname, string nsUri);
                /*0x177edd8*/ void Set(string prefix, string lname, string nsUri);
                /*0x177b1b8*/ void Clear();
                /*0x177f894*/ bool MatchNs(string lname, string nsUri);
                /*0x177f8e4*/ bool MatchPrefix(string prefix, string lname);
                /*0x177fc7c*/ void CheckPrefixNS(string prefix, string namespaceUri);
                /*0x1782f80*/ int GetHashCode();
                /*0x1782fc8*/ int GetNSHashCode(System.Xml.SecureStringHasher hasher);
                /*0x1783014*/ bool Equals(object other);
                /*0x1780ad4*/ string ToString();
            }

            struct ElemInfo
            {
                /*0x10*/ System.Xml.XmlSqlBinaryReader.QName name;
                /*0x28*/ string xmlLang;
                /*0x30*/ System.Xml.XmlSpace xmlSpace;
                /*0x34*/ bool xmlspacePreserve;
                /*0x38*/ System.Xml.XmlSqlBinaryReader.NamespaceDecl nsdecls;

                /*0x17818e0*/ void Set(System.Xml.XmlSqlBinaryReader.QName name, bool xmlspacePreserve);
                /*0x1780c88*/ System.Xml.XmlSqlBinaryReader.NamespaceDecl Clear();
            }

            struct AttrInfo
            {
                /*0x10*/ System.Xml.XmlSqlBinaryReader.QName name;
                /*0x28*/ string val;
                /*0x30*/ int contentPos;
                /*0x34*/ int hashCode;
                /*0x38*/ int prevHash;

                /*0x177ff7c*/ void Set(System.Xml.XmlSqlBinaryReader.QName n, string v);
                /*0x1780450*/ void Set(System.Xml.XmlSqlBinaryReader.QName n, int pos);
                /*0x1780abc*/ void GetLocalnameAndNamespaceUri(ref string localname, ref string namespaceUri);
                /*0x1780b44*/ int GetLocalnameAndNamespaceUriAndHash(System.Xml.SecureStringHasher hasher, ref string localname, ref string namespaceUri);
                /*0x1780ad0*/ bool MatchNS(string localname, string namespaceUri);
                /*0x1780b6c*/ bool MatchHashNS(int hash, string localname, string namespaceUri);
                /*0x177f1c0*/ void AdjustPosition(int adj);
            }

            class NamespaceDecl
            {
                /*0x10*/ string prefix;
                /*0x18*/ string uri;
                /*0x20*/ System.Xml.XmlSqlBinaryReader.NamespaceDecl scopeLink;
                /*0x28*/ System.Xml.XmlSqlBinaryReader.NamespaceDecl prevLink;
                /*0x30*/ int scope;
                /*0x34*/ bool implied;

                /*0x177e878*/ NamespaceDecl(string prefix, string nsuri, System.Xml.XmlSqlBinaryReader.NamespaceDecl nextInScope, System.Xml.XmlSqlBinaryReader.NamespaceDecl prevDecl, int scope, bool implied);
            }

            struct SymbolTables
            {
                /*0x10*/ string[] symtable;
                /*0x18*/ int symCount;
                /*0x20*/ System.Xml.XmlSqlBinaryReader.QName[] qnametable;
                /*0x28*/ int qnameCount;

                /*0x177b0d0*/ void Init();
            }

            class NestedBinXml
            {
                /*0x10*/ System.Xml.XmlSqlBinaryReader.SymbolTables symbolTables;
                /*0x30*/ int docState;
                /*0x38*/ System.Xml.XmlSqlBinaryReader.NestedBinXml next;

                /*0x1781900*/ NestedBinXml(System.Xml.XmlSqlBinaryReader.SymbolTables symbolTables, int docState, System.Xml.XmlSqlBinaryReader.NestedBinXml next);
            }
        }

        class BitStack
        {
            /*0x10*/ uint[] bitStack;
            /*0x18*/ int stackPos;
            /*0x1c*/ uint curr;

            /*0x178312c*/ BitStack();
            /*0x178314c*/ void PushBit(bool bit);
            /*0x178324c*/ bool PopBit();
            /*0x17832b8*/ bool PeekBit();
            /*0x1783184*/ void PushCurr();
            /*0x1783274*/ void PopCurr();
        }

        class Bits
        {
            static /*0x0*/ uint MASK_0101010101010101;
            static /*0x4*/ uint MASK_0011001100110011;
            static /*0x8*/ uint MASK_0000111100001111;
            static /*0xc*/ uint MASK_0000000011111111;
            static /*0x10*/ uint MASK_1111111111111111;

            static /*0x17833cc*/ Bits();
            static /*0x17832c4*/ int Count(uint num);
            static /*0x1783360*/ int LeastPosition(uint num);
        }

        class ByteStack
        {
            /*0x10*/ byte[] stack;
            /*0x18*/ int growthRate;
            /*0x1c*/ int top;
            /*0x20*/ int size;

            /*0x1783424*/ ByteStack(int growthRate);
            /*0x1783494*/ void Push(byte data);
            /*0x1783564*/ byte Pop();
        }

        class CharEntityEncoderFallback : System.Text.EncoderFallback
        {
            /*0x10*/ System.Xml.CharEntityEncoderFallbackBuffer fallbackBuffer;
            /*0x18*/ int[] textContentMarks;
            /*0x20*/ int endMarkPos;
            /*0x24*/ int curMarkPos;
            /*0x28*/ int startOffset;

            /*0x17835b0*/ CharEntityEncoderFallback();
            /*0x17835b8*/ System.Text.EncoderFallbackBuffer CreateFallbackBuffer();
            /*0x1783698*/ int get_MaxCharCount();
            /*0x17836a0*/ void set_StartOffset(int value);
            /*0x17836a8*/ void Reset(int[] textContentMarks, int endMarkPos);
            /*0x17836b4*/ bool CanReplaceAt(int index);
        }

        class CharEntityEncoderFallbackBuffer : System.Text.EncoderFallbackBuffer
        {
            /*0x30*/ System.Xml.CharEntityEncoderFallback parent;
            /*0x38*/ string charEntity;
            /*0x40*/ int charEntityIndex;

            /*0x1783624*/ CharEntityEncoderFallbackBuffer(System.Xml.CharEntityEncoderFallback parent);
            /*0x178371c*/ bool Fallback(char charUnknown, int index);
            /*0x178390c*/ bool Fallback(char charUnknownHigh, char charUnknownLow, int index);
            /*0x1783b9c*/ char GetNextChar();
            /*0x1783bf4*/ bool MovePrevious();
            /*0x1783c14*/ int get_Remaining();
            /*0x1783c48*/ void Reset();
            /*0x1783b8c*/ int SurrogateCharToUtf32(char highSurrogate, char lowSurrogate);
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

            /*0x1783c54*/ HtmlEncodedRawTextWriter(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings);
            /*0x1783df4*/ HtmlEncodedRawTextWriter(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x1783e20*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x1783e24*/ void WriteXmlDeclaration(string xmldecl);
            /*0x1783e28*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x1784070*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x178419c*/ void StartElementContent();
            /*0x1784304*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x1784408*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x178450c*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x1784690*/ void WriteEndAttribute();
            /*0x17847b8*/ void WriteProcessingInstruction(string target, string text);
            /*0x17848ec*/ void WriteString(string text);
            /*0x17849b8*/ void WriteEntityRef(string name);
            /*0x1784a18*/ void WriteCharEntity(char ch);
            /*0x1784a78*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x1784ad8*/ void WriteChars(char[] buffer, int index, int count);
            /*0x1783c80*/ void Init(System.Xml.XmlWriterSettings settings);
            /*0x17841f0*/ void WriteMetaElement();
            /*0x17849a0*/ void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd);
            /*0x178495c*/ void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd);
            /*0x1784ebc*/ void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd);
            /*0x1784b68*/ void WriteUriAttributeText(char* pSrc, char* pSrcEnd);
            /*0x1784724*/ void OutputRestAmps();
        }

        class HtmlEncodedRawTextWriterIndent : System.Xml.HtmlEncodedRawTextWriter
        {
            /*0xec*/ int indentLevel;
            /*0xf0*/ int endBlockPos;
            /*0xf8*/ string indentChars;
            /*0x100*/ bool newLineOnAttributes;

            /*0x1785150*/ HtmlEncodedRawTextWriterIndent(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings);
            /*0x17851c4*/ HtmlEncodedRawTextWriterIndent(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x1785210*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x178522c*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x1785440*/ void StartElementContent();
            /*0x17854b0*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x1785550*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x17855c4*/ void FlushBuffer();
            /*0x178519c*/ void Init(System.Xml.XmlWriterSettings settings);
            /*0x17853f0*/ void WriteIndent();
        }

        class HtmlTernaryTree
        {
            static /*0x0*/ byte[] htmlElements;
            static /*0x8*/ byte[] htmlAttributes;

            static /*0x17855f0*/ HtmlTernaryTree();
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

            /*0x17856c0*/ HtmlUtf8RawTextWriter(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0x1785860*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0x1785864*/ void WriteXmlDeclaration(string xmldecl);
            /*0x1785868*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x1785ab0*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0x1785bbc*/ void StartElementContent();
            /*0x1785d28*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0x1785e0c*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0x1785ef0*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0x1786064*/ void WriteEndAttribute();
            /*0x17861a0*/ void WriteProcessingInstruction(string target, string text);
            /*0x17862c0*/ void WriteString(string text);
            /*0x178636c*/ void WriteEntityRef(string name);
            /*0x17863cc*/ void WriteCharEntity(char ch);
            /*0x178642c*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x178648c*/ void WriteChars(char[] buffer, int index, int count);
            /*0x17856ec*/ void Init(System.Xml.XmlWriterSettings settings);
            /*0x1785c14*/ void WriteMetaElement();
            /*0x1786354*/ void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd);
            /*0x1786310*/ void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd);
            /*0x178680c*/ void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd);
            /*0x17864d0*/ void WriteUriAttributeText(char* pSrc, char* pSrcEnd);
            /*0x17860dc*/ void OutputRestAmps();
        }

        class HtmlUtf8RawTextWriterIndent : System.Xml.HtmlUtf8RawTextWriter
        {
            /*0xbc*/ int indentLevel;
            /*0xc0*/ int endBlockPos;
            /*0xc8*/ string indentChars;
            /*0xd0*/ bool newLineOnAttributes;

            /*0xd2a8c0*/ HtmlUtf8RawTextWriterIndent(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0xd2a928*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0xd2a948*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0xd2ac6c*/ void StartElementContent();
            /*0xd2ace4*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0xd2ad8c*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0xd2ae04*/ void FlushBuffer();
            /*0xd2a900*/ void Init(System.Xml.XmlWriterSettings settings);
            /*0xd2ac1c*/ void WriteIndent();
        }

        interface IDtdInfo
        {
            System.Xml.XmlQualifiedName get_Name();
            string get_InternalDtdSubset();
            bool get_HasDefaultAttributes();
            bool get_HasNonCDataAttributes();
            System.Xml.IDtdAttributeListInfo LookupAttributeList(string prefix, string localName);
            System.Xml.IDtdEntityInfo LookupEntity(string name);
        }

        interface IDtdAttributeListInfo
        {
            bool get_HasNonCDataAttributes();
            System.Xml.IDtdAttributeInfo LookupAttribute(string prefix, string localName);
            System.Collections.Generic.IEnumerable<System.Xml.IDtdDefaultAttributeInfo> LookupDefaultAttributes();
        }

        interface IDtdAttributeInfo
        {
            string get_Prefix();
            string get_LocalName();
            int get_LineNumber();
            int get_LinePosition();
            bool get_IsNonCDataType();
            bool get_IsDeclaredInExternal();
            bool get_IsXmlAttribute();
        }

        interface IDtdDefaultAttributeInfo : System.Xml.IDtdAttributeInfo
        {
            string get_DefaultValueExpanded();
            object get_DefaultValueTyped();
            int get_ValueLineNumber();
            int get_ValueLinePosition();
        }

        interface IDtdEntityInfo
        {
            string get_Name();
            bool get_IsExternal();
            bool get_IsDeclaredInExternal();
            bool get_IsUnparsedEntity();
            bool get_IsParameterEntity();
            string get_BaseUriString();
            string get_DeclaredUriString();
            string get_SystemId();
            string get_PublicId();
            string get_Text();
            int get_LineNumber();
            int get_LinePosition();
        }

        interface IDtdParser
        {
            System.Xml.IDtdInfo ParseInternalDtd(System.Xml.IDtdParserAdapter adapter, bool saveInternalSubset);
            System.Xml.IDtdInfo ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, System.Xml.IDtdParserAdapter adapter);
        }

        interface IDtdParserAdapter
        {
            System.Xml.XmlNameTable get_NameTable();
            System.Xml.IXmlNamespaceResolver get_NamespaceResolver();
            System.Uri get_BaseUri();
            char[] get_ParsingBuffer();
            int get_ParsingBufferLength();
            int get_CurrentPosition();
            void set_CurrentPosition(int value);
            int get_LineNo();
            int get_LineStartPosition();
            bool get_IsEof();
            int get_EntityStackLength();
            bool get_IsEntityEolNormalized();
            int ReadData();
            void OnNewLine(int pos);
            int ParseNumericCharRef(System.Text.StringBuilder internalSubsetBuilder);
            int ParseNamedCharRef(bool expand, System.Text.StringBuilder internalSubsetBuilder);
            void ParsePI(System.Text.StringBuilder sb);
            void ParseComment(System.Text.StringBuilder sb);
            bool PushEntity(System.Xml.IDtdEntityInfo entity, ref int entityId);
            bool PopEntity(ref System.Xml.IDtdEntityInfo oldEntity, ref int newEntityId);
            bool PushExternalSubset(string systemId, string publicId);
            void PushInternalDtd(string baseUri, string internalDtd);
            void OnSystemId(string systemId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo systemLiteralLineInfo);
            void OnPublicId(string publicId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo publicLiteralLineInfo);
            void Throw(System.Exception e);
        }

        interface IDtdParserAdapterWithValidation : System.Xml.IDtdParserAdapter
        {
            bool get_DtdValidation();
            System.Xml.IValidationEventHandling get_ValidationEventHandling();
        }

        interface IDtdParserAdapterV1 : System.Xml.IDtdParserAdapterWithValidation, System.Xml.IDtdParserAdapter
        {
            bool get_V1CompatibilityMode();
            bool get_Normalization();
            bool get_Namespaces();
        }

        class OnRemoveWriter : System.MulticastDelegate
        {
            /*0xd2ae30*/ OnRemoveWriter(object object, nint method);
            /*0xd2af5c*/ void Invoke(System.Xml.XmlRawWriter writer);
        }

        interface IValidationEventHandling
        {
            object get_EventHandler();
            void SendEvent(System.Exception exception, System.Xml.Schema.XmlSeverityType severity);
        }

        class IncrementalReadDecoder
        {
            /*0xd2af70*/ IncrementalReadDecoder();
            bool get_IsFull();
            int Decode(char[] chars, int startPos, int len);
        }

        class IncrementalReadDummyDecoder : System.Xml.IncrementalReadDecoder
        {
            /*0xd2af88*/ IncrementalReadDummyDecoder();
            /*0xd2af78*/ bool get_IsFull();
            /*0xd2af80*/ int Decode(char[] chars, int startPos, int len);
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

            /*0xd2af90*/ QueryOutputWriter(System.Xml.XmlRawWriter writer, System.Xml.XmlWriterSettings settings);
            /*0xd2b254*/ void set_NamespaceResolver(System.Xml.IXmlNamespaceResolver value);
            /*0xd2b280*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0xd2b2a4*/ void WriteXmlDeclaration(string xmldecl);
            /*0xd2b2c8*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0xd2b300*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0xd2b4cc*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0xd2b52c*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0xd2b58c*/ void StartElementContent();
            /*0xd2b5b0*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0xd2b5dc*/ void WriteEndAttribute();
            /*0xd2b608*/ void WriteNamespaceDeclaration(string prefix, string ns);
            /*0xd2b62c*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0xd2b650*/ void WriteStartNamespaceDeclaration(string prefix);
            /*0xd2b674*/ void WriteEndNamespaceDeclaration();
            /*0xd2b698*/ void WriteCData(string text);
            /*0xd2b6bc*/ void WriteComment(string text);
            /*0xd2b6e8*/ void WriteProcessingInstruction(string name, string text);
            /*0xd2b714*/ void WriteWhitespace(string ws);
            /*0xd2b7c0*/ void WriteString(string text);
            /*0xd2b82c*/ void WriteChars(char[] buffer, int index, int count);
            /*0xd2b8dc*/ void WriteEntityRef(string name);
            /*0xd2b908*/ void WriteCharEntity(char ch);
            /*0xd2b934*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0xd2b960*/ void WriteRaw(char[] buffer, int index, int count);
            /*0xd2ba10*/ void WriteRaw(string data);
            /*0xd2ba7c*/ void Close();
            /*0xd2bb24*/ void Flush();
            /*0xd2b780*/ bool StartCDataSection();
            /*0xd2b4c4*/ void EndCDataSection();
        }

        class ReadContentAsBinaryHelper
        {
            /*0x10*/ System.Xml.XmlReader reader;
            /*0x18*/ System.Xml.ReadContentAsBinaryHelper.State state;
            /*0x1c*/ int valueOffset;
            /*0x20*/ bool isEnd;

            /*0xd2bb48*/ void Finish();
            /*0xd2bd60*/ void Reset();
            /*0xd2bc88*/ bool MoveToNextContentNode(bool moveIfOnContentNode);

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

            /*0xd2bd6c*/ TernaryTreeReadOnly(byte[] nodeBuffer);
            /*0xd2aaf0*/ byte FindCaseInsensitiveString(string stringToFind);
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

            static /*0xd2bfc4*/ int GetHashCodeOfString(string key, int sLen, long additionalEntropy);
            static /*0xd2be6c*/ System.Xml.SecureStringHasher.HashCodeOfStringDelegate GetHashCodeDelegate();
            /*0xd2bd94*/ SecureStringHasher();
            /*0xd2bdb8*/ bool Equals(string x, string y);
            /*0xd2bdd0*/ int GetHashCode(string key);

            class HashCodeOfStringDelegate : System.MulticastDelegate
            {
                /*0xd2c030*/ HashCodeOfStringDelegate(object object, nint method);
                /*0xd2c108*/ int Invoke(string s, int sLen, long additionalEntropy);
            }
        }

        class TextEncodedRawTextWriter : System.Xml.XmlEncodedRawTextWriter
        {
            /*0xd2c11c*/ TextEncodedRawTextWriter(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings);
            /*0xd2c1f8*/ TextEncodedRawTextWriter(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0xd2c480*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0xd2c484*/ void WriteXmlDeclaration(string xmldecl);
            /*0xd2c488*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0xd2c48c*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0xd2c490*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0xd2c494*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0xd2c498*/ void StartElementContent();
            /*0xd2c49c*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0xd2c4a8*/ void WriteEndAttribute();
            /*0xd2c4b0*/ void WriteNamespaceDeclaration(string prefix, string ns);
            /*0xd2c4b4*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0xd2c4bc*/ void WriteCData(string text);
            /*0xd2c524*/ void WriteComment(string text);
            /*0xd2c528*/ void WriteProcessingInstruction(string name, string text);
            /*0xd2c52c*/ void WriteEntityRef(string name);
            /*0xd2c530*/ void WriteCharEntity(char ch);
            /*0xd2c534*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0xd2c538*/ void WriteWhitespace(string ws);
            /*0xd2c548*/ void WriteString(string textBlock);
            /*0xd2c558*/ void WriteChars(char[] buffer, int index, int count);
            /*0xd2c5e4*/ void WriteRaw(char[] buffer, int index, int count);
            /*0xd2c5f4*/ void WriteRaw(string data);
        }

        class TextUtf8RawTextWriter : System.Xml.XmlUtf8RawTextWriter
        {
            /*0xd2c604*/ TextUtf8RawTextWriter(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0xd2c60c*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0xd2c610*/ void WriteXmlDeclaration(string xmldecl);
            /*0xd2c614*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0xd2c618*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0xd2c61c*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0xd2c620*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0xd2c624*/ void StartElementContent();
            /*0xd2c628*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0xd2c634*/ void WriteEndAttribute();
            /*0xd2c63c*/ void WriteNamespaceDeclaration(string prefix, string ns);
            /*0xd2c640*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0xd2c648*/ void WriteCData(string text);
            /*0xd2c650*/ void WriteComment(string text);
            /*0xd2c654*/ void WriteProcessingInstruction(string name, string text);
            /*0xd2c658*/ void WriteEntityRef(string name);
            /*0xd2c65c*/ void WriteCharEntity(char ch);
            /*0xd2c660*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0xd2c664*/ void WriteWhitespace(string ws);
            /*0xd2c678*/ void WriteString(string textBlock);
            /*0xd2c68c*/ void WriteChars(char[] buffer, int index, int count);
            /*0xd2c6a0*/ void WriteRaw(char[] buffer, int index, int count);
            /*0xd2c6b4*/ void WriteRaw(string data);
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

            /*0xd2c6c8*/ ValidatingReaderNodeData();
            /*0xd2c768*/ ValidatingReaderNodeData(System.Xml.XmlNodeType nodeType);
            /*0xd2c794*/ string get_LocalName();
            /*0xd2c79c*/ void set_LocalName(string value);
            /*0xd2c7a4*/ string get_Namespace();
            /*0xd2c7ac*/ void set_Namespace(string value);
            /*0xd2c7b4*/ string get_Prefix();
            /*0xd2c7bc*/ void set_Prefix(string value);
            /*0xd2c7c4*/ string GetAtomizedNameWPrefix(System.Xml.XmlNameTable nameTable);
            /*0xd2c858*/ int get_Depth();
            /*0xd2c860*/ void set_Depth(int value);
            /*0xd2c868*/ string get_RawValue();
            /*0xd2c870*/ void set_RawValue(string value);
            /*0xd2c878*/ string get_OriginalStringValue();
            /*0xd2c880*/ System.Xml.XmlNodeType get_NodeType();
            /*0xd2c888*/ void set_NodeType(System.Xml.XmlNodeType value);
            /*0xd2c890*/ System.Xml.AttributePSVIInfo get_AttInfo();
            /*0xd2c898*/ void set_AttInfo(System.Xml.AttributePSVIInfo value);
            /*0xd2c8a0*/ int get_LineNumber();
            /*0xd2c8a8*/ int get_LinePosition();
            /*0xd2c6e8*/ void Clear(System.Xml.XmlNodeType nodeType);
            /*0xd2c8b0*/ void SetLineInfo(int lineNo, int linePos);
            /*0xd2c8b8*/ void SetLineInfo(System.Xml.IXmlLineInfo lineInfo);
            /*0xd2c9c0*/ void SetItemData(string localName, string prefix, string ns, int depth);
            /*0xd2ca3c*/ void SetItemData(string value);
            /*0xd2ca44*/ void SetItemData(string value, string originalStringValue);
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

            static /*0xd2ca54*/ System.Xml.XmlAsyncCheckReader CreateAsyncCheckWrapper(System.Xml.XmlReader reader);
            /*0xd2ce80*/ XmlAsyncCheckReader(System.Xml.XmlReader reader);
            /*0xd2ca4c*/ System.Xml.XmlReader get_CoreReader();
            /*0xd2cf28*/ void CheckAsync();
            /*0xd2cfac*/ System.Xml.XmlReaderSettings get_Settings();
            /*0xd2d13c*/ System.Xml.XmlNodeType get_NodeType();
            /*0xd2d164*/ string get_Name();
            /*0xd2d18c*/ string get_LocalName();
            /*0xd2d1b4*/ string get_NamespaceURI();
            /*0xd2d1dc*/ string get_Prefix();
            /*0xd2d204*/ string get_Value();
            /*0xd2d22c*/ int get_Depth();
            /*0xd2d254*/ string get_BaseURI();
            /*0xd2d280*/ bool get_IsEmptyElement();
            /*0xd2d2ac*/ bool get_IsDefault();
            /*0xd2d2d8*/ char get_QuoteChar();
            /*0xd2d304*/ System.Xml.XmlSpace get_XmlSpace();
            /*0xd2d330*/ string get_XmlLang();
            /*0xd2d35c*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0xd2d388*/ System.Type get_ValueType();
            /*0xd2d3b4*/ int get_AttributeCount();
            /*0xd2d3e0*/ string GetAttribute(string name);
            /*0xd2d41c*/ string GetAttribute(string name, string namespaceURI);
            /*0xd2d460*/ string GetAttribute(int i);
            /*0xd2d49c*/ bool MoveToAttribute(string name);
            /*0xd2d4d8*/ void MoveToAttribute(int i);
            /*0xd2d514*/ bool MoveToFirstAttribute();
            /*0xd2d540*/ bool MoveToNextAttribute();
            /*0xd2d56c*/ bool MoveToElement();
            /*0xd2d598*/ bool ReadAttributeValue();
            /*0xd2d5c4*/ bool Read();
            /*0xd2d5f0*/ bool get_EOF();
            /*0xd2d61c*/ void Close();
            /*0xd2d648*/ System.Xml.ReadState get_ReadState();
            /*0xd2d674*/ void Skip();
            /*0xd2d6a0*/ System.Xml.XmlNameTable get_NameTable();
            /*0xd2d6cc*/ string LookupNamespace(string prefix);
            /*0xd2d708*/ bool get_CanResolveEntity();
            /*0xd2d734*/ void ResolveEntity();
            /*0xd2d760*/ bool get_CanReadValueChunk();
            /*0xd2d78c*/ int ReadValueChunk(char[] buffer, int index, int count);
            /*0xd2d7e0*/ string ReadString();
            /*0xd2d80c*/ System.Xml.XmlNodeType MoveToContent();
            /*0xd2d838*/ void ReadStartElement();
            /*0xd2d864*/ string ReadElementString();
            /*0xd2d890*/ void ReadEndElement();
            /*0xd2d8bc*/ bool IsStartElement(string localname, string ns);
            /*0xd2d900*/ string ReadInnerXml();
            /*0xd2d92c*/ bool get_HasAttributes();
            /*0xd2d958*/ void Dispose(bool disposing);
            /*0xd2d99c*/ System.Xml.XmlNamespaceManager get_NamespaceManager();
            /*0xd2d9c8*/ System.Xml.IDtdInfo get_DtdInfo();
        }

        class XmlAsyncCheckReaderWithNS : System.Xml.XmlAsyncCheckReader, System.Xml.IXmlNamespaceResolver
        {
            /*0x20*/ System.Xml.IXmlNamespaceResolver readerAsIXmlNamespaceResolver;

            /*0xd2cddc*/ XmlAsyncCheckReaderWithNS(System.Xml.XmlReader reader);
            /*0xd2d9f4*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0xd2da9c*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0xd2db48*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
        }

        class XmlAsyncCheckReaderWithLineInfo : System.Xml.XmlAsyncCheckReader, System.Xml.IXmlLineInfo
        {
            /*0x20*/ System.Xml.IXmlLineInfo readerAsIXmlLineInfo;

            /*0xd2cd38*/ XmlAsyncCheckReaderWithLineInfo(System.Xml.XmlReader reader);
            /*0xd2dbf4*/ bool HasLineInfo();
            /*0xd2dc94*/ int get_LineNumber();
            /*0xd2dd38*/ int get_LinePosition();
        }

        class XmlAsyncCheckReaderWithLineInfoNS : System.Xml.XmlAsyncCheckReaderWithLineInfo, System.Xml.IXmlNamespaceResolver
        {
            /*0x28*/ System.Xml.IXmlNamespaceResolver readerAsIXmlNamespaceResolver;

            /*0xd2cc94*/ XmlAsyncCheckReaderWithLineInfoNS(System.Xml.XmlReader reader);
            /*0xd2dddc*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0xd2de84*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0xd2df30*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
        }

        class XmlAsyncCheckReaderWithLineInfoNSSchema : System.Xml.XmlAsyncCheckReaderWithLineInfoNS, System.Xml.Schema.IXmlSchemaInfo
        {
            /*0x30*/ System.Xml.Schema.IXmlSchemaInfo readerAsIXmlSchemaInfo;

            /*0xd2cbf0*/ XmlAsyncCheckReaderWithLineInfoNSSchema(System.Xml.XmlReader reader);
            /*0xd2dfdc*/ System.Xml.Schema.XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity();
            /*0xd2e07c*/ bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault();
            /*0xd2e120*/ bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil();
            /*0xd2e1c4*/ System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType();
            /*0xd2e268*/ System.Xml.Schema.XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType();
            /*0xd2e30c*/ System.Xml.Schema.XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement();
            /*0xd2e3b0*/ System.Xml.Schema.XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute();
        }

        class XmlAsyncCheckWriter : System.Xml.XmlWriter
        {
            /*0x18*/ System.Xml.XmlWriter coreWriter;
            /*0x20*/ System.Threading.Tasks.Task lastTask;

            /*0xd2e454*/ XmlAsyncCheckWriter(System.Xml.XmlWriter writer);
            /*0xd2e4d0*/ void CheckAsync();
            /*0xd2e554*/ void WriteStartDocument();
            /*0xd2e57c*/ void WriteStartDocument(bool standalone);
            /*0xd2e5b4*/ void WriteEndDocument();
            /*0xd2e5dc*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0xd2e634*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0xd2e684*/ void WriteEndElement();
            /*0xd2e6ac*/ void WriteFullEndElement();
            /*0xd2e6d4*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0xd2e724*/ void WriteEndAttribute();
            /*0xd2e750*/ void WriteCData(string text);
            /*0xd2e78c*/ void WriteComment(string text);
            /*0xd2e7c8*/ void WriteProcessingInstruction(string name, string text);
            /*0xd2e80c*/ void WriteEntityRef(string name);
            /*0xd2e848*/ void WriteCharEntity(char ch);
            /*0xd2e884*/ void WriteWhitespace(string ws);
            /*0xd2e8c0*/ void WriteString(string text);
            /*0xd2e8fc*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0xd2e940*/ void WriteChars(char[] buffer, int index, int count);
            /*0xd2e994*/ void WriteRaw(char[] buffer, int index, int count);
            /*0xd2e9e8*/ void WriteRaw(string data);
            /*0xd2ea24*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0xd2ea78*/ void WriteBinHex(byte[] buffer, int index, int count);
            /*0xd2eacc*/ System.Xml.WriteState get_WriteState();
            /*0xd2eaf8*/ void Close();
            /*0xd2eb24*/ void Flush();
            /*0xd2eb50*/ string LookupPrefix(string ns);
            /*0xd2eb8c*/ void WriteValue(string value);
            /*0xd2ebc8*/ void WriteAttributes(System.Xml.XmlReader reader, bool defattr);
            /*0xd2ec0c*/ void WriteNode(System.Xml.XmlReader reader, bool defattr);
            /*0xd2ec50*/ void Dispose(bool disposing);
        }

        class XmlAutoDetectWriter : System.Xml.XmlRawWriter
        {
            /*0x28*/ System.Xml.XmlRawWriter wrapped;
            /*0x30*/ System.Xml.OnRemoveWriter onRemove;
            /*0x38*/ System.Xml.XmlWriterSettings writerSettings;
            /*0x40*/ System.Xml.XmlEventCache eventCache;
            /*0x48*/ System.IO.TextWriter textWriter;
            /*0x50*/ System.IO.Stream strm;

            static /*0xd2eeac*/ bool IsHtmlTag(string tagName);
            /*0xd2ec74*/ XmlAutoDetectWriter(System.Xml.XmlWriterSettings writerSettings);
            /*0xd2ed64*/ XmlAutoDetectWriter(System.IO.TextWriter textWriter, System.Xml.XmlWriterSettings writerSettings);
            /*0xd2ed8c*/ XmlAutoDetectWriter(System.IO.Stream strm, System.Xml.XmlWriterSettings writerSettings);
            /*0xd2edb4*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0xd2ee2c*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0xd2f100*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0xd2f160*/ void WriteEndAttribute();
            /*0xd2f184*/ void WriteCData(string text);
            /*0xd2f22c*/ void WriteComment(string text);
            /*0xd2f25c*/ void WriteProcessingInstruction(string name, string text);
            /*0xd2f28c*/ void WriteWhitespace(string ws);
            /*0xd2f2bc*/ void WriteString(string text);
            /*0xd2f304*/ void WriteChars(char[] buffer, int index, int count);
            /*0xd2f334*/ void WriteRaw(char[] buffer, int index, int count);
            /*0xd2f364*/ void WriteRaw(string data);
            /*0xd2f3ac*/ void WriteEntityRef(string name);
            /*0xd2f3f8*/ void WriteCharEntity(char ch);
            /*0xd2f444*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0xd2f498*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0xd2f4fc*/ void WriteBinHex(byte[] buffer, int index, int count);
            /*0xd2f560*/ void Close();
            /*0xd2f59c*/ void Flush();
            /*0xd2f5d8*/ void WriteValue(string value);
            /*0xd2f624*/ void set_NamespaceResolver(System.Xml.IXmlNamespaceResolver value);
            /*0xd2f658*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0xd2f6a4*/ void WriteXmlDeclaration(string xmldecl);
            /*0xd2f6f0*/ void StartElementContent();
            /*0xd2f714*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0xd2f738*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0xd2f75c*/ void WriteNamespaceDeclaration(string prefix, string ns);
            /*0xd2f7b0*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0xd2f7d4*/ void WriteStartNamespaceDeclaration(string prefix);
            /*0xd2f820*/ void WriteEndNamespaceDeclaration();
            /*0xd2ee1c*/ void EnsureWrappedWriter(System.Xml.XmlOutputMethod outMethod);
            /*0xd2f1cc*/ bool TextBlockCreatesWriter(string textBlock);
            /*0xd2efc0*/ void CreateWrappedWriter(System.Xml.XmlOutputMethod outMethod);
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

            static /*0xd32c10*/ char* EncodeSurrogate(char* pSrc, char* pSrcEnd, char* pDst);
            static /*0xd32b3c*/ char* LtEntity(char* pDst);
            static /*0xd32b54*/ char* GtEntity(char* pDst);
            static /*0xd32b14*/ char* AmpEntity(char* pDst);
            static /*0xd32b6c*/ char* QuoteEntity(char* pDst);
            static /*0xd32b98*/ char* TabEntity(char* pDst);
            static /*0xd32be8*/ char* LineFeedEntity(char* pDst);
            static /*0xd32bc0*/ char* CarriageReturnEntity(char* pDst);
            static /*0xd33004*/ char* CharEntity(char* pDst, char ch);
            static /*0xd32fcc*/ char* RawStartCData(char* pDst);
            static /*0xd32fac*/ char* RawEndCData(char* pDst);
            /*0xd2ff4c*/ XmlEncodedRawTextWriter(System.Xml.XmlWriterSettings settings);
            /*0xd2c120*/ XmlEncodedRawTextWriter(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings);
            /*0xd2c1fc*/ XmlEncodedRawTextWriter(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0xd30388*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0xd305b4*/ void WriteXmlDeclaration(string xmldecl);
            /*0xd3062c*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0xd30818*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0xd308e0*/ void StartElementContent();
            /*0xd30924*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0xd30a94*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0xd30b9c*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0xd30cbc*/ void WriteEndAttribute();
            /*0xd30d24*/ void WriteNamespaceDeclaration(string prefix, string namespaceName);
            /*0xd30d78*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0xd30d80*/ void WriteStartNamespaceDeclaration(string prefix);
            /*0xd30ea4*/ void WriteEndNamespaceDeclaration();
            /*0xd30f0c*/ void WriteCData(string text);
            /*0xd313fc*/ void WriteComment(string text);
            /*0xd3183c*/ void WriteProcessingInstruction(string name, string text);
            /*0xd31968*/ void WriteEntityRef(string name);
            /*0xd31a34*/ void WriteCharEntity(char ch);
            /*0xd31bf8*/ void WriteWhitespace(string ws);
            /*0xd32208*/ void WriteString(string text);
            /*0xd32274*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0xd323bc*/ void WriteChars(char[] buffer, int index, int count);
            /*0xd2c568*/ void WriteRaw(char[] buffer, int index, int count);
            /*0xd2c4c0*/ void WriteRaw(string data);
            /*0xd32668*/ void Close();
            /*0xd32780*/ void Flush();
            /*0xd327d8*/ void FlushBuffer();
            /*0xd329e0*/ void EncodeChars(int startOffset, int endOffset, bool writeAllToStream);
            /*0xd326e4*/ void FlushEncoder();
            /*0xd31c64*/ void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd);
            /*0xd31f58*/ void WriteElementTextBlock(char* pSrc, char* pSrcEnd);
            /*0xd30578*/ void RawText(string s);
            /*0xd32e38*/ void RawText(char* pSrcBegin, char* pSrcEnd);
            /*0xd32444*/ void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd);
            /*0xd31528*/ void WriteCommentOrPi(string text, int stopChar);
            /*0xd310ec*/ void WriteCDataSection(string text);
            /*0xd32d70*/ char* InvalidXmlChar(int ch, char* pDst, bool entitize);
            /*0xd330b4*/ void EncodeChar(ref char* pSrc, char* pSrcEnd, ref char* pDst);
            /*0xd30504*/ void ChangeTextContentMark(bool value);
            /*0xd33158*/ void GrowTextContentMarks();
            /*0xd32ddc*/ char* WriteNewLine(char* pDst);
            /*0xd30028*/ void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace);
        }

        class XmlEncodedRawTextWriterIndent : System.Xml.XmlEncodedRawTextWriter
        {
            /*0xc0*/ int indentLevel;
            /*0xc4*/ bool newLineOnAttributes;
            /*0xc8*/ string indentChars;
            /*0xd0*/ bool mixedContent;
            /*0xd8*/ System.Xml.BitStack mixedContentStack;
            /*0xe0*/ System.Xml.ConformanceLevel conformanceLevel;

            /*0xd331d8*/ XmlEncodedRawTextWriterIndent(System.IO.TextWriter writer, System.Xml.XmlWriterSettings settings);
            /*0xd3330c*/ XmlEncodedRawTextWriterIndent(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0xd33334*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0xd333dc*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0xd33448*/ void StartElementContent();
            /*0xd33498*/ void OnRootElement(System.Xml.ConformanceLevel currentConformanceLevel);
            /*0xd334a0*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0xd33520*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0xd335a0*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0xd335dc*/ void WriteCData(string text);
            /*0xd335e8*/ void WriteComment(string text);
            /*0xd33628*/ void WriteProcessingInstruction(string target, string text);
            /*0xd33670*/ void WriteEntityRef(string name);
            /*0xd3367c*/ void WriteCharEntity(char ch);
            /*0xd33688*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0xd33694*/ void WriteWhitespace(string ws);
            /*0xd336a0*/ void WriteString(string text);
            /*0xd336ac*/ void WriteChars(char[] buffer, int index, int count);
            /*0xd336b8*/ void WriteRaw(char[] buffer, int index, int count);
            /*0xd336c4*/ void WriteRaw(string data);
            /*0xd336d0*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0xd33200*/ void Init(System.Xml.XmlWriterSettings settings);
            /*0xd33394*/ void WriteIndent();
        }

        class XmlEventCache : System.Xml.XmlRawWriter
        {
            /*0x28*/ System.Collections.Generic.List<System.Xml.XmlEventCache.XmlEvent[]> pages;
            /*0x30*/ System.Xml.XmlEventCache.XmlEvent[] pageCurr;
            /*0x38*/ int pageSize;
            /*0x3c*/ bool hasRootNode;
            /*0x40*/ System.Xml.Xsl.Runtime.StringConcat singleText;
            /*0x78*/ string baseUri;

            static /*0xd33bc4*/ byte[] ToBytes(byte[] buffer, int index, int count);
            /*0xd2ed34*/ XmlEventCache(string baseUri, bool hasRootNode);
            /*0xd2f844*/ void EndEvents();
            /*0xd2f858*/ void EventsToWriter(System.Xml.XmlWriter writer);
            /*0xd337b8*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0xd33840*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0xd338b8*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0xd338cc*/ void WriteEndAttribute();
            /*0xd338d4*/ void WriteCData(string text);
            /*0xd33930*/ void WriteComment(string text);
            /*0xd3393c*/ void WriteProcessingInstruction(string name, string text);
            /*0xd339a8*/ void WriteWhitespace(string ws);
            /*0xd339b4*/ void WriteString(string text);
            /*0xd339d8*/ void WriteChars(char[] buffer, int index, int count);
            /*0xd33a08*/ void WriteRaw(char[] buffer, int index, int count);
            /*0xd33a38*/ void WriteRaw(string data);
            /*0xd33a44*/ void WriteEntityRef(string name);
            /*0xd33a50*/ void WriteCharEntity(char ch);
            /*0xd33b0c*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0xd33b98*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0xd33c78*/ void WriteBinHex(byte[] buffer, int index, int count);
            /*0xd33ca4*/ void Close();
            /*0xd33cac*/ void Flush();
            /*0xd33cb4*/ void WriteValue(string value);
            /*0xd33cc4*/ void Dispose(bool disposing);
            /*0xd33d74*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0xd33de0*/ void WriteXmlDeclaration(string xmldecl);
            /*0xd33dec*/ void StartElementContent();
            /*0xd33df4*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0xd33e08*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0xd33e1c*/ void WriteNamespaceDeclaration(string prefix, string ns);
            /*0xd33e2c*/ void WriteEndBase64();
            /*0xd33770*/ void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType);
            /*0xd338e0*/ void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1);
            /*0xd3394c*/ void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1, string s2);
            /*0xd33854*/ void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1, string s2, string s3);
            /*0xd337d0*/ void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o);
            /*0xd33abc*/ void AddEvent(System.Xml.XmlEventCache.XmlEventType eventType, object o);
            /*0xd33e34*/ int NewEvent();

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

                /*0xd34080*/ void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType);
                /*0xd3403c*/ void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1);
                /*0xd34048*/ void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1, string s2);
                /*0xd34054*/ void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1, string s2, string s3);
                /*0xd34064*/ void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o);
                /*0xd34074*/ void InitEvent(System.Xml.XmlEventCache.XmlEventType eventType, object o);
                /*0xd34088*/ System.Xml.XmlEventCache.XmlEventType get_EventType();
                /*0xd34090*/ string get_String1();
                /*0xd34098*/ string get_String2();
                /*0xd340a0*/ string get_String3();
                /*0xd340a8*/ object get_Object();
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

            /*0xd340b0*/ XmlParserContext(System.Xml.XmlNameTable nt, System.Xml.XmlNamespaceManager nsMgr, string xmlLang, System.Xml.XmlSpace xmlSpace);
            /*0xd34150*/ XmlParserContext(System.Xml.XmlNameTable nt, System.Xml.XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, System.Xml.XmlSpace xmlSpace);
            /*0xd3417c*/ XmlParserContext(System.Xml.XmlNameTable nt, System.Xml.XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, System.Xml.XmlSpace xmlSpace, System.Text.Encoding enc);
            /*0xd34338*/ System.Xml.XmlNameTable get_NameTable();
            /*0xd34340*/ System.Xml.XmlNamespaceManager get_NamespaceManager();
            /*0xd34348*/ string get_DocTypeName();
            /*0xd34350*/ string get_PublicId();
            /*0xd34358*/ string get_SystemId();
            /*0xd34360*/ string get_BaseURI();
            /*0xd34368*/ string get_InternalSubset();
            /*0xd34370*/ string get_XmlLang();
            /*0xd34378*/ System.Xml.XmlSpace get_XmlSpace();
            /*0xd34380*/ System.Text.Encoding get_Encoding();
            /*0xd34388*/ bool get_HasDtdInfo();
        }

        class XmlRawWriter : System.Xml.XmlWriter
        {
            /*0x18*/ System.Xml.XmlRawWriterBase64Encoder base64Encoder;
            /*0x20*/ System.Xml.IXmlNamespaceResolver resolver;

            /*0xd2b24c*/ XmlRawWriter();
            /*0xd34424*/ void WriteStartDocument();
            /*0xd34484*/ void WriteStartDocument(bool standalone);
            /*0xd344e4*/ void WriteEndDocument();
            /*0xd34544*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0xd34548*/ void WriteEndElement();
            /*0xd345a8*/ void WriteFullEndElement();
            /*0xd336dc*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0xd34608*/ string LookupPrefix(string ns);
            /*0xd34668*/ System.Xml.WriteState get_WriteState();
            /*0xd346c8*/ void WriteCData(string text);
            /*0xd346d8*/ void WriteCharEntity(char ch);
            /*0xd3476c*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0xd34810*/ void WriteWhitespace(string ws);
            /*0xd34820*/ void WriteChars(char[] buffer, int index, int count);
            /*0xd34850*/ void WriteRaw(char[] buffer, int index, int count);
            /*0xd34880*/ void WriteRaw(string data);
            /*0xd34890*/ void WriteValue(string value);
            /*0xd348a0*/ void WriteAttributes(System.Xml.XmlReader reader, bool defattr);
            /*0xd34900*/ void WriteNode(System.Xml.XmlReader reader, bool defattr);
            /*0xd34960*/ void set_NamespaceResolver(System.Xml.IXmlNamespaceResolver value);
            /*0xd34968*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0xd3496c*/ void WriteXmlDeclaration(string xmldecl);
            void StartElementContent();
            /*0xd34970*/ void OnRootElement(System.Xml.ConformanceLevel conformanceLevel);
            void WriteEndElement(string prefix, string localName, string ns);
            /*0xd34974*/ void WriteFullEndElement(string prefix, string localName, string ns);
            void WriteNamespaceDeclaration(string prefix, string ns);
            /*0xd34984*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0xd3498c*/ void WriteStartNamespaceDeclaration(string prefix);
            /*0xd349cc*/ void WriteEndNamespaceDeclaration();
            /*0xd34a0c*/ void WriteEndBase64();
            /*0xd34a28*/ void Close(System.Xml.WriteState currentState);
        }

        class XmlReader : System.IDisposable
        {
            static /*0x0*/ uint IsTextualNodeBitmap;
            static /*0x4*/ uint CanReadContentAsBitmap;
            static /*0x8*/ uint HasValueBitmap;

            static /*0xd36a54*/ XmlReader();
            static /*0xd35058*/ bool IsTextualNode(System.Xml.XmlNodeType nodeType);
            static /*0xd36038*/ bool HasValueInternal(System.Xml.XmlNodeType nodeType);
            static /*0xd36190*/ System.Xml.XmlReader Create(System.IO.Stream input, System.Xml.XmlReaderSettings settings, string baseUri);
            static /*0xd363d8*/ System.Xml.XmlReader Create(System.IO.TextReader input, System.Xml.XmlReaderSettings settings, string baseUri);
            static /*0xd36590*/ System.Xml.XmlReader CreateSqlReader(System.IO.Stream input, System.Xml.XmlReaderSettings settings, System.Xml.XmlParserContext inputContext);
            static /*0xd368c8*/ int CalcBufferSize(System.IO.Stream input);
            /*0xd2cf20*/ XmlReader();
            /*0xd34a38*/ System.Xml.XmlReaderSettings get_Settings();
            System.Xml.XmlNodeType get_NodeType();
            /*0xd34a40*/ string get_Name();
            string get_LocalName();
            string get_NamespaceURI();
            string get_Prefix();
            string get_Value();
            int get_Depth();
            string get_BaseURI();
            bool get_IsEmptyElement();
            /*0xd34b24*/ bool get_IsDefault();
            /*0xd34b2c*/ char get_QuoteChar();
            /*0xd34b34*/ System.Xml.XmlSpace get_XmlSpace();
            /*0xd34b3c*/ string get_XmlLang();
            /*0xd34b84*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0xd34bcc*/ System.Type get_ValueType();
            int get_AttributeCount();
            string GetAttribute(string name);
            string GetAttribute(string name, string namespaceURI);
            string GetAttribute(int i);
            bool MoveToAttribute(string name);
            /*0xd34c38*/ void MoveToAttribute(int i);
            bool MoveToFirstAttribute();
            bool MoveToNextAttribute();
            bool MoveToElement();
            bool ReadAttributeValue();
            bool Read();
            bool get_EOF();
            /*0xd34d08*/ void Close();
            System.Xml.ReadState get_ReadState();
            /*0xd34d0c*/ void Skip();
            System.Xml.XmlNameTable get_NameTable();
            string LookupNamespace(string prefix);
            /*0xd34e14*/ bool get_CanResolveEntity();
            void ResolveEntity();
            /*0xd34e1c*/ bool get_CanReadValueChunk();
            /*0xd34e24*/ int ReadValueChunk(char[] buffer, int index, int count);
            /*0xd34e84*/ string ReadString();
            /*0xd350c8*/ System.Xml.XmlNodeType MoveToContent();
            /*0xd3514c*/ void ReadStartElement();
            /*0xd35244*/ string ReadElementString();
            /*0xd354ec*/ void ReadEndElement();
            /*0xd355e4*/ bool IsStartElement(string localname, string ns);
            /*0xd35668*/ string ReadInnerXml();
            /*0xd35a74*/ void WriteNode(System.Xml.XmlWriter xtw, bool defattr);
            /*0xd359a0*/ void WriteAttributeValue(System.Xml.XmlWriter xtw);
            /*0xd35924*/ System.Xml.XmlWriter CreateWriterForInnerOuterXml(System.IO.StringWriter sw);
            /*0xd35ebc*/ void SetNamespacesFlag(System.Xml.XmlTextWriter xtw);
            /*0xd35fc8*/ bool get_HasAttributes();
            /*0xd2d988*/ void Dispose();
            /*0xd35fec*/ void Dispose(bool disposing);
            /*0xd36030*/ System.Xml.XmlNamespaceManager get_NamespaceManager();
            /*0xd34d40*/ bool SkipSubtree();
            /*0xd360a8*/ bool get_IsDefaultInternal();
            /*0xd36188*/ System.Xml.IDtdInfo get_DtdInfo();
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

            static /*0xd374d0*/ System.Xml.XmlResolver CreateDefaultResolver();
            static /*0xd3752c*/ bool EnableLegacyXmlSettings();
            /*0xd2d0c0*/ XmlReaderSettings();
            /*0xd36ab8*/ bool get_Async();
            /*0xd2d0e0*/ void set_Async(bool value);
            /*0xd36b78*/ System.Xml.XmlNameTable get_NameTable();
            /*0xd36b80*/ void set_NameTable(System.Xml.XmlNameTable value);
            /*0xd36bdc*/ bool get_IsXmlResolverSet();
            /*0xd36be4*/ void set_IsXmlResolverSet(bool value);
            /*0xd36bf0*/ void set_XmlResolver(System.Xml.XmlResolver value);
            /*0xd36c54*/ System.Xml.XmlResolver GetXmlResolver();
            /*0xd36c5c*/ System.Xml.XmlResolver GetXmlResolver_CheckConfig();
            /*0xd36c8c*/ int get_LineNumberOffset();
            /*0xd36c94*/ void set_LineNumberOffset(int value);
            /*0xd36cf0*/ int get_LinePositionOffset();
            /*0xd36cf8*/ void set_LinePositionOffset(int value);
            /*0xd36d54*/ System.Xml.ConformanceLevel get_ConformanceLevel();
            /*0xd36d5c*/ void set_ConformanceLevel(System.Xml.ConformanceLevel value);
            /*0xd36e0c*/ bool get_CheckCharacters();
            /*0xd36e14*/ void set_CheckCharacters(bool value);
            /*0xd36e70*/ long get_MaxCharactersInDocument();
            /*0xd36e78*/ void set_MaxCharactersInDocument(long value);
            /*0xd36f24*/ long get_MaxCharactersFromEntities();
            /*0xd36f2c*/ void set_MaxCharactersFromEntities(long value);
            /*0xd36fd8*/ bool get_IgnoreWhitespace();
            /*0xd36fe0*/ void set_IgnoreWhitespace(bool value);
            /*0xd3703c*/ bool get_IgnoreProcessingInstructions();
            /*0xd37044*/ void set_IgnoreProcessingInstructions(bool value);
            /*0xd370a0*/ bool get_IgnoreComments();
            /*0xd370a8*/ void set_IgnoreComments(bool value);
            /*0xd37104*/ System.Xml.DtdProcessing get_DtdProcessing();
            /*0xd3710c*/ void set_DtdProcessing(System.Xml.DtdProcessing value);
            /*0xd371bc*/ bool get_CloseInput();
            /*0xd371c4*/ void set_CloseInput(bool value);
            /*0xd37220*/ System.Xml.ValidationType get_ValidationType();
            /*0xd37228*/ void set_ValidationType(System.Xml.ValidationType value);
            /*0xd372d8*/ System.Xml.Schema.XmlSchemaValidationFlags get_ValidationFlags();
            /*0xd372e0*/ void set_ValidationFlags(System.Xml.Schema.XmlSchemaValidationFlags value);
            /*0xd37390*/ System.Xml.Schema.XmlSchemaSet get_Schemas();
            /*0xd373fc*/ void set_Schemas(System.Xml.Schema.XmlSchemaSet value);
            /*0xd2d058*/ System.Xml.XmlReaderSettings Clone();
            /*0xd37458*/ System.Xml.Schema.ValidationEventHandler GetEventHandler();
            /*0xd36220*/ System.Xml.XmlReader CreateReader(System.IO.Stream input, System.Uri baseUri, string baseUriString, System.Xml.XmlParserContext inputContext);
            /*0xd36464*/ System.Xml.XmlReader CreateReader(System.IO.TextReader input, string baseUriString, System.Xml.XmlParserContext inputContext);
            /*0xd37460*/ void set_ReadOnly(bool value);
            /*0xd36ac0*/ void CheckReadOnly(string propertyName);
            /*0xd36ab0*/ void Initialize();
            /*0xd3746c*/ void Initialize(System.Xml.XmlResolver resolver);
            /*0xd3694c*/ System.Xml.XmlReader AddValidation(System.Xml.XmlReader reader);
            /*0xd3762c*/ System.Xml.XmlValidatingReaderImpl CreateDtdValidatingReader(System.Xml.XmlReader baseReader);
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

            /*0xd376ac*/ XmlTextEncoder(System.IO.TextWriter textWriter);
            /*0xd376e8*/ void set_QuoteChar(char value);
            /*0xd376f0*/ void StartAttribute(bool cacheAttrValue);
            /*0xd37790*/ void EndAttribute();
            /*0xd377c8*/ string get_AttributeValue();
            /*0xd3783c*/ void WriteSurrogateChar(char lowChar, char highChar);
            /*0xd378f0*/ void Write(char[] array, int offset, int count);
            /*0xd37e08*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0xd37f98*/ void Write(string text);
            /*0xd38474*/ void WriteRawWithSurrogateChecking(string text);
            /*0xd3866c*/ void WriteRaw(char[] array, int offset, int count);
            /*0xd387a4*/ void WriteCharEntity(char ch);
            /*0xd38984*/ void WriteEntityRef(string name);
            /*0xd383cc*/ void WriteStringFragment(string str, int offset, int count, char[] helperBuffer);
            /*0xd37d1c*/ void WriteCharEntityImpl(char ch);
            /*0xd388ec*/ void WriteCharEntityImpl(string strVal);
            /*0xd37d98*/ void WriteEntityRefImpl(string name);
        }

        class XmlTextReader : System.Xml.XmlReader, System.Xml.IXmlLineInfo, System.Xml.IXmlNamespaceResolver
        {
            /*0x10*/ System.Xml.XmlTextReaderImpl impl;

            /*0xd389f0*/ XmlTextReader(System.IO.Stream input);
            /*0xd38a94*/ XmlTextReader(string url, System.IO.Stream input, System.Xml.XmlNameTable nt);
            /*0xd38b50*/ XmlTextReader(System.IO.TextReader input);
            /*0xd38bf4*/ XmlTextReader(System.IO.TextReader input, System.Xml.XmlNameTable nt);
            /*0xd38ca0*/ System.Xml.XmlNodeType get_NodeType();
            /*0xd38cc0*/ string get_Name();
            /*0xd38ce0*/ string get_LocalName();
            /*0xd38d00*/ string get_NamespaceURI();
            /*0xd38d20*/ string get_Prefix();
            /*0xd38d40*/ string get_Value();
            /*0xd38d60*/ int get_Depth();
            /*0xd38d80*/ string get_BaseURI();
            /*0xd38da4*/ bool get_IsEmptyElement();
            /*0xd38dc8*/ bool get_IsDefault();
            /*0xd38dec*/ char get_QuoteChar();
            /*0xd38e10*/ System.Xml.XmlSpace get_XmlSpace();
            /*0xd38e34*/ string get_XmlLang();
            /*0xd38e58*/ int get_AttributeCount();
            /*0xd38e7c*/ string GetAttribute(string name);
            /*0xd38ea0*/ string GetAttribute(string localName, string namespaceURI);
            /*0xd38ec4*/ string GetAttribute(int i);
            /*0xd38ee8*/ bool MoveToAttribute(string name);
            /*0xd38f0c*/ void MoveToAttribute(int i);
            /*0xd38f30*/ bool MoveToFirstAttribute();
            /*0xd38f54*/ bool MoveToNextAttribute();
            /*0xd38f78*/ bool MoveToElement();
            /*0xd38f9c*/ bool ReadAttributeValue();
            /*0xd38fc0*/ bool Read();
            /*0xd38fe4*/ bool get_EOF();
            /*0xd39008*/ void Close();
            /*0xd3902c*/ System.Xml.ReadState get_ReadState();
            /*0xd39050*/ void Skip();
            /*0xd39074*/ System.Xml.XmlNameTable get_NameTable();
            /*0xd39098*/ string LookupNamespace(string prefix);
            /*0xd390d0*/ bool get_CanResolveEntity();
            /*0xd390d8*/ void ResolveEntity();
            /*0xd390fc*/ bool get_CanReadValueChunk();
            /*0xd39104*/ string ReadString();
            /*0xd3912c*/ bool HasLineInfo();
            /*0xd39134*/ int get_LineNumber();
            /*0xd39150*/ int get_LinePosition();
            /*0xd3916c*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0xd39188*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0xd391ac*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            /*0xd35fac*/ bool get_Namespaces();
            /*0xd391c8*/ bool get_Normalization();
            /*0xd391e4*/ void set_Normalization(bool value);
            /*0xd39204*/ void set_WhitespaceHandling(System.Xml.WhitespaceHandling value);
            /*0xd39220*/ void set_EntityHandling(System.Xml.EntityHandling value);
            /*0xd3923c*/ void set_XmlResolver(System.Xml.XmlResolver value);
            /*0xd39258*/ System.Xml.XmlTextReaderImpl get_Impl();
            /*0xd39260*/ System.Xml.XmlNamespaceManager get_NamespaceManager();
            /*0xd39284*/ void set_XmlValidatingReaderCompatibilityMode(bool value);
            /*0xd392a4*/ System.Xml.IDtdInfo get_DtdInfo();
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

            static /*0xe94e1c*/ string StripSpaces(string value);
            static /*0xe95044*/ void StripSpaces(char[] value, int index, ref int len);
            static /*0xe889fc*/ void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count);
            static /*0xe8c800*/ void BlockCopy(byte[] src, int srcOffset, byte[] dst, int dstOffset, int count);
            /*0xe820e8*/ XmlTextReaderImpl(System.Xml.XmlNameTable nt);
            /*0xe8245c*/ XmlTextReaderImpl(System.Xml.XmlResolver resolver, System.Xml.XmlReaderSettings settings, System.Xml.XmlParserContext context);
            /*0xe82b08*/ XmlTextReaderImpl(System.IO.Stream input);
            /*0xe82ba0*/ XmlTextReaderImpl(string url, System.IO.Stream input, System.Xml.XmlNameTable nt);
            /*0xe82d08*/ XmlTextReaderImpl(System.IO.TextReader input);
            /*0xe82e70*/ XmlTextReaderImpl(System.IO.TextReader input, System.Xml.XmlNameTable nt);
            /*0xe82da0*/ XmlTextReaderImpl(string url, System.IO.TextReader input, System.Xml.XmlNameTable nt);
            /*0xe82ee4*/ XmlTextReaderImpl(string xmlFragment, System.Xml.XmlNodeType fragType, System.Xml.XmlParserContext context);
            /*0xe832a8*/ XmlTextReaderImpl(string xmlFragment, System.Xml.XmlParserContext context);
            /*0xe839a4*/ XmlTextReaderImpl(System.IO.Stream stream, byte[] bytes, int byteCount, System.Xml.XmlReaderSettings settings, System.Uri baseUri, string baseUriStr, System.Xml.XmlParserContext context, bool closeInput);
            /*0xe83cc4*/ XmlTextReaderImpl(System.IO.TextReader input, System.Xml.XmlReaderSettings settings, string baseUriStr, System.Xml.XmlParserContext context);
            /*0xe83e10*/ XmlTextReaderImpl(string xmlFragment, System.Xml.XmlParserContext context, System.Xml.XmlReaderSettings settings);
            /*0xe833e0*/ void FinishInitUriString();
            /*0xe83c44*/ void FinishInitStream();
            /*0xe83dac*/ void FinishInitTextReader();
            /*0xe83eb4*/ System.Xml.XmlReaderSettings get_Settings();
            /*0xe8400c*/ System.Xml.XmlNodeType get_NodeType();
            /*0xe84028*/ string get_Name();
            /*0xe8404c*/ string get_LocalName();
            /*0xe84068*/ string get_NamespaceURI();
            /*0xe84084*/ string get_Prefix();
            /*0xe840a0*/ string get_Value();
            /*0xe842b4*/ int get_Depth();
            /*0xe842d0*/ string get_BaseURI();
            /*0xe842d8*/ bool get_IsEmptyElement();
            /*0xe842f4*/ bool get_IsDefault();
            /*0xe84310*/ char get_QuoteChar();
            /*0xe84340*/ System.Xml.XmlSpace get_XmlSpace();
            /*0xe8435c*/ string get_XmlLang();
            /*0xe84378*/ System.Xml.ReadState get_ReadState();
            /*0xe84380*/ bool get_EOF();
            /*0xe84390*/ System.Xml.XmlNameTable get_NameTable();
            /*0xe84398*/ bool get_CanResolveEntity();
            /*0xe843a0*/ int get_AttributeCount();
            /*0xe843a8*/ string GetAttribute(string name);
            /*0xe845d8*/ string GetAttribute(string localName, string namespaceURI);
            /*0xe84754*/ string GetAttribute(int i);
            /*0xe847f4*/ bool MoveToAttribute(string name);
            /*0xe8497c*/ void MoveToAttribute(int i);
            /*0xe84a48*/ bool MoveToFirstAttribute();
            /*0xe84abc*/ bool MoveToNextAttribute();
            /*0xe84b44*/ bool MoveToElement();
            /*0xe84bcc*/ void FinishInit();
            /*0xe84c14*/ bool Read();
            /*0xe86d94*/ void Close();
            /*0xe86e58*/ void Skip();
            /*0xe86fd8*/ string LookupNamespace(string prefix);
            /*0xe87010*/ bool ReadAttributeValue();
            /*0xe876f0*/ void ResolveEntity();
            /*0xe87de8*/ void set_OuterReader(System.Xml.XmlReader value);
            /*0xe87df0*/ void MoveOffEntityReference();
            /*0xe87ea8*/ string ReadString();
            /*0xe87ec4*/ bool get_CanReadValueChunk();
            /*0xe87ecc*/ int ReadValueChunk(char[] buffer, int index, int count);
            /*0xe88a10*/ bool HasLineInfo();
            /*0xe88a18*/ int get_LineNumber();
            /*0xe88a34*/ int get_LinePosition();
            /*0xe88a50*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0xe88a98*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0xe88aa8*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            /*0xe88a74*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0xe88acc*/ string LookupPrefix(string namespaceName);
            /*0xe88af0*/ bool get_Namespaces();
            /*0xe88af8*/ void set_Namespaces(bool value);
            /*0xe88cc8*/ bool get_Normalization();
            /*0xe88cd0*/ void set_Normalization(bool value);
            /*0xe88df4*/ void set_WhitespaceHandling(System.Xml.WhitespaceHandling value);
            /*0xe88ec8*/ void set_EntityHandling(System.Xml.EntityHandling value);
            /*0xe88f50*/ bool get_IsResolverSet();
            /*0xe88f58*/ void set_XmlResolver(System.Xml.XmlResolver value);
            /*0xe88fb4*/ System.Xml.XmlNameTable get_DtdParserProxy_NameTable();
            /*0xe88fbc*/ System.Xml.IXmlNamespaceResolver get_DtdParserProxy_NamespaceResolver();
            /*0xe88fc4*/ bool get_DtdParserProxy_DtdValidation();
            /*0xe88fe4*/ bool get_DtdParserProxy_Normalization();
            /*0xe88fec*/ bool get_DtdParserProxy_Namespaces();
            /*0xe88ff4*/ bool get_DtdParserProxy_V1CompatibilityMode();
            /*0xe88ffc*/ System.Uri get_DtdParserProxy_BaseUri();
            /*0xe890a0*/ bool get_DtdParserProxy_IsEof();
            /*0xe890a8*/ char[] get_DtdParserProxy_ParsingBuffer();
            /*0xe890b0*/ int get_DtdParserProxy_ParsingBufferLength();
            /*0xe890b8*/ int get_DtdParserProxy_CurrentPosition();
            /*0xe890c0*/ void set_DtdParserProxy_CurrentPosition(int value);
            /*0xe890c8*/ int get_DtdParserProxy_EntityStackLength();
            /*0xe890d4*/ bool get_DtdParserProxy_IsEntityEolNormalized();
            /*0xe890dc*/ System.Xml.IValidationEventHandling get_DtdParserProxy_ValidationEventHandling();
            /*0xe890e4*/ void DtdParserProxy_OnNewLine(int pos);
            /*0xe8910c*/ int get_DtdParserProxy_LineNo();
            /*0xe89114*/ int get_DtdParserProxy_LineStartPosition();
            /*0xe8911c*/ int DtdParserProxy_ReadData();
            /*0xe89550*/ int DtdParserProxy_ParseNumericCharRef(System.Text.StringBuilder internalSubsetBuilder);
            /*0xe8961c*/ int DtdParserProxy_ParseNamedCharRef(bool expand, System.Text.StringBuilder internalSubsetBuilder);
            /*0xe89688*/ void DtdParserProxy_ParsePI(System.Text.StringBuilder sb);
            /*0xe89a3c*/ void DtdParserProxy_ParseComment(System.Text.StringBuilder sb);
            /*0xe89dc4*/ bool get_IsResolverNull();
            /*0xe89e04*/ System.Xml.XmlResolver GetTempResolver();
            /*0xe89e6c*/ bool DtdParserProxy_PushEntity(System.Xml.IDtdEntityInfo entity, ref int entityId);
            /*0xe8a628*/ bool DtdParserProxy_PopEntity(ref System.Xml.IDtdEntityInfo oldEntity, ref int newEntityId);
            /*0xe8a6c0*/ bool DtdParserProxy_PushExternalSubset(string systemId, string publicId);
            /*0xe8ae08*/ void DtdParserProxy_PushInternalDtd(string baseUri, string internalDtd);
            /*0xe8b068*/ void DtdParserProxy_Throw(System.Exception e);
            /*0xe8b100*/ void DtdParserProxy_OnSystemId(string systemId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo systemLiteralLineInfo);
            /*0xe8b208*/ void DtdParserProxy_OnPublicId(string publicId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo publicLiteralLineInfo);
            /*0xe8b294*/ void Throw(int pos, string res, string arg);
            /*0xe8b344*/ void Throw(int pos, string res, string[] args);
            /*0xe8b3f4*/ void Throw(int pos, string res);
            /*0xe83bf0*/ void Throw(string res);
            /*0xe8b450*/ void Throw(string res, int lineNo, int linePos);
            /*0xe8b2a8*/ void Throw(string res, string arg);
            /*0xe8b4f8*/ void Throw(string res, string arg, int lineNo, int linePos);
            /*0xe8b358*/ void Throw(string res, string[] args);
            /*0xe8b584*/ void Throw(string res, string arg, System.Exception innerException);
            /*0xe8b610*/ void Throw(string res, string[] args, System.Exception innerException);
            /*0xe8b070*/ void Throw(System.Exception e);
            /*0xe8b6cc*/ void ReThrow(System.Exception e, int lineNo, int linePos);
            /*0xe86b80*/ void ThrowWithoutLineInfo(string res);
            /*0xe8b774*/ void ThrowWithoutLineInfo(string res, string arg);
            /*0xe8b7ec*/ void ThrowWithoutLineInfo(string res, string[] args, System.Exception innerException);
            /*0xe8b878*/ void ThrowInvalidChar(char[] data, int length, int invCharPos);
            /*0xe8b6b8*/ void SetErrorState();
            /*0xe89d18*/ void SendValidationEvent(System.Xml.Schema.XmlSeverityType severity, string code, string arg, int lineNo, int linePos);
            /*0xe8b8e8*/ void SendValidationEvent(System.Xml.Schema.XmlSeverityType severity, System.Xml.Schema.XmlSchemaException exception);
            /*0xe848b4*/ bool get_InAttributeValueIterator();
            /*0xe848d8*/ void FinishAttributeValueIterator();
            /*0xe88fd4*/ bool get_DtdValidation();
            /*0xe82c78*/ void InitStreamInput(System.IO.Stream stream, System.Text.Encoding encoding);
            /*0xe82cec*/ void InitStreamInput(string baseUriStr, System.IO.Stream stream, System.Text.Encoding encoding);
            /*0xe8bad8*/ void InitStreamInput(System.Uri baseUri, System.IO.Stream stream, System.Text.Encoding encoding);
            /*0xe8bb38*/ void InitStreamInput(System.Uri baseUri, string baseUriStr, System.IO.Stream stream, System.Text.Encoding encoding);
            /*0xe836cc*/ void InitStreamInput(System.Uri baseUri, string baseUriStr, System.IO.Stream stream, byte[] bytes, int byteCount, System.Text.Encoding encoding);
            /*0xe82ed8*/ void InitTextReaderInput(string baseUriStr, System.IO.TextReader input);
            /*0xe8bebc*/ void InitTextReaderInput(string baseUriStr, System.Uri baseUri, System.IO.TextReader input);
            /*0xe82ff0*/ void InitStringInput(string baseUriStr, System.Text.Encoding originalEncoding, string str);
            /*0xe830bc*/ void InitFragmentReader(System.Xml.XmlNodeType fragmentType, System.Xml.XmlParserContext parserContext, bool allowXmlDeclFragment);
            /*0xe83938*/ void ProcessDtdFromParserContext(System.Xml.XmlParserContext context);
            /*0xe857e8*/ void OpenUrl();
            /*0xe8c194*/ void OpenUrlDelegate(object xmlResolver);
            /*0xe8bb48*/ System.Text.Encoding DetectEncoding();
            /*0xe8bd74*/ void SetupEncoding(System.Text.Encoding encoding);
            /*0xe8c2b8*/ void SwitchEncoding(System.Text.Encoding newEncoding);
            /*0xe8c454*/ System.Text.Encoding CheckEncoding(string newEncodingName);
            /*0xe8c3a8*/ void UnDecodeChars();
            /*0xe8c794*/ void SwitchEncodingToUTF8();
            /*0xe89120*/ int ReadData();
            /*0xe8c808*/ int GetChars(int maxCharsCount);
            /*0xe8c920*/ void InvalidCharRecovery(ref int bytesCount, ref int charsCount);
            /*0xe86d9c*/ void Close(bool closeInput);
            /*0xe8cb08*/ void ShiftBuffer(int sourcePos, int destPos, int count);
            /*0xe85974*/ bool ParseXmlDeclaration(bool isTextDecl);
            /*0xe852f8*/ bool ParseDocumentContent();
            /*0xe84fc0*/ bool ParseElementContent();
            /*0xe8e094*/ void ThrowUnclosedElements();
            /*0xe8cfec*/ void ParseElement();
            /*0xe8e87c*/ void AddDefaultAttributesAndNormalize();
            /*0xe8dca8*/ void ParseEndElement();
            /*0xe8f9e8*/ void ThrowTagMismatch(System.Xml.XmlTextReaderImpl.NodeData startTag);
            /*0xe8e240*/ void ParseAttributes();
            /*0xe8f290*/ void ElementNamespaceLookup();
            /*0xe8f944*/ void AttributeNamespaceLookup();
            /*0xe90b14*/ void AttributeDuplCheck();
            /*0xe90750*/ void OnDefaultNamespaceDecl(System.Xml.XmlTextReaderImpl.NodeData attr);
            /*0xe9084c*/ void OnNamespaceDecl(System.Xml.XmlTextReaderImpl.NodeData attr);
            /*0xe90928*/ void OnXmlReservedAttribute(System.Xml.XmlTextReaderImpl.NodeData attr);
            /*0xe8fe08*/ void ParseAttributeValueSlow(int curPos, char quoteChar, System.Xml.XmlTextReaderImpl.NodeData attr);
            /*0xe91220*/ void AddAttributeChunkToList(System.Xml.XmlTextReaderImpl.NodeData attr, System.Xml.XmlTextReaderImpl.NodeData chunk, ref System.Xml.XmlTextReaderImpl.NodeData lastChunk);
            /*0xe8d738*/ bool ParseText();
            /*0xe88330*/ bool ParseText(ref int startPos, ref int endPos, ref int outOrChars);
            /*0xe840e8*/ void FinishPartialValue();
            /*0xe841a4*/ void FinishOtherValueIterator();
            /*0xe86c14*/ void SkipPartialTextValue();
            /*0xe86c54*/ void FinishReadValueChunk();
            /*0xe86c74*/ void FinishReadContentAsBinary();
            /*0xe86cc4*/ void FinishReadElementContentAsBinary();
            /*0xe8daac*/ bool ParseRootLevelWhitespace();
            /*0xe867a4*/ void ParseEntityReference();
            /*0xe8d48c*/ System.Xml.XmlTextReaderImpl.EntityType HandleEntityReference(bool isInAttributeValue, System.Xml.XmlTextReaderImpl.EntityExpandType expandType, ref int charRefEndPos);
            /*0xe87944*/ System.Xml.XmlTextReaderImpl.EntityType HandleGeneralEntityReference(string name, bool isInAttributeValue, bool pushFakeEntityIfNullResolver, int entityStartLinePos);
            /*0xe8c784*/ bool get_InEntity();
            /*0xe8b9b0*/ bool HandleEntityEnd(bool checkEntityNesting);
            /*0xe86818*/ void SetupEndEntityNodeInContent();
            /*0xe915bc*/ void SetupEndEntityNodeInAttribute();
            /*0xe8ccd8*/ bool ParsePI();
            /*0xe896cc*/ bool ParsePI(System.Text.StringBuilder piInDtdStringBuilder);
            /*0xe91624*/ bool ParsePIValue(ref int outStartPos, ref int outEndPos);
            /*0xe8cce0*/ bool ParseComment();
            /*0xe8cd44*/ void ParseCData();
            /*0xe89bc0*/ void ParseCDataOrComment(System.Xml.XmlNodeType type);
            /*0xe919b8*/ bool ParseCDataOrComment(System.Xml.XmlNodeType type, ref int outStartPos, ref int outEndPos);
            /*0xe8cd4c*/ bool ParseDoctypeDecl();
            /*0xe91df4*/ void ParseDtd();
            /*0xe92110*/ void SkipDtd();
            /*0xe92468*/ void SkipPublicOrSystemIdLiteral();
            /*0xe92520*/ void SkipUntil(char stopChar, bool recognizeLiterals);
            /*0xe8abb4*/ int EatWhitespaces(System.Text.StringBuilder sb);
            /*0xe913e4*/ int ParseCharRefInline(int startPos, ref int charCount, ref System.Xml.XmlTextReaderImpl.EntityType entityType);
            /*0xe89570*/ int ParseNumericCharRef(bool expand, System.Text.StringBuilder internalSubsetBuilder, ref System.Xml.XmlTextReaderImpl.EntityType entityType);
            /*0xe9295c*/ int ParseNumericCharRefInline(int startPos, bool expand, System.Text.StringBuilder internalSubsetBuilder, ref int charCount, ref System.Xml.XmlTextReaderImpl.EntityType entityType);
            /*0xe89624*/ int ParseNamedCharRef(bool expand, System.Text.StringBuilder internalSubsetBuilder);
            /*0xe92fbc*/ int ParseNamedCharRefInline(int startPos, bool expand, System.Text.StringBuilder internalSubsetBuilder);
            /*0xe8cb30*/ int ParseName();
            /*0xe8e230*/ int ParseQName(ref int colonPos);
            /*0xe93298*/ int ParseQName(bool isQName, int startOffset, ref int colonPos);
            /*0xe93520*/ bool ReadDataInName(ref int pos);
            /*0xe91250*/ string ParseEntityName();
            /*0xe8671c*/ System.Xml.XmlTextReaderImpl.NodeData AddNode(int nodeIndex, int nodeDepth);
            /*0xe93560*/ System.Xml.XmlTextReaderImpl.NodeData AllocNode(int nodeIndex, int nodeDepth);
            /*0xe8b18c*/ System.Xml.XmlTextReaderImpl.NodeData AddAttributeNoChecks(string name, int attrDepth);
            /*0xe8fc64*/ System.Xml.XmlTextReaderImpl.NodeData AddAttribute(int endNamePos, int colonPos);
            /*0xe93698*/ System.Xml.XmlTextReaderImpl.NodeData AddAttribute(string localName, string prefix, string nameWPrefix);
            /*0xe86760*/ void PopElementContext();
            /*0xe890f8*/ void OnNewLine(int pos);
            /*0xe86af8*/ void OnEof();
            /*0xe90e88*/ string LookupNamespace(System.Xml.XmlTextReaderImpl.NodeData node);
            /*0xe90fc4*/ void AddNamespace(string prefix, string uri, System.Xml.XmlTextReaderImpl.NodeData attr);
            /*0xe866f0*/ void ResetAttributes();
            /*0xe937f8*/ void FullAttributeCleanup();
            /*0xe90f4c*/ void PushXmlContext();
            /*0xe937cc*/ void PopXmlContext();
            /*0xe91574*/ System.Xml.XmlNodeType GetWhitespaceType();
            /*0xe9138c*/ System.Xml.XmlNodeType GetTextNodeType(int orChars);
            /*0xe8a7e8*/ void PushExternalEntityOrSubset(string publicId, string systemId, System.Uri baseUri, string entityName);
            /*0xe9385c*/ bool OpenAndPush(System.Uri uri);
            /*0xe89f78*/ bool PushExternalEntity(System.Xml.IDtdEntityInfo entity);
            /*0xe8a308*/ void PushInternalEntity(System.Xml.IDtdEntityInfo entity);
            /*0xe8a674*/ void PopEntity();
            /*0xe93a90*/ void RegisterEntity(System.Xml.IDtdEntityInfo entity);
            /*0xe93c80*/ void UnregisterEntity();
            /*0xe8ae6c*/ void PushParsingState();
            /*0xe8ca9c*/ void PopParsingState();
            /*0xe93ce4*/ int IncrementalRead();
            /*0xe86950*/ void FinishIncrementalRead();
            /*0xe869bc*/ bool ParseFragmentAttribute();
            /*0xe8725c*/ bool ParseAttributeValueChunk();
            /*0xe86a3c*/ void ParseXmlDeclarationFragment();
            /*0xe8cd34*/ void ThrowUnexpectedToken(int pos, string expectedToken);
            /*0xe8cb28*/ void ThrowUnexpectedToken(string expectedToken1);
            /*0xe8cfdc*/ void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2);
            /*0xe8cb50*/ void ThrowUnexpectedToken(string expectedToken1, string expectedToken2);
            /*0xe8cfd4*/ string ParseUnexpectedToken(int pos);
            /*0xe94618*/ string ParseUnexpectedToken();
            /*0xe8fbe4*/ void ThrowExpectingWhitespace(int pos);
            /*0xe8443c*/ int GetIndexOfAttributeWithoutPrefix(string name);
            /*0xe84524*/ int GetIndexOfAttributeWithPrefix(string name);
            /*0xe91450*/ bool ZeroEndingStream(int pos);
            /*0xe8bf6c*/ void ParseDtdFromParserContext();
            /*0xe914cc*/ bool MoveToNextContentNode(bool moveIfOnContentNode);
            /*0xe828cc*/ void SetupFromParserContext(System.Xml.XmlParserContext context, System.Xml.XmlReaderSettings settings);
            /*0xe946e0*/ System.Xml.IDtdInfo get_DtdInfo();
            /*0xe946e8*/ void SetDtdInfo(System.Xml.IDtdInfo newDtdInfo);
            /*0xe9481c*/ void set_ValidationEventHandling(System.Xml.IValidationEventHandling value);
            /*0xe94824*/ void set_OnDefaultAttributeUse(System.Xml.XmlTextReaderImpl.OnDefaultAttributeUseDelegate value);
            /*0xe9482c*/ void set_XmlValidatingReaderCompatibilityMode(bool value);
            /*0xe94904*/ System.Xml.XmlNodeType get_FragmentType();
            /*0xe9490c*/ void ChangeCurrentNodeType(System.Xml.XmlNodeType newNodeType);
            /*0xe94928*/ System.Xml.XmlResolver GetResolver();
            /*0xe94960*/ void set_InternalSchemaType(object value);
            /*0xe9497c*/ object get_InternalTypedValue();
            /*0xe94998*/ void set_InternalTypedValue(object value);
            /*0xe949b4*/ bool get_StandAlone();
            /*0xe949bc*/ System.Xml.XmlNamespaceManager get_NamespaceManager();
            /*0xe949c4*/ bool get_V1Compat();
            /*0xe8f2d8*/ bool AddDefaultAttributeDtd(System.Xml.IDtdDefaultAttributeInfo defAttrInfo, bool definedInDtd, System.Xml.XmlTextReaderImpl.NodeData[] nameSortedNodeData);
            /*0xe94c10*/ bool AddDefaultAttributeNonDtd(System.Xml.Schema.SchemaAttDef attrDef);
            /*0xe949cc*/ System.Xml.XmlTextReaderImpl.NodeData AddDefaultAttributeInternal(string localName, string ns, string prefix, string value, int lineNo, int linePos, int valueLineNo, int valueLinePos, bool isXmlAttribute);
            /*0xe94e10*/ void set_DisableUndeclaredEntityCheck(bool value);
            /*0xe83b0c*/ bool UriEqual(System.Uri uri1, string uri1Str, string uri2Str, System.Xml.XmlResolver resolver);
            /*0xe8af8c*/ void RegisterConsumedCharacters(long characters, bool inEntityReference);

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

                /*0xd392c8*/ LaterInitParam();
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

                /*0xd392d8*/ void Clear();
                /*0xd39354*/ void Close(bool closeInput);
                /*0xd3938c*/ int get_LineNo();
                /*0xd39394*/ int get_LinePos();
            }

            class XmlContext
            {
                /*0x10*/ System.Xml.XmlSpace xmlSpace;
                /*0x18*/ string xmlLang;
                /*0x20*/ string defaultNamespace;
                /*0x28*/ System.Xml.XmlTextReaderImpl.XmlContext previousContext;

                /*0xd393a4*/ XmlContext();
                /*0xd39408*/ XmlContext(System.Xml.XmlTextReaderImpl.XmlContext previousContext);
            }

            class NoNamespaceManager : System.Xml.XmlNamespaceManager
            {
                /*0xd39448*/ NoNamespaceManager();
                /*0xd39450*/ string get_DefaultNamespace();
                /*0xd39498*/ void PushScope();
                /*0xd3949c*/ bool PopScope();
                /*0xd394a4*/ void AddNamespace(string prefix, string uri);
                /*0xd394a8*/ void RemoveNamespace(string prefix, string uri);
                /*0xd394ac*/ System.Collections.IEnumerator GetEnumerator();
                /*0xd394b4*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
                /*0xd394bc*/ string LookupNamespace(string prefix);
                /*0xd39504*/ string LookupPrefix(string uri);
            }

            class DtdParserProxy : System.Xml.IDtdParserAdapterV1, System.Xml.IDtdParserAdapterWithValidation, System.Xml.IDtdParserAdapter
            {
                /*0x10*/ System.Xml.XmlTextReaderImpl reader;

                /*0xd3950c*/ DtdParserProxy(System.Xml.XmlTextReaderImpl reader);
                /*0xd39534*/ System.Xml.XmlNameTable System.Xml.IDtdParserAdapter.get_NameTable();
                /*0xd39550*/ System.Xml.IXmlNamespaceResolver System.Xml.IDtdParserAdapter.get_NamespaceResolver();
                /*0xd3956c*/ System.Uri System.Xml.IDtdParserAdapter.get_BaseUri();
                /*0xd39588*/ bool System.Xml.IDtdParserAdapter.get_IsEof();
                /*0xd395a4*/ char[] System.Xml.IDtdParserAdapter.get_ParsingBuffer();
                /*0xd395c0*/ int System.Xml.IDtdParserAdapter.get_ParsingBufferLength();
                /*0xd395dc*/ int System.Xml.IDtdParserAdapter.get_CurrentPosition();
                /*0xd395f8*/ void System.Xml.IDtdParserAdapter.set_CurrentPosition(int value);
                /*0xd39614*/ int System.Xml.IDtdParserAdapter.get_EntityStackLength();
                /*0xd39630*/ bool System.Xml.IDtdParserAdapter.get_IsEntityEolNormalized();
                /*0xd3964c*/ void System.Xml.IDtdParserAdapter.OnNewLine(int pos);
                /*0xd39668*/ int System.Xml.IDtdParserAdapter.get_LineNo();
                /*0xd39684*/ int System.Xml.IDtdParserAdapter.get_LineStartPosition();
                /*0xd396a0*/ int System.Xml.IDtdParserAdapter.ReadData();
                /*0xd396bc*/ int System.Xml.IDtdParserAdapter.ParseNumericCharRef(System.Text.StringBuilder internalSubsetBuilder);
                /*0xd396d8*/ int System.Xml.IDtdParserAdapter.ParseNamedCharRef(bool expand, System.Text.StringBuilder internalSubsetBuilder);
                /*0xd396f8*/ void System.Xml.IDtdParserAdapter.ParsePI(System.Text.StringBuilder sb);
                /*0xd39714*/ void System.Xml.IDtdParserAdapter.ParseComment(System.Text.StringBuilder sb);
                /*0xd39730*/ bool System.Xml.IDtdParserAdapter.PushEntity(System.Xml.IDtdEntityInfo entity, ref int entityId);
                /*0xd3974c*/ bool System.Xml.IDtdParserAdapter.PopEntity(ref System.Xml.IDtdEntityInfo oldEntity, ref int newEntityId);
                /*0xd39768*/ bool System.Xml.IDtdParserAdapter.PushExternalSubset(string systemId, string publicId);
                /*0xd39784*/ void System.Xml.IDtdParserAdapter.PushInternalDtd(string baseUri, string internalDtd);
                /*0xd397a0*/ void System.Xml.IDtdParserAdapter.Throw(System.Exception e);
                /*0xd397bc*/ void System.Xml.IDtdParserAdapter.OnSystemId(string systemId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo systemLiteralLineInfo);
                /*0xd397d8*/ void System.Xml.IDtdParserAdapter.OnPublicId(string publicId, System.Xml.LineInfo keywordLineInfo, System.Xml.LineInfo publicLiteralLineInfo);
                /*0xd397f4*/ bool System.Xml.IDtdParserAdapterWithValidation.get_DtdValidation();
                /*0xd39810*/ System.Xml.IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.get_ValidationEventHandling();
                /*0xd3982c*/ bool System.Xml.IDtdParserAdapterV1.get_Normalization();
                /*0xd39848*/ bool System.Xml.IDtdParserAdapterV1.get_Namespaces();
                /*0xd39864*/ bool System.Xml.IDtdParserAdapterV1.get_V1CompatibilityMode();
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

                static /*0xd39880*/ System.Xml.XmlTextReaderImpl.NodeData get_None();
                /*0xd39920*/ NodeData();
                /*0xd399d4*/ int get_LineNo();
                /*0xd399dc*/ int get_LinePos();
                /*0xd399e4*/ bool get_IsEmptyElement();
                /*0xd39a08*/ void set_IsEmptyElement(bool value);
                /*0xd39a14*/ bool get_IsDefaultAttribute();
                /*0xd39a38*/ void set_IsDefaultAttribute(bool value);
                /*0xd39a44*/ bool get_ValueBuffered();
                /*0xd39a54*/ string get_StringValue();
                /*0xd39a80*/ void TrimSpacesInValue();
                /*0xd39948*/ void Clear(System.Xml.XmlNodeType type);
                /*0xd39abc*/ void ClearName();
                /*0xd39b10*/ void SetLineInfo(int lineNo, int linePos);
                /*0xd39b1c*/ void SetLineInfo2(int lineNo, int linePos);
                /*0xd39b28*/ void SetValueNode(System.Xml.XmlNodeType type, string value);
                /*0xd39b98*/ void SetValueNode(System.Xml.XmlNodeType type, char[] chars, int startPos, int len);
                /*0xd39c14*/ void SetNamedNode(System.Xml.XmlNodeType type, string localName);
                /*0xd39cbc*/ void SetNamedNode(System.Xml.XmlNodeType type, string localName, string prefix, string nameWPrefix);
                /*0xd39d44*/ void SetValue(string value);
                /*0xd39d54*/ void SetValue(char[] chars, int startPos, int len);
                /*0xd39d60*/ void OnBufferInvalidated();
                /*0xd39d98*/ void CopyTo(int valueOffset, System.Text.StringBuilder sb);
                /*0xd39e18*/ int CopyTo(int valueOffset, char[] buffer, int offset, int length);
                /*0xd39e78*/ string GetNameWPrefix(System.Xml.XmlNameTable nt);
                /*0xd39e8c*/ string CreateNameWPrefix(System.Xml.XmlNameTable nt);
                /*0xd39f18*/ int System.IComparable.CompareTo(object obj);
            }

            class DtdDefaultAttributeInfoToNodeDataComparer : System.Collections.Generic.IComparer<object>
            {
                static /*0x0*/ System.Collections.Generic.IComparer<object> s_instance;

                static /*0xd19b50*/ DtdDefaultAttributeInfoToNodeDataComparer();
                static /*0xd197a8*/ System.Collections.Generic.IComparer<object> get_Instance();
                /*0xd19b48*/ DtdDefaultAttributeInfoToNodeDataComparer();
                /*0xd19800*/ int Compare(object x, object y);
            }

            class OnDefaultAttributeUseDelegate : System.MulticastDelegate
            {
                /*0xd19bb4*/ OnDefaultAttributeUseDelegate(object object, nint method);
                /*0xd19ce4*/ void Invoke(System.Xml.IDtdDefaultAttributeInfo defaultAttribute, System.Xml.XmlTextReaderImpl coreReader);
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

            static /*0xd1e60c*/ XmlTextWriter();
            /*0xd19cf8*/ XmlTextWriter();
            /*0xd19e88*/ XmlTextWriter(System.IO.Stream w, System.Text.Encoding encoding);
            /*0xd19f58*/ XmlTextWriter(string filename, System.Text.Encoding encoding);
            /*0xd19fe0*/ XmlTextWriter(System.IO.TextWriter w);
            /*0xd1a074*/ System.IO.Stream get_BaseStream();
            /*0xd1a110*/ void set_Namespaces(bool value);
            /*0xd1a18c*/ void set_Formatting(System.Xml.Formatting value);
            /*0xd1a1a0*/ void set_QuoteChar(char value);
            /*0xd1a234*/ void WriteStartDocument();
            /*0xd1a5b4*/ void WriteStartDocument(bool standalone);
            /*0xd1a5c8*/ void WriteEndDocument();
            /*0xd1a7ec*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0xd1b2a4*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0xd1bc98*/ void WriteEndElement();
            /*0xd1bf88*/ void WriteFullEndElement();
            /*0xd1bf90*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0xd1c894*/ void WriteEndAttribute();
            /*0xd1c934*/ void WriteCData(string text);
            /*0xd1cb04*/ void WriteComment(string text);
            /*0xd1cd10*/ void WriteProcessingInstruction(string name, string text);
            /*0xd1d054*/ void WriteEntityRef(string name);
            /*0xd1d120*/ void WriteCharEntity(char ch);
            /*0xd1d1e0*/ void WriteWhitespace(string ws);
            /*0xd1d358*/ void WriteString(string text);
            /*0xd1d424*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0xd1d4ec*/ void WriteChars(char[] buffer, int index, int count);
            /*0xd1d5c4*/ void WriteRaw(char[] buffer, int index, int count);
            /*0xd1d69c*/ void WriteRaw(string data);
            /*0xd1d75c*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0xd1d8a8*/ void WriteBinHex(byte[] buffer, int index, int count);
            /*0xd1d978*/ System.Xml.WriteState get_WriteState();
            /*0xd1d99c*/ void Close();
            /*0xd1dac4*/ void Flush();
            /*0xd1dae4*/ string LookupPrefix(string ns);
            /*0xd1a23c*/ void StartDocument(int standalone);
            /*0xd1ada0*/ void AutoComplete(System.Xml.XmlTextWriter.Token token);
            /*0xd1a798*/ void AutoCompleteAll();
            /*0xd1bca0*/ void InternalWriteEndElement(bool longFormat);
            /*0xd1dd08*/ void WriteEndStartTag(bool empty);
            /*0xd1dcbc*/ void WriteEndAttributeQuote();
            /*0xd1dbec*/ void Indent(bool beforeEndElement);
            /*0xd1b8fc*/ void PushNamespace(string prefix, string ns, bool declared);
            /*0xd1e36c*/ void AddNamespace(string prefix, string ns, bool declared);
            /*0xd1e524*/ void AddToNamespaceHashtable(int namespaceIndex);
            /*0xd1e080*/ void PopNamespaces(int indexFrom, int indexTo);
            /*0xd1c780*/ string GeneratePrefix();
            /*0xd1cf58*/ void InternalWriteProcessingInstruction(string name, string text);
            /*0xd1b758*/ int LookupNamespace(string prefix);
            /*0xd1c654*/ int LookupNamespaceInCurrentScope(string prefix);
            /*0xd1b834*/ string FindPrefix(string ns);
            /*0xd1abe0*/ void ValidateName(string name, bool isNCName);
            /*0xd1e154*/ void HandleSpecialAttribute();
            /*0xd1bb30*/ void VerifyPrefixXml(string prefix, string ns);
            /*0xd1b68c*/ void PushStack();
            /*0xd1e05c*/ void FlushEncoders();

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

                /*0xd19e1c*/ void Init(int nsTop);
            }

            struct Namespace
            {
                /*0x10*/ string prefix;
                /*0x18*/ string ns;
                /*0x20*/ bool declared;
                /*0x24*/ int prevNsIndex;

                /*0xd1e50c*/ void Set(string prefix, string ns, bool declared);
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

            static /*0xd21cc8*/ bool IsSurrogateByte(byte b);
            static /*0xd21818*/ byte* EncodeSurrogate(char* pSrc, char* pSrcEnd, byte* pDst);
            static /*0xd21a64*/ byte* EncodeMultibyteUTF8(int ch, byte* pDst);
            static /*0xd21e60*/ void CharToUTF8(ref char* pSrc, char* pSrcEnd, ref byte* pDst);
            static /*0xd21778*/ byte* LtEntity(byte* pDst);
            static /*0xd21788*/ byte* GtEntity(byte* pDst);
            static /*0xd21758*/ byte* AmpEntity(byte* pDst);
            static /*0xd21798*/ byte* QuoteEntity(byte* pDst);
            static /*0xd217b8*/ byte* TabEntity(byte* pDst);
            static /*0xd217f8*/ byte* LineFeedEntity(byte* pDst);
            static /*0xd217d8*/ byte* CarriageReturnEntity(byte* pDst);
            static /*0xd21cd8*/ byte* CharEntity(byte* pDst, char ch);
            static /*0xd21ca0*/ byte* RawStartCData(byte* pDst);
            static /*0xd21c84*/ byte* RawEndCData(byte* pDst);
            /*0xd1ed28*/ XmlUtf8RawTextWriter(System.Xml.XmlWriterSettings settings);
            /*0xd1f164*/ XmlUtf8RawTextWriter(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0xd1f2a8*/ void WriteXmlDeclaration(System.Xml.XmlStandalone standalone);
            /*0xd1f444*/ void WriteXmlDeclaration(string xmldecl);
            /*0xd1f4bc*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0xd1f6ac*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0xd1f750*/ void StartElementContent();
            /*0xd1f798*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0xd1f8f0*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0xd1f9e4*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0xd1faf0*/ void WriteEndAttribute();
            /*0xd1fb3c*/ void WriteNamespaceDeclaration(string prefix, string namespaceName);
            /*0xd1fb90*/ bool get_SupportsNamespaceDeclarationInChunks();
            /*0xd1fb98*/ void WriteStartNamespaceDeclaration(string prefix);
            /*0xd1fc8c*/ void WriteEndNamespaceDeclaration();
            /*0xd1fcd8*/ void WriteCData(string text);
            /*0xd20254*/ void WriteComment(string text);
            /*0xd206e0*/ void WriteProcessingInstruction(string name, string text);
            /*0xd20808*/ void WriteEntityRef(string name);
            /*0xd208a8*/ void WriteCharEntity(char ch);
            /*0xd20a74*/ void WriteWhitespace(string ws);
            /*0xd21078*/ void WriteString(string text);
            /*0xd210c8*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0xd21214*/ void WriteChars(char[] buffer, int index, int count);
            /*0xd21254*/ void WriteRaw(char[] buffer, int index, int count);
            /*0xd214e0*/ void WriteRaw(string data);
            /*0xd21528*/ void Close();
            /*0xd215a0*/ void Flush();
            /*0xd215dc*/ void FlushBuffer();
            /*0xd2159c*/ void FlushEncoder();
            /*0xd20ac4*/ void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd);
            /*0xd20db8*/ void WriteElementTextBlock(char* pSrc, char* pSrcEnd);
            /*0xd1f408*/ void RawText(string s);
            /*0xd21af8*/ void RawText(char* pSrcBegin, char* pSrcEnd);
            /*0xd21294*/ void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd);
            /*0xd203ac*/ void WriteCommentOrPi(string text, int stopChar);
            /*0xd1ff34*/ void WriteCDataSection(string text);
            /*0xd219b0*/ byte* InvalidXmlChar(int ch, byte* pDst, bool entitize);
            /*0xd21d84*/ void EncodeChar(ref char* pSrc, char* pSrcEnd, ref byte* pDst);
            /*0xd21aa4*/ byte* WriteNewLine(byte* pDst);
            /*0xd1ee04*/ void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace);
        }

        class XmlUtf8RawTextWriterIndent : System.Xml.XmlUtf8RawTextWriter
        {
            /*0x90*/ int indentLevel;
            /*0x94*/ bool newLineOnAttributes;
            /*0x98*/ string indentChars;
            /*0xa0*/ bool mixedContent;
            /*0xa8*/ System.Xml.BitStack mixedContentStack;
            /*0xb0*/ System.Xml.ConformanceLevel conformanceLevel;

            /*0xd21f30*/ XmlUtf8RawTextWriterIndent(System.IO.Stream stream, System.Xml.XmlWriterSettings settings);
            /*0xd22064*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0xd2210c*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0xd22178*/ void StartElementContent();
            /*0xd221c8*/ void OnRootElement(System.Xml.ConformanceLevel currentConformanceLevel);
            /*0xd221d0*/ void WriteEndElement(string prefix, string localName, string ns);
            /*0xd22250*/ void WriteFullEndElement(string prefix, string localName, string ns);
            /*0xd222d0*/ void WriteStartAttribute(string prefix, string localName, string ns);
            /*0xd2230c*/ void WriteCData(string text);
            /*0xd22318*/ void WriteComment(string text);
            /*0xd22358*/ void WriteProcessingInstruction(string target, string text);
            /*0xd223a0*/ void WriteEntityRef(string name);
            /*0xd223ac*/ void WriteCharEntity(char ch);
            /*0xd223b8*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0xd223c4*/ void WriteWhitespace(string ws);
            /*0xd223d0*/ void WriteString(string text);
            /*0xd223dc*/ void WriteChars(char[] buffer, int index, int count);
            /*0xd223e8*/ void WriteRaw(char[] buffer, int index, int count);
            /*0xd223f4*/ void WriteRaw(string data);
            /*0xd22400*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0xd21f58*/ void Init(System.Xml.XmlWriterSettings settings);
            /*0xd220c4*/ void WriteIndent();
        }

        class XmlValidatingReader : System.Xml.XmlReader
        {
            /*0x10*/ System.Xml.XmlValidatingReaderImpl impl;

            /*0xd22410*/ System.Xml.XmlNodeType get_NodeType();
            /*0xd22430*/ string get_LocalName();
            /*0xd22450*/ string get_NamespaceURI();
            /*0xd22470*/ string get_Prefix();
            /*0xd22490*/ string get_Value();
            /*0xd224b0*/ int get_Depth();
            /*0xd224d0*/ string get_BaseURI();
            /*0xd224f4*/ bool get_IsEmptyElement();
            /*0xd22518*/ int get_AttributeCount();
            /*0xd2253c*/ string GetAttribute(string name);
            /*0xd22560*/ string GetAttribute(string localName, string namespaceURI);
            /*0xd22584*/ string GetAttribute(int i);
            /*0xd225a8*/ bool MoveToAttribute(string name);
            /*0xd225cc*/ bool MoveToFirstAttribute();
            /*0xd225f0*/ bool MoveToNextAttribute();
            /*0xd22614*/ bool MoveToElement();
            /*0xd22638*/ bool ReadAttributeValue();
            /*0xd2265c*/ bool Read();
            /*0xd22680*/ bool get_EOF();
            /*0xd226a4*/ System.Xml.ReadState get_ReadState();
            /*0xd226c8*/ System.Xml.XmlNameTable get_NameTable();
            /*0xd226ec*/ string LookupNamespace(string prefix);
            /*0xd22724*/ void ResolveEntity();
            /*0xd22748*/ bool get_Namespaces();
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

            /*0xd22788*/ XmlValidatingReaderImpl(System.Xml.XmlReader reader, System.Xml.Schema.ValidationEventHandler settingsEventHandler, bool processIdentityConstraints);
            /*0xd22d98*/ System.Xml.XmlReaderSettings get_Settings();
            /*0xd22e6c*/ System.Xml.XmlNodeType get_NodeType();
            /*0xd22e8c*/ string get_Name();
            /*0xd22eac*/ string get_LocalName();
            /*0xd22ecc*/ string get_NamespaceURI();
            /*0xd22eec*/ string get_Prefix();
            /*0xd22f0c*/ string get_Value();
            /*0xd22f2c*/ int get_Depth();
            /*0xd22f4c*/ string get_BaseURI();
            /*0xd22f70*/ bool get_IsEmptyElement();
            /*0xd22f94*/ bool get_IsDefault();
            /*0xd22fb8*/ char get_QuoteChar();
            /*0xd22fdc*/ System.Xml.XmlSpace get_XmlSpace();
            /*0xd23000*/ string get_XmlLang();
            /*0xd23024*/ System.Xml.ReadState get_ReadState();
            /*0xd23060*/ bool get_EOF();
            /*0xd23084*/ System.Xml.XmlNameTable get_NameTable();
            /*0xd230a8*/ int get_AttributeCount();
            /*0xd230cc*/ string GetAttribute(string name);
            /*0xd230f0*/ string GetAttribute(string localName, string namespaceURI);
            /*0xd23114*/ string GetAttribute(int i);
            /*0xd23138*/ bool MoveToAttribute(string name);
            /*0xd23178*/ void MoveToAttribute(int i);
            /*0xd231a8*/ bool MoveToFirstAttribute();
            /*0xd231e8*/ bool MoveToNextAttribute();
            /*0xd23228*/ bool MoveToElement();
            /*0xd23268*/ bool Read();
            /*0xd2362c*/ void Close();
            /*0xd23660*/ string LookupNamespace(string prefix);
            /*0xd23684*/ bool ReadAttributeValue();
            /*0xd236e4*/ bool get_CanResolveEntity();
            /*0xd236ec*/ void ResolveEntity();
            /*0xd23720*/ void MoveOffEntityReference();
            /*0xd237d8*/ string ReadString();
            /*0xd237f4*/ bool HasLineInfo();
            /*0xd237fc*/ int get_LineNumber();
            /*0xd238e4*/ int get_LinePosition();
            /*0xd239cc*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0xd23a78*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0xd23a88*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            /*0xd239d0*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0xd23a8c*/ string LookupPrefix(string namespaceName);
            /*0xd23b38*/ System.Xml.ValidationType get_ValidationType();
            /*0xd23b40*/ System.Xml.Schema.XmlSchemaCollection get_Schemas();
            /*0xd2276c*/ bool get_Namespaces();
            /*0xd2342c*/ void ParseDtdFromParserContext();
            /*0xd23b48*/ void ValidateDtd();
            /*0xd235a4*/ void ResolveEntityInternally();
            /*0xd22c58*/ void SetupValidation(System.Xml.ValidationType valType);
            /*0xd22ad8*/ System.Xml.XmlResolver GetResolver();
            /*0xd23340*/ void ProcessCoreReaderEvent();
            /*0xd23bc4*/ System.Xml.Schema.BaseValidator get_Validator();
            /*0xd23bcc*/ void set_Validator(System.Xml.Schema.BaseValidator value);
            /*0xd23bd4*/ System.Xml.XmlNamespaceManager get_NamespaceManager();
            /*0xd23bf8*/ bool get_StandAlone();
            /*0xd23c14*/ void set_SchemaTypeObject(object value);
            /*0xd23c30*/ object get_TypedValueObject();
            /*0xd23c4c*/ void set_TypedValueObject(object value);
            /*0xd23c68*/ bool AddDefaultAttribute(System.Xml.Schema.SchemaAttDef attdef);
            /*0xd23c84*/ System.Xml.IDtdInfo get_DtdInfo();
            /*0xd23ca8*/ void ValidateDefaultAttributeOnUse(System.Xml.IDtdDefaultAttributeInfo defaultAttribute, System.Xml.XmlTextReaderImpl coreReader);

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

                /*0xd22bb0*/ ValidationEventHandling(System.Xml.XmlValidatingReaderImpl reader);
                /*0xd23de8*/ object System.Xml.IValidationEventHandling.get_EventHandler();
                /*0xd23df0*/ void System.Xml.IValidationEventHandling.SendEvent(System.Exception exception, System.Xml.Schema.XmlSeverityType severity);
                /*0xd22bd8*/ void AddHandler(System.Xml.Schema.ValidationEventHandler handler);
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

            static /*0xd29ee4*/ XmlWellFormedWriter();
            static /*0xd295cc*/ System.Xml.XmlException DupAttrException(string prefix, string localName);
            static /*0xd297c0*/ string GetStateName(System.Xml.XmlWellFormedWriter.State state);
            static /*0xd29c28*/ System.Exception InvalidCharsException(string name, int badCharIndex);
            /*0xd23f10*/ XmlWellFormedWriter(System.Xml.XmlWriter writer, System.Xml.XmlWriterSettings settings);
            /*0xd2434c*/ System.Xml.WriteState get_WriteState();
            /*0xd243e0*/ void WriteStartDocument();
            /*0xd2459c*/ void WriteStartDocument(bool standalone);
            /*0xd245b8*/ void WriteEndDocument();
            /*0xd24a20*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0xd24f0c*/ void WriteStartElement(string prefix, string localName, string ns);
            /*0xd2592c*/ void WriteEndElement();
            /*0xd25c1c*/ void WriteFullEndElement();
            /*0xd25e38*/ void WriteStartAttribute(string prefix, string localName, string namespaceName);
            /*0xd26a28*/ void WriteEndAttribute();
            /*0xd27764*/ void WriteCData(string text);
            /*0xd27868*/ void WriteComment(string text);
            /*0xd2796c*/ void WriteProcessingInstruction(string name, string text);
            /*0xd27c28*/ void WriteEntityRef(string name);
            /*0xd27da8*/ void WriteCharEntity(char ch);
            /*0xd27f58*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0xd28100*/ void WriteWhitespace(string ws);
            /*0xd282c4*/ void WriteString(string text);
            /*0xd283b8*/ void WriteChars(char[] buffer, int index, int count);
            /*0xd28638*/ void WriteRaw(char[] buffer, int index, int count);
            /*0xd288b8*/ void WriteRaw(string data);
            /*0xd289ac*/ void WriteBase64(byte[] buffer, int index, int count);
            /*0xd28bfc*/ void Close();
            /*0xd28de4*/ void Flush();
            /*0xd28e98*/ string LookupPrefix(string ns);
            /*0xd29118*/ void WriteValue(string value);
            /*0xd2921c*/ void WriteBinHex(byte[] buffer, int index, int count);
            /*0xd29360*/ System.Xml.XmlRawWriter get_RawWriter();
            /*0xd27d98*/ bool get_SaveAttrValue();
            /*0xd28db8*/ bool get_InBase64();
            /*0xd2650c*/ void SetSpecialAttribute(System.Xml.XmlWellFormedWriter.SpecialAttribute special);
            /*0xd243e8*/ void WriteStartDocumentImpl(System.Xml.XmlStandalone standalone);
            /*0xd29368*/ void StartFragment();
            /*0xd254fc*/ void PushNamespaceImplicit(string prefix, string ns);
            /*0xd27284*/ bool PushNamespaceExplicit(string prefix, string ns);
            /*0xd29450*/ void AddNamespace(string prefix, string ns, System.Xml.XmlWellFormedWriter.NamespaceKind kind);
            /*0xd296d8*/ void AddToNamespaceHashtable(int namespaceIndex);
            /*0xd29374*/ int LookupNamespaceIndex(string prefix);
            /*0xd25b48*/ void PopNamespaces(int indexFrom, int indexTo);
            /*0xd24714*/ void AdvanceState(System.Xml.XmlWellFormedWriter.Token token);
            /*0xd29a34*/ void StartElementContent();
            /*0xd253c4*/ string LookupNamespace(string prefix);
            /*0xd266d4*/ string LookupLocalNamespace(string prefix);
            /*0xd265a0*/ string GeneratePrefix();
            /*0xd252c4*/ void CheckNCName(string ncname);
            /*0xd29860*/ void ThrowInvalidStateTransition(System.Xml.XmlWellFormedWriter.Token token, System.Xml.XmlWellFormedWriter.State currentState);
            /*0xd29350*/ bool get_IsClosedOrErrorState();
            /*0xd267a4*/ void AddAttribute(string prefix, string localName, string namespaceName);
            /*0xd29da8*/ void AddToAttrHashTable(int attributeIndex);

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

                /*0xd242f8*/ NamespaceResolverProxy(System.Xml.XmlWellFormedWriter wfWriter);
                /*0xd2a844*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
                /*0xd2a884*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
                /*0xd2a89c*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            }

            struct ElementScope
            {
                /*0x10*/ int prevNSTop;
                /*0x18*/ string prefix;
                /*0x20*/ string localName;
                /*0x28*/ string namespaceUri;
                /*0x30*/ System.Xml.XmlSpace xmlSpace;
                /*0x38*/ string xmlLang;

                /*0xd24330*/ void Set(string prefix, string localName, string namespaceUri, int prevNSTop);
                /*0xd25b18*/ void WriteEndElement(System.Xml.XmlRawWriter rawWriter);
                /*0xd25e08*/ void WriteFullEndElement(System.Xml.XmlRawWriter rawWriter);
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

                /*0xd24320*/ void Set(string prefix, string namespaceUri, System.Xml.XmlWellFormedWriter.NamespaceKind kind);
                /*0xd29afc*/ void WriteDecl(System.Xml.XmlWriter writer, System.Xml.XmlRawWriter rawWriter);
            }

            struct AttrName
            {
                /*0x10*/ string prefix;
                /*0x18*/ string namespaceUri;
                /*0x20*/ string localName;
                /*0x28*/ int prev;

                /*0x996674*/ void Set(string prefix, string localName, string namespaceUri);
                /*0x996684*/ bool IsDuplicate(string prefix, string localName, string namespaceUri);
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

                /*0x997680*/ AttributeValueCache();
                /*0x9966f0*/ string get_StringValue();
                /*0x996724*/ void WriteEntityRef(string name);
                /*0x996a70*/ void WriteCharEntity(char ch);
                /*0x996b04*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
                /*0x996bc8*/ void WriteWhitespace(string ws);
                /*0x996c18*/ void WriteString(string text);
                /*0x996c88*/ void WriteChars(char[] buffer, int index, int count);
                /*0x996d74*/ void WriteRaw(char[] buffer, int index, int count);
                /*0x996e24*/ void WriteRaw(string data);
                /*0x996e74*/ void WriteValue(string value);
                /*0x996ec4*/ void Replay(System.Xml.XmlWriter writer);
                /*0x9971e8*/ void Trim();
                /*0x99763c*/ void Clear();
                /*0x9968c0*/ void StartComplexValue();
                /*0x9968fc*/ void AddItem(System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType type, object data);

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

                    /*0x99766c*/ Item();
                    /*0x997674*/ void Set(System.Xml.XmlWellFormedWriter.AttributeValueCache.ItemType type, object data);
                }

                class BufferChunk
                {
                    /*0x10*/ char[] buffer;
                    /*0x18*/ int index;
                    /*0x1c*/ int count;

                    /*0x996d38*/ BufferChunk(char[] buffer, int index, int count);
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

            static /*0x997ff0*/ System.Xml.XmlWriter Create(System.IO.Stream output, System.Xml.XmlWriterSettings settings);
            static /*0x998590*/ System.Xml.XmlWriter Create(System.IO.TextWriter output, System.Xml.XmlWriterSettings settings);
            /*0x998918*/ XmlWriter();
            void WriteStartDocument();
            void WriteStartDocument(bool standalone);
            void WriteEndDocument();
            void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x9976f0*/ void WriteStartElement(string localName, string ns);
            void WriteStartElement(string prefix, string localName, string ns);
            void WriteEndElement();
            void WriteFullEndElement();
            /*0x997708*/ void WriteAttributeString(string localName, string ns, string value);
            /*0x997764*/ void WriteAttributeString(string localName, string value);
            /*0x9977c0*/ void WriteAttributeString(string prefix, string localName, string ns, string value);
            void WriteStartAttribute(string prefix, string localName, string ns);
            void WriteEndAttribute();
            void WriteCData(string text);
            void WriteComment(string text);
            void WriteProcessingInstruction(string name, string text);
            void WriteEntityRef(string name);
            void WriteCharEntity(char ch);
            void WriteWhitespace(string ws);
            void WriteString(string text);
            void WriteSurrogateCharEntity(char lowChar, char highChar);
            void WriteChars(char[] buffer, int index, int count);
            void WriteRaw(char[] buffer, int index, int count);
            void WriteRaw(string data);
            void WriteBase64(byte[] buffer, int index, int count);
            /*0x997810*/ void WriteBinHex(byte[] buffer, int index, int count);
            System.Xml.WriteState get_WriteState();
            /*0x99782c*/ void Close();
            void Flush();
            string LookupPrefix(string ns);
            /*0x997830*/ void WriteValue(string value);
            /*0x997848*/ void WriteAttributes(System.Xml.XmlReader reader, bool defattr);
            /*0x997acc*/ void WriteNode(System.Xml.XmlReader reader, bool defattr);
            /*0x997f34*/ void WriteElementString(string localName, string ns, string value);
            /*0x997f98*/ void Dispose();
            /*0x997fac*/ void Dispose(bool disposing);
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

            /*0x998058*/ XmlWriterSettings();
            /*0x998a00*/ bool get_Async();
            /*0x998a08*/ System.Text.Encoding get_Encoding();
            /*0x998a10*/ bool get_OmitXmlDeclaration();
            /*0x998a18*/ void set_OmitXmlDeclaration(bool value);
            /*0x998b2c*/ System.Xml.NewLineHandling get_NewLineHandling();
            /*0x998b34*/ string get_NewLineChars();
            /*0x998b3c*/ bool get_Indent();
            /*0x998b4c*/ void set_Indent(bool value);
            /*0x998bb4*/ string get_IndentChars();
            /*0x998bbc*/ bool get_NewLineOnAttributes();
            /*0x998bc4*/ bool get_CloseOutput();
            /*0x998bcc*/ System.Xml.ConformanceLevel get_ConformanceLevel();
            /*0x998bd4*/ void set_ConformanceLevel(System.Xml.ConformanceLevel value);
            /*0x998c84*/ bool get_CheckCharacters();
            /*0x998c8c*/ System.Xml.NamespaceHandling get_NamespaceHandling();
            /*0x998c94*/ void set_NamespaceHandling(System.Xml.NamespaceHandling value);
            /*0x998d44*/ bool get_WriteEndDocumentOnClose();
            /*0x998d4c*/ System.Xml.XmlOutputMethod get_OutputMethod();
            /*0x998d54*/ void set_OutputMethod(System.Xml.XmlOutputMethod value);
            /*0x998d5c*/ System.Xml.XmlWriterSettings Clone();
            /*0x998e28*/ System.Collections.Generic.List<System.Xml.XmlQualifiedName> get_CDataSectionElements();
            /*0x998e30*/ bool get_DoNotEscapeUriAttributes();
            /*0x998e38*/ bool get_MergeCDataSections();
            /*0x998e40*/ string get_MediaType();
            /*0x998e48*/ string get_DocTypeSystem();
            /*0x998e50*/ string get_DocTypePublic();
            /*0x998e58*/ System.Xml.XmlStandalone get_Standalone();
            /*0x998e60*/ bool get_AutoXmlDeclaration();
            /*0x998e68*/ System.Xml.TriState get_IndentInternal();
            /*0x998e70*/ bool get_IsQuerySpecific();
            /*0x9980dc*/ System.Xml.XmlWriter CreateWriter(System.IO.Stream output);
            /*0x9985f8*/ System.Xml.XmlWriter CreateWriter(System.IO.TextWriter output);
            /*0x998ee0*/ void set_ReadOnly(bool value);
            /*0x998a74*/ void CheckReadOnly(string propertyName);
            /*0x998920*/ void Initialize();
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

            /*0x998eec*/ XsdCachingReader(System.Xml.XmlReader reader, System.Xml.IXmlLineInfo lineInfo, System.Xml.CachingEventHandler handlerMethod);
            /*0x998fa8*/ void Init();
            /*0x9993e4*/ void Reset(System.Xml.XmlReader reader);
            /*0x9993ec*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x99940c*/ System.Xml.XmlNodeType get_NodeType();
            /*0x999428*/ string get_Name();
            /*0x99944c*/ string get_LocalName();
            /*0x999468*/ string get_NamespaceURI();
            /*0x999484*/ string get_Prefix();
            /*0x9994a0*/ string get_Value();
            /*0x9994d0*/ int get_Depth();
            /*0x9994ec*/ string get_BaseURI();
            /*0x999510*/ bool get_IsEmptyElement();
            /*0x999518*/ bool get_IsDefault();
            /*0x999520*/ char get_QuoteChar();
            /*0x999544*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x999568*/ string get_XmlLang();
            /*0x99958c*/ int get_AttributeCount();
            /*0x999594*/ string GetAttribute(string name);
            /*0x999770*/ string GetAttribute(string name, string namespaceURI);
            /*0x999888*/ string GetAttribute(int i);
            /*0x99991c*/ bool MoveToAttribute(string name);
            /*0x9999ac*/ void MoveToAttribute(int i);
            /*0x999a40*/ bool MoveToFirstAttribute();
            /*0x999a84*/ bool MoveToNextAttribute();
            /*0x999adc*/ bool MoveToElement();
            /*0x999b30*/ bool Read();
            /*0x999e04*/ System.Xml.ValidatingReaderNodeData RecordTextNode(string textValue, string originalStringValue, int depth, int lineNo, int linePos);
            /*0x999e7c*/ void SwitchTextNodeAndEndElement(string textValue, string originalStringValue);
            /*0x999f7c*/ void RecordEndElementNode();
            /*0x99a0ac*/ bool get_EOF();
            /*0x99a0e8*/ void Close();
            /*0x99a11c*/ System.Xml.ReadState get_ReadState();
            /*0x99a140*/ void Skip();
            /*0x99a254*/ System.Xml.XmlNameTable get_NameTable();
            /*0x99a25c*/ string LookupNamespace(string prefix);
            /*0x99a280*/ void ResolveEntity();
            /*0x99a2c0*/ bool ReadAttributeValue();
            /*0x99a390*/ bool System.Xml.IXmlLineInfo.HasLineInfo();
            /*0x99a398*/ int System.Xml.IXmlLineInfo.get_LineNumber();
            /*0x99a3b4*/ int System.Xml.IXmlLineInfo.get_LinePosition();
            /*0x99a3d0*/ void SetToReplayMode();
            /*0x99a3f0*/ System.Xml.XmlReader GetCoreReader();
            /*0x99a3f8*/ System.Xml.IXmlLineInfo GetLineInfo();
            /*0x999df4*/ void ClearAttributesInfo();
            /*0x99a400*/ System.Xml.ValidatingReaderNodeData AddAttribute(int attIndex);
            /*0x9990f8*/ System.Xml.ValidatingReaderNodeData AddContent(System.Xml.XmlNodeType nodeType);
            /*0x99926c*/ void RecordAttributes();
            /*0x999620*/ int GetAttributeIndexWithoutPrefix(string name);
            /*0x9996d0*/ int GetAttributeIndexWithPrefix(string name);
            /*0x99a308*/ System.Xml.ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth);

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
            /*0x99a55c*/ CachingEventHandler(object object, nint method);
            /*0x99a688*/ void Invoke(System.Xml.XsdCachingReader cachingReader);
        }

        class AttributePSVIInfo
        {
            /*0x10*/ string localName;
            /*0x18*/ string namespaceUri;
            /*0x20*/ object typedAttributeValue;
            /*0x28*/ System.Xml.Schema.XmlSchemaInfo attributeSchemaInfo;

            /*0x99a69c*/ AttributePSVIInfo();
            /*0x99a708*/ void Reset();
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

            /*0x99a76c*/ XsdValidatingReader(System.Xml.XmlReader reader, System.Xml.XmlResolver xmlResolver, System.Xml.XmlReaderSettings readerSettings, System.Xml.Schema.XmlSchemaObject partialValidationType);
            /*0x99ae10*/ XsdValidatingReader(System.Xml.XmlReader reader, System.Xml.XmlResolver xmlResolver, System.Xml.XmlReaderSettings readerSettings);
            /*0x99a904*/ void Init();
            /*0x99ac30*/ void SetupValidator(System.Xml.XmlReaderSettings readerSettings, System.Xml.XmlReader reader, System.Xml.Schema.XmlSchemaObject partialValidationType);
            /*0x99ae18*/ System.Xml.XmlReaderSettings get_Settings();
            /*0x99aeec*/ System.Xml.XmlNodeType get_NodeType();
            /*0x99af74*/ string get_Name();
            /*0x99b0a8*/ string get_LocalName();
            /*0x99b0e4*/ string get_NamespaceURI();
            /*0x99b120*/ string get_Prefix();
            /*0x99b15c*/ string get_Value();
            /*0x99b198*/ int get_Depth();
            /*0x99b1d4*/ string get_BaseURI();
            /*0x99b1f8*/ bool get_IsEmptyElement();
            /*0x99b21c*/ bool get_IsDefault();
            /*0x99b258*/ char get_QuoteChar();
            /*0x99b27c*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x99b2a0*/ string get_XmlLang();
            /*0x99b2c4*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x99b2c8*/ System.Type get_ValueType();
            /*0x99b3ac*/ int get_AttributeCount();
            /*0x99b3b4*/ string GetAttribute(string name);
            /*0x99b5a4*/ string GetAttribute(string name, string namespaceURI);
            /*0x99b7e8*/ string GetAttribute(int i);
            /*0x99b8c4*/ bool MoveToAttribute(string name);
            /*0x99bafc*/ void MoveToAttribute(int i);
            /*0x99bc94*/ bool MoveToFirstAttribute();
            /*0x99bde8*/ bool MoveToNextAttribute();
            /*0x99bf40*/ bool MoveToElement();
            /*0x99bf94*/ bool Read();
            /*0x99c398*/ bool get_EOF();
            /*0x99c3bc*/ void Close();
            /*0x99c3f0*/ System.Xml.ReadState get_ReadState();
            /*0x99c42c*/ void Skip();
            /*0x99c598*/ System.Xml.XmlNameTable get_NameTable();
            /*0x99c5a0*/ string LookupNamespace(string prefix);
            /*0x99c64c*/ void ResolveEntity();
            /*0x99c68c*/ bool ReadAttributeValue();
            /*0x99c7c0*/ bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault();
            /*0x99cab8*/ bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil();
            /*0x99cb04*/ System.Xml.Schema.XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity();
            /*0x99cb98*/ System.Xml.Schema.XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType();
            /*0x99cd10*/ System.Xml.Schema.XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType();
            /*0x99cd6c*/ System.Xml.Schema.XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement();
            /*0x99cdc0*/ System.Xml.Schema.XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute();
            /*0x99ce04*/ bool HasLineInfo();
            /*0x99ce0c*/ int get_LineNumber();
            /*0x99cebc*/ int get_LinePosition();
            /*0x99cf6c*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x99d02c*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0x99d0f0*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            /*0x99d1b4*/ object GetStringValue();
            /*0x99b390*/ System.Xml.Schema.XmlSchemaInfo get_AttributeSchemaInfo();
            /*0x99c0e4*/ void ProcessReaderEvent();
            /*0x99d1d4*/ void ProcessElementEvent();
            /*0x99d66c*/ void ProcessEndElementEvent();
            /*0x99d7ec*/ void ValidateAttributes();
            /*0x99c35c*/ void ClearAttributesInfo();
            /*0x99b97c*/ System.Xml.AttributePSVIInfo GetAttributePSVI(string name);
            /*0x99dc4c*/ System.Xml.AttributePSVIInfo GetAttributePSVI(string localName, string ns);
            /*0x99b420*/ System.Xml.ValidatingReaderNodeData GetDefaultAttribute(string name, bool updatePosition);
            /*0x99b6a4*/ System.Xml.ValidatingReaderNodeData GetDefaultAttribute(string attrLocalName, string ns, bool updatePosition);
            /*0x99db00*/ System.Xml.AttributePSVIInfo AddAttributePSVI(int attIndex);
            /*0x99d79c*/ bool IsXSDRoot(string localName, string ns);
            /*0x99c2ac*/ void ProcessInlineSchema();
            /*0x99dcf4*/ void ReadAheadForMemberType();
            /*0x99c848*/ void GetIsDefault();
            /*0x99cc18*/ void GetMemberType();
            /*0x99da24*/ System.Xml.XsdCachingReader GetCachingReader();
            /*0x99c738*/ System.Xml.ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth);
            /*0x99deb8*/ void CachingCallBack(System.Xml.XsdCachingReader cachingReader);
            /*0x99d994*/ string GetOriginalAtomicValueStringOfElement();

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

            /*0x99dee0*/ DomNameTable(System.Xml.XmlDocument document);
            /*0x99df80*/ System.Xml.XmlName GetName(string prefix, string localName, string ns, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            /*0x99e0dc*/ System.Xml.XmlName AddName(string prefix, string localName, string ns, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            /*0x99e340*/ void Grow();
        }

        class XmlAttribute : System.Xml.XmlNode
        {
            /*0x18*/ System.Xml.XmlName name;
            /*0x20*/ System.Xml.XmlLinkedNode lastChild;

            /*0x99e464*/ XmlAttribute(System.Xml.XmlName name, System.Xml.XmlDocument doc);
            /*0x99e668*/ XmlAttribute(string prefix, string localName, string namespaceURI, System.Xml.XmlDocument doc);
            /*0x99e64c*/ int get_LocalNameHash();
            /*0x99e7c0*/ System.Xml.XmlName get_XmlName();
            /*0x99e7c8*/ void set_XmlName(System.Xml.XmlName value);
            /*0x99e7d0*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x99e898*/ System.Xml.XmlNode get_ParentNode();
            /*0x99e8a0*/ string get_Name();
            /*0x99e8bc*/ string get_LocalName();
            /*0x99e8d8*/ string get_NamespaceURI();
            /*0x99e8f4*/ string get_Prefix();
            /*0x99e910*/ void set_Prefix(string value);
            /*0x99e9a4*/ System.Xml.XmlNodeType get_NodeType();
            /*0x99e9ac*/ System.Xml.XmlDocument get_OwnerDocument();
            /*0x99e9c8*/ string get_Value();
            /*0x99e9d8*/ void set_Value(string value);
            /*0x99e9e8*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x99e9f0*/ void set_InnerText(string value);
            /*0x99ea54*/ bool PrepareOwnerElementInElementIdAttrMap();
            /*0x99eb04*/ void ResetOwnerElementInElementIdAttrMap(string oldInnerText);
            /*0x99ed34*/ bool get_IsContainer();
            /*0x99ed3c*/ System.Xml.XmlNode AppendChildForLoad(System.Xml.XmlNode newChild, System.Xml.XmlDocument doc);
            /*0x99ef60*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x99ef68*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x99ef70*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x99ef88*/ bool get_Specified();
            /*0x99ef90*/ System.Xml.XmlNode InsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x99f020*/ System.Xml.XmlNode InsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x99f0b0*/ System.Xml.XmlNode RemoveChild(System.Xml.XmlNode oldChild);
            /*0x99f128*/ System.Xml.XmlNode PrependChild(System.Xml.XmlNode newChild);
            /*0x99f1a0*/ System.Xml.XmlNode AppendChild(System.Xml.XmlNode newChild);
            /*0x99f218*/ System.Xml.XmlElement get_OwnerElement();
            /*0x99f294*/ void set_InnerXml(string value);
            /*0x99f330*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x99f3e4*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x99f44c*/ string get_BaseURI();
            /*0x99f4e4*/ void SetParent(System.Xml.XmlNode node);
            /*0x99f4ec*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x99f540*/ string get_XmlLang();
        }

        class XmlAttributeCollection : System.Xml.XmlNamedNodeMap, System.Collections.ICollection, System.Collections.IEnumerable
        {
            /*0x99f5d8*/ XmlAttributeCollection(System.Xml.XmlNode parent);
            /*0x99f5e0*/ System.Xml.XmlAttribute get_ItemOf(int i);
            /*0x99f72c*/ System.Xml.XmlAttribute get_ItemOf(string name);
            /*0x99f854*/ System.Xml.XmlAttribute get_ItemOf(string localName, string namespaceURI);
            /*0x99f9ac*/ int FindNodeOffsetNS(System.Xml.XmlAttribute node);
            /*0x99fb30*/ System.Xml.XmlNode SetNamedItem(System.Xml.XmlNode node);
            /*0x99fd6c*/ System.Xml.XmlAttribute Append(System.Xml.XmlAttribute node);
            /*0x9a0028*/ System.Xml.XmlAttribute Remove(System.Xml.XmlAttribute node);
            /*0x9a00b0*/ System.Xml.XmlAttribute RemoveAt(int i);
            /*0x9a015c*/ void RemoveAll();
            /*0x9a01a4*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
            /*0x9a0228*/ bool System.Collections.ICollection.get_IsSynchronized();
            /*0x9a0230*/ object System.Collections.ICollection.get_SyncRoot();
            /*0x9a0234*/ int System.Collections.ICollection.get_Count();
            /*0x9a023c*/ System.Xml.XmlNode AddNode(System.Xml.XmlNode node);
            /*0x9a0424*/ System.Xml.XmlNode InsertNodeAt(int i, System.Xml.XmlNode node);
            /*0x9a04d4*/ System.Xml.XmlNode RemoveNodeAt(int i);
            /*0x99fe88*/ void Detach(System.Xml.XmlAttribute attr);
            /*0x99fed0*/ void InsertParentIntoElementIdAttrMap(System.Xml.XmlAttribute attr);
            /*0x9a0674*/ void RemoveParentFromElementIdAttrMap(System.Xml.XmlAttribute attr);
            /*0x9a0320*/ int RemoveDuplicateAttribute(System.Xml.XmlAttribute attr);
            /*0x99eb80*/ bool PrepareParentInElementIdAttrMap(string attrPrefix, string attrLocalName);
            /*0x99ec74*/ void ResetParentInElementIdAttrMap(string oldVal, string newVal);
            /*0x99fccc*/ System.Xml.XmlAttribute InternalAppendAttribute(System.Xml.XmlAttribute node);
        }

        class XmlCDataSection : System.Xml.XmlCharacterData
        {
            /*0x9a0da0*/ XmlCDataSection(string data, System.Xml.XmlDocument doc);
            /*0x9a0df8*/ string get_Name();
            /*0x9a0e20*/ string get_LocalName();
            /*0x9a0e48*/ System.Xml.XmlNodeType get_NodeType();
            /*0x9a0e50*/ System.Xml.XmlNode get_ParentNode();
            /*0x9a0ed4*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x9a0f30*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x9a0f70*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x9a0f74*/ bool get_IsText();
        }

        class XmlCharacterData : System.Xml.XmlLinkedNode
        {
            /*0x20*/ string data;

            /*0x9a0dcc*/ XmlCharacterData(string data, System.Xml.XmlDocument doc);
            /*0x9a0f98*/ string get_Value();
            /*0x9a0fa8*/ void set_Value(string value);
            /*0x9a0fb8*/ string get_InnerText();
            /*0x9a0fc4*/ void set_InnerText(string value);
            /*0x9a0fd0*/ string get_Data();
            /*0x9a1024*/ void set_Data(string value);
            /*0x9a10c4*/ bool CheckOnData(string data);
        }

        class XmlChildEnumerator : System.Collections.IEnumerator
        {
            /*0x10*/ System.Xml.XmlNode container;
            /*0x18*/ System.Xml.XmlNode child;
            /*0x20*/ bool isFirst;

            /*0x9a10fc*/ XmlChildEnumerator(System.Xml.XmlNode container);
            /*0x9a114c*/ bool System.Collections.IEnumerator.MoveNext();
            /*0x9a1150*/ bool MoveNext();
            /*0x9a11b4*/ void System.Collections.IEnumerator.Reset();
            /*0x9a11ec*/ object System.Collections.IEnumerator.get_Current();
            /*0x9a11f0*/ System.Xml.XmlNode get_Current();
        }

        class XmlChildNodes : System.Xml.XmlNodeList
        {
            /*0x10*/ System.Xml.XmlNode container;

            /*0x9a126c*/ XmlChildNodes(System.Xml.XmlNode container);
            /*0x9a1294*/ System.Xml.XmlNode Item(int i);
            /*0x9a12f0*/ int get_Count();
            /*0x9a133c*/ System.Collections.IEnumerator GetEnumerator();
        }

        class XmlComment : System.Xml.XmlCharacterData
        {
            /*0x9a13f0*/ XmlComment(string comment, System.Xml.XmlDocument doc);
            /*0x9a141c*/ string get_Name();
            /*0x9a1444*/ string get_LocalName();
            /*0x9a146c*/ System.Xml.XmlNodeType get_NodeType();
            /*0x9a1474*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x9a14d0*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x9a1510*/ void WriteContentTo(System.Xml.XmlWriter w);
        }

        class XmlDeclaration : System.Xml.XmlLinkedNode
        {
            /*0x20*/ string version;
            /*0x28*/ string encoding;
            /*0x30*/ string standalone;

            /*0x9a1514*/ XmlDeclaration(string version, string encoding, string standalone, System.Xml.XmlDocument doc);
            /*0x9a18d8*/ string get_Version();
            /*0x9a18e0*/ void set_Version(string value);
            /*0x9a18e8*/ string get_Encoding();
            /*0x9a1724*/ void set_Encoding(string value);
            /*0x9a18f0*/ string get_Standalone();
            /*0x9a178c*/ void set_Standalone(string value);
            /*0x9a18f8*/ string get_Value();
            /*0x9a1908*/ void set_Value(string value);
            /*0x9a1918*/ string get_InnerText();
            /*0x9a1a80*/ void set_InnerText(string value);
            /*0x9a1e10*/ string get_Name();
            /*0x9a1e50*/ string get_LocalName();
            /*0x9a1e5c*/ System.Xml.XmlNodeType get_NodeType();
            /*0x9a1e64*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x9a1ea0*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x9a1f04*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x9a16a8*/ bool IsValidXmlVersion(string ver);
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

            static /*0x9a6068*/ XmlDocument();
            static /*0x99e574*/ void CheckName(string name);
            /*0x9a1f08*/ XmlDocument();
            /*0x9a239c*/ XmlDocument(System.Xml.XmlNameTable nt);
            /*0x9a1fd4*/ XmlDocument(System.Xml.XmlImplementation imp);
            /*0x9a2438*/ System.Xml.Schema.SchemaInfo get_DtdSchemaInfo();
            /*0x9a2440*/ void set_DtdSchemaInfo(System.Xml.Schema.SchemaInfo value);
            /*0x9a2448*/ System.Xml.XmlName AddXmlName(string prefix, string localName, string namespaceURI, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            /*0x9a2460*/ System.Xml.XmlName GetXmlName(string prefix, string localName, string namespaceURI, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            /*0x99e6a4*/ System.Xml.XmlName AddAttrXmlName(string prefix, string localName, string namespaceURI, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            /*0x9a2478*/ bool AddIdInfo(System.Xml.XmlName eleName, System.Xml.XmlName attrName);
            /*0x9a2538*/ System.Xml.XmlName GetIDInfoByElement_(System.Xml.XmlName eleName);
            /*0x9a0a60*/ System.Xml.XmlName GetIDInfoByElement(System.Xml.XmlName eleName);
            /*0x9a260c*/ System.WeakReference GetElement(System.Collections.ArrayList elementList, System.Xml.XmlElement elem);
            /*0x9a0a74*/ void AddElementWithId(string id, System.Xml.XmlElement elem);
            /*0x9a0c68*/ void RemoveElementWithId(string id, System.Xml.XmlElement elem);
            /*0x9a2c5c*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x9a2d58*/ System.Xml.XmlNodeType get_NodeType();
            /*0x9a2d60*/ System.Xml.XmlNode get_ParentNode();
            /*0x9a2d68*/ System.Xml.XmlDocumentType get_DocumentType();
            /*0x9a2df4*/ System.Xml.XmlDeclaration get_Declaration();
            /*0x9a2e98*/ System.Xml.XmlImplementation get_Implementation();
            /*0x9a2ea0*/ string get_Name();
            /*0x9a2ea8*/ string get_LocalName();
            /*0x9a2eb0*/ System.Xml.XmlElement get_DocumentElement();
            /*0x9a2f3c*/ bool get_IsContainer();
            /*0x9a2f44*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x9a2f4c*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x9a2f54*/ System.Xml.XmlDocument get_OwnerDocument();
            /*0x9a2f5c*/ void set_Schemas(System.Xml.Schema.XmlSchemaSet value);
            /*0x9a2f64*/ bool get_CanReportValidity();
            /*0x9a2f6c*/ bool get_HasSetResolver();
            /*0x9a2f74*/ System.Xml.XmlResolver GetResolver();
            /*0x9a2f7c*/ void set_XmlResolver(System.Xml.XmlResolver value);
            /*0x9a3104*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x9a31f4*/ bool HasNodeTypeInPrevSiblings(System.Xml.XmlNodeType nt, System.Xml.XmlNode refNode);
            /*0x9a32a4*/ bool HasNodeTypeInNextSiblings(System.Xml.XmlNodeType nt, System.Xml.XmlNode refNode);
            /*0x9a3308*/ bool CanInsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x9a3460*/ bool CanInsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x9a3558*/ System.Xml.XmlAttribute CreateAttribute(string name);
            /*0x9a3618*/ void SetDefaultNamespace(string prefix, string localName, ref string namespaceURI);
            /*0x9a36a8*/ System.Xml.XmlCDataSection CreateCDataSection(string data);
            /*0x9a3724*/ System.Xml.XmlComment CreateComment(string data);
            /*0x9a3798*/ System.Xml.XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset);
            /*0x9a38f0*/ System.Xml.XmlDocumentFragment CreateDocumentFragment();
            /*0x9a39d4*/ System.Xml.XmlElement CreateElement(string name);
            /*0x9a3a84*/ void AddDefaultAttributes(System.Xml.XmlElement elem);
            /*0x9a3d0c*/ System.Xml.Schema.SchemaElementDecl GetSchemaElementDecl(System.Xml.XmlElement elem);
            /*0x9a3e1c*/ System.Xml.XmlAttribute PrepareDefaultAttribute(System.Xml.Schema.SchemaAttDef attdef, string attrPrefix, string attrLocalname, string attrNamespaceURI);
            /*0x9a3f18*/ System.Xml.XmlEntityReference CreateEntityReference(string name);
            /*0x9a4078*/ System.Xml.XmlProcessingInstruction CreateProcessingInstruction(string target, string data);
            /*0x9a40f4*/ System.Xml.XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone);
            /*0x9a417c*/ System.Xml.XmlText CreateTextNode(string text);
            /*0x9a41f0*/ System.Xml.XmlSignificantWhitespace CreateSignificantWhitespace(string text);
            /*0x9a4264*/ System.Xml.XmlWhitespace CreateWhitespace(string text);
            /*0x9a42d8*/ System.Xml.XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI);
            /*0x9a437c*/ System.Xml.XmlElement CreateElement(string qualifiedName, string namespaceURI);
            /*0x9a4420*/ System.Xml.XmlNode ImportNodeInternal(System.Xml.XmlNode node, bool deep);
            /*0x9a48d0*/ void ImportAttributes(System.Xml.XmlNode fromElem, System.Xml.XmlNode toElem);
            /*0x9a2cbc*/ void ImportChildren(System.Xml.XmlNode fromNode, System.Xml.XmlNode toNode, bool deep);
            /*0x99df64*/ System.Xml.XmlNameTable get_NameTable();
            /*0x9a49e4*/ System.Xml.XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI);
            /*0x9a4a84*/ System.Xml.XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI);
            /*0x9a4b10*/ System.Xml.XmlElement CreateElement(string prefix, string localName, string namespaceURI);
            /*0x9a4ce0*/ bool get_IsReadOnly();
            /*0x9a4ce8*/ System.Xml.XmlNamedNodeMap get_Entities();
            /*0x9a4d58*/ void set_Entities(System.Xml.XmlNamedNodeMap value);
            /*0x9a4d60*/ bool get_IsLoading();
            /*0x9a4d68*/ void set_IsLoading(bool value);
            /*0x9a4d74*/ bool get_ActualLoadingStatus();
            /*0x9a4d7c*/ System.Xml.XmlNode ReadNode(System.Xml.XmlReader reader);
            /*0x9a4f7c*/ System.Xml.XmlTextReader SetupReader(System.Xml.XmlTextReader tr);
            /*0x9a4fdc*/ void Load(System.Xml.XmlReader reader);
            /*0x9a532c*/ void LoadXml(string xml);
            /*0x9a547c*/ void set_InnerText(string value);
            /*0x9a54dc*/ void set_InnerXml(string value);
            /*0x9a54ec*/ void Save(System.Xml.XmlWriter w);
            /*0x9a5710*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x9a5720*/ void WriteContentTo(System.Xml.XmlWriter xw);
            /*0x9a5a1c*/ System.Xml.XmlNodeChangedEventArgs GetEventArgs(System.Xml.XmlNode node, System.Xml.XmlNode oldParent, System.Xml.XmlNode newParent, string oldValue, string newValue, System.Xml.XmlNodeChangedAction action);
            /*0x99eea4*/ System.Xml.XmlNodeChangedEventArgs GetInsertEventArgsForLoad(System.Xml.XmlNode node, System.Xml.XmlNode newParent);
            /*0x9a5b1c*/ void BeforeEvent(System.Xml.XmlNodeChangedEventArgs args);
            /*0x9a5b70*/ void AfterEvent(System.Xml.XmlNodeChangedEventArgs args);
            /*0x9a07cc*/ System.Xml.XmlAttribute GetDefaultAttribute(System.Xml.XmlElement elem, string attrPrefix, string attrLocalname, string attrNamespaceURI);
            /*0x9a5bc4*/ string get_Version();
            /*0x9a5be8*/ string get_Encoding();
            /*0x9a56ec*/ string get_Standalone();
            /*0x9a5c0c*/ System.Xml.XmlEntity GetEntityNode(string name);
            /*0x9a5d40*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x9a5e84*/ string get_BaseURI();
            /*0x9a5e8c*/ void SetBaseURI(string inBaseURI);
            /*0x9a5e94*/ System.Xml.XmlNode AppendChildForLoad(System.Xml.XmlNode newChild, System.Xml.XmlDocument doc);
        }

        class XmlDocumentFragment : System.Xml.XmlNode
        {
            /*0x18*/ System.Xml.XmlLinkedNode lastChild;

            /*0x9a3950*/ XmlDocumentFragment(System.Xml.XmlDocument ownerDocument);
            /*0x9a616c*/ string get_Name();
            /*0x9a6194*/ string get_LocalName();
            /*0x9a61bc*/ System.Xml.XmlNodeType get_NodeType();
            /*0x9a61c4*/ System.Xml.XmlNode get_ParentNode();
            /*0x9a61cc*/ System.Xml.XmlDocument get_OwnerDocument();
            /*0x9a6244*/ void set_InnerXml(string value);
            /*0x9a64d4*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x9a6558*/ bool get_IsContainer();
            /*0x9a6560*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x9a6568*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x9a6570*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x9a65dc*/ bool CanInsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x9a664c*/ bool CanInsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x9a66b4*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x9a66c4*/ void WriteContentTo(System.Xml.XmlWriter w);
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

            /*0x9a3828*/ XmlDocumentType(string name, string publicId, string systemId, string internalSubset, System.Xml.XmlDocument doc);
            /*0x9a6a28*/ string get_Name();
            /*0x9a6a30*/ string get_LocalName();
            /*0x9a6a38*/ System.Xml.XmlNodeType get_NodeType();
            /*0x9a6a40*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x9a6a7c*/ bool get_IsReadOnly();
            /*0x9a5cd0*/ System.Xml.XmlNamedNodeMap get_Entities();
            /*0x9a6a84*/ System.Xml.XmlNamedNodeMap get_Notations();
            /*0x9a6af4*/ string get_PublicId();
            /*0x9a6afc*/ string get_SystemId();
            /*0x9a6b04*/ string get_InternalSubset();
            /*0x9a6b0c*/ bool get_ParseWithNamespaces();
            /*0x9a6b14*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x9a6b40*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x9a6b44*/ System.Xml.Schema.SchemaInfo get_DtdSchemaInfo();
            /*0x9a6b4c*/ void set_DtdSchemaInfo(System.Xml.Schema.SchemaInfo value);
        }

        class XmlElement : System.Xml.XmlLinkedNode
        {
            /*0x20*/ System.Xml.XmlName name;
            /*0x28*/ System.Xml.XmlAttributeCollection attributes;
            /*0x30*/ System.Xml.XmlLinkedNode lastChild;

            static /*0x9a7c94*/ void WriteElementTo(System.Xml.XmlWriter writer, System.Xml.XmlElement e);
            /*0x9a4bc4*/ XmlElement(System.Xml.XmlName name, bool empty, System.Xml.XmlDocument doc);
            /*0x9a6b54*/ XmlElement(string prefix, string localName, string namespaceURI, System.Xml.XmlDocument doc);
            /*0x9a6b98*/ System.Xml.XmlName get_XmlName();
            /*0x9a6ba0*/ void set_XmlName(System.Xml.XmlName value);
            /*0x9a6ba8*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x9a7180*/ string get_Name();
            /*0x9a719c*/ string get_LocalName();
            /*0x9a71b8*/ string get_NamespaceURI();
            /*0x9a71d4*/ string get_Prefix();
            /*0x9a71f0*/ void set_Prefix(string value);
            /*0x9a7288*/ System.Xml.XmlNodeType get_NodeType();
            /*0x9a7290*/ System.Xml.XmlNode get_ParentNode();
            /*0x9a7298*/ System.Xml.XmlDocument get_OwnerDocument();
            /*0x9a72b4*/ bool get_IsContainer();
            /*0x9a72bc*/ System.Xml.XmlNode AppendChildForLoad(System.Xml.XmlNode newChild, System.Xml.XmlDocument doc);
            /*0x9a7134*/ bool get_IsEmpty();
            /*0x9a7144*/ void set_IsEmpty(bool value);
            /*0x9a7434*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x9a7444*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x9a744c*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x9a7470*/ System.Xml.XmlAttributeCollection get_Attributes();
            /*0x9a75b4*/ bool get_HasAttributes();
            /*0x9a75dc*/ string GetAttribute(string name);
            /*0x9a765c*/ void SetAttribute(string name, string value);
            /*0x9a7700*/ System.Xml.XmlAttribute GetAttributeNode(string name);
            /*0x9a7764*/ System.Xml.XmlAttribute SetAttributeNode(System.Xml.XmlAttribute newAttr);
            /*0x9a787c*/ string GetAttribute(string localName, string namespaceURI);
            /*0x9a7910*/ string SetAttribute(string localName, string namespaceURI, string value);
            /*0x9a7a14*/ System.Xml.XmlAttribute GetAttributeNode(string localName, string namespaceURI);
            /*0x9a7a80*/ System.Xml.XmlAttribute SetAttributeNode(string localName, string namespaceURI);
            /*0x9a7b5c*/ bool HasAttribute(string name);
            /*0x9a7b80*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x9a7e84*/ void WriteStartElement(System.Xml.XmlWriter w);
            /*0x9a7f9c*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x9a8004*/ void RemoveAllAttributes();
            /*0x9a803c*/ void RemoveAll();
            /*0x9a742c*/ void RemoveAllChildren();
            /*0x9a8064*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x9a806c*/ void set_InnerXml(string value);
            /*0x9a8160*/ string get_InnerText();
            /*0x9a8168*/ void set_InnerText(string value);
            /*0x9a8224*/ System.Xml.XmlNode get_NextSibling();
            /*0x9a8260*/ void SetParent(System.Xml.XmlNode node);
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

            /*0x9a8268*/ XmlEntity(string name, string strdata, string publicId, string systemId, string notationName, System.Xml.XmlDocument doc);
            /*0x9a82ec*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x9a834c*/ bool get_IsReadOnly();
            /*0x9a8354*/ string get_Name();
            /*0x9a835c*/ string get_LocalName();
            /*0x9a8364*/ string get_InnerText();
            /*0x9a836c*/ void set_InnerText(string value);
            /*0x9a83cc*/ bool get_IsContainer();
            /*0x9a83d4*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x9a84ac*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x9a84b4*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x9a84f0*/ System.Xml.XmlNodeType get_NodeType();
            /*0x9a84f8*/ string get_SystemId();
            /*0x9a8500*/ void set_InnerXml(string value);
            /*0x9a8560*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x9a8564*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x9a8568*/ string get_BaseURI();
            /*0x9a8570*/ void SetBaseURI(string inBaseURI);
        }

        class XmlEntityReference : System.Xml.XmlLinkedNode
        {
            /*0x20*/ string name;
            /*0x28*/ System.Xml.XmlLinkedNode lastChild;

            /*0x9a3f88*/ XmlEntityReference(string name, System.Xml.XmlDocument doc);
            /*0x9a8578*/ string get_Name();
            /*0x9a8580*/ string get_LocalName();
            /*0x9a8588*/ string get_Value();
            /*0x9a8590*/ void set_Value(string value);
            /*0x9a85f0*/ System.Xml.XmlNodeType get_NodeType();
            /*0x9a85f8*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x9a8630*/ bool get_IsReadOnly();
            /*0x9a8638*/ bool get_IsContainer();
            /*0x9a8640*/ void SetParent(System.Xml.XmlNode node);
            /*0x9a8d30*/ void SetParentForLoad(System.Xml.XmlNode node);
            /*0x9a8d40*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x9a8d48*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x9a8d50*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x9a8d74*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x9a8da0*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x9a909c*/ string get_BaseURI();
            /*0x9a90cc*/ string ConstructBaseURI(string baseURI, string systemId);
            /*0x9a91a0*/ string get_ChildBaseURI();
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

            /*0x9a1f68*/ XmlImplementation();
            /*0x9a2410*/ XmlImplementation(System.Xml.XmlNameTable nt);
            /*0x9a9270*/ System.Xml.XmlDocument CreateDocument();
            /*0x9a92d0*/ System.Xml.XmlNameTable get_NameTable();
        }

        class XmlLinkedNode : System.Xml.XmlNode
        {
            /*0x18*/ System.Xml.XmlLinkedNode next;

            /*0x9a0f7c*/ XmlLinkedNode(System.Xml.XmlDocument doc);
            /*0x9a92d8*/ System.Xml.XmlNode get_PreviousSibling();
            /*0x9a9340*/ System.Xml.XmlNode get_NextSibling();
        }

        class XmlLoader
        {
            /*0x10*/ System.Xml.XmlDocument doc;
            /*0x18*/ System.Xml.XmlReader reader;
            /*0x20*/ bool preserveWhitespace;

            static /*0x9a1c08*/ void ParseXmlDeclarationValue(string strValue, ref string version, ref string encoding, ref string standalone);
            static /*0x9aa210*/ System.Exception UnexpectedNodeType(System.Xml.XmlNodeType nodetype);
            /*0x99f320*/ XmlLoader();
            /*0x9a50ec*/ void Load(System.Xml.XmlDocument doc, System.Xml.XmlReader reader, bool preserveWhitespace);
            /*0x9a9390*/ void LoadDocSequence(System.Xml.XmlDocument parentDoc);
            /*0x9a4e54*/ System.Xml.XmlNode ReadCurrentNode(System.Xml.XmlDocument doc, System.Xml.XmlReader reader);
            /*0x9a93fc*/ System.Xml.XmlNode LoadNode(bool skipOverWhitespace);
            /*0x9a9990*/ System.Xml.XmlAttribute LoadAttributeNode();
            /*0x9aa328*/ System.Xml.XmlAttribute LoadDefaultAttribute();
            /*0x9aa4c0*/ void LoadAttributeValue(System.Xml.XmlNode parent, bool direct);
            /*0x9a9cbc*/ System.Xml.XmlEntityReference LoadEntityReferenceNode(bool direct);
            /*0x9a9eb0*/ System.Xml.XmlDeclaration LoadDeclarationNode();
            /*0x9aa064*/ System.Xml.XmlDocumentType LoadDocumentTypeNode();
            /*0x9aa7d8*/ System.Xml.XmlNode LoadNodeDirect();
            /*0x9ab790*/ System.Xml.XmlAttribute LoadAttributeNodeDirect();
            /*0x9a69c0*/ void ParseDocumentType(System.Xml.XmlDocumentType dtNode);
            /*0x9ab8d4*/ void ParseDocumentType(System.Xml.XmlDocumentType dtNode, bool bUseResolver, System.Xml.XmlResolver resolver);
            /*0x9aac60*/ void LoadDocumentType(System.Xml.IDtdInfo dtdInfo, System.Xml.XmlDocumentType dtNode);
            /*0x9abb9c*/ System.Xml.XmlParserContext GetContext(System.Xml.XmlNode node);
            /*0x9a62d0*/ System.Xml.XmlNamespaceManager ParsePartialContent(System.Xml.XmlNode parentNode, string innerxmltext, System.Xml.XmlNodeType nt);
            /*0x9a80ec*/ void LoadInnerXmlElement(System.Xml.XmlElement node, string innerxmltext);
            /*0x99f328*/ void LoadInnerXmlAttribute(System.Xml.XmlAttribute node, string innerxmltext);
            /*0x9ac6ec*/ void RemoveDuplicateNamespace(System.Xml.XmlElement elem, System.Xml.XmlNamespaceManager mgr, bool fCheckElemAttrs);
            /*0x9ac978*/ string EntitizeName(string name);
            /*0x9a8460*/ void ExpandEntity(System.Xml.XmlEntity ent);
            /*0x9a86fc*/ void ExpandEntityReference(System.Xml.XmlEntityReference eref);
            /*0x9ac470*/ System.Xml.XmlReader CreateInnerXmlReader(string xmlFragment, System.Xml.XmlNodeType nt, System.Xml.XmlParserContext context, System.Xml.XmlDocument doc);
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

            static /*0x981db0*/ System.Xml.XmlName Create(string prefix, string localName, string ns, int hashCode, System.Xml.XmlDocument ownerDoc, System.Xml.XmlName next, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            static /*0x9824e0*/ int GetHashCode(string name);
            /*0x981ea4*/ XmlName(string prefix, string localName, string ns, int hashCode, System.Xml.XmlDocument ownerDoc, System.Xml.XmlName next);
            /*0x9822c8*/ string get_LocalName();
            /*0x9822d0*/ string get_NamespaceURI();
            /*0x9822d8*/ string get_Prefix();
            /*0x9822e0*/ int get_HashCode();
            /*0x9822e8*/ System.Xml.XmlDocument get_OwnerDocument();
            /*0x9822f0*/ string get_Name();
            /*0x98249c*/ System.Xml.Schema.XmlSchemaValidity get_Validity();
            /*0x9824a4*/ bool get_IsDefault();
            /*0x9824ac*/ bool get_IsNil();
            /*0x9824b4*/ System.Xml.Schema.XmlSchemaSimpleType get_MemberType();
            /*0x9824bc*/ System.Xml.Schema.XmlSchemaType get_SchemaType();
            /*0x9824c4*/ System.Xml.Schema.XmlSchemaElement get_SchemaElement();
            /*0x9824cc*/ System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute();
            /*0x9824d4*/ bool Equals(System.Xml.Schema.IXmlSchemaInfo schemaInfo);
        }

        class XmlNameEx : System.Xml.XmlName
        {
            /*0x48*/ byte flags;
            /*0x50*/ System.Xml.Schema.XmlSchemaSimpleType memberType;
            /*0x58*/ System.Xml.Schema.XmlSchemaType schemaType;
            /*0x60*/ object decl;

            /*0x981efc*/ XmlNameEx(string prefix, string localName, string ns, int hashCode, System.Xml.XmlDocument ownerDoc, System.Xml.XmlName next, System.Xml.Schema.IXmlSchemaInfo schemaInfo);
            /*0x982590*/ System.Xml.Schema.XmlSchemaValidity get_Validity();
            /*0x9825c0*/ bool get_IsDefault();
            /*0x9825cc*/ bool get_IsNil();
            /*0x9825d8*/ System.Xml.Schema.XmlSchemaSimpleType get_MemberType();
            /*0x9825e0*/ System.Xml.Schema.XmlSchemaType get_SchemaType();
            /*0x9825e8*/ System.Xml.Schema.XmlSchemaElement get_SchemaElement();
            /*0x982664*/ System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute();
            /*0x982544*/ void SetValidity(System.Xml.Schema.XmlSchemaValidity value);
            /*0x982558*/ void SetIsDefault(bool value);
            /*0x982574*/ void SetIsNil(bool value);
            /*0x9826e0*/ bool Equals(System.Xml.Schema.IXmlSchemaInfo schemaInfo);
        }

        class XmlNamedNodeMap : System.Collections.IEnumerable
        {
            /*0x10*/ System.Xml.XmlNode parent;
            /*0x18*/ System.Xml.XmlNamedNodeMap.SmallXmlNodeList nodes;

            /*0x982ab4*/ XmlNamedNodeMap(System.Xml.XmlNode parent);
            /*0x982adc*/ System.Xml.XmlNode GetNamedItem(string name);
            /*0x982d38*/ System.Xml.XmlNode SetNamedItem(System.Xml.XmlNode node);
            /*0x982f6c*/ int get_Count();
            /*0x983018*/ System.Collections.IEnumerator GetEnumerator();
            /*0x982b74*/ int FindNodeOffset(string name);
            /*0x982df4*/ int FindNodeOffset(string localName, string namespaceURI);
            /*0x983120*/ System.Xml.XmlNode AddNode(System.Xml.XmlNode node);
            /*0x9833b4*/ System.Xml.XmlNode AddNodeForLoad(System.Xml.XmlNode node, System.Xml.XmlDocument doc);
            /*0x98345c*/ System.Xml.XmlNode RemoveNodeAt(int i);
            /*0x982f18*/ System.Xml.XmlNode ReplaceNodeAt(int i, System.Xml.XmlNode node);
            /*0x9836a8*/ System.Xml.XmlNode InsertNodeAt(int i, System.Xml.XmlNode node);

            struct SmallXmlNodeList
            {
                /*0x10*/ object field;

                /*0x982f74*/ int get_Count();
                /*0x982c58*/ object get_Item(int index);
                /*0x983298*/ void Add(object value);
                /*0x9835c4*/ void RemoveAt(int index);
                /*0x983828*/ void Insert(int index, object value);
                /*0x983020*/ System.Collections.IEnumerator GetEnumerator();

                class SingleObjectEnumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ object loneValue;
                    /*0x18*/ int position;

                    /*0x9839cc*/ SingleObjectEnumerator(object value);
                    /*0x9839fc*/ object get_Current();
                    /*0x983a50*/ bool MoveNext();
                    /*0x983a6c*/ void Reset();
                }
            }
        }

        class XmlNode : System.ICloneable, System.Collections.IEnumerable
        {
            /*0x10*/ System.Xml.XmlNode parentNode;

            static /*0x985560*/ bool HasReadOnlyParent(System.Xml.XmlNode n);
            static /*0x9860c8*/ void SplitName(string name, ref string prefix, ref string localName);
            static /*0x984414*/ void NestTextNodes(System.Xml.XmlNode prevNode, System.Xml.XmlNode nextNode);
            static /*0x98442c*/ void UnnestTextNodes(System.Xml.XmlNode prevNode, System.Xml.XmlNode nextNode);
            /*0x983a78*/ XmlNode();
            /*0x983a80*/ XmlNode(System.Xml.XmlDocument doc);
            string get_Name();
            /*0x983b04*/ string get_Value();
            /*0x983b0c*/ void set_Value(string value);
            System.Xml.XmlNodeType get_NodeType();
            /*0x983be0*/ System.Xml.XmlNode get_ParentNode();
            /*0x983ccc*/ System.Xml.XmlNodeList get_ChildNodes();
            /*0x983d30*/ System.Xml.XmlNode get_PreviousSibling();
            /*0x983d38*/ System.Xml.XmlNode get_NextSibling();
            /*0x983d40*/ System.Xml.XmlAttributeCollection get_Attributes();
            /*0x983d48*/ System.Xml.XmlDocument get_OwnerDocument();
            /*0x983e00*/ System.Xml.XmlNode get_FirstChild();
            /*0x983e24*/ System.Xml.XmlNode get_LastChild();
            /*0x983e34*/ bool get_IsContainer();
            /*0x983e3c*/ System.Xml.XmlLinkedNode get_LastNode();
            /*0x983e44*/ void set_LastNode(System.Xml.XmlLinkedNode value);
            /*0x983e48*/ bool AncestorNode(System.Xml.XmlNode node);
            /*0x983ea0*/ System.Xml.XmlNode InsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x984458*/ System.Xml.XmlNode InsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x9849b4*/ System.Xml.XmlNode RemoveChild(System.Xml.XmlNode oldChild);
            /*0x984d30*/ System.Xml.XmlNode PrependChild(System.Xml.XmlNode newChild);
            /*0x984d78*/ System.Xml.XmlNode AppendChild(System.Xml.XmlNode newChild);
            /*0x985230*/ System.Xml.XmlNode AppendChildForLoad(System.Xml.XmlNode newChild, System.Xml.XmlDocument doc);
            /*0x9853cc*/ bool IsValidChildType(System.Xml.XmlNodeType type);
            /*0x9853d4*/ bool CanInsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x9853dc*/ bool CanInsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x9853e4*/ bool get_HasChildNodes();
            System.Xml.XmlNode CloneNode(bool deep);
            /*0x985408*/ void CopyChildren(System.Xml.XmlDocument doc, System.Xml.XmlNode container, bool deep);
            /*0x9854a8*/ string get_NamespaceURI();
            /*0x9854f0*/ string get_Prefix();
            /*0x985538*/ void set_Prefix(string value);
            string get_LocalName();
            /*0x98553c*/ bool get_IsReadOnly();
            /*0x98562c*/ object System.ICloneable.Clone();
            /*0x985640*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x9856a4*/ System.Collections.IEnumerator GetEnumerator();
            /*0x985708*/ void AppendChildText(System.Text.StringBuilder builder);
            /*0x98580c*/ string get_InnerText();
            /*0x985914*/ void set_InnerText(string value);
            /*0x9859e4*/ void set_InnerXml(string value);
            /*0x985a44*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x985a9c*/ string get_BaseURI();
            void WriteTo(System.Xml.XmlWriter w);
            void WriteContentTo(System.Xml.XmlWriter w);
            /*0x985bc4*/ void RemoveAll();
            /*0x985c2c*/ System.Xml.XmlDocument get_Document();
            /*0x985cd8*/ string GetPrefixOfNamespace(string namespaceURI);
            /*0x985d38*/ string GetPrefixOfNamespaceStrict(string namespaceURI);
            /*0x986090*/ void SetParent(System.Xml.XmlNode node);
            /*0x9860c0*/ void SetParentForLoad(System.Xml.XmlNode node);
            /*0x986194*/ System.Xml.XmlNode FindChild(System.Xml.XmlNodeType type);
            /*0x9861f8*/ System.Xml.XmlNodeChangedEventArgs GetEventArgs(System.Xml.XmlNode node, System.Xml.XmlNode oldParent, System.Xml.XmlNode newParent, string oldValue, string newValue, System.Xml.XmlNodeChangedAction action);
            /*0x986324*/ void BeforeEvent(System.Xml.XmlNodeChangedEventArgs args);
            /*0x986368*/ void AfterEvent(System.Xml.XmlNodeChangedEventArgs args);
            /*0x9863ac*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x986524*/ string get_XmlLang();
            /*0x986628*/ bool get_IsText();
        }

        class XmlNodeChangedEventArgs : System.EventArgs
        {
            /*0x10*/ System.Xml.XmlNodeChangedAction action;
            /*0x18*/ System.Xml.XmlNode node;
            /*0x20*/ System.Xml.XmlNode oldParent;
            /*0x28*/ System.Xml.XmlNode newParent;
            /*0x30*/ string oldValue;
            /*0x38*/ string newValue;

            /*0x986630*/ XmlNodeChangedEventArgs(System.Xml.XmlNode node, System.Xml.XmlNode oldParent, System.Xml.XmlNode newParent, string oldValue, string newValue, System.Xml.XmlNodeChangedAction action);
            /*0x9866cc*/ System.Xml.XmlNodeChangedAction get_Action();
        }

        class XmlNodeChangedEventHandler : System.MulticastDelegate
        {
            /*0x9866d4*/ XmlNodeChangedEventHandler(object object, nint method);
            /*0x986804*/ void Invoke(object sender, System.Xml.XmlNodeChangedEventArgs e);
        }

        class XmlNodeList : System.Collections.IEnumerable, System.IDisposable
        {
            /*0x986834*/ XmlNodeList();
            System.Xml.XmlNode Item(int index);
            int get_Count();
            System.Collections.IEnumerator GetEnumerator();
            /*0x986818*/ System.Xml.XmlNode get_ItemOf(int i);
            /*0x986824*/ void System.IDisposable.Dispose();
            /*0x986830*/ void PrivateDisposeNodeList();
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

            /*0x98683c*/ XmlNodeReaderNavigator(System.Xml.XmlNode node);
            /*0x986a14*/ System.Xml.XmlNodeType get_NodeType();
            /*0x986a58*/ string get_NamespaceURI();
            /*0x986a7c*/ string get_Name();
            /*0x986b90*/ string get_LocalName();
            /*0x986c3c*/ bool get_CreatedOnAttribute();
            /*0x986b6c*/ bool IsLocalNameEmpty(System.Xml.XmlNodeType nt);
            /*0x986c44*/ string get_Prefix();
            /*0x986c68*/ string get_Value();
            /*0x987014*/ string get_BaseURI();
            /*0x987038*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x98705c*/ string get_XmlLang();
            /*0x987080*/ bool get_IsEmptyElement();
            /*0x98712c*/ bool get_IsDefault();
            /*0x987208*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x98722c*/ System.Xml.XmlNameTable get_NameTable();
            /*0x987234*/ int get_AttributeCount();
            /*0x98746c*/ void CheckIndexCondition(int attributeIndex);
            /*0x986ee0*/ void InitDecAttr();
            /*0x9874d8*/ string GetDeclarationAttr(System.Xml.XmlDeclaration decl, string name);
            /*0x9875b8*/ string GetDeclarationAttr(int i);
            /*0x98760c*/ int GetDecAttrInd(string name);
            /*0x987398*/ void InitDocTypeAttr();
            /*0x9876a4*/ string GetDocumentTypeAttr(System.Xml.XmlDocumentType docType, string name);
            /*0x987750*/ string GetDocumentTypeAttr(int i);
            /*0x9877a4*/ int GetDocTypeAttrInd(string name);
            /*0x98783c*/ string GetAttributeFromElement(System.Xml.XmlElement elem, string name);
            /*0x987880*/ string GetAttribute(string name);
            /*0x987a1c*/ string GetAttributeFromElement(System.Xml.XmlElement elem, string name, string ns);
            /*0x987a64*/ string GetAttribute(string name, string ns);
            /*0x987c34*/ string GetAttribute(int attributeIndex);
            /*0x987e08*/ void LogMove(int level);
            /*0x987e2c*/ void RollBackMove(ref int level);
            /*0x987e58*/ bool get_IsOnDeclOrDocType();
            /*0x987e90*/ void ResetToAttribute(ref int level);
            /*0x987f28*/ void ResetMove(ref int level, ref System.Xml.XmlNodeType nt);
            /*0x9880f4*/ bool MoveToAttribute(string name);
            /*0x9882ac*/ bool MoveToAttributeFromElement(System.Xml.XmlElement elem, string name, string ns);
            /*0x988154*/ bool MoveToAttribute(string name, string namespaceURI);
            /*0x988364*/ void MoveToAttribute(int attributeIndex);
            /*0x988530*/ bool MoveToNextAttribute(ref int level);
            /*0x9886f4*/ bool MoveToParent();
            /*0x988734*/ bool MoveToFirstChild();
            /*0x98877c*/ bool MoveToNextSibling(System.Xml.XmlNode node);
            /*0x9887c8*/ bool MoveToNext();
            /*0x988808*/ bool MoveToElement();
            /*0x988888*/ string LookupNamespace(string prefix);
            /*0x988b34*/ string DefaultLookupNamespace(string prefix);
            /*0x988c6c*/ string LookupPrefix(string namespaceName);
            /*0x989030*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x9894e4*/ bool ReadAttributeValue(ref int level, ref bool bResolveEntity, ref System.Xml.XmlNodeType nt);
            /*0x9896a4*/ System.Xml.XmlDocument get_Document();

            struct VirtualAttribute
            {
                /*0x10*/ string name;
                /*0x18*/ string value;

                /*0x986a0c*/ VirtualAttribute(string name, string value);
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

            /*0x9896ac*/ XmlNodeReader(System.Xml.XmlNode node);
            /*0x98979c*/ bool IsInReadingStates();
            /*0x9897ac*/ System.Xml.XmlNodeType get_NodeType();
            /*0x9897c8*/ string get_Name();
            /*0x989838*/ string get_LocalName();
            /*0x9898a8*/ string get_NamespaceURI();
            /*0x98992c*/ string get_Prefix();
            /*0x9899b0*/ string get_Value();
            /*0x989a20*/ int get_Depth();
            /*0x989a28*/ string get_BaseURI();
            /*0x989a54*/ bool get_CanResolveEntity();
            /*0x989a5c*/ bool get_IsEmptyElement();
            /*0x989a8c*/ bool get_IsDefault();
            /*0x989abc*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x989b00*/ string get_XmlLang();
            /*0x989b84*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            /*0x989bc8*/ int get_AttributeCount();
            /*0x989c04*/ string GetAttribute(string name);
            /*0x989c34*/ string GetAttribute(string name, string namespaceURI);
            /*0x989cc8*/ string GetAttribute(int attributeIndex);
            /*0x989d38*/ bool MoveToAttribute(string name);
            /*0x989e24*/ void MoveToAttribute(int attributeIndex);
            /*0x98a008*/ bool MoveToFirstAttribute();
            /*0x98a0e0*/ bool MoveToNextAttribute();
            /*0x98a1c0*/ bool MoveToElement();
            /*0x98a2a0*/ bool Read();
            /*0x98a2a8*/ bool Read(bool fSkipChildren);
            /*0x98a3ac*/ bool ReadNextNode(bool fSkipChildren);
            /*0x98a660*/ void SetEndOfFile();
            /*0x98a678*/ bool ReadAtZeroLevel(bool fSkipChildren);
            /*0x98a57c*/ bool ReadForward(bool fSkipChildren);
            /*0x98a558*/ void ReSetReadingMarks();
            /*0x98a6e8*/ bool get_EOF();
            /*0x98a70c*/ void Close();
            /*0x98a718*/ System.Xml.ReadState get_ReadState();
            /*0x98a720*/ void Skip();
            /*0x98a728*/ string ReadString();
            /*0x98a7d4*/ bool get_HasAttributes();
            /*0x98a7f8*/ System.Xml.XmlNameTable get_NameTable();
            /*0x98a814*/ string LookupNamespace(string prefix);
            /*0x98a84c*/ void ResolveEntity();
            /*0x98a8d8*/ bool ReadAttributeValue();
            /*0x989e00*/ void FinishReadBinary();
            /*0x98a924*/ System.Collections.Generic.IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0x98a93c*/ string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName);
            /*0x98a954*/ string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix);
            /*0x98a9b0*/ System.Xml.IDtdInfo get_DtdInfo();
        }

        class XmlNotation : System.Xml.XmlNode
        {
            /*0x18*/ string publicId;
            /*0x20*/ string systemId;
            /*0x28*/ string name;

            /*0x98a9d4*/ XmlNotation(string name, string publicId, string systemId, System.Xml.XmlDocument doc);
            /*0x98aa3c*/ string get_Name();
            /*0x98aa44*/ string get_LocalName();
            /*0x98aa4c*/ System.Xml.XmlNodeType get_NodeType();
            /*0x98aa54*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x98aab4*/ bool get_IsReadOnly();
            /*0x98aabc*/ void set_InnerXml(string value);
            /*0x98ab1c*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x98ab20*/ void WriteContentTo(System.Xml.XmlWriter w);
        }

        class XmlProcessingInstruction : System.Xml.XmlLinkedNode
        {
            /*0x20*/ string target;
            /*0x28*/ string data;

            /*0x98ab24*/ XmlProcessingInstruction(string target, string data, System.Xml.XmlDocument doc);
            /*0x98ab54*/ string get_Name();
            /*0x98aba8*/ string get_LocalName();
            /*0x98abb4*/ string get_Value();
            /*0x98abbc*/ void set_Value(string value);
            /*0x98abc0*/ void set_Data(string value);
            /*0x98ac60*/ string get_InnerText();
            /*0x98ac68*/ void set_InnerText(string value);
            /*0x98ac6c*/ System.Xml.XmlNodeType get_NodeType();
            /*0x98ac74*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x98acac*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x98acd8*/ void WriteContentTo(System.Xml.XmlWriter w);
        }

        class XmlSignificantWhitespace : System.Xml.XmlCharacterData
        {
            /*0x98acdc*/ XmlSignificantWhitespace(string strData, System.Xml.XmlDocument doc);
            /*0x98ad80*/ string get_Name();
            /*0x98ada8*/ string get_LocalName();
            /*0x98add0*/ System.Xml.XmlNodeType get_NodeType();
            /*0x98add8*/ System.Xml.XmlNode get_ParentNode();
            /*0x98ae60*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x98aebc*/ string get_Value();
            /*0x98aecc*/ void set_Value(string value);
            /*0x98af60*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x98afa0*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x98afa4*/ bool get_IsText();
        }

        class XmlText : System.Xml.XmlCharacterData
        {
            /*0x98afac*/ XmlText(string strData);
            /*0x98afb8*/ XmlText(string strData, System.Xml.XmlDocument doc);
            /*0x98afc0*/ string get_Name();
            /*0x98afe8*/ string get_LocalName();
            /*0x98b010*/ System.Xml.XmlNodeType get_NodeType();
            /*0x98b018*/ System.Xml.XmlNode get_ParentNode();
            /*0x98b09c*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x98b0f8*/ string get_Value();
            /*0x98b108*/ void set_Value(string value);
            /*0x98b1dc*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x98b21c*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x98b220*/ bool get_IsText();
        }

        class XmlUnspecifiedAttribute : System.Xml.XmlAttribute
        {
            /*0x28*/ bool fSpecified;

            /*0x98b228*/ XmlUnspecifiedAttribute(string prefix, string localName, string namespaceURI, System.Xml.XmlDocument doc);
            /*0x98b230*/ bool get_Specified();
            /*0x98b238*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x98b368*/ void set_InnerText(string value);
            /*0x98b388*/ System.Xml.XmlNode InsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x98b3a8*/ System.Xml.XmlNode InsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild);
            /*0x98b3c8*/ System.Xml.XmlNode RemoveChild(System.Xml.XmlNode oldChild);
            /*0x98b3e8*/ System.Xml.XmlNode AppendChild(System.Xml.XmlNode newChild);
            /*0x98b408*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x98b41c*/ void SetSpecified(bool f);
        }

        class XmlWhitespace : System.Xml.XmlCharacterData
        {
            /*0x98b428*/ XmlWhitespace(string strData, System.Xml.XmlDocument doc);
            /*0x98b4cc*/ string get_Name();
            /*0x98b4f4*/ string get_LocalName();
            /*0x98b51c*/ System.Xml.XmlNodeType get_NodeType();
            /*0x98b524*/ System.Xml.XmlNode get_ParentNode();
            /*0x98b5ac*/ string get_Value();
            /*0x98b5bc*/ void set_Value(string value);
            /*0x98b650*/ System.Xml.XmlNode CloneNode(bool deep);
            /*0x98b6ac*/ void WriteTo(System.Xml.XmlWriter w);
            /*0x98b6ec*/ void WriteContentTo(System.Xml.XmlWriter w);
            /*0x98b6f0*/ bool get_IsText();
        }

        class EmptyEnumerator : System.Collections.IEnumerator
        {
            /*0x98b764*/ EmptyEnumerator();
            /*0x98b6f8*/ bool System.Collections.IEnumerator.MoveNext();
            /*0x98b700*/ void System.Collections.IEnumerator.Reset();
            /*0x98b704*/ object System.Collections.IEnumerator.get_Current();
        }

        class HWStack : System.ICloneable
        {
            /*0x10*/ object[] stack;
            /*0x18*/ int growthRate;
            /*0x1c*/ int used;
            /*0x20*/ int size;
            /*0x24*/ int limit;

            /*0x98b76c*/ HWStack(int GrowthRate);
            /*0x98b774*/ HWStack(int GrowthRate, int limit);
            /*0x98bb50*/ HWStack(object[] stack, int growthRate, int used, int size);
            /*0x98b7e8*/ object Push();
            /*0x98b924*/ object Pop();
            /*0x98b96c*/ object Peek();
            /*0x98b9b0*/ void AddToTop(object o);
            /*0x98ba1c*/ object get_Item(int index);
            /*0x98ba98*/ void set_Item(int index, object value);
            /*0x98bb48*/ int get_Length();
            /*0x98bb94*/ object Clone();
        }

        interface IXmlLineInfo
        {
            bool HasLineInfo();
            int get_LineNumber();
            int get_LinePosition();
        }

        class PositionInfo : System.Xml.IXmlLineInfo
        {
            static /*0x98bc88*/ System.Xml.PositionInfo GetPositionInfo(object o);
            /*0x98bd6c*/ PositionInfo();
            /*0x98bc70*/ bool HasLineInfo();
            /*0x98bc78*/ int get_LineNumber();
            /*0x98bc80*/ int get_LinePosition();
        }

        class ReaderPositionInfo : System.Xml.PositionInfo
        {
            /*0x10*/ System.Xml.IXmlLineInfo lineInfo;

            /*0x98bd44*/ ReaderPositionInfo(System.Xml.IXmlLineInfo lineInfo);
            /*0x98bd74*/ bool HasLineInfo();
            /*0x98be14*/ int get_LineNumber();
            /*0x98beb8*/ int get_LinePosition();
        }

        interface IXmlNamespaceResolver
        {
            System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            string LookupNamespace(string prefix);
            string LookupPrefix(string namespaceName);
        }

        struct LineInfo
        {
            /*0x10*/ int lineNo;
            /*0x14*/ int linePos;

            /*0x98bf5c*/ LineInfo(int lineNo, int linePos);
            /*0x98bf64*/ void Set(int lineNo, int linePos);
        }

        class NameTable : System.Xml.XmlNameTable
        {
            /*0x10*/ System.Xml.NameTable.Entry[] entries;
            /*0x18*/ int count;
            /*0x1c*/ int mask;
            /*0x20*/ int hashCodeRandomizer;

            static /*0x98c3d8*/ bool TextEquals(string str1, char[] str2, int str2Start, int str2Length);
            /*0x98bf6c*/ NameTable();
            /*0x98bfdc*/ string Add(string key);
            /*0x98c260*/ string Add(char[] key, int start, int len);
            /*0x98c488*/ string Get(string value);
            /*0x98c158*/ string AddEntry(string str, int hashCode);
            /*0x98c630*/ void Grow();

            class Entry
            {
                /*0x10*/ string str;
                /*0x18*/ int hashCode;
                /*0x20*/ System.Xml.NameTable.Entry next;

                /*0x98c5f0*/ Entry(string str, int hashCode, System.Xml.NameTable.Entry next);
            }
        }

        class Ref
        {
            static /*0x986084*/ bool Equal(string strA, string strB);
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

            static /*0x98c7dc*/ System.Xml.IDtdParser Create();
            static /*0x9961b4*/ string StripSpaces(string value);
            /*0x98c754*/ DtdParser();
            /*0x98c834*/ void Initialize(System.Xml.IDtdParserAdapter readerAdapter);
            /*0x98cc04*/ void InitializeFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, System.Xml.IDtdParserAdapter adapter);
            /*0x98d050*/ System.Xml.IDtdInfo System.Xml.IDtdParser.ParseInternalDtd(System.Xml.IDtdParserAdapter adapter, bool saveInternalSubset);
            /*0x98d2dc*/ System.Xml.IDtdInfo System.Xml.IDtdParser.ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, System.Xml.IDtdParserAdapter adapter);
            /*0x98d300*/ bool get_ParsingInternalSubset();
            /*0x98d310*/ bool get_IgnoreEntityReferences();
            /*0x98d320*/ bool get_SaveInternalSubsetValue();
            /*0x98d3e0*/ bool get_ParsingTopLevelMarkup();
            /*0x98d410*/ bool get_SupportNamespaces();
            /*0x98d418*/ bool get_Normalize();
            /*0x98d080*/ void Parse(bool saveInternalSubset);
            /*0x98d474*/ void ParseInDocumentDtd(bool saveInternalSubset);
            /*0x98d420*/ void ParseFreeFloatingDtd();
            /*0x98e92c*/ void ParseInternalSubset();
            /*0x98e930*/ void ParseExternalSubset();
            /*0x98ead4*/ void ParseSubset();
            /*0x98ee30*/ void ParseAttlistDecl();
            /*0x990864*/ void ParseAttlistType(System.Xml.Schema.SchemaAttDef attrDef, System.Xml.Schema.SchemaElementDecl elementDecl, bool ignoreErrors);
            /*0x990dc0*/ void ParseAttlistDefault(System.Xml.Schema.SchemaAttDef attrDef, bool ignoreErrors);
            /*0x98f3f8*/ void ParseElementDecl();
            /*0x991540*/ void ParseElementOnlyContent(System.Xml.Schema.ParticleContentValidator pcv, int startParenEntityId);
            /*0x991890*/ void ParseHowMany(System.Xml.Schema.ParticleContentValidator pcv);
            /*0x99129c*/ void ParseElementMixedContent(System.Xml.Schema.ParticleContentValidator pcv, int startParenEntityId);
            /*0x98f78c*/ void ParseEntityDecl();
            /*0x98fae8*/ void ParseNotationDecl();
            /*0x991064*/ void AddUndeclaredNotation(string notationName);
            /*0x98fcdc*/ void ParseComment();
            /*0x98ff20*/ void ParsePI();
            /*0x9900ec*/ void ParseCondSection();
            /*0x98e410*/ void ParseExternalId(System.Xml.DtdParser.Token idTokenType, System.Xml.DtdParser.Token declType, ref string publicId, ref string systemId);
            /*0x98d9a8*/ System.Xml.DtdParser.Token GetToken(bool needWhiteSpace);
            /*0x992070*/ System.Xml.DtdParser.Token ScanSubsetContent();
            /*0x992008*/ System.Xml.DtdParser.Token ScanNameExpected();
            /*0x99202c*/ System.Xml.DtdParser.Token ScanQNameExpected();
            /*0x992050*/ System.Xml.DtdParser.Token ScanNmtokenExpected();
            /*0x992774*/ System.Xml.DtdParser.Token ScanDoctype1();
            /*0x992890*/ System.Xml.DtdParser.Token ScanDoctype2();
            /*0x994ac4*/ System.Xml.DtdParser.Token ScanClosingTag();
            /*0x992938*/ System.Xml.DtdParser.Token ScanElement1();
            /*0x992b08*/ System.Xml.DtdParser.Token ScanElement2();
            /*0x992cac*/ System.Xml.DtdParser.Token ScanElement3();
            /*0x992d2c*/ System.Xml.DtdParser.Token ScanElement4();
            /*0x992df8*/ System.Xml.DtdParser.Token ScanElement5();
            /*0x992ee4*/ System.Xml.DtdParser.Token ScanElement6();
            /*0x992fb4*/ System.Xml.DtdParser.Token ScanElement7();
            /*0x993014*/ System.Xml.DtdParser.Token ScanAttlist1();
            /*0x9930d8*/ System.Xml.DtdParser.Token ScanAttlist2();
            /*0x993758*/ System.Xml.DtdParser.Token ScanAttlist3();
            /*0x9937f8*/ System.Xml.DtdParser.Token ScanAttlist4();
            /*0x9938c8*/ System.Xml.DtdParser.Token ScanAttlist5();
            /*0x993998*/ System.Xml.DtdParser.Token ScanAttlist6();
            /*0x993d0c*/ System.Xml.DtdParser.Token ScanAttlist7();
            /*0x995108*/ System.Xml.DtdParser.Token ScanLiteral(System.Xml.DtdParser.LiteralType literalType);
            /*0x995b90*/ System.Xml.XmlQualifiedName ScanEntityName();
            /*0x993dc8*/ System.Xml.DtdParser.Token ScanNotation1();
            /*0x993ec0*/ System.Xml.DtdParser.Token ScanSystemId();
            /*0x994090*/ System.Xml.DtdParser.Token ScanEntity1();
            /*0x994104*/ System.Xml.DtdParser.Token ScanEntity2();
            /*0x994230*/ System.Xml.DtdParser.Token ScanEntity3();
            /*0x993f74*/ System.Xml.DtdParser.Token ScanPublicId1();
            /*0x994028*/ System.Xml.DtdParser.Token ScanPublicId2();
            /*0x994344*/ System.Xml.DtdParser.Token ScanCondSection1();
            /*0x9945e0*/ System.Xml.DtdParser.Token ScanCondSection2();
            /*0x994678*/ System.Xml.DtdParser.Token ScanCondSection3();
            /*0x994dc4*/ void ScanName();
            /*0x994dcc*/ void ScanQName();
            /*0x995ef0*/ void ScanQName(bool isQName);
            /*0x996170*/ bool ReadDataInName();
            /*0x994dd4*/ void ScanNmtoken();
            /*0x994f40*/ bool EatPublicKeyword();
            /*0x995024*/ bool EatSystemKeyword();
            /*0x98e2a0*/ System.Xml.XmlQualifiedName GetNameQualified(bool canHavePrefix);
            /*0x991048*/ string GetNameString();
            /*0x9911c4*/ string GetNmtokenString();
            /*0x991240*/ string GetValue();
            /*0x9911e0*/ string GetValueWithStrippedSpaces();
            /*0x994b58*/ int ReadData();
            /*0x98d82c*/ void LoadParsingBuffer();
            /*0x98e924*/ void SaveParsingBuffer();
            /*0x9903ec*/ void SaveParsingBuffer(int internalSubsetValueEndPos);
            /*0x991efc*/ bool HandleEntityReference(bool paramEntity, bool inLiteral, bool inAttribute);
            /*0x9963dc*/ bool HandleEntityReference(System.Xml.XmlQualifiedName entityName, bool paramEntity, bool inLiteral, bool inAttribute);
            /*0x994c1c*/ bool HandleEntityEnd(bool inLiteral);
            /*0x995cf0*/ System.Xml.Schema.SchemaEntity VerifyEntityReference(System.Xml.XmlQualifiedName entityName, bool paramEntity, bool mustBeDeclared, bool inAttribute);
            /*0x990310*/ void SendValidationEvent(int pos, System.Xml.Schema.XmlSeverityType severity, string code, string arg);
            /*0x990f80*/ void SendValidationEvent(System.Xml.Schema.XmlSeverityType severity, string code, string arg);
            /*0x98d6e8*/ void SendValidationEvent(System.Xml.Schema.XmlSeverityType severity, System.Xml.Schema.XmlSchemaException e);
            /*0x990f74*/ bool IsAttributeValueType(System.Xml.DtdParser.Token token);
            /*0x990540*/ int get_LineNo();
            /*0x9905e4*/ int get_LinePos();
            /*0x98d5c4*/ string get_BaseUriStr();
            /*0x98e254*/ void OnUnexpectedError();
            /*0x990084*/ void Throw(int curPos, string res);
            /*0x991900*/ void Throw(int curPos, string res, string arg);
            /*0x991c94*/ void Throw(int curPos, string res, string[] args);
            /*0x990694*/ void Throw(string res, string arg, int lineNo, int linePos);
            /*0x98cfd4*/ void ThrowInvalidChar(int pos, string data, int invCharPos);
            /*0x991e7c*/ void ThrowInvalidChar(char[] data, int length, int invCharPos);
            /*0x990538*/ void ThrowUnexpectedToken(int pos, string expectedToken);
            /*0x991ae8*/ void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2);
            /*0x991f4c*/ string ParseUnexpectedToken(int startPos);

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

                /*0xb5f4a0*/ UndeclaredNotation(string name, int lineNo, int linePos);
            }

            class ParseElementOnlyContent_LocalFrame
            {
                /*0x10*/ int startParenEntityId;
                /*0x14*/ System.Xml.DtdParser.Token parsingSchema;

                /*0xb5f4e0*/ ParseElementOnlyContent_LocalFrame(int startParentEntityIdParam);
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

            static /*0xb60588*/ ValidateNames();
            static /*0xb5f50c*/ int ParseNmtoken(string s, int offset);
            static /*0xb5f5d4*/ int ParseNmtokenNoNamespaces(string s, int offset);
            static /*0xb5f6b8*/ int ParseNameNoNamespaces(string s, int offset);
            static /*0xb5f810*/ bool IsNameNoNamespaces(string s);
            static /*0xb5f890*/ int ParseNCName(string s, int offset);
            static /*0xb5f9ac*/ int ParseNCName(string s);
            static /*0xb5fa04*/ int ParseQName(string s, int offset, ref int colonOffset);
            static /*0xb5fae0*/ void ParseQNameThrow(string s, ref string prefix, ref string localName);
            static /*0xb5fbec*/ void ThrowInvalidName(string s, int offsetStartChar, int offsetBadChar);
            static /*0xb5ffc4*/ System.Exception GetInvalidNameException(string s, int offsetStartChar, int offsetBadChar);
            static /*0xb60184*/ void SplitQName(string name, ref string prefix, ref string lname);
        }

        struct XmlCharType
        {
            static /*0x0*/ object s_Lock;
            static /*0x8*/ byte[] s_CharProperties;
            /*0x10*/ byte[] charProperties;

            static /*0xb605d4*/ object get_StaticLock();
            static /*0xb60670*/ void InitInstance();
            static /*0xb608d0*/ void SetProperties(byte[] chProps, string ranges, byte value);
            static /*0xb5fe70*/ System.Xml.XmlCharType get_Instance();
            static /*0xb60b90*/ bool IsDigit(char ch);
            static /*0xb60bb8*/ bool IsHighSurrogate(int ch);
            static /*0xb60bc8*/ bool IsLowSurrogate(int ch);
            static /*0xb60bd8*/ bool IsSurrogate(int ch);
            static /*0xb60be8*/ int CombineSurrogateChar(int lowChar, int highChar);
            static /*0xb60c00*/ void SplitSurrogateChar(int combinedChar, ref char lowChar, ref char highChar);
            static /*0xb60db0*/ bool IsOnlyDigits(string str, int startPos, int len);
            static /*0xb60ba4*/ bool InRange(int value, int start, int end);
            /*0xb60994*/ XmlCharType(byte[] charProperties);
            /*0xb6099c*/ bool IsWhiteSpace(char ch);
            /*0xb5fe3c*/ bool IsNCNameSingleChar(char ch);
            /*0xb5fed8*/ bool IsStartNCNameSingleChar(char ch);
            /*0xb609d0*/ bool IsNameSingleChar(char ch);
            /*0xb609f4*/ bool IsCharData(char ch);
            /*0xb60a28*/ bool IsPubidChar(char ch);
            /*0xb60aac*/ bool IsTextChar(char ch);
            /*0xb60ae0*/ bool IsLetter(char ch);
            /*0xb60b14*/ bool IsNCNameCharXml4e(char ch);
            /*0xb60b48*/ bool IsStartNCNameCharXml4e(char ch);
            /*0xb60b6c*/ bool IsNameCharXml4e(char ch);
            /*0xb60c38*/ bool IsOnlyWhitespace(string str);
            /*0xb60c50*/ int IsOnlyWhitespaceWithPos(string str);
            /*0xb60cd8*/ int IsOnlyCharData(string str);
            /*0xb60e1c*/ int IsPublicId(string str);
        }

        class XmlComplianceUtil
        {
            static /*0xb60e7c*/ string NonCDataNormalize(string value);
            static /*0xb61108*/ string CDataNormalize(string value);
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

            static /*0xb67e6c*/ XmlConvert();
            static /*0xb612ec*/ string EncodeName(string name);
            static /*0xb61d14*/ string EncodeLocalName(string name);
            static /*0xb61d70*/ string DecodeName(string name);
            static /*0xb61348*/ string EncodeName(string name, bool first, bool local);
            static /*0xb62698*/ int FromHex(char digit);
            static /*0xb626c8*/ byte[] FromBinHexString(string s);
            static /*0xb62720*/ byte[] FromBinHexString(string s, bool allowOddCount);
            static /*0xb62790*/ string ToBinHexString(byte[] inArray);
            static /*0xb627f8*/ string VerifyName(string name);
            static /*0xb62a14*/ System.Exception TryVerifyName(string name);
            static /*0xb62b70*/ string VerifyQName(string name, System.Xml.ExceptionType exceptionType);
            static /*0xb62d7c*/ string VerifyNCName(string name);
            static /*0xb62dd4*/ string VerifyNCName(string name, System.Xml.ExceptionType exceptionType);
            static /*0xb62f2c*/ System.Exception TryVerifyNCName(string name);
            static /*0xb62fcc*/ string VerifyTOKEN(string token);
            static /*0xb63104*/ System.Exception TryVerifyTOKEN(string token);
            static /*0xb63240*/ System.Exception TryVerifyNMTOKEN(string name);
            static /*0xb63370*/ System.Exception TryVerifyNormalizedString(string str);
            static /*0xb6343c*/ string ToString(bool value);
            static /*0xb634a4*/ string ToString(char value);
            static /*0xb634c4*/ string ToString(decimal value);
            static /*0xb63518*/ string ToString(sbyte value);
            static /*0xb63544*/ string ToString(short value);
            static /*0xb63570*/ string ToString(int value);
            static /*0xb6359c*/ string ToString(long value);
            static /*0xb635c8*/ string ToString(byte value);
            static /*0xb635f4*/ string ToString(ushort value);
            static /*0xb63620*/ string ToString(uint value);
            static /*0xb6364c*/ string ToString(ulong value);
            static /*0xb63678*/ string ToString(float value);
            static /*0xb637e8*/ string ToString(double value);
            static /*0xb638e4*/ string ToString(System.TimeSpan value);
            static /*0xb6393c*/ string ToString(System.DateTime value, string format);
            static /*0xb639b4*/ string ToString(System.DateTime value, System.Xml.XmlDateTimeSerializationMode dateTimeOption);
            static /*0xb63c84*/ string ToString(System.DateTimeOffset value);
            static /*0xb63cbc*/ string ToString(System.Guid value);
            static /*0xb63ce0*/ bool ToBoolean(string s);
            static /*0xb63f1c*/ System.Exception TryToBoolean(string s, ref bool result);
            static /*0xb64140*/ char ToChar(string s);
            static /*0xb64208*/ System.Exception TryToChar(string s, ref char result);
            static /*0xb6437c*/ decimal ToDecimal(string s);
            static /*0xb643ec*/ System.Exception TryToDecimal(string s, ref decimal result);
            static /*0xb64578*/ decimal ToInteger(string s);
            static /*0xb645e8*/ System.Exception TryToInteger(string s, ref decimal result);
            static /*0xb64774*/ sbyte ToSByte(string s);
            static /*0xb6479c*/ System.Exception TryToSByte(string s, ref sbyte result);
            static /*0xb648f4*/ short ToInt16(string s);
            static /*0xb6491c*/ System.Exception TryToInt16(string s, ref short result);
            static /*0xb64a74*/ int ToInt32(string s);
            static /*0xb64a9c*/ System.Exception TryToInt32(string s, ref int result);
            static /*0xb64bf4*/ long ToInt64(string s);
            static /*0xb64c1c*/ System.Exception TryToInt64(string s, ref long result);
            static /*0xb64d74*/ byte ToByte(string s);
            static /*0xb64d9c*/ System.Exception TryToByte(string s, ref byte result);
            static /*0xb64ef4*/ ushort ToUInt16(string s);
            static /*0xb64f1c*/ System.Exception TryToUInt16(string s, ref ushort result);
            static /*0xb65074*/ uint ToUInt32(string s);
            static /*0xb6509c*/ System.Exception TryToUInt32(string s, ref uint result);
            static /*0xb651f4*/ ulong ToUInt64(string s);
            static /*0xb6521c*/ System.Exception TryToUInt64(string s, ref ulong result);
            static /*0xb65374*/ float ToSingle(string s);
            static /*0xb6548c*/ System.Exception TryToSingle(string s, ref float result);
            static /*0xb656c4*/ double ToDouble(string s);
            static /*0xb657dc*/ System.Exception TryToDouble(string s, ref double result);
            static /*0xb65a14*/ double ToXPathDouble(object o);
            static /*0xb65c68*/ System.TimeSpan ToTimeSpan(string s);
            static /*0xb65e04*/ System.Exception TryToTimeSpan(string s, ref System.TimeSpan result);
            static /*0xb65eb0*/ string[] get_AllDateTimeFormats();
            static /*0xb65f48*/ void CreateAllDateTimeFormats();
            static /*0xb6660c*/ System.DateTime ToDateTime(string s);
            static /*0xb66668*/ System.DateTime ToDateTime(string s, string[] formats);
            static /*0xb6670c*/ System.DateTime ToDateTime(string s, System.Xml.XmlDateTimeSerializationMode dateTimeOption);
            static /*0xb6692c*/ System.DateTimeOffset ToDateTimeOffset(string s);
            static /*0xb669f8*/ System.Guid ToGuid(string s);
            static /*0xb66a24*/ System.Exception TryToGuid(string s, ref System.Guid result);
            static /*0xb63b9c*/ System.DateTime SwitchToLocalTime(System.DateTime value);
            static /*0xb63c10*/ System.DateTime SwitchToUtcTime(System.DateTime value);
            static /*0xb66c08*/ System.Uri ToUri(string s);
            static /*0xb66dc4*/ System.Exception TryToUri(string s, ref System.Uri result);
            static /*0xb66fdc*/ bool StrEqual(char[] chars, int strPos1, int strLen1, string str2);
            static /*0xb63eb0*/ string TrimString(string value);
            static /*0xb670a4*/ string TrimStringStart(string value);
            static /*0xb67110*/ string TrimStringEnd(string value);
            static /*0xb6717c*/ string[] SplitString(string value);
            static /*0xb63774*/ bool IsNegativeZero(double value);
            static /*0xb671ec*/ long DoubleToInt64Bits(double value);
            static /*0xb671f4*/ void VerifyCharData(string data, System.Xml.ExceptionType invCharExceptionType, System.Xml.ExceptionType invSurrogateExceptionType);
            static /*0xb673e4*/ System.Exception CreateException(string res, System.Xml.ExceptionType exceptionType, int lineNo, int linePos);
            static /*0xb677fc*/ System.Exception CreateException(string res, string arg, System.Xml.ExceptionType exceptionType, int lineNo, int linePos);
            static /*0xb67934*/ System.Exception CreateException(string res, string[] args, System.Xml.ExceptionType exceptionType);
            static /*0xb62ca0*/ System.Exception CreateException(string res, string[] args, System.Xml.ExceptionType exceptionType, int lineNo, int linePos);
            static /*0xb67a18*/ System.Exception CreateInvalidSurrogatePairException(char low, char hi);
            static /*0xb67a80*/ System.Exception CreateInvalidSurrogatePairException(char low, char hi, System.Xml.ExceptionType exceptionType);
            static /*0xb674bc*/ System.Exception CreateInvalidSurrogatePairException(char low, char hi, System.Xml.ExceptionType exceptionType, int lineNo, int linePos);
            static /*0xb67af4*/ System.Exception CreateInvalidHighSurrogateCharException(char hi);
            static /*0xb67b4c*/ System.Exception CreateInvalidHighSurrogateCharException(char hi, System.Xml.ExceptionType exceptionType);
            static /*0xb67bb8*/ System.Exception CreateInvalidHighSurrogateCharException(char hi, System.Xml.ExceptionType exceptionType, int lineNo, int linePos);
            static /*0xb67674*/ System.Exception CreateInvalidCharException(string data, int invCharPos, System.Xml.ExceptionType exceptionType);
            static /*0xb67cb4*/ System.Exception CreateInvalidCharException(char invChar, char nextChar);
            static /*0xb67d1c*/ System.Exception CreateInvalidCharException(char invChar, char nextChar, System.Xml.ExceptionType exceptionType);
            static /*0xb62950*/ System.Exception CreateInvalidNameCharException(string name, int index, System.Xml.ExceptionType exceptionType);
            static /*0xb67db0*/ System.ArgumentException CreateInvalidNameArgumentException(string name, string argumentName);
        }

        class XmlDownloadManager
        {
            /*0x10*/ System.Collections.Hashtable connections;

            /*0xb68ad4*/ XmlDownloadManager();
            /*0xb67f54*/ System.IO.Stream GetStream(System.Uri uri, System.Net.ICredentials credentials, System.Net.IWebProxy proxy, System.Net.Cache.RequestCachePolicy cachePolicy);
            /*0xb68058*/ System.IO.Stream GetNonFileStream(System.Uri uri, System.Net.ICredentials credentials, System.Net.IWebProxy proxy, System.Net.Cache.RequestCachePolicy cachePolicy);
            /*0xb686e4*/ void Remove(string host);
            /*0xb68850*/ System.Threading.Tasks.Task<System.IO.Stream> GetStreamAsync(System.Uri uri, System.Net.ICredentials credentials, System.Net.IWebProxy proxy, System.Net.Cache.RequestCachePolicy cachePolicy);
            /*0xb689bc*/ System.Threading.Tasks.Task<System.IO.Stream> GetNonFileStreamAsync(System.Uri uri, System.Net.ICredentials credentials, System.Net.IWebProxy proxy, System.Net.Cache.RequestCachePolicy cachePolicy);

            class <>c__DisplayClass4_0
            {
                /*0x10*/ System.Uri uri;

                /*0xb689b4*/ <>c__DisplayClass4_0();
                /*0xb68adc*/ System.IO.Stream <GetStreamAsync>b__0();
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

                /*0xb68b6c*/ void MoveNext();
                /*0xb692e0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class OpenedHost
        {
            /*0x10*/ int nonCachedConnectionsCount;

            /*0xb684e8*/ OpenedHost();
        }

        class XmlRegisteredNonCachedStream : System.IO.Stream
        {
            /*0x28*/ System.IO.Stream stream;
            /*0x30*/ System.Xml.XmlDownloadManager downloadManager;
            /*0x38*/ string host;

            /*0xb684f0*/ XmlRegisteredNonCachedStream(System.IO.Stream stream, System.Xml.XmlDownloadManager downloadManager, string host);
            /*0xb69338*/ void Finalize();
            /*0xb693dc*/ void Dispose(bool disposing);
            /*0xb69514*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state);
            /*0xb69538*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state);
            /*0xb6955c*/ int EndRead(System.IAsyncResult asyncResult);
            /*0xb69580*/ void EndWrite(System.IAsyncResult asyncResult);
            /*0xb695a4*/ void Flush();
            /*0xb695c8*/ int Read(byte[] buffer, int offset, int count);
            /*0xb695ec*/ int ReadByte();
            /*0xb69610*/ long Seek(long offset, System.IO.SeekOrigin origin);
            /*0xb69634*/ void SetLength(long value);
            /*0xb69658*/ void Write(byte[] buffer, int offset, int count);
            /*0xb6967c*/ void WriteByte(byte value);
            /*0xb696a0*/ bool get_CanRead();
            /*0xb696c0*/ bool get_CanSeek();
            /*0xb696e0*/ bool get_CanWrite();
            /*0xb69700*/ long get_Length();
            /*0xb69720*/ long get_Position();
            /*0xb69740*/ void set_Position(long value);
        }

        class XmlCachedStream : System.IO.MemoryStream
        {
            /*0x50*/ System.Uri uri;

            /*0xb68570*/ XmlCachedStream(System.Uri uri, System.IO.Stream stream);
        }

        class UTF16Decoder : System.Text.Decoder
        {
            /*0x20*/ bool bigEndian;
            /*0x24*/ int lastByte;

            /*0xb69764*/ UTF16Decoder(bool bigEndian);
            /*0xb69794*/ int GetCharCount(byte[] bytes, int index, int count);
            /*0xb697a4*/ int GetCharCount(byte[] bytes, int index, int count, bool flush);
            /*0xb69890*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0xb69ac8*/ void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, ref int bytesUsed, ref int charsUsed, ref bool completed);
        }

        class SafeAsciiDecoder : System.Text.Decoder
        {
            /*0xb69d60*/ SafeAsciiDecoder();
            /*0xb69d68*/ int GetCharCount(byte[] bytes, int index, int count);
            /*0xb69d70*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0xb69de0*/ void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, ref int bytesUsed, ref int charsUsed, ref bool completed);
        }

        class Ucs4Encoding : System.Text.Encoding
        {
            /*0x38*/ System.Xml.Ucs4Decoder ucs4Decoder;

            static /*0xb69f5c*/ System.Text.Encoding get_UCS4_Littleendian();
            static /*0xb6a01c*/ System.Text.Encoding get_UCS4_Bigendian();
            static /*0xb6a0dc*/ System.Text.Encoding get_UCS4_2143();
            static /*0xb6a19c*/ System.Text.Encoding get_UCS4_3412();
            /*0xb6a25c*/ Ucs4Encoding();
            /*0xb69e68*/ string get_WebName();
            /*0xb69e74*/ System.Text.Decoder GetDecoder();
            /*0xb69e7c*/ int GetByteCount(char[] chars, int index, int count);
            /*0xb69edc*/ byte[] GetBytes(string s);
            /*0xb69ee4*/ int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);
            /*0xb69eec*/ int GetMaxByteCount(int charCount);
            /*0xb69ef4*/ int GetCharCount(byte[] bytes, int index, int count);
            /*0xb69f14*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0xb69f34*/ int GetMaxCharCount(int byteCount);
            /*0xb69f4c*/ int get_CodePage();
            /*0xb69f54*/ System.Text.Encoder GetEncoder();
        }

        class Ucs4Encoding1234 : System.Xml.Ucs4Encoding
        {
            /*0xb6a074*/ Ucs4Encoding1234();
            /*0xb6a268*/ string get_EncodingName();
            /*0xb6a2a8*/ byte[] GetPreamble();
        }

        class Ucs4Encoding4321 : System.Xml.Ucs4Encoding
        {
            /*0xb69fb4*/ Ucs4Encoding4321();
            /*0xb6a324*/ string get_EncodingName();
            /*0xb6a364*/ byte[] GetPreamble();
        }

        class Ucs4Encoding2143 : System.Xml.Ucs4Encoding
        {
            /*0xb6a134*/ Ucs4Encoding2143();
            /*0xb6a3dc*/ string get_EncodingName();
            /*0xb6a41c*/ byte[] GetPreamble();
        }

        class Ucs4Encoding3412 : System.Xml.Ucs4Encoding
        {
            /*0xb6a1f4*/ Ucs4Encoding3412();
            /*0xb6a498*/ string get_EncodingName();
            /*0xb6a4d8*/ byte[] GetPreamble();
        }

        class Ucs4Decoder : System.Text.Decoder
        {
            /*0x20*/ byte[] lastBytes;
            /*0x28*/ int lastBytesCount;

            /*0xb6a92c*/ Ucs4Decoder();
            /*0xb6a54c*/ int GetCharCount(byte[] bytes, int index, int count);
            int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0xb6a568*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0xb6a6e0*/ void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, ref int bytesUsed, ref int charsUsed, ref bool completed);
            /*0xb6a8d4*/ void Ucs4ToUTF16(uint code, char[] chars, int charIndex);
        }

        class Ucs4Decoder4321 : System.Xml.Ucs4Decoder
        {
            /*0xb6a320*/ Ucs4Decoder4321();
            /*0xb6a984*/ int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
        }

        class Ucs4Decoder1234 : System.Xml.Ucs4Decoder
        {
            /*0xb6a264*/ Ucs4Decoder1234();
            /*0xb6ab98*/ int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
        }

        class Ucs4Decoder2143 : System.Xml.Ucs4Decoder
        {
            /*0xb6a3d8*/ Ucs4Decoder2143();
            /*0xb6adac*/ int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
        }

        class Ucs4Decoder3412 : System.Xml.Ucs4Decoder
        {
            /*0xb6a494*/ Ucs4Decoder3412();
            /*0xb6afc0*/ int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
        }

        class XmlException : System.SystemException
        {
            /*0x90*/ string res;
            /*0x98*/ string[] args;
            /*0xa0*/ int lineNumber;
            /*0xa4*/ int linePosition;
            /*0xa8*/ string sourceUri;
            /*0xb0*/ string message;

            static /*0xb6bb2c*/ string FormatUserMessage(string message, int lineNumber, int linePosition);
            static /*0xb6b5ac*/ string CreateMessage(string res, string[] args, int lineNumber, int linePosition);
            static /*0xb5ff0c*/ string[] BuildCharExceptionArgs(string data, int invCharIndex);
            static /*0xb6c1a8*/ string[] BuildCharExceptionArgs(char[] data, int length, int invCharIndex);
            static /*0xb602d0*/ string[] BuildCharExceptionArgs(char invChar, char nextChar);
            /*0xb6b1d4*/ XmlException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0xb6b9c0*/ XmlException();
            /*0xb6b9d8*/ XmlException(string message);
            /*0xb6b9f4*/ XmlException(string message, System.Exception innerException);
            /*0xb6b9ec*/ XmlException(string message, System.Exception innerException, int lineNumber, int linePosition);
            /*0xb6ba04*/ XmlException(string message, System.Exception innerException, int lineNumber, int linePosition, string sourceUri);
            /*0xb5ff68*/ XmlException(string res, string[] args);
            /*0xb5fd64*/ XmlException(string res, string arg);
            /*0xb6bca4*/ XmlException(string res, string arg, string sourceUri);
            /*0xb6bd88*/ XmlException(string res, string arg, System.Xml.IXmlLineInfo lineInfo);
            /*0xb6bfb0*/ XmlException(string res, string[] args, System.Xml.IXmlLineInfo lineInfo);
            /*0xb6be44*/ XmlException(string res, string[] args, System.Xml.IXmlLineInfo lineInfo, string sourceUri);
            /*0xb67710*/ XmlException(string res, string arg, int lineNumber, int linePosition);
            /*0xb6bfb8*/ XmlException(string res, string arg, int lineNumber, int linePosition, string sourceUri);
            /*0xb679a8*/ XmlException(string res, string[] args, int lineNumber, int linePosition);
            /*0xb6c0b0*/ XmlException(string res, string[] args, int lineNumber, int linePosition, string sourceUri);
            /*0xb6c12c*/ XmlException(string res, string[] args, System.Exception innerException, int lineNumber, int linePosition);
            /*0xb6bc24*/ XmlException(string res, string[] args, System.Exception innerException, int lineNumber, int linePosition, string sourceUri);
            /*0xb6b850*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            /*0xb6c1fc*/ int get_LineNumber();
            /*0xb6c204*/ int get_LinePosition();
            /*0xb6c20c*/ string get_Message();
            /*0xb6c224*/ string get_ResString();
        }

        class XmlNameTable
        {
            /*0xb6c22c*/ XmlNameTable();
            string Get(string array);
            string Add(char[] array, int offset, int length);
            string Add(string array);
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

            /*0xb6c234*/ XmlNamespaceManager();
            /*0xb6c23c*/ XmlNamespaceManager(System.Xml.XmlNameTable nameTable);
            /*0xb6c404*/ System.Xml.XmlNameTable get_NameTable();
            /*0xb6c40c*/ string get_DefaultNamespace();
            /*0xb6c47c*/ void PushScope();
            /*0xb6c48c*/ bool PopScope();
            /*0xb6c564*/ void AddNamespace(string prefix, string uri);
            /*0xb6ca94*/ void RemoveNamespace(string prefix, string uri);
            /*0xb6cbd0*/ System.Collections.IEnumerator GetEnumerator();
            /*0xb6cd40*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
            /*0xb6cef8*/ string LookupNamespace(string prefix);
            /*0xb6c908*/ int LookupNamespaceDecl(string prefix);
            /*0xb6cf44*/ string LookupPrefix(string uri);

            struct NamespaceDeclaration
            {
                /*0x10*/ string prefix;
                /*0x18*/ string uri;
                /*0x20*/ int scopeId;
                /*0x24*/ int previousNsIndex;

                /*0xb6c3f8*/ void Set(string prefix, string uri, int scopeId, int previousNsIndex);
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

            static /*0xb6daa0*/ XmlQualifiedName();
            static /*0xb6d59c*/ bool op_Equality(System.Xml.XmlQualifiedName a, System.Xml.XmlQualifiedName b);
            static /*0xb6d52c*/ bool op_Inequality(System.Xml.XmlQualifiedName a, System.Xml.XmlQualifiedName b);
            static /*0xb6d604*/ string ToString(string name, string ns);
            static /*0xb6d224*/ System.Xml.XmlQualifiedName.HashCodeOfStringDelegate GetHashCodeDelegate();
            static /*0xb6d674*/ bool IsRandomizedHashingDisabled();
            static /*0xb6d754*/ int GetHashCodeOfString(string s, int length, long additionalEntropy);
            static /*0xb6d868*/ System.Xml.XmlQualifiedName Parse(string s, System.Xml.IXmlNamespaceResolver nsmgr, ref string prefix);
            /*0xb6d008*/ XmlQualifiedName();
            /*0xb6d0e8*/ XmlQualifiedName(string name);
            /*0xb6d05c*/ XmlQualifiedName(string name, string ns);
            /*0xb6d148*/ string get_Namespace();
            /*0xb6d150*/ string get_Name();
            /*0xb6d158*/ int GetHashCode();
            /*0xb6d3a0*/ bool get_IsEmpty();
            /*0xb6d3dc*/ string ToString();
            /*0xb6d44c*/ bool Equals(object other);
            /*0xb6d770*/ void Init(string name, string ns);
            /*0xb6d77c*/ void SetNamespace(string ns);
            /*0xb6d784*/ void Verify();
            /*0xb6d814*/ void Atomize(System.Xml.XmlNameTable nameTable);
            /*0xb6da20*/ System.Xml.XmlQualifiedName Clone();

            class HashCodeOfStringDelegate : System.MulticastDelegate
            {
                /*0xb6d67c*/ HashCodeOfStringDelegate(object object, nint method);
                /*0xb6db30*/ int Invoke(string s, int sLen, long additionalEntropy);
            }
        }

        class XmlResolver
        {
            /*0xb6dea4*/ XmlResolver();
            object GetEntity(System.Uri absoluteUri, string role, System.Type ofObjectToReturn);
            /*0xb6db44*/ System.Uri ResolveUri(System.Uri baseUri, string relativeUri);
            /*0xb6dd1c*/ bool SupportsType(System.Uri absoluteUri, System.Type type);
            /*0xb6de64*/ System.Threading.Tasks.Task<object> GetEntityAsync(System.Uri absoluteUri, string role, System.Type ofObjectToReturn);
        }

        class XmlUrlResolver : System.Xml.XmlResolver
        {
            static /*0x0*/ object s_DownloadManager;
            /*0x10*/ System.Net.ICredentials _credentials;
            /*0x18*/ System.Net.IWebProxy _proxy;
            /*0x20*/ System.Net.Cache.RequestCachePolicy _cachePolicy;

            static /*0xb6deac*/ System.Xml.XmlDownloadManager get_DownloadManager();
            /*0xb6df80*/ XmlUrlResolver();
            /*0xb6df88*/ object GetEntity(System.Uri absoluteUri, string role, System.Type ofObjectToReturn);
            /*0xb6e104*/ System.Uri ResolveUri(System.Uri baseUri, string relativeUri);
            /*0xb6e108*/ System.Threading.Tasks.Task<object> GetEntityAsync(System.Uri absoluteUri, string role, System.Type ofObjectToReturn);

            struct <GetEntityAsync>d__15 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object> <>t__builder;
                /*0x30*/ System.Type ofObjectToReturn;
                /*0x38*/ System.Uri absoluteUri;
                /*0x40*/ System.Xml.XmlUrlResolver <>4__this;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.IO.Stream> <>u__1;

                /*0xb6e214*/ void MoveNext();
                /*0xb6e590*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class BinaryCompatibility
        {
            static /*0xb6e5e8*/ bool get_TargetsAtLeast_Desktop_V4_5_2();
        }

        class Res
        {
            static /*0xb6294c*/ string GetString(string name);
            static /*0xb60578*/ string GetString(string name, object[] args);
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

                /*0xb6e5f0*/ System.Xml.XmlNameTable get_NameTable();
                /*0xb6e5f8*/ bool get_HasLineInfo();
                /*0xb6e600*/ int GetXmlNamespaceNode(ref MS.Internal.Xml.Cache.XPathNode[] pageXmlNmsp);
                /*0xb6e610*/ int LookupNamespaces(MS.Internal.Xml.Cache.XPathNode[] pageElem, int idxElem, ref MS.Internal.Xml.Cache.XPathNode[] pageNmsp);
            }

            class XPathException : System.SystemException
            {
                /*0x90*/ string res;
                /*0x98*/ string[] args;
                /*0xa0*/ string message;

                static /*0xb6ed10*/ System.Xml.XPath.XPathException Create(string res);
                static /*0xb6ede8*/ System.Xml.XPath.XPathException Create(string res, string arg);
                static /*0xb6eed8*/ System.Xml.XPath.XPathException Create(string res, string arg, string arg2);
                static /*0xb6e958*/ string CreateMessage(string res, string[] args);
                /*0xb6e6e4*/ XPathException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0xb6eb7c*/ XPathException();
                /*0xb6ebd0*/ XPathException(string message, System.Exception innerException);
                /*0xb6ed98*/ XPathException(string res, string[] args);
                /*0xb6ecb4*/ XPathException(string res, string[] args, System.Exception inner);
                /*0xb6ea94*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0xb6eff4*/ string get_Message();
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
                /*0xb6f020*/ XPathItem();
                System.Xml.Schema.XmlSchemaType get_XmlType();
                string get_Value();
                object get_TypedValue();
                System.Type get_ValueType();
                bool get_ValueAsBoolean();
                System.DateTime get_ValueAsDateTime();
                double get_ValueAsDouble();
                int get_ValueAsInt();
                long get_ValueAsLong();
                /*0xb6f00c*/ object ValueAs(System.Type returnType);
                object ValueAs(System.Type returnType, System.Xml.IXmlNamespaceResolver nsResolver);
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

                static /*0xb70e40*/ XPathNavigator();
                static /*0xb70e28*/ bool IsText(System.Xml.XPath.XPathNodeType type);
                /*0xb70e38*/ XPathNavigator();
                /*0xb6f028*/ string ToString();
                /*0xb6f034*/ System.Xml.Schema.XmlSchemaType get_XmlType();
                /*0xb6f1bc*/ object get_TypedValue();
                /*0xb6f498*/ System.Type get_ValueType();
                /*0xb6f6a4*/ bool get_ValueAsBoolean();
                /*0xb6f968*/ System.DateTime get_ValueAsDateTime();
                /*0xb6fc34*/ double get_ValueAsDouble();
                /*0xb6ff00*/ int get_ValueAsInt();
                /*0xb701cc*/ long get_ValueAsLong();
                /*0xb70498*/ object ValueAs(System.Type returnType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0xb70784*/ object System.ICloneable.Clone();
                System.Xml.XmlNameTable get_NameTable();
                /*0xb70794*/ string LookupNamespace(string prefix);
                /*0xb70938*/ string LookupPrefix(string namespaceURI);
                /*0xb70b28*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
                System.Xml.XPath.XPathNavigator Clone();
                System.Xml.XPath.XPathNodeType get_NodeType();
                string get_LocalName();
                string get_NamespaceURI();
                string get_Prefix();
                /*0xb70d38*/ object get_UnderlyingObject();
                /*0xb70d40*/ bool MoveToNamespace(string name);
                bool MoveToFirstNamespace(System.Xml.XPath.XPathNamespaceScope namespaceScope);
                bool MoveToNextNamespace(System.Xml.XPath.XPathNamespaceScope namespaceScope);
                bool MoveToParent();
                bool IsSamePosition(System.Xml.XPath.XPathNavigator other);
                /*0xb70de0*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
            }

            class XPathNavigatorKeyComparer : System.Collections.IEqualityComparer
            {
                /*0xb70fa4*/ XPathNavigatorKeyComparer();
                /*0xb70fac*/ bool System.Collections.IEqualityComparer.Equals(object obj1, object obj2);
                /*0xb71088*/ int System.Collections.IEqualityComparer.GetHashCode(object obj);
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

                static /*0xb71660*/ CodeIdentifier();
                static /*0xb71258*/ string MakePascal(string identifier);
                static /*0xb71400*/ string MakeValid(string identifier);
                static /*0xb715fc*/ bool IsValidStart(char c);
                static /*0xb71580*/ bool IsValid(char c);
            }

            class XmlSerializerNamespaces
            {
                /*0x10*/ System.Collections.Hashtable namespaces;

                /*0xb716d8*/ XmlSerializerNamespaces();
                /*0xb716e0*/ void Add(string prefix, string ns);
                /*0xb7178c*/ void AddInternal(string prefix, string ns);
                /*0xb71834*/ System.Xml.XmlQualifiedName[] ToArray();
                /*0xb71d78*/ int get_Count();
                /*0xb7193c*/ System.Collections.ArrayList get_NamespaceList();
                /*0xb717c8*/ System.Collections.Hashtable get_Namespaces();
                /*0xb71d9c*/ void set_Namespaces(System.Collections.Hashtable value);
            }

            class XmlAttributeEventHandler : System.MulticastDelegate
            {
                /*0xb71da4*/ XmlAttributeEventHandler(object object, nint method);
                /*0xb71ed4*/ void Invoke(object sender, System.Xml.Serialization.XmlAttributeEventArgs e);
            }

            class XmlAttributeEventArgs : System.EventArgs
            {
                /*0x10*/ object o;
                /*0x18*/ System.Xml.XmlAttribute attr;
                /*0x20*/ string qnames;
                /*0x28*/ int lineNumber;
                /*0x2c*/ int linePosition;

                /*0xb71ee8*/ XmlAttributeEventArgs(System.Xml.XmlAttribute attr, int lineNumber, int linePosition, object o, string qnames);
            }

            class XmlElementEventHandler : System.MulticastDelegate
            {
                /*0xb71f7c*/ XmlElementEventHandler(object object, nint method);
                /*0xb720ac*/ void Invoke(object sender, System.Xml.Serialization.XmlElementEventArgs e);
            }

            class XmlElementEventArgs : System.EventArgs
            {
                /*0x10*/ object o;
                /*0x18*/ System.Xml.XmlElement elem;
                /*0x20*/ string qnames;
                /*0x28*/ int lineNumber;
                /*0x2c*/ int linePosition;

                /*0xb720c0*/ XmlElementEventArgs(System.Xml.XmlElement elem, int lineNumber, int linePosition, object o, string qnames);
            }

            class XmlNodeEventHandler : System.MulticastDelegate
            {
                /*0xb72154*/ XmlNodeEventHandler(object object, nint method);
                /*0xb72284*/ void Invoke(object sender, System.Xml.Serialization.XmlNodeEventArgs e);
            }

            class XmlNodeEventArgs : System.EventArgs
            {
                /*0x10*/ object o;
                /*0x18*/ System.Xml.XmlNode xmlNode;
                /*0x20*/ int lineNumber;
                /*0x24*/ int linePosition;

                /*0xb72298*/ XmlNodeEventArgs(System.Xml.XmlNode xmlNode, int lineNumber, int linePosition, object o);
            }

            class UnreferencedObjectEventHandler : System.MulticastDelegate
            {
                /*0xb7231c*/ UnreferencedObjectEventHandler(object object, nint method);
                /*0xb7244c*/ void Invoke(object sender, System.Xml.Serialization.UnreferencedObjectEventArgs e);
            }

            class UnreferencedObjectEventArgs : System.EventArgs
            {
                /*0x10*/ object o;
                /*0x18*/ string id;

                /*0xb72460*/ UnreferencedObjectEventArgs(object o, string id);
            }

            interface IXmlSerializable
            {
                System.Xml.Schema.XmlSchema GetSchema();
                void ReadXml(System.Xml.XmlReader reader);
                void WriteXml(System.Xml.XmlWriter writer);
            }

            interface IXmlTextParser
            {
                bool get_Normalized();
                void set_Normalized(bool value);
            }

            class KeyHelper
            {
                static /*0xb724d0*/ void AddField(System.Text.StringBuilder sb, int n, string val);
                static /*0xb724d8*/ void AddField(System.Text.StringBuilder sb, int n, string val, string def);
                static /*0xb725bc*/ void AddField(System.Text.StringBuilder sb, int n, bool val);
                static /*0xb725c8*/ void AddField(System.Text.StringBuilder sb, int n, bool val, bool def);
                static /*0xb72610*/ void AddField(System.Text.StringBuilder sb, int n, int val, int def);
                static /*0xb726c8*/ void AddField(System.Text.StringBuilder sb, int n, System.Type val);
            }

            class ReflectionHelper
            {
                static /*0x0*/ System.Reflection.ParameterModifier[] empty_modifiers;
                /*0x10*/ System.Collections.Hashtable _clrTypes;
                /*0x18*/ System.Collections.Hashtable _schemaTypes;

                static /*0xb72fe8*/ ReflectionHelper();
                static /*0xb72c14*/ void CheckSerializableType(System.Type type, bool allowPrivateConstructors);
                /*0xb72f64*/ ReflectionHelper();
                /*0xb727b4*/ void RegisterSchemaType(System.Xml.Serialization.XmlTypeMapping map, string xmlType, string ns);
                /*0xb72880*/ System.Xml.Serialization.XmlTypeMapping GetRegisteredSchemaType(string xmlType, string ns);
                /*0xb72954*/ void RegisterClrType(System.Xml.Serialization.XmlTypeMapping map, System.Type type, string ns);
                /*0xb72aac*/ System.Xml.Serialization.XmlTypeMapping GetRegisteredClrType(System.Type type, string ns);
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

                /*0xb73050*/ SerializationSource(string namspace, System.Type[] includedTypes);
                /*0xb73084*/ bool BaseEquals(System.Xml.Serialization.SerializationSource other);
            }

            class XmlTypeSerializationSource : System.Xml.Serialization.SerializationSource
            {
                /*0x28*/ string attributeOverridesHash;
                /*0x30*/ System.Type type;
                /*0x38*/ string rootHash;

                /*0xb73180*/ XmlTypeSerializationSource(System.Type type, System.Xml.Serialization.XmlRootAttribute root, System.Xml.Serialization.XmlAttributeOverrides attributeOverrides, string namspace, System.Type[] includedTypes);
                /*0xb73284*/ bool Equals(object o);
                /*0xb73364*/ int GetHashCode();
            }

            class XmlTypeConvertorAttribute : System.Attribute
            {
                /*0x10*/ string <Method>k__BackingField;

                /*0xb73394*/ XmlTypeConvertorAttribute(string method);
                /*0xb73384*/ string get_Method();
                /*0xb7338c*/ void set_Method(string value);
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

                static /*0xb747dc*/ TypeData();
                static /*0xb7457c*/ System.Reflection.PropertyInfo GetIndexerProperty(System.Type collectionType);
                static /*0xb746bc*/ System.InvalidOperationException CreateMissingAddMethodException(System.Type type, string inheritFrom, System.Type argumentType);
                static /*0xb74388*/ System.Type GetGenericListItemType(System.Type type);
                /*0xb733bc*/ TypeData(System.Type type, string elementName, bool isPrimitive);
                /*0xb733cc*/ TypeData(System.Type type, string elementName, bool isPrimitive, System.Xml.Serialization.TypeData mappedType, System.Xml.Schema.XmlSchemaPatternFacet facet);
                /*0xb7392c*/ void LookupTypeConvertor();
                /*0xb739cc*/ void ConvertForAssignment(ref object value);
                /*0xb73a9c*/ string get_TypeName();
                /*0xb73aa4*/ string get_XmlType();
                /*0xb73aac*/ System.Type get_Type();
                /*0xb73ab4*/ string get_FullTypeName();
                /*0xb73abc*/ System.Xml.Serialization.SchemaTypes get_SchemaType();
                /*0xb72f54*/ bool get_IsListType();
                /*0xb73ac4*/ bool get_IsComplexType();
                /*0xb73afc*/ bool get_IsValueType();
                /*0xb73b90*/ bool get_IsNullable();
                /*0xb73ca4*/ void set_IsNullable(bool value);
                /*0xb73764*/ System.Xml.Serialization.TypeData get_ListItemTypeData();
                /*0xb73cb0*/ System.Type get_ListItemType();
                /*0xb73aec*/ bool get_IsXsdType();
                /*0xb747d4*/ bool get_HasPublicConstructor();
            }

            class TypeMember
            {
                /*0x10*/ System.Type type;
                /*0x18*/ string member;

                static /*0xb75d44*/ bool Equals(System.Xml.Serialization.TypeMember tm1, System.Xml.Serialization.TypeMember tm2);
                /*0xb75c60*/ TypeMember(System.Type type, string member);
                /*0xb75c8c*/ int GetHashCode();
                /*0xb75cd4*/ bool Equals(object obj);
                /*0xb75df0*/ string ToString();
            }

            class TypeTranslator
            {
                static /*0x0*/ System.Collections.Hashtable nameCache;
                static /*0x8*/ System.Collections.Hashtable primitiveTypes;
                static /*0x10*/ System.Collections.Hashtable primitiveArrayTypes;
                static /*0x18*/ System.Collections.Hashtable nullableTypes;

                static /*0xb75e54*/ TypeTranslator();
                static /*0xb72ef8*/ System.Xml.Serialization.TypeData GetTypeData(System.Type type);
                static /*0xb78360*/ System.Xml.Serialization.TypeData GetTypeData(System.Type runtimeType, string xmlDataType, bool underlyingEnumType);
                static /*0xb78d24*/ System.Xml.Serialization.TypeData GetPrimitiveTypeData(string typeName);
                static /*0xb78d7c*/ System.Xml.Serialization.TypeData GetPrimitiveTypeData(string typeName, bool nullable);
                static /*0xb78f84*/ System.Xml.Serialization.TypeData FindPrimitiveTypeData(string typeName);
                static /*0xb7381c*/ string GetArrayName(string elemName);
                static /*0xb79044*/ void ParseArrayType(string arrayType, ref string type, ref string ns, ref string dimensions);
            }

            class XmlAnyAttributeAttribute : System.Attribute
            {
                /*0xb791c0*/ XmlAnyAttributeAttribute();
            }

            class XmlAnyElementAttribute : System.Attribute
            {
                /*0x10*/ string elementName;
                /*0x18*/ string ns;
                /*0x20*/ int order;

                /*0xb791c8*/ XmlAnyElementAttribute();
                /*0xb791d8*/ string get_Name();
                /*0xb7922c*/ string get_Namespace();
                /*0xb79234*/ int get_Order();
                /*0xb7923c*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlAnyElementAttributes : System.Collections.CollectionBase
            {
                /*0xb79830*/ XmlAnyElementAttributes();
                /*0xb792cc*/ System.Xml.Serialization.XmlAnyElementAttribute get_Item(int index);
                /*0xb793cc*/ int Add(System.Xml.Serialization.XmlAnyElementAttribute attribute);
                /*0xb79484*/ void AddKeyHash(System.Text.StringBuilder sb);
                /*0xb79550*/ int get_Order();
            }

            class XmlArrayAttribute : System.Attribute
            {
                /*0x10*/ string elementName;
                /*0x18*/ System.Xml.Schema.XmlSchemaForm form;
                /*0x1c*/ bool isNullable;
                /*0x20*/ string ns;
                /*0x28*/ int order;

                /*0xb9f500*/ string get_ElementName();
                /*0xb9f554*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0xb9f55c*/ bool get_IsNullable();
                /*0xb9f564*/ string get_Namespace();
                /*0xb9f56c*/ int get_Order();
                /*0xb9f574*/ void AddKeyHash(System.Text.StringBuilder sb);
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

                /*0xb9f694*/ string get_DataType();
                /*0xb9f6e8*/ string get_ElementName();
                /*0xb9f73c*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0xb9f744*/ string get_Namespace();
                /*0xb9f74c*/ bool get_IsNullable();
                /*0xb9f754*/ bool get_IsNullableSpecified();
                /*0xb9f75c*/ System.Type get_Type();
                /*0xb9f764*/ int get_NestingLevel();
                /*0xb9f76c*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlArrayItemAttributes : System.Collections.CollectionBase
            {
                /*0xb9fb54*/ XmlArrayItemAttributes();
                /*0xb9f8d0*/ System.Xml.Serialization.XmlArrayItemAttribute get_Item(int index);
                /*0xb9f9d0*/ int Add(System.Xml.Serialization.XmlArrayItemAttribute attribute);
                /*0xb9fa88*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlAttributeAttribute : System.Attribute
            {
                /*0x10*/ string attributeName;
                /*0x18*/ string dataType;
                /*0x20*/ System.Type type;
                /*0x28*/ System.Xml.Schema.XmlSchemaForm form;
                /*0x30*/ string ns;

                /*0xb9fb5c*/ XmlAttributeAttribute(string attributeName);
                /*0xb9fb84*/ string get_AttributeName();
                /*0xb9fbd8*/ string get_DataType();
                /*0xb9fc2c*/ void set_DataType(string value);
                /*0xb9fc34*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0xb9fc3c*/ string get_Namespace();
                /*0xb9fc44*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlAttributeOverrides
            {
                /*0x10*/ System.Collections.Hashtable overrides;

                /*0xb9fd78*/ XmlAttributeOverrides();
                /*0xb9fde4*/ System.Xml.Serialization.XmlAttributes get_Item(System.Type type);
                /*0xb9fe44*/ System.Xml.Serialization.XmlAttributes get_Item(System.Type type, string member);
                /*0xb9fef8*/ System.Xml.Serialization.TypeMember GetKey(System.Type type, string member);
                /*0xb9ff6c*/ void AddKeyHash(System.Text.StringBuilder sb);
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

                /*0xba06e8*/ XmlAttributes();
                /*0xba07f4*/ XmlAttributes(System.Reflection.ICustomAttributeProvider provider);
                /*0xba0ee4*/ System.Xml.Serialization.XmlAnyAttributeAttribute get_XmlAnyAttribute();
                /*0xba0eec*/ System.Xml.Serialization.XmlAnyElementAttributes get_XmlAnyElements();
                /*0xba0ef4*/ System.Xml.Serialization.XmlArrayAttribute get_XmlArray();
                /*0xba0efc*/ System.Xml.Serialization.XmlArrayItemAttributes get_XmlArrayItems();
                /*0xba0f04*/ System.Xml.Serialization.XmlAttributeAttribute get_XmlAttribute();
                /*0xba0f0c*/ System.Xml.Serialization.XmlChoiceIdentifierAttribute get_XmlChoiceIdentifier();
                /*0xba0f14*/ object get_XmlDefaultValue();
                /*0xba0f1c*/ System.Xml.Serialization.XmlElementAttributes get_XmlElements();
                /*0xba0f24*/ bool get_XmlIgnore();
                /*0xba0f2c*/ bool get_Xmlns();
                /*0xba0f34*/ System.Xml.Serialization.XmlRootAttribute get_XmlRoot();
                /*0xba0f3c*/ System.Xml.Serialization.XmlTextAttribute get_XmlText();
                /*0xba0f44*/ System.Xml.Serialization.XmlTypeAttribute get_XmlType();
                /*0xba0478*/ void AddKeyHash(System.Text.StringBuilder sb);
                /*0xba1e8c*/ System.Nullable<int> get_Order();
                /*0xba2228*/ int get_SortableOrder();
            }

            class XmlChoiceIdentifierAttribute : System.Attribute
            {
                /*0x10*/ string memberName;

                /*0xba22a8*/ string get_MemberName();
                /*0xba1e10*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlCustomFormatter
            {
                static /*0x0*/ string[] allTimeFormats;

                static /*0xba30ac*/ XmlCustomFormatter();
                static /*0xba22fc*/ string FromEnum(long value, string[] values, long[] ids, string typeName);
                static /*0xba2584*/ string FromXmlName(string name);
                static /*0xba25dc*/ string FromXmlNCName(string ncName);
                static /*0xba1018*/ string ToXmlString(System.Xml.Serialization.TypeData type, object value);
                static /*0xba2634*/ object FromXmlString(System.Xml.Serialization.TypeData type, string value);
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

                /*0xba3730*/ XmlElementAttribute(string elementName);
                /*0xba3760*/ XmlElementAttribute(string elementName, System.Type type);
                /*0xba3798*/ string get_DataType();
                /*0xba37ec*/ string get_ElementName();
                /*0xba3840*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0xba3848*/ string get_Namespace();
                /*0xba3850*/ bool get_IsNullable();
                /*0xba3858*/ int get_Order();
                /*0xba3860*/ System.Type get_Type();
                /*0xba3868*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlElementAttributes : System.Collections.CollectionBase
            {
                /*0xba07ec*/ XmlElementAttributes();
                /*0xba39b0*/ System.Xml.Serialization.XmlElementAttribute get_Item(int index);
                /*0xba0e2c*/ int Add(System.Xml.Serialization.XmlElementAttribute attribute);
                /*0xba0f4c*/ void AddKeyHash(System.Text.StringBuilder sb);
                /*0xba1f48*/ int get_Order();
            }

            class XmlEnumAttribute : System.Attribute
            {
                /*0x10*/ string name;

                /*0xba3ab0*/ XmlEnumAttribute(string name);
                /*0xba3ad8*/ string get_Name();
                /*0xba1cdc*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlIgnoreAttribute : System.Attribute
            {
                /*0xba3ae0*/ XmlIgnoreAttribute();
            }

            class XmlIncludeAttribute : System.Attribute
            {
                /*0x10*/ System.Type type;

                /*0xba3ae8*/ System.Type get_Type();
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

                /*0xba3af0*/ XmlMapping(string elementName, string ns);
                /*0xba3b1c*/ string get_ElementName();
                /*0xba3b24*/ string get_Namespace();
                /*0xba3b2c*/ void SetKey(string key);
                /*0xba3b34*/ System.Xml.Serialization.ObjectMap get_ObjectMap();
                /*0xba3b3c*/ void set_ObjectMap(System.Xml.Serialization.ObjectMap value);
                /*0xba3b44*/ System.Collections.ArrayList get_RelatedMaps();
                /*0xba3b4c*/ void set_RelatedMaps(System.Collections.ArrayList value);
                /*0xba3b54*/ System.Xml.Serialization.SerializationFormat get_Format();
                /*0xba3b5c*/ void set_Format(System.Xml.Serialization.SerializationFormat value);
                /*0xba3b64*/ System.Xml.Serialization.SerializationSource get_Source();
            }

            class ObjectMap
            {
                /*0xba3b6c*/ ObjectMap();
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

                /*0xba3b74*/ int get_Count();
                /*0xba3b90*/ bool get_HasWrapperElement();
            }

            class XmlNamespaceDeclarationsAttribute : System.Attribute
            {
                /*0xba3b98*/ XmlNamespaceDeclarationsAttribute();
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

                static /*0xbaad68*/ XmlReflectionImporter();
                /*0xba3ba0*/ XmlReflectionImporter(System.Xml.Serialization.XmlAttributeOverrides attributeOverrides, string defaultNamespace);
                /*0xba3cb8*/ System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Type type);
                /*0xba3eac*/ System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Type type, string defaultNamespace);
                /*0xba3cc4*/ System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Type type, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0xba3eb8*/ System.Xml.Serialization.XmlTypeMapping ImportTypeMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0xba69c4*/ System.Xml.Serialization.XmlTypeMapping CreateTypeMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultXmlType, string defaultNamespace);
                /*0xba6e94*/ System.Xml.Serialization.XmlTypeMapping ImportClassMapping(System.Type type, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace, bool isBaseType);
                /*0xba433c*/ System.Xml.Serialization.XmlTypeMapping ImportClassMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace, bool isBaseType);
                /*0xba87a4*/ void RegisterDerivedMap(System.Xml.Serialization.XmlTypeMapping map, System.Xml.Serialization.XmlTypeMapping derivedMap);
                /*0xba6f24*/ string GetTypeNamespace(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0xba89f8*/ System.Xml.Serialization.XmlTypeMapping ImportListMapping(System.Type type, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace, System.Xml.Serialization.XmlAttributes atts, int nestingLevel);
                /*0xba532c*/ System.Xml.Serialization.XmlTypeMapping ImportListMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace, System.Xml.Serialization.XmlAttributes atts, int nestingLevel);
                /*0xba6030*/ System.Xml.Serialization.XmlTypeMapping ImportXmlNodeMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0xba6204*/ System.Xml.Serialization.XmlTypeMapping ImportPrimitiveMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0xba62b8*/ System.Xml.Serialization.XmlTypeMapping ImportEnumMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0xba68b0*/ System.Xml.Serialization.XmlTypeMapping ImportXmlSerializableMapping(System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0xba88c0*/ void ImportIncludedTypes(System.Type type, string defaultNamespace);
                /*0xba7030*/ System.Collections.Generic.List<System.Xml.Serialization.XmlReflectionMember> GetReflectionMembers(System.Type type);
                /*0xba7dfc*/ System.Xml.Serialization.XmlTypeMapMember CreateMapMember(System.Type declaringType, System.Xml.Serialization.XmlReflectionMember rmember, string defaultNamespace);
                /*0xba91d4*/ System.Xml.Serialization.XmlTypeMapElementInfoList ImportElementInfo(System.Type cls, string defaultName, string defaultNamespace, System.Type defaultType, System.Xml.Serialization.XmlTypeMapMemberElement member, System.Xml.Serialization.XmlAttributes atts);
                /*0xba8ad4*/ System.Xml.Serialization.XmlTypeMapElementInfoList ImportAnyElementInfo(string defaultNamespace, System.Xml.Serialization.XmlReflectionMember rmember, System.Xml.Serialization.XmlTypeMapMemberElement member, System.Xml.Serialization.XmlAttributes atts);
                /*0xbaa50c*/ void ImportTextElementInfo(System.Xml.Serialization.XmlTypeMapElementInfoList list, System.Type defaultType, System.Xml.Serialization.XmlTypeMapMemberElement member, System.Xml.Serialization.XmlAttributes atts, string defaultNamespace);
                /*0xba6e00*/ bool CanBeNull(System.Xml.Serialization.TypeData type);
                /*0xbaa854*/ void IncludeType(System.Type type);
                /*0xbaa338*/ object GetDefaultValue(System.Xml.Serialization.TypeData typeData, object defaultValue);

                class <>c
                {
                    static /*0x0*/ System.Xml.Serialization.XmlReflectionImporter.<> <>9;
                    static /*0x8*/ System.Comparison<System.Xml.Serialization.XmlReflectionMember> <>9__28_0;

                    static /*0xbaadf4*/ <>c();
                    /*0xbaae58*/ <>c();
                    /*0xbaae60*/ int <ImportClassMapping>b__28_0(System.Xml.Serialization.XmlReflectionMember m1, System.Xml.Serialization.XmlReflectionMember m2);
                }
            }

            class XmlReflectionMember
            {
                /*0x10*/ bool isReturnValue;
                /*0x18*/ string memberName;
                /*0x20*/ System.Type memberType;
                /*0x28*/ System.Xml.Serialization.XmlAttributes xmlAttributes;
                /*0x30*/ System.Type declaringType;

                /*0xba8a98*/ XmlReflectionMember(string name, System.Type type, System.Xml.Serialization.XmlAttributes attributes);
                /*0xbaaeac*/ bool get_IsReturnValue();
                /*0xbaaeb4*/ string get_MemberName();
                /*0xbaaebc*/ System.Type get_MemberType();
                /*0xba7d94*/ System.Xml.Serialization.XmlAttributes get_XmlAttributes();
                /*0xbaaec4*/ System.Type get_DeclaringType();
                /*0xbaaecc*/ void set_DeclaringType(System.Type value);
            }

            class XmlRootAttribute : System.Attribute
            {
                /*0x10*/ string dataType;
                /*0x18*/ string elementName;
                /*0x20*/ bool isNullable;
                /*0x28*/ string ns;

                /*0xbaaed4*/ XmlRootAttribute();
                /*0xbaaee4*/ XmlRootAttribute(string elementName);
                /*0xbaaf14*/ string get_DataType();
                /*0xbaaf68*/ void set_DataType(string value);
                /*0xba6e40*/ string get_ElementName();
                /*0xbaaf70*/ void set_ElementName(string value);
                /*0xbaaf78*/ bool get_IsNullable();
                /*0xbaaf80*/ void set_IsNullable(bool value);
                /*0xbaaf8c*/ string get_Namespace();
                /*0xbaaf94*/ void set_Namespace(string value);
                /*0xba1d58*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlSchemaProviderAttribute : System.Attribute
            {
                /*0x10*/ string _methodName;
                /*0x18*/ bool _isAny;

                /*0xbaaf9c*/ XmlSchemaProviderAttribute(string methodName);
                /*0xbaafc4*/ string get_MethodName();
                /*0xbaafcc*/ bool get_IsAny();
                /*0xbaafd4*/ void set_IsAny(bool value);
            }

            class XmlSerializationCollectionFixupCallback : System.MulticastDelegate
            {
                /*0xbaafe0*/ XmlSerializationCollectionFixupCallback(object object, nint method);
                /*0xbab110*/ void Invoke(object collection, object collectionItems);
            }

            class XmlSerializationFixupCallback : System.MulticastDelegate
            {
                /*0xbab124*/ XmlSerializationFixupCallback(object object, nint method);
                /*0xbab250*/ void Invoke(object fixup);
            }

            class XmlSerializationGeneratedCode
            {
                /*0xbab264*/ XmlSerializationGeneratedCode();
            }

            class XmlSerializationReadCallback : System.MulticastDelegate
            {
                /*0xbab26c*/ XmlSerializationReadCallback(object object, nint method);
                /*0xbab328*/ object Invoke();
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

                /*0xbab72c*/ XmlSerializationReader();
                /*0xbab33c*/ void Initialize(System.Xml.XmlReader reader, System.Xml.Serialization.XmlSerializer eventSource);
                /*0xbab664*/ System.Collections.ArrayList EnsureArrayList(System.Collections.ArrayList list);
                /*0xbab6c8*/ System.Collections.Hashtable EnsureHashtable(System.Collections.Hashtable hash);
                /*0xbab734*/ System.Xml.XmlDocument get_Document();
                /*0xbab7c4*/ System.Xml.XmlReader get_Reader();
                /*0xbab7cc*/ void AddFixup(System.Xml.Serialization.XmlSerializationReader.CollectionFixup fixup);
                /*0xbab880*/ void AddFixup(System.Xml.Serialization.XmlSerializationReader.Fixup fixup);
                /*0xbab8c4*/ void AddFixup(System.Xml.Serialization.XmlSerializationReader.CollectionItemFixup fixup);
                /*0xbab908*/ void AddReadCallback(string name, string ns, System.Type type, System.Xml.Serialization.XmlSerializationReadCallback read);
                /*0xbab9f4*/ void AddTarget(string id, object o);
                /*0xbaba9c*/ string CurrentTag();
                /*0xbabbfc*/ System.Exception CreateReadOnlyCollectionException(string name);
                /*0xbabc94*/ System.Exception CreateUnknownConstantException(string value, System.Type enumType);
                /*0xbabd34*/ System.Exception CreateUnknownNodeException();
                /*0xbabdd0*/ System.Exception CreateUnknownTypeException(System.Xml.XmlQualifiedName type);
                /*0xbabfd8*/ System.Array EnsureArrayIndex(System.Array a, int index, System.Type elementType);
                /*0xbac064*/ bool GetNullAttr();
                /*0xbac10c*/ object GetTarget(string id);
                /*0xbac1c4*/ bool TargetReady(string id);
                /*0xbac1e0*/ System.Xml.XmlQualifiedName GetXsiType();
                void InitCallbacks();
                void InitIDs();
                /*0xbac3f8*/ bool IsXmlnsAttribute(string name);
                /*0xbac498*/ void ParseWsdlArrayType(System.Xml.XmlAttribute attr);
                /*0xbac61c*/ System.Xml.XmlQualifiedName ReadElementQualifiedName();
                /*0xbac950*/ void ReadEndElement();
                /*0xbac9e8*/ bool ReadNull();
                /*0xbacae4*/ System.Xml.XmlQualifiedName ReadNullableQualifiedName();
                /*0xbacb0c*/ string ReadNullableString();
                /*0xbacb54*/ object ReadReferencedElement();
                /*0xbace70*/ System.Xml.Serialization.XmlSerializationReader.WriteCallbackInfo GetCallbackInfo(System.Xml.XmlQualifiedName qname);
                /*0xbacbac*/ object ReadReferencedElement(string name, string ns);
                /*0xbacf50*/ bool ReadList(ref object resultList);
                /*0xbadde0*/ void ReadReferencedElements();
                /*0xbaed24*/ object ReadReferencingElement(ref string fixupReference);
                /*0xbadd94*/ object ReadReferencingElement(string name, string ns, ref string fixupReference);
                /*0xbaed88*/ object ReadReferencingElement(string name, string ns, bool elementCanBeType, ref string fixupReference);
                /*0xbaf09c*/ System.Xml.Serialization.IXmlSerializable ReadSerializable(System.Xml.Serialization.IXmlSerializable serializable);
                /*0xbaf22c*/ object ReadTypedPrimitive(System.Xml.XmlQualifiedName type);
                /*0xbad430*/ object ReadTypedPrimitive(System.Xml.XmlQualifiedName qname, bool reportUnknown);
                /*0xbaf4b4*/ System.Xml.XmlNode ReadXmlNode(bool wrapped);
                /*0xbaf51c*/ System.Xml.XmlDocument ReadXmlDocument(bool wrapped);
                /*0xbaf638*/ System.Array ShrinkArray(System.Array a, int length, System.Type elementType, bool isNullable);
                /*0xbac718*/ System.Xml.XmlQualifiedName ToXmlQualifiedName(string value);
                /*0xbaf6c8*/ void UnknownAttribute(object o, System.Xml.XmlAttribute attr, string qnames);
                /*0xbaf828*/ void UnknownElement(object o, System.Xml.XmlElement elem, string qnames);
                /*0xbacab0*/ void UnknownNode(object o);
                /*0xbaf988*/ void UnknownNode(object o, string qnames);
                /*0xbaf234*/ void OnUnknownNode(System.Xml.XmlNode node, object o, string qnames);
                /*0xbaec88*/ void UnreferencedObject(string id, object o);

                class WriteCallbackInfo
                {
                    /*0x10*/ System.Type Type;
                    /*0x18*/ string TypeName;
                    /*0x20*/ string TypeNs;
                    /*0x28*/ System.Xml.Serialization.XmlSerializationReadCallback Callback;

                    /*0xbab9ec*/ WriteCallbackInfo();
                }

                class CollectionFixup
                {
                    /*0x10*/ System.Xml.Serialization.XmlSerializationCollectionFixupCallback callback;
                    /*0x18*/ object collection;
                    /*0x20*/ object collectionItems;
                    /*0x28*/ string id;

                    /*0xbaf9c0*/ CollectionFixup(object collection, System.Xml.Serialization.XmlSerializationCollectionFixupCallback callback, string id);
                    /*0xbaf9fc*/ System.Xml.Serialization.XmlSerializationCollectionFixupCallback get_Callback();
                    /*0xbafa04*/ object get_Collection();
                    /*0xbafa0c*/ object get_Id();
                    /*0xbafa14*/ object get_CollectionItems();
                    /*0xbafa1c*/ void set_CollectionItems(object value);
                }

                class Fixup
                {
                    /*0x10*/ object source;
                    /*0x18*/ string[] ids;
                    /*0x20*/ System.Xml.Serialization.XmlSerializationFixupCallback callback;

                    /*0xbafa24*/ Fixup(object o, System.Xml.Serialization.XmlSerializationFixupCallback callback, int count);
                    /*0xbafaa4*/ System.Xml.Serialization.XmlSerializationFixupCallback get_Callback();
                    /*0xbafaac*/ string[] get_Ids();
                    /*0xbafab4*/ object get_Source();
                }

                class CollectionItemFixup
                {
                    /*0x10*/ System.Array list;
                    /*0x18*/ int index;
                    /*0x20*/ string id;

                    /*0xbadda0*/ CollectionItemFixup(System.Array list, int index, string id);
                    /*0xbafabc*/ System.Array get_Collection();
                    /*0xbafac4*/ int get_Index();
                    /*0xbafacc*/ string get_Id();
                }
            }

            class XmlSerializationReaderInterpreter : System.Xml.Serialization.XmlSerializationReader
            {
                static /*0x0*/ System.Xml.XmlQualifiedName AnyType;
                static /*0x8*/ object[] empty_array;
                /*0xd0*/ System.Xml.Serialization.XmlMapping _typeMap;
                /*0xd8*/ System.Xml.Serialization.SerializationFormat _format;

                static /*0xbb51ec*/ XmlSerializationReaderInterpreter();
                static /*0xbb3830*/ object CreateInstance(System.Type type, bool nonPublic);
                /*0xbafad4*/ XmlSerializationReaderInterpreter(System.Xml.Serialization.XmlMapping typeMap);
                /*0xbafb0c*/ void InitCallbacks();
                /*0xbaff24*/ void InitIDs();
                /*0xbaff28*/ object ReadRoot();
                /*0xbb0108*/ object ReadEncodedObject(System.Xml.Serialization.XmlTypeMapping typeMap);
                /*0xbb020c*/ object ReadMessage(System.Xml.Serialization.XmlMembersMapping typeMap);
                /*0xbb0030*/ object ReadRoot(System.Xml.Serialization.XmlTypeMapping rootMap);
                /*0xbb2e04*/ object ReadObject(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable, bool checkType);
                /*0xbb3554*/ object ReadClassInstance(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable, bool checkType);
                /*0xbb383c*/ void ReadClassInstanceMembers(System.Xml.Serialization.XmlTypeMapping typeMap, object ob);
                /*0xbb07b8*/ void ReadAttributeMembers(System.Xml.Serialization.ClassMap map, object ob, bool isValueList);
                /*0xbb0bbc*/ void ReadMembers(System.Xml.Serialization.ClassMap map, object ob, bool isValueList, bool readBySoapOrder);
                /*0xbb3f48*/ void SetListMembersDefaults(System.Xml.Serialization.ClassMap map, object ob, bool isValueList);
                /*0xbb44b4*/ void FixupMembers(System.Xml.Serialization.ClassMap map, object obfixup, bool isValueList);
                /*0xbb48b8*/ void ProcessUnknownAttribute(object target);
                /*0xbb48ec*/ void ProcessUnknownElement(object target);
                /*0xbb4090*/ bool IsReadOnly(System.Xml.Serialization.XmlTypeMapMember member, System.Xml.Serialization.TypeData memType, object ob, bool isValueList);
                /*0xbb3a1c*/ void SetMemberValue(System.Xml.Serialization.XmlTypeMapMember member, object ob, object value, bool isValueList);
                /*0xbb06f8*/ void SetMemberValueFromAttr(System.Xml.Serialization.XmlTypeMapMember member, object ob, object value, bool isValueList);
                /*0xbb3ba8*/ object GetMemberValue(System.Xml.Serialization.XmlTypeMapMember member, object ob, bool isValueList);
                /*0xbb4258*/ object ReadObjectElement(System.Xml.Serialization.XmlTypeMapElementInfo elem);
                /*0xbb4920*/ object ReadPrimitiveValue(System.Xml.Serialization.XmlTypeMapElementInfo elem);
                /*0xbb38e4*/ object GetValueFromXmlString(string value, System.Xml.Serialization.TypeData typeData, System.Xml.Serialization.XmlTypeMapping typeMap);
                /*0xbb2eec*/ object ReadListElement(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable, object list, bool canCreateInstance);
                /*0xbb4a44*/ object ReadListString(System.Xml.Serialization.XmlTypeMapping typeMap, string values);
                /*0xbb3c74*/ void AddListValue(System.Xml.Serialization.TypeData listType, ref object list, int index, object value, bool canCreateInstance);
                /*0xbb0694*/ object CreateInstance(System.Type type);
                /*0xbb41bc*/ object CreateList(System.Type listType);
                /*0xbb40f4*/ object InitializeList(System.Xml.Serialization.TypeData listType);
                /*0xbb4da4*/ void FillList(object list, object items);
                /*0xbb4db4*/ void CopyEnumerableList(object source, object dest);
                /*0xbb2de8*/ object ReadXmlNodeElement(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable);
                /*0xbb43f4*/ object ReadXmlNode(System.Xml.Serialization.TypeData type, bool wrapped);
                /*0xbb3294*/ object ReadPrimitiveElement(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable);
                /*0xbb3350*/ object ReadEnumElement(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable);
                /*0xbb4c74*/ object GetEnumValue(System.Xml.Serialization.XmlTypeMapping typeMap, string val);
                /*0xbb33c0*/ object ReadXmlSerializableElement(System.Xml.Serialization.XmlTypeMapping typeMap, bool isNullable);

                class FixupCallbackInfo
                {
                    /*0x10*/ System.Xml.Serialization.XmlSerializationReaderInterpreter _sri;
                    /*0x18*/ System.Xml.Serialization.ClassMap _map;
                    /*0x20*/ bool _isValueList;

                    /*0xbb4180*/ FixupCallbackInfo(System.Xml.Serialization.XmlSerializationReaderInterpreter sri, System.Xml.Serialization.ClassMap map, bool isValueList);
                    /*0xbb52c0*/ void FixupMembers(object fixup);
                }

                class ReaderCallbackInfo
                {
                    /*0x10*/ System.Xml.Serialization.XmlSerializationReaderInterpreter _sri;
                    /*0x18*/ System.Xml.Serialization.XmlTypeMapping _typeMap;

                    /*0xbafef8*/ ReaderCallbackInfo(System.Xml.Serialization.XmlSerializationReaderInterpreter sri, System.Xml.Serialization.XmlTypeMapping typeMap);
                    /*0xbb52e8*/ object ReadObject();
                }
            }

            class XmlSerializationWriteCallback : System.MulticastDelegate
            {
                /*0xbb5318*/ XmlSerializationWriteCallback(object object, nint method);
                /*0xbb5444*/ void Invoke(object o);
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

                /*0xbb5458*/ XmlSerializationWriter();
                /*0xbb54c8*/ void Initialize(System.Xml.XmlWriter writer, System.Xml.Serialization.XmlSerializerNamespaces nss);
                /*0xbb55e4*/ System.Xml.XmlWriter get_Writer();
                /*0xbb55ec*/ void AddWriteCallback(System.Type type, string typeName, string typeNs, System.Xml.Serialization.XmlSerializationWriteCallback callback);
                /*0xbb56c0*/ System.Exception CreateUnknownAnyElementException(string name, string ns);
                /*0xbb5760*/ System.Exception CreateUnknownTypeException(object o);
                /*0xbb5784*/ System.Exception CreateUnknownTypeException(System.Type type);
                /*0xbb581c*/ string FromXmlQualifiedName(System.Xml.XmlQualifiedName xmlQualifiedName);
                /*0xbb59a8*/ string GetId(object o, bool addToReferencesList);
                /*0xbb5ac4*/ bool AlreadyQueued(object ob);
                /*0xbb5af8*/ string GetNamespacePrefix(string ns);
                /*0xbb58dc*/ string GetQualifiedName(string name, string ns);
                void InitCallbacks();
                /*0xbb5c44*/ void TopLevelElement();
                /*0xbb5c50*/ void WriteAttribute(string localName, string ns, string value);
                /*0xbb5c1c*/ void WriteAttribute(string prefix, string localName, string ns, string value);
                /*0xbb5c64*/ void WriteXmlNode(System.Xml.XmlNode node);
                /*0xbb5d04*/ void WriteElementEncoded(System.Xml.XmlNode node, string name, string ns, bool isNullable, bool any);
                /*0xbb5eec*/ void WriteElementLiteral(System.Xml.XmlNode node, string name, string ns, bool isNullable, bool any);
                /*0xbb60d8*/ void WriteElementQualifiedName(string localName, string ns, System.Xml.XmlQualifiedName value);
                /*0xbb60e0*/ void WriteElementQualifiedName(string localName, string ns, System.Xml.XmlQualifiedName value, System.Xml.XmlQualifiedName xsiType);
                /*0xbb62ec*/ void WriteElementString(string localName, string ns, string value);
                /*0xbb62f4*/ void WriteElementString(string localName, string ns, string value, System.Xml.XmlQualifiedName xsiType);
                /*0xbb62cc*/ void WriteEndElement();
                /*0xbb6444*/ void WriteEndElement(object o);
                /*0xbb6484*/ void WriteNamespaceDeclarations(System.Xml.Serialization.XmlSerializerNamespaces xmlns);
                /*0xbb68b0*/ void WriteNullableQualifiedNameEncoded(string name, string ns, System.Xml.XmlQualifiedName value, System.Xml.XmlQualifiedName xsiType);
                /*0xbb6968*/ void WriteNullableQualifiedNameLiteral(string name, string ns, System.Xml.XmlQualifiedName value);
                /*0xbb6a1c*/ void WriteNullableStringEncoded(string name, string ns, string value, System.Xml.XmlQualifiedName xsiType);
                /*0xbb6a28*/ void WriteNullableStringLiteral(string name, string ns, string value);
                /*0xbb5e2c*/ void WriteNullTagEncoded(string name, string ns);
                /*0xbb6014*/ void WriteNullTagLiteral(string name, string ns);
                /*0xbb6a38*/ void WritePotentiallyReferencingElement(string n, string ns, object o, System.Type ambientType, bool suppressReference, bool isNullable);
                /*0xbb7050*/ void WriteReferencedElements();
                /*0xbb6f5c*/ bool IsPrimitiveArray(System.Xml.Serialization.TypeData td);
                /*0xbb726c*/ void WriteArray(object o, System.Xml.Serialization.TypeData td);
                /*0xbb7570*/ void WriteReferencingElement(string n, string ns, object o, bool isNullable);
                /*0xbb6edc*/ void CheckReferenceQueue();
                /*0xbb76cc*/ void WriteSerializable(System.Xml.Serialization.IXmlSerializable serializable, string name, string ns, bool isNullable);
                /*0xbb76d8*/ void WriteSerializable(System.Xml.Serialization.IXmlSerializable serializable, string name, string ns, bool isNullable, bool wrapped);
                /*0xbb7814*/ void WriteStartDocument();
                /*0xbb61fc*/ void WriteStartElement(string name, string ns);
                /*0xbb6ecc*/ void WriteStartElement(string name, string ns, bool writePrefixed);
                /*0xbb7868*/ void WriteStartElement(string name, string ns, object o);
                /*0xbb785c*/ void WriteStartElement(string name, string ns, object o, bool writePrefixed);
                /*0xbb7874*/ void WriteStartElement(string name, string ns, object o, bool writePrefixed, System.Collections.ICollection namespaces);
                /*0xbb815c*/ void WriteTypedPrimitive(string name, string ns, object o, bool xsiType);
                /*0xbb8428*/ void WriteValue(string value);
                /*0xbb8458*/ void WriteXmlAttribute(System.Xml.XmlNode node, object container);
                /*0xbb620c*/ void WriteXsiType(string name, string ns);

                class WriteCallbackInfo
                {
                    /*0x10*/ System.Type Type;
                    /*0x18*/ string TypeName;
                    /*0x20*/ string TypeNs;
                    /*0x28*/ System.Xml.Serialization.XmlSerializationWriteCallback Callback;

                    /*0x1c23158*/ WriteCallbackInfo();
                }
            }

            class XmlSerializationWriterInterpreter : System.Xml.Serialization.XmlSerializationWriter
            {
                /*0x48*/ System.Xml.Serialization.XmlMapping _typeMap;
                /*0x50*/ System.Xml.Serialization.SerializationFormat _format;

                static /*0x1c24040*/ object ImplicitConvert(object obj, System.Type type);
                /*0x1c23160*/ XmlSerializationWriterInterpreter(System.Xml.Serialization.XmlMapping typeMap);
                /*0x1c23198*/ void InitCallbacks();
                /*0x1c23600*/ void WriteRoot(object ob);
                /*0x1c23814*/ void WriteObject(System.Xml.Serialization.XmlTypeMapping typeMap, object ob, string element, string namesp, bool isNullable, bool needType, bool writeWrappingElem);
                /*0x1c244dc*/ void WriteMessage(System.Xml.Serialization.XmlMembersMapping membersMap, object[] parameters);
                /*0x1c24708*/ void WriteObjectElement(System.Xml.Serialization.XmlTypeMapping typeMap, object ob, string element, string namesp);
                /*0x1c24968*/ void WriteObjectElementAttributes(System.Xml.Serialization.XmlTypeMapping typeMap, object ob);
                /*0x1c2516c*/ void WriteObjectElementElements(System.Xml.Serialization.XmlTypeMapping typeMap, object ob);
                /*0x1c246c4*/ void WriteMembers(System.Xml.Serialization.ClassMap map, object ob, bool isValueList);
                /*0x1c24a0c*/ void WriteAttributeMembers(System.Xml.Serialization.ClassMap map, object ob, bool isValueList);
                /*0x1c25210*/ void WriteElementMembers(System.Xml.Serialization.ClassMap map, object ob, bool isValueList);
                /*0x1c25b8c*/ object GetMemberValue(System.Xml.Serialization.XmlTypeMapMember member, object ob, bool isValueList);
                /*0x1c25964*/ bool MemberHasValue(System.Xml.Serialization.XmlTypeMapMember member, object ob, bool isValueList);
                /*0x1c2631c*/ void WriteMemberElement(System.Xml.Serialization.XmlTypeMapElementInfo elem, object memberValue);
                /*0x1c28028*/ void WritePrimitiveValueLiteral(object memberValue, string name, string ns, System.Xml.Serialization.XmlTypeMapping mappedType, System.Xml.Serialization.TypeData typeData, bool wrapped, bool isNullable);
                /*0x1c28340*/ void WritePrimitiveValueEncoded(object memberValue, string name, string ns, System.Xml.XmlQualifiedName xsiType, System.Xml.Serialization.XmlTypeMapping mappedType, System.Xml.Serialization.TypeData typeData, bool wrapped, bool isNullable);
                /*0x1c285b4*/ void WriteListElement(System.Xml.Serialization.XmlTypeMapping typeMap, object ob, string element, string namesp);
                /*0x1c2689c*/ void WriteListContent(object container, System.Xml.Serialization.TypeData listType, System.Xml.Serialization.ListMap map, object ob, System.Text.StringBuilder targetString);
                /*0x1c287a0*/ int GetListCount(System.Xml.Serialization.TypeData listType, object ob);
                /*0x1c270a8*/ void WriteAnyElementContent(System.Xml.Serialization.XmlTypeMapMemberAnyElement member, object memberValue);
                /*0x1c29664*/ void WritePrimitiveElement(System.Xml.Serialization.XmlTypeMapping typeMap, object ob, string element, string namesp);
                /*0x1c296a0*/ void WriteEnumElement(System.Xml.Serialization.XmlTypeMapping typeMap, object ob, string element, string namesp);
                /*0x1c26068*/ string GetStringValue(System.Xml.Serialization.XmlTypeMapping typeMap, System.Xml.Serialization.TypeData type, object value);
                /*0x1c296d0*/ string GetEnumXmlValue(System.Xml.Serialization.XmlTypeMapping typeMap, object ob);

                class CallbackInfo
                {
                    /*0x10*/ System.Xml.Serialization.XmlSerializationWriterInterpreter _swi;
                    /*0x18*/ System.Xml.Serialization.XmlTypeMapping _typeMap;

                    /*0x1c235d4*/ CallbackInfo(System.Xml.Serialization.XmlSerializationWriterInterpreter swi, System.Xml.Serialization.XmlTypeMapping typeMap);
                    /*0x1c29b18*/ void WriteObject(object ob);
                    /*0x1c29b68*/ void WriteEnum(object ob);
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

                static /*0x1c29bb8*/ XmlSerializer();
                /*0x1c29c64*/ XmlSerializer(System.Type type, System.Xml.Serialization.XmlAttributeOverrides overrides, System.Type[] extraTypes, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
                /*0x1c29de8*/ System.Xml.Serialization.XmlMapping get_Mapping();
                /*0x1c29df0*/ void OnUnknownAttribute(System.Xml.Serialization.XmlAttributeEventArgs e);
                /*0x1c29e18*/ void OnUnknownElement(System.Xml.Serialization.XmlElementEventArgs e);
                /*0x1c29e40*/ void OnUnknownNode(System.Xml.Serialization.XmlNodeEventArgs e);
                /*0x1c29e68*/ void OnUnreferencedObject(System.Xml.Serialization.UnreferencedObjectEventArgs e);
                /*0x1c29e90*/ System.Xml.Serialization.XmlSerializationReader CreateReader();
                /*0x1c29ed0*/ System.Xml.Serialization.XmlSerializationWriter CreateWriter();
                /*0x1c29f10*/ object Deserialize(System.IO.TextReader textReader);
                /*0x1c29fa4*/ object Deserialize(System.Xml.XmlReader xmlReader);
                /*0x1c2a078*/ object Deserialize(System.Xml.Serialization.XmlSerializationReader reader);
                /*0x1c2a35c*/ void Serialize(object o, System.Xml.Serialization.XmlSerializationWriter writer);
                /*0x1c2a550*/ void Serialize(System.IO.TextWriter textWriter, object o);
                /*0x1c2a8f4*/ void Serialize(System.Xml.XmlWriter xmlWriter, object o);
                /*0x1c2a5e0*/ void Serialize(System.Xml.XmlWriter xmlWriter, object o, System.Xml.Serialization.XmlSerializerNamespaces namespaces);
                /*0x1c2a8fc*/ System.Xml.Serialization.XmlSerializationWriter CreateWriter(System.Xml.Serialization.XmlMapping typeMapping);
                /*0x1c2a014*/ System.Xml.Serialization.XmlSerializationReader CreateReader(System.Xml.Serialization.XmlMapping typeMapping);

                class SerializerData
                {
                    /*0x10*/ System.Reflection.MethodInfo ReaderMethod;
                    /*0x18*/ System.Type WriterType;
                    /*0x20*/ System.Reflection.MethodInfo WriterMethod;
                    /*0x28*/ System.Xml.Serialization.XmlSerializerImplementation Implementation;

                    /*0x1c2ab08*/ System.Xml.Serialization.XmlSerializationWriter CreateWriter();
                }
            }

            class XmlSerializerFactory
            {
                static /*0x0*/ System.Collections.Hashtable serializersBySource;

                static /*0x1c2ae88*/ XmlSerializerFactory();
                /*0x1c2abe0*/ XmlSerializerFactory();
                /*0x1c2abe8*/ System.Xml.Serialization.XmlSerializer CreateSerializer(System.Type type);
                /*0x1c2ae74*/ System.Xml.Serialization.XmlSerializer CreateSerializer(System.Type type, System.Xml.Serialization.XmlRootAttribute root);
                /*0x1c2abfc*/ System.Xml.Serialization.XmlSerializer CreateSerializer(System.Type type, System.Xml.Serialization.XmlAttributeOverrides overrides, System.Type[] extraTypes, System.Xml.Serialization.XmlRootAttribute root, string defaultNamespace);
            }

            class XmlSerializerImplementation
            {
                /*0x1c2af00*/ System.Xml.Serialization.XmlSerializationWriter get_Writer();
            }

            class XmlTextAttribute : System.Attribute
            {
                /*0x10*/ string dataType;
                /*0x18*/ System.Type type;

                /*0x1c2af40*/ XmlTextAttribute();
                /*0x1c2af48*/ string get_DataType();
                /*0x1c2af9c*/ System.Type get_Type();
                /*0x1c2afa4*/ void AddKeyHash(System.Text.StringBuilder sb);
            }

            class XmlTypeAttribute : System.Attribute
            {
                /*0x10*/ bool includeInSchema;
                /*0x18*/ string ns;
                /*0x20*/ string typeName;

                /*0x1c2b034*/ bool get_IncludeInSchema();
                /*0x1c2b03c*/ string get_Namespace();
                /*0x1c2b044*/ string get_TypeName();
                /*0x1c2b098*/ void AddKeyHash(System.Text.StringBuilder sb);
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

                /*0x1c2b13c*/ XmlTypeMapElementInfo(System.Xml.Serialization.XmlTypeMapMember member, System.Xml.Serialization.TypeData type);
                /*0x1c2b1e8*/ System.Xml.Serialization.TypeData get_TypeData();
                /*0x1c2b1f0*/ object get_ChoiceValue();
                /*0x1c2b1f8*/ void set_ChoiceValue(object value);
                /*0x1c2b200*/ string get_ElementName();
                /*0x1c2b208*/ void set_ElementName(string value);
                /*0x1c2b210*/ string get_Namespace();
                /*0x1c2b218*/ void set_Namespace(string value);
                /*0x1c282b8*/ string get_DataTypeNamespace();
                /*0x1c28288*/ string get_DataTypeName();
                /*0x1c2b220*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0x1c2b228*/ void set_Form(System.Xml.Schema.XmlSchemaForm value);
                /*0x1c2b230*/ System.Xml.Serialization.XmlTypeMapping get_MappedType();
                /*0x1c2b238*/ void set_MappedType(System.Xml.Serialization.XmlTypeMapping value);
                /*0x1c2b240*/ bool get_IsNullable();
                /*0x1c2b248*/ void set_IsNullable(bool value);
                /*0x1c2b254*/ System.Xml.Serialization.XmlTypeMapMember get_Member();
                /*0x1c2b25c*/ void set_NestingLevel(int value);
                /*0x1c2b264*/ bool get_MultiReferenceType();
                /*0x1c2b284*/ bool get_WrappedElement();
                /*0x1c2b28c*/ void set_WrappedElement(bool value);
                /*0x1c2b298*/ bool get_IsTextElement();
                /*0x1c2b2e4*/ void set_IsTextElement(bool value);
                /*0x1c2b3a4*/ bool get_IsUnnamedAnyElement();
                /*0x1c2b3f8*/ void set_IsUnnamedAnyElement(bool value);
                /*0x1c2b49c*/ int get_ExplicitOrder();
                /*0x1c2b4a4*/ void set_ExplicitOrder(int value);
                /*0x1c2b4ac*/ bool Equals(object other);
                /*0x1c2b5e4*/ int GetHashCode();
            }

            class XmlTypeMapElementInfoList : System.Collections.ArrayList
            {
                /*0x1c2b5ec*/ XmlTypeMapElementInfoList();
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

                static /*0x1c2b974*/ object GetValue(object ob, string name);
                static /*0x1c2bc18*/ void SetValue(object ob, string name, object value);
                /*0x1c2b5f4*/ XmlTypeMapMember();
                /*0x1c2b664*/ string get_Name();
                /*0x1c2b66c*/ void set_Name(string value);
                /*0x1c2b674*/ object get_DefaultValue();
                /*0x1c2b67c*/ void set_DefaultValue(object value);
                /*0x1c2b684*/ bool IsReadOnly(System.Type type);
                /*0x1c24830*/ object GetValue(object ob);
                /*0x1c2bab8*/ void SetValue(object ob, object value);
                /*0x1c2b738*/ void InitMember(System.Type type);
                /*0x1c2bd70*/ System.Xml.Serialization.TypeData get_TypeData();
                /*0x1c2bd78*/ void set_TypeData(System.Xml.Serialization.TypeData value);
                /*0x1c2bd80*/ int get_Index();
                /*0x1c2bd88*/ void set_Index(int value);
                /*0x1c2bd90*/ int get_GlobalIndex();
                /*0x1c2bd98*/ void set_GlobalIndex(int value);
                /*0x1c27dc4*/ bool get_IsOptionalValueType();
                /*0x1c2bda0*/ void set_IsOptionalValueType(bool value);
                /*0x1c2bdcc*/ bool get_IsReturnValue();
                /*0x1c2bdd8*/ void set_IsReturnValue(bool value);
                /*0x1c2be04*/ void CheckOptionalValueType(System.Type type);
                /*0x1c27dd0*/ bool GetValueSpecified(object ob);
                /*0x1c2be84*/ void SetValueSpecified(object ob, bool value);
            }

            class XmlTypeMapMemberAttribute : System.Xml.Serialization.XmlTypeMapMember
            {
                /*0x58*/ string _attributeName;
                /*0x60*/ string _namespace;
                /*0x68*/ System.Xml.Schema.XmlSchemaForm _form;
                /*0x70*/ System.Xml.Serialization.XmlTypeMapping _mappedType;

                /*0x1c2c120*/ XmlTypeMapMemberAttribute();
                /*0x1c2c16c*/ string get_AttributeName();
                /*0x1c2c174*/ void set_AttributeName(string value);
                /*0x1c2c17c*/ string get_Namespace();
                /*0x1c2c184*/ void set_Namespace(string value);
                /*0x1c2c18c*/ void set_Form(System.Xml.Schema.XmlSchemaForm value);
                /*0x1c2c194*/ System.Xml.Serialization.XmlTypeMapping get_MappedType();
                /*0x1c2c19c*/ void set_MappedType(System.Xml.Serialization.XmlTypeMapping value);
            }

            class XmlTypeMapMemberElement : System.Xml.Serialization.XmlTypeMapMember
            {
                /*0x58*/ System.Xml.Serialization.XmlTypeMapElementInfoList _elementInfo;
                /*0x60*/ string _choiceMember;
                /*0x68*/ bool _isTextCollector;
                /*0x70*/ System.Xml.Serialization.TypeData _choiceTypeData;

                /*0x1c2c1a4*/ XmlTypeMapMemberElement();
                /*0x1c262b0*/ System.Xml.Serialization.XmlTypeMapElementInfoList get_ElementInfo();
                /*0x1c2c1a8*/ void set_ElementInfo(System.Xml.Serialization.XmlTypeMapElementInfoList value);
                /*0x1c2c1b0*/ string get_ChoiceMember();
                /*0x1c2c1b8*/ void set_ChoiceMember(string value);
                /*0x1c2c1c0*/ System.Xml.Serialization.TypeData get_ChoiceTypeData();
                /*0x1c2c1c8*/ void set_ChoiceTypeData(System.Xml.Serialization.TypeData value);
                /*0x1c276f0*/ System.Xml.Serialization.XmlTypeMapElementInfo FindElement(object ob, object memberValue);
                /*0x1c2c1d0*/ void SetChoice(object ob, object choice);
                /*0x1c2c1e0*/ bool get_IsXmlTextCollector();
                /*0x1c2c1e8*/ void set_IsXmlTextCollector(bool value);
            }

            class XmlTypeMapMemberList : System.Xml.Serialization.XmlTypeMapMemberElement
            {
                /*0x1c2c1f4*/ XmlTypeMapMemberList();
            }

            class XmlTypeMapMemberExpandable : System.Xml.Serialization.XmlTypeMapMemberElement
            {
                /*0x78*/ int _flatArrayIndex;

                /*0x1c2c208*/ XmlTypeMapMemberExpandable();
                /*0x1c2c1f8*/ int get_FlatArrayIndex();
                /*0x1c2c200*/ void set_FlatArrayIndex(int value);
            }

            class XmlTypeMapMemberFlatList : System.Xml.Serialization.XmlTypeMapMemberExpandable
            {
                /*0x80*/ System.Xml.Serialization.ListMap _listMap;

                /*0x1c2c21c*/ XmlTypeMapMemberFlatList();
                /*0x1c2c20c*/ System.Xml.Serialization.ListMap get_ListMap();
                /*0x1c2c214*/ void set_ListMap(System.Xml.Serialization.ListMap value);
            }

            class XmlTypeMapMemberAnyElement : System.Xml.Serialization.XmlTypeMapMemberExpandable
            {
                /*0x1c2c51c*/ XmlTypeMapMemberAnyElement();
                /*0x1c29318*/ bool IsElementDefined(string name, string ns);
                /*0x1c2c220*/ bool get_IsDefaultAny();
            }

            class XmlTypeMapMemberAnyAttribute : System.Xml.Serialization.XmlTypeMapMember
            {
                /*0x1c2c520*/ XmlTypeMapMemberAnyAttribute();
            }

            class XmlTypeMapMemberNamespaces : System.Xml.Serialization.XmlTypeMapMember
            {
                /*0x1c2c524*/ XmlTypeMapMemberNamespaces();
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

                /*0x1c2c528*/ XmlTypeMapping(string elementName, string ns, System.Xml.Serialization.TypeData typeData, string xmlType, string xmlTypeNamespace);
                /*0x1c29778*/ string get_TypeFullName();
                /*0x1c2c5d8*/ System.Xml.Serialization.TypeData get_TypeData();
                /*0x1c2c5e0*/ string get_XmlType();
                /*0x1c2c5e8*/ void set_XmlType(string value);
                /*0x1c24488*/ string get_XmlTypeNamespace();
                /*0x1c2c5f0*/ void set_XmlTypeNamespace(string value);
                /*0x1c2c5f8*/ bool get_HasXmlTypeNamespace();
                /*0x1c2c608*/ System.Collections.ArrayList get_DerivedTypes();
                /*0x1c2c610*/ bool get_MultiReferenceType();
                /*0x1c2c618*/ System.Xml.Serialization.XmlTypeMapping get_BaseMap();
                /*0x1c2c620*/ void set_BaseMap(System.Xml.Serialization.XmlTypeMapping value);
                /*0x1c2c628*/ void set_IncludeInSchema(bool value);
                /*0x1c2c634*/ bool get_IsNullable();
                /*0x1c2c63c*/ void set_IsNullable(bool value);
                /*0x1c2c648*/ bool get_IsAny();
                /*0x1c2c650*/ void set_IsAny(bool value);
                /*0x1c24318*/ System.Xml.Serialization.XmlTypeMapping GetRealTypeMap(System.Type objectType);
                /*0x1c2c65c*/ System.Xml.Serialization.XmlTypeMapping GetRealElementMap(string name, string ens);
                /*0x1c2ca38*/ void UpdateRoot(System.Xml.XmlQualifiedName qname);
            }

            class XmlSerializableMapping : System.Xml.Serialization.XmlTypeMapping
            {
                /*0x78*/ System.Xml.Schema.XmlSchema _schema;
                /*0x80*/ System.Xml.Schema.XmlSchemaComplexType _schemaType;
                /*0x88*/ System.Xml.XmlQualifiedName _schemaTypeName;

                /*0x1c2cab8*/ XmlSerializableMapping(System.Xml.Serialization.XmlRootAttribute root, string elementName, string ns, System.Xml.Serialization.TypeData typeData, string xmlType, string xmlTypeNamespace);
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

                /*0x1c2eea0*/ ClassMap();
                /*0x1c2d224*/ void AddMember(System.Xml.Serialization.XmlTypeMapMember member);
                /*0x1c2df68*/ void RegisterFlatList(System.Xml.Serialization.XmlTypeMapMemberExpandable member);
                /*0x1c2e008*/ System.Xml.Serialization.XmlTypeMapMemberAttribute GetAttribute(string name, string ns);
                /*0x1c2e0c4*/ System.Xml.Serialization.XmlTypeMapElementInfo GetElement(string name, string ns, int minimalOrder);
                /*0x1c2e48c*/ System.Xml.Serialization.XmlTypeMapElementInfo GetElement(string name, string ns);
                /*0x1c2de88*/ string BuildKey(string name, string ns, int explicitOrder);
                /*0x1c2e830*/ bool get_IsOrderDependentMap();
                /*0x1c2ec08*/ System.Xml.Serialization.XmlTypeMapMemberAnyElement get_DefaultAnyElementMember();
                /*0x1c2ec10*/ System.Xml.Serialization.XmlTypeMapMemberAnyAttribute get_DefaultAnyAttributeMember();
                /*0x1c2ec18*/ System.Xml.Serialization.XmlTypeMapMemberNamespaces get_NamespaceDeclarations();
                /*0x1c25c54*/ System.Collections.ICollection get_AttributeMembers();
                /*0x1c2ec20*/ System.Collections.ICollection get_ElementMembers();
                /*0x1c2ec28*/ System.Collections.ArrayList get_AllMembers();
                /*0x1c2ec30*/ System.Collections.ArrayList get_FlatLists();
                /*0x1c2ec38*/ System.Collections.ArrayList get_ListMembers();
                /*0x1c2ec40*/ System.Xml.Serialization.XmlTypeMapMember get_XmlTextCollector();
                /*0x1c2ec48*/ System.Xml.Serialization.XmlTypeMapMember get_ReturnMember();
                /*0x1c2ec50*/ System.Xml.XmlQualifiedName get_SimpleContentBaseType();
                /*0x1c2ee28*/ void SetCanBeSimpleType(bool can);
                /*0x1c2ee34*/ bool get_HasSimpleContent();
            }

            class ListMap : System.Xml.Serialization.ObjectMap
            {
                /*0x10*/ System.Xml.Serialization.XmlTypeMapElementInfoList _itemInfo;
                /*0x18*/ string _choiceMember;

                /*0x1c2f6ec*/ ListMap();
                /*0x1c2ef40*/ void set_ChoiceMember(string value);
                /*0x1c2ef48*/ System.Xml.Serialization.XmlTypeMapElementInfoList get_ItemInfo();
                /*0x1c2ef50*/ void set_ItemInfo(System.Xml.Serialization.XmlTypeMapElementInfoList value);
                /*0x1c28ad0*/ System.Xml.Serialization.XmlTypeMapElementInfo FindElement(object ob, int index, object memberValue);
                /*0x1c2ef58*/ System.Xml.Serialization.XmlTypeMapElementInfo FindElement(string elementName, string ns);
                /*0x1c2f288*/ System.Xml.Serialization.XmlTypeMapElementInfo FindTextElement();
                /*0x1c288c8*/ void GetArrayType(int itemCount, ref string localName, ref string ns);
                /*0x1c2f588*/ bool Equals(object other);
                /*0x1c2f6e4*/ int GetHashCode();
            }

            class EnumMap : System.Xml.Serialization.ObjectMap
            {
                /*0x10*/ System.Xml.Serialization.EnumMap.EnumMapMember[] _members;
                /*0x18*/ bool _isFlags;
                /*0x20*/ string[] _enumNames;
                /*0x28*/ string[] _xmlNames;
                /*0x30*/ long[] _values;

                /*0x1c2f6f4*/ EnumMap(System.Xml.Serialization.EnumMap.EnumMapMember[] members, bool isFlags);
                /*0x1c2f888*/ bool get_IsFlags();
                /*0x1c2f890*/ string[] get_EnumNames();
                /*0x1c2f898*/ string[] get_XmlNames();
                /*0x1c2f8a0*/ long[] get_Values();
                /*0x1c29794*/ string GetXmlName(string typeName, object enumValue);
                /*0x1c2f8a8*/ string GetEnumName(string typeName, string xmlName);

                class EnumMapMember
                {
                    /*0x10*/ string _xmlName;
                    /*0x18*/ string _enumName;
                    /*0x20*/ long _value;

                    /*0x1c2fb88*/ EnumMapMember(string xmlName, string enumName, long value);
                    /*0x1c2fbc4*/ string get_XmlName();
                    /*0x1c2fbcc*/ string get_EnumName();
                    /*0x1c2fbd4*/ long get_Value();
                }
            }
        }

        namespace XmlConfiguration
        {
            class XmlReaderSection
            {
                static /*0x1c2fbdc*/ bool get_ProhibitDefaultUrlResolver();
                static /*0x1c2fbe4*/ System.Xml.XmlResolver CreateDefaultResolver();
                static /*0x1c2fc40*/ bool get_CollapseWhiteSpaceIntoEmptyString();
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

                    /*0x1c2fc48*/ void Clear();
                    /*0x1c2fc54*/ int get_Count();
                    /*0x1c2fc5c*/ string GetResult();
                    /*0x1c2fd50*/ void ConcatNoDelimiter(string s);
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

                /*0x1c30010*/ AxisElement(System.Xml.Schema.DoubleLinkAxis node, int depth);
                /*0x1c30008*/ System.Xml.Schema.DoubleLinkAxis get_CurNode();
                /*0x1c30044*/ void SetDepth(int depth);
                /*0x1c3004c*/ void MoveToParent(int depth, System.Xml.Schema.ForwardAxis parent);
                /*0x1c30158*/ bool MoveToChild(string name, string URN, int depth, System.Xml.Schema.ForwardAxis parent);
            }

            class AxisStack
            {
                /*0x10*/ System.Collections.ArrayList _stack;
                /*0x18*/ System.Xml.Schema.ForwardAxis _subtree;
                /*0x20*/ System.Xml.Schema.ActiveAxis _parent;

                static /*0x1c302f0*/ bool Equal(string thisname, string thisURN, string name, string URN);
                /*0x1c30398*/ AxisStack(System.Xml.Schema.ForwardAxis faxis, System.Xml.Schema.ActiveAxis parent);
                /*0x1c3036c*/ System.Xml.Schema.ForwardAxis get_Subtree();
                /*0x1c30374*/ int get_Length();
                /*0x1c30440*/ void Push(int depth);
                /*0x1c304d8*/ void Pop();
                /*0x1c30518*/ void MoveToParent(string name, string URN, int depth);
                /*0x1c30660*/ bool MoveToChild(string name, string URN, int depth);
                /*0x1c307a0*/ bool MoveToAttribute(string name, string URN, int depth);
            }

            class ActiveAxis
            {
                /*0x10*/ int _currentDepth;
                /*0x14*/ bool _isActive;
                /*0x18*/ System.Xml.Schema.Asttree _axisTree;
                /*0x20*/ System.Collections.ArrayList _axisStack;

                /*0x1c30930*/ ActiveAxis(System.Xml.Schema.Asttree axisTree);
                /*0x1c30914*/ int get_CurrentDepth();
                /*0x1c3091c*/ void Reactivate();
                /*0x1c30adc*/ bool MoveToStartElement(string localname, string URN);
                /*0x1c30c1c*/ bool EndElement(string localname, string URN);
                /*0x1c30d2c*/ bool MoveToAttribute(string localname, string URN);
            }

            class DoubleLinkAxis : MS.Internal.Xml.XPath.Axis
            {
                /*0x40*/ MS.Internal.Xml.XPath.Axis next;

                static /*0x1c30ea0*/ System.Xml.Schema.DoubleLinkAxis ConvertTree(MS.Internal.Xml.XPath.Axis axis);
                /*0x1c30e48*/ DoubleLinkAxis(MS.Internal.Xml.XPath.Axis axis, System.Xml.Schema.DoubleLinkAxis inputaxis);
                /*0x1c30e38*/ MS.Internal.Xml.XPath.Axis get_Next();
                /*0x1c30e40*/ void set_Next(MS.Internal.Xml.XPath.Axis value);
            }

            class ForwardAxis
            {
                /*0x10*/ System.Xml.Schema.DoubleLinkAxis _topNode;
                /*0x18*/ System.Xml.Schema.DoubleLinkAxis _rootNode;
                /*0x20*/ bool _isAttribute;
                /*0x21*/ bool _isDss;
                /*0x22*/ bool _isSelfAxis;

                /*0x1c30f90*/ ForwardAxis(System.Xml.Schema.DoubleLinkAxis axis, bool isdesorself);
                /*0x1c30f68*/ System.Xml.Schema.DoubleLinkAxis get_RootNode();
                /*0x1c30f70*/ System.Xml.Schema.DoubleLinkAxis get_TopNode();
                /*0x1c30f78*/ bool get_IsAttribute();
                /*0x1c30f80*/ bool get_IsDss();
                /*0x1c30f88*/ bool get_IsSelfAxis();
            }

            class Asttree
            {
                /*0x10*/ System.Collections.ArrayList _fAxisArray;
                /*0x18*/ string _xpathexpr;
                /*0x20*/ bool _isField;
                /*0x28*/ System.Xml.XmlNamespaceManager _nsmgr;

                static /*0x1c31904*/ bool IsNameTest(MS.Internal.Xml.XPath.Axis ast);
                static /*0x1c302bc*/ bool IsAttribute(MS.Internal.Xml.XPath.Axis ast);
                static /*0x1c31938*/ bool IsDescendantOrSelf(MS.Internal.Xml.XPath.Axis ast);
                static /*0x1c310a8*/ bool IsSelf(MS.Internal.Xml.XPath.Axis ast);
                /*0x1c310f0*/ Asttree(string xPath, bool isField, System.Xml.XmlNamespaceManager nsmgr);
                /*0x1c310e8*/ System.Collections.ArrayList get_SubtreeArray();
                /*0x1c31140*/ void CompileXPath(string xPath, bool isField, System.Xml.XmlNamespaceManager nsmgr);
                /*0x1c31978*/ void SetURN(MS.Internal.Xml.XPath.Axis axis, System.Xml.XmlNamespaceManager nsmgr);
            }

            class AutoValidator : System.Xml.Schema.BaseValidator
            {
                /*0x1c31a70*/ AutoValidator(System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling);
                /*0x1c31bb4*/ bool get_PreserveWhitespace();
                /*0x1c31bbc*/ void Validate();
                /*0x1c31fe4*/ void CompleteValidation();
                /*0x1c31fe8*/ object FindId(string name);
                /*0x1c31ca0*/ System.Xml.ValidationType DetectValidationType();
            }

            class BaseProcessor
            {
                /*0x10*/ System.Xml.XmlNameTable nameTable;
                /*0x18*/ System.Xml.Schema.SchemaNames schemaNames;
                /*0x20*/ System.Xml.Schema.ValidationEventHandler eventHandler;
                /*0x28*/ System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings;
                /*0x30*/ int errorCount;
                /*0x38*/ string NsXml;

                /*0x1c32084*/ BaseProcessor(System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler);
                /*0x1c32110*/ BaseProcessor(System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler, System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings);
                /*0x1c321a4*/ System.Xml.XmlNameTable get_NameTable();
                /*0x1c321ac*/ System.Xml.Schema.SchemaNames get_SchemaNames();
                /*0x1c32220*/ System.Xml.Schema.ValidationEventHandler get_EventHandler();
                /*0x1c32228*/ System.Xml.Schema.XmlSchemaCompilationSettings get_CompilationSettings();
                /*0x1c32230*/ bool get_HasErrors();
                /*0x1c32240*/ void AddToTable(System.Xml.Schema.XmlSchemaObjectTable table, System.Xml.XmlQualifiedName qname, System.Xml.Schema.XmlSchemaObject item);
                /*0x1c326a0*/ bool IsValidAttributeGroupRedefine(System.Xml.Schema.XmlSchemaObject existingObject, System.Xml.Schema.XmlSchemaObject item, System.Xml.Schema.XmlSchemaObjectTable table);
                /*0x1c328f0*/ bool IsValidGroupRedefine(System.Xml.Schema.XmlSchemaObject existingObject, System.Xml.Schema.XmlSchemaObject item, System.Xml.Schema.XmlSchemaObjectTable table);
                /*0x1c327c8*/ bool IsValidTypeRedefine(System.Xml.Schema.XmlSchemaObject existingObject, System.Xml.Schema.XmlSchemaObject item, System.Xml.Schema.XmlSchemaObjectTable table);
                /*0x1c32a94*/ void SendValidationEvent(string code, System.Xml.Schema.XmlSchemaObject source);
                /*0x1c32a04*/ void SendValidationEvent(string code, string msg, System.Xml.Schema.XmlSchemaObject source);
                /*0x1c32be0*/ void SendValidationEvent(string code, string msg1, string msg2, System.Xml.Schema.XmlSchemaObject source);
                /*0x1c32cf8*/ void SendValidationEvent(string code, string[] args, System.Exception innerException, System.Xml.Schema.XmlSchemaObject source);
                /*0x1c32db8*/ void SendValidationEvent(string code, string msg1, string msg2, string sourceUri, int lineNumber, int linePosition);
                /*0x1c32ee8*/ void SendValidationEvent(string code, System.Xml.Schema.XmlSchemaObject source, System.Xml.Schema.XmlSeverityType severity);
                /*0x1c32f74*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e);
                /*0x1c32f7c*/ void SendValidationEvent(string code, string msg, System.Xml.Schema.XmlSchemaObject source, System.Xml.Schema.XmlSeverityType severity);
                /*0x1c32b14*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity);
                /*0x1c33010*/ void SendValidationEventNoThrow(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity);
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

                static /*0x1c33c90*/ void ProcessEntity(System.Xml.Schema.SchemaInfo sinfo, string name, object sender, System.Xml.Schema.ValidationEventHandler eventhandler, string baseUri, int lineNumber, int linePosition);
                static /*0x1c33e74*/ void ProcessEntity(System.Xml.Schema.SchemaInfo sinfo, string name, System.Xml.IValidationEventHandling eventHandling, string baseUriStr, int lineNumber, int linePosition);
                static /*0x1c34070*/ System.Xml.Schema.BaseValidator CreateInstance(System.Xml.ValidationType valType, System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling, bool processIdentityConstraints);
                /*0x1c330c0*/ BaseValidator(System.Xml.Schema.BaseValidator other);
                /*0x1c31b00*/ BaseValidator(System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling);
                /*0x1c3311c*/ System.Xml.XmlValidatingReaderImpl get_Reader();
                /*0x1c33124*/ System.Xml.Schema.XmlSchemaCollection get_SchemaCollection();
                /*0x1c3312c*/ System.Xml.XmlNameTable get_NameTable();
                /*0x1c31ff0*/ System.Xml.Schema.SchemaNames get_SchemaNames();
                /*0x1c33134*/ System.Xml.PositionInfo get_PositionInfo();
                /*0x1c3313c*/ System.Xml.XmlResolver get_XmlResolver();
                /*0x1c33144*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x1c3314c*/ System.Uri get_BaseUri();
                /*0x1c33154*/ void set_BaseUri(System.Uri value);
                /*0x1c3315c*/ System.Xml.Schema.ValidationEventHandler get_EventHandler();
                /*0x1c3322c*/ System.Xml.Schema.SchemaInfo get_SchemaInfo();
                /*0x1c33234*/ void set_DtdInfo(System.Xml.IDtdInfo value);
                /*0x1c33310*/ bool get_PreserveWhitespace();
                /*0x1c33318*/ void Validate();
                /*0x1c3331c*/ void CompleteValidation();
                /*0x1c33320*/ object FindId(string name);
                /*0x1c33328*/ void ValidateText();
                /*0x1c33818*/ void ValidateWhitespace();
                /*0x1c337a4*/ void SaveTextValue(string value);
                /*0x1c33954*/ void SendValidationEvent(string code);
                /*0x1c336b8*/ void SendValidationEvent(string code, string[] args);
                /*0x1c335cc*/ void SendValidationEvent(string code, string arg);
                /*0x1c339b4*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e);
                /*0x1c33aa0*/ void SendValidationEvent(string code, string msg, System.Xml.Schema.XmlSeverityType severity);
                /*0x1c33b98*/ void SendValidationEvent(string code, string[] args, System.Xml.Schema.XmlSeverityType severity);
                /*0x1c339bc*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity);
            }

            class BitSet
            {
                /*0x10*/ int count;
                /*0x18*/ uint[] bits;

                /*0x1c34210*/ BitSet();
                /*0x1c34218*/ BitSet(int count);
                /*0x1c34290*/ int get_Count();
                /*0x1c34298*/ bool get_Item(int index);
                /*0x1c342f8*/ void Clear();
                /*0x1c3434c*/ void Set(int index);
                /*0x1c3429c*/ bool Get(int index);
                /*0x1c3443c*/ int NextSet(int startFrom);
                /*0x1c344d8*/ void And(System.Xml.Schema.BitSet other);
                /*0x1c34590*/ void Or(System.Xml.Schema.BitSet other);
                /*0x1c34634*/ int GetHashCode();
                /*0x1c3466c*/ bool Equals(object obj);
                /*0x1c347b4*/ System.Xml.Schema.BitSet Clone();
                /*0x1c34888*/ bool get_IsEmpty();
                /*0x1c348f0*/ bool Intersects(System.Xml.Schema.BitSet other);
                /*0x1c34288*/ int Subscript(int bitIndex);
                /*0x1c343a8*/ void EnsureLength(int nRequiredLength);
            }

            class ChameleonKey
            {
                /*0x10*/ string targetNS;
                /*0x18*/ System.Uri chameleonLocation;
                /*0x20*/ System.Xml.Schema.XmlSchema originalSchema;
                /*0x28*/ int hashCode;

                /*0x1c349d0*/ ChameleonKey(string ns, System.Xml.Schema.XmlSchema originalSchema);
                /*0x1c34a28*/ int GetHashCode();
                /*0x1c34aa8*/ bool Equals(object obj);
            }

            class CompiledIdentityConstraint
            {
                static /*0x0*/ System.Xml.Schema.CompiledIdentityConstraint Empty;
                /*0x10*/ System.Xml.XmlQualifiedName name;
                /*0x18*/ System.Xml.Schema.CompiledIdentityConstraint.ConstraintRole role;
                /*0x20*/ System.Xml.Schema.Asttree selector;
                /*0x28*/ System.Xml.Schema.Asttree[] fields;
                /*0x30*/ System.Xml.XmlQualifiedName refer;

                static /*0x1c350c8*/ CompiledIdentityConstraint();
                /*0x1c34b9c*/ CompiledIdentityConstraint();
                /*0x1c34c08*/ CompiledIdentityConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint constraint, System.Xml.XmlNamespaceManager nsmgr);
                /*0x1c34b84*/ System.Xml.Schema.CompiledIdentityConstraint.ConstraintRole get_Role();
                /*0x1c34b8c*/ System.Xml.Schema.Asttree get_Selector();
                /*0x1c34b94*/ System.Xml.Schema.Asttree[] get_Fields();

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

                /*0x1c35130*/ ConstraintStruct(System.Xml.Schema.CompiledIdentityConstraint constraint);
                /*0x1c35128*/ int get_TableDim();
            }

            class LocatedActiveAxis : System.Xml.Schema.ActiveAxis
            {
                /*0x28*/ int column;
                /*0x2c*/ bool isMatched;
                /*0x30*/ System.Xml.Schema.KeySequence Ks;

                /*0x1c352c0*/ LocatedActiveAxis(System.Xml.Schema.Asttree astfield, System.Xml.Schema.KeySequence ks, int column);
                /*0x1c352b8*/ int get_Column();
                /*0x1c352f0*/ void Reactivate(System.Xml.Schema.KeySequence ks);
            }

            class SelectorActiveAxis : System.Xml.Schema.ActiveAxis
            {
                /*0x28*/ System.Xml.Schema.ConstraintStruct cs;
                /*0x30*/ System.Collections.ArrayList KSs;
                /*0x38*/ int KSpointer;

                /*0x1c3523c*/ SelectorActiveAxis(System.Xml.Schema.Asttree axisTree, System.Xml.Schema.ConstraintStruct cs);
                /*0x1c35308*/ int get_lastDepth();
                /*0x1c353b0*/ bool EndElement(string localname, string URN);
                /*0x1c353f8*/ int PushKS(int errline, int errcol);
                /*0x1c357c8*/ System.Xml.Schema.KeySequence PopKS();
            }

            class KSStruct
            {
                /*0x10*/ int depth;
                /*0x18*/ System.Xml.Schema.KeySequence ks;
                /*0x20*/ System.Xml.Schema.LocatedActiveAxis[] fields;

                /*0x1c35758*/ KSStruct(System.Xml.Schema.KeySequence ks, int dim);
            }

            class TypedObject
            {
                /*0x10*/ System.Xml.Schema.TypedObject.DecimalStruct dstruct;
                /*0x18*/ object ovalue;
                /*0x20*/ string svalue;
                /*0x28*/ System.Xml.Schema.XmlSchemaDatatype xsdtype;
                /*0x30*/ int dim;
                /*0x34*/ bool isList;

                /*0x1c358c0*/ TypedObject(object obj, string svalue, System.Xml.Schema.XmlSchemaDatatype xsdtype);
                /*0x1c35868*/ int get_Dim();
                /*0x1c35870*/ bool get_IsList();
                /*0x1c35878*/ bool get_IsDecimal();
                /*0x1c35894*/ decimal[] get_Dvalue();
                /*0x1c358b0*/ object get_Value();
                /*0x1c358b8*/ System.Xml.Schema.XmlSchemaDatatype get_Type();
                /*0x1c35a1c*/ string ToString();
                /*0x1c35a24*/ void SetDecimal();
                /*0x1c35d40*/ bool ListDValueEquals(System.Xml.Schema.TypedObject other);
                /*0x1c35e50*/ bool Equals(System.Xml.Schema.TypedObject other);

                class DecimalStruct
                {
                    /*0x10*/ bool isDecimal;
                    /*0x18*/ decimal[] dvalue;

                    /*0x1c35ce4*/ DecimalStruct();
                    /*0x1c35c7c*/ DecimalStruct(int dim);
                    /*0x1c360b0*/ bool get_IsDecimal();
                    /*0x1c360b8*/ void set_IsDecimal(bool value);
                    /*0x1c360c4*/ decimal[] get_Dvalue();
                }
            }

            class KeySequence
            {
                /*0x10*/ System.Xml.Schema.TypedObject[] ks;
                /*0x18*/ int dim;
                /*0x1c*/ int hashcode;
                /*0x20*/ int posline;
                /*0x24*/ int poscol;

                /*0x1c356d0*/ KeySequence(int dim, int line, int col);
                /*0x1c360cc*/ int get_PosLine();
                /*0x1c360d4*/ int get_PosCol();
                /*0x1c360dc*/ object get_Item(int index);
                /*0x1c3610c*/ void set_Item(int index, object value);
                /*0x1c36204*/ bool IsQualified();
                /*0x1c36264*/ int GetHashCode();
                /*0x1c365b8*/ bool Equals(object other);
                /*0x1c366a4*/ string ToString();
            }

            class UpaException : System.Exception
            {
                /*0x90*/ object particle1;
                /*0x98*/ object particle2;

                /*0x1c367d0*/ UpaException(object particle1, object particle2);
                /*0x1c36840*/ object get_Particle1();
                /*0x1c36848*/ object get_Particle2();
            }

            class SymbolsDictionary
            {
                /*0x10*/ int last;
                /*0x18*/ System.Collections.Hashtable names;
                /*0x20*/ System.Collections.Hashtable wildcards;
                /*0x28*/ System.Collections.ArrayList particles;
                /*0x30*/ object particleLast;
                /*0x38*/ bool isUpaEnforced;

                /*0x1c36850*/ SymbolsDictionary();
                /*0x1c368f4*/ int get_Count();
                /*0x1c36900*/ bool get_IsUpaEnforced();
                /*0x1c36908*/ void set_IsUpaEnforced(bool value);
                /*0x1c36914*/ int AddName(System.Xml.XmlQualifiedName name, object particle);
                /*0x1c36a48*/ void AddNamespaceList(System.Xml.Schema.NamespaceList list, object particle, bool allowLocal);
                /*0x1c36de4*/ void AddWildcard(string wildcard, object particle);
                /*0x1c36f4c*/ System.Collections.ICollection GetNamespaceListSymbols(System.Xml.Schema.NamespaceList list);
                /*0x1c376dc*/ int get_Item(System.Xml.XmlQualifiedName name);
                /*0x1c37794*/ bool Exists(System.Xml.XmlQualifiedName name);
                /*0x1c377c4*/ object GetParticle(int symbol);
                /*0x1c37800*/ string NameOf(int symbol);
            }

            struct Position
            {
                /*0x10*/ int symbol;
                /*0x18*/ object particle;

                /*0x1c37f10*/ Position(int symbol, object particle);
            }

            class Positions
            {
                /*0x10*/ System.Collections.ArrayList positions;

                /*0x1c38060*/ Positions();
                /*0x1c37f1c*/ int Add(int symbol, object particle);
                /*0x1c37fac*/ System.Xml.Schema.Position get_Item(int pos);
                /*0x1c3803c*/ int get_Count();
            }

            class SyntaxTreeNode
            {
                /*0x1c380d0*/ SyntaxTreeNode();
                void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
                void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                bool get_IsNullable();
                /*0x1c380c8*/ bool get_IsRangeNode();
            }

            class LeafNode : System.Xml.Schema.SyntaxTreeNode
            {
                /*0x10*/ int pos;

                /*0x1c380d8*/ LeafNode(int pos);
                /*0x1c38100*/ int get_Pos();
                /*0x1c38108*/ void set_Pos(int value);
                /*0x1c38110*/ void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
                /*0x1c38114*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x1c38154*/ bool get_IsNullable();
            }

            class NamespaceListNode : System.Xml.Schema.SyntaxTreeNode
            {
                /*0x10*/ System.Xml.Schema.NamespaceList namespaceList;
                /*0x18*/ object particle;

                /*0x1c3815c*/ NamespaceListNode(System.Xml.Schema.NamespaceList namespaceList, object particle);
                /*0x1c38188*/ System.Collections.ICollection GetResolvedSymbols(System.Xml.Schema.SymbolsDictionary symbols);
                /*0x1c381a8*/ void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
                /*0x1c38628*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x1c38668*/ bool get_IsNullable();
            }

            class InteriorNode : System.Xml.Schema.SyntaxTreeNode
            {
                /*0x10*/ System.Xml.Schema.SyntaxTreeNode leftChild;
                /*0x18*/ System.Xml.Schema.SyntaxTreeNode rightChild;

                /*0x1c3890c*/ InteriorNode();
                /*0x1c386a8*/ System.Xml.Schema.SyntaxTreeNode get_LeftChild();
                /*0x1c386b0*/ void set_LeftChild(System.Xml.Schema.SyntaxTreeNode value);
                /*0x1c386b8*/ System.Xml.Schema.SyntaxTreeNode get_RightChild();
                /*0x1c386c0*/ void set_RightChild(System.Xml.Schema.SyntaxTreeNode value);
                /*0x1c386c8*/ void ExpandTreeNoRecursive(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
                /*0x1c388a8*/ void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
            }

            class SequenceNode : System.Xml.Schema.InteriorNode
            {
                /*0x1c38dcc*/ SequenceNode();
                /*0x1c38914*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x1c38c6c*/ bool get_IsNullable();
                /*0x1c38dc8*/ void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);

                struct SequenceConstructPosContext
                {
                    /*0x10*/ System.Xml.Schema.SequenceNode this_;
                    /*0x18*/ System.Xml.Schema.BitSet firstpos;
                    /*0x20*/ System.Xml.Schema.BitSet lastpos;
                    /*0x28*/ System.Xml.Schema.BitSet lastposLeft;
                    /*0x30*/ System.Xml.Schema.BitSet firstposRight;

                    /*0x1c38c5c*/ SequenceConstructPosContext(System.Xml.Schema.SequenceNode node, System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos);
                }
            }

            class ChoiceNode : System.Xml.Schema.InteriorNode
            {
                static /*0x1c38dd4*/ void ConstructChildPos(System.Xml.Schema.SyntaxTreeNode child, System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x1c38620*/ ChoiceNode();
                /*0x1c38eb0*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x1c38fc8*/ bool get_IsNullable();
                /*0x1c39058*/ void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
            }

            class PlusNode : System.Xml.Schema.InteriorNode
            {
                /*0x1c39118*/ PlusNode();
                /*0x1c3905c*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x1c390f8*/ bool get_IsNullable();
            }

            class QmarkNode : System.Xml.Schema.InteriorNode
            {
                /*0x1c39148*/ QmarkNode();
                /*0x1c39120*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x1c39140*/ bool get_IsNullable();
            }

            class StarNode : System.Xml.Schema.InteriorNode
            {
                /*0x1c391f4*/ StarNode();
                /*0x1c39150*/ void ConstructPos(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet lastpos, System.Xml.Schema.BitSet[] followpos);
                /*0x1c391ec*/ bool get_IsNullable();
            }

            class LeafRangeNode : System.Xml.Schema.LeafNode
            {
                /*0x18*/ decimal min;
                /*0x28*/ decimal max;
                /*0x38*/ System.Xml.Schema.BitSet nextIteration;

                /*0x1c391fc*/ LeafRangeNode(decimal min, decimal max);
                /*0x1c39244*/ LeafRangeNode(int pos, decimal min, decimal max);
                /*0x1c39294*/ decimal get_Max();
                /*0x1c392a0*/ decimal get_Min();
                /*0x1c392ac*/ System.Xml.Schema.BitSet get_NextIteration();
                /*0x1c392b4*/ void set_NextIteration(System.Xml.Schema.BitSet value);
                /*0x1c392bc*/ bool get_IsRangeNode();
                /*0x1c392c4*/ void ExpandTree(System.Xml.Schema.InteriorNode parent, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions);
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

                static /*0x1c396b0*/ ContentValidator();
                static /*0x1c39410*/ void AddParticleToExpected(System.Xml.Schema.XmlSchemaParticle p, System.Xml.Schema.XmlSchemaSet schemaSet, System.Collections.ArrayList particles);
                static /*0x1c39480*/ void AddParticleToExpected(System.Xml.Schema.XmlSchemaParticle p, System.Xml.Schema.XmlSchemaSet schemaSet, System.Collections.ArrayList particles, bool global);
                /*0x1c392f8*/ ContentValidator(System.Xml.Schema.XmlSchemaContentType contentType);
                /*0x1c39328*/ ContentValidator(System.Xml.Schema.XmlSchemaContentType contentType, bool isOpen, bool isEmptiable);
                /*0x1c39368*/ System.Xml.Schema.XmlSchemaContentType get_ContentType();
                /*0x1c39370*/ bool get_PreserveWhitespace();
                /*0x1c3938c*/ bool get_IsEmptiable();
                /*0x1c39394*/ bool get_IsOpen();
                /*0x1c393b8*/ void set_IsOpen(bool value);
                /*0x1c393c4*/ void InitValidation(System.Xml.Schema.ValidationState context);
                /*0x1c393c8*/ object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, ref int errorCode);
                /*0x1c393f8*/ bool CompleteValidation(System.Xml.Schema.ValidationState context);
                /*0x1c39400*/ System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, bool isRequiredOnly);
                /*0x1c39408*/ System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, bool isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet);
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

                /*0x1c397a8*/ ParticleContentValidator(System.Xml.Schema.XmlSchemaContentType contentType);
                /*0x1c397b0*/ ParticleContentValidator(System.Xml.Schema.XmlSchemaContentType contentType, bool enableUpaCheck);
                /*0x1c3982c*/ void InitValidation(System.Xml.Schema.ValidationState context);
                /*0x1c3986c*/ object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, ref int errorCode);
                /*0x1c398ac*/ bool CompleteValidation(System.Xml.Schema.ValidationState context);
                /*0x1c398ec*/ void Start();
                /*0x1c399a4*/ void OpenGroup();
                /*0x1c399cc*/ void CloseGroup();
                /*0x1c39b1c*/ bool Exists(System.Xml.XmlQualifiedName name);
                /*0x1c39b54*/ void AddName(System.Xml.XmlQualifiedName name, object particle);
                /*0x1c39cdc*/ void AddNamespaceList(System.Xml.Schema.NamespaceList namespaceList, object particle);
                /*0x1c39c00*/ void AddLeafNode(System.Xml.Schema.SyntaxTreeNode node);
                /*0x1c39d6c*/ void AddChoice();
                /*0x1c39e4c*/ void AddSequence();
                /*0x1c39f2c*/ void AddStar();
                /*0x1c3a0e0*/ void AddPlus();
                /*0x1c3a144*/ void AddQMark();
                /*0x1c3a1a8*/ void AddLeafRange(decimal min, decimal max);
                /*0x1c39f90*/ void Closure(System.Xml.Schema.InteriorNode node);
                /*0x1c3a294*/ System.Xml.Schema.ContentValidator Finish(bool useDFA);
                /*0x1c3a804*/ System.Xml.Schema.BitSet[] CalculateTotalFollowposForRangeNodes(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos, ref System.Xml.Schema.BitSet posWithRangeTerminals);
                /*0x1c3ac58*/ void CheckCMUPAWithLeafRangeNodes(System.Xml.Schema.BitSet curpos);
                /*0x1c3aae8*/ System.Xml.Schema.BitSet GetApplicableMinMaxFollowPos(System.Xml.Schema.BitSet curpos, System.Xml.Schema.BitSet posWithRangeTerminals, System.Xml.Schema.BitSet[] minmaxFollowPos);
                /*0x1c3add0*/ void CheckUniqueParticleAttribution(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos);
                /*0x1c3b490*/ void CheckUniqueParticleAttribution(System.Xml.Schema.BitSet curpos);
                /*0x1c3ae58*/ int[][] BuildTransitionTable(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos, int endMarkerPos);
            }

            class DfaContentValidator : System.Xml.Schema.ContentValidator
            {
                /*0x18*/ int[][] transitionTable;
                /*0x20*/ System.Xml.Schema.SymbolsDictionary symbols;

                /*0x1c3b3f0*/ DfaContentValidator(int[][] transitionTable, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.XmlSchemaContentType contentType, bool isOpen, bool isEmptiable);
                /*0x1c3b64c*/ void InitValidation(System.Xml.Schema.ValidationState context);
                /*0x1c3b6b0*/ object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, ref int errorCode);
                /*0x1c3b7c0*/ bool CompleteValidation(System.Xml.Schema.ValidationState context);
                /*0x1c3b7d8*/ System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, bool isRequiredOnly);
                /*0x1c3b9a8*/ System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, bool isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet);
            }

            class NfaContentValidator : System.Xml.Schema.ContentValidator
            {
                /*0x18*/ System.Xml.Schema.BitSet firstpos;
                /*0x20*/ System.Xml.Schema.BitSet[] followpos;
                /*0x28*/ System.Xml.Schema.SymbolsDictionary symbols;
                /*0x30*/ System.Xml.Schema.Positions positions;
                /*0x38*/ int endMarkerPos;

                /*0x1bdfd28*/ NfaContentValidator(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions, int endMarkerPos, System.Xml.Schema.XmlSchemaContentType contentType, bool isOpen, bool isEmptiable);
                /*0x1bdfddc*/ void InitValidation(System.Xml.Schema.ValidationState context);
                /*0x1bdfed8*/ object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, ref int errorCode);
                /*0x1be0088*/ bool CompleteValidation(System.Xml.Schema.ValidationState context);
                /*0x1be00d0*/ System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, bool isRequiredOnly);
                /*0x1be02b8*/ System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, bool isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet);
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

                /*0x1be0438*/ RangeContentValidator(System.Xml.Schema.BitSet firstpos, System.Xml.Schema.BitSet[] followpos, System.Xml.Schema.SymbolsDictionary symbols, System.Xml.Schema.Positions positions, int endMarkerPos, System.Xml.Schema.XmlSchemaContentType contentType, bool isEmptiable, System.Xml.Schema.BitSet positionsWithRangeTerminals, int minmaxNodesCount);
                /*0x1be04f4*/ void InitValidation(System.Xml.Schema.ValidationState context);
                /*0x1be0694*/ object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, ref int errorCode);
                /*0x1be0f24*/ bool CompleteValidation(System.Xml.Schema.ValidationState context);
                /*0x1be0f3c*/ System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, bool isRequiredOnly);
                /*0x1be11a4*/ System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, bool isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet);
            }

            class AllElementsContentValidator : System.Xml.Schema.ContentValidator
            {
                /*0x18*/ System.Collections.Hashtable elements;
                /*0x20*/ object[] particles;
                /*0x28*/ System.Xml.Schema.BitSet isRequired;
                /*0x30*/ int countRequired;

                /*0x1be13a8*/ AllElementsContentValidator(System.Xml.Schema.XmlSchemaContentType contentType, int size, bool isEmptiable);
                /*0x1be14bc*/ bool AddElement(System.Xml.XmlQualifiedName name, object particle, bool isEmptiable);
                /*0x1be1604*/ bool get_IsEmptiable();
                /*0x1be1624*/ void InitValidation(System.Xml.Schema.ValidationState context);
                /*0x1be16b8*/ object ValidateElement(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, ref int errorCode);
                /*0x1be1800*/ bool CompleteValidation(System.Xml.Schema.ValidationState context);
                /*0x1be1850*/ System.Collections.ArrayList ExpectedElements(System.Xml.Schema.ValidationState context, bool isRequiredOnly);
                /*0x1be1c74*/ System.Collections.ArrayList ExpectedParticles(System.Xml.Schema.ValidationState context, bool isRequiredOnly, System.Xml.Schema.XmlSchemaSet schemaSet);
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

                /*0x1be2140*/ XsdSimpleValue(System.Xml.Schema.XmlSchemaSimpleType st, object value);
                /*0x1be216c*/ System.Xml.Schema.XmlSchemaSimpleType get_XmlType();
                /*0x1be2174*/ object get_TypedValue();
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

                /*0x1be217c*/ RestrictionFacets();
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

                static /*0x1be2184*/ DatatypeImplementation();
                static /*0x1be71c4*/ System.Xml.Schema.XmlSchemaSimpleType get_AnySimpleType();
                static /*0x1be721c*/ System.Xml.Schema.XmlSchemaSimpleType get_UntypedAtomicType();
                static /*0x1be7274*/ System.Xml.Schema.DatatypeImplementation FromXmlTokenizedType(System.Xml.XmlTokenizedType token);
                static /*0x1be72f0*/ System.Xml.Schema.DatatypeImplementation FromXmlTokenizedTypeXsd(System.Xml.XmlTokenizedType token);
                static /*0x1be736c*/ System.Xml.Schema.DatatypeImplementation FromXdrName(string name);
                static /*0x1be742c*/ System.Xml.Schema.DatatypeImplementation FromTypeName(string name);
                static /*0x1be74ec*/ System.Xml.Schema.XmlSchemaSimpleType StartBuiltinType(System.Xml.XmlQualifiedName qname, System.Xml.Schema.XmlSchemaDatatype dataType);
                static /*0x1be75c0*/ void FinishBuiltinType(System.Xml.Schema.XmlSchemaSimpleType derivedType, System.Xml.Schema.XmlSchemaSimpleType baseType);
                static /*0x1be69d8*/ void CreateBuiltinTypes();
                static /*0x1be77a4*/ System.Xml.Schema.XmlSchemaSimpleType GetSimpleTypeFromTypeCode(System.Xml.Schema.XmlTypeCode typeCode);
                static /*0x1be7820*/ System.Xml.Schema.XmlSchemaSimpleType GetSimpleTypeFromXsdType(System.Xml.XmlQualifiedName qname);
                static /*0x1be78e0*/ System.Xml.Schema.XmlSchemaSimpleType GetNormalizedStringTypeV1Compat();
                static /*0x1be7a54*/ System.Xml.Schema.XmlSchemaSimpleType GetTokenTypeV1Compat();
                static /*0x1be7bc8*/ System.Xml.Schema.XmlSchemaSimpleType[] GetBuiltInTypes();
                static /*0x1be7c20*/ System.Xml.Schema.XmlTypeCode GetPrimitiveTypeCode(System.Xml.Schema.XmlTypeCode typeCode);
                static /*0x1be7f30*/ System.Xml.Schema.DatatypeImplementation DeriveByUnion(System.Xml.Schema.XmlSchemaSimpleType[] types, System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1be8db0*/ DatatypeImplementation();
                /*0x1be7d50*/ System.Xml.Schema.XmlSchemaDatatype DeriveByRestriction(System.Xml.Schema.XmlSchemaObjectCollection facets, System.Xml.XmlNameTable nameTable, System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1be7e34*/ System.Xml.Schema.XmlSchemaDatatype DeriveByList(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1be5e64*/ System.Xml.Schema.XmlSchemaDatatype DeriveByList(int minSize, System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1be8044*/ void VerifySchemaValid(System.Xml.Schema.XmlSchemaObjectTable notations, System.Xml.Schema.XmlSchemaObject caller);
                /*0x1be8048*/ bool IsDerivedFrom(System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1be82dc*/ bool IsEqual(object o1, object o2);
                /*0x1be8300*/ bool IsComparable(System.Xml.Schema.XmlSchemaDatatype dtype);
                /*0x1be83ec*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1be83f4*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1be844c*/ System.Xml.Schema.XmlValueConverter get_ValueConverter();
                /*0x1be8480*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x1be8488*/ System.Type get_ValueType();
                /*0x1be84f4*/ System.Xml.Schema.XmlSchemaDatatypeVariety get_Variety();
                /*0x1be84fc*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1be8504*/ System.Xml.Schema.RestrictionFacets get_Restriction();
                /*0x1be850c*/ bool get_HasLexicalFacets();
                /*0x1be8534*/ bool get_HasValueFacets();
                /*0x1be855c*/ System.Xml.Schema.DatatypeImplementation get_Base();
                System.Type get_ListValueType();
                System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1be8564*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1be856c*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
                /*0x1be87d4*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, bool createAtomicValue);
                /*0x1be8950*/ System.Exception TryParseValue(object value, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver namespaceResolver, ref object typedValue);
                /*0x1be8768*/ string GetTypeName();
                /*0x1be8d3c*/ int Compare(byte[] value1, byte[] value2);

                class SchemaDatatypeMap : System.IComparable
                {
                    /*0x10*/ string name;
                    /*0x18*/ System.Xml.Schema.DatatypeImplementation type;
                    /*0x20*/ int parentIndex;

                    static /*0x1be8db8*/ System.Xml.Schema.DatatypeImplementation op_Explicit(System.Xml.Schema.DatatypeImplementation.SchemaDatatypeMap sdm);
                    /*0x1be6970*/ SchemaDatatypeMap(string name, System.Xml.Schema.DatatypeImplementation type);
                    /*0x1be699c*/ SchemaDatatypeMap(string name, System.Xml.Schema.DatatypeImplementation type, int parentIndex);
                    /*0x1be8dd0*/ string get_Name();
                    /*0x1be8dd8*/ int get_ParentIndex();
                    /*0x1be8de0*/ int CompareTo(object obj);
                }
            }

            class Datatype_List : System.Xml.Schema.Datatype_anySimpleType
            {
                /*0x38*/ System.Xml.Schema.DatatypeImplementation itemType;
                /*0x40*/ int minListSize;

                /*0x1be7ec0*/ Datatype_List(System.Xml.Schema.DatatypeImplementation type, int minListSize);
                /*0x1be8e50*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1be90f4*/ int Compare(object value1, object value2);
                /*0x1be9394*/ System.Type get_ValueType();
                /*0x1be93a4*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x1be93c4*/ System.Type get_ListValueType();
                /*0x1be93e8*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1be9440*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1be9460*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1be9468*/ System.Exception TryParseValue(object value, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver namespaceResolver, ref object typedValue);
                /*0x1be9a60*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_union : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                /*0x38*/ System.Xml.Schema.XmlSchemaSimpleType[] types;

                static /*0x1bea758*/ Datatype_union();
                /*0x1be7fdc*/ Datatype_union(System.Xml.Schema.XmlSchemaSimpleType[] types);
                /*0x1be9e84*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1be9e90*/ int Compare(object value1, object value2);
                /*0x1be9f94*/ System.Type get_ValueType();
                /*0x1be9fec*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1be9ff4*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bea04c*/ System.Type get_ListValueType();
                /*0x1bea0a4*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1bea0ac*/ System.Xml.Schema.XmlSchemaSimpleType[] get_BaseMemberTypes();
                /*0x1be7e40*/ bool HasAtomicMembers();
                /*0x1be8258*/ bool IsUnionBaseOf(System.Xml.Schema.DatatypeImplementation derivedType);
                /*0x1bea0b4*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
                /*0x1bea2b0*/ System.Exception TryParseValue(object value, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_anySimpleType : System.Xml.Schema.DatatypeImplementation
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x1beaa10*/ Datatype_anySimpleType();
                /*0x1be595c*/ Datatype_anySimpleType();
                /*0x1bea814*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1bea86c*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bea8c4*/ System.Type get_ValueType();
                /*0x1bea91c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bea924*/ System.Type get_ListValueType();
                /*0x1bea97c*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x1bea984*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1bea98c*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1bea994*/ int Compare(object value1, object value2);
                /*0x1bea9ec*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_anyAtomicType : System.Xml.Schema.Datatype_anySimpleType
            {
                /*0x1be6870*/ Datatype_anyAtomicType();
                /*0x1beaacc*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1beab24*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1beab2c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_untypedAtomicType : System.Xml.Schema.Datatype_anyAtomicType
            {
                /*0x1be6918*/ Datatype_untypedAtomicType();
                /*0x1beab34*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1beab8c*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1beab94*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_string : System.Xml.Schema.Datatype_anySimpleType
            {
                /*0x1be64b4*/ Datatype_string();
                /*0x1beab9c*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1beaba8*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1beabb0*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1beac08*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1beac10*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x1beac18*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1beac20*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_boolean : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x1beafbc*/ Datatype_boolean();
                /*0x1be5a5c*/ Datatype_boolean();
                /*0x1beacf4*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1bead00*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bead58*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bead60*/ System.Type get_ValueType();
                /*0x1beadb8*/ System.Type get_ListValueType();
                /*0x1beae10*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1beae18*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1beae20*/ int Compare(object value1, object value2);
                /*0x1beaeb4*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_float : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x1beb378*/ Datatype_float();
                /*0x1be6040*/ Datatype_float();
                /*0x1beb078*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1beb084*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1beb0dc*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1beb0e4*/ System.Type get_ValueType();
                /*0x1beb13c*/ System.Type get_ListValueType();
                /*0x1beb194*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1beb19c*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1beb1a4*/ int Compare(object value1, object value2);
                /*0x1beb238*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_double : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x1beb734*/ Datatype_double();
                /*0x1be5d64*/ Datatype_double();
                /*0x1beb434*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1beb440*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1beb498*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1beb4a0*/ System.Type get_ValueType();
                /*0x1beb4f8*/ System.Type get_ListValueType();
                /*0x1beb550*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1beb558*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1beb560*/ int Compare(object value1, object value2);
                /*0x1beb5f4*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_decimal : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x1bebb3c*/ Datatype_decimal();
                /*0x1be5d10*/ Datatype_decimal();
                /*0x1beb7f0*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1beb7fc*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1beb854*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1beb85c*/ System.Type get_ValueType();
                /*0x1beb8b4*/ System.Type get_ListValueType();
                /*0x1beb90c*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1beb914*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1beb91c*/ int Compare(object value1, object value2);
                /*0x1beb9d8*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_duration : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x1bec08c*/ Datatype_duration();
                /*0x1be5e0c*/ Datatype_duration();
                /*0x1bebd04*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1bebd10*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bebd68*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bebd70*/ System.Type get_ValueType();
                /*0x1bebdc8*/ System.Type get_ListValueType();
                /*0x1bebe20*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1bebe28*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1bebe30*/ int Compare(object value1, object value2);
                /*0x1bebec4*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_yearMonthDuration : System.Xml.Schema.Datatype_duration
            {
                /*0x1be691c*/ Datatype_yearMonthDuration();
                /*0x1bec148*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
                /*0x1bec310*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_dayTimeDuration : System.Xml.Schema.Datatype_duration
            {
                /*0x1be68c4*/ Datatype_dayTimeDuration();
                /*0x1bec318*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
                /*0x1bec4e0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_dateTimeBase : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                /*0x38*/ System.Xml.Schema.XsdDateTimeFlags dateTimeFlags;

                static /*0x1becaa8*/ Datatype_dateTimeBase();
                /*0x1bec554*/ Datatype_dateTimeBase(System.Xml.Schema.XsdDateTimeFlags dateTimeFlags);
                /*0x1bec4e8*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1bec4f4*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bec54c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bec5bc*/ System.Type get_ValueType();
                /*0x1bec614*/ System.Type get_ListValueType();
                /*0x1bec66c*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1bec674*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1bec67c*/ int Compare(object value1, object value2);
                /*0x1bec784*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_dateTimeNoTimeZone : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x1be5c08*/ Datatype_dateTimeNoTimeZone();
            }

            class Datatype_dateTimeTimeZone : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x1be5c60*/ Datatype_dateTimeTimeZone();
            }

            class Datatype_dateTime : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x1be5bb0*/ Datatype_dateTime();
            }

            class Datatype_timeNoTimeZone : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x1be6560*/ Datatype_timeNoTimeZone();
            }

            class Datatype_timeTimeZone : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x1be65b8*/ Datatype_timeTimeZone();
            }

            class Datatype_time : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x1be6508*/ Datatype_time();
                /*0x1becb64*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_date : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x1be5b58*/ Datatype_date();
                /*0x1becb6c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_yearMonth : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x1be6810*/ Datatype_yearMonth();
                /*0x1becb74*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_year : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x1be67b8*/ Datatype_year();
                /*0x1becb7c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_monthDay : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x1be624c*/ Datatype_monthDay();
                /*0x1becb84*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_day : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x1be5cb8*/ Datatype_day();
                /*0x1becb8c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_month : System.Xml.Schema.Datatype_dateTimeBase
            {
                /*0x1be61f4*/ Datatype_month();
                /*0x1becb94*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_hexBinary : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x1becf14*/ Datatype_hexBinary();
                /*0x1be60e8*/ Datatype_hexBinary();
                /*0x1becb9c*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1becba8*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1becc00*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1becc08*/ System.Type get_ValueType();
                /*0x1becc60*/ System.Type get_ListValueType();
                /*0x1beccb8*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1beccc0*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1beccc8*/ int Compare(object value1, object value2);
                /*0x1becd70*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_base64Binary : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x1bed344*/ Datatype_base64Binary();
                /*0x1be5a08*/ Datatype_base64Binary();
                /*0x1becfd0*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1becfdc*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bed034*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bed03c*/ System.Type get_ValueType();
                /*0x1bed094*/ System.Type get_ListValueType();
                /*0x1bed0ec*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1bed0f4*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1bed0fc*/ int Compare(object value1, object value2);
                /*0x1bed1a4*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_anyURI : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x1bed994*/ Datatype_anyURI();
                /*0x1be59b4*/ Datatype_anyURI();
                /*0x1bed400*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1bed40c*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bed464*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bed46c*/ System.Type get_ValueType();
                /*0x1bed4c4*/ bool get_HasValueFacets();
                /*0x1bed4cc*/ System.Type get_ListValueType();
                /*0x1bed524*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1bed52c*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1bed534*/ int Compare(object value1, object value2);
                /*0x1bed620*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_QName : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x1beddc0*/ Datatype_QName();
                /*0x1be63b8*/ Datatype_QName();
                /*0x1beda50*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1beda5c*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bedab4*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bedabc*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x1bedac4*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1bedacc*/ System.Type get_ValueType();
                /*0x1bedb24*/ System.Type get_ListValueType();
                /*0x1bedb7c*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1bedb84*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_normalizedString : System.Xml.Schema.Datatype_string
            {
                /*0x1be630c*/ Datatype_normalizedString();
                /*0x1bede7c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bede84*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1bede8c*/ bool get_HasValueFacets();
            }

            class Datatype_normalizedStringV1Compat : System.Xml.Schema.Datatype_string
            {
                /*0x1be6868*/ Datatype_normalizedStringV1Compat();
                /*0x1bede94*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bede9c*/ bool get_HasValueFacets();
            }

            class Datatype_token : System.Xml.Schema.Datatype_normalizedString
            {
                /*0x1be6610*/ Datatype_token();
                /*0x1bedea4*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bedeac*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
            }

            class Datatype_tokenV1Compat : System.Xml.Schema.Datatype_normalizedStringV1Compat
            {
                /*0x1be686c*/ Datatype_tokenV1Compat();
                /*0x1bedeb4*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_language : System.Xml.Schema.Datatype_token
            {
                /*0x1be61ec*/ Datatype_language();
                /*0x1bedebc*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_NMTOKEN : System.Xml.Schema.Datatype_token
            {
                /*0x1be6300*/ Datatype_NMTOKEN();
                /*0x1bedec4*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bedecc*/ System.Xml.XmlTokenizedType get_TokenizedType();
            }

            class Datatype_Name : System.Xml.Schema.Datatype_token
            {
                /*0x1be62a4*/ Datatype_Name();
                /*0x1beded4*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_NCName : System.Xml.Schema.Datatype_Name
            {
                /*0x1be62a8*/ Datatype_NCName();
                /*0x1bededc*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bedee4*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_ID : System.Xml.Schema.Datatype_NCName
            {
                /*0x1be613c*/ Datatype_ID();
                /*0x1bedfe0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bedfe8*/ System.Xml.XmlTokenizedType get_TokenizedType();
            }

            class Datatype_IDREF : System.Xml.Schema.Datatype_NCName
            {
                /*0x1be6140*/ Datatype_IDREF();
                /*0x1bedff0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bedff8*/ System.Xml.XmlTokenizedType get_TokenizedType();
            }

            class Datatype_ENTITY : System.Xml.Schema.Datatype_NCName
            {
                /*0x1be5e60*/ Datatype_ENTITY();
                /*0x1bee000*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bee008*/ System.Xml.XmlTokenizedType get_TokenizedType();
            }

            class Datatype_NOTATION : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x1bee590*/ Datatype_NOTATION();
                /*0x1be6310*/ Datatype_NOTATION();
                /*0x1bee010*/ System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0x1bee01c*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bee074*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bee07c*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x1bee084*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1bee08c*/ System.Type get_ValueType();
                /*0x1bee0e4*/ System.Type get_ListValueType();
                /*0x1bee13c*/ System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                /*0x1bee144*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
                /*0x1bee380*/ void VerifySchemaValid(System.Xml.Schema.XmlSchemaObjectTable notations, System.Xml.Schema.XmlSchemaObject caller);
            }

            class Datatype_integer : System.Xml.Schema.Datatype_decimal
            {
                /*0x1be6198*/ Datatype_integer();
                /*0x1bee64c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bee654*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_nonPositiveInteger : System.Xml.Schema.Datatype_integer
            {
                static /*0x0*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x1bee7fc*/ Datatype_nonPositiveInteger();
                /*0x1be6308*/ Datatype_nonPositiveInteger();
                /*0x1bee794*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bee7ec*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bee7f4*/ bool get_HasValueFacets();
            }

            class Datatype_negativeInteger : System.Xml.Schema.Datatype_nonPositiveInteger
            {
                static /*0x0*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x1bee96c*/ Datatype_negativeInteger();
                /*0x1be62ac*/ Datatype_negativeInteger();
                /*0x1bee90c*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bee964*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_long : System.Xml.Schema.Datatype_integer
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x1beed68*/ Datatype_long();
                /*0x1be61f0*/ Datatype_long();
                /*0x1beea7c*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1beead4*/ bool get_HasValueFacets();
                /*0x1beeadc*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1beeae4*/ int Compare(object value1, object value2);
                /*0x1beeb78*/ System.Type get_ValueType();
                /*0x1beebd0*/ System.Type get_ListValueType();
                /*0x1beec28*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_int : System.Xml.Schema.Datatype_long
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x1bef1b4*/ Datatype_int();
                /*0x1be6144*/ Datatype_int();
                /*0x1beeed0*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1beef28*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1beef30*/ int Compare(object value1, object value2);
                /*0x1beefc4*/ System.Type get_ValueType();
                /*0x1bef01c*/ System.Type get_ListValueType();
                /*0x1bef074*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_short : System.Xml.Schema.Datatype_int
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x1bef600*/ Datatype_short();
                /*0x1be6460*/ Datatype_short();
                /*0x1bef31c*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bef374*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bef37c*/ int Compare(object value1, object value2);
                /*0x1bef410*/ System.Type get_ValueType();
                /*0x1bef468*/ System.Type get_ListValueType();
                /*0x1bef4c0*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_byte : System.Xml.Schema.Datatype_short
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x1befa4c*/ Datatype_byte();
                /*0x1be5ab0*/ Datatype_byte();
                /*0x1bef768*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bef7c0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bef7c8*/ int Compare(object value1, object value2);
                /*0x1bef85c*/ System.Type get_ValueType();
                /*0x1bef8b4*/ System.Type get_ListValueType();
                /*0x1bef90c*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_nonNegativeInteger : System.Xml.Schema.Datatype_integer
            {
                static /*0x0*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x1befc1c*/ Datatype_nonNegativeInteger();
                /*0x1be6304*/ Datatype_nonNegativeInteger();
                /*0x1befbb4*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1befc0c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1befc14*/ bool get_HasValueFacets();
            }

            class Datatype_unsignedLong : System.Xml.Schema.Datatype_nonNegativeInteger
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x1bf0054*/ Datatype_unsignedLong();
                /*0x1be66bc*/ Datatype_unsignedLong();
                /*0x1befd2c*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1befd84*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1befd8c*/ int Compare(object value1, object value2);
                /*0x1befe20*/ System.Type get_ValueType();
                /*0x1befe78*/ System.Type get_ListValueType();
                /*0x1befed0*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_unsignedInt : System.Xml.Schema.Datatype_unsignedLong
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x1bf04b8*/ Datatype_unsignedInt();
                /*0x1be6668*/ Datatype_unsignedInt();
                /*0x1bf01d4*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bf022c*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bf0234*/ int Compare(object value1, object value2);
                /*0x1bf02c8*/ System.Type get_ValueType();
                /*0x1bf0320*/ System.Type get_ListValueType();
                /*0x1bf0378*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_unsignedShort : System.Xml.Schema.Datatype_unsignedInt
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x1bf091c*/ Datatype_unsignedShort();
                /*0x1be6710*/ Datatype_unsignedShort();
                /*0x1bf0638*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bf0690*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bf0698*/ int Compare(object value1, object value2);
                /*0x1bf072c*/ System.Type get_ValueType();
                /*0x1bf0784*/ System.Type get_ListValueType();
                /*0x1bf07dc*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_unsignedByte : System.Xml.Schema.Datatype_unsignedShort
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;
                static /*0x10*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x1bf0d80*/ Datatype_unsignedByte();
                /*0x1be6614*/ Datatype_unsignedByte();
                /*0x1bf0a9c*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bf0af4*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x1bf0afc*/ int Compare(object value1, object value2);
                /*0x1bf0b90*/ System.Type get_ValueType();
                /*0x1bf0be8*/ System.Type get_ListValueType();
                /*0x1bf0c40*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_positiveInteger : System.Xml.Schema.Datatype_nonNegativeInteger
            {
                static /*0x0*/ System.Xml.Schema.FacetsChecker numeric10FacetsChecker;

                static /*0x1bf0f60*/ Datatype_positiveInteger();
                /*0x1be6364*/ Datatype_positiveInteger();
                /*0x1bf0f00*/ System.Xml.Schema.FacetsChecker get_FacetsChecker();
                /*0x1bf0f58*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
            }

            class Datatype_doubleXdr : System.Xml.Schema.Datatype_double
            {
                /*0x1be5db8*/ Datatype_doubleXdr();
                /*0x1bf1070*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
            }

            class Datatype_floatXdr : System.Xml.Schema.Datatype_float
            {
                /*0x1be6094*/ Datatype_floatXdr();
                /*0x1bf12f4*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
            }

            class Datatype_QNameXdr : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x1bf18ac*/ Datatype_QNameXdr();
                /*0x1be640c*/ Datatype_QNameXdr();
                /*0x1bf1578*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x1bf1580*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
                /*0x1bf17fc*/ System.Type get_ValueType();
                /*0x1bf1854*/ System.Type get_ListValueType();
            }

            class Datatype_ENUMERATION : System.Xml.Schema.Datatype_NMTOKEN
            {
                /*0x1be5fe8*/ Datatype_ENUMERATION();
                /*0x1bf1968*/ System.Xml.XmlTokenizedType get_TokenizedType();
            }

            class Datatype_char : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x1bf1d40*/ Datatype_char();
                /*0x1be5b04*/ Datatype_char();
                /*0x1bf1970*/ System.Type get_ValueType();
                /*0x1bf19c8*/ System.Type get_ListValueType();
                /*0x1bf1a20*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1bf1a28*/ int Compare(object value1, object value2);
                /*0x1bf1abc*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
                /*0x1bf1c94*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_fixed : System.Xml.Schema.Datatype_decimal
            {
                /*0x1be5fec*/ Datatype_fixed();
                /*0x1bf1dfc*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
                /*0x1bf2354*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
            }

            class Datatype_uuid : System.Xml.Schema.Datatype_anySimpleType
            {
                static /*0x0*/ System.Type atomicValueType;
                static /*0x8*/ System.Type listValueType;

                static /*0x1bf288c*/ Datatype_uuid();
                /*0x1be6764*/ Datatype_uuid();
                /*0x1bf24ac*/ System.Type get_ValueType();
                /*0x1bf2504*/ System.Type get_ListValueType();
                /*0x1bf255c*/ System.Xml.Schema.RestrictionFlags get_ValidRestrictionFlags();
                /*0x1bf2564*/ int Compare(object value1, object value2);
                /*0x1bf2600*/ object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
                /*0x1bf27d8*/ System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
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

                static /*0x1bf4eb0*/ DtdValidator();
                static /*0x1bf46e4*/ void SetDefaultTypedValue(System.Xml.Schema.SchemaAttDef attdef, System.Xml.IDtdParserAdapter readerAdapter);
                static /*0x1bf4a9c*/ void CheckDefaultValue(System.Xml.Schema.SchemaAttDef attdef, System.Xml.Schema.SchemaInfo sinfo, System.Xml.IValidationEventHandling eventHandling, string baseUriStr);
                /*0x1bf2948*/ DtdValidator(System.Xml.XmlValidatingReaderImpl reader, System.Xml.IValidationEventHandling eventHandling, bool processIdentityConstraints);
                /*0x1bf29e4*/ void Init();
                /*0x1bf2bf8*/ void Validate();
                /*0x1bf2efc*/ bool MeetsStandAloneConstraint();
                /*0x1bf2f9c*/ void ValidatePIComment();
                /*0x1bf2df4*/ void ValidateElement();
                /*0x1bf334c*/ void ValidateChildElement();
                /*0x1bf35ac*/ void ValidateStartElement();
                /*0x1bf3f88*/ void ValidateEndStartElement();
                /*0x1bf3494*/ void ProcessElement();
                /*0x1bf415c*/ void CompleteValidation();
                /*0x1bf31a8*/ void ValidateEndElement();
                /*0x1bf4354*/ bool get_PreserveWhitespace();
                /*0x1bf438c*/ void ProcessTokenizedType(System.Xml.XmlTokenizedType ttype, string name);
                /*0x1bf3a18*/ void CheckValue(string value, System.Xml.Schema.SchemaAttDef attdef);
                /*0x1bf45a4*/ void AddID(string name, object node);
                /*0x1bf4634*/ object FindId(string name);
                /*0x1bf304c*/ bool GenEntity(System.Xml.XmlQualifiedName qname);
                /*0x1bf4650*/ System.Xml.Schema.SchemaEntity GetEntity(System.Xml.XmlQualifiedName qname, bool fParameterEntity);
                /*0x1bf424c*/ void CheckForwardRefs();
                /*0x1bf2b20*/ void Push(System.Xml.XmlQualifiedName elementName);
                /*0x1bf41a4*/ bool Pop();

                class NamespaceManager : System.Xml.XmlNamespaceManager
                {
                    /*0x1bf4f28*/ NamespaceManager();
                    /*0x1bf4f30*/ string LookupNamespace(string prefix);
                }
            }

            class FacetsChecker
            {
                static /*0x1bf7930*/ decimal Power(int x, int y);
                /*0x1bf7a5c*/ FacetsChecker();
                /*0x1bf4f38*/ System.Exception CheckLexicalFacets(ref string parseString, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bf51d0*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bf51d8*/ System.Exception CheckValueFacets(decimal value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bf51e0*/ System.Exception CheckValueFacets(long value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bf51e8*/ System.Exception CheckValueFacets(int value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bf51f0*/ System.Exception CheckValueFacets(short value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bf51f8*/ System.Exception CheckValueFacets(System.DateTime value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bf5200*/ System.Exception CheckValueFacets(double value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bf5208*/ System.Exception CheckValueFacets(float value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bf5210*/ System.Exception CheckValueFacets(string value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bf5218*/ System.Exception CheckValueFacets(byte[] value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bf5220*/ System.Exception CheckValueFacets(System.TimeSpan value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bf5228*/ System.Exception CheckValueFacets(System.Xml.XmlQualifiedName value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bf4f7c*/ void CheckWhitespaceFacets(ref string s, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bf5064*/ System.Exception CheckPatternFacets(System.Xml.Schema.RestrictionFacets restriction, string value);
                /*0x1bf5230*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bf5238*/ System.Xml.Schema.RestrictionFacets ConstructRestriction(System.Xml.Schema.DatatypeImplementation datatype, System.Xml.Schema.XmlSchemaObjectCollection facets, System.Xml.XmlNameTable nameTable);

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

                    static /*0x1bf8718*/ FacetsCompiler();
                    static /*0x1bf81e4*/ string Preprocess(string pattern);
                    /*0x1bf5570*/ FacetsCompiler(System.Xml.Schema.DatatypeImplementation baseDatatype, System.Xml.Schema.RestrictionFacets restriction);
                    /*0x1bf5774*/ void CompileLengthFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x1bf5aac*/ void CompileMinLengthFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x1bf5da8*/ void CompileMaxLengthFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x1bf60a4*/ void CompilePatternFacet(System.Xml.Schema.XmlSchemaPatternFacet facet);
                    /*0x1bf61d4*/ void CompileEnumerationFacet(System.Xml.Schema.XmlSchemaFacet facet, System.Xml.IXmlNamespaceResolver nsmgr, System.Xml.XmlNameTable nameTable);
                    /*0x1bf62e8*/ void CompileWhitespaceFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x1bf694c*/ void CompileMaxInclusiveFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x1bf6adc*/ void CompileMaxExclusiveFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x1bf662c*/ void CompileMinInclusiveFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x1bf67bc*/ void CompileMinExclusiveFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x1bf6c6c*/ void CompileTotalDigitsFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x1bf6f5c*/ void CompileFractionDigitsFacet(System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x1bf71e4*/ void FinishFacetCompile();
                    /*0x1bf7d28*/ void CheckValue(object value, System.Xml.Schema.XmlSchemaFacet facet);
                    /*0x1bf756c*/ void CompileFacetCombinations();
                    /*0x1bf8440*/ void CopyFacetsFromBaseType();
                    /*0x1bf7b70*/ object ParseFacetValue(System.Xml.Schema.XmlSchemaDatatype datatype, System.Xml.Schema.XmlSchemaFacet facet, string code, System.Xml.IXmlNamespaceResolver nsmgr, System.Xml.XmlNameTable nameTable);
                    /*0x1bf7a64*/ void CheckProhibitedFlag(System.Xml.Schema.XmlSchemaFacet facet, System.Xml.Schema.RestrictionFlags flag, string errorCode);
                    /*0x1bf7af8*/ void CheckDupFlag(System.Xml.Schema.XmlSchemaFacet facet, System.Xml.Schema.RestrictionFlags flag, string errorCode);
                    /*0x1bf7cc4*/ void SetFlag(System.Xml.Schema.XmlSchemaFacet facet, System.Xml.Schema.RestrictionFlags flag);
                    /*0x1bf86dc*/ void SetFlag(System.Xml.Schema.RestrictionFlags flag);

                    struct Map
                    {
                        /*0x10*/ char match;
                        /*0x18*/ string replacement;

                        /*0x1bf88cc*/ Map(char m, string r);
                    }
                }
            }

            class Numeric10FacetsChecker : System.Xml.Schema.FacetsChecker
            {
                static /*0x0*/ char[] signs;
                /*0x10*/ decimal maxValue;
                /*0x20*/ decimal minValue;

                static /*0x1bf91f4*/ Numeric10FacetsChecker();
                /*0x1bebcc4*/ Numeric10FacetsChecker(decimal minVal, decimal maxVal);
                /*0x1bf88d8*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bf8948*/ System.Exception CheckValueFacets(decimal value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bf8fcc*/ System.Exception CheckValueFacets(long value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bf9058*/ System.Exception CheckValueFacets(int value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bf90e4*/ System.Exception CheckValueFacets(short value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bf9170*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bf8eac*/ bool MatchEnumeration(decimal value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlValueConverter valueConverter);
                /*0x1bf20ac*/ System.Exception CheckTotalAndFractionDigits(decimal value, int totalDigits, int fractionDigits, bool checkTotal, bool checkFraction);
            }

            class Numeric2FacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x1be5944*/ Numeric2FacetsChecker();
                /*0x1bf9288*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bf92e8*/ System.Exception CheckValueFacets(double value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bf9628*/ System.Exception CheckValueFacets(float value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bf9638*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bf9570*/ bool MatchEnumeration(double value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlValueConverter valueConverter);
            }

            class DurationFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x1be5954*/ DurationFacetsChecker();
                /*0x1bf96b0*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bf97c4*/ System.Exception CheckValueFacets(System.TimeSpan value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bf9bf8*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bf9aec*/ bool MatchEnumeration(System.TimeSpan value, System.Collections.ArrayList enumeration);
            }

            class DateTimeFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x1be594c*/ DateTimeFacetsChecker();
                /*0x1bf9c70*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bf9cd4*/ System.Exception CheckValueFacets(System.DateTime value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bfa1cc*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bfa090*/ bool MatchEnumeration(System.DateTime value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
            }

            class StringFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                static /*0x0*/ System.Text.RegularExpressions.Regex languagePattern;

                static /*0x1bfa228*/ System.Text.RegularExpressions.Regex get_LanguagePattern();
                /*0x1be593c*/ StringFacetsChecker();
                /*0x1bfa2e0*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bfa340*/ System.Exception CheckValueFacets(string value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bed78c*/ System.Exception CheckValueFacets(string value, System.Xml.Schema.XmlSchemaDatatype datatype, bool verifyUri);
                /*0x1bfa738*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bfa564*/ bool MatchEnumeration(string value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x1bfa348*/ System.Exception CheckBuiltInFacets(string s, System.Xml.Schema.XmlTypeCode typeCode, bool verifyUri);
            }

            class QNameFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x12a50e4*/ QNameFacetsChecker();
                /*0x12a4bc8*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x12a4cf4*/ System.Exception CheckValueFacets(System.Xml.XmlQualifiedName value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x12a4fd0*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x12a4ec0*/ bool MatchEnumeration(System.Xml.XmlQualifiedName value, System.Collections.ArrayList enumeration);
            }

            class MiscFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x12a50ec*/ MiscFacetsChecker();
            }

            class BinaryFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x12a54d8*/ BinaryFacetsChecker();
                /*0x12a50f4*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x12a5184*/ System.Exception CheckValueFacets(byte[] value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x12a5454*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x12a533c*/ bool MatchEnumeration(byte[] value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
            }

            class ListFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x12a57d4*/ ListFacetsChecker();
                /*0x12a54e0*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x12a571c*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
            }

            class UnionFacetsChecker : System.Xml.Schema.FacetsChecker
            {
                /*0x12a5990*/ UnionFacetsChecker();
                /*0x12a57dc*/ System.Exception CheckValueFacets(object value, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0x12a58d8*/ bool MatchEnumeration(object value, System.Collections.ArrayList enumeration, System.Xml.Schema.XmlSchemaDatatype datatype);
            }

            interface IXmlSchemaInfo
            {
                System.Xml.Schema.XmlSchemaValidity get_Validity();
                bool get_IsDefault();
                bool get_IsNil();
                System.Xml.Schema.XmlSchemaSimpleType get_MemberType();
                System.Xml.Schema.XmlSchemaType get_SchemaType();
                System.Xml.Schema.XmlSchemaElement get_SchemaElement();
                System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute();
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

                static /*0x12ae9c8*/ XmlSchemaInference();
                static /*0x12ad30c*/ int InferSimpleType(string s, ref bool bNeedsRangeCheck);
                static /*0x12ae8b4*/ int DateTime(string s, bool bDate, bool bTime);
                static /*0x12aa0cc*/ int GetSchemaType(System.Xml.XmlQualifiedName qname);
                /*0x12a59b0*/ XmlSchemaInference();
                /*0x12a5998*/ void set_Occurrence(System.Xml.Schema.XmlSchemaInference.InferenceOption value);
                /*0x12a59a0*/ System.Xml.Schema.XmlSchemaInference.InferenceOption get_Occurrence();
                /*0x12a59a8*/ void set_TypeInference(System.Xml.Schema.XmlSchemaInference.InferenceOption value);
                /*0x12a5ad0*/ System.Xml.Schema.XmlSchemaSet InferSchema(System.Xml.XmlReader instanceDocument);
                /*0x12a5b4c*/ System.Xml.Schema.XmlSchemaSet InferSchema1(System.Xml.XmlReader instanceDocument, System.Xml.Schema.XmlSchemaSet schemas);
                /*0x12a7fdc*/ System.Xml.Schema.XmlSchemaAttribute AddAttribute(string localName, string prefix, string childURI, string attrValue, bool bCreatingNewType, System.Xml.Schema.XmlSchema parentSchema, System.Xml.Schema.XmlSchemaObjectCollection addLocation, System.Xml.Schema.XmlSchemaObjectTable compiledAttributes);
                /*0x12aa8a4*/ System.Xml.Schema.XmlSchema CreateXmlSchema(string targetNS);
                /*0x12a6564*/ System.Xml.Schema.XmlSchemaElement AddElement(string localName, string prefix, string childURI, System.Xml.Schema.XmlSchema parentSchema, System.Xml.Schema.XmlSchemaObjectCollection addLocation, int positionWithinCollection);
                /*0x12a6b30*/ void InferElement(System.Xml.Schema.XmlSchemaElement xse, bool bCreatingNewType, System.Xml.Schema.XmlSchema parentSchema);
                /*0x12ab598*/ System.Xml.Schema.XmlSchemaSimpleContentExtension CheckSimpleContentExtension(System.Xml.Schema.XmlSchemaComplexType ct);
                /*0x12aacd0*/ System.Xml.Schema.XmlSchemaType GetEffectiveSchemaType(System.Xml.Schema.XmlSchemaElement elem, bool bCreatingNewType);
                /*0x12abb68*/ System.Xml.Schema.XmlSchemaElement FindMatchingElement(bool bCreatingNewType, System.Xml.XmlReader xtr, System.Xml.Schema.XmlSchemaComplexType ct, ref int lastUsedSeqItem, ref bool bParticleChanged, System.Xml.Schema.XmlSchema parentSchema, bool setMaxoccurs);
                /*0x12aae08*/ void ProcessAttributes(ref System.Xml.Schema.XmlSchemaElement xse, System.Xml.Schema.XmlSchemaType effectiveSchemaType, bool bCreatingNewType, System.Xml.Schema.XmlSchema parentSchema);
                /*0x12abacc*/ void MoveAttributes(System.Xml.Schema.XmlSchemaSimpleContentExtension scExtension, System.Xml.Schema.XmlSchemaComplexType ct);
                /*0x12ab6d8*/ void MoveAttributes(System.Xml.Schema.XmlSchemaComplexType ct, System.Xml.Schema.XmlSchemaSimpleContentExtension simpleContentExtension, bool bCreatingNewType);
                /*0x12a8ba4*/ System.Xml.Schema.XmlSchemaAttribute FindAttribute(System.Collections.ICollection attributes, string attrName);
                /*0x12aa934*/ System.Xml.Schema.XmlSchemaElement FindGlobalElement(string namespaceURI, string localName, ref System.Xml.Schema.XmlSchema parentSchema);
                /*0x12acccc*/ System.Xml.Schema.XmlSchemaElement FindElement(System.Xml.Schema.XmlSchemaObjectCollection elements, string elementName);
                /*0x12a87c8*/ System.Xml.Schema.XmlSchemaAttribute FindAttributeRef(System.Collections.ICollection attributes, string attributeName, string nsURI);
                /*0x12acdfc*/ System.Xml.Schema.XmlSchemaElement FindElementRef(System.Xml.Schema.XmlSchemaObjectCollection elements, string elementName, string nsURI);
                /*0x12ab504*/ void MakeExistingAttributesOptional(System.Xml.Schema.XmlSchemaComplexType ct, System.Xml.Schema.XmlSchemaObjectCollection attributesInInstance);
                /*0x12ad1e8*/ void SwitchUseToOptional(System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaObjectCollection attributesInInstance);
                /*0x12a8f3c*/ System.Xml.XmlQualifiedName RefineSimpleType(string s, ref int iTypeFlags);
                /*0x12acf5c*/ System.Xml.Schema.XmlSchemaElement CreateNewElementforChoice(System.Xml.Schema.XmlSchemaElement copyElement);
                /*0x12acb50*/ void SetMinMaxOccurs(System.Xml.Schema.XmlSchemaElement el, bool setMaxOccurs);

                enum InferenceOption
                {
                    Restricted = 0,
                    Relaxed = 1,
                }
            }

            class XmlSchemaInferenceException : System.Xml.Schema.XmlSchemaException
            {
                /*0x12af354*/ XmlSchemaInferenceException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x12af364*/ XmlSchemaInferenceException();
                /*0x12ad11c*/ XmlSchemaInferenceException(string res, string arg);
                /*0x12a6530*/ XmlSchemaInferenceException(string res, int lineNumber, int linePosition);
                /*0x12af35c*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            class NamespaceList
            {
                /*0x10*/ System.Xml.Schema.NamespaceList.ListType type;
                /*0x18*/ System.Collections.Hashtable set;
                /*0x20*/ string targetNamespace;

                static /*0x12afd28*/ bool IsSubset(System.Xml.Schema.NamespaceList sub, System.Xml.Schema.NamespaceList super);
                static /*0x12b0114*/ System.Xml.Schema.NamespaceList Union(System.Xml.Schema.NamespaceList o1, System.Xml.Schema.NamespaceList o2, bool v1Compat);
                static /*0x12b07c8*/ System.Xml.Schema.NamespaceList Intersection(System.Xml.Schema.NamespaceList o1, System.Xml.Schema.NamespaceList o2, bool v1Compat);
                /*0x12af370*/ NamespaceList();
                /*0x12af378*/ NamespaceList(string namespaces, string targetNamespace);
                /*0x12af618*/ System.Xml.Schema.NamespaceList Clone();
                /*0x12af740*/ System.Xml.Schema.NamespaceList.ListType get_Type();
                /*0x12af748*/ string get_Excluded();
                /*0x12af750*/ System.Collections.ICollection get_Enumerate();
                /*0x12af7bc*/ bool Allows(string ns);
                /*0x12af840*/ bool Allows(System.Xml.XmlQualifiedName qname);
                /*0x12af860*/ string ToString();
                /*0x12b06a0*/ System.Xml.Schema.NamespaceList CompareSetToOther(System.Xml.Schema.NamespaceList other);
                /*0x12b0cfc*/ void RemoveNamespace(string tns);

                enum ListType
                {
                    Any = 0,
                    Other = 1,
                    Set = 2,
                }
            }

            class NamespaceListV1Compat : System.Xml.Schema.NamespaceList
            {
                /*0x12b0d5c*/ NamespaceListV1Compat(string namespaces, string targetNamespace);
                /*0x12b0d60*/ bool Allows(string ns);
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

                /*0x12b0d84*/ Parser(System.Xml.Schema.SchemaType schemaType, System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler);
                /*0x12b0e3c*/ System.Xml.Schema.SchemaType Parse(System.Xml.XmlReader reader, string targetNamespace);
                /*0x12b0e8c*/ void StartParsing(System.Xml.XmlReader reader, string targetNamespace);
                /*0x12b18d0*/ bool CheckSchemaRoot(System.Xml.Schema.SchemaType rootType, ref string code);
                /*0x12b19d8*/ System.Xml.Schema.SchemaType FinishParsing();
                /*0x12b19e0*/ System.Xml.Schema.XmlSchema get_XmlSchema();
                /*0x12b19e8*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x12b19f0*/ System.Xml.Schema.SchemaInfo get_XdrSchema();
                /*0x12b1250*/ bool ParseReaderNode();
                /*0x12b19f8*/ void ProcessAppInfoDocMarkup(bool root);
                /*0x12b1c18*/ System.Xml.XmlElement LoadElementNode(bool root);
                /*0x12b2154*/ System.Xml.XmlAttribute CreateXmlNsAttribute(string prefix, string value);
                /*0x12b1fe0*/ System.Xml.XmlAttribute LoadAttributeNode();
                /*0x12b2270*/ System.Xml.XmlEntityReference LoadEntityReferenceInAttribute();
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

                /*0x12b2488*/ RedefineEntry(System.Xml.Schema.XmlSchemaRedefine external, System.Xml.Schema.XmlSchema schema);
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

                static /*0x12b57d8*/ System.Xml.Schema.XmlSchema GetBuildInSchema();
                static /*0x12b911c*/ System.Xml.Schema.XmlSchema GetParentSchema(System.Xml.Schema.XmlSchemaObject currentSchemaObject);
                /*0x12b24b4*/ Preprocessor(System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler, System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings);
                /*0x12b259c*/ bool Execute(System.Xml.Schema.XmlSchema schema, string targetNamespace, bool loadExternals);
                /*0x12b5704*/ void Cleanup(System.Xml.Schema.XmlSchema schema);
                /*0x12b5da4*/ void CleanupRedefine(System.Xml.Schema.XmlSchemaExternal include);
                /*0x12b5e44*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x12b5e4c*/ void set_ReaderSettings(System.Xml.XmlReaderSettings value);
                /*0x12b5e54*/ void set_SchemaLocations(System.Collections.Hashtable value);
                /*0x12b5e5c*/ void set_ChameleonSchemas(System.Collections.Hashtable value);
                /*0x12b5e64*/ System.Xml.Schema.XmlSchema get_RootSchema();
                /*0x12b3878*/ void BuildSchemaList(System.Xml.Schema.XmlSchema schema);
                /*0x12b2b8c*/ void LoadExternals(System.Xml.Schema.XmlSchema schema);
                /*0x12b5ed4*/ void BuildRefNamespaces(System.Xml.Schema.XmlSchema schema);
                /*0x12b60f4*/ void ParseUri(string uri, string code, System.Xml.Schema.XmlSchemaObject sourceSchemaObject);
                /*0x12b39f0*/ void Preprocess(System.Xml.Schema.XmlSchema schema, string targetNamespace, System.Collections.ArrayList imports);
                /*0x12b6738*/ void CopyIncludedComponents(System.Xml.Schema.XmlSchema includedSchema, System.Xml.Schema.XmlSchema schema);
                /*0x12b4c10*/ void PreprocessRedefine(System.Xml.Schema.RedefineEntry redefineEntry);
                /*0x12b91b0*/ void GetIncludedSet(System.Xml.Schema.XmlSchema schema, System.Collections.ArrayList includesList);
                /*0x12b662c*/ void SetSchemaDefaults(System.Xml.Schema.XmlSchema schema);
                /*0x12b98f4*/ int CountGroupSelfReference(System.Xml.Schema.XmlSchemaObjectCollection items, System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaGroup redefined);
                /*0x12b92dc*/ void CheckRefinedGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x12b937c*/ void CheckRefinedAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x12b97e8*/ void CheckRefinedSimpleType(System.Xml.Schema.XmlSchemaSimpleType stype);
                /*0x12b94d4*/ void CheckRefinedComplexType(System.Xml.Schema.XmlSchemaComplexType ctype);
                /*0x12b79fc*/ void PreprocessAttribute(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x12ba0d8*/ void PreprocessLocalAttribute(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x12b9eb0*/ void PreprocessAttributeContent(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x12b7b64*/ void PreprocessAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x12b8a24*/ void PreprocessElement(System.Xml.Schema.XmlSchemaElement element);
                /*0x12bab8c*/ void PreprocessLocalElement(System.Xml.Schema.XmlSchemaElement element);
                /*0x12ba868*/ void PreprocessElementContent(System.Xml.Schema.XmlSchemaElement element);
                /*0x12baef8*/ void PreprocessIdentityConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint constraint);
                /*0x12b8498*/ void PreprocessSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType, bool local);
                /*0x12b7c60*/ void PreprocessComplexType(System.Xml.Schema.XmlSchemaComplexType complexType, bool local);
                /*0x12b8c70*/ void PreprocessGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x12b8e30*/ void PreprocessNotation(System.Xml.Schema.XmlSchemaNotation notation);
                /*0x12bb234*/ void PreprocessParticle(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x12ba4dc*/ void PreprocessAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute, System.Xml.Schema.XmlSchemaObject parent);
                /*0x12b6304*/ void ValidateIdAttribute(System.Xml.Schema.XmlSchemaObject xso);
                /*0x12b9c08*/ void ValidateNameAttribute(System.Xml.Schema.XmlSchemaObject xso);
                /*0x12ba288*/ void ValidateQNameAttribute(System.Xml.Schema.XmlSchemaObject xso, string attributeName, System.Xml.XmlQualifiedName value);
                /*0x12b5e6c*/ System.Uri ResolveSchemaLocationUri(System.Xml.Schema.XmlSchema enclosingSchema, string location);
                /*0x12b5eac*/ object GetSchemaEntity(System.Uri ruri);
                /*0x12b2a58*/ System.Xml.Schema.XmlSchema GetChameleonSchema(string targetNamespace, System.Xml.Schema.XmlSchema schema);
                /*0x12b6260*/ void SetParent(System.Xml.Schema.XmlSchemaObject child, System.Xml.Schema.XmlSchemaObject parent);
                /*0x12b6278*/ void PreprocessAnnotation(System.Xml.Schema.XmlSchemaObject schemaObject);
                /*0x12b90ac*/ void PreprocessAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
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

                static /*0x127a160*/ SchemaAttDef();
                /*0x1279c8c*/ SchemaAttDef(System.Xml.XmlQualifiedName name, string prefix);
                /*0x1279c94*/ SchemaAttDef(System.Xml.XmlQualifiedName name);
                /*0x1279ca0*/ SchemaAttDef();
                /*0x1279ca8*/ string System.Xml.IDtdAttributeInfo.get_Prefix();
                /*0x1279cb0*/ string System.Xml.IDtdAttributeInfo.get_LocalName();
                /*0x1279ccc*/ int System.Xml.IDtdAttributeInfo.get_LineNumber();
                /*0x1279cd4*/ int System.Xml.IDtdAttributeInfo.get_LinePosition();
                /*0x1279cdc*/ bool System.Xml.IDtdAttributeInfo.get_IsNonCDataType();
                /*0x1279d28*/ bool System.Xml.IDtdAttributeInfo.get_IsDeclaredInExternal();
                /*0x1279d30*/ bool System.Xml.IDtdAttributeInfo.get_IsXmlAttribute();
                /*0x1279d40*/ string System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueExpanded();
                /*0x1279de8*/ object System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueTyped();
                /*0x1279df0*/ int System.Xml.IDtdDefaultAttributeInfo.get_ValueLineNumber();
                /*0x1279df8*/ int System.Xml.IDtdDefaultAttributeInfo.get_ValueLinePosition();
                /*0x1279e00*/ int get_LinePosition();
                /*0x1279e08*/ void set_LinePosition(int value);
                /*0x1279e10*/ int get_LineNumber();
                /*0x1279e18*/ void set_LineNumber(int value);
                /*0x1279e20*/ int get_ValueLinePosition();
                /*0x1279e28*/ void set_ValueLinePosition(int value);
                /*0x1279e30*/ int get_ValueLineNumber();
                /*0x1279e38*/ void set_ValueLineNumber(int value);
                /*0x1279d94*/ string get_DefaultValueExpanded();
                /*0x1279e40*/ void set_DefaultValueExpanded(string value);
                /*0x1279d08*/ System.Xml.XmlTokenizedType get_TokenizedType();
                /*0x1279e48*/ void set_TokenizedType(System.Xml.XmlTokenizedType value);
                /*0x1279e68*/ System.Xml.Schema.SchemaAttDef.Reserve get_Reserved();
                /*0x1279e70*/ void set_Reserved(System.Xml.Schema.SchemaAttDef.Reserve value);
                /*0x1279e78*/ bool get_DefaultValueChecked();
                /*0x1279e80*/ System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute();
                /*0x1279e88*/ void set_SchemaAttribute(System.Xml.Schema.XmlSchemaAttribute value);
                /*0x1279e90*/ void CheckXmlSpace(System.Xml.IValidationEventHandling validationEventHandling);
                /*0x127a0fc*/ System.Xml.Schema.SchemaAttDef Clone();

                enum Reserve
                {
                    None = 0,
                    XmlSpace = 1,
                    XmlLang = 2,
                }
            }

            class SchemaBuilder
            {
                /*0x127a1c4*/ SchemaBuilder();
                bool ProcessElement(string prefix, string name, string ns);
                void ProcessAttribute(string prefix, string name, string ns, string value);
                bool IsContentParsed();
                void ProcessMarkup(System.Xml.XmlNode[] markup);
                void ProcessCData(string value);
                void StartChildren();
                void EndChildren();
            }

            class SchemaCollectionCompiler : System.Xml.Schema.BaseProcessor
            {
                /*0x40*/ bool compileContentModel;
                /*0x48*/ System.Xml.Schema.XmlSchemaObjectTable examplars;
                /*0x50*/ System.Collections.Stack complexTypeStack;
                /*0x58*/ System.Xml.Schema.XmlSchema schema;

                static /*0x127ebf8*/ void Cleanup(System.Xml.Schema.XmlSchema schema);
                static /*0x127ebc8*/ void CleanupAttribute(System.Xml.Schema.XmlSchemaAttribute attribute);
                static /*0x127e6dc*/ void CleanupAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                static /*0x127e718*/ void CleanupComplexType(System.Xml.Schema.XmlSchemaComplexType complexType);
                static /*0x127ea3c*/ void CleanupSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType);
                static /*0x127ea54*/ void CleanupElement(System.Xml.Schema.XmlSchemaElement element);
                static /*0x1283704*/ void CleanupAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes);
                static /*0x127e6b8*/ void CleanupGroup(System.Xml.Schema.XmlSchemaGroup group);
                static /*0x12837c8*/ void CleanupParticle(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x127a1cc*/ SchemaCollectionCompiler(System.Xml.XmlNameTable nameTable, System.Xml.Schema.ValidationEventHandler eventHandler);
                /*0x127a280*/ bool Execute(System.Xml.Schema.XmlSchema schema, System.Xml.Schema.SchemaInfo schemaInfo, bool compileContentModel);
                /*0x127a2ec*/ void Prepare();
                /*0x127a774*/ void Cleanup();
                /*0x127b67c*/ void Compile();
                /*0x127d6d4*/ void Output(System.Xml.Schema.SchemaInfo schemaInfo);
                /*0x127f20c*/ void CompileSubstitutionGroup(System.Xml.Schema.XmlSchemaSubstitutionGroupV1Compat substitutionGroup);
                /*0x1283538*/ void CheckSubstitutionGroup(System.Xml.Schema.XmlSchemaSubstitutionGroup substitutionGroup);
                /*0x127f68c*/ void CompileGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x1280b5c*/ void CompileSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType);
                /*0x1283cc4*/ System.Xml.Schema.XmlSchemaSimpleType[] CompileBaseMemberTypes(System.Xml.Schema.XmlSchemaSimpleType simpleType);
                /*0x1284068*/ void CheckUnionType(System.Xml.Schema.XmlSchemaSimpleType unionMember, System.Collections.ArrayList memberTypeDefinitions, System.Xml.Schema.XmlSchemaSimpleType parentType);
                /*0x127fea4*/ void CompileComplexType(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x1284180*/ void CompileSimpleContentExtension(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaSimpleContentExtension simpleExtension);
                /*0x12843c0*/ void CompileSimpleContentRestriction(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaSimpleContentRestriction simpleRestriction);
                /*0x12847e8*/ void CompileComplexContentExtension(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaComplexContentExtension complexExtension);
                /*0x1284bb0*/ void CompileComplexContentRestriction(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaComplexContentRestriction complexRestriction);
                /*0x1283404*/ void CheckParticleDerivation(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x1286344*/ System.Xml.Schema.XmlSchemaParticle CompileContentTypeParticle(System.Xml.Schema.XmlSchemaParticle particle, bool substitution);
                /*0x128392c*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeParticle(System.Xml.Schema.XmlSchemaParticle particle, bool root, bool substitution);
                /*0x12876e0*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeElement(System.Xml.Schema.XmlSchemaElement element, bool substitution);
                /*0x1287830*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeGroupRef(System.Xml.Schema.XmlSchemaGroupRef groupRef, bool root, bool substitution);
                /*0x1287d7c*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeAll(System.Xml.Schema.XmlSchemaAll all, bool root, bool substitution);
                /*0x1288210*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeChoice(System.Xml.Schema.XmlSchemaChoice choice, bool root, bool substitution);
                /*0x1288714*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeSequence(System.Xml.Schema.XmlSchemaSequence sequence, bool root, bool substitution);
                /*0x1287158*/ bool IsValidRestriction(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle);
                /*0x1288c78*/ bool IsElementFromElement(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaElement baseElement);
                /*0x1288d8c*/ bool IsElementFromAny(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaAny baseAny);
                /*0x1288de8*/ bool IsAnyFromAny(System.Xml.Schema.XmlSchemaAny derivedAny, System.Xml.Schema.XmlSchemaAny baseAny);
                /*0x1288e34*/ bool IsGroupBaseFromAny(System.Xml.Schema.XmlSchemaGroupBase derivedGroupBase, System.Xml.Schema.XmlSchemaAny baseAny);
                /*0x1289034*/ bool IsElementFromGroupBase(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly);
                /*0x1289390*/ bool IsGroupBaseFromGroupBase(System.Xml.Schema.XmlSchemaGroupBase derivedGroupBase, System.Xml.Schema.XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly);
                /*0x1289604*/ bool IsSequenceFromAll(System.Xml.Schema.XmlSchemaSequence derivedSequence, System.Xml.Schema.XmlSchemaAll baseAll);
                /*0x1289904*/ bool IsSequenceFromChoice(System.Xml.Schema.XmlSchemaSequence derivedSequence, System.Xml.Schema.XmlSchemaChoice baseChoice);
                /*0x128a408*/ void CalculateSequenceRange(System.Xml.Schema.XmlSchemaSequence sequence, ref decimal minOccurs, ref decimal maxOccurs);
                /*0x1289af4*/ bool IsValidOccurrenceRangeRestriction(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle);
                /*0x128a22c*/ bool IsValidOccurrenceRangeRestriction(decimal minOccurs, decimal maxOccurs, decimal baseMinOccurs, decimal baseMaxOccurs);
                /*0x128a314*/ int GetMappingParticle(System.Xml.Schema.XmlSchemaParticle particle, System.Xml.Schema.XmlSchemaObjectCollection collection);
                /*0x1288bb4*/ bool IsParticleEmptiable(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x1289b38*/ void CalculateEffectiveTotalRange(System.Xml.Schema.XmlSchemaParticle particle, ref decimal minOccurs, ref decimal maxOccurs);
                /*0x128a7c4*/ void PushComplexType(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x12864b4*/ System.Xml.Schema.XmlSchemaContentType GetSchemaContentType(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaParticle particle);
                /*0x127f758*/ void CompileAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x1284e88*/ void CompileLocalAttributes(System.Xml.Schema.XmlSchemaComplexType baseType, System.Xml.Schema.XmlSchemaComplexType derivedType, System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute, System.Xml.Schema.XmlSchemaDerivationMethod derivedBy);
                /*0x128a87c*/ System.Xml.Schema.XmlSchemaAnyAttribute CompileAnyAttributeUnion(System.Xml.Schema.XmlSchemaAnyAttribute a, System.Xml.Schema.XmlSchemaAnyAttribute b);
                /*0x128a7e8*/ System.Xml.Schema.XmlSchemaAnyAttribute CompileAnyAttributeIntersection(System.Xml.Schema.XmlSchemaAnyAttribute a, System.Xml.Schema.XmlSchemaAnyAttribute b);
                /*0x12821c4*/ void CompileAttribute(System.Xml.Schema.XmlSchemaAttribute xa);
                /*0x1282c80*/ void CompileIdentityConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint xi);
                /*0x1281420*/ void CompileElement(System.Xml.Schema.XmlSchemaElement xe);
                /*0x1286524*/ System.Xml.Schema.ContentValidator CompileComplexContent(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x128a910*/ void BuildParticleContentModel(System.Xml.Schema.ParticleContentValidator contentValidator, System.Xml.Schema.XmlSchemaParticle particle);
                /*0x128ae08*/ void CompileParticleElements(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaParticle particle);
                /*0x1283330*/ void CompileCompexTypeElements(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x1283b78*/ System.Xml.Schema.XmlSchemaSimpleType GetSimpleType(System.Xml.XmlQualifiedName name);
                /*0x12870a4*/ System.Xml.Schema.XmlSchemaComplexType GetComplexType(System.Xml.XmlQualifiedName name);
                /*0x1286f40*/ System.Xml.Schema.XmlSchemaType GetAnySchemaType(System.Xml.XmlQualifiedName name);
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

                /*0x128b05c*/ SchemaCollectionPreprocessor(System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventHandler);
                /*0x128b064*/ bool Execute(System.Xml.Schema.XmlSchema schema, string targetNamespace, bool loadExternals, System.Xml.Schema.XmlSchemaCollection xsc);
                /*0x128b288*/ void Cleanup(System.Xml.Schema.XmlSchema schema);
                /*0x128e660*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x128b4a4*/ void LoadExternals(System.Xml.Schema.XmlSchema schema, System.Xml.Schema.XmlSchemaCollection xsc);
                /*0x128e828*/ void BuildRefNamespaces(System.Xml.Schema.XmlSchema schema);
                /*0x128c130*/ void Preprocess(System.Xml.Schema.XmlSchema schema, string targetNamespace, System.Xml.Schema.SchemaCollectionPreprocessor.Compositor compositor);
                /*0x128eb20*/ void PreprocessRedefine(System.Xml.Schema.XmlSchemaRedefine redefine);
                /*0x1291940*/ int CountGroupSelfReference(System.Xml.Schema.XmlSchemaObjectCollection items, System.Xml.XmlQualifiedName name);
                /*0x1291320*/ void CheckRefinedGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x12913b8*/ void CheckRefinedAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x1291834*/ void CheckRefinedSimpleType(System.Xml.Schema.XmlSchemaSimpleType stype);
                /*0x1291520*/ void CheckRefinedComplexType(System.Xml.Schema.XmlSchemaComplexType ctype);
                /*0x128fc40*/ void PreprocessAttribute(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x129212c*/ void PreprocessLocalAttribute(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x1291ef4*/ void PreprocessAttributeContent(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x128fda8*/ void PreprocessAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x1290c74*/ void PreprocessElement(System.Xml.Schema.XmlSchemaElement element);
                /*0x1292ab8*/ void PreprocessLocalElement(System.Xml.Schema.XmlSchemaElement element);
                /*0x1292770*/ void PreprocessElementContent(System.Xml.Schema.XmlSchemaElement element);
                /*0x1292e20*/ void PreprocessIdentityConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint constraint);
                /*0x12906cc*/ void PreprocessSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType, bool local);
                /*0x128fea0*/ void PreprocessComplexType(System.Xml.Schema.XmlSchemaComplexType complexType, bool local);
                /*0x1290ec0*/ void PreprocessGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x129107c*/ void PreprocessNotation(System.Xml.Schema.XmlSchemaNotation notation);
                /*0x1293158*/ void PreprocessParticle(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x1292460*/ void PreprocessAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute, System.Xml.Schema.XmlSchemaObject parent);
                /*0x128bed4*/ void ValidateIdAttribute(System.Xml.Schema.XmlSchemaObject xso);
                /*0x1291c4c*/ void ValidateNameAttribute(System.Xml.Schema.XmlSchemaObject xso);
                /*0x12922d8*/ void ValidateQNameAttribute(System.Xml.Schema.XmlSchemaObject xso, string attributeName, System.Xml.XmlQualifiedName value);
                /*0x128ea2c*/ void SetParent(System.Xml.Schema.XmlSchemaObject child, System.Xml.Schema.XmlSchemaObject parent);
                /*0x128ea44*/ void PreprocessAnnotation(System.Xml.Schema.XmlSchemaObject schemaObject);
                /*0x128e668*/ System.Uri ResolveSchemaLocationUri(System.Xml.Schema.XmlSchema enclosingSchema, string location);
                /*0x128e714*/ System.IO.Stream GetSchemaEntity(System.Uri ruri);

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

                /*0x1189554*/ SchemaDeclBase(System.Xml.XmlQualifiedName name, string prefix);
                /*0x11895dc*/ SchemaDeclBase();
                /*0x1189644*/ System.Xml.XmlQualifiedName get_Name();
                /*0x118964c*/ void set_Name(System.Xml.XmlQualifiedName value);
                /*0x1189654*/ string get_Prefix();
                /*0x11896a8*/ void set_Prefix(string value);
                /*0x11896b0*/ bool get_IsDeclaredInExternal();
                /*0x11896b8*/ void set_IsDeclaredInExternal(bool value);
                /*0x11896c4*/ System.Xml.Schema.SchemaDeclBase.Use get_Presence();
                /*0x11896cc*/ void set_Presence(System.Xml.Schema.SchemaDeclBase.Use value);
                /*0x11896d4*/ long get_MaxLength();
                /*0x11896dc*/ void set_MaxLength(long value);
                /*0x11896e4*/ long get_MinLength();
                /*0x11896ec*/ void set_MinLength(long value);
                /*0x11896f4*/ System.Xml.Schema.XmlSchemaType get_SchemaType();
                /*0x11896fc*/ void set_SchemaType(System.Xml.Schema.XmlSchemaType value);
                /*0x1189704*/ System.Xml.Schema.XmlSchemaDatatype get_Datatype();
                /*0x118970c*/ void set_Datatype(System.Xml.Schema.XmlSchemaDatatype value);
                /*0x1189714*/ void AddValue(string value);
                /*0x1189804*/ System.Collections.Generic.List<string> get_Values();
                /*0x118980c*/ void set_Values(System.Collections.Generic.List<string> value);
                /*0x1189814*/ string get_DefaultValueRaw();
                /*0x1189868*/ void set_DefaultValueRaw(string value);
                /*0x1189870*/ object get_DefaultValueTyped();
                /*0x1189878*/ void set_DefaultValueTyped(object value);
                /*0x1189880*/ bool CheckEnumeration(object pVal);
                /*0x1189938*/ bool CheckValue(object pVal);

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

                static /*0x118a364*/ SchemaElementDecl();
                static /*0x1189c1c*/ System.Xml.Schema.SchemaElementDecl CreateAnyTypeElementDecl();
                /*0x1189988*/ SchemaElementDecl();
                /*0x1189a44*/ SchemaElementDecl(System.Xml.Schema.XmlSchemaDatatype dtype);
                /*0x1189b48*/ SchemaElementDecl(System.Xml.XmlQualifiedName name, string prefix);
                /*0x1189ce0*/ bool System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes();
                /*0x1189ce8*/ System.Xml.IDtdAttributeInfo System.Xml.IDtdAttributeListInfo.LookupAttribute(string prefix, string localName);
                /*0x1189da0*/ System.Collections.Generic.IEnumerable<System.Xml.IDtdDefaultAttributeInfo> System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes();
                /*0x1189da8*/ bool get_IsIdDeclared();
                /*0x1189db0*/ void set_IsIdDeclared(bool value);
                /*0x1189dbc*/ bool get_HasNonCDataAttribute();
                /*0x1189dc4*/ void set_HasNonCDataAttribute(bool value);
                /*0x1189dd0*/ System.Xml.Schema.SchemaElementDecl Clone();
                /*0x1189e34*/ bool get_IsAbstract();
                /*0x1189e3c*/ void set_IsAbstract(bool value);
                /*0x1189e48*/ bool get_IsNillable();
                /*0x1189e50*/ void set_IsNillable(bool value);
                /*0x1189e5c*/ System.Xml.Schema.XmlSchemaDerivationMethod get_Block();
                /*0x1189e64*/ void set_Block(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x1189e6c*/ bool get_IsNotationDeclared();
                /*0x1189e74*/ void set_IsNotationDeclared(bool value);
                /*0x1189e80*/ bool get_HasDefaultAttribute();
                /*0x1189e90*/ bool get_HasRequiredAttribute();
                /*0x1189e98*/ System.Xml.Schema.ContentValidator get_ContentValidator();
                /*0x1189ea0*/ void set_ContentValidator(System.Xml.Schema.ContentValidator value);
                /*0x1189ea8*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0x1189eb0*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x1189eb8*/ System.Xml.Schema.CompiledIdentityConstraint[] get_Constraints();
                /*0x1189ec0*/ void set_Constraints(System.Xml.Schema.CompiledIdentityConstraint[] value);
                /*0x1189ec8*/ System.Xml.Schema.XmlSchemaElement get_SchemaElement();
                /*0x1189ed0*/ void set_SchemaElement(System.Xml.Schema.XmlSchemaElement value);
                /*0x1189ed8*/ void AddAttDef(System.Xml.Schema.SchemaAttDef attdef);
                /*0x118a02c*/ System.Xml.Schema.SchemaAttDef GetAttDef(System.Xml.XmlQualifiedName qname);
                /*0x118a0a4*/ System.Collections.Generic.IList<System.Xml.IDtdDefaultAttributeInfo> get_DefaultAttDefs();
                /*0x118a0ac*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaAttDef> get_AttDefs();
                /*0x118a0b4*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.XmlQualifiedName> get_ProhibitedAttributes();
                /*0x118a0bc*/ void CheckAttributes(System.Collections.Hashtable presence, bool standalone);
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

                static /*0x118a61c*/ bool IsPredefinedEntity(string n);
                /*0x118a3c4*/ SchemaEntity(System.Xml.XmlQualifiedName qname, bool isParameter);
                /*0x118a448*/ string System.Xml.IDtdEntityInfo.get_Name();
                /*0x118a464*/ bool System.Xml.IDtdEntityInfo.get_IsExternal();
                /*0x118a46c*/ bool System.Xml.IDtdEntityInfo.get_IsDeclaredInExternal();
                /*0x118a474*/ bool System.Xml.IDtdEntityInfo.get_IsUnparsedEntity();
                /*0x118a49c*/ bool System.Xml.IDtdEntityInfo.get_IsParameterEntity();
                /*0x118a4a4*/ string System.Xml.IDtdEntityInfo.get_BaseUriString();
                /*0x118a54c*/ string System.Xml.IDtdEntityInfo.get_DeclaredUriString();
                /*0x118a5f4*/ string System.Xml.IDtdEntityInfo.get_SystemId();
                /*0x118a5fc*/ string System.Xml.IDtdEntityInfo.get_PublicId();
                /*0x118a604*/ string System.Xml.IDtdEntityInfo.get_Text();
                /*0x118a60c*/ int System.Xml.IDtdEntityInfo.get_LineNumber();
                /*0x118a614*/ int System.Xml.IDtdEntityInfo.get_LinePosition();
                /*0x118a718*/ System.Xml.XmlQualifiedName get_Name();
                /*0x118a720*/ string get_Url();
                /*0x118a728*/ void set_Url(string value);
                /*0x118a738*/ string get_Pubid();
                /*0x118a740*/ void set_Pubid(string value);
                /*0x118a748*/ bool get_IsExternal();
                /*0x118a750*/ void set_IsExternal(bool value);
                /*0x118a75c*/ bool get_DeclaredInExternal();
                /*0x118a764*/ void set_DeclaredInExternal(bool value);
                /*0x118a770*/ System.Xml.XmlQualifiedName get_NData();
                /*0x118a778*/ void set_NData(System.Xml.XmlQualifiedName value);
                /*0x118a780*/ string get_Text();
                /*0x118a788*/ void set_Text(string value);
                /*0x118a794*/ int get_Line();
                /*0x118a79c*/ void set_Line(int value);
                /*0x118a7a4*/ int get_Pos();
                /*0x118a7ac*/ void set_Pos(int value);
                /*0x118a4f8*/ string get_BaseURI();
                /*0x118a7b4*/ void set_BaseURI(string value);
                /*0x118a7bc*/ bool get_ParsingInProgress();
                /*0x118a7c4*/ void set_ParsingInProgress(bool value);
                /*0x118a5a0*/ string get_DeclaredURI();
                /*0x118a7d0*/ void set_DeclaredURI(string value);
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

                /*0x118a7d8*/ SchemaInfo();
                /*0x118a984*/ System.Xml.XmlQualifiedName get_DocTypeName();
                /*0x118a98c*/ void set_DocTypeName(System.Xml.XmlQualifiedName value);
                /*0x118a994*/ void set_InternalDtdSubset(string value);
                /*0x118a99c*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaElementDecl> get_ElementDecls();
                /*0x118a9a4*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaElementDecl> get_UndeclaredElementDecls();
                /*0x118a9ac*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaEntity> get_GeneralEntities();
                /*0x118aa2c*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaEntity> get_ParameterEntities();
                /*0x118aaac*/ System.Xml.Schema.SchemaType get_SchemaType();
                /*0x118aab4*/ void set_SchemaType(System.Xml.Schema.SchemaType value);
                /*0x118aabc*/ System.Collections.Generic.Dictionary<string, bool> get_TargetNamespaces();
                /*0x118aac4*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaElementDecl> get_ElementDeclsByType();
                /*0x118aacc*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.SchemaAttDef> get_AttributeDecls();
                /*0x118aad4*/ System.Collections.Generic.Dictionary<string, System.Xml.Schema.SchemaNotation> get_Notations();
                /*0x118ab54*/ int get_ErrorCount();
                /*0x118ab5c*/ void set_ErrorCount(int value);
                /*0x118ab64*/ System.Xml.Schema.SchemaElementDecl GetElementDecl(System.Xml.XmlQualifiedName qname);
                /*0x118abdc*/ System.Xml.Schema.SchemaElementDecl GetTypeDecl(System.Xml.XmlQualifiedName qname);
                /*0x118ac54*/ System.Xml.Schema.XmlSchemaElement GetElement(System.Xml.XmlQualifiedName qname);
                /*0x118ac6c*/ bool HasSchema(string ns);
                /*0x118acc4*/ bool Contains(string ns);
                /*0x118ad1c*/ System.Xml.Schema.SchemaAttDef GetAttributeXdr(System.Xml.Schema.SchemaElementDecl ed, System.Xml.XmlQualifiedName qname);
                /*0x118ae6c*/ System.Xml.Schema.SchemaAttDef GetAttributeXsd(System.Xml.Schema.SchemaElementDecl ed, System.Xml.XmlQualifiedName qname, System.Xml.Schema.XmlSchemaObject partialValidationType, ref System.Xml.Schema.AttributeMatchState attributeMatchState);
                /*0x118b084*/ System.Xml.Schema.SchemaAttDef GetAttributeXsd(System.Xml.Schema.SchemaElementDecl ed, System.Xml.XmlQualifiedName qname, ref bool skip);
                /*0x118b184*/ void Add(System.Xml.Schema.SchemaInfo sinfo, System.Xml.Schema.ValidationEventHandler eventhandler);
                /*0x118ba64*/ void Finish();
                /*0x118bc18*/ bool System.Xml.IDtdInfo.get_HasDefaultAttributes();
                /*0x118bc20*/ bool System.Xml.IDtdInfo.get_HasNonCDataAttributes();
                /*0x118bc28*/ System.Xml.IDtdAttributeListInfo System.Xml.IDtdInfo.LookupAttributeList(string prefix, string localName);
                /*0x118bcf4*/ System.Xml.IDtdEntityInfo System.Xml.IDtdInfo.LookupEntity(string name);
                /*0x118bdac*/ System.Xml.XmlQualifiedName System.Xml.IDtdInfo.get_Name();
                /*0x118bdb4*/ string System.Xml.IDtdInfo.get_InternalDtdSubset();
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

                /*0x118bdbc*/ SchemaNames(System.Xml.XmlNameTable nameTable);
                /*0x118e894*/ void CreateTokenToQNameTable();
                /*0x1190200*/ System.Xml.Schema.SchemaType SchemaTypeFromRoot(string localName, string ns);
                /*0x1190260*/ bool IsXSDRoot(string localName, string ns);
                /*0x11902b0*/ bool IsXDRRoot(string localName, string ns);

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

                /*0x1190300*/ SchemaNamespaceManager(System.Xml.Schema.XmlSchemaObject node);
                /*0x1190328*/ string LookupNamespace(string prefix);
                /*0x1190450*/ string LookupPrefix(string ns);
            }

            class SchemaNotation
            {
                /*0x10*/ System.Xml.XmlQualifiedName name;
                /*0x18*/ string systemLiteral;
                /*0x20*/ string pubid;

                /*0x119084c*/ SchemaNotation(System.Xml.XmlQualifiedName name);
                /*0x1190874*/ System.Xml.XmlQualifiedName get_Name();
                /*0x119087c*/ string get_SystemLiteral();
                /*0x1190884*/ void set_SystemLiteral(string value);
                /*0x119088c*/ string get_Pubid();
                /*0x1190894*/ void set_Pubid(string value);
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

                /*0x119089c*/ Compiler(System.Xml.XmlNameTable nameTable, System.Xml.Schema.ValidationEventHandler eventHandler, System.Xml.Schema.XmlSchema schemaForSchema, System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings);
                /*0x1190a7c*/ bool Execute(System.Xml.Schema.XmlSchemaSet schemaSet, System.Xml.Schema.SchemaInfo schemaCompiledInfo);
                /*0x1193bd8*/ void Prepare(System.Xml.Schema.XmlSchema schema, bool cleanup);
                /*0x119598c*/ void UpdateSForSSimpleTypes();
                /*0x1192b04*/ void Output(System.Xml.Schema.SchemaInfo schemaInfo);
                /*0x1195adc*/ void ImportAllCompiledSchemas(System.Xml.Schema.XmlSchemaSet schemaSet);
                /*0x1190af8*/ bool Compile();
                /*0x1195400*/ void CleanupAttribute(System.Xml.Schema.XmlSchemaAttribute attribute);
                /*0x1195464*/ void CleanupAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x11954b8*/ void CleanupComplexType(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x11958d8*/ void CleanupSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType);
                /*0x119527c*/ void CleanupElement(System.Xml.Schema.XmlSchemaElement element);
                /*0x119a830*/ void CleanupAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes);
                /*0x1195428*/ void CleanupGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x119a908*/ void CleanupParticle(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x11998b0*/ void ProcessSubstitutionGroups();
                /*0x119aab0*/ void CompileSubstitutionGroup(System.Xml.Schema.XmlSchemaSubstitutionGroup substitutionGroup);
                /*0x119a708*/ void RecursivelyCheckRedefinedGroups(System.Xml.Schema.XmlSchemaGroup redefinedGroup, System.Xml.Schema.XmlSchemaGroup baseGroup);
                /*0x119a7b8*/ void RecursivelyCheckRedefinedAttributeGroups(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup, System.Xml.Schema.XmlSchemaAttributeGroup baseAttributeGroup);
                /*0x1195be4*/ void CompileGroup(System.Xml.Schema.XmlSchemaGroup group);
                /*0x1196fe8*/ void CompileSimpleType(System.Xml.Schema.XmlSchemaSimpleType simpleType);
                /*0x119beb4*/ System.Xml.Schema.XmlSchemaSimpleType[] CompileBaseMemberTypes(System.Xml.Schema.XmlSchemaSimpleType simpleType);
                /*0x119c258*/ void CheckUnionType(System.Xml.Schema.XmlSchemaSimpleType unionMember, System.Collections.ArrayList memberTypeDefinitions, System.Xml.Schema.XmlSchemaSimpleType parentType);
                /*0x1196530*/ void CompileComplexType(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x119c370*/ void CompileSimpleContentExtension(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaSimpleContentExtension simpleExtension);
                /*0x119c5b0*/ void CompileSimpleContentRestriction(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaSimpleContentRestriction simpleRestriction);
                /*0x119c9d8*/ void CompileComplexContentExtension(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaComplexContentExtension complexExtension);
                /*0x119cd4c*/ void CompileComplexContentRestriction(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaComplexContentRestriction complexRestriction);
                /*0x119a120*/ void CheckParticleDerivation(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x119b36c*/ void CheckParticleDerivation(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle);
                /*0x119e550*/ System.Xml.Schema.XmlSchemaParticle CompileContentTypeParticle(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x119afc8*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeParticle(System.Xml.Schema.XmlSchemaParticle particle, bool root);
                /*0x11a1168*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeElement(System.Xml.Schema.XmlSchemaElement element);
                /*0x11a0020*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeGroupRef(System.Xml.Schema.XmlSchemaGroupRef groupRef, bool root);
                /*0x11a0538*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeAll(System.Xml.Schema.XmlSchemaAll all, bool root);
                /*0x11a07bc*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeChoice(System.Xml.Schema.XmlSchemaChoice choice, bool root);
                /*0x11a0cb4*/ System.Xml.Schema.XmlSchemaParticle CannonicalizeSequence(System.Xml.Schema.XmlSchemaSequence sequence, bool root);
                /*0x119f368*/ System.Xml.Schema.XmlSchemaParticle CannonicalizePointlessRoot(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x119f63c*/ bool IsValidRestriction(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle);
                /*0x11a1488*/ bool IsElementFromElement(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaElement baseElement);
                /*0x11a1674*/ bool IsElementFromAny(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaAny baseAny);
                /*0x11a17fc*/ bool IsAnyFromAny(System.Xml.Schema.XmlSchemaAny derivedAny, System.Xml.Schema.XmlSchemaAny baseAny);
                /*0x11a18f4*/ bool IsGroupBaseFromAny(System.Xml.Schema.XmlSchemaGroupBase derivedGroupBase, System.Xml.Schema.XmlSchemaAny baseAny);
                /*0x11a1cc4*/ bool IsElementFromGroupBase(System.Xml.Schema.XmlSchemaElement derivedElement, System.Xml.Schema.XmlSchemaGroupBase baseGroupBase);
                /*0x11a2a7c*/ bool IsChoiceFromChoiceSubstGroup(System.Xml.Schema.XmlSchemaChoice derivedChoice, System.Xml.Schema.XmlSchemaChoice baseChoice);
                /*0x11a24a8*/ bool IsGroupBaseFromGroupBase(System.Xml.Schema.XmlSchemaGroupBase derivedGroupBase, System.Xml.Schema.XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly);
                /*0x11a277c*/ bool IsSequenceFromAll(System.Xml.Schema.XmlSchemaSequence derivedSequence, System.Xml.Schema.XmlSchemaAll baseAll);
                /*0x11a2c08*/ bool IsSequenceFromChoice(System.Xml.Schema.XmlSchemaSequence derivedSequence, System.Xml.Schema.XmlSchemaChoice baseChoice);
                /*0x11a2f38*/ bool IsValidOccurrenceRangeRestriction(System.Xml.Schema.XmlSchemaParticle derivedParticle, System.Xml.Schema.XmlSchemaParticle baseParticle);
                /*0x11a37c0*/ bool IsValidOccurrenceRangeRestriction(decimal minOccurs, decimal maxOccurs, decimal baseMinOccurs, decimal baseMaxOccurs);
                /*0x11a38a8*/ int GetMappingParticle(System.Xml.Schema.XmlSchemaParticle particle, System.Xml.Schema.XmlSchemaObjectCollection collection);
                /*0x11a13c4*/ bool IsParticleEmptiable(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x11a30d8*/ void CalculateEffectiveTotalRange(System.Xml.Schema.XmlSchemaParticle particle, ref decimal minOccurs, ref decimal maxOccurs);
                /*0x11a399c*/ void PushComplexType(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x119e6b8*/ System.Xml.Schema.XmlSchemaContentType GetSchemaContentType(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaComplexContent complexContent, System.Xml.Schema.XmlSchemaParticle particle);
                /*0x1195cac*/ void CompileAttributeGroup(System.Xml.Schema.XmlSchemaAttributeGroup attributeGroup);
                /*0x119cffc*/ void CompileLocalAttributes(System.Xml.Schema.XmlSchemaComplexType baseType, System.Xml.Schema.XmlSchemaComplexType derivedType, System.Xml.Schema.XmlSchemaObjectCollection attributes, System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute, System.Xml.Schema.XmlSchemaDerivationMethod derivedBy);
                /*0x119b444*/ void CheckAtrributeGroupRestriction(System.Xml.Schema.XmlSchemaAttributeGroup baseAttributeGroup, System.Xml.Schema.XmlSchemaAttributeGroup derivedAttributeGroup);
                /*0x11a3ae8*/ bool IsProcessContentsRestricted(System.Xml.Schema.XmlSchemaComplexType baseType, System.Xml.Schema.XmlSchemaAnyAttribute derivedAttributeWildcard, System.Xml.Schema.XmlSchemaAnyAttribute baseAttributeWildcard);
                /*0x11a3a54*/ System.Xml.Schema.XmlSchemaAnyAttribute CompileAnyAttributeUnion(System.Xml.Schema.XmlSchemaAnyAttribute a, System.Xml.Schema.XmlSchemaAnyAttribute b);
                /*0x11a39c0*/ System.Xml.Schema.XmlSchemaAnyAttribute CompileAnyAttributeIntersection(System.Xml.Schema.XmlSchemaAnyAttribute a, System.Xml.Schema.XmlSchemaAnyAttribute b);
                /*0x11987c8*/ void CompileAttribute(System.Xml.Schema.XmlSchemaAttribute xa);
                /*0x11a3bc4*/ void SetDefaultFixed(System.Xml.Schema.XmlSchemaAttribute xa, System.Xml.Schema.SchemaAttDef decl);
                /*0x11990f4*/ void CompileIdentityConstraint(System.Xml.Schema.XmlSchemaIdentityConstraint xi);
                /*0x11978e4*/ void CompileElement(System.Xml.Schema.XmlSchemaElement xe);
                /*0x119e728*/ System.Xml.Schema.ContentValidator CompileComplexContent(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x11a3d70*/ bool BuildParticleContentModel(System.Xml.Schema.ParticleContentValidator contentValidator, System.Xml.Schema.XmlSchemaParticle particle);
                /*0x11a4274*/ void CompileParticleElements(System.Xml.Schema.XmlSchemaComplexType complexType, System.Xml.Schema.XmlSchemaParticle particle);
                /*0x119b1e4*/ void CompileParticleElements(System.Xml.Schema.XmlSchemaParticle particle);
                /*0x1199794*/ void CompileComplexTypeElements(System.Xml.Schema.XmlSchemaComplexType complexType);
                /*0x119bddc*/ System.Xml.Schema.XmlSchemaSimpleType GetSimpleType(System.Xml.XmlQualifiedName name);
                /*0x119f2c0*/ System.Xml.Schema.XmlSchemaComplexType GetComplexType(System.Xml.XmlQualifiedName name);
                /*0x119f168*/ System.Xml.Schema.XmlSchemaType GetAnySchemaType(System.Xml.XmlQualifiedName name);
                /*0x11a1368*/ void CopyPosition(System.Xml.Schema.XmlSchemaAnnotated to, System.Xml.Schema.XmlSchemaAnnotated from, bool copyParent);
                /*0x11a2f7c*/ bool IsFixedEqual(System.Xml.Schema.SchemaDeclBase baseDecl, System.Xml.Schema.SchemaDeclBase derivedDecl);
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

                /*0x11ba48c*/ ValidationEventArgs(System.Xml.Schema.XmlSchemaException ex);
                /*0x11ba4fc*/ ValidationEventArgs(System.Xml.Schema.XmlSchemaException ex, System.Xml.Schema.XmlSeverityType severity);
                /*0x11ba570*/ System.Xml.Schema.XmlSeverityType get_Severity();
                /*0x11ba578*/ System.Xml.Schema.XmlSchemaException get_Exception();
            }

            class ValidationEventHandler : System.MulticastDelegate
            {
                /*0x11ba580*/ ValidationEventHandler(object object, nint method);
                /*0x11ba6b0*/ void Invoke(object sender, System.Xml.Schema.ValidationEventArgs e);
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

                /*0x11ba6c4*/ ValidationState();
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

                static /*0x11bffd4*/ XdrBuilder();
                static /*0x11bb364*/ bool IsXdrSchema(string uri);
                static /*0x11bbe90*/ void XDR_InitRoot(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x11bbed0*/ void XDR_BuildRoot_Name(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x11bbf5c*/ void XDR_BuildRoot_ID(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x11bbf60*/ void XDR_BeginRoot(System.Xml.Schema.XdrBuilder builder);
                static /*0x11bc03c*/ void XDR_EndRoot(System.Xml.Schema.XdrBuilder builder);
                static /*0x11bc594*/ void XDR_InitElementType(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x11bc694*/ void XDR_BuildElementType_Name(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x11bc830*/ void XDR_BuildElementType_Content(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x11bca54*/ void XDR_BuildElementType_Model(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x11bcbd0*/ void XDR_BuildElementType_Order(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x11bcda0*/ void XDR_BuildElementType_DtType(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x11bcf58*/ void XDR_BuildElementType_DtValues(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x11bd038*/ void XDR_BuildElementType_DtMaxLength(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x11bd1e4*/ void XDR_BuildElementType_DtMinLength(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x11bd390*/ void XDR_BeginElementType(System.Xml.Schema.XdrBuilder builder);
                static /*0x11bd66c*/ void XDR_EndElementType(System.Xml.Schema.XdrBuilder builder);
                static /*0x11bda30*/ void XDR_InitAttributeType(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x11bdb18*/ void XDR_BuildAttributeType_Name(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x11bdd44*/ void XDR_BuildAttributeType_Required(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x11bdebc*/ void XDR_BuildAttributeType_Default(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x11bdedc*/ void XDR_BuildAttributeType_DtType(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x11be0d0*/ void XDR_BuildAttributeType_DtValues(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x11be1b0*/ void XDR_BuildAttributeType_DtMaxLength(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x11be224*/ void XDR_BuildAttributeType_DtMinLength(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x11be298*/ void XDR_BeginAttributeType(System.Xml.Schema.XdrBuilder builder);
                static /*0x11be310*/ void XDR_EndAttributeType(System.Xml.Schema.XdrBuilder builder);
                static /*0x11be66c*/ void XDR_InitElement(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x11be6f8*/ void XDR_BuildElement_Type(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x11be940*/ void XDR_BuildElement_MinOccurs(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x11beaac*/ void XDR_BuildElement_MaxOccurs(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x11bec48*/ void XDR_EndElement(System.Xml.Schema.XdrBuilder builder);
                static /*0x11bed1c*/ void XDR_InitAttribute(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x11bedb0*/ void XDR_BuildAttribute_Type(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x11bee74*/ void XDR_BuildAttribute_Required(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x11beef8*/ void XDR_BuildAttribute_Default(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x11bef18*/ void XDR_BeginAttribute(System.Xml.Schema.XdrBuilder builder);
                static /*0x11bf1cc*/ void XDR_EndAttribute(System.Xml.Schema.XdrBuilder builder);
                static /*0x11bf264*/ void XDR_InitGroup(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x11bf31c*/ void XDR_BuildGroup_Order(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x11bf408*/ void XDR_BuildGroup_MinOccurs(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x11bf48c*/ void XDR_BuildGroup_MaxOccurs(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                static /*0x11bf510*/ void XDR_EndGroup(System.Xml.Schema.XdrBuilder builder);
                static /*0x11bf640*/ void XDR_InitElementDtType(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x11bf6dc*/ void XDR_EndElementDtType(System.Xml.Schema.XdrBuilder builder);
                static /*0x11bf79c*/ void XDR_InitAttributeDtType(System.Xml.Schema.XdrBuilder builder, object obj);
                static /*0x11bf808*/ void XDR_EndAttributeDtType(System.Xml.Schema.XdrBuilder builder);
                static /*0x11bddbc*/ bool IsYes(object obj, System.Xml.Schema.XdrBuilder builder);
                static /*0x11be9b4*/ uint ParseMinOccurs(object obj, System.Xml.Schema.XdrBuilder builder);
                static /*0x11beb20*/ uint ParseMaxOccurs(object obj, System.Xml.Schema.XdrBuilder builder);
                static /*0x11becec*/ void HandleMinMax(System.Xml.Schema.ParticleContentValidator pContent, uint cMin, uint cMax);
                static /*0x11bd0ac*/ void ParseDtMaxLength(ref uint cVal, object obj, System.Xml.Schema.XdrBuilder builder);
                static /*0x11bd258*/ void ParseDtMinLength(ref uint cVal, object obj, System.Xml.Schema.XdrBuilder builder);
                static /*0x11bd9a8*/ void CompareMinMaxLength(uint cMin, uint cMax, System.Xml.Schema.XdrBuilder builder);
                static /*0x11bf8e8*/ bool ParseInteger(string str, ref uint n);
                /*0x11ba71c*/ XdrBuilder(System.Xml.XmlReader reader, System.Xml.XmlNamespaceManager curmgr, System.Xml.Schema.SchemaInfo sinfo, string targetNamspace, System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventhandler);
                /*0x11ba938*/ bool ProcessElement(string prefix, string name, string ns);
                /*0x11bafb8*/ void ProcessAttribute(string prefix, string name, string ns, string value);
                /*0x11bba64*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x11bb41c*/ bool LoadSchema(string uri);
                /*0x11bbb84*/ bool IsContentParsed();
                /*0x11bbb8c*/ void ProcessMarkup(System.Xml.XmlNode[] markup);
                /*0x11bbbec*/ void ProcessCData(string value);
                /*0x11bbc60*/ void StartChildren();
                /*0x11bbc98*/ void EndChildren();
                /*0x11badc8*/ void Push();
                /*0x11bbcd4*/ void Pop();
                /*0x11bbd54*/ void PushGroupInfo();
                /*0x11bbe10*/ void PopGroupInfo();
                /*0x11bac2c*/ bool GetNextState(System.Xml.XmlQualifiedName qname);
                /*0x11bae10*/ bool IsSkipableElement(System.Xml.XmlQualifiedName qname);
                /*0x11bb92c*/ bool IsSkipableAttribute(System.Xml.XmlQualifiedName qname);
                /*0x11bcc7c*/ int GetOrder(System.Xml.XmlQualifiedName qname);
                /*0x11be880*/ void AddOrder();
                /*0x11bc4f0*/ void XDR_CheckAttributeDefault(System.Xml.Schema.XdrBuilder.DeclBaseInfo decl, System.Xml.Schema.SchemaAttDef pAttdef);
                /*0x11be61c*/ void SetAttributePresence(System.Xml.Schema.SchemaAttDef pAttdef, bool fRequired);
                /*0x11bc8cc*/ int GetContent(System.Xml.XmlQualifiedName qname);
                /*0x11bcaf4*/ bool GetModel(System.Xml.XmlQualifiedName qname);
                /*0x11bdf8c*/ System.Xml.Schema.XmlSchemaDatatype CheckDatatype(string str);
                /*0x11be52c*/ void CheckDefaultAttValue(System.Xml.Schema.SchemaAttDef attDef);
                /*0x11bb358*/ bool IsGlobal(int flags);
                /*0x11bba6c*/ void SendValidationEvent(string code, string[] args, System.Xml.Schema.XmlSeverityType severity);
                /*0x11bcea0*/ void SendValidationEvent(string code);
                /*0x11baed0*/ void SendValidationEvent(string code, string msg);
                /*0x11bfe14*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity);

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

                    /*0x11bed94*/ DeclBaseInfo();
                    /*0x11bf1e8*/ void Reset();
                }

                class GroupContent
                {
                    /*0x10*/ uint _MinVal;
                    /*0x14*/ uint _MaxVal;
                    /*0x18*/ bool _HasMaxAttr;
                    /*0x19*/ bool _HasMinAttr;
                    /*0x1c*/ int _Order;

                    static /*0x11c1fe4*/ void Copy(System.Xml.Schema.XdrBuilder.GroupContent from, System.Xml.Schema.XdrBuilder.GroupContent to);
                    static /*0x11bbda4*/ System.Xml.Schema.XdrBuilder.GroupContent Copy(System.Xml.Schema.XdrBuilder.GroupContent other);
                    /*0x11ba930*/ GroupContent();
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

                    /*0x11ba920*/ ElementContent();
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

                    /*0x11ba928*/ AttributeContent();
                }

                class XdrBuildFunction : System.MulticastDelegate
                {
                    /*0x11c1b90*/ XdrBuildFunction(object object, nint method);
                    /*0x11c200c*/ void Invoke(System.Xml.Schema.XdrBuilder builder, object obj, string prefix);
                }

                class XdrInitFunction : System.MulticastDelegate
                {
                    /*0x11c1d64*/ XdrInitFunction(object object, nint method);
                    /*0x11c2020*/ void Invoke(System.Xml.Schema.XdrBuilder builder, object obj);
                }

                class XdrBeginChildFunction : System.MulticastDelegate
                {
                    /*0x11c1e3c*/ XdrBeginChildFunction(object object, nint method);
                    /*0x11c2034*/ void Invoke(System.Xml.Schema.XdrBuilder builder);
                }

                class XdrEndChildFunction : System.MulticastDelegate
                {
                    /*0x11c1f10*/ XdrEndChildFunction(object object, nint method);
                    /*0x11c2048*/ void Invoke(System.Xml.Schema.XdrBuilder builder);
                }

                class XdrAttributeEntry
                {
                    /*0x10*/ System.Xml.Schema.SchemaNames.Token _Attribute;
                    /*0x14*/ int _SchemaFlags;
                    /*0x18*/ System.Xml.Schema.XmlSchemaDatatype _Datatype;
                    /*0x20*/ System.Xml.Schema.XdrBuilder.XdrBuildFunction _BuildFunc;

                    /*0x11c1c68*/ XdrAttributeEntry(System.Xml.Schema.SchemaNames.Token a, System.Xml.XmlTokenizedType ttype, System.Xml.Schema.XdrBuilder.XdrBuildFunction build);
                    /*0x11c1cb0*/ XdrAttributeEntry(System.Xml.Schema.SchemaNames.Token a, System.Xml.XmlTokenizedType ttype, int schemaFlags, System.Xml.Schema.XdrBuilder.XdrBuildFunction build);
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

                    /*0x11c1cfc*/ XdrEntry(System.Xml.Schema.SchemaNames.Token n, int[] states, System.Xml.Schema.XdrBuilder.XdrAttributeEntry[] attributes, System.Xml.Schema.XdrBuilder.XdrInitFunction init, System.Xml.Schema.XdrBuilder.XdrBeginChildFunction begin, System.Xml.Schema.XdrBuilder.XdrEndChildFunction end, bool fText);
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

                static /*0x11bf920*/ void CheckDefaultValue(string value, System.Xml.Schema.SchemaAttDef attdef, System.Xml.Schema.SchemaInfo sinfo, System.Xml.XmlNamespaceManager nsManager, System.Xml.XmlNameTable NameTable, object sender, System.Xml.Schema.ValidationEventHandler eventhandler, string baseUri, int lineNo, int linePos);
                /*0x11c205c*/ XdrValidator(System.Xml.Schema.BaseValidator validator);
                /*0x11c2284*/ XdrValidator(System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling);
                /*0x11c20dc*/ void Init();
                /*0x11c23f0*/ void Validate();
                /*0x11c26c0*/ void ValidateElement();
                /*0x11c2a10*/ void ValidateChildElement();
                /*0x11c24a8*/ bool get_IsInlineSchemaStarted();
                /*0x11c24b8*/ void ProcessInlineSchema();
                /*0x11c2b58*/ void ProcessElement();
                /*0x11c2850*/ void ValidateEndElement();
                /*0x11c2c0c*/ System.Xml.Schema.SchemaElementDecl ThoroughGetElementDecl();
                /*0x11c2f20*/ void ValidateStartElement();
                /*0x11c32fc*/ void ValidateEndStartElement();
                /*0x11c3f20*/ void LoadSchemaFromLocation(string uri);
                /*0x11c3ce0*/ void LoadSchema(string uri);
                /*0x11c4614*/ bool get_HasSchema();
                /*0x11c4638*/ bool get_PreserveWhitespace();
                /*0x11c4670*/ void ProcessTokenizedType(System.Xml.XmlTokenizedType ttype, string name);
                /*0x11c4908*/ void CompleteValidation();
                /*0x11c3658*/ void CheckValue(string value, System.Xml.Schema.SchemaAttDef attdef);
                /*0x11c4878*/ void AddID(string name, object node);
                /*0x11c4ba4*/ object FindId(string name);
                /*0x11c231c*/ void Push(System.Xml.XmlQualifiedName elementName);
                /*0x11c3c44*/ void Pop();
                /*0x11c49cc*/ void CheckForwardRefs();
                /*0x11c3e74*/ System.Xml.XmlQualifiedName QualifiedName(string name, string ns);
            }

            class XmlAtomicValue : System.Xml.XPath.XPathItem, System.ICloneable
            {
                /*0x10*/ System.Xml.Schema.XmlSchemaType xmlType;
                /*0x18*/ object objVal;
                /*0x20*/ System.TypeCode clrType;
                /*0x24*/ System.Xml.Schema.XmlAtomicValue.Union unionVal;
                /*0x30*/ System.Xml.Schema.XmlAtomicValue.NamespacePrefixForQName nsPrefix;

                /*0x11c4bc0*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, bool value);
                /*0x11c4c4c*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, System.DateTime value);
                /*0x11c4cd4*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, double value);
                /*0x11c4d64*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, int value);
                /*0x11c4de8*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, long value);
                /*0x11c4e70*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, string value);
                /*0x11c4f14*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, string value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x11c51c4*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, object value);
                /*0x11c5268*/ XmlAtomicValue(System.Xml.Schema.XmlSchemaType xmlType, object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x11c5460*/ object System.ICloneable.Clone();
                /*0x11c5464*/ System.Xml.Schema.XmlSchemaType get_XmlType();
                /*0x11c546c*/ System.Type get_ValueType();
                /*0x11c5494*/ object get_TypedValue();
                /*0x11c565c*/ bool get_ValueAsBoolean();
                /*0x11c572c*/ System.DateTime get_ValueAsDateTime();
                /*0x11c5810*/ double get_ValueAsDouble();
                /*0x11c58f0*/ int get_ValueAsInt();
                /*0x11c59c8*/ long get_ValueAsLong();
                /*0x11c5aac*/ object ValueAs(System.Type type, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0x11c5ce0*/ string get_Value();
                /*0x11c5dd8*/ string ToString();
                /*0x11c50cc*/ string GetPrefixFromQName(string value);

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

                    /*0x11c5198*/ NamespacePrefixForQName(string prefix, string ns);
                    /*0x11c5de4*/ string LookupNamespace(string prefix);
                    /*0x11c5e18*/ string LookupPrefix(string namespaceName);
                    /*0x11c5e44*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
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

                static /*0x11c7990*/ XmlSchema();
                static /*0x11c6070*/ System.Xml.Schema.XmlSchema Read(System.Xml.XmlReader reader, System.Xml.Schema.ValidationEventHandler validationEventHandler);
                /*0x11c5ee0*/ XmlSchema();
                /*0x11c621c*/ bool CompileSchema(System.Xml.Schema.XmlSchemaCollection xsc, System.Xml.XmlResolver resolver, System.Xml.Schema.SchemaInfo schemaInfo, string ns, System.Xml.Schema.ValidationEventHandler validationEventHandler, System.Xml.XmlNameTable nameTable, bool CompileContentModel);
                /*0x11c63f8*/ void CompileSchemaInSet(System.Xml.XmlNameTable nameTable, System.Xml.Schema.ValidationEventHandler eventHandler, System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings);
                /*0x11c64a8*/ System.Xml.Schema.XmlSchemaForm get_AttributeFormDefault();
                /*0x11c64b0*/ void set_AttributeFormDefault(System.Xml.Schema.XmlSchemaForm value);
                /*0x11c64b8*/ System.Xml.Schema.XmlSchemaDerivationMethod get_BlockDefault();
                /*0x11c64c0*/ void set_BlockDefault(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x11c64c8*/ System.Xml.Schema.XmlSchemaDerivationMethod get_FinalDefault();
                /*0x11c64d0*/ void set_FinalDefault(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x11c64d8*/ System.Xml.Schema.XmlSchemaForm get_ElementFormDefault();
                /*0x11c64e0*/ void set_ElementFormDefault(System.Xml.Schema.XmlSchemaForm value);
                /*0x11c64e8*/ string get_TargetNamespace();
                /*0x11c64f0*/ void set_TargetNamespace(string value);
                /*0x11c64f8*/ string get_Version();
                /*0x11c6500*/ void set_Version(string value);
                /*0x11c6508*/ System.Xml.Schema.XmlSchemaObjectCollection get_Includes();
                /*0x11c6510*/ System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                /*0x11c6518*/ bool get_IsCompiledBySet();
                /*0x11c6520*/ void set_IsCompiledBySet(bool value);
                /*0x11c652c*/ bool get_IsPreprocessed();
                /*0x11c6534*/ void set_IsPreprocessed(bool value);
                /*0x11c6540*/ bool get_IsRedefined();
                /*0x11c6548*/ void set_IsRedefined(bool value);
                /*0x11c6554*/ System.Xml.Schema.XmlSchemaObjectTable get_Attributes();
                /*0x11c65c0*/ System.Xml.Schema.XmlSchemaObjectTable get_AttributeGroups();
                /*0x11c662c*/ System.Xml.Schema.XmlSchemaObjectTable get_SchemaTypes();
                /*0x11c6698*/ System.Xml.Schema.XmlSchemaObjectTable get_Elements();
                /*0x11c6704*/ string get_Id();
                /*0x11c670c*/ void set_Id(string value);
                /*0x11c6714*/ System.Xml.Schema.XmlSchemaObjectTable get_Groups();
                /*0x11c671c*/ System.Xml.Schema.XmlSchemaObjectTable get_Notations();
                /*0x11c6724*/ System.Xml.Schema.XmlSchemaObjectTable get_IdentityConstraints();
                /*0x11c672c*/ System.Uri get_BaseUri();
                /*0x11c6734*/ void set_BaseUri(System.Uri value);
                /*0x11c673c*/ int get_SchemaId();
                /*0x11c67ac*/ bool get_IsChameleon();
                /*0x11c67b4*/ void set_IsChameleon(bool value);
                /*0x11c67c0*/ System.Collections.Hashtable get_Ids();
                /*0x11c67c8*/ System.Xml.XmlDocument get_Document();
                /*0x11c6834*/ int get_ErrorCount();
                /*0x11c683c*/ void set_ErrorCount(int value);
                /*0x11c6844*/ System.Xml.Schema.XmlSchema Clone();
                /*0x11c694c*/ System.Xml.Schema.XmlSchema DeepClone();
                /*0x11c76bc*/ string get_IdAttribute();
                /*0x11c76c4*/ void set_IdAttribute(string value);
                /*0x11c76cc*/ void SetIsCompiled(bool isCompiled);
                /*0x11c76d8*/ void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes);
                /*0x11c76e0*/ void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
                /*0x11c76f8*/ System.Collections.ArrayList get_ImportedSchemas();
                /*0x11c7764*/ System.Collections.ArrayList get_ImportedNamespaces();
                /*0x11c77d0*/ void GetExternalSchemasList(System.Collections.IList extList, System.Xml.Schema.XmlSchema schema);
            }

            class XmlSchemaAll : System.Xml.Schema.XmlSchemaGroupBase
            {
                /*0x78*/ System.Xml.Schema.XmlSchemaObjectCollection items;

                /*0x11c7a2c*/ XmlSchemaAll();
                /*0x11c79dc*/ System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                /*0x11c79e4*/ bool get_IsEmpty();
                /*0x11c7a24*/ void SetItems(System.Xml.Schema.XmlSchemaObjectCollection newItems);
            }

            class XmlSchemaAnnotated : System.Xml.Schema.XmlSchemaObject
            {
                /*0x38*/ string id;
                /*0x40*/ System.Xml.Schema.XmlSchemaAnnotation annotation;
                /*0x48*/ System.Xml.XmlAttribute[] moreAttributes;

                /*0x11c7b38*/ XmlSchemaAnnotated();
                /*0x11c7ae8*/ string get_Id();
                /*0x11c7af0*/ void set_Id(string value);
                /*0x11c7af8*/ System.Xml.Schema.XmlSchemaAnnotation get_Annotation();
                /*0x11c7b00*/ void set_Annotation(System.Xml.Schema.XmlSchemaAnnotation value);
                /*0x11c7b08*/ System.Xml.XmlAttribute[] get_UnhandledAttributes();
                /*0x11c7b10*/ void set_UnhandledAttributes(System.Xml.XmlAttribute[] value);
                /*0x11c7b18*/ string get_IdAttribute();
                /*0x11c7b20*/ void set_IdAttribute(string value);
                /*0x11c7b28*/ void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes);
                /*0x11c7b30*/ void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
            }

            class XmlSchemaAnnotation : System.Xml.Schema.XmlSchemaObject
            {
                /*0x38*/ string id;
                /*0x40*/ System.Xml.Schema.XmlSchemaObjectCollection items;
                /*0x48*/ System.Xml.XmlAttribute[] moreAttributes;

                /*0x11c7b70*/ XmlSchemaAnnotation();
                /*0x11c7b40*/ string get_Id();
                /*0x11c7b48*/ void set_Id(string value);
                /*0x11c7b50*/ System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                /*0x11c7b58*/ string get_IdAttribute();
                /*0x11c7b60*/ void set_IdAttribute(string value);
                /*0x11c7b68*/ void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes);
            }

            class XmlSchemaAny : System.Xml.Schema.XmlSchemaParticle
            {
                /*0x78*/ string ns;
                /*0x80*/ System.Xml.Schema.XmlSchemaContentProcessing processContents;
                /*0x88*/ System.Xml.Schema.NamespaceList namespaceList;

                /*0x11c82c8*/ XmlSchemaAny();
                /*0x11c7bd8*/ string get_Namespace();
                /*0x11c7be0*/ void set_Namespace(string value);
                /*0x11c7be8*/ void set_ProcessContents(System.Xml.Schema.XmlSchemaContentProcessing value);
                /*0x11c7bf0*/ System.Xml.Schema.NamespaceList get_NamespaceList();
                /*0x11c7bf8*/ string get_ResolvedNamespace();
                /*0x11c7c50*/ System.Xml.Schema.XmlSchemaContentProcessing get_ProcessContentsCorrect();
                /*0x11c7c64*/ string get_NameString();
                /*0x11c8160*/ void BuildNamespaceList(string targetNamespace);
                /*0x11c81f4*/ void BuildNamespaceListV1Compat(string targetNamespace);
                /*0x11c82a0*/ bool Allows(System.Xml.XmlQualifiedName qname);
            }

            class XmlSchemaAnyAttribute : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ string ns;
                /*0x58*/ System.Xml.Schema.XmlSchemaContentProcessing processContents;
                /*0x60*/ System.Xml.Schema.NamespaceList namespaceList;

                static /*0x11c84bc*/ bool IsSubset(System.Xml.Schema.XmlSchemaAnyAttribute sub, System.Xml.Schema.XmlSchemaAnyAttribute super);
                static /*0x11c84e0*/ System.Xml.Schema.XmlSchemaAnyAttribute Intersection(System.Xml.Schema.XmlSchemaAnyAttribute o1, System.Xml.Schema.XmlSchemaAnyAttribute o2, bool v1Compat);
                static /*0x11c8598*/ System.Xml.Schema.XmlSchemaAnyAttribute Union(System.Xml.Schema.XmlSchemaAnyAttribute o1, System.Xml.Schema.XmlSchemaAnyAttribute o2, bool v1Compat);
                /*0x11c8590*/ XmlSchemaAnyAttribute();
                /*0x11c8320*/ void set_Namespace(string value);
                /*0x11c8328*/ System.Xml.Schema.XmlSchemaContentProcessing get_ProcessContents();
                /*0x11c8330*/ void set_ProcessContents(System.Xml.Schema.XmlSchemaContentProcessing value);
                /*0x11c8338*/ System.Xml.Schema.NamespaceList get_NamespaceList();
                /*0x11c8340*/ System.Xml.Schema.XmlSchemaContentProcessing get_ProcessContentsCorrect();
                /*0x11c8354*/ void BuildNamespaceList(string targetNamespace);
                /*0x11c83e8*/ void BuildNamespaceListV1Compat(string targetNamespace);
                /*0x11c8494*/ bool Allows(System.Xml.XmlQualifiedName qname);
            }

            class XmlSchemaAppInfo : System.Xml.Schema.XmlSchemaObject
            {
                /*0x38*/ string source;
                /*0x40*/ System.Xml.XmlNode[] markup;

                /*0x11c8660*/ XmlSchemaAppInfo();
                /*0x11c8648*/ void set_Source(string value);
                /*0x11c8650*/ System.Xml.XmlNode[] get_Markup();
                /*0x11c8658*/ void set_Markup(System.Xml.XmlNode[] value);
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

                /*0x11c8930*/ XmlSchemaAttribute();
                /*0x11c8668*/ string get_DefaultValue();
                /*0x11c8670*/ void set_DefaultValue(string value);
                /*0x11c8678*/ string get_FixedValue();
                /*0x11c8680*/ void set_FixedValue(string value);
                /*0x11c8688*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0x11c8690*/ void set_Form(System.Xml.Schema.XmlSchemaForm value);
                /*0x11c8698*/ string get_Name();
                /*0x11c86a0*/ void set_Name(string value);
                /*0x11c86a8*/ System.Xml.XmlQualifiedName get_RefName();
                /*0x11c86b0*/ void set_RefName(System.Xml.XmlQualifiedName value);
                /*0x11c8748*/ System.Xml.XmlQualifiedName get_SchemaTypeName();
                /*0x11c8750*/ void set_SchemaTypeName(System.Xml.XmlQualifiedName value);
                /*0x11c87e8*/ System.Xml.Schema.XmlSchemaSimpleType get_SchemaType();
                /*0x11c87f0*/ void set_SchemaType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0x11c87f8*/ System.Xml.Schema.XmlSchemaUse get_Use();
                /*0x11c8800*/ void set_Use(System.Xml.Schema.XmlSchemaUse value);
                /*0x11c8808*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0x11c8810*/ System.Xml.Schema.XmlSchemaSimpleType get_AttributeSchemaType();
                /*0x11c8818*/ System.Xml.Schema.XmlSchemaDatatype get_Datatype();
                /*0x11c8830*/ void SetQualifiedName(System.Xml.XmlQualifiedName value);
                /*0x11c8838*/ void SetAttributeType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0x11c8840*/ System.Xml.Schema.SchemaAttDef get_AttDef();
                /*0x11c8848*/ void set_AttDef(System.Xml.Schema.SchemaAttDef value);
                /*0x11c8850*/ string get_NameAttribute();
                /*0x11c8858*/ void set_NameAttribute(string value);
                /*0x11c8860*/ System.Xml.Schema.XmlSchemaObject Clone();
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

                /*0x11c8f08*/ XmlSchemaAttributeGroup();
                /*0x11c899c*/ string get_Name();
                /*0x11c89a4*/ void set_Name(string value);
                /*0x11c89ac*/ System.Xml.Schema.XmlSchemaObjectCollection get_Attributes();
                /*0x11c89b4*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0x11c89bc*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x11c89c4*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0x11c89cc*/ System.Xml.Schema.XmlSchemaObjectTable get_AttributeUses();
                /*0x11c8a38*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AttributeWildcard();
                /*0x11c8a40*/ void set_AttributeWildcard(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x11c8a48*/ System.Xml.Schema.XmlSchemaAttributeGroup get_RedefinedAttributeGroup();
                /*0x11c8a50*/ System.Xml.Schema.XmlSchemaAttributeGroup get_Redefined();
                /*0x11c8a58*/ void set_Redefined(System.Xml.Schema.XmlSchemaAttributeGroup value);
                /*0x11c8a60*/ int get_SelfReferenceCount();
                /*0x11c8a68*/ void set_SelfReferenceCount(int value);
                /*0x11c8a70*/ string get_NameAttribute();
                /*0x11c8a78*/ void set_NameAttribute(string value);
                /*0x11c8a80*/ void SetQualifiedName(System.Xml.XmlQualifiedName value);
                /*0x11c8a88*/ System.Xml.Schema.XmlSchemaObject Clone();
            }

            class XmlSchemaAttributeGroupRef : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ System.Xml.XmlQualifiedName refName;

                /*0x11c9044*/ XmlSchemaAttributeGroupRef();
                /*0x11c8fa4*/ System.Xml.XmlQualifiedName get_RefName();
                /*0x11c8fac*/ void set_RefName(System.Xml.XmlQualifiedName value);
            }

            class XmlSchemaChoice : System.Xml.Schema.XmlSchemaGroupBase
            {
                /*0x78*/ System.Xml.Schema.XmlSchemaObjectCollection items;

                /*0x11c90c4*/ XmlSchemaChoice();
                /*0x11c90ac*/ System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                /*0x11c90b4*/ bool get_IsEmpty();
                /*0x11c90bc*/ void SetItems(System.Xml.Schema.XmlSchemaObjectCollection newItems);
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

                /*0x11c9128*/ XmlSchemaCollection(System.Xml.XmlNameTable nametable);
                /*0x11c924c*/ int get_Count();
                /*0x11c9270*/ System.Xml.XmlNameTable get_NameTable();
                /*0x11c9278*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0x11c9280*/ System.Xml.Schema.XmlSchema get_Item(string ns);
                /*0x11c9324*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x11c93cc*/ System.Xml.Schema.XmlSchemaCollectionEnumerator GetEnumerator();
                /*0x11c9430*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x11c96c4*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x11c96cc*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x11c96d0*/ int System.Collections.ICollection.get_Count();
                /*0x11c4570*/ System.Xml.Schema.SchemaInfo GetSchemaInfo(string ns);
                /*0x11c96f4*/ System.Xml.Schema.SchemaNames GetSchemaNames(System.Xml.XmlNameTable nt);
                /*0x11c2c00*/ System.Xml.Schema.XmlSchema Add(string ns, System.Xml.Schema.SchemaInfo schemaInfo, System.Xml.Schema.XmlSchema schema, bool compile);
                /*0x11c979c*/ System.Xml.Schema.XmlSchema Add(string ns, System.Xml.Schema.SchemaInfo schemaInfo, System.Xml.Schema.XmlSchema schema, bool compile, System.Xml.XmlResolver resolver);
                /*0x11c98ec*/ void Add(string ns, System.Xml.Schema.XmlSchemaCollectionNode node);
                /*0x11c9a28*/ System.Xml.Schema.ValidationEventHandler get_EventHandler();
                /*0x11c9a30*/ void set_EventHandler(System.Xml.Schema.ValidationEventHandler value);
            }

            class XmlSchemaCollectionNode
            {
                /*0x10*/ string namespaceUri;
                /*0x18*/ System.Xml.Schema.SchemaInfo schemaInfo;
                /*0x20*/ System.Xml.Schema.XmlSchema schema;

                /*0x11c98e4*/ XmlSchemaCollectionNode();
                /*0x11c9a38*/ void set_NamespaceURI(string value);
                /*0x11c9a40*/ System.Xml.Schema.SchemaInfo get_SchemaInfo();
                /*0x11c9a48*/ void set_SchemaInfo(System.Xml.Schema.SchemaInfo value);
                /*0x11c9a50*/ System.Xml.Schema.XmlSchema get_Schema();
                /*0x11c9a58*/ void set_Schema(System.Xml.Schema.XmlSchema value);
            }

            class XmlSchemaCollectionEnumerator : System.Collections.IEnumerator
            {
                /*0x10*/ System.Collections.IDictionaryEnumerator enumerator;

                /*0x11c9388*/ XmlSchemaCollectionEnumerator(System.Collections.Hashtable collection);
                /*0x11c9a60*/ void System.Collections.IEnumerator.Reset();
                /*0x11c9b04*/ bool System.Collections.IEnumerator.MoveNext();
                /*0x11c9624*/ bool MoveNext();
                /*0x11c9ba4*/ object System.Collections.IEnumerator.get_Current();
                /*0x11c954c*/ System.Xml.Schema.XmlSchema get_Current();
                /*0x11c9ba8*/ System.Xml.Schema.XmlSchemaCollectionNode get_CurrentNode();
            }

            class XmlSchemaCompilationSettings
            {
                /*0x10*/ bool enableUpaCheck;

                /*0x11c9c7c*/ XmlSchemaCompilationSettings();
                /*0x11c9c9c*/ bool get_EnableUpaCheck();
            }

            class XmlSchemaComplexContent : System.Xml.Schema.XmlSchemaContentModel
            {
                /*0x50*/ System.Xml.Schema.XmlSchemaContent content;
                /*0x58*/ bool isMixed;
                /*0x59*/ bool hasMixedAttribute;

                /*0x11c9cd8*/ XmlSchemaComplexContent();
                /*0x11c9ca4*/ bool get_IsMixed();
                /*0x11c9cac*/ void set_IsMixed(bool value);
                /*0x11c9cc0*/ System.Xml.Schema.XmlSchemaContent get_Content();
                /*0x11c9cc8*/ void set_Content(System.Xml.Schema.XmlSchemaContent value);
                /*0x11c9cd0*/ bool get_HasMixedAttribute();
            }

            class XmlSchemaComplexContentExtension : System.Xml.Schema.XmlSchemaContent
            {
                /*0x50*/ System.Xml.Schema.XmlSchemaParticle particle;
                /*0x58*/ System.Xml.Schema.XmlSchemaObjectCollection attributes;
                /*0x60*/ System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;
                /*0x68*/ System.Xml.XmlQualifiedName baseTypeName;

                /*0x11c9db8*/ XmlSchemaComplexContentExtension();
                /*0x11c9ce8*/ System.Xml.XmlQualifiedName get_BaseTypeName();
                /*0x11c9cf0*/ void set_BaseTypeName(System.Xml.XmlQualifiedName value);
                /*0x11c9d88*/ System.Xml.Schema.XmlSchemaParticle get_Particle();
                /*0x11c9d90*/ void set_Particle(System.Xml.Schema.XmlSchemaParticle value);
                /*0x11c9d98*/ System.Xml.Schema.XmlSchemaObjectCollection get_Attributes();
                /*0x11c9da0*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0x11c9da8*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x11c9db0*/ void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes);
            }

            class XmlSchemaComplexContentRestriction : System.Xml.Schema.XmlSchemaContent
            {
                /*0x50*/ System.Xml.Schema.XmlSchemaParticle particle;
                /*0x58*/ System.Xml.Schema.XmlSchemaObjectCollection attributes;
                /*0x60*/ System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;
                /*0x68*/ System.Xml.XmlQualifiedName baseTypeName;

                /*0x11c9f2c*/ XmlSchemaComplexContentRestriction();
                /*0x11c9e5c*/ System.Xml.XmlQualifiedName get_BaseTypeName();
                /*0x11c9e64*/ void set_BaseTypeName(System.Xml.XmlQualifiedName value);
                /*0x11c9efc*/ System.Xml.Schema.XmlSchemaParticle get_Particle();
                /*0x11c9f04*/ void set_Particle(System.Xml.Schema.XmlSchemaParticle value);
                /*0x11c9f0c*/ System.Xml.Schema.XmlSchemaObjectCollection get_Attributes();
                /*0x11c9f14*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0x11c9f1c*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x11c9f24*/ void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes);
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

                static /*0x11c9fc8*/ XmlSchemaComplexType();
                static /*0x11ca190*/ System.Xml.Schema.XmlSchemaComplexType CreateAnyType(System.Xml.Schema.XmlSchemaContentProcessing processContents);
                static /*0x11ca580*/ System.Xml.Schema.XmlSchemaComplexType get_AnyType();
                static /*0x11ca5d8*/ System.Xml.Schema.XmlSchemaComplexType get_UntypedAnyType();
                static /*0x11ca510*/ System.Xml.Schema.ContentValidator get_AnyTypeContentValidator();
                static /*0x11c8cd8*/ System.Xml.Schema.XmlSchemaObjectCollection CloneAttributes(System.Xml.Schema.XmlSchemaObjectCollection attributes);
                static /*0x11cb21c*/ System.Xml.Schema.XmlSchemaObjectCollection CloneGroupBaseParticles(System.Xml.Schema.XmlSchemaObjectCollection groupBaseParticles, System.Xml.Schema.XmlSchema parentSchema);
                static /*0x11cae88*/ System.Xml.Schema.XmlSchemaParticle CloneParticle(System.Xml.Schema.XmlSchemaParticle particle, System.Xml.Schema.XmlSchema parentSchema);
                static /*0x11cb3f4*/ System.Xml.Schema.XmlSchemaForm GetResolvedElementForm(System.Xml.Schema.XmlSchema parentSchema, System.Xml.Schema.XmlSchemaElement element);
                static /*0x11cac0c*/ bool HasParticleRef(System.Xml.Schema.XmlSchemaParticle particle, System.Xml.Schema.XmlSchema parentSchema);
                static /*0x11c8b7c*/ bool HasAttributeQNameRef(System.Xml.Schema.XmlSchemaObjectCollection attributes);
                /*0x11ca4a0*/ XmlSchemaComplexType();
                /*0x11ca630*/ bool get_IsAbstract();
                /*0x11ca63c*/ void set_IsAbstract(bool value);
                /*0x11ca658*/ System.Xml.Schema.XmlSchemaDerivationMethod get_Block();
                /*0x11ca660*/ void set_Block(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x11ca668*/ bool get_IsMixed();
                /*0x11ca674*/ void set_IsMixed(bool value);
                /*0x11ca690*/ System.Xml.Schema.XmlSchemaContentModel get_ContentModel();
                /*0x11ca698*/ void set_ContentModel(System.Xml.Schema.XmlSchemaContentModel value);
                /*0x11ca6a0*/ System.Xml.Schema.XmlSchemaParticle get_Particle();
                /*0x11ca6a8*/ void set_Particle(System.Xml.Schema.XmlSchemaParticle value);
                /*0x11ca6b0*/ System.Xml.Schema.XmlSchemaObjectCollection get_Attributes();
                /*0x11ca71c*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0x11ca724*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x11ca72c*/ System.Xml.Schema.XmlSchemaContentType get_ContentType();
                /*0x11ca734*/ System.Xml.Schema.XmlSchemaParticle get_ContentTypeParticle();
                /*0x11ca73c*/ System.Xml.Schema.XmlSchemaDerivationMethod get_BlockResolved();
                /*0x11ca744*/ System.Xml.Schema.XmlSchemaObjectTable get_AttributeUses();
                /*0x11ca7b0*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AttributeWildcard();
                /*0x11ca7b8*/ System.Xml.Schema.XmlSchemaObjectTable get_LocalElements();
                /*0x11ca824*/ void SetContentTypeParticle(System.Xml.Schema.XmlSchemaParticle value);
                /*0x11ca82c*/ void SetBlockResolved(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x11ca834*/ void SetAttributeWildcard(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0x11ca83c*/ void set_HasWildCard(bool value);
                /*0x11ca858*/ void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes);
                /*0x11ca860*/ bool ContainsIdAttribute(bool findAll);
                /*0x11cac04*/ System.Xml.Schema.XmlSchemaObject Clone();
                /*0x11c6c4c*/ System.Xml.Schema.XmlSchemaObject Clone(System.Xml.Schema.XmlSchema parentSchema);
                /*0x11cb12c*/ void ClearCompiledState();
            }

            class XmlSchemaContent : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x11c9e54*/ XmlSchemaContent();
            }

            class XmlSchemaContentModel : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x11c9ce0*/ XmlSchemaContentModel();
                System.Xml.Schema.XmlSchemaContent get_Content();
                void set_Content(System.Xml.Schema.XmlSchemaContent value);
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
                static /*0x11cba08*/ string ConcatenatedToString(object value);
                static /*0x11be4d4*/ System.Xml.Schema.XmlSchemaDatatype FromXmlTokenizedType(System.Xml.XmlTokenizedType token);
                static /*0x11cc0dc*/ System.Xml.Schema.XmlSchemaDatatype FromXmlTokenizedTypeXsd(System.Xml.XmlTokenizedType token);
                static /*0x11bcf00*/ System.Xml.Schema.XmlSchemaDatatype FromXdrName(string name);
                static /*0x11cc134*/ System.Xml.Schema.XmlSchemaDatatype DeriveByUnion(System.Xml.Schema.XmlSchemaSimpleType[] types, System.Xml.Schema.XmlSchemaType schemaType);
                static /*0x11baa6c*/ string XdrCanonizeUri(string uri, System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames);
                /*0x11cc19c*/ XmlSchemaDatatype();
                System.Type get_ValueType();
                System.Xml.XmlTokenizedType get_TokenizedType();
                object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr);
                /*0x11cb41c*/ System.Xml.Schema.XmlSchemaDatatypeVariety get_Variety();
                /*0x11cb424*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0x11cb42c*/ bool IsDerivedFrom(System.Xml.Schema.XmlSchemaDatatype datatype);
                bool get_HasLexicalFacets();
                bool get_HasValueFacets();
                System.Xml.Schema.XmlValueConverter get_ValueConverter();
                System.Xml.Schema.RestrictionFacets get_Restriction();
                int Compare(object value1, object value2);
                object ParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, bool createAtomicValue);
                System.Exception TryParseValue(string s, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver nsmgr, ref object typedValue);
                System.Exception TryParseValue(object value, System.Xml.XmlNameTable nameTable, System.Xml.IXmlNamespaceResolver namespaceResolver, ref object typedValue);
                System.Xml.Schema.FacetsChecker get_FacetsChecker();
                System.Xml.Schema.XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();
                System.Xml.Schema.XmlSchemaDatatype DeriveByRestriction(System.Xml.Schema.XmlSchemaObjectCollection facets, System.Xml.XmlNameTable nameTable, System.Xml.Schema.XmlSchemaType schemaType);
                System.Xml.Schema.XmlSchemaDatatype DeriveByList(System.Xml.Schema.XmlSchemaType schemaType);
                void VerifySchemaValid(System.Xml.Schema.XmlSchemaObjectTable notations, System.Xml.Schema.XmlSchemaObject caller);
                bool IsEqual(object o1, object o2);
                bool IsComparable(System.Xml.Schema.XmlSchemaDatatype dtype);
                /*0x11cb434*/ string get_TypeCodeString();
                /*0x11cb55c*/ string TypeCodeToString(System.Xml.Schema.XmlTypeCode typeCode);
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

                static /*0x11cc28c*/ XmlSchemaDocumentation();
                /*0x11cc284*/ XmlSchemaDocumentation();
                /*0x11cc1a4*/ void set_Source(string value);
                /*0x11cc1ac*/ void set_Language(string value);
                /*0x11cc27c*/ void set_Markup(System.Xml.XmlNode[] value);
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

                /*0x11cc728*/ XmlSchemaElement();
                /*0x11cc364*/ bool get_IsAbstract();
                /*0x11cc36c*/ void set_IsAbstract(bool value);
                /*0x11cc380*/ System.Xml.Schema.XmlSchemaDerivationMethod get_Block();
                /*0x11cc388*/ void set_Block(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x11cc390*/ string get_DefaultValue();
                /*0x11cc398*/ void set_DefaultValue(string value);
                /*0x11cc3a0*/ System.Xml.Schema.XmlSchemaDerivationMethod get_Final();
                /*0x11cc3a8*/ void set_Final(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x11cc3b0*/ string get_FixedValue();
                /*0x11cc3b8*/ void set_FixedValue(string value);
                /*0x11cc3c0*/ System.Xml.Schema.XmlSchemaForm get_Form();
                /*0x11cc3c8*/ void set_Form(System.Xml.Schema.XmlSchemaForm value);
                /*0x11cc3d0*/ string get_Name();
                /*0x11cc3d8*/ void set_Name(string value);
                /*0x11cc3e0*/ bool get_IsNillable();
                /*0x11cc3e8*/ void set_IsNillable(bool value);
                /*0x11cc3fc*/ bool get_HasNillableAttribute();
                /*0x11cc404*/ bool get_HasAbstractAttribute();
                /*0x11cc40c*/ System.Xml.XmlQualifiedName get_RefName();
                /*0x11cc414*/ void set_RefName(System.Xml.XmlQualifiedName value);
                /*0x11cc4ac*/ System.Xml.XmlQualifiedName get_SubstitutionGroup();
                /*0x11cc4b4*/ void set_SubstitutionGroup(System.Xml.XmlQualifiedName value);
                /*0x11cc54c*/ System.Xml.XmlQualifiedName get_SchemaTypeName();
                /*0x11cc554*/ void set_SchemaTypeName(System.Xml.XmlQualifiedName value);
                /*0x11cc5ec*/ System.Xml.Schema.XmlSchemaType get_SchemaType();
                /*0x11cc5f4*/ void set_SchemaType(System.Xml.Schema.XmlSchemaType value);
                /*0x11cc5fc*/ System.Xml.Schema.XmlSchemaObjectCollection get_Constraints();
                /*0x11cc668*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0x11cc670*/ System.Xml.Schema.XmlSchemaType get_ElementSchemaType();
                /*0x11cc678*/ System.Xml.Schema.XmlSchemaDerivationMethod get_BlockResolved();
                /*0x11cc680*/ System.Xml.Schema.XmlSchemaDerivationMethod get_FinalResolved();
                /*0x11cc688*/ void SetQualifiedName(System.Xml.XmlQualifiedName value);
                /*0x11cc690*/ void SetElementType(System.Xml.Schema.XmlSchemaType value);
                /*0x11cc698*/ void SetBlockResolved(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x11cc6a0*/ void SetFinalResolved(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0x11cc6a8*/ bool get_HasConstraints();
                /*0x11cc6cc*/ bool get_IsLocalTypeDerivationChecked();
                /*0x11cc6d4*/ void set_IsLocalTypeDerivationChecked(bool value);
                /*0x11cc6e0*/ System.Xml.Schema.SchemaElementDecl get_ElementDecl();
                /*0x11cc6e8*/ void set_ElementDecl(System.Xml.Schema.SchemaElementDecl value);
                /*0x11cc6f0*/ string get_NameAttribute();
                /*0x11cc6f8*/ void set_NameAttribute(string value);
                /*0x11cc700*/ string get_NameString();
                /*0x11cc720*/ System.Xml.Schema.XmlSchemaObject Clone();
                /*0x11c72b8*/ System.Xml.Schema.XmlSchemaObject Clone(System.Xml.Schema.XmlSchema parentSchema);
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

                static /*0x11ccb7c*/ string CreateMessage(string res, string[] args);
                /*0x11cc7c4*/ XmlSchemaException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x11ccdb0*/ XmlSchemaException();
                /*0x11ccdc4*/ XmlSchemaException(string message);
                /*0x11ccef8*/ XmlSchemaException(string message, System.Exception innerException);
                /*0x11ccdd4*/ XmlSchemaException(string message, System.Exception innerException, int lineNumber, int linePosition);
                /*0x11ccf8c*/ XmlSchemaException(string res, string[] args);
                /*0x11c4ad0*/ XmlSchemaException(string res, string arg);
                /*0x11bfee0*/ XmlSchemaException(string res, string arg, string sourceUri, int lineNumber, int linePosition);
                /*0x11ccfe4*/ XmlSchemaException(string res, string sourceUri, int lineNumber, int linePosition);
                /*0x11bfd9c*/ XmlSchemaException(string res, string[] args, string sourceUri, int lineNumber, int linePosition);
                /*0x11cd050*/ XmlSchemaException(string res, System.Xml.Schema.XmlSchemaObject source);
                /*0x11cd0d4*/ XmlSchemaException(string res, string arg, System.Xml.Schema.XmlSchemaObject source);
                /*0x11cd05c*/ XmlSchemaException(string res, string[] args, System.Xml.Schema.XmlSchemaObject source);
                /*0x11ccf04*/ XmlSchemaException(string res, string[] args, System.Exception innerException, string sourceUri, int lineNumber, int linePosition, System.Xml.Schema.XmlSchemaObject source);
                /*0x11ccc40*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0x11cd18c*/ string get_GetRes();
                /*0x11cd194*/ string[] get_Args();
                /*0x11cd19c*/ string get_SourceUri();
                /*0x11cd1a4*/ int get_LineNumber();
                /*0x11cd1ac*/ int get_LinePosition();
                /*0x11cd1b4*/ System.Xml.Schema.XmlSchemaObject get_SourceSchemaObject();
                /*0x11c3f14*/ void SetSource(string sourceUri, int lineNumber, int linePosition);
                /*0x11cd1bc*/ void SetSchemaObject(System.Xml.Schema.XmlSchemaObject source);
                /*0x11cd1c4*/ void SetSource(System.Xml.Schema.XmlSchemaObject source);
                /*0x11cd1ec*/ string get_Message();
            }

            class XmlSchemaExternal : System.Xml.Schema.XmlSchemaObject
            {
                /*0x38*/ string location;
                /*0x40*/ System.Uri baseUri;
                /*0x48*/ System.Xml.Schema.XmlSchema schema;
                /*0x50*/ string id;
                /*0x58*/ System.Xml.XmlAttribute[] moreAttributes;
                /*0x60*/ System.Xml.Schema.Compositor compositor;

                /*0x11cd26c*/ XmlSchemaExternal();
                /*0x11cd204*/ string get_SchemaLocation();
                /*0x11cd20c*/ void set_SchemaLocation(string value);
                /*0x11cd214*/ System.Xml.Schema.XmlSchema get_Schema();
                /*0x11cd21c*/ void set_Schema(System.Xml.Schema.XmlSchema value);
                /*0x11cd224*/ string get_Id();
                /*0x11cd22c*/ void set_Id(string value);
                /*0x11cd234*/ System.Uri get_BaseUri();
                /*0x11cd23c*/ void set_BaseUri(System.Uri value);
                /*0x11cd244*/ string get_IdAttribute();
                /*0x11cd24c*/ void set_IdAttribute(string value);
                /*0x11cd254*/ void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes);
                /*0x11cd25c*/ System.Xml.Schema.Compositor get_Compositor();
                /*0x11cd264*/ void set_Compositor(System.Xml.Schema.Compositor value);
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

                /*0x11cd350*/ XmlSchemaFacet();
                /*0x11cd274*/ string get_Value();
                /*0x11cd27c*/ void set_Value(string value);
                /*0x11cd284*/ bool get_IsFixed();
                /*0x11cd28c*/ void set_IsFixed(bool value);
                /*0x11cd340*/ System.Xml.Schema.FacetType get_FacetType();
                /*0x11cd348*/ void set_FacetType(System.Xml.Schema.FacetType value);
            }

            class XmlSchemaNumericFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x11cd358*/ XmlSchemaNumericFacet();
            }

            class XmlSchemaLengthFacet : System.Xml.Schema.XmlSchemaNumericFacet
            {
                /*0x11cd360*/ XmlSchemaLengthFacet();
            }

            class XmlSchemaMinLengthFacet : System.Xml.Schema.XmlSchemaNumericFacet
            {
                /*0x11cd380*/ XmlSchemaMinLengthFacet();
            }

            class XmlSchemaMaxLengthFacet : System.Xml.Schema.XmlSchemaNumericFacet
            {
                /*0x11cd3a0*/ XmlSchemaMaxLengthFacet();
            }

            class XmlSchemaPatternFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x11cd3c0*/ XmlSchemaPatternFacet();
            }

            class XmlSchemaEnumerationFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x11cd3e0*/ XmlSchemaEnumerationFacet();
            }

            class XmlSchemaMinExclusiveFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x11cd400*/ XmlSchemaMinExclusiveFacet();
            }

            class XmlSchemaMinInclusiveFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x11cd420*/ XmlSchemaMinInclusiveFacet();
            }

            class XmlSchemaMaxExclusiveFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x11cd440*/ XmlSchemaMaxExclusiveFacet();
            }

            class XmlSchemaMaxInclusiveFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x11cd460*/ XmlSchemaMaxInclusiveFacet();
            }

            class XmlSchemaTotalDigitsFacet : System.Xml.Schema.XmlSchemaNumericFacet
            {
                /*0x11cd480*/ XmlSchemaTotalDigitsFacet();
            }

            class XmlSchemaFractionDigitsFacet : System.Xml.Schema.XmlSchemaNumericFacet
            {
                /*0x11cd4a0*/ XmlSchemaFractionDigitsFacet();
            }

            class XmlSchemaWhiteSpaceFacet : System.Xml.Schema.XmlSchemaFacet
            {
                /*0x11cd4c0*/ XmlSchemaWhiteSpaceFacet();
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

                /*0x11cd558*/ XmlSchemaGroup();
                /*0x11cd4e0*/ string get_Name();
                /*0x11cd4e8*/ void set_Name(string value);
                /*0x11cd4f0*/ System.Xml.Schema.XmlSchemaGroupBase get_Particle();
                /*0x11cd4f8*/ void set_Particle(System.Xml.Schema.XmlSchemaGroupBase value);
                /*0x11cd500*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0x11cd508*/ System.Xml.Schema.XmlSchemaParticle get_CanonicalParticle();
                /*0x11cd510*/ void set_CanonicalParticle(System.Xml.Schema.XmlSchemaParticle value);
                /*0x11cd518*/ System.Xml.Schema.XmlSchemaGroup get_Redefined();
                /*0x11cd520*/ void set_Redefined(System.Xml.Schema.XmlSchemaGroup value);
                /*0x11cd528*/ int get_SelfReferenceCount();
                /*0x11cd530*/ void set_SelfReferenceCount(int value);
                /*0x11cd538*/ string get_NameAttribute();
                /*0x11cd540*/ void set_NameAttribute(string value);
                /*0x11cd548*/ void SetQualifiedName(System.Xml.XmlQualifiedName value);
                /*0x11cd550*/ System.Xml.Schema.XmlSchemaObject Clone();
                /*0x11c7484*/ System.Xml.Schema.XmlSchemaObject Clone(System.Xml.Schema.XmlSchema parentSchema);
            }

            class XmlSchemaGroupBase : System.Xml.Schema.XmlSchemaParticle
            {
                /*0x11c7a90*/ XmlSchemaGroupBase();
                System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                void SetItems(System.Xml.Schema.XmlSchemaObjectCollection newItems);
            }

            class XmlSchemaGroupRef : System.Xml.Schema.XmlSchemaParticle
            {
                /*0x78*/ System.Xml.XmlQualifiedName refName;
                /*0x80*/ System.Xml.Schema.XmlSchemaGroupBase particle;
                /*0x88*/ System.Xml.Schema.XmlSchemaGroup refined;

                /*0x11cd5e8*/ XmlSchemaGroupRef();
                /*0x11cd5c0*/ System.Xml.XmlQualifiedName get_RefName();
                /*0x11cb35c*/ void set_RefName(System.Xml.XmlQualifiedName value);
                /*0x11cd5c8*/ System.Xml.Schema.XmlSchemaGroupBase get_Particle();
                /*0x11cd5d0*/ void SetParticle(System.Xml.Schema.XmlSchemaGroupBase value);
                /*0x11cd5d8*/ System.Xml.Schema.XmlSchemaGroup get_Redefined();
                /*0x11cd5e0*/ void set_Redefined(System.Xml.Schema.XmlSchemaGroup value);
            }

            class XmlSchemaIdentityConstraint : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ string name;
                /*0x58*/ System.Xml.Schema.XmlSchemaXPath selector;
                /*0x60*/ System.Xml.Schema.XmlSchemaObjectCollection fields;
                /*0x68*/ System.Xml.XmlQualifiedName qualifiedName;
                /*0x70*/ System.Xml.Schema.CompiledIdentityConstraint compiledConstraint;

                /*0x11cd6cc*/ XmlSchemaIdentityConstraint();
                /*0x11cd674*/ string get_Name();
                /*0x11cd67c*/ void set_Name(string value);
                /*0x11cd684*/ System.Xml.Schema.XmlSchemaXPath get_Selector();
                /*0x11cd68c*/ void set_Selector(System.Xml.Schema.XmlSchemaXPath value);
                /*0x11cd694*/ System.Xml.Schema.XmlSchemaObjectCollection get_Fields();
                /*0x11cd69c*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0x11cd6a4*/ void SetQualifiedName(System.Xml.XmlQualifiedName value);
                /*0x11cd6ac*/ System.Xml.Schema.CompiledIdentityConstraint get_CompiledConstraint();
                /*0x11cd6b4*/ void set_CompiledConstraint(System.Xml.Schema.CompiledIdentityConstraint value);
                /*0x11cd6bc*/ string get_NameAttribute();
                /*0x11cd6c4*/ void set_NameAttribute(string value);
            }

            class XmlSchemaXPath : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ string xpath;

                /*0x11cd778*/ XmlSchemaXPath();
                /*0x11cd768*/ string get_XPath();
                /*0x11cd770*/ void set_XPath(string value);
            }

            class XmlSchemaUnique : System.Xml.Schema.XmlSchemaIdentityConstraint
            {
                /*0x11cd780*/ XmlSchemaUnique();
            }

            class XmlSchemaKey : System.Xml.Schema.XmlSchemaIdentityConstraint
            {
                /*0x11cd784*/ XmlSchemaKey();
            }

            class XmlSchemaKeyref : System.Xml.Schema.XmlSchemaIdentityConstraint
            {
                /*0x78*/ System.Xml.XmlQualifiedName refer;

                /*0x11cd828*/ XmlSchemaKeyref();
                /*0x11cd788*/ System.Xml.XmlQualifiedName get_Refer();
                /*0x11cd790*/ void set_Refer(System.Xml.XmlQualifiedName value);
            }

            class XmlSchemaImport : System.Xml.Schema.XmlSchemaExternal
            {
                /*0x68*/ string ns;
                /*0x70*/ System.Xml.Schema.XmlSchemaAnnotation annotation;

                /*0x11cd88c*/ XmlSchemaImport();
                /*0x11cd8ac*/ string get_Namespace();
                /*0x11cd8b4*/ void set_Namespace(string value);
                /*0x11cd8bc*/ void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
            }

            class XmlSchemaInclude : System.Xml.Schema.XmlSchemaExternal
            {
                /*0x68*/ System.Xml.Schema.XmlSchemaAnnotation annotation;

                /*0x11cd8c4*/ XmlSchemaInclude();
                /*0x11cd8e4*/ void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
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

                /*0x11cd8ec*/ XmlSchemaInfo();
                /*0x11cd938*/ XmlSchemaInfo(System.Xml.Schema.XmlSchemaValidity validity);
                /*0x11cd974*/ System.Xml.Schema.XmlSchemaValidity get_Validity();
                /*0x11cd97c*/ void set_Validity(System.Xml.Schema.XmlSchemaValidity value);
                /*0x11cd984*/ bool get_IsDefault();
                /*0x11cd98c*/ void set_IsDefault(bool value);
                /*0x11cd998*/ bool get_IsNil();
                /*0x11cd9a0*/ void set_IsNil(bool value);
                /*0x11cd9ac*/ System.Xml.Schema.XmlSchemaSimpleType get_MemberType();
                /*0x11cd9b4*/ void set_MemberType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0x11cd9bc*/ System.Xml.Schema.XmlSchemaType get_SchemaType();
                /*0x11cd9c4*/ void set_SchemaType(System.Xml.Schema.XmlSchemaType value);
                /*0x11cd9e0*/ System.Xml.Schema.XmlSchemaElement get_SchemaElement();
                /*0x11cd9e8*/ void set_SchemaElement(System.Xml.Schema.XmlSchemaElement value);
                /*0x11cd9f8*/ System.Xml.Schema.XmlSchemaAttribute get_SchemaAttribute();
                /*0x11cda00*/ void set_SchemaAttribute(System.Xml.Schema.XmlSchemaAttribute value);
                /*0x11cda10*/ System.Xml.Schema.XmlSchemaContentType get_ContentType();
                /*0x11cda18*/ System.Xml.Schema.XmlSchemaType get_XmlType();
                /*0x11cda34*/ bool get_HasDefaultValue();
                /*0x11cda68*/ bool get_IsUnionType();
                /*0x11cd91c*/ void Clear();
            }

            class XmlSchemaNotation : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0x50*/ string name;
                /*0x58*/ string publicId;
                /*0x60*/ string systemId;
                /*0x68*/ System.Xml.XmlQualifiedName qname;

                /*0x11cdaf0*/ XmlSchemaNotation();
                /*0x11cdaa0*/ string get_Name();
                /*0x11cdaa8*/ void set_Name(string value);
                /*0x11cdab0*/ string get_Public();
                /*0x11cdab8*/ void set_Public(string value);
                /*0x11cdac0*/ string get_System();
                /*0x11cdac8*/ void set_System(string value);
                /*0x11cdad0*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0x11cdad8*/ void set_QualifiedName(System.Xml.XmlQualifiedName value);
                /*0x11cdae0*/ string get_NameAttribute();
                /*0x11cdae8*/ void set_NameAttribute(string value);
            }

            class XmlSchemaObject
            {
                /*0x10*/ int lineNum;
                /*0x14*/ int linePos;
                /*0x18*/ string sourceUri;
                /*0x20*/ System.Xml.Serialization.XmlSerializerNamespaces namespaces;
                /*0x28*/ System.Xml.Schema.XmlSchemaObject parent;
                /*0x30*/ bool isProcessing;

                /*0x11c6068*/ XmlSchemaObject();
                /*0x11cdb58*/ int get_LineNumber();
                /*0x11cdb60*/ void set_LineNumber(int value);
                /*0x11cdb68*/ int get_LinePosition();
                /*0x11cdb70*/ void set_LinePosition(int value);
                /*0x11cdb78*/ string get_SourceUri();
                /*0x11cdb80*/ void set_SourceUri(string value);
                /*0x11cdb88*/ System.Xml.Schema.XmlSchemaObject get_Parent();
                /*0x11cdb90*/ void set_Parent(System.Xml.Schema.XmlSchemaObject value);
                /*0x11c68e0*/ System.Xml.Serialization.XmlSerializerNamespaces get_Namespaces();
                /*0x11cdb98*/ void set_Namespaces(System.Xml.Serialization.XmlSerializerNamespaces value);
                /*0x11cdba0*/ void OnAdd(System.Xml.Schema.XmlSchemaObjectCollection container, object item);
                /*0x11cdba4*/ void OnRemove(System.Xml.Schema.XmlSchemaObjectCollection container, object item);
                /*0x11cdba8*/ void OnClear(System.Xml.Schema.XmlSchemaObjectCollection container);
                /*0x11cdbac*/ string get_IdAttribute();
                /*0x11cdbb4*/ void set_IdAttribute(string value);
                /*0x11cdbb8*/ void SetUnhandledAttributes(System.Xml.XmlAttribute[] moreAttributes);
                /*0x11cdbbc*/ void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
                /*0x11cdbc0*/ string get_NameAttribute();
                /*0x11cdbc8*/ void set_NameAttribute(string value);
                /*0x11cdbcc*/ bool get_IsProcessing();
                /*0x11cdbd4*/ void set_IsProcessing(bool value);
                /*0x11cdbe0*/ System.Xml.Schema.XmlSchemaObject Clone();
            }

            class XmlSchemaObjectCollection : System.Collections.CollectionBase
            {
                /*0x18*/ System.Xml.Schema.XmlSchemaObject parent;

                /*0x11c6060*/ XmlSchemaObjectCollection();
                /*0x11cdc60*/ System.Xml.Schema.XmlSchemaObject get_Item(int index);
                /*0x11cdd60*/ void set_Item(int index, System.Xml.Schema.XmlSchemaObject value);
                /*0x11cde28*/ System.Xml.Schema.XmlSchemaObjectEnumerator GetEnumerator();
                /*0x11c7604*/ int Add(System.Xml.Schema.XmlSchemaObject item);
                /*0x11cdeac*/ void Insert(int index, System.Xml.Schema.XmlSchemaObject item);
                /*0x11cdf74*/ void Remove(System.Xml.Schema.XmlSchemaObject item);
                /*0x11ce02c*/ void OnInsert(int index, object item);
                /*0x11ce048*/ void OnSet(int index, object oldValue, object newValue);
                /*0x11ce0a4*/ void OnClear();
                /*0x11ce0c0*/ void OnRemove(int index, object item);
                /*0x11cb19c*/ System.Xml.Schema.XmlSchemaObjectCollection Clone();
                /*0x11ce0dc*/ void Add(System.Xml.Schema.XmlSchemaObjectCollection collToAdd);
            }

            class XmlSchemaObjectEnumerator : System.Collections.IEnumerator
            {
                /*0x10*/ System.Collections.IEnumerator enumerator;

                /*0xfbb7b0*/ XmlSchemaObjectEnumerator(System.Collections.IEnumerator enumerator);
                /*0xfbb7d8*/ bool MoveNext();
                /*0xfbb878*/ System.Xml.Schema.XmlSchemaObject get_Current();
                /*0xfbb968*/ void System.Collections.IEnumerator.Reset();
                /*0xfbba0c*/ bool System.Collections.IEnumerator.MoveNext();
                /*0xfbbaac*/ object System.Collections.IEnumerator.get_Current();
            }

            class XmlSchemaObjectTable
            {
                /*0x10*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Xml.Schema.XmlSchemaObject> table;
                /*0x18*/ System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries;

                /*0xfbbb50*/ XmlSchemaObjectTable();
                /*0xfbbc10*/ void Add(System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaObject value);
                /*0xfbbd00*/ void Insert(System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaObject value);
                /*0xfbbe90*/ void Replace(System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaObject value);
                /*0xfbbf70*/ void Clear();
                /*0xfbc004*/ void Remove(System.Xml.XmlQualifiedName name);
                /*0xfbbdf4*/ int FindIndexByValue(System.Xml.Schema.XmlSchemaObject xso);
                /*0xfbc0d4*/ int get_Count();
                /*0xfbc124*/ bool Contains(System.Xml.XmlQualifiedName name);
                /*0xfbc17c*/ System.Xml.Schema.XmlSchemaObject get_Item(System.Xml.XmlQualifiedName name);
                /*0xfbc1f4*/ System.Collections.ICollection get_Values();
                /*0xfbc2bc*/ System.Collections.IDictionaryEnumerator GetEnumerator();

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

                    /*0xfbbcf8*/ XmlSchemaObjectEntry(System.Xml.XmlQualifiedName name, System.Xml.Schema.XmlSchemaObject value);
                }

                class ValuesCollection : System.Collections.ICollection, System.Collections.IEnumerable
                {
                    /*0x10*/ System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries;
                    /*0x18*/ int size;

                    /*0xfbc28c*/ ValuesCollection(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size);
                    /*0xfbc3a4*/ int get_Count();
                    /*0xfbc3ac*/ object get_SyncRoot();
                    /*0xfbc450*/ bool get_IsSynchronized();
                    /*0xfbc4f4*/ void CopyTo(System.Array array, int arrayIndex);
                    /*0xfbc624*/ System.Collections.IEnumerator GetEnumerator();
                }

                class XSOEnumerator : System.Collections.IEnumerator
                {
                    /*0x10*/ System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries;
                    /*0x18*/ System.Xml.Schema.XmlSchemaObjectTable.EnumeratorType enumType;
                    /*0x1c*/ int currentIndex;
                    /*0x20*/ int size;
                    /*0x28*/ System.Xml.XmlQualifiedName currentKey;
                    /*0x30*/ System.Xml.Schema.XmlSchemaObject currentValue;

                    /*0xfbc6a8*/ XSOEnumerator(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, System.Xml.Schema.XmlSchemaObjectTable.EnumeratorType enumType);
                    /*0xfbc6ec*/ object get_Current();
                    /*0xfbc8ac*/ bool MoveNext();
                    /*0xfbc944*/ void Reset();
                }

                class XSODictionaryEnumerator : System.Xml.Schema.XmlSchemaObjectTable.XSOEnumerator, System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator
                {
                    /*0xfbc360*/ XSODictionaryEnumerator(System.Collections.Generic.List<System.Xml.Schema.XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, System.Xml.Schema.XmlSchemaObjectTable.EnumeratorType enumType);
                    /*0xfbc954*/ System.Collections.DictionaryEntry get_Entry();
                    /*0xfbcaa8*/ object get_Key();
                    /*0xfbcbe0*/ object get_Value();
                }
            }

            class XmlSchemaParticle : System.Xml.Schema.XmlSchemaAnnotated
            {
                static /*0x0*/ System.Xml.Schema.XmlSchemaParticle Empty;
                /*0x50*/ decimal minOccurs;
                /*0x60*/ decimal maxOccurs;
                /*0x70*/ System.Xml.Schema.XmlSchemaParticle.Occurs flags;

                static /*0xfbd788*/ XmlSchemaParticle();
                /*0xfbd714*/ XmlSchemaParticle();
                /*0xfbcd18*/ string get_MinOccursString();
                /*0xfbcd90*/ void set_MinOccursString(string value);
                /*0xfbcee8*/ string get_MaxOccursString();
                /*0xfbd00c*/ void set_MaxOccursString(string value);
                /*0xfbd224*/ decimal get_MinOccurs();
                /*0xfbd230*/ void set_MinOccurs(decimal value);
                /*0xfbd360*/ decimal get_MaxOccurs();
                /*0xfbd36c*/ void set_MaxOccurs(decimal value);
                /*0xfbd4d4*/ bool get_IsEmpty();
                /*0xfbd540*/ string get_NameString();
                /*0xfbd588*/ System.Xml.XmlQualifiedName GetQualifiedName();

                enum Occurs
                {
                    None = 0,
                    Min = 1,
                    Max = 2,
                }

                class EmptyParticle : System.Xml.Schema.XmlSchemaParticle
                {
                    /*0xfbd7fc*/ EmptyParticle();
                    /*0xfbd850*/ bool get_IsEmpty();
                }
            }

            class XmlSchemaRedefine : System.Xml.Schema.XmlSchemaExternal
            {
                /*0x68*/ System.Xml.Schema.XmlSchemaObjectCollection items;
                /*0x70*/ System.Xml.Schema.XmlSchemaObjectTable attributeGroups;
                /*0x78*/ System.Xml.Schema.XmlSchemaObjectTable types;
                /*0x80*/ System.Xml.Schema.XmlSchemaObjectTable groups;

                /*0xfbd858*/ XmlSchemaRedefine();
                /*0xfbd928*/ System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                /*0xfbd930*/ System.Xml.Schema.XmlSchemaObjectTable get_AttributeGroups();
                /*0xfbd938*/ System.Xml.Schema.XmlSchemaObjectTable get_SchemaTypes();
                /*0xfbd940*/ System.Xml.Schema.XmlSchemaObjectTable get_Groups();
                /*0xfbd948*/ void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation annotation);
            }

            class XmlSchemaSequence : System.Xml.Schema.XmlSchemaGroupBase
            {
                /*0x78*/ System.Xml.Schema.XmlSchemaObjectCollection items;

                /*0xfbd9b0*/ XmlSchemaSequence();
                /*0xfbd964*/ System.Xml.Schema.XmlSchemaObjectCollection get_Items();
                /*0xfbd96c*/ bool get_IsEmpty();
                /*0xfbd9a8*/ void SetItems(System.Xml.Schema.XmlSchemaObjectCollection newItems);
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

                /*0xfbda90*/ XmlSchemaSet();
                /*0xfbdaf4*/ XmlSchemaSet(System.Xml.XmlNameTable nameTable);
                /*0xfbda18*/ object get_InternalSyncObject();
                /*0xfbdd80*/ void add_ValidationEventHandler(System.Xml.Schema.ValidationEventHandler value);
                /*0xfbde48*/ void remove_ValidationEventHandler(System.Xml.Schema.ValidationEventHandler value);
                /*0xfbdecc*/ bool get_IsCompiled();
                /*0xfbded4*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0xfbdef0*/ System.Xml.Schema.XmlSchemaCompilationSettings get_CompilationSettings();
                /*0xfbdef8*/ void set_CompilationSettings(System.Xml.Schema.XmlSchemaCompilationSettings value);
                /*0xfbdf00*/ int get_Count();
                /*0xfbdf24*/ System.Xml.Schema.XmlSchemaObjectTable get_GlobalElements();
                /*0xfbdf8c*/ System.Xml.Schema.XmlSchemaObjectTable get_GlobalAttributes();
                /*0xfbdff4*/ System.Xml.Schema.XmlSchemaObjectTable get_GlobalTypes();
                /*0xfbe05c*/ System.Xml.Schema.XmlSchemaObjectTable get_SubstitutionGroups();
                /*0xfbe0c4*/ System.Collections.Hashtable get_SchemaLocations();
                /*0xfbe0cc*/ System.Xml.Schema.XmlSchemaObjectTable get_TypeExtensions();
                /*0xfbe134*/ void Add(System.Xml.Schema.XmlSchemaSet schemas);
                /*0xfc080c*/ System.Xml.Schema.XmlSchema Add(System.Xml.Schema.XmlSchema schema);
                /*0xfc09b8*/ bool RemoveRecursive(System.Xml.Schema.XmlSchema schemaToRemove);
                /*0xfc1894*/ bool Contains(string targetNamespace);
                /*0xfc1910*/ void Compile();
                /*0xfc1e14*/ System.Xml.Schema.XmlSchema Reprocess(System.Xml.Schema.XmlSchema schema);
                /*0xfc37f8*/ void CopyTo(System.Xml.Schema.XmlSchema[] schemas, int index);
                /*0xfc3964*/ System.Collections.ICollection Schemas();
                /*0xfc35a0*/ System.Collections.ICollection Schemas(string targetNamespace);
                /*0xfc07b0*/ System.Xml.Schema.XmlSchema Add(string targetNamespace, System.Xml.Schema.XmlSchema schema);
                /*0xfc3cfc*/ void Add(string targetNamespace, System.Xml.XmlReader reader, System.Collections.Hashtable validatedNamespaces);
                /*0xfc053c*/ System.Xml.Schema.XmlSchema FindSchemaByNSAndUrl(System.Uri schemaUri, string ns, System.Collections.DictionaryEntry[] locationsTable);
                /*0xfc3988*/ void AddSchemaToSet(System.Xml.Schema.XmlSchema schema);
                /*0xfc44cc*/ void ProcessNewSubstitutionGroups(System.Xml.Schema.XmlSchemaObjectTable substitutionGroupsTable, bool resolve);
                /*0xfc49a4*/ void ResolveSubstitutionGroup(System.Xml.Schema.XmlSchemaSubstitutionGroup substitutionGroup, System.Xml.Schema.XmlSchemaObjectTable substTable);
                /*0xfc1518*/ System.Xml.Schema.XmlSchema Remove(System.Xml.Schema.XmlSchema schema, bool forceCompile);
                /*0xfc1db8*/ void ClearTables();
                /*0xfc3704*/ bool PreprocessSchema(ref System.Xml.Schema.XmlSchema schema, string targetNamespace);
                /*0xfc4360*/ System.Xml.Schema.XmlSchema ParseSchema(string targetNamespace, System.Xml.XmlReader reader);
                /*0xfbeab8*/ void CopyFromCompiledSet(System.Xml.Schema.XmlSchemaSet otherSet);
                /*0xfc51e8*/ System.Xml.Schema.SchemaInfo get_CompiledInfo();
                /*0xfc51f0*/ System.Xml.XmlReaderSettings get_ReaderSettings();
                /*0xfc51f8*/ System.Xml.XmlResolver GetResolver();
                /*0xfc5214*/ System.Xml.Schema.ValidationEventHandler GetEventHandler();
                /*0xfc5064*/ System.Xml.Schema.SchemaNames GetSchemaNames(System.Xml.XmlNameTable nt);
                /*0xfc40a4*/ bool IsSchemaLoaded(System.Uri schemaUri, string targetNamespace, ref System.Xml.Schema.XmlSchema schema);
                /*0xfc521c*/ bool GetSchemaByUri(System.Uri schemaUri, ref System.Xml.Schema.XmlSchema schema);
                /*0xfc1414*/ string GetTargetNamespace(System.Xml.Schema.XmlSchema schema);
                /*0xfc535c*/ System.Collections.SortedList get_SortedSchemas();
                /*0xfc2fa8*/ void RemoveSchemaFromCaches(System.Xml.Schema.XmlSchema schema);
                /*0xfc250c*/ void RemoveSchemaFromGlobalTables(System.Xml.Schema.XmlSchema schema);
                /*0xfc4d80*/ bool AddToTable(System.Xml.Schema.XmlSchemaObjectTable table, System.Xml.XmlQualifiedName qname, System.Xml.Schema.XmlSchemaObject item);
                /*0xfc510c*/ void VerifyTables();
                /*0xfc5364*/ void InternalValidationCallback(object sender, System.Xml.Schema.ValidationEventArgs e);
                /*0xfc1470*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity);
            }

            class XmlSchemaSimpleContent : System.Xml.Schema.XmlSchemaContentModel
            {
                /*0x50*/ System.Xml.Schema.XmlSchemaContent content;

                /*0xfc53b8*/ XmlSchemaSimpleContent();
                /*0xfc53a8*/ System.Xml.Schema.XmlSchemaContent get_Content();
                /*0xfc53b0*/ void set_Content(System.Xml.Schema.XmlSchemaContent value);
            }

            class XmlSchemaSimpleContentExtension : System.Xml.Schema.XmlSchemaContent
            {
                /*0x50*/ System.Xml.Schema.XmlSchemaObjectCollection attributes;
                /*0x58*/ System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;
                /*0x60*/ System.Xml.XmlQualifiedName baseTypeName;

                /*0xfc5480*/ XmlSchemaSimpleContentExtension();
                /*0xfc53c0*/ System.Xml.XmlQualifiedName get_BaseTypeName();
                /*0xfc53c8*/ void set_BaseTypeName(System.Xml.XmlQualifiedName value);
                /*0xfc5460*/ System.Xml.Schema.XmlSchemaObjectCollection get_Attributes();
                /*0xfc5468*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0xfc5470*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0xfc5478*/ void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes);
            }

            class XmlSchemaSimpleContentRestriction : System.Xml.Schema.XmlSchemaContent
            {
                /*0x50*/ System.Xml.XmlQualifiedName baseTypeName;
                /*0x58*/ System.Xml.Schema.XmlSchemaSimpleType baseType;
                /*0x60*/ System.Xml.Schema.XmlSchemaObjectCollection facets;
                /*0x68*/ System.Xml.Schema.XmlSchemaObjectCollection attributes;
                /*0x70*/ System.Xml.Schema.XmlSchemaAnyAttribute anyAttribute;

                /*0xfc55f4*/ XmlSchemaSimpleContentRestriction();
                /*0xfc551c*/ System.Xml.XmlQualifiedName get_BaseTypeName();
                /*0xfc5524*/ void set_BaseTypeName(System.Xml.XmlQualifiedName value);
                /*0xfc55bc*/ System.Xml.Schema.XmlSchemaSimpleType get_BaseType();
                /*0xfc55c4*/ void set_BaseType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0xfc55cc*/ System.Xml.Schema.XmlSchemaObjectCollection get_Facets();
                /*0xfc55d4*/ System.Xml.Schema.XmlSchemaObjectCollection get_Attributes();
                /*0xfc55dc*/ System.Xml.Schema.XmlSchemaAnyAttribute get_AnyAttribute();
                /*0xfc55e4*/ void set_AnyAttribute(System.Xml.Schema.XmlSchemaAnyAttribute value);
                /*0xfc55ec*/ void SetAttributes(System.Xml.Schema.XmlSchemaObjectCollection newAttributes);
            }

            class XmlSchemaSimpleType : System.Xml.Schema.XmlSchemaType
            {
                /*0x98*/ System.Xml.Schema.XmlSchemaSimpleTypeContent content;

                /*0xfc56ac*/ XmlSchemaSimpleType();
                /*0xfc5724*/ System.Xml.Schema.XmlSchemaSimpleTypeContent get_Content();
                /*0xfc572c*/ void set_Content(System.Xml.Schema.XmlSchemaSimpleTypeContent value);
                /*0xfc5734*/ System.Xml.Schema.XmlSchemaObject Clone();
            }

            class XmlSchemaSimpleTypeContent : System.Xml.Schema.XmlSchemaAnnotated
            {
                /*0xfc5828*/ XmlSchemaSimpleTypeContent();
            }

            class XmlSchemaSimpleTypeList : System.Xml.Schema.XmlSchemaSimpleTypeContent
            {
                /*0x50*/ System.Xml.XmlQualifiedName itemTypeName;
                /*0x58*/ System.Xml.Schema.XmlSchemaSimpleType itemType;
                /*0x60*/ System.Xml.Schema.XmlSchemaSimpleType baseItemType;

                /*0xfc59a0*/ XmlSchemaSimpleTypeList();
                /*0xfc5830*/ System.Xml.XmlQualifiedName get_ItemTypeName();
                /*0xfc5838*/ void set_ItemTypeName(System.Xml.XmlQualifiedName value);
                /*0xfc58d0*/ System.Xml.Schema.XmlSchemaSimpleType get_ItemType();
                /*0xfc58d8*/ void set_ItemType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0xfc58e0*/ System.Xml.Schema.XmlSchemaSimpleType get_BaseItemType();
                /*0xfc58e8*/ void set_BaseItemType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0xfc58f0*/ System.Xml.Schema.XmlSchemaObject Clone();
            }

            class XmlSchemaSimpleTypeRestriction : System.Xml.Schema.XmlSchemaSimpleTypeContent
            {
                /*0x50*/ System.Xml.XmlQualifiedName baseTypeName;
                /*0x58*/ System.Xml.Schema.XmlSchemaSimpleType baseType;
                /*0x60*/ System.Xml.Schema.XmlSchemaObjectCollection facets;

                /*0xfc5b70*/ XmlSchemaSimpleTypeRestriction();
                /*0xfc5a08*/ System.Xml.XmlQualifiedName get_BaseTypeName();
                /*0xfc5a10*/ void set_BaseTypeName(System.Xml.XmlQualifiedName value);
                /*0xfc5aa8*/ System.Xml.Schema.XmlSchemaSimpleType get_BaseType();
                /*0xfc5ab0*/ void set_BaseType(System.Xml.Schema.XmlSchemaSimpleType value);
                /*0xfc5ab8*/ System.Xml.Schema.XmlSchemaObjectCollection get_Facets();
                /*0xfc5ac0*/ System.Xml.Schema.XmlSchemaObject Clone();
            }

            class XmlSchemaSimpleTypeUnion : System.Xml.Schema.XmlSchemaSimpleTypeContent
            {
                /*0x50*/ System.Xml.Schema.XmlSchemaObjectCollection baseTypes;
                /*0x58*/ System.Xml.XmlQualifiedName[] memberTypes;
                /*0x60*/ System.Xml.Schema.XmlSchemaSimpleType[] baseMemberTypes;

                /*0xfc5d9c*/ XmlSchemaSimpleTypeUnion();
                /*0xfc5c0c*/ System.Xml.Schema.XmlSchemaObjectCollection get_BaseTypes();
                /*0xfc5c14*/ System.Xml.XmlQualifiedName[] get_MemberTypes();
                /*0xfc5c1c*/ void set_MemberTypes(System.Xml.XmlQualifiedName[] value);
                /*0xfc5c24*/ System.Xml.Schema.XmlSchemaSimpleType[] get_BaseMemberTypes();
                /*0xfc5c2c*/ void SetBaseMemberTypes(System.Xml.Schema.XmlSchemaSimpleType[] baseMemberTypes);
                /*0xfc5c34*/ System.Xml.Schema.XmlSchemaObject Clone();
            }

            class XmlSchemaSubstitutionGroup : System.Xml.Schema.XmlSchemaObject
            {
                /*0x38*/ System.Collections.ArrayList membersList;
                /*0x40*/ System.Xml.XmlQualifiedName examplar;

                /*0xfc5e1c*/ XmlSchemaSubstitutionGroup();
                /*0xfc5e04*/ System.Collections.ArrayList get_Members();
                /*0xfc5e0c*/ System.Xml.XmlQualifiedName get_Examplar();
                /*0xfc5e14*/ void set_Examplar(System.Xml.XmlQualifiedName value);
            }

            class XmlSchemaSubstitutionGroupV1Compat : System.Xml.Schema.XmlSchemaSubstitutionGroup
            {
                /*0x48*/ System.Xml.Schema.XmlSchemaChoice choice;

                /*0xfc5ec0*/ XmlSchemaSubstitutionGroupV1Compat();
                /*0xfc5eb8*/ System.Xml.Schema.XmlSchemaChoice get_Choice();
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

                static /*0xfc5f24*/ System.Xml.Schema.XmlSchemaSimpleType GetBuiltInSimpleType(System.Xml.XmlQualifiedName qualifiedName);
                static /*0xfc6000*/ System.Xml.Schema.XmlSchemaSimpleType GetBuiltInSimpleType(System.Xml.Schema.XmlTypeCode typeCode);
                static /*0xfc6058*/ System.Xml.Schema.XmlSchemaComplexType GetBuiltInComplexType(System.Xml.XmlQualifiedName qualifiedName);
                static /*0xfc64bc*/ bool IsDerivedFrom(System.Xml.Schema.XmlSchemaType derivedType, System.Xml.Schema.XmlSchemaType baseType, System.Xml.Schema.XmlSchemaDerivationMethod except);
                static /*0xfc66b4*/ bool IsDerivedFromDatatype(System.Xml.Schema.XmlSchemaDatatype derivedDataType, System.Xml.Schema.XmlSchemaDatatype baseDataType, System.Xml.Schema.XmlSchemaDerivationMethod except);
                /*0xfc56b0*/ XmlSchemaType();
                /*0xfc62a4*/ string get_Name();
                /*0xfc62ac*/ void set_Name(string value);
                /*0xfc62b4*/ System.Xml.Schema.XmlSchemaDerivationMethod get_Final();
                /*0xfc62bc*/ void set_Final(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0xfc51d0*/ System.Xml.XmlQualifiedName get_QualifiedName();
                /*0xfc62c4*/ System.Xml.Schema.XmlSchemaDerivationMethod get_FinalResolved();
                /*0xfc62cc*/ System.Xml.Schema.XmlSchemaType get_BaseXmlSchemaType();
                /*0xfc62d4*/ System.Xml.Schema.XmlSchemaDerivationMethod get_DerivedBy();
                /*0xfc62dc*/ System.Xml.Schema.XmlSchemaDatatype get_Datatype();
                /*0xfc62e4*/ bool get_IsMixed();
                /*0xfc62ec*/ void set_IsMixed(bool value);
                /*0xfc62f0*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0xfc63a4*/ System.Xml.Schema.XmlValueConverter get_ValueConverter();
                /*0xfc641c*/ System.Xml.Schema.XmlSchemaContentType get_SchemaContentType();
                /*0xfc6424*/ void SetQualifiedName(System.Xml.XmlQualifiedName value);
                /*0xfc6448*/ void SetFinalResolved(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0xfc6450*/ void SetBaseSchemaType(System.Xml.Schema.XmlSchemaType value);
                /*0xfc6458*/ void SetDerivedBy(System.Xml.Schema.XmlSchemaDerivationMethod value);
                /*0xfc6460*/ void SetDatatype(System.Xml.Schema.XmlSchemaDatatype value);
                /*0xfc6468*/ System.Xml.Schema.SchemaElementDecl get_ElementDecl();
                /*0xfc6480*/ void set_ElementDecl(System.Xml.Schema.SchemaElementDecl value);
                /*0xfc64a4*/ System.Xml.Schema.XmlSchemaType get_Redefined();
                /*0xfc64ac*/ void set_Redefined(System.Xml.Schema.XmlSchemaType value);
                /*0xfc64b4*/ void SetContentType(System.Xml.Schema.XmlSchemaContentType value);
                /*0xfc6788*/ string get_NameAttribute();
                /*0xfc6790*/ void set_NameAttribute(string value);
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
                /*0xfc6798*/ XmlSchemaValidationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
                /*0xfc67a8*/ XmlSchemaValidationException();
                /*0xfc67b4*/ XmlSchemaValidationException(string res, string arg, string sourceUri, int lineNumber, int linePosition);
                /*0xfc689c*/ XmlSchemaValidationException(string res, string[] args, string sourceUri, int lineNumber, int linePosition);
                /*0xfc68cc*/ XmlSchemaValidationException(string res, string[] args, System.Exception innerException, string sourceUri, int lineNumber, int linePosition);
                /*0xfc67a0*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            class XmlValueGetter : System.MulticastDelegate
            {
                /*0xfc68ec*/ XmlValueGetter(object object, nint method);
                /*0xfc69a8*/ object Invoke();
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

                /*0xfc69bc*/ IdRefNode(System.Xml.Schema.IdRefNode next, string id, int lineNo, int linePos);
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

                static /*0xfd15a0*/ XmlSchemaValidator();
                static /*0xfcf254*/ void ElementValidationError(System.Xml.XmlQualifiedName name, System.Xml.Schema.ValidationState context, System.Xml.Schema.ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, System.Xml.Schema.XmlSchemaSet schemaSet);
                static /*0xfcd61c*/ void CompleteValidationError(System.Xml.Schema.ValidationState context, System.Xml.Schema.ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, System.Xml.Schema.XmlSchemaSet schemaSet);
                static /*0xfcb494*/ string PrintExpectedElements(System.Collections.ArrayList expected, bool getParticles);
                static /*0xfd11f4*/ string PrintNames(System.Collections.ArrayList expected);
                static /*0xfd0d84*/ void PrintNamesWithNS(System.Collections.ArrayList expected, System.Text.StringBuilder builder);
                static /*0xfd1370*/ void EnumerateAny(System.Text.StringBuilder builder, string namespaces);
                static /*0xfcb2b4*/ string QNameString(string localName, string ns);
                static /*0xfcefd4*/ string BuildElementName(System.Xml.XmlQualifiedName qname);
                static /*0xfcb368*/ string BuildElementName(string localName, string ns);
                static /*0xfd0cc8*/ void SendValidationEvent(System.Xml.Schema.ValidationEventHandler eventHandler, object sender, System.Xml.Schema.XmlSchemaValidationException e, System.Xml.Schema.XmlSeverityType severity);
                /*0xfc6a00*/ XmlSchemaValidator(System.Xml.XmlNameTable nameTable, System.Xml.Schema.XmlSchemaSet schemas, System.Xml.IXmlNamespaceResolver namespaceResolver, System.Xml.Schema.XmlSchemaValidationFlags validationFlags);
                /*0xfc6bec*/ void Init();
                /*0xfc6ff0*/ void Reset();
                /*0xfc714c*/ void set_XmlResolver(System.Xml.XmlResolver value);
                /*0xfc7154*/ void set_LineInfoProvider(System.Xml.IXmlLineInfo value);
                /*0xfc716c*/ void set_SourceUri(System.Uri value);
                /*0xfc71a0*/ void set_ValidationEventSender(object value);
                /*0xfc71a8*/ void add_ValidationEventHandler(System.Xml.Schema.ValidationEventHandler value);
                /*0xfc7228*/ void remove_ValidationEventHandler(System.Xml.Schema.ValidationEventHandler value);
                /*0xfc72a8*/ void AddSchema(System.Xml.Schema.XmlSchema schema);
                /*0xfc7a30*/ void Initialize();
                /*0xfc7b90*/ void Initialize(System.Xml.Schema.XmlSchemaObject partialValidationType);
                /*0xfc7e54*/ void ValidateElement(string localName, string namespaceUri, System.Xml.Schema.XmlSchemaInfo schemaInfo, string xsiType, string xsiNil, string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation);
                /*0xfc9758*/ object ValidateAttribute(string localName, string namespaceUri, System.Xml.Schema.XmlValueGetter attributeValue, System.Xml.Schema.XmlSchemaInfo schemaInfo);
                /*0xfc97b8*/ object ValidateAttribute(string lName, string ns, System.Xml.Schema.XmlValueGetter attributeValueGetter, string attributeStringValue, System.Xml.Schema.XmlSchemaInfo schemaInfo);
                /*0xfcac0c*/ void ValidateEndOfAttributes(System.Xml.Schema.XmlSchemaInfo schemaInfo);
                /*0xfcaed8*/ void ValidateText(System.Xml.Schema.XmlValueGetter elementValue);
                /*0xfcaf38*/ void ValidateText(string elementStringValue, System.Xml.Schema.XmlValueGetter elementValueGetter);
                /*0xfcb890*/ void ValidateWhitespace(System.Xml.Schema.XmlValueGetter elementValue);
                /*0xfcb8f0*/ void ValidateWhitespace(string elementStringValue, System.Xml.Schema.XmlValueGetter elementValueGetter);
                /*0xfcbacc*/ object ValidateEndElement(System.Xml.Schema.XmlSchemaInfo schemaInfo);
                /*0xfcbfcc*/ void SkipToEndElement(System.Xml.Schema.XmlSchemaInfo schemaInfo);
                /*0xfcc2f4*/ void EndValidation();
                /*0xfcc4d8*/ void GetUnspecifiedDefaultAttributes(System.Collections.ArrayList defaultAttributes, bool createNodeData);
                /*0xfcce78*/ System.Xml.Schema.XmlSchemaSet get_SchemaSet();
                /*0xfcce80*/ System.Xml.Schema.XmlSchemaValidationFlags get_ValidationFlags();
                /*0xfcce88*/ System.Xml.Schema.XmlSchemaContentType get_CurrentContentType();
                /*0xfccebc*/ void SetDtdSchemaInfo(System.Xml.IDtdInfo dtdSchemaInfo);
                /*0xfccecc*/ bool get_StrictlyAssessed();
                /*0xfccf10*/ bool get_HasSchema();
                /*0xfccf58*/ string GetConcatenatedValue();
                /*0xfcbad4*/ object InternalValidateEndElement(System.Xml.Schema.XmlSchemaInfo schemaInfo, object typedValue);
                /*0xfc8aa0*/ void ProcessSchemaLocations(string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation);
                /*0xfc8448*/ object ValidateElementContext(System.Xml.XmlQualifiedName elementName, ref bool invalidElementInContext);
                /*0xfceda8*/ System.Xml.Schema.XmlSchemaElement GetSubstitutionGroupHead(System.Xml.XmlQualifiedName member);
                /*0xfccf78*/ object ValidateAtomicValue(string stringValue, ref System.Xml.Schema.XmlSchemaSimpleType memberType);
                /*0xfcd20c*/ object ValidateAtomicValue(object parsedValue, ref System.Xml.Schema.XmlSchemaSimpleType memberType);
                /*0xfcfc94*/ string GetTypeName(System.Xml.Schema.SchemaDeclBase decl);
                /*0xfcb328*/ void SaveTextValue(object value);
                /*0xfc6f00*/ void Push(System.Xml.XmlQualifiedName elementName);
                /*0xfcc1d0*/ void Pop();
                /*0xfc8850*/ System.Xml.Schema.SchemaElementDecl FastGetElementDecl(System.Xml.XmlQualifiedName elementName, object particle);
                /*0xfc8e08*/ System.Xml.Schema.SchemaElementDecl CheckXsiTypeAndNil(System.Xml.Schema.SchemaElementDecl elementDecl, string xsiType, string xsiNil, ref bool declFound);
                /*0xfc93f8*/ void ThrowDeclNotFoundWarningOrError(bool declFound);
                /*0xfc9540*/ void CheckElementProperties();
                /*0xfc95f4*/ void ValidateStartElementIdentityConstraints();
                /*0xfca2dc*/ System.Xml.Schema.SchemaAttDef CheckIsXmlAttribute(System.Xml.XmlQualifiedName attQName);
                /*0xfd0510*/ void AddXmlNamespaceSchema();
                /*0xfcd540*/ object CheckMixedValueConstraint(string elementValue);
                /*0xfce820*/ void LoadSchema(string uri, string url);
                /*0xfc707c*/ void RecompileSchemaSet();
                /*0xfd0764*/ void ProcessTokenizedType(System.Xml.XmlTokenizedType ttype, string name, bool attrValue);
                /*0xfca534*/ object CheckAttributeValue(object value, System.Xml.Schema.SchemaAttDef attdef);
                /*0xfcfa3c*/ object CheckElementValue(string stringValue);
                /*0xfca7b8*/ void CheckTokenizedTypes(System.Xml.Schema.XmlSchemaDatatype dtype, object typedValue, bool attrValue);
                /*0xfd0a08*/ object FindId(string name);
                /*0xfcc3e8*/ void CheckForwardRefs();
                /*0xfca944*/ bool get_HasIdentityConstraints();
                /*0xfcfd5c*/ bool get_ProcessIdentityConstraints();
                /*0xfd0cb4*/ bool get_ReportValidationWarnings();
                /*0xfc713c*/ bool get_ProcessSchemaHints();
                /*0xfc81b4*/ void CheckStateTransition(System.Xml.Schema.ValidatorState toState, string methodName);
                /*0xfc8404*/ void ClearPSVI();
                /*0xfcacd4*/ void CheckRequiredAttributes(System.Xml.Schema.SchemaElementDecl currentElementDecl);
                /*0xfc9650*/ System.Xml.Schema.XmlSchemaElement GetSchemaElement();
                /*0xfcca88*/ string GetDefaultAttributePrefix(string attributeNS);
                /*0xfcfd68*/ void AddIdentityConstraints();
                /*0xfd0160*/ void ElementIdentityConstraints();
                /*0xfca964*/ void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0xfcdac4*/ void EndElementIdentityConstraints(object typedValue, string stringValue, System.Xml.Schema.XmlSchemaDatatype datatype);
                /*0xfd0a24*/ void ProcessEntity(string name);
                /*0xfcfcfc*/ void SendValidationEvent(string code);
                /*0xfca3a4*/ void SendValidationEvent(string code, string[] args);
                /*0xfca160*/ void SendValidationEvent(string code, string arg);
                /*0xfcf03c*/ void SendValidationEvent(string code, string arg1, string arg2);
                /*0xfd0598*/ void SendValidationEvent(string code, string[] args, System.Exception innerException, System.Xml.Schema.XmlSeverityType severity);
                /*0xfc7894*/ void SendValidationEvent(string code, string[] args, System.Exception innerException);
                /*0xfd0cc0*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaValidationException e);
                /*0xfcecf4*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e);
                /*0xfc76e4*/ void SendValidationEvent(string code, string msg, System.Xml.Schema.XmlSeverityType severity);
                /*0xfd0b98*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaValidationException e, System.Xml.Schema.XmlSeverityType severity);
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
                /*0xfd1a44*/ XmlValueConverter();
                bool ToBoolean(long value);
                bool ToBoolean(int value);
                bool ToBoolean(double value);
                bool ToBoolean(System.DateTime value);
                bool ToBoolean(string value);
                bool ToBoolean(object value);
                int ToInt32(bool value);
                int ToInt32(long value);
                int ToInt32(double value);
                int ToInt32(System.DateTime value);
                int ToInt32(string value);
                int ToInt32(object value);
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
                string ToString(int value);
                string ToString(long value);
                string ToString(decimal value);
                string ToString(float value);
                string ToString(double value);
                string ToString(System.DateTime value);
                string ToString(System.DateTimeOffset value);
                string ToString(object value);
                string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                object ChangeType(bool value, System.Type destinationType);
                object ChangeType(int value, System.Type destinationType);
                object ChangeType(long value, System.Type destinationType);
                object ChangeType(decimal value, System.Type destinationType);
                object ChangeType(double value, System.Type destinationType);
                object ChangeType(System.DateTime value, System.Type destinationType);
                object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                object ChangeType(object value, System.Type destinationType);
                object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
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

                static /*0xfd73b0*/ XmlBaseConverter();
                static /*0xfd4d40*/ bool IsDerivedFrom(System.Type derivedType, System.Type baseType);
                static /*0xfd4c1c*/ string QNameToString(System.Xml.XmlQualifiedName name);
                static /*0xfd50bc*/ byte[] StringToBase64Binary(string value);
                static /*0xfd514c*/ System.DateTime StringToDate(string value);
                static /*0xfd51c8*/ System.DateTime StringToDateTime(string value);
                static /*0xfd5244*/ System.TimeSpan StringToDayTimeDuration(string value);
                static /*0xfd52a4*/ System.TimeSpan StringToDuration(string value);
                static /*0xfd5304*/ System.DateTime StringToGDay(string value);
                static /*0xfd5380*/ System.DateTime StringToGMonth(string value);
                static /*0xfd53fc*/ System.DateTime StringToGMonthDay(string value);
                static /*0xfd5478*/ System.DateTime StringToGYear(string value);
                static /*0xfd54f4*/ System.DateTime StringToGYearMonth(string value);
                static /*0xfd5570*/ System.DateTimeOffset StringToDateOffset(string value);
                static /*0xfd55ec*/ System.DateTimeOffset StringToDateTimeOffset(string value);
                static /*0xfd5668*/ System.DateTimeOffset StringToGDayOffset(string value);
                static /*0xfd56e4*/ System.DateTimeOffset StringToGMonthOffset(string value);
                static /*0xfd5760*/ System.DateTimeOffset StringToGMonthDayOffset(string value);
                static /*0xfd57dc*/ System.DateTimeOffset StringToGYearOffset(string value);
                static /*0xfd5858*/ System.DateTimeOffset StringToGYearMonthOffset(string value);
                static /*0xfd58d4*/ byte[] StringToHexBinary(string value);
                static /*0xfd5a10*/ System.Xml.XmlQualifiedName StringToQName(string value, System.Xml.IXmlNamespaceResolver nsResolver);
                static /*0xfd5cd4*/ System.DateTime StringToTime(string value);
                static /*0xfd5d50*/ System.DateTimeOffset StringToTimeOffset(string value);
                static /*0xfd5dcc*/ System.TimeSpan StringToYearMonthDuration(string value);
                static /*0xfd5e2c*/ string AnyUriToString(System.Uri value);
                static /*0xfd5e40*/ string Base64BinaryToString(byte[] value);
                static /*0xfd5e98*/ string DateToString(System.DateTime value);
                static /*0xfd5edc*/ string DateTimeToString(System.DateTime value);
                static /*0xfd5f20*/ string DayTimeDurationToString(System.TimeSpan value);
                static /*0xfd5f80*/ string DurationToString(System.TimeSpan value);
                static /*0xfd5fe0*/ string GDayToString(System.DateTime value);
                static /*0xfd6024*/ string GMonthToString(System.DateTime value);
                static /*0xfd6068*/ string GMonthDayToString(System.DateTime value);
                static /*0xfd60ac*/ string GYearToString(System.DateTime value);
                static /*0xfd60f0*/ string GYearMonthToString(System.DateTime value);
                static /*0xfd6134*/ string DateOffsetToString(System.DateTimeOffset value);
                static /*0xfd617c*/ string DateTimeOffsetToString(System.DateTimeOffset value);
                static /*0xfd61c4*/ string GDayOffsetToString(System.DateTimeOffset value);
                static /*0xfd620c*/ string GMonthOffsetToString(System.DateTimeOffset value);
                static /*0xfd6254*/ string GMonthDayOffsetToString(System.DateTimeOffset value);
                static /*0xfd629c*/ string GYearOffsetToString(System.DateTimeOffset value);
                static /*0xfd62e4*/ string GYearMonthOffsetToString(System.DateTimeOffset value);
                static /*0xfd632c*/ string QNameToString(System.Xml.XmlQualifiedName qname, System.Xml.IXmlNamespaceResolver nsResolver);
                static /*0xfd6548*/ string TimeToString(System.DateTime value);
                static /*0xfd658c*/ string TimeOffsetToString(System.DateTimeOffset value);
                static /*0xfd65d4*/ string YearMonthDurationToString(System.TimeSpan value);
                static /*0xfd6634*/ System.DateTime DateTimeOffsetToDateTime(System.DateTimeOffset value);
                static /*0xfd6658*/ int DecimalToInt32(decimal value);
                static /*0xfd685c*/ long DecimalToInt64(decimal value);
                static /*0xfd6a60*/ ulong DecimalToUInt64(decimal value);
                static /*0xfd6c58*/ byte Int32ToByte(int value);
                static /*0xfd6d68*/ short Int32ToInt16(int value);
                static /*0xfd6e78*/ sbyte Int32ToSByte(int value);
                static /*0xfd6f88*/ ushort Int32ToUInt16(int value);
                static /*0xfd7098*/ int Int64ToInt32(long value);
                static /*0xfd71a8*/ uint Int64ToUInt32(long value);
                static /*0xfd72b8*/ System.DateTime UntypedAtomicToDateTime(string value);
                static /*0xfd7334*/ System.DateTimeOffset UntypedAtomicToDateTimeOffset(string value);
                /*0xfd1a4c*/ XmlBaseConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0xfd1b28*/ XmlBaseConverter(System.Xml.Schema.XmlTypeCode typeCode);
                /*0xfd1bf0*/ XmlBaseConverter(System.Xml.Schema.XmlBaseConverter converterAtomic);
                /*0xfd1c4c*/ XmlBaseConverter(System.Xml.Schema.XmlBaseConverter converterAtomic, System.Type clrTypeDefault);
                /*0xfd1c90*/ bool ToBoolean(System.DateTime value);
                /*0xfd1d88*/ bool ToBoolean(double value);
                /*0xfd1e88*/ bool ToBoolean(int value);
                /*0xfd1f80*/ bool ToBoolean(long value);
                /*0xfd2078*/ bool ToBoolean(string value);
                /*0xfd213c*/ bool ToBoolean(object value);
                /*0xfd2200*/ System.DateTime ToDateTime(bool value);
                /*0xfd22f8*/ System.DateTime ToDateTime(System.DateTimeOffset value);
                /*0xfd23fc*/ System.DateTime ToDateTime(double value);
                /*0xfd24fc*/ System.DateTime ToDateTime(int value);
                /*0xfd25f4*/ System.DateTime ToDateTime(long value);
                /*0xfd26ec*/ System.DateTime ToDateTime(string value);
                /*0xfd27b0*/ System.DateTime ToDateTime(object value);
                /*0xfd2874*/ System.DateTimeOffset ToDateTimeOffset(System.DateTime value);
                /*0xfd2970*/ System.DateTimeOffset ToDateTimeOffset(string value);
                /*0xfd2a38*/ System.DateTimeOffset ToDateTimeOffset(object value);
                /*0xfd2b00*/ decimal ToDecimal(string value);
                /*0xfd2bc8*/ decimal ToDecimal(object value);
                /*0xfd2c90*/ double ToDouble(bool value);
                /*0xfd2d88*/ double ToDouble(System.DateTime value);
                /*0xfd2e80*/ double ToDouble(int value);
                /*0xfd2f78*/ double ToDouble(long value);
                /*0xfd3070*/ double ToDouble(string value);
                /*0xfd3134*/ double ToDouble(object value);
                /*0xfd31f8*/ int ToInt32(bool value);
                /*0xfd32f0*/ int ToInt32(System.DateTime value);
                /*0xfd33e8*/ int ToInt32(double value);
                /*0xfd34e8*/ int ToInt32(long value);
                /*0xfd35e0*/ int ToInt32(string value);
                /*0xfd36a4*/ int ToInt32(object value);
                /*0xfd3768*/ long ToInt64(bool value);
                /*0xfd3860*/ long ToInt64(System.DateTime value);
                /*0xfd3958*/ long ToInt64(double value);
                /*0xfd3a58*/ long ToInt64(int value);
                /*0xfd3b50*/ long ToInt64(string value);
                /*0xfd3c14*/ long ToInt64(object value);
                /*0xfd3cd8*/ float ToSingle(double value);
                /*0xfd3dd8*/ float ToSingle(string value);
                /*0xfd3e9c*/ float ToSingle(object value);
                /*0xfd3f60*/ string ToString(bool value);
                /*0xfd4044*/ string ToString(System.DateTime value);
                /*0xfd4128*/ string ToString(System.DateTimeOffset value);
                /*0xfd4218*/ string ToString(decimal value);
                /*0xfd4328*/ string ToString(double value);
                /*0xfd4414*/ string ToString(int value);
                /*0xfd44f8*/ string ToString(long value);
                /*0xfd45dc*/ string ToString(float value);
                /*0xfd46c8*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0xfd477c*/ string ToString(object value);
                /*0xfd4790*/ object ChangeType(bool value, System.Type destinationType);
                /*0xfd4818*/ object ChangeType(System.DateTime value, System.Type destinationType);
                /*0xfd48a0*/ object ChangeType(decimal value, System.Type destinationType);
                /*0xfd4954*/ object ChangeType(double value, System.Type destinationType);
                /*0xfd49e4*/ object ChangeType(int value, System.Type destinationType);
                /*0xfd4a6c*/ object ChangeType(long value, System.Type destinationType);
                /*0xfd4af4*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0xfd4b04*/ object ChangeType(object value, System.Type destinationType);
                /*0xfd4b18*/ System.Xml.Schema.XmlSchemaType get_SchemaType();
                /*0xfd4b20*/ System.Xml.Schema.XmlTypeCode get_TypeCode();
                /*0xfd4b28*/ string get_XmlTypeName();
                /*0xfd4d38*/ System.Type get_DefaultClrType();
                /*0xfd4e04*/ System.Exception CreateInvalidClrMappingException(System.Type sourceType, System.Type destinationType);
                /*0xfd5068*/ object ChangeListType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlNumeric10Converter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0xfd8a28*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0xfd89c0*/ XmlNumeric10Converter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0xfd8a88*/ decimal ToDecimal(string value);
                /*0xfd8b50*/ decimal ToDecimal(object value);
                /*0xfd9394*/ int ToInt32(long value);
                /*0xfd93ec*/ int ToInt32(string value);
                /*0xfd94f4*/ int ToInt32(object value);
                /*0xfd98e0*/ long ToInt64(int value);
                /*0xfd98e8*/ long ToInt64(string value);
                /*0xfd99f0*/ long ToInt64(object value);
                /*0xfd9dc0*/ string ToString(decimal value);
                /*0xfd9e7c*/ string ToString(int value);
                /*0xfd9ed4*/ string ToString(long value);
                /*0xfd9f2c*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0xfda338*/ object ChangeType(decimal value, System.Type destinationType);
                /*0xfdabe4*/ object ChangeType(int value, System.Type destinationType);
                /*0xfdb00c*/ object ChangeType(long value, System.Type destinationType);
                /*0xfdb444*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0xfdb87c*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0xfd8f34*/ object ChangeTypeWildcardDestination(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0xfda780*/ object ChangeTypeWildcardSource(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlNumeric2Converter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0xfdc808*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0xfdc7a0*/ XmlNumeric2Converter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0xfdc868*/ double ToDouble(string value);
                /*0xfdc938*/ double ToDouble(object value);
                /*0xfdcc78*/ float ToSingle(double value);
                /*0xfdcc80*/ float ToSingle(string value);
                /*0xfdcd50*/ float ToSingle(object value);
                /*0xfdd098*/ string ToString(double value);
                /*0xfdd14c*/ string ToString(float value);
                /*0xfdd1d4*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0xfdd52c*/ object ChangeType(double value, System.Type destinationType);
                /*0xfdd89c*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0xfddc4c*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlDateTimeConverter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0xfde388*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0xfde320*/ XmlDateTimeConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0xfde3e8*/ System.DateTime ToDateTime(System.DateTimeOffset value);
                /*0xfde450*/ System.DateTime ToDateTime(string value);
                /*0xfde620*/ System.DateTime ToDateTime(object value);
                /*0xfde97c*/ System.DateTimeOffset ToDateTimeOffset(System.DateTime value);
                /*0xfde9a4*/ System.DateTimeOffset ToDateTimeOffset(string value);
                /*0xfdeb74*/ System.DateTimeOffset ToDateTimeOffset(object value);
                /*0xfdeed4*/ string ToString(System.DateTime value);
                /*0xfdf054*/ string ToString(System.DateTimeOffset value);
                /*0xfdf21c*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0xfdf574*/ object ChangeType(System.DateTime value, System.Type destinationType);
                /*0xfdf90c*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0xfdfcbc*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlBooleanConverter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0xfe0434*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0xfe03cc*/ XmlBooleanConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0xfe0494*/ bool ToBoolean(string value);
                /*0xfe053c*/ bool ToBoolean(object value);
                /*0xfe0818*/ string ToString(bool value);
                /*0xfe0870*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0xfe0b3c*/ object ChangeType(bool value, System.Type destinationType);
                /*0xfe0e6c*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0xfe11b0*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlMiscConverter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0xfe17c0*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0xfe1758*/ XmlMiscConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0xfe1820*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0xfe1ea8*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0xfe2520*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0xfe1d6c*/ object ChangeTypeWildcardDestination(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0xfe23bc*/ object ChangeTypeWildcardSource(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlStringConverter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0xfe328c*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0xfe3224*/ XmlStringConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0xfe32ec*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0xfe34fc*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0xfe3798*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlUntypedConverter : System.Xml.Schema.XmlListConverter
            {
                static /*0x0*/ System.Xml.Schema.XmlValueConverter Untyped;
                static /*0x8*/ System.Xml.Schema.XmlValueConverter UntypedList;
                /*0x30*/ bool allowListToList;

                static /*0xfea768*/ XmlUntypedConverter();
                /*0xfe3bd4*/ XmlUntypedConverter();
                /*0xfe3ccc*/ XmlUntypedConverter(System.Xml.Schema.XmlUntypedConverter atomicConverter, bool allowListToList);
                /*0xfe3ddc*/ bool ToBoolean(string value);
                /*0xfe3e84*/ bool ToBoolean(object value);
                /*0xfe4190*/ System.DateTime ToDateTime(string value);
                /*0xfe4238*/ System.DateTime ToDateTime(object value);
                /*0xfe43f0*/ System.DateTimeOffset ToDateTimeOffset(string value);
                /*0xfe4498*/ System.DateTimeOffset ToDateTimeOffset(object value);
                /*0xfe4650*/ decimal ToDecimal(string value);
                /*0xfe46f8*/ decimal ToDecimal(object value);
                /*0xfe48c8*/ double ToDouble(string value);
                /*0xfe4970*/ double ToDouble(object value);
                /*0xfe4b40*/ int ToInt32(string value);
                /*0xfe4be8*/ int ToInt32(object value);
                /*0xfe4db8*/ long ToInt64(string value);
                /*0xfe4e60*/ long ToInt64(object value);
                /*0xfe5030*/ float ToSingle(string value);
                /*0xfe50d8*/ float ToSingle(object value);
                /*0xfe52a8*/ string ToString(bool value);
                /*0xfe5300*/ string ToString(System.DateTime value);
                /*0xfe5358*/ string ToString(System.DateTimeOffset value);
                /*0xfe53c0*/ string ToString(decimal value);
                /*0xfe5428*/ string ToString(double value);
                /*0xfe5488*/ string ToString(int value);
                /*0xfe54e0*/ string ToString(long value);
                /*0xfe5538*/ string ToString(float value);
                /*0xfe5598*/ string ToString(object value, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0xfe6340*/ object ChangeType(bool value, System.Type destinationType);
                /*0xfe66bc*/ object ChangeType(System.DateTime value, System.Type destinationType);
                /*0xfe6888*/ object ChangeType(decimal value, System.Type destinationType);
                /*0xfe6a94*/ object ChangeType(double value, System.Type destinationType);
                /*0xfe6c74*/ object ChangeType(int value, System.Type destinationType);
                /*0xfe6e54*/ object ChangeType(long value, System.Type destinationType);
                /*0xfe7034*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0xfe7c3c*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0xfe4054*/ object ChangeTypeWildcardDestination(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0xfe6524*/ object ChangeTypeWildcardSource(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0xfe9138*/ object ChangeListType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0xfe9440*/ bool SupportsType(System.Type clrType);
            }

            class XmlAnyConverter : System.Xml.Schema.XmlBaseConverter
            {
                static /*0x0*/ System.Xml.Schema.XmlValueConverter Item;
                static /*0x8*/ System.Xml.Schema.XmlValueConverter AnyAtomic;

                static /*0xfedc94*/ XmlAnyConverter();
                /*0xfea820*/ XmlAnyConverter(System.Xml.Schema.XmlTypeCode typeCode);
                /*0xfea888*/ bool ToBoolean(object value);
                /*0xfeab78*/ System.DateTime ToDateTime(object value);
                /*0xfead2c*/ System.DateTimeOffset ToDateTimeOffset(object value);
                /*0xfeaef0*/ decimal ToDecimal(object value);
                /*0xfeb0b4*/ double ToDouble(object value);
                /*0xfeb268*/ int ToInt32(object value);
                /*0xfeb41c*/ long ToInt64(object value);
                /*0xfeb5d0*/ float ToSingle(object value);
                /*0xfeb790*/ object ChangeType(bool value, System.Type destinationType);
                /*0xfebaf0*/ object ChangeType(System.DateTime value, System.Type destinationType);
                /*0xfebce8*/ object ChangeType(decimal value, System.Type destinationType);
                /*0xfebf28*/ object ChangeType(double value, System.Type destinationType);
                /*0xfec120*/ object ChangeType(int value, System.Type destinationType);
                /*0xfec318*/ object ChangeType(long value, System.Type destinationType);
                /*0xfec510*/ object ChangeType(string value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0xfec718*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0xfeaa3c*/ object ChangeTypeWildcardDestination(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0xfeb98c*/ object ChangeTypeWildcardSource(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0xfedc0c*/ System.Xml.XPath.XPathNavigator ToNavigator(System.Xml.XPath.XPathNavigator nav);
            }

            class XmlAnyListConverter : System.Xml.Schema.XmlListConverter
            {
                static /*0x0*/ System.Xml.Schema.XmlValueConverter ItemList;
                static /*0x8*/ System.Xml.Schema.XmlValueConverter AnyAtomicList;

                static /*0xfedfe8*/ XmlAnyListConverter();
                /*0xfedd1c*/ XmlAnyListConverter(System.Xml.Schema.XmlBaseConverter atomicConverter);
                /*0xfedd90*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
            }

            class XmlListConverter : System.Xml.Schema.XmlBaseConverter
            {
                /*0x28*/ System.Xml.Schema.XmlValueConverter atomicConverter;

                static /*0xfee138*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlValueConverter atomicConverter);
                /*0xfedd20*/ XmlListConverter(System.Xml.Schema.XmlBaseConverter atomicConverter);
                /*0xfe3d64*/ XmlListConverter(System.Xml.Schema.XmlBaseConverter atomicConverter, System.Type clrTypeDefault);
                /*0xfe3c64*/ XmlListConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0xfee2e4*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0xfe9970*/ object ChangeListType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0xfee3ec*/ bool IsListType(System.Type type);
                T[] ToArray<T>(object list, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0xfeec44*/ System.Collections.IList ToList(object list, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0xfeeb94*/ System.Collections.Generic.List<string> StringAsList(string value);
                /*0xfee7e8*/ string ListAsString(System.Collections.IEnumerable list, System.Xml.IXmlNamespaceResolver nsResolver);
                /*0xfee57c*/ System.Exception CreateInvalidClrMappingException(System.Type sourceType, System.Type destinationType);
            }

            class XmlUnionConverter : System.Xml.Schema.XmlBaseConverter
            {
                /*0x28*/ System.Xml.Schema.XmlValueConverter[] converters;
                /*0x30*/ bool hasAtomicMember;
                /*0x31*/ bool hasListMember;

                static /*0xfef4d0*/ System.Xml.Schema.XmlValueConverter Create(System.Xml.Schema.XmlSchemaType schemaType);
                /*0xfef288*/ XmlUnionConverter(System.Xml.Schema.XmlSchemaType schemaType);
                /*0xfef530*/ object ChangeType(object value, System.Type destinationType, System.Xml.IXmlNamespaceResolver nsResolver);
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

                static /*0xff5aa0*/ XsdBuilder();
                static /*0xff15c8*/ void BuildAnnotated_Id(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff15ec*/ void BuildSchema_AttributeFormDefault(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff1760*/ void BuildSchema_ElementFormDefault(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff1800*/ void BuildSchema_TargetNamespace(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff1820*/ void BuildSchema_Version(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff1840*/ void BuildSchema_FinalDefault(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff1afc*/ void BuildSchema_BlockDefault(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff1b64*/ void InitSchema(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff1b88*/ void InitInclude(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff1c34*/ void BuildInclude_SchemaLocation(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff1c54*/ void InitImport(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff1d00*/ void BuildImport_Namespace(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff1d20*/ void BuildImport_SchemaLocation(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff1d40*/ void InitRedefine(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff1dec*/ void BuildRedefine_SchemaLocation(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff1e0c*/ void EndRedefine(System.Xml.Schema.XsdBuilder builder);
                static /*0xff1e28*/ void InitAttribute(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff20d8*/ void BuildAttribute_Default(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff20f8*/ void BuildAttribute_Fixed(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff2118*/ void BuildAttribute_Form(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff21b8*/ void BuildAttribute_Use(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff2258*/ void BuildAttribute_Ref(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff242c*/ void BuildAttribute_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff244c*/ void BuildAttribute_Type(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff24bc*/ void InitElement(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff25b0*/ void BuildElement_Abstract(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff272c*/ void BuildElement_Block(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff2794*/ void BuildElement_Default(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff27b4*/ void BuildElement_Form(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff2854*/ void BuildElement_SubstitutionGroup(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff28c4*/ void BuildElement_Final(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff292c*/ void BuildElement_Fixed(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff294c*/ void BuildElement_MaxOccurs(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff2a28*/ void BuildElement_MinOccurs(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff2b04*/ void BuildElement_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff2b24*/ void BuildElement_Nillable(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff2b94*/ void BuildElement_Ref(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff2c04*/ void BuildElement_Type(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff2c74*/ void InitSimpleType(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff2f44*/ void BuildSimpleType_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff2f64*/ void BuildSimpleType_Final(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff2fcc*/ void InitSimpleTypeUnion(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff3074*/ void BuildSimpleTypeUnion_MemberTypes(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff3258*/ void InitSimpleTypeList(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff3300*/ void BuildSimpleTypeList_ItemType(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff3370*/ void InitSimpleTypeRestriction(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff3418*/ void BuildSimpleTypeRestriction_Base(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff3488*/ void InitComplexType(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff35e8*/ void BuildComplexType_Abstract(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff3658*/ void BuildComplexType_Block(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff36c0*/ void BuildComplexType_Final(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff3728*/ void BuildComplexType_Mixed(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff37a0*/ void BuildComplexType_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff37c0*/ void InitComplexContent(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff38ac*/ void BuildComplexContent_Mixed(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff391c*/ void InitComplexContentExtension(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff39f0*/ void BuildComplexContentExtension_Base(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff3a60*/ void InitComplexContentRestriction(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff3ae0*/ void BuildComplexContentRestriction_Base(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff3b50*/ void InitSimpleContent(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff3c3c*/ void InitSimpleContentExtension(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff3d10*/ void BuildSimpleContentExtension_Base(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff3d80*/ void InitSimpleContentRestriction(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff3e54*/ void BuildSimpleContentRestriction_Base(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff3ec4*/ void InitAttributeGroup(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff3f80*/ void BuildAttributeGroup_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff3fa0*/ void InitAttributeGroupRef(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff4010*/ void BuildAttributeGroupRef_Ref(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff4080*/ void InitAnyAttribute(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff42a4*/ void BuildAnyAttribute_Namespace(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff42c4*/ void BuildAnyAttribute_ProcessContents(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff4364*/ void InitGroup(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff4420*/ void BuildGroup_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff4440*/ void InitGroupRef(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff47a8*/ void BuildParticle_MaxOccurs(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff47c4*/ void BuildParticle_MinOccurs(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff47e0*/ void BuildGroupRef_Ref(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff4850*/ void InitAll(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff48c4*/ void InitChoice(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff4938*/ void InitSequence(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff49a8*/ void InitAny(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff4a1c*/ void BuildAny_Namespace(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff4a3c*/ void BuildAny_ProcessContents(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff4adc*/ void InitNotation(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff4b60*/ void BuildNotation_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff4b80*/ void BuildNotation_Public(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff4ba0*/ void BuildNotation_System(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff4bc0*/ void InitFacet(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff4ef4*/ void BuildFacet_Fixed(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff4f6c*/ void BuildFacet_Value(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff4f8c*/ void InitIdentityConstraint(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff50d4*/ void BuildIdentityConstraint_Name(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff50f4*/ void BuildIdentityConstraint_Refer(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff5214*/ void InitSelector(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff52bc*/ void BuildSelector_XPath(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff52dc*/ void InitField(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff5390*/ void BuildField_XPath(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff53b0*/ void InitAnnotation(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff547c*/ void InitAppinfo(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff5524*/ void BuildAppinfo_Source(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff5590*/ void EndAppinfo(System.Xml.Schema.XsdBuilder builder);
                static /*0xff55b4*/ void InitDocumentation(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff565c*/ void BuildDocumentation_Source(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff56c4*/ void BuildDocumentation_XmlLang(System.Xml.Schema.XsdBuilder builder, string value);
                static /*0xff5804*/ void EndDocumentation(System.Xml.Schema.XsdBuilder builder);
                static /*0xff558c*/ string ParseUriReference(string s);
                /*0xfef950*/ XsdBuilder(System.Xml.XmlReader reader, System.Xml.XmlNamespaceManager curmgr, System.Xml.Schema.XmlSchema schema, System.Xml.XmlNameTable nameTable, System.Xml.Schema.SchemaNames schemaNames, System.Xml.Schema.ValidationEventHandler eventhandler);
                /*0xfefb18*/ bool ProcessElement(string prefix, string name, string ns);
                /*0xfeffd4*/ void ProcessAttribute(string prefix, string name, string ns, string value);
                /*0xff0570*/ bool IsContentParsed();
                /*0xff058c*/ void ProcessMarkup(System.Xml.XmlNode[] markup);
                /*0xff0594*/ void ProcessCData(string value);
                /*0xff05ec*/ void StartChildren();
                /*0xff0770*/ void EndChildren();
                /*0xfefd8c*/ void Push();
                /*0xff07ac*/ void Pop();
                /*0xff14a4*/ System.Xml.Schema.SchemaNames.Token get_CurrentElement();
                /*0xff14c0*/ System.Xml.Schema.SchemaNames.Token get_ParentElement();
                /*0xff1538*/ System.Xml.Schema.XmlSchemaObject get_ParentContainer();
                /*0xff0868*/ System.Xml.Schema.XmlSchemaObject GetContainer(System.Xml.Schema.XsdBuilder.State state);
                /*0xff09a0*/ void SetContainer(System.Xml.Schema.XsdBuilder.State state, object container);
                /*0xff1ed0*/ void AddAttribute(System.Xml.Schema.XmlSchemaObject value);
                /*0xff44b4*/ void AddParticle(System.Xml.Schema.XmlSchemaParticle particle);
                /*0xfefc30*/ bool GetNextState(System.Xml.XmlQualifiedName qname);
                /*0xfefec0*/ bool IsSkipableElement(System.Xml.XmlQualifiedName qname);
                /*0xff2a44*/ void SetMinOccurs(System.Xml.Schema.XmlSchemaParticle particle, string value);
                /*0xff2968*/ void SetMaxOccurs(System.Xml.Schema.XmlSchemaParticle particle, string value);
                /*0xff2620*/ bool ParseBoolean(string value, string attributeName);
                /*0xff168c*/ int ParseEnum(string value, string attributeName, string[] values);
                /*0xff22c8*/ System.Xml.XmlQualifiedName ParseQName(string value, string attributeName);
                /*0xff18a8*/ int ParseBlockFinalEnum(string value, string attributeName);
                /*0xff5828*/ void SendValidationEvent(string code, string arg0, string arg1, string arg2);
                /*0xfefee8*/ void SendValidationEvent(string code, string msg);
                /*0xff0478*/ void SendValidationEvent(string code, string[] args, System.Xml.Schema.XmlSeverityType severity);
                /*0xff59c8*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e, System.Xml.Schema.XmlSeverityType severity);
                /*0xff3250*/ void SendValidationEvent(System.Xml.Schema.XmlSchemaException e);
                /*0xfefe24*/ void RecordPosition();

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
                    /*0x10cc548*/ XsdBuildFunction(object object, nint method);
                    /*0x10cc620*/ void Invoke(System.Xml.Schema.XsdBuilder builder, string value);
                }

                class XsdInitFunction : System.MulticastDelegate
                {
                    /*0x10cc634*/ XsdInitFunction(object object, nint method);
                    /*0x10cc70c*/ void Invoke(System.Xml.Schema.XsdBuilder builder, string value);
                }

                class XsdEndChildFunction : System.MulticastDelegate
                {
                    /*0x10cc720*/ XsdEndChildFunction(object object, nint method);
                    /*0x10cc7f4*/ void Invoke(System.Xml.Schema.XsdBuilder builder);
                }

                class XsdAttributeEntry
                {
                    /*0x10*/ System.Xml.Schema.SchemaNames.Token Attribute;
                    /*0x18*/ System.Xml.Schema.XsdBuilder.XsdBuildFunction BuildFunc;

                    /*0x10cc808*/ XsdAttributeEntry(System.Xml.Schema.SchemaNames.Token a, System.Xml.Schema.XsdBuilder.XsdBuildFunction build);
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

                    /*0x10cc838*/ XsdEntry(System.Xml.Schema.SchemaNames.Token n, System.Xml.Schema.XsdBuilder.State state, System.Xml.Schema.XsdBuilder.State[] nextStates, System.Xml.Schema.XsdBuilder.XsdAttributeEntry[] attributes, System.Xml.Schema.XsdBuilder.XsdInitFunction init, System.Xml.Schema.XsdBuilder.XsdEndChildFunction end, bool parseContent);
                }

                class BuilderNamespaceManager : System.Xml.XmlNamespaceManager
                {
                    /*0x50*/ System.Xml.XmlNamespaceManager nsMgr;
                    /*0x58*/ System.Xml.XmlReader reader;

                    /*0x10cc89c*/ BuilderNamespaceManager(System.Xml.XmlNamespaceManager nsMgr, System.Xml.XmlReader reader);
                    /*0x10cc8c8*/ string LookupNamespace(string prefix);
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

                static /*0x10ce800*/ XsdDateTime();
                static /*0x10cd3c0*/ bool TryParse(string text, System.Xml.Schema.XsdDateTimeFlags kinds, ref System.Xml.Schema.XsdDateTime result);
                static /*0x10cd7d4*/ System.DateTime op_Implicit(System.Xml.Schema.XsdDateTime xdt);
                static /*0x10cdbf4*/ System.DateTimeOffset op_Implicit(System.Xml.Schema.XsdDateTime xdt);
                /*0x10cc928*/ XsdDateTime(string text, System.Xml.Schema.XsdDateTimeFlags kinds);
                /*0x10cd390*/ XsdDateTime(System.Xml.Schema.XsdDateTime.Parser parser);
                /*0x10cd434*/ XsdDateTime(System.DateTime dateTime, System.Xml.Schema.XsdDateTimeFlags kinds);
                /*0x10cd590*/ XsdDateTime(System.DateTimeOffset dateTimeOffset);
                /*0x10cd598*/ XsdDateTime(System.DateTimeOffset dateTimeOffset, System.Xml.Schema.XsdDateTimeFlags kinds);
                /*0x10cd314*/ void InitiateXsdDateTime(System.Xml.Schema.XsdDateTime.Parser parser);
                /*0x10cd6ac*/ System.Xml.Schema.XsdDateTime.DateTimeTypeCode get_InternalTypeCode();
                /*0x10cd6b4*/ System.Xml.Schema.XsdDateTime.XsdDateTimeKind get_InternalKind();
                /*0x10cd6bc*/ int get_Year();
                /*0x10cd6c4*/ int get_Month();
                /*0x10cd6cc*/ int get_Day();
                /*0x10cd6d4*/ int get_Hour();
                /*0x10cd6dc*/ int get_Minute();
                /*0x10cd6e4*/ int get_Second();
                /*0x10cd6ec*/ int get_Fraction();
                /*0x10cd7c4*/ int get_ZoneHour();
                /*0x10cd7cc*/ int get_ZoneMinute();
                /*0x10cde74*/ string ToString();
                /*0x10ce24c*/ void PrintDate(System.Text.StringBuilder sb);
                /*0x10ce39c*/ void PrintTime(System.Text.StringBuilder sb);
                /*0x10ce678*/ void PrintZone(System.Text.StringBuilder sb);
                /*0x10ce5a8*/ void IntToCharArray(char[] text, int start, int value, int digits);
                /*0x10ce610*/ void ShortToCharArray(char[] text, int start, int value);

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

                    static /*0x10cf4e4*/ Parser();
                    static /*0x10cebb0*/ bool Test(System.Xml.Schema.XsdDateTimeFlags left, System.Xml.Schema.XsdDateTimeFlags right);
                    /*0x10cca64*/ bool Parse(string text, System.Xml.Schema.XsdDateTimeFlags kinds);
                    /*0x10cebbc*/ bool ParseDate(int start);
                    /*0x10ceda0*/ bool ParseTimeAndZoneAndWhitespace(int start);
                    /*0x10ceff8*/ bool ParseTimeAndWhitespace(int start);
                    /*0x10cf1f4*/ bool ParseTime(ref int start);
                    /*0x10cede4*/ bool ParseZoneAndWhitespace(int start);
                    /*0x10cf050*/ bool Parse4Dig(int start, ref int num);
                    /*0x10cf15c*/ bool Parse2Dig(int start, ref int num);
                    /*0x10ced5c*/ bool ParseChar(int start, char ch);
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

                static /*0x10d0a50*/ System.Exception TryParse(string s, ref System.Xml.Schema.XsdDuration result);
                static /*0x10cf9dc*/ System.Exception TryParse(string s, System.Xml.Schema.XsdDuration.DurationType durationType, ref System.Xml.Schema.XsdDuration result);
                static /*0x10d0a5c*/ string TryParseDigits(string s, ref int offset, bool eatDigits, ref int result, ref int numDigits);
                /*0x10cf578*/ XsdDuration(bool isNegative, int years, int months, int days, int hours, int minutes, int seconds, int nanoseconds);
                /*0x10cf6f0*/ XsdDuration(System.TimeSpan timeSpan);
                /*0x10cf7c8*/ XsdDuration(System.TimeSpan timeSpan, System.Xml.Schema.XsdDuration.DurationType durationType);
                /*0x10cf948*/ XsdDuration(string s);
                /*0x10cf950*/ XsdDuration(string s, System.Xml.Schema.XsdDuration.DurationType durationType);
                /*0x10d00d4*/ bool get_IsNegative();
                /*0x10d00e0*/ int get_Years();
                /*0x10d00e8*/ int get_Months();
                /*0x10d00f0*/ int get_Days();
                /*0x10d00f8*/ int get_Hours();
                /*0x10d0100*/ int get_Minutes();
                /*0x10d0108*/ int get_Seconds();
                /*0x10d00c8*/ int get_Nanoseconds();
                /*0x10d0110*/ System.TimeSpan ToTimeSpan();
                /*0x10d0118*/ System.TimeSpan ToTimeSpan(System.Xml.Schema.XsdDuration.DurationType durationType);
                /*0x10d0640*/ System.Exception TryToTimeSpan(ref System.TimeSpan result);
                /*0x10d0160*/ System.Exception TryToTimeSpan(System.Xml.Schema.XsdDuration.DurationType durationType, ref System.TimeSpan result);
                /*0x10d064c*/ string ToString();
                /*0x10d0654*/ string ToString(System.Xml.Schema.XsdDuration.DurationType durationType);

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

                static /*0x10d5c08*/ XsdValidator();
                /*0x10d0c18*/ XsdValidator(System.Xml.Schema.BaseValidator validator);
                /*0x10d0f70*/ XsdValidator(System.Xml.XmlValidatingReaderImpl reader, System.Xml.Schema.XmlSchemaCollection schemaCollection, System.Xml.IValidationEventHandling eventHandling);
                /*0x10d0c3c*/ void Init();
                /*0x10d1078*/ void Validate();
                /*0x10d1734*/ void CompleteValidation();
                /*0x10d1130*/ bool get_IsInlineSchemaStarted();
                /*0x10d1140*/ void ProcessInlineSchema();
                /*0x10d13f4*/ void ValidateElement();
                /*0x10d1840*/ object ValidateChildElement();
                /*0x10d1a7c*/ void ProcessElement(object particle);
                /*0x10d1d88*/ void ProcessXsiAttributes(ref System.Xml.XmlQualifiedName xsiType, ref string xsiNil);
                /*0x10d1550*/ void ValidateEndElement();
                /*0x10d1cac*/ System.Xml.Schema.SchemaElementDecl FastGetElementDecl(object particle);
                /*0x10d255c*/ System.Xml.Schema.SchemaElementDecl ThoroughGetElementDecl(System.Xml.Schema.SchemaElementDecl elementDecl, System.Xml.XmlQualifiedName xsiType, string xsiNil);
                /*0x10d29e8*/ void ValidateStartElement();
                /*0x10d30a0*/ void ValidateEndStartElement();
                /*0x10d4bf8*/ void LoadSchemaFromLocation(string uri, string url);
                /*0x10d3484*/ void LoadSchema(string uri, string url);
                /*0x10d2978*/ bool get_HasSchema();
                /*0x10d51d0*/ bool get_PreserveWhitespace();
                /*0x10d5208*/ void ProcessTokenizedType(System.Xml.XmlTokenizedType ttype, string name);
                /*0x10d3648*/ void CheckValue(string value, System.Xml.Schema.SchemaAttDef attdef);
                /*0x10d5410*/ void AddID(string name, object node);
                /*0x10d54a0*/ object FindId(string name);
                /*0x10d1a2c*/ bool IsXSDRoot(string localName, string ns);
                /*0x10d0f94*/ void Push(System.Xml.XmlQualifiedName elementName);
                /*0x10d47d4*/ void Pop();
                /*0x10d1738*/ void CheckForwardRefs();
                /*0x10d299c*/ void ValidateStartElementIdentityConstraints();
                /*0x10d3aac*/ bool get_HasIdentityConstraints();
                /*0x10d54bc*/ void AddIdentityConstraints();
                /*0x10d58c0*/ void ElementIdentityConstraints();
                /*0x10d4918*/ void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, System.Xml.Schema.SchemaAttDef attdef);
                /*0x10d4894*/ object UnWrapUnion(object typedValue);
                /*0x10d3abc*/ void EndElementIdentityConstraints();
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
                    /*0x10d5ca4*/ AstNode();
                    MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    System.Xml.XPath.XPathResultType get_ReturnType();

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

                    /*0x10d5cac*/ Axis(MS.Internal.Xml.XPath.Axis.AxisType axisType, MS.Internal.Xml.XPath.AstNode input, string prefix, string name, System.Xml.XPath.XPathNodeType nodetype);
                    /*0x10d5d44*/ Axis(MS.Internal.Xml.XPath.Axis.AxisType axisType, MS.Internal.Xml.XPath.AstNode input);
                    /*0x10d5dc0*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x10d5dc8*/ System.Xml.XPath.XPathResultType get_ReturnType();
                    /*0x10d5dd0*/ MS.Internal.Xml.XPath.AstNode get_Input();
                    /*0x10d5dd8*/ void set_Input(MS.Internal.Xml.XPath.AstNode value);
                    /*0x10d5de0*/ string get_Prefix();
                    /*0x10d5de8*/ string get_Name();
                    /*0x10d5df0*/ System.Xml.XPath.XPathNodeType get_NodeType();
                    /*0x10d5df8*/ MS.Internal.Xml.XPath.Axis.AxisType get_TypeOfAxis();
                    /*0x10d5e00*/ bool get_AbbrAxis();
                    /*0x10d5e08*/ string get_Urn();
                    /*0x10d5e10*/ void set_Urn(string value);

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

                    /*0x10d5e18*/ Filter(MS.Internal.Xml.XPath.AstNode input, MS.Internal.Xml.XPath.AstNode condition);
                    /*0x10d5e44*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x10d5e4c*/ System.Xml.XPath.XPathResultType get_ReturnType();
                }

                class Function : MS.Internal.Xml.XPath.AstNode
                {
                    static /*0x0*/ System.Xml.XPath.XPathResultType[] ReturnTypes;
                    /*0x10*/ MS.Internal.Xml.XPath.Function.FunctionType _functionType;
                    /*0x18*/ System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> _argumentList;
                    /*0x20*/ string _name;
                    /*0x28*/ string _prefix;

                    static /*0x10d6128*/ Function();
                    /*0x10d5e54*/ Function(MS.Internal.Xml.XPath.Function.FunctionType ftype, System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> argumentList);
                    /*0x10d5eec*/ Function(string prefix, string name, System.Collections.Generic.List<MS.Internal.Xml.XPath.AstNode> argumentList);
                    /*0x10d5f98*/ Function(MS.Internal.Xml.XPath.Function.FunctionType ftype, MS.Internal.Xml.XPath.AstNode arg);
                    /*0x10d60a0*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x10d60a8*/ System.Xml.XPath.XPathResultType get_ReturnType();

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

                    /*0x10d61bc*/ Group(MS.Internal.Xml.XPath.AstNode groupNode);
                    /*0x10d61e4*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x10d61ec*/ System.Xml.XPath.XPathResultType get_ReturnType();
                }

                class Operand : MS.Internal.Xml.XPath.AstNode
                {
                    /*0x10*/ System.Xml.XPath.XPathResultType _type;
                    /*0x18*/ object _val;

                    /*0x10d61f4*/ Operand(string val);
                    /*0x10d6224*/ Operand(double val);
                    /*0x10d6294*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x10d629c*/ System.Xml.XPath.XPathResultType get_ReturnType();
                }

                class Operator : MS.Internal.Xml.XPath.AstNode
                {
                    static /*0x0*/ MS.Internal.Xml.XPath.Operator.Op[] s_invertOp;
                    /*0x10*/ MS.Internal.Xml.XPath.Operator.Op _opType;
                    /*0x18*/ MS.Internal.Xml.XPath.AstNode _opnd1;
                    /*0x20*/ MS.Internal.Xml.XPath.AstNode _opnd2;

                    static /*0x10d630c*/ Operator();
                    /*0x10d62a4*/ Operator(MS.Internal.Xml.XPath.Operator.Op op, MS.Internal.Xml.XPath.AstNode opnd1, MS.Internal.Xml.XPath.AstNode opnd2);
                    /*0x10d62e0*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x10d62e8*/ System.Xml.XPath.XPathResultType get_ReturnType();

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
                    /*0x10d63a0*/ Root();
                    /*0x10d63a8*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x10d63b0*/ System.Xml.XPath.XPathResultType get_ReturnType();
                }

                class Variable : MS.Internal.Xml.XPath.AstNode
                {
                    /*0x10*/ string _localname;
                    /*0x18*/ string _prefix;

                    /*0x10d63b8*/ Variable(string name, string prefix);
                    /*0x10d63e4*/ MS.Internal.Xml.XPath.AstNode.AstType get_Type();
                    /*0x10d63ec*/ System.Xml.XPath.XPathResultType get_ReturnType();
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

                    static /*0x10d93f8*/ XPathParser();
                    static /*0x10d641c*/ MS.Internal.Xml.XPath.AstNode ParseXPathExpression(string xpathExpression);
                    static /*0x10d6f98*/ bool IsNodeType(MS.Internal.Xml.XPath.XPathScanner scaner);
                    static /*0x10d76a8*/ bool IsStep(MS.Internal.Xml.XPath.XPathScanner.LexKind lexKind);
                    static /*0x10d708c*/ bool IsPrimaryExpr(MS.Internal.Xml.XPath.XPathScanner scanner);
                    static /*0x10d85e0*/ System.Collections.Generic.Dictionary<string, MS.Internal.Xml.XPath.XPathParser.ParamInfo> CreateFunctionTable();
                    static /*0x10d9148*/ System.Collections.Generic.Dictionary<string, MS.Internal.Xml.XPath.Axis.AxisType> CreateAxesTable();
                    /*0x10d63f4*/ XPathParser(MS.Internal.Xml.XPath.XPathScanner scanner);
                    /*0x10d6598*/ MS.Internal.Xml.XPath.AstNode ParseExpression(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x10d65fc*/ MS.Internal.Xml.XPath.AstNode ParseOrExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x10d66f0*/ MS.Internal.Xml.XPath.AstNode ParseAndExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x10d6848*/ MS.Internal.Xml.XPath.AstNode ParseEqualityExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x10d6924*/ MS.Internal.Xml.XPath.AstNode ParseRelationalExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x10d6a28*/ MS.Internal.Xml.XPath.AstNode ParseAdditiveExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x10d6b04*/ MS.Internal.Xml.XPath.AstNode ParseMultiplicativeExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x10d6c34*/ MS.Internal.Xml.XPath.AstNode ParseUnaryExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x10d6d18*/ MS.Internal.Xml.XPath.AstNode ParseUnionExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x10d6e20*/ MS.Internal.Xml.XPath.AstNode ParsePathExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x10d713c*/ MS.Internal.Xml.XPath.AstNode ParseFilterExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x10d761c*/ MS.Internal.Xml.XPath.AstNode ParsePredicate(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x10d72bc*/ MS.Internal.Xml.XPath.AstNode ParseLocationPath(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x10d71f0*/ MS.Internal.Xml.XPath.AstNode ParseRelativeLocationPath(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x10d76f0*/ MS.Internal.Xml.XPath.AstNode ParseStep(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x10d7960*/ MS.Internal.Xml.XPath.AstNode ParseNodeTest(MS.Internal.Xml.XPath.AstNode qyInput, MS.Internal.Xml.XPath.Axis.AxisType axisType, System.Xml.XPath.XPathNodeType nodeType);
                    /*0x10d740c*/ MS.Internal.Xml.XPath.AstNode ParsePrimaryExpr(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x10d7cb8*/ MS.Internal.Xml.XPath.AstNode ParseMethod(MS.Internal.Xml.XPath.AstNode qyInput);
                    /*0x10d7c54*/ void CheckToken(MS.Internal.Xml.XPath.XPathScanner.LexKind t);
                    /*0x10d7688*/ void PassToken(MS.Internal.Xml.XPath.XPathScanner.LexKind t);
                    /*0x10d6830*/ void NextLex();
                    /*0x10d67e4*/ bool TestOp(string op);
                    /*0x10d6f3c*/ void CheckNodeSet(System.Xml.XPath.XPathResultType t);
                    /*0x10d7878*/ MS.Internal.Xml.XPath.Axis.AxisType GetAxis();

                    class ParamInfo
                    {
                        /*0x10*/ MS.Internal.Xml.XPath.Function.FunctionType _ftype;
                        /*0x14*/ int _minargs;
                        /*0x18*/ int _maxargs;
                        /*0x20*/ System.Xml.XPath.XPathResultType[] _argTypes;

                        /*0x10d9104*/ ParamInfo(MS.Internal.Xml.XPath.Function.FunctionType ftype, int minargs, int maxargs, System.Xml.XPath.XPathResultType[] argTypes);
                        /*0x10d9638*/ MS.Internal.Xml.XPath.Function.FunctionType get_FType();
                        /*0x10d9640*/ int get_Minargs();
                        /*0x10d9648*/ int get_Maxargs();
                        /*0x10d9650*/ System.Xml.XPath.XPathResultType[] get_ArgTypes();
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

                    /*0x10d6500*/ XPathScanner(string xpathExpr);
                    /*0x10d96ac*/ string get_SourceText();
                    /*0x10d96b4*/ char get_CurrentChar();
                    /*0x10d9658*/ bool NextChar();
                    /*0x10d96bc*/ MS.Internal.Xml.XPath.XPathScanner.LexKind get_Kind();
                    /*0x10d96c4*/ string get_Name();
                    /*0x10d96cc*/ string get_Prefix();
                    /*0x10d96d4*/ string get_StringValue();
                    /*0x10d96dc*/ double get_NumberValue();
                    /*0x10d96e4*/ bool get_CanBeFunction();
                    /*0x10d96ec*/ void SkipSpace();
                    /*0x10d8224*/ bool NextLex();
                    /*0x10d9888*/ double ScanNumber();
                    /*0x10d9728*/ double ScanFraction();
                    /*0x10d97d8*/ string ScanString();
                    /*0x10d9960*/ string ScanName();

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

                    /*0x10d99d8*/ XPathDocumentNavigator(MS.Internal.Xml.Cache.XPathNode[] pageCurrent, int idxCurrent, MS.Internal.Xml.Cache.XPathNode[] pageParent, int idxParent);
                    /*0x10d9a5c*/ string get_Value();
                    /*0x10d9e38*/ System.Xml.XPath.XPathNavigator Clone();
                    /*0x10d9eb4*/ System.Xml.XPath.XPathNodeType get_NodeType();
                    /*0x10d9ef8*/ string get_LocalName();
                    /*0x10d9f50*/ string get_NamespaceURI();
                    /*0x10d9fa8*/ string get_Prefix();
                    /*0x10da000*/ System.Xml.XmlNameTable get_NameTable();
                    /*0x10da060*/ bool MoveToFirstNamespace(System.Xml.XPath.XPathNamespaceScope namespaceScope);
                    /*0x10da31c*/ bool MoveToNextNamespace(System.Xml.XPath.XPathNamespaceScope scope);
                    /*0x10da448*/ bool MoveToParent();
                    /*0x10da4cc*/ bool IsSamePosition(System.Xml.XPath.XPathNavigator other);
                    /*0x10da578*/ object get_UnderlyingObject();
                    /*0x10da588*/ bool HasLineInfo();
                    /*0x10da5cc*/ int get_LineNumber();
                    /*0x10da678*/ int get_LinePosition();
                    /*0x10da76c*/ int GetPositionHashCode();
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

                    /*0x10d9eec*/ System.Xml.XPath.XPathNodeType get_NodeType();
                    /*0x10d9fe4*/ string get_Prefix();
                    /*0x10d9f34*/ string get_LocalName();
                    /*0x10d9f8c*/ string get_NamespaceUri();
                    /*0x10da044*/ System.Xml.XPath.XPathDocument get_Document();
                    /*0x10da650*/ int get_LineNumber();
                    /*0x10da748*/ int get_LinePosition();
                    /*0x10da71c*/ int get_CollapsedLinePosition();
                    /*0x10da778*/ MS.Internal.Xml.Cache.XPathNodePageInfo get_PageInfo();
                    /*0x10da424*/ int GetParent(ref MS.Internal.Xml.Cache.XPathNode[] pageNode);
                    /*0x10da2f8*/ int GetSibling(ref MS.Internal.Xml.Cache.XPathNode[] pageNode);
                    /*0x10da270*/ bool get_IsXmlNamespaceNode();
                    /*0x10da794*/ bool get_HasSibling();
                    /*0x10da7a4*/ bool get_HasCollapsedText();
                    /*0x10da7b0*/ bool get_IsText();
                    /*0x10da810*/ bool get_HasNamespaceDecls();
                    /*0x10da81c*/ string get_Value();
                }

                struct XPathNodeRef
                {
                    /*0x10*/ MS.Internal.Xml.Cache.XPathNode[] _page;
                    /*0x18*/ int _idx;

                    /*0x10da824*/ XPathNodeRef(MS.Internal.Xml.Cache.XPathNode[] page, int idx);
                    /*0x10da830*/ MS.Internal.Xml.Cache.XPathNode[] get_Page();
                    /*0x10da838*/ int get_Index();
                    /*0x10da840*/ int GetHashCode();
                }

                class XPathNodeHelper
                {
                    static /*0x10da154*/ int GetLocalNamespaces(MS.Internal.Xml.Cache.XPathNode[] pageElem, int idxElem, ref MS.Internal.Xml.Cache.XPathNode[] pageNmsp);
                    static /*0x10da1b8*/ int GetInScopeNamespaces(MS.Internal.Xml.Cache.XPathNode[] pageElem, int idxElem, ref MS.Internal.Xml.Cache.XPathNode[] pageNmsp);
                    static /*0x10da474*/ bool GetParent(ref MS.Internal.Xml.Cache.XPathNode[] pageNode, ref int idxNode);
                    static /*0x10da850*/ int GetLocation(MS.Internal.Xml.Cache.XPathNode[] pageNode, int idxNode);
                    static /*0x10d9cd8*/ bool GetTextFollowing(ref MS.Internal.Xml.Cache.XPathNode[] pageCurrent, ref int idxCurrent, MS.Internal.Xml.Cache.XPathNode[] pageEnd, int idxEnd);
                    static /*0x10d9c58*/ bool GetNonDescendant(ref MS.Internal.Xml.Cache.XPathNode[] pageNode, ref int idxNode);
                }

                class XPathNodePageInfo
                {
                    /*0x10*/ int _pageNum;
                    /*0x14*/ int _nodeCount;
                    /*0x18*/ MS.Internal.Xml.Cache.XPathNode[] _pageNext;

                    /*0x10da888*/ int get_PageNumber();
                    /*0x10da890*/ int get_NodeCount();
                    /*0x10da898*/ MS.Internal.Xml.Cache.XPathNode[] get_NextPage();
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

                    /*0x10da8a0*/ MS.Internal.Xml.Cache.XPathNodePageInfo get_PageInfo();
                    /*0x10da8a8*/ string get_LocalName();
                    /*0x10da8b0*/ string get_NamespaceUri();
                    /*0x10da8b8*/ string get_Prefix();
                    /*0x10da8c0*/ MS.Internal.Xml.Cache.XPathNode[] get_SiblingPage();
                    /*0x10da8c8*/ MS.Internal.Xml.Cache.XPathNode[] get_ParentPage();
                    /*0x10da8d0*/ System.Xml.XPath.XPathDocument get_Document();
                    /*0x10da8d8*/ int get_LineNumberBase();
                    /*0x10da8e0*/ int get_LinePositionBase();
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

    static /*0x10da8e8*/ uint ComputeStringHash(string s);

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
