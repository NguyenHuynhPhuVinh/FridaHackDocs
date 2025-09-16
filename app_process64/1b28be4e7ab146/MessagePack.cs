class <Module>
{
}

class <>f__AnonymousType0<<Label>j__TPar, <Attr>j__TPar>
{
    /*0x0*/ <Label> <Label>i__Field;
    /*0x0*/ <Attr> <Attr>i__Field;

    /*0x3910ae8*/ <>f__AnonymousType0(<Label> Label, <Attr> Attr);
    /*0x3910ae8*/ <Label> get_Label();
    /*0x3910ae8*/ <Attr> get_Attr();
    /*0x38141c4*/ bool Equals(object value);
    /*0x3814574*/ int GetHashCode();
    /*0x38148bc*/ string ToString();
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x6fa4148*/ EmbeddedAttribute();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class IsUnmanagedAttribute : System.Attribute
            {
                /*0x6fa4150*/ IsUnmanagedAttribute();
            }

            class NullableAttribute : System.Attribute
            {
                /*0x10*/ byte[] NullableFlags;

                /*0x6fa4158*/ NullableAttribute(byte );
                /*0x6fa41e0*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x6fa4210*/ NullableContextAttribute(byte );
            }

            class NativeIntegerAttribute : System.Attribute
            {
                /*0x10*/ bool[] TransformFlags;

                /*0x6fa4238*/ NativeIntegerAttribute();
            }

            class ScopedRefAttribute : System.Attribute
            {
                /*0x6fa42b8*/ ScopedRefAttribute();
            }

            class RefSafetyRulesAttribute : System.Attribute
            {
                /*0x10*/ int Version;

                /*0x6fa42c0*/ RefSafetyRulesAttribute(int );
            }
        }
    }
}

namespace Nerdbank
{
    namespace Streams
    {
        class Sequence<T> : System.Buffers.IBufferWriter<T>, System.IDisposable
        {
            static /*0x0*/ int DefaultLengthFromArrayPool;
            static /*0x0*/ System.Buffers.ReadOnlySequence<T> Empty;
            /*0x0*/ System.Collections.Generic.Stack<Nerdbank.Streams.Sequence.SequenceSegment<T>> segmentPool;
            /*0x0*/ System.Buffers.MemoryPool<T> memoryPool;
            /*0x0*/ System.Buffers.ArrayPool<T> arrayPool;
            /*0x0*/ Nerdbank.Streams.Sequence.SequenceSegment<T> first;
            /*0x0*/ Nerdbank.Streams.Sequence.SequenceSegment<T> last;
            /*0x0*/ int <MinimumSpanLength>k__BackingField;
            /*0x0*/ bool <AutoIncreaseMinimumSpanLength>k__BackingField;

            static /*0x383e7a0*/ Sequence();
            static /*0x3910ae8*/ System.Buffers.ReadOnlySequence<T> op_Implicit(Nerdbank.Streams.Sequence<T> sequence);
            /*0x3816710*/ Sequence(System.Buffers.MemoryPool<T> memoryPool);
            /*0x3816710*/ Sequence(System.Buffers.ArrayPool<T> arrayPool);
            /*0x3814574*/ int get_MinimumSpanLength();
            /*0x3815ed0*/ void set_MinimumSpanLength(int value);
            /*0x3813ffc*/ bool get_AutoIncreaseMinimumSpanLength();
            /*0x3910ae8*/ System.Buffers.ReadOnlySequence<T> get_AsReadOnlySequence();
            /*0x38146fc*/ long get_Length();
            /*0x3910ae8*/ void AdvanceTo(System.SequencePosition position);
            /*0x3815ed0*/ void Advance(int count);
            /*0x3910ae8*/ System.Memory<T> GetMemory(int sizeHint);
            /*0x3910ae8*/ System.Span<T> GetSpan(int sizeHint);
            /*0x38159dc*/ void Dispose();
            /*0x38159dc*/ void Reset();
            /*0x3814964*/ Nerdbank.Streams.Sequence.SequenceSegment<T> GetSegment(int sizeHint);
            /*0x3816710*/ void Append(Nerdbank.Streams.Sequence.SequenceSegment<T> segment);
            /*0x3814a3c*/ Nerdbank.Streams.Sequence.SequenceSegment<T> RecycleAndGetNext(Nerdbank.Streams.Sequence.SequenceSegment<T> segment);
            /*0x38159dc*/ void ConsiderMinimumSizeIncrease();

            class SequenceSegment<T> : System.Buffers.ReadOnlySequenceSegment<T>
            {
                static /*0x0*/ Nerdbank.Streams.Sequence.SequenceSegment<T> Empty;
                static /*0x0*/ bool MayContainReferences;
                /*0x0*/ T[] array;
                /*0x0*/ int <Start>k__BackingField;
                /*0x0*/ int <End>k__BackingField;
                /*0x0*/ System.Buffers.IMemoryOwner<T> <MemoryOwner>k__BackingField;

                static /*0x383e7a0*/ SequenceSegment();
                /*0x38159dc*/ SequenceSegment();
                /*0x3814574*/ int get_Start();
                /*0x3815ed0*/ void set_Start(int value);
                /*0x3814574*/ int get_End();
                /*0x3815ed0*/ void set_End(int value);
                /*0x3910ae8*/ System.Memory<T> get_RemainingMemory();
                /*0x3910ae8*/ System.Span<T> get_RemainingSpan();
                /*0x38148bc*/ System.Buffers.IMemoryOwner<T> get_MemoryOwner();
                /*0x3816710*/ void set_MemoryOwner(System.Buffers.IMemoryOwner<T> value);
                /*0x3910ae8*/ System.Memory<T> get_AvailableMemory();
                /*0x3814574*/ int get_Length();
                /*0x3814574*/ int get_WritableBytes();
                /*0x38148bc*/ Nerdbank.Streams.Sequence.SequenceSegment<T> get_Next();
                /*0x3816710*/ void set_Next(Nerdbank.Streams.Sequence.SequenceSegment<T> value);
                /*0x3813ffc*/ bool get_IsForeignMemory();
                /*0x3816710*/ void Assign(System.Buffers.IMemoryOwner<T> memoryOwner);
                /*0x3816710*/ void Assign(T[] array);
                /*0x3816710*/ void ResetMemory(System.Buffers.ArrayPool<T> arrayPool);
                /*0x3816710*/ void SetNext(Nerdbank.Streams.Sequence.SequenceSegment<T> segment);
                /*0x3815ed0*/ void Advance(int count);
                /*0x3815ed0*/ void AdvanceTo(int offset);
                /*0x3815fb8*/ void ClearReferences(int startIndex, int length);
            }
        }

        class Requires
        {
            static /*0x6fa42e8*/ void Range(bool condition, string parameterName, string message);
            static /*0x6fa4300*/ System.Exception FailRange(string parameterName, string message);
            static /*0x3910ae8*/ T NotNull<T>(T value, string parameterName);
            static /*0x6fa4370*/ void Argument(bool condition, string parameterName, string message);
        }

        class Verify
        {
            static /*0x6fa43c4*/ void Operation(bool condition, string message);
        }
    }
}

namespace MessagePack
{
    struct BufferWriter
    {
        /*0x10*/ System.Buffers.IBufferWriter<byte> _output;
        /*0x18*/ System.Span<byte> _span;
        /*0x28*/ System.ArraySegment<byte> _segment;
        /*0x38*/ int _buffered;
        /*0x40*/ long _bytesCommitted;
        /*0x48*/ MessagePack.SequencePool _sequencePool;
        /*0x50*/ MessagePack.SequencePool.Rental _rental;

        /*0x6fa4410*/ BufferWriter(System.Buffers.IBufferWriter<byte> output);
        /*0x6fa4528*/ BufferWriter(MessagePack.SequencePool sequencePool, byte[] array);
        /*0x6fa4698*/ System.Span<byte> get_Span();
        /*0x6fa46a4*/ MessagePack.SequencePool.Rental get_SequenceRental();
        /*0x6fa46b0*/ System.Span<byte> GetSpan(int sizeHint);
        /*0x6fa4708*/ ref byte GetPointer(int sizeHint);
        /*0x6fa4844*/ void Commit();
        /*0x6fa4a90*/ void Advance(int count);
        /*0x6fa4b4c*/ void Write(System.ReadOnlySpan<byte> source);
        /*0x6fa4ec0*/ void Ensure(int count);
        /*0x6fa4ff4*/ bool TryGetUncommittedSpan(ref System.ReadOnlySpan<byte> span);
        /*0x6fa4f1c*/ void EnsureMore(int count);
        /*0x6fa4c98*/ void WriteMultiBuffer(System.ReadOnlySpan<byte> source);
        /*0x6fa4954*/ void MigrateToSequence();
    }

    struct ExtensionHeader : System.IEquatable<MessagePack.ExtensionHeader>
    {
        /*0x10*/ sbyte <TypeCode>k__BackingField;
        /*0x14*/ uint <Length>k__BackingField;

        /*0x6fa5394*/ ExtensionHeader(sbyte typeCode, uint length);
        /*0x6fa53a0*/ ExtensionHeader(sbyte typeCode, int length);
        /*0x6fa5374*/ sbyte get_TypeCode();
        /*0x6fa537c*/ void set_TypeCode(sbyte value);
        /*0x6fa5384*/ uint get_Length();
        /*0x6fa538c*/ void set_Length(uint value);
        /*0x6fa53f0*/ bool Equals(MessagePack.ExtensionHeader other);
    }

    struct ExtensionResult
    {
        /*0x10*/ sbyte <TypeCode>k__BackingField;
        /*0x18*/ System.Buffers.ReadOnlySequence<byte> <Data>k__BackingField;

        /*0x6fa5418*/ ExtensionResult(sbyte typeCode, System.Buffers.ReadOnlySequence<byte> data);
        /*0x6fa543c*/ void set_TypeCode(sbyte value);
        /*0x6fa5444*/ System.Buffers.ReadOnlySequence<byte> get_Data();
        /*0x6fa5458*/ void set_Data(System.Buffers.ReadOnlySequence<byte> value);
    }

    interface IFormatterResolver
    {
        /*0x38148bc*/ MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();
    }

    class FormatterResolverExtensions
    {
        static /*0x0*/ MessagePack.Internal.ThreadsafeTypeKeyHashTable<System.Func<MessagePack.IFormatterResolver, MessagePack.Formatters.IMessagePackFormatter>> FormatterGetters;
        static /*0x8*/ System.Reflection.MethodInfo GetFormatterRuntimeMethod;

        static /*0x6fa5930*/ FormatterResolverExtensions();
        static /*0x38379c4*/ MessagePack.Formatters.IMessagePackFormatter<T> GetFormatterWithVerify<T>(MessagePack.IFormatterResolver resolver);
        static /*0x6fa5478*/ void Throw(System.TypeInitializationException ex);
        static /*0x6fa54b0*/ void Throw(System.Type t, MessagePack.IFormatterResolver resolver);
        static /*0x6fa5564*/ object GetFormatterDynamic(MessagePack.IFormatterResolver resolver, System.Type type);
        static /*0x6fa58b0*/ object GetFormatterDynamicWithVerify(MessagePack.IFormatterResolver resolver, System.Type type);
    }

    class FormatterNotRegisteredException : MessagePack.MessagePackSerializationException
    {
        /*0x6fa5560*/ FormatterNotRegisteredException(string message);
        /*0x6fa5b00*/ FormatterNotRegisteredException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
    }

    enum MessagePackType
    {
        Unknown = 0,
        Integer = 1,
        Nil = 2,
        Boolean = 3,
        Float = 4,
        String = 5,
        Binary = 6,
        Array = 7,
        Map = 8,
        Extension = 9,
    }

    class MessagePackCode
    {
        static /*0x0*/ MessagePack.MessagePackType[] TypeLookupTable;
        static /*0x8*/ string[] FormatNameTable;

        static /*0x6fa5b84*/ MessagePackCode();
        static /*0x6fa6b60*/ MessagePack.MessagePackType ToMessagePackType(byte code);
        static /*0x6fa6bdc*/ string ToFormatName(byte code);
        static /*0x6fa6c58*/ bool IsPositiveFixInt(byte code);
        static /*0x6fa6c64*/ bool IsNegativeFixInt(byte code);
        static /*0x6fa6c74*/ bool IsFixMap(byte code);
        static /*0x6fa6ce4*/ bool IsFixArray(byte code);
        static /*0x6fa6d40*/ bool IsFixStr(byte code);
        static /*0x6fa6cd0*/ bool CheckBitmask(byte code, byte bitmask, byte targetValue);
    }

    enum MessagePackCompression
    {
        None = 0,
        Lz4Block = 1,
        Lz4BlockArray = 2,
    }

    class MessagePackCompressionExtensions
    {
        static /*0x6fa6d9c*/ bool IsCompression(MessagePack.MessagePackCompression compression);
    }

    class MessagePackEventSource : System.Diagnostics.Tracing.EventSource
    {
        static /*0x0*/ MessagePack.MessagePackEventSource Instance;

        static /*0x6fa6dcc*/ MessagePackEventSource();
        /*0x6fa6da8*/ MessagePackEventSource();
        /*0x6fa6db0*/ void FormatterDynamicallyGeneratedStart();
        /*0x6fa6dbc*/ void FormatterDynamicallyGeneratedStop(string dataType);

        class Tasks
        {
            static System.Diagnostics.Tracing.EventTask FormatterDynamicallyGenerated = 1;
        }
    }

    class MessagePackEventSourceExtensions
    {
        static /*0x6fa6e34*/ void FormatterDynamicallyGeneratedStop(MessagePack.MessagePackEventSource source, System.Type dataType);
    }

    class MessagePackPrimitives
    {
        static /*0x6fa6ea0*/ MessagePack.MessagePackPrimitives.DecodeResult TryReadArrayHeader(System.ReadOnlySpan<byte> source, ref uint count, ref int tokenSize);
        static /*0x6fa7130*/ MessagePack.MessagePackPrimitives.DecodeResult TryReadMapHeader(System.ReadOnlySpan<byte> source, ref uint count, ref int tokenSize);
        static /*0x6fa7294*/ MessagePack.MessagePackPrimitives.DecodeResult TryReadDateTime(System.ReadOnlySpan<byte> source, ref System.DateTime value, ref int tokenSize);
        static /*0x6fa7554*/ MessagePack.MessagePackPrimitives.DecodeResult TryReadDateTime(System.ReadOnlySpan<byte> source, MessagePack.ExtensionHeader header, ref System.DateTime value, ref int tokenSize);
        static /*0x6fa7398*/ MessagePack.MessagePackPrimitives.DecodeResult TryReadExtensionHeader(System.ReadOnlySpan<byte> source, ref MessagePack.ExtensionHeader extensionHeader, ref int tokenSize);
        static /*0x6fa793c*/ MessagePack.MessagePackPrimitives.DecodeResult TryReadBinHeader(System.ReadOnlySpan<byte> source, ref uint length, ref int tokenSize);
        static /*0x6fa7ab0*/ MessagePack.MessagePackPrimitives.DecodeResult TryReadStringHeader(System.ReadOnlySpan<byte> source, ref uint length, ref int tokenSize);
        static /*0x6fa7004*/ bool TryReadBigEndian(System.ReadOnlySpan<byte> source, ref ushort value);
        static /*0x6fa7c4c*/ bool TryReadBigEndian(System.ReadOnlySpan<byte> source, ref short value);
        static /*0x6fa709c*/ bool TryReadBigEndian(System.ReadOnlySpan<byte> source, ref uint value);
        static /*0x6fa7c80*/ bool TryReadBigEndian(System.ReadOnlySpan<byte> source, ref int value);
        static /*0x6fa7874*/ bool TryReadBigEndian(System.ReadOnlySpan<byte> source, ref ulong value);
        static /*0x6fa7908*/ bool TryReadBigEndian(System.ReadOnlySpan<byte> source, ref long value);
        static /*0x6fa7820*/ void AssumesTrue(bool condition);
        static /*0x6fa7cb4*/ MessagePack.MessagePackPrimitives.DecodeResult TryReadByte(System.ReadOnlySpan<byte> source, ref byte value, ref int tokenSize);
        static /*0x6fa7e2c*/ MessagePack.MessagePackPrimitives.DecodeResult TryReadUInt16(System.ReadOnlySpan<byte> source, ref ushort value, ref int tokenSize);
        static /*0x6fa7fa4*/ MessagePack.MessagePackPrimitives.DecodeResult TryReadUInt32(System.ReadOnlySpan<byte> source, ref uint value, ref int tokenSize);
        static /*0x6fa811c*/ MessagePack.MessagePackPrimitives.DecodeResult TryReadUInt64(System.ReadOnlySpan<byte> source, ref ulong value, ref int tokenSize);
        static /*0x6fa826c*/ MessagePack.MessagePackPrimitives.DecodeResult TryReadSByte(System.ReadOnlySpan<byte> source, ref sbyte value, ref int tokenSize);
        static /*0x6fa83e4*/ MessagePack.MessagePackPrimitives.DecodeResult TryReadInt16(System.ReadOnlySpan<byte> source, ref short value, ref int tokenSize);
        static /*0x6fa855c*/ MessagePack.MessagePackPrimitives.DecodeResult TryReadInt32(System.ReadOnlySpan<byte> source, ref int value, ref int tokenSize);
        static /*0x6fa86d8*/ MessagePack.MessagePackPrimitives.DecodeResult TryReadInt64(System.ReadOnlySpan<byte> source, ref long value, ref int tokenSize);
        static /*0x6fa8828*/ MessagePack.MessagePackPrimitives.DecodeResult TryReadSingle(System.ReadOnlySpan<byte> source, ref float value, ref int tokenSize);
        static /*0x6fa89d4*/ MessagePack.MessagePackPrimitives.DecodeResult TryReadDouble(System.ReadOnlySpan<byte> source, ref double value, ref int tokenSize);
        static /*0x6fa8b80*/ bool TryWriteNil(System.Span<byte> destination, ref int bytesWritten);
        static /*0x6fa8be8*/ bool TryWriteArrayHeader(System.Span<byte> destination, uint count, ref int bytesWritten);
        static /*0x6fa8d4c*/ bool TryWriteMapHeader(System.Span<byte> destination, uint count, ref int bytesWritten);
        static /*0x6fa8e68*/ bool TryWrite(System.Span<byte> destination, sbyte value, ref int bytesWritten);
        static /*0x6fa90cc*/ bool TryWrite(System.Span<byte> destination, short value, ref int bytesWritten);
        static /*0x6fa9354*/ bool TryWrite(System.Span<byte> destination, int value, ref int bytesWritten);
        static /*0x6fa9600*/ bool TryWrite(System.Span<byte> destination, long value, ref int bytesWritten);
        static /*0x6fa905c*/ bool TryWriteInt8(System.Span<byte> destination, sbyte value, ref int bytesWritten);
        static /*0x6fa92b4*/ bool TryWriteInt16(System.Span<byte> destination, short value, ref int bytesWritten);
        static /*0x6fa9564*/ bool TryWriteInt32(System.Span<byte> destination, int value, ref int bytesWritten);
        static /*0x6fa984c*/ bool TryWriteInt64(System.Span<byte> destination, long value, ref int bytesWritten);
        static /*0x6fa8f44*/ bool TryWrite(System.Span<byte> destination, byte value, ref int bytesWritten);
        static /*0x6fa91d4*/ bool TryWrite(System.Span<byte> destination, ushort value, ref int bytesWritten);
        static /*0x6fa9470*/ bool TryWrite(System.Span<byte> destination, uint value, ref int bytesWritten);
        static /*0x6fa960c*/ bool TryWrite(System.Span<byte> destination, ulong value, ref int bytesWritten);
        static /*0x6fa995c*/ bool TryWriteUInt8(System.Span<byte> destination, byte value, ref int bytesWritten);
        static /*0x6fa99cc*/ bool TryWriteUInt16(System.Span<byte> destination, ushort value, ref int bytesWritten);
        static /*0x6fa9a6c*/ bool TryWriteUInt32(System.Span<byte> destination, uint value, ref int bytesWritten);
        static /*0x6fa9be8*/ bool TryWriteUInt64(System.Span<byte> destination, ulong value, ref int bytesWritten);
        static /*0x6fa9cac*/ bool TryWrite(System.Span<byte> destination, float value, ref int bytesWritten);
        static /*0x6fa9d54*/ bool TryWrite(System.Span<byte> destination, double value, ref int bytesWritten);
        static /*0x6fa9e00*/ bool TryWrite(System.Span<byte> destination, bool value, ref int bytesWritten);
        static /*0x6fa9e74*/ bool TryWrite(System.Span<byte> destination, char value, ref int bytesWritten);
        static /*0x6fa9e78*/ bool TryWrite(System.Span<byte> destination, System.DateTime value, ref int bytesWritten);
        static /*0x6faa0cc*/ bool TryWriteBinHeader(System.Span<byte> destination, uint length, ref int bytesWritten);
        static /*0x6faa1ec*/ bool TryWriteStringHeader(System.Span<byte> destination, uint byteCount, ref int bytesWritten);
        static /*0x6faa330*/ bool TryWriteExtensionFormatHeader(System.Span<byte> destination, MessagePack.ExtensionHeader extensionHeader, ref int bytesWritten);
        static /*0x6fa98f4*/ bool TryWriteFixIntUnsafe(System.Span<byte> destination, byte value, ref int bytesWritten);
        static /*0x6fa8ff4*/ bool TryWriteNegativeFixIntUnsafe(System.Span<byte> destination, sbyte value, ref int bytesWritten);
        static /*0x6faa534*/ System.Exception ThrowUnreachable();
        static /*0x6fa8d08*/ void WriteBigEndian(System.Span<byte> destination, ushort value);
        static /*0x6fa8d2c*/ void WriteBigEndian(System.Span<byte> destination, uint value);
        static /*0x6fa9c8c*/ void WriteBigEndian(System.Span<byte> destination, ulong value);
        static /*0x6fa9808*/ void WriteBigEndian(System.Span<byte> destination, short value);
        static /*0x6fa982c*/ void WriteBigEndian(System.Span<byte> destination, int value);
        static /*0x6fa98f0*/ void WriteBigEndian(System.Span<byte> destination, long value);
        static /*0x6fa969c*/ bool <TryWrite>g__SlowPath|35_0(System.Span<byte> destination, long value, ref int bytesWritten);
        static /*0x6fa9b08*/ bool <TryWrite>g__SlowPath|43_0(System.Span<byte> destination, ulong value, ref int bytesWritten);

        enum DecodeResult
        {
            Success = 0,
            TokenMismatch = 1,
            EmptyBuffer = 2,
            InsufficientBuffer = 3,
        }

        class Decoders
        {
            static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.IReadInt64[] Int64JumpTable;
            static /*0x8*/ MessagePack.MessagePackPrimitives.Decoders.IReadUInt64[] UInt64JumpTable;

            static /*0x6faa580*/ Decoders();

            interface IReadInt64
            {
                MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref long value, ref int tokenSize);
            }

            interface IReadUInt64
            {
                MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref ulong value, ref int tokenSize);
            }

            class ReadInt64Invalid : MessagePack.MessagePackPrimitives.Decoders.IReadInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadInt64Invalid Instance;

                static /*0x6fab10c*/ ReadInt64Invalid();
                /*0x6fab0f0*/ ReadInt64Invalid();
                /*0x6fab0f8*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref long value, ref int tokenSize);
            }

            class ReadInt64FixInt : MessagePack.MessagePackPrimitives.Decoders.IReadInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadInt64FixInt Instance;

                static /*0x6fab1a4*/ ReadInt64FixInt();
                /*0x6fab174*/ ReadInt64FixInt();
                /*0x6fab17c*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref long value, ref int tokenSize);
            }

            class ReadInt64NegativeFixInt : MessagePack.MessagePackPrimitives.Decoders.IReadInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadInt64NegativeFixInt Instance;

                static /*0x6fab23c*/ ReadInt64NegativeFixInt();
                /*0x6fab20c*/ ReadInt64NegativeFixInt();
                /*0x6fab214*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref long value, ref int tokenSize);
            }

            class ReadInt64UInt8 : MessagePack.MessagePackPrimitives.Decoders.IReadInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadInt64UInt8 Instance;

                static /*0x6fab320*/ ReadInt64UInt8();
                /*0x6fab2a4*/ ReadInt64UInt8();
                /*0x6fab2ac*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref long value, ref int tokenSize);
            }

            class ReadInt64UInt16 : MessagePack.MessagePackPrimitives.Decoders.IReadInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadInt64UInt16 Instance;

                static /*0x6fab440*/ ReadInt64UInt16();
                /*0x6fab388*/ ReadInt64UInt16();
                /*0x6fab390*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref long value, ref int tokenSize);
            }

            class ReadInt64UInt32 : MessagePack.MessagePackPrimitives.Decoders.IReadInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadInt64UInt32 Instance;

                static /*0x6fab560*/ ReadInt64UInt32();
                /*0x6fab4a8*/ ReadInt64UInt32();
                /*0x6fab4b0*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref long value, ref int tokenSize);
            }

            class ReadInt64UInt64 : MessagePack.MessagePackPrimitives.Decoders.IReadInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadInt64UInt64 Instance;

                static /*0x6fab6a8*/ ReadInt64UInt64();
                /*0x6fab5c8*/ ReadInt64UInt64();
                /*0x6fab5d0*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref long value, ref int tokenSize);
            }

            class ReadInt64Int8 : MessagePack.MessagePackPrimitives.Decoders.IReadInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadInt64Int8 Instance;

                static /*0x6fab78c*/ ReadInt64Int8();
                /*0x6fab710*/ ReadInt64Int8();
                /*0x6fab718*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref long value, ref int tokenSize);
            }

            class ReadInt64Int16 : MessagePack.MessagePackPrimitives.Decoders.IReadInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadInt64Int16 Instance;

                static /*0x6fab8ac*/ ReadInt64Int16();
                /*0x6fab7f4*/ ReadInt64Int16();
                /*0x6fab7fc*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref long value, ref int tokenSize);
            }

            class ReadInt64Int32 : MessagePack.MessagePackPrimitives.Decoders.IReadInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadInt64Int32 Instance;

                static /*0x6fab9cc*/ ReadInt64Int32();
                /*0x6fab914*/ ReadInt64Int32();
                /*0x6fab91c*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref long value, ref int tokenSize);
            }

            class ReadInt64Int64 : MessagePack.MessagePackPrimitives.Decoders.IReadInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadInt64Int64 Instance;

                static /*0x6fabaec*/ ReadInt64Int64();
                /*0x6faba34*/ ReadInt64Int64();
                /*0x6faba3c*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref long value, ref int tokenSize);
            }

            class ReadUInt64Invalid : MessagePack.MessagePackPrimitives.Decoders.IReadUInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadUInt64Invalid Instance;

                static /*0x6fabb70*/ ReadUInt64Invalid();
                /*0x6fabb54*/ ReadUInt64Invalid();
                /*0x6fabb5c*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref ulong value, ref int tokenSize);
            }

            class ReadUInt64FixInt : MessagePack.MessagePackPrimitives.Decoders.IReadUInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadUInt64FixInt Instance;

                static /*0x6fabc08*/ ReadUInt64FixInt();
                /*0x6fabbd8*/ ReadUInt64FixInt();
                /*0x6fabbe0*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref ulong value, ref int tokenSize);
            }

            class ReadUInt64NegativeFixInt : MessagePack.MessagePackPrimitives.Decoders.IReadUInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadUInt64NegativeFixInt Instance;

                static /*0x6fabce0*/ ReadUInt64NegativeFixInt();
                /*0x6fabc70*/ ReadUInt64NegativeFixInt();
                /*0x6fabc78*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref ulong value, ref int tokenSize);
            }

            class ReadUInt64UInt8 : MessagePack.MessagePackPrimitives.Decoders.IReadUInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadUInt64UInt8 Instance;

                static /*0x6fabdc4*/ ReadUInt64UInt8();
                /*0x6fabd48*/ ReadUInt64UInt8();
                /*0x6fabd50*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref ulong value, ref int tokenSize);
            }

            class ReadUInt64UInt16 : MessagePack.MessagePackPrimitives.Decoders.IReadUInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadUInt64UInt16 Instance;

                static /*0x6fabee4*/ ReadUInt64UInt16();
                /*0x6fabe2c*/ ReadUInt64UInt16();
                /*0x6fabe34*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref ulong value, ref int tokenSize);
            }

            class ReadUInt64UInt32 : MessagePack.MessagePackPrimitives.Decoders.IReadUInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadUInt64UInt32 Instance;

                static /*0x6fac004*/ ReadUInt64UInt32();
                /*0x6fabf4c*/ ReadUInt64UInt32();
                /*0x6fabf54*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref ulong value, ref int tokenSize);
            }

            class ReadUInt64UInt64 : MessagePack.MessagePackPrimitives.Decoders.IReadUInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadUInt64UInt64 Instance;

                static /*0x6fac124*/ ReadUInt64UInt64();
                /*0x6fac06c*/ ReadUInt64UInt64();
                /*0x6fac074*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref ulong value, ref int tokenSize);
            }

            class ReadUInt64Int8 : MessagePack.MessagePackPrimitives.Decoders.IReadUInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadUInt64Int8 Instance;

                static /*0x6fac214*/ ReadUInt64Int8();
                /*0x6fac18c*/ ReadUInt64Int8();
                /*0x6fac194*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref ulong value, ref int tokenSize);
            }

            class ReadUInt64Int16 : MessagePack.MessagePackPrimitives.Decoders.IReadUInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadUInt64Int16 Instance;

                static /*0x6fac340*/ ReadUInt64Int16();
                /*0x6fac27c*/ ReadUInt64Int16();
                /*0x6fac284*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref ulong value, ref int tokenSize);
            }

            class ReadUInt64Int32 : MessagePack.MessagePackPrimitives.Decoders.IReadUInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadUInt64Int32 Instance;

                static /*0x6fac46c*/ ReadUInt64Int32();
                /*0x6fac3a8*/ ReadUInt64Int32();
                /*0x6fac3b0*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref ulong value, ref int tokenSize);
            }

            class ReadUInt64Int64 : MessagePack.MessagePackPrimitives.Decoders.IReadUInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadUInt64Int64 Instance;

                static /*0x6fac598*/ ReadUInt64Int64();
                /*0x6fac4d4*/ ReadUInt64Int64();
                /*0x6fac4dc*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref ulong value, ref int tokenSize);
            }
        }
    }

    struct MessagePackReader
    {
        /*0x10*/ MessagePack.SequenceReader<byte> reader;
        /*0x90*/ System.Threading.CancellationToken <CancellationToken>k__BackingField;
        /*0x98*/ int <Depth>k__BackingField;

