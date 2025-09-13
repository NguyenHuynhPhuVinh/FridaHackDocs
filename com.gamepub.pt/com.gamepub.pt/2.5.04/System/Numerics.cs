class <Module>
{
}

class SR
{
    static /*0x2a79ae0*/ string Format(string resourceFormat, object p1);
}

namespace System
{
    namespace Numerics
    {
        struct BigInteger : System.IFormattable, System.IComparable, System.IComparable<System.Numerics.BigInteger>, System.IEquatable<System.Numerics.BigInteger>
        {
            static /*0x0*/ System.Numerics.BigInteger s_bnMinInt;
            static /*0x10*/ System.Numerics.BigInteger s_bnOneInt;
            static /*0x20*/ System.Numerics.BigInteger s_bnZeroInt;
            static /*0x30*/ System.Numerics.BigInteger s_bnMinusOneInt;
            static /*0x40*/ byte[] s_success;
            /*0x10*/ int _sign;
            /*0x18*/ uint[] _bits;

            static /*0x2a78de0*/ BigInteger();
            static /*0x2a75ed8*/ System.Numerics.BigInteger get_Zero();
            static /*0x2a75f4c*/ System.Numerics.BigInteger Parse(string value, System.IFormatProvider provider);
            static /*0x2a75fe0*/ System.Numerics.BigInteger Parse(string value, System.Globalization.NumberStyles style, System.IFormatProvider provider);
            static /*0x2a77378*/ System.Numerics.BigInteger Add(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign);
            static /*0x2a77740*/ System.Numerics.BigInteger op_Subtraction(System.Numerics.BigInteger left, System.Numerics.BigInteger right);
            static /*0x2a77804*/ System.Numerics.BigInteger Subtract(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign);
            static /*0x2a77c48*/ System.Numerics.BigInteger op_Implicit(byte value);
            static /*0x2a77c74*/ System.Numerics.BigInteger op_Implicit(sbyte value);
            static /*0x2a77ca0*/ System.Numerics.BigInteger op_Implicit(short value);
            static /*0x2a77ccc*/ System.Numerics.BigInteger op_Implicit(ushort value);
            static /*0x2a77cf8*/ System.Numerics.BigInteger op_Implicit(int value);
            static /*0x2a77d24*/ System.Numerics.BigInteger op_Implicit(uint value);
            static /*0x2a77500*/ System.Numerics.BigInteger op_Implicit(long value);
            static /*0x2a75510*/ System.Numerics.BigInteger op_Implicit(ulong value);
            static /*0x2a77d50*/ byte op_Explicit(System.Numerics.BigInteger value);
            static /*0x2a77edc*/ sbyte op_Explicit(System.Numerics.BigInteger value);
            static /*0x2a77f78*/ short op_Explicit(System.Numerics.BigInteger value);
            static /*0x2a78014*/ ushort op_Explicit(System.Numerics.BigInteger value);
            static /*0x2a77dec*/ int op_Explicit(System.Numerics.BigInteger value);
            static /*0x2a780b0*/ uint op_Explicit(System.Numerics.BigInteger value);
            static /*0x2a7816c*/ long op_Explicit(System.Numerics.BigInteger value);
            static /*0x2a78234*/ ulong op_Explicit(System.Numerics.BigInteger value);
            static /*0x2a78300*/ float op_Explicit(System.Numerics.BigInteger value);
            static /*0x2a78378*/ double op_Explicit(System.Numerics.BigInteger value);
            static /*0x2a785b4*/ decimal op_Explicit(System.Numerics.BigInteger value);
            static /*0x2a7870c*/ System.Numerics.BigInteger op_UnaryNegation(System.Numerics.BigInteger value);
            static /*0x2a78714*/ System.Numerics.BigInteger op_Addition(System.Numerics.BigInteger left, System.Numerics.BigInteger right);
            static /*0x2a787d8*/ System.Numerics.BigInteger op_Multiply(System.Numerics.BigInteger left, System.Numerics.BigInteger right);
            static /*0x2a78c58*/ bool op_LessThanOrEqual(System.Numerics.BigInteger left, System.Numerics.BigInteger right);
            static /*0x2a78c8c*/ bool op_Inequality(System.Numerics.BigInteger left, System.Numerics.BigInteger right);
            static /*0x2a78cc0*/ bool op_LessThan(System.Numerics.BigInteger left, long right);
            static /*0x2a78cec*/ bool op_LessThanOrEqual(System.Numerics.BigInteger left, long right);
            static /*0x2a78d1c*/ bool op_Equality(System.Numerics.BigInteger left, long right);
            static /*0x2a78d48*/ bool op_Inequality(System.Numerics.BigInteger left, long right);
            static /*0x2a78d78*/ bool op_LessThan(long left, System.Numerics.BigInteger right);
            static /*0x2a78dac*/ bool op_LessThanOrEqual(long left, System.Numerics.BigInteger right);
            static /*0x2a762e8*/ int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu);
            /*0xb1fe78*/ BigInteger(int value);
            /*0xb1fe80*/ BigInteger(uint value);
            /*0xb1fe88*/ BigInteger(long value);
            /*0xb1fe90*/ BigInteger(ulong value);
            /*0xb1fe98*/ BigInteger(float value);
            /*0xb1fea4*/ BigInteger(double value);
            /*0xb1feac*/ BigInteger(decimal value);
            /*0xb1feb4*/ BigInteger(byte[] value);
            /*0xb1febc*/ BigInteger(System.ReadOnlySpan<byte> value);
            /*0xb1fef0*/ BigInteger(int n, uint[] rgu);
            /*0xb1fefc*/ BigInteger(uint[] value, bool negative);
            /*0xb1ff08*/ bool get_IsZero();
            /*0xb1ff18*/ int GetHashCode();
            /*0xb1ff20*/ bool Equals(object obj);
            /*0xb1ff28*/ bool Equals(long other);
            /*0xb1ff30*/ bool Equals(System.Numerics.BigInteger other);
            /*0xb1ff38*/ int CompareTo(long other);
            /*0xb1ff40*/ int CompareTo(System.Numerics.BigInteger other);
            /*0xb1ff48*/ int CompareTo(object obj);
            /*0xb1ff50*/ byte[] ToByteArray();
            /*0xb1ff88*/ byte[] TryGetBytes(System.Numerics.BigInteger.GetBytesMode mode, System.Span<byte> destination, ref int bytesWritten);
            /*0xb1ffbc*/ string ToString();
            /*0xb1fff0*/ string ToString(System.IFormatProvider provider);
            /*0xb20028*/ string ToString(string format, System.IFormatProvider provider);

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

