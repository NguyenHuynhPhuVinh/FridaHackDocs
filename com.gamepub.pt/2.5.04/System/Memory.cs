class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x2abd754*/ EmbeddedAttribute();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class IsReadOnlyAttribute : System.Attribute
            {
                /*0x2abd810*/ IsReadOnlyAttribute();
            }

            class IsByRefLikeAttribute : System.Attribute
            {
                /*0x2abd808*/ IsByRefLikeAttribute();
            }
        }
    }
}

namespace FxResources
{
    namespace System
    {
        namespace Memory
        {
            class SR
            {
            }
        }
    }
}

namespace System
{
    struct SequencePosition : System.IEquatable<System.SequencePosition>
    {
        /*0x10*/ object _object;
        /*0x18*/ int _integer;

        /*0xb21ec0*/ SequencePosition(object object, int integer);
        /*0xb21ecc*/ object GetObject();
        /*0xb21ed4*/ int GetInteger();
        /*0xb21edc*/ bool Equals(System.SequencePosition other);
        /*0xb21efc*/ bool Equals(object obj);
        /*0xb21f04*/ int GetHashCode();
    }

    class ThrowHelper
    {
        static /*0x2ac0640*/ void ThrowArgumentNullException(System.ExceptionArgument argument);
        static /*0x2ac066c*/ System.Exception CreateArgumentNullException(System.ExceptionArgument argument);
        static /*0x2ac0720*/ void ThrowArrayTypeMismatchException();
        static /*0x2ac074c*/ System.Exception CreateArrayTypeMismatchException();
        static /*0x2ac07a4*/ void ThrowArgumentException_InvalidTypeWithPointersNotSupported(System.Type type);
        static /*0x2ac07d0*/ System.Exception CreateArgumentException_InvalidTypeWithPointersNotSupported(System.Type type);
        static /*0x2ac0870*/ void ThrowArgumentException_DestinationTooShort();
        static /*0x2ac089c*/ System.Exception CreateArgumentException_DestinationTooShort();
        static /*0x2ac0930*/ void ThrowIndexOutOfRangeException();
        static /*0x2ac095c*/ System.Exception CreateIndexOutOfRangeException();
        static /*0x2ac09b4*/ void ThrowArgumentOutOfRangeException();
        static /*0x2ac09e0*/ System.Exception CreateArgumentOutOfRangeException();
        static /*0x2abd950*/ void ThrowArgumentOutOfRangeException(System.ExceptionArgument argument);
        static /*0x2ac0a38*/ System.Exception CreateArgumentOutOfRangeException(System.ExceptionArgument argument);
        static /*0x2ac03cc*/ void ThrowArgumentOutOfRangeException_PrecisionTooLarge();
        static /*0x2ac0aec*/ System.Exception CreateArgumentOutOfRangeException_PrecisionTooLarge();
        static /*0x2ac03f8*/ void ThrowArgumentOutOfRangeException_SymbolDoesNotFit();
        static /*0x2ac0bd8*/ System.Exception CreateArgumentOutOfRangeException_SymbolDoesNotFit();
        static /*0x2ac0c84*/ void ThrowInvalidOperationException();
        static /*0x2ac0cb0*/ System.Exception CreateInvalidOperationException();
        static /*0x2ac0d08*/ void ThrowInvalidOperationException_EndPositionNotReached();
        static /*0x2ac0d34*/ System.Exception CreateInvalidOperationException_EndPositionNotReached();
        static /*0x2ac0dc8*/ void ThrowArgumentOutOfRangeException_PositionOutOfRange();
        static /*0x2ac0df4*/ System.Exception CreateArgumentOutOfRangeException_PositionOutOfRange();
        static /*0x2ac0e64*/ void ThrowArgumentOutOfRangeException_OffsetOutOfRange();
        static /*0x2ac0e90*/ System.Exception CreateArgumentOutOfRangeException_OffsetOutOfRange();
        static /*0x2ac0f00*/ void ThrowObjectDisposedException_ArrayMemoryPoolBuffer();
        static /*0x2ac0f2c*/ System.Exception CreateObjectDisposedException_ArrayMemoryPoolBuffer();
        static /*0x2ac0f9c*/ void ThrowFormatException_BadFormatSpecifier();
        static /*0x2ac0fc8*/ System.Exception CreateFormatException_BadFormatSpecifier();
        static /*0x2ac105c*/ bool TryFormatThrowFormatException(ref int bytesWritten);
        static bool TryParseThrowFormatException<T>(ref T value, ref int bytesConsumed);
        static void ThrowArgumentValidationException<T>(System.Buffers.ReadOnlySequenceSegment<T> startSegment, int startIndex, System.Buffers.ReadOnlySequenceSegment<T> endSegment);
        static System.Exception CreateArgumentValidationException<T>(System.Buffers.ReadOnlySequenceSegment<T> startSegment, int startIndex, System.Buffers.ReadOnlySequenceSegment<T> endSegment);
        static /*0x2ac106c*/ void ThrowStartOrEndArgumentValidationException(long start);
        static /*0x2ac1098*/ System.Exception CreateStartOrEndArgumentValidationException(long start);
    }

