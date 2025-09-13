class <Module>
{
}

class <>f__AnonymousType0<<Label>j__TPar, <Attr>j__TPar>
{
    /*0x0*/ <Label> <Label>i__Field;
    /*0x0*/ <Attr> <Attr>i__Field;

    <>f__AnonymousType0(<Label> Label, <Attr> Attr);
    <Label> get_Label();
    <Attr> get_Attr();
    bool Equals(object value);
    int GetHashCode();
    string ToString();
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x1538dac*/ EmbeddedAttribute();
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
                /*0x2302db8*/ IsUnmanagedAttribute();
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
            /*0x0*/ System.Collections.Generic.Stack<Nerdbank.Streams.Sequence.SequenceSegment<T>> segmentPool;
            /*0x0*/ System.Buffers.MemoryPool<T> memoryPool;
            /*0x0*/ System.Buffers.ArrayPool<T> arrayPool;
            /*0x0*/ Nerdbank.Streams.Sequence.SequenceSegment<T> first;
            /*0x0*/ Nerdbank.Streams.Sequence.SequenceSegment<T> last;
            /*0x0*/ int <MinimumSpanLength>k__BackingField;

            static Sequence();
            static System.Buffers.ReadOnlySequence<T> op_Implicit(Nerdbank.Streams.Sequence<T> sequence);
            Sequence();
            Sequence(System.Buffers.MemoryPool<T> memoryPool);
            Sequence(System.Buffers.ArrayPool<T> arrayPool);
            int get_MinimumSpanLength();
            void set_MinimumSpanLength(int value);
            System.Buffers.ReadOnlySequence<T> get_AsReadOnlySequence();
            long get_Length();
            string get_DebuggerDisplay();
            void AdvanceTo(System.SequencePosition position);
            void Advance(int count);
            System.Memory<T> GetMemory(int sizeHint);
            System.Span<T> GetSpan(int sizeHint);
            void Dispose();
            void Reset();
            Nerdbank.Streams.Sequence.SequenceSegment<T> GetSegment(int sizeHint);
            void Append(Nerdbank.Streams.Sequence.SequenceSegment<T> segment);
            Nerdbank.Streams.Sequence.SequenceSegment<T> RecycleAndGetNext(Nerdbank.Streams.Sequence.SequenceSegment<T> segment);

            class SequenceSegment<T> : System.Buffers.ReadOnlySequenceSegment<T>
            {
                static /*0x0*/ bool MayContainReferences;
                /*0x0*/ T[] array;
                /*0x0*/ int <Start>k__BackingField;
                /*0x0*/ int <End>k__BackingField;
                /*0x0*/ System.Buffers.IMemoryOwner<T> <MemoryOwner>k__BackingField;

                static SequenceSegment();
                SequenceSegment();
                int get_Start();
                void set_Start(int value);
                int get_End();
                void set_End(int value);
                System.Memory<T> get_RemainingMemory();
                System.Span<T> get_RemainingSpan();
                System.Buffers.IMemoryOwner<T> get_MemoryOwner();
                void set_MemoryOwner(System.Buffers.IMemoryOwner<T> value);
                System.Memory<T> get_AvailableMemory();
                int get_Length();
                int get_WritableBytes();
                Nerdbank.Streams.Sequence.SequenceSegment<T> get_Next();
                void set_Next(Nerdbank.Streams.Sequence.SequenceSegment<T> value);
                void Assign(System.Buffers.IMemoryOwner<T> memoryOwner);
                void Assign(T[] array);
                void ResetMemory(System.Buffers.ArrayPool<T> arrayPool);
                void SetNext(Nerdbank.Streams.Sequence.SequenceSegment<T> segment);
                void Advance(int count);
                void AdvanceTo(int offset);
                void ClearReferences(int startIndex, int length);
            }
        }

        class Requires
        {
            static /*0x178e2ac*/ void Range(bool condition, string parameterName, string message);
            static /*0x178e2c8*/ System.Exception FailRange(string parameterName, string message);
            static T NotNull<T>(T value, string parameterName);
            static /*0x178e33c*/ void Argument(bool condition, string parameterName, string message);
            static /*0x178e398*/ void Argument(bool condition, string parameterName, string message, object arg1);
            static /*0x178e404*/ void Argument(bool condition, string parameterName, string message, object arg1, object arg2);
            static /*0x178e474*/ void Argument(bool condition, string parameterName, string message, object[] args);
        }

        class Verify
        {
            static /*0x1847ae0*/ void Operation(bool condition, string message);
        }
    }
}

namespace System
{
    struct HashCode
    {
        static uint Prime1 = 2654435761;
        static uint Prime2 = 2246822519;
        static uint Prime3 = 3266489917;
        static uint Prime4 = 668265263;
        static uint Prime5 = 374761393;
        static /*0x0*/ uint s_seed;
        /*0x10*/ uint _v1;
        /*0x14*/ uint _v2;
        /*0x18*/ uint _v3;
        /*0x1c*/ uint _v4;
        /*0x20*/ uint _queue1;
        /*0x24*/ uint _queue2;
        /*0x28*/ uint _queue3;
        /*0x2c*/ uint _length;

        static /*0x22ffdc4*/ HashCode();
        static /*0x22ff654*/ uint GenerateGlobalSeed();
        static int Combine<T1>(T1 value1);
        static int Combine<T1, T2>(T1 value1, T2 value2);
        static int Combine<T1, T2, T3>(T1 value1, T2 value2, T3 value3);
        static int Combine<T1, T2, T3, T4>(T1 value1, T2 value2, T3 value3, T4 value4);
        static int Combine<T1, T2, T3, T4, T5>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5);
        static int Combine<T1, T2, T3, T4, T5, T6>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6);
        static int Combine<T1, T2, T3, T4, T5, T6, T7>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7);
        static int Combine<T1, T2, T3, T4, T5, T6, T7, T8>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8);
        static /*0x22ff7f4*/ void Initialize(ref uint v1, ref uint v2, ref uint v3, ref uint v4);
        static /*0x22ff8d0*/ uint Round(uint hash, uint input);
        static /*0x22ff8f0*/ uint QueueRound(uint hash, uint queuedValue);
        static /*0x22ff910*/ uint MixState(uint v1, uint v2, uint v3, uint v4);
        static /*0x22ff930*/ uint MixEmptyState();
        static /*0x22ff9a0*/ uint MixFinal(uint hash);
        void Add<T>(T value);
        void Add<T>(T value, System.Collections.Generic.IEqualityComparer<T> comparer);
        /*0xae48ec*/ void Add(int value);
        /*0xae48f4*/ int ToHashCode();
        /*0xae48fc*/ int GetHashCode();
        /*0xae4908*/ bool Equals(object obj);
    }

    namespace Buffers
    {
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

            SequenceReader(ref System.Buffers.ReadOnlySequence<T> sequence);
            SequenceReader(System.ReadOnlyMemory<T> memory);
            bool get_End();
            System.Buffers.ReadOnlySequence<T> get_Sequence();
            System.SequencePosition get_Position();
            System.ReadOnlySpan<T> get_CurrentSpan();
            void set_CurrentSpan(System.ReadOnlySpan<T> value);
            int get_CurrentSpanIndex();
            void set_CurrentSpanIndex(int value);
            System.ReadOnlySpan<T> get_UnreadSpan();
            long get_Consumed();
            void set_Consumed(long value);
            long get_Remaining();
            long get_Length();
            bool TryPeek(ref T value);
            bool TryRead(ref T value);
            void Rewind(long count);
            void RetreatToPreviousSpan(long consumed);
            void ResetReader();
            void GetNextSpan();
            void Advance(long count);
            void AdvanceCurrentSpan(long count);
            void AdvanceWithinSpan(long count);
            bool TryAdvance(long count);
            void AdvanceToNextSpan(long count);
            bool TryCopyTo(System.Span<T> destination);
            bool TryCopyMultisegment(System.Span<T> destination);
        }

        class SequenceReaderExtensions
        {
            static bool TryRead<T>(ref System.Buffers.SequenceReader<byte> reader, ref T value);
            static /*0x178ead4*/ bool TryRead(ref System.Buffers.SequenceReader<byte> reader, ref long value);
            static /*0x178ecf0*/ long BitConverterToInt64(System.ReadOnlySpan<byte> value);
            static bool TryReadMultisegment<T>(ref System.Buffers.SequenceReader<byte> reader, ref T value);
            static /*0x178ebb8*/ bool TryReadMultisegment(ref System.Buffers.SequenceReader<byte> reader, ref long value);
            static /*0x178eec8*/ bool TryRead(ref System.Buffers.SequenceReader<byte> reader, ref sbyte value);
            static /*0x178ef40*/ bool TryReadBigEndian(ref System.Buffers.SequenceReader<byte> reader, ref short value);
            static /*0x178f070*/ bool TryReadBigEndian(ref System.Buffers.SequenceReader<byte> reader, ref ushort value);
            static /*0x178eff0*/ bool TryReadReverseEndianness(ref System.Buffers.SequenceReader<byte> reader, ref short value);
            static /*0x178f0ac*/ bool TryReadBigEndian(ref System.Buffers.SequenceReader<byte> reader, ref int value);
            static /*0x178f1d8*/ bool TryReadBigEndian(ref System.Buffers.SequenceReader<byte> reader, ref uint value);
            static /*0x178f15c*/ bool TryReadReverseEndianness(ref System.Buffers.SequenceReader<byte> reader, ref int value);
            static /*0x178f214*/ bool TryReadBigEndian(ref System.Buffers.SequenceReader<byte> reader, ref long value);
            static /*0x178f464*/ bool TryReadBigEndian(ref System.Buffers.SequenceReader<byte> reader, ref ulong value);
            static /*0x178f364*/ bool TryReadReverseEndianness(ref System.Buffers.SequenceReader<byte> reader, ref long value);
            static /*0x178f4a0*/ bool TryReadBigEndian(ref System.Buffers.SequenceReader<byte> reader, ref float value);
            static /*0x178f4e4*/ bool TryReadBigEndian(ref System.Buffers.SequenceReader<byte> reader, ref double value);
        }
    }

    namespace Numerics
    {
        class BitOperations
        {
            static /*0x151ea94*/ uint RotateLeft(uint value, int offset);
        }
    }
}

namespace MessagePack
{
    class MessagePackObjectAttribute : System.Attribute
    {
        /*0x10*/ bool <KeyAsPropertyName>k__BackingField;

        /*0x230b500*/ MessagePackObjectAttribute(bool keyAsPropertyName);
        /*0x230b4ec*/ bool get_KeyAsPropertyName();
        /*0x230b4f4*/ void set_KeyAsPropertyName(bool value);
    }

    class KeyAttribute : System.Attribute
    {
        /*0x10*/ System.Nullable<int> <IntKey>k__BackingField;
        /*0x18*/ string <StringKey>k__BackingField;

        /*0x2302de0*/ KeyAttribute(int x);
        /*0x2302e58*/ KeyAttribute(string x);
        /*0x2302dc0*/ System.Nullable<int> get_IntKey();
        /*0x2302dc8*/ void set_IntKey(System.Nullable<int> value);
        /*0x2302dd0*/ string get_StringKey();
        /*0x2302dd8*/ void set_StringKey(string value);
    }

    class IgnoreMemberAttribute : System.Attribute
    {
        /*0x23014a8*/ IgnoreMemberAttribute();
    }

    class UnionAttribute : System.Attribute
    {
        /*0x10*/ int <Key>k__BackingField;
        /*0x18*/ System.Type <SubType>k__BackingField;

        /*0x18419f0*/ UnionAttribute(int key, System.Type subType);
        /*0x18419d0*/ int get_Key();
        /*0x18419d8*/ void set_Key(int value);
        /*0x18419e0*/ System.Type get_SubType();
        /*0x18419e8*/ void set_SubType(System.Type value);
    }

    class SerializationConstructorAttribute : System.Attribute
    {
        /*0x178f528*/ SerializationConstructorAttribute();
    }

    class MessagePackFormatterAttribute : System.Attribute
    {
        /*0x10*/ System.Type <FormatterType>k__BackingField;
        /*0x18*/ object[] <Arguments>k__BackingField;

        /*0x230b488*/ MessagePackFormatterAttribute(System.Type formatterType);
        /*0x230b4b4*/ MessagePackFormatterAttribute(System.Type formatterType, object[] arguments);
        /*0x230b468*/ System.Type get_FormatterType();
        /*0x230b470*/ void set_FormatterType(System.Type value);
        /*0x230b478*/ object[] get_Arguments();
        /*0x230b480*/ void set_Arguments(object[] value);
    }

    interface IMessagePackSerializationCallbackReceiver
    {
        void OnBeforeSerialize();
        void OnAfterDeserialize();
    }

    struct BufferWriter
    {
        /*0x10*/ System.Buffers.IBufferWriter<byte> _output;
        /*0x18*/ System.Span<byte> _span;
        /*0x30*/ System.ArraySegment<byte> _segment;
        /*0x40*/ int _buffered;
        /*0x48*/ long _bytesCommitted;
        /*0x50*/ MessagePack.SequencePool _sequencePool;
        /*0x58*/ MessagePack.SequencePool.Rental _rental;

        /*0xaa4254*/ BufferWriter(System.Buffers.IBufferWriter<byte> output);
        /*0xaa43a0*/ BufferWriter(MessagePack.SequencePool sequencePool, byte[] array);
        /*0xaa44fc*/ System.Span<byte> get_Span();
        /*0xaa4510*/ long get_BytesCommitted();
        /*0xaa4518*/ System.Buffers.IBufferWriter<byte> get_UnderlyingWriter();
        /*0xaa4520*/ MessagePack.SequencePool.Rental get_SequenceRental();
        /*0xaa452c*/ System.Span<byte> GetSpan(int sizeHint);
        /*0xaa456c*/ ref byte GetPointer(int sizeHint);
        /*0xaa4658*/ void Commit();
        /*0xaa4740*/ void Advance(int count);
        /*0xaa4838*/ void Write(System.ReadOnlySpan<byte> source);
        /*0xaa49dc*/ void Ensure(int count);
        /*0xaa4a48*/ bool TryGetUncommittedSpan(ref System.ReadOnlySpan<byte> span);
        /*0xaa4a50*/ void EnsureMore(int count);
        /*0xaa4a58*/ void WriteMultiBuffer(System.ReadOnlySpan<byte> source);
        /*0xaa4a8c*/ void MigrateToSequence();
    }

    struct ExtensionHeader : System.IEquatable<MessagePack.ExtensionHeader>
    {
        /*0x10*/ sbyte <TypeCode>k__BackingField;
        /*0x14*/ uint <Length>k__BackingField;

        /*0xaa5048*/ ExtensionHeader(sbyte typeCode, uint length);
        /*0xaa5054*/ ExtensionHeader(sbyte typeCode, int length);
        /*0xaa5028*/ sbyte get_TypeCode();
        /*0xaa5030*/ void set_TypeCode(sbyte value);
        /*0xaa5038*/ uint get_Length();
        /*0xaa5040*/ void set_Length(uint value);
        /*0xaa5060*/ bool Equals(MessagePack.ExtensionHeader other);
    }

    struct ExtensionResult
    {
        /*0x10*/ sbyte <TypeCode>k__BackingField;
        /*0x18*/ System.Buffers.ReadOnlySequence<byte> <Data>k__BackingField;

        /*0xaa50c4*/ ExtensionResult(sbyte typeCode, System.Memory<byte> data);
        /*0xaa50cc*/ ExtensionResult(sbyte typeCode, System.Buffers.ReadOnlySequence<byte> data);
        /*0xaa50e8*/ sbyte get_TypeCode();
        /*0xaa50f0*/ void set_TypeCode(sbyte value);
        /*0xaa50f8*/ System.Buffers.ReadOnlySequence<byte> get_Data();
        /*0xaa5108*/ void set_Data(System.Buffers.ReadOnlySequence<byte> value);
        /*0xaa5118*/ MessagePack.ExtensionHeader get_Header();
    }

    interface IFormatterResolver
    {
        MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();
    }

    class FormatterResolverExtensions
    {
        static /*0x0*/ MessagePack.Internal.ThreadsafeTypeKeyHashTable<System.Func<MessagePack.IFormatterResolver, MessagePack.Formatters.IMessagePackFormatter>> FormatterGetters;
        static /*0x8*/ System.Reflection.MethodInfo GetFormatterRuntimeMethod;

        static /*0x22fbfd4*/ FormatterResolverExtensions();
        static MessagePack.Formatters.IMessagePackFormatter<T> GetFormatterWithVerify<T>(MessagePack.IFormatterResolver resolver);
        static /*0x22fbab8*/ void Throw(System.TypeInitializationException ex);
        static /*0x22fbaec*/ void Throw(System.Type t, MessagePack.IFormatterResolver resolver);
        static /*0x22fbbb8*/ object GetFormatterDynamic(MessagePack.IFormatterResolver resolver, System.Type type);
        static /*0x22fbf38*/ object GetFormatterDynamicWithVerify(MessagePack.IFormatterResolver resolver, System.Type type);
    }

    class FormatterNotRegisteredException : MessagePack.MessagePackSerializationException
    {
        /*0x22fbab0*/ FormatterNotRegisteredException(string message);
    }

    enum TinyJsonToken
    {
        None = 0,
        StartObject = 1,
        EndObject = 2,
        StartArray = 3,
        EndArray = 4,
        Number = 5,
        String = 6,
        True = 7,
        False = 8,
        Null = 9,
    }

    enum ValueType
    {
        Null = 0,
        True = 1,
        False = 2,
        Double = 3,
        Long = 4,
        ULong = 5,
        Decimal = 6,
        String = 7,
    }

    class TinyJsonException : MessagePack.MessagePackSerializationException
    {
        /*0x1791ea0*/ TinyJsonException(string message);
    }

    class TinyJsonReader : System.IDisposable
    {
        /*0x10*/ System.IO.TextReader reader;
        /*0x18*/ bool disposeInnerReader;
        /*0x20*/ System.Text.StringBuilder reusableBuilder;
        /*0x28*/ MessagePack.TinyJsonToken <TokenType>k__BackingField;
        /*0x2c*/ MessagePack.ValueType <ValueType>k__BackingField;
        /*0x30*/ double <DoubleValue>k__BackingField;
        /*0x38*/ long <LongValue>k__BackingField;
        /*0x40*/ ulong <ULongValue>k__BackingField;
        /*0x48*/ decimal <DecimalValue>k__BackingField;
        /*0x58*/ string <StringValue>k__BackingField;

        static /*0x1792510*/ bool IsWordBreak(char c);
        /*0x176f690*/ TinyJsonReader(System.IO.TextReader reader, bool disposeInnerReader);
        /*0x1791ea4*/ MessagePack.TinyJsonToken get_TokenType();
        /*0x1791eac*/ void set_TokenType(MessagePack.TinyJsonToken value);
        /*0x1791eb4*/ MessagePack.ValueType get_ValueType();
        /*0x1791ebc*/ void set_ValueType(MessagePack.ValueType value);
        /*0x1791ec4*/ double get_DoubleValue();
        /*0x1791ecc*/ void set_DoubleValue(double value);
        /*0x1791ed4*/ long get_LongValue();
        /*0x1791edc*/ void set_LongValue(long value);
        /*0x1791ee4*/ ulong get_ULongValue();
        /*0x1791eec*/ void set_ULongValue(ulong value);
        /*0x1791ef4*/ decimal get_DecimalValue();
        /*0x1791f00*/ void set_DecimalValue(decimal value);
        /*0x1791f08*/ string get_StringValue();
        /*0x1791f10*/ void set_StringValue(string value);
        /*0x1773578*/ bool Read();
        /*0x17923e0*/ void Dispose();
        /*0x179241c*/ void SkipWhiteSpace();
        /*0x17924e8*/ char ReadChar();
        /*0x1791f18*/ void ReadNextToken();
        /*0x17920d0*/ void ReadValue();
        /*0x17925a0*/ void ReadNumber();
        /*0x17928b4*/ void ReadString();
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
        static byte MinFixInt = 0;
        static byte MaxFixInt = 127;
        static byte MinFixMap = 128;
        static byte MaxFixMap = 143;
        static byte MinFixArray = 144;
        static byte MaxFixArray = 159;
        static byte MinFixStr = 160;
        static byte MaxFixStr = 191;
        static byte Nil = 192;
        static byte NeverUsed = 193;
        static byte False = 194;
        static byte True = 195;
        static byte Bin8 = 196;
        static byte Bin16 = 197;
        static byte Bin32 = 198;
        static byte Ext8 = 199;
        static byte Ext16 = 200;
        static byte Ext32 = 201;
        static byte Float32 = 202;
        static byte Float64 = 203;
        static byte UInt8 = 204;
        static byte UInt16 = 205;
        static byte UInt32 = 206;
        static byte UInt64 = 207;
        static byte Int8 = 208;
        static byte Int16 = 209;
        static byte Int32 = 210;
        static byte Int64 = 211;
        static byte FixExt1 = 212;
        static byte FixExt2 = 213;
        static byte FixExt4 = 214;
        static byte FixExt8 = 215;
        static byte FixExt16 = 216;
        static byte Str8 = 217;
        static byte Str16 = 218;
        static byte Str32 = 219;
        static byte Array16 = 220;
        static byte Array32 = 221;
        static byte Map16 = 222;
        static byte Map32 = 223;
        static byte MinNegativeFixInt = 224;
        static byte MaxNegativeFixInt = 255;
        static /*0x0*/ MessagePack.MessagePackType[] TypeLookupTable;
        static /*0x8*/ string[] FormatNameTable;

        static /*0x230a0c0*/ MessagePackCode();
        static /*0x230b300*/ MessagePack.MessagePackType ToMessagePackType(byte code);
        static /*0x230b394*/ string ToFormatName(byte code);
        static /*0x230b428*/ bool IsSignedInteger(byte code);
    }

    class ReservedMessagePackExtensionTypeCode
    {
        static sbyte DateTime = -1;
    }

    class MessagePackRange
    {
        static int MinFixNegativeInt = -32;
        static int MaxFixNegativeInt = -1;
        static int MaxFixPositiveInt = 127;
        static int MinFixStringLength = 0;
        static int MaxFixStringLength = 31;
        static int MaxFixMapCount = 15;
        static int MaxFixArrayCount = 15;
    }

    enum MessagePackCompression
    {
        None = 0,
        Lz4Block = 1,
        Lz4BlockArray = 2,
    }

    class MessagePackCompressionExtensions
    {
        static /*0x230b44c*/ bool IsCompression(MessagePack.MessagePackCompression compression);
    }

    struct MessagePackReader
    {
        /*0x10*/ System.Buffers.SequenceReader<byte> reader;
        /*0xa0*/ System.Threading.CancellationToken <CancellationToken>k__BackingField;
        /*0xa8*/ int <Depth>k__BackingField;

        static /*0x230d938*/ System.IO.EndOfStreamException ThrowNotEnoughBytesException();
        static /*0x230c36c*/ System.IO.EndOfStreamException ThrowNotEnoughBytesException(System.Exception innerException);
        static /*0x230bfe4*/ System.Exception ThrowInvalidCode(byte code);
        static /*0x230b91c*/ void ThrowInsufficientBufferUnless(bool condition);
        /*0xae4950*/ MessagePackReader(System.ReadOnlyMemory<byte> memory);
        /*0xae4958*/ MessagePackReader(ref System.Buffers.ReadOnlySequence<byte> readOnlySequence);
        /*0xae4960*/ System.Threading.CancellationToken get_CancellationToken();
        /*0xae4968*/ void set_CancellationToken(System.Threading.CancellationToken value);
        /*0xae4970*/ int get_Depth();
        /*0xae4978*/ void set_Depth(int value);
        /*0xae4980*/ System.Buffers.ReadOnlySequence<byte> get_Sequence();
        /*0xae49b8*/ System.SequencePosition get_Position();
        /*0xae49c0*/ long get_Consumed();
        /*0xae4a00*/ bool get_End();
        /*0xae4a08*/ bool get_IsNil();
        /*0xae4a2c*/ MessagePack.MessagePackType get_NextMessagePackType();
        /*0xae4a34*/ byte get_NextCode();
        /*0xae4a3c*/ MessagePack.MessagePackReader Clone(ref System.Buffers.ReadOnlySequence<byte> readOnlySequence);
        /*0xae4ab0*/ MessagePack.MessagePackReader CreatePeekReader();
        /*0xae4ad0*/ void Skip();
        /*0xae4af0*/ bool TrySkip();
        /*0xae4af8*/ MessagePack.Nil ReadNil();
        /*0xae4b14*/ bool TryReadNil();
        /*0xae4b8c*/ System.Buffers.ReadOnlySequence<byte> ReadRaw(long length);
        /*0xae4bc4*/ System.Buffers.ReadOnlySequence<byte> ReadRaw();
        /*0xae4bfc*/ int ReadArrayHeader();
        /*0xae4c04*/ bool TryReadArrayHeader(ref int count);
        /*0xae4cfc*/ int ReadMapHeader();
        /*0xae4d04*/ bool TryReadMapHeader(ref int count);
        /*0xae4d0c*/ bool ReadBoolean();
        /*0xae4d14*/ char ReadChar();
        /*0xae4d1c*/ float ReadSingle();
        /*0xae4d24*/ double ReadDouble();
        /*0xae4d2c*/ System.DateTime ReadDateTime();
        /*0xae4d58*/ System.DateTime ReadDateTime(MessagePack.ExtensionHeader header);
        /*0xae4d60*/ System.Nullable<System.Buffers.ReadOnlySequence<byte>> ReadBytes();
        /*0xae4da4*/ System.Nullable<System.Buffers.ReadOnlySequence<byte>> ReadStringSequence();
        /*0xae4de8*/ bool TryReadStringSpan(ref System.ReadOnlySpan<byte> span);
        /*0xae4df0*/ string ReadString();
        /*0xae505c*/ MessagePack.ExtensionHeader ReadExtensionFormatHeader();
        /*0xae5064*/ bool TryReadExtensionFormatHeader(ref MessagePack.ExtensionHeader extensionHeader);
        /*0xae506c*/ MessagePack.ExtensionResult ReadExtensionFormat();
        /*0xae50b0*/ int GetBytesLength();
        /*0xae50b8*/ int GetStringLengthInBytes();
        /*0xae5140*/ int GetStringLengthInBytesSlow(byte code);
        /*0xae5148*/ string ReadStringSlow(int byteLength);
        /*0xae5150*/ bool TrySkipNextArray();
        /*0xae5158*/ bool TrySkipNextMap();
        /*0xae5160*/ bool TrySkip(int count);
        /*0xae51b8*/ byte ReadByte();
        /*0xae51c0*/ ushort ReadUInt16();
        /*0xae51c8*/ uint ReadUInt32();
        /*0xae51d0*/ ulong ReadUInt64();
        /*0xae51d8*/ sbyte ReadSByte();
        /*0xae51e0*/ short ReadInt16();
        /*0xae51e8*/ int ReadInt32();
        /*0xae51f0*/ long ReadInt64();
    }

    class MessagePackSecurity
    {
        static /*0x0*/ MessagePack.MessagePackSecurity TrustedData;
        static /*0x8*/ MessagePack.MessagePackSecurity UntrustedData;
        /*0x10*/ MessagePack.MessagePackSecurity.ObjectFallbackEqualityComparer objectFallbackEqualityComparer;
        /*0x18*/ bool <HashCollisionResistant>k__BackingField;
        /*0x1c*/ int <MaximumObjectGraphDepth>k__BackingField;

