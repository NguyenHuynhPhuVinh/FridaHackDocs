class <Module>
{
}

namespace Grpc
{
    namespace Core
    {
        struct AsyncCallState
        {
            /*0x10*/ object responseHeadersAsync;
            /*0x18*/ object getStatusFunc;
            /*0x20*/ object getTrailersFunc;
            /*0x28*/ object disposeAction;
            /*0x30*/ object callbackState;

            /*0xb30d68*/ AsyncCallState(System.Func<object, System.Threading.Tasks.Task<Grpc.Core.Metadata>> responseHeadersAsync, System.Func<object, Grpc.Core.Status> getStatusFunc, System.Func<object, Grpc.Core.Metadata> getTrailersFunc, System.Action<object> disposeAction, object callbackState);
            /*0xb30d78*/ System.Threading.Tasks.Task<Grpc.Core.Metadata> ResponseHeadersAsync();
            /*0xb30d80*/ Grpc.Core.Status GetStatus();
            /*0xb30dc0*/ Grpc.Core.Metadata GetTrailers();
            /*0xb30dc8*/ void Dispose();
        }

        class AsyncClientStreamingCall<TRequest, TResponse> : System.IDisposable
        {
            /*0x0*/ Grpc.Core.IClientStreamWriter<TRequest> requestStream;
            /*0x0*/ System.Threading.Tasks.Task<TResponse> responseAsync;
            /*0x0*/ Grpc.Core.AsyncCallState callState;

            AsyncClientStreamingCall(Grpc.Core.IClientStreamWriter<TRequest> requestStream, System.Threading.Tasks.Task<TResponse> responseAsync, System.Func<object, System.Threading.Tasks.Task<Grpc.Core.Metadata>> responseHeadersAsync, System.Func<object, Grpc.Core.Status> getStatusFunc, System.Func<object, Grpc.Core.Metadata> getTrailersFunc, System.Action<object> disposeAction, object state);
            System.Threading.Tasks.Task<TResponse> get_ResponseAsync();
            System.Threading.Tasks.Task<Grpc.Core.Metadata> get_ResponseHeadersAsync();
            Grpc.Core.IClientStreamWriter<TRequest> get_RequestStream();
            Grpc.Core.Status GetStatus();
            Grpc.Core.Metadata GetTrailers();
            void Dispose();
        }

        class AsyncDuplexStreamingCall<TRequest, TResponse> : System.IDisposable
        {
            /*0x0*/ Grpc.Core.IClientStreamWriter<TRequest> requestStream;
            /*0x0*/ Grpc.Core.IAsyncStreamReader<TResponse> responseStream;
            /*0x0*/ Grpc.Core.AsyncCallState callState;

            AsyncDuplexStreamingCall(Grpc.Core.IClientStreamWriter<TRequest> requestStream, Grpc.Core.IAsyncStreamReader<TResponse> responseStream, System.Func<object, System.Threading.Tasks.Task<Grpc.Core.Metadata>> responseHeadersAsync, System.Func<object, Grpc.Core.Status> getStatusFunc, System.Func<object, Grpc.Core.Metadata> getTrailersFunc, System.Action<object> disposeAction, object state);
            Grpc.Core.IAsyncStreamReader<TResponse> get_ResponseStream();
            Grpc.Core.IClientStreamWriter<TRequest> get_RequestStream();
            System.Threading.Tasks.Task<Grpc.Core.Metadata> get_ResponseHeadersAsync();
            Grpc.Core.Status GetStatus();
            Grpc.Core.Metadata GetTrailers();
            void Dispose();
        }

        class AsyncServerStreamingCall<TResponse> : System.IDisposable
        {
            /*0x0*/ Grpc.Core.IAsyncStreamReader<TResponse> responseStream;
            /*0x0*/ Grpc.Core.AsyncCallState callState;

            AsyncServerStreamingCall(Grpc.Core.IAsyncStreamReader<TResponse> responseStream, System.Func<object, System.Threading.Tasks.Task<Grpc.Core.Metadata>> responseHeadersAsync, System.Func<object, Grpc.Core.Status> getStatusFunc, System.Func<object, Grpc.Core.Metadata> getTrailersFunc, System.Action<object> disposeAction, object state);
            Grpc.Core.IAsyncStreamReader<TResponse> get_ResponseStream();
            System.Threading.Tasks.Task<Grpc.Core.Metadata> get_ResponseHeadersAsync();
            Grpc.Core.Status GetStatus();
            Grpc.Core.Metadata GetTrailers();
            void Dispose();
        }

