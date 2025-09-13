class <Module>
{
}

namespace MagicOnion
{
    struct ClientStreamingResult<TRequest, TResponse> : System.IDisposable
    {
        /*0x0*/ TResponse rawValue;
        /*0x0*/ bool hasRawValue;
        /*0x0*/ Grpc.Core.AsyncClientStreamingCall<System.Byte[], System.Byte[]> inner;
        /*0x0*/ Grpc.Core.IClientStreamWriter<TRequest> requestStream;
        /*0x0*/ MessagePack.MessagePackSerializerOptions serializerOptions;

        ClientStreamingResult(TResponse rawValue);
        ClientStreamingResult(Grpc.Core.AsyncClientStreamingCall<System.Byte[], System.Byte[]> inner, Grpc.Core.IClientStreamWriter<TRequest> requestStream, MessagePack.MessagePackSerializerOptions serializerOptions);
        System.Threading.Tasks.Task<TResponse> Deserialize();
        System.Threading.Tasks.Task<TResponse> get_ResponseAsync();
        System.Threading.Tasks.Task<Grpc.Core.Metadata> get_ResponseHeadersAsync();
        Grpc.Core.IClientStreamWriter<TRequest> get_RequestStream();
        System.Runtime.CompilerServices.TaskAwaiter<TResponse> GetAwaiter();
        Grpc.Core.Status GetStatus();
        Grpc.Core.Metadata GetTrailers();
        void Dispose();

        struct <Deserialize>d__7<TRequest, TResponse> : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x0*/ int <>1__state;
            /*0x0*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResponse> <>t__builder;
            /*0x0*/ MagicOnion.ClientStreamingResult<TRequest, TResponse> <>4__this;
            /*0x0*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Byte[]> <>u__1;

            void MoveNext();
            void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    struct DuplexStreamingResult<TRequest, TResponse> : System.IDisposable
    {
        /*0x0*/ Grpc.Core.AsyncDuplexStreamingCall<System.Byte[], System.Byte[]> inner;
        /*0x0*/ Grpc.Core.IClientStreamWriter<TRequest> requestStream;
        /*0x0*/ Grpc.Core.IAsyncStreamReader<TResponse> responseStream;

        DuplexStreamingResult(Grpc.Core.AsyncDuplexStreamingCall<System.Byte[], System.Byte[]> inner, Grpc.Core.IClientStreamWriter<TRequest> requestStream, Grpc.Core.IAsyncStreamReader<TResponse> responseStream, MessagePack.MessagePackSerializerOptions serializerOptions);
        Grpc.Core.AsyncDuplexStreamingCall<System.Byte[], System.Byte[]> get_RawStreamingCall();
        Grpc.Core.IAsyncStreamReader<TResponse> get_ResponseStream();
        Grpc.Core.IClientStreamWriter<TRequest> get_RequestStream();
        System.Threading.Tasks.Task<Grpc.Core.Metadata> get_ResponseHeadersAsync();
        Grpc.Core.Status GetStatus();
        Grpc.Core.Metadata GetTrailers();
        void Dispose();
    }

    class GenerateDefineDebugAttribute : System.Attribute
    {
        /*0x2b3a9d0*/ GenerateDefineDebugAttribute();
    }

    interface IServiceMarker
    {
    }

    interface IService<TSelf> : MagicOnion.IServiceMarker
    {
        TSelf WithOptions(Grpc.Core.CallOptions option);
        TSelf WithHeaders(Grpc.Core.Metadata headers);
        TSelf WithDeadline(System.DateTime deadline);
        TSelf WithCancellationToken(System.Threading.CancellationToken cancellationToken);
        TSelf WithHost(string host);
    }

    interface IStreamingHubMarker
    {
    }

    interface IStreamingHub<TSelf, TReceiver> : MagicOnion.IStreamingHubMarker, MagicOnion.IServiceMarker
    {
        TSelf FireAndForget();
        System.Threading.Tasks.Task DisposeAsync();
        System.Threading.Tasks.Task WaitForDisconnect();
    }

    class IgnoreAttribute : System.Attribute
    {
        /*0x2b3a9d8*/ IgnoreAttribute();
    }

    struct ServerStreamingResult<TResponse> : System.IDisposable
    {
        /*0x0*/ Grpc.Core.AsyncServerStreamingCall<System.Byte[]> inner;
        /*0x0*/ Grpc.Core.IAsyncStreamReader<TResponse> responseStream;