            static /*0x2a79970*/ BigIntegerCalculator();
            static /*0x2a77538*/ uint[] Add(uint[] left, uint right);
            static /*0x2a77634*/ uint[] Add(uint[] left, uint[] right);
            static /*0x2a78f6c*/ void Add(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength);
            static /*0x2a78ff0*/ void AddSelf(uint* left, int leftLength, uint* right, int rightLength);
            static /*0x2a779d4*/ uint[] Subtract(uint[] left, uint right);
            static /*0x2a77b3c*/ uint[] Subtract(uint[] left, uint[] right);
            static /*0x2a7905c*/ void Subtract(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength);
            static /*0x2a77ab0*/ int Compare(uint[] left, uint[] right);
            static /*0x2a78a8c*/ uint[] Square(uint[] value);
            static /*0x2a790d4*/ void Square(uint* value, int valueLength, uint* bits, int bitsLength);
            static /*0x2a78994*/ uint[] Multiply(uint[] left, uint right);
            static /*0x2a78b5c*/ uint[] Multiply(uint[] left, uint[] right);
            static /*0x2a79520*/ void Multiply(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength);
            static /*0x2a79460*/ void SubtractCore(uint* left, int leftLength, uint* right, int rightLength, uint* core, int coreLength);
        }

        class BigNumber
        {
            static /*0x2a799e4*/ bool TryValidateParseStyleInteger(System.Globalization.NumberStyles style, ref System.ArgumentException e);
            static /*0x2a79b5c*/ bool TryParseBigInteger(System.ReadOnlySpan<char> value, System.Globalization.NumberStyles style, System.Globalization.NumberFormatInfo info, ref System.Numerics.BigInteger result);
            static /*0x2a76018*/ System.Numerics.BigInteger ParseBigInteger(string value, System.Globalization.NumberStyles style, System.Globalization.NumberFormatInfo info);
            static /*0x2a7a1dc*/ System.ReadOnlySpan<char> AsReadOnlySpan(string s);
            static /*0x2a7a254*/ System.Numerics.BigInteger ParseBigInteger(System.ReadOnlySpan<char> value, System.Globalization.NumberStyles style, System.Globalization.NumberFormatInfo info);
            static /*0x2a79e3c*/ bool HexNumberToBigInteger(ref System.Numerics.BigNumber.BigNumberBuffer number, ref System.Numerics.BigInteger value);
            static /*0x2a79fec*/ bool NumberToBigInteger(ref System.Numerics.BigNumber.BigNumberBuffer number, ref System.Numerics.BigInteger value);
            static /*0x2a7a3ac*/ char ParseFormatSpecifier(string format, ref int digits);
            static /*0x2a7a558*/ string FormatBigIntegerToHexString(System.Numerics.BigInteger value, char format, int digits, System.Globalization.NumberFormatInfo info);
            static /*0x2a76b3c*/ string FormatBigInteger(System.Numerics.BigInteger value, string format, System.Globalization.NumberFormatInfo info);

            struct BigNumberBuffer
            {
                /*0x10*/ System.Text.StringBuilder digits;
                /*0x18*/ int precision;
                /*0x1c*/ int scale;
                /*0x20*/ bool sign;

                static /*0x2a79cc4*/ System.Numerics.BigNumber.BigNumberBuffer Create();
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

