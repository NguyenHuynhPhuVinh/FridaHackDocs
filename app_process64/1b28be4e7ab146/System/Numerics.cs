class <Module>
{
}

class SR
{
    static /*0x756e718*/ string Format(string resourceFormat, object p1);
}

namespace System
{
    namespace Numerics
    {
        struct Matrix3x2 : System.IEquatable<System.Numerics.Matrix3x2>
        {
            static /*0x0*/ System.Numerics.Matrix3x2 _identity;
            /*0x10*/ float M11;
            /*0x14*/ float M12;
            /*0x18*/ float M21;
            /*0x1c*/ float M22;
            /*0x20*/ float M31;
            /*0x24*/ float M32;

            static /*0x756ec04*/ Matrix3x2();
            /*0x756e788*/ Matrix3x2(float m11, float m12, float m21, float m22, float m31, float m32);
            /*0x756e798*/ bool Equals(System.Numerics.Matrix3x2 other);
            /*0x756e804*/ bool Equals(object obj);
            /*0x756e8fc*/ string ToString();
            /*0x756eb70*/ int GetHashCode();
        }

        struct Matrix4x4 : System.IEquatable<System.Numerics.Matrix4x4>
        {
            static /*0x0*/ System.Numerics.Matrix4x4 _identity;
            /*0x10*/ float M11;
            /*0x14*/ float M12;
            /*0x18*/ float M13;
            /*0x1c*/ float M14;
            /*0x20*/ float M21;
            /*0x24*/ float M22;
            /*0x28*/ float M23;
            /*0x2c*/ float M24;
            /*0x30*/ float M31;
            /*0x34*/ float M32;
            /*0x38*/ float M33;
            /*0x3c*/ float M34;
            /*0x40*/ float M41;
            /*0x44*/ float M42;
            /*0x48*/ float M43;
            /*0x4c*/ float M44;

            static /*0x756f530*/ Matrix4x4();
            /*0x756ec58*/ Matrix4x4(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44);
            /*0x756ec9c*/ bool Equals(System.Numerics.Matrix4x4 other);
            /*0x756eda8*/ bool Equals(object obj);
            /*0x756ee68*/ string ToString();
            /*0x756f3ac*/ int GetHashCode();
        }

        struct Quaternion : System.IEquatable<System.Numerics.Quaternion>
        {
            /*0x10*/ float X;
            /*0x14*/ float Y;
            /*0x18*/ float Z;
            /*0x1c*/ float W;

            /*0x756f59c*/ Quaternion(float x, float y, float z, float w);
            /*0x756f5a8*/ bool Equals(System.Numerics.Quaternion other);
            /*0x756f5e4*/ bool Equals(object obj);
            /*0x756f68c*/ string ToString();
            /*0x756f870*/ int GetHashCode();
        }

        struct Vector2 : System.IEquatable<System.Numerics.Vector2>, System.IFormattable
        {
            /*0x10*/ float X;
            /*0x14*/ float Y;

            /*0x756fb9c*/ Vector2(float x, float y);
            /*0x756f8d4*/ int GetHashCode();
            /*0x756f964*/ bool Equals(object obj);
            /*0x756fa10*/ string ToString();
            /*0x756fa88*/ string ToString(string format, System.IFormatProvider formatProvider);
            /*0x756f9ec*/ bool Equals(System.Numerics.Vector2 other);
        }

        struct Vector3 : System.IEquatable<System.Numerics.Vector3>, System.IFormattable
        {
            /*0x10*/ float X;
            /*0x14*/ float Y;
            /*0x18*/ float Z;

            /*0x756ff84*/ Vector3(float x, float y, float z);
            /*0x756fba4*/ int GetHashCode();
            /*0x756fc3c*/ bool Equals(object obj);
            /*0x756fd04*/ string ToString();
            /*0x756fd7c*/ string ToString(string format, System.IFormatProvider formatProvider);
            /*0x756fcd4*/ bool Equals(System.Numerics.Vector3 other);
        }

        struct Vector4 : System.IEquatable<System.Numerics.Vector4>, System.IFormattable
        {
            /*0x10*/ float X;
            /*0x14*/ float Y;
            /*0x18*/ float Z;
            /*0x1c*/ float W;

            /*0x7570338*/ Vector4(float x, float y, float z, float w);
            /*0x756ff90*/ int GetHashCode();
            /*0x7570040*/ bool Equals(object obj);
            /*0x7570124*/ string ToString();
            /*0x757019c*/ string ToString(string format, System.IFormatProvider formatProvider);
            /*0x75700e8*/ bool Equals(System.Numerics.Vector4 other);
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

