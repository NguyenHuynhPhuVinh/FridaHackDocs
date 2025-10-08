class <Module>
{
}

namespace FixMath
{
    namespace NET
    {
        struct Fix64 : System.IEquatable<FixMath.NET.Fix64>, System.IComparable<FixMath.NET.Fix64>
        {
            static long MAX_VALUE = 9223372036854775807;
            static long MIN_VALUE = -9223372036854775808;
            static int NUM_BITS = 64;
            static int FRACTIONAL_PLACES = 32;
            static long ONE = 4294967296;
            static long PI_TIMES_2 = 26986075409;
            static long PI = 13493037704;
            static long PI_OVER_2 = 6746518852;
            static long LN2 = 2977044471;
            static long LOG2MAX = 133143986176;
            static long LOG2MIN = -137438953472;
            static long Cordic1K = 2608131496;
            static /*0x0*/ decimal Precision;
            static /*0x10*/ FixMath.NET.Fix64 MaxValue;
            static /*0x18*/ FixMath.NET.Fix64 MinValue;
            static /*0x20*/ FixMath.NET.Fix64 One;
            static /*0x28*/ FixMath.NET.Fix64 Zero;
            static /*0x30*/ FixMath.NET.Fix64 MinusOne;
            static /*0x38*/ FixMath.NET.Fix64 Pi;
            static /*0x40*/ FixMath.NET.Fix64 PiOver2;
            static /*0x48*/ FixMath.NET.Fix64 PiTimes2;
            static /*0x50*/ FixMath.NET.Fix64 PiInv;
            static /*0x58*/ FixMath.NET.Fix64 PiOver2Inv;
            static /*0x60*/ FixMath.NET.Fix64 Log2Max;
            static /*0x68*/ FixMath.NET.Fix64 Log2Min;
            static /*0x70*/ FixMath.NET.Fix64 Ln2;
            static /*0x78*/ long[] CordicLut;
            /*0x10*/ long m_rawValue;

            static /*0x2d56cfc*/ Fix64();
            static /*0x2d54ff8*/ FixMath.NET.Fix64 Abs(FixMath.NET.Fix64 value);
            static /*0x2d5506c*/ FixMath.NET.Fix64 Floor(FixMath.NET.Fix64 value);
            static /*0x2d55074*/ FixMath.NET.Fix64 Round(FixMath.NET.Fix64 value);
            static /*0x2d5512c*/ FixMath.NET.Fix64 op_Addition(FixMath.NET.Fix64 x, FixMath.NET.Fix64 y);
            static /*0x2d55150*/ FixMath.NET.Fix64 op_Subtraction(FixMath.NET.Fix64 x, FixMath.NET.Fix64 y);
            static /*0x2d55170*/ long AddOverflowHelper(long x, long y, ref bool overflow);
            static /*0x2d55194*/ FixMath.NET.Fix64 op_Multiply(FixMath.NET.Fix64 x, FixMath.NET.Fix64 y);
            static /*0x2d55300*/ FixMath.NET.Fix64 FastMul(FixMath.NET.Fix64 x, FixMath.NET.Fix64 y);
            static /*0x2d55320*/ int CountLeadingZeroes(ulong x);
            static /*0x2d55368*/ FixMath.NET.Fix64 op_Division(FixMath.NET.Fix64 x, FixMath.NET.Fix64 y);
            static /*0x2d55534*/ FixMath.NET.Fix64 op_UnaryNegation(FixMath.NET.Fix64 x);
            static /*0x2d555a4*/ bool op_Equality(FixMath.NET.Fix64 x, FixMath.NET.Fix64 y);
            static /*0x2d555b0*/ bool op_GreaterThan(FixMath.NET.Fix64 x, FixMath.NET.Fix64 y);
            static /*0x2d555bc*/ bool op_LessThan(FixMath.NET.Fix64 x, FixMath.NET.Fix64 y);
            static /*0x2d555c8*/ bool op_GreaterThanOrEqual(FixMath.NET.Fix64 x, FixMath.NET.Fix64 y);
            static /*0x2d555d4*/ bool op_LessThanOrEqual(FixMath.NET.Fix64 x, FixMath.NET.Fix64 y);
            static /*0x2d555e0*/ FixMath.NET.Fix64 Pow2(FixMath.NET.Fix64 x);
            static /*0x2d558cc*/ FixMath.NET.Fix64 Log2(FixMath.NET.Fix64 x);
            static /*0x2d55a3c*/ FixMath.NET.Fix64 Ln(FixMath.NET.Fix64 x);
            static /*0x2d55abc*/ FixMath.NET.Fix64 Pow(FixMath.NET.Fix64 b, FixMath.NET.Fix64 exp);
            static /*0x2d55be4*/ FixMath.NET.Fix64 Sqrt(FixMath.NET.Fix64 x);
            static /*0x2d55ce4*/ void FastSinCos(FixMath.NET.Fix64 angle, ref FixMath.NET.Fix64 sin, ref FixMath.NET.Fix64 cos);
            static /*0x2d55d78*/ long SinCosRaw(FixMath.NET.Fix64 angle, ref long sin, ref long cos, int n);
            static /*0x2d55fe8*/ FixMath.NET.Fix64 Atan(FixMath.NET.Fix64 z);
            static /*0x2d56348*/ FixMath.NET.Fix64 Atan2(FixMath.NET.Fix64 y, FixMath.NET.Fix64 x);
            static /*0x2d56898*/ FixMath.NET.Fix64 op_Explicit(long value);
            static /*0x2d568a0*/ long op_Explicit(FixMath.NET.Fix64 value);
            static /*0x2d568a8*/ FixMath.NET.Fix64 op_Explicit(float value);
            static /*0x2d568d0*/ float op_Explicit(FixMath.NET.Fix64 value);
            static /*0x2d568d8*/ FixMath.NET.Fix64 op_Explicit(double value);
            static /*0x2d56900*/ double op_Explicit(FixMath.NET.Fix64 value);
            static /*0x2d56908*/ FixMath.NET.Fix64 op_Explicit(decimal value);
            static /*0x2d569bc*/ decimal op_Explicit(FixMath.NET.Fix64 value);
            static /*0x2d56c7c*/ FixMath.NET.Fix64 FromRaw(long rawValue);
            static /*0x2d56c80*/ long AngleShift(long alpha, long beta);
            /*0x2d56ce8*/ Fix64(long rawValue);
            /*0x2d56cf0*/ Fix64(int value);
            /*0x2d56a78*/ bool Equals(object obj);
            /*0x2d56af0*/ int GetHashCode();
            /*0x2d56b0c*/ bool Equals(FixMath.NET.Fix64 other);
            /*0x2d56b1c*/ int CompareTo(FixMath.NET.Fix64 other);
            /*0x2d56b38*/ string ToString();
            /*0x2d56ce0*/ long get_RawValue();
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 4993B6317885AE3B36A946E87BA3081A0ACD9E4F;

    struct __StaticArrayInitTypeSize=216
    {
    }
}
