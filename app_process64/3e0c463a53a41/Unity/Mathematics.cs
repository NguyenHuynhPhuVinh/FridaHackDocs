class <Module>
{
}

namespace Unity
{
    namespace IL2CPP
    {
        namespace CompilerServices
        {
            class Il2CppEagerStaticClassConstructionAttribute : System.Attribute
            {
                /*0x7ad79e4*/ Il2CppEagerStaticClassConstructionAttribute();
            }
        }
    }

    namespace Mathematics
    {
        class math
        {
            static /*0x7ad79ec*/ uint hash(Unity.Mathematics.bool2 v);
            static /*0x7ad7a24*/ uint hash(Unity.Mathematics.bool3 v);
            static /*0x7ad7a78*/ uint hash(Unity.Mathematics.bool4 v);
            static /*0x7ad7ac4*/ uint hash(Unity.Mathematics.bool4x4 v);
            static /*0x7ad7c84*/ Unity.Mathematics.float2 float2(float x, float y);
            static /*0x7ad7c88*/ uint hash(Unity.Mathematics.float2 v);
            static /*0x7ad7cbc*/ Unity.Mathematics.float2x2 float2x2(Unity.Mathematics.float2 c0, Unity.Mathematics.float2 c1);
            static /*0x7ad7cc0*/ float determinant(Unity.Mathematics.float2x2 m);
            static /*0x7ad7cd0*/ uint hash(Unity.Mathematics.float2x2 v);
            static /*0x7ad7d28*/ Unity.Mathematics.float3 float3(float x, float y, float z);
            static /*0x7ad7d2c*/ Unity.Mathematics.float3 float3(float x, Unity.Mathematics.float2 yz);
            static /*0x7ad7d30*/ Unity.Mathematics.float3 float3(Unity.Mathematics.float2 xy, float z);
            static /*0x7ad7d34*/ uint hash(Unity.Mathematics.float3 v);
            static /*0x7ad7d7c*/ Unity.Mathematics.float3x3 float3x3(Unity.Mathematics.float3 c0, Unity.Mathematics.float3 c1, Unity.Mathematics.float3 c2);
            static /*0x7ad7da4*/ Unity.Mathematics.float3x3 float3x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22);
            static /*0x7ad7dc8*/ Unity.Mathematics.float3x3 transpose(Unity.Mathematics.float3x3 v);
            static /*0x7ad7df4*/ float determinant(Unity.Mathematics.float3x3 m);
            static /*0x7ad7e44*/ uint hash(Unity.Mathematics.float3x3 v);
            static /*0x7ad7ee0*/ Unity.Mathematics.float4 float4(float x, float y, float z, float w);
            static /*0x7ad7ee4*/ Unity.Mathematics.float4 float4(Unity.Mathematics.float2 xy, float z, float w);
            static /*0x7ad7ee8*/ Unity.Mathematics.float4 float4(Unity.Mathematics.float2 xy, Unity.Mathematics.float2 zw);
            static /*0x7ad7eec*/ Unity.Mathematics.float4 float4(Unity.Mathematics.float3 xyz, float w);
            static /*0x7ad7ef0*/ uint hash(Unity.Mathematics.float4 v);
            static /*0x7ad7f50*/ Unity.Mathematics.float4x4 float4x4(Unity.Mathematics.float4 c0, Unity.Mathematics.float4 c1, Unity.Mathematics.float4 c2, Unity.Mathematics.float4 c3);
            static /*0x7ad7f74*/ Unity.Mathematics.float3 rotate(Unity.Mathematics.float4x4 a, Unity.Mathematics.float3 b);
            static /*0x7ad7fbc*/ Unity.Mathematics.float3 transform(Unity.Mathematics.float4x4 a, Unity.Mathematics.float3 b);
            static /*0x7ad8014*/ uint hash(Unity.Mathematics.float4x4 v);
            static /*0x7ad8120*/ Unity.Mathematics.int2 int2(int x, int y);
            static /*0x7ad812c*/ uint hash(Unity.Mathematics.int2 v);
            static /*0x7ad815c*/ uint hash(Unity.Mathematics.int4 v);
            static /*0x7ad81b4*/ int asint(float x);
            static /*0x7ad81bc*/ Unity.Mathematics.uint2 asuint(Unity.Mathematics.int2 x);
            static /*0x7ad81c0*/ Unity.Mathematics.uint4 asuint(Unity.Mathematics.int4 x);
            static /*0x7ad81c4*/ uint asuint(float x);
            static /*0x7ad81cc*/ Unity.Mathematics.uint2 asuint(Unity.Mathematics.float2 x);
            static /*0x7ad81dc*/ Unity.Mathematics.uint3 asuint(Unity.Mathematics.float3 x);
            static /*0x7ad81f0*/ Unity.Mathematics.uint4 asuint(Unity.Mathematics.float4 x);
            static /*0x7ad820c*/ float asfloat(uint x);
            static /*0x7ad8214*/ Unity.Mathematics.float3 asfloat(Unity.Mathematics.uint3 x);
            static /*0x7ad8228*/ Unity.Mathematics.float4 asfloat(Unity.Mathematics.uint4 x);
            static /*0x7ad8244*/ bool isfinite(float x);
            static /*0x7ad825c*/ Unity.Mathematics.bool4 isnan(Unity.Mathematics.float4 x);
            static /*0x7ad82b0*/ int min(int x, int y);
            static /*0x7ad82bc*/ uint min(uint x, uint y);
            static /*0x7ad82c8*/ long min(long x, long y);
            static /*0x7ad82d4*/ float min(float x, float y);
            static /*0x7ad82f0*/ int max(int x, int y);
            static /*0x7ad82fc*/ Unity.Mathematics.int2 max(Unity.Mathematics.int2 x, Unity.Mathematics.int2 y);
            static /*0x7ad831c*/ uint max(uint x, uint y);
            static /*0x7ad8328*/ long max(long x, long y);
            static /*0x7ad8334*/ float max(float x, float y);
            static /*0x7ad8350*/ float lerp(float start, float end, float t);
            static /*0x7ad8360*/ Unity.Mathematics.float3 lerp(Unity.Mathematics.float3 start, Unity.Mathematics.float3 end, float t);
            static /*0x7ad8388*/ int clamp(int valueToClamp, int lowerBound, int upperBound);
            static /*0x7ad839c*/ uint clamp(uint valueToClamp, uint lowerBound, uint upperBound);
            static /*0x7ad83b0*/ float clamp(float valueToClamp, float lowerBound, float upperBound);
            static /*0x7ad83e0*/ float saturate(float x);
            static /*0x7ad8418*/ int abs(int x);
            static /*0x7ad8428*/ float abs(float x);
            static /*0x7ad8430*/ Unity.Mathematics.float3 abs(Unity.Mathematics.float3 x);
            static /*0x7ad8440*/ Unity.Mathematics.float4 abs(Unity.Mathematics.float4 x);
            static /*0x7ad8454*/ float dot(Unity.Mathematics.float2 x, Unity.Mathematics.float2 y);
            static /*0x7ad8464*/ float dot(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y);
            static /*0x7ad847c*/ float dot(Unity.Mathematics.float4 x, Unity.Mathematics.float4 y);
            static /*0x7ad849c*/ float atan(float x);
            static /*0x7ad8500*/ Unity.Mathematics.float2 atan(Unity.Mathematics.float2 x);
            static /*0x7ad85a4*/ float cos(float x);
            static /*0x7ad8608*/ Unity.Mathematics.float3 cos(Unity.Mathematics.float3 x);
            static /*0x7ad86f4*/ float acos(float x);
            static /*0x7ad8758*/ float sin(float x);
            static /*0x7ad87bc*/ Unity.Mathematics.float3 sin(Unity.Mathematics.float3 x);
            static /*0x7ad88a8*/ float floor(float x);
            static /*0x7ad8904*/ float ceil(float x);
            static /*0x7ad8960*/ float frac(float x);
            static /*0x7ad89b8*/ float rcp(float x);
            static /*0x7ad89c4*/ Unity.Mathematics.float2 rcp(Unity.Mathematics.float2 x);
            static /*0x7ad89d4*/ float pow(float x, float y);
            static /*0x7ad8a44*/ float log2(float x);
            static /*0x7ad8ab0*/ float sqrt(float x);
            static /*0x7ad8b0c*/ float rsqrt(float x);
            static /*0x7ad8b68*/ Unity.Mathematics.float2 normalize(Unity.Mathematics.float2 x);
            static /*0x7ad8bdc*/ Unity.Mathematics.float3 normalize(Unity.Mathematics.float3 x);
            static /*0x7ad8c68*/ Unity.Mathematics.float4 normalize(Unity.Mathematics.float4 x);
            static /*0x7ad8d04*/ Unity.Mathematics.float3 normalizesafe(Unity.Mathematics.float3 x, Unity.Mathematics.float3 defaultvalue);
            static /*0x7ad8dc4*/ float length(Unity.Mathematics.float2 x);
            static /*0x7ad8e28*/ float length(Unity.Mathematics.float3 x);
            static /*0x7ad8ea0*/ float length(Unity.Mathematics.float4 x);
            static /*0x7ad8f24*/ float lengthsq(float x);
            static /*0x7ad8f2c*/ float lengthsq(Unity.Mathematics.float2 x);
            static /*0x7ad8f3c*/ float lengthsq(Unity.Mathematics.float3 x);
            static /*0x7ad8f54*/ float lengthsq(Unity.Mathematics.float4 x);
            static /*0x7ad8f74*/ float distance(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y);
            static /*0x7ad900c*/ float distancesq(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y);
            static /*0x7ad9030*/ float distancesq(Unity.Mathematics.float4 x, Unity.Mathematics.float4 y);
            static /*0x7ad9060*/ Unity.Mathematics.float3 cross(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y);
            static /*0x7ad9088*/ bool any(Unity.Mathematics.bool2 x);
            static /*0x7ad9098*/ bool any(Unity.Mathematics.bool4 x);
            static /*0x7ad90a8*/ bool all(Unity.Mathematics.bool3 x);
            static /*0x7ad90c0*/ bool all(Unity.Mathematics.bool4 x);
            static /*0x7ad90d4*/ uint select(uint falseValue, uint trueValue, bool test);
            static /*0x7ad90e0*/ Unity.Mathematics.uint2 select(Unity.Mathematics.uint2 falseValue, Unity.Mathematics.uint2 trueValue, Unity.Mathematics.bool2 test);
            static /*0x7ad90f8*/ Unity.Mathematics.uint3 select(Unity.Mathematics.uint3 falseValue, Unity.Mathematics.uint3 trueValue, Unity.Mathematics.bool3 test);
            static /*0x7ad911c*/ Unity.Mathematics.uint4 select(Unity.Mathematics.uint4 falseValue, Unity.Mathematics.uint4 trueValue, Unity.Mathematics.bool4 test);
            static /*0x7ad9148*/ Unity.Mathematics.float3 select(Unity.Mathematics.float3 falseValue, Unity.Mathematics.float3 trueValue, bool test);
            static /*0x7ad915c*/ Unity.Mathematics.float4 select(Unity.Mathematics.float4 falseValue, Unity.Mathematics.float4 trueValue, bool test);
            static /*0x7ad9174*/ void sincos(float x, ref float s, ref float c);
            static /*0x7ad9228*/ void sincos(Unity.Mathematics.float3 x, ref Unity.Mathematics.float3 s, ref Unity.Mathematics.float3 c);
            static /*0x7ad928c*/ int countbits(ulong x);
            static /*0x7ad92c0*/ int lzcnt(int x);
            static /*0x7ad92fc*/ int lzcnt(uint x);
            static /*0x7ad9338*/ int tzcnt(int x);
            static /*0x7ad9374*/ int tzcnt(uint x);
            static /*0x7ad93b0*/ int tzcnt(ulong x);
            static /*0x7ad9404*/ int ceilpow2(int x);
            static /*0x7ad9424*/ Unity.Mathematics.int2 ceilpow2(Unity.Mathematics.int2 x);
            static /*0x7ad94b4*/ uint ceilpow2(uint x);
            static /*0x7ad94d4*/ int ceillog2(int x);
            static /*0x7ad9510*/ int floorlog2(int x);
            static /*0x7ad9548*/ float radians(float x);
            static /*0x7ad9558*/ uint csum(Unity.Mathematics.uint2 x);
            static /*0x7ad9564*/ uint csum(Unity.Mathematics.uint3 x);
            static /*0x7ad9574*/ uint csum(Unity.Mathematics.uint4 x);
            static /*0x7ad958c*/ float csum(Unity.Mathematics.float3 x);
            static /*0x7ad9598*/ float f16tof32(uint x);
            static /*0x7ad95f4*/ Unity.Mathematics.float3 up();
            static /*0x7ad9604*/ Unity.Mathematics.float3 forward();
            static /*0x7ad9614*/ Unity.Mathematics.float3 right();
            static /*0x7ad9624*/ Unity.Mathematics.float3x3 float3x3(Unity.Mathematics.quaternion rotation);
            static /*0x7ad971c*/ Unity.Mathematics.float3 mul(Unity.Mathematics.float3x3 a, Unity.Mathematics.float3 b);
            static /*0x7ad9764*/ Unity.Mathematics.float3x3 mul(Unity.Mathematics.float3x3 a, Unity.Mathematics.float3x3 b);
            static /*0x7ad9824*/ Unity.Mathematics.float4 mul(Unity.Mathematics.float4x4 a, Unity.Mathematics.float4 b);
            static /*0x7ad9858*/ Unity.Mathematics.float4x4 mul(Unity.Mathematics.float4x4 a, Unity.Mathematics.float4x4 b);
            static /*0x7ad9950*/ Unity.Mathematics.quaternion quaternion(Unity.Mathematics.float4 value);
            static /*0x7ad9954*/ Unity.Mathematics.quaternion quaternion(Unity.Mathematics.float3x3 m);
            static /*0x7ad9b54*/ Unity.Mathematics.quaternion inverse(Unity.Mathematics.quaternion q);
            static /*0x7ad9b98*/ float lengthsq(Unity.Mathematics.quaternion q);
            static /*0x7ad9bb8*/ Unity.Mathematics.quaternion mul(Unity.Mathematics.quaternion a, Unity.Mathematics.quaternion b);
            static /*0x7ad9c2c*/ Unity.Mathematics.float3 mul(Unity.Mathematics.quaternion q, Unity.Mathematics.float3 v);
            static /*0x7ad9ca8*/ Unity.Mathematics.float3 rotate(Unity.Mathematics.quaternion q, Unity.Mathematics.float3 v);
            static /*0x7ad9d24*/ uint hash(Unity.Mathematics.quaternion q);
            static /*0x7ad9d84*/ Unity.Mathematics.uint2 uint2(uint x, uint y);
            static /*0x7ad9d90*/ uint hash(Unity.Mathematics.uint2 v);
            static /*0x7ad9dc0*/ Unity.Mathematics.uint3 uint3(uint x, uint y, uint z);
            static /*0x7ad9dd0*/ uint hash(Unity.Mathematics.uint3 v);
            static /*0x7ad9e10*/ Unity.Mathematics.uint4 uint4(uint x, uint y, uint z, uint w);
            static /*0x7ad9e28*/ Unity.Mathematics.uint4 uint4(int v);
            static /*0x7ad9e38*/ uint hash(Unity.Mathematics.uint4 v);