        ServerStreamingResult(Grpc.Core.AsyncServerStreamingCall<System.Byte[]> inner, Grpc.Core.IAsyncStreamReader<TResponse> responseStream, MessagePack.MessagePackSerializerOptions serializerOptions);
        Grpc.Core.IAsyncStreamReader<TResponse> get_ResponseStream();
        System.Threading.Tasks.Task<Grpc.Core.Metadata> get_ResponseHeadersAsync();
        Grpc.Core.Status GetStatus();
        Grpc.Core.Metadata GetTrailers();
        void Dispose();
    }

    struct UnaryResult<TResponse>
    {
        /*0x0*/ bool hasRawValue;
        /*0x0*/ TResponse rawValue;
        /*0x0*/ System.Threading.Tasks.Task<TResponse> rawTaskValue;
        /*0x0*/ System.Threading.Tasks.Task<MagicOnion.Client.IResponseContext<TResponse>> response;

        UnaryResult(TResponse rawValue);
        UnaryResult(System.Threading.Tasks.Task<TResponse> rawTaskValue);
        UnaryResult(System.Threading.Tasks.Task<MagicOnion.Client.IResponseContext<TResponse>> response);
        System.Threading.Tasks.Task<TResponse> get_ResponseAsync();
        System.Threading.Tasks.Task<Grpc.Core.Metadata> get_ResponseHeadersAsync();
        System.Threading.Tasks.Task<TResponse> UnwrapResponse();
        System.Threading.Tasks.Task<Grpc.Core.Metadata> UnwrapResponseHeaders();
        void UnwrapDispose();
        MagicOnion.Client.IResponseContext<TResponse> TryUnwrap();
        System.Runtime.CompilerServices.TaskAwaiter<TResponse> GetAwaiter();
        Grpc.Core.Status GetStatus();
        Grpc.Core.Metadata GetTrailers();
        void Dispose();

        struct <UnwrapResponse>d__<TResponse> : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x0*/ int <>1__state;
            /*0x0*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResponse> <>t__builder;
            /*0x0*/ MagicOnion.UnaryResult<TResponse> <>4__this;
            /*0x0*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<MagicOnion.Client.IResponseContext<TResponse>> <>u__1;
            /*0x0*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<TResponse> <>u__2;

            void MoveNext();
            void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }

        struct <UnwrapResponseHeaders>d__12<TResponse> : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x0*/ int <>1__state;
            /*0x0*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Grpc.Core.Metadata> <>t__builder;
            /*0x0*/ MagicOnion.UnaryResult<TResponse> <>4__this;
            /*0x0*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<MagicOnion.Client.IResponseContext<TResponse>> <>u__1;
            /*0x0*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Grpc.Core.Metadata> <>u__2;

            void MoveNext();
            void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }

        struct <UnwrapDispose>d__13<TResponse> : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x0*/ int <>1__state;
            /*0x0*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
            /*0x0*/ MagicOnion.UnaryResult<TResponse> <>4__this;
            /*0x0*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<MagicOnion.Client.IResponseContext<TResponse>> <>u__1;

            void MoveNext();
            void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    namespace Server
    {
        namespace Hubs
        {
            class MethodIdAttribute : System.Attribute
            {
                /*0x10*/ int MethodId;

                /*0x2b3a9e0*/ MethodIdAttribute(int methodId);
            }
        }
    }

    namespace CompilerServices
    {
        struct AsyncUnaryResultMethodBuilder<T>
        {
            /*0x0*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T> methodBuilder;
            /*0x0*/ T result;
            /*0x0*/ bool haveResult;
            /*0x0*/ bool useBuilder;

            static MagicOnion.CompilerServices.AsyncUnaryResultMethodBuilder<T> Create();
            void Start<TStateMachine>(ref TStateMachine stateMachine);
            void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            void SetResult(T result);
            void SetException(System.Exception exception);
            MagicOnion.UnaryResult<T> get_Task();
            void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine);
            void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine);
        }
    }

    namespace Client
    {
        interface IResponseContext : System.IDisposable
        {
            System.Threading.Tasks.Task<Grpc.Core.Metadata> get_ResponseHeadersAsync();
            Grpc.Core.Status GetStatus();
            Grpc.Core.Metadata GetTrailers();
            System.Type get_ResponseType();
        }

        interface IResponseContext<T> : MagicOnion.Client.IResponseContext, System.IDisposable
        {
            System.Threading.Tasks.Task<T> get_ResponseAsync();
        }
    }
}
