class <Module>
{
}

namespace EA
{
    namespace Text
    {
        class ByteArrayParser
        {
            /*0x10*/ nint _address;
            /*0x18*/ int _length;
            /*0x1c*/ int _position;
            /*0x20*/ int _endLinePosition;
            /*0x24*/ int _endTrimPosition;

            /*0x2bd8a40*/ ByteArrayParser(nint address, uint length);
            /*0x2bd8a78*/ void SetWidth(int lenght);
            /*0x2bd8a9c*/ bool MoveToNextLine(char nextLineCharacter);
            /*0x2bd8b00*/ byte get_Item(int index);
            /*0x2bd8b14*/ void SelectAll();
            /*0x2bd8b28*/ void SetPosition(int position, int width);
            /*0x2bd8ba4*/ bool IsNullOrEmpty();
            /*0x2bd8bcc*/ int GetLineWidth();
            /*0x2bd8bf0*/ int IndexOf(char toFind, int startIndex);
            /*0x2bd8c50*/ string ToStringUnescape(int startIndex, int length);
            /*0x2bd8f70*/ bool FillFromJsonStringArray(System.Collections.Generic.Dictionary<string, string> dic);
        }

        struct SmallString16 : System.ICloneable, System.IComparable, System.IConvertible, System.Collections.IEnumerable, System.IComparable<string>, System.IComparable<EA.Text.SmallString16>, System.Collections.Generic.IEnumerable<char>, System.IEquatable<string>, System.IEquatable<EA.Text.SmallString16>
        {
            static /*0x0*/ EA.Text.SmallString16 Empty;
            static /*0x10*/ string[] sTempString;
            static /*0x18*/ int sTempStringIndex;
            /*0x10*/ byte Byte0;
            /*0x10*/ EA.Text.SmallString16.<Value> Value;

            static /*0x2bdb3e4*/ SmallString16();
            static /*0x2bda600*/ int CompareNonOrdinal(EA.Text.SmallString16 strA, EA.Text.SmallString16 strB);
            static /*0x2bda864*/ int CompareNonOrdinal(EA.Text.SmallString16 strA, string strB);
            /*0x2bd9124*/ System.TypeCode GetTypeCode();
            /*0x2bd912c*/ bool ToBoolean(System.IFormatProvider provider);
            /*0x2bd9364*/ float ToSingle(System.IFormatProvider provider);
            /*0x2bd93d4*/ decimal ToDecimal(System.IFormatProvider provider);
            /*0x2bd9474*/ char ToChar(System.IFormatProvider provider);
            /*0x2bd94e0*/ short ToInt16(System.IFormatProvider provider);
            /*0x2bd954c*/ ushort ToUInt16(System.IFormatProvider provider);
            /*0x2bd95b8*/ byte ToByte(System.IFormatProvider provider);
            /*0x2bd9654*/ sbyte ToSByte(System.IFormatProvider provider);
            /*0x2bd96f0*/ int ToInt32(System.IFormatProvider provider);
            /*0x2bd975c*/ uint ToUInt32(System.IFormatProvider provider);
            /*0x2bd97c8*/ ulong ToUInt64(System.IFormatProvider provider);
            /*0x2bd9830*/ System.DateTime ToDateTime(System.IFormatProvider provider);
            /*0x2bd98d0*/ string ToString(System.IFormatProvider provider);
            /*0x2bd9928*/ object ToType(System.Type t, System.IFormatProvider provider);
            /*0x2bd9960*/ long ToInt64(System.IFormatProvider provider);
            /*0x2bd9b1c*/ double ToDouble(System.IFormatProvider provider);
            /*0x2bd9d1c*/ int get_Length();
            /*0x2bd9ecc*/ string ToString();
            /*0x2bda0d4*/ byte* GetBytes();
            /*0x2bda0d8*/ string ToTempString();
            /*0x2bda3f4*/ int GetHashCode();
            /*0x2bda57c*/ object Clone();
            /*0x2bdaae8*/ int CompareTo(object obj);
            /*0x2bdafb0*/ int CompareTo(string s);
            /*0x2bdb020*/ int CompareTo(EA.Text.SmallString16 s);
            /*0x2bdb098*/ System.Collections.Generic.IEnumerator<char> System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator();
            /*0x2bdb100*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x2bdb168*/ bool Equals(string str);
            /*0x2bdb300*/ bool Equals(EA.Text.SmallString16 str);
            /*0x2bdb370*/ bool Equals(object o);

