class <Module>
{
}

class SR
{
    static /*0x179cfb4*/ string Format(string resourceFormat, object p1);
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

            static /*0x17a11f8*/ BigInteger();
            static /*0x179e094*/ System.Numerics.BigInteger get_Zero();
            static /*0x179e0ec*/ System.Numerics.BigInteger get_MinusOne();
            static /*0x179e154*/ System.Numerics.BigInteger Parse(string value, System.IFormatProvider provider);
            static /*0x179e1dc*/ System.Numerics.BigInteger Parse(string value, System.Globalization.NumberStyles style, System.IFormatProvider provider);
            static /*0x179eebc*/ System.Numerics.BigInteger Add(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign);
            static /*0x179f20c*/ System.Numerics.BigInteger op_Subtraction(System.Numerics.BigInteger left, System.Numerics.BigInteger right);
            static /*0x179f2b8*/ System.Numerics.BigInteger Subtract(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign);
            static /*0x179f670*/ System.Numerics.BigInteger op_Implicit(byte value);
            static /*0x179f698*/ System.Numerics.BigInteger op_Implicit(sbyte value);
            static /*0x179f6c0*/ System.Numerics.BigInteger op_Implicit(short value);
            static /*0x179f6e8*/ System.Numerics.BigInteger op_Implicit(ushort value);
            static /*0x179f710*/ System.Numerics.BigInteger op_Implicit(int value);
            static /*0x179f738*/ System.Numerics.BigInteger op_Implicit(uint value);
            static /*0x179f008*/ System.Numerics.BigInteger op_Implicit(long value);
            static /*0x179d660*/ System.Numerics.BigInteger op_Implicit(ulong value);
            static /*0x179f760*/ byte op_Explicit(System.Numerics.BigInteger value);
            static /*0x179f8cc*/ sbyte op_Explicit(System.Numerics.BigInteger value);
            static /*0x179f95c*/ short op_Explicit(System.Numerics.BigInteger value);
            static /*0x179f9ec*/ ushort op_Explicit(System.Numerics.BigInteger value);
            static /*0x179f7f0*/ int op_Explicit(System.Numerics.BigInteger value);
            static /*0x179fa7c*/ uint op_Explicit(System.Numerics.BigInteger value);
            static /*0x179fb28*/ long op_Explicit(System.Numerics.BigInteger value);
            static /*0x179fbd8*/ ulong op_Explicit(System.Numerics.BigInteger value);
            static /*0x179fc94*/ float op_Explicit(System.Numerics.BigInteger value);
            static /*0x179fd00*/ double op_Explicit(System.Numerics.BigInteger value);
            static /*0x179ff1c*/ decimal op_Explicit(System.Numerics.BigInteger value);
            static /*0x17a0084*/ System.Numerics.BigInteger op_LeftShift(System.Numerics.BigInteger value, int shift);
            static /*0x17a02d0*/ System.Numerics.BigInteger op_RightShift(System.Numerics.BigInteger value, int shift);
            static /*0x17a0694*/ System.Numerics.BigInteger op_UnaryNegation(System.Numerics.BigInteger value);
            static /*0x17a069c*/ System.Numerics.BigInteger op_Addition(System.Numerics.BigInteger left, System.Numerics.BigInteger right);
            static /*0x17a0748*/ System.Numerics.BigInteger op_Multiply(System.Numerics.BigInteger left, System.Numerics.BigInteger right);
            static /*0x17a0b60*/ System.Numerics.BigInteger op_Division(System.Numerics.BigInteger dividend, System.Numerics.BigInteger divisor);
            static /*0x17a0e30*/ System.Numerics.BigInteger op_Modulus(System.Numerics.BigInteger dividend, System.Numerics.BigInteger divisor);
            static /*0x17a1090*/ bool op_LessThanOrEqual(System.Numerics.BigInteger left, System.Numerics.BigInteger right);
            static /*0x17a10c0*/ bool op_Inequality(System.Numerics.BigInteger left, System.Numerics.BigInteger right);
            static /*0x17a10f0*/ bool op_LessThan(System.Numerics.BigInteger left, long right);
            static /*0x17a1118*/ bool op_LessThanOrEqual(System.Numerics.BigInteger left, long right);
            static /*0x17a1144*/ bool op_Equality(System.Numerics.BigInteger left, long right);
            static /*0x17a116c*/ bool op_Inequality(System.Numerics.BigInteger left, long right);
            static /*0x17a1198*/ bool op_LessThan(long left, System.Numerics.BigInteger right);
            static /*0x17a11c8*/ bool op_LessThanOrEqual(long left, System.Numerics.BigInteger right);
            static /*0x17a05d4*/ bool GetPartsForBitManipulation(ref System.Numerics.BigInteger x, ref uint[] xd, ref int xl);
            static /*0x179e4c4*/ int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu);
            /*0x179d024*/ BigInteger(int value);
            /*0x179d0a0*/ BigInteger(uint value);
            /*0x179d124*/ BigInteger(long value);
            /*0x179d23c*/ BigInteger(ulong value);
            /*0x179d2f8*/ BigInteger(float value);
            /*0x179d300*/ BigInteger(double value);
            /*0x179d688*/ BigInteger(decimal value);
            /*0x179d85c*/ BigInteger(byte[] value);
            /*0x179d8fc*/ BigInteger(System.ReadOnlySpan<byte> value, bool isUnsigned, bool isBigEndian);
            /*0x179dee4*/ BigInteger(int n, uint[] rgu);
            /*0x179def0*/ BigInteger(uint[] value, bool negative);
            /*0x179e144*/ bool get_IsZero();
            /*0x179e2c0*/ int GetHashCode();
            /*0x179e314*/ bool Equals(object obj);
            /*0x179e448*/ bool Equals(long other);
            /*0x179e38c*/ bool Equals(System.Numerics.BigInteger other);
            /*0x179e52c*/ int CompareTo(long other);
            /*0x179e5bc*/ int CompareTo(System.Numerics.BigInteger other);
            /*0x179e6e4*/ int CompareTo(object obj);
            /*0x179e7bc*/ byte[] ToByteArray();
            /*0x179e7e8*/ byte[] ToByteArray(bool isUnsigned, bool isBigEndian);
            /*0x179ed00*/ bool TryWriteBytes(System.Span<byte> destination, ref int bytesWritten, bool isUnsigned, bool isBigEndian);
            /*0x179ed40*/ bool TryWriteOrCountBytes(System.Span<byte> destination, ref int bytesWritten, bool isUnsigned, bool isBigEndian);
            /*0x179e814*/ byte[] TryGetBytes(System.Numerics.BigInteger.GetBytesMode mode, System.Span<byte> destination, bool isUnsigned, bool isBigEndian, ref int bytesWritten);
            /*0x179ed74*/ string ToString();
            /*0x179ee50*/ string ToString(System.IFormatProvider provider);
            /*0x179ee84*/ string ToString(string format, System.IFormatProvider provider);

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

            static /*0x17a21f0*/ BigIntegerCalculator();
            static /*0x179f03c*/ uint[] Add(uint[] left, uint right);
            static /*0x179f114*/ uint[] Add(uint[] left, uint[] right);
            static /*0x17a1338*/ void Add(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength);
            static /*0x17a13c0*/ void AddSelf(uint* left, int leftLength, uint* right, int rightLength);
            static /*0x179f438*/ uint[] Subtract(uint[] left, uint right);
            static /*0x179f570*/ uint[] Subtract(uint[] left, uint[] right);
            static /*0x17a142c*/ void Subtract(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength);
            static /*0x179f4f0*/ int Compare(uint[] left, uint[] right);
            static /*0x17a0ca0*/ uint[] Divide(uint[] left, uint right);
            static /*0x17a0f8c*/ uint Remainder(uint[] left, uint right);
            static /*0x17a0d54*/ uint[] Divide(uint[] left, uint[] right);
            static /*0x17a0ff0*/ uint[] Remainder(uint[] left, uint[] right);
            static /*0x17a1520*/ void Divide(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength);
            static /*0x17a192c*/ uint AddDivisor(uint* left, int leftLength, uint* right, int rightLength);
            static /*0x17a18e4*/ uint SubtractDivisor(uint* left, int leftLength, uint* right, int rightLength, ulong q);
            static /*0x17a1898*/ bool DivideGuessTooBig(ulong q, ulong valHi, uint valLo, uint divHi, uint divLo);
            static /*0x17a14a4*/ uint[] CreateCopy(uint[] value);
            static /*0x17a181c*/ int LeadingZeros(uint value);
            static /*0x17a09ac*/ uint[] Square(uint[] value);
            static /*0x17a196c*/ void Square(uint* value, int valueLength, uint* bits, int bitsLength);
            static /*0x17a08c8*/ uint[] Multiply(uint[] left, uint right);
            static /*0x17a0a70*/ uint[] Multiply(uint[] left, uint[] right);
            static /*0x17a1da4*/ void Multiply(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength);
            static /*0x17a1ce4*/ void SubtractCore(uint* left, int leftLength, uint* right, int rightLength, uint* core, int coreLength);
        }

        class BigNumber
        {
            static /*0x17a2240*/ bool TryValidateParseStyleInteger(System.Globalization.NumberStyles style, ref System.ArgumentException e);
            static /*0x17a233c*/ bool TryParseBigInteger(System.ReadOnlySpan<char> value, System.Globalization.NumberStyles style, System.Globalization.NumberFormatInfo info, ref System.Numerics.BigInteger result);
            static /*0x179e210*/ System.Numerics.BigInteger ParseBigInteger(string value, System.Globalization.NumberStyles style, System.Globalization.NumberFormatInfo info);
            static /*0x17a297c*/ System.Numerics.BigInteger ParseBigInteger(System.ReadOnlySpan<char> value, System.Globalization.NumberStyles style, System.Globalization.NumberFormatInfo info);
            static /*0x17a2618*/ bool HexNumberToBigInteger(ref System.Numerics.BigNumber.BigNumberBuffer number, ref System.Numerics.BigInteger value);
            static /*0x17a27b0*/ bool NumberToBigInteger(ref System.Numerics.BigNumber.BigNumberBuffer number, ref System.Numerics.BigInteger value);
            static /*0x17a2abc*/ char ParseFormatSpecifier(System.ReadOnlySpan<char> format, ref int digits);
            static /*0x17a2bac*/ string FormatBigIntegerToHex(bool targetSpan, System.Numerics.BigInteger value, char format, int digits, System.Globalization.NumberFormatInfo info, System.Span<char> destination, ref int charsWritten, ref bool spanSuccess);
            static /*0x179eda4*/ string FormatBigInteger(System.Numerics.BigInteger value, string format, System.Globalization.NumberFormatInfo info);
            static /*0x17a3794*/ string FormatBigInteger(bool targetSpan, System.Numerics.BigInteger value, string formatString, System.ReadOnlySpan<char> formatSpan, System.Globalization.NumberFormatInfo info, System.Span<char> destination, ref int charsWritten, ref bool spanSuccess);

            struct BigNumberBuffer
            {
                /*0x10*/ System.Text.StringBuilder digits;
                /*0x18*/ int precision;
                /*0x1c*/ int scale;
                /*0x20*/ bool sign;

                static /*0x17a2484*/ System.Numerics.BigNumber.BigNumberBuffer Create();
            }
        }

        struct DoubleUlong
        {
            /*0x10*/ double dbl;
            /*0x10*/ ulong uu;
        }

        class NumericsHelpers
        {
            static /*0x179d5e4*/ void GetDoubleParts(double dbl, ref int sign, ref int exp, ref ulong man, ref bool fFinite);
            static /*0x179fe7c*/ double GetDoubleFromParts(int sign, int exp, ulong man);
            static /*0x179de28*/ void DangerousMakeTwosComplement(uint[] d);
            static /*0x179e4b4*/ ulong MakeUlong(uint uHi, uint uLo);
            static /*0x179f030*/ uint Abs(int a);
            static /*0x17a42f8*/ uint CombineHash(uint u1, uint u2);
            static /*0x179e30c*/ int CombineHash(int n1, int n2);
            static /*0x179fe00*/ int CbitHighZero(uint u);
            static /*0x17a42d4*/ int CbitHighZero(ulong uu);
        }
    }

    namespace Globalization
    {
        class FormatProvider
        {
            static /*0x17a4194*/ void FormatBigInteger(ref System.Text.ValueStringBuilder sb, int precision, int scale, bool sign, System.ReadOnlySpan<char> format, System.Globalization.NumberFormatInfo numberFormatInfo, char[] digits, int startIndex);
            static /*0x17a2520*/ bool TryStringToBigInteger(System.ReadOnlySpan<char> s, System.Globalization.NumberStyles styles, System.Globalization.NumberFormatInfo numberFormatInfo, System.Text.StringBuilder receiver, ref int precision, ref int scale, ref bool sign);

            class Number
            {
                static /*0x0*/ string[] s_posCurrencyFormats;
                static /*0x8*/ string[] s_negCurrencyFormats;
                static /*0x10*/ string[] s_posPercentFormats;
                static /*0x18*/ string[] s_negPercentFormats;
                static /*0x20*/ string[] s_negNumberFormats;
                static /*0x28*/ string s_posNumberFormat;

                static /*0x17a7d54*/ Number();
                static /*0x17a5b40*/ bool IsWhite(char ch);
                static /*0x17a5b68*/ char* MatchChars(char* p, char* pEnd, string str);
                static /*0x17a5c2c*/ char* MatchChars(char* p, char* pEnd, char* str);
                static /*0x17a5c88*/ bool ParseNumber(ref char* str, char* strEnd, System.Globalization.NumberStyles options, ref System.Globalization.FormatProvider.Number.NumberBuffer number, System.Text.StringBuilder sb, System.Globalization.NumberFormatInfo numfmt, bool parseDecimal);
                static /*0x17a63a8*/ bool TrailingZeros(System.ReadOnlySpan<char> s, int index);
                static /*0x17a5a08*/ bool TryStringToNumber(System.ReadOnlySpan<char> str, System.Globalization.NumberStyles options, ref System.Globalization.FormatProvider.Number.NumberBuffer number, System.Text.StringBuilder sb, System.Globalization.NumberFormatInfo numfmt, bool parseDecimal);
                static /*0x17a6424*/ void Int32ToDecChars(char* buffer, ref int index, uint value, int digits);
                static /*0x17a4300*/ char ParseFormatSpecifier(System.ReadOnlySpan<char> format, ref int digits);
                static /*0x17a4440*/ void NumberToString(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, char format, int nMaxDigits, System.Globalization.NumberFormatInfo info, bool isDecimal);
                static /*0x17a6554*/ void FormatCurrency(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info);
                static /*0x17a7754*/ int wcslen(char* s);
                static /*0x17a67b4*/ void FormatFixed(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup);
                static /*0x17a6cd4*/ void FormatNumber(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info);
                static /*0x17a6f1c*/ void FormatScientific(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info, char expChar);
                static /*0x17a7930*/ void FormatExponent(ref System.Text.ValueStringBuilder sb, System.Globalization.NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign);
                static /*0x17a7158*/ void FormatGeneral(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info, char expChar, bool bSuppressScientific);
                static /*0x17a74f4*/ void FormatPercent(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info);
                static /*0x17a6480*/ void RoundNumber(ref System.Globalization.FormatProvider.Number.NumberBuffer number, int pos);
                static /*0x17a7c20*/ int FindSection(System.ReadOnlySpan<char> format, int section);
                static /*0x17a4988*/ void NumberToStringFormat(ref System.Text.ValueStringBuilder sb, ref System.Globalization.FormatProvider.Number.NumberBuffer number, System.ReadOnlySpan<char> format, System.Globalization.NumberFormatInfo info);

                struct NumberBuffer
                {
                    /*0x10*/ int precision;
                    /*0x14*/ int scale;
                    /*0x18*/ bool sign;
                    /*0x20*/ char* overrideDigits;

                    /*0x17a88a4*/ char* get_digits();
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

            /*0x17a3190*/ ValueStringBuilder(System.Span<char> initialBuffer);
            /*0x17a88ac*/ int get_Length();
            /*0x17a35fc*/ string ToString();
            /*0x17a3370*/ bool TryCopyTo(System.Span<char> destination, ref int charsWritten);
            /*0x17a31a0*/ void Insert(int index, char value, int count);
            /*0x17a8af8*/ void Append(char c);
            /*0x17a8bf4*/ void Append(string s);
            /*0x17a8ca0*/ void AppendSlow(string s);
            /*0x17a7854*/ void Append(char c, int count);
            /*0x17a7774*/ void Append(char* value, int length);
            /*0x17a8dd0*/ System.Span<char> AppendSpan(int length);
            /*0x17a8b74*/ void GrowAndAppend(char c);
            /*0x17a88b4*/ void Grow(int requiredAdditionalCapacity);
            /*0x17a8e90*/ void Dispose();
        }
    }
}
