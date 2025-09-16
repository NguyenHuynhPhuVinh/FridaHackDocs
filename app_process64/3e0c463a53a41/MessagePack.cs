class <Module>
{
}

class <>f__AnonymousType0<<Label>j__TPar, <Attr>j__TPar>
{
    /*0x0*/ <Label> <Label>i__Field;
    /*0x0*/ <Attr> <Attr>i__Field;

    /*0x3907c14*/ <>f__AnonymousType0(<Label> Label, <Attr> Attr);
    /*0x3907c14*/ <Label> get_Label();
    /*0x3907c14*/ <Attr> get_Attr();
    /*0x380b2f0*/ bool Equals(object value);
    /*0x380b6a0*/ int GetHashCode();
    /*0x380b9e8*/ string ToString();
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x6f8cd18*/ EmbeddedAttribute();
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
                /*0x6f8cd20*/ IsUnmanagedAttribute();
            }

            class NullableAttribute : System.Attribute
            {
                /*0x10*/ byte[] NullableFlags;

                /*0x6f8cd28*/ NullableAttribute(byte );
                /*0x6f8cdb0*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x6f8cde0*/ NullableContextAttribute(byte );
            }

            class NativeIntegerAttribute : System.Attribute
            {
                /*0x10*/ bool[] TransformFlags;

                /*0x6f8ce08*/ NativeIntegerAttribute();
            }

            class ScopedRefAttribute : System.Attribute
            {
                /*0x6f8ce88*/ ScopedRefAttribute();
            }

            class RefSafetyRulesAttribute : System.Attribute
            {
                /*0x10*/ int Version;

                /*0x6f8ce90*/ RefSafetyRulesAttribute(int );
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

            static /*0x38358cc*/ Sequence();
            static /*0x3907c14*/ System.Buffers.ReadOnlySequence<T> op_Implicit(Nerdbank.Streams.Sequence<T> sequence);
            /*0x380d83c*/ Sequence(System.Buffers.MemoryPool<T> memoryPool);
            /*0x380d83c*/ Sequence(System.Buffers.ArrayPool<T> arrayPool);
            /*0x380b6a0*/ int get_MinimumSpanLength();
            /*0x380cffc*/ void set_MinimumSpanLength(int value);
            /*0x380b128*/ bool get_AutoIncreaseMinimumSpanLength();
            /*0x3907c14*/ System.Buffers.ReadOnlySequence<T> get_AsReadOnlySequence();
            /*0x380b828*/ long get_Length();
            /*0x3907c14*/ void AdvanceTo(System.SequencePosition position);
            /*0x380cffc*/ void Advance(int count);
            /*0x3907c14*/ System.Memory<T> GetMemory(int sizeHint);
            /*0x3907c14*/ System.Span<T> GetSpan(int sizeHint);
            /*0x380cb08*/ void Dispose();
            /*0x380cb08*/ void Reset();
            /*0x380ba90*/ Nerdbank.Streams.Sequence.SequenceSegment<T> GetSegment(int sizeHint);
            /*0x380d83c*/ void Append(Nerdbank.Streams.Sequence.SequenceSegment<T> segment);
            /*0x380bb68*/ Nerdbank.Streams.Sequence.SequenceSegment<T> RecycleAndGetNext(Nerdbank.Streams.Sequence.SequenceSegment<T> segment);
            /*0x380cb08*/ void ConsiderMinimumSizeIncrease();

            class SequenceSegment<T> : System.Buffers.ReadOnlySequenceSegment<T>
            {
                static /*0x0*/ Nerdbank.Streams.Sequence.SequenceSegment<T> Empty;
                static /*0x0*/ bool MayContainReferences;
                /*0x0*/ T[] array;
                /*0x0*/ int <Start>k__BackingField;
                /*0x0*/ int <End>k__BackingField;
                /*0x0*/ System.Buffers.IMemoryOwner<T> <MemoryOwner>k__BackingField;

                static /*0x38358cc*/ SequenceSegment();
                /*0x380cb08*/ SequenceSegment();
                /*0x380b6a0*/ int get_Start();
                /*0x380cffc*/ void set_Start(int value);
                /*0x380b6a0*/ int get_End();
                /*0x380cffc*/ void set_End(int value);
                /*0x3907c14*/ System.Memory<T> get_RemainingMemory();
                /*0x3907c14*/ System.Span<T> get_RemainingSpan();
                /*0x380b9e8*/ System.Buffers.IMemoryOwner<T> get_MemoryOwner();
                /*0x380d83c*/ void set_MemoryOwner(System.Buffers.IMemoryOwner<T> value);
                /*0x3907c14*/ System.Memory<T> get_AvailableMemory();
                /*0x380b6a0*/ int get_Length();
                /*0x380b6a0*/ int get_WritableBytes();
                /*0x380b9e8*/ Nerdbank.Streams.Sequence.SequenceSegment<T> get_Next();
                /*0x380d83c*/ void set_Next(Nerdbank.Streams.Sequence.SequenceSegment<T> value);
                /*0x380b128*/ bool get_IsForeignMemory();
                /*0x380d83c*/ void Assign(System.Buffers.IMemoryOwner<T> memoryOwner);
                /*0x380d83c*/ void Assign(T[] array);
                /*0x380d83c*/ void ResetMemory(System.Buffers.ArrayPool<T> arrayPool);
                /*0x380d83c*/ void SetNext(Nerdbank.Streams.Sequence.SequenceSegment<T> segment);
                /*0x380cffc*/ void Advance(int count);
                /*0x380cffc*/ void AdvanceTo(int offset);
                /*0x380d0e4*/ void ClearReferences(int startIndex, int length);
            }
        }

        class Requires
        {
            static /*0x6f8ceb8*/ void Range(bool condition, string parameterName, string message);
            static /*0x6f8ced0*/ System.Exception FailRange(string parameterName, string message);
            static /*0x3907c14*/ T NotNull<T>(T value, string parameterName);
            static /*0x6f8cf40*/ void Argument(bool condition, string parameterName, string message);
        }

        class Verify
        {
            static /*0x6f8cf94*/ void Operation(bool condition, string message);
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

        /*0x6f8cfe0*/ BufferWriter(System.Buffers.IBufferWriter<byte> output);
        /*0x6f8d0f8*/ BufferWriter(MessagePack.SequencePool sequencePool, byte[] array);
        /*0x6f8d268*/ System.Span<byte> get_Span();
        /*0x6f8d274*/ MessagePack.SequencePool.Rental get_SequenceRental();
        /*0x6f8d280*/ System.Span<byte> GetSpan(int sizeHint);
        /*0x6f8d2d8*/ ref byte GetPointer(int sizeHint);
        /*0x6f8d414*/ void Commit();
        /*0x6f8d660*/ void Advance(int count);
        /*0x6f8d71c*/ void Write(System.ReadOnlySpan<byte> source);
        /*0x6f8da90*/ void Ensure(int count);
        /*0x6f8dbc4*/ bool TryGetUncommittedSpan(ref System.ReadOnlySpan<byte> span);
        /*0x6f8daec*/ void EnsureMore(int count);
        /*0x6f8d868*/ void WriteMultiBuffer(System.ReadOnlySpan<byte> source);
        /*0x6f8d524*/ void MigrateToSequence();
    }

    struct ExtensionHeader : System.IEquatable<MessagePack.ExtensionHeader>
    {
        /*0x10*/ sbyte <TypeCode>k__BackingField;
        /*0x14*/ uint <Length>k__BackingField;

        /*0x6f8df64*/ ExtensionHeader(sbyte typeCode, uint length);
        /*0x6f8df70*/ ExtensionHeader(sbyte typeCode, int length);
        /*0x6f8df44*/ sbyte get_TypeCode();
        /*0x6f8df4c*/ void set_TypeCode(sbyte value);
        /*0x6f8df54*/ uint get_Length();
        /*0x6f8df5c*/ void set_Length(uint value);
        /*0x6f8dfc0*/ bool Equals(MessagePack.ExtensionHeader other);
    }

    struct ExtensionResult
    {
        /*0x10*/ sbyte <TypeCode>k__BackingField;
        /*0x18*/ System.Buffers.ReadOnlySequence<byte> <Data>k__BackingField;

        /*0x6f8dfe8*/ ExtensionResult(sbyte typeCode, System.Buffers.ReadOnlySequence<byte> data);
        /*0x6f8e00c*/ void set_TypeCode(sbyte value);
        /*0x6f8e014*/ System.Buffers.ReadOnlySequence<byte> get_Data();
        /*0x6f8e028*/ void set_Data(System.Buffers.ReadOnlySequence<byte> value);
    }

    interface IFormatterResolver
    {
        /*0x380b9e8*/ MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();
    }

    class FormatterResolverExtensions
    {
        static /*0x0*/ MessagePack.Internal.ThreadsafeTypeKeyHashTable<System.Func<MessagePack.IFormatterResolver, MessagePack.Formatters.IMessagePackFormatter>> FormatterGetters;
        static /*0x8*/ System.Reflection.MethodInfo GetFormatterRuntimeMethod;

        static /*0x6f8e500*/ FormatterResolverExtensions();
        static /*0x382eaf0*/ MessagePack.Formatters.IMessagePackFormatter<T> GetFormatterWithVerify<T>(MessagePack.IFormatterResolver resolver);
        static /*0x6f8e048*/ void Throw(System.TypeInitializationException ex);
        static /*0x6f8e080*/ void Throw(System.Type t, MessagePack.IFormatterResolver resolver);
        static /*0x6f8e134*/ object GetFormatterDynamic(MessagePack.IFormatterResolver resolver, System.Type type);
        static /*0x6f8e480*/ object GetFormatterDynamicWithVerify(MessagePack.IFormatterResolver resolver, System.Type type);
    }

    class FormatterNotRegisteredException : MessagePack.MessagePackSerializationException
    {
        /*0x6f8e130*/ FormatterNotRegisteredException(string message);
        /*0x6f8e6d0*/ FormatterNotRegisteredException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
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

        static /*0x6f8e754*/ MessagePackCode();
        static /*0x6f8f730*/ MessagePack.MessagePackType ToMessagePackType(byte code);
        static /*0x6f8f7ac*/ string ToFormatName(byte code);
        static /*0x6f8f828*/ bool IsPositiveFixInt(byte code);
        static /*0x6f8f834*/ bool IsNegativeFixInt(byte code);
        static /*0x6f8f844*/ bool IsFixMap(byte code);
        static /*0x6f8f8b4*/ bool IsFixArray(byte code);
        static /*0x6f8f910*/ bool IsFixStr(byte code);
        static /*0x6f8f8a0*/ bool CheckBitmask(byte code, byte bitmask, byte targetValue);
    }

    enum MessagePackCompression
    {
        None = 0,
        Lz4Block = 1,
        Lz4BlockArray = 2,
    }

    class MessagePackCompressionExtensions
    {
        static /*0x6f8f96c*/ bool IsCompression(MessagePack.MessagePackCompression compression);
    }

    class MessagePackEventSource : System.Diagnostics.Tracing.EventSource
    {
        static /*0x0*/ MessagePack.MessagePackEventSource Instance;

        static /*0x6f8f99c*/ MessagePackEventSource();
        /*0x6f8f978*/ MessagePackEventSource();
        /*0x6f8f980*/ void FormatterDynamicallyGeneratedStart();
        /*0x6f8f98c*/ void FormatterDynamicallyGeneratedStop(string dataType);

        class Tasks
        {
            static System.Diagnostics.Tracing.EventTask FormatterDynamicallyGenerated = 1;
        }
    }

    class MessagePackEventSourceExtensions
    {
        static /*0x6f8fa04*/ void FormatterDynamicallyGeneratedStop(MessagePack.MessagePackEventSource source, System.Type dataType);
    }

    class MessagePackPrimitives
    {
        static /*0x6f8fa70*/ MessagePack.MessagePackPrimitives.DecodeResult TryReadArrayHeader(System.ReadOnlySpan<byte> source, ref uint count, ref int tokenSize);
        static /*0x6f8fd00*/ MessagePack.MessagePackPrimitives.DecodeResult TryReadMapHeader(System.ReadOnlySpan<byte> source, ref uint count, ref int tokenSize);
        static /*0x6f8fe64*/ MessagePack.MessagePackPrimitives.DecodeResult TryReadDateTime(System.ReadOnlySpan<byte> source, ref System.DateTime value, ref int tokenSize);
        static /*0x6f90124*/ MessagePack.MessagePackPrimitives.DecodeResult TryReadDateTime(System.ReadOnlySpan<byte> source, MessagePack.ExtensionHeader header, ref System.DateTime value, ref int tokenSize);
        static /*0x6f8ff68*/ MessagePack.MessagePackPrimitives.DecodeResult TryReadExtensionHeader(System.ReadOnlySpan<byte> source, ref MessagePack.ExtensionHeader extensionHeader, ref int tokenSize);
        static /*0x6f9050c*/ MessagePack.MessagePackPrimitives.DecodeResult TryReadBinHeader(System.ReadOnlySpan<byte> source, ref uint length, ref int tokenSize);
        static /*0x6f90680*/ MessagePack.MessagePackPrimitives.DecodeResult TryReadStringHeader(System.ReadOnlySpan<byte> source, ref uint length, ref int tokenSize);
        static /*0x6f8fbd4*/ bool TryReadBigEndian(System.ReadOnlySpan<byte> source, ref ushort value);
        static /*0x6f9081c*/ bool TryReadBigEndian(System.ReadOnlySpan<byte> source, ref short value);
        static /*0x6f8fc6c*/ bool TryReadBigEndian(System.ReadOnlySpan<byte> source, ref uint value);
        static /*0x6f90850*/ bool TryReadBigEndian(System.ReadOnlySpan<byte> source, ref int value);
        static /*0x6f90444*/ bool TryReadBigEndian(System.ReadOnlySpan<byte> source, ref ulong value);
        static /*0x6f904d8*/ bool TryReadBigEndian(System.ReadOnlySpan<byte> source, ref long value);
        static /*0x6f903f0*/ void AssumesTrue(bool condition);
        static /*0x6f90884*/ MessagePack.MessagePackPrimitives.DecodeResult TryReadByte(System.ReadOnlySpan<byte> source, ref byte value, ref int tokenSize);
        static /*0x6f909fc*/ MessagePack.MessagePackPrimitives.DecodeResult TryReadUInt16(System.ReadOnlySpan<byte> source, ref ushort value, ref int tokenSize);
        static /*0x6f90b74*/ MessagePack.MessagePackPrimitives.DecodeResult TryReadUInt32(System.ReadOnlySpan<byte> source, ref uint value, ref int tokenSize);
        static /*0x6f90cec*/ MessagePack.MessagePackPrimitives.DecodeResult TryReadUInt64(System.ReadOnlySpan<byte> source, ref ulong value, ref int tokenSize);
        static /*0x6f90e3c*/ MessagePack.MessagePackPrimitives.DecodeResult TryReadSByte(System.ReadOnlySpan<byte> source, ref sbyte value, ref int tokenSize);
        static /*0x6f90fb4*/ MessagePack.MessagePackPrimitives.DecodeResult TryReadInt16(System.ReadOnlySpan<byte> source, ref short value, ref int tokenSize);
        static /*0x6f9112c*/ MessagePack.MessagePackPrimitives.DecodeResult TryReadInt32(System.ReadOnlySpan<byte> source, ref int value, ref int tokenSize);
        static /*0x6f912a8*/ MessagePack.MessagePackPrimitives.DecodeResult TryReadInt64(System.ReadOnlySpan<byte> source, ref long value, ref int tokenSize);
        static /*0x6f913f8*/ MessagePack.MessagePackPrimitives.DecodeResult TryReadSingle(System.ReadOnlySpan<byte> source, ref float value, ref int tokenSize);
        static /*0x6f915a4*/ MessagePack.MessagePackPrimitives.DecodeResult TryReadDouble(System.ReadOnlySpan<byte> source, ref double value, ref int tokenSize);
        static /*0x6f91750*/ bool TryWriteNil(System.Span<byte> destination, ref int bytesWritten);
        static /*0x6f917b8*/ bool TryWriteArrayHeader(System.Span<byte> destination, uint count, ref int bytesWritten);
        static /*0x6f9191c*/ bool TryWriteMapHeader(System.Span<byte> destination, uint count, ref int bytesWritten);
        static /*0x6f91a38*/ bool TryWrite(System.Span<byte> destination, sbyte value, ref int bytesWritten);
        static /*0x6f91c9c*/ bool TryWrite(System.Span<byte> destination, short value, ref int bytesWritten);
        static /*0x6f91f24*/ bool TryWrite(System.Span<byte> destination, int value, ref int bytesWritten);
        static /*0x6f921d0*/ bool TryWrite(System.Span<byte> destination, long value, ref int bytesWritten);
        static /*0x6f91c2c*/ bool TryWriteInt8(System.Span<byte> destination, sbyte value, ref int bytesWritten);
        static /*0x6f91e84*/ bool TryWriteInt16(System.Span<byte> destination, short value, ref int bytesWritten);
        static /*0x6f92134*/ bool TryWriteInt32(System.Span<byte> destination, int value, ref int bytesWritten);
        static /*0x6f9241c*/ bool TryWriteInt64(System.Span<byte> destination, long value, ref int bytesWritten);
        static /*0x6f91b14*/ bool TryWrite(System.Span<byte> destination, byte value, ref int bytesWritten);
        static /*0x6f91da4*/ bool TryWrite(System.Span<byte> destination, ushort value, ref int bytesWritten);
        static /*0x6f92040*/ bool TryWrite(System.Span<byte> destination, uint value, ref int bytesWritten);
        static /*0x6f921dc*/ bool TryWrite(System.Span<byte> destination, ulong value, ref int bytesWritten);
        static /*0x6f9252c*/ bool TryWriteUInt8(System.Span<byte> destination, byte value, ref int bytesWritten);
        static /*0x6f9259c*/ bool TryWriteUInt16(System.Span<byte> destination, ushort value, ref int bytesWritten);
        static /*0x6f9263c*/ bool TryWriteUInt32(System.Span<byte> destination, uint value, ref int bytesWritten);
        static /*0x6f927b8*/ bool TryWriteUInt64(System.Span<byte> destination, ulong value, ref int bytesWritten);
        static /*0x6f9287c*/ bool TryWrite(System.Span<byte> destination, float value, ref int bytesWritten);
        static /*0x6f92924*/ bool TryWrite(System.Span<byte> destination, double value, ref int bytesWritten);
        static /*0x6f929d0*/ bool TryWrite(System.Span<byte> destination, bool value, ref int bytesWritten);
        static /*0x6f92a44*/ bool TryWrite(System.Span<byte> destination, char value, ref int bytesWritten);
        static /*0x6f92a48*/ bool TryWrite(System.Span<byte> destination, System.DateTime value, ref int bytesWritten);
        static /*0x6f92c9c*/ bool TryWriteBinHeader(System.Span<byte> destination, uint length, ref int bytesWritten);
        static /*0x6f92dbc*/ bool TryWriteStringHeader(System.Span<byte> destination, uint byteCount, ref int bytesWritten);
        static /*0x6f92f00*/ bool TryWriteExtensionFormatHeader(System.Span<byte> destination, MessagePack.ExtensionHeader extensionHeader, ref int bytesWritten);
        static /*0x6f924c4*/ bool TryWriteFixIntUnsafe(System.Span<byte> destination, byte value, ref int bytesWritten);
        static /*0x6f91bc4*/ bool TryWriteNegativeFixIntUnsafe(System.Span<byte> destination, sbyte value, ref int bytesWritten);
        static /*0x6f93104*/ System.Exception ThrowUnreachable();
        static /*0x6f918d8*/ void WriteBigEndian(System.Span<byte> destination, ushort value);
        static /*0x6f918fc*/ void WriteBigEndian(System.Span<byte> destination, uint value);
        static /*0x6f9285c*/ void WriteBigEndian(System.Span<byte> destination, ulong value);
        static /*0x6f923d8*/ void WriteBigEndian(System.Span<byte> destination, short value);
        static /*0x6f923fc*/ void WriteBigEndian(System.Span<byte> destination, int value);
        static /*0x6f924c0*/ void WriteBigEndian(System.Span<byte> destination, long value);
        static /*0x6f9226c*/ bool <TryWrite>g__SlowPath|35_0(System.Span<byte> destination, long value, ref int bytesWritten);
        static /*0x6f926d8*/ bool <TryWrite>g__SlowPath|43_0(System.Span<byte> destination, ulong value, ref int bytesWritten);

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

            static /*0x6f93150*/ Decoders();

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

                static /*0x6f93cdc*/ ReadInt64Invalid();
                /*0x6f93cc0*/ ReadInt64Invalid();
                /*0x6f93cc8*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref long value, ref int tokenSize);
            }

            class ReadInt64FixInt : MessagePack.MessagePackPrimitives.Decoders.IReadInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadInt64FixInt Instance;

                static /*0x6f93d74*/ ReadInt64FixInt();
                /*0x6f93d44*/ ReadInt64FixInt();
                /*0x6f93d4c*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref long value, ref int tokenSize);
            }

            class ReadInt64NegativeFixInt : MessagePack.MessagePackPrimitives.Decoders.IReadInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadInt64NegativeFixInt Instance;

                static /*0x6f93e0c*/ ReadInt64NegativeFixInt();
                /*0x6f93ddc*/ ReadInt64NegativeFixInt();
                /*0x6f93de4*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref long value, ref int tokenSize);
            }

            class ReadInt64UInt8 : MessagePack.MessagePackPrimitives.Decoders.IReadInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadInt64UInt8 Instance;

                static /*0x6f93ef0*/ ReadInt64UInt8();
                /*0x6f93e74*/ ReadInt64UInt8();
                /*0x6f93e7c*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref long value, ref int tokenSize);
            }

            class ReadInt64UInt16 : MessagePack.MessagePackPrimitives.Decoders.IReadInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadInt64UInt16 Instance;

                static /*0x6f94010*/ ReadInt64UInt16();
                /*0x6f93f58*/ ReadInt64UInt16();
                /*0x6f93f60*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref long value, ref int tokenSize);
            }

            class ReadInt64UInt32 : MessagePack.MessagePackPrimitives.Decoders.IReadInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadInt64UInt32 Instance;

                static /*0x6f94130*/ ReadInt64UInt32();
                /*0x6f94078*/ ReadInt64UInt32();
                /*0x6f94080*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref long value, ref int tokenSize);
            }

            class ReadInt64UInt64 : MessagePack.MessagePackPrimitives.Decoders.IReadInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadInt64UInt64 Instance;

                static /*0x6f94278*/ ReadInt64UInt64();
                /*0x6f94198*/ ReadInt64UInt64();
                /*0x6f941a0*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref long value, ref int tokenSize);
            }

            class ReadInt64Int8 : MessagePack.MessagePackPrimitives.Decoders.IReadInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadInt64Int8 Instance;

                static /*0x6f9435c*/ ReadInt64Int8();
                /*0x6f942e0*/ ReadInt64Int8();
                /*0x6f942e8*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref long value, ref int tokenSize);
            }

            class ReadInt64Int16 : MessagePack.MessagePackPrimitives.Decoders.IReadInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadInt64Int16 Instance;

                static /*0x6f9447c*/ ReadInt64Int16();
                /*0x6f943c4*/ ReadInt64Int16();
                /*0x6f943cc*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref long value, ref int tokenSize);
            }

            class ReadInt64Int32 : MessagePack.MessagePackPrimitives.Decoders.IReadInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadInt64Int32 Instance;

                static /*0x6f9459c*/ ReadInt64Int32();
                /*0x6f944e4*/ ReadInt64Int32();
                /*0x6f944ec*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref long value, ref int tokenSize);
            }

            class ReadInt64Int64 : MessagePack.MessagePackPrimitives.Decoders.IReadInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadInt64Int64 Instance;

                static /*0x6f946bc*/ ReadInt64Int64();
                /*0x6f94604*/ ReadInt64Int64();
                /*0x6f9460c*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref long value, ref int tokenSize);
            }

            class ReadUInt64Invalid : MessagePack.MessagePackPrimitives.Decoders.IReadUInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadUInt64Invalid Instance;

                static /*0x6f94740*/ ReadUInt64Invalid();
                /*0x6f94724*/ ReadUInt64Invalid();
                /*0x6f9472c*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref ulong value, ref int tokenSize);
            }

            class ReadUInt64FixInt : MessagePack.MessagePackPrimitives.Decoders.IReadUInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadUInt64FixInt Instance;

                static /*0x6f947d8*/ ReadUInt64FixInt();
                /*0x6f947a8*/ ReadUInt64FixInt();
                /*0x6f947b0*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref ulong value, ref int tokenSize);
            }

            class ReadUInt64NegativeFixInt : MessagePack.MessagePackPrimitives.Decoders.IReadUInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadUInt64NegativeFixInt Instance;

                static /*0x6f948b0*/ ReadUInt64NegativeFixInt();
                /*0x6f94840*/ ReadUInt64NegativeFixInt();
                /*0x6f94848*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref ulong value, ref int tokenSize);
            }

            class ReadUInt64UInt8 : MessagePack.MessagePackPrimitives.Decoders.IReadUInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadUInt64UInt8 Instance;

                static /*0x6f94994*/ ReadUInt64UInt8();
                /*0x6f94918*/ ReadUInt64UInt8();
                /*0x6f94920*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref ulong value, ref int tokenSize);
            }

            class ReadUInt64UInt16 : MessagePack.MessagePackPrimitives.Decoders.IReadUInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadUInt64UInt16 Instance;

                static /*0x6f94ab4*/ ReadUInt64UInt16();
                /*0x6f949fc*/ ReadUInt64UInt16();
                /*0x6f94a04*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref ulong value, ref int tokenSize);
            }

            class ReadUInt64UInt32 : MessagePack.MessagePackPrimitives.Decoders.IReadUInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadUInt64UInt32 Instance;

                static /*0x6f94bd4*/ ReadUInt64UInt32();
                /*0x6f94b1c*/ ReadUInt64UInt32();
                /*0x6f94b24*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref ulong value, ref int tokenSize);
            }

            class ReadUInt64UInt64 : MessagePack.MessagePackPrimitives.Decoders.IReadUInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadUInt64UInt64 Instance;

                static /*0x6f94cf4*/ ReadUInt64UInt64();
                /*0x6f94c3c*/ ReadUInt64UInt64();
                /*0x6f94c44*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref ulong value, ref int tokenSize);
            }

            class ReadUInt64Int8 : MessagePack.MessagePackPrimitives.Decoders.IReadUInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadUInt64Int8 Instance;

                static /*0x6f94de4*/ ReadUInt64Int8();
                /*0x6f94d5c*/ ReadUInt64Int8();
                /*0x6f94d64*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref ulong value, ref int tokenSize);
            }

            class ReadUInt64Int16 : MessagePack.MessagePackPrimitives.Decoders.IReadUInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadUInt64Int16 Instance;

                static /*0x6f94f10*/ ReadUInt64Int16();
                /*0x6f94e4c*/ ReadUInt64Int16();
                /*0x6f94e54*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref ulong value, ref int tokenSize);
            }

            class ReadUInt64Int32 : MessagePack.MessagePackPrimitives.Decoders.IReadUInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadUInt64Int32 Instance;

                static /*0x6f9503c*/ ReadUInt64Int32();
                /*0x6f94f78*/ ReadUInt64Int32();
                /*0x6f94f80*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref ulong value, ref int tokenSize);
            }

            class ReadUInt64Int64 : MessagePack.MessagePackPrimitives.Decoders.IReadUInt64
            {
                static /*0x0*/ MessagePack.MessagePackPrimitives.Decoders.ReadUInt64Int64 Instance;

                static /*0x6f95168*/ ReadUInt64Int64();
                /*0x6f950a4*/ ReadUInt64Int64();
                /*0x6f950ac*/ MessagePack.MessagePackPrimitives.DecodeResult Read(System.ReadOnlySpan<byte> source, ref ulong value, ref int tokenSize);
            }
        }
    }

    struct MessagePackReader
    {
        /*0x10*/ MessagePack.SequenceReader<byte> reader;
        /*0x90*/ System.Threading.CancellationToken <CancellationToken>k__BackingField;
        /*0x98*/ int <Depth>k__BackingField;

        static /*0x6f9899c*/ System.IO.EndOfStreamException ThrowNotEnoughBytesException();
        static /*0x6f95ec4*/ System.IO.EndOfStreamException ThrowNotEnoughBytesException(System.Exception innerException);
        static /*0x6f95b58*/ System.Exception ThrowInvalidCode(byte code);
        static /*0x6f95540*/ void ThrowInsufficientBufferUnless(bool condition);
        static /*0x6f989d4*/ System.Exception ThrowUnreachable();
        static /*0x6f96200*/ bool <TryReadArrayHeader>g__SlowPath|34_0(ref MessagePack.MessagePackReader self, MessagePack.MessagePackPrimitives.DecodeResult readResult, ref int count, ref int tokenSize);
        static /*0x6f96654*/ bool <TryReadMapHeader>g__SlowPath|36_0(ref MessagePack.MessagePackReader self, MessagePack.MessagePackPrimitives.DecodeResult readResult, ref int count, ref int tokenSize);
        static /*0x6f96b78*/ float <ReadSingle>g__SlowPath|39_0(ref MessagePack.MessagePackReader self, MessagePack.MessagePackPrimitives.DecodeResult readResult, float value, ref int tokenSize);
        static /*0x6f96ec8*/ double <ReadDouble>g__SlowPath|40_0(ref MessagePack.MessagePackReader self, MessagePack.MessagePackPrimitives.DecodeResult readResult, double value, ref int tokenSize);
        static /*0x6f97218*/ System.DateTime <ReadDateTime>g__SlowPath|41_0(ref MessagePack.MessagePackReader self, MessagePack.MessagePackPrimitives.DecodeResult readResult, System.DateTime value, ref int tokenSize);
        static /*0x6f97574*/ System.DateTime <ReadDateTime>g__SlowPath|42_0(ref MessagePack.MessagePackReader self, MessagePack.ExtensionHeader header, MessagePack.MessagePackPrimitives.DecodeResult readResult, System.DateTime value, ref int tokenSize);
        static /*0x6f98550*/ bool <TryReadExtensionFormatHeader>g__SlowPath|48_0(ref MessagePack.MessagePackReader self, MessagePack.MessagePackPrimitives.DecodeResult readResult, ref MessagePack.ExtensionHeader extensionHeader, ref int tokenSize);
        static /*0x6f98a20*/ bool <TryGetBytesLength>g__SlowPath|56_0(ref MessagePack.MessagePackReader self, MessagePack.MessagePackPrimitives.DecodeResult readResult, bool usingBinaryHeader, ref uint length, ref int tokenSize);
        static /*0x6f98e38*/ bool <TryGetStringLengthInBytes>g__SlowPath|57_0(ref MessagePack.MessagePackReader self, MessagePack.MessagePackPrimitives.DecodeResult readResult, ref uint length, ref int tokenSize);
        static /*0x6f99214*/ byte <ReadByte>g__SlowPath|63_0(ref MessagePack.MessagePackReader self, MessagePack.MessagePackPrimitives.DecodeResult readResult, byte value, ref int tokenSize);
        static /*0x6f9943c*/ ushort <ReadUInt16>g__SlowPath|64_0(ref MessagePack.MessagePackReader self, MessagePack.MessagePackPrimitives.DecodeResult readResult, ushort value, ref int tokenSize);
        static /*0x6f99780*/ uint <ReadUInt32>g__SlowPath|65_0(ref MessagePack.MessagePackReader self, MessagePack.MessagePackPrimitives.DecodeResult readResult, uint value, ref int tokenSize);
        static /*0x6f99ac8*/ ulong <ReadUInt64>g__SlowPath|66_0(ref MessagePack.MessagePackReader self, MessagePack.MessagePackPrimitives.DecodeResult readResult, ulong value, ref int tokenSize);
        static /*0x6f99e10*/ sbyte <ReadSByte>g__SlowPath|67_0(ref MessagePack.MessagePackReader self, MessagePack.MessagePackPrimitives.DecodeResult readResult, sbyte value, ref int tokenSize);
        static /*0x6f9a158*/ short <ReadInt16>g__SlowPath|68_0(ref MessagePack.MessagePackReader self, MessagePack.MessagePackPrimitives.DecodeResult readResult, short value, ref int tokenSize);
        static /*0x6f9a49c*/ int <ReadInt32>g__SlowPath|69_0(ref MessagePack.MessagePackReader self, MessagePack.MessagePackPrimitives.DecodeResult readResult, int value, ref int tokenSize);
        static /*0x6f9a7e4*/ long <ReadInt64>g__SlowPath|70_0(ref MessagePack.MessagePackReader self, MessagePack.MessagePackPrimitives.DecodeResult readResult, long value, ref int tokenSize);
        /*0x6f951d0*/ MessagePackReader(System.ReadOnlyMemory<byte> memory);
        /*0x6f95274*/ MessagePackReader(ref System.Buffers.ReadOnlySequence<byte> readOnlySequence);
        /*0x6f95310*/ System.Threading.CancellationToken get_CancellationToken();
        /*0x6f95318*/ void set_CancellationToken(System.Threading.CancellationToken value);
        /*0x6f95320*/ int get_Depth();
        /*0x6f95328*/ void set_Depth(int value);
        /*0x6f95330*/ System.Buffers.ReadOnlySequence<byte> get_Sequence();
        /*0x6f953a0*/ System.SequencePosition get_Position();
        /*0x6f953e8*/ bool get_End();
        /*0x6f95430*/ bool get_IsNil();
        /*0x6f954dc*/ MessagePack.MessagePackType get_NextMessagePackType();
        /*0x6f9544c*/ byte get_NextCode();
        /*0x6f95550*/ MessagePack.MessagePackReader Clone(ref System.Buffers.ReadOnlySequence<byte> readOnlySequence);
        /*0x6f955c0*/ MessagePack.MessagePackReader CreatePeekReader();
        /*0x6f955d0*/ void Skip();
        /*0x6f955e8*/ bool TrySkip();
        /*0x6f95bf4*/ MessagePack.Nil ReadNil();
        /*0x6f95c88*/ bool TryReadNil();
        /*0x6f95cf4*/ System.Buffers.ReadOnlySequence<byte> ReadRaw(long length);
        /*0x6f95f44*/ System.Buffers.ReadOnlySequence<byte> ReadRaw();
        /*0x6f96038*/ int ReadArrayHeader();
        /*0x6f960b0*/ bool TryReadArrayHeader(ref int count);
        /*0x6f96464*/ int ReadMapHeader();
        /*0x6f96504*/ bool TryReadMapHeader(ref int count);
        /*0x6f968b8*/ bool ReadBoolean();
        /*0x6f96938*/ char ReadChar();
        /*0x6f96a5c*/ float ReadSingle();
        /*0x6f96da8*/ double ReadDouble();
        /*0x6f970f8*/ System.DateTime ReadDateTime();
        /*0x6f97440*/ System.DateTime ReadDateTime(MessagePack.ExtensionHeader header);
        /*0x6f977b0*/ System.Nullable<System.Buffers.ReadOnlySequence<byte>> ReadBytes();
        /*0x6f979d0*/ System.Nullable<System.Buffers.ReadOnlySequence<byte>> ReadStringSequence();
        /*0x6f97bf4*/ bool TryReadStringSpan(ref System.ReadOnlySpan<byte> span);
        /*0x6f97dcc*/ string ReadString();
        /*0x6f984dc*/ MessagePack.ExtensionHeader ReadExtensionFormatHeader();
        /*0x6f95a34*/ bool TryReadExtensionFormatHeader(ref MessagePack.ExtensionHeader extensionHeader);
        /*0x6f98784*/ MessagePack.ExtensionResult ReadExtensionFormat();
        /*0x6f979ac*/ uint GetBytesLength();
        /*0x6f9590c*/ bool TryGetBytesLength(ref uint length);
        /*0x6f98d14*/ bool TryGetStringLengthInBytes(ref uint length);
        /*0x6f97bcc*/ uint GetStringLengthInBytes();
        /*0x6f98010*/ string ReadStringSlow(uint byteLength);
        /*0x6f958c8*/ bool TrySkipNextArray();
        /*0x6f95840*/ bool TrySkipNextMap();
        /*0x6f9906c*/ bool TrySkip(int count);
        /*0x6f990f4*/ byte ReadByte();
        /*0x6f9693c*/ ushort ReadUInt16();
        /*0x6f99664*/ uint ReadUInt32();
        /*0x6f999a8*/ ulong ReadUInt64();
        /*0x6f99cf0*/ sbyte ReadSByte();
        /*0x6f9a038*/ short ReadInt16();
        /*0x6f9a380*/ int ReadInt32();
        /*0x6f9a6c4*/ long ReadInt64();
    }

    class MessagePackSecurity
    {
        static /*0x0*/ MessagePack.MessagePackSecurity TrustedData;
        static /*0x8*/ MessagePack.MessagePackSecurity UntrustedData;
        static /*0x10*/ MessagePack.SipHash Hash;
        /*0x10*/ MessagePack.MessagePackSecurity.ObjectFallbackEqualityComparer objectFallbackEqualityComparer;
        /*0x18*/ bool <HashCollisionResistant>k__BackingField;
        /*0x1c*/ int <MaximumObjectGraphDepth>k__BackingField;

        static /*0x6f9b564*/ MessagePackSecurity();
        static /*0x3907c14*/ int SecureHash<T>(T value);
        static /*0x6f9ad70*/ int SecureHash(System.ReadOnlySpan<byte> data);
        /*0x6f9aa0c*/ MessagePackSecurity();
        /*0x6f9ab7c*/ bool get_HashCollisionResistant();
        /*0x6f9ab84*/ void set_HashCollisionResistant(bool value);
        /*0x6f9ab90*/ int get_MaximumObjectGraphDepth();
        /*0x6f9ab98*/ void set_MaximumObjectGraphDepth(int value);
        /*0x380b9e8*/ System.Collections.Generic.IEqualityComparer<T> GetEqualityComparer<T>();
        /*0x6f9aba0*/ System.Collections.IEqualityComparer GetEqualityComparer();
        /*0x380b9e8*/ System.Collections.Generic.IEqualityComparer<T> GetHashCollisionResistantEqualityComparer<T>();
        /*0x6f9ac04*/ void DepthStep(ref MessagePack.MessagePackReader reader);
        /*0x6f9acd0*/ System.Collections.IEqualityComparer GetHashCollisionResistantEqualityComparer();

        class HashResistantCache<T>
        {
            static /*0x0*/ System.Collections.Generic.IEqualityComparer<T> EqualityComparer;

            static /*0x38358cc*/ HashResistantCache();
        }

        class CollisionResistantHasher<T> : System.Collections.Generic.IEqualityComparer<T>, System.Collections.IEqualityComparer
        {
            /*0x380cb08*/ CollisionResistantHasher();
            /*0x3907c14*/ bool Equals(T x, T y);
            /*0x380b32c*/ bool System.Collections.IEqualityComparer.Equals(object x, object y);
            /*0x380b7a8*/ int GetHashCode(object obj);
            /*0x3907c14*/ int GetHashCode(T value);
        }

        class CollisionResistantHasherUnmanaged<T> : MessagePack.MessagePackSecurity.CollisionResistantHasher<T>
        {
            static /*0x0*/ MessagePack.MessagePackSecurity.CollisionResistantHasherUnmanaged<T> Instance;

            static /*0x38358cc*/ CollisionResistantHasherUnmanaged();
            /*0x380cb08*/ CollisionResistantHasherUnmanaged();
            /*0x3907c14*/ int GetHashCode(T value);
        }

        class ObjectFallbackEqualityComparer : System.Collections.Generic.IEqualityComparer<object>, System.Collections.IEqualityComparer
        {
            static /*0x0*/ System.Lazy<System.Reflection.MethodInfo> GetHashCollisionResistantEqualityComparerOpenGenericMethod;
            /*0x10*/ MessagePack.MessagePackSecurity security;
            /*0x18*/ MessagePack.Internal.ThreadsafeTypeKeyHashTable<System.Collections.IEqualityComparer> equalityComparerCache;

            static /*0x6f9bef4*/ ObjectFallbackEqualityComparer();
            /*0x6f9aa80*/ ObjectFallbackEqualityComparer(MessagePack.MessagePackSecurity security);
            /*0x6f9b9d4*/ bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y);
            /*0x6f9ba40*/ bool System.Collections.IEqualityComparer.Equals(object x, object y);
            /*0x6f9bb10*/ int GetHashCode(object value);

            class <>c
            {
                static /*0x0*/ MessagePack.MessagePackSecurity.ObjectFallbackEqualityComparer.<> <>9;
                static /*0x8*/ System.Func<System.Reflection.MethodInfo, bool> <>9__7_1;

                static /*0x6f9c00c*/ <>c();
                /*0x6f9c074*/ <>c();
                /*0x6f9c07c*/ System.Reflection.MethodInfo <.cctor>b__7_0();
                /*0x6f9c1d8*/ bool <.cctor>b__7_1(System.Reflection.MethodInfo m);
            }
        }

        class SingleEqualityComparer : MessagePack.MessagePackSecurity.CollisionResistantHasherUnmanaged<float>
        {
            static /*0x0*/ MessagePack.MessagePackSecurity.SingleEqualityComparer Instance;

            static /*0x6f9c348*/ SingleEqualityComparer();
            /*0x6f9c2dc*/ SingleEqualityComparer();
            /*0x6f9c260*/ int GetHashCode(float value);
        }

        class DoubleEqualityComparer : MessagePack.MessagePackSecurity.CollisionResistantHasherUnmanaged<double>
        {
            static /*0x0*/ MessagePack.MessagePackSecurity.DoubleEqualityComparer Instance;

            static /*0x6f9c494*/ DoubleEqualityComparer();
            /*0x6f9c428*/ DoubleEqualityComparer();
            /*0x6f9c3ac*/ int GetHashCode(double value);
        }

        class DateTimeEqualityComparer : MessagePack.MessagePackSecurity.CollisionResistantHasherUnmanaged<System.DateTime>
        {
            static /*0x0*/ MessagePack.MessagePackSecurity.DateTimeEqualityComparer Instance;

            static /*0x6f9c60c*/ DateTimeEqualityComparer();
            /*0x6f9c5a0*/ DateTimeEqualityComparer();
            /*0x6f9c4f8*/ int GetHashCode(System.DateTime value);
        }

        class DateTimeOffsetEqualityComparer : MessagePack.MessagePackSecurity.CollisionResistantHasherUnmanaged<System.DateTimeOffset>
        {
            static /*0x0*/ MessagePack.MessagePackSecurity.DateTimeOffsetEqualityComparer Instance;

            static /*0x6f9c7c8*/ DateTimeOffsetEqualityComparer();
            /*0x6f9c75c*/ DateTimeOffsetEqualityComparer();
            /*0x6f9c670*/ int GetHashCode(System.DateTimeOffset value);
        }

        class StringEqualityComparer : MessagePack.MessagePackSecurity.CollisionResistantHasher<string>
        {
            static /*0x0*/ MessagePack.MessagePackSecurity.StringEqualityComparer Instance;

            static /*0x6f9c964*/ StringEqualityComparer();
            /*0x6f9c91c*/ StringEqualityComparer();
            /*0x6f9c82c*/ int GetHashCode(string value);
        }

        class CollisionResistantEnumHasher<TEnum, TUnderlying> : System.Collections.Generic.IEqualityComparer<TEnum>, System.Collections.IEqualityComparer
        {
            static /*0x0*/ MessagePack.MessagePackSecurity.CollisionResistantEnumHasher<TEnum, TUnderlying> Instance;

            static /*0x38358cc*/ CollisionResistantEnumHasher();
            /*0x380cb08*/ CollisionResistantEnumHasher();
            /*0x3907c14*/ bool Equals(TEnum x, TEnum y);
            /*0x3907c14*/ int GetHashCode(TEnum obj);
            /*0x380b32c*/ bool System.Collections.IEqualityComparer.Equals(object x, object y);
            /*0x380b7a8*/ int System.Collections.IEqualityComparer.GetHashCode(object obj);
        }
    }

    class MessagePackSerializationException : System.Exception
    {
        static /*0x382dee4*/ System.Exception ThrowUnexpectedNilWhileDeserializing<T>();
        /*0x6f9c9c8*/ MessagePackSerializationException();
        /*0x6f8e668*/ MessagePackSerializationException(string message);
        /*0x6f9ca20*/ MessagePackSerializationException(string message, System.Exception inner);
        /*0x6f8e6d4*/ MessagePackSerializationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
    }

    class MessagePackSerializer
    {
        static /*0x0*/ MessagePack.MessagePackSerializerOptions defaultOptions;
        static /*0x8*/ MessagePack.MessagePackSerializer.LZ4Transform LZ4CodecEncode;
        static /*0x10*/ MessagePack.MessagePackSerializer.LZ4Transform LZ4CodecDecode;
        static /*0x18*/ System.Func<System.Type, MessagePack.MessagePackSerializer.CompiledMethods> CreateCompiledMethods;
        static /*0x20*/ MessagePack.Internal.ThreadsafeTypeKeyHashTable<MessagePack.MessagePackSerializer.CompiledMethods> Serializes;
        [ThreadStatic] static byte[] scratchArray;

        static /*0x6f9e708*/ MessagePackSerializer();
        static /*0x6f9ca90*/ MessagePack.MessagePackSerializerOptions get_DefaultOptions();
        static /*0x6f9cb88*/ void set_DefaultOptions(MessagePack.MessagePackSerializerOptions value);
        static /*0x3907c14*/ void Serialize<T>(System.Buffers.IBufferWriter<byte> writer, T value, MessagePack.MessagePackSerializerOptions options, System.Threading.CancellationToken cancellationToken);
        static /*0x3907c14*/ void Serialize<T>(ref MessagePack.MessagePackWriter writer, T value, MessagePack.MessagePackSerializerOptions options);
        static /*0x3907c14*/ byte[] Serialize<T>(T value, MessagePack.MessagePackSerializerOptions options, System.Threading.CancellationToken cancellationToken);
        static /*0x3907c14*/ T Deserialize<T>(ref System.Buffers.ReadOnlySequence<byte> byteSequence, MessagePack.MessagePackSerializerOptions options, System.Threading.CancellationToken cancellationToken);
        static /*0x3907c14*/ T Deserialize<T>(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        static /*0x3907c14*/ T Deserialize<T>(System.ReadOnlyMemory<byte> buffer, MessagePack.MessagePackSerializerOptions options, System.Threading.CancellationToken cancellationToken);
        static /*0x6f9cbf0*/ int LZ4Operation(ref System.Buffers.ReadOnlySequence<byte> input, System.Span<byte> output, MessagePack.MessagePackSerializer.LZ4Transform lz4Operation);
        static /*0x6f9cf70*/ bool TryDecompress(ref MessagePack.MessagePackReader reader, System.Buffers.IBufferWriter<byte> writer);
        static /*0x6f9d718*/ void ToLZ4BinaryCore(ref System.Buffers.ReadOnlySequence<byte> msgpackUncompressedData, ref MessagePack.MessagePackWriter writer, MessagePack.MessagePackCompression compression, int minCompressionSize);
        static /*0x6f9e2d8*/ int GetUInt32WriteSize(uint value);
        static /*0x6f9e358*/ void WriteBin32Header(uint value, System.Span<byte> span);
        static /*0x6f9e440*/ bool IsMessagePackFixedSizePrimitiveTypeHelper(System.Type type);

        class LZ4Transform : System.MulticastDelegate
        {
            /*0x6f9e8cc*/ LZ4Transform(object object, nint method);
            /*0x6f9e96c*/ int Invoke(System.ReadOnlySpan<byte> input, System.Span<byte> output);
        }

        class PrimitiveChecker<T>
        {
            static /*0x0*/ bool IsMessagePackFixedSizePrimitive;

            static /*0x38358cc*/ PrimitiveChecker();
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

            static /*0x6fa19b8*/ void ThrowRefStructNotSupported();
            static /*0x6fa1640*/ System.Reflection.MethodInfo GetMethod(string methodName, System.Type type, System.Type[] parameters);
            /*0x6f9e9d8*/ CompiledMethods(System.Type type);
            /*0x6f9e980*/ bool get_PreferInterpretation();

            class MessagePackWriterSerialize : System.MulticastDelegate
            {
                /*0x6fa1830*/ MessagePackWriterSerialize(object object, nint method);
                /*0x6fa1a0c*/ void Invoke(ref MessagePack.MessagePackWriter writer, object value, MessagePack.MessagePackSerializerOptions options);
            }

            class MessagePackReaderDeserialize : System.MulticastDelegate
            {
                /*0x6fa18e4*/ MessagePackReaderDeserialize(object object, nint method);
                /*0x6fa1a20*/ object Invoke(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
            }

            class <>c
            {
                static /*0x0*/ MessagePack.MessagePackSerializer.CompiledMethods.<> <>9;
                static /*0x8*/ MessagePack.MessagePackSerializer.CompiledMethods.MessagePackWriterSerialize <>9__14_4;
                static /*0x10*/ MessagePack.MessagePackSerializer.CompiledMethods.MessagePackReaderDeserialize <>9__14_5;

                static /*0x6fa1a34*/ <>c();
                /*0x6fa1a9c*/ <>c();
                /*0x6fa1aa4*/ void <.ctor>b__14_4(ref MessagePack.MessagePackWriter x, object y, MessagePack.MessagePackSerializerOptions z);
                /*0x6fa1aac*/ object <.ctor>b__14_5(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
            }

            class <>c__DisplayClass14_0
            {
                /*0x10*/ System.Reflection.MethodInfo serialize;

                /*0x6fa1638*/ <>c__DisplayClass14_0();
                /*0x6fa1ab4*/ byte[] <.ctor>b__0(object x, MessagePack.MessagePackSerializerOptions y, System.Threading.CancellationToken z);
            }

            class <>c__DisplayClass14_1
            {
                /*0x10*/ System.Reflection.MethodInfo serialize;

                /*0x6fa1818*/ <>c__DisplayClass14_1();
                /*0x6fa1c4c*/ void <.ctor>b__1(System.IO.Stream x, object y, MessagePack.MessagePackSerializerOptions z, System.Threading.CancellationToken a);
            }

            class <>c__DisplayClass14_2
            {
                /*0x10*/ System.Reflection.MethodInfo serialize;

                /*0x6fa1820*/ <>c__DisplayClass14_2();
                /*0x6fa1dec*/ System.Threading.Tasks.Task <.ctor>b__2(System.IO.Stream x, object y, MessagePack.MessagePackSerializerOptions z, System.Threading.CancellationToken a);
            }

            class <>c__DisplayClass14_3
            {
                /*0x10*/ System.Reflection.MethodInfo serialize;

                /*0x6fa1828*/ <>c__DisplayClass14_3();
                /*0x6fa1fd4*/ void <.ctor>b__3(System.Buffers.IBufferWriter<byte> x, object y, MessagePack.MessagePackSerializerOptions z, System.Threading.CancellationToken a);
            }

            class <>c__DisplayClass14_4
            {
                /*0x10*/ System.Reflection.MethodInfo deserialize;

                /*0x6fa1998*/ <>c__DisplayClass14_4();
                /*0x6fa2174*/ object <.ctor>b__6(System.IO.Stream x, MessagePack.MessagePackSerializerOptions y, System.Threading.CancellationToken z);
            }

            class <>c__DisplayClass14_5
            {
                /*0x10*/ System.Reflection.MethodInfo deserialize;

                /*0x6fa19a0*/ <>c__DisplayClass14_5();
                /*0x6fa22d4*/ System.Threading.Tasks.ValueTask<object> <.ctor>b__7(System.IO.Stream x, MessagePack.MessagePackSerializerOptions y, System.Threading.CancellationToken z);
            }

            class <>c__DisplayClass14_6
            {
                /*0x10*/ System.Reflection.MethodInfo deserialize;

                /*0x6fa19a8*/ <>c__DisplayClass14_6();
                /*0x6fa2488*/ object <.ctor>b__8(System.ReadOnlyMemory<byte> x, MessagePack.MessagePackSerializerOptions y, System.Threading.CancellationToken z);
            }

            class <>c__DisplayClass14_7
            {
                /*0x10*/ System.Reflection.MethodInfo deserialize;

                /*0x6fa19b0*/ <>c__DisplayClass14_7();
                /*0x6fa2624*/ object <.ctor>b__9(System.Buffers.ReadOnlySequence<byte> x, MessagePack.MessagePackSerializerOptions y, System.Threading.CancellationToken z);
            }

            class <>c__DisplayClass16_0
            {
                /*0x10*/ string methodName;
                /*0x18*/ System.Type[] parameters;

                /*0x6fa1a04*/ <>c__DisplayClass16_0();
                /*0x6fa27c0*/ bool <GetMethod>b__0(System.Reflection.MethodInfo x);
            }
        }

        class <>c
        {
            static /*0x0*/ MessagePack.MessagePackSerializer.<> <>9;

            static /*0x6fa2980*/ <>c();
            /*0x6fa29e8*/ <>c();
            /*0x6fa29f0*/ MessagePack.MessagePackSerializer.CompiledMethods <.cctor>b__43_0(System.Type t);
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

        static /*0x6fa2f5c*/ MessagePackSerializerOptions();
        static /*0x6fa2a48*/ MessagePack.MessagePackSerializerOptions get_Standard();
        /*0x6fa2aa0*/ MessagePackSerializerOptions(MessagePack.IFormatterResolver resolver);
        /*0x6fa2bcc*/ MessagePackSerializerOptions(MessagePack.MessagePackSerializerOptions copyFrom);
        /*0x6fa2d3c*/ MessagePack.IFormatterResolver get_Resolver();
        /*0x6fa2d44*/ void set_Resolver(MessagePack.IFormatterResolver value);
        /*0x6fa2d4c*/ MessagePack.MessagePackCompression get_Compression();
        /*0x6fa2d54*/ void set_Compression(MessagePack.MessagePackCompression value);
        /*0x6fa2d5c*/ int get_CompressionMinLength();
        /*0x6fa2d64*/ void set_CompressionMinLength(int value);
        /*0x6fa2d6c*/ int get_SuggestedContiguousMemorySize();
        /*0x6fa2d74*/ void set_SuggestedContiguousMemorySize(int value);
        /*0x6fa2d7c*/ System.Nullable<bool> get_OldSpec();
        /*0x6fa2d84*/ void set_OldSpec(System.Nullable<bool> value);
        /*0x6fa2d8c*/ bool get_OmitAssemblyVersion();
        /*0x6fa2d94*/ void set_OmitAssemblyVersion(bool value);
        /*0x6fa2da0*/ bool get_AllowAssemblyVersionMismatch();
        /*0x6fa2da8*/ void set_AllowAssemblyVersionMismatch(bool value);
        /*0x6fa2db4*/ MessagePack.MessagePackSecurity get_Security();
        /*0x6fa2dbc*/ void set_Security(MessagePack.MessagePackSecurity value);
        /*0x6fa2dc4*/ MessagePack.SequencePool get_SequencePool();
        /*0x6fa2dcc*/ void set_SequencePool(MessagePack.SequencePool value);
        /*0x6fa2dd4*/ MessagePack.MessagePackSerializerOptions WithCompression(MessagePack.MessagePackCompression compression);
        /*0x6fa2e08*/ MessagePack.MessagePackSerializerOptions Clone();

        class MessagePackSerializerOptionsDefaultSettingsLazyInitializationHelper
        {
            static /*0x0*/ MessagePack.MessagePackSerializerOptions Standard;

            static /*0x6fa30b8*/ MessagePackSerializerOptionsDefaultSettingsLazyInitializationHelper();
        }
    }

    class MessagePackStreamReader : System.IDisposable
    {
        /*0x10*/ System.IO.Stream stream;
        /*0x18*/ bool leaveOpen;
        /*0x20*/ MessagePack.SequencePool.Rental sequenceRental;
        /*0x30*/ System.Nullable<System.SequencePosition> endOfLastMessage;

        /*0x6fa3164*/ MessagePackStreamReader(System.IO.Stream stream, bool leaveOpen);
        /*0x6fa31dc*/ MessagePackStreamReader(System.IO.Stream stream, bool leaveOpen, MessagePack.SequencePool sequencePool);
        /*0x6fa32bc*/ Nerdbank.Streams.Sequence<byte> get_ReadData();
        /*0x6fa32c4*/ System.Threading.Tasks.ValueTask<System.Nullable<System.Buffers.ReadOnlySequence<byte>>> ReadAsync(System.Threading.CancellationToken cancellationToken);
        /*0x6fa343c*/ void Dispose();
        /*0x6fa34a8*/ void Dispose(bool disposing);
        /*0x6fa3510*/ void RecycleLastMessage();
        /*0x6fa35b8*/ System.Threading.Tasks.Task<bool> TryReadMoreDataAsync(System.Threading.CancellationToken cancellationToken);
        /*0x6fa36e4*/ bool TryReadNextMessage(ref System.Buffers.ReadOnlySequence<byte> completeMessage);

        struct <ReadAsync>d__14 : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder<System.Nullable<System.Buffers.ReadOnlySequence<byte>>> <>t__builder;
            /*0x58*/ MessagePack.MessagePackStreamReader <>4__this;
            /*0x60*/ System.Threading.CancellationToken cancellationToken;
            /*0x68*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;

            /*0x6fa3920*/ void MoveNext();
            /*0x6fa3c00*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }

        struct <TryReadMoreDataAsync>d__19 : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder;
            /*0x30*/ System.Threading.CancellationToken cancellationToken;
            /*0x38*/ MessagePack.MessagePackStreamReader <>4__this;
            /*0x40*/ int <bytesRead>5__2;
            /*0x48*/ System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int> <>u__1;

            /*0x6fa3c58*/ void MoveNext();
            /*0x6fa413c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    struct MessagePackWriter
    {
        /*0x10*/ MessagePack.BufferWriter writer;
        /*0x60*/ System.Threading.CancellationToken <CancellationToken>k__BackingField;
        /*0x68*/ bool <OldSpec>k__BackingField;

        static /*0x6fa6330*/ void WriteBigEndian(ushort value, byte* span);
        static /*0x6fa6340*/ void WriteBigEndian(uint value, byte* span);
        static /*0x6fa4410*/ void AssumesTrue(bool condition);
        /*0x6fa41b8*/ MessagePackWriter(System.Buffers.IBufferWriter<byte> writer);
        /*0x6fa420c*/ MessagePackWriter(MessagePack.SequencePool sequencePool, byte[] array);
        /*0x6fa4260*/ System.Threading.CancellationToken get_CancellationToken();
        /*0x6fa4268*/ void set_CancellationToken(System.Threading.CancellationToken value);
        /*0x6fa4270*/ bool get_OldSpec();
        /*0x6fa4278*/ void set_OldSpec(bool value);
        /*0x6fa4284*/ MessagePack.MessagePackWriter Clone(System.Buffers.IBufferWriter<byte> writer);
        /*0x6fa4308*/ void Flush();
        /*0x6fa4310*/ void WriteNil();
        /*0x6f9e2d0*/ void WriteRaw(System.ReadOnlySpan<byte> rawMessagePackBlock);
        /*0x6f9df94*/ void WriteRaw(ref System.Buffers.ReadOnlySequence<byte> rawMessagePackBlock);
        /*0x6f9e30c*/ void WriteArrayHeader(int count);
        /*0x6fa4464*/ void WriteArrayHeader(uint count);
        /*0x6fa4544*/ void WriteMapHeader(int count);
        /*0x6fa4588*/ void WriteMapHeader(uint count);
        /*0x6fa4668*/ void Write(byte value);
        /*0x6fa4748*/ void WriteUInt8(byte value);
        /*0x6fa4854*/ void Write(sbyte value);
        /*0x6fa4934*/ void WriteInt8(sbyte value);
        /*0x6fa4a40*/ void Write(ushort value);
        /*0x6fa4b20*/ void WriteUInt16(ushort value);
        /*0x6fa4c00*/ void Write(short value);
        /*0x6fa4ce0*/ void WriteInt16(short value);
        /*0x6fa4dc0*/ void Write(uint value);
        /*0x6fa4ea0*/ void WriteUInt32(uint value);
        /*0x6fa4f80*/ void Write(int value);
        /*0x6f9e1f0*/ void WriteInt32(int value);
        /*0x6fa5060*/ void Write(ulong value);
        /*0x6fa5140*/ void WriteUInt64(ulong value);
        /*0x6fa5220*/ void Write(long value);
        /*0x6fa5300*/ void WriteInt64(long value);
        /*0x6fa53e0*/ void Write(bool value);
        /*0x6fa54f4*/ void Write(char value);
        /*0x6fa55d4*/ void Write(float value);
        /*0x6fa56c4*/ void Write(double value);
        /*0x6fa57b4*/ void Write(System.DateTime dateTime);
        /*0x6fa58e4*/ void Write(byte[] src);
        /*0x6fa5984*/ void Write(System.ReadOnlySpan<byte> src);
        /*0x6fa5bf0*/ void Write(ref System.Buffers.ReadOnlySequence<byte> src);
        /*0x6fa5ab4*/ void WriteBinHeader(int length);
        /*0x6fa5e9c*/ void WriteString(System.ReadOnlySpan<byte> utf8stringBytes);
        /*0x6fa5d78*/ void WriteStringHeader(int byteCount);
        /*0x6fa5fcc*/ void Write(string value);
        /*0x6fa60cc*/ void Write(System.ReadOnlySpan<char> value);
        /*0x6f9e0d0*/ void WriteExtensionFormatHeader(MessagePack.ExtensionHeader extensionHeader);
        /*0x6f9e354*/ System.Span<byte> GetSpan(int length);
        /*0x6f9e384*/ void Advance(int length);
        /*0x6fa61e4*/ byte[] FlushAndGetArray();
        /*0x6fa634c*/ ref byte WriteString_PrepareSpan(int characterLength, ref int bufferSize, ref int encodedBytesOffset);
        /*0x6fa6470*/ void WriteString_PostEncoding(byte* pBuffer, int estimatedOffset, int byteCount);
    }

    struct MonoProtection
    {
        static /*0x0*/ object RefEmitLock;

        static /*0x6fa688c*/ MonoProtection();
        static /*0x6fa673c*/ bool get_IsRunningOnMono();
        static /*0x6fa67d0*/ MessagePack.MonoProtectionDisposal EnterRefEmitLock();
    }

    struct MonoProtectionDisposal : System.IDisposable
    {
        /*0x10*/ object lockObject;

        /*0x6fa686c*/ MonoProtectionDisposal(object lockObject);
        /*0x6fa6908*/ void Dispose();
    }

    struct Nil : System.IEquatable<MessagePack.Nil>
    {
        static /*0x0*/ MessagePack.Nil Default;

        /*0x6fa691c*/ bool Equals(object obj);
        /*0x6fa6978*/ bool Equals(MessagePack.Nil other);
        /*0x6fa6980*/ int GetHashCode();
        /*0x6fa6988*/ string ToString();
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

        static /*0x6fa7ad8*/ SkipClrVisibilityChecks();
        static /*0x6fa6ae4*/ void GetSkipVisibilityChecksRequirements(System.Reflection.TypeInfo typeInfo, System.Collections.Immutable.ImmutableHashSet.Builder<System.Reflection.AssemblyName> referencedAssemblies);
        static /*0x6fa7040*/ void <GetSkipVisibilityChecksRequirements>g__AddTypeIfNonPublic|9_0(System.Type type, ref MessagePack.SkipClrVisibilityChecks.<> );
        /*0x6fa69c8*/ SkipClrVisibilityChecks(System.Reflection.Emit.AssemblyBuilder assemblyBuilder, System.Reflection.Emit.ModuleBuilder moduleBuilder);
        /*0x6fa7194*/ void SkipVisibilityChecksFor(System.Collections.Generic.IEnumerable<System.Reflection.AssemblyName> assemblyNames);
        /*0x6fa7468*/ void SkipVisibilityChecksFor(System.Reflection.AssemblyName assemblyName);
        /*0x6fa75a0*/ System.Reflection.ConstructorInfo GetMagicAttributeCtor();
        /*0x6fa76e8*/ System.Reflection.TypeInfo EmitMagicAttribute();

        class AssemblyNameEqualityComparer : System.Collections.Generic.IEqualityComparer<System.Reflection.AssemblyName>
        {
            static /*0x0*/ MessagePack.SkipClrVisibilityChecks.AssemblyNameEqualityComparer Instance;

            static /*0x6fa7e68*/ AssemblyNameEqualityComparer();
            /*0x6fa7dcc*/ AssemblyNameEqualityComparer();
            /*0x6fa7dd4*/ bool Equals(System.Reflection.AssemblyName x, System.Reflection.AssemblyName y);
            /*0x6fa7e34*/ int GetHashCode(System.Reflection.AssemblyName obj);
        }

        class <>c
        {
            static /*0x0*/ MessagePack.SkipClrVisibilityChecks.<> <>9;

            static /*0x6fa7ed0*/ <>c();
            /*0x6fa7f38*/ <>c();
            /*0x6fa7f40*/ bool <.cctor>b__15_0(System.Reflection.ConstructorInfo ctor);
        }

        struct <>c__DisplayClass9_0
        {
            /*0x10*/ System.Collections.Immutable.ImmutableHashSet.Builder<System.Reflection.AssemblyName> referencedAssemblies;
        }
    }

    class SafeBitConverter
    {
        static /*0x6fa7f7c*/ long ToInt64(System.ReadOnlySpan<byte> value);
        static /*0x6fa7fe8*/ ulong ToUInt64(System.ReadOnlySpan<byte> value);
        static /*0x6fa7fec*/ ushort ToUInt16(System.ReadOnlySpan<byte> value);
        static /*0x6fa8058*/ uint ToUInt32(System.ReadOnlySpan<byte> value);
    }

    class SequencePool
    {
        static /*0x0*/ MessagePack.SequencePool Shared;
        /*0x10*/ int maxSize;
        /*0x18*/ System.Collections.Generic.Stack<Nerdbank.Streams.Sequence<byte>> pool;
        /*0x20*/ object arrayPoolOrMemoryPool;

        static /*0x6fa83b8*/ SequencePool();
        /*0x6fa80c4*/ SequencePool();
        /*0x6fa8180*/ SequencePool(int maxSize, System.Buffers.ArrayPool<byte> arrayPool);
        /*0x6f8dc54*/ MessagePack.SequencePool.Rental Rent();
        /*0x6fa825c*/ void Return(Nerdbank.Streams.Sequence<byte> value);

        struct Rental : System.IDisposable
        {
            /*0x10*/ MessagePack.SequencePool owner;
            /*0x18*/ Nerdbank.Streams.Sequence<byte> <Value>k__BackingField;

            /*0x6fa822c*/ Rental(MessagePack.SequencePool owner, Nerdbank.Streams.Sequence<byte> value);
            /*0x6fa841c*/ Nerdbank.Streams.Sequence<byte> get_Value();
            /*0x6fa34f8*/ void Dispose();
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

        /*0x380d83c*/ SequenceReader(ref System.Buffers.ReadOnlySequence<T> sequence);
        /*0x3907c14*/ SequenceReader(System.ReadOnlyMemory<T> memory);
        /*0x380b128*/ bool get_End();
        /*0x3907c14*/ System.Buffers.ReadOnlySequence<T> get_Sequence();
        /*0x3907c14*/ System.SequencePosition get_Position();
        /*0x3907c14*/ System.ReadOnlySpan<T> get_CurrentSpan();
        /*0x3907c14*/ void set_CurrentSpan(System.ReadOnlySpan<T> value);
        /*0x380b6a0*/ int get_CurrentSpanIndex();
        /*0x380cffc*/ void set_CurrentSpanIndex(int value);
        /*0x3907c14*/ System.ReadOnlySpan<T> get_UnreadSpan();
        /*0x380b828*/ long get_Consumed();
        /*0x380d438*/ void set_Consumed(long value);
        /*0x380b828*/ long get_Remaining();
        /*0x380b828*/ long get_Length();
        /*0x380b2f0*/ bool TryPeek(ref T value);
        /*0x380b2f0*/ bool TryRead(ref T value);
        /*0x380d438*/ void Rewind(long count);
        /*0x380d438*/ void RetreatToPreviousSpan(long consumed);
        /*0x380cb08*/ void ResetReader();
        /*0x380cb08*/ void GetNextSpan();
        /*0x380d438*/ void Advance(long count);
        bool TryAdvance(long count);
        /*0x380d438*/ void AdvanceToNextSpan(long count);
        /*0x3907c14*/ bool TryCopyTo(System.Span<T> destination);
        /*0x3907c14*/ bool TryCopyMultisegment(System.Span<T> destination);
    }

    class SipHash
    {
        /*0x10*/ ulong initialState0;
        /*0x18*/ ulong initialState1;

        /*0x6f9b648*/ SipHash();
        /*0x6f9adec*/ long Compute(System.ReadOnlySpan<byte> data);
    }

    class StringEncoding
    {
        static /*0x0*/ System.Text.Encoding UTF8;

        static /*0x6fa96cc*/ StringEncoding();
    }

    class Utilities
    {
        static /*0x6fa974c*/ System.Memory<byte> GetMemoryCheckResult(System.Buffers.IBufferWriter<byte> bufferWriter, int size);
        static /*0x6fa98bc*/ MessagePack.Utilities.NonGenericDictionaryEnumerable GetEntryEnumerator(System.Collections.IDictionary dictionary);

        struct NonGenericDictionaryEnumerable
        {
            /*0x10*/ System.Collections.IDictionary dictionary;

            /*0x6fa98dc*/ NonGenericDictionaryEnumerable(System.Collections.IDictionary dictionary);
            /*0x6fa98e4*/ MessagePack.Utilities.NonGenericDictionaryEnumerator GetEnumerator();
        }

        struct NonGenericDictionaryEnumerator : System.Collections.Generic.IEnumerator<System.Collections.DictionaryEntry>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ System.Collections.IDictionaryEnumerator enumerator;

            /*0x6fa9904*/ NonGenericDictionaryEnumerator(System.Collections.IDictionary dictionary);
            /*0x6fa99b8*/ System.Collections.DictionaryEntry get_Current();
            /*0x6fa9a5c*/ object System.Collections.IEnumerator.get_Current();
            /*0x6fa9b34*/ void Dispose();
            /*0x6fa9b38*/ bool MoveNext();
            /*0x6fa9bd8*/ void Reset();
        }
    }

    namespace Resolvers
    {
        class AttributeFormatterResolver : MessagePack.IFormatterResolver
        {
            static /*0x0*/ MessagePack.Resolvers.AttributeFormatterResolver Instance;

            static /*0x6fa9c84*/ AttributeFormatterResolver();
            /*0x6fa9c7c*/ AttributeFormatterResolver();
            /*0x380b9e8*/ MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static /*0x38358cc*/ FormatterCache();
            }
        }

        class BuiltinResolver : MessagePack.IFormatterResolver
        {
            static /*0x0*/ MessagePack.Resolvers.BuiltinResolver Instance;

            static /*0x6fa9cf4*/ BuiltinResolver();
            /*0x6fa9cec*/ BuiltinResolver();
            /*0x380b9e8*/ MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static /*0x38358cc*/ FormatterCache();
            }
        }

        class CompositeResolver
        {
            static /*0x0*/ System.Collections.ObjectModel.ReadOnlyDictionary<System.Type, MessagePack.Formatters.IMessagePackFormatter> EmptyFormattersByType;

            static /*0x6faa084*/ CompositeResolver();
            static /*0x6fa9d5c*/ MessagePack.IFormatterResolver Create(System.Collections.Generic.IReadOnlyList<MessagePack.Formatters.IMessagePackFormatter> formatters, System.Collections.Generic.IReadOnlyList<MessagePack.IFormatterResolver> resolvers);
            static /*0x6fa9fc4*/ MessagePack.IFormatterResolver Create(MessagePack.Formatters.IMessagePackFormatter[] formatters);

            class CachingResolver : MessagePack.IFormatterResolver
            {
                /*0x10*/ MessagePack.Internal.ThreadsafeTypeKeyHashTable<MessagePack.Formatters.IMessagePackFormatter> formattersCache;
                /*0x18*/ MessagePack.Formatters.IMessagePackFormatter[] subFormatters;
                /*0x20*/ MessagePack.IFormatterResolver[] subResolvers;

                /*0x6fa9e80*/ CachingResolver(MessagePack.Formatters.IMessagePackFormatter[] subFormatters, MessagePack.IFormatterResolver[] subResolvers);
                /*0x380b9e8*/ MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();
            }
        }

        class DynamicGenericResolver : MessagePack.IFormatterResolver
        {
            static /*0x0*/ MessagePack.Resolvers.DynamicGenericResolver Instance;

            static /*0x6faa16c*/ DynamicGenericResolver();
            /*0x6faa164*/ DynamicGenericResolver();
            /*0x380b9e8*/ MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static /*0x38358cc*/ FormatterCache();
            }
        }

        class DynamicObjectResolver : MessagePack.IFormatterResolver
        {
            static /*0x0*/ MessagePack.Resolvers.DynamicObjectResolver Instance;
            static /*0x8*/ MessagePack.MessagePackSerializerOptions Options;
            static /*0x10*/ MessagePack.Internal.DynamicAssemblyFactory DynamicAssemblyFactory;

            static /*0x6faa1d4*/ DynamicObjectResolver();
            static /*0x3907c14*/ MessagePack.Formatters.IMessagePackFormatter<T> BuildFormatterHelper<T>(MessagePack.IFormatterResolver self, MessagePack.Internal.DynamicAssemblyFactory dynamicAssemblyFactory, bool forceStringKey, bool contractless, bool allowPrivate);
            /*0x6faa2e0*/ DynamicObjectResolver();
            /*0x380b9e8*/ MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static /*0x38358cc*/ FormatterCache();
            }

            class <>c__7<T>
            {
                static /*0x0*/ MessagePack.Resolvers.DynamicObjectResolver.<>c__7<T> <>9;
                static /*0x0*/ System.Func<MessagePack.MessagePackObjectAttribute, bool> <>9__7_0;

                static /*0x38358cc*/ <>c__7();
                /*0x380cb08*/ <>c__7();
                /*0x380b2f0*/ bool <BuildFormatterHelper>b__7_0(MessagePack.MessagePackObjectAttribute a);
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

            static /*0x6faa3d4*/ DynamicUnionResolver();
            static /*0x6fab0bc*/ System.Reflection.TypeInfo BuildType(System.Type type);
            static /*0x6fac098*/ void BuildConstructor(System.Type type, MessagePack.UnionAttribute[] infos, System.Reflection.ConstructorInfo method, System.Reflection.Emit.FieldBuilder typeToKeyAndJumpMap, System.Reflection.Emit.FieldBuilder keyToJumpMap, System.Reflection.Emit.ILGenerator il);
            static /*0x6fac450*/ void BuildSerialize(System.Type type, MessagePack.UnionAttribute[] infos, System.Reflection.Emit.MethodBuilder method, System.Reflection.Emit.FieldBuilder typeToKeyAndJumpMap, System.Reflection.Emit.ILGenerator il);
            static /*0x6facd94*/ void BuildDeserialize(System.Type type, MessagePack.UnionAttribute[] infos, System.Reflection.Emit.MethodBuilder method, System.Reflection.Emit.FieldBuilder keyToJumpMap, System.Reflection.Emit.ILGenerator il);
            static /*0x6fadf20*/ bool IsZeroStartSequential(MessagePack.UnionAttribute[] infos);
            /*0x6fab0b4*/ DynamicUnionResolver();
            /*0x380b9e8*/ MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static /*0x38358cc*/ FormatterCache();
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

                static /*0x6fadfb0*/ MessagePackReaderTypeInfo();
            }

            class MessagePackWriterTypeInfo
            {
                static /*0x0*/ System.Reflection.TypeInfo WriterTypeInfo;
                static /*0x8*/ System.Reflection.MethodInfo WriteArrayHeader;
                static /*0x10*/ System.Reflection.MethodInfo WriteInt32;
                static /*0x18*/ System.Reflection.MethodInfo WriteNil;

                static /*0x6fae298*/ MessagePackWriterTypeInfo();
            }

            class <>c
            {
                static /*0x0*/ MessagePack.Resolvers.DynamicUnionResolver.<> <>9;
                static /*0x8*/ System.Func<MessagePack.UnionAttribute, int> <>9__9_0;
                static /*0x10*/ System.Func<<>f__AnonymousType0<System.Reflection.Emit.Label, MessagePack.UnionAttribute>, System.Reflection.Emit.Label> <>9__11_1;
                static /*0x18*/ System.Func<<>f__AnonymousType0<System.Reflection.Emit.Label, MessagePack.UnionAttribute>, System.Reflection.Emit.Label> <>9__12_1;

                static /*0x6fae518*/ <>c();
                /*0x6fae580*/ <>c();
                /*0x6fae588*/ bool <.cctor>b__5_0(System.Reflection.MethodInfo x);
                /*0x6fae5e8*/ System.Reflection.MethodInfo <.cctor>b__5_1(System.Type t);
                /*0x6fae820*/ System.Reflection.MethodInfo <.cctor>b__5_2(System.Type t);
                /*0x6faea24*/ bool <.cctor>b__5_3(System.Reflection.ConstructorInfo x);
                /*0x6faea60*/ bool <.cctor>b__5_4(System.Reflection.ConstructorInfo x);
                /*0x6faeb04*/ bool <.cctor>b__5_5(System.Reflection.ConstructorInfo x);
                /*0x6faeba8*/ bool <.cctor>b__5_6(System.Reflection.ConstructorInfo x);
                /*0x6faec4c*/ bool <.cctor>b__5_7(System.Reflection.ConstructorInfo x);
                /*0x6faec88*/ int <BuildType>b__9_0(MessagePack.UnionAttribute x);
                /*0x6faeca0*/ System.Reflection.Emit.Label <BuildSerialize>b__11_1(<>f__AnonymousType0<System.Reflection.Emit.Label, MessagePack.UnionAttribute> x);
                /*0x6faece4*/ System.Reflection.Emit.Label <BuildDeserialize>b__12_1(<>f__AnonymousType0<System.Reflection.Emit.Label, MessagePack.UnionAttribute> x);
            }

            class <>c__DisplayClass11_0
            {
                /*0x10*/ System.Reflection.Emit.ILGenerator il;

                /*0x6fadda8*/ <>c__DisplayClass11_0();
                /*0x6faed28*/ <>f__AnonymousType0<System.Reflection.Emit.Label, MessagePack.UnionAttribute> <BuildSerialize>b__0(MessagePack.UnionAttribute x);
            }

            class <>c__DisplayClass12_0
            {
                /*0x10*/ System.Reflection.Emit.ILGenerator il;

                /*0x6faded8*/ <>c__DisplayClass12_0();
                /*0x6faedc0*/ <>f__AnonymousType0<System.Reflection.Emit.Label, MessagePack.UnionAttribute> <BuildDeserialize>b__0(MessagePack.UnionAttribute x);
            }
        }

        class MessagePackDynamicUnionResolverException : MessagePack.MessagePackSerializationException
        {
            /*0x6fabd80*/ MessagePackDynamicUnionResolverException(string message);
        }

        class PrimitiveObjectResolver : MessagePack.IFormatterResolver
        {
            static /*0x0*/ MessagePack.Resolvers.PrimitiveObjectResolver Instance;
            static /*0x8*/ MessagePack.MessagePackSerializerOptions Options;

            static /*0x6faee58*/ PrimitiveObjectResolver();
            /*0x6faef0c*/ PrimitiveObjectResolver();
            /*0x380b9e8*/ MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static /*0x38358cc*/ FormatterCache();
            }
        }

        class SourceGeneratedFormatterResolver : MessagePack.IFormatterResolver
        {
            static /*0x0*/ MessagePack.Resolvers.SourceGeneratedFormatterResolver Instance;
            static /*0x8*/ System.Collections.Concurrent.ConcurrentDictionary<System.Reflection.Assembly, MessagePack.IFormatterResolver> AssemblyResolverCache;

            static /*0x6faef1c*/ SourceGeneratedFormatterResolver();
            /*0x6faef14*/ SourceGeneratedFormatterResolver();
            /*0x380b9e8*/ MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static /*0x38358cc*/ FormatterCache();
                static /*0x382dee4*/ MessagePack.Formatters.IMessagePackFormatter<T> FindPrecompiledFormatter();

                class <>c<T>
                {
                    static /*0x0*/ MessagePack.Resolvers.SourceGeneratedFormatterResolver.FormatterCache.<>c<T> <>9;
                    static /*0x0*/ System.Func<System.Reflection.Assembly, MessagePack.IFormatterResolver> <>9__1_0;

                    static /*0x38358cc*/ <>c();
                    /*0x380cb08*/ <>c();
                    /*0x380bb68*/ MessagePack.IFormatterResolver <FindPrecompiledFormatter>b__1_0(System.Reflection.Assembly assembly);
                }
            }
        }

        class StandardResolver : MessagePack.IFormatterResolver
        {
            static /*0x0*/ MessagePack.Resolvers.StandardResolver Instance;
            static /*0x8*/ MessagePack.MessagePackSerializerOptions Options;
            static /*0x10*/ MessagePack.IFormatterResolver[] Resolvers;

            static /*0x6faefdc*/ StandardResolver();
            /*0x6faf300*/ StandardResolver();
            /*0x380b9e8*/ MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static /*0x38358cc*/ FormatterCache();
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

            static /*0x6fb127c*/ LZ4Codec();
            static /*0x6faf308*/ int MaximumOutputLength(int inputLength);
            static /*0x6faf38c*/ int Encode(System.ReadOnlySpan<byte> input, System.Span<byte> output);
            static /*0x6fb0ba4*/ int Decode(System.ReadOnlySpan<byte> input, System.Span<byte> output);
            static /*0x6fb0124*/ int LZ4_compressCtx_32(uint* hash_table, byte* src, byte* dst, int src_len, int dst_maxlen);
            static /*0x6faf65c*/ int LZ4_compress64kCtx_32(ushort* hash_table, byte* src, byte* dst, int src_len, int dst_maxlen);
            static /*0x6fb0d1c*/ int LZ4_uncompress_32(byte* src, byte* dst, int dst_len);
            static /*0x6fb1158*/ void BlockCopy32(byte* src, byte* dst, int len);
            static /*0x6fb065c*/ int LZ4_compressCtx_64(uint* hash_table, byte* src, byte* dst, int src_len, int dst_maxlen);
            static /*0x6fafb4c*/ int LZ4_compress64kCtx_64(ushort* hash_table, byte* src, byte* dst, int src_len, int dst_maxlen);
            static /*0x6fb0f34*/ int LZ4_uncompress_64(byte* src, byte* dst, int dst_len);
            static /*0x6fb11e0*/ void BlockCopy64(byte* src, byte* dst, int len);

            class HashTablePool
            {
                [ThreadStatic] static ushort[] ushortPool;
                [ThreadStatic] static uint[] uintPool;

                static /*0x6faf588*/ ushort[] GetUShortHashTablePool();
                static /*0x6fb004c*/ uint[] GetUIntHashTablePool();
            }
        }
    }

    namespace Internal
    {
        class AutomataDictionary : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, int>>, System.Collections.IEnumerable
        {
            /*0x10*/ MessagePack.Internal.AutomataDictionary.AutomataNode root;

            static /*0x6fb1e9c*/ void ToStringCore(System.Collections.Generic.IEnumerable<MessagePack.Internal.AutomataDictionary.AutomataNode> nexts, System.Text.StringBuilder sb, int depth);
            static /*0x6fb23d8*/ System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, int>> YieldCore(System.Collections.Generic.IEnumerable<MessagePack.Internal.AutomataDictionary.AutomataNode> nexts);
            /*0x6fb13f0*/ AutomataDictionary();
            /*0x6fb159c*/ void Add(string str, int value);
            /*0x6fb1da0*/ string ToString();
            /*0x6fb2324*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x6fb2328*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, int>> GetEnumerator();
            /*0x6fb2488*/ void EmitMatch(System.Reflection.Emit.ILGenerator il, System.Reflection.Emit.LocalBuilder bytesSpan, System.Reflection.Emit.LocalBuilder key, System.Action<System.Collections.Generic.KeyValuePair<string, int>> onFound, System.Action onNotFound);

            class AutomataNode : System.IComparable<MessagePack.Internal.AutomataDictionary.AutomataNode>
            {
                /*0x10*/ ulong Key;
                /*0x18*/ int Value;
                /*0x20*/ string OriginalKey;
                /*0x28*/ MessagePack.Internal.AutomataDictionary.AutomataNode[] nexts;
                /*0x30*/ ulong[] nextKeys;
                /*0x38*/ int count;

                static /*0x6fb265c*/ void EmitSearchNextCore(System.Reflection.Emit.ILGenerator il, System.Reflection.Emit.LocalBuilder bytesSpan, System.Reflection.Emit.LocalBuilder key, System.Action<System.Collections.Generic.KeyValuePair<string, int>> onFound, System.Action onNotFound, MessagePack.Internal.AutomataDictionary.AutomataNode[] nexts, int count);
                /*0x6fb145c*/ AutomataNode(ulong key);
                /*0x6fb2564*/ bool get_HasChildren();
                /*0x6fb1b40*/ MessagePack.Internal.AutomataDictionary.AutomataNode Add(ulong key);
                /*0x6fb1b00*/ MessagePack.Internal.AutomataDictionary.AutomataNode Add(ulong key, int value, string originalKey);
                /*0x6fb2574*/ int CompareTo(MessagePack.Internal.AutomataDictionary.AutomataNode other);
                /*0x6fb1e20*/ System.Collections.Generic.IEnumerable<MessagePack.Internal.AutomataDictionary.AutomataNode> YieldChildren();
                /*0x6fb24a0*/ void EmitSearchNext(System.Reflection.Emit.ILGenerator il, System.Reflection.Emit.LocalBuilder bytesSpan, System.Reflection.Emit.LocalBuilder key, System.Action<System.Collections.Generic.KeyValuePair<string, int>> onFound, System.Action onNotFound);

                class <>c
                {
                    static /*0x0*/ MessagePack.Internal.AutomataDictionary.AutomataNode.<> <>9;
                    static /*0x8*/ System.Func<MessagePack.Internal.AutomataDictionary.AutomataNode, bool> <>9__16_0;
                    static /*0x10*/ System.Func<MessagePack.Internal.AutomataDictionary.AutomataNode, bool> <>9__16_1;

                    static /*0x6fb3204*/ <>c();
                    /*0x6fb326c*/ <>c();
                    /*0x6fb3274*/ bool <EmitSearchNextCore>b__16_0(MessagePack.Internal.AutomataDictionary.AutomataNode x);
                    /*0x6fb3294*/ bool <EmitSearchNextCore>b__16_1(MessagePack.Internal.AutomataDictionary.AutomataNode x);
                }

                class <>c__DisplayClass16_0
                {
                    /*0x10*/ System.Reflection.Emit.ILGenerator il;

                    /*0x6fb317c*/ <>c__DisplayClass16_0();
                    /*0x6fb32b4*/ System.Reflection.Emit.Label <EmitSearchNextCore>b__3(int _);
                    /*0x6fb32dc*/ System.Reflection.Emit.Label <EmitSearchNextCore>b__2(int _);
                }

                class <YieldChildren>d__14 : System.Collections.Generic.IEnumerable<MessagePack.Internal.AutomataDictionary.AutomataNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<MessagePack.Internal.AutomataDictionary.AutomataNode>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ MessagePack.Internal.AutomataDictionary.AutomataNode <>2__current;
                    /*0x20*/ int <>l__initialThreadId;
                    /*0x28*/ MessagePack.Internal.AutomataDictionary.AutomataNode <>4__this;
                    /*0x30*/ int <i>5__2;

                    /*0x6fb2628*/ <YieldChildren>d__14(int <>1__state);
                    /*0x6fb3304*/ void System.IDisposable.Dispose();
                    /*0x6fb3308*/ bool MoveNext();
                    /*0x6fb33e8*/ MessagePack.Internal.AutomataDictionary.AutomataNode System.Collections.Generic.IEnumerator<MessagePack.Internal.AutomataDictionary.AutomataNode>.get_Current();
                    /*0x6fb33f0*/ void System.Collections.IEnumerator.Reset();
                    /*0x6fb3428*/ object System.Collections.IEnumerator.get_Current();
                    /*0x6fb3430*/ System.Collections.Generic.IEnumerator<MessagePack.Internal.AutomataDictionary.AutomataNode> System.Collections.Generic.IEnumerable<MessagePack.Internal.AutomataDictionary.AutomataNode>.GetEnumerator();
                    /*0x6fb34d4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
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

                /*0x6fb2454*/ <YieldCore>d__9(int <>1__state);
                /*0x6fb34d8*/ void System.IDisposable.Dispose();
                /*0x6fb358c*/ bool MoveNext();
                /*0x6fb3b4c*/ void <>m__Finally1();
                /*0x6fb3a9c*/ void <>m__Finally2();
                /*0x6fb3bfc*/ System.Collections.Generic.KeyValuePair<string, int> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Int32>>.get_Current();
                /*0x6fb3c08*/ void System.Collections.IEnumerator.Reset();
                /*0x6fb3c40*/ object System.Collections.IEnumerator.get_Current();
                /*0x6fb3c9c*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, int>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Int32>>.GetEnumerator();
                /*0x6fb3d40*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class AutomataKeyGen
        {
            static /*0x0*/ System.Reflection.MethodInfo GetKeyMethod;

            static /*0x6fb3d44*/ AutomataKeyGen();
            static /*0x6fb16a8*/ ulong GetKey(ref System.ReadOnlySpan<byte> span);
        }

        class CodeGenHelpers
        {
            static /*0x6fb3f00*/ byte[] GetEncodedStringBytes(string value);
            static /*0x6fb41e0*/ System.ReadOnlySpan<byte> ReadStringSpan(ref MessagePack.MessagePackReader reader);
            static /*0x6fb43c8*/ byte[] GetArrayFromNullableSequence(ref System.Nullable<System.Buffers.ReadOnlySequence<byte>> sequence);
        }

        class DateTimeConstants
        {
            static /*0x0*/ System.DateTime UnixEpoch;

            static /*0x6fb445c*/ DateTimeConstants();
        }

        class DynamicAssembly
        {
            static /*0x0*/ bool AvoidDynamicCode;
            /*0x10*/ System.Reflection.Emit.AssemblyBuilder assemblyBuilder;
            /*0x18*/ System.Reflection.Emit.ModuleBuilder moduleBuilder;

            static /*0x6fb460c*/ DynamicAssembly();
            /*0x6fb44d8*/ DynamicAssembly(string moduleName, System.Collections.Immutable.ImmutableHashSet<System.Reflection.AssemblyName> skipVisibilityChecksTo);
            /*0x6fac07c*/ System.Reflection.Emit.TypeBuilder DefineType(string name, System.Reflection.TypeAttributes attr, System.Type parent, System.Type[] interfaces);
        }

        class DynamicAssemblyFactory
        {
            /*0x10*/ string moduleName;
            /*0x18*/ MessagePack.Internal.DynamicAssembly singletonAssembly;
            /*0x20*/ System.Collections.Immutable.ImmutableHashSet<System.Reflection.AssemblyName> lastCreatedDynamicAssemblySkipVisibilityChecks;

            /*0x6faa2e8*/ DynamicAssemblyFactory(string moduleName);
            /*0x6fabd88*/ MessagePack.Internal.DynamicAssembly GetDynamicAssembly(System.Type type, bool allowPrivate);
            /*0x6fb4664*/ MessagePack.Internal.DynamicAssembly <GetDynamicAssembly>g__NewAssembly|4_0();
        }

        class ExpressionUtility
        {
            static /*0x6fb46c8*/ System.Reflection.MethodInfo GetMethodInfoCore(System.Linq.Expressions.LambdaExpression expression);
            static /*0x382eaf0*/ System.Reflection.MethodInfo GetMethodInfo<T>(System.Linq.Expressions.Expression<System.Func<T>> expression);
            static /*0x382eaf0*/ System.Reflection.MethodInfo GetMethodInfo<T, TR>(System.Linq.Expressions.Expression<System.Func<T, TR>> expression);
            static /*0x382eaf0*/ System.Reflection.MemberInfo GetMemberInfoCore<T>(System.Linq.Expressions.Expression<T> source);
            static /*0x382eaf0*/ System.Reflection.PropertyInfo GetPropertyInfo<T, TR>(System.Linq.Expressions.Expression<System.Func<T, TR>> expression);
        }

        class GeneratedAssemblyMessagePackResolverAttribute : System.Attribute
        {
            /*0x10*/ System.Type <ResolverType>k__BackingField;
            /*0x18*/ int <MajorVersion>k__BackingField;
            /*0x1c*/ int <MinorVersion>k__BackingField;

            /*0x6fb4794*/ GeneratedAssemblyMessagePackResolverAttribute(System.Type resolverType, int majorVersion, int minorVersion);
            /*0x6fb47dc*/ System.Type get_ResolverType();
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

            static /*0x6fb47e4*/ System.ReadOnlySpan<byte> GetByteToHexStringHigh();
            static /*0x6fb4834*/ System.ReadOnlySpan<byte> GetByteToHexStringLow();
            static /*0x6fb4c18*/ byte Parse(System.ReadOnlySpan<byte> bytes, int highOffset);
            static /*0x6fb4d38*/ byte SwitchParse(byte b);
            /*0x6fb4884*/ GuidBits(ref System.Guid value);
            /*0x6fb4894*/ GuidBits(System.ReadOnlySpan<byte> utf8string);
            /*0x6fb4de0*/ void Write(System.Span<byte> buffer);
        }

        struct ArgumentField
        {
            /*0x10*/ int i;
            /*0x14*/ bool ref;
            /*0x18*/ System.Reflection.Emit.ILGenerator il;

            /*0x6fadee0*/ ArgumentField(System.Reflection.Emit.ILGenerator il, int i, bool ref);
            /*0x6fb518c*/ ArgumentField(System.Reflection.Emit.ILGenerator il, int i, System.Type type);
            /*0x6fb521c*/ void EmitLoad();
            /*0x6fadf10*/ void EmitLdarg();
        }

        class ILGeneratorExtensions
        {
            static /*0x6fb52e0*/ void EmitLdloc(System.Reflection.Emit.ILGenerator il, int index);
            static /*0x6fadea4*/ void EmitLdloc(System.Reflection.Emit.ILGenerator il, System.Reflection.Emit.LocalBuilder local);
            static /*0x6fb5490*/ void EmitStloc(System.Reflection.Emit.ILGenerator il, int index);
            static /*0x6faddb0*/ void EmitStloc(System.Reflection.Emit.ILGenerator il, System.Reflection.Emit.LocalBuilder local);
            static /*0x6fb5640*/ void EmitLdloca(System.Reflection.Emit.ILGenerator il, int index);
            static /*0x6fade70*/ void EmitLdloca(System.Reflection.Emit.ILGenerator il, System.Reflection.Emit.LocalBuilder local);
            static /*0x6fb5704*/ void EmitTrue(System.Reflection.Emit.ILGenerator il);
            static /*0x6fb570c*/ void EmitBoolean(System.Reflection.Emit.ILGenerator il, bool value);
            static /*0x6fada08*/ void EmitLdc_I4(System.Reflection.Emit.ILGenerator il, int value);
            static /*0x6fb5714*/ void EmitBoxOrDoNothing(System.Reflection.Emit.ILGenerator il, System.Type type);
            static /*0x6fad874*/ void EmitLdarg(System.Reflection.Emit.ILGenerator il, int index);
            static /*0x6fadde4*/ void EmitLoadThis(System.Reflection.Emit.ILGenerator il);
            static /*0x6fb5238*/ void EmitLdarga(System.Reflection.Emit.ILGenerator il, int index);
            static /*0x6fadcdc*/ void EmitCall(System.Reflection.Emit.ILGenerator il, System.Reflection.MethodInfo methodInfo);
            static /*0x6faddec*/ void EmitLdfld(System.Reflection.Emit.ILGenerator il, System.Reflection.FieldInfo fieldInfo);
            static /*0x6fb57b8*/ void EmitLdsfld(System.Reflection.Emit.ILGenerator il, System.Reflection.FieldInfo fieldInfo);
            static /*0x6fb3184*/ void EmitULong(System.Reflection.Emit.ILGenerator il, ulong value);
            static /*0x6fb583c*/ void EmitIncrementFor(System.Reflection.Emit.ILGenerator il, System.Reflection.Emit.LocalBuilder conditionGreater, System.Action<System.Reflection.Emit.LocalBuilder> emitBody);
        }

        class PreserveAttribute : System.Attribute
        {
            /*0x6fb5a10*/ PreserveAttribute();
        }

        class ReflectionExtensions
        {
            static /*0x6fb5a18*/ bool IsNullable(System.Reflection.TypeInfo type);
            static /*0x6fb5ad8*/ bool IsAnonymous(System.Reflection.TypeInfo type);
            static /*0x6fb5c48*/ bool IsIndexer(System.Reflection.PropertyInfo propertyInfo);
            static /*0x6fb5c7c*/ bool IsConstructedGenericType(System.Reflection.TypeInfo type);
        }

        class RuntimeTypeHandleEqualityComparer : System.Collections.Generic.IEqualityComparer<System.RuntimeTypeHandle>
        {
            static /*0x0*/ System.Collections.Generic.IEqualityComparer<System.RuntimeTypeHandle> Default;

            static /*0x6fb5cf8*/ RuntimeTypeHandleEqualityComparer();
            /*0x6fb5cb0*/ RuntimeTypeHandleEqualityComparer();
            /*0x6fb5cb8*/ bool Equals(System.RuntimeTypeHandle x, System.RuntimeTypeHandle y);
            /*0x6fb5cdc*/ int GetHashCode(System.RuntimeTypeHandle obj);
        }

        class ThreadsafeTypeKeyHashTable<TValue>
        {
            /*0x0*/ MessagePack.Internal.ThreadsafeTypeKeyHashTable.Entry<TValue> buckets;
            /*0x0*/ int size;
            /*0x0*/ object writerLock;
            /*0x0*/ float loadFactor;

            static /*0x3907c14*/ int CalculateCapacity(int collectionSize, float loadFactor);
            static /*0x383af28*/ void VolatileWrite(ref MessagePack.Internal.ThreadsafeTypeKeyHashTable.Entry<TValue> location, MessagePack.Internal.ThreadsafeTypeKeyHashTable.Entry<TValue> value);
            static /*0x383af28*/ void VolatileWrite(ref MessagePack.Internal.ThreadsafeTypeKeyHashTable.Entry<TValue> location, MessagePack.Internal.ThreadsafeTypeKeyHashTable.Entry<TValue> value);
            /*0x380d250*/ ThreadsafeTypeKeyHashTable(int capacity, float loadFactor);
            /*0x3907c14*/ bool TryAdd(System.Type key, TValue value);
            /*0x380b32c*/ bool TryAdd(System.Type key, System.Func<System.Type, TValue> valueFactory);
            bool TryAddInternal(System.Type key, System.Func<System.Type, TValue> valueFactory, ref TValue resultingValue);
            /*0x380b3b4*/ bool AddToBuckets(MessagePack.Internal.ThreadsafeTypeKeyHashTable.Entry<TValue> buckets, System.Type newKey, MessagePack.Internal.ThreadsafeTypeKeyHashTable.Entry<TValue> newEntryOrNull, System.Func<System.Type, TValue> valueFactory, ref TValue resultingValue);
            /*0x380b32c*/ bool TryGetValue(System.Type key, ref TValue value);

            class Entry<TValue>
            {
                /*0x0*/ MessagePack.Internal.ThreadsafeTypeKeyHashTable.Entry<TValue> Next;
                /*0x0*/ System.Type <Key>k__BackingField;
                /*0x0*/ TValue <Value>k__BackingField;
                /*0x0*/ int <Hash>k__BackingField;

                /*0x3907c14*/ Entry(System.Type key, TValue value, int hash);
                /*0x380b9e8*/ System.Type get_Key();
                /*0x3907c14*/ TValue get_Value();
                /*0x380b6a0*/ int get_Hash();
                /*0x380b9e8*/ string ToString();
                /*0x380b6a0*/ int Count();
            }

            class <>c__DisplayClass5_0<TValue>
            {
                /*0x0*/ TValue value;

                /*0x380cb08*/ <>c__DisplayClass5_0();
                /*0x3907c14*/ TValue <TryAdd>b__0(System.Type _);
            }
        }

        class UnsafeMemory32
        {
            static /*0x6fb5d60*/ void WriteRaw4(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb5dd8*/ void WriteRaw5(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb5e64*/ void WriteRaw6(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb5ef0*/ void WriteRaw7(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb5f7c*/ void WriteRaw8(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb6008*/ void WriteRaw9(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb609c*/ void WriteRaw10(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb6130*/ void WriteRaw11(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb61c4*/ void WriteRaw12(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb6258*/ void WriteRaw13(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb62f4*/ void WriteRaw14(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb6390*/ void WriteRaw15(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb642c*/ void WriteRaw16(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb64c8*/ void WriteRaw17(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb656c*/ void WriteRaw18(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb6610*/ void WriteRaw19(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb66b4*/ void WriteRaw20(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb6758*/ void WriteRaw21(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb6804*/ void WriteRaw22(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb68b0*/ void WriteRaw23(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb695c*/ void WriteRaw24(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb6a08*/ void WriteRaw25(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb6abc*/ void WriteRaw26(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb6b70*/ void WriteRaw27(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb6c24*/ void WriteRaw28(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb6cd8*/ void WriteRaw29(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb6d94*/ void WriteRaw30(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb6e50*/ void WriteRaw31(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb6f0c*/ void WriteRaw1(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb6f84*/ void WriteRaw2(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb6ffc*/ void WriteRaw3(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
        }

        class UnsafeMemory64
        {
            static /*0x6fb7088*/ void WriteRaw8(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb7100*/ void WriteRaw9(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb718c*/ void WriteRaw10(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb7218*/ void WriteRaw11(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb72a4*/ void WriteRaw12(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb7330*/ void WriteRaw13(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb73bc*/ void WriteRaw14(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb7448*/ void WriteRaw15(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb74d4*/ void WriteRaw16(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb7560*/ void WriteRaw17(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb75f4*/ void WriteRaw18(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb7688*/ void WriteRaw19(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb771c*/ void WriteRaw20(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb77b0*/ void WriteRaw21(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb7844*/ void WriteRaw22(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb78d8*/ void WriteRaw23(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb796c*/ void WriteRaw24(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb7a00*/ void WriteRaw25(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb7a9c*/ void WriteRaw26(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb7b38*/ void WriteRaw27(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb7bd4*/ void WriteRaw28(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb7c70*/ void WriteRaw29(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb7d0c*/ void WriteRaw30(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb7da8*/ void WriteRaw31(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb7e44*/ void WriteRaw1(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb7ebc*/ void WriteRaw2(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb7f34*/ void WriteRaw3(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb7fc0*/ void WriteRaw4(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb8038*/ void WriteRaw5(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb80c4*/ void WriteRaw6(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
            static /*0x6fb8150*/ void WriteRaw7(ref MessagePack.MessagePackWriter writer, System.ReadOnlySpan<byte> src);
        }

        class UnsafeMemory
        {
            static /*0x0*/ bool Is32Bit;

            static /*0x6fb81dc*/ UnsafeMemory();
        }

        class UnsafeRefDeserializeHelper
        {
            static /*0x6fb8234*/ int Deserialize(ref byte input, int length, ref bool output);
        }

        class UnsafeRefSerializeHelper
        {
            static /*0x6fb82c0*/ void Serialize(ref MessagePack.MessagePackWriter writer, ref bool input, int length);
            static /*0x6fb8384*/ void Serialize(ref MessagePack.MessagePackWriter writer, ref sbyte input, int length);
            static /*0x6fb84cc*/ void BigEndianSerialize(ref MessagePack.MessagePackWriter writer, ref sbyte input, int length);
            static /*0x6fb8388*/ void LittleEndianSerialize(ref MessagePack.MessagePackWriter writer, ref sbyte input, int length);
            static /*0x6fb8538*/ void Serialize(ref MessagePack.MessagePackWriter writer, ref short input, int length);
            static /*0x6fb86ec*/ void BigEndianSerialize(ref MessagePack.MessagePackWriter writer, ref short input, int length);
            static /*0x6fb853c*/ void LittleEndianSerialize(ref MessagePack.MessagePackWriter writer, ref short input, int length);
            static /*0x6fb8758*/ void Serialize(ref MessagePack.MessagePackWriter writer, ref char input, int length);
            static /*0x6fb875c*/ void Serialize(ref MessagePack.MessagePackWriter writer, ref ushort input, int length);
            static /*0x6fb88d0*/ void BigEndianSerialize(ref MessagePack.MessagePackWriter writer, ref ushort input, int length);
            static /*0x6fb8760*/ void LittleEndianSerialize(ref MessagePack.MessagePackWriter writer, ref ushort input, int length);
            static /*0x6fb893c*/ void Serialize(ref MessagePack.MessagePackWriter writer, ref int input, int length);
            static /*0x6fb8b24*/ void BigEndianSerialize(ref MessagePack.MessagePackWriter writer, ref int input, int length);
            static /*0x6fb8940*/ void LittleEndianSerialize(ref MessagePack.MessagePackWriter writer, ref int input, int length);
            static /*0x6fb8b90*/ void Serialize(ref MessagePack.MessagePackWriter writer, ref uint input, int length);
            static /*0x6fb8d34*/ void BigEndianSerialize(ref MessagePack.MessagePackWriter writer, ref uint input, int length);
            static /*0x6fb8b94*/ void LittleEndianSerialize(ref MessagePack.MessagePackWriter writer, ref uint input, int length);
            static /*0x6fb8da0*/ void Serialize(ref MessagePack.MessagePackWriter writer, ref long input, int length);
            static /*0x6fb8fd8*/ void BigEndianSerialize(ref MessagePack.MessagePackWriter writer, ref long input, int length);
            static /*0x6fb8da4*/ void LittleEndianSerialize(ref MessagePack.MessagePackWriter writer, ref long input, int length);
            static /*0x6fb9044*/ void Serialize(ref MessagePack.MessagePackWriter writer, ref ulong input, int length);
            static /*0x6fb920c*/ void BigEndianSerialize(ref MessagePack.MessagePackWriter writer, ref ulong input, int length);
            static /*0x6fb9048*/ void LittleEndianSerialize(ref MessagePack.MessagePackWriter writer, ref ulong input, int length);
            static /*0x6fb9278*/ void Serialize(ref MessagePack.MessagePackWriter writer, ref float input, int length);
            static /*0x6fb93b0*/ void BigEndianSerialize(ref MessagePack.MessagePackWriter writer, ref float input, int length);
            static /*0x6fb927c*/ void LittleEndianSerialize(ref MessagePack.MessagePackWriter writer, ref float input, int length);
            static /*0x6fb94e0*/ void Serialize(ref MessagePack.MessagePackWriter writer, ref double input, int length);
            static /*0x6fb9618*/ void BigEndianSerialize(ref MessagePack.MessagePackWriter writer, ref double input, int length);
            static /*0x6fb94e4*/ void LittleEndianSerialize(ref MessagePack.MessagePackWriter writer, ref double input, int length);
            static /*0x6fb9748*/ nuint ReverseWriteUnknown(ref byte destination, byte value);
            static /*0x6fb976c*/ nuint ReverseWriteUnknown(ref byte destination, sbyte value);
            static /*0x6fb9798*/ nuint ReverseWriteUnknown(ref byte destination, ushort value);
            static /*0x6fb97e4*/ nuint ReverseWriteUnknown(ref byte destination, short value);
            static /*0x6fb985c*/ nuint ReverseWriteUnknown(ref byte destination, uint value);
            static /*0x6fb98c8*/ nuint ReverseWriteUnknown(ref byte destination, int value);
            static /*0x6fb9970*/ nuint ReverseWriteUnknown(ref byte destination, ulong value);
            static /*0x6fb9a00*/ nuint ReverseWriteUnknown(ref byte destination, long value);
        }

        class BuiltinResolverGetFormatterHelper
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, object> FormatterMap;

            static /*0x6fb9cd4*/ BuiltinResolverGetFormatterHelper();
            static /*0x6fb9aec*/ object GetFormatter(System.Type t);
        }

        class DynamicGenericResolverGetFormatterHelper
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, System.Type> FormatterMap;

            static /*0x6fbf3e8*/ DynamicGenericResolverGetFormatterHelper();
            static /*0x6fbc7fc*/ object GetFormatter(System.Type t);
            static /*0x6fbf3b0*/ object CreateInstance(System.Type genericType, System.Type[] genericTypeArguments, object[] arguments);

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

                static /*0x6fbfe84*/ <>c();
                /*0x6fbfeec*/ <>c();
                /*0x6fbfef4*/ bool <GetFormatter>b__1_0(System.Reflection.ConstructorInfo x);
                /*0x6fbff30*/ bool <GetFormatter>b__1_1(System.Reflection.ConstructorInfo x);
                /*0x6fbff6c*/ bool <GetFormatter>b__1_2(System.Type x);
                /*0x6fc002c*/ bool <GetFormatter>b__1_3(System.Reflection.ConstructorInfo x);
                /*0x6fc0080*/ bool <GetFormatter>b__1_4(System.Type x);
                /*0x6fc0140*/ bool <GetFormatter>b__1_5(System.Type x);
                /*0x6fc0200*/ bool <GetFormatter>b__1_6(System.Reflection.ConstructorInfo x);
                /*0x6fc0254*/ bool <GetFormatter>b__1_8(System.Type x);
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ System.Reflection.ParameterInfo[] parameters;

                /*0x6fbf3e0*/ <>c__DisplayClass1_0();
                /*0x6fc0314*/ bool <GetFormatter>b__7(System.Type allowedType);
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

            static /*0x6fca99c*/ DynamicObjectTypeBuilder();
            static /*0x6fc0364*/ System.Reflection.TypeInfo BuildType(MessagePack.Internal.DynamicAssembly assembly, System.Type type, bool forceStringKey, bool contractless, bool allowPrivate);
            static /*0x6fc3e74*/ void BuildConstructor(System.Type type, MessagePack.Internal.ObjectSerializationInfo info, System.Reflection.ConstructorInfo method, System.Reflection.Emit.FieldBuilder stringByteKeysField, System.Reflection.Emit.ILGenerator il);
            static /*0x6fc4530*/ System.Collections.Generic.Dictionary<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, System.Reflection.FieldInfo> BuildCustomFormatterField(System.Reflection.Emit.TypeBuilder builder, MessagePack.Internal.ObjectSerializationInfo info, System.Reflection.Emit.ILGenerator il);
            static /*0x6fc5178*/ void BuildSerialize(System.Type type, MessagePack.Internal.ObjectSerializationInfo info, System.Reflection.Emit.ILGenerator il, System.Action emitStringByteKeys, System.Func<int, MessagePack.Internal.ObjectSerializationInfo.EmittableMember, System.Action> tryEmitLoadCustomFormatter, int firstArgIndex);
            static /*0x6fc6a44*/ void EmitSerializeValue(System.Reflection.Emit.ILGenerator il, System.Reflection.TypeInfo type, MessagePack.Internal.ObjectSerializationInfo.EmittableMember member, int index, System.Func<int, MessagePack.Internal.ObjectSerializationInfo.EmittableMember, System.Action> tryEmitLoadCustomFormatter, MessagePack.Internal.ArgumentField argWriter, MessagePack.Internal.ArgumentField argValue, MessagePack.Internal.ArgumentField argOptions, System.Reflection.Emit.LocalBuilder localResolver);
            static /*0x6fc6564*/ void BuildDeserialize(System.Type type, MessagePack.Internal.ObjectSerializationInfo info, System.Reflection.Emit.TypeBuilder typeBuilder, System.Reflection.Emit.ILGenerator il, System.Func<int, MessagePack.Internal.ObjectSerializationInfo.EmittableMember, System.Action> tryEmitLoadCustomFormatter, int firstArgIndex);
            static /*0x6fc7b04*/ void BuildDeserializeInternalDeserializeEachPropertyStringKey(MessagePack.Internal.ObjectSerializationInfo info, System.Reflection.Emit.TypeBuilder typeBuilder, System.Reflection.Emit.ILGenerator il, System.Func<int, MessagePack.Internal.ObjectSerializationInfo.EmittableMember, System.Action> tryEmitLoadCustomFormatter, bool canOverwrite, ref MessagePack.Internal.ArgumentField argReader, MessagePack.Internal.ArgumentField argOptions, System.Reflection.Emit.LocalBuilder localResolver, System.Reflection.Emit.LocalBuilder localResult, System.Reflection.Emit.LocalBuilder localLength);
            static /*0x6fc79bc*/ void BuildDeserializeInternalDeserializeEachPropertyIntKey(MessagePack.Internal.ObjectSerializationInfo info, System.Reflection.Emit.TypeBuilder typeBuilder, System.Reflection.Emit.ILGenerator il, System.Func<int, MessagePack.Internal.ObjectSerializationInfo.EmittableMember, System.Action> tryEmitLoadCustomFormatter, bool canOverwrite, ref MessagePack.Internal.ArgumentField argReader, ref MessagePack.Internal.ArgumentField argOptions, System.Reflection.Emit.LocalBuilder localResolver, System.Reflection.Emit.LocalBuilder localResult, System.Reflection.Emit.LocalBuilder localLength);
            static /*0x6fc8934*/ void BuildDeserializeInternalAssignFieldFromLocalVariableStringKey(MessagePack.Internal.ObjectSerializationInfo info, System.Reflection.Emit.TypeBuilder typeBuilder, System.Reflection.Emit.ILGenerator il, MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo[] infoList, System.Reflection.Emit.LocalBuilder localResult);
            static /*0x6fc9140*/ void BuildDeserializeInternalAssignFieldFromLocalVariableIntKey(System.Reflection.Emit.TypeBuilder typeBuilder, MessagePack.Internal.ObjectSerializationInfo info, System.Reflection.Emit.ILGenerator il, MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo[] infoList, System.Reflection.Emit.LocalBuilder localResult, System.Reflection.Emit.LocalBuilder localLength, int maxKey);
            static /*0x6fc8668*/ void BuildDeserializeInternalCreateInstanceWithArguments(MessagePack.Internal.ObjectSerializationInfo info, System.Reflection.Emit.ILGenerator il, MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo[] infoList, System.Reflection.Emit.LocalBuilder localResult);
            static /*0x6fc80b4*/ MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo[] BuildDeserializeInternalDeserializationInfoArrayStringKey(MessagePack.Internal.ObjectSerializationInfo info, System.Reflection.Emit.ILGenerator il, bool canOverwrite);
            static /*0x6fc8ab4*/ MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo[] BuildDeserializeInternalDeserializationInfoArrayIntKey(MessagePack.Internal.ObjectSerializationInfo info, System.Reflection.Emit.ILGenerator il, bool canOverwrite, ref System.Nullable<System.Reflection.Emit.Label> gotoDefault, ref int maxKey);
            static /*0x6fc8f2c*/ void BuildDeserializeInternalDeserializeLoopIntKey(System.Reflection.Emit.TypeBuilder typeBuilder, System.Reflection.Emit.ILGenerator il, System.Func<int, MessagePack.Internal.ObjectSerializationInfo.EmittableMember, System.Action> tryEmitLoadCustomFormatter, ref MessagePack.Internal.ArgumentField argReader, ref MessagePack.Internal.ArgumentField argOptions, MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo[] infoList, System.Reflection.Emit.LocalBuilder localResolver, System.Reflection.Emit.LocalBuilder localResult, System.Reflection.Emit.LocalBuilder localLength, bool canOverwrite, System.Nullable<System.Reflection.Emit.Label> gotoDefault);
            static /*0x6fc8380*/ void BuildDeserializeInternalDeserializeLoopStringKey(System.Reflection.Emit.TypeBuilder typeBuilder, System.Reflection.Emit.ILGenerator il, System.Func<int, MessagePack.Internal.ObjectSerializationInfo.EmittableMember, System.Action> tryEmitLoadCustomFormatter, ref MessagePack.Internal.ArgumentField argReader, ref MessagePack.Internal.ArgumentField argOptions, MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo[] infoList, System.Reflection.Emit.LocalBuilder localResolver, System.Reflection.Emit.LocalBuilder localResult, System.Reflection.Emit.LocalBuilder localLength, bool canOverwrite, MessagePack.Internal.ObjectSerializationInfo info);
            static /*0x6fc7414*/ void BuildDeserializeInternalTryReadNil(System.Type type, System.Reflection.Emit.ILGenerator il, ref MessagePack.Internal.ArgumentField argReader);
            static /*0x6fc7fa0*/ void BuildDeserializeInternalDepthUnStep(System.Reflection.Emit.ILGenerator il, ref MessagePack.Internal.ArgumentField argReader);
            static /*0x6fc7c48*/ void BuildDeserializeInternalOnAfterDeserialize(System.Type type, MessagePack.Internal.ObjectSerializationInfo info, System.Reflection.Emit.ILGenerator il, System.Reflection.Emit.LocalBuilder localResult);
            static /*0x6fc78b4*/ System.Reflection.Emit.LocalBuilder BuildDeserializeInternalResolver(MessagePack.Internal.ObjectSerializationInfo info, System.Reflection.Emit.ILGenerator il, ref MessagePack.Internal.ArgumentField argOptions);
            static /*0x6fc77b8*/ System.Reflection.Emit.LocalBuilder BuildDeserializeInternalReadHeaderLength(MessagePack.Internal.ObjectSerializationInfo info, System.Reflection.Emit.ILGenerator il, ref MessagePack.Internal.ArgumentField argReader);
            static /*0x6fc7714*/ void BuildDeserializeInternalDepthStep(System.Reflection.Emit.ILGenerator il, ref MessagePack.Internal.ArgumentField argReader, ref MessagePack.Internal.ArgumentField argOptions);
            static /*0x6fc7614*/ void BuildDeserializeInternalCreateInstance(System.Type type, MessagePack.Internal.ObjectSerializationInfo info, System.Reflection.Emit.ILGenerator il, System.Reflection.Emit.LocalBuilder localResult);
            static /*0x6fc97b4*/ void BuildDeserializeInternalDeserializeValueAssignDirectly(System.Reflection.Emit.TypeBuilder typeBuilder, System.Reflection.Emit.ILGenerator il, MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo info, int index, System.Func<int, MessagePack.Internal.ObjectSerializationInfo.EmittableMember, System.Action> tryEmitLoadCustomFormatter, ref MessagePack.Internal.ArgumentField argReader, ref MessagePack.Internal.ArgumentField argOptions, System.Reflection.Emit.LocalBuilder localResolver, System.Reflection.Emit.LocalBuilder localResult);
            static /*0x6fca3a0*/ void BuildDeserializeInternalDeserializeValueAssignLocalVariable(System.Reflection.Emit.ILGenerator il, MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo info, int index, System.Func<int, MessagePack.Internal.ObjectSerializationInfo.EmittableMember, System.Action> tryEmitLoadCustomFormatter, ref MessagePack.Internal.ArgumentField argReader, ref MessagePack.Internal.ArgumentField argOptions, System.Reflection.Emit.LocalBuilder localResolver, System.Reflection.Emit.LocalBuilder localResult);

            class MessagePackWriterTypeInfo
            {
                static /*0x0*/ System.Reflection.TypeInfo TypeInfo;
                static /*0x8*/ System.Reflection.MethodInfo WriteMapHeader;
                static /*0x10*/ System.Reflection.MethodInfo WriteArrayHeader;
                static /*0x18*/ System.Reflection.MethodInfo WriteBytes;
                static /*0x20*/ System.Reflection.MethodInfo WriteNil;
                static /*0x28*/ System.Reflection.MethodInfo WriteRaw;

                static /*0x6fcb6fc*/ MessagePackWriterTypeInfo();
            }

            class MessagePackReaderTypeInfo
            {
                static /*0x0*/ System.Reflection.TypeInfo TypeInfo;
                static /*0x8*/ System.Reflection.MethodInfo ReadArrayHeader;
                static /*0x10*/ System.Reflection.MethodInfo ReadMapHeader;
                static /*0x18*/ System.Reflection.MethodInfo ReadBytes;
                static /*0x20*/ System.Reflection.MethodInfo TryReadNil;
                static /*0x28*/ System.Reflection.MethodInfo Skip;

                static /*0x6fcbaf0*/ MessagePackReaderTypeInfo();
            }

            class CodeGenHelpersTypeInfo
            {
                static /*0x0*/ System.Reflection.MethodInfo GetEncodedStringBytes;

                static /*0x6fcbd30*/ CodeGenHelpersTypeInfo();
            }

            class EmitInfo
            {
                static /*0x0*/ System.Reflection.MethodInfo GetTypeFromHandle;
                static /*0x8*/ System.Reflection.MethodInfo TypeGetProperty;
                static /*0x10*/ System.Reflection.MethodInfo TypeGetField;
                static /*0x18*/ System.Reflection.MethodInfo GetCustomAttributeMessagePackFormatterAttribute;
                static /*0x20*/ System.Reflection.MethodInfo ActivatorCreateInstance;

                static /*0x6fcbe78*/ EmitInfo();

                class MessagePackFormatterAttr
                {
                    static /*0x0*/ System.Reflection.MethodInfo FormatterType;
                    static /*0x8*/ System.Reflection.MethodInfo Arguments;

                    static /*0x6fccb2c*/ MessagePackFormatterAttr();
                }
            }

            class DeserializeInfo
            {
                /*0x10*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMember <MemberInfo>k__BackingField;
                /*0x18*/ System.Reflection.Emit.LocalBuilder <LocalVariable>k__BackingField;
                /*0x20*/ System.Reflection.Emit.LocalBuilder <IsInitializedLocalVariable>k__BackingField;
                /*0x28*/ System.Reflection.Emit.Label <SwitchLabel>k__BackingField;

                /*0x6fc978c*/ DeserializeInfo();
                /*0x6fccea0*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMember get_MemberInfo();
                /*0x6fccea8*/ void set_MemberInfo(MessagePack.Internal.ObjectSerializationInfo.EmittableMember value);
                /*0x6fcceb0*/ System.Reflection.Emit.LocalBuilder get_LocalVariable();
                /*0x6fcceb8*/ void set_LocalVariable(System.Reflection.Emit.LocalBuilder value);
                /*0x6fccec0*/ System.Reflection.Emit.LocalBuilder get_IsInitializedLocalVariable();
                /*0x6fccec8*/ void set_IsInitializedLocalVariable(System.Reflection.Emit.LocalBuilder value);
                /*0x6fcced0*/ System.Reflection.Emit.Label get_SwitchLabel();
                /*0x6fcced8*/ void set_SwitchLabel(System.Reflection.Emit.Label value);
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

                static /*0x6fccee0*/ <>c();
                /*0x6fccf48*/ <>c();
                /*0x6fccf50*/ bool <BuildConstructor>b__4_0(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x6fccf68*/ bool <BuildConstructor>b__4_1(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x6fccf80*/ bool <BuildCustomFormatterField>b__5_0(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x6fccfb0*/ bool <BuildSerialize>b__6_0(System.Type x);
                /*0x6fcd024*/ bool <BuildSerialize>b__6_1(System.Reflection.MethodInfo x);
                /*0x6fcd084*/ bool <BuildSerialize>b__6_2(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x6fcd09c*/ int <BuildSerialize>b__6_3(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x6fcd0b4*/ bool <BuildSerialize>b__6_4(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x6fcd0cc*/ int <BuildSerialize>b__6_5(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x6fcd0e4*/ bool <BuildSerialize>b__6_6(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x6fcd0fc*/ bool <BuildSerialize>b__6_7(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x6fcd114*/ bool <BuildDeserializeInternalAssignFieldFromLocalVariableIntKey>b__12_0(MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo x);
                /*0x6fcd144*/ int <BuildDeserializeInternalAssignFieldFromLocalVariableIntKey>b__12_1(MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo x);
                /*0x6fcd164*/ int <BuildDeserializeInternalDeserializationInfoArrayIntKey>b__15_0(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x6fcd17c*/ int <BuildDeserializeInternalDeserializationInfoArrayIntKey>b__15_1(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x6fcd194*/ System.Reflection.Emit.Label <BuildDeserializeInternalDeserializeLoopIntKey>b__16_1(MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo x);
                /*0x6fcd1ac*/ bool <BuildDeserializeInternalOnAfterDeserialize>b__20_0(System.Type x);
                /*0x6fcd220*/ bool <BuildDeserializeInternalOnAfterDeserialize>b__20_1(System.Reflection.MethodInfo x);
                /*0x6fcd280*/ bool <BuildDeserializeInternalDeserializeValueAssignDirectly>b__25_0(System.Reflection.MethodInfo x);
                /*0x6fcd2bc*/ bool <BuildDeserializeInternalDeserializeValueAssignLocalVariable>b__26_0(System.Reflection.MethodInfo x);
                /*0x6fcd2f8*/ bool <.cctor>b__49_0(System.Reflection.MethodInfo x);
                /*0x6fcd358*/ System.Reflection.MethodInfo <.cctor>b__49_1(System.Type t);
                /*0x6fcd590*/ System.Reflection.MethodInfo <.cctor>b__49_2(System.Type t);
                /*0x6fcd78c*/ bool <.cctor>b__49_3(System.Reflection.ConstructorInfo x);
                /*0x6fcd830*/ bool <.cctor>b__49_4(System.Reflection.ConstructorInfo x);
            }

            class <>c__DisplayClass13_0
            {
                /*0x10*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMemberAndConstructorParameter item;

                /*0x6fc9728*/ <>c__DisplayClass13_0();
                /*0x6fcd86c*/ bool <BuildDeserializeInternalCreateInstanceWithArguments>b__0(MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo x);
            }

            class <>c__DisplayClass14_0
            {
                /*0x10*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMember item;

                /*0x6fc9784*/ <>c__DisplayClass14_0();
                /*0x6fcd898*/ bool <BuildDeserializeInternalDeserializationInfoArrayStringKey>b__0(MessagePack.Internal.ObjectSerializationInfo.EmittableMemberAndConstructorParameter p);
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

                /*0x6fc9794*/ <>c__DisplayClass16_0();
                /*0x6fcd8c4*/ void <BuildDeserializeInternalDeserializeLoopIntKey>g__ForBody|0(System.Reflection.Emit.LocalBuilder forILocal);
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

                /*0x6fc979c*/ <>c__DisplayClass17_0();
                /*0x6fcdd84*/ void <BuildDeserializeInternalDeserializeLoopStringKey>g__ForBody|0(System.Reflection.Emit.LocalBuilder forILocal);
            }

            class <>c__DisplayClass17_1
            {
                /*0x10*/ System.Reflection.Emit.Label loopEnd;
                /*0x14*/ System.Reflection.Emit.Label readNext;
                /*0x18*/ MessagePack.Internal.DynamicObjectTypeBuilder.<> CS$<>8__locals1;

                /*0x6fcdffc*/ <>c__DisplayClass17_1();
                /*0x6fce004*/ void <BuildDeserializeInternalDeserializeLoopStringKey>g__OnFoundAssignDirect|1(System.Collections.Generic.KeyValuePair<string, int> x);
                /*0x6fce17c*/ void <BuildDeserializeInternalDeserializeLoopStringKey>g__OnFoundAssignLocalVariable|2(System.Collections.Generic.KeyValuePair<string, int> x);
                /*0x6fce2e4*/ void <BuildDeserializeInternalDeserializeLoopStringKey>g__OnNotFound|3();
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ System.Reflection.Emit.FieldBuilder stringByteKeysField;
                /*0x18*/ System.Collections.Generic.Dictionary<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, System.Reflection.FieldInfo> customFormatterLookup;

                /*0x6fc3e5c*/ <>c__DisplayClass3_0();
            }

            class <>c__DisplayClass3_1
            {
                /*0x10*/ System.Reflection.Emit.ILGenerator il;
                /*0x18*/ MessagePack.Internal.DynamicObjectTypeBuilder.<> CS$<>8__locals1;

                /*0x6fc5170*/ <>c__DisplayClass3_1();
                /*0x6fce364*/ void <BuildType>b__0();
                /*0x6fce398*/ System.Action <BuildType>b__1(int index, MessagePack.Internal.ObjectSerializationInfo.EmittableMember member);
            }

            class <>c__DisplayClass3_2
            {
                /*0x10*/ System.Reflection.FieldInfo fi;
                /*0x18*/ MessagePack.Internal.DynamicObjectTypeBuilder.<> CS$<>8__locals2;

                /*0x6fce498*/ <>c__DisplayClass3_2();
                /*0x6fce4a0*/ void <BuildType>b__2();
            }

            class <>c__DisplayClass3_3
            {
                /*0x10*/ System.Reflection.Emit.ILGenerator il;
                /*0x18*/ MessagePack.Internal.DynamicObjectTypeBuilder.<> CS$<>8__locals3;

                /*0x6fc655c*/ <>c__DisplayClass3_3();
                /*0x6fce4dc*/ System.Action <BuildType>b__3(int index, MessagePack.Internal.ObjectSerializationInfo.EmittableMember member);
            }

            class <>c__DisplayClass3_4
            {
                /*0x10*/ System.Reflection.FieldInfo fi;
                /*0x18*/ MessagePack.Internal.DynamicObjectTypeBuilder.<> CS$<>8__locals4;

                /*0x6fce5dc*/ <>c__DisplayClass3_4();
                /*0x6fce5e4*/ void <BuildType>b__4();
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMember item;

                /*0x6fc68a4*/ <>c__DisplayClass5_0();
                /*0x6fce620*/ bool <BuildCustomFormatterField>b__1(System.Type i);
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

            static /*0x6fc1264*/ MessagePack.Internal.ObjectSerializationInfo CreateOrNull(System.Type type, bool forceStringKey, bool contractless, bool allowPrivate);
            static /*0x6fc70f0*/ bool IsOptimizeTargetType(System.Type type);
            static /*0x6fcf074*/ System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> GetAllFields(System.Type type);
            static /*0x6fceff8*/ System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> GetAllProperties(System.Type type);
            static /*0x6fceba8*/ bool IsClassRecord(System.Reflection.TypeInfo type);
            static /*0x6fcf13c*/ bool TryGetNextConstructor(System.Collections.Generic.IEnumerator<System.Reflection.ConstructorInfo> ctorEnumerator, ref System.Reflection.ConstructorInfo ctor);
            /*0x6fce78c*/ ObjectSerializationInfo(System.Type type, MessagePack.Internal.ObjectSerializationInfo.EmittableMemberAndConstructorParameter[] constructorParameters, MessagePack.Internal.ObjectSerializationInfo.EmittableMember[] members, bool isClass, System.Reflection.ConstructorInfo bestmatchConstructor, bool isIntKey);
            /*0x6fce748*/ System.Type get_Type();
            /*0x6fce750*/ bool get_IsIntKey();
            /*0x6fc3e64*/ bool get_IsStringKey();
            /*0x6fce758*/ bool get_IsClass();
            /*0x6fc97a4*/ bool get_IsStruct();
            /*0x6fce760*/ bool get_ShouldUseFormatterResolver();
            /*0x6fce768*/ void set_ShouldUseFormatterResolver(bool value);
            /*0x6fce774*/ System.Reflection.ConstructorInfo get_BestmatchConstructor();
            /*0x6fce77c*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMemberAndConstructorParameter[] get_ConstructorParameters();
            /*0x6fce784*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMember[] get_Members();

            class EmittableMemberAndConstructorParameter
            {
                /*0x10*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMember <MemberInfo>k__BackingField;
                /*0x18*/ System.Reflection.ParameterInfo <ConstructorParameter>k__BackingField;

                /*0x6fcf0f8*/ EmittableMemberAndConstructorParameter(MessagePack.Internal.ObjectSerializationInfo.EmittableMember memberInfo, System.Reflection.ParameterInfo constructorParameter);
                /*0x6fcf2e8*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMember get_MemberInfo();
                /*0x6fcf2f0*/ System.Reflection.ParameterInfo get_ConstructorParameter();
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

                /*0x6fcf2f8*/ EmittableMember(System.Reflection.MemberInfo memberInfo);
                /*0x6fc6a2c*/ bool get_IsProperty();
                /*0x6fcf328*/ bool get_IsWritable();
                /*0x6fcf330*/ void set_IsWritable(bool value);
                /*0x6fcf33c*/ bool get_IsWrittenByConstructor();
                /*0x6fcf344*/ void set_IsWrittenByConstructor(bool value);
                /*0x6fce990*/ bool get_IsInitOnly();
                /*0x6fcf350*/ bool get_IsReadable();
                /*0x6fcf358*/ void set_IsReadable(bool value);
                /*0x6fcf364*/ int get_IntKey();
                /*0x6fcf36c*/ void set_IntKey(int value);
                /*0x6fcf374*/ string get_StringKey();
                /*0x6fcf37c*/ void set_StringKey(string value);
                /*0x6fc695c*/ System.Type get_Type();
                /*0x6fcf384*/ System.Reflection.MemberInfo get_MemberInfo();
                /*0x6fcec24*/ System.Reflection.FieldInfo get_FieldInfo();
                /*0x6fc6914*/ string get_Name();
                /*0x6fceb24*/ System.Reflection.PropertyInfo get_PropertyInfo();
                /*0x6fc9730*/ bool get_IsValueType();
                /*0x6fcf38c*/ bool get_IsExplicitContract();
                /*0x6fcf394*/ void set_IsExplicitContract(bool value);
                /*0x6fcf3a0*/ bool get_IsProblematicInitProperty();
                /*0x6fcf3a8*/ void set_IsProblematicInitProperty(bool value);
                /*0x6fc68ac*/ MessagePack.MessagePackFormatterAttribute GetMessagePackFormatterAttribute();
                /*0x6fcf3b4*/ System.Runtime.Serialization.DataMemberAttribute GetDataMemberAttribute();
                /*0x6fc6fd8*/ void EmitLoadValue(System.Reflection.Emit.ILGenerator il);
                /*0x6fc682c*/ void OnTypeCreated(System.Reflection.TypeInfo formatterType);
                /*0x6fc9e38*/ void EmitPreStoreValue(System.Reflection.Emit.TypeBuilder typeBuilder, System.Reflection.Emit.ILGenerator il, System.Reflection.Emit.LocalBuilder localResult);
                /*0x6fc953c*/ void EmitStoreValue(System.Reflection.Emit.ILGenerator il, System.Reflection.Emit.TypeBuilder typeBuilder);

                class PropertySetterHelperForStructs<T, TValue> : System.MulticastDelegate
                {
                    PropertySetterHelperForStructs(object object, nint method);
                    /*0x3907c14*/ void Invoke(ref T target, TValue value);
                }

                class <>c
                {
                    static /*0x0*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMember.<> <>9;
                    static /*0x8*/ System.Func<System.Type, bool> <>9__14_0;

                    static /*0x6fcf41c*/ <>c();
                    /*0x6fcf484*/ <>c();
                    /*0x6fcf48c*/ bool <get_IsInitOnly>b__14_0(System.Type modifierType);
                }
            }

            class OrderBaseTypesBeforeDerivedTypes : System.Collections.Generic.IComparer<System.Type>
            {
                static /*0x0*/ MessagePack.Internal.ObjectSerializationInfo.OrderBaseTypesBeforeDerivedTypes Instance;

                static /*0x6fcf5e0*/ OrderBaseTypesBeforeDerivedTypes();
                /*0x6fcf4f0*/ OrderBaseTypesBeforeDerivedTypes();
                /*0x6fcf4f8*/ int Compare(System.Type x, System.Type y);
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

                static /*0x6fcf648*/ <>c();
                /*0x6fcf6b0*/ <>c();
                /*0x6fcf6b8*/ System.Type <CreateOrNull>b__27_8(System.Reflection.MemberInfo m);
                /*0x6fcf6dc*/ string <CreateOrNull>b__27_9(System.Reflection.MemberInfo m);
                /*0x6fcf700*/ bool <CreateOrNull>b__27_2(System.Reflection.ConstructorInfo x);
                /*0x6fcf758*/ int <CreateOrNull>b__27_4(System.Reflection.ConstructorInfo x);
                /*0x6fcf78c*/ int <CreateOrNull>b__27_10(System.Collections.Generic.KeyValuePair<int, MessagePack.Internal.ObjectSerializationInfo.EmittableMember> x);
                /*0x6fcf7c8*/ System.ValueTuple<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, int> <CreateOrNull>b__27_11(System.Collections.Generic.KeyValuePair<int, MessagePack.Internal.ObjectSerializationInfo.EmittableMember> x, int i);
                /*0x6fcf844*/ int <CreateOrNull>b__27_12(System.ValueTuple<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, int> x);
                /*0x6fcf84c*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMember <CreateOrNull>b__27_13(System.ValueTuple<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, int> x);
                /*0x6fcf854*/ string <CreateOrNull>b__27_14(System.Collections.Generic.KeyValuePair<string, MessagePack.Internal.ObjectSerializationInfo.EmittableMember> x);
                /*0x6fcf890*/ System.Collections.Generic.KeyValuePair<string, MessagePack.Internal.ObjectSerializationInfo.EmittableMember> <CreateOrNull>b__27_15(System.Collections.Generic.KeyValuePair<string, MessagePack.Internal.ObjectSerializationInfo.EmittableMember> x);
                /*0x6fcf89c*/ string <CreateOrNull>b__27_16(System.Collections.Generic.KeyValuePair<string, MessagePack.Internal.ObjectSerializationInfo.EmittableMember> x);
                /*0x6fcf8e0*/ System.Collections.Generic.KeyValuePair<string, MessagePack.Internal.ObjectSerializationInfo.EmittableMember> <CreateOrNull>b__27_17(System.Collections.Generic.KeyValuePair<string, MessagePack.Internal.ObjectSerializationInfo.EmittableMember> x);
                /*0x6fcf8ec*/ int <CreateOrNull>b__27_5(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x6fcf904*/ int <CreateOrNull>b__27_6(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x6fcf930*/ bool <CreateOrNull>b__27_7(MessagePack.Internal.ObjectSerializationInfo.EmittableMember m);
            }

            class <>c__DisplayClass26_0
            {
                /*0x10*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMember member;

                /*0x6fce988*/ <>c__DisplayClass26_0();
                /*0x6fcf968*/ bool <.ctor>b__0(MessagePack.Internal.ObjectSerializationInfo.EmittableMemberAndConstructorParameter cp);
            }

            class <>c__DisplayClass27_0
            {
                /*0x10*/ System.Collections.Generic.Dictionary<int, MessagePack.Internal.ObjectSerializationInfo.EmittableMember> intMembers;
                /*0x18*/ System.Collections.Generic.Dictionary<string, MessagePack.Internal.ObjectSerializationInfo.EmittableMember> stringMembers;
                /*0x20*/ System.Type type;
                /*0x28*/ bool isClassRecord;
                /*0x29*/ bool allowPrivate;

                /*0x6fceba0*/ <>c__DisplayClass27_0();
                /*0x6fceca0*/ bool <CreateOrNull>g__AddEmittableMemberOrIgnore|0(bool isIntKeyMode, MessagePack.Internal.ObjectSerializationInfo.EmittableMember member, bool checkConflicting);
                /*0x6fcf98c*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMember <CreateOrNull>g__CreateEmittableMember|1(System.Reflection.MemberInfo m);
                /*0x6fcfddc*/ bool <CreateOrNull>b__3(System.Reflection.ConstructorInfo x);
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

                /*0x6fcf280*/ <GetAllFields>d__29(int <>1__state);
                /*0x6fcfe38*/ void System.IDisposable.Dispose();
                /*0x6fcfe54*/ bool MoveNext();
                /*0x6fd0210*/ void <>m__Finally1();
                /*0x6fd02c0*/ System.Reflection.FieldInfo System.Collections.Generic.IEnumerator<System.Reflection.FieldInfo>.get_Current();
                /*0x6fd02c8*/ void System.Collections.IEnumerator.Reset();
                /*0x6fd0300*/ object System.Collections.IEnumerator.get_Current();
                /*0x6fd0308*/ System.Collections.Generic.IEnumerator<System.Reflection.FieldInfo> System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo>.GetEnumerator();
                /*0x6fd03ac*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
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

                /*0x6fcf2b4*/ <GetAllProperties>d__30(int <>1__state);
                /*0x6fd03b0*/ void System.IDisposable.Dispose();
                /*0x6fd03cc*/ bool MoveNext();
                /*0x6fd0788*/ void <>m__Finally1();
                /*0x6fd0838*/ System.Reflection.PropertyInfo System.Collections.Generic.IEnumerator<System.Reflection.PropertyInfo>.get_Current();
                /*0x6fd0840*/ void System.Collections.IEnumerator.Reset();
                /*0x6fd0878*/ object System.Collections.IEnumerator.get_Current();
                /*0x6fd0880*/ System.Collections.Generic.IEnumerator<System.Reflection.PropertyInfo> System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo>.GetEnumerator();
                /*0x6fd0924*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class MessagePackDynamicObjectResolverException : MessagePack.MessagePackSerializationException
        {
            /*0x6fcf0f0*/ MessagePackDynamicObjectResolverException(string message);
        }

        class ResolverUtilities
        {
            static /*0x6fd0928*/ MessagePack.Formatters.IMessagePackFormatter ActivateFormatter(System.Type formatterType, object[] args);
            static /*0x6fc69ac*/ System.Reflection.FieldInfo FetchSingletonField(System.Type formatterType);
        }

        class StandardResolverHelper
        {
            static /*0x0*/ MessagePack.IFormatterResolver[] DefaultResolvers;

            static /*0x6fd0bc4*/ StandardResolverHelper();
        }
    }

    namespace ImmutableCollection
    {
        class ImmutableArrayFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<System.Collections.Immutable.ImmutableArray<T>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x3907c14*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Collections.Immutable.ImmutableArray<T> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ System.Collections.Immutable.ImmutableArray<T> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ImmutableListFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.Immutable.ImmutableList.Builder<T>, System.Collections.Immutable.ImmutableList.Enumerator<T>, System.Collections.Immutable.ImmutableList<T>>
        {
            /*0x3907c14*/ void Add(System.Collections.Immutable.ImmutableList.Builder<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bb68*/ System.Collections.Immutable.ImmutableList<T> Complete(System.Collections.Immutable.ImmutableList.Builder<T> intermediateCollection);
            System.Collections.Immutable.ImmutableList.Builder<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ System.Collections.Immutable.ImmutableList.Enumerator<T> GetSourceEnumerator(System.Collections.Immutable.ImmutableList<T> source);
        }

        class ImmutableDictionaryFormatter<TKey, TValue> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, System.Collections.Immutable.ImmutableDictionary.Builder<TKey, TValue>, System.Collections.Immutable.ImmutableDictionary.Enumerator<TKey, TValue>, System.Collections.Immutable.ImmutableDictionary<TKey, TValue>>
        {
            /*0x3907c14*/ void Add(System.Collections.Immutable.ImmutableDictionary.Builder<TKey, TValue> collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bb68*/ System.Collections.Immutable.ImmutableDictionary<TKey, TValue> Complete(System.Collections.Immutable.ImmutableDictionary.Builder<TKey, TValue> intermediateCollection);
            System.Collections.Immutable.ImmutableDictionary.Builder<TKey, TValue> Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ System.Collections.Immutable.ImmutableDictionary.Enumerator<TKey, TValue> GetSourceEnumerator(System.Collections.Immutable.ImmutableDictionary<TKey, TValue> source);
        }

        class ImmutableHashSetFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.Immutable.ImmutableHashSet.Builder<T>, System.Collections.Immutable.ImmutableHashSet.Enumerator<T>, System.Collections.Immutable.ImmutableHashSet<T>>
        {
            /*0x3907c14*/ void Add(System.Collections.Immutable.ImmutableHashSet.Builder<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bb68*/ System.Collections.Immutable.ImmutableHashSet<T> Complete(System.Collections.Immutable.ImmutableHashSet.Builder<T> intermediateCollection);
            System.Collections.Immutable.ImmutableHashSet.Builder<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ System.Collections.Immutable.ImmutableHashSet.Enumerator<T> GetSourceEnumerator(System.Collections.Immutable.ImmutableHashSet<T> source);
        }

        class ImmutableSortedDictionaryFormatter<TKey, TValue> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, System.Collections.Immutable.ImmutableSortedDictionary.Builder<TKey, TValue>, System.Collections.Immutable.ImmutableSortedDictionary.Enumerator<TKey, TValue>, System.Collections.Immutable.ImmutableSortedDictionary<TKey, TValue>>
        {
            /*0x3907c14*/ void Add(System.Collections.Immutable.ImmutableSortedDictionary.Builder<TKey, TValue> collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bb68*/ System.Collections.Immutable.ImmutableSortedDictionary<TKey, TValue> Complete(System.Collections.Immutable.ImmutableSortedDictionary.Builder<TKey, TValue> intermediateCollection);
            System.Collections.Immutable.ImmutableSortedDictionary.Builder<TKey, TValue> Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ System.Collections.Immutable.ImmutableSortedDictionary.Enumerator<TKey, TValue> GetSourceEnumerator(System.Collections.Immutable.ImmutableSortedDictionary<TKey, TValue> source);
        }

        class ImmutableSortedSetFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.Immutable.ImmutableSortedSet.Builder<T>, System.Collections.Immutable.ImmutableSortedSet.Enumerator<T>, System.Collections.Immutable.ImmutableSortedSet<T>>
        {
            /*0x3907c14*/ void Add(System.Collections.Immutable.ImmutableSortedSet.Builder<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bb68*/ System.Collections.Immutable.ImmutableSortedSet<T> Complete(System.Collections.Immutable.ImmutableSortedSet.Builder<T> intermediateCollection);
            System.Collections.Immutable.ImmutableSortedSet.Builder<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ System.Collections.Immutable.ImmutableSortedSet.Enumerator<T> GetSourceEnumerator(System.Collections.Immutable.ImmutableSortedSet<T> source);
        }

        class ImmutableQueueFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, MessagePack.ImmutableCollection.ImmutableQueueBuilder<T>, System.Collections.Immutable.ImmutableQueue<T>>
        {
            /*0x3907c14*/ void Add(MessagePack.ImmutableCollection.ImmutableQueueBuilder<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bb68*/ System.Collections.Immutable.ImmutableQueue<T> Complete(MessagePack.ImmutableCollection.ImmutableQueueBuilder<T> intermediateCollection);
            MessagePack.ImmutableCollection.ImmutableQueueBuilder<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class ImmutableStackFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, T[], System.Collections.Immutable.ImmutableStack<T>>
        {
            /*0x3907c14*/ void Add(T[] collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bb68*/ System.Collections.Immutable.ImmutableStack<T> Complete(T[] intermediateCollection);
            T[] Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class InterfaceImmutableListFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.Immutable.ImmutableList.Builder<T>, System.Collections.Immutable.IImmutableList<T>>
        {
            /*0x3907c14*/ void Add(System.Collections.Immutable.ImmutableList.Builder<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bb68*/ System.Collections.Immutable.IImmutableList<T> Complete(System.Collections.Immutable.ImmutableList.Builder<T> intermediateCollection);
            System.Collections.Immutable.ImmutableList.Builder<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class InterfaceImmutableDictionaryFormatter<TKey, TValue> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, System.Collections.Immutable.ImmutableDictionary.Builder<TKey, TValue>, System.Collections.Immutable.IImmutableDictionary<TKey, TValue>>
        {
            /*0x3907c14*/ void Add(System.Collections.Immutable.ImmutableDictionary.Builder<TKey, TValue> collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bb68*/ System.Collections.Immutable.IImmutableDictionary<TKey, TValue> Complete(System.Collections.Immutable.ImmutableDictionary.Builder<TKey, TValue> intermediateCollection);
            System.Collections.Immutable.ImmutableDictionary.Builder<TKey, TValue> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class InterfaceImmutableSetFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.Immutable.ImmutableHashSet.Builder<T>, System.Collections.Immutable.IImmutableSet<T>>
        {
            /*0x3907c14*/ void Add(System.Collections.Immutable.ImmutableHashSet.Builder<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bb68*/ System.Collections.Immutable.IImmutableSet<T> Complete(System.Collections.Immutable.ImmutableHashSet.Builder<T> intermediateCollection);
            System.Collections.Immutable.ImmutableHashSet.Builder<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class InterfaceImmutableQueueFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, MessagePack.ImmutableCollection.ImmutableQueueBuilder<T>, System.Collections.Immutable.IImmutableQueue<T>>
        {
            /*0x3907c14*/ void Add(MessagePack.ImmutableCollection.ImmutableQueueBuilder<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bb68*/ System.Collections.Immutable.IImmutableQueue<T> Complete(MessagePack.ImmutableCollection.ImmutableQueueBuilder<T> intermediateCollection);
            MessagePack.ImmutableCollection.ImmutableQueueBuilder<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class InterfaceImmutableStackFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, T[], System.Collections.Immutable.IImmutableStack<T>>
        {
            /*0x3907c14*/ void Add(T[] collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bb68*/ System.Collections.Immutable.IImmutableStack<T> Complete(T[] intermediateCollection);
            T[] Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class ImmutableQueueBuilder<T>
        {
            /*0x0*/ System.Collections.Immutable.ImmutableQueue<T> <Q>k__BackingField;

            /*0x380cb08*/ ImmutableQueueBuilder();
            /*0x380b9e8*/ System.Collections.Immutable.ImmutableQueue<T> get_Q();
            /*0x380d83c*/ void set_Q(System.Collections.Immutable.ImmutableQueue<T> value);
            /*0x3907c14*/ void Add(T value);
        }

        class ImmutableCollectionResolver : MessagePack.IFormatterResolver
        {
            static /*0x0*/ MessagePack.ImmutableCollection.ImmutableCollectionResolver Instance;

            static /*0x6fd1248*/ ImmutableCollectionResolver();
            /*0x6fd1240*/ ImmutableCollectionResolver();
            /*0x380b9e8*/ MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static /*0x38358cc*/ FormatterCache();
            }
        }

        class ImmutableCollectionGetFormatterHelper
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, System.Type> FormatterMap;

            static /*0x6fd1774*/ ImmutableCollectionGetFormatterHelper();
            static /*0x6fd12b0*/ object GetFormatter(System.Type t);
            static /*0x6fd1744*/ object CreateInstance(System.Type genericType, System.Type[] genericTypeArguments, object[] arguments);
        }

        class ReflectionExtensions
        {
            static /*0x6fd1684*/ bool IsNullable(System.Reflection.TypeInfo type);
        }
    }

    namespace Formatters
    {
        class ArrayFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<T[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x380cb08*/ ArrayFormatter();
            /*0x380da4c*/ void Serialize(ref MessagePack.MessagePackWriter writer, T[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bcbc*/ T[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ByteMemoryFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Memory<byte>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.ByteMemoryFormatter Instance;

            static /*0x6fd1ebc*/ ByteMemoryFormatter();
            /*0x6fd1d08*/ ByteMemoryFormatter();
            /*0x6fd1d10*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Memory<byte> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd1da8*/ System.Memory<byte> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ByteReadOnlyMemoryFormatter : MessagePack.Formatters.IMessagePackFormatter<System.ReadOnlyMemory<byte>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.ByteReadOnlyMemoryFormatter Instance;

            static /*0x6fd20b4*/ ByteReadOnlyMemoryFormatter();
            /*0x6fd1f24*/ ByteReadOnlyMemoryFormatter();
            /*0x6fd1f2c*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.ReadOnlyMemory<byte> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd1fa0*/ System.ReadOnlyMemory<byte> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ByteReadOnlySequenceFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Buffers.ReadOnlySequence<byte>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.ByteReadOnlySequenceFormatter Instance;

            static /*0x6fd23d8*/ ByteReadOnlySequenceFormatter();
            /*0x6fd211c*/ ByteReadOnlySequenceFormatter();
            /*0x6fd2124*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Buffers.ReadOnlySequence<byte> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd22bc*/ System.Buffers.ReadOnlySequence<byte> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ByteArraySegmentFormatter : MessagePack.Formatters.IMessagePackFormatter<System.ArraySegment<byte>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.ByteArraySegmentFormatter Instance;

            static /*0x6fd261c*/ ByteArraySegmentFormatter();
            /*0x6fd2440*/ ByteArraySegmentFormatter();
            /*0x6fd2448*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.ArraySegment<byte> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd2510*/ System.ArraySegment<byte> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ByteListFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Collections.Generic.List<byte>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.ByteListFormatter Instance;
            static /*0x8*/ MessagePack.Formatters.ListFormatter<byte> InnerFormatter;

            static /*0x6fd28bc*/ ByteListFormatter();
            /*0x6fd28b4*/ ByteListFormatter();
            /*0x6fd2684*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Collections.Generic.List<byte> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd271c*/ System.Collections.Generic.List<byte> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class MemoryFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<System.Memory<T>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x380cb08*/ MemoryFormatter();
            /*0x3907c14*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Memory<T> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ System.Memory<T> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ReadOnlyMemoryFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<System.ReadOnlyMemory<T>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x380cb08*/ ReadOnlyMemoryFormatter();
            /*0x3907c14*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.ReadOnlyMemory<T> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ System.ReadOnlyMemory<T> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ReadOnlySequenceFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<System.Buffers.ReadOnlySequence<T>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x380cb08*/ ReadOnlySequenceFormatter();
            /*0x3907c14*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Buffers.ReadOnlySequence<T> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ System.Buffers.ReadOnlySequence<T> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ArraySegmentFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<System.ArraySegment<T>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x380cb08*/ ArraySegmentFormatter();
            /*0x3907c14*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.ArraySegment<T> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ System.ArraySegment<T> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ListFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<System.Collections.Generic.List<T>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x380cb08*/ ListFormatter();
            /*0x380da4c*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Collections.Generic.List<T> value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bcbc*/ System.Collections.Generic.List<T> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class CollectionFormatterBase<TElement, TIntermediate, TEnumerator, TCollection> : MessagePack.Formatters.IMessagePackFormatter<TCollection>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x380cb08*/ CollectionFormatterBase();
            /*0x3907c14*/ void Serialize(ref MessagePack.MessagePackWriter writer, TCollection value, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ TCollection Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ System.Nullable<int> GetCount(TCollection sequence);
            /*0x3907c14*/ TEnumerator GetSourceEnumerator(TCollection source);
            /*0x3907c14*/ TIntermediate Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ void Add(TIntermediate collection, int index, TElement value, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ TCollection Complete(TIntermediate intermediateCollection);
        }

        class CollectionFormatterBase<TElement, TIntermediate, TCollection> : MessagePack.Formatters.CollectionFormatterBase<TElement, TIntermediate, System.Collections.Generic.IEnumerator<TElement>, TCollection>
        {
            /*0x380cb08*/ CollectionFormatterBase();
            /*0x3907c14*/ System.Collections.Generic.IEnumerator<TElement> GetSourceEnumerator(TCollection source);
        }

        class CollectionFormatterBase<TElement, TCollection> : MessagePack.Formatters.CollectionFormatterBase<TElement, TCollection, TCollection>
        {
            /*0x380cb08*/ CollectionFormatterBase();
            /*0x3907c14*/ TCollection Complete(TCollection intermediateCollection);
        }

        class GenericCollectionFormatter<TElement, TCollection> : MessagePack.Formatters.CollectionFormatterBase<TElement, TCollection>
        {
            /*0x380cb08*/ GenericCollectionFormatter();
            /*0x3907c14*/ TCollection Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ void Add(TCollection collection, int index, TElement value, MessagePack.MessagePackSerializerOptions options);
        }

        class GenericEnumerableFormatter<TElement, TCollection> : MessagePack.Formatters.CollectionFormatterBase<TElement, TElement[], TCollection>
        {
            /*0x380cb08*/ GenericEnumerableFormatter();
            TElement[] Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ void Add(TElement[] collection, int index, TElement value, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ TCollection Complete(TElement[] intermediateCollection);
        }

        class LinkedListFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.Generic.LinkedList<T>, System.Collections.Generic.LinkedList.Enumerator<T>, System.Collections.Generic.LinkedList<T>>
        {
            /*0x380cb08*/ LinkedListFormatter();
            /*0x3907c14*/ void Add(System.Collections.Generic.LinkedList<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bb68*/ System.Collections.Generic.LinkedList<T> Complete(System.Collections.Generic.LinkedList<T> intermediateCollection);
            System.Collections.Generic.LinkedList<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ System.Collections.Generic.LinkedList.Enumerator<T> GetSourceEnumerator(System.Collections.Generic.LinkedList<T> source);
        }

        class QueueFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.Generic.Queue<T>, System.Collections.Generic.Queue.Enumerator<T>, System.Collections.Generic.Queue<T>>
        {
            /*0x380cb08*/ QueueFormatter();
            /*0x380a950*/ System.Nullable<int> GetCount(System.Collections.Generic.Queue<T> sequence);
            /*0x3907c14*/ void Add(System.Collections.Generic.Queue<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.Queue<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ System.Collections.Generic.Queue.Enumerator<T> GetSourceEnumerator(System.Collections.Generic.Queue<T> source);
            /*0x380bb68*/ System.Collections.Generic.Queue<T> Complete(System.Collections.Generic.Queue<T> intermediateCollection);
        }

        class StackFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, T[], System.Collections.Generic.Stack.Enumerator<T>, System.Collections.Generic.Stack<T>>
        {
            /*0x380cb08*/ StackFormatter();
            /*0x380a950*/ System.Nullable<int> GetCount(System.Collections.Generic.Stack<T> sequence);
            /*0x3907c14*/ void Add(T[] collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            T[] Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ System.Collections.Generic.Stack.Enumerator<T> GetSourceEnumerator(System.Collections.Generic.Stack<T> source);
            /*0x380bb68*/ System.Collections.Generic.Stack<T> Complete(T[] intermediateCollection);
        }

        class HashSetFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.Generic.HashSet<T>, System.Collections.Generic.HashSet.Enumerator<T>, System.Collections.Generic.HashSet<T>>
        {
            /*0x380cb08*/ HashSetFormatter();
            /*0x380a950*/ System.Nullable<int> GetCount(System.Collections.Generic.HashSet<T> sequence);
            /*0x3907c14*/ void Add(System.Collections.Generic.HashSet<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bb68*/ System.Collections.Generic.HashSet<T> Complete(System.Collections.Generic.HashSet<T> intermediateCollection);
            System.Collections.Generic.HashSet<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ System.Collections.Generic.HashSet.Enumerator<T> GetSourceEnumerator(System.Collections.Generic.HashSet<T> source);
        }

        class ReadOnlyCollectionFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, T[], System.Collections.ObjectModel.ReadOnlyCollection<T>>
        {
            /*0x380cb08*/ ReadOnlyCollectionFormatter();
            /*0x3907c14*/ void Add(T[] collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bb68*/ System.Collections.ObjectModel.ReadOnlyCollection<T> Complete(T[] intermediateCollection);
            T[] Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class InterfaceListFormatter2<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.Generic.List<T>, System.Collections.Generic.IList<T>>
        {
            /*0x380cb08*/ InterfaceListFormatter2();
            /*0x3907c14*/ void Add(System.Collections.Generic.List<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.List<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x380bb68*/ System.Collections.Generic.IList<T> Complete(System.Collections.Generic.List<T> intermediateCollection);
        }

        class InterfaceCollectionFormatter2<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.Generic.List<T>, System.Collections.Generic.ICollection<T>>
        {
            /*0x380cb08*/ InterfaceCollectionFormatter2();
            /*0x3907c14*/ void Add(System.Collections.Generic.List<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.List<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x380bb68*/ System.Collections.Generic.ICollection<T> Complete(System.Collections.Generic.List<T> intermediateCollection);
        }

        class InterfaceEnumerableFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, T[], System.Collections.Generic.IEnumerable<T>>
        {
            /*0x380cb08*/ InterfaceEnumerableFormatter();
            /*0x3907c14*/ void Add(T[] collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            T[] Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x380bb68*/ System.Collections.Generic.IEnumerable<T> Complete(T[] intermediateCollection);
        }

        class InterfaceGroupingFormatter<TKey, TElement> : MessagePack.Formatters.IMessagePackFormatter<System.Linq.IGrouping<TKey, TElement>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x380cb08*/ InterfaceGroupingFormatter();
            /*0x380da4c*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Linq.IGrouping<TKey, TElement> value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bcbc*/ System.Linq.IGrouping<TKey, TElement> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class InterfaceLookupFormatter<TKey, TElement> : MessagePack.Formatters.CollectionFormatterBase<System.Linq.IGrouping<TKey, TElement>, System.Collections.Generic.Dictionary<TKey, System.Linq.IGrouping<TKey, TElement>>, System.Linq.ILookup<TKey, TElement>>
        {
            /*0x380cb08*/ InterfaceLookupFormatter();
            void Add(System.Collections.Generic.Dictionary<TKey, System.Linq.IGrouping<TKey, TElement>> collection, int index, System.Linq.IGrouping<TKey, TElement> value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bb68*/ System.Linq.ILookup<TKey, TElement> Complete(System.Collections.Generic.Dictionary<TKey, System.Linq.IGrouping<TKey, TElement>> intermediateCollection);
            System.Collections.Generic.Dictionary<TKey, System.Linq.IGrouping<TKey, TElement>> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class Grouping<TKey, TElement> : System.Linq.IGrouping<TKey, TElement>, System.Collections.Generic.IEnumerable<TElement>, System.Collections.IEnumerable
        {
            /*0x0*/ TKey key;
            /*0x0*/ System.Collections.Generic.IEnumerable<TElement> elements;

            /*0x3907c14*/ Grouping(TKey key, System.Collections.Generic.IEnumerable<TElement> elements);
            /*0x3907c14*/ TKey get_Key();
            /*0x380b9e8*/ System.Collections.Generic.IEnumerator<TElement> GetEnumerator();
            /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class Lookup<TKey, TElement> : System.Linq.ILookup<TKey, TElement>, System.Collections.Generic.IEnumerable<System.Linq.IGrouping<TKey, TElement>>, System.Collections.IEnumerable
        {
            /*0x0*/ System.Collections.Generic.Dictionary<TKey, System.Linq.IGrouping<TKey, TElement>> groupings;

            /*0x380d83c*/ Lookup(System.Collections.Generic.Dictionary<TKey, System.Linq.IGrouping<TKey, TElement>> groupings);
            /*0x3907c14*/ System.Collections.Generic.IEnumerable<TElement> get_Item(TKey key);
            /*0x380b9e8*/ System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey, TElement>> GetEnumerator();
            /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class NonGenericListFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<T>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x380cb08*/ NonGenericListFormatter();
            /*0x3907c14*/ void Serialize(ref MessagePack.MessagePackWriter writer, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ T Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NonGenericInterfaceCollectionFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Collections.ICollection>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Collections.ICollection> Instance;

            static /*0x6fd31d8*/ NonGenericInterfaceCollectionFormatter();
            /*0x6fd297c*/ NonGenericInterfaceCollectionFormatter();
            /*0x6fd2984*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Collections.ICollection value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd2e1c*/ System.Collections.ICollection Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NonGenericInterfaceEnumerableFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Collections.IEnumerable>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Collections.IEnumerable> Instance;

            static /*0x6fd3bdc*/ NonGenericInterfaceEnumerableFormatter();
            /*0x6fd3240*/ NonGenericInterfaceEnumerableFormatter();
            /*0x6fd3248*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Collections.IEnumerable value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd3820*/ System.Collections.IEnumerable Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NonGenericInterfaceListFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Collections.IList>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Collections.IList> Instance;

            static /*0x6fd44a0*/ NonGenericInterfaceListFormatter();
            /*0x6fd3c44*/ NonGenericInterfaceListFormatter();
            /*0x6fd3c4c*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Collections.IList value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd40e4*/ System.Collections.IList Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NonGenericDictionaryFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<T>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x380cb08*/ NonGenericDictionaryFormatter();
            /*0x3907c14*/ void Serialize(ref MessagePack.MessagePackWriter writer, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ T Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NonGenericInterfaceDictionaryFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Collections.IDictionary>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Collections.IDictionary> Instance;

            static /*0x6fd4c68*/ NonGenericInterfaceDictionaryFormatter();
            /*0x6fd4508*/ NonGenericInterfaceDictionaryFormatter();
            /*0x6fd4510*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Collections.IDictionary value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd4834*/ System.Collections.IDictionary Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ObservableCollectionFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.ObjectModel.ObservableCollection<T>>
        {
            /*0x380cb08*/ ObservableCollectionFormatter();
            /*0x3907c14*/ void Add(System.Collections.ObjectModel.ObservableCollection<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.ObjectModel.ObservableCollection<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class ReadOnlyObservableCollectionFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.ObjectModel.ObservableCollection<T>, System.Collections.ObjectModel.ReadOnlyObservableCollection<T>>
        {
            /*0x380cb08*/ ReadOnlyObservableCollectionFormatter();
            /*0x3907c14*/ void Add(System.Collections.ObjectModel.ObservableCollection<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.ObjectModel.ObservableCollection<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x380bb68*/ System.Collections.ObjectModel.ReadOnlyObservableCollection<T> Complete(System.Collections.ObjectModel.ObservableCollection<T> intermediateCollection);
        }

        class InterfaceReadOnlyListFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, T[], System.Collections.Generic.IReadOnlyList<T>>
        {
            /*0x380cb08*/ InterfaceReadOnlyListFormatter();
            /*0x3907c14*/ void Add(T[] collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            T[] Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x380bb68*/ System.Collections.Generic.IReadOnlyList<T> Complete(T[] intermediateCollection);
        }

        class InterfaceReadOnlyCollectionFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, T[], System.Collections.Generic.IReadOnlyCollection<T>>
        {
            /*0x380cb08*/ InterfaceReadOnlyCollectionFormatter();
            /*0x3907c14*/ void Add(T[] collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            T[] Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x380bb68*/ System.Collections.Generic.IReadOnlyCollection<T> Complete(T[] intermediateCollection);
        }

        class InterfaceSetFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.Generic.HashSet<T>, System.Collections.Generic.ISet<T>>
        {
            /*0x380cb08*/ InterfaceSetFormatter();
            /*0x3907c14*/ void Add(System.Collections.Generic.HashSet<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bb68*/ System.Collections.Generic.ISet<T> Complete(System.Collections.Generic.HashSet<T> intermediateCollection);
            System.Collections.Generic.HashSet<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class ConcurrentBagFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.Concurrent.ConcurrentBag<T>>
        {
            /*0x380cb08*/ ConcurrentBagFormatter();
            /*0x380a950*/ System.Nullable<int> GetCount(System.Collections.Concurrent.ConcurrentBag<T> sequence);
            /*0x3907c14*/ void Add(System.Collections.Concurrent.ConcurrentBag<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Concurrent.ConcurrentBag<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class ConcurrentQueueFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.Concurrent.ConcurrentQueue<T>>
        {
            /*0x380cb08*/ ConcurrentQueueFormatter();
            /*0x380a950*/ System.Nullable<int> GetCount(System.Collections.Concurrent.ConcurrentQueue<T> sequence);
            /*0x3907c14*/ void Add(System.Collections.Concurrent.ConcurrentQueue<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Concurrent.ConcurrentQueue<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class ConcurrentStackFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, T[], System.Collections.Concurrent.ConcurrentStack<T>>
        {
            /*0x380cb08*/ ConcurrentStackFormatter();
            /*0x380a950*/ System.Nullable<int> GetCount(System.Collections.Concurrent.ConcurrentStack<T> sequence);
            /*0x3907c14*/ void Add(T[] collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            T[] Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x380bb68*/ System.Collections.Concurrent.ConcurrentStack<T> Complete(T[] intermediateCollection);
        }

        class CollectionHelpers<TCollection, TEqualityComparer>
        {
            static /*0x0*/ System.Func<int, TEqualityComparer, TCollection> collectionCreator;

            static /*0x38358cc*/ CollectionHelpers();
            static /*0x3907c14*/ TCollection CreateHashCollection(int count, TEqualityComparer equalityComparer);
        }

        class DictionaryFormatterBase<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : MessagePack.Formatters.IMessagePackFormatter<TDictionary>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x380cb08*/ DictionaryFormatterBase();
            /*0x3907c14*/ void Serialize(ref MessagePack.MessagePackWriter writer, TDictionary value, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ TDictionary Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ TEnumerator GetSourceEnumerator(TDictionary source);
            /*0x3907c14*/ TIntermediate Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ void Add(TIntermediate collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ TDictionary Complete(TIntermediate intermediateCollection);
        }

        class DictionaryFormatterBase<TKey, TValue, TIntermediate, TDictionary> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, TIntermediate, System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>, TDictionary>
        {
            /*0x380cb08*/ DictionaryFormatterBase();
            /*0x3907c14*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetSourceEnumerator(TDictionary source);
        }

        class DictionaryFormatterBase<TKey, TValue, TDictionary> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, TDictionary, TDictionary>
        {
            /*0x380cb08*/ DictionaryFormatterBase();
            /*0x3907c14*/ TDictionary Complete(TDictionary intermediateCollection);
        }

        class DictionaryFormatter<TKey, TValue> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, System.Collections.Generic.Dictionary<TKey, TValue>, System.Collections.Generic.Dictionary.Enumerator<TKey, TValue>, System.Collections.Generic.Dictionary<TKey, TValue>>
        {
            /*0x380cb08*/ DictionaryFormatter();
            /*0x3907c14*/ void Add(System.Collections.Generic.Dictionary<TKey, TValue> collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bb68*/ System.Collections.Generic.Dictionary<TKey, TValue> Complete(System.Collections.Generic.Dictionary<TKey, TValue> intermediateCollection);
            System.Collections.Generic.Dictionary<TKey, TValue> Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ System.Collections.Generic.Dictionary.Enumerator<TKey, TValue> GetSourceEnumerator(System.Collections.Generic.Dictionary<TKey, TValue> source);
        }

        class GenericDictionaryFormatter<TKey, TValue, TDictionary> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, TDictionary>
        {
            /*0x380cb08*/ GenericDictionaryFormatter();
            /*0x3907c14*/ void Add(TDictionary collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ TDictionary Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class GenericReadOnlyDictionaryFormatter<TKey, TValue, TDictionary> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, System.Collections.Generic.Dictionary<TKey, TValue>, TDictionary>
        {
            /*0x380cb08*/ GenericReadOnlyDictionaryFormatter();
            /*0x3907c14*/ void Add(System.Collections.Generic.Dictionary<TKey, TValue> collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.Dictionary<TKey, TValue> Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ TDictionary Complete(System.Collections.Generic.Dictionary<TKey, TValue> intermediateCollection);
        }

        class InterfaceDictionaryFormatter<TKey, TValue> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, System.Collections.Generic.Dictionary<TKey, TValue>, System.Collections.Generic.IDictionary<TKey, TValue>>
        {
            /*0x380cb08*/ InterfaceDictionaryFormatter();
            /*0x3907c14*/ void Add(System.Collections.Generic.Dictionary<TKey, TValue> collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.Dictionary<TKey, TValue> Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x380bb68*/ System.Collections.Generic.IDictionary<TKey, TValue> Complete(System.Collections.Generic.Dictionary<TKey, TValue> intermediateCollection);
        }

        class SortedListFormatter<TKey, TValue> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, System.Collections.Generic.SortedList<TKey, TValue>>
        {
            /*0x380cb08*/ SortedListFormatter();
            /*0x3907c14*/ void Add(System.Collections.Generic.SortedList<TKey, TValue> collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.SortedList<TKey, TValue> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class SortedDictionaryFormatter<TKey, TValue> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, System.Collections.Generic.SortedDictionary<TKey, TValue>, System.Collections.Generic.SortedDictionary.Enumerator<TKey, TValue>, System.Collections.Generic.SortedDictionary<TKey, TValue>>
        {
            /*0x380cb08*/ SortedDictionaryFormatter();
            /*0x3907c14*/ void Add(System.Collections.Generic.SortedDictionary<TKey, TValue> collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bb68*/ System.Collections.Generic.SortedDictionary<TKey, TValue> Complete(System.Collections.Generic.SortedDictionary<TKey, TValue> intermediateCollection);
            System.Collections.Generic.SortedDictionary<TKey, TValue> Create(int count, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ System.Collections.Generic.SortedDictionary.Enumerator<TKey, TValue> GetSourceEnumerator(System.Collections.Generic.SortedDictionary<TKey, TValue> source);
        }

        class ReadOnlyDictionaryFormatter<TKey, TValue> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, System.Collections.Generic.Dictionary<TKey, TValue>, System.Collections.ObjectModel.ReadOnlyDictionary<TKey, TValue>>
        {
            /*0x380cb08*/ ReadOnlyDictionaryFormatter();
            /*0x3907c14*/ void Add(System.Collections.Generic.Dictionary<TKey, TValue> collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bb68*/ System.Collections.ObjectModel.ReadOnlyDictionary<TKey, TValue> Complete(System.Collections.Generic.Dictionary<TKey, TValue> intermediateCollection);
            System.Collections.Generic.Dictionary<TKey, TValue> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class InterfaceReadOnlyDictionaryFormatter<TKey, TValue> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, System.Collections.Generic.Dictionary<TKey, TValue>, System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>>
        {
            /*0x380cb08*/ InterfaceReadOnlyDictionaryFormatter();
            /*0x3907c14*/ void Add(System.Collections.Generic.Dictionary<TKey, TValue> collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bb68*/ System.Collections.Generic.IReadOnlyDictionary<TKey, TValue> Complete(System.Collections.Generic.Dictionary<TKey, TValue> intermediateCollection);
            System.Collections.Generic.Dictionary<TKey, TValue> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class ConcurrentDictionaryFormatter<TKey, TValue> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue>>
        {
            /*0x380cb08*/ ConcurrentDictionaryFormatter();
            /*0x3907c14*/ void Add(System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue> collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class DynamicObjectTypeFallbackFormatter : MessagePack.Formatters.IMessagePackFormatter<object>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<object> Instance;
            static /*0x8*/ MessagePack.Internal.ThreadsafeTypeKeyHashTable<MessagePack.Formatters.DynamicObjectTypeFallbackFormatter.SerializeMethod> SerializerDelegates;

            static /*0x6fd5820*/ DynamicObjectTypeFallbackFormatter();
            /*0x6fd4cd0*/ DynamicObjectTypeFallbackFormatter();
            /*0x6fd4cd8*/ void Serialize(ref MessagePack.MessagePackWriter writer, object value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd573c*/ object Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);

            class SerializeMethod : System.MulticastDelegate
            {
                /*0x6fd58e8*/ SerializeMethod(object object, nint method);
                /*0x6fd59f4*/ void Invoke(object dynamicFormatter, ref MessagePack.MessagePackWriter writer, object value, MessagePack.MessagePackSerializerOptions options);
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

            static /*0x3830700*/ string Translate(string items, System.Collections.Generic.IReadOnlyDictionary<string, string> mapping);
            /*0x380cb08*/ EnumAsStringFormatter();
            /*0x380cdf0*/ EnumAsStringFormatter(bool ignoreCase);
            /*0x3907c14*/ void Serialize(ref MessagePack.MessagePackWriter writer, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ T Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
            /*0x380bb68*/ string GetClrNames(string serializedNames);
            /*0x380bb68*/ string GetSerializedNames(string clrNames);
        }

        class ExpandoObjectFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Dynamic.ExpandoObject>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Dynamic.ExpandoObject> Instance;

            static /*0x6fd6330*/ ExpandoObjectFormatter();
            /*0x6fd5a08*/ ExpandoObjectFormatter();
            /*0x6fd5a10*/ System.Dynamic.ExpandoObject Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd5e04*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Dynamic.ExpandoObject value, MessagePack.MessagePackSerializerOptions options);
        }

        class GenericEnumFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<T>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x0*/ MessagePack.Formatters.GenericEnumFormatter.EnumSerialize<T> serializer;
            /*0x0*/ MessagePack.Formatters.GenericEnumFormatter.EnumDeserialize<T> deserializer;

            /*0x380cb08*/ GenericEnumFormatter();
            /*0x3907c14*/ void Serialize(ref MessagePack.MessagePackWriter writer, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ T Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);

            class EnumSerialize<T> : System.MulticastDelegate
            {
                EnumSerialize(object object, nint method);
                /*0x380d93c*/ void Invoke(ref MessagePack.MessagePackWriter writer, ref T value);
            }

            class EnumDeserialize<T> : System.MulticastDelegate
            {
                EnumDeserialize(object object, nint method);
                /*0x3907c14*/ T Invoke(ref MessagePack.MessagePackReader reader);
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

                static /*0x38358cc*/ <>c();
                /*0x380cb08*/ <>c();
                /*0x380d93c*/ void <.ctor>b__4_0(ref MessagePack.MessagePackWriter writer, ref T value);
                /*0x3907c14*/ T <.ctor>b__4_1(ref MessagePack.MessagePackReader reader);
                /*0x380d93c*/ void <.ctor>b__4_2(ref MessagePack.MessagePackWriter writer, ref T value);
                /*0x3907c14*/ T <.ctor>b__4_3(ref MessagePack.MessagePackReader reader);
                /*0x380d93c*/ void <.ctor>b__4_4(ref MessagePack.MessagePackWriter writer, ref T value);
                /*0x3907c14*/ T <.ctor>b__4_5(ref MessagePack.MessagePackReader reader);
                /*0x380d93c*/ void <.ctor>b__4_6(ref MessagePack.MessagePackWriter writer, ref T value);
                /*0x3907c14*/ T <.ctor>b__4_7(ref MessagePack.MessagePackReader reader);
                /*0x380d93c*/ void <.ctor>b__4_8(ref MessagePack.MessagePackWriter writer, ref T value);
                /*0x3907c14*/ T <.ctor>b__4_9(ref MessagePack.MessagePackReader reader);
                /*0x380d93c*/ void <.ctor>b__4_10(ref MessagePack.MessagePackWriter writer, ref T value);
                /*0x3907c14*/ T <.ctor>b__4_11(ref MessagePack.MessagePackReader reader);
                /*0x380d93c*/ void <.ctor>b__4_12(ref MessagePack.MessagePackWriter writer, ref T value);
                /*0x3907c14*/ T <.ctor>b__4_13(ref MessagePack.MessagePackReader reader);
                /*0x380d93c*/ void <.ctor>b__4_14(ref MessagePack.MessagePackWriter writer, ref T value);
                /*0x3907c14*/ T <.ctor>b__4_15(ref MessagePack.MessagePackReader reader);
            }
        }

        interface IMessagePackFormatter
        {
        }

        interface IMessagePackFormatter<T> : MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x3907c14*/ void Serialize(ref MessagePack.MessagePackWriter writer, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ T Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class TwoDimensionalArrayFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<T[, ]>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x380cb08*/ TwoDimensionalArrayFormatter();
            /*0x380da4c*/ void Serialize(ref MessagePack.MessagePackWriter writer, T[,] value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bcbc*/ T[,] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ThreeDimensionalArrayFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<T[, , ]>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x380cb08*/ ThreeDimensionalArrayFormatter();
            /*0x380da4c*/ void Serialize(ref MessagePack.MessagePackWriter writer, T[,,] value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bcbc*/ T[,,] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class FourDimensionalArrayFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<T[, , , ]>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x380cb08*/ FourDimensionalArrayFormatter();
            /*0x380da4c*/ void Serialize(ref MessagePack.MessagePackWriter writer, T[,,,] value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bcbc*/ T[,,,] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NilFormatter : MessagePack.Formatters.IMessagePackFormatter<MessagePack.Nil>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<MessagePack.Nil> Instance;

            static /*0x6fd63c8*/ NilFormatter();
            /*0x6fd6398*/ NilFormatter();
            /*0x6fd63a0*/ void Serialize(ref MessagePack.MessagePackWriter writer, MessagePack.Nil value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd63ac*/ MessagePack.Nil Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableNilFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<MessagePack.Nil>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Nullable<MessagePack.Nil>> Instance;

            static /*0x6fd64b0*/ NullableNilFormatter();
            /*0x6fd6430*/ NullableNilFormatter();
            /*0x6fd6438*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<MessagePack.Nil> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd6444*/ System.Nullable<MessagePack.Nil> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<T>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x380cb08*/ NullableFormatter();
            /*0x3907c14*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<T> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ System.Nullable<T> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class StaticNullableFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<T>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> underlyingFormatter;

            /*0x380d83c*/ StaticNullableFormatter(MessagePack.Formatters.IMessagePackFormatter<T> underlyingFormatter);
            /*0x3907c14*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<T> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ System.Nullable<T> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class Int16Formatter : MessagePack.Formatters.IMessagePackFormatter<short>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.Int16Formatter Instance;

            static /*0x6fd653c*/ Int16Formatter();
            /*0x6fd6518*/ Int16Formatter();
            /*0x6fd6520*/ void Serialize(ref MessagePack.MessagePackWriter writer, short value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd6530*/ short Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableInt16Formatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<short>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableInt16Formatter Instance;

            static /*0x6fd6704*/ NullableInt16Formatter();
            /*0x6fd65a4*/ NullableInt16Formatter();
            /*0x6fd65ac*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<short> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd6644*/ System.Nullable<short> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class Int16ArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Int16[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.Int16ArrayFormatter Instance;

            static /*0x6fd69d0*/ Int16ArrayFormatter();
            /*0x6fd676c*/ Int16ArrayFormatter();
            /*0x6fd6774*/ void Serialize(ref MessagePack.MessagePackWriter writer, short[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd6830*/ short[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class Int32Formatter : MessagePack.Formatters.IMessagePackFormatter<int>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.Int32Formatter Instance;

            static /*0x6fd6a5c*/ Int32Formatter();
            /*0x6fd6a38*/ Int32Formatter();
            /*0x6fd6a40*/ void Serialize(ref MessagePack.MessagePackWriter writer, int value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd6a50*/ int Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableInt32Formatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<int>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableInt32Formatter Instance;

            static /*0x6fd6c24*/ NullableInt32Formatter();
            /*0x6fd6ac4*/ NullableInt32Formatter();
            /*0x6fd6acc*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<int> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd6b64*/ System.Nullable<int> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class Int32ArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Int32[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.Int32ArrayFormatter Instance;

            static /*0x6fd6ef0*/ Int32ArrayFormatter();
            /*0x6fd6c8c*/ Int32ArrayFormatter();
            /*0x6fd6c94*/ void Serialize(ref MessagePack.MessagePackWriter writer, int[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd6d50*/ int[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class Int64Formatter : MessagePack.Formatters.IMessagePackFormatter<long>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.Int64Formatter Instance;

            static /*0x6fd6f7c*/ Int64Formatter();
            /*0x6fd6f58*/ Int64Formatter();
            /*0x6fd6f60*/ void Serialize(ref MessagePack.MessagePackWriter writer, long value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd6f70*/ long Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableInt64Formatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<long>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableInt64Formatter Instance;

            static /*0x6fd7148*/ NullableInt64Formatter();
            /*0x6fd6fe4*/ NullableInt64Formatter();
            /*0x6fd6fec*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<long> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd7084*/ System.Nullable<long> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class Int64ArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Int64[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.Int64ArrayFormatter Instance;

            static /*0x6fd7414*/ Int64ArrayFormatter();
            /*0x6fd71b0*/ Int64ArrayFormatter();
            /*0x6fd71b8*/ void Serialize(ref MessagePack.MessagePackWriter writer, long[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd7274*/ long[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class UInt16Formatter : MessagePack.Formatters.IMessagePackFormatter<ushort>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.UInt16Formatter Instance;

            static /*0x6fd74a0*/ UInt16Formatter();
            /*0x6fd747c*/ UInt16Formatter();
            /*0x6fd7484*/ void Serialize(ref MessagePack.MessagePackWriter writer, ushort value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd7494*/ ushort Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableUInt16Formatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<ushort>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableUInt16Formatter Instance;

            static /*0x6fd7668*/ NullableUInt16Formatter();
            /*0x6fd7508*/ NullableUInt16Formatter();
            /*0x6fd7510*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<ushort> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd75a8*/ System.Nullable<ushort> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class UInt16ArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.UInt16[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.UInt16ArrayFormatter Instance;

            static /*0x6fd7934*/ UInt16ArrayFormatter();
            /*0x6fd76d0*/ UInt16ArrayFormatter();
            /*0x6fd76d8*/ void Serialize(ref MessagePack.MessagePackWriter writer, ushort[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd7794*/ ushort[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class UInt32Formatter : MessagePack.Formatters.IMessagePackFormatter<uint>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.UInt32Formatter Instance;

            static /*0x6fd79c0*/ UInt32Formatter();
            /*0x6fd799c*/ UInt32Formatter();
            /*0x6fd79a4*/ void Serialize(ref MessagePack.MessagePackWriter writer, uint value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd79b4*/ uint Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableUInt32Formatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<uint>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableUInt32Formatter Instance;

            static /*0x6fd7b88*/ NullableUInt32Formatter();
            /*0x6fd7a28*/ NullableUInt32Formatter();
            /*0x6fd7a30*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<uint> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd7ac8*/ System.Nullable<uint> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class UInt32ArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.UInt32[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.UInt32ArrayFormatter Instance;

            static /*0x6fd7e54*/ UInt32ArrayFormatter();
            /*0x6fd7bf0*/ UInt32ArrayFormatter();
            /*0x6fd7bf8*/ void Serialize(ref MessagePack.MessagePackWriter writer, uint[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd7cb4*/ uint[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class UInt64Formatter : MessagePack.Formatters.IMessagePackFormatter<ulong>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.UInt64Formatter Instance;

            static /*0x6fd7ee0*/ UInt64Formatter();
            /*0x6fd7ebc*/ UInt64Formatter();
            /*0x6fd7ec4*/ void Serialize(ref MessagePack.MessagePackWriter writer, ulong value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd7ed4*/ ulong Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableUInt64Formatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<ulong>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableUInt64Formatter Instance;

            static /*0x6fd80ac*/ NullableUInt64Formatter();
            /*0x6fd7f48*/ NullableUInt64Formatter();
            /*0x6fd7f50*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<ulong> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd7fe8*/ System.Nullable<ulong> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class UInt64ArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.UInt64[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.UInt64ArrayFormatter Instance;

            static /*0x6fd8378*/ UInt64ArrayFormatter();
            /*0x6fd8114*/ UInt64ArrayFormatter();
            /*0x6fd811c*/ void Serialize(ref MessagePack.MessagePackWriter writer, ulong[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd81d8*/ ulong[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class SingleFormatter : MessagePack.Formatters.IMessagePackFormatter<float>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.SingleFormatter Instance;

            static /*0x6fd8400*/ SingleFormatter();
            /*0x6fd83e0*/ SingleFormatter();
            /*0x6fd83e8*/ void Serialize(ref MessagePack.MessagePackWriter writer, float value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd83f4*/ float Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableSingleFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<float>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableSingleFormatter Instance;

            static /*0x6fd85c0*/ NullableSingleFormatter();
            /*0x6fd8468*/ NullableSingleFormatter();
            /*0x6fd8470*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<float> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd8504*/ System.Nullable<float> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class SingleArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Single[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.SingleArrayFormatter Instance;

            static /*0x6fd888c*/ SingleArrayFormatter();
            /*0x6fd8628*/ SingleArrayFormatter();
            /*0x6fd8630*/ void Serialize(ref MessagePack.MessagePackWriter writer, float[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd86ec*/ float[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class DoubleFormatter : MessagePack.Formatters.IMessagePackFormatter<double>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.DoubleFormatter Instance;

            static /*0x6fd8914*/ DoubleFormatter();
            /*0x6fd88f4*/ DoubleFormatter();
            /*0x6fd88fc*/ void Serialize(ref MessagePack.MessagePackWriter writer, double value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd8908*/ double Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableDoubleFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<double>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableDoubleFormatter Instance;

            static /*0x6fd8ad8*/ NullableDoubleFormatter();
            /*0x6fd897c*/ NullableDoubleFormatter();
            /*0x6fd8984*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<double> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd8a18*/ System.Nullable<double> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class DoubleArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Double[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.DoubleArrayFormatter Instance;

            static /*0x6fd8da4*/ DoubleArrayFormatter();
            /*0x6fd8b40*/ DoubleArrayFormatter();
            /*0x6fd8b48*/ void Serialize(ref MessagePack.MessagePackWriter writer, double[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd8c04*/ double[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class BooleanFormatter : MessagePack.Formatters.IMessagePackFormatter<bool>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.BooleanFormatter Instance;

            static /*0x6fd8e34*/ BooleanFormatter();
            /*0x6fd8e0c*/ BooleanFormatter();
            /*0x6fd8e14*/ void Serialize(ref MessagePack.MessagePackWriter writer, bool value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd8e28*/ bool Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableBooleanFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<bool>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableBooleanFormatter Instance;

            static /*0x6fd8ffc*/ NullableBooleanFormatter();
            /*0x6fd8e9c*/ NullableBooleanFormatter();
            /*0x6fd8ea4*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<bool> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd8f3c*/ System.Nullable<bool> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class BooleanArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Boolean[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.BooleanArrayFormatter Instance;

            static /*0x6fd9538*/ BooleanArrayFormatter();
            /*0x6fd9064*/ BooleanArrayFormatter();
            /*0x6fd906c*/ void Serialize(ref MessagePack.MessagePackWriter writer, bool[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd9128*/ bool[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ByteFormatter : MessagePack.Formatters.IMessagePackFormatter<byte>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.ByteFormatter Instance;

            static /*0x6fd95c4*/ ByteFormatter();
            /*0x6fd95a0*/ ByteFormatter();
            /*0x6fd95a8*/ void Serialize(ref MessagePack.MessagePackWriter writer, byte value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd95b8*/ byte Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableByteFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<byte>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableByteFormatter Instance;

            static /*0x6fd978c*/ NullableByteFormatter();
            /*0x6fd962c*/ NullableByteFormatter();
            /*0x6fd9634*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<byte> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd96cc*/ System.Nullable<byte> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class SByteFormatter : MessagePack.Formatters.IMessagePackFormatter<sbyte>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.SByteFormatter Instance;

            static /*0x6fd9818*/ SByteFormatter();
            /*0x6fd97f4*/ SByteFormatter();
            /*0x6fd97fc*/ void Serialize(ref MessagePack.MessagePackWriter writer, sbyte value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd980c*/ sbyte Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableSByteFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<sbyte>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableSByteFormatter Instance;

            static /*0x6fd99e0*/ NullableSByteFormatter();
            /*0x6fd9880*/ NullableSByteFormatter();
            /*0x6fd9888*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<sbyte> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd9920*/ System.Nullable<sbyte> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class SByteArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.SByte[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.SByteArrayFormatter Instance;

            static /*0x6fd9cac*/ SByteArrayFormatter();
            /*0x6fd9a48*/ SByteArrayFormatter();
            /*0x6fd9a50*/ void Serialize(ref MessagePack.MessagePackWriter writer, sbyte[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd9b0c*/ sbyte[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class CharFormatter : MessagePack.Formatters.IMessagePackFormatter<char>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.CharFormatter Instance;

            static /*0x6fd9d38*/ CharFormatter();
            /*0x6fd9d14*/ CharFormatter();
            /*0x6fd9d1c*/ void Serialize(ref MessagePack.MessagePackWriter writer, char value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd9d2c*/ char Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableCharFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<char>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableCharFormatter Instance;

            static /*0x6fd9f00*/ NullableCharFormatter();
            /*0x6fd9da0*/ NullableCharFormatter();
            /*0x6fd9da8*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<char> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fd9e40*/ System.Nullable<char> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class CharArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Char[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.CharArrayFormatter Instance;

            static /*0x6fda1cc*/ CharArrayFormatter();
            /*0x6fd9f68*/ CharArrayFormatter();
            /*0x6fd9f70*/ void Serialize(ref MessagePack.MessagePackWriter writer, char[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fda02c*/ char[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class DateTimeFormatter : MessagePack.Formatters.IMessagePackFormatter<System.DateTime>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.DateTimeFormatter Instance;

            static /*0x6fda258*/ DateTimeFormatter();
            /*0x6fda234*/ DateTimeFormatter();
            /*0x6fda23c*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.DateTime value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fda24c*/ System.DateTime Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableDateTimeFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<System.DateTime>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableDateTimeFormatter Instance;

            static /*0x6fda424*/ NullableDateTimeFormatter();
            /*0x6fda2c0*/ NullableDateTimeFormatter();
            /*0x6fda2c8*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<System.DateTime> value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fda360*/ System.Nullable<System.DateTime> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class DateTimeArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.DateTime[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.DateTimeArrayFormatter Instance;

            static /*0x6fda6e8*/ DateTimeArrayFormatter();
            /*0x6fda48c*/ DateTimeArrayFormatter();
            /*0x6fda494*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.DateTime[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fda548*/ System.DateTime[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class PrimitiveObjectFormatter : MessagePack.Formatters.IMessagePackFormatter<object>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<object> Instance;
            static /*0x8*/ System.Collections.Generic.Dictionary<System.Type, int> TypeToJumpCode;

            static /*0x6fdbf74*/ PrimitiveObjectFormatter();
            static /*0x6fda758*/ bool IsSupportedType(System.Type type, System.Reflection.TypeInfo typeInfo, object value);
            /*0x6fda750*/ PrimitiveObjectFormatter();
            /*0x6fda864*/ void Serialize(ref MessagePack.MessagePackWriter writer, object value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fdb358*/ object Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
            /*0x6fdbd28*/ object DeserializeMap(ref MessagePack.MessagePackReader reader, int length, MessagePack.MessagePackSerializerOptions options);
        }

        class ByteArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Byte[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.ByteArrayFormatter Instance;

            static /*0x6fdc5f0*/ ByteArrayFormatter();
            /*0x6fdc2b0*/ ByteArrayFormatter();
            /*0x6fdc2b8*/ void Serialize(ref MessagePack.MessagePackWriter writer, byte[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fdc2c8*/ byte[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableStringFormatter : MessagePack.Formatters.IMessagePackFormatter<string>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableStringFormatter Instance;

            static /*0x6fdc67c*/ NullableStringFormatter();
            /*0x6fdc658*/ NullableStringFormatter();
            /*0x6fdc660*/ void Serialize(ref MessagePack.MessagePackWriter writer, string value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fdc670*/ string Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableStringArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.String[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableStringArrayFormatter Instance;

            static /*0x6fdc954*/ NullableStringArrayFormatter();
            /*0x6fdc6e4*/ NullableStringArrayFormatter();
            /*0x6fdc6ec*/ void Serialize(ref MessagePack.MessagePackWriter writer, string[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fdc7a0*/ string[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class DecimalFormatter : MessagePack.Formatters.IMessagePackFormatter<decimal>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.DecimalFormatter Instance;

            static /*0x6fdd26c*/ DecimalFormatter();
            /*0x6fdc9bc*/ DecimalFormatter();
            /*0x6fdc9c4*/ void Serialize(ref MessagePack.MessagePackWriter writer, decimal value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fdcbc8*/ decimal Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class TimeSpanFormatter : MessagePack.Formatters.IMessagePackFormatter<System.TimeSpan>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.TimeSpan> Instance;

            static /*0x6fdd350*/ TimeSpanFormatter();
            /*0x6fdd2d4*/ TimeSpanFormatter();
            /*0x6fdd2dc*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.TimeSpan value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fdd344*/ System.TimeSpan Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class DateTimeOffsetFormatter : MessagePack.Formatters.IMessagePackFormatter<System.DateTimeOffset>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.DateTimeOffset> Instance;

            static /*0x6fdd638*/ DateTimeOffsetFormatter();
            /*0x6fdd3b8*/ DateTimeOffsetFormatter();
            /*0x6fdd3c0*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.DateTimeOffset value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fdd4f8*/ System.DateTimeOffset Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class GuidFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Guid>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Guid> Instance;

            static /*0x6fdda30*/ GuidFormatter();
            /*0x6fdd6a0*/ GuidFormatter();
            /*0x6fdd6a8*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Guid value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fdd7a4*/ System.Guid Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class UriFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Uri>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Uri> Instance;

            static /*0x6fddbbc*/ UriFormatter();
            /*0x6fdda98*/ UriFormatter();
            /*0x6fddaa0*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Uri value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fddb48*/ System.Uri Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class VersionFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Version>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Version> Instance;

            static /*0x6fddd04*/ VersionFormatter();
            /*0x6fddc24*/ VersionFormatter();
            /*0x6fddc2c*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Version value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fddc94*/ System.Version Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class KeyValuePairFormatter<TKey, TValue> : MessagePack.Formatters.IMessagePackFormatter<System.Collections.Generic.KeyValuePair<TKey, TValue>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x380cb08*/ KeyValuePairFormatter();
            /*0x3907c14*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Collections.Generic.KeyValuePair<TKey, TValue> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ System.Collections.Generic.KeyValuePair<TKey, TValue> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class StringBuilderFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Text.StringBuilder>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Text.StringBuilder> Instance;

            static /*0x6fdde7c*/ StringBuilderFormatter();
            /*0x6fddd6c*/ StringBuilderFormatter();
            /*0x6fddd74*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Text.StringBuilder value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fdddb4*/ System.Text.StringBuilder Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class BitArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Collections.BitArray>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Collections.BitArray> Instance;

            static /*0x6fde0b4*/ BitArrayFormatter();
            /*0x6fddee4*/ BitArrayFormatter();
            /*0x6fddeec*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Collections.BitArray value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fddf98*/ System.Collections.BitArray Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class BigIntegerFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Numerics.BigInteger>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Numerics.BigInteger> Instance;

            static /*0x6fde2b8*/ BigIntegerFormatter();
            /*0x6fde11c*/ BigIntegerFormatter();
            /*0x6fde124*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Numerics.BigInteger value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fde19c*/ System.Numerics.BigInteger Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ComplexFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Numerics.Complex>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Numerics.Complex> Instance;

            static /*0x6fde468*/ ComplexFormatter();
            /*0x6fde320*/ ComplexFormatter();
            /*0x6fde328*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Numerics.Complex value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fde3b4*/ System.Numerics.Complex Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class Vector2Formatter : MessagePack.Formatters.IMessagePackFormatter<System.Numerics.Vector2>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Numerics.Vector2> Instance;

            static /*0x6fde5d0*/ Vector2Formatter();
            /*0x6fde4d0*/ Vector2Formatter();
            /*0x6fde4d8*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Numerics.Vector2 value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fde524*/ System.Numerics.Vector2 Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class Vector3Formatter : MessagePack.Formatters.IMessagePackFormatter<System.Numerics.Vector3>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Numerics.Vector3> Instance;

            static /*0x6fde778*/ Vector3Formatter();
            /*0x6fde638*/ Vector3Formatter();
            /*0x6fde640*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Numerics.Vector3 value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fde6a8*/ System.Numerics.Vector3 Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class Vector4Formatter : MessagePack.Formatters.IMessagePackFormatter<System.Numerics.Vector4>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Numerics.Vector4> Instance;

            static /*0x6fde94c*/ Vector4Formatter();
            /*0x6fde7e0*/ Vector4Formatter();
            /*0x6fde7e8*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Numerics.Vector4 value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fde864*/ System.Numerics.Vector4 Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class QuaternionFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Numerics.Quaternion>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Numerics.Quaternion> Instance;

            static /*0x6fdeb20*/ QuaternionFormatter();
            /*0x6fde9b4*/ QuaternionFormatter();
            /*0x6fde9bc*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Numerics.Quaternion value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fdea38*/ System.Numerics.Quaternion Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class Matrix3x2Formatter : MessagePack.Formatters.IMessagePackFormatter<System.Numerics.Matrix3x2>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Numerics.Matrix3x2> Instance;

            static /*0x6fded2c*/ Matrix3x2Formatter();
            /*0x6fdeb88*/ Matrix3x2Formatter();
            /*0x6fdeb90*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Numerics.Matrix3x2 value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fdec18*/ System.Numerics.Matrix3x2 Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class Matrix4x4Formatter : MessagePack.Formatters.IMessagePackFormatter<System.Numerics.Matrix4x4>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Numerics.Matrix4x4> Instance;

            static /*0x6fdf0ac*/ Matrix4x4Formatter();
            /*0x6fded94*/ Matrix4x4Formatter();
            /*0x6fded9c*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Numerics.Matrix4x4 value, MessagePack.MessagePackSerializerOptions options);
            /*0x6fdeec4*/ System.Numerics.Matrix4x4 Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class LazyFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<System.Lazy<T>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x380cb08*/ LazyFormatter();
            /*0x380da4c*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Lazy<T> value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bcbc*/ System.Lazy<T> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);

            class <>c__DisplayClass1_0<T>
            {
                /*0x0*/ T v;

                /*0x380cb08*/ <>c__DisplayClass1_0();
                /*0x3907c14*/ T <Deserialize>b__0();
            }
        }

        class TypeFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<T>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Instance;

            static /*0x38358cc*/ TypeFormatter();
            /*0x380cb08*/ TypeFormatter();
            /*0x3907c14*/ void Serialize(ref MessagePack.MessagePackWriter writer, T value, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ T Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class TupleFormatter<T1> : MessagePack.Formatters.IMessagePackFormatter<System.Tuple<T1>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x380cb08*/ TupleFormatter();
            /*0x380da4c*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Tuple<T1> value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bcbc*/ System.Tuple<T1> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class TupleFormatter<T1, T2> : MessagePack.Formatters.IMessagePackFormatter<System.Tuple<T1, T2>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x380cb08*/ TupleFormatter();
            /*0x380da4c*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Tuple<T1, T2> value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bcbc*/ System.Tuple<T1, T2> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class TupleFormatter<T1, T2, T3> : MessagePack.Formatters.IMessagePackFormatter<System.Tuple<T1, T2, T3>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x380cb08*/ TupleFormatter();
            /*0x380da4c*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Tuple<T1, T2, T3> value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bcbc*/ System.Tuple<T1, T2, T3> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class TupleFormatter<T1, T2, T3, T4> : MessagePack.Formatters.IMessagePackFormatter<System.Tuple<T1, T2, T3, T4>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x380cb08*/ TupleFormatter();
            /*0x380da4c*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Tuple<T1, T2, T3, T4> value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bcbc*/ System.Tuple<T1, T2, T3, T4> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class TupleFormatter<T1, T2, T3, T4, T5> : MessagePack.Formatters.IMessagePackFormatter<System.Tuple<T1, T2, T3, T4, T5>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x380cb08*/ TupleFormatter();
            /*0x380da4c*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Tuple<T1, T2, T3, T4, T5> value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bcbc*/ System.Tuple<T1, T2, T3, T4, T5> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class TupleFormatter<T1, T2, T3, T4, T5, T6> : MessagePack.Formatters.IMessagePackFormatter<System.Tuple<T1, T2, T3, T4, T5, T6>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x380cb08*/ TupleFormatter();
            /*0x380da4c*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Tuple<T1, T2, T3, T4, T5, T6> value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bcbc*/ System.Tuple<T1, T2, T3, T4, T5, T6> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class TupleFormatter<T1, T2, T3, T4, T5, T6, T7> : MessagePack.Formatters.IMessagePackFormatter<System.Tuple<T1, T2, T3, T4, T5, T6, T7>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x380cb08*/ TupleFormatter();
            /*0x380da4c*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Tuple<T1, T2, T3, T4, T5, T6, T7> value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bcbc*/ System.Tuple<T1, T2, T3, T4, T5, T6, T7> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class TupleFormatter<T1, T2, T3, T4, T5, T6, T7, TRest> : MessagePack.Formatters.IMessagePackFormatter<System.Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x380cb08*/ TupleFormatter();
            /*0x380da4c*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> value, MessagePack.MessagePackSerializerOptions options);
            /*0x380bcbc*/ System.Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ValueTupleFormatter<T1> : MessagePack.Formatters.IMessagePackFormatter<System.ValueTuple<T1>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x380cb08*/ ValueTupleFormatter();
            /*0x3907c14*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.ValueTuple<T1> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ System.ValueTuple<T1> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ValueTupleFormatter<T1, T2> : MessagePack.Formatters.IMessagePackFormatter<System.ValueTuple<T1, T2>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x380cb08*/ ValueTupleFormatter();
            /*0x3907c14*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.ValueTuple<T1, T2> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ System.ValueTuple<T1, T2> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ValueTupleFormatter<T1, T2, T3> : MessagePack.Formatters.IMessagePackFormatter<System.ValueTuple<T1, T2, T3>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x380cb08*/ ValueTupleFormatter();
            /*0x3907c14*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.ValueTuple<T1, T2, T3> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ System.ValueTuple<T1, T2, T3> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ValueTupleFormatter<T1, T2, T3, T4> : MessagePack.Formatters.IMessagePackFormatter<System.ValueTuple<T1, T2, T3, T4>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x380cb08*/ ValueTupleFormatter();
            /*0x3907c14*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.ValueTuple<T1, T2, T3, T4> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ System.ValueTuple<T1, T2, T3, T4> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ValueTupleFormatter<T1, T2, T3, T4, T5> : MessagePack.Formatters.IMessagePackFormatter<System.ValueTuple<T1, T2, T3, T4, T5>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x380cb08*/ ValueTupleFormatter();
            /*0x3907c14*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.ValueTuple<T1, T2, T3, T4, T5> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ System.ValueTuple<T1, T2, T3, T4, T5> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ValueTupleFormatter<T1, T2, T3, T4, T5, T6> : MessagePack.Formatters.IMessagePackFormatter<System.ValueTuple<T1, T2, T3, T4, T5, T6>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x380cb08*/ ValueTupleFormatter();
            /*0x3907c14*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.ValueTuple<T1, T2, T3, T4, T5, T6> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ System.ValueTuple<T1, T2, T3, T4, T5, T6> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ValueTupleFormatter<T1, T2, T3, T4, T5, T6, T7> : MessagePack.Formatters.IMessagePackFormatter<System.ValueTuple<T1, T2, T3, T4, T5, T6, T7>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x380cb08*/ ValueTupleFormatter();
            /*0x3907c14*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.ValueTuple<T1, T2, T3, T4, T5, T6, T7> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ System.ValueTuple<T1, T2, T3, T4, T5, T6, T7> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ValueTupleFormatter<T1, T2, T3, T4, T5, T6, T7, TRest> : MessagePack.Formatters.IMessagePackFormatter<System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x380cb08*/ ValueTupleFormatter();
            /*0x3907c14*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> value, MessagePack.MessagePackSerializerOptions options);
            /*0x3907c14*/ System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
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

                /*0x6fdf114*/ CompilerFeatureRequiredAttribute(string featureName);
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