            struct <Value>e__FixedBuffer
            {
                /*0x10*/ ulong FixedElementField;
            }
        }

        struct SmallString32 : System.ICloneable, System.IComparable, System.IConvertible, System.Collections.IEnumerable, System.IComparable<string>, System.IComparable<EA.Text.SmallString32>, System.Collections.Generic.IEnumerable<char>, System.IEquatable<string>, System.IEquatable<EA.Text.SmallString32>
        {
            static /*0x0*/ EA.Text.SmallString32 Empty;
            static /*0x20*/ string[] sTempString;
            static /*0x28*/ int sTempStringIndex;
            /*0x10*/ byte Byte0;
            /*0x10*/ EA.Text.SmallString32.<Value> Value;

            static /*0x2bdc970*/ SmallString32();
            static /*0x2bdc214*/ int CompareNonOrdinal(EA.Text.SmallString32 strA, EA.Text.SmallString32 strB);
            static /*0x2bdc364*/ int CompareNonOrdinal(EA.Text.SmallString32 strA, string strB);
            /*0x2bdb614*/ System.TypeCode GetTypeCode();
            /*0x2bdb61c*/ bool ToBoolean(System.IFormatProvider provider);
            /*0x2bdb6f8*/ float ToSingle(System.IFormatProvider provider);
            /*0x2bdb768*/ decimal ToDecimal(System.IFormatProvider provider);
            /*0x2bdb808*/ char ToChar(System.IFormatProvider provider);
            /*0x2bdb874*/ short ToInt16(System.IFormatProvider provider);
            /*0x2bdb8e0*/ ushort ToUInt16(System.IFormatProvider provider);
            /*0x2bdb94c*/ byte ToByte(System.IFormatProvider provider);
            /*0x2bdb9e8*/ sbyte ToSByte(System.IFormatProvider provider);
            /*0x2bdba84*/ int ToInt32(System.IFormatProvider provider);
            /*0x2bdbaf0*/ uint ToUInt32(System.IFormatProvider provider);
            /*0x2bdbb5c*/ ulong ToUInt64(System.IFormatProvider provider);
            /*0x2bdbbc4*/ System.DateTime ToDateTime(System.IFormatProvider provider);
            /*0x2bdbc64*/ string ToString(System.IFormatProvider provider);
            /*0x2bdbcbc*/ object ToType(System.Type t, System.IFormatProvider provider);
            /*0x2bdbcf4*/ long ToInt64(System.IFormatProvider provider);
            /*0x2bdbdd0*/ double ToDouble(System.IFormatProvider provider);
            /*0x2bdbeac*/ int get_Length();
            /*0x2bdbf28*/ string ToString();
            /*0x2bdc008*/ byte* GetBytes();
            /*0x2bdc00c*/ string ToTempString();
            /*0x2bdc114*/ int GetHashCode();
            /*0x2bdc190*/ object Clone();
            /*0x2bdc454*/ int CompareTo(object obj);
            /*0x2bdc540*/ int CompareTo(string s);
            /*0x2bdc5e4*/ int CompareTo(EA.Text.SmallString32 s);
            /*0x2bdc698*/ System.Collections.Generic.IEnumerator<char> System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator();
            /*0x2bdc700*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x2bdc768*/ bool Equals(string str);
            /*0x2bdc854*/ bool Equals(EA.Text.SmallString32 str);
            /*0x2bdc8fc*/ bool Equals(object o);

