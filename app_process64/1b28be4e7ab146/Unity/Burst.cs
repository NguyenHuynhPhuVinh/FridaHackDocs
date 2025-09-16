class <Module>
{
}

namespace Unity
{
    namespace Burst
    {
        enum OptimizeFor
        {
            Default = 0,
            Performance = 1,
            Size = 2,
            FastCompilation = 3,
            Balanced = 4,
        }

        enum FloatMode
        {
            Default = 0,
            Strict = 1,
            Deterministic = 2,
            Fast = 3,
        }

        enum FloatPrecision
        {
            Standard = 0,
            High = 1,
            Medium = 2,
            Low = 3,
        }

        class BurstCompileAttribute : System.Attribute
        {
            /*0x10*/ Unity.Burst.FloatMode <FloatMode>k__BackingField;
            /*0x14*/ Unity.Burst.FloatPrecision <FloatPrecision>k__BackingField;
            /*0x18*/ System.Nullable<bool> _compileSynchronously;
            /*0x1a*/ System.Nullable<bool> _disableSafetyChecks;
            /*0x1c*/ Unity.Burst.OptimizeFor <OptimizeFor>k__BackingField;
            /*0x20*/ string[] <Options>k__BackingField;

            /*0x7964ba0*/ BurstCompileAttribute();
            /*0x7964ba8*/ BurstCompileAttribute(Unity.Burst.FloatPrecision floatPrecision, Unity.Burst.FloatMode floatMode);
            /*0x7964ab0*/ void set_FloatMode(Unity.Burst.FloatMode value);
            /*0x7964ab8*/ void set_FloatPrecision(Unity.Burst.FloatPrecision value);
            /*0x7964ac0*/ void set_CompileSynchronously(bool value);
            /*0x7964b28*/ void set_DisableSafetyChecks(bool value);
            /*0x7964b90*/ void set_OptimizeFor(Unity.Burst.OptimizeFor value);
            /*0x7964b98*/ void set_Options(string[] value);
        }

        class BurstCompiler
        {
            static /*0x0*/ bool _IsEnabled;
            static /*0x8*/ Unity.Burst.BurstCompilerOptions Options;
            static /*0x10*/ System.Reflection.MethodInfo DummyMethodInfo;

            static /*0x7965288*/ BurstCompiler();
            static /*0x7964bd4*/ bool get_IsEnabled();
            static /*0x3910ae8*/ Unity.Burst.FunctionPointer<T> CompileFunctionPointer<T>(T delegateMethod);
            static /*0x7964c70*/ void* Compile(object delegateObj, bool isFunctionPointer);
            static /*0x7964d88*/ void* Compile(object delegateObj, System.Reflection.MethodInfo methodInfo, bool isFunctionPointer, bool isILPostProcessing);
            static /*0x7965284*/ void DummyMethod();

            class BurstCompilerHelper
            {
                static /*0x0*/ Unity.Burst.BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate IsBurstEnabledImpl;
                static /*0x8*/ bool IsBurstGenerated;

                static /*0x796547c*/ BurstCompilerHelper();
                static /*0x79653ec*/ bool IsBurstEnabled();
                static /*0x796543c*/ void DiscardedMethod(ref bool value);
                static /*0x7965444*/ bool IsCompiledByBurst(System.Delegate del);

                class IsBurstEnabledDelegate : System.MulticastDelegate
                {
                    /*0x7965560*/ IsBurstEnabledDelegate(object object, nint method);
                    /*0x79655fc*/ bool Invoke();
                }
            }

            class FakeDelegate
            {
                /*0x10*/ System.Reflection.MethodInfo <Method>k__BackingField;

                /*0x7965610*/ System.Reflection.MethodInfo get_Method();
            }

            class <>c
            {
                static /*0x0*/ Unity.Burst.BurstCompiler.<> <>9;
                static /*0x8*/ System.Func<System.Attribute, bool> <>9__22_0;

                static /*0x7965618*/ <>c();
                /*0x7965680*/ <>c();
                /*0x7965688*/ bool <Compile>b__22_0(System.Attribute s);
            }
        }