        class AsyncUnaryCall<TResponse> : System.IDisposable
        {
            /*0x0*/ System.Threading.Tasks.Task<TResponse> responseAsync;
            /*0x0*/ Grpc.Core.AsyncCallState callState;

            AsyncUnaryCall(System.Threading.Tasks.Task<TResponse> responseAsync, System.Func<object, System.Threading.Tasks.Task<Grpc.Core.Metadata>> responseHeadersAsync, System.Func<object, Grpc.Core.Status> getStatusFunc, System.Func<object, Grpc.Core.Metadata> getTrailersFunc, System.Action<object> disposeAction, object state);
            System.Threading.Tasks.Task<TResponse> get_ResponseAsync();
            System.Threading.Tasks.Task<Grpc.Core.Metadata> get_ResponseHeadersAsync();
            Grpc.Core.Status GetStatus();
            Grpc.Core.Metadata GetTrailers();
            void Dispose();
        }

        class CallCredentials
        {
            void InternalPopulateConfiguration(Grpc.Core.CallCredentialsConfiguratorBase configurator, object state);
        }

        class CallCredentialsConfiguratorBase
        {
            /*0x2afe994*/ CallCredentialsConfiguratorBase();
        }

        class CallInvoker
        {
            /*0x2afe99c*/ CallInvoker();
            Grpc.Core.AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(Grpc.Core.Method<TRequest, TResponse> method, string host, Grpc.Core.CallOptions options, TRequest request);
            Grpc.Core.AsyncServerStreamingCall<TResponse> AsyncServerStreamingCall<TRequest, TResponse>(Grpc.Core.Method<TRequest, TResponse> method, string host, Grpc.Core.CallOptions options, TRequest request);
            Grpc.Core.AsyncClientStreamingCall<TRequest, TResponse> AsyncClientStreamingCall<TRequest, TResponse>(Grpc.Core.Method<TRequest, TResponse> method, string host, Grpc.Core.CallOptions options);
            Grpc.Core.AsyncDuplexStreamingCall<TRequest, TResponse> AsyncDuplexStreamingCall<TRequest, TResponse>(Grpc.Core.Method<TRequest, TResponse> method, string host, Grpc.Core.CallOptions options);
        }

        struct CallOptions
        {
            /*0x10*/ Grpc.Core.Metadata headers;
            /*0x18*/ System.Nullable<System.DateTime> deadline;
            /*0x28*/ System.Threading.CancellationToken cancellationToken;
            /*0x30*/ Grpc.Core.WriteOptions writeOptions;
            /*0x38*/ Grpc.Core.ContextPropagationToken propagationToken;
            /*0x40*/ Grpc.Core.CallCredentials credentials;
            /*0x48*/ Grpc.Core.Internal.CallFlags flags;

            /*0xb30e0c*/ Grpc.Core.Metadata get_Headers();
            /*0xb30e14*/ System.Nullable<System.DateTime> get_Deadline();
            /*0xb30e20*/ System.Threading.CancellationToken get_CancellationToken();
            /*0xb30e28*/ Grpc.Core.WriteOptions get_WriteOptions();
            /*0xb30e30*/ Grpc.Core.ContextPropagationToken get_PropagationToken();
            /*0xb30e38*/ Grpc.Core.CallCredentials get_Credentials();
            /*0xb30e40*/ Grpc.Core.Internal.CallFlags get_Flags();
            /*0xb30e48*/ Grpc.Core.CallOptions WithHeaders(Grpc.Core.Metadata headers);
            /*0xb30e70*/ Grpc.Core.CallOptions WithDeadline(System.DateTime deadline);
            /*0xb30eb0*/ Grpc.Core.CallOptions WithCancellationToken(System.Threading.CancellationToken cancellationToken);
        }

        class ChannelBase
        {
            /*0x10*/ string target;

            /*0x2afead0*/ ChannelBase(string target);
            Grpc.Core.CallInvoker CreateCallInvoker();
            /*0x2afeb54*/ System.Threading.Tasks.Task ShutdownAsync();
            /*0x2afeb60*/ System.Threading.Tasks.Task ShutdownAsyncCore();

            struct <ShutdownAsyncCore>d__6 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;