    enum ExceptionArgument
    {
        length = 0,
        start = 1,
        minimumBufferSize = 2,
        elementIndex = 3,
        comparable = 4,
        comparer = 5,
        destination = 6,
        offset = 7,
        startSegment = 8,
        endSegment = 9,
        startIndex = 10,
        endIndex = 11,
        array = 12,
        culture = 13,
        manager = 14,
    }

    class DecimalDecCalc
    {
        static /*0x2abd580*/ uint D32DivMod1E9(uint hi32, ref uint lo32);
        static /*0x2abd5a4*/ uint DecDivMod1E9(ref System.MutableDecimal value);
        static /*0x2abd5f0*/ void DecAddInt32(ref System.MutableDecimal value, uint i);
        static /*0x2abd634*/ bool D32AddCarry(ref uint value, uint i);
        static /*0x2abd658*/ void DecMul10(ref System.MutableDecimal value);
        static /*0x2abd6c4*/ void DecShiftLeft(ref System.MutableDecimal value);
        static /*0x2abd6e4*/ void DecAdd(ref System.MutableDecimal value, System.MutableDecimal d);
    }

    class Number
    {
        static /*0x0*/ ulong[] s_rgval64Power10;
        static /*0x8*/ sbyte[] s_rgexp64Power10;
        static /*0x10*/ ulong[] s_rgval64Power10By16;
        static /*0x18*/ short[] s_rgexp64Power10By16;

        static /*0x2abe2a8*/ Number();
        static /*0x2abdb68*/ void RoundNumber(ref System.NumberBuffer number, int pos);
        static /*0x2abdd84*/ bool NumberBufferToDecimal(ref System.NumberBuffer number, ref decimal value);
        static /*0x2abe050*/ void DecimalToNumber(decimal value, ref System.NumberBuffer number);
    }

    struct NumberBuffer
    {
        /*0x10*/ int Scale;
        /*0x14*/ bool IsNegative;
        /*0x15*/ byte _b0;
        /*0x16*/ byte _b1;
        /*0x17*/ byte _b2;
        /*0x18*/ byte _b3;
        /*0x19*/ byte _b4;
        /*0x1a*/ byte _b5;
        /*0x1b*/ byte _b6;
        /*0x1c*/ byte _b7;
        /*0x1d*/ byte _b8;
        /*0x1e*/ byte _b9;
        /*0x1f*/ byte _b10;
        /*0x20*/ byte _b11;
        /*0x21*/ byte _b12;
        /*0x22*/ byte _b13;
        /*0x23*/ byte _b14;
        /*0x24*/ byte _b15;
        /*0x25*/ byte _b16;
        /*0x26*/ byte _b17;
        /*0x27*/ byte _b18;
        /*0x28*/ byte _b19;
        /*0x29*/ byte _b20;
        /*0x2a*/ byte _b21;
        /*0x2b*/ byte _b22;
        /*0x2c*/ byte _b23;
        /*0x2d*/ byte _b24;
        /*0x2e*/ byte _b25;
        /*0x2f*/ byte _b26;
        /*0x30*/ byte _b27;
        /*0x31*/ byte _b28;
        /*0x32*/ byte _b29;
        /*0x33*/ byte _b30;
        /*0x34*/ byte _b31;
        /*0x35*/ byte _b32;
        /*0x36*/ byte _b33;
        /*0x37*/ byte _b34;
        /*0x38*/ byte _b35;
        /*0x39*/ byte _b36;
        /*0x3a*/ byte _b37;
        /*0x3b*/ byte _b38;
        /*0x3c*/ byte _b39;
        /*0x3d*/ byte _b40;
        /*0x3e*/ byte _b41;
        /*0x3f*/ byte _b42;
        /*0x40*/ byte _b43;
        /*0x41*/ byte _b44;
        /*0x42*/ byte _b45;
        /*0x43*/ byte _b46;
        /*0x44*/ byte _b47;
        /*0x45*/ byte _b48;
        /*0x46*/ byte _b49;
        /*0x47*/ byte _b50;