            struct LongDoubleUnion
            {
                /*0x10*/ long longValue;
                /*0x10*/ double doubleValue;
            }
        }

        struct bool2 : System.IEquatable<Unity.Mathematics.bool2>
        {
            /*0x10*/ bool x;
            /*0x11*/ bool y;

            /*0x7ad9e90*/ bool2(bool x, bool y);
            /*0x7ad9ea4*/ bool Equals(Unity.Mathematics.bool2 rhs);
            /*0x7ad9ed0*/ bool Equals(object o);
            /*0x7ad9f5c*/ int GetHashCode();
            /*0x7ad9f98*/ string ToString();

            class DebuggerProxy
            {
            }
        }

        struct bool3 : System.IEquatable<Unity.Mathematics.bool3>
        {
            /*0x10*/ bool x;
            /*0x11*/ bool y;
            /*0x12*/ bool z;

            /*0x7ada02c*/ bool3(bool x, bool y, bool z);
            /*0x7ada048*/ bool Equals(Unity.Mathematics.bool3 rhs);
            /*0x7ada084*/ bool Equals(object o);
            /*0x7ada128*/ int GetHashCode();
            /*0x7ada188*/ string ToString();

            class DebuggerProxy
            {
            }
        }

        struct bool4 : System.IEquatable<Unity.Mathematics.bool4>
        {
            /*0x10*/ bool x;
            /*0x11*/ bool y;
            /*0x12*/ bool z;
            /*0x13*/ bool w;