                /*0xb30f40*/ void MoveNext();
                /*0xb30f58*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class ChannelCredentials
        {
            static /*0x0*/ Grpc.Core.ChannelCredentials InsecureInstance;
            static /*0x8*/ Grpc.Core.ChannelCredentials SecureSslInstance;

            static /*0x2afecbc*/ ChannelCredentials();
            static /*0x2afec58*/ Grpc.Core.ChannelCredentials get_Insecure();
            /*0x2afec50*/ ChannelCredentials();
            void InternalPopulateConfiguration(Grpc.Core.ChannelCredentialsConfiguratorBase configurator, object state);

            class InsecureCredentials : Grpc.Core.ChannelCredentials
            {
                /*0x2afed68*/ InsecureCredentials();
                /*0x2b0036c*/ void InternalPopulateConfiguration(Grpc.Core.ChannelCredentialsConfiguratorBase configurator, object state);
            }
        }

        class ChannelCredentialsConfiguratorBase
        {
            /*0x2afeddc*/ ChannelCredentialsConfiguratorBase();
            void SetInsecureCredentials(object state);
            void SetSslCredentials(object state, string rootCertificates, Grpc.Core.KeyCertificatePair keyCertificatePair, Grpc.Core.VerifyPeerCallback verifyPeerCallback);
        }

        class ContextPropagationOptions
        {
            static /*0x0*/ Grpc.Core.ContextPropagationOptions Default;
            /*0x10*/ bool propagateDeadline;
            /*0x11*/ bool propagateCancellation;

            static /*0x2afee38*/ ContextPropagationOptions();
            /*0x2afede4*/ ContextPropagationOptions(bool propagateDeadline, bool propagateCancellation);
            /*0x2afee28*/ bool get_IsPropagateDeadline();
            /*0x2afee30*/ bool get_IsPropagateCancellation();
        }

        class ContextPropagationToken
        {
        }

        class DeserializationContext
        {
            /*0x2afef20*/ DeserializationContext();
            /*0x2afeea0*/ byte[] PayloadAsNewBuffer();
            /*0x2afeee0*/ System.Buffers.ReadOnlySequence<byte> PayloadAsReadOnlySequence();
        }

        interface IAsyncStreamReader<T>
        {
            T get_Current();
            System.Threading.Tasks.Task<bool> MoveNext(System.Threading.CancellationToken cancellationToken);
        }

        interface IAsyncStreamWriter<T>
        {
            System.Threading.Tasks.Task WriteAsync(T message);
            Grpc.Core.WriteOptions get_WriteOptions();
            void set_WriteOptions(Grpc.Core.WriteOptions value);
        }

        interface IClientStreamWriter<T> : Grpc.Core.IAsyncStreamWriter<T>
        {
            System.Threading.Tasks.Task CompleteAsync();
        }

        class KeyCertificatePair
        {
            /*0x10*/ string certificateChain;
            /*0x18*/ string privateKey;

            /*0x2aff1b4*/ string get_CertificateChain();
            /*0x2aff1bc*/ string get_PrivateKey();
        }

        class Marshaller<T>
        {
            /*0x0*/ System.Func<T, System.Byte[]> serializer;
            /*0x0*/ System.Func<System.Byte[], T> deserializer;
            /*0x0*/ System.Action<T, Grpc.Core.SerializationContext> contextualSerializer;
            /*0x0*/ System.Func<Grpc.Core.DeserializationContext, T> contextualDeserializer;

            Marshaller(System.Func<T, System.Byte[]> serializer, System.Func<System.Byte[], T> deserializer);
            System.Action<T, Grpc.Core.SerializationContext> get_ContextualSerializer();
            System.Func<Grpc.Core.DeserializationContext, T> get_ContextualDeserializer();
            void EmulateContextualSerializer(T message, Grpc.Core.SerializationContext context);
            T EmulateContextualDeserializer(Grpc.Core.DeserializationContext context);
        }

        class Metadata : System.Collections.Generic.IList<Grpc.Core.Metadata.Entry>, System.Collections.Generic.ICollection<Grpc.Core.Metadata.Entry>, System.Collections.Generic.IEnumerable<Grpc.Core.Metadata.Entry>, System.Collections.IEnumerable
        {
            static /*0x0*/ Grpc.Core.Metadata Empty;
            static /*0x8*/ System.Text.Encoding EncodingASCII;
            /*0x10*/ System.Collections.Generic.List<Grpc.Core.Metadata.Entry> entries;
            /*0x18*/ bool readOnly;