        /*0xb21ae4*/ System.Span<byte> get_Digits();
        /*0xb21b24*/ byte* get_UnsafeDigits();
        /*0xb21d78*/ int get_NumDigits();
        /*0xb21d80*/ string ToString();
    }

    struct Memory<T>
    {
        /*0x0*/ object _object;
        /*0x0*/ int _index;
        /*0x0*/ int _length;

        static System.Memory<T> op_Implicit(T[] array);
        static System.ReadOnlyMemory<T> op_Implicit(System.Memory<T> memory);
        static int CombineHashCodes(int left, int right);
        static int CombineHashCodes(int h1, int h2, int h3);
        Memory(T[] array);
        Memory(T[] array, int start);
        Memory(T[] array, int start, int length);
        Memory(System.Buffers.MemoryManager<T> manager, int length);
        Memory(object obj, int start, int length);
        int get_Length();
        bool get_IsEmpty();
        string ToString();
        System.Memory<T> Slice(int start);
        System.Memory<T> Slice(int start, int length);
        System.Span<T> get_Span();
        bool Equals(object obj);
        bool Equals(System.Memory<T> other);
        int GetHashCode();
    }

    class MemoryDebugView<T>
    {
    }

    class MemoryExtensions
    {
        static /*0x0*/ nint StringAdjustment;

        static /*0x2abda00*/ MemoryExtensions();
        static int IndexOf<T>(System.Span<T> span, T value);
        static bool SequenceEqual<T>(System.Span<T> span, System.ReadOnlySpan<T> other);
        static bool SequenceEqual<T>(System.ReadOnlySpan<T> span, System.ReadOnlySpan<T> other);
        static System.Span<T> AsSpan<T>(T[] array);
        static System.Span<T> AsSpan<T>(T[] array, int start, int length);
        static System.Span<T> AsSpan<T>(System.ArraySegment<T> segment);
        static System.Span<T> AsSpan<T>(System.ArraySegment<T> segment, int start, int length);
        static System.Memory<T> AsMemory<T>(T[] array, int start);
        static System.Memory<T> AsMemory<T>(T[] array, int start, int length);
        static System.Memory<T> AsMemory<T>(System.ArraySegment<T> segment, int start);
        static bool IsTypeComparableAsBytes<T>(ref System.NUInt size);
        static System.Span<T> AsSpan<T>(T[] array, int start);
        static /*0x2abd818*/ System.ReadOnlySpan<char> AsSpan(string text);
        static /*0x2abd8c4*/ System.ReadOnlyMemory<char> AsMemory(string text, int start, int length);
        static /*0x2abd97c*/ nint MeasureStringAdjustment();
    }

    struct ReadOnlyMemory<T>
    {
        /*0x0*/ object _object;
        /*0x0*/ int _index;
        /*0x0*/ int _length;