        class BurstCompilerOptions
        {
            static /*0x0*/ bool ForceDisableBurstCompilation;
            static /*0x1*/ bool ForceBurstCompilationSynchronously;
            static /*0x2*/ bool IsSecondaryUnityProcess;
            /*0x10*/ bool _enableBurstCompilation;
            /*0x11*/ bool _enableBurstSafetyChecks;
            /*0x12*/ bool <IsGlobal>k__BackingField;
            /*0x18*/ System.Action <OptionsChanged>k__BackingField;

            static /*0x7965d54*/ BurstCompilerOptions();
            static /*0x7965884*/ bool TryGetAttribute(System.Reflection.MemberInfo member, ref Unity.Burst.BurstCompileAttribute attribute);
            static /*0x7965928*/ Unity.Burst.BurstCompileAttribute GetBurstCompileAttribute(System.Reflection.MemberInfo memberInfo);
            static /*0x79651c4*/ bool HasBurstCompileAttribute(System.Reflection.MemberInfo member);
            static /*0x7965ecc*/ bool CheckIsSecondaryUnityProcess();
            /*0x7965384*/ BurstCompilerOptions(bool isGlobal);
            /*0x796584c*/ bool get_IsGlobal();
            /*0x7965854*/ bool get_EnableBurstCompilation();
            /*0x79656f4*/ void set_EnableBurstCompilation(bool value);
            /*0x796581c*/ void set_EnableBurstSafetyChecks(bool value);
            /*0x796587c*/ System.Action get_OptionsChanged();
            /*0x796585c*/ void OnOptionsChanged();
            /*0x7965878*/ void MaybeTriggerRecompilation();
        }

        class BurstRuntime
        {
            static /*0x3835328*/ long GetHashCode64<T>();
            static /*0x7965ed4*/ long HashStringWithFNV1A64(string text);
            static /*0x7965f60*/ void RuntimeLog(byte* message, int logType, byte* fileName, int lineNumber);
            static /*0x7965f78*/ void PreventRequiredAttributeStrip();
            static /*0x7966070*/ void Log(byte* message, int logType, byte* fileName, int lineNumber);

            struct HashCode64<T>
            {
                static /*0x0*/ long Value;

                static /*0x383e7a0*/ HashCode64();
            }

            class PreserveAttribute : System.Attribute
            {
                /*0x7966088*/ PreserveAttribute();
            }
        }

        class BurstString
        {
            static /*0x0*/ char[] SplitByColon;
            static /*0x8*/ byte[] logTable;
            static /*0x10*/ uint[] g_PowerOf10_U32;
            static /*0x18*/ byte[] InfinityString;
            static /*0x20*/ byte[] NanString;