            static /*0x75748d8*/ BigInteger();
            static /*0x75715ac*/ System.Numerics.BigInteger get_Zero();
            static /*0x7571604*/ System.Numerics.BigInteger get_MinusOne();
            static /*0x757166c*/ System.Numerics.BigInteger Parse(string value, System.IFormatProvider provider);
            static /*0x75716f4*/ System.Numerics.BigInteger Parse(string value, System.Globalization.NumberStyles style, System.IFormatProvider provider);
            static /*0x75725ac*/ System.Numerics.BigInteger Add(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign);
            static /*0x75728f0*/ System.Numerics.BigInteger op_Subtraction(System.Numerics.BigInteger left, System.Numerics.BigInteger right);
            static /*0x757299c*/ System.Numerics.BigInteger Subtract(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign);
            static /*0x7572d58*/ System.Numerics.BigInteger op_Implicit(byte value);
            static /*0x7572d80*/ System.Numerics.BigInteger op_Implicit(sbyte value);
            static /*0x7572da8*/ System.Numerics.BigInteger op_Implicit(short value);
            static /*0x7572dd0*/ System.Numerics.BigInteger op_Implicit(ushort value);
            static /*0x7572df8*/ System.Numerics.BigInteger op_Implicit(int value);
            static /*0x7572e20*/ System.Numerics.BigInteger op_Implicit(uint value);
            static /*0x75726f8*/ System.Numerics.BigInteger op_Implicit(long value);
            static /*0x7570a58*/ System.Numerics.BigInteger op_Implicit(ulong value);
            static /*0x7572e48*/ byte op_Explicit(System.Numerics.BigInteger value);
            static /*0x7572fb0*/ sbyte op_Explicit(System.Numerics.BigInteger value);
            static /*0x7573040*/ short op_Explicit(System.Numerics.BigInteger value);
            static /*0x75730d0*/ ushort op_Explicit(System.Numerics.BigInteger value);
            static /*0x7572ed8*/ int op_Explicit(System.Numerics.BigInteger value);
            static /*0x7573160*/ uint op_Explicit(System.Numerics.BigInteger value);
            static /*0x7573208*/ long op_Explicit(System.Numerics.BigInteger value);
            static /*0x75732b4*/ ulong op_Explicit(System.Numerics.BigInteger value);
            static /*0x757336c*/ float op_Explicit(System.Numerics.BigInteger value);
            static /*0x75733d8*/ double op_Explicit(System.Numerics.BigInteger value);
            static /*0x75735f0*/ decimal op_Explicit(System.Numerics.BigInteger value);
            static /*0x7573748*/ System.Numerics.BigInteger op_LeftShift(System.Numerics.BigInteger value, int shift);
            static /*0x757399c*/ System.Numerics.BigInteger op_RightShift(System.Numerics.BigInteger value, int shift);
            static /*0x7573d84*/ System.Numerics.BigInteger op_UnaryNegation(System.Numerics.BigInteger value);
            static /*0x7573db4*/ System.Numerics.BigInteger op_Addition(System.Numerics.BigInteger left, System.Numerics.BigInteger right);
            static /*0x7573e60*/ System.Numerics.BigInteger op_Multiply(System.Numerics.BigInteger left, System.Numerics.BigInteger right);
            static /*0x7574268*/ System.Numerics.BigInteger op_Division(System.Numerics.BigInteger dividend, System.Numerics.BigInteger divisor);
            static /*0x7574540*/ bool op_LessThanOrEqual(System.Numerics.BigInteger left, System.Numerics.BigInteger right);
            static /*0x75745c0*/ bool op_Inequality(System.Numerics.BigInteger left, System.Numerics.BigInteger right);
            static /*0x7574640*/ bool op_LessThan(System.Numerics.BigInteger left, long right);
            static /*0x75746ac*/ bool op_LessThanOrEqual(System.Numerics.BigInteger left, long right);
            static /*0x757471c*/ bool op_Equality(System.Numerics.BigInteger left, long right);
            static /*0x7574788*/ bool op_Inequality(System.Numerics.BigInteger left, long right);
            static /*0x75747f8*/ bool op_LessThan(long left, System.Numerics.BigInteger right);
            static /*0x7574868*/ bool op_LessThanOrEqual(long left, System.Numerics.BigInteger right);
            static /*0x7573cc0*/ bool GetPartsForBitManipulation(ref System.Numerics.BigInteger x, ref uint[] xd, ref int xl);
            static /*0x75719f4*/ int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu);
            /*0x7570344*/ BigInteger(int value);
            /*0x75703c8*/ BigInteger(uint value);
            /*0x757046c*/ BigInteger(long value);
            /*0x75705b8*/ BigInteger(ulong value);
            /*0x75706a4*/ BigInteger(float value);
            /*0x7570708*/ BigInteger(double value);
            /*0x7570a80*/ BigInteger(decimal value);
            /*0x7570c7c*/ BigInteger(byte[] value);
            /*0x7570d40*/ BigInteger(System.ReadOnlySpan<byte> value, bool isUnsigned, bool isBigEndian);
            /*0x75713a8*/ BigInteger(int n, uint[] rgu);
            /*0x75713b8*/ BigInteger(uint[] value, bool negative);
            /*0x757165c*/ bool get_IsZero();
            /*0x75717d4*/ int GetHashCode();
            /*0x7571814*/ bool Equals(object obj);
            /*0x7571978*/ bool Equals(long other);
            /*0x75718bc*/ bool Equals(System.Numerics.BigInteger other);
            /*0x7571a5c*/ int CompareTo(long other);
            /*0x7571aec*/ int CompareTo(System.Numerics.BigInteger other);
            /*0x7571c14*/ int CompareTo(object obj);
            /*0x7571d18*/ byte[] ToByteArray();
            /*0x7571d74*/ byte[] ToByteArray(bool isUnsigned, bool isBigEndian);
            /*0x757230c*/ bool TryWriteBytes(System.Span<byte> destination, ref int bytesWritten, bool isUnsigned, bool isBigEndian);
            /*0x75723bc*/ bool TryWriteOrCountBytes(System.Span<byte> destination, ref int bytesWritten, bool isUnsigned, bool isBigEndian);
            /*0x7571e00*/ byte[] TryGetBytes(System.Numerics.BigInteger.GetBytesMode mode, System.Span<byte> destination, bool isUnsigned, bool isBigEndian, ref int bytesWritten);
            /*0x7572464*/ string ToString();
            /*0x7572540*/ string ToString(System.IFormatProvider provider);
            /*0x7572574*/ string ToString(string format, System.IFormatProvider provider);

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