            static /*0x7ada278*/ Unity.Mathematics.bool4 op_BitwiseOr(Unity.Mathematics.bool4 lhs, Unity.Mathematics.bool4 rhs);
            /*0x7ada240*/ bool4(bool x, bool y, bool z, bool w);
            /*0x7ada264*/ bool4(bool v);
            /*0x7ada288*/ bool Equals(Unity.Mathematics.bool4 rhs);
            /*0x7ada2d4*/ bool Equals(object o);
            /*0x7ada380*/ int GetHashCode();
            /*0x7ada3d4*/ string ToString();

            class DebuggerProxy
            {
            }
        }

        struct bool4x4 : System.IEquatable<Unity.Mathematics.bool4x4>
        {
            /*0x10*/ Unity.Mathematics.bool4 c0;
            /*0x14*/ Unity.Mathematics.bool4 c1;
            /*0x18*/ Unity.Mathematics.bool4 c2;
            /*0x1c*/ Unity.Mathematics.bool4 c3;

            /*0x7ada5a4*/ bool4x4(Unity.Mathematics.bool4 c0, Unity.Mathematics.bool4 c1, Unity.Mathematics.bool4 c2, Unity.Mathematics.bool4 c3);
            /*0x7ada5b0*/ bool Equals(Unity.Mathematics.bool4x4 rhs);
            /*0x7ada6bc*/ bool Equals(object o);
            /*0x7ada738*/ int GetHashCode();
            /*0x7ada8fc*/ string ToString();
        }

