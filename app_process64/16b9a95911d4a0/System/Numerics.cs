class <Module>
{
}

class SR
{
    static /*0x37df320*/ string Format(string resourceFormat, object p1);
}

namespace System
{
    namespace Numerics
    {
        struct Vector3 : System.IEquatable<System.Numerics.Vector3>, System.IFormattable
        {
            /*0x10*/ float X;
            /*0x14*/ float Y;
            /*0x18*/ float Z;

            static /*0x37df390*/ System.Numerics.Vector3 get_Zero();
            static /*0x37df790*/ System.Numerics.Vector3 Cross(System.Numerics.Vector3 vector1, System.Numerics.Vector3 vector2);
            static /*0x37df7d0*/ float Dot(System.Numerics.Vector3 vector1, System.Numerics.Vector3 vector2);
            static /*0x37df7e8*/ System.Numerics.Vector3 op_Addition(System.Numerics.Vector3 left, System.Numerics.Vector3 right);
            static /*0x37df7f8*/ System.Numerics.Vector3 op_Subtraction(System.Numerics.Vector3 left, System.Numerics.Vector3 right);
            static /*0x37df808*/ System.Numerics.Vector3 op_Multiply(System.Numerics.Vector3 left, System.Numerics.Vector3 right);
            static /*0x37df818*/ System.Numerics.Vector3 op_Multiply(System.Numerics.Vector3 left, float right);
            /*0x37df7c4*/ Vector3(float value);
            /*0x37df7b8*/ Vector3(float x, float y, float z);
            /*0x37df3a0*/ int GetHashCode();
            /*0x37df448*/ bool Equals(object obj);
            /*0x37df510*/ string ToString();
            /*0x37df588*/ string ToString(string format, System.IFormatProvider formatProvider);
            /*0x37df4e0*/ bool Equals(System.Numerics.Vector3 other);
        }

        struct BigInteger : System.IFormattable, System.IComparable, System.IComparable<System.Numerics.BigInteger>, System.IEquatable<System.Numerics.BigInteger>
        {
            static /*0x0*/ System.Numerics.BigInteger s_bnMinInt;
            static /*0x10*/ System.Numerics.BigInteger s_bnOneInt;
            static /*0x20*/ System.Numerics.BigInteger s_bnZeroInt;
            static /*0x30*/ System.Numerics.BigInteger s_bnMinusOneInt;
            static /*0x40*/ byte[] s_success;
            /*0x10*/ int _sign;
            /*0x18*/ uint[] _bits;