            static /*0x7969698*/ BurstString();
            static /*0x7966090*/ void CopyFixedString(byte* dest, int destLength, byte* src, int srcLength);
            static /*0x79660b4*/ void Format(byte* dest, ref int destIndex, int destLength, byte* src, int srcLength, int formatOptionsRaw);
            static /*0x79662f8*/ void Format(byte* dest, ref int destIndex, int destLength, float value, int formatOptionsRaw);
            static /*0x7966604*/ void Format(byte* dest, ref int destIndex, int destLength, double value, int formatOptionsRaw);
            static /*0x796690c*/ void Format(byte* dest, ref int destIndex, int destLength, bool value, int formatOptionsRaw);
            static /*0x7966adc*/ void Format(byte* dest, ref int destIndex, int destLength, char value, int formatOptionsRaw);
            static /*0x7966cd4*/ void Format(byte* dest, ref int destIndex, int destLength, byte value, int formatOptionsRaw);
            static /*0x7966ddc*/ void Format(byte* dest, ref int destIndex, int destLength, ushort value, int formatOptionsRaw);
            static /*0x7966e60*/ void Format(byte* dest, ref int destIndex, int destLength, uint value, int formatOptionsRaw);
            static /*0x7966d58*/ void Format(byte* dest, ref int destIndex, int destLength, ulong value, int formatOptionsRaw);
            static /*0x7967088*/ void Format(byte* dest, ref int destIndex, int destLength, sbyte value, int formatOptionsRaw);
            static /*0x79672f4*/ void Format(byte* dest, ref int destIndex, int destLength, short value, int formatOptionsRaw);
            static /*0x79673ac*/ void Format(byte* dest, ref int destIndex, int destLength, int value, int formatOptionsRaw);
            static /*0x7967464*/ void Format(byte* dest, ref int destIndex, int destLength, long value, int formatOptionsRaw);
            static /*0x7966ee4*/ void ConvertUnsignedIntegerToString(byte* dest, ref int destIndex, int destLength, ulong value, Unity.Burst.BurstString.FormatOptions options);
            static /*0x7967800*/ int GetLengthIntegerToString(long value, int basis, int zeroPadding);
            static /*0x7967140*/ void ConvertIntegerToString(byte* dest, ref int destIndex, int destLength, long value, Unity.Burst.BurstString.FormatOptions options);
            static /*0x796758c*/ void FormatNumber(byte* dest, ref int destIndex, int destLength, ref Unity.Burst.BurstString.NumberBuffer number, int nMaxDigits, Unity.Burst.BurstString.FormatOptions options);
            static /*0x796782c*/ void FormatDecimalOrHexadecimal(byte* dest, ref int destIndex, int destLength, ref Unity.Burst.BurstString.NumberBuffer number, int zeroPadding, bool outputPositiveSign);
            static /*0x7967530*/ byte ValueToIntegerChar(int value, bool uppercase);
            static /*0x7966230*/ bool AlignRight(byte* dest, ref int destIndex, int destLength, int align, int length);
            static /*0x79661e4*/ bool AlignLeft(byte* dest, ref int destIndex, int destLength, int align, int length);
            static /*0x7967a04*/ int GetLengthForFormatGeneral(ref Unity.Burst.BurstString.NumberBuffer number, int nMaxDigits);
            static /*0x7967b4c*/ void FormatGeneral(byte* dest, ref int destIndex, int destLength, ref Unity.Burst.BurstString.NumberBuffer number, int nMaxDigits, byte expChar);
            static /*0x79678cc*/ void RoundNumber(ref Unity.Burst.BurstString.NumberBuffer number, int pos, bool isCorrectlyRounded);
            static /*0x7967d5c*/ bool ShouldRoundUp(byte* dig, int i, bool isCorrectlyRounded);
            static /*0x7967d80*/ uint LogBase2(uint val);
            static /*0x7967ea4*/ int BigInt_Compare(ref Unity.Burst.BurstString.tBigInt lhs, ref Unity.Burst.BurstString.tBigInt rhs);
            static /*0x7967ef4*/ void BigInt_Add(ref Unity.Burst.BurstString.tBigInt pResult, ref Unity.Burst.BurstString.tBigInt lhs, ref Unity.Burst.BurstString.tBigInt rhs);
            static /*0x7967f7c*/ void BigInt_Add_internal(ref Unity.Burst.BurstString.tBigInt pResult, ref Unity.Burst.BurstString.tBigInt pLarge, ref Unity.Burst.BurstString.tBigInt pSmall);
            static /*0x7968024*/ void BigInt_Multiply(ref Unity.Burst.BurstString.tBigInt pResult, ref Unity.Burst.BurstString.tBigInt lhs, ref Unity.Burst.BurstString.tBigInt rhs);
            static /*0x79680ac*/ void BigInt_Multiply_internal(ref Unity.Burst.BurstString.tBigInt pResult, ref Unity.Burst.BurstString.tBigInt pLarge, ref Unity.Burst.BurstString.tBigInt pSmall);
            static /*0x79681a0*/ void BigInt_Multiply(ref Unity.Burst.BurstString.tBigInt pResult, ref Unity.Burst.BurstString.tBigInt lhs, uint rhs);
            static /*0x7968200*/ void BigInt_Multiply2(ref Unity.Burst.BurstString.tBigInt pResult, ref Unity.Burst.BurstString.tBigInt input);
            static /*0x796825c*/ void BigInt_Multiply2(ref Unity.Burst.BurstString.tBigInt pResult);
            static /*0x79682b8*/ void BigInt_Multiply10(ref Unity.Burst.BurstString.tBigInt pResult);
            static /*0x7968314*/ Unity.Burst.BurstString.tBigInt g_PowerOf10_Big(int i);
            static /*0x796855c*/ void BigInt_Pow10(ref Unity.Burst.BurstString.tBigInt pResult, uint exponent);
            static /*0x796870c*/ void BigInt_MultiplyPow10(ref Unity.Burst.BurstString.tBigInt pResult, ref Unity.Burst.BurstString.tBigInt input, uint exponent);
            static /*0x79688b8*/ void BigInt_Pow2(ref Unity.Burst.BurstString.tBigInt pResult, uint exponent);
            static /*0x7968914*/ uint BigInt_DivideWithRemainder_MaxQuotient9(ref Unity.Burst.BurstString.tBigInt pDividend, ref Unity.Burst.BurstString.tBigInt divisor);
            static /*0x7968adc*/ void BigInt_ShiftLeft(ref Unity.Burst.BurstString.tBigInt pResult, uint shift);
            static /*0x7968bf0*/ uint Dragon4(ulong mantissa, int exponent, uint mantissaHighBitIdx, bool hasUnequalMargins, Unity.Burst.BurstString.CutoffMode cutoffMode, uint cutoffNumber, byte* pOutBuffer, uint bufferSize, ref int pOutExponent);
            static /*0x7969454*/ void FormatInfinityNaN(byte* dest, ref int destIndex, int destLength, ulong mantissa, bool isNegative, Unity.Burst.BurstString.FormatOptions formatOptions);
            static /*0x7966384*/ void ConvertFloatToString(byte* dest, ref int destIndex, int destLength, float value, Unity.Burst.BurstString.FormatOptions formatOptions);
            static /*0x7966690*/ void ConvertDoubleToString(byte* dest, ref int destIndex, int destLength, double value, Unity.Burst.BurstString.FormatOptions formatOptions);