            struct <Value>e__FixedBuffer
            {
                /*0x10*/ ulong FixedElementField;
            }
        }

        struct SmallString64 : System.ICloneable, System.IComparable, System.IConvertible, System.Collections.IEnumerable, System.IComparable<string>, System.IComparable<EA.Text.SmallString64>, System.Collections.Generic.IEnumerable<char>, System.IEquatable<string>, System.IEquatable<EA.Text.SmallString64>
        {
            static /*0x0*/ EA.Text.SmallString64 Empty;
            static /*0x40*/ string[] sTempString;
            static /*0x48*/ int sTempStringIndex;
            /*0x10*/ byte Byte0;
            /*0x10*/ EA.Text.SmallString64.<Value> Value;

            static /*0x2bde424*/ SmallString64();
            static /*0x2bdd068*/ EA.Text.SmallString64 op_Implicit(string b);
            static /*0x2bddc80*/ int CompareNonOrdinal(EA.Text.SmallString64 strA, EA.Text.SmallString64 strB);
            static /*0x2bdddd0*/ int CompareNonOrdinal(EA.Text.SmallString64 strA, string strB);
            /*0x2bdcba4*/ SmallString64(string str);
            /*0x2bdd004*/ System.TypeCode GetTypeCode();
            /*0x2bdd00c*/ void Clear();
            /*0x2bdd080*/ bool ToBoolean(System.IFormatProvider provider);
            /*0x2bdd15c*/ float ToSingle(System.IFormatProvider provider);
            /*0x2bdd1cc*/ decimal ToDecimal(System.IFormatProvider provider);
            /*0x2bdd26c*/ char ToChar(System.IFormatProvider provider);
            /*0x2bdd2d8*/ short ToInt16(System.IFormatProvider provider);
            /*0x2bdd344*/ ushort ToUInt16(System.IFormatProvider provider);
            /*0x2bdd3b0*/ byte ToByte(System.IFormatProvider provider);
            /*0x2bdd44c*/ sbyte ToSByte(System.IFormatProvider provider);
            /*0x2bdd4e8*/ int ToInt32(System.IFormatProvider provider);
            /*0x2bdd554*/ uint ToUInt32(System.IFormatProvider provider);
            /*0x2bdd5c0*/ ulong ToUInt64(System.IFormatProvider provider);
            /*0x2bdd628*/ System.DateTime ToDateTime(System.IFormatProvider provider);
            /*0x2bdd6c8*/ string ToString(System.IFormatProvider provider);
            /*0x2bdd720*/ object ToType(System.Type t, System.IFormatProvider provider);
            /*0x2bdd758*/ long ToInt64(System.IFormatProvider provider);
            /*0x2bdd834*/ double ToDouble(System.IFormatProvider provider);
            /*0x2bdd910*/ int get_Length();
            /*0x2bdd98c*/ string ToString();
            /*0x2bdda6c*/ byte* GetBytes();
            /*0x2bdda70*/ string ToTempString();
            /*0x2bddb78*/ int GetHashCode();
            /*0x2bddbf4*/ object Clone();
            /*0x2bddec0*/ int CompareTo(object obj);
            /*0x2bddfac*/ int CompareTo(string s);
            /*0x2bde060*/ int CompareTo(EA.Text.SmallString64 s);
            /*0x2bde13c*/ System.Collections.Generic.IEnumerator<char> System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator();
            /*0x2bde1a4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x2bde20c*/ bool Equals(string str);
            /*0x2bde2f8*/ bool Equals(EA.Text.SmallString64 str);
            /*0x2bde3b0*/ bool Equals(object o);

            struct <Value>e__FixedBuffer
            {
                /*0x10*/ ulong FixedElementField;
            }
        }