            static /*0x75759c8*/ BigIntegerCalculator();
            static /*0x757272c*/ uint[] Add(uint[] left, uint right);
            static /*0x7572804*/ uint[] Add(uint[] left, uint[] right);
            static /*0x7574a9c*/ void Add(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength);
            static /*0x7574b20*/ void AddSelf(uint* left, int leftLength, uint* right, int rightLength);
            static /*0x7572b2c*/ uint[] Subtract(uint[] left, uint right);
            static /*0x7572c64*/ uint[] Subtract(uint[] left, uint[] right);
            static /*0x7574b94*/ void Subtract(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength);
            static /*0x7572be4*/ int Compare(uint[] left, uint[] right);
            static /*0x75743b8*/ uint[] Divide(uint[] left, uint right);
            static /*0x7574464*/ uint[] Divide(uint[] left, uint[] right);
            static /*0x7574c88*/ void Divide(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength);
            static /*0x757508c*/ uint AddDivisor(uint* left, int leftLength, uint* right, int rightLength);
            static /*0x7575044*/ uint SubtractDivisor(uint* left, int leftLength, uint* right, int rightLength, ulong q);
            static /*0x7574ff8*/ bool DivideGuessTooBig(ulong q, ulong valHi, uint valLo, uint divHi, uint divLo);
            static /*0x7574c0c*/ uint[] CreateCopy(uint[] value);
            static /*0x7574f80*/ int LeadingZeros(uint value);
            static /*0x75740bc*/ uint[] Square(uint[] value);
            static /*0x75750cc*/ void Square(uint* value, int valueLength, uint* bits, int bitsLength);
            static /*0x7573fd8*/ uint[] Multiply(uint[] left, uint right);
            static /*0x757417c*/ uint[] Multiply(uint[] left, uint[] right);
            static /*0x7575534*/ void Multiply(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength);
            static /*0x7575474*/ void SubtractCore(uint* left, int leftLength, uint* right, int rightLength, uint* core, int coreLength);
        }