            static /*0x37e3d6c*/ BigInteger();
            static /*0x37e0ad0*/ System.Numerics.BigInteger get_Zero();
            static /*0x37e0b28*/ System.Numerics.BigInteger get_MinusOne();
            static /*0x37e0b90*/ System.Numerics.BigInteger Parse(string value, System.IFormatProvider provider);
            static /*0x37e0c18*/ System.Numerics.BigInteger Parse(string value, System.Globalization.NumberStyles style, System.IFormatProvider provider);
            static /*0x37e19f8*/ System.Numerics.BigInteger Add(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign);
            static /*0x37e1d54*/ System.Numerics.BigInteger op_Subtraction(System.Numerics.BigInteger left, System.Numerics.BigInteger right);
            static /*0x37e1e04*/ System.Numerics.BigInteger Subtract(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign);
            static /*0x37e21d4*/ System.Numerics.BigInteger op_Implicit(byte value);
            static /*0x37e2200*/ System.Numerics.BigInteger op_Implicit(sbyte value);
            static /*0x37e2228*/ System.Numerics.BigInteger op_Implicit(short value);
            static /*0x37e2250*/ System.Numerics.BigInteger op_Implicit(ushort value);
            static /*0x37e227c*/ System.Numerics.BigInteger op_Implicit(int value);
            static /*0x37e22a4*/ System.Numerics.BigInteger op_Implicit(uint value);
            static /*0x37e1b5c*/ System.Numerics.BigInteger op_Implicit(long value);
            static /*0x37dff38*/ System.Numerics.BigInteger op_Implicit(ulong value);
            static /*0x37e22cc*/ byte op_Explicit(System.Numerics.BigInteger value);
            static /*0x37e2438*/ sbyte op_Explicit(System.Numerics.BigInteger value);
            static /*0x37e24c8*/ short op_Explicit(System.Numerics.BigInteger value);
            static /*0x37e2558*/ ushort op_Explicit(System.Numerics.BigInteger value);
            static /*0x37e235c*/ int op_Explicit(System.Numerics.BigInteger value);
            static /*0x37e25e8*/ uint op_Explicit(System.Numerics.BigInteger value);
            static /*0x37e2690*/ long op_Explicit(System.Numerics.BigInteger value);
            static /*0x37e2738*/ ulong op_Explicit(System.Numerics.BigInteger value);
            static /*0x37e27f4*/ float op_Explicit(System.Numerics.BigInteger value);
            static /*0x37e2860*/ double op_Explicit(System.Numerics.BigInteger value);
            static /*0x37e2a6c*/ decimal op_Explicit(System.Numerics.BigInteger value);
            static /*0x37e2bdc*/ System.Numerics.BigInteger op_LeftShift(System.Numerics.BigInteger value, int shift);
            static /*0x37e2e20*/ System.Numerics.BigInteger op_RightShift(System.Numerics.BigInteger value, int shift);
            static /*0x37e320c*/ System.Numerics.BigInteger op_UnaryNegation(System.Numerics.BigInteger value);
            static /*0x37e323c*/ System.Numerics.BigInteger op_Addition(System.Numerics.BigInteger left, System.Numerics.BigInteger right);
            static /*0x37e32ec*/ System.Numerics.BigInteger op_Multiply(System.Numerics.BigInteger left, System.Numerics.BigInteger right);
            static /*0x37e36f0*/ System.Numerics.BigInteger op_Division(System.Numerics.BigInteger dividend, System.Numerics.BigInteger divisor);
            static /*0x37e39d4*/ bool op_LessThanOrEqual(System.Numerics.BigInteger left, System.Numerics.BigInteger right);
            static /*0x37e3a54*/ bool op_Inequality(System.Numerics.BigInteger left, System.Numerics.BigInteger right);
            static /*0x37e3ad4*/ bool op_LessThan(System.Numerics.BigInteger left, long right);
            static /*0x37e3b40*/ bool op_LessThanOrEqual(System.Numerics.BigInteger left, long right);
            static /*0x37e3bb0*/ bool op_Equality(System.Numerics.BigInteger left, long right);
            static /*0x37e3c1c*/ bool op_Inequality(System.Numerics.BigInteger left, long right);
            static /*0x37e3c8c*/ bool op_LessThan(long left, System.Numerics.BigInteger right);
            static /*0x37e3cfc*/ bool op_LessThanOrEqual(long left, System.Numerics.BigInteger right);
            static /*0x37e313c*/ bool GetPartsForBitManipulation(ref System.Numerics.BigInteger x, ref uint[] xd, ref int xl);
            static /*0x37e0f2c*/ int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu);
            /*0x37df828*/ BigInteger(int value);
            /*0x37df8ac*/ BigInteger(uint value);
            /*0x37df950*/ BigInteger(long value);
            /*0x37dfa9c*/ BigInteger(ulong value);
            /*0x37dfb88*/ BigInteger(float value);
            /*0x37dfbec*/ BigInteger(double value);
            /*0x37dff60*/ BigInteger(decimal value);
            /*0x37e015c*/ BigInteger(byte[] value);
            /*0x37e0220*/ BigInteger(System.ReadOnlySpan<byte> value, bool isUnsigned, bool isBigEndian);
            /*0x37e08c8*/ BigInteger(int n, uint[] rgu);
            /*0x37e08d8*/ BigInteger(uint[] value, bool negative);
            /*0x37e0b80*/ bool get_IsZero();
            /*0x37e0cf8*/ int GetHashCode();
            /*0x37e0d50*/ bool Equals(object obj);
            /*0x37e0eb8*/ bool Equals(long other);
            /*0x37e0dfc*/ bool Equals(System.Numerics.BigInteger other);
            /*0x37e0fa4*/ int CompareTo(long other);
            /*0x37e1034*/ int CompareTo(System.Numerics.BigInteger other);
            /*0x37e1158*/ int CompareTo(object obj);
            /*0x37e1260*/ bool TryWriteBytes(System.Span<byte> destination, ref int bytesWritten, bool isUnsigned, bool isBigEndian);
            /*0x37e1808*/ bool TryWriteOrCountBytes(System.Span<byte> destination, ref int bytesWritten, bool isUnsigned, bool isBigEndian);
            /*0x37e1310*/ byte[] TryGetBytes(System.Numerics.BigInteger.GetBytesMode mode, System.Span<byte> destination, bool isUnsigned, bool isBigEndian, ref int bytesWritten);
            /*0x37e18b0*/ string ToString();
            /*0x37e198c*/ string ToString(System.IFormatProvider provider);
            /*0x37e19c0*/ string ToString(string format, System.IFormatProvider provider);