            class PreserveAttribute : System.Attribute
            {
                /*0x7969870*/ PreserveAttribute();
            }

            enum NumberBufferKind
            {
                Integer = 0,
                Float = 1,
            }

            struct NumberBuffer
            {
                /*0x10*/ byte* _buffer;
                /*0x18*/ Unity.Burst.BurstString.NumberBufferKind Kind;
                /*0x1c*/ int DigitsCount;
                /*0x20*/ int Scale;
                /*0x24*/ bool IsNegative;

                /*0x7967574*/ NumberBuffer(Unity.Burst.BurstString.NumberBufferKind kind, byte* buffer, int digitsCount, int scale, bool isNegative);
                /*0x7969878*/ byte* GetDigitsPointer();
            }

            enum NumberFormatKind
            {
                General = 0,
                Decimal = 1,
                DecimalForceSigned = 2,
                Hexadecimal = 3,
            }

            struct FormatOptions
            {
                /*0x10*/ Unity.Burst.BurstString.NumberFormatKind Kind;
                /*0x11*/ sbyte AlignAndSize;
                /*0x12*/ byte Specifier;
                /*0x13*/ bool Lowercase;

                /*0x7967d40*/ FormatOptions(Unity.Burst.BurstString.NumberFormatKind kind, sbyte alignAndSize, byte specifier, bool lowercase);
                /*0x7967520*/ bool get_Uppercase();
                /*0x7967508*/ int GetBase();
                /*0x7969880*/ string ToString();
            }

            struct tBigInt
            {
                /*0x10*/ int m_length;
                /*0x14*/ Unity.Burst.BurstString.tBigInt.<m_blocks> m_blocks;