        static /*0x176c8b4*/ MessagePackSecurity();
        /*0x176c50c*/ MessagePackSecurity();
        /*0x176c580*/ MessagePackSecurity(MessagePack.MessagePackSecurity copyFrom);
        /*0x176c600*/ bool get_HashCollisionResistant();
        /*0x176c608*/ void set_HashCollisionResistant(bool value);
        /*0x176c614*/ int get_MaximumObjectGraphDepth();
        /*0x176c61c*/ void set_MaximumObjectGraphDepth(int value);
        /*0x176c624*/ MessagePack.MessagePackSecurity WithMaximumObjectGraphDepth(int maximumObjectGraphDepth);
        /*0x176c664*/ MessagePack.MessagePackSecurity WithHashCollisionResistant(bool hashCollisionResistant);
        System.Collections.Generic.IEqualityComparer<T> GetEqualityComparer<T>();
        /*0x176c6b0*/ System.Collections.IEqualityComparer GetEqualityComparer();
        System.Collections.Generic.IEqualityComparer<T> GetHashCollisionResistantEqualityComparer<T>();
        /*0x176c718*/ void DepthStep(ref MessagePack.MessagePackReader reader);
        /*0x176c7b4*/ System.Collections.IEqualityComparer GetHashCollisionResistantEqualityComparer();
        /*0x176c858*/ MessagePack.MessagePackSecurity Clone();

        class CollisionResistantHasher<T> : System.Collections.Generic.IEqualityComparer<T>, System.Collections.IEqualityComparer
        {
            static /*0x0*/ MessagePack.MessagePackSecurity.CollisionResistantHasher<T> Instance;

            static CollisionResistantHasher();
            CollisionResistantHasher();
            bool Equals(T x, T y);
            bool System.Collections.IEqualityComparer.Equals(object x, object y);
            int GetHashCode(object obj);
            int GetHashCode(T value);
        }

        class ObjectFallbackEqualityComparer : System.Collections.Generic.IEqualityComparer<object>, System.Collections.IEqualityComparer
        {
            static /*0x0*/ System.Reflection.MethodInfo GetHashCollisionResistantEqualityComparerOpenGenericMethod;
            /*0x10*/ MessagePack.MessagePackSecurity security;
            /*0x18*/ MessagePack.Internal.ThreadsafeTypeKeyHashTable<System.Collections.IEqualityComparer> equalityComparerCache;

            static /*0x1851bf0*/ ObjectFallbackEqualityComparer();
            /*0x1851594*/ ObjectFallbackEqualityComparer(MessagePack.MessagePackSecurity security);
            /*0x1851684*/ bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y);
            /*0x18516f4*/ bool System.Collections.IEqualityComparer.Equals(object x, object y);
            /*0x18517d0*/ int GetHashCode(object value);

            class <>c
            {
                static /*0x0*/ MessagePack.MessagePackSecurity.ObjectFallbackEqualityComparer.<> <>9;

                static /*0x1857604*/ <>c();
                /*0x1857664*/ <>c();
                /*0x185766c*/ bool <.cctor>b__7_0(System.Reflection.MethodInfo m);
            }
        }

        class UInt64EqualityComparer : MessagePack.MessagePackSecurity.CollisionResistantHasher<ulong>
        {
            static /*0x0*/ MessagePack.MessagePackSecurity.UInt64EqualityComparer Instance;

            static /*0x18521c0*/ UInt64EqualityComparer();
            /*0x1852148*/ UInt64EqualityComparer();
            /*0x18520cc*/ int GetHashCode(ulong value);
        }

        class Int64EqualityComparer : MessagePack.MessagePackSecurity.CollisionResistantHasher<long>
        {
            static /*0x0*/ MessagePack.MessagePackSecurity.Int64EqualityComparer Instance;

            static /*0x1851538*/ Int64EqualityComparer();
            /*0x18514c0*/ Int64EqualityComparer();
            /*0x1851444*/ int GetHashCode(long value);
        }

        class SingleEqualityComparer : MessagePack.MessagePackSecurity.CollisionResistantHasher<float>
        {
            static /*0x0*/ MessagePack.MessagePackSecurity.SingleEqualityComparer Instance;

            static /*0x1851eec*/ SingleEqualityComparer();
            /*0x1851e74*/ SingleEqualityComparer();
            /*0x1851d70*/ int GetHashCode(float value);
        }

        class DoubleEqualityComparer : MessagePack.MessagePackSecurity.CollisionResistantHasher<double>
        {
            static /*0x0*/ MessagePack.MessagePackSecurity.DoubleEqualityComparer Instance;

            static /*0x1851288*/ DoubleEqualityComparer();
            /*0x1851210*/ DoubleEqualityComparer();
            /*0x18510ec*/ int GetHashCode(double value);
        }

        class GuidEqualityComparer : MessagePack.MessagePackSecurity.CollisionResistantHasher<System.Guid>
        {
            static /*0x0*/ MessagePack.MessagePackSecurity.GuidEqualityComparer Instance;

            static /*0x18513e8*/ GuidEqualityComparer();
            /*0x1851370*/ GuidEqualityComparer();
            /*0x18512e4*/ int GetHashCode(System.Guid value);
        }

        class StringEqualityComparer : MessagePack.MessagePackSecurity.CollisionResistantHasher<string>
        {
            static /*0x0*/ MessagePack.MessagePackSecurity.StringEqualityComparer Instance;

            static /*0x1852070*/ StringEqualityComparer();
            /*0x1851ff8*/ StringEqualityComparer();
            /*0x1851f48*/ int GetHashCode(string value);
        }

        class DateTimeEqualityComparer : MessagePack.MessagePackSecurity.CollisionResistantHasher<System.DateTime>
        {
            static /*0x0*/ MessagePack.MessagePackSecurity.DateTimeEqualityComparer Instance;

            static /*0x1850f10*/ DateTimeEqualityComparer();
            /*0x1850e98*/ DateTimeEqualityComparer();
            /*0x1850dd8*/ int GetHashCode(System.DateTime value);
        }

        class DateTimeOffsetEqualityComparer : MessagePack.MessagePackSecurity.CollisionResistantHasher<System.DateTimeOffset>
        {
            static /*0x0*/ MessagePack.MessagePackSecurity.DateTimeOffsetEqualityComparer Instance;

