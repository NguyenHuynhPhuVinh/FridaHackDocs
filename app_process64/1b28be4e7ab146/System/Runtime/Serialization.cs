class <Module>
{
}

namespace System
{
    class LocalAppContextSwitches
    {
        static /*0x0*/ bool DoNotUseTimeZoneInfo;
        static /*0x1*/ bool DoNotUseEcmaScriptV6EscapeControlCharacter;
    }

    namespace Xml
    {
        class ArrayHelper<TArgument, TArray>
        {
            /*0x38159dc*/ ArrayHelper();
            /*0x3910ae8*/ TArray[] ReadArray(System.Xml.XmlDictionaryReader reader, TArgument localName, TArgument namespaceUri, int maxArrayLength);
            /*0x3910ae8*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, TArgument localName, TArgument namespaceUri, System.Xml.XmlDictionaryReader reader);
            /*0x3910ae8*/ int ReadArray(System.Xml.XmlDictionaryReader reader, TArgument localName, TArgument namespaceUri, TArray[] array, int offset, int count);
            /*0x3910ae8*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, TArgument localName, TArgument namespaceUri, TArray[] array, int offset, int count);
        }

        class BooleanArrayHelperWithString : System.Xml.ArrayHelper<string, bool>
        {
            static /*0x0*/ System.Xml.BooleanArrayHelperWithString Instance;

            static /*0x757c9e8*/ BooleanArrayHelperWithString();
            /*0x757c9a0*/ BooleanArrayHelperWithString();
            /*0x757c924*/ int ReadArray(System.Xml.XmlDictionaryReader reader, string localName, string namespaceUri, bool[] array, int offset, int count);
            /*0x757c960*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, bool[] array, int offset, int count);
        }

        class BooleanArrayHelperWithDictionaryString : System.Xml.ArrayHelper<System.Xml.XmlDictionaryString, bool>
        {
            static /*0x0*/ System.Xml.BooleanArrayHelperWithDictionaryString Instance;

            static /*0x757cb10*/ BooleanArrayHelperWithDictionaryString();
            /*0x757cac8*/ BooleanArrayHelperWithDictionaryString();
            /*0x757ca4c*/ int ReadArray(System.Xml.XmlDictionaryReader reader, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, bool[] array, int offset, int count);
            /*0x757ca88*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, bool[] array, int offset, int count);
        }

        class Int16ArrayHelperWithString : System.Xml.ArrayHelper<string, short>
        {
            static /*0x0*/ System.Xml.Int16ArrayHelperWithString Instance;

            static /*0x757cc38*/ Int16ArrayHelperWithString();
            /*0x757cbf0*/ Int16ArrayHelperWithString();
            /*0x757cb74*/ int ReadArray(System.Xml.XmlDictionaryReader reader, string localName, string namespaceUri, short[] array, int offset, int count);
            /*0x757cbb0*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, short[] array, int offset, int count);
        }

        class Int16ArrayHelperWithDictionaryString : System.Xml.ArrayHelper<System.Xml.XmlDictionaryString, short>
        {
            static /*0x0*/ System.Xml.Int16ArrayHelperWithDictionaryString Instance;

            static /*0x757cd60*/ Int16ArrayHelperWithDictionaryString();
            /*0x757cd18*/ Int16ArrayHelperWithDictionaryString();
            /*0x757cc9c*/ int ReadArray(System.Xml.XmlDictionaryReader reader, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, short[] array, int offset, int count);
            /*0x757ccd8*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, short[] array, int offset, int count);
        }

        class Int32ArrayHelperWithString : System.Xml.ArrayHelper<string, int>
        {
            static /*0x0*/ System.Xml.Int32ArrayHelperWithString Instance;

            static /*0x757ce88*/ Int32ArrayHelperWithString();
            /*0x757ce40*/ Int32ArrayHelperWithString();
            /*0x757cdc4*/ int ReadArray(System.Xml.XmlDictionaryReader reader, string localName, string namespaceUri, int[] array, int offset, int count);
            /*0x757ce00*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, int[] array, int offset, int count);
        }

        class Int32ArrayHelperWithDictionaryString : System.Xml.ArrayHelper<System.Xml.XmlDictionaryString, int>
        {
            static /*0x0*/ System.Xml.Int32ArrayHelperWithDictionaryString Instance;

            static /*0x757cfb0*/ Int32ArrayHelperWithDictionaryString();
            /*0x757cf68*/ Int32ArrayHelperWithDictionaryString();
            /*0x757ceec*/ int ReadArray(System.Xml.XmlDictionaryReader reader, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, int[] array, int offset, int count);
            /*0x757cf28*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, int[] array, int offset, int count);
        }

        class Int64ArrayHelperWithString : System.Xml.ArrayHelper<string, long>
        {
            static /*0x0*/ System.Xml.Int64ArrayHelperWithString Instance;

            static /*0x757d0d8*/ Int64ArrayHelperWithString();
            /*0x757d090*/ Int64ArrayHelperWithString();
            /*0x757d014*/ int ReadArray(System.Xml.XmlDictionaryReader reader, string localName, string namespaceUri, long[] array, int offset, int count);
            /*0x757d050*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, long[] array, int offset, int count);
        }

        class Int64ArrayHelperWithDictionaryString : System.Xml.ArrayHelper<System.Xml.XmlDictionaryString, long>
        {
            static /*0x0*/ System.Xml.Int64ArrayHelperWithDictionaryString Instance;

            static /*0x757d200*/ Int64ArrayHelperWithDictionaryString();
            /*0x757d1b8*/ Int64ArrayHelperWithDictionaryString();
            /*0x757d13c*/ int ReadArray(System.Xml.XmlDictionaryReader reader, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, long[] array, int offset, int count);
            /*0x757d178*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, long[] array, int offset, int count);
        }

        class SingleArrayHelperWithString : System.Xml.ArrayHelper<string, float>
        {
            static /*0x0*/ System.Xml.SingleArrayHelperWithString Instance;

            static /*0x757d328*/ SingleArrayHelperWithString();
            /*0x757d2e0*/ SingleArrayHelperWithString();
            /*0x757d264*/ int ReadArray(System.Xml.XmlDictionaryReader reader, string localName, string namespaceUri, float[] array, int offset, int count);
            /*0x757d2a0*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, float[] array, int offset, int count);
        }

        class SingleArrayHelperWithDictionaryString : System.Xml.ArrayHelper<System.Xml.XmlDictionaryString, float>
        {
            static /*0x0*/ System.Xml.SingleArrayHelperWithDictionaryString Instance;

            static /*0x757d450*/ SingleArrayHelperWithDictionaryString();
            /*0x757d408*/ SingleArrayHelperWithDictionaryString();
            /*0x757d38c*/ int ReadArray(System.Xml.XmlDictionaryReader reader, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, float[] array, int offset, int count);
            /*0x757d3c8*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, float[] array, int offset, int count);
        }

        class DoubleArrayHelperWithString : System.Xml.ArrayHelper<string, double>
        {
            static /*0x0*/ System.Xml.DoubleArrayHelperWithString Instance;

            static /*0x757d578*/ DoubleArrayHelperWithString();
            /*0x757d530*/ DoubleArrayHelperWithString();
            /*0x757d4b4*/ int ReadArray(System.Xml.XmlDictionaryReader reader, string localName, string namespaceUri, double[] array, int offset, int count);
            /*0x757d4f0*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, double[] array, int offset, int count);
        }

        class DoubleArrayHelperWithDictionaryString : System.Xml.ArrayHelper<System.Xml.XmlDictionaryString, double>
        {
            static /*0x0*/ System.Xml.DoubleArrayHelperWithDictionaryString Instance;

            static /*0x757d6a0*/ DoubleArrayHelperWithDictionaryString();
            /*0x757d658*/ DoubleArrayHelperWithDictionaryString();
            /*0x757d5dc*/ int ReadArray(System.Xml.XmlDictionaryReader reader, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, double[] array, int offset, int count);
            /*0x757d618*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, double[] array, int offset, int count);
        }

        class DecimalArrayHelperWithString : System.Xml.ArrayHelper<string, decimal>
        {
            static /*0x0*/ System.Xml.DecimalArrayHelperWithString Instance;

            static /*0x757d7c8*/ DecimalArrayHelperWithString();
            /*0x757d780*/ DecimalArrayHelperWithString();
            /*0x757d704*/ int ReadArray(System.Xml.XmlDictionaryReader reader, string localName, string namespaceUri, decimal[] array, int offset, int count);
            /*0x757d740*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, decimal[] array, int offset, int count);
        }

        class DecimalArrayHelperWithDictionaryString : System.Xml.ArrayHelper<System.Xml.XmlDictionaryString, decimal>
        {
            static /*0x0*/ System.Xml.DecimalArrayHelperWithDictionaryString Instance;

            static /*0x757d8f0*/ DecimalArrayHelperWithDictionaryString();
            /*0x757d8a8*/ DecimalArrayHelperWithDictionaryString();
            /*0x757d82c*/ int ReadArray(System.Xml.XmlDictionaryReader reader, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, decimal[] array, int offset, int count);
            /*0x757d868*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, decimal[] array, int offset, int count);
        }

        class DateTimeArrayHelperWithString : System.Xml.ArrayHelper<string, System.DateTime>
        {
            static /*0x0*/ System.Xml.DateTimeArrayHelperWithString Instance;

            static /*0x757da18*/ DateTimeArrayHelperWithString();
            /*0x757d9d0*/ DateTimeArrayHelperWithString();
            /*0x757d954*/ int ReadArray(System.Xml.XmlDictionaryReader reader, string localName, string namespaceUri, System.DateTime[] array, int offset, int count);
            /*0x757d990*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, System.DateTime[] array, int offset, int count);
        }

        class DateTimeArrayHelperWithDictionaryString : System.Xml.ArrayHelper<System.Xml.XmlDictionaryString, System.DateTime>
        {
            static /*0x0*/ System.Xml.DateTimeArrayHelperWithDictionaryString Instance;

            static /*0x757db40*/ DateTimeArrayHelperWithDictionaryString();
            /*0x757daf8*/ DateTimeArrayHelperWithDictionaryString();
            /*0x757da7c*/ int ReadArray(System.Xml.XmlDictionaryReader reader, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.DateTime[] array, int offset, int count);
            /*0x757dab8*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.DateTime[] array, int offset, int count);
        }

        class GuidArrayHelperWithString : System.Xml.ArrayHelper<string, System.Guid>
        {
            static /*0x0*/ System.Xml.GuidArrayHelperWithString Instance;

            static /*0x757dc68*/ GuidArrayHelperWithString();
            /*0x757dc20*/ GuidArrayHelperWithString();
            /*0x757dba4*/ int ReadArray(System.Xml.XmlDictionaryReader reader, string localName, string namespaceUri, System.Guid[] array, int offset, int count);
            /*0x757dbe0*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, System.Guid[] array, int offset, int count);
        }

        class GuidArrayHelperWithDictionaryString : System.Xml.ArrayHelper<System.Xml.XmlDictionaryString, System.Guid>
        {
            static /*0x0*/ System.Xml.GuidArrayHelperWithDictionaryString Instance;

            static /*0x757dd90*/ GuidArrayHelperWithDictionaryString();
            /*0x757dd48*/ GuidArrayHelperWithDictionaryString();
            /*0x757dccc*/ int ReadArray(System.Xml.XmlDictionaryReader reader, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Guid[] array, int offset, int count);
            /*0x757dd08*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Guid[] array, int offset, int count);
        }

        class TimeSpanArrayHelperWithString : System.Xml.ArrayHelper<string, System.TimeSpan>
        {
            static /*0x0*/ System.Xml.TimeSpanArrayHelperWithString Instance;

            static /*0x757deb8*/ TimeSpanArrayHelperWithString();
            /*0x757de70*/ TimeSpanArrayHelperWithString();
            /*0x757ddf4*/ int ReadArray(System.Xml.XmlDictionaryReader reader, string localName, string namespaceUri, System.TimeSpan[] array, int offset, int count);
            /*0x757de30*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, System.TimeSpan[] array, int offset, int count);
        }

        class TimeSpanArrayHelperWithDictionaryString : System.Xml.ArrayHelper<System.Xml.XmlDictionaryString, System.TimeSpan>
        {
            static /*0x0*/ System.Xml.TimeSpanArrayHelperWithDictionaryString Instance;

            static /*0x757dfe0*/ TimeSpanArrayHelperWithDictionaryString();
            /*0x757df98*/ TimeSpanArrayHelperWithDictionaryString();
            /*0x757df1c*/ int ReadArray(System.Xml.XmlDictionaryReader reader, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.TimeSpan[] array, int offset, int count);
            /*0x757df58*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.TimeSpan[] array, int offset, int count);
        }

        class EncodingStreamWrapper : System.IO.Stream
        {
            static /*0x0*/ System.Text.UTF8Encoding SafeUTF8;
            static /*0x8*/ System.Text.UnicodeEncoding SafeUTF16;
            static /*0x10*/ System.Text.UnicodeEncoding SafeBEUTF16;
            static /*0x18*/ System.Text.UTF8Encoding ValidatingUTF8;
            static /*0x20*/ System.Text.UnicodeEncoding ValidatingUTF16;
            static /*0x28*/ System.Text.UnicodeEncoding ValidatingBEUTF16;
            static /*0x30*/ byte[] encodingAttr;
            static /*0x38*/ byte[] encodingUTF8;
            static /*0x40*/ byte[] encodingUnicode;
            static /*0x48*/ byte[] encodingUnicodeLE;
            static /*0x50*/ byte[] encodingUnicodeBE;
            /*0x28*/ System.Xml.EncodingStreamWrapper.SupportedEncoding encodingCode;
            /*0x30*/ System.Text.Encoding encoding;
            /*0x38*/ System.Text.Encoder enc;
            /*0x40*/ System.Text.Decoder dec;
            /*0x48*/ bool isReading;
            /*0x50*/ System.IO.Stream stream;
            /*0x58*/ char[] chars;
            /*0x60*/ byte[] bytes;
            /*0x68*/ int byteOffset;
            /*0x6c*/ int byteCount;
            /*0x70*/ byte[] byteBuffer;

            static /*0x758033c*/ EncodingStreamWrapper();
            static /*0x757f308*/ System.Text.Encoding GetEncoding(System.Xml.EncodingStreamWrapper.SupportedEncoding e);
            static /*0x757f424*/ string GetEncodingName(System.Xml.EncodingStreamWrapper.SupportedEncoding enc);
            static /*0x757e4c8*/ System.Xml.EncodingStreamWrapper.SupportedEncoding GetSupportedEncoding(System.Text.Encoding encoding);
            static /*0x757f714*/ System.Xml.EncodingStreamWrapper.SupportedEncoding ReadBOMEncoding(byte b1, byte b2, byte b3, byte b4, bool notOutOfBand, ref int preserve);
            static /*0x757ea48*/ void CheckUTF8DeclarationEncoding(byte[] buffer, int offset, int count, System.Xml.EncodingStreamWrapper.SupportedEncoding e, System.Xml.EncodingStreamWrapper.SupportedEncoding expectedEnc);
            static /*0x757f9ac*/ bool CompareCaseInsensitive(byte[] key, byte[] buffer, int offset);
            static /*0x757f934*/ bool Compare(byte[] key, byte[] buffer, int offset);
            static /*0x757f908*/ bool IsWhitespace(byte ch);
            static /*0x757e8dc*/ void ThrowExpectedEncodingMismatch(System.Xml.EncodingStreamWrapper.SupportedEncoding expEnc, System.Xml.EncodingStreamWrapper.SupportedEncoding actualEnc);
            static /*0x757fbbc*/ void ThrowEncodingMismatch(string declEnc, System.Xml.EncodingStreamWrapper.SupportedEncoding enc);
            static /*0x757faec*/ void ThrowEncodingMismatch(string declEnc, string docEnc);
            /*0x757e044*/ EncodingStreamWrapper(System.IO.Stream stream, System.Text.Encoding encoding);
            /*0x757f4ec*/ EncodingStreamWrapper(System.IO.Stream stream, System.Text.Encoding encoding, bool emitBOM);
            /*0x757f0c8*/ void SetReadDocumentEncoding(System.Xml.EncodingStreamWrapper.SupportedEncoding e);
            /*0x757e694*/ System.Xml.EncodingStreamWrapper.SupportedEncoding ReadBOMEncoding(bool notOutOfBand);
            /*0x757e9d8*/ void FillBuffer(int count);
            /*0x757f054*/ void EnsureBuffers();
            /*0x757f89c*/ void EnsureByteBuffer();
            /*0x757fc14*/ bool get_CanRead();
            /*0x757fc48*/ bool get_CanSeek();
            /*0x757fc50*/ bool get_CanWrite();
            /*0x757fc84*/ long get_Position();
            /*0x757fccc*/ void set_Position(long value);
            /*0x757fd14*/ void Close();
            /*0x757fd58*/ void Flush();
            /*0x757fd7c*/ int ReadByte();
            /*0x757fe00*/ int Read(byte[] buffer, int offset, int count);
            /*0x757f144*/ void CleanupCharBreak();
            /*0x7580064*/ long Seek(long offset, System.IO.SeekOrigin origin);
            /*0x75800ac*/ void WriteByte(byte b);
            /*0x7580110*/ void Write(byte[] buffer, int offset, int count);
            /*0x7580224*/ bool get_CanTimeout();
            /*0x7580244*/ long get_Length();
            /*0x7580264*/ int get_ReadTimeout();
            /*0x7580288*/ void set_ReadTimeout(int value);
            /*0x75802ac*/ int get_WriteTimeout();
            /*0x75802d0*/ void set_WriteTimeout(int value);
            /*0x75802f4*/ void SetLength(long value);

            enum SupportedEncoding
            {
                UTF8 = 0,
                UTF16LE = 1,
                UTF16BE = 2,
                None = 3,
            }
        }

        interface IXmlDictionary
        {
            /*0x3814140*/ bool TryLookup(int key, ref System.Xml.XmlDictionaryString result);
        }

        enum PrefixHandleType
        {
            Empty = 0,
            A = 1,
            B = 2,
            C = 3,
            D = 4,
            E = 5,
            F = 6,
            G = 7,
            H = 8,
            I = 9,
            J = 10,
            K = 11,
            L = 12,
            M = 13,
            N = 14,
            O = 15,
            P = 16,
            Q = 17,
            R = 18,
            S = 19,
            T = 20,
            U = 21,
            V = 22,
            W = 23,
            X = 24,
            Y = 25,
            Z = 26,
            Buffer = 27,
            Max = 28,
        }

        class PrefixHandle
        {
            static /*0x0*/ string[] prefixStrings;
            static /*0x8*/ byte[] prefixBuffer;
            /*0x10*/ System.Xml.XmlBufferReader bufferReader;
            /*0x18*/ System.Xml.PrefixHandleType type;
            /*0x1c*/ int offset;
            /*0x20*/ int length;

            static /*0x7580e38*/ PrefixHandle();
            static /*0x7580910*/ string GetString(System.Xml.PrefixHandleType type);
            static /*0x7580774*/ System.Xml.PrefixHandleType GetAlphaPrefix(int index);
            static /*0x758098c*/ byte[] GetString(System.Xml.PrefixHandleType type, ref int offset, ref int length);
            static /*0x7580d34*/ bool op_Equality(System.Xml.PrefixHandle prefix1, string prefix2);
            static /*0x7580d44*/ bool op_Equality(System.Xml.PrefixHandle prefix1, System.Xml.XmlDictionaryString prefix2);
            static /*0x7580d60*/ bool op_Equality(System.Xml.PrefixHandle prefix1, System.Xml.PrefixHandle prefix2);
            /*0x758065c*/ PrefixHandle(System.Xml.XmlBufferReader bufferReader);
            /*0x758068c*/ void SetValue(System.Xml.PrefixHandleType type);
            /*0x7580694*/ void SetValue(System.Xml.PrefixHandle prefix);
            /*0x75806b8*/ void SetValue(int offset, int length);
            /*0x758077c*/ bool get_IsEmpty();
            /*0x758078c*/ bool get_IsXmlns();
            /*0x7580860*/ bool get_IsXml();
            /*0x75808fc*/ bool TryGetShortPrefix(ref System.Xml.PrefixHandleType type);
            /*0x7580a18*/ string GetString(System.Xml.XmlNameTable nameTable);
            /*0x7580aa0*/ string GetString();
            /*0x7580b20*/ byte[] GetString(ref int offset, ref int length);
            /*0x7580bc8*/ int CompareTo(System.Xml.PrefixHandle that);
            /*0x7580c08*/ bool Equals2(System.Xml.PrefixHandle prefix2);
            /*0x7580c88*/ bool Equals2(string prefix2);
            /*0x7580d1c*/ bool Equals2(System.Xml.XmlDictionaryString prefix2);
            /*0x7580d70*/ bool Equals(object obj);
            /*0x7580e14*/ string ToString();
            /*0x7580e18*/ int GetHashCode();
        }

        enum StringHandleConstStringType
        {
            Type = 0,
            Root = 1,
            Item = 2,
        }

        class StringHandle
        {
            static /*0x0*/ string[] constStrings;
            /*0x10*/ System.Xml.XmlBufferReader bufferReader;
            /*0x18*/ System.Xml.StringHandle.StringHandleType type;
            /*0x1c*/ int key;
            /*0x20*/ int offset;
            /*0x24*/ int length;

            static /*0x7581fc4*/ StringHandle();
            static /*0x7581e2c*/ bool op_Equality(System.Xml.StringHandle s1, System.Xml.XmlDictionaryString xmlString2);
            static /*0x7581e3c*/ bool op_Equality(System.Xml.StringHandle s1, string s2);
            static /*0x7581e4c*/ bool op_Inequality(System.Xml.StringHandle s1, string s2);
            static /*0x7581e6c*/ bool op_Equality(System.Xml.StringHandle s1, System.Xml.StringHandle s2);
            /*0x7581490*/ StringHandle(System.Xml.XmlBufferReader bufferReader);
            /*0x75814d0*/ void SetValue(int offset, int length);
            /*0x75814e0*/ void SetConstantValue(System.Xml.StringHandleConstStringType constStringType);
            /*0x75814ec*/ void SetValue(int offset, int length, bool escaped);
            /*0x7581514*/ void SetValue(System.Xml.StringHandle value);
            /*0x7581530*/ bool get_IsEmpty();
            /*0x75815d8*/ bool get_IsXmlns();
            /*0x75816f4*/ void ToPrefixHandle(System.Xml.PrefixHandle prefix);
            /*0x7581714*/ string GetString(System.Xml.XmlNameTable nameTable);
            /*0x758182c*/ string GetString();
            /*0x758191c*/ byte[] GetString(ref int offset, ref int length);
            /*0x7581a7c*/ bool TryGetDictionaryString(ref System.Xml.XmlDictionaryString value);
            /*0x7581b58*/ string ToString();
            /*0x7581b5c*/ bool Equals2(int key2, System.Xml.XmlBufferReader bufferReader2);
            /*0x7581c38*/ bool Equals2(System.Xml.XmlDictionaryString xmlString2);
            /*0x7581564*/ bool Equals2(string s2);
            /*0x7581ce4*/ bool Equals2(int offset2, int length2, System.Xml.XmlBufferReader bufferReader2);
            /*0x7581dc4*/ bool Equals2(System.Xml.StringHandle s2);
            /*0x7581e7c*/ int CompareTo(System.Xml.StringHandle that);
            /*0x7581f00*/ bool Equals(object obj);
            /*0x7581fa4*/ int GetHashCode();

            enum StringHandleType
            {
                Dictionary = 0,
                UTF8 = 1,
                EscapedUTF8 = 2,
                ConstString = 3,
            }
        }

        class UniqueId
        {
            static /*0x0*/ short[] char2val;
            /*0x10*/ long idLow;
            /*0x18*/ long idHigh;
            /*0x20*/ string s;

            static /*0x75832ac*/ UniqueId();
            static /*0x758311c*/ bool op_Equality(System.Xml.UniqueId id1, System.Xml.UniqueId id2);
            /*0x75820dc*/ UniqueId(byte[] guid, int offset);
            /*0x758233c*/ UniqueId(string value);
            /*0x7582964*/ int get_CharArrayLength();
            /*0x758297c*/ int UnsafeDecode(short* char2val, char ch1, char ch2);
            /*0x75829b0*/ void UnsafeEncode(char* val2char, byte b, char* pch);
            /*0x75829d8*/ bool get_IsGuid();
            /*0x7582408*/ void UnsafeParse(char* chars, int charCount);
            /*0x75829ec*/ int ToCharArray(char[] chars, int offset);
            /*0x7583084*/ string ToString();
            /*0x75831b4*/ bool Equals(object obj);
            /*0x7583254*/ int GetHashCode();
            /*0x7582334*/ long UnsafeGetInt64(byte* pb);
            /*0x758329c*/ int UnsafeGetInt32(byte* pb);
            /*0x758307c*/ void UnsafeSetInt64(long value, byte* pb);
            /*0x75832a4*/ void UnsafeSetInt32(int value, byte* pb);
        }

        enum ValueHandleConstStringType
        {
            String = 0,
            Number = 1,
            Array = 2,
            Object = 3,
            Boolean = 4,
            Null = 5,
        }

        enum ValueHandleType
        {
            Empty = 0,
            True = 1,
            False = 2,
            Zero = 3,
            One = 4,
            Int8 = 5,
            Int16 = 6,
            Int32 = 7,
            Int64 = 8,
            UInt64 = 9,
            Single = 10,
            Double = 11,
            Decimal = 12,
            DateTime = 13,
            TimeSpan = 14,
            Guid = 15,
            UniqueId = 16,
            UTF8 = 17,
            EscapedUTF8 = 18,
            Base64 = 19,
            Dictionary = 20,
            List = 21,
            Char = 22,
            Unicode = 23,
            QName = 24,
            ConstString = 25,
        }

        class ValueHandle
        {
            static /*0x0*/ System.Text.Base64Encoding base64Encoding;
            static /*0x8*/ string[] constStrings;
            /*0x10*/ System.Xml.XmlBufferReader bufferReader;
            /*0x18*/ System.Xml.ValueHandleType type;
            /*0x1c*/ int offset;
            /*0x20*/ int length;

            static /*0x7585ef8*/ ValueHandle();
            static /*0x7583384*/ System.Text.Base64Encoding get_Base64Encoding();
            /*0x758334c*/ ValueHandle(System.Xml.XmlBufferReader bufferReader);
            /*0x7583450*/ void SetConstantValue(System.Xml.ValueHandleConstStringType constStringType);
            /*0x758345c*/ void SetValue(System.Xml.ValueHandleType type);
            /*0x7583464*/ void SetDictionaryValue(int key);
            /*0x7583480*/ void SetCharValue(int ch);
            /*0x7583490*/ void SetQNameValue(int prefix, int key);
            /*0x7583474*/ void SetValue(System.Xml.ValueHandleType type, int offset, int length);
            /*0x75834a0*/ bool IsWhitespace();
            /*0x758360c*/ System.Type ToType();
            /*0x7583848*/ bool ToBoolean();
            /*0x7583e74*/ int ToInt();
            /*0x7584048*/ long ToLong();
            /*0x7584178*/ ulong ToULong();
            /*0x758428c*/ float ToSingle();
            /*0x758442c*/ double ToDouble();
            /*0x7584560*/ decimal ToDecimal();
            /*0x7584740*/ System.DateTime ToDateTime();
            /*0x758483c*/ System.Xml.UniqueId ToUniqueId();
            /*0x7584930*/ System.TimeSpan ToTimeSpan();
            /*0x7584a00*/ System.Guid ToGuid();
            /*0x7584af4*/ string ToString();
            /*0x7584af8*/ byte[] ToByteArray();
            /*0x7583978*/ string GetString();
            /*0x75851a8*/ bool Equals2(string str, bool checkLower);
            /*0x75852d4*/ void Sign(System.Xml.XmlSigningNodeWriter writer);
            /*0x75850e4*/ object[] ToList();
            /*0x75854d0*/ object ToObject();
            /*0x7585704*/ bool TryReadBase64(byte[] buffer, int offset, int count, ref int actual);
            /*0x758592c*/ bool TryReadChars(char[] chars, int offset, int count, ref int actual);
            /*0x7585d5c*/ bool TryReadUnicodeChars(char[] chars, int offset, int count, ref int actual);
            /*0x7585e78*/ bool TryGetDictionaryString(ref System.Xml.XmlDictionaryString value);
            /*0x7585ec8*/ bool TryGetByteArrayLength(ref int length);
            /*0x7584f0c*/ string GetCharsText();
            /*0x7584f9c*/ string GetUnicodeCharsText();
            /*0x7584fc0*/ string GetEscapedCharsText();
            /*0x7584fe4*/ string GetCharText();
            /*0x7585ef0*/ int GetChar();
            /*0x7583954*/ int GetInt8();
            /*0x7583fb8*/ int GetInt16();
            /*0x7583fdc*/ int GetInt32();
            /*0x7584000*/ long GetInt64();
            /*0x7584024*/ ulong GetUInt64();
            /*0x75843e4*/ float GetSingle();
            /*0x7584408*/ double GetDouble();
            /*0x758471c*/ decimal GetDecimal();
            /*0x758490c*/ System.Xml.UniqueId GetUniqueId();
            /*0x7584ad0*/ System.Guid GetGuid();
            /*0x7584edc*/ void GetBase64(byte[] buffer, int offset, int count);
            /*0x75850c0*/ System.Xml.XmlDictionaryString GetDictionaryString();
            /*0x7585108*/ string GetQNameDictionaryText();
        }

        class XmlBaseReader : System.Xml.XmlDictionaryReader
        {
            static /*0x0*/ System.Xml.XmlBaseReader.XmlInitialNode initialNode;
            static /*0x8*/ System.Xml.XmlBaseReader.XmlEndOfFileNode endOfFileNode;
            static /*0x10*/ System.Xml.XmlBaseReader.XmlClosedNode closedNode;
            static /*0x18*/ System.Text.BinHexEncoding binhexEncoding;
            static /*0x20*/ System.Text.Base64Encoding base64Encoding;
            /*0x10*/ System.Xml.XmlBufferReader bufferReader;
            /*0x18*/ System.Xml.XmlBaseReader.XmlNode node;
            /*0x20*/ System.Xml.XmlBaseReader.NamespaceManager nsMgr;
            /*0x28*/ System.Xml.XmlBaseReader.XmlElementNode[] elementNodes;
            /*0x30*/ System.Xml.XmlBaseReader.XmlAttributeNode[] attributeNodes;
            /*0x38*/ System.Xml.XmlBaseReader.XmlAtomicTextNode atomicTextNode;
            /*0x40*/ int depth;
            /*0x44*/ int attributeCount;
            /*0x48*/ int attributeStart;
            /*0x50*/ System.Xml.XmlDictionaryReaderQuotas quotas;
            /*0x58*/ System.Xml.XmlNameTable nameTable;
            /*0x60*/ System.Xml.XmlBaseReader.XmlDeclarationNode declarationNode;
            /*0x68*/ System.Xml.XmlBaseReader.XmlComplexTextNode complexTextNode;
            /*0x70*/ System.Xml.XmlBaseReader.XmlWhitespaceTextNode whitespaceTextNode;
            /*0x78*/ System.Xml.XmlBaseReader.XmlCDataNode cdataNode;
            /*0x80*/ System.Xml.XmlBaseReader.XmlCommentNode commentNode;
            /*0x88*/ System.Xml.XmlBaseReader.XmlElementNode rootElementNode;
            /*0x90*/ int attributeIndex;
            /*0x98*/ char[] chars;
            /*0xa0*/ string prefix;
            /*0xa8*/ string localName;
            /*0xb0*/ string ns;
            /*0xb8*/ string value;
            /*0xc0*/ int trailCharCount;
            /*0xc4*/ int trailByteCount;
            /*0xc8*/ char[] trailChars;
            /*0xd0*/ byte[] trailBytes;
            /*0xd8*/ bool rootElement;
            /*0xd9*/ bool readingElement;
            /*0xe0*/ System.Xml.XmlSigningNodeWriter signingWriter;
            /*0xe8*/ bool signing;
            /*0xf0*/ System.Xml.XmlBaseReader.AttributeSorter attributeSorter;

            static /*0x758d838*/ XmlBaseReader();
            static /*0x75865d8*/ System.Text.BinHexEncoding get_BinHexEncoding();
            static /*0x758669c*/ System.Text.Base64Encoding get_Base64Encoding();
            /*0x75860a4*/ XmlBaseReader();
            /*0x7586760*/ System.Xml.XmlBufferReader get_BufferReader();
            /*0x7586768*/ System.Xml.XmlDictionaryReaderQuotas get_Quotas();
            /*0x7586770*/ System.Xml.XmlBaseReader.XmlNode get_Node();
            /*0x7586778*/ void MoveToNode(System.Xml.XmlBaseReader.XmlNode node);
            /*0x75867cc*/ void MoveToInitial(System.Xml.XmlDictionaryReaderQuotas quotas);
            /*0x75869d0*/ System.Xml.XmlBaseReader.XmlDeclarationNode MoveToDeclaration();
            /*0x7586e58*/ bool CheckStandalone(int attr);
            /*0x7586cbc*/ bool CheckDeclAttribute(int index, string localName, string value, bool checkLower, string valueSR);
            /*0x7587160*/ System.Xml.XmlBaseReader.XmlCommentNode MoveToComment();
            /*0x7587314*/ System.Xml.XmlBaseReader.XmlCDataNode MoveToCData();
            /*0x75874c8*/ System.Xml.XmlBaseReader.XmlAtomicTextNode MoveToAtomicText();
            /*0x75874e4*/ System.Xml.XmlBaseReader.XmlComplexTextNode MoveToComplexText();
            /*0x7587698*/ System.Xml.XmlBaseReader.XmlTextNode MoveToWhitespaceText();
            /*0x7587870*/ System.Xml.XmlBaseReader.XmlElementNode get_ElementNode();
            /*0x75878b4*/ void MoveToEndElement();
            /*0x758792c*/ void MoveToEndOfFile();
            /*0x75879a0*/ System.Xml.XmlBaseReader.XmlElementNode EnterScope();
            /*0x7587b94*/ void ExitScope();
            /*0x7587d28*/ System.Xml.XmlBaseReader.XmlAttributeNode AddAttribute(System.Xml.XmlBaseReader.QNameType qnameType, bool isAtomicValue);
            /*0x7587fc8*/ System.Xml.XmlBaseReader.Namespace AddNamespace();
            /*0x758816c*/ System.Xml.XmlBaseReader.XmlAttributeNode AddAttribute();
            /*0x7588178*/ System.Xml.XmlBaseReader.XmlAttributeNode AddXmlAttribute();
            /*0x7588184*/ System.Xml.XmlBaseReader.XmlAttributeNode AddXmlnsAttribute(System.Xml.XmlBaseReader.Namespace ns);
            /*0x7588530*/ void FixXmlAttribute(System.Xml.XmlBaseReader.XmlAttributeNode attributeNode);
            /*0x7588764*/ bool get_OutsideRootElement();
            /*0x7588774*/ bool get_CanReadValueChunk();
            /*0x758877c*/ string get_BaseURI();
            /*0x7588794*/ bool get_IsDefault();
            /*0x758879c*/ int get_AttributeCount();
            /*0x75887c8*/ void Close();
            /*0x758897c*/ int get_Depth();
            /*0x75889a0*/ bool get_EOF();
            /*0x75889c4*/ System.Xml.XmlBaseReader.XmlAttributeNode GetAttributeNode(int index);
            /*0x7588b1c*/ System.Xml.XmlBaseReader.XmlAttributeNode GetAttributeNode(string name);
            /*0x7588e14*/ System.Xml.XmlBaseReader.XmlAttributeNode GetAttributeNode(string localName, string namespaceUri);
            /*0x758905c*/ string GetAttribute(int index);
            /*0x75890ac*/ string GetAttribute(string name);
            /*0x75890c8*/ string GetAttribute(string localName, string namespaceUri);
            /*0x75890e4*/ bool get_IsEmptyElement();
            /*0x7589100*/ string get_LocalName();
            /*0x7589258*/ string LookupNamespace(string prefix);
            /*0x758944c*/ System.Xml.XmlBaseReader.Namespace LookupNamespace(System.Xml.PrefixHandle prefix);
            /*0x75895cc*/ void ProcessAttributes();
            /*0x75895e4*/ void ProcessAttributes(System.Xml.XmlBaseReader.XmlAttributeNode[] attributeNodes, int attributeCount);
            /*0x75899c0*/ void CheckAttributes(System.Xml.XmlBaseReader.XmlAttributeNode[] attributeNodes, int attributeCount);
            /*0x7589c14*/ void MoveToAttribute(int index);
            /*0x7589c44*/ bool MoveToAttribute(string name);
            /*0x7589c84*/ bool MoveToAttribute(string localName, string namespaceUri);
            /*0x7589cc4*/ bool MoveToElement();
            /*0x7589d3c*/ System.Xml.XmlNodeType MoveToContent();
            /*0x7589e30*/ bool MoveToFirstAttribute();
            /*0x7589e84*/ bool MoveToNextAttribute();
            /*0x7589eec*/ string get_NamespaceURI();
            /*0x7589ff4*/ System.Xml.XmlNameTable get_NameTable();
            /*0x758a220*/ System.Xml.XmlNodeType get_NodeType();
            /*0x758a23c*/ string get_Prefix();
            /*0x758a32c*/ char get_QuoteChar();
            /*0x7589144*/ string GetLocalName(bool enforceAtomization);
            /*0x7589f30*/ string GetNamespaceUri(bool enforceAtomization);
            /*0x758a348*/ bool IsLocalName(string localName);
            /*0x758a474*/ bool IsLocalName(System.Xml.XmlDictionaryString localName);
            /*0x758a59c*/ bool IsNamespaceUri(string namespaceUri);
            /*0x758a65c*/ bool IsNamespaceUri(System.Xml.XmlDictionaryString namespaceUri);
            /*0x758a720*/ bool IsStartElement();
            /*0x758a7a8*/ bool IsStartElement(string localName, string namespaceUri);
            /*0x758a880*/ bool IsStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri);
            /*0x758a994*/ int IndexOfLocalName(System.Xml.XmlDictionaryString[] localNames, System.Xml.XmlDictionaryString namespaceUri);
            /*0x758abcc*/ int ReadValueChunk(char[] chars, int offset, int count);
            /*0x758af08*/ string ReadElementContentAsString();
            /*0x758afb8*/ string ReadElementString();
            /*0x758b058*/ void ReadStartElement();
            /*0x758b0a4*/ void ReadEndElement();
            /*0x758b1dc*/ bool ReadAttributeValue();
            /*0x758b20c*/ System.Xml.ReadState get_ReadState();
            /*0x758b228*/ void SkipValue(System.Xml.XmlBaseReader.XmlNode node);
            /*0x758b258*/ bool TryGetBase64ContentLength(ref int length);
            /*0x758b2c8*/ byte[] ReadContentAsBase64();
            /*0x758b3b4*/ int ReadContentAsBase64(byte[] buffer, int offset, int count);
            /*0x758bd24*/ int ReadContentAsBinHex(byte[] buffer, int offset, int count);
            /*0x758b73c*/ int ReadBytes(System.Text.Encoding encoding, int byteBlock, int charBlock, byte[] buffer, int offset, int byteCount, bool readContent);
            /*0x758c094*/ string ReadContentAsString();
            /*0x758c16c*/ bool ReadContentAsBoolean();
            /*0x758c238*/ long ReadContentAsLong();
            /*0x758c304*/ int ReadContentAsInt();
            /*0x758c3d0*/ System.DateTime ReadContentAsDateTime();
            /*0x758c49c*/ double ReadContentAsDouble();
            /*0x758c574*/ float ReadContentAsFloat();
            /*0x758c64c*/ decimal ReadContentAsDecimal();
            /*0x758c720*/ System.Xml.UniqueId ReadContentAsUniqueId();
            /*0x758c7ec*/ System.TimeSpan ReadContentAsTimeSpan();
            /*0x758c8b8*/ System.Guid ReadContentAsGuid();
            /*0x758c98c*/ object ReadContentAsObject();
            /*0x758ca0c*/ object ReadContentAs(System.Type type, System.Xml.IXmlNamespaceResolver namespaceResolver);
            /*0x758cfcc*/ void ResolveEntity();
            /*0x758d034*/ void Skip();
            /*0x758d114*/ string get_Value();
            /*0x758d154*/ System.Type get_ValueType();
            /*0x758d244*/ string get_XmlLang();
            /*0x758d260*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x758d27c*/ bool TryGetLocalNameAsDictionaryString(ref System.Xml.XmlDictionaryString localName);
            /*0x758d2d0*/ bool TryGetNamespaceUriAsDictionaryString(ref System.Xml.XmlDictionaryString localName);
            /*0x758d32c*/ bool TryGetValueAsDictionaryString(ref System.Xml.XmlDictionaryString value);
            /*0x758d380*/ string GetOpenElements();
            /*0x758bff8*/ char[] GetCharBuffer(int count);
            /*0x758d470*/ void SignStartElement(System.Xml.XmlSigningNodeWriter writer);
            /*0x758d4f8*/ void SignAttribute(System.Xml.XmlSigningNodeWriter writer, System.Xml.XmlBaseReader.XmlAttributeNode attributeNode);
            /*0x758d618*/ void SignEndElement(System.Xml.XmlSigningNodeWriter writer);
            /*0x758d6a4*/ void SignNode(System.Xml.XmlSigningNodeWriter writer);
            /*0x758d824*/ void SignNode();

            enum QNameType
            {
                Normal = 0,
                Xmlns = 1,
            }

            class XmlNode
            {
                /*0x10*/ System.Xml.XmlNodeType nodeType;
                /*0x18*/ System.Xml.PrefixHandle prefix;
                /*0x20*/ System.Xml.StringHandle localName;
                /*0x28*/ System.Xml.ValueHandle value;
                /*0x30*/ System.Xml.XmlBaseReader.Namespace ns;
                /*0x38*/ bool hasValue;
                /*0x39*/ bool canGetAttribute;
                /*0x3a*/ bool canMoveToElement;
                /*0x3c*/ System.Xml.ReadState readState;
                /*0x40*/ System.Xml.XmlBaseReader.XmlAttributeTextNode attributeTextNode;
                /*0x48*/ bool exitScope;
                /*0x4c*/ int depthDelta;
                /*0x50*/ bool isAtomicValue;
                /*0x51*/ bool skipValue;
                /*0x54*/ System.Xml.XmlBaseReader.QNameType qnameType;
                /*0x58*/ bool hasContent;
                /*0x59*/ bool isEmptyElement;
                /*0x5a*/ char quoteChar;

                /*0x758dd7c*/ XmlNode(System.Xml.XmlNodeType nodeType, System.Xml.PrefixHandle prefix, System.Xml.StringHandle localName, System.Xml.ValueHandle value, System.Xml.XmlBaseReader.XmlNode.XmlNodeFlags nodeFlags, System.Xml.ReadState readState, System.Xml.XmlBaseReader.XmlAttributeTextNode attributeTextNode, int depthDelta);
                /*0x758defc*/ System.Xml.ReadState get_ReadState();
                /*0x758df04*/ System.Xml.StringHandle get_LocalName();
                /*0x758df0c*/ System.Xml.PrefixHandle get_Prefix();
                /*0x758df14*/ bool get_CanGetAttribute();
                /*0x758df1c*/ bool get_CanMoveToElement();
                /*0x758df24*/ System.Xml.XmlBaseReader.XmlAttributeTextNode get_AttributeText();
                /*0x758df2c*/ bool get_SkipValue();
                /*0x758df34*/ System.Xml.ValueHandle get_Value();
                /*0x758df3c*/ int get_DepthDelta();
                /*0x758df44*/ bool get_HasContent();
                /*0x758df4c*/ System.Xml.XmlNodeType get_NodeType();
                /*0x758df54*/ void set_NodeType(System.Xml.XmlNodeType value);
                /*0x758df5c*/ System.Xml.XmlBaseReader.QNameType get_QNameType();
                /*0x758df64*/ void set_QNameType(System.Xml.XmlBaseReader.QNameType value);
                /*0x758df6c*/ System.Xml.XmlBaseReader.Namespace get_Namespace();
                /*0x758df74*/ void set_Namespace(System.Xml.XmlBaseReader.Namespace value);
                /*0x758df7c*/ bool get_IsAtomicValue();
                /*0x758df84*/ void set_IsAtomicValue(bool value);
                /*0x758df90*/ bool get_ExitScope();
                /*0x758df98*/ void set_ExitScope(bool value);
                /*0x758dfa4*/ bool get_IsEmptyElement();
                /*0x758dfac*/ void set_IsEmptyElement(bool value);
                /*0x758dfb8*/ char get_QuoteChar();
                /*0x758dfc0*/ void set_QuoteChar(char value);
                /*0x758a3bc*/ bool IsLocalName(string localName);
                /*0x758a4e8*/ bool IsLocalName(System.Xml.XmlDictionaryString localName);
                /*0x758a5e8*/ bool IsNamespaceUri(string ns);
                /*0x758a6a8*/ bool IsNamespaceUri(System.Xml.XmlDictionaryString ns);
                /*0x7588f44*/ bool IsLocalNameAndNamespaceUri(string localName, string ns);
                /*0x7588ce0*/ bool IsPrefixAndLocalName(string prefix, string localName);
                /*0x758d294*/ bool TryGetLocalNameAsDictionaryString(ref System.Xml.XmlDictionaryString localName);
                /*0x758d2e8*/ bool TryGetNamespaceUriAsDictionaryString(ref System.Xml.XmlDictionaryString ns);
                /*0x758d344*/ bool TryGetValueAsDictionaryString(ref System.Xml.XmlDictionaryString value);
                /*0x7589074*/ string get_ValueAsString();

                enum XmlNodeFlags
                {
                    None = 0,
                    CanGetAttribute = 1,
                    CanMoveToElement = 2,
                    HasValue = 4,
                    AtomicValue = 8,
                    SkipValue = 16,
                    HasContent = 32,
                }
            }

            class XmlElementNode : System.Xml.XmlBaseReader.XmlNode
            {
                /*0x60*/ System.Xml.XmlBaseReader.XmlEndElementNode endElementNode;
                /*0x68*/ int bufferOffset;
                /*0x6c*/ int NameOffset;
                /*0x70*/ int NameLength;

                /*0x75863a8*/ XmlElementNode(System.Xml.XmlBufferReader bufferReader);
                /*0x758e108*/ XmlElementNode(System.Xml.PrefixHandle prefix, System.Xml.StringHandle localName, System.Xml.ValueHandle value);
                /*0x758e210*/ System.Xml.XmlBaseReader.XmlEndElementNode get_EndElement();
                /*0x758e218*/ int get_BufferOffset();
                /*0x758e220*/ void set_BufferOffset(int value);
            }

            class XmlAttributeNode : System.Xml.XmlBaseReader.XmlNode
            {
                /*0x7587ec0*/ XmlAttributeNode(System.Xml.XmlBufferReader bufferReader);
                /*0x758e228*/ XmlAttributeNode(System.Xml.PrefixHandle prefix, System.Xml.StringHandle localName, System.Xml.ValueHandle value);
            }

            class XmlEndElementNode : System.Xml.XmlBaseReader.XmlNode
            {
                /*0x758e1d4*/ XmlEndElementNode(System.Xml.PrefixHandle prefix, System.Xml.StringHandle localName, System.Xml.ValueHandle value);
            }

            class XmlTextNode : System.Xml.XmlBaseReader.XmlNode
            {
                /*0x758e324*/ XmlTextNode(System.Xml.XmlNodeType nodeType, System.Xml.PrefixHandle prefix, System.Xml.StringHandle localName, System.Xml.ValueHandle value, System.Xml.XmlBaseReader.XmlNode.XmlNodeFlags nodeFlags, System.Xml.ReadState readState, System.Xml.XmlBaseReader.XmlAttributeTextNode attributeTextNode, int depthDelta);
            }

            class XmlAtomicTextNode : System.Xml.XmlBaseReader.XmlTextNode
            {
                /*0x75864b0*/ XmlAtomicTextNode(System.Xml.XmlBufferReader bufferReader);
            }

            class XmlComplexTextNode : System.Xml.XmlBaseReader.XmlTextNode
            {
                /*0x7587570*/ XmlComplexTextNode(System.Xml.XmlBufferReader bufferReader);
            }

            class XmlWhitespaceTextNode : System.Xml.XmlBaseReader.XmlTextNode
            {
                /*0x7587748*/ XmlWhitespaceTextNode(System.Xml.XmlBufferReader bufferReader);
            }

            class XmlCDataNode : System.Xml.XmlBaseReader.XmlTextNode
            {
                /*0x75873a0*/ XmlCDataNode(System.Xml.XmlBufferReader bufferReader);
            }

            class XmlAttributeTextNode : System.Xml.XmlBaseReader.XmlTextNode
            {
                /*0x758e2e8*/ XmlAttributeTextNode(System.Xml.PrefixHandle prefix, System.Xml.StringHandle localName, System.Xml.ValueHandle value);
            }

            class XmlInitialNode : System.Xml.XmlBaseReader.XmlNode
            {
                /*0x758da04*/ XmlInitialNode(System.Xml.XmlBufferReader bufferReader);
            }

            class XmlDeclarationNode : System.Xml.XmlBaseReader.XmlNode
            {
                /*0x7587038*/ XmlDeclarationNode(System.Xml.XmlBufferReader bufferReader);
            }

            class XmlCommentNode : System.Xml.XmlBaseReader.XmlNode
            {
                /*0x75871ec*/ XmlCommentNode(System.Xml.XmlBufferReader bufferReader);
            }

            class XmlEndOfFileNode : System.Xml.XmlBaseReader.XmlNode
            {
                /*0x758db2c*/ XmlEndOfFileNode(System.Xml.XmlBufferReader bufferReader);
            }

            class XmlClosedNode : System.Xml.XmlBaseReader.XmlNode
            {
                /*0x758dc54*/ XmlClosedNode(System.Xml.XmlBufferReader bufferReader);
            }

            class AttributeSorter : System.Collections.IComparer
            {
                /*0x10*/ object[] indeces;
                /*0x18*/ System.Xml.XmlBaseReader.XmlAttributeNode[] attributeNodes;
                /*0x20*/ int attributeCount;
                /*0x24*/ int attributeIndex1;
                /*0x28*/ int attributeIndex2;

                /*0x7589b9c*/ AttributeSorter();
                /*0x7589ba4*/ bool Sort(System.Xml.XmlBaseReader.XmlAttributeNode[] attributeNodes, int attributeCount);
                /*0x7589c00*/ void GetIndeces(ref int attributeIndex1, ref int attributeIndex2);
                /*0x7588958*/ void Close();
                /*0x758e330*/ bool Sort();
                /*0x758e490*/ bool IsSorted();
                /*0x758e5c8*/ int Compare(object obj1, object obj2);
                /*0x758e704*/ int CompareQNameType(System.Xml.XmlBaseReader.QNameType type1, System.Xml.XmlBaseReader.QNameType type2);
            }

            class NamespaceManager
            {
                static /*0x0*/ System.Xml.XmlBaseReader.Namespace emptyNamespace;
                static /*0x8*/ System.Xml.XmlBaseReader.Namespace xmlNamespace;
                /*0x10*/ System.Xml.XmlBufferReader bufferReader;
                /*0x18*/ System.Xml.XmlBaseReader.Namespace[] namespaces;
                /*0x20*/ int nsCount;
                /*0x24*/ int depth;
                /*0x28*/ System.Xml.XmlBaseReader.Namespace[] shortPrefixUri;
                /*0x30*/ System.Xml.XmlBaseReader.NamespaceManager.XmlAttribute[] attributes;
                /*0x38*/ int attributeCount;
                /*0x3c*/ System.Xml.XmlSpace space;
                /*0x40*/ string lang;

                static /*0x758ec90*/ NamespaceManager();
                static /*0x758e70c*/ System.Xml.XmlBaseReader.Namespace get_XmlNamespace();
                static /*0x758e9ac*/ System.Xml.XmlBaseReader.Namespace get_EmptyNamespace();
                /*0x7586258*/ NamespaceManager(System.Xml.XmlBufferReader bufferReader);
                /*0x75888e8*/ void Close();
                /*0x758ea04*/ string get_XmlLang();
                /*0x758ea0c*/ System.Xml.XmlSpace get_XmlSpace();
                /*0x75868ac*/ void Clear();
                /*0x7587b84*/ void EnterScope();
                /*0x7587bd0*/ void ExitScope();
                /*0x7588714*/ void AddLangAttribute(string lang);
                /*0x7588740*/ void AddSpaceAttribute(System.Xml.XmlSpace space);
                /*0x758ea14*/ void AddAttribute();
                /*0x758847c*/ void Register(System.Xml.XmlBaseReader.Namespace nameSpace);
                /*0x7587fe0*/ System.Xml.XmlBaseReader.Namespace AddNamespace();
                /*0x758ebb4*/ System.Xml.XmlBaseReader.Namespace LookupNamespace(System.Xml.PrefixHandleType prefix);
                /*0x75894a0*/ System.Xml.XmlBaseReader.Namespace LookupNamespace(System.Xml.PrefixHandle prefix);
                /*0x7589314*/ System.Xml.XmlBaseReader.Namespace LookupNamespace(string prefix);
                /*0x758ebe4*/ bool TryGetShortPrefix(string s, ref System.Xml.PrefixHandleType shortPrefix);

                class XmlAttribute
                {
                    /*0x10*/ System.Xml.XmlSpace space;
                    /*0x18*/ string lang;
                    /*0x20*/ int depth;

                    /*0x758eba0*/ XmlAttribute();
                    /*0x758ed6c*/ int get_Depth();
                    /*0x758ed74*/ void set_Depth(int value);
                    /*0x758ed7c*/ string get_XmlLang();
                    /*0x758ed84*/ void set_XmlLang(string value);
                    /*0x758ed8c*/ System.Xml.XmlSpace get_XmlSpace();
                    /*0x758ed94*/ void set_XmlSpace(System.Xml.XmlSpace value);
                }
            }

            class Namespace
            {
                /*0x10*/ System.Xml.PrefixHandle prefix;
                /*0x18*/ System.Xml.StringHandle uri;
                /*0x20*/ int depth;
                /*0x28*/ System.Xml.XmlBaseReader.Namespace outerUri;
                /*0x30*/ string uriString;

                /*0x758e8b0*/ Namespace(System.Xml.XmlBufferReader bufferReader);
                /*0x758eba8*/ void Clear();
                /*0x758ed9c*/ int get_Depth();
                /*0x758eda4*/ void set_Depth(int value);
                /*0x758edac*/ System.Xml.PrefixHandle get_Prefix();
                /*0x758dfc8*/ bool IsUri(string s);
                /*0x758e064*/ bool IsUri(System.Xml.XmlDictionaryString s);
                /*0x758edb4*/ System.Xml.StringHandle get_Uri();
                /*0x758edbc*/ System.Xml.XmlBaseReader.Namespace get_OuterUri();
                /*0x758edc4*/ void set_OuterUri(System.Xml.XmlBaseReader.Namespace value);
            }

            class QuotaNameTable : System.Xml.XmlNameTable
            {
                /*0x10*/ System.Xml.XmlDictionaryReader reader;
                /*0x18*/ System.Xml.XmlNameTable nameTable;
                /*0x20*/ int maxCharCount;
                /*0x24*/ int charCount;

                /*0x758a18c*/ QuotaNameTable(System.Xml.XmlDictionaryReader reader, int maxCharCount);
                /*0x758edcc*/ string Get(char[] chars, int offset, int count);
                /*0x758edec*/ string Get(string value);
                /*0x758ee0c*/ void Add(int charCount);
                /*0x758ee50*/ string Add(char[] chars, int offset, int count);
                /*0x758eeec*/ string Add(string value);
            }
        }

        class XmlBaseWriter : System.Xml.XmlDictionaryWriter
        {
            static /*0x0*/ System.Text.BinHexEncoding binhexEncoding;
            static /*0x8*/ string[] prefixes;
            /*0x18*/ System.Xml.XmlNodeWriter writer;
            /*0x20*/ System.Xml.XmlBaseWriter.NamespaceManager nsMgr;
            /*0x28*/ System.Xml.XmlBaseWriter.Element[] elements;
            /*0x30*/ int depth;
            /*0x38*/ string attributeLocalName;
            /*0x40*/ string attributeValue;
            /*0x48*/ bool isXmlAttribute;
            /*0x49*/ bool isXmlnsAttribute;
            /*0x4c*/ System.Xml.WriteState writeState;
            /*0x50*/ System.Xml.XmlBaseWriter.DocumentState documentState;
            /*0x58*/ byte[] trailBytes;
            /*0x60*/ int trailByteCount;
            /*0x68*/ System.Xml.XmlStreamNodeWriter nodeWriter;
            /*0x70*/ System.Xml.XmlSigningNodeWriter signingWriter;
            /*0x78*/ System.Xml.XmlUTF8NodeWriter textFragmentWriter;
            /*0x80*/ System.Xml.XmlNodeWriter oldWriter;
            /*0x88*/ System.IO.Stream oldStream;
            /*0x90*/ bool inList;

            static /*0x7593c00*/ XmlBaseWriter();
            static /*0x758f28c*/ System.Text.BinHexEncoding get_BinHexEncoding();
            /*0x758ef74*/ XmlBaseWriter();
            /*0x758efec*/ void SetOutput(System.Xml.XmlStreamNodeWriter writer);
            /*0x758f0a0*/ void Flush();
            /*0x758f148*/ void Close();
            /*0x758f0d0*/ bool get_IsClosed();
            /*0x758f0e0*/ void ThrowClosed();
            /*0x758f358*/ string get_XmlLang();
            /*0x758f374*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x758f390*/ System.Xml.WriteState get_WriteState();
            /*0x758f398*/ void WriteXmlnsAttribute(string prefix, string ns);
            /*0x758f7e8*/ void WriteXmlnsAttribute(string prefix, System.Xml.XmlDictionaryString ns);
            /*0x758f9b0*/ void StartAttribute(ref string prefix, string localName, string ns, System.Xml.XmlDictionaryString xNs);
            /*0x759017c*/ void WriteStartAttribute(string prefix, string localName, string namespaceUri);
            /*0x75901d4*/ void WriteStartAttribute(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri);
            /*0x7590250*/ void WriteEndAttribute();
            /*0x75906c8*/ void WriteComment(string text);
            /*0x7590960*/ void WriteFullEndElement();
            /*0x7590af4*/ void WriteCData(string text);
            /*0x7590d54*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x7590e10*/ void StartElement(ref string prefix, string localName, string ns, System.Xml.XmlDictionaryString xNs);
            /*0x7591350*/ void WriteStartElement(string prefix, string localName, string namespaceUri);
            /*0x759139c*/ void WriteStartElement(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri);
            /*0x759140c*/ void WriteEndElement();
            /*0x75911e0*/ System.Xml.XmlBaseWriter.Element EnterScope();
            /*0x7591608*/ void ExitScope();
            /*0x759167c*/ void FlushElement();
            /*0x7590934*/ void StartComment();
            /*0x759095c*/ void EndComment();
            /*0x7590cb4*/ void StartContent();
            /*0x75916a4*/ void StartContent(char ch);
            /*0x7591794*/ void StartContent(string s);
            /*0x75918d0*/ void StartContent(char[] chars, int offset, int count);
            /*0x75916f8*/ void VerifyWhitespace(char ch);
            /*0x75917e8*/ void VerifyWhitespace(string s);
            /*0x7591940*/ void VerifyWhitespace(char[] chars, int offset, int count);
            /*0x7591a24*/ bool IsWhitespace(char ch);
            /*0x7590d50*/ void EndContent();
            /*0x758f258*/ void AutoComplete(System.Xml.WriteState writeState);
            /*0x7591a64*/ void EndStartElement();
            /*0x7591aa0*/ string LookupPrefix(string ns);
            /*0x7591b28*/ string GetQualifiedNamePrefix(string namespaceUri, System.Xml.XmlDictionaryString xNs);
            /*0x7591c34*/ void WriteQualifiedName(string localName, string namespaceUri);
            /*0x7591dc8*/ void WriteQualifiedName(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri);
            /*0x7591fe8*/ void WriteStartDocument();
            /*0x7592158*/ void WriteStartDocument(bool standalone);
            /*0x759217c*/ void WriteProcessingInstruction(string name, string text);
            /*0x758f200*/ void FinishDocument();
            /*0x75922b0*/ void WriteEndDocument();
            /*0x7592350*/ void WriteEntityRef(string name);
            /*0x759240c*/ void WriteWhitespace(string whitespace);
            /*0x759253c*/ void WriteString(string value);
            /*0x75925fc*/ void WriteString(System.Xml.XmlDictionaryString value);
            /*0x75926d4*/ void WriteChars(char[] chars, int offset, int count);
            /*0x7592924*/ void WriteRaw(string value);
            /*0x75929dc*/ void WriteRaw(char[] chars, int offset, int count);
            /*0x7592c2c*/ void WriteCharEntity(char ch);
            /*0x7592d58*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x7592e74*/ void WriteValue(string value);
            /*0x7592e9c*/ void WriteValue(int value);
            /*0x7592f6c*/ void WriteValue(long value);
            /*0x759303c*/ void WriteValue(bool value);
            /*0x759310c*/ void WriteValue(decimal value);
            /*0x75931f4*/ void WriteValue(float value);
            /*0x75932d0*/ void WriteValue(double value);
            /*0x75933ac*/ void WriteValue(System.DateTime value);
            /*0x759347c*/ void WriteValue(System.Guid value);
            /*0x7593564*/ void WriteValue(System.TimeSpan value);
            /*0x7593634*/ void WriteBase64(byte[] buffer, int offset, int count);
            /*0x7593a70*/ void WriteBinHex(byte[] buffer, int offset, int count);
            /*0x75906b4*/ void FlushBase64();
            /*0x7593b30*/ void FlushTrailBytes();
            /*0x75938f0*/ void EnsureBufferBounds(byte[] buffer, int offset, int count);
            /*0x758f564*/ string GeneratePrefix(string ns, System.Xml.XmlDictionaryString xNs);
            /*0x7591fb0*/ void WriteAttributeText(string value);

            class Element
            {
                /*0x10*/ string prefix;
                /*0x18*/ string localName;
                /*0x20*/ int prefixId;

                /*0x759421c*/ Element();
                /*0x75941bc*/ string get_Prefix();
                /*0x75941c4*/ void set_Prefix(string value);
                /*0x75941cc*/ string get_LocalName();
                /*0x75941d4*/ void set_LocalName(string value);
                /*0x75941dc*/ int get_PrefixId();
                /*0x75941e4*/ void set_PrefixId(int value);
                /*0x75941ec*/ void Clear();
            }

            enum DocumentState
            {
                None = 0,
                Document = 1,
                Epilog = 2,
                End = 3,
            }

            class NamespaceManager
            {
                /*0x10*/ System.Xml.XmlBaseWriter.NamespaceManager.Namespace[] namespaces;
                /*0x18*/ System.Xml.XmlBaseWriter.NamespaceManager.Namespace lastNameSpace;
                /*0x20*/ int nsCount;
                /*0x24*/ int depth;
                /*0x28*/ System.Xml.XmlBaseWriter.NamespaceManager.XmlAttribute[] attributes;
                /*0x30*/ int attributeCount;
                /*0x34*/ System.Xml.XmlSpace space;
                /*0x38*/ string lang;
                /*0x40*/ int namespaceBoundary;
                /*0x44*/ int nsTop;
                /*0x48*/ System.Xml.XmlBaseWriter.NamespaceManager.Namespace defaultNamespace;

                /*0x7594224*/ NamespaceManager();
                /*0x7594348*/ string get_XmlLang();
                /*0x7594350*/ System.Xml.XmlSpace get_XmlSpace();
                /*0x7594358*/ void Clear();
                /*0x7594448*/ void Close();
                /*0x75944cc*/ void DeclareNamespaces(System.Xml.XmlNodeWriter writer);
                /*0x75945d8*/ void EnterScope();
                /*0x75945e8*/ void ExitScope();
                /*0x7594760*/ void AddLangAttribute(string lang);
                /*0x7594918*/ void AddSpaceAttribute(System.Xml.XmlSpace space);
                /*0x759478c*/ void AddAttribute();
                /*0x7594944*/ string AddNamespace(string uri, System.Xml.XmlDictionaryString uriDictionaryString);
                /*0x7594ab8*/ void AddNamespaceIfNotDeclared(string prefix, string uri, System.Xml.XmlDictionaryString uriDictionaryString);
                /*0x7594b18*/ void AddNamespace(string prefix, string uri, System.Xml.XmlDictionaryString uriDictionaryString);
                /*0x75952c4*/ string LookupPrefix(string ns);
                /*0x759559c*/ string LookupAttributePrefix(string ns);
                /*0x75950d8*/ string LookupNamespace(string prefix);

                class XmlAttribute
                {
                    /*0x10*/ System.Xml.XmlSpace space;
                    /*0x18*/ string lang;
                    /*0x20*/ int depth;

                    /*0x759493c*/ XmlAttribute();
                    /*0x75957bc*/ int get_Depth();
                    /*0x75957c4*/ void set_Depth(int value);
                    /*0x75957cc*/ string get_XmlLang();
                    /*0x75957d4*/ void set_XmlLang(string value);
                    /*0x75957dc*/ System.Xml.XmlSpace get_XmlSpace();
                    /*0x75957e4*/ void set_XmlSpace(System.Xml.XmlSpace value);
                    /*0x7594754*/ void Clear();
                }

                class Namespace
                {
                    /*0x10*/ string prefix;
                    /*0x18*/ string ns;
                    /*0x20*/ System.Xml.XmlDictionaryString xNs;
                    /*0x28*/ int depth;
                    /*0x2c*/ char prefixChar;

                    /*0x75942e8*/ Namespace();
                    /*0x7594710*/ void Clear();
                    /*0x75957ec*/ int get_Depth();
                    /*0x75957f4*/ void set_Depth(int value);
                    /*0x75957fc*/ char get_PrefixChar();
                    /*0x7595804*/ string get_Prefix();
                    /*0x75942f0*/ void set_Prefix(string value);
                    /*0x759580c*/ string get_Uri();
                    /*0x7595814*/ void set_Uri(string value);
                    /*0x759581c*/ System.Xml.XmlDictionaryString get_UriDictionaryString();
                    /*0x7595824*/ void set_UriDictionaryString(System.Xml.XmlDictionaryString value);
                }
            }
        }

        enum XmlBinaryNodeType
        {
            EndElement = 1,
            Comment = 2,
            Array = 3,
            MinAttribute = 4,
            ShortAttribute = 4,
            Attribute = 5,
            ShortDictionaryAttribute = 6,
            DictionaryAttribute = 7,
            ShortXmlnsAttribute = 8,
            XmlnsAttribute = 9,
            ShortDictionaryXmlnsAttribute = 10,
            DictionaryXmlnsAttribute = 11,
            PrefixDictionaryAttributeA = 12,
            PrefixDictionaryAttributeB = 13,
            PrefixDictionaryAttributeC = 14,
            PrefixDictionaryAttributeD = 15,
            PrefixDictionaryAttributeE = 16,
            PrefixDictionaryAttributeF = 17,
            PrefixDictionaryAttributeG = 18,
            PrefixDictionaryAttributeH = 19,
            PrefixDictionaryAttributeI = 20,
            PrefixDictionaryAttributeJ = 21,
            PrefixDictionaryAttributeK = 22,
            PrefixDictionaryAttributeL = 23,
            PrefixDictionaryAttributeM = 24,
            PrefixDictionaryAttributeN = 25,
            PrefixDictionaryAttributeO = 26,
            PrefixDictionaryAttributeP = 27,
            PrefixDictionaryAttributeQ = 28,
            PrefixDictionaryAttributeR = 29,
            PrefixDictionaryAttributeS = 30,
            PrefixDictionaryAttributeT = 31,
            PrefixDictionaryAttributeU = 32,
            PrefixDictionaryAttributeV = 33,
            PrefixDictionaryAttributeW = 34,
            PrefixDictionaryAttributeX = 35,
            PrefixDictionaryAttributeY = 36,
            PrefixDictionaryAttributeZ = 37,
            PrefixAttributeA = 38,
            PrefixAttributeB = 39,
            PrefixAttributeC = 40,
            PrefixAttributeD = 41,
            PrefixAttributeE = 42,
            PrefixAttributeF = 43,
            PrefixAttributeG = 44,
            PrefixAttributeH = 45,
            PrefixAttributeI = 46,
            PrefixAttributeJ = 47,
            PrefixAttributeK = 48,
            PrefixAttributeL = 49,
            PrefixAttributeM = 50,
            PrefixAttributeN = 51,
            PrefixAttributeO = 52,
            PrefixAttributeP = 53,
            PrefixAttributeQ = 54,
            PrefixAttributeR = 55,
            PrefixAttributeS = 56,
            PrefixAttributeT = 57,
            PrefixAttributeU = 58,
            PrefixAttributeV = 59,
            PrefixAttributeW = 60,
            PrefixAttributeX = 61,
            PrefixAttributeY = 62,
            PrefixAttributeZ = 63,
            MaxAttribute = 63,
            MinElement = 64,
            ShortElement = 64,
            Element = 65,
            ShortDictionaryElement = 66,
            DictionaryElement = 67,
            PrefixDictionaryElementA = 68,
            PrefixDictionaryElementB = 69,
            PrefixDictionaryElementC = 70,
            PrefixDictionaryElementD = 71,
            PrefixDictionaryElementE = 72,
            PrefixDictionaryElementF = 73,
            PrefixDictionaryElementG = 74,
            PrefixDictionaryElementH = 75,
            PrefixDictionaryElementI = 76,
            PrefixDictionaryElementJ = 77,
            PrefixDictionaryElementK = 78,
            PrefixDictionaryElementL = 79,
            PrefixDictionaryElementM = 80,
            PrefixDictionaryElementN = 81,
            PrefixDictionaryElementO = 82,
            PrefixDictionaryElementP = 83,
            PrefixDictionaryElementQ = 84,
            PrefixDictionaryElementR = 85,
            PrefixDictionaryElementS = 86,
            PrefixDictionaryElementT = 87,
            PrefixDictionaryElementU = 88,
            PrefixDictionaryElementV = 89,
            PrefixDictionaryElementW = 90,
            PrefixDictionaryElementX = 91,
            PrefixDictionaryElementY = 92,
            PrefixDictionaryElementZ = 93,
            PrefixElementA = 94,
            PrefixElementB = 95,
            PrefixElementC = 96,
            PrefixElementD = 97,
            PrefixElementE = 98,
            PrefixElementF = 99,
            PrefixElementG = 100,
            PrefixElementH = 101,
            PrefixElementI = 102,
            PrefixElementJ = 103,
            PrefixElementK = 104,
            PrefixElementL = 105,
            PrefixElementM = 106,
            PrefixElementN = 107,
            PrefixElementO = 108,
            PrefixElementP = 109,
            PrefixElementQ = 110,
            PrefixElementR = 111,
            PrefixElementS = 112,
            PrefixElementT = 113,
            PrefixElementU = 114,
            PrefixElementV = 115,
            PrefixElementW = 116,
            PrefixElementX = 117,
            PrefixElementY = 118,
            PrefixElementZ = 119,
            MaxElement = 119,
            MinText = 128,
            ZeroText = 128,
            OneText = 130,
            FalseText = 132,
            TrueText = 134,
            Int8Text = 136,
            Int16Text = 138,
            Int32Text = 140,
            Int64Text = 142,
            FloatText = 144,
            DoubleText = 146,
            DecimalText = 148,
            DateTimeText = 150,
            Chars8Text = 152,
            Chars16Text = 154,
            Chars32Text = 156,
            Bytes8Text = 158,
            Bytes16Text = 160,
            Bytes32Text = 162,
            StartListText = 164,
            EndListText = 166,
            EmptyText = 168,
            DictionaryText = 170,
            UniqueIdText = 172,
            TimeSpanText = 174,
            GuidText = 176,
            UInt64Text = 178,
            BoolText = 180,
            UnicodeChars8Text = 182,
            UnicodeChars16Text = 184,
            UnicodeChars32Text = 186,
            QNameDictionaryText = 188,
            ZeroTextWithEndElement = 129,
            OneTextWithEndElement = 131,
            FalseTextWithEndElement = 133,
            TrueTextWithEndElement = 135,
            Int8TextWithEndElement = 137,
            Int16TextWithEndElement = 139,
            Int32TextWithEndElement = 141,
            Int64TextWithEndElement = 143,
            FloatTextWithEndElement = 145,
            DoubleTextWithEndElement = 147,
            DecimalTextWithEndElement = 149,
            DateTimeTextWithEndElement = 151,
            Chars8TextWithEndElement = 153,
            Chars16TextWithEndElement = 155,
            Chars32TextWithEndElement = 157,
            Bytes8TextWithEndElement = 159,
            Bytes16TextWithEndElement = 161,
            Bytes32TextWithEndElement = 163,
            StartListTextWithEndElement = 165,
            EndListTextWithEndElement = 167,
            EmptyTextWithEndElement = 169,
            DictionaryTextWithEndElement = 171,
            UniqueIdTextWithEndElement = 173,
            TimeSpanTextWithEndElement = 175,
            GuidTextWithEndElement = 177,
            UInt64TextWithEndElement = 179,
            BoolTextWithEndElement = 181,
            UnicodeChars8TextWithEndElement = 183,
            UnicodeChars16TextWithEndElement = 185,
            UnicodeChars32TextWithEndElement = 187,
            QNameDictionaryTextWithEndElement = 189,
            MaxText = 189,
        }

        class XmlBinaryReaderSession : System.Xml.IXmlDictionary
        {
            /*0x10*/ System.Xml.XmlDictionaryString[] strings;
            /*0x18*/ System.Collections.Generic.Dictionary<int, System.Xml.XmlDictionaryString> stringDict;

            /*0x759582c*/ bool TryLookup(int key, ref System.Xml.XmlDictionaryString result);
        }

        class XmlBufferReader
        {
            static /*0x0*/ byte[] emptyByteArray;
            static /*0x8*/ System.Xml.XmlBufferReader empty;
            /*0x10*/ System.Xml.XmlDictionaryReader reader;
            /*0x18*/ System.IO.Stream stream;
            /*0x20*/ byte[] streamBuffer;
            /*0x28*/ byte[] buffer;
            /*0x30*/ int offsetMin;
            /*0x34*/ int offsetMax;
            /*0x38*/ System.Xml.IXmlDictionary dictionary;
            /*0x40*/ System.Xml.XmlBinaryReaderSession session;
            /*0x48*/ byte[] guid;
            /*0x50*/ int offset;
            /*0x58*/ char[] chars;
            /*0x60*/ int windowOffset;
            /*0x64*/ int windowOffsetMax;
            /*0x68*/ System.Xml.ValueHandle listValue;

            static /*0x7598dac*/ XmlBufferReader();
            static /*0x7595970*/ System.Xml.XmlBufferReader get_Empty();
            /*0x7595900*/ XmlBufferReader(System.Xml.XmlDictionaryReader reader);
            /*0x7595930*/ XmlBufferReader(byte[] buffer);
            /*0x75959c8*/ byte[] get_Buffer();
            /*0x75959d0*/ bool get_IsStreamed();
            /*0x75959e0*/ void SetBuffer(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary, System.Xml.XmlBinaryReaderSession session);
            /*0x7595a94*/ void SetBuffer(System.IO.Stream stream, byte[] buffer, int offset, int count, System.Xml.IXmlDictionary dictionary, System.Xml.XmlBinaryReaderSession session);
            /*0x7595b10*/ void Close();
            /*0x7595bf0*/ bool get_EndOfFile();
            /*0x7595ce0*/ byte GetByte();
            /*0x7595d64*/ void SkipByte();
            /*0x7595d28*/ byte GetByteHard();
            /*0x7595dac*/ byte[] GetBuffer(int count, ref int offset);
            /*0x7595e08*/ byte[] GetBuffer(int count, ref int offset, ref int offsetMax);
            /*0x7596078*/ byte[] GetBuffer(ref int offset, ref int offsetMax);
            /*0x7595de8*/ byte[] GetBufferHard(int count, ref int offset);
            /*0x7595d84*/ void EnsureByte();
            /*0x7595c20*/ bool TryEnsureByte();
            /*0x7596090*/ void EnsureBytes(int count);
            /*0x7595ebc*/ bool TryEnsureBytes(int count);
            /*0x7595d74*/ void Advance(int count);
            /*0x75960b8*/ void SetWindow(int windowOffset, int windowLength);
            /*0x759618c*/ int get_Offset();
            /*0x7596194*/ void set_Offset(int value);
            /*0x759619c*/ int ReadBytes(int count);
            /*0x75961ec*/ int ReadMultiByteUInt31();
            /*0x75962a4*/ int ReadUInt8();
            /*0x75962c8*/ int ReadUInt16();
            /*0x7596344*/ int ReadInt32();
            /*0x75963f4*/ int ReadUInt31();
            /*0x7596430*/ char[] GetCharBuffer(int count);
            /*0x75964cc*/ int GetChars(int offset, int length, char[] chars);
            /*0x7596720*/ int GetChars(int offset, int length, char[] chars, int charOffset);
            /*0x7596834*/ string GetString(int offset, int length);
            /*0x7596890*/ string GetUnicodeString(int offset, int length);
            /*0x7596a40*/ string GetString(int offset, int length, System.Xml.XmlNameTable nameTable);
            /*0x7596aac*/ int GetEscapedChars(int offset, int length, char[] chars);
            /*0x7596ce4*/ bool IsAttrChar(int ch);
            /*0x7596e70*/ string GetEscapedString(int offset, int length);
            /*0x7596ecc*/ string GetEscapedString(int offset, int length, System.Xml.XmlNameTable nameTable);
            /*0x7596f38*/ int GetLessThanCharEntity(int offset, int length);
            /*0x7596fa8*/ int GetGreaterThanCharEntity(int offset, int length);
            /*0x7597018*/ int GetQuoteCharEntity(int offset, int length);
            /*0x75970c0*/ int GetAmpersandCharEntity(int offset, int length);
            /*0x759714c*/ int GetApostropheCharEntity(int offset, int length);
            /*0x75971f4*/ int GetDecimalCharEntity(int offset, int length);
            /*0x75972a8*/ int GetHexCharEntity(int offset, int length);
            /*0x7596d0c*/ int GetCharEntity(int offset, int length);
            /*0x7597378*/ bool IsWhitespaceKey(int key);
            /*0x759758c*/ bool IsWhitespaceUTF8(int offset, int length);
            /*0x7597684*/ bool IsWhitespaceUnicode(int offset, int length);
            /*0x75977ac*/ bool Equals2(int key1, int key2, System.Xml.XmlBufferReader bufferReader2);
            /*0x7597810*/ bool Equals2(int key1, System.Xml.XmlDictionaryString xmlString2);
            /*0x7597868*/ bool Equals2(int offset1, int length1, byte[] buffer2);
            /*0x75978fc*/ bool Equals2(int offset1, int length1, System.Xml.XmlBufferReader bufferReader2, int offset2, int length2);
            /*0x75979a4*/ bool Equals2(int offset1, int length1, int offset2, int length2);
            /*0x7597a54*/ bool Equals2(int offset1, int length1, string s2);
            /*0x7597db4*/ int Compare(int offset1, int length1, int offset2, int length2);
            /*0x7597eb0*/ byte GetByte(int offset);
            /*0x7597ee0*/ int GetInt8(int offset);
            /*0x7597760*/ int GetInt16(int offset);
            /*0x7597ef4*/ int GetInt32(int offset);
            /*0x7597f6c*/ long GetInt64(int offset);
            /*0x7598044*/ ulong GetUInt64(int offset);
            /*0x7598048*/ float GetSingle(int offset);
            /*0x75980d4*/ double GetDouble(int offset);
            /*0x75981d0*/ decimal GetDecimal(int offset);
            /*0x759833c*/ System.Xml.UniqueId GetUniqueId(int offset);
            /*0x75983ac*/ System.Guid GetGuid(int offset);
            /*0x759845c*/ void GetBase64(int srcOffset, byte[] buffer, int dstOffset, int count);
            /*0x7598468*/ System.Xml.XmlBinaryNodeType GetNodeType();
            /*0x759847c*/ void SkipNodeType();
            /*0x759848c*/ object[] GetList(int offset, int count);
            /*0x7597470*/ System.Xml.XmlDictionaryString GetDictionaryString(int key);
            /*0x7598850*/ int ReadDictionaryKey();
            /*0x7598608*/ void ReadValue(System.Xml.XmlBinaryNodeType nodeType, System.Xml.ValueHandle value);
            /*0x75989c0*/ void ReadValue(System.Xml.ValueHandle value, System.Xml.ValueHandleType type, int length);
            /*0x7598a38*/ void ReadUnicodeValue(System.Xml.ValueHandle value, int length);
            /*0x7598a78*/ void ReadList(System.Xml.ValueHandle value);
            /*0x7598b6c*/ void ReadQName(System.Xml.ValueHandle value);
            /*0x7598bd4*/ int[] GetRows();
        }

        class XmlCanonicalWriter
        {
            static /*0x0*/ bool[] isEscapedAttributeChar;
            static /*0x8*/ bool[] isEscapedElementChar;
            /*0x10*/ System.Xml.XmlUTF8NodeWriter writer;
            /*0x18*/ System.IO.MemoryStream elementStream;
            /*0x20*/ byte[] elementBuffer;
            /*0x28*/ System.Xml.XmlUTF8NodeWriter elementWriter;
            /*0x30*/ bool inStartElement;
            /*0x34*/ int depth;
            /*0x38*/ System.Xml.XmlCanonicalWriter.Scope[] scopes;
            /*0x40*/ int xmlnsAttributeCount;
            /*0x48*/ System.Xml.XmlCanonicalWriter.XmlnsAttribute[] xmlnsAttributes;
            /*0x50*/ int attributeCount;
            /*0x58*/ System.Xml.XmlCanonicalWriter.Attribute[] attributes;
            /*0x60*/ System.Xml.XmlCanonicalWriter.Attribute attribute;
            /*0x80*/ System.Xml.XmlCanonicalWriter.Element element;
            /*0x90*/ byte[] xmlnsBuffer;
            /*0x98*/ int xmlnsOffset;
            /*0x9c*/ bool includeComments;
            /*0xa0*/ string[] inclusivePrefixes;

            static /*0x759b230*/ XmlCanonicalWriter();
            /*0x7598e50*/ void Flush();
            /*0x7598e90*/ void Close();
            /*0x7598fa0*/ void WriteDeclaration();
            /*0x7598fa4*/ void WriteComment(string value);
            /*0x7599010*/ void StartElement();
            /*0x7599124*/ void EndElement();
            /*0x759916c*/ void WriteStartElement(string prefix, string localName);
            /*0x759932c*/ bool IsInclusivePrefix(ref System.Xml.XmlCanonicalWriter.XmlnsAttribute xmlnsAttribute);
            /*0x759969c*/ void WriteEndStartElement(bool isEmpty);
            /*0x7599c88*/ void WriteEndElement(string prefix, string localName);
            /*0x7599d00*/ void EnsureXmlnsBuffer(int byteCount);
            /*0x7599e40*/ void WriteXmlnsAttribute(string prefix, string ns);
            /*0x759a05c*/ void WriteStartAttribute(string prefix, string localName);
            /*0x759a164*/ void WriteEndAttribute();
            /*0x759a2e0*/ void WriteCharEntity(int ch);
            /*0x759a410*/ void WriteEscapedText(string value);
            /*0x759a4a4*/ void WriteEscapedText(byte[] chars, int offset, int count);
            /*0x759a384*/ void WriteEscapedText(char[] chars, int offset, int count);
            /*0x759a3d8*/ void WriteText(int ch);
            /*0x759a720*/ void WriteText(byte[] chars, int offset, int count);
            /*0x759a974*/ void WriteText(string value);
            /*0x759aa18*/ void WriteText(char[] chars, int offset, int count);
            /*0x7598e78*/ void ThrowIfClosed();
            /*0x759ac6c*/ void ThrowClosed();
            /*0x7599a78*/ void WriteXmlnsAttribute(ref System.Xml.XmlCanonicalWriter.XmlnsAttribute xmlnsAttribute);
            /*0x7599ac0*/ void SortAttributes();
            /*0x759a1d0*/ void AddAttribute(ref System.Xml.XmlCanonicalWriter.Attribute attribute);
            /*0x75993f4*/ void AddXmlnsAttribute(ref System.Xml.XmlCanonicalWriter.XmlnsAttribute xmlnsAttribute);
            /*0x759afbc*/ void ResolvePrefix(int prefixOffset, int prefixLength, ref int nsOffset, ref int nsLength);
            /*0x759b0f0*/ void ResolvePrefix(ref System.Xml.XmlCanonicalWriter.Attribute attribute);
            /*0x7599944*/ void ResolvePrefixes();
            /*0x759af90*/ int Compare(ref System.Xml.XmlCanonicalWriter.XmlnsAttribute xmlnsAttribute1, ref System.Xml.XmlCanonicalWriter.XmlnsAttribute xmlnsAttribute2);
            /*0x759ace0*/ int Compare(ref System.Xml.XmlCanonicalWriter.Attribute attribute1, ref System.Xml.XmlCanonicalWriter.Attribute attribute2);
            /*0x759b10c*/ int Compare(byte[] buffer, int offset1, int length1, int offset2, int length2);
            /*0x759b12c*/ int Compare(byte[] buffer1, int offset1, int length1, byte[] buffer2, int offset2, int length2);
            /*0x75999dc*/ bool Equals(byte[] buffer1, int offset1, int length1, byte[] buffer2, int offset2, int length2);

            class AttributeSorter : System.Collections.IComparer
            {
                /*0x10*/ System.Xml.XmlCanonicalWriter writer;

                /*0x759ad58*/ AttributeSorter(System.Xml.XmlCanonicalWriter writer);
                /*0x759ad88*/ void Sort();
                /*0x759b314*/ int Compare(object obj1, object obj2);
            }

            struct Scope
            {
                /*0x10*/ int xmlnsAttributeCount;
                /*0x14*/ int xmlnsOffset;
            }

            struct Element
            {
                /*0x10*/ int prefixOffset;
                /*0x14*/ int prefixLength;
                /*0x18*/ int localNameOffset;
                /*0x1c*/ int localNameLength;
            }

            struct Attribute
            {
                /*0x10*/ int prefixOffset;
                /*0x14*/ int prefixLength;
                /*0x18*/ int localNameOffset;
                /*0x1c*/ int localNameLength;
                /*0x20*/ int nsOffset;
                /*0x24*/ int nsLength;
                /*0x28*/ int offset;
                /*0x2c*/ int length;
            }

            struct XmlnsAttribute
            {
                /*0x10*/ int prefixOffset;
                /*0x14*/ int prefixLength;
                /*0x18*/ int nsOffset;
                /*0x1c*/ int nsLength;
                /*0x20*/ bool referred;
            }
        }

        class XmlConverter
        {
            static /*0x0*/ char[] whiteSpaceChars;
            static /*0x8*/ System.Text.UTF8Encoding utf8Encoding;
            static /*0x10*/ System.Text.UnicodeEncoding unicodeEncoding;
            static /*0x18*/ System.Text.Base64Encoding base64Encoding;

            static /*0x759fa38*/ XmlConverter();
            static /*0x759b3d8*/ System.Text.Base64Encoding get_Base64Encoding();
            static /*0x759b49c*/ System.Text.UTF8Encoding get_UTF8Encoding();
            static /*0x759b568*/ System.Text.UnicodeEncoding get_UnicodeEncoding();
            static /*0x759b638*/ bool ToBoolean(string value);
            static /*0x759b76c*/ bool ToBoolean(byte[] buffer, int offset, int count);
            static /*0x759b830*/ int ToInt32(string value);
            static /*0x759b97c*/ int ToInt32(byte[] buffer, int offset, int count);
            static /*0x759bb74*/ long ToInt64(string value);
            static /*0x759bcc0*/ long ToInt64(byte[] buffer, int offset, int count);
            static /*0x759bf30*/ float ToSingle(string value);
            static /*0x759c07c*/ float ToSingle(byte[] buffer, int offset, int count);
            static /*0x759c288*/ double ToDouble(string value);
            static /*0x759c3d4*/ double ToDouble(byte[] buffer, int offset, int count);
            static /*0x759c5c8*/ decimal ToDecimal(string value);
            static /*0x759c714*/ decimal ToDecimal(byte[] buffer, int offset, int count);
            static /*0x759c784*/ System.DateTime ToDateTime(long value);
            static /*0x759c90c*/ System.DateTime ToDateTime(string value);
            static /*0x759ca40*/ System.DateTime ToDateTime(byte[] buffer, int offset, int count);
            static /*0x759d184*/ System.Xml.UniqueId ToUniqueId(string value);
            static /*0x759d494*/ System.Xml.UniqueId ToUniqueId(byte[] buffer, int offset, int count);
            static /*0x759d504*/ System.TimeSpan ToTimeSpan(string value);
            static /*0x759d650*/ System.TimeSpan ToTimeSpan(byte[] buffer, int offset, int count);
            static /*0x759d6c0*/ System.Guid ToGuid(string value);
            static /*0x759d814*/ System.Guid ToGuid(byte[] buffer, int offset, int count);
            static /*0x759d884*/ ulong ToUInt64(string value);
            static /*0x759d9a4*/ ulong ToUInt64(byte[] buffer, int offset, int count);
            static /*0x7597c74*/ string ToString(byte[] buffer, int offset, int count);
            static /*0x7596900*/ string ToStringUnicode(byte[] buffer, int offset, int count);
            static /*0x759da14*/ byte[] ToBytes(string value);
            static /*0x75965c8*/ int ToChars(byte[] buffer, int offset, int count, char[] chars, int charOffset);
            static /*0x759db34*/ string ToString(bool value);
            static /*0x759db9c*/ string ToString(int value);
            static /*0x759c8b4*/ string ToString(long value);
            static /*0x759dbf4*/ string ToString(float value);
            static /*0x759dc54*/ string ToString(double value);
            static /*0x759dcb4*/ string ToString(decimal value);
            static /*0x759dd1c*/ string ToString(System.TimeSpan value);
            static /*0x759dd74*/ string ToString(System.Xml.UniqueId value);
            static /*0x759dd90*/ string ToString(System.Guid value);
            static /*0x759ddb4*/ string ToString(ulong value);
            static /*0x759dddc*/ string ToString(System.DateTime value);
            static /*0x759e2c0*/ string ToString(object value);
            static /*0x759e7b0*/ string ToString(object[] objects);
            static /*0x759ba2c*/ bool TryParseInt32(byte[] chars, int offset, int count, ref int result);
            static /*0x759bd70*/ bool TryParseInt64(byte[] chars, int offset, int count, ref long result);
            static /*0x759c12c*/ bool TryParseSingle(byte[] chars, int offset, int count, ref float result);
            static /*0x759c484*/ bool TryParseDouble(byte[] chars, int offset, int count, ref double result);
            static /*0x759e910*/ int ToInt32D2(byte[] chars, int offset);
            static /*0x759e978*/ int ToInt32D4(byte[] chars, int offset, int count);
            static /*0x759e9e4*/ int ToInt32D7(byte[] chars, int offset, int count);
            static /*0x759caf0*/ bool TryParseDateTime(byte[] chars, int offset, int count, ref System.DateTime result);
            static /*0x759ea68*/ int ToChars(bool value, byte[] buffer, int offset);
            static /*0x759eb74*/ int ToCharsR(int value, byte[] chars, int offset);
            static /*0x759ecb8*/ int ToChars(int value, byte[] chars, int offset);
            static /*0x759ed50*/ int ToCharsR(long value, byte[] chars, int offset);
            static /*0x759eeb4*/ int ToChars(long value, byte[] chars, int offset);
            static /*0x759ef4c*/ bool IsNegativeZero(float value);
            static /*0x759ef60*/ bool IsNegativeZero(double value);
            static /*0x759ef74*/ int ToInfinity(bool isNegative, byte[] buffer, int offset);
            static /*0x759f048*/ int ToZero(bool isNegative, byte[] buffer, int offset);
            static /*0x759f0b4*/ int ToChars(double value, byte[] buffer, int offset);
            static /*0x759f278*/ int ToChars(float value, byte[] buffer, int offset);
            static /*0x759f3bc*/ int ToChars(decimal value, byte[] buffer, int offset);
            static /*0x759f4a4*/ int ToChars(ulong value, byte[] buffer, int offset);
            static /*0x759f1f8*/ int ToAsciiChars(string s, byte[] buffer, int offset);
            static /*0x759f538*/ int ToCharsD2(int value, byte[] chars, int offset);
            static /*0x759f5dc*/ int ToCharsD4(int value, byte[] chars, int offset);
            static /*0x759f67c*/ int ToCharsD7(int value, byte[] chars, int offset);
            static /*0x759de78*/ int ToChars(System.DateTime value, byte[] chars, int offset);
            static /*0x759f788*/ bool IsWhitespace(string s);
            static /*0x7597554*/ bool IsWhitespace(char ch);
            static /*0x759f868*/ string StripWhitespace(string s);
            static /*0x759d2e8*/ string Trim(string s);
        }

        class XmlDictionary : System.Xml.IXmlDictionary
        {
            /*0x10*/ System.Collections.Generic.Dictionary<string, System.Xml.XmlDictionaryString> lookup;
            /*0x18*/ System.Xml.XmlDictionaryString[] strings;
            /*0x20*/ int nextId;

            /*0x759fad8*/ XmlDictionary();
            /*0x759fb78*/ XmlDictionary(int capacity);
            /*0x759fc48*/ System.Xml.XmlDictionaryString Add(string value);
            /*0x759ffd0*/ bool TryLookup(int key, ref System.Xml.XmlDictionaryString result);
        }

        class OnXmlDictionaryReaderClose : System.MulticastDelegate
        {
            /*0x75a0038*/ OnXmlDictionaryReaderClose(object object, nint method);
            /*0x75a0140*/ void Invoke(System.Xml.XmlDictionaryReader reader);
        }

        class XmlDictionaryReader : System.Xml.XmlReader
        {
            static /*0x75a0154*/ System.Xml.XmlDictionaryReader CreateDictionaryReader(System.Xml.XmlReader reader);
            static /*0x75a026c*/ System.Xml.XmlDictionaryReader CreateTextReader(System.IO.Stream stream, System.Xml.XmlDictionaryReaderQuotas quotas);
            static /*0x75a027c*/ System.Xml.XmlDictionaryReader CreateTextReader(System.IO.Stream stream, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose onClose);
            /*0x75a3508*/ XmlDictionaryReader();
            /*0x75a0314*/ System.Xml.XmlDictionaryReaderQuotas get_Quotas();
            /*0x75a039c*/ void MoveToStartElement();
            /*0x75a03d0*/ bool IsLocalName(string localName);
            /*0x75a03f8*/ bool IsLocalName(System.Xml.XmlDictionaryString localName);
            /*0x75a0448*/ bool IsNamespaceUri(string namespaceUri);
            /*0x75a04a0*/ bool IsNamespaceUri(System.Xml.XmlDictionaryString namespaceUri);
            /*0x75a04f0*/ bool IsStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri);
            /*0x75a0590*/ int IndexOfLocalName(System.Xml.XmlDictionaryString[] localNames, System.Xml.XmlDictionaryString namespaceUri);
            /*0x75a06dc*/ bool TryGetBase64ContentLength(ref int length);
            /*0x75a06e8*/ byte[] ReadContentAsBase64();
            /*0x75a071c*/ byte[] ReadContentAsBase64(int maxByteArrayContentLength, int maxInitialCount);
            /*0x75a0a64*/ string ReadContentAsString();
            /*0x75a0a94*/ string ReadContentAsString(int maxStringContentLength);
            /*0x75a0c80*/ string ReadString();
            /*0x75a0cb0*/ string ReadString(int maxStringContentLength);
            /*0x75a0830*/ byte[] ReadContentAsBytes(bool base64, int maxByteArrayContentLength);
            /*0x75a0f50*/ bool IsTextNode(System.Xml.XmlNodeType nodeType);
            /*0x75a0f74*/ int ReadContentAsChars(char[] chars, int offset, int count);
            /*0x75a1044*/ object ReadContentAs(System.Type type, System.Xml.IXmlNamespaceResolver namespaceResolver);
            /*0x75a13b0*/ decimal ReadContentAsDecimal();
            /*0x75a1420*/ float ReadContentAsFloat();
            /*0x75a1490*/ System.Xml.UniqueId ReadContentAsUniqueId();
            /*0x75a1500*/ System.Guid ReadContentAsGuid();
            /*0x75a1570*/ System.TimeSpan ReadContentAsTimeSpan();
            /*0x75a15e0*/ string ReadElementContentAsString();
            /*0x75a1694*/ bool ReadElementContentAsBoolean();
            /*0x75a1790*/ int ReadElementContentAsInt();
            /*0x75a188c*/ long ReadElementContentAsLong();
            /*0x75a1988*/ float ReadElementContentAsFloat();
            /*0x75a1a90*/ double ReadElementContentAsDouble();
            /*0x75a1b98*/ decimal ReadElementContentAsDecimal();
            /*0x75a1ca0*/ System.DateTime ReadElementContentAsDateTime();
            /*0x75a1e8c*/ System.Guid ReadElementContentAsGuid();
            /*0x75a1f70*/ System.TimeSpan ReadElementContentAsTimeSpan();
            /*0x75a206c*/ byte[] ReadElementContentAsBase64();
            /*0x75a2148*/ bool TryGetLocalNameAsDictionaryString(ref System.Xml.XmlDictionaryString localName);
            /*0x75a2168*/ bool TryGetNamespaceUriAsDictionaryString(ref System.Xml.XmlDictionaryString namespaceUri);
            /*0x75a2188*/ bool TryGetValueAsDictionaryString(ref System.Xml.XmlDictionaryString value);
            /*0x75a21a8*/ void CheckArray(System.Array array, int offset, int count);
            /*0x75a23f8*/ bool IsStartArray(ref System.Type type);
            /*0x75a2418*/ bool TryGetArrayLength(ref int count);
            /*0x75a2424*/ int ReadArray(string localName, string namespaceUri, bool[] array, int offset, int count);
            /*0x75a2510*/ int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, bool[] array, int offset, int count);
            /*0x75a25cc*/ int ReadArray(string localName, string namespaceUri, short[] array, int offset, int count);
            /*0x75a2724*/ int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, short[] array, int offset, int count);
            /*0x75a27e0*/ int ReadArray(string localName, string namespaceUri, int[] array, int offset, int count);
            /*0x75a28c8*/ int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, int[] array, int offset, int count);
            /*0x75a2984*/ int ReadArray(string localName, string namespaceUri, long[] array, int offset, int count);
            /*0x75a2a6c*/ int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, long[] array, int offset, int count);
            /*0x75a2b28*/ int ReadArray(string localName, string namespaceUri, float[] array, int offset, int count);
            /*0x75a2c10*/ int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, float[] array, int offset, int count);
            /*0x75a2ccc*/ int ReadArray(string localName, string namespaceUri, double[] array, int offset, int count);
            /*0x75a2db4*/ int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, double[] array, int offset, int count);
            /*0x75a2e70*/ int ReadArray(string localName, string namespaceUri, decimal[] array, int offset, int count);
            /*0x75a2f5c*/ int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, decimal[] array, int offset, int count);
            /*0x75a3018*/ int ReadArray(string localName, string namespaceUri, System.DateTime[] array, int offset, int count);
            /*0x75a3100*/ int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.DateTime[] array, int offset, int count);
            /*0x75a31bc*/ int ReadArray(string localName, string namespaceUri, System.Guid[] array, int offset, int count);
            /*0x75a32a8*/ int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Guid[] array, int offset, int count);
            /*0x75a3364*/ int ReadArray(string localName, string namespaceUri, System.TimeSpan[] array, int offset, int count);
            /*0x75a344c*/ int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.TimeSpan[] array, int offset, int count);

            class XmlWrappedReader : System.Xml.XmlDictionaryReader, System.Xml.IXmlLineInfo
            {
                /*0x10*/ System.Xml.XmlReader reader;
                /*0x18*/ System.Xml.XmlNamespaceManager nsMgr;

                /*0x75a022c*/ XmlWrappedReader(System.Xml.XmlReader reader, System.Xml.XmlNamespaceManager nsMgr);
                /*0x75a3560*/ int get_AttributeCount();
                /*0x75a3584*/ string get_BaseURI();
                /*0x75a35a8*/ bool get_CanReadValueChunk();
                /*0x75a35cc*/ void Close();
                /*0x75a3604*/ int get_Depth();
                /*0x75a3624*/ bool get_EOF();
                /*0x75a3648*/ string GetAttribute(int index);
                /*0x75a366c*/ string GetAttribute(string name);
                /*0x75a3690*/ string GetAttribute(string name, string namespaceUri);
                /*0x75a36b4*/ bool get_IsDefault();
                /*0x75a36d8*/ bool get_IsEmptyElement();
                /*0x75a36fc*/ bool IsStartElement(string localName, string namespaceUri);
                /*0x75a3720*/ string get_LocalName();
                /*0x75a3740*/ string LookupNamespace(string namespaceUri);
                /*0x75a3764*/ void MoveToAttribute(int index);
                /*0x75a3788*/ bool MoveToAttribute(string name);
                /*0x75a37ac*/ bool MoveToAttribute(string name, string namespaceUri);
                /*0x75a37d0*/ bool MoveToElement();
                /*0x75a37f4*/ bool MoveToFirstAttribute();
                /*0x75a3818*/ bool MoveToNextAttribute();
                /*0x75a383c*/ string get_Name();
                /*0x75a385c*/ string get_NamespaceURI();
                /*0x75a387c*/ System.Xml.XmlNameTable get_NameTable();
                /*0x75a38a0*/ System.Xml.XmlNodeType get_NodeType();
                /*0x75a38c0*/ string get_Prefix();
                /*0x75a38e0*/ char get_QuoteChar();
                /*0x75a3904*/ bool Read();
                /*0x75a3928*/ bool ReadAttributeValue();
                /*0x75a394c*/ string ReadInnerXml();
                /*0x75a3970*/ void ReadEndElement();
                /*0x75a3994*/ string ReadString();
                /*0x75a39b8*/ System.Xml.ReadState get_ReadState();
                /*0x75a39dc*/ void ResolveEntity();
                /*0x75a3a00*/ string get_Value();
                /*0x75a3a20*/ string get_XmlLang();
                /*0x75a3a44*/ System.Xml.XmlSpace get_XmlSpace();
                /*0x75a3a68*/ int ReadContentAsBase64(byte[] buffer, int offset, int count);
                /*0x75a3a8c*/ int ReadContentAsBinHex(byte[] buffer, int offset, int count);
                /*0x75a3ab0*/ int ReadValueChunk(char[] chars, int offset, int count);
                /*0x75a3ad4*/ System.Type get_ValueType();
                /*0x75a3af8*/ bool ReadContentAsBoolean();
                /*0x75a3b1c*/ System.DateTime ReadContentAsDateTime();
                /*0x75a3b40*/ decimal ReadContentAsDecimal();
                /*0x75a3c10*/ double ReadContentAsDouble();
                /*0x75a3c34*/ int ReadContentAsInt();
                /*0x75a3c58*/ long ReadContentAsLong();
                /*0x75a3c7c*/ float ReadContentAsFloat();
                /*0x75a3ca0*/ string ReadContentAsString();
                /*0x75a3cc4*/ object ReadContentAs(System.Type type, System.Xml.IXmlNamespaceResolver namespaceResolver);
                /*0x75a3ce8*/ bool HasLineInfo();
                /*0x75a3d9c*/ int get_LineNumber();
                /*0x75a3e58*/ int get_LinePosition();
            }
        }

        enum XmlDictionaryReaderQuotaTypes
        {
            MaxDepth = 1,
            MaxStringContentLength = 2,
            MaxArrayLength = 4,
            MaxBytesPerRead = 8,
            MaxNameTableCharCount = 16,
        }

        class XmlDictionaryReaderQuotas
        {
            static /*0x0*/ System.Xml.XmlDictionaryReaderQuotas defaultQuota;
            static /*0x8*/ System.Xml.XmlDictionaryReaderQuotas maxQuota;
            /*0x10*/ bool readOnly;
            /*0x14*/ int maxStringContentLength;
            /*0x18*/ int maxArrayLength;
            /*0x1c*/ int maxDepth;
            /*0x20*/ int maxNameTableCharCount;
            /*0x24*/ int maxBytesPerRead;
            /*0x28*/ System.Xml.XmlDictionaryReaderQuotaTypes modifiedQuotas;

            static /*0x75a415c*/ XmlDictionaryReaderQuotas();
            static /*0x75a40b8*/ System.Xml.XmlDictionaryReaderQuotas get_Max();
            /*0x75a3f14*/ XmlDictionaryReaderQuotas();
            /*0x75a4050*/ XmlDictionaryReaderQuotas(int maxDepth, int maxStringContentLength, int maxArrayLength, int maxBytesPerRead, int maxNameTableCharCount, System.Xml.XmlDictionaryReaderQuotaTypes modifiedQuotas);
            /*0x75a3f88*/ void CopyTo(System.Xml.XmlDictionaryReaderQuotas quotas);
            /*0x75a4110*/ void InternalCopyTo(System.Xml.XmlDictionaryReaderQuotas quotas);
            /*0x75a4134*/ int get_MaxStringContentLength();
            /*0x75a413c*/ int get_MaxArrayLength();
            /*0x75a4144*/ int get_MaxBytesPerRead();
            /*0x75a414c*/ int get_MaxDepth();
            /*0x75a4154*/ int get_MaxNameTableCharCount();
            /*0x75a40ac*/ void MakeReadOnly();
        }

        class XmlDictionaryString
        {
            static /*0x0*/ System.Xml.XmlDictionaryString.EmptyStringDictionary emptyStringDictionary;
            /*0x10*/ System.Xml.IXmlDictionary dictionary;
            /*0x18*/ string value;
            /*0x20*/ int key;
            /*0x28*/ byte[] buffer;

            static /*0x75a4300*/ XmlDictionaryString();
            static /*0x75a0584*/ string GetString(System.Xml.XmlDictionaryString s);
            static /*0x75a4224*/ System.Xml.XmlDictionaryString get_Empty();
            /*0x759fe04*/ XmlDictionaryString(System.Xml.IXmlDictionary dictionary, string value, int key);
            /*0x75a4288*/ System.Xml.IXmlDictionary get_Dictionary();
            /*0x75a4290*/ int get_Key();
            /*0x75a4298*/ string get_Value();
            /*0x75a42a0*/ byte[] ToUTF8();
            /*0x75a42f8*/ string ToString();

            class EmptyStringDictionary : System.Xml.IXmlDictionary
            {
                /*0x10*/ System.Xml.XmlDictionaryString empty;

                /*0x75a4378*/ EmptyStringDictionary();
                /*0x75a4400*/ System.Xml.XmlDictionaryString get_EmptyString();
                /*0x75a4408*/ bool TryLookup(int key, ref System.Xml.XmlDictionaryString result);
            }
        }

        class XmlDictionaryWriter : System.Xml.XmlWriter
        {
            static /*0x75a4444*/ System.Xml.XmlDictionaryWriter CreateTextWriter(System.IO.Stream stream, System.Text.Encoding encoding, bool ownsStream);
            static /*0x75a44cc*/ System.Xml.XmlDictionaryWriter CreateDictionaryWriter(System.Xml.XmlWriter writer);
            /*0x75a7690*/ XmlDictionaryWriter();
            /*0x75a45ec*/ void WriteStartElement(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri);
            /*0x75a468c*/ void WriteStartAttribute(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri);
            /*0x75a472c*/ void WriteXmlnsAttribute(string prefix, string namespaceUri);
            /*0x75a4860*/ void WriteXmlnsAttribute(string prefix, System.Xml.XmlDictionaryString namespaceUri);
            /*0x75a48e8*/ void WriteString(System.Xml.XmlDictionaryString value);
            /*0x75a4968*/ void WriteQualifiedName(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri);
            /*0x75a4a50*/ void WriteValue(System.Guid value);
            /*0x75a4a90*/ void WriteValue(System.TimeSpan value);
            /*0x75a4b0c*/ void WriteElementNode(System.Xml.XmlDictionaryReader reader, bool defattr);
            /*0x75a4e90*/ void WriteArrayNode(System.Xml.XmlDictionaryReader reader, string prefix, string localName, string namespaceUri, System.Type type);
            /*0x75a5638*/ void WriteArrayNode(System.Xml.XmlDictionaryReader reader, string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Type type);
            /*0x75a5de0*/ void WriteArrayNode(System.Xml.XmlDictionaryReader reader, System.Type type);
            /*0x75a5ed4*/ void WriteTextNode(System.Xml.XmlDictionaryReader reader, bool isAttribute);
            /*0x75a5f78*/ void WriteNode(System.Xml.XmlReader reader, bool defattr);
            /*0x75a6030*/ void WriteNode(System.Xml.XmlDictionaryReader reader, bool defattr);
            /*0x75a63d0*/ void CheckArray(System.Array array, int offset, int count);
            /*0x75a6620*/ void WriteArray(string prefix, string localName, string namespaceUri, bool[] array, int offset, int count);
            /*0x75a6700*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, bool[] array, int offset, int count);
            /*0x75a67c4*/ void WriteArray(string prefix, string localName, string namespaceUri, short[] array, int offset, int count);
            /*0x75a68a4*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, short[] array, int offset, int count);
            /*0x75a6968*/ void WriteArray(string prefix, string localName, string namespaceUri, int[] array, int offset, int count);
            /*0x75a6a48*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, int[] array, int offset, int count);
            /*0x75a6b0c*/ void WriteArray(string prefix, string localName, string namespaceUri, long[] array, int offset, int count);
            /*0x75a6bec*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, long[] array, int offset, int count);
            /*0x75a6cb0*/ void WriteArray(string prefix, string localName, string namespaceUri, float[] array, int offset, int count);
            /*0x75a6d90*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, float[] array, int offset, int count);
            /*0x75a6e54*/ void WriteArray(string prefix, string localName, string namespaceUri, double[] array, int offset, int count);
            /*0x75a6f34*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, double[] array, int offset, int count);
            /*0x75a6ff8*/ void WriteArray(string prefix, string localName, string namespaceUri, decimal[] array, int offset, int count);
            /*0x75a70dc*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, decimal[] array, int offset, int count);
            /*0x75a71a0*/ void WriteArray(string prefix, string localName, string namespaceUri, System.DateTime[] array, int offset, int count);
            /*0x75a7280*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.DateTime[] array, int offset, int count);
            /*0x75a7344*/ void WriteArray(string prefix, string localName, string namespaceUri, System.Guid[] array, int offset, int count);
            /*0x75a7428*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Guid[] array, int offset, int count);
            /*0x75a74ec*/ void WriteArray(string prefix, string localName, string namespaceUri, System.TimeSpan[] array, int offset, int count);
            /*0x75a75cc*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.TimeSpan[] array, int offset, int count);

            class XmlWrappedWriter : System.Xml.XmlDictionaryWriter
            {
                /*0x18*/ System.Xml.XmlWriter writer;
                /*0x20*/ int depth;
                /*0x24*/ int prefix;

                /*0x75a45b4*/ XmlWrappedWriter(System.Xml.XmlWriter writer);
                /*0x75a7698*/ void Close();
                /*0x75a76bc*/ void Flush();
                /*0x75a76e0*/ string LookupPrefix(string namespaceUri);
                /*0x75a7704*/ void WriteAttributes(System.Xml.XmlReader reader, bool defattr);
                /*0x75a772c*/ void WriteBase64(byte[] buffer, int index, int count);
                /*0x75a7750*/ void WriteBinHex(byte[] buffer, int index, int count);
                /*0x75a7774*/ void WriteCData(string text);
                /*0x75a7798*/ void WriteCharEntity(char ch);
                /*0x75a77bc*/ void WriteChars(char[] buffer, int index, int count);
                /*0x75a77e0*/ void WriteComment(string text);
                /*0x75a7804*/ void WriteDocType(string name, string pubid, string sysid, string subset);
                /*0x75a7824*/ void WriteEndAttribute();
                /*0x75a7848*/ void WriteEndDocument();
                /*0x75a7868*/ void WriteEndElement();
                /*0x75a789c*/ void WriteEntityRef(string name);
                /*0x75a78c0*/ void WriteFullEndElement();
                /*0x75a78e0*/ void WriteNode(System.Xml.XmlReader reader, bool defattr);
                /*0x75a7908*/ void WriteProcessingInstruction(string name, string text);
                /*0x75a792c*/ void WriteQualifiedName(string localName, string namespaceUri);
                /*0x75a7950*/ void WriteRaw(char[] buffer, int index, int count);
                /*0x75a7974*/ void WriteRaw(string data);
                /*0x75a7998*/ void WriteStartAttribute(string prefix, string localName, string namespaceUri);
                /*0x75a79cc*/ void WriteStartDocument();
                /*0x75a79ec*/ void WriteStartDocument(bool standalone);
                /*0x75a7a10*/ void WriteStartElement(string prefix, string localName, string namespaceUri);
                /*0x75a7a48*/ System.Xml.WriteState get_WriteState();
                /*0x75a7a6c*/ void WriteString(string text);
                /*0x75a7a90*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
                /*0x75a7ab4*/ void WriteWhitespace(string whitespace);
                /*0x75a7ad8*/ void WriteValue(string value);
                /*0x75a7afc*/ void WriteValue(bool value);
                /*0x75a7b24*/ void WriteValue(System.DateTime value);
                /*0x75a7b48*/ void WriteValue(double value);
                /*0x75a7b6c*/ void WriteValue(int value);
                /*0x75a7b90*/ void WriteValue(long value);
                /*0x75a7bb4*/ void WriteXmlnsAttribute(string prefix, string namespaceUri);
                /*0x75a7d28*/ string get_XmlLang();
                /*0x75a7d4c*/ System.Xml.XmlSpace get_XmlSpace();
            }
        }

        class XmlNodeWriter
        {
            /*0x75a802c*/ XmlNodeWriter();
            /*0x38159dc*/ void Flush();
            /*0x38159dc*/ void Close();
            /*0x38159dc*/ void WriteDeclaration();
            /*0x3816710*/ void WriteComment(string text);
            /*0x3816710*/ void WriteCData(string text);
            /*0x3816810*/ void WriteStartElement(string prefix, string localName);
            /*0x75a7d70*/ void WriteStartElement(byte[] prefixBuffer, int prefixOffset, int prefixLength, byte[] localNameBuffer, int localNameOffset, int localNameLength);
            /*0x3816810*/ void WriteStartElement(string prefix, System.Xml.XmlDictionaryString localName);
            /*0x3815cc4*/ void WriteEndStartElement(bool isEmpty);
            /*0x3816810*/ void WriteEndElement(string prefix, string localName);
            /*0x75a7e1c*/ void WriteEndElement(byte[] prefixBuffer, int prefixOffset, int prefixLength, byte[] localNameBuffer, int localNameOffset, int localNameLength);
            /*0x3816810*/ void WriteXmlnsAttribute(string prefix, string ns);
            /*0x75a7ecc*/ void WriteXmlnsAttribute(byte[] prefixBuffer, int prefixOffset, int prefixLength, byte[] nsBuffer, int nsOffset, int nsLength);
            /*0x3816810*/ void WriteXmlnsAttribute(string prefix, System.Xml.XmlDictionaryString ns);
            /*0x3816810*/ void WriteStartAttribute(string prefix, string localName);
            /*0x75a7f7c*/ void WriteStartAttribute(byte[] prefixBuffer, int prefixOffset, int prefixLength, byte[] localNameBuffer, int localNameOffset, int localNameLength);
            /*0x3816810*/ void WriteStartAttribute(string prefix, System.Xml.XmlDictionaryString localName);
            /*0x38159dc*/ void WriteEndAttribute();
            /*0x3815ed0*/ void WriteCharEntity(int ch);
            /*0x3816710*/ void WriteEscapedText(string value);
            /*0x3816710*/ void WriteEscapedText(System.Xml.XmlDictionaryString value);
            void WriteEscapedText(char[] chars, int offset, int count);
            void WriteEscapedText(byte[] buffer, int offset, int count);
            /*0x3816710*/ void WriteText(string value);
            /*0x3816710*/ void WriteText(System.Xml.XmlDictionaryString value);
            void WriteText(char[] chars, int offset, int count);
            void WriteText(byte[] buffer, int offset, int count);
            /*0x3815ed0*/ void WriteInt32Text(int value);
            /*0x381630c*/ void WriteInt64Text(long value);
            /*0x3815cc4*/ void WriteBoolText(bool value);
            void WriteUInt64Text(ulong value);
            /*0x3816f24*/ void WriteFloatText(float value);
            /*0x3815db4*/ void WriteDoubleText(double value);
            void WriteDecimalText(decimal value);
            void WriteDateTimeText(System.DateTime value);
            /*0x3816710*/ void WriteUniqueIdText(System.Xml.UniqueId value);
            /*0x3817080*/ void WriteTimeSpanText(System.TimeSpan value);
            void WriteGuidText(System.Guid value);
            void WriteBase64Text(byte[] trailBuffer, int trailCount, byte[] buffer, int offset, int count);
            /*0x3816810*/ void WriteQualifiedName(string prefix, System.Xml.XmlDictionaryString localName);
        }

        class XmlSigningNodeWriter : System.Xml.XmlNodeWriter
        {
            /*0x10*/ System.Xml.XmlNodeWriter writer;
            /*0x18*/ System.Xml.XmlCanonicalWriter signingWriter;
            /*0x20*/ byte[] chars;
            /*0x28*/ byte[] base64Chars;
            /*0x30*/ bool text;

            /*0x75a8034*/ void Flush();
            /*0x75a807c*/ void Close();
            /*0x75a80ac*/ void WriteDeclaration();
            /*0x75a80dc*/ void WriteComment(string text);
            /*0x75a811c*/ void WriteCData(string text);
            /*0x75a815c*/ void WriteStartElement(string prefix, string localName);
            /*0x75a81a4*/ void WriteStartElement(string prefix, System.Xml.XmlDictionaryString localName);
            /*0x75a81f0*/ void WriteEndStartElement(bool isEmpty);
            /*0x75a8234*/ void WriteEndElement(string prefix, string localName);
            /*0x75a8280*/ void WriteXmlnsAttribute(string prefix, string ns);
            /*0x75a82cc*/ void WriteXmlnsAttribute(string prefix, System.Xml.XmlDictionaryString ns);
            /*0x75a831c*/ void WriteStartAttribute(string prefix, string localName);
            /*0x75a8368*/ void WriteStartAttribute(string prefix, System.Xml.XmlDictionaryString localName);
            /*0x75a83b8*/ void WriteEndAttribute();
            /*0x75a83ec*/ void WriteCharEntity(int ch);
            /*0x75a8430*/ void WriteEscapedText(string value);
            /*0x75a8474*/ void WriteEscapedText(char[] chars, int offset, int count);
            /*0x75a84d0*/ void WriteEscapedText(System.Xml.XmlDictionaryString value);
            /*0x75a8518*/ void WriteEscapedText(byte[] chars, int offset, int count);
            /*0x75a8574*/ void WriteText(string value);
            /*0x75a85b8*/ void WriteText(char[] chars, int offset, int count);
            /*0x75a8614*/ void WriteText(byte[] chars, int offset, int count);
            /*0x75a8670*/ void WriteText(System.Xml.XmlDictionaryString value);
            /*0x75a86b8*/ void WriteInt32Text(int value);
            /*0x75a8794*/ void WriteInt64Text(long value);
            /*0x75a8870*/ void WriteBoolText(bool value);
            /*0x75a894c*/ void WriteUInt64Text(ulong value);
            /*0x75a8a28*/ void WriteFloatText(float value);
            /*0x75a8b04*/ void WriteDoubleText(double value);
            /*0x75a8be0*/ void WriteDecimalText(decimal value);
            /*0x75a8cc8*/ void WriteDateTimeText(System.DateTime value);
            /*0x75a8da4*/ void WriteUniqueIdText(System.Xml.UniqueId value);
            /*0x75a8e64*/ void WriteTimeSpanText(System.TimeSpan value);
            /*0x75a8f18*/ void WriteGuidText(System.Guid value);
            /*0x75a8fec*/ void WriteBase64Text(byte[] trailBytes, int trailByteCount, byte[] buffer, int offset, int count);
            /*0x75a90a0*/ void WriteBase64Text(byte[] buffer, int offset, int count);
            /*0x75a92f0*/ void WriteQualifiedName(string prefix, System.Xml.XmlDictionaryString localName);
        }

        class XmlStreamNodeWriter : System.Xml.XmlNodeWriter
        {
            static /*0x0*/ System.Text.UTF8Encoding UTF8Encoding;
            /*0x10*/ System.IO.Stream stream;
            /*0x18*/ byte[] buffer;
            /*0x20*/ int offset;
            /*0x24*/ bool ownsStream;
            /*0x28*/ System.Text.Encoding encoding;

            static /*0x75a9c38*/ XmlStreamNodeWriter();
            /*0x75a93a0*/ XmlStreamNodeWriter();
            /*0x75a9448*/ void SetOutput(System.IO.Stream stream, bool ownsStream, System.Text.Encoding encoding);
            /*0x75a94a8*/ int get_Position();
            /*0x75a94dc*/ byte[] GetBuffer(int count, ref int offset);
            /*0x75a9528*/ void Advance(int count);
            /*0x75a9538*/ void EnsureByte();
            /*0x75a9558*/ void WriteByte(byte b);
            /*0x75a95c4*/ void WriteByte(char ch);
            /*0x75a95c8*/ void WriteBytes(byte b1, byte b2);
            /*0x75a9660*/ void WriteBytes(char ch1, char ch2);
            /*0x75a9664*/ void WriteUTF8Char(int ch);
            /*0x75a9930*/ void WriteUTF8Chars(byte[] chars, int charOffset, int charCount);
            /*0x75a99f8*/ void WriteUTF8Chars(string value);
            /*0x75a96fc*/ void UnsafeWriteUTF8Chars(char* chars, int charCount);
            /*0x75a9a48*/ int UnsafeGetUTF8Chars(char* chars, int charCount, byte[] buffer, int offset);
            /*0x75a9b78*/ void FlushBuffer();
            /*0x75a9bb8*/ void Flush();
            /*0x75a9bf0*/ void Close();
        }

        class XmlUTF8TextReader : System.Xml.XmlBaseReader, System.Xml.IXmlLineInfo
        {
            static /*0x0*/ byte[] charType;
            /*0xf8*/ System.Xml.PrefixHandle prefix;
            /*0x100*/ System.Xml.StringHandle localName;
            /*0x108*/ int[] rowOffsets;
            /*0x110*/ System.Xml.OnXmlDictionaryReaderClose onClose;
            /*0x118*/ bool buffered;
            /*0x11c*/ int maxBytesPerRead;

            static /*0x75acdfc*/ XmlUTF8TextReader();
            /*0x75a9cbc*/ XmlUTF8TextReader();
            /*0x75a9da0*/ void SetInput(System.IO.Stream stream, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose onClose);
            /*0x75a9e84*/ void MoveToInitial(System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose onClose);
            /*0x75a9ec8*/ void Close();
            /*0x75a9fd8*/ void SkipWhitespace();
            /*0x75aa098*/ void ReadDeclaration();
            /*0x75aabd0*/ void VerifyNCName(string s);
            /*0x75aaf94*/ void ReadQualifiedName(System.Xml.PrefixHandle prefix, System.Xml.StringHandle localName);
            /*0x75ab304*/ int ReadAttributeText(byte[] buffer, int offset, int offsetMax);
            /*0x75aa584*/ void ReadAttributes();
            /*0x75ab4e4*/ void ReadNonFFFE();
            /*0x75ab65c*/ bool IsNextCharacterNonFFFE(byte[] buffer, int offset);
            /*0x75aa3ec*/ void BufferElement();
            /*0x75ab6c0*/ void ReadStartElement();
            /*0x75ab8bc*/ void ReadEndElement();
            /*0x75abb74*/ void ReadComment();
            /*0x75abe98*/ void ReadCData();
            /*0x75ab440*/ int ReadCharRef();
            /*0x75ac138*/ void ReadWhitespace();
            /*0x75ac200*/ int ReadWhitespace(byte[] buffer, int offset, int offsetMax);
            /*0x75ac380*/ int ReadText(byte[] buffer, int offset, int offsetMax);
            /*0x75ac44c*/ int ReadTextAndWatchForInvalidCharacters(byte[] buffer, int offset, int offsetMax);
            /*0x75ac2cc*/ int BreakText(byte[] buffer, int offset, int length);
            /*0x75ac600*/ void ReadText(bool hasLeadingByteOf0xEF);
            /*0x75ac768*/ void ReadEscapedText();
            /*0x75ac830*/ bool Read();
            /*0x75acce4*/ bool HasLineInfo();
            /*0x75accec*/ int get_LineNumber();
            /*0x75acddc*/ int get_LinePosition();
            /*0x75acd0c*/ void GetPosition(ref int row, ref int column);
        }

        class XmlUTF8TextWriter : System.Xml.XmlBaseWriter
        {
            /*0x98*/ System.Xml.XmlUTF8NodeWriter writer;

            /*0x75ad100*/ XmlUTF8TextWriter();
            /*0x75ace9c*/ void SetOutput(System.IO.Stream stream, System.Text.Encoding encoding, bool ownsStream);
        }

        class XmlUTF8NodeWriter : System.Xml.XmlStreamNodeWriter
        {
            static /*0x0*/ byte[] startDecl;
            static /*0x8*/ byte[] endDecl;
            static /*0x10*/ byte[] utf8Decl;
            static /*0x18*/ byte[] digits;
            static /*0x20*/ bool[] defaultIsEscapedAttributeChar;
            static /*0x28*/ bool[] defaultIsEscapedElementChar;
            /*0x30*/ byte[] entityChars;
            /*0x38*/ bool[] isEscapedAttributeChar;
            /*0x40*/ bool[] isEscapedElementChar;
            /*0x48*/ bool inAttribute;
            /*0x50*/ System.Text.Encoding encoding;
            /*0x58*/ char[] chars;

            static /*0x75af620*/ XmlUTF8NodeWriter();
            /*0x75ad008*/ XmlUTF8NodeWriter();
            /*0x75ad158*/ XmlUTF8NodeWriter(bool[] isEscapedAttributeChar, bool[] isEscapedElementChar);
            /*0x75ad068*/ void SetOutput(System.IO.Stream stream, bool ownsStream, System.Text.Encoding encoding);
            /*0x75ad1e4*/ byte[] GetCharEntityBuffer();
            /*0x75ad24c*/ char[] GetCharBuffer(int charCount);
            /*0x75ad2e8*/ void WriteDeclaration();
            /*0x75ad41c*/ void WriteCData(string text);
            /*0x75ad608*/ void WriteStartComment();
            /*0x75ad6c4*/ void WriteEndComment();
            /*0x75ad764*/ void WriteComment(string text);
            /*0x75ad794*/ void WriteStartElement(string prefix, string localName);
            /*0x75ad838*/ void WriteStartElement(string prefix, System.Xml.XmlDictionaryString localName);
            /*0x75ad858*/ void WriteStartElement(byte[] prefixBuffer, int prefixOffset, int prefixLength, byte[] localNameBuffer, int localNameOffset, int localNameLength);
            /*0x75ad914*/ void WriteEndStartElement(bool isEmpty);
            /*0x75ad92c*/ void WriteEndElement(string prefix, string localName);
            /*0x75ad994*/ void WriteEndElement(byte[] prefixBuffer, int prefixOffset, int prefixLength, byte[] localNameBuffer, int localNameOffset, int localNameLength);
            /*0x75ada20*/ void WriteStartXmlnsAttribute();
            /*0x75adb20*/ void WriteXmlnsAttribute(string prefix, string ns);
            /*0x75adba4*/ void WriteXmlnsAttribute(string prefix, System.Xml.XmlDictionaryString ns);
            /*0x75adbc8*/ void WriteXmlnsAttribute(byte[] prefixBuffer, int prefixOffset, int prefixLength, byte[] nsBuffer, int nsOffset, int nsLength);
            /*0x75adc70*/ void WriteStartAttribute(string prefix, string localName);
            /*0x75adce4*/ void WriteStartAttribute(string prefix, System.Xml.XmlDictionaryString localName);
            /*0x75add08*/ void WriteStartAttribute(byte[] prefixBuffer, int prefixOffset, int prefixLength, byte[] localNameBuffer, int localNameOffset, int localNameLength);
            /*0x75adda0*/ void WriteEndAttribute();
            /*0x75ad7ec*/ void WritePrefix(string prefix);
            /*0x75ad8d4*/ void WritePrefix(byte[] prefixBuffer, int prefixOffset, int prefixLength);
            /*0x75ad834*/ void WriteLocalName(string localName);
            /*0x75ad910*/ void WriteLocalName(byte[] localNameBuffer, int localNameOffset, int localNameLength);
            /*0x75addbc*/ void WriteEscapedText(System.Xml.XmlDictionaryString s);
            /*0x75adde0*/ void WriteEscapedText(string s);
            /*0x75adf40*/ void WriteEscapedText(char[] s, int offset, int count);
            /*0x75ade30*/ void UnsafeWriteEscapedText(char* chars, int count);
            /*0x75adf80*/ void WriteEscapedText(byte[] chars, int offset, int count);
            /*0x75ae144*/ void WriteText(int ch);
            /*0x75ae148*/ void WriteText(byte[] chars, int offset, int count);
            /*0x75ae14c*/ void WriteText(char[] chars, int offset, int count);
            /*0x75ae18c*/ void WriteText(string value);
            /*0x75ae190*/ void WriteText(System.Xml.XmlDictionaryString value);
            /*0x75ae1a8*/ void WriteLessThanCharEntity();
            /*0x75ae268*/ void WriteGreaterThanCharEntity();
            /*0x75ae328*/ void WriteAmpersandCharEntity();
            /*0x75ae404*/ void WriteApostropheCharEntity();
            /*0x75ae4fc*/ void WriteQuoteCharEntity();
            /*0x75ae5f4*/ void WriteHexCharEntity(int ch);
            /*0x75ae778*/ void WriteCharEntity(int ch);
            /*0x75ae6b4*/ int ToBase16(byte[] chars, int offset, uint value);
            /*0x75ae7c0*/ void WriteBoolText(bool value);
            /*0x75ae868*/ void WriteDecimalText(decimal value);
            /*0x75ae918*/ void WriteDoubleText(double value);
            /*0x75ae9c0*/ void WriteFloatText(float value);
            /*0x75aea68*/ void WriteDateTimeText(System.DateTime value);
            /*0x75aeb10*/ void WriteUniqueIdText(System.Xml.UniqueId value);
            /*0x75aebd0*/ void WriteInt32Text(int value);
            /*0x75aec78*/ void WriteInt64Text(long value);
            /*0x75aed20*/ void WriteUInt64Text(ulong value);
            /*0x75aedc8*/ void WriteGuidText(System.Guid value);
            /*0x75aee08*/ void WriteBase64Text(byte[] trailBytes, int trailByteCount, byte[] buffer, int offset, int count);
            /*0x75aee5c*/ void InternalWriteBase64Text(byte[] buffer, int offset, int count);
            /*0x75af550*/ void WriteTimeSpanText(System.TimeSpan value);
            /*0x75af5cc*/ void WriteQualifiedName(string prefix, System.Xml.XmlDictionaryString localName);
        }

        class XmlExceptionHelper
        {
            static /*0x75af840*/ void ThrowXmlException(System.Xml.XmlDictionaryReader reader, string res);
            static /*0x75af84c*/ void ThrowXmlException(System.Xml.XmlDictionaryReader reader, string res, string arg1);
            static /*0x75af858*/ void ThrowXmlException(System.Xml.XmlDictionaryReader reader, string res, string arg1, string arg2);
            static /*0x75af864*/ void ThrowXmlException(System.Xml.XmlDictionaryReader reader, string res, string arg1, string arg2, string arg3);
            static /*0x75aacb8*/ void ThrowXmlException(System.Xml.XmlDictionaryReader reader, System.Xml.XmlException exception);
            static /*0x75afc44*/ string GetName(string prefix, string localName);
            static /*0x75afcb8*/ string GetWhatWasFound(System.Xml.XmlDictionaryReader reader);
            static /*0x75b0190*/ void ThrowStartElementExpected(System.Xml.XmlDictionaryReader reader);
            static /*0x75b01dc*/ void ThrowEndElementExpected(System.Xml.XmlDictionaryReader reader, string localName, string ns);
            static /*0x75b023c*/ void ThrowMaxStringContentLengthExceeded(System.Xml.XmlDictionaryReader reader, int maxStringContentLength);
            static /*0x75b02a0*/ void ThrowMaxArrayLengthExceeded(System.Xml.XmlDictionaryReader reader, int maxArrayLength);
            static /*0x75b0304*/ void ThrowMaxArrayLengthOrMaxItemsQuotaExceeded(System.Xml.XmlDictionaryReader reader, int maxQuota);
            static /*0x75b0368*/ void ThrowMaxDepthExceeded(System.Xml.XmlDictionaryReader reader, int maxDepth);
            static /*0x75ab5f8*/ void ThrowMaxBytesPerReadExceeded(System.Xml.XmlDictionaryReader reader, int maxBytesPerRead);
            static /*0x75b03cc*/ void ThrowMaxNameTableCharCountExceeded(System.Xml.XmlDictionaryReader reader, int maxNameTableCharCount);
            static /*0x75b0430*/ void ThrowBase64DataExpected(System.Xml.XmlDictionaryReader reader);
            static /*0x75b047c*/ void ThrowUndefinedPrefix(System.Xml.XmlDictionaryReader reader, string prefix);
            static /*0x75aa504*/ void ThrowProcessingInstructionNotSupported(System.Xml.XmlDictionaryReader reader);
            static /*0x75abdfc*/ void ThrowInvalidXml(System.Xml.XmlDictionaryReader reader, byte b);
            static /*0x75b04c8*/ void ThrowUnexpectedEndOfFile(System.Xml.XmlDictionaryReader reader);
            static /*0x75b0548*/ void ThrowUnexpectedEndElement(System.Xml.XmlDictionaryReader reader);
            static /*0x75ab3d0*/ void ThrowTokenExpected(System.Xml.XmlDictionaryReader reader, string expected, char found);
            static /*0x75aab7c*/ void ThrowTokenExpected(System.Xml.XmlDictionaryReader reader, string expected, string found);
            static /*0x75b0588*/ void ThrowInvalidCharRef(System.Xml.XmlDictionaryReader reader);
            static /*0x75abaf8*/ void ThrowTagMismatch(System.Xml.XmlDictionaryReader reader, string expectedPrefix, string expectedLocalName, string foundPrefix, string foundLocalName);
            static /*0x75b05c8*/ void ThrowDuplicateXmlnsAttribute(System.Xml.XmlDictionaryReader reader, string localName, string ns);
            static /*0x75b0670*/ void ThrowDuplicateAttribute(System.Xml.XmlDictionaryReader reader, string prefix1, string prefix2, string localName, string ns);
            static /*0x75b06f0*/ void ThrowInvalidBinaryFormat(System.Xml.XmlDictionaryReader reader);
            static /*0x75acca4*/ void ThrowInvalidRootData(System.Xml.XmlDictionaryReader reader);
            static /*0x75b0730*/ void ThrowMultipleRootElements(System.Xml.XmlDictionaryReader reader);
            static /*0x75aa544*/ void ThrowDeclarationNotFirst(System.Xml.XmlDictionaryReader reader);
            static /*0x75b0770*/ void ThrowConversionOverflow(System.Xml.XmlDictionaryReader reader, string value, string type);
            static /*0x75b07c4*/ void ThrowXmlDictionaryStringIDOutOfRange(System.Xml.XmlDictionaryReader reader);
            static /*0x75b0850*/ void ThrowXmlDictionaryStringIDUndefinedStatic(System.Xml.XmlDictionaryReader reader, int key);
            static /*0x75b08b4*/ void ThrowXmlDictionaryStringIDUndefinedSession(System.Xml.XmlDictionaryReader reader, int key);
            static /*0x75b0918*/ void ThrowEmptyNamespace(System.Xml.XmlDictionaryReader reader);
            static /*0x75b0958*/ System.Xml.XmlException CreateConversionException(string value, string type, System.Exception exception);
            static /*0x75b0a94*/ System.Xml.XmlException CreateEncodingException(byte[] buffer, int offset, int count, System.Exception exception);
            static /*0x75b0b38*/ System.Xml.XmlException CreateEncodingException(string value, System.Exception exception);
        }
    }

    namespace Text
    {
        class Base64Encoding : System.Text.Encoding
        {
            static /*0x0*/ byte[] char2val;
            static /*0x8*/ string val2char;
            static /*0x10*/ byte[] val2byte;

            static /*0x75b2614*/ Base64Encoding();
            /*0x75b260c*/ Base64Encoding();
            /*0x75b0c3c*/ int GetMaxByteCount(int charCount);
            /*0x75b0d78*/ bool IsValidLeadBytes(int v1, int v2, int v3, int v4);
            /*0x75b0d98*/ bool IsValidTailBytes(int v3, int v4);
            /*0x75b0db0*/ int GetByteCount(char[] chars, int index, int count);
            /*0x75b127c*/ int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);
            /*0x75b18f4*/ int GetBytes(byte[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);
            /*0x75b1f54*/ int GetMaxCharCount(int byteCount);
            /*0x75b20a8*/ int GetCharCount(byte[] bytes, int index, int count);
            /*0x75b20bc*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0x75af000*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, byte[] chars, int charIndex);
        }

        class BinHexEncoding : System.Text.Encoding
        {
            static /*0x0*/ byte[] char2val;
            static /*0x8*/ string val2char;

            static /*0x75b33f4*/ BinHexEncoding();
            /*0x75b33ec*/ BinHexEncoding();
            /*0x75b2728*/ int GetMaxByteCount(int charCount);
            /*0x75b2858*/ int GetByteCount(char[] chars, int index, int count);
            /*0x75b286c*/ int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);
            /*0x75b2e14*/ int GetMaxCharCount(int byteCount);
            /*0x75b2f3c*/ int GetCharCount(byte[] bytes, int index, int count);
            /*0x75b2f50*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
        }

        struct SurrogateChar
        {
            /*0x10*/ char lowChar;
            /*0x12*/ char highChar;

            /*0x75a97f8*/ SurrogateChar(int ch);
            /*0x75b34bc*/ SurrogateChar(char lowChar, char highChar);
            /*0x75b36b0*/ char get_LowChar();
            /*0x75b36b8*/ char get_HighChar();
            /*0x75b36c0*/ int get_Char();
        }
    }

    namespace Runtime
    {
        namespace Serialization
        {
            class Attributes
            {
                static /*0x0*/ System.Xml.XmlDictionaryString[] serializationLocalNames;
                static /*0x8*/ System.Xml.XmlDictionaryString[] schemaInstanceLocalNames;
                /*0x10*/ string Id;
                /*0x18*/ string Ref;
                /*0x20*/ string XsiTypeName;
                /*0x28*/ string XsiTypeNamespace;
                /*0x30*/ string XsiTypePrefix;
                /*0x38*/ bool XsiNil;
                /*0x40*/ string ClrAssembly;
                /*0x48*/ string ClrType;
                /*0x50*/ int ArraySZSize;
                /*0x58*/ string FactoryTypeName;
                /*0x60*/ string FactoryTypeNamespace;
                /*0x68*/ string FactoryTypePrefix;
                /*0x70*/ bool UnrecognizedAttributesFound;

                static /*0x75b36e0*/ Attributes();
                /*0x75b4078*/ Attributes();
                /*0x75b39c0*/ void Read(System.Runtime.Serialization.XmlReaderDelegator reader);
                /*0x75b3c10*/ void Reset();
                /*0x75b3d20*/ void ReadId(System.Runtime.Serialization.XmlReaderDelegator reader);
                /*0x75b3ec0*/ void ReadRef(System.Runtime.Serialization.XmlReaderDelegator reader);
                /*0x75b3fec*/ void ReadXsiNil(System.Runtime.Serialization.XmlReaderDelegator reader);
                /*0x75b3dec*/ void ReadArraySize(System.Runtime.Serialization.XmlReaderDelegator reader);
                /*0x75b4018*/ void ReadXsiType(System.Runtime.Serialization.XmlReaderDelegator reader);
                /*0x75b3f8c*/ void ReadFactoryType(System.Runtime.Serialization.XmlReaderDelegator reader);
            }

            class ClassDataContract : System.Runtime.Serialization.DataContract
            {
                /*0x28*/ System.Xml.XmlDictionaryString[] ContractNamespaces;
                /*0x30*/ System.Xml.XmlDictionaryString[] MemberNames;
                /*0x38*/ System.Xml.XmlDictionaryString[] MemberNamespaces;
                /*0x40*/ System.Xml.XmlDictionaryString[] childElementNamespaces;
                /*0x48*/ System.Runtime.Serialization.ClassDataContract.ClassDataContractCriticalHelper helper;

                static /*0x75b5d9c*/ System.Runtime.Serialization.ClassDataContract CreateClassDataContractForKeyValue(System.Type type, System.Xml.XmlDictionaryString ns, string[] memberNames);
                static /*0x75b5e0c*/ void CheckAndAddMember(System.Collections.Generic.List<System.Runtime.Serialization.DataMember> members, System.Runtime.Serialization.DataMember memberContract, System.Collections.Generic.Dictionary<string, System.Runtime.Serialization.DataMember> memberNamesTable);
                static /*0x75b6138*/ System.Xml.XmlDictionaryString GetChildNamespaceToDeclare(System.Runtime.Serialization.DataContract dataContract, System.Type childType, System.Xml.XmlDictionary dictionary);
                static /*0x75b62bc*/ bool IsNonAttributedTypeValidForSerialization(System.Type type);
                /*0x75b4080*/ ClassDataContract(System.Type type);
                /*0x75b4d38*/ ClassDataContract(System.Type type, System.Xml.XmlDictionaryString ns, string[] memberNames);
                /*0x75b4c20*/ void InitClassDataContract();
                /*0x75b5148*/ System.Runtime.Serialization.ClassDataContract get_BaseContract();
                /*0x75b5164*/ System.Collections.Generic.List<System.Runtime.Serialization.DataMember> get_Members();
                /*0x75b5180*/ System.Xml.XmlDictionaryString[] get_ChildElementNamespaces();
                /*0x75b54ac*/ System.Reflection.MethodInfo get_OnSerializing();
                /*0x75b54e8*/ System.Reflection.MethodInfo get_OnSerialized();
                /*0x75b5524*/ System.Reflection.MethodInfo get_OnDeserializing();
                /*0x75b5560*/ System.Reflection.MethodInfo get_OnDeserialized();
                /*0x75b559c*/ System.Reflection.MethodInfo get_ExtensionDataSetMethod();
                /*0x75b55d8*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> get_KnownDataContracts();
                /*0x75b55f8*/ bool get_IsISerializable();
                /*0x75b5618*/ bool get_IsNonAttributedType();
                /*0x75b5634*/ bool get_HasExtensionData();
                /*0x75b5650*/ string get_SerializationExceptionMessage();
                /*0x75b566c*/ string get_DeserializationExceptionMessage();
                /*0x75b5758*/ bool get_IsReadOnlyContract();
                /*0x75b577c*/ System.Reflection.ConstructorInfo GetISerializableConstructor();
                /*0x75b58dc*/ System.Reflection.ConstructorInfo GetNonAttributedTypeConstructor();
                /*0x75b5a88*/ System.Runtime.Serialization.XmlFormatClassWriterDelegate get_XmlFormatWriterDelegate();
                /*0x75b5bf8*/ System.Runtime.Serialization.XmlFormatClassReaderDelegate get_XmlFormatReaderDelegate();
                /*0x75b52bc*/ System.Xml.XmlDictionaryString[] CreateChildElementNamespaces();
                /*0x75b6684*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75b66dc*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
                /*0x75b6750*/ bool Equals(object other, System.Collections.Generic.Dictionary<System.Runtime.Serialization.DataContractPairKey, object> checkedContracts);
                /*0x75b6bb4*/ bool IsEveryDataMemberOptional(System.Collections.Generic.IEnumerable<System.Runtime.Serialization.DataMember> dataMembers);
                /*0x75b6e9c*/ int GetHashCode();

                class ClassDataContractCriticalHelper : System.Runtime.Serialization.DataContract.DataContractCriticalHelper
                {
                    static /*0x0*/ System.Type[] serInfoCtorArgs;
                    /*0x58*/ System.Runtime.Serialization.ClassDataContract baseContract;
                    /*0x60*/ System.Collections.Generic.List<System.Runtime.Serialization.DataMember> members;
                    /*0x68*/ System.Reflection.MethodInfo onSerializing;
                    /*0x70*/ System.Reflection.MethodInfo onSerialized;
                    /*0x78*/ System.Reflection.MethodInfo onDeserializing;
                    /*0x80*/ System.Reflection.MethodInfo onDeserialized;
                    /*0x88*/ System.Reflection.MethodInfo extensionDataSetMethod;
                    /*0x90*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> knownDataContracts;
                    /*0x98*/ string serializationExceptionMessage;
                    /*0xa0*/ bool isISerializable;
                    /*0xa1*/ bool isKnownTypeAttributeChecked;
                    /*0xa2*/ bool isMethodChecked;
                    /*0xa3*/ bool hasExtensionData;
                    /*0xa4*/ bool isNonAttributedType;
                    /*0xa5*/ bool hasDataContract;
                    /*0xa8*/ System.Xml.XmlDictionaryString[] childElementNamespaces;
                    /*0xb0*/ System.Runtime.Serialization.XmlFormatClassReaderDelegate xmlFormatReaderDelegate;
                    /*0xb8*/ System.Runtime.Serialization.XmlFormatClassWriterDelegate xmlFormatWriterDelegate;
                    /*0xc0*/ System.Xml.XmlDictionaryString[] ContractNamespaces;
                    /*0xc8*/ System.Xml.XmlDictionaryString[] MemberNames;
                    /*0xd0*/ System.Xml.XmlDictionaryString[] MemberNamespaces;

                    static /*0x75b8b20*/ bool IsMethodOverriding(System.Reflection.MethodInfo method);
                    static /*0x75b9870*/ bool IsValidCallback(System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] parameters, System.Type attributeType, System.Reflection.MethodInfo currentCallback, ref System.Type prevAttributeType);
                    static /*0x75ba120*/ System.Type[] get_SerInfoCtorArgs();
                    /*0x75b40f4*/ ClassDataContractCriticalHelper(System.Type type);
                    /*0x75b4dc4*/ ClassDataContractCriticalHelper(System.Type type, System.Xml.XmlDictionaryString ns, string[] memberNames);
                    /*0x75b8750*/ void EnsureIsReferenceImported(System.Type type);
                    /*0x75b7520*/ void ImportDataMembers();
                    /*0x75b8b68*/ bool SetIfGetOnlyCollection(System.Runtime.Serialization.DataMember memberContract, bool skipIfReadOnlyContract);
                    /*0x75b8bf0*/ void SetIfMembersHaveConflict(System.Collections.Generic.List<System.Runtime.Serialization.DataMember> members);
                    /*0x75b6ea4*/ System.Xml.XmlQualifiedName GetStableNameAndSetHasDataContract(System.Type type);
                    /*0x75b72b8*/ void SetIsNonAttributedType(System.Type type);
                    /*0x75b6eb8*/ void EnsureMethodsImported();
                    /*0x75b9390*/ bool IsValidExtensionDataSetMethod(System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] parameters);
                    /*0x75b9fb8*/ System.Runtime.Serialization.ClassDataContract get_BaseContract();
                    /*0x75b7334*/ void set_BaseContract(System.Runtime.Serialization.ClassDataContract value);
                    /*0x75b9fc0*/ System.Collections.Generic.List<System.Runtime.Serialization.DataMember> get_Members();
                    /*0x75b54d0*/ System.Reflection.MethodInfo get_OnSerializing();
                    /*0x75b550c*/ System.Reflection.MethodInfo get_OnSerialized();
                    /*0x75b5548*/ System.Reflection.MethodInfo get_OnDeserializing();
                    /*0x75b5584*/ System.Reflection.MethodInfo get_OnDeserialized();
                    /*0x75b55c0*/ System.Reflection.MethodInfo get_ExtensionDataSetMethod();
                    /*0x75b9fc8*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> get_KnownDataContracts();
                    /*0x75ba0f8*/ string get_SerializationExceptionMessage();
                    /*0x75b5684*/ string get_DeserializationExceptionMessage();
                    /*0x75ba100*/ bool get_IsISerializable();
                    /*0x75ba108*/ bool get_HasDataContract();
                    /*0x75ba110*/ bool get_HasExtensionData();
                    /*0x75ba118*/ bool get_IsNonAttributedType();
                    /*0x75b5794*/ System.Reflection.ConstructorInfo GetISerializableConstructor();
                    /*0x75b58f4*/ System.Reflection.ConstructorInfo GetNonAttributedTypeConstructor();
                    /*0x75ba29c*/ System.Runtime.Serialization.XmlFormatClassWriterDelegate get_XmlFormatWriterDelegate();
                    /*0x75ba2a4*/ void set_XmlFormatWriterDelegate(System.Runtime.Serialization.XmlFormatClassWriterDelegate value);
                    /*0x75ba2ac*/ System.Runtime.Serialization.XmlFormatClassReaderDelegate get_XmlFormatReaderDelegate();
                    /*0x75ba2b4*/ void set_XmlFormatReaderDelegate(System.Runtime.Serialization.XmlFormatClassReaderDelegate value);
                    /*0x75ba2bc*/ System.Xml.XmlDictionaryString[] get_ChildElementNamespaces();
                    /*0x75ba2c4*/ void set_ChildElementNamespaces(System.Xml.XmlDictionaryString[] value);

                    struct Member
                    {
                        /*0x10*/ System.Runtime.Serialization.DataMember member;
                        /*0x18*/ string ns;
                        /*0x20*/ int baseTypeIndex;

                        /*0x75b9354*/ Member(System.Runtime.Serialization.DataMember member, string ns, int baseTypeIndex);
                    }

                    class DataMemberConflictComparer : System.Collections.Generic.IComparer<System.Runtime.Serialization.ClassDataContract.ClassDataContractCriticalHelper.Member>
                    {
                        static /*0x0*/ System.Runtime.Serialization.ClassDataContract.ClassDataContractCriticalHelper.DataMemberConflictComparer Singleton;

                        static /*0x75ba350*/ DataMemberConflictComparer();
                        /*0x75ba348*/ DataMemberConflictComparer();
                        /*0x75ba2cc*/ int Compare(System.Runtime.Serialization.ClassDataContract.ClassDataContractCriticalHelper.Member x, System.Runtime.Serialization.ClassDataContract.ClassDataContractCriticalHelper.Member y);
                    }
                }

                class DataMemberComparer : System.Collections.Generic.IComparer<System.Runtime.Serialization.DataMember>
                {
                    static /*0x0*/ System.Runtime.Serialization.ClassDataContract.DataMemberComparer Singleton;

                    static /*0x75ba440*/ DataMemberComparer();
                    /*0x75ba438*/ DataMemberComparer();
                    /*0x75ba3b8*/ int Compare(System.Runtime.Serialization.DataMember x, System.Runtime.Serialization.DataMember y);
                }
            }

            struct KeyValue<K, V>
            {
                /*0x0*/ K key;
                /*0x0*/ V value;

                /*0x3910ae8*/ KeyValue(K key, V value);
            }

            enum CollectionKind
            {
                None = 0,
                GenericDictionary = 1,
                Dictionary = 2,
                GenericList = 3,
                GenericCollection = 4,
                List = 5,
                GenericEnumerable = 6,
                Collection = 7,
                Enumerable = 8,
                Array = 9,
            }

            class CollectionDataContract : System.Runtime.Serialization.DataContract
            {
                /*0x28*/ System.Xml.XmlDictionaryString collectionItemName;
                /*0x30*/ System.Xml.XmlDictionaryString childElementNamespace;
                /*0x38*/ System.Runtime.Serialization.DataContract itemContract;
                /*0x40*/ System.Runtime.Serialization.CollectionDataContract.CollectionDataContractCriticalHelper helper;

                static /*0x75baac0*/ System.Type[] get_KnownInterfaces();
                static /*0x75b65a0*/ bool IsCollectionInterface(System.Type type);
                static /*0x75bb430*/ bool IsCollection(System.Type type);
                static /*0x75bb454*/ bool IsCollection(System.Type type, ref System.Type itemType);
                static /*0x75b932c*/ bool IsCollection(System.Type type, bool constructorRequired, bool skipIfReadOnlyContract);
                static /*0x75bb460*/ bool IsCollectionHelper(System.Type type, ref System.Type itemType, bool constructorRequired, bool skipIfReadOnlyContract);
                static /*0x75bc84c*/ bool TryCreate(System.Type type, ref System.Runtime.Serialization.DataContract dataContract);
                static /*0x75bc878*/ bool TryCreateGetOnlyCollectionDataContract(System.Type type, ref System.Runtime.Serialization.DataContract dataContract);
                static /*0x75bc92c*/ System.Reflection.MethodInfo GetTargetMethodWithName(string name, System.Type type, System.Type interfaceType);
                static /*0x75bc9fc*/ bool IsArraySegment(System.Type t);
                static /*0x75bb500*/ bool IsCollectionOrTryCreate(System.Type type, bool tryCreate, ref System.Runtime.Serialization.DataContract dataContract, ref System.Type itemType, bool constructorRequired, bool skipIfReadOnlyContract);
                static /*0x75bcce4*/ bool IsCollectionDataContract(System.Type type);
                static /*0x75bcabc*/ bool HandleIfInvalidCollection(System.Type type, bool tryCreate, bool hasCollectionDataContract, bool createContractWithException, string message, string param, ref System.Runtime.Serialization.DataContract dataContract);
                static /*0x75bcd58*/ void GetReadOnlyCollectionExceptionMessages(System.Type type, bool hasCollectionDataContract, string message, string param, ref string serializationExceptionMessage, ref string deserializationExceptionMessage);
                static /*0x75bd300*/ string GetInvalidCollectionMessage(string message, string nestedMessage, string param);
                static /*0x75bd428*/ void FindCollectionMethodsOnInterface(System.Type type, System.Type interfaceType, ref System.Reflection.MethodInfo addMethod, ref System.Reflection.MethodInfo getEnumeratorMethod);
                static /*0x75bcf2c*/ void GetCollectionMethods(System.Type type, System.Type interfaceType, System.Type[] addMethodTypeArray, bool addMethodOnInterface, ref System.Reflection.MethodInfo getEnumeratorMethod, ref System.Reflection.MethodInfo addMethod);
                static /*0x75bd590*/ bool IsKnownInterface(System.Type type);
                /*0x75ba4a8*/ CollectionDataContract(System.Type type);
                /*0x75ba650*/ CollectionDataContract(System.Type type, System.Runtime.Serialization.DataContract itemContract);
                /*0x75ba6d4*/ CollectionDataContract(System.Type type, System.Runtime.Serialization.CollectionKind kind, System.Type itemType, System.Reflection.MethodInfo getEnumeratorMethod, string serializationExceptionMessage, string deserializationExceptionMessage);
                /*0x75ba898*/ CollectionDataContract(System.Type type, System.Runtime.Serialization.CollectionKind kind, System.Type itemType, System.Reflection.MethodInfo getEnumeratorMethod, System.Reflection.MethodInfo addMethod, System.Reflection.ConstructorInfo constructor);
                /*0x75ba958*/ CollectionDataContract(System.Type type, System.Runtime.Serialization.CollectionKind kind, System.Type itemType, System.Reflection.MethodInfo getEnumeratorMethod, System.Reflection.MethodInfo addMethod, System.Reflection.ConstructorInfo constructor, bool isConstructorCheckRequired);
                /*0x75baa30*/ CollectionDataContract(System.Type type, string invalidCollectionInSharedContractMessage);
                /*0x75ba524*/ void InitCollectionDataContract(System.Runtime.Serialization.DataContract sharedTypeContract);
                /*0x75baac8*/ System.Runtime.Serialization.CollectionKind get_Kind();
                /*0x75baae4*/ System.Type get_ItemType();
                /*0x75bab00*/ System.Runtime.Serialization.DataContract get_ItemContract();
                /*0x75b7318*/ System.Runtime.Serialization.DataContract get_SharedTypeContract();
                /*0x75bab30*/ string get_ItemName();
                /*0x75bab4c*/ System.Xml.XmlDictionaryString get_CollectionItemName();
                /*0x75bab54*/ string get_KeyName();
                /*0x75bab70*/ bool get_IsDictionary();
                /*0x75bab94*/ System.Xml.XmlDictionaryString get_ChildElementNamespace();
                /*0x75bad24*/ bool get_IsItemTypeNullable();
                /*0x75bad40*/ bool get_IsConstructorCheckRequired();
                /*0x75bad5c*/ void set_IsConstructorCheckRequired(bool value);
                /*0x75bad7c*/ System.Reflection.MethodInfo get_GetEnumeratorMethod();
                /*0x75bad98*/ System.Reflection.MethodInfo get_AddMethod();
                /*0x75badb4*/ System.Reflection.ConstructorInfo get_Constructor();
                /*0x75badd0*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> get_KnownDataContracts();
                /*0x75badf0*/ string get_InvalidCollectionInSharedContractMessage();
                /*0x75bae0c*/ string get_SerializationExceptionMessage();
                /*0x75bae28*/ string get_DeserializationExceptionMessage();
                /*0x75bae44*/ bool get_IsReadOnlyContract();
                /*0x75bae68*/ System.Runtime.Serialization.XmlFormatCollectionWriterDelegate get_XmlFormatWriterDelegate();
                /*0x75bafd8*/ System.Runtime.Serialization.XmlFormatCollectionReaderDelegate get_XmlFormatReaderDelegate();
                /*0x75bb160*/ System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate get_XmlFormatGetOnlyCollectionReaderDelegate();
                /*0x75ba794*/ System.Runtime.Serialization.DataContract GetSharedTypeContract(System.Type type);
                /*0x75bd670*/ System.Runtime.Serialization.DataContract GetValidContract(System.Runtime.Serialization.SerializationMode mode);
                /*0x75bd6cc*/ void ThrowIfInvalid();
                /*0x75bd744*/ System.Runtime.Serialization.DataContract GetValidContract();
                /*0x75bd774*/ void CheckConstructor();
                /*0x75bd8ac*/ bool IsValidContract(System.Runtime.Serialization.SerializationMode mode);
                /*0x75bd8ec*/ bool Equals(object other, System.Collections.Generic.Dictionary<System.Runtime.Serialization.DataContractPairKey, object> checkedContracts);
                /*0x75bda90*/ int GetHashCode();
                /*0x75bda98*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75bdb0c*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);

                class CollectionDataContractCriticalHelper : System.Runtime.Serialization.DataContract.DataContractCriticalHelper
                {
                    static /*0x0*/ System.Type[] _knownInterfaces;
                    /*0x58*/ System.Type itemType;
                    /*0x60*/ bool isItemTypeNullable;
                    /*0x61*/ System.Runtime.Serialization.CollectionKind kind;
                    /*0x68*/ System.Reflection.MethodInfo getEnumeratorMethod;
                    /*0x70*/ System.Reflection.MethodInfo addMethod;
                    /*0x78*/ System.Reflection.ConstructorInfo constructor;
                    /*0x80*/ string serializationExceptionMessage;
                    /*0x88*/ string deserializationExceptionMessage;
                    /*0x90*/ System.Runtime.Serialization.DataContract itemContract;
                    /*0x98*/ System.Runtime.Serialization.DataContract sharedTypeContract;
                    /*0xa0*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> knownDataContracts;
                    /*0xa8*/ bool isKnownTypeAttributeChecked;
                    /*0xb0*/ string itemName;
                    /*0xb8*/ bool itemNameSetExplicit;
                    /*0xc0*/ System.Xml.XmlDictionaryString collectionItemName;
                    /*0xc8*/ string keyName;
                    /*0xd0*/ string valueName;
                    /*0xd8*/ System.Xml.XmlDictionaryString childElementNamespace;
                    /*0xe0*/ string invalidCollectionInSharedContractMessage;
                    /*0xe8*/ System.Runtime.Serialization.XmlFormatCollectionReaderDelegate xmlFormatReaderDelegate;
                    /*0xf0*/ System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate xmlFormatGetOnlyCollectionReaderDelegate;
                    /*0xf8*/ System.Runtime.Serialization.XmlFormatCollectionWriterDelegate xmlFormatWriterDelegate;
                    /*0x100*/ bool isConstructorCheckRequired;

                    static /*0x75bdc20*/ System.Type[] get_KnownInterfaces();
                    /*0x75beff4*/ CollectionDataContractCriticalHelper(System.Type type);
                    /*0x75bf40c*/ CollectionDataContractCriticalHelper(System.Type type, System.Runtime.Serialization.DataContract itemContract);
                    /*0x75bf640*/ CollectionDataContractCriticalHelper(System.Type type, System.Runtime.Serialization.CollectionKind kind, System.Type itemType, System.Reflection.MethodInfo getEnumeratorMethod, string serializationExceptionMessage, string deserializationExceptionMessage);
                    /*0x75bf924*/ CollectionDataContractCriticalHelper(System.Type type, System.Runtime.Serialization.CollectionKind kind, System.Type itemType, System.Reflection.MethodInfo getEnumeratorMethod, System.Reflection.MethodInfo addMethod, System.Reflection.ConstructorInfo constructor);
                    /*0x75bfa50*/ CollectionDataContractCriticalHelper(System.Type type, System.Runtime.Serialization.CollectionKind kind, System.Type itemType, System.Reflection.MethodInfo getEnumeratorMethod, System.Reflection.MethodInfo addMethod, System.Reflection.ConstructorInfo constructor, bool isConstructorCheckRequired);
                    /*0x75bfa74*/ CollectionDataContractCriticalHelper(System.Type type, string invalidCollectionInSharedContractMessage);
                    /*0x75be714*/ void Init(System.Runtime.Serialization.CollectionKind kind, System.Type itemType, System.Runtime.Serialization.CollectionDataContractAttribute collectionContractAttribute);
                    /*0x75bfb00*/ System.Runtime.Serialization.CollectionKind get_Kind();
                    /*0x75bfb08*/ System.Type get_ItemType();
                    /*0x75bfb10*/ System.Runtime.Serialization.DataContract get_ItemContract();
                    /*0x75bfd9c*/ System.Runtime.Serialization.DataContract get_SharedTypeContract();
                    /*0x75bfda4*/ void set_SharedTypeContract(System.Runtime.Serialization.DataContract value);
                    /*0x75bfdac*/ string get_ItemName();
                    /*0x75bfdb4*/ bool get_IsConstructorCheckRequired();
                    /*0x75bfdbc*/ void set_IsConstructorCheckRequired(bool value);
                    /*0x75bfdc8*/ System.Xml.XmlDictionaryString get_CollectionItemName();
                    /*0x75bfdd0*/ string get_KeyName();
                    /*0x75bfdd8*/ string get_ValueName();
                    /*0x75bfd08*/ bool get_IsDictionary();
                    /*0x75bfde0*/ string get_SerializationExceptionMessage();
                    /*0x75bfde8*/ string get_DeserializationExceptionMessage();
                    /*0x75bfdf0*/ System.Xml.XmlDictionaryString get_ChildElementNamespace();
                    /*0x75bfdf8*/ void set_ChildElementNamespace(System.Xml.XmlDictionaryString value);
                    /*0x75bfe00*/ bool get_IsItemTypeNullable();
                    /*0x75bfe08*/ System.Reflection.MethodInfo get_GetEnumeratorMethod();
                    /*0x75bfe10*/ System.Reflection.MethodInfo get_AddMethod();
                    /*0x75bfe18*/ System.Reflection.ConstructorInfo get_Constructor();
                    /*0x75bfe20*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> get_KnownDataContracts();
                    /*0x75bffd4*/ string get_InvalidCollectionInSharedContractMessage();
                    /*0x75bffdc*/ System.Runtime.Serialization.XmlFormatCollectionWriterDelegate get_XmlFormatWriterDelegate();
                    /*0x75bffe4*/ void set_XmlFormatWriterDelegate(System.Runtime.Serialization.XmlFormatCollectionWriterDelegate value);
                    /*0x75bffec*/ System.Runtime.Serialization.XmlFormatCollectionReaderDelegate get_XmlFormatReaderDelegate();
                    /*0x75bfff4*/ void set_XmlFormatReaderDelegate(System.Runtime.Serialization.XmlFormatCollectionReaderDelegate value);
                    /*0x75bfffc*/ System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate get_XmlFormatGetOnlyCollectionReaderDelegate();
                    /*0x75c0004*/ void set_XmlFormatGetOnlyCollectionReaderDelegate(System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate value);
                }

                class DictionaryEnumerator : System.Collections.Generic.IEnumerator<System.Runtime.Serialization.KeyValue<object, object>>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ System.Collections.IDictionaryEnumerator enumerator;

                    /*0x75c000c*/ DictionaryEnumerator(System.Collections.IDictionaryEnumerator enumerator);
                    /*0x75c003c*/ void Dispose();
                    /*0x75c0040*/ bool MoveNext();
                    /*0x75c00e0*/ System.Runtime.Serialization.KeyValue<object, object> get_Current();
                    /*0x75c0224*/ object System.Collections.IEnumerator.get_Current();
                    /*0x75c0288*/ void Reset();
                }

                class GenericDictionaryEnumerator<K, V> : System.Collections.Generic.IEnumerator<System.Runtime.Serialization.KeyValue<K, V>>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x0*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<K, V>> enumerator;

                    /*0x38159dc*/ void Dispose();
                    /*0x3813ffc*/ bool MoveNext();
                    /*0x3910ae8*/ System.Runtime.Serialization.KeyValue<K, V> get_Current();
                    /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
                    /*0x38159dc*/ void Reset();
                }
            }

            class CollectionDataContractAttribute : System.Attribute
            {
                /*0x10*/ string name;
                /*0x18*/ string ns;
                /*0x20*/ string itemName;
                /*0x28*/ string keyName;
                /*0x30*/ string valueName;
                /*0x38*/ bool isReference;
                /*0x39*/ bool isNameSetExplicitly;
                /*0x3a*/ bool isNamespaceSetExplicitly;
                /*0x3b*/ bool isItemNameSetExplicitly;
                /*0x3c*/ bool isKeyNameSetExplicitly;
                /*0x3d*/ bool isValueNameSetExplicitly;

                /*0x75c032c*/ string get_Namespace();
                /*0x75c0334*/ bool get_IsNamespaceSetExplicitly();
                /*0x75c033c*/ string get_Name();
                /*0x75c0344*/ bool get_IsNameSetExplicitly();
                /*0x75c034c*/ string get_ItemName();
                /*0x75c0354*/ bool get_IsItemNameSetExplicitly();
                /*0x75c035c*/ string get_KeyName();
                /*0x75c0364*/ bool get_IsReference();
                /*0x75c036c*/ bool get_IsKeyNameSetExplicitly();
                /*0x75c0374*/ string get_ValueName();
                /*0x75c037c*/ bool get_IsValueNameSetExplicitly();
            }

            class ContractNamespaceAttribute : System.Attribute
            {
                /*0x10*/ string clrNamespace;
                /*0x18*/ string contractNamespace;

                /*0x75c0384*/ string get_ClrNamespace();
                /*0x75c038c*/ string get_ContractNamespace();
            }

            class DataContract
            {
                /*0x10*/ System.Xml.XmlDictionaryString name;
                /*0x18*/ System.Xml.XmlDictionaryString ns;
                /*0x20*/ System.Runtime.Serialization.DataContract.DataContractCriticalHelper helper;

                static /*0x75bfd68*/ System.Runtime.Serialization.DataContract GetDataContract(System.Type type);
                static /*0x75c03ec*/ System.Runtime.Serialization.DataContract GetDataContract(System.RuntimeTypeHandle typeHandle, System.Type type, System.Runtime.Serialization.SerializationMode mode);
                static /*0x75c0468*/ System.Runtime.Serialization.DataContract GetDataContract(int id, System.RuntimeTypeHandle typeHandle, System.Runtime.Serialization.SerializationMode mode);
                static /*0x75c0498*/ System.Runtime.Serialization.DataContract GetDataContractSkipValidation(int id, System.RuntimeTypeHandle typeHandle, System.Type type);
                static /*0x75c05cc*/ System.Runtime.Serialization.DataContract GetGetOnlyCollectionDataContract(int id, System.RuntimeTypeHandle typeHandle, System.Type type, System.Runtime.Serialization.SerializationMode mode);
                static /*0x75c0720*/ System.Runtime.Serialization.DataContract GetGetOnlyCollectionDataContractSkipValidation(int id, System.RuntimeTypeHandle typeHandle, System.Type type);
                static /*0x75c0864*/ System.Runtime.Serialization.DataContract GetDataContractForInitialization(int id);
                static /*0x75c0998*/ int GetIdForInitialization(System.Runtime.Serialization.ClassDataContract classContract);
                static /*0x75c0414*/ int GetId(System.RuntimeTypeHandle typeHandle);
                static /*0x75c0ee4*/ System.Runtime.Serialization.DataContract GetBuiltInDataContract(System.Type type);
                static /*0x75c11e4*/ System.Runtime.Serialization.DataContract GetBuiltInDataContract(string name, string ns);
                static /*0x75c14e8*/ System.Runtime.Serialization.DataContract GetBuiltInDataContract(string typeName);
                static /*0x75c22a0*/ string GetNamespace(string key);
                static /*0x75c2618*/ System.Xml.XmlDictionaryString GetClrTypeString(string key);
                static /*0x75bfd18*/ void ThrowInvalidDataContractException(string message, System.Type type);
                static /*0x75c357c*/ bool IsTypeSerializable(System.Type type);
                static /*0x75c35f4*/ bool IsTypeSerializable(System.Type type, System.Collections.Generic.Dictionary<System.Type, object> previousCollectionTypes);
                static /*0x75c3944*/ void ValidatePreviousCollectionTypes(System.Type collectionType, System.Type itemType, System.Collections.Generic.Dictionary<System.Type, object> previousCollectionTypes);
                static /*0x75c3d2c*/ System.Type UnwrapRedundantNullableType(System.Type type);
                static /*0x75beee0*/ System.Type UnwrapNullableType(System.Type type);
                static /*0x75c3f5c*/ bool IsAlpha(char ch);
                static /*0x75c3f88*/ bool IsDigit(char ch);
                static /*0x75c3f9c*/ bool IsAsciiLocalName(string localName);
                static /*0x75bee60*/ string EncodeLocalName(string localName);
                static /*0x75c405c*/ bool IsValidNCName(string name);
                static /*0x75befdc*/ System.Xml.XmlQualifiedName GetStableName(System.Type type);
                static /*0x75c4134*/ System.Xml.XmlQualifiedName GetStableName(System.Type type, ref bool hasDataContract);
                static /*0x75c41b4*/ System.Xml.XmlQualifiedName GetStableName(System.Type type, System.Collections.Generic.Dictionary<System.Type, object> previousCollectionTypes, ref bool hasDataContract);
                static /*0x75c44d0*/ System.Xml.XmlQualifiedName GetDCTypeStableName(System.Type type, System.Runtime.Serialization.DataContractAttribute dataContractAttribute);
                static /*0x75c469c*/ System.Xml.XmlQualifiedName GetNonDCTypeStableName(System.Type type, System.Collections.Generic.Dictionary<System.Type, object> previousCollectionTypes);
                static /*0x75c4240*/ bool TryGetBuiltInXmlAndArrayTypeStableName(System.Type type, System.Collections.Generic.Dictionary<System.Type, object> previousCollectionTypes, ref System.Xml.XmlQualifiedName stableName);
                static /*0x75c43c4*/ bool TryGetDCAttribute(System.Type type, ref System.Runtime.Serialization.DataContractAttribute dataContractAttribute);
                static /*0x75bf894*/ System.Xml.XmlQualifiedName GetCollectionStableName(System.Type type, System.Type itemType, ref System.Runtime.Serialization.CollectionDataContractAttribute collectionContractAttribute);
                static /*0x75c5240*/ System.Xml.XmlQualifiedName GetCollectionStableName(System.Type type, System.Type itemType, System.Collections.Generic.Dictionary<System.Type, object> previousCollectionTypes, ref System.Runtime.Serialization.CollectionDataContractAttribute collectionContractAttribute);
                static /*0x75c5708*/ string GetArrayPrefix(ref System.Type itemType);
                static /*0x75c57cc*/ string GetCollectionNamespace(string elementNs);
                static /*0x75c58a4*/ System.Xml.XmlQualifiedName GetDefaultStableName(System.Type type);
                static /*0x75c47a0*/ string GetDefaultStableLocalName(System.Type type);
                static /*0x75c5184*/ string GetDefaultDataContractNamespace(System.Type type);
                static /*0x75c58d4*/ System.Collections.Generic.IList<int> GetDataContractNameForGenericName(string typeName, System.Text.StringBuilder localName);
                static /*0x75c5820*/ bool IsBuiltInNamespace(string ns);
                static /*0x75c5580*/ string GetDefaultStableNamespace(System.Type type);
                static /*0x75bf5c4*/ System.Xml.XmlQualifiedName CreateQualifiedName(string localName, string ns);
                static /*0x75c6134*/ string GetDefaultStableNamespace(string clrNs);
                static /*0x75c4f64*/ void CheckExplicitDataContractNamespaceUri(string dataContractNs, System.Type type);
                static /*0x75bed60*/ string GetClrTypeFullName(System.Type type);
                static /*0x75c62ec*/ string GetClrAssemblyName(System.Type type, ref bool hasTypeForwardedFrom);
                static /*0x75c6408*/ string GetClrTypeFullNameUsingTypeForwardedFromAttribute(System.Type type);
                static /*0x75c643c*/ string GetClrTypeFullNameForArray(System.Type type);
                static /*0x75c6514*/ string GetClrTypeFullNameForNonArrayTypes(System.Type type);
                static /*0x75c678c*/ void GetClrNameAndNamespace(string fullTypeName, ref string localName, ref string ns);
                static /*0x75c68a0*/ void GetDefaultStableName(string fullTypeName, ref string localName, ref string ns);
                static /*0x75c6914*/ void GetDefaultStableName(System.Runtime.Serialization.CodeTypeReference typeReference, ref string localName, ref string ns);
                static /*0x75c5e44*/ string GetGlobalDataContractNamespace(string clrNs, System.Reflection.ICustomAttributeProvider customAttribuetProvider);
                static /*0x75c5c80*/ string GetNamespacesDigest(string namespaces);
                static /*0x75c4738*/ string ExpandGenericParameters(string format, System.Type type);
                static /*0x75c7050*/ string ExpandGenericParameters(string format, System.Runtime.Serialization.IGenericNameProvider genericNameProvider);
                static /*0x75bec7c*/ bool IsTypeNullable(System.Type type);
                static /*0x75c7a30*/ void ThrowTypeNotSerializable(System.Type type);
                static /*0x75bff4c*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> ImportKnownTypeAttributes(System.Type type);
                static /*0x75c7ac4*/ void ImportKnownTypeAttributes(System.Type type, System.Collections.Generic.Dictionary<System.Type, System.Type> typesChecked, ref System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> knownDataContracts);
                static /*0x75c8b70*/ void LoadKnownTypesFromConfig(System.Type type, System.Collections.Generic.Dictionary<System.Type, System.Type> typesChecked, ref System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> knownDataContracts);
                static /*0x75c85dc*/ void CheckAndAdd(System.Type type, System.Collections.Generic.Dictionary<System.Type, System.Type> typesChecked, ref System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> nameToDataContractTable);
                /*0x75c0394*/ DataContract(System.Runtime.Serialization.DataContract.DataContractCriticalHelper helper);
                /*0x75c2f08*/ System.Runtime.Serialization.DataContract.DataContractCriticalHelper get_Helper();
                /*0x75c078c*/ System.Type get_UnderlyingType();
                /*0x75c2f10*/ System.Type get_OriginalUnderlyingType();
                /*0x75c2fcc*/ bool get_IsBuiltInDataContract();
                /*0x75c2fec*/ System.Type get_TypeForInitialization();
                /*0x75c3008*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75c30fc*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
                /*0x75c31f0*/ bool get_IsValueType();
                /*0x75c320c*/ bool get_IsReference();
                /*0x75bf5a8*/ System.Xml.XmlQualifiedName get_StableName();
                /*0x75c3228*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> get_KnownDataContracts();
                /*0x75c3248*/ bool get_IsISerializable();
                /*0x75c3268*/ System.Xml.XmlDictionaryString get_Name();
                /*0x75c3270*/ System.Xml.XmlDictionaryString get_Namespace();
                /*0x75c3278*/ bool get_HasRoot();
                /*0x75c3280*/ System.Xml.XmlDictionaryString get_TopLevelElementName();
                /*0x75c32a0*/ System.Xml.XmlDictionaryString get_TopLevelElementNamespace();
                /*0x75c32c0*/ bool get_CanContainReferences();
                /*0x75c32c8*/ bool get_IsPrimitive();
                /*0x75c32d0*/ void WriteRootElement(System.Runtime.Serialization.XmlWriterDelegator writer, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75c33c0*/ System.Runtime.Serialization.DataContract GetValidContract(System.Runtime.Serialization.SerializationMode mode);
                /*0x75c33c4*/ System.Runtime.Serialization.DataContract GetValidContract();
                /*0x75c33c8*/ bool IsValidContract(System.Runtime.Serialization.SerializationMode mode);
                /*0x75c33d0*/ System.Reflection.MethodInfo get_ParseMethod();
                /*0x75c8c1c*/ bool Equals(object other);
                /*0x75c8cb8*/ bool Equals(object other, System.Collections.Generic.Dictionary<System.Runtime.Serialization.DataContractPairKey, object> checkedContracts);
                /*0x75c8dd4*/ bool IsEqualOrChecked(object other, System.Collections.Generic.Dictionary<System.Runtime.Serialization.DataContractPairKey, object> checkedContracts);
                /*0x75c8ee8*/ int GetHashCode();

                class DataContractCriticalHelper
                {
                    static /*0x0*/ System.Collections.Generic.Dictionary<System.Runtime.Serialization.TypeHandleRef, System.Runtime.Serialization.IntRef> typeToIDCache;
                    static /*0x8*/ System.Runtime.Serialization.DataContract[] dataContractCache;
                    static /*0x10*/ int dataContractID;
                    static /*0x18*/ System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.DataContract> typeToBuiltInContract;
                    static /*0x20*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> nameToBuiltInContract;
                    static /*0x28*/ System.Collections.Generic.Dictionary<string, System.Runtime.Serialization.DataContract> typeNameToBuiltInContract;
                    static /*0x30*/ System.Collections.Generic.Dictionary<string, string> namespaces;
                    static /*0x38*/ System.Collections.Generic.Dictionary<string, System.Xml.XmlDictionaryString> clrTypeStrings;
                    static /*0x40*/ System.Xml.XmlDictionary clrTypeStringsDictionary;
                    static /*0x48*/ System.Runtime.Serialization.TypeHandleRef typeHandleRef;
                    static /*0x50*/ object cacheLock;
                    static /*0x58*/ object createDataContractLock;
                    static /*0x60*/ object initBuiltInContractsLock;
                    static /*0x68*/ object namespacesLock;
                    static /*0x70*/ object clrTypeStringsLock;
                    /*0x10*/ System.Type underlyingType;
                    /*0x18*/ System.Type originalUnderlyingType;
                    /*0x20*/ bool isReference;
                    /*0x21*/ bool isValueType;
                    /*0x28*/ System.Xml.XmlQualifiedName stableName;
                    /*0x30*/ System.Xml.XmlDictionaryString name;
                    /*0x38*/ System.Xml.XmlDictionaryString ns;
                    /*0x40*/ System.Type typeForInitialization;
                    /*0x48*/ System.Reflection.MethodInfo parseMethod;
                    /*0x50*/ bool parseMethodSet;

                    static /*0x75c8ef0*/ DataContractCriticalHelper();
                    static /*0x75c0504*/ System.Runtime.Serialization.DataContract GetDataContractSkipValidation(int id, System.RuntimeTypeHandle typeHandle, System.Type type);
                    static /*0x75c07a8*/ System.Runtime.Serialization.DataContract GetGetOnlyCollectionDataContractSkipValidation(int id, System.RuntimeTypeHandle typeHandle, System.Type type);
                    static /*0x75c08b8*/ System.Runtime.Serialization.DataContract GetDataContractForInitialization(int id);
                    static /*0x75c09ec*/ int GetIdForInitialization(System.Runtime.Serialization.ClassDataContract classContract);
                    static /*0x75c9af8*/ bool ContractMatches(System.Runtime.Serialization.DataContract contract, System.Runtime.Serialization.DataContract cachedContract);
                    static /*0x75c0bc0*/ int GetId(System.RuntimeTypeHandle typeHandle);
                    static /*0x75c9c24*/ System.Runtime.Serialization.IntRef GetNextId();
                    static /*0x75c9134*/ System.Runtime.Serialization.DataContract CreateDataContract(int id, System.RuntimeTypeHandle typeHandle, System.Type type);
                    static /*0x75c9990*/ void AssignDataContractToId(System.Runtime.Serialization.DataContract dataContract, int id);
                    static /*0x75c96d0*/ System.Runtime.Serialization.DataContract CreateGetOnlyCollectionDataContract(int id, System.RuntimeTypeHandle typeHandle, System.Type type);
                    static /*0x75c8b74*/ System.Type GetDataContractAdapterType(System.Type type);
                    static /*0x75ca2b0*/ System.Type GetDataContractOriginalType(System.Type type);
                    static /*0x75c9b64*/ System.RuntimeTypeHandle GetDataContractAdapterTypeHandle(System.RuntimeTypeHandle typeHandle);
                    static /*0x75c0f38*/ System.Runtime.Serialization.DataContract GetBuiltInDataContract(System.Type type);
                    static /*0x75c1248*/ System.Runtime.Serialization.DataContract GetBuiltInDataContract(string name, string ns);
                    static /*0x75c153c*/ System.Runtime.Serialization.DataContract GetBuiltInDataContract(string typeName);
                    static /*0x75ca454*/ bool TryCreateBuiltInDataContract(System.Type type, ref System.Runtime.Serialization.DataContract dataContract);
                    static /*0x75cac68*/ bool TryCreateBuiltInDataContract(string name, string ns, ref System.Runtime.Serialization.DataContract dataContract);
                    static /*0x75c22f4*/ string GetNamespace(string key);
                    static /*0x75c266c*/ System.Xml.XmlDictionaryString GetClrTypeString(string key);
                    static /*0x75c2bdc*/ void ThrowInvalidDataContractException(string message, System.Type type);
                    /*0x75bf1b8*/ DataContractCriticalHelper(System.Type type);
                    /*0x75cc2dc*/ System.Type get_UnderlyingType();
                    /*0x75c2f28*/ System.Type get_OriginalUnderlyingType();
                    /*0x75cc2e4*/ bool get_IsBuiltInDataContract();
                    /*0x75cc2ec*/ System.Type get_TypeForInitialization();
                    /*0x75cc230*/ void SetTypeForInitialization(System.Type classType);
                    /*0x75cc2f4*/ bool get_IsReference();
                    /*0x75cc2fc*/ void set_IsReference(bool value);
                    /*0x75cc308*/ bool get_IsValueType();
                    /*0x75cc310*/ void set_IsValueType(bool value);
                    /*0x75cc31c*/ System.Xml.XmlQualifiedName get_StableName();
                    /*0x75cc324*/ void set_StableName(System.Xml.XmlQualifiedName value);
                    /*0x75cc32c*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> get_KnownDataContracts();
                    /*0x75cc334*/ bool get_IsISerializable();
                    /*0x75cc33c*/ System.Xml.XmlDictionaryString get_Name();
                    /*0x75cc344*/ void set_Name(System.Xml.XmlDictionaryString value);
                    /*0x75cc34c*/ System.Xml.XmlDictionaryString get_Namespace();
                    /*0x75cc354*/ void set_Namespace(System.Xml.XmlDictionaryString value);
                    /*0x75cc35c*/ bool get_HasRoot();
                    /*0x75cc364*/ void set_HasRoot(bool value);
                    /*0x75cc368*/ System.Xml.XmlDictionaryString get_TopLevelElementName();
                    /*0x75cc370*/ System.Xml.XmlDictionaryString get_TopLevelElementNamespace();
                    /*0x75c33e8*/ System.Reflection.MethodInfo get_ParseMethod();
                    /*0x75cc46c*/ void SetDataContractName(System.Xml.XmlQualifiedName stableName);
                    /*0x75cc530*/ void SetDataContractName(System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                    /*0x75cc58c*/ void ThrowInvalidDataContractException(string message);
                }
            }

            interface IGenericNameProvider
            {
                /*0x3814574*/ int GetParameterCount();
                /*0x38148bc*/ System.Collections.Generic.IList<int> GetNestedParameterCounts();
                /*0x3814964*/ string GetParameterName(int paramIndex);
                /*0x38148bc*/ string GetNamespaces();
                /*0x38148bc*/ string GetGenericTypeName();
                /*0x3813ffc*/ bool get_ParametersFromBuiltInNamespaces();
            }

            class GenericNameProvider : System.Runtime.Serialization.IGenericNameProvider
            {
                /*0x10*/ string genericTypeName;
                /*0x18*/ object[] genericParams;
                /*0x20*/ System.Collections.Generic.IList<int> nestedParamCounts;

                /*0x75c6ff0*/ GenericNameProvider(System.Type type);
                /*0x75cc5e0*/ GenericNameProvider(string genericTypeName, object[] genericParams);
                /*0x75cc6c4*/ int GetParameterCount();
                /*0x75cc6e0*/ System.Collections.Generic.IList<int> GetNestedParameterCounts();
                /*0x75cc6e8*/ string GetParameterName(int paramIndex);
                /*0x75cc8fc*/ string GetNamespaces();
                /*0x75cc9dc*/ string GetGenericTypeName();
                /*0x75cc9e4*/ bool get_ParametersFromBuiltInNamespaces();
                /*0x75cc704*/ System.Xml.XmlQualifiedName GetStableName(int i);
            }

            class DataContractPairKey
            {
                /*0x10*/ object object1;
                /*0x18*/ object object2;

                /*0x75c8ea4*/ DataContractPairKey(object object1, object object2);
                /*0x75cca48*/ bool Equals(object other);
                /*0x75ccb14*/ int GetHashCode();
            }

            class TypeHandleRefEqualityComparer : System.Collections.Generic.IEqualityComparer<System.Runtime.Serialization.TypeHandleRef>
            {
                /*0x75c912c*/ TypeHandleRefEqualityComparer();
                /*0x75ccb5c*/ bool Equals(System.Runtime.Serialization.TypeHandleRef x, System.Runtime.Serialization.TypeHandleRef y);
                /*0x75ccb94*/ int GetHashCode(System.Runtime.Serialization.TypeHandleRef obj);
            }

            class TypeHandleRef
            {
                /*0x10*/ System.RuntimeTypeHandle value;

                /*0x75c9124*/ TypeHandleRef();
                /*0x75c9d80*/ TypeHandleRef(System.RuntimeTypeHandle value);
                /*0x75ccbc0*/ System.RuntimeTypeHandle get_Value();
                /*0x75ccbc8*/ void set_Value(System.RuntimeTypeHandle value);
            }

            class IntRef
            {
                /*0x10*/ int value;

                /*0x75c9da8*/ IntRef(int value);
                /*0x75ccbd0*/ int get_Value();
            }

            class DataContractAttribute : System.Attribute
            {
                /*0x10*/ string name;
                /*0x18*/ string ns;
                /*0x20*/ bool isNameSetExplicitly;
                /*0x21*/ bool isNamespaceSetExplicitly;
                /*0x22*/ bool isReference;
                /*0x23*/ bool isReferenceSetExplicitly;

                /*0x75ccbd8*/ DataContractAttribute();
                /*0x75ccbe0*/ bool get_IsReference();
                /*0x75ccbe8*/ bool get_IsReferenceSetExplicitly();
                /*0x75ccbf0*/ string get_Namespace();
                /*0x75ccbf8*/ void set_Namespace(string value);
                /*0x75ccc1c*/ bool get_IsNamespaceSetExplicitly();
                /*0x75ccc24*/ string get_Name();
                /*0x75ccc2c*/ void set_Name(string value);
                /*0x75ccc50*/ bool get_IsNameSetExplicitly();
            }

            class DataContractResolver
            {
                /*0x75ccc58*/ DataContractResolver();
                /*0x3814288*/ bool TryResolveType(System.Type type, System.Type declaredType, System.Runtime.Serialization.DataContractResolver knownTypeResolver, ref System.Xml.XmlDictionaryString typeName, ref System.Xml.XmlDictionaryString typeNamespace);
                /*0x3814c50*/ System.Type ResolveName(string typeName, string typeNamespace, System.Type declaredType, System.Runtime.Serialization.DataContractResolver knownTypeResolver);
            }

            class DataContractSerializer : System.Runtime.Serialization.XmlObjectSerializer
            {
                /*0x10*/ System.Type rootType;
                /*0x18*/ System.Runtime.Serialization.DataContract rootContract;
                /*0x20*/ bool needsContractNsAtRoot;
                /*0x28*/ System.Xml.XmlDictionaryString rootName;
                /*0x30*/ System.Xml.XmlDictionaryString rootNamespace;
                /*0x38*/ int maxItemsInObjectGraph;
                /*0x3c*/ bool ignoreExtensionDataObject;
                /*0x3d*/ bool preserveObjectReferences;
                /*0x40*/ System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate;
                /*0x48*/ System.Collections.Generic.IList<System.Type> knownTypeList;
                /*0x50*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> knownDataContracts;
                /*0x58*/ System.Runtime.Serialization.DataContractResolver dataContractResolver;
                /*0x60*/ bool serializeReadOnlyTypes;

                static /*0x75cdc48*/ System.Runtime.Serialization.DataContract GetDataContract(System.Runtime.Serialization.DataContract declaredTypeContract, System.Type declaredType, System.Type objectType);
                static /*0x75cdb94*/ object SurrogateToDataContractType(System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate, object oldObj, System.Type surrogatedDeclaredType, ref System.Type objType);
                static /*0x75cd314*/ System.Type GetSurrogatedType(System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate, System.Type type);
                /*0x75ccc60*/ DataContractSerializer(System.Type type, System.Collections.Generic.IEnumerable<System.Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate);
                /*0x75cccd8*/ DataContractSerializer(System.Type type, System.Collections.Generic.IEnumerable<System.Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate, System.Runtime.Serialization.DataContractResolver dataContractResolver);
                /*0x75ccd5c*/ void Initialize(System.Type type, System.Collections.Generic.IEnumerable<System.Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate, System.Runtime.Serialization.DataContractResolver dataContractResolver, bool serializeReadOnlyTypes);
                /*0x75cd228*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> get_KnownDataContracts();
                /*0x75cd268*/ int get_MaxItemsInObjectGraph();
                /*0x75cd270*/ System.Runtime.Serialization.IDataContractSurrogate get_DataContractSurrogate();
                /*0x75cd278*/ bool get_PreserveObjectReferences();
                /*0x75cd280*/ bool get_IgnoreExtensionDataObject();
                /*0x75cd288*/ System.Runtime.Serialization.DataContractResolver get_DataContractResolver();
                /*0x75cd290*/ bool get_SerializeReadOnlyTypes();
                /*0x75cd298*/ System.Runtime.Serialization.DataContract get_RootContract();
                /*0x75cd338*/ void InternalWriteObject(System.Runtime.Serialization.XmlWriterDelegator writer, object graph);
                /*0x75cd34c*/ void InternalWriteObject(System.Runtime.Serialization.XmlWriterDelegator writer, object graph, System.Runtime.Serialization.DataContractResolver dataContractResolver);
                /*0x75cd7a4*/ void WriteStartObject(System.Xml.XmlWriter writer, object graph);
                /*0x75cd81c*/ void WriteObjectContent(System.Xml.XmlWriter writer, object graph);
                /*0x75cd894*/ void WriteEndObject(System.Xml.XmlWriter writer);
                /*0x75cd904*/ void WriteStartObject(System.Xml.XmlDictionaryWriter writer, object graph);
                /*0x75cd97c*/ void WriteObjectContent(System.Xml.XmlDictionaryWriter writer, object graph);
                /*0x75cd9f4*/ void WriteEndObject(System.Xml.XmlDictionaryWriter writer);
                /*0x75cda64*/ object ReadObject(System.Xml.XmlReader reader, bool verifyObjectName);
                /*0x75cdadc*/ object ReadObject(System.Xml.XmlDictionaryReader reader, bool verifyObjectName);
                /*0x75cdb54*/ void InternalWriteStartObject(System.Runtime.Serialization.XmlWriterDelegator writer, object graph);
                /*0x75cdb8c*/ void InternalWriteObjectContent(System.Runtime.Serialization.XmlWriterDelegator writer, object graph);
                /*0x75cd3b0*/ void InternalWriteObjectContent(System.Runtime.Serialization.XmlWriterDelegator writer, object graph, System.Runtime.Serialization.DataContractResolver dataContractResolver);
                /*0x75cdcd8*/ void InternalWriteEndObject(System.Runtime.Serialization.XmlWriterDelegator writer);
                /*0x75cdd30*/ object InternalReadObject(System.Runtime.Serialization.XmlReaderDelegator xmlReader, bool verifyObjectName);
                /*0x75cdd48*/ object InternalReadObject(System.Runtime.Serialization.XmlReaderDelegator xmlReader, bool verifyObjectName, System.Runtime.Serialization.DataContractResolver dataContractResolver);
                /*0x75ce0b0*/ bool InternalIsStartObject(System.Runtime.Serialization.XmlReaderDelegator reader);
                /*0x75ce0e4*/ System.Type GetSerializeType(object graph);
                /*0x75ce0fc*/ System.Type GetDeserializeType();
            }

            class DataMember
            {
                /*0x10*/ System.Runtime.Serialization.DataMember.CriticalHelper helper;

                /*0x75ce104*/ DataMember(System.Reflection.MemberInfo memberInfo);
                /*0x75ce1cc*/ System.Reflection.MemberInfo get_MemberInfo();
                /*0x75ce1e8*/ string get_Name();
                /*0x75ce204*/ void set_Name(string value);
                /*0x75ce220*/ int get_Order();
                /*0x75ce23c*/ void set_Order(int value);
                /*0x75ce258*/ bool get_IsRequired();
                /*0x75ce274*/ void set_IsRequired(bool value);
                /*0x75ce294*/ bool get_EmitDefaultValue();
                /*0x75ce2b0*/ void set_EmitDefaultValue(bool value);
                /*0x75ce2d0*/ bool get_IsNullable();
                /*0x75ce2ec*/ void set_IsNullable(bool value);
                /*0x75ce30c*/ bool get_IsGetOnlyCollection();
                /*0x75ce328*/ void set_IsGetOnlyCollection(bool value);
                /*0x75ce348*/ System.Type get_MemberType();
                /*0x75ce460*/ System.Runtime.Serialization.DataContract get_MemberTypeContract();
                /*0x75ce548*/ bool get_HasConflictingNameAndType();
                /*0x75ce564*/ void set_HasConflictingNameAndType(bool value);
                /*0x75ce584*/ System.Runtime.Serialization.DataMember get_ConflictingMember();
                /*0x75ce5a0*/ void set_ConflictingMember(System.Runtime.Serialization.DataMember value);
                /*0x75ce5bc*/ bool Equals(object other, System.Collections.Generic.Dictionary<System.Runtime.Serialization.DataContractPairKey, object> checkedContracts);
                /*0x75ce79c*/ int GetHashCode();

                class CriticalHelper
                {
                    /*0x10*/ System.Runtime.Serialization.DataContract memberTypeContract;
                    /*0x18*/ string name;
                    /*0x20*/ int order;
                    /*0x24*/ bool isRequired;
                    /*0x25*/ bool emitDefaultValue;
                    /*0x26*/ bool isNullable;
                    /*0x27*/ bool isGetOnlyCollection;
                    /*0x28*/ System.Reflection.MemberInfo memberInfo;
                    /*0x30*/ bool hasConflictingNameAndType;
                    /*0x38*/ System.Runtime.Serialization.DataMember conflictingMember;

                    /*0x75ce194*/ CriticalHelper(System.Reflection.MemberInfo memberInfo);
                    /*0x75ce7a4*/ System.Reflection.MemberInfo get_MemberInfo();
                    /*0x75ce7ac*/ string get_Name();
                    /*0x75ce7b4*/ void set_Name(string value);
                    /*0x75ce7bc*/ int get_Order();
                    /*0x75ce7c4*/ void set_Order(int value);
                    /*0x75ce7cc*/ bool get_IsRequired();
                    /*0x75ce7d4*/ void set_IsRequired(bool value);
                    /*0x75ce7e0*/ bool get_EmitDefaultValue();
                    /*0x75ce7e8*/ void set_EmitDefaultValue(bool value);
                    /*0x75ce7f4*/ bool get_IsNullable();
                    /*0x75ce7fc*/ void set_IsNullable(bool value);
                    /*0x75ce808*/ bool get_IsGetOnlyCollection();
                    /*0x75ce810*/ void set_IsGetOnlyCollection(bool value);
                    /*0x75ce360*/ System.Type get_MemberType();
                    /*0x75ce478*/ System.Runtime.Serialization.DataContract get_MemberTypeContract();
                    /*0x75ce81c*/ bool get_HasConflictingNameAndType();
                    /*0x75ce824*/ void set_HasConflictingNameAndType(bool value);
                    /*0x75ce830*/ System.Runtime.Serialization.DataMember get_ConflictingMember();
                    /*0x75ce838*/ void set_ConflictingMember(System.Runtime.Serialization.DataMember value);
                }
            }

            class DataMemberAttribute : System.Attribute
            {
                /*0x10*/ string name;
                /*0x18*/ bool isNameSetExplicitly;
                /*0x1c*/ int order;
                /*0x20*/ bool isRequired;
                /*0x21*/ bool emitDefaultValue;

                /*0x75ce840*/ DataMemberAttribute();
                /*0x75ce858*/ string get_Name();
                /*0x75ce860*/ void set_Name(string value);
                /*0x75ce884*/ bool get_IsNameSetExplicitly();
                /*0x75ce88c*/ int get_Order();
                /*0x75ce894*/ bool get_IsRequired();
                /*0x75ce89c*/ void set_IsRequired(bool value);
                /*0x75ce8a8*/ bool get_EmitDefaultValue();
            }

            class DateTimeFormat
            {
                /*0x10*/ string formatString;
                /*0x18*/ System.IFormatProvider formatProvider;
                /*0x20*/ System.Globalization.DateTimeStyles dateTimeStyles;

                /*0x75ce8b0*/ string get_FormatString();
                /*0x75ce8b8*/ System.IFormatProvider get_FormatProvider();
                /*0x75ce8c0*/ System.Globalization.DateTimeStyles get_DateTimeStyles();
            }

            struct DateTimeOffsetAdapter
            {
                /*0x10*/ System.DateTime utcDateTime;
                /*0x18*/ short offsetMinutes;

                static /*0x75ce8e4*/ System.DateTimeOffset GetDateTimeOffset(System.Runtime.Serialization.DateTimeOffsetAdapter value);
                static /*0x75cebc8*/ System.Runtime.Serialization.DateTimeOffsetAdapter GetDateTimeOffsetAdapter(System.DateTimeOffset value);
                /*0x75ce8c8*/ DateTimeOffsetAdapter(System.DateTime dateTime, short offsetMinutes);
                /*0x75ce8d4*/ System.DateTime get_UtcDateTime();
                /*0x75ce8dc*/ short get_OffsetMinutes();
                /*0x75ceaf0*/ string ToString(System.IFormatProvider provider);
            }

            class DictionaryGlobals
            {
                static /*0x0*/ System.Xml.XmlDictionaryString EmptyString;
                static /*0x8*/ System.Xml.XmlDictionaryString SchemaInstanceNamespace;
                static /*0x10*/ System.Xml.XmlDictionaryString SchemaNamespace;
                static /*0x18*/ System.Xml.XmlDictionaryString SerializationNamespace;
                static /*0x20*/ System.Xml.XmlDictionaryString XmlnsNamespace;
                static /*0x28*/ System.Xml.XmlDictionaryString XsiTypeLocalName;
                static /*0x30*/ System.Xml.XmlDictionaryString XsiNilLocalName;
                static /*0x38*/ System.Xml.XmlDictionaryString ClrTypeLocalName;
                static /*0x40*/ System.Xml.XmlDictionaryString ClrAssemblyLocalName;
                static /*0x48*/ System.Xml.XmlDictionaryString ArraySizeLocalName;
                static /*0x50*/ System.Xml.XmlDictionaryString IdLocalName;
                static /*0x58*/ System.Xml.XmlDictionaryString RefLocalName;
                static /*0x60*/ System.Xml.XmlDictionaryString ISerializableFactoryTypeLocalName;
                static /*0x68*/ System.Xml.XmlDictionaryString CharLocalName;
                static /*0x70*/ System.Xml.XmlDictionaryString BooleanLocalName;
                static /*0x78*/ System.Xml.XmlDictionaryString SignedByteLocalName;
                static /*0x80*/ System.Xml.XmlDictionaryString UnsignedByteLocalName;
                static /*0x88*/ System.Xml.XmlDictionaryString ShortLocalName;
                static /*0x90*/ System.Xml.XmlDictionaryString UnsignedShortLocalName;
                static /*0x98*/ System.Xml.XmlDictionaryString IntLocalName;
                static /*0xa0*/ System.Xml.XmlDictionaryString UnsignedIntLocalName;
                static /*0xa8*/ System.Xml.XmlDictionaryString LongLocalName;
                static /*0xb0*/ System.Xml.XmlDictionaryString UnsignedLongLocalName;
                static /*0xb8*/ System.Xml.XmlDictionaryString FloatLocalName;
                static /*0xc0*/ System.Xml.XmlDictionaryString DoubleLocalName;
                static /*0xc8*/ System.Xml.XmlDictionaryString DecimalLocalName;
                static /*0xd0*/ System.Xml.XmlDictionaryString DateTimeLocalName;
                static /*0xd8*/ System.Xml.XmlDictionaryString StringLocalName;
                static /*0xe0*/ System.Xml.XmlDictionaryString ByteArrayLocalName;
                static /*0xe8*/ System.Xml.XmlDictionaryString ObjectLocalName;
                static /*0xf0*/ System.Xml.XmlDictionaryString TimeSpanLocalName;
                static /*0xf8*/ System.Xml.XmlDictionaryString GuidLocalName;
                static /*0x100*/ System.Xml.XmlDictionaryString UriLocalName;
                static /*0x108*/ System.Xml.XmlDictionaryString QNameLocalName;
                static /*0x110*/ System.Xml.XmlDictionaryString Space;
                static /*0x118*/ System.Xml.XmlDictionaryString timeLocalName;
                static /*0x120*/ System.Xml.XmlDictionaryString dateLocalName;
                static /*0x128*/ System.Xml.XmlDictionaryString hexBinaryLocalName;
                static /*0x130*/ System.Xml.XmlDictionaryString gYearMonthLocalName;
                static /*0x138*/ System.Xml.XmlDictionaryString gYearLocalName;
                static /*0x140*/ System.Xml.XmlDictionaryString gMonthDayLocalName;
                static /*0x148*/ System.Xml.XmlDictionaryString gDayLocalName;
                static /*0x150*/ System.Xml.XmlDictionaryString gMonthLocalName;
                static /*0x158*/ System.Xml.XmlDictionaryString integerLocalName;
                static /*0x160*/ System.Xml.XmlDictionaryString positiveIntegerLocalName;
                static /*0x168*/ System.Xml.XmlDictionaryString negativeIntegerLocalName;
                static /*0x170*/ System.Xml.XmlDictionaryString nonPositiveIntegerLocalName;
                static /*0x178*/ System.Xml.XmlDictionaryString nonNegativeIntegerLocalName;
                static /*0x180*/ System.Xml.XmlDictionaryString normalizedStringLocalName;
                static /*0x188*/ System.Xml.XmlDictionaryString tokenLocalName;
                static /*0x190*/ System.Xml.XmlDictionaryString languageLocalName;
                static /*0x198*/ System.Xml.XmlDictionaryString NameLocalName;
                static /*0x1a0*/ System.Xml.XmlDictionaryString NCNameLocalName;
                static /*0x1a8*/ System.Xml.XmlDictionaryString XSDIDLocalName;
                static /*0x1b0*/ System.Xml.XmlDictionaryString IDREFLocalName;
                static /*0x1b8*/ System.Xml.XmlDictionaryString IDREFSLocalName;
                static /*0x1c0*/ System.Xml.XmlDictionaryString ENTITYLocalName;
                static /*0x1c8*/ System.Xml.XmlDictionaryString ENTITIESLocalName;
                static /*0x1d0*/ System.Xml.XmlDictionaryString NMTOKENLocalName;
                static /*0x1d8*/ System.Xml.XmlDictionaryString NMTOKENSLocalName;
                static /*0x1e0*/ System.Xml.XmlDictionaryString AsmxTypesNamespace;

                static /*0x75cec94*/ DictionaryGlobals();
            }

            enum EmitTypeInformation
            {
                AsNeeded = 0,
                Always = 1,
                Never = 2,
            }

            class EnumDataContract : System.Runtime.Serialization.DataContract
            {
                /*0x28*/ System.Runtime.Serialization.EnumDataContract.EnumDataContractCriticalHelper helper;

                /*0x75c9dd0*/ EnumDataContract(System.Type type);
                /*0x75d01bc*/ System.Collections.Generic.List<System.Runtime.Serialization.DataMember> get_Members();
                /*0x75d01d8*/ System.Collections.Generic.List<long> get_Values();
                /*0x75d01f4*/ bool get_IsFlags();
                /*0x75d0210*/ bool get_IsULong();
                /*0x75d022c*/ System.Xml.XmlDictionaryString[] get_ChildElementNames();
                /*0x75d0248*/ bool get_CanContainReferences();
                /*0x75d0250*/ void WriteEnumValue(System.Runtime.Serialization.XmlWriterDelegator writer, object value);
                /*0x75d0640*/ object ReadEnumValue(System.Runtime.Serialization.XmlReaderDelegator reader);
                /*0x75d08cc*/ long ReadEnumValue(string value, int index, int count);
                /*0x75d0aac*/ bool Equals(object other, System.Collections.Generic.Dictionary<System.Runtime.Serialization.DataContractPairKey, object> checkedContracts);
                /*0x75d0da8*/ int GetHashCode();
                /*0x75d0db0*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75d0db4*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);

                class EnumDataContractCriticalHelper : System.Runtime.Serialization.DataContract.DataContractCriticalHelper
                {
                    static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, System.Xml.XmlQualifiedName> typeToName;
                    static /*0x8*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Type> nameToType;
                    /*0x58*/ System.Xml.XmlQualifiedName baseContractName;
                    /*0x60*/ System.Collections.Generic.List<System.Runtime.Serialization.DataMember> members;
                    /*0x68*/ System.Collections.Generic.List<long> values;
                    /*0x70*/ bool isULong;
                    /*0x71*/ bool isFlags;
                    /*0x72*/ bool hasDataContract;
                    /*0x78*/ System.Xml.XmlDictionaryString[] childElementNames;

                    static /*0x75d0dec*/ EnumDataContractCriticalHelper();
                    static /*0x75d1064*/ void Add(System.Type type, string localName);
                    static /*0x75d1150*/ System.Xml.XmlQualifiedName GetBaseContractName(System.Type type);
                    /*0x75cfd84*/ EnumDataContractCriticalHelper(System.Type type);
                    /*0x75d1ab4*/ System.Collections.Generic.List<System.Runtime.Serialization.DataMember> get_Members();
                    /*0x75d1abc*/ System.Collections.Generic.List<long> get_Values();
                    /*0x75d1ac4*/ bool get_IsFlags();
                    /*0x75d1acc*/ void set_IsFlags(bool value);
                    /*0x75d1ad8*/ bool get_IsULong();
                    /*0x75d1ae0*/ System.Xml.XmlDictionaryString[] get_ChildElementNames();
                    /*0x75d11e8*/ void ImportBaseType(System.Type baseType);
                    /*0x75d1384*/ void ImportDataMembers();
                }
            }

            class EnumMemberAttribute : System.Attribute
            {
                /*0x10*/ string value;
                /*0x18*/ bool isValueSetExplicitly;

                /*0x75d1de4*/ string get_Value();
                /*0x75d1dec*/ bool get_IsValueSetExplicitly();
            }

            class ExtensionDataObject
            {
                /*0x10*/ System.Collections.Generic.IList<System.Runtime.Serialization.ExtensionDataMember> members;

                /*0x75d1df4*/ ExtensionDataObject();
                /*0x75d1dfc*/ System.Collections.Generic.IList<System.Runtime.Serialization.ExtensionDataMember> get_Members();
                /*0x75d1e04*/ void set_Members(System.Collections.Generic.IList<System.Runtime.Serialization.ExtensionDataMember> value);
            }

            class ExtensionDataMember
            {
                /*0x10*/ string name;
                /*0x18*/ string ns;
                /*0x20*/ System.Runtime.Serialization.IDataNode value;
                /*0x28*/ int memberIndex;

                /*0x75d1e4c*/ ExtensionDataMember();
                /*0x75d1e0c*/ string get_Name();
                /*0x75d1e14*/ void set_Name(string value);
                /*0x75d1e1c*/ string get_Namespace();
                /*0x75d1e24*/ void set_Namespace(string value);
                /*0x75d1e2c*/ System.Runtime.Serialization.IDataNode get_Value();
                /*0x75d1e34*/ void set_Value(System.Runtime.Serialization.IDataNode value);
                /*0x75d1e3c*/ int get_MemberIndex();
                /*0x75d1e44*/ void set_MemberIndex(int value);
            }

            interface IDataNode
            {
                /*0x38148bc*/ System.Type get_DataType();
                /*0x38148bc*/ object get_Value();
                /*0x3816710*/ void set_Value(object value);
                /*0x38148bc*/ string get_DataContractName();
                /*0x3816710*/ void set_DataContractName(string value);
                /*0x38148bc*/ string get_DataContractNamespace();
                /*0x3816710*/ void set_DataContractNamespace(string value);
                /*0x38148bc*/ string get_ClrTypeName();
                /*0x3816710*/ void set_ClrTypeName(string value);
                /*0x38148bc*/ string get_ClrAssemblyName();
                /*0x3816710*/ void set_ClrAssemblyName(string value);
                /*0x38148bc*/ string get_Id();
                /*0x3816710*/ void set_Id(string value);
                /*0x3813ffc*/ bool get_PreservesReferences();
                /*0x3816710*/ void GetData(System.Runtime.Serialization.ElementData element);
                /*0x3813ffc*/ bool get_IsFinalValue();
                /*0x3815cc4*/ void set_IsFinalValue(bool value);
                /*0x38159dc*/ void Clear();
            }

            class DataNode<T> : System.Runtime.Serialization.IDataNode
            {
                /*0x0*/ System.Type dataType;
                /*0x0*/ T value;
                /*0x0*/ string dataContractName;
                /*0x0*/ string dataContractNamespace;
                /*0x0*/ string clrTypeName;
                /*0x0*/ string clrAssemblyName;
                /*0x0*/ string id;
                /*0x0*/ bool isFinalValue;

                /*0x38159dc*/ DataNode();
                /*0x3910ae8*/ DataNode(T value);
                /*0x38148bc*/ System.Type get_DataType();
                /*0x38148bc*/ object get_Value();
                /*0x3816710*/ void set_Value(object value);
                /*0x3813ffc*/ bool System.Runtime.Serialization.IDataNode.get_IsFinalValue();
                /*0x3815cc4*/ void System.Runtime.Serialization.IDataNode.set_IsFinalValue(bool value);
                /*0x3910ae8*/ T GetValue();
                /*0x38148bc*/ string get_DataContractName();
                /*0x3816710*/ void set_DataContractName(string value);
                /*0x38148bc*/ string get_DataContractNamespace();
                /*0x3816710*/ void set_DataContractNamespace(string value);
                /*0x38148bc*/ string get_ClrTypeName();
                /*0x3816710*/ void set_ClrTypeName(string value);
                /*0x38148bc*/ string get_ClrAssemblyName();
                /*0x3816710*/ void set_ClrAssemblyName(string value);
                /*0x3813ffc*/ bool get_PreservesReferences();
                /*0x38148bc*/ string get_Id();
                /*0x3816710*/ void set_Id(string value);
                /*0x3816710*/ void GetData(System.Runtime.Serialization.ElementData element);
                /*0x38159dc*/ void Clear();
                /*0x3816a14*/ void AddQualifiedNameAttribute(System.Runtime.Serialization.ElementData element, string elementPrefix, string elementName, string elementNs, string valueName, string valueNs);
            }

            class ClassDataNode : System.Runtime.Serialization.DataNode<object>
            {
                /*0x50*/ System.Collections.Generic.IList<System.Runtime.Serialization.ExtensionDataMember> members;

                /*0x75d1e54*/ ClassDataNode();
                /*0x75d1fe4*/ System.Collections.Generic.IList<System.Runtime.Serialization.ExtensionDataMember> get_Members();
                /*0x75d1fec*/ void set_Members(System.Collections.Generic.IList<System.Runtime.Serialization.ExtensionDataMember> value);
                /*0x75d1ff4*/ void Clear();
            }

            class CollectionDataNode : System.Runtime.Serialization.DataNode<System.Array>
            {
                /*0x50*/ System.Collections.Generic.IList<System.Runtime.Serialization.IDataNode> items;
                /*0x58*/ string itemName;
                /*0x60*/ string itemNamespace;
                /*0x68*/ int size;

                /*0x75d204c*/ CollectionDataNode();
                /*0x75d21e4*/ System.Collections.Generic.IList<System.Runtime.Serialization.IDataNode> get_Items();
                /*0x75d21ec*/ void set_Items(System.Collections.Generic.IList<System.Runtime.Serialization.IDataNode> value);
                /*0x75d21f4*/ string get_ItemName();
                /*0x75d21fc*/ void set_ItemName(string value);
                /*0x75d2204*/ string get_ItemNamespace();
                /*0x75d220c*/ void set_ItemNamespace(string value);
                /*0x75d2214*/ int get_Size();
                /*0x75d221c*/ void set_Size(int value);
                /*0x75d2224*/ void GetData(System.Runtime.Serialization.ElementData element);
                /*0x75d2440*/ void Clear();
            }

            class XmlDataNode : System.Runtime.Serialization.DataNode<object>
            {
                /*0x50*/ System.Collections.Generic.IList<System.Xml.XmlAttribute> xmlAttributes;
                /*0x58*/ System.Collections.Generic.IList<System.Xml.XmlNode> xmlChildNodes;
                /*0x60*/ System.Xml.XmlDocument ownerDocument;

                /*0x75d24a4*/ XmlDataNode();
                /*0x75d2634*/ System.Collections.Generic.IList<System.Xml.XmlAttribute> get_XmlAttributes();
                /*0x75d263c*/ void set_XmlAttributes(System.Collections.Generic.IList<System.Xml.XmlAttribute> value);
                /*0x75d2644*/ System.Collections.Generic.IList<System.Xml.XmlNode> get_XmlChildNodes();
                /*0x75d264c*/ void set_XmlChildNodes(System.Collections.Generic.IList<System.Xml.XmlNode> value);
                /*0x75d2654*/ System.Xml.XmlDocument get_OwnerDocument();
                /*0x75d265c*/ void set_OwnerDocument(System.Xml.XmlDocument value);
                /*0x75d2664*/ void Clear();
            }

            class ISerializableDataNode : System.Runtime.Serialization.DataNode<object>
            {
                /*0x50*/ string factoryTypeName;
                /*0x58*/ string factoryTypeNamespace;
                /*0x60*/ System.Collections.Generic.IList<System.Runtime.Serialization.ISerializableDataMember> members;

                /*0x75d26dc*/ ISerializableDataNode();
                /*0x75d286c*/ string get_FactoryTypeName();
                /*0x75d2874*/ void set_FactoryTypeName(string value);
                /*0x75d287c*/ string get_FactoryTypeNamespace();
                /*0x75d2884*/ void set_FactoryTypeNamespace(string value);
                /*0x75d288c*/ System.Collections.Generic.IList<System.Runtime.Serialization.ISerializableDataMember> get_Members();
                /*0x75d2894*/ void set_Members(System.Collections.Generic.IList<System.Runtime.Serialization.ISerializableDataMember> value);
                /*0x75d289c*/ void GetData(System.Runtime.Serialization.ElementData element);
                /*0x75d297c*/ void Clear();
            }

            class ISerializableDataMember
            {
                /*0x10*/ string name;
                /*0x18*/ System.Runtime.Serialization.IDataNode value;

                /*0x75d2a14*/ ISerializableDataMember();
                /*0x75d29f4*/ string get_Name();
                /*0x75d29fc*/ void set_Name(string value);
                /*0x75d2a04*/ System.Runtime.Serialization.IDataNode get_Value();
                /*0x75d2a0c*/ void set_Value(System.Runtime.Serialization.IDataNode value);
            }

            class ExtensionDataReader : System.Xml.XmlReader
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<string, string> nsToPrefixTable;
                static /*0x8*/ System.Collections.Generic.Dictionary<string, string> prefixToNsTable;
                /*0x10*/ System.Collections.Hashtable cache;
                /*0x18*/ System.Runtime.Serialization.ElementData[] elements;
                /*0x20*/ System.Runtime.Serialization.ElementData element;
                /*0x28*/ System.Runtime.Serialization.ElementData nextElement;
                /*0x30*/ System.Xml.ReadState readState;
                /*0x34*/ System.Runtime.Serialization.ExtensionDataReader.ExtensionDataNodeType internalNodeType;
                /*0x38*/ System.Xml.XmlNodeType nodeType;
                /*0x3c*/ int depth;
                /*0x40*/ string localName;
                /*0x48*/ string ns;
                /*0x50*/ string prefix;
                /*0x58*/ string value;
                /*0x60*/ int attributeCount;
                /*0x64*/ int attributeIndex;
                /*0x68*/ System.Xml.XmlNodeReader xmlNodeReader;
                /*0x70*/ System.Collections.Generic.Queue<System.Runtime.Serialization.IDataNode> deserializedDataNodes;
                /*0x78*/ System.Runtime.Serialization.XmlObjectSerializerReadContext context;

                static /*0x75d2a1c*/ ExtensionDataReader();
                static /*0x75d5808*/ string GetPrefix(string ns);
                static /*0x75d2b70*/ void AddPrefix(string prefix, string ns);
                /*0x75d2c20*/ ExtensionDataReader(System.Runtime.Serialization.XmlObjectSerializerReadContext context);
                /*0x75d2cd4*/ void SetDeserializedValue(object obj);
                /*0x75d2e30*/ System.Runtime.Serialization.IDataNode GetCurrentNode();
                /*0x75d2e60*/ void SetDataNode(System.Runtime.Serialization.IDataNode dataNode, string name, string ns);
                /*0x75d3174*/ void Reset();
                /*0x75d3208*/ bool get_IsXmlDataNode();
                /*0x75d3218*/ System.Xml.XmlNodeType get_NodeType();
                /*0x75d3250*/ string get_LocalName();
                /*0x75d3288*/ string get_NamespaceURI();
                /*0x75d32c0*/ string get_Prefix();
                /*0x75d32f8*/ string get_Value();
                /*0x75d3330*/ int get_Depth();
                /*0x75d3368*/ int get_AttributeCount();
                /*0x75d33a4*/ bool get_EOF();
                /*0x75d33e8*/ System.Xml.ReadState get_ReadState();
                /*0x75d3424*/ bool get_IsEmptyElement();
                /*0x75d3460*/ bool get_IsDefault();
                /*0x75d349c*/ char get_QuoteChar();
                /*0x75d34d8*/ System.Xml.XmlSpace get_XmlSpace();
                /*0x75d3514*/ string get_XmlLang();
                /*0x75d3560*/ bool MoveToFirstAttribute();
                /*0x75d35c0*/ bool MoveToNextAttribute();
                /*0x75d3624*/ void MoveToAttribute(int index);
                /*0x75d375c*/ string GetAttribute(string name, string namespaceURI);
                /*0x75d383c*/ bool MoveToAttribute(string name, string namespaceURI);
                /*0x75d3934*/ bool MoveToElement();
                /*0x75d30c8*/ void SetElement();
                /*0x75d3988*/ string LookupNamespace(string prefix);
                /*0x75d3a58*/ void Skip();
                /*0x75d3bc8*/ bool IsElementNode(System.Runtime.Serialization.ExtensionDataReader.ExtensionDataNodeType nodeType);
                /*0x75d3bec*/ void Close();
                /*0x75d3c38*/ bool Read();
                /*0x75d44c0*/ string get_Name();
                /*0x75d4508*/ string get_BaseURI();
                /*0x75d4554*/ System.Xml.XmlNameTable get_NameTable();
                /*0x75d4590*/ string GetAttribute(string name);
                /*0x75d45cc*/ string GetAttribute(int i);
                /*0x75d4608*/ bool MoveToAttribute(string name);
                /*0x75d4644*/ void ResolveEntity();
                /*0x75d467c*/ bool ReadAttributeValue();
                /*0x75d3ef0*/ void MoveNext(System.Runtime.Serialization.IDataNode dataNode);
                /*0x75d2ea8*/ void SetNextElement(System.Runtime.Serialization.IDataNode node, string name, string ns, string prefix);
                /*0x75d55c8*/ void AddDeserializedDataNode(System.Runtime.Serialization.IDataNode node);
                /*0x75d5310*/ bool CheckIfNodeHandled(System.Runtime.Serialization.IDataNode node);
                /*0x75d46b8*/ void MoveNextInClass(System.Runtime.Serialization.ClassDataNode dataNode);
                /*0x75d4908*/ void MoveNextInCollection(System.Runtime.Serialization.CollectionDataNode dataNode);
                /*0x75d4b54*/ void MoveNextInISerializable(System.Runtime.Serialization.ISerializableDataNode dataNode);
                /*0x75d4d78*/ void MoveNextInXml(System.Runtime.Serialization.XmlDataNode dataNode);
                /*0x75d4f8c*/ void MoveToDeserializedObject(System.Runtime.Serialization.IDataNode dataNode);
                /*0x75d5aa4*/ bool MoveToText(System.Type type, System.Runtime.Serialization.IDataNode dataNode, bool isTypedNode);
                /*0x75d4344*/ void PushElement();
                /*0x75d4408*/ void PopElement();
                /*0x75d76d4*/ void GrowElementsIfNeeded();
                /*0x75d5288*/ System.Runtime.Serialization.ElementData GetNextElement();

                enum ExtensionDataNodeType
                {
                    None = 0,
                    Element = 1,
                    EndElement = 2,
                    Text = 3,
                    Xml = 4,
                    ReferencedElement = 5,
                    NullElement = 6,
                }
            }

            class AttributeData
            {
                /*0x10*/ string prefix;
                /*0x18*/ string ns;
                /*0x20*/ string localName;
                /*0x28*/ string value;

                /*0x75d77a4*/ AttributeData();
            }

            class ElementData
            {
                /*0x10*/ string localName;
                /*0x18*/ string ns;
                /*0x20*/ string prefix;
                /*0x28*/ int attributeCount;
                /*0x30*/ System.Runtime.Serialization.AttributeData[] attributes;
                /*0x38*/ System.Runtime.Serialization.IDataNode dataNode;
                /*0x40*/ int childElementIndex;

                /*0x75d779c*/ ElementData();
                /*0x75d2300*/ void AddAttribute(string prefix, string ns, string name, string value);
                /*0x75d77ac*/ void GrowAttributesIfNeeded();
            }

            class GenericParameterDataContract : System.Runtime.Serialization.DataContract
            {
                /*0x28*/ System.Runtime.Serialization.GenericParameterDataContract.GenericParameterDataContractCriticalHelper helper;

                /*0x75c9eb8*/ GenericParameterDataContract(System.Type type);
                /*0x75d7918*/ bool get_IsBuiltInDataContract();

                class GenericParameterDataContractCriticalHelper : System.Runtime.Serialization.DataContract.DataContractCriticalHelper
                {
                    /*0x54*/ int parameterPosition;

                    /*0x75d7874*/ GenericParameterDataContractCriticalHelper(System.Type type);
                }
            }

            class Globals
            {
                static /*0x0*/ System.Type typeOfObject;
                static /*0x8*/ System.Type typeOfValueType;
                static /*0x10*/ System.Type typeOfArray;
                static /*0x18*/ System.Type typeOfString;
                static /*0x20*/ System.Type typeOfInt;
                static /*0x28*/ System.Type typeOfULong;
                static /*0x30*/ System.Type typeOfVoid;
                static /*0x38*/ System.Type typeOfByteArray;
                static /*0x40*/ System.Type typeOfTimeSpan;
                static /*0x48*/ System.Type typeOfGuid;
                static /*0x50*/ System.Type typeOfDateTimeOffset;
                static /*0x58*/ System.Type typeOfDateTimeOffsetAdapter;
                static /*0x60*/ System.Type typeOfUri;
                static /*0x68*/ System.Type typeOfTypeEnumerable;
                static /*0x70*/ System.Type typeOfStreamingContext;
                static /*0x78*/ System.Type typeOfISerializable;
                static /*0x80*/ System.Type typeOfIDeserializationCallback;
                static /*0x88*/ System.Type typeOfIObjectReference;
                static /*0x90*/ System.Type typeOfKnownTypeAttribute;
                static /*0x98*/ System.Type typeOfDataContractAttribute;
                static /*0xa0*/ System.Type typeOfDataMemberAttribute;
                static /*0xa8*/ System.Type typeOfEnumMemberAttribute;
                static /*0xb0*/ System.Type typeOfCollectionDataContractAttribute;
                static /*0xb8*/ System.Type typeOfOptionalFieldAttribute;
                static /*0xc0*/ System.Type typeOfObjectArray;
                static /*0xc8*/ System.Type typeOfOnSerializingAttribute;
                static /*0xd0*/ System.Type typeOfOnSerializedAttribute;
                static /*0xd8*/ System.Type typeOfOnDeserializingAttribute;
                static /*0xe0*/ System.Type typeOfOnDeserializedAttribute;
                static /*0xe8*/ System.Type typeOfFlagsAttribute;
                static /*0xf0*/ System.Type typeOfIXmlSerializable;
                static /*0xf8*/ System.Type typeOfXmlSchemaProviderAttribute;
                static /*0x100*/ System.Type typeOfXmlRootAttribute;
                static /*0x108*/ System.Type typeOfXmlQualifiedName;
                static /*0x110*/ System.Type typeOfXmlSchemaType;
                static /*0x118*/ System.Type typeOfXmlNodeArray;
                static /*0x120*/ object[] emptyObjectArray;
                static /*0x128*/ System.Type[] emptyTypeArray;
                static /*0x130*/ System.Type typeOfIExtensibleDataObject;
                static /*0x138*/ System.Type typeOfExtensionDataObject;
                static /*0x140*/ System.Type typeOfISerializableDataNode;
                static /*0x148*/ System.Type typeOfClassDataNode;
                static /*0x150*/ System.Type typeOfCollectionDataNode;
                static /*0x158*/ System.Type typeOfXmlDataNode;
                static /*0x160*/ System.Type typeOfNullable;
                static /*0x168*/ System.Type typeOfReflectionPointer;
                static /*0x170*/ System.Type typeOfIDictionaryGeneric;
                static /*0x178*/ System.Type typeOfIDictionary;
                static /*0x180*/ System.Type typeOfIListGeneric;
                static /*0x188*/ System.Type typeOfIList;
                static /*0x190*/ System.Type typeOfICollectionGeneric;
                static /*0x198*/ System.Type typeOfICollection;
                static /*0x1a0*/ System.Type typeOfIEnumerableGeneric;
                static /*0x1a8*/ System.Type typeOfIEnumerable;
                static /*0x1b0*/ System.Type typeOfIEnumeratorGeneric;
                static /*0x1b8*/ System.Type typeOfIEnumerator;
                static /*0x1c0*/ System.Type typeOfKeyValuePair;
                static /*0x1c8*/ System.Type typeOfKeyValue;
                static /*0x1d0*/ System.Type typeOfIDictionaryEnumerator;
                static /*0x1d8*/ System.Type typeOfDictionaryEnumerator;
                static /*0x1e0*/ System.Type typeOfGenericDictionaryEnumerator;
                static /*0x1e8*/ System.Type typeOfDictionaryGeneric;
                static /*0x1f0*/ System.Type typeOfHashtable;
                static /*0x1f8*/ System.Type typeOfXmlElement;
                static /*0x200*/ System.Type typeOfDBNull;
                static /*0x208*/ System.Uri dataContractXsdBaseNamespaceUri;
                static /*0x210*/ string NewObjectId;

                static /*0x75d96b8*/ Globals();
                static /*0x75ca358*/ System.Type get_TypeOfObject();
                static /*0x75d7920*/ System.Type get_TypeOfValueType();
                static /*0x75bf214*/ System.Type get_TypeOfArray();
                static /*0x75cc378*/ System.Type get_TypeOfString();
                static /*0x75cc13c*/ System.Type get_TypeOfInt();
                static /*0x75d1ae8*/ System.Type get_TypeOfULong();
                static /*0x75d7a14*/ System.Type get_TypeOfVoid();
                static /*0x75d72c4*/ System.Type get_TypeOfByteArray();
                static /*0x75d73c8*/ System.Type get_TypeOfTimeSpan();
                static /*0x75d74cc*/ System.Type get_TypeOfGuid();
                static /*0x75ca0a8*/ System.Type get_TypeOfDateTimeOffset();
                static /*0x75ca1ac*/ System.Type get_TypeOfDateTimeOffsetAdapter();
                static /*0x75d75d0*/ System.Type get_TypeOfUri();
                static /*0x75c89a4*/ System.Type get_TypeOfTypeEnumerable();
                static /*0x75d7b08*/ System.Type get_TypeOfStreamingContext();
                static /*0x75d7c0c*/ System.Type get_TypeOfISerializable();
                static /*0x75d7d10*/ System.Type get_TypeOfIDeserializationCallback();
                static /*0x75d7e14*/ System.Type get_TypeOfIObjectReference();
                static /*0x75c84d8*/ System.Type get_TypeOfKnownTypeAttribute();
                static /*0x75c373c*/ System.Type get_TypeOfDataContractAttribute();
                static /*0x75d1ce0*/ System.Type get_TypeOfDataMemberAttribute();
                static /*0x75d1bdc*/ System.Type get_TypeOfEnumMemberAttribute();
                static /*0x75c5604*/ System.Type get_TypeOfCollectionDataContractAttribute();
                static /*0x75d7f18*/ System.Type get_TypeOfOptionalFieldAttribute();
                static /*0x75bf308*/ System.Type get_TypeOfObjectArray();
                static /*0x75d801c*/ System.Type get_TypeOfOnSerializingAttribute();
                static /*0x75d8120*/ System.Type get_TypeOfOnSerializedAttribute();
                static /*0x75d8224*/ System.Type get_TypeOfOnDeserializingAttribute();
                static /*0x75d8328*/ System.Type get_TypeOfOnDeserializedAttribute();
                static /*0x75d1280*/ System.Type get_TypeOfFlagsAttribute();
                static /*0x75c3840*/ System.Type get_TypeOfIXmlSerializable();
                static /*0x75d842c*/ System.Type get_TypeOfXmlSchemaProviderAttribute();
                static /*0x75d8530*/ System.Type get_TypeOfXmlRootAttribute();
                static /*0x75d8638*/ System.Type get_TypeOfXmlQualifiedName();
                static /*0x75d8740*/ System.Type get_TypeOfXmlSchemaType();
                static /*0x75d8848*/ System.Type get_TypeOfXmlNodeArray();
                static /*0x75c8aa8*/ object[] get_EmptyObjectArray();
                static /*0x75c88dc*/ System.Type[] get_EmptyTypeArray();
                static /*0x75d8950*/ System.Type get_TypeOfIExtensibleDataObject();
                static /*0x75d8a58*/ System.Type get_TypeOfExtensionDataObject();
                static /*0x75d2764*/ System.Type get_TypeOfISerializableDataNode();
                static /*0x75d1edc*/ System.Type get_TypeOfClassDataNode();
                static /*0x75d20dc*/ System.Type get_TypeOfCollectionDataNode();
                static /*0x75d252c*/ System.Type get_TypeOfXmlDataNode();
                static /*0x75c3e54*/ System.Type get_TypeOfNullable();
                static /*0x75c9fa0*/ System.Type get_TypeOfReflectionPointer();
                static /*0x75bded4*/ System.Type get_TypeOfIDictionaryGeneric();
                static /*0x75bdfdc*/ System.Type get_TypeOfIDictionary();
                static /*0x75be0e4*/ System.Type get_TypeOfIListGeneric();
                static /*0x75be2f4*/ System.Type get_TypeOfIList();
                static /*0x75be1ec*/ System.Type get_TypeOfICollectionGeneric();
                static /*0x75be504*/ System.Type get_TypeOfICollection();
                static /*0x75be3fc*/ System.Type get_TypeOfIEnumerableGeneric();
                static /*0x75be60c*/ System.Type get_TypeOfIEnumerable();
                static /*0x75d8b60*/ System.Type get_TypeOfIEnumeratorGeneric();
                static /*0x75d8c68*/ System.Type get_TypeOfIEnumerator();
                static /*0x75d8d70*/ System.Type get_TypeOfKeyValuePair();
                static /*0x75d8e78*/ System.Type get_TypeOfKeyValue();
                static /*0x75d8f80*/ System.Type get_TypeOfIDictionaryEnumerator();
                static /*0x75d9088*/ System.Type get_TypeOfDictionaryEnumerator();
                static /*0x75d9190*/ System.Type get_TypeOfGenericDictionaryEnumerator();
                static /*0x75d9298*/ System.Type get_TypeOfDictionaryGeneric();
                static /*0x75d93a0*/ System.Type get_TypeOfHashtable();
                static /*0x75d94a8*/ System.Type get_TypeOfXmlElement();
                static /*0x75d95b0*/ System.Type get_TypeOfDBNull();
                static /*0x75c61e8*/ System.Uri get_DataContractXsdBaseNamespaceUri();
            }

            class HybridObjectCache
            {
                /*0x10*/ System.Collections.Generic.Dictionary<string, object> objectDictionary;
                /*0x18*/ System.Collections.Generic.Dictionary<string, object> referencedObjectDictionary;

                /*0x75d9718*/ HybridObjectCache();
                /*0x75d9720*/ void Add(string id, object obj);
                /*0x75d9894*/ void Remove(string id);
                /*0x75d98f4*/ object GetObject(string id);
                /*0x75d9a10*/ bool IsObjectReferenced(string id);
            }

            interface IDataContractSurrogate
            {
                /*0x3814a3c*/ System.Type GetDataContractType(System.Type type);
                /*0x3814b90*/ object GetObjectToSerialize(object obj, System.Type targetType);
                /*0x3814b90*/ object GetDeserializedObject(object obj, System.Type targetType);
            }

            class DataContractSurrogateCaller
            {
                static /*0x75d9a70*/ System.Type GetDataContractType(System.Runtime.Serialization.IDataContractSurrogate surrogate, System.Type type);
                static /*0x75d9b68*/ object GetObjectToSerialize(System.Runtime.Serialization.IDataContractSurrogate surrogate, object obj, System.Type objType, System.Type membertype);
                static /*0x75d9c4c*/ object GetDeserializedObject(System.Runtime.Serialization.IDataContractSurrogate surrogate, object obj, System.Type objType, System.Type memberType);
            }

            interface IExtensibleDataObject
            {
                /*0x38148bc*/ System.Runtime.Serialization.ExtensionDataObject get_ExtensionData();
                /*0x3816710*/ void set_ExtensionData(System.Runtime.Serialization.ExtensionDataObject value);
            }

            class IgnoreDataMemberAttribute : System.Attribute
            {
                /*0x75d9d30*/ IgnoreDataMemberAttribute();
            }

            class InvalidDataContractException : System.Exception
            {
                /*0x75d9d38*/ InvalidDataContractException();
                /*0x75d9d90*/ InvalidDataContractException(string message);
                /*0x75d9df8*/ InvalidDataContractException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            class JsonFormatGeneratorStatics
            {
                static /*0x0*/ System.Reflection.MethodInfo boxPointer;
                static /*0x8*/ System.Reflection.MethodInfo ienumeratorGetCurrentMethod;
                static /*0x10*/ System.Reflection.MethodInfo ienumeratorMoveNextMethod;
                static /*0x18*/ System.Type[] serInfoCtorArgs;
                static /*0x20*/ System.Reflection.MethodInfo unboxPointer;

                static /*0x75d9e78*/ System.Reflection.MethodInfo get_BoxPointer();
                static /*0x75d9f5c*/ System.Reflection.MethodInfo get_GetCurrentMethod();
                static /*0x75da048*/ System.Reflection.MethodInfo get_MoveNextMethod();
                static /*0x75da128*/ System.Type[] get_SerInfoCtorArgs();
                static /*0x75da29c*/ System.Reflection.MethodInfo get_UnboxPointer();
            }

            class KnownTypeAttribute : System.Attribute
            {
                /*0x10*/ string methodName;
                /*0x18*/ System.Type type;

                /*0x75da37c*/ string get_MethodName();
                /*0x75da384*/ System.Type get_Type();
            }

            class KnownTypeDataContractResolver : System.Runtime.Serialization.DataContractResolver
            {
                /*0x10*/ System.Runtime.Serialization.XmlObjectSerializerContext context;

                /*0x75da38c*/ KnownTypeDataContractResolver(System.Runtime.Serialization.XmlObjectSerializerContext context);
                /*0x75da3bc*/ bool TryResolveType(System.Type type, System.Type declaredType, System.Runtime.Serialization.DataContractResolver knownTypeResolver, ref System.Xml.XmlDictionaryString typeName, ref System.Xml.XmlDictionaryString typeNamespace);
                /*0x75da594*/ System.Type ResolveName(string typeName, string typeNamespace, System.Type declaredType, System.Runtime.Serialization.DataContractResolver knownTypeResolver);
            }

            class NetDataContractSerializer : System.Runtime.Serialization.XmlObjectSerializer
            {
                static /*0x0*/ System.Collections.Hashtable typeNameCache;
                static /*0x8*/ System.Nullable<bool> unsafeTypeForwardingEnabled;
                /*0x10*/ System.Runtime.Serialization.StreamingContext context;
                /*0x20*/ System.Runtime.Serialization.SerializationBinder binder;
                /*0x28*/ System.Runtime.Serialization.ISurrogateSelector surrogateSelector;
                /*0x30*/ int maxItemsInObjectGraph;
                /*0x34*/ bool ignoreExtensionDataObject;

                static /*0x75dc090*/ NetDataContractSerializer();
                static /*0x75da650*/ bool get_UnsafeTypeForwardingEnabled();
                static /*0x75daf04*/ void WriteClrTypeInfo(System.Runtime.Serialization.XmlWriterDelegator writer, System.Runtime.Serialization.DataContract dataContract, System.Runtime.Serialization.SerializationBinder binder);
                static /*0x75db6b4*/ void WriteClrTypeInfo(System.Runtime.Serialization.XmlWriterDelegator writer, System.Type dataContractType, System.Runtime.Serialization.SerializationBinder binder, string defaultClrTypeName, string defaultClrAssemblyName);
                static /*0x75db784*/ void WriteClrTypeInfo(System.Runtime.Serialization.XmlWriterDelegator writer, System.Type dataContractType, System.Runtime.Serialization.SerializationBinder binder, System.Runtime.Serialization.SerializationInfo serInfo);
                static /*0x75db594*/ void WriteClrTypeInfo(System.Runtime.Serialization.XmlWriterDelegator writer, string clrTypeName, string clrAssemblyName);
                static /*0x75dbaf8*/ System.Runtime.Serialization.ISerializationSurrogate GetSurrogate(System.Type type, System.Runtime.Serialization.ISurrogateSelector surrogateSelector, System.Runtime.Serialization.StreamingContext context);
                static /*0x75dbbc8*/ System.Runtime.Serialization.DataContract GetDataContractFromSurrogateSelector(System.Runtime.Serialization.ISurrogateSelector surrogateSelector, System.Runtime.Serialization.StreamingContext context, System.RuntimeTypeHandle typeHandle, System.Type type, ref System.Collections.Hashtable surrogateDataContracts);
                static /*0x75db220*/ System.Runtime.Serialization.TypeInformation GetTypeInformation(System.Type type);
                static /*0x75db434*/ bool IsAssemblyNameForwardingSafe(string originalAssemblyName, string newAssemblyName);
                static /*0x75dbffc*/ bool IsPublicKeyTokenForwardingSafe(byte[] sourceToken, byte[] destinationToken);
                /*0x75da738*/ System.Runtime.Serialization.StreamingContext get_Context();
                /*0x75da744*/ System.Runtime.Serialization.SerializationBinder get_Binder();
                /*0x75da74c*/ System.Runtime.Serialization.ISurrogateSelector get_SurrogateSelector();
                /*0x75da754*/ int get_MaxItemsInObjectGraph();
                /*0x75da75c*/ bool get_IgnoreExtensionDataObject();
                /*0x75da764*/ void WriteStartObject(System.Xml.XmlDictionaryWriter writer, object graph);
                /*0x75da940*/ void WriteObjectContent(System.Xml.XmlDictionaryWriter writer, object graph);
                /*0x75db8c4*/ void WriteEndObject(System.Xml.XmlDictionaryWriter writer);
                /*0x75dba74*/ object ReadObject(System.Xml.XmlDictionaryReader reader, bool verifyObjectName);
            }

            struct ObjectReferenceStack
            {
                /*0x10*/ int count;
                /*0x18*/ object[] objectArray;
                /*0x20*/ bool[] isReferenceArray;
                /*0x28*/ System.Collections.Generic.Dictionary<object, object> objectDictionary;

                /*0x75dc10c*/ void Push(object obj);
                /*0x75dc304*/ void EnsureSetAsIsReference(object obj);
                /*0x75dc43c*/ void Pop(object obj);
                /*0x75dc4b0*/ bool Contains(object obj);
                /*0x75dc58c*/ int get_Count();
            }

            class ObjectToIdCache
            {
                static /*0x0*/ int[] primes;
                /*0x10*/ int m_currentCount;
                /*0x18*/ int[] m_ids;
                /*0x20*/ object[] m_objs;
                /*0x28*/ bool[] m_isWrapped;

                static /*0x75dd0d0*/ ObjectToIdCache();
                static /*0x75dc6ac*/ int GetPrime(int min);
                static /*0x75dd018*/ bool IsPrime(int candidate);
                /*0x75dc594*/ ObjectToIdCache();
                /*0x75dc7bc*/ int GetId(object obj, ref bool newId);
                /*0x75dcc1c*/ int ReassignId(int oldObjId, object oldObj, object newObj);
                /*0x75dc904*/ int FindElement(object obj, ref bool isEmpty, ref bool isWrapped);
                /*0x75dcd8c*/ void RemoveAt(int position);
                /*0x75dcfe0*/ int ComputeStartPosition(object o);
                /*0x75dc9dc*/ void Rehash();
            }

            class PrimitiveDataContract : System.Runtime.Serialization.DataContract
            {
                /*0x28*/ System.Runtime.Serialization.PrimitiveDataContract.PrimitiveDataContractCriticalHelper helper;

                static /*0x75dd300*/ System.Runtime.Serialization.PrimitiveDataContract GetPrimitiveDataContract(System.Type type);
                static /*0x75dd384*/ System.Runtime.Serialization.PrimitiveDataContract GetPrimitiveDataContract(string name, string ns);
                /*0x75dd170*/ PrimitiveDataContract(System.Type type, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x38148bc*/ string get_WriteMethodName();
                /*0x38148bc*/ string get_ReadMethodName();
                /*0x75dd410*/ System.Xml.XmlDictionaryString get_TopLevelElementNamespace();
                /*0x75dd468*/ bool get_CanContainReferences();
                /*0x75dd470*/ bool get_IsPrimitive();
                /*0x75dd478*/ bool get_IsBuiltInDataContract();
                /*0x75dd480*/ System.Reflection.MethodInfo get_XmlFormatWriterMethod();
                /*0x75dd83c*/ System.Reflection.MethodInfo get_XmlFormatContentWriterMethod();
                /*0x75ddacc*/ System.Reflection.MethodInfo get_XmlFormatReaderMethod();
                /*0x75ddba8*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75ddbc4*/ object HandleReadValue(object obj, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
                /*0x75ddc08*/ bool TryReadNullAtTopLevel(System.Runtime.Serialization.XmlReaderDelegator reader);
                /*0x75ddd68*/ bool Equals(object other, System.Collections.Generic.Dictionary<System.Runtime.Serialization.DataContractPairKey, object> checkedContracts);

                class PrimitiveDataContractCriticalHelper : System.Runtime.Serialization.DataContract.DataContractCriticalHelper
                {
                    /*0x58*/ System.Reflection.MethodInfo xmlFormatWriterMethod;
                    /*0x60*/ System.Reflection.MethodInfo xmlFormatContentWriterMethod;
                    /*0x68*/ System.Reflection.MethodInfo xmlFormatReaderMethod;

                    /*0x75dd274*/ PrimitiveDataContractCriticalHelper(System.Type type, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                    /*0x75dde6c*/ System.Reflection.MethodInfo get_XmlFormatWriterMethod();
                    /*0x75dde74*/ void set_XmlFormatWriterMethod(System.Reflection.MethodInfo value);
                    /*0x75dde7c*/ System.Reflection.MethodInfo get_XmlFormatContentWriterMethod();
                    /*0x75dde84*/ void set_XmlFormatContentWriterMethod(System.Reflection.MethodInfo value);
                    /*0x75dde8c*/ System.Reflection.MethodInfo get_XmlFormatReaderMethod();
                    /*0x75dde94*/ void set_XmlFormatReaderMethod(System.Reflection.MethodInfo value);
                }
            }

            class CharDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75dde9c*/ CharDataContract();
                /*0x75ddf00*/ CharDataContract(System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75ddf64*/ string get_WriteMethodName();
                /*0x75ddfa4*/ string get_ReadMethodName();
                /*0x75ddfe4*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75de040*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class AsmxCharDataContract : System.Runtime.Serialization.CharDataContract
            {
                /*0x75de0c4*/ AsmxCharDataContract();
            }

            class BooleanDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75de128*/ BooleanDataContract();
                /*0x75de1c4*/ string get_WriteMethodName();
                /*0x75de204*/ string get_ReadMethodName();
                /*0x75de244*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75de29c*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class SignedByteDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75de314*/ SignedByteDataContract();
                /*0x75de3b0*/ string get_WriteMethodName();
                /*0x75de3f0*/ string get_ReadMethodName();
                /*0x75de430*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75de48c*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class UnsignedByteDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75de508*/ UnsignedByteDataContract();
                /*0x75de5a4*/ string get_WriteMethodName();
                /*0x75de5e4*/ string get_ReadMethodName();
                /*0x75de624*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75de680*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class ShortDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75de6fc*/ ShortDataContract();
                /*0x75de798*/ string get_WriteMethodName();
                /*0x75de7d8*/ string get_ReadMethodName();
                /*0x75de818*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75de874*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class UnsignedShortDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75de8f0*/ UnsignedShortDataContract();
                /*0x75de98c*/ string get_WriteMethodName();
                /*0x75de9cc*/ string get_ReadMethodName();
                /*0x75dea0c*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75dea68*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class IntDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75deae4*/ IntDataContract();
                /*0x75deb80*/ string get_WriteMethodName();
                /*0x75debc0*/ string get_ReadMethodName();
                /*0x75dec00*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75dec58*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class UnsignedIntDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75decd4*/ UnsignedIntDataContract();
                /*0x75ded70*/ string get_WriteMethodName();
                /*0x75dedb0*/ string get_ReadMethodName();
                /*0x75dedf0*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75dee4c*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class LongDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75deec8*/ LongDataContract();
                /*0x75def2c*/ LongDataContract(System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75def90*/ string get_WriteMethodName();
                /*0x75defd0*/ string get_ReadMethodName();
                /*0x75df010*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75df068*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class IntegerDataContract : System.Runtime.Serialization.LongDataContract
            {
                /*0x75df0e4*/ IntegerDataContract();
            }

            class PositiveIntegerDataContract : System.Runtime.Serialization.LongDataContract
            {
                /*0x75df148*/ PositiveIntegerDataContract();
            }

            class NegativeIntegerDataContract : System.Runtime.Serialization.LongDataContract
            {
                /*0x75df1ac*/ NegativeIntegerDataContract();
            }

            class NonPositiveIntegerDataContract : System.Runtime.Serialization.LongDataContract
            {
                /*0x75df210*/ NonPositiveIntegerDataContract();
            }

            class NonNegativeIntegerDataContract : System.Runtime.Serialization.LongDataContract
            {
                /*0x75df274*/ NonNegativeIntegerDataContract();
            }

            class UnsignedLongDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75df2d8*/ UnsignedLongDataContract();
                /*0x75df374*/ string get_WriteMethodName();
                /*0x75df3b4*/ string get_ReadMethodName();
                /*0x75df3f4*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75df450*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class FloatDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75df4d4*/ FloatDataContract();
                /*0x75df570*/ string get_WriteMethodName();
                /*0x75df5b0*/ string get_ReadMethodName();
                /*0x75df5f0*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75df648*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class DoubleDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75df6bc*/ DoubleDataContract();
                /*0x75df758*/ string get_WriteMethodName();
                /*0x75df798*/ string get_ReadMethodName();
                /*0x75df7d8*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75df830*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class DecimalDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75df8a4*/ DecimalDataContract();
                /*0x75df950*/ string get_WriteMethodName();
                /*0x75df990*/ string get_ReadMethodName();
                /*0x75df9d0*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75dfa54*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class DateTimeDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75dfb24*/ DateTimeDataContract();
                /*0x75dfbd0*/ string get_WriteMethodName();
                /*0x75dfc10*/ string get_ReadMethodName();
                /*0x75dfc50*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75dfcd4*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class StringDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75dfd80*/ StringDataContract();
                /*0x75dfde4*/ StringDataContract(System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75dfe48*/ string get_WriteMethodName();
                /*0x75dfe88*/ string get_ReadMethodName();
                /*0x75dfec8*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75dff10*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class TimeDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75dff84*/ TimeDataContract();
            }

            class DateDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75dffe8*/ DateDataContract();
            }

            class HexBinaryDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75e004c*/ HexBinaryDataContract();
            }

            class GYearMonthDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75e00b0*/ GYearMonthDataContract();
            }

            class GYearDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75e0114*/ GYearDataContract();
            }

            class GMonthDayDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75e0178*/ GMonthDayDataContract();
            }

            class GDayDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75e01dc*/ GDayDataContract();
            }

            class GMonthDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75e0240*/ GMonthDataContract();
            }

            class NormalizedStringDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75e02a4*/ NormalizedStringDataContract();
            }

            class TokenDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75e0308*/ TokenDataContract();
            }

            class LanguageDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75e036c*/ LanguageDataContract();
            }

            class NameDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75e03d0*/ NameDataContract();
            }

            class NCNameDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75e0434*/ NCNameDataContract();
            }

            class IDDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75e0498*/ IDDataContract();
            }

            class IDREFDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75e04fc*/ IDREFDataContract();
            }

            class IDREFSDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75e0560*/ IDREFSDataContract();
            }

            class ENTITYDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75e05c4*/ ENTITYDataContract();
            }

            class ENTITIESDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75e0628*/ ENTITIESDataContract();
            }

            class NMTOKENDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75e068c*/ NMTOKENDataContract();
            }

            class ByteArrayDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75e06f0*/ ByteArrayDataContract();
                /*0x75e079c*/ string get_WriteMethodName();
                /*0x75e07dc*/ string get_ReadMethodName();
                /*0x75e081c*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75e08a0*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class ObjectDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75e091c*/ ObjectDataContract();
                /*0x75e09b8*/ string get_WriteMethodName();
                /*0x75e09f8*/ string get_ReadMethodName();
                /*0x75e0a38*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75e0a3c*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
                /*0x75e0cac*/ bool get_CanContainReferences();
                /*0x75e0cb4*/ bool get_IsPrimitive();
            }

            class TimeSpanDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75e0cbc*/ TimeSpanDataContract();
                /*0x75e0d20*/ TimeSpanDataContract(System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75e0da8*/ string get_WriteMethodName();
                /*0x75e0de8*/ string get_ReadMethodName();
                /*0x75e0e28*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75e0ea8*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class XsDurationDataContract : System.Runtime.Serialization.TimeSpanDataContract
            {
                /*0x75e0f50*/ XsDurationDataContract();
            }

            class GuidDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75e0fb4*/ GuidDataContract();
                /*0x75e1018*/ GuidDataContract(System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75e10a0*/ string get_WriteMethodName();
                /*0x75e10e0*/ string get_ReadMethodName();
                /*0x75e1120*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75e11a0*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class AsmxGuidDataContract : System.Runtime.Serialization.GuidDataContract
            {
                /*0x75e1248*/ AsmxGuidDataContract();
            }

            class UriDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75e12ac*/ UriDataContract();
                /*0x75e1358*/ string get_WriteMethodName();
                /*0x75e1398*/ string get_ReadMethodName();
                /*0x75e13d8*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75e1468*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class QNameDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75e14dc*/ QNameDataContract();
                /*0x75e1588*/ string get_WriteMethodName();
                /*0x75e15c8*/ string get_ReadMethodName();
                /*0x75e1608*/ bool get_IsPrimitive();
                /*0x75e1610*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75e16a8*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
                /*0x75e171c*/ void WriteRootElement(System.Runtime.Serialization.XmlWriterDelegator writer, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
            }

            class SchemaExporter
            {
                static /*0x0*/ System.Xml.XmlQualifiedName actualTypeAnnotationName;

                static /*0x75e1818*/ System.Xml.XmlElement ExportActualType(System.Xml.XmlQualifiedName typeName, System.Xml.XmlDocument xmlDoc);
                static /*0x75e1a40*/ void GetXmlTypeInfo(System.Type type, ref System.Xml.XmlQualifiedName stableName, ref System.Xml.Schema.XmlSchemaType xsdType, ref bool hasRoot);
                static /*0x75e1dc4*/ bool InvokeSchemaProviderMethod(System.Type clrType, System.Xml.Schema.XmlSchemaSet schemas, ref System.Xml.XmlQualifiedName stableName, ref System.Xml.Schema.XmlSchemaType xsdType, ref bool hasRoot);
                static /*0x75e2e7c*/ System.Xml.Schema.XmlSchemaComplexType CreateAnyType();
                static /*0x75e2c10*/ System.Xml.Schema.XmlSchemaComplexType CreateAnyElementType();
                static /*0x75e1bb4*/ bool IsSpecialXmlType(System.Type type, ref System.Xml.XmlQualifiedName typeName, ref System.Xml.Schema.XmlSchemaType xsdType, ref bool hasRoot);
                static /*0x75e2d94*/ System.Xml.Schema.XmlSchemaAnnotation GetSchemaAnnotation(System.Xml.XmlNode[] nodes);
                static /*0x75e1954*/ System.Xml.XmlQualifiedName get_ActualTypeAnnotationName();
            }

            struct ScopedKnownTypes
            {
                /*0x10*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> dataContractDictionaries;
                /*0x18*/ int count;

                /*0x75e3094*/ void Push(System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> dataContractDictionary);
                /*0x75e3194*/ void Pop();
                /*0x75e31a4*/ System.Runtime.Serialization.DataContract GetDataContract(System.Xml.XmlQualifiedName qname);
            }

            enum SerializationMode
            {
                SharedContract = 0,
                SharedType = 1,
            }

            class SpecialTypeDataContract : System.Runtime.Serialization.DataContract
            {
                /*0x28*/ System.Runtime.Serialization.SpecialTypeDataContract.SpecialTypeDataContractCriticalHelper helper;

                /*0x75e324c*/ SpecialTypeDataContract(System.Type type, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75e33dc*/ bool get_IsBuiltInDataContract();

                class SpecialTypeDataContractCriticalHelper : System.Runtime.Serialization.DataContract.DataContractCriticalHelper
                {
                    /*0x75e3350*/ SpecialTypeDataContractCriticalHelper(System.Type type, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                }
            }

            class SurrogateDataContract : System.Runtime.Serialization.DataContract
            {
                /*0x28*/ System.Runtime.Serialization.SurrogateDataContract.SurrogateDataContractCriticalHelper helper;

                static /*0x75e3ac8*/ object GetRealObject(System.Runtime.Serialization.IObjectReference obj, System.Runtime.Serialization.StreamingContext context);
                /*0x75dbeb0*/ SurrogateDataContract(System.Type type, System.Runtime.Serialization.ISerializationSurrogate serializationSurrogate);
                /*0x75e34a8*/ System.Runtime.Serialization.ISerializationSurrogate get_SerializationSurrogate();
                /*0x75e34c4*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75e39e8*/ object SerializationSurrogateSetObjectData(object obj, System.Runtime.Serialization.SerializationInfo serInfo, System.Runtime.Serialization.StreamingContext context);
                /*0x75e3b7c*/ object GetUninitializedObject(System.Type objType);
                /*0x75e3640*/ void SerializationSurrogateGetObjectData(object obj, System.Runtime.Serialization.SerializationInfo serInfo, System.Runtime.Serialization.StreamingContext context);
                /*0x75e3bd4*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);

                class SurrogateDataContractCriticalHelper : System.Runtime.Serialization.DataContract.DataContractCriticalHelper
                {
                    /*0x58*/ System.Runtime.Serialization.ISerializationSurrogate serializationSurrogate;

                    /*0x75e33e4*/ SurrogateDataContractCriticalHelper(System.Type type, System.Runtime.Serialization.ISerializationSurrogate serializationSurrogate);
                    /*0x75e42b8*/ System.Runtime.Serialization.ISerializationSurrogate get_SerializationSurrogate();
                }
            }

            class TypeInformation
            {
                /*0x10*/ string fullTypeName;
                /*0x18*/ string assemblyString;
                /*0x20*/ bool hasTypeForwardedFrom;

                /*0x75dbfa4*/ TypeInformation(string fullTypeName, string assemblyString, bool hasTypeForwardedFrom);
                /*0x75e42c0*/ string get_FullTypeName();
                /*0x75e42c8*/ string get_AssemblyString();
            }

            class CreateXmlSerializableDelegate : System.MulticastDelegate
            {
                /*0x75e42d0*/ CreateXmlSerializableDelegate(object object, nint method);
                /*0x75e436c*/ System.Xml.Serialization.IXmlSerializable Invoke();
            }

            class XmlDataContract : System.Runtime.Serialization.DataContract
            {
                /*0x28*/ System.Runtime.Serialization.XmlDataContract.XmlDataContractCriticalHelper helper;

                /*0x75e4380*/ XmlDataContract(System.Type type);
                /*0x75e4a38*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> get_KnownDataContracts();
                /*0x75e4a58*/ bool get_IsAnonymous();
                /*0x75e4a8c*/ bool get_HasRoot();
                /*0x75e4aac*/ System.Xml.XmlDictionaryString get_TopLevelElementName();
                /*0x75e4acc*/ System.Xml.XmlDictionaryString get_TopLevelElementNamespace();
                /*0x75e4aec*/ System.Runtime.Serialization.CreateXmlSerializableDelegate get_CreateXmlSerializableDelegate();
                /*0x75e4c80*/ bool get_CanContainReferences();
                /*0x75e4c88*/ bool get_IsBuiltInDataContract();
                /*0x75e4d94*/ bool Equals(object other, System.Collections.Generic.Dictionary<System.Runtime.Serialization.DataContractPairKey, object> checkedContracts);
                /*0x75e4ef4*/ int GetHashCode();
                /*0x75e4efc*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75e5008*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
                /*0x75e4c08*/ System.Runtime.Serialization.CreateXmlSerializableDelegate GenerateCreateXmlSerializableDelegate();
                /*0x75e5184*/ System.Xml.Serialization.IXmlSerializable <GenerateCreateXmlSerializableDelegate>b__39_0();

                class XmlDataContractCriticalHelper : System.Runtime.Serialization.DataContract.DataContractCriticalHelper
                {
                    /*0x58*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> knownDataContracts;
                    /*0x60*/ bool isKnownTypeAttributeChecked;
                    /*0x68*/ System.Xml.XmlDictionaryString topLevelElementName;
                    /*0x70*/ System.Xml.XmlDictionaryString topLevelElementNamespace;
                    /*0x78*/ bool isTopLevelElementNullable;
                    /*0x80*/ System.Xml.Schema.XmlSchemaType xsdType;
                    /*0x88*/ bool hasRoot;
                    /*0x90*/ System.Runtime.Serialization.CreateXmlSerializableDelegate createXmlSerializable;

                    /*0x75e446c*/ XmlDataContractCriticalHelper(System.Type type);
                    /*0x75e51ec*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> get_KnownDataContracts();
                    /*0x75e531c*/ void set_XsdType(System.Xml.Schema.XmlSchemaType value);
                    /*0x75e4a7c*/ bool get_IsAnonymous();
                    /*0x75e5324*/ bool get_HasRoot();
                    /*0x75e532c*/ void set_HasRoot(bool value);
                    /*0x75e5338*/ System.Xml.XmlDictionaryString get_TopLevelElementName();
                    /*0x75e5340*/ System.Xml.XmlDictionaryString get_TopLevelElementNamespace();
                    /*0x75e5348*/ System.Runtime.Serialization.CreateXmlSerializableDelegate get_CreateXmlSerializableDelegate();
                    /*0x75e5350*/ void set_CreateXmlSerializableDelegate(System.Runtime.Serialization.CreateXmlSerializableDelegate value);
                }
            }

            class XmlFormatGeneratorStatics
            {
                static /*0x0*/ System.Reflection.MethodInfo boxPointer;
                static /*0x8*/ System.Reflection.MethodInfo ienumeratorMoveNextMethod;
                static /*0x10*/ System.Reflection.MethodInfo ienumeratorGetCurrentMethod;
                static /*0x18*/ System.Reflection.MethodInfo unboxPointer;
                static /*0x20*/ System.Reflection.ConstructorInfo hashtableCtor;
                static /*0x28*/ System.Reflection.MethodInfo incrementItemCountMethod;
                static /*0x30*/ System.Reflection.MethodInfo ensureArraySizeMethod;
                static /*0x38*/ System.Reflection.MethodInfo trimArraySizeMethod;
                static /*0x40*/ System.Reflection.MethodInfo internalSerializeReferenceMethod;
                static /*0x48*/ System.Reflection.MethodInfo internalSerializeMethod;
                static /*0x50*/ System.Reflection.MethodInfo writeNullMethod;
                static /*0x58*/ System.Reflection.MethodInfo incrementCollectionCountMethod;
                static /*0x60*/ System.Reflection.MethodInfo incrementCollectionCountGenericMethod;
                static /*0x68*/ System.Reflection.MethodInfo getDefaultValueMethod;
                static /*0x70*/ System.Reflection.MethodInfo getNullableValueMethod;
                static /*0x78*/ System.Reflection.MethodInfo getHasValueMethod;
                static /*0x80*/ System.Reflection.MethodInfo extensionDataSetExplicitMethodInfo;

                static /*0x75e5358*/ System.Reflection.MethodInfo get_BoxPointer();
                static /*0x75e543c*/ System.Reflection.MethodInfo get_MoveNextMethod();
                static /*0x75e551c*/ System.Reflection.MethodInfo get_GetCurrentMethod();
                static /*0x75e5608*/ System.Reflection.MethodInfo get_UnboxPointer();
                static /*0x75e56e8*/ System.Reflection.ConstructorInfo get_HashtableCtor();
                static /*0x75e57e8*/ System.Reflection.MethodInfo get_IncrementItemCountMethod();
                static /*0x75e58cc*/ System.Reflection.MethodInfo get_EnsureArraySizeMethod();
                static /*0x75e59b0*/ System.Reflection.MethodInfo get_TrimArraySizeMethod();
                static /*0x75e5a94*/ System.Reflection.MethodInfo get_InternalSerializeReferenceMethod();
                static /*0x75e5b78*/ System.Reflection.MethodInfo get_InternalSerializeMethod();
                static /*0x75e5c5c*/ System.Reflection.MethodInfo get_WriteNullMethod();
                static /*0x75e5e80*/ System.Reflection.MethodInfo get_IncrementCollectionCountMethod();
                static /*0x75e606c*/ System.Reflection.MethodInfo get_IncrementCollectionCountGenericMethod();
                static /*0x75e6150*/ System.Reflection.MethodInfo get_GetDefaultValueMethod();
                static /*0x75e6234*/ System.Reflection.MethodInfo get_GetNullableValueMethod();
                static /*0x75e6318*/ System.Reflection.MethodInfo get_GetHasValueMethod();
                static /*0x75e63fc*/ System.Reflection.MethodInfo get_ExtensionDataSetExplicitMethodInfo();
            }

            class XmlFormatClassReaderDelegate : System.MulticastDelegate
            {
                /*0x75e64dc*/ XmlFormatClassReaderDelegate(object object, nint method);
                /*0x75e65e8*/ object Invoke(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.XmlObjectSerializerReadContext context, System.Xml.XmlDictionaryString[] memberNames, System.Xml.XmlDictionaryString[] memberNamespaces);
            }

            class XmlFormatCollectionReaderDelegate : System.MulticastDelegate
            {
                /*0x75e65fc*/ XmlFormatCollectionReaderDelegate(object object, nint method);
                /*0x75e6708*/ object Invoke(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.XmlObjectSerializerReadContext context, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace, System.Runtime.Serialization.CollectionDataContract collectionContract);
            }

            class XmlFormatGetOnlyCollectionReaderDelegate : System.MulticastDelegate
            {
                /*0x75e671c*/ XmlFormatGetOnlyCollectionReaderDelegate(object object, nint method);
                /*0x75e6828*/ void Invoke(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.XmlObjectSerializerReadContext context, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace, System.Runtime.Serialization.CollectionDataContract collectionContract);
            }

            class XmlFormatReaderGenerator
            {
                /*0x10*/ System.Runtime.Serialization.XmlFormatReaderGenerator.CriticalHelper helper;

                static /*0x75e7018*/ object UnsafeGetUninitializedObject(int id);
                /*0x75e683c*/ XmlFormatReaderGenerator();
                /*0x75e68b0*/ System.Runtime.Serialization.XmlFormatClassReaderDelegate GenerateClassReader(System.Runtime.Serialization.ClassDataContract classContract);
                /*0x75e6b28*/ System.Runtime.Serialization.XmlFormatCollectionReaderDelegate GenerateCollectionReader(System.Runtime.Serialization.CollectionDataContract collectionContract);
                /*0x75e6da0*/ System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate GenerateGetOnlyCollectionReader(System.Runtime.Serialization.CollectionDataContract collectionContract);

                class CriticalHelper
                {
                    /*0x75e68a8*/ CriticalHelper();
                    /*0x75e6a70*/ System.Runtime.Serialization.XmlFormatClassReaderDelegate GenerateClassReader(System.Runtime.Serialization.ClassDataContract classContract);
                    /*0x75e6ce8*/ System.Runtime.Serialization.XmlFormatCollectionReaderDelegate GenerateCollectionReader(System.Runtime.Serialization.CollectionDataContract collectionContract);
                    /*0x75e6f60*/ System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate GenerateGetOnlyCollectionReader(System.Runtime.Serialization.CollectionDataContract collectionContract);

                    class <>c__DisplayClass0_0
                    {
                        /*0x10*/ System.Runtime.Serialization.ClassDataContract classContract;

                        /*0x75e7094*/ <>c__DisplayClass0_0();
                        /*0x75e70ac*/ object <GenerateClassReader>b__0(System.Runtime.Serialization.XmlReaderDelegator xr, System.Runtime.Serialization.XmlObjectSerializerReadContext ctx, System.Xml.XmlDictionaryString[] memberNames, System.Xml.XmlDictionaryString[] memberNamespaces);
                    }

                    class <>c__DisplayClass1_0
                    {
                        /*0x10*/ System.Runtime.Serialization.CollectionDataContract collectionContract;

                        /*0x75e709c*/ <>c__DisplayClass1_0();
                        /*0x75e7148*/ object <GenerateCollectionReader>b__0(System.Runtime.Serialization.XmlReaderDelegator xr, System.Runtime.Serialization.XmlObjectSerializerReadContext ctx, System.Xml.XmlDictionaryString inm, System.Xml.XmlDictionaryString ins, System.Runtime.Serialization.CollectionDataContract cc);
                    }

                    class <>c__DisplayClass2_0
                    {
                        /*0x10*/ System.Runtime.Serialization.CollectionDataContract collectionContract;

                        /*0x75e70a4*/ <>c__DisplayClass2_0();
                        /*0x75e71f8*/ void <GenerateGetOnlyCollectionReader>b__0(System.Runtime.Serialization.XmlReaderDelegator xr, System.Runtime.Serialization.XmlObjectSerializerReadContext ctx, System.Xml.XmlDictionaryString inm, System.Xml.XmlDictionaryString ins, System.Runtime.Serialization.CollectionDataContract cc);
                    }
                }
            }

            class XmlFormatClassWriterDelegate : System.MulticastDelegate
            {
                /*0x75e72a8*/ XmlFormatClassWriterDelegate(object object, nint method);
                /*0x75e73b4*/ void Invoke(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context, System.Runtime.Serialization.ClassDataContract dataContract);
            }

            class XmlFormatCollectionWriterDelegate : System.MulticastDelegate
            {
                /*0x75e73c8*/ XmlFormatCollectionWriterDelegate(object object, nint method);
                /*0x75e74d4*/ void Invoke(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context, System.Runtime.Serialization.CollectionDataContract dataContract);
            }

            class XmlFormatWriterGenerator
            {
                /*0x10*/ System.Runtime.Serialization.XmlFormatWriterGenerator.CriticalHelper helper;

                /*0x75e74e8*/ XmlFormatWriterGenerator();
                /*0x75e755c*/ System.Runtime.Serialization.XmlFormatClassWriterDelegate GenerateClassWriter(System.Runtime.Serialization.ClassDataContract classContract);
                /*0x75e77d4*/ System.Runtime.Serialization.XmlFormatCollectionWriterDelegate GenerateCollectionWriter(System.Runtime.Serialization.CollectionDataContract collectionContract);

                class CriticalHelper
                {
                    /*0x75e7554*/ CriticalHelper();
                    /*0x75e771c*/ System.Runtime.Serialization.XmlFormatClassWriterDelegate GenerateClassWriter(System.Runtime.Serialization.ClassDataContract classContract);
                    /*0x75e7994*/ System.Runtime.Serialization.XmlFormatCollectionWriterDelegate GenerateCollectionWriter(System.Runtime.Serialization.CollectionDataContract collectionContract);

                    class <>c__DisplayClass0_0
                    {
                        /*0x10*/ System.Runtime.Serialization.ClassDataContract classContract;

                        /*0x75e7a4c*/ <>c__DisplayClass0_0();
                        /*0x75e7a5c*/ void <GenerateClassWriter>b__0(System.Runtime.Serialization.XmlWriterDelegator xw, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext ctx, System.Runtime.Serialization.ClassDataContract ctr);
                    }

                    class <>c__DisplayClass1_0
                    {
                        /*0x10*/ System.Runtime.Serialization.CollectionDataContract collectionContract;

                        /*0x75e7a54*/ <>c__DisplayClass1_0();
                        /*0x75e7af8*/ void <GenerateCollectionWriter>b__0(System.Runtime.Serialization.XmlWriterDelegator xw, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext ctx, System.Runtime.Serialization.CollectionDataContract ctr);
                    }
                }
            }

            class XmlObjectSerializer
            {
                static /*0x0*/ System.Runtime.Serialization.IFormatterConverter formatterConverter;

                static /*0x75e8748*/ void WriteNull(System.Runtime.Serialization.XmlWriterDelegator writer);
                static /*0x75e87d4*/ bool IsContractDeclared(System.Runtime.Serialization.DataContract contract, System.Runtime.Serialization.DataContract declaredContract);
                static /*0x75e7c40*/ void CheckNull(object obj, string name);
                static /*0x75e908c*/ string TryAddLineInfo(System.Runtime.Serialization.XmlReaderDelegator reader, string errorMessage);
                static /*0x75e925c*/ System.Exception CreateSerializationExceptionWithReaderDetails(string errorMessage, System.Runtime.Serialization.XmlReaderDelegator reader);
                static /*0x75d988c*/ System.Runtime.Serialization.SerializationException CreateSerializationException(string errorMessage);
                static /*0x75e0c40*/ System.Runtime.Serialization.SerializationException CreateSerializationException(string errorMessage, System.Exception innerException);
                static /*0x75e81c8*/ string GetTypeInfo(System.Type type);
                static /*0x75e8230*/ string GetTypeInfoError(string errorMessage, System.Type type, System.Exception innerException);
                static /*0x75e35a4*/ System.Runtime.Serialization.IFormatterConverter get_FormatterConverter();
                /*0x75e9450*/ XmlObjectSerializer();
                /*0x3816810*/ void WriteStartObject(System.Xml.XmlDictionaryWriter writer, object graph);
                /*0x3816810*/ void WriteObjectContent(System.Xml.XmlDictionaryWriter writer, object graph);
                /*0x3816710*/ void WriteEndObject(System.Xml.XmlDictionaryWriter writer);
                /*0x75e7b94*/ void WriteObject(System.IO.Stream stream, object graph);
                /*0x75e7c9c*/ void WriteStartObject(System.Xml.XmlWriter writer, object graph);
                /*0x75e7d18*/ void WriteObjectContent(System.Xml.XmlWriter writer, object graph);
                /*0x75e7d94*/ void WriteEndObject(System.Xml.XmlWriter writer);
                /*0x75e7e08*/ void WriteObject(System.Xml.XmlDictionaryWriter writer, object graph);
                /*0x75e7e80*/ void WriteObjectHandleExceptions(System.Runtime.Serialization.XmlWriterDelegator writer, object graph);
                /*0x75e7e88*/ void WriteObjectHandleExceptions(System.Runtime.Serialization.XmlWriterDelegator writer, object graph, System.Runtime.Serialization.DataContractResolver dataContractResolver);
                /*0x75e8400*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> get_KnownDataContracts();
                /*0x75e8408*/ void InternalWriteObject(System.Runtime.Serialization.XmlWriterDelegator writer, object graph);
                /*0x75e8468*/ void InternalWriteObject(System.Runtime.Serialization.XmlWriterDelegator writer, object graph, System.Runtime.Serialization.DataContractResolver dataContractResolver);
                /*0x75e8478*/ void InternalWriteStartObject(System.Runtime.Serialization.XmlWriterDelegator writer, object graph);
                /*0x75e84c0*/ void InternalWriteObjectContent(System.Runtime.Serialization.XmlWriterDelegator writer, object graph);
                /*0x75e8508*/ void InternalWriteEndObject(System.Runtime.Serialization.XmlWriterDelegator writer);
                /*0x75da7d8*/ void WriteStartObjectHandleExceptions(System.Runtime.Serialization.XmlWriterDelegator writer, object graph);
                /*0x75da9b4*/ void WriteObjectContentHandleExceptions(System.Runtime.Serialization.XmlWriterDelegator writer, object graph);
                /*0x75db930*/ void WriteEndObjectHandleExceptions(System.Runtime.Serialization.XmlWriterDelegator writer);
                /*0x75e8550*/ void WriteRootElement(System.Runtime.Serialization.XmlWriterDelegator writer, System.Runtime.Serialization.DataContract contract, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns, bool needsContractNsAtRoot);
                /*0x75e862c*/ bool CheckIfNeedsContractNsAtRoot(System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns, System.Runtime.Serialization.DataContract contract);
                /*0x75e88ac*/ object ReadObject(System.IO.Stream stream);
                /*0x75e8984*/ object ReadObject(System.Xml.XmlDictionaryReader reader);
                /*0x75e89f8*/ object ReadObject(System.Xml.XmlReader reader, bool verifyObjectName);
                /*0x3814a74*/ object ReadObject(System.Xml.XmlDictionaryReader reader, bool verifyObjectName);
                /*0x75e8a78*/ object InternalReadObject(System.Runtime.Serialization.XmlReaderDelegator reader, bool verifyObjectName);
                /*0x75e8aa0*/ object InternalReadObject(System.Runtime.Serialization.XmlReaderDelegator reader, bool verifyObjectName, System.Runtime.Serialization.DataContractResolver dataContractResolver);
                /*0x75e8ab4*/ bool InternalIsStartObject(System.Runtime.Serialization.XmlReaderDelegator reader);
                /*0x75dbaec*/ object ReadObjectHandleExceptions(System.Runtime.Serialization.XmlReaderDelegator reader, bool verifyObjectName);
                /*0x75e8afc*/ object ReadObjectHandleExceptions(System.Runtime.Serialization.XmlReaderDelegator reader, bool verifyObjectName, System.Runtime.Serialization.DataContractResolver dataContractResolver);
                /*0x75e8e3c*/ bool IsRootXmlAny(System.Xml.XmlDictionaryString rootName, System.Runtime.Serialization.DataContract contract);
                /*0x75e8e74*/ bool IsStartElement(System.Runtime.Serialization.XmlReaderDelegator reader);
                /*0x75e8eb0*/ bool IsRootElement(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.DataContract contract, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75e9430*/ System.Type GetSerializeType(object graph);
                /*0x75e9448*/ System.Type GetDeserializeType();
            }

            class XmlObjectSerializerContext
            {
                static /*0x0*/ System.Reflection.MethodInfo incrementItemCountMethod;
                /*0x10*/ System.Runtime.Serialization.XmlObjectSerializer serializer;
                /*0x18*/ System.Runtime.Serialization.DataContract rootTypeDataContract;
                /*0x20*/ System.Runtime.Serialization.ScopedKnownTypes scopedKnownTypes;
                /*0x30*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> serializerKnownDataContracts;
                /*0x38*/ bool isSerializerKnownDataContractsSetExplicit;
                /*0x40*/ System.Collections.Generic.IList<System.Type> serializerKnownTypeList;
                /*0x48*/ int itemCount;
                /*0x4c*/ int maxItemsInObjectGraph;
                /*0x50*/ System.Runtime.Serialization.StreamingContext streamingContext;
                /*0x60*/ bool ignoreExtensionDataObject;
                /*0x68*/ System.Runtime.Serialization.DataContractResolver dataContractResolver;
                /*0x70*/ System.Runtime.Serialization.KnownTypeDataContractResolver knownTypeResolver;

                static /*0x75e95c4*/ System.Reflection.MethodInfo get_IncrementItemCountMethod();
                static /*0x75e9b68*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> GetDataContractsForKnownTypes(System.Collections.Generic.IList<System.Type> knownTypeList);
                /*0x75e9458*/ XmlObjectSerializerContext(System.Runtime.Serialization.XmlObjectSerializer serializer, int maxItemsInObjectGraph, System.Runtime.Serialization.StreamingContext streamingContext, bool ignoreExtensionDataObject, System.Runtime.Serialization.DataContractResolver dataContractResolver);
                /*0x75e94dc*/ XmlObjectSerializerContext(System.Runtime.Serialization.XmlObjectSerializer serializer, int maxItemsInObjectGraph, System.Runtime.Serialization.StreamingContext streamingContext, bool ignoreExtensionDataObject);
                /*0x75e94e8*/ XmlObjectSerializerContext(System.Runtime.Serialization.DataContractSerializer serializer, System.Runtime.Serialization.DataContract rootTypeDataContract, System.Runtime.Serialization.DataContractResolver dataContractResolver);
                /*0x75e9578*/ XmlObjectSerializerContext(System.Runtime.Serialization.NetDataContractSerializer serializer);
                /*0x75e959c*/ System.Runtime.Serialization.SerializationMode get_Mode();
                /*0x75e95a4*/ bool get_IsGetOnlyCollection();
                /*0x75e95ac*/ void set_IsGetOnlyCollection(bool value);
                /*0x75e95b0*/ void DemandSerializationFormatterPermission();
                /*0x75e95b4*/ void DemandMemberAccessPermission();
                /*0x75e95b8*/ System.Runtime.Serialization.StreamingContext GetStreamingContext();
                /*0x75e96ac*/ void IncrementItemCount(int count);
                /*0x75e977c*/ int get_RemainingItemCount();
                /*0x75e9788*/ bool get_IgnoreExtensionDataObject();
                /*0x75e9790*/ System.Runtime.Serialization.DataContractResolver get_DataContractResolver();
                /*0x75e9798*/ System.Runtime.Serialization.KnownTypeDataContractResolver get_KnownTypeResolver();
                /*0x75e981c*/ System.Runtime.Serialization.DataContract GetDataContract(System.Type type);
                /*0x75e9868*/ System.Runtime.Serialization.DataContract GetDataContract(System.RuntimeTypeHandle typeHandle, System.Type type);
                /*0x75e9908*/ System.Runtime.Serialization.DataContract GetDataContractSkipValidation(int typeId, System.RuntimeTypeHandle typeHandle, System.Type type);
                /*0x75e9968*/ System.Runtime.Serialization.DataContract GetDataContract(int id, System.RuntimeTypeHandle typeHandle);
                /*0x75e99e4*/ void CheckIfTypeSerializable(System.Type memberType, bool isMemberTypeSerializable);
                /*0x75e9a90*/ System.Type GetSurrogatedType(System.Type type);
                /*0x75e9a98*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> get_SerializerKnownDataContracts();
                /*0x75e9af0*/ System.Runtime.Serialization.DataContract GetDataContractFromSerializerKnownTypes(System.Xml.XmlQualifiedName qname);
                /*0x75da52c*/ bool IsKnownType(System.Runtime.Serialization.DataContract dataContract, System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> knownDataContracts, System.Type declaredType);
                /*0x75e9e28*/ bool IsKnownType(System.Runtime.Serialization.DataContract dataContract, System.Type declaredType);
                /*0x75ea02c*/ System.Runtime.Serialization.DataContract ResolveDataContractFromKnownTypes(System.Xml.XmlQualifiedName typeName);
                /*0x75ea080*/ System.Runtime.Serialization.DataContract ResolveDataContractFromDataContractResolver(System.Xml.XmlQualifiedName typeName, System.Type declaredType);
                /*0x75da630*/ System.Type ResolveNameFromKnownTypes(System.Xml.XmlQualifiedName typeName);
                /*0x75e9eec*/ System.Runtime.Serialization.DataContract ResolveDataContractFromKnownTypes(string typeName, string typeNs, System.Runtime.Serialization.DataContract memberTypeContract, System.Type declaredType);
                /*0x75ea1c8*/ System.Runtime.Serialization.DataContract ResolveDataContractFromRootDataContract(System.Xml.XmlQualifiedName typeQName);
            }

            class XmlObjectSerializerReadContext : System.Runtime.Serialization.XmlObjectSerializerContext
            {
                /*0x78*/ System.Runtime.Serialization.Attributes attributes;
                /*0x80*/ System.Runtime.Serialization.HybridObjectCache deserializedObjects;
                /*0x88*/ System.Runtime.Serialization.XmlSerializableReader xmlSerializableReader;
                /*0x90*/ System.Xml.XmlDocument xmlDocument;
                /*0x98*/ System.Runtime.Serialization.Attributes attributesInXmlData;
                /*0xa0*/ System.Runtime.Serialization.XmlReaderDelegator extensionDataReader;
                /*0xa8*/ object getOnlyCollectionValue;
                /*0xb0*/ bool isGetOnlyCollection;

                static /*0x75ea424*/ void ThrowNullValueReturnedForGetOnlyCollectionException(System.Type type);
                static /*0x75ea4bc*/ void ThrowArrayExceededSizeException(int arraySize, System.Type type);
                static /*0x75ea59c*/ System.Runtime.Serialization.XmlObjectSerializerReadContext CreateContext(System.Runtime.Serialization.DataContractSerializer serializer, System.Runtime.Serialization.DataContract rootTypeDataContract, System.Runtime.Serialization.DataContractResolver dataContractResolver);
                static /*0x75eb3a8*/ bool MoveToNextElement(System.Runtime.Serialization.XmlReaderDelegator xmlReader);
                static /*0x75eb660*/ void ThrowRequiredMemberMissingException(System.Runtime.Serialization.XmlReaderDelegator xmlReader, int memberIndex, int requiredIndex, System.Xml.XmlDictionaryString[] memberNames);
                static /*0x75ec34c*/ void Read(System.Runtime.Serialization.XmlReaderDelegator xmlReader);
                static /*0x75ec3a8*/ void ParseQualifiedName(string qname, System.Runtime.Serialization.XmlReaderDelegator xmlReader, ref string name, ref string ns, ref string prefix);
                static /*0x38390c0*/ T[] EnsureArraySize<T>(T[] array, int index);
                static /*0x38390c0*/ T[] TrimArraySize<T>(T[] array, int size);
                static /*0x75e5080*/ object ReadRootIXmlSerializable(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.XmlDataContract xmlDataContract, bool isMemberType);
                static /*0x75ec648*/ object ReadIXmlSerializable(System.Runtime.Serialization.XmlSerializableReader xmlSerializableReader, System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.XmlDataContract xmlDataContract, bool isMemberType);
                static /*0x75eee28*/ System.Xml.XmlNode CreateWrapperXmlElement(System.Xml.XmlDocument document, System.Collections.Generic.IList<System.Xml.XmlAttribute> xmlAttributes, System.Collections.Generic.IList<System.Xml.XmlNode> xmlChildNodes, string prefix, string localName, string ns);
                static /*0x75eb8c4*/ System.Exception CreateUnexpectedStateException(System.Xml.XmlNodeType expectedState, System.Runtime.Serialization.XmlReaderDelegator xmlReader);
                /*0x75ea728*/ XmlObjectSerializerReadContext(System.Runtime.Serialization.XmlObjectSerializer serializer, int maxItemsInObjectGraph, System.Runtime.Serialization.StreamingContext streamingContext, bool ignoreExtensionDataObject);
                /*0x75ea658*/ XmlObjectSerializerReadContext(System.Runtime.Serialization.DataContractSerializer serializer, System.Runtime.Serialization.DataContract rootTypeDataContract, System.Runtime.Serialization.DataContractResolver dataContractResolver);
                /*0x75ea304*/ System.Runtime.Serialization.HybridObjectCache get_DeserializedObjects();
                /*0x75ea374*/ System.Xml.XmlDocument get_Document();
                /*0x75ea3e4*/ bool get_IsGetOnlyCollection();
                /*0x75ea3ec*/ void set_IsGetOnlyCollection(bool value);
                /*0x75ea3f8*/ object GetCollectionMember();
                /*0x75ea400*/ void StoreCollectionMemberInfo(object collectionMember);
                /*0x75ea734*/ object InternalDeserialize(System.Runtime.Serialization.XmlReaderDelegator xmlReader, int id, System.RuntimeTypeHandle declaredTypeHandle, string name, string ns);
                /*0x75eae28*/ object InternalDeserialize(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Type declaredType, string name, string ns);
                /*0x75eae8c*/ object InternalDeserialize(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Type declaredType, System.Runtime.Serialization.DataContract dataContract, string name, string ns);
                /*0x75eaef4*/ bool TryHandleNullOrRef(System.Runtime.Serialization.XmlReaderDelegator reader, System.Type declaredType, string name, string ns, ref object retObj);
                /*0x75ea7cc*/ object InternalDeserialize(System.Runtime.Serialization.XmlReaderDelegator reader, string name, string ns, System.Type declaredType, ref System.Runtime.Serialization.DataContract dataContract);
                /*0x75eb370*/ bool ReplaceScopedKnownTypesTop(System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> knownDataContracts, bool knownTypesAddedInCurrentScope);
                /*0x75eb3cc*/ int GetMemberIndex(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Xml.XmlDictionaryString[] memberNames, System.Xml.XmlDictionaryString[] memberNamespaces, int memberIndex, System.Runtime.Serialization.ExtensionDataObject extensionData);
                /*0x75eb564*/ int GetMemberIndexWithRequiredMembers(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Xml.XmlDictionaryString[] memberNames, System.Xml.XmlDictionaryString[] memberNamespaces, int memberIndex, int requiredIndex, System.Runtime.Serialization.ExtensionDataObject extensionData);
                /*0x75eb4ac*/ void HandleMemberNotFound(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.ExtensionDataObject extensionData, int memberIndex);
                /*0x75ebb5c*/ void HandleUnknownElement(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.ExtensionDataObject extensionData, int memberIndex);
                /*0x75eb9c4*/ void SkipUnknownElement(System.Runtime.Serialization.XmlReaderDelegator xmlReader);
                /*0x75ebd94*/ string ReadIfNullOrRef(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Type memberType, bool isMemberTypeSerializable);
                /*0x75ebec0*/ void ReadAttributes(System.Runtime.Serialization.XmlReaderDelegator xmlReader);
                /*0x75ebf44*/ void ResetAttributes();
                /*0x75e3e18*/ string GetObjectId();
                /*0x75ebf58*/ int GetArraySize();
                /*0x75ddbe8*/ void AddNewObject(object obj);
                /*0x75ebf60*/ void AddNewObjectWithId(string id, object obj);
                /*0x75e40b8*/ void ReplaceDeserializedObject(string id, object oldObj, object newObj);
                /*0x75eb0e0*/ object GetExistingObject(string id, System.Type type, string name, string ns);
                /*0x75ec1b0*/ object GetExistingObjectOrExtensionData(string id);
                /*0x75ec258*/ object GetRealObject(System.Runtime.Serialization.IObjectReference obj, string id);
                /*0x75ec024*/ object DeserializeFromExtensionData(System.Runtime.Serialization.IDataNode dataNode, System.Type type, string name, string ns);
                /*0x75ec4a0*/ void CheckEndOfArray(System.Runtime.Serialization.XmlReaderDelegator xmlReader, int arraySize, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace);
                /*0x75e50f4*/ object ReadIXmlSerializable(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.XmlDataContract xmlDataContract, bool isMemberType);
                /*0x75e3e34*/ System.Runtime.Serialization.SerializationInfo ReadSerializationInfo(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Type type);
                /*0x75ec970*/ System.Runtime.Serialization.DataContract ResolveDataContractFromTypeName();
                /*0x75ebc98*/ System.Runtime.Serialization.ExtensionDataMember ReadExtensionDataMember(System.Runtime.Serialization.XmlReaderDelegator xmlReader, int memberIndex);
                /*0x75ec9a8*/ System.Runtime.Serialization.IDataNode ReadExtensionDataValue(System.Runtime.Serialization.XmlReaderDelegator xmlReader);
                /*0x75ee1c8*/ void StartReadExtensionDataValue(System.Runtime.Serialization.XmlReaderDelegator xmlReader);
                /*0x75ed854*/ System.Runtime.Serialization.IDataNode ReadExtensionDataValue(System.Runtime.Serialization.XmlReaderDelegator xmlReader, string dataContractName, string dataContractNamespace);
                /*0x75eea8c*/ System.Runtime.Serialization.IDataNode ReadPrimitiveExtensionDataValue(System.Runtime.Serialization.XmlReaderDelegator xmlReader, string dataContractName, string dataContractNamespace);
                /*0x75edf60*/ void InitializeExtensionDataNode(System.Runtime.Serialization.IDataNode dataNode, string dataContractName, string dataContractNamespace);
                /*0x75edf04*/ System.Runtime.Serialization.IDataNode ReadUnknownPrimitiveData(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Type type, string dataContractName, string dataContractNamespace);
                /*0x75ed650*/ System.Runtime.Serialization.ClassDataNode ReadUnknownClassData(System.Runtime.Serialization.XmlReaderDelegator xmlReader, string dataContractName, string dataContractNamespace);
                /*0x75eced0*/ System.Runtime.Serialization.CollectionDataNode ReadUnknownCollectionData(System.Runtime.Serialization.XmlReaderDelegator xmlReader, string dataContractName, string dataContractNamespace);
                /*0x75ed3c0*/ System.Runtime.Serialization.ISerializableDataNode ReadUnknownISerializableData(System.Runtime.Serialization.XmlReaderDelegator xmlReader, string dataContractName, string dataContractNamespace);
                /*0x75edad8*/ System.Runtime.Serialization.IDataNode ReadUnknownXmlData(System.Runtime.Serialization.XmlReaderDelegator xmlReader, string dataContractName, string dataContractNamespace);
                /*0x75ee1cc*/ System.Runtime.Serialization.IDataNode ReadAndResolveUnknownXmlData(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Collections.Generic.IDictionary<string, string> namespaces, string dataContractName, string dataContractNamespace);
                /*0x75eed3c*/ bool IsContentNode(System.Xml.XmlNodeType nodeType);
                /*0x75eed60*/ System.Runtime.Serialization.XmlReaderDelegator CreateReaderOverChildNodes(System.Collections.Generic.IList<System.Xml.XmlAttribute> xmlAttributes, System.Collections.Generic.IList<System.Xml.XmlNode> xmlChildNodes);
                /*0x75eec60*/ System.Xml.XmlAttribute AddNamespaceDeclaration(string prefix, string ns);
                /*0x75ef118*/ object ReadDataContractValue(System.Runtime.Serialization.DataContract dataContract, System.Runtime.Serialization.XmlReaderDelegator reader);
                /*0x75ef144*/ System.Runtime.Serialization.XmlReaderDelegator CreateReaderDelegatorForReader(System.Xml.XmlReader xmlReader);
                /*0x75ef1a0*/ bool IsReadingCollectionExtensionData(System.Runtime.Serialization.XmlReaderDelegator xmlReader);
                /*0x75ef1c4*/ bool IsReadingClassExtensionData(System.Runtime.Serialization.XmlReaderDelegator xmlReader);
            }

            class XmlObjectSerializerReadContextComplex : System.Runtime.Serialization.XmlObjectSerializerReadContext
            {
                static /*0x0*/ System.Collections.Hashtable dataContractTypeCache;
                /*0xb1*/ bool preserveObjectReferences;
                /*0xb8*/ System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate;
                /*0xc0*/ System.Runtime.Serialization.SerializationMode mode;
                /*0xc8*/ System.Runtime.Serialization.SerializationBinder binder;
                /*0xd0*/ System.Runtime.Serialization.ISurrogateSelector surrogateSelector;
                /*0xd8*/ System.Runtime.Serialization.Formatters.FormatterAssemblyStyle assemblyFormat;
                /*0xe0*/ System.Collections.Hashtable surrogateDataContracts;

                static /*0x75f0c40*/ XmlObjectSerializerReadContextComplex();
                static /*0x75f0bd0*/ System.Reflection.Assembly ResolveSimpleAssemblyName(System.Reflection.AssemblyName assemblyName);
                static /*0x75f05d8*/ System.Reflection.Assembly ResolveSimpleAssemblyName(string assemblyName);
                static /*0x75f0728*/ void CheckTypeForwardedTo(System.Reflection.Assembly sourceAssembly, System.Reflection.Assembly destinationAssembly, System.Type resolvedType);
                /*0x75ea6e8*/ XmlObjectSerializerReadContextComplex(System.Runtime.Serialization.DataContractSerializer serializer, System.Runtime.Serialization.DataContract rootTypeDataContract, System.Runtime.Serialization.DataContractResolver dataContractResolver);
                /*0x75ef1cc*/ XmlObjectSerializerReadContextComplex(System.Runtime.Serialization.XmlObjectSerializer serializer, int maxItemsInObjectGraph, System.Runtime.Serialization.StreamingContext streamingContext, bool ignoreExtensionDataObject);
                /*0x75ef1d8*/ System.Runtime.Serialization.SerializationMode get_Mode();
                /*0x75ef1e0*/ System.Runtime.Serialization.DataContract GetDataContract(int id, System.RuntimeTypeHandle typeHandle);
                /*0x75ef3a0*/ System.Runtime.Serialization.DataContract GetDataContract(System.RuntimeTypeHandle typeHandle, System.Type type);
                /*0x75ef560*/ object InternalDeserialize(System.Runtime.Serialization.XmlReaderDelegator xmlReader, int declaredTypeID, System.RuntimeTypeHandle declaredTypeHandle, string name, string ns);
                /*0x75efdc8*/ object InternalDeserialize(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Type declaredType, string name, string ns);
                /*0x75efe98*/ object InternalDeserialize(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Type declaredType, System.Runtime.Serialization.DataContract dataContract, string name, string ns);
                /*0x75ef918*/ object InternalDeserializeInSharedTypeMode(System.Runtime.Serialization.XmlReaderDelegator xmlReader, int declaredTypeID, System.Type declaredType, string name, string ns);
                /*0x75ef664*/ object InternalDeserializeWithSurrogate(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Type declaredType, System.Runtime.Serialization.DataContract surrogateDataContract, string name, string ns);
                /*0x75eff40*/ System.Type ResolveDataContractTypeInSharedTypeMode(string assemblyName, string typeName, ref System.Reflection.Assembly assembly);
                /*0x75efec8*/ System.Runtime.Serialization.DataContract ResolveDataContractInSharedTypeMode(string assemblyName, string typeName, ref System.Reflection.Assembly assembly, ref System.Type type);
                /*0x75f07f8*/ System.Runtime.Serialization.DataContract ResolveDataContractFromTypeName();
                /*0x75f0850*/ bool CheckIfTypeSerializableForSharedTypeMode(System.Type memberType);
                /*0x75f0920*/ void CheckIfTypeSerializable(System.Type memberType, bool isMemberTypeSerializable);
                /*0x75f0a68*/ System.Type GetSurrogatedType(System.Type type);
                /*0x75f0ba4*/ int GetArraySize();

                class TopLevelAssemblyTypeResolver
                {
                    /*0x10*/ System.Reflection.Assembly topLevelAssembly;

                    /*0x75f06f8*/ TopLevelAssemblyTypeResolver(System.Reflection.Assembly topLevelAssembly);
                    /*0x75f0cbc*/ System.Type ResolveType(System.Reflection.Assembly assembly, string simpleTypeName, bool ignoreCase);
                }

                class XmlObjectDataContractTypeInfo
                {
                    /*0x10*/ System.Reflection.Assembly assembly;
                    /*0x18*/ System.Type type;

                    /*0x75f07b4*/ XmlObjectDataContractTypeInfo(System.Reflection.Assembly assembly, System.Type type);
                    /*0x75f0d24*/ System.Reflection.Assembly get_Assembly();
                    /*0x75f0d2c*/ System.Type get_Type();
                }

                class XmlObjectDataContractTypeKey
                {
                    /*0x10*/ string assemblyName;
                    /*0x18*/ string typeName;

                    /*0x75f0594*/ XmlObjectDataContractTypeKey(string assemblyName, string typeName);
                    /*0x75f0d34*/ bool Equals(object obj);
                    /*0x75f0df8*/ int GetHashCode();
                }
            }

            class XmlObjectSerializerWriteContext : System.Runtime.Serialization.XmlObjectSerializerContext
            {
                /*0x78*/ System.Runtime.Serialization.ObjectReferenceStack byValObjectsInScope;
                /*0x98*/ System.Runtime.Serialization.XmlSerializableWriter xmlSerializableWriter;
                /*0xa0*/ bool preserveObjectReferences;
                /*0xa8*/ System.Runtime.Serialization.ObjectToIdCache serializedObjects;
                /*0xb0*/ bool isGetOnlyCollection;
                /*0xb1*/ bool unsafeTypeForwardingEnabled;
                /*0xb2*/ bool serializeReadOnlyTypes;

                static /*0x75f0e4c*/ System.Runtime.Serialization.XmlObjectSerializerWriteContext CreateContext(System.Runtime.Serialization.DataContractSerializer serializer, System.Runtime.Serialization.DataContract rootTypeDataContract, System.Runtime.Serialization.DataContractResolver dataContractResolver);
                static /*0x75f0f80*/ System.Runtime.Serialization.XmlObjectSerializerWriteContext CreateContext(System.Runtime.Serialization.NetDataContractSerializer serializer, System.Collections.Hashtable surrogateDataContracts);
                static /*0x3910ae8*/ T GetDefaultValue<T>();
                static /*0x3910ae8*/ T GetNullableValue<T>(System.Nullable<T> value);
                static /*0x75f2830*/ void ThrowRequiredMemberMustBeEmitted(string memberName, System.Type type);
                static /*0x3910ae8*/ bool GetHasValue<T>(System.Nullable<T> value);
                static /*0x75e4f14*/ void WriteRootIXmlSerializable(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj);
                static /*0x75f2920*/ void WriteIXmlSerializable(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.XmlSerializableWriter xmlSerializableWriter);
                /*0x75f0f08*/ XmlObjectSerializerWriteContext(System.Runtime.Serialization.DataContractSerializer serializer, System.Runtime.Serialization.DataContract rootTypeDataContract, System.Runtime.Serialization.DataContractResolver resolver);
                /*0x75f1060*/ XmlObjectSerializerWriteContext(System.Runtime.Serialization.NetDataContractSerializer serializer);
                /*0x75f10d4*/ XmlObjectSerializerWriteContext(System.Runtime.Serialization.XmlObjectSerializer serializer, int maxItemsInObjectGraph, System.Runtime.Serialization.StreamingContext streamingContext, bool ignoreExtensionDataObject);
                /*0x75f10f8*/ System.Runtime.Serialization.ObjectToIdCache get_SerializedObjects();
                /*0x75f1164*/ bool get_IsGetOnlyCollection();
                /*0x75f116c*/ void set_IsGetOnlyCollection(bool value);
                /*0x75f1178*/ bool get_SerializeReadOnlyTypes();
                /*0x75f1180*/ bool get_UnsafeTypeForwardingEnabled();
                /*0x75f1188*/ void StoreIsGetOnlyCollection();
                /*0x75f1194*/ void InternalSerializeReference(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, bool isDeclaredType, bool writeXsiType, int declaredTypeID, System.RuntimeTypeHandle declaredTypeHandle);
                /*0x75f1234*/ void InternalSerialize(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, bool isDeclaredType, bool writeXsiType, int declaredTypeID, System.RuntimeTypeHandle declaredTypeHandle);
                /*0x75f1474*/ void SerializeWithoutXsiType(System.Runtime.Serialization.DataContract dataContract, System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.RuntimeTypeHandle declaredTypeHandle);
                /*0x75f1794*/ void SerializeWithXsiTypeAtTopLevel(System.Runtime.Serialization.DataContract dataContract, System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.RuntimeTypeHandle originalDeclaredTypeHandle, System.Type graphType);
                /*0x75f1ad8*/ void SerializeWithXsiType(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.RuntimeTypeHandle objectTypeHandle, System.Type objectType, int declaredTypeID, System.RuntimeTypeHandle declaredTypeHandle, System.Type declaredType);
                /*0x75f155c*/ bool OnHandleIsReference(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Runtime.Serialization.DataContract contract, object obj);
                /*0x75f18e0*/ void SerializeAndVerifyType(System.Runtime.Serialization.DataContract dataContract, System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, bool verifyKnownType, System.RuntimeTypeHandle declaredTypeHandle, System.Type declaredType);
                /*0x75f1de8*/ bool WriteClrTypeInfo(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Runtime.Serialization.DataContract dataContract);
                /*0x75f1df0*/ bool WriteClrTypeInfo(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Type dataContractType, string clrTypeName, string clrAssemblyName);
                /*0x75f1df8*/ bool WriteClrTypeInfo(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Type dataContractType, System.Runtime.Serialization.SerializationInfo serInfo);
                /*0x75f1e00*/ void WriteAnyType(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object value);
                /*0x75f1e1c*/ void WriteString(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, string value);
                /*0x75f1e38*/ void WriteString(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, string value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75f1f74*/ void WriteBase64(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, byte[] value);
                /*0x75f1f9c*/ void WriteBase64(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, byte[] value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75f208c*/ void WriteUri(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Uri value);
                /*0x75f20a8*/ void WriteUri(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Uri value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75f21c8*/ void WriteQName(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Xml.XmlQualifiedName value);
                /*0x75f21f4*/ void WriteQName(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Xml.XmlQualifiedName value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75f2368*/ void HandleGraphAtTopLevel(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.DataContract contract);
                /*0x75f2480*/ bool OnHandleReference(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, bool canContainCyclicReference);
                /*0x75f2634*/ void OnEndHandleReference(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, bool canContainCyclicReference);
                /*0x75f2668*/ void WriteNull(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Type memberType, bool isMemberTypeSerializable);
                /*0x75f1ef4*/ void WriteNull(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Type memberType, bool isMemberTypeSerializable, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75f26b4*/ void IncrementArrayCount(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Array array);
                /*0x75f2750*/ void IncrementCollectionCount(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Collections.ICollection collection);
                /*0x3816810*/ void IncrementCollectionCountGeneric<T>(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Collections.Generic.ICollection<T> collection);
                /*0x75f2710*/ void IncrementCollectionCount(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, int size);
                /*0x75f282c*/ void WriteArraySize(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, int size);
                /*0x75e4f80*/ void WriteIXmlSerializable(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj);
                /*0x75f2b7c*/ void GetObjectData(System.Runtime.Serialization.ISerializable obj, System.Runtime.Serialization.SerializationInfo serInfo, System.Runtime.Serialization.StreamingContext context);
                /*0x75f2c38*/ void WriteISerializable(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Runtime.Serialization.ISerializable obj);
                /*0x75e3718*/ void WriteSerializationInfo(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Type objType, System.Runtime.Serialization.SerializationInfo serInfo);
                /*0x75f2fcc*/ void WriteExtensionData(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Runtime.Serialization.ExtensionDataObject extensionData, int memberIndex);
                /*0x75f3150*/ void WriteExtensionDataMember(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Runtime.Serialization.ExtensionDataMember member);
                /*0x75f391c*/ void WriteExtensionDataTypeInfo(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Runtime.Serialization.IDataNode dataNode);
                /*0x75f31a8*/ void WriteExtensionDataValue(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Runtime.Serialization.IDataNode dataNode);
                /*0x75f474c*/ bool TryWriteDeserializedExtensionData(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Runtime.Serialization.IDataNode dataNode);
                /*0x75f3be8*/ void WriteExtensionClassData(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Runtime.Serialization.ClassDataNode dataNode);
                /*0x75f3d6c*/ void WriteExtensionCollectionData(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Runtime.Serialization.CollectionDataNode dataNode);
                /*0x75f451c*/ void WriteExtensionISerializableData(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Runtime.Serialization.ISerializableDataNode dataNode);
                /*0x75f3f2c*/ void WriteExtensionXmlData(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Runtime.Serialization.XmlDataNode dataNode);
                /*0x75f48ec*/ void WriteDataContractValue(System.Runtime.Serialization.DataContract dataContract, System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.RuntimeTypeHandle declaredTypeHandle);
                /*0x75f491c*/ void WriteNull(System.Runtime.Serialization.XmlWriterDelegator xmlWriter);
                /*0x75f187c*/ void WriteResolvedTypeInfo(System.Runtime.Serialization.XmlWriterDelegator writer, System.Type objectType, System.Type declaredType);
                /*0x75f2dcc*/ bool ResolveType(System.Type objectType, System.Type declaredType, ref System.Xml.XmlDictionaryString typeName, ref System.Xml.XmlDictionaryString typeNamespace);
                /*0x75f4924*/ bool WriteTypeInfo(System.Runtime.Serialization.XmlWriterDelegator writer, System.Runtime.Serialization.DataContract contract, System.Runtime.Serialization.DataContract declaredContract);
                /*0x75f49e4*/ void WriteTypeInfo(System.Runtime.Serialization.XmlWriterDelegator writer, string dataContractName, string dataContractNamespace);
                /*0x75f4a84*/ void WriteTypeInfo(System.Runtime.Serialization.XmlWriterDelegator writer, System.Xml.XmlDictionaryString dataContractName, System.Xml.XmlDictionaryString dataContractNamespace);
            }

            class XmlObjectSerializerWriteContextComplex : System.Runtime.Serialization.XmlObjectSerializerWriteContext
            {
                /*0xb8*/ System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate;
                /*0xc0*/ System.Runtime.Serialization.SerializationMode mode;
                /*0xc8*/ System.Runtime.Serialization.SerializationBinder binder;
                /*0xd0*/ System.Runtime.Serialization.ISurrogateSelector surrogateSelector;
                /*0xd8*/ System.Runtime.Serialization.StreamingContext streamingContext;
                /*0xe8*/ System.Collections.Hashtable surrogateDataContracts;

                /*0x75f0f40*/ XmlObjectSerializerWriteContextComplex(System.Runtime.Serialization.DataContractSerializer serializer, System.Runtime.Serialization.DataContract rootTypeDataContract, System.Runtime.Serialization.DataContractResolver dataContractResolver);
                /*0x75f0fe8*/ XmlObjectSerializerWriteContextComplex(System.Runtime.Serialization.NetDataContractSerializer serializer, System.Collections.Hashtable surrogateDataContracts);
                /*0x75f4b24*/ XmlObjectSerializerWriteContextComplex(System.Runtime.Serialization.XmlObjectSerializer serializer, int maxItemsInObjectGraph, System.Runtime.Serialization.StreamingContext streamingContext, bool ignoreExtensionDataObject);
                /*0x75f4b48*/ System.Runtime.Serialization.SerializationMode get_Mode();
                /*0x75f4b50*/ System.Runtime.Serialization.DataContract GetDataContract(System.RuntimeTypeHandle typeHandle, System.Type type);
                /*0x75f4d10*/ System.Runtime.Serialization.DataContract GetDataContract(int id, System.RuntimeTypeHandle typeHandle);
                /*0x75f4ed0*/ System.Runtime.Serialization.DataContract GetDataContractSkipValidation(int typeId, System.RuntimeTypeHandle typeHandle, System.Type type);
                /*0x75f50a4*/ bool WriteClrTypeInfo(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Runtime.Serialization.DataContract dataContract);
                /*0x75f512c*/ bool WriteClrTypeInfo(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Type dataContractType, string clrTypeName, string clrAssemblyName);
                /*0x75f51cc*/ bool WriteClrTypeInfo(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Type dataContractType, System.Runtime.Serialization.SerializationInfo serInfo);
                /*0x75f525c*/ void WriteAnyType(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object value);
                /*0x75f52b0*/ void WriteString(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, string value);
                /*0x75f5304*/ void WriteString(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, string value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75f53e4*/ void WriteBase64(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, byte[] value);
                /*0x75f543c*/ void WriteBase64(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, byte[] value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75f5550*/ void WriteUri(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Uri value);
                /*0x75f55a4*/ void WriteUri(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Uri value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75f56e8*/ void WriteQName(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Xml.XmlQualifiedName value);
                /*0x75f5744*/ void WriteQName(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Xml.XmlQualifiedName value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75f58dc*/ void InternalSerialize(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, bool isDeclaredType, bool writeXsiType, int declaredTypeID, System.RuntimeTypeHandle declaredTypeHandle);
                /*0x75f5c2c*/ bool OnHandleReference(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, bool canContainCyclicReference);
                /*0x75f5db0*/ void OnEndHandleReference(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, bool canContainCyclicReference);
                /*0x75f5e18*/ bool CheckIfTypeSerializableForSharedTypeMode(System.Type memberType);
                /*0x75f5ee8*/ void CheckIfTypeSerializable(System.Type memberType, bool isMemberTypeSerializable);
                /*0x75f6030*/ System.Type GetSurrogatedType(System.Type type);
                /*0x75f58fc*/ void InternalSerializeWithSurrogate(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, bool isDeclaredType, bool writeXsiType, int declaredTypeID, System.RuntimeTypeHandle declaredTypeHandle);
                /*0x75f616c*/ void WriteArraySize(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, int size);
            }

            class XmlReaderDelegator
            {
                /*0x10*/ System.Xml.XmlReader reader;
                /*0x18*/ System.Xml.XmlDictionaryReader dictionaryReader;
                /*0x20*/ bool isEndOfEmptyElement;

                /*0x75f6224*/ XmlReaderDelegator(System.Xml.XmlReader reader);
                /*0x75f6328*/ System.Xml.XmlReader get_UnderlyingReader();
                /*0x75f6330*/ System.Runtime.Serialization.ExtensionDataReader get_UnderlyingExtensionDataReader();
                /*0x75f63ac*/ int get_AttributeCount();
                /*0x75f63e4*/ string GetAttribute(string name);
                /*0x75f641c*/ string GetAttribute(string name, string namespaceUri);
                /*0x75f6454*/ string GetAttribute(int i);
                /*0x75f64ec*/ bool get_IsEmptyElement();
                /*0x75f64f4*/ bool IsNamespaceURI(string ns);
                /*0x75f654c*/ bool IsLocalName(string localName);
                /*0x75f65a4*/ bool IsNamespaceUri(System.Xml.XmlDictionaryString ns);
                /*0x75f65fc*/ bool IsLocalName(System.Xml.XmlDictionaryString localName);
                /*0x75f6654*/ int IndexOfLocalName(System.Xml.XmlDictionaryString[] localNames, System.Xml.XmlDictionaryString ns);
                /*0x75f6758*/ bool IsStartElement();
                /*0x75f6790*/ bool IsStartElement(string localname, string ns);
                /*0x75f67c8*/ bool IsStartElement(System.Xml.XmlDictionaryString localname, System.Xml.XmlDictionaryString ns);
                /*0x75f6830*/ bool MoveToAttribute(string name);
                /*0x75f6868*/ bool MoveToAttribute(string name, string ns);
                /*0x75f68a0*/ void MoveToAttribute(int i);
                /*0x75f6930*/ bool MoveToElement();
                /*0x75f6968*/ bool MoveToFirstAttribute();
                /*0x75f69a0*/ bool MoveToNextAttribute();
                /*0x75f69d8*/ System.Xml.XmlNodeType get_NodeType();
                /*0x75f6a0c*/ bool Read();
                /*0x75f6a90*/ System.Xml.XmlNodeType MoveToContent();
                /*0x75f6ac8*/ bool ReadAttributeValue();
                /*0x75f6b00*/ void ReadEndElement();
                /*0x75f6b34*/ System.Exception CreateInvalidPrimitiveTypeException(System.Type type);
                /*0x75f6cf0*/ object ReadElementContentAsAnyType(System.Type valueType);
                /*0x75f6d2c*/ object ReadContentAsAnyType(System.Type valueType);
                /*0x75f789c*/ System.Runtime.Serialization.IDataNode ReadExtensionData(System.Type valueType);
                /*0x75f8214*/ void ThrowConversionException(string value, string type);
                /*0x75f82e8*/ void ThrowNotAtElement();
                /*0x75f8390*/ char ReadElementContentAsChar();
                /*0x75f8460*/ char ReadContentAsChar();
                /*0x75f83dc*/ char ToChar(int value);
                /*0x75f847c*/ string ReadElementContentAsString();
                /*0x75f752c*/ string ReadContentAsString();
                /*0x75f84ac*/ bool ReadElementContentAsBoolean();
                /*0x75f71f4*/ bool ReadContentAsBoolean();
                /*0x75f84dc*/ float ReadElementContentAsFloat();
                /*0x75f73ac*/ float ReadContentAsSingle();
                /*0x75f850c*/ double ReadElementContentAsDouble();
                /*0x75f742c*/ double ReadContentAsDouble();
                /*0x75f853c*/ decimal ReadElementContentAsDecimal();
                /*0x75f74ac*/ decimal ReadContentAsDecimal();
                /*0x75f856c*/ byte[] ReadElementContentAsBase64();
                /*0x75f8740*/ byte[] ReadContentAsBase64();
                /*0x75f85c4*/ byte[] ReadContentAsBase64(string str);
                /*0x75f87dc*/ System.DateTime ReadElementContentAsDateTime();
                /*0x75f880c*/ System.DateTime ReadContentAsDateTime();
                /*0x75f83ac*/ int ReadElementContentAsInt();
                /*0x75f72ac*/ int ReadContentAsInt();
                /*0x75f888c*/ long ReadElementContentAsLong();
                /*0x75f732c*/ long ReadContentAsLong();
                /*0x75f88bc*/ short ReadElementContentAsShort();
                /*0x75f7290*/ short ReadContentAsShort();
                /*0x75f88d8*/ short ToShort(int value);
                /*0x75f895c*/ byte ReadElementContentAsUnsignedByte();
                /*0x75f7274*/ byte ReadContentAsUnsignedByte();
                /*0x75f8978*/ byte ToByte(int value);
                /*0x75f89fc*/ sbyte ReadElementContentAsSignedByte();
                /*0x75f7574*/ sbyte ReadContentAsSignedByte();
                /*0x75f8a18*/ sbyte ToSByte(int value);
                /*0x75f8a9c*/ uint ReadElementContentAsUnsignedInt();
                /*0x75f75ac*/ uint ReadContentAsUnsignedInt();
                /*0x75f8ab8*/ uint ToUInt32(long value);
                /*0x75f8b3c*/ ulong ReadElementContentAsUnsignedLong();
                /*0x75f8c00*/ ulong ReadContentAsUnsignedLong();
                /*0x75f8cb8*/ ushort ReadElementContentAsUnsignedShort();
                /*0x75f7590*/ ushort ReadContentAsUnsignedShort();
                /*0x75f8cd4*/ ushort ToUInt16(int value);
                /*0x75f8d58*/ System.TimeSpan ReadElementContentAsTimeSpan();
                /*0x75f75c8*/ System.TimeSpan ReadContentAsTimeSpan();
                /*0x75f8de0*/ System.Guid ReadElementContentAsGuid();
                /*0x75f7644*/ System.Guid ReadContentAsGuid();
                /*0x75f8f0c*/ System.Uri ReadElementContentAsUri();
                /*0x75f7764*/ System.Uri ReadContentAsUri();
                /*0x75f9050*/ System.Xml.XmlQualifiedName ReadElementContentAsQName();
                /*0x75f908c*/ System.Xml.XmlQualifiedName ReadContentAsQName();
                /*0x75f90a8*/ System.Xml.XmlQualifiedName ParseQualifiedName(string str);
                /*0x75f9168*/ void CheckExpectedArrayLength(System.Runtime.Serialization.XmlObjectSerializerReadContext context, int arrayLength);
                /*0x75f9184*/ int GetArrayLengthQuota(System.Runtime.Serialization.XmlObjectSerializerReadContext context);
                /*0x75f9250*/ void CheckActualArrayLength(int expectedLength, int actualLength, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace);
                /*0x75f9364*/ bool TryReadBooleanArray(System.Runtime.Serialization.XmlObjectSerializerReadContext context, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace, int arrayLength, ref bool[] array);
                /*0x75f9528*/ bool TryReadDateTimeArray(System.Runtime.Serialization.XmlObjectSerializerReadContext context, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace, int arrayLength, ref System.DateTime[] array);
                /*0x75f96ec*/ bool TryReadDecimalArray(System.Runtime.Serialization.XmlObjectSerializerReadContext context, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace, int arrayLength, ref decimal[] array);
                /*0x75f98b0*/ bool TryReadInt32Array(System.Runtime.Serialization.XmlObjectSerializerReadContext context, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace, int arrayLength, ref int[] array);
                /*0x75f9a74*/ bool TryReadInt64Array(System.Runtime.Serialization.XmlObjectSerializerReadContext context, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace, int arrayLength, ref long[] array);
                /*0x75f9c38*/ bool TryReadSingleArray(System.Runtime.Serialization.XmlObjectSerializerReadContext context, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace, int arrayLength, ref float[] array);
                /*0x75f9dfc*/ bool TryReadDoubleArray(System.Runtime.Serialization.XmlObjectSerializerReadContext context, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace, int arrayLength, ref double[] array);
                /*0x75f9fc0*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
                /*0x75fa0d4*/ bool HasLineInfo();
                /*0x75fa188*/ int get_LineNumber();
                /*0x75fa240*/ int get_LinePosition();
                /*0x75fa2f8*/ bool get_Normalized();
                /*0x75fa400*/ void set_Normalized(bool value);
                /*0x75fa518*/ System.Xml.WhitespaceHandling get_WhitespaceHandling();
                /*0x75fa628*/ void set_WhitespaceHandling(System.Xml.WhitespaceHandling value);
                /*0x75fa740*/ string get_Name();
                /*0x75f6738*/ string get_LocalName();
                /*0x75fa760*/ string get_NamespaceURI();
                /*0x75fa780*/ string get_Value();
                /*0x75fa7a0*/ System.Type get_ValueType();
                /*0x75fa7c4*/ int get_Depth();
                /*0x75fa7e4*/ string LookupNamespace(string prefix);
                /*0x75fa808*/ bool get_EOF();
                /*0x75fa82c*/ void Skip();
            }

            class XmlSerializableReader : System.Xml.XmlReader, System.Xml.IXmlLineInfo, System.Xml.Serialization.IXmlTextParser
            {
                /*0x10*/ System.Runtime.Serialization.XmlReaderDelegator xmlReader;
                /*0x18*/ int startDepth;
                /*0x1c*/ bool isRootEmptyElement;
                /*0x20*/ System.Xml.XmlReader innerReader;

                /*0x75fb734*/ XmlSerializableReader();
                /*0x75fa85c*/ System.Xml.XmlReader get_InnerReader();
                /*0x75fa864*/ void BeginRead(System.Runtime.Serialization.XmlReaderDelegator xmlReader);
                /*0x75fa920*/ void EndRead();
                /*0x75fa9ec*/ bool Read();
                /*0x75faa94*/ void Close();
                /*0x75faac8*/ System.Xml.XmlReaderSettings get_Settings();
                /*0x75faae8*/ System.Xml.XmlNodeType get_NodeType();
                /*0x75fab08*/ string get_Name();
                /*0x75fab28*/ string get_LocalName();
                /*0x75fab48*/ string get_NamespaceURI();
                /*0x75fab68*/ string get_Prefix();
                /*0x75fab88*/ string get_Value();
                /*0x75faba8*/ int get_Depth();
                /*0x75fabc8*/ string get_BaseURI();
                /*0x75fabec*/ bool get_IsEmptyElement();
                /*0x75fac10*/ bool get_IsDefault();
                /*0x75fac34*/ char get_QuoteChar();
                /*0x75fac58*/ System.Xml.XmlSpace get_XmlSpace();
                /*0x75fac7c*/ string get_XmlLang();
                /*0x75faca0*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
                /*0x75facc4*/ System.Type get_ValueType();
                /*0x75face8*/ int get_AttributeCount();
                /*0x75fad0c*/ bool get_EOF();
                /*0x75fad30*/ System.Xml.ReadState get_ReadState();
                /*0x75fad54*/ System.Xml.XmlNameTable get_NameTable();
                /*0x75fad78*/ bool get_CanResolveEntity();
                /*0x75fad9c*/ bool get_CanReadValueChunk();
                /*0x75fadc0*/ bool get_HasAttributes();
                /*0x75fade4*/ string GetAttribute(string name);
                /*0x75fae08*/ string GetAttribute(string name, string namespaceURI);
                /*0x75fae2c*/ string GetAttribute(int i);
                /*0x75fae50*/ bool MoveToAttribute(string name);
                /*0x75fae74*/ bool MoveToAttribute(string name, string ns);
                /*0x75fae98*/ void MoveToAttribute(int i);
                /*0x75faebc*/ bool MoveToFirstAttribute();
                /*0x75faee0*/ bool MoveToNextAttribute();
                /*0x75faf04*/ bool MoveToElement();
                /*0x75faf28*/ string LookupNamespace(string prefix);
                /*0x75faf4c*/ bool ReadAttributeValue();
                /*0x75faf70*/ void ResolveEntity();
                /*0x75faf94*/ bool IsStartElement();
                /*0x75fafb8*/ bool IsStartElement(string localname, string ns);
                /*0x75fafdc*/ System.Xml.XmlNodeType MoveToContent();
                /*0x75fb000*/ object ReadContentAsObject();
                /*0x75fb024*/ bool ReadContentAsBoolean();
                /*0x75fb048*/ System.DateTime ReadContentAsDateTime();
                /*0x75fb06c*/ double ReadContentAsDouble();
                /*0x75fb090*/ int ReadContentAsInt();
                /*0x75fb0b4*/ long ReadContentAsLong();
                /*0x75fb0d8*/ string ReadContentAsString();
                /*0x75fb0fc*/ object ReadContentAs(System.Type returnType, System.Xml.IXmlNamespaceResolver namespaceResolver);
                /*0x75fb120*/ int ReadContentAsBase64(byte[] buffer, int index, int count);
                /*0x75fb144*/ int ReadContentAsBinHex(byte[] buffer, int index, int count);
                /*0x75fb168*/ int ReadValueChunk(char[] buffer, int index, int count);
                /*0x75fb18c*/ string ReadString();
                /*0x75fb1b0*/ bool System.Xml.Serialization.IXmlTextParser.get_Normalized();
                /*0x75fb270*/ void System.Xml.Serialization.IXmlTextParser.set_Normalized(bool value);
                /*0x75fb34c*/ System.Xml.WhitespaceHandling System.Xml.Serialization.IXmlTextParser.get_WhitespaceHandling();
                /*0x75fb410*/ void System.Xml.Serialization.IXmlTextParser.set_WhitespaceHandling(System.Xml.WhitespaceHandling value);
                /*0x75fb4ec*/ bool System.Xml.IXmlLineInfo.HasLineInfo();
                /*0x75fb5ac*/ int System.Xml.IXmlLineInfo.get_LineNumber();
                /*0x75fb670*/ int System.Xml.IXmlLineInfo.get_LinePosition();
            }

            class XmlSerializableServices
            {
                static /*0x0*/ string ReadNodesMethodName;
                static /*0x8*/ string WriteNodesMethodName;
                static /*0x10*/ string AddDefaultSchemaMethodName;

                static /*0x75fbbf8*/ XmlSerializableServices();
                static /*0x75fb78c*/ System.Xml.XmlNode[] ReadNodes(System.Xml.XmlReader xmlReader);
                static /*0x75fbb00*/ bool IsValidAttribute(System.Xml.XmlReader xmlReader);
            }

            class XmlSerializableWriter : System.Xml.XmlWriter
            {
                /*0x18*/ System.Xml.XmlWriter xmlWriter;
                /*0x20*/ int depth;
                /*0x28*/ object obj;

                /*0x75fc408*/ XmlSerializableWriter();
                /*0x75fbcbc*/ void BeginWrite(System.Xml.XmlWriter xmlWriter, object obj);
                /*0x75fbcf0*/ void EndWrite();
                /*0x75fbde4*/ void WriteStartDocument();
                /*0x75fbe24*/ void WriteEndDocument();
                /*0x75fbe44*/ void WriteStartDocument(bool standalone);
                /*0x75fbe9c*/ void WriteDocType(string name, string pubid, string sysid, string subset);
                /*0x75fbea0*/ void WriteStartElement(string prefix, string localName, string ns);
                /*0x75fbed4*/ void WriteEndElement();
                /*0x75fbfdc*/ void WriteFullEndElement();
                /*0x75fc0e4*/ void Close();
                /*0x75fc118*/ void WriteStartAttribute(string prefix, string localName, string ns);
                /*0x75fc138*/ void WriteEndAttribute();
                /*0x75fc15c*/ void WriteCData(string text);
                /*0x75fc180*/ void WriteComment(string text);
                /*0x75fc1a4*/ void WriteProcessingInstruction(string name, string text);
                /*0x75fc1c8*/ void WriteEntityRef(string name);
                /*0x75fc1ec*/ void WriteCharEntity(char ch);
                /*0x75fc210*/ void WriteWhitespace(string ws);
                /*0x75fc234*/ void WriteString(string text);
                /*0x75fc258*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
                /*0x75fc27c*/ void WriteChars(char[] buffer, int index, int count);
                /*0x75fc2a0*/ void WriteRaw(char[] buffer, int index, int count);
                /*0x75fc2c4*/ void WriteRaw(string data);
                /*0x75fc2e8*/ void WriteBase64(byte[] buffer, int index, int count);
                /*0x75fc30c*/ void WriteBinHex(byte[] buffer, int index, int count);
                /*0x75fc330*/ System.Xml.WriteState get_WriteState();
                /*0x75fc354*/ void Flush();
                /*0x75fc378*/ void WriteQualifiedName(string localName, string ns);
                /*0x75fc39c*/ string LookupPrefix(string ns);
                /*0x75fc3c0*/ System.Xml.XmlSpace get_XmlSpace();
                /*0x75fc3e4*/ string get_XmlLang();
            }

            class XmlWriterDelegator
            {
                /*0x10*/ System.Xml.XmlWriter writer;
                /*0x18*/ System.Xml.XmlDictionaryWriter dictionaryWriter;
                /*0x20*/ int depth;
                /*0x24*/ int prefixes;

                /*0x75fc410*/ XmlWriterDelegator(System.Xml.XmlWriter writer);
                /*0x75fc514*/ System.Xml.XmlWriter get_Writer();
                /*0x75fc51c*/ void Flush();
                /*0x75fc540*/ string LookupPrefix(string ns);
                /*0x75fc564*/ void WriteEndAttribute();
                /*0x75fc588*/ void WriteEndElement();
                /*0x75fc5bc*/ void WriteRaw(char[] buffer, int index, int count);
                /*0x75fc5e0*/ void WriteRaw(string data);
                /*0x75fc604*/ void WriteXmlnsAttribute(System.Xml.XmlDictionaryString ns);
                /*0x75fc654*/ void WriteXmlnsAttribute(string ns);
                /*0x75fc80c*/ void WriteXmlnsAttribute(string prefix, System.Xml.XmlDictionaryString ns);
                /*0x75fc8ac*/ void WriteStartAttribute(string prefix, string localName, string ns);
                /*0x75fc8cc*/ void WriteStartAttribute(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri);
                /*0x75fc918*/ void WriteAttributeString(string prefix, string localName, string ns, string value);
                /*0x75fc9a0*/ void WriteAttributeString(string prefix, System.Xml.XmlDictionaryString attrName, System.Xml.XmlDictionaryString attrNs, string value);
                /*0x75fc97c*/ void WriteAttributeStringValue(string value);
                /*0x75fc9f4*/ void WriteAttributeString(string prefix, System.Xml.XmlDictionaryString attrName, System.Xml.XmlDictionaryString attrNs, System.Xml.XmlDictionaryString value);
                /*0x75fca38*/ void WriteAttributeStringValue(System.Xml.XmlDictionaryString value);
                /*0x75fca80*/ void WriteAttributeInt(string prefix, System.Xml.XmlDictionaryString attrName, System.Xml.XmlDictionaryString attrNs, int value);
                /*0x75fcad4*/ void WriteAttributeIntValue(int value);
                /*0x75fcaf8*/ void WriteAttributeBool(string prefix, System.Xml.XmlDictionaryString attrName, System.Xml.XmlDictionaryString attrNs, bool value);
                /*0x75fcb4c*/ void WriteAttributeBoolValue(bool value);
                /*0x75fcb74*/ void WriteAttributeQualifiedName(string attrPrefix, System.Xml.XmlDictionaryString attrName, System.Xml.XmlDictionaryString attrNs, string name, string ns);
                /*0x75fcc04*/ void WriteAttributeQualifiedNameValue(string name, string ns);
                /*0x75fcc28*/ void WriteAttributeQualifiedName(string attrPrefix, System.Xml.XmlDictionaryString attrName, System.Xml.XmlDictionaryString attrNs, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75fcca8*/ void WriteAttributeQualifiedNameValue(System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75fccf8*/ void WriteStartElement(string localName, string ns);
                /*0x75fcd10*/ void WriteStartElement(string prefix, string localName, string ns);
                /*0x75fcd48*/ void WriteStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri);
                /*0x75fcd58*/ void WriteStartElement(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri);
                /*0x75fcdb8*/ void WriteStartElementPrimitive(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri);
                /*0x75fce10*/ void WriteEndElementPrimitive();
                /*0x75fce30*/ System.Xml.WriteState get_WriteState();
                /*0x75fce54*/ string get_XmlLang();
                /*0x75fce78*/ System.Xml.XmlSpace get_XmlSpace();
                /*0x75fce9c*/ void WriteNamespaceDecl(System.Xml.XmlDictionaryString ns);
                /*0x75fcea0*/ System.Exception CreateInvalidPrimitiveTypeException(System.Type type);
                /*0x75fcfa8*/ void WriteAnyType(object value);
                /*0x75fcfe4*/ void WriteAnyType(object value, System.Type valueType);
                /*0x75fd8d8*/ void WriteExtensionData(System.Runtime.Serialization.IDataNode dataNode);
                /*0x75fd79c*/ void WriteString(string value);
                /*0x75fe408*/ void WriteBoolean(bool value);
                /*0x75fe430*/ void WriteBoolean(bool value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75fe480*/ void WriteDateTime(System.DateTime value);
                /*0x75fe4a4*/ void WriteDateTime(System.DateTime value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75fe4f4*/ void WriteDecimal(decimal value);
                /*0x75fe518*/ void WriteDecimal(decimal value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75fe570*/ void WriteDouble(double value);
                /*0x75fe594*/ void WriteDouble(double value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75fe5dc*/ void WriteInt(int value);
                /*0x75fe600*/ void WriteInt(int value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75fe650*/ void WriteLong(long value);
                /*0x75fe674*/ void WriteLong(long value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75fe6c4*/ void WriteFloat(float value);
                /*0x75fe6e8*/ void WriteFloat(float value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75fe730*/ void WriteBase64(byte[] bytes);
                /*0x75fe768*/ void WriteShort(short value);
                /*0x75fe790*/ void WriteShort(short value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75fe7e4*/ void WriteUnsignedByte(byte value);
                /*0x75fe80c*/ void WriteUnsignedByte(byte value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75fe860*/ void WriteSignedByte(sbyte value);
                /*0x75fe888*/ void WriteSignedByte(sbyte value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75fe8dc*/ void WriteUnsignedInt(uint value);
                /*0x75fe904*/ void WriteUnsignedInt(uint value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75fe958*/ void WriteUnsignedLong(ulong value);
                /*0x75fe9e0*/ void WriteUnsignedLong(ulong value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75fea34*/ void WriteUnsignedShort(ushort value);
                /*0x75fea5c*/ void WriteUnsignedShort(ushort value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75feab0*/ void WriteChar(char value);
                /*0x75fead8*/ void WriteChar(char value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75fd7c0*/ void WriteTimeSpan(System.TimeSpan value);
                /*0x75feb2c*/ void WriteTimeSpan(System.TimeSpan value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75fd848*/ void WriteGuid(System.Guid value);
                /*0x75feb74*/ void WriteGuid(System.Guid value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75fd890*/ void WriteUri(System.Uri value);
                /*0x75febc4*/ void WriteQName(System.Xml.XmlQualifiedName value);
                /*0x75fec78*/ void WriteQualifiedName(string localName, string ns);
                /*0x75fec9c*/ void WriteQualifiedName(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString ns);
                /*0x75fecec*/ void WriteBooleanArray(bool[] value, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace);
                /*0x75fedb4*/ void WriteDateTimeArray(System.DateTime[] value, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace);
                /*0x75fee7c*/ void WriteDecimalArray(decimal[] value, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace);
                /*0x75fef48*/ void WriteInt32Array(int[] value, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace);
                /*0x75ff010*/ void WriteInt64Array(long[] value, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace);
                /*0x75ff0d8*/ void WriteSingleArray(float[] value, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace);
                /*0x75ff1a0*/ void WriteDoubleArray(double[] value, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace);
            }

            class BitFlagsGenerator
            {
                /*0x10*/ int bitCount;
                /*0x18*/ byte[] locals;

                static /*0x75ff46c*/ bool IsBitSet(byte[] bytes, int bitIndex);
                static /*0x75ff4b4*/ void SetBit(byte[] bytes, int bitIndex);
                static /*0x75ff340*/ int GetByteIndex(int bitIndex);
                static /*0x75ff348*/ byte GetBitValue(int bitIndex);
                /*0x75ff268*/ BitFlagsGenerator(int bitCount);
                /*0x75ff2ec*/ void Store(int bitIndex, bool value);
                /*0x75ff358*/ bool Load(int bitIndex);
                /*0x75ff3a0*/ byte[] LoadArray();
                /*0x75ff418*/ int GetLocalCount();
                /*0x75ff434*/ int GetBitCount();
                /*0x75ff43c*/ byte GetLocal(int i);
            }

            class CodeInterpreter
            {
                static /*0x75ff4f8*/ object ConvertValue(object arg, System.Type source, System.Type target);
                static /*0x75ff74c*/ bool CanConvert(System.TypeCode typeCode);
                static /*0x75ff500*/ object InternalConvert(object arg, System.Type source, System.Type target, bool isAddress);
                static /*0x75ff75c*/ object GetMember(System.Reflection.MemberInfo memberInfo, object instance);
                static /*0x75ff888*/ void SetMember(System.Reflection.MemberInfo memberInfo, object instance, object value);
            }

            class DiagnosticUtility
            {
                static /*0x0*/ bool ShouldTraceError;
                static /*0x1*/ bool ShouldTraceWarning;
                static /*0x2*/ bool ShouldTraceInformation;
                static /*0x3*/ bool ShouldTraceVerbose;

                static /*0x75ff9c8*/ DiagnosticUtility();

                class DiagnosticTrace
                {
                    static /*0x75ffa18*/ void TraceEvent(object[] args);
                }

                class ExceptionUtility
                {
                    static /*0x75f64e8*/ System.Exception ThrowHelperError(System.Exception e);
                    static /*0x75ffa20*/ System.Exception ThrowHelperCallback(System.Exception e);
                    static /*0x75ffa1c*/ System.Exception ThrowHelper(System.Exception e, System.Diagnostics.TraceEventType type);
                    static /*0x75ffa9c*/ System.Exception ThrowHelperArgument(string arg, string message);
                    static /*0x75fbaa4*/ System.Exception ThrowHelperArgumentNull(string arg);
                    static /*0x75ffb08*/ System.Exception ThrowHelperFatal(string msg, System.Exception e);
                }
            }

            class FxTrace
            {
                static /*0x0*/ bool ShouldTraceError;
                static /*0x1*/ bool ShouldTraceVerbose;

                static /*0x75ffb88*/ FxTrace();
                static /*0x75ffb74*/ System.Runtime.Diagnostics.EtwDiagnosticTrace get_Trace();
                static /*0x75ffb7c*/ bool IsEventEnabled(int index);
                static /*0x75ffb84*/ void UpdateEventDefinitions(System.Runtime.Diagnostics.EventDescriptor[] ed, ushort[] events);
            }

            class SR
            {
                static /*0x75f6c80*/ string GetString(string name, object[] args);
                static /*0x75ffbd4*/ string GetString(System.Globalization.CultureInfo culture, string name, object[] args);
                static /*0x75f64e4*/ string GetString(string name);
            }

            enum CodeTypeReferenceOptions
            {
                GlobalReference = 1,
                GenericTypeParameter = 2,
            }

            class CodeTypeReference
            {
                /*0x10*/ string baseType;
                /*0x18*/ int arrayRank;
                /*0x20*/ System.Runtime.Serialization.CodeTypeReference arrayElementType;
                /*0x28*/ System.Collections.Generic.List<System.Runtime.Serialization.CodeTypeReference> typeArguments;
                /*0x30*/ System.Runtime.Serialization.CodeTypeReferenceOptions referenceOptions;
                /*0x34*/ bool needsFixup;

                /*0x75ffbdc*/ CodeTypeReference(string typeName, System.Runtime.Serialization.CodeTypeReferenceOptions codeTypeReferenceOption);
                /*0x76004a0*/ CodeTypeReference(string typeName);
                /*0x7600714*/ CodeTypeReference(System.Runtime.Serialization.CodeTypeReference arrayType, int rank);
                /*0x76004d0*/ void Initialize(string typeName);
                /*0x75ffc10*/ void Initialize(string typeName, System.Runtime.Serialization.CodeTypeReferenceOptions options);
                /*0x760075c*/ string get_BaseType();
                /*0x7600884*/ System.Runtime.Serialization.CodeTypeReferenceOptions get_Options();
                /*0x760088c*/ void set_Options(System.Runtime.Serialization.CodeTypeReferenceOptions value);
                /*0x7600678*/ System.Collections.Generic.List<System.Runtime.Serialization.CodeTypeReference> get_TypeArguments();
                /*0x76004d8*/ string RipOffAssemblyInformationFromTypeName(string typeName);
            }

            class XmlDataContractInterpreter
            {
                /*0x10*/ System.Runtime.Serialization.XmlDataContract contract;

                /*0x7600894*/ XmlDataContractInterpreter(System.Runtime.Serialization.XmlDataContract contract);
                /*0x76008c4*/ System.Xml.Serialization.IXmlSerializable CreateXmlSerializable();
                /*0x76009d0*/ System.Reflection.ConstructorInfo GetConstructor();
            }

            class XmlFormatReaderInterpreter
            {
                /*0x10*/ bool is_get_only_collection;
                /*0x18*/ System.Runtime.Serialization.ClassDataContract classContract;
                /*0x20*/ System.Runtime.Serialization.CollectionDataContract collectionContract;
                /*0x28*/ object objectLocal;
                /*0x30*/ System.Type objectType;
                /*0x38*/ System.Runtime.Serialization.XmlReaderDelegator xmlReader;
                /*0x40*/ System.Runtime.Serialization.XmlObjectSerializerReadContext context;
                /*0x48*/ System.Xml.XmlDictionaryString[] memberNames;
                /*0x50*/ System.Xml.XmlDictionaryString[] memberNamespaces;
                /*0x58*/ System.Xml.XmlDictionaryString itemName;
                /*0x60*/ System.Xml.XmlDictionaryString itemNamespace;

                /*0x7600b50*/ XmlFormatReaderInterpreter(System.Runtime.Serialization.ClassDataContract classContract);
                /*0x7600b80*/ XmlFormatReaderInterpreter(System.Runtime.Serialization.CollectionDataContract collectionContract, bool isGetOnly);
                /*0x7600bbc*/ object ReadFromXml(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.XmlObjectSerializerReadContext context, System.Xml.XmlDictionaryString[] memberNames, System.Xml.XmlDictionaryString[] memberNamespaces);
                /*0x76018a0*/ object ReadCollectionFromXml(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.XmlObjectSerializerReadContext context, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace, System.Runtime.Serialization.CollectionDataContract collectionContract);
                /*0x76021b0*/ void ReadGetOnlyCollectionFromXml(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.XmlObjectSerializerReadContext context, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace, System.Runtime.Serialization.CollectionDataContract collectionContract);
                /*0x7600f14*/ void CreateObject(System.Runtime.Serialization.ClassDataContract classContract);
                /*0x7601160*/ void InvokeOnDeserializing(System.Runtime.Serialization.ClassDataContract classContract);
                /*0x7601748*/ void InvokeOnDeserialized(System.Runtime.Serialization.ClassDataContract classContract);
                /*0x76012b8*/ bool HasFactoryMethod(System.Runtime.Serialization.ClassDataContract classContract);
                /*0x7601624*/ bool InvokeFactoryMethod(System.Runtime.Serialization.ClassDataContract classContract, string objectId);
                /*0x7601340*/ void ReadISerializable(System.Runtime.Serialization.ClassDataContract classContract);
                /*0x76014bc*/ void ReadClass(System.Runtime.Serialization.ClassDataContract classContract);
                /*0x76024a8*/ void ReadMembers(System.Runtime.Serialization.ClassDataContract classContract, System.Runtime.Serialization.ExtensionDataObject extensionData);
                /*0x76026b4*/ int ReadMembers(int index, System.Runtime.Serialization.ClassDataContract classContract, bool[] requiredMembers, ref int memberIndex, ref int requiredIndex);
                /*0x76025ec*/ bool[] GetRequiredMembers(System.Runtime.Serialization.ClassDataContract contract, ref int firstRequiredMember);
                /*0x7602e9c*/ int GetRequiredMembers(System.Runtime.Serialization.ClassDataContract contract, bool[] requiredMembers);
                /*0x76028f4*/ object ReadValue(System.Type type, string name, string ns);
                /*0x7602fb4*/ object InternalDeserialize(System.Type type, string name, string ns);
                /*0x7603194*/ object WrapNullableObject(System.Type innerType, object innerValue, System.Type outerType, int nullables);
                /*0x7601928*/ void ReadCollection(System.Runtime.Serialization.CollectionDataContract collectionContract);
                /*0x7602230*/ void ReadGetOnlyCollection(System.Runtime.Serialization.CollectionDataContract collectionContract);
                /*0x7603378*/ bool TryReadPrimitiveArray(System.Type type, System.Type itemType, int size, ref bool readResult);
                /*0x76036cc*/ object ReadCollectionItem(System.Runtime.Serialization.CollectionDataContract collectionContract, System.Type itemType, string itemName, string itemNs);
                /*0x76037e8*/ void StoreCollectionValue(object collection, System.Type valueType, object value, System.Runtime.Serialization.CollectionDataContract collectionContract);
                /*0x7603a68*/ void HandleUnexpectedItemInCollection(ref int iterator);
                /*0x76036b4*/ bool IsStartElement(System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x7603ae4*/ bool IsStartElement();
                /*0x7603a44*/ bool IsEndElement();
            }

            class XmlFormatWriterInterpreter
            {
                /*0x10*/ System.Runtime.Serialization.ClassDataContract classContract;
                /*0x18*/ System.Runtime.Serialization.CollectionDataContract collectionContract;
                /*0x20*/ System.Runtime.Serialization.XmlWriterDelegator writer;
                /*0x28*/ object obj;
                /*0x30*/ System.Runtime.Serialization.XmlObjectSerializerWriteContext ctx;
                /*0x38*/ System.Runtime.Serialization.DataContract dataContract;
                /*0x40*/ object objLocal;
                /*0x48*/ System.Xml.XmlDictionaryString[] contractNamespaces;
                /*0x50*/ System.Xml.XmlDictionaryString[] memberNames;
                /*0x58*/ System.Xml.XmlDictionaryString[] childElementNamespaces;
                /*0x60*/ int typeIndex;
                /*0x64*/ int childElementIndex;

                /*0x7603afc*/ XmlFormatWriterInterpreter(System.Runtime.Serialization.ClassDataContract classContract);
                /*0x7603b34*/ XmlFormatWriterInterpreter(System.Runtime.Serialization.CollectionDataContract collectionContract);
                /*0x7603b6c*/ System.Runtime.Serialization.ClassDataContract get_classDataContract();
                /*0x7603bc8*/ System.Runtime.Serialization.CollectionDataContract get_collectionDataContract();
                /*0x7603c24*/ void WriteToXml(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context, System.Runtime.Serialization.ClassDataContract dataContract);
                /*0x760412c*/ void WriteCollectionToXml(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context, System.Runtime.Serialization.CollectionDataContract collectionContract);
                /*0x7603ce4*/ void InitArgs(System.Type objType);
                /*0x76053ac*/ void InvokeOnSerializing(System.Runtime.Serialization.ClassDataContract classContract, object objSerialized, System.Runtime.Serialization.XmlObjectSerializerWriteContext ctx);
                /*0x760550c*/ void InvokeOnSerialized(System.Runtime.Serialization.ClassDataContract classContract, object objSerialized, System.Runtime.Serialization.XmlObjectSerializerWriteContext ctx);
                /*0x7603e68*/ void WriteClass(System.Runtime.Serialization.ClassDataContract classContract);
                /*0x76041e0*/ void WriteCollection(System.Runtime.Serialization.CollectionDataContract collectionContract);
                /*0x760566c*/ int WriteMembers(System.Runtime.Serialization.ClassDataContract classContract, System.Runtime.Serialization.ExtensionDataObject extensionData, System.Runtime.Serialization.ClassDataContract derivedMostClassContract);
                /*0x7606f94*/ bool IsDefaultValue(System.Type type, object value);
                /*0x7607154*/ object GetDefaultValue(System.Type type);
                /*0x7606fc8*/ bool CheckIfMemberHasConflict(System.Runtime.Serialization.DataMember member, System.Runtime.Serialization.ClassDataContract classContract, System.Runtime.Serialization.ClassDataContract derivedMostClassContract);
                /*0x76072a4*/ bool CheckIfConflictingMembersHaveDifferentTypes(System.Runtime.Serialization.DataMember member);
                /*0x7607358*/ bool NeedsPrefix(System.Type type, System.Xml.XmlDictionaryString ns);
                /*0x760634c*/ void WriteStartElement(System.Type type, System.Xml.XmlDictionaryString ns, System.Xml.XmlDictionaryString namespaceLocal, System.Xml.XmlDictionaryString nameLocal, int nameIndex);
                /*0x7606f44*/ void WriteEndElement();
                /*0x7606404*/ void WriteValue(System.Type memberType, object memberValue, bool writeXsiType);
                /*0x7607420*/ object UnwrapNullableObject(System.Func<object> memberValue, ref System.Type memberType, ref bool isNull);
                /*0x7605eac*/ bool TryWritePrimitive(System.Type type, System.Func<object> value, System.Reflection.MemberInfo memberInfo, System.Nullable<int> arrayItemIndex, System.Xml.XmlDictionaryString ns, System.Xml.XmlDictionaryString name, int nameIndex);
                /*0x7605b30*/ bool TryWritePrimitiveArray(System.Type type, System.Type itemType, System.Func<object> value, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace);
                /*0x7606f6c*/ object LoadMemberValue(System.Runtime.Serialization.DataMember member);
                /*0x760782c*/ object <WriteCollection>b__24_0();

                class <>c__DisplayClass24_0
                {
                    /*0x10*/ object currentValue;

                    /*0x7606f5c*/ <>c__DisplayClass24_0();
                    /*0x7607834*/ object <WriteCollection>b__1();
                }

                class <>c__DisplayClass25_0
                {
                    /*0x10*/ object memberValue;

                    /*0x7606f64*/ <>c__DisplayClass25_0();
                    /*0x760783c*/ object <WriteMembers>b__0();
                }

                class <>c__DisplayClass33_0
                {
                    /*0x10*/ object memberValue;

                    /*0x7607418*/ <>c__DisplayClass33_0();
                    /*0x7607844*/ object <WriteValue>b__0();
                }
            }

            namespace Json
            {
                class ByteArrayHelperWithString : System.Xml.ArrayHelper<string, byte>
                {
                    static /*0x0*/ System.Runtime.Serialization.Json.ByteArrayHelperWithString Instance;

                    static /*0x7607cec*/ ByteArrayHelperWithString();
                    /*0x7607ca4*/ ByteArrayHelperWithString();
                    /*0x760784c*/ void WriteArray(System.Xml.XmlWriter writer, byte[] array, int offset, int count);
                    /*0x7607a08*/ int ReadArray(System.Xml.XmlDictionaryReader reader, string localName, string namespaceUri, byte[] array, int offset, int count);
                    /*0x7607bd8*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, byte[] array, int offset, int count);
                    /*0x7607be8*/ void ThrowConversionException(string value, string type);
                    /*0x7607b64*/ byte ToByte(int value);
                }

                class DataContractJsonSerializer : System.Runtime.Serialization.XmlObjectSerializer
                {
                    /*0x10*/ System.Collections.Generic.IList<System.Type> knownTypeList;
                    /*0x18*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> knownDataContracts;
                    /*0x20*/ System.Runtime.Serialization.EmitTypeInformation emitTypeInformation;
                    /*0x28*/ System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate;
                    /*0x30*/ bool ignoreExtensionDataObject;
                    /*0x34*/ int maxItemsInObjectGraph;
                    /*0x38*/ System.Runtime.Serialization.DataContract rootContract;
                    /*0x40*/ System.Xml.XmlDictionaryString rootName;
                    /*0x48*/ bool rootNameRequiresMapping;
                    /*0x50*/ System.Type rootType;
                    /*0x58*/ bool serializeReadOnlyTypes;
                    /*0x60*/ System.Runtime.Serialization.DateTimeFormat dateTimeFormat;
                    /*0x68*/ bool useSimpleDictionaryFormat;

                    static /*0x7608db4*/ bool CheckIfJsonNameRequiresMapping(string jsonName);
                    static /*0x7608e2c*/ bool CheckIfJsonNameRequiresMapping(System.Xml.XmlDictionaryString jsonName);
                    static /*0x7608e3c*/ bool CheckIfXmlNameRequiresMapping(string xmlName);
                    static /*0x7608eac*/ bool CheckIfXmlNameRequiresMapping(System.Xml.XmlDictionaryString xmlName);
                    static /*0x7608e54*/ string ConvertXmlNameToJsonName(string xmlName);
                    static /*0x7608ebc*/ System.Xml.XmlDictionaryString ConvertXmlNameToJsonName(System.Xml.XmlDictionaryString xmlName);
                    static /*0x7608f44*/ bool IsJsonLocalName(System.Runtime.Serialization.XmlReaderDelegator reader, string elementName);
                    static /*0x7608f8c*/ object ReadJsonValue(System.Runtime.Serialization.DataContract contract, System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context);
                    static /*0x7609064*/ void WriteJsonNull(System.Runtime.Serialization.XmlWriterDelegator writer);
                    static /*0x76090d4*/ void WriteJsonValue(System.Runtime.Serialization.Json.JsonDataContract contract, System.Runtime.Serialization.XmlWriterDelegator writer, object graph, System.Runtime.Serialization.Json.XmlObjectSerializerWriteContextComplexJson context, System.RuntimeTypeHandle declaredTypeHandle);
                    static /*0x76085d4*/ void CheckIfTypeIsReference(System.Runtime.Serialization.DataContract dataContract);
                    static /*0x760984c*/ System.Runtime.Serialization.DataContract GetDataContract(System.Runtime.Serialization.DataContract declaredTypeContract, System.Type declaredType, System.Type objectType);
                    /*0x7607d50*/ DataContractJsonSerializer(System.Type type);
                    /*0x7607d58*/ DataContractJsonSerializer(System.Type type, System.Collections.Generic.IEnumerable<System.Type> knownTypes);
                    /*0x7607db4*/ DataContractJsonSerializer(System.Type type, System.Collections.Generic.IEnumerable<System.Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate, bool alwaysEmitTypeInformation);
                    /*0x760833c*/ DataContractJsonSerializer(System.Type type, System.Runtime.Serialization.Json.DataContractJsonSerializerSettings settings);
                    /*0x7608500*/ System.Runtime.Serialization.IDataContractSurrogate get_DataContractSurrogate();
                    /*0x7608508*/ bool get_IgnoreExtensionDataObject();
                    /*0x7608510*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> get_KnownDataContracts();
                    /*0x7608550*/ int get_MaxItemsInObjectGraph();
                    /*0x7608558*/ System.Runtime.Serialization.EmitTypeInformation get_EmitTypeInformation();
                    /*0x7608560*/ bool get_SerializeReadOnlyTypes();
                    /*0x7608568*/ System.Runtime.Serialization.DateTimeFormat get_DateTimeFormat();
                    /*0x7608570*/ bool get_UseSimpleDictionaryFormat();
                    /*0x7608578*/ System.Runtime.Serialization.DataContract get_RootContract();
                    /*0x76086f8*/ System.Xml.XmlDictionaryString get_RootName();
                    /*0x760875c*/ object ReadObject(System.IO.Stream stream);
                    /*0x7608838*/ object ReadObject(System.Xml.XmlReader reader, bool verifyObjectName);
                    /*0x76088b8*/ object ReadObject(System.Xml.XmlDictionaryReader reader);
                    /*0x7608934*/ object ReadObject(System.Xml.XmlDictionaryReader reader, bool verifyObjectName);
                    /*0x76089b4*/ void WriteEndObject(System.Xml.XmlWriter writer);
                    /*0x7608a24*/ void WriteEndObject(System.Xml.XmlDictionaryWriter writer);
                    /*0x7608a94*/ void WriteObject(System.IO.Stream stream, object graph);
                    /*0x7608b44*/ void WriteObject(System.Xml.XmlDictionaryWriter writer, object graph);
                    /*0x7608bc4*/ void WriteObjectContent(System.Xml.XmlWriter writer, object graph);
                    /*0x7608c44*/ void WriteObjectContent(System.Xml.XmlDictionaryWriter writer, object graph);
                    /*0x7608cc4*/ void WriteStartObject(System.Xml.XmlWriter writer, object graph);
                    /*0x7608d3c*/ void WriteStartObject(System.Xml.XmlDictionaryWriter writer, object graph);
                    /*0x7609144*/ System.Type GetDeserializeType();
                    /*0x760914c*/ System.Type GetSerializeType(object graph);
                    /*0x7609164*/ bool InternalIsStartObject(System.Runtime.Serialization.XmlReaderDelegator reader);
                    /*0x7609230*/ object InternalReadObject(System.Runtime.Serialization.XmlReaderDelegator xmlReader, bool verifyObjectName);
                    /*0x76094d0*/ void InternalWriteEndObject(System.Runtime.Serialization.XmlWriterDelegator writer);
                    /*0x76094e4*/ void InternalWriteObject(System.Runtime.Serialization.XmlWriterDelegator writer, object graph);
                    /*0x7609544*/ void InternalWriteObjectContent(System.Runtime.Serialization.XmlWriterDelegator writer, object graph);
                    /*0x760986c*/ void InternalWriteStartObject(System.Runtime.Serialization.XmlWriterDelegator writer, object graph);
                    /*0x760996c*/ void AddCollectionItemTypeToKnownTypes(System.Type knownType);
                    /*0x7607e30*/ void Initialize(System.Type type, System.Collections.Generic.IEnumerable<System.Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate, System.Runtime.Serialization.EmitTypeInformation emitTypeInformation, bool serializeReadOnlyTypes, System.Runtime.Serialization.DateTimeFormat dateTimeFormat, bool useSimpleDictionaryFormat);
                    /*0x7608464*/ void Initialize(System.Type type, System.Xml.XmlDictionaryString rootName, System.Collections.Generic.IEnumerable<System.Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate, System.Runtime.Serialization.EmitTypeInformation emitTypeInformation, bool serializeReadOnlyTypes, System.Runtime.Serialization.DateTimeFormat dateTimeFormat, bool useSimpleDictionaryFormat);
                }

                class DataContractJsonSerializerSettings
                {
                    /*0x10*/ int maxItemsInObjectGraph;
                    /*0x18*/ string <RootName>k__BackingField;
                    /*0x20*/ System.Collections.Generic.IEnumerable<System.Type> <KnownTypes>k__BackingField;
                    /*0x28*/ bool <IgnoreExtensionDataObject>k__BackingField;
                    /*0x30*/ System.Runtime.Serialization.IDataContractSurrogate <DataContractSurrogate>k__BackingField;
                    /*0x38*/ System.Runtime.Serialization.EmitTypeInformation <EmitTypeInformation>k__BackingField;
                    /*0x40*/ System.Runtime.Serialization.DateTimeFormat <DateTimeFormat>k__BackingField;
                    /*0x48*/ bool <SerializeReadOnlyTypes>k__BackingField;
                    /*0x49*/ bool <UseSimpleDictionaryFormat>k__BackingField;

                    /*0x7608454*/ DataContractJsonSerializerSettings();
                    /*0x7609b50*/ string get_RootName();
                    /*0x7609b58*/ System.Collections.Generic.IEnumerable<System.Type> get_KnownTypes();
                    /*0x7609b60*/ int get_MaxItemsInObjectGraph();
                    /*0x7609b68*/ bool get_IgnoreExtensionDataObject();
                    /*0x7609b70*/ System.Runtime.Serialization.IDataContractSurrogate get_DataContractSurrogate();
                    /*0x7609b78*/ System.Runtime.Serialization.EmitTypeInformation get_EmitTypeInformation();
                    /*0x7609b80*/ System.Runtime.Serialization.DateTimeFormat get_DateTimeFormat();
                    /*0x7609b88*/ bool get_SerializeReadOnlyTypes();
                    /*0x7609b90*/ bool get_UseSimpleDictionaryFormat();
                    /*0x7609b98*/ void set_UseSimpleDictionaryFormat(bool value);
                }

                class JsonByteArrayDataContract : System.Runtime.Serialization.Json.JsonDataContract
                {
                    /*0x7609ba4*/ JsonByteArrayDataContract(System.Runtime.Serialization.ByteArrayDataContract traditionalByteArrayDataContract);
                    /*0x7609c20*/ object ReadJsonValueCore(System.Runtime.Serialization.XmlReaderDelegator jsonReader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context);
                }

                class JsonClassDataContract : System.Runtime.Serialization.Json.JsonDataContract
                {
                    /*0x18*/ System.Runtime.Serialization.Json.JsonClassDataContract.JsonClassDataContractCriticalHelper helper;

                    /*0x7609d90*/ JsonClassDataContract(System.Runtime.Serialization.ClassDataContract traditionalDataContract);
                    /*0x7609fd0*/ System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate get_JsonFormatReaderDelegate();
                    /*0x760a1c0*/ System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate get_JsonFormatWriterDelegate();
                    /*0x760a340*/ System.Xml.XmlDictionaryString[] get_MemberNames();
                    /*0x760a35c*/ string get_TypeName();
                    /*0x760a1a4*/ System.Runtime.Serialization.ClassDataContract get_TraditionalClassDataContract();
                    /*0x760a37c*/ object ReadJsonValueCore(System.Runtime.Serialization.XmlReaderDelegator jsonReader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context);
                    /*0x760a440*/ void WriteJsonValueCore(System.Runtime.Serialization.XmlWriterDelegator jsonWriter, object obj, System.Runtime.Serialization.Json.XmlObjectSerializerWriteContextComplexJson context, System.RuntimeTypeHandle declaredTypeHandle);

                    class JsonClassDataContractCriticalHelper : System.Runtime.Serialization.Json.JsonDataContract.JsonDataContractCriticalHelper
                    {
                        /*0x28*/ System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate jsonFormatReaderDelegate;
                        /*0x30*/ System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate jsonFormatWriterDelegate;
                        /*0x38*/ System.Xml.XmlDictionaryString[] memberNames;
                        /*0x40*/ System.Runtime.Serialization.ClassDataContract traditionalClassDataContract;
                        /*0x48*/ string typeName;

                        /*0x7609e8c*/ JsonClassDataContractCriticalHelper(System.Runtime.Serialization.ClassDataContract traditionalDataContract);
                        /*0x760a8fc*/ System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate get_JsonFormatReaderDelegate();
                        /*0x760a904*/ void set_JsonFormatReaderDelegate(System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate value);
                        /*0x760a90c*/ System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate get_JsonFormatWriterDelegate();
                        /*0x760a914*/ void set_JsonFormatWriterDelegate(System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate value);
                        /*0x760a91c*/ System.Xml.XmlDictionaryString[] get_MemberNames();
                        /*0x760a924*/ System.Runtime.Serialization.ClassDataContract get_TraditionalClassDataContract();
                        /*0x760a5e0*/ void CopyMembersAndCheckDuplicateNames();
                    }
                }

                class JsonCollectionDataContract : System.Runtime.Serialization.Json.JsonDataContract
                {
                    /*0x18*/ System.Runtime.Serialization.Json.JsonCollectionDataContract.JsonCollectionDataContractCriticalHelper helper;

                    /*0x760a92c*/ JsonCollectionDataContract(System.Runtime.Serialization.CollectionDataContract traditionalDataContract);
                    /*0x760aa9c*/ System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate get_JsonFormatReaderDelegate();
                    /*0x760ac8c*/ System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate get_JsonFormatGetOnlyReaderDelegate();
                    /*0x760aff4*/ System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate get_JsonFormatWriterDelegate();
                    /*0x760ac70*/ System.Runtime.Serialization.CollectionDataContract get_TraditionalCollectionDataContract();
                    /*0x760b174*/ object ReadJsonValueCore(System.Runtime.Serialization.XmlReaderDelegator jsonReader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context);
                    /*0x760b334*/ void WriteJsonValueCore(System.Runtime.Serialization.XmlWriterDelegator jsonWriter, object obj, System.Runtime.Serialization.Json.XmlObjectSerializerWriteContextComplexJson context, System.RuntimeTypeHandle declaredTypeHandle);

                    class JsonCollectionDataContractCriticalHelper : System.Runtime.Serialization.Json.JsonDataContract.JsonDataContractCriticalHelper
                    {
                        /*0x28*/ System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate jsonFormatReaderDelegate;
                        /*0x30*/ System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate jsonFormatGetOnlyReaderDelegate;
                        /*0x38*/ System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate jsonFormatWriterDelegate;
                        /*0x40*/ System.Runtime.Serialization.CollectionDataContract traditionalCollectionDataContract;

                        /*0x760aa28*/ JsonCollectionDataContractCriticalHelper(System.Runtime.Serialization.CollectionDataContract traditionalDataContract);
                        /*0x760b3b0*/ System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate get_JsonFormatReaderDelegate();
                        /*0x760b3b8*/ void set_JsonFormatReaderDelegate(System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate value);
                        /*0x760b3c0*/ System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate get_JsonFormatGetOnlyReaderDelegate();
                        /*0x760b3c8*/ void set_JsonFormatGetOnlyReaderDelegate(System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate value);
                        /*0x760b3d0*/ System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate get_JsonFormatWriterDelegate();
                        /*0x760b3d8*/ void set_JsonFormatWriterDelegate(System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate value);
                        /*0x760b3e0*/ System.Runtime.Serialization.CollectionDataContract get_TraditionalCollectionDataContract();
                    }
                }

                class JsonDataContract
                {
                    /*0x10*/ System.Runtime.Serialization.Json.JsonDataContract.JsonDataContractCriticalHelper helper;

                    static /*0x7608fbc*/ System.Runtime.Serialization.Json.JsonDataContract GetJsonDataContract(System.Runtime.Serialization.DataContract traditionalDataContract);
                    static /*0x7609d64*/ object HandleReadValue(object obj, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
                    static /*0x7609ca0*/ bool TryReadNullAtTopLevel(System.Runtime.Serialization.XmlReaderDelegator reader);
                    /*0x7609ba8*/ JsonDataContract(System.Runtime.Serialization.DataContract traditionalDataContract);
                    /*0x7609fa0*/ JsonDataContract(System.Runtime.Serialization.Json.JsonDataContract.JsonDataContractCriticalHelper helper);
                    /*0x760b3e8*/ string get_TypeName();
                    /*0x760b3f0*/ System.Runtime.Serialization.Json.JsonDataContract.JsonDataContractCriticalHelper get_Helper();
                    /*0x760afd8*/ System.Runtime.Serialization.DataContract get_TraditionalDataContract();
                    /*0x760b3f8*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> get_KnownDataContracts();
                    /*0x7609010*/ object ReadJsonValue(System.Runtime.Serialization.XmlReaderDelegator jsonReader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context);
                    /*0x760b5b8*/ object ReadJsonValueCore(System.Runtime.Serialization.XmlReaderDelegator jsonReader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context);
                    /*0x76090e4*/ void WriteJsonValue(System.Runtime.Serialization.XmlWriterDelegator jsonWriter, object obj, System.Runtime.Serialization.Json.XmlObjectSerializerWriteContextComplexJson context, System.RuntimeTypeHandle declaredTypeHandle);
                    /*0x760b5e0*/ void WriteJsonValueCore(System.Runtime.Serialization.XmlWriterDelegator jsonWriter, object obj, System.Runtime.Serialization.Json.XmlObjectSerializerWriteContextComplexJson context, System.RuntimeTypeHandle declaredTypeHandle);
                    /*0x760b584*/ void PopKnownDataContracts(System.Runtime.Serialization.XmlObjectSerializerContext context);
                    /*0x760b54c*/ void PushKnownDataContracts(System.Runtime.Serialization.XmlObjectSerializerContext context);

                    class JsonDataContractCriticalHelper
                    {
                        static /*0x0*/ object cacheLock;
                        static /*0x8*/ object createDataContractLock;
                        static /*0x10*/ System.Runtime.Serialization.Json.JsonDataContract[] dataContractCache;
                        static /*0x18*/ int dataContractID;
                        static /*0x20*/ System.Runtime.Serialization.TypeHandleRef typeHandleRef;
                        static /*0x28*/ System.Collections.Generic.Dictionary<System.Runtime.Serialization.TypeHandleRef, System.Runtime.Serialization.IntRef> typeToIDCache;
                        /*0x10*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> knownDataContracts;
                        /*0x18*/ System.Runtime.Serialization.DataContract traditionalDataContract;
                        /*0x20*/ string typeName;

                        static /*0x760c940*/ JsonDataContractCriticalHelper();
                        static /*0x760b414*/ System.Runtime.Serialization.Json.JsonDataContract GetJsonDataContract(System.Runtime.Serialization.DataContract traditionalDataContract);
                        static /*0x760bae0*/ int GetId(System.RuntimeTypeHandle typeHandle);
                        static /*0x760beec*/ System.Runtime.Serialization.Json.JsonDataContract CreateJsonDataContract(int id, System.Runtime.Serialization.DataContract traditionalDataContract);
                        /*0x760a4fc*/ JsonDataContractCriticalHelper(System.Runtime.Serialization.DataContract traditionalDataContract);
                        /*0x760bac8*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> get_KnownDataContracts();
                        /*0x760bad0*/ System.Runtime.Serialization.DataContract get_TraditionalDataContract();
                        /*0x760bad8*/ string get_TypeName();
                        /*0x760b608*/ void AddCollectionItemContractsToKnownDataContracts();
                    }
                }

                class JsonEncodingStreamWrapper : System.IO.Stream
                {
                    static /*0x0*/ System.Text.UnicodeEncoding SafeBEUTF16;
                    static /*0x8*/ System.Text.UnicodeEncoding SafeUTF16;
                    static /*0x10*/ System.Text.UTF8Encoding SafeUTF8;
                    static /*0x18*/ System.Text.UnicodeEncoding ValidatingBEUTF16;
                    static /*0x20*/ System.Text.UnicodeEncoding ValidatingUTF16;
                    static /*0x28*/ System.Text.UTF8Encoding ValidatingUTF8;
                    /*0x28*/ byte[] byteBuffer;
                    /*0x30*/ int byteCount;
                    /*0x34*/ int byteOffset;
                    /*0x38*/ byte[] bytes;
                    /*0x40*/ char[] chars;
                    /*0x48*/ System.Text.Decoder dec;
                    /*0x50*/ System.Text.Encoder enc;
                    /*0x58*/ System.Text.Encoding encoding;
                    /*0x60*/ System.Runtime.Serialization.Json.JsonEncodingStreamWrapper.SupportedEncoding encodingCode;
                    /*0x64*/ bool isReading;
                    /*0x68*/ System.IO.Stream stream;

                    static /*0x760df80*/ JsonEncodingStreamWrapper();
                    static /*0x760d854*/ System.Text.Encoding GetEncoding(System.Runtime.Serialization.Json.JsonEncodingStreamWrapper.SupportedEncoding e);
                    static /*0x760d958*/ string GetEncodingName(System.Runtime.Serialization.Json.JsonEncodingStreamWrapper.SupportedEncoding enc);
                    static /*0x760da08*/ System.Runtime.Serialization.Json.JsonEncodingStreamWrapper.SupportedEncoding GetSupportedEncoding(System.Text.Encoding encoding);
                    static /*0x760dbbc*/ System.Runtime.Serialization.Json.JsonEncodingStreamWrapper.SupportedEncoding ReadEncoding(byte b1, byte b2);
                    static /*0x760dc30*/ void ThrowExpectedEncodingMismatch(System.Runtime.Serialization.Json.JsonEncodingStreamWrapper.SupportedEncoding expEnc, System.Runtime.Serialization.Json.JsonEncodingStreamWrapper.SupportedEncoding actualEnc);
                    /*0x760caf8*/ JsonEncodingStreamWrapper(System.IO.Stream stream, System.Text.Encoding encoding, bool isReader);
                    /*0x760cfd8*/ bool get_CanRead();
                    /*0x760d00c*/ bool get_CanSeek();
                    /*0x760d014*/ bool get_CanTimeout();
                    /*0x760d034*/ bool get_CanWrite();
                    /*0x760d068*/ long get_Length();
                    /*0x760d088*/ long get_Position();
                    /*0x760d0c0*/ void set_Position(long value);
                    /*0x760d0f8*/ int get_ReadTimeout();
                    /*0x760d11c*/ void set_ReadTimeout(int value);
                    /*0x760d140*/ int get_WriteTimeout();
                    /*0x760d164*/ void set_WriteTimeout(int value);
                    /*0x760d188*/ void Close();
                    /*0x760d1cc*/ void Flush();
                    /*0x760d1f0*/ int Read(byte[] buffer, int offset, int count);
                    /*0x760d5e8*/ int ReadByte();
                    /*0x760d66c*/ long Seek(long offset, System.IO.SeekOrigin origin);
                    /*0x760d6a4*/ void SetLength(long value);
                    /*0x760d6dc*/ void Write(byte[] buffer, int offset, int count);
                    /*0x760d7f0*/ void WriteByte(byte b);
                    /*0x760d43c*/ void CleanupCharBreak();
                    /*0x760dd18*/ void EnsureBuffers();
                    /*0x760dd8c*/ void EnsureByteBuffer();
                    /*0x760ddf8*/ void FillBuffer(int count);
                    /*0x760cc14*/ void InitForReading(System.IO.Stream inputStream, System.Text.Encoding expectedEncoding);
                    /*0x760ce8c*/ void InitForWriting(System.IO.Stream outputStream, System.Text.Encoding writeEncoding);
                    /*0x760de68*/ System.Runtime.Serialization.Json.JsonEncodingStreamWrapper.SupportedEncoding ReadEncoding();

                    enum SupportedEncoding
                    {
                        UTF8 = 0,
                        UTF16LE = 1,
                        UTF16BE = 2,
                        None = 3,
                    }
                }

                class JsonEnumDataContract : System.Runtime.Serialization.Json.JsonDataContract
                {
                    /*0x18*/ System.Runtime.Serialization.Json.JsonEnumDataContract.JsonEnumDataContractCriticalHelper helper;

                    /*0x760e120*/ JsonEnumDataContract(System.Runtime.Serialization.EnumDataContract traditionalDataContract);
                    /*0x760e294*/ bool get_IsULong();
                    /*0x760e2b0*/ object ReadJsonValueCore(System.Runtime.Serialization.XmlReaderDelegator jsonReader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context);
                    /*0x760e3a0*/ void WriteJsonValueCore(System.Runtime.Serialization.XmlWriterDelegator jsonWriter, object obj, System.Runtime.Serialization.Json.XmlObjectSerializerWriteContextComplexJson context, System.RuntimeTypeHandle declaredTypeHandle);

                    class JsonEnumDataContractCriticalHelper : System.Runtime.Serialization.Json.JsonDataContract.JsonDataContractCriticalHelper
                    {
                        /*0x28*/ bool isULong;

                        /*0x760e20c*/ JsonEnumDataContractCriticalHelper(System.Runtime.Serialization.EnumDataContract traditionalEnumDataContract);
                        /*0x760e530*/ bool get_IsULong();
                    }
                }

                class JsonFormatClassReaderDelegate : System.MulticastDelegate
                {
                    /*0x760e538*/ JsonFormatClassReaderDelegate(object object, nint method);
                    /*0x760e644*/ object Invoke(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context, System.Xml.XmlDictionaryString emptyDictionaryString, System.Xml.XmlDictionaryString[] memberNames);
                }

                class JsonFormatCollectionReaderDelegate : System.MulticastDelegate
                {
                    /*0x760e658*/ JsonFormatCollectionReaderDelegate(object object, nint method);
                    /*0x760e764*/ object Invoke(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context, System.Xml.XmlDictionaryString emptyDictionaryString, System.Xml.XmlDictionaryString itemName, System.Runtime.Serialization.CollectionDataContract collectionContract);
                }

                class JsonFormatGetOnlyCollectionReaderDelegate : System.MulticastDelegate
                {
                    /*0x760e778*/ JsonFormatGetOnlyCollectionReaderDelegate(object object, nint method);
                    /*0x760e884*/ void Invoke(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context, System.Xml.XmlDictionaryString emptyDictionaryString, System.Xml.XmlDictionaryString itemName, System.Runtime.Serialization.CollectionDataContract collectionContract);
                }

                class JsonFormatReaderGenerator
                {
                    /*0x10*/ System.Runtime.Serialization.Json.JsonFormatReaderGenerator.CriticalHelper helper;

                    /*0x760e898*/ JsonFormatReaderGenerator();
                    /*0x760e90c*/ System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate GenerateClassReader(System.Runtime.Serialization.ClassDataContract classContract);
                    /*0x760eb84*/ System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate GenerateCollectionReader(System.Runtime.Serialization.CollectionDataContract collectionContract);
                    /*0x760edf0*/ System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate GenerateGetOnlyCollectionReader(System.Runtime.Serialization.CollectionDataContract collectionContract);

                    class CriticalHelper
                    {
                        /*0x760e904*/ CriticalHelper();
                        /*0x760eacc*/ System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate GenerateClassReader(System.Runtime.Serialization.ClassDataContract classContract);
                        /*0x760ed38*/ System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate GenerateCollectionReader(System.Runtime.Serialization.CollectionDataContract collectionContract);
                        /*0x760efb0*/ System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate GenerateGetOnlyCollectionReader(System.Runtime.Serialization.CollectionDataContract collectionContract);

                        class <>c__DisplayClass0_0
                        {
                            /*0x10*/ System.Runtime.Serialization.ClassDataContract classContract;

                            /*0x760f068*/ <>c__DisplayClass0_0();
                            /*0x760f080*/ object <GenerateClassReader>b__0(System.Runtime.Serialization.XmlReaderDelegator xr, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson ctx, System.Xml.XmlDictionaryString emptyDictionaryString, System.Xml.XmlDictionaryString[] memberNames);
                        }

                        class <>c__DisplayClass1_0
                        {
                            /*0x10*/ System.Runtime.Serialization.CollectionDataContract collectionContract;

                            /*0x760f070*/ <>c__DisplayClass1_0();
                            /*0x760f468*/ object <GenerateCollectionReader>b__0(System.Runtime.Serialization.XmlReaderDelegator xr, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson ctx, System.Xml.XmlDictionaryString emptyDS, System.Xml.XmlDictionaryString inm, System.Runtime.Serialization.CollectionDataContract cc);
                        }

                        class <>c__DisplayClass2_0
                        {
                            /*0x10*/ System.Runtime.Serialization.CollectionDataContract collectionContract;

                            /*0x760f078*/ <>c__DisplayClass2_0();
                            /*0x760f5dc*/ void <GenerateGetOnlyCollectionReader>b__0(System.Runtime.Serialization.XmlReaderDelegator xr, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson ctx, System.Xml.XmlDictionaryString emptyDS, System.Xml.XmlDictionaryString inm, System.Runtime.Serialization.CollectionDataContract cc);
                        }
                    }
                }

                class JsonFormatClassWriterDelegate : System.MulticastDelegate
                {
                    /*0x760f710*/ JsonFormatClassWriterDelegate(object object, nint method);
                    /*0x760f81c*/ void Invoke(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.Json.XmlObjectSerializerWriteContextComplexJson context, System.Runtime.Serialization.ClassDataContract dataContract, System.Xml.XmlDictionaryString[] memberNames);
                }

                class JsonFormatCollectionWriterDelegate : System.MulticastDelegate
                {
                    /*0x760f830*/ JsonFormatCollectionWriterDelegate(object object, nint method);
                    /*0x760f93c*/ void Invoke(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.Json.XmlObjectSerializerWriteContextComplexJson context, System.Runtime.Serialization.CollectionDataContract dataContract);
                }

                class JsonFormatWriterGenerator
                {
                    /*0x10*/ System.Runtime.Serialization.Json.JsonFormatWriterGenerator.CriticalHelper helper;

                    /*0x760f950*/ JsonFormatWriterGenerator();
                    /*0x760f9c4*/ System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate GenerateClassWriter(System.Runtime.Serialization.ClassDataContract classContract);
                    /*0x760fc3c*/ System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate GenerateCollectionWriter(System.Runtime.Serialization.CollectionDataContract collectionContract);

                    class CriticalHelper
                    {
                        /*0x760f9bc*/ CriticalHelper();
                        /*0x760fb84*/ System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate GenerateClassWriter(System.Runtime.Serialization.ClassDataContract classContract);
                        /*0x760fdfc*/ System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate GenerateCollectionWriter(System.Runtime.Serialization.CollectionDataContract collectionContract);

                        class <>c__DisplayClass0_0
                        {
                            /*0x10*/ System.Runtime.Serialization.ClassDataContract classContract;

                            /*0x760feb4*/ <>c__DisplayClass0_0();
                            /*0x760fec4*/ void <GenerateClassWriter>b__0(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.Json.XmlObjectSerializerWriteContextComplexJson context, System.Runtime.Serialization.ClassDataContract dataContract, System.Xml.XmlDictionaryString[] memberNames);
                        }

                        class <>c__DisplayClass1_0
                        {
                            /*0x10*/ System.Runtime.Serialization.CollectionDataContract collectionContract;

                            /*0x760febc*/ <>c__DisplayClass1_0();
                            /*0x7610084*/ void <GenerateCollectionWriter>b__0(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.Json.XmlObjectSerializerWriteContextComplexJson context, System.Runtime.Serialization.CollectionDataContract dataContract);
                        }
                    }
                }

                class JsonGlobals
                {
                    static /*0x0*/ int DataContractXsdBaseNamespaceLength;
                    static /*0x8*/ System.Xml.XmlDictionaryString dDictionaryString;
                    static /*0x10*/ char[] floatingPointCharacters;
                    static /*0x18*/ System.Xml.XmlDictionaryString itemDictionaryString;
                    static /*0x20*/ System.Xml.XmlDictionaryString rootDictionaryString;
                    static /*0x28*/ long unixEpochTicks;

                    static /*0x7610220*/ JsonGlobals();
                }

                enum JsonNodeType
                {
                    None = 0,
                    Object = 1,
                    Element = 2,
                    EndElement = 3,
                    QuotedText = 4,
                    StandaloneText = 5,
                    Collection = 6,
                }

                class JsonObjectDataContract : System.Runtime.Serialization.Json.JsonDataContract
                {
                    static /*0x7610804*/ object ParseJsonNumber(string value, ref System.TypeCode objectTypeCode);
                    static /*0x7610778*/ object ParseJsonNumber(string value);
                    /*0x7610484*/ JsonObjectDataContract(System.Runtime.Serialization.DataContract traditionalDataContract);
                    /*0x761048c*/ object ReadJsonValueCore(System.Runtime.Serialization.XmlReaderDelegator jsonReader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context);
                    /*0x7610790*/ void WriteJsonValueCore(System.Runtime.Serialization.XmlWriterDelegator jsonWriter, object obj, System.Runtime.Serialization.Json.XmlObjectSerializerWriteContextComplexJson context, System.RuntimeTypeHandle declaredTypeHandle);
                }

                class JsonQNameDataContract : System.Runtime.Serialization.Json.JsonDataContract
                {
                    /*0x7610b48*/ JsonQNameDataContract(System.Runtime.Serialization.QNameDataContract traditionalQNameDataContract);
                    /*0x7610b50*/ object ReadJsonValueCore(System.Runtime.Serialization.XmlReaderDelegator jsonReader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context);
                }

                class JsonReaderDelegator : System.Runtime.Serialization.XmlReaderDelegator
                {
                    /*0x28*/ System.Runtime.Serialization.DateTimeFormat dateTimeFormat;
                    /*0x30*/ System.Runtime.Serialization.Json.JsonReaderDelegator.DateTimeArrayJsonHelperWithString dateTimeArrayHelper;

                    static /*0x7610cfc*/ System.Xml.XmlQualifiedName ParseQualifiedName(string qname);
                    static /*0x761123c*/ System.DateTime ParseJsonDate(string originalDateTimeValue, System.Runtime.Serialization.DateTimeFormat dateTimeFormat);
                    static /*0x76112cc*/ System.DateTime ParseJsonDateInDefaultFormat(string originalDateTimeValue);
                    /*0x7610bc4*/ JsonReaderDelegator(System.Xml.XmlReader reader);
                    /*0x7610bcc*/ JsonReaderDelegator(System.Xml.XmlReader reader, System.Runtime.Serialization.DateTimeFormat dateTimeFormat);
                    /*0x7610bfc*/ System.Xml.XmlDictionaryReaderQuotas get_ReaderQuotas();
                    /*0x7610c18*/ System.Runtime.Serialization.Json.JsonReaderDelegator.DateTimeArrayJsonHelperWithString get_DateTimeArrayHelper();
                    /*0x7610e00*/ char ReadContentAsChar();
                    /*0x7610e6c*/ System.Xml.XmlQualifiedName ReadContentAsQName();
                    /*0x7610e80*/ char ReadElementContentAsChar();
                    /*0x7610eec*/ byte[] ReadContentAsBase64();
                    /*0x7611068*/ byte[] ReadElementContentAsBase64();
                    /*0x7611220*/ System.DateTime ReadContentAsDateTime();
                    /*0x761175c*/ System.DateTime ReadElementContentAsDateTime();
                    /*0x7611778*/ bool TryReadJsonDateTimeArray(System.Runtime.Serialization.XmlObjectSerializerReadContext context, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace, int arrayLength, ref System.DateTime[] array);
                    /*0x76118d0*/ ulong ReadContentAsUnsignedLong();
                    /*0x7611ae8*/ ulong ReadElementContentAsUnsignedLong();

                    class DateTimeArrayJsonHelperWithString : System.Xml.ArrayHelper<string, System.DateTime>
                    {
                        /*0x10*/ System.Runtime.Serialization.DateTimeFormat dateTimeFormat;

                        /*0x7610c98*/ DateTimeArrayJsonHelperWithString(System.Runtime.Serialization.DateTimeFormat dateTimeFormat);
                        /*0x7611d74*/ int ReadArray(System.Xml.XmlDictionaryReader reader, string localName, string namespaceUri, System.DateTime[] array, int offset, int count);
                        /*0x7612114*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, System.DateTime[] array, int offset, int count);
                    }
                }

                class JsonReaderWriterFactory
                {
                    static /*0x761215c*/ System.Xml.XmlDictionaryReader CreateJsonReader(System.IO.Stream stream, System.Xml.XmlDictionaryReaderQuotas quotas);
                    static /*0x761216c*/ System.Xml.XmlDictionaryReader CreateJsonReader(System.IO.Stream stream, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose onClose);
                    static /*0x7612348*/ System.Xml.XmlDictionaryWriter CreateJsonWriter(System.IO.Stream stream, System.Text.Encoding encoding, bool ownsStream);
                    static /*0x7612354*/ System.Xml.XmlDictionaryWriter CreateJsonWriter(System.IO.Stream stream, System.Text.Encoding encoding, bool ownsStream, bool indent);
                    static /*0x76123c4*/ System.Xml.XmlDictionaryWriter CreateJsonWriter(System.IO.Stream stream, System.Text.Encoding encoding, bool ownsStream, bool indent, string indentChars);
                }

                class JsonStringDataContract : System.Runtime.Serialization.Json.JsonDataContract
                {
                    /*0x76126b8*/ JsonStringDataContract(System.Runtime.Serialization.StringDataContract traditionalStringDataContract);
                    /*0x76126c0*/ object ReadJsonValueCore(System.Runtime.Serialization.XmlReaderDelegator jsonReader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context);
                }

                class JsonUriDataContract : System.Runtime.Serialization.Json.JsonDataContract
                {
                    /*0x7612734*/ JsonUriDataContract(System.Runtime.Serialization.UriDataContract traditionalUriDataContract);
                    /*0x761273c*/ object ReadJsonValueCore(System.Runtime.Serialization.XmlReaderDelegator jsonReader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context);
                }

                class JsonWriterDelegator : System.Runtime.Serialization.XmlWriterDelegator
                {
                    /*0x28*/ System.Runtime.Serialization.DateTimeFormat dateTimeFormat;

                    /*0x76127b0*/ JsonWriterDelegator(System.Xml.XmlWriter writer);
                    /*0x76127b8*/ JsonWriterDelegator(System.Xml.XmlWriter writer, System.Runtime.Serialization.DateTimeFormat dateTimeFormat);
                    /*0x76127e8*/ void WriteChar(char value);
                    /*0x761285c*/ void WriteBase64(byte[] bytes);
                    /*0x76128e8*/ void WriteQName(System.Xml.XmlQualifiedName value);
                    /*0x76129dc*/ void WriteUnsignedLong(ulong value);
                    /*0x7612a60*/ void WriteDecimal(decimal value);
                    /*0x7612af0*/ void WriteDouble(double value);
                    /*0x7612b78*/ void WriteFloat(float value);
                    /*0x7612c00*/ void WriteLong(long value);
                    /*0x7612c80*/ void WriteSignedByte(sbyte value);
                    /*0x7612d00*/ void WriteUnsignedInt(uint value);
                    /*0x7612d80*/ void WriteUnsignedShort(ushort value);
                    /*0x7612e00*/ void WriteUnsignedByte(byte value);
                    /*0x7612e80*/ void WriteShort(short value);
                    /*0x7612f00*/ void WriteBoolean(bool value);
                    /*0x7612f80*/ void WriteInt(int value);
                    /*0x7613000*/ void WriteJsonBooleanArray(bool[] value, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace);
                    /*0x7613088*/ void WriteJsonDateTimeArray(System.DateTime[] value, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace);
                    /*0x7613110*/ void WriteJsonDecimalArray(decimal[] value, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace);
                    /*0x761319c*/ void WriteJsonInt32Array(int[] value, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace);
                    /*0x7613224*/ void WriteJsonInt64Array(long[] value, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace);
                    /*0x76132ac*/ void WriteDateTime(System.DateTime value);
                    /*0x7613368*/ void WriteDateTimeInDefaultFormat(System.DateTime value);
                    /*0x7613980*/ void WriteJsonSingleArray(float[] value, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace);
                    /*0x7613a08*/ void WriteJsonDoubleArray(double[] value, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace);
                    /*0x7613a90*/ void WriteStartElement(string prefix, string localName, string ns);
                }

                class JsonXmlDataContract : System.Runtime.Serialization.Json.JsonDataContract
                {
                    /*0x7613b40*/ JsonXmlDataContract(System.Runtime.Serialization.XmlDataContract traditionalXmlDataContract);
                    /*0x7613b48*/ object ReadJsonValueCore(System.Runtime.Serialization.XmlReaderDelegator jsonReader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context);
                    /*0x761411c*/ void WriteJsonValueCore(System.Runtime.Serialization.XmlWriterDelegator jsonWriter, object obj, System.Runtime.Serialization.Json.XmlObjectSerializerWriteContextComplexJson context, System.RuntimeTypeHandle declaredTypeHandle);
                    /*0x7613d44*/ System.Collections.Generic.List<System.Type> GetKnownTypesFromContext(System.Runtime.Serialization.XmlObjectSerializerContext context, System.Collections.Generic.IList<System.Type> serializerKnownTypeList);
                }

                class XmlJsonReader : System.Xml.XmlBaseReader
                {
                    static /*0x0*/ byte[] charType;
                    /*0xf8*/ bool buffered;
                    /*0x100*/ byte[] charactersToSkipOnNextRead;
                    /*0x108*/ System.Runtime.Serialization.Json.XmlJsonReader.JsonComplexTextMode complexTextMode;
                    /*0x10c*/ bool expectingFirstElementInNonPrimitiveChild;
                    /*0x110*/ int maxBytesPerRead;
                    /*0x118*/ System.Xml.OnXmlDictionaryReaderClose onReaderClose;
                    /*0x120*/ bool readServerTypeElement;
                    /*0x124*/ int scopeDepth;
                    /*0x128*/ System.Runtime.Serialization.Json.JsonNodeType[] scopes;

                    static /*0x7617ebc*/ XmlJsonReader();
                    static /*0x7611ec8*/ void CheckArray(System.Array array, int offset, int count);
                    static /*0x7616dd0*/ int BreakText(byte[] buffer, int offset, int length);
                    static /*0x7616e84*/ int ComputeNumericalTextLength(byte[] buffer, int offset, int offsetMax);
                    static /*0x7616f8c*/ int ComputeQuotedTextLengthUntilEndQuote(byte[] buffer, int offset, int offsetMax, ref bool escaped);
                    static /*0x76165b4*/ bool IsWhitespace(byte ch);
                    static /*0x76170d0*/ char ParseChar(string value, System.Globalization.NumberStyles style);
                    static /*0x76167cc*/ int ParseInt(string value, System.Globalization.NumberStyles style);
                    /*0x76121fc*/ XmlJsonReader();
                    /*0x76142ac*/ string get_Value();
                    /*0x761433c*/ bool get_IsAttributeValue();
                    /*0x7614820*/ bool get_IsReadingCollection();
                    /*0x761486c*/ bool get_IsReadingComplexText();
                    /*0x76148a0*/ void Close();
                    /*0x7614a3c*/ string GetAttribute(int index);
                    /*0x7614a5c*/ string GetAttribute(string localName, string namespaceUri);
                    /*0x7614af4*/ string GetAttribute(string name);
                    /*0x7614b84*/ bool Read();
                    /*0x76165e0*/ decimal ReadContentAsDecimal();
                    /*0x7616758*/ int ReadContentAsInt();
                    /*0x76168f4*/ long ReadContentAsLong();
                    /*0x7616a28*/ int ReadValueChunk(char[] chars, int offset, int count);
                    /*0x761225c*/ void SetInput(System.IO.Stream stream, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose onClose);
                    /*0x7617228*/ void BufferElement();
                    /*0x76163cc*/ void EnterJsonScope(System.Runtime.Serialization.Json.JsonNodeType currentNodeType);
                    /*0x7615a00*/ System.Runtime.Serialization.Json.JsonNodeType ExitJsonScope();
                    /*0x7615a48*/ void MoveToEndElement();
                    /*0x7616d8c*/ void MoveToInitial(System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose onClose);
                    /*0x761733c*/ void ParseAndSetLocalName();
                    /*0x76164bc*/ void ParseStartElement();
                    /*0x76176fc*/ void ReadAttributes();
                    /*0x7615c78*/ void ReadEscapedCharacter(bool moveToText);
                    /*0x7615a64*/ void ReadNonExistentElementName(System.Xml.StringHandleConstStringType elementName);
                    /*0x7617db4*/ int ReadNonFFFE();
                    /*0x7615afc*/ void ReadNumericalText();
                    /*0x76161a8*/ void ReadQuotedText(bool moveToText);
                    /*0x7617a48*/ void ReadServerTypeAttribute(bool consumedObjectChar);
                    /*0x76149a4*/ void ResetState();
                    /*0x761754c*/ void SetJsonNameWithMapping(System.Xml.XmlBaseReader.XmlElementNode elementNode);
                    /*0x7617654*/ void SkipExpectedByteInBufferReader(byte characterToSkip);
                    /*0x76158c4*/ void SkipWhitespaceInBufferReader();
                    /*0x7615984*/ bool TryGetByte(ref byte ch);
                    /*0x76143d0*/ string UnescapeJsonString(string val);

                    enum JsonComplexTextMode
                    {
                        QuotedText = 0,
                        NumericalText = 1,
                        None = 2,
                    }
                }

                class XmlJsonWriter : System.Xml.XmlDictionaryWriter
                {
                    static /*0x0*/ System.Text.BinHexEncoding binHexEncoding;
                    static /*0x8*/ char[] CharacterAbbrevs;
                    /*0x18*/ string attributeText;
                    /*0x20*/ System.Runtime.Serialization.Json.XmlJsonWriter.JsonDataType dataType;
                    /*0x24*/ int depth;
                    /*0x28*/ bool endElementBuffer;
                    /*0x29*/ bool isWritingDataTypeAttribute;
                    /*0x2a*/ bool isWritingServerTypeAttribute;
                    /*0x2b*/ bool isWritingXmlnsAttribute;
                    /*0x2c*/ bool isWritingXmlnsAttributeDefaultNs;
                    /*0x30*/ System.Runtime.Serialization.Json.XmlJsonWriter.NameState nameState;
                    /*0x34*/ System.Runtime.Serialization.Json.JsonNodeType nodeType;
                    /*0x38*/ System.Runtime.Serialization.Json.XmlJsonWriter.JsonNodeWriter nodeWriter;
                    /*0x40*/ System.Runtime.Serialization.Json.JsonNodeType[] scopes;
                    /*0x48*/ string serverTypeValue;
                    /*0x50*/ System.Xml.WriteState writeState;
                    /*0x54*/ bool wroteServerTypeAttribute;
                    /*0x55*/ bool indent;
                    /*0x58*/ string indentChars;
                    /*0x60*/ int indentLevel;

                    static /*0x7617fe0*/ char[] GetCharacterAbbrevs();
                    static /*0x76180dc*/ bool TryEscapeControlCharacter(char ch, ref char abbrev);
                    static /*0x76181ec*/ System.Text.BinHexEncoding get_BinHexEncoding();
                    static /*0x761c2e0*/ bool CharacterNeedsEscaping(char ch);
                    static /*0x76183ec*/ void ThrowClosed();
                    static /*0x761c430*/ bool IsUnicodeNewlineCharacter(char c);
                    /*0x761245c*/ XmlJsonWriter(bool indent, string indentChars);
                    /*0x761814c*/ System.Xml.WriteState get_WriteState();
                    /*0x76181dc*/ string get_XmlLang();
                    /*0x76181e4*/ System.Xml.XmlSpace get_XmlSpace();
                    /*0x76181ac*/ bool get_HasOpenAttribute();
                    /*0x7618294*/ bool get_IsClosed();
                    /*0x76182b8*/ bool get_IsWritingCollection();
                    /*0x7618288*/ bool get_IsWritingNameAttribute();
                    /*0x7618304*/ bool get_IsWritingNameWithMapping();
                    /*0x7618310*/ bool get_WrittenNameWithMapping();
                    /*0x761831c*/ void Close();
                    /*0x76183ac*/ void Flush();
                    /*0x7618454*/ string LookupPrefix(string ns);
                    /*0x7612548*/ void SetOutput(System.IO.Stream stream, System.Text.Encoding encoding, bool ownsStream);
                    /*0x76185c4*/ void WriteArray(string prefix, string localName, string namespaceUri, bool[] array, int offset, int count);
                    /*0x761862c*/ void WriteArray(string prefix, string localName, string namespaceUri, short[] array, int offset, int count);
                    /*0x7618694*/ void WriteArray(string prefix, string localName, string namespaceUri, int[] array, int offset, int count);
                    /*0x76186fc*/ void WriteArray(string prefix, string localName, string namespaceUri, long[] array, int offset, int count);
                    /*0x7618764*/ void WriteArray(string prefix, string localName, string namespaceUri, float[] array, int offset, int count);
                    /*0x76187cc*/ void WriteArray(string prefix, string localName, string namespaceUri, double[] array, int offset, int count);
                    /*0x7618834*/ void WriteArray(string prefix, string localName, string namespaceUri, decimal[] array, int offset, int count);
                    /*0x761889c*/ void WriteArray(string prefix, string localName, string namespaceUri, System.DateTime[] array, int offset, int count);
                    /*0x7618904*/ void WriteArray(string prefix, string localName, string namespaceUri, System.Guid[] array, int offset, int count);
                    /*0x761896c*/ void WriteArray(string prefix, string localName, string namespaceUri, System.TimeSpan[] array, int offset, int count);
                    /*0x76189d4*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, bool[] array, int offset, int count);
                    /*0x7618a3c*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, decimal[] array, int offset, int count);
                    /*0x7618aa4*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, double[] array, int offset, int count);
                    /*0x7618b0c*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, float[] array, int offset, int count);
                    /*0x7618b74*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, int[] array, int offset, int count);
                    /*0x7618bdc*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, long[] array, int offset, int count);
                    /*0x7618c44*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, short[] array, int offset, int count);
                    /*0x7618cac*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.DateTime[] array, int offset, int count);
                    /*0x7618d14*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Guid[] array, int offset, int count);
                    /*0x7618d7c*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.TimeSpan[] array, int offset, int count);
                    /*0x7618de4*/ void WriteBase64(byte[] buffer, int index, int count);
                    /*0x761924c*/ void WriteBinHex(byte[] buffer, int index, int count);
                    /*0x76196f8*/ void WriteCData(string text);
                    /*0x7619708*/ void WriteCharEntity(char ch);
                    /*0x7619764*/ void WriteChars(char[] buffer, int index, int count);
                    /*0x7619908*/ void WriteComment(string text);
                    /*0x76199c4*/ void WriteDocType(string name, string pubid, string sysid, string subset);
                    /*0x7619a80*/ void WriteEndAttribute();
                    /*0x761a1c4*/ void WriteEndDocument();
                    /*0x761a220*/ void WriteEndElement();
                    /*0x761a778*/ void WriteEntityRef(string name);
                    /*0x761a834*/ void WriteFullEndElement();
                    /*0x761a840*/ void WriteProcessingInstruction(string name, string text);
                    /*0x761a98c*/ void WriteQualifiedName(string localName, string ns);
                    /*0x761aa24*/ void WriteRaw(string data);
                    /*0x761aa34*/ void WriteRaw(char[] buffer, int index, int count);
                    /*0x761abd8*/ void WriteStartAttribute(string prefix, string localName, string ns);
                    /*0x761b3c0*/ void WriteStartDocument(bool standalone);
                    /*0x761b3cc*/ void WriteStartDocument();
                    /*0x761b538*/ void WriteStartElement(string prefix, string localName, string ns);
                    /*0x761bbac*/ void WriteString(string text);
                    /*0x761bcc0*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
                    /*0x761bd38*/ void WriteValue(bool value);
                    /*0x761bd74*/ void WriteValue(decimal value);
                    /*0x761bdb8*/ void WriteValue(double value);
                    /*0x761bdf4*/ void WriteValue(float value);
                    /*0x761be30*/ void WriteValue(int value);
                    /*0x761be6c*/ void WriteValue(long value);
                    /*0x761bea8*/ void WriteValue(System.Guid value);
                    /*0x761beec*/ void WriteValue(System.DateTime value);
                    /*0x761bf28*/ void WriteValue(string value);
                    /*0x761bf38*/ void WriteValue(System.TimeSpan value);
                    /*0x761bf74*/ void WriteWhitespace(string ws);
                    /*0x761c140*/ void WriteXmlnsAttribute(string prefix, string namespaceUri);
                    /*0x761c210*/ void WriteXmlnsAttribute(string prefix, System.Xml.XmlDictionaryString namespaceUri);
                    /*0x761c33c*/ void CheckText(System.Runtime.Serialization.Json.JsonNodeType nextNodeType);
                    /*0x761babc*/ void EnterScope(System.Runtime.Serialization.Json.JsonNodeType currentNodeType);
                    /*0x761a680*/ System.Runtime.Serialization.Json.JsonNodeType ExitScope();
                    /*0x7617f5c*/ void InitializeWriter();
                    /*0x7618f9c*/ void StartText();
                    /*0x7619e60*/ void ThrowIfServerTypeWritten(string dataTypeSpecified);
                    /*0x761c45c*/ void ThrowInvalidAttributeContent();
                    /*0x761ba28*/ bool TrySetWritingNameWithMapping(string localName, string ns);
                    /*0x7619fd0*/ void WriteDataTypeServerType();
                    /*0x7619408*/ void WriteEscapedJsonString(string str);
                    /*0x761a700*/ void WriteIndent();
                    /*0x761a6c8*/ void WriteNewLine();
                    /*0x761a154*/ void WriteJsonElementName(string localName);
                    /*0x761a758*/ void WriteJsonQuote();
                    /*0x761a0b8*/ void WriteServerTypeAttribute();

                    enum JsonDataType
                    {
                        None = 0,
                        Null = 1,
                        Boolean = 2,
                        Number = 3,
                        String = 4,
                        Object = 5,
                        Array = 6,
                    }

                    enum NameState
                    {
                        None = 0,
                        IsWritingNameWithMapping = 1,
                        IsWritingNameAttribute = 2,
                        WrittenNameWithMapping = 4,
                    }

                    class JsonNodeWriter : System.Xml.XmlUTF8NodeWriter
                    {
                        /*0x761856c*/ JsonNodeWriter();
                        /*0x761c584*/ void WriteChars(char* chars, int charCount);
                    }
                }

                class XmlObjectSerializerReadContextComplexJson : System.Runtime.Serialization.XmlObjectSerializerReadContextComplex
                {
                    /*0xe8*/ string extensionDataValueType;
                    /*0xf0*/ System.Runtime.Serialization.DateTimeFormat dateTimeFormat;
                    /*0xf8*/ bool useSimpleDictionaryFormat;

                    static /*0x761cec4*/ System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson CreateContext(System.Runtime.Serialization.Json.DataContractJsonSerializer serializer, System.Runtime.Serialization.DataContract rootTypeDataContract);
                    static /*0x761d310*/ bool TryGetJsonLocalName(System.Runtime.Serialization.XmlReaderDelegator xmlReader, ref string name);
                    static /*0x761d3f4*/ string GetJsonMemberName(System.Runtime.Serialization.XmlReaderDelegator xmlReader);
                    static /*0x761d43c*/ void ThrowMissingRequiredMembers(object obj, System.Xml.XmlDictionaryString[] memberNames, byte[] expectedElements, byte[] requiredElements);
                    static /*0x761d698*/ void ThrowDuplicateMemberException(object obj, System.Xml.XmlDictionaryString[] memberNames, int memberIndex);
                    static /*0x761d690*/ bool IsBitSet(byte[] bytes, int bitIndex);
                    /*0x761c58c*/ XmlObjectSerializerReadContextComplexJson(System.Runtime.Serialization.Json.DataContractJsonSerializer serializer, System.Runtime.Serialization.DataContract rootTypeDataContract);
                    /*0x761c680*/ System.Collections.Generic.IList<System.Type> get_SerializerKnownTypeList();
                    /*0x761c688*/ bool get_UseSimpleDictionaryFormat();
                    /*0x761c690*/ void StartReadExtensionDataValue(System.Runtime.Serialization.XmlReaderDelegator xmlReader);
                    /*0x761c6f8*/ System.Runtime.Serialization.IDataNode ReadPrimitiveExtensionDataValue(System.Runtime.Serialization.XmlReaderDelegator xmlReader, string dataContractName, string dataContractNamespace);
                    /*0x761c90c*/ System.Runtime.Serialization.IDataNode ReadNumericalPrimitiveExtensionDataValue(System.Runtime.Serialization.XmlReaderDelegator xmlReader);
                    /*0x761cf2c*/ int GetArraySize();
                    /*0x761cf34*/ object ReadDataContractValue(System.Runtime.Serialization.DataContract dataContract, System.Runtime.Serialization.XmlReaderDelegator reader);
                    /*0x761cf4c*/ void ReadAttributes(System.Runtime.Serialization.XmlReaderDelegator xmlReader);
                    /*0x761d16c*/ int GetJsonMemberIndex(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Xml.XmlDictionaryString[] memberNames, int memberIndex, System.Runtime.Serialization.ExtensionDataObject extensionData);
                    /*0x761d7ac*/ bool IsReadingCollectionExtensionData(System.Runtime.Serialization.XmlReaderDelegator xmlReader);
                    /*0x761d820*/ bool IsReadingClassExtensionData(System.Runtime.Serialization.XmlReaderDelegator xmlReader);
                    /*0x761d894*/ System.Runtime.Serialization.XmlReaderDelegator CreateReaderDelegatorForReader(System.Xml.XmlReader xmlReader);
                    /*0x761d910*/ System.Runtime.Serialization.DataContract GetDataContract(System.RuntimeTypeHandle typeHandle, System.Type type);
                    /*0x761d934*/ System.Runtime.Serialization.DataContract GetDataContractSkipValidation(int typeId, System.RuntimeTypeHandle typeHandle, System.Type type);
                    /*0x761d958*/ System.Runtime.Serialization.DataContract GetDataContract(int id, System.RuntimeTypeHandle typeHandle);
                    /*0x761d97c*/ System.Runtime.Serialization.DataContract ResolveDataContractFromRootDataContract(System.Xml.XmlQualifiedName typeQName);
                }

                class XmlObjectSerializerWriteContextComplexJson : System.Runtime.Serialization.XmlObjectSerializerWriteContextComplex
                {
                    /*0xf0*/ System.Runtime.Serialization.EmitTypeInformation emitXsiType;
                    /*0xf4*/ bool perCallXsiTypeAlreadyEmitted;
                    /*0xf5*/ bool useSimpleDictionaryFormat;

                    static /*0x761dc9c*/ System.Runtime.Serialization.Json.XmlObjectSerializerWriteContextComplexJson CreateContext(System.Runtime.Serialization.Json.DataContractJsonSerializer serializer, System.Runtime.Serialization.DataContract rootTypeDataContract);
                    static /*0x761de34*/ string TruncateDefaultDataContractNamespace(string dataContractNamespace);
                    static /*0x761df6c*/ bool RequiresJsonTypeInfo(System.Runtime.Serialization.DataContract contract);
                    static /*0x761e470*/ System.Runtime.Serialization.DataContract GetRevisedItemContract(System.Runtime.Serialization.DataContract oldItemContract);
                    static /*0x761e6b0*/ void WriteJsonNameWithMapping(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Xml.XmlDictionaryString[] memberNames, int index);
                    static /*0x761f24c*/ void VerifyObjectCompatibilityWithInterface(System.Runtime.Serialization.DataContract contract, object graph, System.Type declaredType);
                    static /*0x761d984*/ System.Runtime.Serialization.DataContract ResolveJsonDataContractFromRootDataContract(System.Runtime.Serialization.XmlObjectSerializerContext context, System.Xml.XmlQualifiedName typeQName, System.Runtime.Serialization.DataContract rootTypeDataContract);
                    /*0x761dbe8*/ XmlObjectSerializerWriteContextComplexJson(System.Runtime.Serialization.Json.DataContractJsonSerializer serializer, System.Runtime.Serialization.DataContract rootTypeDataContract);
                    /*0x761dd04*/ System.Collections.Generic.IList<System.Type> get_SerializerKnownTypeList();
                    /*0x761dd0c*/ bool get_UseSimpleDictionaryFormat();
                    /*0x761dd14*/ bool WriteClrTypeInfo(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Type dataContractType, string clrTypeName, string clrAssemblyName);
                    /*0x761dd1c*/ bool WriteClrTypeInfo(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Runtime.Serialization.DataContract dataContract);
                    /*0x761dd24*/ void WriteArraySize(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, int size);
                    /*0x761dd28*/ void WriteTypeInfo(System.Runtime.Serialization.XmlWriterDelegator writer, string dataContractName, string dataContractNamespace);
                    /*0x761ddd0*/ void WriteTypeInfo(System.Runtime.Serialization.XmlWriterDelegator writer, string typeInformation);
                    /*0x761dfc8*/ bool WriteTypeInfo(System.Runtime.Serialization.XmlWriterDelegator writer, System.Runtime.Serialization.DataContract contract, System.Runtime.Serialization.DataContract declaredContract);
                    /*0x761e2c8*/ void WriteJsonISerializable(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Runtime.Serialization.ISerializable obj);
                    /*0x761e570*/ void WriteDataContractValue(System.Runtime.Serialization.DataContract dataContract, System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.RuntimeTypeHandle declaredTypeHandle);
                    /*0x761e64c*/ void WriteNull(System.Runtime.Serialization.XmlWriterDelegator xmlWriter);
                    /*0x761e658*/ System.Xml.XmlDictionaryString get_CollectionItemName();
                    /*0x761e770*/ void WriteExtensionDataTypeInfo(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Runtime.Serialization.IDataNode dataNode);
                    /*0x761eb78*/ void SerializeWithXsiType(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.RuntimeTypeHandle objectTypeHandle, System.Type objectType, int declaredTypeID, System.RuntimeTypeHandle declaredTypeHandle, System.Type declaredType);
                    /*0x761ed3c*/ void HandleCollectionAssignedToObject(System.Type declaredType, ref System.Runtime.Serialization.DataContract dataContract, ref object obj, ref bool verifyKnownType);
                    /*0x761f6ac*/ void SerializeWithXsiTypeAtTopLevel(System.Runtime.Serialization.DataContract dataContract, System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.RuntimeTypeHandle originalDeclaredTypeHandle, System.Type graphType);
                    /*0x761f4d4*/ void VerifyType(System.Runtime.Serialization.DataContract dataContract, System.Type declaredType);
                    /*0x761f7f0*/ System.Runtime.Serialization.DataContract GetDataContract(System.RuntimeTypeHandle typeHandle, System.Type type);
                    /*0x761f814*/ System.Runtime.Serialization.DataContract GetDataContractSkipValidation(int typeId, System.RuntimeTypeHandle typeHandle, System.Type type);
                    /*0x761f838*/ System.Runtime.Serialization.DataContract GetDataContract(int id, System.RuntimeTypeHandle typeHandle);
                    /*0x761f85c*/ System.Runtime.Serialization.DataContract ResolveDataContractFromRootDataContract(System.Xml.XmlQualifiedName typeQName);
                }

                class JsonFormatReaderInterpreter
                {
                    /*0x10*/ bool is_get_only_collection;
                    /*0x18*/ System.Runtime.Serialization.ClassDataContract classContract;
                    /*0x20*/ System.Runtime.Serialization.CollectionDataContract collectionContract;
                    /*0x28*/ object objectLocal;
                    /*0x30*/ System.Type objectType;
                    /*0x38*/ System.Runtime.Serialization.XmlReaderDelegator xmlReader;
                    /*0x40*/ System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context;
                    /*0x48*/ System.Xml.XmlDictionaryString[] memberNames;
                    /*0x50*/ System.Xml.XmlDictionaryString emptyDictionaryString;
                    /*0x58*/ System.Xml.XmlDictionaryString itemName;

                    /*0x760f11c*/ JsonFormatReaderInterpreter(System.Runtime.Serialization.ClassDataContract classContract);
                    /*0x760f518*/ JsonFormatReaderInterpreter(System.Runtime.Serialization.CollectionDataContract collectionContract, bool isGetOnly);
                    /*0x760f14c*/ object ReadFromJson(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context, System.Xml.XmlDictionaryString emptyDictionaryString, System.Xml.XmlDictionaryString[] memberNames);
                    /*0x760f554*/ object ReadCollectionFromJson(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context, System.Xml.XmlDictionaryString emptyDictionaryString, System.Xml.XmlDictionaryString itemName, System.Runtime.Serialization.CollectionDataContract collectionContract);
                    /*0x760f690*/ void ReadGetOnlyCollectionFromJson(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context, System.Xml.XmlDictionaryString emptyDictionaryString, System.Xml.XmlDictionaryString itemName, System.Runtime.Serialization.CollectionDataContract collectionContract);
                    /*0x761f864*/ void CreateObject(System.Runtime.Serialization.ClassDataContract classContract);
                    /*0x761fab0*/ void InvokeOnDeserializing(System.Runtime.Serialization.ClassDataContract classContract);
                    /*0x761ffb8*/ void InvokeOnDeserialized(System.Runtime.Serialization.ClassDataContract classContract);
                    /*0x7620bbc*/ bool HasFactoryMethod(System.Runtime.Serialization.ClassDataContract classContract);
                    /*0x7620110*/ bool InvokeFactoryMethod(System.Runtime.Serialization.ClassDataContract classContract);
                    /*0x761fc08*/ void ReadISerializable(System.Runtime.Serialization.ClassDataContract classContract);
                    /*0x761fe50*/ void ReadClass(System.Runtime.Serialization.ClassDataContract classContract);
                    /*0x7620c44*/ void ReadMembers(System.Runtime.Serialization.ClassDataContract classContract, System.Runtime.Serialization.ExtensionDataObject extensionData);
                    /*0x7620f24*/ int ReadMembers(int index, System.Runtime.Serialization.ClassDataContract classContract, System.Runtime.Serialization.BitFlagsGenerator expectedElements, ref int memberIndex);
                    /*0x7621130*/ bool CheckRequiredElements(System.Runtime.Serialization.BitFlagsGenerator expectedElements, byte[] requiredElements);
                    /*0x7620dcc*/ int SetRequiredElements(System.Runtime.Serialization.ClassDataContract contract, byte[] requiredElements);
                    /*0x7620ed4*/ void SetExpectedElements(System.Runtime.Serialization.BitFlagsGenerator expectedElements, int startIndex);
                    /*0x7621768*/ void ResetExpectedElements(System.Runtime.Serialization.BitFlagsGenerator expectedElements, int index);
                    /*0x76211c0*/ object ReadValue(System.Type type, string name);
                    /*0x7621788*/ object InternalDeserialize(System.Type type, string name);
                    /*0x7621974*/ object WrapNullableObject(System.Type innerType, object innerValue, System.Type outerType, int nullables);
                    /*0x7620238*/ void ReadCollection(System.Runtime.Serialization.CollectionDataContract collectionContract);
                    /*0x7621b58*/ void ReadSimpleDictionary(System.Runtime.Serialization.CollectionDataContract collectionContract, System.Type keyValueType);
                    /*0x7620918*/ void ReadGetOnlyCollection(System.Runtime.Serialization.CollectionDataContract collectionContract);
                    /*0x7622138*/ bool TryReadPrimitiveArray(System.Type itemType, ref bool readResult);
                    /*0x76224dc*/ object ReadCollectionItem(System.Runtime.Serialization.CollectionDataContract collectionContract, System.Type itemType);
                    /*0x76225f0*/ void StoreCollectionValue(object collection, System.Type valueType, object value, System.Runtime.Serialization.CollectionDataContract collectionContract);
                    /*0x7622988*/ void HandleUnexpectedItemInCollection(ref int iterator);
                    /*0x76224c0*/ bool IsStartElement(System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                    /*0x7622aa0*/ bool IsStartElement();
                    /*0x7622960*/ bool IsEndElement();
                    /*0x7622a6c*/ void ThrowUnexpectedStateException(System.Xml.XmlNodeType expectedState);
                    /*0x7622a08*/ void ThrowSerializationException(string msg, object[] values);

                    enum KeyParseMode
                    {
                        Fail = 0,
                        AsString = 1,
                        UsingParseEnum = 2,
                        UsingCustomParse = 3,
                    }
                }

                class JsonFormatWriterInterpreter
                {
                    /*0x10*/ System.Runtime.Serialization.ClassDataContract classContract;
                    /*0x18*/ System.Runtime.Serialization.CollectionDataContract collectionContract;
                    /*0x20*/ System.Runtime.Serialization.XmlWriterDelegator writer;
                    /*0x28*/ object obj;
                    /*0x30*/ System.Runtime.Serialization.Json.XmlObjectSerializerWriteContextComplexJson context;
                    /*0x38*/ System.Runtime.Serialization.DataContract dataContract;
                    /*0x40*/ object objLocal;
                    /*0x48*/ System.Xml.XmlDictionaryString[] memberNames;
                    /*0x50*/ int typeIndex;
                    /*0x54*/ int childElementIndex;

                    /*0x760ff78*/ JsonFormatWriterInterpreter(System.Runtime.Serialization.ClassDataContract classContract);
                    /*0x7610128*/ JsonFormatWriterInterpreter(System.Runtime.Serialization.CollectionDataContract collectionContract);
                    /*0x7622abc*/ System.Runtime.Serialization.CollectionDataContract get_collectionDataContract();
                    /*0x760ffb0*/ void WriteToJson(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.Json.XmlObjectSerializerWriteContextComplexJson context, System.Runtime.Serialization.ClassDataContract dataContract, System.Xml.XmlDictionaryString[] memberNames);
                    /*0x7610160*/ void WriteCollectionToJson(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.Json.XmlObjectSerializerWriteContextComplexJson context, System.Runtime.Serialization.CollectionDataContract dataContract);
                    /*0x7622b18*/ void InitArgs(System.Type objType);
                    /*0x76242a0*/ void InvokeOnSerializing(System.Runtime.Serialization.ClassDataContract classContract, object objSerialized, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                    /*0x7624400*/ void InvokeOnSerialized(System.Runtime.Serialization.ClassDataContract classContract, object objSerialized, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                    /*0x7622c9c*/ void WriteClass(System.Runtime.Serialization.ClassDataContract classContract);
                    /*0x7622e8c*/ void WriteCollection(System.Runtime.Serialization.CollectionDataContract collectionContract);
                    /*0x7624560*/ int WriteMembers(System.Runtime.Serialization.ClassDataContract classContract, System.Runtime.Serialization.ExtensionDataObject extensionData, System.Runtime.Serialization.ClassDataContract derivedMostClassContract);
                    /*0x7625c58*/ bool IsDefaultValue(System.Type type, object value);
                    /*0x7625c8c*/ object GetDefaultValue(System.Type type);
                    /*0x76251a8*/ void WriteStartElement(object nameLocal, int nameIndex);
                    /*0x7625b9c*/ void WriteEndElement();
                    /*0x7624c8c*/ void WriteArrayAttribute();
                    /*0x7625bb8*/ void WriteObjectAttribute();
                    /*0x76252c4*/ void WriteValue(System.Type memberType, object memberValue);
                    /*0x7625ddc*/ void InternalSerialize(System.Reflection.MethodInfo methodInfo, System.Func<object> memberValue, System.Type memberType, bool writeXsiType);
                    /*0x7626244*/ object UnwrapNullableObject(System.Func<object> memberValue, ref System.Type memberType, ref bool isNull);
                    /*0x7624d10*/ bool TryWritePrimitive(System.Type type, System.Func<object> value, System.Reflection.MemberInfo memberInfo, System.Nullable<int> arrayItemIndex, System.Xml.XmlDictionaryString name, int nameIndex);
                    /*0x7624940*/ bool TryWritePrimitiveArray(System.Type type, System.Type itemType, System.Func<object> value, System.Xml.XmlDictionaryString itemName);
                    /*0x7625c2c*/ object LoadMemberValue(System.Runtime.Serialization.DataMember member);
                    /*0x7626650*/ object <WriteCollection>b__22_0();

                    class <>c__DisplayClass22_0
                    {
                        /*0x10*/ object currentValue;
                        /*0x18*/ System.Func<object> <>9__1;

                        /*0x7626658*/ <>c__DisplayClass22_0();
                        /*0x7626660*/ object <WriteCollection>b__1();
                    }

                    class <>c__DisplayClass23_0
                    {
                        /*0x10*/ object memberValue;

                        /*0x7626668*/ <>c__DisplayClass23_0();
                        /*0x7626670*/ object <WriteMembers>b__0();
                    }

                    class <>c__DisplayClass30_0
                    {
                        /*0x10*/ object memberValue;

                        /*0x7626678*/ <>c__DisplayClass30_0();
                        /*0x7626680*/ object <WriteValue>b__0();
                        /*0x7626688*/ object <WriteValue>b__1();
                        /*0x7626690*/ object <WriteValue>b__2();
                    }
                }
            }

            namespace Diagnostics
            {
                class TraceUtility
                {
                    static /*0x0*/ System.Collections.Generic.Dictionary<int, string> traceCodes;

                    static /*0x76269bc*/ TraceUtility();
                    static /*0x7626698*/ void Trace(System.Diagnostics.TraceEventType severity, int traceCode, string traceDescription);
                    static /*0x7626708*/ void Trace(System.Diagnostics.TraceEventType severity, int traceCode, string traceDescription, System.Runtime.Diagnostics.TraceRecord record);
                    static /*0x7626788*/ void Trace(System.Diagnostics.TraceEventType severity, int traceCode, string traceDescription, System.Runtime.Diagnostics.TraceRecord record, System.Exception exception);
                }

                namespace Application
                {
                    class TD
                    {
                        static /*0x0*/ System.Runtime.Diagnostics.EventDescriptor[] eventDescriptors;
                        static /*0x8*/ object syncLock;
                        static /*0x10*/ bool eventDescriptorsCreated;

                        static /*0x7628ecc*/ TD();
                        static /*0x7626d6c*/ bool ReaderQuotaExceededIsEnabled();
                        static /*0x7626ebc*/ void ReaderQuotaExceeded(string param0);
                        static /*0x7627078*/ bool DCSerializeWithSurrogateStartIsEnabled();
                        static /*0x762710c*/ void DCSerializeWithSurrogateStart(string SurrogateType);
                        static /*0x76271e4*/ bool DCSerializeWithSurrogateStopIsEnabled();
                        static /*0x7627278*/ void DCSerializeWithSurrogateStop();
                        static /*0x762741c*/ bool DCDeserializeWithSurrogateStartIsEnabled();
                        static /*0x76274b0*/ void DCDeserializeWithSurrogateStart(string SurrogateType);
                        static /*0x7627588*/ bool DCDeserializeWithSurrogateStopIsEnabled();
                        static /*0x762761c*/ void DCDeserializeWithSurrogateStop();
                        static /*0x76276ec*/ bool ImportKnownTypesStartIsEnabled();
                        static /*0x7627780*/ void ImportKnownTypesStart();
                        static /*0x7627850*/ bool ImportKnownTypesStopIsEnabled();
                        static /*0x76278e4*/ void ImportKnownTypesStop();
                        static /*0x76279b4*/ bool DCResolverResolveIsEnabled();
                        static /*0x7627a48*/ void DCResolverResolve(string TypeName);
                        static /*0x7627b20*/ bool DCGenWriterStartIsEnabled();
                        static /*0x7627bb4*/ void DCGenWriterStart(string Kind, string TypeName);
                        static /*0x7627d88*/ bool DCGenWriterStopIsEnabled();
                        static /*0x7627e1c*/ void DCGenWriterStop();
                        static /*0x7627eec*/ bool DCGenReaderStartIsEnabled();
                        static /*0x7627f80*/ void DCGenReaderStart(string Kind, string TypeName);
                        static /*0x7628068*/ bool DCGenReaderStopIsEnabled();
                        static /*0x76280fc*/ void DCGenReaderStop();
                        static /*0x76281cc*/ bool DCJsonGenReaderStartIsEnabled();
                        static /*0x7628260*/ void DCJsonGenReaderStart(string Kind, string TypeName);
                        static /*0x7628348*/ bool DCJsonGenReaderStopIsEnabled();
                        static /*0x76283dc*/ void DCJsonGenReaderStop();
                        static /*0x76284ac*/ bool DCJsonGenWriterStartIsEnabled();
                        static /*0x7628540*/ void DCJsonGenWriterStart(string Kind, string TypeName);
                        static /*0x7628628*/ bool DCJsonGenWriterStopIsEnabled();
                        static /*0x76286bc*/ void DCJsonGenWriterStop();
                        static /*0x762878c*/ void CreateEventDescriptors();
                        static /*0x7628d54*/ void EnsureEventDescriptors();
                        static /*0x7626e00*/ bool IsEtwEventEnabled(int eventIndex);
                        static /*0x7626f94*/ bool WriteEtwEvent(int eventIndex, System.Runtime.Diagnostics.EventTraceActivity eventParam0, string eventParam1, string eventParam2);
                        static /*0x7627348*/ bool WriteEtwEvent(int eventIndex, System.Runtime.Diagnostics.EventTraceActivity eventParam0, string eventParam1);
                        static /*0x7627c9c*/ bool WriteEtwEvent(int eventIndex, System.Runtime.Diagnostics.EventTraceActivity eventParam0, string eventParam1, string eventParam2, string eventParam3);
                    }
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 0778B88CF739FBF497B4D61586F4B6448056E6B305D4B06A91BD5A34BB55F167;
    static /*0x27*/ <PrivateImplementationDetails> 07B17FBD48328D70E7A6875353DCC135EDC6C8008ADDA9287DD0D1C01A0C2DA5;
    static /*0xa7*/ <PrivateImplementationDetails> 0AA86CAD79935F18BB2A386E4EE3942F4AC11B4917BBC244589A759E64A4320E;
    static /*0xad*/ <PrivateImplementationDetails> 141D88DBD309555BDD06664CDA05DD54EF001086CADDAFE32AF6646AFEDF9B34;
    static /*0xed*/ <PrivateImplementationDetails> 2125B2C332B1113AAE9BFC5E9F7E3B4C91D828CB942C2DF1EEB02502ECCAE9E9;
    static /*0xfd*/ <PrivateImplementationDetails> 301512FFFF9F0A98660AAC6A73495F09EEBB3598609B3ED991AEC1B9C0283872;
    static /*0x13d*/ <PrivateImplementationDetails> 4115BAA94E12B39AB5433C271F51CA73A8941474946746BE20FF2E679265204A;
    static /*0x1c0*/ long 43B2BAE670862746D450580C9D19092B89F152579694F3960C49B9B32631B636;
    static /*0x1c8*/ long 4FFBAE68801817B08163DBD0023D76523C184FD01829D309F8731169CDF0DC32;
    static /*0x1d0*/ <PrivateImplementationDetails> 5CF1FA8D836A5E82EAD36FB0854A6A68A4B8F7542038A346357D2424DDB60F5E;
    static /*0x1d5*/ <PrivateImplementationDetails> 69902299DCBBB683E2F8D030182A118E263895B0741D115080954756FF6927F4;
    static /*0x1d8*/ <PrivateImplementationDetails> 71C480DF93D6AE2F1EFAD1447C66C9525E316218CF51FC8D9ED832F2DAF18B73;
    static /*0x1f2*/ <PrivateImplementationDetails> 7543B37FA53FDE2C84F07FD39F368555966AA1C0EB2F2FD26B294D79966E290E;
    static /*0x232*/ <PrivateImplementationDetails> 86E0A4D4F900F574D917587D8767680FDEDC64DA8E542A31F08B5A06C3FE389B;
    static /*0x258*/ <PrivateImplementationDetails> 916A8F81581DC5FBF1B7054C732973715AF88BEC75AA6D3FBA3F4CDD4339E640;
    static /*0x358*/ <PrivateImplementationDetails> 9554602FCFE44E49A3B944935FA0D572E1DF6D1BE17F76CB9E14E1275F0D1CB3;
    static /*0x458*/ <PrivateImplementationDetails> A2011EC537AEDB42D450CD8EE11952B207B84CD4F1FB4A51825260ADA111F019;
    static /*0x658*/ <PrivateImplementationDetails> A8FA6609048BE08405501B83AA4547AD47B4C5EAABDE4FC7F6A376A35E8106B2;
    static /*0x676*/ <PrivateImplementationDetails> AAFC395EF50119504BA02FF16011DC5F347953970F851D503AFFE6B942D5DD1C;
    static /*0x6c8*/ long DACC0E6568D9B10337A1A693F10D42C3175E80C378154406C6FBFA989F919F51;
    static /*0x6d0*/ long E8424EA5339B85A750AB5F4C63BDE5D5C62975792A3BED6CCB37C045207C6771;
    static /*0x6d8*/ <PrivateImplementationDetails> FF517CBF611BA5DCC09449D4E0B1603306508DA5510FE4266AFDC0E32123E756;

    struct __StaticArrayInitTypeSize=3
    {
    }

    struct __StaticArrayInitTypeSize=5
    {
    }

    struct __StaticArrayInitTypeSize=6
    {
    }

    struct __StaticArrayInitTypeSize=16
    {
    }

    struct __StaticArrayInitTypeSize=26
    {
    }

    struct __StaticArrayInitTypeSize=30
    {
    }

    struct __StaticArrayInitTypeSize=38
    {
    }

    struct __StaticArrayInitTypeSize=39
    {
    }

    struct __StaticArrayInitTypeSize=64
    {
    }

    struct __StaticArrayInitTypeSize=80
    {
    }

    struct __StaticArrayInitTypeSize=128
    {
    }

    struct __StaticArrayInitTypeSize=256
    {
    }

    struct __StaticArrayInitTypeSize=512
    {
    }
}