                /*0x7969ba8*/ int GetLength();
                /*0x7969438*/ uint GetBlock(int idx);
                /*0x7969444*/ bool IsZero();
                /*0x7969408*/ void SetU64(ulong val);
                /*0x79686f0*/ void SetU32(uint val);

                struct <m_blocks>e__FixedBuffer
                {
                    /*0x10*/ uint FixedElementField;
                }
            }

            enum CutoffMode
            {
                Unique = 0,
                TotalLength = 1,
                FractionLength = 2,
            }

            struct tFloatUnion32
            {
                /*0x10*/ float m_floatingPoint;
                /*0x10*/ uint m_integer;

                /*0x7969668*/ bool IsNegative();
                /*0x7969650*/ uint GetExponent();
                /*0x796965c*/ uint GetMantissa();
            }

            struct tFloatUnion64
            {
                /*0x10*/ double m_floatingPoint;
                /*0x10*/ ulong m_integer;

                /*0x796968c*/ bool IsNegative();
                /*0x7969674*/ uint GetExponent();
                /*0x7969680*/ ulong GetMantissa();
            }
        }

        struct FunctionPointer<T>
        {
            /*0x0*/ nint _ptr;

            FunctionPointer(nint ptr);
            nint get_Value();
            /*0x3910ae8*/ T get_Invoke();
        }

        class NoAliasAttribute : System.Attribute
        {
            /*0x7969bb0*/ NoAliasAttribute();
        }

        struct SharedStatic<T>
        {
            /*0x0*/ void* _buffer;

            static /*0x3910ae8*/ Unity.Burst.SharedStatic<T> GetOrCreate<TContext>(uint alignment);
            static /*0x3910ae8*/ Unity.Burst.SharedStatic<T> GetOrCreateUnsafe(uint alignment, long hashCode, long subHashCode);
            /*0x3910ae8*/ SharedStatic(void* buffer);
            /*0x38148bc*/ ref T get_Data();
            /*0x3910ae8*/ void* get_UnsafeDataPointer();
        }

        class SharedStatic
        {
            static /*0x7969bb8*/ void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment);

            class PreserveAttribute : System.Attribute
            {
                /*0x7969c08*/ PreserveAttribute();
            }
        }

        namespace Intrinsics
        {
            class Arm
            {
                class Neon
                {
                    static /*0x7969c10*/ bool get_IsNeonSupported();
                    static /*0x7969c18*/ Unity.Burst.Intrinsics.v128 veorq_s8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x7969c50*/ Unity.Burst.Intrinsics.v128 veorq_u8(Unity.Burst.Intrinsics.v128 a0, Unity.Burst.Intrinsics.v128 a1);
                    static /*0x7969c58*/ Unity.Burst.Intrinsics.v128 vld1q_u8(byte* a0);
                    static /*0x7969c64*/ void vst1q_u8(byte* a0, Unity.Burst.Intrinsics.v128 a1);
                }
            }

            class BurstTargetCpuAttribute : System.Attribute
            {
            }

            class V64DebugView
            {
            }

            class V128DebugView
            {
            }

            class V256DebugView
            {
            }