        struct float2 : System.IEquatable<Unity.Mathematics.float2>, System.IFormattable
        {
            static /*0x0*/ Unity.Mathematics.float2 zero;
            /*0x10*/ float x;
            /*0x14*/ float y;

            static /*0x7adae8c*/ Unity.Mathematics.float2 op_Implicit(Unity.Mathematics.int2 v);
            static /*0x7adae9c*/ Unity.Mathematics.float2 op_Implicit(Unity.Mathematics.uint2 v);
            static /*0x7adaeac*/ Unity.Mathematics.float2 op_Multiply(Unity.Mathematics.float2 lhs, Unity.Mathematics.float2 rhs);
            static /*0x7adaeb8*/ Unity.Mathematics.float2 op_Multiply(Unity.Mathematics.float2 lhs, float rhs);
            static /*0x7adaec4*/ Unity.Mathematics.float2 op_Multiply(float lhs, Unity.Mathematics.float2 rhs);
            static /*0x7adaed4*/ Unity.Mathematics.float2 op_Addition(Unity.Mathematics.float2 lhs, Unity.Mathematics.float2 rhs);
            static /*0x7adaee0*/ Unity.Mathematics.float2 op_Addition(Unity.Mathematics.float2 lhs, float rhs);
            static /*0x7adaeec*/ Unity.Mathematics.float2 op_Addition(float lhs, Unity.Mathematics.float2 rhs);
            static /*0x7adaefc*/ Unity.Mathematics.float2 op_Subtraction(Unity.Mathematics.float2 lhs, Unity.Mathematics.float2 rhs);
            static /*0x7adaf08*/ Unity.Mathematics.float2 op_Division(Unity.Mathematics.float2 lhs, Unity.Mathematics.float2 rhs);
            static /*0x7adaf14*/ Unity.Mathematics.float2 op_Division(Unity.Mathematics.float2 lhs, float rhs);
            static /*0x7adaf20*/ Unity.Mathematics.float2 op_Division(float lhs, Unity.Mathematics.float2 rhs);
            static /*0x7adaf30*/ Unity.Mathematics.float2 op_UnaryNegation(Unity.Mathematics.float2 val);
            static /*0x7adb13c*/ UnityEngine.Vector2 op_Implicit(Unity.Mathematics.float2 v);
            static /*0x7adb140*/ Unity.Mathematics.float2 op_Implicit(UnityEngine.Vector2 v);
            /*0x7adae5c*/ float2(float x, float y);
            /*0x7adae64*/ float2(Unity.Mathematics.int2 v);
            /*0x7adae78*/ float2(Unity.Mathematics.uint2 v);
            /*0x7adaf3c*/ bool Equals(Unity.Mathematics.float2 rhs);
            /*0x7adaf60*/ bool Equals(object o);
            /*0x7adafe8*/ int GetHashCode();
            /*0x7adb018*/ string ToString();
            /*0x7adb0ac*/ string ToString(string format, System.IFormatProvider formatProvider);

            class DebuggerProxy
            {
            }
        }