            enum GetBytesMode
            {
                AllocateArray = 0,
                Count = 1,
                Span = 2,
            }
        }

        class BigIntegerCalculator
        {
            static /*0x0*/ int ReducerThreshold;
            static /*0x4*/ int SquareThreshold;
            static /*0x8*/ int AllocationThreshold;
            static /*0xc*/ int MultiplyThreshold;

            static /*0x37e4ed0*/ BigIntegerCalculator();
            static /*0x37e1b90*/ uint[] Add(uint[] left, uint right);
            static /*0x37e1c68*/ uint[] Add(uint[] left, uint[] right);
            static /*0x37e3f3c*/ void Add(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength);
            static /*0x37e3fc0*/ void AddSelf(uint* left, int leftLength, uint* right, int rightLength);
            static /*0x37e1fa0*/ uint[] Subtract(uint[] left, uint right);
            static /*0x37e20e0*/ uint[] Subtract(uint[] left, uint[] right);
            static /*0x37e402c*/ void Subtract(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength);
            static /*0x37e2054*/ int Compare(uint[] left, uint[] right);
            static /*0x37e383c*/ uint[] Divide(uint[] left, uint right);
            static /*0x37e38f8*/ uint[] Divide(uint[] left, uint[] right);
            static /*0x37e4120*/ void Divide(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength);
            static /*0x37e4540*/ uint AddDivisor(uint* left, int leftLength, uint* right, int rightLength);
            static /*0x37e44f8*/ uint SubtractDivisor(uint* left, int leftLength, uint* right, int rightLength, ulong q);
            static /*0x37e44b8*/ bool DivideGuessTooBig(ulong q, ulong valHi, uint valLo, uint divHi, uint divLo);
            static /*0x37e40a4*/ uint[] CreateCopy(uint[] value);
            static /*0x37e4440*/ int LeadingZeros(uint value);
            static /*0x37e353c*/ uint[] Square(uint[] value);
            static /*0x37e4580*/ void Square(uint* value, int valueLength, uint* bits, int bitsLength);
            static /*0x37e3464*/ uint[] Multiply(uint[] left, uint right);
            static /*0x37e3600*/ uint[] Multiply(uint[] left, uint[] right);
            static /*0x37e4a24*/ void Multiply(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength);
            static /*0x37e4960*/ void SubtractCore(uint* left, int leftLength, uint* right, int rightLength, uint* core, int coreLength);
        }