            struct v128
            {
                /*0x10*/ byte Byte0;
                /*0x11*/ byte Byte1;
                /*0x12*/ byte Byte2;
                /*0x13*/ byte Byte3;
                /*0x14*/ byte Byte4;
                /*0x15*/ byte Byte5;
                /*0x16*/ byte Byte6;
                /*0x17*/ byte Byte7;
                /*0x18*/ byte Byte8;
                /*0x19*/ byte Byte9;
                /*0x1a*/ byte Byte10;
                /*0x1b*/ byte Byte11;
                /*0x1c*/ byte Byte12;
                /*0x1d*/ byte Byte13;
                /*0x1e*/ byte Byte14;
                /*0x1f*/ byte Byte15;
                /*0x10*/ sbyte SByte0;
                /*0x11*/ sbyte SByte1;
                /*0x12*/ sbyte SByte2;
                /*0x13*/ sbyte SByte3;
                /*0x14*/ sbyte SByte4;
                /*0x15*/ sbyte SByte5;
                /*0x16*/ sbyte SByte6;
                /*0x17*/ sbyte SByte7;
                /*0x18*/ sbyte SByte8;
                /*0x19*/ sbyte SByte9;
                /*0x1a*/ sbyte SByte10;
                /*0x1b*/ sbyte SByte11;
                /*0x1c*/ sbyte SByte12;
                /*0x1d*/ sbyte SByte13;
                /*0x1e*/ sbyte SByte14;
                /*0x1f*/ sbyte SByte15;
                /*0x10*/ ushort UShort0;
                /*0x12*/ ushort UShort1;
                /*0x14*/ ushort UShort2;
                /*0x16*/ ushort UShort3;
                /*0x18*/ ushort UShort4;
                /*0x1a*/ ushort UShort5;
                /*0x1c*/ ushort UShort6;
                /*0x1e*/ ushort UShort7;
                /*0x10*/ short SShort0;
                /*0x12*/ short SShort1;
                /*0x14*/ short SShort2;
                /*0x16*/ short SShort3;
                /*0x18*/ short SShort4;
                /*0x1a*/ short SShort5;
                /*0x1c*/ short SShort6;
                /*0x1e*/ short SShort7;
                /*0x10*/ uint UInt0;
                /*0x14*/ uint UInt1;
                /*0x18*/ uint UInt2;
                /*0x1c*/ uint UInt3;
                /*0x10*/ int SInt0;
                /*0x14*/ int SInt1;
                /*0x18*/ int SInt2;
                /*0x1c*/ int SInt3;
                /*0x10*/ ulong ULong0;
                /*0x18*/ ulong ULong1;
                /*0x10*/ long SLong0;
                /*0x18*/ long SLong1;
                /*0x10*/ float Float0;
                /*0x14*/ float Float1;
                /*0x18*/ float Float2;
                /*0x1c*/ float Float3;
                /*0x10*/ double Double0;
                /*0x18*/ double Double1;
                /*0x10*/ Unity.Burst.Intrinsics.v64 Lo64;
                /*0x18*/ Unity.Burst.Intrinsics.v64 Hi64;

                /*0x7969c6c*/ v128(uint v);
            }