        struct float2x2 : System.IEquatable<Unity.Mathematics.float2x2>, System.IFormattable
        {
            static /*0x0*/ Unity.Mathematics.float2x2 identity;
            /*0x10*/ Unity.Mathematics.float2 c0;
            /*0x18*/ Unity.Mathematics.float2 c1;

            static /*0x7adb624*/ float2x2();
            /*0x7adb144*/ float2x2(Unity.Mathematics.float2 c0, Unity.Mathematics.float2 c1);
            /*0x7adb150*/ float2x2(float m00, float m01, float m10, float m11);
            /*0x7adb15c*/ bool Equals(Unity.Mathematics.float2x2 rhs);
            /*0x7adb198*/ bool Equals(object o);
            /*0x7adb240*/ int GetHashCode();
            /*0x7adb290*/ string ToString();
            /*0x7adb460*/ string ToString(string format, System.IFormatProvider formatProvider);
        }

        struct float3 : System.IEquatable<Unity.Mathematics.float3>, System.IFormattable
        {
            static /*0x0*/ Unity.Mathematics.float3 zero;
            /*0x10*/ float x;
            /*0x14*/ float y;
            /*0x18*/ float z;

            static /*0x7adb6b4*/ Unity.Mathematics.float3 op_Implicit(float v);
            static /*0x7adb6c0*/ Unity.Mathematics.float3 op_Implicit(int v);
            static /*0x7adb6d0*/ Unity.Mathematics.float3 op_Multiply(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs);
            static /*0x7adb6e0*/ Unity.Mathematics.float3 op_Multiply(Unity.Mathematics.float3 lhs, float rhs);
            static /*0x7adb6f0*/ Unity.Mathematics.float3 op_Multiply(float lhs, Unity.Mathematics.float3 rhs);
            static /*0x7adb704*/ Unity.Mathematics.float3 op_Addition(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs);
            static /*0x7adb714*/ Unity.Mathematics.float3 op_Subtraction(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs);
            static /*0x7adb724*/ Unity.Mathematics.float3 op_Division(Unity.Mathematics.float3 lhs, float rhs);
            static /*0x7adb734*/ Unity.Mathematics.float3 op_UnaryNegation(Unity.Mathematics.float3 val);
            static /*0x7adb744*/ Unity.Mathematics.bool3 op_Equality(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs);
            static /*0x7adb76c*/ Unity.Mathematics.bool3 op_Equality(Unity.Mathematics.float3 lhs, float rhs);
            static /*0x7adbab0*/ UnityEngine.Vector3 op_Implicit(Unity.Mathematics.float3 v);
            static /*0x7adbab4*/ Unity.Mathematics.float3 op_Implicit(UnityEngine.Vector3 v);
            /*0x7adb674*/ float3(float x, float y, float z);
            /*0x7adb680*/ float3(float x, Unity.Mathematics.float2 yz);
            /*0x7adb68c*/ float3(Unity.Mathematics.float2 xy, float z);
            /*0x7adb698*/ float3(float v);
            /*0x7adb6a4*/ float3(int v);
            /*0x7adb794*/ Unity.Mathematics.float4 get_xxxx();
            /*0x7adb7a8*/ Unity.Mathematics.float4 get_yxxy();
            /*0x7adb7b8*/ Unity.Mathematics.float4 get_yyyy();
            /*0x7adb7cc*/ Unity.Mathematics.float4 get_zzyz();
            /*0x7adb7e0*/ Unity.Mathematics.float4 get_zzzz();
            /*0x7adb7f4*/ Unity.Mathematics.float3 get_xyz();
            /*0x7adb800*/ Unity.Mathematics.float3 get_yzx();
            /*0x7adb80c*/ Unity.Mathematics.float2 get_xy();
            /*0x7adb814*/ Unity.Mathematics.float2 get_xz();
            /*0x7adb820*/ Unity.Mathematics.float2 get_yz();
            /*0x7adb828*/ float get_Item(int index);
            /*0x7adb830*/ void set_Item(int index, float value);
            /*0x7adb838*/ bool Equals(Unity.Mathematics.float3 rhs);
            /*0x7adb868*/ bool Equals(object o);
            /*0x7adb900*/ int GetHashCode();
            /*0x7adb944*/ string ToString();
            /*0x7adb9fc*/ string ToString(string format, System.IFormatProvider formatProvider);

            class DebuggerProxy
            {
            }
        }

        struct float3x3 : System.IEquatable<Unity.Mathematics.float3x3>, System.IFormattable
        {
            static /*0x0*/ Unity.Mathematics.float3x3 identity;
            /*0x10*/ Unity.Mathematics.float3 c0;
            /*0x1c*/ Unity.Mathematics.float3 c1;
            /*0x28*/ Unity.Mathematics.float3 c2;