        class BigNumber
        {
            static /*0x37e4f20*/ bool TryValidateParseStyleInteger(System.Globalization.NumberStyles style, ref System.ArgumentException e);
            static /*0x37e5020*/ bool TryParseBigInteger(System.ReadOnlySpan<char> value, System.Globalization.NumberStyles style, System.Globalization.NumberFormatInfo info, ref System.Numerics.BigInteger result);
            static /*0x37e0c4c*/ System.Numerics.BigInteger ParseBigInteger(string value, System.Globalization.NumberStyles style, System.Globalization.NumberFormatInfo info);
            static /*0x37e56bc*/ System.Numerics.BigInteger ParseBigInteger(System.ReadOnlySpan<char> value, System.Globalization.NumberStyles style, System.Globalization.NumberFormatInfo info);
            static /*0x37e52dc*/ bool HexNumberToBigInteger(ref System.Numerics.BigNumber.BigNumberBuffer number, ref System.Numerics.BigInteger value);
            static /*0x37e5494*/ bool NumberToBigInteger(ref System.Numerics.BigNumber.BigNumberBuffer number, ref System.Numerics.BigInteger value);
            static /*0x37e57f8*/ char ParseFormatSpecifier(System.ReadOnlySpan<char> format, ref int digits);
            static /*0x37e58e8*/ string FormatBigIntegerToHex(bool targetSpan, System.Numerics.BigInteger value, char format, int digits, System.Globalization.NumberFormatInfo info, System.Span<char> destination, ref int charsWritten, ref bool spanSuccess);
            static /*0x37e18e0*/ string FormatBigInteger(System.Numerics.BigInteger value, string format, System.Globalization.NumberFormatInfo info);
            static /*0x37e6450*/ string FormatBigInteger(bool targetSpan, System.Numerics.BigInteger value, string formatString, System.ReadOnlySpan<char> formatSpan, System.Globalization.NumberFormatInfo info, System.Span<char> destination, ref int charsWritten, ref bool spanSuccess);

            struct BigNumberBuffer
            {
                /*0x10*/ System.Text.StringBuilder digits;
                /*0x18*/ int precision;
                /*0x1c*/ int scale;
                /*0x20*/ bool sign;

                static /*0x37e5174*/ System.Numerics.BigNumber.BigNumberBuffer Create();
            }
        }

        struct DoubleUlong
        {
            /*0x10*/ double dbl;
            /*0x10*/ ulong uu;
        }

        class NumericsHelpers
        {
            static /*0x37dfebc*/ void GetDoubleParts(double dbl, ref int sign, ref int exp, ref ulong man, ref bool fFinite);
            static /*0x37e29c4*/ double GetDoubleFromParts(int sign, int exp, ulong man);
            static /*0x37e0814*/ void DangerousMakeTwosComplement(uint[] d);
            static /*0x37e0f20*/ ulong MakeUlong(uint uHi, uint uLo);
            static /*0x37e1b84*/ uint Abs(int a);
            static /*0x37e71bc*/ uint CombineHash(uint u1, uint u2);
            static /*0x37e0d48*/ int CombineHash(int n1, int n2);
            static /*0x37e294c*/ int CbitHighZero(uint u);
            static /*0x37e7198*/ int CbitHighZero(ulong uu);
        }

        namespace Hashing
        {
            class HashHelpers
            {
                static /*0x0*/ int RandomSeed;