            struct v256
            {
                /*0x10*/ byte Byte0;
                /*0x11*/ byte Byte1;
                /*0x12*/ byte Byte2;
                /*0x13*/ byte Byte3;
                /*0x14*/ byte Byte4;
                /*0x15*/ byte Byte5;
                /*0x16*/ byte Byte6;
                /*0x17*/ byte Byte7;
                /*0x18*/ byte Byte8;
                /*0x19*/ byte Byte9;
                /*0x1a*/ byte Byte10;
                /*0x1b*/ byte Byte11;
                /*0x1c*/ byte Byte12;
                /*0x1d*/ byte Byte13;
                /*0x1e*/ byte Byte14;
                /*0x1f*/ byte Byte15;
                /*0x20*/ byte Byte16;
                /*0x21*/ byte Byte17;
                /*0x22*/ byte Byte18;
                /*0x23*/ byte Byte19;
                /*0x24*/ byte Byte20;
                /*0x25*/ byte Byte21;
                /*0x26*/ byte Byte22;
                /*0x27*/ byte Byte23;
                /*0x28*/ byte Byte24;
                /*0x29*/ byte Byte25;
                /*0x2a*/ byte Byte26;
                /*0x2b*/ byte Byte27;
                /*0x2c*/ byte Byte28;
                /*0x2d*/ byte Byte29;
                /*0x2e*/ byte Byte30;
                /*0x2f*/ byte Byte31;
                /*0x10*/ sbyte SByte0;
                /*0x11*/ sbyte SByte1;
                /*0x12*/ sbyte SByte2;
                /*0x13*/ sbyte SByte3;
                /*0x14*/ sbyte SByte4;
                /*0x15*/ sbyte SByte5;
                /*0x16*/ sbyte SByte6;
                /*0x17*/ sbyte SByte7;
                /*0x18*/ sbyte SByte8;
                /*0x19*/ sbyte SByte9;
                /*0x1a*/ sbyte SByte10;
                /*0x1b*/ sbyte SByte11;
                /*0x1c*/ sbyte SByte12;
                /*0x1d*/ sbyte SByte13;
                /*0x1e*/ sbyte SByte14;
                /*0x1f*/ sbyte SByte15;
                /*0x20*/ sbyte SByte16;
                /*0x21*/ sbyte SByte17;
                /*0x22*/ sbyte SByte18;
                /*0x23*/ sbyte SByte19;
                /*0x24*/ sbyte SByte20;
                /*0x25*/ sbyte SByte21;
                /*0x26*/ sbyte SByte22;
                /*0x27*/ sbyte SByte23;
                /*0x28*/ sbyte SByte24;
                /*0x29*/ sbyte SByte25;
                /*0x2a*/ sbyte SByte26;
                /*0x2b*/ sbyte SByte27;
                /*0x2c*/ sbyte SByte28;
                /*0x2d*/ sbyte SByte29;
                /*0x2e*/ sbyte SByte30;
                /*0x2f*/ sbyte SByte31;
                /*0x10*/ ushort UShort0;
                /*0x12*/ ushort UShort1;
                /*0x14*/ ushort UShort2;
                /*0x16*/ ushort UShort3;
                /*0x18*/ ushort UShort4;
                /*0x1a*/ ushort UShort5;
                /*0x1c*/ ushort UShort6;
                /*0x1e*/ ushort UShort7;
                /*0x20*/ ushort UShort8;
                /*0x22*/ ushort UShort9;
                /*0x24*/ ushort UShort10;
                /*0x26*/ ushort UShort11;
                /*0x28*/ ushort UShort12;
                /*0x2a*/ ushort UShort13;
                /*0x2c*/ ushort UShort14;
                /*0x2e*/ ushort UShort15;
                /*0x10*/ short SShort0;
                /*0x12*/ short SShort1;
                /*0x14*/ short SShort2;
                /*0x16*/ short SShort3;
                /*0x18*/ short SShort4;
                /*0x1a*/ short SShort5;
                /*0x1c*/ short SShort6;
                /*0x1e*/ short SShort7;
                /*0x20*/ short SShort8;
                /*0x22*/ short SShort9;
                /*0x24*/ short SShort10;
                /*0x26*/ short SShort11;
                /*0x28*/ short SShort12;
                /*0x2a*/ short SShort13;
                /*0x2c*/ short SShort14;
                /*0x2e*/ short SShort15;
                /*0x10*/ uint UInt0;
                /*0x14*/ uint UInt1;
                /*0x18*/ uint UInt2;
                /*0x1c*/ uint UInt3;
                /*0x20*/ uint UInt4;
                /*0x24*/ uint UInt5;
                /*0x28*/ uint UInt6;
                /*0x2c*/ uint UInt7;
                /*0x10*/ int SInt0;
                /*0x14*/ int SInt1;
                /*0x18*/ int SInt2;
                /*0x1c*/ int SInt3;
                /*0x20*/ int SInt4;
                /*0x24*/ int SInt5;
                /*0x28*/ int SInt6;
                /*0x2c*/ int SInt7;
                /*0x10*/ ulong ULong0;
                /*0x18*/ ulong ULong1;
                /*0x20*/ ulong ULong2;
                /*0x28*/ ulong ULong3;
                /*0x10*/ long SLong0;
                /*0x18*/ long SLong1;
                /*0x20*/ long SLong2;
                /*0x28*/ long SLong3;
                /*0x10*/ float Float0;
                /*0x14*/ float Float1;
                /*0x18*/ float Float2;
                /*0x1c*/ float Float3;
                /*0x20*/ float Float4;
                /*0x24*/ float Float5;
                /*0x28*/ float Float6;
                /*0x2c*/ float Float7;
                /*0x10*/ double Double0;
                /*0x18*/ double Double1;
                /*0x20*/ double Double2;
                /*0x28*/ double Double3;
                /*0x10*/ Unity.Burst.Intrinsics.v128 Lo128;
                /*0x20*/ Unity.Burst.Intrinsics.v128 Hi128;