        struct SmallString8 : System.ICloneable, System.IComparable, System.IConvertible, System.Collections.IEnumerable, System.IComparable<string>, System.IComparable<EA.Text.SmallString8>, System.Collections.Generic.IEnumerable<char>, System.IEquatable<string>, System.IEquatable<EA.Text.SmallString8>
        {
            static /*0x0*/ EA.Text.SmallString8 Empty;
            static /*0x8*/ string[] sTempString;
            static /*0x10*/ int sTempStringIndex;
            /*0x10*/ byte Byte0;
            /*0x10*/ EA.Text.SmallString8.<Value> Value;

            static /*0x2bdf8dc*/ SmallString8();
            static /*0x2bdf234*/ int CompareNonOrdinal(EA.Text.SmallString8 strA, EA.Text.SmallString8 strB);
            static /*0x2bdf384*/ int CompareNonOrdinal(EA.Text.SmallString8 strA, string strB);
            /*0x2bde65c*/ System.TypeCode GetTypeCode();
            /*0x2bde664*/ bool ToBoolean(System.IFormatProvider provider);
            /*0x2bde740*/ float ToSingle(System.IFormatProvider provider);
            /*0x2bde7b0*/ decimal ToDecimal(System.IFormatProvider provider);
            /*0x2bde850*/ char ToChar(System.IFormatProvider provider);
            /*0x2bde8bc*/ short ToInt16(System.IFormatProvider provider);
            /*0x2bde928*/ ushort ToUInt16(System.IFormatProvider provider);
            /*0x2bde994*/ byte ToByte(System.IFormatProvider provider);
            /*0x2bdea30*/ sbyte ToSByte(System.IFormatProvider provider);
            /*0x2bdeacc*/ int ToInt32(System.IFormatProvider provider);
            /*0x2bdeb38*/ uint ToUInt32(System.IFormatProvider provider);
            /*0x2bdeba4*/ ulong ToUInt64(System.IFormatProvider provider);
            /*0x2bdec0c*/ System.DateTime ToDateTime(System.IFormatProvider provider);
            /*0x2bdecac*/ string ToString(System.IFormatProvider provider);
            /*0x2bded04*/ object ToType(System.Type t, System.IFormatProvider provider);
            /*0x2bded3c*/ long ToInt64(System.IFormatProvider provider);
            /*0x2bdee18*/ double ToDouble(System.IFormatProvider provider);
            /*0x2bdeef4*/ int get_Length();
            /*0x2bdef70*/ string ToString();
            /*0x2bdf050*/ byte* GetBytes();
            /*0x2bdf054*/ string ToTempString();
            /*0x2bdf15c*/ int GetHashCode();
            /*0x2bdf1d8*/ object Clone();
            /*0x2bdf478*/ int CompareTo(object obj);
            /*0x2bdf564*/ int CompareTo(string s);
            /*0x2bdf5d0*/ int CompareTo(EA.Text.SmallString8 s);
            /*0x2bdf63c*/ System.Collections.Generic.IEnumerator<char> System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator();
            /*0x2bdf6a4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x2bdf70c*/ bool Equals(string str);
            /*0x2bdf7f8*/ bool Equals(EA.Text.SmallString8 str);
            /*0x2bdf868*/ bool Equals(object o);

            struct <Value>e__FixedBuffer
            {
                /*0x10*/ ulong FixedElementField;
            }
        }

        class SmallStringCommon
        {
            static /*0x0*/ byte[] kNonOrdinvalMap;