        static System.ReadOnlyMemory<T> op_Implicit(T[] array);
        static System.ReadOnlyMemory<T> op_Implicit(System.ArraySegment<T> segment);
        static int CombineHashCodes(int left, int right);
        static int CombineHashCodes(int h1, int h2, int h3);
        ReadOnlyMemory(T[] array);
        ReadOnlyMemory(T[] array, int start, int length);
        ReadOnlyMemory(object obj, int start, int length);
        int get_Length();
        bool get_IsEmpty();
        string ToString();
        System.ReadOnlyMemory<T> Slice(int start);
        System.ReadOnlyMemory<T> Slice(int start, int length);
        System.ReadOnlySpan<T> get_Span();
        void CopyTo(System.Memory<T> destination);
        bool Equals(object obj);
        bool Equals(System.ReadOnlyMemory<T> other);
        int GetHashCode();
        object GetObjectStartLength(ref int start, ref int length);
    }

    struct ReadOnlySpan<T>
    {
        /*0x0*/ System.Pinnable<T> _pinnable;
        /*0x0*/ nint _byteOffset;
        /*0x0*/ int _length;

        static System.ReadOnlySpan<T> op_Implicit(T[] array);
        static System.ReadOnlySpan<T> op_Implicit(System.ArraySegment<T> segment);
        ReadOnlySpan(T[] array);
        ReadOnlySpan(T[] array, int start, int length);
        ReadOnlySpan(void* pointer, int length);
        ReadOnlySpan(System.Pinnable<T> pinnable, nint byteOffset, int length);
        int get_Length();
        bool Equals(object obj);
        int GetHashCode();
        ref T get_Item(int index);
        ref T GetPinnableReference();
        void CopyTo(System.Span<T> destination);
        bool TryCopyTo(System.Span<T> destination);
        string ToString();
        System.ReadOnlySpan<T> Slice(int start);
        System.ReadOnlySpan<T> Slice(int start, int length);
        T[] ToArray();
        ref T DangerousGetPinnableReference();
        System.Pinnable<T> get_Pinnable();
        nint get_ByteOffset();
    }

    struct Span<T>
    {
        /*0x0*/ System.Pinnable<T> _pinnable;
        /*0x0*/ nint _byteOffset;
        /*0x0*/ int _length;

        static System.Span<T> op_Implicit(T[] array);
        static System.Span<T> Create(T[] array, int start);
        static System.ReadOnlySpan<T> op_Implicit(System.Span<T> span);
        Span(T[] array);
        Span(T[] array, int start, int length);
        Span(void* pointer, int length);
        Span(System.Pinnable<T> pinnable, nint byteOffset, int length);
        int get_Length();
        bool Equals(object obj);
        int GetHashCode();
        ref T get_Item(int index);
        ref T GetPinnableReference();
        void Clear();
        void CopyTo(System.Span<T> destination);
        bool TryCopyTo(System.Span<T> destination);
        string ToString();
        System.Span<T> Slice(int start);
        System.Span<T> Slice(int start, int length);
        ref T DangerousGetPinnableReference();
        System.Pinnable<T> get_Pinnable();
        nint get_ByteOffset();
    }

    class SpanDebugView<T>
    {
    }

    class SpanHelpers
    {
        static /*0x2abf114*/ int IndexOf(ref byte searchSpace, byte value, int length);
        static /*0x2abf3d0*/ bool SequenceEqual(ref byte first, ref byte second, System.NUInt length);
        static /*0x2abf5f4*/ int IndexOf(ref char searchSpace, char value, int length);
        static int IndexOf<T>(ref T searchSpace, T value, int length);
        static bool SequenceEqual<T>(ref T first, ref T second, int length);
        static void CopyTo<T>(ref T dst, int dstLength, ref T src, int srcLength);
        static nint Add<T>(nint start, int index);
        static bool IsReferenceOrContainsReferences<T>();
        static /*0x2abf6a0*/ bool IsReferenceOrContainsReferencesCore(System.Type type);
        static /*0x2abfa64*/ void ClearLessThanPointerSized(byte* ptr, nuint byteLength);
        static /*0x2abfb24*/ void ClearLessThanPointerSized(ref byte b, nuint byteLength);
        static /*0x2abfc00*/ void ClearPointerSizedWithoutReferences(ref byte b, nuint byteLength);
        static /*0x2abff64*/ void ClearPointerSizedWithReferences(ref nint ip, nuint pointerSizeLength);
        static /*0x2ac02c8*/ bool LessThanEqual(nint index, nuint length);

        struct Reg64
        {
        }

