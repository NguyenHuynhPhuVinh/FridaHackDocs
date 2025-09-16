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
            /*0x380cb08*/ ArrayHelper();
            /*0x3907c14*/ TArray[] ReadArray(System.Xml.XmlDictionaryReader reader, TArgument localName, TArgument namespaceUri, int maxArrayLength);
            /*0x3907c14*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, TArgument localName, TArgument namespaceUri, System.Xml.XmlDictionaryReader reader);
            /*0x3907c14*/ int ReadArray(System.Xml.XmlDictionaryReader reader, TArgument localName, TArgument namespaceUri, TArray[] array, int offset, int count);
            /*0x3907c14*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, TArgument localName, TArgument namespaceUri, TArray[] array, int offset, int count);
        }

        class BooleanArrayHelperWithString : System.Xml.ArrayHelper<string, bool>
        {
            static /*0x0*/ System.Xml.BooleanArrayHelperWithString Instance;

            static /*0x75655b8*/ BooleanArrayHelperWithString();
            /*0x7565570*/ BooleanArrayHelperWithString();
            /*0x75654f4*/ int ReadArray(System.Xml.XmlDictionaryReader reader, string localName, string namespaceUri, bool[] array, int offset, int count);
            /*0x7565530*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, bool[] array, int offset, int count);
        }

        class BooleanArrayHelperWithDictionaryString : System.Xml.ArrayHelper<System.Xml.XmlDictionaryString, bool>
        {
            static /*0x0*/ System.Xml.BooleanArrayHelperWithDictionaryString Instance;

            static /*0x75656e0*/ BooleanArrayHelperWithDictionaryString();
            /*0x7565698*/ BooleanArrayHelperWithDictionaryString();
            /*0x756561c*/ int ReadArray(System.Xml.XmlDictionaryReader reader, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, bool[] array, int offset, int count);
            /*0x7565658*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, bool[] array, int offset, int count);
        }

        class Int16ArrayHelperWithString : System.Xml.ArrayHelper<string, short>
        {
            static /*0x0*/ System.Xml.Int16ArrayHelperWithString Instance;

            static /*0x7565808*/ Int16ArrayHelperWithString();
            /*0x75657c0*/ Int16ArrayHelperWithString();
            /*0x7565744*/ int ReadArray(System.Xml.XmlDictionaryReader reader, string localName, string namespaceUri, short[] array, int offset, int count);
            /*0x7565780*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, short[] array, int offset, int count);
        }

        class Int16ArrayHelperWithDictionaryString : System.Xml.ArrayHelper<System.Xml.XmlDictionaryString, short>
        {
            static /*0x0*/ System.Xml.Int16ArrayHelperWithDictionaryString Instance;

            static /*0x7565930*/ Int16ArrayHelperWithDictionaryString();
            /*0x75658e8*/ Int16ArrayHelperWithDictionaryString();
            /*0x756586c*/ int ReadArray(System.Xml.XmlDictionaryReader reader, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, short[] array, int offset, int count);
            /*0x75658a8*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, short[] array, int offset, int count);
        }

        class Int32ArrayHelperWithString : System.Xml.ArrayHelper<string, int>
        {
            static /*0x0*/ System.Xml.Int32ArrayHelperWithString Instance;

            static /*0x7565a58*/ Int32ArrayHelperWithString();
            /*0x7565a10*/ Int32ArrayHelperWithString();
            /*0x7565994*/ int ReadArray(System.Xml.XmlDictionaryReader reader, string localName, string namespaceUri, int[] array, int offset, int count);
            /*0x75659d0*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, int[] array, int offset, int count);
        }

        class Int32ArrayHelperWithDictionaryString : System.Xml.ArrayHelper<System.Xml.XmlDictionaryString, int>
        {
            static /*0x0*/ System.Xml.Int32ArrayHelperWithDictionaryString Instance;

            static /*0x7565b80*/ Int32ArrayHelperWithDictionaryString();
            /*0x7565b38*/ Int32ArrayHelperWithDictionaryString();
            /*0x7565abc*/ int ReadArray(System.Xml.XmlDictionaryReader reader, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, int[] array, int offset, int count);
            /*0x7565af8*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, int[] array, int offset, int count);
        }

        class Int64ArrayHelperWithString : System.Xml.ArrayHelper<string, long>
        {
            static /*0x0*/ System.Xml.Int64ArrayHelperWithString Instance;

            static /*0x7565ca8*/ Int64ArrayHelperWithString();
            /*0x7565c60*/ Int64ArrayHelperWithString();
            /*0x7565be4*/ int ReadArray(System.Xml.XmlDictionaryReader reader, string localName, string namespaceUri, long[] array, int offset, int count);
            /*0x7565c20*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, long[] array, int offset, int count);
        }

        class Int64ArrayHelperWithDictionaryString : System.Xml.ArrayHelper<System.Xml.XmlDictionaryString, long>
        {
            static /*0x0*/ System.Xml.Int64ArrayHelperWithDictionaryString Instance;

            static /*0x7565dd0*/ Int64ArrayHelperWithDictionaryString();
            /*0x7565d88*/ Int64ArrayHelperWithDictionaryString();
            /*0x7565d0c*/ int ReadArray(System.Xml.XmlDictionaryReader reader, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, long[] array, int offset, int count);
            /*0x7565d48*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, long[] array, int offset, int count);
        }

        class SingleArrayHelperWithString : System.Xml.ArrayHelper<string, float>
        {
            static /*0x0*/ System.Xml.SingleArrayHelperWithString Instance;

            static /*0x7565ef8*/ SingleArrayHelperWithString();
            /*0x7565eb0*/ SingleArrayHelperWithString();
            /*0x7565e34*/ int ReadArray(System.Xml.XmlDictionaryReader reader, string localName, string namespaceUri, float[] array, int offset, int count);
            /*0x7565e70*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, float[] array, int offset, int count);
        }

        class SingleArrayHelperWithDictionaryString : System.Xml.ArrayHelper<System.Xml.XmlDictionaryString, float>
        {
            static /*0x0*/ System.Xml.SingleArrayHelperWithDictionaryString Instance;

            static /*0x7566020*/ SingleArrayHelperWithDictionaryString();
            /*0x7565fd8*/ SingleArrayHelperWithDictionaryString();
            /*0x7565f5c*/ int ReadArray(System.Xml.XmlDictionaryReader reader, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, float[] array, int offset, int count);
            /*0x7565f98*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, float[] array, int offset, int count);
        }

        class DoubleArrayHelperWithString : System.Xml.ArrayHelper<string, double>
        {
            static /*0x0*/ System.Xml.DoubleArrayHelperWithString Instance;

            static /*0x7566148*/ DoubleArrayHelperWithString();
            /*0x7566100*/ DoubleArrayHelperWithString();
            /*0x7566084*/ int ReadArray(System.Xml.XmlDictionaryReader reader, string localName, string namespaceUri, double[] array, int offset, int count);
            /*0x75660c0*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, double[] array, int offset, int count);
        }

        class DoubleArrayHelperWithDictionaryString : System.Xml.ArrayHelper<System.Xml.XmlDictionaryString, double>
        {
            static /*0x0*/ System.Xml.DoubleArrayHelperWithDictionaryString Instance;

            static /*0x7566270*/ DoubleArrayHelperWithDictionaryString();
            /*0x7566228*/ DoubleArrayHelperWithDictionaryString();
            /*0x75661ac*/ int ReadArray(System.Xml.XmlDictionaryReader reader, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, double[] array, int offset, int count);
            /*0x75661e8*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, double[] array, int offset, int count);
        }

        class DecimalArrayHelperWithString : System.Xml.ArrayHelper<string, decimal>
        {
            static /*0x0*/ System.Xml.DecimalArrayHelperWithString Instance;

            static /*0x7566398*/ DecimalArrayHelperWithString();
            /*0x7566350*/ DecimalArrayHelperWithString();
            /*0x75662d4*/ int ReadArray(System.Xml.XmlDictionaryReader reader, string localName, string namespaceUri, decimal[] array, int offset, int count);
            /*0x7566310*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, decimal[] array, int offset, int count);
        }

        class DecimalArrayHelperWithDictionaryString : System.Xml.ArrayHelper<System.Xml.XmlDictionaryString, decimal>
        {
            static /*0x0*/ System.Xml.DecimalArrayHelperWithDictionaryString Instance;

            static /*0x75664c0*/ DecimalArrayHelperWithDictionaryString();
            /*0x7566478*/ DecimalArrayHelperWithDictionaryString();
            /*0x75663fc*/ int ReadArray(System.Xml.XmlDictionaryReader reader, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, decimal[] array, int offset, int count);
            /*0x7566438*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, decimal[] array, int offset, int count);
        }

        class DateTimeArrayHelperWithString : System.Xml.ArrayHelper<string, System.DateTime>
        {
            static /*0x0*/ System.Xml.DateTimeArrayHelperWithString Instance;

            static /*0x75665e8*/ DateTimeArrayHelperWithString();
            /*0x75665a0*/ DateTimeArrayHelperWithString();
            /*0x7566524*/ int ReadArray(System.Xml.XmlDictionaryReader reader, string localName, string namespaceUri, System.DateTime[] array, int offset, int count);
            /*0x7566560*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, System.DateTime[] array, int offset, int count);
        }

        class DateTimeArrayHelperWithDictionaryString : System.Xml.ArrayHelper<System.Xml.XmlDictionaryString, System.DateTime>
        {
            static /*0x0*/ System.Xml.DateTimeArrayHelperWithDictionaryString Instance;

            static /*0x7566710*/ DateTimeArrayHelperWithDictionaryString();
            /*0x75666c8*/ DateTimeArrayHelperWithDictionaryString();
            /*0x756664c*/ int ReadArray(System.Xml.XmlDictionaryReader reader, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.DateTime[] array, int offset, int count);
            /*0x7566688*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.DateTime[] array, int offset, int count);
        }

        class GuidArrayHelperWithString : System.Xml.ArrayHelper<string, System.Guid>
        {
            static /*0x0*/ System.Xml.GuidArrayHelperWithString Instance;

            static /*0x7566838*/ GuidArrayHelperWithString();
            /*0x75667f0*/ GuidArrayHelperWithString();
            /*0x7566774*/ int ReadArray(System.Xml.XmlDictionaryReader reader, string localName, string namespaceUri, System.Guid[] array, int offset, int count);
            /*0x75667b0*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, System.Guid[] array, int offset, int count);
        }

        class GuidArrayHelperWithDictionaryString : System.Xml.ArrayHelper<System.Xml.XmlDictionaryString, System.Guid>
        {
            static /*0x0*/ System.Xml.GuidArrayHelperWithDictionaryString Instance;

            static /*0x7566960*/ GuidArrayHelperWithDictionaryString();
            /*0x7566918*/ GuidArrayHelperWithDictionaryString();
            /*0x756689c*/ int ReadArray(System.Xml.XmlDictionaryReader reader, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Guid[] array, int offset, int count);
            /*0x75668d8*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Guid[] array, int offset, int count);
        }

        class TimeSpanArrayHelperWithString : System.Xml.ArrayHelper<string, System.TimeSpan>
        {
            static /*0x0*/ System.Xml.TimeSpanArrayHelperWithString Instance;

            static /*0x7566a88*/ TimeSpanArrayHelperWithString();
            /*0x7566a40*/ TimeSpanArrayHelperWithString();
            /*0x75669c4*/ int ReadArray(System.Xml.XmlDictionaryReader reader, string localName, string namespaceUri, System.TimeSpan[] array, int offset, int count);
            /*0x7566a00*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, System.TimeSpan[] array, int offset, int count);
        }

        class TimeSpanArrayHelperWithDictionaryString : System.Xml.ArrayHelper<System.Xml.XmlDictionaryString, System.TimeSpan>
        {
            static /*0x0*/ System.Xml.TimeSpanArrayHelperWithDictionaryString Instance;

            static /*0x7566bb0*/ TimeSpanArrayHelperWithDictionaryString();
            /*0x7566b68*/ TimeSpanArrayHelperWithDictionaryString();
            /*0x7566aec*/ int ReadArray(System.Xml.XmlDictionaryReader reader, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.TimeSpan[] array, int offset, int count);
            /*0x7566b28*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.TimeSpan[] array, int offset, int count);
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

            static /*0x7568f0c*/ EncodingStreamWrapper();
            static /*0x7567ed8*/ System.Text.Encoding GetEncoding(System.Xml.EncodingStreamWrapper.SupportedEncoding e);
            static /*0x7567ff4*/ string GetEncodingName(System.Xml.EncodingStreamWrapper.SupportedEncoding enc);
            static /*0x7567098*/ System.Xml.EncodingStreamWrapper.SupportedEncoding GetSupportedEncoding(System.Text.Encoding encoding);
            static /*0x75682e4*/ System.Xml.EncodingStreamWrapper.SupportedEncoding ReadBOMEncoding(byte b1, byte b2, byte b3, byte b4, bool notOutOfBand, ref int preserve);
            static /*0x7567618*/ void CheckUTF8DeclarationEncoding(byte[] buffer, int offset, int count, System.Xml.EncodingStreamWrapper.SupportedEncoding e, System.Xml.EncodingStreamWrapper.SupportedEncoding expectedEnc);
            static /*0x756857c*/ bool CompareCaseInsensitive(byte[] key, byte[] buffer, int offset);
            static /*0x7568504*/ bool Compare(byte[] key, byte[] buffer, int offset);
            static /*0x75684d8*/ bool IsWhitespace(byte ch);
            static /*0x75674ac*/ void ThrowExpectedEncodingMismatch(System.Xml.EncodingStreamWrapper.SupportedEncoding expEnc, System.Xml.EncodingStreamWrapper.SupportedEncoding actualEnc);
            static /*0x756878c*/ void ThrowEncodingMismatch(string declEnc, System.Xml.EncodingStreamWrapper.SupportedEncoding enc);
            static /*0x75686bc*/ void ThrowEncodingMismatch(string declEnc, string docEnc);
            /*0x7566c14*/ EncodingStreamWrapper(System.IO.Stream stream, System.Text.Encoding encoding);
            /*0x75680bc*/ EncodingStreamWrapper(System.IO.Stream stream, System.Text.Encoding encoding, bool emitBOM);
            /*0x7567c98*/ void SetReadDocumentEncoding(System.Xml.EncodingStreamWrapper.SupportedEncoding e);
            /*0x7567264*/ System.Xml.EncodingStreamWrapper.SupportedEncoding ReadBOMEncoding(bool notOutOfBand);
            /*0x75675a8*/ void FillBuffer(int count);
            /*0x7567c24*/ void EnsureBuffers();
            /*0x756846c*/ void EnsureByteBuffer();
            /*0x75687e4*/ bool get_CanRead();
            /*0x7568818*/ bool get_CanSeek();
            /*0x7568820*/ bool get_CanWrite();
            /*0x7568854*/ long get_Position();
            /*0x756889c*/ void set_Position(long value);
            /*0x75688e4*/ void Close();
            /*0x7568928*/ void Flush();
            /*0x756894c*/ int ReadByte();
            /*0x75689d0*/ int Read(byte[] buffer, int offset, int count);
            /*0x7567d14*/ void CleanupCharBreak();
            /*0x7568c34*/ long Seek(long offset, System.IO.SeekOrigin origin);
            /*0x7568c7c*/ void WriteByte(byte b);
            /*0x7568ce0*/ void Write(byte[] buffer, int offset, int count);
            /*0x7568df4*/ bool get_CanTimeout();
            /*0x7568e14*/ long get_Length();
            /*0x7568e34*/ int get_ReadTimeout();
            /*0x7568e58*/ void set_ReadTimeout(int value);
            /*0x7568e7c*/ int get_WriteTimeout();
            /*0x7568ea0*/ void set_WriteTimeout(int value);
            /*0x7568ec4*/ void SetLength(long value);

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
            /*0x380b26c*/ bool TryLookup(int key, ref System.Xml.XmlDictionaryString result);
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

            static /*0x7569a08*/ PrefixHandle();
            static /*0x75694e0*/ string GetString(System.Xml.PrefixHandleType type);
            static /*0x7569344*/ System.Xml.PrefixHandleType GetAlphaPrefix(int index);
            static /*0x756955c*/ byte[] GetString(System.Xml.PrefixHandleType type, ref int offset, ref int length);
            static /*0x7569904*/ bool op_Equality(System.Xml.PrefixHandle prefix1, string prefix2);
            static /*0x7569914*/ bool op_Equality(System.Xml.PrefixHandle prefix1, System.Xml.XmlDictionaryString prefix2);
            static /*0x7569930*/ bool op_Equality(System.Xml.PrefixHandle prefix1, System.Xml.PrefixHandle prefix2);
            /*0x756922c*/ PrefixHandle(System.Xml.XmlBufferReader bufferReader);
            /*0x756925c*/ void SetValue(System.Xml.PrefixHandleType type);
            /*0x7569264*/ void SetValue(System.Xml.PrefixHandle prefix);
            /*0x7569288*/ void SetValue(int offset, int length);
            /*0x756934c*/ bool get_IsEmpty();
            /*0x756935c*/ bool get_IsXmlns();
            /*0x7569430*/ bool get_IsXml();
            /*0x75694cc*/ bool TryGetShortPrefix(ref System.Xml.PrefixHandleType type);
            /*0x75695e8*/ string GetString(System.Xml.XmlNameTable nameTable);
            /*0x7569670*/ string GetString();
            /*0x75696f0*/ byte[] GetString(ref int offset, ref int length);
            /*0x7569798*/ int CompareTo(System.Xml.PrefixHandle that);
            /*0x75697d8*/ bool Equals2(System.Xml.PrefixHandle prefix2);
            /*0x7569858*/ bool Equals2(string prefix2);
            /*0x75698ec*/ bool Equals2(System.Xml.XmlDictionaryString prefix2);
            /*0x7569940*/ bool Equals(object obj);
            /*0x75699e4*/ string ToString();
            /*0x75699e8*/ int GetHashCode();
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

            static /*0x756ab94*/ StringHandle();
            static /*0x756a9fc*/ bool op_Equality(System.Xml.StringHandle s1, System.Xml.XmlDictionaryString xmlString2);
            static /*0x756aa0c*/ bool op_Equality(System.Xml.StringHandle s1, string s2);
            static /*0x756aa1c*/ bool op_Inequality(System.Xml.StringHandle s1, string s2);
            static /*0x756aa3c*/ bool op_Equality(System.Xml.StringHandle s1, System.Xml.StringHandle s2);
            /*0x756a060*/ StringHandle(System.Xml.XmlBufferReader bufferReader);
            /*0x756a0a0*/ void SetValue(int offset, int length);
            /*0x756a0b0*/ void SetConstantValue(System.Xml.StringHandleConstStringType constStringType);
            /*0x756a0bc*/ void SetValue(int offset, int length, bool escaped);
            /*0x756a0e4*/ void SetValue(System.Xml.StringHandle value);
            /*0x756a100*/ bool get_IsEmpty();
            /*0x756a1a8*/ bool get_IsXmlns();
            /*0x756a2c4*/ void ToPrefixHandle(System.Xml.PrefixHandle prefix);
            /*0x756a2e4*/ string GetString(System.Xml.XmlNameTable nameTable);
            /*0x756a3fc*/ string GetString();
            /*0x756a4ec*/ byte[] GetString(ref int offset, ref int length);
            /*0x756a64c*/ bool TryGetDictionaryString(ref System.Xml.XmlDictionaryString value);
            /*0x756a728*/ string ToString();
            /*0x756a72c*/ bool Equals2(int key2, System.Xml.XmlBufferReader bufferReader2);
            /*0x756a808*/ bool Equals2(System.Xml.XmlDictionaryString xmlString2);
            /*0x756a134*/ bool Equals2(string s2);
            /*0x756a8b4*/ bool Equals2(int offset2, int length2, System.Xml.XmlBufferReader bufferReader2);
            /*0x756a994*/ bool Equals2(System.Xml.StringHandle s2);
            /*0x756aa4c*/ int CompareTo(System.Xml.StringHandle that);
            /*0x756aad0*/ bool Equals(object obj);
            /*0x756ab74*/ int GetHashCode();

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

            static /*0x756be7c*/ UniqueId();
            static /*0x756bcec*/ bool op_Equality(System.Xml.UniqueId id1, System.Xml.UniqueId id2);
            /*0x756acac*/ UniqueId(byte[] guid, int offset);
            /*0x756af0c*/ UniqueId(string value);
            /*0x756b534*/ int get_CharArrayLength();
            /*0x756b54c*/ int UnsafeDecode(short* char2val, char ch1, char ch2);
            /*0x756b580*/ void UnsafeEncode(char* val2char, byte b, char* pch);
            /*0x756b5a8*/ bool get_IsGuid();
            /*0x756afd8*/ void UnsafeParse(char* chars, int charCount);
            /*0x756b5bc*/ int ToCharArray(char[] chars, int offset);
            /*0x756bc54*/ string ToString();
            /*0x756bd84*/ bool Equals(object obj);
            /*0x756be24*/ int GetHashCode();
            /*0x756af04*/ long UnsafeGetInt64(byte* pb);
            /*0x756be6c*/ int UnsafeGetInt32(byte* pb);
            /*0x756bc4c*/ void UnsafeSetInt64(long value, byte* pb);
            /*0x756be74*/ void UnsafeSetInt32(int value, byte* pb);
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

            static /*0x756eac8*/ ValueHandle();
            static /*0x756bf54*/ System.Text.Base64Encoding get_Base64Encoding();
            /*0x756bf1c*/ ValueHandle(System.Xml.XmlBufferReader bufferReader);
            /*0x756c020*/ void SetConstantValue(System.Xml.ValueHandleConstStringType constStringType);
            /*0x756c02c*/ void SetValue(System.Xml.ValueHandleType type);
            /*0x756c034*/ void SetDictionaryValue(int key);
            /*0x756c050*/ void SetCharValue(int ch);
            /*0x756c060*/ void SetQNameValue(int prefix, int key);
            /*0x756c044*/ void SetValue(System.Xml.ValueHandleType type, int offset, int length);
            /*0x756c070*/ bool IsWhitespace();
            /*0x756c1dc*/ System.Type ToType();
            /*0x756c418*/ bool ToBoolean();
            /*0x756ca44*/ int ToInt();
            /*0x756cc18*/ long ToLong();
            /*0x756cd48*/ ulong ToULong();
            /*0x756ce5c*/ float ToSingle();
            /*0x756cffc*/ double ToDouble();
            /*0x756d130*/ decimal ToDecimal();
            /*0x756d310*/ System.DateTime ToDateTime();
            /*0x756d40c*/ System.Xml.UniqueId ToUniqueId();
            /*0x756d500*/ System.TimeSpan ToTimeSpan();
            /*0x756d5d0*/ System.Guid ToGuid();
            /*0x756d6c4*/ string ToString();
            /*0x756d6c8*/ byte[] ToByteArray();
            /*0x756c548*/ string GetString();
            /*0x756dd78*/ bool Equals2(string str, bool checkLower);
            /*0x756dea4*/ void Sign(System.Xml.XmlSigningNodeWriter writer);
            /*0x756dcb4*/ object[] ToList();
            /*0x756e0a0*/ object ToObject();
            /*0x756e2d4*/ bool TryReadBase64(byte[] buffer, int offset, int count, ref int actual);
            /*0x756e4fc*/ bool TryReadChars(char[] chars, int offset, int count, ref int actual);
            /*0x756e92c*/ bool TryReadUnicodeChars(char[] chars, int offset, int count, ref int actual);
            /*0x756ea48*/ bool TryGetDictionaryString(ref System.Xml.XmlDictionaryString value);
            /*0x756ea98*/ bool TryGetByteArrayLength(ref int length);
            /*0x756dadc*/ string GetCharsText();
            /*0x756db6c*/ string GetUnicodeCharsText();
            /*0x756db90*/ string GetEscapedCharsText();
            /*0x756dbb4*/ string GetCharText();
            /*0x756eac0*/ int GetChar();
            /*0x756c524*/ int GetInt8();
            /*0x756cb88*/ int GetInt16();
            /*0x756cbac*/ int GetInt32();
            /*0x756cbd0*/ long GetInt64();
            /*0x756cbf4*/ ulong GetUInt64();
            /*0x756cfb4*/ float GetSingle();
            /*0x756cfd8*/ double GetDouble();
            /*0x756d2ec*/ decimal GetDecimal();
            /*0x756d4dc*/ System.Xml.UniqueId GetUniqueId();
            /*0x756d6a0*/ System.Guid GetGuid();
            /*0x756daac*/ void GetBase64(byte[] buffer, int offset, int count);
            /*0x756dc90*/ System.Xml.XmlDictionaryString GetDictionaryString();
            /*0x756dcd8*/ string GetQNameDictionaryText();
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

            static /*0x7576408*/ XmlBaseReader();
            static /*0x756f1a8*/ System.Text.BinHexEncoding get_BinHexEncoding();
            static /*0x756f26c*/ System.Text.Base64Encoding get_Base64Encoding();
            /*0x756ec74*/ XmlBaseReader();
            /*0x756f330*/ System.Xml.XmlBufferReader get_BufferReader();
            /*0x756f338*/ System.Xml.XmlDictionaryReaderQuotas get_Quotas();
            /*0x756f340*/ System.Xml.XmlBaseReader.XmlNode get_Node();
            /*0x756f348*/ void MoveToNode(System.Xml.XmlBaseReader.XmlNode node);
            /*0x756f39c*/ void MoveToInitial(System.Xml.XmlDictionaryReaderQuotas quotas);
            /*0x756f5a0*/ System.Xml.XmlBaseReader.XmlDeclarationNode MoveToDeclaration();
            /*0x756fa28*/ bool CheckStandalone(int attr);
            /*0x756f88c*/ bool CheckDeclAttribute(int index, string localName, string value, bool checkLower, string valueSR);
            /*0x756fd30*/ System.Xml.XmlBaseReader.XmlCommentNode MoveToComment();
            /*0x756fee4*/ System.Xml.XmlBaseReader.XmlCDataNode MoveToCData();
            /*0x7570098*/ System.Xml.XmlBaseReader.XmlAtomicTextNode MoveToAtomicText();
            /*0x75700b4*/ System.Xml.XmlBaseReader.XmlComplexTextNode MoveToComplexText();
            /*0x7570268*/ System.Xml.XmlBaseReader.XmlTextNode MoveToWhitespaceText();
            /*0x7570440*/ System.Xml.XmlBaseReader.XmlElementNode get_ElementNode();
            /*0x7570484*/ void MoveToEndElement();
            /*0x75704fc*/ void MoveToEndOfFile();
            /*0x7570570*/ System.Xml.XmlBaseReader.XmlElementNode EnterScope();
            /*0x7570764*/ void ExitScope();
            /*0x75708f8*/ System.Xml.XmlBaseReader.XmlAttributeNode AddAttribute(System.Xml.XmlBaseReader.QNameType qnameType, bool isAtomicValue);
            /*0x7570b98*/ System.Xml.XmlBaseReader.Namespace AddNamespace();
            /*0x7570d3c*/ System.Xml.XmlBaseReader.XmlAttributeNode AddAttribute();
            /*0x7570d48*/ System.Xml.XmlBaseReader.XmlAttributeNode AddXmlAttribute();
            /*0x7570d54*/ System.Xml.XmlBaseReader.XmlAttributeNode AddXmlnsAttribute(System.Xml.XmlBaseReader.Namespace ns);
            /*0x7571100*/ void FixXmlAttribute(System.Xml.XmlBaseReader.XmlAttributeNode attributeNode);
            /*0x7571334*/ bool get_OutsideRootElement();
            /*0x7571344*/ bool get_CanReadValueChunk();
            /*0x757134c*/ string get_BaseURI();
            /*0x7571364*/ bool get_IsDefault();
            /*0x757136c*/ int get_AttributeCount();
            /*0x7571398*/ void Close();
            /*0x757154c*/ int get_Depth();
            /*0x7571570*/ bool get_EOF();
            /*0x7571594*/ System.Xml.XmlBaseReader.XmlAttributeNode GetAttributeNode(int index);
            /*0x75716ec*/ System.Xml.XmlBaseReader.XmlAttributeNode GetAttributeNode(string name);
            /*0x75719e4*/ System.Xml.XmlBaseReader.XmlAttributeNode GetAttributeNode(string localName, string namespaceUri);
            /*0x7571c2c*/ string GetAttribute(int index);
            /*0x7571c7c*/ string GetAttribute(string name);
            /*0x7571c98*/ string GetAttribute(string localName, string namespaceUri);
            /*0x7571cb4*/ bool get_IsEmptyElement();
            /*0x7571cd0*/ string get_LocalName();
            /*0x7571e28*/ string LookupNamespace(string prefix);
            /*0x757201c*/ System.Xml.XmlBaseReader.Namespace LookupNamespace(System.Xml.PrefixHandle prefix);
            /*0x757219c*/ void ProcessAttributes();
            /*0x75721b4*/ void ProcessAttributes(System.Xml.XmlBaseReader.XmlAttributeNode[] attributeNodes, int attributeCount);
            /*0x7572590*/ void CheckAttributes(System.Xml.XmlBaseReader.XmlAttributeNode[] attributeNodes, int attributeCount);
            /*0x75727e4*/ void MoveToAttribute(int index);
            /*0x7572814*/ bool MoveToAttribute(string name);
            /*0x7572854*/ bool MoveToAttribute(string localName, string namespaceUri);
            /*0x7572894*/ bool MoveToElement();
            /*0x757290c*/ System.Xml.XmlNodeType MoveToContent();
            /*0x7572a00*/ bool MoveToFirstAttribute();
            /*0x7572a54*/ bool MoveToNextAttribute();
            /*0x7572abc*/ string get_NamespaceURI();
            /*0x7572bc4*/ System.Xml.XmlNameTable get_NameTable();
            /*0x7572df0*/ System.Xml.XmlNodeType get_NodeType();
            /*0x7572e0c*/ string get_Prefix();
            /*0x7572efc*/ char get_QuoteChar();
            /*0x7571d14*/ string GetLocalName(bool enforceAtomization);
            /*0x7572b00*/ string GetNamespaceUri(bool enforceAtomization);
            /*0x7572f18*/ bool IsLocalName(string localName);
            /*0x7573044*/ bool IsLocalName(System.Xml.XmlDictionaryString localName);
            /*0x757316c*/ bool IsNamespaceUri(string namespaceUri);
            /*0x757322c*/ bool IsNamespaceUri(System.Xml.XmlDictionaryString namespaceUri);
            /*0x75732f0*/ bool IsStartElement();
            /*0x7573378*/ bool IsStartElement(string localName, string namespaceUri);
            /*0x7573450*/ bool IsStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri);
            /*0x7573564*/ int IndexOfLocalName(System.Xml.XmlDictionaryString[] localNames, System.Xml.XmlDictionaryString namespaceUri);
            /*0x757379c*/ int ReadValueChunk(char[] chars, int offset, int count);
            /*0x7573ad8*/ string ReadElementContentAsString();
            /*0x7573b88*/ string ReadElementString();
            /*0x7573c28*/ void ReadStartElement();
            /*0x7573c74*/ void ReadEndElement();
            /*0x7573dac*/ bool ReadAttributeValue();
            /*0x7573ddc*/ System.Xml.ReadState get_ReadState();
            /*0x7573df8*/ void SkipValue(System.Xml.XmlBaseReader.XmlNode node);
            /*0x7573e28*/ bool TryGetBase64ContentLength(ref int length);
            /*0x7573e98*/ byte[] ReadContentAsBase64();
            /*0x7573f84*/ int ReadContentAsBase64(byte[] buffer, int offset, int count);
            /*0x75748f4*/ int ReadContentAsBinHex(byte[] buffer, int offset, int count);
            /*0x757430c*/ int ReadBytes(System.Text.Encoding encoding, int byteBlock, int charBlock, byte[] buffer, int offset, int byteCount, bool readContent);
            /*0x7574c64*/ string ReadContentAsString();
            /*0x7574d3c*/ bool ReadContentAsBoolean();
            /*0x7574e08*/ long ReadContentAsLong();
            /*0x7574ed4*/ int ReadContentAsInt();
            /*0x7574fa0*/ System.DateTime ReadContentAsDateTime();
            /*0x757506c*/ double ReadContentAsDouble();
            /*0x7575144*/ float ReadContentAsFloat();
            /*0x757521c*/ decimal ReadContentAsDecimal();
            /*0x75752f0*/ System.Xml.UniqueId ReadContentAsUniqueId();
            /*0x75753bc*/ System.TimeSpan ReadContentAsTimeSpan();
            /*0x7575488*/ System.Guid ReadContentAsGuid();
            /*0x757555c*/ object ReadContentAsObject();
            /*0x75755dc*/ object ReadContentAs(System.Type type, System.Xml.IXmlNamespaceResolver namespaceResolver);
            /*0x7575b9c*/ void ResolveEntity();
            /*0x7575c04*/ void Skip();
            /*0x7575ce4*/ string get_Value();
            /*0x7575d24*/ System.Type get_ValueType();
            /*0x7575e14*/ string get_XmlLang();
            /*0x7575e30*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x7575e4c*/ bool TryGetLocalNameAsDictionaryString(ref System.Xml.XmlDictionaryString localName);
            /*0x7575ea0*/ bool TryGetNamespaceUriAsDictionaryString(ref System.Xml.XmlDictionaryString localName);
            /*0x7575efc*/ bool TryGetValueAsDictionaryString(ref System.Xml.XmlDictionaryString value);
            /*0x7575f50*/ string GetOpenElements();
            /*0x7574bc8*/ char[] GetCharBuffer(int count);
            /*0x7576040*/ void SignStartElement(System.Xml.XmlSigningNodeWriter writer);
            /*0x75760c8*/ void SignAttribute(System.Xml.XmlSigningNodeWriter writer, System.Xml.XmlBaseReader.XmlAttributeNode attributeNode);
            /*0x75761e8*/ void SignEndElement(System.Xml.XmlSigningNodeWriter writer);
            /*0x7576274*/ void SignNode(System.Xml.XmlSigningNodeWriter writer);
            /*0x75763f4*/ void SignNode();

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

                /*0x757694c*/ XmlNode(System.Xml.XmlNodeType nodeType, System.Xml.PrefixHandle prefix, System.Xml.StringHandle localName, System.Xml.ValueHandle value, System.Xml.XmlBaseReader.XmlNode.XmlNodeFlags nodeFlags, System.Xml.ReadState readState, System.Xml.XmlBaseReader.XmlAttributeTextNode attributeTextNode, int depthDelta);
                /*0x7576acc*/ System.Xml.ReadState get_ReadState();
                /*0x7576ad4*/ System.Xml.StringHandle get_LocalName();
                /*0x7576adc*/ System.Xml.PrefixHandle get_Prefix();
                /*0x7576ae4*/ bool get_CanGetAttribute();
                /*0x7576aec*/ bool get_CanMoveToElement();
                /*0x7576af4*/ System.Xml.XmlBaseReader.XmlAttributeTextNode get_AttributeText();
                /*0x7576afc*/ bool get_SkipValue();
                /*0x7576b04*/ System.Xml.ValueHandle get_Value();
                /*0x7576b0c*/ int get_DepthDelta();
                /*0x7576b14*/ bool get_HasContent();
                /*0x7576b1c*/ System.Xml.XmlNodeType get_NodeType();
                /*0x7576b24*/ void set_NodeType(System.Xml.XmlNodeType value);
                /*0x7576b2c*/ System.Xml.XmlBaseReader.QNameType get_QNameType();
                /*0x7576b34*/ void set_QNameType(System.Xml.XmlBaseReader.QNameType value);
                /*0x7576b3c*/ System.Xml.XmlBaseReader.Namespace get_Namespace();
                /*0x7576b44*/ void set_Namespace(System.Xml.XmlBaseReader.Namespace value);
                /*0x7576b4c*/ bool get_IsAtomicValue();
                /*0x7576b54*/ void set_IsAtomicValue(bool value);
                /*0x7576b60*/ bool get_ExitScope();
                /*0x7576b68*/ void set_ExitScope(bool value);
                /*0x7576b74*/ bool get_IsEmptyElement();
                /*0x7576b7c*/ void set_IsEmptyElement(bool value);
                /*0x7576b88*/ char get_QuoteChar();
                /*0x7576b90*/ void set_QuoteChar(char value);
                /*0x7572f8c*/ bool IsLocalName(string localName);
                /*0x75730b8*/ bool IsLocalName(System.Xml.XmlDictionaryString localName);
                /*0x75731b8*/ bool IsNamespaceUri(string ns);
                /*0x7573278*/ bool IsNamespaceUri(System.Xml.XmlDictionaryString ns);
                /*0x7571b14*/ bool IsLocalNameAndNamespaceUri(string localName, string ns);
                /*0x75718b0*/ bool IsPrefixAndLocalName(string prefix, string localName);
                /*0x7575e64*/ bool TryGetLocalNameAsDictionaryString(ref System.Xml.XmlDictionaryString localName);
                /*0x7575eb8*/ bool TryGetNamespaceUriAsDictionaryString(ref System.Xml.XmlDictionaryString ns);
                /*0x7575f14*/ bool TryGetValueAsDictionaryString(ref System.Xml.XmlDictionaryString value);
                /*0x7571c44*/ string get_ValueAsString();

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

                /*0x756ef78*/ XmlElementNode(System.Xml.XmlBufferReader bufferReader);
                /*0x7576cd8*/ XmlElementNode(System.Xml.PrefixHandle prefix, System.Xml.StringHandle localName, System.Xml.ValueHandle value);
                /*0x7576de0*/ System.Xml.XmlBaseReader.XmlEndElementNode get_EndElement();
                /*0x7576de8*/ int get_BufferOffset();
                /*0x7576df0*/ void set_BufferOffset(int value);
            }

            class XmlAttributeNode : System.Xml.XmlBaseReader.XmlNode
            {
                /*0x7570a90*/ XmlAttributeNode(System.Xml.XmlBufferReader bufferReader);
                /*0x7576df8*/ XmlAttributeNode(System.Xml.PrefixHandle prefix, System.Xml.StringHandle localName, System.Xml.ValueHandle value);
            }

            class XmlEndElementNode : System.Xml.XmlBaseReader.XmlNode
            {
                /*0x7576da4*/ XmlEndElementNode(System.Xml.PrefixHandle prefix, System.Xml.StringHandle localName, System.Xml.ValueHandle value);
            }

            class XmlTextNode : System.Xml.XmlBaseReader.XmlNode
            {
                /*0x7576ef4*/ XmlTextNode(System.Xml.XmlNodeType nodeType, System.Xml.PrefixHandle prefix, System.Xml.StringHandle localName, System.Xml.ValueHandle value, System.Xml.XmlBaseReader.XmlNode.XmlNodeFlags nodeFlags, System.Xml.ReadState readState, System.Xml.XmlBaseReader.XmlAttributeTextNode attributeTextNode, int depthDelta);
            }

            class XmlAtomicTextNode : System.Xml.XmlBaseReader.XmlTextNode
            {
                /*0x756f080*/ XmlAtomicTextNode(System.Xml.XmlBufferReader bufferReader);
            }

            class XmlComplexTextNode : System.Xml.XmlBaseReader.XmlTextNode
            {
                /*0x7570140*/ XmlComplexTextNode(System.Xml.XmlBufferReader bufferReader);
            }

            class XmlWhitespaceTextNode : System.Xml.XmlBaseReader.XmlTextNode
            {
                /*0x7570318*/ XmlWhitespaceTextNode(System.Xml.XmlBufferReader bufferReader);
            }

            class XmlCDataNode : System.Xml.XmlBaseReader.XmlTextNode
            {
                /*0x756ff70*/ XmlCDataNode(System.Xml.XmlBufferReader bufferReader);
            }

            class XmlAttributeTextNode : System.Xml.XmlBaseReader.XmlTextNode
            {
                /*0x7576eb8*/ XmlAttributeTextNode(System.Xml.PrefixHandle prefix, System.Xml.StringHandle localName, System.Xml.ValueHandle value);
            }

            class XmlInitialNode : System.Xml.XmlBaseReader.XmlNode
            {
                /*0x75765d4*/ XmlInitialNode(System.Xml.XmlBufferReader bufferReader);
            }

            class XmlDeclarationNode : System.Xml.XmlBaseReader.XmlNode
            {
                /*0x756fc08*/ XmlDeclarationNode(System.Xml.XmlBufferReader bufferReader);
            }

            class XmlCommentNode : System.Xml.XmlBaseReader.XmlNode
            {
                /*0x756fdbc*/ XmlCommentNode(System.Xml.XmlBufferReader bufferReader);
            }

            class XmlEndOfFileNode : System.Xml.XmlBaseReader.XmlNode
            {
                /*0x75766fc*/ XmlEndOfFileNode(System.Xml.XmlBufferReader bufferReader);
            }

            class XmlClosedNode : System.Xml.XmlBaseReader.XmlNode
            {
                /*0x7576824*/ XmlClosedNode(System.Xml.XmlBufferReader bufferReader);
            }

            class AttributeSorter : System.Collections.IComparer
            {
                /*0x10*/ object[] indeces;
                /*0x18*/ System.Xml.XmlBaseReader.XmlAttributeNode[] attributeNodes;
                /*0x20*/ int attributeCount;
                /*0x24*/ int attributeIndex1;
                /*0x28*/ int attributeIndex2;

                /*0x757276c*/ AttributeSorter();
                /*0x7572774*/ bool Sort(System.Xml.XmlBaseReader.XmlAttributeNode[] attributeNodes, int attributeCount);
                /*0x75727d0*/ void GetIndeces(ref int attributeIndex1, ref int attributeIndex2);
                /*0x7571528*/ void Close();
                /*0x7576f00*/ bool Sort();
                /*0x7577060*/ bool IsSorted();
                /*0x7577198*/ int Compare(object obj1, object obj2);
                /*0x75772d4*/ int CompareQNameType(System.Xml.XmlBaseReader.QNameType type1, System.Xml.XmlBaseReader.QNameType type2);
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

                static /*0x7577860*/ NamespaceManager();
                static /*0x75772dc*/ System.Xml.XmlBaseReader.Namespace get_XmlNamespace();
                static /*0x757757c*/ System.Xml.XmlBaseReader.Namespace get_EmptyNamespace();
                /*0x756ee28*/ NamespaceManager(System.Xml.XmlBufferReader bufferReader);
                /*0x75714b8*/ void Close();
                /*0x75775d4*/ string get_XmlLang();
                /*0x75775dc*/ System.Xml.XmlSpace get_XmlSpace();
                /*0x756f47c*/ void Clear();
                /*0x7570754*/ void EnterScope();
                /*0x75707a0*/ void ExitScope();
                /*0x75712e4*/ void AddLangAttribute(string lang);
                /*0x7571310*/ void AddSpaceAttribute(System.Xml.XmlSpace space);
                /*0x75775e4*/ void AddAttribute();
                /*0x757104c*/ void Register(System.Xml.XmlBaseReader.Namespace nameSpace);
                /*0x7570bb0*/ System.Xml.XmlBaseReader.Namespace AddNamespace();
                /*0x7577784*/ System.Xml.XmlBaseReader.Namespace LookupNamespace(System.Xml.PrefixHandleType prefix);
                /*0x7572070*/ System.Xml.XmlBaseReader.Namespace LookupNamespace(System.Xml.PrefixHandle prefix);
                /*0x7571ee4*/ System.Xml.XmlBaseReader.Namespace LookupNamespace(string prefix);
                /*0x75777b4*/ bool TryGetShortPrefix(string s, ref System.Xml.PrefixHandleType shortPrefix);

                class XmlAttribute
                {
                    /*0x10*/ System.Xml.XmlSpace space;
                    /*0x18*/ string lang;
                    /*0x20*/ int depth;

                    /*0x7577770*/ XmlAttribute();
                    /*0x757793c*/ int get_Depth();
                    /*0x7577944*/ void set_Depth(int value);
                    /*0x757794c*/ string get_XmlLang();
                    /*0x7577954*/ void set_XmlLang(string value);
                    /*0x757795c*/ System.Xml.XmlSpace get_XmlSpace();
                    /*0x7577964*/ void set_XmlSpace(System.Xml.XmlSpace value);
                }
            }

            class Namespace
            {
                /*0x10*/ System.Xml.PrefixHandle prefix;
                /*0x18*/ System.Xml.StringHandle uri;
                /*0x20*/ int depth;
                /*0x28*/ System.Xml.XmlBaseReader.Namespace outerUri;
                /*0x30*/ string uriString;

                /*0x7577480*/ Namespace(System.Xml.XmlBufferReader bufferReader);
                /*0x7577778*/ void Clear();
                /*0x757796c*/ int get_Depth();
                /*0x7577974*/ void set_Depth(int value);
                /*0x757797c*/ System.Xml.PrefixHandle get_Prefix();
                /*0x7576b98*/ bool IsUri(string s);
                /*0x7576c34*/ bool IsUri(System.Xml.XmlDictionaryString s);
                /*0x7577984*/ System.Xml.StringHandle get_Uri();
                /*0x757798c*/ System.Xml.XmlBaseReader.Namespace get_OuterUri();
                /*0x7577994*/ void set_OuterUri(System.Xml.XmlBaseReader.Namespace value);
            }

            class QuotaNameTable : System.Xml.XmlNameTable
            {
                /*0x10*/ System.Xml.XmlDictionaryReader reader;
                /*0x18*/ System.Xml.XmlNameTable nameTable;
                /*0x20*/ int maxCharCount;
                /*0x24*/ int charCount;

                /*0x7572d5c*/ QuotaNameTable(System.Xml.XmlDictionaryReader reader, int maxCharCount);
                /*0x757799c*/ string Get(char[] chars, int offset, int count);
                /*0x75779bc*/ string Get(string value);
                /*0x75779dc*/ void Add(int charCount);
                /*0x7577a20*/ string Add(char[] chars, int offset, int count);
                /*0x7577abc*/ string Add(string value);
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

            static /*0x757c7d0*/ XmlBaseWriter();
            static /*0x7577e5c*/ System.Text.BinHexEncoding get_BinHexEncoding();
            /*0x7577b44*/ XmlBaseWriter();
            /*0x7577bbc*/ void SetOutput(System.Xml.XmlStreamNodeWriter writer);
            /*0x7577c70*/ void Flush();
            /*0x7577d18*/ void Close();
            /*0x7577ca0*/ bool get_IsClosed();
            /*0x7577cb0*/ void ThrowClosed();
            /*0x7577f28*/ string get_XmlLang();
            /*0x7577f44*/ System.Xml.XmlSpace get_XmlSpace();
            /*0x7577f60*/ System.Xml.WriteState get_WriteState();
            /*0x7577f68*/ void WriteXmlnsAttribute(string prefix, string ns);
            /*0x75783b8*/ void WriteXmlnsAttribute(string prefix, System.Xml.XmlDictionaryString ns);
            /*0x7578580*/ void StartAttribute(ref string prefix, string localName, string ns, System.Xml.XmlDictionaryString xNs);
            /*0x7578d4c*/ void WriteStartAttribute(string prefix, string localName, string namespaceUri);
            /*0x7578da4*/ void WriteStartAttribute(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri);
            /*0x7578e20*/ void WriteEndAttribute();
            /*0x7579298*/ void WriteComment(string text);
            /*0x7579530*/ void WriteFullEndElement();
            /*0x75796c4*/ void WriteCData(string text);
            /*0x7579924*/ void WriteDocType(string name, string pubid, string sysid, string subset);
            /*0x75799e0*/ void StartElement(ref string prefix, string localName, string ns, System.Xml.XmlDictionaryString xNs);
            /*0x7579f20*/ void WriteStartElement(string prefix, string localName, string namespaceUri);
            /*0x7579f6c*/ void WriteStartElement(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri);
            /*0x7579fdc*/ void WriteEndElement();
            /*0x7579db0*/ System.Xml.XmlBaseWriter.Element EnterScope();
            /*0x757a1d8*/ void ExitScope();
            /*0x757a24c*/ void FlushElement();
            /*0x7579504*/ void StartComment();
            /*0x757952c*/ void EndComment();
            /*0x7579884*/ void StartContent();
            /*0x757a274*/ void StartContent(char ch);
            /*0x757a364*/ void StartContent(string s);
            /*0x757a4a0*/ void StartContent(char[] chars, int offset, int count);
            /*0x757a2c8*/ void VerifyWhitespace(char ch);
            /*0x757a3b8*/ void VerifyWhitespace(string s);
            /*0x757a510*/ void VerifyWhitespace(char[] chars, int offset, int count);
            /*0x757a5f4*/ bool IsWhitespace(char ch);
            /*0x7579920*/ void EndContent();
            /*0x7577e28*/ void AutoComplete(System.Xml.WriteState writeState);
            /*0x757a634*/ void EndStartElement();
            /*0x757a670*/ string LookupPrefix(string ns);
            /*0x757a6f8*/ string GetQualifiedNamePrefix(string namespaceUri, System.Xml.XmlDictionaryString xNs);
            /*0x757a804*/ void WriteQualifiedName(string localName, string namespaceUri);
            /*0x757a998*/ void WriteQualifiedName(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri);
            /*0x757abb8*/ void WriteStartDocument();
            /*0x757ad28*/ void WriteStartDocument(bool standalone);
            /*0x757ad4c*/ void WriteProcessingInstruction(string name, string text);
            /*0x7577dd0*/ void FinishDocument();
            /*0x757ae80*/ void WriteEndDocument();
            /*0x757af20*/ void WriteEntityRef(string name);
            /*0x757afdc*/ void WriteWhitespace(string whitespace);
            /*0x757b10c*/ void WriteString(string value);
            /*0x757b1cc*/ void WriteString(System.Xml.XmlDictionaryString value);
            /*0x757b2a4*/ void WriteChars(char[] chars, int offset, int count);
            /*0x757b4f4*/ void WriteRaw(string value);
            /*0x757b5ac*/ void WriteRaw(char[] chars, int offset, int count);
            /*0x757b7fc*/ void WriteCharEntity(char ch);
            /*0x757b928*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
            /*0x757ba44*/ void WriteValue(string value);
            /*0x757ba6c*/ void WriteValue(int value);
            /*0x757bb3c*/ void WriteValue(long value);
            /*0x757bc0c*/ void WriteValue(bool value);
            /*0x757bcdc*/ void WriteValue(decimal value);
            /*0x757bdc4*/ void WriteValue(float value);
            /*0x757bea0*/ void WriteValue(double value);
            /*0x757bf7c*/ void WriteValue(System.DateTime value);
            /*0x757c04c*/ void WriteValue(System.Guid value);
            /*0x757c134*/ void WriteValue(System.TimeSpan value);
            /*0x757c204*/ void WriteBase64(byte[] buffer, int offset, int count);
            /*0x757c640*/ void WriteBinHex(byte[] buffer, int offset, int count);
            /*0x7579284*/ void FlushBase64();
            /*0x757c700*/ void FlushTrailBytes();
            /*0x757c4c0*/ void EnsureBufferBounds(byte[] buffer, int offset, int count);
            /*0x7578134*/ string GeneratePrefix(string ns, System.Xml.XmlDictionaryString xNs);
            /*0x757ab80*/ void WriteAttributeText(string value);

            class Element
            {
                /*0x10*/ string prefix;
                /*0x18*/ string localName;
                /*0x20*/ int prefixId;

                /*0x757cdec*/ Element();
                /*0x757cd8c*/ string get_Prefix();
                /*0x757cd94*/ void set_Prefix(string value);
                /*0x757cd9c*/ string get_LocalName();
                /*0x757cda4*/ void set_LocalName(string value);
                /*0x757cdac*/ int get_PrefixId();
                /*0x757cdb4*/ void set_PrefixId(int value);
                /*0x757cdbc*/ void Clear();
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

                /*0x757cdf4*/ NamespaceManager();
                /*0x757cf18*/ string get_XmlLang();
                /*0x757cf20*/ System.Xml.XmlSpace get_XmlSpace();
                /*0x757cf28*/ void Clear();
                /*0x757d018*/ void Close();
                /*0x757d09c*/ void DeclareNamespaces(System.Xml.XmlNodeWriter writer);
                /*0x757d1a8*/ void EnterScope();
                /*0x757d1b8*/ void ExitScope();
                /*0x757d330*/ void AddLangAttribute(string lang);
                /*0x757d4e8*/ void AddSpaceAttribute(System.Xml.XmlSpace space);
                /*0x757d35c*/ void AddAttribute();
                /*0x757d514*/ string AddNamespace(string uri, System.Xml.XmlDictionaryString uriDictionaryString);
                /*0x757d688*/ void AddNamespaceIfNotDeclared(string prefix, string uri, System.Xml.XmlDictionaryString uriDictionaryString);
                /*0x757d6e8*/ void AddNamespace(string prefix, string uri, System.Xml.XmlDictionaryString uriDictionaryString);
                /*0x757de94*/ string LookupPrefix(string ns);
                /*0x757e16c*/ string LookupAttributePrefix(string ns);
                /*0x757dca8*/ string LookupNamespace(string prefix);

                class XmlAttribute
                {
                    /*0x10*/ System.Xml.XmlSpace space;
                    /*0x18*/ string lang;
                    /*0x20*/ int depth;

                    /*0x757d50c*/ XmlAttribute();
                    /*0x757e38c*/ int get_Depth();
                    /*0x757e394*/ void set_Depth(int value);
                    /*0x757e39c*/ string get_XmlLang();
                    /*0x757e3a4*/ void set_XmlLang(string value);
                    /*0x757e3ac*/ System.Xml.XmlSpace get_XmlSpace();
                    /*0x757e3b4*/ void set_XmlSpace(System.Xml.XmlSpace value);
                    /*0x757d324*/ void Clear();
                }

                class Namespace
                {
                    /*0x10*/ string prefix;
                    /*0x18*/ string ns;
                    /*0x20*/ System.Xml.XmlDictionaryString xNs;
                    /*0x28*/ int depth;
                    /*0x2c*/ char prefixChar;

                    /*0x757ceb8*/ Namespace();
                    /*0x757d2e0*/ void Clear();
                    /*0x757e3bc*/ int get_Depth();
                    /*0x757e3c4*/ void set_Depth(int value);
                    /*0x757e3cc*/ char get_PrefixChar();
                    /*0x757e3d4*/ string get_Prefix();
                    /*0x757cec0*/ void set_Prefix(string value);
                    /*0x757e3dc*/ string get_Uri();
                    /*0x757e3e4*/ void set_Uri(string value);
                    /*0x757e3ec*/ System.Xml.XmlDictionaryString get_UriDictionaryString();
                    /*0x757e3f4*/ void set_UriDictionaryString(System.Xml.XmlDictionaryString value);
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

            /*0x757e3fc*/ bool TryLookup(int key, ref System.Xml.XmlDictionaryString result);
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

            static /*0x758197c*/ XmlBufferReader();
            static /*0x757e540*/ System.Xml.XmlBufferReader get_Empty();
            /*0x757e4d0*/ XmlBufferReader(System.Xml.XmlDictionaryReader reader);
            /*0x757e500*/ XmlBufferReader(byte[] buffer);
            /*0x757e598*/ byte[] get_Buffer();
            /*0x757e5a0*/ bool get_IsStreamed();
            /*0x757e5b0*/ void SetBuffer(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary, System.Xml.XmlBinaryReaderSession session);
            /*0x757e664*/ void SetBuffer(System.IO.Stream stream, byte[] buffer, int offset, int count, System.Xml.IXmlDictionary dictionary, System.Xml.XmlBinaryReaderSession session);
            /*0x757e6e0*/ void Close();
            /*0x757e7c0*/ bool get_EndOfFile();
            /*0x757e8b0*/ byte GetByte();
            /*0x757e934*/ void SkipByte();
            /*0x757e8f8*/ byte GetByteHard();
            /*0x757e97c*/ byte[] GetBuffer(int count, ref int offset);
            /*0x757e9d8*/ byte[] GetBuffer(int count, ref int offset, ref int offsetMax);
            /*0x757ec48*/ byte[] GetBuffer(ref int offset, ref int offsetMax);
            /*0x757e9b8*/ byte[] GetBufferHard(int count, ref int offset);
            /*0x757e954*/ void EnsureByte();
            /*0x757e7f0*/ bool TryEnsureByte();
            /*0x757ec60*/ void EnsureBytes(int count);
            /*0x757ea8c*/ bool TryEnsureBytes(int count);
            /*0x757e944*/ void Advance(int count);
            /*0x757ec88*/ void SetWindow(int windowOffset, int windowLength);
            /*0x757ed5c*/ int get_Offset();
            /*0x757ed64*/ void set_Offset(int value);
            /*0x757ed6c*/ int ReadBytes(int count);
            /*0x757edbc*/ int ReadMultiByteUInt31();
            /*0x757ee74*/ int ReadUInt8();
            /*0x757ee98*/ int ReadUInt16();
            /*0x757ef14*/ int ReadInt32();
            /*0x757efc4*/ int ReadUInt31();
            /*0x757f000*/ char[] GetCharBuffer(int count);
            /*0x757f09c*/ int GetChars(int offset, int length, char[] chars);
            /*0x757f2f0*/ int GetChars(int offset, int length, char[] chars, int charOffset);
            /*0x757f404*/ string GetString(int offset, int length);
            /*0x757f460*/ string GetUnicodeString(int offset, int length);
            /*0x757f610*/ string GetString(int offset, int length, System.Xml.XmlNameTable nameTable);
            /*0x757f67c*/ int GetEscapedChars(int offset, int length, char[] chars);
            /*0x757f8b4*/ bool IsAttrChar(int ch);
            /*0x757fa40*/ string GetEscapedString(int offset, int length);
            /*0x757fa9c*/ string GetEscapedString(int offset, int length, System.Xml.XmlNameTable nameTable);
            /*0x757fb08*/ int GetLessThanCharEntity(int offset, int length);
            /*0x757fb78*/ int GetGreaterThanCharEntity(int offset, int length);
            /*0x757fbe8*/ int GetQuoteCharEntity(int offset, int length);
            /*0x757fc90*/ int GetAmpersandCharEntity(int offset, int length);
            /*0x757fd1c*/ int GetApostropheCharEntity(int offset, int length);
            /*0x757fdc4*/ int GetDecimalCharEntity(int offset, int length);
            /*0x757fe78*/ int GetHexCharEntity(int offset, int length);
            /*0x757f8dc*/ int GetCharEntity(int offset, int length);
            /*0x757ff48*/ bool IsWhitespaceKey(int key);
            /*0x758015c*/ bool IsWhitespaceUTF8(int offset, int length);
            /*0x7580254*/ bool IsWhitespaceUnicode(int offset, int length);
            /*0x758037c*/ bool Equals2(int key1, int key2, System.Xml.XmlBufferReader bufferReader2);
            /*0x75803e0*/ bool Equals2(int key1, System.Xml.XmlDictionaryString xmlString2);
            /*0x7580438*/ bool Equals2(int offset1, int length1, byte[] buffer2);
            /*0x75804cc*/ bool Equals2(int offset1, int length1, System.Xml.XmlBufferReader bufferReader2, int offset2, int length2);
            /*0x7580574*/ bool Equals2(int offset1, int length1, int offset2, int length2);
            /*0x7580624*/ bool Equals2(int offset1, int length1, string s2);
            /*0x7580984*/ int Compare(int offset1, int length1, int offset2, int length2);
            /*0x7580a80*/ byte GetByte(int offset);
            /*0x7580ab0*/ int GetInt8(int offset);
            /*0x7580330*/ int GetInt16(int offset);
            /*0x7580ac4*/ int GetInt32(int offset);
            /*0x7580b3c*/ long GetInt64(int offset);
            /*0x7580c14*/ ulong GetUInt64(int offset);
            /*0x7580c18*/ float GetSingle(int offset);
            /*0x7580ca4*/ double GetDouble(int offset);
            /*0x7580da0*/ decimal GetDecimal(int offset);
            /*0x7580f0c*/ System.Xml.UniqueId GetUniqueId(int offset);
            /*0x7580f7c*/ System.Guid GetGuid(int offset);
            /*0x758102c*/ void GetBase64(int srcOffset, byte[] buffer, int dstOffset, int count);
            /*0x7581038*/ System.Xml.XmlBinaryNodeType GetNodeType();
            /*0x758104c*/ void SkipNodeType();
            /*0x758105c*/ object[] GetList(int offset, int count);
            /*0x7580040*/ System.Xml.XmlDictionaryString GetDictionaryString(int key);
            /*0x7581420*/ int ReadDictionaryKey();
            /*0x75811d8*/ void ReadValue(System.Xml.XmlBinaryNodeType nodeType, System.Xml.ValueHandle value);
            /*0x7581590*/ void ReadValue(System.Xml.ValueHandle value, System.Xml.ValueHandleType type, int length);
            /*0x7581608*/ void ReadUnicodeValue(System.Xml.ValueHandle value, int length);
            /*0x7581648*/ void ReadList(System.Xml.ValueHandle value);
            /*0x758173c*/ void ReadQName(System.Xml.ValueHandle value);
            /*0x75817a4*/ int[] GetRows();
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

            static /*0x7583e00*/ XmlCanonicalWriter();
            /*0x7581a20*/ void Flush();
            /*0x7581a60*/ void Close();
            /*0x7581b70*/ void WriteDeclaration();
            /*0x7581b74*/ void WriteComment(string value);
            /*0x7581be0*/ void StartElement();
            /*0x7581cf4*/ void EndElement();
            /*0x7581d3c*/ void WriteStartElement(string prefix, string localName);
            /*0x7581efc*/ bool IsInclusivePrefix(ref System.Xml.XmlCanonicalWriter.XmlnsAttribute xmlnsAttribute);
            /*0x758226c*/ void WriteEndStartElement(bool isEmpty);
            /*0x7582858*/ void WriteEndElement(string prefix, string localName);
            /*0x75828d0*/ void EnsureXmlnsBuffer(int byteCount);
            /*0x7582a10*/ void WriteXmlnsAttribute(string prefix, string ns);
            /*0x7582c2c*/ void WriteStartAttribute(string prefix, string localName);
            /*0x7582d34*/ void WriteEndAttribute();
            /*0x7582eb0*/ void WriteCharEntity(int ch);
            /*0x7582fe0*/ void WriteEscapedText(string value);
            /*0x7583074*/ void WriteEscapedText(byte[] chars, int offset, int count);
            /*0x7582f54*/ void WriteEscapedText(char[] chars, int offset, int count);
            /*0x7582fa8*/ void WriteText(int ch);
            /*0x75832f0*/ void WriteText(byte[] chars, int offset, int count);
            /*0x7583544*/ void WriteText(string value);
            /*0x75835e8*/ void WriteText(char[] chars, int offset, int count);
            /*0x7581a48*/ void ThrowIfClosed();
            /*0x758383c*/ void ThrowClosed();
            /*0x7582648*/ void WriteXmlnsAttribute(ref System.Xml.XmlCanonicalWriter.XmlnsAttribute xmlnsAttribute);
            /*0x7582690*/ void SortAttributes();
            /*0x7582da0*/ void AddAttribute(ref System.Xml.XmlCanonicalWriter.Attribute attribute);
            /*0x7581fc4*/ void AddXmlnsAttribute(ref System.Xml.XmlCanonicalWriter.XmlnsAttribute xmlnsAttribute);
            /*0x7583b8c*/ void ResolvePrefix(int prefixOffset, int prefixLength, ref int nsOffset, ref int nsLength);
            /*0x7583cc0*/ void ResolvePrefix(ref System.Xml.XmlCanonicalWriter.Attribute attribute);
            /*0x7582514*/ void ResolvePrefixes();
            /*0x7583b60*/ int Compare(ref System.Xml.XmlCanonicalWriter.XmlnsAttribute xmlnsAttribute1, ref System.Xml.XmlCanonicalWriter.XmlnsAttribute xmlnsAttribute2);
            /*0x75838b0*/ int Compare(ref System.Xml.XmlCanonicalWriter.Attribute attribute1, ref System.Xml.XmlCanonicalWriter.Attribute attribute2);
            /*0x7583cdc*/ int Compare(byte[] buffer, int offset1, int length1, int offset2, int length2);
            /*0x7583cfc*/ int Compare(byte[] buffer1, int offset1, int length1, byte[] buffer2, int offset2, int length2);
            /*0x75825ac*/ bool Equals(byte[] buffer1, int offset1, int length1, byte[] buffer2, int offset2, int length2);

            class AttributeSorter : System.Collections.IComparer
            {
                /*0x10*/ System.Xml.XmlCanonicalWriter writer;

                /*0x7583928*/ AttributeSorter(System.Xml.XmlCanonicalWriter writer);
                /*0x7583958*/ void Sort();
                /*0x7583ee4*/ int Compare(object obj1, object obj2);
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

            static /*0x7588608*/ XmlConverter();
            static /*0x7583fa8*/ System.Text.Base64Encoding get_Base64Encoding();
            static /*0x758406c*/ System.Text.UTF8Encoding get_UTF8Encoding();
            static /*0x7584138*/ System.Text.UnicodeEncoding get_UnicodeEncoding();
            static /*0x7584208*/ bool ToBoolean(string value);
            static /*0x758433c*/ bool ToBoolean(byte[] buffer, int offset, int count);
            static /*0x7584400*/ int ToInt32(string value);
            static /*0x758454c*/ int ToInt32(byte[] buffer, int offset, int count);
            static /*0x7584744*/ long ToInt64(string value);
            static /*0x7584890*/ long ToInt64(byte[] buffer, int offset, int count);
            static /*0x7584b00*/ float ToSingle(string value);
            static /*0x7584c4c*/ float ToSingle(byte[] buffer, int offset, int count);
            static /*0x7584e58*/ double ToDouble(string value);
            static /*0x7584fa4*/ double ToDouble(byte[] buffer, int offset, int count);
            static /*0x7585198*/ decimal ToDecimal(string value);
            static /*0x75852e4*/ decimal ToDecimal(byte[] buffer, int offset, int count);
            static /*0x7585354*/ System.DateTime ToDateTime(long value);
            static /*0x75854dc*/ System.DateTime ToDateTime(string value);
            static /*0x7585610*/ System.DateTime ToDateTime(byte[] buffer, int offset, int count);
            static /*0x7585d54*/ System.Xml.UniqueId ToUniqueId(string value);
            static /*0x7586064*/ System.Xml.UniqueId ToUniqueId(byte[] buffer, int offset, int count);
            static /*0x75860d4*/ System.TimeSpan ToTimeSpan(string value);
            static /*0x7586220*/ System.TimeSpan ToTimeSpan(byte[] buffer, int offset, int count);
            static /*0x7586290*/ System.Guid ToGuid(string value);
            static /*0x75863e4*/ System.Guid ToGuid(byte[] buffer, int offset, int count);
            static /*0x7586454*/ ulong ToUInt64(string value);
            static /*0x7586574*/ ulong ToUInt64(byte[] buffer, int offset, int count);
            static /*0x7580844*/ string ToString(byte[] buffer, int offset, int count);
            static /*0x757f4d0*/ string ToStringUnicode(byte[] buffer, int offset, int count);
            static /*0x75865e4*/ byte[] ToBytes(string value);
            static /*0x757f198*/ int ToChars(byte[] buffer, int offset, int count, char[] chars, int charOffset);
            static /*0x7586704*/ string ToString(bool value);
            static /*0x758676c*/ string ToString(int value);
            static /*0x7585484*/ string ToString(long value);
            static /*0x75867c4*/ string ToString(float value);
            static /*0x7586824*/ string ToString(double value);
            static /*0x7586884*/ string ToString(decimal value);
            static /*0x75868ec*/ string ToString(System.TimeSpan value);
            static /*0x7586944*/ string ToString(System.Xml.UniqueId value);
            static /*0x7586960*/ string ToString(System.Guid value);
            static /*0x7586984*/ string ToString(ulong value);
            static /*0x75869ac*/ string ToString(System.DateTime value);
            static /*0x7586e90*/ string ToString(object value);
            static /*0x7587380*/ string ToString(object[] objects);
            static /*0x75845fc*/ bool TryParseInt32(byte[] chars, int offset, int count, ref int result);
            static /*0x7584940*/ bool TryParseInt64(byte[] chars, int offset, int count, ref long result);
            static /*0x7584cfc*/ bool TryParseSingle(byte[] chars, int offset, int count, ref float result);
            static /*0x7585054*/ bool TryParseDouble(byte[] chars, int offset, int count, ref double result);
            static /*0x75874e0*/ int ToInt32D2(byte[] chars, int offset);
            static /*0x7587548*/ int ToInt32D4(byte[] chars, int offset, int count);
            static /*0x75875b4*/ int ToInt32D7(byte[] chars, int offset, int count);
            static /*0x75856c0*/ bool TryParseDateTime(byte[] chars, int offset, int count, ref System.DateTime result);
            static /*0x7587638*/ int ToChars(bool value, byte[] buffer, int offset);
            static /*0x7587744*/ int ToCharsR(int value, byte[] chars, int offset);
            static /*0x7587888*/ int ToChars(int value, byte[] chars, int offset);
            static /*0x7587920*/ int ToCharsR(long value, byte[] chars, int offset);
            static /*0x7587a84*/ int ToChars(long value, byte[] chars, int offset);
            static /*0x7587b1c*/ bool IsNegativeZero(float value);
            static /*0x7587b30*/ bool IsNegativeZero(double value);
            static /*0x7587b44*/ int ToInfinity(bool isNegative, byte[] buffer, int offset);
            static /*0x7587c18*/ int ToZero(bool isNegative, byte[] buffer, int offset);
            static /*0x7587c84*/ int ToChars(double value, byte[] buffer, int offset);
            static /*0x7587e48*/ int ToChars(float value, byte[] buffer, int offset);
            static /*0x7587f8c*/ int ToChars(decimal value, byte[] buffer, int offset);
            static /*0x7588074*/ int ToChars(ulong value, byte[] buffer, int offset);
            static /*0x7587dc8*/ int ToAsciiChars(string s, byte[] buffer, int offset);
            static /*0x7588108*/ int ToCharsD2(int value, byte[] chars, int offset);
            static /*0x75881ac*/ int ToCharsD4(int value, byte[] chars, int offset);
            static /*0x758824c*/ int ToCharsD7(int value, byte[] chars, int offset);
            static /*0x7586a48*/ int ToChars(System.DateTime value, byte[] chars, int offset);
            static /*0x7588358*/ bool IsWhitespace(string s);
            static /*0x7580124*/ bool IsWhitespace(char ch);
            static /*0x7588438*/ string StripWhitespace(string s);
            static /*0x7585eb8*/ string Trim(string s);
        }

        class XmlDictionary : System.Xml.IXmlDictionary
        {
            /*0x10*/ System.Collections.Generic.Dictionary<string, System.Xml.XmlDictionaryString> lookup;
            /*0x18*/ System.Xml.XmlDictionaryString[] strings;
            /*0x20*/ int nextId;

            /*0x75886a8*/ XmlDictionary();
            /*0x7588748*/ XmlDictionary(int capacity);
            /*0x7588818*/ System.Xml.XmlDictionaryString Add(string value);
            /*0x7588ba0*/ bool TryLookup(int key, ref System.Xml.XmlDictionaryString result);
        }

        class OnXmlDictionaryReaderClose : System.MulticastDelegate
        {
            /*0x7588c08*/ OnXmlDictionaryReaderClose(object object, nint method);
            /*0x7588d10*/ void Invoke(System.Xml.XmlDictionaryReader reader);
        }

        class XmlDictionaryReader : System.Xml.XmlReader
        {
            static /*0x7588d24*/ System.Xml.XmlDictionaryReader CreateDictionaryReader(System.Xml.XmlReader reader);
            static /*0x7588e3c*/ System.Xml.XmlDictionaryReader CreateTextReader(System.IO.Stream stream, System.Xml.XmlDictionaryReaderQuotas quotas);
            static /*0x7588e4c*/ System.Xml.XmlDictionaryReader CreateTextReader(System.IO.Stream stream, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose onClose);
            /*0x758c0d8*/ XmlDictionaryReader();
            /*0x7588ee4*/ System.Xml.XmlDictionaryReaderQuotas get_Quotas();
            /*0x7588f6c*/ void MoveToStartElement();
            /*0x7588fa0*/ bool IsLocalName(string localName);
            /*0x7588fc8*/ bool IsLocalName(System.Xml.XmlDictionaryString localName);
            /*0x7589018*/ bool IsNamespaceUri(string namespaceUri);
            /*0x7589070*/ bool IsNamespaceUri(System.Xml.XmlDictionaryString namespaceUri);
            /*0x75890c0*/ bool IsStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri);
            /*0x7589160*/ int IndexOfLocalName(System.Xml.XmlDictionaryString[] localNames, System.Xml.XmlDictionaryString namespaceUri);
            /*0x75892ac*/ bool TryGetBase64ContentLength(ref int length);
            /*0x75892b8*/ byte[] ReadContentAsBase64();
            /*0x75892ec*/ byte[] ReadContentAsBase64(int maxByteArrayContentLength, int maxInitialCount);
            /*0x7589634*/ string ReadContentAsString();
            /*0x7589664*/ string ReadContentAsString(int maxStringContentLength);
            /*0x7589850*/ string ReadString();
            /*0x7589880*/ string ReadString(int maxStringContentLength);
            /*0x7589400*/ byte[] ReadContentAsBytes(bool base64, int maxByteArrayContentLength);
            /*0x7589b20*/ bool IsTextNode(System.Xml.XmlNodeType nodeType);
            /*0x7589b44*/ int ReadContentAsChars(char[] chars, int offset, int count);
            /*0x7589c14*/ object ReadContentAs(System.Type type, System.Xml.IXmlNamespaceResolver namespaceResolver);
            /*0x7589f80*/ decimal ReadContentAsDecimal();
            /*0x7589ff0*/ float ReadContentAsFloat();
            /*0x758a060*/ System.Xml.UniqueId ReadContentAsUniqueId();
            /*0x758a0d0*/ System.Guid ReadContentAsGuid();
            /*0x758a140*/ System.TimeSpan ReadContentAsTimeSpan();
            /*0x758a1b0*/ string ReadElementContentAsString();
            /*0x758a264*/ bool ReadElementContentAsBoolean();
            /*0x758a360*/ int ReadElementContentAsInt();
            /*0x758a45c*/ long ReadElementContentAsLong();
            /*0x758a558*/ float ReadElementContentAsFloat();
            /*0x758a660*/ double ReadElementContentAsDouble();
            /*0x758a768*/ decimal ReadElementContentAsDecimal();
            /*0x758a870*/ System.DateTime ReadElementContentAsDateTime();
            /*0x758aa5c*/ System.Guid ReadElementContentAsGuid();
            /*0x758ab40*/ System.TimeSpan ReadElementContentAsTimeSpan();
            /*0x758ac3c*/ byte[] ReadElementContentAsBase64();
            /*0x758ad18*/ bool TryGetLocalNameAsDictionaryString(ref System.Xml.XmlDictionaryString localName);
            /*0x758ad38*/ bool TryGetNamespaceUriAsDictionaryString(ref System.Xml.XmlDictionaryString namespaceUri);
            /*0x758ad58*/ bool TryGetValueAsDictionaryString(ref System.Xml.XmlDictionaryString value);
            /*0x758ad78*/ void CheckArray(System.Array array, int offset, int count);
            /*0x758afc8*/ bool IsStartArray(ref System.Type type);
            /*0x758afe8*/ bool TryGetArrayLength(ref int count);
            /*0x758aff4*/ int ReadArray(string localName, string namespaceUri, bool[] array, int offset, int count);
            /*0x758b0e0*/ int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, bool[] array, int offset, int count);
            /*0x758b19c*/ int ReadArray(string localName, string namespaceUri, short[] array, int offset, int count);
            /*0x758b2f4*/ int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, short[] array, int offset, int count);
            /*0x758b3b0*/ int ReadArray(string localName, string namespaceUri, int[] array, int offset, int count);
            /*0x758b498*/ int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, int[] array, int offset, int count);
            /*0x758b554*/ int ReadArray(string localName, string namespaceUri, long[] array, int offset, int count);
            /*0x758b63c*/ int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, long[] array, int offset, int count);
            /*0x758b6f8*/ int ReadArray(string localName, string namespaceUri, float[] array, int offset, int count);
            /*0x758b7e0*/ int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, float[] array, int offset, int count);
            /*0x758b89c*/ int ReadArray(string localName, string namespaceUri, double[] array, int offset, int count);
            /*0x758b984*/ int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, double[] array, int offset, int count);
            /*0x758ba40*/ int ReadArray(string localName, string namespaceUri, decimal[] array, int offset, int count);
            /*0x758bb2c*/ int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, decimal[] array, int offset, int count);
            /*0x758bbe8*/ int ReadArray(string localName, string namespaceUri, System.DateTime[] array, int offset, int count);
            /*0x758bcd0*/ int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.DateTime[] array, int offset, int count);
            /*0x758bd8c*/ int ReadArray(string localName, string namespaceUri, System.Guid[] array, int offset, int count);
            /*0x758be78*/ int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Guid[] array, int offset, int count);
            /*0x758bf34*/ int ReadArray(string localName, string namespaceUri, System.TimeSpan[] array, int offset, int count);
            /*0x758c01c*/ int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.TimeSpan[] array, int offset, int count);

            class XmlWrappedReader : System.Xml.XmlDictionaryReader, System.Xml.IXmlLineInfo
            {
                /*0x10*/ System.Xml.XmlReader reader;
                /*0x18*/ System.Xml.XmlNamespaceManager nsMgr;

                /*0x7588dfc*/ XmlWrappedReader(System.Xml.XmlReader reader, System.Xml.XmlNamespaceManager nsMgr);
                /*0x758c130*/ int get_AttributeCount();
                /*0x758c154*/ string get_BaseURI();
                /*0x758c178*/ bool get_CanReadValueChunk();
                /*0x758c19c*/ void Close();
                /*0x758c1d4*/ int get_Depth();
                /*0x758c1f4*/ bool get_EOF();
                /*0x758c218*/ string GetAttribute(int index);
                /*0x758c23c*/ string GetAttribute(string name);
                /*0x758c260*/ string GetAttribute(string name, string namespaceUri);
                /*0x758c284*/ bool get_IsDefault();
                /*0x758c2a8*/ bool get_IsEmptyElement();
                /*0x758c2cc*/ bool IsStartElement(string localName, string namespaceUri);
                /*0x758c2f0*/ string get_LocalName();
                /*0x758c310*/ string LookupNamespace(string namespaceUri);
                /*0x758c334*/ void MoveToAttribute(int index);
                /*0x758c358*/ bool MoveToAttribute(string name);
                /*0x758c37c*/ bool MoveToAttribute(string name, string namespaceUri);
                /*0x758c3a0*/ bool MoveToElement();
                /*0x758c3c4*/ bool MoveToFirstAttribute();
                /*0x758c3e8*/ bool MoveToNextAttribute();
                /*0x758c40c*/ string get_Name();
                /*0x758c42c*/ string get_NamespaceURI();
                /*0x758c44c*/ System.Xml.XmlNameTable get_NameTable();
                /*0x758c470*/ System.Xml.XmlNodeType get_NodeType();
                /*0x758c490*/ string get_Prefix();
                /*0x758c4b0*/ char get_QuoteChar();
                /*0x758c4d4*/ bool Read();
                /*0x758c4f8*/ bool ReadAttributeValue();
                /*0x758c51c*/ string ReadInnerXml();
                /*0x758c540*/ void ReadEndElement();
                /*0x758c564*/ string ReadString();
                /*0x758c588*/ System.Xml.ReadState get_ReadState();
                /*0x758c5ac*/ void ResolveEntity();
                /*0x758c5d0*/ string get_Value();
                /*0x758c5f0*/ string get_XmlLang();
                /*0x758c614*/ System.Xml.XmlSpace get_XmlSpace();
                /*0x758c638*/ int ReadContentAsBase64(byte[] buffer, int offset, int count);
                /*0x758c65c*/ int ReadContentAsBinHex(byte[] buffer, int offset, int count);
                /*0x758c680*/ int ReadValueChunk(char[] chars, int offset, int count);
                /*0x758c6a4*/ System.Type get_ValueType();
                /*0x758c6c8*/ bool ReadContentAsBoolean();
                /*0x758c6ec*/ System.DateTime ReadContentAsDateTime();
                /*0x758c710*/ decimal ReadContentAsDecimal();
                /*0x758c7e0*/ double ReadContentAsDouble();
                /*0x758c804*/ int ReadContentAsInt();
                /*0x758c828*/ long ReadContentAsLong();
                /*0x758c84c*/ float ReadContentAsFloat();
                /*0x758c870*/ string ReadContentAsString();
                /*0x758c894*/ object ReadContentAs(System.Type type, System.Xml.IXmlNamespaceResolver namespaceResolver);
                /*0x758c8b8*/ bool HasLineInfo();
                /*0x758c96c*/ int get_LineNumber();
                /*0x758ca28*/ int get_LinePosition();
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

            static /*0x758cd2c*/ XmlDictionaryReaderQuotas();
            static /*0x758cc88*/ System.Xml.XmlDictionaryReaderQuotas get_Max();
            /*0x758cae4*/ XmlDictionaryReaderQuotas();
            /*0x758cc20*/ XmlDictionaryReaderQuotas(int maxDepth, int maxStringContentLength, int maxArrayLength, int maxBytesPerRead, int maxNameTableCharCount, System.Xml.XmlDictionaryReaderQuotaTypes modifiedQuotas);
            /*0x758cb58*/ void CopyTo(System.Xml.XmlDictionaryReaderQuotas quotas);
            /*0x758cce0*/ void InternalCopyTo(System.Xml.XmlDictionaryReaderQuotas quotas);
            /*0x758cd04*/ int get_MaxStringContentLength();
            /*0x758cd0c*/ int get_MaxArrayLength();
            /*0x758cd14*/ int get_MaxBytesPerRead();
            /*0x758cd1c*/ int get_MaxDepth();
            /*0x758cd24*/ int get_MaxNameTableCharCount();
            /*0x758cc7c*/ void MakeReadOnly();
        }

        class XmlDictionaryString
        {
            static /*0x0*/ System.Xml.XmlDictionaryString.EmptyStringDictionary emptyStringDictionary;
            /*0x10*/ System.Xml.IXmlDictionary dictionary;
            /*0x18*/ string value;
            /*0x20*/ int key;
            /*0x28*/ byte[] buffer;

            static /*0x758ced0*/ XmlDictionaryString();
            static /*0x7589154*/ string GetString(System.Xml.XmlDictionaryString s);
            static /*0x758cdf4*/ System.Xml.XmlDictionaryString get_Empty();
            /*0x75889d4*/ XmlDictionaryString(System.Xml.IXmlDictionary dictionary, string value, int key);
            /*0x758ce58*/ System.Xml.IXmlDictionary get_Dictionary();
            /*0x758ce60*/ int get_Key();
            /*0x758ce68*/ string get_Value();
            /*0x758ce70*/ byte[] ToUTF8();
            /*0x758cec8*/ string ToString();

            class EmptyStringDictionary : System.Xml.IXmlDictionary
            {
                /*0x10*/ System.Xml.XmlDictionaryString empty;

                /*0x758cf48*/ EmptyStringDictionary();
                /*0x758cfd0*/ System.Xml.XmlDictionaryString get_EmptyString();
                /*0x758cfd8*/ bool TryLookup(int key, ref System.Xml.XmlDictionaryString result);
            }
        }

        class XmlDictionaryWriter : System.Xml.XmlWriter
        {
            static /*0x758d014*/ System.Xml.XmlDictionaryWriter CreateTextWriter(System.IO.Stream stream, System.Text.Encoding encoding, bool ownsStream);
            static /*0x758d09c*/ System.Xml.XmlDictionaryWriter CreateDictionaryWriter(System.Xml.XmlWriter writer);
            /*0x7590260*/ XmlDictionaryWriter();
            /*0x758d1bc*/ void WriteStartElement(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri);
            /*0x758d25c*/ void WriteStartAttribute(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri);
            /*0x758d2fc*/ void WriteXmlnsAttribute(string prefix, string namespaceUri);
            /*0x758d430*/ void WriteXmlnsAttribute(string prefix, System.Xml.XmlDictionaryString namespaceUri);
            /*0x758d4b8*/ void WriteString(System.Xml.XmlDictionaryString value);
            /*0x758d538*/ void WriteQualifiedName(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri);
            /*0x758d620*/ void WriteValue(System.Guid value);
            /*0x758d660*/ void WriteValue(System.TimeSpan value);
            /*0x758d6dc*/ void WriteElementNode(System.Xml.XmlDictionaryReader reader, bool defattr);
            /*0x758da60*/ void WriteArrayNode(System.Xml.XmlDictionaryReader reader, string prefix, string localName, string namespaceUri, System.Type type);
            /*0x758e208*/ void WriteArrayNode(System.Xml.XmlDictionaryReader reader, string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Type type);
            /*0x758e9b0*/ void WriteArrayNode(System.Xml.XmlDictionaryReader reader, System.Type type);
            /*0x758eaa4*/ void WriteTextNode(System.Xml.XmlDictionaryReader reader, bool isAttribute);
            /*0x758eb48*/ void WriteNode(System.Xml.XmlReader reader, bool defattr);
            /*0x758ec00*/ void WriteNode(System.Xml.XmlDictionaryReader reader, bool defattr);
            /*0x758efa0*/ void CheckArray(System.Array array, int offset, int count);
            /*0x758f1f0*/ void WriteArray(string prefix, string localName, string namespaceUri, bool[] array, int offset, int count);
            /*0x758f2d0*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, bool[] array, int offset, int count);
            /*0x758f394*/ void WriteArray(string prefix, string localName, string namespaceUri, short[] array, int offset, int count);
            /*0x758f474*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, short[] array, int offset, int count);
            /*0x758f538*/ void WriteArray(string prefix, string localName, string namespaceUri, int[] array, int offset, int count);
            /*0x758f618*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, int[] array, int offset, int count);
            /*0x758f6dc*/ void WriteArray(string prefix, string localName, string namespaceUri, long[] array, int offset, int count);
            /*0x758f7bc*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, long[] array, int offset, int count);
            /*0x758f880*/ void WriteArray(string prefix, string localName, string namespaceUri, float[] array, int offset, int count);
            /*0x758f960*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, float[] array, int offset, int count);
            /*0x758fa24*/ void WriteArray(string prefix, string localName, string namespaceUri, double[] array, int offset, int count);
            /*0x758fb04*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, double[] array, int offset, int count);
            /*0x758fbc8*/ void WriteArray(string prefix, string localName, string namespaceUri, decimal[] array, int offset, int count);
            /*0x758fcac*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, decimal[] array, int offset, int count);
            /*0x758fd70*/ void WriteArray(string prefix, string localName, string namespaceUri, System.DateTime[] array, int offset, int count);
            /*0x758fe50*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.DateTime[] array, int offset, int count);
            /*0x758ff14*/ void WriteArray(string prefix, string localName, string namespaceUri, System.Guid[] array, int offset, int count);
            /*0x758fff8*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Guid[] array, int offset, int count);
            /*0x75900bc*/ void WriteArray(string prefix, string localName, string namespaceUri, System.TimeSpan[] array, int offset, int count);
            /*0x759019c*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.TimeSpan[] array, int offset, int count);

            class XmlWrappedWriter : System.Xml.XmlDictionaryWriter
            {
                /*0x18*/ System.Xml.XmlWriter writer;
                /*0x20*/ int depth;
                /*0x24*/ int prefix;

                /*0x758d184*/ XmlWrappedWriter(System.Xml.XmlWriter writer);
                /*0x7590268*/ void Close();
                /*0x759028c*/ void Flush();
                /*0x75902b0*/ string LookupPrefix(string namespaceUri);
                /*0x75902d4*/ void WriteAttributes(System.Xml.XmlReader reader, bool defattr);
                /*0x75902fc*/ void WriteBase64(byte[] buffer, int index, int count);
                /*0x7590320*/ void WriteBinHex(byte[] buffer, int index, int count);
                /*0x7590344*/ void WriteCData(string text);
                /*0x7590368*/ void WriteCharEntity(char ch);
                /*0x759038c*/ void WriteChars(char[] buffer, int index, int count);
                /*0x75903b0*/ void WriteComment(string text);
                /*0x75903d4*/ void WriteDocType(string name, string pubid, string sysid, string subset);
                /*0x75903f4*/ void WriteEndAttribute();
                /*0x7590418*/ void WriteEndDocument();
                /*0x7590438*/ void WriteEndElement();
                /*0x759046c*/ void WriteEntityRef(string name);
                /*0x7590490*/ void WriteFullEndElement();
                /*0x75904b0*/ void WriteNode(System.Xml.XmlReader reader, bool defattr);
                /*0x75904d8*/ void WriteProcessingInstruction(string name, string text);
                /*0x75904fc*/ void WriteQualifiedName(string localName, string namespaceUri);
                /*0x7590520*/ void WriteRaw(char[] buffer, int index, int count);
                /*0x7590544*/ void WriteRaw(string data);
                /*0x7590568*/ void WriteStartAttribute(string prefix, string localName, string namespaceUri);
                /*0x759059c*/ void WriteStartDocument();
                /*0x75905bc*/ void WriteStartDocument(bool standalone);
                /*0x75905e0*/ void WriteStartElement(string prefix, string localName, string namespaceUri);
                /*0x7590618*/ System.Xml.WriteState get_WriteState();
                /*0x759063c*/ void WriteString(string text);
                /*0x7590660*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
                /*0x7590684*/ void WriteWhitespace(string whitespace);
                /*0x75906a8*/ void WriteValue(string value);
                /*0x75906cc*/ void WriteValue(bool value);
                /*0x75906f4*/ void WriteValue(System.DateTime value);
                /*0x7590718*/ void WriteValue(double value);
                /*0x759073c*/ void WriteValue(int value);
                /*0x7590760*/ void WriteValue(long value);
                /*0x7590784*/ void WriteXmlnsAttribute(string prefix, string namespaceUri);
                /*0x75908f8*/ string get_XmlLang();
                /*0x759091c*/ System.Xml.XmlSpace get_XmlSpace();
            }
        }

        class XmlNodeWriter
        {
            /*0x7590bfc*/ XmlNodeWriter();
            /*0x380cb08*/ void Flush();
            /*0x380cb08*/ void Close();
            /*0x380cb08*/ void WriteDeclaration();
            /*0x380d83c*/ void WriteComment(string text);
            /*0x380d83c*/ void WriteCData(string text);
            /*0x380d93c*/ void WriteStartElement(string prefix, string localName);
            /*0x7590940*/ void WriteStartElement(byte[] prefixBuffer, int prefixOffset, int prefixLength, byte[] localNameBuffer, int localNameOffset, int localNameLength);
            /*0x380d93c*/ void WriteStartElement(string prefix, System.Xml.XmlDictionaryString localName);
            /*0x380cdf0*/ void WriteEndStartElement(bool isEmpty);
            /*0x380d93c*/ void WriteEndElement(string prefix, string localName);
            /*0x75909ec*/ void WriteEndElement(byte[] prefixBuffer, int prefixOffset, int prefixLength, byte[] localNameBuffer, int localNameOffset, int localNameLength);
            /*0x380d93c*/ void WriteXmlnsAttribute(string prefix, string ns);
            /*0x7590a9c*/ void WriteXmlnsAttribute(byte[] prefixBuffer, int prefixOffset, int prefixLength, byte[] nsBuffer, int nsOffset, int nsLength);
            /*0x380d93c*/ void WriteXmlnsAttribute(string prefix, System.Xml.XmlDictionaryString ns);
            /*0x380d93c*/ void WriteStartAttribute(string prefix, string localName);
            /*0x7590b4c*/ void WriteStartAttribute(byte[] prefixBuffer, int prefixOffset, int prefixLength, byte[] localNameBuffer, int localNameOffset, int localNameLength);
            /*0x380d93c*/ void WriteStartAttribute(string prefix, System.Xml.XmlDictionaryString localName);
            /*0x380cb08*/ void WriteEndAttribute();
            /*0x380cffc*/ void WriteCharEntity(int ch);
            /*0x380d83c*/ void WriteEscapedText(string value);
            /*0x380d83c*/ void WriteEscapedText(System.Xml.XmlDictionaryString value);
            void WriteEscapedText(char[] chars, int offset, int count);
            void WriteEscapedText(byte[] buffer, int offset, int count);
            /*0x380d83c*/ void WriteText(string value);
            /*0x380d83c*/ void WriteText(System.Xml.XmlDictionaryString value);
            void WriteText(char[] chars, int offset, int count);
            void WriteText(byte[] buffer, int offset, int count);
            /*0x380cffc*/ void WriteInt32Text(int value);
            /*0x380d438*/ void WriteInt64Text(long value);
            /*0x380cdf0*/ void WriteBoolText(bool value);
            void WriteUInt64Text(ulong value);
            /*0x380e050*/ void WriteFloatText(float value);
            /*0x380cee0*/ void WriteDoubleText(double value);
            void WriteDecimalText(decimal value);
            void WriteDateTimeText(System.DateTime value);
            /*0x380d83c*/ void WriteUniqueIdText(System.Xml.UniqueId value);
            /*0x380e1ac*/ void WriteTimeSpanText(System.TimeSpan value);
            void WriteGuidText(System.Guid value);
            void WriteBase64Text(byte[] trailBuffer, int trailCount, byte[] buffer, int offset, int count);
            /*0x380d93c*/ void WriteQualifiedName(string prefix, System.Xml.XmlDictionaryString localName);
        }

        class XmlSigningNodeWriter : System.Xml.XmlNodeWriter
        {
            /*0x10*/ System.Xml.XmlNodeWriter writer;
            /*0x18*/ System.Xml.XmlCanonicalWriter signingWriter;
            /*0x20*/ byte[] chars;
            /*0x28*/ byte[] base64Chars;
            /*0x30*/ bool text;

            /*0x7590c04*/ void Flush();
            /*0x7590c4c*/ void Close();
            /*0x7590c7c*/ void WriteDeclaration();
            /*0x7590cac*/ void WriteComment(string text);
            /*0x7590cec*/ void WriteCData(string text);
            /*0x7590d2c*/ void WriteStartElement(string prefix, string localName);
            /*0x7590d74*/ void WriteStartElement(string prefix, System.Xml.XmlDictionaryString localName);
            /*0x7590dc0*/ void WriteEndStartElement(bool isEmpty);
            /*0x7590e04*/ void WriteEndElement(string prefix, string localName);
            /*0x7590e50*/ void WriteXmlnsAttribute(string prefix, string ns);
            /*0x7590e9c*/ void WriteXmlnsAttribute(string prefix, System.Xml.XmlDictionaryString ns);
            /*0x7590eec*/ void WriteStartAttribute(string prefix, string localName);
            /*0x7590f38*/ void WriteStartAttribute(string prefix, System.Xml.XmlDictionaryString localName);
            /*0x7590f88*/ void WriteEndAttribute();
            /*0x7590fbc*/ void WriteCharEntity(int ch);
            /*0x7591000*/ void WriteEscapedText(string value);
            /*0x7591044*/ void WriteEscapedText(char[] chars, int offset, int count);
            /*0x75910a0*/ void WriteEscapedText(System.Xml.XmlDictionaryString value);
            /*0x75910e8*/ void WriteEscapedText(byte[] chars, int offset, int count);
            /*0x7591144*/ void WriteText(string value);
            /*0x7591188*/ void WriteText(char[] chars, int offset, int count);
            /*0x75911e4*/ void WriteText(byte[] chars, int offset, int count);
            /*0x7591240*/ void WriteText(System.Xml.XmlDictionaryString value);
            /*0x7591288*/ void WriteInt32Text(int value);
            /*0x7591364*/ void WriteInt64Text(long value);
            /*0x7591440*/ void WriteBoolText(bool value);
            /*0x759151c*/ void WriteUInt64Text(ulong value);
            /*0x75915f8*/ void WriteFloatText(float value);
            /*0x75916d4*/ void WriteDoubleText(double value);
            /*0x75917b0*/ void WriteDecimalText(decimal value);
            /*0x7591898*/ void WriteDateTimeText(System.DateTime value);
            /*0x7591974*/ void WriteUniqueIdText(System.Xml.UniqueId value);
            /*0x7591a34*/ void WriteTimeSpanText(System.TimeSpan value);
            /*0x7591ae8*/ void WriteGuidText(System.Guid value);
            /*0x7591bbc*/ void WriteBase64Text(byte[] trailBytes, int trailByteCount, byte[] buffer, int offset, int count);
            /*0x7591c70*/ void WriteBase64Text(byte[] buffer, int offset, int count);
            /*0x7591ec0*/ void WriteQualifiedName(string prefix, System.Xml.XmlDictionaryString localName);
        }

        class XmlStreamNodeWriter : System.Xml.XmlNodeWriter
        {
            static /*0x0*/ System.Text.UTF8Encoding UTF8Encoding;
            /*0x10*/ System.IO.Stream stream;
            /*0x18*/ byte[] buffer;
            /*0x20*/ int offset;
            /*0x24*/ bool ownsStream;
            /*0x28*/ System.Text.Encoding encoding;

            static /*0x7592808*/ XmlStreamNodeWriter();
            /*0x7591f70*/ XmlStreamNodeWriter();
            /*0x7592018*/ void SetOutput(System.IO.Stream stream, bool ownsStream, System.Text.Encoding encoding);
            /*0x7592078*/ int get_Position();
            /*0x75920ac*/ byte[] GetBuffer(int count, ref int offset);
            /*0x75920f8*/ void Advance(int count);
            /*0x7592108*/ void EnsureByte();
            /*0x7592128*/ void WriteByte(byte b);
            /*0x7592194*/ void WriteByte(char ch);
            /*0x7592198*/ void WriteBytes(byte b1, byte b2);
            /*0x7592230*/ void WriteBytes(char ch1, char ch2);
            /*0x7592234*/ void WriteUTF8Char(int ch);
            /*0x7592500*/ void WriteUTF8Chars(byte[] chars, int charOffset, int charCount);
            /*0x75925c8*/ void WriteUTF8Chars(string value);
            /*0x75922cc*/ void UnsafeWriteUTF8Chars(char* chars, int charCount);
            /*0x7592618*/ int UnsafeGetUTF8Chars(char* chars, int charCount, byte[] buffer, int offset);
            /*0x7592748*/ void FlushBuffer();
            /*0x7592788*/ void Flush();
            /*0x75927c0*/ void Close();
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

            static /*0x75959cc*/ XmlUTF8TextReader();
            /*0x759288c*/ XmlUTF8TextReader();
            /*0x7592970*/ void SetInput(System.IO.Stream stream, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose onClose);
            /*0x7592a54*/ void MoveToInitial(System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose onClose);
            /*0x7592a98*/ void Close();
            /*0x7592ba8*/ void SkipWhitespace();
            /*0x7592c68*/ void ReadDeclaration();
            /*0x75937a0*/ void VerifyNCName(string s);
            /*0x7593b64*/ void ReadQualifiedName(System.Xml.PrefixHandle prefix, System.Xml.StringHandle localName);
            /*0x7593ed4*/ int ReadAttributeText(byte[] buffer, int offset, int offsetMax);
            /*0x7593154*/ void ReadAttributes();
            /*0x75940b4*/ void ReadNonFFFE();
            /*0x759422c*/ bool IsNextCharacterNonFFFE(byte[] buffer, int offset);
            /*0x7592fbc*/ void BufferElement();
            /*0x7594290*/ void ReadStartElement();
            /*0x759448c*/ void ReadEndElement();
            /*0x7594744*/ void ReadComment();
            /*0x7594a68*/ void ReadCData();
            /*0x7594010*/ int ReadCharRef();
            /*0x7594d08*/ void ReadWhitespace();
            /*0x7594dd0*/ int ReadWhitespace(byte[] buffer, int offset, int offsetMax);
            /*0x7594f50*/ int ReadText(byte[] buffer, int offset, int offsetMax);
            /*0x759501c*/ int ReadTextAndWatchForInvalidCharacters(byte[] buffer, int offset, int offsetMax);
            /*0x7594e9c*/ int BreakText(byte[] buffer, int offset, int length);
            /*0x75951d0*/ void ReadText(bool hasLeadingByteOf0xEF);
            /*0x7595338*/ void ReadEscapedText();
            /*0x7595400*/ bool Read();
            /*0x75958b4*/ bool HasLineInfo();
            /*0x75958bc*/ int get_LineNumber();
            /*0x75959ac*/ int get_LinePosition();
            /*0x75958dc*/ void GetPosition(ref int row, ref int column);
        }

        class XmlUTF8TextWriter : System.Xml.XmlBaseWriter
        {
            /*0x98*/ System.Xml.XmlUTF8NodeWriter writer;

            /*0x7595cd0*/ XmlUTF8TextWriter();
            /*0x7595a6c*/ void SetOutput(System.IO.Stream stream, System.Text.Encoding encoding, bool ownsStream);
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

            static /*0x75981f0*/ XmlUTF8NodeWriter();
            /*0x7595bd8*/ XmlUTF8NodeWriter();
            /*0x7595d28*/ XmlUTF8NodeWriter(bool[] isEscapedAttributeChar, bool[] isEscapedElementChar);
            /*0x7595c38*/ void SetOutput(System.IO.Stream stream, bool ownsStream, System.Text.Encoding encoding);
            /*0x7595db4*/ byte[] GetCharEntityBuffer();
            /*0x7595e1c*/ char[] GetCharBuffer(int charCount);
            /*0x7595eb8*/ void WriteDeclaration();
            /*0x7595fec*/ void WriteCData(string text);
            /*0x75961d8*/ void WriteStartComment();
            /*0x7596294*/ void WriteEndComment();
            /*0x7596334*/ void WriteComment(string text);
            /*0x7596364*/ void WriteStartElement(string prefix, string localName);
            /*0x7596408*/ void WriteStartElement(string prefix, System.Xml.XmlDictionaryString localName);
            /*0x7596428*/ void WriteStartElement(byte[] prefixBuffer, int prefixOffset, int prefixLength, byte[] localNameBuffer, int localNameOffset, int localNameLength);
            /*0x75964e4*/ void WriteEndStartElement(bool isEmpty);
            /*0x75964fc*/ void WriteEndElement(string prefix, string localName);
            /*0x7596564*/ void WriteEndElement(byte[] prefixBuffer, int prefixOffset, int prefixLength, byte[] localNameBuffer, int localNameOffset, int localNameLength);
            /*0x75965f0*/ void WriteStartXmlnsAttribute();
            /*0x75966f0*/ void WriteXmlnsAttribute(string prefix, string ns);
            /*0x7596774*/ void WriteXmlnsAttribute(string prefix, System.Xml.XmlDictionaryString ns);
            /*0x7596798*/ void WriteXmlnsAttribute(byte[] prefixBuffer, int prefixOffset, int prefixLength, byte[] nsBuffer, int nsOffset, int nsLength);
            /*0x7596840*/ void WriteStartAttribute(string prefix, string localName);
            /*0x75968b4*/ void WriteStartAttribute(string prefix, System.Xml.XmlDictionaryString localName);
            /*0x75968d8*/ void WriteStartAttribute(byte[] prefixBuffer, int prefixOffset, int prefixLength, byte[] localNameBuffer, int localNameOffset, int localNameLength);
            /*0x7596970*/ void WriteEndAttribute();
            /*0x75963bc*/ void WritePrefix(string prefix);
            /*0x75964a4*/ void WritePrefix(byte[] prefixBuffer, int prefixOffset, int prefixLength);
            /*0x7596404*/ void WriteLocalName(string localName);
            /*0x75964e0*/ void WriteLocalName(byte[] localNameBuffer, int localNameOffset, int localNameLength);
            /*0x759698c*/ void WriteEscapedText(System.Xml.XmlDictionaryString s);
            /*0x75969b0*/ void WriteEscapedText(string s);
            /*0x7596b10*/ void WriteEscapedText(char[] s, int offset, int count);
            /*0x7596a00*/ void UnsafeWriteEscapedText(char* chars, int count);
            /*0x7596b50*/ void WriteEscapedText(byte[] chars, int offset, int count);
            /*0x7596d14*/ void WriteText(int ch);
            /*0x7596d18*/ void WriteText(byte[] chars, int offset, int count);
            /*0x7596d1c*/ void WriteText(char[] chars, int offset, int count);
            /*0x7596d5c*/ void WriteText(string value);
            /*0x7596d60*/ void WriteText(System.Xml.XmlDictionaryString value);
            /*0x7596d78*/ void WriteLessThanCharEntity();
            /*0x7596e38*/ void WriteGreaterThanCharEntity();
            /*0x7596ef8*/ void WriteAmpersandCharEntity();
            /*0x7596fd4*/ void WriteApostropheCharEntity();
            /*0x75970cc*/ void WriteQuoteCharEntity();
            /*0x75971c4*/ void WriteHexCharEntity(int ch);
            /*0x7597348*/ void WriteCharEntity(int ch);
            /*0x7597284*/ int ToBase16(byte[] chars, int offset, uint value);
            /*0x7597390*/ void WriteBoolText(bool value);
            /*0x7597438*/ void WriteDecimalText(decimal value);
            /*0x75974e8*/ void WriteDoubleText(double value);
            /*0x7597590*/ void WriteFloatText(float value);
            /*0x7597638*/ void WriteDateTimeText(System.DateTime value);
            /*0x75976e0*/ void WriteUniqueIdText(System.Xml.UniqueId value);
            /*0x75977a0*/ void WriteInt32Text(int value);
            /*0x7597848*/ void WriteInt64Text(long value);
            /*0x75978f0*/ void WriteUInt64Text(ulong value);
            /*0x7597998*/ void WriteGuidText(System.Guid value);
            /*0x75979d8*/ void WriteBase64Text(byte[] trailBytes, int trailByteCount, byte[] buffer, int offset, int count);
            /*0x7597a2c*/ void InternalWriteBase64Text(byte[] buffer, int offset, int count);
            /*0x7598120*/ void WriteTimeSpanText(System.TimeSpan value);
            /*0x759819c*/ void WriteQualifiedName(string prefix, System.Xml.XmlDictionaryString localName);
        }

        class XmlExceptionHelper
        {
            static /*0x7598410*/ void ThrowXmlException(System.Xml.XmlDictionaryReader reader, string res);
            static /*0x759841c*/ void ThrowXmlException(System.Xml.XmlDictionaryReader reader, string res, string arg1);
            static /*0x7598428*/ void ThrowXmlException(System.Xml.XmlDictionaryReader reader, string res, string arg1, string arg2);
            static /*0x7598434*/ void ThrowXmlException(System.Xml.XmlDictionaryReader reader, string res, string arg1, string arg2, string arg3);
            static /*0x7593888*/ void ThrowXmlException(System.Xml.XmlDictionaryReader reader, System.Xml.XmlException exception);
            static /*0x7598814*/ string GetName(string prefix, string localName);
            static /*0x7598888*/ string GetWhatWasFound(System.Xml.XmlDictionaryReader reader);
            static /*0x7598d60*/ void ThrowStartElementExpected(System.Xml.XmlDictionaryReader reader);
            static /*0x7598dac*/ void ThrowEndElementExpected(System.Xml.XmlDictionaryReader reader, string localName, string ns);
            static /*0x7598e0c*/ void ThrowMaxStringContentLengthExceeded(System.Xml.XmlDictionaryReader reader, int maxStringContentLength);
            static /*0x7598e70*/ void ThrowMaxArrayLengthExceeded(System.Xml.XmlDictionaryReader reader, int maxArrayLength);
            static /*0x7598ed4*/ void ThrowMaxArrayLengthOrMaxItemsQuotaExceeded(System.Xml.XmlDictionaryReader reader, int maxQuota);
            static /*0x7598f38*/ void ThrowMaxDepthExceeded(System.Xml.XmlDictionaryReader reader, int maxDepth);
            static /*0x75941c8*/ void ThrowMaxBytesPerReadExceeded(System.Xml.XmlDictionaryReader reader, int maxBytesPerRead);
            static /*0x7598f9c*/ void ThrowMaxNameTableCharCountExceeded(System.Xml.XmlDictionaryReader reader, int maxNameTableCharCount);
            static /*0x7599000*/ void ThrowBase64DataExpected(System.Xml.XmlDictionaryReader reader);
            static /*0x759904c*/ void ThrowUndefinedPrefix(System.Xml.XmlDictionaryReader reader, string prefix);
            static /*0x75930d4*/ void ThrowProcessingInstructionNotSupported(System.Xml.XmlDictionaryReader reader);
            static /*0x75949cc*/ void ThrowInvalidXml(System.Xml.XmlDictionaryReader reader, byte b);
            static /*0x7599098*/ void ThrowUnexpectedEndOfFile(System.Xml.XmlDictionaryReader reader);
            static /*0x7599118*/ void ThrowUnexpectedEndElement(System.Xml.XmlDictionaryReader reader);
            static /*0x7593fa0*/ void ThrowTokenExpected(System.Xml.XmlDictionaryReader reader, string expected, char found);
            static /*0x759374c*/ void ThrowTokenExpected(System.Xml.XmlDictionaryReader reader, string expected, string found);
            static /*0x7599158*/ void ThrowInvalidCharRef(System.Xml.XmlDictionaryReader reader);
            static /*0x75946c8*/ void ThrowTagMismatch(System.Xml.XmlDictionaryReader reader, string expectedPrefix, string expectedLocalName, string foundPrefix, string foundLocalName);
            static /*0x7599198*/ void ThrowDuplicateXmlnsAttribute(System.Xml.XmlDictionaryReader reader, string localName, string ns);
            static /*0x7599240*/ void ThrowDuplicateAttribute(System.Xml.XmlDictionaryReader reader, string prefix1, string prefix2, string localName, string ns);
            static /*0x75992c0*/ void ThrowInvalidBinaryFormat(System.Xml.XmlDictionaryReader reader);
            static /*0x7595874*/ void ThrowInvalidRootData(System.Xml.XmlDictionaryReader reader);
            static /*0x7599300*/ void ThrowMultipleRootElements(System.Xml.XmlDictionaryReader reader);
            static /*0x7593114*/ void ThrowDeclarationNotFirst(System.Xml.XmlDictionaryReader reader);
            static /*0x7599340*/ void ThrowConversionOverflow(System.Xml.XmlDictionaryReader reader, string value, string type);
            static /*0x7599394*/ void ThrowXmlDictionaryStringIDOutOfRange(System.Xml.XmlDictionaryReader reader);
            static /*0x7599420*/ void ThrowXmlDictionaryStringIDUndefinedStatic(System.Xml.XmlDictionaryReader reader, int key);
            static /*0x7599484*/ void ThrowXmlDictionaryStringIDUndefinedSession(System.Xml.XmlDictionaryReader reader, int key);
            static /*0x75994e8*/ void ThrowEmptyNamespace(System.Xml.XmlDictionaryReader reader);
            static /*0x7599528*/ System.Xml.XmlException CreateConversionException(string value, string type, System.Exception exception);
            static /*0x7599664*/ System.Xml.XmlException CreateEncodingException(byte[] buffer, int offset, int count, System.Exception exception);
            static /*0x7599708*/ System.Xml.XmlException CreateEncodingException(string value, System.Exception exception);
        }
    }

    namespace Text
    {
        class Base64Encoding : System.Text.Encoding
        {
            static /*0x0*/ byte[] char2val;
            static /*0x8*/ string val2char;
            static /*0x10*/ byte[] val2byte;

            static /*0x759b1e4*/ Base64Encoding();
            /*0x759b1dc*/ Base64Encoding();
            /*0x759980c*/ int GetMaxByteCount(int charCount);
            /*0x7599948*/ bool IsValidLeadBytes(int v1, int v2, int v3, int v4);
            /*0x7599968*/ bool IsValidTailBytes(int v3, int v4);
            /*0x7599980*/ int GetByteCount(char[] chars, int index, int count);
            /*0x7599e4c*/ int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);
            /*0x759a4c4*/ int GetBytes(byte[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);
            /*0x759ab24*/ int GetMaxCharCount(int byteCount);
            /*0x759ac78*/ int GetCharCount(byte[] bytes, int index, int count);
            /*0x759ac8c*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
            /*0x7597bd0*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, byte[] chars, int charIndex);
        }

        class BinHexEncoding : System.Text.Encoding
        {
            static /*0x0*/ byte[] char2val;
            static /*0x8*/ string val2char;

            static /*0x759bfc4*/ BinHexEncoding();
            /*0x759bfbc*/ BinHexEncoding();
            /*0x759b2f8*/ int GetMaxByteCount(int charCount);
            /*0x759b428*/ int GetByteCount(char[] chars, int index, int count);
            /*0x759b43c*/ int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);
            /*0x759b9e4*/ int GetMaxCharCount(int byteCount);
            /*0x759bb0c*/ int GetCharCount(byte[] bytes, int index, int count);
            /*0x759bb20*/ int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);
        }

        struct SurrogateChar
        {
            /*0x10*/ char lowChar;
            /*0x12*/ char highChar;

            /*0x75923c8*/ SurrogateChar(int ch);
            /*0x759c08c*/ SurrogateChar(char lowChar, char highChar);
            /*0x759c280*/ char get_LowChar();
            /*0x759c288*/ char get_HighChar();
            /*0x759c290*/ int get_Char();
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

                static /*0x759c2b0*/ Attributes();
                /*0x759cc48*/ Attributes();
                /*0x759c590*/ void Read(System.Runtime.Serialization.XmlReaderDelegator reader);
                /*0x759c7e0*/ void Reset();
                /*0x759c8f0*/ void ReadId(System.Runtime.Serialization.XmlReaderDelegator reader);
                /*0x759ca90*/ void ReadRef(System.Runtime.Serialization.XmlReaderDelegator reader);
                /*0x759cbbc*/ void ReadXsiNil(System.Runtime.Serialization.XmlReaderDelegator reader);
                /*0x759c9bc*/ void ReadArraySize(System.Runtime.Serialization.XmlReaderDelegator reader);
                /*0x759cbe8*/ void ReadXsiType(System.Runtime.Serialization.XmlReaderDelegator reader);
                /*0x759cb5c*/ void ReadFactoryType(System.Runtime.Serialization.XmlReaderDelegator reader);
            }

            class ClassDataContract : System.Runtime.Serialization.DataContract
            {
                /*0x28*/ System.Xml.XmlDictionaryString[] ContractNamespaces;
                /*0x30*/ System.Xml.XmlDictionaryString[] MemberNames;
                /*0x38*/ System.Xml.XmlDictionaryString[] MemberNamespaces;
                /*0x40*/ System.Xml.XmlDictionaryString[] childElementNamespaces;
                /*0x48*/ System.Runtime.Serialization.ClassDataContract.ClassDataContractCriticalHelper helper;

                static /*0x759e96c*/ System.Runtime.Serialization.ClassDataContract CreateClassDataContractForKeyValue(System.Type type, System.Xml.XmlDictionaryString ns, string[] memberNames);
                static /*0x759e9dc*/ void CheckAndAddMember(System.Collections.Generic.List<System.Runtime.Serialization.DataMember> members, System.Runtime.Serialization.DataMember memberContract, System.Collections.Generic.Dictionary<string, System.Runtime.Serialization.DataMember> memberNamesTable);
                static /*0x759ed08*/ System.Xml.XmlDictionaryString GetChildNamespaceToDeclare(System.Runtime.Serialization.DataContract dataContract, System.Type childType, System.Xml.XmlDictionary dictionary);
                static /*0x759ee8c*/ bool IsNonAttributedTypeValidForSerialization(System.Type type);
                /*0x759cc50*/ ClassDataContract(System.Type type);
                /*0x759d908*/ ClassDataContract(System.Type type, System.Xml.XmlDictionaryString ns, string[] memberNames);
                /*0x759d7f0*/ void InitClassDataContract();
                /*0x759dd18*/ System.Runtime.Serialization.ClassDataContract get_BaseContract();
                /*0x759dd34*/ System.Collections.Generic.List<System.Runtime.Serialization.DataMember> get_Members();
                /*0x759dd50*/ System.Xml.XmlDictionaryString[] get_ChildElementNamespaces();
                /*0x759e07c*/ System.Reflection.MethodInfo get_OnSerializing();
                /*0x759e0b8*/ System.Reflection.MethodInfo get_OnSerialized();
                /*0x759e0f4*/ System.Reflection.MethodInfo get_OnDeserializing();
                /*0x759e130*/ System.Reflection.MethodInfo get_OnDeserialized();
                /*0x759e16c*/ System.Reflection.MethodInfo get_ExtensionDataSetMethod();
                /*0x759e1a8*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> get_KnownDataContracts();
                /*0x759e1c8*/ bool get_IsISerializable();
                /*0x759e1e8*/ bool get_IsNonAttributedType();
                /*0x759e204*/ bool get_HasExtensionData();
                /*0x759e220*/ string get_SerializationExceptionMessage();
                /*0x759e23c*/ string get_DeserializationExceptionMessage();
                /*0x759e328*/ bool get_IsReadOnlyContract();
                /*0x759e34c*/ System.Reflection.ConstructorInfo GetISerializableConstructor();
                /*0x759e4ac*/ System.Reflection.ConstructorInfo GetNonAttributedTypeConstructor();
                /*0x759e658*/ System.Runtime.Serialization.XmlFormatClassWriterDelegate get_XmlFormatWriterDelegate();
                /*0x759e7c8*/ System.Runtime.Serialization.XmlFormatClassReaderDelegate get_XmlFormatReaderDelegate();
                /*0x759de8c*/ System.Xml.XmlDictionaryString[] CreateChildElementNamespaces();
                /*0x759f254*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x759f2ac*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
                /*0x759f320*/ bool Equals(object other, System.Collections.Generic.Dictionary<System.Runtime.Serialization.DataContractPairKey, object> checkedContracts);
                /*0x759f784*/ bool IsEveryDataMemberOptional(System.Collections.Generic.IEnumerable<System.Runtime.Serialization.DataMember> dataMembers);
                /*0x759fa6c*/ int GetHashCode();

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

                    static /*0x75a16f0*/ bool IsMethodOverriding(System.Reflection.MethodInfo method);
                    static /*0x75a2440*/ bool IsValidCallback(System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] parameters, System.Type attributeType, System.Reflection.MethodInfo currentCallback, ref System.Type prevAttributeType);
                    static /*0x75a2cf0*/ System.Type[] get_SerInfoCtorArgs();
                    /*0x759ccc4*/ ClassDataContractCriticalHelper(System.Type type);
                    /*0x759d994*/ ClassDataContractCriticalHelper(System.Type type, System.Xml.XmlDictionaryString ns, string[] memberNames);
                    /*0x75a1320*/ void EnsureIsReferenceImported(System.Type type);
                    /*0x75a00f0*/ void ImportDataMembers();
                    /*0x75a1738*/ bool SetIfGetOnlyCollection(System.Runtime.Serialization.DataMember memberContract, bool skipIfReadOnlyContract);
                    /*0x75a17c0*/ void SetIfMembersHaveConflict(System.Collections.Generic.List<System.Runtime.Serialization.DataMember> members);
                    /*0x759fa74*/ System.Xml.XmlQualifiedName GetStableNameAndSetHasDataContract(System.Type type);
                    /*0x759fe88*/ void SetIsNonAttributedType(System.Type type);
                    /*0x759fa88*/ void EnsureMethodsImported();
                    /*0x75a1f60*/ bool IsValidExtensionDataSetMethod(System.Reflection.MethodInfo method, System.Reflection.ParameterInfo[] parameters);
                    /*0x75a2b88*/ System.Runtime.Serialization.ClassDataContract get_BaseContract();
                    /*0x759ff04*/ void set_BaseContract(System.Runtime.Serialization.ClassDataContract value);
                    /*0x75a2b90*/ System.Collections.Generic.List<System.Runtime.Serialization.DataMember> get_Members();
                    /*0x759e0a0*/ System.Reflection.MethodInfo get_OnSerializing();
                    /*0x759e0dc*/ System.Reflection.MethodInfo get_OnSerialized();
                    /*0x759e118*/ System.Reflection.MethodInfo get_OnDeserializing();
                    /*0x759e154*/ System.Reflection.MethodInfo get_OnDeserialized();
                    /*0x759e190*/ System.Reflection.MethodInfo get_ExtensionDataSetMethod();
                    /*0x75a2b98*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> get_KnownDataContracts();
                    /*0x75a2cc8*/ string get_SerializationExceptionMessage();
                    /*0x759e254*/ string get_DeserializationExceptionMessage();
                    /*0x75a2cd0*/ bool get_IsISerializable();
                    /*0x75a2cd8*/ bool get_HasDataContract();
                    /*0x75a2ce0*/ bool get_HasExtensionData();
                    /*0x75a2ce8*/ bool get_IsNonAttributedType();
                    /*0x759e364*/ System.Reflection.ConstructorInfo GetISerializableConstructor();
                    /*0x759e4c4*/ System.Reflection.ConstructorInfo GetNonAttributedTypeConstructor();
                    /*0x75a2e6c*/ System.Runtime.Serialization.XmlFormatClassWriterDelegate get_XmlFormatWriterDelegate();
                    /*0x75a2e74*/ void set_XmlFormatWriterDelegate(System.Runtime.Serialization.XmlFormatClassWriterDelegate value);
                    /*0x75a2e7c*/ System.Runtime.Serialization.XmlFormatClassReaderDelegate get_XmlFormatReaderDelegate();
                    /*0x75a2e84*/ void set_XmlFormatReaderDelegate(System.Runtime.Serialization.XmlFormatClassReaderDelegate value);
                    /*0x75a2e8c*/ System.Xml.XmlDictionaryString[] get_ChildElementNamespaces();
                    /*0x75a2e94*/ void set_ChildElementNamespaces(System.Xml.XmlDictionaryString[] value);

                    struct Member
                    {
                        /*0x10*/ System.Runtime.Serialization.DataMember member;
                        /*0x18*/ string ns;
                        /*0x20*/ int baseTypeIndex;

                        /*0x75a1f24*/ Member(System.Runtime.Serialization.DataMember member, string ns, int baseTypeIndex);
                    }

                    class DataMemberConflictComparer : System.Collections.Generic.IComparer<System.Runtime.Serialization.ClassDataContract.ClassDataContractCriticalHelper.Member>
                    {
                        static /*0x0*/ System.Runtime.Serialization.ClassDataContract.ClassDataContractCriticalHelper.DataMemberConflictComparer Singleton;

                        static /*0x75a2f20*/ DataMemberConflictComparer();
                        /*0x75a2f18*/ DataMemberConflictComparer();
                        /*0x75a2e9c*/ int Compare(System.Runtime.Serialization.ClassDataContract.ClassDataContractCriticalHelper.Member x, System.Runtime.Serialization.ClassDataContract.ClassDataContractCriticalHelper.Member y);
                    }
                }

                class DataMemberComparer : System.Collections.Generic.IComparer<System.Runtime.Serialization.DataMember>
                {
                    static /*0x0*/ System.Runtime.Serialization.ClassDataContract.DataMemberComparer Singleton;

                    static /*0x75a3010*/ DataMemberComparer();
                    /*0x75a3008*/ DataMemberComparer();
                    /*0x75a2f88*/ int Compare(System.Runtime.Serialization.DataMember x, System.Runtime.Serialization.DataMember y);
                }
            }

            struct KeyValue<K, V>
            {
                /*0x0*/ K key;
                /*0x0*/ V value;

                /*0x3907c14*/ KeyValue(K key, V value);
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

                static /*0x75a3690*/ System.Type[] get_KnownInterfaces();
                static /*0x759f170*/ bool IsCollectionInterface(System.Type type);
                static /*0x75a4000*/ bool IsCollection(System.Type type);
                static /*0x75a4024*/ bool IsCollection(System.Type type, ref System.Type itemType);
                static /*0x75a1efc*/ bool IsCollection(System.Type type, bool constructorRequired, bool skipIfReadOnlyContract);
                static /*0x75a4030*/ bool IsCollectionHelper(System.Type type, ref System.Type itemType, bool constructorRequired, bool skipIfReadOnlyContract);
                static /*0x75a541c*/ bool TryCreate(System.Type type, ref System.Runtime.Serialization.DataContract dataContract);
                static /*0x75a5448*/ bool TryCreateGetOnlyCollectionDataContract(System.Type type, ref System.Runtime.Serialization.DataContract dataContract);
                static /*0x75a54fc*/ System.Reflection.MethodInfo GetTargetMethodWithName(string name, System.Type type, System.Type interfaceType);
                static /*0x75a55cc*/ bool IsArraySegment(System.Type t);
                static /*0x75a40d0*/ bool IsCollectionOrTryCreate(System.Type type, bool tryCreate, ref System.Runtime.Serialization.DataContract dataContract, ref System.Type itemType, bool constructorRequired, bool skipIfReadOnlyContract);
                static /*0x75a58b4*/ bool IsCollectionDataContract(System.Type type);
                static /*0x75a568c*/ bool HandleIfInvalidCollection(System.Type type, bool tryCreate, bool hasCollectionDataContract, bool createContractWithException, string message, string param, ref System.Runtime.Serialization.DataContract dataContract);
                static /*0x75a5928*/ void GetReadOnlyCollectionExceptionMessages(System.Type type, bool hasCollectionDataContract, string message, string param, ref string serializationExceptionMessage, ref string deserializationExceptionMessage);
                static /*0x75a5ed0*/ string GetInvalidCollectionMessage(string message, string nestedMessage, string param);
                static /*0x75a5ff8*/ void FindCollectionMethodsOnInterface(System.Type type, System.Type interfaceType, ref System.Reflection.MethodInfo addMethod, ref System.Reflection.MethodInfo getEnumeratorMethod);
                static /*0x75a5afc*/ void GetCollectionMethods(System.Type type, System.Type interfaceType, System.Type[] addMethodTypeArray, bool addMethodOnInterface, ref System.Reflection.MethodInfo getEnumeratorMethod, ref System.Reflection.MethodInfo addMethod);
                static /*0x75a6160*/ bool IsKnownInterface(System.Type type);
                /*0x75a3078*/ CollectionDataContract(System.Type type);
                /*0x75a3220*/ CollectionDataContract(System.Type type, System.Runtime.Serialization.DataContract itemContract);
                /*0x75a32a4*/ CollectionDataContract(System.Type type, System.Runtime.Serialization.CollectionKind kind, System.Type itemType, System.Reflection.MethodInfo getEnumeratorMethod, string serializationExceptionMessage, string deserializationExceptionMessage);
                /*0x75a3468*/ CollectionDataContract(System.Type type, System.Runtime.Serialization.CollectionKind kind, System.Type itemType, System.Reflection.MethodInfo getEnumeratorMethod, System.Reflection.MethodInfo addMethod, System.Reflection.ConstructorInfo constructor);
                /*0x75a3528*/ CollectionDataContract(System.Type type, System.Runtime.Serialization.CollectionKind kind, System.Type itemType, System.Reflection.MethodInfo getEnumeratorMethod, System.Reflection.MethodInfo addMethod, System.Reflection.ConstructorInfo constructor, bool isConstructorCheckRequired);
                /*0x75a3600*/ CollectionDataContract(System.Type type, string invalidCollectionInSharedContractMessage);
                /*0x75a30f4*/ void InitCollectionDataContract(System.Runtime.Serialization.DataContract sharedTypeContract);
                /*0x75a3698*/ System.Runtime.Serialization.CollectionKind get_Kind();
                /*0x75a36b4*/ System.Type get_ItemType();
                /*0x75a36d0*/ System.Runtime.Serialization.DataContract get_ItemContract();
                /*0x759fee8*/ System.Runtime.Serialization.DataContract get_SharedTypeContract();
                /*0x75a3700*/ string get_ItemName();
                /*0x75a371c*/ System.Xml.XmlDictionaryString get_CollectionItemName();
                /*0x75a3724*/ string get_KeyName();
                /*0x75a3740*/ bool get_IsDictionary();
                /*0x75a3764*/ System.Xml.XmlDictionaryString get_ChildElementNamespace();
                /*0x75a38f4*/ bool get_IsItemTypeNullable();
                /*0x75a3910*/ bool get_IsConstructorCheckRequired();
                /*0x75a392c*/ void set_IsConstructorCheckRequired(bool value);
                /*0x75a394c*/ System.Reflection.MethodInfo get_GetEnumeratorMethod();
                /*0x75a3968*/ System.Reflection.MethodInfo get_AddMethod();
                /*0x75a3984*/ System.Reflection.ConstructorInfo get_Constructor();
                /*0x75a39a0*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> get_KnownDataContracts();
                /*0x75a39c0*/ string get_InvalidCollectionInSharedContractMessage();
                /*0x75a39dc*/ string get_SerializationExceptionMessage();
                /*0x75a39f8*/ string get_DeserializationExceptionMessage();
                /*0x75a3a14*/ bool get_IsReadOnlyContract();
                /*0x75a3a38*/ System.Runtime.Serialization.XmlFormatCollectionWriterDelegate get_XmlFormatWriterDelegate();
                /*0x75a3ba8*/ System.Runtime.Serialization.XmlFormatCollectionReaderDelegate get_XmlFormatReaderDelegate();
                /*0x75a3d30*/ System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate get_XmlFormatGetOnlyCollectionReaderDelegate();
                /*0x75a3364*/ System.Runtime.Serialization.DataContract GetSharedTypeContract(System.Type type);
                /*0x75a6240*/ System.Runtime.Serialization.DataContract GetValidContract(System.Runtime.Serialization.SerializationMode mode);
                /*0x75a629c*/ void ThrowIfInvalid();
                /*0x75a6314*/ System.Runtime.Serialization.DataContract GetValidContract();
                /*0x75a6344*/ void CheckConstructor();
                /*0x75a647c*/ bool IsValidContract(System.Runtime.Serialization.SerializationMode mode);
                /*0x75a64bc*/ bool Equals(object other, System.Collections.Generic.Dictionary<System.Runtime.Serialization.DataContractPairKey, object> checkedContracts);
                /*0x75a6660*/ int GetHashCode();
                /*0x75a6668*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75a66dc*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);

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

                    static /*0x75a67f0*/ System.Type[] get_KnownInterfaces();
                    /*0x75a7bc4*/ CollectionDataContractCriticalHelper(System.Type type);
                    /*0x75a7fdc*/ CollectionDataContractCriticalHelper(System.Type type, System.Runtime.Serialization.DataContract itemContract);
                    /*0x75a8210*/ CollectionDataContractCriticalHelper(System.Type type, System.Runtime.Serialization.CollectionKind kind, System.Type itemType, System.Reflection.MethodInfo getEnumeratorMethod, string serializationExceptionMessage, string deserializationExceptionMessage);
                    /*0x75a84f4*/ CollectionDataContractCriticalHelper(System.Type type, System.Runtime.Serialization.CollectionKind kind, System.Type itemType, System.Reflection.MethodInfo getEnumeratorMethod, System.Reflection.MethodInfo addMethod, System.Reflection.ConstructorInfo constructor);
                    /*0x75a8620*/ CollectionDataContractCriticalHelper(System.Type type, System.Runtime.Serialization.CollectionKind kind, System.Type itemType, System.Reflection.MethodInfo getEnumeratorMethod, System.Reflection.MethodInfo addMethod, System.Reflection.ConstructorInfo constructor, bool isConstructorCheckRequired);
                    /*0x75a8644*/ CollectionDataContractCriticalHelper(System.Type type, string invalidCollectionInSharedContractMessage);
                    /*0x75a72e4*/ void Init(System.Runtime.Serialization.CollectionKind kind, System.Type itemType, System.Runtime.Serialization.CollectionDataContractAttribute collectionContractAttribute);
                    /*0x75a86d0*/ System.Runtime.Serialization.CollectionKind get_Kind();
                    /*0x75a86d8*/ System.Type get_ItemType();
                    /*0x75a86e0*/ System.Runtime.Serialization.DataContract get_ItemContract();
                    /*0x75a896c*/ System.Runtime.Serialization.DataContract get_SharedTypeContract();
                    /*0x75a8974*/ void set_SharedTypeContract(System.Runtime.Serialization.DataContract value);
                    /*0x75a897c*/ string get_ItemName();
                    /*0x75a8984*/ bool get_IsConstructorCheckRequired();
                    /*0x75a898c*/ void set_IsConstructorCheckRequired(bool value);
                    /*0x75a8998*/ System.Xml.XmlDictionaryString get_CollectionItemName();
                    /*0x75a89a0*/ string get_KeyName();
                    /*0x75a89a8*/ string get_ValueName();
                    /*0x75a88d8*/ bool get_IsDictionary();
                    /*0x75a89b0*/ string get_SerializationExceptionMessage();
                    /*0x75a89b8*/ string get_DeserializationExceptionMessage();
                    /*0x75a89c0*/ System.Xml.XmlDictionaryString get_ChildElementNamespace();
                    /*0x75a89c8*/ void set_ChildElementNamespace(System.Xml.XmlDictionaryString value);
                    /*0x75a89d0*/ bool get_IsItemTypeNullable();
                    /*0x75a89d8*/ System.Reflection.MethodInfo get_GetEnumeratorMethod();
                    /*0x75a89e0*/ System.Reflection.MethodInfo get_AddMethod();
                    /*0x75a89e8*/ System.Reflection.ConstructorInfo get_Constructor();
                    /*0x75a89f0*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> get_KnownDataContracts();
                    /*0x75a8ba4*/ string get_InvalidCollectionInSharedContractMessage();
                    /*0x75a8bac*/ System.Runtime.Serialization.XmlFormatCollectionWriterDelegate get_XmlFormatWriterDelegate();
                    /*0x75a8bb4*/ void set_XmlFormatWriterDelegate(System.Runtime.Serialization.XmlFormatCollectionWriterDelegate value);
                    /*0x75a8bbc*/ System.Runtime.Serialization.XmlFormatCollectionReaderDelegate get_XmlFormatReaderDelegate();
                    /*0x75a8bc4*/ void set_XmlFormatReaderDelegate(System.Runtime.Serialization.XmlFormatCollectionReaderDelegate value);
                    /*0x75a8bcc*/ System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate get_XmlFormatGetOnlyCollectionReaderDelegate();
                    /*0x75a8bd4*/ void set_XmlFormatGetOnlyCollectionReaderDelegate(System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate value);
                }

                class DictionaryEnumerator : System.Collections.Generic.IEnumerator<System.Runtime.Serialization.KeyValue<object, object>>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x10*/ System.Collections.IDictionaryEnumerator enumerator;

                    /*0x75a8bdc*/ DictionaryEnumerator(System.Collections.IDictionaryEnumerator enumerator);
                    /*0x75a8c0c*/ void Dispose();
                    /*0x75a8c10*/ bool MoveNext();
                    /*0x75a8cb0*/ System.Runtime.Serialization.KeyValue<object, object> get_Current();
                    /*0x75a8df4*/ object System.Collections.IEnumerator.get_Current();
                    /*0x75a8e58*/ void Reset();
                }

                class GenericDictionaryEnumerator<K, V> : System.Collections.Generic.IEnumerator<System.Runtime.Serialization.KeyValue<K, V>>, System.IDisposable, System.Collections.IEnumerator
                {
                    /*0x0*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<K, V>> enumerator;

                    /*0x380cb08*/ void Dispose();
                    /*0x380b128*/ bool MoveNext();
                    /*0x3907c14*/ System.Runtime.Serialization.KeyValue<K, V> get_Current();
                    /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                    /*0x380cb08*/ void Reset();
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

                /*0x75a8efc*/ string get_Namespace();
                /*0x75a8f04*/ bool get_IsNamespaceSetExplicitly();
                /*0x75a8f0c*/ string get_Name();
                /*0x75a8f14*/ bool get_IsNameSetExplicitly();
                /*0x75a8f1c*/ string get_ItemName();
                /*0x75a8f24*/ bool get_IsItemNameSetExplicitly();
                /*0x75a8f2c*/ string get_KeyName();
                /*0x75a8f34*/ bool get_IsReference();
                /*0x75a8f3c*/ bool get_IsKeyNameSetExplicitly();
                /*0x75a8f44*/ string get_ValueName();
                /*0x75a8f4c*/ bool get_IsValueNameSetExplicitly();
            }

            class ContractNamespaceAttribute : System.Attribute
            {
                /*0x10*/ string clrNamespace;
                /*0x18*/ string contractNamespace;

                /*0x75a8f54*/ string get_ClrNamespace();
                /*0x75a8f5c*/ string get_ContractNamespace();
            }

            class DataContract
            {
                /*0x10*/ System.Xml.XmlDictionaryString name;
                /*0x18*/ System.Xml.XmlDictionaryString ns;
                /*0x20*/ System.Runtime.Serialization.DataContract.DataContractCriticalHelper helper;

                static /*0x75a8938*/ System.Runtime.Serialization.DataContract GetDataContract(System.Type type);
                static /*0x75a8fbc*/ System.Runtime.Serialization.DataContract GetDataContract(System.RuntimeTypeHandle typeHandle, System.Type type, System.Runtime.Serialization.SerializationMode mode);
                static /*0x75a9038*/ System.Runtime.Serialization.DataContract GetDataContract(int id, System.RuntimeTypeHandle typeHandle, System.Runtime.Serialization.SerializationMode mode);
                static /*0x75a9068*/ System.Runtime.Serialization.DataContract GetDataContractSkipValidation(int id, System.RuntimeTypeHandle typeHandle, System.Type type);
                static /*0x75a919c*/ System.Runtime.Serialization.DataContract GetGetOnlyCollectionDataContract(int id, System.RuntimeTypeHandle typeHandle, System.Type type, System.Runtime.Serialization.SerializationMode mode);
                static /*0x75a92f0*/ System.Runtime.Serialization.DataContract GetGetOnlyCollectionDataContractSkipValidation(int id, System.RuntimeTypeHandle typeHandle, System.Type type);
                static /*0x75a9434*/ System.Runtime.Serialization.DataContract GetDataContractForInitialization(int id);
                static /*0x75a9568*/ int GetIdForInitialization(System.Runtime.Serialization.ClassDataContract classContract);
                static /*0x75a8fe4*/ int GetId(System.RuntimeTypeHandle typeHandle);
                static /*0x75a9ab4*/ System.Runtime.Serialization.DataContract GetBuiltInDataContract(System.Type type);
                static /*0x75a9db4*/ System.Runtime.Serialization.DataContract GetBuiltInDataContract(string name, string ns);
                static /*0x75aa0b8*/ System.Runtime.Serialization.DataContract GetBuiltInDataContract(string typeName);
                static /*0x75aae70*/ string GetNamespace(string key);
                static /*0x75ab1e8*/ System.Xml.XmlDictionaryString GetClrTypeString(string key);
                static /*0x75a88e8*/ void ThrowInvalidDataContractException(string message, System.Type type);
                static /*0x75ac14c*/ bool IsTypeSerializable(System.Type type);
                static /*0x75ac1c4*/ bool IsTypeSerializable(System.Type type, System.Collections.Generic.Dictionary<System.Type, object> previousCollectionTypes);
                static /*0x75ac514*/ void ValidatePreviousCollectionTypes(System.Type collectionType, System.Type itemType, System.Collections.Generic.Dictionary<System.Type, object> previousCollectionTypes);
                static /*0x75ac8fc*/ System.Type UnwrapRedundantNullableType(System.Type type);
                static /*0x75a7ab0*/ System.Type UnwrapNullableType(System.Type type);
                static /*0x75acb2c*/ bool IsAlpha(char ch);
                static /*0x75acb58*/ bool IsDigit(char ch);
                static /*0x75acb6c*/ bool IsAsciiLocalName(string localName);
                static /*0x75a7a30*/ string EncodeLocalName(string localName);
                static /*0x75acc2c*/ bool IsValidNCName(string name);
                static /*0x75a7bac*/ System.Xml.XmlQualifiedName GetStableName(System.Type type);
                static /*0x75acd04*/ System.Xml.XmlQualifiedName GetStableName(System.Type type, ref bool hasDataContract);
                static /*0x75acd84*/ System.Xml.XmlQualifiedName GetStableName(System.Type type, System.Collections.Generic.Dictionary<System.Type, object> previousCollectionTypes, ref bool hasDataContract);
                static /*0x75ad0a0*/ System.Xml.XmlQualifiedName GetDCTypeStableName(System.Type type, System.Runtime.Serialization.DataContractAttribute dataContractAttribute);
                static /*0x75ad26c*/ System.Xml.XmlQualifiedName GetNonDCTypeStableName(System.Type type, System.Collections.Generic.Dictionary<System.Type, object> previousCollectionTypes);
                static /*0x75ace10*/ bool TryGetBuiltInXmlAndArrayTypeStableName(System.Type type, System.Collections.Generic.Dictionary<System.Type, object> previousCollectionTypes, ref System.Xml.XmlQualifiedName stableName);
                static /*0x75acf94*/ bool TryGetDCAttribute(System.Type type, ref System.Runtime.Serialization.DataContractAttribute dataContractAttribute);
                static /*0x75a8464*/ System.Xml.XmlQualifiedName GetCollectionStableName(System.Type type, System.Type itemType, ref System.Runtime.Serialization.CollectionDataContractAttribute collectionContractAttribute);
                static /*0x75ade10*/ System.Xml.XmlQualifiedName GetCollectionStableName(System.Type type, System.Type itemType, System.Collections.Generic.Dictionary<System.Type, object> previousCollectionTypes, ref System.Runtime.Serialization.CollectionDataContractAttribute collectionContractAttribute);
                static /*0x75ae2d8*/ string GetArrayPrefix(ref System.Type itemType);
                static /*0x75ae39c*/ string GetCollectionNamespace(string elementNs);
                static /*0x75ae474*/ System.Xml.XmlQualifiedName GetDefaultStableName(System.Type type);
                static /*0x75ad370*/ string GetDefaultStableLocalName(System.Type type);
                static /*0x75add54*/ string GetDefaultDataContractNamespace(System.Type type);
                static /*0x75ae4a4*/ System.Collections.Generic.IList<int> GetDataContractNameForGenericName(string typeName, System.Text.StringBuilder localName);
                static /*0x75ae3f0*/ bool IsBuiltInNamespace(string ns);
                static /*0x75ae150*/ string GetDefaultStableNamespace(System.Type type);
                static /*0x75a8194*/ System.Xml.XmlQualifiedName CreateQualifiedName(string localName, string ns);
                static /*0x75aed04*/ string GetDefaultStableNamespace(string clrNs);
                static /*0x75adb34*/ void CheckExplicitDataContractNamespaceUri(string dataContractNs, System.Type type);
                static /*0x75a7930*/ string GetClrTypeFullName(System.Type type);
                static /*0x75aeebc*/ string GetClrAssemblyName(System.Type type, ref bool hasTypeForwardedFrom);
                static /*0x75aefd8*/ string GetClrTypeFullNameUsingTypeForwardedFromAttribute(System.Type type);
                static /*0x75af00c*/ string GetClrTypeFullNameForArray(System.Type type);
                static /*0x75af0e4*/ string GetClrTypeFullNameForNonArrayTypes(System.Type type);
                static /*0x75af35c*/ void GetClrNameAndNamespace(string fullTypeName, ref string localName, ref string ns);
                static /*0x75af470*/ void GetDefaultStableName(string fullTypeName, ref string localName, ref string ns);
                static /*0x75af4e4*/ void GetDefaultStableName(System.Runtime.Serialization.CodeTypeReference typeReference, ref string localName, ref string ns);
                static /*0x75aea14*/ string GetGlobalDataContractNamespace(string clrNs, System.Reflection.ICustomAttributeProvider customAttribuetProvider);
                static /*0x75ae850*/ string GetNamespacesDigest(string namespaces);
                static /*0x75ad308*/ string ExpandGenericParameters(string format, System.Type type);
                static /*0x75afc20*/ string ExpandGenericParameters(string format, System.Runtime.Serialization.IGenericNameProvider genericNameProvider);
                static /*0x75a784c*/ bool IsTypeNullable(System.Type type);
                static /*0x75b0600*/ void ThrowTypeNotSerializable(System.Type type);
                static /*0x75a8b1c*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> ImportKnownTypeAttributes(System.Type type);
                static /*0x75b0694*/ void ImportKnownTypeAttributes(System.Type type, System.Collections.Generic.Dictionary<System.Type, System.Type> typesChecked, ref System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> knownDataContracts);
                static /*0x75b1740*/ void LoadKnownTypesFromConfig(System.Type type, System.Collections.Generic.Dictionary<System.Type, System.Type> typesChecked, ref System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> knownDataContracts);
                static /*0x75b11ac*/ void CheckAndAdd(System.Type type, System.Collections.Generic.Dictionary<System.Type, System.Type> typesChecked, ref System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> nameToDataContractTable);
                /*0x75a8f64*/ DataContract(System.Runtime.Serialization.DataContract.DataContractCriticalHelper helper);
                /*0x75abad8*/ System.Runtime.Serialization.DataContract.DataContractCriticalHelper get_Helper();
                /*0x75a935c*/ System.Type get_UnderlyingType();
                /*0x75abae0*/ System.Type get_OriginalUnderlyingType();
                /*0x75abb9c*/ bool get_IsBuiltInDataContract();
                /*0x75abbbc*/ System.Type get_TypeForInitialization();
                /*0x75abbd8*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75abccc*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
                /*0x75abdc0*/ bool get_IsValueType();
                /*0x75abddc*/ bool get_IsReference();
                /*0x75a8178*/ System.Xml.XmlQualifiedName get_StableName();
                /*0x75abdf8*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> get_KnownDataContracts();
                /*0x75abe18*/ bool get_IsISerializable();
                /*0x75abe38*/ System.Xml.XmlDictionaryString get_Name();
                /*0x75abe40*/ System.Xml.XmlDictionaryString get_Namespace();
                /*0x75abe48*/ bool get_HasRoot();
                /*0x75abe50*/ System.Xml.XmlDictionaryString get_TopLevelElementName();
                /*0x75abe70*/ System.Xml.XmlDictionaryString get_TopLevelElementNamespace();
                /*0x75abe90*/ bool get_CanContainReferences();
                /*0x75abe98*/ bool get_IsPrimitive();
                /*0x75abea0*/ void WriteRootElement(System.Runtime.Serialization.XmlWriterDelegator writer, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75abf90*/ System.Runtime.Serialization.DataContract GetValidContract(System.Runtime.Serialization.SerializationMode mode);
                /*0x75abf94*/ System.Runtime.Serialization.DataContract GetValidContract();
                /*0x75abf98*/ bool IsValidContract(System.Runtime.Serialization.SerializationMode mode);
                /*0x75abfa0*/ System.Reflection.MethodInfo get_ParseMethod();
                /*0x75b17ec*/ bool Equals(object other);
                /*0x75b1888*/ bool Equals(object other, System.Collections.Generic.Dictionary<System.Runtime.Serialization.DataContractPairKey, object> checkedContracts);
                /*0x75b19a4*/ bool IsEqualOrChecked(object other, System.Collections.Generic.Dictionary<System.Runtime.Serialization.DataContractPairKey, object> checkedContracts);
                /*0x75b1ab8*/ int GetHashCode();

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

                    static /*0x75b1ac0*/ DataContractCriticalHelper();
                    static /*0x75a90d4*/ System.Runtime.Serialization.DataContract GetDataContractSkipValidation(int id, System.RuntimeTypeHandle typeHandle, System.Type type);
                    static /*0x75a9378*/ System.Runtime.Serialization.DataContract GetGetOnlyCollectionDataContractSkipValidation(int id, System.RuntimeTypeHandle typeHandle, System.Type type);
                    static /*0x75a9488*/ System.Runtime.Serialization.DataContract GetDataContractForInitialization(int id);
                    static /*0x75a95bc*/ int GetIdForInitialization(System.Runtime.Serialization.ClassDataContract classContract);
                    static /*0x75b26c8*/ bool ContractMatches(System.Runtime.Serialization.DataContract contract, System.Runtime.Serialization.DataContract cachedContract);
                    static /*0x75a9790*/ int GetId(System.RuntimeTypeHandle typeHandle);
                    static /*0x75b27f4*/ System.Runtime.Serialization.IntRef GetNextId();
                    static /*0x75b1d04*/ System.Runtime.Serialization.DataContract CreateDataContract(int id, System.RuntimeTypeHandle typeHandle, System.Type type);
                    static /*0x75b2560*/ void AssignDataContractToId(System.Runtime.Serialization.DataContract dataContract, int id);
                    static /*0x75b22a0*/ System.Runtime.Serialization.DataContract CreateGetOnlyCollectionDataContract(int id, System.RuntimeTypeHandle typeHandle, System.Type type);
                    static /*0x75b1744*/ System.Type GetDataContractAdapterType(System.Type type);
                    static /*0x75b2e80*/ System.Type GetDataContractOriginalType(System.Type type);
                    static /*0x75b2734*/ System.RuntimeTypeHandle GetDataContractAdapterTypeHandle(System.RuntimeTypeHandle typeHandle);
                    static /*0x75a9b08*/ System.Runtime.Serialization.DataContract GetBuiltInDataContract(System.Type type);
                    static /*0x75a9e18*/ System.Runtime.Serialization.DataContract GetBuiltInDataContract(string name, string ns);
                    static /*0x75aa10c*/ System.Runtime.Serialization.DataContract GetBuiltInDataContract(string typeName);
                    static /*0x75b3024*/ bool TryCreateBuiltInDataContract(System.Type type, ref System.Runtime.Serialization.DataContract dataContract);
                    static /*0x75b3838*/ bool TryCreateBuiltInDataContract(string name, string ns, ref System.Runtime.Serialization.DataContract dataContract);
                    static /*0x75aaec4*/ string GetNamespace(string key);
                    static /*0x75ab23c*/ System.Xml.XmlDictionaryString GetClrTypeString(string key);
                    static /*0x75ab7ac*/ void ThrowInvalidDataContractException(string message, System.Type type);
                    /*0x75a7d88*/ DataContractCriticalHelper(System.Type type);
                    /*0x75b4eac*/ System.Type get_UnderlyingType();
                    /*0x75abaf8*/ System.Type get_OriginalUnderlyingType();
                    /*0x75b4eb4*/ bool get_IsBuiltInDataContract();
                    /*0x75b4ebc*/ System.Type get_TypeForInitialization();
                    /*0x75b4e00*/ void SetTypeForInitialization(System.Type classType);
                    /*0x75b4ec4*/ bool get_IsReference();
                    /*0x75b4ecc*/ void set_IsReference(bool value);
                    /*0x75b4ed8*/ bool get_IsValueType();
                    /*0x75b4ee0*/ void set_IsValueType(bool value);
                    /*0x75b4eec*/ System.Xml.XmlQualifiedName get_StableName();
                    /*0x75b4ef4*/ void set_StableName(System.Xml.XmlQualifiedName value);
                    /*0x75b4efc*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> get_KnownDataContracts();
                    /*0x75b4f04*/ bool get_IsISerializable();
                    /*0x75b4f0c*/ System.Xml.XmlDictionaryString get_Name();
                    /*0x75b4f14*/ void set_Name(System.Xml.XmlDictionaryString value);
                    /*0x75b4f1c*/ System.Xml.XmlDictionaryString get_Namespace();
                    /*0x75b4f24*/ void set_Namespace(System.Xml.XmlDictionaryString value);
                    /*0x75b4f2c*/ bool get_HasRoot();
                    /*0x75b4f34*/ void set_HasRoot(bool value);
                    /*0x75b4f38*/ System.Xml.XmlDictionaryString get_TopLevelElementName();
                    /*0x75b4f40*/ System.Xml.XmlDictionaryString get_TopLevelElementNamespace();
                    /*0x75abfb8*/ System.Reflection.MethodInfo get_ParseMethod();
                    /*0x75b503c*/ void SetDataContractName(System.Xml.XmlQualifiedName stableName);
                    /*0x75b5100*/ void SetDataContractName(System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                    /*0x75b515c*/ void ThrowInvalidDataContractException(string message);
                }
            }

            interface IGenericNameProvider
            {
                /*0x380b6a0*/ int GetParameterCount();
                /*0x380b9e8*/ System.Collections.Generic.IList<int> GetNestedParameterCounts();
                /*0x380ba90*/ string GetParameterName(int paramIndex);
                /*0x380b9e8*/ string GetNamespaces();
                /*0x380b9e8*/ string GetGenericTypeName();
                /*0x380b128*/ bool get_ParametersFromBuiltInNamespaces();
            }

            class GenericNameProvider : System.Runtime.Serialization.IGenericNameProvider
            {
                /*0x10*/ string genericTypeName;
                /*0x18*/ object[] genericParams;
                /*0x20*/ System.Collections.Generic.IList<int> nestedParamCounts;

                /*0x75afbc0*/ GenericNameProvider(System.Type type);
                /*0x75b51b0*/ GenericNameProvider(string genericTypeName, object[] genericParams);
                /*0x75b5294*/ int GetParameterCount();
                /*0x75b52b0*/ System.Collections.Generic.IList<int> GetNestedParameterCounts();
                /*0x75b52b8*/ string GetParameterName(int paramIndex);
                /*0x75b54cc*/ string GetNamespaces();
                /*0x75b55ac*/ string GetGenericTypeName();
                /*0x75b55b4*/ bool get_ParametersFromBuiltInNamespaces();
                /*0x75b52d4*/ System.Xml.XmlQualifiedName GetStableName(int i);
            }

            class DataContractPairKey
            {
                /*0x10*/ object object1;
                /*0x18*/ object object2;

                /*0x75b1a74*/ DataContractPairKey(object object1, object object2);
                /*0x75b5618*/ bool Equals(object other);
                /*0x75b56e4*/ int GetHashCode();
            }

            class TypeHandleRefEqualityComparer : System.Collections.Generic.IEqualityComparer<System.Runtime.Serialization.TypeHandleRef>
            {
                /*0x75b1cfc*/ TypeHandleRefEqualityComparer();
                /*0x75b572c*/ bool Equals(System.Runtime.Serialization.TypeHandleRef x, System.Runtime.Serialization.TypeHandleRef y);
                /*0x75b5764*/ int GetHashCode(System.Runtime.Serialization.TypeHandleRef obj);
            }

            class TypeHandleRef
            {
                /*0x10*/ System.RuntimeTypeHandle value;

                /*0x75b1cf4*/ TypeHandleRef();
                /*0x75b2950*/ TypeHandleRef(System.RuntimeTypeHandle value);
                /*0x75b5790*/ System.RuntimeTypeHandle get_Value();
                /*0x75b5798*/ void set_Value(System.RuntimeTypeHandle value);
            }

            class IntRef
            {
                /*0x10*/ int value;

                /*0x75b2978*/ IntRef(int value);
                /*0x75b57a0*/ int get_Value();
            }

            class DataContractAttribute : System.Attribute
            {
                /*0x10*/ string name;
                /*0x18*/ string ns;
                /*0x20*/ bool isNameSetExplicitly;
                /*0x21*/ bool isNamespaceSetExplicitly;
                /*0x22*/ bool isReference;
                /*0x23*/ bool isReferenceSetExplicitly;

                /*0x75b57a8*/ DataContractAttribute();
                /*0x75b57b0*/ bool get_IsReference();
                /*0x75b57b8*/ bool get_IsReferenceSetExplicitly();
                /*0x75b57c0*/ string get_Namespace();
                /*0x75b57c8*/ void set_Namespace(string value);
                /*0x75b57ec*/ bool get_IsNamespaceSetExplicitly();
                /*0x75b57f4*/ string get_Name();
                /*0x75b57fc*/ void set_Name(string value);
                /*0x75b5820*/ bool get_IsNameSetExplicitly();
            }

            class DataContractResolver
            {
                /*0x75b5828*/ DataContractResolver();
                /*0x380b3b4*/ bool TryResolveType(System.Type type, System.Type declaredType, System.Runtime.Serialization.DataContractResolver knownTypeResolver, ref System.Xml.XmlDictionaryString typeName, ref System.Xml.XmlDictionaryString typeNamespace);
                /*0x380bd7c*/ System.Type ResolveName(string typeName, string typeNamespace, System.Type declaredType, System.Runtime.Serialization.DataContractResolver knownTypeResolver);
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

                static /*0x75b6818*/ System.Runtime.Serialization.DataContract GetDataContract(System.Runtime.Serialization.DataContract declaredTypeContract, System.Type declaredType, System.Type objectType);
                static /*0x75b6764*/ object SurrogateToDataContractType(System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate, object oldObj, System.Type surrogatedDeclaredType, ref System.Type objType);
                static /*0x75b5ee4*/ System.Type GetSurrogatedType(System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate, System.Type type);
                /*0x75b5830*/ DataContractSerializer(System.Type type, System.Collections.Generic.IEnumerable<System.Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate);
                /*0x75b58a8*/ DataContractSerializer(System.Type type, System.Collections.Generic.IEnumerable<System.Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate, System.Runtime.Serialization.DataContractResolver dataContractResolver);
                /*0x75b592c*/ void Initialize(System.Type type, System.Collections.Generic.IEnumerable<System.Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate, System.Runtime.Serialization.DataContractResolver dataContractResolver, bool serializeReadOnlyTypes);
                /*0x75b5df8*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> get_KnownDataContracts();
                /*0x75b5e38*/ int get_MaxItemsInObjectGraph();
                /*0x75b5e40*/ System.Runtime.Serialization.IDataContractSurrogate get_DataContractSurrogate();
                /*0x75b5e48*/ bool get_PreserveObjectReferences();
                /*0x75b5e50*/ bool get_IgnoreExtensionDataObject();
                /*0x75b5e58*/ System.Runtime.Serialization.DataContractResolver get_DataContractResolver();
                /*0x75b5e60*/ bool get_SerializeReadOnlyTypes();
                /*0x75b5e68*/ System.Runtime.Serialization.DataContract get_RootContract();
                /*0x75b5f08*/ void InternalWriteObject(System.Runtime.Serialization.XmlWriterDelegator writer, object graph);
                /*0x75b5f1c*/ void InternalWriteObject(System.Runtime.Serialization.XmlWriterDelegator writer, object graph, System.Runtime.Serialization.DataContractResolver dataContractResolver);
                /*0x75b6374*/ void WriteStartObject(System.Xml.XmlWriter writer, object graph);
                /*0x75b63ec*/ void WriteObjectContent(System.Xml.XmlWriter writer, object graph);
                /*0x75b6464*/ void WriteEndObject(System.Xml.XmlWriter writer);
                /*0x75b64d4*/ void WriteStartObject(System.Xml.XmlDictionaryWriter writer, object graph);
                /*0x75b654c*/ void WriteObjectContent(System.Xml.XmlDictionaryWriter writer, object graph);
                /*0x75b65c4*/ void WriteEndObject(System.Xml.XmlDictionaryWriter writer);
                /*0x75b6634*/ object ReadObject(System.Xml.XmlReader reader, bool verifyObjectName);
                /*0x75b66ac*/ object ReadObject(System.Xml.XmlDictionaryReader reader, bool verifyObjectName);
                /*0x75b6724*/ void InternalWriteStartObject(System.Runtime.Serialization.XmlWriterDelegator writer, object graph);
                /*0x75b675c*/ void InternalWriteObjectContent(System.Runtime.Serialization.XmlWriterDelegator writer, object graph);
                /*0x75b5f80*/ void InternalWriteObjectContent(System.Runtime.Serialization.XmlWriterDelegator writer, object graph, System.Runtime.Serialization.DataContractResolver dataContractResolver);
                /*0x75b68a8*/ void InternalWriteEndObject(System.Runtime.Serialization.XmlWriterDelegator writer);
                /*0x75b6900*/ object InternalReadObject(System.Runtime.Serialization.XmlReaderDelegator xmlReader, bool verifyObjectName);
                /*0x75b6918*/ object InternalReadObject(System.Runtime.Serialization.XmlReaderDelegator xmlReader, bool verifyObjectName, System.Runtime.Serialization.DataContractResolver dataContractResolver);
                /*0x75b6c80*/ bool InternalIsStartObject(System.Runtime.Serialization.XmlReaderDelegator reader);
                /*0x75b6cb4*/ System.Type GetSerializeType(object graph);
                /*0x75b6ccc*/ System.Type GetDeserializeType();
            }

            class DataMember
            {
                /*0x10*/ System.Runtime.Serialization.DataMember.CriticalHelper helper;

                /*0x75b6cd4*/ DataMember(System.Reflection.MemberInfo memberInfo);
                /*0x75b6d9c*/ System.Reflection.MemberInfo get_MemberInfo();
                /*0x75b6db8*/ string get_Name();
                /*0x75b6dd4*/ void set_Name(string value);
                /*0x75b6df0*/ int get_Order();
                /*0x75b6e0c*/ void set_Order(int value);
                /*0x75b6e28*/ bool get_IsRequired();
                /*0x75b6e44*/ void set_IsRequired(bool value);
                /*0x75b6e64*/ bool get_EmitDefaultValue();
                /*0x75b6e80*/ void set_EmitDefaultValue(bool value);
                /*0x75b6ea0*/ bool get_IsNullable();
                /*0x75b6ebc*/ void set_IsNullable(bool value);
                /*0x75b6edc*/ bool get_IsGetOnlyCollection();
                /*0x75b6ef8*/ void set_IsGetOnlyCollection(bool value);
                /*0x75b6f18*/ System.Type get_MemberType();
                /*0x75b7030*/ System.Runtime.Serialization.DataContract get_MemberTypeContract();
                /*0x75b7118*/ bool get_HasConflictingNameAndType();
                /*0x75b7134*/ void set_HasConflictingNameAndType(bool value);
                /*0x75b7154*/ System.Runtime.Serialization.DataMember get_ConflictingMember();
                /*0x75b7170*/ void set_ConflictingMember(System.Runtime.Serialization.DataMember value);
                /*0x75b718c*/ bool Equals(object other, System.Collections.Generic.Dictionary<System.Runtime.Serialization.DataContractPairKey, object> checkedContracts);
                /*0x75b736c*/ int GetHashCode();

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

                    /*0x75b6d64*/ CriticalHelper(System.Reflection.MemberInfo memberInfo);
                    /*0x75b7374*/ System.Reflection.MemberInfo get_MemberInfo();
                    /*0x75b737c*/ string get_Name();
                    /*0x75b7384*/ void set_Name(string value);
                    /*0x75b738c*/ int get_Order();
                    /*0x75b7394*/ void set_Order(int value);
                    /*0x75b739c*/ bool get_IsRequired();
                    /*0x75b73a4*/ void set_IsRequired(bool value);
                    /*0x75b73b0*/ bool get_EmitDefaultValue();
                    /*0x75b73b8*/ void set_EmitDefaultValue(bool value);
                    /*0x75b73c4*/ bool get_IsNullable();
                    /*0x75b73cc*/ void set_IsNullable(bool value);
                    /*0x75b73d8*/ bool get_IsGetOnlyCollection();
                    /*0x75b73e0*/ void set_IsGetOnlyCollection(bool value);
                    /*0x75b6f30*/ System.Type get_MemberType();
                    /*0x75b7048*/ System.Runtime.Serialization.DataContract get_MemberTypeContract();
                    /*0x75b73ec*/ bool get_HasConflictingNameAndType();
                    /*0x75b73f4*/ void set_HasConflictingNameAndType(bool value);
                    /*0x75b7400*/ System.Runtime.Serialization.DataMember get_ConflictingMember();
                    /*0x75b7408*/ void set_ConflictingMember(System.Runtime.Serialization.DataMember value);
                }
            }

            class DataMemberAttribute : System.Attribute
            {
                /*0x10*/ string name;
                /*0x18*/ bool isNameSetExplicitly;
                /*0x1c*/ int order;
                /*0x20*/ bool isRequired;
                /*0x21*/ bool emitDefaultValue;

                /*0x75b7410*/ DataMemberAttribute();
                /*0x75b7428*/ string get_Name();
                /*0x75b7430*/ void set_Name(string value);
                /*0x75b7454*/ bool get_IsNameSetExplicitly();
                /*0x75b745c*/ int get_Order();
                /*0x75b7464*/ bool get_IsRequired();
                /*0x75b746c*/ void set_IsRequired(bool value);
                /*0x75b7478*/ bool get_EmitDefaultValue();
            }

            class DateTimeFormat
            {
                /*0x10*/ string formatString;
                /*0x18*/ System.IFormatProvider formatProvider;
                /*0x20*/ System.Globalization.DateTimeStyles dateTimeStyles;

                /*0x75b7480*/ string get_FormatString();
                /*0x75b7488*/ System.IFormatProvider get_FormatProvider();
                /*0x75b7490*/ System.Globalization.DateTimeStyles get_DateTimeStyles();
            }

            struct DateTimeOffsetAdapter
            {
                /*0x10*/ System.DateTime utcDateTime;
                /*0x18*/ short offsetMinutes;

                static /*0x75b74b4*/ System.DateTimeOffset GetDateTimeOffset(System.Runtime.Serialization.DateTimeOffsetAdapter value);
                static /*0x75b7798*/ System.Runtime.Serialization.DateTimeOffsetAdapter GetDateTimeOffsetAdapter(System.DateTimeOffset value);
                /*0x75b7498*/ DateTimeOffsetAdapter(System.DateTime dateTime, short offsetMinutes);
                /*0x75b74a4*/ System.DateTime get_UtcDateTime();
                /*0x75b74ac*/ short get_OffsetMinutes();
                /*0x75b76c0*/ string ToString(System.IFormatProvider provider);
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

                static /*0x75b7864*/ DictionaryGlobals();
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

                /*0x75b29a0*/ EnumDataContract(System.Type type);
                /*0x75b8d8c*/ System.Collections.Generic.List<System.Runtime.Serialization.DataMember> get_Members();
                /*0x75b8da8*/ System.Collections.Generic.List<long> get_Values();
                /*0x75b8dc4*/ bool get_IsFlags();
                /*0x75b8de0*/ bool get_IsULong();
                /*0x75b8dfc*/ System.Xml.XmlDictionaryString[] get_ChildElementNames();
                /*0x75b8e18*/ bool get_CanContainReferences();
                /*0x75b8e20*/ void WriteEnumValue(System.Runtime.Serialization.XmlWriterDelegator writer, object value);
                /*0x75b9210*/ object ReadEnumValue(System.Runtime.Serialization.XmlReaderDelegator reader);
                /*0x75b949c*/ long ReadEnumValue(string value, int index, int count);
                /*0x75b967c*/ bool Equals(object other, System.Collections.Generic.Dictionary<System.Runtime.Serialization.DataContractPairKey, object> checkedContracts);
                /*0x75b9978*/ int GetHashCode();
                /*0x75b9980*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75b9984*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);

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

                    static /*0x75b99bc*/ EnumDataContractCriticalHelper();
                    static /*0x75b9c34*/ void Add(System.Type type, string localName);
                    static /*0x75b9d20*/ System.Xml.XmlQualifiedName GetBaseContractName(System.Type type);
                    /*0x75b8954*/ EnumDataContractCriticalHelper(System.Type type);
                    /*0x75ba684*/ System.Collections.Generic.List<System.Runtime.Serialization.DataMember> get_Members();
                    /*0x75ba68c*/ System.Collections.Generic.List<long> get_Values();
                    /*0x75ba694*/ bool get_IsFlags();
                    /*0x75ba69c*/ void set_IsFlags(bool value);
                    /*0x75ba6a8*/ bool get_IsULong();
                    /*0x75ba6b0*/ System.Xml.XmlDictionaryString[] get_ChildElementNames();
                    /*0x75b9db8*/ void ImportBaseType(System.Type baseType);
                    /*0x75b9f54*/ void ImportDataMembers();
                }
            }

            class EnumMemberAttribute : System.Attribute
            {
                /*0x10*/ string value;
                /*0x18*/ bool isValueSetExplicitly;

                /*0x75ba9b4*/ string get_Value();
                /*0x75ba9bc*/ bool get_IsValueSetExplicitly();
            }

            class ExtensionDataObject
            {
                /*0x10*/ System.Collections.Generic.IList<System.Runtime.Serialization.ExtensionDataMember> members;

                /*0x75ba9c4*/ ExtensionDataObject();
                /*0x75ba9cc*/ System.Collections.Generic.IList<System.Runtime.Serialization.ExtensionDataMember> get_Members();
                /*0x75ba9d4*/ void set_Members(System.Collections.Generic.IList<System.Runtime.Serialization.ExtensionDataMember> value);
            }

            class ExtensionDataMember
            {
                /*0x10*/ string name;
                /*0x18*/ string ns;
                /*0x20*/ System.Runtime.Serialization.IDataNode value;
                /*0x28*/ int memberIndex;

                /*0x75baa1c*/ ExtensionDataMember();
                /*0x75ba9dc*/ string get_Name();
                /*0x75ba9e4*/ void set_Name(string value);
                /*0x75ba9ec*/ string get_Namespace();
                /*0x75ba9f4*/ void set_Namespace(string value);
                /*0x75ba9fc*/ System.Runtime.Serialization.IDataNode get_Value();
                /*0x75baa04*/ void set_Value(System.Runtime.Serialization.IDataNode value);
                /*0x75baa0c*/ int get_MemberIndex();
                /*0x75baa14*/ void set_MemberIndex(int value);
            }

            interface IDataNode
            {
                /*0x380b9e8*/ System.Type get_DataType();
                /*0x380b9e8*/ object get_Value();
                /*0x380d83c*/ void set_Value(object value);
                /*0x380b9e8*/ string get_DataContractName();
                /*0x380d83c*/ void set_DataContractName(string value);
                /*0x380b9e8*/ string get_DataContractNamespace();
                /*0x380d83c*/ void set_DataContractNamespace(string value);
                /*0x380b9e8*/ string get_ClrTypeName();
                /*0x380d83c*/ void set_ClrTypeName(string value);
                /*0x380b9e8*/ string get_ClrAssemblyName();
                /*0x380d83c*/ void set_ClrAssemblyName(string value);
                /*0x380b9e8*/ string get_Id();
                /*0x380d83c*/ void set_Id(string value);
                /*0x380b128*/ bool get_PreservesReferences();
                /*0x380d83c*/ void GetData(System.Runtime.Serialization.ElementData element);
                /*0x380b128*/ bool get_IsFinalValue();
                /*0x380cdf0*/ void set_IsFinalValue(bool value);
                /*0x380cb08*/ void Clear();
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

                /*0x380cb08*/ DataNode();
                /*0x3907c14*/ DataNode(T value);
                /*0x380b9e8*/ System.Type get_DataType();
                /*0x380b9e8*/ object get_Value();
                /*0x380d83c*/ void set_Value(object value);
                /*0x380b128*/ bool System.Runtime.Serialization.IDataNode.get_IsFinalValue();
                /*0x380cdf0*/ void System.Runtime.Serialization.IDataNode.set_IsFinalValue(bool value);
                /*0x3907c14*/ T GetValue();
                /*0x380b9e8*/ string get_DataContractName();
                /*0x380d83c*/ void set_DataContractName(string value);
                /*0x380b9e8*/ string get_DataContractNamespace();
                /*0x380d83c*/ void set_DataContractNamespace(string value);
                /*0x380b9e8*/ string get_ClrTypeName();
                /*0x380d83c*/ void set_ClrTypeName(string value);
                /*0x380b9e8*/ string get_ClrAssemblyName();
                /*0x380d83c*/ void set_ClrAssemblyName(string value);
                /*0x380b128*/ bool get_PreservesReferences();
                /*0x380b9e8*/ string get_Id();
                /*0x380d83c*/ void set_Id(string value);
                /*0x380d83c*/ void GetData(System.Runtime.Serialization.ElementData element);
                /*0x380cb08*/ void Clear();
                /*0x380db40*/ void AddQualifiedNameAttribute(System.Runtime.Serialization.ElementData element, string elementPrefix, string elementName, string elementNs, string valueName, string valueNs);
            }

            class ClassDataNode : System.Runtime.Serialization.DataNode<object>
            {
                /*0x50*/ System.Collections.Generic.IList<System.Runtime.Serialization.ExtensionDataMember> members;

                /*0x75baa24*/ ClassDataNode();
                /*0x75babb4*/ System.Collections.Generic.IList<System.Runtime.Serialization.ExtensionDataMember> get_Members();
                /*0x75babbc*/ void set_Members(System.Collections.Generic.IList<System.Runtime.Serialization.ExtensionDataMember> value);
                /*0x75babc4*/ void Clear();
            }

            class CollectionDataNode : System.Runtime.Serialization.DataNode<System.Array>
            {
                /*0x50*/ System.Collections.Generic.IList<System.Runtime.Serialization.IDataNode> items;
                /*0x58*/ string itemName;
                /*0x60*/ string itemNamespace;
                /*0x68*/ int size;

                /*0x75bac1c*/ CollectionDataNode();
                /*0x75badb4*/ System.Collections.Generic.IList<System.Runtime.Serialization.IDataNode> get_Items();
                /*0x75badbc*/ void set_Items(System.Collections.Generic.IList<System.Runtime.Serialization.IDataNode> value);
                /*0x75badc4*/ string get_ItemName();
                /*0x75badcc*/ void set_ItemName(string value);
                /*0x75badd4*/ string get_ItemNamespace();
                /*0x75baddc*/ void set_ItemNamespace(string value);
                /*0x75bade4*/ int get_Size();
                /*0x75badec*/ void set_Size(int value);
                /*0x75badf4*/ void GetData(System.Runtime.Serialization.ElementData element);
                /*0x75bb010*/ void Clear();
            }

            class XmlDataNode : System.Runtime.Serialization.DataNode<object>
            {
                /*0x50*/ System.Collections.Generic.IList<System.Xml.XmlAttribute> xmlAttributes;
                /*0x58*/ System.Collections.Generic.IList<System.Xml.XmlNode> xmlChildNodes;
                /*0x60*/ System.Xml.XmlDocument ownerDocument;

                /*0x75bb074*/ XmlDataNode();
                /*0x75bb204*/ System.Collections.Generic.IList<System.Xml.XmlAttribute> get_XmlAttributes();
                /*0x75bb20c*/ void set_XmlAttributes(System.Collections.Generic.IList<System.Xml.XmlAttribute> value);
                /*0x75bb214*/ System.Collections.Generic.IList<System.Xml.XmlNode> get_XmlChildNodes();
                /*0x75bb21c*/ void set_XmlChildNodes(System.Collections.Generic.IList<System.Xml.XmlNode> value);
                /*0x75bb224*/ System.Xml.XmlDocument get_OwnerDocument();
                /*0x75bb22c*/ void set_OwnerDocument(System.Xml.XmlDocument value);
                /*0x75bb234*/ void Clear();
            }

            class ISerializableDataNode : System.Runtime.Serialization.DataNode<object>
            {
                /*0x50*/ string factoryTypeName;
                /*0x58*/ string factoryTypeNamespace;
                /*0x60*/ System.Collections.Generic.IList<System.Runtime.Serialization.ISerializableDataMember> members;

                /*0x75bb2ac*/ ISerializableDataNode();
                /*0x75bb43c*/ string get_FactoryTypeName();
                /*0x75bb444*/ void set_FactoryTypeName(string value);
                /*0x75bb44c*/ string get_FactoryTypeNamespace();
                /*0x75bb454*/ void set_FactoryTypeNamespace(string value);
                /*0x75bb45c*/ System.Collections.Generic.IList<System.Runtime.Serialization.ISerializableDataMember> get_Members();
                /*0x75bb464*/ void set_Members(System.Collections.Generic.IList<System.Runtime.Serialization.ISerializableDataMember> value);
                /*0x75bb46c*/ void GetData(System.Runtime.Serialization.ElementData element);
                /*0x75bb54c*/ void Clear();
            }

            class ISerializableDataMember
            {
                /*0x10*/ string name;
                /*0x18*/ System.Runtime.Serialization.IDataNode value;

                /*0x75bb5e4*/ ISerializableDataMember();
                /*0x75bb5c4*/ string get_Name();
                /*0x75bb5cc*/ void set_Name(string value);
                /*0x75bb5d4*/ System.Runtime.Serialization.IDataNode get_Value();
                /*0x75bb5dc*/ void set_Value(System.Runtime.Serialization.IDataNode value);
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

                static /*0x75bb5ec*/ ExtensionDataReader();
                static /*0x75be3d8*/ string GetPrefix(string ns);
                static /*0x75bb740*/ void AddPrefix(string prefix, string ns);
                /*0x75bb7f0*/ ExtensionDataReader(System.Runtime.Serialization.XmlObjectSerializerReadContext context);
                /*0x75bb8a4*/ void SetDeserializedValue(object obj);
                /*0x75bba00*/ System.Runtime.Serialization.IDataNode GetCurrentNode();
                /*0x75bba30*/ void SetDataNode(System.Runtime.Serialization.IDataNode dataNode, string name, string ns);
                /*0x75bbd44*/ void Reset();
                /*0x75bbdd8*/ bool get_IsXmlDataNode();
                /*0x75bbde8*/ System.Xml.XmlNodeType get_NodeType();
                /*0x75bbe20*/ string get_LocalName();
                /*0x75bbe58*/ string get_NamespaceURI();
                /*0x75bbe90*/ string get_Prefix();
                /*0x75bbec8*/ string get_Value();
                /*0x75bbf00*/ int get_Depth();
                /*0x75bbf38*/ int get_AttributeCount();
                /*0x75bbf74*/ bool get_EOF();
                /*0x75bbfb8*/ System.Xml.ReadState get_ReadState();
                /*0x75bbff4*/ bool get_IsEmptyElement();
                /*0x75bc030*/ bool get_IsDefault();
                /*0x75bc06c*/ char get_QuoteChar();
                /*0x75bc0a8*/ System.Xml.XmlSpace get_XmlSpace();
                /*0x75bc0e4*/ string get_XmlLang();
                /*0x75bc130*/ bool MoveToFirstAttribute();
                /*0x75bc190*/ bool MoveToNextAttribute();
                /*0x75bc1f4*/ void MoveToAttribute(int index);
                /*0x75bc32c*/ string GetAttribute(string name, string namespaceURI);
                /*0x75bc40c*/ bool MoveToAttribute(string name, string namespaceURI);
                /*0x75bc504*/ bool MoveToElement();
                /*0x75bbc98*/ void SetElement();
                /*0x75bc558*/ string LookupNamespace(string prefix);
                /*0x75bc628*/ void Skip();
                /*0x75bc798*/ bool IsElementNode(System.Runtime.Serialization.ExtensionDataReader.ExtensionDataNodeType nodeType);
                /*0x75bc7bc*/ void Close();
                /*0x75bc808*/ bool Read();
                /*0x75bd090*/ string get_Name();
                /*0x75bd0d8*/ string get_BaseURI();
                /*0x75bd124*/ System.Xml.XmlNameTable get_NameTable();
                /*0x75bd160*/ string GetAttribute(string name);
                /*0x75bd19c*/ string GetAttribute(int i);
                /*0x75bd1d8*/ bool MoveToAttribute(string name);
                /*0x75bd214*/ void ResolveEntity();
                /*0x75bd24c*/ bool ReadAttributeValue();
                /*0x75bcac0*/ void MoveNext(System.Runtime.Serialization.IDataNode dataNode);
                /*0x75bba78*/ void SetNextElement(System.Runtime.Serialization.IDataNode node, string name, string ns, string prefix);
                /*0x75be198*/ void AddDeserializedDataNode(System.Runtime.Serialization.IDataNode node);
                /*0x75bdee0*/ bool CheckIfNodeHandled(System.Runtime.Serialization.IDataNode node);
                /*0x75bd288*/ void MoveNextInClass(System.Runtime.Serialization.ClassDataNode dataNode);
                /*0x75bd4d8*/ void MoveNextInCollection(System.Runtime.Serialization.CollectionDataNode dataNode);
                /*0x75bd724*/ void MoveNextInISerializable(System.Runtime.Serialization.ISerializableDataNode dataNode);
                /*0x75bd948*/ void MoveNextInXml(System.Runtime.Serialization.XmlDataNode dataNode);
                /*0x75bdb5c*/ void MoveToDeserializedObject(System.Runtime.Serialization.IDataNode dataNode);
                /*0x75be674*/ bool MoveToText(System.Type type, System.Runtime.Serialization.IDataNode dataNode, bool isTypedNode);
                /*0x75bcf14*/ void PushElement();
                /*0x75bcfd8*/ void PopElement();
                /*0x75c02a4*/ void GrowElementsIfNeeded();
                /*0x75bde58*/ System.Runtime.Serialization.ElementData GetNextElement();

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

                /*0x75c0374*/ AttributeData();
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

                /*0x75c036c*/ ElementData();
                /*0x75baed0*/ void AddAttribute(string prefix, string ns, string name, string value);
                /*0x75c037c*/ void GrowAttributesIfNeeded();
            }

            class GenericParameterDataContract : System.Runtime.Serialization.DataContract
            {
                /*0x28*/ System.Runtime.Serialization.GenericParameterDataContract.GenericParameterDataContractCriticalHelper helper;

                /*0x75b2a88*/ GenericParameterDataContract(System.Type type);
                /*0x75c04e8*/ bool get_IsBuiltInDataContract();

                class GenericParameterDataContractCriticalHelper : System.Runtime.Serialization.DataContract.DataContractCriticalHelper
                {
                    /*0x54*/ int parameterPosition;

                    /*0x75c0444*/ GenericParameterDataContractCriticalHelper(System.Type type);
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

                static /*0x75c2288*/ Globals();
                static /*0x75b2f28*/ System.Type get_TypeOfObject();
                static /*0x75c04f0*/ System.Type get_TypeOfValueType();
                static /*0x75a7de4*/ System.Type get_TypeOfArray();
                static /*0x75b4f48*/ System.Type get_TypeOfString();
                static /*0x75b4d0c*/ System.Type get_TypeOfInt();
                static /*0x75ba6b8*/ System.Type get_TypeOfULong();
                static /*0x75c05e4*/ System.Type get_TypeOfVoid();
                static /*0x75bfe94*/ System.Type get_TypeOfByteArray();
                static /*0x75bff98*/ System.Type get_TypeOfTimeSpan();
                static /*0x75c009c*/ System.Type get_TypeOfGuid();
                static /*0x75b2c78*/ System.Type get_TypeOfDateTimeOffset();
                static /*0x75b2d7c*/ System.Type get_TypeOfDateTimeOffsetAdapter();
                static /*0x75c01a0*/ System.Type get_TypeOfUri();
                static /*0x75b1574*/ System.Type get_TypeOfTypeEnumerable();
                static /*0x75c06d8*/ System.Type get_TypeOfStreamingContext();
                static /*0x75c07dc*/ System.Type get_TypeOfISerializable();
                static /*0x75c08e0*/ System.Type get_TypeOfIDeserializationCallback();
                static /*0x75c09e4*/ System.Type get_TypeOfIObjectReference();
                static /*0x75b10a8*/ System.Type get_TypeOfKnownTypeAttribute();
                static /*0x75ac30c*/ System.Type get_TypeOfDataContractAttribute();
                static /*0x75ba8b0*/ System.Type get_TypeOfDataMemberAttribute();
                static /*0x75ba7ac*/ System.Type get_TypeOfEnumMemberAttribute();
                static /*0x75ae1d4*/ System.Type get_TypeOfCollectionDataContractAttribute();
                static /*0x75c0ae8*/ System.Type get_TypeOfOptionalFieldAttribute();
                static /*0x75a7ed8*/ System.Type get_TypeOfObjectArray();
                static /*0x75c0bec*/ System.Type get_TypeOfOnSerializingAttribute();
                static /*0x75c0cf0*/ System.Type get_TypeOfOnSerializedAttribute();
                static /*0x75c0df4*/ System.Type get_TypeOfOnDeserializingAttribute();
                static /*0x75c0ef8*/ System.Type get_TypeOfOnDeserializedAttribute();
                static /*0x75b9e50*/ System.Type get_TypeOfFlagsAttribute();
                static /*0x75ac410*/ System.Type get_TypeOfIXmlSerializable();
                static /*0x75c0ffc*/ System.Type get_TypeOfXmlSchemaProviderAttribute();
                static /*0x75c1100*/ System.Type get_TypeOfXmlRootAttribute();
                static /*0x75c1208*/ System.Type get_TypeOfXmlQualifiedName();
                static /*0x75c1310*/ System.Type get_TypeOfXmlSchemaType();
                static /*0x75c1418*/ System.Type get_TypeOfXmlNodeArray();
                static /*0x75b1678*/ object[] get_EmptyObjectArray();
                static /*0x75b14ac*/ System.Type[] get_EmptyTypeArray();
                static /*0x75c1520*/ System.Type get_TypeOfIExtensibleDataObject();
                static /*0x75c1628*/ System.Type get_TypeOfExtensionDataObject();
                static /*0x75bb334*/ System.Type get_TypeOfISerializableDataNode();
                static /*0x75baaac*/ System.Type get_TypeOfClassDataNode();
                static /*0x75bacac*/ System.Type get_TypeOfCollectionDataNode();
                static /*0x75bb0fc*/ System.Type get_TypeOfXmlDataNode();
                static /*0x75aca24*/ System.Type get_TypeOfNullable();
                static /*0x75b2b70*/ System.Type get_TypeOfReflectionPointer();
                static /*0x75a6aa4*/ System.Type get_TypeOfIDictionaryGeneric();
                static /*0x75a6bac*/ System.Type get_TypeOfIDictionary();
                static /*0x75a6cb4*/ System.Type get_TypeOfIListGeneric();
                static /*0x75a6ec4*/ System.Type get_TypeOfIList();
                static /*0x75a6dbc*/ System.Type get_TypeOfICollectionGeneric();
                static /*0x75a70d4*/ System.Type get_TypeOfICollection();
                static /*0x75a6fcc*/ System.Type get_TypeOfIEnumerableGeneric();
                static /*0x75a71dc*/ System.Type get_TypeOfIEnumerable();
                static /*0x75c1730*/ System.Type get_TypeOfIEnumeratorGeneric();
                static /*0x75c1838*/ System.Type get_TypeOfIEnumerator();
                static /*0x75c1940*/ System.Type get_TypeOfKeyValuePair();
                static /*0x75c1a48*/ System.Type get_TypeOfKeyValue();
                static /*0x75c1b50*/ System.Type get_TypeOfIDictionaryEnumerator();
                static /*0x75c1c58*/ System.Type get_TypeOfDictionaryEnumerator();
                static /*0x75c1d60*/ System.Type get_TypeOfGenericDictionaryEnumerator();
                static /*0x75c1e68*/ System.Type get_TypeOfDictionaryGeneric();
                static /*0x75c1f70*/ System.Type get_TypeOfHashtable();
                static /*0x75c2078*/ System.Type get_TypeOfXmlElement();
                static /*0x75c2180*/ System.Type get_TypeOfDBNull();
                static /*0x75aedb8*/ System.Uri get_DataContractXsdBaseNamespaceUri();
            }

            class HybridObjectCache
            {
                /*0x10*/ System.Collections.Generic.Dictionary<string, object> objectDictionary;
                /*0x18*/ System.Collections.Generic.Dictionary<string, object> referencedObjectDictionary;

                /*0x75c22e8*/ HybridObjectCache();
                /*0x75c22f0*/ void Add(string id, object obj);
                /*0x75c2464*/ void Remove(string id);
                /*0x75c24c4*/ object GetObject(string id);
                /*0x75c25e0*/ bool IsObjectReferenced(string id);
            }

            interface IDataContractSurrogate
            {
                /*0x380bb68*/ System.Type GetDataContractType(System.Type type);
                /*0x380bcbc*/ object GetObjectToSerialize(object obj, System.Type targetType);
                /*0x380bcbc*/ object GetDeserializedObject(object obj, System.Type targetType);
            }

            class DataContractSurrogateCaller
            {
                static /*0x75c2640*/ System.Type GetDataContractType(System.Runtime.Serialization.IDataContractSurrogate surrogate, System.Type type);
                static /*0x75c2738*/ object GetObjectToSerialize(System.Runtime.Serialization.IDataContractSurrogate surrogate, object obj, System.Type objType, System.Type membertype);
                static /*0x75c281c*/ object GetDeserializedObject(System.Runtime.Serialization.IDataContractSurrogate surrogate, object obj, System.Type objType, System.Type memberType);
            }

            interface IExtensibleDataObject
            {
                /*0x380b9e8*/ System.Runtime.Serialization.ExtensionDataObject get_ExtensionData();
                /*0x380d83c*/ void set_ExtensionData(System.Runtime.Serialization.ExtensionDataObject value);
            }

            class IgnoreDataMemberAttribute : System.Attribute
            {
                /*0x75c2900*/ IgnoreDataMemberAttribute();
            }

            class InvalidDataContractException : System.Exception
            {
                /*0x75c2908*/ InvalidDataContractException();
                /*0x75c2960*/ InvalidDataContractException(string message);
                /*0x75c29c8*/ InvalidDataContractException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            class JsonFormatGeneratorStatics
            {
                static /*0x0*/ System.Reflection.MethodInfo boxPointer;
                static /*0x8*/ System.Reflection.MethodInfo ienumeratorGetCurrentMethod;
                static /*0x10*/ System.Reflection.MethodInfo ienumeratorMoveNextMethod;
                static /*0x18*/ System.Type[] serInfoCtorArgs;
                static /*0x20*/ System.Reflection.MethodInfo unboxPointer;

                static /*0x75c2a48*/ System.Reflection.MethodInfo get_BoxPointer();
                static /*0x75c2b2c*/ System.Reflection.MethodInfo get_GetCurrentMethod();
                static /*0x75c2c18*/ System.Reflection.MethodInfo get_MoveNextMethod();
                static /*0x75c2cf8*/ System.Type[] get_SerInfoCtorArgs();
                static /*0x75c2e6c*/ System.Reflection.MethodInfo get_UnboxPointer();
            }

            class KnownTypeAttribute : System.Attribute
            {
                /*0x10*/ string methodName;
                /*0x18*/ System.Type type;

                /*0x75c2f4c*/ string get_MethodName();
                /*0x75c2f54*/ System.Type get_Type();
            }

            class KnownTypeDataContractResolver : System.Runtime.Serialization.DataContractResolver
            {
                /*0x10*/ System.Runtime.Serialization.XmlObjectSerializerContext context;

                /*0x75c2f5c*/ KnownTypeDataContractResolver(System.Runtime.Serialization.XmlObjectSerializerContext context);
                /*0x75c2f8c*/ bool TryResolveType(System.Type type, System.Type declaredType, System.Runtime.Serialization.DataContractResolver knownTypeResolver, ref System.Xml.XmlDictionaryString typeName, ref System.Xml.XmlDictionaryString typeNamespace);
                /*0x75c3164*/ System.Type ResolveName(string typeName, string typeNamespace, System.Type declaredType, System.Runtime.Serialization.DataContractResolver knownTypeResolver);
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

                static /*0x75c4c60*/ NetDataContractSerializer();
                static /*0x75c3220*/ bool get_UnsafeTypeForwardingEnabled();
                static /*0x75c3ad4*/ void WriteClrTypeInfo(System.Runtime.Serialization.XmlWriterDelegator writer, System.Runtime.Serialization.DataContract dataContract, System.Runtime.Serialization.SerializationBinder binder);
                static /*0x75c4284*/ void WriteClrTypeInfo(System.Runtime.Serialization.XmlWriterDelegator writer, System.Type dataContractType, System.Runtime.Serialization.SerializationBinder binder, string defaultClrTypeName, string defaultClrAssemblyName);
                static /*0x75c4354*/ void WriteClrTypeInfo(System.Runtime.Serialization.XmlWriterDelegator writer, System.Type dataContractType, System.Runtime.Serialization.SerializationBinder binder, System.Runtime.Serialization.SerializationInfo serInfo);
                static /*0x75c4164*/ void WriteClrTypeInfo(System.Runtime.Serialization.XmlWriterDelegator writer, string clrTypeName, string clrAssemblyName);
                static /*0x75c46c8*/ System.Runtime.Serialization.ISerializationSurrogate GetSurrogate(System.Type type, System.Runtime.Serialization.ISurrogateSelector surrogateSelector, System.Runtime.Serialization.StreamingContext context);
                static /*0x75c4798*/ System.Runtime.Serialization.DataContract GetDataContractFromSurrogateSelector(System.Runtime.Serialization.ISurrogateSelector surrogateSelector, System.Runtime.Serialization.StreamingContext context, System.RuntimeTypeHandle typeHandle, System.Type type, ref System.Collections.Hashtable surrogateDataContracts);
                static /*0x75c3df0*/ System.Runtime.Serialization.TypeInformation GetTypeInformation(System.Type type);
                static /*0x75c4004*/ bool IsAssemblyNameForwardingSafe(string originalAssemblyName, string newAssemblyName);
                static /*0x75c4bcc*/ bool IsPublicKeyTokenForwardingSafe(byte[] sourceToken, byte[] destinationToken);
                /*0x75c3308*/ System.Runtime.Serialization.StreamingContext get_Context();
                /*0x75c3314*/ System.Runtime.Serialization.SerializationBinder get_Binder();
                /*0x75c331c*/ System.Runtime.Serialization.ISurrogateSelector get_SurrogateSelector();
                /*0x75c3324*/ int get_MaxItemsInObjectGraph();
                /*0x75c332c*/ bool get_IgnoreExtensionDataObject();
                /*0x75c3334*/ void WriteStartObject(System.Xml.XmlDictionaryWriter writer, object graph);
                /*0x75c3510*/ void WriteObjectContent(System.Xml.XmlDictionaryWriter writer, object graph);
                /*0x75c4494*/ void WriteEndObject(System.Xml.XmlDictionaryWriter writer);
                /*0x75c4644*/ object ReadObject(System.Xml.XmlDictionaryReader reader, bool verifyObjectName);
            }

            struct ObjectReferenceStack
            {
                /*0x10*/ int count;
                /*0x18*/ object[] objectArray;
                /*0x20*/ bool[] isReferenceArray;
                /*0x28*/ System.Collections.Generic.Dictionary<object, object> objectDictionary;

                /*0x75c4cdc*/ void Push(object obj);
                /*0x75c4ed4*/ void EnsureSetAsIsReference(object obj);
                /*0x75c500c*/ void Pop(object obj);
                /*0x75c5080*/ bool Contains(object obj);
                /*0x75c515c*/ int get_Count();
            }

            class ObjectToIdCache
            {
                static /*0x0*/ int[] primes;
                /*0x10*/ int m_currentCount;
                /*0x18*/ int[] m_ids;
                /*0x20*/ object[] m_objs;
                /*0x28*/ bool[] m_isWrapped;

                static /*0x75c5ca0*/ ObjectToIdCache();
                static /*0x75c527c*/ int GetPrime(int min);
                static /*0x75c5be8*/ bool IsPrime(int candidate);
                /*0x75c5164*/ ObjectToIdCache();
                /*0x75c538c*/ int GetId(object obj, ref bool newId);
                /*0x75c57ec*/ int ReassignId(int oldObjId, object oldObj, object newObj);
                /*0x75c54d4*/ int FindElement(object obj, ref bool isEmpty, ref bool isWrapped);
                /*0x75c595c*/ void RemoveAt(int position);
                /*0x75c5bb0*/ int ComputeStartPosition(object o);
                /*0x75c55ac*/ void Rehash();
            }

            class PrimitiveDataContract : System.Runtime.Serialization.DataContract
            {
                /*0x28*/ System.Runtime.Serialization.PrimitiveDataContract.PrimitiveDataContractCriticalHelper helper;

                static /*0x75c5ed0*/ System.Runtime.Serialization.PrimitiveDataContract GetPrimitiveDataContract(System.Type type);
                static /*0x75c5f54*/ System.Runtime.Serialization.PrimitiveDataContract GetPrimitiveDataContract(string name, string ns);
                /*0x75c5d40*/ PrimitiveDataContract(System.Type type, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x380b9e8*/ string get_WriteMethodName();
                /*0x380b9e8*/ string get_ReadMethodName();
                /*0x75c5fe0*/ System.Xml.XmlDictionaryString get_TopLevelElementNamespace();
                /*0x75c6038*/ bool get_CanContainReferences();
                /*0x75c6040*/ bool get_IsPrimitive();
                /*0x75c6048*/ bool get_IsBuiltInDataContract();
                /*0x75c6050*/ System.Reflection.MethodInfo get_XmlFormatWriterMethod();
                /*0x75c640c*/ System.Reflection.MethodInfo get_XmlFormatContentWriterMethod();
                /*0x75c669c*/ System.Reflection.MethodInfo get_XmlFormatReaderMethod();
                /*0x75c6778*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75c6794*/ object HandleReadValue(object obj, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
                /*0x75c67d8*/ bool TryReadNullAtTopLevel(System.Runtime.Serialization.XmlReaderDelegator reader);
                /*0x75c6938*/ bool Equals(object other, System.Collections.Generic.Dictionary<System.Runtime.Serialization.DataContractPairKey, object> checkedContracts);

                class PrimitiveDataContractCriticalHelper : System.Runtime.Serialization.DataContract.DataContractCriticalHelper
                {
                    /*0x58*/ System.Reflection.MethodInfo xmlFormatWriterMethod;
                    /*0x60*/ System.Reflection.MethodInfo xmlFormatContentWriterMethod;
                    /*0x68*/ System.Reflection.MethodInfo xmlFormatReaderMethod;

                    /*0x75c5e44*/ PrimitiveDataContractCriticalHelper(System.Type type, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                    /*0x75c6a3c*/ System.Reflection.MethodInfo get_XmlFormatWriterMethod();
                    /*0x75c6a44*/ void set_XmlFormatWriterMethod(System.Reflection.MethodInfo value);
                    /*0x75c6a4c*/ System.Reflection.MethodInfo get_XmlFormatContentWriterMethod();
                    /*0x75c6a54*/ void set_XmlFormatContentWriterMethod(System.Reflection.MethodInfo value);
                    /*0x75c6a5c*/ System.Reflection.MethodInfo get_XmlFormatReaderMethod();
                    /*0x75c6a64*/ void set_XmlFormatReaderMethod(System.Reflection.MethodInfo value);
                }
            }

            class CharDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75c6a6c*/ CharDataContract();
                /*0x75c6ad0*/ CharDataContract(System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75c6b34*/ string get_WriteMethodName();
                /*0x75c6b74*/ string get_ReadMethodName();
                /*0x75c6bb4*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75c6c10*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class AsmxCharDataContract : System.Runtime.Serialization.CharDataContract
            {
                /*0x75c6c94*/ AsmxCharDataContract();
            }

            class BooleanDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75c6cf8*/ BooleanDataContract();
                /*0x75c6d94*/ string get_WriteMethodName();
                /*0x75c6dd4*/ string get_ReadMethodName();
                /*0x75c6e14*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75c6e6c*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class SignedByteDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75c6ee4*/ SignedByteDataContract();
                /*0x75c6f80*/ string get_WriteMethodName();
                /*0x75c6fc0*/ string get_ReadMethodName();
                /*0x75c7000*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75c705c*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class UnsignedByteDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75c70d8*/ UnsignedByteDataContract();
                /*0x75c7174*/ string get_WriteMethodName();
                /*0x75c71b4*/ string get_ReadMethodName();
                /*0x75c71f4*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75c7250*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class ShortDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75c72cc*/ ShortDataContract();
                /*0x75c7368*/ string get_WriteMethodName();
                /*0x75c73a8*/ string get_ReadMethodName();
                /*0x75c73e8*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75c7444*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class UnsignedShortDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75c74c0*/ UnsignedShortDataContract();
                /*0x75c755c*/ string get_WriteMethodName();
                /*0x75c759c*/ string get_ReadMethodName();
                /*0x75c75dc*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75c7638*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class IntDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75c76b4*/ IntDataContract();
                /*0x75c7750*/ string get_WriteMethodName();
                /*0x75c7790*/ string get_ReadMethodName();
                /*0x75c77d0*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75c7828*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class UnsignedIntDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75c78a4*/ UnsignedIntDataContract();
                /*0x75c7940*/ string get_WriteMethodName();
                /*0x75c7980*/ string get_ReadMethodName();
                /*0x75c79c0*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75c7a1c*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class LongDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75c7a98*/ LongDataContract();
                /*0x75c7afc*/ LongDataContract(System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75c7b60*/ string get_WriteMethodName();
                /*0x75c7ba0*/ string get_ReadMethodName();
                /*0x75c7be0*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75c7c38*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class IntegerDataContract : System.Runtime.Serialization.LongDataContract
            {
                /*0x75c7cb4*/ IntegerDataContract();
            }

            class PositiveIntegerDataContract : System.Runtime.Serialization.LongDataContract
            {
                /*0x75c7d18*/ PositiveIntegerDataContract();
            }

            class NegativeIntegerDataContract : System.Runtime.Serialization.LongDataContract
            {
                /*0x75c7d7c*/ NegativeIntegerDataContract();
            }

            class NonPositiveIntegerDataContract : System.Runtime.Serialization.LongDataContract
            {
                /*0x75c7de0*/ NonPositiveIntegerDataContract();
            }

            class NonNegativeIntegerDataContract : System.Runtime.Serialization.LongDataContract
            {
                /*0x75c7e44*/ NonNegativeIntegerDataContract();
            }

            class UnsignedLongDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75c7ea8*/ UnsignedLongDataContract();
                /*0x75c7f44*/ string get_WriteMethodName();
                /*0x75c7f84*/ string get_ReadMethodName();
                /*0x75c7fc4*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75c8020*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class FloatDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75c80a4*/ FloatDataContract();
                /*0x75c8140*/ string get_WriteMethodName();
                /*0x75c8180*/ string get_ReadMethodName();
                /*0x75c81c0*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75c8218*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class DoubleDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75c828c*/ DoubleDataContract();
                /*0x75c8328*/ string get_WriteMethodName();
                /*0x75c8368*/ string get_ReadMethodName();
                /*0x75c83a8*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75c8400*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class DecimalDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75c8474*/ DecimalDataContract();
                /*0x75c8520*/ string get_WriteMethodName();
                /*0x75c8560*/ string get_ReadMethodName();
                /*0x75c85a0*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75c8624*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class DateTimeDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75c86f4*/ DateTimeDataContract();
                /*0x75c87a0*/ string get_WriteMethodName();
                /*0x75c87e0*/ string get_ReadMethodName();
                /*0x75c8820*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75c88a4*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class StringDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75c8950*/ StringDataContract();
                /*0x75c89b4*/ StringDataContract(System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75c8a18*/ string get_WriteMethodName();
                /*0x75c8a58*/ string get_ReadMethodName();
                /*0x75c8a98*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75c8ae0*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class TimeDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75c8b54*/ TimeDataContract();
            }

            class DateDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75c8bb8*/ DateDataContract();
            }

            class HexBinaryDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75c8c1c*/ HexBinaryDataContract();
            }

            class GYearMonthDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75c8c80*/ GYearMonthDataContract();
            }

            class GYearDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75c8ce4*/ GYearDataContract();
            }

            class GMonthDayDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75c8d48*/ GMonthDayDataContract();
            }

            class GDayDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75c8dac*/ GDayDataContract();
            }

            class GMonthDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75c8e10*/ GMonthDataContract();
            }

            class NormalizedStringDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75c8e74*/ NormalizedStringDataContract();
            }

            class TokenDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75c8ed8*/ TokenDataContract();
            }

            class LanguageDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75c8f3c*/ LanguageDataContract();
            }

            class NameDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75c8fa0*/ NameDataContract();
            }

            class NCNameDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75c9004*/ NCNameDataContract();
            }

            class IDDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75c9068*/ IDDataContract();
            }

            class IDREFDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75c90cc*/ IDREFDataContract();
            }

            class IDREFSDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75c9130*/ IDREFSDataContract();
            }

            class ENTITYDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75c9194*/ ENTITYDataContract();
            }

            class ENTITIESDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75c91f8*/ ENTITIESDataContract();
            }

            class NMTOKENDataContract : System.Runtime.Serialization.StringDataContract
            {
                /*0x75c925c*/ NMTOKENDataContract();
            }

            class ByteArrayDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75c92c0*/ ByteArrayDataContract();
                /*0x75c936c*/ string get_WriteMethodName();
                /*0x75c93ac*/ string get_ReadMethodName();
                /*0x75c93ec*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75c9470*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class ObjectDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75c94ec*/ ObjectDataContract();
                /*0x75c9588*/ string get_WriteMethodName();
                /*0x75c95c8*/ string get_ReadMethodName();
                /*0x75c9608*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75c960c*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
                /*0x75c987c*/ bool get_CanContainReferences();
                /*0x75c9884*/ bool get_IsPrimitive();
            }

            class TimeSpanDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75c988c*/ TimeSpanDataContract();
                /*0x75c98f0*/ TimeSpanDataContract(System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75c9978*/ string get_WriteMethodName();
                /*0x75c99b8*/ string get_ReadMethodName();
                /*0x75c99f8*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75c9a78*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class XsDurationDataContract : System.Runtime.Serialization.TimeSpanDataContract
            {
                /*0x75c9b20*/ XsDurationDataContract();
            }

            class GuidDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75c9b84*/ GuidDataContract();
                /*0x75c9be8*/ GuidDataContract(System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75c9c70*/ string get_WriteMethodName();
                /*0x75c9cb0*/ string get_ReadMethodName();
                /*0x75c9cf0*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75c9d70*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class AsmxGuidDataContract : System.Runtime.Serialization.GuidDataContract
            {
                /*0x75c9e18*/ AsmxGuidDataContract();
            }

            class UriDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75c9e7c*/ UriDataContract();
                /*0x75c9f28*/ string get_WriteMethodName();
                /*0x75c9f68*/ string get_ReadMethodName();
                /*0x75c9fa8*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75ca038*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
            }

            class QNameDataContract : System.Runtime.Serialization.PrimitiveDataContract
            {
                /*0x75ca0ac*/ QNameDataContract();
                /*0x75ca158*/ string get_WriteMethodName();
                /*0x75ca198*/ string get_ReadMethodName();
                /*0x75ca1d8*/ bool get_IsPrimitive();
                /*0x75ca1e0*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75ca278*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
                /*0x75ca2ec*/ void WriteRootElement(System.Runtime.Serialization.XmlWriterDelegator writer, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
            }

            class SchemaExporter
            {
                static /*0x0*/ System.Xml.XmlQualifiedName actualTypeAnnotationName;

                static /*0x75ca3e8*/ System.Xml.XmlElement ExportActualType(System.Xml.XmlQualifiedName typeName, System.Xml.XmlDocument xmlDoc);
                static /*0x75ca610*/ void GetXmlTypeInfo(System.Type type, ref System.Xml.XmlQualifiedName stableName, ref System.Xml.Schema.XmlSchemaType xsdType, ref bool hasRoot);
                static /*0x75ca994*/ bool InvokeSchemaProviderMethod(System.Type clrType, System.Xml.Schema.XmlSchemaSet schemas, ref System.Xml.XmlQualifiedName stableName, ref System.Xml.Schema.XmlSchemaType xsdType, ref bool hasRoot);
                static /*0x75cba4c*/ System.Xml.Schema.XmlSchemaComplexType CreateAnyType();
                static /*0x75cb7e0*/ System.Xml.Schema.XmlSchemaComplexType CreateAnyElementType();
                static /*0x75ca784*/ bool IsSpecialXmlType(System.Type type, ref System.Xml.XmlQualifiedName typeName, ref System.Xml.Schema.XmlSchemaType xsdType, ref bool hasRoot);
                static /*0x75cb964*/ System.Xml.Schema.XmlSchemaAnnotation GetSchemaAnnotation(System.Xml.XmlNode[] nodes);
                static /*0x75ca524*/ System.Xml.XmlQualifiedName get_ActualTypeAnnotationName();
            }

            struct ScopedKnownTypes
            {
                /*0x10*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> dataContractDictionaries;
                /*0x18*/ int count;

                /*0x75cbc64*/ void Push(System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> dataContractDictionary);
                /*0x75cbd64*/ void Pop();
                /*0x75cbd74*/ System.Runtime.Serialization.DataContract GetDataContract(System.Xml.XmlQualifiedName qname);
            }

            enum SerializationMode
            {
                SharedContract = 0,
                SharedType = 1,
            }

            class SpecialTypeDataContract : System.Runtime.Serialization.DataContract
            {
                /*0x28*/ System.Runtime.Serialization.SpecialTypeDataContract.SpecialTypeDataContractCriticalHelper helper;

                /*0x75cbe1c*/ SpecialTypeDataContract(System.Type type, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75cbfac*/ bool get_IsBuiltInDataContract();

                class SpecialTypeDataContractCriticalHelper : System.Runtime.Serialization.DataContract.DataContractCriticalHelper
                {
                    /*0x75cbf20*/ SpecialTypeDataContractCriticalHelper(System.Type type, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                }
            }

            class SurrogateDataContract : System.Runtime.Serialization.DataContract
            {
                /*0x28*/ System.Runtime.Serialization.SurrogateDataContract.SurrogateDataContractCriticalHelper helper;

                static /*0x75cc698*/ object GetRealObject(System.Runtime.Serialization.IObjectReference obj, System.Runtime.Serialization.StreamingContext context);
                /*0x75c4a80*/ SurrogateDataContract(System.Type type, System.Runtime.Serialization.ISerializationSurrogate serializationSurrogate);
                /*0x75cc078*/ System.Runtime.Serialization.ISerializationSurrogate get_SerializationSurrogate();
                /*0x75cc094*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75cc5b8*/ object SerializationSurrogateSetObjectData(object obj, System.Runtime.Serialization.SerializationInfo serInfo, System.Runtime.Serialization.StreamingContext context);
                /*0x75cc74c*/ object GetUninitializedObject(System.Type objType);
                /*0x75cc210*/ void SerializationSurrogateGetObjectData(object obj, System.Runtime.Serialization.SerializationInfo serInfo, System.Runtime.Serialization.StreamingContext context);
                /*0x75cc7a4*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);

                class SurrogateDataContractCriticalHelper : System.Runtime.Serialization.DataContract.DataContractCriticalHelper
                {
                    /*0x58*/ System.Runtime.Serialization.ISerializationSurrogate serializationSurrogate;

                    /*0x75cbfb4*/ SurrogateDataContractCriticalHelper(System.Type type, System.Runtime.Serialization.ISerializationSurrogate serializationSurrogate);
                    /*0x75cce88*/ System.Runtime.Serialization.ISerializationSurrogate get_SerializationSurrogate();
                }
            }

            class TypeInformation
            {
                /*0x10*/ string fullTypeName;
                /*0x18*/ string assemblyString;
                /*0x20*/ bool hasTypeForwardedFrom;

                /*0x75c4b74*/ TypeInformation(string fullTypeName, string assemblyString, bool hasTypeForwardedFrom);
                /*0x75cce90*/ string get_FullTypeName();
                /*0x75cce98*/ string get_AssemblyString();
            }

            class CreateXmlSerializableDelegate : System.MulticastDelegate
            {
                /*0x75ccea0*/ CreateXmlSerializableDelegate(object object, nint method);
                /*0x75ccf3c*/ System.Xml.Serialization.IXmlSerializable Invoke();
            }

            class XmlDataContract : System.Runtime.Serialization.DataContract
            {
                /*0x28*/ System.Runtime.Serialization.XmlDataContract.XmlDataContractCriticalHelper helper;

                /*0x75ccf50*/ XmlDataContract(System.Type type);
                /*0x75cd608*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> get_KnownDataContracts();
                /*0x75cd628*/ bool get_IsAnonymous();
                /*0x75cd65c*/ bool get_HasRoot();
                /*0x75cd67c*/ System.Xml.XmlDictionaryString get_TopLevelElementName();
                /*0x75cd69c*/ System.Xml.XmlDictionaryString get_TopLevelElementNamespace();
                /*0x75cd6bc*/ System.Runtime.Serialization.CreateXmlSerializableDelegate get_CreateXmlSerializableDelegate();
                /*0x75cd850*/ bool get_CanContainReferences();
                /*0x75cd858*/ bool get_IsBuiltInDataContract();
                /*0x75cd964*/ bool Equals(object other, System.Collections.Generic.Dictionary<System.Runtime.Serialization.DataContractPairKey, object> checkedContracts);
                /*0x75cdac4*/ int GetHashCode();
                /*0x75cdacc*/ void WriteXmlValue(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                /*0x75cdbd8*/ object ReadXmlValue(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
                /*0x75cd7d8*/ System.Runtime.Serialization.CreateXmlSerializableDelegate GenerateCreateXmlSerializableDelegate();
                /*0x75cdd54*/ System.Xml.Serialization.IXmlSerializable <GenerateCreateXmlSerializableDelegate>b__39_0();

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

                    /*0x75cd03c*/ XmlDataContractCriticalHelper(System.Type type);
                    /*0x75cddbc*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> get_KnownDataContracts();
                    /*0x75cdeec*/ void set_XsdType(System.Xml.Schema.XmlSchemaType value);
                    /*0x75cd64c*/ bool get_IsAnonymous();
                    /*0x75cdef4*/ bool get_HasRoot();
                    /*0x75cdefc*/ void set_HasRoot(bool value);
                    /*0x75cdf08*/ System.Xml.XmlDictionaryString get_TopLevelElementName();
                    /*0x75cdf10*/ System.Xml.XmlDictionaryString get_TopLevelElementNamespace();
                    /*0x75cdf18*/ System.Runtime.Serialization.CreateXmlSerializableDelegate get_CreateXmlSerializableDelegate();
                    /*0x75cdf20*/ void set_CreateXmlSerializableDelegate(System.Runtime.Serialization.CreateXmlSerializableDelegate value);
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

                static /*0x75cdf28*/ System.Reflection.MethodInfo get_BoxPointer();
                static /*0x75ce00c*/ System.Reflection.MethodInfo get_MoveNextMethod();
                static /*0x75ce0ec*/ System.Reflection.MethodInfo get_GetCurrentMethod();
                static /*0x75ce1d8*/ System.Reflection.MethodInfo get_UnboxPointer();
                static /*0x75ce2b8*/ System.Reflection.ConstructorInfo get_HashtableCtor();
                static /*0x75ce3b8*/ System.Reflection.MethodInfo get_IncrementItemCountMethod();
                static /*0x75ce49c*/ System.Reflection.MethodInfo get_EnsureArraySizeMethod();
                static /*0x75ce580*/ System.Reflection.MethodInfo get_TrimArraySizeMethod();
                static /*0x75ce664*/ System.Reflection.MethodInfo get_InternalSerializeReferenceMethod();
                static /*0x75ce748*/ System.Reflection.MethodInfo get_InternalSerializeMethod();
                static /*0x75ce82c*/ System.Reflection.MethodInfo get_WriteNullMethod();
                static /*0x75cea50*/ System.Reflection.MethodInfo get_IncrementCollectionCountMethod();
                static /*0x75cec3c*/ System.Reflection.MethodInfo get_IncrementCollectionCountGenericMethod();
                static /*0x75ced20*/ System.Reflection.MethodInfo get_GetDefaultValueMethod();
                static /*0x75cee04*/ System.Reflection.MethodInfo get_GetNullableValueMethod();
                static /*0x75ceee8*/ System.Reflection.MethodInfo get_GetHasValueMethod();
                static /*0x75cefcc*/ System.Reflection.MethodInfo get_ExtensionDataSetExplicitMethodInfo();
            }

            class XmlFormatClassReaderDelegate : System.MulticastDelegate
            {
                /*0x75cf0ac*/ XmlFormatClassReaderDelegate(object object, nint method);
                /*0x75cf1b8*/ object Invoke(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.XmlObjectSerializerReadContext context, System.Xml.XmlDictionaryString[] memberNames, System.Xml.XmlDictionaryString[] memberNamespaces);
            }

            class XmlFormatCollectionReaderDelegate : System.MulticastDelegate
            {
                /*0x75cf1cc*/ XmlFormatCollectionReaderDelegate(object object, nint method);
                /*0x75cf2d8*/ object Invoke(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.XmlObjectSerializerReadContext context, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace, System.Runtime.Serialization.CollectionDataContract collectionContract);
            }

            class XmlFormatGetOnlyCollectionReaderDelegate : System.MulticastDelegate
            {
                /*0x75cf2ec*/ XmlFormatGetOnlyCollectionReaderDelegate(object object, nint method);
                /*0x75cf3f8*/ void Invoke(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.XmlObjectSerializerReadContext context, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace, System.Runtime.Serialization.CollectionDataContract collectionContract);
            }

            class XmlFormatReaderGenerator
            {
                /*0x10*/ System.Runtime.Serialization.XmlFormatReaderGenerator.CriticalHelper helper;

                static /*0x75cfbe8*/ object UnsafeGetUninitializedObject(int id);
                /*0x75cf40c*/ XmlFormatReaderGenerator();
                /*0x75cf480*/ System.Runtime.Serialization.XmlFormatClassReaderDelegate GenerateClassReader(System.Runtime.Serialization.ClassDataContract classContract);
                /*0x75cf6f8*/ System.Runtime.Serialization.XmlFormatCollectionReaderDelegate GenerateCollectionReader(System.Runtime.Serialization.CollectionDataContract collectionContract);
                /*0x75cf970*/ System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate GenerateGetOnlyCollectionReader(System.Runtime.Serialization.CollectionDataContract collectionContract);

                class CriticalHelper
                {
                    /*0x75cf478*/ CriticalHelper();
                    /*0x75cf640*/ System.Runtime.Serialization.XmlFormatClassReaderDelegate GenerateClassReader(System.Runtime.Serialization.ClassDataContract classContract);
                    /*0x75cf8b8*/ System.Runtime.Serialization.XmlFormatCollectionReaderDelegate GenerateCollectionReader(System.Runtime.Serialization.CollectionDataContract collectionContract);
                    /*0x75cfb30*/ System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate GenerateGetOnlyCollectionReader(System.Runtime.Serialization.CollectionDataContract collectionContract);

                    class <>c__DisplayClass0_0
                    {
                        /*0x10*/ System.Runtime.Serialization.ClassDataContract classContract;

                        /*0x75cfc64*/ <>c__DisplayClass0_0();
                        /*0x75cfc7c*/ object <GenerateClassReader>b__0(System.Runtime.Serialization.XmlReaderDelegator xr, System.Runtime.Serialization.XmlObjectSerializerReadContext ctx, System.Xml.XmlDictionaryString[] memberNames, System.Xml.XmlDictionaryString[] memberNamespaces);
                    }

                    class <>c__DisplayClass1_0
                    {
                        /*0x10*/ System.Runtime.Serialization.CollectionDataContract collectionContract;

                        /*0x75cfc6c*/ <>c__DisplayClass1_0();
                        /*0x75cfd18*/ object <GenerateCollectionReader>b__0(System.Runtime.Serialization.XmlReaderDelegator xr, System.Runtime.Serialization.XmlObjectSerializerReadContext ctx, System.Xml.XmlDictionaryString inm, System.Xml.XmlDictionaryString ins, System.Runtime.Serialization.CollectionDataContract cc);
                    }

                    class <>c__DisplayClass2_0
                    {
                        /*0x10*/ System.Runtime.Serialization.CollectionDataContract collectionContract;

                        /*0x75cfc74*/ <>c__DisplayClass2_0();
                        /*0x75cfdc8*/ void <GenerateGetOnlyCollectionReader>b__0(System.Runtime.Serialization.XmlReaderDelegator xr, System.Runtime.Serialization.XmlObjectSerializerReadContext ctx, System.Xml.XmlDictionaryString inm, System.Xml.XmlDictionaryString ins, System.Runtime.Serialization.CollectionDataContract cc);
                    }
                }
            }

            class XmlFormatClassWriterDelegate : System.MulticastDelegate
            {
                /*0x75cfe78*/ XmlFormatClassWriterDelegate(object object, nint method);
                /*0x75cff84*/ void Invoke(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context, System.Runtime.Serialization.ClassDataContract dataContract);
            }

            class XmlFormatCollectionWriterDelegate : System.MulticastDelegate
            {
                /*0x75cff98*/ XmlFormatCollectionWriterDelegate(object object, nint method);
                /*0x75d00a4*/ void Invoke(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context, System.Runtime.Serialization.CollectionDataContract dataContract);
            }

            class XmlFormatWriterGenerator
            {
                /*0x10*/ System.Runtime.Serialization.XmlFormatWriterGenerator.CriticalHelper helper;

                /*0x75d00b8*/ XmlFormatWriterGenerator();
                /*0x75d012c*/ System.Runtime.Serialization.XmlFormatClassWriterDelegate GenerateClassWriter(System.Runtime.Serialization.ClassDataContract classContract);
                /*0x75d03a4*/ System.Runtime.Serialization.XmlFormatCollectionWriterDelegate GenerateCollectionWriter(System.Runtime.Serialization.CollectionDataContract collectionContract);

                class CriticalHelper
                {
                    /*0x75d0124*/ CriticalHelper();
                    /*0x75d02ec*/ System.Runtime.Serialization.XmlFormatClassWriterDelegate GenerateClassWriter(System.Runtime.Serialization.ClassDataContract classContract);
                    /*0x75d0564*/ System.Runtime.Serialization.XmlFormatCollectionWriterDelegate GenerateCollectionWriter(System.Runtime.Serialization.CollectionDataContract collectionContract);

                    class <>c__DisplayClass0_0
                    {
                        /*0x10*/ System.Runtime.Serialization.ClassDataContract classContract;

                        /*0x75d061c*/ <>c__DisplayClass0_0();
                        /*0x75d062c*/ void <GenerateClassWriter>b__0(System.Runtime.Serialization.XmlWriterDelegator xw, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext ctx, System.Runtime.Serialization.ClassDataContract ctr);
                    }

                    class <>c__DisplayClass1_0
                    {
                        /*0x10*/ System.Runtime.Serialization.CollectionDataContract collectionContract;

                        /*0x75d0624*/ <>c__DisplayClass1_0();
                        /*0x75d06c8*/ void <GenerateCollectionWriter>b__0(System.Runtime.Serialization.XmlWriterDelegator xw, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext ctx, System.Runtime.Serialization.CollectionDataContract ctr);
                    }
                }
            }

            class XmlObjectSerializer
            {
                static /*0x0*/ System.Runtime.Serialization.IFormatterConverter formatterConverter;

                static /*0x75d1318*/ void WriteNull(System.Runtime.Serialization.XmlWriterDelegator writer);
                static /*0x75d13a4*/ bool IsContractDeclared(System.Runtime.Serialization.DataContract contract, System.Runtime.Serialization.DataContract declaredContract);
                static /*0x75d0810*/ void CheckNull(object obj, string name);
                static /*0x75d1c5c*/ string TryAddLineInfo(System.Runtime.Serialization.XmlReaderDelegator reader, string errorMessage);
                static /*0x75d1e2c*/ System.Exception CreateSerializationExceptionWithReaderDetails(string errorMessage, System.Runtime.Serialization.XmlReaderDelegator reader);
                static /*0x75c245c*/ System.Runtime.Serialization.SerializationException CreateSerializationException(string errorMessage);
                static /*0x75c9810*/ System.Runtime.Serialization.SerializationException CreateSerializationException(string errorMessage, System.Exception innerException);
                static /*0x75d0d98*/ string GetTypeInfo(System.Type type);
                static /*0x75d0e00*/ string GetTypeInfoError(string errorMessage, System.Type type, System.Exception innerException);
                static /*0x75cc174*/ System.Runtime.Serialization.IFormatterConverter get_FormatterConverter();
                /*0x75d2020*/ XmlObjectSerializer();
                /*0x380d93c*/ void WriteStartObject(System.Xml.XmlDictionaryWriter writer, object graph);
                /*0x380d93c*/ void WriteObjectContent(System.Xml.XmlDictionaryWriter writer, object graph);
                /*0x380d83c*/ void WriteEndObject(System.Xml.XmlDictionaryWriter writer);
                /*0x75d0764*/ void WriteObject(System.IO.Stream stream, object graph);
                /*0x75d086c*/ void WriteStartObject(System.Xml.XmlWriter writer, object graph);
                /*0x75d08e8*/ void WriteObjectContent(System.Xml.XmlWriter writer, object graph);
                /*0x75d0964*/ void WriteEndObject(System.Xml.XmlWriter writer);
                /*0x75d09d8*/ void WriteObject(System.Xml.XmlDictionaryWriter writer, object graph);
                /*0x75d0a50*/ void WriteObjectHandleExceptions(System.Runtime.Serialization.XmlWriterDelegator writer, object graph);
                /*0x75d0a58*/ void WriteObjectHandleExceptions(System.Runtime.Serialization.XmlWriterDelegator writer, object graph, System.Runtime.Serialization.DataContractResolver dataContractResolver);
                /*0x75d0fd0*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> get_KnownDataContracts();
                /*0x75d0fd8*/ void InternalWriteObject(System.Runtime.Serialization.XmlWriterDelegator writer, object graph);
                /*0x75d1038*/ void InternalWriteObject(System.Runtime.Serialization.XmlWriterDelegator writer, object graph, System.Runtime.Serialization.DataContractResolver dataContractResolver);
                /*0x75d1048*/ void InternalWriteStartObject(System.Runtime.Serialization.XmlWriterDelegator writer, object graph);
                /*0x75d1090*/ void InternalWriteObjectContent(System.Runtime.Serialization.XmlWriterDelegator writer, object graph);
                /*0x75d10d8*/ void InternalWriteEndObject(System.Runtime.Serialization.XmlWriterDelegator writer);
                /*0x75c33a8*/ void WriteStartObjectHandleExceptions(System.Runtime.Serialization.XmlWriterDelegator writer, object graph);
                /*0x75c3584*/ void WriteObjectContentHandleExceptions(System.Runtime.Serialization.XmlWriterDelegator writer, object graph);
                /*0x75c4500*/ void WriteEndObjectHandleExceptions(System.Runtime.Serialization.XmlWriterDelegator writer);
                /*0x75d1120*/ void WriteRootElement(System.Runtime.Serialization.XmlWriterDelegator writer, System.Runtime.Serialization.DataContract contract, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns, bool needsContractNsAtRoot);
                /*0x75d11fc*/ bool CheckIfNeedsContractNsAtRoot(System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns, System.Runtime.Serialization.DataContract contract);
                /*0x75d147c*/ object ReadObject(System.IO.Stream stream);
                /*0x75d1554*/ object ReadObject(System.Xml.XmlDictionaryReader reader);
                /*0x75d15c8*/ object ReadObject(System.Xml.XmlReader reader, bool verifyObjectName);
                /*0x380bba0*/ object ReadObject(System.Xml.XmlDictionaryReader reader, bool verifyObjectName);
                /*0x75d1648*/ object InternalReadObject(System.Runtime.Serialization.XmlReaderDelegator reader, bool verifyObjectName);
                /*0x75d1670*/ object InternalReadObject(System.Runtime.Serialization.XmlReaderDelegator reader, bool verifyObjectName, System.Runtime.Serialization.DataContractResolver dataContractResolver);
                /*0x75d1684*/ bool InternalIsStartObject(System.Runtime.Serialization.XmlReaderDelegator reader);
                /*0x75c46bc*/ object ReadObjectHandleExceptions(System.Runtime.Serialization.XmlReaderDelegator reader, bool verifyObjectName);
                /*0x75d16cc*/ object ReadObjectHandleExceptions(System.Runtime.Serialization.XmlReaderDelegator reader, bool verifyObjectName, System.Runtime.Serialization.DataContractResolver dataContractResolver);
                /*0x75d1a0c*/ bool IsRootXmlAny(System.Xml.XmlDictionaryString rootName, System.Runtime.Serialization.DataContract contract);
                /*0x75d1a44*/ bool IsStartElement(System.Runtime.Serialization.XmlReaderDelegator reader);
                /*0x75d1a80*/ bool IsRootElement(System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.DataContract contract, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75d2000*/ System.Type GetSerializeType(object graph);
                /*0x75d2018*/ System.Type GetDeserializeType();
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

                static /*0x75d2194*/ System.Reflection.MethodInfo get_IncrementItemCountMethod();
                static /*0x75d2738*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> GetDataContractsForKnownTypes(System.Collections.Generic.IList<System.Type> knownTypeList);
                /*0x75d2028*/ XmlObjectSerializerContext(System.Runtime.Serialization.XmlObjectSerializer serializer, int maxItemsInObjectGraph, System.Runtime.Serialization.StreamingContext streamingContext, bool ignoreExtensionDataObject, System.Runtime.Serialization.DataContractResolver dataContractResolver);
                /*0x75d20ac*/ XmlObjectSerializerContext(System.Runtime.Serialization.XmlObjectSerializer serializer, int maxItemsInObjectGraph, System.Runtime.Serialization.StreamingContext streamingContext, bool ignoreExtensionDataObject);
                /*0x75d20b8*/ XmlObjectSerializerContext(System.Runtime.Serialization.DataContractSerializer serializer, System.Runtime.Serialization.DataContract rootTypeDataContract, System.Runtime.Serialization.DataContractResolver dataContractResolver);
                /*0x75d2148*/ XmlObjectSerializerContext(System.Runtime.Serialization.NetDataContractSerializer serializer);
                /*0x75d216c*/ System.Runtime.Serialization.SerializationMode get_Mode();
                /*0x75d2174*/ bool get_IsGetOnlyCollection();
                /*0x75d217c*/ void set_IsGetOnlyCollection(bool value);
                /*0x75d2180*/ void DemandSerializationFormatterPermission();
                /*0x75d2184*/ void DemandMemberAccessPermission();
                /*0x75d2188*/ System.Runtime.Serialization.StreamingContext GetStreamingContext();
                /*0x75d227c*/ void IncrementItemCount(int count);
                /*0x75d234c*/ int get_RemainingItemCount();
                /*0x75d2358*/ bool get_IgnoreExtensionDataObject();
                /*0x75d2360*/ System.Runtime.Serialization.DataContractResolver get_DataContractResolver();
                /*0x75d2368*/ System.Runtime.Serialization.KnownTypeDataContractResolver get_KnownTypeResolver();
                /*0x75d23ec*/ System.Runtime.Serialization.DataContract GetDataContract(System.Type type);
                /*0x75d2438*/ System.Runtime.Serialization.DataContract GetDataContract(System.RuntimeTypeHandle typeHandle, System.Type type);
                /*0x75d24d8*/ System.Runtime.Serialization.DataContract GetDataContractSkipValidation(int typeId, System.RuntimeTypeHandle typeHandle, System.Type type);
                /*0x75d2538*/ System.Runtime.Serialization.DataContract GetDataContract(int id, System.RuntimeTypeHandle typeHandle);
                /*0x75d25b4*/ void CheckIfTypeSerializable(System.Type memberType, bool isMemberTypeSerializable);
                /*0x75d2660*/ System.Type GetSurrogatedType(System.Type type);
                /*0x75d2668*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> get_SerializerKnownDataContracts();
                /*0x75d26c0*/ System.Runtime.Serialization.DataContract GetDataContractFromSerializerKnownTypes(System.Xml.XmlQualifiedName qname);
                /*0x75c30fc*/ bool IsKnownType(System.Runtime.Serialization.DataContract dataContract, System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> knownDataContracts, System.Type declaredType);
                /*0x75d29f8*/ bool IsKnownType(System.Runtime.Serialization.DataContract dataContract, System.Type declaredType);
                /*0x75d2bfc*/ System.Runtime.Serialization.DataContract ResolveDataContractFromKnownTypes(System.Xml.XmlQualifiedName typeName);
                /*0x75d2c50*/ System.Runtime.Serialization.DataContract ResolveDataContractFromDataContractResolver(System.Xml.XmlQualifiedName typeName, System.Type declaredType);
                /*0x75c3200*/ System.Type ResolveNameFromKnownTypes(System.Xml.XmlQualifiedName typeName);
                /*0x75d2abc*/ System.Runtime.Serialization.DataContract ResolveDataContractFromKnownTypes(string typeName, string typeNs, System.Runtime.Serialization.DataContract memberTypeContract, System.Type declaredType);
                /*0x75d2d98*/ System.Runtime.Serialization.DataContract ResolveDataContractFromRootDataContract(System.Xml.XmlQualifiedName typeQName);
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

                static /*0x75d2ff4*/ void ThrowNullValueReturnedForGetOnlyCollectionException(System.Type type);
                static /*0x75d308c*/ void ThrowArrayExceededSizeException(int arraySize, System.Type type);
                static /*0x75d316c*/ System.Runtime.Serialization.XmlObjectSerializerReadContext CreateContext(System.Runtime.Serialization.DataContractSerializer serializer, System.Runtime.Serialization.DataContract rootTypeDataContract, System.Runtime.Serialization.DataContractResolver dataContractResolver);
                static /*0x75d3f78*/ bool MoveToNextElement(System.Runtime.Serialization.XmlReaderDelegator xmlReader);
                static /*0x75d4230*/ void ThrowRequiredMemberMissingException(System.Runtime.Serialization.XmlReaderDelegator xmlReader, int memberIndex, int requiredIndex, System.Xml.XmlDictionaryString[] memberNames);
                static /*0x75d4f1c*/ void Read(System.Runtime.Serialization.XmlReaderDelegator xmlReader);
                static /*0x75d4f78*/ void ParseQualifiedName(string qname, System.Runtime.Serialization.XmlReaderDelegator xmlReader, ref string name, ref string ns, ref string prefix);
                static /*0x38301ec*/ T[] EnsureArraySize<T>(T[] array, int index);
                static /*0x38301ec*/ T[] TrimArraySize<T>(T[] array, int size);
                static /*0x75cdc50*/ object ReadRootIXmlSerializable(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.XmlDataContract xmlDataContract, bool isMemberType);
                static /*0x75d5218*/ object ReadIXmlSerializable(System.Runtime.Serialization.XmlSerializableReader xmlSerializableReader, System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.XmlDataContract xmlDataContract, bool isMemberType);
                static /*0x75d79f8*/ System.Xml.XmlNode CreateWrapperXmlElement(System.Xml.XmlDocument document, System.Collections.Generic.IList<System.Xml.XmlAttribute> xmlAttributes, System.Collections.Generic.IList<System.Xml.XmlNode> xmlChildNodes, string prefix, string localName, string ns);
                static /*0x75d4494*/ System.Exception CreateUnexpectedStateException(System.Xml.XmlNodeType expectedState, System.Runtime.Serialization.XmlReaderDelegator xmlReader);
                /*0x75d32f8*/ XmlObjectSerializerReadContext(System.Runtime.Serialization.XmlObjectSerializer serializer, int maxItemsInObjectGraph, System.Runtime.Serialization.StreamingContext streamingContext, bool ignoreExtensionDataObject);
                /*0x75d3228*/ XmlObjectSerializerReadContext(System.Runtime.Serialization.DataContractSerializer serializer, System.Runtime.Serialization.DataContract rootTypeDataContract, System.Runtime.Serialization.DataContractResolver dataContractResolver);
                /*0x75d2ed4*/ System.Runtime.Serialization.HybridObjectCache get_DeserializedObjects();
                /*0x75d2f44*/ System.Xml.XmlDocument get_Document();
                /*0x75d2fb4*/ bool get_IsGetOnlyCollection();
                /*0x75d2fbc*/ void set_IsGetOnlyCollection(bool value);
                /*0x75d2fc8*/ object GetCollectionMember();
                /*0x75d2fd0*/ void StoreCollectionMemberInfo(object collectionMember);
                /*0x75d3304*/ object InternalDeserialize(System.Runtime.Serialization.XmlReaderDelegator xmlReader, int id, System.RuntimeTypeHandle declaredTypeHandle, string name, string ns);
                /*0x75d39f8*/ object InternalDeserialize(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Type declaredType, string name, string ns);
                /*0x75d3a5c*/ object InternalDeserialize(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Type declaredType, System.Runtime.Serialization.DataContract dataContract, string name, string ns);
                /*0x75d3ac4*/ bool TryHandleNullOrRef(System.Runtime.Serialization.XmlReaderDelegator reader, System.Type declaredType, string name, string ns, ref object retObj);
                /*0x75d339c*/ object InternalDeserialize(System.Runtime.Serialization.XmlReaderDelegator reader, string name, string ns, System.Type declaredType, ref System.Runtime.Serialization.DataContract dataContract);
                /*0x75d3f40*/ bool ReplaceScopedKnownTypesTop(System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> knownDataContracts, bool knownTypesAddedInCurrentScope);
                /*0x75d3f9c*/ int GetMemberIndex(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Xml.XmlDictionaryString[] memberNames, System.Xml.XmlDictionaryString[] memberNamespaces, int memberIndex, System.Runtime.Serialization.ExtensionDataObject extensionData);
                /*0x75d4134*/ int GetMemberIndexWithRequiredMembers(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Xml.XmlDictionaryString[] memberNames, System.Xml.XmlDictionaryString[] memberNamespaces, int memberIndex, int requiredIndex, System.Runtime.Serialization.ExtensionDataObject extensionData);
                /*0x75d407c*/ void HandleMemberNotFound(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.ExtensionDataObject extensionData, int memberIndex);
                /*0x75d472c*/ void HandleUnknownElement(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.ExtensionDataObject extensionData, int memberIndex);
                /*0x75d4594*/ void SkipUnknownElement(System.Runtime.Serialization.XmlReaderDelegator xmlReader);
                /*0x75d4964*/ string ReadIfNullOrRef(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Type memberType, bool isMemberTypeSerializable);
                /*0x75d4a90*/ void ReadAttributes(System.Runtime.Serialization.XmlReaderDelegator xmlReader);
                /*0x75d4b14*/ void ResetAttributes();
                /*0x75cc9e8*/ string GetObjectId();
                /*0x75d4b28*/ int GetArraySize();
                /*0x75c67b8*/ void AddNewObject(object obj);
                /*0x75d4b30*/ void AddNewObjectWithId(string id, object obj);
                /*0x75ccc88*/ void ReplaceDeserializedObject(string id, object oldObj, object newObj);
                /*0x75d3cb0*/ object GetExistingObject(string id, System.Type type, string name, string ns);
                /*0x75d4d80*/ object GetExistingObjectOrExtensionData(string id);
                /*0x75d4e28*/ object GetRealObject(System.Runtime.Serialization.IObjectReference obj, string id);
                /*0x75d4bf4*/ object DeserializeFromExtensionData(System.Runtime.Serialization.IDataNode dataNode, System.Type type, string name, string ns);
                /*0x75d5070*/ void CheckEndOfArray(System.Runtime.Serialization.XmlReaderDelegator xmlReader, int arraySize, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace);
                /*0x75cdcc4*/ object ReadIXmlSerializable(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.XmlDataContract xmlDataContract, bool isMemberType);
                /*0x75cca04*/ System.Runtime.Serialization.SerializationInfo ReadSerializationInfo(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Type type);
                /*0x75d5540*/ System.Runtime.Serialization.DataContract ResolveDataContractFromTypeName();
                /*0x75d4868*/ System.Runtime.Serialization.ExtensionDataMember ReadExtensionDataMember(System.Runtime.Serialization.XmlReaderDelegator xmlReader, int memberIndex);
                /*0x75d5578*/ System.Runtime.Serialization.IDataNode ReadExtensionDataValue(System.Runtime.Serialization.XmlReaderDelegator xmlReader);
                /*0x75d6d98*/ void StartReadExtensionDataValue(System.Runtime.Serialization.XmlReaderDelegator xmlReader);
                /*0x75d6424*/ System.Runtime.Serialization.IDataNode ReadExtensionDataValue(System.Runtime.Serialization.XmlReaderDelegator xmlReader, string dataContractName, string dataContractNamespace);
                /*0x75d765c*/ System.Runtime.Serialization.IDataNode ReadPrimitiveExtensionDataValue(System.Runtime.Serialization.XmlReaderDelegator xmlReader, string dataContractName, string dataContractNamespace);
                /*0x75d6b30*/ void InitializeExtensionDataNode(System.Runtime.Serialization.IDataNode dataNode, string dataContractName, string dataContractNamespace);
                /*0x75d6ad4*/ System.Runtime.Serialization.IDataNode ReadUnknownPrimitiveData(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Type type, string dataContractName, string dataContractNamespace);
                /*0x75d6220*/ System.Runtime.Serialization.ClassDataNode ReadUnknownClassData(System.Runtime.Serialization.XmlReaderDelegator xmlReader, string dataContractName, string dataContractNamespace);
                /*0x75d5aa0*/ System.Runtime.Serialization.CollectionDataNode ReadUnknownCollectionData(System.Runtime.Serialization.XmlReaderDelegator xmlReader, string dataContractName, string dataContractNamespace);
                /*0x75d5f90*/ System.Runtime.Serialization.ISerializableDataNode ReadUnknownISerializableData(System.Runtime.Serialization.XmlReaderDelegator xmlReader, string dataContractName, string dataContractNamespace);
                /*0x75d66a8*/ System.Runtime.Serialization.IDataNode ReadUnknownXmlData(System.Runtime.Serialization.XmlReaderDelegator xmlReader, string dataContractName, string dataContractNamespace);
                /*0x75d6d9c*/ System.Runtime.Serialization.IDataNode ReadAndResolveUnknownXmlData(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Collections.Generic.IDictionary<string, string> namespaces, string dataContractName, string dataContractNamespace);
                /*0x75d790c*/ bool IsContentNode(System.Xml.XmlNodeType nodeType);
                /*0x75d7930*/ System.Runtime.Serialization.XmlReaderDelegator CreateReaderOverChildNodes(System.Collections.Generic.IList<System.Xml.XmlAttribute> xmlAttributes, System.Collections.Generic.IList<System.Xml.XmlNode> xmlChildNodes);
                /*0x75d7830*/ System.Xml.XmlAttribute AddNamespaceDeclaration(string prefix, string ns);
                /*0x75d7ce8*/ object ReadDataContractValue(System.Runtime.Serialization.DataContract dataContract, System.Runtime.Serialization.XmlReaderDelegator reader);
                /*0x75d7d14*/ System.Runtime.Serialization.XmlReaderDelegator CreateReaderDelegatorForReader(System.Xml.XmlReader xmlReader);
                /*0x75d7d70*/ bool IsReadingCollectionExtensionData(System.Runtime.Serialization.XmlReaderDelegator xmlReader);
                /*0x75d7d94*/ bool IsReadingClassExtensionData(System.Runtime.Serialization.XmlReaderDelegator xmlReader);
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

                static /*0x75d9810*/ XmlObjectSerializerReadContextComplex();
                static /*0x75d97a0*/ System.Reflection.Assembly ResolveSimpleAssemblyName(System.Reflection.AssemblyName assemblyName);
                static /*0x75d91a8*/ System.Reflection.Assembly ResolveSimpleAssemblyName(string assemblyName);
                static /*0x75d92f8*/ void CheckTypeForwardedTo(System.Reflection.Assembly sourceAssembly, System.Reflection.Assembly destinationAssembly, System.Type resolvedType);
                /*0x75d32b8*/ XmlObjectSerializerReadContextComplex(System.Runtime.Serialization.DataContractSerializer serializer, System.Runtime.Serialization.DataContract rootTypeDataContract, System.Runtime.Serialization.DataContractResolver dataContractResolver);
                /*0x75d7d9c*/ XmlObjectSerializerReadContextComplex(System.Runtime.Serialization.XmlObjectSerializer serializer, int maxItemsInObjectGraph, System.Runtime.Serialization.StreamingContext streamingContext, bool ignoreExtensionDataObject);
                /*0x75d7da8*/ System.Runtime.Serialization.SerializationMode get_Mode();
                /*0x75d7db0*/ System.Runtime.Serialization.DataContract GetDataContract(int id, System.RuntimeTypeHandle typeHandle);
                /*0x75d7f70*/ System.Runtime.Serialization.DataContract GetDataContract(System.RuntimeTypeHandle typeHandle, System.Type type);
                /*0x75d8130*/ object InternalDeserialize(System.Runtime.Serialization.XmlReaderDelegator xmlReader, int declaredTypeID, System.RuntimeTypeHandle declaredTypeHandle, string name, string ns);
                /*0x75d8998*/ object InternalDeserialize(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Type declaredType, string name, string ns);
                /*0x75d8a68*/ object InternalDeserialize(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Type declaredType, System.Runtime.Serialization.DataContract dataContract, string name, string ns);
                /*0x75d84e8*/ object InternalDeserializeInSharedTypeMode(System.Runtime.Serialization.XmlReaderDelegator xmlReader, int declaredTypeID, System.Type declaredType, string name, string ns);
                /*0x75d8234*/ object InternalDeserializeWithSurrogate(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Type declaredType, System.Runtime.Serialization.DataContract surrogateDataContract, string name, string ns);
                /*0x75d8b10*/ System.Type ResolveDataContractTypeInSharedTypeMode(string assemblyName, string typeName, ref System.Reflection.Assembly assembly);
                /*0x75d8a98*/ System.Runtime.Serialization.DataContract ResolveDataContractInSharedTypeMode(string assemblyName, string typeName, ref System.Reflection.Assembly assembly, ref System.Type type);
                /*0x75d93c8*/ System.Runtime.Serialization.DataContract ResolveDataContractFromTypeName();
                /*0x75d9420*/ bool CheckIfTypeSerializableForSharedTypeMode(System.Type memberType);
                /*0x75d94f0*/ void CheckIfTypeSerializable(System.Type memberType, bool isMemberTypeSerializable);
                /*0x75d9638*/ System.Type GetSurrogatedType(System.Type type);
                /*0x75d9774*/ int GetArraySize();

                class TopLevelAssemblyTypeResolver
                {
                    /*0x10*/ System.Reflection.Assembly topLevelAssembly;

                    /*0x75d92c8*/ TopLevelAssemblyTypeResolver(System.Reflection.Assembly topLevelAssembly);
                    /*0x75d988c*/ System.Type ResolveType(System.Reflection.Assembly assembly, string simpleTypeName, bool ignoreCase);
                }

                class XmlObjectDataContractTypeInfo
                {
                    /*0x10*/ System.Reflection.Assembly assembly;
                    /*0x18*/ System.Type type;

                    /*0x75d9384*/ XmlObjectDataContractTypeInfo(System.Reflection.Assembly assembly, System.Type type);
                    /*0x75d98f4*/ System.Reflection.Assembly get_Assembly();
                    /*0x75d98fc*/ System.Type get_Type();
                }

                class XmlObjectDataContractTypeKey
                {
                    /*0x10*/ string assemblyName;
                    /*0x18*/ string typeName;

                    /*0x75d9164*/ XmlObjectDataContractTypeKey(string assemblyName, string typeName);
                    /*0x75d9904*/ bool Equals(object obj);
                    /*0x75d99c8*/ int GetHashCode();
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

                static /*0x75d9a1c*/ System.Runtime.Serialization.XmlObjectSerializerWriteContext CreateContext(System.Runtime.Serialization.DataContractSerializer serializer, System.Runtime.Serialization.DataContract rootTypeDataContract, System.Runtime.Serialization.DataContractResolver dataContractResolver);
                static /*0x75d9b50*/ System.Runtime.Serialization.XmlObjectSerializerWriteContext CreateContext(System.Runtime.Serialization.NetDataContractSerializer serializer, System.Collections.Hashtable surrogateDataContracts);
                static /*0x3907c14*/ T GetDefaultValue<T>();
                static /*0x3907c14*/ T GetNullableValue<T>(System.Nullable<T> value);
                static /*0x75db400*/ void ThrowRequiredMemberMustBeEmitted(string memberName, System.Type type);
                static /*0x3907c14*/ bool GetHasValue<T>(System.Nullable<T> value);
                static /*0x75cdae4*/ void WriteRootIXmlSerializable(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj);
                static /*0x75db4f0*/ void WriteIXmlSerializable(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.XmlSerializableWriter xmlSerializableWriter);
                /*0x75d9ad8*/ XmlObjectSerializerWriteContext(System.Runtime.Serialization.DataContractSerializer serializer, System.Runtime.Serialization.DataContract rootTypeDataContract, System.Runtime.Serialization.DataContractResolver resolver);
                /*0x75d9c30*/ XmlObjectSerializerWriteContext(System.Runtime.Serialization.NetDataContractSerializer serializer);
                /*0x75d9ca4*/ XmlObjectSerializerWriteContext(System.Runtime.Serialization.XmlObjectSerializer serializer, int maxItemsInObjectGraph, System.Runtime.Serialization.StreamingContext streamingContext, bool ignoreExtensionDataObject);
                /*0x75d9cc8*/ System.Runtime.Serialization.ObjectToIdCache get_SerializedObjects();
                /*0x75d9d34*/ bool get_IsGetOnlyCollection();
                /*0x75d9d3c*/ void set_IsGetOnlyCollection(bool value);
                /*0x75d9d48*/ bool get_SerializeReadOnlyTypes();
                /*0x75d9d50*/ bool get_UnsafeTypeForwardingEnabled();
                /*0x75d9d58*/ void StoreIsGetOnlyCollection();
                /*0x75d9d64*/ void InternalSerializeReference(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, bool isDeclaredType, bool writeXsiType, int declaredTypeID, System.RuntimeTypeHandle declaredTypeHandle);
                /*0x75d9e04*/ void InternalSerialize(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, bool isDeclaredType, bool writeXsiType, int declaredTypeID, System.RuntimeTypeHandle declaredTypeHandle);
                /*0x75da044*/ void SerializeWithoutXsiType(System.Runtime.Serialization.DataContract dataContract, System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.RuntimeTypeHandle declaredTypeHandle);
                /*0x75da364*/ void SerializeWithXsiTypeAtTopLevel(System.Runtime.Serialization.DataContract dataContract, System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.RuntimeTypeHandle originalDeclaredTypeHandle, System.Type graphType);
                /*0x75da6a8*/ void SerializeWithXsiType(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.RuntimeTypeHandle objectTypeHandle, System.Type objectType, int declaredTypeID, System.RuntimeTypeHandle declaredTypeHandle, System.Type declaredType);
                /*0x75da12c*/ bool OnHandleIsReference(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Runtime.Serialization.DataContract contract, object obj);
                /*0x75da4b0*/ void SerializeAndVerifyType(System.Runtime.Serialization.DataContract dataContract, System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, bool verifyKnownType, System.RuntimeTypeHandle declaredTypeHandle, System.Type declaredType);
                /*0x75da9b8*/ bool WriteClrTypeInfo(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Runtime.Serialization.DataContract dataContract);
                /*0x75da9c0*/ bool WriteClrTypeInfo(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Type dataContractType, string clrTypeName, string clrAssemblyName);
                /*0x75da9c8*/ bool WriteClrTypeInfo(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Type dataContractType, System.Runtime.Serialization.SerializationInfo serInfo);
                /*0x75da9d0*/ void WriteAnyType(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object value);
                /*0x75da9ec*/ void WriteString(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, string value);
                /*0x75daa08*/ void WriteString(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, string value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75dab44*/ void WriteBase64(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, byte[] value);
                /*0x75dab6c*/ void WriteBase64(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, byte[] value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75dac5c*/ void WriteUri(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Uri value);
                /*0x75dac78*/ void WriteUri(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Uri value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75dad98*/ void WriteQName(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Xml.XmlQualifiedName value);
                /*0x75dadc4*/ void WriteQName(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Xml.XmlQualifiedName value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75daf38*/ void HandleGraphAtTopLevel(System.Runtime.Serialization.XmlWriterDelegator writer, object obj, System.Runtime.Serialization.DataContract contract);
                /*0x75db050*/ bool OnHandleReference(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, bool canContainCyclicReference);
                /*0x75db204*/ void OnEndHandleReference(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, bool canContainCyclicReference);
                /*0x75db238*/ void WriteNull(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Type memberType, bool isMemberTypeSerializable);
                /*0x75daac4*/ void WriteNull(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Type memberType, bool isMemberTypeSerializable, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75db284*/ void IncrementArrayCount(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Array array);
                /*0x75db320*/ void IncrementCollectionCount(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Collections.ICollection collection);
                /*0x380d93c*/ void IncrementCollectionCountGeneric<T>(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Collections.Generic.ICollection<T> collection);
                /*0x75db2e0*/ void IncrementCollectionCount(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, int size);
                /*0x75db3fc*/ void WriteArraySize(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, int size);
                /*0x75cdb50*/ void WriteIXmlSerializable(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj);
                /*0x75db74c*/ void GetObjectData(System.Runtime.Serialization.ISerializable obj, System.Runtime.Serialization.SerializationInfo serInfo, System.Runtime.Serialization.StreamingContext context);
                /*0x75db808*/ void WriteISerializable(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Runtime.Serialization.ISerializable obj);
                /*0x75cc2e8*/ void WriteSerializationInfo(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Type objType, System.Runtime.Serialization.SerializationInfo serInfo);
                /*0x75dbb9c*/ void WriteExtensionData(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Runtime.Serialization.ExtensionDataObject extensionData, int memberIndex);
                /*0x75dbd20*/ void WriteExtensionDataMember(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Runtime.Serialization.ExtensionDataMember member);
                /*0x75dc4ec*/ void WriteExtensionDataTypeInfo(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Runtime.Serialization.IDataNode dataNode);
                /*0x75dbd78*/ void WriteExtensionDataValue(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Runtime.Serialization.IDataNode dataNode);
                /*0x75dd31c*/ bool TryWriteDeserializedExtensionData(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Runtime.Serialization.IDataNode dataNode);
                /*0x75dc7b8*/ void WriteExtensionClassData(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Runtime.Serialization.ClassDataNode dataNode);
                /*0x75dc93c*/ void WriteExtensionCollectionData(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Runtime.Serialization.CollectionDataNode dataNode);
                /*0x75dd0ec*/ void WriteExtensionISerializableData(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Runtime.Serialization.ISerializableDataNode dataNode);
                /*0x75dcafc*/ void WriteExtensionXmlData(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Runtime.Serialization.XmlDataNode dataNode);
                /*0x75dd4bc*/ void WriteDataContractValue(System.Runtime.Serialization.DataContract dataContract, System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.RuntimeTypeHandle declaredTypeHandle);
                /*0x75dd4ec*/ void WriteNull(System.Runtime.Serialization.XmlWriterDelegator xmlWriter);
                /*0x75da44c*/ void WriteResolvedTypeInfo(System.Runtime.Serialization.XmlWriterDelegator writer, System.Type objectType, System.Type declaredType);
                /*0x75db99c*/ bool ResolveType(System.Type objectType, System.Type declaredType, ref System.Xml.XmlDictionaryString typeName, ref System.Xml.XmlDictionaryString typeNamespace);
                /*0x75dd4f4*/ bool WriteTypeInfo(System.Runtime.Serialization.XmlWriterDelegator writer, System.Runtime.Serialization.DataContract contract, System.Runtime.Serialization.DataContract declaredContract);
                /*0x75dd5b4*/ void WriteTypeInfo(System.Runtime.Serialization.XmlWriterDelegator writer, string dataContractName, string dataContractNamespace);
                /*0x75dd654*/ void WriteTypeInfo(System.Runtime.Serialization.XmlWriterDelegator writer, System.Xml.XmlDictionaryString dataContractName, System.Xml.XmlDictionaryString dataContractNamespace);
            }

            class XmlObjectSerializerWriteContextComplex : System.Runtime.Serialization.XmlObjectSerializerWriteContext
            {
                /*0xb8*/ System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate;
                /*0xc0*/ System.Runtime.Serialization.SerializationMode mode;
                /*0xc8*/ System.Runtime.Serialization.SerializationBinder binder;
                /*0xd0*/ System.Runtime.Serialization.ISurrogateSelector surrogateSelector;
                /*0xd8*/ System.Runtime.Serialization.StreamingContext streamingContext;
                /*0xe8*/ System.Collections.Hashtable surrogateDataContracts;

                /*0x75d9b10*/ XmlObjectSerializerWriteContextComplex(System.Runtime.Serialization.DataContractSerializer serializer, System.Runtime.Serialization.DataContract rootTypeDataContract, System.Runtime.Serialization.DataContractResolver dataContractResolver);
                /*0x75d9bb8*/ XmlObjectSerializerWriteContextComplex(System.Runtime.Serialization.NetDataContractSerializer serializer, System.Collections.Hashtable surrogateDataContracts);
                /*0x75dd6f4*/ XmlObjectSerializerWriteContextComplex(System.Runtime.Serialization.XmlObjectSerializer serializer, int maxItemsInObjectGraph, System.Runtime.Serialization.StreamingContext streamingContext, bool ignoreExtensionDataObject);
                /*0x75dd718*/ System.Runtime.Serialization.SerializationMode get_Mode();
                /*0x75dd720*/ System.Runtime.Serialization.DataContract GetDataContract(System.RuntimeTypeHandle typeHandle, System.Type type);
                /*0x75dd8e0*/ System.Runtime.Serialization.DataContract GetDataContract(int id, System.RuntimeTypeHandle typeHandle);
                /*0x75ddaa0*/ System.Runtime.Serialization.DataContract GetDataContractSkipValidation(int typeId, System.RuntimeTypeHandle typeHandle, System.Type type);
                /*0x75ddc74*/ bool WriteClrTypeInfo(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Runtime.Serialization.DataContract dataContract);
                /*0x75ddcfc*/ bool WriteClrTypeInfo(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Type dataContractType, string clrTypeName, string clrAssemblyName);
                /*0x75ddd9c*/ bool WriteClrTypeInfo(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Type dataContractType, System.Runtime.Serialization.SerializationInfo serInfo);
                /*0x75dde2c*/ void WriteAnyType(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object value);
                /*0x75dde80*/ void WriteString(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, string value);
                /*0x75dded4*/ void WriteString(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, string value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75ddfb4*/ void WriteBase64(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, byte[] value);
                /*0x75de00c*/ void WriteBase64(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, byte[] value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75de120*/ void WriteUri(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Uri value);
                /*0x75de174*/ void WriteUri(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Uri value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75de2b8*/ void WriteQName(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Xml.XmlQualifiedName value);
                /*0x75de314*/ void WriteQName(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Xml.XmlQualifiedName value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75de4ac*/ void InternalSerialize(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, bool isDeclaredType, bool writeXsiType, int declaredTypeID, System.RuntimeTypeHandle declaredTypeHandle);
                /*0x75de7fc*/ bool OnHandleReference(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, bool canContainCyclicReference);
                /*0x75de980*/ void OnEndHandleReference(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, bool canContainCyclicReference);
                /*0x75de9e8*/ bool CheckIfTypeSerializableForSharedTypeMode(System.Type memberType);
                /*0x75deab8*/ void CheckIfTypeSerializable(System.Type memberType, bool isMemberTypeSerializable);
                /*0x75dec00*/ System.Type GetSurrogatedType(System.Type type);
                /*0x75de4cc*/ void InternalSerializeWithSurrogate(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, bool isDeclaredType, bool writeXsiType, int declaredTypeID, System.RuntimeTypeHandle declaredTypeHandle);
                /*0x75ded3c*/ void WriteArraySize(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, int size);
            }

            class XmlReaderDelegator
            {
                /*0x10*/ System.Xml.XmlReader reader;
                /*0x18*/ System.Xml.XmlDictionaryReader dictionaryReader;
                /*0x20*/ bool isEndOfEmptyElement;

                /*0x75dedf4*/ XmlReaderDelegator(System.Xml.XmlReader reader);
                /*0x75deef8*/ System.Xml.XmlReader get_UnderlyingReader();
                /*0x75def00*/ System.Runtime.Serialization.ExtensionDataReader get_UnderlyingExtensionDataReader();
                /*0x75def7c*/ int get_AttributeCount();
                /*0x75defb4*/ string GetAttribute(string name);
                /*0x75defec*/ string GetAttribute(string name, string namespaceUri);
                /*0x75df024*/ string GetAttribute(int i);
                /*0x75df0bc*/ bool get_IsEmptyElement();
                /*0x75df0c4*/ bool IsNamespaceURI(string ns);
                /*0x75df11c*/ bool IsLocalName(string localName);
                /*0x75df174*/ bool IsNamespaceUri(System.Xml.XmlDictionaryString ns);
                /*0x75df1cc*/ bool IsLocalName(System.Xml.XmlDictionaryString localName);
                /*0x75df224*/ int IndexOfLocalName(System.Xml.XmlDictionaryString[] localNames, System.Xml.XmlDictionaryString ns);
                /*0x75df328*/ bool IsStartElement();
                /*0x75df360*/ bool IsStartElement(string localname, string ns);
                /*0x75df398*/ bool IsStartElement(System.Xml.XmlDictionaryString localname, System.Xml.XmlDictionaryString ns);
                /*0x75df400*/ bool MoveToAttribute(string name);
                /*0x75df438*/ bool MoveToAttribute(string name, string ns);
                /*0x75df470*/ void MoveToAttribute(int i);
                /*0x75df500*/ bool MoveToElement();
                /*0x75df538*/ bool MoveToFirstAttribute();
                /*0x75df570*/ bool MoveToNextAttribute();
                /*0x75df5a8*/ System.Xml.XmlNodeType get_NodeType();
                /*0x75df5dc*/ bool Read();
                /*0x75df660*/ System.Xml.XmlNodeType MoveToContent();
                /*0x75df698*/ bool ReadAttributeValue();
                /*0x75df6d0*/ void ReadEndElement();
                /*0x75df704*/ System.Exception CreateInvalidPrimitiveTypeException(System.Type type);
                /*0x75df8c0*/ object ReadElementContentAsAnyType(System.Type valueType);
                /*0x75df8fc*/ object ReadContentAsAnyType(System.Type valueType);
                /*0x75e046c*/ System.Runtime.Serialization.IDataNode ReadExtensionData(System.Type valueType);
                /*0x75e0de4*/ void ThrowConversionException(string value, string type);
                /*0x75e0eb8*/ void ThrowNotAtElement();
                /*0x75e0f60*/ char ReadElementContentAsChar();
                /*0x75e1030*/ char ReadContentAsChar();
                /*0x75e0fac*/ char ToChar(int value);
                /*0x75e104c*/ string ReadElementContentAsString();
                /*0x75e00fc*/ string ReadContentAsString();
                /*0x75e107c*/ bool ReadElementContentAsBoolean();
                /*0x75dfdc4*/ bool ReadContentAsBoolean();
                /*0x75e10ac*/ float ReadElementContentAsFloat();
                /*0x75dff7c*/ float ReadContentAsSingle();
                /*0x75e10dc*/ double ReadElementContentAsDouble();
                /*0x75dfffc*/ double ReadContentAsDouble();
                /*0x75e110c*/ decimal ReadElementContentAsDecimal();
                /*0x75e007c*/ decimal ReadContentAsDecimal();
                /*0x75e113c*/ byte[] ReadElementContentAsBase64();
                /*0x75e1310*/ byte[] ReadContentAsBase64();
                /*0x75e1194*/ byte[] ReadContentAsBase64(string str);
                /*0x75e13ac*/ System.DateTime ReadElementContentAsDateTime();
                /*0x75e13dc*/ System.DateTime ReadContentAsDateTime();
                /*0x75e0f7c*/ int ReadElementContentAsInt();
                /*0x75dfe7c*/ int ReadContentAsInt();
                /*0x75e145c*/ long ReadElementContentAsLong();
                /*0x75dfefc*/ long ReadContentAsLong();
                /*0x75e148c*/ short ReadElementContentAsShort();
                /*0x75dfe60*/ short ReadContentAsShort();
                /*0x75e14a8*/ short ToShort(int value);
                /*0x75e152c*/ byte ReadElementContentAsUnsignedByte();
                /*0x75dfe44*/ byte ReadContentAsUnsignedByte();
                /*0x75e1548*/ byte ToByte(int value);
                /*0x75e15cc*/ sbyte ReadElementContentAsSignedByte();
                /*0x75e0144*/ sbyte ReadContentAsSignedByte();
                /*0x75e15e8*/ sbyte ToSByte(int value);
                /*0x75e166c*/ uint ReadElementContentAsUnsignedInt();
                /*0x75e017c*/ uint ReadContentAsUnsignedInt();
                /*0x75e1688*/ uint ToUInt32(long value);
                /*0x75e170c*/ ulong ReadElementContentAsUnsignedLong();
                /*0x75e17d0*/ ulong ReadContentAsUnsignedLong();
                /*0x75e1888*/ ushort ReadElementContentAsUnsignedShort();
                /*0x75e0160*/ ushort ReadContentAsUnsignedShort();
                /*0x75e18a4*/ ushort ToUInt16(int value);
                /*0x75e1928*/ System.TimeSpan ReadElementContentAsTimeSpan();
                /*0x75e0198*/ System.TimeSpan ReadContentAsTimeSpan();
                /*0x75e19b0*/ System.Guid ReadElementContentAsGuid();
                /*0x75e0214*/ System.Guid ReadContentAsGuid();
                /*0x75e1adc*/ System.Uri ReadElementContentAsUri();
                /*0x75e0334*/ System.Uri ReadContentAsUri();
                /*0x75e1c20*/ System.Xml.XmlQualifiedName ReadElementContentAsQName();
                /*0x75e1c5c*/ System.Xml.XmlQualifiedName ReadContentAsQName();
                /*0x75e1c78*/ System.Xml.XmlQualifiedName ParseQualifiedName(string str);
                /*0x75e1d38*/ void CheckExpectedArrayLength(System.Runtime.Serialization.XmlObjectSerializerReadContext context, int arrayLength);
                /*0x75e1d54*/ int GetArrayLengthQuota(System.Runtime.Serialization.XmlObjectSerializerReadContext context);
                /*0x75e1e20*/ void CheckActualArrayLength(int expectedLength, int actualLength, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace);
                /*0x75e1f34*/ bool TryReadBooleanArray(System.Runtime.Serialization.XmlObjectSerializerReadContext context, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace, int arrayLength, ref bool[] array);
                /*0x75e20f8*/ bool TryReadDateTimeArray(System.Runtime.Serialization.XmlObjectSerializerReadContext context, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace, int arrayLength, ref System.DateTime[] array);
                /*0x75e22bc*/ bool TryReadDecimalArray(System.Runtime.Serialization.XmlObjectSerializerReadContext context, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace, int arrayLength, ref decimal[] array);
                /*0x75e2480*/ bool TryReadInt32Array(System.Runtime.Serialization.XmlObjectSerializerReadContext context, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace, int arrayLength, ref int[] array);
                /*0x75e2644*/ bool TryReadInt64Array(System.Runtime.Serialization.XmlObjectSerializerReadContext context, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace, int arrayLength, ref long[] array);
                /*0x75e2808*/ bool TryReadSingleArray(System.Runtime.Serialization.XmlObjectSerializerReadContext context, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace, int arrayLength, ref float[] array);
                /*0x75e29cc*/ bool TryReadDoubleArray(System.Runtime.Serialization.XmlObjectSerializerReadContext context, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace, int arrayLength, ref double[] array);
                /*0x75e2b90*/ System.Collections.Generic.IDictionary<string, string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope);
                /*0x75e2ca4*/ bool HasLineInfo();
                /*0x75e2d58*/ int get_LineNumber();
                /*0x75e2e10*/ int get_LinePosition();
                /*0x75e2ec8*/ bool get_Normalized();
                /*0x75e2fd0*/ void set_Normalized(bool value);
                /*0x75e30e8*/ System.Xml.WhitespaceHandling get_WhitespaceHandling();
                /*0x75e31f8*/ void set_WhitespaceHandling(System.Xml.WhitespaceHandling value);
                /*0x75e3310*/ string get_Name();
                /*0x75df308*/ string get_LocalName();
                /*0x75e3330*/ string get_NamespaceURI();
                /*0x75e3350*/ string get_Value();
                /*0x75e3370*/ System.Type get_ValueType();
                /*0x75e3394*/ int get_Depth();
                /*0x75e33b4*/ string LookupNamespace(string prefix);
                /*0x75e33d8*/ bool get_EOF();
                /*0x75e33fc*/ void Skip();
            }

            class XmlSerializableReader : System.Xml.XmlReader, System.Xml.IXmlLineInfo, System.Xml.Serialization.IXmlTextParser
            {
                /*0x10*/ System.Runtime.Serialization.XmlReaderDelegator xmlReader;
                /*0x18*/ int startDepth;
                /*0x1c*/ bool isRootEmptyElement;
                /*0x20*/ System.Xml.XmlReader innerReader;

                /*0x75e4304*/ XmlSerializableReader();
                /*0x75e342c*/ System.Xml.XmlReader get_InnerReader();
                /*0x75e3434*/ void BeginRead(System.Runtime.Serialization.XmlReaderDelegator xmlReader);
                /*0x75e34f0*/ void EndRead();
                /*0x75e35bc*/ bool Read();
                /*0x75e3664*/ void Close();
                /*0x75e3698*/ System.Xml.XmlReaderSettings get_Settings();
                /*0x75e36b8*/ System.Xml.XmlNodeType get_NodeType();
                /*0x75e36d8*/ string get_Name();
                /*0x75e36f8*/ string get_LocalName();
                /*0x75e3718*/ string get_NamespaceURI();
                /*0x75e3738*/ string get_Prefix();
                /*0x75e3758*/ string get_Value();
                /*0x75e3778*/ int get_Depth();
                /*0x75e3798*/ string get_BaseURI();
                /*0x75e37bc*/ bool get_IsEmptyElement();
                /*0x75e37e0*/ bool get_IsDefault();
                /*0x75e3804*/ char get_QuoteChar();
                /*0x75e3828*/ System.Xml.XmlSpace get_XmlSpace();
                /*0x75e384c*/ string get_XmlLang();
                /*0x75e3870*/ System.Xml.Schema.IXmlSchemaInfo get_SchemaInfo();
                /*0x75e3894*/ System.Type get_ValueType();
                /*0x75e38b8*/ int get_AttributeCount();
                /*0x75e38dc*/ bool get_EOF();
                /*0x75e3900*/ System.Xml.ReadState get_ReadState();
                /*0x75e3924*/ System.Xml.XmlNameTable get_NameTable();
                /*0x75e3948*/ bool get_CanResolveEntity();
                /*0x75e396c*/ bool get_CanReadValueChunk();
                /*0x75e3990*/ bool get_HasAttributes();
                /*0x75e39b4*/ string GetAttribute(string name);
                /*0x75e39d8*/ string GetAttribute(string name, string namespaceURI);
                /*0x75e39fc*/ string GetAttribute(int i);
                /*0x75e3a20*/ bool MoveToAttribute(string name);
                /*0x75e3a44*/ bool MoveToAttribute(string name, string ns);
                /*0x75e3a68*/ void MoveToAttribute(int i);
                /*0x75e3a8c*/ bool MoveToFirstAttribute();
                /*0x75e3ab0*/ bool MoveToNextAttribute();
                /*0x75e3ad4*/ bool MoveToElement();
                /*0x75e3af8*/ string LookupNamespace(string prefix);
                /*0x75e3b1c*/ bool ReadAttributeValue();
                /*0x75e3b40*/ void ResolveEntity();
                /*0x75e3b64*/ bool IsStartElement();
                /*0x75e3b88*/ bool IsStartElement(string localname, string ns);
                /*0x75e3bac*/ System.Xml.XmlNodeType MoveToContent();
                /*0x75e3bd0*/ object ReadContentAsObject();
                /*0x75e3bf4*/ bool ReadContentAsBoolean();
                /*0x75e3c18*/ System.DateTime ReadContentAsDateTime();
                /*0x75e3c3c*/ double ReadContentAsDouble();
                /*0x75e3c60*/ int ReadContentAsInt();
                /*0x75e3c84*/ long ReadContentAsLong();
                /*0x75e3ca8*/ string ReadContentAsString();
                /*0x75e3ccc*/ object ReadContentAs(System.Type returnType, System.Xml.IXmlNamespaceResolver namespaceResolver);
                /*0x75e3cf0*/ int ReadContentAsBase64(byte[] buffer, int index, int count);
                /*0x75e3d14*/ int ReadContentAsBinHex(byte[] buffer, int index, int count);
                /*0x75e3d38*/ int ReadValueChunk(char[] buffer, int index, int count);
                /*0x75e3d5c*/ string ReadString();
                /*0x75e3d80*/ bool System.Xml.Serialization.IXmlTextParser.get_Normalized();
                /*0x75e3e40*/ void System.Xml.Serialization.IXmlTextParser.set_Normalized(bool value);
                /*0x75e3f1c*/ System.Xml.WhitespaceHandling System.Xml.Serialization.IXmlTextParser.get_WhitespaceHandling();
                /*0x75e3fe0*/ void System.Xml.Serialization.IXmlTextParser.set_WhitespaceHandling(System.Xml.WhitespaceHandling value);
                /*0x75e40bc*/ bool System.Xml.IXmlLineInfo.HasLineInfo();
                /*0x75e417c*/ int System.Xml.IXmlLineInfo.get_LineNumber();
                /*0x75e4240*/ int System.Xml.IXmlLineInfo.get_LinePosition();
            }

            class XmlSerializableServices
            {
                static /*0x0*/ string ReadNodesMethodName;
                static /*0x8*/ string WriteNodesMethodName;
                static /*0x10*/ string AddDefaultSchemaMethodName;

                static /*0x75e47c8*/ XmlSerializableServices();
                static /*0x75e435c*/ System.Xml.XmlNode[] ReadNodes(System.Xml.XmlReader xmlReader);
                static /*0x75e46d0*/ bool IsValidAttribute(System.Xml.XmlReader xmlReader);
            }

            class XmlSerializableWriter : System.Xml.XmlWriter
            {
                /*0x18*/ System.Xml.XmlWriter xmlWriter;
                /*0x20*/ int depth;
                /*0x28*/ object obj;

                /*0x75e4fd8*/ XmlSerializableWriter();
                /*0x75e488c*/ void BeginWrite(System.Xml.XmlWriter xmlWriter, object obj);
                /*0x75e48c0*/ void EndWrite();
                /*0x75e49b4*/ void WriteStartDocument();
                /*0x75e49f4*/ void WriteEndDocument();
                /*0x75e4a14*/ void WriteStartDocument(bool standalone);
                /*0x75e4a6c*/ void WriteDocType(string name, string pubid, string sysid, string subset);
                /*0x75e4a70*/ void WriteStartElement(string prefix, string localName, string ns);
                /*0x75e4aa4*/ void WriteEndElement();
                /*0x75e4bac*/ void WriteFullEndElement();
                /*0x75e4cb4*/ void Close();
                /*0x75e4ce8*/ void WriteStartAttribute(string prefix, string localName, string ns);
                /*0x75e4d08*/ void WriteEndAttribute();
                /*0x75e4d2c*/ void WriteCData(string text);
                /*0x75e4d50*/ void WriteComment(string text);
                /*0x75e4d74*/ void WriteProcessingInstruction(string name, string text);
                /*0x75e4d98*/ void WriteEntityRef(string name);
                /*0x75e4dbc*/ void WriteCharEntity(char ch);
                /*0x75e4de0*/ void WriteWhitespace(string ws);
                /*0x75e4e04*/ void WriteString(string text);
                /*0x75e4e28*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
                /*0x75e4e4c*/ void WriteChars(char[] buffer, int index, int count);
                /*0x75e4e70*/ void WriteRaw(char[] buffer, int index, int count);
                /*0x75e4e94*/ void WriteRaw(string data);
                /*0x75e4eb8*/ void WriteBase64(byte[] buffer, int index, int count);
                /*0x75e4edc*/ void WriteBinHex(byte[] buffer, int index, int count);
                /*0x75e4f00*/ System.Xml.WriteState get_WriteState();
                /*0x75e4f24*/ void Flush();
                /*0x75e4f48*/ void WriteQualifiedName(string localName, string ns);
                /*0x75e4f6c*/ string LookupPrefix(string ns);
                /*0x75e4f90*/ System.Xml.XmlSpace get_XmlSpace();
                /*0x75e4fb4*/ string get_XmlLang();
            }

            class XmlWriterDelegator
            {
                /*0x10*/ System.Xml.XmlWriter writer;
                /*0x18*/ System.Xml.XmlDictionaryWriter dictionaryWriter;
                /*0x20*/ int depth;
                /*0x24*/ int prefixes;

                /*0x75e4fe0*/ XmlWriterDelegator(System.Xml.XmlWriter writer);
                /*0x75e50e4*/ System.Xml.XmlWriter get_Writer();
                /*0x75e50ec*/ void Flush();
                /*0x75e5110*/ string LookupPrefix(string ns);
                /*0x75e5134*/ void WriteEndAttribute();
                /*0x75e5158*/ void WriteEndElement();
                /*0x75e518c*/ void WriteRaw(char[] buffer, int index, int count);
                /*0x75e51b0*/ void WriteRaw(string data);
                /*0x75e51d4*/ void WriteXmlnsAttribute(System.Xml.XmlDictionaryString ns);
                /*0x75e5224*/ void WriteXmlnsAttribute(string ns);
                /*0x75e53dc*/ void WriteXmlnsAttribute(string prefix, System.Xml.XmlDictionaryString ns);
                /*0x75e547c*/ void WriteStartAttribute(string prefix, string localName, string ns);
                /*0x75e549c*/ void WriteStartAttribute(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri);
                /*0x75e54e8*/ void WriteAttributeString(string prefix, string localName, string ns, string value);
                /*0x75e5570*/ void WriteAttributeString(string prefix, System.Xml.XmlDictionaryString attrName, System.Xml.XmlDictionaryString attrNs, string value);
                /*0x75e554c*/ void WriteAttributeStringValue(string value);
                /*0x75e55c4*/ void WriteAttributeString(string prefix, System.Xml.XmlDictionaryString attrName, System.Xml.XmlDictionaryString attrNs, System.Xml.XmlDictionaryString value);
                /*0x75e5608*/ void WriteAttributeStringValue(System.Xml.XmlDictionaryString value);
                /*0x75e5650*/ void WriteAttributeInt(string prefix, System.Xml.XmlDictionaryString attrName, System.Xml.XmlDictionaryString attrNs, int value);
                /*0x75e56a4*/ void WriteAttributeIntValue(int value);
                /*0x75e56c8*/ void WriteAttributeBool(string prefix, System.Xml.XmlDictionaryString attrName, System.Xml.XmlDictionaryString attrNs, bool value);
                /*0x75e571c*/ void WriteAttributeBoolValue(bool value);
                /*0x75e5744*/ void WriteAttributeQualifiedName(string attrPrefix, System.Xml.XmlDictionaryString attrName, System.Xml.XmlDictionaryString attrNs, string name, string ns);
                /*0x75e57d4*/ void WriteAttributeQualifiedNameValue(string name, string ns);
                /*0x75e57f8*/ void WriteAttributeQualifiedName(string attrPrefix, System.Xml.XmlDictionaryString attrName, System.Xml.XmlDictionaryString attrNs, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75e5878*/ void WriteAttributeQualifiedNameValue(System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75e58c8*/ void WriteStartElement(string localName, string ns);
                /*0x75e58e0*/ void WriteStartElement(string prefix, string localName, string ns);
                /*0x75e5918*/ void WriteStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri);
                /*0x75e5928*/ void WriteStartElement(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri);
                /*0x75e5988*/ void WriteStartElementPrimitive(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri);
                /*0x75e59e0*/ void WriteEndElementPrimitive();
                /*0x75e5a00*/ System.Xml.WriteState get_WriteState();
                /*0x75e5a24*/ string get_XmlLang();
                /*0x75e5a48*/ System.Xml.XmlSpace get_XmlSpace();
                /*0x75e5a6c*/ void WriteNamespaceDecl(System.Xml.XmlDictionaryString ns);
                /*0x75e5a70*/ System.Exception CreateInvalidPrimitiveTypeException(System.Type type);
                /*0x75e5b78*/ void WriteAnyType(object value);
                /*0x75e5bb4*/ void WriteAnyType(object value, System.Type valueType);
                /*0x75e64a8*/ void WriteExtensionData(System.Runtime.Serialization.IDataNode dataNode);
                /*0x75e636c*/ void WriteString(string value);
                /*0x75e6fd8*/ void WriteBoolean(bool value);
                /*0x75e7000*/ void WriteBoolean(bool value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75e7050*/ void WriteDateTime(System.DateTime value);
                /*0x75e7074*/ void WriteDateTime(System.DateTime value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75e70c4*/ void WriteDecimal(decimal value);
                /*0x75e70e8*/ void WriteDecimal(decimal value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75e7140*/ void WriteDouble(double value);
                /*0x75e7164*/ void WriteDouble(double value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75e71ac*/ void WriteInt(int value);
                /*0x75e71d0*/ void WriteInt(int value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75e7220*/ void WriteLong(long value);
                /*0x75e7244*/ void WriteLong(long value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75e7294*/ void WriteFloat(float value);
                /*0x75e72b8*/ void WriteFloat(float value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75e7300*/ void WriteBase64(byte[] bytes);
                /*0x75e7338*/ void WriteShort(short value);
                /*0x75e7360*/ void WriteShort(short value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75e73b4*/ void WriteUnsignedByte(byte value);
                /*0x75e73dc*/ void WriteUnsignedByte(byte value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75e7430*/ void WriteSignedByte(sbyte value);
                /*0x75e7458*/ void WriteSignedByte(sbyte value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75e74ac*/ void WriteUnsignedInt(uint value);
                /*0x75e74d4*/ void WriteUnsignedInt(uint value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75e7528*/ void WriteUnsignedLong(ulong value);
                /*0x75e75b0*/ void WriteUnsignedLong(ulong value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75e7604*/ void WriteUnsignedShort(ushort value);
                /*0x75e762c*/ void WriteUnsignedShort(ushort value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75e7680*/ void WriteChar(char value);
                /*0x75e76a8*/ void WriteChar(char value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75e6390*/ void WriteTimeSpan(System.TimeSpan value);
                /*0x75e76fc*/ void WriteTimeSpan(System.TimeSpan value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75e6418*/ void WriteGuid(System.Guid value);
                /*0x75e7744*/ void WriteGuid(System.Guid value, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75e6460*/ void WriteUri(System.Uri value);
                /*0x75e7794*/ void WriteQName(System.Xml.XmlQualifiedName value);
                /*0x75e7848*/ void WriteQualifiedName(string localName, string ns);
                /*0x75e786c*/ void WriteQualifiedName(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString ns);
                /*0x75e78bc*/ void WriteBooleanArray(bool[] value, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace);
                /*0x75e7984*/ void WriteDateTimeArray(System.DateTime[] value, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace);
                /*0x75e7a4c*/ void WriteDecimalArray(decimal[] value, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace);
                /*0x75e7b18*/ void WriteInt32Array(int[] value, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace);
                /*0x75e7be0*/ void WriteInt64Array(long[] value, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace);
                /*0x75e7ca8*/ void WriteSingleArray(float[] value, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace);
                /*0x75e7d70*/ void WriteDoubleArray(double[] value, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace);
            }

            class BitFlagsGenerator
            {
                /*0x10*/ int bitCount;
                /*0x18*/ byte[] locals;

                static /*0x75e803c*/ bool IsBitSet(byte[] bytes, int bitIndex);
                static /*0x75e8084*/ void SetBit(byte[] bytes, int bitIndex);
                static /*0x75e7f10*/ int GetByteIndex(int bitIndex);
                static /*0x75e7f18*/ byte GetBitValue(int bitIndex);
                /*0x75e7e38*/ BitFlagsGenerator(int bitCount);
                /*0x75e7ebc*/ void Store(int bitIndex, bool value);
                /*0x75e7f28*/ bool Load(int bitIndex);
                /*0x75e7f70*/ byte[] LoadArray();
                /*0x75e7fe8*/ int GetLocalCount();
                /*0x75e8004*/ int GetBitCount();
                /*0x75e800c*/ byte GetLocal(int i);
            }

            class CodeInterpreter
            {
                static /*0x75e80c8*/ object ConvertValue(object arg, System.Type source, System.Type target);
                static /*0x75e831c*/ bool CanConvert(System.TypeCode typeCode);
                static /*0x75e80d0*/ object InternalConvert(object arg, System.Type source, System.Type target, bool isAddress);
                static /*0x75e832c*/ object GetMember(System.Reflection.MemberInfo memberInfo, object instance);
                static /*0x75e8458*/ void SetMember(System.Reflection.MemberInfo memberInfo, object instance, object value);
            }

            class DiagnosticUtility
            {
                static /*0x0*/ bool ShouldTraceError;
                static /*0x1*/ bool ShouldTraceWarning;
                static /*0x2*/ bool ShouldTraceInformation;
                static /*0x3*/ bool ShouldTraceVerbose;

                static /*0x75e8598*/ DiagnosticUtility();

                class DiagnosticTrace
                {
                    static /*0x75e85e8*/ void TraceEvent(object[] args);
                }

                class ExceptionUtility
                {
                    static /*0x75df0b8*/ System.Exception ThrowHelperError(System.Exception e);
                    static /*0x75e85f0*/ System.Exception ThrowHelperCallback(System.Exception e);
                    static /*0x75e85ec*/ System.Exception ThrowHelper(System.Exception e, System.Diagnostics.TraceEventType type);
                    static /*0x75e866c*/ System.Exception ThrowHelperArgument(string arg, string message);
                    static /*0x75e4674*/ System.Exception ThrowHelperArgumentNull(string arg);
                    static /*0x75e86d8*/ System.Exception ThrowHelperFatal(string msg, System.Exception e);
                }
            }

            class FxTrace
            {
                static /*0x0*/ bool ShouldTraceError;
                static /*0x1*/ bool ShouldTraceVerbose;

                static /*0x75e8758*/ FxTrace();
                static /*0x75e8744*/ System.Runtime.Diagnostics.EtwDiagnosticTrace get_Trace();
                static /*0x75e874c*/ bool IsEventEnabled(int index);
                static /*0x75e8754*/ void UpdateEventDefinitions(System.Runtime.Diagnostics.EventDescriptor[] ed, ushort[] events);
            }

            class SR
            {
                static /*0x75df850*/ string GetString(string name, object[] args);
                static /*0x75e87a4*/ string GetString(System.Globalization.CultureInfo culture, string name, object[] args);
                static /*0x75df0b4*/ string GetString(string name);
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

                /*0x75e87ac*/ CodeTypeReference(string typeName, System.Runtime.Serialization.CodeTypeReferenceOptions codeTypeReferenceOption);
                /*0x75e9070*/ CodeTypeReference(string typeName);
                /*0x75e92e4*/ CodeTypeReference(System.Runtime.Serialization.CodeTypeReference arrayType, int rank);
                /*0x75e90a0*/ void Initialize(string typeName);
                /*0x75e87e0*/ void Initialize(string typeName, System.Runtime.Serialization.CodeTypeReferenceOptions options);
                /*0x75e932c*/ string get_BaseType();
                /*0x75e9454*/ System.Runtime.Serialization.CodeTypeReferenceOptions get_Options();
                /*0x75e945c*/ void set_Options(System.Runtime.Serialization.CodeTypeReferenceOptions value);
                /*0x75e9248*/ System.Collections.Generic.List<System.Runtime.Serialization.CodeTypeReference> get_TypeArguments();
                /*0x75e90a8*/ string RipOffAssemblyInformationFromTypeName(string typeName);
            }

            class XmlDataContractInterpreter
            {
                /*0x10*/ System.Runtime.Serialization.XmlDataContract contract;

                /*0x75e9464*/ XmlDataContractInterpreter(System.Runtime.Serialization.XmlDataContract contract);
                /*0x75e9494*/ System.Xml.Serialization.IXmlSerializable CreateXmlSerializable();
                /*0x75e95a0*/ System.Reflection.ConstructorInfo GetConstructor();
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

                /*0x75e9720*/ XmlFormatReaderInterpreter(System.Runtime.Serialization.ClassDataContract classContract);
                /*0x75e9750*/ XmlFormatReaderInterpreter(System.Runtime.Serialization.CollectionDataContract collectionContract, bool isGetOnly);
                /*0x75e978c*/ object ReadFromXml(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.XmlObjectSerializerReadContext context, System.Xml.XmlDictionaryString[] memberNames, System.Xml.XmlDictionaryString[] memberNamespaces);
                /*0x75ea470*/ object ReadCollectionFromXml(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.XmlObjectSerializerReadContext context, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace, System.Runtime.Serialization.CollectionDataContract collectionContract);
                /*0x75ead80*/ void ReadGetOnlyCollectionFromXml(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.XmlObjectSerializerReadContext context, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace, System.Runtime.Serialization.CollectionDataContract collectionContract);
                /*0x75e9ae4*/ void CreateObject(System.Runtime.Serialization.ClassDataContract classContract);
                /*0x75e9d30*/ void InvokeOnDeserializing(System.Runtime.Serialization.ClassDataContract classContract);
                /*0x75ea318*/ void InvokeOnDeserialized(System.Runtime.Serialization.ClassDataContract classContract);
                /*0x75e9e88*/ bool HasFactoryMethod(System.Runtime.Serialization.ClassDataContract classContract);
                /*0x75ea1f4*/ bool InvokeFactoryMethod(System.Runtime.Serialization.ClassDataContract classContract, string objectId);
                /*0x75e9f10*/ void ReadISerializable(System.Runtime.Serialization.ClassDataContract classContract);
                /*0x75ea08c*/ void ReadClass(System.Runtime.Serialization.ClassDataContract classContract);
                /*0x75eb078*/ void ReadMembers(System.Runtime.Serialization.ClassDataContract classContract, System.Runtime.Serialization.ExtensionDataObject extensionData);
                /*0x75eb284*/ int ReadMembers(int index, System.Runtime.Serialization.ClassDataContract classContract, bool[] requiredMembers, ref int memberIndex, ref int requiredIndex);
                /*0x75eb1bc*/ bool[] GetRequiredMembers(System.Runtime.Serialization.ClassDataContract contract, ref int firstRequiredMember);
                /*0x75eba6c*/ int GetRequiredMembers(System.Runtime.Serialization.ClassDataContract contract, bool[] requiredMembers);
                /*0x75eb4c4*/ object ReadValue(System.Type type, string name, string ns);
                /*0x75ebb84*/ object InternalDeserialize(System.Type type, string name, string ns);
                /*0x75ebd64*/ object WrapNullableObject(System.Type innerType, object innerValue, System.Type outerType, int nullables);
                /*0x75ea4f8*/ void ReadCollection(System.Runtime.Serialization.CollectionDataContract collectionContract);
                /*0x75eae00*/ void ReadGetOnlyCollection(System.Runtime.Serialization.CollectionDataContract collectionContract);
                /*0x75ebf48*/ bool TryReadPrimitiveArray(System.Type type, System.Type itemType, int size, ref bool readResult);
                /*0x75ec29c*/ object ReadCollectionItem(System.Runtime.Serialization.CollectionDataContract collectionContract, System.Type itemType, string itemName, string itemNs);
                /*0x75ec3b8*/ void StoreCollectionValue(object collection, System.Type valueType, object value, System.Runtime.Serialization.CollectionDataContract collectionContract);
                /*0x75ec638*/ void HandleUnexpectedItemInCollection(ref int iterator);
                /*0x75ec284*/ bool IsStartElement(System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                /*0x75ec6b4*/ bool IsStartElement();
                /*0x75ec614*/ bool IsEndElement();
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

                /*0x75ec6cc*/ XmlFormatWriterInterpreter(System.Runtime.Serialization.ClassDataContract classContract);
                /*0x75ec704*/ XmlFormatWriterInterpreter(System.Runtime.Serialization.CollectionDataContract collectionContract);
                /*0x75ec73c*/ System.Runtime.Serialization.ClassDataContract get_classDataContract();
                /*0x75ec798*/ System.Runtime.Serialization.CollectionDataContract get_collectionDataContract();
                /*0x75ec7f4*/ void WriteToXml(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context, System.Runtime.Serialization.ClassDataContract dataContract);
                /*0x75eccfc*/ void WriteCollectionToXml(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.XmlObjectSerializerWriteContext context, System.Runtime.Serialization.CollectionDataContract collectionContract);
                /*0x75ec8b4*/ void InitArgs(System.Type objType);
                /*0x75edf7c*/ void InvokeOnSerializing(System.Runtime.Serialization.ClassDataContract classContract, object objSerialized, System.Runtime.Serialization.XmlObjectSerializerWriteContext ctx);
                /*0x75ee0dc*/ void InvokeOnSerialized(System.Runtime.Serialization.ClassDataContract classContract, object objSerialized, System.Runtime.Serialization.XmlObjectSerializerWriteContext ctx);
                /*0x75eca38*/ void WriteClass(System.Runtime.Serialization.ClassDataContract classContract);
                /*0x75ecdb0*/ void WriteCollection(System.Runtime.Serialization.CollectionDataContract collectionContract);
                /*0x75ee23c*/ int WriteMembers(System.Runtime.Serialization.ClassDataContract classContract, System.Runtime.Serialization.ExtensionDataObject extensionData, System.Runtime.Serialization.ClassDataContract derivedMostClassContract);
                /*0x75efb64*/ bool IsDefaultValue(System.Type type, object value);
                /*0x75efd24*/ object GetDefaultValue(System.Type type);
                /*0x75efb98*/ bool CheckIfMemberHasConflict(System.Runtime.Serialization.DataMember member, System.Runtime.Serialization.ClassDataContract classContract, System.Runtime.Serialization.ClassDataContract derivedMostClassContract);
                /*0x75efe74*/ bool CheckIfConflictingMembersHaveDifferentTypes(System.Runtime.Serialization.DataMember member);
                /*0x75eff28*/ bool NeedsPrefix(System.Type type, System.Xml.XmlDictionaryString ns);
                /*0x75eef1c*/ void WriteStartElement(System.Type type, System.Xml.XmlDictionaryString ns, System.Xml.XmlDictionaryString namespaceLocal, System.Xml.XmlDictionaryString nameLocal, int nameIndex);
                /*0x75efb14*/ void WriteEndElement();
                /*0x75eefd4*/ void WriteValue(System.Type memberType, object memberValue, bool writeXsiType);
                /*0x75efff0*/ object UnwrapNullableObject(System.Func<object> memberValue, ref System.Type memberType, ref bool isNull);
                /*0x75eea7c*/ bool TryWritePrimitive(System.Type type, System.Func<object> value, System.Reflection.MemberInfo memberInfo, System.Nullable<int> arrayItemIndex, System.Xml.XmlDictionaryString ns, System.Xml.XmlDictionaryString name, int nameIndex);
                /*0x75ee700*/ bool TryWritePrimitiveArray(System.Type type, System.Type itemType, System.Func<object> value, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace);
                /*0x75efb3c*/ object LoadMemberValue(System.Runtime.Serialization.DataMember member);
                /*0x75f03fc*/ object <WriteCollection>b__24_0();

                class <>c__DisplayClass24_0
                {
                    /*0x10*/ object currentValue;

                    /*0x75efb2c*/ <>c__DisplayClass24_0();
                    /*0x75f0404*/ object <WriteCollection>b__1();
                }

                class <>c__DisplayClass25_0
                {
                    /*0x10*/ object memberValue;

                    /*0x75efb34*/ <>c__DisplayClass25_0();
                    /*0x75f040c*/ object <WriteMembers>b__0();
                }

                class <>c__DisplayClass33_0
                {
                    /*0x10*/ object memberValue;

                    /*0x75effe8*/ <>c__DisplayClass33_0();
                    /*0x75f0414*/ object <WriteValue>b__0();
                }
            }

            namespace Json
            {
                class ByteArrayHelperWithString : System.Xml.ArrayHelper<string, byte>
                {
                    static /*0x0*/ System.Runtime.Serialization.Json.ByteArrayHelperWithString Instance;

                    static /*0x75f08bc*/ ByteArrayHelperWithString();
                    /*0x75f0874*/ ByteArrayHelperWithString();
                    /*0x75f041c*/ void WriteArray(System.Xml.XmlWriter writer, byte[] array, int offset, int count);
                    /*0x75f05d8*/ int ReadArray(System.Xml.XmlDictionaryReader reader, string localName, string namespaceUri, byte[] array, int offset, int count);
                    /*0x75f07a8*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, byte[] array, int offset, int count);
                    /*0x75f07b8*/ void ThrowConversionException(string value, string type);
                    /*0x75f0734*/ byte ToByte(int value);
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

                    static /*0x75f1984*/ bool CheckIfJsonNameRequiresMapping(string jsonName);
                    static /*0x75f19fc*/ bool CheckIfJsonNameRequiresMapping(System.Xml.XmlDictionaryString jsonName);
                    static /*0x75f1a0c*/ bool CheckIfXmlNameRequiresMapping(string xmlName);
                    static /*0x75f1a7c*/ bool CheckIfXmlNameRequiresMapping(System.Xml.XmlDictionaryString xmlName);
                    static /*0x75f1a24*/ string ConvertXmlNameToJsonName(string xmlName);
                    static /*0x75f1a8c*/ System.Xml.XmlDictionaryString ConvertXmlNameToJsonName(System.Xml.XmlDictionaryString xmlName);
                    static /*0x75f1b14*/ bool IsJsonLocalName(System.Runtime.Serialization.XmlReaderDelegator reader, string elementName);
                    static /*0x75f1b5c*/ object ReadJsonValue(System.Runtime.Serialization.DataContract contract, System.Runtime.Serialization.XmlReaderDelegator reader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context);
                    static /*0x75f1c34*/ void WriteJsonNull(System.Runtime.Serialization.XmlWriterDelegator writer);
                    static /*0x75f1ca4*/ void WriteJsonValue(System.Runtime.Serialization.Json.JsonDataContract contract, System.Runtime.Serialization.XmlWriterDelegator writer, object graph, System.Runtime.Serialization.Json.XmlObjectSerializerWriteContextComplexJson context, System.RuntimeTypeHandle declaredTypeHandle);
                    static /*0x75f11a4*/ void CheckIfTypeIsReference(System.Runtime.Serialization.DataContract dataContract);
                    static /*0x75f241c*/ System.Runtime.Serialization.DataContract GetDataContract(System.Runtime.Serialization.DataContract declaredTypeContract, System.Type declaredType, System.Type objectType);
                    /*0x75f0920*/ DataContractJsonSerializer(System.Type type);
                    /*0x75f0928*/ DataContractJsonSerializer(System.Type type, System.Collections.Generic.IEnumerable<System.Type> knownTypes);
                    /*0x75f0984*/ DataContractJsonSerializer(System.Type type, System.Collections.Generic.IEnumerable<System.Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate, bool alwaysEmitTypeInformation);
                    /*0x75f0f0c*/ DataContractJsonSerializer(System.Type type, System.Runtime.Serialization.Json.DataContractJsonSerializerSettings settings);
                    /*0x75f10d0*/ System.Runtime.Serialization.IDataContractSurrogate get_DataContractSurrogate();
                    /*0x75f10d8*/ bool get_IgnoreExtensionDataObject();
                    /*0x75f10e0*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> get_KnownDataContracts();
                    /*0x75f1120*/ int get_MaxItemsInObjectGraph();
                    /*0x75f1128*/ System.Runtime.Serialization.EmitTypeInformation get_EmitTypeInformation();
                    /*0x75f1130*/ bool get_SerializeReadOnlyTypes();
                    /*0x75f1138*/ System.Runtime.Serialization.DateTimeFormat get_DateTimeFormat();
                    /*0x75f1140*/ bool get_UseSimpleDictionaryFormat();
                    /*0x75f1148*/ System.Runtime.Serialization.DataContract get_RootContract();
                    /*0x75f12c8*/ System.Xml.XmlDictionaryString get_RootName();
                    /*0x75f132c*/ object ReadObject(System.IO.Stream stream);
                    /*0x75f1408*/ object ReadObject(System.Xml.XmlReader reader, bool verifyObjectName);
                    /*0x75f1488*/ object ReadObject(System.Xml.XmlDictionaryReader reader);
                    /*0x75f1504*/ object ReadObject(System.Xml.XmlDictionaryReader reader, bool verifyObjectName);
                    /*0x75f1584*/ void WriteEndObject(System.Xml.XmlWriter writer);
                    /*0x75f15f4*/ void WriteEndObject(System.Xml.XmlDictionaryWriter writer);
                    /*0x75f1664*/ void WriteObject(System.IO.Stream stream, object graph);
                    /*0x75f1714*/ void WriteObject(System.Xml.XmlDictionaryWriter writer, object graph);
                    /*0x75f1794*/ void WriteObjectContent(System.Xml.XmlWriter writer, object graph);
                    /*0x75f1814*/ void WriteObjectContent(System.Xml.XmlDictionaryWriter writer, object graph);
                    /*0x75f1894*/ void WriteStartObject(System.Xml.XmlWriter writer, object graph);
                    /*0x75f190c*/ void WriteStartObject(System.Xml.XmlDictionaryWriter writer, object graph);
                    /*0x75f1d14*/ System.Type GetDeserializeType();
                    /*0x75f1d1c*/ System.Type GetSerializeType(object graph);
                    /*0x75f1d34*/ bool InternalIsStartObject(System.Runtime.Serialization.XmlReaderDelegator reader);
                    /*0x75f1e00*/ object InternalReadObject(System.Runtime.Serialization.XmlReaderDelegator xmlReader, bool verifyObjectName);
                    /*0x75f20a0*/ void InternalWriteEndObject(System.Runtime.Serialization.XmlWriterDelegator writer);
                    /*0x75f20b4*/ void InternalWriteObject(System.Runtime.Serialization.XmlWriterDelegator writer, object graph);
                    /*0x75f2114*/ void InternalWriteObjectContent(System.Runtime.Serialization.XmlWriterDelegator writer, object graph);
                    /*0x75f243c*/ void InternalWriteStartObject(System.Runtime.Serialization.XmlWriterDelegator writer, object graph);
                    /*0x75f253c*/ void AddCollectionItemTypeToKnownTypes(System.Type knownType);
                    /*0x75f0a00*/ void Initialize(System.Type type, System.Collections.Generic.IEnumerable<System.Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate, System.Runtime.Serialization.EmitTypeInformation emitTypeInformation, bool serializeReadOnlyTypes, System.Runtime.Serialization.DateTimeFormat dateTimeFormat, bool useSimpleDictionaryFormat);
                    /*0x75f1034*/ void Initialize(System.Type type, System.Xml.XmlDictionaryString rootName, System.Collections.Generic.IEnumerable<System.Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate, System.Runtime.Serialization.EmitTypeInformation emitTypeInformation, bool serializeReadOnlyTypes, System.Runtime.Serialization.DateTimeFormat dateTimeFormat, bool useSimpleDictionaryFormat);
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

                    /*0x75f1024*/ DataContractJsonSerializerSettings();
                    /*0x75f2720*/ string get_RootName();
                    /*0x75f2728*/ System.Collections.Generic.IEnumerable<System.Type> get_KnownTypes();
                    /*0x75f2730*/ int get_MaxItemsInObjectGraph();
                    /*0x75f2738*/ bool get_IgnoreExtensionDataObject();
                    /*0x75f2740*/ System.Runtime.Serialization.IDataContractSurrogate get_DataContractSurrogate();
                    /*0x75f2748*/ System.Runtime.Serialization.EmitTypeInformation get_EmitTypeInformation();
                    /*0x75f2750*/ System.Runtime.Serialization.DateTimeFormat get_DateTimeFormat();
                    /*0x75f2758*/ bool get_SerializeReadOnlyTypes();
                    /*0x75f2760*/ bool get_UseSimpleDictionaryFormat();
                    /*0x75f2768*/ void set_UseSimpleDictionaryFormat(bool value);
                }

                class JsonByteArrayDataContract : System.Runtime.Serialization.Json.JsonDataContract
                {
                    /*0x75f2774*/ JsonByteArrayDataContract(System.Runtime.Serialization.ByteArrayDataContract traditionalByteArrayDataContract);
                    /*0x75f27f0*/ object ReadJsonValueCore(System.Runtime.Serialization.XmlReaderDelegator jsonReader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context);
                }

                class JsonClassDataContract : System.Runtime.Serialization.Json.JsonDataContract
                {
                    /*0x18*/ System.Runtime.Serialization.Json.JsonClassDataContract.JsonClassDataContractCriticalHelper helper;

                    /*0x75f2960*/ JsonClassDataContract(System.Runtime.Serialization.ClassDataContract traditionalDataContract);
                    /*0x75f2ba0*/ System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate get_JsonFormatReaderDelegate();
                    /*0x75f2d90*/ System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate get_JsonFormatWriterDelegate();
                    /*0x75f2f10*/ System.Xml.XmlDictionaryString[] get_MemberNames();
                    /*0x75f2f2c*/ string get_TypeName();
                    /*0x75f2d74*/ System.Runtime.Serialization.ClassDataContract get_TraditionalClassDataContract();
                    /*0x75f2f4c*/ object ReadJsonValueCore(System.Runtime.Serialization.XmlReaderDelegator jsonReader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context);
                    /*0x75f3010*/ void WriteJsonValueCore(System.Runtime.Serialization.XmlWriterDelegator jsonWriter, object obj, System.Runtime.Serialization.Json.XmlObjectSerializerWriteContextComplexJson context, System.RuntimeTypeHandle declaredTypeHandle);

                    class JsonClassDataContractCriticalHelper : System.Runtime.Serialization.Json.JsonDataContract.JsonDataContractCriticalHelper
                    {
                        /*0x28*/ System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate jsonFormatReaderDelegate;
                        /*0x30*/ System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate jsonFormatWriterDelegate;
                        /*0x38*/ System.Xml.XmlDictionaryString[] memberNames;
                        /*0x40*/ System.Runtime.Serialization.ClassDataContract traditionalClassDataContract;
                        /*0x48*/ string typeName;

                        /*0x75f2a5c*/ JsonClassDataContractCriticalHelper(System.Runtime.Serialization.ClassDataContract traditionalDataContract);
                        /*0x75f34cc*/ System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate get_JsonFormatReaderDelegate();
                        /*0x75f34d4*/ void set_JsonFormatReaderDelegate(System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate value);
                        /*0x75f34dc*/ System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate get_JsonFormatWriterDelegate();
                        /*0x75f34e4*/ void set_JsonFormatWriterDelegate(System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate value);
                        /*0x75f34ec*/ System.Xml.XmlDictionaryString[] get_MemberNames();
                        /*0x75f34f4*/ System.Runtime.Serialization.ClassDataContract get_TraditionalClassDataContract();
                        /*0x75f31b0*/ void CopyMembersAndCheckDuplicateNames();
                    }
                }

                class JsonCollectionDataContract : System.Runtime.Serialization.Json.JsonDataContract
                {
                    /*0x18*/ System.Runtime.Serialization.Json.JsonCollectionDataContract.JsonCollectionDataContractCriticalHelper helper;

                    /*0x75f34fc*/ JsonCollectionDataContract(System.Runtime.Serialization.CollectionDataContract traditionalDataContract);
                    /*0x75f366c*/ System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate get_JsonFormatReaderDelegate();
                    /*0x75f385c*/ System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate get_JsonFormatGetOnlyReaderDelegate();
                    /*0x75f3bc4*/ System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate get_JsonFormatWriterDelegate();
                    /*0x75f3840*/ System.Runtime.Serialization.CollectionDataContract get_TraditionalCollectionDataContract();
                    /*0x75f3d44*/ object ReadJsonValueCore(System.Runtime.Serialization.XmlReaderDelegator jsonReader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context);
                    /*0x75f3f04*/ void WriteJsonValueCore(System.Runtime.Serialization.XmlWriterDelegator jsonWriter, object obj, System.Runtime.Serialization.Json.XmlObjectSerializerWriteContextComplexJson context, System.RuntimeTypeHandle declaredTypeHandle);

                    class JsonCollectionDataContractCriticalHelper : System.Runtime.Serialization.Json.JsonDataContract.JsonDataContractCriticalHelper
                    {
                        /*0x28*/ System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate jsonFormatReaderDelegate;
                        /*0x30*/ System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate jsonFormatGetOnlyReaderDelegate;
                        /*0x38*/ System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate jsonFormatWriterDelegate;
                        /*0x40*/ System.Runtime.Serialization.CollectionDataContract traditionalCollectionDataContract;

                        /*0x75f35f8*/ JsonCollectionDataContractCriticalHelper(System.Runtime.Serialization.CollectionDataContract traditionalDataContract);
                        /*0x75f3f80*/ System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate get_JsonFormatReaderDelegate();
                        /*0x75f3f88*/ void set_JsonFormatReaderDelegate(System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate value);
                        /*0x75f3f90*/ System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate get_JsonFormatGetOnlyReaderDelegate();
                        /*0x75f3f98*/ void set_JsonFormatGetOnlyReaderDelegate(System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate value);
                        /*0x75f3fa0*/ System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate get_JsonFormatWriterDelegate();
                        /*0x75f3fa8*/ void set_JsonFormatWriterDelegate(System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate value);
                        /*0x75f3fb0*/ System.Runtime.Serialization.CollectionDataContract get_TraditionalCollectionDataContract();
                    }
                }

                class JsonDataContract
                {
                    /*0x10*/ System.Runtime.Serialization.Json.JsonDataContract.JsonDataContractCriticalHelper helper;

                    static /*0x75f1b8c*/ System.Runtime.Serialization.Json.JsonDataContract GetJsonDataContract(System.Runtime.Serialization.DataContract traditionalDataContract);
                    static /*0x75f2934*/ object HandleReadValue(object obj, System.Runtime.Serialization.XmlObjectSerializerReadContext context);
                    static /*0x75f2870*/ bool TryReadNullAtTopLevel(System.Runtime.Serialization.XmlReaderDelegator reader);
                    /*0x75f2778*/ JsonDataContract(System.Runtime.Serialization.DataContract traditionalDataContract);
                    /*0x75f2b70*/ JsonDataContract(System.Runtime.Serialization.Json.JsonDataContract.JsonDataContractCriticalHelper helper);
                    /*0x75f3fb8*/ string get_TypeName();
                    /*0x75f3fc0*/ System.Runtime.Serialization.Json.JsonDataContract.JsonDataContractCriticalHelper get_Helper();
                    /*0x75f3ba8*/ System.Runtime.Serialization.DataContract get_TraditionalDataContract();
                    /*0x75f3fc8*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> get_KnownDataContracts();
                    /*0x75f1be0*/ object ReadJsonValue(System.Runtime.Serialization.XmlReaderDelegator jsonReader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context);
                    /*0x75f4188*/ object ReadJsonValueCore(System.Runtime.Serialization.XmlReaderDelegator jsonReader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context);
                    /*0x75f1cb4*/ void WriteJsonValue(System.Runtime.Serialization.XmlWriterDelegator jsonWriter, object obj, System.Runtime.Serialization.Json.XmlObjectSerializerWriteContextComplexJson context, System.RuntimeTypeHandle declaredTypeHandle);
                    /*0x75f41b0*/ void WriteJsonValueCore(System.Runtime.Serialization.XmlWriterDelegator jsonWriter, object obj, System.Runtime.Serialization.Json.XmlObjectSerializerWriteContextComplexJson context, System.RuntimeTypeHandle declaredTypeHandle);
                    /*0x75f4154*/ void PopKnownDataContracts(System.Runtime.Serialization.XmlObjectSerializerContext context);
                    /*0x75f411c*/ void PushKnownDataContracts(System.Runtime.Serialization.XmlObjectSerializerContext context);

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

                        static /*0x75f5510*/ JsonDataContractCriticalHelper();
                        static /*0x75f3fe4*/ System.Runtime.Serialization.Json.JsonDataContract GetJsonDataContract(System.Runtime.Serialization.DataContract traditionalDataContract);
                        static /*0x75f46b0*/ int GetId(System.RuntimeTypeHandle typeHandle);
                        static /*0x75f4abc*/ System.Runtime.Serialization.Json.JsonDataContract CreateJsonDataContract(int id, System.Runtime.Serialization.DataContract traditionalDataContract);
                        /*0x75f30cc*/ JsonDataContractCriticalHelper(System.Runtime.Serialization.DataContract traditionalDataContract);
                        /*0x75f4698*/ System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.Runtime.Serialization.DataContract> get_KnownDataContracts();
                        /*0x75f46a0*/ System.Runtime.Serialization.DataContract get_TraditionalDataContract();
                        /*0x75f46a8*/ string get_TypeName();
                        /*0x75f41d8*/ void AddCollectionItemContractsToKnownDataContracts();
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

                    static /*0x75f6b50*/ JsonEncodingStreamWrapper();
                    static /*0x75f6424*/ System.Text.Encoding GetEncoding(System.Runtime.Serialization.Json.JsonEncodingStreamWrapper.SupportedEncoding e);
                    static /*0x75f6528*/ string GetEncodingName(System.Runtime.Serialization.Json.JsonEncodingStreamWrapper.SupportedEncoding enc);
                    static /*0x75f65d8*/ System.Runtime.Serialization.Json.JsonEncodingStreamWrapper.SupportedEncoding GetSupportedEncoding(System.Text.Encoding encoding);
                    static /*0x75f678c*/ System.Runtime.Serialization.Json.JsonEncodingStreamWrapper.SupportedEncoding ReadEncoding(byte b1, byte b2);
                    static /*0x75f6800*/ void ThrowExpectedEncodingMismatch(System.Runtime.Serialization.Json.JsonEncodingStreamWrapper.SupportedEncoding expEnc, System.Runtime.Serialization.Json.JsonEncodingStreamWrapper.SupportedEncoding actualEnc);
                    /*0x75f56c8*/ JsonEncodingStreamWrapper(System.IO.Stream stream, System.Text.Encoding encoding, bool isReader);
                    /*0x75f5ba8*/ bool get_CanRead();
                    /*0x75f5bdc*/ bool get_CanSeek();
                    /*0x75f5be4*/ bool get_CanTimeout();
                    /*0x75f5c04*/ bool get_CanWrite();
                    /*0x75f5c38*/ long get_Length();
                    /*0x75f5c58*/ long get_Position();
                    /*0x75f5c90*/ void set_Position(long value);
                    /*0x75f5cc8*/ int get_ReadTimeout();
                    /*0x75f5cec*/ void set_ReadTimeout(int value);
                    /*0x75f5d10*/ int get_WriteTimeout();
                    /*0x75f5d34*/ void set_WriteTimeout(int value);
                    /*0x75f5d58*/ void Close();
                    /*0x75f5d9c*/ void Flush();
                    /*0x75f5dc0*/ int Read(byte[] buffer, int offset, int count);
                    /*0x75f61b8*/ int ReadByte();
                    /*0x75f623c*/ long Seek(long offset, System.IO.SeekOrigin origin);
                    /*0x75f6274*/ void SetLength(long value);
                    /*0x75f62ac*/ void Write(byte[] buffer, int offset, int count);
                    /*0x75f63c0*/ void WriteByte(byte b);
                    /*0x75f600c*/ void CleanupCharBreak();
                    /*0x75f68e8*/ void EnsureBuffers();
                    /*0x75f695c*/ void EnsureByteBuffer();
                    /*0x75f69c8*/ void FillBuffer(int count);
                    /*0x75f57e4*/ void InitForReading(System.IO.Stream inputStream, System.Text.Encoding expectedEncoding);
                    /*0x75f5a5c*/ void InitForWriting(System.IO.Stream outputStream, System.Text.Encoding writeEncoding);
                    /*0x75f6a38*/ System.Runtime.Serialization.Json.JsonEncodingStreamWrapper.SupportedEncoding ReadEncoding();

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

                    /*0x75f6cf0*/ JsonEnumDataContract(System.Runtime.Serialization.EnumDataContract traditionalDataContract);
                    /*0x75f6e64*/ bool get_IsULong();
                    /*0x75f6e80*/ object ReadJsonValueCore(System.Runtime.Serialization.XmlReaderDelegator jsonReader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context);
                    /*0x75f6f70*/ void WriteJsonValueCore(System.Runtime.Serialization.XmlWriterDelegator jsonWriter, object obj, System.Runtime.Serialization.Json.XmlObjectSerializerWriteContextComplexJson context, System.RuntimeTypeHandle declaredTypeHandle);

                    class JsonEnumDataContractCriticalHelper : System.Runtime.Serialization.Json.JsonDataContract.JsonDataContractCriticalHelper
                    {
                        /*0x28*/ bool isULong;

                        /*0x75f6ddc*/ JsonEnumDataContractCriticalHelper(System.Runtime.Serialization.EnumDataContract traditionalEnumDataContract);
                        /*0x75f7100*/ bool get_IsULong();
                    }
                }

                class JsonFormatClassReaderDelegate : System.MulticastDelegate
                {
                    /*0x75f7108*/ JsonFormatClassReaderDelegate(object object, nint method);
                    /*0x75f7214*/ object Invoke(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context, System.Xml.XmlDictionaryString emptyDictionaryString, System.Xml.XmlDictionaryString[] memberNames);
                }

                class JsonFormatCollectionReaderDelegate : System.MulticastDelegate
                {
                    /*0x75f7228*/ JsonFormatCollectionReaderDelegate(object object, nint method);
                    /*0x75f7334*/ object Invoke(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context, System.Xml.XmlDictionaryString emptyDictionaryString, System.Xml.XmlDictionaryString itemName, System.Runtime.Serialization.CollectionDataContract collectionContract);
                }

                class JsonFormatGetOnlyCollectionReaderDelegate : System.MulticastDelegate
                {
                    /*0x75f7348*/ JsonFormatGetOnlyCollectionReaderDelegate(object object, nint method);
                    /*0x75f7454*/ void Invoke(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context, System.Xml.XmlDictionaryString emptyDictionaryString, System.Xml.XmlDictionaryString itemName, System.Runtime.Serialization.CollectionDataContract collectionContract);
                }

                class JsonFormatReaderGenerator
                {
                    /*0x10*/ System.Runtime.Serialization.Json.JsonFormatReaderGenerator.CriticalHelper helper;

                    /*0x75f7468*/ JsonFormatReaderGenerator();
                    /*0x75f74dc*/ System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate GenerateClassReader(System.Runtime.Serialization.ClassDataContract classContract);
                    /*0x75f7754*/ System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate GenerateCollectionReader(System.Runtime.Serialization.CollectionDataContract collectionContract);
                    /*0x75f79c0*/ System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate GenerateGetOnlyCollectionReader(System.Runtime.Serialization.CollectionDataContract collectionContract);

                    class CriticalHelper
                    {
                        /*0x75f74d4*/ CriticalHelper();
                        /*0x75f769c*/ System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate GenerateClassReader(System.Runtime.Serialization.ClassDataContract classContract);
                        /*0x75f7908*/ System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate GenerateCollectionReader(System.Runtime.Serialization.CollectionDataContract collectionContract);
                        /*0x75f7b80*/ System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate GenerateGetOnlyCollectionReader(System.Runtime.Serialization.CollectionDataContract collectionContract);

                        class <>c__DisplayClass0_0
                        {
                            /*0x10*/ System.Runtime.Serialization.ClassDataContract classContract;

                            /*0x75f7c38*/ <>c__DisplayClass0_0();
                            /*0x75f7c50*/ object <GenerateClassReader>b__0(System.Runtime.Serialization.XmlReaderDelegator xr, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson ctx, System.Xml.XmlDictionaryString emptyDictionaryString, System.Xml.XmlDictionaryString[] memberNames);
                        }

                        class <>c__DisplayClass1_0
                        {
                            /*0x10*/ System.Runtime.Serialization.CollectionDataContract collectionContract;

                            /*0x75f7c40*/ <>c__DisplayClass1_0();
                            /*0x75f8038*/ object <GenerateCollectionReader>b__0(System.Runtime.Serialization.XmlReaderDelegator xr, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson ctx, System.Xml.XmlDictionaryString emptyDS, System.Xml.XmlDictionaryString inm, System.Runtime.Serialization.CollectionDataContract cc);
                        }

                        class <>c__DisplayClass2_0
                        {
                            /*0x10*/ System.Runtime.Serialization.CollectionDataContract collectionContract;

                            /*0x75f7c48*/ <>c__DisplayClass2_0();
                            /*0x75f81ac*/ void <GenerateGetOnlyCollectionReader>b__0(System.Runtime.Serialization.XmlReaderDelegator xr, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson ctx, System.Xml.XmlDictionaryString emptyDS, System.Xml.XmlDictionaryString inm, System.Runtime.Serialization.CollectionDataContract cc);
                        }
                    }
                }

                class JsonFormatClassWriterDelegate : System.MulticastDelegate
                {
                    /*0x75f82e0*/ JsonFormatClassWriterDelegate(object object, nint method);
                    /*0x75f83ec*/ void Invoke(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.Json.XmlObjectSerializerWriteContextComplexJson context, System.Runtime.Serialization.ClassDataContract dataContract, System.Xml.XmlDictionaryString[] memberNames);
                }

                class JsonFormatCollectionWriterDelegate : System.MulticastDelegate
                {
                    /*0x75f8400*/ JsonFormatCollectionWriterDelegate(object object, nint method);
                    /*0x75f850c*/ void Invoke(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.Json.XmlObjectSerializerWriteContextComplexJson context, System.Runtime.Serialization.CollectionDataContract dataContract);
                }

                class JsonFormatWriterGenerator
                {
                    /*0x10*/ System.Runtime.Serialization.Json.JsonFormatWriterGenerator.CriticalHelper helper;

                    /*0x75f8520*/ JsonFormatWriterGenerator();
                    /*0x75f8594*/ System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate GenerateClassWriter(System.Runtime.Serialization.ClassDataContract classContract);
                    /*0x75f880c*/ System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate GenerateCollectionWriter(System.Runtime.Serialization.CollectionDataContract collectionContract);

                    class CriticalHelper
                    {
                        /*0x75f858c*/ CriticalHelper();
                        /*0x75f8754*/ System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate GenerateClassWriter(System.Runtime.Serialization.ClassDataContract classContract);
                        /*0x75f89cc*/ System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate GenerateCollectionWriter(System.Runtime.Serialization.CollectionDataContract collectionContract);

                        class <>c__DisplayClass0_0
                        {
                            /*0x10*/ System.Runtime.Serialization.ClassDataContract classContract;

                            /*0x75f8a84*/ <>c__DisplayClass0_0();
                            /*0x75f8a94*/ void <GenerateClassWriter>b__0(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.Json.XmlObjectSerializerWriteContextComplexJson context, System.Runtime.Serialization.ClassDataContract dataContract, System.Xml.XmlDictionaryString[] memberNames);
                        }

                        class <>c__DisplayClass1_0
                        {
                            /*0x10*/ System.Runtime.Serialization.CollectionDataContract collectionContract;

                            /*0x75f8a8c*/ <>c__DisplayClass1_0();
                            /*0x75f8c54*/ void <GenerateCollectionWriter>b__0(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.Json.XmlObjectSerializerWriteContextComplexJson context, System.Runtime.Serialization.CollectionDataContract dataContract);
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

                    static /*0x75f8df0*/ JsonGlobals();
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
                    static /*0x75f93d4*/ object ParseJsonNumber(string value, ref System.TypeCode objectTypeCode);
                    static /*0x75f9348*/ object ParseJsonNumber(string value);
                    /*0x75f9054*/ JsonObjectDataContract(System.Runtime.Serialization.DataContract traditionalDataContract);
                    /*0x75f905c*/ object ReadJsonValueCore(System.Runtime.Serialization.XmlReaderDelegator jsonReader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context);
                    /*0x75f9360*/ void WriteJsonValueCore(System.Runtime.Serialization.XmlWriterDelegator jsonWriter, object obj, System.Runtime.Serialization.Json.XmlObjectSerializerWriteContextComplexJson context, System.RuntimeTypeHandle declaredTypeHandle);
                }

                class JsonQNameDataContract : System.Runtime.Serialization.Json.JsonDataContract
                {
                    /*0x75f9718*/ JsonQNameDataContract(System.Runtime.Serialization.QNameDataContract traditionalQNameDataContract);
                    /*0x75f9720*/ object ReadJsonValueCore(System.Runtime.Serialization.XmlReaderDelegator jsonReader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context);
                }

                class JsonReaderDelegator : System.Runtime.Serialization.XmlReaderDelegator
                {
                    /*0x28*/ System.Runtime.Serialization.DateTimeFormat dateTimeFormat;
                    /*0x30*/ System.Runtime.Serialization.Json.JsonReaderDelegator.DateTimeArrayJsonHelperWithString dateTimeArrayHelper;

                    static /*0x75f98cc*/ System.Xml.XmlQualifiedName ParseQualifiedName(string qname);
                    static /*0x75f9e0c*/ System.DateTime ParseJsonDate(string originalDateTimeValue, System.Runtime.Serialization.DateTimeFormat dateTimeFormat);
                    static /*0x75f9e9c*/ System.DateTime ParseJsonDateInDefaultFormat(string originalDateTimeValue);
                    /*0x75f9794*/ JsonReaderDelegator(System.Xml.XmlReader reader);
                    /*0x75f979c*/ JsonReaderDelegator(System.Xml.XmlReader reader, System.Runtime.Serialization.DateTimeFormat dateTimeFormat);
                    /*0x75f97cc*/ System.Xml.XmlDictionaryReaderQuotas get_ReaderQuotas();
                    /*0x75f97e8*/ System.Runtime.Serialization.Json.JsonReaderDelegator.DateTimeArrayJsonHelperWithString get_DateTimeArrayHelper();
                    /*0x75f99d0*/ char ReadContentAsChar();
                    /*0x75f9a3c*/ System.Xml.XmlQualifiedName ReadContentAsQName();
                    /*0x75f9a50*/ char ReadElementContentAsChar();
                    /*0x75f9abc*/ byte[] ReadContentAsBase64();
                    /*0x75f9c38*/ byte[] ReadElementContentAsBase64();
                    /*0x75f9df0*/ System.DateTime ReadContentAsDateTime();
                    /*0x75fa32c*/ System.DateTime ReadElementContentAsDateTime();
                    /*0x75fa348*/ bool TryReadJsonDateTimeArray(System.Runtime.Serialization.XmlObjectSerializerReadContext context, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace, int arrayLength, ref System.DateTime[] array);
                    /*0x75fa4a0*/ ulong ReadContentAsUnsignedLong();
                    /*0x75fa6b8*/ ulong ReadElementContentAsUnsignedLong();

                    class DateTimeArrayJsonHelperWithString : System.Xml.ArrayHelper<string, System.DateTime>
                    {
                        /*0x10*/ System.Runtime.Serialization.DateTimeFormat dateTimeFormat;

                        /*0x75f9868*/ DateTimeArrayJsonHelperWithString(System.Runtime.Serialization.DateTimeFormat dateTimeFormat);
                        /*0x75fa944*/ int ReadArray(System.Xml.XmlDictionaryReader reader, string localName, string namespaceUri, System.DateTime[] array, int offset, int count);
                        /*0x75face4*/ void WriteArray(System.Xml.XmlDictionaryWriter writer, string prefix, string localName, string namespaceUri, System.DateTime[] array, int offset, int count);
                    }
                }

                class JsonReaderWriterFactory
                {
                    static /*0x75fad2c*/ System.Xml.XmlDictionaryReader CreateJsonReader(System.IO.Stream stream, System.Xml.XmlDictionaryReaderQuotas quotas);
                    static /*0x75fad3c*/ System.Xml.XmlDictionaryReader CreateJsonReader(System.IO.Stream stream, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose onClose);
                    static /*0x75faf18*/ System.Xml.XmlDictionaryWriter CreateJsonWriter(System.IO.Stream stream, System.Text.Encoding encoding, bool ownsStream);
                    static /*0x75faf24*/ System.Xml.XmlDictionaryWriter CreateJsonWriter(System.IO.Stream stream, System.Text.Encoding encoding, bool ownsStream, bool indent);
                    static /*0x75faf94*/ System.Xml.XmlDictionaryWriter CreateJsonWriter(System.IO.Stream stream, System.Text.Encoding encoding, bool ownsStream, bool indent, string indentChars);
                }

                class JsonStringDataContract : System.Runtime.Serialization.Json.JsonDataContract
                {
                    /*0x75fb288*/ JsonStringDataContract(System.Runtime.Serialization.StringDataContract traditionalStringDataContract);
                    /*0x75fb290*/ object ReadJsonValueCore(System.Runtime.Serialization.XmlReaderDelegator jsonReader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context);
                }

                class JsonUriDataContract : System.Runtime.Serialization.Json.JsonDataContract
                {
                    /*0x75fb304*/ JsonUriDataContract(System.Runtime.Serialization.UriDataContract traditionalUriDataContract);
                    /*0x75fb30c*/ object ReadJsonValueCore(System.Runtime.Serialization.XmlReaderDelegator jsonReader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context);
                }

                class JsonWriterDelegator : System.Runtime.Serialization.XmlWriterDelegator
                {
                    /*0x28*/ System.Runtime.Serialization.DateTimeFormat dateTimeFormat;

                    /*0x75fb380*/ JsonWriterDelegator(System.Xml.XmlWriter writer);
                    /*0x75fb388*/ JsonWriterDelegator(System.Xml.XmlWriter writer, System.Runtime.Serialization.DateTimeFormat dateTimeFormat);
                    /*0x75fb3b8*/ void WriteChar(char value);
                    /*0x75fb42c*/ void WriteBase64(byte[] bytes);
                    /*0x75fb4b8*/ void WriteQName(System.Xml.XmlQualifiedName value);
                    /*0x75fb5ac*/ void WriteUnsignedLong(ulong value);
                    /*0x75fb630*/ void WriteDecimal(decimal value);
                    /*0x75fb6c0*/ void WriteDouble(double value);
                    /*0x75fb748*/ void WriteFloat(float value);
                    /*0x75fb7d0*/ void WriteLong(long value);
                    /*0x75fb850*/ void WriteSignedByte(sbyte value);
                    /*0x75fb8d0*/ void WriteUnsignedInt(uint value);
                    /*0x75fb950*/ void WriteUnsignedShort(ushort value);
                    /*0x75fb9d0*/ void WriteUnsignedByte(byte value);
                    /*0x75fba50*/ void WriteShort(short value);
                    /*0x75fbad0*/ void WriteBoolean(bool value);
                    /*0x75fbb50*/ void WriteInt(int value);
                    /*0x75fbbd0*/ void WriteJsonBooleanArray(bool[] value, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace);
                    /*0x75fbc58*/ void WriteJsonDateTimeArray(System.DateTime[] value, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace);
                    /*0x75fbce0*/ void WriteJsonDecimalArray(decimal[] value, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace);
                    /*0x75fbd6c*/ void WriteJsonInt32Array(int[] value, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace);
                    /*0x75fbdf4*/ void WriteJsonInt64Array(long[] value, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace);
                    /*0x75fbe7c*/ void WriteDateTime(System.DateTime value);
                    /*0x75fbf38*/ void WriteDateTimeInDefaultFormat(System.DateTime value);
                    /*0x75fc550*/ void WriteJsonSingleArray(float[] value, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace);
                    /*0x75fc5d8*/ void WriteJsonDoubleArray(double[] value, System.Xml.XmlDictionaryString itemName, System.Xml.XmlDictionaryString itemNamespace);
                    /*0x75fc660*/ void WriteStartElement(string prefix, string localName, string ns);
                }

                class JsonXmlDataContract : System.Runtime.Serialization.Json.JsonDataContract
                {
                    /*0x75fc710*/ JsonXmlDataContract(System.Runtime.Serialization.XmlDataContract traditionalXmlDataContract);
                    /*0x75fc718*/ object ReadJsonValueCore(System.Runtime.Serialization.XmlReaderDelegator jsonReader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context);
                    /*0x75fccec*/ void WriteJsonValueCore(System.Runtime.Serialization.XmlWriterDelegator jsonWriter, object obj, System.Runtime.Serialization.Json.XmlObjectSerializerWriteContextComplexJson context, System.RuntimeTypeHandle declaredTypeHandle);
                    /*0x75fc914*/ System.Collections.Generic.List<System.Type> GetKnownTypesFromContext(System.Runtime.Serialization.XmlObjectSerializerContext context, System.Collections.Generic.IList<System.Type> serializerKnownTypeList);
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

                    static /*0x7600a8c*/ XmlJsonReader();
                    static /*0x75faa98*/ void CheckArray(System.Array array, int offset, int count);
                    static /*0x75ff9a0*/ int BreakText(byte[] buffer, int offset, int length);
                    static /*0x75ffa54*/ int ComputeNumericalTextLength(byte[] buffer, int offset, int offsetMax);
                    static /*0x75ffb5c*/ int ComputeQuotedTextLengthUntilEndQuote(byte[] buffer, int offset, int offsetMax, ref bool escaped);
                    static /*0x75ff184*/ bool IsWhitespace(byte ch);
                    static /*0x75ffca0*/ char ParseChar(string value, System.Globalization.NumberStyles style);
                    static /*0x75ff39c*/ int ParseInt(string value, System.Globalization.NumberStyles style);
                    /*0x75fadcc*/ XmlJsonReader();
                    /*0x75fce7c*/ string get_Value();
                    /*0x75fcf0c*/ bool get_IsAttributeValue();
                    /*0x75fd3f0*/ bool get_IsReadingCollection();
                    /*0x75fd43c*/ bool get_IsReadingComplexText();
                    /*0x75fd470*/ void Close();
                    /*0x75fd60c*/ string GetAttribute(int index);
                    /*0x75fd62c*/ string GetAttribute(string localName, string namespaceUri);
                    /*0x75fd6c4*/ string GetAttribute(string name);
                    /*0x75fd754*/ bool Read();
                    /*0x75ff1b0*/ decimal ReadContentAsDecimal();
                    /*0x75ff328*/ int ReadContentAsInt();
                    /*0x75ff4c4*/ long ReadContentAsLong();
                    /*0x75ff5f8*/ int ReadValueChunk(char[] chars, int offset, int count);
                    /*0x75fae2c*/ void SetInput(System.IO.Stream stream, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose onClose);
                    /*0x75ffdf8*/ void BufferElement();
                    /*0x75fef9c*/ void EnterJsonScope(System.Runtime.Serialization.Json.JsonNodeType currentNodeType);
                    /*0x75fe5d0*/ System.Runtime.Serialization.Json.JsonNodeType ExitJsonScope();
                    /*0x75fe618*/ void MoveToEndElement();
                    /*0x75ff95c*/ void MoveToInitial(System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose onClose);
                    /*0x75fff0c*/ void ParseAndSetLocalName();
                    /*0x75ff08c*/ void ParseStartElement();
                    /*0x76002cc*/ void ReadAttributes();
                    /*0x75fe848*/ void ReadEscapedCharacter(bool moveToText);
                    /*0x75fe634*/ void ReadNonExistentElementName(System.Xml.StringHandleConstStringType elementName);
                    /*0x7600984*/ int ReadNonFFFE();
                    /*0x75fe6cc*/ void ReadNumericalText();
                    /*0x75fed78*/ void ReadQuotedText(bool moveToText);
                    /*0x7600618*/ void ReadServerTypeAttribute(bool consumedObjectChar);
                    /*0x75fd574*/ void ResetState();
                    /*0x760011c*/ void SetJsonNameWithMapping(System.Xml.XmlBaseReader.XmlElementNode elementNode);
                    /*0x7600224*/ void SkipExpectedByteInBufferReader(byte characterToSkip);
                    /*0x75fe494*/ void SkipWhitespaceInBufferReader();
                    /*0x75fe554*/ bool TryGetByte(ref byte ch);
                    /*0x75fcfa0*/ string UnescapeJsonString(string val);

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

                    static /*0x7600bb0*/ char[] GetCharacterAbbrevs();
                    static /*0x7600cac*/ bool TryEscapeControlCharacter(char ch, ref char abbrev);
                    static /*0x7600dbc*/ System.Text.BinHexEncoding get_BinHexEncoding();
                    static /*0x7604eb0*/ bool CharacterNeedsEscaping(char ch);
                    static /*0x7600fbc*/ void ThrowClosed();
                    static /*0x7605000*/ bool IsUnicodeNewlineCharacter(char c);
                    /*0x75fb02c*/ XmlJsonWriter(bool indent, string indentChars);
                    /*0x7600d1c*/ System.Xml.WriteState get_WriteState();
                    /*0x7600dac*/ string get_XmlLang();
                    /*0x7600db4*/ System.Xml.XmlSpace get_XmlSpace();
                    /*0x7600d7c*/ bool get_HasOpenAttribute();
                    /*0x7600e64*/ bool get_IsClosed();
                    /*0x7600e88*/ bool get_IsWritingCollection();
                    /*0x7600e58*/ bool get_IsWritingNameAttribute();
                    /*0x7600ed4*/ bool get_IsWritingNameWithMapping();
                    /*0x7600ee0*/ bool get_WrittenNameWithMapping();
                    /*0x7600eec*/ void Close();
                    /*0x7600f7c*/ void Flush();
                    /*0x7601024*/ string LookupPrefix(string ns);
                    /*0x75fb118*/ void SetOutput(System.IO.Stream stream, System.Text.Encoding encoding, bool ownsStream);
                    /*0x7601194*/ void WriteArray(string prefix, string localName, string namespaceUri, bool[] array, int offset, int count);
                    /*0x76011fc*/ void WriteArray(string prefix, string localName, string namespaceUri, short[] array, int offset, int count);
                    /*0x7601264*/ void WriteArray(string prefix, string localName, string namespaceUri, int[] array, int offset, int count);
                    /*0x76012cc*/ void WriteArray(string prefix, string localName, string namespaceUri, long[] array, int offset, int count);
                    /*0x7601334*/ void WriteArray(string prefix, string localName, string namespaceUri, float[] array, int offset, int count);
                    /*0x760139c*/ void WriteArray(string prefix, string localName, string namespaceUri, double[] array, int offset, int count);
                    /*0x7601404*/ void WriteArray(string prefix, string localName, string namespaceUri, decimal[] array, int offset, int count);
                    /*0x760146c*/ void WriteArray(string prefix, string localName, string namespaceUri, System.DateTime[] array, int offset, int count);
                    /*0x76014d4*/ void WriteArray(string prefix, string localName, string namespaceUri, System.Guid[] array, int offset, int count);
                    /*0x760153c*/ void WriteArray(string prefix, string localName, string namespaceUri, System.TimeSpan[] array, int offset, int count);
                    /*0x76015a4*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, bool[] array, int offset, int count);
                    /*0x760160c*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, decimal[] array, int offset, int count);
                    /*0x7601674*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, double[] array, int offset, int count);
                    /*0x76016dc*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, float[] array, int offset, int count);
                    /*0x7601744*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, int[] array, int offset, int count);
                    /*0x76017ac*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, long[] array, int offset, int count);
                    /*0x7601814*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, short[] array, int offset, int count);
                    /*0x760187c*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.DateTime[] array, int offset, int count);
                    /*0x76018e4*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Guid[] array, int offset, int count);
                    /*0x760194c*/ void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.TimeSpan[] array, int offset, int count);
                    /*0x76019b4*/ void WriteBase64(byte[] buffer, int index, int count);
                    /*0x7601e1c*/ void WriteBinHex(byte[] buffer, int index, int count);
                    /*0x76022c8*/ void WriteCData(string text);
                    /*0x76022d8*/ void WriteCharEntity(char ch);
                    /*0x7602334*/ void WriteChars(char[] buffer, int index, int count);
                    /*0x76024d8*/ void WriteComment(string text);
                    /*0x7602594*/ void WriteDocType(string name, string pubid, string sysid, string subset);
                    /*0x7602650*/ void WriteEndAttribute();
                    /*0x7602d94*/ void WriteEndDocument();
                    /*0x7602df0*/ void WriteEndElement();
                    /*0x7603348*/ void WriteEntityRef(string name);
                    /*0x7603404*/ void WriteFullEndElement();
                    /*0x7603410*/ void WriteProcessingInstruction(string name, string text);
                    /*0x760355c*/ void WriteQualifiedName(string localName, string ns);
                    /*0x76035f4*/ void WriteRaw(string data);
                    /*0x7603604*/ void WriteRaw(char[] buffer, int index, int count);
                    /*0x76037a8*/ void WriteStartAttribute(string prefix, string localName, string ns);
                    /*0x7603f90*/ void WriteStartDocument(bool standalone);
                    /*0x7603f9c*/ void WriteStartDocument();
                    /*0x7604108*/ void WriteStartElement(string prefix, string localName, string ns);
                    /*0x760477c*/ void WriteString(string text);
                    /*0x7604890*/ void WriteSurrogateCharEntity(char lowChar, char highChar);
                    /*0x7604908*/ void WriteValue(bool value);
                    /*0x7604944*/ void WriteValue(decimal value);
                    /*0x7604988*/ void WriteValue(double value);
                    /*0x76049c4*/ void WriteValue(float value);
                    /*0x7604a00*/ void WriteValue(int value);
                    /*0x7604a3c*/ void WriteValue(long value);
                    /*0x7604a78*/ void WriteValue(System.Guid value);
                    /*0x7604abc*/ void WriteValue(System.DateTime value);
                    /*0x7604af8*/ void WriteValue(string value);
                    /*0x7604b08*/ void WriteValue(System.TimeSpan value);
                    /*0x7604b44*/ void WriteWhitespace(string ws);
                    /*0x7604d10*/ void WriteXmlnsAttribute(string prefix, string namespaceUri);
                    /*0x7604de0*/ void WriteXmlnsAttribute(string prefix, System.Xml.XmlDictionaryString namespaceUri);
                    /*0x7604f0c*/ void CheckText(System.Runtime.Serialization.Json.JsonNodeType nextNodeType);
                    /*0x760468c*/ void EnterScope(System.Runtime.Serialization.Json.JsonNodeType currentNodeType);
                    /*0x7603250*/ System.Runtime.Serialization.Json.JsonNodeType ExitScope();
                    /*0x7600b2c*/ void InitializeWriter();
                    /*0x7601b6c*/ void StartText();
                    /*0x7602a30*/ void ThrowIfServerTypeWritten(string dataTypeSpecified);
                    /*0x760502c*/ void ThrowInvalidAttributeContent();
                    /*0x76045f8*/ bool TrySetWritingNameWithMapping(string localName, string ns);
                    /*0x7602ba0*/ void WriteDataTypeServerType();
                    /*0x7601fd8*/ void WriteEscapedJsonString(string str);
                    /*0x76032d0*/ void WriteIndent();
                    /*0x7603298*/ void WriteNewLine();
                    /*0x7602d24*/ void WriteJsonElementName(string localName);
                    /*0x7603328*/ void WriteJsonQuote();
                    /*0x7602c88*/ void WriteServerTypeAttribute();

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
                        /*0x760113c*/ JsonNodeWriter();
                        /*0x7605154*/ void WriteChars(char* chars, int charCount);
                    }
                }

                class XmlObjectSerializerReadContextComplexJson : System.Runtime.Serialization.XmlObjectSerializerReadContextComplex
                {
                    /*0xe8*/ string extensionDataValueType;
                    /*0xf0*/ System.Runtime.Serialization.DateTimeFormat dateTimeFormat;
                    /*0xf8*/ bool useSimpleDictionaryFormat;

                    static /*0x7605a94*/ System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson CreateContext(System.Runtime.Serialization.Json.DataContractJsonSerializer serializer, System.Runtime.Serialization.DataContract rootTypeDataContract);
                    static /*0x7605ee0*/ bool TryGetJsonLocalName(System.Runtime.Serialization.XmlReaderDelegator xmlReader, ref string name);
                    static /*0x7605fc4*/ string GetJsonMemberName(System.Runtime.Serialization.XmlReaderDelegator xmlReader);
                    static /*0x760600c*/ void ThrowMissingRequiredMembers(object obj, System.Xml.XmlDictionaryString[] memberNames, byte[] expectedElements, byte[] requiredElements);
                    static /*0x7606268*/ void ThrowDuplicateMemberException(object obj, System.Xml.XmlDictionaryString[] memberNames, int memberIndex);
                    static /*0x7606260*/ bool IsBitSet(byte[] bytes, int bitIndex);
                    /*0x760515c*/ XmlObjectSerializerReadContextComplexJson(System.Runtime.Serialization.Json.DataContractJsonSerializer serializer, System.Runtime.Serialization.DataContract rootTypeDataContract);
                    /*0x7605250*/ System.Collections.Generic.IList<System.Type> get_SerializerKnownTypeList();
                    /*0x7605258*/ bool get_UseSimpleDictionaryFormat();
                    /*0x7605260*/ void StartReadExtensionDataValue(System.Runtime.Serialization.XmlReaderDelegator xmlReader);
                    /*0x76052c8*/ System.Runtime.Serialization.IDataNode ReadPrimitiveExtensionDataValue(System.Runtime.Serialization.XmlReaderDelegator xmlReader, string dataContractName, string dataContractNamespace);
                    /*0x76054dc*/ System.Runtime.Serialization.IDataNode ReadNumericalPrimitiveExtensionDataValue(System.Runtime.Serialization.XmlReaderDelegator xmlReader);
                    /*0x7605afc*/ int GetArraySize();
                    /*0x7605b04*/ object ReadDataContractValue(System.Runtime.Serialization.DataContract dataContract, System.Runtime.Serialization.XmlReaderDelegator reader);
                    /*0x7605b1c*/ void ReadAttributes(System.Runtime.Serialization.XmlReaderDelegator xmlReader);
                    /*0x7605d3c*/ int GetJsonMemberIndex(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Xml.XmlDictionaryString[] memberNames, int memberIndex, System.Runtime.Serialization.ExtensionDataObject extensionData);
                    /*0x760637c*/ bool IsReadingCollectionExtensionData(System.Runtime.Serialization.XmlReaderDelegator xmlReader);
                    /*0x76063f0*/ bool IsReadingClassExtensionData(System.Runtime.Serialization.XmlReaderDelegator xmlReader);
                    /*0x7606464*/ System.Runtime.Serialization.XmlReaderDelegator CreateReaderDelegatorForReader(System.Xml.XmlReader xmlReader);
                    /*0x76064e0*/ System.Runtime.Serialization.DataContract GetDataContract(System.RuntimeTypeHandle typeHandle, System.Type type);
                    /*0x7606504*/ System.Runtime.Serialization.DataContract GetDataContractSkipValidation(int typeId, System.RuntimeTypeHandle typeHandle, System.Type type);
                    /*0x7606528*/ System.Runtime.Serialization.DataContract GetDataContract(int id, System.RuntimeTypeHandle typeHandle);
                    /*0x760654c*/ System.Runtime.Serialization.DataContract ResolveDataContractFromRootDataContract(System.Xml.XmlQualifiedName typeQName);
                }

                class XmlObjectSerializerWriteContextComplexJson : System.Runtime.Serialization.XmlObjectSerializerWriteContextComplex
                {
                    /*0xf0*/ System.Runtime.Serialization.EmitTypeInformation emitXsiType;
                    /*0xf4*/ bool perCallXsiTypeAlreadyEmitted;
                    /*0xf5*/ bool useSimpleDictionaryFormat;

                    static /*0x760686c*/ System.Runtime.Serialization.Json.XmlObjectSerializerWriteContextComplexJson CreateContext(System.Runtime.Serialization.Json.DataContractJsonSerializer serializer, System.Runtime.Serialization.DataContract rootTypeDataContract);
                    static /*0x7606a04*/ string TruncateDefaultDataContractNamespace(string dataContractNamespace);
                    static /*0x7606b3c*/ bool RequiresJsonTypeInfo(System.Runtime.Serialization.DataContract contract);
                    static /*0x7607040*/ System.Runtime.Serialization.DataContract GetRevisedItemContract(System.Runtime.Serialization.DataContract oldItemContract);
                    static /*0x7607280*/ void WriteJsonNameWithMapping(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Xml.XmlDictionaryString[] memberNames, int index);
                    static /*0x7607e1c*/ void VerifyObjectCompatibilityWithInterface(System.Runtime.Serialization.DataContract contract, object graph, System.Type declaredType);
                    static /*0x7606554*/ System.Runtime.Serialization.DataContract ResolveJsonDataContractFromRootDataContract(System.Runtime.Serialization.XmlObjectSerializerContext context, System.Xml.XmlQualifiedName typeQName, System.Runtime.Serialization.DataContract rootTypeDataContract);
                    /*0x76067b8*/ XmlObjectSerializerWriteContextComplexJson(System.Runtime.Serialization.Json.DataContractJsonSerializer serializer, System.Runtime.Serialization.DataContract rootTypeDataContract);
                    /*0x76068d4*/ System.Collections.Generic.IList<System.Type> get_SerializerKnownTypeList();
                    /*0x76068dc*/ bool get_UseSimpleDictionaryFormat();
                    /*0x76068e4*/ bool WriteClrTypeInfo(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Type dataContractType, string clrTypeName, string clrAssemblyName);
                    /*0x76068ec*/ bool WriteClrTypeInfo(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Runtime.Serialization.DataContract dataContract);
                    /*0x76068f4*/ void WriteArraySize(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, int size);
                    /*0x76068f8*/ void WriteTypeInfo(System.Runtime.Serialization.XmlWriterDelegator writer, string dataContractName, string dataContractNamespace);
                    /*0x76069a0*/ void WriteTypeInfo(System.Runtime.Serialization.XmlWriterDelegator writer, string typeInformation);
                    /*0x7606b98*/ bool WriteTypeInfo(System.Runtime.Serialization.XmlWriterDelegator writer, System.Runtime.Serialization.DataContract contract, System.Runtime.Serialization.DataContract declaredContract);
                    /*0x7606e98*/ void WriteJsonISerializable(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Runtime.Serialization.ISerializable obj);
                    /*0x7607140*/ void WriteDataContractValue(System.Runtime.Serialization.DataContract dataContract, System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.RuntimeTypeHandle declaredTypeHandle);
                    /*0x760721c*/ void WriteNull(System.Runtime.Serialization.XmlWriterDelegator xmlWriter);
                    /*0x7607228*/ System.Xml.XmlDictionaryString get_CollectionItemName();
                    /*0x7607340*/ void WriteExtensionDataTypeInfo(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, System.Runtime.Serialization.IDataNode dataNode);
                    /*0x7607748*/ void SerializeWithXsiType(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.RuntimeTypeHandle objectTypeHandle, System.Type objectType, int declaredTypeID, System.RuntimeTypeHandle declaredTypeHandle, System.Type declaredType);
                    /*0x760790c*/ void HandleCollectionAssignedToObject(System.Type declaredType, ref System.Runtime.Serialization.DataContract dataContract, ref object obj, ref bool verifyKnownType);
                    /*0x760827c*/ void SerializeWithXsiTypeAtTopLevel(System.Runtime.Serialization.DataContract dataContract, System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.RuntimeTypeHandle originalDeclaredTypeHandle, System.Type graphType);
                    /*0x76080a4*/ void VerifyType(System.Runtime.Serialization.DataContract dataContract, System.Type declaredType);
                    /*0x76083c0*/ System.Runtime.Serialization.DataContract GetDataContract(System.RuntimeTypeHandle typeHandle, System.Type type);
                    /*0x76083e4*/ System.Runtime.Serialization.DataContract GetDataContractSkipValidation(int typeId, System.RuntimeTypeHandle typeHandle, System.Type type);
                    /*0x7608408*/ System.Runtime.Serialization.DataContract GetDataContract(int id, System.RuntimeTypeHandle typeHandle);
                    /*0x760842c*/ System.Runtime.Serialization.DataContract ResolveDataContractFromRootDataContract(System.Xml.XmlQualifiedName typeQName);
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

                    /*0x75f7cec*/ JsonFormatReaderInterpreter(System.Runtime.Serialization.ClassDataContract classContract);
                    /*0x75f80e8*/ JsonFormatReaderInterpreter(System.Runtime.Serialization.CollectionDataContract collectionContract, bool isGetOnly);
                    /*0x75f7d1c*/ object ReadFromJson(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context, System.Xml.XmlDictionaryString emptyDictionaryString, System.Xml.XmlDictionaryString[] memberNames);
                    /*0x75f8124*/ object ReadCollectionFromJson(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context, System.Xml.XmlDictionaryString emptyDictionaryString, System.Xml.XmlDictionaryString itemName, System.Runtime.Serialization.CollectionDataContract collectionContract);
                    /*0x75f8260*/ void ReadGetOnlyCollectionFromJson(System.Runtime.Serialization.XmlReaderDelegator xmlReader, System.Runtime.Serialization.Json.XmlObjectSerializerReadContextComplexJson context, System.Xml.XmlDictionaryString emptyDictionaryString, System.Xml.XmlDictionaryString itemName, System.Runtime.Serialization.CollectionDataContract collectionContract);
                    /*0x7608434*/ void CreateObject(System.Runtime.Serialization.ClassDataContract classContract);
                    /*0x7608680*/ void InvokeOnDeserializing(System.Runtime.Serialization.ClassDataContract classContract);
                    /*0x7608b88*/ void InvokeOnDeserialized(System.Runtime.Serialization.ClassDataContract classContract);
                    /*0x760978c*/ bool HasFactoryMethod(System.Runtime.Serialization.ClassDataContract classContract);
                    /*0x7608ce0*/ bool InvokeFactoryMethod(System.Runtime.Serialization.ClassDataContract classContract);
                    /*0x76087d8*/ void ReadISerializable(System.Runtime.Serialization.ClassDataContract classContract);
                    /*0x7608a20*/ void ReadClass(System.Runtime.Serialization.ClassDataContract classContract);
                    /*0x7609814*/ void ReadMembers(System.Runtime.Serialization.ClassDataContract classContract, System.Runtime.Serialization.ExtensionDataObject extensionData);
                    /*0x7609af4*/ int ReadMembers(int index, System.Runtime.Serialization.ClassDataContract classContract, System.Runtime.Serialization.BitFlagsGenerator expectedElements, ref int memberIndex);
                    /*0x7609d00*/ bool CheckRequiredElements(System.Runtime.Serialization.BitFlagsGenerator expectedElements, byte[] requiredElements);
                    /*0x760999c*/ int SetRequiredElements(System.Runtime.Serialization.ClassDataContract contract, byte[] requiredElements);
                    /*0x7609aa4*/ void SetExpectedElements(System.Runtime.Serialization.BitFlagsGenerator expectedElements, int startIndex);
                    /*0x760a338*/ void ResetExpectedElements(System.Runtime.Serialization.BitFlagsGenerator expectedElements, int index);
                    /*0x7609d90*/ object ReadValue(System.Type type, string name);
                    /*0x760a358*/ object InternalDeserialize(System.Type type, string name);
                    /*0x760a544*/ object WrapNullableObject(System.Type innerType, object innerValue, System.Type outerType, int nullables);
                    /*0x7608e08*/ void ReadCollection(System.Runtime.Serialization.CollectionDataContract collectionContract);
                    /*0x760a728*/ void ReadSimpleDictionary(System.Runtime.Serialization.CollectionDataContract collectionContract, System.Type keyValueType);
                    /*0x76094e8*/ void ReadGetOnlyCollection(System.Runtime.Serialization.CollectionDataContract collectionContract);
                    /*0x760ad08*/ bool TryReadPrimitiveArray(System.Type itemType, ref bool readResult);
                    /*0x760b0ac*/ object ReadCollectionItem(System.Runtime.Serialization.CollectionDataContract collectionContract, System.Type itemType);
                    /*0x760b1c0*/ void StoreCollectionValue(object collection, System.Type valueType, object value, System.Runtime.Serialization.CollectionDataContract collectionContract);
                    /*0x760b558*/ void HandleUnexpectedItemInCollection(ref int iterator);
                    /*0x760b090*/ bool IsStartElement(System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns);
                    /*0x760b670*/ bool IsStartElement();
                    /*0x760b530*/ bool IsEndElement();
                    /*0x760b63c*/ void ThrowUnexpectedStateException(System.Xml.XmlNodeType expectedState);
                    /*0x760b5d8*/ void ThrowSerializationException(string msg, object[] values);

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

                    /*0x75f8b48*/ JsonFormatWriterInterpreter(System.Runtime.Serialization.ClassDataContract classContract);
                    /*0x75f8cf8*/ JsonFormatWriterInterpreter(System.Runtime.Serialization.CollectionDataContract collectionContract);
                    /*0x760b68c*/ System.Runtime.Serialization.CollectionDataContract get_collectionDataContract();
                    /*0x75f8b80*/ void WriteToJson(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.Json.XmlObjectSerializerWriteContextComplexJson context, System.Runtime.Serialization.ClassDataContract dataContract, System.Xml.XmlDictionaryString[] memberNames);
                    /*0x75f8d30*/ void WriteCollectionToJson(System.Runtime.Serialization.XmlWriterDelegator xmlWriter, object obj, System.Runtime.Serialization.Json.XmlObjectSerializerWriteContextComplexJson context, System.Runtime.Serialization.CollectionDataContract dataContract);
                    /*0x760b6e8*/ void InitArgs(System.Type objType);
                    /*0x760ce70*/ void InvokeOnSerializing(System.Runtime.Serialization.ClassDataContract classContract, object objSerialized, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                    /*0x760cfd0*/ void InvokeOnSerialized(System.Runtime.Serialization.ClassDataContract classContract, object objSerialized, System.Runtime.Serialization.XmlObjectSerializerWriteContext context);
                    /*0x760b86c*/ void WriteClass(System.Runtime.Serialization.ClassDataContract classContract);
                    /*0x760ba5c*/ void WriteCollection(System.Runtime.Serialization.CollectionDataContract collectionContract);
                    /*0x760d130*/ int WriteMembers(System.Runtime.Serialization.ClassDataContract classContract, System.Runtime.Serialization.ExtensionDataObject extensionData, System.Runtime.Serialization.ClassDataContract derivedMostClassContract);
                    /*0x760e828*/ bool IsDefaultValue(System.Type type, object value);
                    /*0x760e85c*/ object GetDefaultValue(System.Type type);
                    /*0x760dd78*/ void WriteStartElement(object nameLocal, int nameIndex);
                    /*0x760e76c*/ void WriteEndElement();
                    /*0x760d85c*/ void WriteArrayAttribute();
                    /*0x760e788*/ void WriteObjectAttribute();
                    /*0x760de94*/ void WriteValue(System.Type memberType, object memberValue);
                    /*0x760e9ac*/ void InternalSerialize(System.Reflection.MethodInfo methodInfo, System.Func<object> memberValue, System.Type memberType, bool writeXsiType);
                    /*0x760ee14*/ object UnwrapNullableObject(System.Func<object> memberValue, ref System.Type memberType, ref bool isNull);
                    /*0x760d8e0*/ bool TryWritePrimitive(System.Type type, System.Func<object> value, System.Reflection.MemberInfo memberInfo, System.Nullable<int> arrayItemIndex, System.Xml.XmlDictionaryString name, int nameIndex);
                    /*0x760d510*/ bool TryWritePrimitiveArray(System.Type type, System.Type itemType, System.Func<object> value, System.Xml.XmlDictionaryString itemName);
                    /*0x760e7fc*/ object LoadMemberValue(System.Runtime.Serialization.DataMember member);
                    /*0x760f220*/ object <WriteCollection>b__22_0();

                    class <>c__DisplayClass22_0
                    {
                        /*0x10*/ object currentValue;
                        /*0x18*/ System.Func<object> <>9__1;

                        /*0x760f228*/ <>c__DisplayClass22_0();
                        /*0x760f230*/ object <WriteCollection>b__1();
                    }

                    class <>c__DisplayClass23_0
                    {
                        /*0x10*/ object memberValue;

                        /*0x760f238*/ <>c__DisplayClass23_0();
                        /*0x760f240*/ object <WriteMembers>b__0();
                    }

                    class <>c__DisplayClass30_0
                    {
                        /*0x10*/ object memberValue;

                        /*0x760f248*/ <>c__DisplayClass30_0();
                        /*0x760f250*/ object <WriteValue>b__0();
                        /*0x760f258*/ object <WriteValue>b__1();
                        /*0x760f260*/ object <WriteValue>b__2();
                    }
                }
            }

            namespace Diagnostics
            {
                class TraceUtility
                {
                    static /*0x0*/ System.Collections.Generic.Dictionary<int, string> traceCodes;

                    static /*0x760f58c*/ TraceUtility();
                    static /*0x760f268*/ void Trace(System.Diagnostics.TraceEventType severity, int traceCode, string traceDescription);
                    static /*0x760f2d8*/ void Trace(System.Diagnostics.TraceEventType severity, int traceCode, string traceDescription, System.Runtime.Diagnostics.TraceRecord record);
                    static /*0x760f358*/ void Trace(System.Diagnostics.TraceEventType severity, int traceCode, string traceDescription, System.Runtime.Diagnostics.TraceRecord record, System.Exception exception);
                }

                namespace Application
                {
                    class TD
                    {
                        static /*0x0*/ System.Runtime.Diagnostics.EventDescriptor[] eventDescriptors;
                        static /*0x8*/ object syncLock;
                        static /*0x10*/ bool eventDescriptorsCreated;

                        static /*0x7611a9c*/ TD();
                        static /*0x760f93c*/ bool ReaderQuotaExceededIsEnabled();
                        static /*0x760fa8c*/ void ReaderQuotaExceeded(string param0);
                        static /*0x760fc48*/ bool DCSerializeWithSurrogateStartIsEnabled();
                        static /*0x760fcdc*/ void DCSerializeWithSurrogateStart(string SurrogateType);
                        static /*0x760fdb4*/ bool DCSerializeWithSurrogateStopIsEnabled();
                        static /*0x760fe48*/ void DCSerializeWithSurrogateStop();
                        static /*0x760ffec*/ bool DCDeserializeWithSurrogateStartIsEnabled();
                        static /*0x7610080*/ void DCDeserializeWithSurrogateStart(string SurrogateType);
                        static /*0x7610158*/ bool DCDeserializeWithSurrogateStopIsEnabled();
                        static /*0x76101ec*/ void DCDeserializeWithSurrogateStop();
                        static /*0x76102bc*/ bool ImportKnownTypesStartIsEnabled();
                        static /*0x7610350*/ void ImportKnownTypesStart();
                        static /*0x7610420*/ bool ImportKnownTypesStopIsEnabled();
                        static /*0x76104b4*/ void ImportKnownTypesStop();
                        static /*0x7610584*/ bool DCResolverResolveIsEnabled();
                        static /*0x7610618*/ void DCResolverResolve(string TypeName);
                        static /*0x76106f0*/ bool DCGenWriterStartIsEnabled();
                        static /*0x7610784*/ void DCGenWriterStart(string Kind, string TypeName);
                        static /*0x7610958*/ bool DCGenWriterStopIsEnabled();
                        static /*0x76109ec*/ void DCGenWriterStop();
                        static /*0x7610abc*/ bool DCGenReaderStartIsEnabled();
                        static /*0x7610b50*/ void DCGenReaderStart(string Kind, string TypeName);
                        static /*0x7610c38*/ bool DCGenReaderStopIsEnabled();
                        static /*0x7610ccc*/ void DCGenReaderStop();
                        static /*0x7610d9c*/ bool DCJsonGenReaderStartIsEnabled();
                        static /*0x7610e30*/ void DCJsonGenReaderStart(string Kind, string TypeName);
                        static /*0x7610f18*/ bool DCJsonGenReaderStopIsEnabled();
                        static /*0x7610fac*/ void DCJsonGenReaderStop();
                        static /*0x761107c*/ bool DCJsonGenWriterStartIsEnabled();
                        static /*0x7611110*/ void DCJsonGenWriterStart(string Kind, string TypeName);
                        static /*0x76111f8*/ bool DCJsonGenWriterStopIsEnabled();
                        static /*0x761128c*/ void DCJsonGenWriterStop();
                        static /*0x761135c*/ void CreateEventDescriptors();
                        static /*0x7611924*/ void EnsureEventDescriptors();
                        static /*0x760f9d0*/ bool IsEtwEventEnabled(int eventIndex);
                        static /*0x760fb64*/ bool WriteEtwEvent(int eventIndex, System.Runtime.Diagnostics.EventTraceActivity eventParam0, string eventParam1, string eventParam2);
                        static /*0x760ff18*/ bool WriteEtwEvent(int eventIndex, System.Runtime.Diagnostics.EventTraceActivity eventParam0, string eventParam1);
                        static /*0x761086c*/ bool WriteEtwEvent(int eventIndex, System.Runtime.Diagnostics.EventTraceActivity eventParam0, string eventParam1, string eventParam2, string eventParam3);
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