            static /*0x2aff8ac*/ Metadata();
            /*0x2aff1c4*/ Metadata();
            /*0x2aff240*/ Grpc.Core.Metadata Freeze();
            /*0x2aff24c*/ int IndexOf(Grpc.Core.Metadata.Entry item);
            /*0x2aff2b0*/ void Insert(int index, Grpc.Core.Metadata.Entry item);
            /*0x2aff398*/ void RemoveAt(int index);
            /*0x2aff404*/ Grpc.Core.Metadata.Entry get_Item(int index);
            /*0x2aff478*/ void set_Item(int index, Grpc.Core.Metadata.Entry value);
            /*0x2aff50c*/ void Add(Grpc.Core.Metadata.Entry item);
            /*0x2aff598*/ void Clear();
            /*0x2aff5f4*/ bool Contains(Grpc.Core.Metadata.Entry item);
            /*0x2aff658*/ void CopyTo(Grpc.Core.Metadata.Entry[] array, int arrayIndex);
            /*0x2aff6c4*/ int get_Count();
            /*0x2aff710*/ bool get_IsReadOnly();
            /*0x2aff718*/ bool Remove(Grpc.Core.Metadata.Entry item);
            /*0x2aff784*/ System.Collections.Generic.IEnumerator<Grpc.Core.Metadata.Entry> GetEnumerator();
            /*0x2aff818*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x2aff344*/ void CheckWriteable();

            class Entry
            {
                static /*0x0*/ byte[] EmptyByteArray;
                /*0x10*/ string key;
                /*0x18*/ string value;
                /*0x20*/ byte[] valueBytes;

                static /*0x2b007d0*/ Entry();
                static /*0x2b0054c*/ Grpc.Core.Metadata.Entry CreateUnsafe(string key, nint source, int length);
                static /*0x2b00728*/ bool HasBinaryHeaderSuffix(string key);
                /*0x2b00394*/ Entry(string key, string value, byte[] valueBytes);
                /*0x2b003d4*/ string get_Key();
                /*0x2b003dc*/ string get_Value();
                /*0x2b00438*/ bool get_IsBinary();
                /*0x2b00448*/ string ToString();
                /*0x2b004b8*/ byte[] GetSerializedValueUnsafe();
            }
        }

        enum MethodType
        {
            Unary = 0,
            ClientStreaming = 1,
            ServerStreaming = 2,
            DuplexStreaming = 3,
        }

        class Method<TRequest, TResponse>
        {
            /*0x0*/ Grpc.Core.MethodType type;
            /*0x0*/ string serviceName;
            /*0x0*/ string name;
            /*0x0*/ Grpc.Core.Marshaller<TRequest> requestMarshaller;
            /*0x0*/ Grpc.Core.Marshaller<TResponse> responseMarshaller;
            /*0x0*/ string fullName;

            static string GetFullName(string serviceName, string methodName);
            Method(Grpc.Core.MethodType type, string serviceName, string name, Grpc.Core.Marshaller<TRequest> requestMarshaller, Grpc.Core.Marshaller<TResponse> responseMarshaller);
            string get_ServiceName();
            Grpc.Core.Marshaller<TRequest> get_RequestMarshaller();
            Grpc.Core.Marshaller<TResponse> get_ResponseMarshaller();
            string get_FullName();
        }

        class RpcException : System.Exception
        {
            /*0x88*/ Grpc.Core.Status status;
            /*0xa0*/ Grpc.Core.Metadata trailers;

            /*0x2aff92c*/ RpcException(Grpc.Core.Status status);
            /*0x2affb7c*/ RpcException(Grpc.Core.Status status, string message);
            /*0x2affc2c*/ RpcException(Grpc.Core.Status status, Grpc.Core.Metadata trailers);
            /*0x2affac0*/ RpcException(Grpc.Core.Status status, Grpc.Core.Metadata trailers, string message);
            /*0x2affc80*/ Grpc.Core.Status get_Status();
        }

        class SerializationContext
        {
            /*0x2affcd4*/ SerializationContext();
            /*0x2affc94*/ void Complete(byte[] payload);
        }