        struct Reg32
        {
        }

        struct Reg16
        {
        }

        class PerTypeValues<T>
        {
            static /*0x0*/ bool IsReferenceOrContainsReferences;
            static /*0x0*/ T[] EmptyArray;
            static /*0x0*/ nint ArrayAdjustment;

            static PerTypeValues();
            static nint MeasureArrayAdjustment();
        }
    }

    struct NUInt
    {
        /*0x10*/ void* _value;

        static /*0x2abdb54*/ System.NUInt op_Explicit(int value);
        static /*0x2abdb5c*/ void* op_Explicit(System.NUInt value);
        static /*0x2abdb60*/ System.NUInt op_Multiply(System.NUInt left, System.NUInt right);
        /*0xb2176c*/ NUInt(uint value);
        /*0xb21778*/ NUInt(ulong value);
    }

    class Pinnable<T>
    {
        /*0x0*/ T Data;
    }

    struct MutableDecimal
    {
        /*0x10*/ uint Flags;
        /*0x14*/ uint High;
        /*0x18*/ uint Low;
        /*0x1c*/ uint Mid;

        /*0xb21728*/ bool get_IsNegative();
        /*0xb21734*/ void set_IsNegative(bool value);
        /*0xb21750*/ int get_Scale();
        /*0xb21758*/ void set_Scale(int value);
    }

    class SR
    {
        static /*0x0*/ System.Resources.ResourceManager s_resourceManager;
        static /*0x8*/ System.Type <ResourceType>k__BackingField;

        static /*0x2abeea0*/ SR();
        static /*0x2abe770*/ System.Resources.ResourceManager get_ResourceManager();
        static /*0x2abe874*/ bool UsingResourceKeys();
        static /*0x2abe87c*/ string GetResourceString(string resourceKey, string defaultString);
        static /*0x2abe9b4*/ string Format(string resourceFormat, object p1);
        static /*0x2abea9c*/ System.Type get_ResourceType();
        static /*0x2abeb00*/ string get_NotSupported_CannotCallEqualsOnSpan();
        static /*0x2abeb74*/ string get_NotSupported_CannotCallGetHashCodeOnSpan();
        static /*0x2abebe8*/ string get_Argument_InvalidTypeWithPointersNotSupported();
        static /*0x2abec5c*/ string get_Argument_DestinationTooShort();
        static /*0x2abecd0*/ string get_Argument_BadFormatSpecifier();
        static /*0x2abed44*/ string get_Argument_GWithPrecisionNotSupported();
        static /*0x2abedb8*/ string get_Argument_PrecisionTooLarge();
        static /*0x2abee2c*/ string get_EndPositionNotReached();
    }

    namespace Numerics
    {
        namespace Hashing
        {
            class HashHelpers
            {
                static /*0x0*/ int RandomSeed;

                static /*0x2abd76c*/ HashHelpers();
                static /*0x2abd75c*/ int Combine(int h1, int h2);
            }
        }
    }

    namespace Runtime
    {
        namespace InteropServices
        {
            class SequenceMarshal
            {
                static /*0x2abef3c*/ bool TryGetString(System.Buffers.ReadOnlySequence<char> sequence, ref string text, ref int start, ref int length);
            }

            class MemoryMarshal
            {
                static bool TryGetArray<T>(System.ReadOnlyMemory<T> memory, ref System.ArraySegment<T> segment);
                static bool TryGetMemoryManager<T, TManager>(System.ReadOnlyMemory<T> memory, ref TManager manager, ref int start, ref int length);
                static /*0x2abda50*/ bool TryGetString(System.ReadOnlyMemory<char> memory, ref string text, ref int start, ref int length);
                static ref T GetReference<T>(System.Span<T> span);
                static ref T GetReference<T>(System.ReadOnlySpan<T> span);
                static System.Span<TTo> Cast<TFrom, TTo>(System.Span<TFrom> span);
                static System.ReadOnlySpan<TTo> Cast<TFrom, TTo>(System.ReadOnlySpan<TFrom> span);
            }
        }
    }

