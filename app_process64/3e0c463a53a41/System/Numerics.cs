class <Module>
{
}

class SR
{
    static /*0x75572e8*/ string Format(string resourceFormat, object p1);
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

            static /*0x75577d4*/ Matrix3x2();
            /*0x7557358*/ Matrix3x2(float m11, float m12, float m21, float m22, float m31, float m32);
            /*0x7557368*/ bool Equals(System.Numerics.Matrix3x2 other);
            /*0x75573d4*/ bool Equals(object obj);
            /*0x75574cc*/ string ToString();
            /*0x7557740*/ int GetHashCode();
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

            static /*0x7558100*/ Matrix4x4();
            /*0x7557828*/ Matrix4x4(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44);
            /*0x755786c*/ bool Equals(System.Numerics.Matrix4x4 other);
            /*0x7557978*/ bool Equals(object obj);
            /*0x7557a38*/ string ToString();
            /*0x7557f7c*/ int GetHashCode();
        }

        struct Quaternion : System.IEquatable<System.Numerics.Quaternion>
        {
            /*0x10*/ float X;
            /*0x14*/ float Y;
            /*0x18*/ float Z;
            /*0x1c*/ float W;

            /*0x755816c*/ Quaternion(float x, float y, float z, float w);
            /*0x7558178*/ bool Equals(System.Numerics.Quaternion other);
            /*0x75581b4*/ bool Equals(object obj);
            /*0x755825c*/ string ToString();
            /*0x7558440*/ int GetHashCode();
        }

        struct Vector2 : System.IEquatable<System.Numerics.Vector2>, System.IFormattable
        {
            /*0x10*/ float X;
            /*0x14*/ float Y;

            /*0x755876c*/ Vector2(float x, float y);
            /*0x75584a4*/ int GetHashCode();
            /*0x7558534*/ bool Equals(object obj);
            /*0x75585e0*/ string ToString();
            /*0x7558658*/ string ToString(string format, System.IFormatProvider formatProvider);
            /*0x75585bc*/ bool Equals(System.Numerics.Vector2 other);
        }

        struct Vector3 : System.IEquatable<System.Numerics.Vector3>, System.IFormattable
        {
            /*0x10*/ float X;
            /*0x14*/ float Y;
            /*0x18*/ float Z;

            /*0x7558b54*/ Vector3(float x, float y, float z);
            /*0x7558774*/ int GetHashCode();
            /*0x755880c*/ bool Equals(object obj);
            /*0x75588d4*/ string ToString();
            /*0x755894c*/ string ToString(string format, System.IFormatProvider formatProvider);
            /*0x75588a4*/ bool Equals(System.Numerics.Vector3 other);
        }

        struct Vector4 : System.IEquatable<System.Numerics.Vector4>, System.IFormattable
        {
            /*0x10*/ float X;
            /*0x14*/ float Y;
            /*0x18*/ float Z;
            /*0x1c*/ float W;

            /*0x7558f08*/ Vector4(float x, float y, float z, float w);
            /*0x7558b60*/ int GetHashCode();
            /*0x7558c10*/ bool Equals(object obj);
            /*0x7558cf4*/ string ToString();
            /*0x7558d6c*/ string ToString(string format, System.IFormatProvider formatProvider);
            /*0x7558cb8*/ bool Equals(System.Numerics.Vector4 other);
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

            static /*0x755d4a8*/ BigInteger();
            static /*0x755a17c*/ System.Numerics.BigInteger get_Zero();
            static /*0x755a1d4*/ System.Numerics.BigInteger get_MinusOne();
            static /*0x755a23c*/ System.Numerics.BigInteger Parse(string value, System.IFormatProvider provider);
            static /*0x755a2c4*/ System.Numerics.BigInteger Parse(string value, System.Globalization.NumberStyles style, System.IFormatProvider provider);
            static /*0x755b17c*/ System.Numerics.BigInteger Add(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign);
            static /*0x755b4c0*/ System.Numerics.BigInteger op_Subtraction(System.Numerics.BigInteger left, System.Numerics.BigInteger right);
            static /*0x755b56c*/ System.Numerics.BigInteger Subtract(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign);
            static /*0x755b928*/ System.Numerics.BigInteger op_Implicit(byte value);
            static /*0x755b950*/ System.Numerics.BigInteger op_Implicit(sbyte value);
            static /*0x755b978*/ System.Numerics.BigInteger op_Implicit(short value);
            static /*0x755b9a0*/ System.Numerics.BigInteger op_Implicit(ushort value);
            static /*0x755b9c8*/ System.Numerics.BigInteger op_Implicit(int value);
            static /*0x755b9f0*/ System.Numerics.BigInteger op_Implicit(uint value);
            static /*0x755b2c8*/ System.Numerics.BigInteger op_Implicit(long value);
            static /*0x7559628*/ System.Numerics.BigInteger op_Implicit(ulong value);
            static /*0x755ba18*/ byte op_Explicit(System.Numerics.BigInteger value);
            static /*0x755bb80*/ sbyte op_Explicit(System.Numerics.BigInteger value);
            static /*0x755bc10*/ short op_Explicit(System.Numerics.BigInteger value);
            static /*0x755bca0*/ ushort op_Explicit(System.Numerics.BigInteger value);
            static /*0x755baa8*/ int op_Explicit(System.Numerics.BigInteger value);
            static /*0x755bd30*/ uint op_Explicit(System.Numerics.BigInteger value);
            static /*0x755bdd8*/ long op_Explicit(System.Numerics.BigInteger value);
            static /*0x755be84*/ ulong op_Explicit(System.Numerics.BigInteger value);
            static /*0x755bf3c*/ float op_Explicit(System.Numerics.BigInteger value);
            static /*0x755bfa8*/ double op_Explicit(System.Numerics.BigInteger value);
            static /*0x755c1c0*/ decimal op_Explicit(System.Numerics.BigInteger value);
            static /*0x755c318*/ System.Numerics.BigInteger op_LeftShift(System.Numerics.BigInteger value, int shift);
            static /*0x755c56c*/ System.Numerics.BigInteger op_RightShift(System.Numerics.BigInteger value, int shift);
            static /*0x755c954*/ System.Numerics.BigInteger op_UnaryNegation(System.Numerics.BigInteger value);
            static /*0x755c984*/ System.Numerics.BigInteger op_Addition(System.Numerics.BigInteger left, System.Numerics.BigInteger right);
            static /*0x755ca30*/ System.Numerics.BigInteger op_Multiply(System.Numerics.BigInteger left, System.Numerics.BigInteger right);
            static /*0x755ce38*/ System.Numerics.BigInteger op_Division(System.Numerics.BigInteger dividend, System.Numerics.BigInteger divisor);
            static /*0x755d110*/ bool op_LessThanOrEqual(System.Numerics.BigInteger left, System.Numerics.BigInteger right);
            static /*0x755d190*/ bool op_Inequality(System.Numerics.BigInteger left, System.Numerics.BigInteger right);
            static /*0x755d210*/ bool op_LessThan(System.Numerics.BigInteger left, long right);
            static /*0x755d27c*/ bool op_LessThanOrEqual(System.Numerics.BigInteger left, long right);
            static /*0x755d2ec*/ bool op_Equality(System.Numerics.BigInteger left, long right);
            static /*0x755d358*/ bool op_Inequality(System.Numerics.BigInteger left, long right);
            static /*0x755d3c8*/ bool op_LessThan(long left, System.Numerics.BigInteger right);
            static /*0x755d438*/ bool op_LessThanOrEqual(long left, System.Numerics.BigInteger right);
            static /*0x755c890*/ bool GetPartsForBitManipulation(ref System.Numerics.BigInteger x, ref uint[] xd, ref int xl);
            static /*0x755a5c4*/ int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu);
            /*0x7558f14*/ BigInteger(int value);
            /*0x7558f98*/ BigInteger(uint value);
            /*0x755903c*/ BigInteger(long value);
            /*0x7559188*/ BigInteger(ulong value);
            /*0x7559274*/ BigInteger(float value);
            /*0x75592d8*/ BigInteger(double value);
            /*0x7559650*/ BigInteger(decimal value);
            /*0x755984c*/ BigInteger(byte[] value);
            /*0x7559910*/ BigInteger(System.ReadOnlySpan<byte> value, bool isUnsigned, bool isBigEndian);
            /*0x7559f78*/ BigInteger(int n, uint[] rgu);
            /*0x7559f88*/ BigInteger(uint[] value, bool negative);
            /*0x755a22c*/ bool get_IsZero();
            /*0x755a3a4*/ int GetHashCode();
            /*0x755a3e4*/ bool Equals(object obj);
            /*0x755a548*/ bool Equals(long other);
            /*0x755a48c*/ bool Equals(System.Numerics.BigInteger other);
            /*0x755a62c*/ int CompareTo(long other);
            /*0x755a6bc*/ int CompareTo(System.Numerics.BigInteger other);
            /*0x755a7e4*/ int CompareTo(object obj);
            /*0x755a8e8*/ byte[] ToByteArray();
            /*0x755a944*/ byte[] ToByteArray(bool isUnsigned, bool isBigEndian);
            /*0x755aedc*/ bool TryWriteBytes(System.Span<byte> destination, ref int bytesWritten, bool isUnsigned, bool isBigEndian);
            /*0x755af8c*/ bool TryWriteOrCountBytes(System.Span<byte> destination, ref int bytesWritten, bool isUnsigned, bool isBigEndian);
            /*0x755a9d0*/ byte[] TryGetBytes(System.Numerics.BigInteger.GetBytesMode mode, System.Span<byte> destination, bool isUnsigned, bool isBigEndian, ref int bytesWritten);
            /*0x755b034*/ string ToString();
            /*0x755b110*/ string ToString(System.IFormatProvider provider);
            /*0x755b144*/ string ToString(string format, System.IFormatProvider provider);

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

            static /*0x755e598*/ BigIntegerCalculator();
            static /*0x755b2fc*/ uint[] Add(uint[] left, uint right);
            static /*0x755b3d4*/ uint[] Add(uint[] left, uint[] right);
            static /*0x755d66c*/ void Add(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength);
            static /*0x755d6f0*/ void AddSelf(uint* left, int leftLength, uint* right, int rightLength);
            static /*0x755b6fc*/ uint[] Subtract(uint[] left, uint right);
            static /*0x755b834*/ uint[] Subtract(uint[] left, uint[] right);
            static /*0x755d764*/ void Subtract(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength);
            static /*0x755b7b4*/ int Compare(uint[] left, uint[] right);
            static /*0x755cf88*/ uint[] Divide(uint[] left, uint right);
            static /*0x755d034*/ uint[] Divide(uint[] left, uint[] right);
            static /*0x755d858*/ void Divide(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength);
            static /*0x755dc5c*/ uint AddDivisor(uint* left, int leftLength, uint* right, int rightLength);
            static /*0x755dc14*/ uint SubtractDivisor(uint* left, int leftLength, uint* right, int rightLength, ulong q);
            static /*0x755dbc8*/ bool DivideGuessTooBig(ulong q, ulong valHi, uint valLo, uint divHi, uint divLo);
            static /*0x755d7dc*/ uint[] CreateCopy(uint[] value);
            static /*0x755db50*/ int LeadingZeros(uint value);
            static /*0x755cc8c*/ uint[] Square(uint[] value);
            static /*0x755dc9c*/ void Square(uint* value, int valueLength, uint* bits, int bitsLength);
            static /*0x755cba8*/ uint[] Multiply(uint[] left, uint right);
            static /*0x755cd4c*/ uint[] Multiply(uint[] left, uint[] right);
            static /*0x755e104*/ void Multiply(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength);
            static /*0x755e044*/ void SubtractCore(uint* left, int leftLength, uint* right, int rightLength, uint* core, int coreLength);
        }

        class BigNumber
        {
            static /*0x755e5e8*/ bool TryValidateParseStyleInteger(System.Globalization.NumberStyles style, ref System.ArgumentException e);
            static /*0x755e700*/ bool TryParseBigInteger(System.ReadOnlySpan<char> value, System.Globalization.NumberStyles style, System.Globalization.NumberFormatInfo info, ref System.Numerics.BigInteger result);
            static /*0x755a2f8*/ System.Numerics.BigInteger ParseBigInteger(string value, System.Globalization.NumberStyles style, System.Globalization.NumberFormatInfo info);
            static /*0x755eda8*/ System.Numerics.BigInteger ParseBigInteger(System.ReadOnlySpan<char> value, System.Globalization.NumberStyles style, System.Globalization.NumberFormatInfo info);
            static /*0x755e9cc*/ bool HexNumberToBigInteger(ref System.Numerics.BigNumber.BigNumberBuffer number, ref System.Numerics.BigInteger value);
            static /*0x755eb7c*/ bool NumberToBigInteger(ref System.Numerics.BigNumber.BigNumberBuffer number, ref System.Numerics.BigInteger value);
            static /*0x755eee4*/ char ParseFormatSpecifier(System.ReadOnlySpan<char> format, ref int digits);
            static /*0x755efd4*/ string FormatBigIntegerToHex(bool targetSpan, System.Numerics.BigInteger value, char format, int digits, System.Globalization.NumberFormatInfo info, System.Span<char> destination, ref int charsWritten, ref bool spanSuccess);
            static /*0x755b064*/ string FormatBigInteger(System.Numerics.BigInteger value, string format, System.Globalization.NumberFormatInfo info);
            static /*0x755f914*/ string FormatBigInteger(bool targetSpan, System.Numerics.BigInteger value, string formatString, System.ReadOnlySpan<char> formatSpan, System.Globalization.NumberFormatInfo info, System.Span<char> destination, ref int charsWritten, ref bool spanSuccess);

            struct BigNumberBuffer
            {
                /*0x10*/ System.Text.StringBuilder digits;
                /*0x18*/ int precision;
                /*0x1c*/ int scale;
                /*0x20*/ bool sign;

                static /*0x755e854*/ System.Numerics.BigNumber.BigNumberBuffer Create();
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

            static /*0x75606f8*/ Complex();
            /*0x756043c*/ Complex(double real, double imaginary);
            /*0x7560444*/ double get_Real();
            /*0x756044c*/ double get_Imaginary();
            /*0x7560454*/ bool Equals(object obj);
            /*0x75604fc*/ bool Equals(System.Numerics.Complex value);
            /*0x7560540*/ int GetHashCode();
            /*0x756059c*/ string ToString();
            /*0x7560668*/ string ToString(string format, System.IFormatProvider provider);
        }

        struct DoubleUlong
        {
            /*0x10*/ double dbl;
            /*0x10*/ ulong uu;
        }

        class NumericsHelpers
        {
            static /*0x75595ac*/ void GetDoubleParts(double dbl, ref int sign, ref int exp, ref ulong man, ref bool fFinite);
            static /*0x755c118*/ double GetDoubleFromParts(int sign, int exp, ulong man);
            static /*0x7559ec4*/ void DangerousMakeTwosComplement(uint[] d);
            static /*0x755a5b4*/ ulong MakeUlong(uint uHi, uint uLo);
            static /*0x755b2f0*/ uint Abs(int a);
            static /*0x75607d4*/ uint CombineHash(uint u1, uint u2);
            static /*0x755a3dc*/ int CombineHash(int n1, int n2);
            static /*0x755c0a0*/ int CbitHighZero(uint u);
            static /*0x75607b0*/ int CbitHighZero(ulong uu);
        }

        namespace Hashing
        {
            class HashHelpers
            {
                static /*0x0*/ int RandomSeed;

                static /*0x75607dc*/ HashHelpers();
                static /*0x7558524*/ int Combine(int h1, int h2);
            }
        }
    }

    namespace Globalization
    {
        class FormatProvider
        {
            static /*0x75602fc*/ void FormatBigInteger(ref System.Text.ValueStringBuilder sb, int precision, int scale, bool sign, System.ReadOnlySpan<char> format, System.Globalization.NumberFormatInfo numberFormatInfo, char[] digits, int startIndex);
            static /*0x755e8d8*/ bool TryStringToBigInteger(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles styles, System.Globalization.NumberFormatInfo numberFormatInfo, System.Text.StringBuilder receiver, ref int precision, ref int scale, ref bool sign);

            class Number
            {
                static /*0x0*/ string[] s_posCurrencyFormats;
                static /*0x8*/ string[] s_negCurrencyFormats;
                static /*0x10*/ string[] s_posPercentFormats;
                static /*0x18*/ string[] s_negPercentFormats;
                static /*0x20*/ string[] s_negNumberFormats;
                static /*0x28*/ string s_posNumberFormat;

                static /*0x75642fc*/ Number();
                static /*0x75620b8*/ bool IsWhite(char ch);
                static /*0x75620e0*/ char* MatchChars(char* p, char* pEnd, string str);
                static /*0x75621a4*/ char* MatchChars(char* p, char* pEnd, char* str);
                static /*0x7562200*/ bool ParseNumber(ref char* str, char* strEnd, System.Globalization.NumberStyles options, ref System.Globalization.FormatProvider.Number.NumberBuffer number, System.Text.StringBuilder sb, System.Globalization.NumberFormatInfo numfmt, bool parseDecimal);
                static /*0x7562904*/ bool TrailingZeros(System.ReadOnlySpan<char> s, int index);
                static /*0x7561f7c*/ bool TryStringToNumber(System.ReadOnlySpan<char> str, System.Globalization.NumberStyles options, ref System.Globalization.FormatProvider.Number.NumberBuffer number, System.Text.StringBuilder sb, System.Globalization.NumberFormatInfo numfmt, bool parseDecimal);
                static /*0x7562994*/ void Int32ToDecChars(char* buffer, ref int index, uint value, int digits);
                static /*0x7560848*/ char ParseFormatSpecifier(System.ReadOnlySpan<char> format, ref int digits);
                static /*0x756098c*/ void NumberToString(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, char format, int nMaxDigits, System.Globalization.NumberFormatInfo info, bool isDecimal);
                static /*0x7562ac0*/ void FormatCurrency(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info);
                static /*0x7563c98*/ int wcslen(char* s);
                static /*0x7562d20*/ void FormatFixed(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup);
                static /*0x756322c*/ void FormatNumber(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info);
                static /*0x7563474*/ void FormatScientific(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info, char expChar);
                static /*0x7563ec0*/ void FormatExponent(ref System.Text.ValueStringBuilder sb, System.Globalization.NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign);
                static /*0x75636b0*/ void FormatGeneral(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info, char expChar, bool bSuppressScientific);
                static /*0x7563a38*/ void FormatPercent(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info);
                static /*0x75629f0*/ void RoundNumber(ref System.Globalization.FormatProvider.Number.NumberBuffer number, int pos);
                static /*0x75641b0*/ int FindSection(System.ReadOnlySpan<char> format, int section);
                static /*0x7560ee4*/ void NumberToStringFormat(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, System.ReadOnlySpan<char> format, System.Globalization.NumberFormatInfo info);

                struct NumberBuffer
                {
                    /*0x10*/ int precision;
                    /*0x14*/ int scale;
                    /*0x18*/ bool sign;
                    /*0x20*/ char* overrideDigits;

                    /*0x7564c7c*/ char* get_digits();
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

            /*0x755f584*/ ValueStringBuilder(System.Span<char> initialBuffer);
            /*0x7564c84*/ int get_Length();
            /*0x755f848*/ string ToString();
            /*0x755f75c*/ bool TryCopyTo(System.Span<char> destination, ref int charsWritten);
            /*0x755f594*/ void Insert(int index, char value, int count);
            /*0x7564ed0*/ void Append(char c);
            /*0x7564fcc*/ void Append(string s);
            /*0x7565078*/ void AppendSlow(string s);
            /*0x7563d98*/ void Append(char c, int count);
            /*0x7563cb8*/ void Append(char* value, int length);
            /*0x75651a8*/ System.Span<char> AppendSpan(int length);
            /*0x7564f4c*/ void GrowAndAppend(char c);
            /*0x7564c8c*/ void Grow(int requiredAdditionalCapacity);
            /*0x7565264*/ void Dispose();
        }
    }

    namespace Runtime
    {
        namespace CompilerServices
        {
            class IntrinsicAttribute : System.Attribute
            {
                /*0x756535c*/ IntrinsicAttribute();
            }
        }
    }
}