                /*0x7969c78*/ v256(byte b);
                /*0x7969c90*/ v256(uint v);
                /*0x7969c9c*/ v256(Unity.Burst.Intrinsics.v128 lo, Unity.Burst.Intrinsics.v128 hi);
            }

            struct v64
            {
                /*0x10*/ byte Byte0;
                /*0x11*/ byte Byte1;
                /*0x12*/ byte Byte2;
                /*0x13*/ byte Byte3;
                /*0x14*/ byte Byte4;
                /*0x15*/ byte Byte5;
                /*0x16*/ byte Byte6;
                /*0x17*/ byte Byte7;
                /*0x10*/ sbyte SByte0;
                /*0x11*/ sbyte SByte1;
                /*0x12*/ sbyte SByte2;
                /*0x13*/ sbyte SByte3;
                /*0x14*/ sbyte SByte4;
                /*0x15*/ sbyte SByte5;
                /*0x16*/ sbyte SByte6;
                /*0x17*/ sbyte SByte7;
                /*0x10*/ ushort UShort0;
                /*0x12*/ ushort UShort1;
                /*0x14*/ ushort UShort2;
                /*0x16*/ ushort UShort3;
                /*0x10*/ short SShort0;
                /*0x12*/ short SShort1;
                /*0x14*/ short SShort2;
                /*0x16*/ short SShort3;
                /*0x10*/ uint UInt0;
                /*0x14*/ uint UInt1;
                /*0x10*/ int SInt0;
                /*0x14*/ int SInt1;
                /*0x10*/ ulong ULong0;
                /*0x10*/ long SLong0;
                /*0x10*/ float Float0;
                /*0x14*/ float Float1;
                /*0x10*/ double Double0;
            }

            class X86
            {
                class Avx2
                {
                    static /*0x7969cb0*/ bool get_IsAvx2Supported();
                    static /*0x7969cb8*/ Unity.Burst.Intrinsics.v256 mm256_xor_si256(Unity.Burst.Intrinsics.v256 a, Unity.Burst.Intrinsics.v256 b);
                    static /*0x7969cdc*/ Unity.Burst.Intrinsics.v256 mm256_maskload_epi32(void* mem_addr, Unity.Burst.Intrinsics.v256 mask);
                    static /*0x7969d44*/ void mm256_maskstore_epi32(void* mem_addr, Unity.Burst.Intrinsics.v256 mask, Unity.Burst.Intrinsics.v256 a);
                }

                class Sse2
                {
                    static /*0x7969cd0*/ Unity.Burst.Intrinsics.v128 xor_si128(Unity.Burst.Intrinsics.v128 a, Unity.Burst.Intrinsics.v128 b);
                }
            }
        }

        namespace CompilerServices
        {
            class AssumeRangeAttribute : System.Attribute
            {
                /*0x7969d68*/ AssumeRangeAttribute(long min, long max);
            }

            class Hint
            {
                static /*0x7969d70*/ void Assume(bool condition);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 07DB995E8ED2CFB0AB71EBA69F3A3EC07D5C6AC10C0C64F33E94ED2949B348AA;
    static /*0x100*/ <PrivateImplementationDetails> C69994AC61B52FBCEA582D6CCCD595C12E00BDB18F0C6F593FB6B393CAEDB08C;
    static /*0x120*/ long D0067CAD9A63E0813759A2BB841051CA73570C0DA2E08E840A8EB45DB6A7A010;
    static /*0x128*/ <PrivateImplementationDetails> D5B592C05DC25B5032553F1B27F4139BE95E881F73DB33B02B05AB20C3F9981E;

    struct __StaticArrayInitTypeSize=3
    {
    }

    struct __StaticArrayInitTypeSize=32
    {
    }

    struct __StaticArrayInitTypeSize=256
    {
    }
}