    namespace Buffers
    {
        class ArrayMemoryPool<T> : System.Buffers.MemoryPool<T>
        {
            ArrayMemoryPool();
            System.Buffers.IMemoryOwner<T> Rent(int minimumBufferSize);
            void Dispose(bool disposing);

            class ArrayMemoryPoolBuffer<T> : System.Buffers.IMemoryOwner<T>, System.IDisposable
            {
                /*0x0*/ T[] _array;

                ArrayMemoryPoolBuffer(int size);
                System.Memory<T> get_Memory();
                void Dispose();
            }
        }

        class BuffersExtensions
        {
            static void CopyTo<T>(ref System.Buffers.ReadOnlySequence<T> source, System.Span<T> destination);
            static void CopyToMultiSegment<T>(ref System.Buffers.ReadOnlySequence<T> sequence, System.Span<T> destination);
            static T[] ToArray<T>(ref System.Buffers.ReadOnlySequence<T> sequence);
        }

        interface IBufferWriter<T>
        {
            void Advance(int count);
            System.Memory<T> GetMemory(int sizeHint);
            System.Span<T> GetSpan(int sizeHint);
        }

        class MemoryPool<T> : System.IDisposable
        {
            static /*0x0*/ System.Buffers.MemoryPool<T> s_shared;

            static MemoryPool();
            MemoryPool();
            System.Buffers.IMemoryOwner<T> Rent(int minBufferSize);
            void Dispose();
            void Dispose(bool disposing);
        }

        struct ReadOnlySequence<T>
        {
            static /*0x0*/ System.Buffers.ReadOnlySequence<T> Empty;
            /*0x0*/ System.SequencePosition _sequenceStart;
            /*0x0*/ System.SequencePosition _sequenceEnd;

            static ReadOnlySequence();
            static System.SequencePosition SeekMultiSegment(System.Buffers.ReadOnlySequenceSegment<T> currentSegment, object endObject, int endIndex, long offset, System.ExceptionArgument argument);
            static int GetIndex(ref System.SequencePosition position);
            static bool InRange(uint value, uint start, uint end);
            static bool InRange(ulong value, ulong start, ulong end);
            ReadOnlySequence(object startSegment, int startIndexAndFlags, object endSegment, int endIndexAndFlags);
            ReadOnlySequence(System.Buffers.ReadOnlySequenceSegment<T> startSegment, int startIndex, System.Buffers.ReadOnlySequenceSegment<T> endSegment, int endIndex);
            ReadOnlySequence(T[] array);
            ReadOnlySequence(System.ReadOnlyMemory<T> memory);
            long get_Length();
            bool get_IsEmpty();
            bool get_IsSingleSegment();
            System.ReadOnlyMemory<T> get_First();
            System.SequencePosition get_Start();
            System.SequencePosition get_End();
            System.Buffers.ReadOnlySequence<T> Slice(long start, System.SequencePosition end);
            System.Buffers.ReadOnlySequence<T> Slice(System.SequencePosition start, long length);
            System.Buffers.ReadOnlySequence<T> Slice(int start, System.SequencePosition end);
            System.Buffers.ReadOnlySequence<T> Slice(System.SequencePosition start, int length);
            System.Buffers.ReadOnlySequence<T> Slice(System.SequencePosition start, System.SequencePosition end);
            System.Buffers.ReadOnlySequence<T> Slice(System.SequencePosition start);
            string ToString();
            System.Buffers.ReadOnlySequence.Enumerator<T> GetEnumerator();
            System.SequencePosition GetPosition(long offset);
            System.SequencePosition GetPosition(long offset, System.SequencePosition origin);
            bool TryGet(ref System.SequencePosition position, ref System.ReadOnlyMemory<T> memory, bool advance);
            bool TryGetBuffer(ref System.SequencePosition position, ref System.ReadOnlyMemory<T> memory, ref System.SequencePosition next);
            System.ReadOnlyMemory<T> GetFirstBuffer();
            System.SequencePosition Seek(ref System.SequencePosition start, ref System.SequencePosition end, long offset, System.ExceptionArgument argument);
            void BoundsCheck(ref System.SequencePosition position);
            void BoundsCheck(uint sliceStartIndex, object sliceStartObject, uint sliceEndIndex, object sliceEndObject);
            System.Buffers.ReadOnlySequence.SequenceType<T> GetSequenceType();
            System.Buffers.ReadOnlySequence<T> SliceImpl(ref System.SequencePosition start, ref System.SequencePosition end);
            long GetLength();
            bool TryGetString(ref string text, ref int start, ref int length);