        static /*0x6fafdcc*/ System.IO.EndOfStreamException ThrowNotEnoughBytesException();
        static /*0x6fad2f4*/ System.IO.EndOfStreamException ThrowNotEnoughBytesException(System.Exception innerException);
        static /*0x6facf88*/ System.Exception ThrowInvalidCode(byte code);
        static /*0x6fac970*/ void ThrowInsufficientBufferUnless(bool condition);
        static /*0x6fafe04*/ System.Exception ThrowUnreachable();
        static /*0x6fad630*/ bool <TryReadArrayHeader>g__SlowPath|34_0(ref MessagePack.MessagePackReader self, MessagePack.MessagePackPrimitives.DecodeResult readResult, ref int count, ref int tokenSize);
        static /*0x6fada84*/ bool <TryReadMapHeader>g__SlowPath|36_0(ref MessagePack.MessagePackReader self, MessagePack.MessagePackPrimitives.DecodeResult readResult, ref int count, ref int tokenSize);
        static /*0x6fadfa8*/ float <ReadSingle>g__SlowPath|39_0(ref MessagePack.MessagePackReader self, MessagePack.MessagePackPrimitives.DecodeResult readResult, float value, ref int tokenSize);
        static /*0x6fae2f8*/ double <ReadDouble>g__SlowPath|40_0(ref MessagePack.MessagePackReader self, MessagePack.MessagePackPrimitives.DecodeResult readResult, double value, ref int tokenSize);
        static /*0x6fae648*/ System.DateTime <ReadDateTime>g__SlowPath|41_0(ref MessagePack.MessagePackReader self, MessagePack.MessagePackPrimitives.DecodeResult readResult, System.DateTime value, ref int tokenSize);
        static /*0x6fae9a4*/ System.DateTime <ReadDateTime>g__SlowPath|42_0(ref MessagePack.MessagePackReader self, MessagePack.ExtensionHeader header, MessagePack.MessagePackPrimitives.DecodeResult readResult, System.DateTime value, ref int tokenSize);
        static /*0x6faf980*/ bool <TryReadExtensionFormatHeader>g__SlowPath|48_0(ref MessagePack.MessagePackReader self, MessagePack.MessagePackPrimitives.DecodeResult readResult, ref MessagePack.ExtensionHeader extensionHeader, ref int tokenSize);
        static /*0x6fafe50*/ bool <TryGetBytesLength>g__SlowPath|56_0(ref MessagePack.MessagePackReader self, MessagePack.MessagePackPrimitives.DecodeResult readResult, bool usingBinaryHeader, ref uint length, ref int tokenSize);
        static /*0x6fb0268*/ bool <TryGetStringLengthInBytes>g__SlowPath|57_0(ref MessagePack.MessagePackReader self, MessagePack.MessagePackPrimitives.DecodeResult readResult, ref uint length, ref int tokenSize);
        static /*0x6fb0644*/ byte <ReadByte>g__SlowPath|63_0(ref MessagePack.MessagePackReader self, MessagePack.MessagePackPrimitives.DecodeResult readResult, byte value, ref int tokenSize);
        static /*0x6fb086c*/ ushort <ReadUInt16>g__SlowPath|64_0(ref MessagePack.MessagePackReader self, MessagePack.MessagePackPrimitives.DecodeResult readResult, ushort value, ref int tokenSize);
        static /*0x6fb0bb0*/ uint <ReadUInt32>g__SlowPath|65_0(ref MessagePack.MessagePackReader self, MessagePack.MessagePackPrimitives.DecodeResult readResult, uint value, ref int tokenSize);
        static /*0x6fb0ef8*/ ulong <ReadUInt64>g__SlowPath|66_0(ref MessagePack.MessagePackReader self, MessagePack.MessagePackPrimitives.DecodeResult readResult, ulong value, ref int tokenSize);
        static /*0x6fb1240*/ sbyte <ReadSByte>g__SlowPath|67_0(ref MessagePack.MessagePackReader self, MessagePack.MessagePackPrimitives.DecodeResult readResult, sbyte value, ref int tokenSize);
        static /*0x6fb1588*/ short <ReadInt16>g__SlowPath|68_0(ref MessagePack.MessagePackReader self, MessagePack.MessagePackPrimitives.DecodeResult readResult, short value, ref int tokenSize);
        static /*0x6fb18cc*/ int <ReadInt32>g__SlowPath|69_0(ref MessagePack.MessagePackReader self, MessagePack.MessagePackPrimitives.DecodeResult readResult, int value, ref int tokenSize);
        static /*0x6fb1c14*/ long <ReadInt64>g__SlowPath|70_0(ref MessagePack.MessagePackReader self, MessagePack.MessagePackPrimitives.DecodeResult readResult, long value, ref int tokenSize);
        /*0x6fac600*/ MessagePackReader(System.ReadOnlyMemory<byte> memory);
        /*0x6fac6a4*/ MessagePackReader(ref System.Buffers.ReadOnlySequence<byte> readOnlySequence);
        /*0x6fac740*/ System.Threading.CancellationToken get_CancellationToken();
        /*0x6fac748*/ void set_CancellationToken(System.Threading.CancellationToken value);
        /*0x6fac750*/ int get_Depth();
        /*0x6fac758*/ void set_Depth(int value);
        /*0x6fac760*/ System.Buffers.ReadOnlySequence<byte> get_Sequence();
        /*0x6fac7d0*/ System.SequencePosition get_Position();
        /*0x6fac818*/ bool get_End();
        /*0x6fac860*/ bool get_IsNil();
        /*0x6fac90c*/ MessagePack.MessagePackType get_NextMessagePackType();
        /*0x6fac87c*/ byte get_NextCode();
        /*0x6fac980*/ MessagePack.MessagePackReader Clone(ref System.Buffers.ReadOnlySequence<byte> readOnlySequence);
        /*0x6fac9f0*/ MessagePack.MessagePackReader CreatePeekReader();
        /*0x6faca00*/ void Skip();
        /*0x6faca18*/ bool TrySkip();
        /*0x6fad024*/ MessagePack.Nil ReadNil();
        /*0x6fad0b8*/ bool TryReadNil();
        /*0x6fad124*/ System.Buffers.ReadOnlySequence<byte> ReadRaw(long length);
        /*0x6fad374*/ System.Buffers.ReadOnlySequence<byte> ReadRaw();
        /*0x6fad468*/ int ReadArrayHeader();
        /*0x6fad4e0*/ bool TryReadArrayHeader(ref int count);
        /*0x6fad894*/ int ReadMapHeader();
        /*0x6fad934*/ bool TryReadMapHeader(ref int count);
        /*0x6fadce8*/ bool ReadBoolean();
        /*0x6fadd68*/ char ReadChar();
        /*0x6fade8c*/ float ReadSingle();
        /*0x6fae1d8*/ double ReadDouble();
        /*0x6fae528*/ System.DateTime ReadDateTime();
        /*0x6fae870*/ System.DateTime ReadDateTime(MessagePack.ExtensionHeader header);
        /*0x6faebe0*/ System.Nullable<System.Buffers.ReadOnlySequence<byte>> ReadBytes();
        /*0x6faee00*/ System.Nullable<System.Buffers.ReadOnlySequence<byte>> ReadStringSequence();
        /*0x6faf024*/ bool TryReadStringSpan(ref System.ReadOnlySpan<byte> span);
        /*0x6faf1fc*/ string ReadString();
        /*0x6faf90c*/ MessagePack.ExtensionHeader ReadExtensionFormatHeader();
        /*0x6face64*/ bool TryReadExtensionFormatHeader(ref MessagePack.ExtensionHeader extensionHeader);
        /*0x6fafbb4*/ MessagePack.ExtensionResult ReadExtensionFormat();
        /*0x6faeddc*/ uint GetBytesLength();
        /*0x6facd3c*/ bool TryGetBytesLength(ref uint length);
        /*0x6fb0144*/ bool TryGetStringLengthInBytes(ref uint length);
        /*0x6faeffc*/ uint GetStringLengthInBytes();
        /*0x6faf440*/ string ReadStringSlow(uint byteLength);
        /*0x6faccf8*/ bool TrySkipNextArray();
        /*0x6facc70*/ bool TrySkipNextMap();
        /*0x6fb049c*/ bool TrySkip(int count);
        /*0x6fb0524*/ byte ReadByte();
        /*0x6fadd6c*/ ushort ReadUInt16();
        /*0x6fb0a94*/ uint ReadUInt32();
        /*0x6fb0dd8*/ ulong ReadUInt64();
        /*0x6fb1120*/ sbyte ReadSByte();
        /*0x6fb1468*/ short ReadInt16();
        /*0x6fb17b0*/ int ReadInt32();
        /*0x6fb1af4*/ long ReadInt64();
    }

    class MessagePackSecurity
    {
        static /*0x0*/ MessagePack.MessagePackSecurity TrustedData;
        static /*0x8*/ MessagePack.MessagePackSecurity UntrustedData;
        static /*0x10*/ MessagePack.SipHash Hash;
        /*0x10*/ MessagePack.MessagePackSecurity.ObjectFallbackEqualityComparer objectFallbackEqualityComparer;
        /*0x18*/ bool <HashCollisionResistant>k__BackingField;
        /*0x1c*/ int <MaximumObjectGraphDepth>k__BackingField;

        static /*0x6fb2994*/ MessagePackSecurity();
        static /*0x3910ae8*/ int SecureHash<T>(T value);
        static /*0x6fb21a0*/ int SecureHash(System.ReadOnlySpan<byte> data);
        /*0x6fb1e3c*/ MessagePackSecurity();
        /*0x6fb1fac*/ bool get_HashCollisionResistant();
        /*0x6fb1fb4*/ void set_HashCollisionResistant(bool value);
        /*0x6fb1fc0*/ int get_MaximumObjectGraphDepth();
        /*0x6fb1fc8*/ void set_MaximumObjectGraphDepth(int value);
        /*0x38148bc*/ System.Collections.Generic.IEqualityComparer<T> GetEqualityComparer<T>();
        /*0x6fb1fd0*/ System.Collections.IEqualityComparer GetEqualityComparer();
        /*0x38148bc*/ System.Collections.Generic.IEqualityComparer<T> GetHashCollisionResistantEqualityComparer<T>();
        /*0x6fb2034*/ void DepthStep(ref MessagePack.MessagePackReader reader);
        /*0x6fb2100*/ System.Collections.IEqualityComparer GetHashCollisionResistantEqualityComparer();

        class HashResistantCache<T>
        {
            static /*0x0*/ System.Collections.Generic.IEqualityComparer<T> EqualityComparer;

            static /*0x383e7a0*/ HashResistantCache();
        }

        class CollisionResistantHasher<T> : System.Collections.Generic.IEqualityComparer<T>, System.Collections.IEqualityComparer
        {
            /*0x38159dc*/ CollisionResistantHasher();
            /*0x3910ae8*/ bool Equals(T x, T y);
            /*0x3814200*/ bool System.Collections.IEqualityComparer.Equals(object x, object y);
            /*0x381467c*/ int GetHashCode(object obj);
            /*0x3910ae8*/ int GetHashCode(T value);
        }

        class CollisionResistantHasherUnmanaged<T> : MessagePack.MessagePackSecurity.CollisionResistantHasher<T>
        {
            static /*0x0*/ MessagePack.MessagePackSecurity.CollisionResistantHasherUnmanaged<T> Instance;

            static /*0x383e7a0*/ CollisionResistantHasherUnmanaged();
            /*0x38159dc*/ CollisionResistantHasherUnmanaged();
            /*0x3910ae8*/ int GetHashCode(T value);
        }

        class ObjectFallbackEqualityComparer : System.Collections.Generic.IEqualityComparer<object>, System.Collections.IEqualityComparer
        {
            static /*0x0*/ System.Lazy<System.Reflection.MethodInfo> GetHashCollisionResistantEqualityComparerOpenGenericMethod;
            /*0x10*/ MessagePack.MessagePackSecurity security;
            /*0x18*/ MessagePack.Internal.ThreadsafeTypeKeyHashTable<System.Collections.IEqualityComparer> equalityComparerCache;

            static /*0x6fb3324*/ ObjectFallbackEqualityComparer();
            /*0x6fb1eb0*/ ObjectFallbackEqualityComparer(MessagePack.MessagePackSecurity security);
            /*0x6fb2e04*/ bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y);
            /*0x6fb2e70*/ bool System.Collections.IEqualityComparer.Equals(object x, object y);
            /*0x6fb2f40*/ int GetHashCode(object value);

            class <>c
            {
                static /*0x0*/ MessagePack.MessagePackSecurity.ObjectFallbackEqualityComparer.<> <>9;
                static /*0x8*/ System.Func<System.Reflection.MethodInfo, bool> <>9__7_1;

                static /*0x6fb343c*/ <>c();
                /*0x6fb34a4*/ <>c();
                /*0x6fb34ac*/ System.Reflection.MethodInfo <.cctor>b__7_0();
                /*0x6fb3608*/ bool <.cctor>b__7_1(System.Reflection.MethodInfo m);
            }
        }

        class SingleEqualityComparer : MessagePack.MessagePackSecurity.CollisionResistantHasherUnmanaged<float>
        {
            static /*0x0*/ MessagePack.MessagePackSecurity.SingleEqualityComparer Instance;

            static /*0x6fb3778*/ SingleEqualityComparer();
            /*0x6fb370c*/ SingleEqualityComparer();
            /*0x6fb3690*/ int GetHashCode(float value);
        }

        class DoubleEqualityComparer : MessagePack.MessagePackSecurity.CollisionResistantHasherUnmanaged<double>
        {
            static /*0x0*/ MessagePack.MessagePackSecurity.DoubleEqualityComparer Instance;

            static /*0x6fb38c4*/ DoubleEqualityComparer();
            /*0x6fb3858*/ DoubleEqualityComparer();
            /*0x6fb37dc*/ int GetHashCode(double value);
        }

        class DateTimeEqualityComparer : MessagePack.MessagePackSecurity.CollisionResistantHasherUnmanaged<System.DateTime>
        {
            static /*0x0*/ MessagePack.MessagePackSecurity.DateTimeEqualityComparer Instance;

            static /*0x6fb3a3c*/ DateTimeEqualityComparer();
            /*0x6fb39d0*/ DateTimeEqualityComparer();
            /*0x6fb3928*/ int GetHashCode(System.DateTime value);
        }

        class DateTimeOffsetEqualityComparer : MessagePack.MessagePackSecurity.CollisionResistantHasherUnmanaged<System.DateTimeOffset>
        {
            static /*0x0*/ MessagePack.MessagePackSecurity.DateTimeOffsetEqualityComparer Instance;

            static /*0x6fb3bf8*/ DateTimeOffsetEqualityComparer();
            /*0x6fb3b8c*/ DateTimeOffsetEqualityComparer();
            /*0x6fb3aa0*/ int GetHashCode(System.DateTimeOffset value);
        }

        class StringEqualityComparer : MessagePack.MessagePackSecurity.CollisionResistantHasher<string>
        {
            static /*0x0*/ MessagePack.MessagePackSecurity.StringEqualityComparer Instance;

            static /*0x6fb3d94*/ StringEqualityComparer();
            /*0x6fb3d4c*/ StringEqualityComparer();
            /*0x6fb3c5c*/ int GetHashCode(string value);
        }

        class CollisionResistantEnumHasher<TEnum, TUnderlying> : System.Collections.Generic.IEqualityComparer<TEnum>, System.Collections.IEqualityComparer
        {
            static /*0x0*/ MessagePack.MessagePackSecurity.CollisionResistantEnumHasher<TEnum, TUnderlying> Instance;

            static /*0x383e7a0*/ CollisionResistantEnumHasher();
            /*0x38159dc*/ CollisionResistantEnumHasher();
            /*0x3910ae8*/ bool Equals(TEnum x, TEnum y);
            /*0x3910ae8*/ int GetHashCode(TEnum obj);
            /*0x3814200*/ bool System.Collections.IEqualityComparer.Equals(object x, object y);
            /*0x381467c*/ int System.Collections.IEqualityComparer.GetHashCode(object obj);
        }
    }

    class MessagePackSerializationException : System.Exception
    {
        static /*0x3836db8*/ System.Exception ThrowUnexpectedNilWhileDeserializing<T>();
        /*0x6fb3df8*/ MessagePackSerializationException();
        /*0x6fa5a98*/ MessagePackSerializationException(string message);
        /*0x6fb3e50*/ MessagePackSerializationException(string message, System.Exception inner);
        /*0x6fa5b04*/ MessagePackSerializationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
    }

    class MessagePackSerializer
    {
        static /*0x0*/ MessagePack.MessagePackSerializerOptions defaultOptions;
        static /*0x8*/ MessagePack.MessagePackSerializer.LZ4Transform LZ4CodecEncode;
        static /*0x10*/ MessagePack.MessagePackSerializer.LZ4Transform LZ4CodecDecode;
        static /*0x18*/ System.Func<System.Type, MessagePack.MessagePackSerializer.CompiledMethods> CreateCompiledMethods;
        static /*0x20*/ MessagePack.Internal.ThreadsafeTypeKeyHashTable<MessagePack.MessagePackSerializer.CompiledMethods> Serializes;
        [ThreadStatic] static byte[] scratchArray;

        static /*0x6fb5b38*/ MessagePackSerializer();
        static /*0x6fb3ec0*/ MessagePack.MessagePackSerializerOptions get_DefaultOptions();
        static /*0x6fb3fb8*/ void set_DefaultOptions(MessagePack.MessagePackSerializerOptions value);
        static /*0x3910ae8*/ void Serialize<T>(System.Buffers.IBufferWriter<byte> writer, T value, MessagePack.MessagePackSerializerOptions options, System.Threading.CancellationToken cancellationToken);
        static /*0x3910ae8*/ void Serialize<T>(ref MessagePack.MessagePackWriter writer, T value, MessagePack.MessagePackSerializerOptions options);
        static /*0x3910ae8*/ byte[] Serialize<T>(T value, MessagePack.MessagePackSerializerOptions options, System.Threading.CancellationToken cancellationToken);
        static /*0x3910ae8*/ T Deserialize<T>(ref System.Buffers.ReadOnlySequence<byte> byteSequence, MessagePack.MessagePackSerializerOptions options, System.Threading.CancellationToken cancellationToken);
        static /*0x3910ae8*/ T Deserialize<T>(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        static /*0x3910ae8*/ T Deserialize<T>(System.ReadOnlyMemory<byte> buffer, MessagePack.MessagePackSerializerOptions options, System.Threading.CancellationToken cancellationToken);
        static /*0x6fb4020*/ int LZ4Operation(ref System.Buffers.ReadOnlySequence<byte> input, System.Span<byte> output, MessagePack.MessagePackSerializer.LZ4Transform lz4Operation);
        static /*0x6fb43a0*/ bool TryDecompress(ref MessagePack.MessagePackReader reader, System.Buffers.IBufferWriter<byte> writer);
        static /*0x6fb4b48*/ void ToLZ4BinaryCore(ref System.Buffers.ReadOnlySequence<byte> msgpackUncompressedData, ref MessagePack.MessagePackWriter writer, MessagePack.MessagePackCompression compression, int minCompressionSize);
        static /*0x6fb5708*/ int GetUInt32WriteSize(uint value);
        static /*0x6fb5788*/ void WriteBin32Header(uint value, System.Span<byte> span);
        static /*0x6fb5870*/ bool IsMessagePackFixedSizePrimitiveTypeHelper(System.Type type);

        class LZ4Transform : System.MulticastDelegate
        {
            /*0x6fb5cfc*/ LZ4Transform(object object, nint method);
            /*0x6fb5d9c*/ int Invoke(System.ReadOnlySpan<byte> input, System.Span<byte> output);
        }

        class PrimitiveChecker<T>
        {
            static /*0x0*/ bool IsMessagePackFixedSizePrimitive;

            static /*0x383e7a0*/ PrimitiveChecker();
        }

        class CompiledMethods
        {
            /*0x10*/ System.Func<object, MessagePack.MessagePackSerializerOptions, System.Threading.CancellationToken, System.Byte[]> Serialize_T_Options;
            /*0x18*/ System.Action<System.IO.Stream, object, MessagePack.MessagePackSerializerOptions, System.Threading.CancellationToken> Serialize_Stream_T_Options_CancellationToken;
            /*0x20*/ System.Func<System.IO.Stream, object, MessagePack.MessagePackSerializerOptions, System.Threading.CancellationToken, System.Threading.Tasks.Task> SerializeAsync_Stream_T_Options_CancellationToken;
            /*0x28*/ MessagePack.MessagePackSerializer.CompiledMethods.MessagePackWriterSerialize Serialize_MessagePackWriter_T_Options;
            /*0x30*/ System.Action<System.Buffers.IBufferWriter<byte>, object, MessagePack.MessagePackSerializerOptions, System.Threading.CancellationToken> Serialize_IBufferWriter_T_Options_CancellationToken;
            /*0x38*/ MessagePack.MessagePackSerializer.CompiledMethods.MessagePackReaderDeserialize Deserialize_MessagePackReader_Options;
            /*0x40*/ System.Func<System.IO.Stream, MessagePack.MessagePackSerializerOptions, System.Threading.CancellationToken, object> Deserialize_Stream_Options_CancellationToken;
            /*0x48*/ System.Func<System.IO.Stream, MessagePack.MessagePackSerializerOptions, System.Threading.CancellationToken, System.Threading.Tasks.ValueTask<object>> DeserializeAsync_Stream_Options_CancellationToken;
            /*0x50*/ System.Func<System.ReadOnlyMemory<byte>, MessagePack.MessagePackSerializerOptions, System.Threading.CancellationToken, object> Deserialize_ReadOnlyMemory_Options;
            /*0x58*/ System.Func<System.Buffers.ReadOnlySequence<byte>, MessagePack.MessagePackSerializerOptions, System.Threading.CancellationToken, object> Deserialize_ReadOnlySequence_Options_CancellationToken;

            static /*0x6fb8de8*/ void ThrowRefStructNotSupported();
            static /*0x6fb8a70*/ System.Reflection.MethodInfo GetMethod(string methodName, System.Type type, System.Type[] parameters);
            /*0x6fb5e08*/ CompiledMethods(System.Type type);
            /*0x6fb5db0*/ bool get_PreferInterpretation();

            class MessagePackWriterSerialize : System.MulticastDelegate
            {
                /*0x6fb8c60*/ MessagePackWriterSerialize(object object, nint method);
                /*0x6fb8e3c*/ void Invoke(ref MessagePack.MessagePackWriter writer, object value, MessagePack.MessagePackSerializerOptions options);
            }

            class MessagePackReaderDeserialize : System.MulticastDelegate
            {
                /*0x6fb8d14*/ MessagePackReaderDeserialize(object object, nint method);
                /*0x6fb8e50*/ object Invoke(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
            }

            class <>c
            {
                static /*0x0*/ MessagePack.MessagePackSerializer.CompiledMethods.<> <>9;
                static /*0x8*/ MessagePack.MessagePackSerializer.CompiledMethods.MessagePackWriterSerialize <>9__14_4;
                static /*0x10*/ MessagePack.MessagePackSerializer.CompiledMethods.MessagePackReaderDeserialize <>9__14_5;

                static /*0x6fb8e64*/ <>c();
                /*0x6fb8ecc*/ <>c();
                /*0x6fb8ed4*/ void <.ctor>b__14_4(ref MessagePack.MessagePackWriter x, object y, MessagePack.MessagePackSerializerOptions z);
                /*0x6fb8edc*/ object <.ctor>b__14_5(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
            }

            class <>c__DisplayClass14_0
            {
                /*0x10*/ System.Reflection.MethodInfo serialize;

                /*0x6fb8a68*/ <>c__DisplayClass14_0();
                /*0x6fb8ee4*/ byte[] <.ctor>b__0(object x, MessagePack.MessagePackSerializerOptions y, System.Threading.CancellationToken z);
            }

            class <>c__DisplayClass14_1
            {
                /*0x10*/ System.Reflection.MethodInfo serialize;

                /*0x6fb8c48*/ <>c__DisplayClass14_1();
                /*0x6fb907c*/ void <.ctor>b__1(System.IO.Stream x, object y, MessagePack.MessagePackSerializerOptions z, System.Threading.CancellationToken a);
            }

            class <>c__DisplayClass14_2
            {
                /*0x10*/ System.Reflection.MethodInfo serialize;

                /*0x6fb8c50*/ <>c__DisplayClass14_2();
                /*0x6fb921c*/ System.Threading.Tasks.Task <.ctor>b__2(System.IO.Stream x, object y, MessagePack.MessagePackSerializerOptions z, System.Threading.CancellationToken a);
            }

            class <>c__DisplayClass14_3
            {
                /*0x10*/ System.Reflection.MethodInfo serialize;

                /*0x6fb8c58*/ <>c__DisplayClass14_3();
                /*0x6fb9404*/ void <.ctor>b__3(System.Buffers.IBufferWriter<byte> x, object y, MessagePack.MessagePackSerializerOptions z, System.Threading.CancellationToken a);
            }

            class <>c__DisplayClass14_4
            {
                /*0x10*/ System.Reflection.MethodInfo deserialize;

                /*0x6fb8dc8*/ <>c__DisplayClass14_4();
                /*0x6fb95a4*/ object <.ctor>b__6(System.IO.Stream x, MessagePack.MessagePackSerializerOptions y, System.Threading.CancellationToken z);
            }

            class <>c__DisplayClass14_5
            {
                /*0x10*/ System.Reflection.MethodInfo deserialize;

                /*0x6fb8dd0*/ <>c__DisplayClass14_5();
                /*0x6fb9704*/ System.Threading.Tasks.ValueTask<object> <.ctor>b__7(System.IO.Stream x, MessagePack.MessagePackSerializerOptions y, System.Threading.CancellationToken z);
            }

            class <>c__DisplayClass14_6
            {
                /*0x10*/ System.Reflection.MethodInfo deserialize;

                /*0x6fb8dd8*/ <>c__DisplayClass14_6();
                /*0x6fb98b8*/ object <.ctor>b__8(System.ReadOnlyMemory<byte> x, MessagePack.MessagePackSerializerOptions y, System.Threading.CancellationToken z);
            }

            class <>c__DisplayClass14_7
            {
                /*0x10*/ System.Reflection.MethodInfo deserialize;

                /*0x6fb8de0*/ <>c__DisplayClass14_7();
                /*0x6fb9a54*/ object <.ctor>b__9(System.Buffers.ReadOnlySequence<byte> x, MessagePack.MessagePackSerializerOptions y, System.Threading.CancellationToken z);
            }

            class <>c__DisplayClass16_0
            {
                /*0x10*/ string methodName;
                /*0x18*/ System.Type[] parameters;

                /*0x6fb8e34*/ <>c__DisplayClass16_0();
                /*0x6fb9bf0*/ bool <GetMethod>b__0(System.Reflection.MethodInfo x);
            }
        }

        class <>c
        {
            static /*0x0*/ MessagePack.MessagePackSerializer.<> <>9;

            static /*0x6fb9db0*/ <>c();
            /*0x6fb9e18*/ <>c();
            /*0x6fb9e20*/ MessagePack.MessagePackSerializer.CompiledMethods <.cctor>b__43_0(System.Type t);
        }
    }

    class MessagePackSerializerOptions
    {
        static /*0x0*/ System.Text.RegularExpressions.Regex AssemblyNameVersionSelectorRegex;
        static /*0x8*/ System.Collections.Generic.HashSet<string> DisallowedTypes;
        /*0x10*/ MessagePack.IFormatterResolver <Resolver>k__BackingField;
        /*0x18*/ MessagePack.MessagePackCompression <Compression>k__BackingField;
        /*0x1c*/ int <CompressionMinLength>k__BackingField;
        /*0x20*/ int <SuggestedContiguousMemorySize>k__BackingField;
        /*0x24*/ System.Nullable<bool> <OldSpec>k__BackingField;
        /*0x26*/ bool <OmitAssemblyVersion>k__BackingField;
        /*0x27*/ bool <AllowAssemblyVersionMismatch>k__BackingField;
        /*0x28*/ MessagePack.MessagePackSecurity <Security>k__BackingField;
        /*0x30*/ MessagePack.SequencePool <SequencePool>k__BackingField;

        static /*0x6fba38c*/ MessagePackSerializerOptions();
        static /*0x6fb9e78*/ MessagePack.MessagePackSerializerOptions get_Standard();
        /*0x6fb9ed0*/ MessagePackSerializerOptions(MessagePack.IFormatterResolver resolver);
        /*0x6fb9ffc*/ MessagePackSerializerOptions(MessagePack.MessagePackSerializerOptions copyFrom);
        /*0x6fba16c*/ MessagePack.IFormatterResolver get_Resolver();
        /*0x6fba174*/ void set_Resolver(MessagePack.IFormatterResolver value);
        /*0x6fba17c*/ MessagePack.MessagePackCompression get_Compression();
        /*0x6fba184*/ void set_Compression(MessagePack.MessagePackCompression value);
        /*0x6fba18c*/ int get_CompressionMinLength();
        /*0x6fba194*/ void set_CompressionMinLength(int value);
        /*0x6fba19c*/ int get_SuggestedContiguousMemorySize();
        /*0x6fba1a4*/ void set_SuggestedContiguousMemorySize(int value);
        /*0x6fba1ac*/ System.Nullable<bool> get_OldSpec();
        /*0x6fba1b4*/ void set_OldSpec(System.Nullable<bool> value);
        /*0x6fba1bc*/ bool get_OmitAssemblyVersion();
        /*0x6fba1c4*/ void set_OmitAssemblyVersion(bool value);
        /*0x6fba1d0*/ bool get_AllowAssemblyVersionMismatch();
        /*0x6fba1d8*/ void set_AllowAssemblyVersionMismatch(bool value);
        /*0x6fba1e4*/ MessagePack.MessagePackSecurity get_Security();
        /*0x6fba1ec*/ void set_Security(MessagePack.MessagePackSecurity value);
        /*0x6fba1f4*/ MessagePack.SequencePool get_SequencePool();
        /*0x6fba1fc*/ void set_SequencePool(MessagePack.SequencePool value);
        /*0x6fba204*/ MessagePack.MessagePackSerializerOptions WithCompression(MessagePack.MessagePackCompression compression);
        /*0x6fba238*/ MessagePack.MessagePackSerializerOptions Clone();

        class MessagePackSerializerOptionsDefaultSettingsLazyInitializationHelper
        {
            static /*0x0*/ MessagePack.MessagePackSerializerOptions Standard;

            static /*0x6fba4e8*/ MessagePackSerializerOptionsDefaultSettingsLazyInitializationHelper();
        }
    }

    class MessagePackStreamReader : System.IDisposable
    {
        /*0x10*/ System.IO.Stream stream;
        /*0x18*/ bool leaveOpen;
        /*0x20*/ MessagePack.SequencePool.Rental sequenceRental;
        /*0x30*/ System.Nullable<System.SequencePosition> endOfLastMessage;

        /*0x6fba594*/ MessagePackStreamReader(System.IO.Stream stream, bool leaveOpen);
        /*0x6fba60c*/ MessagePackStreamReader(System.IO.Stream stream, bool leaveOpen, MessagePack.SequencePool sequencePool);
        /*0x6fba6ec*/ Nerdbank.Streams.Sequence<byte> get_ReadData();
        /*0x6fba6f4*/ System.Threading.Tasks.ValueTask<System.Nullable<System.Buffers.ReadOnlySequence<byte>>> ReadAsync(System.Threading.CancellationToken cancellationToken);
        /*0x6fba86c*/ void Dispose();
        /*0x6fba8d8*/ void Dispose(bool disposing);
        /*0x6fba940*/ void RecycleLastMessage();
        /*0x6fba9e8*/ System.Threading.Tasks.Task<bool> TryReadMoreDataAsync(System.Threading.CancellationToken cancellationToken);
        /*0x6fbab14*/ bool TryReadNextMessage(ref System.Buffers.ReadOnlySequence<byte> completeMessage);

        struct <ReadAsync>d__14 : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder<System.Nullable<System.Buffers.ReadOnlySequence<byte>>> <>t__builder;
            /*0x58*/ MessagePack.MessagePackStreamReader <>4__this;
            /*0x60*/ System.Threading.CancellationToken cancellationToken;
            /*0x68*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;

            /*0x6fbad50*/ void MoveNext();
            /*0x6fbb030*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }

        struct <TryReadMoreDataAsync>d__19 : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder;
            /*0x30*/ System.Threading.CancellationToken cancellationToken;
            /*0x38*/ MessagePack.MessagePackStreamReader <>4__this;
            /*0x40*/ int <bytesRead>5__2;
            /*0x48*/ System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int> <>u__1;

            /*0x6fbb088*/ void MoveNext();
            /*0x6fbb56c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    struct MessagePackWriter
    {
        /*0x10*/ MessagePack.BufferWriter writer;
        /*0x60*/ System.Threading.CancellationToken <CancellationToken>k__BackingField;
        /*0x68*/ bool <OldSpec>k__BackingField;

        static /*0x6fbd760*/ void WriteBigEndian(ushort value, byte* span);
        static /*0x6fbd770*/ void WriteBigEndian(uint value, byte* span);
        static /*0x6fbb840*/ void AssumesTrue(bool condition);
        /*0x6fbb5e8*/ MessagePackWriter(System.Buffers.IBufferWriter<byte> writer);
        /*0x6fbb63c*/ MessagePackWriter(MessagePack.SequencePool sequencePool, byte[] array);
        /*0x6fbb690*/ System.Threading.CancellationToken get_CancellationToken();
        /*0x6fbb698*/ void set_CancellationToken(System.Threading.CancellationToken value);
        /*0x6fbb6a0*/ bool get_OldSpec();
        /*0x6fbb6a8*/ void set_OldSpec(bool value);
        /*0x6fbb6b4*/ MessagePack.MessagePackWriter Clone(System.Buffers.IBufferWriter<byte> writer);
        /*0x6fbb738*/ void Flush();
        /*0x6fbb740*/ void WriteNil();
        /*0x6fb5700*/ void WriteRaw(System.ReadOnlySpan<byte> rawMessagePackBlock);
        /*0x6fb53c4*/ void WriteRaw(ref System.Buffers.ReadOnlySequence<byte> rawMessagePackBlock);
        /*0x6fb573c*/ void WriteArrayHeader(int count);
        /*0x6fbb894*/ void WriteArrayHeader(uint count);
        /*0x6fbb974*/ void WriteMapHeader(int count);
        /*0x6fbb9b8*/ void WriteMapHeader(uint count);
        /*0x6fbba98*/ void Write(byte value);
        /*0x6fbbb78*/ void WriteUInt8(byte value);
        /*0x6fbbc84*/ void Write(sbyte value);
        /*0x6fbbd64*/ void WriteInt8(sbyte value);
        /*0x6fbbe70*/ void Write(ushort value);
        /*0x6fbbf50*/ void WriteUInt16(ushort value);
        /*0x6fbc030*/ void Write(short value);
        /*0x6fbc110*/ void WriteInt16(short value);
        /*0x6fbc1f0*/ void Write(uint value);
        /*0x6fbc2d0*/ void WriteUInt32(uint value);
        /*0x6fbc3b0*/ void Write(int value);
        /*0x6fb5620*/ void WriteInt32(int value);
        /*0x6fbc490*/ void Write(ulong value);
        /*0x6fbc570*/ void WriteUInt64(ulong value);
        /*0x6fbc650*/ void Write(long value);
        /*0x6fbc730*/ void WriteInt64(long value);
        /*0x6fbc810*/ void Write(bool value);
        /*0x6fbc924*/ void Write(char value);
        /*0x6fbca04*/ void Write(float value);
        /*0x6fbcaf4*/ void Write(double value);
        /*0x6fbcbe4*/ void Write(System.DateTime dateTime);
        /*0x6fbcd14*/ void Write(byte[] src);
        /*0x6fbcdb4*/ void Write(System.ReadOnlySpan<byte> src);
        /*0x6fbd020*/ void Write(ref System.Buffers.ReadOnlySequence<byte> src);
        /*0x6fbcee4*/ void WriteBinHeader(int length);
        /*0x6fbd2cc*/ void WriteString(System.ReadOnlySpan<byte> utf8stringBytes);
        /*0x6fbd1a8*/ void WriteStringHeader(int byteCount);
        /*0x6fbd3fc*/ void Write(string value);
        /*0x6fbd4fc*/ void Write(System.ReadOnlySpan<char> value);
        /*0x6fb5500*/ void WriteExtensionFormatHeader(MessagePack.ExtensionHeader extensionHeader);
        /*0x6fb5784*/ System.Span<byte> GetSpan(int length);
        /*0x6fb57b4*/ void Advance(int length);
        /*0x6fbd614*/ byte[] FlushAndGetArray();
        /*0x6fbd77c*/ ref byte WriteString_PrepareSpan(int characterLength, ref int bufferSize, ref int encodedBytesOffset);
        /*0x6fbd8a0*/ void WriteString_PostEncoding(byte* pBuffer, int estimatedOffset, int byteCount);
    }

    struct MonoProtection
    {
        static /*0x0*/ object RefEmitLock;

        static /*0x6fbdcbc*/ MonoProtection();
        static /*0x6fbdb6c*/ bool get_IsRunningOnMono();
        static /*0x6fbdc00*/ MessagePack.MonoProtectionDisposal EnterRefEmitLock();
    }

    struct MonoProtectionDisposal : System.IDisposable
    {
        /*0x10*/ object lockObject;

        /*0x6fbdc9c*/ MonoProtectionDisposal(object lockObject);
        /*0x6fbdd38*/ void Dispose();
    }

    struct Nil : System.IEquatable<MessagePack.Nil>
    {
        static /*0x0*/ MessagePack.Nil Default;

        /*0x6fbdd4c*/ bool Equals(object obj);
        /*0x6fbdda8*/ bool Equals(MessagePack.Nil other);
        /*0x6fbddb0*/ int GetHashCode();
        /*0x6fbddb8*/ string ToString();
    }

    class SkipClrVisibilityChecks
    {
        static /*0x0*/ System.Reflection.ConstructorInfo AttributeBaseClassCtor;
        static /*0x8*/ System.Reflection.ConstructorInfo AttributeUsageCtor;
        static /*0x10*/ System.Reflection.PropertyInfo AttributeUsageAllowMultipleProperty;
        static /*0x18*/ System.Collections.Immutable.ImmutableHashSet<System.Reflection.AssemblyName> EmptySet;
        /*0x10*/ System.Reflection.Emit.AssemblyBuilder assemblyBuilder;
        /*0x18*/ System.Reflection.Emit.ModuleBuilder moduleBuilder;
        /*0x20*/ System.Collections.Generic.HashSet<string> attributedAssemblyNames;
        /*0x28*/ System.Reflection.ConstructorInfo magicAttributeCtor;

        static /*0x6fbef08*/ SkipClrVisibilityChecks();
        static /*0x6fbdf14*/ void GetSkipVisibilityChecksRequirements(System.Reflection.TypeInfo typeInfo, System.Collections.Immutable.ImmutableHashSet.Builder<System.Reflection.AssemblyName> referencedAssemblies);
        static /*0x6fbe470*/ void <GetSkipVisibilityChecksRequirements>g__AddTypeIfNonPublic|9_0(System.Type type, ref MessagePack.SkipClrVisibilityChecks.<> );
        /*0x6fbddf8*/ SkipClrVisibilityChecks(System.Reflection.Emit.AssemblyBuilder assemblyBuilder, System.Reflection.Emit.ModuleBuilder moduleBuilder);
        /*0x6fbe5c4*/ void SkipVisibilityChecksFor(System.Collections.Generic.IEnumerable<System.Reflection.AssemblyName> assemblyNames);
        /*0x6fbe898*/ void SkipVisibilityChecksFor(System.Reflection.AssemblyName assemblyName);
        /*0x6fbe9d0*/ System.Reflection.ConstructorInfo GetMagicAttributeCtor();
        /*0x6fbeb18*/ System.Reflection.TypeInfo EmitMagicAttribute();

        class AssemblyNameEqualityComparer : System.Collections.Generic.IEqualityComparer<System.Reflection.AssemblyName>
        {
            static /*0x0*/ MessagePack.SkipClrVisibilityChecks.AssemblyNameEqualityComparer Instance;

            static /*0x6fbf298*/ AssemblyNameEqualityComparer();
            /*0x6fbf1fc*/ AssemblyNameEqualityComparer();
            /*0x6fbf204*/ bool Equals(System.Reflection.AssemblyName x, System.Reflection.AssemblyName y);
            /*0x6fbf264*/ int GetHashCode(System.Reflection.AssemblyName obj);
        }

        class <>c
        {
            static /*0x0*/ MessagePack.SkipClrVisibilityChecks.<> <>9;

            static /*0x6fbf300*/ <>c();
            /*0x6fbf368*/ <>c();
            /*0x6fbf370*/ bool <.cctor>b__15_0(System.Reflection.ConstructorInfo ctor);
        }

        struct <>c__DisplayClass9_0
        {
            /*0x10*/ System.Collections.Immutable.ImmutableHashSet.Builder<System.Reflection.AssemblyName> referencedAssemblies;
        }
    }

    class SafeBitConverter
    {
        static /*0x6fbf3ac*/ long ToInt64(System.ReadOnlySpan<byte> value);
        static /*0x6fbf418*/ ulong ToUInt64(System.ReadOnlySpan<byte> value);
        static /*0x6fbf41c*/ ushort ToUInt16(System.ReadOnlySpan<byte> value);
        static /*0x6fbf488*/ uint ToUInt32(System.ReadOnlySpan<byte> value);
    }

    class SequencePool
    {
        static /*0x0*/ MessagePack.SequencePool Shared;
        /*0x10*/ int maxSize;
        /*0x18*/ System.Collections.Generic.Stack<Nerdbank.Streams.Sequence<byte>> pool;
        /*0x20*/ object arrayPoolOrMemoryPool;

        static /*0x6fbf7e8*/ SequencePool();
        /*0x6fbf4f4*/ SequencePool();
        /*0x6fbf5b0*/ SequencePool(int maxSize, System.Buffers.ArrayPool<byte> arrayPool);
        /*0x6fa5084*/ MessagePack.SequencePool.Rental Rent();
        /*0x6fbf68c*/ void Return(Nerdbank.Streams.Sequence<byte> value);

        struct Rental : System.IDisposable
        {
            /*0x10*/ MessagePack.SequencePool owner;
            /*0x18*/ Nerdbank.Streams.Sequence<byte> <Value>k__BackingField;

            /*0x6fbf65c*/ Rental(MessagePack.SequencePool owner, Nerdbank.Streams.Sequence<byte> value);
            /*0x6fbf84c*/ Nerdbank.Streams.Sequence<byte> get_Value();
            /*0x6fba928*/ void Dispose();
        }
    }

    struct SequenceReader<T>
    {
        /*0x0*/ bool usingSequence;
        /*0x0*/ System.Buffers.ReadOnlySequence<T> sequence;
        /*0x0*/ System.SequencePosition currentPosition;
        /*0x0*/ System.SequencePosition nextPosition;
        /*0x0*/ System.ReadOnlyMemory<T> memory;
        /*0x0*/ bool moreData;
        /*0x0*/ long length;
        /*0x0*/ System.ReadOnlySpan<T> <CurrentSpan>k__BackingField;
        /*0x0*/ int <CurrentSpanIndex>k__BackingField;
        /*0x0*/ long <Consumed>k__BackingField;

        /*0x3816710*/ SequenceReader(ref System.Buffers.ReadOnlySequence<T> sequence);
        /*0x3910ae8*/ SequenceReader(System.ReadOnlyMemory<T> memory);
        /*0x3813ffc*/ bool get_End();
        /*0x3910ae8*/ System.Buffers.ReadOnlySequence<T> get_Sequence();
        /*0x3910ae8*/ System.SequencePosition get_Position();
        /*0x3910ae8*/ System.ReadOnlySpan<T> get_CurrentSpan();
        /*0x3910ae8*/ void set_CurrentSpan(System.ReadOnlySpan<T> value);
        /*0x3814574*/ int get_CurrentSpanIndex();
        /*0x3815ed0*/ void set_CurrentSpanIndex(int value);
        /*0x3910ae8*/ System.ReadOnlySpan<T> get_UnreadSpan();
        /*0x38146fc*/ long get_Consumed();
        /*0x381630c*/ void set_Consumed(long value);
        /*0x38146fc*/ long get_Remaining();
        /*0x38146fc*/ long get_Length();
        /*0x38141c4*/ bool TryPeek(ref T value);
        /*0x38141c4*/ bool TryRead(ref T value);
        /*0x381630c*/ void Rewind(long count);
        /*0x381630c*/ void RetreatToPreviousSpan(long consumed);
        /*0x38159dc*/ void ResetReader();
        /*0x38159dc*/ void GetNextSpan();
        /*0x381630c*/ void Advance(long count);
        bool TryAdvance(long count);
        /*0x381630c*/ void AdvanceToNextSpan(long count);
        /*0x3910ae8*/ bool TryCopyTo(System.Span<T> destination);
        /*0x3910ae8*/ bool TryCopyMultisegment(System.Span<T> destination);
    }

    class SipHash
    {
        /*0x10*/ ulong initialState0;
        /*0x18*/ ulong initialState1;

        /*0x6fb2a78*/ SipHash();
        /*0x6fb221c*/ long Compute(System.ReadOnlySpan<byte> data);
    }

    class StringEncoding
    {
        static /*0x0*/ System.Text.Encoding UTF8;

        static /*0x6fc0afc*/ StringEncoding();
    }

    class Utilities
    {
        static /*0x6fc0b7c*/ System.Memory<byte> GetMemoryCheckResult(System.Buffers.IBufferWriter<byte> bufferWriter, int size);
        static /*0x6fc0cec*/ MessagePack.Utilities.NonGenericDictionaryEnumerable GetEntryEnumerator(System.Collections.IDictionary dictionary);

        struct NonGenericDictionaryEnumerable
        {
            /*0x10*/ System.Collections.IDictionary dictionary;

            /*0x6fc0d0c*/ NonGenericDictionaryEnumerable(System.Collections.IDictionary dictionary);
            /*0x6fc0d14*/ MessagePack.Utilities.NonGenericDictionaryEnumerator GetEnumerator();
        }

        struct NonGenericDictionaryEnumerator : System.Collections.Generic.IEnumerator<System.Collections.DictionaryEntry>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ System.Collections.IDictionaryEnumerator enumerator;

            /*0x6fc0d34*/ NonGenericDictionaryEnumerator(System.Collections.IDictionary dictionary);
            /*0x6fc0de8*/ System.Collections.DictionaryEntry get_Current();
            /*0x6fc0e8c*/ object System.Collections.IEnumerator.get_Current();
            /*0x6fc0f64*/ void Dispose();
            /*0x6fc0f68*/ bool MoveNext();
            /*0x6fc1008*/ void Reset();
        }
    }

    namespace Resolvers
    {
        class AttributeFormatterResolver : MessagePack.IFormatterResolver
        {
            static /*0x0*/ MessagePack.Resolvers.AttributeFormatterResolver Instance;

            static /*0x6fc10b4*/ AttributeFormatterResolver();
            /*0x6fc10ac*/ AttributeFormatterResolver();
            /*0x38148bc*/ MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static /*0x383e7a0*/ FormatterCache();
            }
        }

        class BuiltinResolver : MessagePack.IFormatterResolver
        {
            static /*0x0*/ MessagePack.Resolvers.BuiltinResolver Instance;

            static /*0x6fc1124*/ BuiltinResolver();
            /*0x6fc111c*/ BuiltinResolver();
            /*0x38148bc*/ MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static /*0x383e7a0*/ FormatterCache();
            }
        }

        class CompositeResolver
        {
            static /*0x0*/ System.Collections.ObjectModel.ReadOnlyDictionary<System.Type, MessagePack.Formatters.IMessagePackFormatter> EmptyFormattersByType;

            static /*0x6fc14b4*/ CompositeResolver();
            static /*0x6fc118c*/ MessagePack.IFormatterResolver Create(System.Collections.Generic.IReadOnlyList<MessagePack.Formatters.IMessagePackFormatter> formatters, System.Collections.Generic.IReadOnlyList<MessagePack.IFormatterResolver> resolvers);
            static /*0x6fc13f4*/ MessagePack.IFormatterResolver Create(MessagePack.Formatters.IMessagePackFormatter[] formatters);

            class CachingResolver : MessagePack.IFormatterResolver
            {
                /*0x10*/ MessagePack.Internal.ThreadsafeTypeKeyHashTable<MessagePack.Formatters.IMessagePackFormatter> formattersCache;
                /*0x18*/ MessagePack.Formatters.IMessagePackFormatter[] subFormatters;
                /*0x20*/ MessagePack.IFormatterResolver[] subResolvers;

                /*0x6fc12b0*/ CachingResolver(MessagePack.Formatters.IMessagePackFormatter[] subFormatters, MessagePack.IFormatterResolver[] subResolvers);
                /*0x38148bc*/ MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();
            }
        }

        class DynamicGenericResolver : MessagePack.IFormatterResolver
        {
            static /*0x0*/ MessagePack.Resolvers.DynamicGenericResolver Instance;

            static /*0x6fc159c*/ DynamicGenericResolver();
            /*0x6fc1594*/ DynamicGenericResolver();
            /*0x38148bc*/ MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static /*0x383e7a0*/ FormatterCache();
            }
        }

        class DynamicObjectResolver : MessagePack.IFormatterResolver
        {
            static /*0x0*/ MessagePack.Resolvers.DynamicObjectResolver Instance;
            static /*0x8*/ MessagePack.MessagePackSerializerOptions Options;
            static /*0x10*/ MessagePack.Internal.DynamicAssemblyFactory DynamicAssemblyFactory;

            static /*0x6fc1604*/ DynamicObjectResolver();
            static /*0x3910ae8*/ MessagePack.Formatters.IMessagePackFormatter<T> BuildFormatterHelper<T>(MessagePack.IFormatterResolver self, MessagePack.Internal.DynamicAssemblyFactory dynamicAssemblyFactory, bool forceStringKey, bool contractless, bool allowPrivate);
            /*0x6fc1710*/ DynamicObjectResolver();
            /*0x38148bc*/ MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static /*0x383e7a0*/ FormatterCache();
            }

            class <>c__7<T>
            {
                static /*0x0*/ MessagePack.Resolvers.DynamicObjectResolver.<>c__7<T> <>9;
                static /*0x0*/ System.Func<MessagePack.MessagePackObjectAttribute, bool> <>9__7_0;

                static /*0x383e7a0*/ <>c__7();
                /*0x38159dc*/ <>c__7();
                /*0x38141c4*/ bool <BuildFormatterHelper>b__7_0(MessagePack.MessagePackObjectAttribute a);
            }
        }

        class DynamicUnionResolver : MessagePack.IFormatterResolver
        {
            static /*0x0*/ MessagePack.Resolvers.DynamicUnionResolver Instance;
            static /*0x8*/ MessagePack.MessagePackSerializerOptions Options;
            static /*0x10*/ MessagePack.Internal.DynamicAssemblyFactory DynamicAssemblyFactory;
            static /*0x18*/ int nameSequence;
            static /*0x20*/ System.Type refMessagePackReader;
            static /*0x28*/ System.Type refKvp;
            static /*0x30*/ System.Reflection.MethodInfo getFormatterWithVerify;
            static /*0x38*/ System.Reflection.MethodInfo getResolverFromOptions;
            static /*0x40*/ System.Func<System.Type, System.Reflection.MethodInfo> getSerialize;
            static /*0x48*/ System.Func<System.Type, System.Reflection.MethodInfo> getDeserialize;
            static /*0x50*/ System.Reflection.FieldInfo runtimeTypeHandleEqualityComparer;
            static /*0x58*/ System.Reflection.ConstructorInfo intIntKeyValuePairConstructor;
            static /*0x60*/ System.Reflection.ConstructorInfo typeMapDictionaryConstructor;
            static /*0x68*/ System.Reflection.MethodInfo typeMapDictionaryAdd;
            static /*0x70*/ System.Reflection.MethodInfo typeMapDictionaryTryGetValue;
            static /*0x78*/ System.Reflection.ConstructorInfo keyMapDictionaryConstructor;
            static /*0x80*/ System.Reflection.MethodInfo keyMapDictionaryAdd;
            static /*0x88*/ System.Reflection.MethodInfo keyMapDictionaryTryGetValue;
            static /*0x90*/ System.Reflection.MethodInfo objectGetType;
            static /*0x98*/ System.Reflection.MethodInfo getTypeHandle;
            static /*0xa0*/ System.Reflection.MethodInfo intIntKeyValuePairGetKey;
            static /*0xa8*/ System.Reflection.MethodInfo intIntKeyValuePairGetValue;
            static /*0xb0*/ System.Reflection.ConstructorInfo invalidOperationExceptionConstructor;
            static /*0xb8*/ System.Reflection.ConstructorInfo objectCtor;

            static /*0x6fc1804*/ DynamicUnionResolver();
            static /*0x6fc24ec*/ System.Reflection.TypeInfo BuildType(System.Type type);
            static /*0x6fc34c8*/ void BuildConstructor(System.Type type, MessagePack.UnionAttribute[] infos, System.Reflection.ConstructorInfo method, System.Reflection.Emit.FieldBuilder typeToKeyAndJumpMap, System.Reflection.Emit.FieldBuilder keyToJumpMap, System.Reflection.Emit.ILGenerator il);
            static /*0x6fc3880*/ void BuildSerialize(System.Type type, MessagePack.UnionAttribute[] infos, System.Reflection.Emit.MethodBuilder method, System.Reflection.Emit.FieldBuilder typeToKeyAndJumpMap, System.Reflection.Emit.ILGenerator il);
            static /*0x6fc41c4*/ void BuildDeserialize(System.Type type, MessagePack.UnionAttribute[] infos, System.Reflection.Emit.MethodBuilder method, System.Reflection.Emit.FieldBuilder keyToJumpMap, System.Reflection.Emit.ILGenerator il);
            static /*0x6fc5350*/ bool IsZeroStartSequential(MessagePack.UnionAttribute[] infos);
            /*0x6fc24e4*/ DynamicUnionResolver();
            /*0x38148bc*/ MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static /*0x383e7a0*/ FormatterCache();
            }

            class MessagePackReaderTypeInfo
            {
                static /*0x0*/ System.Reflection.TypeInfo ReaderTypeInfo;
                static /*0x8*/ System.Reflection.MethodInfo ReadBytes;
                static /*0x10*/ System.Reflection.MethodInfo ReadInt32;
                static /*0x18*/ System.Reflection.MethodInfo ReadString;
                static /*0x20*/ System.Reflection.MethodInfo TryReadNil;
                static /*0x28*/ System.Reflection.MethodInfo Skip;
                static /*0x30*/ System.Reflection.MethodInfo ReadArrayHeader;
                static /*0x38*/ System.Reflection.MethodInfo ReadMapHeader;

                static /*0x6fc53e0*/ MessagePackReaderTypeInfo();
            }

            class MessagePackWriterTypeInfo
            {
                static /*0x0*/ System.Reflection.TypeInfo WriterTypeInfo;
                static /*0x8*/ System.Reflection.MethodInfo WriteArrayHeader;
                static /*0x10*/ System.Reflection.MethodInfo WriteInt32;
                static /*0x18*/ System.Reflection.MethodInfo WriteNil;

                static /*0x6fc56c8*/ MessagePackWriterTypeInfo();
            }

            class <>c
            {
                static /*0x0*/ MessagePack.Resolvers.DynamicUnionResolver.<> <>9;
                static /*0x8*/ System.Func<MessagePack.UnionAttribute, int> <>9__9_0;
                static /*0x10*/ System.Func<<>f__AnonymousType0<System.Reflection.Emit.Label, MessagePack.UnionAttribute>, System.Reflection.Emit.Label> <>9__11_1;
                static /*0x18*/ System.Func<<>f__AnonymousType0<System.Reflection.Emit.Label, MessagePack.UnionAttribute>, System.Reflection.Emit.Label> <>9__12_1;

                static /*0x6fc5948*/ <>c();
                /*0x6fc59b0*/ <>c();
                /*0x6fc59b8*/ bool <.cctor>b__5_0(System.Reflection.MethodInfo x);
                /*0x6fc5a18*/ System.Reflection.MethodInfo <.cctor>b__5_1(System.Type t);
                /*0x6fc5c50*/ System.Reflection.MethodInfo <.cctor>b__5_2(System.Type t);
                /*0x6fc5e54*/ bool <.cctor>b__5_3(System.Reflection.ConstructorInfo x);
                /*0x6fc5e90*/ bool <.cctor>b__5_4(System.Reflection.ConstructorInfo x);
                /*0x6fc5f34*/ bool <.cctor>b__5_5(System.Reflection.ConstructorInfo x);
                /*0x6fc5fd8*/ bool <.cctor>b__5_6(System.Reflection.ConstructorInfo x);
                /*0x6fc607c*/ bool <.cctor>b__5_7(System.Reflection.ConstructorInfo x);
                /*0x6fc60b8*/ int <BuildType>b__9_0(MessagePack.UnionAttribute x);
                /*0x6fc60d0*/ System.Reflection.Emit.Label <BuildSerialize>b__11_1(<>f__AnonymousType0<System.Reflection.Emit.Label, MessagePack.UnionAttribute> x);
                /*0x6fc6114*/ System.Reflection.Emit.Label <BuildDeserialize>b__12_1(<>f__AnonymousType0<System.Reflection.Emit.Label, MessagePack.UnionAttribute> x);
            }

            class <>c__DisplayClass11_0
            {
                /*0x10*/ System.Reflection.Emit.ILGenerator il;

                /*0x6fc51d8*/ <>c__DisplayClass11_0();
                /*0x6fc6158*/ <>f__AnonymousType0<System.Reflection.Emit.Label, MessagePack.UnionAttribute> <BuildSerialize>b__0(MessagePack.UnionAttribute x);
            }

            class <>c__DisplayClass12_0
            {
                /*0x10*/ System.Reflection.Emit.ILGenerator il;

                /*0x6fc5308*/ <>c__DisplayClass12_0();
                /*0x6fc61f0*/ <>f__AnonymousType0<System.Reflection.Emit.Label, MessagePack.UnionAttribute> <BuildDeserialize>b__0(MessagePack.UnionAttribute x);
            }
        }

        class MessagePackDynamicUnionResolverException : MessagePack.MessagePackSerializationException
        {
            /*0x6fc31b0*/ MessagePackDynamicUnionResolverException(string message);
        }

        class PrimitiveObjectResolver : MessagePack.IFormatterResolver
        {
            static /*0x0*/ MessagePack.Resolvers.PrimitiveObjectResolver Instance;
            static /*0x8*/ MessagePack.MessagePackSerializerOptions Options;

            static /*0x6fc6288*/ PrimitiveObjectResolver();
            /*0x6fc633c*/ PrimitiveObjectResolver();
            /*0x38148bc*/ MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static /*0x383e7a0*/ FormatterCache();
            }
        }

        class SourceGeneratedFormatterResolver : MessagePack.IFormatterResolver
        {
            static /*0x0*/ MessagePack.Resolvers.SourceGeneratedFormatterResolver Instance;
            static /*0x8*/ System.Collections.Concurrent.ConcurrentDictionary<System.Reflection.Assembly, MessagePack.IFormatterResolver> AssemblyResolverCache;

            static /*0x6fc634c*/ SourceGeneratedFormatterResolver();
            /*0x6fc6344*/ SourceGeneratedFormatterResolver();
            /*0x38148bc*/ MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static /*0x383e7a0*/ FormatterCache();
                static /*0x3836db8*/ MessagePack.Formatters.IMessagePackFormatter<T> FindPrecompiledFormatter();

                class <>c<T>
                {
                    static /*0x0*/ MessagePack.Resolvers.SourceGeneratedFormatterResolver.FormatterCache.<>c<T> <>9;
                    static /*0x0*/ System.Func<System.Reflection.Assembly, MessagePack.IFormatterResolver> <>9__1_0;

                    static /*0x383e7a0*/ <>c();
                    /*0x38159dc*/ <>c();
                    /*0x3814a3c*/ MessagePack.IFormatterResolver <FindPrecompiledFormatter>b__1_0(System.Reflection.Assembly assembly);
                }
            }
        }

        class StandardResolver : MessagePack.IFormatterResolver
        {
            static /*0x0*/ MessagePack.Resolvers.StandardResolver Instance;
            static /*0x8*/ MessagePack.MessagePackSerializerOptions Options;
            static /*0x10*/ MessagePack.IFormatterResolver[] Resolvers;

            static /*0x6fc640c*/ StandardResolver();
            /*0x6fc6730*/ StandardResolver();
            /*0x38148bc*/ MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static /*0x383e7a0*/ FormatterCache();
            }
        }
    }

    namespace LZ4
    {
        class LZ4Codec
        {
            static /*0x0*/ int[] DECODER_TABLE_32;
            static /*0x8*/ int[] DECODER_TABLE_64;
            static /*0x10*/ int[] DEBRUIJN_TABLE_32;
            static /*0x18*/ int[] DEBRUIJN_TABLE_64;

            static /*0x6fc86ac*/ LZ4Codec();
            static /*0x6fc6738*/ int MaximumOutputLength(int inputLength);
            static /*0x6fc67bc*/ int Encode(System.ReadOnlySpan<byte> input, System.Span<byte> output);
            static /*0x6fc7fd4*/ int Decode(System.ReadOnlySpan<byte> input, System.Span<byte> output);
            static /*0x6fc7554*/ int LZ4_compressCtx_32(uint* hash_table, byte* src, byte* dst, int src_len, int dst_maxlen);
            static /*0x6fc6a8c*/ int LZ4_compress64kCtx_32(ushort* hash_table, byte* src, byte* dst, int src_len, int dst_maxlen);
            static /*0x6fc814c*/ int LZ4_uncompress_32(byte* src, byte* dst, int dst_len);
            static /*0x6fc8588*/ void BlockCopy32(byte* src, byte* dst, int len);
            static /*0x6fc7a8c*/ int LZ4_compressCtx_64(uint* hash_table, byte* src, byte* dst, int src_len, int dst_maxlen);
            static /*0x6fc6f7c*/ int LZ4_compress64kCtx_64(ushort* hash_table, byte* src, byte* dst, int src_len, int dst_maxlen);
            static /*0x6fc8364*/ int LZ4_uncompress_64(byte* src, byte* dst, int dst_len);
            static /*0x6fc8610*/ void BlockCopy64(byte* src, byte* dst, int len);

            class HashTablePool
            {
                [ThreadStatic] static ushort[] ushortPool;
                [ThreadStatic] static uint[] uintPool;

                static /*0x6fc69b8*/ ushort[] GetUShortHashTablePool();
                static /*0x6fc747c*/ uint[] GetUIntHashTablePool();
            }
        }
    }

    namespace Internal
    {
        class AutomataDictionary : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, int>>, System.Collections.IEnumerable
        {
            /*0x10*/ MessagePack.Internal.AutomataDictionary.AutomataNode root;

            static /*0x6fc92cc*/ void ToStringCore(System.Collections.Generic.IEnumerable<MessagePack.Internal.AutomataDictionary.AutomataNode> nexts, System.Text.StringBuilder sb, int depth);
            static /*0x6fc9808*/ System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, int>> YieldCore(System.Collections.Generic.IEnumerable<MessagePack.Internal.AutomataDictionary.AutomataNode> nexts);
            /*0x6fc8820*/ AutomataDictionary();
            /*0x6fc89cc*/ void Add(string str, int value);
            /*0x6fc91d0*/ string ToString();
            /*0x6fc9754*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x6fc9758*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, int>> GetEnumerator();
            /*0x6fc98b8*/ void EmitMatch(System.Reflection.Emit.ILGenerator il, System.Reflection.Emit.LocalBuilder bytesSpan, System.Reflection.Emit.LocalBuilder key, System.Action<System.Collections.Generic.KeyValuePair<string, int>> onFound, System.Action onNotFound);

            class AutomataNode : System.IComparable<MessagePack.Internal.AutomataDictionary.AutomataNode>
            {
                /*0x10*/ ulong Key;
                /*0x18*/ int Value;
                /*0x20*/ string OriginalKey;
                /*0x28*/ MessagePack.Internal.AutomataDictionary.AutomataNode[] nexts;
                /*0x30*/ ulong[] nextKeys;
                /*0x38*/ int count;

                static /*0x6fc9a8c*/ void EmitSearchNextCore(System.Reflection.Emit.ILGenerator il, System.Reflection.Emit.LocalBuilder bytesSpan, System.Reflection.Emit.LocalBuilder key, System.Action<System.Collections.Generic.KeyValuePair<string, int>> onFound, System.Action onNotFound, MessagePack.Internal.AutomataDictionary.AutomataNode[] nexts, int count);
                /*0x6fc888c*/ AutomataNode(ulong key);
                /*0x6fc9994*/ bool get_HasChildren();
                /*0x6fc8f70*/ MessagePack.Internal.AutomataDictionary.AutomataNode Add(ulong key);
                /*0x6fc8f30*/ MessagePack.Internal.AutomataDictionary.AutomataNode Add(ulong key, int value, string originalKey);
                /*0x6fc99a4*/ int CompareTo(MessagePack.Internal.AutomataDictionary.AutomataNode other);
                /*0x6fc9250*/ System.Collections.Generic.IEnumerable<MessagePack.Internal.AutomataDictionary.AutomataNode> YieldChildren();
                /*0x6fc98d0*/ void EmitSearchNext(System.Reflection.Emit.ILGenerator il, System.Reflection.Emit.LocalBuilder bytesSpan, System.Reflection.Emit.LocalBuilder key, System.Action<System.Collections.Generic.KeyValuePair<string, int>> onFound, System.Action onNotFound);

                class <>c
                {
                    static /*0x0*/ MessagePack.Internal.AutomataDictionary.AutomataNode.<> <>9;
                    static /*0x8*/ System.Func<MessagePack.Internal.AutomataDictionary.AutomataNode, bool> <>9__16_0;
                    static /*0x10*/ System.Func<MessagePack.Internal.AutomataDictionary.AutomataNode, bool> <>9__16_1;

                    static /*0x6fca634*/ <>c();
                    /*0x6fca69c*/ <>c();
                    /*0x6fca6a4*/ bool <EmitSearchNextCore>b__16_0(MessagePack.Internal.AutomataDictionary.AutomataNode x);
                    /*0x6fca6c4*/ bool <EmitSearchNextCore>b__16_1(MessagePack.Internal.AutomataDictionary.AutomataNode x);
                }

                class <>c__DisplayClass16_0
                {
                    /*0x10*/ System.Reflection.Emit.ILGenerator il;

                    /*0x6fca5ac*/ <>c__DisplayClass16_0();
                    /*0x6fca6e4*/ System.Reflection.Emit.Label <EmitSearchNextCore>b__3(int _);
                    /*0x6fca70c*/ System.Reflection.Emit.Label <EmitSearchNextCore>b__2(int _);
                }

                class <YieldChildren>d__14 : System.Collections.Generic.IEnumerable<MessagePack.Internal.AutomataDictionary.AutomataNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<MessagePack.Internal.AutomataDictionary.AutomataNode>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ MessagePack.Internal.AutomataDictionary.AutomataNode <>2__current;
                    /*0x20*/ int <>l__initialThreadId;
                    /*0x28*/ MessagePack.Internal.AutomataDictionary.AutomataNode <>4__this;
                    /*0x30*/ int <i>5__2;

                    /*0x6fc9a58*/ <YieldChildren>d__14(int <>1__state);
                    /*0x6fca734*/ void System.IDisposable.Dispose();
                    /*0x6fca738*/ bool MoveNext();
                    /*0x6fca818*/ MessagePack.Internal.AutomataDictionary.AutomataNode System.Collections.Generic.IEnumerator<MessagePack.Internal.AutomataDictionary.AutomataNode>.get_Current();
                    /*0x6fca820*/ void System.Collections.IEnumerator.Reset();
                    /*0x6fca858*/ object System.Collections.IEnumerator.get_Current();
                    /*0x6fca860*/ System.Collections.Generic.IEnumerator<MessagePack.Internal.AutomataDictionary.AutomataNode> System.Collections.Generic.IEnumerable<MessagePack.Internal.AutomataDictionary.AutomataNode>.GetEnumerator();
                    /*0x6fca904*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            class <YieldCore>d__9 : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, int>>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, int>>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Collections.Generic.KeyValuePair<string, int> <>2__current;
                /*0x28*/ int <>l__initialThreadId;
                /*0x30*/ System.Collections.Generic.IEnumerable<MessagePack.Internal.AutomataDictionary.AutomataNode> nexts;
                /*0x38*/ System.Collections.Generic.IEnumerable<MessagePack.Internal.AutomataDictionary.AutomataNode> <>3__nexts;
                /*0x40*/ System.Collections.Generic.IEnumerator<MessagePack.Internal.AutomataDictionary.AutomataNode> <>7__wrap1;
                /*0x48*/ MessagePack.Internal.AutomataDictionary.AutomataNode <item>5__3;
                /*0x50*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, int>> <>7__wrap3;

                /*0x6fc9884*/ <YieldCore>d__9(int <>1__state);
                /*0x6fca908*/ void System.IDisposable.Dispose();
                /*0x6fca9bc*/ bool MoveNext();
                /*0x6fcaf7c*/ void <>m__Finally1();
                /*0x6fcaecc*/ void <>m__Finally2();
                /*0x6fcb02c*/ System.Collections.Generic.KeyValuePair<string, int> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Int32>>.get_Current();
                /*0x6fcb038*/ void System.Collections.IEnumerator.Reset();
                /*0x6fcb070*/ object System.Collections.IEnumerator.get_Current();
                /*0x6fcb0cc*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, int>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Int32>>.GetEnumerator();
                /*0x6fcb170*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class AutomataKeyGen
        {
            static /*0x0*/ System.Reflection.MethodInfo GetKeyMethod;

            static /*0x6fcb174*/ AutomataKeyGen();
            static /*0x6fc8ad8*/ ulong GetKey(ref System.ReadOnlySpan<byte> span);
        }

        class CodeGenHelpers
        {
            static /*0x6fcb330*/ byte[] GetEncodedStringBytes(string value);
            static /*0x6fcb610*/ System.ReadOnlySpan<byte> ReadStringSpan(ref MessagePack.MessagePackReader reader);
            static /*0x6fcb7f8*/ byte[] GetArrayFromNullableSequence(ref System.Nullable<System.Buffers.ReadOnlySequence<byte>> sequence);
        }

        class DateTimeConstants
        {
            static /*0x0*/ System.DateTime UnixEpoch;

            static /*0x6fcb88c*/ DateTimeConstants();
        }

        class DynamicAssembly
        {
            static /*0x0*/ bool AvoidDynamicCode;
            /*0x10*/ System.Reflection.Emit.AssemblyBuilder assemblyBuilder;
            /*0x18*/ System.Reflection.Emit.ModuleBuilder moduleBuilder;

            static /*0x6fcba3c*/ DynamicAssembly();
            /*0x6fcb908*/ DynamicAssembly(string moduleName, System.Collections.Immutable.ImmutableHashSet<System.Reflection.AssemblyName> skipVisibilityChecksTo);
            /*0x6fc34ac*/ System.Reflection.Emit.TypeBuilder DefineType(string name, System.Reflection.TypeAttributes attr, System.Type parent, System.Type[] interfaces);
        }

        class DynamicAssemblyFactory
        {
            /*0x10*/ string moduleName;
            /*0x18*/ MessagePack.Internal.DynamicAssembly singletonAssembly;
            /*0x20*/ System.Collections.Immutable.ImmutableHashSet<System.Reflection.AssemblyName> lastCreatedDynamicAssemblySkipVisibilityChecks;

            /*0x6fc1718*/ DynamicAssemblyFactory(string moduleName);
            /*0x6fc31b8*/ MessagePack.Internal.DynamicAssembly GetDynamicAssembly(System.Type type, bool allowPrivate);
            /*0x6fcba94*/ MessagePack.Internal.DynamicAssembly <GetDynamicAssembly>g__NewAssembly|4_0();
        }

        class ExpressionUtility
        {
            static /*0x6fcbaf8*/ System.Reflection.MethodInfo GetMethodInfoCore(System.Linq.Expressions.LambdaExpression expression);
            static /*0x38379c4*/ System.Reflection.MethodInfo GetMethodInfo<T>(System.Linq.Expressions.Expression<System.Func<T>> expression);
            static /*0x38379c4*/ System.Reflection.MethodInfo GetMethodInfo<T, TR>(System.Linq.Expressions.Expression<System.Func<T, TR>> expression);
            static /*0x38379c4*/ System.Reflection.MemberInfo GetMemberInfoCore<T>(System.Linq.Expressions.Expression<T> source);
            static /*0x38379c4*/ System.Reflection.PropertyInfo GetPropertyInfo<T, TR>(System.Linq.Expressions.Expression<System.Func<T, TR>> expression);
        }

        class GeneratedAssemblyMessagePackResolverAttribute : System.Attribute
        {
            /*0x10*/ System.Type <ResolverType>k__BackingField;
            /*0x18*/ int <MajorVersion>k__BackingField;
            /*0x1c*/ int <MinorVersion>k__BackingField;

            /*0x6fcbbc4*/ GeneratedAssemblyMessagePackResolverAttribute(System.Type resolverType, int majorVersion, int minorVersion);
            /*0x6fcbc0c*/ System.Type get_ResolverType();
        }

        struct GuidBits
        {
            /*0x10*/ System.Guid Value;
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

            static /*0x6fcbc14*/ System.ReadOnlySpan<byte> GetByteToHexStringHigh();
            static /*0x6fcbc64*/ System.ReadOnlySpan<byte> GetByteToHexStringLow();
            static /*0x6fcc048*/ byte Parse(System.ReadOnlySpan<byte> bytes, int highOffset);
            static /*0x6fcc168*/ byte SwitchParse(byte b);
            /*0x6fcbcb4*/ GuidBits(ref System.Guid value);
            /*0x6fcbcc4*/ GuidBits(System.ReadOnlySpan<byte> utf8string);
            /*0x6fcc210*/ void Write(System.Span<byte> buffer);
        }

        struct ArgumentField
        {
            /*0x10*/ int i;
            /*0x14*/ bool ref;
            /*0x18*/ System.Reflection.Emit.ILGenerator il;

            /*0x6fc5310*/ ArgumentField(System.Reflection.Emit.ILGenerator il, int i, bool ref);
            /*0x6fcc5bc*/ ArgumentField(System.Reflection.Emit.ILGenerator il, int i, System.Type type);
            /*0x6fcc64c*/ void EmitLoad();
            /*0x6fc5340*/ void EmitLdarg();
        }

        class ILGeneratorExtensions
        {
            static /*0x6fcc710*/ void EmitLdloc(System.Reflection.Emit.ILGenerator il, int index);
            static /*0x6fc52d4*/ void EmitLdloc(System.Reflection.Emit.ILGenerator il, System.Reflection.Emit.LocalBuilder local);
            static /*0x6fcc8c0*/ void EmitStloc(System.Reflection.Emit.ILGenerator il, int index);
            static /*0x6fc51e0*/ void EmitStloc(System.Reflection.Emit.ILGenerator il, System.Reflection.Emit.LocalBuilder local);
            static /*0x6fcca70*/ void EmitLdloca(System.Reflection.Emit.ILGenerator il, int index);
            static /*0x6fc52a0*/ void EmitLdloca(System.Reflection.Emit.ILGenerator il, System.Reflection.Emit.LocalBuilder local);
            static /*0x6fccb34*/ void EmitTrue(System.Reflection.Emit.ILGenerator il);
            static /*0x6fccb3c*/ void EmitBoolean(System.Reflection.Emit.ILGenerator il, bool value);
            static /*0x6fc4e38*/ void EmitLdc_I4(System.Reflection.Emit.ILGenerator il, int value);
            static /*0x6fccb44*/ void EmitBoxOrDoNothing(System.Reflection.Emit.ILGenerator il, System.Type type);
            static /*0x6fc4ca4*/ void EmitLdarg(System.Reflection.Emit.ILGenerator il, int index);
            static /*0x6fc5214*/ void EmitLoadThis(System.Reflection.Emit.ILGenerator il);
            static /*0x6fcc668*/ void EmitLdarga(System.Reflection.Emit.ILGenerator il, int index);
            static /*0x6fc510c*/ void EmitCall(System.Reflection.Emit.ILGenerator il, System.Reflection.MethodInfo methodInfo);
            static /*0x6fc521c*/ void EmitLdfld(System.Reflection.Emit.ILGenerator il, System.Reflection.FieldInfo fieldInfo);
            static /*0x6fccbe8*/ void EmitLdsfld(System.Reflection.Emit.ILGenerator il, System.Reflection.FieldInfo fieldInfo);
            static /*0x6fca5b4*/ void EmitULong(System.Reflection.Emit.ILGenerator il, ulong value);
            static /*0x6fccc6c*/ void EmitIncrementFor(System.Reflection.Emit.ILGenerator il, System.Reflection.Emit.LocalBuilder conditionGreater, System.Action<System.Reflection.Emit.LocalBuilder> emitBody);
        }

        class PreserveAttribute : System.Attribute
        {
            /*0x6fcce40*/ PreserveAttribute();
        }

        class ReflectionExtensions
        {
            static /*0x6fcce48*/ bool IsNullable(System.Reflection.TypeInfo type);
            static /*0x6fccf08*/ bool IsAnonymous(System.Reflection.TypeInfo type);
            static /*0x6fcd078*/ bool IsIndexer(System.Reflection.PropertyInfo propertyInfo);
            static /*0x6fcd0ac*/ bool IsConstructedGenericType(System.Reflection.TypeInfo type);
        }

        class RuntimeTypeHandleEqualityComparer : System.Collections.Generic.IEqualityComparer<System.RuntimeTypeHandle>
        {
            static /*0x0*/ System.Collections.Generic.IEqualityComparer<System.RuntimeTypeHandle> Default;

            static /*0x6fcd128*/ RuntimeTypeHandleEqualityComparer();
            /*0x6fcd0e0*/ RuntimeTypeHandleEqualityComparer();
            /*0x6fcd0e8*/ bool Equals(System.RuntimeTypeHandle x, System.RuntimeTypeHandle y);
            /*0x6fcd10c*/ int GetHashCode(System.RuntimeTypeHandle obj);
        }

        class ThreadsafeTypeKeyHashTable<TValue>
        {
            /*0x0*/ MessagePack.Internal.ThreadsafeTypeKeyHashTable.Entry<TValue> buckets;
            /*0x0*/ int size;
            /*0x0*/ object writerLock;
            /*0x0*/ float loadFactor;

            static /*0x3910ae8*/ int CalculateCapacity(int collectionSize, float loadFactor);
            static /*0x3843dfc*/ void VolatileWrite(ref MessagePack.Internal.ThreadsafeTypeKeyHashTable.Entry<TValue> location, MessagePack.Internal.ThreadsafeTypeKeyHashTable.Entry<TValue> value);
            static /*0x3843dfc*/ void VolatileWrite(ref MessagePack.Internal.ThreadsafeTypeKeyHashTable.Entry<TValue> location, MessagePack.Internal.ThreadsafeTypeKeyHashTable.Entry<TValue> value);
            /*0x3816124*/ ThreadsafeTypeKeyHashTable(int capacity, float loadFactor);
            /*0x3910ae8*/ bool TryAdd(System.Type key, TValue value);
            /*0x3814200*/ bool TryAdd(System.Type key, System.Func<System.Type, TValue> valueFactory);
            bool TryAddInternal(System.Type key, System.Func<System.Type, TValue> valueFactory, ref TValue resultingValue);
            /*0x3814288*/ bool AddToBuckets(MessagePack.Internal.ThreadsafeTypeKeyHashTable.Entry<TValue> buckets, System.Type newKey, MessagePack.Internal.ThreadsafeTypeKeyHashTable.Entry<TValue> newEntryOrNull, System.Func<System.Type, TValue> valueFactory, ref TValue resultingValue);
            /*0x3814200*/ bool TryGetValue(System.Type key, ref TValue value);

            class Entry<TValue>
            {
                /*0x0*/ MessagePack.Internal.ThreadsafeTypeKeyHashTable.Entry<TValue> Next;
                /*0x0*/ System.Type <Key>k__BackingField;
                /*0x0*/ TValue <Value>k__BackingField;
                /*0x0*/ int <Hash>k__BackingField;

                /*0x3910ae8*/ Entry(System.Type key, TValue value, int hash);
                /*0x38148bc*/ System.Type get_Key();
                /*0x3910ae8*/ TValue get_Value();
                /*0x3814574*/ int get_Hash();
                /*0x38148bc*/ string ToString();
                /*0x3814574*/ int Count();
            }

            class <>c__DisplayClass5_0<TValue>
            {
                /*0x0*/ TValue value;

                /*0x38159dc*/ <>c__DisplayClass5_0();
                /*0x3910ae8*/ TValue <TryAdd>b__0(System.Type _);
            }
        }

        class UnsafeMemory32
        {
            static /*0x6fcd190*/ void WriteRaw4(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcd208*/ void WriteRaw5(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcd294*/ void WriteRaw6(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcd320*/ void WriteRaw7(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcd3ac*/ void WriteRaw8(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcd438*/ void WriteRaw9(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcd4cc*/ void WriteRaw10(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcd560*/ void WriteRaw11(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcd5f4*/ void WriteRaw12(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcd688*/ void WriteRaw13(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcd724*/ void WriteRaw14(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcd7c0*/ void WriteRaw15(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcd85c*/ void WriteRaw16(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcd8f8*/ void WriteRaw17(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcd99c*/ void WriteRaw18(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcda40*/ void WriteRaw19(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcdae4*/ void WriteRaw20(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcdb88*/ void WriteRaw21(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcdc34*/ void WriteRaw22(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcdce0*/ void WriteRaw23(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcdd8c*/ void WriteRaw24(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcde38*/ void WriteRaw25(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcdeec*/ void WriteRaw26(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcdfa0*/ void WriteRaw27(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fce054*/ void WriteRaw28(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fce108*/ void WriteRaw29(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fce1c4*/ void WriteRaw30(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fce280*/ void WriteRaw31(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fce33c*/ void WriteRaw1(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fce3b4*/ void WriteRaw2(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fce42c*/ void WriteRaw3(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
        }

        class UnsafeMemory64
        {
            static /*0x6fce4b8*/ void WriteRaw8(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fce530*/ void WriteRaw9(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fce5bc*/ void WriteRaw10(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fce648*/ void WriteRaw11(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fce6d4*/ void WriteRaw12(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fce760*/ void WriteRaw13(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fce7ec*/ void WriteRaw14(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fce878*/ void WriteRaw15(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fce904*/ void WriteRaw16(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fce990*/ void WriteRaw17(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcea24*/ void WriteRaw18(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fceab8*/ void WriteRaw19(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fceb4c*/ void WriteRaw20(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcebe0*/ void WriteRaw21(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcec74*/ void WriteRaw22(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fced08*/ void WriteRaw23(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fced9c*/ void WriteRaw24(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcee30*/ void WriteRaw25(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fceecc*/ void WriteRaw26(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcef68*/ void WriteRaw27(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcf004*/ void WriteRaw28(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcf0a0*/ void WriteRaw29(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcf13c*/ void WriteRaw30(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcf1d8*/ void WriteRaw31(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcf274*/ void WriteRaw1(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcf2ec*/ void WriteRaw2(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcf364*/ void WriteRaw3(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcf3f0*/ void WriteRaw4(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcf468*/ void WriteRaw5(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcf4f4*/ void WriteRaw6(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fcf580*/ void WriteRaw7(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
        }

        class UnsafeMemory
        {
            static /*0x0*/ bool Is32Bit;

            static /*0x6fcf60c*/ UnsafeMemory();
        }

        class UnsafeRefDeserializeHelper
        {
            static /*0x6fcf664*/ int Deserialize(ref byte input, int length, ref bool output);
        }

        class UnsafeRefSerializeHelper
        {
            static /*0x6fcf6f0*/ void Serialize(ref MessagePack.MessagePackWriter writer, ref bool input, int length);
            static /*0x6fcf7b4*/ void Serialize(ref MessagePack.MessagePackWriter writer, ref sbyte input, int length);
            static /*0x6fcf8fc*/ void BigEndianSerialize(ref MessagePack.MessagePackWriter writer, ref sbyte input, int length);
            static /*0x6fcf7b8*/ void LittleEndianSerialize(ref MessagePack.MessagePackWriter writer, ref sbyte input, int length);
            static /*0x6fcf968*/ void Serialize(ref MessagePack.MessagePackWriter writer, ref short input, int length);
            static /*0x6fcfb1c*/ void BigEndianSerialize(ref MessagePack.MessagePackWriter writer, ref short input, int length);
            static /*0x6fcf96c*/ void LittleEndianSerialize(ref MessagePack.MessagePackWriter writer, ref short input, int length);
            static /*0x6fcfb88*/ void Serialize(ref MessagePack.MessagePackWriter writer, ref char input, int length);
            static /*0x6fcfb8c*/ void Serialize(ref MessagePack.MessagePackWriter writer, ref ushort input, int length);
            static /*0x6fcfd00*/ void BigEndianSerialize(ref MessagePack.MessagePackWriter writer, ref ushort input, int length);
            static /*0x6fcfb90*/ void LittleEndianSerialize(ref MessagePack.MessagePackWriter writer, ref ushort input, int length);
            static /*0x6fcfd6c*/ void Serialize(ref MessagePack.MessagePackWriter writer, ref int input, int length);
            static /*0x6fcff54*/ void BigEndianSerialize(ref MessagePack.MessagePackWriter writer, ref int input, int length);
            static /*0x6fcfd70*/ void LittleEndianSerialize(ref MessagePack.MessagePackWriter writer, ref int input, int length);
            static /*0x6fcffc0*/ void Serialize(ref MessagePack.MessagePackWriter writer, ref uint input, int length);
            static /*0x6fd0164*/ void BigEndianSerialize(ref MessagePack.MessagePackWriter writer, ref uint input, int length);
            static /*0x6fcffc4*/ void LittleEndianSerialize(ref MessagePack.MessagePackWriter writer, ref uint input, int length);
            static /*0x6fd01d0*/ void Serialize(ref MessagePack.MessagePackWriter writer, ref long input, int length);
            static /*0x6fd0408*/ void BigEndianSerialize(ref MessagePack.MessagePackWriter writer, ref long input, int length);
            static /*0x6fd01d4*/ void LittleEndianSerialize(ref MessagePack.MessagePackWriter writer, ref long input, int length);
            static /*0x6fd0474*/ void Serialize(ref MessagePack.MessagePackWriter writer, ref ulong input, int length);
            static /*0x6fd063c*/ void BigEndianSerialize(ref MessagePack.MessagePackWriter writer, ref ulong input, int length);
            static /*0x6fd0478*/ void LittleEndianSerialize(ref MessagePack.MessagePackWriter writer, ref ulong input, int length);
            static /*0x6fd06a8*/ void Serialize(ref MessagePack.MessagePackWriter writer, ref float input, int length);
            static /*0x6fd07e0*/ void BigEndianSerialize(ref MessagePack.MessagePackWriter writer, ref float input, int length);
            static /*0x6fd06ac*/ void LittleEndianSerialize(ref MessagePack.MessagePackWriter writer, ref float input, int length);
            static /*0x6fd0910*/ void Serialize(ref MessagePack.MessagePackWriter writer, ref double input, int length);
            static /*0x6fd0a48*/ void BigEndianSerialize(ref MessagePack.MessagePackWriter writer, ref double input, int length);
            static /*0x6fd0914*/ void LittleEndianSerialize(ref MessagePack.MessagePackWriter writer, ref double input, int length);
            static /*0x6fd0b78*/ nuint ReverseWriteUnknown(ref byte destination, byte value);
            static /*0x6fd0b9c*/ nuint ReverseWriteUnknown(ref byte destination, sbyte value);
            static /*0x6fd0bc8*/ nuint ReverseWriteUnknown(ref byte destination, ushort value);
            static /*0x6fd0c14*/ nuint ReverseWriteUnknown(ref byte destination, short value);
            static /*0x6fd0c8c*/ nuint ReverseWriteUnknown(ref byte destination, uint value);
            static /*0x6fd0cf8*/ nuint ReverseWriteUnknown(ref byte destination, int value);
            static /*0x6fd0da0*/ nuint ReverseWriteUnknown(ref byte destination, ulong value);
            static /*0x6fd0e30*/ nuint ReverseWriteUnknown(ref byte destination, long value);
        }

        class BuiltinResolverGetFormatterHelper
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, object> FormatterMap;

            static /*0x6fd1104*/ BuiltinResolverGetFormatterHelper();
            static /*0x6fd0f1c*/ object GetFormatter(System.Type t);
        }

        class DynamicGenericResolverGetFormatterHelper
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, System.Type> FormatterMap;

            static /*0x6fd6818*/ DynamicGenericResolverGetFormatterHelper();
            static /*0x6fd3c2c*/ object GetFormatter(System.Type t);
            static /*0x6fd67e0*/ object CreateInstance(System.Type genericType, System.Type[] genericTypeArguments, object[] arguments);

            class <>c
            {
                static /*0x0*/ MessagePack.Internal.DynamicGenericResolverGetFormatterHelper.<> <>9;
                static /*0x8*/ System.Func<System.Reflection.ConstructorInfo, bool> <>9__1_0;
                static /*0x10*/ System.Func<System.Reflection.ConstructorInfo, bool> <>9__1_1;
                static /*0x18*/ System.Func<System.Type, bool> <>9__1_2;
                static /*0x20*/ System.Func<System.Reflection.ConstructorInfo, bool> <>9__1_3;
                static /*0x28*/ System.Func<System.Type, bool> <>9__1_4;
                static /*0x30*/ System.Func<System.Type, bool> <>9__1_5;
                static /*0x38*/ System.Func<System.Reflection.ConstructorInfo, bool> <>9__1_6;
                static /*0x40*/ System.Func<System.Type, bool> <>9__1_8;

                static /*0x6fd72b4*/ <>c();
                /*0x6fd731c*/ <>c();
                /*0x6fd7324*/ bool <GetFormatter>b__1_0(System.Reflection.ConstructorInfo x);
                /*0x6fd7360*/ bool <GetFormatter>b__1_1(System.Reflection.ConstructorInfo x);
                /*0x6fd739c*/ bool <GetFormatter>b__1_2(System.Type x);
                /*0x6fd745c*/ bool <GetFormatter>b__1_3(System.Reflection.ConstructorInfo x);
                /*0x6fd74b0*/ bool <GetFormatter>b__1_4(System.Type x);
                /*0x6fd7570*/ bool <GetFormatter>b__1_5(System.Type x);
                /*0x6fd7630*/ bool <GetFormatter>b__1_6(System.Reflection.ConstructorInfo x);
                /*0x6fd7684*/ bool <GetFormatter>b__1_8(System.Type x);
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ System.Reflection.ParameterInfo[] parameters;

                /*0x6fd6810*/ <>c__DisplayClass1_0();
                /*0x6fd7744*/ bool <GetFormatter>b__7(System.Type allowedType);
            }
        }

        class DynamicObjectTypeBuilder
        {
            static /*0x0*/ System.Text.RegularExpressions.Regex SubtractFullNameRegex;
            static /*0x8*/ int nameSequence;
            static /*0x10*/ System.Collections.Generic.HashSet<System.Type> ignoreTypes;
            static /*0x18*/ System.Type refMessagePackReader;
            static /*0x20*/ System.Reflection.MethodInfo ReadOnlySpanFromByteArray;
            static /*0x28*/ System.Reflection.MethodInfo ReadStringSpan;
            static /*0x30*/ System.Reflection.MethodInfo ArrayFromNullableReadOnlySequence;
            static /*0x38*/ System.Reflection.MethodInfo getFormatterWithVerify;
            static /*0x40*/ System.Reflection.MethodInfo getResolverFromOptions;
            static /*0x48*/ System.Reflection.MethodInfo getSecurityFromOptions;
            static /*0x50*/ System.Reflection.MethodInfo securityDepthStep;
            static /*0x58*/ System.Reflection.MethodInfo readerDepthGet;
            static /*0x60*/ System.Reflection.MethodInfo readerDepthSet;
            static /*0x68*/ System.Func<System.Type, System.Reflection.MethodInfo> getSerialize;
            static /*0x70*/ System.Func<System.Type, System.Reflection.MethodInfo> getDeserialize;
            static /*0x78*/ System.Reflection.ConstructorInfo messagePackSerializationExceptionMessageOnlyConstructor;
            static /*0x80*/ System.Reflection.MethodInfo onBeforeSerialize;
            static /*0x88*/ System.Reflection.MethodInfo onAfterDeserialize;
            static /*0x90*/ System.Reflection.ConstructorInfo objectCtor;

            static /*0x6fe1dcc*/ DynamicObjectTypeBuilder();
            static /*0x6fd7794*/ System.Reflection.TypeInfo BuildType(MessagePack.Internal.DynamicAssembly assembly, System.Type type, bool forceStringKey, bool contractless, bool allowPrivate);
            static /*0x6fdb2a4*/ void BuildConstructor(System.Type type, MessagePack.Internal.ObjectSerializationInfo info, System.Reflection.ConstructorInfo method, System.Reflection.Emit.FieldBuilder stringByteKeysField, System.Reflection.Emit.ILGenerator il);
            static /*0x6fdb960*/ System.Collections.Generic.Dictionary<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, System.Reflection.FieldInfo> BuildCustomFormatterField(System.Reflection.Emit.TypeBuilder builder, MessagePack.Internal.ObjectSerializationInfo info, System.Reflection.Emit.ILGenerator il);
            static /*0x6fdc5a8*/ void BuildSerialize(System.Type type, MessagePack.Internal.ObjectSerializationInfo info, System.Reflection.Emit.ILGenerator il, System.Action emitStringByteKeys, System.Func<int, MessagePack.Internal.ObjectSerializationInfo.EmittableMember, System.Action> tryEmitLoadCustomFormatter, int firstArgIndex);
            static /*0x6fdde74*/ void EmitSerializeValue(System.Reflection.Emit.ILGenerator il, System.Reflection.TypeInfo type, MessagePack.Internal.ObjectSerializationInfo.EmittableMember member, int index, System.Func<int, MessagePack.Internal.ObjectSerializationInfo.EmittableMember, System.Action> tryEmitLoadCustomFormatter, MessagePack.Internal.ArgumentField argWriter, MessagePack.Internal.ArgumentField argValue, MessagePack.Internal.ArgumentField argOptions, System.Reflection.Emit.LocalBuilder localResolver);
            static /*0x6fdd994*/ void BuildDeserialize(System.Type type, MessagePack.Internal.ObjectSerializationInfo info, System.Reflection.Emit.TypeBuilder typeBuilder, System.Reflection.Emit.ILGenerator il, System.Func<int, MessagePack.Internal.ObjectSerializationInfo.EmittableMember, System.Action> tryEmitLoadCustomFormatter, int firstArgIndex);
            static /*0x6fdef34*/ void BuildDeserializeInternalDeserializeEachPropertyStringKey(MessagePack.Internal.ObjectSerializationInfo info, System.Reflection.Emit.TypeBuilder typeBuilder, System.Reflection.Emit.ILGenerator il, System.Func<int, MessagePack.Internal.ObjectSerializationInfo.EmittableMember, System.Action> tryEmitLoadCustomFormatter, bool canOverwrite, ref MessagePack.Internal.ArgumentField argReader, MessagePack.Internal.ArgumentField argOptions, System.Reflection.Emit.LocalBuilder localResolver, System.Reflection.Emit.LocalBuilder localResult, System.Reflection.Emit.LocalBuilder localLength);
            static /*0x6fdedec*/ void BuildDeserializeInternalDeserializeEachPropertyIntKey(MessagePack.Internal.ObjectSerializationInfo info, System.Reflection.Emit.TypeBuilder typeBuilder, System.Reflection.Emit.ILGenerator il, System.Func<int, MessagePack.Internal.ObjectSerializationInfo.EmittableMember, System.Action> tryEmitLoadCustomFormatter, bool canOverwrite, ref MessagePack.Internal.ArgumentField argReader, ref MessagePack.Internal.ArgumentField argOptions, System.Reflection.Emit.LocalBuilder localResolver, System.Reflection.Emit.LocalBuilder localResult, System.Reflection.Emit.LocalBuilder localLength);
            static /*0x6fdfd64*/ void BuildDeserializeInternalAssignFieldFromLocalVariableStringKey(MessagePack.Internal.ObjectSerializationInfo info, System.Reflection.Emit.TypeBuilder typeBuilder, System.Reflection.Emit.ILGenerator il, MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo[] infoList, System.Reflection.Emit.LocalBuilder localResult);
            static /*0x6fe0570*/ void BuildDeserializeInternalAssignFieldFromLocalVariableIntKey(System.Reflection.Emit.TypeBuilder typeBuilder, MessagePack.Internal.ObjectSerializationInfo info, System.Reflection.Emit.ILGenerator il, MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo[] infoList, System.Reflection.Emit.LocalBuilder localResult, System.Reflection.Emit.LocalBuilder localLength, int maxKey);
            static /*0x6fdfa98*/ void BuildDeserializeInternalCreateInstanceWithArguments(MessagePack.Internal.ObjectSerializationInfo info, System.Reflection.Emit.ILGenerator il, MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo[] infoList, System.Reflection.Emit.LocalBuilder localResult);
            static /*0x6fdf4e4*/ MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo[] BuildDeserializeInternalDeserializationInfoArrayStringKey(MessagePack.Internal.ObjectSerializationInfo info, System.Reflection.Emit.ILGenerator il, bool canOverwrite);
            static /*0x6fdfee4*/ MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo[] BuildDeserializeInternalDeserializationInfoArrayIntKey(MessagePack.Internal.ObjectSerializationInfo info, System.Reflection.Emit.ILGenerator il, bool canOverwrite, ref System.Nullable<System.Reflection.Emit.Label> gotoDefault, ref int maxKey);
            static /*0x6fe035c*/ void BuildDeserializeInternalDeserializeLoopIntKey(System.Reflection.Emit.TypeBuilder typeBuilder, System.Reflection.Emit.ILGenerator il, System.Func<int, MessagePack.Internal.ObjectSerializationInfo.EmittableMember, System.Action> tryEmitLoadCustomFormatter, ref MessagePack.Internal.ArgumentField argReader, ref MessagePack.Internal.ArgumentField argOptions, MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo[] infoList, System.Reflection.Emit.LocalBuilder localResolver, System.Reflection.Emit.LocalBuilder localResult, System.Reflection.Emit.LocalBuilder localLength, bool canOverwrite, System.Nullable<System.Reflection.Emit.Label> gotoDefault);
            static /*0x6fdf7b0*/ void BuildDeserializeInternalDeserializeLoopStringKey(System.Reflection.Emit.TypeBuilder typeBuilder, System.Reflection.Emit.ILGenerator il, System.Func<int, MessagePack.Internal.ObjectSerializationInfo.EmittableMember, System.Action> tryEmitLoadCustomFormatter, ref MessagePack.Internal.ArgumentField argReader, ref MessagePack.Internal.ArgumentField argOptions, MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo[] infoList, System.Reflection.Emit.LocalBuilder localResolver, System.Reflection.Emit.LocalBuilder localResult, System.Reflection.Emit.LocalBuilder localLength, bool canOverwrite, MessagePack.Internal.ObjectSerializationInfo info);
            static /*0x6fde844*/ void BuildDeserializeInternalTryReadNil(System.Type type, System.Reflection.Emit.ILGenerator il, ref MessagePack.Internal.ArgumentField argReader);
            static /*0x6fdf3d0*/ void BuildDeserializeInternalDepthUnStep(System.Reflection.Emit.ILGenerator il, ref MessagePack.Internal.ArgumentField argReader);
            static /*0x6fdf078*/ void BuildDeserializeInternalOnAfterDeserialize(System.Type type, MessagePack.Internal.ObjectSerializationInfo info, System.Reflection.Emit.ILGenerator il, System.Reflection.Emit.LocalBuilder localResult);
            static /*0x6fdece4*/ System.Reflection.Emit.LocalBuilder BuildDeserializeInternalResolver(MessagePack.Internal.ObjectSerializationInfo info, System.Reflection.Emit.ILGenerator il, ref MessagePack.Internal.ArgumentField argOptions);
            static /*0x6fdebe8*/ System.Reflection.Emit.LocalBuilder BuildDeserializeInternalReadHeaderLength(MessagePack.Internal.ObjectSerializationInfo info, System.Reflection.Emit.ILGenerator il, ref MessagePack.Internal.ArgumentField argReader);
            static /*0x6fdeb44*/ void BuildDeserializeInternalDepthStep(System.Reflection.Emit.ILGenerator il, ref MessagePack.Internal.ArgumentField argReader, ref MessagePack.Internal.ArgumentField argOptions);
            static /*0x6fdea44*/ void BuildDeserializeInternalCreateInstance(System.Type type, MessagePack.Internal.ObjectSerializationInfo info, System.Reflection.Emit.ILGenerator il, System.Reflection.Emit.LocalBuilder localResult);
            static /*0x6fe0be4*/ void BuildDeserializeInternalDeserializeValueAssignDirectly(System.Reflection.Emit.TypeBuilder typeBuilder, System.Reflection.Emit.ILGenerator il, MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo info, int index, System.Func<int, MessagePack.Internal.ObjectSerializationInfo.EmittableMember, System.Action> tryEmitLoadCustomFormatter, ref MessagePack.Internal.ArgumentField argReader, ref MessagePack.Internal.ArgumentField argOptions, System.Reflection.Emit.LocalBuilder localResolver, System.Reflection.Emit.LocalBuilder localResult);
            static /*0x6fe17d0*/ void BuildDeserializeInternalDeserializeValueAssignLocalVariable(System.Reflection.Emit.ILGenerator il, MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo info, int index, System.Func<int, MessagePack.Internal.ObjectSerializationInfo.EmittableMember, System.Action> tryEmitLoadCustomFormatter, ref MessagePack.Internal.ArgumentField argReader, ref MessagePack.Internal.ArgumentField argOptions, System.Reflection.Emit.LocalBuilder localResolver, System.Reflection.Emit.LocalBuilder localResult);

            class MessagePackWriterTypeInfo
            {
                static /*0x0*/ System.Reflection.TypeInfo TypeInfo;
                static /*0x8*/ System.Reflection.MethodInfo WriteMapHeader;
                static /*0x10*/ System.Reflection.MethodInfo WriteArrayHeader;
                static /*0x18*/ System.Reflection.MethodInfo WriteBytes;
                static /*0x20*/ System.Reflection.MethodInfo WriteNil;
                static /*0x28*/ System.Reflection.MethodInfo WriteRaw;

                static /*0x6fe2b2c*/ MessagePackWriterTypeInfo();
            }

            class MessagePackReaderTypeInfo
            {
                static /*0x0*/ System.Reflection.TypeInfo TypeInfo;
                static /*0x8*/ System.Reflection.MethodInfo ReadArrayHeader;
                static /*0x10*/ System.Reflection.MethodInfo ReadMapHeader;
                static /*0x18*/ System.Reflection.MethodInfo ReadBytes;
                static /*0x20*/ System.Reflection.MethodInfo TryReadNil;
                static /*0x28*/ System.Reflection.MethodInfo Skip;

                static /*0x6fe2f20*/ MessagePackReaderTypeInfo();
            }

            class CodeGenHelpersTypeInfo
            {
                static /*0x0*/ System.Reflection.MethodInfo GetEncodedStringBytes;

                static /*0x6fe3160*/ CodeGenHelpersTypeInfo();
            }

            class EmitInfo
            {
                static /*0x0*/ System.Reflection.MethodInfo GetTypeFromHandle;
                static /*0x8*/ System.Reflection.MethodInfo TypeGetProperty;
                static /*0x10*/ System.Reflection.MethodInfo TypeGetField;
                static /*0x18*/ System.Reflection.MethodInfo GetCustomAttributeMessagePackFormatterAttribute;
                static /*0x20*/ System.Reflection.MethodInfo ActivatorCreateInstance;

                static /*0x6fe32a8*/ EmitInfo();

                class MessagePackFormatterAttr
                {
                    static /*0x0*/ System.Reflection.MethodInfo FormatterType;
                    static /*0x8*/ System.Reflection.MethodInfo Arguments;

                    static /*0x6fe3f5c*/ MessagePackFormatterAttr();
                }
            }

            class DeserializeInfo
            {
                /*0x10*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMember <MemberInfo>k__BackingField;
                /*0x18*/ System.Reflection.Emit.LocalBuilder <LocalVariable>k__BackingField;
                /*0x20*/ System.Reflection.Emit.LocalBuilder <IsInitializedLocalVariable>k__BackingField;
                /*0x28*/ System.Reflection.Emit.Label <SwitchLabel>k__BackingField;

                /*0x6fe0bbc*/ DeserializeInfo();
                /*0x6fe42d0*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMember get_MemberInfo();
                /*0x6fe42d8*/ void set_MemberInfo(MessagePack.Internal.ObjectSerializationInfo.EmittableMember value);
                /*0x6fe42e0*/ System.Reflection.Emit.LocalBuilder get_LocalVariable();
                /*0x6fe42e8*/ void set_LocalVariable(System.Reflection.Emit.LocalBuilder value);
                /*0x6fe42f0*/ System.Reflection.Emit.LocalBuilder get_IsInitializedLocalVariable();
                /*0x6fe42f8*/ void set_IsInitializedLocalVariable(System.Reflection.Emit.LocalBuilder value);
                /*0x6fe4300*/ System.Reflection.Emit.Label get_SwitchLabel();
                /*0x6fe4308*/ void set_SwitchLabel(System.Reflection.Emit.Label value);
            }

            class <>c
            {
                static /*0x0*/ MessagePack.Internal.DynamicObjectTypeBuilder.<> <>9;
                static /*0x8*/ System.Func<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, bool> <>9__4_0;
                static /*0x10*/ System.Func<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, bool> <>9__4_1;
                static /*0x18*/ System.Func<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, bool> <>9__5_0;
                static /*0x20*/ System.Func<System.Type, bool> <>9__6_0;
                static /*0x28*/ System.Func<System.Reflection.MethodInfo, bool> <>9__6_1;
                static /*0x30*/ System.Func<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, bool> <>9__6_2;
                static /*0x38*/ System.Func<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, int> <>9__6_3;
                static /*0x40*/ System.Func<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, bool> <>9__6_4;
                static /*0x48*/ System.Func<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, int> <>9__6_5;
                static /*0x50*/ System.Func<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, bool> <>9__6_6;
                static /*0x58*/ System.Func<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, bool> <>9__6_7;
                static /*0x60*/ System.Func<MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo, bool> <>9__12_0;
                static /*0x68*/ System.Func<MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo, int> <>9__12_1;
                static /*0x70*/ System.Func<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, int> <>9__15_0;
                static /*0x78*/ System.Func<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, int> <>9__15_1;
                static /*0x80*/ System.Func<MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo, System.Reflection.Emit.Label> <>9__16_1;
                static /*0x88*/ System.Func<System.Type, bool> <>9__20_0;
                static /*0x90*/ System.Func<System.Reflection.MethodInfo, bool> <>9__20_1;
                static /*0x98*/ System.Func<System.Reflection.MethodInfo, bool> <>9__25_0;
                static /*0xa0*/ System.Func<System.Reflection.MethodInfo, bool> <>9__26_0;

                static /*0x6fe4310*/ <>c();
                /*0x6fe4378*/ <>c();
                /*0x6fe4380*/ bool <BuildConstructor>b__4_0(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x6fe4398*/ bool <BuildConstructor>b__4_1(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x6fe43b0*/ bool <BuildCustomFormatterField>b__5_0(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x6fe43e0*/ bool <BuildSerialize>b__6_0(System.Type x);
                /*0x6fe4454*/ bool <BuildSerialize>b__6_1(System.Reflection.MethodInfo x);
                /*0x6fe44b4*/ bool <BuildSerialize>b__6_2(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x6fe44cc*/ int <BuildSerialize>b__6_3(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x6fe44e4*/ bool <BuildSerialize>b__6_4(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x6fe44fc*/ int <BuildSerialize>b__6_5(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x6fe4514*/ bool <BuildSerialize>b__6_6(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x6fe452c*/ bool <BuildSerialize>b__6_7(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x6fe4544*/ bool <BuildDeserializeInternalAssignFieldFromLocalVariableIntKey>b__12_0(MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo x);
                /*0x6fe4574*/ int <BuildDeserializeInternalAssignFieldFromLocalVariableIntKey>b__12_1(MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo x);
                /*0x6fe4594*/ int <BuildDeserializeInternalDeserializationInfoArrayIntKey>b__15_0(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x6fe45ac*/ int <BuildDeserializeInternalDeserializationInfoArrayIntKey>b__15_1(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x6fe45c4*/ System.Reflection.Emit.Label <BuildDeserializeInternalDeserializeLoopIntKey>b__16_1(MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo x);
                /*0x6fe45dc*/ bool <BuildDeserializeInternalOnAfterDeserialize>b__20_0(System.Type x);
                /*0x6fe4650*/ bool <BuildDeserializeInternalOnAfterDeserialize>b__20_1(System.Reflection.MethodInfo x);
                /*0x6fe46b0*/ bool <BuildDeserializeInternalDeserializeValueAssignDirectly>b__25_0(System.Reflection.MethodInfo x);
                /*0x6fe46ec*/ bool <BuildDeserializeInternalDeserializeValueAssignLocalVariable>b__26_0(System.Reflection.MethodInfo x);
                /*0x6fe4728*/ bool <.cctor>b__49_0(System.Reflection.MethodInfo x);
                /*0x6fe4788*/ System.Reflection.MethodInfo <.cctor>b__49_1(System.Type t);
                /*0x6fe49c0*/ System.Reflection.MethodInfo <.cctor>b__49_2(System.Type t);
                /*0x6fe4bbc*/ bool <.cctor>b__49_3(System.Reflection.ConstructorInfo x);
                /*0x6fe4c60*/ bool <.cctor>b__49_4(System.Reflection.ConstructorInfo x);
            }

            class <>c__DisplayClass13_0
            {
                /*0x10*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMemberAndConstructorParameter item;

                /*0x6fe0b58*/ <>c__DisplayClass13_0();
                /*0x6fe4c9c*/ bool <BuildDeserializeInternalCreateInstanceWithArguments>b__0(MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo x);
            }

            class <>c__DisplayClass14_0
            {
                /*0x10*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMember item;

                /*0x6fe0bb4*/ <>c__DisplayClass14_0();
                /*0x6fe4cc8*/ bool <BuildDeserializeInternalDeserializationInfoArrayStringKey>b__0(MessagePack.Internal.ObjectSerializationInfo.EmittableMemberAndConstructorParameter p);
            }

            class <>c__DisplayClass16_0
            {
                /*0x10*/ System.Reflection.Emit.ILGenerator il;
                /*0x18*/ System.Reflection.Emit.LocalBuilder key;
                /*0x20*/ MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo[] infoList;
                /*0x28*/ System.Reflection.Emit.Label switchDefault;
                /*0x30*/ MessagePack.Internal.ArgumentField reader;
                /*0x40*/ System.Nullable<System.Reflection.Emit.Label> gotoDefault;
                /*0x48*/ bool canOverwrite;
                /*0x50*/ System.Reflection.Emit.TypeBuilder typeBuilder;
                /*0x58*/ System.Func<int, MessagePack.Internal.ObjectSerializationInfo.EmittableMember, System.Action> tryEmitLoadCustomFormatter;
                /*0x60*/ MessagePack.Internal.ArgumentField options;
                /*0x70*/ System.Reflection.Emit.LocalBuilder localResolver;
                /*0x78*/ System.Reflection.Emit.LocalBuilder localResult;

                /*0x6fe0bc4*/ <>c__DisplayClass16_0();
                /*0x6fe4cf4*/ void <BuildDeserializeInternalDeserializeLoopIntKey>g__ForBody|0(System.Reflection.Emit.LocalBuilder forILocal);
            }

            class <>c__DisplayClass17_0
            {
                /*0x10*/ System.Reflection.Emit.ILGenerator il;
                /*0x18*/ MessagePack.Internal.ArgumentField reader;
                /*0x28*/ System.Reflection.Emit.LocalBuilder buffer;
                /*0x30*/ MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo[] infoList;
                /*0x38*/ System.Reflection.Emit.TypeBuilder typeBuilder;
                /*0x40*/ System.Func<int, MessagePack.Internal.ObjectSerializationInfo.EmittableMember, System.Action> tryEmitLoadCustomFormatter;
                /*0x48*/ MessagePack.Internal.ArgumentField options;
                /*0x58*/ System.Reflection.Emit.LocalBuilder localResolver;
                /*0x60*/ System.Reflection.Emit.LocalBuilder localResult;
                /*0x68*/ bool canOverwrite;
                /*0x70*/ MessagePack.Internal.AutomataDictionary automata;
                /*0x78*/ System.Reflection.Emit.LocalBuilder longKey;

                /*0x6fe0bcc*/ <>c__DisplayClass17_0();
                /*0x6fe51b4*/ void <BuildDeserializeInternalDeserializeLoopStringKey>g__ForBody|0(System.Reflection.Emit.LocalBuilder forILocal);
            }

            class <>c__DisplayClass17_1
            {
                /*0x10*/ System.Reflection.Emit.Label loopEnd;
                /*0x14*/ System.Reflection.Emit.Label readNext;
                /*0x18*/ MessagePack.Internal.DynamicObjectTypeBuilder.<> CS$<>8__locals1;

                /*0x6fe542c*/ <>c__DisplayClass17_1();
                /*0x6fe5434*/ void <BuildDeserializeInternalDeserializeLoopStringKey>g__OnFoundAssignDirect|1(System.Collections.Generic.KeyValuePair<string, int> x);
                /*0x6fe55ac*/ void <BuildDeserializeInternalDeserializeLoopStringKey>g__OnFoundAssignLocalVariable|2(System.Collections.Generic.KeyValuePair<string, int> x);
                /*0x6fe5714*/ void <BuildDeserializeInternalDeserializeLoopStringKey>g__OnNotFound|3();
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ System.Reflection.Emit.FieldBuilder stringByteKeysField;
                /*0x18*/ System.Collections.Generic.Dictionary<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, System.Reflection.FieldInfo> customFormatterLookup;

                /*0x6fdb28c*/ <>c__DisplayClass3_0();
            }

            class <>c__DisplayClass3_1
            {
                /*0x10*/ System.Reflection.Emit.ILGenerator il;
                /*0x18*/ MessagePack.Internal.DynamicObjectTypeBuilder.<> CS$<>8__locals1;

                /*0x6fdc5a0*/ <>c__DisplayClass3_1();
                /*0x6fe5794*/ void <BuildType>b__0();
                /*0x6fe57c8*/ System.Action <BuildType>b__1(int index, MessagePack.Internal.ObjectSerializationInfo.EmittableMember member);
            }

            class <>c__DisplayClass3_2
            {
                /*0x10*/ System.Reflection.FieldInfo fi;
                /*0x18*/ MessagePack.Internal.DynamicObjectTypeBuilder.<> CS$<>8__locals2;

                /*0x6fe58c8*/ <>c__DisplayClass3_2();
                /*0x6fe58d0*/ void <BuildType>b__2();
            }

            class <>c__DisplayClass3_3
            {
                /*0x10*/ System.Reflection.Emit.ILGenerator il;
                /*0x18*/ MessagePack.Internal.DynamicObjectTypeBuilder.<> CS$<>8__locals3;

                /*0x6fdd98c*/ <>c__DisplayClass3_3();
                /*0x6fe590c*/ System.Action <BuildType>b__3(int index, MessagePack.Internal.ObjectSerializationInfo.EmittableMember member);
            }

            class <>c__DisplayClass3_4
            {
                /*0x10*/ System.Reflection.FieldInfo fi;
                /*0x18*/ MessagePack.Internal.DynamicObjectTypeBuilder.<> CS$<>8__locals4;

                /*0x6fe5a0c*/ <>c__DisplayClass3_4();
                /*0x6fe5a14*/ void <BuildType>b__4();
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMember item;

                /*0x6fddcd4*/ <>c__DisplayClass5_0();
                /*0x6fe5a50*/ bool <BuildCustomFormatterField>b__1(System.Type i);
            }
        }

        class ObjectSerializationInfo
        {
            /*0x10*/ System.Type <Type>k__BackingField;
            /*0x18*/ bool <IsIntKey>k__BackingField;
            /*0x19*/ bool <IsClass>k__BackingField;
            /*0x1a*/ bool <ShouldUseFormatterResolver>k__BackingField;
            /*0x20*/ System.Reflection.ConstructorInfo <BestmatchConstructor>k__BackingField;
            /*0x28*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMemberAndConstructorParameter[] <ConstructorParameters>k__BackingField;
            /*0x30*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMember[] <Members>k__BackingField;

            static /*0x6fd8694*/ MessagePack.Internal.ObjectSerializationInfo CreateOrNull(System.Type type, bool forceStringKey, bool contractless, bool allowPrivate);
            static /*0x6fde520*/ bool IsOptimizeTargetType(System.Type type);
            static /*0x6fe64a4*/ System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> GetAllFields(System.Type type);
            static /*0x6fe6428*/ System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> GetAllProperties(System.Type type);
            static /*0x6fe5fd8*/ bool IsClassRecord(System.Reflection.TypeInfo type);
            static /*0x6fe656c*/ bool TryGetNextConstructor(System.Collections.Generic.IEnumerator<System.Reflection.ConstructorInfo> ctorEnumerator, ref System.Reflection.ConstructorInfo ctor);
            /*0x6fe5bbc*/ ObjectSerializationInfo(System.Type type, MessagePack.Internal.ObjectSerializationInfo.EmittableMemberAndConstructorParameter[] constructorParameters, MessagePack.Internal.ObjectSerializationInfo.EmittableMember[] members, bool isClass, System.Reflection.ConstructorInfo bestmatchConstructor, bool isIntKey);
            /*0x6fe5b78*/ System.Type get_Type();
            /*0x6fe5b80*/ bool get_IsIntKey();
            /*0x6fdb294*/ bool get_IsStringKey();
            /*0x6fe5b88*/ bool get_IsClass();
            /*0x6fe0bd4*/ bool get_IsStruct();
            /*0x6fe5b90*/ bool get_ShouldUseFormatterResolver();
            /*0x6fe5b98*/ void set_ShouldUseFormatterResolver(bool value);
            /*0x6fe5ba4*/ System.Reflection.ConstructorInfo get_BestmatchConstructor();
            /*0x6fe5bac*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMemberAndConstructorParameter[] get_ConstructorParameters();
            /*0x6fe5bb4*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMember[] get_Members();

            class EmittableMemberAndConstructorParameter
            {
                /*0x10*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMember <MemberInfo>k__BackingField;
                /*0x18*/ System.Reflection.ParameterInfo <ConstructorParameter>k__BackingField;

                /*0x6fe6528*/ EmittableMemberAndConstructorParameter(MessagePack.Internal.ObjectSerializationInfo.EmittableMember memberInfo, System.Reflection.ParameterInfo constructorParameter);
                /*0x6fe6718*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMember get_MemberInfo();
                /*0x6fe6720*/ System.Reflection.ParameterInfo get_ConstructorParameter();
            }

            class EmittableMember
            {
                /*0x10*/ bool <IsWritable>k__BackingField;
                /*0x11*/ bool <IsWrittenByConstructor>k__BackingField;
                /*0x12*/ bool <IsReadable>k__BackingField;
                /*0x14*/ int <IntKey>k__BackingField;
                /*0x18*/ string <StringKey>k__BackingField;
                /*0x20*/ System.Reflection.MemberInfo <MemberInfo>k__BackingField;
                /*0x28*/ bool <IsExplicitContract>k__BackingField;
                /*0x29*/ bool <IsProblematicInitProperty>k__BackingField;
                /*0x30*/ System.Delegate setterHelperDelegate;
                /*0x38*/ System.Reflection.Emit.FieldBuilder setterHelperField;

                /*0x6fe6728*/ EmittableMember(System.Reflection.MemberInfo memberInfo);
                /*0x6fdde5c*/ bool get_IsProperty();
                /*0x6fe6758*/ bool get_IsWritable();
                /*0x6fe6760*/ void set_IsWritable(bool value);
                /*0x6fe676c*/ bool get_IsWrittenByConstructor();
                /*0x6fe6774*/ void set_IsWrittenByConstructor(bool value);
                /*0x6fe5dc0*/ bool get_IsInitOnly();
                /*0x6fe6780*/ bool get_IsReadable();
                /*0x6fe6788*/ void set_IsReadable(bool value);
                /*0x6fe6794*/ int get_IntKey();
                /*0x6fe679c*/ void set_IntKey(int value);
                /*0x6fe67a4*/ string get_StringKey();
                /*0x6fe67ac*/ void set_StringKey(string value);
                /*0x6fddd8c*/ System.Type get_Type();
                /*0x6fe67b4*/ System.Reflection.MemberInfo get_MemberInfo();
                /*0x6fe6054*/ System.Reflection.FieldInfo get_FieldInfo();
                /*0x6fddd44*/ string get_Name();
                /*0x6fe5f54*/ System.Reflection.PropertyInfo get_PropertyInfo();
                /*0x6fe0b60*/ bool get_IsValueType();
                /*0x6fe67bc*/ bool get_IsExplicitContract();
                /*0x6fe67c4*/ void set_IsExplicitContract(bool value);
                /*0x6fe67d0*/ bool get_IsProblematicInitProperty();
                /*0x6fe67d8*/ void set_IsProblematicInitProperty(bool value);
                /*0x6fddcdc*/ MessagePack.MessagePackFormatterAttribute GetMessagePackFormatterAttribute();
                /*0x6fe67e4*/ System.Runtime.Serialization.DataMemberAttribute GetDataMemberAttribute();
                /*0x6fde408*/ void EmitLoadValue(System.Reflection.Emit.ILGenerator il);
                /*0x6fddc5c*/ void OnTypeCreated(System.Reflection.TypeInfo formatterType);
                /*0x6fe1268*/ void EmitPreStoreValue(System.Reflection.Emit.TypeBuilder typeBuilder, System.Reflection.Emit.ILGenerator il, System.Reflection.Emit.LocalBuilder localResult);
                /*0x6fe096c*/ void EmitStoreValue(System.Reflection.Emit.ILGenerator il, System.Reflection.Emit.TypeBuilder typeBuilder);

                class PropertySetterHelperForStructs<T, TValue> : System.MulticastDelegate
                {
                    PropertySetterHelperForStructs(object object, nint method);
                    /*0x3910ae8*/ void Invoke(ref T target, TValue value);
                }

                class <>c
                {
                    static /*0x0*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMember.<> <>9;
                    static /*0x8*/ System.Func<System.Type, bool> <>9__14_0;

                    static /*0x6fe684c*/ <>c();
                    /*0x6fe68b4*/ <>c();
                    /*0x6fe68bc*/ bool <get_IsInitOnly>b__14_0(System.Type modifierType);
                }
            }

            class OrderBaseTypesBeforeDerivedTypes : System.Collections.Generic.IComparer<System.Type>
            {
                static /*0x0*/ MessagePack.Internal.ObjectSerializationInfo.OrderBaseTypesBeforeDerivedTypes Instance;

                static /*0x6fe6a10*/ OrderBaseTypesBeforeDerivedTypes();
                /*0x6fe6920*/ OrderBaseTypesBeforeDerivedTypes();
                /*0x6fe6928*/ int Compare(System.Type x, System.Type y);
            }

            class <>c
            {
                static /*0x0*/ MessagePack.Internal.ObjectSerializationInfo.<> <>9;
                static /*0x8*/ System.Func<System.Reflection.MemberInfo, System.Type> <>9__27_8;
                static /*0x10*/ System.Func<System.Reflection.MemberInfo, string> <>9__27_9;
                static /*0x18*/ System.Func<System.Reflection.ConstructorInfo, bool> <>9__27_2;
                static /*0x20*/ System.Func<System.Reflection.ConstructorInfo, int> <>9__27_4;
                static /*0x28*/ System.Func<System.Collections.Generic.KeyValuePair<int, MessagePack.Internal.ObjectSerializationInfo.EmittableMember>, int> <>9__27_10;
                static /*0x30*/ System.Func<System.Collections.Generic.KeyValuePair<int, MessagePack.Internal.ObjectSerializationInfo.EmittableMember>, int, System.ValueTuple<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, int>> <>9__27_11;
                static /*0x38*/ System.Func<System.ValueTuple<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, int>, int> <>9__27_12;
                static /*0x40*/ System.Func<System.ValueTuple<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, int>, MessagePack.Internal.ObjectSerializationInfo.EmittableMember> <>9__27_13;
                static /*0x48*/ System.Func<System.Collections.Generic.KeyValuePair<string, MessagePack.Internal.ObjectSerializationInfo.EmittableMember>, string> <>9__27_14;
                static /*0x50*/ System.Func<System.Collections.Generic.KeyValuePair<string, MessagePack.Internal.ObjectSerializationInfo.EmittableMember>, System.Collections.Generic.KeyValuePair<string, MessagePack.Internal.ObjectSerializationInfo.EmittableMember>> <>9__27_15;
                static /*0x58*/ System.Func<System.Collections.Generic.KeyValuePair<string, MessagePack.Internal.ObjectSerializationInfo.EmittableMember>, string> <>9__27_16;
                static /*0x60*/ System.Func<System.Collections.Generic.KeyValuePair<string, MessagePack.Internal.ObjectSerializationInfo.EmittableMember>, System.Collections.Generic.KeyValuePair<string, MessagePack.Internal.ObjectSerializationInfo.EmittableMember>> <>9__27_17;
                static /*0x68*/ System.Func<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, int> <>9__27_5;
                static /*0x70*/ System.Func<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, int> <>9__27_6;
                static /*0x78*/ System.Func<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, bool> <>9__27_7;

                static /*0x6fe6a78*/ <>c();
                /*0x6fe6ae0*/ <>c();
                /*0x6fe6ae8*/ System.Type <CreateOrNull>b__27_8(System.Reflection.MemberInfo m);
                /*0x6fe6b0c*/ string <CreateOrNull>b__27_9(System.Reflection.MemberInfo m);
                /*0x6fe6b30*/ bool <CreateOrNull>b__27_2(System.Reflection.ConstructorInfo x);
                /*0x6fe6b88*/ int <CreateOrNull>b__27_4(System.Reflection.ConstructorInfo x);
                /*0x6fe6bbc*/ int <CreateOrNull>b__27_10(System.Collections.Generic.KeyValuePair<int, MessagePack.Internal.ObjectSerializationInfo.EmittableMember> x);
                /*0x6fe6bf8*/ System.ValueTuple<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, int> <CreateOrNull>b__27_11(System.Collections.Generic.KeyValuePair<int, MessagePack.Internal.ObjectSerializationInfo.EmittableMember> x, int i);
                /*0x6fe6c74*/ int <CreateOrNull>b__27_12(System.ValueTuple<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, int> x);
                /*0x6fe6c7c*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMember <CreateOrNull>b__27_13(System.ValueTuple<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, int> x);
                /*0x6fe6c84*/ string <CreateOrNull>b__27_14(System.Collections.Generic.KeyValuePair<string, MessagePack.Internal.ObjectSerializationInfo.EmittableMember> x);
                /*0x6fe6cc0*/ System.Collections.Generic.KeyValuePair<string, MessagePack.Internal.ObjectSerializationInfo.EmittableMember> <CreateOrNull>b__27_15(System.Collections.Generic.KeyValuePair<string, MessagePack.Internal.ObjectSerializationInfo.EmittableMember> x);
                /*0x6fe6ccc*/ string <CreateOrNull>b__27_16(System.Collections.Generic.KeyValuePair<string, MessagePack.Internal.ObjectSerializationInfo.EmittableMember> x);
                /*0x6fe6d10*/ System.Collections.Generic.KeyValuePair<string, MessagePack.Internal.ObjectSerializationInfo.EmittableMember> <CreateOrNull>b__27_17(System.Collections.Generic.KeyValuePair<string, MessagePack.Internal.ObjectSerializationInfo.EmittableMember> x);
                /*0x6fe6d1c*/ int <CreateOrNull>b__27_5(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x6fe6d34*/ int <CreateOrNull>b__27_6(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x6fe6d60*/ bool <CreateOrNull>b__27_7(MessagePack.Internal.ObjectSerializationInfo.EmittableMember m);
            }

            class <>c__DisplayClass26_0
            {
                /*0x10*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMember member;

                /*0x6fe5db8*/ <>c__DisplayClass26_0();
                /*0x6fe6d98*/ bool <.ctor>b__0(MessagePack.Internal.ObjectSerializationInfo.EmittableMemberAndConstructorParameter cp);
            }

            class <>c__DisplayClass27_0
            {
                /*0x10*/ System.Collections.Generic.Dictionary<int, MessagePack.Internal.ObjectSerializationInfo.EmittableMember> intMembers;
                /*0x18*/ System.Collections.Generic.Dictionary<string, MessagePack.Internal.ObjectSerializationInfo.EmittableMember> stringMembers;
                /*0x20*/ System.Type type;
                /*0x28*/ bool isClassRecord;
                /*0x29*/ bool allowPrivate;

                /*0x6fe5fd0*/ <>c__DisplayClass27_0();
                /*0x6fe60d0*/ bool <CreateOrNull>g__AddEmittableMemberOrIgnore|0(bool isIntKeyMode, MessagePack.Internal.ObjectSerializationInfo.EmittableMember member, bool checkConflicting);
                /*0x6fe6dbc*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMember <CreateOrNull>g__CreateEmittableMember|1(System.Reflection.MemberInfo m);
                /*0x6fe720c*/ bool <CreateOrNull>b__3(System.Reflection.ConstructorInfo x);
            }

            class <GetAllFields>d__29 : System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Reflection.FieldInfo>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Reflection.FieldInfo <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ System.Type type;
                /*0x30*/ System.Type <>3__type;
                /*0x38*/ System.Collections.Generic.IEnumerator<System.Reflection.FieldInfo> <>7__wrap1;
                /*0x40*/ System.Reflection.FieldInfo[] <>7__wrap2;
                /*0x48*/ int <>7__wrap3;

                /*0x6fe66b0*/ <GetAllFields>d__29(int <>1__state);
                /*0x6fe7268*/ void System.IDisposable.Dispose();
                /*0x6fe7284*/ bool MoveNext();
                /*0x6fe7640*/ void <>m__Finally1();
                /*0x6fe76f0*/ System.Reflection.FieldInfo System.Collections.Generic.IEnumerator<System.Reflection.FieldInfo>.get_Current();
                /*0x6fe76f8*/ void System.Collections.IEnumerator.Reset();
                /*0x6fe7730*/ object System.Collections.IEnumerator.get_Current();
                /*0x6fe7738*/ System.Collections.Generic.IEnumerator<System.Reflection.FieldInfo> System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo>.GetEnumerator();
                /*0x6fe77dc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <GetAllProperties>d__30 : System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Reflection.PropertyInfo>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Reflection.PropertyInfo <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ System.Type type;
                /*0x30*/ System.Type <>3__type;
                /*0x38*/ System.Collections.Generic.IEnumerator<System.Reflection.PropertyInfo> <>7__wrap1;
                /*0x40*/ System.Reflection.PropertyInfo[] <>7__wrap2;
                /*0x48*/ int <>7__wrap3;

                /*0x6fe66e4*/ <GetAllProperties>d__30(int <>1__state);
                /*0x6fe77e0*/ void System.IDisposable.Dispose();
                /*0x6fe77fc*/ bool MoveNext();
                /*0x6fe7bb8*/ void <>m__Finally1();
                /*0x6fe7c68*/ System.Reflection.PropertyInfo System.Collections.Generic.IEnumerator<System.Reflection.PropertyInfo>.get_Current();
                /*0x6fe7c70*/ void System.Collections.IEnumerator.Reset();
                /*0x6fe7ca8*/ object System.Collections.IEnumerator.get_Current();
                /*0x6fe7cb0*/ System.Collections.Generic.IEnumerator<System.Reflection.PropertyInfo> System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo>.GetEnumerator();
                /*0x6fe7d54*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class MessagePackDynamicObjectResolverException : MessagePack.MessagePackSerializationException
        {
            /*0x6fe6520*/ MessagePackDynamicObjectResolverException(string message);
        }

        class ResolverUtilities
        {
            static /*0x6fe7d58*/ MessagePack.Formatters.IMessagePackFormatter ActivateFormatter(System.Type formatterType, object[] args);
            static /*0x6fddddc*/ System.Reflection.FieldInfo FetchSingletonField(System.Type formatterType);
        }

        class StandardResolverHelper
        {
            static /*0x0*/ MessagePack.IFormatterResolver[] DefaultResolvers;

            static /*0x6fe7ff4*/ StandardResolverHelper();
        }
    }

    namespace ImmutableCollection
    {
        class ImmutableArrayFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<System.Collections.Immutable.ImmutableArray<T>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x3910ae8*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Collections.Immutable.ImmutableArray<T> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ System.Collections.Immutable.ImmutableArray<T> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ImmutableListFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.Immutable.ImmutableList.Builder<T>, System.Collections.Immutable.ImmutableList.Enumerator<T>, System.Collections.Immutable.ImmutableList<T>>
        {
            /*0x3910ae8*/ void Add(System.Collections.Immutable.ImmutableList.Builder<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814a3c*/ System.Collections.Immutable.ImmutableList<T> Complete(System.Collections.Immutable.ImmutableList.Builder<T> intermediateCollection);
            System.Collections.Immutable.ImmutableList.Builder<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ System.Collections.Immutable.ImmutableList.Enumerator<T> GetSourceEnumerator(System.Collections.Immutable.ImmutableList<T> source);
        }

        class ImmutableDictionaryFormatter<TKey, TValue> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, System.Collections.Immutable.ImmutableDictionary.Builder<TKey, TValue>, System.Collections.Immutable.ImmutableDictionary.Enumerator<TKey, TValue>, System.Collections.Immutable.ImmutableDictionary<TKey, TValue>>
        {
            /*0x3910ae8*/ void Add(System.Collections.Immutable.ImmutableDictionary.Builder<TKey, TValue> collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814a3c*/ System.Collections.Immutable.ImmutableDictionary<TKey, TValue> Complete(System.Collections.Immutable.ImmutableDictionary.Builder<TKey, TValue> intermediateCollection);
            System.Collections.Immutable.ImmutableDictionary.Builder<TKey, TValue> Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ System.Collections.Immutable.ImmutableDictionary.Enumerator<TKey, TValue> GetSourceEnumerator(System.Collections.Immutable.ImmutableDictionary<TKey, TValue> source);
        }

        class ImmutableHashSetFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.Immutable.ImmutableHashSet.Builder<T>, System.Collections.Immutable.ImmutableHashSet.Enumerator<T>, System.Collections.Immutable.ImmutableHashSet<T>>
        {
            /*0x3910ae8*/ void Add(System.Collections.Immutable.ImmutableHashSet.Builder<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814a3c*/ System.Collections.Immutable.ImmutableHashSet<T> Complete(System.Collections.Immutable.ImmutableHashSet.Builder<T> intermediateCollection);
            System.Collections.Immutable.ImmutableHashSet.Builder<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ System.Collections.Immutable.ImmutableHashSet.Enumerator<T> GetSourceEnumerator(System.Collections.Immutable.ImmutableHashSet<T> source);
        }

        class ImmutableSortedDictionaryFormatter<TKey, TValue> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, System.Collections.Immutable.ImmutableSortedDictionary.Builder<TKey, TValue>, System.Collections.Immutable.ImmutableSortedDictionary.Enumerator<TKey, TValue>, System.Collections.Immutable.ImmutableSortedDictionary<TKey, TValue>>
        {
            /*0x3910ae8*/ void Add(System.Collections.Immutable.ImmutableSortedDictionary.Builder<TKey, TValue> collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814a3c*/ System.Collections.Immutable.ImmutableSortedDictionary<TKey, TValue> Complete(System.Collections.Immutable.ImmutableSortedDictionary.Builder<TKey, TValue> intermediateCollection);
            System.Collections.Immutable.ImmutableSortedDictionary.Builder<TKey, TValue> Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ System.Collections.Immutable.ImmutableSortedDictionary.Enumerator<TKey, TValue> GetSourceEnumerator(System.Collections.Immutable.ImmutableSortedDictionary<TKey, TValue> source);
        }

        class ImmutableSortedSetFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.Immutable.ImmutableSortedSet.Builder<T>, System.Collections.Immutable.ImmutableSortedSet.Enumerator<T>, System.Collections.Immutable.ImmutableSortedSet<T>>
        {
            /*0x3910ae8*/ void Add(System.Collections.Immutable.ImmutableSortedSet.Builder<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814a3c*/ System.Collections.Immutable.ImmutableSortedSet<T> Complete(System.Collections.Immutable.ImmutableSortedSet.Builder<T> intermediateCollection);
            System.Collections.Immutable.ImmutableSortedSet.Builder<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ System.Collections.Immutable.ImmutableSortedSet.Enumerator<T> GetSourceEnumerator(System.Collections.Immutable.ImmutableSortedSet<T> source);
        }

        class ImmutableQueueFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, MessagePack.ImmutableCollection.ImmutableQueueBuilder<T>, System.Collections.Immutable.ImmutableQueue<T>>
        {
            /*0x3910ae8*/ void Add(MessagePack.ImmutableCollection.ImmutableQueueBuilder<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814a3c*/ System.Collections.Immutable.ImmutableQueue<T> Complete(MessagePack.ImmutableCollection.ImmutableQueueBuilder<T> intermediateCollection);
            MessagePack.ImmutableCollection.ImmutableQueueBuilder<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class ImmutableStackFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, T[], System.Collections.Immutable.ImmutableStack<T>>
        {
            /*0x3910ae8*/ void Add(T[] collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814a3c*/ System.Collections.Immutable.ImmutableStack<T> Complete(T[] intermediateCollection);
            T[] Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class InterfaceImmutableListFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.Immutable.ImmutableList.Builder<T>, System.Collections.Immutable.IImmutableList<T>>
        {
            /*0x3910ae8*/ void Add(System.Collections.Immutable.ImmutableList.Builder<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814a3c*/ System.Collections.Immutable.IImmutableList<T> Complete(System.Collections.Immutable.ImmutableList.Builder<T> intermediateCollection);
            System.Collections.Immutable.ImmutableList.Builder<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class InterfaceImmutableDictionaryFormatter<TKey, TValue> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, System.Collections.Immutable.ImmutableDictionary.Builder<TKey, TValue>, System.Collections.Immutable.IImmutableDictionary<TKey, TValue>>
        {
            /*0x3910ae8*/ void Add(System.Collections.Immutable.ImmutableDictionary.Builder<TKey, TValue> collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814a3c*/ System.Collections.Immutable.IImmutableDictionary<TKey, TValue> Complete(System.Collections.Immutable.ImmutableDictionary.Builder<TKey, TValue> intermediateCollection);
            System.Collections.Immutable.ImmutableDictionary.Builder<TKey, TValue> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class InterfaceImmutableSetFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.Immutable.ImmutableHashSet.Builder<T>, System.Collections.Immutable.IImmutableSet<T>>
        {
            /*0x3910ae8*/ void Add(System.Collections.Immutable.ImmutableHashSet.Builder<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814a3c*/ System.Collections.Immutable.IImmutableSet<T> Complete(System.Collections.Immutable.ImmutableHashSet.Builder<T> intermediateCollection);
            System.Collections.Immutable.ImmutableHashSet.Builder<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class InterfaceImmutableQueueFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, MessagePack.ImmutableCollection.ImmutableQueueBuilder<T>, System.Collections.Immutable.IImmutableQueue<T>>
        {
            /*0x3910ae8*/ void Add(MessagePack.ImmutableCollection.ImmutableQueueBuilder<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814a3c*/ System.Collections.Immutable.IImmutableQueue<T> Complete(MessagePack.ImmutableCollection.ImmutableQueueBuilder<T> intermediateCollection);
            MessagePack.ImmutableCollection.ImmutableQueueBuilder<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class InterfaceImmutableStackFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, T[], System.Collections.Immutable.IImmutableStack<T>>
        {
            /*0x3910ae8*/ void Add(T[] collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814a3c*/ System.Collections.Immutable.IImmutableStack<T> Complete(T[] intermediateCollection);
            T[] Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class ImmutableQueueBuilder<T>
        {
            /*0x0*/ System.Collections.Immutable.ImmutableQueue<T> <Q>k__BackingField;

            /*0x38159dc*/ ImmutableQueueBuilder();
            /*0x38148bc*/ System.Collections.Immutable.ImmutableQueue<T> get_Q();
            /*0x3816710*/ void set_Q(System.Collections.Immutable.ImmutableQueue<T> value);
            /*0x3910ae8*/ void Add(T value);
        }

        class ImmutableCollectionResolver : MessagePack.IFormatterResolver
        {
            static /*0x0*/ MessagePack.ImmutableCollection.ImmutableCollectionResolver Instance;

            static /*0x6fe8678*/ ImmutableCollectionResolver();
            /*0x6fe8670*/ ImmutableCollectionResolver();
            /*0x38148bc*/ MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static /*0x383e7a0*/ FormatterCache();
            }
        }

        class ImmutableCollectionGetFormatterHelper
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, System.Type> FormatterMap;

            static /*0x6fe8ba4*/ ImmutableCollectionGetFormatterHelper();
            static /*0x6fe86e0*/ object GetFormatter(System.Type t);
            static /*0x6fe8b74*/ object CreateInstance(System.Type genericType, System.Type[] genericTypeArguments, object[] arguments);
        }

        class ReflectionExtensions
        {
            static /*0x6fe8ab4*/ bool IsNullable(System.Reflection.TypeInfo type);
        }
    }

    namespace Formatters
    {
        class ArrayFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<T[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x38159dc*/ ArrayFormatter();
            /*0x3816920*/ void Serialize(ref MessagePack.MessagePackWriter writer, T[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814b90*/ T[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ByteMemoryFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Memory<byte>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.ByteMemoryFormatter Instance;

            static /*0x6fe92ec*/ ByteMemoryFormatter();
            /*0x6fe9138*/ ByteMemoryFormatter();
            /*0x6fe9140*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Memory<byte> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fe91d8*/ System.Memory<byte> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ByteReadOnlyMemoryFormatter : MessagePack.Formatters.IMessagePackFormatter<System.ReadOnlyMemory<byte>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.ByteReadOnlyMemoryFormatter Instance;

            static /*0x6fe94e4*/ ByteReadOnlyMemoryFormatter();
            /*0x6fe9354*/ ByteReadOnlyMemoryFormatter();
            /*0x6fe935c*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.ReadOnlyMemory<byte> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fe93d0*/ System.ReadOnlyMemory<byte> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ByteReadOnlySequenceFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Buffers.ReadOnlySequence<byte>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.ByteReadOnlySequenceFormatter Instance;

            static /*0x6fe9808*/ ByteReadOnlySequenceFormatter();
            /*0x6fe954c*/ ByteReadOnlySequenceFormatter();
            /*0x6fe9554*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Buffers.ReadOnlySequence<byte> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fe96ec*/ System.Buffers.ReadOnlySequence<byte> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ByteArraySegmentFormatter : MessagePack.Formatters.IMessagePackFormatter<System.ArraySegment<byte>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.ByteArraySegmentFormatter Instance;

            static /*0x6fe9a4c*/ ByteArraySegmentFormatter();
            /*0x6fe9870*/ ByteArraySegmentFormatter();
            /*0x6fe9878*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.ArraySegment<byte> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fe9940*/ System.ArraySegment<byte> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ByteListFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Collections.Generic.List<byte>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.ByteListFormatter Instance;
            static /*0x8*/ MessagePack.Formatters.ListFormatter<byte> InnerFormatter;

            static /*0x6fe9cec*/ ByteListFormatter();
            /*0x6fe9ce4*/ ByteListFormatter();
            /*0x6fe9ab4*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Collections.Generic.List<byte> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fe9b4c*/ System.Collections.Generic.List<byte> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class MemoryFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<System.Memory<T>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x38159dc*/ MemoryFormatter();
            /*0x3910ae8*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Memory<T> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ System.Memory<T> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ReadOnlyMemoryFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<System.ReadOnlyMemory<T>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x38159dc*/ ReadOnlyMemoryFormatter();
            /*0x3910ae8*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.ReadOnlyMemory<T> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ System.ReadOnlyMemory<T> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ReadOnlySequenceFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<System.Buffers.ReadOnlySequence<T>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x38159dc*/ ReadOnlySequenceFormatter();
            /*0x3910ae8*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Buffers.ReadOnlySequence<T> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ System.Buffers.ReadOnlySequence<T> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ArraySegmentFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<System.ArraySegment<T>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x38159dc*/ ArraySegmentFormatter();
            /*0x3910ae8*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.ArraySegment<T> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ System.ArraySegment<T> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ListFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<System.Collections.Generic.List<T>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x38159dc*/ ListFormatter();
            /*0x3816920*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Collections.Generic.List<T> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814b90*/ System.Collections.Generic.List<T> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class CollectionFormatterBase<TElement, TIntermediate, TEnumerator, TCollection> : MessagePack.Formatters.IMessagePackFormatter<TCollection>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x38159dc*/ CollectionFormatterBase();
            /*0x3910ae8*/ void Serialize(ref MessagePack.MessagePackWriter writer, TCollection value, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ TCollection Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ System.Nullable<int> GetCount(TCollection sequence);
            /*0x3910ae8*/ TEnumerator GetSourceEnumerator(TCollection source);
            /*0x3910ae8*/ TIntermediate Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ void Add(TIntermediate collection, int index, TElement value, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ TCollection Complete(TIntermediate intermediateCollection);
        }

        class CollectionFormatterBase<TElement, TIntermediate, TCollection> : MessagePack.Formatters.CollectionFormatterBase<TElement, TIntermediate, System.Collections.Generic.IEnumerator<TElement>, TCollection>
        {
            /*0x38159dc*/ CollectionFormatterBase();
            /*0x3910ae8*/ System.Collections.Generic.IEnumerator<TElement> GetSourceEnumerator(TCollection source);
        }

        class CollectionFormatterBase<TElement, TCollection> : MessagePack.Formatters.CollectionFormatterBase<TElement, TCollection, TCollection>
        {
            /*0x38159dc*/ CollectionFormatterBase();
            /*0x3910ae8*/ TCollection Complete(TCollection intermediateCollection);
        }

        class GenericCollectionFormatter<TElement, TCollection> : MessagePack.Formatters.CollectionFormatterBase<TElement, TCollection>
        {
            /*0x38159dc*/ GenericCollectionFormatter();
            /*0x3910ae8*/ TCollection Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ void Add(TCollection collection, int index, TElement value, MessagePack.MessagePackSerializerOptions options);
        }

        class GenericEnumerableFormatter<TElement, TCollection> : MessagePack.Formatters.CollectionFormatterBase<TElement, TElement[], TCollection>
        {
            /*0x38159dc*/ GenericEnumerableFormatter();
            TElement[] Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ void Add(TElement[] collection, int index, TElement value, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ TCollection Complete(TElement[] intermediateCollection);
        }

        class LinkedListFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.Generic.LinkedList<T>, System.Collections.Generic.LinkedList.Enumerator<T>, System.Collections.Generic.LinkedList<T>>
        {
            /*0x38159dc*/ LinkedListFormatter();
            /*0x3910ae8*/ void Add(System.Collections.Generic.LinkedList<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814a3c*/ System.Collections.Generic.LinkedList<T> Complete(System.Collections.Generic.LinkedList<T> intermediateCollection);
            System.Collections.Generic.LinkedList<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ System.Collections.Generic.LinkedList.Enumerator<T> GetSourceEnumerator(System.Collections.Generic.LinkedList<T> source);
        }

        class QueueFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.Generic.Queue<T>, System.Collections.Generic.Queue.Enumerator<T>, System.Collections.Generic.Queue<T>>
        {
            /*0x38159dc*/ QueueFormatter();
            /*0x3813824*/ System.Nullable<int> GetCount(System.Collections.Generic.Queue<T> sequence);
            /*0x3910ae8*/ void Add(System.Collections.Generic.Queue<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.Queue<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ System.Collections.Generic.Queue.Enumerator<T> GetSourceEnumerator(System.Collections.Generic.Queue<T> source);
            /*0x3814a3c*/ System.Collections.Generic.Queue<T> Complete(System.Collections.Generic.Queue<T> intermediateCollection);
        }

        class StackFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, T[], System.Collections.Generic.Stack.Enumerator<T>, System.Collections.Generic.Stack<T>>
        {
            /*0x38159dc*/ StackFormatter();
            /*0x3813824*/ System.Nullable<int> GetCount(System.Collections.Generic.Stack<T> sequence);
            /*0x3910ae8*/ void Add(T[] collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            T[] Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ System.Collections.Generic.Stack.Enumerator<T> GetSourceEnumerator(System.Collections.Generic.Stack<T> source);
            /*0x3814a3c*/ System.Collections.Generic.Stack<T> Complete(T[] intermediateCollection);
        }

        class HashSetFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.Generic.HashSet<T>, System.Collections.Generic.HashSet.Enumerator<T>, System.Collections.Generic.HashSet<T>>
        {
            /*0x38159dc*/ HashSetFormatter();
            /*0x3813824*/ System.Nullable<int> GetCount(System.Collections.Generic.HashSet<T> sequence);
            /*0x3910ae8*/ void Add(System.Collections.Generic.HashSet<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814a3c*/ System.Collections.Generic.HashSet<T> Complete(System.Collections.Generic.HashSet<T> intermediateCollection);
            System.Collections.Generic.HashSet<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ System.Collections.Generic.HashSet.Enumerator<T> GetSourceEnumerator(System.Collections.Generic.HashSet<T> source);
        }

        class ReadOnlyCollectionFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, T[], System.Collections.ObjectModel.ReadOnlyCollection<T>>
        {
            /*0x38159dc*/ ReadOnlyCollectionFormatter();
            /*0x3910ae8*/ void Add(T[] collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814a3c*/ System.Collections.ObjectModel.ReadOnlyCollection<T> Complete(T[] intermediateCollection);
            T[] Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class InterfaceListFormatter2<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.Generic.List<T>, System.Collections.Generic.IList<T>>
        {
            /*0x38159dc*/ InterfaceListFormatter2();
            /*0x3910ae8*/ void Add(System.Collections.Generic.List<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.List<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3814a3c*/ System.Collections.Generic.IList<T> Complete(System.Collections.Generic.List<T> intermediateCollection);
        }

        class InterfaceCollectionFormatter2<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.Generic.List<T>, System.Collections.Generic.ICollection<T>>
        {
            /*0x38159dc*/ InterfaceCollectionFormatter2();
            /*0x3910ae8*/ void Add(System.Collections.Generic.List<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.List<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3814a3c*/ System.Collections.Generic.ICollection<T> Complete(System.Collections.Generic.List<T> intermediateCollection);
        }

        class InterfaceEnumerableFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, T[], System.Collections.Generic.IEnumerable<T>>
        {
            /*0x38159dc*/ InterfaceEnumerableFormatter();
            /*0x3910ae8*/ void Add(T[] collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            T[] Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3814a3c*/ System.Collections.Generic.IEnumerable<T> Complete(T[] intermediateCollection);
        }

        class InterfaceGroupingFormatter<TKey, TElement> : MessagePack.Formatters.IMessagePackFormatter<System.Linq.IGrouping<TKey, TElement>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x38159dc*/ InterfaceGroupingFormatter();
            /*0x3816920*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Linq.IGrouping<TKey, TElement> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814b90*/ System.Linq.IGrouping<TKey, TElement> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class InterfaceLookupFormatter<TKey, TElement> : MessagePack.Formatters.CollectionFormatterBase<System.Linq.IGrouping<TKey, TElement>, System.Collections.Generic.Dictionary<TKey, System.Linq.IGrouping<TKey, TElement>>, System.Linq.ILookup<TKey, TElement>>
        {
            /*0x38159dc*/ InterfaceLookupFormatter();
            void Add(System.Collections.Generic.Dictionary<TKey, System.Linq.IGrouping<TKey, TElement>> collection, int index, System.Linq.IGrouping<TKey, TElement> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814a3c*/ System.Linq.ILookup<TKey, TElement> Complete(System.Collections.Generic.Dictionary<TKey, System.Linq.IGrouping<TKey, TElement>> intermediateCollection);
            System.Collections.Generic.Dictionary<TKey, System.Linq.IGrouping<TKey, TElement>> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class Grouping<TKey, TElement> : System.Linq.IGrouping<TKey, TElement>, System.Collections.Generic.IEnumerable<TElement>, System.Collections.IEnumerable
        {
            /*0x0*/ TKey key;
            /*0x0*/ System.Collections.Generic.IEnumerable<TElement> elements;

            /*0x3910ae8*/ Grouping(TKey key, System.Collections.Generic.IEnumerable<TElement> elements);
            /*0x3910ae8*/ TKey get_Key();
            /*0x38148bc*/ System.Collections.Generic.IEnumerator<TElement> GetEnumerator();
            /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class Lookup<TKey, TElement> : System.Linq.ILookup<TKey, TElement>, System.Collections.Generic.IEnumerable<System.Linq.IGrouping<TKey, TElement>>, System.Collections.IEnumerable
        {
            /*0x0*/ System.Collections.Generic.Dictionary<TKey, System.Linq.IGrouping<TKey, TElement>> groupings;

            /*0x3816710*/ Lookup(System.Collections.Generic.Dictionary<TKey, System.Linq.IGrouping<TKey, TElement>> groupings);
            /*0x3910ae8*/ System.Collections.Generic.IEnumerable<TElement> get_Item(TKey key);
            /*0x38148bc*/ System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey, TElement>> GetEnumerator();
            /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class NonGenericListFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<T>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x38159dc*/ NonGenericListFormatter();
            /*0x3910ae8*/ void Serialize(ref MessagePack.MessagePackWriter writer, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ T Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NonGenericInterfaceCollectionFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Collections.ICollection>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Collections.ICollection> Instance;

            static /*0x6fea608*/ NonGenericInterfaceCollectionFormatter();
            /*0x6fe9dac*/ NonGenericInterfaceCollectionFormatter();
            /*0x6fe9db4*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Collections.ICollection value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fea24c*/ System.Collections.ICollection Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NonGenericInterfaceEnumerableFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Collections.IEnumerable>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Collections.IEnumerable> Instance;

            static /*0x6feb00c*/ NonGenericInterfaceEnumerableFormatter();
            /*0x6fea670*/ NonGenericInterfaceEnumerableFormatter();
            /*0x6fea678*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Collections.IEnumerable value, MessagePack.MessagePackSerializerOptions options);
            /*0x6feac50*/ System.Collections.IEnumerable Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NonGenericInterfaceListFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Collections.IList>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Collections.IList> Instance;

            static /*0x6feb8d0*/ NonGenericInterfaceListFormatter();
            /*0x6feb074*/ NonGenericInterfaceListFormatter();
            /*0x6feb07c*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Collections.IList value, MessagePack.MessagePackSerializerOptions options);
            /*0x6feb514*/ System.Collections.IList Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NonGenericDictionaryFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<T>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x38159dc*/ NonGenericDictionaryFormatter();
            /*0x3910ae8*/ void Serialize(ref MessagePack.MessagePackWriter writer, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ T Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NonGenericInterfaceDictionaryFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Collections.IDictionary>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Collections.IDictionary> Instance;

            static /*0x6fec098*/ NonGenericInterfaceDictionaryFormatter();
            /*0x6feb938*/ NonGenericInterfaceDictionaryFormatter();
            /*0x6feb940*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Collections.IDictionary value, MessagePack.MessagePackSerializerOptions options);
            /*0x6febc64*/ System.Collections.IDictionary Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ObservableCollectionFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.ObjectModel.ObservableCollection<T>>
        {
            /*0x38159dc*/ ObservableCollectionFormatter();
            /*0x3910ae8*/ void Add(System.Collections.ObjectModel.ObservableCollection<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.ObjectModel.ObservableCollection<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class ReadOnlyObservableCollectionFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.ObjectModel.ObservableCollection<T>, System.Collections.ObjectModel.ReadOnlyObservableCollection<T>>
        {
            /*0x38159dc*/ ReadOnlyObservableCollectionFormatter();
            /*0x3910ae8*/ void Add(System.Collections.ObjectModel.ObservableCollection<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.ObjectModel.ObservableCollection<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3814a3c*/ System.Collections.ObjectModel.ReadOnlyObservableCollection<T> Complete(System.Collections.ObjectModel.ObservableCollection<T> intermediateCollection);
        }

        class InterfaceReadOnlyListFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, T[], System.Collections.Generic.IReadOnlyList<T>>
        {
            /*0x38159dc*/ InterfaceReadOnlyListFormatter();
            /*0x3910ae8*/ void Add(T[] collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            T[] Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3814a3c*/ System.Collections.Generic.IReadOnlyList<T> Complete(T[] intermediateCollection);
        }

        class InterfaceReadOnlyCollectionFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, T[], System.Collections.Generic.IReadOnlyCollection<T>>
        {
            /*0x38159dc*/ InterfaceReadOnlyCollectionFormatter();
            /*0x3910ae8*/ void Add(T[] collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            T[] Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3814a3c*/ System.Collections.Generic.IReadOnlyCollection<T> Complete(T[] intermediateCollection);
        }

        class InterfaceSetFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.Generic.HashSet<T>, System.Collections.Generic.ISet<T>>
        {
            /*0x38159dc*/ InterfaceSetFormatter();
            /*0x3910ae8*/ void Add(System.Collections.Generic.HashSet<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814a3c*/ System.Collections.Generic.ISet<T> Complete(System.Collections.Generic.HashSet<T> intermediateCollection);
            System.Collections.Generic.HashSet<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class ConcurrentBagFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.Concurrent.ConcurrentBag<T>>
        {
            /*0x38159dc*/ ConcurrentBagFormatter();
            /*0x3813824*/ System.Nullable<int> GetCount(System.Collections.Concurrent.ConcurrentBag<T> sequence);
            /*0x3910ae8*/ void Add(System.Collections.Concurrent.ConcurrentBag<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Concurrent.ConcurrentBag<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class ConcurrentQueueFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.Concurrent.ConcurrentQueue<T>>
        {
            /*0x38159dc*/ ConcurrentQueueFormatter();
            /*0x3813824*/ System.Nullable<int> GetCount(System.Collections.Concurrent.ConcurrentQueue<T> sequence);
            /*0x3910ae8*/ void Add(System.Collections.Concurrent.ConcurrentQueue<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Concurrent.ConcurrentQueue<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class ConcurrentStackFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, T[], System.Collections.Concurrent.ConcurrentStack<T>>
        {
            /*0x38159dc*/ ConcurrentStackFormatter();
            /*0x3813824*/ System.Nullable<int> GetCount(System.Collections.Concurrent.ConcurrentStack<T> sequence);
            /*0x3910ae8*/ void Add(T[] collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            T[] Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3814a3c*/ System.Collections.Concurrent.ConcurrentStack<T> Complete(T[] intermediateCollection);
        }

        class CollectionHelpers<TCollection, TEqualityComparer>
        {
            static /*0x0*/ System.Func<int, TEqualityComparer, TCollection> collectionCreator;

            static /*0x383e7a0*/ CollectionHelpers();
            static /*0x3910ae8*/ TCollection CreateHashCollection(int count, TEqualityComparer equalityComparer);
        }

        class DictionaryFormatterBase<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : MessagePack.Formatters.IMessagePackFormatter<TDictionary>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x38159dc*/ DictionaryFormatterBase();
            /*0x3910ae8*/ void Serialize(ref MessagePack.MessagePackWriter writer, TDictionary value, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ TDictionary Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ TEnumerator GetSourceEnumerator(TDictionary source);
            /*0x3910ae8*/ TIntermediate Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ void Add(TIntermediate collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ TDictionary Complete(TIntermediate intermediateCollection);
        }

        class DictionaryFormatterBase<TKey, TValue, TIntermediate, TDictionary> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, TIntermediate, System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>, TDictionary>
        {
            /*0x38159dc*/ DictionaryFormatterBase();
            /*0x3910ae8*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetSourceEnumerator(TDictionary source);
        }

        class DictionaryFormatterBase<TKey, TValue, TDictionary> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, TDictionary, TDictionary>
        {
            /*0x38159dc*/ DictionaryFormatterBase();
            /*0x3910ae8*/ TDictionary Complete(TDictionary intermediateCollection);
        }

        class DictionaryFormatter<TKey, TValue> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, System.Collections.Generic.Dictionary<TKey, TValue>, System.Collections.Generic.Dictionary.Enumerator<TKey, TValue>, System.Collections.Generic.Dictionary<TKey, TValue>>
        {
            /*0x38159dc*/ DictionaryFormatter();
            /*0x3910ae8*/ void Add(System.Collections.Generic.Dictionary<TKey, TValue> collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814a3c*/ System.Collections.Generic.Dictionary<TKey, TValue> Complete(System.Collections.Generic.Dictionary<TKey, TValue> intermediateCollection);
            System.Collections.Generic.Dictionary<TKey, TValue> Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ System.Collections.Generic.Dictionary.Enumerator<TKey, TValue> GetSourceEnumerator(System.Collections.Generic.Dictionary<TKey, TValue> source);
        }

        class GenericDictionaryFormatter<TKey, TValue, TDictionary> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, TDictionary>
        {
            /*0x38159dc*/ GenericDictionaryFormatter();
            /*0x3910ae8*/ void Add(TDictionary collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ TDictionary Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class GenericReadOnlyDictionaryFormatter<TKey, TValue, TDictionary> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, System.Collections.Generic.Dictionary<TKey, TValue>, TDictionary>
        {
            /*0x38159dc*/ GenericReadOnlyDictionaryFormatter();
            /*0x3910ae8*/ void Add(System.Collections.Generic.Dictionary<TKey, TValue> collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.Dictionary<TKey, TValue> Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ TDictionary Complete(System.Collections.Generic.Dictionary<TKey, TValue> intermediateCollection);
        }

        class InterfaceDictionaryFormatter<TKey, TValue> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, System.Collections.Generic.Dictionary<TKey, TValue>, System.Collections.Generic.IDictionary<TKey, TValue>>
        {
            /*0x38159dc*/ InterfaceDictionaryFormatter();
            /*0x3910ae8*/ void Add(System.Collections.Generic.Dictionary<TKey, TValue> collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.Dictionary<TKey, TValue> Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3814a3c*/ System.Collections.Generic.IDictionary<TKey, TValue> Complete(System.Collections.Generic.Dictionary<TKey, TValue> intermediateCollection);
        }

        class SortedListFormatter<TKey, TValue> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, System.Collections.Generic.SortedList<TKey, TValue>>
        {
            /*0x38159dc*/ SortedListFormatter();
            /*0x3910ae8*/ void Add(System.Collections.Generic.SortedList<TKey, TValue> collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.SortedList<TKey, TValue> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class SortedDictionaryFormatter<TKey, TValue> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, System.Collections.Generic.SortedDictionary<TKey, TValue>, System.Collections.Generic.SortedDictionary.Enumerator<TKey, TValue>, System.Collections.Generic.SortedDictionary<TKey, TValue>>
        {
            /*0x38159dc*/ SortedDictionaryFormatter();
            /*0x3910ae8*/ void Add(System.Collections.Generic.SortedDictionary<TKey, TValue> collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814a3c*/ System.Collections.Generic.SortedDictionary<TKey, TValue> Complete(System.Collections.Generic.SortedDictionary<TKey, TValue> intermediateCollection);
            System.Collections.Generic.SortedDictionary<TKey, TValue> Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ System.Collections.Generic.SortedDictionary.Enumerator<TKey, TValue> GetSourceEnumerator(System.Collections.Generic.SortedDictionary<TKey, TValue> source);
        }

        class ReadOnlyDictionaryFormatter<TKey, TValue> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, System.Collections.Generic.Dictionary<TKey, TValue>, System.Collections.ObjectModel.ReadOnlyDictionary<TKey, TValue>>
        {
            /*0x38159dc*/ ReadOnlyDictionaryFormatter();
            /*0x3910ae8*/ void Add(System.Collections.Generic.Dictionary<TKey, TValue> collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814a3c*/ System.Collections.ObjectModel.ReadOnlyDictionary<TKey, TValue> Complete(System.Collections.Generic.Dictionary<TKey, TValue> intermediateCollection);
            System.Collections.Generic.Dictionary<TKey, TValue> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class InterfaceReadOnlyDictionaryFormatter<TKey, TValue> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, System.Collections.Generic.Dictionary<TKey, TValue>, System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>>
        {
            /*0x38159dc*/ InterfaceReadOnlyDictionaryFormatter();
            /*0x3910ae8*/ void Add(System.Collections.Generic.Dictionary<TKey, TValue> collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814a3c*/ System.Collections.Generic.IReadOnlyDictionary<TKey, TValue> Complete(System.Collections.Generic.Dictionary<TKey, TValue> intermediateCollection);
            System.Collections.Generic.Dictionary<TKey, TValue> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class ConcurrentDictionaryFormatter<TKey, TValue> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue>>
        {
            /*0x38159dc*/ ConcurrentDictionaryFormatter();
            /*0x3910ae8*/ void Add(System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue> collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class DynamicObjectTypeFallbackFormatter : MessagePack.Formatters.IMessagePackFormatter<object>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<object> Instance;
            static /*0x8*/ MessagePack.Internal.ThreadsafeTypeKeyHashTable<MessagePack.Formatters.DynamicObjectTypeFallbackFormatter.SerializeMethod> SerializerDelegates;

            static /*0x6fecc50*/ DynamicObjectTypeFallbackFormatter();
            /*0x6fec100*/ DynamicObjectTypeFallbackFormatter();
            /*0x6fec108*/ void Serialize(ref MessagePack.MessagePackWriter writer, object value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fecb6c*/ object Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);

            class SerializeMethod : System.MulticastDelegate
            {
                /*0x6fecd18*/ SerializeMethod(object object, nint method);
                /*0x6fece24*/ void Invoke(object dynamicFormatter, ref MessagePack.MessagePackWriter writer, object value, MessagePack.MessagePackSerializerOptions options);
            }
        }

        class EnumAsStringFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<T>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x0*/ bool ignoreCase;
            /*0x0*/ System.Collections.Generic.IReadOnlyDictionary<string, T> nameValueMapping;
            /*0x0*/ System.Collections.Generic.IReadOnlyDictionary<T, string> valueNameMapping;
            /*0x0*/ System.Collections.Generic.IReadOnlyDictionary<string, string> clrToSerializationName;
            /*0x0*/ System.Collections.Generic.IReadOnlyDictionary<string, string> serializationToClrName;
            /*0x0*/ bool isFlags;

            static /*0x38395d4*/ string Translate(string items, System.Collections.Generic.IReadOnlyDictionary<string, string> mapping);
            /*0x38159dc*/ EnumAsStringFormatter();
            /*0x3815cc4*/ EnumAsStringFormatter(bool ignoreCase);
            /*0x3910ae8*/ void Serialize(ref MessagePack.MessagePackWriter writer, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ T Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
            /*0x3814a3c*/ string GetClrNames(string serializedNames);
            /*0x3814a3c*/ string GetSerializedNames(string clrNames);
        }

        class ExpandoObjectFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Dynamic.ExpandoObject>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Dynamic.ExpandoObject> Instance;

            static /*0x6fed760*/ ExpandoObjectFormatter();
            /*0x6fece38*/ ExpandoObjectFormatter();
            /*0x6fece40*/ System.Dynamic.ExpandoObject Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
            /*0x6fed234*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Dynamic.ExpandoObject value, MessagePack.MessagePackSerializerOptions options);
        }

        class GenericEnumFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<T>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x0*/ MessagePack.Formatters.GenericEnumFormatter.EnumSerialize<T> serializer;
            /*0x0*/ MessagePack.Formatters.GenericEnumFormatter.EnumDeserialize<T> deserializer;

            /*0x38159dc*/ GenericEnumFormatter();
            /*0x3910ae8*/ void Serialize(ref MessagePack.MessagePackWriter writer, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ T Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);

            class EnumSerialize<T> : System.MulticastDelegate
            {
                EnumSerialize(object object, nint method);
                /*0x3816810*/ void Invoke(ref MessagePack.MessagePackWriter writer, ref T value);
            }

            class EnumDeserialize<T> : System.MulticastDelegate
            {
                EnumDeserialize(object object, nint method);
                /*0x3910ae8*/ T Invoke(ref MessagePack.MessagePackReader reader);
            }

            class <>c<T>
            {
                static /*0x0*/ MessagePack.Formatters.GenericEnumFormatter.<>c<T> <>9;
                static /*0x0*/ MessagePack.Formatters.GenericEnumFormatter.EnumSerialize<T> <>9__4_0;
                static /*0x0*/ MessagePack.Formatters.GenericEnumFormatter.EnumDeserialize<T> <>9__4_1;
                static /*0x0*/ MessagePack.Formatters.GenericEnumFormatter.EnumSerialize<T> <>9__4_2;
                static /*0x0*/ MessagePack.Formatters.GenericEnumFormatter.EnumDeserialize<T> <>9__4_3;
                static /*0x0*/ MessagePack.Formatters.GenericEnumFormatter.EnumSerialize<T> <>9__4_4;
                static /*0x0*/ MessagePack.Formatters.GenericEnumFormatter.EnumDeserialize<T> <>9__4_5;
                static /*0x0*/ MessagePack.Formatters.GenericEnumFormatter.EnumSerialize<T> <>9__4_6;
                static /*0x0*/ MessagePack.Formatters.GenericEnumFormatter.EnumDeserialize<T> <>9__4_7;
                static /*0x0*/ MessagePack.Formatters.GenericEnumFormatter.EnumSerialize<T> <>9__4_8;
                static /*0x0*/ MessagePack.Formatters.GenericEnumFormatter.EnumDeserialize<T> <>9__4_9;
                static /*0x0*/ MessagePack.Formatters.GenericEnumFormatter.EnumSerialize<T> <>9__4_10;
                static /*0x0*/ MessagePack.Formatters.GenericEnumFormatter.EnumDeserialize<T> <>9__4_11;
                static /*0x0*/ MessagePack.Formatters.GenericEnumFormatter.EnumSerialize<T> <>9__4_12;
                static /*0x0*/ MessagePack.Formatters.GenericEnumFormatter.EnumDeserialize<T> <>9__4_13;
                static /*0x0*/ MessagePack.Formatters.GenericEnumFormatter.EnumSerialize<T> <>9__4_14;
                static /*0x0*/ MessagePack.Formatters.GenericEnumFormatter.EnumDeserialize<T> <>9__4_15;

                static /*0x383e7a0*/ <>c();
                /*0x38159dc*/ <>c();
                /*0x3816810*/ void <.ctor>b__4_0(ref MessagePack.MessagePackWriter writer, ref T value);
                /*0x3910ae8*/ T <.ctor>b__4_1(ref MessagePack.MessagePackReader reader);
                /*0x3816810*/ void <.ctor>b__4_2(ref MessagePack.MessagePackWriter writer, ref T value);
                /*0x3910ae8*/ T <.ctor>b__4_3(ref MessagePack.MessagePackReader reader);
                /*0x3816810*/ void <.ctor>b__4_4(ref MessagePack.MessagePackWriter writer, ref T value);
                /*0x3910ae8*/ T <.ctor>b__4_5(ref MessagePack.MessagePackReader reader);
                /*0x3816810*/ void <.ctor>b__4_6(ref MessagePack.MessagePackWriter writer, ref T value);
                /*0x3910ae8*/ T <.ctor>b__4_7(ref MessagePack.MessagePackReader reader);
                /*0x3816810*/ void <.ctor>b__4_8(ref MessagePack.MessagePackWriter writer, ref T value);
                /*0x3910ae8*/ T <.ctor>b__4_9(ref MessagePack.MessagePackReader reader);
                /*0x3816810*/ void <.ctor>b__4_10(ref MessagePack.MessagePackWriter writer, ref T value);
                /*0x3910ae8*/ T <.ctor>b__4_11(ref MessagePack.MessagePackReader reader);
                /*0x3816810*/ void <.ctor>b__4_12(ref MessagePack.MessagePackWriter writer, ref T value);
                /*0x3910ae8*/ T <.ctor>b__4_13(ref MessagePack.MessagePackReader reader);
                /*0x3816810*/ void <.ctor>b__4_14(ref MessagePack.MessagePackWriter writer, ref T value);
                /*0x3910ae8*/ T <.ctor>b__4_15(ref MessagePack.MessagePackReader reader);
            }
        }

        interface IMessagePackFormatter
        {
        }

        interface IMessagePackFormatter<T> : MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x3910ae8*/ void Serialize(ref MessagePack.MessagePackWriter writer, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ T Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class TwoDimensionalArrayFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<T[, ]>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x38159dc*/ TwoDimensionalArrayFormatter();
            /*0x3816920*/ void Serialize(ref MessagePack.MessagePackWriter writer, T[,] value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814b90*/ T[,] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ThreeDimensionalArrayFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<T[, , ]>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x38159dc*/ ThreeDimensionalArrayFormatter();
            /*0x3816920*/ void Serialize(ref MessagePack.MessagePackWriter writer, T[,,] value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814b90*/ T[,,] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class FourDimensionalArrayFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<T[, , , ]>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x38159dc*/ FourDimensionalArrayFormatter();
            /*0x3816920*/ void Serialize(ref MessagePack.MessagePackWriter writer, T[,,,] value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814b90*/ T[,,,] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NilFormatter : MessagePack.Formatters.IMessagePackFormatter<MessagePack.Nil>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<MessagePack.Nil> Instance;

            static /*0x6fed7f8*/ NilFormatter();
            /*0x6fed7c8*/ NilFormatter();
            /*0x6fed7d0*/ void Serialize(ref MessagePack.MessagePackWriter writer, MessagePack.Nil value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fed7dc*/ MessagePack.Nil Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableNilFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<MessagePack.Nil>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Nullable<MessagePack.Nil>> Instance;

            static /*0x6fed8e0*/ NullableNilFormatter();
            /*0x6fed860*/ NullableNilFormatter();
            /*0x6fed868*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<MessagePack.Nil> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fed874*/ System.Nullable<MessagePack.Nil> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<T>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x38159dc*/ NullableFormatter();
            /*0x3910ae8*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<T> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ System.Nullable<T> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class StaticNullableFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<T>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> underlyingFormatter;

            /*0x3816710*/ StaticNullableFormatter(MessagePack.Formatters.IMessagePackFormatter<T> underlyingFormatter);
            /*0x3910ae8*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<T> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ System.Nullable<T> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class Int16Formatter : MessagePack.Formatters.IMessagePackFormatter<short>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.Int16Formatter Instance;

            static /*0x6fed96c*/ Int16Formatter();
            /*0x6fed948*/ Int16Formatter();
            /*0x6fed950*/ void Serialize(ref MessagePack.MessagePackWriter writer, short value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fed960*/ short Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableInt16Formatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<short>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableInt16Formatter Instance;

            static /*0x6fedb34*/ NullableInt16Formatter();
            /*0x6fed9d4*/ NullableInt16Formatter();
            /*0x6fed9dc*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<short> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6feda74*/ System.Nullable<short> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class Int16ArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Int16[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.Int16ArrayFormatter Instance;

            static /*0x6fede00*/ Int16ArrayFormatter();
            /*0x6fedb9c*/ Int16ArrayFormatter();
            /*0x6fedba4*/ void Serialize(ref MessagePack.MessagePackWriter writer, short[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fedc60*/ short[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class Int32Formatter : MessagePack.Formatters.IMessagePackFormatter<int>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.Int32Formatter Instance;

            static /*0x6fede8c*/ Int32Formatter();
            /*0x6fede68*/ Int32Formatter();
            /*0x6fede70*/ void Serialize(ref MessagePack.MessagePackWriter writer, int value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fede80*/ int Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableInt32Formatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<int>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableInt32Formatter Instance;

            static /*0x6fee054*/ NullableInt32Formatter();
            /*0x6fedef4*/ NullableInt32Formatter();
            /*0x6fedefc*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<int> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fedf94*/ System.Nullable<int> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class Int32ArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Int32[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.Int32ArrayFormatter Instance;

            static /*0x6fee320*/ Int32ArrayFormatter();
            /*0x6fee0bc*/ Int32ArrayFormatter();
            /*0x6fee0c4*/ void Serialize(ref MessagePack.MessagePackWriter writer, int[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fee180*/ int[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class Int64Formatter : MessagePack.Formatters.IMessagePackFormatter<long>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.Int64Formatter Instance;

            static /*0x6fee3ac*/ Int64Formatter();
            /*0x6fee388*/ Int64Formatter();
            /*0x6fee390*/ void Serialize(ref MessagePack.MessagePackWriter writer, long value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fee3a0*/ long Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableInt64Formatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<long>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableInt64Formatter Instance;

            static /*0x6fee578*/ NullableInt64Formatter();
            /*0x6fee414*/ NullableInt64Formatter();
            /*0x6fee41c*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<long> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fee4b4*/ System.Nullable<long> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class Int64ArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Int64[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.Int64ArrayFormatter Instance;

            static /*0x6fee844*/ Int64ArrayFormatter();
            /*0x6fee5e0*/ Int64ArrayFormatter();
            /*0x6fee5e8*/ void Serialize(ref MessagePack.MessagePackWriter writer, long[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fee6a4*/ long[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class UInt16Formatter : MessagePack.Formatters.IMessagePackFormatter<ushort>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.UInt16Formatter Instance;

            static /*0x6fee8d0*/ UInt16Formatter();
            /*0x6fee8ac*/ UInt16Formatter();
            /*0x6fee8b4*/ void Serialize(ref MessagePack.MessagePackWriter writer, ushort value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fee8c4*/ ushort Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableUInt16Formatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<ushort>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableUInt16Formatter Instance;

            static /*0x6feea98*/ NullableUInt16Formatter();
            /*0x6fee938*/ NullableUInt16Formatter();
            /*0x6fee940*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<ushort> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fee9d8*/ System.Nullable<ushort> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class UInt16ArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.UInt16[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.UInt16ArrayFormatter Instance;

            static /*0x6feed64*/ UInt16ArrayFormatter();
            /*0x6feeb00*/ UInt16ArrayFormatter();
            /*0x6feeb08*/ void Serialize(ref MessagePack.MessagePackWriter writer, ushort[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x6feebc4*/ ushort[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class UInt32Formatter : MessagePack.Formatters.IMessagePackFormatter<uint>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.UInt32Formatter Instance;

            static /*0x6feedf0*/ UInt32Formatter();
            /*0x6feedcc*/ UInt32Formatter();
            /*0x6feedd4*/ void Serialize(ref MessagePack.MessagePackWriter writer, uint value, MessagePack.MessagePackSerializerOptions options);
            /*0x6feede4*/ uint Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableUInt32Formatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<uint>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableUInt32Formatter Instance;

            static /*0x6feefb8*/ NullableUInt32Formatter();
            /*0x6feee58*/ NullableUInt32Formatter();
            /*0x6feee60*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<uint> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6feeef8*/ System.Nullable<uint> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class UInt32ArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.UInt32[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.UInt32ArrayFormatter Instance;

            static /*0x6fef284*/ UInt32ArrayFormatter();
            /*0x6fef020*/ UInt32ArrayFormatter();
            /*0x6fef028*/ void Serialize(ref MessagePack.MessagePackWriter writer, uint[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fef0e4*/ uint[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class UInt64Formatter : MessagePack.Formatters.IMessagePackFormatter<ulong>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.UInt64Formatter Instance;

            static /*0x6fef310*/ UInt64Formatter();
            /*0x6fef2ec*/ UInt64Formatter();
            /*0x6fef2f4*/ void Serialize(ref MessagePack.MessagePackWriter writer, ulong value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fef304*/ ulong Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableUInt64Formatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<ulong>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableUInt64Formatter Instance;

            static /*0x6fef4dc*/ NullableUInt64Formatter();
            /*0x6fef378*/ NullableUInt64Formatter();
            /*0x6fef380*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<ulong> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fef418*/ System.Nullable<ulong> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class UInt64ArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.UInt64[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.UInt64ArrayFormatter Instance;

            static /*0x6fef7a8*/ UInt64ArrayFormatter();
            /*0x6fef544*/ UInt64ArrayFormatter();
            /*0x6fef54c*/ void Serialize(ref MessagePack.MessagePackWriter writer, ulong[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fef608*/ ulong[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class SingleFormatter : MessagePack.Formatters.IMessagePackFormatter<float>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.SingleFormatter Instance;

            static /*0x6fef830*/ SingleFormatter();
            /*0x6fef810*/ SingleFormatter();
            /*0x6fef818*/ void Serialize(ref MessagePack.MessagePackWriter writer, float value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fef824*/ float Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableSingleFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<float>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableSingleFormatter Instance;

            static /*0x6fef9f0*/ NullableSingleFormatter();
            /*0x6fef898*/ NullableSingleFormatter();
            /*0x6fef8a0*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<float> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fef934*/ System.Nullable<float> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class SingleArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Single[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.SingleArrayFormatter Instance;

            static /*0x6fefcbc*/ SingleArrayFormatter();
            /*0x6fefa58*/ SingleArrayFormatter();
            /*0x6fefa60*/ void Serialize(ref MessagePack.MessagePackWriter writer, float[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fefb1c*/ float[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class DoubleFormatter : MessagePack.Formatters.IMessagePackFormatter<double>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.DoubleFormatter Instance;

            static /*0x6fefd44*/ DoubleFormatter();
            /*0x6fefd24*/ DoubleFormatter();
            /*0x6fefd2c*/ void Serialize(ref MessagePack.MessagePackWriter writer, double value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fefd38*/ double Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableDoubleFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<double>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableDoubleFormatter Instance;

            static /*0x6feff08*/ NullableDoubleFormatter();
            /*0x6fefdac*/ NullableDoubleFormatter();
            /*0x6fefdb4*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<double> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fefe48*/ System.Nullable<double> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class DoubleArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Double[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.DoubleArrayFormatter Instance;

            static /*0x6ff01d4*/ DoubleArrayFormatter();
            /*0x6feff70*/ DoubleArrayFormatter();
            /*0x6feff78*/ void Serialize(ref MessagePack.MessagePackWriter writer, double[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff0034*/ double[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class BooleanFormatter : MessagePack.Formatters.IMessagePackFormatter<bool>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.BooleanFormatter Instance;

            static /*0x6ff0264*/ BooleanFormatter();
            /*0x6ff023c*/ BooleanFormatter();
            /*0x6ff0244*/ void Serialize(ref MessagePack.MessagePackWriter writer, bool value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff0258*/ bool Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableBooleanFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<bool>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableBooleanFormatter Instance;

            static /*0x6ff042c*/ NullableBooleanFormatter();
            /*0x6ff02cc*/ NullableBooleanFormatter();
            /*0x6ff02d4*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<bool> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff036c*/ System.Nullable<bool> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class BooleanArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Boolean[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.BooleanArrayFormatter Instance;

            static /*0x6ff0968*/ BooleanArrayFormatter();
            /*0x6ff0494*/ BooleanArrayFormatter();
            /*0x6ff049c*/ void Serialize(ref MessagePack.MessagePackWriter writer, bool[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff0558*/ bool[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ByteFormatter : MessagePack.Formatters.IMessagePackFormatter<byte>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.ByteFormatter Instance;

            static /*0x6ff09f4*/ ByteFormatter();
            /*0x6ff09d0*/ ByteFormatter();
            /*0x6ff09d8*/ void Serialize(ref MessagePack.MessagePackWriter writer, byte value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff09e8*/ byte Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableByteFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<byte>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableByteFormatter Instance;

            static /*0x6ff0bbc*/ NullableByteFormatter();
            /*0x6ff0a5c*/ NullableByteFormatter();
            /*0x6ff0a64*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<byte> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff0afc*/ System.Nullable<byte> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class SByteFormatter : MessagePack.Formatters.IMessagePackFormatter<sbyte>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.SByteFormatter Instance;

            static /*0x6ff0c48*/ SByteFormatter();
            /*0x6ff0c24*/ SByteFormatter();
            /*0x6ff0c2c*/ void Serialize(ref MessagePack.MessagePackWriter writer, sbyte value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff0c3c*/ sbyte Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableSByteFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<sbyte>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableSByteFormatter Instance;

            static /*0x6ff0e10*/ NullableSByteFormatter();
            /*0x6ff0cb0*/ NullableSByteFormatter();
            /*0x6ff0cb8*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<sbyte> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff0d50*/ System.Nullable<sbyte> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class SByteArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.SByte[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.SByteArrayFormatter Instance;

            static /*0x6ff10dc*/ SByteArrayFormatter();
            /*0x6ff0e78*/ SByteArrayFormatter();
            /*0x6ff0e80*/ void Serialize(ref MessagePack.MessagePackWriter writer, sbyte[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff0f3c*/ sbyte[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class CharFormatter : MessagePack.Formatters.IMessagePackFormatter<char>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.CharFormatter Instance;

            static /*0x6ff1168*/ CharFormatter();
            /*0x6ff1144*/ CharFormatter();
            /*0x6ff114c*/ void Serialize(ref MessagePack.MessagePackWriter writer, char value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff115c*/ char Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableCharFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<char>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableCharFormatter Instance;

            static /*0x6ff1330*/ NullableCharFormatter();
            /*0x6ff11d0*/ NullableCharFormatter();
            /*0x6ff11d8*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<char> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff1270*/ System.Nullable<char> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class CharArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Char[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.CharArrayFormatter Instance;

            static /*0x6ff15fc*/ CharArrayFormatter();
            /*0x6ff1398*/ CharArrayFormatter();
            /*0x6ff13a0*/ void Serialize(ref MessagePack.MessagePackWriter writer, char[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff145c*/ char[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class DateTimeFormatter : MessagePack.Formatters.IMessagePackFormatter<System.DateTime>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.DateTimeFormatter Instance;

            static /*0x6ff1688*/ DateTimeFormatter();
            /*0x6ff1664*/ DateTimeFormatter();
            /*0x6ff166c*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.DateTime value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff167c*/ System.DateTime Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableDateTimeFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<System.DateTime>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableDateTimeFormatter Instance;

            static /*0x6ff1854*/ NullableDateTimeFormatter();
            /*0x6ff16f0*/ NullableDateTimeFormatter();
            /*0x6ff16f8*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<System.DateTime> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff1790*/ System.Nullable<System.DateTime> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class DateTimeArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.DateTime[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.DateTimeArrayFormatter Instance;

            static /*0x6ff1b18*/ DateTimeArrayFormatter();
            /*0x6ff18bc*/ DateTimeArrayFormatter();
            /*0x6ff18c4*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.DateTime[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff1978*/ System.DateTime[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class PrimitiveObjectFormatter : MessagePack.Formatters.IMessagePackFormatter<object>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<object> Instance;
            static /*0x8*/ System.Collections.Generic.Dictionary<System.Type, int> TypeToJumpCode;

            static /*0x6ff33a4*/ PrimitiveObjectFormatter();
            static /*0x6ff1b88*/ bool IsSupportedType(System.Type type, System.Reflection.TypeInfo typeInfo, object value);
            /*0x6ff1b80*/ PrimitiveObjectFormatter();
            /*0x6ff1c94*/ void Serialize(ref MessagePack.MessagePackWriter writer, object value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff2788*/ object Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff3158*/ object DeserializeMap(ref MessagePack.MessagePackReader reader, int length, MessagePack.MessagePackSerializerOptions options);
        }

        class ByteArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Byte[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.ByteArrayFormatter Instance;

            static /*0x6ff3a20*/ ByteArrayFormatter();
            /*0x6ff36e0*/ ByteArrayFormatter();
            /*0x6ff36e8*/ void Serialize(ref MessagePack.MessagePackWriter writer, byte[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff36f8*/ byte[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableStringFormatter : MessagePack.Formatters.IMessagePackFormatter<string>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableStringFormatter Instance;

            static /*0x6ff3aac*/ NullableStringFormatter();
            /*0x6ff3a88*/ NullableStringFormatter();
            /*0x6ff3a90*/ void Serialize(ref MessagePack.MessagePackWriter writer, string value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff3aa0*/ string Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableStringArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.String[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableStringArrayFormatter Instance;

            static /*0x6ff3d84*/ NullableStringArrayFormatter();
            /*0x6ff3b14*/ NullableStringArrayFormatter();
            /*0x6ff3b1c*/ void Serialize(ref MessagePack.MessagePackWriter writer, string[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff3bd0*/ string[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class DecimalFormatter : MessagePack.Formatters.IMessagePackFormatter<decimal>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.DecimalFormatter Instance;

            static /*0x6ff469c*/ DecimalFormatter();
            /*0x6ff3dec*/ DecimalFormatter();
            /*0x6ff3df4*/ void Serialize(ref MessagePack.MessagePackWriter writer, decimal value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff3ff8*/ decimal Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class TimeSpanFormatter : MessagePack.Formatters.IMessagePackFormatter<System.TimeSpan>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.TimeSpan> Instance;

            static /*0x6ff4780*/ TimeSpanFormatter();
            /*0x6ff4704*/ TimeSpanFormatter();
            /*0x6ff470c*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.TimeSpan value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff4774*/ System.TimeSpan Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class DateTimeOffsetFormatter : MessagePack.Formatters.IMessagePackFormatter<System.DateTimeOffset>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.DateTimeOffset> Instance;

            static /*0x6ff4a68*/ DateTimeOffsetFormatter();
            /*0x6ff47e8*/ DateTimeOffsetFormatter();
            /*0x6ff47f0*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.DateTimeOffset value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff4928*/ System.DateTimeOffset Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class GuidFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Guid>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Guid> Instance;

            static /*0x6ff4e60*/ GuidFormatter();
            /*0x6ff4ad0*/ GuidFormatter();
            /*0x6ff4ad8*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Guid value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff4bd4*/ System.Guid Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class UriFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Uri>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Uri> Instance;

            static /*0x6ff4fec*/ UriFormatter();
            /*0x6ff4ec8*/ UriFormatter();
            /*0x6ff4ed0*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Uri value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff4f78*/ System.Uri Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class VersionFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Version>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Version> Instance;

            static /*0x6ff5134*/ VersionFormatter();
            /*0x6ff5054*/ VersionFormatter();
            /*0x6ff505c*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Version value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff50c4*/ System.Version Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class KeyValuePairFormatter<TKey, TValue> : MessagePack.Formatters.IMessagePackFormatter<System.Collections.Generic.KeyValuePair<TKey, TValue>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x38159dc*/ KeyValuePairFormatter();
            /*0x3910ae8*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Collections.Generic.KeyValuePair<TKey, TValue> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ System.Collections.Generic.KeyValuePair<TKey, TValue> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class StringBuilderFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Text.StringBuilder>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Text.StringBuilder> Instance;

            static /*0x6ff52ac*/ StringBuilderFormatter();
            /*0x6ff519c*/ StringBuilderFormatter();
            /*0x6ff51a4*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Text.StringBuilder value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff51e4*/ System.Text.StringBuilder Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class BitArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Collections.BitArray>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Collections.BitArray> Instance;

            static /*0x6ff54e4*/ BitArrayFormatter();
            /*0x6ff5314*/ BitArrayFormatter();
            /*0x6ff531c*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Collections.BitArray value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff53c8*/ System.Collections.BitArray Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class BigIntegerFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Numerics.BigInteger>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Numerics.BigInteger> Instance;

            static /*0x6ff56e8*/ BigIntegerFormatter();
            /*0x6ff554c*/ BigIntegerFormatter();
            /*0x6ff5554*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Numerics.BigInteger value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff55cc*/ System.Numerics.BigInteger Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ComplexFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Numerics.Complex>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Numerics.Complex> Instance;

            static /*0x6ff5898*/ ComplexFormatter();
            /*0x6ff5750*/ ComplexFormatter();
            /*0x6ff5758*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Numerics.Complex value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff57e4*/ System.Numerics.Complex Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class Vector2Formatter : MessagePack.Formatters.IMessagePackFormatter<System.Numerics.Vector2>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Numerics.Vector2> Instance;

            static /*0x6ff5a00*/ Vector2Formatter();
            /*0x6ff5900*/ Vector2Formatter();
            /*0x6ff5908*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Numerics.Vector2 value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff5954*/ System.Numerics.Vector2 Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class Vector3Formatter : MessagePack.Formatters.IMessagePackFormatter<System.Numerics.Vector3>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Numerics.Vector3> Instance;

            static /*0x6ff5ba8*/ Vector3Formatter();
            /*0x6ff5a68*/ Vector3Formatter();
            /*0x6ff5a70*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Numerics.Vector3 value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff5ad8*/ System.Numerics.Vector3 Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class Vector4Formatter : MessagePack.Formatters.IMessagePackFormatter<System.Numerics.Vector4>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Numerics.Vector4> Instance;

            static /*0x6ff5d7c*/ Vector4Formatter();
            /*0x6ff5c10*/ Vector4Formatter();
            /*0x6ff5c18*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Numerics.Vector4 value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff5c94*/ System.Numerics.Vector4 Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class QuaternionFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Numerics.Quaternion>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Numerics.Quaternion> Instance;

            static /*0x6ff5f50*/ QuaternionFormatter();
            /*0x6ff5de4*/ QuaternionFormatter();
            /*0x6ff5dec*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Numerics.Quaternion value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff5e68*/ System.Numerics.Quaternion Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class Matrix3x2Formatter : MessagePack.Formatters.IMessagePackFormatter<System.Numerics.Matrix3x2>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Numerics.Matrix3x2> Instance;

            static /*0x6ff615c*/ Matrix3x2Formatter();
            /*0x6ff5fb8*/ Matrix3x2Formatter();
            /*0x6ff5fc0*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Numerics.Matrix3x2 value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff6048*/ System.Numerics.Matrix3x2 Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class Matrix4x4Formatter : MessagePack.Formatters.IMessagePackFormatter<System.Numerics.Matrix4x4>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Numerics.Matrix4x4> Instance;

            static /*0x6ff64dc*/ Matrix4x4Formatter();
            /*0x6ff61c4*/ Matrix4x4Formatter();
            /*0x6ff61cc*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Numerics.Matrix4x4 value, MessagePack.MessagePackSerializerOptions options);
            /*0x6ff62f4*/ System.Numerics.Matrix4x4 Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class LazyFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<System.Lazy<T>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x38159dc*/ LazyFormatter();
            /*0x3816920*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Lazy<T> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814b90*/ System.Lazy<T> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);

            class <>c__DisplayClass1_0<T>
            {
                /*0x0*/ T v;

                /*0x38159dc*/ <>c__DisplayClass1_0();
                /*0x3910ae8*/ T <Deserialize>b__0();
            }
        }

        class TypeFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<T>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Instance;

            static /*0x383e7a0*/ TypeFormatter();
            /*0x38159dc*/ TypeFormatter();
            /*0x3910ae8*/ void Serialize(ref MessagePack.MessagePackWriter writer, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ T Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class TupleFormatter<T1> : MessagePack.Formatters.IMessagePackFormatter<System.Tuple<T1>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x38159dc*/ TupleFormatter();
            /*0x3816920*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Tuple<T1> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814b90*/ System.Tuple<T1> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class TupleFormatter<T1, T2> : MessagePack.Formatters.IMessagePackFormatter<System.Tuple<T1, T2>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x38159dc*/ TupleFormatter();
            /*0x3816920*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Tuple<T1, T2> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814b90*/ System.Tuple<T1, T2> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class TupleFormatter<T1, T2, T3> : MessagePack.Formatters.IMessagePackFormatter<System.Tuple<T1, T2, T3>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x38159dc*/ TupleFormatter();
            /*0x3816920*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Tuple<T1, T2, T3> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814b90*/ System.Tuple<T1, T2, T3> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class TupleFormatter<T1, T2, T3, T4> : MessagePack.Formatters.IMessagePackFormatter<System.Tuple<T1, T2, T3, T4>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x38159dc*/ TupleFormatter();
            /*0x3816920*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Tuple<T1, T2, T3, T4> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814b90*/ System.Tuple<T1, T2, T3, T4> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class TupleFormatter<T1, T2, T3, T4, T5> : MessagePack.Formatters.IMessagePackFormatter<System.Tuple<T1, T2, T3, T4, T5>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x38159dc*/ TupleFormatter();
            /*0x3816920*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Tuple<T1, T2, T3, T4, T5> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814b90*/ System.Tuple<T1, T2, T3, T4, T5> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class TupleFormatter<T1, T2, T3, T4, T5, T6> : MessagePack.Formatters.IMessagePackFormatter<System.Tuple<T1, T2, T3, T4, T5, T6>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x38159dc*/ TupleFormatter();
            /*0x3816920*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Tuple<T1, T2, T3, T4, T5, T6> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814b90*/ System.Tuple<T1, T2, T3, T4, T5, T6> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class TupleFormatter<T1, T2, T3, T4, T5, T6, T7> : MessagePack.Formatters.IMessagePackFormatter<System.Tuple<T1, T2, T3, T4, T5, T6, T7>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x38159dc*/ TupleFormatter();
            /*0x3816920*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Tuple<T1, T2, T3, T4, T5, T6, T7> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814b90*/ System.Tuple<T1, T2, T3, T4, T5, T6, T7> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class TupleFormatter<T1, T2, T3, T4, T5, T6, T7, TRest> : MessagePack.Formatters.IMessagePackFormatter<System.Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x38159dc*/ TupleFormatter();
            /*0x3816920*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3814b90*/ System.Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ValueTupleFormatter<T1> : MessagePack.Formatters.IMessagePackFormatter<System.ValueTuple<T1>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x38159dc*/ ValueTupleFormatter();
            /*0x3910ae8*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.ValueTuple<T1> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ System.ValueTuple<T1> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ValueTupleFormatter<T1, T2> : MessagePack.Formatters.IMessagePackFormatter<System.ValueTuple<T1, T2>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x38159dc*/ ValueTupleFormatter();
            /*0x3910ae8*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.ValueTuple<T1, T2> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ System.ValueTuple<T1, T2> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ValueTupleFormatter<T1, T2, T3> : MessagePack.Formatters.IMessagePackFormatter<System.ValueTuple<T1, T2, T3>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x38159dc*/ ValueTupleFormatter();
            /*0x3910ae8*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.ValueTuple<T1, T2, T3> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ System.ValueTuple<T1, T2, T3> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ValueTupleFormatter<T1, T2, T3, T4> : MessagePack.Formatters.IMessagePackFormatter<System.ValueTuple<T1, T2, T3, T4>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x38159dc*/ ValueTupleFormatter();
            /*0x3910ae8*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.ValueTuple<T1, T2, T3, T4> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ System.ValueTuple<T1, T2, T3, T4> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ValueTupleFormatter<T1, T2, T3, T4, T5> : MessagePack.Formatters.IMessagePackFormatter<System.ValueTuple<T1, T2, T3, T4, T5>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x38159dc*/ ValueTupleFormatter();
            /*0x3910ae8*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.ValueTuple<T1, T2, T3, T4, T5> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ System.ValueTuple<T1, T2, T3, T4, T5> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ValueTupleFormatter<T1, T2, T3, T4, T5, T6> : MessagePack.Formatters.IMessagePackFormatter<System.ValueTuple<T1, T2, T3, T4, T5, T6>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x38159dc*/ ValueTupleFormatter();
            /*0x3910ae8*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.ValueTuple<T1, T2, T3, T4, T5, T6> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ System.ValueTuple<T1, T2, T3, T4, T5, T6> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ValueTupleFormatter<T1, T2, T3, T4, T5, T6, T7> : MessagePack.Formatters.IMessagePackFormatter<System.ValueTuple<T1, T2, T3, T4, T5, T6, T7>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x38159dc*/ ValueTupleFormatter();
            /*0x3910ae8*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.ValueTuple<T1, T2, T3, T4, T5, T6, T7> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ System.ValueTuple<T1, T2, T3, T4, T5, T6, T7> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ValueTupleFormatter<T1, T2, T3, T4, T5, T6, T7, TRest> : MessagePack.Formatters.IMessagePackFormatter<System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x38159dc*/ ValueTupleFormatter();
            /*0x3910ae8*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3910ae8*/ System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class CompilerFeatureRequiredAttribute : System.Attribute
            {
                /*0x10*/ string <FeatureName>k__BackingField;

                /*0x6ff6544*/ CompilerFeatureRequiredAttribute(string featureName);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 168A802D5149EF4DCF86752E588ECEE8C3D853455914AB3446460A7E786B04E1;
    static /*0x80*/ <PrivateImplementationDetails> 2F8AB27C794DB6AFCC4F795F819F1D1C0D90FE357D0584CB0C38710838013AA5;
    static /*0x180*/ <PrivateImplementationDetails> 4604FE57A895837058497526E671C041E16CA431D8C8E37A1CF5794965941172;
    static /*0x1a0*/ <PrivateImplementationDetails> 5271CD636451FF809DBF4FEFAFDF6256A9D6DE9AAB898594763168674B72C75D;
    static /*0x2a0*/ <PrivateImplementationDetails> 7712F30D902A66E2BF63A8A5A0087D0D1060078C101ACCCD0D70FA11C00AC4D5;
    static /*0x3a0*/ <PrivateImplementationDetails> E8E6013856D199B70A4BCF85D8CE19A1C43799B6B21133E9FB4D0D9FFA2B8142;

    struct __StaticArrayInitTypeSize=32
    {
    }

    struct __StaticArrayInitTypeSize=128
    {
    }

    struct __StaticArrayInitTypeSize=256
    {
    }
}