            static /*0x2be0778*/ SmallStringCommon();
            static /*0x2bd9208*/ bool ToBoolean(byte* bytes, int length);
            static /*0x2bd9a3c*/ long ToInt64(byte* bytes, int length);
            static /*0x2bd9bf8*/ double ToDouble(byte* bytes, int length);
            static /*0x2bdfb0c*/ int LengthFromValue(ulong v);
            static /*0x2bda774*/ int CompareNonOrdinal(byte* strA, int la, byte* strB, int lb);
            static /*0x2bdfb54*/ int CompareNonOrdinalUtf8(byte* utf8, int la, string strB);
            static /*0x2bda980*/ int CompareNonOrdinal(byte* strA, int la, string strB, bool isUtf8);
            static /*0x2bd9d98*/ int GetLengthBinarySearch(byte* _this, int MaxLength);
            static /*0x2bd9fac*/ string ToString(byte* _this, int length, bool fromUtf8);
            static /*0x2bda1e0*/ string ToTempString(byte* _this, int length, int MaxLength, string[] tempStrings, ref int sTempStringIndex, bool fromUtf8);
            static /*0x2bdb254*/ bool Equals(byte* _this, int length, string value);
            static /*0x2bdcc7c*/ void Concat(byte* dest, int MaxLength, string str0, string str1, bool isUtf8);
            static /*0x2be05c8*/ void Concat(byte* dest, int MaxLength, byte* str0, int l0, byte* str1, int l1);
            static /*0x2bda470*/ int GetHashCode(byte* bytes, int MaxLength);
            static /*0x2be02f8*/ void CopyFrom(byte* _this, int MaxLength, string chars, int startIndex, int length, bool toUtf8);
            static /*0x2be0658*/ ulong HashCombine(ulong v1, ulong v2, ulong seed);
            static /*0x2bdabd4*/ int CompareTo(byte* _this, int length, object obj);
        }

        class StringBuilder
        {
            static string pattern0 = "{0}";
            static string pattern1 = "{1}";
            static string pattern2 = "{2}";
            static int TrimAll = 0;
            static int TrimTail = 1;
            static int TrimHead = 2;
            static /*0x0*/ char[] _charNumbers;
            static /*0x8*/ char[][] s_bool;
            /*0x10*/ char[] _buffer;
            /*0x18*/ int _bufferPos;
            /*0x1c*/ int _charsCapacity;

            static /*0x2be24a0*/ StringBuilder();
            static /*0x2be0818*/ EA.Text.StringBuilder Create(int initialCapacity);
            static /*0x2be1adc*/ int GetIntLength(ulong n);
            /*0x2be0870*/ StringBuilder(int initialCapacity);
            /*0x2be08f4*/ StringBuilder(string value);
            /*0x2be08ec*/ char[] GetBuffer();
            /*0x2be0af8*/ string ToString();
            /*0x2be0b2c*/ string ToString(string hint);
            /*0x2be0c14*/ bool Equals(object obj);
            /*0x2be0c94*/ bool Equals(EA.Text.StringBuilder other);
            /*0x2be0d30*/ char get_Item(int index);
            /*0x2be0d60*/ int get_Length();
            /*0x2be0d68*/ void Wrap(int startIndex, int endIndex);
            /*0x2be0dd0*/ void LoopShift(int startIndex, int endIndex, int shift);
            /*0x2be0e78*/ EA.Text.StringBuilder Clear();
            /*0x2be09b8*/ EA.Text.StringBuilder Append(string value, int startIndex, int count);
            /*0x2be0e80*/ EA.Text.StringBuilder Append(char value);
            /*0x2be0f58*/ EA.Text.StringBuilder Append(bool value);
            /*0x2be0ff8*/ EA.Text.StringBuilder Append(char[] value, int startIndex, int count);
            /*0x2be10e8*/ EA.Text.StringBuilder Append(object value);
            /*0x2be1128*/ EA.Text.StringBuilder Append(System.DateTime value);
            /*0x2be11dc*/ EA.Text.StringBuilder Append(byte value, string format);
            /*0x2be11ec*/ EA.Text.StringBuilder Append(int value, string format);
            /*0x2be1650*/ EA.Text.StringBuilder Append(float valueF, int maxNumberDecimals, int minNumberDecimals, char dotSeparator);
            /*0x2be1ac8*/ EA.Text.StringBuilder Append(long value, string format);
            /*0x2be120c*/ EA.Text.StringBuilder Append(ulong value, bool isNegative, string format);
            /*0x2be1b08*/ bool EndsWith(string value);
            /*0x2be1bd8*/ void EnsureCapacity(int appendLength);
            /*0x2be1c70*/ void ToLower();
            /*0x2be1ccc*/ void ToUpper();
            /*0x2be1d2c*/ EA.Text.StringBuilder ToUpper(System.Globalization.CultureInfo culture);
            /*0x2be1ddc*/ EA.Text.StringBuilder ToUpperInvariant();
            /*0x2be1e3c*/ int GetHashCode();
            /*0x2be1eb0*/ bool CheckIsPattern(string format, int index, string pattern);
            /*0x2be1f70*/ void AppendFormat(string format, object arg0);
            /*0x2be2058*/ void AppendFormat(string format, object arg0, object arg1);
            /*0x2be21ac*/ void AppendFormat(string format, string str0, string str1, string str2);
            /*0x2be2328*/ void AppendLine();
            /*0x2be2330*/ void AppendLine(string value);
            /*0x2be2398*/ void Insert(int index, string value);
            /*0x2be23d0*/ void Insert(int index, char value);
            /*0x2be2400*/ void Remove(int startIndex, int length);
        }