        class BigNumber
        {
            static /*0x7575a18*/ bool TryValidateParseStyleInteger(System.Globalization.NumberStyles style, ref System.ArgumentException e);
            static /*0x7575b30*/ bool TryParseBigInteger(System.ReadOnlySpan<char> value, System.Globalization.NumberStyles style, System.Globalization.NumberFormatInfo info, ref System.Numerics.BigInteger result);
            static /*0x7571728*/ System.Numerics.BigInteger ParseBigInteger(string value, System.Globalization.NumberStyles style, System.Globalization.NumberFormatInfo info);
            static /*0x75761d8*/ System.Numerics.BigInteger ParseBigInteger(System.ReadOnlySpan<char> value, System.Globalization.NumberStyles style, System.Globalization.NumberFormatInfo info);
            static /*0x7575dfc*/ bool HexNumberToBigInteger(ref System.Numerics.BigNumber.BigNumberBuffer number, ref System.Numerics.BigInteger value);
            static /*0x7575fac*/ bool NumberToBigInteger(ref System.Numerics.BigNumber.BigNumberBuffer number, ref System.Numerics.BigInteger value);
            static /*0x7576314*/ char ParseFormatSpecifier(System.ReadOnlySpan<char> format, ref int digits);
            static /*0x7576404*/ string FormatBigIntegerToHex(bool targetSpan, System.Numerics.BigInteger value, char format, int digits, System.Globalization.NumberFormatInfo info, System.Span<char> destination, ref int charsWritten, ref bool spanSuccess);
            static /*0x7572494*/ string FormatBigInteger(System.Numerics.BigInteger value, string format, System.Globalization.NumberFormatInfo info);
            static /*0x7576d44*/ string FormatBigInteger(bool targetSpan, System.Numerics.BigInteger value, string formatString, System.ReadOnlySpan<char> formatSpan, System.Globalization.NumberFormatInfo info, System.Span<char> destination, ref int charsWritten, ref bool spanSuccess);

            struct BigNumberBuffer
            {
                /*0x10*/ System.Text.StringBuilder digits;
                /*0x18*/ int precision;
                /*0x1c*/ int scale;
                /*0x20*/ bool sign;

                static /*0x7575c84*/ System.Numerics.BigNumber.BigNumberBuffer Create();
            }
        }

        struct Complex : System.IEquatable<System.Numerics.Complex>, System.IFormattable
        {
            static /*0x0*/ System.Numerics.Complex Zero;
            static /*0x10*/ System.Numerics.Complex One;
            static /*0x20*/ System.Numerics.Complex ImaginaryOne;
            static /*0x30*/ double s_sqrtRescaleThreshold;
            static /*0x38*/ double s_asinOverflowThreshold;
            static /*0x40*/ double s_log2;
            /*0x10*/ double m_real;
            /*0x18*/ double m_imaginary;

            static /*0x7577b28*/ Complex();
            /*0x757786c*/ Complex(double real, double imaginary);
            /*0x7577874*/ double get_Real();
            /*0x757787c*/ double get_Imaginary();
            /*0x7577884*/ bool Equals(object obj);
            /*0x757792c*/ bool Equals(System.Numerics.Complex value);
            /*0x7577970*/ int GetHashCode();
            /*0x75779cc*/ string ToString();
            /*0x7577a98*/ string ToString(string format, System.IFormatProvider provider);
        }

        struct DoubleUlong
        {
            /*0x10*/ double dbl;
            /*0x10*/ ulong uu;
        }

        class NumericsHelpers
        {
            static /*0x75709dc*/ void GetDoubleParts(double dbl, ref int sign, ref int exp, ref ulong man, ref bool fFinite);
            static /*0x7573548*/ double GetDoubleFromParts(int sign, int exp, ulong man);
            static /*0x75712f4*/ void DangerousMakeTwosComplement(uint[] d);
            static /*0x75719e4*/ ulong MakeUlong(uint uHi, uint uLo);
            static /*0x7572720*/ uint Abs(int a);
            static /*0x7577c04*/ uint CombineHash(uint u1, uint u2);
            static /*0x757180c*/ int CombineHash(int n1, int n2);
            static /*0x75734d0*/ int CbitHighZero(uint u);
            static /*0x7577be0*/ int CbitHighZero(ulong uu);
        }

        namespace Hashing
        {
            class HashHelpers
            {
                static /*0x0*/ int RandomSeed;