        class VerifyPeerCallback : System.MulticastDelegate
        {
            /*0x2affe4c*/ VerifyPeerCallback(object object, nint method);
            /*0x2affeac*/ bool Invoke(Grpc.Core.VerifyPeerContext context);
            /*0x2b00230*/ System.IAsyncResult BeginInvoke(Grpc.Core.VerifyPeerContext context, System.AsyncCallback callback, object object);
            /*0x2b00254*/ bool EndInvoke(System.IAsyncResult result);
        }

        class SslCredentials : Grpc.Core.ChannelCredentials
        {
            /*0x10*/ string rootCertificates;
            /*0x18*/ Grpc.Core.KeyCertificatePair keyCertificatePair;
            /*0x20*/ Grpc.Core.VerifyPeerCallback verifyPeerCallback;

            /*0x2afedcc*/ SslCredentials();
            /*0x2affcdc*/ SslCredentials(string rootCertificates, Grpc.Core.KeyCertificatePair keyCertificatePair, Grpc.Core.VerifyPeerCallback verifyPeerCallback);
            /*0x2affd68*/ void InternalPopulateConfiguration(Grpc.Core.ChannelCredentialsConfiguratorBase configurator, object state);
        }

        struct Status
        {
            static /*0x0*/ Grpc.Core.Status DefaultSuccess;
            static /*0x18*/ Grpc.Core.Status DefaultCancelled;
            /*0x10*/ Grpc.Core.StatusCode <StatusCode>k__BackingField;
            /*0x18*/ string <Detail>k__BackingField;
            /*0x20*/ System.Exception <DebugException>k__BackingField;

            static /*0x2affdc8*/ Status();
            /*0xb30f08*/ Status(Grpc.Core.StatusCode statusCode, string detail);
            /*0xb30f14*/ Status(Grpc.Core.StatusCode statusCode, string detail, System.Exception debugException);
            /*0xb30f20*/ Grpc.Core.StatusCode get_StatusCode();
            /*0xb30f28*/ string get_Detail();
            /*0xb30f30*/ System.Exception get_DebugException();
            /*0xb30f38*/ string ToString();
        }

        enum StatusCode
        {
            OK = 0,
            Cancelled = 1,
            Unknown = 2,
            InvalidArgument = 3,
            DeadlineExceeded = 4,
            NotFound = 5,
            AlreadyExists = 6,
            PermissionDenied = 7,
            Unauthenticated = 16,
            ResourceExhausted = 8,
            FailedPrecondition = 9,
            Aborted = 10,
            OutOfRange = 11,
            Unimplemented = 12,
            Internal = 13,
            Unavailable = 14,
            DataLoss = 15,
        }

        class VerifyPeerContext
        {
            /*0x10*/ string <TargetName>k__BackingField;
            /*0x18*/ string <PeerPem>k__BackingField;

            /*0x2b00280*/ VerifyPeerContext(string targetName, string peerPem);
        }

        enum WriteFlags
        {
            BufferHint = 1,
            NoCompress = 2,
        }

        class WriteOptions
        {
            static /*0x0*/ Grpc.Core.WriteOptions Default;
            /*0x10*/ Grpc.Core.WriteFlags flags;

            static /*0x2b002ec*/ WriteOptions();
            /*0x2b002b8*/ WriteOptions(Grpc.Core.WriteFlags flags);
            /*0x2b002e4*/ Grpc.Core.WriteFlags get_Flags();
        }

        namespace Utils
        {
            class GrpcPreconditions
            {
                static /*0x2aff084*/ void CheckArgument(bool condition);
                static /*0x2aff0cc*/ void CheckArgument(bool condition, string errorMessage);
                static T CheckNotNull<T>(T reference);
                static T CheckNotNull<T>(T reference, string paramName);
                static /*0x2aff11c*/ void CheckState(bool condition);
                static /*0x2aff164*/ void CheckState(bool condition, string errorMessage);
            }
        }

        namespace Api
        {
            namespace Utils
            {
                class EncodingExtensions
                {
                    static /*0x2afef28*/ string GetString(System.Text.Encoding encoding, byte* source, int byteCount);
                    static /*0x2aff00c*/ string GetString(System.Text.Encoding encoding, nint ptr, int len);
                }
            }
        }

        namespace Internal
        {
            enum CallFlags
            {
                IdempotentRequest = 16,
                WaitForReady = 32,
                CacheableRequest = 64,
            }
        }
    }
}