        class DisposableStringBuilder : EA.Text.StringBuilder, System.IDisposable
        {
            /*0x2be276c*/ DisposableStringBuilder();
            /*0x2be2628*/ void Dispose();
        }

        class StringBuilderPool
        {
            static /*0x0*/ System.Collections.Generic.Stack<EA.Text.DisposableStringBuilder> _StringBuilders;
            static /*0x8*/ System.Collections.Concurrent.ConcurrentBag<EA.Text.DisposableStringBuilder> _StringBuildersThreaded;
            static /*0x10*/ System.Threading.Thread sMainThread;

            static /*0x2be293c*/ StringBuilderPool();
            static /*0x2be27c4*/ EA.Text.DisposableStringBuilder Acquire();
            static /*0x2be267c*/ void Release(EA.Text.DisposableStringBuilder sb);
        }

        enum ConversionError
        {
            None = 0,
            Overflow = 1,
            Encoding = 2,
            CodePoint = 3,
        }

        class Unicode
        {
            static /*0x0*/ char[] _chars2;

            static /*0x2be3098*/ Unicode();
            static /*0x2be2a4c*/ bool IsValidCodePoint(int ucs);
            static /*0x2be2a6c*/ bool NotTrailer(byte b);
            static /*0x2be2a7c*/ EA.Text.ConversionError Utf8ToUcs(ref int ucs, byte* buffer, ref int offset, int capacity);
            static /*0x2be2d5c*/ EA.Text.ConversionError Utf16ToUcs(ref int ucs, char* buffer, ref int offset, int capacity);
            static /*0x2be2df8*/ EA.Text.ConversionError UcsToUtf8(byte* buffer, ref int offset, int capacity, int ucs);
            static /*0x2be2f6c*/ EA.Text.ConversionError UcsToUtf16(char* buffer, ref int offset, int capacity, int ucs);
            static /*0x2be06b8*/ EA.Text.ConversionError Utf16ToUtf8(char* utf16_buffer, int utf16_length, byte* utf8_buffer, ref int utf8_length, int utf8_capacity);
            static /*0x2be04dc*/ EA.Text.ConversionError Utf16ToUtf8(string str, byte* utf8_buffer, ref int utf8_length, int utf8_capacity);
            static /*0x2be0028*/ EA.Text.ConversionError Utf8ToUtf16(byte* utf8_buffer, int utf8_length, char* utf16_buffer, ref int utf16_length, int utf16_capacity);
            static /*0x2bdffbc*/ int UTtf8ToUtf16Length(byte* utf8, int MaxLength);
            static /*0x2bdfd14*/ int UTtf8Length(byte* utf8, int MaxLength);
            static /*0x2be3058*/ int Utf16ToUtf8Length(char* utf16, int length);
            static /*0x2be0454*/ int Utf16ToUtf8Length(string str);
            static /*0x2bdfd88*/ char UTtf8GetAtIndex(byte* utf8, int MaxLength, int index, ref int offset, ref int charUtf8Length);
        }
    }