            struct Enumerator<T>
            {
                /*0x0*/ System.Buffers.ReadOnlySequence<T> _sequence;
                /*0x0*/ System.SequencePosition _next;
                /*0x0*/ System.ReadOnlyMemory<T> _currentMemory;

                Enumerator(ref System.Buffers.ReadOnlySequence<T> sequence);
                System.ReadOnlyMemory<T> get_Current();
                bool MoveNext();
            }

            enum SequenceType<T>
            {
                MultiSegment = 0,
                Array = 1,
                MemoryManager = 2,
                String = 3,
                Empty = 4,
            }
        }

        class ReadOnlySequence
        {
            static /*0x2abe740*/ int SegmentToSequenceStart(int startIndex);
            static /*0x2abe744*/ int SegmentToSequenceEnd(int endIndex);
            static /*0x2abe748*/ int ArrayToSequenceStart(int startIndex);
            static /*0x2abe74c*/ int ArrayToSequenceEnd(int endIndex);
            static /*0x2abe754*/ int MemoryManagerToSequenceStart(int startIndex);
            static /*0x2abe75c*/ int MemoryManagerToSequenceEnd(int endIndex);
            static /*0x2abe760*/ int StringToSequenceStart(int startIndex);
            static /*0x2abe768*/ int StringToSequenceEnd(int endIndex);
        }

        class ReadOnlySequenceDebugView<T>
        {
        }

        class ReadOnlySequenceSegment<T>
        {
            /*0x0*/ System.ReadOnlyMemory<T> <Memory>k__BackingField;
            /*0x0*/ System.Buffers.ReadOnlySequenceSegment<T> <Next>k__BackingField;
            /*0x0*/ long <RunningIndex>k__BackingField;

            ReadOnlySequenceSegment();
            System.ReadOnlyMemory<T> get_Memory();
            void set_Memory(System.ReadOnlyMemory<T> value);
            System.Buffers.ReadOnlySequenceSegment<T> get_Next();
            void set_Next(System.Buffers.ReadOnlySequenceSegment<T> value);
            long get_RunningIndex();
            void set_RunningIndex(long value);
        }

        struct StandardFormat : System.IEquatable<System.Buffers.StandardFormat>
        {
            /*0x10*/ byte _format;
            /*0x11*/ byte _precision;

            static /*0x2ac0424*/ System.Buffers.StandardFormat op_Implicit(char symbol);
            /*0xb21f3c*/ StandardFormat(char symbol, byte precision);
            /*0xb21f0c*/ char get_Symbol();
            /*0xb21f14*/ byte get_Precision();
            /*0xb21f1c*/ bool get_IsDefault();
            /*0xb21f44*/ bool Equals(object obj);
            /*0xb21f4c*/ int GetHashCode();
            /*0xb21fa0*/ bool Equals(System.Buffers.StandardFormat other);
            /*0xb21fc8*/ string ToString();
        }

        interface IMemoryOwner<T> : System.IDisposable
        {
            System.Memory<T> get_Memory();
        }

        class MemoryManager<T> : System.Buffers.IMemoryOwner<T>, System.IDisposable
        {
            MemoryManager();
            System.Memory<T> get_Memory();
            System.Span<T> GetSpan();
            bool TryGetArray(ref System.ArraySegment<T> segment);
            void System.IDisposable.Dispose();
            void Dispose(bool disposing);
        }

        namespace Text
        {
            class Utf8Formatter
            {
                static /*0x0*/ uint[] DayAbbreviations;
                static /*0x8*/ uint[] DayAbbreviationsLowercase;
                static /*0x10*/ uint[] MonthAbbreviations;
                static /*0x18*/ uint[] MonthAbbreviationsLowercase;