                static /*0x7577c0c*/ HashHelpers();
                static /*0x756f954*/ int Combine(int h1, int h2);
            }
        }
    }

    namespace Globalization
    {
        class FormatProvider
        {
            static /*0x757772c*/ void FormatBigInteger(ref System.Text.ValueStringBuilder sb, int precision, int scale, bool sign, System.ReadOnlySpan<char> format, System.Globalization.NumberFormatInfo numberFormatInfo, char[] digits, int startIndex);
            static /*0x7575d08*/ bool TryStringToBigInteger(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles styles, System.Globalization.NumberFormatInfo numberFormatInfo, System.Text.StringBuilder receiver, ref int precision, ref int scale, ref bool sign);

            class Number
            {
                static /*0x0*/ string[] s_posCurrencyFormats;
                static /*0x8*/ string[] s_negCurrencyFormats;
                static /*0x10*/ string[] s_posPercentFormats;
                static /*0x18*/ string[] s_negPercentFormats;
                static /*0x20*/ string[] s_negNumberFormats;
                static /*0x28*/ string s_posNumberFormat;

                static /*0x757b72c*/ Number();
                static /*0x75794e8*/ bool IsWhite(char ch);
                static /*0x7579510*/ char* MatchChars(char* p, char* pEnd, string str);
                static /*0x75795d4*/ char* MatchChars(char* p, char* pEnd, char* str);
                static /*0x7579630*/ bool ParseNumber(ref char* str, char* strEnd, System.Globalization.NumberStyles options, ref System.Globalization.FormatProvider.Number.NumberBuffer number, System.Text.StringBuilder sb, System.Globalization.NumberFormatInfo numfmt, bool parseDecimal);
                static /*0x7579d34*/ bool TrailingZeros(System.ReadOnlySpan<char> s, int index);
                static /*0x75793ac*/ bool TryStringToNumber(System.ReadOnlySpan<char> str, System.Globalization.NumberStyles options, ref System.Globalization.FormatProvider.Number.NumberBuffer number, System.Text.StringBuilder sb, System.Globalization.NumberFormatInfo numfmt, bool parseDecimal);
                static /*0x7579dc4*/ void Int32ToDecChars(char* buffer, ref int index, uint value, int digits);
                static /*0x7577c78*/ char ParseFormatSpecifier(System.ReadOnlySpan<char> format, ref int digits);
                static /*0x7577dbc*/ void NumberToString(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, char format, int nMaxDigits, System.Globalization.NumberFormatInfo info, bool isDecimal);
                static /*0x7579ef0*/ void FormatCurrency(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info);
                static /*0x757b0c8*/ int wcslen(char* s);
                static /*0x757a150*/ void FormatFixed(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup);
                static /*0x757a65c*/ void FormatNumber(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info);
                static /*0x757a8a4*/ void FormatScientific(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info, char expChar);
                static /*0x757b2f0*/ void FormatExponent(ref System.Text.ValueStringBuilder sb, System.Globalization.NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign);
                static /*0x757aae0*/ void FormatGeneral(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info, char expChar, bool bSuppressScientific);
                static /*0x757ae68*/ void FormatPercent(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info);
                static /*0x7579e20*/ void RoundNumber(ref System.Globalization.FormatProvider.Number.NumberBuffer number, int pos);
                static /*0x757b5e0*/ int FindSection(System.ReadOnlySpan<char> format, int section);
                static /*0x7578314*/ void NumberToStringFormat(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, System.ReadOnlySpan<char> format, System.Globalization.NumberFormatInfo info);

                struct NumberBuffer
                {
                    /*0x10*/ int precision;
                    /*0x14*/ int scale;
                    /*0x18*/ bool sign;
                    /*0x20*/ char* overrideDigits;

                    /*0x757c0ac*/ char* get_digits();
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

            /*0x75769b4*/ ValueStringBuilder(System.Span<char> initialBuffer);
            /*0x757c0b4*/ int get_Length();
            /*0x7576c78*/ string ToString();
            /*0x7576b8c*/ bool TryCopyTo(System.Span<char> destination, ref int charsWritten);
            /*0x75769c4*/ void Insert(int index, char value, int count);
            /*0x757c300*/ void Append(char c);
            /*0x757c3fc*/ void Append(string s);
            /*0x757c4a8*/ void AppendSlow(string s);
            /*0x757b1c8*/ void Append(char c, int count);
            /*0x757b0e8*/ void Append(char* value, int length);
            /*0x757c5d8*/ System.Span<char> AppendSpan(int length);
            /*0x757c37c*/ void GrowAndAppend(char c);
            /*0x757c0bc*/ void Grow(int requiredAdditionalCapacity);
            /*0x757c694*/ void Dispose();
        }
    }

    namespace Runtime
    {
        namespace CompilerServices
        {
            class IntrinsicAttribute : System.Attribute
            {
                /*0x757c78c*/ IntrinsicAttribute();
            }
        }
    }
}