    namespace StringInternUtils
    {
        class AddressHelper
        {
            static /*0x2be310c*/ nint GetAddress(object obj);
            static /*0x1ffc854*/ int GetOffsetFromInternalFieldValueType<T, TField>(T obj, string fieldName, int startOffset);
            static /*0x1ffc854*/ int GetOffsetFromInternalFieldObject<T, TField>(T obj, string fieldName, int startOffset);

            struct ObjectReinterpreter
            {
                /*0x10*/ object AsObject;
                /*0x10*/ nint AsIntPtr;
            }

            class <>c__DisplayClass4_0<T, TField>
            {
                /*0x0*/ string fieldName;

                /*0x1f309e4*/ <>c__DisplayClass4_0();
                /*0x1f2fec8*/ bool <GetOffsetFromInternalFieldValueType>b__0(System.Reflection.FieldInfo p);
            }
        }

        class SizeOfHeaderClass
        {
            static /*0x0*/ long SizeOfHeader;

            static /*0x2be3128*/ long GetSizeOfHeader();

            class Dummy
            {
                /*0x10*/ byte[] a;

                /*0x2be3228*/ Dummy();
            }
        }

        class NativeMemoryByteArray : EA.StringInternUtils.NativeMemoryArray<byte>
        {
            /*0x2be328c*/ NativeMemoryByteArray(long size);
        }

        class NativeMemoryArray<T> : System.IDisposable
        {
            static /*0x0*/ int OffsetInClassNativeMemoryArray;
            /*0x0*/ T[] NativeArray;
            /*0x0*/ nint _ptrByteArray;
            /*0x0*/ nint _oldPtr;
            /*0x0*/ nint _nativeMemory;
            /*0x0*/ long _nativeMemorySize;
            /*0x0*/ T[] NativeArraySaved;

            static /*0x1f33998*/ NativeMemoryArray();
            /*0x1f30d60*/ NativeMemoryArray(long size);
            /*0x1f309e4*/ void Dispose();
            /*0x1f30a84*/ void Dispose(bool disposing);
            /*0x1f309e4*/ void Finalize();
        }

        class StringInternUtility
        {
            static /*0x0*/ string sInternalString;
            static /*0x8*/ int mAdrOffset_m_StringLength;

            static /*0x2be3308*/ StringInternUtility();
            static /*0x2be33cc*/ string CreateStringFromTempString(string maybeTempString);
            static /*0x2be350c*/ string GetTemporaryStringFromEncoding(System.Text.Encoding encoding, byte[] bytes, int index, int byteLength);
            static /*0x2be00f0*/ void SetInternalStringLength(ref string internalString, int maxSize, int length);
            static /*0x2be3664*/ void SetInternalStringLength(int length);
            static /*0x2be36c4*/ string StringBuilderToTempString(EA.Text.StringBuilder sb, int startIndex, int length);
            static /*0x2be349c*/ void CopyFromStringToString(string src, string dst);
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 0650D85E90CA5A191017D96B6CF776C390DF99E943981E7FEB5229C276ECB34A;
    static /*0xa*/ <PrivateImplementationDetails> 76B351CF70EE5EC7F1B83F392A5ECF88567129B80AC8399061D9BA3F1DB3DDD1;
    static /*0x1e*/ <PrivateImplementationDetails> 8DBC07F40F9D196EAA83D28A7E80F834DA697A23592BE94EB8A01755CB870726;
    static /*0x120*/ long B949CD1F6FF08789FC9B56B72A41C0EEB239C7D951A5D04808DC8C4E0D733575;

    struct __StaticArrayInitTypeSize=10
    {
    }

    struct __StaticArrayInitTypeSize=20
    {
    }

    struct __StaticArrayInitTypeSize=255
    {
    }
}