                static /*0x2ac1ed8*/ Utf8Formatter();
                static /*0x2ac10a0*/ bool TryFormat(decimal value, System.Span<byte> destination, ref int bytesWritten, System.Buffers.StandardFormat format);
                static /*0x2ac1b88*/ bool TryFormatDecimalE(ref System.NumberBuffer number, System.Span<byte> destination, ref int bytesWritten, byte precision, byte exponentSymbol);
                static /*0x2ac17e4*/ bool TryFormatDecimalF(ref System.NumberBuffer number, System.Span<byte> destination, ref int bytesWritten, byte precision);
                static /*0x2ac14bc*/ bool TryFormatDecimalG(ref System.NumberBuffer number, System.Span<byte> destination, ref int bytesWritten);
            }

            class ParserHelpers
            {
                static /*0x0*/ byte[] s_hexLookup;

                static /*0x2abe6b0*/ ParserHelpers();
                static /*0x2abe6a0*/ bool IsDigit(int i);
            }

            class Utf8Parser
            {
                static /*0x0*/ int[] s_daysToMonth365;
                static /*0x8*/ int[] s_daysToMonth366;

                static /*0x2ac2e78*/ Utf8Parser();
                static /*0x2ac2024*/ bool TryParse(System.ReadOnlySpan<byte> source, ref decimal value, ref int bytesConsumed, char standardFormat);
                static /*0x2ac29b8*/ bool TryParseUInt32D(System.ReadOnlySpan<byte> source, ref uint value, ref int bytesConsumed);
                static /*0x2ac2258*/ bool TryParseNumber(System.ReadOnlySpan<byte> source, ref System.NumberBuffer number, ref int bytesConsumed, System.Buffers.Text.Utf8Parser.ParseNumberOptions options, ref bool textUsedExponentNotation);

                enum ParseNumberOptions
                {
                    AllowExponent = 1,
                }
            }
        }

        namespace Binary
        {
            class BinaryPrimitives
            {
                static /*0x2abd53c*/ short ReverseEndianness(short value);
                static /*0x2abd548*/ int ReverseEndianness(int value);
                static /*0x2abd550*/ long ReverseEndianness(long value);
                static /*0x2abd564*/ uint ReverseEndianness(uint value);
                static /*0x2abd56c*/ ulong ReverseEndianness(ulong value);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 2B2055E39CBB1C111FB5C1C05492B3E5AAC607ED;
    static /*0x150*/ <PrivateImplementationDetails> 3CDA7449B0586AB873C75C04BB11D4864F5D7392;
    static /*0x250*/ <PrivateImplementationDetails> 608454F961E288A48E34666C94032BEDEFD399E1;
    static /*0x340*/ <PrivateImplementationDetails> B8B960BE929E7BAB90AE2CAEF2468C56CD5414C1;
    static /*0x370*/ <PrivateImplementationDetails> BD20BFA840DDF83194ECD4397DA071ECD4C1C72F;
    static /*0x38c*/ <PrivateImplementationDetails> C3FB1115E83603E7E71244A6F2D43E22B790B5D1;
    static /*0x39b*/ <PrivateImplementationDetails> C4C38BC485A320D4B7D737DB85E705077FA38BEF;
    static /*0x3cb*/ <PrivateImplementationDetails> DB5930245CE35BDE5EDC35035275D8DD55E139CF;
    static /*0x3f5*/ <PrivateImplementationDetails> DD3AEFEADB1CD615F3017763F1568179FEE640B0;
    static /*0x429*/ <PrivateImplementationDetails> E92B39D8233061927D9ACDE54665E68E7535635A;
    static /*0x45d*/ <PrivateImplementationDetails> EE0B1C00D481FCA3559F2937C3DD3127C35B2FE3;

    struct __StaticArrayInitTypeSize=15
    {
    }

    struct __StaticArrayInitTypeSize=28
    {
    }

    struct __StaticArrayInitTypeSize=42
    {
    }

    struct __StaticArrayInitTypeSize=48
    {
    }

    struct __StaticArrayInitTypeSize=52
    {
    }

    struct __StaticArrayInitTypeSize=240
    {
    }

    struct __StaticArrayInitTypeSize=256
    {
    }

    struct __StaticArrayInitTypeSize=336
    {
    }
}
