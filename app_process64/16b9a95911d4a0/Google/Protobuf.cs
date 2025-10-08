class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x304f2bc*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x304f3b0*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace EA
{
    namespace GoogleProtobuf
    {
        namespace Runtime
        {
            class InitializeInputStream
            {
                static /*0x304f3b8*/ void OnRuntimeInitialize();
                static /*0x304f568*/ string CreateInternStringFromEncoding(System.Text.Encoding encoding, byte[] bytes, int index, int byteLength);
            }
        }
    }
}

namespace Google
{
    namespace Protobuf
    {
        class ByteArray
        {
            static int CopyThreshold = 12;

            static /*0x304f6a4*/ void Copy(byte[] src, int srcOffset, byte[] dst, int dstOffset, int count);
            static /*0x304f724*/ void Reverse(byte[] bytes);
        }

        class ByteString : System.Collections.Generic.IEnumerable<byte>, System.Collections.IEnumerable, System.IEquatable<Google.Protobuf.ByteString>
        {
            static /*0x0*/ Google.Protobuf.ByteString empty;
            /*0x10*/ System.ReadOnlyMemory<byte> bytes;

            static /*0x3050d88*/ ByteString();
            static /*0x304f788*/ Google.Protobuf.ByteString AttachBytes(System.ReadOnlyMemory<byte> bytes);
            static /*0x304f838*/ Google.Protobuf.ByteString AttachBytes(byte[] bytes);
            static /*0x304f8dc*/ Google.Protobuf.ByteString get_Empty();
            static /*0x304fb60*/ Google.Protobuf.ByteString FromBase64(string bytes);
            static /*0x304fc98*/ Google.Protobuf.ByteString FromStream(System.IO.Stream stream);
            static /*0x304fe64*/ System.Threading.Tasks.Task<Google.Protobuf.ByteString> FromStreamAsync(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken);
            static /*0x304fff8*/ Google.Protobuf.ByteString CopyFrom(byte[] bytes);
            static /*0x30500d4*/ Google.Protobuf.ByteString CopyFrom(byte[] bytes, int offset, int count);
            static /*0x30501bc*/ Google.Protobuf.ByteString CopyFrom(System.ReadOnlySpan<byte> bytes);
            static /*0x305027c*/ Google.Protobuf.ByteString CopyFrom(string text, System.Text.Encoding encoding);
            static /*0x3050338*/ Google.Protobuf.ByteString CopyFromUtf8(string text);
            static /*0x305094c*/ bool op_Equality(Google.Protobuf.ByteString lhs, Google.Protobuf.ByteString rhs);
            static /*0x3050a00*/ bool op_Inequality(Google.Protobuf.ByteString lhs, Google.Protobuf.ByteString rhs);
            /*0x304f800*/ ByteString(System.ReadOnlyMemory<byte> bytes);
            /*0x304f934*/ int get_Length();
            /*0x304f97c*/ bool get_IsEmpty();
            /*0x304f994*/ System.ReadOnlySpan<byte> get_Span();
            /*0x304f9dc*/ System.ReadOnlyMemory<byte> get_Memory();
            /*0x304f9e8*/ byte[] ToByteArray();
            /*0x304fa30*/ string ToBase64();
            /*0x30503a0*/ byte get_Item(int index);
            /*0x3050408*/ string ToString(System.Text.Encoding encoding);
            /*0x3050520*/ string ToStringUtf8();
            /*0x3050540*/ System.Collections.Generic.IEnumerator<byte> GetEnumerator();
            /*0x3050600*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x3050604*/ Google.Protobuf.CodedInputStream CreateCodedInput();
            /*0x3050a70*/ bool Equals(object obj);
            /*0x3050af0*/ int GetHashCode();
            /*0x3050b78*/ bool Equals(Google.Protobuf.ByteString other);
            /*0x3050bdc*/ void CopyTo(byte[] array, int position);
            /*0x3050c70*/ void WriteTo(System.IO.Stream outputStream);
        }

        class ByteStringAsync
        {
            static /*0x304fedc*/ System.Threading.Tasks.Task<Google.Protobuf.ByteString> FromStreamAsyncCore(System.IO.Stream stream, System.Threading.CancellationToken cancellationToken);

            struct <FromStreamAsyncCore>d__0 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Google.Protobuf.ByteString> <>t__builder;
                /*0x30*/ System.IO.Stream stream;
                /*0x38*/ System.Threading.CancellationToken cancellationToken;
                /*0x40*/ System.IO.MemoryStream <memoryStream>5__2;
                /*0x48*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                /*0x3050e50*/ void MoveNext();
                /*0x3051288*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class CodedInputStream : System.IDisposable
        {
            static int DefaultRecursionLimit = 100;
            static int DefaultSizeLimit = 2147483647;
            static int BufferSize = 4096;
            static /*0x0*/ System.Text.Encoding Utf8Encoding;
            static /*0x8*/ Google.Protobuf.CodedInputStream.CreateStringFromEncodingDelegate CreateStringFromEncoding;
            /*0x10*/ bool leaveOpen;
            /*0x18*/ byte[] buffer;
            /*0x20*/ System.IO.Stream input;
            /*0x28*/ Google.Protobuf.ParserInternalState state;

            static /*0x3052598*/ CodedInputStream();
            static /*0x3051304*/ string CreateStringFromEncodingDefault(System.Text.Encoding encoding, byte[] bytes, int index, int byteLength);
            static /*0x30515c8*/ Google.Protobuf.CodedInputStream CreateWithLimits(System.IO.Stream input, int sizeLimit, int recursionLimit);
            static /*0x3052300*/ uint ReadRawVarint32(System.IO.Stream input);
            /*0x30508bc*/ CodedInputStream(byte[] buffer);
            /*0x305076c*/ CodedInputStream(byte[] buffer, int offset, int length);
            /*0x305143c*/ CodedInputStream(System.IO.Stream input);
            /*0x3051444*/ CodedInputStream(System.IO.Stream input, bool leaveOpen);
            /*0x3051320*/ CodedInputStream(System.IO.Stream input, byte[] buffer, int bufferPos, int bufferSize, bool leaveOpen);
            /*0x3051500*/ CodedInputStream(System.IO.Stream input, byte[] buffer, int bufferPos, int bufferSize, int sizeLimit, int recursionLimit, bool leaveOpen);
            /*0x3051680*/ long get_Position();
            /*0x30516c0*/ uint get_LastTag();
            /*0x30516c8*/ int get_SizeLimit();
            /*0x30516d0*/ int get_RecursionLimit();
            /*0x30516d8*/ bool get_DiscardUnknownFields();
            /*0x30516e0*/ void set_DiscardUnknownFields(bool value);
            /*0x30516e8*/ Google.Protobuf.ExtensionRegistry get_ExtensionRegistry();
            /*0x30516f0*/ void set_ExtensionRegistry(Google.Protobuf.ExtensionRegistry value);
            /*0x30516f8*/ byte[] get_InternalBuffer();
            /*0x3051700*/ System.IO.Stream get_InternalInputStream();
            /*0x3051708*/ ref Google.Protobuf.ParserInternalState get_InternalState();
            /*0x3051710*/ void Dispose();
            /*0x3051734*/ void CheckReadEndOfStreamTag();
            /*0x305178c*/ uint PeekTag();
            /*0x3051800*/ uint ReadTag();
            /*0x3051874*/ void SkipLastField();
            /*0x305190c*/ void SkipGroup(uint startGroupTag);
            /*0x30519ac*/ double ReadDouble();
            /*0x3051a20*/ float ReadFloat();
            /*0x3051a94*/ ulong ReadUInt64();
            /*0x3051b0c*/ long ReadInt64();
            /*0x3051b10*/ int ReadInt32();
            /*0x3051b88*/ ulong ReadFixed64();
            /*0x3051c00*/ uint ReadFixed32();
            /*0x3051c78*/ bool ReadBool();
            /*0x3051c90*/ string ReadString();
            /*0x3051eac*/ void ReadMessage(Google.Protobuf.IMessage builder);
            /*0x3052028*/ void ReadGroup(Google.Protobuf.IMessage builder);
            /*0x3052178*/ Google.Protobuf.ByteString ReadBytes();
            /*0x3052248*/ uint ReadUInt32();
            /*0x305224c*/ int ReadEnum();
            /*0x3052250*/ int ReadSFixed32();
            /*0x3052254*/ long ReadSFixed64();
            /*0x3052258*/ int ReadSInt32();
            /*0x305226c*/ long ReadSInt64();
            /*0x3051dbc*/ int ReadLength();
            /*0x3052280*/ bool MaybeConsumeTag(uint tag);
            /*0x3051b14*/ uint ReadRawVarint32();
            /*0x3051a98*/ ulong ReadRawVarint64();
            /*0x3051c04*/ uint ReadRawLittleEndian32();
            /*0x3051b8c*/ ulong ReadRawLittleEndian64();
            /*0x3052308*/ int PushLimit(int byteLimit);
            /*0x3052314*/ void PopLimit(int oldLimit);
            /*0x3052320*/ bool get_ReachedLimit();
            /*0x305232c*/ bool get_IsAtEnd();
            /*0x30523c4*/ bool RefillBuffer(bool mustSucceed);
            /*0x3051e30*/ byte[] ReadRawBytes(int size);
            /*0x3052448*/ void ReadRawMessage(Google.Protobuf.IMessage message);

            class CreateStringFromEncodingDelegate : System.MulticastDelegate
            {
                /*0x304f45c*/ CreateStringFromEncodingDelegate(object object, nint method);
                /*0x3052650*/ string Invoke(System.Text.Encoding encoding, byte[] bytes, int index, int byteLength);
                /*0x3052664*/ System.IAsyncResult BeginInvoke(System.Text.Encoding encoding, byte[] bytes, int index, int byteLength, System.AsyncCallback callback, object object);
                /*0x30526e8*/ string EndInvoke(System.IAsyncResult result);
            }
        }

        class CodedOutputStream : System.IDisposable
        {
            static int LittleEndian64Size = 8;
            static int LittleEndian32Size = 4;
            static int DoubleSize = 8;
            static int FloatSize = 4;
            static int BoolSize = 1;
            static /*0x0*/ int DefaultBufferSize;
            /*0x10*/ bool leaveOpen;
            /*0x18*/ byte[] buffer;
            /*0x20*/ Google.Protobuf.WriterInternalState state;
            /*0x38*/ System.IO.Stream output;

            static /*0x3054b50*/ CodedOutputStream();
            static /*0x30526f4*/ int ComputeDoubleSize(double value);
            static /*0x30526fc*/ int ComputeFloatSize(float value);
            static /*0x3052704*/ int ComputeUInt64Size(ulong value);
            static /*0x30527e8*/ int ComputeInt64Size(long value);
            static /*0x305283c*/ int ComputeInt32Size(int value);
            static /*0x305291c*/ int ComputeFixed64Size(ulong value);
            static /*0x3052924*/ int ComputeFixed32Size(uint value);
            static /*0x305292c*/ int ComputeBoolSize(bool value);
            static /*0x3052934*/ int ComputeStringSize(string value);
            static /*0x3052a70*/ int ComputeGroupSize(Google.Protobuf.IMessage value);
            static /*0x3052b10*/ int ComputeMessageSize(Google.Protobuf.IMessage value);
            static /*0x3052bec*/ int ComputeBytesSize(Google.Protobuf.ByteString value);
            static /*0x3052c6c*/ int ComputeUInt32Size(uint value);
            static /*0x3052cfc*/ int ComputeEnumSize(int value);
            static /*0x3052d50*/ int ComputeSFixed32Size(int value);
            static /*0x3052d58*/ int ComputeSFixed64Size(long value);
            static /*0x3052d60*/ int ComputeSInt32Size(int value);
            static /*0x3052e28*/ int ComputeSInt64Size(long value);
            static /*0x30529e0*/ int ComputeLengthSize(int length);
            static /*0x30528d8*/ int ComputeRawVarint32Size(uint value);
            static /*0x3052758*/ int ComputeRawVarint64Size(ulong value);
            static /*0x3052eb4*/ int ComputeTagSize(int fieldNumber);
            /*0x3052f5c*/ CodedOutputStream(byte[] flatArray);
            /*0x3052f74*/ CodedOutputStream(byte[] buffer, int offset, int length);
            /*0x3053050*/ CodedOutputStream(System.IO.Stream output, byte[] buffer, bool leaveOpen);
            /*0x305313c*/ CodedOutputStream(System.IO.Stream output);
            /*0x3053228*/ CodedOutputStream(System.IO.Stream output, int bufferSize);
            /*0x3053294*/ CodedOutputStream(System.IO.Stream output, bool leaveOpen);
            /*0x30531b0*/ CodedOutputStream(System.IO.Stream output, int bufferSize, bool leaveOpen);
            /*0x305330c*/ long get_Position();
            /*0x3053340*/ void WriteDouble(double value);
            /*0x30533e8*/ void WriteFloat(float value);
            /*0x3053490*/ void WriteUInt64(ulong value);
            /*0x3053530*/ void WriteInt64(long value);
            /*0x30535d0*/ void WriteInt32(int value);
            /*0x3053670*/ void WriteFixed64(ulong value);
            /*0x3053710*/ void WriteFixed32(uint value);
            /*0x30537b0*/ void WriteBool(bool value);
            /*0x3053850*/ void WriteString(string value);
            /*0x30538f0*/ void WriteMessage(Google.Protobuf.IMessage value);
            /*0x3053a00*/ void WriteRawMessage(Google.Protobuf.IMessage value);
            /*0x3053b10*/ void WriteGroup(Google.Protobuf.IMessage value);
            /*0x3053c20*/ void WriteBytes(Google.Protobuf.ByteString value);
            /*0x3053cc0*/ void WriteUInt32(uint value);
            /*0x3053d60*/ void WriteEnum(int value);
            /*0x3053e00*/ void WriteSFixed32(int value);
            /*0x3053ea0*/ void WriteSFixed64(long value);
            /*0x3053f40*/ void WriteSInt32(int value);
            /*0x3053fe0*/ void WriteSInt64(long value);
            /*0x3054080*/ void WriteLength(int length);
            /*0x3054120*/ void WriteTag(int fieldNumber, Google.Protobuf.WireFormat.WireType type);
            /*0x30541d0*/ void WriteTag(uint tag);
            /*0x3054270*/ void WriteRawTag(byte b1);
            /*0x3054310*/ void WriteRawTag(byte b1, byte b2);
            /*0x30543c0*/ void WriteRawTag(byte b1, byte b2, byte b3);
            /*0x3054478*/ void WriteRawTag(byte b1, byte b2, byte b3, byte b4);
            /*0x3054540*/ void WriteRawTag(byte b1, byte b2, byte b3, byte b4, byte b5);
            /*0x3054610*/ void WriteRawVarint32(uint value);
            /*0x30546b0*/ void WriteRawVarint64(ulong value);
            /*0x3054750*/ void WriteRawLittleEndian32(uint value);
            /*0x30547f0*/ void WriteRawLittleEndian64(ulong value);
            /*0x3054890*/ void WriteRawBytes(byte[] value);
            /*0x30548a8*/ void WriteRawBytes(byte[] value, int offset, int length);
            /*0x3054960*/ void Dispose();
            /*0x3054994*/ void Flush();
            /*0x3054abc*/ void CheckNoSpaceLeft();
            /*0x3054ac8*/ int get_SpaceLeft();
            /*0x3054b38*/ byte[] get_InternalBuffer();
            /*0x3054b40*/ System.IO.Stream get_InternalOutputStream();
            /*0x3054b48*/ ref Google.Protobuf.WriterInternalState get_InternalState();

            class OutOfSpaceException : System.IO.IOException
            {
                /*0x3054b9c*/ OutOfSpaceException();
            }
        }

        class Extension
        {
            /*0x10*/ int <FieldNumber>k__BackingField;

            /*0x3054be8*/ Extension(int fieldNumber);
            /*0x1f30214*/ System.Type get_TargetType();
            /*0x1f30214*/ Google.Protobuf.IExtensionValue CreateValue();
            /*0x3054c10*/ int get_FieldNumber();
            /*0x1f2fe14*/ bool get_IsRepeated();
        }

        class Extension<TTarget, TValue> : Google.Protobuf.Extension
        {
            /*0x0*/ Google.Protobuf.FieldCodec<TValue> codec;

            /*0x1f30c88*/ Extension(int fieldNumber, Google.Protobuf.FieldCodec<TValue> codec);
            /*0x1ffc854*/ TValue get_DefaultValue();
            /*0x1f30214*/ System.Type get_TargetType();
            /*0x1f2fe14*/ bool get_IsRepeated();
            /*0x1f30214*/ Google.Protobuf.IExtensionValue CreateValue();
        }

        class RepeatedExtension<TTarget, TValue> : Google.Protobuf.Extension
        {
            /*0x0*/ Google.Protobuf.FieldCodec<TValue> codec;

            /*0x1f30c88*/ RepeatedExtension(int fieldNumber, Google.Protobuf.FieldCodec<TValue> codec);
            /*0x1f30214*/ System.Type get_TargetType();
            /*0x1f2fe14*/ bool get_IsRepeated();
            /*0x1f30214*/ Google.Protobuf.IExtensionValue CreateValue();
        }

        class ExtensionRegistry : System.Collections.Generic.ICollection<Google.Protobuf.Extension>, System.Collections.Generic.IEnumerable<Google.Protobuf.Extension>, System.Collections.IEnumerable, Google.Protobuf.IDeepCloneable<Google.Protobuf.ExtensionRegistry>
        {
            /*0x10*/ System.Collections.Generic.IDictionary<Google.Protobuf.ObjectIntPair<System.Type>, Google.Protobuf.Extension> extensions;

            /*0x3054c18*/ ExtensionRegistry();
            /*0x3054ca0*/ ExtensionRegistry(System.Collections.Generic.IDictionary<Google.Protobuf.ObjectIntPair<System.Type>, Google.Protobuf.Extension> collection);
            /*0x3054e5c*/ int get_Count();
            /*0x3054efc*/ bool System.Collections.Generic.ICollection<Google.Protobuf.Extension>.get_IsReadOnly();
            /*0x3054f04*/ bool ContainsInputField(uint lastTag, System.Type target, ref Google.Protobuf.Extension extension);
            /*0x305501c*/ void Add(Google.Protobuf.Extension extension);
            /*0x3055160*/ void AddRange(System.Collections.Generic.IEnumerable<Google.Protobuf.Extension> extensions);
            /*0x3055438*/ void Clear();
            /*0x30554dc*/ bool Contains(Google.Protobuf.Extension item);
            /*0x3055620*/ void System.Collections.Generic.ICollection<Google.Protobuf.Extension>.CopyTo(Google.Protobuf.Extension[] array, int arrayIndex);
            /*0x3055850*/ System.Collections.Generic.IEnumerator<Google.Protobuf.Extension> GetEnumerator();
            /*0x3055968*/ bool Remove(Google.Protobuf.Extension item);
            /*0x3055aac*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x3055ab0*/ Google.Protobuf.ExtensionRegistry Clone();

            class ExtensionComparer : System.Collections.Generic.IEqualityComparer<Google.Protobuf.Extension>
            {
                static /*0x0*/ Google.Protobuf.ExtensionRegistry.ExtensionComparer Instance;

                static /*0x3055c94*/ ExtensionComparer();
                /*0x3055c8c*/ ExtensionComparer();
                /*0x3055b0c*/ bool Equals(Google.Protobuf.Extension a, Google.Protobuf.Extension b);
                /*0x3055be8*/ int GetHashCode(Google.Protobuf.Extension a);
            }

            class <>c
            {
                static /*0x0*/ Google.Protobuf.ExtensionRegistry.<> <>9;
                static /*0x8*/ System.Func<System.Collections.Generic.KeyValuePair<Google.Protobuf.ObjectIntPair<System.Type>, Google.Protobuf.Extension>, Google.Protobuf.ObjectIntPair<System.Type>> <>9__3_0;
                static /*0x10*/ System.Func<System.Collections.Generic.KeyValuePair<Google.Protobuf.ObjectIntPair<System.Type>, Google.Protobuf.Extension>, Google.Protobuf.Extension> <>9__3_1;

                static /*0x3055cfc*/ <>c();
                /*0x3055d64*/ <>c();
                /*0x3055d6c*/ Google.Protobuf.ObjectIntPair<System.Type> <.ctor>b__3_0(System.Collections.Generic.KeyValuePair<Google.Protobuf.ObjectIntPair<System.Type>, Google.Protobuf.Extension> k);
                /*0x3055e28*/ Google.Protobuf.Extension <.ctor>b__3_1(System.Collections.Generic.KeyValuePair<Google.Protobuf.ObjectIntPair<System.Type>, Google.Protobuf.Extension> v);
            }
        }

        class ExtensionSet
        {
            static /*0x1f319c4*/ bool TryGetValue<TTarget>(ref Google.Protobuf.ExtensionSet<TTarget> set, Google.Protobuf.Extension extension, ref Google.Protobuf.IExtensionValue value);
            static /*0x1ffc854*/ TValue Get<TTarget, TValue>(ref Google.Protobuf.ExtensionSet<TTarget> set, Google.Protobuf.Extension<TTarget, TValue> extension);
            static /*0x1f32888*/ Google.Protobuf.Collections.RepeatedField<TValue> Get<TTarget, TValue>(ref Google.Protobuf.ExtensionSet<TTarget> set, Google.Protobuf.RepeatedExtension<TTarget, TValue> extension);
            static /*0x1f32888*/ Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitialize<TTarget, TValue>(ref Google.Protobuf.ExtensionSet<TTarget> set, Google.Protobuf.RepeatedExtension<TTarget, TValue> extension);
            static /*0x1ffc854*/ void Set<TTarget, TValue>(ref Google.Protobuf.ExtensionSet<TTarget> set, Google.Protobuf.Extension<TTarget, TValue> extension, TValue value);
            static /*0x1f318fc*/ bool Has<TTarget, TValue>(ref Google.Protobuf.ExtensionSet<TTarget> set, Google.Protobuf.Extension<TTarget, TValue> extension);
            static /*0x1f36f18*/ void Clear<TTarget, TValue>(ref Google.Protobuf.ExtensionSet<TTarget> set, Google.Protobuf.Extension<TTarget, TValue> extension);
            static /*0x1f36f18*/ void Clear<TTarget, TValue>(ref Google.Protobuf.ExtensionSet<TTarget> set, Google.Protobuf.RepeatedExtension<TTarget, TValue> extension);
            static /*0x1f318fc*/ bool TryMergeFieldFrom<TTarget>(ref Google.Protobuf.ExtensionSet<TTarget> set, Google.Protobuf.CodedInputStream stream);
            static /*0x1f318fc*/ bool TryMergeFieldFrom<TTarget>(ref Google.Protobuf.ExtensionSet<TTarget> set, ref Google.Protobuf.ParseContext ctx);
            static /*0x1f36f18*/ void MergeFrom<TTarget>(ref Google.Protobuf.ExtensionSet<TTarget> first, Google.Protobuf.ExtensionSet<TTarget> second);
            static /*0x1f327cc*/ Google.Protobuf.ExtensionSet<TTarget> Clone<TTarget>(Google.Protobuf.ExtensionSet<TTarget> set);
        }

        class ExtensionSet<TTarget>
        {
            /*0x0*/ System.Collections.Generic.Dictionary<int, Google.Protobuf.IExtensionValue> <ValuesByNumber>k__BackingField;

            /*0x1f309e4*/ ExtensionSet();
            /*0x1f30214*/ System.Collections.Generic.Dictionary<int, Google.Protobuf.IExtensionValue> get_ValuesByNumber();
            /*0x1f2ffc8*/ int GetHashCode();
            /*0x1f2fec8*/ bool Equals(object other);
            /*0x1f2ffc8*/ int CalculateSize();
            /*0x1f30ebc*/ void WriteTo(Google.Protobuf.CodedOutputStream stream);
            /*0x1f30ebc*/ void WriteTo(ref Google.Protobuf.WriteContext ctx);
            /*0x1f2fe14*/ bool IsInitialized();

            class <>c<TTarget>
            {
                static /*0x0*/ Google.Protobuf.ExtensionSet.<>c<TTarget> <>9;
                static /*0x0*/ System.Func<Google.Protobuf.IExtensionValue, bool> <>9__8_0;

                static /*0x1f33998*/ <>c();
                /*0x1f309e4*/ <>c();
                /*0x1f2fec8*/ bool <IsInitialized>b__8_0(Google.Protobuf.IExtensionValue v);
            }
        }

        interface IExtensionValue : System.IEquatable<Google.Protobuf.IExtensionValue>, Google.Protobuf.IDeepCloneable<Google.Protobuf.IExtensionValue>
        {
            /*0x1f30ebc*/ void MergeFrom(ref Google.Protobuf.ParseContext ctx);
            /*0x1f30ebc*/ void MergeFrom(Google.Protobuf.IExtensionValue value);
            /*0x1f30ebc*/ void WriteTo(ref Google.Protobuf.WriteContext ctx);
            /*0x1f2ffc8*/ int CalculateSize();
            /*0x1f2fe14*/ bool IsInitialized();
        }

        class ExtensionValue<T> : Google.Protobuf.IExtensionValue, System.IEquatable<Google.Protobuf.IExtensionValue>, Google.Protobuf.IDeepCloneable<Google.Protobuf.IExtensionValue>
        {
            /*0x0*/ T field;
            /*0x0*/ Google.Protobuf.FieldCodec<T> codec;

            /*0x1f30ebc*/ ExtensionValue(Google.Protobuf.FieldCodec<T> codec);
            /*0x1f2ffc8*/ int CalculateSize();
            /*0x1f30214*/ Google.Protobuf.IExtensionValue Clone();
            /*0x1f2fec8*/ bool Equals(Google.Protobuf.IExtensionValue other);
            /*0x1f2ffc8*/ int GetHashCode();
            /*0x1f30ebc*/ void MergeFrom(ref Google.Protobuf.ParseContext ctx);
            /*0x1f30ebc*/ void MergeFrom(Google.Protobuf.IExtensionValue value);
            /*0x1f30ebc*/ void WriteTo(ref Google.Protobuf.WriteContext ctx);
            /*0x1ffc854*/ T GetValue();
            /*0x1ffc854*/ void SetValue(T value);
            /*0x1f2fe14*/ bool IsInitialized();
        }

        class RepeatedExtensionValue<T> : Google.Protobuf.IExtensionValue, System.IEquatable<Google.Protobuf.IExtensionValue>, Google.Protobuf.IDeepCloneable<Google.Protobuf.IExtensionValue>
        {
            /*0x0*/ Google.Protobuf.Collections.RepeatedField<T> field;
            /*0x0*/ Google.Protobuf.FieldCodec<T> codec;

            /*0x1f30ebc*/ RepeatedExtensionValue(Google.Protobuf.FieldCodec<T> codec);
            /*0x1f2ffc8*/ int CalculateSize();
            /*0x1f30214*/ Google.Protobuf.IExtensionValue Clone();
            /*0x1f2fec8*/ bool Equals(Google.Protobuf.IExtensionValue other);
            /*0x1f2ffc8*/ int GetHashCode();
            /*0x1f30ebc*/ void MergeFrom(ref Google.Protobuf.ParseContext ctx);
            /*0x1f30ebc*/ void MergeFrom(Google.Protobuf.IExtensionValue value);
            /*0x1f30ebc*/ void WriteTo(ref Google.Protobuf.WriteContext ctx);
            /*0x1f30214*/ Google.Protobuf.Collections.RepeatedField<T> GetValue();
            /*0x1f2fe14*/ bool IsInitialized();
        }

        class FieldCodec
        {
            static /*0x3055ee8*/ Google.Protobuf.FieldCodec<string> ForString(uint tag);
            static /*0x305614c*/ Google.Protobuf.FieldCodec<Google.Protobuf.ByteString> ForBytes(uint tag);
            static /*0x30563f8*/ Google.Protobuf.FieldCodec<bool> ForBool(uint tag);
            static /*0x30565d8*/ Google.Protobuf.FieldCodec<int> ForInt32(uint tag);
            static /*0x3056800*/ Google.Protobuf.FieldCodec<int> ForSInt32(uint tag);
            static /*0x3056a28*/ Google.Protobuf.FieldCodec<uint> ForFixed32(uint tag);
            static /*0x3056c04*/ Google.Protobuf.FieldCodec<int> ForSFixed32(uint tag);
            static /*0x3056de0*/ Google.Protobuf.FieldCodec<uint> ForUInt32(uint tag);
            static /*0x3057008*/ Google.Protobuf.FieldCodec<long> ForInt64(uint tag);
            static /*0x3057230*/ Google.Protobuf.FieldCodec<long> ForSInt64(uint tag);
            static /*0x3057458*/ Google.Protobuf.FieldCodec<ulong> ForFixed64(uint tag);
            static /*0x3057634*/ Google.Protobuf.FieldCodec<long> ForSFixed64(uint tag);
            static /*0x3057810*/ Google.Protobuf.FieldCodec<ulong> ForUInt64(uint tag);
            static /*0x3057a38*/ Google.Protobuf.FieldCodec<float> ForFloat(uint tag);
            static /*0x3057c14*/ Google.Protobuf.FieldCodec<double> ForDouble(uint tag);
            static /*0x1ffc854*/ Google.Protobuf.FieldCodec<T> ForEnum<T>(uint tag, System.Func<T, int> toInt32, System.Func<int, T> fromInt32);
            static /*0x3055f30*/ Google.Protobuf.FieldCodec<string> ForString(uint tag, string defaultValue);
            static /*0x30561dc*/ Google.Protobuf.FieldCodec<Google.Protobuf.ByteString> ForBytes(uint tag, Google.Protobuf.ByteString defaultValue);
            static /*0x3056400*/ Google.Protobuf.FieldCodec<bool> ForBool(uint tag, bool defaultValue);
            static /*0x30565e0*/ Google.Protobuf.FieldCodec<int> ForInt32(uint tag, int defaultValue);
            static /*0x3056808*/ Google.Protobuf.FieldCodec<int> ForSInt32(uint tag, int defaultValue);
            static /*0x3056a30*/ Google.Protobuf.FieldCodec<uint> ForFixed32(uint tag, uint defaultValue);
            static /*0x3056c0c*/ Google.Protobuf.FieldCodec<int> ForSFixed32(uint tag, int defaultValue);
            static /*0x3056de8*/ Google.Protobuf.FieldCodec<uint> ForUInt32(uint tag, uint defaultValue);
            static /*0x3057010*/ Google.Protobuf.FieldCodec<long> ForInt64(uint tag, long defaultValue);
            static /*0x3057238*/ Google.Protobuf.FieldCodec<long> ForSInt64(uint tag, long defaultValue);
            static /*0x3057460*/ Google.Protobuf.FieldCodec<ulong> ForFixed64(uint tag, ulong defaultValue);
            static /*0x305763c*/ Google.Protobuf.FieldCodec<long> ForSFixed64(uint tag, long defaultValue);
            static /*0x3057818*/ Google.Protobuf.FieldCodec<ulong> ForUInt64(uint tag, ulong defaultValue);
            static /*0x3057a40*/ Google.Protobuf.FieldCodec<float> ForFloat(uint tag, float defaultValue);
            static /*0x3057c1c*/ Google.Protobuf.FieldCodec<double> ForDouble(uint tag, double defaultValue);
            static /*0x1ffc854*/ Google.Protobuf.FieldCodec<T> ForEnum<T>(uint tag, System.Func<T, int> toInt32, System.Func<int, T> fromInt32, T defaultValue);
            static /*0x1ffc854*/ Google.Protobuf.FieldCodec<T> ForMessage<T>(uint tag, Google.Protobuf.MessageParser<T> parser);
            static /*0x1ffc854*/ Google.Protobuf.FieldCodec<T> ForGroup<T>(uint startTag, uint endTag, Google.Protobuf.MessageParser<T> parser);
            static /*0x1f33104*/ Google.Protobuf.FieldCodec<T> ForClassWrapper<T>(uint tag);
            static /*0x1f33104*/ Google.Protobuf.FieldCodec<System.Nullable<T>> ForStructWrapper<T>(uint tag);

            class WrapperCodecs
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, object> Codecs;
                static /*0x8*/ System.Collections.Generic.Dictionary<System.Type, object> Readers;

                static /*0x3057df0*/ WrapperCodecs();
                static /*0x1f327a0*/ Google.Protobuf.FieldCodec<T> GetCodec<T>();
                static /*0x1f327a0*/ Google.Protobuf.ValueReader<System.Nullable<T>> GetReader<T>();
                static /*0x1ffc854*/ T Read<T>(ref Google.Protobuf.ParseContext ctx, Google.Protobuf.FieldCodec<T> codec);
                static /*0x1ffc854*/ void Write<T>(ref Google.Protobuf.WriteContext ctx, T value, Google.Protobuf.FieldCodec<T> codec);
                static /*0x1ffc854*/ int CalculateSize<T>(T value, Google.Protobuf.FieldCodec<T> codec);

                class <>c__DisplayClass3_0<T>
                {
                    /*0x0*/ Google.Protobuf.FieldCodec<T> nestedCoded;

                    /*0x1f309e4*/ <>c__DisplayClass3_0();
                    /*0x1ffc854*/ System.Nullable<T> <GetReader>b__0(ref Google.Protobuf.ParseContext ctx);
                }
            }

            class <>c
            {
                static /*0x0*/ Google.Protobuf.FieldCodec.<> <>9;
                static /*0x8*/ Google.Protobuf.ValueReader<string> <>9__16_0;
                static /*0x10*/ Google.Protobuf.ValueWriter<string> <>9__16_1;
                static /*0x18*/ Google.Protobuf.ValueReader<Google.Protobuf.ByteString> <>9__17_0;
                static /*0x20*/ Google.Protobuf.ValueWriter<Google.Protobuf.ByteString> <>9__17_1;
                static /*0x28*/ Google.Protobuf.ValueReader<bool> <>9__18_0;
                static /*0x30*/ Google.Protobuf.ValueWriter<bool> <>9__18_1;
                static /*0x38*/ Google.Protobuf.ValueReader<int> <>9__19_0;
                static /*0x40*/ Google.Protobuf.ValueWriter<int> <>9__19_1;
                static /*0x48*/ Google.Protobuf.ValueReader<int> <>9__20_0;
                static /*0x50*/ Google.Protobuf.ValueWriter<int> <>9__20_1;
                static /*0x58*/ Google.Protobuf.ValueReader<uint> <>9__21_0;
                static /*0x60*/ Google.Protobuf.ValueWriter<uint> <>9__21_1;
                static /*0x68*/ Google.Protobuf.ValueReader<int> <>9__22_0;
                static /*0x70*/ Google.Protobuf.ValueWriter<int> <>9__22_1;
                static /*0x78*/ Google.Protobuf.ValueReader<uint> <>9__23_0;
                static /*0x80*/ Google.Protobuf.ValueWriter<uint> <>9__23_1;
                static /*0x88*/ Google.Protobuf.ValueReader<long> <>9__24_0;
                static /*0x90*/ Google.Protobuf.ValueWriter<long> <>9__24_1;
                static /*0x98*/ Google.Protobuf.ValueReader<long> <>9__25_0;
                static /*0xa0*/ Google.Protobuf.ValueWriter<long> <>9__25_1;
                static /*0xa8*/ Google.Protobuf.ValueReader<ulong> <>9__26_0;
                static /*0xb0*/ Google.Protobuf.ValueWriter<ulong> <>9__26_1;
                static /*0xb8*/ Google.Protobuf.ValueReader<long> <>9__27_0;
                static /*0xc0*/ Google.Protobuf.ValueWriter<long> <>9__27_1;
                static /*0xc8*/ Google.Protobuf.ValueReader<ulong> <>9__28_0;
                static /*0xd0*/ Google.Protobuf.ValueWriter<ulong> <>9__28_1;
                static /*0xd8*/ Google.Protobuf.ValueReader<float> <>9__29_0;
                static /*0xe0*/ Google.Protobuf.ValueWriter<float> <>9__29_1;
                static /*0xe8*/ Google.Protobuf.ValueReader<double> <>9__30_0;
                static /*0xf0*/ Google.Protobuf.ValueWriter<double> <>9__30_1;

                static /*0x30584e4*/ <>c();
                /*0x305854c*/ <>c();
                /*0x3058554*/ string <ForString>b__16_0(ref Google.Protobuf.ParseContext ctx);
                /*0x3058584*/ void <ForString>b__16_1(ref Google.Protobuf.WriteContext ctx, string value);
                /*0x3058594*/ Google.Protobuf.ByteString <ForBytes>b__17_0(ref Google.Protobuf.ParseContext ctx);
                /*0x3058614*/ void <ForBytes>b__17_1(ref Google.Protobuf.WriteContext ctx, Google.Protobuf.ByteString value);
                /*0x3058624*/ bool <ForBool>b__18_0(ref Google.Protobuf.ParseContext ctx);
                /*0x3058648*/ void <ForBool>b__18_1(ref Google.Protobuf.WriteContext ctx, bool value);
                /*0x3058658*/ int <ForInt32>b__19_0(ref Google.Protobuf.ParseContext ctx);
                /*0x3058668*/ void <ForInt32>b__19_1(ref Google.Protobuf.WriteContext output, int value);
                /*0x3058678*/ int <ForSInt32>b__20_0(ref Google.Protobuf.ParseContext ctx);
                /*0x3058698*/ void <ForSInt32>b__20_1(ref Google.Protobuf.WriteContext output, int value);
                /*0x30586a8*/ uint <ForFixed32>b__21_0(ref Google.Protobuf.ParseContext ctx);
                /*0x30586b8*/ void <ForFixed32>b__21_1(ref Google.Protobuf.WriteContext output, uint value);
                /*0x30586c8*/ int <ForSFixed32>b__22_0(ref Google.Protobuf.ParseContext ctx);
                /*0x30586d8*/ void <ForSFixed32>b__22_1(ref Google.Protobuf.WriteContext output, int value);
                /*0x30586e8*/ uint <ForUInt32>b__23_0(ref Google.Protobuf.ParseContext ctx);
                /*0x30586f8*/ void <ForUInt32>b__23_1(ref Google.Protobuf.WriteContext output, uint value);
                /*0x3058708*/ long <ForInt64>b__24_0(ref Google.Protobuf.ParseContext ctx);
                /*0x3058718*/ void <ForInt64>b__24_1(ref Google.Protobuf.WriteContext output, long value);
                /*0x3058728*/ long <ForSInt64>b__25_0(ref Google.Protobuf.ParseContext ctx);
                /*0x3058748*/ void <ForSInt64>b__25_1(ref Google.Protobuf.WriteContext output, long value);
                /*0x3058758*/ ulong <ForFixed64>b__26_0(ref Google.Protobuf.ParseContext ctx);
                /*0x3058768*/ void <ForFixed64>b__26_1(ref Google.Protobuf.WriteContext output, ulong value);
                /*0x3058778*/ long <ForSFixed64>b__27_0(ref Google.Protobuf.ParseContext ctx);
                /*0x3058788*/ void <ForSFixed64>b__27_1(ref Google.Protobuf.WriteContext output, long value);
                /*0x3058798*/ ulong <ForUInt64>b__28_0(ref Google.Protobuf.ParseContext ctx);
                /*0x30587a8*/ void <ForUInt64>b__28_1(ref Google.Protobuf.WriteContext output, ulong value);
                /*0x30587b8*/ float <ForFloat>b__29_0(ref Google.Protobuf.ParseContext ctx);
                /*0x30587c8*/ void <ForFloat>b__29_1(ref Google.Protobuf.WriteContext output, float value);
                /*0x30587d4*/ double <ForDouble>b__30_0(ref Google.Protobuf.ParseContext ctx);
                /*0x30587e4*/ void <ForDouble>b__30_1(ref Google.Protobuf.WriteContext output, double value);
            }

            class <>c__32<T>
            {
                static /*0x0*/ Google.Protobuf.FieldCodec.<>c__32<T> <>9;
                static /*0x0*/ Google.Protobuf.ValueWriter<T> <>9__32_1;
                static /*0x0*/ Google.Protobuf.FieldCodec.ValuesMerger<T> <>9__32_3;
                static /*0x0*/ System.Func<T, int> <>9__32_4;

                static /*0x1f33998*/ <>c__32();
                /*0x1f309e4*/ <>c__32();
                /*0x1ffc854*/ void <ForMessage>b__32_1(ref Google.Protobuf.WriteContext output, T value);
                /*0x1ffc854*/ bool <ForMessage>b__32_3(ref T v, T v2);
                /*0x1ffc854*/ int <ForMessage>b__32_4(T message);
            }

            class <>c__33<T>
            {
                static /*0x0*/ Google.Protobuf.FieldCodec.<>c__33<T> <>9;
                static /*0x0*/ Google.Protobuf.ValueWriter<T> <>9__33_1;
                static /*0x0*/ Google.Protobuf.FieldCodec.ValuesMerger<T> <>9__33_3;
                static /*0x0*/ System.Func<T, int> <>9__33_4;

                static /*0x1f33998*/ <>c__33();
                /*0x1f309e4*/ <>c__33();
                /*0x1ffc854*/ void <ForGroup>b__33_1(ref Google.Protobuf.WriteContext output, T value);
                /*0x1ffc854*/ bool <ForGroup>b__33_3(ref T v, T v2);
                /*0x1ffc854*/ int <ForGroup>b__33_4(T message);
            }

            class <>c__34<T>
            {
                static /*0x0*/ Google.Protobuf.FieldCodec.<>c__34<T> <>9;
                static /*0x0*/ Google.Protobuf.FieldCodec.ValuesMerger<T> <>9__34_3;

                static /*0x1f33998*/ <>c__34();
                /*0x1f309e4*/ <>c__34();
                /*0x1ffc854*/ bool <ForClassWrapper>b__34_3(ref T v, T v2);
            }

            class <>c__35<T>
            {
                static /*0x0*/ Google.Protobuf.FieldCodec.<>c__35<T> <>9;
                static /*0x0*/ Google.Protobuf.FieldCodec.ValuesMerger<System.Nullable<T>> <>9__35_2;

                static /*0x1f33998*/ <>c__35();
                /*0x1f309e4*/ <>c__35();
                /*0x1ffc854*/ bool <ForStructWrapper>b__35_2(ref System.Nullable<T> v, System.Nullable<T> v2);
            }

            class <>c__DisplayClass31_0<T>
            {
                /*0x0*/ System.Func<int, T> fromInt32;
                /*0x0*/ System.Func<T, int> toInt32;

                /*0x1f309e4*/ <>c__DisplayClass31_0();
                /*0x1ffc854*/ T <ForEnum>b__0(ref Google.Protobuf.ParseContext ctx);
                /*0x1ffc854*/ void <ForEnum>b__1(ref Google.Protobuf.WriteContext output, T value);
                /*0x1ffc854*/ int <ForEnum>b__2(T value);
            }

            class <>c__DisplayClass32_0<T>
            {
                /*0x0*/ Google.Protobuf.MessageParser<T> parser;

                /*0x1f309e4*/ <>c__DisplayClass32_0();
                /*0x1ffc854*/ T <ForMessage>b__0(ref Google.Protobuf.ParseContext ctx);
                /*0x1f30ff0*/ void <ForMessage>b__2(ref Google.Protobuf.ParseContext ctx, ref T v);
            }

            class <>c__DisplayClass33_0<T>
            {
                /*0x0*/ Google.Protobuf.MessageParser<T> parser;

                /*0x1f309e4*/ <>c__DisplayClass33_0();
                /*0x1ffc854*/ T <ForGroup>b__0(ref Google.Protobuf.ParseContext ctx);
                /*0x1f30ff0*/ void <ForGroup>b__2(ref Google.Protobuf.ParseContext ctx, ref T v);
            }

            class <>c__DisplayClass34_0<T>
            {
                /*0x0*/ Google.Protobuf.FieldCodec<T> nestedCodec;

                /*0x1f309e4*/ <>c__DisplayClass34_0();
                /*0x1ffc854*/ T <ForClassWrapper>b__0(ref Google.Protobuf.ParseContext ctx);
                /*0x1ffc854*/ void <ForClassWrapper>b__1(ref Google.Protobuf.WriteContext output, T value);
                /*0x1f30ff0*/ void <ForClassWrapper>b__2(ref Google.Protobuf.ParseContext ctx, ref T v);
                /*0x1ffc854*/ int <ForClassWrapper>b__4(T value);
            }

            class <>c__DisplayClass35_0<T>
            {
                /*0x0*/ Google.Protobuf.FieldCodec<T> nestedCodec;

                /*0x1f309e4*/ <>c__DisplayClass35_0();
                /*0x1ffc854*/ void <ForStructWrapper>b__0(ref Google.Protobuf.WriteContext output, System.Nullable<T> value);
                /*0x1f30ff0*/ void <ForStructWrapper>b__1(ref Google.Protobuf.ParseContext ctx, ref System.Nullable<T> v);
                /*0x1ffc854*/ int <ForStructWrapper>b__3(System.Nullable<T> value);
            }
        }

        class ValueReader<TValue> : System.MulticastDelegate
        {
            ValueReader(object object, nint method);
            /*0x1ffc854*/ TValue Invoke(ref Google.Protobuf.ParseContext ctx);
            /*0x1f303d0*/ System.IAsyncResult BeginInvoke(ref Google.Protobuf.ParseContext ctx, System.AsyncCallback callback, object object);
            /*0x1ffc854*/ TValue EndInvoke(ref Google.Protobuf.ParseContext ctx, System.IAsyncResult result);
        }

        class ValueWriter<T> : System.MulticastDelegate
        {
            ValueWriter(object object, nint method);
            /*0x1ffc854*/ void Invoke(ref Google.Protobuf.WriteContext ctx, T value);
            /*0x1ffc854*/ System.IAsyncResult BeginInvoke(ref Google.Protobuf.WriteContext ctx, T value, System.AsyncCallback callback, object object);
            /*0x1f30ff0*/ void EndInvoke(ref Google.Protobuf.WriteContext ctx, System.IAsyncResult result);
        }

        class FieldCodec<T>
        {
            static /*0x0*/ System.Collections.Generic.EqualityComparer<T> EqualityComparer;
            static /*0x0*/ T DefaultDefault;
            static /*0x0*/ bool TypeSupportsPacking;
            /*0x0*/ bool <PackedRepeatedField>k__BackingField;
            /*0x0*/ Google.Protobuf.ValueWriter<T> <ValueWriter>k__BackingField;
            /*0x0*/ System.Func<T, int> <ValueSizeCalculator>k__BackingField;
            /*0x0*/ Google.Protobuf.ValueReader<T> <ValueReader>k__BackingField;
            /*0x0*/ Google.Protobuf.FieldCodec.InputMerger<T> <ValueMerger>k__BackingField;
            /*0x0*/ Google.Protobuf.FieldCodec.ValuesMerger<T> <FieldMerger>k__BackingField;
            /*0x0*/ int <FixedSize>k__BackingField;
            /*0x0*/ uint <Tag>k__BackingField;
            /*0x0*/ uint <EndTag>k__BackingField;
            /*0x0*/ T <DefaultValue>k__BackingField;
            /*0x0*/ int tagSize;

            static /*0x1f33998*/ FieldCodec();
            static bool IsPackedRepeatedField(uint tag);
            /*0x1ffc854*/ FieldCodec(Google.Protobuf.ValueReader<T> reader, Google.Protobuf.ValueWriter<T> writer, int fixedSize, uint tag, T defaultValue);
            /*0x1ffc854*/ FieldCodec(Google.Protobuf.ValueReader<T> reader, Google.Protobuf.ValueWriter<T> writer, System.Func<T, int> sizeCalculator, uint tag, T defaultValue);
            /*0x1ffc854*/ FieldCodec(Google.Protobuf.ValueReader<T> reader, Google.Protobuf.ValueWriter<T> writer, Google.Protobuf.FieldCodec.InputMerger<T> inputMerger, Google.Protobuf.FieldCodec.ValuesMerger<T> valuesMerger, System.Func<T, int> sizeCalculator, uint tag, uint endTag);
            /*0x1ffc854*/ FieldCodec(Google.Protobuf.ValueReader<T> reader, Google.Protobuf.ValueWriter<T> writer, Google.Protobuf.FieldCodec.InputMerger<T> inputMerger, Google.Protobuf.FieldCodec.ValuesMerger<T> valuesMerger, System.Func<T, int> sizeCalculator, uint tag, uint endTag, T defaultValue);
            /*0x1f2fe14*/ bool get_PackedRepeatedField();
            /*0x1f30214*/ Google.Protobuf.ValueWriter<T> get_ValueWriter();
            /*0x1f30214*/ System.Func<T, int> get_ValueSizeCalculator();
            /*0x1f30214*/ Google.Protobuf.ValueReader<T> get_ValueReader();
            /*0x1f30214*/ Google.Protobuf.FieldCodec.InputMerger<T> get_ValueMerger();
            /*0x1f30214*/ Google.Protobuf.FieldCodec.ValuesMerger<T> get_FieldMerger();
            /*0x1f2ffc8*/ int get_FixedSize();
            uint get_Tag();
            uint get_EndTag();
            /*0x1ffc854*/ T get_DefaultValue();
            /*0x1ffc854*/ void WriteTagAndValue(Google.Protobuf.CodedOutputStream output, T value);
            /*0x1ffc854*/ void WriteTagAndValue(ref Google.Protobuf.WriteContext ctx, T value);
            /*0x1ffc854*/ T Read(Google.Protobuf.CodedInputStream input);
            /*0x1ffc854*/ T Read(ref Google.Protobuf.ParseContext ctx);
            /*0x1ffc854*/ int CalculateSizeWithTag(T value);
            /*0x1ffc854*/ int CalculateUnconditionalSizeWithTag(T value);
            /*0x1ffc854*/ bool IsDefault(T value);

            class InputMerger<T> : System.MulticastDelegate
            {
                InputMerger(object object, nint method);
                /*0x1f30ff0*/ void Invoke(ref Google.Protobuf.ParseContext ctx, ref T value);
                /*0x1f3040c*/ System.IAsyncResult BeginInvoke(ref Google.Protobuf.ParseContext ctx, ref T value, System.AsyncCallback callback, object object);
                /*0x1f310fc*/ void EndInvoke(ref Google.Protobuf.ParseContext ctx, ref T value, System.IAsyncResult result);
            }

            class ValuesMerger<T> : System.MulticastDelegate
            {
                ValuesMerger(object object, nint method);
                /*0x1ffc854*/ bool Invoke(ref T value, T other);
                /*0x1ffc854*/ System.IAsyncResult BeginInvoke(ref T value, T other, System.AsyncCallback callback, object object);
                /*0x1f2ff00*/ bool EndInvoke(ref T value, System.IAsyncResult result);
            }

            class <>c<T>
            {
                static /*0x0*/ Google.Protobuf.FieldCodec.<>c<T> <>9;
                static /*0x0*/ Google.Protobuf.FieldCodec.ValuesMerger<T> <>9__39_1;

                static /*0x1f33998*/ <>c();
                /*0x1f309e4*/ <>c();
                /*0x1ffc854*/ bool <.ctor>b__39_1(ref T v, T v2);
            }

            class <>c__DisplayClass38_0<T>
            {
                /*0x0*/ int fixedSize;

                /*0x1f309e4*/ <>c__DisplayClass38_0();
                /*0x1ffc854*/ int <.ctor>b__0(T _);
            }

            class <>c__DisplayClass39_0<T>
            {
                /*0x0*/ Google.Protobuf.ValueReader<T> reader;

                /*0x1f309e4*/ <>c__DisplayClass39_0();
                /*0x1f30ff0*/ void <.ctor>b__0(ref Google.Protobuf.ParseContext ctx, ref T v);
            }
        }

        class FieldMaskTree
        {
            static char FIELD_PATH_SEPARATOR = 46;
            /*0x10*/ Google.Protobuf.FieldMaskTree.Node root;

            /*0x30587f0*/ FieldMaskTree();
            /*0x30588e0*/ FieldMaskTree(Google.Protobuf.WellKnownTypes.FieldMask mask);
            /*0x3058c38*/ string ToString();
            /*0x3058d7c*/ Google.Protobuf.FieldMaskTree AddFieldPath(string path);
            /*0x3058960*/ Google.Protobuf.FieldMaskTree MergeFromFieldMask(Google.Protobuf.WellKnownTypes.FieldMask mask);
            /*0x3058c58*/ Google.Protobuf.WellKnownTypes.FieldMask ToFieldMask();
            /*0x3058f38*/ void GetFieldPaths(Google.Protobuf.FieldMaskTree.Node node, string path, System.Collections.Generic.List<string> paths);
            /*0x3059350*/ void IntersectFieldPath(string path, Google.Protobuf.FieldMaskTree output);
            /*0x3059674*/ void Merge(Google.Protobuf.IMessage source, Google.Protobuf.IMessage destination, Google.Protobuf.WellKnownTypes.FieldMask.MergeOptions options);
            /*0x305985c*/ void Merge(Google.Protobuf.FieldMaskTree.Node node, string path, Google.Protobuf.IMessage source, Google.Protobuf.IMessage destination, Google.Protobuf.WellKnownTypes.FieldMask.MergeOptions options);

            class Node
            {
                /*0x10*/ System.Collections.Generic.Dictionary<string, Google.Protobuf.FieldMaskTree.Node> <Children>k__BackingField;

                /*0x3058858*/ Node();
                /*0x305acd4*/ System.Collections.Generic.Dictionary<string, Google.Protobuf.FieldMaskTree.Node> get_Children();
            }
        }

        class FrameworkPortability
        {
            static /*0x0*/ System.Text.RegularExpressions.RegexOptions CompiledRegexWhereAvailable;

            static /*0x305acdc*/ FrameworkPortability();
        }

        interface IBufferMessage : Google.Protobuf.IMessage
        {
            /*0x1f30ebc*/ void InternalMergeFrom(ref Google.Protobuf.ParseContext ctx);
            /*0x1f30ebc*/ void InternalWriteTo(ref Google.Protobuf.WriteContext ctx);
        }

        interface ICustomDiagnosticMessage : Google.Protobuf.IMessage
        {
            /*0x1f30214*/ string ToDiagnosticString();
        }

        interface IDeepCloneable<T>
        {
            /*0x1ffc854*/ T Clone();
        }

        interface IExtendableMessage<T> : Google.Protobuf.IMessage<T>, Google.Protobuf.IMessage, System.IEquatable<T>, Google.Protobuf.IDeepCloneable<T>
        {
            /*0x1ffc854*/ TValue GetExtension<TValue>(Google.Protobuf.Extension<T, TValue> extension);
            /*0x1f302cc*/ Google.Protobuf.Collections.RepeatedField<TValue> GetExtension<TValue>(Google.Protobuf.RepeatedExtension<T, TValue> extension);
            /*0x1f302cc*/ Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension<TValue>(Google.Protobuf.RepeatedExtension<T, TValue> extension);
            /*0x1ffc854*/ void SetExtension<TValue>(Google.Protobuf.Extension<T, TValue> extension, TValue value);
            /*0x1f2fec8*/ bool HasExtension<TValue>(Google.Protobuf.Extension<T, TValue> extension);
            /*0x1f30ebc*/ void ClearExtension<TValue>(Google.Protobuf.Extension<T, TValue> extension);
            /*0x1f30ebc*/ void ClearExtension<TValue>(Google.Protobuf.RepeatedExtension<T, TValue> extension);
        }

        interface IMessage
        {
            /*0x1f30ebc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
            /*0x1f30ebc*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x1f2ffc8*/ int CalculateSize();
            /*0x1f30214*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
        }

        interface IMessage<T> : Google.Protobuf.IMessage, System.IEquatable<T>, Google.Protobuf.IDeepCloneable<T>
        {
            /*0x1ffc854*/ void MergeFrom(T message);
        }

        class InvalidJsonException : System.IO.IOException
        {
            /*0x305adb0*/ InvalidJsonException(string message);
        }

        class InvalidProtocolBufferException : System.IO.IOException
        {
            static /*0x305adc0*/ Google.Protobuf.InvalidProtocolBufferException MoreDataAvailable();
            static /*0x305ae2c*/ Google.Protobuf.InvalidProtocolBufferException TruncatedMessage();
            static /*0x305ae98*/ Google.Protobuf.InvalidProtocolBufferException NegativeSize();
            static /*0x305af04*/ Google.Protobuf.InvalidProtocolBufferException MalformedVarint();
            static /*0x305af70*/ Google.Protobuf.InvalidProtocolBufferException InvalidTag();
            static /*0x305afdc*/ Google.Protobuf.InvalidProtocolBufferException InvalidWireType();
            static /*0x305b048*/ Google.Protobuf.InvalidProtocolBufferException InvalidBase64(System.Exception innerException);
            static /*0x305b0c4*/ Google.Protobuf.InvalidProtocolBufferException InvalidEndTag();
            static /*0x305b130*/ Google.Protobuf.InvalidProtocolBufferException RecursionLimitExceeded();
            static /*0x305b19c*/ Google.Protobuf.InvalidProtocolBufferException JsonRecursionLimitExceeded();
            static /*0x305b208*/ Google.Protobuf.InvalidProtocolBufferException SizeLimitExceeded();
            static /*0x305b274*/ Google.Protobuf.InvalidProtocolBufferException InvalidMessageStreamTag();
            static /*0x305b2e0*/ Google.Protobuf.InvalidProtocolBufferException MissingFields();
            /*0x3059854*/ InvalidProtocolBufferException(string message);
            /*0x305adb8*/ InvalidProtocolBufferException(string message, System.Exception innerException);
        }

        class JsonFormatter
        {
            static string AnyTypeUrlField = "@type";
            static string AnyDiagnosticValueField = "@value";
            static string AnyWellKnownTypeValueField = "value";
            static string TypeUrlPrefix = "type.googleapis.com";
            static string NameValueSeparator = ": ";
            static string PropertySeparator = ", ";
            static string Hex = "0123456789abcdef";
            static /*0x0*/ Google.Protobuf.JsonFormatter <Default>k__BackingField;
            static /*0x8*/ Google.Protobuf.JsonFormatter diagnosticFormatter;
            static /*0x10*/ string[] CommonRepresentations;
            static /*0x18*/ System.Text.StringBuilder SB;
            static /*0x20*/ int ThreadId;
            static /*0x28*/ char[] CharArray;
            /*0x10*/ Google.Protobuf.JsonFormatter.Settings settings;

            static /*0x305b3a4*/ JsonFormatter();
            static /*0x305b34c*/ Google.Protobuf.JsonFormatter get_Default();
            static /*0x305d8b0*/ string ToDiagnosticString(Google.Protobuf.IMessage message);
            static /*0x305f370*/ string ToJsonName(string name);
            static /*0x305f524*/ string FromJsonName(string name);
            static /*0x305d958*/ void WriteNull(System.IO.TextWriter writer);
            static /*0x305ef20*/ bool IsDefaultValue(Google.Protobuf.Reflection.FieldDescriptor descriptor, object value);
            static /*0x305e3d4*/ void WriteString(System.IO.TextWriter writer, string text);
            static /*0x3062240*/ void HexEncodeUtf16CodeUnit(System.IO.TextWriter writer, char c);
            static /*0x30602f8*/ int UintToCharArray(uint value, ref char[] charArray);
            static /*0x30600f8*/ int IntToCharArray(int valueInt, ref char[] charArray);
            /*0x305cddc*/ JsonFormatter(Google.Protobuf.JsonFormatter.Settings settings);
            /*0x305ce64*/ bool get_DiagnosticOnly();
            /*0x305cec8*/ string Format(Google.Protobuf.IMessage message);
            /*0x305cf4c*/ void Format(Google.Protobuf.IMessage message, System.IO.TextWriter writer);
            /*0x305d708*/ void WriteMessage(System.IO.TextWriter writer, Google.Protobuf.IMessage message);
            /*0x305d9b4*/ bool WriteMessageFields(System.IO.TextWriter writer, Google.Protobuf.IMessage message, bool assumeFirstFieldWritten);
            /*0x305e2a4*/ bool ShouldFormatFieldValue(Google.Protobuf.IMessage message, Google.Protobuf.Reflection.FieldDescriptor field, object value);
            /*0x305e780*/ void WriteValue(System.IO.TextWriter writer, object value);
            /*0x305d120*/ void WriteWellKnownTypeValue(System.IO.TextWriter writer, Google.Protobuf.Reflection.MessageDescriptor descriptor, object value);
            /*0x30606b0*/ void WriteTimestamp(System.IO.TextWriter writer, Google.Protobuf.IMessage value);
            /*0x3060998*/ void WriteDuration(System.IO.TextWriter writer, Google.Protobuf.IMessage value);
            /*0x3060c80*/ void WriteFieldMask(System.IO.TextWriter writer, Google.Protobuf.IMessage value);
            /*0x306190c*/ void WriteAny(System.IO.TextWriter writer, Google.Protobuf.IMessage value);
            /*0x3061e20*/ void WriteDiagnosticOnlyAny(System.IO.TextWriter writer, Google.Protobuf.IMessage value);
            /*0x3060e68*/ void WriteStruct(System.IO.TextWriter writer, Google.Protobuf.IMessage message);
            /*0x30614d8*/ void WriteStructFieldValue(System.IO.TextWriter writer, Google.Protobuf.IMessage message);
            /*0x305fd64*/ void WriteList(System.IO.TextWriter writer, System.Collections.IList list);
            /*0x305f650*/ void WriteDictionary(System.IO.TextWriter writer, System.Collections.IDictionary dictionary);
            /*0x305ee8c*/ void WriteValue(System.IO.TextWriter writer, int value);
            /*0x305e704*/ void WriteValue(System.IO.TextWriter writer, bool value);

            class Settings
            {
                static /*0x0*/ Google.Protobuf.JsonFormatter.Settings <Default>k__BackingField;
                /*0x10*/ bool <FormatDefaultValues>k__BackingField;
                /*0x18*/ Google.Protobuf.Reflection.TypeRegistry <TypeRegistry>k__BackingField;
                /*0x20*/ bool <FormatEnumsAsIntegers>k__BackingField;

                static /*0x30623c0*/ Settings();
                static /*0x3062368*/ Google.Protobuf.JsonFormatter.Settings get_Default();
                /*0x3062428*/ Settings(bool formatDefaultValues);
                /*0x30624e4*/ Settings(bool formatDefaultValues, Google.Protobuf.Reflection.TypeRegistry typeRegistry);
                /*0x30624ec*/ Settings(bool formatDefaultValues, Google.Protobuf.Reflection.TypeRegistry typeRegistry, bool formatEnumsAsIntegers);
                /*0x30624cc*/ bool get_FormatDefaultValues();
                /*0x30624d4*/ Google.Protobuf.Reflection.TypeRegistry get_TypeRegistry();
                /*0x30624dc*/ bool get_FormatEnumsAsIntegers();
                /*0x30625b8*/ Google.Protobuf.JsonFormatter.Settings WithFormatDefaultValues(bool formatDefaultValues);
                /*0x306262c*/ Google.Protobuf.JsonFormatter.Settings WithTypeRegistry(Google.Protobuf.Reflection.TypeRegistry typeRegistry);
                /*0x30626a0*/ Google.Protobuf.JsonFormatter.Settings WithFormatEnumsAsIntegers(bool formatEnumsAsIntegers);
            }

            class OriginalEnumValueHelper
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.Dictionary<object, string>> dictionaries;

                static /*0x3062a40*/ OriginalEnumValueHelper();
                static /*0x306049c*/ string GetOriginalName(object value);
                static /*0x3062714*/ System.Collections.Generic.Dictionary<object, string> GetNameMapping(System.Type enumType);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.JsonFormatter.OriginalEnumValueHelper.<> <>9;
                    static /*0x8*/ System.Func<System.Reflection.FieldInfo, bool> <>9__2_0;
                    static /*0x10*/ System.Func<System.Reflection.FieldInfo, bool> <>9__2_1;
                    static /*0x18*/ System.Func<System.Reflection.FieldInfo, object> <>9__2_2;
                    static /*0x20*/ System.Func<System.Reflection.FieldInfo, string> <>9__2_3;

                    static /*0x3062ad8*/ <>c();
                    /*0x3062b40*/ <>c();
                    /*0x3062b48*/ bool <GetNameMapping>b__2_0(System.Reflection.FieldInfo f);
                    /*0x3062b60*/ bool <GetNameMapping>b__2_1(System.Reflection.FieldInfo f);
                    /*0x3062bf0*/ object <GetNameMapping>b__2_2(System.Reflection.FieldInfo f);
                    /*0x3062c14*/ string <GetNameMapping>b__2_3(System.Reflection.FieldInfo f);
                }
            }
        }

        class JsonParser
        {
            static /*0x0*/ System.Text.RegularExpressions.Regex TimestampRegex;
            static /*0x8*/ System.Text.RegularExpressions.Regex DurationRegex;
            static /*0x10*/ int[] SubsecondScalingFactors;
            static /*0x18*/ char[] FieldMaskPathSeparators;
            static /*0x20*/ Google.Protobuf.Reflection.EnumDescriptor NullValueDescriptor;
            static /*0x28*/ Google.Protobuf.JsonParser defaultInstance;
            static /*0x30*/ System.Collections.Generic.Dictionary<string, System.Action<Google.Protobuf.JsonParser, Google.Protobuf.IMessage, Google.Protobuf.JsonTokenizer>> WellKnownTypeHandlers;
            /*0x10*/ Google.Protobuf.JsonParser.Settings settings;

            static /*0x3067c00*/ JsonParser();
            static /*0x3062cb0*/ void MergeWrapperField(Google.Protobuf.JsonParser parser, Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer);
            static /*0x3063000*/ Google.Protobuf.JsonParser get_Default();
            static /*0x30638f8*/ bool IsGoogleProtobufValueField(Google.Protobuf.Reflection.FieldDescriptor field);
            static /*0x306399c*/ bool IsGoogleProtobufNullValueField(Google.Protobuf.Reflection.FieldDescriptor field);
            static /*0x3064434*/ object ParseMapKey(Google.Protobuf.Reflection.FieldDescriptor field, string keyText);
            static /*0x3064ee0*/ object ParseSingleNumberValue(Google.Protobuf.Reflection.FieldDescriptor field, Google.Protobuf.JsonToken token);
            static /*0x30663cc*/ void CheckInteger(double value);
            static /*0x3064890*/ object ParseSingleStringValue(Google.Protobuf.Reflection.FieldDescriptor field, string text);
            static /*0x3064868*/ Google.Protobuf.IMessage NewMessageForField(Google.Protobuf.Reflection.FieldDescriptor field);
            static /*0x1ffc854*/ T ParseNumericString<T>(string text, System.Func<string, System.Globalization.NumberStyles, System.IFormatProvider, T> parser);
            static /*0x30664b4*/ void ValidateInfinityAndNan(string text, bool isPositiveInfinity, bool isNegativeInfinity, bool isNaN);
            static /*0x30665c8*/ void MergeTimestamp(Google.Protobuf.IMessage message, Google.Protobuf.JsonToken token);
            static /*0x3066fcc*/ void MergeDuration(Google.Protobuf.IMessage message, Google.Protobuf.JsonToken token);
            static /*0x3067730*/ void MergeFieldMask(Google.Protobuf.IMessage message, Google.Protobuf.JsonToken token);
            static /*0x3067a24*/ string ToSnakeCase(string text);
            /*0x3063058*/ JsonParser(Google.Protobuf.JsonParser.Settings settings);
            /*0x30630e0*/ void Merge(Google.Protobuf.IMessage message, string json);
            /*0x3063154*/ void Merge(Google.Protobuf.IMessage message, System.IO.TextReader jsonReader);
            /*0x30632c8*/ void Merge(Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer);
            /*0x3062d90*/ void MergeField(Google.Protobuf.IMessage message, Google.Protobuf.Reflection.FieldDescriptor field, Google.Protobuf.JsonTokenizer tokenizer);
            /*0x3063dfc*/ void MergeRepeatedField(Google.Protobuf.IMessage message, Google.Protobuf.Reflection.FieldDescriptor field, Google.Protobuf.JsonTokenizer tokenizer);
            /*0x3063aec*/ void MergeMapField(Google.Protobuf.IMessage message, Google.Protobuf.Reflection.FieldDescriptor field, Google.Protobuf.JsonTokenizer tokenizer);
            /*0x30640a8*/ object ParseSingleValue(Google.Protobuf.Reflection.FieldDescriptor field, Google.Protobuf.JsonTokenizer tokenizer);
            /*0x1ffc854*/ T Parse<T>(string json);
            /*0x1ffc854*/ T Parse<T>(System.IO.TextReader jsonReader);
            /*0x30654c8*/ Google.Protobuf.IMessage Parse(string json, Google.Protobuf.Reflection.MessageDescriptor descriptor);
            /*0x30655bc*/ Google.Protobuf.IMessage Parse(System.IO.TextReader jsonReader, Google.Protobuf.Reflection.MessageDescriptor descriptor);
            /*0x30656a4*/ void MergeStructValue(Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer);
            /*0x3065c0c*/ void MergeStruct(Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer);
            /*0x3065d54*/ void MergeAny(Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer);
            /*0x30662b4*/ void MergeWellKnownTypeAnyBody(Google.Protobuf.IMessage body, Google.Protobuf.JsonTokenizer tokenizer);

            class Settings
            {
                static /*0x0*/ Google.Protobuf.JsonParser.Settings <Default>k__BackingField;
                /*0x10*/ int <RecursionLimit>k__BackingField;
                /*0x18*/ Google.Protobuf.Reflection.TypeRegistry <TypeRegistry>k__BackingField;
                /*0x20*/ bool <IgnoreUnknownFields>k__BackingField;

                static /*0x306878c*/ Settings();
                static /*0x3068734*/ Google.Protobuf.JsonParser.Settings get_Default();
                /*0x30688b0*/ Settings(int recursionLimit, Google.Protobuf.Reflection.TypeRegistry typeRegistry, bool ignoreUnknownFields);
                /*0x30687f4*/ Settings(int recursionLimit);
                /*0x3068958*/ Settings(int recursionLimit, Google.Protobuf.Reflection.TypeRegistry typeRegistry);
                /*0x3068898*/ int get_RecursionLimit();
                /*0x30688a0*/ Google.Protobuf.Reflection.TypeRegistry get_TypeRegistry();
                /*0x30688a8*/ bool get_IgnoreUnknownFields();
                /*0x3068960*/ Google.Protobuf.JsonParser.Settings WithIgnoreUnknownFields(bool ignoreUnknownFields);
                /*0x30689d4*/ Google.Protobuf.JsonParser.Settings WithRecursionLimit(int recursionLimit);
                /*0x3068a48*/ Google.Protobuf.JsonParser.Settings WithTypeRegistry(Google.Protobuf.Reflection.TypeRegistry typeRegistry);
            }

            class <>c
            {
                static /*0x0*/ Google.Protobuf.JsonParser.<> <>9;

                static /*0x3068b04*/ <>c();
                /*0x3068b6c*/ <>c();
                /*0x3068b74*/ bool <.cctor>b__41_0(Google.Protobuf.Reflection.EnumDescriptor ed);
                /*0x3068bf4*/ void <.cctor>b__41_1(Google.Protobuf.JsonParser parser, Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer);
                /*0x3068c68*/ void <.cctor>b__41_2(Google.Protobuf.JsonParser parser, Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer);
                /*0x3068cdc*/ void <.cctor>b__41_3(Google.Protobuf.JsonParser parser, Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer);
                /*0x3068cf8*/ void <.cctor>b__41_4(Google.Protobuf.JsonParser parser, Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer);
                /*0x3068dd8*/ void <.cctor>b__41_5(Google.Protobuf.JsonParser parser, Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer);
                /*0x3068df4*/ void <.cctor>b__41_6(Google.Protobuf.JsonParser parser, Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer);
                /*0x3068e10*/ void <.cctor>b__41_7(Google.Protobuf.JsonParser parser, Google.Protobuf.IMessage message, Google.Protobuf.JsonTokenizer tokenizer);
            }
        }

        class JsonToken : System.IEquatable<Google.Protobuf.JsonToken>
        {
            static /*0x0*/ Google.Protobuf.JsonToken _true;
            static /*0x8*/ Google.Protobuf.JsonToken _false;
            static /*0x10*/ Google.Protobuf.JsonToken _null;
            static /*0x18*/ Google.Protobuf.JsonToken startObject;
            static /*0x20*/ Google.Protobuf.JsonToken endObject;
            static /*0x28*/ Google.Protobuf.JsonToken startArray;
            static /*0x30*/ Google.Protobuf.JsonToken endArray;
            static /*0x38*/ Google.Protobuf.JsonToken endDocument;
            /*0x10*/ Google.Protobuf.JsonToken.TokenType type;
            /*0x18*/ string stringValue;
            /*0x20*/ double numberValue;

            static /*0x3069704*/ JsonToken();
            static /*0x3068e84*/ Google.Protobuf.JsonToken get_Null();
            static /*0x3068edc*/ Google.Protobuf.JsonToken get_False();
            static /*0x3068f34*/ Google.Protobuf.JsonToken get_True();
            static /*0x3068f8c*/ Google.Protobuf.JsonToken get_StartObject();
            static /*0x3068fe4*/ Google.Protobuf.JsonToken get_EndObject();
            static /*0x306903c*/ Google.Protobuf.JsonToken get_StartArray();
            static /*0x3069094*/ Google.Protobuf.JsonToken get_EndArray();
            static /*0x30690ec*/ Google.Protobuf.JsonToken get_EndDocument();
            static /*0x3069144*/ Google.Protobuf.JsonToken Name(string name);
            static /*0x3069204*/ Google.Protobuf.JsonToken Value(string value);
            static /*0x3069278*/ Google.Protobuf.JsonToken Value(double value);
            /*0x30691b8*/ JsonToken(Google.Protobuf.JsonToken.TokenType type, string stringValue, double numberValue);
            /*0x30692f4*/ Google.Protobuf.JsonToken.TokenType get_Type();
            /*0x30692fc*/ string get_StringValue();
            /*0x3069304*/ double get_NumberValue();
            /*0x306930c*/ bool Equals(object obj);
            /*0x30693dc*/ int GetHashCode();
            /*0x3069470*/ string ToString();
            /*0x3069370*/ bool Equals(Google.Protobuf.JsonToken other);

            enum TokenType
            {
                Null = 0,
                False = 1,
                True = 2,
                StringValue = 3,
                Number = 4,
                Name = 5,
                StartObject = 6,
                EndObject = 7,
                StartArray = 8,
                EndArray = 9,
                EndDocument = 10,
            }
        }

        class JsonTokenizer
        {
            /*0x10*/ Google.Protobuf.JsonToken bufferedToken;
            /*0x18*/ int <ObjectDepth>k__BackingField;

            static /*0x3063270*/ Google.Protobuf.JsonTokenizer FromTextReader(System.IO.TextReader reader);
            static /*0x306624c*/ Google.Protobuf.JsonTokenizer FromReplayedTokens(System.Collections.Generic.IList<Google.Protobuf.JsonToken> tokens, Google.Protobuf.JsonTokenizer continuation);
            /*0x3069ad0*/ JsonTokenizer();
            /*0x3069ac0*/ int get_ObjectDepth();
            /*0x3069ac8*/ void set_ObjectDepth(int value);
            /*0x3063a44*/ void PushBack(Google.Protobuf.JsonToken token);
            /*0x306380c*/ Google.Protobuf.JsonToken Next();
            /*0x1f30214*/ Google.Protobuf.JsonToken NextImpl();
            /*0x3063888*/ void SkipValue();

            class JsonReplayTokenizer : Google.Protobuf.JsonTokenizer
            {
                /*0x20*/ System.Collections.Generic.IList<Google.Protobuf.JsonToken> tokens;
                /*0x28*/ Google.Protobuf.JsonTokenizer nextTokenizer;
                /*0x30*/ int nextTokenIndex;

                /*0x3069a7c*/ JsonReplayTokenizer(System.Collections.Generic.IList<Google.Protobuf.JsonToken> tokens, Google.Protobuf.JsonTokenizer nextTokenizer);
                /*0x3069ad8*/ Google.Protobuf.JsonToken NextImpl();
            }

            class JsonTextTokenizer : Google.Protobuf.JsonTokenizer
            {
                static /*0x0*/ Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State ValueStates;
                /*0x20*/ System.Collections.Generic.Stack<Google.Protobuf.JsonTokenizer.JsonTextTokenizer.ContainerType> containerStack;
                /*0x28*/ Google.Protobuf.JsonTokenizer.JsonTextTokenizer.PushBackReader reader;
                /*0x30*/ Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State state;

                static /*0x306c0cc*/ JsonTextTokenizer();
                /*0x3069960*/ JsonTextTokenizer(System.IO.TextReader reader);
                /*0x3069c4c*/ Google.Protobuf.JsonToken NextImpl();
                /*0x306a610*/ void ValidateState(Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State validStates, string errorPrefix);
                /*0x306a6a4*/ string ReadString();
                /*0x306b528*/ char ReadEscapedCharacter();
                /*0x306b6c8*/ char ReadUnicodeEscape();
                /*0x306aaac*/ void ConsumeLiteral(string text);
                /*0x306ac10*/ double ReadNumber(char initialCharacter);
                /*0x306b918*/ System.Nullable<char> ReadInt(System.Text.StringBuilder builder);
                /*0x306ba14*/ System.Nullable<char> ReadFrac(System.Text.StringBuilder builder);
                /*0x306ba9c*/ System.Nullable<char> ReadExp(System.Text.StringBuilder builder);
                /*0x306bf98*/ System.Nullable<char> ConsumeDigits(System.Text.StringBuilder builder, ref int count);
                /*0x306a88c*/ void ValidateAndModifyStateForValue(string errorPrefix);
                /*0x306a98c*/ void PopContainer();

                enum ContainerType
                {
                    Document = 0,
                    Object = 1,
                    Array = 2,
                }

                enum State
                {
                    StartOfDocument = 1,
                    ExpectedEndOfDocument = 2,
                    ReaderExhausted = 4,
                    ObjectStart = 8,
                    ObjectBeforeColon = 16,
                    ObjectAfterColon = 32,
                    ObjectAfterProperty = 64,
                    ObjectAfterComma = 128,
                    ArrayStart = 256,
                    ArrayAfterValue = 512,
                    ArrayAfterComma = 1024,
                }

                class PushBackReader
                {
                    /*0x10*/ System.IO.TextReader reader;
                    /*0x18*/ System.Nullable<char> nextChar;

                    /*0x3069c1c*/ PushBackReader(System.IO.TextReader reader);
                    /*0x306a52c*/ System.Nullable<char> Read();
                    /*0x306b448*/ char ReadOrFail(string messageOnFailure);
                    /*0x306b81c*/ void PushBack(char c);
                    /*0x306b3ec*/ Google.Protobuf.InvalidJsonException CreateException(string message);
                }
            }
        }

        class LimitedInputStream : System.IO.Stream
        {
            /*0x28*/ System.IO.Stream proxied;
            /*0x30*/ int bytesLeft;

            /*0x306c118*/ LimitedInputStream(System.IO.Stream proxied, int size);
            /*0x306c198*/ bool get_CanRead();
            /*0x306c1a0*/ bool get_CanSeek();
            /*0x306c1a8*/ bool get_CanWrite();
            /*0x306c1b0*/ void Flush();
            /*0x306c1b4*/ long get_Length();
            /*0x306c1ec*/ long get_Position();
            /*0x306c224*/ void set_Position(long value);
            /*0x306c25c*/ int Read(byte[] buffer, int offset, int count);
            /*0x306c324*/ long Seek(long offset, System.IO.SeekOrigin origin);
            /*0x306c35c*/ void SetLength(long value);
            /*0x306c394*/ void Write(byte[] buffer, int offset, int count);
        }

        class MessageExtensions
        {
            static /*0x306c3cc*/ void MergeFrom(Google.Protobuf.IMessage message, byte[] data);
            static /*0x306c560*/ void MergeFrom(Google.Protobuf.IMessage message, byte[] data, int offset, int length);
            static /*0x305ac68*/ void MergeFrom(Google.Protobuf.IMessage message, Google.Protobuf.ByteString data);
            static /*0x306c868*/ void MergeFrom(Google.Protobuf.IMessage message, System.IO.Stream input);
            static /*0x306ca00*/ void MergeFrom(Google.Protobuf.IMessage message, System.ReadOnlySpan<byte> span);
            static /*0x306cb38*/ void MergeDelimitedFrom(Google.Protobuf.IMessage message, System.IO.Stream input);
            static /*0x306cc80*/ byte[] ToByteArray(Google.Protobuf.IMessage message);
            static /*0x306ce2c*/ void WriteTo(Google.Protobuf.IMessage message, System.IO.Stream output);
            static /*0x306cf90*/ void WriteDelimitedTo(Google.Protobuf.IMessage message, System.IO.Stream output);
            static /*0x305abc4*/ Google.Protobuf.ByteString ToByteString(Google.Protobuf.IMessage message);
            static /*0x306d15c*/ void WriteTo(Google.Protobuf.IMessage message, System.Buffers.IBufferWriter<byte> output);
            static /*0x306d290*/ void WriteTo(Google.Protobuf.IMessage message, System.Span<byte> output);
            static /*0x306d38c*/ bool IsInitialized(Google.Protobuf.IMessage message);
            static /*0x306c3d8*/ void MergeFrom(Google.Protobuf.IMessage message, byte[] data, bool discardUnknownFields, Google.Protobuf.ExtensionRegistry registry);
            static /*0x306c56c*/ void MergeFrom(Google.Protobuf.IMessage message, byte[] data, int offset, int length, bool discardUnknownFields, Google.Protobuf.ExtensionRegistry registry);
            static /*0x306c704*/ void MergeFrom(Google.Protobuf.IMessage message, Google.Protobuf.ByteString data, bool discardUnknownFields, Google.Protobuf.ExtensionRegistry registry);
            static /*0x306c874*/ void MergeFrom(Google.Protobuf.IMessage message, System.IO.Stream input, bool discardUnknownFields, Google.Protobuf.ExtensionRegistry registry);
            static /*0x306d614*/ void MergeFrom(Google.Protobuf.IMessage message, System.Buffers.ReadOnlySequence<byte> data, bool discardUnknownFields, Google.Protobuf.ExtensionRegistry registry);
            static /*0x306ca0c*/ void MergeFrom(Google.Protobuf.IMessage message, System.ReadOnlySpan<byte> data, bool discardUnknownFields, Google.Protobuf.ExtensionRegistry registry);
            static /*0x306cb44*/ void MergeDelimitedFrom(Google.Protobuf.IMessage message, System.IO.Stream input, bool discardUnknownFields, Google.Protobuf.ExtensionRegistry registry);

            class <>c__DisplayClass12_0
            {
                /*0x10*/ Google.Protobuf.IMessage message;

                /*0x306d60c*/ <>c__DisplayClass12_0();
                /*0x306d774*/ bool <IsInitialized>b__0(Google.Protobuf.Reflection.FieldDescriptor f);
            }
        }

        class MessageParser
        {
            /*0x10*/ System.Func<Google.Protobuf.IMessage> factory;
            /*0x18*/ bool <DiscardUnknownFields>k__BackingField;
            /*0x20*/ Google.Protobuf.ExtensionRegistry <Extensions>k__BackingField;

            /*0x306dc78*/ MessageParser(System.Func<Google.Protobuf.IMessage> factory, bool discardUnknownFields, Google.Protobuf.ExtensionRegistry extensions);
            /*0x306dc68*/ bool get_DiscardUnknownFields();
            /*0x306dc70*/ Google.Protobuf.ExtensionRegistry get_Extensions();
            /*0x305ab94*/ Google.Protobuf.IMessage CreateTemplate();
            /*0x306dccc*/ Google.Protobuf.IMessage ParseFrom(byte[] data);
            /*0x306dd2c*/ Google.Protobuf.IMessage ParseFrom(byte[] data, int offset, int length);
            /*0x305ac74*/ Google.Protobuf.IMessage ParseFrom(Google.Protobuf.ByteString data);
            /*0x306dda4*/ Google.Protobuf.IMessage ParseFrom(System.IO.Stream input);
            /*0x306de04*/ Google.Protobuf.IMessage ParseFrom(System.Buffers.ReadOnlySequence<byte> data);
            /*0x306de74*/ Google.Protobuf.IMessage ParseFrom(System.ReadOnlySpan<byte> data);
            /*0x306dedc*/ Google.Protobuf.IMessage ParseDelimitedFrom(System.IO.Stream input);
            /*0x306df3c*/ Google.Protobuf.IMessage ParseFrom(Google.Protobuf.CodedInputStream input);
            /*0x306e11c*/ Google.Protobuf.IMessage ParseJson(string json);
            /*0x306df98*/ void MergeFrom(Google.Protobuf.IMessage message, Google.Protobuf.CodedInputStream codedInput);
            /*0x306e1ec*/ Google.Protobuf.MessageParser WithDiscardUnknownFields(bool discardUnknownFields);
            /*0x306e260*/ Google.Protobuf.MessageParser WithExtensionRegistry(Google.Protobuf.ExtensionRegistry registry);
        }

        class MessageParser<T> : Google.Protobuf.MessageParser
        {
            /*0x0*/ System.Func<T> factory;

            /*0x1f30ebc*/ MessageParser(System.Func<T> factory);
            MessageParser(System.Func<T> factory, bool discardUnknownFields, Google.Protobuf.ExtensionRegistry extensions);
            /*0x1ffc854*/ T CreateTemplate();
            /*0x1ffc854*/ T ParseFrom(byte[] data);
            /*0x1ffc854*/ T ParseFrom(byte[] data, int offset, int length);
            /*0x1ffc854*/ T ParseFrom(Google.Protobuf.ByteString data);
            /*0x1ffc854*/ T ParseFrom(System.IO.Stream input);
            /*0x1ffc854*/ T ParseFrom(System.Buffers.ReadOnlySequence<byte> data);
            /*0x1ffc854*/ T ParseFrom(System.ReadOnlySpan<byte> data);
            /*0x1ffc854*/ T ParseDelimitedFrom(System.IO.Stream input);
            /*0x1ffc854*/ T ParseFrom(Google.Protobuf.CodedInputStream input);
            /*0x1ffc854*/ T ParseJson(string json);
            Google.Protobuf.MessageParser<T> WithDiscardUnknownFields(bool discardUnknownFields);
            /*0x1f302cc*/ Google.Protobuf.MessageParser<T> WithExtensionRegistry(Google.Protobuf.ExtensionRegistry registry);

            class <>c__DisplayClass2_0<T>
            {
                /*0x0*/ System.Func<T> factory;

                /*0x1f309e4*/ <>c__DisplayClass2_0();
                /*0x1f30214*/ Google.Protobuf.IMessage <.ctor>b__0();
            }
        }

        struct ObjectIntPair<T> : System.IEquatable<Google.Protobuf.ObjectIntPair<T>>
        {
            /*0x0*/ int number;
            /*0x0*/ T obj;

            /*0x1ffc854*/ ObjectIntPair(T obj, int number);
            /*0x1ffc854*/ bool Equals(Google.Protobuf.ObjectIntPair<T> other);
            /*0x1f2fec8*/ bool Equals(object obj);
            /*0x1f2ffc8*/ int GetHashCode();
        }

        struct ParseContext
        {
            static int DefaultRecursionLimit = 100;
            static int DefaultSizeLimit = 2147483647;
            /*0x10*/ System.ReadOnlySpan<byte> buffer;
            /*0x20*/ Google.Protobuf.ParserInternalState state;

            static /*0x306e89c*/ void Initialize(System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParseContext ctx);
            static /*0x306e920*/ void Initialize(System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state, ref Google.Protobuf.ParseContext ctx);
            static /*0x306e93c*/ void Initialize(Google.Protobuf.CodedInputStream input, ref Google.Protobuf.ParseContext ctx);
            static /*0x306e9b8*/ void Initialize(System.Buffers.ReadOnlySequence<byte> input, ref Google.Protobuf.ParseContext ctx);
            static /*0x306ea6c*/ void Initialize(System.Buffers.ReadOnlySequence<byte> input, int recursionLimit, ref Google.Protobuf.ParseContext ctx);
            /*0x306eb18*/ uint get_LastTag();
            /*0x306eb20*/ bool get_DiscardUnknownFields();
            /*0x306eb28*/ void set_DiscardUnknownFields(bool value);
            /*0x306eb30*/ Google.Protobuf.ExtensionRegistry get_ExtensionRegistry();
            /*0x306eb38*/ void set_ExtensionRegistry(Google.Protobuf.ExtensionRegistry value);
            /*0x306eb40*/ uint ReadTag();
            /*0x306ec48*/ double ReadDouble();
            /*0x306ed5c*/ float ReadFloat();
            /*0x306ee74*/ ulong ReadUInt64();
            /*0x306ef3c*/ long ReadInt64();
            /*0x306ef44*/ int ReadInt32();
            /*0x306f0c0*/ ulong ReadFixed64();
            /*0x306f1f0*/ uint ReadFixed32();
            /*0x306f320*/ bool ReadBool();
            /*0x306f33c*/ string ReadString();
            /*0x306f360*/ void ReadMessage(Google.Protobuf.IMessage message);
            /*0x306f4e8*/ void ReadGroup(Google.Protobuf.IMessage message);
            /*0x306f608*/ Google.Protobuf.ByteString ReadBytes();
            /*0x306f684*/ uint ReadUInt32();
            /*0x306f68c*/ int ReadEnum();
            /*0x306f694*/ int ReadSFixed32();
            /*0x306f69c*/ long ReadSFixed64();
            /*0x306f6a4*/ int ReadSInt32();
            /*0x306f6d4*/ long ReadSInt64();
            /*0x306f704*/ int ReadLength();
            /*0x306f70c*/ void CopyStateTo(Google.Protobuf.CodedInputStream input);
            /*0x306f750*/ void LoadStateFrom(Google.Protobuf.CodedInputStream input);
        }

        struct ParserInternalState
        {
            /*0x10*/ int bufferPos;
            /*0x14*/ int bufferSize;
            /*0x18*/ int bufferSizeAfterLimit;
            /*0x1c*/ int currentLimit;
            /*0x20*/ int totalBytesRetired;
            /*0x24*/ int recursionDepth;
            /*0x28*/ Google.Protobuf.SegmentedBufferHelper segmentedBufferHelper;
            /*0x70*/ uint lastTag;
            /*0x74*/ uint nextTag;
            /*0x78*/ bool hasNextTag;
            /*0x7c*/ int sizeLimit;
            /*0x80*/ int recursionLimit;
            /*0x84*/ bool <DiscardUnknownFields>k__BackingField;
            /*0x88*/ Google.Protobuf.ExtensionRegistry <ExtensionRegistry>k__BackingField;

            /*0x306f780*/ Google.Protobuf.CodedInputStream get_CodedInputStream();
            /*0x306f788*/ bool get_DiscardUnknownFields();
            /*0x306f790*/ void set_DiscardUnknownFields(bool value);
            /*0x306f798*/ Google.Protobuf.ExtensionRegistry get_ExtensionRegistry();
            /*0x306f7a0*/ void set_ExtensionRegistry(Google.Protobuf.ExtensionRegistry value);
        }

        class ParsingPrimitives
        {
            static int StackallocThreshold = 256;

            static /*0x306f7a8*/ int ParseLength(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x306eb48*/ uint ParseTag(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x306f7b4*/ bool MaybeConsumeTag(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state, uint tag);
            static /*0x306f80c*/ uint PeekTag(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x306ee7c*/ ulong ParseRawVarint64(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x306f84c*/ ulong ParseRawVarint64SlowPath(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x306ef4c*/ uint ParseRawVarint32(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x306f928*/ uint ParseRawVarint32SlowPath(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x306f1f8*/ uint ParseRawLittleEndian32(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x306fa18*/ uint ParseRawLittleEndian32SlowPath(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x306f0c8*/ ulong ParseRawLittleEndian64(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x306fa80*/ ulong ParseRawLittleEndian64SlowPath(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x306ec50*/ double ParseDouble(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x306ed64*/ float ParseFloat(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x306fb48*/ float ParseFloatSlow(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x306fc7c*/ byte[] ReadRawBytes(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state, int size);
            static /*0x306fe34*/ byte[] ReadRawBytesSlow(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state, int size);
            static /*0x3070950*/ void SkipRawBytes(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state, int size);
            static /*0x3070a10*/ string ReadString(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x3070a88*/ Google.Protobuf.ByteString ReadBytes(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x3070a3c*/ string ReadRawString(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state, int length);
            static /*0x3070b10*/ string ReadStringSlow(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state, int length);
            static /*0x30703d4*/ void ValidateCurrentLimit(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state, int size);
            static /*0x306f8c8*/ byte ReadRawByte(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x3070bc0*/ uint ReadRawVarint32(System.IO.Stream input);
            static /*0x306f6c4*/ int DecodeZigZag32(uint n);
            static /*0x306f6f4*/ long DecodeZigZag64(ulong n);
            static /*0x3070c88*/ bool IsDataAvailable(ref Google.Protobuf.ParserInternalState state, int size);
            static /*0x3070420*/ bool IsDataAvailableInSource(ref Google.Protobuf.ParserInternalState state, int size);
            static /*0x307071c*/ void ReadRawBytesIntoSpan(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state, int length, System.Span<byte> byteSpan);
        }

        class ParsingPrimitivesMessages
        {
            static /*0x0*/ byte[] ZeroLengthMessageStreamData;

            static /*0x307149c*/ ParsingPrimitivesMessages();
            static /*0x3070ca4*/ void SkipLastField(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x3070e34*/ void SkipGroup(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state, uint startGroupTag);
            static /*0x306f3c4*/ void ReadMessage(ref Google.Protobuf.ParseContext ctx, Google.Protobuf.IMessage message);
            static /*0x1ffc854*/ System.Collections.Generic.KeyValuePair<TKey, TValue> ReadMapEntry<TKey, TValue>(ref Google.Protobuf.ParseContext ctx, Google.Protobuf.Collections.MapField.Codec<TKey, TValue> codec);
            static /*0x306f54c*/ void ReadGroup(ref Google.Protobuf.ParseContext ctx, Google.Protobuf.IMessage message);
            static /*0x3071394*/ void ReadGroup(ref Google.Protobuf.ParseContext ctx, int fieldNumber, Google.Protobuf.UnknownFieldSet set);
            static /*0x3071034*/ void ReadRawMessage(ref Google.Protobuf.ParseContext ctx, Google.Protobuf.IMessage message);
            static /*0x30712b8*/ void CheckReadEndOfStreamTag(ref Google.Protobuf.ParserInternalState state);
            static /*0x307135c*/ void CheckLastTagWas(ref Google.Protobuf.ParserInternalState state, uint expectedTag);
        }

        class ParsingPrimitivesWrappers
        {
            static /*0x3071510*/ System.Nullable<float> ReadFloatWrapperLittleEndian(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x3071610*/ System.Nullable<float> ReadFloatWrapperSlow(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x3071728*/ System.Nullable<double> ReadDoubleWrapperLittleEndian(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x3071828*/ System.Nullable<double> ReadDoubleWrapperSlow(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x3071940*/ System.Nullable<bool> ReadBoolWrapper(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x3071bb0*/ System.Nullable<uint> ReadUInt32Wrapper(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x3071cbc*/ System.Nullable<uint> ReadUInt32WrapperSlow(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x3071dd0*/ System.Nullable<int> ReadInt32Wrapper(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x3071aa0*/ System.Nullable<ulong> ReadUInt64Wrapper(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x3071f38*/ System.Nullable<ulong> ReadUInt64WrapperSlow(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x3072050*/ System.Nullable<long> ReadInt64Wrapper(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x30721b0*/ System.Nullable<float> ReadFloatWrapperLittleEndian(ref Google.Protobuf.ParseContext ctx);
            static /*0x30721b8*/ System.Nullable<float> ReadFloatWrapperSlow(ref Google.Protobuf.ParseContext ctx);
            static /*0x30721c0*/ System.Nullable<double> ReadDoubleWrapperLittleEndian(ref Google.Protobuf.ParseContext ctx);
            static /*0x30721c8*/ System.Nullable<double> ReadDoubleWrapperSlow(ref Google.Protobuf.ParseContext ctx);
            static /*0x30721d0*/ System.Nullable<bool> ReadBoolWrapper(ref Google.Protobuf.ParseContext ctx);
            static /*0x30721d8*/ System.Nullable<uint> ReadUInt32Wrapper(ref Google.Protobuf.ParseContext ctx);
            static /*0x30721e0*/ System.Nullable<int> ReadInt32Wrapper(ref Google.Protobuf.ParseContext ctx);
            static /*0x30721e8*/ System.Nullable<ulong> ReadUInt64Wrapper(ref Google.Protobuf.ParseContext ctx);
            static /*0x30721f0*/ System.Nullable<ulong> ReadUInt64WrapperSlow(ref Google.Protobuf.ParseContext ctx);
            static /*0x30721f8*/ System.Nullable<long> ReadInt64Wrapper(ref Google.Protobuf.ParseContext ctx);
        }

        class ProtoPreconditions
        {
            static /*0x1ffc854*/ T CheckNotNull<T>(T value, string name);
            static /*0x1ffc854*/ T CheckNotNullUnconstrained<T>(T value, string name);
        }

        struct SegmentedBufferHelper
        {
            /*0x10*/ System.Nullable<int> totalLength;
            /*0x18*/ System.Buffers.ReadOnlySequence.Enumerator<byte> readOnlySequenceEnumerator;
            /*0x50*/ Google.Protobuf.CodedInputStream codedInputStream;

            static /*0x3072200*/ void Initialize(Google.Protobuf.CodedInputStream codedInputStream, ref Google.Protobuf.SegmentedBufferHelper instance);
            static /*0x30722b4*/ void Initialize(System.Buffers.ReadOnlySequence<byte> sequence, ref Google.Protobuf.SegmentedBufferHelper instance, ref System.ReadOnlySpan<byte> firstSpan);
            static /*0x3070fb8*/ int PushLimit(ref Google.Protobuf.ParserInternalState state, int byteLimit);
            static /*0x307131c*/ void PopLimit(ref Google.Protobuf.ParserInternalState state, int oldLimit);
            static /*0x30712ec*/ bool IsReachedLimit(ref Google.Protobuf.ParserInternalState state);
            static /*0x3072814*/ bool IsAtEnd(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state);
            static /*0x30727e0*/ void RecomputeBufferSizeAfterLimit(ref Google.Protobuf.ParserInternalState state);
            static /*0x3072850*/ void CheckCurrentBufferIsEmpty(ref Google.Protobuf.ParserInternalState state);
            /*0x3070938*/ bool RefillBuffer(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state, bool mustSucceed);
            /*0x30727d0*/ System.Nullable<int> get_TotalLength();
            /*0x30727d8*/ Google.Protobuf.CodedInputStream get_CodedInputStream();
            /*0x3072654*/ bool RefillFromReadOnlySequence(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state, bool mustSucceed);
            /*0x30724e8*/ bool RefillFromCodedInputStream(ref System.ReadOnlySpan<byte> buffer, ref Google.Protobuf.ParserInternalState state, bool mustSucceed);
        }

        class UnknownField
        {
            /*0x10*/ System.Collections.Generic.List<ulong> varintList;
            /*0x18*/ System.Collections.Generic.List<uint> fixed32List;
            /*0x20*/ System.Collections.Generic.List<ulong> fixed64List;
            /*0x28*/ System.Collections.Generic.List<Google.Protobuf.ByteString> lengthDelimitedList;
            /*0x30*/ System.Collections.Generic.List<Google.Protobuf.UnknownFieldSet> groupList;

            static /*0x1f32888*/ System.Collections.Generic.List<T> AddAll<T>(System.Collections.Generic.List<T> current, System.Collections.Generic.IList<T> extras);
            static /*0x1ffc854*/ System.Collections.Generic.List<T> Add<T>(System.Collections.Generic.List<T> list, T value);
            /*0x30728ac*/ UnknownField();
            /*0x30728b4*/ bool Equals(object other);
            /*0x30729d8*/ int GetHashCode();
            /*0x3072ae0*/ void WriteTo(int fieldNumber, ref Google.Protobuf.WriteContext output);
            /*0x3073884*/ int GetSerializedSize(int fieldNumber);
            /*0x30742c4*/ Google.Protobuf.UnknownField MergeFrom(Google.Protobuf.UnknownField other);
            /*0x3074414*/ Google.Protobuf.UnknownField AddVarint(ulong value);
            /*0x307448c*/ Google.Protobuf.UnknownField AddFixed32(uint value);
            /*0x3074504*/ Google.Protobuf.UnknownField AddFixed64(ulong value);
            /*0x307457c*/ Google.Protobuf.UnknownField AddLengthDelimited(Google.Protobuf.ByteString value);
            /*0x30745f0*/ Google.Protobuf.UnknownField AddGroup(Google.Protobuf.UnknownFieldSet value);
        }

        class UnknownFieldSet
        {
            /*0x10*/ System.Collections.Generic.IDictionary<int, Google.Protobuf.UnknownField> fields;
            /*0x18*/ int lastFieldNumber;
            /*0x20*/ Google.Protobuf.UnknownField lastField;

            static /*0x30756c4*/ Google.Protobuf.UnknownFieldSet MergeFieldFrom(Google.Protobuf.UnknownFieldSet unknownFields, Google.Protobuf.CodedInputStream input);
            static /*0x30757e0*/ Google.Protobuf.UnknownFieldSet MergeFieldFrom(Google.Protobuf.UnknownFieldSet unknownFields, ref Google.Protobuf.ParseContext ctx);
            static /*0x3075d60*/ Google.Protobuf.UnknownFieldSet MergeFrom(Google.Protobuf.UnknownFieldSet unknownFields, Google.Protobuf.UnknownFieldSet other);
            static /*0x3075dd4*/ Google.Protobuf.UnknownFieldSet Clone(Google.Protobuf.UnknownFieldSet other);
            /*0x3074664*/ UnknownFieldSet();
            /*0x30746ec*/ bool HasField(int field);
            /*0x3074798*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
            /*0x30734ac*/ void WriteTo(ref Google.Protobuf.WriteContext ctx);
            /*0x3073ee4*/ int CalculateSize();
            /*0x30748a8*/ bool Equals(object other);
            /*0x3074e34*/ int GetHashCode();
            /*0x3075238*/ Google.Protobuf.UnknownField GetOrAddField(int number);
            /*0x3075378*/ Google.Protobuf.UnknownFieldSet AddOrReplaceField(int number, Google.Protobuf.UnknownField field);
            /*0x307549c*/ bool MergeFieldFrom(ref Google.Protobuf.ParseContext ctx);
            /*0x3071460*/ void MergeGroupFrom(ref Google.Protobuf.ParseContext ctx);
            /*0x30758d8*/ Google.Protobuf.UnknownFieldSet MergeFrom(Google.Protobuf.UnknownFieldSet other);
            /*0x3075ca4*/ Google.Protobuf.UnknownFieldSet MergeField(int number, Google.Protobuf.UnknownField field);
        }

        class UnsafeByteOperations
        {
            static /*0x3075e48*/ Google.Protobuf.ByteString UnsafeWrap(System.ReadOnlyMemory<byte> bytes);
        }

        class WireFormat
        {
            static int TagTypeBits = 3;
            static uint TagTypeMask = 7;

            static /*0x3070e2c*/ Google.Protobuf.WireFormat.WireType GetTagWireType(uint tag);
            static /*0x306f7ac*/ int GetTagFieldNumber(uint tag);
            static /*0x3071354*/ uint MakeTag(int fieldNumber, Google.Protobuf.WireFormat.WireType wireType);

            enum WireType
            {
                Varint = 0,
                Fixed64 = 1,
                LengthDelimited = 2,
                StartGroup = 3,
                EndGroup = 4,
                Fixed32 = 5,
            }
        }

        struct WriteBufferHelper
        {
            /*0x10*/ System.Buffers.IBufferWriter<byte> bufferWriter;
            /*0x18*/ Google.Protobuf.CodedOutputStream codedOutputStream;

            static /*0x3075eb8*/ void Initialize(Google.Protobuf.CodedOutputStream codedOutputStream, ref Google.Protobuf.WriteBufferHelper instance);
            static /*0x3075ef0*/ void Initialize(System.Buffers.IBufferWriter<byte> bufferWriter, ref Google.Protobuf.WriteBufferHelper instance, ref System.Span<byte> buffer);
            static /*0x3075f30*/ void InitializeNonRefreshable(ref Google.Protobuf.WriteBufferHelper instance);
            static /*0x3075f58*/ void CheckNoSpaceLeft(ref Google.Protobuf.WriterInternalState state);
            static /*0x307600c*/ int GetSpaceLeft(ref Google.Protobuf.WriterInternalState state);
            static /*0x307607c*/ void RefreshBuffer(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state);
            static /*0x307621c*/ void Flush(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state);
            /*0x3075eb0*/ Google.Protobuf.CodedOutputStream get_CodedOutputStream();
        }

        struct WriteContext
        {
            /*0x10*/ System.Span<byte> buffer;
            /*0x20*/ Google.Protobuf.WriterInternalState state;

            static /*0x307630c*/ void Initialize(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, ref Google.Protobuf.WriteContext ctx);
            static /*0x3076328*/ void Initialize(Google.Protobuf.CodedOutputStream output, ref Google.Protobuf.WriteContext ctx);
            static /*0x30763b4*/ void Initialize(System.Buffers.IBufferWriter<byte> output, ref Google.Protobuf.WriteContext ctx);
            static /*0x3076428*/ void Initialize(ref System.Span<byte> buffer, ref Google.Protobuf.WriteContext ctx);
            /*0x307649c*/ void WriteDouble(double value);
            /*0x3076578*/ void WriteFloat(float value);
            /*0x307330c*/ void WriteUInt64(ulong value);
            /*0x30767a4*/ void WriteInt64(long value);
            /*0x3076878*/ void WriteInt32(int value);
            /*0x30733dc*/ void WriteFixed64(ulong value);
            /*0x3073374*/ void WriteFixed32(uint value);
            /*0x3076a4c*/ void WriteBool(bool value);
            /*0x3076b20*/ void WriteString(string value);
            /*0x3076d80*/ void WriteMessage(Google.Protobuf.IMessage value);
            /*0x3076d88*/ void WriteGroup(Google.Protobuf.IMessage value);
            /*0x3073444*/ void WriteBytes(Google.Protobuf.ByteString value);
            /*0x3076e38*/ void WriteUInt32(uint value);
            /*0x3076f0c*/ void WriteEnum(int value);
            /*0x3076fe0*/ void WriteSFixed32(int value);
            /*0x30770b4*/ void WriteSFixed64(long value);
            /*0x3077188*/ void WriteSInt32(int value);
            /*0x3077260*/ void WriteSInt64(long value);
            /*0x3077338*/ void WriteLength(int length);
            /*0x307329c*/ void WriteTag(int fieldNumber, Google.Protobuf.WireFormat.WireType type);
            /*0x3077484*/ void WriteTag(uint tag);
            /*0x3077558*/ void WriteRawTag(byte b1);
            /*0x307762c*/ void WriteRawTag(byte b1, byte b2);
            /*0x3077780*/ void WriteRawTag(byte b1, byte b2, byte b3);
            /*0x3077918*/ void WriteRawTag(byte b1, byte b2, byte b3, byte b4);
            /*0x3077ae0*/ void WriteRawTag(byte b1, byte b2, byte b3, byte b4, byte b5);
            /*0x3077cec*/ void Flush();
            /*0x3077dd0*/ void CheckNoSpaceLeft();
            /*0x3077ddc*/ void CopyStateTo(Google.Protobuf.CodedOutputStream output);
            /*0x3077e1c*/ void LoadStateFrom(Google.Protobuf.CodedOutputStream output);
        }

        struct WriterInternalState
        {
            /*0x10*/ int limit;
            /*0x14*/ int position;
            /*0x18*/ Google.Protobuf.WriteBufferHelper writeBufferHelper;

            /*0x3077e50*/ Google.Protobuf.CodedOutputStream get_CodedOutputStream();
        }

        class WritingPrimitives
        {
            static /*0x0*/ System.Text.Encoding Utf8Encoding;

            static /*0x30792dc*/ WritingPrimitives();
            static /*0x3076504*/ void WriteDouble(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, double value);
            static /*0x30765e0*/ void WriteFloat(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, float value);
            static /*0x3077fc4*/ void WriteFloatSlowPath(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, float value);
            static /*0x3076738*/ void WriteUInt64(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, ulong value);
            static /*0x307680c*/ void WriteInt64(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, long value);
            static /*0x30768e0*/ void WriteInt32(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, int value);
            static /*0x3076974*/ void WriteFixed64(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, ulong value);
            static /*0x30769e0*/ void WriteFixed32(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, uint value);
            static /*0x3076ab4*/ void WriteBool(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, bool value);
            static /*0x3076b88*/ void WriteString(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, string value);
            static /*0x3078720*/ void WriteAsciiStringToBuffer(System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, string value, int length);
            static /*0x30789fc*/ void NarrowFourUtf16CharsToAsciiAndWriteToBuffer(ref byte outputBuffer, ulong value);
            static /*0x30785cc*/ int WriteStringToBuffer(System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, string value);
            static /*0x3076d90*/ void WriteBytes(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, Google.Protobuf.ByteString value);
            static /*0x3076ea0*/ void WriteUInt32(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, uint value);
            static /*0x3076f74*/ void WriteEnum(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, int value);
            static /*0x3077048*/ void WriteSFixed32(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, int value);
            static /*0x307711c*/ void WriteSFixed64(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, long value);
            static /*0x30771f0*/ void WriteSInt32(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, int value);
            static /*0x30772c8*/ void WriteSInt64(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, long value);
            static /*0x30773a0*/ void WriteLength(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, int length);
            static /*0x307831c*/ void WriteRawVarint32(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, uint value);
            static /*0x30781d8*/ void WriteRawVarint64(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, ulong value);
            static /*0x3078460*/ void WriteRawLittleEndian32(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, uint value);
            static /*0x3078db8*/ void WriteRawLittleEndian32SlowPath(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, uint value);
            static /*0x3077e58*/ void WriteRawLittleEndian64(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, ulong value);
            static /*0x3078e54*/ void WriteRawLittleEndian64SlowPath(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, ulong value);
            static /*0x3078150*/ void WriteRawByte(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, byte value);
            static /*0x307896c*/ void WriteRawBytes(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, byte[] value);
            static /*0x3078f30*/ void WriteRawBytes(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, byte[] value, int offset, int length);
            static /*0x3078a1c*/ void WriteRawBytes(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, System.ReadOnlySpan<byte> value);
            static /*0x307740c*/ void WriteTag(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, int fieldNumber, Google.Protobuf.WireFormat.WireType type);
            static /*0x30774ec*/ void WriteTag(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, uint tag);
            static /*0x30775c0*/ void WriteRawTag(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, byte b1);
            static /*0x307769c*/ void WriteRawTag(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, byte b1, byte b2);
            static /*0x3079034*/ void WriteRawTagSlowPath(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, byte b1, byte b2);
            static /*0x3077800*/ void WriteRawTag(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, byte b1, byte b2, byte b3);
            static /*0x30790bc*/ void WriteRawTagSlowPath(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, byte b1, byte b2, byte b3);
            static /*0x30779a0*/ void WriteRawTag(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, byte b1, byte b2, byte b3, byte b4);
            static /*0x3079158*/ void WriteRawTagSlowPath(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, byte b1, byte b2, byte b3, byte b4);
            static /*0x3077b78*/ void WriteRawTag(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, byte b1, byte b2, byte b3, byte b4, byte b5);
            static /*0x3079210*/ void WriteRawTagSlowPath(ref System.Span<byte> buffer, ref Google.Protobuf.WriterInternalState state, byte b1, byte b2, byte b3, byte b4, byte b5);
            static /*0x3078da0*/ uint EncodeZigZag32(int n);
            static /*0x3078dac*/ ulong EncodeZigZag64(long n);
        }

        class WritingPrimitivesMessages
        {
            static /*0x3079338*/ void WriteMessage(ref Google.Protobuf.WriteContext ctx, Google.Protobuf.IMessage value);
            static /*0x3079428*/ void WriteGroup(ref Google.Protobuf.WriteContext ctx, Google.Protobuf.IMessage value);
            static /*0x3079430*/ void WriteRawMessage(ref Google.Protobuf.WriteContext ctx, Google.Protobuf.IMessage message);
        }

        namespace WellKnownTypes
        {
            class AnyReflection
            {
                static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

                static /*0x3079714*/ AnyReflection();
                static /*0x30796bc*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
            }

            class Any : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.Any>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.Any>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.Any>, Google.Protobuf.IBufferMessage
            {
                static int TypeUrlFieldNumber = 1;
                static int ValueFieldNumber = 2;
                static string DefaultPrefix = "type.googleapis.com";
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Any> _parser;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ string typeUrl_;
                /*0x20*/ Google.Protobuf.ByteString value_;

                static /*0x307a894*/ Any();
                static /*0x3079b20*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Any> get_Parser();
                static /*0x3079b78*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                static /*0x307a47c*/ string GetTypeUrl(Google.Protobuf.Reflection.MessageDescriptor descriptor, string prefix);
                static /*0x307a50c*/ string GetTypeName(string typeUrl);
                static /*0x307a684*/ Google.Protobuf.WellKnownTypes.Any Pack(Google.Protobuf.IMessage message);
                static /*0x307a6f0*/ Google.Protobuf.WellKnownTypes.Any Pack(Google.Protobuf.IMessage message, string typeUrlPrefix);
                /*0x3079cc8*/ Any();
                /*0x3079d94*/ Any(Google.Protobuf.WellKnownTypes.Any other);
                /*0x3079c7c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x3079df0*/ Google.Protobuf.WellKnownTypes.Any Clone();
                /*0x3079e48*/ string get_TypeUrl();
                /*0x3079e50*/ void set_TypeUrl(string value);
                /*0x3079ecc*/ Google.Protobuf.ByteString get_Value();
                /*0x3079ed4*/ void set_Value(Google.Protobuf.ByteString value);
                /*0x3079f50*/ bool Equals(object other);
                /*0x3079fb4*/ bool Equals(Google.Protobuf.WellKnownTypes.Any other);
                /*0x307a074*/ int GetHashCode();
                /*0x307a100*/ string ToString();
                /*0x307a158*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x307a178*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x307a204*/ int CalculateSize();
                /*0x307a2d0*/ void MergeFrom(Google.Protobuf.WellKnownTypes.Any other);
                /*0x307a350*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x307a370*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);
                /*0x307a5cc*/ bool Is(Google.Protobuf.Reflection.MessageDescriptor descriptor);
                /*0x1ffc854*/ T Unpack<T>();
                /*0x1f2fec8*/ bool TryUnpack<T>(ref T result);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.Any.<> <>9;

                    static /*0x307a9ac*/ <>c();
                    /*0x307aa14*/ <>c();
                    /*0x307aa1c*/ Google.Protobuf.WellKnownTypes.Any <.cctor>b__40_0();
                }
            }

            class ApiReflection
            {
                static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

                static /*0x307aac4*/ ApiReflection();
                static /*0x307aa6c*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
            }

            class Api : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.Api>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.Api>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.Api>, Google.Protobuf.IBufferMessage
            {
                static int NameFieldNumber = 1;
                static int MethodsFieldNumber = 2;
                static int OptionsFieldNumber = 3;
                static int VersionFieldNumber = 4;
                static int SourceContextFieldNumber = 5;
                static int MixinsFieldNumber = 6;
                static int SyntaxFieldNumber = 7;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Api> _parser;
                static /*0x8*/ Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Method> _repeated_methods_codec;
                static /*0x10*/ Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec;
                static /*0x18*/ Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Mixin> _repeated_mixins_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ string name_;
                /*0x20*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Method> methods_;
                /*0x28*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_;
                /*0x30*/ string version_;
                /*0x38*/ Google.Protobuf.WellKnownTypes.SourceContext sourceContext_;
                /*0x40*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Mixin> mixins_;
                /*0x48*/ Google.Protobuf.WellKnownTypes.Syntax syntax_;

                static /*0x307c8a8*/ Api();
                static /*0x307b688*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Api> get_Parser();
                static /*0x307b6e0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x307b830*/ Api();
                /*0x307b994*/ Api(Google.Protobuf.WellKnownTypes.Api other);
                /*0x307b7e4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x307bb28*/ Google.Protobuf.WellKnownTypes.Api Clone();
                /*0x307bb80*/ string get_Name();
                /*0x307bb88*/ void set_Name(string value);
                /*0x307bc04*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Method> get_Methods();
                /*0x307bc0c*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> get_Options();
                /*0x307bc14*/ string get_Version();
                /*0x307bc1c*/ void set_Version(string value);
                /*0x307bc98*/ Google.Protobuf.WellKnownTypes.SourceContext get_SourceContext();
                /*0x307bca0*/ void set_SourceContext(Google.Protobuf.WellKnownTypes.SourceContext value);
                /*0x307bca8*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Mixin> get_Mixins();
                /*0x307bcb0*/ Google.Protobuf.WellKnownTypes.Syntax get_Syntax();
                /*0x307bcb8*/ void set_Syntax(Google.Protobuf.WellKnownTypes.Syntax value);
                /*0x307bcc0*/ bool Equals(object other);
                /*0x307bd24*/ bool Equals(Google.Protobuf.WellKnownTypes.Api other);
                /*0x307be58*/ int GetHashCode();
                /*0x307bf6c*/ string ToString();
                /*0x307bfc4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x307bfe4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x307c1a8*/ int CalculateSize();
                /*0x307c3b4*/ void MergeFrom(Google.Protobuf.WellKnownTypes.Api other);
                /*0x307c5e0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x307c600*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.Api.<> <>9;

                    static /*0x307cb88*/ <>c();
                    /*0x307cbf0*/ <>c();
                    /*0x307cbf8*/ Google.Protobuf.WellKnownTypes.Api <.cctor>b__57_0();
                }
            }

            class Method : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.Method>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.Method>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.Method>, Google.Protobuf.IBufferMessage
            {
                static int NameFieldNumber = 1;
                static int RequestTypeUrlFieldNumber = 2;
                static int RequestStreamingFieldNumber = 3;
                static int ResponseTypeUrlFieldNumber = 4;
                static int ResponseStreamingFieldNumber = 5;
                static int OptionsFieldNumber = 6;
                static int SyntaxFieldNumber = 7;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Method> _parser;
                static /*0x8*/ Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ string name_;
                /*0x20*/ string requestTypeUrl_;
                /*0x28*/ bool requestStreaming_;
                /*0x30*/ string responseTypeUrl_;
                /*0x38*/ bool responseStreaming_;
                /*0x40*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_;
                /*0x48*/ Google.Protobuf.WellKnownTypes.Syntax syntax_;

                static /*0x307db2c*/ Method();
                static /*0x307cc48*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Method> get_Parser();
                static /*0x307cca0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x307cdf0*/ Method();
                /*0x307cebc*/ Method(Google.Protobuf.WellKnownTypes.Method other);
                /*0x307cda4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x307cf90*/ Google.Protobuf.WellKnownTypes.Method Clone();
                /*0x307cfe8*/ string get_Name();
                /*0x307cff0*/ void set_Name(string value);
                /*0x307d06c*/ string get_RequestTypeUrl();
                /*0x307d074*/ void set_RequestTypeUrl(string value);
                /*0x307d0f0*/ bool get_RequestStreaming();
                /*0x307d0f8*/ void set_RequestStreaming(bool value);
                /*0x307d100*/ string get_ResponseTypeUrl();
                /*0x307d108*/ void set_ResponseTypeUrl(string value);
                /*0x307d184*/ bool get_ResponseStreaming();
                /*0x307d18c*/ void set_ResponseStreaming(bool value);
                /*0x307d194*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> get_Options();
                /*0x307d19c*/ Google.Protobuf.WellKnownTypes.Syntax get_Syntax();
                /*0x307d1a4*/ void set_Syntax(Google.Protobuf.WellKnownTypes.Syntax value);
                /*0x307d1ac*/ bool Equals(object other);
                /*0x307d210*/ bool Equals(Google.Protobuf.WellKnownTypes.Method other);
                /*0x307d32c*/ int GetHashCode();
                /*0x307d478*/ string ToString();
                /*0x307d4d0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x307d4f0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x307d67c*/ int CalculateSize();
                /*0x307d824*/ void MergeFrom(Google.Protobuf.WellKnownTypes.Method other);
                /*0x307d91c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x307d93c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.Method.<> <>9;

                    static /*0x307dcdc*/ <>c();
                    /*0x307dd44*/ <>c();
                    /*0x307dd4c*/ Google.Protobuf.WellKnownTypes.Method <.cctor>b__57_0();
                }
            }

            class Mixin : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.Mixin>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.Mixin>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.Mixin>, Google.Protobuf.IBufferMessage
            {
                static int NameFieldNumber = 1;
                static int RootFieldNumber = 2;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Mixin> _parser;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ string name_;
                /*0x20*/ string root_;

                static /*0x307e5d8*/ Mixin();
                static /*0x307dd9c*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Mixin> get_Parser();
                static /*0x307ddf4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x307df44*/ Mixin();
                /*0x307dfac*/ Mixin(Google.Protobuf.WellKnownTypes.Mixin other);
                /*0x307def8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x307e008*/ Google.Protobuf.WellKnownTypes.Mixin Clone();
                /*0x307e060*/ string get_Name();
                /*0x307e068*/ void set_Name(string value);
                /*0x307e0e4*/ string get_Root();
                /*0x307e0ec*/ void set_Root(string value);
                /*0x307e168*/ bool Equals(object other);
                /*0x307e1cc*/ bool Equals(Google.Protobuf.WellKnownTypes.Mixin other);
                /*0x307e240*/ int GetHashCode();
                /*0x307e2c0*/ string ToString();
                /*0x307e318*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x307e338*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x307e3c0*/ int CalculateSize();
                /*0x307e48c*/ void MergeFrom(Google.Protobuf.WellKnownTypes.Mixin other);
                /*0x307e504*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x307e524*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.Mixin.<> <>9;

                    static /*0x307e6f0*/ <>c();
                    /*0x307e758*/ <>c();
                    /*0x307e760*/ Google.Protobuf.WellKnownTypes.Mixin <.cctor>b__32_0();
                }
            }

            class DurationReflection
            {
                static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

                static /*0x307e808*/ DurationReflection();
                static /*0x307e7b0*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
            }

            class Duration : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.Duration>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.Duration>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.Duration>, Google.Protobuf.IBufferMessage, Google.Protobuf.ICustomDiagnosticMessage
            {
                static int SecondsFieldNumber = 1;
                static int NanosFieldNumber = 2;
                static int NanosecondsPerSecond = 1000000000;
                static int NanosecondsPerTick = 100;
                static long MaxSeconds = 315576000000;
                static long MinSeconds = -315576000000;
                static int MaxNanoseconds = 999999999;
                static int MinNanoseconds = -999999999;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Duration> _parser;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ long seconds_;
                /*0x20*/ int nanos_;

                static /*0x307fde4*/ Duration();
                static /*0x307ec48*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Duration> get_Parser();
                static /*0x307eca0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                static /*0x307f274*/ bool IsNormalized(long seconds, int nanoseconds);
                static /*0x307f4a8*/ Google.Protobuf.WellKnownTypes.Duration FromTimeSpan(System.TimeSpan timeSpan);
                static /*0x307f574*/ Google.Protobuf.WellKnownTypes.Duration op_UnaryNegation(Google.Protobuf.WellKnownTypes.Duration value);
                static /*0x307f72c*/ Google.Protobuf.WellKnownTypes.Duration op_Addition(Google.Protobuf.WellKnownTypes.Duration lhs, Google.Protobuf.WellKnownTypes.Duration rhs);
                static /*0x307f860*/ Google.Protobuf.WellKnownTypes.Duration op_Subtraction(Google.Protobuf.WellKnownTypes.Duration lhs, Google.Protobuf.WellKnownTypes.Duration rhs);
                static /*0x307f658*/ Google.Protobuf.WellKnownTypes.Duration Normalize(long seconds, int nanoseconds);
                static /*0x307f994*/ string ToJson(long seconds, int nanoseconds, bool diagnosticOnly);
                static /*0x307fc14*/ void AppendNanoseconds(System.Text.StringBuilder builder, int nanos);
                /*0x307edf0*/ Duration();
                /*0x307edf8*/ Duration(Google.Protobuf.WellKnownTypes.Duration other);
                /*0x307eda4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x307ee44*/ Google.Protobuf.WellKnownTypes.Duration Clone();
                /*0x307ee9c*/ long get_Seconds();
                /*0x307eea4*/ void set_Seconds(long value);
                /*0x307eeac*/ int get_Nanos();
                /*0x307eeb4*/ void set_Nanos(int value);
                /*0x307eebc*/ bool Equals(object other);
                /*0x307ef20*/ bool Equals(Google.Protobuf.WellKnownTypes.Duration other);
                /*0x307ef6c*/ int GetHashCode();
                /*0x307efec*/ string ToString();
                /*0x307f044*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x307f064*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x307f0d8*/ int CalculateSize();
                /*0x307f188*/ void MergeFrom(Google.Protobuf.WellKnownTypes.Duration other);
                /*0x307f1d0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x307f1f0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);
                /*0x307f334*/ System.TimeSpan ToTimeSpan();
                /*0x307fd80*/ string ToDiagnosticString();

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.Duration.<> <>9;

                    static /*0x307fefc*/ <>c();
                    /*0x307ff64*/ <>c();
                    /*0x307ff6c*/ Google.Protobuf.WellKnownTypes.Duration <.cctor>b__48_0();
                }
            }

            class EmptyReflection
            {
                static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

                static /*0x3080018*/ EmptyReflection();
                static /*0x307ffc0*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
            }

            class Empty : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.Empty>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.Empty>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.Empty>, Google.Protobuf.IBufferMessage
            {
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Empty> _parser;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;

                static /*0x308080c*/ Empty();
                static /*0x30803b0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Empty> get_Parser();
                static /*0x3080408*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x3080558*/ Empty();
                /*0x3080560*/ Empty(Google.Protobuf.WellKnownTypes.Empty other);
                /*0x308050c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x30805a0*/ Google.Protobuf.WellKnownTypes.Empty Clone();
                /*0x30805f8*/ bool Equals(object other);
                /*0x308067c*/ bool Equals(Google.Protobuf.WellKnownTypes.Empty other);
                /*0x30806a8*/ int GetHashCode();
                /*0x30806d4*/ string ToString();
                /*0x308072c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x308074c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x308075c*/ int CalculateSize();
                /*0x308076c*/ void MergeFrom(Google.Protobuf.WellKnownTypes.Empty other);
                /*0x308079c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x30807bc*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.Empty.<> <>9;

                    static /*0x3080924*/ <>c();
                    /*0x308098c*/ <>c();
                    /*0x3080994*/ Google.Protobuf.WellKnownTypes.Empty <.cctor>b__22_0();
                }
            }

            class FieldMaskReflection
            {
                static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

                static /*0x3080a40*/ FieldMaskReflection();
                static /*0x30809e8*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
            }

            class FieldMask : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.FieldMask>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.FieldMask>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.FieldMask>, Google.Protobuf.IBufferMessage, Google.Protobuf.ICustomDiagnosticMessage
            {
                static int PathsFieldNumber = 1;
                static char FIELD_PATH_SEPARATOR = 44;
                static char FIELD_SEPARATOR_REGEX = 46;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.FieldMask> _parser;
                static /*0x8*/ Google.Protobuf.FieldCodec<string> _repeated_paths_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ Google.Protobuf.Collections.RepeatedField<string> paths_;

                static /*0x3082480*/ FieldMask();
                static /*0x3080e18*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.FieldMask> get_Parser();
                static /*0x3080e70*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                static /*0x30815b8*/ string ToJson(System.Collections.Generic.IList<string> paths, bool diagnosticOnly);
                static /*0x308199c*/ Google.Protobuf.WellKnownTypes.FieldMask FromString(string value);
                static /*0x1f327cc*/ Google.Protobuf.WellKnownTypes.FieldMask FromString<T>(string value);
                static /*0x1f327cc*/ Google.Protobuf.WellKnownTypes.FieldMask FromStringEnumerable<T>(System.Collections.Generic.IEnumerable<string> paths);
                static /*0x1f327cc*/ Google.Protobuf.WellKnownTypes.FieldMask FromFieldNumbers<T>(int[] fieldNumbers);
                static /*0x1f327cc*/ Google.Protobuf.WellKnownTypes.FieldMask FromFieldNumbers<T>(System.Collections.Generic.IEnumerable<int> fieldNumbers);
                static /*0x3081a74*/ bool IsPathValid(string input);
                static /*0x1f31840*/ bool IsValid<T>(Google.Protobuf.WellKnownTypes.FieldMask fieldMask);
                static /*0x3081b20*/ bool IsValid(Google.Protobuf.Reflection.MessageDescriptor descriptor, Google.Protobuf.WellKnownTypes.FieldMask fieldMask);
                static /*0x1f31840*/ bool IsValid<T>(string path);
                static /*0x3081e38*/ bool IsValid(Google.Protobuf.Reflection.MessageDescriptor descriptor, string path);
                /*0x3080fc0*/ FieldMask();
                /*0x3081048*/ FieldMask(Google.Protobuf.WellKnownTypes.FieldMask other);
                /*0x3080f74*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x30810d0*/ Google.Protobuf.WellKnownTypes.FieldMask Clone();
                /*0x3081128*/ Google.Protobuf.Collections.RepeatedField<string> get_Paths();
                /*0x3081130*/ bool Equals(object other);
                /*0x3081194*/ bool Equals(Google.Protobuf.WellKnownTypes.FieldMask other);
                /*0x3081224*/ int GetHashCode();
                /*0x3081270*/ string ToString();
                /*0x30812c8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x30812e8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x308139c*/ int CalculateSize();
                /*0x3081440*/ void MergeFrom(Google.Protobuf.WellKnownTypes.FieldMask other);
                /*0x30814c4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x30814e4*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);
                /*0x3081940*/ string ToDiagnosticString();
                /*0x3081f0c*/ Google.Protobuf.WellKnownTypes.FieldMask Normalize();
                /*0x3081f74*/ Google.Protobuf.WellKnownTypes.FieldMask Union(Google.Protobuf.WellKnownTypes.FieldMask[] otherMasks);
                /*0x3082034*/ Google.Protobuf.WellKnownTypes.FieldMask Intersection(Google.Protobuf.WellKnownTypes.FieldMask additionalMask);
                /*0x3082374*/ void Merge(Google.Protobuf.IMessage source, Google.Protobuf.IMessage destination, Google.Protobuf.WellKnownTypes.FieldMask.MergeOptions options);
                /*0x3082404*/ void Merge(Google.Protobuf.IMessage source, Google.Protobuf.IMessage destination);

                class MergeOptions
                {
                    /*0x10*/ bool <ReplaceMessageFields>k__BackingField;
                    /*0x11*/ bool <ReplaceRepeatedFields>k__BackingField;
                    /*0x12*/ bool <ReplacePrimitiveFields>k__BackingField;

                    /*0x3082478*/ MergeOptions();
                    /*0x30825bc*/ bool get_ReplaceMessageFields();
                    /*0x30825c4*/ void set_ReplaceMessageFields(bool value);
                    /*0x30825cc*/ bool get_ReplaceRepeatedFields();
                    /*0x30825d4*/ void set_ReplaceRepeatedFields(bool value);
                    /*0x30825dc*/ bool get_ReplacePrimitiveFields();
                    /*0x30825e4*/ void set_ReplacePrimitiveFields(bool value);
                }

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.FieldMask.<> <>9;
                    static /*0x8*/ System.Func<string, bool> <>9__29_0;

                    static /*0x30825ec*/ <>c();
                    /*0x3082654*/ <>c();
                    /*0x308265c*/ bool <ToJson>b__29_0(string p);
                    /*0x30826bc*/ Google.Protobuf.WellKnownTypes.FieldMask <.cctor>b__47_0();
                }
            }

            class SourceContextReflection
            {
                static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

                static /*0x3082764*/ SourceContextReflection();
                static /*0x308270c*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
            }

            class SourceContext : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.SourceContext>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.SourceContext>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.SourceContext>, Google.Protobuf.IBufferMessage
            {
                static int FileNameFieldNumber = 1;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.SourceContext> _parser;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ string fileName_;

                static /*0x3083114*/ SourceContext();
                static /*0x3082b70*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.SourceContext> get_Parser();
                static /*0x3082bc8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x307c528*/ SourceContext();
                /*0x3082d18*/ SourceContext(Google.Protobuf.WellKnownTypes.SourceContext other);
                /*0x3082ccc*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x307bad0*/ Google.Protobuf.WellKnownTypes.SourceContext Clone();
                /*0x3082d64*/ string get_FileName();
                /*0x3082d6c*/ void set_FileName(string value);
                /*0x3082de8*/ bool Equals(object other);
                /*0x3082e4c*/ bool Equals(Google.Protobuf.WellKnownTypes.SourceContext other);
                /*0x3082eac*/ int GetHashCode();
                /*0x3082f0c*/ string ToString();
                /*0x3082f64*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x3082f84*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x3082fe4*/ int CalculateSize();
                /*0x307c580*/ void MergeFrom(Google.Protobuf.WellKnownTypes.SourceContext other);
                /*0x3083074*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x3083094*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.SourceContext.<> <>9;

                    static /*0x308322c*/ <>c();
                    /*0x3083294*/ <>c();
                    /*0x308329c*/ Google.Protobuf.WellKnownTypes.SourceContext <.cctor>b__27_0();
                }
            }

            class StructReflection
            {
                static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

                static /*0x3083344*/ StructReflection();
                static /*0x30832ec*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
            }

            enum NullValue
            {
                NullValue = 0,
            }

            class Struct : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.Struct>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.Struct>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.Struct>, Google.Protobuf.IBufferMessage
            {
                static int FieldsFieldNumber = 1;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Struct> _parser;
                static /*0x8*/ Google.Protobuf.Collections.MapField.Codec<string, Google.Protobuf.WellKnownTypes.Value> _map_fields_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ Google.Protobuf.Collections.MapField<string, Google.Protobuf.WellKnownTypes.Value> fields_;

                static /*0x30844d8*/ Struct();
                static /*0x3083d38*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Struct> get_Parser();
                static /*0x3083d90*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x3083ee0*/ Struct();
                /*0x3083f68*/ Struct(Google.Protobuf.WellKnownTypes.Struct other);
                /*0x3083e94*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x3083ff0*/ Google.Protobuf.WellKnownTypes.Struct Clone();
                /*0x3084048*/ Google.Protobuf.Collections.MapField<string, Google.Protobuf.WellKnownTypes.Value> get_Fields();
                /*0x3084050*/ bool Equals(object other);
                /*0x30840b4*/ bool Equals(Google.Protobuf.WellKnownTypes.Struct other);
                /*0x3084144*/ int GetHashCode();
                /*0x3084190*/ string ToString();
                /*0x30841e8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x3084208*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x30842bc*/ int CalculateSize();
                /*0x3084360*/ void MergeFrom(Google.Protobuf.WellKnownTypes.Struct other);
                /*0x30843e4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x3084404*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.Struct.<> <>9;

                    static /*0x3084708*/ <>c();
                    /*0x3084770*/ <>c();
                    /*0x3084778*/ Google.Protobuf.WellKnownTypes.Struct <.cctor>b__27_0();
                }
            }

            class Value : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.Value>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.Value>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.Value>, Google.Protobuf.IBufferMessage
            {
                static int NullValueFieldNumber = 1;
                static int NumberValueFieldNumber = 2;
                static int StringValueFieldNumber = 3;
                static int BoolValueFieldNumber = 4;
                static int StructValueFieldNumber = 5;
                static int ListValueFieldNumber = 6;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Value> _parser;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ object kind_;
                /*0x20*/ Google.Protobuf.WellKnownTypes.Value.KindOneofCase kindCase_;

                static /*0x3086244*/ Value();
                static /*0x30847c8*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Value> get_Parser();
                static /*0x3084820*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                static /*0x3085e24*/ Google.Protobuf.WellKnownTypes.Value ForString(string value);
                static /*0x3085ed0*/ Google.Protobuf.WellKnownTypes.Value ForNumber(double value);
                static /*0x3085f70*/ Google.Protobuf.WellKnownTypes.Value ForBool(bool value);
                static /*0x308600c*/ Google.Protobuf.WellKnownTypes.Value ForNull();
                static /*0x3086074*/ Google.Protobuf.WellKnownTypes.Value ForList(Google.Protobuf.WellKnownTypes.Value[] values);
                static /*0x3086184*/ Google.Protobuf.WellKnownTypes.Value ForStruct(Google.Protobuf.WellKnownTypes.Struct value);
                /*0x3084970*/ Value();
                /*0x3084978*/ Value(Google.Protobuf.WellKnownTypes.Value other);
                /*0x3084924*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x3084ffc*/ Google.Protobuf.WellKnownTypes.Value Clone();
                /*0x3084b24*/ Google.Protobuf.WellKnownTypes.NullValue get_NullValue();
                /*0x3084ba8*/ void set_NullValue(Google.Protobuf.WellKnownTypes.NullValue value);
                /*0x3084c1c*/ double get_NumberValue();
                /*0x3084c70*/ void set_NumberValue(double value);
                /*0x3084cb8*/ string get_StringValue();
                /*0x3084d2c*/ void set_StringValue(string value);
                /*0x3084db4*/ bool get_BoolValue();
                /*0x3084e14*/ void set_BoolValue(bool value);
                /*0x3084e5c*/ Google.Protobuf.WellKnownTypes.Struct get_StructValue();
                /*0x3084ec8*/ void set_StructValue(Google.Protobuf.WellKnownTypes.Struct value);
                /*0x3084f00*/ Google.Protobuf.WellKnownTypes.ListValue get_ListValue();
                /*0x3084fc4*/ void set_ListValue(Google.Protobuf.WellKnownTypes.ListValue value);
                /*0x3085054*/ Google.Protobuf.WellKnownTypes.Value.KindOneofCase get_KindCase();
                /*0x308505c*/ void ClearKind();
                /*0x308506c*/ bool Equals(object other);
                /*0x30850d0*/ bool Equals(Google.Protobuf.WellKnownTypes.Value other);
                /*0x30852a0*/ int GetHashCode();
                /*0x3085480*/ string ToString();
                /*0x30854d8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x30854f8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x3085638*/ int CalculateSize();
                /*0x30857b8*/ void MergeFrom(Google.Protobuf.WellKnownTypes.Value other);
                /*0x3085b08*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x3085b28*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                enum KindOneofCase
                {
                    None = 0,
                    NullValue = 1,
                    NumberValue = 2,
                    StringValue = 3,
                    BoolValue = 4,
                    StructValue = 5,
                    ListValue = 6,
                }

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.Value.<> <>9;

                    static /*0x308635c*/ <>c();
                    /*0x30863c4*/ <>c();
                    /*0x30863cc*/ Google.Protobuf.WellKnownTypes.Value <.cctor>b__58_0();
                }
            }

            class ListValue : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.ListValue>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.ListValue>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.ListValue>, Google.Protobuf.IBufferMessage
            {
                static int ValuesFieldNumber = 1;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.ListValue> _parser;
                static /*0x8*/ Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Value> _repeated_values_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Value> values_;

                static /*0x3086a5c*/ ListValue();
                static /*0x3086420*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.ListValue> get_Parser();
                static /*0x3086478*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x30859fc*/ ListValue();
                /*0x30865c8*/ ListValue(Google.Protobuf.WellKnownTypes.ListValue other);
                /*0x308657c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x3084f6c*/ Google.Protobuf.WellKnownTypes.ListValue Clone();
                /*0x3086650*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Value> get_Values();
                /*0x3086658*/ bool Equals(object other);
                /*0x30866bc*/ bool Equals(Google.Protobuf.WellKnownTypes.ListValue other);
                /*0x308674c*/ int GetHashCode();
                /*0x3086798*/ string ToString();
                /*0x30867f0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x3086810*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x30868c4*/ int CalculateSize();
                /*0x3085a84*/ void MergeFrom(Google.Protobuf.WellKnownTypes.ListValue other);
                /*0x3086968*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x3086988*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.ListValue.<> <>9;

                    static /*0x3086c0c*/ <>c();
                    /*0x3086c74*/ <>c();
                    /*0x3086c7c*/ Google.Protobuf.WellKnownTypes.ListValue <.cctor>b__27_0();
                }
            }

            class TimeExtensions
            {
                static /*0x3086ccc*/ Google.Protobuf.WellKnownTypes.Timestamp ToTimestamp(System.DateTime dateTime);
                static /*0x3086eb0*/ Google.Protobuf.WellKnownTypes.Timestamp ToTimestamp(System.DateTimeOffset dateTimeOffset);
                static /*0x3086fac*/ Google.Protobuf.WellKnownTypes.Duration ToDuration(System.TimeSpan timeSpan);
            }

            class TimestampReflection
            {
                static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

                static /*0x3087058*/ TimestampReflection();
                static /*0x3087000*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
            }

            class Timestamp : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.Timestamp>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.Timestamp>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.Timestamp>, Google.Protobuf.IBufferMessage, Google.Protobuf.ICustomDiagnosticMessage, System.IComparable<Google.Protobuf.WellKnownTypes.Timestamp>
            {
                static int SecondsFieldNumber = 1;
                static int NanosFieldNumber = 2;
                static long BclSecondsAtUnixEpoch = 62135596800;
                static long UnixSecondsAtBclMaxValue = 253402300799;
                static long UnixSecondsAtBclMinValue = -62135596800;
                static int MaxNanos = 999999999;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Timestamp> _parser;
                static /*0x8*/ System.DateTime UnixEpoch;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ long seconds_;
                /*0x20*/ int nanos_;

                static /*0x30886c8*/ Timestamp();
                static /*0x3087498*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Timestamp> get_Parser();
                static /*0x30874f0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                static /*0x3087b44*/ bool IsNormalized(long seconds, int nanoseconds);
                static /*0x3087b78*/ Google.Protobuf.WellKnownTypes.Duration op_Subtraction(Google.Protobuf.WellKnownTypes.Timestamp lhs, Google.Protobuf.WellKnownTypes.Timestamp rhs);
                static /*0x3087cac*/ Google.Protobuf.WellKnownTypes.Timestamp op_Addition(Google.Protobuf.WellKnownTypes.Timestamp lhs, Google.Protobuf.WellKnownTypes.Duration rhs);
                static /*0x3087eac*/ Google.Protobuf.WellKnownTypes.Timestamp op_Subtraction(Google.Protobuf.WellKnownTypes.Timestamp lhs, Google.Protobuf.WellKnownTypes.Duration rhs);
                static /*0x3086d20*/ Google.Protobuf.WellKnownTypes.Timestamp FromDateTime(System.DateTime dateTime);
                static /*0x3086f14*/ Google.Protobuf.WellKnownTypes.Timestamp FromDateTimeOffset(System.DateTimeOffset dateTimeOffset);
                static /*0x3087df4*/ Google.Protobuf.WellKnownTypes.Timestamp Normalize(long seconds, int nanoseconds);
                static /*0x30881e8*/ string ToJson(long seconds, int nanoseconds, bool diagnosticOnly);
                static /*0x3088558*/ bool op_LessThan(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b);
                static /*0x3088574*/ bool op_GreaterThan(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b);
                static /*0x3088594*/ bool op_LessThanOrEqual(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b);
                static /*0x30885b4*/ bool op_GreaterThanOrEqual(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b);
                static /*0x3087a7c*/ bool op_Equality(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b);
                static /*0x30885d4*/ bool op_Inequality(Google.Protobuf.WellKnownTypes.Timestamp a, Google.Protobuf.WellKnownTypes.Timestamp b);
                /*0x3087640*/ Timestamp();
                /*0x3087648*/ Timestamp(Google.Protobuf.WellKnownTypes.Timestamp other);
                /*0x30875f4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x3087694*/ Google.Protobuf.WellKnownTypes.Timestamp Clone();
                /*0x30876ec*/ long get_Seconds();
                /*0x30876f4*/ void set_Seconds(long value);
                /*0x30876fc*/ int get_Nanos();
                /*0x3087704*/ void set_Nanos(int value);
                /*0x308770c*/ bool Equals(object other);
                /*0x3087770*/ bool Equals(Google.Protobuf.WellKnownTypes.Timestamp other);
                /*0x30877bc*/ int GetHashCode();
                /*0x308783c*/ string ToString();
                /*0x3087894*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x30878b4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x3087928*/ int CalculateSize();
                /*0x30879d8*/ void MergeFrom(Google.Protobuf.WellKnownTypes.Timestamp other);
                /*0x3087aa0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x3087ac0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);
                /*0x3087ff4*/ System.DateTime ToDateTime();
                /*0x308815c*/ System.DateTimeOffset ToDateTimeOffset();
                /*0x30884b8*/ int CompareTo(Google.Protobuf.WellKnownTypes.Timestamp other);
                /*0x3088664*/ string ToDiagnosticString();

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.Timestamp.<> <>9;

                    static /*0x3088824*/ <>c();
                    /*0x308888c*/ <>c();
                    /*0x3088894*/ Google.Protobuf.WellKnownTypes.Timestamp <.cctor>b__55_0();
                }
            }

            class TypeReflection
            {
                static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

                static /*0x3088940*/ TypeReflection();
                static /*0x30888e8*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
            }

            enum Syntax
            {
                Proto2 = 0,
                Proto3 = 1,
            }

            class Type : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.Type>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.Type>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.Type>, Google.Protobuf.IBufferMessage
            {
                static int NameFieldNumber = 1;
                static int FieldsFieldNumber = 2;
                static int OneofsFieldNumber = 3;
                static int OptionsFieldNumber = 4;
                static int SourceContextFieldNumber = 5;
                static int SyntaxFieldNumber = 6;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Type> _parser;
                static /*0x8*/ Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Field> _repeated_fields_codec;
                static /*0x10*/ Google.Protobuf.FieldCodec<string> _repeated_oneofs_codec;
                static /*0x18*/ Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ string name_;
                /*0x20*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Field> fields_;
                /*0x28*/ Google.Protobuf.Collections.RepeatedField<string> oneofs_;
                /*0x30*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_;
                /*0x38*/ Google.Protobuf.WellKnownTypes.SourceContext sourceContext_;
                /*0x40*/ Google.Protobuf.WellKnownTypes.Syntax syntax_;

                static /*0x308ad6c*/ Type();
                static /*0x3089dac*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Type> get_Parser();
                static /*0x3089e04*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x3089f54*/ Type();
                /*0x308a0a8*/ Type(Google.Protobuf.WellKnownTypes.Type other);
                /*0x3089f08*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x308a1dc*/ Google.Protobuf.WellKnownTypes.Type Clone();
                /*0x308a234*/ string get_Name();
                /*0x308a23c*/ void set_Name(string value);
                /*0x308a2b8*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Field> get_Fields();
                /*0x308a2c0*/ Google.Protobuf.Collections.RepeatedField<string> get_Oneofs();
                /*0x308a2c8*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> get_Options();
                /*0x308a2d0*/ Google.Protobuf.WellKnownTypes.SourceContext get_SourceContext();
                /*0x308a2d8*/ void set_SourceContext(Google.Protobuf.WellKnownTypes.SourceContext value);
                /*0x308a2e0*/ Google.Protobuf.WellKnownTypes.Syntax get_Syntax();
                /*0x308a2e8*/ void set_Syntax(Google.Protobuf.WellKnownTypes.Syntax value);
                /*0x308a2f0*/ bool Equals(object other);
                /*0x308a354*/ bool Equals(Google.Protobuf.WellKnownTypes.Type other);
                /*0x308a474*/ int GetHashCode();
                /*0x308a570*/ string ToString();
                /*0x308a5c8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x308a5e8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x308a788*/ int CalculateSize();
                /*0x308a958*/ void MergeFrom(Google.Protobuf.WellKnownTypes.Type other);
                /*0x308aac0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x308aae0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.Type.<> <>9;

                    static /*0x308afd8*/ <>c();
                    /*0x308b040*/ <>c();
                    /*0x308b048*/ Google.Protobuf.WellKnownTypes.Type <.cctor>b__52_0();
                }
            }

            class Field : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.Field>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.Field>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.Field>, Google.Protobuf.IBufferMessage
            {
                static int KindFieldNumber = 1;
                static int CardinalityFieldNumber = 2;
                static int NumberFieldNumber = 3;
                static int NameFieldNumber = 4;
                static int TypeUrlFieldNumber = 6;
                static int OneofIndexFieldNumber = 7;
                static int PackedFieldNumber = 8;
                static int OptionsFieldNumber = 9;
                static int JsonNameFieldNumber = 10;
                static int DefaultValueFieldNumber = 11;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Field> _parser;
                static /*0x8*/ Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ Google.Protobuf.WellKnownTypes.Field.Types.Kind kind_;
                /*0x1c*/ Google.Protobuf.WellKnownTypes.Field.Types.Cardinality cardinality_;
                /*0x20*/ int number_;
                /*0x28*/ string name_;
                /*0x30*/ string typeUrl_;
                /*0x38*/ int oneofIndex_;
                /*0x3c*/ bool packed_;
                /*0x40*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_;
                /*0x48*/ string jsonName_;
                /*0x50*/ string defaultValue_;

                static /*0x308c2fc*/ Field();
                static /*0x308b098*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Field> get_Parser();
                static /*0x308b0f0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x308b240*/ Field();
                /*0x308b31c*/ Field(Google.Protobuf.WellKnownTypes.Field other);
                /*0x308b1f4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x308b40c*/ Google.Protobuf.WellKnownTypes.Field Clone();
                /*0x308b464*/ Google.Protobuf.WellKnownTypes.Field.Types.Kind get_Kind();
                /*0x308b46c*/ void set_Kind(Google.Protobuf.WellKnownTypes.Field.Types.Kind value);
                /*0x308b474*/ Google.Protobuf.WellKnownTypes.Field.Types.Cardinality get_Cardinality();
                /*0x308b47c*/ void set_Cardinality(Google.Protobuf.WellKnownTypes.Field.Types.Cardinality value);
                /*0x308b484*/ int get_Number();
                /*0x308b48c*/ void set_Number(int value);
                /*0x308b494*/ string get_Name();
                /*0x308b49c*/ void set_Name(string value);
                /*0x308b518*/ string get_TypeUrl();
                /*0x308b520*/ void set_TypeUrl(string value);
                /*0x308b59c*/ int get_OneofIndex();
                /*0x308b5a4*/ void set_OneofIndex(int value);
                /*0x308b5ac*/ bool get_Packed();
                /*0x308b5b4*/ void set_Packed(bool value);
                /*0x308b5bc*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> get_Options();
                /*0x308b5c4*/ string get_JsonName();
                /*0x308b5cc*/ void set_JsonName(string value);
                /*0x308b648*/ string get_DefaultValue();
                /*0x308b650*/ void set_DefaultValue(string value);
                /*0x308b6cc*/ bool Equals(object other);
                /*0x308b730*/ bool Equals(Google.Protobuf.WellKnownTypes.Field other);
                /*0x308b870*/ int GetHashCode();
                /*0x308ba04*/ string ToString();
                /*0x308ba5c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x308ba7c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x308bcbc*/ int CalculateSize();
                /*0x308bf18*/ void MergeFrom(Google.Protobuf.WellKnownTypes.Field other);
                /*0x308c040*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x308c060*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class Types
                {
                    enum Kind
                    {
                        TypeUnknown = 0,
                        TypeDouble = 1,
                        TypeFloat = 2,
                        TypeInt64 = 3,
                        TypeUint64 = 4,
                        TypeInt32 = 5,
                        TypeFixed64 = 6,
                        TypeFixed32 = 7,
                        TypeBool = 8,
                        TypeString = 9,
                        TypeGroup = 10,
                        TypeMessage = 11,
                        TypeBytes = 12,
                        TypeUint32 = 13,
                        TypeEnum = 14,
                        TypeSfixed32 = 15,
                        TypeSfixed64 = 16,
                        TypeSint32 = 17,
                        TypeSint64 = 18,
                    }

                    enum Cardinality
                    {
                        Unknown = 0,
                        Optional = 1,
                        Required = 2,
                        Repeated = 3,
                    }
                }

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.Field.<> <>9;

                    static /*0x308c4ac*/ <>c();
                    /*0x308c514*/ <>c();
                    /*0x308c51c*/ Google.Protobuf.WellKnownTypes.Field <.cctor>b__73_0();
                }
            }

            class Enum : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.Enum>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.Enum>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.Enum>, Google.Protobuf.IBufferMessage
            {
                static int NameFieldNumber = 1;
                static int EnumvalueFieldNumber = 2;
                static int OptionsFieldNumber = 3;
                static int SourceContextFieldNumber = 4;
                static int SyntaxFieldNumber = 5;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Enum> _parser;
                static /*0x8*/ Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.EnumValue> _repeated_enumvalue_codec;
                static /*0x10*/ Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ string name_;
                /*0x20*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.EnumValue> enumvalue_;
                /*0x28*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_;
                /*0x30*/ Google.Protobuf.WellKnownTypes.SourceContext sourceContext_;
                /*0x38*/ Google.Protobuf.WellKnownTypes.Syntax syntax_;

                static /*0x308d358*/ Enum();
                static /*0x308c56c*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Enum> get_Parser();
                static /*0x308c5c4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x308c714*/ Enum();
                /*0x308c814*/ Enum(Google.Protobuf.WellKnownTypes.Enum other);
                /*0x308c6c8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x308c914*/ Google.Protobuf.WellKnownTypes.Enum Clone();
                /*0x308c96c*/ string get_Name();
                /*0x308c974*/ void set_Name(string value);
                /*0x308c9f0*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.EnumValue> get_Enumvalue();
                /*0x308c9f8*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> get_Options();
                /*0x308ca00*/ Google.Protobuf.WellKnownTypes.SourceContext get_SourceContext();
                /*0x308ca08*/ void set_SourceContext(Google.Protobuf.WellKnownTypes.SourceContext value);
                /*0x308ca10*/ Google.Protobuf.WellKnownTypes.Syntax get_Syntax();
                /*0x308ca18*/ void set_Syntax(Google.Protobuf.WellKnownTypes.Syntax value);
                /*0x308ca20*/ bool Equals(object other);
                /*0x308ca84*/ bool Equals(Google.Protobuf.WellKnownTypes.Enum other);
                /*0x308cb78*/ int GetHashCode();
                /*0x308cc48*/ string ToString();
                /*0x308cca0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x308ccc0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x308ce2c*/ int CalculateSize();
                /*0x308cfb4*/ void MergeFrom(Google.Protobuf.WellKnownTypes.Enum other);
                /*0x308d0f4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x308d114*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.Enum.<> <>9;

                    static /*0x308d5a0*/ <>c();
                    /*0x308d608*/ <>c();
                    /*0x308d610*/ Google.Protobuf.WellKnownTypes.Enum <.cctor>b__47_0();
                }
            }

            class EnumValue : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.EnumValue>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.EnumValue>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.EnumValue>, Google.Protobuf.IBufferMessage
            {
                static int NameFieldNumber = 1;
                static int NumberFieldNumber = 2;
                static int OptionsFieldNumber = 3;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.EnumValue> _parser;
                static /*0x8*/ Google.Protobuf.FieldCodec<Google.Protobuf.WellKnownTypes.Option> _repeated_options_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ string name_;
                /*0x20*/ int number_;
                /*0x28*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> options_;

                static /*0x308e0c0*/ EnumValue();
                static /*0x308d660*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.EnumValue> get_Parser();
                static /*0x308d6b8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x308d808*/ EnumValue();
                /*0x308d8b4*/ EnumValue(Google.Protobuf.WellKnownTypes.EnumValue other);
                /*0x308d7bc*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x308d95c*/ Google.Protobuf.WellKnownTypes.EnumValue Clone();
                /*0x308d9b4*/ string get_Name();
                /*0x308d9bc*/ void set_Name(string value);
                /*0x308da38*/ int get_Number();
                /*0x308da40*/ void set_Number(int value);
                /*0x308da48*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.WellKnownTypes.Option> get_Options();
                /*0x308da50*/ bool Equals(object other);
                /*0x308dab4*/ bool Equals(Google.Protobuf.WellKnownTypes.EnumValue other);
                /*0x308db68*/ int GetHashCode();
                /*0x308dc04*/ string ToString();
                /*0x308dc5c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x308dc7c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x308dd8c*/ int CalculateSize();
                /*0x308deb4*/ void MergeFrom(Google.Protobuf.WellKnownTypes.EnumValue other);
                /*0x308df60*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x308df80*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.EnumValue.<> <>9;

                    static /*0x308e270*/ <>c();
                    /*0x308e2d8*/ <>c();
                    /*0x308e2e0*/ Google.Protobuf.WellKnownTypes.EnumValue <.cctor>b__37_0();
                }
            }

            class Option : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.Option>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.Option>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.Option>, Google.Protobuf.IBufferMessage
            {
                static int NameFieldNumber = 1;
                static int ValueFieldNumber = 2;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Option> _parser;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ string name_;
                /*0x20*/ Google.Protobuf.WellKnownTypes.Any value_;

                static /*0x308ec04*/ Option();
                static /*0x308e330*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Option> get_Parser();
                static /*0x308e388*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x308e4d8*/ Option();
                /*0x308e530*/ Option(Google.Protobuf.WellKnownTypes.Option other);
                /*0x308e48c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x308e5a8*/ Google.Protobuf.WellKnownTypes.Option Clone();
                /*0x308e600*/ string get_Name();
                /*0x308e608*/ void set_Name(string value);
                /*0x308e684*/ Google.Protobuf.WellKnownTypes.Any get_Value();
                /*0x308e68c*/ void set_Value(Google.Protobuf.WellKnownTypes.Any value);
                /*0x308e694*/ bool Equals(object other);
                /*0x308e6f8*/ bool Equals(Google.Protobuf.WellKnownTypes.Option other);
                /*0x308e76c*/ int GetHashCode();
                /*0x308e7e4*/ string ToString();
                /*0x308e83c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x308e85c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x308e8f0*/ int CalculateSize();
                /*0x308e9b8*/ void MergeFrom(Google.Protobuf.WellKnownTypes.Option other);
                /*0x308ea9c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x308eabc*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.Option.<> <>9;

                    static /*0x308ed1c*/ <>c();
                    /*0x308ed84*/ <>c();
                    /*0x308ed8c*/ Google.Protobuf.WellKnownTypes.Option <.cctor>b__32_0();
                }
            }

            class WrappersReflection
            {
                static int WrapperValueFieldNumber = 1;
                static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

                static /*0x308ee34*/ WrappersReflection();
                static /*0x308eddc*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
            }

            class DoubleValue : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.DoubleValue>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.DoubleValue>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.DoubleValue>, Google.Protobuf.IBufferMessage
            {
                static int ValueFieldNumber = 1;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.DoubleValue> _parser;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ double value_;

                static /*0x30901c0*/ DoubleValue();
                static /*0x308fb4c*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.DoubleValue> get_Parser();
                static /*0x308fba4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x308fcf4*/ DoubleValue();
                /*0x308fcfc*/ DoubleValue(Google.Protobuf.WellKnownTypes.DoubleValue other);
                /*0x308fca8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x308fd48*/ Google.Protobuf.WellKnownTypes.DoubleValue Clone();
                /*0x308fda0*/ double get_Value();
                /*0x308fda8*/ void set_Value(double value);
                /*0x308fdb0*/ bool Equals(object other);
                /*0x308fe14*/ bool Equals(Google.Protobuf.WellKnownTypes.DoubleValue other);
                /*0x308ff00*/ int GetHashCode();
                /*0x308ffd8*/ string ToString();
                /*0x3090030*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x3090050*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x30900b4*/ int CalculateSize();
                /*0x30900e8*/ void MergeFrom(Google.Protobuf.WellKnownTypes.DoubleValue other);
                /*0x309012c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x309014c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.DoubleValue.<> <>9;

                    static /*0x30902d8*/ <>c();
                    /*0x3090340*/ <>c();
                    /*0x3090348*/ Google.Protobuf.WellKnownTypes.DoubleValue <.cctor>b__27_0();
                }
            }

            class FloatValue : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.FloatValue>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.FloatValue>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.FloatValue>, Google.Protobuf.IBufferMessage
            {
                static int ValueFieldNumber = 1;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.FloatValue> _parser;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ float value_;

                static /*0x3090a10*/ FloatValue();
                static /*0x309039c*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.FloatValue> get_Parser();
                static /*0x30903f4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x3090544*/ FloatValue();
                /*0x309054c*/ FloatValue(Google.Protobuf.WellKnownTypes.FloatValue other);
                /*0x30904f8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x3090598*/ Google.Protobuf.WellKnownTypes.FloatValue Clone();
                /*0x30905f0*/ float get_Value();
                /*0x30905f8*/ void set_Value(float value);
                /*0x3090600*/ bool Equals(object other);
                /*0x3090664*/ bool Equals(Google.Protobuf.WellKnownTypes.FloatValue other);
                /*0x3090750*/ int GetHashCode();
                /*0x3090828*/ string ToString();
                /*0x3090880*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x30908a0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x3090904*/ int CalculateSize();
                /*0x3090938*/ void MergeFrom(Google.Protobuf.WellKnownTypes.FloatValue other);
                /*0x309097c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x309099c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.FloatValue.<> <>9;

                    static /*0x3090b28*/ <>c();
                    /*0x3090b90*/ <>c();
                    /*0x3090b98*/ Google.Protobuf.WellKnownTypes.FloatValue <.cctor>b__27_0();
                }
            }

            class Int64Value : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.Int64Value>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.Int64Value>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.Int64Value>, Google.Protobuf.IBufferMessage
            {
                static int ValueFieldNumber = 1;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Int64Value> _parser;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ long value_;

                static /*0x3091174*/ Int64Value();
                static /*0x3090bec*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Int64Value> get_Parser();
                static /*0x3090c44*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x3090d94*/ Int64Value();
                /*0x3090d9c*/ Int64Value(Google.Protobuf.WellKnownTypes.Int64Value other);
                /*0x3090d48*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x3090de4*/ Google.Protobuf.WellKnownTypes.Int64Value Clone();
                /*0x3090e3c*/ long get_Value();
                /*0x3090e44*/ void set_Value(long value);
                /*0x3090e4c*/ bool Equals(object other);
                /*0x3090eb0*/ bool Equals(Google.Protobuf.WellKnownTypes.Int64Value other);
                /*0x3090eec*/ int GetHashCode();
                /*0x3090f48*/ string ToString();
                /*0x3090fa0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x3090fc0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x3091020*/ int CalculateSize();
                /*0x30910a0*/ void MergeFrom(Google.Protobuf.WellKnownTypes.Int64Value other);
                /*0x30910e0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x3091100*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.Int64Value.<> <>9;

                    static /*0x309128c*/ <>c();
                    /*0x30912f4*/ <>c();
                    /*0x30912fc*/ Google.Protobuf.WellKnownTypes.Int64Value <.cctor>b__27_0();
                }
            }

            class UInt64Value : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.UInt64Value>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.UInt64Value>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.UInt64Value>, Google.Protobuf.IBufferMessage
            {
                static int ValueFieldNumber = 1;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.UInt64Value> _parser;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ ulong value_;

                static /*0x30918d8*/ UInt64Value();
                static /*0x3091350*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.UInt64Value> get_Parser();
                static /*0x30913a8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x30914f8*/ UInt64Value();
                /*0x3091500*/ UInt64Value(Google.Protobuf.WellKnownTypes.UInt64Value other);
                /*0x30914ac*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x3091548*/ Google.Protobuf.WellKnownTypes.UInt64Value Clone();
                /*0x30915a0*/ ulong get_Value();
                /*0x30915a8*/ void set_Value(ulong value);
                /*0x30915b0*/ bool Equals(object other);
                /*0x3091614*/ bool Equals(Google.Protobuf.WellKnownTypes.UInt64Value other);
                /*0x3091650*/ int GetHashCode();
                /*0x30916ac*/ string ToString();
                /*0x3091704*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x3091724*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x3091784*/ int CalculateSize();
                /*0x3091804*/ void MergeFrom(Google.Protobuf.WellKnownTypes.UInt64Value other);
                /*0x3091844*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x3091864*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.UInt64Value.<> <>9;

                    static /*0x30919f0*/ <>c();
                    /*0x3091a58*/ <>c();
                    /*0x3091a60*/ Google.Protobuf.WellKnownTypes.UInt64Value <.cctor>b__27_0();
                }
            }

            class Int32Value : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.Int32Value>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.Int32Value>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.Int32Value>, Google.Protobuf.IBufferMessage
            {
                static int ValueFieldNumber = 1;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Int32Value> _parser;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ int value_;

                static /*0x3092040*/ Int32Value();
                static /*0x3091ab4*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.Int32Value> get_Parser();
                static /*0x3091b0c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x3091c5c*/ Int32Value();
                /*0x3091c64*/ Int32Value(Google.Protobuf.WellKnownTypes.Int32Value other);
                /*0x3091c10*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x3091cb0*/ Google.Protobuf.WellKnownTypes.Int32Value Clone();
                /*0x3091d08*/ int get_Value();
                /*0x3091d10*/ void set_Value(int value);
                /*0x3091d18*/ bool Equals(object other);
                /*0x3091d7c*/ bool Equals(Google.Protobuf.WellKnownTypes.Int32Value other);
                /*0x3091db8*/ int GetHashCode();
                /*0x3091e14*/ string ToString();
                /*0x3091e6c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x3091e8c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x3091eec*/ int CalculateSize();
                /*0x3091f6c*/ void MergeFrom(Google.Protobuf.WellKnownTypes.Int32Value other);
                /*0x3091fac*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x3091fcc*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.Int32Value.<> <>9;

                    static /*0x3092158*/ <>c();
                    /*0x30921c0*/ <>c();
                    /*0x30921c8*/ Google.Protobuf.WellKnownTypes.Int32Value <.cctor>b__27_0();
                }
            }

            class UInt32Value : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.UInt32Value>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.UInt32Value>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.UInt32Value>, Google.Protobuf.IBufferMessage
            {
                static int ValueFieldNumber = 1;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.UInt32Value> _parser;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ uint value_;

                static /*0x30927a8*/ UInt32Value();
                static /*0x309221c*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.UInt32Value> get_Parser();
                static /*0x3092274*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x30923c4*/ UInt32Value();
                /*0x30923cc*/ UInt32Value(Google.Protobuf.WellKnownTypes.UInt32Value other);
                /*0x3092378*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x3092418*/ Google.Protobuf.WellKnownTypes.UInt32Value Clone();
                /*0x3092470*/ uint get_Value();
                /*0x3092478*/ void set_Value(uint value);
                /*0x3092480*/ bool Equals(object other);
                /*0x30924e4*/ bool Equals(Google.Protobuf.WellKnownTypes.UInt32Value other);
                /*0x3092520*/ int GetHashCode();
                /*0x309257c*/ string ToString();
                /*0x30925d4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x30925f4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x3092654*/ int CalculateSize();
                /*0x30926d4*/ void MergeFrom(Google.Protobuf.WellKnownTypes.UInt32Value other);
                /*0x3092714*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x3092734*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.UInt32Value.<> <>9;

                    static /*0x30928c0*/ <>c();
                    /*0x3092928*/ <>c();
                    /*0x3092930*/ Google.Protobuf.WellKnownTypes.UInt32Value <.cctor>b__27_0();
                }
            }

            class BoolValue : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.BoolValue>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.BoolValue>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.BoolValue>, Google.Protobuf.IBufferMessage
            {
                static int ValueFieldNumber = 1;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.BoolValue> _parser;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ bool value_;

                static /*0x3092eec*/ BoolValue();
                static /*0x3092984*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.BoolValue> get_Parser();
                static /*0x30929dc*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x3092b2c*/ BoolValue();
                /*0x3092b34*/ BoolValue(Google.Protobuf.WellKnownTypes.BoolValue other);
                /*0x3092ae0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x3092b80*/ Google.Protobuf.WellKnownTypes.BoolValue Clone();
                /*0x3092bd8*/ bool get_Value();
                /*0x3092be0*/ void set_Value(bool value);
                /*0x3092be8*/ bool Equals(object other);
                /*0x3092c4c*/ bool Equals(Google.Protobuf.WellKnownTypes.BoolValue other);
                /*0x3092c98*/ int GetHashCode();
                /*0x3092d08*/ string ToString();
                /*0x3092d60*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x3092d80*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x3092de0*/ int CalculateSize();
                /*0x3092e0c*/ void MergeFrom(Google.Protobuf.WellKnownTypes.BoolValue other);
                /*0x3092e50*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x3092e70*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.BoolValue.<> <>9;

                    static /*0x3093004*/ <>c();
                    /*0x309306c*/ <>c();
                    /*0x3093074*/ Google.Protobuf.WellKnownTypes.BoolValue <.cctor>b__27_0();
                }
            }

            class StringValue : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.StringValue>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.StringValue>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.StringValue>, Google.Protobuf.IBufferMessage
            {
                static int ValueFieldNumber = 1;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.StringValue> _parser;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ string value_;

                static /*0x30937a4*/ StringValue();
                static /*0x30930c8*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.StringValue> get_Parser();
                static /*0x3093120*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x3093270*/ StringValue();
                /*0x30932c8*/ StringValue(Google.Protobuf.WellKnownTypes.StringValue other);
                /*0x3093224*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x3093318*/ Google.Protobuf.WellKnownTypes.StringValue Clone();
                /*0x3093370*/ string get_Value();
                /*0x3093378*/ void set_Value(string value);
                /*0x30933f4*/ bool Equals(object other);
                /*0x3093458*/ bool Equals(Google.Protobuf.WellKnownTypes.StringValue other);
                /*0x30934b8*/ int GetHashCode();
                /*0x3093518*/ string ToString();
                /*0x3093570*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x3093590*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x30935fc*/ int CalculateSize();
                /*0x3093690*/ void MergeFrom(Google.Protobuf.WellKnownTypes.StringValue other);
                /*0x30936f4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x3093714*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.StringValue.<> <>9;

                    static /*0x30938bc*/ <>c();
                    /*0x3093924*/ <>c();
                    /*0x309392c*/ Google.Protobuf.WellKnownTypes.StringValue <.cctor>b__27_0();
                }
            }

            class BytesValue : Google.Protobuf.IMessage<Google.Protobuf.WellKnownTypes.BytesValue>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.WellKnownTypes.BytesValue>, Google.Protobuf.IDeepCloneable<Google.Protobuf.WellKnownTypes.BytesValue>, Google.Protobuf.IBufferMessage
            {
                static int ValueFieldNumber = 1;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.BytesValue> _parser;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ Google.Protobuf.ByteString value_;

                static /*0x3094164*/ BytesValue();
                static /*0x309397c*/ Google.Protobuf.MessageParser<Google.Protobuf.WellKnownTypes.BytesValue> get_Parser();
                static /*0x30939d4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x3093b24*/ BytesValue();
                /*0x3093bc4*/ BytesValue(Google.Protobuf.WellKnownTypes.BytesValue other);
                /*0x3093ad8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x3093c14*/ Google.Protobuf.WellKnownTypes.BytesValue Clone();
                /*0x3093c6c*/ Google.Protobuf.ByteString get_Value();
                /*0x3093c74*/ void set_Value(Google.Protobuf.ByteString value);
                /*0x3093cf0*/ bool Equals(object other);
                /*0x3093d54*/ bool Equals(Google.Protobuf.WellKnownTypes.BytesValue other);
                /*0x3093e00*/ int GetHashCode();
                /*0x3093e6c*/ string ToString();
                /*0x3093ec4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x3093ee4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x3093f54*/ int CalculateSize();
                /*0x3093ff0*/ void MergeFrom(Google.Protobuf.WellKnownTypes.BytesValue other);
                /*0x309405c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x309407c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.WellKnownTypes.BytesValue.<> <>9;

                    static /*0x309427c*/ <>c();
                    /*0x30942e4*/ <>c();
                    /*0x30942ec*/ Google.Protobuf.WellKnownTypes.BytesValue <.cctor>b__27_0();
                }
            }
        }

        namespace Reflection
        {
            class CustomOptions
            {
                static /*0x0*/ object[] EmptyParameters;
                /*0x10*/ System.Collections.Generic.IDictionary<int, Google.Protobuf.IExtensionValue> values;

                static /*0x309479c*/ CustomOptions();
                /*0x309433c*/ CustomOptions(System.Collections.Generic.IDictionary<int, Google.Protobuf.IExtensionValue> values);
                /*0x309436c*/ bool TryGetBool(int field, ref bool value);
                /*0x30943cc*/ bool TryGetInt32(int field, ref int value);
                /*0x309442c*/ bool TryGetInt64(int field, ref long value);
                /*0x309448c*/ bool TryGetFixed32(int field, ref uint value);
                /*0x30944f0*/ bool TryGetFixed64(int field, ref ulong value);
                /*0x3094554*/ bool TryGetSFixed32(int field, ref int value);
                /*0x3094558*/ bool TryGetSFixed64(int field, ref long value);
                /*0x309455c*/ bool TryGetSInt32(int field, ref int value);
                /*0x30945bc*/ bool TryGetSInt64(int field, ref long value);
                /*0x3094490*/ bool TryGetUInt32(int field, ref uint value);
                /*0x30944f4*/ bool TryGetUInt64(int field, ref ulong value);
                /*0x309461c*/ bool TryGetFloat(int field, ref float value);
                /*0x309467c*/ bool TryGetDouble(int field, ref double value);
                /*0x30946dc*/ bool TryGetString(int field, ref string value);
                /*0x309473c*/ bool TryGetBytes(int field, ref Google.Protobuf.ByteString value);
                /*0x1f2fe80*/ bool TryGetMessage<T>(int field, ref T value);
                /*0x1f2fe80*/ bool TryGetPrimitiveValue<T>(int field, ref T value);

                class <>c__18<T>
                {
                    static /*0x0*/ Google.Protobuf.Reflection.CustomOptions.<>c__18<T> <>9;
                    static /*0x0*/ System.Func<T, Google.Protobuf.ByteString> <>9__18_0;
                    static /*0x0*/ System.Func<T, Google.Protobuf.ByteString, T> <>9__18_1;

                    static /*0x1f33998*/ <>c__18();
                    /*0x1f309e4*/ <>c__18();
                    /*0x1ffc854*/ Google.Protobuf.ByteString <TryGetMessage>b__18_0(T v);
                    /*0x1ffc854*/ T <TryGetMessage>b__18_1(T t, Google.Protobuf.ByteString b);
                }
            }

            class DescriptorReflection
            {
                static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor descriptor;

                static /*0x3094868*/ DescriptorReflection();
                static /*0x3094810*/ Google.Protobuf.Reflection.FileDescriptor get_Descriptor();
            }

            class FileDescriptorSet : Google.Protobuf.IMessage<Google.Protobuf.Reflection.FileDescriptorSet>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.FileDescriptorSet>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.FileDescriptorSet>, Google.Protobuf.IBufferMessage
            {
                static int FileFieldNumber = 1;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FileDescriptorSet> _parser;
                static /*0x8*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.FileDescriptorProto> _repeated_file_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FileDescriptorProto> file_;

                static /*0x3099d4c*/ FileDescriptorSet();
                static /*0x3099594*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FileDescriptorSet> get_Parser();
                static /*0x30995ec*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x309973c*/ FileDescriptorSet();
                /*0x30997c4*/ FileDescriptorSet(Google.Protobuf.Reflection.FileDescriptorSet other);
                /*0x30996f0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x3099850*/ Google.Protobuf.Reflection.FileDescriptorSet Clone();
                /*0x30998a8*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FileDescriptorProto> get_File();
                /*0x30998b0*/ bool Equals(object other);
                /*0x3099914*/ bool Equals(Google.Protobuf.Reflection.FileDescriptorSet other);
                /*0x30999a4*/ int GetHashCode();
                /*0x30999f0*/ string ToString();
                /*0x3099a48*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x3099a68*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x3099b20*/ int CalculateSize();
                /*0x3099bc8*/ void MergeFrom(Google.Protobuf.Reflection.FileDescriptorSet other);
                /*0x3099c50*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x3099c70*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.FileDescriptorSet.<> <>9;

                    static /*0x3099efc*/ <>c();
                    /*0x3099f64*/ <>c();
                    /*0x3099f6c*/ Google.Protobuf.Reflection.FileDescriptorSet <.cctor>b__27_0();
                }
            }

            class FileDescriptorProto : Google.Protobuf.IMessage<Google.Protobuf.Reflection.FileDescriptorProto>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.FileDescriptorProto>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.FileDescriptorProto>, Google.Protobuf.IBufferMessage
            {
                static int NameFieldNumber = 1;
                static int PackageFieldNumber = 2;
                static int DependencyFieldNumber = 3;
                static int PublicDependencyFieldNumber = 10;
                static int WeakDependencyFieldNumber = 11;
                static int MessageTypeFieldNumber = 4;
                static int EnumTypeFieldNumber = 5;
                static int ServiceFieldNumber = 6;
                static int ExtensionFieldNumber = 7;
                static int OptionsFieldNumber = 8;
                static int SourceCodeInfoFieldNumber = 9;
                static int SyntaxFieldNumber = 12;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FileDescriptorProto> _parser;
                static /*0x8*/ string NameDefaultValue;
                static /*0x10*/ string PackageDefaultValue;
                static /*0x18*/ Google.Protobuf.FieldCodec<string> _repeated_dependency_codec;
                static /*0x20*/ Google.Protobuf.FieldCodec<int> _repeated_publicDependency_codec;
                static /*0x28*/ Google.Protobuf.FieldCodec<int> _repeated_weakDependency_codec;
                static /*0x30*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.DescriptorProto> _repeated_messageType_codec;
                static /*0x38*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.EnumDescriptorProto> _repeated_enumType_codec;
                static /*0x40*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.ServiceDescriptorProto> _repeated_service_codec;
                static /*0x48*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.FieldDescriptorProto> _repeated_extension_codec;
                static /*0x50*/ string SyntaxDefaultValue;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ string name_;
                /*0x20*/ string package_;
                /*0x28*/ Google.Protobuf.Collections.RepeatedField<string> dependency_;
                /*0x30*/ Google.Protobuf.Collections.RepeatedField<int> publicDependency_;
                /*0x38*/ Google.Protobuf.Collections.RepeatedField<int> weakDependency_;
                /*0x40*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto> messageType_;
                /*0x48*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumDescriptorProto> enumType_;
                /*0x50*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.ServiceDescriptorProto> service_;
                /*0x58*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FieldDescriptorProto> extension_;
                /*0x60*/ Google.Protobuf.Reflection.FileOptions options_;
                /*0x68*/ Google.Protobuf.Reflection.SourceCodeInfo sourceCodeInfo_;
                /*0x70*/ string syntax_;

                static /*0x309bb50*/ FileDescriptorProto();
                static /*0x3099fbc*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FileDescriptorProto> get_Parser();
                static /*0x309a014*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x309a164*/ FileDescriptorProto();
                /*0x309a3a4*/ FileDescriptorProto(Google.Protobuf.Reflection.FileDescriptorProto other);
                /*0x309a118*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x309a5d4*/ Google.Protobuf.Reflection.FileDescriptorProto Clone();
                /*0x309a62c*/ string get_Name();
                /*0x309a690*/ void set_Name(string value);
                /*0x309a70c*/ bool get_HasName();
                /*0x309a71c*/ void ClearName();
                /*0x309a728*/ string get_Package();
                /*0x309a78c*/ void set_Package(string value);
                /*0x309a808*/ bool get_HasPackage();
                /*0x309a818*/ void ClearPackage();
                /*0x309a824*/ Google.Protobuf.Collections.RepeatedField<string> get_Dependency();
                /*0x309a82c*/ Google.Protobuf.Collections.RepeatedField<int> get_PublicDependency();
                /*0x309a834*/ Google.Protobuf.Collections.RepeatedField<int> get_WeakDependency();
                /*0x309a83c*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto> get_MessageType();
                /*0x309a844*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumDescriptorProto> get_EnumType();
                /*0x309a84c*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.ServiceDescriptorProto> get_Service();
                /*0x309a854*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FieldDescriptorProto> get_Extension();
                /*0x309a85c*/ Google.Protobuf.Reflection.FileOptions get_Options();
                /*0x309a864*/ void set_Options(Google.Protobuf.Reflection.FileOptions value);
                /*0x309a86c*/ Google.Protobuf.Reflection.SourceCodeInfo get_SourceCodeInfo();
                /*0x309a874*/ void set_SourceCodeInfo(Google.Protobuf.Reflection.SourceCodeInfo value);
                /*0x309a87c*/ string get_Syntax();
                /*0x309a8e0*/ void set_Syntax(string value);
                /*0x309a95c*/ bool get_HasSyntax();
                /*0x309a96c*/ void ClearSyntax();
                /*0x309a978*/ bool Equals(object other);
                /*0x309a9dc*/ bool Equals(Google.Protobuf.Reflection.FileDescriptorProto other);
                /*0x309ac00*/ int GetHashCode();
                /*0x309adc4*/ string ToString();
                /*0x309ae1c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x309ae3c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x309b10c*/ int CalculateSize();
                /*0x309b43c*/ void MergeFrom(Google.Protobuf.Reflection.FileDescriptorProto other);
                /*0x309b6c0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x309b6e0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.FileDescriptorProto.<> <>9;

                    static /*0x309bf8c*/ <>c();
                    /*0x309bff4*/ <>c();
                    /*0x309bffc*/ Google.Protobuf.Reflection.FileDescriptorProto <.cctor>b__94_0();
                }
            }

            class DescriptorProto : Google.Protobuf.IMessage<Google.Protobuf.Reflection.DescriptorProto>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.DescriptorProto>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.DescriptorProto>, Google.Protobuf.IBufferMessage
            {
                static int NameFieldNumber = 1;
                static int FieldFieldNumber = 2;
                static int ExtensionFieldNumber = 6;
                static int NestedTypeFieldNumber = 3;
                static int EnumTypeFieldNumber = 4;
                static int ExtensionRangeFieldNumber = 5;
                static int OneofDeclFieldNumber = 8;
                static int OptionsFieldNumber = 7;
                static int ReservedRangeFieldNumber = 9;
                static int ReservedNameFieldNumber = 10;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.DescriptorProto> _parser;
                static /*0x8*/ string NameDefaultValue;
                static /*0x10*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.FieldDescriptorProto> _repeated_field_codec;
                static /*0x18*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.FieldDescriptorProto> _repeated_extension_codec;
                static /*0x20*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.DescriptorProto> _repeated_nestedType_codec;
                static /*0x28*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.EnumDescriptorProto> _repeated_enumType_codec;
                static /*0x30*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange> _repeated_extensionRange_codec;
                static /*0x38*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.OneofDescriptorProto> _repeated_oneofDecl_codec;
                static /*0x40*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange> _repeated_reservedRange_codec;
                static /*0x48*/ Google.Protobuf.FieldCodec<string> _repeated_reservedName_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ string name_;
                /*0x20*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FieldDescriptorProto> field_;
                /*0x28*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FieldDescriptorProto> extension_;
                /*0x30*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto> nestedType_;
                /*0x38*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumDescriptorProto> enumType_;
                /*0x40*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange> extensionRange_;
                /*0x48*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.OneofDescriptorProto> oneofDecl_;
                /*0x50*/ Google.Protobuf.Reflection.MessageOptions options_;
                /*0x58*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange> reservedRange_;
                /*0x60*/ Google.Protobuf.Collections.RepeatedField<string> reservedName_;

                static /*0x309d7d0*/ DescriptorProto();
                static /*0x309c04c*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.DescriptorProto> get_Parser();
                static /*0x309c0a4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x309c1f4*/ DescriptorProto();
                /*0x309c480*/ DescriptorProto(Google.Protobuf.Reflection.DescriptorProto other);
                /*0x309c1a8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x309c69c*/ Google.Protobuf.Reflection.DescriptorProto Clone();
                /*0x309c6f4*/ string get_Name();
                /*0x309c758*/ void set_Name(string value);
                /*0x309c7d4*/ bool get_HasName();
                /*0x309c7e4*/ void ClearName();
                /*0x309c7f0*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FieldDescriptorProto> get_Field();
                /*0x309c7f8*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.FieldDescriptorProto> get_Extension();
                /*0x309c800*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto> get_NestedType();
                /*0x309c808*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumDescriptorProto> get_EnumType();
                /*0x309c810*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange> get_ExtensionRange();
                /*0x309c818*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.OneofDescriptorProto> get_OneofDecl();
                /*0x309c820*/ Google.Protobuf.Reflection.MessageOptions get_Options();
                /*0x309c828*/ void set_Options(Google.Protobuf.Reflection.MessageOptions value);
                /*0x309c830*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange> get_ReservedRange();
                /*0x309c838*/ Google.Protobuf.Collections.RepeatedField<string> get_ReservedName();
                /*0x309c840*/ bool Equals(object other);
                /*0x309c8a4*/ bool Equals(Google.Protobuf.Reflection.DescriptorProto other);
                /*0x309ca90*/ int GetHashCode();
                /*0x309cc0c*/ string ToString();
                /*0x309cc64*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x309cc84*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x309cf00*/ int CalculateSize();
                /*0x309d1d4*/ void MergeFrom(Google.Protobuf.Reflection.DescriptorProto other);
                /*0x309d3e8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x309d408*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class Types
                {
                    class ExtensionRange : Google.Protobuf.IMessage<Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange>, Google.Protobuf.IBufferMessage
                    {
                        static int StartFieldNumber = 1;
                        static int EndFieldNumber = 2;
                        static int OptionsFieldNumber = 3;
                        static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange> _parser;
                        static /*0x8*/ int StartDefaultValue;
                        static /*0xc*/ int EndDefaultValue;
                        /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                        /*0x18*/ int _hasBits0;
                        /*0x1c*/ int start_;
                        /*0x20*/ int end_;
                        /*0x28*/ Google.Protobuf.Reflection.ExtensionRangeOptions options_;

                        static /*0x309e890*/ ExtensionRange();
                        static /*0x309dd04*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange> get_Parser();
                        static /*0x309dd5c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                        /*0x309de74*/ ExtensionRange();
                        /*0x309de7c*/ ExtensionRange(Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange other);
                        /*0x309de28*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                        /*0x309df4c*/ Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange Clone();
                        /*0x309dfa4*/ int get_Start();
                        /*0x309e014*/ void set_Start(int value);
                        /*0x309e024*/ bool get_HasStart();
                        /*0x309e030*/ void ClearStart();
                        /*0x309e040*/ int get_End();
                        /*0x309e0b0*/ void set_End(int value);
                        /*0x309e0c4*/ bool get_HasEnd();
                        /*0x309e0d0*/ void ClearEnd();
                        /*0x309e0e0*/ Google.Protobuf.Reflection.ExtensionRangeOptions get_Options();
                        /*0x309e0e8*/ void set_Options(Google.Protobuf.Reflection.ExtensionRangeOptions value);
                        /*0x309e0f0*/ bool Equals(object other);
                        /*0x309e154*/ bool Equals(Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange other);
                        /*0x309e1ec*/ int GetHashCode();
                        /*0x309e290*/ string ToString();
                        /*0x309e2e8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                        /*0x309e308*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                        /*0x309e3c8*/ int CalculateSize();
                        /*0x309e4d4*/ void MergeFrom(Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange other);
                        /*0x309e70c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                        /*0x309e72c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                        class <>c
                        {
                            static /*0x0*/ Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange.<> <>9;

                            static /*0x309e9b8*/ <>c();
                            /*0x309ea20*/ <>c();
                            /*0x309ea28*/ Google.Protobuf.Reflection.DescriptorProto.Types.ExtensionRange <.cctor>b__46_0();
                        }
                    }

                    class ReservedRange : Google.Protobuf.IMessage<Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange>, Google.Protobuf.IBufferMessage
                    {
                        static int StartFieldNumber = 1;
                        static int EndFieldNumber = 2;
                        static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange> _parser;
                        static /*0x8*/ int StartDefaultValue;
                        static /*0xc*/ int EndDefaultValue;
                        /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                        /*0x18*/ int _hasBits0;
                        /*0x1c*/ int start_;
                        /*0x20*/ int end_;

                        static /*0x309f280*/ ReservedRange();
                        static /*0x309ea7c*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange> get_Parser();
                        static /*0x309ead4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                        /*0x309ebec*/ ReservedRange();
                        /*0x309ebf4*/ ReservedRange(Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange other);
                        /*0x309eba0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                        /*0x309ec48*/ Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange Clone();
                        /*0x309eca0*/ int get_Start();
                        /*0x309ed10*/ void set_Start(int value);
                        /*0x309ed20*/ bool get_HasStart();
                        /*0x309ed2c*/ void ClearStart();
                        /*0x309ed3c*/ int get_End();
                        /*0x309edac*/ void set_End(int value);
                        /*0x309edc0*/ bool get_HasEnd();
                        /*0x309edcc*/ void ClearEnd();
                        /*0x309eddc*/ bool Equals(object other);
                        /*0x309ee40*/ bool Equals(Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange other);
                        /*0x309eec4*/ int GetHashCode();
                        /*0x309ef50*/ string ToString();
                        /*0x309efa8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                        /*0x309efc8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                        /*0x309f060*/ int CalculateSize();
                        /*0x309f138*/ void MergeFrom(Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange other);
                        /*0x309f1b8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                        /*0x309f1d8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                        class <>c
                        {
                            static /*0x0*/ Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange.<> <>9;

                            static /*0x309f3a8*/ <>c();
                            /*0x309f410*/ <>c();
                            /*0x309f418*/ Google.Protobuf.Reflection.DescriptorProto.Types.ReservedRange <.cctor>b__41_0();
                        }
                    }
                }

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.DescriptorProto.<> <>9;

                    static /*0x309f46c*/ <>c();
                    /*0x309f4d4*/ <>c();
                    /*0x309f4dc*/ Google.Protobuf.Reflection.DescriptorProto <.cctor>b__77_0();
                }
            }

            class ExtensionRangeOptions : Google.Protobuf.IExtendableMessage<Google.Protobuf.Reflection.ExtensionRangeOptions>, Google.Protobuf.IMessage<Google.Protobuf.Reflection.ExtensionRangeOptions>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.ExtensionRangeOptions>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.ExtensionRangeOptions>, Google.Protobuf.IBufferMessage
            {
                static int UninterpretedOptionFieldNumber = 999;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.ExtensionRangeOptions> _parser;
                static /*0x8*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.ExtensionRangeOptions> _extensions;
                /*0x20*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;

                static /*0x309fc6c*/ ExtensionRangeOptions();
                static /*0x309f534*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.ExtensionRangeOptions> get_Parser();
                static /*0x309f58c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x309e5d8*/ ExtensionRangeOptions();
                /*0x309f6dc*/ ExtensionRangeOptions(Google.Protobuf.Reflection.ExtensionRangeOptions other);
                /*0x309f52c*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.ExtensionRangeOptions> get__Extensions();
                /*0x309f690*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x309def4*/ Google.Protobuf.Reflection.ExtensionRangeOptions Clone();
                /*0x309f798*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption();
                /*0x309f7a0*/ bool Equals(object other);
                /*0x309f804*/ bool Equals(Google.Protobuf.Reflection.ExtensionRangeOptions other);
                /*0x309f8a8*/ int GetHashCode();
                /*0x309f914*/ string ToString();
                /*0x309f96c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x309f98c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x309fa6c*/ int CalculateSize();
                /*0x309e660*/ void MergeFrom(Google.Protobuf.Reflection.ExtensionRangeOptions other);
                /*0x309fb3c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x309fb5c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);
                /*0x1ffc854*/ TValue GetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.ExtensionRangeOptions, TValue> extension);
                /*0x1f302cc*/ Google.Protobuf.Collections.RepeatedField<TValue> GetExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ExtensionRangeOptions, TValue> extension);
                /*0x1f302cc*/ Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ExtensionRangeOptions, TValue> extension);
                /*0x1ffc854*/ void SetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.ExtensionRangeOptions, TValue> extension, TValue value);
                /*0x1f2fec8*/ bool HasExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.ExtensionRangeOptions, TValue> extension);
                /*0x1f30ebc*/ void ClearExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.ExtensionRangeOptions, TValue> extension);
                /*0x1f30ebc*/ void ClearExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ExtensionRangeOptions, TValue> extension);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.ExtensionRangeOptions.<> <>9;

                    static /*0x309fe1c*/ <>c();
                    /*0x309fe84*/ <>c();
                    /*0x309fe8c*/ Google.Protobuf.Reflection.ExtensionRangeOptions <.cctor>b__37_0();
                }
            }

            class FieldDescriptorProto : Google.Protobuf.IMessage<Google.Protobuf.Reflection.FieldDescriptorProto>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.FieldDescriptorProto>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.FieldDescriptorProto>, Google.Protobuf.IBufferMessage
            {
                static int NameFieldNumber = 1;
                static int NumberFieldNumber = 3;
                static int LabelFieldNumber = 4;
                static int TypeFieldNumber = 5;
                static int TypeNameFieldNumber = 6;
                static int ExtendeeFieldNumber = 2;
                static int DefaultValueFieldNumber = 7;
                static int OneofIndexFieldNumber = 9;
                static int JsonNameFieldNumber = 10;
                static int OptionsFieldNumber = 8;
                static int Proto3OptionalFieldNumber = 17;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FieldDescriptorProto> _parser;
                static /*0x8*/ string NameDefaultValue;
                static /*0x10*/ int NumberDefaultValue;
                static /*0x14*/ Google.Protobuf.Reflection.FieldDescriptorProto.Types.Label LabelDefaultValue;
                static /*0x18*/ Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type TypeDefaultValue;
                static /*0x20*/ string TypeNameDefaultValue;
                static /*0x28*/ string ExtendeeDefaultValue;
                static /*0x30*/ string DefaultValueDefaultValue;
                static /*0x38*/ int OneofIndexDefaultValue;
                static /*0x40*/ string JsonNameDefaultValue;
                static /*0x48*/ bool Proto3OptionalDefaultValue;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ int _hasBits0;
                /*0x20*/ string name_;
                /*0x28*/ int number_;
                /*0x2c*/ Google.Protobuf.Reflection.FieldDescriptorProto.Types.Label label_;
                /*0x30*/ Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type type_;
                /*0x38*/ string typeName_;
                /*0x40*/ string extendee_;
                /*0x48*/ string defaultValue_;
                /*0x50*/ int oneofIndex_;
                /*0x58*/ string jsonName_;
                /*0x60*/ Google.Protobuf.Reflection.FieldOptions options_;
                /*0x68*/ bool proto3Optional_;

                static /*0x30a18e4*/ FieldDescriptorProto();
                static /*0x309fedc*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FieldDescriptorProto> get_Parser();
                static /*0x309ff34*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x30a0084*/ FieldDescriptorProto();
                /*0x30a008c*/ FieldDescriptorProto(Google.Protobuf.Reflection.FieldDescriptorProto other);
                /*0x30a0038*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x30a0170*/ Google.Protobuf.Reflection.FieldDescriptorProto Clone();
                /*0x30a01c8*/ string get_Name();
                /*0x30a022c*/ void set_Name(string value);
                /*0x30a02a8*/ bool get_HasName();
                /*0x30a02b8*/ void ClearName();
                /*0x30a02c4*/ int get_Number();
                /*0x30a0334*/ void set_Number(int value);
                /*0x30a0348*/ bool get_HasNumber();
                /*0x30a0354*/ void ClearNumber();
                /*0x30a0364*/ Google.Protobuf.Reflection.FieldDescriptorProto.Types.Label get_Label();
                /*0x30a03d4*/ void set_Label(Google.Protobuf.Reflection.FieldDescriptorProto.Types.Label value);
                /*0x30a03e8*/ bool get_HasLabel();
                /*0x30a03f4*/ void ClearLabel();
                /*0x30a0404*/ Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type get_Type();
                /*0x30a0474*/ void set_Type(Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type value);
                /*0x30a0488*/ bool get_HasType();
                /*0x30a0494*/ void ClearType();
                /*0x30a04a4*/ string get_TypeName();
                /*0x30a0508*/ void set_TypeName(string value);
                /*0x30a0584*/ bool get_HasTypeName();
                /*0x30a0594*/ void ClearTypeName();
                /*0x30a05a0*/ string get_Extendee();
                /*0x30a0604*/ void set_Extendee(string value);
                /*0x30a0680*/ bool get_HasExtendee();
                /*0x30a0690*/ void ClearExtendee();
                /*0x30a069c*/ string get_DefaultValue();
                /*0x30a0700*/ void set_DefaultValue(string value);
                /*0x30a077c*/ bool get_HasDefaultValue();
                /*0x30a078c*/ void ClearDefaultValue();
                /*0x30a0798*/ int get_OneofIndex();
                /*0x30a0808*/ void set_OneofIndex(int value);
                /*0x30a081c*/ bool get_HasOneofIndex();
                /*0x30a0828*/ void ClearOneofIndex();
                /*0x30a0838*/ string get_JsonName();
                /*0x30a089c*/ void set_JsonName(string value);
                /*0x30a0918*/ bool get_HasJsonName();
                /*0x30a0928*/ void ClearJsonName();
                /*0x30a0934*/ Google.Protobuf.Reflection.FieldOptions get_Options();
                /*0x30a093c*/ void set_Options(Google.Protobuf.Reflection.FieldOptions value);
                /*0x30a0944*/ bool get_Proto3Optional();
                /*0x30a09b4*/ void set_Proto3Optional(bool value);
                /*0x30a09c8*/ bool get_HasProto3Optional();
                /*0x30a09d4*/ void ClearProto3Optional();
                /*0x30a09e4*/ bool Equals(object other);
                /*0x30a0a48*/ bool Equals(Google.Protobuf.Reflection.FieldDescriptorProto other);
                /*0x30a0bfc*/ int GetHashCode();
                /*0x30a0df8*/ string ToString();
                /*0x30a0e50*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x30a0e70*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x30a10c0*/ int CalculateSize();
                /*0x30a1388*/ void MergeFrom(Google.Protobuf.Reflection.FieldDescriptorProto other);
                /*0x30a1590*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x30a15b0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class Types
                {
                    enum Type
                    {
                        Double = 1,
                        Float = 2,
                        Int64 = 3,
                        Uint64 = 4,
                        Int32 = 5,
                        Fixed64 = 6,
                        Fixed32 = 7,
                        Bool = 8,
                        String = 9,
                        Group = 10,
                        Message = 11,
                        Bytes = 12,
                        Uint32 = 13,
                        Enum = 14,
                        Sfixed32 = 15,
                        Sfixed64 = 16,
                        Sint32 = 17,
                        Sint64 = 18,
                    }

                    enum Label
                    {
                        Optional = 1,
                        Required = 2,
                        Repeated = 3,
                    }
                }

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.FieldDescriptorProto.<> <>9;

                    static /*0x30a1a9c*/ <>c();
                    /*0x30a1b04*/ <>c();
                    /*0x30a1b0c*/ Google.Protobuf.Reflection.FieldDescriptorProto <.cctor>b__119_0();
                }
            }

            class OneofDescriptorProto : Google.Protobuf.IMessage<Google.Protobuf.Reflection.OneofDescriptorProto>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.OneofDescriptorProto>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.OneofDescriptorProto>, Google.Protobuf.IBufferMessage
            {
                static int NameFieldNumber = 1;
                static int OptionsFieldNumber = 2;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.OneofDescriptorProto> _parser;
                static /*0x8*/ string NameDefaultValue;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ string name_;
                /*0x20*/ Google.Protobuf.Reflection.OneofOptions options_;

                static /*0x30a247c*/ OneofDescriptorProto();
                static /*0x30a1b60*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.OneofDescriptorProto> get_Parser();
                static /*0x30a1bb8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x30a1d08*/ OneofDescriptorProto();
                /*0x30a1d10*/ OneofDescriptorProto(Google.Protobuf.Reflection.OneofDescriptorProto other);
                /*0x30a1cbc*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x30a1d8c*/ Google.Protobuf.Reflection.OneofDescriptorProto Clone();
                /*0x30a1de4*/ string get_Name();
                /*0x30a1e48*/ void set_Name(string value);
                /*0x30a1ec4*/ bool get_HasName();
                /*0x30a1ed4*/ void ClearName();
                /*0x30a1ee0*/ Google.Protobuf.Reflection.OneofOptions get_Options();
                /*0x30a1ee8*/ void set_Options(Google.Protobuf.Reflection.OneofOptions value);
                /*0x30a1ef0*/ bool Equals(object other);
                /*0x30a1f54*/ bool Equals(Google.Protobuf.Reflection.OneofDescriptorProto other);
                /*0x30a1fdc*/ int GetHashCode();
                /*0x30a2058*/ string ToString();
                /*0x30a20b0*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x30a20d0*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x30a2160*/ int CalculateSize();
                /*0x30a222c*/ void MergeFrom(Google.Protobuf.Reflection.OneofDescriptorProto other);
                /*0x30a2314*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x30a2334*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.OneofDescriptorProto.<> <>9;

                    static /*0x30a25bc*/ <>c();
                    /*0x30a2624*/ <>c();
                    /*0x30a262c*/ Google.Protobuf.Reflection.OneofDescriptorProto <.cctor>b__36_0();
                }
            }

            class EnumDescriptorProto : Google.Protobuf.IMessage<Google.Protobuf.Reflection.EnumDescriptorProto>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.EnumDescriptorProto>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.EnumDescriptorProto>, Google.Protobuf.IBufferMessage
            {
                static int NameFieldNumber = 1;
                static int ValueFieldNumber = 2;
                static int OptionsFieldNumber = 3;
                static int ReservedRangeFieldNumber = 4;
                static int ReservedNameFieldNumber = 5;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumDescriptorProto> _parser;
                static /*0x8*/ string NameDefaultValue;
                static /*0x10*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.EnumValueDescriptorProto> _repeated_value_codec;
                static /*0x18*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange> _repeated_reservedRange_codec;
                static /*0x20*/ Google.Protobuf.FieldCodec<string> _repeated_reservedName_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ string name_;
                /*0x20*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumValueDescriptorProto> value_;
                /*0x28*/ Google.Protobuf.Reflection.EnumOptions options_;
                /*0x30*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange> reservedRange_;
                /*0x38*/ Google.Protobuf.Collections.RepeatedField<string> reservedName_;

                static /*0x30a37bc*/ EnumDescriptorProto();
                static /*0x30a2680*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumDescriptorProto> get_Parser();
                static /*0x30a26d8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x30a2828*/ EnumDescriptorProto();
                /*0x30a2958*/ EnumDescriptorProto(Google.Protobuf.Reflection.EnumDescriptorProto other);
                /*0x30a27dc*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x30a2ad8*/ Google.Protobuf.Reflection.EnumDescriptorProto Clone();
                /*0x30a2b30*/ string get_Name();
                /*0x30a2b94*/ void set_Name(string value);
                /*0x30a2c10*/ bool get_HasName();
                /*0x30a2c20*/ void ClearName();
                /*0x30a2c2c*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumValueDescriptorProto> get_Value();
                /*0x30a2c34*/ Google.Protobuf.Reflection.EnumOptions get_Options();
                /*0x30a2c3c*/ void set_Options(Google.Protobuf.Reflection.EnumOptions value);
                /*0x30a2c44*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange> get_ReservedRange();
                /*0x30a2c4c*/ Google.Protobuf.Collections.RepeatedField<string> get_ReservedName();
                /*0x30a2c54*/ bool Equals(object other);
                /*0x30a2cb8*/ bool Equals(Google.Protobuf.Reflection.EnumDescriptorProto other);
                /*0x30a2ddc*/ int GetHashCode();
                /*0x30a2eac*/ string ToString();
                /*0x30a2f04*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x30a2f24*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x30a30b0*/ int CalculateSize();
                /*0x30a3260*/ void MergeFrom(Google.Protobuf.Reflection.EnumDescriptorProto other);
                /*0x30a3534*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x30a3554*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class Types
                {
                    class EnumReservedRange : Google.Protobuf.IMessage<Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange>, Google.Protobuf.IBufferMessage
                    {
                        static int StartFieldNumber = 1;
                        static int EndFieldNumber = 2;
                        static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange> _parser;
                        static /*0x8*/ int StartDefaultValue;
                        static /*0xc*/ int EndDefaultValue;
                        /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                        /*0x18*/ int _hasBits0;
                        /*0x1c*/ int start_;
                        /*0x20*/ int end_;

                        static /*0x30a425c*/ EnumReservedRange();
                        static /*0x30a3a58*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange> get_Parser();
                        static /*0x30a3ab0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                        /*0x30a3bc8*/ EnumReservedRange();
                        /*0x30a3bd0*/ EnumReservedRange(Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange other);
                        /*0x30a3b7c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                        /*0x30a3c24*/ Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange Clone();
                        /*0x30a3c7c*/ int get_Start();
                        /*0x30a3cec*/ void set_Start(int value);
                        /*0x30a3cfc*/ bool get_HasStart();
                        /*0x30a3d08*/ void ClearStart();
                        /*0x30a3d18*/ int get_End();
                        /*0x30a3d88*/ void set_End(int value);
                        /*0x30a3d9c*/ bool get_HasEnd();
                        /*0x30a3da8*/ void ClearEnd();
                        /*0x30a3db8*/ bool Equals(object other);
                        /*0x30a3e1c*/ bool Equals(Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange other);
                        /*0x30a3ea0*/ int GetHashCode();
                        /*0x30a3f2c*/ string ToString();
                        /*0x30a3f84*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                        /*0x30a3fa4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                        /*0x30a403c*/ int CalculateSize();
                        /*0x30a4114*/ void MergeFrom(Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange other);
                        /*0x30a4194*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                        /*0x30a41b4*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                        class <>c
                        {
                            static /*0x0*/ Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange.<> <>9;

                            static /*0x30a4384*/ <>c();
                            /*0x30a43ec*/ <>c();
                            /*0x30a43f4*/ Google.Protobuf.Reflection.EnumDescriptorProto.Types.EnumReservedRange <.cctor>b__41_0();
                        }
                    }
                }

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.EnumDescriptorProto.<> <>9;

                    static /*0x30a4448*/ <>c();
                    /*0x30a44b0*/ <>c();
                    /*0x30a44b8*/ Google.Protobuf.Reflection.EnumDescriptorProto <.cctor>b__52_0();
                }
            }

            class EnumValueDescriptorProto : Google.Protobuf.IMessage<Google.Protobuf.Reflection.EnumValueDescriptorProto>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.EnumValueDescriptorProto>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.EnumValueDescriptorProto>, Google.Protobuf.IBufferMessage
            {
                static int NameFieldNumber = 1;
                static int NumberFieldNumber = 2;
                static int OptionsFieldNumber = 3;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumValueDescriptorProto> _parser;
                static /*0x8*/ string NameDefaultValue;
                static /*0x10*/ int NumberDefaultValue;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ int _hasBits0;
                /*0x20*/ string name_;
                /*0x28*/ int number_;
                /*0x30*/ Google.Protobuf.Reflection.EnumValueOptions options_;

                static /*0x30a517c*/ EnumValueDescriptorProto();
                static /*0x30a4508*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumValueDescriptorProto> get_Parser();
                static /*0x30a4560*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x30a46b0*/ EnumValueDescriptorProto();
                /*0x30a46b8*/ EnumValueDescriptorProto(Google.Protobuf.Reflection.EnumValueDescriptorProto other);
                /*0x30a4664*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x30a479c*/ Google.Protobuf.Reflection.EnumValueDescriptorProto Clone();
                /*0x30a47f4*/ string get_Name();
                /*0x30a4858*/ void set_Name(string value);
                /*0x30a48d4*/ bool get_HasName();
                /*0x30a48e4*/ void ClearName();
                /*0x30a48f0*/ int get_Number();
                /*0x30a4960*/ void set_Number(int value);
                /*0x30a4974*/ bool get_HasNumber();
                /*0x30a4980*/ void ClearNumber();
                /*0x30a4990*/ Google.Protobuf.Reflection.EnumValueOptions get_Options();
                /*0x30a4998*/ void set_Options(Google.Protobuf.Reflection.EnumValueOptions value);
                /*0x30a49a0*/ bool Equals(object other);
                /*0x30a4a04*/ bool Equals(Google.Protobuf.Reflection.EnumValueDescriptorProto other);
                /*0x30a4aa8*/ int GetHashCode();
                /*0x30a4b4c*/ string ToString();
                /*0x30a4ba4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x30a4bc4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x30a4c84*/ int CalculateSize();
                /*0x30a4d8c*/ void MergeFrom(Google.Protobuf.Reflection.EnumValueDescriptorProto other);
                /*0x30a4fe4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x30a5004*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.EnumValueDescriptorProto.<> <>9;

                    static /*0x30a52cc*/ <>c();
                    /*0x30a5334*/ <>c();
                    /*0x30a533c*/ Google.Protobuf.Reflection.EnumValueDescriptorProto <.cctor>b__46_0();
                }
            }

            class ServiceDescriptorProto : Google.Protobuf.IMessage<Google.Protobuf.Reflection.ServiceDescriptorProto>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.ServiceDescriptorProto>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.ServiceDescriptorProto>, Google.Protobuf.IBufferMessage
            {
                static int NameFieldNumber = 1;
                static int MethodFieldNumber = 2;
                static int OptionsFieldNumber = 3;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.ServiceDescriptorProto> _parser;
                static /*0x8*/ string NameDefaultValue;
                static /*0x10*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.MethodDescriptorProto> _repeated_method_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ string name_;
                /*0x20*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.MethodDescriptorProto> method_;
                /*0x28*/ Google.Protobuf.Reflection.ServiceOptions options_;

                static /*0x30a6100*/ ServiceDescriptorProto();
                static /*0x30a5390*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.ServiceDescriptorProto> get_Parser();
                static /*0x30a53e8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x30a5538*/ ServiceDescriptorProto();
                /*0x30a55c0*/ ServiceDescriptorProto(Google.Protobuf.Reflection.ServiceDescriptorProto other);
                /*0x30a54ec*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x30a56d8*/ Google.Protobuf.Reflection.ServiceDescriptorProto Clone();
                /*0x30a5730*/ string get_Name();
                /*0x30a5794*/ void set_Name(string value);
                /*0x30a5810*/ bool get_HasName();
                /*0x30a5820*/ void ClearName();
                /*0x30a582c*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.MethodDescriptorProto> get_Method();
                /*0x30a5834*/ Google.Protobuf.Reflection.ServiceOptions get_Options();
                /*0x30a583c*/ void set_Options(Google.Protobuf.Reflection.ServiceOptions value);
                /*0x30a5844*/ bool Equals(object other);
                /*0x30a58a8*/ bool Equals(Google.Protobuf.Reflection.ServiceDescriptorProto other);
                /*0x30a5974*/ int GetHashCode();
                /*0x30a5a0c*/ string ToString();
                /*0x30a5a64*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x30a5a84*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x30a5b94*/ int CalculateSize();
                /*0x30a5cc0*/ void MergeFrom(Google.Protobuf.Reflection.ServiceDescriptorProto other);
                /*0x30a5f20*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x30a5f40*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.ServiceDescriptorProto.<> <>9;

                    static /*0x30a62e0*/ <>c();
                    /*0x30a6348*/ <>c();
                    /*0x30a6350*/ Google.Protobuf.Reflection.ServiceDescriptorProto <.cctor>b__41_0();
                }
            }

            class MethodDescriptorProto : Google.Protobuf.IMessage<Google.Protobuf.Reflection.MethodDescriptorProto>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.MethodDescriptorProto>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.MethodDescriptorProto>, Google.Protobuf.IBufferMessage
            {
                static int NameFieldNumber = 1;
                static int InputTypeFieldNumber = 2;
                static int OutputTypeFieldNumber = 3;
                static int OptionsFieldNumber = 4;
                static int ClientStreamingFieldNumber = 5;
                static int ServerStreamingFieldNumber = 6;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.MethodDescriptorProto> _parser;
                static /*0x8*/ string NameDefaultValue;
                static /*0x10*/ string InputTypeDefaultValue;
                static /*0x18*/ string OutputTypeDefaultValue;
                static /*0x20*/ bool ClientStreamingDefaultValue;
                static /*0x21*/ bool ServerStreamingDefaultValue;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ int _hasBits0;
                /*0x20*/ string name_;
                /*0x28*/ string inputType_;
                /*0x30*/ string outputType_;
                /*0x38*/ Google.Protobuf.Reflection.MethodOptions options_;
                /*0x40*/ bool clientStreaming_;
                /*0x41*/ bool serverStreaming_;

                static /*0x30a7600*/ MethodDescriptorProto();
                static /*0x30a63a0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.MethodDescriptorProto> get_Parser();
                static /*0x30a63f8*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x30a6548*/ MethodDescriptorProto();
                /*0x30a6550*/ MethodDescriptorProto(Google.Protobuf.Reflection.MethodDescriptorProto other);
                /*0x30a64fc*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x30a6650*/ Google.Protobuf.Reflection.MethodDescriptorProto Clone();
                /*0x30a66a8*/ string get_Name();
                /*0x30a670c*/ void set_Name(string value);
                /*0x30a6788*/ bool get_HasName();
                /*0x30a6798*/ void ClearName();
                /*0x30a67a4*/ string get_InputType();
                /*0x30a6808*/ void set_InputType(string value);
                /*0x30a6884*/ bool get_HasInputType();
                /*0x30a6894*/ void ClearInputType();
                /*0x30a68a0*/ string get_OutputType();
                /*0x30a6904*/ void set_OutputType(string value);
                /*0x30a6980*/ bool get_HasOutputType();
                /*0x30a6990*/ void ClearOutputType();
                /*0x30a699c*/ Google.Protobuf.Reflection.MethodOptions get_Options();
                /*0x30a69a4*/ void set_Options(Google.Protobuf.Reflection.MethodOptions value);
                /*0x30a69ac*/ bool get_ClientStreaming();
                /*0x30a6a1c*/ void set_ClientStreaming(bool value);
                /*0x30a6a30*/ bool get_HasClientStreaming();
                /*0x30a6a3c*/ void ClearClientStreaming();
                /*0x30a6a4c*/ bool get_ServerStreaming();
                /*0x30a6abc*/ void set_ServerStreaming(bool value);
                /*0x30a6ad0*/ bool get_HasServerStreaming();
                /*0x30a6adc*/ void ClearServerStreaming();
                /*0x30a6aec*/ bool Equals(object other);
                /*0x30a6b50*/ bool Equals(Google.Protobuf.Reflection.MethodDescriptorProto other);
                /*0x30a6c60*/ int GetHashCode();
                /*0x30a6db0*/ string ToString();
                /*0x30a6e08*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x30a6e28*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x30a6f78*/ int CalculateSize();
                /*0x30a70d0*/ void MergeFrom(Google.Protobuf.Reflection.MethodDescriptorProto other);
                /*0x30a73a8*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x30a73c8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.MethodDescriptorProto.<> <>9;

                    static /*0x30a7778*/ <>c();
                    /*0x30a77e0*/ <>c();
                    /*0x30a77e8*/ Google.Protobuf.Reflection.MethodDescriptorProto <.cctor>b__73_0();
                }
            }

            class FileOptions : Google.Protobuf.IExtendableMessage<Google.Protobuf.Reflection.FileOptions>, Google.Protobuf.IMessage<Google.Protobuf.Reflection.FileOptions>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.FileOptions>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.FileOptions>, Google.Protobuf.IBufferMessage
            {
                static int JavaPackageFieldNumber = 1;
                static int JavaOuterClassnameFieldNumber = 8;
                static int JavaMultipleFilesFieldNumber = 10;
                static int JavaGenerateEqualsAndHashFieldNumber = 20;
                static int JavaStringCheckUtf8FieldNumber = 27;
                static int OptimizeForFieldNumber = 9;
                static int GoPackageFieldNumber = 11;
                static int CcGenericServicesFieldNumber = 16;
                static int JavaGenericServicesFieldNumber = 17;
                static int PyGenericServicesFieldNumber = 18;
                static int PhpGenericServicesFieldNumber = 42;
                static int DeprecatedFieldNumber = 23;
                static int CcEnableArenasFieldNumber = 31;
                static int ObjcClassPrefixFieldNumber = 36;
                static int CsharpNamespaceFieldNumber = 37;
                static int SwiftPrefixFieldNumber = 39;
                static int PhpClassPrefixFieldNumber = 40;
                static int PhpNamespaceFieldNumber = 41;
                static int PhpMetadataNamespaceFieldNumber = 44;
                static int RubyPackageFieldNumber = 45;
                static int UninterpretedOptionFieldNumber = 999;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FileOptions> _parser;
                static /*0x8*/ string JavaPackageDefaultValue;
                static /*0x10*/ string JavaOuterClassnameDefaultValue;
                static /*0x18*/ bool JavaMultipleFilesDefaultValue;
                static /*0x19*/ bool JavaGenerateEqualsAndHashDefaultValue;
                static /*0x1a*/ bool JavaStringCheckUtf8DefaultValue;
                static /*0x1c*/ Google.Protobuf.Reflection.FileOptions.Types.OptimizeMode OptimizeForDefaultValue;
                static /*0x20*/ string GoPackageDefaultValue;
                static /*0x28*/ bool CcGenericServicesDefaultValue;
                static /*0x29*/ bool JavaGenericServicesDefaultValue;
                static /*0x2a*/ bool PyGenericServicesDefaultValue;
                static /*0x2b*/ bool PhpGenericServicesDefaultValue;
                static /*0x2c*/ bool DeprecatedDefaultValue;
                static /*0x2d*/ bool CcEnableArenasDefaultValue;
                static /*0x30*/ string ObjcClassPrefixDefaultValue;
                static /*0x38*/ string CsharpNamespaceDefaultValue;
                static /*0x40*/ string SwiftPrefixDefaultValue;
                static /*0x48*/ string PhpClassPrefixDefaultValue;
                static /*0x50*/ string PhpNamespaceDefaultValue;
                static /*0x58*/ string PhpMetadataNamespaceDefaultValue;
                static /*0x60*/ string RubyPackageDefaultValue;
                static /*0x68*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.FileOptions> _extensions;
                /*0x20*/ int _hasBits0;
                /*0x28*/ string javaPackage_;
                /*0x30*/ string javaOuterClassname_;
                /*0x38*/ bool javaMultipleFiles_;
                /*0x39*/ bool javaGenerateEqualsAndHash_;
                /*0x3a*/ bool javaStringCheckUtf8_;
                /*0x3c*/ Google.Protobuf.Reflection.FileOptions.Types.OptimizeMode optimizeFor_;
                /*0x40*/ string goPackage_;
                /*0x48*/ bool ccGenericServices_;
                /*0x49*/ bool javaGenericServices_;
                /*0x4a*/ bool pyGenericServices_;
                /*0x4b*/ bool phpGenericServices_;
                /*0x4c*/ bool deprecated_;
                /*0x4d*/ bool ccEnableArenas_;
                /*0x50*/ string objcClassPrefix_;
                /*0x58*/ string csharpNamespace_;
                /*0x60*/ string swiftPrefix_;
                /*0x68*/ string phpClassPrefix_;
                /*0x70*/ string phpNamespace_;
                /*0x78*/ string phpMetadataNamespace_;
                /*0x80*/ string rubyPackage_;
                /*0x88*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;

                static /*0x30aa6f4*/ FileOptions();
                static /*0x30a7844*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FileOptions> get_Parser();
                static /*0x30a789c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x30a79ec*/ FileOptions();
                /*0x30a7a74*/ FileOptions(Google.Protobuf.Reflection.FileOptions other);
                /*0x30a783c*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.FileOptions> get__Extensions();
                /*0x30a79a0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x30a7c08*/ Google.Protobuf.Reflection.FileOptions Clone();
                /*0x30a7c60*/ string get_JavaPackage();
                /*0x30a7cc4*/ void set_JavaPackage(string value);
                /*0x30a7d40*/ bool get_HasJavaPackage();
                /*0x30a7d50*/ void ClearJavaPackage();
                /*0x30a7d5c*/ string get_JavaOuterClassname();
                /*0x30a7dc0*/ void set_JavaOuterClassname(string value);
                /*0x30a7e3c*/ bool get_HasJavaOuterClassname();
                /*0x30a7e4c*/ void ClearJavaOuterClassname();
                /*0x30a7e58*/ bool get_JavaMultipleFiles();
                /*0x30a7ec8*/ void set_JavaMultipleFiles(bool value);
                /*0x30a7edc*/ bool get_HasJavaMultipleFiles();
                /*0x30a7ee8*/ void ClearJavaMultipleFiles();
                /*0x30a7ef8*/ bool get_JavaGenerateEqualsAndHash();
                /*0x30a7f68*/ void set_JavaGenerateEqualsAndHash(bool value);
                /*0x30a7f7c*/ bool get_HasJavaGenerateEqualsAndHash();
                /*0x30a7f88*/ void ClearJavaGenerateEqualsAndHash();
                /*0x30a7f98*/ bool get_JavaStringCheckUtf8();
                /*0x30a8008*/ void set_JavaStringCheckUtf8(bool value);
                /*0x30a801c*/ bool get_HasJavaStringCheckUtf8();
                /*0x30a8028*/ void ClearJavaStringCheckUtf8();
                /*0x30a8038*/ Google.Protobuf.Reflection.FileOptions.Types.OptimizeMode get_OptimizeFor();
                /*0x30a80a8*/ void set_OptimizeFor(Google.Protobuf.Reflection.FileOptions.Types.OptimizeMode value);
                /*0x30a80bc*/ bool get_HasOptimizeFor();
                /*0x30a80c8*/ void ClearOptimizeFor();
                /*0x30a80d8*/ string get_GoPackage();
                /*0x30a813c*/ void set_GoPackage(string value);
                /*0x30a81b8*/ bool get_HasGoPackage();
                /*0x30a81c8*/ void ClearGoPackage();
                /*0x30a81d4*/ bool get_CcGenericServices();
                /*0x30a8244*/ void set_CcGenericServices(bool value);
                /*0x30a8258*/ bool get_HasCcGenericServices();
                /*0x30a8264*/ void ClearCcGenericServices();
                /*0x30a8274*/ bool get_JavaGenericServices();
                /*0x30a82e4*/ void set_JavaGenericServices(bool value);
                /*0x30a82f8*/ bool get_HasJavaGenericServices();
                /*0x30a8304*/ void ClearJavaGenericServices();
                /*0x30a8314*/ bool get_PyGenericServices();
                /*0x30a8384*/ void set_PyGenericServices(bool value);
                /*0x30a8398*/ bool get_HasPyGenericServices();
                /*0x30a83a4*/ void ClearPyGenericServices();
                /*0x30a83b4*/ bool get_PhpGenericServices();
                /*0x30a8424*/ void set_PhpGenericServices(bool value);
                /*0x30a8438*/ bool get_HasPhpGenericServices();
                /*0x30a8444*/ void ClearPhpGenericServices();
                /*0x30a8454*/ bool get_Deprecated();
                /*0x30a84c4*/ void set_Deprecated(bool value);
                /*0x30a84d8*/ bool get_HasDeprecated();
                /*0x30a84e4*/ void ClearDeprecated();
                /*0x30a84f4*/ bool get_CcEnableArenas();
                /*0x30a8564*/ void set_CcEnableArenas(bool value);
                /*0x30a8578*/ bool get_HasCcEnableArenas();
                /*0x30a8584*/ void ClearCcEnableArenas();
                /*0x30a8594*/ string get_ObjcClassPrefix();
                /*0x30a85f8*/ void set_ObjcClassPrefix(string value);
                /*0x30a8674*/ bool get_HasObjcClassPrefix();
                /*0x30a8684*/ void ClearObjcClassPrefix();
                /*0x30a8690*/ string get_CsharpNamespace();
                /*0x30a86f4*/ void set_CsharpNamespace(string value);
                /*0x30a8770*/ bool get_HasCsharpNamespace();
                /*0x30a8780*/ void ClearCsharpNamespace();
                /*0x30a878c*/ string get_SwiftPrefix();
                /*0x30a87f0*/ void set_SwiftPrefix(string value);
                /*0x30a886c*/ bool get_HasSwiftPrefix();
                /*0x30a887c*/ void ClearSwiftPrefix();
                /*0x30a8888*/ string get_PhpClassPrefix();
                /*0x30a88ec*/ void set_PhpClassPrefix(string value);
                /*0x30a8968*/ bool get_HasPhpClassPrefix();
                /*0x30a8978*/ void ClearPhpClassPrefix();
                /*0x30a8984*/ string get_PhpNamespace();
                /*0x30a89e8*/ void set_PhpNamespace(string value);
                /*0x30a8a64*/ bool get_HasPhpNamespace();
                /*0x30a8a74*/ void ClearPhpNamespace();
                /*0x30a8a80*/ string get_PhpMetadataNamespace();
                /*0x30a8ae4*/ void set_PhpMetadataNamespace(string value);
                /*0x30a8b60*/ bool get_HasPhpMetadataNamespace();
                /*0x30a8b70*/ void ClearPhpMetadataNamespace();
                /*0x30a8b7c*/ string get_RubyPackage();
                /*0x30a8be0*/ void set_RubyPackage(string value);
                /*0x30a8c5c*/ bool get_HasRubyPackage();
                /*0x30a8c6c*/ void ClearRubyPackage();
                /*0x30a8c78*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption();
                /*0x30a8c80*/ bool Equals(object other);
                /*0x30a8ce4*/ bool Equals(Google.Protobuf.Reflection.FileOptions other);
                /*0x30a9030*/ int GetHashCode();
                /*0x30a948c*/ string ToString();
                /*0x30a94e4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x30a9504*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x30a99fc*/ int CalculateSize();
                /*0x30a9dec*/ void MergeFrom(Google.Protobuf.Reflection.FileOptions other);
                /*0x30aa13c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x30aa15c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);
                /*0x1ffc854*/ TValue GetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.FileOptions, TValue> extension);
                /*0x1f302cc*/ Google.Protobuf.Collections.RepeatedField<TValue> GetExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FileOptions, TValue> extension);
                /*0x1f302cc*/ Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FileOptions, TValue> extension);
                /*0x1ffc854*/ void SetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.FileOptions, TValue> extension, TValue value);
                /*0x1f2fec8*/ bool HasExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.FileOptions, TValue> extension);
                /*0x1f30ebc*/ void ClearExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.FileOptions, TValue> extension);
                /*0x1f30ebc*/ void ClearExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FileOptions, TValue> extension);

                class Types
                {
                    enum OptimizeMode
                    {
                        Speed = 1,
                        CodeSize = 2,
                        LiteRuntime = 3,
                    }
                }

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.FileOptions.<> <>9;

                    static /*0x30aa9a4*/ <>c();
                    /*0x30aaa0c*/ <>c();
                    /*0x30aaa14*/ Google.Protobuf.Reflection.FileOptions <.cctor>b__219_0();
                }
            }

            class MessageOptions : Google.Protobuf.IExtendableMessage<Google.Protobuf.Reflection.MessageOptions>, Google.Protobuf.IMessage<Google.Protobuf.Reflection.MessageOptions>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.MessageOptions>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.MessageOptions>, Google.Protobuf.IBufferMessage
            {
                static int MessageSetWireFormatFieldNumber = 1;
                static int NoStandardDescriptorAccessorFieldNumber = 2;
                static int DeprecatedFieldNumber = 3;
                static int MapEntryFieldNumber = 7;
                static int UninterpretedOptionFieldNumber = 999;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.MessageOptions> _parser;
                static /*0x8*/ bool MessageSetWireFormatDefaultValue;
                static /*0x9*/ bool NoStandardDescriptorAccessorDefaultValue;
                static /*0xa*/ bool DeprecatedDefaultValue;
                static /*0xb*/ bool MapEntryDefaultValue;
                static /*0x10*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.MessageOptions> _extensions;
                /*0x20*/ int _hasBits0;
                /*0x24*/ bool messageSetWireFormat_;
                /*0x25*/ bool noStandardDescriptorAccessor_;
                /*0x26*/ bool deprecated_;
                /*0x27*/ bool mapEntry_;
                /*0x28*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;

                static /*0x30ab9c0*/ MessageOptions();
                static /*0x30aaa6c*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.MessageOptions> get_Parser();
                static /*0x30aaac4*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x30aac14*/ MessageOptions();
                /*0x30aac9c*/ MessageOptions(Google.Protobuf.Reflection.MessageOptions other);
                /*0x30aaa64*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.MessageOptions> get__Extensions();
                /*0x30aabc8*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x30aad68*/ Google.Protobuf.Reflection.MessageOptions Clone();
                /*0x30aadc0*/ bool get_MessageSetWireFormat();
                /*0x30aae30*/ void set_MessageSetWireFormat(bool value);
                /*0x30aae44*/ bool get_HasMessageSetWireFormat();
                /*0x30aae50*/ void ClearMessageSetWireFormat();
                /*0x30aae60*/ bool get_NoStandardDescriptorAccessor();
                /*0x30aaed0*/ void set_NoStandardDescriptorAccessor(bool value);
                /*0x30aaee4*/ bool get_HasNoStandardDescriptorAccessor();
                /*0x30aaef0*/ void ClearNoStandardDescriptorAccessor();
                /*0x30aaf00*/ bool get_Deprecated();
                /*0x30aaf70*/ void set_Deprecated(bool value);
                /*0x30aaf84*/ bool get_HasDeprecated();
                /*0x30aaf90*/ void ClearDeprecated();
                /*0x30aafa0*/ bool get_MapEntry();
                /*0x30ab010*/ void set_MapEntry(bool value);
                /*0x30ab024*/ bool get_HasMapEntry();
                /*0x30ab030*/ void ClearMapEntry();
                /*0x30ab040*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption();
                /*0x30ab048*/ bool Equals(object other);
                /*0x30ab0ac*/ bool Equals(Google.Protobuf.Reflection.MessageOptions other);
                /*0x30ab1c0*/ int GetHashCode();
                /*0x30ab344*/ string ToString();
                /*0x30ab39c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x30ab3bc*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x30ab568*/ int CalculateSize();
                /*0x30ab668*/ void MergeFrom(Google.Protobuf.Reflection.MessageOptions other);
                /*0x30ab7b4*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x30ab7d4*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);
                /*0x1ffc854*/ TValue GetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.MessageOptions, TValue> extension);
                /*0x1f302cc*/ Google.Protobuf.Collections.RepeatedField<TValue> GetExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MessageOptions, TValue> extension);
                /*0x1f302cc*/ Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MessageOptions, TValue> extension);
                /*0x1ffc854*/ void SetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.MessageOptions, TValue> extension, TValue value);
                /*0x1f2fec8*/ bool HasExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.MessageOptions, TValue> extension);
                /*0x1f30ebc*/ void ClearExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.MessageOptions, TValue> extension);
                /*0x1f30ebc*/ void ClearExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MessageOptions, TValue> extension);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.MessageOptions.<> <>9;

                    static /*0x30abb7c*/ <>c();
                    /*0x30abbe4*/ <>c();
                    /*0x30abbec*/ Google.Protobuf.Reflection.MessageOptions <.cctor>b__74_0();
                }
            }

            class FieldOptions : Google.Protobuf.IExtendableMessage<Google.Protobuf.Reflection.FieldOptions>, Google.Protobuf.IMessage<Google.Protobuf.Reflection.FieldOptions>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.FieldOptions>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.FieldOptions>, Google.Protobuf.IBufferMessage
            {
                static int CtypeFieldNumber = 1;
                static int PackedFieldNumber = 2;
                static int JstypeFieldNumber = 6;
                static int LazyFieldNumber = 5;
                static int DeprecatedFieldNumber = 3;
                static int WeakFieldNumber = 10;
                static int UninterpretedOptionFieldNumber = 999;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FieldOptions> _parser;
                static /*0x8*/ Google.Protobuf.Reflection.FieldOptions.Types.CType CtypeDefaultValue;
                static /*0xc*/ bool PackedDefaultValue;
                static /*0x10*/ Google.Protobuf.Reflection.FieldOptions.Types.JSType JstypeDefaultValue;
                static /*0x14*/ bool LazyDefaultValue;
                static /*0x15*/ bool DeprecatedDefaultValue;
                static /*0x16*/ bool WeakDefaultValue;
                static /*0x18*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.FieldOptions> _extensions;
                /*0x20*/ int _hasBits0;
                /*0x24*/ Google.Protobuf.Reflection.FieldOptions.Types.CType ctype_;
                /*0x28*/ bool packed_;
                /*0x2c*/ Google.Protobuf.Reflection.FieldOptions.Types.JSType jstype_;
                /*0x30*/ bool lazy_;
                /*0x31*/ bool deprecated_;
                /*0x32*/ bool weak_;
                /*0x38*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;

                static /*0x30acf24*/ FieldOptions();
                static /*0x30abc44*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.FieldOptions> get_Parser();
                static /*0x30abc9c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x30abdec*/ FieldOptions();
                /*0x30abe74*/ FieldOptions(Google.Protobuf.Reflection.FieldOptions other);
                /*0x30abc3c*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.FieldOptions> get__Extensions();
                /*0x30abda0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x30abf58*/ Google.Protobuf.Reflection.FieldOptions Clone();
                /*0x30abfb0*/ Google.Protobuf.Reflection.FieldOptions.Types.CType get_Ctype();
                /*0x30ac020*/ void set_Ctype(Google.Protobuf.Reflection.FieldOptions.Types.CType value);
                /*0x30ac030*/ bool get_HasCtype();
                /*0x30ac03c*/ void ClearCtype();
                /*0x30ac04c*/ bool get_Packed();
                /*0x30ac0bc*/ void set_Packed(bool value);
                /*0x30ac0d0*/ bool get_HasPacked();
                /*0x30ac0dc*/ void ClearPacked();
                /*0x30ac0ec*/ Google.Protobuf.Reflection.FieldOptions.Types.JSType get_Jstype();
                /*0x30ac15c*/ void set_Jstype(Google.Protobuf.Reflection.FieldOptions.Types.JSType value);
                /*0x30ac170*/ bool get_HasJstype();
                /*0x30ac17c*/ void ClearJstype();
                /*0x30ac18c*/ bool get_Lazy();
                /*0x30ac1fc*/ void set_Lazy(bool value);
                /*0x30ac210*/ bool get_HasLazy();
                /*0x30ac21c*/ void ClearLazy();
                /*0x30ac22c*/ bool get_Deprecated();
                /*0x30ac29c*/ void set_Deprecated(bool value);
                /*0x30ac2b0*/ bool get_HasDeprecated();
                /*0x30ac2bc*/ void ClearDeprecated();
                /*0x30ac2cc*/ bool get_Weak();
                /*0x30ac33c*/ void set_Weak(bool value);
                /*0x30ac350*/ bool get_HasWeak();
                /*0x30ac35c*/ void ClearWeak();
                /*0x30ac36c*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption();
                /*0x30ac374*/ bool Equals(object other);
                /*0x30ac3d8*/ bool Equals(Google.Protobuf.Reflection.FieldOptions other);
                /*0x30ac524*/ int GetHashCode();
                /*0x30ac700*/ string ToString();
                /*0x30ac758*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x30ac778*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x30ac98c*/ int CalculateSize();
                /*0x30acb2c*/ void MergeFrom(Google.Protobuf.Reflection.FieldOptions other);
                /*0x30accc0*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x30acce0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);
                /*0x1ffc854*/ TValue GetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.FieldOptions, TValue> extension);
                /*0x1f302cc*/ Google.Protobuf.Collections.RepeatedField<TValue> GetExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FieldOptions, TValue> extension);
                /*0x1f302cc*/ Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FieldOptions, TValue> extension);
                /*0x1ffc854*/ void SetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.FieldOptions, TValue> extension, TValue value);
                /*0x1f2fec8*/ bool HasExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.FieldOptions, TValue> extension);
                /*0x1f30ebc*/ void ClearExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.FieldOptions, TValue> extension);
                /*0x1f30ebc*/ void ClearExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FieldOptions, TValue> extension);

                class Types
                {
                    enum CType
                    {
                        String = 0,
                        Cord = 1,
                        StringPiece = 2,
                    }

                    enum JSType
                    {
                        JsNormal = 0,
                        JsString = 1,
                        JsNumber = 2,
                    }
                }

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.FieldOptions.<> <>9;

                    static /*0x30ad0ec*/ <>c();
                    /*0x30ad154*/ <>c();
                    /*0x30ad15c*/ Google.Protobuf.Reflection.FieldOptions <.cctor>b__93_0();
                }
            }

            class OneofOptions : Google.Protobuf.IExtendableMessage<Google.Protobuf.Reflection.OneofOptions>, Google.Protobuf.IMessage<Google.Protobuf.Reflection.OneofOptions>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.OneofOptions>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.OneofOptions>, Google.Protobuf.IBufferMessage
            {
                static int UninterpretedOptionFieldNumber = 999;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.OneofOptions> _parser;
                static /*0x8*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.OneofOptions> _extensions;
                /*0x20*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;

                static /*0x30ada78*/ OneofOptions();
                static /*0x30ad1b4*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.OneofOptions> get_Parser();
                static /*0x30ad20c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x30ad35c*/ OneofOptions();
                /*0x30ad3e4*/ OneofOptions(Google.Protobuf.Reflection.OneofOptions other);
                /*0x30ad1ac*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.OneofOptions> get__Extensions();
                /*0x30ad310*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x30ad4a0*/ Google.Protobuf.Reflection.OneofOptions Clone();
                /*0x30ad4f8*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption();
                /*0x30ad500*/ bool Equals(object other);
                /*0x30ad564*/ bool Equals(Google.Protobuf.Reflection.OneofOptions other);
                /*0x30ad608*/ int GetHashCode();
                /*0x30ad674*/ string ToString();
                /*0x30ad6cc*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x30ad6ec*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x30ad7cc*/ int CalculateSize();
                /*0x30ad89c*/ void MergeFrom(Google.Protobuf.Reflection.OneofOptions other);
                /*0x30ad948*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x30ad968*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);
                /*0x1ffc854*/ TValue GetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.OneofOptions, TValue> extension);
                /*0x1f302cc*/ Google.Protobuf.Collections.RepeatedField<TValue> GetExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.OneofOptions, TValue> extension);
                /*0x1f302cc*/ Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.OneofOptions, TValue> extension);
                /*0x1ffc854*/ void SetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.OneofOptions, TValue> extension, TValue value);
                /*0x1f2fec8*/ bool HasExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.OneofOptions, TValue> extension);
                /*0x1f30ebc*/ void ClearExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.OneofOptions, TValue> extension);
                /*0x1f30ebc*/ void ClearExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.OneofOptions, TValue> extension);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.OneofOptions.<> <>9;

                    static /*0x30adc28*/ <>c();
                    /*0x30adc90*/ <>c();
                    /*0x30adc98*/ Google.Protobuf.Reflection.OneofOptions <.cctor>b__37_0();
                }
            }

            class EnumOptions : Google.Protobuf.IExtendableMessage<Google.Protobuf.Reflection.EnumOptions>, Google.Protobuf.IMessage<Google.Protobuf.Reflection.EnumOptions>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.EnumOptions>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.EnumOptions>, Google.Protobuf.IBufferMessage
            {
                static int AllowAliasFieldNumber = 2;
                static int DeprecatedFieldNumber = 3;
                static int UninterpretedOptionFieldNumber = 999;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumOptions> _parser;
                static /*0x8*/ bool AllowAliasDefaultValue;
                static /*0x9*/ bool DeprecatedDefaultValue;
                static /*0x10*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.EnumOptions> _extensions;
                /*0x20*/ int _hasBits0;
                /*0x24*/ bool allowAlias_;
                /*0x25*/ bool deprecated_;
                /*0x28*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;

                static /*0x30ae730*/ EnumOptions();
                static /*0x30adcf0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumOptions> get_Parser();
                static /*0x30add48*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x30a33b8*/ EnumOptions();
                /*0x30ade98*/ EnumOptions(Google.Protobuf.Reflection.EnumOptions other);
                /*0x30adce8*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.EnumOptions> get__Extensions();
                /*0x30ade4c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x30a2a80*/ Google.Protobuf.Reflection.EnumOptions Clone();
                /*0x30adf64*/ bool get_AllowAlias();
                /*0x30adfd4*/ void set_AllowAlias(bool value);
                /*0x30adfe8*/ bool get_HasAllowAlias();
                /*0x30adff4*/ void ClearAllowAlias();
                /*0x30ae004*/ bool get_Deprecated();
                /*0x30ae074*/ void set_Deprecated(bool value);
                /*0x30ae088*/ bool get_HasDeprecated();
                /*0x30ae094*/ void ClearDeprecated();
                /*0x30ae0a4*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption();
                /*0x30ae0ac*/ bool Equals(object other);
                /*0x30ae110*/ bool Equals(Google.Protobuf.Reflection.EnumOptions other);
                /*0x30ae1ec*/ int GetHashCode();
                /*0x30ae2f0*/ string ToString();
                /*0x30ae348*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x30ae368*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x30ae4a8*/ int CalculateSize();
                /*0x30a3440*/ void MergeFrom(Google.Protobuf.Reflection.EnumOptions other);
                /*0x30ae590*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x30ae5b0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);
                /*0x1ffc854*/ TValue GetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumOptions, TValue> extension);
                /*0x1f302cc*/ Google.Protobuf.Collections.RepeatedField<TValue> GetExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumOptions, TValue> extension);
                /*0x1f302cc*/ Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumOptions, TValue> extension);
                /*0x1ffc854*/ void SetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumOptions, TValue> extension, TValue value);
                /*0x1f2fec8*/ bool HasExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumOptions, TValue> extension);
                /*0x1f30ebc*/ void ClearExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumOptions, TValue> extension);
                /*0x1f30ebc*/ void ClearExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumOptions, TValue> extension);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.EnumOptions.<> <>9;

                    static /*0x30ae8ec*/ <>c();
                    /*0x30ae954*/ <>c();
                    /*0x30ae95c*/ Google.Protobuf.Reflection.EnumOptions <.cctor>b__56_0();
                }
            }

            class EnumValueOptions : Google.Protobuf.IExtendableMessage<Google.Protobuf.Reflection.EnumValueOptions>, Google.Protobuf.IMessage<Google.Protobuf.Reflection.EnumValueOptions>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.EnumValueOptions>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.EnumValueOptions>, Google.Protobuf.IBufferMessage
            {
                static int DeprecatedFieldNumber = 1;
                static int UninterpretedOptionFieldNumber = 999;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumValueOptions> _parser;
                static /*0x8*/ bool DeprecatedDefaultValue;
                static /*0x10*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.EnumValueOptions> _extensions;
                /*0x20*/ int _hasBits0;
                /*0x24*/ bool deprecated_;
                /*0x28*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;

                static /*0x30af27c*/ EnumValueOptions();
                static /*0x30ae9b4*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.EnumValueOptions> get_Parser();
                static /*0x30aea0c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x30a4e8c*/ EnumValueOptions();
                /*0x30aeb5c*/ EnumValueOptions(Google.Protobuf.Reflection.EnumValueOptions other);
                /*0x30ae9ac*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.EnumValueOptions> get__Extensions();
                /*0x30aeb10*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x30a4744*/ Google.Protobuf.Reflection.EnumValueOptions Clone();
                /*0x30aec28*/ bool get_Deprecated();
                /*0x30aec98*/ void set_Deprecated(bool value);
                /*0x30aecac*/ bool get_HasDeprecated();
                /*0x30aecb8*/ void ClearDeprecated();
                /*0x30aecc8*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption();
                /*0x30aecd0*/ bool Equals(object other);
                /*0x30aed34*/ bool Equals(Google.Protobuf.Reflection.EnumValueOptions other);
                /*0x30aedf4*/ int GetHashCode();
                /*0x30aeeb0*/ string ToString();
                /*0x30aef08*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x30aef28*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x30af038*/ int CalculateSize();
                /*0x30a4f14*/ void MergeFrom(Google.Protobuf.Reflection.EnumValueOptions other);
                /*0x30af118*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x30af138*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);
                /*0x1ffc854*/ TValue GetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumValueOptions, TValue> extension);
                /*0x1f302cc*/ Google.Protobuf.Collections.RepeatedField<TValue> GetExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumValueOptions, TValue> extension);
                /*0x1f302cc*/ Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumValueOptions, TValue> extension);
                /*0x1ffc854*/ void SetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumValueOptions, TValue> extension, TValue value);
                /*0x1f2fec8*/ bool HasExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumValueOptions, TValue> extension);
                /*0x1f30ebc*/ void ClearExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumValueOptions, TValue> extension);
                /*0x1f30ebc*/ void ClearExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumValueOptions, TValue> extension);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.EnumValueOptions.<> <>9;

                    static /*0x30af438*/ <>c();
                    /*0x30af4a0*/ <>c();
                    /*0x30af4a8*/ Google.Protobuf.Reflection.EnumValueOptions <.cctor>b__47_0();
                }
            }

            class ServiceOptions : Google.Protobuf.IExtendableMessage<Google.Protobuf.Reflection.ServiceOptions>, Google.Protobuf.IMessage<Google.Protobuf.Reflection.ServiceOptions>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.ServiceOptions>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.ServiceOptions>, Google.Protobuf.IBufferMessage
            {
                static int DeprecatedFieldNumber = 33;
                static int UninterpretedOptionFieldNumber = 999;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.ServiceOptions> _parser;
                static /*0x8*/ bool DeprecatedDefaultValue;
                static /*0x10*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.ServiceOptions> _extensions;
                /*0x20*/ int _hasBits0;
                /*0x24*/ bool deprecated_;
                /*0x28*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;

                static /*0x30afdd0*/ ServiceOptions();
                static /*0x30af500*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.ServiceOptions> get_Parser();
                static /*0x30af558*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x30a5dc8*/ ServiceOptions();
                /*0x30af6a8*/ ServiceOptions(Google.Protobuf.Reflection.ServiceOptions other);
                /*0x30af4f8*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.ServiceOptions> get__Extensions();
                /*0x30af65c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x30a5680*/ Google.Protobuf.Reflection.ServiceOptions Clone();
                /*0x30af774*/ bool get_Deprecated();
                /*0x30af7e4*/ void set_Deprecated(bool value);
                /*0x30af7f8*/ bool get_HasDeprecated();
                /*0x30af804*/ void ClearDeprecated();
                /*0x30af814*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption();
                /*0x30af81c*/ bool Equals(object other);
                /*0x30af880*/ bool Equals(Google.Protobuf.Reflection.ServiceOptions other);
                /*0x30af940*/ int GetHashCode();
                /*0x30af9fc*/ string ToString();
                /*0x30afa54*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x30afa74*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x30afb88*/ int CalculateSize();
                /*0x30a5e50*/ void MergeFrom(Google.Protobuf.Reflection.ServiceOptions other);
                /*0x30afc6c*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x30afc8c*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);
                /*0x1ffc854*/ TValue GetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.ServiceOptions, TValue> extension);
                /*0x1f302cc*/ Google.Protobuf.Collections.RepeatedField<TValue> GetExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ServiceOptions, TValue> extension);
                /*0x1f302cc*/ Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ServiceOptions, TValue> extension);
                /*0x1ffc854*/ void SetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.ServiceOptions, TValue> extension, TValue value);
                /*0x1f2fec8*/ bool HasExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.ServiceOptions, TValue> extension);
                /*0x1f30ebc*/ void ClearExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.ServiceOptions, TValue> extension);
                /*0x1f30ebc*/ void ClearExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ServiceOptions, TValue> extension);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.ServiceOptions.<> <>9;

                    static /*0x30aff8c*/ <>c();
                    /*0x30afff4*/ <>c();
                    /*0x30afffc*/ Google.Protobuf.Reflection.ServiceOptions <.cctor>b__47_0();
                }
            }

            class MethodOptions : Google.Protobuf.IExtendableMessage<Google.Protobuf.Reflection.MethodOptions>, Google.Protobuf.IMessage<Google.Protobuf.Reflection.MethodOptions>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.MethodOptions>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.MethodOptions>, Google.Protobuf.IBufferMessage
            {
                static int DeprecatedFieldNumber = 33;
                static int IdempotencyLevelFieldNumber = 34;
                static int UninterpretedOptionFieldNumber = 999;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.MethodOptions> _parser;
                static /*0x8*/ bool DeprecatedDefaultValue;
                static /*0xc*/ Google.Protobuf.Reflection.MethodOptions.Types.IdempotencyLevel IdempotencyLevelDefaultValue;
                static /*0x10*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption> _repeated_uninterpretedOption_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.MethodOptions> _extensions;
                /*0x20*/ int _hasBits0;
                /*0x24*/ bool deprecated_;
                /*0x28*/ Google.Protobuf.Reflection.MethodOptions.Types.IdempotencyLevel idempotencyLevel_;
                /*0x30*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> uninterpretedOption_;

                static /*0x30b0ac8*/ MethodOptions();
                static /*0x30b0054*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.MethodOptions> get_Parser();
                static /*0x30b00ac*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x30a7230*/ MethodOptions();
                /*0x30b01fc*/ MethodOptions(Google.Protobuf.Reflection.MethodOptions other);
                /*0x30b004c*/ Google.Protobuf.ExtensionSet<Google.Protobuf.Reflection.MethodOptions> get__Extensions();
                /*0x30b01b0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x30a65f8*/ Google.Protobuf.Reflection.MethodOptions Clone();
                /*0x30b02d0*/ bool get_Deprecated();
                /*0x30b0340*/ void set_Deprecated(bool value);
                /*0x30b0354*/ bool get_HasDeprecated();
                /*0x30b0360*/ void ClearDeprecated();
                /*0x30b0370*/ Google.Protobuf.Reflection.MethodOptions.Types.IdempotencyLevel get_IdempotencyLevel();
                /*0x30b03e0*/ void set_IdempotencyLevel(Google.Protobuf.Reflection.MethodOptions.Types.IdempotencyLevel value);
                /*0x30b03f4*/ bool get_HasIdempotencyLevel();
                /*0x30b0400*/ void ClearIdempotencyLevel();
                /*0x30b0410*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption> get_UninterpretedOption();
                /*0x30b0418*/ bool Equals(object other);
                /*0x30b047c*/ bool Equals(Google.Protobuf.Reflection.MethodOptions other);
                /*0x30b0558*/ int GetHashCode();
                /*0x30b0640*/ string ToString();
                /*0x30b0698*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x30b06b8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x30b0800*/ int CalculateSize();
                /*0x30a72b8*/ void MergeFrom(Google.Protobuf.Reflection.MethodOptions other);
                /*0x30b0930*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x30b0950*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);
                /*0x1ffc854*/ TValue GetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.MethodOptions, TValue> extension);
                /*0x1f302cc*/ Google.Protobuf.Collections.RepeatedField<TValue> GetExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MethodOptions, TValue> extension);
                /*0x1f302cc*/ Google.Protobuf.Collections.RepeatedField<TValue> GetOrInitializeExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MethodOptions, TValue> extension);
                /*0x1ffc854*/ void SetExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.MethodOptions, TValue> extension, TValue value);
                /*0x1f2fec8*/ bool HasExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.MethodOptions, TValue> extension);
                /*0x1f30ebc*/ void ClearExtension<TValue>(Google.Protobuf.Extension<Google.Protobuf.Reflection.MethodOptions, TValue> extension);
                /*0x1f30ebc*/ void ClearExtension<TValue>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MethodOptions, TValue> extension);

                class Types
                {
                    enum IdempotencyLevel
                    {
                        IdempotencyUnknown = 0,
                        NoSideEffects = 1,
                        Idempotent = 2,
                    }
                }

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.MethodOptions.<> <>9;

                    static /*0x30b0c88*/ <>c();
                    /*0x30b0cf0*/ <>c();
                    /*0x30b0cf8*/ Google.Protobuf.Reflection.MethodOptions <.cctor>b__57_0();
                }
            }

            class UninterpretedOption : Google.Protobuf.IMessage<Google.Protobuf.Reflection.UninterpretedOption>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.UninterpretedOption>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.UninterpretedOption>, Google.Protobuf.IBufferMessage
            {
                static int NameFieldNumber = 2;
                static int IdentifierValueFieldNumber = 3;
                static int PositiveIntValueFieldNumber = 4;
                static int NegativeIntValueFieldNumber = 5;
                static int DoubleValueFieldNumber = 6;
                static int StringValueFieldNumber = 7;
                static int AggregateValueFieldNumber = 8;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.UninterpretedOption> _parser;
                static /*0x8*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart> _repeated_name_codec;
                static /*0x10*/ string IdentifierValueDefaultValue;
                static /*0x18*/ ulong PositiveIntValueDefaultValue;
                static /*0x20*/ long NegativeIntValueDefaultValue;
                static /*0x28*/ double DoubleValueDefaultValue;
                static /*0x30*/ Google.Protobuf.ByteString StringValueDefaultValue;
                static /*0x38*/ string AggregateValueDefaultValue;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ int _hasBits0;
                /*0x20*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart> name_;
                /*0x28*/ string identifierValue_;
                /*0x30*/ ulong positiveIntValue_;
                /*0x38*/ long negativeIntValue_;
                /*0x40*/ double doubleValue_;
                /*0x48*/ Google.Protobuf.ByteString stringValue_;
                /*0x50*/ string aggregateValue_;

                static /*0x30b2260*/ UninterpretedOption();
                static /*0x30b0d48*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.UninterpretedOption> get_Parser();
                static /*0x30b0da0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x30b0ef0*/ UninterpretedOption();
                /*0x30b0f78*/ UninterpretedOption(Google.Protobuf.Reflection.UninterpretedOption other);
                /*0x30b0ea4*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x30b104c*/ Google.Protobuf.Reflection.UninterpretedOption Clone();
                /*0x30b10a4*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart> get_Name();
                /*0x30b10ac*/ string get_IdentifierValue();
                /*0x30b1110*/ void set_IdentifierValue(string value);
                /*0x30b118c*/ bool get_HasIdentifierValue();
                /*0x30b119c*/ void ClearIdentifierValue();
                /*0x30b11a8*/ ulong get_PositiveIntValue();
                /*0x30b1218*/ void set_PositiveIntValue(ulong value);
                /*0x30b122c*/ bool get_HasPositiveIntValue();
                /*0x30b1238*/ void ClearPositiveIntValue();
                /*0x30b1248*/ long get_NegativeIntValue();
                /*0x30b12b8*/ void set_NegativeIntValue(long value);
                /*0x30b12cc*/ bool get_HasNegativeIntValue();
                /*0x30b12d8*/ void ClearNegativeIntValue();
                /*0x30b12e8*/ double get_DoubleValue();
                /*0x30b1358*/ void set_DoubleValue(double value);
                /*0x30b136c*/ bool get_HasDoubleValue();
                /*0x30b1378*/ void ClearDoubleValue();
                /*0x30b1388*/ Google.Protobuf.ByteString get_StringValue();
                /*0x30b13ec*/ void set_StringValue(Google.Protobuf.ByteString value);
                /*0x30b1468*/ bool get_HasStringValue();
                /*0x30b14c8*/ void ClearStringValue();
                /*0x30b14d4*/ string get_AggregateValue();
                /*0x30b1538*/ void set_AggregateValue(string value);
                /*0x30b15b4*/ bool get_HasAggregateValue();
                /*0x30b15c4*/ void ClearAggregateValue();
                /*0x30b15d0*/ bool Equals(object other);
                /*0x30b1634*/ bool Equals(Google.Protobuf.Reflection.UninterpretedOption other);
                /*0x30b184c*/ int GetHashCode();
                /*0x30b1a14*/ string ToString();
                /*0x30b1a6c*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x30b1a8c*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x30b1c70*/ int CalculateSize();
                /*0x30b1e70*/ void MergeFrom(Google.Protobuf.Reflection.UninterpretedOption other);
                /*0x30b1fbc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x30b1fdc*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class Types
                {
                    class NamePart : Google.Protobuf.IMessage<Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart>, Google.Protobuf.IBufferMessage
                    {
                        static int NamePart_FieldNumber = 1;
                        static int IsExtensionFieldNumber = 2;
                        static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart> _parser;
                        static /*0x8*/ string NamePart_DefaultValue;
                        static /*0x10*/ bool IsExtensionDefaultValue;
                        /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                        /*0x18*/ int _hasBits0;
                        /*0x20*/ string namePart_;
                        /*0x28*/ bool isExtension_;

                        static /*0x30b2d4c*/ NamePart();
                        static /*0x30b24cc*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart> get_Parser();
                        static /*0x30b2524*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                        /*0x30b263c*/ NamePart();
                        /*0x30b2644*/ NamePart(Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart other);
                        /*0x30b25f0*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                        /*0x30b26a8*/ Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart Clone();
                        /*0x30b2700*/ string get_NamePart_();
                        /*0x30b2764*/ void set_NamePart_(string value);
                        /*0x30b27e0*/ bool get_HasNamePart_();
                        /*0x30b27f0*/ void ClearNamePart_();
                        /*0x30b27fc*/ bool get_IsExtension();
                        /*0x30b286c*/ void set_IsExtension(bool value);
                        /*0x30b2880*/ bool get_HasIsExtension();
                        /*0x30b288c*/ void ClearIsExtension();
                        /*0x30b289c*/ bool Equals(object other);
                        /*0x30b2900*/ bool Equals(Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart other);
                        /*0x30b2990*/ int GetHashCode();
                        /*0x30b2a3c*/ string ToString();
                        /*0x30b2a94*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                        /*0x30b2ab4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                        /*0x30b2b4c*/ int CalculateSize();
                        /*0x30b2be8*/ void MergeFrom(Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart other);
                        /*0x30b2c68*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                        /*0x30b2c88*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                        class <>c
                        {
                            static /*0x0*/ Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart.<> <>9;

                            static /*0x30b2e9c*/ <>c();
                            /*0x30b2f04*/ <>c();
                            /*0x30b2f0c*/ Google.Protobuf.Reflection.UninterpretedOption.Types.NamePart <.cctor>b__41_0();
                        }
                    }
                }

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.UninterpretedOption.<> <>9;

                    static /*0x30b2f60*/ <>c();
                    /*0x30b2fc8*/ <>c();
                    /*0x30b2fd0*/ Google.Protobuf.Reflection.UninterpretedOption <.cctor>b__83_0();
                }
            }

            class SourceCodeInfo : Google.Protobuf.IMessage<Google.Protobuf.Reflection.SourceCodeInfo>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.SourceCodeInfo>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.SourceCodeInfo>, Google.Protobuf.IBufferMessage
            {
                static int LocationFieldNumber = 1;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.SourceCodeInfo> _parser;
                static /*0x8*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.SourceCodeInfo.Types.Location> _repeated_location_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.SourceCodeInfo.Types.Location> location_;

                static /*0x30b37d8*/ SourceCodeInfo();
                static /*0x30b3020*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.SourceCodeInfo> get_Parser();
                static /*0x30b3078*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x30b31c8*/ SourceCodeInfo();
                /*0x30b3250*/ SourceCodeInfo(Google.Protobuf.Reflection.SourceCodeInfo other);
                /*0x30b317c*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x30b32dc*/ Google.Protobuf.Reflection.SourceCodeInfo Clone();
                /*0x30b3334*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.SourceCodeInfo.Types.Location> get_Location();
                /*0x30b333c*/ bool Equals(object other);
                /*0x30b33a0*/ bool Equals(Google.Protobuf.Reflection.SourceCodeInfo other);
                /*0x30b3430*/ int GetHashCode();
                /*0x30b347c*/ string ToString();
                /*0x30b34d4*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x30b34f4*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x30b35ac*/ int CalculateSize();
                /*0x30b3654*/ void MergeFrom(Google.Protobuf.Reflection.SourceCodeInfo other);
                /*0x30b36dc*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x30b36fc*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class Types
                {
                    class Location : Google.Protobuf.IMessage<Google.Protobuf.Reflection.SourceCodeInfo.Types.Location>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.SourceCodeInfo.Types.Location>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.SourceCodeInfo.Types.Location>, Google.Protobuf.IBufferMessage
                    {
                        static int PathFieldNumber = 1;
                        static int SpanFieldNumber = 2;
                        static int LeadingCommentsFieldNumber = 3;
                        static int TrailingCommentsFieldNumber = 4;
                        static int LeadingDetachedCommentsFieldNumber = 6;
                        static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.SourceCodeInfo.Types.Location> _parser;
                        static /*0x8*/ Google.Protobuf.FieldCodec<int> _repeated_path_codec;
                        static /*0x10*/ Google.Protobuf.FieldCodec<int> _repeated_span_codec;
                        static /*0x18*/ string LeadingCommentsDefaultValue;
                        static /*0x20*/ string TrailingCommentsDefaultValue;
                        static /*0x28*/ Google.Protobuf.FieldCodec<string> _repeated_leadingDetachedComments_codec;
                        /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                        /*0x18*/ Google.Protobuf.Collections.RepeatedField<int> path_;
                        /*0x20*/ Google.Protobuf.Collections.RepeatedField<int> span_;
                        /*0x28*/ string leadingComments_;
                        /*0x30*/ string trailingComments_;
                        /*0x38*/ Google.Protobuf.Collections.RepeatedField<string> leadingDetachedComments_;

                        static /*0x30b4884*/ Location();
                        static /*0x30b3988*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.SourceCodeInfo.Types.Location> get_Parser();
                        static /*0x30b39e0*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                        /*0x30b3af8*/ Location();
                        /*0x30b3bf8*/ Location(Google.Protobuf.Reflection.SourceCodeInfo.Types.Location other);
                        /*0x30b3aac*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                        /*0x30b3cf8*/ Google.Protobuf.Reflection.SourceCodeInfo.Types.Location Clone();
                        /*0x30b3d50*/ Google.Protobuf.Collections.RepeatedField<int> get_Path();
                        /*0x30b3d58*/ Google.Protobuf.Collections.RepeatedField<int> get_Span();
                        /*0x30b3d60*/ string get_LeadingComments();
                        /*0x30b3dc4*/ void set_LeadingComments(string value);
                        /*0x30b3e40*/ bool get_HasLeadingComments();
                        /*0x30b3e50*/ void ClearLeadingComments();
                        /*0x30b3e5c*/ string get_TrailingComments();
                        /*0x30b3ec0*/ void set_TrailingComments(string value);
                        /*0x30b3f3c*/ bool get_HasTrailingComments();
                        /*0x30b3f4c*/ void ClearTrailingComments();
                        /*0x30b3f58*/ Google.Protobuf.Collections.RepeatedField<string> get_LeadingDetachedComments();
                        /*0x30b3f60*/ bool Equals(object other);
                        /*0x30b3fc4*/ bool Equals(Google.Protobuf.Reflection.SourceCodeInfo.Types.Location other);
                        /*0x30b40e8*/ int GetHashCode();
                        /*0x30b41bc*/ string ToString();
                        /*0x30b4214*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                        /*0x30b4234*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                        /*0x30b43b4*/ int CalculateSize();
                        /*0x30b455c*/ void MergeFrom(Google.Protobuf.Reflection.SourceCodeInfo.Types.Location other);
                        /*0x30b4658*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                        /*0x30b4678*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                        class <>c
                        {
                            static /*0x0*/ Google.Protobuf.Reflection.SourceCodeInfo.Types.Location.<> <>9;

                            static /*0x30b4a44*/ <>c();
                            /*0x30b4aac*/ <>c();
                            /*0x30b4ab4*/ Google.Protobuf.Reflection.SourceCodeInfo.Types.Location <.cctor>b__55_0();
                        }
                    }
                }

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.SourceCodeInfo.<> <>9;

                    static /*0x30b4b04*/ <>c();
                    /*0x30b4b6c*/ <>c();
                    /*0x30b4b74*/ Google.Protobuf.Reflection.SourceCodeInfo <.cctor>b__28_0();
                }
            }

            class GeneratedCodeInfo : Google.Protobuf.IMessage<Google.Protobuf.Reflection.GeneratedCodeInfo>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.GeneratedCodeInfo>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.GeneratedCodeInfo>, Google.Protobuf.IBufferMessage
            {
                static int AnnotationFieldNumber = 1;
                static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.GeneratedCodeInfo> _parser;
                static /*0x8*/ Google.Protobuf.FieldCodec<Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation> _repeated_annotation_codec;
                /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                /*0x18*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation> annotation_;

                static /*0x30b537c*/ GeneratedCodeInfo();
                static /*0x30b4bc4*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.GeneratedCodeInfo> get_Parser();
                static /*0x30b4c1c*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                /*0x30b4d6c*/ GeneratedCodeInfo();
                /*0x30b4df4*/ GeneratedCodeInfo(Google.Protobuf.Reflection.GeneratedCodeInfo other);
                /*0x30b4d20*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                /*0x30b4e80*/ Google.Protobuf.Reflection.GeneratedCodeInfo Clone();
                /*0x30b4ed8*/ Google.Protobuf.Collections.RepeatedField<Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation> get_Annotation();
                /*0x30b4ee0*/ bool Equals(object other);
                /*0x30b4f44*/ bool Equals(Google.Protobuf.Reflection.GeneratedCodeInfo other);
                /*0x30b4fd4*/ int GetHashCode();
                /*0x30b5020*/ string ToString();
                /*0x30b5078*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                /*0x30b5098*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                /*0x30b5150*/ int CalculateSize();
                /*0x30b51f8*/ void MergeFrom(Google.Protobuf.Reflection.GeneratedCodeInfo other);
                /*0x30b5280*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                /*0x30b52a0*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                class Types
                {
                    class Annotation : Google.Protobuf.IMessage<Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation>, Google.Protobuf.IMessage, System.IEquatable<Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation>, Google.Protobuf.IDeepCloneable<Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation>, Google.Protobuf.IBufferMessage
                    {
                        static int PathFieldNumber = 1;
                        static int SourceFileFieldNumber = 2;
                        static int BeginFieldNumber = 3;
                        static int EndFieldNumber = 4;
                        static /*0x0*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation> _parser;
                        static /*0x8*/ Google.Protobuf.FieldCodec<int> _repeated_path_codec;
                        static /*0x10*/ string SourceFileDefaultValue;
                        static /*0x18*/ int BeginDefaultValue;
                        static /*0x1c*/ int EndDefaultValue;
                        /*0x10*/ Google.Protobuf.UnknownFieldSet _unknownFields;
                        /*0x18*/ int _hasBits0;
                        /*0x20*/ Google.Protobuf.Collections.RepeatedField<int> path_;
                        /*0x28*/ string sourceFile_;
                        /*0x30*/ int begin_;
                        /*0x34*/ int end_;

                        static /*0x30b6240*/ Annotation();
                        static /*0x30b552c*/ Google.Protobuf.MessageParser<Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation> get_Parser();
                        static /*0x30b5584*/ Google.Protobuf.Reflection.MessageDescriptor get_Descriptor();
                        /*0x30b569c*/ Annotation();
                        /*0x30b5724*/ Annotation(Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation other);
                        /*0x30b5650*/ Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor();
                        /*0x30b57d0*/ Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation Clone();
                        /*0x30b5828*/ Google.Protobuf.Collections.RepeatedField<int> get_Path();
                        /*0x30b5830*/ string get_SourceFile();
                        /*0x30b5894*/ void set_SourceFile(string value);
                        /*0x30b5910*/ bool get_HasSourceFile();
                        /*0x30b5920*/ void ClearSourceFile();
                        /*0x30b592c*/ int get_Begin();
                        /*0x30b599c*/ void set_Begin(int value);
                        /*0x30b59b0*/ bool get_HasBegin();
                        /*0x30b59bc*/ void ClearBegin();
                        /*0x30b59cc*/ int get_End();
                        /*0x30b5a3c*/ void set_End(int value);
                        /*0x30b5a50*/ bool get_HasEnd();
                        /*0x30b5a5c*/ void ClearEnd();
                        /*0x30b5a6c*/ bool Equals(object other);
                        /*0x30b5ad0*/ bool Equals(Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation other);
                        /*0x30b5bc0*/ int GetHashCode();
                        /*0x30b5c80*/ string ToString();
                        /*0x30b5cd8*/ void WriteTo(Google.Protobuf.CodedOutputStream output);
                        /*0x30b5cf8*/ void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref Google.Protobuf.WriteContext output);
                        /*0x30b5e40*/ int CalculateSize();
                        /*0x30b5fb4*/ void MergeFrom(Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation other);
                        /*0x30b6098*/ void MergeFrom(Google.Protobuf.CodedInputStream input);
                        /*0x30b60b8*/ void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref Google.Protobuf.ParseContext input);

                        class <>c
                        {
                            static /*0x0*/ Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation.<> <>9;

                            static /*0x30b63b4*/ <>c();
                            /*0x30b641c*/ <>c();
                            /*0x30b6424*/ Google.Protobuf.Reflection.GeneratedCodeInfo.Types.Annotation <.cctor>b__55_0();
                        }
                    }
                }

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.GeneratedCodeInfo.<> <>9;

                    static /*0x30b6474*/ <>c();
                    /*0x30b64dc*/ <>c();
                    /*0x30b64e4*/ Google.Protobuf.Reflection.GeneratedCodeInfo <.cctor>b__28_0();
                }
            }

            class DescriptorBase : Google.Protobuf.Reflection.IDescriptor
            {
                /*0x10*/ int <Index>k__BackingField;
                /*0x18*/ string <FullName>k__BackingField;
                /*0x20*/ Google.Protobuf.Reflection.FileDescriptor <File>k__BackingField;

                /*0x30b6534*/ DescriptorBase(Google.Protobuf.Reflection.FileDescriptor file, string fullName, int index);
                /*0x30b658c*/ int get_Index();
                /*0x1f30214*/ string get_Name();
                /*0x30b6594*/ string get_FullName();
                /*0x30b659c*/ Google.Protobuf.Reflection.FileDescriptor get_File();
                /*0x30b65a4*/ Google.Protobuf.Reflection.DescriptorDeclaration get_Declaration();
                /*0x30b65c0*/ System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> GetNestedDescriptorListForField(int fieldNumber);
            }

            class DescriptorDeclaration
            {
                /*0x10*/ Google.Protobuf.Reflection.IDescriptor <Descriptor>k__BackingField;
                /*0x18*/ int <StartLine>k__BackingField;
                /*0x1c*/ int <StartColumn>k__BackingField;
                /*0x20*/ int <EndLine>k__BackingField;
                /*0x24*/ int <EndColumn>k__BackingField;
                /*0x28*/ string <LeadingComments>k__BackingField;
                /*0x30*/ string <TrailingComments>k__BackingField;
                /*0x38*/ System.Collections.Generic.IReadOnlyList<string> <LeadingDetachedComments>k__BackingField;

                static /*0x30b67f4*/ Google.Protobuf.Reflection.DescriptorDeclaration FromProto(Google.Protobuf.Reflection.IDescriptor descriptor, Google.Protobuf.Reflection.SourceCodeInfo.Types.Location location);
                /*0x30b6608*/ DescriptorDeclaration(Google.Protobuf.Reflection.IDescriptor descriptor, Google.Protobuf.Reflection.SourceCodeInfo.Types.Location location);
                /*0x30b65c8*/ Google.Protobuf.Reflection.IDescriptor get_Descriptor();
                /*0x30b65d0*/ int get_StartLine();
                /*0x30b65d8*/ int get_StartColumn();
                /*0x30b65e0*/ int get_EndLine();
                /*0x30b65e8*/ int get_EndColumn();
                /*0x30b65f0*/ string get_LeadingComments();
                /*0x30b65f8*/ string get_TrailingComments();
                /*0x30b6600*/ System.Collections.Generic.IReadOnlyList<string> get_LeadingDetachedComments();
            }

            class DescriptorPool
            {
                static /*0x0*/ System.Text.RegularExpressions.Regex ValidationRegex;
                /*0x10*/ System.Collections.Generic.IDictionary<string, Google.Protobuf.Reflection.IDescriptor> descriptorsByName;
                /*0x18*/ System.Collections.Generic.IDictionary<Google.Protobuf.ObjectIntPair<Google.Protobuf.Reflection.IDescriptor>, Google.Protobuf.Reflection.FieldDescriptor> fieldsByNumber;
                /*0x20*/ System.Collections.Generic.IDictionary<Google.Protobuf.ObjectIntPair<Google.Protobuf.Reflection.IDescriptor>, Google.Protobuf.Reflection.EnumValueDescriptor> enumValuesByNumber;
                /*0x28*/ System.Collections.Generic.HashSet<Google.Protobuf.Reflection.FileDescriptor> dependencies;

                static /*0x30b84c4*/ DescriptorPool();
                static /*0x30b78e0*/ void ValidateSymbolName(Google.Protobuf.Reflection.IDescriptor descriptor);
                /*0x30b685c*/ DescriptorPool(System.Collections.Generic.IEnumerable<Google.Protobuf.Reflection.FileDescriptor> dependencyFiles);
                /*0x30b6eb0*/ void ImportPublicDependencies(Google.Protobuf.Reflection.FileDescriptor file);
                /*0x1ffc854*/ T FindSymbol<T>(string fullName);
                /*0x30b7198*/ void AddPackage(string fullName, Google.Protobuf.Reflection.FileDescriptor file);
                /*0x30b749c*/ void AddSymbol(Google.Protobuf.Reflection.IDescriptor descriptor);
                /*0x30b7b28*/ Google.Protobuf.Reflection.FieldDescriptor FindFieldByNumber(Google.Protobuf.Reflection.MessageDescriptor messageDescriptor, int number);
                /*0x30b7c2c*/ Google.Protobuf.Reflection.EnumValueDescriptor FindEnumValueByNumber(Google.Protobuf.Reflection.EnumDescriptor enumDescriptor, int number);
                /*0x30b7d30*/ void AddFieldByNumber(Google.Protobuf.Reflection.FieldDescriptor field);
                /*0x30b8048*/ void AddEnumValueByNumber(Google.Protobuf.Reflection.EnumValueDescriptor enumValue);
                /*0x30b81d0*/ Google.Protobuf.Reflection.IDescriptor LookupSymbol(string name, Google.Protobuf.Reflection.IDescriptor relativeTo);
            }

            class DescriptorUtil
            {
                static /*0x1f32888*/ System.Collections.Generic.IList<TOutput> ConvertAndMakeReadOnly<TInput, TOutput>(System.Collections.Generic.IList<TInput> input, Google.Protobuf.Reflection.DescriptorUtil.IndexedConverter<TInput, TOutput> converter);

                class IndexedConverter<TInput, TOutput> : System.MulticastDelegate
                {
                    IndexedConverter(object object, nint method);
                    /*0x1ffc854*/ TOutput Invoke(TInput element, int index);
                    /*0x1ffc854*/ System.IAsyncResult BeginInvoke(TInput element, int index, System.AsyncCallback callback, object object);
                    /*0x1ffc854*/ TOutput EndInvoke(System.IAsyncResult result);
                }
            }

            class DescriptorValidationException : System.Exception
            {
                /*0x90*/ string name;
                /*0x98*/ string description;

                /*0x30b85a4*/ DescriptorValidationException(Google.Protobuf.Reflection.IDescriptor problemDescriptor, string description);
                /*0x30b8738*/ DescriptorValidationException(Google.Protobuf.Reflection.IDescriptor problemDescriptor, string description, System.Exception cause);
                /*0x30b8594*/ string get_ProblemSymbolName();
                /*0x30b859c*/ string get_Description();
            }

            class EnumDescriptor : Google.Protobuf.Reflection.DescriptorBase
            {
                /*0x28*/ Google.Protobuf.Reflection.EnumDescriptorProto proto;
                /*0x30*/ Google.Protobuf.Reflection.MessageDescriptor containingType;
                /*0x38*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.EnumValueDescriptor> values;
                /*0x40*/ System.Type clrType;

                /*0x30b88d4*/ EnumDescriptor(Google.Protobuf.Reflection.EnumDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.MessageDescriptor parent, int index, System.Type clrType);
                /*0x30b8ba8*/ Google.Protobuf.Reflection.EnumDescriptorProto get_Proto();
                /*0x30b8bb0*/ string get_Name();
                /*0x30b8bc8*/ System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> GetNestedDescriptorListForField(int fieldNumber);
                /*0x30b8c40*/ System.Type get_ClrType();
                /*0x30b8c48*/ Google.Protobuf.Reflection.MessageDescriptor get_ContainingType();
                /*0x30b8c50*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.EnumValueDescriptor> get_Values();
                /*0x30b8c58*/ Google.Protobuf.Reflection.EnumValueDescriptor FindValueByNumber(int number);
                /*0x30b8c88*/ Google.Protobuf.Reflection.EnumValueDescriptor FindValueByName(string name);
                /*0x30b8d14*/ Google.Protobuf.Reflection.CustomOptions get_CustomOptions();
                /*0x30b8da4*/ Google.Protobuf.Reflection.EnumOptions GetOptions();
                /*0x1ffc854*/ T GetOption<T>(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumOptions, T> extension);
                /*0x1f302cc*/ Google.Protobuf.Collections.RepeatedField<T> GetOption<T>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumOptions, T> extension);

                class <>c__DisplayClass4_0
                {
                    /*0x10*/ Google.Protobuf.Reflection.FileDescriptor file;
                    /*0x18*/ Google.Protobuf.Reflection.EnumDescriptor <>4__this;

                    /*0x30b8af0*/ <>c__DisplayClass4_0();
                    /*0x30b8dc8*/ Google.Protobuf.Reflection.EnumValueDescriptor <.ctor>b__0(Google.Protobuf.Reflection.EnumValueDescriptorProto value, int i);
                }
            }

            class EnumValueDescriptor : Google.Protobuf.Reflection.DescriptorBase
            {
                /*0x28*/ Google.Protobuf.Reflection.EnumDescriptor enumDescriptor;
                /*0x30*/ Google.Protobuf.Reflection.EnumValueDescriptorProto proto;

                /*0x30b8e40*/ EnumValueDescriptor(Google.Protobuf.Reflection.EnumValueDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.EnumDescriptor parent, int index);
                /*0x30b8f30*/ Google.Protobuf.Reflection.EnumValueDescriptorProto get_Proto();
                /*0x30b8f38*/ string get_Name();
                /*0x30b8f50*/ int get_Number();
                /*0x30b8f68*/ Google.Protobuf.Reflection.EnumDescriptor get_EnumDescriptor();
                /*0x30b8f70*/ Google.Protobuf.Reflection.CustomOptions get_CustomOptions();
                /*0x30b9000*/ Google.Protobuf.Reflection.EnumValueOptions GetOptions();
                /*0x1ffc854*/ T GetOption<T>(Google.Protobuf.Extension<Google.Protobuf.Reflection.EnumValueOptions, T> extension);
                /*0x1f302cc*/ Google.Protobuf.Collections.RepeatedField<T> GetOption<T>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.EnumValueOptions, T> extension);
            }

            class ExtensionAccessor : Google.Protobuf.Reflection.IFieldAccessor
            {
                /*0x10*/ Google.Protobuf.Extension extension;
                /*0x18*/ Google.Protobuf.Reflection.ReflectionUtil.IExtensionReflectionHelper helper;
                /*0x20*/ Google.Protobuf.Reflection.FieldDescriptor <Descriptor>k__BackingField;

                /*0x30b9024*/ ExtensionAccessor(Google.Protobuf.Reflection.FieldDescriptor descriptor);
                /*0x30b92ec*/ Google.Protobuf.Reflection.FieldDescriptor get_Descriptor();
                /*0x30b92f4*/ void Clear(Google.Protobuf.IMessage message);
                /*0x30b93a0*/ bool HasValue(Google.Protobuf.IMessage message);
                /*0x30b944c*/ object GetValue(Google.Protobuf.IMessage message);
                /*0x30b94f4*/ void SetValue(Google.Protobuf.IMessage message, object value);
            }

            class ExtensionCollection
            {
                /*0x10*/ System.Collections.Generic.IDictionary<Google.Protobuf.Reflection.MessageDescriptor, System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>> extensionsByTypeInDeclarationOrder;
                /*0x18*/ System.Collections.Generic.IDictionary<Google.Protobuf.Reflection.MessageDescriptor, System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>> extensionsByTypeInNumberOrder;
                /*0x20*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> <UnorderedExtensions>k__BackingField;

                /*0x30b95b0*/ ExtensionCollection(Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Extension[] extensions);
                /*0x30b96dc*/ ExtensionCollection(Google.Protobuf.Reflection.MessageDescriptor message, Google.Protobuf.Extension[] extensions);
                /*0x30b9808*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> get_UnorderedExtensions();
                /*0x30b9810*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> GetExtensionsInDeclarationOrder(Google.Protobuf.Reflection.MessageDescriptor descriptor);
                /*0x30b98b8*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> GetExtensionsInNumberOrder(Google.Protobuf.Reflection.MessageDescriptor descriptor);
                /*0x30b9960*/ void CrossLink();

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.ExtensionCollection.<> <>9;
                    static /*0x8*/ System.Func<System.Collections.Generic.KeyValuePair<Google.Protobuf.Reflection.MessageDescriptor, System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>>, Google.Protobuf.Reflection.MessageDescriptor> <>9__9_0;
                    static /*0x10*/ System.Func<System.Collections.Generic.KeyValuePair<Google.Protobuf.Reflection.MessageDescriptor, System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>>, System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>> <>9__9_1;
                    static /*0x18*/ System.Func<System.Collections.Generic.KeyValuePair<Google.Protobuf.Reflection.MessageDescriptor, System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>>, Google.Protobuf.Reflection.MessageDescriptor> <>9__9_2;
                    static /*0x20*/ System.Func<Google.Protobuf.Reflection.FieldDescriptor, int> <>9__9_4;
                    static /*0x28*/ System.Func<System.Collections.Generic.KeyValuePair<Google.Protobuf.Reflection.MessageDescriptor, System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>>, System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>> <>9__9_3;

                    static /*0x30ba510*/ <>c();
                    /*0x30ba578*/ <>c();
                    /*0x30ba580*/ Google.Protobuf.Reflection.MessageDescriptor <CrossLink>b__9_0(System.Collections.Generic.KeyValuePair<Google.Protobuf.Reflection.MessageDescriptor, System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>> kvp);
                    /*0x30ba638*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> <CrossLink>b__9_1(System.Collections.Generic.KeyValuePair<Google.Protobuf.Reflection.MessageDescriptor, System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>> kvp);
                    /*0x30ba73c*/ Google.Protobuf.Reflection.MessageDescriptor <CrossLink>b__9_2(System.Collections.Generic.KeyValuePair<Google.Protobuf.Reflection.MessageDescriptor, System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>> kvp);
                    /*0x30ba7f4*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> <CrossLink>b__9_3(System.Collections.Generic.KeyValuePair<Google.Protobuf.Reflection.MessageDescriptor, System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor>> kvp);
                    /*0x30ba9fc*/ int <CrossLink>b__9_4(Google.Protobuf.Reflection.FieldDescriptor field);
                }

                class <>c__DisplayClass2_0
                {
                    /*0x10*/ Google.Protobuf.Extension[] extensions;
                    /*0x18*/ Google.Protobuf.Reflection.FileDescriptor file;

                    /*0x30b96d4*/ <>c__DisplayClass2_0();
                    /*0x30baa34*/ Google.Protobuf.Reflection.FieldDescriptor <.ctor>b__0(Google.Protobuf.Reflection.FieldDescriptorProto extension, int i);
                }

                class <>c__DisplayClass3_0
                {
                    /*0x10*/ Google.Protobuf.Extension[] extensions;
                    /*0x18*/ Google.Protobuf.Reflection.MessageDescriptor message;

                    /*0x30b9800*/ <>c__DisplayClass3_0();
                    /*0x30bae90*/ Google.Protobuf.Reflection.FieldDescriptor <.ctor>b__0(Google.Protobuf.Reflection.FieldDescriptorProto extension, int i);
                }
            }

            class FieldAccessorBase : Google.Protobuf.Reflection.IFieldAccessor
            {
                /*0x10*/ System.Func<Google.Protobuf.IMessage, object> getValueDelegate;
                /*0x18*/ System.Func<Google.Protobuf.IMessage, int> getValueDelegateInt32;
                /*0x20*/ System.Func<Google.Protobuf.IMessage, bool> getValueDelegateBoolean;
                /*0x28*/ System.TypeCode returnTypeCode;
                /*0x30*/ Google.Protobuf.Reflection.FieldDescriptor descriptor;

                /*0x30baf8c*/ FieldAccessorBase(System.Reflection.PropertyInfo property, Google.Protobuf.Reflection.FieldDescriptor descriptor);
                /*0x30bb3f8*/ Google.Protobuf.Reflection.FieldDescriptor get_Descriptor();
                /*0x30bb400*/ object GetValue(Google.Protobuf.IMessage message);
                /*0x30bb430*/ int GetValueInt(Google.Protobuf.IMessage message);
                /*0x30bb460*/ bool GetValueBool(Google.Protobuf.IMessage message);
                /*0x1f2fec8*/ bool HasValue(Google.Protobuf.IMessage message);
                /*0x1f30ebc*/ void Clear(Google.Protobuf.IMessage message);
                /*0x1f30ff0*/ void SetValue(Google.Protobuf.IMessage message, object value);
            }

            class FieldDescriptor : Google.Protobuf.Reflection.DescriptorBase, System.IComparable<Google.Protobuf.Reflection.FieldDescriptor>
            {
                /*0x28*/ Google.Protobuf.Reflection.EnumDescriptor enumType;
                /*0x30*/ Google.Protobuf.Reflection.MessageDescriptor extendeeType;
                /*0x38*/ Google.Protobuf.Reflection.MessageDescriptor messageType;
                /*0x40*/ Google.Protobuf.Reflection.FieldType fieldType;
                /*0x48*/ Google.Protobuf.Reflection.IFieldAccessor accessor;
                /*0x50*/ Google.Protobuf.Reflection.MessageDescriptor <ContainingType>k__BackingField;
                /*0x58*/ Google.Protobuf.Reflection.OneofDescriptor <ContainingOneof>k__BackingField;
                /*0x60*/ string <JsonName>k__BackingField;
                /*0x68*/ string <PropertyName>k__BackingField;
                /*0x70*/ Google.Protobuf.Reflection.FieldDescriptorProto <Proto>k__BackingField;
                /*0x78*/ Google.Protobuf.Extension <Extension>k__BackingField;

                static /*0x30bb5d0*/ Google.Protobuf.Reflection.FieldType GetFieldTypeFromProtoType(Google.Protobuf.Reflection.FieldDescriptorProto.Types.Type type);
                /*0x30bab10*/ FieldDescriptor(Google.Protobuf.Reflection.FieldDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.MessageDescriptor parent, int index, string propertyName, Google.Protobuf.Extension extension);
                /*0x30bb490*/ Google.Protobuf.Reflection.MessageDescriptor get_ContainingType();
                /*0x30bb498*/ Google.Protobuf.Reflection.OneofDescriptor get_ContainingOneof();
                /*0x30bb4a0*/ Google.Protobuf.Reflection.OneofDescriptor get_RealContainingOneof();
                /*0x30bb4c0*/ string get_JsonName();
                /*0x30bb4c8*/ string get_PropertyName();
                /*0x30bb4d0*/ bool get_HasPresence();
                /*0x30bb5c0*/ Google.Protobuf.Reflection.FieldDescriptorProto get_Proto();
                /*0x30bb5c8*/ Google.Protobuf.Extension get_Extension();
                /*0x30bb638*/ string get_Name();
                /*0x30bb650*/ Google.Protobuf.Reflection.IFieldAccessor get_Accessor();
                /*0x30bb554*/ bool get_IsRepeated();
                /*0x30bb658*/ bool get_IsRequired();
                /*0x30bb57c*/ bool get_IsMap();
                /*0x30bb680*/ bool get_IsPacked();
                /*0x30bb6f4*/ bool get_IsExtension();
                /*0x30bb70c*/ Google.Protobuf.Reflection.FieldType get_FieldType();
                /*0x30baa1c*/ int get_FieldNumber();
                /*0x30bb714*/ int CompareTo(Google.Protobuf.Reflection.FieldDescriptor other);
                /*0x30bb7b0*/ Google.Protobuf.Reflection.EnumDescriptor get_EnumType();
                /*0x30bb810*/ Google.Protobuf.Reflection.MessageDescriptor get_MessageType();
                /*0x30ba49c*/ Google.Protobuf.Reflection.MessageDescriptor get_ExtendeeType();
                /*0x30bb874*/ Google.Protobuf.Reflection.CustomOptions get_CustomOptions();
                /*0x30bb904*/ Google.Protobuf.Reflection.FieldOptions GetOptions();
                /*0x1ffc854*/ T GetOption<T>(Google.Protobuf.Extension<Google.Protobuf.Reflection.FieldOptions, T> extension);
                /*0x1f302cc*/ Google.Protobuf.Collections.RepeatedField<T> GetOption<T>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FieldOptions, T> extension);
                /*0x30ba06c*/ void CrossLink();
                /*0x30bb928*/ Google.Protobuf.Reflection.IFieldAccessor CreateAccessor();
            }

            enum FieldType
            {
                Double = 0,
                Float = 1,
                Int64 = 2,
                UInt64 = 3,
                Int32 = 4,
                Fixed64 = 5,
                Fixed32 = 6,
                Bool = 7,
                String = 8,
                Group = 9,
                Message = 10,
                Bytes = 11,
                UInt32 = 12,
                SFixed32 = 13,
                SFixed64 = 14,
                SInt32 = 15,
                SInt64 = 16,
                Enum = 17,
            }

            enum Syntax
            {
                Proto2 = 0,
                Proto3 = 1,
                Unknown = 2,
            }

            class FileDescriptor : Google.Protobuf.Reflection.IDescriptor
            {
                /*0x10*/ System.Lazy<System.Collections.Generic.Dictionary<Google.Protobuf.Reflection.IDescriptor, Google.Protobuf.Reflection.DescriptorDeclaration>> declarations;
                /*0x18*/ Google.Protobuf.Reflection.FileDescriptorProto <Proto>k__BackingField;
                /*0x20*/ Google.Protobuf.Reflection.Syntax <Syntax>k__BackingField;
                /*0x28*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.MessageDescriptor> <MessageTypes>k__BackingField;
                /*0x30*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.EnumDescriptor> <EnumTypes>k__BackingField;
                /*0x38*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.ServiceDescriptor> <Services>k__BackingField;
                /*0x40*/ Google.Protobuf.Reflection.ExtensionCollection <Extensions>k__BackingField;
                /*0x48*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.FileDescriptor> <Dependencies>k__BackingField;
                /*0x50*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.FileDescriptor> <PublicDependencies>k__BackingField;
                /*0x58*/ Google.Protobuf.ByteString <SerializedData>k__BackingField;
                /*0x60*/ Google.Protobuf.Reflection.DescriptorPool <DescriptorPool>k__BackingField;

                static /*0x30bc1a0*/ FileDescriptor();
                static /*0x30bc738*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.FileDescriptor> DeterminePublicDependencies(Google.Protobuf.Reflection.FileDescriptor this, Google.Protobuf.Reflection.FileDescriptorProto proto, System.Collections.Generic.IEnumerable<Google.Protobuf.Reflection.FileDescriptor> dependencies, bool allowUnknownDependencies);
                static /*0x30bd500*/ Google.Protobuf.Reflection.FileDescriptor BuildFrom(Google.Protobuf.ByteString descriptorData, Google.Protobuf.Reflection.FileDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor[] dependencies, bool allowUnknownDependencies, Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedCodeInfo);
                static /*0x30be500*/ Google.Protobuf.Reflection.FileDescriptor FromGeneratedCode(byte[] descriptorData, Google.Protobuf.Reflection.FileDescriptor[] dependencies, Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedCodeInfo);
                static /*0x30be8d4*/ System.Collections.Generic.IEnumerable<Google.Protobuf.Extension> GetAllExtensions(Google.Protobuf.Reflection.FileDescriptor[] dependencies, Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedInfo);
                static /*0x30bea30*/ System.Collections.Generic.IEnumerable<Google.Protobuf.Extension> GetAllGeneratedExtensions(Google.Protobuf.Reflection.GeneratedClrTypeInfo generated);
                static /*0x30bebe4*/ System.Collections.Generic.IEnumerable<Google.Protobuf.Extension> GetAllDependedExtensions(Google.Protobuf.Reflection.FileDescriptor descriptor);
                static /*0x30bef30*/ System.Collections.Generic.IEnumerable<Google.Protobuf.Extension> GetAllDependedExtensionsFromMessage(Google.Protobuf.Reflection.MessageDescriptor descriptor);
                static /*0x30bf1ac*/ System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.FileDescriptor> BuildFromByteStrings(System.Collections.Generic.IEnumerable<Google.Protobuf.ByteString> descriptorData, Google.Protobuf.ExtensionRegistry registry);
                static /*0x30bfb80*/ System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.FileDescriptor> BuildFromByteStrings(System.Collections.Generic.IEnumerable<Google.Protobuf.ByteString> descriptorData);
                static /*0x30bfc3c*/ Google.Protobuf.Reflection.FileDescriptor get_DescriptorProtoFileDescriptor();
                static /*0x1f33998*/ void ForceReflectionInitialization<T>();
                /*0x30bc260*/ FileDescriptor(Google.Protobuf.ByteString descriptorData, Google.Protobuf.Reflection.FileDescriptorProto proto, System.Collections.Generic.IEnumerable<Google.Protobuf.Reflection.FileDescriptor> dependencies, Google.Protobuf.Reflection.DescriptorPool pool, bool allowUnknownDependencies, Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedCodeInfo);
                /*0x30bcab8*/ System.Collections.Generic.Dictionary<Google.Protobuf.Reflection.IDescriptor, Google.Protobuf.Reflection.DescriptorDeclaration> CreateDeclarationMap();
                /*0x30bce84*/ Google.Protobuf.Reflection.IDescriptor FindDescriptorForPath(System.Collections.Generic.IList<int> path);
                /*0x30bd274*/ Google.Protobuf.Reflection.DescriptorBase GetDescriptorFromList(System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> list, int index);
                /*0x30bd1d8*/ System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> GetNestedDescriptorListForField(int fieldNumber);
                /*0x30bd3e4*/ Google.Protobuf.Reflection.DescriptorDeclaration GetDeclaration(Google.Protobuf.Reflection.IDescriptor descriptor);
                /*0x30b8af8*/ string ComputeFullName(Google.Protobuf.Reflection.MessageDescriptor parent, string name);
                /*0x30bd47c*/ Google.Protobuf.Reflection.FileDescriptorProto get_Proto();
                /*0x30bd484*/ Google.Protobuf.Reflection.Syntax get_Syntax();
                /*0x30bd48c*/ string get_Name();
                /*0x30bcaa0*/ string get_Package();
                /*0x30bd4a4*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.MessageDescriptor> get_MessageTypes();
                /*0x30bd4ac*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.EnumDescriptor> get_EnumTypes();
                /*0x30bd4b4*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.ServiceDescriptor> get_Services();
                /*0x30bd4bc*/ Google.Protobuf.Reflection.ExtensionCollection get_Extensions();
                /*0x30bd4c4*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.FileDescriptor> get_Dependencies();
                /*0x30bd4cc*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.FileDescriptor> get_PublicDependencies();
                /*0x30bd4d4*/ Google.Protobuf.ByteString get_SerializedData();
                /*0x30bd4dc*/ string Google.Protobuf.Reflection.IDescriptor.get_FullName();
                /*0x30bd4f4*/ Google.Protobuf.Reflection.FileDescriptor Google.Protobuf.Reflection.IDescriptor.get_File();
                /*0x30bd4f8*/ Google.Protobuf.Reflection.DescriptorPool get_DescriptorPool();
                /*0x1ffc854*/ T FindTypeByName<T>(string name);
                /*0x30bd66c*/ void CrossLink();
                /*0x30bfbd8*/ string ToString();
                /*0x30bfcc4*/ Google.Protobuf.Reflection.CustomOptions get_CustomOptions();
                /*0x30bfd54*/ Google.Protobuf.Reflection.FileOptions GetOptions();
                /*0x1ffc854*/ T GetOption<T>(Google.Protobuf.Extension<Google.Protobuf.Reflection.FileOptions, T> extension);
                /*0x1f302cc*/ Google.Protobuf.Collections.RepeatedField<T> GetOption<T>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.FileOptions, T> extension);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.FileDescriptor.<> <>9;
                    static /*0x8*/ System.Func<Google.Protobuf.Reflection.FileDescriptor, string> <>9__9_0;
                    static /*0x10*/ System.Func<Google.Protobuf.Reflection.GeneratedClrTypeInfo, bool> <>9__53_0;
                    static /*0x18*/ System.Func<Google.Protobuf.Reflection.FieldDescriptor, Google.Protobuf.Extension> <>9__54_0;
                    static /*0x20*/ System.Func<Google.Protobuf.Extension, bool> <>9__54_1;
                    static /*0x28*/ System.Func<Google.Protobuf.Reflection.FieldDescriptor, Google.Protobuf.Extension> <>9__55_0;
                    static /*0x30*/ System.Func<Google.Protobuf.Extension, bool> <>9__55_1;

                    static /*0x30bfd78*/ <>c();
                    /*0x30bfde0*/ <>c();
                    /*0x30bfde8*/ string <DeterminePublicDependencies>b__9_0(Google.Protobuf.Reflection.FileDescriptor file);
                    /*0x30bfe08*/ bool <GetAllGeneratedExtensions>b__53_0(Google.Protobuf.Reflection.GeneratedClrTypeInfo t);
                    /*0x30bfe14*/ Google.Protobuf.Extension <GetAllDependedExtensions>b__54_0(Google.Protobuf.Reflection.FieldDescriptor s);
                    /*0x30bfe28*/ bool <GetAllDependedExtensions>b__54_1(Google.Protobuf.Extension e);
                    /*0x30bfe34*/ Google.Protobuf.Extension <GetAllDependedExtensionsFromMessage>b__55_0(Google.Protobuf.Reflection.FieldDescriptor s);
                    /*0x30bfe48*/ bool <GetAllDependedExtensionsFromMessage>b__55_1(Google.Protobuf.Extension e);
                }

                class <>c__DisplayClass2_0
                {
                    /*0x10*/ Google.Protobuf.Reflection.FileDescriptor <>4__this;
                    /*0x18*/ Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedCodeInfo;

                    /*0x30bc730*/ <>c__DisplayClass2_0();
                    /*0x30bfe54*/ Google.Protobuf.Reflection.MessageDescriptor <.ctor>b__0(Google.Protobuf.Reflection.DescriptorProto message, int index);
                    /*0x30c0800*/ Google.Protobuf.Reflection.EnumDescriptor <.ctor>b__1(Google.Protobuf.Reflection.EnumDescriptorProto enumType, int index);
                    /*0x30c08ac*/ Google.Protobuf.Reflection.ServiceDescriptor <.ctor>b__2(Google.Protobuf.Reflection.ServiceDescriptorProto service, int index);
                }
            }

            class GeneratedClrTypeInfo
            {
                static /*0x0*/ string[] EmptyNames;
                static /*0x8*/ Google.Protobuf.Reflection.GeneratedClrTypeInfo[] EmptyCodeInfo;
                static /*0x10*/ Google.Protobuf.Extension[] EmptyExtensions;
                /*0x10*/ System.Type <ClrType>k__BackingField;
                /*0x18*/ Google.Protobuf.MessageParser <Parser>k__BackingField;
                /*0x20*/ string[] <PropertyNames>k__BackingField;
                /*0x28*/ Google.Protobuf.Extension[] <Extensions>k__BackingField;
                /*0x30*/ string[] <OneofNames>k__BackingField;
                /*0x38*/ Google.Protobuf.Reflection.GeneratedClrTypeInfo[] <NestedTypes>k__BackingField;
                /*0x40*/ System.Type[] <NestedEnums>k__BackingField;

                static /*0x30c0d30*/ GeneratedClrTypeInfo();
                /*0x30c0ae8*/ GeneratedClrTypeInfo(System.Type clrType, Google.Protobuf.MessageParser parser, string[] propertyNames, string[] oneofNames, System.Type[] nestedEnums, Google.Protobuf.Extension[] extensions, Google.Protobuf.Reflection.GeneratedClrTypeInfo[] nestedTypes);
                /*0x30c0ca8*/ GeneratedClrTypeInfo(System.Type clrType, Google.Protobuf.MessageParser parser, string[] propertyNames, string[] oneofNames, System.Type[] nestedEnums, Google.Protobuf.Reflection.GeneratedClrTypeInfo[] nestedTypes);
                /*0x30c0cc8*/ GeneratedClrTypeInfo(System.Type[] nestedEnums, Google.Protobuf.Extension[] extensions, Google.Protobuf.Reflection.GeneratedClrTypeInfo[] nestedTypes);
                /*0x30c0cfc*/ GeneratedClrTypeInfo(System.Type[] nestedEnums, Google.Protobuf.Reflection.GeneratedClrTypeInfo[] nestedTypes);
                /*0x30c0aa8*/ System.Type get_ClrType();
                /*0x30c0ab0*/ void set_ClrType(System.Type value);
                /*0x30c0ab8*/ Google.Protobuf.MessageParser get_Parser();
                /*0x30c0ac0*/ string[] get_PropertyNames();
                /*0x30c0ac8*/ Google.Protobuf.Extension[] get_Extensions();
                /*0x30c0ad0*/ string[] get_OneofNames();
                /*0x30c0ad8*/ Google.Protobuf.Reflection.GeneratedClrTypeInfo[] get_NestedTypes();
                /*0x30c0ae0*/ System.Type[] get_NestedEnums();
            }

            interface IDescriptor
            {
                /*0x1f30214*/ string get_Name();
                /*0x1f30214*/ string get_FullName();
                /*0x1f30214*/ Google.Protobuf.Reflection.FileDescriptor get_File();
            }

            interface IFieldAccessor
            {
                /*0x1f30214*/ Google.Protobuf.Reflection.FieldDescriptor get_Descriptor();
                /*0x1f30ebc*/ void Clear(Google.Protobuf.IMessage message);
                /*0x1f302cc*/ object GetValue(Google.Protobuf.IMessage message);
                /*0x1f2fec8*/ bool HasValue(Google.Protobuf.IMessage message);
                /*0x1f30ff0*/ void SetValue(Google.Protobuf.IMessage message, object value);
            }

            class MapFieldAccessor : Google.Protobuf.Reflection.FieldAccessorBase
            {
                /*0x30bc19c*/ MapFieldAccessor(System.Reflection.PropertyInfo property, Google.Protobuf.Reflection.FieldDescriptor descriptor);
                /*0x30c0e1c*/ void Clear(Google.Protobuf.IMessage message);
                /*0x30c0f10*/ bool HasValue(Google.Protobuf.IMessage message);
                /*0x30c0f5c*/ void SetValue(Google.Protobuf.IMessage message, object value);
            }

            class MessageDescriptor : Google.Protobuf.Reflection.DescriptorBase
            {
                static /*0x0*/ System.Collections.Generic.HashSet<string> WellKnownTypeNames;
                /*0x28*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> fieldsInDeclarationOrder;
                /*0x30*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> fieldsInNumberOrder;
                /*0x38*/ System.Collections.Generic.IDictionary<string, Google.Protobuf.Reflection.FieldDescriptor> jsonFieldMap;
                /*0x40*/ System.Func<Google.Protobuf.IMessage, bool> extensionSetIsInitialized;
                /*0x48*/ Google.Protobuf.Reflection.DescriptorProto <Proto>k__BackingField;
                /*0x50*/ System.Type <ClrType>k__BackingField;
                /*0x58*/ Google.Protobuf.MessageParser <Parser>k__BackingField;
                /*0x60*/ Google.Protobuf.Reflection.MessageDescriptor <ContainingType>k__BackingField;
                /*0x68*/ Google.Protobuf.Reflection.MessageDescriptor.FieldCollection <Fields>k__BackingField;
                /*0x70*/ Google.Protobuf.Reflection.ExtensionCollection <Extensions>k__BackingField;
                /*0x78*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.MessageDescriptor> <NestedTypes>k__BackingField;
                /*0x80*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.EnumDescriptor> <EnumTypes>k__BackingField;
                /*0x88*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.OneofDescriptor> <Oneofs>k__BackingField;
                /*0x90*/ int <RealOneofCount>k__BackingField;

                static /*0x30c1da4*/ MessageDescriptor();
                static /*0x30c0fb0*/ System.Collections.ObjectModel.ReadOnlyDictionary<string, Google.Protobuf.Reflection.FieldDescriptor> CreateJsonFieldMap(System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> fields);
                /*0x30bff00*/ MessageDescriptor(Google.Protobuf.Reflection.DescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.MessageDescriptor parent, int typeIndex, Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedCodeInfo);
                /*0x30c1370*/ string get_Name();
                /*0x30c1388*/ System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> GetNestedDescriptorListForField(int fieldNumber);
                /*0x30c1424*/ Google.Protobuf.Reflection.DescriptorProto get_Proto();
                /*0x30c142c*/ bool IsExtensionsInitialized(Google.Protobuf.IMessage message);
                /*0x30c16c4*/ System.Type get_ClrType();
                /*0x30c16cc*/ Google.Protobuf.MessageParser get_Parser();
                /*0x30c16d4*/ bool get_IsWellKnownType();
                /*0x30c17c0*/ bool get_IsWrapperType();
                /*0x30c1870*/ Google.Protobuf.Reflection.MessageDescriptor get_ContainingType();
                /*0x30c1878*/ Google.Protobuf.Reflection.MessageDescriptor.FieldCollection get_Fields();
                /*0x30c1880*/ Google.Protobuf.Reflection.ExtensionCollection get_Extensions();
                /*0x30c1888*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.MessageDescriptor> get_NestedTypes();
                /*0x30c1890*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.EnumDescriptor> get_EnumTypes();
                /*0x30c1898*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.OneofDescriptor> get_Oneofs();
                /*0x30c18a0*/ int get_RealOneofCount();
                /*0x30c18a8*/ Google.Protobuf.Reflection.FieldDescriptor FindFieldByName(string name);
                /*0x30c1934*/ Google.Protobuf.Reflection.FieldDescriptor FindFieldByNumber(int number);
                /*0x1ffc854*/ T FindDescriptor<T>(string name);
                /*0x30c1964*/ Google.Protobuf.Reflection.CustomOptions get_CustomOptions();
                /*0x30c19f4*/ Google.Protobuf.Reflection.MessageOptions GetOptions();
                /*0x1ffc854*/ T GetOption<T>(Google.Protobuf.Extension<Google.Protobuf.Reflection.MessageOptions, T> extension);
                /*0x1f302cc*/ Google.Protobuf.Collections.RepeatedField<T> GetOption<T>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MessageOptions, T> extension);
                /*0x30bdb48*/ void CrossLink();

                class FieldCollection
                {
                    /*0x10*/ Google.Protobuf.Reflection.MessageDescriptor messageDescriptor;

                    /*0x30c1340*/ FieldCollection(Google.Protobuf.Reflection.MessageDescriptor messageDescriptor);
                    /*0x30c1fd8*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> InDeclarationOrder();
                    /*0x30c1ff0*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> InFieldNumberOrder();
                    /*0x30c2008*/ System.Collections.Generic.IDictionary<string, Google.Protobuf.Reflection.FieldDescriptor> ByJsonName();
                    /*0x30c2020*/ Google.Protobuf.Reflection.FieldDescriptor get_Item(int number);
                    /*0x30c2088*/ Google.Protobuf.Reflection.FieldDescriptor get_Item(string name);
                }

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.MessageDescriptor.<> <>9;
                    static /*0x8*/ System.Func<Google.Protobuf.Reflection.FieldDescriptor, int> <>9__5_4;

                    static /*0x30c20f0*/ <>c();
                    /*0x30c2158*/ <>c();
                    /*0x30c2160*/ int <.ctor>b__5_4(Google.Protobuf.Reflection.FieldDescriptor field);
                }

                class <>c__DisplayClass5_0
                {
                    /*0x10*/ Google.Protobuf.Reflection.FileDescriptor file;
                    /*0x18*/ Google.Protobuf.Reflection.MessageDescriptor <>4__this;
                    /*0x20*/ Google.Protobuf.Reflection.GeneratedClrTypeInfo generatedCodeInfo;

                    /*0x30c0fa8*/ <>c__DisplayClass5_0();
                    /*0x30c2180*/ Google.Protobuf.Reflection.OneofDescriptor <.ctor>b__0(Google.Protobuf.Reflection.OneofDescriptorProto oneof, int index);
                    /*0x30c23e4*/ Google.Protobuf.Reflection.MessageDescriptor <.ctor>b__1(Google.Protobuf.Reflection.DescriptorProto type, int index);
                    /*0x30c249c*/ Google.Protobuf.Reflection.EnumDescriptor <.ctor>b__2(Google.Protobuf.Reflection.EnumDescriptorProto type, int index);
                    /*0x30c2554*/ Google.Protobuf.Reflection.FieldDescriptor <.ctor>b__3(Google.Protobuf.Reflection.FieldDescriptorProto field, int index);
                }
            }

            class MethodDescriptor : Google.Protobuf.Reflection.DescriptorBase
            {
                /*0x28*/ Google.Protobuf.Reflection.MethodDescriptorProto proto;
                /*0x30*/ Google.Protobuf.Reflection.ServiceDescriptor service;
                /*0x38*/ Google.Protobuf.Reflection.MessageDescriptor inputType;
                /*0x40*/ Google.Protobuf.Reflection.MessageDescriptor outputType;

                /*0x30c270c*/ MethodDescriptor(Google.Protobuf.Reflection.MethodDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.ServiceDescriptor parent, int index);
                /*0x30c2610*/ Google.Protobuf.Reflection.ServiceDescriptor get_Service();
                /*0x30c2618*/ Google.Protobuf.Reflection.MessageDescriptor get_InputType();
                /*0x30c2620*/ Google.Protobuf.Reflection.MessageDescriptor get_OutputType();
                /*0x30c2628*/ bool get_IsClientStreaming();
                /*0x30c2640*/ bool get_IsServerStreaming();
                /*0x30c2658*/ Google.Protobuf.Reflection.CustomOptions get_CustomOptions();
                /*0x30c26e8*/ Google.Protobuf.Reflection.MethodOptions GetOptions();
                /*0x1ffc854*/ T GetOption<T>(Google.Protobuf.Extension<Google.Protobuf.Reflection.MethodOptions, T> extension);
                /*0x1f302cc*/ Google.Protobuf.Collections.RepeatedField<T> GetOption<T>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.MethodOptions, T> extension);
                /*0x30c27e8*/ Google.Protobuf.Reflection.MethodDescriptorProto get_Proto();
                /*0x30c27f0*/ string get_Name();
                /*0x30c2808*/ void CrossLink();
            }

            class OneofAccessor
            {
                /*0x10*/ System.Func<Google.Protobuf.IMessage, int> caseDelegate;
                /*0x18*/ System.Action<Google.Protobuf.IMessage> clearDelegate;
                /*0x20*/ Google.Protobuf.Reflection.OneofDescriptor <Descriptor>k__BackingField;

                static /*0x30c2a24*/ Google.Protobuf.Reflection.OneofAccessor ForRegularOneof(Google.Protobuf.Reflection.OneofDescriptor descriptor, System.Reflection.PropertyInfo caseProperty, System.Reflection.MethodInfo clearMethod);
                static /*0x30c2c1c*/ Google.Protobuf.Reflection.OneofAccessor ForSyntheticOneof(Google.Protobuf.Reflection.OneofDescriptor descriptor);
                /*0x30c29c4*/ OneofAccessor(Google.Protobuf.Reflection.OneofDescriptor descriptor, System.Func<Google.Protobuf.IMessage, int> caseDelegate, System.Action<Google.Protobuf.IMessage> clearDelegate);
                /*0x30c2d6c*/ Google.Protobuf.Reflection.OneofDescriptor get_Descriptor();
                /*0x30c2d74*/ void Clear(Google.Protobuf.IMessage message);
                /*0x30c2d94*/ Google.Protobuf.Reflection.FieldDescriptor GetCaseFieldDescriptor(Google.Protobuf.IMessage message);

                class <>c__DisplayClass4_0
                {
                    /*0x10*/ Google.Protobuf.Reflection.OneofDescriptor descriptor;

                    /*0x30c2d64*/ <>c__DisplayClass4_0();
                    /*0x30c2df4*/ int <ForSyntheticOneof>b__0(Google.Protobuf.IMessage message);
                    /*0x30c2fc4*/ void <ForSyntheticOneof>b__1(Google.Protobuf.IMessage message);
                }
            }

            class OneofDescriptor : Google.Protobuf.Reflection.DescriptorBase
            {
                /*0x28*/ Google.Protobuf.Reflection.OneofDescriptorProto proto;
                /*0x30*/ Google.Protobuf.Reflection.MessageDescriptor containingType;
                /*0x38*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> fields;
                /*0x40*/ Google.Protobuf.Reflection.OneofAccessor accessor;
                /*0x48*/ bool <IsSynthetic>k__BackingField;

                /*0x30c2238*/ OneofDescriptor(Google.Protobuf.Reflection.OneofDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, Google.Protobuf.Reflection.MessageDescriptor parent, int index, string clrName);
                /*0x30c332c*/ string get_Name();
                /*0x30c3344*/ Google.Protobuf.Reflection.MessageDescriptor get_ContainingType();
                /*0x30c334c*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.FieldDescriptor> get_Fields();
                /*0x30c3354*/ bool get_IsSynthetic();
                /*0x30c335c*/ Google.Protobuf.Reflection.OneofAccessor get_Accessor();
                /*0x30c3364*/ Google.Protobuf.Reflection.CustomOptions get_CustomOptions();
                /*0x30c33f4*/ Google.Protobuf.Reflection.OneofOptions GetOptions();
                /*0x1ffc854*/ T GetOption<T>(Google.Protobuf.Extension<Google.Protobuf.Reflection.OneofOptions, T> extension);
                /*0x1f302cc*/ Google.Protobuf.Collections.RepeatedField<T> GetOption<T>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.OneofOptions, T> extension);
                /*0x30c1a18*/ void CrossLink();
                /*0x30c30fc*/ Google.Protobuf.Reflection.OneofAccessor CreateAccessor(string clrName);

                class <>c__DisplayClass4_0
                {
                    /*0x10*/ int index;

                    /*0x30c30f4*/ <>c__DisplayClass4_0();
                    /*0x30c3418*/ bool <.ctor>b__0(Google.Protobuf.Reflection.FieldDescriptorProto fieldProto);
                }
            }

            class OriginalNameAttribute : System.Attribute
            {
                /*0x10*/ string <Name>k__BackingField;
                /*0x18*/ bool <PreferredAlias>k__BackingField;

                /*0x30c348c*/ OriginalNameAttribute(string name);
                /*0x30c346c*/ string get_Name();
                /*0x30c3474*/ void set_Name(string value);
                /*0x30c347c*/ bool get_PreferredAlias();
                /*0x30c3484*/ void set_PreferredAlias(bool value);
            }

            class PackageDescriptor : Google.Protobuf.Reflection.IDescriptor
            {
                /*0x10*/ string name;
                /*0x18*/ string fullName;
                /*0x20*/ Google.Protobuf.Reflection.FileDescriptor file;

                /*0x30c3520*/ PackageDescriptor(string name, string fullName, Google.Protobuf.Reflection.FileDescriptor file);
                /*0x30c3580*/ string get_Name();
                /*0x30c3588*/ string get_FullName();
                /*0x30c3590*/ Google.Protobuf.Reflection.FileDescriptor get_File();
            }

            class ReflectionUtil
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<System.ValueTuple<System.Type, System.Type, System.Reflection.MethodInfo>, System.Func<Google.Protobuf.IMessage, int>> FuncIMessageInt32Dic;
                static /*0x8*/ System.Collections.Generic.Dictionary<System.ValueTuple<System.Type, System.Type, System.Reflection.MethodInfo>, System.Func<Google.Protobuf.IMessage, object>> FuncIMessageObjectDic;
                static /*0x10*/ System.Type[] EmptyTypes;
                static /*0x18*/ bool <CanConvertEnumFuncToInt32Func>k__BackingField;
                static /*0x20*/ System.Collections.Generic.Dictionary<System.ValueTuple<System.Type, System.Type>, Google.Protobuf.Reflection.ReflectionUtil.IReflectionHelper> ReflectionHelperDic;
                static /*0x28*/ object LockGetReflectionHelper;
                static /*0x30*/ System.Type[] ReflectionHelperTypes;
                static /*0x38*/ System.Type ReflectionHelperType;

                static /*0x30c3598*/ ReflectionUtil();
                static /*0x1f33998*/ void ForceInitialize<T>();
                static /*0x30bb2ec*/ System.Func<Google.Protobuf.IMessage, object> CreateFuncIMessageObject(System.Reflection.MethodInfo method);
                static /*0x30bb0d8*/ System.Func<Google.Protobuf.IMessage, int> CreateFuncIMessageInt32(System.Reflection.MethodInfo method);
                static /*0x30bb1e0*/ System.Func<Google.Protobuf.IMessage, bool> CreateFuncIMessageBoolean(System.Reflection.MethodInfo method);
                static /*0x30c3b74*/ System.Action<Google.Protobuf.IMessage, object> CreateActionIMessageObject(System.Reflection.MethodInfo method);
                static /*0x30c2af0*/ System.Action<Google.Protobuf.IMessage> CreateActionIMessage(System.Reflection.MethodInfo method);
                static /*0x30c3ca4*/ System.Func<Google.Protobuf.IMessage, bool> CreateFuncIMessageBool(System.Reflection.MethodInfo method);
                static /*0x30c1514*/ System.Func<Google.Protobuf.IMessage, bool> CreateIsInitializedCaller(System.Type msg);
                static /*0x30b90c8*/ Google.Protobuf.Reflection.ReflectionUtil.IExtensionReflectionHelper CreateExtensionHelper(Google.Protobuf.Extension extension);
                static /*0x30c3b10*/ Google.Protobuf.Reflection.ReflectionUtil.IReflectionHelper GetReflectionHelper(System.Type t1, System.Type t2);
                static /*0x30c4100*/ bool get_CanConvertEnumFuncToInt32Func();
                static /*0x30c39b0*/ bool CheckCanConvertEnumFuncToInt32Func();
                static /*0x30c3b08*/ Google.Protobuf.Reflection.ReflectionUtil.SampleEnum SampleEnumMethod();
                static /*0x30c3db0*/ Google.Protobuf.Reflection.ReflectionUtil.IReflectionHelper GetReflectionHelperMaybeFromCache(System.Type t1, System.Type t2);

                interface IReflectionHelper
                {
                    /*0x1f302cc*/ System.Func<Google.Protobuf.IMessage, int> CreateFuncIMessageInt32(System.Reflection.MethodInfo method);
                    /*0x1f302cc*/ System.Func<Google.Protobuf.IMessage, bool> CreateFuncIMessageBoolean(System.Reflection.MethodInfo method);
                    /*0x1f302cc*/ System.Action<Google.Protobuf.IMessage> CreateActionIMessage(System.Reflection.MethodInfo method);
                    /*0x1f302cc*/ System.Func<Google.Protobuf.IMessage, object> CreateFuncIMessageObject(System.Reflection.MethodInfo method);
                    /*0x1f302cc*/ System.Action<Google.Protobuf.IMessage, object> CreateActionIMessageObject(System.Reflection.MethodInfo method);
                    /*0x1f302cc*/ System.Func<Google.Protobuf.IMessage, bool> CreateFuncIMessageBool(System.Reflection.MethodInfo method);
                }

                interface IExtensionReflectionHelper
                {
                    /*0x1f302cc*/ object GetExtension(Google.Protobuf.IMessage message);
                    /*0x1f30ff0*/ void SetExtension(Google.Protobuf.IMessage message, object value);
                    /*0x1f2fec8*/ bool HasExtension(Google.Protobuf.IMessage message);
                    /*0x1f30ebc*/ void ClearExtension(Google.Protobuf.IMessage message);
                }

                interface IExtensionSetReflector
                {
                    /*0x1f30214*/ System.Func<Google.Protobuf.IMessage, bool> CreateIsInitializedCaller();
                }

                class ReflectionHelper<T1, T2> : Google.Protobuf.Reflection.ReflectionUtil.IReflectionHelper
                {
                    static /*0x0*/ System.Type t1;
                    static /*0x0*/ System.Type t2;

                    static /*0x1f33998*/ ReflectionHelper();
                    /*0x1f309e4*/ ReflectionHelper();
                    /*0x1f302cc*/ System.Func<Google.Protobuf.IMessage, int> CreateFuncIMessageInt32(System.Reflection.MethodInfo method);
                    /*0x1f302cc*/ System.Action<Google.Protobuf.IMessage> CreateActionIMessage(System.Reflection.MethodInfo method);
                    /*0x1f302cc*/ System.Func<Google.Protobuf.IMessage, object> CreateFuncIMessageObject(System.Reflection.MethodInfo method);
                    /*0x1f302cc*/ System.Func<Google.Protobuf.IMessage, bool> CreateFuncIMessageBoolean(System.Reflection.MethodInfo method);
                    /*0x1f302cc*/ System.Action<Google.Protobuf.IMessage, object> CreateActionIMessageObject(System.Reflection.MethodInfo method);
                    /*0x1f302cc*/ System.Func<Google.Protobuf.IMessage, bool> CreateFuncIMessageBool(System.Reflection.MethodInfo method);

                    class <>c__DisplayClass2_0<T1, T2>
                    {
                        /*0x0*/ System.Func<T1, int> del;

                        /*0x1f309e4*/ <>c__DisplayClass2_0();
                        /*0x1f3008c*/ int <CreateFuncIMessageInt32>b__0(Google.Protobuf.IMessage message);
                    }

                    class <>c__DisplayClass2_1<T1, T2>
                    {
                        /*0x0*/ System.Func<T1, T2> del;

                        /*0x1f309e4*/ <>c__DisplayClass2_1();
                        /*0x1f3008c*/ int <CreateFuncIMessageInt32>b__1(Google.Protobuf.IMessage message);
                    }

                    class <>c__DisplayClass2_<T1, T2>
                    {
                        /*0x0*/ System.Func<T1, int> del;

                        /*0x1f309e4*/ <>c__DisplayClass2_();
                        /*0x1f3008c*/ int <CreateFuncIMessageInt32>b__2(Google.Protobuf.IMessage message);
                    }

                    class <>c__DisplayClass3_0<T1, T2>
                    {
                        /*0x0*/ System.Action<T1> del;

                        /*0x1f309e4*/ <>c__DisplayClass3_0();
                        /*0x1f30ebc*/ void <CreateActionIMessage>b__0(Google.Protobuf.IMessage message);
                    }

                    class <>c__DisplayClass4_0<T1, T2>
                    {
                        /*0x0*/ System.Func<T1, T2> del;

                        /*0x1f309e4*/ <>c__DisplayClass4_0();
                        /*0x1f302cc*/ object <CreateFuncIMessageObject>b__0(Google.Protobuf.IMessage message);
                    }

                    class <>c__DisplayClass5_0<T1, T2>
                    {
                        /*0x0*/ System.Func<T1, bool> del;

                        /*0x1f309e4*/ <>c__DisplayClass5_0();
                        /*0x1f2fec8*/ bool <CreateFuncIMessageBoolean>b__0(Google.Protobuf.IMessage message);
                    }

                    class <>c__DisplayClass6_0<T1, T2>
                    {
                        /*0x0*/ System.Action<T1, T2> del;

                        /*0x1f309e4*/ <>c__DisplayClass6_0();
                        /*0x1f30ff0*/ void <CreateActionIMessageObject>b__0(Google.Protobuf.IMessage message, object arg);
                    }

                    class <>c__DisplayClass7_0<T1, T2>
                    {
                        /*0x0*/ System.Func<T1, bool> del;

                        /*0x1f309e4*/ <>c__DisplayClass7_0();
                        /*0x1f2fec8*/ bool <CreateFuncIMessageBool>b__0(Google.Protobuf.IMessage message);
                    }
                }

                class ExtensionReflectionHelper<T1, T3> : Google.Protobuf.Reflection.ReflectionUtil.IExtensionReflectionHelper
                {
                    /*0x0*/ Google.Protobuf.Extension extension;

                    /*0x1f30ebc*/ ExtensionReflectionHelper(Google.Protobuf.Extension extension);
                    /*0x1f302cc*/ object GetExtension(Google.Protobuf.IMessage message);
                    /*0x1f2fec8*/ bool HasExtension(Google.Protobuf.IMessage message);
                    /*0x1f30ff0*/ void SetExtension(Google.Protobuf.IMessage message, object value);
                    /*0x1f30ebc*/ void ClearExtension(Google.Protobuf.IMessage message);
                }

                class ExtensionSetReflector<T1> : Google.Protobuf.Reflection.ReflectionUtil.IExtensionSetReflector
                {
                    /*0x1f309e4*/ ExtensionSetReflector();
                    /*0x1f30214*/ System.Func<Google.Protobuf.IMessage, bool> CreateIsInitializedCaller();

                    class <>c__DisplayClass0_0<T1>
                    {
                        /*0x0*/ System.Func<T1, Google.Protobuf.ExtensionSet<T1>> getFunc;
                        /*0x0*/ System.Func<Google.Protobuf.ExtensionSet<T1>, bool> initializedFunc;

                        /*0x1f309e4*/ <>c__DisplayClass0_0();
                        /*0x1f2fec8*/ bool <CreateIsInitializedCaller>b__0(Google.Protobuf.IMessage m);
                    }
                }

                enum SampleEnum
                {
                    X = 0,
                }
            }

            class RepeatedFieldAccessor : Google.Protobuf.Reflection.FieldAccessorBase
            {
                /*0x30bc198*/ RepeatedFieldAccessor(System.Reflection.PropertyInfo property, Google.Protobuf.Reflection.FieldDescriptor descriptor);
                /*0x30c4158*/ void Clear(Google.Protobuf.IMessage message);
                /*0x30c424c*/ bool HasValue(Google.Protobuf.IMessage message);
                /*0x30c4298*/ void SetValue(Google.Protobuf.IMessage message, object value);
            }

            class ServiceDescriptor : Google.Protobuf.Reflection.DescriptorBase
            {
                /*0x28*/ Google.Protobuf.Reflection.ServiceDescriptorProto proto;
                /*0x30*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.MethodDescriptor> methods;

                /*0x30c0920*/ ServiceDescriptor(Google.Protobuf.Reflection.ServiceDescriptorProto proto, Google.Protobuf.Reflection.FileDescriptor file, int index);
                /*0x30c42ec*/ string get_Name();
                /*0x30c4304*/ System.Collections.Generic.IReadOnlyList<Google.Protobuf.Reflection.DescriptorBase> GetNestedDescriptorListForField(int fieldNumber);
                /*0x30c437c*/ Google.Protobuf.Reflection.ServiceDescriptorProto get_Proto();
                /*0x30c4384*/ System.Collections.Generic.IList<Google.Protobuf.Reflection.MethodDescriptor> get_Methods();
                /*0x30c438c*/ Google.Protobuf.Reflection.MethodDescriptor FindMethodByName(string name);
                /*0x30c4418*/ Google.Protobuf.Reflection.CustomOptions get_CustomOptions();
                /*0x30c44a8*/ Google.Protobuf.Reflection.ServiceOptions GetOptions();
                /*0x1ffc854*/ T GetOption<T>(Google.Protobuf.Extension<Google.Protobuf.Reflection.ServiceOptions, T> extension);
                /*0x1f302cc*/ Google.Protobuf.Collections.RepeatedField<T> GetOption<T>(Google.Protobuf.RepeatedExtension<Google.Protobuf.Reflection.ServiceOptions, T> extension);
                /*0x30be260*/ void CrossLink();

                class <>c__DisplayClass2_0
                {
                    /*0x10*/ Google.Protobuf.Reflection.FileDescriptor file;
                    /*0x18*/ Google.Protobuf.Reflection.ServiceDescriptor <>4__this;

                    /*0x30c42e4*/ <>c__DisplayClass2_0();
                    /*0x30c44cc*/ Google.Protobuf.Reflection.MethodDescriptor <.ctor>b__0(Google.Protobuf.Reflection.MethodDescriptorProto method, int i);
                }
            }

            class SingleFieldAccessor : Google.Protobuf.Reflection.FieldAccessorBase
            {
                /*0x38*/ System.Action<Google.Protobuf.IMessage, object> setValueDelegate;
                /*0x40*/ System.Action<Google.Protobuf.IMessage> clearDelegate;
                /*0x48*/ System.Func<Google.Protobuf.IMessage, bool> hasDelegate;

                /*0x30bbac4*/ SingleFieldAccessor(System.Reflection.PropertyInfo property, Google.Protobuf.Reflection.FieldDescriptor descriptor);
                /*0x30c455c*/ void Clear(Google.Protobuf.IMessage message);
                /*0x30c457c*/ bool HasValue(Google.Protobuf.IMessage message);
                /*0x30c45ac*/ void SetValue(Google.Protobuf.IMessage message, object value);

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.SingleFieldAccessor.<> <>9;
                    static /*0x8*/ System.Func<Google.Protobuf.IMessage, bool> <>9__3_4;

                    static /*0x30c45cc*/ <>c();
                    /*0x30c4634*/ <>c();
                    /*0x30c463c*/ bool <.ctor>b__3_4(Google.Protobuf.IMessage message);
                }

                class <>c__DisplayClass3_0
                {
                    /*0x10*/ Google.Protobuf.Reflection.SingleFieldAccessor <>4__this;
                    /*0x18*/ Google.Protobuf.Reflection.FieldDescriptor descriptor;

                    /*0x30c4544*/ <>c__DisplayClass3_0();
                    /*0x30c4688*/ bool <.ctor>b__0(Google.Protobuf.IMessage message);
                    /*0x30c46ac*/ void <.ctor>b__1(Google.Protobuf.IMessage message);
                }

                class <>c__DisplayClass3_1
                {
                    /*0x10*/ Google.Protobuf.Reflection.OneofAccessor oneofAccessor;
                    /*0x18*/ Google.Protobuf.Reflection.SingleFieldAccessor.<> CS$<>8__locals1;

                    /*0x30c454c*/ <>c__DisplayClass3_1();
                    /*0x30c46cc*/ bool <.ctor>b__2(Google.Protobuf.IMessage message);
                    /*0x30c4700*/ void <.ctor>b__3(Google.Protobuf.IMessage message);
                }

                class <>c__DisplayClass3_2
                {
                    /*0x10*/ object defaultValue;
                    /*0x18*/ Google.Protobuf.Reflection.SingleFieldAccessor.<> CS$<>8__locals2;

                    /*0x30c4554*/ <>c__DisplayClass3_2();
                    /*0x30c476c*/ void <.ctor>b__5(Google.Protobuf.IMessage message);
                }
            }

            class TypeRegistry
            {
                static /*0x0*/ Google.Protobuf.Reflection.TypeRegistry <Empty>k__BackingField;
                /*0x10*/ System.Collections.Generic.Dictionary<string, Google.Protobuf.Reflection.MessageDescriptor> fullNameToMessageMap;

                static /*0x30c543c*/ TypeRegistry();
                static /*0x30c479c*/ Google.Protobuf.Reflection.TypeRegistry get_Empty();
                static /*0x30c4894*/ Google.Protobuf.Reflection.TypeRegistry FromFiles(Google.Protobuf.Reflection.FileDescriptor[] fileDescriptors);
                static /*0x30c48e8*/ Google.Protobuf.Reflection.TypeRegistry FromFiles(System.Collections.Generic.IEnumerable<Google.Protobuf.Reflection.FileDescriptor> fileDescriptors);
                static /*0x30c527c*/ Google.Protobuf.Reflection.TypeRegistry FromMessages(Google.Protobuf.Reflection.MessageDescriptor[] messageDescriptors);
                static /*0x30c52d0*/ Google.Protobuf.Reflection.TypeRegistry FromMessages(System.Collections.Generic.IEnumerable<Google.Protobuf.Reflection.MessageDescriptor> messageDescriptors);
                /*0x30c47f4*/ TypeRegistry(System.Collections.Generic.Dictionary<string, Google.Protobuf.Reflection.MessageDescriptor> fullNameToMessageMap);
                /*0x30c4824*/ Google.Protobuf.Reflection.MessageDescriptor Find(string fullName);

                class Builder
                {
                    /*0x10*/ System.Collections.Generic.Dictionary<string, Google.Protobuf.Reflection.MessageDescriptor> types;
                    /*0x18*/ System.Collections.Generic.HashSet<string> fileDescriptorNames;

                    /*0x30c4bf8*/ Builder();
                    /*0x30c4cd4*/ void AddFile(Google.Protobuf.Reflection.FileDescriptor fileDescriptor);
                    /*0x30c54f8*/ void AddMessage(Google.Protobuf.Reflection.MessageDescriptor messageDescriptor);
                    /*0x30c5210*/ Google.Protobuf.Reflection.TypeRegistry Build();
                }

                class <>c
                {
                    static /*0x0*/ Google.Protobuf.Reflection.TypeRegistry.<> <>9;
                    static /*0x8*/ System.Func<Google.Protobuf.Reflection.MessageDescriptor, Google.Protobuf.Reflection.FileDescriptor> <>9__9_0;

                    static /*0x30c57d4*/ <>c();
                    /*0x30c583c*/ <>c();
                    /*0x30c5844*/ Google.Protobuf.Reflection.FileDescriptor <FromMessages>b__9_0(Google.Protobuf.Reflection.MessageDescriptor md);
                }
            }
        }

        namespace Compatibility
        {
            class PropertyInfoExtensions
            {
                static /*0x30c5858*/ System.Reflection.MethodInfo GetGetMethod(System.Reflection.PropertyInfo target);
                static /*0x30c58b0*/ System.Reflection.MethodInfo GetSetMethod(System.Reflection.PropertyInfo target);
            }

            class TypeExtensions
            {
                static /*0x30c5908*/ bool IsAssignableFrom(System.Type target, System.Type c);
                static /*0x30c5954*/ System.Reflection.PropertyInfo GetProperty(System.Type target, string name);
                static /*0x30c5a80*/ System.Reflection.MethodInfo GetMethod(System.Type target, string name);
            }
        }

        namespace Collections
        {
            class Lists
            {
                static /*0x1f318fc*/ bool Equals<T>(System.Collections.Generic.List<T> left, System.Collections.Generic.List<T> right);
                static /*0x1f31f88*/ int GetHashCode<T>(System.Collections.Generic.List<T> list);
            }

            class MapField<TKey, TValue> : Google.Protobuf.IDeepCloneable<Google.Protobuf.Collections.MapField<TKey, TValue>>, System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable, System.IEquatable<Google.Protobuf.Collections.MapField<TKey, TValue>>, System.Collections.IDictionary, System.Collections.ICollection, System.Collections.Generic.IReadOnlyDictionary<TKey, TValue>, System.Collections.Generic.IReadOnlyCollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>
            {
                static /*0x0*/ System.Collections.Generic.EqualityComparer<TValue> ValueEqualityComparer;
                static /*0x0*/ System.Collections.Generic.EqualityComparer<TKey> KeyEqualityComparer;
                /*0x0*/ System.Collections.Generic.Dictionary<TKey, System.Collections.Generic.LinkedListNode<System.Collections.Generic.KeyValuePair<TKey, TValue>>> map;
                /*0x0*/ System.Collections.Generic.LinkedList<System.Collections.Generic.KeyValuePair<TKey, TValue>> list;

                static /*0x1f33998*/ MapField();
                static /*0x1ffc854*/ int CalculateEntrySize(Google.Protobuf.Collections.MapField.Codec<TKey, TValue> codec, System.Collections.Generic.KeyValuePair<TKey, TValue> entry);
                /*0x1f309e4*/ MapField();
                /*0x1f30214*/ Google.Protobuf.Collections.MapField<TKey, TValue> Clone();
                /*0x1ffc854*/ void Add(TKey key, TValue value);
                /*0x1ffc854*/ bool ContainsKey(TKey key);
                /*0x1ffc854*/ bool ContainsValue(TValue value);
                /*0x1ffc854*/ bool Remove(TKey key);
                /*0x1ffc854*/ bool TryGetValue(TKey key, ref TValue value);
                /*0x1ffc854*/ TValue get_Item(TKey key);
                /*0x1ffc854*/ void set_Item(TKey key, TValue value);
                /*0x1f30214*/ System.Collections.Generic.ICollection<TKey> get_Keys();
                /*0x1f30214*/ System.Collections.Generic.ICollection<TValue> get_Values();
                /*0x1f30ebc*/ void Add(System.Collections.Generic.IDictionary<TKey, TValue> entries);
                /*0x1f30214*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator();
                /*0x1f30214*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x1ffc854*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
                /*0x1f309e4*/ void Clear();
                /*0x1ffc854*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
                /*0x1f30ee8*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue> array, int arrayIndex);
                /*0x1ffc854*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
                /*0x1f2ffc8*/ int get_Count();
                /*0x1f2fe14*/ bool get_IsReadOnly();
                /*0x1f2fec8*/ bool Equals(object other);
                /*0x1f2ffc8*/ int GetHashCode();
                /*0x1f2fec8*/ bool Equals(Google.Protobuf.Collections.MapField<TKey, TValue> other);
                /*0x1f30ff0*/ void AddEntriesFrom(Google.Protobuf.CodedInputStream input, Google.Protobuf.Collections.MapField.Codec<TKey, TValue> codec);
                /*0x1f30ff0*/ void AddEntriesFrom(ref Google.Protobuf.ParseContext ctx, Google.Protobuf.Collections.MapField.Codec<TKey, TValue> codec);
                /*0x1f30ff0*/ void WriteTo(Google.Protobuf.CodedOutputStream output, Google.Protobuf.Collections.MapField.Codec<TKey, TValue> codec);
                /*0x1f30ff0*/ void WriteTo(ref Google.Protobuf.WriteContext ctx, Google.Protobuf.Collections.MapField.Codec<TKey, TValue> codec);
                /*0x1f3008c*/ int CalculateSize(Google.Protobuf.Collections.MapField.Codec<TKey, TValue> codec);
                /*0x1f30214*/ string ToString();
                /*0x1f30ff0*/ void System.Collections.IDictionary.Add(object key, object value);
                /*0x1f2fec8*/ bool System.Collections.IDictionary.Contains(object key);
                /*0x1f30214*/ System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
                /*0x1f30ebc*/ void System.Collections.IDictionary.Remove(object key);
                /*0x1f30ee8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x1f2fe14*/ bool System.Collections.IDictionary.get_IsFixedSize();
                /*0x1f30214*/ System.Collections.ICollection System.Collections.IDictionary.get_Keys();
                /*0x1f30214*/ System.Collections.ICollection System.Collections.IDictionary.get_Values();
                /*0x1f2fe14*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x1f30214*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x1f302cc*/ object System.Collections.IDictionary.get_Item(object key);
                /*0x1f30ff0*/ void System.Collections.IDictionary.set_Item(object key, object value);
                /*0x1f30214*/ System.Collections.Generic.IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys();
                /*0x1f30214*/ System.Collections.Generic.IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values();

                class DictionaryEnumerator<TKey, TValue> : System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator
                {
                    /*0x0*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> enumerator;

                    /*0x1f30ebc*/ DictionaryEnumerator(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> enumerator);
                    /*0x1f2fe14*/ bool MoveNext();
                    /*0x1f309e4*/ void Reset();
                    /*0x1f30214*/ object get_Current();
                    System.Collections.DictionaryEntry get_Entry();
                    /*0x1f30214*/ object get_Key();
                    /*0x1f30214*/ object get_Value();
                }

                class Codec<TKey, TValue>
                {
                    /*0x0*/ Google.Protobuf.FieldCodec<TKey> keyCodec;
                    /*0x0*/ Google.Protobuf.FieldCodec<TValue> valueCodec;
                    /*0x0*/ uint mapTag;

                    Codec(Google.Protobuf.FieldCodec<TKey> keyCodec, Google.Protobuf.FieldCodec<TValue> valueCodec, uint mapTag);
                    /*0x1f30214*/ Google.Protobuf.FieldCodec<TKey> get_KeyCodec();
                    /*0x1f30214*/ Google.Protobuf.FieldCodec<TValue> get_ValueCodec();
                    uint get_MapTag();
                }

                class MapView`1<TKey, TValue, T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.ICollection
                {
                    /*0x0*/ Google.Protobuf.Collections.MapField<TKey, TValue> parent;
                    /*0x0*/ System.Func<System.Collections.Generic.KeyValuePair<TKey, TValue>, T> projection;
                    /*0x0*/ System.Func<T, bool> containsCheck;

                    /*0x1f310fc*/ MapView`1(Google.Protobuf.Collections.MapField<TKey, TValue> parent, System.Func<System.Collections.Generic.KeyValuePair<TKey, TValue>, T> projection, System.Func<T, bool> containsCheck);
                    /*0x1f2ffc8*/ int get_Count();
                    /*0x1f2fe14*/ bool get_IsReadOnly();
                    /*0x1f2fe14*/ bool get_IsSynchronized();
                    /*0x1f30214*/ object get_SyncRoot();
                    /*0x1ffc854*/ void Add(T item);
                    /*0x1f309e4*/ void Clear();
                    /*0x1ffc854*/ bool Contains(T item);
                    /*0x1f30ee8*/ void CopyTo(T[] array, int arrayIndex);
                    /*0x1f30214*/ System.Collections.Generic.IEnumerator<T> GetEnumerator();
                    /*0x1ffc854*/ bool Remove(T item);
                    /*0x1f30214*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x1f30ee8*/ void CopyTo(System.Array array, int index);
                }

                class <>c<TKey, TValue>
                {
                    static /*0x0*/ Google.Protobuf.Collections.MapField.<>c<TKey, TValue> <>9;
                    static /*0x0*/ System.Func<System.Collections.Generic.KeyValuePair<TKey, TValue>, TKey> <>9__14_0;
                    static /*0x0*/ System.Func<System.Collections.Generic.KeyValuePair<TKey, TValue>, TValue> <>9__16_0;
                    static /*0x0*/ System.Func<System.Collections.Generic.KeyValuePair<TKey, TValue>, System.Collections.DictionaryEntry> <>9__43_0;

                    static /*0x1f33998*/ <>c();
                    /*0x1f309e4*/ <>c();
                    /*0x1ffc854*/ TKey <get_Keys>b__14_0(System.Collections.Generic.KeyValuePair<TKey, TValue> pair);
                    /*0x1ffc854*/ TValue <get_Values>b__16_0(System.Collections.Generic.KeyValuePair<TKey, TValue> pair);
                    /*0x1ffc854*/ System.Collections.DictionaryEntry <System.Collections.ICollection.CopyTo>b__43_0(System.Collections.Generic.KeyValuePair<TKey, TValue> pair);
                }

                class <>c__DisplayClass7_0<TKey, TValue>
                {
                    /*0x0*/ TValue value;

                    /*0x1f309e4*/ <>c__DisplayClass7_0();
                    /*0x1ffc854*/ bool <ContainsValue>b__0(System.Collections.Generic.KeyValuePair<TKey, TValue> pair);
                }
            }

            class ProtobufEqualityComparers
            {
                static /*0x0*/ System.Collections.Generic.EqualityComparer<double> <BitwiseDoubleEqualityComparer>k__BackingField;
                static /*0x8*/ System.Collections.Generic.EqualityComparer<float> <BitwiseSingleEqualityComparer>k__BackingField;
                static /*0x10*/ System.Collections.Generic.EqualityComparer<System.Nullable<double>> <BitwiseNullableDoubleEqualityComparer>k__BackingField;
                static /*0x18*/ System.Collections.Generic.EqualityComparer<System.Nullable<float>> <BitwiseNullableSingleEqualityComparer>k__BackingField;

                static /*0x30c5ca4*/ ProtobufEqualityComparers();
                static /*0x1f327a0*/ System.Collections.Generic.EqualityComparer<T> GetEqualityComparer<T>();
                static /*0x30c5b44*/ System.Collections.Generic.EqualityComparer<double> get_BitwiseDoubleEqualityComparer();
                static /*0x30c5b9c*/ System.Collections.Generic.EqualityComparer<float> get_BitwiseSingleEqualityComparer();
                static /*0x30c5bf4*/ System.Collections.Generic.EqualityComparer<System.Nullable<double>> get_BitwiseNullableDoubleEqualityComparer();
                static /*0x30c5c4c*/ System.Collections.Generic.EqualityComparer<System.Nullable<float>> get_BitwiseNullableSingleEqualityComparer();

                class BitwiseDoubleEqualityComparerImpl : System.Collections.Generic.EqualityComparer<double>
                {
                    /*0x30c5dd4*/ BitwiseDoubleEqualityComparerImpl();
                    /*0x30c5ef4*/ bool Equals(double x, double y);
                    /*0x30c5f08*/ int GetHashCode(double obj);
                }

                class BitwiseSingleEqualityComparerImpl : System.Collections.Generic.EqualityComparer<float>
                {
                    /*0x30c5e1c*/ BitwiseSingleEqualityComparerImpl();
                    /*0x30c5f24*/ bool Equals(float x, float y);
                    /*0x30c5f40*/ int GetHashCode(float obj);
                }

                class BitwiseNullableDoubleEqualityComparerImpl : System.Collections.Generic.EqualityComparer<System.Nullable<double>>
                {
                    /*0x30c5e64*/ BitwiseNullableDoubleEqualityComparerImpl();
                    /*0x30c5f60*/ bool Equals(System.Nullable<double> x, System.Nullable<double> y);
                    /*0x30c6150*/ int GetHashCode(System.Nullable<double> obj);
                }

                class BitwiseNullableSingleEqualityComparerImpl : System.Collections.Generic.EqualityComparer<System.Nullable<float>>
                {
                    /*0x30c5eac*/ BitwiseNullableSingleEqualityComparerImpl();
                    /*0x30c6278*/ bool Equals(System.Nullable<float> x, System.Nullable<float> y);
                    /*0x30c6468*/ int GetHashCode(System.Nullable<float> obj);
                }
            }

            class ReadOnlyDictionary<TKey, TValue> : System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable
            {
                /*0x0*/ System.Collections.Generic.IDictionary<TKey, TValue> wrapped;

                /*0x1f30ebc*/ ReadOnlyDictionary(System.Collections.Generic.IDictionary<TKey, TValue> wrapped);
                /*0x1ffc854*/ void Add(TKey key, TValue value);
                /*0x1ffc854*/ bool ContainsKey(TKey key);
                /*0x1f30214*/ System.Collections.Generic.ICollection<TKey> get_Keys();
                /*0x1ffc854*/ bool Remove(TKey key);
                /*0x1ffc854*/ bool TryGetValue(TKey key, ref TValue value);
                /*0x1f30214*/ System.Collections.Generic.ICollection<TValue> get_Values();
                /*0x1ffc854*/ TValue get_Item(TKey key);
                /*0x1ffc854*/ void set_Item(TKey key, TValue value);
                /*0x1ffc854*/ void Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
                /*0x1f309e4*/ void Clear();
                /*0x1ffc854*/ bool Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
                /*0x1f30ee8*/ void CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue> array, int arrayIndex);
                /*0x1f2ffc8*/ int get_Count();
                /*0x1f2fe14*/ bool get_IsReadOnly();
                /*0x1ffc854*/ bool Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
                /*0x1f30214*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator();
                /*0x1f30214*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x1f2fec8*/ bool Equals(object obj);
                /*0x1f2ffc8*/ int GetHashCode();
                /*0x1f30214*/ string ToString();
            }

            class RepeatedField<T> : System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection, Google.Protobuf.IDeepCloneable<Google.Protobuf.Collections.RepeatedField<T>>, System.IEquatable<Google.Protobuf.Collections.RepeatedField<T>>, System.Collections.Generic.IReadOnlyList<T>, System.Collections.Generic.IReadOnlyCollection<T>
            {
                static int MinArraySize = 8;
                static /*0x0*/ System.Collections.Generic.EqualityComparer<T> EqualityComparer;
                static /*0x0*/ System.Collections.Generic.List<T> EmptyArray;
                /*0x0*/ System.Collections.Generic.List<T> array;

                static /*0x1f33998*/ RepeatedField();
                /*0x1f309e4*/ RepeatedField();
                /*0x1f30214*/ Google.Protobuf.Collections.RepeatedField<T> Clone();
                /*0x1f30ff0*/ void AddEntriesFrom(Google.Protobuf.CodedInputStream input, Google.Protobuf.FieldCodec<T> codec);
                /*0x1f30ff0*/ void AddEntriesFrom(ref Google.Protobuf.ParseContext ctx, Google.Protobuf.FieldCodec<T> codec);
                /*0x1f3008c*/ int CalculateSize(Google.Protobuf.FieldCodec<T> codec);
                /*0x1f3008c*/ int CalculatePackedDataSize(Google.Protobuf.FieldCodec<T> codec);
                /*0x1f30ff0*/ void WriteTo(Google.Protobuf.CodedOutputStream output, Google.Protobuf.FieldCodec<T> codec);
                /*0x1f30ff0*/ void WriteTo(ref Google.Protobuf.WriteContext ctx, Google.Protobuf.FieldCodec<T> codec);
                /*0x1f2ffc8*/ int get_Capacity();
                /*0x1f30b78*/ void set_Capacity(int value);
                /*0x1f30b78*/ void SetSize(int size);
                /*0x1ffc854*/ void Add(T item);
                /*0x1f309e4*/ void Clear();
                /*0x1ffc854*/ bool Contains(T item);
                /*0x1f30ee8*/ void CopyTo(T[] array, int arrayIndex);
                /*0x1ffc854*/ bool Remove(T item);
                /*0x1f2ffc8*/ int get_Count();
                /*0x1f2fe14*/ bool get_IsReadOnly();
                /*0x1f30ebc*/ void AddRange(System.Collections.Generic.IEnumerable<T> values);
                /*0x1f30ebc*/ void Add(System.Collections.Generic.IEnumerable<T> values);
                /*0x1f30214*/ System.Collections.Generic.IEnumerator<T> GetEnumerator();
                /*0x1f2fec8*/ bool Equals(object obj);
                /*0x1f30214*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x1f2ffc8*/ int GetHashCode();
                /*0x1f2fec8*/ bool Equals(Google.Protobuf.Collections.RepeatedField<T> other);
                /*0x1ffc854*/ int IndexOf(T item);
                /*0x1ffc854*/ void Insert(int index, T item);
                /*0x1f30b78*/ void RemoveAt(int index);
                /*0x1f30214*/ string ToString();
                /*0x1ffc854*/ T get_Item(int index);
                /*0x1ffc854*/ void set_Item(int index, T value);
                /*0x1f2fe14*/ bool System.Collections.IList.get_IsFixedSize();
                /*0x1f30ee8*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
                /*0x1f2fe14*/ bool System.Collections.ICollection.get_IsSynchronized();
                /*0x1f30214*/ object System.Collections.ICollection.get_SyncRoot();
                /*0x1f30240*/ object System.Collections.IList.get_Item(int index);
                /*0x1f30c88*/ void System.Collections.IList.set_Item(int index, object value);
                /*0x1f3008c*/ int System.Collections.IList.Add(object value);
                /*0x1f2fec8*/ bool System.Collections.IList.Contains(object value);
                /*0x1f3008c*/ int System.Collections.IList.IndexOf(object value);
                /*0x1f30c88*/ void System.Collections.IList.Insert(int index, object value);
                /*0x1f30ebc*/ void System.Collections.IList.Remove(object value);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 1EFF1891409D680B30DE202BD7A16F945ED09F02601C0E7B90FD917BE1162300;
    static /*0x2c*/ <PrivateImplementationDetails> 7D3ED631C225BAFC29AD7279E0C4A8B07EFA13540DD8358F52484B3C67B0A49F;
    static /*0x2467*/ <PrivateImplementationDetails> B684B73AC8F7E7B17C6AE25987A7EF5C9034C8E4A6F31F4277488ED1E1818CD3;

    struct __StaticArrayInitTypeSize=44
    {
    }

    struct __StaticArrayInitTypeSize=9275
    {
    }

    struct __StaticArrayInitTypeSize=11234
    {
    }
}
