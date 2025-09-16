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
                /*0x7aeee14*/ Il2CppEagerStaticClassConstructionAttribute();
            }
        }
    }

    namespace Mathematics
    {
        class math
        {
            static /*0x7aeee1c*/ uint hash(Unity.Mathematics.bool2 v);
            static /*0x7aeee54*/ uint hash(Unity.Mathematics.bool3 v);
            static /*0x7aeeea8*/ uint hash(Unity.Mathematics.bool4 v);
            static /*0x7aeeef4*/ uint hash(Unity.Mathematics.bool4x4 v);
            static /*0x7aef0b4*/ Unity.Mathematics.float2 float2(float x, float y);
            static /*0x7aef0b8*/ uint hash(Unity.Mathematics.float2 v);
            static /*0x7aef0ec*/ Unity.Mathematics.float2x2 float2x2(Unity.Mathematics.float2 c0, Unity.Mathematics.float2 c1);
            static /*0x7aef0f0*/ float determinant(Unity.Mathematics.float2x2 m);
            static /*0x7aef100*/ uint hash(Unity.Mathematics.float2x2 v);
            static /*0x7aef158*/ Unity.Mathematics.float3 float3(float x, float y, float z);
            static /*0x7aef15c*/ Unity.Mathematics.float3 float3(float x, Unity.Mathematics.float2 yz);
            static /*0x7aef160*/ Unity.Mathematics.float3 float3(Unity.Mathematics.float2 xy, float z);
            static /*0x7aef164*/ uint hash(Unity.Mathematics.float3 v);
            static /*0x7aef1ac*/ Unity.Mathematics.float3x3 float3x3(Unity.Mathematics.float3 c0, Unity.Mathematics.float3 c1, Unity.Mathematics.float3 c2);
            static /*0x7aef1d4*/ Unity.Mathematics.float3x3 float3x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22);
            static /*0x7aef1f8*/ Unity.Mathematics.float3x3 transpose(Unity.Mathematics.float3x3 v);
            static /*0x7aef224*/ float determinant(Unity.Mathematics.float3x3 m);
            static /*0x7aef274*/ uint hash(Unity.Mathematics.float3x3 v);
            static /*0x7aef310*/ Unity.Mathematics.float4 float4(float x, float y, float z, float w);
            static /*0x7aef314*/ Unity.Mathematics.float4 float4(Unity.Mathematics.float2 xy, float z, float w);
            static /*0x7aef318*/ Unity.Mathematics.float4 float4(Unity.Mathematics.float2 xy, Unity.Mathematics.float2 zw);
            static /*0x7aef31c*/ Unity.Mathematics.float4 float4(Unity.Mathematics.float3 xyz, float w);
            static /*0x7aef320*/ uint hash(Unity.Mathematics.float4 v);
            static /*0x7aef380*/ Unity.Mathematics.float4x4 float4x4(Unity.Mathematics.float4 c0, Unity.Mathematics.float4 c1, Unity.Mathematics.float4 c2, Unity.Mathematics.float4 c3);
            static /*0x7aef3a4*/ Unity.Mathematics.float3 rotate(Unity.Mathematics.float4x4 a, Unity.Mathematics.float3 b);
            static /*0x7aef3ec*/ Unity.Mathematics.float3 transform(Unity.Mathematics.float4x4 a, Unity.Mathematics.float3 b);
            static /*0x7aef444*/ uint hash(Unity.Mathematics.float4x4 v);
            static /*0x7aef550*/ Unity.Mathematics.int2 int2(int x, int y);
            static /*0x7aef55c*/ uint hash(Unity.Mathematics.int2 v);
            static /*0x7aef58c*/ uint hash(Unity.Mathematics.int4 v);
            static /*0x7aef5e4*/ int asint(float x);
            static /*0x7aef5ec*/ Unity.Mathematics.uint2 asuint(Unity.Mathematics.int2 x);
            static /*0x7aef5f0*/ Unity.Mathematics.uint4 asuint(Unity.Mathematics.int4 x);
            static /*0x7aef5f4*/ uint asuint(float x);
            static /*0x7aef5fc*/ Unity.Mathematics.uint2 asuint(Unity.Mathematics.float2 x);
            static /*0x7aef60c*/ Unity.Mathematics.uint3 asuint(Unity.Mathematics.float3 x);
            static /*0x7aef620*/ Unity.Mathematics.uint4 asuint(Unity.Mathematics.float4 x);
            static /*0x7aef63c*/ float asfloat(uint x);
            static /*0x7aef644*/ Unity.Mathematics.float3 asfloat(Unity.Mathematics.uint3 x);
            static /*0x7aef658*/ Unity.Mathematics.float4 asfloat(Unity.Mathematics.uint4 x);
            static /*0x7aef674*/ bool isfinite(float x);
            static /*0x7aef68c*/ Unity.Mathematics.bool4 isnan(Unity.Mathematics.float4 x);
            static /*0x7aef6e0*/ int min(int x, int y);
            static /*0x7aef6ec*/ uint min(uint x, uint y);
            static /*0x7aef6f8*/ long min(long x, long y);
            static /*0x7aef704*/ float min(float x, float y);
            static /*0x7aef720*/ int max(int x, int y);
            static /*0x7aef72c*/ Unity.Mathematics.int2 max(Unity.Mathematics.int2 x, Unity.Mathematics.int2 y);
            static /*0x7aef74c*/ uint max(uint x, uint y);
            static /*0x7aef758*/ long max(long x, long y);
            static /*0x7aef764*/ float max(float x, float y);
            static /*0x7aef780*/ float lerp(float start, float end, float t);
            static /*0x7aef790*/ Unity.Mathematics.float3 lerp(Unity.Mathematics.float3 start, Unity.Mathematics.float3 end, float t);
            static /*0x7aef7b8*/ int clamp(int valueToClamp, int lowerBound, int upperBound);
            static /*0x7aef7cc*/ uint clamp(uint valueToClamp, uint lowerBound, uint upperBound);
            static /*0x7aef7e0*/ float clamp(float valueToClamp, float lowerBound, float upperBound);
            static /*0x7aef810*/ float saturate(float x);
            static /*0x7aef848*/ int abs(int x);
            static /*0x7aef858*/ float abs(float x);
            static /*0x7aef860*/ Unity.Mathematics.float3 abs(Unity.Mathematics.float3 x);
            static /*0x7aef870*/ Unity.Mathematics.float4 abs(Unity.Mathematics.float4 x);
            static /*0x7aef884*/ float dot(Unity.Mathematics.float2 x, Unity.Mathematics.float2 y);
            static /*0x7aef894*/ float dot(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y);
            static /*0x7aef8ac*/ float dot(Unity.Mathematics.float4 x, Unity.Mathematics.float4 y);
            static /*0x7aef8cc*/ float atan(float x);
            static /*0x7aef930*/ Unity.Mathematics.float2 atan(Unity.Mathematics.float2 x);
            static /*0x7aef9d4*/ float cos(float x);
            static /*0x7aefa38*/ Unity.Mathematics.float3 cos(Unity.Mathematics.float3 x);
            static /*0x7aefb24*/ float acos(float x);
            static /*0x7aefb88*/ float sin(float x);
            static /*0x7aefbec*/ Unity.Mathematics.float3 sin(Unity.Mathematics.float3 x);
            static /*0x7aefcd8*/ float floor(float x);
            static /*0x7aefd34*/ float ceil(float x);
            static /*0x7aefd90*/ float frac(float x);
            static /*0x7aefde8*/ float rcp(float x);
            static /*0x7aefdf4*/ Unity.Mathematics.float2 rcp(Unity.Mathematics.float2 x);
            static /*0x7aefe04*/ float pow(float x, float y);
            static /*0x7aefe74*/ float log2(float x);
            static /*0x7aefee0*/ float sqrt(float x);
            static /*0x7aeff3c*/ float rsqrt(float x);
            static /*0x7aeff98*/ Unity.Mathematics.float2 normalize(Unity.Mathematics.float2 x);
            static /*0x7af000c*/ Unity.Mathematics.float3 normalize(Unity.Mathematics.float3 x);
            static /*0x7af0098*/ Unity.Mathematics.float4 normalize(Unity.Mathematics.float4 x);
            static /*0x7af0134*/ Unity.Mathematics.float3 normalizesafe(Unity.Mathematics.float3 x, Unity.Mathematics.float3 defaultvalue);
            static /*0x7af01f4*/ float length(Unity.Mathematics.float2 x);
            static /*0x7af0258*/ float length(Unity.Mathematics.float3 x);
            static /*0x7af02d0*/ float length(Unity.Mathematics.float4 x);
            static /*0x7af0354*/ float lengthsq(float x);
            static /*0x7af035c*/ float lengthsq(Unity.Mathematics.float2 x);
            static /*0x7af036c*/ float lengthsq(Unity.Mathematics.float3 x);
            static /*0x7af0384*/ float lengthsq(Unity.Mathematics.float4 x);
            static /*0x7af03a4*/ float distance(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y);
            static /*0x7af043c*/ float distancesq(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y);
            static /*0x7af0460*/ float distancesq(Unity.Mathematics.float4 x, Unity.Mathematics.float4 y);
            static /*0x7af0490*/ Unity.Mathematics.float3 cross(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y);
            static /*0x7af04b8*/ bool any(Unity.Mathematics.bool2 x);
            static /*0x7af04c8*/ bool any(Unity.Mathematics.bool4 x);
            static /*0x7af04d8*/ bool all(Unity.Mathematics.bool3 x);
            static /*0x7af04f0*/ bool all(Unity.Mathematics.bool4 x);
            static /*0x7af0504*/ uint select(uint falseValue, uint trueValue, bool test);
            static /*0x7af0510*/ Unity.Mathematics.uint2 select(Unity.Mathematics.uint2 falseValue, Unity.Mathematics.uint2 trueValue, Unity.Mathematics.bool2 test);
            static /*0x7af0528*/ Unity.Mathematics.uint3 select(Unity.Mathematics.uint3 falseValue, Unity.Mathematics.uint3 trueValue, Unity.Mathematics.bool3 test);
            static /*0x7af054c*/ Unity.Mathematics.uint4 select(Unity.Mathematics.uint4 falseValue, Unity.Mathematics.uint4 trueValue, Unity.Mathematics.bool4 test);
            static /*0x7af0578*/ Unity.Mathematics.float3 select(Unity.Mathematics.float3 falseValue, Unity.Mathematics.float3 trueValue, bool test);
            static /*0x7af058c*/ Unity.Mathematics.float4 select(Unity.Mathematics.float4 falseValue, Unity.Mathematics.float4 trueValue, bool test);
            static /*0x7af05a4*/ void sincos(float x, ref float s, ref float c);
            static /*0x7af0658*/ void sincos(Unity.Mathematics.float3 x, ref Unity.Mathematics.float3 s, ref Unity.Mathematics.float3 c);
            static /*0x7af06bc*/ int countbits(ulong x);
            static /*0x7af06f0*/ int lzcnt(int x);
            static /*0x7af072c*/ int lzcnt(uint x);
            static /*0x7af0768*/ int tzcnt(int x);
            static /*0x7af07a4*/ int tzcnt(uint x);
            static /*0x7af07e0*/ int tzcnt(ulong x);
            static /*0x7af0834*/ int ceilpow2(int x);
            static /*0x7af0854*/ Unity.Mathematics.int2 ceilpow2(Unity.Mathematics.int2 x);
            static /*0x7af08e4*/ uint ceilpow2(uint x);
            static /*0x7af0904*/ int ceillog2(int x);
            static /*0x7af0940*/ int floorlog2(int x);
            static /*0x7af0978*/ float radians(float x);
            static /*0x7af0988*/ uint csum(Unity.Mathematics.uint2 x);
            static /*0x7af0994*/ uint csum(Unity.Mathematics.uint3 x);
            static /*0x7af09a4*/ uint csum(Unity.Mathematics.uint4 x);
            static /*0x7af09bc*/ float csum(Unity.Mathematics.float3 x);
            static /*0x7af09c8*/ float f16tof32(uint x);
            static /*0x7af0a24*/ Unity.Mathematics.float3 up();
            static /*0x7af0a34*/ Unity.Mathematics.float3 forward();
            static /*0x7af0a44*/ Unity.Mathematics.float3 right();
            static /*0x7af0a54*/ Unity.Mathematics.float3x3 float3x3(Unity.Mathematics.quaternion rotation);
            static /*0x7af0b4c*/ Unity.Mathematics.float3 mul(Unity.Mathematics.float3x3 a, Unity.Mathematics.float3 b);
            static /*0x7af0b94*/ Unity.Mathematics.float3x3 mul(Unity.Mathematics.float3x3 a, Unity.Mathematics.float3x3 b);
            static /*0x7af0c54*/ Unity.Mathematics.float4 mul(Unity.Mathematics.float4x4 a, Unity.Mathematics.float4 b);
            static /*0x7af0c88*/ Unity.Mathematics.float4x4 mul(Unity.Mathematics.float4x4 a, Unity.Mathematics.float4x4 b);
            static /*0x7af0d80*/ Unity.Mathematics.quaternion quaternion(Unity.Mathematics.float4 value);
            static /*0x7af0d84*/ Unity.Mathematics.quaternion quaternion(Unity.Mathematics.float3x3 m);
            static /*0x7af0f84*/ Unity.Mathematics.quaternion inverse(Unity.Mathematics.quaternion q);
            static /*0x7af0fc8*/ float lengthsq(Unity.Mathematics.quaternion q);
            static /*0x7af0fe8*/ Unity.Mathematics.quaternion mul(Unity.Mathematics.quaternion a, Unity.Mathematics.quaternion b);
            static /*0x7af105c*/ Unity.Mathematics.float3 mul(Unity.Mathematics.quaternion q, Unity.Mathematics.float3 v);
            static /*0x7af10d8*/ Unity.Mathematics.float3 rotate(Unity.Mathematics.quaternion q, Unity.Mathematics.float3 v);
            static /*0x7af1154*/ uint hash(Unity.Mathematics.quaternion q);
            static /*0x7af11b4*/ Unity.Mathematics.uint2 uint2(uint x, uint y);
            static /*0x7af11c0*/ uint hash(Unity.Mathematics.uint2 v);
            static /*0x7af11f0*/ Unity.Mathematics.uint3 uint3(uint x, uint y, uint z);
            static /*0x7af1200*/ uint hash(Unity.Mathematics.uint3 v);
            static /*0x7af1240*/ Unity.Mathematics.uint4 uint4(uint x, uint y, uint z, uint w);
            static /*0x7af1258*/ Unity.Mathematics.uint4 uint4(int v);
            static /*0x7af1268*/ uint hash(Unity.Mathematics.uint4 v);

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

            /*0x7af12c0*/ bool2(bool x, bool y);
            /*0x7af12d4*/ bool Equals(Unity.Mathematics.bool2 rhs);
            /*0x7af1300*/ bool Equals(object o);
            /*0x7af138c*/ int GetHashCode();
            /*0x7af13c8*/ string ToString();

            class DebuggerProxy
            {
            }
        }

        struct bool3 : System.IEquatable<Unity.Mathematics.bool3>
        {
            /*0x10*/ bool x;
            /*0x11*/ bool y;
            /*0x12*/ bool z;

            /*0x7af145c*/ bool3(bool x, bool y, bool z);
            /*0x7af1478*/ bool Equals(Unity.Mathematics.bool3 rhs);
            /*0x7af14b4*/ bool Equals(object o);
            /*0x7af1558*/ int GetHashCode();
            /*0x7af15b8*/ string ToString();

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

            static /*0x7af16a8*/ Unity.Mathematics.bool4 op_BitwiseOr(Unity.Mathematics.bool4 lhs, Unity.Mathematics.bool4 rhs);
            /*0x7af1670*/ bool4(bool x, bool y, bool z, bool w);
            /*0x7af1694*/ bool4(bool v);
            /*0x7af16b8*/ bool Equals(Unity.Mathematics.bool4 rhs);
            /*0x7af1704*/ bool Equals(object o);
            /*0x7af17b0*/ int GetHashCode();
            /*0x7af1804*/ string ToString();

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

            /*0x7af19d4*/ bool4x4(Unity.Mathematics.bool4 c0, Unity.Mathematics.bool4 c1, Unity.Mathematics.bool4 c2, Unity.Mathematics.bool4 c3);
            /*0x7af19e0*/ bool Equals(Unity.Mathematics.bool4x4 rhs);
            /*0x7af1aec*/ bool Equals(object o);
            /*0x7af1b68*/ int GetHashCode();
            /*0x7af1d2c*/ string ToString();
        }

        struct float2 : System.IEquatable<Unity.Mathematics.float2>, System.IFormattable
        {
            static /*0x0*/ Unity.Mathematics.float2 zero;
            /*0x10*/ float x;
            /*0x14*/ float y;

            static /*0x7af22bc*/ Unity.Mathematics.float2 op_Implicit(Unity.Mathematics.int2 v);
            static /*0x7af22cc*/ Unity.Mathematics.float2 op_Implicit(Unity.Mathematics.uint2 v);
            static /*0x7af22dc*/ Unity.Mathematics.float2 op_Multiply(Unity.Mathematics.float2 lhs, Unity.Mathematics.float2 rhs);
            static /*0x7af22e8*/ Unity.Mathematics.float2 op_Multiply(Unity.Mathematics.float2 lhs, float rhs);
            static /*0x7af22f4*/ Unity.Mathematics.float2 op_Multiply(float lhs, Unity.Mathematics.float2 rhs);
            static /*0x7af2304*/ Unity.Mathematics.float2 op_Addition(Unity.Mathematics.float2 lhs, Unity.Mathematics.float2 rhs);
            static /*0x7af2310*/ Unity.Mathematics.float2 op_Addition(Unity.Mathematics.float2 lhs, float rhs);
            static /*0x7af231c*/ Unity.Mathematics.float2 op_Addition(float lhs, Unity.Mathematics.float2 rhs);
            static /*0x7af232c*/ Unity.Mathematics.float2 op_Subtraction(Unity.Mathematics.float2 lhs, Unity.Mathematics.float2 rhs);
            static /*0x7af2338*/ Unity.Mathematics.float2 op_Division(Unity.Mathematics.float2 lhs, Unity.Mathematics.float2 rhs);
            static /*0x7af2344*/ Unity.Mathematics.float2 op_Division(Unity.Mathematics.float2 lhs, float rhs);
            static /*0x7af2350*/ Unity.Mathematics.float2 op_Division(float lhs, Unity.Mathematics.float2 rhs);
            static /*0x7af2360*/ Unity.Mathematics.float2 op_UnaryNegation(Unity.Mathematics.float2 val);
            static /*0x7af256c*/ UnityEngine.Vector2 op_Implicit(Unity.Mathematics.float2 v);
            static /*0x7af2570*/ Unity.Mathematics.float2 op_Implicit(UnityEngine.Vector2 v);
            /*0x7af228c*/ float2(float x, float y);
            /*0x7af2294*/ float2(Unity.Mathematics.int2 v);
            /*0x7af22a8*/ float2(Unity.Mathematics.uint2 v);
            /*0x7af236c*/ bool Equals(Unity.Mathematics.float2 rhs);
            /*0x7af2390*/ bool Equals(object o);
            /*0x7af2418*/ int GetHashCode();
            /*0x7af2448*/ string ToString();
            /*0x7af24dc*/ string ToString(string format, System.IFormatProvider formatProvider);

            class DebuggerProxy
            {
            }
        }

        struct float2x2 : System.IEquatable<Unity.Mathematics.float2x2>, System.IFormattable
        {
            static /*0x0*/ Unity.Mathematics.float2x2 identity;
            /*0x10*/ Unity.Mathematics.float2 c0;
            /*0x18*/ Unity.Mathematics.float2 c1;

            static /*0x7af2a54*/ float2x2();
            /*0x7af2574*/ float2x2(Unity.Mathematics.float2 c0, Unity.Mathematics.float2 c1);
            /*0x7af2580*/ float2x2(float m00, float m01, float m10, float m11);
            /*0x7af258c*/ bool Equals(Unity.Mathematics.float2x2 rhs);
            /*0x7af25c8*/ bool Equals(object o);
            /*0x7af2670*/ int GetHashCode();
            /*0x7af26c0*/ string ToString();
            /*0x7af2890*/ string ToString(string format, System.IFormatProvider formatProvider);
        }

        struct float3 : System.IEquatable<Unity.Mathematics.float3>, System.IFormattable
        {
            static /*0x0*/ Unity.Mathematics.float3 zero;
            /*0x10*/ float x;
            /*0x14*/ float y;
            /*0x18*/ float z;

            static /*0x7af2ae4*/ Unity.Mathematics.float3 op_Implicit(float v);
            static /*0x7af2af0*/ Unity.Mathematics.float3 op_Implicit(int v);
            static /*0x7af2b00*/ Unity.Mathematics.float3 op_Multiply(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs);
            static /*0x7af2b10*/ Unity.Mathematics.float3 op_Multiply(Unity.Mathematics.float3 lhs, float rhs);
            static /*0x7af2b20*/ Unity.Mathematics.float3 op_Multiply(float lhs, Unity.Mathematics.float3 rhs);
            static /*0x7af2b34*/ Unity.Mathematics.float3 op_Addition(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs);
            static /*0x7af2b44*/ Unity.Mathematics.float3 op_Subtraction(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs);
            static /*0x7af2b54*/ Unity.Mathematics.float3 op_Division(Unity.Mathematics.float3 lhs, float rhs);
            static /*0x7af2b64*/ Unity.Mathematics.float3 op_UnaryNegation(Unity.Mathematics.float3 val);
            static /*0x7af2b74*/ Unity.Mathematics.bool3 op_Equality(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs);
            static /*0x7af2b9c*/ Unity.Mathematics.bool3 op_Equality(Unity.Mathematics.float3 lhs, float rhs);
            static /*0x7af2ee0*/ UnityEngine.Vector3 op_Implicit(Unity.Mathematics.float3 v);
            static /*0x7af2ee4*/ Unity.Mathematics.float3 op_Implicit(UnityEngine.Vector3 v);
            /*0x7af2aa4*/ float3(float x, float y, float z);
            /*0x7af2ab0*/ float3(float x, Unity.Mathematics.float2 yz);
            /*0x7af2abc*/ float3(Unity.Mathematics.float2 xy, float z);
            /*0x7af2ac8*/ float3(float v);
            /*0x7af2ad4*/ float3(int v);
            /*0x7af2bc4*/ Unity.Mathematics.float4 get_xxxx();
            /*0x7af2bd8*/ Unity.Mathematics.float4 get_yxxy();
            /*0x7af2be8*/ Unity.Mathematics.float4 get_yyyy();
            /*0x7af2bfc*/ Unity.Mathematics.float4 get_zzyz();
            /*0x7af2c10*/ Unity.Mathematics.float4 get_zzzz();
            /*0x7af2c24*/ Unity.Mathematics.float3 get_xyz();
            /*0x7af2c30*/ Unity.Mathematics.float3 get_yzx();
            /*0x7af2c3c*/ Unity.Mathematics.float2 get_xy();
            /*0x7af2c44*/ Unity.Mathematics.float2 get_xz();
            /*0x7af2c50*/ Unity.Mathematics.float2 get_yz();
            /*0x7af2c58*/ float get_Item(int index);
            /*0x7af2c60*/ void set_Item(int index, float value);
            /*0x7af2c68*/ bool Equals(Unity.Mathematics.float3 rhs);
            /*0x7af2c98*/ bool Equals(object o);
            /*0x7af2d30*/ int GetHashCode();
            /*0x7af2d74*/ string ToString();
            /*0x7af2e2c*/ string ToString(string format, System.IFormatProvider formatProvider);

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

            static /*0x7af3850*/ float3x3();
            static /*0x7af3814*/ Unity.Mathematics.float3x3 op_Explicit(Unity.Mathematics.float4x4 f4x4);
            /*0x7af2ee8*/ float3x3(Unity.Mathematics.float3 c0, Unity.Mathematics.float3 c1, Unity.Mathematics.float3 c2);
            /*0x7af2f08*/ float3x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22);
            /*0x7af37e0*/ float3x3(Unity.Mathematics.float4x4 f4x4);
            /*0x7af0a68*/ float3x3(Unity.Mathematics.quaternion q);
            /*0x7af2f24*/ bool Equals(Unity.Mathematics.float3x3 rhs);
            /*0x7af2fc0*/ bool Equals(object o);
            /*0x7af30b8*/ int GetHashCode();
            /*0x7af3154*/ string ToString();
            /*0x7af34a0*/ string ToString(string format, System.IFormatProvider formatProvider);
        }

        struct float4 : System.IEquatable<Unity.Mathematics.float4>, System.IFormattable
        {
            static /*0x0*/ Unity.Mathematics.float4 zero;
            /*0x10*/ float x;
            /*0x14*/ float y;
            /*0x18*/ float z;
            /*0x1c*/ float w;

            static /*0x7af38fc*/ Unity.Mathematics.float4 op_Implicit(Unity.Mathematics.int4 v);
            static /*0x7af3918*/ Unity.Mathematics.float4 op_Multiply(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs);
            static /*0x7af392c*/ Unity.Mathematics.float4 op_Multiply(Unity.Mathematics.float4 lhs, float rhs);
            static /*0x7af3940*/ Unity.Mathematics.float4 op_Multiply(float lhs, Unity.Mathematics.float4 rhs);
            static /*0x7af3958*/ Unity.Mathematics.float4 op_Addition(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs);
            static /*0x7af396c*/ Unity.Mathematics.float4 op_Subtraction(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs);
            static /*0x7af3980*/ Unity.Mathematics.float4 op_Division(Unity.Mathematics.float4 lhs, float rhs);
            static /*0x7af3994*/ Unity.Mathematics.bool4 op_LessThan(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs);
            static /*0x7af39c8*/ Unity.Mathematics.bool4 op_Equality(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs);
            static /*0x7af3fa4*/ Unity.Mathematics.float4 op_Implicit(UnityEngine.Vector4 v);
            static /*0x7af3fa8*/ UnityEngine.Vector4 op_Implicit(Unity.Mathematics.float4 v);
            /*0x7af38a8*/ float4(float x, float y, float z, float w);
            /*0x7af38b4*/ float4(Unity.Mathematics.float2 xy, float z, float w);
            /*0x7af38c0*/ float4(Unity.Mathematics.float2 xy, Unity.Mathematics.float2 zw);
            /*0x7af38cc*/ float4(Unity.Mathematics.float3 xyz, float w);
            /*0x7af38d8*/ float4(Unity.Mathematics.int4 v);
            /*0x7af39fc*/ Unity.Mathematics.float4 get_xyzx();
            /*0x7af3a0c*/ Unity.Mathematics.float4 get_yzxy();
            /*0x7af3a1c*/ Unity.Mathematics.float4 get_yzxz();
            /*0x7af3a2c*/ Unity.Mathematics.float4 get_zxyy();
            /*0x7af3a3c*/ Unity.Mathematics.float4 get_zxyz();
            /*0x7af3a4c*/ Unity.Mathematics.float4 get_zwxy();
            /*0x7af3a58*/ Unity.Mathematics.float4 get_wzyx();
            /*0x7af3a64*/ Unity.Mathematics.float4 get_wwwx();
            /*0x7af3a78*/ Unity.Mathematics.float4 get_wwww();
            /*0x7af3a8c*/ Unity.Mathematics.float3 get_xyz();
            /*0x7af3a98*/ Unity.Mathematics.float3 get_yxw();
            /*0x7af3aa4*/ Unity.Mathematics.float3 get_zwx();
            /*0x7af3ab0*/ Unity.Mathematics.float3 get_wzy();
            /*0x7af3abc*/ Unity.Mathematics.float2 get_xy();
            /*0x7af3ac4*/ Unity.Mathematics.float2 get_zw();
            /*0x7af3acc*/ float get_Item(int index);
            /*0x7af3ad4*/ bool Equals(Unity.Mathematics.float4 rhs);
            /*0x7af3b10*/ bool Equals(object o);
            /*0x7af3bb8*/ int GetHashCode();
            /*0x7af3c10*/ string ToString();
            /*0x7af3de0*/ string ToString(string format, System.IFormatProvider formatProvider);

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

            static /*0x7af5204*/ float4x4();
            static /*0x7af400c*/ Unity.Mathematics.bool4x4 op_Equality(Unity.Mathematics.float4x4 lhs, Unity.Mathematics.float4x4 rhs);
            static /*0x7af4f4c*/ Unity.Mathematics.float4x4 op_Implicit(UnityEngine.Matrix4x4 m);
            static /*0x7af5030*/ UnityEngine.Matrix4x4 op_Implicit(Unity.Mathematics.float4x4 m);
            static /*0x7af5128*/ Unity.Mathematics.float4x4 TRS(Unity.Mathematics.float3 translation, Unity.Mathematics.quaternion rotation, Unity.Mathematics.float3 scale);
            /*0x7af3fac*/ float4x4(Unity.Mathematics.float4 c0, Unity.Mathematics.float4 c1, Unity.Mathematics.float4 c2, Unity.Mathematics.float4 c3);
            /*0x7af3fc8*/ float4x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33);
            /*0x7af5094*/ float4x4(Unity.Mathematics.quaternion rotation, Unity.Mathematics.float3 translation);
            /*0x7af4118*/ ref Unity.Mathematics.float4 get_Item(int index);
            /*0x7af4120*/ bool Equals(Unity.Mathematics.float4x4 rhs);
            /*0x7af422c*/ bool Equals(object o);
            /*0x7af4394*/ int GetHashCode();
            /*0x7af4498*/ string ToString();
            /*0x7af49f8*/ string ToString(string format, System.IFormatProvider formatProvider);
        }

        struct half : System.IEquatable<Unity.Mathematics.half>, System.IFormattable
        {
            /*0x10*/ ushort value;

            static /*0x7af5270*/ float get_MinValue();
            /*0x7af527c*/ bool Equals(Unity.Mathematics.half rhs);
            /*0x7af528c*/ bool Equals(object o);
            /*0x7af5304*/ int GetHashCode();
            /*0x7af530c*/ string ToString();
            /*0x7af5384*/ string ToString(string format, System.IFormatProvider formatProvider);
        }

        struct int2 : System.IEquatable<Unity.Mathematics.int2>, System.IFormattable
        {
            /*0x10*/ int x;
            /*0x14*/ int y;

            static /*0x7af540c*/ Unity.Mathematics.int2 op_Implicit(int v);
            static /*0x7af5418*/ Unity.Mathematics.int2 op_Addition(Unity.Mathematics.int2 lhs, Unity.Mathematics.int2 rhs);
            static /*0x7af5430*/ Unity.Mathematics.int2 op_Addition(Unity.Mathematics.int2 lhs, int rhs);
            static /*0x7af5444*/ Unity.Mathematics.int2 op_Subtraction(Unity.Mathematics.int2 lhs, int rhs);
            static /*0x7af5458*/ Unity.Mathematics.int2 op_Division(Unity.Mathematics.int2 lhs, int rhs);
            static /*0x7af546c*/ Unity.Mathematics.bool2 op_LessThan(Unity.Mathematics.int2 lhs, Unity.Mathematics.int2 rhs);
            static /*0x7af548c*/ Unity.Mathematics.int2 op_RightShift(Unity.Mathematics.int2 x, int n);
            static /*0x7af54a0*/ Unity.Mathematics.int2 op_BitwiseOr(Unity.Mathematics.int2 lhs, Unity.Mathematics.int2 rhs);
            /*0x7af53fc*/ int2(int x, int y);
            /*0x7af5404*/ int2(int v);
            /*0x7af54a8*/ Unity.Mathematics.int4 get_xyxy();
            /*0x7af54b4*/ bool Equals(Unity.Mathematics.int2 rhs);
            /*0x7af54dc*/ bool Equals(object o);
            /*0x7af5564*/ int GetHashCode();
            /*0x7af5598*/ string ToString();
            /*0x7af562c*/ string ToString(string format, System.IFormatProvider formatProvider);

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

            static /*0x7af5710*/ Unity.Mathematics.int4 op_Explicit(Unity.Mathematics.float4 v);
            /*0x7af56bc*/ int4(int x, int y, int z, int w);
            /*0x7af56c8*/ int4(Unity.Mathematics.float4 v);
            /*0x7af5764*/ Unity.Mathematics.int2 get_xy();
            /*0x7af576c*/ Unity.Mathematics.int2 get_zw();
            /*0x7af5774*/ int get_Item(int index);
            /*0x7af577c*/ bool Equals(Unity.Mathematics.int4 rhs);
            /*0x7af57c0*/ bool Equals(object o);
            /*0x7af5868*/ int GetHashCode();
            /*0x7af58c4*/ string ToString();
            /*0x7af5a94*/ string ToString(string format, System.IFormatProvider formatProvider);

            class DebuggerProxy
            {
            }
        }

        struct quaternion : System.IEquatable<Unity.Mathematics.quaternion>, System.IFormattable
        {
            static /*0x0*/ Unity.Mathematics.quaternion identity;
            /*0x10*/ Unity.Mathematics.float4 value;

            static /*0x7af6888*/ quaternion();
            static /*0x7af5c58*/ Unity.Mathematics.quaternion op_Implicit(UnityEngine.Quaternion q);
            static /*0x7af5e3c*/ Unity.Mathematics.quaternion AxisAngle(Unity.Mathematics.float3 axis, float angle);
            static /*0x7af5f14*/ Unity.Mathematics.quaternion EulerXYZ(Unity.Mathematics.float3 xyz);
            static /*0x7af5fc8*/ Unity.Mathematics.quaternion EulerXYZ(float x, float y, float z);
            static /*0x7af607c*/ Unity.Mathematics.quaternion LookRotationSafe(Unity.Mathematics.float3 forward, Unity.Mathematics.float3 up);
            /*0x7af5c5c*/ quaternion(float x, float y, float z, float w);
            /*0x7af5c68*/ quaternion(Unity.Mathematics.float4 value);
            /*0x7af0dc0*/ quaternion(Unity.Mathematics.float3x3 m);
            /*0x7af5c74*/ quaternion(Unity.Mathematics.float4x4 m);
            /*0x7af63b8*/ bool Equals(Unity.Mathematics.quaternion x);
            /*0x7af63f4*/ bool Equals(object x);
            /*0x7af649c*/ int GetHashCode();
            /*0x7af64f4*/ string ToString();
            /*0x7af66c4*/ string ToString(string format, System.IFormatProvider formatProvider);
        }

        struct uint2 : System.IEquatable<Unity.Mathematics.uint2>, System.IFormattable
        {
            /*0x10*/ uint x;
            /*0x14*/ uint y;

            static /*0x7af68e0*/ Unity.Mathematics.uint2 op_Multiply(Unity.Mathematics.uint2 lhs, Unity.Mathematics.uint2 rhs);
            static /*0x7af68f8*/ Unity.Mathematics.uint2 op_Addition(Unity.Mathematics.uint2 lhs, Unity.Mathematics.uint2 rhs);
            /*0x7af68d8*/ uint2(uint x, uint y);
            /*0x7af6910*/ bool Equals(Unity.Mathematics.uint2 rhs);
            /*0x7af6938*/ bool Equals(object o);
            /*0x7af69c0*/ int GetHashCode();
            /*0x7af69f4*/ string ToString();
            /*0x7af6a88*/ string ToString(string format, System.IFormatProvider formatProvider);

            class DebuggerProxy
            {
            }
        }

        struct uint3 : System.IEquatable<Unity.Mathematics.uint3>, System.IFormattable
        {
            /*0x10*/ uint x;
            /*0x14*/ uint y;
            /*0x18*/ uint z;

            static /*0x7af6b24*/ Unity.Mathematics.uint3 op_Multiply(Unity.Mathematics.uint3 lhs, Unity.Mathematics.uint3 rhs);
            static /*0x7af6b40*/ Unity.Mathematics.uint3 op_Addition(Unity.Mathematics.uint3 lhs, Unity.Mathematics.uint3 rhs);
            static /*0x7af6b5c*/ Unity.Mathematics.uint3 op_BitwiseAnd(Unity.Mathematics.uint3 lhs, uint rhs);
            static /*0x7af6b74*/ Unity.Mathematics.uint3 op_ExclusiveOr(Unity.Mathematics.uint3 lhs, Unity.Mathematics.uint3 rhs);
            /*0x7af6b18*/ uint3(uint x, uint y, uint z);
            /*0x7af6b80*/ bool Equals(Unity.Mathematics.uint3 rhs);
            /*0x7af6bb4*/ bool Equals(object o);
            /*0x7af6c4c*/ int GetHashCode();
            /*0x7af6c94*/ string ToString();
            /*0x7af6d4c*/ string ToString(string format, System.IFormatProvider formatProvider);

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

            static /*0x7af6e24*/ Unity.Mathematics.uint4 op_Implicit(uint v);
            static /*0x7af6e34*/ Unity.Mathematics.uint4 op_Multiply(Unity.Mathematics.uint4 lhs, Unity.Mathematics.uint4 rhs);
            static /*0x7af6e60*/ Unity.Mathematics.uint4 op_Addition(Unity.Mathematics.uint4 lhs, Unity.Mathematics.uint4 rhs);
            static /*0x7af6e8c*/ Unity.Mathematics.bool4 op_GreaterThan(Unity.Mathematics.uint4 lhs, uint rhs);
            static /*0x7af6ec4*/ Unity.Mathematics.uint4 op_OnesComplement(Unity.Mathematics.uint4 val);
            static /*0x7af6ed0*/ Unity.Mathematics.uint4 op_BitwiseAnd(Unity.Mathematics.uint4 lhs, Unity.Mathematics.uint4 rhs);
            static /*0x7af6edc*/ Unity.Mathematics.uint4 op_BitwiseAnd(Unity.Mathematics.uint4 lhs, uint rhs);
            static /*0x7af6f00*/ Unity.Mathematics.uint4 op_BitwiseOr(Unity.Mathematics.uint4 lhs, Unity.Mathematics.uint4 rhs);
            static /*0x7af6f0c*/ Unity.Mathematics.uint4 op_ExclusiveOr(Unity.Mathematics.uint4 lhs, Unity.Mathematics.uint4 rhs);
            /*0x7af6e00*/ uint4(uint x, uint y, uint z, uint w);
            /*0x7af6e0c*/ uint4(uint v);
            /*0x7af6e18*/ uint4(int v);
            /*0x7af6f18*/ void set_Item(int index, uint value);
            /*0x7af6f20*/ bool Equals(Unity.Mathematics.uint4 rhs);
            /*0x7af6f64*/ bool Equals(object o);
            /*0x7af700c*/ int GetHashCode();
            /*0x7af7068*/ string ToString();
            /*0x7af7238*/ string ToString(string format, System.IFormatProvider formatProvider);

            class DebuggerProxy
            {
            }
        }
    }
}