            static /*0x7adc420*/ float3x3();
            static /*0x7adc3e4*/ Unity.Mathematics.float3x3 op_Explicit(Unity.Mathematics.float4x4 f4x4);
            /*0x7adbab8*/ float3x3(Unity.Mathematics.float3 c0, Unity.Mathematics.float3 c1, Unity.Mathematics.float3 c2);
            /*0x7adbad8*/ float3x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22);
            /*0x7adc3b0*/ float3x3(Unity.Mathematics.float4x4 f4x4);
            /*0x7ad9638*/ float3x3(Unity.Mathematics.quaternion q);
            /*0x7adbaf4*/ bool Equals(Unity.Mathematics.float3x3 rhs);
            /*0x7adbb90*/ bool Equals(object o);
            /*0x7adbc88*/ int GetHashCode();
            /*0x7adbd24*/ string ToString();
            /*0x7adc070*/ string ToString(string format, System.IFormatProvider formatProvider);
        }

        struct float4 : System.IEquatable<Unity.Mathematics.float4>, System.IFormattable
        {
            static /*0x0*/ Unity.Mathematics.float4 zero;
            /*0x10*/ float x;
            /*0x14*/ float y;
            /*0x18*/ float z;
            /*0x1c*/ float w;

            static /*0x7adc4cc*/ Unity.Mathematics.float4 op_Implicit(Unity.Mathematics.int4 v);
            static /*0x7adc4e8*/ Unity.Mathematics.float4 op_Multiply(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs);
            static /*0x7adc4fc*/ Unity.Mathematics.float4 op_Multiply(Unity.Mathematics.float4 lhs, float rhs);
            static /*0x7adc510*/ Unity.Mathematics.float4 op_Multiply(float lhs, Unity.Mathematics.float4 rhs);
            static /*0x7adc528*/ Unity.Mathematics.float4 op_Addition(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs);
            static /*0x7adc53c*/ Unity.Mathematics.float4 op_Subtraction(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs);
            static /*0x7adc550*/ Unity.Mathematics.float4 op_Division(Unity.Mathematics.float4 lhs, float rhs);
            static /*0x7adc564*/ Unity.Mathematics.bool4 op_LessThan(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs);
            static /*0x7adc598*/ Unity.Mathematics.bool4 op_Equality(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs);
            static /*0x7adcb74*/ Unity.Mathematics.float4 op_Implicit(UnityEngine.Vector4 v);
            static /*0x7adcb78*/ UnityEngine.Vector4 op_Implicit(Unity.Mathematics.float4 v);
            /*0x7adc478*/ float4(float x, float y, float z, float w);
            /*0x7adc484*/ float4(Unity.Mathematics.float2 xy, float z, float w);
            /*0x7adc490*/ float4(Unity.Mathematics.float2 xy, Unity.Mathematics.float2 zw);
            /*0x7adc49c*/ float4(Unity.Mathematics.float3 xyz, float w);
            /*0x7adc4a8*/ float4(Unity.Mathematics.int4 v);
            /*0x7adc5cc*/ Unity.Mathematics.float4 get_xyzx();
            /*0x7adc5dc*/ Unity.Mathematics.float4 get_yzxy();
            /*0x7adc5ec*/ Unity.Mathematics.float4 get_yzxz();
            /*0x7adc5fc*/ Unity.Mathematics.float4 get_zxyy();
            /*0x7adc60c*/ Unity.Mathematics.float4 get_zxyz();
            /*0x7adc61c*/ Unity.Mathematics.float4 get_zwxy();
            /*0x7adc628*/ Unity.Mathematics.float4 get_wzyx();
            /*0x7adc634*/ Unity.Mathematics.float4 get_wwwx();
            /*0x7adc648*/ Unity.Mathematics.float4 get_wwww();
            /*0x7adc65c*/ Unity.Mathematics.float3 get_xyz();
            /*0x7adc668*/ Unity.Mathematics.float3 get_yxw();
            /*0x7adc674*/ Unity.Mathematics.float3 get_zwx();
            /*0x7adc680*/ Unity.Mathematics.float3 get_wzy();
            /*0x7adc68c*/ Unity.Mathematics.float2 get_xy();
            /*0x7adc694*/ Unity.Mathematics.float2 get_zw();
            /*0x7adc69c*/ float get_Item(int index);
            /*0x7adc6a4*/ bool Equals(Unity.Mathematics.float4 rhs);
            /*0x7adc6e0*/ bool Equals(object o);
            /*0x7adc788*/ int GetHashCode();
            /*0x7adc7e0*/ string ToString();
            /*0x7adc9b0*/ string ToString(string format, System.IFormatProvider formatProvider);

            class DebuggerProxy
            {
            }
        }

        struct float4x4 : System.IEquatable<Unity.Mathematics.float4x4>, System.IFormattable
        {
            static /*0x0*/ Unity.Mathematics.float4x4 identity;
            static /*0x40*/ Unity.Mathematics.float4x4 zero;
            /*0x10*/ Unity.Mathematics.float4 c0;
            /*0x20*/ Unity.Mathematics.float4 c1;
            /*0x30*/ Unity.Mathematics.float4 c2;
            /*0x40*/ Unity.Mathematics.float4 c3;

            static /*0x7adddd4*/ float4x4();
            static /*0x7adcbdc*/ Unity.Mathematics.bool4x4 op_Equality(Unity.Mathematics.float4x4 lhs, Unity.Mathematics.float4x4 rhs);
            static /*0x7addb1c*/ Unity.Mathematics.float4x4 op_Implicit(UnityEngine.Matrix4x4 m);
            static /*0x7addc00*/ UnityEngine.Matrix4x4 op_Implicit(Unity.Mathematics.float4x4 m);
            static /*0x7addcf8*/ Unity.Mathematics.float4x4 TRS(Unity.Mathematics.float3 translation, Unity.Mathematics.quaternion rotation, Unity.Mathematics.float3 scale);
            /*0x7adcb7c*/ float4x4(Unity.Mathematics.float4 c0, Unity.Mathematics.float4 c1, Unity.Mathematics.float4 c2, Unity.Mathematics.float4 c3);
            /*0x7adcb98*/ float4x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33);
            /*0x7addc64*/ float4x4(Unity.Mathematics.quaternion rotation, Unity.Mathematics.float3 translation);
            /*0x7adcce8*/ ref Unity.Mathematics.float4 get_Item(int index);
            /*0x7adccf0*/ bool Equals(Unity.Mathematics.float4x4 rhs);
            /*0x7adcdfc*/ bool Equals(object o);
            /*0x7adcf64*/ int GetHashCode();
            /*0x7add068*/ string ToString();
            /*0x7add5c8*/ string ToString(string format, System.IFormatProvider formatProvider);
        }

        struct half : System.IEquatable<Unity.Mathematics.half>, System.IFormattable
        {
            /*0x10*/ ushort value;

            static /*0x7adde40*/ float get_MinValue();
            /*0x7adde4c*/ bool Equals(Unity.Mathematics.half rhs);
            /*0x7adde5c*/ bool Equals(object o);
            /*0x7added4*/ int GetHashCode();
            /*0x7addedc*/ string ToString();
            /*0x7addf54*/ string ToString(string format, System.IFormatProvider formatProvider);
        }

        struct int2 : System.IEquatable<Unity.Mathematics.int2>, System.IFormattable
        {
            /*0x10*/ int x;
            /*0x14*/ int y;

            static /*0x7addfdc*/ Unity.Mathematics.int2 op_Implicit(int v);
            static /*0x7addfe8*/ Unity.Mathematics.int2 op_Addition(Unity.Mathematics.int2 lhs, Unity.Mathematics.int2 rhs);
            static /*0x7ade000*/ Unity.Mathematics.int2 op_Addition(Unity.Mathematics.int2 lhs, int rhs);
            static /*0x7ade014*/ Unity.Mathematics.int2 op_Subtraction(Unity.Mathematics.int2 lhs, int rhs);
            static /*0x7ade028*/ Unity.Mathematics.int2 op_Division(Unity.Mathematics.int2 lhs, int rhs);
            static /*0x7ade03c*/ Unity.Mathematics.bool2 op_LessThan(Unity.Mathematics.int2 lhs, Unity.Mathematics.int2 rhs);
            static /*0x7ade05c*/ Unity.Mathematics.int2 op_RightShift(Unity.Mathematics.int2 x, int n);
            static /*0x7ade070*/ Unity.Mathematics.int2 op_BitwiseOr(Unity.Mathematics.int2 lhs, Unity.Mathematics.int2 rhs);
            /*0x7addfcc*/ int2(int x, int y);
            /*0x7addfd4*/ int2(int v);
            /*0x7ade078*/ Unity.Mathematics.int4 get_xyxy();
            /*0x7ade084*/ bool Equals(Unity.Mathematics.int2 rhs);
            /*0x7ade0ac*/ bool Equals(object o);
            /*0x7ade134*/ int GetHashCode();
            /*0x7ade168*/ string ToString();
            /*0x7ade1fc*/ string ToString(string format, System.IFormatProvider formatProvider);

            class DebuggerProxy
            {
            }
        }

        struct int4 : System.IEquatable<Unity.Mathematics.int4>, System.IFormattable
        {
            /*0x10*/ int x;
            /*0x14*/ int y;
            /*0x18*/ int z;
            /*0x1c*/ int w;

            static /*0x7ade2e0*/ Unity.Mathematics.int4 op_Explicit(Unity.Mathematics.float4 v);
            /*0x7ade28c*/ int4(int x, int y, int z, int w);
            /*0x7ade298*/ int4(Unity.Mathematics.float4 v);
            /*0x7ade334*/ Unity.Mathematics.int2 get_xy();
            /*0x7ade33c*/ Unity.Mathematics.int2 get_zw();
            /*0x7ade344*/ int get_Item(int index);
            /*0x7ade34c*/ bool Equals(Unity.Mathematics.int4 rhs);
            /*0x7ade390*/ bool Equals(object o);
            /*0x7ade438*/ int GetHashCode();
            /*0x7ade494*/ string ToString();
            /*0x7ade664*/ string ToString(string format, System.IFormatProvider formatProvider);

            class DebuggerProxy
            {
            }
        }

        struct quaternion : System.IEquatable<Unity.Mathematics.quaternion>, System.IFormattable
        {
            static /*0x0*/ Unity.Mathematics.quaternion identity;
            /*0x10*/ Unity.Mathematics.float4 value;

            static /*0x7adf458*/ quaternion();
            static /*0x7ade828*/ Unity.Mathematics.quaternion op_Implicit(UnityEngine.Quaternion q);
            static /*0x7adea0c*/ Unity.Mathematics.quaternion AxisAngle(Unity.Mathematics.float3 axis, float angle);
            static /*0x7adeae4*/ Unity.Mathematics.quaternion EulerXYZ(Unity.Mathematics.float3 xyz);
            static /*0x7adeb98*/ Unity.Mathematics.quaternion EulerXYZ(float x, float y, float z);
            static /*0x7adec4c*/ Unity.Mathematics.quaternion LookRotationSafe(Unity.Mathematics.float3 forward, Unity.Mathematics.float3 up);
            /*0x7ade82c*/ quaternion(float x, float y, float z, float w);
            /*0x7ade838*/ quaternion(Unity.Mathematics.float4 value);
            /*0x7ad9990*/ quaternion(Unity.Mathematics.float3x3 m);
            /*0x7ade844*/ quaternion(Unity.Mathematics.float4x4 m);
            /*0x7adef88*/ bool Equals(Unity.Mathematics.quaternion x);
            /*0x7adefc4*/ bool Equals(object x);
            /*0x7adf06c*/ int GetHashCode();
            /*0x7adf0c4*/ string ToString();
            /*0x7adf294*/ string ToString(string format, System.IFormatProvider formatProvider);
        }

        struct uint2 : System.IEquatable<Unity.Mathematics.uint2>, System.IFormattable
        {
            /*0x10*/ uint x;
            /*0x14*/ uint y;

            static /*0x7adf4b0*/ Unity.Mathematics.uint2 op_Multiply(Unity.Mathematics.uint2 lhs, Unity.Mathematics.uint2 rhs);
            static /*0x7adf4c8*/ Unity.Mathematics.uint2 op_Addition(Unity.Mathematics.uint2 lhs, Unity.Mathematics.uint2 rhs);
            /*0x7adf4a8*/ uint2(uint x, uint y);
            /*0x7adf4e0*/ bool Equals(Unity.Mathematics.uint2 rhs);
            /*0x7adf508*/ bool Equals(object o);
            /*0x7adf590*/ int GetHashCode();
            /*0x7adf5c4*/ string ToString();
            /*0x7adf658*/ string ToString(string format, System.IFormatProvider formatProvider);

            class DebuggerProxy
            {
            }
        }

        struct uint3 : System.IEquatable<Unity.Mathematics.uint3>, System.IFormattable
        {
            /*0x10*/ uint x;
            /*0x14*/ uint y;
            /*0x18*/ uint z;

            static /*0x7adf6f4*/ Unity.Mathematics.uint3 op_Multiply(Unity.Mathematics.uint3 lhs, Unity.Mathematics.uint3 rhs);
            static /*0x7adf710*/ Unity.Mathematics.uint3 op_Addition(Unity.Mathematics.uint3 lhs, Unity.Mathematics.uint3 rhs);
            static /*0x7adf72c*/ Unity.Mathematics.uint3 op_BitwiseAnd(Unity.Mathematics.uint3 lhs, uint rhs);
            static /*0x7adf744*/ Unity.Mathematics.uint3 op_ExclusiveOr(Unity.Mathematics.uint3 lhs, Unity.Mathematics.uint3 rhs);
            /*0x7adf6e8*/ uint3(uint x, uint y, uint z);
            /*0x7adf750*/ bool Equals(Unity.Mathematics.uint3 rhs);
            /*0x7adf784*/ bool Equals(object o);
            /*0x7adf81c*/ int GetHashCode();
            /*0x7adf864*/ string ToString();
            /*0x7adf91c*/ string ToString(string format, System.IFormatProvider formatProvider);

            class DebuggerProxy
            {
            }
        }

        struct uint4 : System.IEquatable<Unity.Mathematics.uint4>, System.IFormattable
        {
            static /*0x0*/ Unity.Mathematics.uint4 zero;
            /*0x10*/ uint x;
            /*0x14*/ uint y;
            /*0x18*/ uint z;
            /*0x1c*/ uint w;

            static /*0x7adf9f4*/ Unity.Mathematics.uint4 op_Implicit(uint v);
            static /*0x7adfa04*/ Unity.Mathematics.uint4 op_Multiply(Unity.Mathematics.uint4 lhs, Unity.Mathematics.uint4 rhs);
            static /*0x7adfa30*/ Unity.Mathematics.uint4 op_Addition(Unity.Mathematics.uint4 lhs, Unity.Mathematics.uint4 rhs);
            static /*0x7adfa5c*/ Unity.Mathematics.bool4 op_GreaterThan(Unity.Mathematics.uint4 lhs, uint rhs);
            static /*0x7adfa94*/ Unity.Mathematics.uint4 op_OnesComplement(Unity.Mathematics.uint4 val);
            static /*0x7adfaa0*/ Unity.Mathematics.uint4 op_BitwiseAnd(Unity.Mathematics.uint4 lhs, Unity.Mathematics.uint4 rhs);
            static /*0x7adfaac*/ Unity.Mathematics.uint4 op_BitwiseAnd(Unity.Mathematics.uint4 lhs, uint rhs);
            static /*0x7adfad0*/ Unity.Mathematics.uint4 op_BitwiseOr(Unity.Mathematics.uint4 lhs, Unity.Mathematics.uint4 rhs);
            static /*0x7adfadc*/ Unity.Mathematics.uint4 op_ExclusiveOr(Unity.Mathematics.uint4 lhs, Unity.Mathematics.uint4 rhs);
            /*0x7adf9d0*/ uint4(uint x, uint y, uint z, uint w);
            /*0x7adf9dc*/ uint4(uint v);
            /*0x7adf9e8*/ uint4(int v);
            /*0x7adfae8*/ void set_Item(int index, uint value);
            /*0x7adfaf0*/ bool Equals(Unity.Mathematics.uint4 rhs);
            /*0x7adfb34*/ bool Equals(object o);
            /*0x7adfbdc*/ int GetHashCode();
            /*0x7adfc38*/ string ToString();
            /*0x7adfe08*/ string ToString(string format, System.IFormatProvider formatProvider);

            class DebuggerProxy
            {
            }
        }
    }
}