            static /*0x2a7ad0c*/ Complex();
            /*0xb2006c*/ Complex(double real, double imaginary);
            /*0xb20074*/ double get_Real();
            /*0xb2007c*/ double get_Imaginary();
            /*0xb20084*/ bool Equals(object obj);
            /*0xb2008c*/ bool Equals(System.Numerics.Complex value);
            /*0xb20094*/ int GetHashCode();
            /*0xb200f4*/ string ToString();
            /*0xb200fc*/ string ToString(string format, System.IFormatProvider provider);
        }

        struct DoubleUlong
        {
            /*0x10*/ double dbl;
            /*0x10*/ ulong uu;
        }

        class NumericsHelpers
        {
            static /*0x2a75494*/ void GetDoubleParts(double dbl, ref int sign, ref int exp, ref ulong man, ref bool fFinite);
            static /*0x2a78508*/ double GetDoubleFromParts(int sign, int exp, ulong man);
            static /*0x2a75c44*/ void DangerousMakeTwosComplement(uint[] d);
            static /*0x2a762d8*/ ulong MakeUlong(uint uHi, uint uLo);
            static /*0x2a7752c*/ uint Abs(int a);
            static /*0x2a7c028*/ uint CombineHash(uint u1, uint u2);
            static /*0x2a76108*/ int CombineHash(int n1, int n2);
            static /*0x2a7848c*/ int CbitHighZero(uint u);
            static /*0x2a7c000*/ int CbitHighZero(ulong uu);
        }
    }

    namespace Globalization
    {
        class FormatProvider
        {
            static /*0x2a7a87c*/ string FormatBigInteger(int precision, int scale, bool sign, string format, System.Globalization.NumberFormatInfo numberFormatInfo, char[] digits, int startIndex);
            static /*0x2a79d24*/ bool TryStringToBigInteger(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles styles, System.Globalization.NumberFormatInfo numberFormatInfo, System.Text.StringBuilder receiver, ref int precision, ref int scale, ref bool sign);

            class Number
            {
                static /*0x0*/ string[] s_posCurrencyFormats;
                static /*0x8*/ string[] s_negCurrencyFormats;
                static /*0x10*/ string[] s_posPercentFormats;
                static /*0x18*/ string[] s_negPercentFormats;
                static /*0x20*/ string[] s_negNumberFormats;
                static /*0x28*/ string s_posNumberFormat;

                static /*0x2a7d918*/ Number();
                static /*0x2a7c030*/ bool IsWhite(char ch);
                static /*0x2a7c058*/ char* MatchChars(char* p, string str);
                static /*0x2a7c114*/ char* MatchChars(char* p, char* str);
                static /*0x2a7c160*/ bool ParseNumber(ref char* str, System.Globalization.NumberStyles options, ref System.Globalization.FormatProvider.Number.NumberBuffer number, System.Text.StringBuilder sb, System.Globalization.NumberFormatInfo numfmt, bool parseDecimal);
                static /*0x2a7c814*/ bool TrailingZeros(System.ReadOnlySpan<char> s, int index);
                static /*0x2a7bdd0*/ bool TryStringToNumber(System.ReadOnlySpan<char> str, System.Globalization.NumberStyles options, ref System.Globalization.FormatProvider.Number.NumberBuffer number, System.Text.StringBuilder sb, System.Globalization.NumberFormatInfo numfmt, bool parseDecimal);
                static /*0x2a7c8b0*/ void Int32ToDecChars(char* buffer, ref int index, uint value, int digits);
                static /*0x2a7adec*/ char ParseFormatSpecifier(string format, ref int digits);
                static /*0x2a7aea4*/ string NumberToString(System.Globalization.FormatProvider.Number.NumberBuffer number, char format, int nMaxDigits, System.Globalization.NumberFormatInfo info, bool isDecimal);
                static /*0x2a7c9ec*/ void FormatCurrency(System.Text.StringBuilder sb, System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info);
                static /*0x2a7d6c8*/ int wcslen(char* s);
                static /*0x2a7cbe4*/ void FormatFixed(System.Text.StringBuilder sb, System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup);
                static /*0x2a7cff0*/ void FormatNumber(System.Text.StringBuilder sb, System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info);
                static /*0x2a7d1d4*/ void FormatScientific(System.Text.StringBuilder sb, System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info, char expChar);
                static /*0x2a7d6e8*/ void FormatExponent(System.Text.StringBuilder sb, System.Globalization.NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign);
                static /*0x2a7d310*/ void FormatGeneral(System.Text.StringBuilder sb, System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info, char expChar, bool bSuppressScientific);
                static /*0x2a7d4d0*/ void FormatPercent(System.Text.StringBuilder sb, System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info);
                static /*0x2a7c908*/ void RoundNumber(ref System.Globalization.FormatProvider.Number.NumberBuffer number, int pos);
                static /*0x2a7d854*/ int FindSection(string format, int section);
                static /*0x2a7b394*/ string NumberToStringFormat(System.Globalization.FormatProvider.Number.NumberBuffer number, string format, System.Globalization.NumberFormatInfo info);

                struct NumberBuffer
                {
                    /*0x10*/ int precision;
                    /*0x14*/ int scale;
                    /*0x18*/ bool sign;
                    /*0x20*/ char* overrideDigits;

                    /*0xb20210*/ char* get_digits();
                }
            }
        }
    }
}
