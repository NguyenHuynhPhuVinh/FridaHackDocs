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
                /*0x3ac1914*/ Il2CppEagerStaticClassConstructionAttribute();
            }
        }
    }

    namespace Mathematics
    {
        class math
        {
            static /*0x3ac191c*/ uint hash(Unity.Mathematics.bool2 v);
            static /*0x3ac1954*/ uint hash(Unity.Mathematics.bool4 v);
            static /*0x3ac199c*/ Unity.Mathematics.float2 float2(float x, float y);
            static /*0x3ac19a0*/ uint hash(Unity.Mathematics.float2 v);
            static /*0x3ac19d4*/ Unity.Mathematics.float2x2 float2x2(Unity.Mathematics.float2 c0, Unity.Mathematics.float2 c1);
            static /*0x3ac19d8*/ float determinant(Unity.Mathematics.float2x2 m);
            static /*0x3ac19e8*/ uint hash(Unity.Mathematics.float2x2 v);
            static /*0x3ac1a40*/ Unity.Mathematics.float3 float3(float x, float y, float z);
            static /*0x3ac1a44*/ Unity.Mathematics.float3 float3(float x, Unity.Mathematics.float2 yz);
            static /*0x3ac1a48*/ Unity.Mathematics.float3 float3(Unity.Mathematics.float2 xy, float z);
            static /*0x3ac1a4c*/ uint hash(Unity.Mathematics.float3 v);
            static /*0x3ac1a94*/ Unity.Mathematics.float3x3 float3x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22);
            static /*0x3ac1ab8*/ Unity.Mathematics.float3x3 transpose(Unity.Mathematics.float3x3 v);
            static /*0x3ac1ae8*/ float determinant(Unity.Mathematics.float3x3 m);
            static /*0x3ac1b3c*/ uint hash(Unity.Mathematics.float3x3 v);
            static /*0x3ac1bdc*/ Unity.Mathematics.float4 float4(float x, float y, float z, float w);
            static /*0x3ac1be0*/ Unity.Mathematics.float4 float4(Unity.Mathematics.float2 xy, float z, float w);
            static /*0x3ac1be4*/ Unity.Mathematics.float4 float4(Unity.Mathematics.float2 xy, Unity.Mathematics.float2 zw);
            static /*0x3ac1be8*/ Unity.Mathematics.float4 float4(Unity.Mathematics.float3 xyz, float w);
            static /*0x3ac1bec*/ uint hash(Unity.Mathematics.float4 v);
            static /*0x3ac1c4c*/ Unity.Mathematics.float4x4 float4x4(Unity.Mathematics.float4 c0, Unity.Mathematics.float4 c1, Unity.Mathematics.float4 c2, Unity.Mathematics.float4 c3);
            static /*0x3ac1c78*/ Unity.Mathematics.float3 transform(Unity.Mathematics.float4x4 a, Unity.Mathematics.float3 b);
            static /*0x3ac1cd0*/ uint hash(Unity.Mathematics.float4x4 v);
            static /*0x3ac1dfc*/ Unity.Mathematics.int2 int2(int x, int y);
            static /*0x3ac1e08*/ uint hash(Unity.Mathematics.int2 v);
            static /*0x3ac1e38*/ uint hash(Unity.Mathematics.int3 v);
            static /*0x3ac1e78*/ uint hash(Unity.Mathematics.int4 v);
            static /*0x3ac1ed0*/ Unity.Mathematics.uint2 asuint(Unity.Mathematics.int2 x);
            static /*0x3ac1ed4*/ Unity.Mathematics.uint3 asuint(Unity.Mathematics.int3 x);
            static /*0x3ac1edc*/ Unity.Mathematics.uint4 asuint(Unity.Mathematics.int4 x);
            static /*0x3ac1ee0*/ uint asuint(float x);
            static /*0x3ac1ee8*/ Unity.Mathematics.uint2 asuint(Unity.Mathematics.float2 x);
            static /*0x3ac1ef8*/ Unity.Mathematics.uint3 asuint(Unity.Mathematics.float3 x);
            static /*0x3ac1f0c*/ Unity.Mathematics.uint4 asuint(Unity.Mathematics.float4 x);
            static /*0x3ac1f28*/ float asfloat(uint x);
            static /*0x3ac1f30*/ Unity.Mathematics.float3 asfloat(Unity.Mathematics.uint3 x);
            static /*0x3ac1f44*/ Unity.Mathematics.float4 asfloat(Unity.Mathematics.uint4 x);
            static /*0x3ac1f60*/ Unity.Mathematics.bool4 isnan(Unity.Mathematics.float4 x);
            static /*0x3ac1fb4*/ int min(int x, int y);
            static /*0x3ac1fc0*/ uint min(uint x, uint y);
            static /*0x3ac1fcc*/ long min(long x, long y);
            static /*0x3ac1fd8*/ float min(float x, float y);
            static /*0x3ac1ff4*/ Unity.Mathematics.float3 min(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y);
            static /*0x3ac2038*/ Unity.Mathematics.float4 min(Unity.Mathematics.float4 x, Unity.Mathematics.float4 y);
            static /*0x3ac2090*/ int max(int x, int y);
            static /*0x3ac209c*/ Unity.Mathematics.int2 max(Unity.Mathematics.int2 x, Unity.Mathematics.int2 y);
            static /*0x3ac20bc*/ uint max(uint x, uint y);
            static /*0x3ac20c8*/ long max(long x, long y);
            static /*0x3ac20d4*/ float max(float x, float y);
            static /*0x3ac20f0*/ Unity.Mathematics.float3 max(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y);
            static /*0x3ac2134*/ Unity.Mathematics.float4 max(Unity.Mathematics.float4 x, Unity.Mathematics.float4 y);
            static /*0x3ac218c*/ float lerp(float start, float end, float t);
            static /*0x3ac219c*/ Unity.Mathematics.float3 lerp(Unity.Mathematics.float3 start, Unity.Mathematics.float3 end, float t);
            static /*0x3ac21c4*/ int clamp(int valueToClamp, int lowerBound, int upperBound);
            static /*0x3ac21d8*/ uint clamp(uint valueToClamp, uint lowerBound, uint upperBound);
            static /*0x3ac21ec*/ float clamp(float valueToClamp, float lowerBound, float upperBound);
            static /*0x3ac221c*/ float saturate(float x);
            static /*0x3ac2254*/ float abs(float x);
            static /*0x3ac225c*/ Unity.Mathematics.float3 abs(Unity.Mathematics.float3 x);
            static /*0x3ac226c*/ Unity.Mathematics.float4 abs(Unity.Mathematics.float4 x);
            static /*0x3ac2280*/ float dot(Unity.Mathematics.float2 x, Unity.Mathematics.float2 y);
            static /*0x3ac2290*/ float dot(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y);
            static /*0x3ac22a8*/ float dot(Unity.Mathematics.float4 x, Unity.Mathematics.float4 y);
            static /*0x3ac22c8*/ float atan(float x);
            static /*0x3ac232c*/ Unity.Mathematics.float2 atan(Unity.Mathematics.float2 x);
            static /*0x3ac23d8*/ float cos(float x);
            static /*0x3ac243c*/ Unity.Mathematics.float3 cos(Unity.Mathematics.float3 x);
            static /*0x3ac2530*/ float sin(float x);
            static /*0x3ac2594*/ Unity.Mathematics.float3 sin(Unity.Mathematics.float3 x);
            static /*0x3ac2688*/ float rcp(float x);
            static /*0x3ac2694*/ Unity.Mathematics.float2 rcp(Unity.Mathematics.float2 x);
            static /*0x3ac26a4*/ float log2(float x);
            static /*0x3ac2710*/ float sqrt(float x);
            static /*0x3ac276c*/ float rsqrt(float x);
            static /*0x3ac27c8*/ Unity.Mathematics.float2 normalize(Unity.Mathematics.float2 x);
            static /*0x3ac283c*/ Unity.Mathematics.float3 normalize(Unity.Mathematics.float3 x);
            static /*0x3ac28c8*/ float length(Unity.Mathematics.float2 x);
            static /*0x3ac292c*/ float length(Unity.Mathematics.float3 x);
            static /*0x3ac29a4*/ float length(Unity.Mathematics.float4 x);
            static /*0x3ac2a28*/ float lengthsq(float x);
            static /*0x3ac2a30*/ float lengthsq(Unity.Mathematics.float2 x);
            static /*0x3ac2a40*/ float lengthsq(Unity.Mathematics.float3 x);
            static /*0x3ac2a58*/ float lengthsq(Unity.Mathematics.float4 x);
            static /*0x3ac2a78*/ float distance(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y);
            static /*0x3ac2b10*/ float distancesq(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y);
            static /*0x3ac2b34*/ float distancesq(Unity.Mathematics.float4 x, Unity.Mathematics.float4 y);
            static /*0x3ac2b64*/ Unity.Mathematics.float3 cross(Unity.Mathematics.float3 x, Unity.Mathematics.float3 y);
            static /*0x3ac2b8c*/ bool any(Unity.Mathematics.bool2 x);
            static /*0x3ac2b9c*/ bool any(Unity.Mathematics.bool4 x);
            static /*0x3ac2bac*/ uint select(uint falseValue, uint trueValue, bool test);
            static /*0x3ac2bb8*/ Unity.Mathematics.uint2 select(Unity.Mathematics.uint2 falseValue, Unity.Mathematics.uint2 trueValue, Unity.Mathematics.bool2 test);
            static /*0x3ac2bd0*/ Unity.Mathematics.uint4 select(Unity.Mathematics.uint4 falseValue, Unity.Mathematics.uint4 trueValue, Unity.Mathematics.bool4 test);
            static /*0x3ac2bfc*/ void sincos(Unity.Mathematics.float3 x, ref Unity.Mathematics.float3 s, ref Unity.Mathematics.float3 c);
            static /*0x3ac2c60*/ int countbits(ulong x);
            static /*0x3ac2c74*/ int lzcnt(int x);
            static /*0x3ac2cb0*/ int lzcnt(uint x);
            static /*0x3ac2cec*/ int tzcnt(int x);
            static /*0x3ac2d28*/ int tzcnt(uint x);
            static /*0x3ac2d64*/ int tzcnt(ulong x);
            static /*0x3ac2db8*/ uint rol(uint x, int n);
            static /*0x3ac2dc4*/ Unity.Mathematics.uint4 rol(Unity.Mathematics.uint4 x, int n);
            static /*0x3ac2dfc*/ int ceilpow2(int x);
            static /*0x3ac2e1c*/ Unity.Mathematics.int2 ceilpow2(Unity.Mathematics.int2 x);
            static /*0x3ac2ea4*/ uint ceilpow2(uint x);
            static /*0x3ac2ec4*/ int ceillog2(int x);
            static /*0x3ac2efc*/ int floorlog2(int x);
            static /*0x3ac2f34*/ float radians(float x);
            static /*0x3ac2f44*/ uint csum(Unity.Mathematics.uint2 x);
            static /*0x3ac2f50*/ uint csum(Unity.Mathematics.uint3 x);
            static /*0x3ac2f60*/ uint csum(Unity.Mathematics.uint4 x);
            static /*0x3ac2f78*/ float csum(Unity.Mathematics.float3 x);
            static /*0x3ac2f84*/ float f16tof32(uint x);
            static /*0x3ac2fdc*/ uint read32_little_endian(void* pBuffer);
            static /*0x3ac2fe4*/ uint hash_without_unaligned_loads(void* pBuffer, int numBytes, uint seed);
            static /*0x3ac3198*/ uint hash(void* pBuffer, int numBytes, uint seed);
            static /*0x3ac319c*/ Unity.Mathematics.float3x3 float3x3(Unity.Mathematics.quaternion rotation);
            static /*0x3ac328c*/ Unity.Mathematics.float3 mul(Unity.Mathematics.float3x3 a, Unity.Mathematics.float3 b);
            static /*0x3ac32d4*/ Unity.Mathematics.float4 mul(Unity.Mathematics.float4x4 a, Unity.Mathematics.float4 b);
            static /*0x3ac3308*/ Unity.Mathematics.float4x4 mul(Unity.Mathematics.float4x4 a, Unity.Mathematics.float4x4 b);
            static /*0x3ac33ac*/ Unity.Mathematics.quaternion quaternion(Unity.Mathematics.float4 value);
            static /*0x3ac33b0*/ Unity.Mathematics.quaternion mul(Unity.Mathematics.quaternion a, Unity.Mathematics.quaternion b);
            static /*0x3ac3424*/ uint hash(Unity.Mathematics.quaternion q);
            static /*0x3ac3484*/ Unity.Mathematics.uint2 uint2(uint x, uint y);
            static /*0x3ac3490*/ uint hash(Unity.Mathematics.uint2 v);
            static /*0x3ac34c0*/ Unity.Mathematics.uint3 uint3(uint x, uint y, uint z);
            static /*0x3ac34d0*/ uint hash(Unity.Mathematics.uint3 v);
            static /*0x3ac3510*/ Unity.Mathematics.uint4 uint4(uint x, uint y, uint z, uint w);
            static /*0x3ac3528*/ uint hash(Unity.Mathematics.uint4 v);

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

            /*0x3ac3580*/ bool2(bool x, bool y);
            /*0x3ac358c*/ bool Equals(Unity.Mathematics.bool2 rhs);
            /*0x3ac35b8*/ bool Equals(object o);
            /*0x3ac3644*/ int GetHashCode();
            /*0x3ac3680*/ string ToString();

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

            static /*0x3ac373c*/ Unity.Mathematics.bool4 op_BitwiseOr(Unity.Mathematics.bool4 lhs, Unity.Mathematics.bool4 rhs);
            /*0x3ac3714*/ bool4(bool x, bool y, bool z, bool w);
            /*0x3ac3728*/ bool4(bool v);
            /*0x3ac3748*/ bool Equals(Unity.Mathematics.bool4 rhs);
            /*0x3ac3794*/ bool Equals(object o);
            /*0x3ac3840*/ int GetHashCode();
            /*0x3ac388c*/ string ToString();

            class DebuggerProxy
            {
            }
        }

        struct float2 : System.IEquatable<Unity.Mathematics.float2>, System.IFormattable
        {
            static /*0x0*/ Unity.Mathematics.float2 zero;
            /*0x10*/ float x;
            /*0x14*/ float y;

            static /*0x3ac3a8c*/ Unity.Mathematics.float2 op_Implicit(Unity.Mathematics.int2 v);
            static /*0x3ac3a9c*/ Unity.Mathematics.float2 op_Implicit(Unity.Mathematics.uint2 v);
            static /*0x3ac3aac*/ Unity.Mathematics.float2 op_Multiply(Unity.Mathematics.float2 lhs, Unity.Mathematics.float2 rhs);
            static /*0x3ac3ab8*/ Unity.Mathematics.float2 op_Multiply(Unity.Mathematics.float2 lhs, float rhs);
            static /*0x3ac3ac4*/ Unity.Mathematics.float2 op_Multiply(float lhs, Unity.Mathematics.float2 rhs);
            static /*0x3ac3ad4*/ Unity.Mathematics.float2 op_Addition(Unity.Mathematics.float2 lhs, Unity.Mathematics.float2 rhs);
            static /*0x3ac3ae0*/ Unity.Mathematics.float2 op_Addition(Unity.Mathematics.float2 lhs, float rhs);
            static /*0x3ac3aec*/ Unity.Mathematics.float2 op_Addition(float lhs, Unity.Mathematics.float2 rhs);
            static /*0x3ac3afc*/ Unity.Mathematics.float2 op_Subtraction(Unity.Mathematics.float2 lhs, Unity.Mathematics.float2 rhs);
            static /*0x3ac3b08*/ Unity.Mathematics.float2 op_Division(Unity.Mathematics.float2 lhs, Unity.Mathematics.float2 rhs);
            static /*0x3ac3b14*/ Unity.Mathematics.float2 op_Division(Unity.Mathematics.float2 lhs, float rhs);
            static /*0x3ac3b20*/ Unity.Mathematics.float2 op_Division(float lhs, Unity.Mathematics.float2 rhs);
            static /*0x3ac3b30*/ Unity.Mathematics.float2 op_UnaryNegation(Unity.Mathematics.float2 val);
            static /*0x3ac3d40*/ UnityEngine.Vector2 op_Implicit(Unity.Mathematics.float2 v);
            static /*0x3ac3d44*/ Unity.Mathematics.float2 op_Implicit(UnityEngine.Vector2 v);
            /*0x3ac3a5c*/ float2(float x, float y);
            /*0x3ac3a64*/ float2(Unity.Mathematics.int2 v);
            /*0x3ac3a78*/ float2(Unity.Mathematics.uint2 v);
            /*0x3ac3b3c*/ bool Equals(Unity.Mathematics.float2 rhs);
            /*0x3ac3b60*/ bool Equals(object o);
            /*0x3ac3be8*/ int GetHashCode();
            /*0x3ac3c1c*/ string ToString();
            /*0x3ac3cb0*/ string ToString(string format, System.IFormatProvider formatProvider);

            class DebuggerProxy
            {
            }
        }

        struct float2x2 : System.IEquatable<Unity.Mathematics.float2x2>, System.IFormattable
        {
            static /*0x0*/ Unity.Mathematics.float2x2 identity;
            /*0x10*/ Unity.Mathematics.float2 c0;
            /*0x18*/ Unity.Mathematics.float2 c1;

            static /*0x3ac4230*/ float2x2();
            /*0x3ac3d48*/ float2x2(Unity.Mathematics.float2 c0, Unity.Mathematics.float2 c1);
            /*0x3ac3d54*/ float2x2(float m00, float m01, float m10, float m11);
            /*0x3ac3d60*/ bool Equals(Unity.Mathematics.float2x2 rhs);
            /*0x3ac3d9c*/ bool Equals(object o);
            /*0x3ac3e44*/ int GetHashCode();
            /*0x3ac3e9c*/ string ToString();
            /*0x3ac406c*/ string ToString(string format, System.IFormatProvider formatProvider);
        }

        struct float3 : System.IEquatable<Unity.Mathematics.float3>, System.IFormattable
        {
            static /*0x0*/ Unity.Mathematics.float3 zero;
            /*0x10*/ float x;
            /*0x14*/ float y;
            /*0x18*/ float z;

            static /*0x3ac42c0*/ Unity.Mathematics.float3 op_Implicit(float v);
            static /*0x3ac42cc*/ Unity.Mathematics.float3 op_Implicit(int v);
            static /*0x3ac42dc*/ Unity.Mathematics.float3 op_Multiply(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs);
            static /*0x3ac42ec*/ Unity.Mathematics.float3 op_Multiply(Unity.Mathematics.float3 lhs, float rhs);
            static /*0x3ac42fc*/ Unity.Mathematics.float3 op_Multiply(float lhs, Unity.Mathematics.float3 rhs);
            static /*0x3ac4310*/ Unity.Mathematics.float3 op_Addition(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs);
            static /*0x3ac4320*/ Unity.Mathematics.float3 op_Subtraction(Unity.Mathematics.float3 lhs, Unity.Mathematics.float3 rhs);
            static /*0x3ac4330*/ Unity.Mathematics.float3 op_Division(Unity.Mathematics.float3 lhs, float rhs);
            static /*0x3ac4340*/ Unity.Mathematics.float3 op_UnaryNegation(Unity.Mathematics.float3 val);
            static /*0x3ac4658*/ UnityEngine.Vector3 op_Implicit(Unity.Mathematics.float3 v);
            static /*0x3ac465c*/ Unity.Mathematics.float3 op_Implicit(UnityEngine.Vector3 v);
            /*0x3ac4280*/ float3(float x, float y, float z);
            /*0x3ac428c*/ float3(float x, Unity.Mathematics.float2 yz);
            /*0x3ac4298*/ float3(Unity.Mathematics.float2 xy, float z);
            /*0x3ac42a4*/ float3(float v);
            /*0x3ac42b0*/ float3(int v);
            /*0x3ac4350*/ Unity.Mathematics.float4 get_xxxx();
            /*0x3ac4364*/ Unity.Mathematics.float4 get_yxxy();
            /*0x3ac4374*/ Unity.Mathematics.float4 get_yyyy();
            /*0x3ac4388*/ Unity.Mathematics.float4 get_zzyz();
            /*0x3ac4398*/ Unity.Mathematics.float4 get_zzzz();
            /*0x3ac43ac*/ Unity.Mathematics.float3 get_xyz();
            /*0x3ac43b8*/ Unity.Mathematics.float3 get_yzx();
            /*0x3ac43c4*/ Unity.Mathematics.float2 get_xy();
            /*0x3ac43cc*/ Unity.Mathematics.float2 get_xz();
            /*0x3ac43d8*/ Unity.Mathematics.float2 get_yz();
            /*0x3ac43e0*/ bool Equals(Unity.Mathematics.float3 rhs);
            /*0x3ac4410*/ bool Equals(object o);
            /*0x3ac44a8*/ int GetHashCode();
            /*0x3ac44ec*/ string ToString();
            /*0x3ac45a4*/ string ToString(string format, System.IFormatProvider formatProvider);

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

            static /*0x3ac4f84*/ float3x3();
            static /*0x3ac4f54*/ Unity.Mathematics.float3x3 op_Explicit(Unity.Mathematics.float4x4 f4x4);
            /*0x3ac4660*/ float3x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22);
            /*0x3ac4f20*/ float3x3(Unity.Mathematics.float4x4 f4x4);
            /*0x3ac31b0*/ float3x3(Unity.Mathematics.quaternion q);
            /*0x3ac467c*/ bool Equals(Unity.Mathematics.float3x3 rhs);
            /*0x3ac4718*/ bool Equals(object o);
            /*0x3ac4810*/ int GetHashCode();
            /*0x3ac4894*/ string ToString();
            /*0x3ac4be0*/ string ToString(string format, System.IFormatProvider formatProvider);
        }

        struct float4 : System.IEquatable<Unity.Mathematics.float4>, System.IFormattable
        {
            static /*0x0*/ Unity.Mathematics.float4 zero;
            /*0x10*/ float x;
            /*0x14*/ float y;
            /*0x18*/ float z;
            /*0x1c*/ float w;

            static /*0x3ac5030*/ Unity.Mathematics.float4 op_Implicit(Unity.Mathematics.int4 v);
            static /*0x3ac504c*/ Unity.Mathematics.float4 op_Multiply(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs);
            static /*0x3ac5060*/ Unity.Mathematics.float4 op_Multiply(Unity.Mathematics.float4 lhs, float rhs);
            static /*0x3ac5074*/ Unity.Mathematics.float4 op_Addition(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs);
            static /*0x3ac5088*/ Unity.Mathematics.float4 op_Subtraction(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs);
            static /*0x3ac509c*/ Unity.Mathematics.float4 op_Division(Unity.Mathematics.float4 lhs, float rhs);
            static /*0x3ac50b0*/ Unity.Mathematics.bool4 op_LessThan(Unity.Mathematics.float4 lhs, Unity.Mathematics.float4 rhs);
            static /*0x3ac5678*/ Unity.Mathematics.float4 op_Implicit(UnityEngine.Vector4 v);
            static /*0x3ac567c*/ UnityEngine.Vector4 op_Implicit(Unity.Mathematics.float4 v);
            /*0x3ac4fdc*/ float4(float x, float y, float z, float w);
            /*0x3ac4fe8*/ float4(Unity.Mathematics.float2 xy, float z, float w);
            /*0x3ac4ff4*/ float4(Unity.Mathematics.float2 xy, Unity.Mathematics.float2 zw);
            /*0x3ac5000*/ float4(Unity.Mathematics.float3 xyz, float w);
            /*0x3ac500c*/ float4(Unity.Mathematics.int4 v);
            /*0x3ac50e4*/ Unity.Mathematics.float4 get_xyzx();
            /*0x3ac50f4*/ Unity.Mathematics.float4 get_yzxy();
            /*0x3ac5104*/ Unity.Mathematics.float4 get_yzxz();
            /*0x3ac5114*/ Unity.Mathematics.float4 get_zxyy();
            /*0x3ac5124*/ Unity.Mathematics.float4 get_zxyz();
            /*0x3ac5134*/ Unity.Mathematics.float4 get_wwwx();
            /*0x3ac5148*/ Unity.Mathematics.float4 get_wwww();
            /*0x3ac515c*/ Unity.Mathematics.float3 get_xyz();
            /*0x3ac5168*/ Unity.Mathematics.float3 get_yxw();
            /*0x3ac5174*/ Unity.Mathematics.float3 get_zwx();
            /*0x3ac5180*/ Unity.Mathematics.float3 get_wzy();
            /*0x3ac518c*/ Unity.Mathematics.float2 get_xy();
            /*0x3ac5194*/ Unity.Mathematics.float2 get_zw();
            /*0x3ac519c*/ float get_Item(int index);
            /*0x3ac51a4*/ bool Equals(Unity.Mathematics.float4 rhs);
            /*0x3ac51e0*/ bool Equals(object o);
            /*0x3ac5288*/ int GetHashCode();
            /*0x3ac52e4*/ string ToString();
            /*0x3ac54b4*/ string ToString(string format, System.IFormatProvider formatProvider);

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

            static /*0x3ac67f8*/ float4x4();
            static /*0x3ac6548*/ Unity.Mathematics.float4x4 op_Implicit(UnityEngine.Matrix4x4 m);
            static /*0x3ac6624*/ UnityEngine.Matrix4x4 op_Implicit(Unity.Mathematics.float4x4 m);
            static /*0x3ac671c*/ Unity.Mathematics.float4x4 TRS(Unity.Mathematics.float3 translation, Unity.Mathematics.quaternion rotation, Unity.Mathematics.float3 scale);
            /*0x3ac5680*/ float4x4(Unity.Mathematics.float4 c0, Unity.Mathematics.float4 c1, Unity.Mathematics.float4 c2, Unity.Mathematics.float4 c3);
            /*0x3ac56a4*/ float4x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33);
            /*0x3ac6688*/ float4x4(Unity.Mathematics.quaternion rotation, Unity.Mathematics.float3 translation);
            /*0x3ac56f8*/ ref Unity.Mathematics.float4 get_Item(int index);
            /*0x3ac5700*/ bool Equals(Unity.Mathematics.float4x4 rhs);
            /*0x3ac580c*/ bool Equals(object o);
            /*0x3ac5974*/ int GetHashCode();
            /*0x3ac5a94*/ string ToString();
            /*0x3ac5ff4*/ string ToString(string format, System.IFormatProvider formatProvider);
        }

        struct half : System.IEquatable<Unity.Mathematics.half>, System.IFormattable
        {
            /*0x10*/ ushort value;

            static /*0x3ac6864*/ float get_MinValue();
            /*0x3ac6870*/ bool Equals(Unity.Mathematics.half rhs);
            /*0x3ac6880*/ bool Equals(object o);
            /*0x3ac68f8*/ int GetHashCode();
            /*0x3ac6900*/ string ToString();
            /*0x3ac6974*/ string ToString(string format, System.IFormatProvider formatProvider);
        }

        struct int2 : System.IEquatable<Unity.Mathematics.int2>, System.IFormattable
        {
            static /*0x0*/ Unity.Mathematics.int2 zero;
            /*0x10*/ int x;
            /*0x14*/ int y;

            static /*0x3ac69f8*/ Unity.Mathematics.int2 op_Implicit(int v);
            static /*0x3ac6a04*/ Unity.Mathematics.int2 op_Addition(Unity.Mathematics.int2 lhs, Unity.Mathematics.int2 rhs);
            static /*0x3ac6a1c*/ Unity.Mathematics.int2 op_Addition(Unity.Mathematics.int2 lhs, int rhs);
            static /*0x3ac6a30*/ Unity.Mathematics.int2 op_Subtraction(Unity.Mathematics.int2 lhs, int rhs);
            static /*0x3ac6a44*/ Unity.Mathematics.int2 op_Division(Unity.Mathematics.int2 lhs, int rhs);
            static /*0x3ac6a58*/ Unity.Mathematics.bool2 op_LessThan(Unity.Mathematics.int2 lhs, Unity.Mathematics.int2 rhs);
            static /*0x3ac6a78*/ Unity.Mathematics.int2 op_RightShift(Unity.Mathematics.int2 x, int n);
            static /*0x3ac6a8c*/ Unity.Mathematics.int2 op_BitwiseOr(Unity.Mathematics.int2 lhs, Unity.Mathematics.int2 rhs);
            /*0x3ac69e8*/ int2(int x, int y);
            /*0x3ac69f0*/ int2(int v);
            /*0x3ac6a94*/ Unity.Mathematics.int4 get_xyxy();
            /*0x3ac6aa0*/ Unity.Mathematics.int2 get_xy();
            /*0x3ac6aa8*/ Unity.Mathematics.int2 get_yx();
            /*0x3ac6ab4*/ bool Equals(Unity.Mathematics.int2 rhs);
            /*0x3ac6adc*/ bool Equals(object o);
            /*0x3ac6b64*/ int GetHashCode();
            /*0x3ac6b98*/ string ToString();
            /*0x3ac6c2c*/ string ToString(string format, System.IFormatProvider formatProvider);

            class DebuggerProxy
            {
            }
        }

        struct int3 : System.IEquatable<Unity.Mathematics.int3>, System.IFormattable
        {
            /*0x10*/ int x;
            /*0x14*/ int y;
            /*0x18*/ int z;

            /*0x3ac6cbc*/ int3(Unity.Mathematics.int2 xy, int z);
            /*0x3ac6ccc*/ Unity.Mathematics.int2 get_xy();
            /*0x3ac6cd4*/ bool Equals(Unity.Mathematics.int3 rhs);
            /*0x3ac6d08*/ bool Equals(object o);
            /*0x3ac6da0*/ int GetHashCode();
            /*0x3ac6de8*/ string ToString();
            /*0x3ac6ea0*/ string ToString(string format, System.IFormatProvider formatProvider);

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

            static /*0x3ac6f8c*/ Unity.Mathematics.int4 op_Explicit(Unity.Mathematics.float4 v);
            /*0x3ac6f54*/ int4(int x, int y, int z, int w);
            /*0x3ac6f60*/ int4(Unity.Mathematics.float4 v);
            /*0x3ac6fe4*/ Unity.Mathematics.int2 get_xy();
            /*0x3ac6fec*/ Unity.Mathematics.int2 get_zw();
            /*0x3ac6ff4*/ int get_Item(int index);
            /*0x3ac6ffc*/ bool Equals(Unity.Mathematics.int4 rhs);
            /*0x3ac7040*/ bool Equals(object o);
            /*0x3ac70e8*/ int GetHashCode();
            /*0x3ac7144*/ string ToString();
            /*0x3ac7314*/ string ToString(string format, System.IFormatProvider formatProvider);

            class DebuggerProxy
            {
            }
        }

        struct quaternion : System.IEquatable<Unity.Mathematics.quaternion>, System.IFormattable
        {
            static /*0x0*/ Unity.Mathematics.quaternion identity;
            /*0x10*/ Unity.Mathematics.float4 value;

            static /*0x3ac7b30*/ quaternion();
            static /*0x3ac74d8*/ Unity.Mathematics.quaternion op_Implicit(UnityEngine.Quaternion q);
            static /*0x3ac74f4*/ Unity.Mathematics.quaternion EulerXYZ(Unity.Mathematics.float3 xyz);
            static /*0x3ac75a8*/ Unity.Mathematics.quaternion EulerXYZ(float x, float y, float z);
            /*0x3ac74dc*/ quaternion(float x, float y, float z, float w);
            /*0x3ac74e8*/ quaternion(Unity.Mathematics.float4 value);
            /*0x3ac765c*/ bool Equals(Unity.Mathematics.quaternion x);
            /*0x3ac7698*/ bool Equals(object x);
            /*0x3ac7740*/ int GetHashCode();
            /*0x3ac779c*/ string ToString();
            /*0x3ac796c*/ string ToString(string format, System.IFormatProvider formatProvider);
        }

        struct uint2 : System.IEquatable<Unity.Mathematics.uint2>, System.IFormattable
        {
            /*0x10*/ uint x;
            /*0x14*/ uint y;

            static /*0x3ac7b88*/ Unity.Mathematics.uint2 op_Multiply(Unity.Mathematics.uint2 lhs, Unity.Mathematics.uint2 rhs);
            static /*0x3ac7ba0*/ Unity.Mathematics.uint2 op_Addition(Unity.Mathematics.uint2 lhs, Unity.Mathematics.uint2 rhs);
            /*0x3ac7b80*/ uint2(uint x, uint y);
            /*0x3ac7bb8*/ bool Equals(Unity.Mathematics.uint2 rhs);
            /*0x3ac7be0*/ bool Equals(object o);
            /*0x3ac7c68*/ int GetHashCode();
            /*0x3ac7c9c*/ string ToString();
            /*0x3ac7d30*/ string ToString(string format, System.IFormatProvider formatProvider);

            class DebuggerProxy
            {
            }
        }

        struct uint3 : System.IEquatable<Unity.Mathematics.uint3>, System.IFormattable
        {
            /*0x10*/ uint x;
            /*0x14*/ uint y;
            /*0x18*/ uint z;

            static /*0x3ac7dcc*/ Unity.Mathematics.uint3 op_Multiply(Unity.Mathematics.uint3 lhs, Unity.Mathematics.uint3 rhs);
            static /*0x3ac7de8*/ Unity.Mathematics.uint3 op_Addition(Unity.Mathematics.uint3 lhs, Unity.Mathematics.uint3 rhs);
            static /*0x3ac7e04*/ Unity.Mathematics.uint3 op_BitwiseAnd(Unity.Mathematics.uint3 lhs, uint rhs);
            static /*0x3ac7e1c*/ Unity.Mathematics.uint3 op_ExclusiveOr(Unity.Mathematics.uint3 lhs, Unity.Mathematics.uint3 rhs);
            /*0x3ac7dc0*/ uint3(uint x, uint y, uint z);
            /*0x3ac7e28*/ bool Equals(Unity.Mathematics.uint3 rhs);
            /*0x3ac7e5c*/ bool Equals(object o);
            /*0x3ac7ef4*/ int GetHashCode();
            /*0x3ac7f3c*/ string ToString();
            /*0x3ac7ff4*/ string ToString(string format, System.IFormatProvider formatProvider);

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

            static /*0x3ac80c0*/ Unity.Mathematics.uint4 op_Implicit(uint v);
            static /*0x3ac80d0*/ Unity.Mathematics.uint4 op_Multiply(Unity.Mathematics.uint4 lhs, Unity.Mathematics.uint4 rhs);
            static /*0x3ac80fc*/ Unity.Mathematics.uint4 op_Multiply(Unity.Mathematics.uint4 lhs, uint rhs);
            static /*0x3ac8120*/ Unity.Mathematics.uint4 op_Addition(Unity.Mathematics.uint4 lhs, Unity.Mathematics.uint4 rhs);
            static /*0x3ac814c*/ Unity.Mathematics.uint4 op_Addition(Unity.Mathematics.uint4 lhs, uint rhs);
            static /*0x3ac8170*/ Unity.Mathematics.bool4 op_GreaterThan(Unity.Mathematics.uint4 lhs, uint rhs);
            static /*0x3ac81a8*/ Unity.Mathematics.uint4 op_LeftShift(Unity.Mathematics.uint4 x, int n);
            static /*0x3ac81cc*/ Unity.Mathematics.uint4 op_RightShift(Unity.Mathematics.uint4 x, int n);
            static /*0x3ac81f0*/ Unity.Mathematics.uint4 op_BitwiseAnd(Unity.Mathematics.uint4 lhs, uint rhs);
            static /*0x3ac8214*/ Unity.Mathematics.uint4 op_BitwiseOr(Unity.Mathematics.uint4 lhs, Unity.Mathematics.uint4 rhs);
            /*0x3ac80a8*/ uint4(uint x, uint y, uint z, uint w);
            /*0x3ac80b4*/ uint4(uint v);
            /*0x3ac8220*/ void set_Item(int index, uint value);
            /*0x3ac8228*/ bool Equals(Unity.Mathematics.uint4 rhs);
            /*0x3ac826c*/ bool Equals(object o);
            /*0x3ac8314*/ int GetHashCode();
            /*0x3ac8370*/ string ToString();
            /*0x3ac8540*/ string ToString(string format, System.IFormatProvider formatProvider);

            class DebuggerProxy
            {
            }
        }
    }
}