                static /*0x37e71c4*/ HashHelpers();
                static /*0x37df438*/ int Combine(int h1, int h2);
            }
        }
    }

    namespace Globalization
    {
        class FormatProvider
        {
            static /*0x37e7058*/ void FormatBigInteger(ref System.Text.ValueStringBuilder sb, int precision, int scale, bool sign, System.ReadOnlySpan<char> format, System.Globalization.NumberFormatInfo numberFormatInfo, char[] digits, int startIndex);
            static /*0x37e51f8*/ bool TryStringToBigInteger(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles styles, System.Globalization.NumberFormatInfo numberFormatInfo, System.Text.StringBuilder receiver, ref int precision, ref int scale, ref bool sign);

            class Number
            {
                static /*0x0*/ string[] s_posCurrencyFormats;
                static /*0x8*/ string[] s_negCurrencyFormats;
                static /*0x10*/ string[] s_posPercentFormats;
                static /*0x18*/ string[] s_negPercentFormats;
                static /*0x20*/ string[] s_negNumberFormats;
                static /*0x28*/ string s_posNumberFormat;

                static /*0x37eb09c*/ Number();
                static /*0x37e8c38*/ bool IsWhite(char ch);
                static /*0x37e8c50*/ char* MatchChars(char* p, char* pEnd, string str);
                static /*0x37e8d14*/ char* MatchChars(char* p, char* pEnd, char* str);
                static /*0x37e8d70*/ bool ParseNumber(ref char* str, char* strEnd, System.Globalization.NumberStyles options, ref System.Globalization.FormatProvider.Number.NumberBuffer number, System.Text.StringBuilder sb, System.Globalization.NumberFormatInfo numfmt, bool parseDecimal);
                static /*0x37e9474*/ bool TrailingZeros(System.ReadOnlySpan<char> s, int index);
                static /*0x37e8afc*/ bool TryStringToNumber(System.ReadOnlySpan<char> str, System.Globalization.NumberStyles options, ref System.Globalization.FormatProvider.Number.NumberBuffer number, System.Text.StringBuilder sb, System.Globalization.NumberFormatInfo numfmt, bool parseDecimal);
                static /*0x37e950c*/ void Int32ToDecChars(char* buffer, ref int index, uint value, int digits);
                static /*0x37e7230*/ char ParseFormatSpecifier(System.ReadOnlySpan<char> format, ref int digits);
                static /*0x37e7374*/ void NumberToString(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, char format, int nMaxDigits, System.Globalization.NumberFormatInfo info, bool isDecimal);
                static /*0x37e9650*/ void FormatCurrency(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info);
                static /*0x37ea8dc*/ int wcslen(char* s);
                static /*0x37e98d0*/ void FormatFixed(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup);
                static /*0x37e9e50*/ void FormatNumber(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info);
                static /*0x37ea0b8*/ void FormatScientific(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info, char expChar);
                static /*0x37eac48*/ void FormatExponent(ref System.Text.ValueStringBuilder sb, System.Globalization.NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign);
                static /*0x37ea2f8*/ void FormatGeneral(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info, char expChar, bool bSuppressScientific);
                static /*0x37ea65c*/ void FormatPercent(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info);
                static /*0x37e9568*/ void RoundNumber(ref System.Globalization.FormatProvider.Number.NumberBuffer number, int pos);
                static /*0x37eaf58*/ int FindSection(System.ReadOnlySpan<char> format, int section);
                static /*0x37e7908*/ void NumberToStringFormat(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, System.ReadOnlySpan<char> format, System.Globalization.NumberFormatInfo info);

                struct NumberBuffer
                {
                    /*0x10*/ int precision;
                    /*0x14*/ int scale;
                    /*0x18*/ bool sign;
                    /*0x20*/ char* overrideDigits;

                    /*0x37eba1c*/ char* get_digits();
                }
            }
        }
    }

    namespace Text
    {
        struct ValueStringBuilder
        {
            /*0x10*/ char[] _arrayToReturnToPool;
            /*0x18*/ System.Span<char> _chars;
            /*0x28*/ int _pos;

            /*0x37e5fc0*/ ValueStringBuilder(System.Span<char> initialBuffer);
            /*0x37eba24*/ int get_Length();
            /*0x37e6350*/ string ToString();
            /*0x37e6228*/ bool TryCopyTo(System.Span<char> destination, ref int charsWritten);
            /*0x37e5fd0*/ void Insert(int index, char value, int count);
            /*0x37ebc90*/ void Append(char c);
            /*0x37ebd8c*/ void Append(string s);
            /*0x37ebe38*/ void AppendSlow(string s);
            /*0x37eaa20*/ void Append(char c, int count);
            /*0x37ea908*/ void Append(char* value, int length);
            /*0x37ebf9c*/ System.Span<char> AppendSpan(int length);
            /*0x37ebd0c*/ void GrowAndAppend(char c);
            /*0x37eba2c*/ void Grow(int requiredAdditionalCapacity);
            /*0x37ec08c*/ void Dispose();
        }
    }

    namespace Runtime
    {
        namespace CompilerServices
        {
            class IntrinsicAttribute : System.Attribute
            {
                /*0x37ec194*/ IntrinsicAttribute();
            }
        }
    }
}