            static /*0x1851090*/ DateTimeOffsetEqualityComparer();
            /*0x1851018*/ DateTimeOffsetEqualityComparer();
            /*0x1850f6c*/ int GetHashCode(System.DateTimeOffset value);
        }
    }

    class MessagePackSerializationException : System.Exception
    {
        /*0x176c944*/ MessagePackSerializationException();
        /*0x176c9a8*/ MessagePackSerializationException(string message);
        /*0x176ca1c*/ MessagePackSerializationException(string message, System.Exception inner);
        /*0x176ca98*/ MessagePackSerializationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
    }

    class MessagePackSerializer
    {
        static int LZ4NotCompressionSizeInLz4BlockType = 64;
        static /*0x0*/ System.Func<System.Type, MessagePack.MessagePackSerializer.CompiledMethods> CreateCompiledMethods;
        static /*0x8*/ MessagePack.Internal.ThreadsafeTypeKeyHashTable<MessagePack.MessagePackSerializer.CompiledMethods> Serializes;
        static /*0x10*/ MessagePack.MessagePackSerializerOptions <DefaultOptions>k__BackingField;
        static /*0x18*/ MessagePack.MessagePackSerializer.LZ4Transform LZ4CodecEncode;
        static /*0x20*/ MessagePack.MessagePackSerializer.LZ4Transform LZ4CodecDecode;
        [ThreadStatic] static byte[] scratchArray;

        static /*0x177379c*/ MessagePackSerializer();
        static void SerializeToJson<T>(System.IO.TextWriter textWriter, T obj, MessagePack.MessagePackSerializerOptions options, System.Threading.CancellationToken cancellationToken);
        static string SerializeToJson<T>(T obj, MessagePack.MessagePackSerializerOptions options, System.Threading.CancellationToken cancellationToken);
        static /*0x176cb24*/ string ConvertToJson(System.ReadOnlyMemory<byte> bytes, MessagePack.MessagePackSerializerOptions options, System.Threading.CancellationToken cancellationToken);
        static /*0x176cbf0*/ string ConvertToJson(ref System.Buffers.ReadOnlySequence<byte> bytes, MessagePack.MessagePackSerializerOptions options, System.Threading.CancellationToken cancellationToken);
        static /*0x176cd04*/ void ConvertToJson(ref MessagePack.MessagePackReader reader, System.IO.TextWriter jsonWriter, MessagePack.MessagePackSerializerOptions options);
        static /*0x176e9a0*/ void ConvertFromJson(string str, ref MessagePack.MessagePackWriter writer, MessagePack.MessagePackSerializerOptions options);
        static /*0x176f04c*/ byte[] ConvertFromJson(string str, MessagePack.MessagePackSerializerOptions options, System.Threading.CancellationToken cancellationToken);
        static /*0x176eb30*/ void ConvertFromJson(System.IO.TextReader reader, ref MessagePack.MessagePackWriter writer, MessagePack.MessagePackSerializerOptions options);
        static /*0x176f6d0*/ uint FromJsonCore(MessagePack.TinyJsonReader jr, ref MessagePack.MessagePackWriter writer);
        static /*0x176dc80*/ void ToJsonCore(ref MessagePack.MessagePackReader reader, System.IO.TextWriter writer, MessagePack.MessagePackSerializerOptions options);
        static /*0x17735ac*/ void WriteJsonString(string value, System.IO.TextWriter builder);
        static /*0x17739e0*/ void Serialize(System.Type type, ref MessagePack.MessagePackWriter writer, object obj, MessagePack.MessagePackSerializerOptions options);
        static /*0x1773b10*/ void Serialize(System.Type type, System.Buffers.IBufferWriter<byte> writer, object obj, MessagePack.MessagePackSerializerOptions options, System.Threading.CancellationToken cancellationToken);
        static /*0x1773bcc*/ byte[] Serialize(System.Type type, object obj, MessagePack.MessagePackSerializerOptions options, System.Threading.CancellationToken cancellationToken);
        static /*0x1773c80*/ void Serialize(System.Type type, System.IO.Stream stream, object obj, MessagePack.MessagePackSerializerOptions options, System.Threading.CancellationToken cancellationToken);
        static /*0x1773d3c*/ System.Threading.Tasks.Task SerializeAsync(System.Type type, System.IO.Stream stream, object obj, MessagePack.MessagePackSerializerOptions options, System.Threading.CancellationToken cancellationToken);
        static /*0x1773df8*/ object Deserialize(System.Type type, ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        static /*0x1773e88*/ object Deserialize(System.Type type, System.IO.Stream stream, MessagePack.MessagePackSerializerOptions options, System.Threading.CancellationToken cancellationToken);
        static /*0x1773f3c*/ System.Threading.Tasks.ValueTask<object> DeserializeAsync(System.Type type, System.IO.Stream stream, MessagePack.MessagePackSerializerOptions options, System.Threading.CancellationToken cancellationToken);
        static /*0x1774014*/ object Deserialize(System.Type type, System.ReadOnlyMemory<byte> bytes, MessagePack.MessagePackSerializerOptions options, System.Threading.CancellationToken cancellationToken);
        static /*0x17740d0*/ object Deserialize(System.Type type, System.Buffers.ReadOnlySequence<byte> bytes, MessagePack.MessagePackSerializerOptions options, System.Threading.CancellationToken cancellationToken);
        static System.Threading.Tasks.ValueTask<object> DeserializeObjectAsync<T>(System.IO.Stream stream, MessagePack.MessagePackSerializerOptions options, System.Threading.CancellationToken cancellationToken);
        static /*0x1773a80*/ MessagePack.MessagePackSerializer.CompiledMethods GetOrAdd(System.Type type);
        static /*0x17741a0*/ MessagePack.MessagePackSerializerOptions get_DefaultOptions();
        static /*0x1774204*/ void set_DefaultOptions(MessagePack.MessagePackSerializerOptions value);
        static void Serialize<T>(System.Buffers.IBufferWriter<byte> writer, T value, MessagePack.MessagePackSerializerOptions options, System.Threading.CancellationToken cancellationToken);
        static void Serialize<T>(ref MessagePack.MessagePackWriter writer, T value, MessagePack.MessagePackSerializerOptions options);
        static byte[] Serialize<T>(T value, MessagePack.MessagePackSerializerOptions options, System.Threading.CancellationToken cancellationToken);
        static void Serialize<T>(System.IO.Stream stream, T value, MessagePack.MessagePackSerializerOptions options, System.Threading.CancellationToken cancellationToken);
        static System.Threading.Tasks.Task SerializeAsync<T>(System.IO.Stream stream, T value, MessagePack.MessagePackSerializerOptions options, System.Threading.CancellationToken cancellationToken);
        static T Deserialize<T>(ref System.Buffers.ReadOnlySequence<byte> byteSequence, MessagePack.MessagePackSerializerOptions options, System.Threading.CancellationToken cancellationToken);
        static T Deserialize<T>(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        static T Deserialize<T>(System.ReadOnlyMemory<byte> buffer, MessagePack.MessagePackSerializerOptions options, System.Threading.CancellationToken cancellationToken);
        static T Deserialize<T>(System.ReadOnlyMemory<byte> buffer, ref int bytesRead, System.Threading.CancellationToken cancellationToken);
        static T Deserialize<T>(System.ReadOnlyMemory<byte> buffer, MessagePack.MessagePackSerializerOptions options, ref int bytesRead, System.Threading.CancellationToken cancellationToken);
        static T Deserialize<T>(System.IO.Stream stream, MessagePack.MessagePackSerializerOptions options, System.Threading.CancellationToken cancellationToken);
        static System.Threading.Tasks.ValueTask<T> DeserializeAsync<T>(System.IO.Stream stream, MessagePack.MessagePackSerializerOptions options, System.Threading.CancellationToken cancellationToken);
        static bool TryDeserializeFromMemoryStream<T>(System.IO.Stream stream, MessagePack.MessagePackSerializerOptions options, System.Threading.CancellationToken cancellationToken, ref T result);
        static T DeserializeFromSequenceAndRewindStreamIfPossible<T>(System.IO.Stream streamToRewind, MessagePack.MessagePackSerializerOptions options, System.Buffers.ReadOnlySequence<byte> sequence, System.Threading.CancellationToken cancellationToken);
        static /*0x177426c*/ int LZ4Operation(ref System.Buffers.ReadOnlySequence<byte> input, System.Span<byte> output, MessagePack.MessagePackSerializer.LZ4Transform lz4Operation);
        static /*0x176d32c*/ bool TryDecompress(ref MessagePack.MessagePackReader reader, System.Buffers.IBufferWriter<byte> writer);
        static /*0x1770e38*/ void ToLZ4BinaryCore(ref System.Buffers.ReadOnlySequence<byte> msgpackUncompressedData, ref MessagePack.MessagePackWriter writer, MessagePack.MessagePackCompression compression);
        static /*0x1775238*/ int GetUInt32WriteSize(uint value);
        static /*0x177579c*/ void WriteBin32Header(uint value, System.Span<byte> span);
        static /*0x1775958*/ bool IsMessagePackFixedSizePrimitiveTypeHelper(System.Type type);

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

            static /*0x1854444*/ System.Reflection.MethodInfo GetMethod(string methodName, System.Type type, System.Type[] parameters);
            /*0x18522e0*/ CompiledMethods(System.Type type);

            class MessagePackWriterSerialize : System.MulticastDelegate
            {
                /*0x1857c54*/ MessagePackWriterSerialize(object object, nint method);
                /*0x1857cb4*/ void Invoke(ref MessagePack.MessagePackWriter writer, object value, MessagePack.MessagePackSerializerOptions options);
                /*0x1857f24*/ System.IAsyncResult BeginInvoke(ref MessagePack.MessagePackWriter writer, object value, MessagePack.MessagePackSerializerOptions options, System.AsyncCallback callback, object object);
                /*0x1857fc8*/ void EndInvoke(ref MessagePack.MessagePackWriter writer, System.IAsyncResult result);
            }

            class MessagePackReaderDeserialize : System.MulticastDelegate
            {
                /*0x18578d4*/ MessagePackReaderDeserialize(object object, nint method);
                /*0x1857934*/ object Invoke(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
                /*0x1857b98*/ System.IAsyncResult BeginInvoke(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options, System.AsyncCallback callback, object object);
                /*0x1857c2c*/ object EndInvoke(ref MessagePack.MessagePackReader reader, System.IAsyncResult result);
            }

            class <>c__DisplayClass13_0
            {
                /*0x10*/ string methodName;
                /*0x18*/ System.Type[] parameters;

                /*0x1854618*/ <>c__DisplayClass13_0();
                /*0x18576f8*/ bool <GetMethod>b__0(System.Reflection.MethodInfo x);
            }
        }

        class LZ4Transform : System.MulticastDelegate
        {
            /*0x1854620*/ LZ4Transform(object object, nint method);
            /*0x1854680*/ int Invoke(System.ReadOnlySpan<byte> input, System.Span<byte> output);
            /*0x1854a68*/ System.IAsyncResult BeginInvoke(System.ReadOnlySpan<byte> input, System.Span<byte> output, System.AsyncCallback callback, object object);
            /*0x1854b24*/ int EndInvoke(System.IAsyncResult result);
        }

        class PrimitiveChecker<T>
        {
            static /*0x0*/ bool IsMessagePackFixedSizePrimitive;

            static PrimitiveChecker();
        }

        class <>c
        {
            static /*0x0*/ MessagePack.MessagePackSerializer.<> <>9;

            static /*0x185221c*/ <>c();
            /*0x185227c*/ <>c();
            /*0x1852284*/ MessagePack.MessagePackSerializer.CompiledMethods <.cctor>b__13_0(System.Type t);
        }

        struct <DeserializeObjectAsync>d__24<T> : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x0*/ int <>1__state;
            /*0x0*/ System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder<object> <>t__builder;
            /*0x0*/ System.IO.Stream stream;
            /*0x0*/ MessagePack.MessagePackSerializerOptions options;
            /*0x0*/ System.Threading.CancellationToken cancellationToken;
            /*0x0*/ System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<T> <>u__1;

            void MoveNext();
            void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }

        struct <SerializeAsync>d__37<T> : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x0*/ int <>1__state;
            /*0x0*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
            /*0x0*/ System.Threading.CancellationToken cancellationToken;
            /*0x0*/ T value;
            /*0x0*/ MessagePack.MessagePackSerializerOptions options;
            /*0x0*/ System.IO.Stream stream;
            /*0x0*/ MessagePack.SequencePool.Rental <sequenceRental>5__2;
            /*0x0*/ System.Buffers.ReadOnlySequence.Enumerator<byte> <>7__wrap2;
            /*0x0*/ System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__1;

            void MoveNext();
            void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }

        struct <DeserializeAsync>d__44<T> : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x0*/ int <>1__state;
            /*0x0*/ System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder<T> <>t__builder;
            /*0x0*/ System.IO.Stream stream;
            /*0x0*/ MessagePack.MessagePackSerializerOptions options;
            /*0x0*/ System.Threading.CancellationToken cancellationToken;
            /*0x0*/ MessagePack.SequencePool.Rental <sequenceRental>5__2;
            /*0x0*/ Nerdbank.Streams.Sequence<byte> <sequence>5__3;
            /*0x0*/ System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int> <>u__1;

            void MoveNext();
            void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    class MessagePackSerializerOptions
    {
        static /*0x0*/ System.Text.RegularExpressions.Regex AssemblyNameVersionSelectorRegex;
        static /*0x8*/ System.Collections.Generic.HashSet<string> BlacklistCheck;
        /*0x10*/ MessagePack.IFormatterResolver <Resolver>k__BackingField;
        /*0x18*/ MessagePack.MessagePackCompression <Compression>k__BackingField;
        /*0x1c*/ System.Nullable<bool> <OldSpec>k__BackingField;
        /*0x1e*/ bool <OmitAssemblyVersion>k__BackingField;
        /*0x1f*/ bool <AllowAssemblyVersionMismatch>k__BackingField;
        /*0x20*/ MessagePack.MessagePackSecurity <Security>k__BackingField;

        static /*0x17766a4*/ MessagePackSerializerOptions();
        static /*0x1775d70*/ MessagePack.MessagePackSerializerOptions get_Standard();
        /*0x1775dd4*/ MessagePackSerializerOptions(MessagePack.IFormatterResolver resolver);
        /*0x1775eb8*/ MessagePackSerializerOptions(MessagePack.MessagePackSerializerOptions copyFrom);
        /*0x1775fb8*/ MessagePack.IFormatterResolver get_Resolver();
        /*0x1775fc0*/ void set_Resolver(MessagePack.IFormatterResolver value);
        /*0x1775fc8*/ MessagePack.MessagePackCompression get_Compression();
        /*0x1775fd0*/ void set_Compression(MessagePack.MessagePackCompression value);
        /*0x1775fd8*/ System.Nullable<bool> get_OldSpec();
        /*0x1775fe0*/ void set_OldSpec(System.Nullable<bool> value);
        /*0x1775fe8*/ bool get_OmitAssemblyVersion();
        /*0x1775ff0*/ void set_OmitAssemblyVersion(bool value);
        /*0x1775ffc*/ bool get_AllowAssemblyVersionMismatch();
        /*0x1776004*/ void set_AllowAssemblyVersionMismatch(bool value);
        /*0x1776010*/ MessagePack.MessagePackSecurity get_Security();
        /*0x1776018*/ void set_Security(MessagePack.MessagePackSecurity value);
        /*0x1776020*/ System.Type LoadType(string typeName);
        /*0x17761a8*/ void ThrowIfDeserializingTypeIsDisallowed(System.Type type);
        /*0x17762e0*/ MessagePack.MessagePackSerializerOptions WithResolver(MessagePack.IFormatterResolver resolver);
        /*0x1776320*/ MessagePack.MessagePackSerializerOptions WithCompression(MessagePack.MessagePackCompression compression);
        /*0x1776360*/ MessagePack.MessagePackSerializerOptions WithOldSpec(System.Nullable<bool> oldSpec);
        /*0x177640c*/ MessagePack.MessagePackSerializerOptions WithOmitAssemblyVersion(bool omitAssemblyVersion);
        /*0x1776458*/ MessagePack.MessagePackSerializerOptions WithAllowAssemblyVersionMismatch(bool allowAssemblyVersionMismatch);
        /*0x17764a4*/ MessagePack.MessagePackSerializerOptions WithSecurity(MessagePack.MessagePackSecurity security);
        /*0x1776530*/ MessagePack.MessagePackSerializerOptions Clone();

        class MessagePackSerializerOptionsDefaultSettingsLazyInitializationHelper
        {
            static /*0x0*/ MessagePack.MessagePackSerializerOptions Standard;

            static /*0x1854b50*/ MessagePackSerializerOptionsDefaultSettingsLazyInitializationHelper();
        }
    }

    class MessagePackStreamReader : System.IDisposable
    {
        /*0x10*/ System.IO.Stream stream;
        /*0x18*/ bool leaveOpen;
        /*0x20*/ MessagePack.SequencePool.Rental sequenceRental;
        /*0x30*/ System.Nullable<System.SequencePosition> endOfLastMessage;

        /*0x17767e8*/ MessagePackStreamReader(System.IO.Stream stream);
        /*0x17767f0*/ MessagePackStreamReader(System.IO.Stream stream, bool leaveOpen);
        /*0x17768e8*/ System.Buffers.ReadOnlySequence<byte> get_RemainingBytes();
        /*0x1776a3c*/ Nerdbank.Streams.Sequence<byte> get_ReadData();
        /*0x1776a44*/ System.Threading.Tasks.ValueTask<System.Nullable<System.Buffers.ReadOnlySequence<byte>>> ReadAsync(System.Threading.CancellationToken cancellationToken);
        /*0x1776b88*/ void DiscardBufferedData();
        /*0x1776be8*/ void Dispose();
        /*0x1776c30*/ void RecycleLastMessage();
        /*0x1776cdc*/ System.Threading.Tasks.Task<bool> TryReadMoreDataAsync(System.Threading.CancellationToken cancellationToken);
        /*0x1776e18*/ bool TryReadNextMessage(ref System.Buffers.ReadOnlySequence<byte> completeMessage);

        struct <ReadAsync>d__10 : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder<System.Nullable<System.Buffers.ReadOnlySequence<byte>>> <>t__builder;
            /*0x60*/ MessagePack.MessagePackStreamReader <>4__this;
            /*0x68*/ System.Threading.CancellationToken cancellationToken;
            /*0x70*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;

            /*0xacb920*/ void MoveNext();
            /*0xacb928*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }

        struct <TryReadMoreDataAsync>d__14 : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder;
            /*0x30*/ System.Threading.CancellationToken cancellationToken;
            /*0x38*/ MessagePack.MessagePackStreamReader <>4__this;
            /*0x40*/ int <bytesRead>5__2;
            /*0x48*/ System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<int> <>u__1;

            /*0xacb930*/ void MoveNext();
            /*0xacb938*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    struct MessagePackWriter
    {
        /*0x10*/ MessagePack.BufferWriter writer;
        /*0x68*/ System.Threading.CancellationToken <CancellationToken>k__BackingField;
        /*0x70*/ bool <OldSpec>k__BackingField;

        static /*0x1778770*/ void WriteBigEndian(short value, System.Span<byte> span);
        static /*0x1779468*/ void WriteBigEndian(int value, System.Span<byte> span);
        static /*0x17799dc*/ void WriteBigEndian(long value, System.Span<byte> span);
        static /*0x17776ac*/ void WriteBigEndian(ushort value, System.Span<byte> span);
        static /*0x177d630*/ void WriteBigEndian(ushort value, byte* span);
        static /*0x1777728*/ void WriteBigEndian(uint value, System.Span<byte> span);
        static /*0x177d640*/ void WriteBigEndian(uint value, byte* span);
        static /*0x17796b4*/ void WriteBigEndian(ulong value, System.Span<byte> span);
        static /*0x1779c2c*/ void WriteBigEndian(float value, System.Span<byte> span);
        static /*0x1779c60*/ void WriteBigEndian(double value, System.Span<byte> span);
        static /*0x177e320*/ void MemoryCopy(void* source, void* destination, long destinationSizeInBytes, long sourceBytesToCopy);
        /*0xac36f4*/ MessagePackWriter(System.Buffers.IBufferWriter<byte> writer);
        /*0xac36fc*/ MessagePackWriter(MessagePack.SequencePool sequencePool, byte[] array);
        /*0xac3704*/ System.Threading.CancellationToken get_CancellationToken();
        /*0xac370c*/ void set_CancellationToken(System.Threading.CancellationToken value);
        /*0xac3714*/ bool get_OldSpec();
        /*0xac371c*/ void set_OldSpec(bool value);
        /*0xac3728*/ MessagePack.MessagePackWriter Clone(System.Buffers.IBufferWriter<byte> writer);
        /*0xac3798*/ void Flush();
        /*0xac37a0*/ void WriteNil();
        /*0xac37a8*/ void WriteRaw(System.ReadOnlySpan<byte> rawMessagePackBlock);
        /*0xac37dc*/ void WriteRaw(ref System.Buffers.ReadOnlySequence<byte> rawMessagePackBlock);
        /*0xac37e4*/ void WriteArrayHeader(int count);
        /*0xac37ec*/ void WriteArrayHeader(uint count);
        /*0xac3ce0*/ void WriteMapHeader(int count);
        /*0xac3ce8*/ void WriteMapHeader(uint count);
        /*0xac3cf0*/ void Write(byte value);
        /*0xac3cf8*/ void WriteUInt8(byte value);
        /*0xac3d00*/ void Write(sbyte value);
        /*0xac3d08*/ void WriteInt8(sbyte value);
        /*0xac3d10*/ void Write(ushort value);
        /*0xac3d18*/ void WriteUInt16(ushort value);
        /*0xac3d20*/ void Write(short value);
        /*0xac3d28*/ void WriteInt16(short value);
        /*0xac3d30*/ void Write(uint value);
        /*0xac419c*/ void WriteUInt32(uint value);
        /*0xac41a4*/ void Write(int value);
        /*0xac47ec*/ void WriteInt32(int value);
        /*0xac47f4*/ void Write(ulong value);
        /*0xac47fc*/ void WriteUInt64(ulong value);
        /*0xac4804*/ void Write(long value);
        /*0xac480c*/ void WriteInt64(long value);
        /*0xac4814*/ void Write(bool value);
        /*0xac4820*/ void Write(char value);
        /*0xac4828*/ void Write(float value);
        /*0xac4830*/ void Write(double value);
        /*0xac4838*/ void Write(System.DateTime dateTime);
        /*0xac4840*/ void Write(byte[] src);
        /*0xac4848*/ void Write(System.ReadOnlySpan<byte> src);
        /*0xac487c*/ void Write(ref System.Buffers.ReadOnlySequence<byte> src);
        /*0xac4884*/ void WriteBinHeader(int length);
        /*0xac488c*/ void WriteString(ref System.Buffers.ReadOnlySequence<byte> utf8stringBytes);
        /*0xac4894*/ void WriteString(System.ReadOnlySpan<byte> utf8stringBytes);
        /*0xac48c8*/ void WriteStringHeader(int byteCount);
        /*0xac48d0*/ void Write(string value);
        /*0xac55e4*/ void Write(System.ReadOnlySpan<char> value);
        /*0xac5618*/ void WriteExtensionFormatHeader(MessagePack.ExtensionHeader extensionHeader);
        /*0xac5620*/ void WriteExtensionFormat(MessagePack.ExtensionResult extensionData);
        /*0xac5654*/ System.Span<byte> GetSpan(int length);
        /*0xac5698*/ void Advance(int length);
        /*0xac56a0*/ void WriteBigEndian(ushort value);
        /*0xac56a8*/ void WriteBigEndian(uint value);
        /*0xac56b0*/ void WriteBigEndian(ulong value);
        /*0xac56b8*/ byte[] FlushAndGetArray();
        /*0xac56c0*/ ref byte WriteString_PrepareSpan(int characterLength, ref int bufferSize, ref int encodedBytesOffset);
        /*0xac5864*/ void WriteString_PostEncoding(byte* pBuffer, int estimatedOffset, int byteCount);
    }

    struct Nil : System.IEquatable<MessagePack.Nil>
    {
        static /*0x0*/ MessagePack.Nil Default;

        static /*0x177f764*/ Nil();
        /*0xac6380*/ bool Equals(object obj);
        /*0xac63e0*/ bool Equals(MessagePack.Nil other);
        /*0xac63e8*/ int GetHashCode();
        /*0xac63f0*/ string ToString();
    }

    class SequencePool
    {
        static int MinimumSpanLength = 32768;
        static /*0x0*/ MessagePack.SequencePool Shared;
        /*0x10*/ int maxSize;
        /*0x18*/ System.Collections.Generic.Stack<Nerdbank.Streams.Sequence<byte>> pool;
        /*0x20*/ System.Buffers.ArrayPool<byte> arrayPool;

        static /*0x178ea5c*/ SequencePool();
        /*0x178e834*/ SequencePool(int maxSize);
        /*0x176d140*/ MessagePack.SequencePool.Rental Rent();
        /*0x178e8ec*/ void Return(Nerdbank.Streams.Sequence<byte> value);

        struct Rental : System.IDisposable
        {
            /*0x10*/ MessagePack.SequencePool owner;
            /*0x18*/ Nerdbank.Streams.Sequence<byte> <Value>k__BackingField;

            /*0xacb97c*/ Rental(MessagePack.SequencePool owner, Nerdbank.Streams.Sequence<byte> value);
            /*0xacb984*/ Nerdbank.Streams.Sequence<byte> get_Value();
            /*0xacb98c*/ void Dispose();
        }
    }

    class StreamPolyfillExtensions
    {
        static /*0x1790180*/ int Read(System.IO.Stream stream, System.Span<byte> buffer);
        static /*0x17904b0*/ System.Threading.Tasks.ValueTask<int> ReadAsync(System.IO.Stream stream, System.Memory<byte> buffer, System.Threading.CancellationToken cancellationToken);
        static /*0x1790870*/ void Write(System.IO.Stream stream, System.ReadOnlySpan<byte> buffer);
        static /*0x1790b60*/ System.Threading.Tasks.ValueTask WriteAsync(System.IO.Stream stream, System.ReadOnlyMemory<byte> buffer, System.Threading.CancellationToken cancellationToken);
        static /*0x1790748*/ System.Threading.Tasks.ValueTask<int> <ReadAsync>g__FinishReadAsync|1_0(System.Threading.Tasks.Task<int> readTask, byte[] localBuffer, System.Memory<byte> localDestination);

        struct <WriteAsync>d__3 : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder <>t__builder;
            /*0x38*/ System.IO.Stream stream;
            /*0x40*/ System.ReadOnlyMemory<byte> buffer;
            /*0x50*/ System.Threading.CancellationToken cancellationToken;
            /*0x58*/ byte[] <sharedBuffer>5__2;
            /*0x60*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

            /*0xacb9b8*/ void MoveNext();
            /*0xacb9c0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }

        struct <<ReadAsync>g__FinishReadAsync|1_0>d : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder<int> <>t__builder;
            /*0x38*/ System.Threading.Tasks.Task<int> readTask;
            /*0x40*/ byte[] localBuffer;
            /*0x48*/ System.Memory<byte> localDestination;
            /*0x58*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1;

            /*0xacb9a8*/ void MoveNext();
            /*0xacb9b0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    class StringEncoding
    {
        static /*0x0*/ System.Text.Encoding UTF8;

        static /*0x1791da8*/ StringEncoding();
        static /*0x1791cf0*/ string GetString(System.Text.Encoding encoding, System.ReadOnlySpan<byte> bytes);
    }

    class ThisLibraryExtensionTypeCodes
    {
        static sbyte UnityVector2 = 30;
        static sbyte UnityVector3 = 31;
        static sbyte UnityVector4 = 32;
        static sbyte UnityQuaternion = 33;
        static sbyte UnityColor = 34;
        static sbyte UnityBounds = 35;
        static sbyte UnityRect = 36;
        static sbyte UnityInt = 37;
        static sbyte UnityFloat = 38;
        static sbyte UnityDouble = 39;
        static sbyte Lz4BlockArray = 98;
        static sbyte Lz4Block = 99;
        static sbyte TypelessFormatter = 100;
    }

    class Utilities
    {
        static bool IsMono = true;

        static byte[] GetWriterBytes<TArg>(TArg arg, MessagePack.Utilities.GetWriterBytesAction<TArg> action);
        static System.Memory<T> GetMemoryCheckResult<T>(System.Buffers.IBufferWriter<T> bufferWriter, int size);

        class GetWriterBytesAction<TArg> : System.MulticastDelegate
        {
            GetWriterBytesAction(object object, nint method);
            void Invoke(ref MessagePack.MessagePackWriter writer, TArg argument);
            System.IAsyncResult BeginInvoke(ref MessagePack.MessagePackWriter writer, TArg argument, System.AsyncCallback callback, object object);
            void EndInvoke(ref MessagePack.MessagePackWriter writer, System.IAsyncResult result);
        }
    }

    namespace Unity
    {
        class Vector2Formatter : MessagePack.Formatters.IMessagePackFormatter<UnityEngine.Vector2>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x1846068*/ Vector2Formatter();
            /*0x18471e0*/ void Serialize(ref MessagePack.MessagePackWriter writer, UnityEngine.Vector2 value, MessagePack.MessagePackSerializerOptions options);
            /*0x1847238*/ UnityEngine.Vector2 Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class Vector3Formatter : MessagePack.Formatters.IMessagePackFormatter<UnityEngine.Vector3>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x1846070*/ Vector3Formatter();
            /*0x18474e4*/ void Serialize(ref MessagePack.MessagePackWriter writer, UnityEngine.Vector3 value, MessagePack.MessagePackSerializerOptions options);
            /*0x1847558*/ UnityEngine.Vector3 Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class Vector4Formatter : MessagePack.Formatters.IMessagePackFormatter<UnityEngine.Vector4>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x1846078*/ Vector4Formatter();
            /*0x18478d0*/ void Serialize(ref MessagePack.MessagePackWriter writer, UnityEngine.Vector4 value, MessagePack.MessagePackSerializerOptions options);
            /*0x1847958*/ UnityEngine.Vector4 Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class QuaternionFormatter : MessagePack.Formatters.IMessagePackFormatter<UnityEngine.Quaternion>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x178bf6c*/ QuaternionFormatter();
            /*0x178bd70*/ void Serialize(ref MessagePack.MessagePackWriter writer, UnityEngine.Quaternion value, MessagePack.MessagePackSerializerOptions options);
            /*0x178bde4*/ UnityEngine.Quaternion Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ColorFormatter : MessagePack.Formatters.IMessagePackFormatter<UnityEngine.Color>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x15281b0*/ ColorFormatter();
            /*0x1527fa0*/ void Serialize(ref MessagePack.MessagePackWriter writer, UnityEngine.Color value, MessagePack.MessagePackSerializerOptions options);
            /*0x1528028*/ UnityEngine.Color Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class BoundsFormatter : MessagePack.Formatters.IMessagePackFormatter<UnityEngine.Bounds>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x151f2ac*/ BoundsFormatter();
            /*0x151eda0*/ void Serialize(ref MessagePack.MessagePackWriter writer, UnityEngine.Bounds value, MessagePack.MessagePackSerializerOptions options);
            /*0x151efac*/ UnityEngine.Bounds Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class RectFormatter : MessagePack.Formatters.IMessagePackFormatter<UnityEngine.Rect>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x178c344*/ RectFormatter();
            /*0x178c134*/ void Serialize(ref MessagePack.MessagePackWriter writer, UnityEngine.Rect value, MessagePack.MessagePackSerializerOptions options);
            /*0x178c1bc*/ UnityEngine.Rect Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class WrapModeFormatter : MessagePack.Formatters.IMessagePackFormatter<UnityEngine.WrapMode>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x1846080*/ WrapModeFormatter();
            /*0x1848c20*/ void Serialize(ref MessagePack.MessagePackWriter writer, UnityEngine.WrapMode value, MessagePack.MessagePackSerializerOptions options);
            /*0x184927c*/ UnityEngine.WrapMode Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class GradientModeFormatter : MessagePack.Formatters.IMessagePackFormatter<UnityEngine.GradientMode>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x22fd768*/ GradientModeFormatter();
            /*0x22fcf28*/ void Serialize(ref MessagePack.MessagePackWriter writer, UnityEngine.GradientMode value, MessagePack.MessagePackSerializerOptions options);
            /*0x22fd584*/ UnityEngine.GradientMode Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class KeyframeFormatter : MessagePack.Formatters.IMessagePackFormatter<UnityEngine.Keyframe>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x23030e8*/ KeyframeFormatter();
            /*0x2302e84*/ void Serialize(ref MessagePack.MessagePackWriter writer, UnityEngine.Keyframe value, MessagePack.MessagePackSerializerOptions options);
            /*0x2302f10*/ UnityEngine.Keyframe Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class AnimationCurveFormatter : MessagePack.Formatters.IMessagePackFormatter<UnityEngine.AnimationCurve>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x151cf1c*/ AnimationCurveFormatter();
            /*0x151c8dc*/ void Serialize(ref MessagePack.MessagePackWriter writer, UnityEngine.AnimationCurve value, MessagePack.MessagePackSerializerOptions options);
            /*0x151cb94*/ UnityEngine.AnimationCurve Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class Matrix4x4Formatter : MessagePack.Formatters.IMessagePackFormatter<UnityEngine.Matrix4x4>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x230a0b8*/ Matrix4x4Formatter();
            /*0x2309c6c*/ void Serialize(ref MessagePack.MessagePackWriter writer, UnityEngine.Matrix4x4 value, MessagePack.MessagePackSerializerOptions options);
            /*0x2309d98*/ UnityEngine.Matrix4x4 Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class GradientColorKeyFormatter : MessagePack.Formatters.IMessagePackFormatter<UnityEngine.GradientColorKey>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x22fc894*/ GradientColorKeyFormatter();
            /*0x22fc4a8*/ void Serialize(ref MessagePack.MessagePackWriter writer, UnityEngine.GradientColorKey value, MessagePack.MessagePackSerializerOptions options);
            /*0x22fc608*/ UnityEngine.GradientColorKey Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class GradientAlphaKeyFormatter : MessagePack.Formatters.IMessagePackFormatter<UnityEngine.GradientAlphaKey>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x22fc4a0*/ GradientAlphaKeyFormatter();
            /*0x22fc0f4*/ void Serialize(ref MessagePack.MessagePackWriter writer, UnityEngine.GradientAlphaKey value, MessagePack.MessagePackSerializerOptions options);
            /*0x22fc14c*/ UnityEngine.GradientAlphaKey Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class GradientFormatter : MessagePack.Formatters.IMessagePackFormatter<UnityEngine.Gradient>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x22fcf20*/ GradientFormatter();
            /*0x22fc89c*/ void Serialize(ref MessagePack.MessagePackWriter writer, UnityEngine.Gradient value, MessagePack.MessagePackSerializerOptions options);
            /*0x22fcb70*/ UnityEngine.Gradient Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class Color32Formatter : MessagePack.Formatters.IMessagePackFormatter<UnityEngine.Color32>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x1527f44*/ Color32Formatter();
            /*0x1527d30*/ void Serialize(ref MessagePack.MessagePackWriter writer, UnityEngine.Color32 value, MessagePack.MessagePackSerializerOptions options);
            /*0x1527db0*/ UnityEngine.Color32 Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class RectOffsetFormatter : MessagePack.Formatters.IMessagePackFormatter<UnityEngine.RectOffset>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x178e008*/ RectOffsetFormatter();
            /*0x178c5ac*/ void Serialize(ref MessagePack.MessagePackWriter writer, UnityEngine.RectOffset value, MessagePack.MessagePackSerializerOptions options);
            /*0x178de6c*/ UnityEngine.RectOffset Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class LayerMaskFormatter : MessagePack.Formatters.IMessagePackFormatter<UnityEngine.LayerMask>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x2309c64*/ LayerMaskFormatter();
            /*0x23094f0*/ void Serialize(ref MessagePack.MessagePackWriter writer, UnityEngine.LayerMask value, MessagePack.MessagePackSerializerOptions options);
            /*0x2309b70*/ UnityEngine.LayerMask Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class Vector2IntFormatter : MessagePack.Formatters.IMessagePackFormatter<UnityEngine.Vector2Int>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x1846088*/ Vector2IntFormatter();
            /*0x1847338*/ void Serialize(ref MessagePack.MessagePackWriter writer, UnityEngine.Vector2Int value, MessagePack.MessagePackSerializerOptions options);
            /*0x1847390*/ UnityEngine.Vector2Int Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class Vector3IntFormatter : MessagePack.Formatters.IMessagePackFormatter<UnityEngine.Vector3Int>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x1846090*/ Vector3IntFormatter();
            /*0x1847684*/ void Serialize(ref MessagePack.MessagePackWriter writer, UnityEngine.Vector3Int value, MessagePack.MessagePackSerializerOptions options);
            /*0x1847714*/ UnityEngine.Vector3Int Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class RangeIntFormatter : MessagePack.Formatters.IMessagePackFormatter<UnityEngine.RangeInt>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x178c0d8*/ RangeIntFormatter();
            /*0x178bf74*/ void Serialize(ref MessagePack.MessagePackWriter writer, UnityEngine.RangeInt value, MessagePack.MessagePackSerializerOptions options);
            /*0x178bfc0*/ UnityEngine.RangeInt Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class RectIntFormatter : MessagePack.Formatters.IMessagePackFormatter<UnityEngine.RectInt>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x178c5a4*/ RectIntFormatter();
            /*0x178c34c*/ void Serialize(ref MessagePack.MessagePackWriter writer, UnityEngine.RectInt value, MessagePack.MessagePackSerializerOptions options);
            /*0x178c3e0*/ UnityEngine.RectInt Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class BoundsIntFormatter : MessagePack.Formatters.IMessagePackFormatter<UnityEngine.BoundsInt>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x151f7d4*/ BoundsIntFormatter();
            /*0x151f2b4*/ void Serialize(ref MessagePack.MessagePackWriter writer, UnityEngine.BoundsInt value, MessagePack.MessagePackSerializerOptions options);
            /*0x151f4a8*/ UnityEngine.BoundsInt Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class UnityResolver : MessagePack.IFormatterResolver
        {
            static /*0x0*/ MessagePack.Unity.UnityResolver Instance;

            static /*0x18421c4*/ UnityResolver();
            /*0x18421bc*/ UnityResolver();
            MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static FormatterCache();
            }
        }

        class UnityResolveryResolverGetFormatterHelper
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, object> FormatterMap;

            static /*0x18422d0*/ UnityResolveryResolverGetFormatterHelper();
            static /*0x1842224*/ object GetFormatter(System.Type t);
        }

        namespace Extension
        {
            class UnityBlitResolver : MessagePack.IFormatterResolver
            {
                static /*0x0*/ MessagePack.Unity.Extension.UnityBlitResolver Instance;

                static /*0x1841a34*/ UnityBlitResolver();
                /*0x1841a2c*/ UnityBlitResolver();
                MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

                class FormatterCache<T>
                {
                    static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                    static FormatterCache();
                }
            }

            class UnityBlitWithPrimitiveArrayResolver : MessagePack.IFormatterResolver
            {
                static /*0x0*/ MessagePack.Unity.Extension.UnityBlitWithPrimitiveArrayResolver Instance;

                static /*0x1841eb4*/ UnityBlitWithPrimitiveArrayResolver();
                /*0x1841eac*/ UnityBlitWithPrimitiveArrayResolver();
                MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

                class FormatterCache<T>
                {
                    static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                    static FormatterCache();
                }
            }

            class UnityBlitResolverGetFormatterHelper
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, System.Type> FormatterMap;

                static /*0x1841b4c*/ UnityBlitResolverGetFormatterHelper();
                static /*0x1841a94*/ object GetFormatter(System.Type t);
            }

            class UnityBlitWithPrimitiveResolverGetFormatterHelper
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, System.Type> FormatterMap;

                static /*0x1841fcc*/ UnityBlitWithPrimitiveResolverGetFormatterHelper();
                static /*0x1841f14*/ object GetFormatter(System.Type t);
            }

            class UnsafeBlitFormatterBase<T> : MessagePack.Formatters.IMessagePackFormatter<T[]>, MessagePack.Formatters.IMessagePackFormatter
            {
                UnsafeBlitFormatterBase();
                sbyte get_TypeCode();
                void CopyDeserializeUnsafe(System.ReadOnlySpan<byte> src, System.Span<T> dest);
                void Serialize(ref MessagePack.MessagePackWriter writer, T[] value, MessagePack.MessagePackSerializerOptions options);
                T[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
            }

            class Vector2ArrayBlitFormatter : MessagePack.Unity.Extension.UnsafeBlitFormatterBase<UnityEngine.Vector2>
            {
                /*0x1847194*/ Vector2ArrayBlitFormatter();
                /*0x184718c*/ sbyte get_TypeCode();
            }

            class Vector3ArrayBlitFormatter : MessagePack.Unity.Extension.UnsafeBlitFormatterBase<UnityEngine.Vector3>
            {
                /*0x1847498*/ Vector3ArrayBlitFormatter();
                /*0x1847490*/ sbyte get_TypeCode();
            }

            class Vector4ArrayBlitFormatter : MessagePack.Unity.Extension.UnsafeBlitFormatterBase<UnityEngine.Vector4>
            {
                /*0x1847884*/ Vector4ArrayBlitFormatter();
                /*0x184787c*/ sbyte get_TypeCode();
            }

            class QuaternionArrayBlitFormatter : MessagePack.Unity.Extension.UnsafeBlitFormatterBase<UnityEngine.Quaternion>
            {
                /*0x178bd24*/ QuaternionArrayBlitFormatter();
                /*0x178bd1c*/ sbyte get_TypeCode();
            }

            class ColorArrayBlitFormatter : MessagePack.Unity.Extension.UnsafeBlitFormatterBase<UnityEngine.Color>
            {
                /*0x1527f54*/ ColorArrayBlitFormatter();
                /*0x1527f4c*/ sbyte get_TypeCode();
            }

            class BoundsArrayBlitFormatter : MessagePack.Unity.Extension.UnsafeBlitFormatterBase<UnityEngine.Bounds>
            {
                /*0x151ed54*/ BoundsArrayBlitFormatter();
                /*0x151ed4c*/ sbyte get_TypeCode();
            }

            class RectArrayBlitFormatter : MessagePack.Unity.Extension.UnsafeBlitFormatterBase<UnityEngine.Rect>
            {
                /*0x178c0e8*/ RectArrayBlitFormatter();
                /*0x178c0e0*/ sbyte get_TypeCode();
            }

            class IntArrayBlitFormatter : MessagePack.Unity.Extension.UnsafeBlitFormatterBase<int>
            {
                /*0x2302d6c*/ IntArrayBlitFormatter();
                /*0x2302d64*/ sbyte get_TypeCode();
            }

            class FloatArrayBlitFormatter : MessagePack.Unity.Extension.UnsafeBlitFormatterBase<float>
            {
                /*0x153b7a8*/ FloatArrayBlitFormatter();
                /*0x153b7a0*/ sbyte get_TypeCode();
            }

            class DoubleArrayBlitFormatter : MessagePack.Unity.Extension.UnsafeBlitFormatterBase<double>
            {
                /*0x152a688*/ DoubleArrayBlitFormatter();
                /*0x152a680*/ sbyte get_TypeCode();
            }
        }
    }

    namespace Resolvers
    {
        class AttributeFormatterResolver : MessagePack.IFormatterResolver
        {
            static /*0x0*/ MessagePack.Resolvers.AttributeFormatterResolver Instance;

            static /*0x151d014*/ AttributeFormatterResolver();
            /*0x151d00c*/ AttributeFormatterResolver();
            MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static FormatterCache();
            }
        }

        class BuiltinResolver : MessagePack.IFormatterResolver
        {
            static /*0x0*/ MessagePack.Resolvers.BuiltinResolver Instance;

            static /*0x15207b8*/ BuiltinResolver();
            /*0x15207b0*/ BuiltinResolver();
            MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static FormatterCache();
            }
        }

        class CachingFormatterResolver : MessagePack.IFormatterResolver
        {
            /*0x10*/ MessagePack.Internal.ThreadsafeTypeKeyHashTable<MessagePack.Formatters.IMessagePackFormatter> formatters;

            /*0x152756c*/ CachingFormatterResolver();
            MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();
            MessagePack.Formatters.IMessagePackFormatter<T> GetFormatterCore<T>();
        }

        class CompositeResolver
        {
            static /*0x0*/ System.Collections.ObjectModel.ReadOnlyDictionary<System.Type, MessagePack.Formatters.IMessagePackFormatter> EmptyFormattersByType;

            static /*0x152866c*/ CompositeResolver();
            static /*0x1528338*/ MessagePack.IFormatterResolver Create(System.Collections.Generic.IReadOnlyList<MessagePack.Formatters.IMessagePackFormatter> formatters, System.Collections.Generic.IReadOnlyList<MessagePack.IFormatterResolver> resolvers);
            static /*0x1528464*/ MessagePack.IFormatterResolver Create(MessagePack.IFormatterResolver[] resolvers);
            static /*0x1528568*/ MessagePack.IFormatterResolver Create(MessagePack.Formatters.IMessagePackFormatter[] formatters);

            class CachingResolver : MessagePack.IFormatterResolver
            {
                /*0x10*/ MessagePack.Internal.ThreadsafeTypeKeyHashTable<MessagePack.Formatters.IMessagePackFormatter> formattersCache;
                /*0x18*/ MessagePack.Formatters.IMessagePackFormatter[] subFormatters;
                /*0x20*/ MessagePack.IFormatterResolver[] subResolvers;

                /*0x184b240*/ CachingResolver(MessagePack.Formatters.IMessagePackFormatter[] subFormatters, MessagePack.IFormatterResolver[] subResolvers);
                MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();
            }
        }

        class DynamicEnumAsStringResolver : MessagePack.IFormatterResolver
        {
            static /*0x0*/ MessagePack.Resolvers.DynamicEnumAsStringResolver Instance;
            static /*0x8*/ MessagePack.MessagePackSerializerOptions Options;

            static /*0x152ae88*/ DynamicEnumAsStringResolver();
            /*0x152af34*/ DynamicEnumAsStringResolver();
            MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static FormatterCache();
            }
        }

        class DynamicEnumResolver : MessagePack.IFormatterResolver
        {
            static string ModuleName = "MessagePack.Resolvers.DynamicEnumResolver";
            static /*0x0*/ MessagePack.Resolvers.DynamicEnumResolver Instance;
            static /*0x8*/ MessagePack.Internal.DynamicAssembly DynamicAssembly;
            static /*0x10*/ int nameSequence;

            static /*0x152af44*/ DynamicEnumResolver();
            static /*0x152aff8*/ System.Reflection.TypeInfo BuildType(System.Type enumType);
            /*0x152af3c*/ DynamicEnumResolver();
            MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static FormatterCache();
            }
        }

        class DynamicGenericResolver : MessagePack.IFormatterResolver
        {
            static /*0x0*/ MessagePack.Resolvers.DynamicGenericResolver Instance;

            static /*0x152b6f0*/ DynamicGenericResolver();
            /*0x152b6e8*/ DynamicGenericResolver();
            MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static FormatterCache();
            }
        }

        class DynamicObjectResolver : MessagePack.IFormatterResolver
        {
            static string ModuleName = "MessagePack.Resolvers.DynamicObjectResolver";
            static /*0x0*/ MessagePack.Resolvers.DynamicObjectResolver Instance;
            static /*0x8*/ MessagePack.MessagePackSerializerOptions Options;
            static /*0x10*/ MessagePack.Internal.DynamicAssembly DynamicAssembly;

            static /*0x152d7a8*/ DynamicObjectResolver();
            /*0x152d89c*/ DynamicObjectResolver();
            MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static FormatterCache();
            }
        }

        class DynamicObjectResolverAllowPrivate : MessagePack.IFormatterResolver
        {
            static /*0x0*/ MessagePack.Resolvers.DynamicObjectResolverAllowPrivate Instance;

            static /*0x152d8ac*/ DynamicObjectResolverAllowPrivate();
            /*0x152d8a4*/ DynamicObjectResolverAllowPrivate();
            MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static FormatterCache();
            }
        }

        class DynamicContractlessObjectResolver : MessagePack.IFormatterResolver
        {
            static string ModuleName = "MessagePack.Resolvers.DynamicContractlessObjectResolver";
            static /*0x0*/ MessagePack.Resolvers.DynamicContractlessObjectResolver Instance;
            static /*0x8*/ MessagePack.Internal.DynamicAssembly DynamicAssembly;

            static /*0x152ad78*/ DynamicContractlessObjectResolver();
            /*0x152ad70*/ DynamicContractlessObjectResolver();
            MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static FormatterCache();
            }
        }

        class DynamicContractlessObjectResolverAllowPrivate : MessagePack.IFormatterResolver
        {
            static /*0x0*/ MessagePack.Resolvers.DynamicContractlessObjectResolverAllowPrivate Instance;

            static /*0x152ae28*/ DynamicContractlessObjectResolverAllowPrivate();
            /*0x152ae20*/ DynamicContractlessObjectResolverAllowPrivate();
            MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static FormatterCache();
            }
        }

        class DynamicUnionResolver : MessagePack.IFormatterResolver
        {
            static string ModuleName = "MessagePack.Resolvers.DynamicUnionResolver";
            static /*0x0*/ MessagePack.Resolvers.DynamicUnionResolver Instance;
            static /*0x8*/ MessagePack.MessagePackSerializerOptions Options;
            static /*0x10*/ MessagePack.Internal.DynamicAssembly DynamicAssembly;
            static /*0x18*/ System.Text.RegularExpressions.Regex SubtractFullNameRegex;
            static /*0x20*/ int nameSequence;
            static /*0x28*/ System.Type refMessagePackReader;
            static /*0x30*/ System.Type refKvp;
            static /*0x38*/ System.Reflection.MethodInfo getFormatterWithVerify;
            static /*0x40*/ System.Reflection.MethodInfo getResolverFromOptions;
            static /*0x48*/ System.Func<System.Type, System.Reflection.MethodInfo> getSerialize;
            static /*0x50*/ System.Func<System.Type, System.Reflection.MethodInfo> getDeserialize;
            static /*0x58*/ System.Reflection.FieldInfo runtimeTypeHandleEqualityComparer;
            static /*0x60*/ System.Reflection.ConstructorInfo intIntKeyValuePairConstructor;
            static /*0x68*/ System.Reflection.ConstructorInfo typeMapDictionaryConstructor;
            static /*0x70*/ System.Reflection.MethodInfo typeMapDictionaryAdd;
            static /*0x78*/ System.Reflection.MethodInfo typeMapDictionaryTryGetValue;
            static /*0x80*/ System.Reflection.ConstructorInfo keyMapDictionaryConstructor;
            static /*0x88*/ System.Reflection.MethodInfo keyMapDictionaryAdd;
            static /*0x90*/ System.Reflection.MethodInfo keyMapDictionaryTryGetValue;
            static /*0x98*/ System.Reflection.MethodInfo objectGetType;
            static /*0xa0*/ System.Reflection.MethodInfo getTypeHandle;
            static /*0xa8*/ System.Reflection.MethodInfo intIntKeyValuePairGetKey;
            static /*0xb0*/ System.Reflection.MethodInfo intIntKeyValuePairGetValue;
            static /*0xb8*/ System.Reflection.ConstructorInfo invalidOperationExceptionConstructor;
            static /*0xc0*/ System.Reflection.ConstructorInfo objectCtor;

            static /*0x1535cb4*/ DynamicUnionResolver();
            static /*0x1536920*/ System.Reflection.TypeInfo BuildType(System.Type type);
            static /*0x15372d8*/ void BuildConstructor(System.Type type, MessagePack.UnionAttribute[] infos, System.Reflection.ConstructorInfo method, System.Reflection.Emit.FieldBuilder typeToKeyAndJumpMap, System.Reflection.Emit.FieldBuilder keyToJumpMap, System.Reflection.Emit.ILGenerator il);
            static /*0x153770c*/ void BuildSerialize(System.Type type, MessagePack.UnionAttribute[] infos, System.Reflection.Emit.MethodBuilder method, System.Reflection.Emit.FieldBuilder typeToKeyAndJumpMap, System.Reflection.Emit.ILGenerator il);
            static /*0x1538170*/ void BuildDeserialize(System.Type type, MessagePack.UnionAttribute[] infos, System.Reflection.Emit.MethodBuilder method, System.Reflection.Emit.FieldBuilder keyToJumpMap, System.Reflection.Emit.ILGenerator il);
            static /*0x1538d40*/ bool IsZeroStartSequential(MessagePack.UnionAttribute[] infos);
            /*0x1536918*/ DynamicUnionResolver();
            MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static FormatterCache();
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

                static /*0x18505e8*/ MessagePackReaderTypeInfo();
            }

            class MessagePackWriterTypeInfo
            {
                static /*0x0*/ System.Reflection.TypeInfo WriterTypeInfo;
                static /*0x8*/ System.Reflection.MethodInfo WriteArrayHeader;
                static /*0x10*/ System.Reflection.MethodInfo WriteInt32;
                static /*0x18*/ System.Reflection.MethodInfo WriteNil;

                static /*0x1850870*/ MessagePackWriterTypeInfo();
            }

            class <>c
            {
                static /*0x0*/ MessagePack.Resolvers.DynamicUnionResolver.<> <>9;
                static /*0x8*/ System.Func<MessagePack.UnionAttribute, int> <>9__10_0;
                static /*0x10*/ System.Func<<>f__AnonymousType0<System.Reflection.Emit.Label, MessagePack.UnionAttribute>, System.Reflection.Emit.Label> <>9__12_1;
                static /*0x18*/ System.Func<<>f__AnonymousType0<System.Reflection.Emit.Label, MessagePack.UnionAttribute>, System.Reflection.Emit.Label> <>9__13_1;

                static /*0x184fbd0*/ <>c();
                /*0x184fc30*/ <>c();
                /*0x184fc38*/ bool <.cctor>b__6_0(System.Reflection.MethodInfo x);
                /*0x184fc9c*/ System.Reflection.MethodInfo <.cctor>b__6_1(System.Type t);
                /*0x184fec4*/ System.Reflection.MethodInfo <.cctor>b__6_2(System.Type t);
                /*0x18500c4*/ bool <.cctor>b__6_3(System.Reflection.ConstructorInfo x);
                /*0x1850100*/ bool <.cctor>b__6_4(System.Reflection.ConstructorInfo x);
                /*0x18501e4*/ bool <.cctor>b__6_5(System.Reflection.ConstructorInfo x);
                /*0x18502c8*/ bool <.cctor>b__6_6(System.Reflection.ConstructorInfo x);
                /*0x18503ac*/ bool <.cctor>b__6_7(System.Reflection.ConstructorInfo x);
                /*0x18503e8*/ int <BuildType>b__10_0(MessagePack.UnionAttribute x);
                /*0x1850400*/ System.Reflection.Emit.Label <BuildSerialize>b__12_1(<>f__AnonymousType0<System.Reflection.Emit.Label, MessagePack.UnionAttribute> x);
                /*0x1850448*/ System.Reflection.Emit.Label <BuildDeserialize>b__13_1(<>f__AnonymousType0<System.Reflection.Emit.Label, MessagePack.UnionAttribute> x);
            }

            class <>c__DisplayClass12_0
            {
                /*0x10*/ System.Reflection.Emit.ILGenerator il;

                /*0x1850490*/ <>c__DisplayClass12_0();
                /*0x1850498*/ <>f__AnonymousType0<System.Reflection.Emit.Label, MessagePack.UnionAttribute> <BuildSerialize>b__0(MessagePack.UnionAttribute x);
            }

            class <>c__DisplayClass13_0
            {
                /*0x10*/ System.Reflection.Emit.ILGenerator il;

                /*0x185053c*/ <>c__DisplayClass13_0();
                /*0x1850544*/ <>f__AnonymousType0<System.Reflection.Emit.Label, MessagePack.UnionAttribute> <BuildDeserialize>b__0(MessagePack.UnionAttribute x);
            }
        }

        class MessagePackDynamicUnionResolverException : MessagePack.MessagePackSerializationException
        {
            /*0x230b460*/ MessagePackDynamicUnionResolverException(string message);
        }

        class NativeDateTimeResolver : MessagePack.IFormatterResolver
        {
            static /*0x0*/ MessagePack.Resolvers.NativeDateTimeResolver Instance;
            static /*0x8*/ MessagePack.MessagePackSerializerOptions Options;

            static /*0x177e940*/ NativeDateTimeResolver();
            /*0x177e9e8*/ NativeDateTimeResolver();
            MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static FormatterCache();
            }
        }

        class NativeDecimalResolver : MessagePack.IFormatterResolver
        {
            static /*0x0*/ MessagePack.Resolvers.NativeDecimalResolver Instance;

            static /*0x177f0f4*/ NativeDecimalResolver();
            static /*0x177ef58*/ object GetFormatterHelper(System.Type t);
            /*0x177ef50*/ NativeDecimalResolver();
            MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static FormatterCache();
            }
        }

        class NativeGuidResolver : MessagePack.IFormatterResolver
        {
            static /*0x0*/ MessagePack.Resolvers.NativeGuidResolver Instance;

            static /*0x177f650*/ NativeGuidResolver();
            static /*0x177f4b4*/ object GetFormatterHelper(System.Type t);
            /*0x177f4ac*/ NativeGuidResolver();
            MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static FormatterCache();
            }
        }

        class PrimitiveObjectResolver : MessagePack.IFormatterResolver
        {
            static /*0x0*/ MessagePack.Resolvers.PrimitiveObjectResolver Instance;
            static /*0x8*/ MessagePack.MessagePackSerializerOptions Options;

            static /*0x178bc6c*/ PrimitiveObjectResolver();
            /*0x178bd14*/ PrimitiveObjectResolver();
            MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static FormatterCache();
            }
        }

        class StandardResolver : MessagePack.IFormatterResolver
        {
            static /*0x0*/ MessagePack.Resolvers.StandardResolver Instance;
            static /*0x8*/ MessagePack.MessagePackSerializerOptions Options;
            static /*0x10*/ MessagePack.IFormatterResolver[] Resolvers;

            static /*0x178f7c0*/ StandardResolver();
            /*0x178f90c*/ StandardResolver();
            MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static FormatterCache();
            }
        }

        class ContractlessStandardResolver : MessagePack.IFormatterResolver
        {
            static /*0x0*/ MessagePack.Resolvers.ContractlessStandardResolver Instance;
            static /*0x8*/ MessagePack.MessagePackSerializerOptions Options;
            static /*0x10*/ MessagePack.IFormatterResolver[] Resolvers;

            static /*0x1528734*/ ContractlessStandardResolver();
            /*0x1528884*/ ContractlessStandardResolver();
            MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static FormatterCache();
            }
        }

        class StandardResolverAllowPrivate : MessagePack.IFormatterResolver
        {
            static /*0x0*/ MessagePack.Resolvers.StandardResolverAllowPrivate Instance;
            static /*0x8*/ MessagePack.MessagePackSerializerOptions Options;
            static /*0x10*/ MessagePack.IFormatterResolver[] Resolvers;

            static /*0x178f914*/ StandardResolverAllowPrivate();
            /*0x178fa60*/ StandardResolverAllowPrivate();
            MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static FormatterCache();
            }
        }

        class ContractlessStandardResolverAllowPrivate : MessagePack.IFormatterResolver
        {
            static /*0x0*/ MessagePack.Resolvers.ContractlessStandardResolverAllowPrivate Instance;
            static /*0x8*/ MessagePack.MessagePackSerializerOptions Options;
            static /*0x10*/ MessagePack.IFormatterResolver[] Resolvers;

            static /*0x152888c*/ ContractlessStandardResolverAllowPrivate();
            /*0x15289dc*/ ContractlessStandardResolverAllowPrivate();
            MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class FormatterCache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static FormatterCache();
            }
        }

        class StaticCompositeResolver : MessagePack.IFormatterResolver
        {
            static /*0x0*/ MessagePack.Resolvers.StaticCompositeResolver Instance;
            /*0x10*/ bool freezed;
            /*0x18*/ System.Collections.Generic.IReadOnlyList<MessagePack.Formatters.IMessagePackFormatter> formatters;
            /*0x20*/ System.Collections.Generic.IReadOnlyList<MessagePack.IFormatterResolver> resolvers;

            static /*0x1790124*/ StaticCompositeResolver();
            /*0x178fc18*/ StaticCompositeResolver();
            /*0x178fd94*/ void Register(MessagePack.Formatters.IMessagePackFormatter[] formatters);
            /*0x178fefc*/ void Register(MessagePack.IFormatterResolver[] resolvers);
            /*0x179005c*/ void Register(System.Collections.Generic.IReadOnlyList<MessagePack.Formatters.IMessagePackFormatter> formatters, System.Collections.Generic.IReadOnlyList<MessagePack.IFormatterResolver> resolvers);
            MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

            class Cache<T>
            {
                static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

                static Cache();
            }
        }
    }

    namespace LZ4
    {
        class LZ4Codec
        {
            static int MEMORY_USAGE = 12;
            static int NOTCOMPRESSIBLE_DETECTIONLEVEL = 6;
            static int MINMATCH = 4;
            static int SKIPSTRENGTH = 6;
            static int COPYLENGTH = 8;
            static int LASTLITERALS = 5;
            static int MFLIMIT = 12;
            static int MINLENGTH = 13;
            static int MAXD_LOG = 16;
            static int MAXD = 65536;
            static int MAXD_MASK = 65535;
            static int MAX_DISTANCE = 65535;
            static int ML_BITS = 4;
            static int ML_MASK = 15;
            static int RUN_BITS = 4;
            static int RUN_MASK = 15;
            static int STEPSIZE_64 = 8;
            static int STEPSIZE_32 = 4;
            static int LZ4_64KLIMIT = 65547;
            static int HASH_LOG = 10;
            static int HASH_TABLESIZE = 1024;
            static int HASH_ADJUST = 22;
            static int HASH64K_LOG = 11;
            static int HASH64K_TABLESIZE = 2048;
            static int HASH64K_ADJUST = 21;
            static int HASHHC_LOG = 15;
            static int HASHHC_TABLESIZE = 32768;
            static int HASHHC_ADJUST = 17;
            static int MAX_NB_ATTEMPTS = 256;
            static int OPTIMAL_ML = 18;
            static int BLOCK_COPY_LIMIT = 16;
            static /*0x0*/ int[] DECODER_TABLE_32;
            static /*0x8*/ int[] DECODER_TABLE_64;
            static /*0x10*/ int[] DEBRUIJN_TABLE_32;
            static /*0x18*/ int[] DEBRUIJN_TABLE_64;

            static /*0x23093a4*/ LZ4Codec();
            static /*0x23030f0*/ int Encode(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength);
            static /*0x23034d0*/ int Decode(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength);
            static /*0x2303820*/ void Assert(bool condition, string errorMessage);
            static /*0x2303870*/ void Poke2(byte[] buffer, int offset, ushort value);
            static /*0x23038c4*/ ushort Peek2(byte[] buffer, int offset);
            static /*0x2303910*/ uint Peek4(byte[] buffer, int offset);
            static /*0x2303990*/ uint Xor4(byte[] buffer, int offset1, int offset2);
            static /*0x2303a68*/ ulong Xor8(byte[] buffer, int offset1, int offset2);
            static /*0x2303c00*/ bool Equal2(byte[] buffer, int offset1, int offset2);
            static /*0x2303c80*/ bool Equal4(byte[] buffer, int offset1, int offset2);
            static /*0x2303d58*/ void Copy4(byte[] buf, int src, int dst);
            static /*0x2303e14*/ void Copy8(byte[] buf, int src, int dst);
            static /*0x2303f70*/ void BlockCopy(byte[] src, int src_0, byte[] dst, int dst_0, int len);
            static /*0x230433c*/ int WildCopy(byte[] src, int src_0, byte[] dst, int dst_0, int dst_end);
            static /*0x2304504*/ int SecureCopy(byte[] buffer, int src, int dst, int dst_end);
            static /*0x23031e8*/ int Encode32Safe(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength);
            static /*0x230335c*/ int Encode64Safe(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength);
            static /*0x23035c8*/ int Decode32Safe(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength);
            static /*0x23036f4*/ int Decode64Safe(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength);
            static /*0x23050a4*/ int LZ4_compressCtx_safe32(int[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen);
            static /*0x2304860*/ int LZ4_compress64kCtx_safe32(ushort[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen);
            static /*0x2306b94*/ int LZ4_uncompress_safe32(byte[] src, byte[] dst, int src_0, int dst_0, int dst_len);
            static /*0x2306240*/ int LZ4_compressCtx_safe64(int[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen);
            static /*0x23059bc*/ int LZ4_compress64kCtx_safe64(ushort[] hash_table, byte[] src, byte[] dst, int src_0, int dst_0, int src_len, int dst_maxlen);
            static /*0x2307044*/ int LZ4_uncompress_safe64(byte[] src, byte[] dst, int src_0, int dst_0, int dst_len);
            static /*0x2307528*/ int Encode(System.ReadOnlySpan<byte> input, System.Span<byte> output);
            static /*0x2308c98*/ int Decode(System.ReadOnlySpan<byte> input, System.Span<byte> output);
            static /*0x23081ec*/ int LZ4_compressCtx_32(uint* hash_table, byte* src, byte* dst, int src_len, int dst_maxlen);
            static /*0x23077a4*/ int LZ4_compress64kCtx_32(ushort* hash_table, byte* src, byte* dst, int src_len, int dst_maxlen);
            static /*0x2308e38*/ int LZ4_uncompress_32(byte* src, byte* dst, int dst_len);
            static /*0x23092d0*/ void BlockCopy32(byte* src, byte* dst, int len);
            static /*0x2308734*/ int LZ4_compressCtx_64(uint* hash_table, byte* src, byte* dst, int src_len, int dst_maxlen);
            static /*0x2307cbc*/ int LZ4_compress64kCtx_64(ushort* hash_table, byte* src, byte* dst, int src_len, int dst_maxlen);
            static /*0x2309080*/ int LZ4_uncompress_64(byte* src, byte* dst, int dst_len);
            static /*0x230931c*/ void BlockCopy64(byte* src, byte* dst, int len);
            static /*0x230937c*/ int MaximumOutputLength(int inputLength);
            static /*0x2304718*/ void CheckArguments(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset, int outputLength);

            class HashTablePool
            {
                [ThreadStatic] static ushort[] ushortPool;
                [ThreadStatic] static uint[] uintPool;
                [ThreadStatic] static int[] intPool;

                static /*0x1850b80*/ ushort[] GetUShortHashTablePool();
                static /*0x1850c48*/ uint[] GetUIntHashTablePool();
                static /*0x1850d10*/ int[] GetIntHashTablePool();
            }
        }
    }

    namespace Internal
    {
        class AutomataDictionary : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, int>>, System.Collections.IEnumerable
        {
            /*0x10*/ MessagePack.Internal.AutomataDictionary.AutomataNode root;

            static /*0x151e008*/ void ToStringCore(System.Collections.Generic.IEnumerable<MessagePack.Internal.AutomataDictionary.AutomataNode> nexts, System.Text.StringBuilder sb, int depth);
            static /*0x151e508*/ System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, int>> YieldCore(System.Collections.Generic.IEnumerable<MessagePack.Internal.AutomataDictionary.AutomataNode> nexts);
            /*0x151d074*/ AutomataDictionary();
            /*0x151d0e0*/ void Add(string str, int value);
            /*0x151de40*/ bool TryGetValue(ref System.Buffers.ReadOnlySequence<byte> bytes, ref int value);
            /*0x151deec*/ bool TryGetValue(System.ReadOnlySpan<byte> bytes, ref int value);
            /*0x151df80*/ string ToString();
            /*0x151e444*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x151e448*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, int>> GetEnumerator();
            /*0x151e574*/ void EmitMatch(System.Reflection.Emit.ILGenerator il, System.Reflection.Emit.LocalBuilder bytesSpan, System.Reflection.Emit.LocalBuilder key, System.Action<System.Collections.Generic.KeyValuePair<string, int>> onFound, System.Action onNotFound);

            class AutomataNode : System.IComparable<MessagePack.Internal.AutomataDictionary.AutomataNode>
            {
                static /*0x0*/ MessagePack.Internal.AutomataDictionary.AutomataNode[] EmptyNodes;
                static /*0x8*/ ulong[] EmptyKeys;
                /*0x10*/ ulong Key;
                /*0x18*/ int Value;
                /*0x20*/ string OriginalKey;
                /*0x28*/ MessagePack.Internal.AutomataDictionary.AutomataNode[] nexts;
                /*0x30*/ ulong[] nextKeys;
                /*0x38*/ int count;

                static /*0x184ad80*/ AutomataNode();
                static /*0x1849fa8*/ int BinarySearch(ulong[] array, int index, int length, ulong value);
                static /*0x184a194*/ void EmitSearchNextCore(System.Reflection.Emit.ILGenerator il, System.Reflection.Emit.LocalBuilder bytesSpan, System.Reflection.Emit.LocalBuilder key, System.Action<System.Collections.Generic.KeyValuePair<string, int>> onFound, System.Action onNotFound, MessagePack.Internal.AutomataDictionary.AutomataNode[] nexts, int count);
                /*0x1849b60*/ AutomataNode(ulong key);
                /*0x1849b50*/ bool get_HasChildren();
                /*0x1849c04*/ MessagePack.Internal.AutomataDictionary.AutomataNode Add(ulong key);
                /*0x1849e14*/ MessagePack.Internal.AutomataDictionary.AutomataNode Add(ulong key, int value, string originalKey);
                /*0x1849e48*/ MessagePack.Internal.AutomataDictionary.AutomataNode SearchNext(ref System.ReadOnlySpan<byte> value);
                /*0x184a02c*/ int CompareTo(MessagePack.Internal.AutomataDictionary.AutomataNode other);
                /*0x184997c*/ System.Collections.Generic.IEnumerable<MessagePack.Internal.AutomataDictionary.AutomataNode> YieldChildren();
                /*0x184a084*/ void EmitSearchNext(System.Reflection.Emit.ILGenerator il, System.Reflection.Emit.LocalBuilder bytesSpan, System.Reflection.Emit.LocalBuilder key, System.Action<System.Collections.Generic.KeyValuePair<string, int>> onFound, System.Action onNotFound);

                class <YieldChildren>d__16 : System.Collections.Generic.IEnumerable<MessagePack.Internal.AutomataDictionary.AutomataNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<MessagePack.Internal.AutomataDictionary.AutomataNode>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ MessagePack.Internal.AutomataDictionary.AutomataNode <>2__current;
                    /*0x20*/ int <>l__initialThreadId;
                    /*0x28*/ MessagePack.Internal.AutomataDictionary.AutomataNode <>4__this;
                    /*0x30*/ int <i>5__2;

                    /*0x184a04c*/ <YieldChildren>d__16(int <>1__state);
                    /*0x1857090*/ void System.IDisposable.Dispose();
                    /*0x1857094*/ bool MoveNext();
                    /*0x1857134*/ MessagePack.Internal.AutomataDictionary.AutomataNode System.Collections.Generic.IEnumerator<MessagePack.Internal.AutomataDictionary.AutomataNode>.get_Current();
                    /*0x185713c*/ void System.Collections.IEnumerator.Reset();
                    /*0x185717c*/ object System.Collections.IEnumerator.get_Current();
                    /*0x1857184*/ System.Collections.Generic.IEnumerator<MessagePack.Internal.AutomataDictionary.AutomataNode> System.Collections.Generic.IEnumerable<MessagePack.Internal.AutomataDictionary.AutomataNode>.GetEnumerator();
                    /*0x185722c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }

                class <>c__DisplayClass18_0
                {
                    /*0x10*/ System.Reflection.Emit.ILGenerator il;

                    /*0x184ad78*/ <>c__DisplayClass18_0();
                    /*0x1857038*/ System.Reflection.Emit.Label <EmitSearchNextCore>b__3(int _);
                    /*0x1857064*/ System.Reflection.Emit.Label <EmitSearchNextCore>b__2(int _);
                }

                class <>c
                {
                    static /*0x0*/ MessagePack.Internal.AutomataDictionary.AutomataNode.<> <>9;
                    static /*0x8*/ System.Func<MessagePack.Internal.AutomataDictionary.AutomataNode, bool> <>9__18_0;
                    static /*0x10*/ System.Func<MessagePack.Internal.AutomataDictionary.AutomataNode, bool> <>9__18_1;

                    static /*0x1856f90*/ <>c();
                    /*0x1856ff0*/ <>c();
                    /*0x1856ff8*/ bool <EmitSearchNextCore>b__18_0(MessagePack.Internal.AutomataDictionary.AutomataNode x);
                    /*0x1857018*/ bool <EmitSearchNextCore>b__18_1(MessagePack.Internal.AutomataDictionary.AutomataNode x);
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

                /*0x1849288*/ <YieldCore>d__9(int <>1__state);
                /*0x18492c0*/ void System.IDisposable.Dispose();
                /*0x18494c0*/ bool MoveNext();
                /*0x1849404*/ void <>m__Finally1();
                /*0x1849348*/ void <>m__Finally2();
                /*0x18499f8*/ System.Collections.Generic.KeyValuePair<string, int> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Int32>>.get_Current();
                /*0x1849a04*/ void System.Collections.IEnumerator.Reset();
                /*0x1849a44*/ object System.Collections.IEnumerator.get_Current();
                /*0x1849aa4*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, int>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Int32>>.GetEnumerator();
                /*0x1849b4c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class AutomataKeyGen
        {
            static /*0x0*/ System.Reflection.MethodInfo GetKeyMethod;

            static /*0x151e590*/ AutomataKeyGen();
            static /*0x151d218*/ ulong GetKey(ref System.ReadOnlySpan<byte> span);
        }

        class ByteArrayStringHashTable : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, int>>, System.Collections.IEnumerable
        {
            static /*0x0*/ bool Is32Bit;
            /*0x10*/ MessagePack.Internal.ByteArrayStringHashTable.Entry[][] buckets;
            /*0x18*/ ulong indexFor;

            static /*0x152748c*/ ByteArrayStringHashTable();
            static /*0x15265f8*/ ulong ByteArrayGetHashCode(System.ReadOnlySpan<byte> x);
            static /*0x15230b8*/ int CalculateCapacity(int collectionSize, float loadFactor);
            /*0x1522fb4*/ ByteArrayStringHashTable(int capacity);
            /*0x1522fc0*/ ByteArrayStringHashTable(int capacity, float loadFactor);
            /*0x1523100*/ void Add(string key, int value);
            /*0x15242c4*/ void Add(byte[] key, int value);
            /*0x15231b8*/ bool TryAddInternal(byte[] key, int value);
            /*0x1524370*/ bool TryGetValue(ref System.Buffers.ReadOnlySequence<byte> key, ref int value);
            /*0x1525484*/ bool TryGetValue(System.ReadOnlySpan<byte> key, ref int value);
            /*0x1526488*/ bool TryGetValueSlow(System.ReadOnlySpan<byte> key, MessagePack.Internal.ByteArrayStringHashTable.Entry[] entry, ref int value);
            /*0x152741c*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, int>> GetEnumerator();
            /*0x1527488*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

            struct Entry
            {
                /*0x10*/ byte[] Key;
                /*0x18*/ int Value;

                /*0xacb7d8*/ string ToString();
            }

            class <GetEnumerator>d__13 : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, int>>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Collections.Generic.KeyValuePair<string, int> <>2__current;
                /*0x28*/ MessagePack.Internal.ByteArrayStringHashTable <>4__this;
                /*0x30*/ MessagePack.Internal.ByteArrayStringHashTable.Entry[][] <>7__wrap1;
                /*0x38*/ int <>7__wrap2;
                /*0x40*/ MessagePack.Internal.ByteArrayStringHashTable.Entry[] <>7__wrap3;
                /*0x48*/ int <>7__wrap4;

                /*0x184ae18*/ <GetEnumerator>d__13(int <>1__state);
                /*0x184ae44*/ void System.IDisposable.Dispose();
                /*0x184ae48*/ bool MoveNext();
                /*0x184afd0*/ System.Collections.Generic.KeyValuePair<string, int> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Int32>>.get_Current();
                /*0x184afdc*/ void System.Collections.IEnumerator.Reset();
                /*0x184b01c*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class CodeGenHelpers
        {
            static /*0x1527890*/ byte[] GetEncodedStringBytes(string value);
            static /*0x1525380*/ System.ReadOnlySpan<byte> GetSpanFromSequence(ref System.Buffers.ReadOnlySequence<byte> sequence);
            static /*0x1527b54*/ System.ReadOnlySpan<byte> ReadStringSpan(ref MessagePack.MessagePackReader reader);
            static /*0x1527ca0*/ byte[] GetArrayFromNullableSequence(ref System.Nullable<System.Buffers.ReadOnlySequence<byte>> sequence);
            static /*0x1527bec*/ System.ReadOnlySpan<byte> GetSpanFromSequence(ref System.Nullable<System.Buffers.ReadOnlySequence<byte>> sequence);
        }

        class DateTimeConstants
        {
            static long BclSecondsAtUnixEpoch = 62135596800;
            static int NanosecondsPerTick = 100;
            static /*0x0*/ System.DateTime UnixEpoch;

            static /*0x1528c04*/ DateTimeConstants();
        }

        class DynamicAssembly
        {
            /*0x10*/ System.Reflection.Emit.AssemblyBuilder assemblyBuilder;
            /*0x18*/ System.Reflection.Emit.ModuleBuilder moduleBuilder;
            /*0x20*/ object gate;

            /*0x152a974*/ DynamicAssembly(string moduleName);
            /*0x152aa6c*/ System.Reflection.Emit.TypeBuilder DefineType(string name, System.Reflection.TypeAttributes attr);
            /*0x152ab60*/ System.Reflection.Emit.TypeBuilder DefineType(string name, System.Reflection.TypeAttributes attr, System.Type parent);
            /*0x152ac64*/ System.Reflection.Emit.TypeBuilder DefineType(string name, System.Reflection.TypeAttributes attr, System.Type parent, System.Type[] interfaces);
        }

        class ExpressionUtility
        {
            static /*0x1538db4*/ System.Reflection.MethodInfo GetMethodInfoCore(System.Linq.Expressions.LambdaExpression expression);
            static System.Reflection.MethodInfo GetMethodInfo<T>(System.Linq.Expressions.Expression<System.Func<T>> expression);
            static /*0x1538e80*/ System.Reflection.MethodInfo GetMethodInfo(System.Linq.Expressions.Expression<System.Action> expression);
            static System.Reflection.MethodInfo GetMethodInfo<T, TR>(System.Linq.Expressions.Expression<System.Func<T, TR>> expression);
            static System.Reflection.MethodInfo GetMethodInfo<T>(System.Linq.Expressions.Expression<System.Action<T>> expression);
            static System.Reflection.MethodInfo GetMethodInfo<T, TArg1, TR>(System.Linq.Expressions.Expression<System.Func<T, TArg1, TR>> expression);
            static System.Reflection.MemberInfo GetMemberInfoCore<T>(System.Linq.Expressions.Expression<T> source);
            static System.Reflection.PropertyInfo GetPropertyInfo<T, TR>(System.Linq.Expressions.Expression<System.Func<T, TR>> expression);
            static System.Reflection.FieldInfo GetFieldInfo<T, TR>(System.Linq.Expressions.Expression<System.Func<T, TR>> expression);
        }

        class FarmHash
        {
            static uint c1 = 3432918353;
            static uint c2 = 461845907;
            static ulong k0 = 14097894508562428199;
            static ulong k1 = 13011662864482103923;
            static ulong k2 = 11160318154034397263;

            static /*0x1539058*/ uint Hash32(System.ReadOnlySpan<byte> bytes);
            static /*0x1539550*/ uint Fetch32(byte* p);
            static /*0x1539558*/ uint Rotate32(uint val, int shift);
            static /*0x1539568*/ uint fmix(uint h);
            static /*0x1539590*/ uint Mur(uint a, uint h);
            static /*0x15395d4*/ uint Hash32Len0to4(System.ReadOnlySpan<byte> s);
            static /*0x1539704*/ uint Hash32Len5to12(byte* s, uint len);
            static /*0x15397d4*/ uint Hash32Len13to24(byte* s, uint len);
            static /*0x15398c4*/ uint Hash32(byte* s, uint len);
            static /*0x1539c2c*/ ulong Hash64(System.ReadOnlySpan<byte> bytes);
            static /*0x153a504*/ void swap(ref ulong x, ref ulong z);
            static /*0x153a518*/ ulong Fetch64(byte* p);
            static /*0x153a520*/ ulong Rotate64(ulong val, int shift);
            static /*0x153a530*/ ulong ShiftMix(ulong val);
            static /*0x153a538*/ ulong HashLen16(ulong u, ulong v, ulong mul);
            static /*0x153a558*/ ulong Hash64(byte* s, uint len);
            static /*0x153ade8*/ ulong HashLen0to16(byte* s, uint len);
            static /*0x153aee8*/ ulong HashLen17to32(byte* s, uint len);
            static /*0x153af6c*/ ulong H32(byte* s, uint len, ulong mul, ulong seed0, ulong seed1);
            static /*0x153afec*/ ulong HashLen33to64(byte* s, uint len);
            static /*0x153b0d0*/ ulong HashLen65to96(byte* s, uint len);
            static /*0x153b214*/ void WeakHashLen32WithSeeds(ulong w, ulong x, ulong y, ulong z, ulong a, ulong b, ref ulong first, ref ulong second);
            static /*0x153b248*/ void WeakHashLen32WithSeeds(byte* s, ulong a, ulong b, ref ulong first, ref ulong second);
            static /*0x153b284*/ ulong Hash64NA(byte* s, uint len);
            static /*0x153b4e8*/ ulong H(ulong x, ulong y, ulong mul, int r);
            static /*0x153b510*/ ulong Hash64UO(byte* s, uint len);
        }

        struct GuidBits
        {
            static /*0x0*/ byte[] byteToHexStringHigh;
            static /*0x8*/ byte[] byteToHexStringLow;
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

            static /*0x22fef80*/ GuidBits();
            static /*0x22fe158*/ byte Parse(System.ReadOnlySpan<byte> bytes, int highOffset);
            static /*0x22fe214*/ byte SwitchParse(byte b);
            /*0xae4874*/ GuidBits(ref System.Guid value);
            /*0xae4884*/ GuidBits(System.ReadOnlySpan<byte> utf8string);
            /*0xae48b8*/ void Write(System.Span<byte> buffer);
        }

        struct ArgumentField
        {
            /*0x10*/ int i;
            /*0x14*/ bool ref;
            /*0x18*/ System.Reflection.Emit.ILGenerator il;

            /*0xaa34d8*/ ArgumentField(System.Reflection.Emit.ILGenerator il, int i, bool ref);
            /*0xaa34ec*/ ArgumentField(System.Reflection.Emit.ILGenerator il, int i, System.Type type);
            /*0xaa34f4*/ void EmitLoad();
            /*0xaa34fc*/ void EmitLdarg();
            /*0xaa3510*/ void EmitLdarga();
            /*0xaa3524*/ void EmitStore();
        }

        class ILGeneratorExtensions
        {
            static /*0x22ffe14*/ void EmitLdloc(System.Reflection.Emit.ILGenerator il, int index);
            static /*0x22fffe8*/ void EmitLdloc(System.Reflection.Emit.ILGenerator il, System.Reflection.Emit.LocalBuilder local);
            static /*0x2300028*/ void EmitStloc(System.Reflection.Emit.ILGenerator il, int index);
            static /*0x23001fc*/ void EmitStloc(System.Reflection.Emit.ILGenerator il, System.Reflection.Emit.LocalBuilder local);
            static /*0x230023c*/ void EmitLdloca(System.Reflection.Emit.ILGenerator il, int index);
            static /*0x23002fc*/ void EmitLdloca(System.Reflection.Emit.ILGenerator il, System.Reflection.Emit.LocalBuilder local);
            static /*0x230033c*/ void EmitTrue(System.Reflection.Emit.ILGenerator il);
            static /*0x230034c*/ void EmitFalse(System.Reflection.Emit.ILGenerator il);
            static /*0x2300344*/ void EmitBoolean(System.Reflection.Emit.ILGenerator il, bool value);
            static /*0x2300354*/ void EmitLdc_I4(System.Reflection.Emit.ILGenerator il, int value);
            static /*0x230068c*/ void EmitUnboxOrCast(System.Reflection.Emit.ILGenerator il, System.Type type);
            static /*0x230076c*/ void EmitBoxOrDoNothing(System.Reflection.Emit.ILGenerator il, System.Type type);
            static /*0x2300828*/ void EmitLdarg(System.Reflection.Emit.ILGenerator il, int index);
            static /*0x23009fc*/ void EmitLoadThis(System.Reflection.Emit.ILGenerator il);
            static /*0x2300a04*/ void EmitLdarga(System.Reflection.Emit.ILGenerator il, int index);
            static /*0x2300ac4*/ void EmitStarg(System.Reflection.Emit.ILGenerator il, int index);
            static /*0x2300b84*/ void EmitPop(System.Reflection.Emit.ILGenerator il, int count);
            static /*0x2300c28*/ void EmitCall(System.Reflection.Emit.ILGenerator il, System.Reflection.MethodInfo methodInfo);
            static /*0x2300d18*/ void EmitLdfld(System.Reflection.Emit.ILGenerator il, System.Reflection.FieldInfo fieldInfo);
            static /*0x2300da8*/ void EmitLdsfld(System.Reflection.Emit.ILGenerator il, System.Reflection.FieldInfo fieldInfo);
            static /*0x2300e38*/ void EmitRet(System.Reflection.Emit.ILGenerator il);
            static /*0x2300eb4*/ void EmitIntZeroReturn(System.Reflection.Emit.ILGenerator il);
            static /*0x2300f3c*/ void EmitNullReturn(System.Reflection.Emit.ILGenerator il);
            static /*0x2300fd4*/ void EmitULong(System.Reflection.Emit.ILGenerator il, ulong value);
            static /*0x2301060*/ void EmitThrowNotimplemented(System.Reflection.Emit.ILGenerator il);
            static /*0x230128c*/ void EmitIncrementFor(System.Reflection.Emit.ILGenerator il, System.Reflection.Emit.LocalBuilder conditionGreater, System.Action<System.Reflection.Emit.LocalBuilder> emitBody);

            class <>c
            {
                static /*0x0*/ MessagePack.Internal.ILGeneratorExtensions.<> <>9;
                static /*0x8*/ System.Func<System.Reflection.ConstructorInfo, bool> <>9__24_0;

                static /*0x1850adc*/ <>c();
                /*0x1850b3c*/ <>c();
                /*0x1850b44*/ bool <EmitThrowNotimplemented>b__24_0(System.Reflection.ConstructorInfo x);
            }
        }

        class ReflectionExtensions
        {
            static /*0x178e010*/ bool IsNullable(System.Reflection.TypeInfo type);
            static /*0x178e0e8*/ bool IsPublic(System.Reflection.TypeInfo type);
            static /*0x178e100*/ bool IsAnonymous(System.Reflection.TypeInfo type);
            static /*0x17891c0*/ bool IsIndexer(System.Reflection.PropertyInfo propertyInfo);
            static /*0x178e234*/ bool IsConstructedGenericType(System.Reflection.TypeInfo type);
            static /*0x178e26c*/ System.Reflection.MethodInfo GetGetMethod(System.Reflection.PropertyInfo propInfo);
            static /*0x178e28c*/ System.Reflection.MethodInfo GetSetMethod(System.Reflection.PropertyInfo propInfo);
        }

        class RuntimeTypeHandleEqualityComparer : System.Collections.Generic.IEqualityComparer<System.RuntimeTypeHandle>
        {
            static /*0x0*/ System.Collections.Generic.IEqualityComparer<System.RuntimeTypeHandle> Default;

            static /*0x178e540*/ RuntimeTypeHandleEqualityComparer();
            /*0x178e4e0*/ RuntimeTypeHandleEqualityComparer();
            /*0x178e4e8*/ bool Equals(System.RuntimeTypeHandle x, System.RuntimeTypeHandle y);
            /*0x178e518*/ int GetHashCode(System.RuntimeTypeHandle obj);
        }

        class ThreadsafeTypeKeyHashTable<TValue>
        {
            /*0x0*/ MessagePack.Internal.ThreadsafeTypeKeyHashTable.Entry<TValue> buckets;
            /*0x0*/ int size;
            /*0x0*/ object writerLock;
            /*0x0*/ float loadFactor;

            static int CalculateCapacity(int collectionSize, float loadFactor);
            static void VolatileWrite(ref MessagePack.Internal.ThreadsafeTypeKeyHashTable.Entry<TValue> location, MessagePack.Internal.ThreadsafeTypeKeyHashTable.Entry<TValue> value);
            static void VolatileWrite(ref MessagePack.Internal.ThreadsafeTypeKeyHashTable.Entry<TValue> location, MessagePack.Internal.ThreadsafeTypeKeyHashTable.Entry<TValue> value);
            ThreadsafeTypeKeyHashTable(int capacity, float loadFactor);
            bool TryAdd(System.Type key, TValue value);
            bool TryAdd(System.Type key, System.Func<System.Type, TValue> valueFactory);
            bool TryAddInternal(System.Type key, System.Func<System.Type, TValue> valueFactory, ref TValue resultingValue);
            bool AddToBuckets(MessagePack.Internal.ThreadsafeTypeKeyHashTable.Entry<TValue> buckets, System.Type newKey, MessagePack.Internal.ThreadsafeTypeKeyHashTable.Entry<TValue> newEntryOrNull, System.Func<System.Type, TValue> valueFactory, ref TValue resultingValue);
            bool TryGetValue(System.Type key, ref TValue value);
            TValue GetOrAdd(System.Type key, System.Func<System.Type, TValue> valueFactory);

            class Entry<TValue>
            {
                /*0x0*/ System.Type Key;
                /*0x0*/ TValue Value;
                /*0x0*/ int Hash;
                /*0x0*/ MessagePack.Internal.ThreadsafeTypeKeyHashTable.Entry<TValue> Next;

                Entry();
                string ToString();
                int Count();
            }

            class <>c__DisplayClass5_0<TValue>
            {
                /*0x0*/ TValue value;

                <>c__DisplayClass5_0();
                TValue <TryAdd>b__0(System.Type _);
            }
        }

        class BuiltinResolverGetFormatterHelper
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, object> FormatterMap;

            static /*0x15208c4*/ BuiltinResolverGetFormatterHelper();
            static /*0x1520818*/ object GetFormatter(System.Type t);
        }

        class DynamicGenericResolverGetFormatterHelper
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, System.Type> FormatterMap;

            static /*0x152cd18*/ DynamicGenericResolverGetFormatterHelper();
            static /*0x152b750*/ object GetFormatter(System.Type t);
            static /*0x152ccdc*/ object CreateInstance(System.Type genericType, System.Type[] genericTypeArguments, object[] arguments);

            class <>c
            {
                static /*0x0*/ MessagePack.Internal.DynamicGenericResolverGetFormatterHelper.<> <>9;
                static /*0x8*/ System.Func<System.Type, bool> <>9__1_2;
                static /*0x10*/ System.Func<System.Reflection.ConstructorInfo, bool> <>9__1_3;
                static /*0x18*/ System.Func<System.Type, bool> <>9__1_4;
                static /*0x20*/ System.Func<System.Reflection.ConstructorInfo, bool> <>9__1_5;
                static /*0x28*/ System.Func<System.Reflection.ConstructorInfo, bool> <>9__1_0;
                static /*0x30*/ System.Func<System.Reflection.ConstructorInfo, bool> <>9__1_1;

                static /*0x184b368*/ <>c();
                /*0x184b3c8*/ <>c();
                /*0x184b3d0*/ bool <GetFormatter>b__1_2(System.Type x);
                /*0x184b4a8*/ bool <GetFormatter>b__1_3(System.Reflection.ConstructorInfo x);
                /*0x184b4e4*/ bool <GetFormatter>b__1_4(System.Type x);
                /*0x184b5bc*/ bool <GetFormatter>b__1_5(System.Reflection.ConstructorInfo x);
                /*0x184b5f8*/ bool <GetFormatter>b__1_0(System.Reflection.ConstructorInfo x);
                /*0x184b634*/ bool <GetFormatter>b__1_1(System.Reflection.ConstructorInfo x);
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

            static /*0x1534428*/ DynamicObjectTypeBuilder();
            static /*0x152d90c*/ System.Reflection.TypeInfo BuildType(MessagePack.Internal.DynamicAssembly assembly, System.Type type, bool forceStringKey, bool contractless);
            static /*0x1531440*/ object BuildFormatterToDynamicMethod(System.Type type, bool forceStringKey, bool contractless, bool allowPrivate);
            static /*0x152e3bc*/ void BuildConstructor(System.Type type, MessagePack.Internal.ObjectSerializationInfo info, System.Reflection.ConstructorInfo method, System.Reflection.Emit.FieldBuilder stringByteKeysField, System.Reflection.Emit.ILGenerator il);
            static /*0x152eaa0*/ System.Collections.Generic.Dictionary<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, System.Reflection.FieldInfo> BuildCustomFormatterField(System.Reflection.Emit.TypeBuilder builder, MessagePack.Internal.ObjectSerializationInfo info, System.Reflection.Emit.ILGenerator il);
            static /*0x152f354*/ void BuildSerialize(System.Type type, MessagePack.Internal.ObjectSerializationInfo info, System.Reflection.Emit.ILGenerator il, System.Action emitStringByteKeys, System.Func<int, MessagePack.Internal.ObjectSerializationInfo.EmittableMember, System.Action> tryEmitLoadCustomFormatter, int firstArgIndex);
            static /*0x1532740*/ void EmitSerializeValue(System.Reflection.Emit.ILGenerator il, System.Reflection.TypeInfo type, MessagePack.Internal.ObjectSerializationInfo.EmittableMember member, int index, System.Func<int, MessagePack.Internal.ObjectSerializationInfo.EmittableMember, System.Action> tryEmitLoadCustomFormatter, MessagePack.Internal.ArgumentField argWriter, MessagePack.Internal.ArgumentField argValue, MessagePack.Internal.ArgumentField argOptions, System.Reflection.Emit.LocalBuilder localResolver);
            static /*0x1530364*/ void BuildDeserialize(System.Type type, MessagePack.Internal.ObjectSerializationInfo info, System.Reflection.Emit.ILGenerator il, System.Func<int, MessagePack.Internal.ObjectSerializationInfo.EmittableMember, System.Action> tryEmitLoadCustomFormatter, int firstArgIndex);
            static /*0x1533c6c*/ void EmitDeserializeValue(System.Reflection.Emit.ILGenerator il, MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo info, int index, System.Func<int, MessagePack.Internal.ObjectSerializationInfo.EmittableMember, System.Action> tryEmitLoadCustomFormatter, MessagePack.Internal.ArgumentField argReader, MessagePack.Internal.ArgumentField argOptions, System.Reflection.Emit.LocalBuilder localResolver);
            static /*0x153319c*/ System.Reflection.Emit.LocalBuilder EmitNewObject(System.Reflection.Emit.ILGenerator il, System.Type type, MessagePack.Internal.ObjectSerializationInfo info, MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo[] members);
            static /*0x1532d34*/ bool IsOptimizeTargetType(System.Type type);
            static /*0x15342f8*/ bool Matches(System.Reflection.MethodInfo m, int parameterIndex, System.Type desiredType);

            class MessagePackWriterTypeInfo
            {
                static /*0x0*/ System.Reflection.TypeInfo TypeInfo;
                static /*0x8*/ System.Reflection.MethodInfo WriteMapHeader;
                static /*0x10*/ System.Reflection.MethodInfo WriteArrayHeader;
                static /*0x18*/ System.Reflection.MethodInfo WriteBytes;
                static /*0x20*/ System.Reflection.MethodInfo WriteNil;
                static /*0x28*/ System.Reflection.MethodInfo WriteRaw;

                static /*0x184f31c*/ MessagePackWriterTypeInfo();
            }

            class MessagePackReaderTypeInfo
            {
                static /*0x0*/ System.Reflection.TypeInfo TypeInfo;
                static /*0x8*/ System.Reflection.MethodInfo ReadArrayHeader;
                static /*0x10*/ System.Reflection.MethodInfo ReadMapHeader;
                static /*0x18*/ System.Reflection.MethodInfo ReadBytes;
                static /*0x20*/ System.Reflection.MethodInfo TryReadNil;
                static /*0x28*/ System.Reflection.MethodInfo Skip;

                static /*0x184f11c*/ MessagePackReaderTypeInfo();
            }

            class CodeGenHelpersTypeInfo
            {
                static /*0x0*/ System.Reflection.MethodInfo GetEncodedStringBytes;

                static /*0x184e2a4*/ CodeGenHelpersTypeInfo();
            }

            class EmitInfo
            {
                static /*0x0*/ System.Reflection.MethodInfo GetTypeFromHandle;
                static /*0x8*/ System.Reflection.MethodInfo TypeGetProperty;
                static /*0x10*/ System.Reflection.MethodInfo TypeGetField;
                static /*0x18*/ System.Reflection.MethodInfo GetCustomAttributeMessagePackFormatterAttribute;
                static /*0x20*/ System.Reflection.MethodInfo ActivatorCreateInstance;

                static /*0x184e438*/ EmitInfo();

                class MessagePackFormatterAttr
                {
                    static /*0x0*/ System.Reflection.MethodInfo FormatterType;
                    static /*0x8*/ System.Reflection.MethodInfo Arguments;

                    static /*0x1857298*/ MessagePackFormatterAttr();

                    class <>c
                    {
                        static /*0x0*/ MessagePack.Internal.DynamicObjectTypeBuilder.EmitInfo.MessagePackFormatterAttr.<> <>9;

                        static /*0x1857ff0*/ <>c();
                        /*0x1858050*/ <>c();
                    }
                }

                class <>c
                {
                    static /*0x0*/ MessagePack.Internal.DynamicObjectTypeBuilder.EmitInfo.<> <>9;

                    static /*0x1857230*/ <>c();
                    /*0x1857290*/ <>c();
                }
            }

            class DeserializeInfo
            {
                /*0x10*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMember <MemberInfo>k__BackingField;
                /*0x18*/ System.Reflection.Emit.LocalBuilder <LocalField>k__BackingField;
                /*0x20*/ System.Reflection.Emit.Label <SwitchLabel>k__BackingField;

                /*0x184d644*/ DeserializeInfo();
                /*0x184e408*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMember get_MemberInfo();
                /*0x184e410*/ void set_MemberInfo(MessagePack.Internal.ObjectSerializationInfo.EmittableMember value);
                /*0x184e418*/ System.Reflection.Emit.LocalBuilder get_LocalField();
                /*0x184e420*/ void set_LocalField(System.Reflection.Emit.LocalBuilder value);
                /*0x184e428*/ System.Reflection.Emit.Label get_SwitchLabel();
                /*0x184e430*/ void set_SwitchLabel(System.Reflection.Emit.Label value);
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ System.Reflection.Emit.FieldBuilder stringByteKeysField;
                /*0x18*/ System.Collections.Generic.Dictionary<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, System.Reflection.FieldInfo> customFormatterLookup;

                /*0x184cdcc*/ <>c__DisplayClass3_0();
            }

            class <>c__DisplayClass3_1
            {
                /*0x10*/ System.Reflection.Emit.ILGenerator il;
                /*0x18*/ MessagePack.Internal.DynamicObjectTypeBuilder.<> CS$<>8__locals1;

                /*0x184cdd4*/ <>c__DisplayClass3_1();
                /*0x184cddc*/ void <BuildType>b__0();
                /*0x184ce1c*/ System.Action <BuildType>b__1(int index, MessagePack.Internal.ObjectSerializationInfo.EmittableMember member);
            }

            class <>c__DisplayClass3_2
            {
                /*0x10*/ System.Reflection.FieldInfo fi;
                /*0x18*/ MessagePack.Internal.DynamicObjectTypeBuilder.<> CS$<>8__locals2;

                /*0x184cf14*/ <>c__DisplayClass3_2();
                /*0x184cf1c*/ void <BuildType>b__2();
            }

            class <>c__DisplayClass3_3
            {
                /*0x10*/ System.Reflection.Emit.ILGenerator il;
                /*0x18*/ MessagePack.Internal.DynamicObjectTypeBuilder.<> CS$<>8__locals3;

                /*0x184cf64*/ <>c__DisplayClass3_3();
                /*0x184cf6c*/ System.Action <BuildType>b__3(int index, MessagePack.Internal.ObjectSerializationInfo.EmittableMember member);
            }

            class <>c__DisplayClass3_4
            {
                /*0x10*/ System.Reflection.FieldInfo fi;
                /*0x18*/ MessagePack.Internal.DynamicObjectTypeBuilder.<> CS$<>8__locals4;

                /*0x184d064*/ <>c__DisplayClass3_4();
                /*0x184d06c*/ void <BuildType>b__4();
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ System.Collections.Generic.List<object> serializeCustomFormatters;
                /*0x18*/ System.Collections.Generic.List<object> deserializeCustomFormatters;

                /*0x184d0b4*/ <>c__DisplayClass4_0();
            }

            class <>c__DisplayClass4_1
            {
                /*0x10*/ System.Reflection.Emit.ILGenerator il;
                /*0x18*/ MessagePack.Internal.DynamicObjectTypeBuilder.<> CS$<>8__locals1;

                /*0x184d0bc*/ <>c__DisplayClass4_1();
                /*0x184d0c4*/ void <BuildFormatterToDynamicMethod>b__3();
                /*0x184d0d4*/ System.Action <BuildFormatterToDynamicMethod>b__4(int index, MessagePack.Internal.ObjectSerializationInfo.EmittableMember member);
            }

            class <>c__DisplayClass4_2
            {
                /*0x10*/ int index;
                /*0x18*/ MessagePack.Internal.DynamicObjectTypeBuilder.<> CS$<>8__locals2;

                /*0x184d1e8*/ <>c__DisplayClass4_2();
                /*0x184d1f0*/ void <BuildFormatterToDynamicMethod>b__5();
            }

            class <>c__DisplayClass4_3
            {
                /*0x10*/ System.Reflection.Emit.ILGenerator il;
                /*0x18*/ MessagePack.Internal.DynamicObjectTypeBuilder.<> CS$<>8__locals3;

                /*0x184d334*/ <>c__DisplayClass4_3();
                /*0x184d33c*/ System.Action <BuildFormatterToDynamicMethod>b__6(int index, MessagePack.Internal.ObjectSerializationInfo.EmittableMember member);
            }

            class <>c__DisplayClass4_4
            {
                /*0x10*/ int index;
                /*0x18*/ MessagePack.Internal.DynamicObjectTypeBuilder.<> CS$<>8__locals4;

                /*0x184d450*/ <>c__DisplayClass4_4();
                /*0x184d458*/ void <BuildFormatterToDynamicMethod>b__7();
            }

            class <>c
            {
                static /*0x0*/ MessagePack.Internal.DynamicObjectTypeBuilder.<> <>9;
                static /*0x8*/ System.Func<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, bool> <>9__4_0;
                static /*0x10*/ MessagePack.Utilities.GetWriterBytesAction<string> <>9__4_1;
                static /*0x18*/ System.Func<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, bool> <>9__4_2;
                static /*0x20*/ System.Func<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, bool> <>9__5_0;
                static /*0x28*/ System.Func<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, bool> <>9__5_1;
                static /*0x30*/ System.Func<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, bool> <>9__6_0;
                static /*0x38*/ System.Func<System.Type, bool> <>9__7_0;
                static /*0x40*/ System.Func<System.Reflection.MethodInfo, bool> <>9__7_1;
                static /*0x48*/ System.Func<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, bool> <>9__7_2;
                static /*0x50*/ System.Func<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, int> <>9__7_3;
                static /*0x58*/ System.Func<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, bool> <>9__7_4;
                static /*0x60*/ System.Func<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, int> <>9__7_5;
                static /*0x68*/ System.Func<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, bool> <>9__7_6;
                static /*0x70*/ System.Func<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, bool> <>9__7_7;
                static /*0x78*/ System.Func<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, int> <>9__9_2;
                static /*0x80*/ System.Func<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, int> <>9__9_3;
                static /*0x88*/ System.Func<MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo, System.Reflection.Emit.Label> <>9__9_9;
                static /*0x90*/ System.Func<System.Type, bool> <>9__9_1;
                static /*0x98*/ System.Func<System.Reflection.MethodInfo, bool> <>9__9_10;
                static /*0xa0*/ System.Func<System.Reflection.MethodInfo, bool> <>9__10_0;
                static /*0xa8*/ System.Func<MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo, bool> <>9__11_1;
                static /*0xb0*/ System.Func<MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo, bool> <>9__11_3;

                static /*0x184b670*/ <>c();
                /*0x184b6d0*/ <>c();
                /*0x184b6d8*/ bool <BuildFormatterToDynamicMethod>b__4_0(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x184b6f0*/ void <BuildFormatterToDynamicMethod>b__4_1(ref MessagePack.MessagePackWriter writer, string arg);
                /*0x184c3fc*/ bool <BuildFormatterToDynamicMethod>b__4_2(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x184c414*/ bool <BuildConstructor>b__5_0(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x184c42c*/ bool <BuildConstructor>b__5_1(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x184c444*/ bool <BuildCustomFormatterField>b__6_0(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x184c474*/ bool <BuildSerialize>b__7_0(System.Type x);
                /*0x184c500*/ bool <BuildSerialize>b__7_1(System.Reflection.MethodInfo x);
                /*0x184c564*/ bool <BuildSerialize>b__7_2(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x184c57c*/ int <BuildSerialize>b__7_3(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x184c594*/ bool <BuildSerialize>b__7_4(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x184c5ac*/ int <BuildSerialize>b__7_5(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x184c5c4*/ bool <BuildSerialize>b__7_6(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x184c5dc*/ bool <BuildSerialize>b__7_7(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x184c5f4*/ int <BuildDeserialize>b__9_2(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x184c60c*/ int <BuildDeserialize>b__9_3(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x184c624*/ System.Reflection.Emit.Label <BuildDeserialize>b__9_9(MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo x);
                /*0x184c63c*/ bool <BuildDeserialize>b__9_1(System.Type x);
                /*0x184c6c8*/ bool <BuildDeserialize>b__9_10(System.Reflection.MethodInfo x);
                /*0x184c72c*/ bool <EmitDeserializeValue>b__10_0(System.Reflection.MethodInfo x);
                /*0x184c768*/ bool <EmitNewObject>b__11_1(MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo x);
                /*0x184c798*/ bool <EmitNewObject>b__11_3(MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo x);
                /*0x184c7c8*/ bool <.cctor>b__35_0(System.Reflection.MethodInfo x);
                /*0x184c82c*/ System.Reflection.MethodInfo <.cctor>b__35_1(System.Type t);
                /*0x184ca54*/ System.Reflection.MethodInfo <.cctor>b__35_2(System.Type t);
                /*0x184cc54*/ bool <.cctor>b__35_3(System.Reflection.ConstructorInfo x);
                /*0x184cd38*/ bool <.cctor>b__35_4(System.Reflection.ConstructorInfo x);
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ System.Reflection.Emit.ILGenerator il;
                /*0x18*/ System.Nullable<System.Reflection.Emit.Label> gotoDefault;
                /*0x20*/ MessagePack.Internal.ArgumentField reader;
                /*0x30*/ MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo[] infoList;
                /*0x38*/ System.Func<int, MessagePack.Internal.ObjectSerializationInfo.EmittableMember, System.Action> tryEmitLoadCustomFormatter;
                /*0x40*/ MessagePack.Internal.ArgumentField argOptions;
                /*0x50*/ System.Reflection.Emit.LocalBuilder localResolver;

                /*0x184d59c*/ <>c__DisplayClass9_0();
                /*0x184d5a4*/ MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo <BuildDeserialize>b__0(MessagePack.Internal.ObjectSerializationInfo.EmittableMember item);
            }

            class <>c__DisplayClass9_1
            {
                /*0x10*/ System.Collections.Generic.Dictionary<int, MessagePack.Internal.ObjectSerializationInfo.EmittableMember> intKeyMap;
                /*0x18*/ MessagePack.Internal.DynamicObjectTypeBuilder.<> CS$<>8__locals1;

                /*0x184d6ac*/ <>c__DisplayClass9_1();
                /*0x184d6b4*/ MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo <BuildDeserialize>b__4(int x);
            }

            class <>c__DisplayClass9_2
            {
                /*0x10*/ System.Reflection.Emit.LocalBuilder buffer;
                /*0x18*/ MessagePack.Internal.AutomataDictionary automata;
                /*0x20*/ System.Reflection.Emit.LocalBuilder longKey;
                /*0x28*/ MessagePack.Internal.DynamicObjectTypeBuilder.<> CS$<>8__locals2;

                /*0x184d868*/ <>c__DisplayClass9_2();
                /*0x184d870*/ void <BuildDeserialize>b__5(System.Reflection.Emit.LocalBuilder forILocal);
            }

            class <>c__DisplayClass9_3
            {
                /*0x10*/ System.Reflection.Emit.Label loopEnd;
                /*0x14*/ System.Reflection.Emit.Label readNext;
                /*0x18*/ MessagePack.Internal.DynamicObjectTypeBuilder.<> CS$<>8__locals3;

                /*0x184db24*/ <>c__DisplayClass9_3();
                /*0x184db2c*/ void <BuildDeserialize>b__6(System.Collections.Generic.KeyValuePair<string, int> x);
                /*0x184dcdc*/ void <BuildDeserialize>b__7();
            }

            class <>c__DisplayClass9_4
            {
                /*0x10*/ System.Reflection.Emit.LocalBuilder key;
                /*0x18*/ System.Reflection.Emit.Label switchDefault;
                /*0x20*/ MessagePack.Internal.DynamicObjectTypeBuilder.<> CS$<>8__locals4;

                /*0x184dd78*/ <>c__DisplayClass9_4();
                /*0x184dd80*/ void <BuildDeserialize>b__8(System.Reflection.Emit.LocalBuilder forILocal);
            }

            class <>c__DisplayClass11_0
            {
                /*0x10*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMember item;

                /*0x184cd74*/ <>c__DisplayClass11_0();
                /*0x184cd7c*/ bool <EmitNewObject>b__0(MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo x);
            }

            class <>c__DisplayClass11_1
            {
                /*0x10*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMember item;

                /*0x184cda0*/ <>c__DisplayClass11_1();
                /*0x184cda8*/ bool <EmitNewObject>b__2(MessagePack.Internal.DynamicObjectTypeBuilder.DeserializeInfo x);
            }
        }

        class AnonymousSerializeFunc<T> : System.MulticastDelegate
        {
            AnonymousSerializeFunc(object object, nint method);
            void Invoke(byte[][] stringByteKeysField, object[] customFormatters, ref MessagePack.MessagePackWriter writer, T value, MessagePack.MessagePackSerializerOptions options);
            System.IAsyncResult BeginInvoke(byte[][] stringByteKeysField, object[] customFormatters, ref MessagePack.MessagePackWriter writer, T value, MessagePack.MessagePackSerializerOptions options, System.AsyncCallback callback, object object);
            void EndInvoke(ref MessagePack.MessagePackWriter writer, System.IAsyncResult result);
        }

        class AnonymousDeserializeFunc<T> : System.MulticastDelegate
        {
            AnonymousDeserializeFunc(object object, nint method);
            T Invoke(object[] customFormatters, ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
            System.IAsyncResult BeginInvoke(object[] customFormatters, ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options, System.AsyncCallback callback, object object);
            T EndInvoke(ref MessagePack.MessagePackReader reader, System.IAsyncResult result);
        }

        class AnonymousSerializableFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<T>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x0*/ byte[][] stringByteKeysField;
            /*0x0*/ object[] serializeCustomFormatters;
            /*0x0*/ object[] deserializeCustomFormatters;
            /*0x0*/ MessagePack.Internal.AnonymousSerializeFunc<T> serialize;
            /*0x0*/ MessagePack.Internal.AnonymousDeserializeFunc<T> deserialize;

            AnonymousSerializableFormatter(byte[][] stringByteKeysField, object[] serializeCustomFormatters, object[] deserializeCustomFormatters, MessagePack.Internal.AnonymousSerializeFunc<T> serialize, MessagePack.Internal.AnonymousDeserializeFunc<T> deserialize);
            void Serialize(ref MessagePack.MessagePackWriter writer, T value, MessagePack.MessagePackSerializerOptions options);
            T Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ObjectSerializationInfo
        {
            /*0x10*/ System.Type <Type>k__BackingField;
            /*0x18*/ bool <IsIntKey>k__BackingField;
            /*0x19*/ bool <IsClass>k__BackingField;
            /*0x20*/ System.Reflection.ConstructorInfo <BestmatchConstructor>k__BackingField;
            /*0x28*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMember[] <ConstructorParameters>k__BackingField;
            /*0x30*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMember[] <Members>k__BackingField;

            static /*0x1785bfc*/ MessagePack.Internal.ObjectSerializationInfo CreateOrNull(System.Type type, bool forceStringKey, bool contractless, bool allowPrivate);
            static /*0x1789264*/ System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> GetAllFields(System.Type type);
            static /*0x17891f8*/ System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> GetAllProperties(System.Type type);
            static /*0x17892d0*/ bool TryGetNextConstructor(System.Collections.Generic.IEnumerator<System.Reflection.ConstructorInfo> ctorEnumerator, ref System.Reflection.ConstructorInfo ctor);
            /*0x1785bf4*/ ObjectSerializationInfo();
            /*0x1785b6c*/ System.Type get_Type();
            /*0x1785b74*/ void set_Type(System.Type value);
            /*0x1785b7c*/ bool get_IsIntKey();
            /*0x1785b84*/ void set_IsIntKey(bool value);
            /*0x1785b90*/ bool get_IsStringKey();
            /*0x1785ba0*/ bool get_IsClass();
            /*0x1785ba8*/ void set_IsClass(bool value);
            /*0x1785bb4*/ bool get_IsStruct();
            /*0x1785bc4*/ System.Reflection.ConstructorInfo get_BestmatchConstructor();
            /*0x1785bcc*/ void set_BestmatchConstructor(System.Reflection.ConstructorInfo value);
            /*0x1785bd4*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMember[] get_ConstructorParameters();
            /*0x1785bdc*/ void set_ConstructorParameters(MessagePack.Internal.ObjectSerializationInfo.EmittableMember[] value);
            /*0x1785be4*/ MessagePack.Internal.ObjectSerializationInfo.EmittableMember[] get_Members();
            /*0x1785bec*/ void set_Members(MessagePack.Internal.ObjectSerializationInfo.EmittableMember[] value);

            class EmittableMember
            {
                /*0x10*/ bool <IsWritable>k__BackingField;
                /*0x11*/ bool <IsReadable>k__BackingField;
                /*0x14*/ int <IntKey>k__BackingField;
                /*0x18*/ string <StringKey>k__BackingField;
                /*0x20*/ System.Reflection.FieldInfo <FieldInfo>k__BackingField;
                /*0x28*/ System.Reflection.PropertyInfo <PropertyInfo>k__BackingField;
                /*0x30*/ bool <IsExplicitContract>k__BackingField;

                /*0x1856500*/ EmittableMember();
                /*0x1856190*/ bool get_IsProperty();
                /*0x18561a0*/ bool get_IsField();
                /*0x18561b0*/ bool get_IsWritable();
                /*0x18561b8*/ void set_IsWritable(bool value);
                /*0x18561c4*/ bool get_IsReadable();
                /*0x18561cc*/ void set_IsReadable(bool value);
                /*0x18561d8*/ int get_IntKey();
                /*0x18561e0*/ void set_IntKey(int value);
                /*0x18561e8*/ string get_StringKey();
                /*0x18561f0*/ void set_StringKey(string value);
                /*0x184d64c*/ System.Type get_Type();
                /*0x18561f8*/ System.Reflection.FieldInfo get_FieldInfo();
                /*0x1856200*/ void set_FieldInfo(System.Reflection.FieldInfo value);
                /*0x1856208*/ System.Reflection.PropertyInfo get_PropertyInfo();
                /*0x1856210*/ void set_PropertyInfo(System.Reflection.PropertyInfo value);
                /*0x1856218*/ string get_Name();
                /*0x1856264*/ bool get_IsValueType();
                /*0x18562c8*/ bool get_IsExplicitContract();
                /*0x18562d0*/ void set_IsExplicitContract(bool value);
                /*0x18562dc*/ MessagePack.MessagePackFormatterAttribute GetMessagePackFormatterAttribute();
                /*0x1855570*/ System.Runtime.Serialization.DataMemberAttribute GetDataMemberAttribute();
                /*0x1856348*/ void EmitLoadValue(System.Reflection.Emit.ILGenerator il);
                /*0x1856424*/ void EmitStoreValue(System.Reflection.Emit.ILGenerator il);
            }

            class OrderBaseTypesBeforeDerivedTypes : System.Collections.Generic.IComparer<System.Type>
            {
                static /*0x0*/ MessagePack.Internal.ObjectSerializationInfo.OrderBaseTypesBeforeDerivedTypes Instance;

                static /*0x18565a0*/ OrderBaseTypesBeforeDerivedTypes();
                /*0x1856508*/ OrderBaseTypesBeforeDerivedTypes();
                /*0x1856510*/ int Compare(System.Type x, System.Type y);
            }

            class <>c__DisplayClass29_0
            {
                /*0x10*/ System.Collections.Generic.List<MessagePack.Internal.ObjectSerializationInfo.EmittableMember> constructorParameters;

                /*0x18555dc*/ <>c__DisplayClass29_0();
                /*0x18555e4*/ bool <CreateOrNull>b__9(MessagePack.Internal.ObjectSerializationInfo.EmittableMember m);
            }

            class <>c
            {
                static /*0x0*/ MessagePack.Internal.ObjectSerializationInfo.<> <>9;
                static /*0x8*/ System.Func<System.Reflection.MemberInfo, System.Type> <>9__29_5;
                static /*0x10*/ System.Func<System.Reflection.MemberInfo, string> <>9__29_6;
                static /*0x18*/ System.Func<System.Reflection.ConstructorInfo, bool> <>9__29_0;
                static /*0x20*/ System.Func<System.Reflection.ConstructorInfo, bool> <>9__29_1;
                static /*0x28*/ System.Func<System.Reflection.ConstructorInfo, int> <>9__29_2;
                static /*0x30*/ System.Func<System.Collections.Generic.KeyValuePair<string, MessagePack.Internal.ObjectSerializationInfo.EmittableMember>, string> <>9__29_7;
                static /*0x38*/ System.Func<System.Collections.Generic.KeyValuePair<string, MessagePack.Internal.ObjectSerializationInfo.EmittableMember>, System.Collections.Generic.KeyValuePair<string, MessagePack.Internal.ObjectSerializationInfo.EmittableMember>> <>9__29_8;
                static /*0x40*/ System.Func<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, int> <>9__29_3;
                static /*0x48*/ System.Func<MessagePack.Internal.ObjectSerializationInfo.EmittableMember, int> <>9__29_4;

                static /*0x1855388*/ <>c();
                /*0x18553e8*/ <>c();
                /*0x18553f0*/ System.Type <CreateOrNull>b__29_5(System.Reflection.MemberInfo m);
                /*0x1855410*/ string <CreateOrNull>b__29_6(System.Reflection.MemberInfo m);
                /*0x1855430*/ bool <CreateOrNull>b__29_0(System.Reflection.ConstructorInfo x);
                /*0x185548c*/ bool <CreateOrNull>b__29_1(System.Reflection.ConstructorInfo x);
                /*0x18554a8*/ int <CreateOrNull>b__29_2(System.Reflection.ConstructorInfo x);
                /*0x18554dc*/ string <CreateOrNull>b__29_7(System.Collections.Generic.KeyValuePair<string, MessagePack.Internal.ObjectSerializationInfo.EmittableMember> x);
                /*0x185551c*/ System.Collections.Generic.KeyValuePair<string, MessagePack.Internal.ObjectSerializationInfo.EmittableMember> <CreateOrNull>b__29_8(System.Collections.Generic.KeyValuePair<string, MessagePack.Internal.ObjectSerializationInfo.EmittableMember> x);
                /*0x1855528*/ int <CreateOrNull>b__29_3(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
                /*0x1855540*/ int <CreateOrNull>b__29_4(MessagePack.Internal.ObjectSerializationInfo.EmittableMember x);
            }

            class <GetAllFields>d__30 : System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Reflection.FieldInfo>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Reflection.FieldInfo <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ System.Type type;
                /*0x30*/ System.Type <>3__type;
                /*0x38*/ System.Collections.Generic.IEnumerator<System.Reflection.FieldInfo> <>7__wrap1;
                /*0x40*/ System.Reflection.FieldInfo[] <>7__wrap2;
                /*0x48*/ int <>7__wrap3;

                /*0x1855670*/ <GetAllFields>d__30(int <>1__state);
                /*0x18556a8*/ void System.IDisposable.Dispose();
                /*0x1855780*/ bool MoveNext();
                /*0x18556c4*/ void <>m__Finally1();
                /*0x1855b04*/ System.Reflection.FieldInfo System.Collections.Generic.IEnumerator<System.Reflection.FieldInfo>.get_Current();
                /*0x1855b0c*/ void System.Collections.IEnumerator.Reset();
                /*0x1855b4c*/ object System.Collections.IEnumerator.get_Current();
                /*0x1855b54*/ System.Collections.Generic.IEnumerator<System.Reflection.FieldInfo> System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo>.GetEnumerator();
                /*0x1855bfc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <GetAllProperties>d__31 : System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Reflection.PropertyInfo>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Reflection.PropertyInfo <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ System.Type type;
                /*0x30*/ System.Type <>3__type;
                /*0x38*/ System.Collections.Generic.IEnumerator<System.Reflection.PropertyInfo> <>7__wrap1;
                /*0x40*/ System.Reflection.PropertyInfo[] <>7__wrap2;
                /*0x48*/ int <>7__wrap3;

                /*0x1855c00*/ <GetAllProperties>d__31(int <>1__state);
                /*0x1855c38*/ void System.IDisposable.Dispose();
                /*0x1855d10*/ bool MoveNext();
                /*0x1855c54*/ void <>m__Finally1();
                /*0x1856094*/ System.Reflection.PropertyInfo System.Collections.Generic.IEnumerator<System.Reflection.PropertyInfo>.get_Current();
                /*0x185609c*/ void System.Collections.IEnumerator.Reset();
                /*0x18560dc*/ object System.Collections.IEnumerator.get_Current();
                /*0x18560e4*/ System.Collections.Generic.IEnumerator<System.Reflection.PropertyInfo> System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo>.GetEnumerator();
                /*0x185618c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class MessagePackDynamicObjectResolverException : MessagePack.MessagePackSerializationException
        {
            /*0x230b458*/ MessagePackDynamicObjectResolverException(string message);
        }

        class NativeDateTimeResolverGetFormatterHelper
        {
            static /*0x177e9f0*/ object GetFormatter(System.Type t);
        }

        class StandardResolverHelper
        {
            static /*0x0*/ MessagePack.IFormatterResolver[] DefaultResolvers;

            static /*0x178fa68*/ StandardResolverHelper();
        }
    }

    namespace Formatters
    {
        class ArrayFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<T[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            ArrayFormatter();
            void Serialize(ref MessagePack.MessagePackWriter writer, T[] value, MessagePack.MessagePackSerializerOptions options);
            T[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ByteArraySegmentFormatter : MessagePack.Formatters.IMessagePackFormatter<System.ArraySegment<byte>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.ByteArraySegmentFormatter Instance;

            static /*0x1522f54*/ ByteArraySegmentFormatter();
            /*0x1522db4*/ ByteArraySegmentFormatter();
            /*0x1522dbc*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.ArraySegment<byte> value, MessagePack.MessagePackSerializerOptions options);
            /*0x1522e78*/ System.ArraySegment<byte> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ArraySegmentFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<System.ArraySegment<T>>, MessagePack.Formatters.IMessagePackFormatter
        {
            ArraySegmentFormatter();
            void Serialize(ref MessagePack.MessagePackWriter writer, System.ArraySegment<T> value, MessagePack.MessagePackSerializerOptions options);
            System.ArraySegment<T> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ListFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<System.Collections.Generic.List<T>>, MessagePack.Formatters.IMessagePackFormatter
        {
            ListFormatter();
            void Serialize(ref MessagePack.MessagePackWriter writer, System.Collections.Generic.List<T> value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.List<T> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class CollectionFormatterBase<TElement, TIntermediate, TEnumerator, TCollection> : MessagePack.Formatters.IMessagePackFormatter<TCollection>, MessagePack.Formatters.IMessagePackFormatter
        {
            CollectionFormatterBase();
            void Serialize(ref MessagePack.MessagePackWriter writer, TCollection value, MessagePack.MessagePackSerializerOptions options);
            TCollection Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
            System.Nullable<int> GetCount(TCollection sequence);
            TEnumerator GetSourceEnumerator(TCollection source);
            TIntermediate Create(int count, MessagePack.MessagePackSerializerOptions options);
            void Add(TIntermediate collection, int index, TElement value, MessagePack.MessagePackSerializerOptions options);
            TCollection Complete(TIntermediate intermediateCollection);
        }

        class CollectionFormatterBase<TElement, TIntermediate, TCollection> : MessagePack.Formatters.CollectionFormatterBase<TElement, TIntermediate, System.Collections.Generic.IEnumerator<TElement>, TCollection>
        {
            CollectionFormatterBase();
            System.Collections.Generic.IEnumerator<TElement> GetSourceEnumerator(TCollection source);
        }

        class CollectionFormatterBase<TElement, TCollection> : MessagePack.Formatters.CollectionFormatterBase<TElement, TCollection, TCollection>
        {
            CollectionFormatterBase();
            TCollection Complete(TCollection intermediateCollection);
        }

        class GenericCollectionFormatter<TElement, TCollection> : MessagePack.Formatters.CollectionFormatterBase<TElement, TCollection>
        {
            GenericCollectionFormatter();
            TCollection Create(int count, MessagePack.MessagePackSerializerOptions options);
            void Add(TCollection collection, int index, TElement value, MessagePack.MessagePackSerializerOptions options);
        }

        class LinkedListFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.Generic.LinkedList<T>, System.Collections.Generic.LinkedList.Enumerator<T>, System.Collections.Generic.LinkedList<T>>
        {
            LinkedListFormatter();
            void Add(System.Collections.Generic.LinkedList<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.LinkedList<T> Complete(System.Collections.Generic.LinkedList<T> intermediateCollection);
            System.Collections.Generic.LinkedList<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.LinkedList.Enumerator<T> GetSourceEnumerator(System.Collections.Generic.LinkedList<T> source);
        }

        class QueueFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.Generic.Queue<T>, System.Collections.Generic.Queue.Enumerator<T>, System.Collections.Generic.Queue<T>>
        {
            QueueFormatter();
            System.Nullable<int> GetCount(System.Collections.Generic.Queue<T> sequence);
            void Add(System.Collections.Generic.Queue<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.Queue<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.Queue.Enumerator<T> GetSourceEnumerator(System.Collections.Generic.Queue<T> source);
            System.Collections.Generic.Queue<T> Complete(System.Collections.Generic.Queue<T> intermediateCollection);
        }

        class StackFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, T[], System.Collections.Generic.Stack.Enumerator<T>, System.Collections.Generic.Stack<T>>
        {
            StackFormatter();
            System.Nullable<int> GetCount(System.Collections.Generic.Stack<T> sequence);
            void Add(T[] collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            T[] Create(int count, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.Stack.Enumerator<T> GetSourceEnumerator(System.Collections.Generic.Stack<T> source);
            System.Collections.Generic.Stack<T> Complete(T[] intermediateCollection);
        }

        class HashSetFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.Generic.HashSet<T>, System.Collections.Generic.HashSet.Enumerator<T>, System.Collections.Generic.HashSet<T>>
        {
            HashSetFormatter();
            System.Nullable<int> GetCount(System.Collections.Generic.HashSet<T> sequence);
            void Add(System.Collections.Generic.HashSet<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.HashSet<T> Complete(System.Collections.Generic.HashSet<T> intermediateCollection);
            System.Collections.Generic.HashSet<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.HashSet.Enumerator<T> GetSourceEnumerator(System.Collections.Generic.HashSet<T> source);
        }

        class ReadOnlyCollectionFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, T[], System.Collections.ObjectModel.ReadOnlyCollection<T>>
        {
            ReadOnlyCollectionFormatter();
            void Add(T[] collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.ObjectModel.ReadOnlyCollection<T> Complete(T[] intermediateCollection);
            T[] Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class InterfaceListFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, T[], System.Collections.Generic.IList<T>>
        {
            InterfaceListFormatter();
            void Add(T[] collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            T[] Create(int count, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.IList<T> Complete(T[] intermediateCollection);
        }

        class InterfaceCollectionFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, T[], System.Collections.Generic.ICollection<T>>
        {
            InterfaceCollectionFormatter();
            void Add(T[] collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            T[] Create(int count, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.ICollection<T> Complete(T[] intermediateCollection);
        }

        class InterfaceListFormatter2<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.Generic.List<T>, System.Collections.Generic.IList<T>>
        {
            InterfaceListFormatter2();
            void Add(System.Collections.Generic.List<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.List<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.IList<T> Complete(System.Collections.Generic.List<T> intermediateCollection);
        }

        class InterfaceCollectionFormatter2<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.Generic.List<T>, System.Collections.Generic.ICollection<T>>
        {
            InterfaceCollectionFormatter2();
            void Add(System.Collections.Generic.List<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.List<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.ICollection<T> Complete(System.Collections.Generic.List<T> intermediateCollection);
        }

        class InterfaceEnumerableFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, T[], System.Collections.Generic.IEnumerable<T>>
        {
            InterfaceEnumerableFormatter();
            void Add(T[] collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            T[] Create(int count, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.IEnumerable<T> Complete(T[] intermediateCollection);
        }

        class InterfaceGroupingFormatter<TKey, TElement> : MessagePack.Formatters.IMessagePackFormatter<System.Linq.IGrouping<TKey, TElement>>, MessagePack.Formatters.IMessagePackFormatter
        {
            InterfaceGroupingFormatter();
            void Serialize(ref MessagePack.MessagePackWriter writer, System.Linq.IGrouping<TKey, TElement> value, MessagePack.MessagePackSerializerOptions options);
            System.Linq.IGrouping<TKey, TElement> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class InterfaceLookupFormatter<TKey, TElement> : MessagePack.Formatters.CollectionFormatterBase<System.Linq.IGrouping<TKey, TElement>, System.Collections.Generic.Dictionary<TKey, System.Linq.IGrouping<TKey, TElement>>, System.Linq.ILookup<TKey, TElement>>
        {
            InterfaceLookupFormatter();
            void Add(System.Collections.Generic.Dictionary<TKey, System.Linq.IGrouping<TKey, TElement>> collection, int index, System.Linq.IGrouping<TKey, TElement> value, MessagePack.MessagePackSerializerOptions options);
            System.Linq.ILookup<TKey, TElement> Complete(System.Collections.Generic.Dictionary<TKey, System.Linq.IGrouping<TKey, TElement>> intermediateCollection);
            System.Collections.Generic.Dictionary<TKey, System.Linq.IGrouping<TKey, TElement>> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class Grouping<TKey, TElement> : System.Linq.IGrouping<TKey, TElement>, System.Collections.Generic.IEnumerable<TElement>, System.Collections.IEnumerable
        {
            /*0x0*/ TKey key;
            /*0x0*/ System.Collections.Generic.IEnumerable<TElement> elements;

            Grouping(TKey key, System.Collections.Generic.IEnumerable<TElement> elements);
            TKey get_Key();
            System.Collections.Generic.IEnumerator<TElement> GetEnumerator();
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class Lookup<TKey, TElement> : System.Linq.ILookup<TKey, TElement>, System.Collections.Generic.IEnumerable<System.Linq.IGrouping<TKey, TElement>>, System.Collections.IEnumerable
        {
            /*0x0*/ System.Collections.Generic.Dictionary<TKey, System.Linq.IGrouping<TKey, TElement>> groupings;

            Lookup(System.Collections.Generic.Dictionary<TKey, System.Linq.IGrouping<TKey, TElement>> groupings);
            System.Collections.Generic.IEnumerable<TElement> get_Item(TKey key);
            int get_Count();
            bool Contains(TKey key);
            System.Collections.Generic.IEnumerator<System.Linq.IGrouping<TKey, TElement>> GetEnumerator();
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class NonGenericListFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<T>, MessagePack.Formatters.IMessagePackFormatter
        {
            NonGenericListFormatter();
            void Serialize(ref MessagePack.MessagePackWriter writer, T value, MessagePack.MessagePackSerializerOptions options);
            T Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NonGenericInterfaceListFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Collections.IList>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Collections.IList> Instance;

            static /*0x1780800*/ NonGenericInterfaceListFormatter();
            /*0x17800dc*/ NonGenericInterfaceListFormatter();
            /*0x17800e4*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Collections.IList value, MessagePack.MessagePackSerializerOptions options);
            /*0x1780530*/ System.Collections.IList Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NonGenericDictionaryFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<T>, MessagePack.Formatters.IMessagePackFormatter
        {
            NonGenericDictionaryFormatter();
            void Serialize(ref MessagePack.MessagePackWriter writer, T value, MessagePack.MessagePackSerializerOptions options);
            T Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NonGenericInterfaceDictionaryFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Collections.IDictionary>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Collections.IDictionary> Instance;

            static /*0x178007c*/ NonGenericInterfaceDictionaryFormatter();
            /*0x177f7f8*/ NonGenericInterfaceDictionaryFormatter();
            /*0x177f800*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Collections.IDictionary value, MessagePack.MessagePackSerializerOptions options);
            /*0x177fd08*/ System.Collections.IDictionary Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ObservableCollectionFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.ObjectModel.ObservableCollection<T>>
        {
            ObservableCollectionFormatter();
            void Add(System.Collections.ObjectModel.ObservableCollection<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.ObjectModel.ObservableCollection<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class ReadOnlyObservableCollectionFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.ObjectModel.ObservableCollection<T>, System.Collections.ObjectModel.ReadOnlyObservableCollection<T>>
        {
            ReadOnlyObservableCollectionFormatter();
            void Add(System.Collections.ObjectModel.ObservableCollection<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.ObjectModel.ObservableCollection<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
            System.Collections.ObjectModel.ReadOnlyObservableCollection<T> Complete(System.Collections.ObjectModel.ObservableCollection<T> intermediateCollection);
        }

        class InterfaceReadOnlyListFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, T[], System.Collections.Generic.IReadOnlyList<T>>
        {
            InterfaceReadOnlyListFormatter();
            void Add(T[] collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            T[] Create(int count, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.IReadOnlyList<T> Complete(T[] intermediateCollection);
        }

        class InterfaceReadOnlyCollectionFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, T[], System.Collections.Generic.IReadOnlyCollection<T>>
        {
            InterfaceReadOnlyCollectionFormatter();
            void Add(T[] collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            T[] Create(int count, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.IReadOnlyCollection<T> Complete(T[] intermediateCollection);
        }

        class InterfaceSetFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.Generic.HashSet<T>, System.Collections.Generic.ISet<T>>
        {
            InterfaceSetFormatter();
            void Add(System.Collections.Generic.HashSet<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.ISet<T> Complete(System.Collections.Generic.HashSet<T> intermediateCollection);
            System.Collections.Generic.HashSet<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class ConcurrentBagFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.Concurrent.ConcurrentBag<T>>
        {
            ConcurrentBagFormatter();
            System.Nullable<int> GetCount(System.Collections.Concurrent.ConcurrentBag<T> sequence);
            void Add(System.Collections.Concurrent.ConcurrentBag<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Concurrent.ConcurrentBag<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class ConcurrentQueueFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, System.Collections.Concurrent.ConcurrentQueue<T>>
        {
            ConcurrentQueueFormatter();
            System.Nullable<int> GetCount(System.Collections.Concurrent.ConcurrentQueue<T> sequence);
            void Add(System.Collections.Concurrent.ConcurrentQueue<T> collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Concurrent.ConcurrentQueue<T> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class ConcurrentStackFormatter<T> : MessagePack.Formatters.CollectionFormatterBase<T, T[], System.Collections.Concurrent.ConcurrentStack<T>>
        {
            ConcurrentStackFormatter();
            System.Nullable<int> GetCount(System.Collections.Concurrent.ConcurrentStack<T> sequence);
            void Add(T[] collection, int index, T value, MessagePack.MessagePackSerializerOptions options);
            T[] Create(int count, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Concurrent.ConcurrentStack<T> Complete(T[] intermediateCollection);
        }

        class CollectionHelpers<TCollection, TEqualityComparer>
        {
            static /*0x0*/ System.Func<int, TEqualityComparer, TCollection> collectionCreator;

            static CollectionHelpers();
            static TCollection CreateHashCollection(int count, TEqualityComparer equalityComparer);
        }

        class NativeDateTimeFormatter : MessagePack.Formatters.IMessagePackFormatter<System.DateTime>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NativeDateTimeFormatter Instance;

            static /*0x177e8e0*/ NativeDateTimeFormatter();
            /*0x177e8d8*/ NativeDateTimeFormatter();
            /*0x177e828*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.DateTime value, MessagePack.MessagePackSerializerOptions options);
            /*0x177e860*/ System.DateTime Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NativeDateTimeArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.DateTime[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NativeDateTimeArrayFormatter Instance;

            static /*0x177e7c8*/ NativeDateTimeArrayFormatter();
            /*0x177e7c0*/ NativeDateTimeArrayFormatter();
            /*0x177e5bc*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.DateTime[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x177e660*/ System.DateTime[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class DictionaryFormatterBase<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : MessagePack.Formatters.IMessagePackFormatter<TDictionary>, MessagePack.Formatters.IMessagePackFormatter
        {
            DictionaryFormatterBase();
            void Serialize(ref MessagePack.MessagePackWriter writer, TDictionary value, MessagePack.MessagePackSerializerOptions options);
            TDictionary Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
            TEnumerator GetSourceEnumerator(TDictionary source);
            TIntermediate Create(int count, MessagePack.MessagePackSerializerOptions options);
            void Add(TIntermediate collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            TDictionary Complete(TIntermediate intermediateCollection);
        }

        class DictionaryFormatterBase<TKey, TValue, TIntermediate, TDictionary> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, TIntermediate, System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>>, TDictionary>
        {
            DictionaryFormatterBase();
            System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetSourceEnumerator(TDictionary source);
        }

        class DictionaryFormatterBase<TKey, TValue, TDictionary> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, TDictionary, TDictionary>
        {
            DictionaryFormatterBase();
            TDictionary Complete(TDictionary intermediateCollection);
        }

        class DictionaryFormatter<TKey, TValue> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, System.Collections.Generic.Dictionary<TKey, TValue>, System.Collections.Generic.Dictionary.Enumerator<TKey, TValue>, System.Collections.Generic.Dictionary<TKey, TValue>>
        {
            DictionaryFormatter();
            void Add(System.Collections.Generic.Dictionary<TKey, TValue> collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.Dictionary<TKey, TValue> Complete(System.Collections.Generic.Dictionary<TKey, TValue> intermediateCollection);
            System.Collections.Generic.Dictionary<TKey, TValue> Create(int count, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.Dictionary.Enumerator<TKey, TValue> GetSourceEnumerator(System.Collections.Generic.Dictionary<TKey, TValue> source);
        }

        class GenericDictionaryFormatter<TKey, TValue, TDictionary> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, TDictionary>
        {
            GenericDictionaryFormatter();
            void Add(TDictionary collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            TDictionary Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class InterfaceDictionaryFormatter<TKey, TValue> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, System.Collections.Generic.Dictionary<TKey, TValue>, System.Collections.Generic.IDictionary<TKey, TValue>>
        {
            InterfaceDictionaryFormatter();
            void Add(System.Collections.Generic.Dictionary<TKey, TValue> collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.Dictionary<TKey, TValue> Create(int count, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.IDictionary<TKey, TValue> Complete(System.Collections.Generic.Dictionary<TKey, TValue> intermediateCollection);
        }

        class SortedListFormatter<TKey, TValue> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, System.Collections.Generic.SortedList<TKey, TValue>>
        {
            SortedListFormatter();
            void Add(System.Collections.Generic.SortedList<TKey, TValue> collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.SortedList<TKey, TValue> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class SortedDictionaryFormatter<TKey, TValue> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, System.Collections.Generic.SortedDictionary<TKey, TValue>, System.Collections.Generic.SortedDictionary.Enumerator<TKey, TValue>, System.Collections.Generic.SortedDictionary<TKey, TValue>>
        {
            SortedDictionaryFormatter();
            void Add(System.Collections.Generic.SortedDictionary<TKey, TValue> collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.SortedDictionary<TKey, TValue> Complete(System.Collections.Generic.SortedDictionary<TKey, TValue> intermediateCollection);
            System.Collections.Generic.SortedDictionary<TKey, TValue> Create(int count, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.SortedDictionary.Enumerator<TKey, TValue> GetSourceEnumerator(System.Collections.Generic.SortedDictionary<TKey, TValue> source);
        }

        class ReadOnlyDictionaryFormatter<TKey, TValue> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, System.Collections.Generic.Dictionary<TKey, TValue>, System.Collections.ObjectModel.ReadOnlyDictionary<TKey, TValue>>
        {
            ReadOnlyDictionaryFormatter();
            void Add(System.Collections.Generic.Dictionary<TKey, TValue> collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.ObjectModel.ReadOnlyDictionary<TKey, TValue> Complete(System.Collections.Generic.Dictionary<TKey, TValue> intermediateCollection);
            System.Collections.Generic.Dictionary<TKey, TValue> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class InterfaceReadOnlyDictionaryFormatter<TKey, TValue> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, System.Collections.Generic.Dictionary<TKey, TValue>, System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>>
        {
            InterfaceReadOnlyDictionaryFormatter();
            void Add(System.Collections.Generic.Dictionary<TKey, TValue> collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.IReadOnlyDictionary<TKey, TValue> Complete(System.Collections.Generic.Dictionary<TKey, TValue> intermediateCollection);
            System.Collections.Generic.Dictionary<TKey, TValue> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class ConcurrentDictionaryFormatter<TKey, TValue> : MessagePack.Formatters.DictionaryFormatterBase<TKey, TValue, System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue>>
        {
            ConcurrentDictionaryFormatter();
            void Add(System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue> collection, int index, TKey key, TValue value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue> Create(int count, MessagePack.MessagePackSerializerOptions options);
        }

        class DynamicObjectTypeFallbackFormatter : MessagePack.Formatters.IMessagePackFormatter<object>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<object> Instance;
            static /*0x8*/ MessagePack.Internal.ThreadsafeTypeKeyHashTable<MessagePack.Formatters.DynamicObjectTypeFallbackFormatter.SerializeMethod> SerializerDelegates;

            static /*0x1535c04*/ DynamicObjectTypeFallbackFormatter();
            /*0x1535164*/ DynamicObjectTypeFallbackFormatter();
            /*0x153516c*/ void Serialize(ref MessagePack.MessagePackWriter writer, object value, MessagePack.MessagePackSerializerOptions options);
            /*0x1535b0c*/ object Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);

            class SerializeMethod : System.MulticastDelegate
            {
                /*0x184f6c4*/ SerializeMethod(object object, nint method);
                /*0x184f724*/ void Invoke(object dynamicFormatter, ref MessagePack.MessagePackWriter writer, object value, MessagePack.MessagePackSerializerOptions options);
                /*0x184fafc*/ System.IAsyncResult BeginInvoke(object dynamicFormatter, ref MessagePack.MessagePackWriter writer, object value, MessagePack.MessagePackSerializerOptions options, System.AsyncCallback callback, object object);
                /*0x184fba8*/ void EndInvoke(ref MessagePack.MessagePackWriter writer, System.IAsyncResult result);
            }
        }

        class EnumAsStringFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<T>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x0*/ System.Collections.Generic.IReadOnlyDictionary<string, T> nameValueMapping;
            /*0x0*/ System.Collections.Generic.IReadOnlyDictionary<T, string> valueNameMapping;
            /*0x0*/ System.Collections.Generic.IReadOnlyDictionary<string, string> clrToSerializationName;
            /*0x0*/ System.Collections.Generic.IReadOnlyDictionary<string, string> serializationToClrName;
            /*0x0*/ bool enumMemberOverridesPresent;
            /*0x0*/ bool isFlags;

            static string Translate(string items, System.Collections.Generic.IReadOnlyDictionary<string, string> mapping);
            EnumAsStringFormatter();
            void Serialize(ref MessagePack.MessagePackWriter writer, T value, MessagePack.MessagePackSerializerOptions options);
            T Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
            string GetClrNames(string serializedNames);
            string GetSerializedNames(string clrNames);
        }

        class GenericEnumFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<T>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x0*/ MessagePack.Formatters.GenericEnumFormatter.EnumSerialize<T> serializer;
            /*0x0*/ MessagePack.Formatters.GenericEnumFormatter.EnumDeserialize<T> deserializer;

            GenericEnumFormatter();
            void Serialize(ref MessagePack.MessagePackWriter writer, T value, MessagePack.MessagePackSerializerOptions options);
            T Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);

            class EnumSerialize<T> : System.MulticastDelegate
            {
                EnumSerialize(object object, nint method);
                void Invoke(ref MessagePack.MessagePackWriter writer, ref T value);
                System.IAsyncResult BeginInvoke(ref MessagePack.MessagePackWriter writer, ref T value, System.AsyncCallback callback, object object);
                void EndInvoke(ref MessagePack.MessagePackWriter writer, ref T value, System.IAsyncResult result);
            }

            class EnumDeserialize<T> : System.MulticastDelegate
            {
                EnumDeserialize(object object, nint method);
                T Invoke(ref MessagePack.MessagePackReader reader);
                System.IAsyncResult BeginInvoke(ref MessagePack.MessagePackReader reader, System.AsyncCallback callback, object object);
                T EndInvoke(ref MessagePack.MessagePackReader reader, System.IAsyncResult result);
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

                static <>c();
                <>c();
                void <.ctor>b__4_0(ref MessagePack.MessagePackWriter writer, ref T value);
                T <.ctor>b__4_1(ref MessagePack.MessagePackReader reader);
                void <.ctor>b__4_2(ref MessagePack.MessagePackWriter writer, ref T value);
                T <.ctor>b__4_3(ref MessagePack.MessagePackReader reader);
                void <.ctor>b__4_4(ref MessagePack.MessagePackWriter writer, ref T value);
                T <.ctor>b__4_5(ref MessagePack.MessagePackReader reader);
                void <.ctor>b__4_6(ref MessagePack.MessagePackWriter writer, ref T value);
                T <.ctor>b__4_7(ref MessagePack.MessagePackReader reader);
                void <.ctor>b__4_8(ref MessagePack.MessagePackWriter writer, ref T value);
                T <.ctor>b__4_9(ref MessagePack.MessagePackReader reader);
                void <.ctor>b__4_10(ref MessagePack.MessagePackWriter writer, ref T value);
                T <.ctor>b__4_11(ref MessagePack.MessagePackReader reader);
                void <.ctor>b__4_12(ref MessagePack.MessagePackWriter writer, ref T value);
                T <.ctor>b__4_13(ref MessagePack.MessagePackReader reader);
                void <.ctor>b__4_14(ref MessagePack.MessagePackWriter writer, ref T value);
                T <.ctor>b__4_15(ref MessagePack.MessagePackReader reader);
            }
        }

        interface IMessagePackFormatter
        {
        }

        interface IMessagePackFormatter<T> : MessagePack.Formatters.IMessagePackFormatter
        {
            void Serialize(ref MessagePack.MessagePackWriter writer, T value, MessagePack.MessagePackSerializerOptions options);
            T Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class IgnoreFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<T>, MessagePack.Formatters.IMessagePackFormatter
        {
            IgnoreFormatter();
            void Serialize(ref MessagePack.MessagePackWriter writer, T value, MessagePack.MessagePackSerializerOptions options);
            T Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class TwoDimensionalArrayFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<T[, ]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static int ArrayLength = 3;

            TwoDimensionalArrayFormatter();
            void Serialize(ref MessagePack.MessagePackWriter writer, T[,] value, MessagePack.MessagePackSerializerOptions options);
            T[,] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ThreeDimensionalArrayFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<T[, , ]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static int ArrayLength = 4;

            ThreeDimensionalArrayFormatter();
            void Serialize(ref MessagePack.MessagePackWriter writer, T[,,] value, MessagePack.MessagePackSerializerOptions options);
            T[,,] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class FourDimensionalArrayFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<T[, , , ]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static int ArrayLength = 5;

            FourDimensionalArrayFormatter();
            void Serialize(ref MessagePack.MessagePackWriter writer, T[,,,] value, MessagePack.MessagePackSerializerOptions options);
            T[,,,] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NilFormatter : MessagePack.Formatters.IMessagePackFormatter<MessagePack.Nil>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<MessagePack.Nil> Instance;

            static /*0x177f798*/ NilFormatter();
            /*0x177f768*/ NilFormatter();
            /*0x177f770*/ void Serialize(ref MessagePack.MessagePackWriter writer, MessagePack.Nil value, MessagePack.MessagePackSerializerOptions options);
            /*0x177f778*/ MessagePack.Nil Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableNilFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<MessagePack.Nil>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Nullable<MessagePack.Nil>> Instance;

            static /*0x1782bb4*/ NullableNilFormatter();
            /*0x1782b34*/ NullableNilFormatter();
            /*0x1782b3c*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<MessagePack.Nil> value, MessagePack.MessagePackSerializerOptions options);
            /*0x1782b44*/ System.Nullable<MessagePack.Nil> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<T>>, MessagePack.Formatters.IMessagePackFormatter
        {
            NullableFormatter();
            void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<T> value, MessagePack.MessagePackSerializerOptions options);
            System.Nullable<T> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class StaticNullableFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<T>>, MessagePack.Formatters.IMessagePackFormatter
        {
            /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> underlyingFormatter;

            StaticNullableFormatter(MessagePack.Formatters.IMessagePackFormatter<T> underlyingFormatter);
            void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<T> value, MessagePack.MessagePackSerializerOptions options);
            System.Nullable<T> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class PrimitiveObjectFormatter : MessagePack.Formatters.IMessagePackFormatter<object>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<object> Instance;
            static /*0x8*/ System.Collections.Generic.Dictionary<System.Type, int> TypeToJumpCode;

            static /*0x178b864*/ PrimitiveObjectFormatter();
            /*0x178945c*/ PrimitiveObjectFormatter();
            /*0x1789464*/ void Serialize(ref MessagePack.MessagePackWriter writer, object value, MessagePack.MessagePackSerializerOptions options);
            /*0x178ad78*/ object Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ByteArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Byte[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.ByteArrayFormatter Instance;

            static /*0x1522d54*/ ByteArrayFormatter();
            /*0x1522c80*/ ByteArrayFormatter();
            /*0x1522c88*/ void Serialize(ref MessagePack.MessagePackWriter writer, byte[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x1522c98*/ byte[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableStringFormatter : MessagePack.Formatters.IMessagePackFormatter<string>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableStringFormatter Instance;

            static /*0x1785168*/ NullableStringFormatter();
            /*0x17841d8*/ NullableStringFormatter();
            /*0x17841e0*/ void Serialize(ref MessagePack.MessagePackWriter writer, string value, MessagePack.MessagePackSerializerOptions options);
            /*0x1784ef0*/ string Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableStringArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.String[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableStringArrayFormatter Instance;

            static /*0x1784178*/ NullableStringArrayFormatter();
            /*0x1782fa0*/ NullableStringArrayFormatter();
            /*0x1782fa8*/ void Serialize(ref MessagePack.MessagePackWriter writer, string[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x1783ddc*/ string[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class DecimalFormatter : MessagePack.Formatters.IMessagePackFormatter<decimal>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.DecimalFormatter Instance;

            static /*0x152a620*/ DecimalFormatter();
            /*0x1528f44*/ DecimalFormatter();
            /*0x1528f4c*/ void Serialize(ref MessagePack.MessagePackWriter writer, decimal value, MessagePack.MessagePackSerializerOptions options);
            /*0x1529e20*/ decimal Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class TimeSpanFormatter : MessagePack.Formatters.IMessagePackFormatter<System.TimeSpan>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.TimeSpan> Instance;

            static /*0x1791e40*/ TimeSpanFormatter();
            /*0x1791e20*/ TimeSpanFormatter();
            /*0x1791e28*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.TimeSpan value, MessagePack.MessagePackSerializerOptions options);
            /*0x1791e34*/ System.TimeSpan Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class DateTimeOffsetFormatter : MessagePack.Formatters.IMessagePackFormatter<System.DateTimeOffset>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.DateTimeOffset> Instance;

            static /*0x1528ee4*/ DateTimeOffsetFormatter();
            /*0x1528d0c*/ DateTimeOffsetFormatter();
            /*0x1528d14*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.DateTimeOffset value, MessagePack.MessagePackSerializerOptions options);
            /*0x1528dc0*/ System.DateTimeOffset Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class GuidFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Guid>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Guid> Instance;

            static /*0x22ff5f4*/ GuidFormatter();
            /*0x22ff054*/ GuidFormatter();
            /*0x22ff05c*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Guid value, MessagePack.MessagePackSerializerOptions options);
            /*0x22ff15c*/ System.Guid Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class UriFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Uri>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Uri> Instance;

            static /*0x184712c*/ UriFormatter();
            /*0x1846098*/ UriFormatter();
            /*0x18460a0*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Uri value, MessagePack.MessagePackSerializerOptions options);
            /*0x1846e18*/ System.Uri Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class VersionFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Version>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Version> Instance;

            static /*0x1848bc0*/ VersionFormatter();
            /*0x1847b30*/ VersionFormatter();
            /*0x1847b38*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Version value, MessagePack.MessagePackSerializerOptions options);
            /*0x18488b0*/ System.Version Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class KeyValuePairFormatter<TKey, TValue> : MessagePack.Formatters.IMessagePackFormatter<System.Collections.Generic.KeyValuePair<TKey, TValue>>, MessagePack.Formatters.IMessagePackFormatter
        {
            KeyValuePairFormatter();
            void Serialize(ref MessagePack.MessagePackWriter writer, System.Collections.Generic.KeyValuePair<TKey, TValue> value, MessagePack.MessagePackSerializerOptions options);
            System.Collections.Generic.KeyValuePair<TKey, TValue> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class StringBuilderFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Text.StringBuilder>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Text.StringBuilder> Instance;

            static /*0x1791c90*/ StringBuilderFormatter();
            /*0x1790c58*/ StringBuilderFormatter();
            /*0x1790c60*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Text.StringBuilder value, MessagePack.MessagePackSerializerOptions options);
            /*0x1791984*/ System.Text.StringBuilder Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class BitArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Collections.BitArray>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Collections.BitArray> Instance;

            static /*0x151ea34*/ BitArrayFormatter();
            /*0x151e888*/ BitArrayFormatter();
            /*0x151e890*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Collections.BitArray value, MessagePack.MessagePackSerializerOptions options);
            /*0x151e920*/ System.Collections.BitArray Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class BigIntegerFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Numerics.BigInteger>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Numerics.BigInteger> Instance;

            static /*0x151e828*/ BigIntegerFormatter();
            /*0x151e708*/ BigIntegerFormatter();
            /*0x151e710*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Numerics.BigInteger value, MessagePack.MessagePackSerializerOptions options);
            /*0x151e754*/ System.Numerics.BigInteger Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ComplexFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Numerics.Complex>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Numerics.Complex> Instance;

            static /*0x15282d8*/ ComplexFormatter();
            /*0x15281b8*/ ComplexFormatter();
            /*0x15281c0*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Numerics.Complex value, MessagePack.MessagePackSerializerOptions options);
            /*0x1528218*/ System.Numerics.Complex Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class LazyFormatter<T> : MessagePack.Formatters.IMessagePackFormatter<System.Lazy<T>>, MessagePack.Formatters.IMessagePackFormatter
        {
            LazyFormatter();
            void Serialize(ref MessagePack.MessagePackWriter writer, System.Lazy<T> value, MessagePack.MessagePackSerializerOptions options);
            System.Lazy<T> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);

            class <>c__DisplayClass1_0<T>
            {
                /*0x0*/ T v;

                <>c__DisplayClass1_0();
                T <Deserialize>b__0();
            }
        }

        class NativeGuidFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Guid>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<System.Guid> Instance;

            static /*0x177f44c*/ NativeGuidFormatter();
            /*0x177f154*/ NativeGuidFormatter();
            /*0x177f15c*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Guid value, MessagePack.MessagePackSerializerOptions options);
            /*0x177f268*/ System.Guid Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NativeDecimalFormatter : MessagePack.Formatters.IMessagePackFormatter<decimal>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<decimal> Instance;

            static /*0x177eef0*/ NativeDecimalFormatter();
            /*0x177ebf8*/ NativeDecimalFormatter();
            /*0x177ec00*/ void Serialize(ref MessagePack.MessagePackWriter writer, decimal value, MessagePack.MessagePackSerializerOptions options);
            /*0x177ed0c*/ decimal Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ForceInt16BlockFormatter : MessagePack.Formatters.IMessagePackFormatter<short>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.ForceInt16BlockFormatter Instance;

            static /*0x153bb4c*/ ForceInt16BlockFormatter();
            /*0x153bb28*/ ForceInt16BlockFormatter();
            /*0x153bb30*/ void Serialize(ref MessagePack.MessagePackWriter writer, short value, MessagePack.MessagePackSerializerOptions options);
            /*0x153bb40*/ short Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableForceInt16BlockFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<short>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableForceInt16BlockFormatter Instance;

            static /*0x178148c*/ NullableForceInt16BlockFormatter();
            /*0x1781324*/ NullableForceInt16BlockFormatter();
            /*0x178132c*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<short> value, MessagePack.MessagePackSerializerOptions options);
            /*0x17813c0*/ System.Nullable<short> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ForceInt16BlockArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Int16[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.ForceInt16BlockArrayFormatter Instance;

            static /*0x153bac8*/ ForceInt16BlockArrayFormatter();
            /*0x153b878*/ ForceInt16BlockArrayFormatter();
            /*0x153b880*/ void Serialize(ref MessagePack.MessagePackWriter writer, short[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x153b920*/ short[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ForceInt32BlockFormatter : MessagePack.Formatters.IMessagePackFormatter<int>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.ForceInt32BlockFormatter Instance;

            static /*0x153be80*/ ForceInt32BlockFormatter();
            /*0x153be5c*/ ForceInt32BlockFormatter();
            /*0x153be64*/ void Serialize(ref MessagePack.MessagePackWriter writer, int value, MessagePack.MessagePackSerializerOptions options);
            /*0x153be74*/ int Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableForceInt32BlockFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<int>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableForceInt32BlockFormatter Instance;

            static /*0x1781654*/ NullableForceInt32BlockFormatter();
            /*0x17814ec*/ NullableForceInt32BlockFormatter();
            /*0x17814f4*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<int> value, MessagePack.MessagePackSerializerOptions options);
            /*0x1781588*/ System.Nullable<int> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ForceInt32BlockArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Int32[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.ForceInt32BlockArrayFormatter Instance;

            static /*0x153bdfc*/ ForceInt32BlockArrayFormatter();
            /*0x153bbac*/ ForceInt32BlockArrayFormatter();
            /*0x153bbb4*/ void Serialize(ref MessagePack.MessagePackWriter writer, int[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x153bc54*/ int[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ForceInt64BlockFormatter : MessagePack.Formatters.IMessagePackFormatter<long>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.ForceInt64BlockFormatter Instance;

            static /*0x153c1b4*/ ForceInt64BlockFormatter();
            /*0x153c190*/ ForceInt64BlockFormatter();
            /*0x153c198*/ void Serialize(ref MessagePack.MessagePackWriter writer, long value, MessagePack.MessagePackSerializerOptions options);
            /*0x153c1a8*/ long Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableForceInt64BlockFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<long>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableForceInt64BlockFormatter Instance;

            static /*0x1781824*/ NullableForceInt64BlockFormatter();
            /*0x17816b4*/ NullableForceInt64BlockFormatter();
            /*0x17816bc*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<long> value, MessagePack.MessagePackSerializerOptions options);
            /*0x178175c*/ System.Nullable<long> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ForceInt64BlockArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Int64[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.ForceInt64BlockArrayFormatter Instance;

            static /*0x153c130*/ ForceInt64BlockArrayFormatter();
            /*0x153bee0*/ ForceInt64BlockArrayFormatter();
            /*0x153bee8*/ void Serialize(ref MessagePack.MessagePackWriter writer, long[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x153bf88*/ long[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ForceUInt16BlockFormatter : MessagePack.Formatters.IMessagePackFormatter<ushort>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.ForceUInt16BlockFormatter Instance;

            static /*0x22fb07c*/ ForceUInt16BlockFormatter();
            /*0x22fb05c*/ ForceUInt16BlockFormatter();
            /*0x22fb064*/ void Serialize(ref MessagePack.MessagePackWriter writer, ushort value, MessagePack.MessagePackSerializerOptions options);
            /*0x22fb074*/ ushort Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableForceUInt16BlockFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<ushort>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableForceUInt16BlockFormatter Instance;

            static /*0x1781bb8*/ NullableForceUInt16BlockFormatter();
            /*0x1781a50*/ NullableForceUInt16BlockFormatter();
            /*0x1781a58*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<ushort> value, MessagePack.MessagePackSerializerOptions options);
            /*0x1781aec*/ System.Nullable<ushort> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ForceUInt16BlockArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.UInt16[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.ForceUInt16BlockArrayFormatter Instance;

            static /*0x22faffc*/ ForceUInt16BlockArrayFormatter();
            /*0x22fabd4*/ ForceUInt16BlockArrayFormatter();
            /*0x22fabdc*/ void Serialize(ref MessagePack.MessagePackWriter writer, ushort[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x22fac7c*/ ushort[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ForceUInt32BlockFormatter : MessagePack.Formatters.IMessagePackFormatter<uint>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.ForceUInt32BlockFormatter Instance;

            static /*0x22fb578*/ ForceUInt32BlockFormatter();
            /*0x22fb558*/ ForceUInt32BlockFormatter();
            /*0x22fb560*/ void Serialize(ref MessagePack.MessagePackWriter writer, uint value, MessagePack.MessagePackSerializerOptions options);
            /*0x22fb570*/ uint Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableForceUInt32BlockFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<uint>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableForceUInt32BlockFormatter Instance;

            static /*0x1781d80*/ NullableForceUInt32BlockFormatter();
            /*0x1781c18*/ NullableForceUInt32BlockFormatter();
            /*0x1781c20*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<uint> value, MessagePack.MessagePackSerializerOptions options);
            /*0x1781cb4*/ System.Nullable<uint> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ForceUInt32BlockArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.UInt32[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.ForceUInt32BlockArrayFormatter Instance;

            static /*0x22fb4f8*/ ForceUInt32BlockArrayFormatter();
            /*0x22fb0dc*/ ForceUInt32BlockArrayFormatter();
            /*0x22fb0e4*/ void Serialize(ref MessagePack.MessagePackWriter writer, uint[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x22fb184*/ uint[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ForceUInt64BlockFormatter : MessagePack.Formatters.IMessagePackFormatter<ulong>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.ForceUInt64BlockFormatter Instance;

            static /*0x22fba50*/ ForceUInt64BlockFormatter();
            /*0x22fba30*/ ForceUInt64BlockFormatter();
            /*0x22fba38*/ void Serialize(ref MessagePack.MessagePackWriter writer, ulong value, MessagePack.MessagePackSerializerOptions options);
            /*0x22fba48*/ ulong Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableForceUInt64BlockFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<ulong>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableForceUInt64BlockFormatter Instance;

            static /*0x1781f50*/ NullableForceUInt64BlockFormatter();
            /*0x1781de0*/ NullableForceUInt64BlockFormatter();
            /*0x1781de8*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<ulong> value, MessagePack.MessagePackSerializerOptions options);
            /*0x1781e88*/ System.Nullable<ulong> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ForceUInt64BlockArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.UInt64[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.ForceUInt64BlockArrayFormatter Instance;

            static /*0x22fb9d0*/ ForceUInt64BlockArrayFormatter();
            /*0x22fb5d8*/ ForceUInt64BlockArrayFormatter();
            /*0x22fb5e0*/ void Serialize(ref MessagePack.MessagePackWriter writer, ulong[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x22fb680*/ ulong[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ForceByteBlockFormatter : MessagePack.Formatters.IMessagePackFormatter<byte>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.ForceByteBlockFormatter Instance;

            static /*0x153b818*/ ForceByteBlockFormatter();
            /*0x153b7f4*/ ForceByteBlockFormatter();
            /*0x153b7fc*/ void Serialize(ref MessagePack.MessagePackWriter writer, byte value, MessagePack.MessagePackSerializerOptions options);
            /*0x153b80c*/ byte Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableForceByteBlockFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<byte>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableForceByteBlockFormatter Instance;

            static /*0x17812c4*/ NullableForceByteBlockFormatter();
            /*0x1781158*/ NullableForceByteBlockFormatter();
            /*0x1781160*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<byte> value, MessagePack.MessagePackSerializerOptions options);
            /*0x17811f8*/ System.Nullable<byte> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ForceSByteBlockFormatter : MessagePack.Formatters.IMessagePackFormatter<sbyte>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.ForceSByteBlockFormatter Instance;

            static /*0x22fab74*/ ForceSByteBlockFormatter();
            /*0x22fab54*/ ForceSByteBlockFormatter();
            /*0x22fab5c*/ void Serialize(ref MessagePack.MessagePackWriter writer, sbyte value, MessagePack.MessagePackSerializerOptions options);
            /*0x22fab6c*/ sbyte Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableForceSByteBlockFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<sbyte>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableForceSByteBlockFormatter Instance;

            static /*0x17819f0*/ NullableForceSByteBlockFormatter();
            /*0x1781884*/ NullableForceSByteBlockFormatter();
            /*0x178188c*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<sbyte> value, MessagePack.MessagePackSerializerOptions options);
            /*0x1781924*/ System.Nullable<sbyte> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ForceSByteBlockArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.SByte[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.ForceSByteBlockArrayFormatter Instance;

            static /*0x22faaf4*/ ForceSByteBlockArrayFormatter();
            /*0x22fa5c4*/ ForceSByteBlockArrayFormatter();
            /*0x22fa5cc*/ void Serialize(ref MessagePack.MessagePackWriter writer, sbyte[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x22fa66c*/ sbyte[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class Int16Formatter : MessagePack.Formatters.IMessagePackFormatter<short>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.Int16Formatter Instance;

            static /*0x23018cc*/ Int16Formatter();
            /*0x23018ac*/ Int16Formatter();
            /*0x23018b4*/ void Serialize(ref MessagePack.MessagePackWriter writer, short value, MessagePack.MessagePackSerializerOptions options);
            /*0x23018c4*/ short Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableInt16Formatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<short>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableInt16Formatter Instance;

            static /*0x1782118*/ NullableInt16Formatter();
            /*0x1781fb0*/ NullableInt16Formatter();
            /*0x1781fb8*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<short> value, MessagePack.MessagePackSerializerOptions options);
            /*0x178204c*/ System.Nullable<short> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class Int16ArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Int16[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.Int16ArrayFormatter Instance;

            static /*0x230184c*/ Int16ArrayFormatter();
            /*0x23014b0*/ Int16ArrayFormatter();
            /*0x23014b8*/ void Serialize(ref MessagePack.MessagePackWriter writer, short[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x2301558*/ short[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class Int32Formatter : MessagePack.Formatters.IMessagePackFormatter<int>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.Int32Formatter Instance;

            static /*0x23028a8*/ Int32Formatter();
            /*0x230223c*/ Int32Formatter();
            /*0x2302244*/ void Serialize(ref MessagePack.MessagePackWriter writer, int value, MessagePack.MessagePackSerializerOptions options);
            /*0x23028a0*/ int Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableInt32Formatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<int>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableInt32Formatter Instance;

            static /*0x1782904*/ NullableInt32Formatter();
            /*0x1782178*/ NullableInt32Formatter();
            /*0x1782180*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<int> value, MessagePack.MessagePackSerializerOptions options);
            /*0x1782838*/ System.Nullable<int> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class Int32ArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Int32[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.Int32ArrayFormatter Instance;

            static /*0x23021dc*/ Int32ArrayFormatter();
            /*0x230192c*/ Int32ArrayFormatter();
            /*0x2301934*/ void Serialize(ref MessagePack.MessagePackWriter writer, int[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x23020d0*/ int[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class Int64Formatter : MessagePack.Formatters.IMessagePackFormatter<long>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.Int64Formatter Instance;

            static /*0x2302d04*/ Int64Formatter();
            /*0x2302ce4*/ Int64Formatter();
            /*0x2302cec*/ void Serialize(ref MessagePack.MessagePackWriter writer, long value, MessagePack.MessagePackSerializerOptions options);
            /*0x2302cfc*/ long Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableInt64Formatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<long>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableInt64Formatter Instance;

            static /*0x1782ad4*/ NullableInt64Formatter();
            /*0x1782964*/ NullableInt64Formatter();
            /*0x178296c*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<long> value, MessagePack.MessagePackSerializerOptions options);
            /*0x1782a0c*/ System.Nullable<long> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class Int64ArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Int64[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.Int64ArrayFormatter Instance;

            static /*0x2302c84*/ Int64ArrayFormatter();
            /*0x2302908*/ Int64ArrayFormatter();
            /*0x2302910*/ void Serialize(ref MessagePack.MessagePackWriter writer, long[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x23029b0*/ long[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class UInt16Formatter : MessagePack.Formatters.IMessagePackFormatter<ushort>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.UInt16Formatter Instance;

            static /*0x1840b7c*/ UInt16Formatter();
            /*0x1840b58*/ UInt16Formatter();
            /*0x1840b60*/ void Serialize(ref MessagePack.MessagePackWriter writer, ushort value, MessagePack.MessagePackSerializerOptions options);
            /*0x1840b70*/ ushort Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableUInt16Formatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<ushort>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableUInt16Formatter Instance;

            static /*0x1785330*/ NullableUInt16Formatter();
            /*0x17851c8*/ NullableUInt16Formatter();
            /*0x17851d0*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<ushort> value, MessagePack.MessagePackSerializerOptions options);
            /*0x1785264*/ System.Nullable<ushort> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class UInt16ArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.UInt16[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.UInt16ArrayFormatter Instance;

            static /*0x1840af8*/ UInt16ArrayFormatter();
            /*0x1840938*/ UInt16ArrayFormatter();
            /*0x1840940*/ void Serialize(ref MessagePack.MessagePackWriter writer, ushort[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x18409e0*/ ushort[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class UInt32Formatter : MessagePack.Formatters.IMessagePackFormatter<uint>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.UInt32Formatter Instance;

            static /*0x18416cc*/ UInt32Formatter();
            /*0x1841248*/ UInt32Formatter();
            /*0x1841250*/ void Serialize(ref MessagePack.MessagePackWriter writer, uint value, MessagePack.MessagePackSerializerOptions options);
            /*0x18416c0*/ uint Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableUInt32Formatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<uint>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableUInt32Formatter Instance;

            static /*0x178593c*/ NullableUInt32Formatter();
            /*0x1785390*/ NullableUInt32Formatter();
            /*0x1785398*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<uint> value, MessagePack.MessagePackSerializerOptions options);
            /*0x1785870*/ System.Nullable<uint> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class UInt32ArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.UInt32[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.UInt32ArrayFormatter Instance;

            static /*0x18411e8*/ UInt32ArrayFormatter();
            /*0x1840bdc*/ UInt32ArrayFormatter();
            /*0x1840be4*/ void Serialize(ref MessagePack.MessagePackWriter writer, uint[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x18410d0*/ uint[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class UInt64Formatter : MessagePack.Formatters.IMessagePackFormatter<ulong>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.UInt64Formatter Instance;

            static /*0x1841970*/ UInt64Formatter();
            /*0x184194c*/ UInt64Formatter();
            /*0x1841954*/ void Serialize(ref MessagePack.MessagePackWriter writer, ulong value, MessagePack.MessagePackSerializerOptions options);
            /*0x1841964*/ ulong Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableUInt64Formatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<ulong>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableUInt64Formatter Instance;

            static /*0x1785b0c*/ NullableUInt64Formatter();
            /*0x178599c*/ NullableUInt64Formatter();
            /*0x17859a4*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<ulong> value, MessagePack.MessagePackSerializerOptions options);
            /*0x1785a44*/ System.Nullable<ulong> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class UInt64ArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.UInt64[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.UInt64ArrayFormatter Instance;

            static /*0x18418ec*/ UInt64ArrayFormatter();
            /*0x184172c*/ UInt64ArrayFormatter();
            /*0x1841734*/ void Serialize(ref MessagePack.MessagePackWriter writer, ulong[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x18417d4*/ ulong[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class SingleFormatter : MessagePack.Formatters.IMessagePackFormatter<float>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.SingleFormatter Instance;

            static /*0x178f760*/ SingleFormatter();
            /*0x178f744*/ SingleFormatter();
            /*0x178f74c*/ void Serialize(ref MessagePack.MessagePackWriter writer, float value, MessagePack.MessagePackSerializerOptions options);
            /*0x178f754*/ float Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableSingleFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<float>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableSingleFormatter Instance;

            static /*0x1782f40*/ NullableSingleFormatter();
            /*0x1782de0*/ NullableSingleFormatter();
            /*0x1782de8*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<float> value, MessagePack.MessagePackSerializerOptions options);
            /*0x1782e78*/ System.Nullable<float> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class SingleArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Single[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.SingleArrayFormatter Instance;

            static /*0x178f6e4*/ SingleArrayFormatter();
            /*0x178f530*/ SingleArrayFormatter();
            /*0x178f538*/ void Serialize(ref MessagePack.MessagePackWriter writer, float[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x178f5cc*/ float[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class DoubleFormatter : MessagePack.Formatters.IMessagePackFormatter<double>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.DoubleFormatter Instance;

            static /*0x152a914*/ DoubleFormatter();
            /*0x152a8f4*/ DoubleFormatter();
            /*0x152a8fc*/ void Serialize(ref MessagePack.MessagePackWriter writer, double value, MessagePack.MessagePackSerializerOptions options);
            /*0x152a908*/ double Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableDoubleFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<double>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableDoubleFormatter Instance;

            static /*0x17810f8*/ NullableDoubleFormatter();
            /*0x1780f90*/ NullableDoubleFormatter();
            /*0x1780f98*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<double> value, MessagePack.MessagePackSerializerOptions options);
            /*0x1781034*/ System.Nullable<double> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class DoubleArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Double[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.DoubleArrayFormatter Instance;

            static /*0x152a894*/ DoubleArrayFormatter();
            /*0x152a6d4*/ DoubleArrayFormatter();
            /*0x152a6dc*/ void Serialize(ref MessagePack.MessagePackWriter writer, double[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x152a77c*/ double[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class BooleanFormatter : MessagePack.Formatters.IMessagePackFormatter<bool>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.BooleanFormatter Instance;

            static /*0x151ecec*/ BooleanFormatter();
            /*0x151ecc4*/ BooleanFormatter();
            /*0x151eccc*/ void Serialize(ref MessagePack.MessagePackWriter writer, bool value, MessagePack.MessagePackSerializerOptions options);
            /*0x151ece0*/ bool Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableBooleanFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<bool>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableBooleanFormatter Instance;

            static /*0x17809cc*/ NullableBooleanFormatter();
            /*0x1780860*/ NullableBooleanFormatter();
            /*0x1780868*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<bool> value, MessagePack.MessagePackSerializerOptions options);
            /*0x1780900*/ System.Nullable<bool> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class BooleanArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Boolean[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.BooleanArrayFormatter Instance;

            static /*0x151ec64*/ BooleanArrayFormatter();
            /*0x151eaa0*/ BooleanArrayFormatter();
            /*0x151eaa8*/ void Serialize(ref MessagePack.MessagePackWriter writer, bool[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x151eb48*/ bool[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ByteFormatter : MessagePack.Formatters.IMessagePackFormatter<byte>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.ByteFormatter Instance;

            static /*0x152750c*/ ByteFormatter();
            /*0x15274e8*/ ByteFormatter();
            /*0x15274f0*/ void Serialize(ref MessagePack.MessagePackWriter writer, byte value, MessagePack.MessagePackSerializerOptions options);
            /*0x1527500*/ byte Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableByteFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<byte>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableByteFormatter Instance;

            static /*0x1780b98*/ NullableByteFormatter();
            /*0x1780a2c*/ NullableByteFormatter();
            /*0x1780a34*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<byte> value, MessagePack.MessagePackSerializerOptions options);
            /*0x1780acc*/ System.Nullable<byte> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class SByteFormatter : MessagePack.Formatters.IMessagePackFormatter<sbyte>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.SByteFormatter Instance;

            static /*0x178e7d4*/ SByteFormatter();
            /*0x178e7b4*/ SByteFormatter();
            /*0x178e7bc*/ void Serialize(ref MessagePack.MessagePackWriter writer, sbyte value, MessagePack.MessagePackSerializerOptions options);
            /*0x178e7c8*/ sbyte Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableSByteFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<sbyte>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableSByteFormatter Instance;

            static /*0x1782d80*/ NullableSByteFormatter();
            /*0x1782c14*/ NullableSByteFormatter();
            /*0x1782c1c*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<sbyte> value, MessagePack.MessagePackSerializerOptions options);
            /*0x1782cb4*/ System.Nullable<sbyte> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class SByteArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.SByte[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.SByteArrayFormatter Instance;

            static /*0x178e754*/ SByteArrayFormatter();
            /*0x178e5a0*/ SByteArrayFormatter();
            /*0x178e5a8*/ void Serialize(ref MessagePack.MessagePackWriter writer, sbyte[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x178e63c*/ sbyte[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class CharFormatter : MessagePack.Formatters.IMessagePackFormatter<char>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.CharFormatter Instance;

            static /*0x1527830*/ CharFormatter();
            /*0x152780c*/ CharFormatter();
            /*0x1527814*/ void Serialize(ref MessagePack.MessagePackWriter writer, char value, MessagePack.MessagePackSerializerOptions options);
            /*0x1527824*/ char Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableCharFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<char>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableCharFormatter Instance;

            static /*0x1780d60*/ NullableCharFormatter();
            /*0x1780bf8*/ NullableCharFormatter();
            /*0x1780c00*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<char> value, MessagePack.MessagePackSerializerOptions options);
            /*0x1780c94*/ System.Nullable<char> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class CharArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Char[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.CharArrayFormatter Instance;

            static /*0x15277ac*/ CharArrayFormatter();
            /*0x15275ec*/ CharArrayFormatter();
            /*0x15275f4*/ void Serialize(ref MessagePack.MessagePackWriter writer, char[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x1527694*/ char[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class DateTimeFormatter : MessagePack.Formatters.IMessagePackFormatter<System.DateTime>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.DateTimeFormatter Instance;

            static /*0x1528cac*/ DateTimeFormatter();
            /*0x1528c88*/ DateTimeFormatter();
            /*0x1528c90*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.DateTime value, MessagePack.MessagePackSerializerOptions options);
            /*0x1528ca0*/ System.DateTime Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class NullableDateTimeFormatter : MessagePack.Formatters.IMessagePackFormatter<System.Nullable<System.DateTime>>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.NullableDateTimeFormatter Instance;

            static /*0x1780f30*/ NullableDateTimeFormatter();
            /*0x1780dc0*/ NullableDateTimeFormatter();
            /*0x1780dc8*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.Nullable<System.DateTime> value, MessagePack.MessagePackSerializerOptions options);
            /*0x1780e68*/ System.Nullable<System.DateTime> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class DateTimeArrayFormatter : MessagePack.Formatters.IMessagePackFormatter<System.DateTime[]>, MessagePack.Formatters.IMessagePackFormatter
        {
            static /*0x0*/ MessagePack.Formatters.DateTimeArrayFormatter Instance;

            static /*0x1528ba4*/ DateTimeArrayFormatter();
            /*0x15289e4*/ DateTimeArrayFormatter();
            /*0x15289ec*/ void Serialize(ref MessagePack.MessagePackWriter writer, System.DateTime[] value, MessagePack.MessagePackSerializerOptions options);
            /*0x1528a8c*/ System.DateTime[] Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class TupleFormatter<T1> : MessagePack.Formatters.IMessagePackFormatter<System.Tuple<T1>>, MessagePack.Formatters.IMessagePackFormatter
        {
            TupleFormatter();
            void Serialize(ref MessagePack.MessagePackWriter writer, System.Tuple<T1> value, MessagePack.MessagePackSerializerOptions options);
            System.Tuple<T1> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class TupleFormatter<T1, T2> : MessagePack.Formatters.IMessagePackFormatter<System.Tuple<T1, T2>>, MessagePack.Formatters.IMessagePackFormatter
        {
            TupleFormatter();
            void Serialize(ref MessagePack.MessagePackWriter writer, System.Tuple<T1, T2> value, MessagePack.MessagePackSerializerOptions options);
            System.Tuple<T1, T2> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class TupleFormatter<T1, T2, T3> : MessagePack.Formatters.IMessagePackFormatter<System.Tuple<T1, T2, T3>>, MessagePack.Formatters.IMessagePackFormatter
        {
            TupleFormatter();
            void Serialize(ref MessagePack.MessagePackWriter writer, System.Tuple<T1, T2, T3> value, MessagePack.MessagePackSerializerOptions options);
            System.Tuple<T1, T2, T3> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class TupleFormatter<T1, T2, T3, T4> : MessagePack.Formatters.IMessagePackFormatter<System.Tuple<T1, T2, T3, T4>>, MessagePack.Formatters.IMessagePackFormatter
        {
            TupleFormatter();
            void Serialize(ref MessagePack.MessagePackWriter writer, System.Tuple<T1, T2, T3, T4> value, MessagePack.MessagePackSerializerOptions options);
            System.Tuple<T1, T2, T3, T4> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class TupleFormatter<T1, T2, T3, T4, T5> : MessagePack.Formatters.IMessagePackFormatter<System.Tuple<T1, T2, T3, T4, T5>>, MessagePack.Formatters.IMessagePackFormatter
        {
            TupleFormatter();
            void Serialize(ref MessagePack.MessagePackWriter writer, System.Tuple<T1, T2, T3, T4, T5> value, MessagePack.MessagePackSerializerOptions options);
            System.Tuple<T1, T2, T3, T4, T5> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class TupleFormatter<T1, T2, T3, T4, T5, T6> : MessagePack.Formatters.IMessagePackFormatter<System.Tuple<T1, T2, T3, T4, T5, T6>>, MessagePack.Formatters.IMessagePackFormatter
        {
            TupleFormatter();
            void Serialize(ref MessagePack.MessagePackWriter writer, System.Tuple<T1, T2, T3, T4, T5, T6> value, MessagePack.MessagePackSerializerOptions options);
            System.Tuple<T1, T2, T3, T4, T5, T6> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class TupleFormatter<T1, T2, T3, T4, T5, T6, T7> : MessagePack.Formatters.IMessagePackFormatter<System.Tuple<T1, T2, T3, T4, T5, T6, T7>>, MessagePack.Formatters.IMessagePackFormatter
        {
            TupleFormatter();
            void Serialize(ref MessagePack.MessagePackWriter writer, System.Tuple<T1, T2, T3, T4, T5, T6, T7> value, MessagePack.MessagePackSerializerOptions options);
            System.Tuple<T1, T2, T3, T4, T5, T6, T7> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class TupleFormatter<T1, T2, T3, T4, T5, T6, T7, TRest> : MessagePack.Formatters.IMessagePackFormatter<System.Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>>, MessagePack.Formatters.IMessagePackFormatter
        {
            TupleFormatter();
            void Serialize(ref MessagePack.MessagePackWriter writer, System.Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> value, MessagePack.MessagePackSerializerOptions options);
            System.Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ValueTupleFormatter<T1> : MessagePack.Formatters.IMessagePackFormatter<System.ValueTuple<T1>>, MessagePack.Formatters.IMessagePackFormatter
        {
            ValueTupleFormatter();
            void Serialize(ref MessagePack.MessagePackWriter writer, System.ValueTuple<T1> value, MessagePack.MessagePackSerializerOptions options);
            System.ValueTuple<T1> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ValueTupleFormatter<T1, T2> : MessagePack.Formatters.IMessagePackFormatter<System.ValueTuple<T1, T2>>, MessagePack.Formatters.IMessagePackFormatter
        {
            ValueTupleFormatter();
            void Serialize(ref MessagePack.MessagePackWriter writer, System.ValueTuple<T1, T2> value, MessagePack.MessagePackSerializerOptions options);
            System.ValueTuple<T1, T2> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ValueTupleFormatter<T1, T2, T3> : MessagePack.Formatters.IMessagePackFormatter<System.ValueTuple<T1, T2, T3>>, MessagePack.Formatters.IMessagePackFormatter
        {
            ValueTupleFormatter();
            void Serialize(ref MessagePack.MessagePackWriter writer, System.ValueTuple<T1, T2, T3> value, MessagePack.MessagePackSerializerOptions options);
            System.ValueTuple<T1, T2, T3> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ValueTupleFormatter<T1, T2, T3, T4> : MessagePack.Formatters.IMessagePackFormatter<System.ValueTuple<T1, T2, T3, T4>>, MessagePack.Formatters.IMessagePackFormatter
        {
            ValueTupleFormatter();
            void Serialize(ref MessagePack.MessagePackWriter writer, System.ValueTuple<T1, T2, T3, T4> value, MessagePack.MessagePackSerializerOptions options);
            System.ValueTuple<T1, T2, T3, T4> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ValueTupleFormatter<T1, T2, T3, T4, T5> : MessagePack.Formatters.IMessagePackFormatter<System.ValueTuple<T1, T2, T3, T4, T5>>, MessagePack.Formatters.IMessagePackFormatter
        {
            ValueTupleFormatter();
            void Serialize(ref MessagePack.MessagePackWriter writer, System.ValueTuple<T1, T2, T3, T4, T5> value, MessagePack.MessagePackSerializerOptions options);
            System.ValueTuple<T1, T2, T3, T4, T5> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ValueTupleFormatter<T1, T2, T3, T4, T5, T6> : MessagePack.Formatters.IMessagePackFormatter<System.ValueTuple<T1, T2, T3, T4, T5, T6>>, MessagePack.Formatters.IMessagePackFormatter
        {
            ValueTupleFormatter();
            void Serialize(ref MessagePack.MessagePackWriter writer, System.ValueTuple<T1, T2, T3, T4, T5, T6> value, MessagePack.MessagePackSerializerOptions options);
            System.ValueTuple<T1, T2, T3, T4, T5, T6> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ValueTupleFormatter<T1, T2, T3, T4, T5, T6, T7> : MessagePack.Formatters.IMessagePackFormatter<System.ValueTuple<T1, T2, T3, T4, T5, T6, T7>>, MessagePack.Formatters.IMessagePackFormatter
        {
            ValueTupleFormatter();
            void Serialize(ref MessagePack.MessagePackWriter writer, System.ValueTuple<T1, T2, T3, T4, T5, T6, T7> value, MessagePack.MessagePackSerializerOptions options);
            System.ValueTuple<T1, T2, T3, T4, T5, T6, T7> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
        }

        class ValueTupleFormatter<T1, T2, T3, T4, T5, T6, T7, TRest> : MessagePack.Formatters.IMessagePackFormatter<System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>, MessagePack.Formatters.IMessagePackFormatter
        {
            ValueTupleFormatter();
            void Serialize(ref MessagePack.MessagePackWriter writer, System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> value, MessagePack.MessagePackSerializerOptions options);
            System.ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
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
