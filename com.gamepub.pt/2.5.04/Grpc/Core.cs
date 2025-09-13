class <Module>
{
}

namespace Grpc
{
    namespace Core
    {
        struct CallInvocationDetails<TRequest, TResponse>
        {
            /*0x0*/ Grpc.Core.Channel channel;
            /*0x0*/ string method;
            /*0x0*/ string host;
            /*0x0*/ Grpc.Core.Marshaller<TRequest> requestMarshaller;
            /*0x0*/ Grpc.Core.Marshaller<TResponse> responseMarshaller;
            /*0x0*/ Grpc.Core.CallOptions options;

            CallInvocationDetails(Grpc.Core.Channel channel, Grpc.Core.Method<TRequest, TResponse> method, string host, Grpc.Core.CallOptions options);
            CallInvocationDetails(Grpc.Core.Channel channel, string method, string host, Grpc.Core.Marshaller<TRequest> requestMarshaller, Grpc.Core.Marshaller<TResponse> responseMarshaller, Grpc.Core.CallOptions options);
            Grpc.Core.Channel get_Channel();
            string get_Method();
            string get_Host();
            Grpc.Core.Marshaller<TRequest> get_RequestMarshaller();
            Grpc.Core.Marshaller<TResponse> get_ResponseMarshaller();
            Grpc.Core.CallOptions get_Options();
            Grpc.Core.CallInvocationDetails<TRequest, TResponse> WithOptions(Grpc.Core.CallOptions options);
        }

        class Calls
        {
            static Grpc.Core.AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(Grpc.Core.CallInvocationDetails<TRequest, TResponse> call, TRequest req);
            static Grpc.Core.AsyncServerStreamingCall<TResponse> AsyncServerStreamingCall<TRequest, TResponse>(Grpc.Core.CallInvocationDetails<TRequest, TResponse> call, TRequest req);
            static Grpc.Core.AsyncClientStreamingCall<TRequest, TResponse> AsyncClientStreamingCall<TRequest, TResponse>(Grpc.Core.CallInvocationDetails<TRequest, TResponse> call);
            static Grpc.Core.AsyncDuplexStreamingCall<TRequest, TResponse> AsyncDuplexStreamingCall<TRequest, TResponse>(Grpc.Core.CallInvocationDetails<TRequest, TResponse> call);

            class Callbacks<TRequest, TResponse>
            {
                static /*0x0*/ System.Func<object, System.Threading.Tasks.Task<Grpc.Core.Metadata>> GetHeaders;
                static /*0x0*/ System.Func<object, Grpc.Core.Status> GetStatus;
                static /*0x0*/ System.Func<object, Grpc.Core.Metadata> GetTrailers;
                static /*0x0*/ System.Action<object> Cancel;

                static Callbacks();

                class <>c<TRequest, TResponse>
                {
                    static /*0x0*/ Grpc.Core.Calls.Callbacks.<>c<TRequest, TResponse> <>9;

                    static <>c();
                    <>c();
                    System.Threading.Tasks.Task<Grpc.Core.Metadata> <.cctor>b__4_0(object state);
                    Grpc.Core.Status <.cctor>b__4_1(object state);
                    Grpc.Core.Metadata <.cctor>b__4_2(object state);
                    void <.cctor>b__4_3(object state);
                }
            }
        }

        class Channel : Grpc.Core.ChannelBase
        {
            static /*0x0*/ Grpc.Core.Logging.ILogger Logger;
            static /*0x8*/ Grpc.Core.Internal.BatchCompletionDelegate WatchConnectivityStateHandler;
            /*0x18*/ object myLock;
            /*0x20*/ Grpc.Core.Internal.AtomicCounter activeCallCounter;
            /*0x28*/ System.Threading.CancellationTokenSource shutdownTokenSource;
            /*0x30*/ Grpc.Core.GrpcEnvironment environment;
            /*0x38*/ Grpc.Core.Internal.CompletionQueueSafeHandle completionQueue;
            /*0x40*/ Grpc.Core.Internal.ChannelSafeHandle handle;
            /*0x48*/ System.Collections.Generic.Dictionary<string, Grpc.Core.ChannelOption> options;
            /*0x50*/ bool shutdownRequested;

            static /*0x155743c*/ Channel();
            static /*0x15559f0*/ void EnsureUserAgentChannelOption(System.Collections.Generic.Dictionary<string, Grpc.Core.ChannelOption> options);
            static /*0x15556d0*/ System.Collections.Generic.Dictionary<string, Grpc.Core.ChannelOption> CreateOptionsDictionary(System.Collections.Generic.IEnumerable<Grpc.Core.ChannelOption> options);
            /*0x15553b4*/ Channel(string target, Grpc.Core.ChannelCredentials credentials, System.Collections.Generic.IEnumerable<Grpc.Core.ChannelOption> options);
            /*0x15567b4*/ Channel(string host, int port, Grpc.Core.ChannelCredentials credentials, System.Collections.Generic.IEnumerable<Grpc.Core.ChannelOption> options);
            /*0x1556870*/ Grpc.Core.ChannelState get_State();
            /*0x15569e4*/ System.Threading.Tasks.Task WaitForStateChangedAsync(Grpc.Core.ChannelState lastObservedState, System.Nullable<System.DateTime> deadline);
            /*0x1556b10*/ System.Threading.Tasks.Task<bool> TryWaitForStateChangedAsync(Grpc.Core.ChannelState lastObservedState, System.Nullable<System.DateTime> deadline);
            /*0x1556ef0*/ System.Threading.CancellationToken get_ShutdownToken();
            /*0x1556f0c*/ System.Threading.Tasks.Task ConnectAsync(System.Nullable<System.DateTime> deadline);
            /*0x1557030*/ System.Threading.Tasks.Task ShutdownAsyncCore();
            /*0x155714c*/ Grpc.Core.CallInvoker CreateCallInvoker();
            /*0x1557214*/ Grpc.Core.Internal.ChannelSafeHandle get_Handle();
            /*0x155721c*/ Grpc.Core.Internal.CompletionQueueSafeHandle get_CompletionQueue();
            /*0x1557224*/ void AddCallReference(object call);
            /*0x1557280*/ void RemoveCallReference(object call);
            /*0x1556878*/ Grpc.Core.ChannelState GetConnectivityState(bool tryToConnect);

            struct <WaitForStateChangedAsync>d__16 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Grpc.Core.Channel <>4__this;
                /*0x38*/ Grpc.Core.ChannelState lastObservedState;
                /*0x40*/ System.Nullable<System.DateTime> deadline;
                /*0x50*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1;

                /*0xa859f8*/ void MoveNext();
                /*0xa85a00*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ConnectAsync>d__22 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Grpc.Core.Channel <>4__this;
                /*0x38*/ System.Nullable<System.DateTime> deadline;
                /*0x48*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xa859d0*/ void MoveNext();
                /*0xa859d8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ShutdownAsyncCore>d__23 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Grpc.Core.Channel <>4__this;
                /*0x38*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xa859e4*/ void MoveNext();
                /*0xa859ec*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            class <>c
            {
                static /*0x0*/ Grpc.Core.Channel.<> <>9;

                static /*0xfc8d80*/ <>c();
                /*0xfc8de0*/ <>c();
                /*0xfc8de8*/ void <.cctor>b__37_0(bool success, Grpc.Core.Internal.BatchContextSafeHandle ctx, object state);
            }
        }

        class ChannelOption : System.IEquatable<Grpc.Core.ChannelOption>
        {
            /*0x10*/ Grpc.Core.ChannelOption.OptionType type;
            /*0x18*/ string name;
            /*0x20*/ int intValue;
            /*0x28*/ string stringValue;

            static /*0x1557e00*/ bool op_Equality(Grpc.Core.ChannelOption option1, Grpc.Core.ChannelOption option2);
            static /*0x1557cf8*/ bool op_Inequality(Grpc.Core.ChannelOption option1, Grpc.Core.ChannelOption option2);
            /*0x1557384*/ ChannelOption(string name, string stringValue);
            /*0x1557b2c*/ ChannelOption(string name, int intValue);
            /*0x1557bbc*/ Grpc.Core.ChannelOption.OptionType get_Type();
            /*0x1557bc4*/ string get_Name();
            /*0x1557bcc*/ int get_IntValue();
            /*0x1557350*/ string get_StringValue();
            /*0x1557c00*/ bool Equals(object obj);
            /*0x1557c70*/ bool Equals(Grpc.Core.ChannelOption other);
            /*0x1557d14*/ int GetHashCode();

            enum OptionType
            {
                Integer = 0,
                String = 1,
            }
        }

        class ChannelOptions
        {
            static /*0x1555ea4*/ Grpc.Core.Internal.ChannelArgsSafeHandle CreateChannelArgs(System.Collections.Generic.ICollection<Grpc.Core.ChannelOption> options);
        }

        enum ChannelState
        {
            Idle = 0,
            Connecting = 1,
            Ready = 2,
            TransientFailure = 3,
            Shutdown = 4,
        }

        class DefaultCallInvoker : Grpc.Core.CallInvoker
        {
            /*0x10*/ Grpc.Core.Channel channel;

            /*0x15571a8*/ DefaultCallInvoker(Grpc.Core.Channel channel);
            Grpc.Core.AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(Grpc.Core.Method<TRequest, TResponse> method, string host, Grpc.Core.CallOptions options, TRequest request);
            Grpc.Core.AsyncServerStreamingCall<TResponse> AsyncServerStreamingCall<TRequest, TResponse>(Grpc.Core.Method<TRequest, TResponse> method, string host, Grpc.Core.CallOptions options, TRequest request);
            Grpc.Core.AsyncClientStreamingCall<TRequest, TResponse> AsyncClientStreamingCall<TRequest, TResponse>(Grpc.Core.Method<TRequest, TResponse> method, string host, Grpc.Core.CallOptions options);
            Grpc.Core.AsyncDuplexStreamingCall<TRequest, TResponse> AsyncDuplexStreamingCall<TRequest, TResponse>(Grpc.Core.Method<TRequest, TResponse> method, string host, Grpc.Core.CallOptions options);
            Grpc.Core.CallInvocationDetails<TRequest, TResponse> CreateCall<TRequest, TResponse>(Grpc.Core.Method<TRequest, TResponse> method, string host, Grpc.Core.CallOptions options);
        }

        class GrpcEnvironment
        {
            static /*0x0*/ object staticLock;
            static /*0x8*/ Grpc.Core.GrpcEnvironment instance;
            static /*0x10*/ int refCount;
            static /*0x14*/ System.Nullable<int> customThreadPoolSize;
            static /*0x1c*/ System.Nullable<int> customCompletionQueueCount;
            static /*0x24*/ bool inlineHandlers;
            static /*0x28*/ int batchContextPoolSharedCapacity;
            static /*0x2c*/ int batchContextPoolThreadLocalCapacity;
            static /*0x30*/ int requestCallContextPoolSharedCapacity;
            static /*0x34*/ int requestCallContextPoolThreadLocalCapacity;
            static /*0x38*/ System.Collections.Generic.HashSet<Grpc.Core.Channel> registeredChannels;
            static /*0x40*/ System.Collections.Generic.HashSet<Grpc.Core.Server> registeredServers;
            static /*0x48*/ Grpc.Core.Internal.AtomicCounter nativeInitCounter;
            static /*0x50*/ Grpc.Core.Logging.ILogger logger;
            static /*0x58*/ System.EventHandler ShuttingDown;
            /*0x10*/ Grpc.Core.Internal.IObjectPool<Grpc.Core.Internal.BatchContextSafeHandle> batchContextPool;
            /*0x18*/ Grpc.Core.Internal.IObjectPool<Grpc.Core.Internal.RequestCallContextSafeHandle> requestCallContextPool;
            /*0x20*/ Grpc.Core.Internal.GrpcThreadPool threadPool;
            /*0x28*/ Grpc.Core.Internal.DebugStats debugStats;
            /*0x30*/ Grpc.Core.Internal.AtomicCounter cqPickerCounter;
            /*0x38*/ bool isShutdown;

            static /*0x155c4b4*/ GrpcEnvironment();
            static /*0x1555bc4*/ Grpc.Core.GrpcEnvironment AddRef();
            static /*0x155b154*/ System.Threading.Tasks.Task ReleaseAsync();
            static /*0x1556634*/ void RegisterChannel(Grpc.Core.Channel channel);
            static /*0x155b250*/ void UnregisterChannel(Grpc.Core.Channel channel);
            static /*0x155b3f4*/ void UnregisterServer(Grpc.Core.Server server);
            static /*0x155b598*/ System.Threading.Tasks.Task ShutdownChannelsAsync();
            static /*0x155b82c*/ System.Threading.Tasks.Task KillServersAsync();
            static /*0x155bac0*/ Grpc.Core.Logging.ILogger get_Logger();
            static /*0x1557e74*/ void GrpcNativeInit();
            static /*0x155812c*/ void GrpcNativeShutdown();
            static /*0x155c250*/ bool get_IsNativeShutdownAllowed();
            /*0x155adc8*/ GrpcEnvironment();
            /*0x155c0e8*/ System.Collections.Generic.IReadOnlyCollection<Grpc.Core.Internal.CompletionQueueSafeHandle> get_CompletionQueues();
            /*0x155c104*/ Grpc.Core.Internal.IObjectPool<Grpc.Core.Internal.BatchContextSafeHandle> get_BatchContextPool();
            /*0x155c10c*/ Grpc.Core.Internal.IObjectPool<Grpc.Core.Internal.RequestCallContextSafeHandle> get_RequestCallContextPool();
            /*0x155c114*/ bool get_IsAlive();
            /*0x1555d94*/ Grpc.Core.Internal.CompletionQueueSafeHandle PickCompletionQueue();
            /*0x155c248*/ Grpc.Core.Internal.DebugStats get_DebugStats();
            /*0x155c318*/ System.Threading.Tasks.Task ShutdownAsync();
            /*0x155bb24*/ int GetThreadPoolSizeOrDefault();
            /*0x155bc2c*/ int GetCompletionQueueCountOrDefault();
            /*0x155c6cc*/ void <ShutdownAsync>b__60_0();

            class ShutdownHooks
            {
                static /*0x0*/ object staticLock;
                static /*0x8*/ bool hooksRegistered;

                static /*0xfcac78*/ ShutdownHooks();
                static /*0xfca854*/ void Register();
                static /*0xfcab40*/ void HandleShutdown();

                class <>c
                {
                    static /*0x0*/ Grpc.Core.GrpcEnvironment.ShutdownHooks.<> <>9;
                    static /*0x8*/ System.EventHandler <>9__2_0;
                    static /*0x10*/ System.EventHandler <>9__2_1;

                    static /*0xff1724*/ <>c();
                    /*0xff1784*/ <>c();
                    /*0xff178c*/ void <Register>b__2_0(object sender, System.EventArgs eventArgs);
                    /*0xff17e4*/ void <Register>b__2_1(object sender, System.EventArgs eventArgs);
                }
            }

            struct <ReleaseAsync>d__26 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xa85b6c*/ void MoveNext();
                /*0xa85b74*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            class <>c
            {
                static /*0x0*/ Grpc.Core.GrpcEnvironment.<> <>9;
                static /*0x8*/ System.Func<Grpc.Core.Channel, System.Threading.Tasks.Task> <>9__32_0;
                static /*0x10*/ System.Func<Grpc.Core.Server, System.Threading.Tasks.Task> <>9__33_0;
                static /*0x18*/ System.Func<Grpc.Core.Internal.BatchContextSafeHandle> <>9__45_0;
                static /*0x20*/ System.Func<Grpc.Core.Internal.RequestCallContextSafeHandle> <>9__45_1;

                static /*0xfc9f60*/ <>c();
                /*0xfc9fc0*/ <>c();
                /*0xfc9fc8*/ System.Threading.Tasks.Task <ShutdownChannelsAsync>b__32_0(Grpc.Core.Channel channel);
                /*0xfc9fe4*/ System.Threading.Tasks.Task <KillServersAsync>b__33_0(Grpc.Core.Server server);
                /*0xfca000*/ Grpc.Core.Internal.BatchContextSafeHandle <.ctor>b__45_0();
                /*0xfca05c*/ Grpc.Core.Internal.RequestCallContextSafeHandle <.ctor>b__45_1();
            }

            struct <ShutdownAsync>d__60 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Grpc.Core.GrpcEnvironment <>4__this;
                /*0x38*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xa85b80*/ void MoveNext();
                /*0xa85b88*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class Server
        {
            static /*0x0*/ Grpc.Core.Logging.ILogger Logger;
            /*0x10*/ Grpc.Core.Internal.AtomicCounter activeCallCounter;
            /*0x18*/ Grpc.Core.GrpcEnvironment environment;
            /*0x20*/ Grpc.Core.Internal.ServerSafeHandle handle;
            /*0x28*/ object myLock;
            /*0x30*/ System.Threading.Tasks.TaskCompletionSource<object> shutdownTcs;
            /*0x38*/ bool shutdownRequested;

            static /*0xfc3500*/ Server();
            /*0xfc309c*/ System.Threading.Tasks.Task KillAsync();
            /*0xfc30a4*/ System.Threading.Tasks.Task ShutdownInternalAsync(bool kill);
            /*0xfc31bc*/ System.Threading.Tasks.Task ShutdownCompleteOrEnvironmentDeadAsync();
            /*0xfc32d8*/ void DisposeHandle();
            /*0xfc34a8*/ void HandleServerShutdown(bool success, Grpc.Core.Internal.BatchContextSafeHandle ctx, object state);

            struct <ShutdownInternalAsync>d__32 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Grpc.Core.Server <>4__this;
                /*0x38*/ bool kill;
                /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

                /*0xa85ba8*/ void MoveNext();
                /*0xa85bb0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ShutdownCompleteOrEnvironmentDeadAsync>d__33 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ Grpc.Core.Server <>4__this;
                /*0x38*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.Threading.Tasks.Task> <>u__1;

                /*0xa85b94*/ void MoveNext();
                /*0xa85b9c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        enum SslClientCertificateRequestType
        {
            DontRequest = 0,
            RequestButDontVerify = 1,
            RequestAndVerify = 2,
            RequestAndRequireButDontVerify = 3,
            RequestAndRequireAndVerify = 4,
        }

        namespace Utils
        {
            class TaskUtils
            {
                static /*0xfc59e8*/ System.Threading.Tasks.Task get_CompletedTask();
            }
        }

        namespace Profiling
        {
            interface IProfiler
            {
            }

            struct ProfilerEntry
            {
                /*0x10*/ Grpc.Core.Internal.Timespec timespec;
                /*0x20*/ Grpc.Core.Profiling.ProfilerEntry.Type type;
                /*0x28*/ string tag;

                static /*0x156fd20*/ string GetTypeAbbreviation(Grpc.Core.Profiling.ProfilerEntry.Type type);
                /*0xaa538c*/ string ToString();

                enum Type
                {
                    BEGIN = 0,
                    END = 1,
                    MARK = 2,
                }
            }

            class Profilers
            {
                static /*0x0*/ Grpc.Core.Profiling.NopProfiler DefaultProfiler;
                static /*0x8*/ System.Threading.ThreadLocal<Grpc.Core.Profiling.IProfiler> profilers;

                static /*0x156fdd4*/ Profilers();
                static /*0x155d414*/ void SetForCurrentThread(Grpc.Core.Profiling.IProfiler profiler);
            }

            class NopProfiler : Grpc.Core.Profiling.IProfiler
            {
                /*0x156f304*/ NopProfiler();
            }

            class BasicProfiler : Grpc.Core.Profiling.IProfiler
            {
                /*0x10*/ Grpc.Core.Profiling.ProfilerEntry[] entries;
                /*0x18*/ int count;

                /*0x155262c*/ void Dump(string filepath);
                /*0x1552764*/ void Dump(System.IO.TextWriter stream);
            }
        }

        namespace Logging
        {
            class ConsoleLogger : Grpc.Core.Logging.TextWriterLogger
            {
                /*0x1558f64*/ ConsoleLogger();
                /*0x1558f6c*/ ConsoleLogger(System.Type forType);
                Grpc.Core.Logging.ILogger ForType<T>();

                class <>c
                {
                    static /*0x0*/ Grpc.Core.Logging.ConsoleLogger.<> <>9;
                    static /*0x8*/ System.Func<System.IO.TextWriter> <>9__1_0;

                    static /*0xfc98c8*/ <>c();
                    /*0xfc9928*/ <>c();
                    /*0xfc9930*/ System.IO.TextWriter <.ctor>b__1_0();
                }
            }

            interface ILogger
            {
                Grpc.Core.Logging.ILogger ForType<T>();
                void Debug(string message);
                void Debug(string format, object[] formatArgs);
                void Info(string message);
                void Warning(string format, object[] formatArgs);
                void Error(string message);
                void Error(System.Exception exception, string message);
            }

            enum LogLevel
            {
                Debug = 0,
                Info = 1,
                Warning = 2,
                Error = 3,
                Off = 2147483647,
            }

            class LogLevelFilterLogger : Grpc.Core.Logging.ILogger
            {
                /*0x10*/ Grpc.Core.Logging.ILogger innerLogger;
                /*0x18*/ Grpc.Core.Logging.LogLevel logLevel;

                static /*0x155dea0*/ Grpc.Core.Logging.LogLevel GetLogLevelFromEnvironment(Grpc.Core.Logging.LogLevel defaultLogLevel, bool fromEnvironmentVariable);
                /*0x155de2c*/ LogLevelFilterLogger(Grpc.Core.Logging.ILogger logger, Grpc.Core.Logging.LogLevel logLevel);
                /*0x155c694*/ LogLevelFilterLogger(Grpc.Core.Logging.ILogger logger, Grpc.Core.Logging.LogLevel defaultLogLevel, bool fromEnvironmentVariable);
                Grpc.Core.Logging.ILogger ForType<T>();
                /*0x155dfa0*/ void Debug(string message);
                /*0x155e07c*/ void Debug(string format, object[] formatArgs);
                /*0x155e160*/ void Info(string message);
                /*0x155e23c*/ void Warning(string format, object[] formatArgs);
                /*0x155e320*/ void Error(string message);
                /*0x155e3fc*/ void Error(System.Exception exception, string message);
            }

            class TextWriterLogger : Grpc.Core.Logging.ILogger
            {
                /*0x10*/ System.Func<System.IO.TextWriter> textWriterProvider;
                /*0x18*/ System.Type forType;
                /*0x20*/ string forTypeString;

                /*0xfc5a5c*/ TextWriterLogger(System.Func<System.IO.TextWriter> textWriterProvider, System.Type forType);
                Grpc.Core.Logging.ILogger ForType<T>();
                /*0xfc5bd0*/ void Debug(string message);
                /*0xfc5e58*/ void Debug(string format, object[] formatArgs);
                /*0xfc5e8c*/ void Info(string message);
                /*0xfc5ee8*/ void Warning(string message);
                /*0xfc5f44*/ void Warning(string format, object[] formatArgs);
                /*0xfc5f78*/ void Error(string message);
                /*0xfc5fd4*/ void Error(System.Exception exception, string message);
                /*0xfc6044*/ System.Type get_AssociatedType();
                /*0xfc5c2c*/ void Log(string severityString, string message);
            }
        }

        namespace Internal
        {
            class AsyncCall<TRequest, TResponse> : Grpc.Core.Internal.AsyncCallBase<TRequest, TResponse>, Grpc.Core.Internal.IUnaryResponseClientCallback, Grpc.Core.Internal.IReceivedStatusOnClientCallback, Grpc.Core.Internal.IReceivedResponseHeadersCallback
            {
                static /*0x0*/ Grpc.Core.Logging.ILogger Logger;
                /*0x0*/ Grpc.Core.CallInvocationDetails<TRequest, TResponse> details;
                /*0x0*/ Grpc.Core.Internal.INativeCall injectedNativeCall;
                /*0x0*/ bool registeredWithChannel;
                /*0x0*/ System.Threading.CancellationTokenRegistration cancellationTokenRegistration;
                /*0x0*/ System.Threading.Tasks.TaskCompletionSource<TResponse> unaryResponseTcs;
                /*0x0*/ System.Threading.Tasks.TaskCompletionSource<object> streamingResponseCallFinishedTcs;
                /*0x0*/ System.Threading.Tasks.TaskCompletionSource<Grpc.Core.Metadata> responseHeadersTcs;
                /*0x0*/ System.Nullable<Grpc.Core.Internal.ClientSideStatus> finishedStatus;

                static AsyncCall();
                AsyncCall(Grpc.Core.CallInvocationDetails<TRequest, TResponse> callDetails);
                System.Threading.Tasks.Task<TResponse> UnaryCallAsync(TRequest msg);
                System.Threading.Tasks.Task<TResponse> ClientStreamingCallAsync();
                void StartServerStreamingCall(TRequest msg);
                void StartDuplexStreamingCall();
                System.Threading.Tasks.Task SendMessageAsync(TRequest msg, Grpc.Core.WriteFlags writeFlags);
                System.Threading.Tasks.Task<TResponse> ReadMessageAsync();
                System.Threading.Tasks.Task SendCloseFromClientAsync();
                System.Threading.Tasks.Task get_StreamingResponseCallFinishedTask();
                System.Threading.Tasks.Task<Grpc.Core.Metadata> get_ResponseHeadersAsync();
                Grpc.Core.Status GetStatus();
                Grpc.Core.Metadata GetTrailers();
                Grpc.Core.CallInvocationDetails<TRequest, TResponse> get_Details();
                void OnAfterReleaseResourcesLocked();
                void OnAfterReleaseResourcesUnlocked();
                bool get_IsClient();
                System.Exception GetRpcExceptionClientOnly();
                System.Threading.Tasks.Task CheckSendAllowedOrEarlyResult();
                System.Threading.Tasks.Task CheckSendPreconditionsClientSide();
                void Initialize(Grpc.Core.Internal.CompletionQueueSafeHandle cq);
                void OnFailedToStartCallLocked();
                Grpc.Core.Internal.INativeCall CreateNativeCall(Grpc.Core.Internal.CompletionQueueSafeHandle cq);
                void RegisterCancellationCallback();
                Grpc.Core.WriteFlags GetWriteFlagsForCall();
                void HandleReceivedResponseHeaders(bool success, Grpc.Core.Metadata responseHeaders);
                void HandleUnaryResponse(bool success, Grpc.Core.Internal.ClientSideStatus receivedStatus, Grpc.Core.Internal.IBufferReader receivedMessageReader, Grpc.Core.Metadata responseHeaders);
                void HandleFinished(bool success, Grpc.Core.Internal.ClientSideStatus receivedStatus);
                Grpc.Core.Internal.IUnaryResponseClientCallback get_UnaryResponseClientCallback();
                void Grpc.Core.Internal.IUnaryResponseClientCallback.OnUnaryResponseClient(bool success, Grpc.Core.Internal.ClientSideStatus receivedStatus, Grpc.Core.Internal.IBufferReader receivedMessageReader, Grpc.Core.Metadata responseHeaders);
                Grpc.Core.Internal.IReceivedStatusOnClientCallback get_ReceivedStatusOnClientCallback();
                void Grpc.Core.Internal.IReceivedStatusOnClientCallback.OnReceivedStatusOnClient(bool success, Grpc.Core.Internal.ClientSideStatus receivedStatus);
                Grpc.Core.Internal.IReceivedResponseHeadersCallback get_ReceivedResponseHeadersCallback();
                void Grpc.Core.Internal.IReceivedResponseHeadersCallback.OnReceivedResponseHeaders(bool success, Grpc.Core.Metadata responseHeaders);
                void <OnFailedToStartCallLocked>b__35_0(object state);
            }

            class AsyncCallBase<TWrite, TRead> : Grpc.Core.Internal.IReceivedMessageCallback, Grpc.Core.Internal.ISendCompletionCallback
            {
                static /*0x0*/ Grpc.Core.Logging.ILogger Logger;
                static /*0x0*/ Grpc.Core.Status DeserializeResponseFailureStatus;
                static /*0x0*/ System.Action<object> CancelCallFromToken;
                /*0x0*/ System.Action<TWrite, Grpc.Core.SerializationContext> serializer;
                /*0x0*/ System.Func<Grpc.Core.DeserializationContext, TRead> deserializer;
                /*0x0*/ object myLock;
                /*0x0*/ Grpc.Core.Internal.INativeCall call;
                /*0x0*/ bool disposed;
                /*0x0*/ bool started;
                /*0x0*/ bool cancelRequested;
                /*0x0*/ System.Threading.Tasks.TaskCompletionSource<TRead> streamingReadTcs;
                /*0x0*/ System.Threading.Tasks.TaskCompletionSource<object> streamingWriteTcs;
                /*0x0*/ bool isStreamingWriteCompletionDelayed;
                /*0x0*/ bool readingDone;
                /*0x0*/ bool halfcloseRequested;
                /*0x0*/ bool finished;
                /*0x0*/ bool initialMetadataSent;
                /*0x0*/ long streamingWritesCounter;

                static AsyncCallBase();
                AsyncCallBase(System.Action<TWrite, Grpc.Core.SerializationContext> serializer, System.Func<Grpc.Core.DeserializationContext, TRead> deserializer);
                void Cancel();
                void CancelWithStatus(Grpc.Core.Status status);
                void InitializeInternal(Grpc.Core.Internal.INativeCall call);
                System.Threading.Tasks.Task SendMessageInternalAsync(TWrite msg, Grpc.Core.WriteFlags writeFlags);
                System.Threading.Tasks.Task<TRead> ReadMessageInternalAsync();
                bool ReleaseResourcesIfPossible();
                bool get_IsClient();
                System.Exception GetRpcExceptionClientOnly();
                void ReleaseResources();
                void OnAfterReleaseResourcesLocked();
                void OnAfterReleaseResourcesUnlocked();
                System.Threading.Tasks.Task CheckSendAllowedOrEarlyResult();
                Grpc.Core.Internal.SliceBufferSafeHandle UnsafeSerialize(TWrite msg, Grpc.Core.Internal.DefaultSerializationContext context);
                System.Exception TryDeserialize(Grpc.Core.Internal.IBufferReader reader, ref TRead msg);
                void HandleSendFinished(bool success);
                void HandleReadFinished(bool success, Grpc.Core.Internal.IBufferReader receivedMessageReader);
                Grpc.Core.Internal.ISendCompletionCallback get_SendCompletionCallback();
                void Grpc.Core.Internal.ISendCompletionCallback.OnSendCompletion(bool success);
                Grpc.Core.Internal.IReceivedMessageCallback get_ReceivedMessageCallback();
                void Grpc.Core.Internal.IReceivedMessageCallback.OnReceivedMessage(bool success, Grpc.Core.Internal.IBufferReader receivedMessageReader);
                System.Threading.CancellationTokenRegistration RegisterCancellationCallbackForToken(System.Threading.CancellationToken cancellationToken);

                class <>c<TWrite, TRead>
                {
                    static /*0x0*/ Grpc.Core.Internal.AsyncCallBase.<>c<TWrite, TRead> <>9;

                    static <>c();
                    <>c();
                    void <.cctor>b__45_0(object state);
                }
            }

            class AtomicCounter
            {
                /*0x10*/ long counter;

                /*0x15523ec*/ AtomicCounter(long initialCount);
                /*0x1552418*/ long Increment();
                /*0x1552424*/ void IncrementIfNonzero(ref bool success);
                /*0x1552484*/ long Decrement();
                /*0x1552490*/ long get_Count();
            }

            class AuthContextSafeHandle : Grpc.Core.Internal.SafeHandleZeroIsInvalid
            {
                static /*0x0*/ Grpc.Core.Internal.NativeMethods Native;

                static /*0x1552574*/ AuthContextSafeHandle();
                /*0x155249c*/ AuthContextSafeHandle();
                /*0x15524ec*/ bool ReleaseHandle();

                struct NativeAuthPropertyIterator
                {
                    /*0x10*/ nint AuthContext;
                    /*0x18*/ nuint Index;
                    /*0x20*/ nint Name;
                }
            }

            interface IOpCompletionCallback
            {
                void OnComplete(bool success);
            }

            interface IBufferReader
            {
                System.Nullable<int> get_TotalLength();
                bool TryGetNextSlice(ref Grpc.Core.Internal.Slice slice);
            }

            class BatchContextSafeHandle : Grpc.Core.Internal.SafeHandleZeroIsInvalid, Grpc.Core.Internal.IOpCompletionCallback, Grpc.Core.Internal.IPooledObject<Grpc.Core.Internal.BatchContextSafeHandle>, System.IDisposable, Grpc.Core.Internal.IBufferReader
            {
                static /*0x0*/ Grpc.Core.Internal.NativeMethods Native;
                static /*0x8*/ Grpc.Core.Logging.ILogger Logger;
                /*0x20*/ System.Action<Grpc.Core.Internal.BatchContextSafeHandle> returnToPoolAction;
                /*0x28*/ Grpc.Core.Internal.BatchContextSafeHandle.CompletionCallbackData completionCallbackData;

                static /*0x1553be8*/ BatchContextSafeHandle();
                static /*0x1552d38*/ Grpc.Core.Internal.BatchContextSafeHandle Create();
                /*0x1552d34*/ BatchContextSafeHandle();
                /*0x1552db0*/ nint get_Handle();
                /*0x1552db8*/ void SetReturnToPoolAction(System.Action<Grpc.Core.Internal.BatchContextSafeHandle> returnAction);
                /*0x1552df0*/ void SetCompletionCallback(Grpc.Core.Internal.BatchCompletionDelegate callback, object state);
                /*0x1552ea4*/ Grpc.Core.Metadata GetReceivedInitialMetadata();
                /*0x1553228*/ Grpc.Core.Internal.ClientSideStatus GetReceivedStatusOnClient();
                /*0x15535a0*/ Grpc.Core.Internal.IBufferReader GetReceivedMessageReader();
                /*0x15535a4*/ bool GetReceivedCloseOnServerCancelled();
                /*0x1553630*/ void Recycle();
                /*0x15536f8*/ bool ReleaseHandle();
                /*0x1553780*/ void Grpc.Core.Internal.IOpCompletionCallback.OnComplete(bool success);
                /*0x15539d4*/ System.Nullable<int> Grpc.Core.Internal.IBufferReader.get_TotalLength();
                /*0x1553ad0*/ bool Grpc.Core.Internal.IBufferReader.TryGetNextSlice(ref Grpc.Core.Internal.Slice slice);

                struct CompletionCallbackData
                {
                    /*0x10*/ Grpc.Core.Internal.BatchCompletionDelegate <Callback>k__BackingField;
                    /*0x18*/ object <State>k__BackingField;

                    /*0xa859b8*/ CompletionCallbackData(Grpc.Core.Internal.BatchCompletionDelegate callback, object state);
                    /*0xa859c0*/ Grpc.Core.Internal.BatchCompletionDelegate get_Callback();
                    /*0xa859c8*/ object get_State();
                }
            }

            class CallCredentialsSafeHandle : Grpc.Core.Internal.SafeHandleZeroIsInvalid
            {
                static /*0x0*/ Grpc.Core.Internal.NativeMethods Native;

                static /*0x1553f40*/ CallCredentialsSafeHandle();
                /*0x1553eb4*/ CallCredentialsSafeHandle();
                /*0x1553eb8*/ bool ReleaseHandle();
            }

            enum CallError
            {
                OK = 0,
                Error = 1,
                NotOnServer = 2,
                NotOnClient = 3,
                AlreadyAccepted = 4,
                AlreadyInvoked = 5,
                NotInvoked = 6,
                AlreadyFinished = 7,
                TooManyOperations = 8,
                InvalidFlags = 9,
                InvalidMetadata = 10,
                InvalidMessage = 11,
                NotServerCompletionQueue = 12,
                BatchTooBig = 13,
                PayloadTypeMismatch = 14,
                CompletionQueueShutdown = 15,
            }

            class CallErrorExtensions
            {
                static /*0x1553f90*/ void CheckOk(Grpc.Core.Internal.CallError callError);
            }

            class CallOptionsExtensions
            {
                static /*0x1554018*/ Grpc.Core.CallOptions Normalize(Grpc.Core.CallOptions options);
            }

            class CallSafeHandle : Grpc.Core.Internal.SafeHandleZeroIsInvalid, Grpc.Core.Internal.INativeCall, System.IDisposable
            {
                static /*0x0*/ Grpc.Core.Internal.CallSafeHandle NullInstance;
                static /*0x8*/ Grpc.Core.Internal.NativeMethods Native;
                static /*0x10*/ Grpc.Core.Internal.BatchCompletionDelegate CompletionHandler_IUnaryResponseClientCallback;
                static /*0x18*/ Grpc.Core.Internal.BatchCompletionDelegate CompletionHandler_IReceivedStatusOnClientCallback;
                static /*0x20*/ Grpc.Core.Internal.BatchCompletionDelegate CompletionHandler_IReceivedMessageCallback;
                static /*0x28*/ Grpc.Core.Internal.BatchCompletionDelegate CompletionHandler_IReceivedResponseHeadersCallback;
                static /*0x30*/ Grpc.Core.Internal.BatchCompletionDelegate CompletionHandler_ISendCompletionCallback;
                static /*0x38*/ Grpc.Core.Internal.BatchCompletionDelegate CompletionHandler_ISendStatusFromServerCompletionCallback;
                static /*0x40*/ Grpc.Core.Internal.BatchCompletionDelegate CompletionHandler_IReceivedCloseOnServerCallback;
                /*0x20*/ Grpc.Core.Internal.CompletionQueueSafeHandle completionQueue;

                static /*0x155511c*/ CallSafeHandle();
                /*0x15542c0*/ CallSafeHandle();
                /*0x15542c4*/ void Initialize(Grpc.Core.Internal.CompletionQueueSafeHandle completionQueue);
                /*0x15542cc*/ void SetCredentials(Grpc.Core.Internal.CallCredentialsSafeHandle credentials);
                /*0x1554360*/ void StartUnary(Grpc.Core.Internal.IUnaryResponseClientCallback callback, Grpc.Core.Internal.SliceBufferSafeHandle payload, Grpc.Core.WriteFlags writeFlags, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags callFlags);
                /*0x15545a4*/ void StartClientStreaming(Grpc.Core.Internal.IUnaryResponseClientCallback callback, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags callFlags);
                /*0x1554710*/ void StartServerStreaming(Grpc.Core.Internal.IReceivedStatusOnClientCallback callback, Grpc.Core.Internal.SliceBufferSafeHandle payload, Grpc.Core.WriteFlags writeFlags, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags callFlags);
                /*0x1554894*/ void StartDuplexStreaming(Grpc.Core.Internal.IReceivedStatusOnClientCallback callback, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags callFlags);
                /*0x1554a00*/ void StartSendMessage(Grpc.Core.Internal.ISendCompletionCallback callback, Grpc.Core.Internal.SliceBufferSafeHandle payload, Grpc.Core.WriteFlags writeFlags, bool sendEmptyInitialMetadata);
                /*0x1554b7c*/ void StartSendCloseFromClient(Grpc.Core.Internal.ISendCompletionCallback callback);
                /*0x1554cd0*/ void StartReceiveMessage(Grpc.Core.Internal.IReceivedMessageCallback callback);
                /*0x1554e24*/ void StartReceiveInitialMetadata(Grpc.Core.Internal.IReceivedResponseHeadersCallback callback);
                /*0x1554f78*/ void Cancel();
                /*0x1554ffc*/ void CancelWithStatus(Grpc.Core.Status status);
                /*0x1555094*/ bool ReleaseHandle();

                class <>c
                {
                    static /*0x0*/ Grpc.Core.Internal.CallSafeHandle.<> <>9;

                    static /*0xfc8510*/ <>c();
                    /*0xfc8570*/ <>c();
                    /*0xfc8578*/ void <.cctor>b__33_0(bool success, Grpc.Core.Internal.BatchContextSafeHandle context, object state);
                    /*0xfc86e8*/ void <.cctor>b__33_1(bool success, Grpc.Core.Internal.BatchContextSafeHandle context, object state);
                    /*0xfc8828*/ void <.cctor>b__33_2(bool success, Grpc.Core.Internal.BatchContextSafeHandle context, object state);
                    /*0xfc8948*/ void <.cctor>b__33_3(bool success, Grpc.Core.Internal.BatchContextSafeHandle context, object state);
                    /*0xfc8a68*/ void <.cctor>b__33_4(bool success, Grpc.Core.Internal.BatchContextSafeHandle context, object state);
                    /*0xfc8b64*/ void <.cctor>b__33_5(bool success, Grpc.Core.Internal.BatchContextSafeHandle context, object state);
                    /*0xfc8c60*/ void <.cctor>b__33_6(bool success, Grpc.Core.Internal.BatchContextSafeHandle context, object state);
                }
            }

            class ChannelArgsSafeHandle : Grpc.Core.Internal.SafeHandleZeroIsInvalid
            {
                static /*0x0*/ Grpc.Core.Internal.NativeMethods Native;

                static /*0x1557924*/ ChannelArgsSafeHandle();
                static /*0x155761c*/ Grpc.Core.Internal.ChannelArgsSafeHandle CreateNull();
                static /*0x1557670*/ Grpc.Core.Internal.ChannelArgsSafeHandle Create(int size);
                /*0x1557618*/ ChannelArgsSafeHandle();
                /*0x1557714*/ void SetString(int index, string key, string value);
                /*0x15577d8*/ void SetInteger(int index, string key, int value);
                /*0x155789c*/ bool ReleaseHandle();
            }

            class ChannelCredentialsSafeHandle : Grpc.Core.Internal.SafeHandleZeroIsInvalid
            {
                static /*0x0*/ Grpc.Core.Internal.NativeMethods Native;

                static /*0x1557adc*/ ChannelCredentialsSafeHandle();
                static /*0x1557980*/ Grpc.Core.Internal.ChannelCredentialsSafeHandle CreateSslCredentials(string pemRootCerts, Grpc.Core.KeyCertificatePair keyCertPair, nint verifyPeerCallbackTag);
                /*0x155797c*/ ChannelCredentialsSafeHandle();
                /*0x1557a54*/ bool ReleaseHandle();
            }

            class ChannelSafeHandle : Grpc.Core.Internal.SafeHandleZeroIsInvalid
            {
                static /*0x0*/ Grpc.Core.Internal.NativeMethods Native;

                static /*0x15581b0*/ ChannelSafeHandle();
                static /*0x1556574*/ Grpc.Core.Internal.ChannelSafeHandle CreateInsecure(string target, Grpc.Core.Internal.ChannelArgsSafeHandle channelArgs);
                static /*0x15564ac*/ Grpc.Core.Internal.ChannelSafeHandle CreateSecure(Grpc.Core.Internal.ChannelCredentialsSafeHandle credentials, string target, Grpc.Core.Internal.ChannelArgsSafeHandle channelArgs);
                /*0x1557e70*/ ChannelSafeHandle();
                /*0x1557f68*/ Grpc.Core.Internal.CallSafeHandle CreateCall(Grpc.Core.Internal.CallSafeHandle parentCall, Grpc.Core.Internal.ContextPropagationFlags propagationMask, Grpc.Core.Internal.CompletionQueueSafeHandle cq, string method, string host, Grpc.Core.Internal.Timespec deadline, Grpc.Core.Internal.CallCredentialsSafeHandle credentials);
                /*0x15572c0*/ Grpc.Core.ChannelState CheckConnectivityState(bool tryToConnect);
                /*0x1556e0c*/ void WatchConnectivityState(Grpc.Core.ChannelState lastObservedState, Grpc.Core.Internal.Timespec deadline, Grpc.Core.Internal.CompletionQueueSafeHandle cq, Grpc.Core.Internal.BatchCompletionDelegate callback, object callbackState);
                /*0x1558074*/ bool ReleaseHandle();
            }

            class ClientRequestStream<TRequest, TResponse> : Grpc.Core.IClientStreamWriter<TRequest>, Grpc.Core.IAsyncStreamWriter<TRequest>
            {
                /*0x0*/ Grpc.Core.Internal.AsyncCall<TRequest, TResponse> call;
                /*0x0*/ Grpc.Core.WriteOptions writeOptions;

                ClientRequestStream(Grpc.Core.Internal.AsyncCall<TRequest, TResponse> call);
                System.Threading.Tasks.Task WriteAsync(TRequest message);
                System.Threading.Tasks.Task CompleteAsync();
                Grpc.Core.WriteOptions get_WriteOptions();
                void set_WriteOptions(Grpc.Core.WriteOptions value);
                Grpc.Core.WriteFlags GetWriteFlags();
            }

            class ClientResponseStream<TRequest, TResponse> : Grpc.Core.IAsyncStreamReader<TResponse>
            {
                /*0x0*/ Grpc.Core.Internal.AsyncCall<TRequest, TResponse> call;
                /*0x0*/ TResponse current;

                ClientResponseStream(Grpc.Core.Internal.AsyncCall<TRequest, TResponse> call);
                TResponse get_Current();
                System.Threading.Tasks.Task<bool> MoveNext(System.Threading.CancellationToken token);

                struct <MoveNext>d__5<TRequest, TResponse> : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder;
                    /*0x0*/ Grpc.Core.Internal.ClientResponseStream<TRequest, TResponse> <>4__this;
                    /*0x0*/ System.Threading.CancellationToken token;
                    /*0x0*/ System.Threading.CancellationTokenRegistration <>7__wrap1;
                    /*0x0*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<TResponse> <>u__1;
                    /*0x0*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

                    void MoveNext();
                    void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            struct ClientSideStatus
            {
                /*0x10*/ Grpc.Core.Status status;
                /*0x28*/ Grpc.Core.Metadata trailers;

                /*0xaa515c*/ ClientSideStatus(Grpc.Core.Status status, Grpc.Core.Metadata trailers);
                /*0xaa5170*/ Grpc.Core.Status get_Status();
                /*0xaa5184*/ Grpc.Core.Metadata get_Trailers();
            }

            enum ClockType
            {
                Monotonic = 0,
                Realtime = 1,
                Precise = 2,
                Timespan = 3,
            }

            class CommonPlatformDetection
            {
                static /*0x155821c*/ Grpc.Core.Internal.CommonPlatformDetection.OSKind GetOSKind();
                static /*0x15584e4*/ Grpc.Core.Internal.CommonPlatformDetection.CpuArchitecture GetProcessArchitecture();
                static /*0x1558508*/ int uname(nint buf);
                static /*0x15582b0*/ string GetUname();

                enum OSKind
                {
                    Unknown = 0,
                    Windows = 1,
                    Linux = 2,
                    MacOSX = 3,
                }

                enum CpuArchitecture
                {
                    Unknown = 0,
                    X86 = 1,
                    X64 = 2,
                    Arm64 = 3,
                }
            }

            struct CompletionQueueEvent
            {
                static /*0x0*/ Grpc.Core.Internal.NativeMethods Native;
                /*0x10*/ Grpc.Core.Internal.CompletionQueueEvent.CompletionType type;
                /*0x14*/ int success;
                /*0x18*/ nint tag;

                static /*0x1558588*/ CompletionQueueEvent();

                enum CompletionType
                {
                    Shutdown = 0,
                    Timeout = 1,
                    OpComplete = 2,
                }
            }

            class CompletionQueueSafeHandle : Grpc.Core.Internal.SafeHandleZeroIsInvalid
            {
                static /*0x0*/ Grpc.Core.Internal.NativeMethods Native;
                /*0x20*/ Grpc.Core.Internal.AtomicCounter shutdownRefcount;
                /*0x28*/ Grpc.Core.Internal.CompletionRegistry completionRegistry;

                static /*0x1558988*/ CompletionQueueSafeHandle();
                static /*0x15585dc*/ Grpc.Core.Internal.CompletionQueueSafeHandle CreateAsync(Grpc.Core.Internal.CompletionRegistry completionRegistry);
                /*0x15585d8*/ CompletionQueueSafeHandle();
                /*0x15586a0*/ Grpc.Core.Internal.CompletionQueueEvent Next();
                /*0x15544e4*/ Grpc.Core.Internal.CompletionQueueSafeHandle.UsageScope NewScope();
                /*0x1558720*/ void Shutdown();
                /*0x15587c8*/ Grpc.Core.Internal.CompletionRegistry get_CompletionRegistry();
                /*0x15587d0*/ bool ReleaseHandle();
                /*0x1558724*/ void DecrementShutdownRefcount();
                /*0x1558858*/ void BeginOp();
                /*0x155891c*/ void EndOp();

                struct UsageScope : System.IDisposable
                {
                    /*0x10*/ Grpc.Core.Internal.CompletionQueueSafeHandle cq;

                    /*0xa85ac8*/ UsageScope(Grpc.Core.Internal.CompletionQueueSafeHandle cq);
                    /*0xa85ae8*/ void Dispose();
                }
            }

            class BatchCompletionDelegate : System.MulticastDelegate
            {
                /*0x15529cc*/ BatchCompletionDelegate(object object, nint method);
                /*0x1552a2c*/ void Invoke(bool success, Grpc.Core.Internal.BatchContextSafeHandle ctx, object state);
                /*0x1552c88*/ System.IAsyncResult BeginInvoke(bool success, Grpc.Core.Internal.BatchContextSafeHandle ctx, object state, System.AsyncCallback callback, object object);
                /*0x1552d28*/ void EndInvoke(System.IAsyncResult result);
            }

            class RequestCallCompletionDelegate : System.MulticastDelegate
            {
                /*0x156fe90*/ RequestCallCompletionDelegate(object object, nint method);
                /*0x156fef0*/ void Invoke(bool success, Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                /*0x1570130*/ System.IAsyncResult BeginInvoke(bool success, Grpc.Core.Internal.RequestCallContextSafeHandle ctx, System.AsyncCallback callback, object object);
                /*0x15701c8*/ void EndInvoke(System.IAsyncResult result);
            }

            class CompletionRegistry
            {
                static /*0x0*/ Grpc.Core.Logging.ILogger Logger;
                /*0x10*/ Grpc.Core.GrpcEnvironment environment;
                /*0x18*/ System.Func<Grpc.Core.Internal.BatchContextSafeHandle> batchContextFactory;
                /*0x20*/ System.Func<Grpc.Core.Internal.RequestCallContextSafeHandle> requestCallContextFactory;
                /*0x28*/ System.Collections.Generic.Dictionary<nint, Grpc.Core.Internal.IOpCompletionCallback> dict;
                /*0x30*/ System.Threading.SpinLock spinLock;
                /*0x38*/ nint lastRegisteredKey;

                static /*0x1558e14*/ CompletionRegistry();
                /*0x15589d8*/ CompletionRegistry(Grpc.Core.GrpcEnvironment environment, System.Func<Grpc.Core.Internal.BatchContextSafeHandle> batchContextFactory, System.Func<Grpc.Core.Internal.RequestCallContextSafeHandle> requestCallContextFactory);
                /*0x1558b60*/ void Register(nint key, Grpc.Core.Internal.IOpCompletionCallback callback);
                /*0x1554514*/ Grpc.Core.Internal.BatchContextSafeHandle RegisterBatchCompletion(Grpc.Core.Internal.BatchCompletionDelegate callback, object state);
                /*0x1558c9c*/ Grpc.Core.Internal.IOpCompletionCallback Extract(nint key);

                class IntPtrComparer : System.Collections.Generic.IEqualityComparer<nint>
                {
                    /*0xfc98c0*/ IntPtrComparer();
                    /*0xfc9888*/ bool Equals(nint x, nint y);
                    /*0xfc9898*/ int GetHashCode(nint obj);
                }
            }

            enum ContextPropagationFlags
            {
                Deadline = 1,
                CensusStatsContext = 2,
                CensusTracingContext = 4,
                Cancellation = 8,
            }

            class ContextPropagationTokenImpl : Grpc.Core.ContextPropagationToken
            {
                /*0x10*/ Grpc.Core.Internal.CallSafeHandle parentCall;
                /*0x18*/ System.DateTime deadline;
                /*0x20*/ System.Threading.CancellationToken cancellationToken;
                /*0x28*/ Grpc.Core.ContextPropagationOptions options;

                /*0x1559088*/ Grpc.Core.Internal.CallSafeHandle get_ParentCall();
                /*0x1559090*/ System.DateTime get_ParentDeadline();
                /*0x1559098*/ System.Threading.CancellationToken get_ParentCancellationToken();
                /*0x15590a0*/ Grpc.Core.ContextPropagationOptions get_Options();
            }

            class ContextPropagationTokenExtensions
            {
                static /*0x1554244*/ Grpc.Core.Internal.ContextPropagationTokenImpl AsImplOrNull(Grpc.Core.ContextPropagationToken instanceOrNull);
            }

            class CoreErrorDetailException : System.Exception
            {
                /*0x1553518*/ CoreErrorDetailException(string message);
            }

            class CStringSafeHandle : Grpc.Core.Internal.SafeHandleZeroIsInvalid
            {
                static /*0x0*/ Grpc.Core.Internal.NativeMethods Native;

                static /*0x1553ddc*/ CStringSafeHandle();
                /*0x1553d50*/ CStringSafeHandle();
                /*0x1553d54*/ bool ReleaseHandle();
            }

            class DebugStats
            {
                /*0x10*/ Grpc.Core.Internal.AtomicCounter PendingBatchCompletions;

                /*0x15591b8*/ DebugStats();
                /*0x15590a8*/ void CheckOK();
                /*0x1559154*/ void DebugWarning(string message);
            }

            class DefaultCallCredentialsConfigurator : Grpc.Core.CallCredentialsConfiguratorBase
            {
                /*0x10*/ Grpc.Core.Internal.CallCredentialsSafeHandle nativeCredentials;

                /*0x1553eac*/ DefaultCallCredentialsConfigurator();
                /*0x1559220*/ Grpc.Core.Internal.CallCredentialsSafeHandle get_NativeCredentials();
            }

            class CallCredentialsExtensions
            {
                static /*0x1553e2c*/ Grpc.Core.Internal.CallCredentialsSafeHandle ToNativeCredentials(Grpc.Core.CallCredentials credentials);
            }

            class DefaultChannelCredentialsConfigurator : Grpc.Core.ChannelCredentialsConfiguratorBase
            {
                static /*0x0*/ Grpc.Core.Logging.ILogger Logger;
                static /*0x8*/ System.Runtime.CompilerServices.ConditionalWeakTable<Grpc.Core.ChannelCredentials, System.Lazy<Grpc.Core.Internal.ChannelCredentialsSafeHandle>> CachedNativeCredentials;
                static /*0x10*/ object StaticLock;
                /*0x10*/ bool configured;
                /*0x18*/ Grpc.Core.Internal.ChannelCredentialsSafeHandle nativeCredentials;

                static /*0x15596dc*/ DefaultChannelCredentialsConfigurator();
                /*0x1557974*/ DefaultChannelCredentialsConfigurator();
                /*0x1559228*/ Grpc.Core.Internal.ChannelCredentialsSafeHandle get_NativeCredentials();
                /*0x1559230*/ void SetInsecureCredentials(object state);
                /*0x155926c*/ void SetSslCredentials(object state, string rootCertificates, Grpc.Core.KeyCertificatePair keyCertificatePair, Grpc.Core.VerifyPeerCallback verifyPeerCallback);
                /*0x15595fc*/ Grpc.Core.Internal.ChannelCredentialsSafeHandle CreateNativeSslCredentials(string rootCertificates, Grpc.Core.KeyCertificatePair keyCertificatePair, Grpc.Core.VerifyPeerCallback verifyPeerCallback);
                /*0x15593c4*/ Grpc.Core.Internal.ChannelCredentialsSafeHandle GetOrCreateNativeCredentials(Grpc.Core.ChannelCredentials key, System.Func<Grpc.Core.Internal.ChannelCredentialsSafeHandle> nativeCredentialsFactory);

                class VerifyPeerCallbackRegistration
                {
                    /*0x10*/ Grpc.Core.VerifyPeerCallback verifyPeerCallback;
                    /*0x18*/ Grpc.Core.Internal.NativeCallbackRegistration callbackRegistration;

                    /*0xfc99fc*/ VerifyPeerCallbackRegistration(Grpc.Core.VerifyPeerCallback verifyPeerCallback);
                    /*0xfc9ac4*/ Grpc.Core.Internal.NativeCallbackRegistration get_CallbackRegistration();
                    /*0xfc9acc*/ int HandleUniversalCallback(nint arg0, nint arg1, nint arg2, nint arg3, nint arg4, nint arg5);
                    /*0xfc9b44*/ int VerifyPeerCallbackHandler(nint targetName, nint peerPem, bool isDestroy);
                }

                class <>c__DisplayClass8_0
                {
                    /*0x10*/ Grpc.Core.Internal.DefaultChannelCredentialsConfigurator <>4__this;
                    /*0x18*/ string rootCertificates;
                    /*0x20*/ Grpc.Core.KeyCertificatePair keyCertificatePair;
                    /*0x28*/ Grpc.Core.VerifyPeerCallback verifyPeerCallback;

                    /*0xfc99cc*/ <>c__DisplayClass8_0();
                    /*0xfc99d4*/ Grpc.Core.Internal.ChannelCredentialsSafeHandle <SetSslCredentials>b__0();
                }
            }

            class ChannelCredentialsExtensions
            {
                static /*0x155642c*/ Grpc.Core.Internal.ChannelCredentialsSafeHandle ToNativeCredentials(Grpc.Core.ChannelCredentials credentials);
            }

            class DefaultDeserializationContext : Grpc.Core.DeserializationContext
            {
                static /*0x0*/ System.Threading.ThreadLocal<Grpc.Core.Internal.DefaultDeserializationContext> threadLocalInstance;
                /*0x10*/ Grpc.Core.Internal.IBufferReader bufferReader;
                /*0x18*/ int payloadLength;
                /*0x20*/ Grpc.Core.Internal.ReusableSliceBuffer cachedSliceBuffer;

                static /*0x155a0d0*/ DefaultDeserializationContext();
                static /*0x155a030*/ Grpc.Core.Internal.DefaultDeserializationContext GetInitializedThreadLocal(Grpc.Core.Internal.IBufferReader bufferReader);
                /*0x15598a8*/ DefaultDeserializationContext();
                /*0x1559990*/ byte[] PayloadAsNewBuffer();
                /*0x1559a6c*/ System.Buffers.ReadOnlySequence<byte> PayloadAsReadOnlySequence();
                /*0x1559df8*/ void Initialize(Grpc.Core.Internal.IBufferReader bufferReader);
                /*0x155996c*/ void Reset();

                class <>c
                {
                    static /*0x0*/ Grpc.Core.Internal.DefaultDeserializationContext.<> <>9;

                    static /*0xfc9db4*/ <>c();
                    /*0xfc9e14*/ <>c();
                    /*0xfc9e1c*/ Grpc.Core.Internal.DefaultDeserializationContext <.cctor>b__12_0();
                }
            }

            class DefaultObjectPool<T> : Grpc.Core.Internal.IObjectPool<T>, System.IDisposable
            {
                /*0x0*/ object myLock;
                /*0x0*/ System.Action<T> returnAction;
                /*0x0*/ System.Func<T> itemFactory;
                /*0x0*/ System.Collections.Generic.Queue<T> sharedQueue;
                /*0x0*/ int sharedCapacity;
                /*0x0*/ System.Threading.ThreadLocal<Grpc.Core.Internal.DefaultObjectPool.ThreadLocalData<T>> threadLocalData;
                /*0x0*/ int threadLocalCapacity;
                /*0x0*/ int rentLimit;
                /*0x0*/ bool disposed;

                DefaultObjectPool(System.Func<T> itemFactory, int sharedCapacity, int threadLocalCapacity);
                T Lease();
                T LeaseInternal();
                void Return(T item);
                void Dispose();

                class ThreadLocalData<T>
                {
                    /*0x0*/ System.Collections.Generic.Queue<T> <Queue>k__BackingField;
                    /*0x0*/ int <CreateBudget>k__BackingField;
                    /*0x0*/ int <DisposeBudget>k__BackingField;

                    ThreadLocalData(int capacity);
                    System.Collections.Generic.Queue<T> get_Queue();
                    int get_CreateBudget();
                    void set_CreateBudget(int value);
                    int get_DisposeBudget();
                    void set_DisposeBudget(int value);
                }

                class <>c__DisplayClass9_0<T>
                {
                    /*0x0*/ int threadLocalCapacity;

                    <>c__DisplayClass9_0();
                    Grpc.Core.Internal.DefaultObjectPool.ThreadLocalData<T> <.ctor>b__0();
                }
            }

            class DefaultSerializationContext : Grpc.Core.SerializationContext
            {
                static /*0x0*/ System.Threading.ThreadLocal<Grpc.Core.Internal.DefaultSerializationContext> threadLocalInstance;
                /*0x10*/ bool isComplete;
                /*0x18*/ Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer;

                static /*0x155a4dc*/ DefaultSerializationContext();
                static /*0x155a458*/ Grpc.Core.Internal.DefaultSerializationContext.UsageScope GetInitializedThreadLocalScope();
                /*0x155a1f0*/ DefaultSerializationContext();
                /*0x155a28c*/ void Complete(byte[] payload);
                /*0x155a3f4*/ Grpc.Core.Internal.SliceBufferSafeHandle GetPayload();
                /*0x155a268*/ void Reset();

                struct UsageScope : System.IDisposable
                {
                    /*0x10*/ Grpc.Core.Internal.DefaultSerializationContext context;

                    /*0xa85b40*/ UsageScope(Grpc.Core.Internal.DefaultSerializationContext context);
                    /*0xa85b48*/ Grpc.Core.Internal.DefaultSerializationContext get_Context();
                    /*0xa85b50*/ void Dispose();
                }

                class <>c
                {
                    static /*0x0*/ Grpc.Core.Internal.DefaultSerializationContext.<> <>9;

                    static /*0xfc9e74*/ <>c();
                    /*0xfc9ed4*/ <>c();
                    /*0xfc9edc*/ Grpc.Core.Internal.DefaultSerializationContext <.cctor>b__12_0();
                }
            }

            class DefaultSslRootsOverride
            {
                static /*0x0*/ object staticLock;

                static /*0x155a958*/ DefaultSslRootsOverride();
                static /*0x155a5fc*/ void Override(Grpc.Core.Internal.NativeMethods native);
            }

            class GrpcThreadPool
            {
                static /*0x0*/ Grpc.Core.Logging.ILogger Logger;
                /*0x10*/ Grpc.Core.GrpcEnvironment environment;
                /*0x18*/ object myLock;
                /*0x20*/ System.Collections.Generic.List<System.Threading.Thread> threads;
                /*0x28*/ int poolSize;
                /*0x2c*/ int completionQueueCount;
                /*0x30*/ bool inlineHandlers;
                /*0x38*/ System.Threading.WaitCallback runCompletionQueueEventCallbackSuccess;
                /*0x40*/ System.Threading.WaitCallback runCompletionQueueEventCallbackFailure;
                /*0x48*/ Grpc.Core.Internal.AtomicCounter queuedContinuationCounter;
                /*0x50*/ System.Collections.Generic.List<Grpc.Core.Profiling.BasicProfiler> threadProfilers;
                /*0x58*/ bool stopRequested;
                /*0x60*/ System.Collections.Generic.IReadOnlyCollection<Grpc.Core.Internal.CompletionQueueSafeHandle> completionQueues;

                static /*0x155d760*/ GrpcThreadPool();
                static /*0x155c750*/ System.Collections.Generic.IReadOnlyCollection<Grpc.Core.Internal.CompletionQueueSafeHandle> CreateCompletionQueueList(Grpc.Core.GrpcEnvironment environment, int completionQueueCount);
                /*0x155bce4*/ GrpcThreadPool(Grpc.Core.GrpcEnvironment environment, int poolSize, int completionQueueCount, bool inlineHandlers);
                /*0x155bed0*/ void Start();
                /*0x155cbdc*/ System.Threading.Tasks.Task StopAsync();
                /*0x155c12c*/ bool get_IsAlive();
                /*0x155cfbc*/ System.Collections.Generic.IReadOnlyCollection<Grpc.Core.Internal.CompletionQueueSafeHandle> get_CompletionQueues();
                /*0x155c9a4*/ System.Threading.Thread CreateAndStartThread(int threadIndex, Grpc.Core.Profiling.IProfiler optionalProfiler);
                /*0x155cfc4*/ void RunHandlerLoop(Grpc.Core.Internal.CompletionQueueSafeHandle cq, Grpc.Core.Profiling.IProfiler optionalProfiler);
                /*0x155d4a0*/ void RunCompletionQueueEventCallback(Grpc.Core.Internal.IOpCompletionCallback callback, bool success);
                /*0x155d8b0*/ void <.ctor>b__15_0(object callback);
                /*0x155d934*/ void <.ctor>b__15_1(object callback);
                /*0x155d9b8*/ void <StopAsync>b__17_0();

                class <>c
                {
                    static /*0x0*/ Grpc.Core.Internal.GrpcThreadPool.<> <>9;
                    static /*0x8*/ System.Func<System.Threading.Thread, bool> <>9__19_0;

                    static /*0xfcacec*/ <>c();
                    /*0xfcad4c*/ <>c();
                    /*0xfcad54*/ bool <get_IsAlive>b__19_0(System.Threading.Thread t);
                }

                class <>c__DisplayClass22_0
                {
                    /*0x10*/ Grpc.Core.Internal.GrpcThreadPool <>4__this;
                    /*0x18*/ Grpc.Core.Internal.CompletionQueueSafeHandle cq;
                    /*0x20*/ Grpc.Core.Profiling.IProfiler optionalProfiler;

                    /*0xfcad80*/ <>c__DisplayClass22_0();
                    /*0xfcad88*/ void <CreateAndStartThread>b__0();
                }

                class <>c__DisplayClass24_0
                {
                    /*0x10*/ Grpc.Core.GrpcEnvironment environment;
                    /*0x18*/ System.Func<Grpc.Core.Internal.BatchContextSafeHandle> <>9__0;
                    /*0x20*/ System.Func<Grpc.Core.Internal.RequestCallContextSafeHandle> <>9__1;

                    /*0xfcadac*/ <>c__DisplayClass24_0();
                    /*0xfcadb4*/ Grpc.Core.Internal.BatchContextSafeHandle <CreateCompletionQueueList>b__0();
                    /*0xfcae68*/ Grpc.Core.Internal.RequestCallContextSafeHandle <CreateCompletionQueueList>b__1();
                }
            }

            interface IUnaryResponseClientCallback
            {
                void OnUnaryResponseClient(bool success, Grpc.Core.Internal.ClientSideStatus receivedStatus, Grpc.Core.Internal.IBufferReader receivedMessageReader, Grpc.Core.Metadata responseHeaders);
            }

            interface IReceivedStatusOnClientCallback
            {
                void OnReceivedStatusOnClient(bool success, Grpc.Core.Internal.ClientSideStatus receivedStatus);
            }

            interface IReceivedMessageCallback
            {
                void OnReceivedMessage(bool success, Grpc.Core.Internal.IBufferReader receivedMessageReader);
            }

            interface IReceivedResponseHeadersCallback
            {
                void OnReceivedResponseHeaders(bool success, Grpc.Core.Metadata responseHeaders);
            }

            interface ISendCompletionCallback
            {
                void OnSendCompletion(bool success);
            }

            interface ISendStatusFromServerCompletionCallback
            {
                void OnSendStatusFromServerCompletion(bool success);
            }

            interface IReceivedCloseOnServerCallback
            {
                void OnReceivedCloseOnServer(bool success, bool cancelled);
            }

            interface INativeCall : System.IDisposable
            {
                void Cancel();
                void CancelWithStatus(Grpc.Core.Status status);
                void StartUnary(Grpc.Core.Internal.IUnaryResponseClientCallback callback, Grpc.Core.Internal.SliceBufferSafeHandle payload, Grpc.Core.WriteFlags writeFlags, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags callFlags);
                void StartClientStreaming(Grpc.Core.Internal.IUnaryResponseClientCallback callback, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags callFlags);
                void StartServerStreaming(Grpc.Core.Internal.IReceivedStatusOnClientCallback callback, Grpc.Core.Internal.SliceBufferSafeHandle payload, Grpc.Core.WriteFlags writeFlags, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags callFlags);
                void StartDuplexStreaming(Grpc.Core.Internal.IReceivedStatusOnClientCallback callback, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags callFlags);
                void StartReceiveMessage(Grpc.Core.Internal.IReceivedMessageCallback callback);
                void StartReceiveInitialMetadata(Grpc.Core.Internal.IReceivedResponseHeadersCallback callback);
                void StartSendMessage(Grpc.Core.Internal.ISendCompletionCallback callback, Grpc.Core.Internal.SliceBufferSafeHandle payload, Grpc.Core.WriteFlags writeFlags, bool sendEmptyInitialMetadata);
                void StartSendCloseFromClient(Grpc.Core.Internal.ISendCompletionCallback callback);
            }

            interface IObjectPool<T> : System.IDisposable
            {
                T Lease();
            }

            interface IPooledObject<T> : System.IDisposable
            {
                void SetReturnToPoolAction(System.Action<T> returnAction);
            }

            class MarshalUtils
            {
                static /*0x0*/ System.Text.Encoding EncodingUTF8;

                static /*0x155e5a8*/ MarshalUtils();
                static /*0x155e4e0*/ string PtrToStringUTF8(nint ptr, int len);
            }

            class MetadataArraySafeHandle : Grpc.Core.Internal.SafeHandleZeroIsInvalid
            {
                static /*0x0*/ Grpc.Core.Internal.NativeMethods Native;

                static /*0x155e84c*/ MetadataArraySafeHandle();
                static /*0x155e600*/ Grpc.Core.Internal.MetadataArraySafeHandle Create(Grpc.Core.Metadata metadata);
                static /*0x1552f60*/ Grpc.Core.Metadata ReadMetadataFromPtrUnsafe(nint metadataArray);
                /*0x155e5fc*/ MetadataArraySafeHandle();
                /*0x155e7c4*/ bool ReleaseHandle();
            }

            class MonoPInvokeCallbackAttribute : System.Attribute
            {
                /*0x10*/ System.Type <Type>k__BackingField;

                /*0x155e89c*/ MonoPInvokeCallbackAttribute(System.Type type);
                /*0x155e8c8*/ void set_Type(System.Type value);
            }

            class UniversalNativeCallback : System.MulticastDelegate
            {
                /*0xfc6630*/ UniversalNativeCallback(object object, nint method);
                /*0xfc6690*/ int Invoke(nint arg0, nint arg1, nint arg2, nint arg3, nint arg4, nint arg5);
                /*0xfc6920*/ System.IAsyncResult BeginInvoke(nint arg0, nint arg1, nint arg2, nint arg3, nint arg4, nint arg5, System.AsyncCallback callback, object object);
                /*0xfc6a14*/ int EndInvoke(System.IAsyncResult result);
            }

            class NativeCallbackDispatcherCallback : System.MulticastDelegate
            {
                /*0x155ebf4*/ NativeCallbackDispatcherCallback(object object, nint method);
                /*0x155ee44*/ int Invoke(nint tag, nint arg0, nint arg1, nint arg2, nint arg3, nint arg4, nint arg5);
                /*0x155f0e8*/ System.IAsyncResult BeginInvoke(nint tag, nint arg0, nint arg1, nint arg2, nint arg3, nint arg4, nint arg5, System.AsyncCallback callback, object object);
                /*0x155f1f0*/ int EndInvoke(System.IAsyncResult result);
            }

            class NativeCallbackDispatcher
            {
                static /*0x0*/ Grpc.Core.Logging.ILogger Logger;
                static /*0x8*/ Grpc.Core.Internal.NativeCallbackDispatcherCallback dispatcherCallback;

                static /*0x155ecf4*/ NativeCallbackDispatcher();
                static /*0x155eb0c*/ void Init(Grpc.Core.Internal.NativeMethods native);
                static /*0x155ec54*/ Grpc.Core.Internal.NativeCallbackRegistration RegisterCallback(Grpc.Core.Internal.UniversalNativeCallback callback);
                static /*0x155e8d0*/ int HandleDispatcherCallback(nint tag, nint arg0, nint arg1, nint arg2, nint arg3, nint arg4, nint arg5);
            }

            class NativeCallbackRegistration : System.IDisposable
            {
                /*0x10*/ System.Runtime.InteropServices.GCHandle handle;

                /*0x155ecc8*/ NativeCallbackRegistration(System.Runtime.InteropServices.GCHandle handle);
                /*0x15596d0*/ nint get_Tag();
                /*0x155f21c*/ void Dispose();
            }

            class NativeExtension
            {
                static /*0x0*/ Grpc.Core.Logging.ILogger Logger;
                static /*0x8*/ object staticLock;
                static /*0x10*/ Grpc.Core.Internal.NativeExtension instance;
                /*0x10*/ Grpc.Core.Internal.NativeMethods nativeMethods;

                static /*0x156ea54*/ NativeExtension();
                static /*0x155fb98*/ Grpc.Core.Internal.NativeExtension Get();
                static /*0x155fd6c*/ Grpc.Core.Internal.NativeMethods LoadNativeMethodsUsingExplicitLoad();
                static /*0x1561478*/ Grpc.Core.Internal.NativeMethods LoadNativeMethodsUsingDllImports();
                static /*0x155f74c*/ Grpc.Core.Internal.NativeMethods LoadNativeMethods();
                static /*0x156ab34*/ Grpc.Core.Internal.NativeMethods LoadNativeMethodsUnity();
                static /*0x156ac20*/ Grpc.Core.Internal.NativeMethods LoadNativeMethodsXamarin();
                static /*0x155ffb4*/ string GetAssemblyDirectory();
                static /*0x156ad4c*/ bool IsNet5SingleFileApp();
                static /*0x156e924*/ bool IsFileUri(string uri);
                static /*0x1560360*/ string GetRuntimeIdString();
                static /*0x156e9b4*/ string GetArchitectureString();
                static /*0x1560130*/ string GetNativeLibraryFilename();
                /*0x155f588*/ NativeExtension();
                /*0x155fd64*/ Grpc.Core.Internal.NativeMethods get_NativeMethods();
            }

            class GprLogDelegate : System.MulticastDelegate
            {
                /*0x155a9cc*/ GprLogDelegate(object object, nint method);
                /*0x155aa2c*/ void Invoke(nint fileStringPtr, int line, ulong threadId, nint severityStringPtr, nint msgPtr);
                /*0x155acb0*/ System.IAsyncResult BeginInvoke(nint fileStringPtr, int line, ulong threadId, nint severityStringPtr, nint msgPtr, System.AsyncCallback callback, object object);
                /*0x155adbc*/ void EndInvoke(System.IAsyncResult result);
            }

            class NativeLogRedirector
            {
                static /*0x0*/ object staticLock;
                static /*0x8*/ Grpc.Core.Internal.GprLogDelegate writeCallback;

                static /*0x156f230*/ NativeLogRedirector();
                static /*0x155f9d0*/ void Redirect(Grpc.Core.Internal.NativeMethods native);
                static /*0x156ebd8*/ void HandleWrite(nint fileStringPtr, int line, ulong threadId, nint severityStringPtr, nint msgPtr);
            }

            class NativeCallbackTestDelegate : System.MulticastDelegate
            {
                /*0x155f264*/ NativeCallbackTestDelegate(object object, nint method);
                /*0x155f2c4*/ void Invoke(bool success);
                /*0x155f4f0*/ System.IAsyncResult BeginInvoke(bool success, System.AsyncCallback callback, object object);
                /*0x155f57c*/ void EndInvoke(System.IAsyncResult result);
            }

            class NativeMethods
            {
                /*0x10*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_init_delegate grpcsharp_init;
                /*0x18*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_shutdown_delegate grpcsharp_shutdown;
                /*0x20*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_version_string_delegate grpcsharp_version_string;
                /*0x28*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_batch_context_create_delegate grpcsharp_batch_context_create;
                /*0x30*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_batch_context_recv_initial_metadata_delegate grpcsharp_batch_context_recv_initial_metadata;
                /*0x38*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_batch_context_recv_message_length_delegate grpcsharp_batch_context_recv_message_length;
                /*0x40*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_batch_context_recv_message_next_slice_peek_delegate grpcsharp_batch_context_recv_message_next_slice_peek;
                /*0x48*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_batch_context_recv_status_on_client_status_delegate grpcsharp_batch_context_recv_status_on_client_status;
                /*0x50*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_batch_context_recv_status_on_client_details_delegate grpcsharp_batch_context_recv_status_on_client_details;
                /*0x58*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_batch_context_recv_status_on_client_error_string_delegate grpcsharp_batch_context_recv_status_on_client_error_string;
                /*0x60*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_batch_context_recv_status_on_client_trailing_metadata_delegate grpcsharp_batch_context_recv_status_on_client_trailing_metadata;
                /*0x68*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_batch_context_recv_close_on_server_cancelled_delegate grpcsharp_batch_context_recv_close_on_server_cancelled;
                /*0x70*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_batch_context_reset_delegate grpcsharp_batch_context_reset;
                /*0x78*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_batch_context_destroy_delegate grpcsharp_batch_context_destroy;
                /*0x80*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_request_call_context_create_delegate grpcsharp_request_call_context_create;
                /*0x88*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_request_call_context_call_delegate grpcsharp_request_call_context_call;
                /*0x90*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_request_call_context_method_delegate grpcsharp_request_call_context_method;
                /*0x98*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_request_call_context_host_delegate grpcsharp_request_call_context_host;
                /*0xa0*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_request_call_context_deadline_delegate grpcsharp_request_call_context_deadline;
                /*0xa8*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_request_call_context_request_metadata_delegate grpcsharp_request_call_context_request_metadata;
                /*0xb0*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_request_call_context_reset_delegate grpcsharp_request_call_context_reset;
                /*0xb8*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_request_call_context_destroy_delegate grpcsharp_request_call_context_destroy;
                /*0xc0*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_composite_call_credentials_create_delegate grpcsharp_composite_call_credentials_create;
                /*0xc8*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_call_credentials_release_delegate grpcsharp_call_credentials_release;
                /*0xd0*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_call_cancel_delegate grpcsharp_call_cancel;
                /*0xd8*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_call_cancel_with_status_delegate grpcsharp_call_cancel_with_status;
                /*0xe0*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_call_start_unary_delegate grpcsharp_call_start_unary;
                /*0xe8*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_call_start_client_streaming_delegate grpcsharp_call_start_client_streaming;
                /*0xf0*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_call_start_server_streaming_delegate grpcsharp_call_start_server_streaming;
                /*0xf8*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_call_start_duplex_streaming_delegate grpcsharp_call_start_duplex_streaming;
                /*0x100*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_call_send_message_delegate grpcsharp_call_send_message;
                /*0x108*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_call_send_close_from_client_delegate grpcsharp_call_send_close_from_client;
                /*0x110*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_call_send_status_from_server_delegate grpcsharp_call_send_status_from_server;
                /*0x118*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_call_recv_message_delegate grpcsharp_call_recv_message;
                /*0x120*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_call_recv_initial_metadata_delegate grpcsharp_call_recv_initial_metadata;
                /*0x128*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_call_start_serverside_delegate grpcsharp_call_start_serverside;
                /*0x130*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_call_send_initial_metadata_delegate grpcsharp_call_send_initial_metadata;
                /*0x138*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_call_set_credentials_delegate grpcsharp_call_set_credentials;
                /*0x140*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_call_get_peer_delegate grpcsharp_call_get_peer;
                /*0x148*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_call_destroy_delegate grpcsharp_call_destroy;
                /*0x150*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_channel_args_create_delegate grpcsharp_channel_args_create;
                /*0x158*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_channel_args_set_string_delegate grpcsharp_channel_args_set_string;
                /*0x160*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_channel_args_set_integer_delegate grpcsharp_channel_args_set_integer;
                /*0x168*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_channel_args_destroy_delegate grpcsharp_channel_args_destroy;
                /*0x170*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_override_default_ssl_roots_delegate grpcsharp_override_default_ssl_roots;
                /*0x178*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_ssl_credentials_create_delegate grpcsharp_ssl_credentials_create;
                /*0x180*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_composite_channel_credentials_create_delegate grpcsharp_composite_channel_credentials_create;
                /*0x188*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_channel_credentials_release_delegate grpcsharp_channel_credentials_release;
                /*0x190*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_insecure_channel_create_delegate grpcsharp_insecure_channel_create;
                /*0x198*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_secure_channel_create_delegate grpcsharp_secure_channel_create;
                /*0x1a0*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_channel_create_call_delegate grpcsharp_channel_create_call;
                /*0x1a8*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_channel_check_connectivity_state_delegate grpcsharp_channel_check_connectivity_state;
                /*0x1b0*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_channel_watch_connectivity_state_delegate grpcsharp_channel_watch_connectivity_state;
                /*0x1b8*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_channel_get_target_delegate grpcsharp_channel_get_target;
                /*0x1c0*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_channel_destroy_delegate grpcsharp_channel_destroy;
                /*0x1c8*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_sizeof_grpc_event_delegate grpcsharp_sizeof_grpc_event;
                /*0x1d0*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_completion_queue_create_async_delegate grpcsharp_completion_queue_create_async;
                /*0x1d8*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_completion_queue_create_sync_delegate grpcsharp_completion_queue_create_sync;
                /*0x1e0*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_completion_queue_shutdown_delegate grpcsharp_completion_queue_shutdown;
                /*0x1e8*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_completion_queue_next_delegate grpcsharp_completion_queue_next;
                /*0x1f0*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_completion_queue_pluck_delegate grpcsharp_completion_queue_pluck;
                /*0x1f8*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_completion_queue_destroy_delegate grpcsharp_completion_queue_destroy;
                /*0x200*/ Grpc.Core.Internal.NativeMethods.Delegates.gprsharp_free_delegate gprsharp_free;
                /*0x208*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_metadata_array_create_delegate grpcsharp_metadata_array_create;
                /*0x210*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_metadata_array_add_delegate grpcsharp_metadata_array_add;
                /*0x218*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_metadata_array_count_delegate grpcsharp_metadata_array_count;
                /*0x220*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_metadata_array_get_key_delegate grpcsharp_metadata_array_get_key;
                /*0x228*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_metadata_array_get_value_delegate grpcsharp_metadata_array_get_value;
                /*0x230*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_metadata_array_destroy_full_delegate grpcsharp_metadata_array_destroy_full;
                /*0x238*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_redirect_log_delegate grpcsharp_redirect_log;
                /*0x240*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_native_callback_dispatcher_init_delegate grpcsharp_native_callback_dispatcher_init;
                /*0x248*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_metadata_credentials_create_from_plugin_delegate grpcsharp_metadata_credentials_create_from_plugin;
                /*0x250*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_metadata_credentials_notify_from_plugin_delegate grpcsharp_metadata_credentials_notify_from_plugin;
                /*0x258*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_ssl_server_credentials_create_delegate grpcsharp_ssl_server_credentials_create;
                /*0x260*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_server_credentials_release_delegate grpcsharp_server_credentials_release;
                /*0x268*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_server_create_delegate grpcsharp_server_create;
                /*0x270*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_server_register_completion_queue_delegate grpcsharp_server_register_completion_queue;
                /*0x278*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_server_add_insecure_http2_port_delegate grpcsharp_server_add_insecure_http2_port;
                /*0x280*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_server_add_secure_http2_port_delegate grpcsharp_server_add_secure_http2_port;
                /*0x288*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_server_start_delegate grpcsharp_server_start;
                /*0x290*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_server_request_call_delegate grpcsharp_server_request_call;
                /*0x298*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_server_cancel_all_calls_delegate grpcsharp_server_cancel_all_calls;
                /*0x2a0*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_server_shutdown_and_notify_callback_delegate grpcsharp_server_shutdown_and_notify_callback;
                /*0x2a8*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_server_destroy_delegate grpcsharp_server_destroy;
                /*0x2b0*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_call_auth_context_delegate grpcsharp_call_auth_context;
                /*0x2b8*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_auth_context_peer_identity_property_name_delegate grpcsharp_auth_context_peer_identity_property_name;
                /*0x2c0*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_auth_context_property_iterator_delegate grpcsharp_auth_context_property_iterator;
                /*0x2c8*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_auth_property_iterator_next_delegate grpcsharp_auth_property_iterator_next;
                /*0x2d0*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_auth_context_release_delegate grpcsharp_auth_context_release;
                /*0x2d8*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_slice_buffer_create_delegate grpcsharp_slice_buffer_create;
                /*0x2e0*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_slice_buffer_adjust_tail_space_delegate grpcsharp_slice_buffer_adjust_tail_space;
                /*0x2e8*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_slice_buffer_slice_count_delegate grpcsharp_slice_buffer_slice_count;
                /*0x2f0*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_slice_buffer_slice_peek_delegate grpcsharp_slice_buffer_slice_peek;
                /*0x2f8*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_slice_buffer_reset_and_unref_delegate grpcsharp_slice_buffer_reset_and_unref;
                /*0x300*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_slice_buffer_destroy_delegate grpcsharp_slice_buffer_destroy;
                /*0x308*/ Grpc.Core.Internal.NativeMethods.Delegates.gprsharp_now_delegate gprsharp_now;
                /*0x310*/ Grpc.Core.Internal.NativeMethods.Delegates.gprsharp_inf_future_delegate gprsharp_inf_future;
                /*0x318*/ Grpc.Core.Internal.NativeMethods.Delegates.gprsharp_inf_past_delegate gprsharp_inf_past;
                /*0x320*/ Grpc.Core.Internal.NativeMethods.Delegates.gprsharp_convert_clock_type_delegate gprsharp_convert_clock_type;
                /*0x328*/ Grpc.Core.Internal.NativeMethods.Delegates.gprsharp_sizeof_timespec_delegate gprsharp_sizeof_timespec;
                /*0x330*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_test_callback_delegate grpcsharp_test_callback;
                /*0x338*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_test_nop_delegate grpcsharp_test_nop;
                /*0x340*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_test_override_method_delegate grpcsharp_test_override_method;
                /*0x348*/ Grpc.Core.Internal.NativeMethods.Delegates.grpcsharp_test_call_start_unary_echo_delegate grpcsharp_test_call_start_unary_echo;

                static /*0x15525c4*/ Grpc.Core.Internal.NativeMethods Get();
                static T GetMethodDelegate<T>(Grpc.Core.Internal.UnmanagedLibrary library);
                static /*0x156f2a4*/ string RemoveStringSuffix(string str, string toRemove);
                /*0x1560590*/ NativeMethods(Grpc.Core.Internal.UnmanagedLibrary library);
                /*0x156ae2c*/ NativeMethods(Grpc.Core.Internal.NativeMethods.DllImportsFromStaticLib unusedInstance);
                /*0x156cba8*/ NativeMethods(Grpc.Core.Internal.NativeMethods.DllImportsFromSharedLib unusedInstance);
                /*0x1566fd0*/ NativeMethods(Grpc.Core.Internal.NativeMethods.DllImportsFromSharedLib_x86 unusedInstance);
                /*0x15634d8*/ NativeMethods(Grpc.Core.Internal.NativeMethods.DllImportsFromSharedLib_x64 unusedInstance);
                /*0x1568d4c*/ NativeMethods(Grpc.Core.Internal.NativeMethods.DllImportsFromSharedLib_arm64 unusedInstance);
                /*0x1565254*/ NativeMethods(Grpc.Core.Internal.NativeMethods.DllImportsFromSharedLib_x86_dll unusedInstance);
                /*0x156175c*/ NativeMethods(Grpc.Core.Internal.NativeMethods.DllImportsFromSharedLib_x64_dll unusedInstance);

                class Delegates
                {
                    class grpcsharp_init_delegate : System.MulticastDelegate
                    {
                        /*0x10002e8*/ grpcsharp_init_delegate(object object, nint method);
                        /*0x1000348*/ void Invoke();
                        /*0x1000554*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                        /*0x1000580*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_shutdown_delegate : System.MulticastDelegate
                    {
                        /*0x10073d0*/ grpcsharp_shutdown_delegate(object object, nint method);
                        /*0x1007430*/ void Invoke();
                        /*0x100763c*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                        /*0x1007668*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_version_string_delegate : System.MulticastDelegate
                    {
                        /*0x100a160*/ grpcsharp_version_string_delegate(object object, nint method);
                        /*0x100a1c0*/ nint Invoke();
                        /*0x100a3d4*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                        /*0x100a400*/ nint EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_batch_context_create_delegate : System.MulticastDelegate
                    {
                        /*0xff3b84*/ grpcsharp_batch_context_create_delegate(object object, nint method);
                        /*0xff3be4*/ Grpc.Core.Internal.BatchContextSafeHandle Invoke();
                        /*0xff3df8*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                        /*0xff3e24*/ Grpc.Core.Internal.BatchContextSafeHandle EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_batch_context_recv_initial_metadata_delegate : System.MulticastDelegate
                    {
                        /*0xff4580*/ grpcsharp_batch_context_recv_initial_metadata_delegate(object object, nint method);
                        /*0xff45e0*/ nint Invoke(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                        /*0xff4960*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.BatchContextSafeHandle ctx, System.AsyncCallback callback, object object);
                        /*0xff4984*/ nint EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_batch_context_recv_message_length_delegate : System.MulticastDelegate
                    {
                        /*0xff49b0*/ grpcsharp_batch_context_recv_message_length_delegate(object object, nint method);
                        /*0xff4a10*/ nint Invoke(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                        /*0xff4d90*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.BatchContextSafeHandle ctx, System.AsyncCallback callback, object object);
                        /*0xff4db4*/ nint EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_batch_context_recv_message_next_slice_peek_delegate : System.MulticastDelegate
                    {
                        /*0xff4de0*/ grpcsharp_batch_context_recv_message_next_slice_peek_delegate(object object, nint method);
                        /*0xff4e40*/ int Invoke(Grpc.Core.Internal.BatchContextSafeHandle ctx, ref nuint sliceLen, ref nint sliceDataPtr);
                        /*0xff5200*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.BatchContextSafeHandle ctx, ref nuint sliceLen, ref nint sliceDataPtr, System.AsyncCallback callback, object object);
                        /*0xff52cc*/ int EndInvoke(ref nuint sliceLen, ref nint sliceDataPtr, System.IAsyncResult result);
                    }

                    class grpcsharp_batch_context_recv_status_on_client_status_delegate : System.MulticastDelegate
                    {
                        /*0xff5c00*/ grpcsharp_batch_context_recv_status_on_client_status_delegate(object object, nint method);
                        /*0xff5c60*/ Grpc.Core.StatusCode Invoke(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                        /*0xff5fe0*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.BatchContextSafeHandle ctx, System.AsyncCallback callback, object object);
                        /*0xff6004*/ Grpc.Core.StatusCode EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_batch_context_recv_status_on_client_details_delegate : System.MulticastDelegate
                    {
                        /*0xff5304*/ grpcsharp_batch_context_recv_status_on_client_details_delegate(object object, nint method);
                        /*0xff5364*/ nint Invoke(Grpc.Core.Internal.BatchContextSafeHandle ctx, ref nuint detailsLength);
                        /*0xff5700*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.BatchContextSafeHandle ctx, ref nuint detailsLength, System.AsyncCallback callback, object object);
                        /*0xff5798*/ nint EndInvoke(ref nuint detailsLength, System.IAsyncResult result);
                    }

                    class grpcsharp_batch_context_recv_status_on_client_error_string_delegate : System.MulticastDelegate
                    {
                        /*0xff57d0*/ grpcsharp_batch_context_recv_status_on_client_error_string_delegate(object object, nint method);
                        /*0xff5830*/ nint Invoke(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                        /*0xff5bb0*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.BatchContextSafeHandle ctx, System.AsyncCallback callback, object object);
                        /*0xff5bd4*/ nint EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_batch_context_recv_status_on_client_trailing_metadata_delegate : System.MulticastDelegate
                    {
                        /*0xff6030*/ grpcsharp_batch_context_recv_status_on_client_trailing_metadata_delegate(object object, nint method);
                        /*0xff6090*/ nint Invoke(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                        /*0xff6410*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.BatchContextSafeHandle ctx, System.AsyncCallback callback, object object);
                        /*0xff6434*/ nint EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_batch_context_recv_close_on_server_cancelled_delegate : System.MulticastDelegate
                    {
                        /*0xff4150*/ grpcsharp_batch_context_recv_close_on_server_cancelled_delegate(object object, nint method);
                        /*0xff41b0*/ int Invoke(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                        /*0xff4530*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.BatchContextSafeHandle ctx, System.AsyncCallback callback, object object);
                        /*0xff4554*/ int EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_batch_context_reset_delegate : System.MulticastDelegate
                    {
                        /*0xff6460*/ grpcsharp_batch_context_reset_delegate(object object, nint method);
                        /*0xff64c0*/ void Invoke(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                        /*0xff6838*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.BatchContextSafeHandle ctx, System.AsyncCallback callback, object object);
                        /*0xff685c*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_batch_context_destroy_delegate : System.MulticastDelegate
                    {
                        /*0xff3e30*/ grpcsharp_batch_context_destroy_delegate(object object, nint method);
                        /*0xff3e90*/ void Invoke(nint ctx);
                        /*0xff40bc*/ System.IAsyncResult BeginInvoke(nint ctx, System.AsyncCallback callback, object object);
                        /*0xff4144*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_request_call_context_create_delegate : System.MulticastDelegate
                    {
                        /*0x10036f4*/ grpcsharp_request_call_context_create_delegate(object object, nint method);
                        /*0x1003754*/ Grpc.Core.Internal.RequestCallContextSafeHandle Invoke();
                        /*0x1003968*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                        /*0x1003994*/ Grpc.Core.Internal.RequestCallContextSafeHandle EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_request_call_context_call_delegate : System.MulticastDelegate
                    {
                        /*0x10032e4*/ grpcsharp_request_call_context_call_delegate(object object, nint method);
                        /*0x1003344*/ Grpc.Core.Internal.CallSafeHandle Invoke(Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                        /*0x10036c4*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.RequestCallContextSafeHandle ctx, System.AsyncCallback callback, object object);
                        /*0x10036e8*/ Grpc.Core.Internal.CallSafeHandle EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_request_call_context_method_delegate : System.MulticastDelegate
                    {
                        /*0x10045c4*/ grpcsharp_request_call_context_method_delegate(object object, nint method);
                        /*0x1004624*/ nint Invoke(Grpc.Core.Internal.RequestCallContextSafeHandle ctx, ref nuint methodLength);
                        /*0x10049c0*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.RequestCallContextSafeHandle ctx, ref nuint methodLength, System.AsyncCallback callback, object object);
                        /*0x1004a58*/ nint EndInvoke(ref nuint methodLength, System.IAsyncResult result);
                    }

                    class grpcsharp_request_call_context_host_delegate : System.MulticastDelegate
                    {
                        /*0x10040f8*/ grpcsharp_request_call_context_host_delegate(object object, nint method);
                        /*0x1004158*/ nint Invoke(Grpc.Core.Internal.RequestCallContextSafeHandle ctx, ref nuint hostLength);
                        /*0x10044f4*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.RequestCallContextSafeHandle ctx, ref nuint hostLength, System.AsyncCallback callback, object object);
                        /*0x100458c*/ nint EndInvoke(ref nuint hostLength, System.IAsyncResult result);
                    }

                    class grpcsharp_request_call_context_deadline_delegate : System.MulticastDelegate
                    {
                        /*0x10039a0*/ grpcsharp_request_call_context_deadline_delegate(object object, nint method);
                        /*0x1003a00*/ Grpc.Core.Internal.Timespec Invoke(Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                        /*0x1003d84*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.RequestCallContextSafeHandle ctx, System.AsyncCallback callback, object object);
                        /*0x1003da8*/ Grpc.Core.Internal.Timespec EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_request_call_context_request_metadata_delegate : System.MulticastDelegate
                    {
                        /*0x1004a90*/ grpcsharp_request_call_context_request_metadata_delegate(object object, nint method);
                        /*0x1004af0*/ nint Invoke(Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                        /*0x1004e70*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.RequestCallContextSafeHandle ctx, System.AsyncCallback callback, object object);
                        /*0x1004e94*/ nint EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_request_call_context_reset_delegate : System.MulticastDelegate
                    {
                        /*0x1004ec0*/ grpcsharp_request_call_context_reset_delegate(object object, nint method);
                        /*0x1004f20*/ void Invoke(Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                        /*0x1005298*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.RequestCallContextSafeHandle ctx, System.AsyncCallback callback, object object);
                        /*0x10052bc*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_request_call_context_destroy_delegate : System.MulticastDelegate
                    {
                        /*0x1003dd8*/ grpcsharp_request_call_context_destroy_delegate(object object, nint method);
                        /*0x1003e38*/ void Invoke(nint ctx);
                        /*0x1004064*/ System.IAsyncResult BeginInvoke(nint ctx, System.AsyncCallback callback, object object);
                        /*0x10040ec*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_composite_call_credentials_create_delegate : System.MulticastDelegate
                    {
                        /*0xfffa78*/ grpcsharp_composite_call_credentials_create_delegate(object object, nint method);
                        /*0xfffad8*/ Grpc.Core.Internal.CallCredentialsSafeHandle Invoke(Grpc.Core.Internal.CallCredentialsSafeHandle creds1, Grpc.Core.Internal.CallCredentialsSafeHandle creds2);
                        /*0xfffe74*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.CallCredentialsSafeHandle creds1, Grpc.Core.Internal.CallCredentialsSafeHandle creds2, System.AsyncCallback callback, object object);
                        /*0xfffea4*/ Grpc.Core.Internal.CallCredentialsSafeHandle EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_call_credentials_release_delegate : System.MulticastDelegate
                    {
                        /*0xff7590*/ grpcsharp_call_credentials_release_delegate(object object, nint method);
                        /*0xff75f0*/ void Invoke(nint credentials);
                        /*0xff781c*/ System.IAsyncResult BeginInvoke(nint credentials, System.AsyncCallback callback, object object);
                        /*0xff78a4*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_call_cancel_delegate : System.MulticastDelegate
                    {
                        /*0xff6c78*/ grpcsharp_call_cancel_delegate(object object, nint method);
                        /*0xff6cd8*/ Grpc.Core.Internal.CallError Invoke(Grpc.Core.Internal.CallSafeHandle call);
                        /*0xff7058*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.CallSafeHandle call, System.AsyncCallback callback, object object);
                        /*0xff707c*/ Grpc.Core.Internal.CallError EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_call_cancel_with_status_delegate : System.MulticastDelegate
                    {
                        /*0xff70a8*/ grpcsharp_call_cancel_with_status_delegate(object object, nint method);
                        /*0xff7108*/ Grpc.Core.Internal.CallError Invoke(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.StatusCode status, string description);
                        /*0xff74c8*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.StatusCode status, string description, System.AsyncCallback callback, object object);
                        /*0xff7564*/ Grpc.Core.Internal.CallError EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_call_start_unary_delegate : System.MulticastDelegate
                    {
                        /*0xffb568*/ grpcsharp_call_start_unary_delegate(object object, nint method);
                        /*0xffb5c8*/ Grpc.Core.Internal.CallError Invoke(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                        /*0xffb9e0*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags, System.AsyncCallback callback, object object);
                        /*0xffbab8*/ Grpc.Core.Internal.CallError EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_call_start_client_streaming_delegate : System.MulticastDelegate
                    {
                        /*0xffa164*/ grpcsharp_call_start_client_streaming_delegate(object object, nint method);
                        /*0xffa1c4*/ Grpc.Core.Internal.CallError Invoke(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                        /*0xffa5a4*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags, System.AsyncCallback callback, object object);
                        /*0xffa650*/ Grpc.Core.Internal.CallError EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_call_start_server_streaming_delegate : System.MulticastDelegate
                    {
                        /*0xffab94*/ grpcsharp_call_start_server_streaming_delegate(object object, nint method);
                        /*0xffabf4*/ Grpc.Core.Internal.CallError Invoke(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                        /*0xffb00c*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags, System.AsyncCallback callback, object object);
                        /*0xffb0e4*/ Grpc.Core.Internal.CallError EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_call_start_duplex_streaming_delegate : System.MulticastDelegate
                    {
                        /*0xffa67c*/ grpcsharp_call_start_duplex_streaming_delegate(object object, nint method);
                        /*0xffa6dc*/ Grpc.Core.Internal.CallError Invoke(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                        /*0xffaabc*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags, System.AsyncCallback callback, object object);
                        /*0xffab68*/ Grpc.Core.Internal.CallError EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_call_send_message_delegate : System.MulticastDelegate
                    {
                        /*0xff9164*/ grpcsharp_call_send_message_delegate(object object, nint method);
                        /*0xff91c4*/ Grpc.Core.Internal.CallError Invoke(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, int sendEmptyInitialMetadata);
                        /*0xff95c4*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, int sendEmptyInitialMetadata, System.AsyncCallback callback, object object);
                        /*0xff969c*/ Grpc.Core.Internal.CallError EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_call_send_close_from_client_delegate : System.MulticastDelegate
                    {
                        /*0xff8890*/ grpcsharp_call_send_close_from_client_delegate(object object, nint method);
                        /*0xff88f0*/ Grpc.Core.Internal.CallError Invoke(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                        /*0xff8c8c*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, System.AsyncCallback callback, object object);
                        /*0xff8cbc*/ Grpc.Core.Internal.CallError EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_call_send_status_from_server_delegate : System.MulticastDelegate
                    {
                        /*0xff96c8*/ grpcsharp_call_send_status_from_server_delegate(object object, nint method);
                        /*0xff9728*/ Grpc.Core.Internal.CallError Invoke(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.StatusCode statusCode, nint statusMessage, nuint statusMessageLen, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, int sendEmptyInitialMetadata, Grpc.Core.Internal.SliceBufferSafeHandle optionalSendBuffer, Grpc.Core.WriteFlags writeFlags);
                        /*0xff9b8c*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.StatusCode statusCode, nint statusMessage, nuint statusMessageLen, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, int sendEmptyInitialMetadata, Grpc.Core.Internal.SliceBufferSafeHandle optionalSendBuffer, Grpc.Core.WriteFlags writeFlags, System.AsyncCallback callback, object object);
                        /*0xff9ce0*/ Grpc.Core.Internal.CallError EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_call_recv_message_delegate : System.MulticastDelegate
                    {
                        /*0xff8438*/ grpcsharp_call_recv_message_delegate(object object, nint method);
                        /*0xff8498*/ Grpc.Core.Internal.CallError Invoke(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                        /*0xff8834*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, System.AsyncCallback callback, object object);
                        /*0xff8864*/ Grpc.Core.Internal.CallError EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_call_recv_initial_metadata_delegate : System.MulticastDelegate
                    {
                        /*0xff7fe0*/ grpcsharp_call_recv_initial_metadata_delegate(object object, nint method);
                        /*0xff8040*/ Grpc.Core.Internal.CallError Invoke(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                        /*0xff83dc*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, System.AsyncCallback callback, object object);
                        /*0xff840c*/ Grpc.Core.Internal.CallError EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_call_start_serverside_delegate : System.MulticastDelegate
                    {
                        /*0xffb110*/ grpcsharp_call_start_serverside_delegate(object object, nint method);
                        /*0xffb170*/ Grpc.Core.Internal.CallError Invoke(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                        /*0xffb50c*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, System.AsyncCallback callback, object object);
                        /*0xffb53c*/ Grpc.Core.Internal.CallError EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_call_send_initial_metadata_delegate : System.MulticastDelegate
                    {
                        /*0xff8ce8*/ grpcsharp_call_send_initial_metadata_delegate(object object, nint method);
                        /*0xff8d48*/ Grpc.Core.Internal.CallError Invoke(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray);
                        /*0xff9108*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, System.AsyncCallback callback, object object);
                        /*0xff9138*/ Grpc.Core.Internal.CallError EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_call_set_credentials_delegate : System.MulticastDelegate
                    {
                        /*0xff9d0c*/ grpcsharp_call_set_credentials_delegate(object object, nint method);
                        /*0xff9d6c*/ Grpc.Core.Internal.CallError Invoke(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.CallCredentialsSafeHandle credentials);
                        /*0xffa108*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.CallCredentialsSafeHandle credentials, System.AsyncCallback callback, object object);
                        /*0xffa138*/ Grpc.Core.Internal.CallError EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_call_get_peer_delegate : System.MulticastDelegate
                    {
                        /*0xff7bd0*/ grpcsharp_call_get_peer_delegate(object object, nint method);
                        /*0xff7c30*/ Grpc.Core.Internal.CStringSafeHandle Invoke(Grpc.Core.Internal.CallSafeHandle call);
                        /*0xff7fb0*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.CallSafeHandle call, System.AsyncCallback callback, object object);
                        /*0xff7fd4*/ Grpc.Core.Internal.CStringSafeHandle EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_call_destroy_delegate : System.MulticastDelegate
                    {
                        /*0xff78b0*/ grpcsharp_call_destroy_delegate(object object, nint method);
                        /*0xff7910*/ void Invoke(nint call);
                        /*0xff7b3c*/ System.IAsyncResult BeginInvoke(nint call, System.AsyncCallback callback, object object);
                        /*0xff7bc4*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_channel_args_create_delegate : System.MulticastDelegate
                    {
                        /*0xffbae4*/ grpcsharp_channel_args_create_delegate(object object, nint method);
                        /*0xffbb44*/ Grpc.Core.Internal.ChannelArgsSafeHandle Invoke(nuint numArgs);
                        /*0xffbd78*/ System.IAsyncResult BeginInvoke(nuint numArgs, System.AsyncCallback callback, object object);
                        /*0xffbe00*/ Grpc.Core.Internal.ChannelArgsSafeHandle EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_channel_args_set_string_delegate : System.MulticastDelegate
                    {
                        /*0xffc638*/ grpcsharp_channel_args_set_string_delegate(object object, nint method);
                        /*0xffc698*/ void Invoke(Grpc.Core.Internal.ChannelArgsSafeHandle args, nuint index, string key, string value);
                        /*0xffca70*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.ChannelArgsSafeHandle args, nuint index, string key, string value, System.AsyncCallback callback, object object);
                        /*0xffcb18*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_channel_args_set_integer_delegate : System.MulticastDelegate
                    {
                        /*0xffc12c*/ grpcsharp_channel_args_set_integer_delegate(object object, nint method);
                        /*0xffc18c*/ void Invoke(Grpc.Core.Internal.ChannelArgsSafeHandle args, nuint index, string key, int value);
                        /*0xffc564*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.ChannelArgsSafeHandle args, nuint index, string key, int value, System.AsyncCallback callback, object object);
                        /*0xffc62c*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_channel_args_destroy_delegate : System.MulticastDelegate
                    {
                        /*0xffbe0c*/ grpcsharp_channel_args_destroy_delegate(object object, nint method);
                        /*0xffbe6c*/ void Invoke(nint args);
                        /*0xffc098*/ System.IAsyncResult BeginInvoke(nint args, System.AsyncCallback callback, object object);
                        /*0xffc120*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_override_default_ssl_roots_delegate : System.MulticastDelegate
                    {
                        /*0x1002ad4*/ grpcsharp_override_default_ssl_roots_delegate(object object, nint method);
                        /*0x1002b34*/ void Invoke(string pemRootCerts);
                        /*0x1002eac*/ System.IAsyncResult BeginInvoke(string pemRootCerts, System.AsyncCallback callback, object object);
                        /*0x1002ed0*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_ssl_credentials_create_delegate : System.MulticastDelegate
                    {
                        /*0x1008604*/ grpcsharp_ssl_credentials_create_delegate(object object, nint method);
                        /*0x1008664*/ Grpc.Core.Internal.ChannelCredentialsSafeHandle Invoke(string pemRootCerts, string keyCertPairCertChain, string keyCertPairPrivateKey, nint verifyPeerCallbackTag);
                        /*0x1008a44*/ System.IAsyncResult BeginInvoke(string pemRootCerts, string keyCertPairCertChain, string keyCertPairPrivateKey, nint verifyPeerCallbackTag, System.AsyncCallback callback, object object);
                        /*0x1008aec*/ Grpc.Core.Internal.ChannelCredentialsSafeHandle EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_composite_channel_credentials_create_delegate : System.MulticastDelegate
                    {
                        /*0xfffeb0*/ grpcsharp_composite_channel_credentials_create_delegate(object object, nint method);
                        /*0xffff10*/ Grpc.Core.Internal.ChannelCredentialsSafeHandle Invoke(Grpc.Core.Internal.ChannelCredentialsSafeHandle channelCreds, Grpc.Core.Internal.CallCredentialsSafeHandle callCreds);
                        /*0x10002ac*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.ChannelCredentialsSafeHandle channelCreds, Grpc.Core.Internal.CallCredentialsSafeHandle callCreds, System.AsyncCallback callback, object object);
                        /*0x10002dc*/ Grpc.Core.Internal.ChannelCredentialsSafeHandle EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_channel_credentials_release_delegate : System.MulticastDelegate
                    {
                        /*0xffd570*/ grpcsharp_channel_credentials_release_delegate(object object, nint method);
                        /*0xffd5d0*/ void Invoke(nint credentials);
                        /*0xffd7fc*/ System.IAsyncResult BeginInvoke(nint credentials, System.AsyncCallback callback, object object);
                        /*0xffd884*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_insecure_channel_create_delegate : System.MulticastDelegate
                    {
                        /*0x100058c*/ grpcsharp_insecure_channel_create_delegate(object object, nint method);
                        /*0x10005ec*/ Grpc.Core.Internal.ChannelSafeHandle Invoke(string target, Grpc.Core.Internal.ChannelArgsSafeHandle channelArgs);
                        /*0x1000988*/ System.IAsyncResult BeginInvoke(string target, Grpc.Core.Internal.ChannelArgsSafeHandle channelArgs, System.AsyncCallback callback, object object);
                        /*0x10009b8*/ Grpc.Core.Internal.ChannelSafeHandle EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_secure_channel_create_delegate : System.MulticastDelegate
                    {
                        /*0x10052c8*/ grpcsharp_secure_channel_create_delegate(object object, nint method);
                        /*0x1005328*/ Grpc.Core.Internal.ChannelSafeHandle Invoke(Grpc.Core.Internal.ChannelCredentialsSafeHandle credentials, string target, Grpc.Core.Internal.ChannelArgsSafeHandle channelArgs);
                        /*0x10056e8*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.ChannelCredentialsSafeHandle credentials, string target, Grpc.Core.Internal.ChannelArgsSafeHandle channelArgs, System.AsyncCallback callback, object object);
                        /*0x1005718*/ Grpc.Core.Internal.ChannelSafeHandle EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_channel_create_call_delegate : System.MulticastDelegate
                    {
                        /*0xffcfe4*/ grpcsharp_channel_create_call_delegate(object object, nint method);
                        /*0xffd044*/ Grpc.Core.Internal.CallSafeHandle Invoke(Grpc.Core.Internal.ChannelSafeHandle channel, Grpc.Core.Internal.CallSafeHandle parentCall, Grpc.Core.Internal.ContextPropagationFlags propagationMask, Grpc.Core.Internal.CompletionQueueSafeHandle cq, string method, string host, Grpc.Core.Internal.Timespec deadline);
                        /*0xffd47c*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.ChannelSafeHandle channel, Grpc.Core.Internal.CallSafeHandle parentCall, Grpc.Core.Internal.ContextPropagationFlags propagationMask, Grpc.Core.Internal.CompletionQueueSafeHandle cq, string method, string host, Grpc.Core.Internal.Timespec deadline, System.AsyncCallback callback, object object);
                        /*0xffd564*/ Grpc.Core.Internal.CallSafeHandle EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_channel_check_connectivity_state_delegate : System.MulticastDelegate
                    {
                        /*0xffcb24*/ grpcsharp_channel_check_connectivity_state_delegate(object object, nint method);
                        /*0xffcb84*/ Grpc.Core.ChannelState Invoke(Grpc.Core.Internal.ChannelSafeHandle channel, int tryToConnect);
                        /*0xffcf20*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.ChannelSafeHandle channel, int tryToConnect, System.AsyncCallback callback, object object);
                        /*0xffcfb8*/ Grpc.Core.ChannelState EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_channel_watch_connectivity_state_delegate : System.MulticastDelegate
                    {
                        /*0xffdfc0*/ grpcsharp_channel_watch_connectivity_state_delegate(object object, nint method);
                        /*0xffe020*/ void Invoke(Grpc.Core.Internal.ChannelSafeHandle channel, Grpc.Core.ChannelState lastObservedState, Grpc.Core.Internal.Timespec deadline, Grpc.Core.Internal.CompletionQueueSafeHandle cq, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                        /*0xffe418*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.ChannelSafeHandle channel, Grpc.Core.ChannelState lastObservedState, Grpc.Core.Internal.Timespec deadline, Grpc.Core.Internal.CompletionQueueSafeHandle cq, Grpc.Core.Internal.BatchContextSafeHandle ctx, System.AsyncCallback callback, object object);
                        /*0xffe4f0*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_channel_get_target_delegate : System.MulticastDelegate
                    {
                        /*0xffdbb0*/ grpcsharp_channel_get_target_delegate(object object, nint method);
                        /*0xffdc10*/ Grpc.Core.Internal.CStringSafeHandle Invoke(Grpc.Core.Internal.ChannelSafeHandle call);
                        /*0xffdf90*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.ChannelSafeHandle call, System.AsyncCallback callback, object object);
                        /*0xffdfb4*/ Grpc.Core.Internal.CStringSafeHandle EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_channel_destroy_delegate : System.MulticastDelegate
                    {
                        /*0xffd890*/ grpcsharp_channel_destroy_delegate(object object, nint method);
                        /*0xffd8f0*/ void Invoke(nint channel);
                        /*0xffdb1c*/ System.IAsyncResult BeginInvoke(nint channel, System.AsyncCallback callback, object object);
                        /*0xffdba4*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_sizeof_grpc_event_delegate : System.MulticastDelegate
                    {
                        /*0x1007674*/ grpcsharp_sizeof_grpc_event_delegate(object object, nint method);
                        /*0x10076d4*/ int Invoke();
                        /*0x10078e8*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                        /*0x1007914*/ int EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_completion_queue_create_async_delegate : System.MulticastDelegate
                    {
                        /*0xffe4fc*/ grpcsharp_completion_queue_create_async_delegate(object object, nint method);
                        /*0xffe55c*/ Grpc.Core.Internal.CompletionQueueSafeHandle Invoke();
                        /*0xffe770*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                        /*0xffe79c*/ Grpc.Core.Internal.CompletionQueueSafeHandle EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_completion_queue_create_sync_delegate : System.MulticastDelegate
                    {
                        /*0xffe7a8*/ grpcsharp_completion_queue_create_sync_delegate(object object, nint method);
                        /*0xffe808*/ Grpc.Core.Internal.CompletionQueueSafeHandle Invoke();
                        /*0xffea1c*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                        /*0xffea48*/ Grpc.Core.Internal.CompletionQueueSafeHandle EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_completion_queue_shutdown_delegate : System.MulticastDelegate
                    {
                        /*0xfff670*/ grpcsharp_completion_queue_shutdown_delegate(object object, nint method);
                        /*0xfff6d0*/ void Invoke(Grpc.Core.Internal.CompletionQueueSafeHandle cq);
                        /*0xfffa48*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.CompletionQueueSafeHandle cq, System.AsyncCallback callback, object object);
                        /*0xfffa6c*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_completion_queue_next_delegate : System.MulticastDelegate
                    {
                        /*0xffed74*/ grpcsharp_completion_queue_next_delegate(object object, nint method);
                        /*0xffedd4*/ Grpc.Core.Internal.CompletionQueueEvent Invoke(Grpc.Core.Internal.CompletionQueueSafeHandle cq);
                        /*0xfff158*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.CompletionQueueSafeHandle cq, System.AsyncCallback callback, object object);
                        /*0xfff17c*/ Grpc.Core.Internal.CompletionQueueEvent EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_completion_queue_pluck_delegate : System.MulticastDelegate
                    {
                        /*0xfff1ac*/ grpcsharp_completion_queue_pluck_delegate(object object, nint method);
                        /*0xfff20c*/ Grpc.Core.Internal.CompletionQueueEvent Invoke(Grpc.Core.Internal.CompletionQueueSafeHandle cq, nint tag);
                        /*0xfff5ac*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.CompletionQueueSafeHandle cq, nint tag, System.AsyncCallback callback, object object);
                        /*0xfff640*/ Grpc.Core.Internal.CompletionQueueEvent EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_completion_queue_destroy_delegate : System.MulticastDelegate
                    {
                        /*0xffea54*/ grpcsharp_completion_queue_destroy_delegate(object object, nint method);
                        /*0xffeab4*/ void Invoke(nint cq);
                        /*0xffece0*/ System.IAsyncResult BeginInvoke(nint cq, System.AsyncCallback callback, object object);
                        /*0xffed68*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class gprsharp_free_delegate : System.MulticastDelegate
                    {
                        /*0xff1c10*/ gprsharp_free_delegate(object object, nint method);
                        /*0xff1c70*/ void Invoke(nint ptr);
                        /*0xff1e9c*/ System.IAsyncResult BeginInvoke(nint ptr, System.AsyncCallback callback, object object);
                        /*0xff1f24*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_metadata_array_create_delegate : System.MulticastDelegate
                    {
                        /*0x10011f8*/ grpcsharp_metadata_array_create_delegate(object object, nint method);
                        /*0x1001258*/ Grpc.Core.Internal.MetadataArraySafeHandle Invoke(nuint capacity);
                        /*0x100148c*/ System.IAsyncResult BeginInvoke(nuint capacity, System.AsyncCallback callback, object object);
                        /*0x1001514*/ Grpc.Core.Internal.MetadataArraySafeHandle EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_metadata_array_add_delegate : System.MulticastDelegate
                    {
                        /*0x10009c4*/ grpcsharp_metadata_array_add_delegate(object object, nint method);
                        /*0x1000a24*/ void Invoke(Grpc.Core.Internal.MetadataArraySafeHandle array, string key, byte[] value, nuint valueLength);
                        /*0x1000dfc*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.MetadataArraySafeHandle array, string key, byte[] value, nuint valueLength, System.AsyncCallback callback, object object);
                        /*0x1000ea4*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_metadata_array_count_delegate : System.MulticastDelegate
                    {
                        /*0x1000eb0*/ grpcsharp_metadata_array_count_delegate(object object, nint method);
                        /*0x1000f10*/ nuint Invoke(nint metadataArray);
                        /*0x1001144*/ System.IAsyncResult BeginInvoke(nint metadataArray, System.AsyncCallback callback, object object);
                        /*0x10011cc*/ nuint EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_metadata_array_get_key_delegate : System.MulticastDelegate
                    {
                        /*0x1001840*/ grpcsharp_metadata_array_get_key_delegate(object object, nint method);
                        /*0x10018a0*/ nint Invoke(nint metadataArray, nuint index, ref nuint keyLength);
                        /*0x1001b04*/ System.IAsyncResult BeginInvoke(nint metadataArray, nuint index, ref nuint keyLength, System.AsyncCallback callback, object object);
                        /*0x1001bd4*/ nint EndInvoke(ref nuint keyLength, System.IAsyncResult result);
                    }

                    class grpcsharp_metadata_array_get_value_delegate : System.MulticastDelegate
                    {
                        /*0x1001c0c*/ grpcsharp_metadata_array_get_value_delegate(object object, nint method);
                        /*0x1001c6c*/ nint Invoke(nint metadataArray, nuint index, ref nuint valueLength);
                        /*0x1001ed0*/ System.IAsyncResult BeginInvoke(nint metadataArray, nuint index, ref nuint valueLength, System.AsyncCallback callback, object object);
                        /*0x1001fa0*/ nint EndInvoke(ref nuint valueLength, System.IAsyncResult result);
                    }

                    class grpcsharp_metadata_array_destroy_full_delegate : System.MulticastDelegate
                    {
                        /*0x1001520*/ grpcsharp_metadata_array_destroy_full_delegate(object object, nint method);
                        /*0x1001580*/ void Invoke(nint array);
                        /*0x10017ac*/ System.IAsyncResult BeginInvoke(nint array, System.AsyncCallback callback, object object);
                        /*0x1001834*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_redirect_log_delegate : System.MulticastDelegate
                    {
                        /*0x1002edc*/ grpcsharp_redirect_log_delegate(object object, nint method);
                        /*0x1002f3c*/ void Invoke(Grpc.Core.Internal.GprLogDelegate callback);
                        /*0x10032b4*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.GprLogDelegate callback, System.AsyncCallback __callback, object object);
                        /*0x10032d8*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_native_callback_dispatcher_init_delegate : System.MulticastDelegate
                    {
                        /*0x10026cc*/ grpcsharp_native_callback_dispatcher_init_delegate(object object, nint method);
                        /*0x100272c*/ void Invoke(Grpc.Core.Internal.NativeCallbackDispatcherCallback dispatcher);
                        /*0x1002aa4*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.NativeCallbackDispatcherCallback dispatcher, System.AsyncCallback callback, object object);
                        /*0x1002ac8*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_metadata_credentials_create_from_plugin_delegate : System.MulticastDelegate
                    {
                        /*0x1001fd8*/ grpcsharp_metadata_credentials_create_from_plugin_delegate(object object, nint method);
                        /*0x1002038*/ Grpc.Core.Internal.CallCredentialsSafeHandle Invoke(nint nativeCallbackTag);
                        /*0x100226c*/ System.IAsyncResult BeginInvoke(nint nativeCallbackTag, System.AsyncCallback callback, object object);
                        /*0x10022f4*/ Grpc.Core.Internal.CallCredentialsSafeHandle EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_metadata_credentials_notify_from_plugin_delegate : System.MulticastDelegate
                    {
                        /*0x1002300*/ grpcsharp_metadata_credentials_notify_from_plugin_delegate(object object, nint method);
                        /*0x1002360*/ void Invoke(nint callbackPtr, nint userData, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.StatusCode statusCode, string errorDetails);
                        /*0x10025e4*/ System.IAsyncResult BeginInvoke(nint callbackPtr, nint userData, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.StatusCode statusCode, string errorDetails, System.AsyncCallback callback, object object);
                        /*0x10026c0*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_ssl_server_credentials_create_delegate : System.MulticastDelegate
                    {
                        /*0x1008af8*/ grpcsharp_ssl_server_credentials_create_delegate(object object, nint method);
                        /*0x1008b58*/ Grpc.Core.Internal.ServerCredentialsSafeHandle Invoke(string pemRootCerts, string[] keyCertPairCertChainArray, string[] keyCertPairPrivateKeyArray, nuint numKeyCertPairs, Grpc.Core.SslClientCertificateRequestType clientCertificateRequest);
                        /*0x1008f58*/ System.IAsyncResult BeginInvoke(string pemRootCerts, string[] keyCertPairCertChainArray, string[] keyCertPairPrivateKeyArray, nuint numKeyCertPairs, Grpc.Core.SslClientCertificateRequestType clientCertificateRequest, System.AsyncCallback callback, object object);
                        /*0x1009030*/ Grpc.Core.Internal.ServerCredentialsSafeHandle EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_server_credentials_release_delegate : System.MulticastDelegate
                    {
                        /*0x1006498*/ grpcsharp_server_credentials_release_delegate(object object, nint method);
                        /*0xfc36dc*/ void Invoke(nint credentials);
                        /*0x10064f8*/ System.IAsyncResult BeginInvoke(nint credentials, System.AsyncCallback callback, object object);
                        /*0x1006580*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_server_create_delegate : System.MulticastDelegate
                    {
                        /*0x1006088*/ grpcsharp_server_create_delegate(object object, nint method);
                        /*0x10060e8*/ Grpc.Core.Internal.ServerSafeHandle Invoke(Grpc.Core.Internal.ChannelArgsSafeHandle args);
                        /*0x1006468*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.ChannelArgsSafeHandle args, System.AsyncCallback callback, object object);
                        /*0x100648c*/ Grpc.Core.Internal.ServerSafeHandle EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_server_register_completion_queue_delegate : System.MulticastDelegate
                    {
                        /*0x1006680*/ grpcsharp_server_register_completion_queue_delegate(object object, nint method);
                        /*0x10066e0*/ void Invoke(Grpc.Core.Internal.ServerSafeHandle server, Grpc.Core.Internal.CompletionQueueSafeHandle cq);
                        /*0x1006a74*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.ServerSafeHandle server, Grpc.Core.Internal.CompletionQueueSafeHandle cq, System.AsyncCallback callback, object object);
                        /*0x1006aa4*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_server_add_insecure_http2_port_delegate : System.MulticastDelegate
                    {
                        /*0x1005724*/ grpcsharp_server_add_insecure_http2_port_delegate(object object, nint method);
                        /*0x1005784*/ int Invoke(Grpc.Core.Internal.ServerSafeHandle server, string addr);
                        /*0x1005b20*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.ServerSafeHandle server, string addr, System.AsyncCallback callback, object object);
                        /*0x1005b50*/ int EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_server_add_secure_http2_port_delegate : System.MulticastDelegate
                    {
                        /*0x1005b7c*/ grpcsharp_server_add_secure_http2_port_delegate(object object, nint method);
                        /*0x1005bdc*/ int Invoke(Grpc.Core.Internal.ServerSafeHandle server, string addr, Grpc.Core.Internal.ServerCredentialsSafeHandle creds);
                        /*0x1005f9c*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.ServerSafeHandle server, string addr, Grpc.Core.Internal.ServerCredentialsSafeHandle creds, System.AsyncCallback callback, object object);
                        /*0x1005fcc*/ int EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_server_start_delegate : System.MulticastDelegate
                    {
                        /*0x1006fc8*/ grpcsharp_server_start_delegate(object object, nint method);
                        /*0x1007028*/ void Invoke(Grpc.Core.Internal.ServerSafeHandle server);
                        /*0x10073a0*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.ServerSafeHandle server, System.AsyncCallback callback, object object);
                        /*0x10073c4*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_server_request_call_delegate : System.MulticastDelegate
                    {
                        /*0x1006ab0*/ grpcsharp_server_request_call_delegate(object object, nint method);
                        /*0x1006b10*/ Grpc.Core.Internal.CallError Invoke(Grpc.Core.Internal.ServerSafeHandle server, Grpc.Core.Internal.CompletionQueueSafeHandle cq, Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                        /*0x1006ed0*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.ServerSafeHandle server, Grpc.Core.Internal.CompletionQueueSafeHandle cq, Grpc.Core.Internal.RequestCallContextSafeHandle ctx, System.AsyncCallback callback, object object);
                        /*0x1006f00*/ Grpc.Core.Internal.CallError EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_server_cancel_all_calls_delegate : System.MulticastDelegate
                    {
                        /*0x1005ff8*/ grpcsharp_server_cancel_all_calls_delegate(object object, nint method);
                        /*0xfc41f8*/ void Invoke(Grpc.Core.Internal.ServerSafeHandle server);
                        /*0x1006058*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.ServerSafeHandle server, System.AsyncCallback callback, object object);
                        /*0x100607c*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_server_shutdown_and_notify_callback_delegate : System.MulticastDelegate
                    {
                        /*0x1006f2c*/ grpcsharp_server_shutdown_and_notify_callback_delegate(object object, nint method);
                        /*0xfc3ac4*/ void Invoke(Grpc.Core.Internal.ServerSafeHandle server, Grpc.Core.Internal.CompletionQueueSafeHandle cq, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                        /*0x1006f8c*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.ServerSafeHandle server, Grpc.Core.Internal.CompletionQueueSafeHandle cq, Grpc.Core.Internal.BatchContextSafeHandle ctx, System.AsyncCallback callback, object object);
                        /*0x1006fbc*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_server_destroy_delegate : System.MulticastDelegate
                    {
                        /*0x100658c*/ grpcsharp_server_destroy_delegate(object object, nint method);
                        /*0xfc3f50*/ void Invoke(nint server);
                        /*0x10065ec*/ System.IAsyncResult BeginInvoke(nint server, System.AsyncCallback callback, object object);
                        /*0x1006674*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_call_auth_context_delegate : System.MulticastDelegate
                    {
                        /*0xff6868*/ grpcsharp_call_auth_context_delegate(object object, nint method);
                        /*0xff68c8*/ Grpc.Core.Internal.AuthContextSafeHandle Invoke(Grpc.Core.Internal.CallSafeHandle call);
                        /*0xff6c48*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.CallSafeHandle call, System.AsyncCallback callback, object object);
                        /*0xff6c6c*/ Grpc.Core.Internal.AuthContextSafeHandle EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_auth_context_peer_identity_property_name_delegate : System.MulticastDelegate
                    {
                        /*0xff2c64*/ grpcsharp_auth_context_peer_identity_property_name_delegate(object object, nint method);
                        /*0xff2cc4*/ nint Invoke(Grpc.Core.Internal.AuthContextSafeHandle authContext);
                        /*0xff3044*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.AuthContextSafeHandle authContext, System.AsyncCallback callback, object object);
                        /*0xff3068*/ nint EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_auth_context_property_iterator_delegate : System.MulticastDelegate
                    {
                        /*0xff3094*/ grpcsharp_auth_context_property_iterator_delegate(object object, nint method);
                        /*0xff30f4*/ Grpc.Core.Internal.AuthContextSafeHandle.NativeAuthPropertyIterator Invoke(Grpc.Core.Internal.AuthContextSafeHandle authContext);
                        /*0xff3490*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.AuthContextSafeHandle authContext, System.AsyncCallback callback, object object);
                        /*0xff34b4*/ Grpc.Core.Internal.AuthContextSafeHandle.NativeAuthPropertyIterator EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_auth_property_iterator_next_delegate : System.MulticastDelegate
                    {
                        /*0xff3818*/ grpcsharp_auth_property_iterator_next_delegate(object object, nint method);
                        /*0xff3878*/ nint Invoke(ref Grpc.Core.Internal.AuthContextSafeHandle.NativeAuthPropertyIterator iterator);
                        /*0xff3abc*/ System.IAsyncResult BeginInvoke(ref Grpc.Core.Internal.AuthContextSafeHandle.NativeAuthPropertyIterator iterator, System.AsyncCallback callback, object object);
                        /*0xff3b4c*/ nint EndInvoke(ref Grpc.Core.Internal.AuthContextSafeHandle.NativeAuthPropertyIterator iterator, System.IAsyncResult result);
                    }

                    class grpcsharp_auth_context_release_delegate : System.MulticastDelegate
                    {
                        /*0xff34f8*/ grpcsharp_auth_context_release_delegate(object object, nint method);
                        /*0xff3558*/ void Invoke(nint authContext);
                        /*0xff3784*/ System.IAsyncResult BeginInvoke(nint authContext, System.AsyncCallback callback, object object);
                        /*0xff380c*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_slice_buffer_create_delegate : System.MulticastDelegate
                    {
                        /*0x1007a78*/ grpcsharp_slice_buffer_create_delegate(object object, nint method);
                        /*0xfc4780*/ Grpc.Core.Internal.SliceBufferSafeHandle Invoke();
                        /*0x1007ad8*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                        /*0x1007b04*/ Grpc.Core.Internal.SliceBufferSafeHandle EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_slice_buffer_adjust_tail_space_delegate : System.MulticastDelegate
                    {
                        /*0x1007940*/ grpcsharp_slice_buffer_adjust_tail_space_delegate(object object, nint method);
                        /*0xfc51a0*/ nint Invoke(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer, nuint availableTailSpace, nuint requestedTailSpace);
                        /*0x10079a0*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer, nuint availableTailSpace, nuint requestedTailSpace, System.AsyncCallback callback, object object);
                        /*0x1007a4c*/ nint EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_slice_buffer_slice_count_delegate : System.MulticastDelegate
                    {
                        /*0x1007c94*/ grpcsharp_slice_buffer_slice_count_delegate(object object, nint method);
                        /*0x1007cf4*/ nuint Invoke(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer);
                        /*0x1008074*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer, System.AsyncCallback callback, object object);
                        /*0x1008098*/ nuint EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_slice_buffer_slice_peek_delegate : System.MulticastDelegate
                    {
                        /*0x10080c4*/ grpcsharp_slice_buffer_slice_peek_delegate(object object, nint method);
                        /*0x1008124*/ void Invoke(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer, nuint index, ref nuint sliceLen, ref nint sliceDataPtr);
                        /*0x10084fc*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer, nuint index, ref nuint sliceLen, ref nint sliceDataPtr, System.AsyncCallback callback, object object);
                        /*0x10085dc*/ void EndInvoke(ref nuint sliceLen, ref nint sliceDataPtr, System.IAsyncResult result);
                    }

                    class grpcsharp_slice_buffer_reset_and_unref_delegate : System.MulticastDelegate
                    {
                        /*0x1007c04*/ grpcsharp_slice_buffer_reset_and_unref_delegate(object object, nint method);
                        /*0xfc4e28*/ void Invoke(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer);
                        /*0x1007c64*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer, System.AsyncCallback callback, object object);
                        /*0x1007c88*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_slice_buffer_destroy_delegate : System.MulticastDelegate
                    {
                        /*0x1007b10*/ grpcsharp_slice_buffer_destroy_delegate(object object, nint method);
                        /*0xfc55e4*/ void Invoke(nint sliceBuffer);
                        /*0x1007b70*/ System.IAsyncResult BeginInvoke(nint sliceBuffer, System.AsyncCallback callback, object object);
                        /*0x1007bf8*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class gprsharp_now_delegate : System.MulticastDelegate
                    {
                        /*0xff2620*/ gprsharp_now_delegate(object object, nint method);
                        /*0xff2680*/ Grpc.Core.Internal.Timespec Invoke(Grpc.Core.Internal.ClockType clockType);
                        /*0xff28e0*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.ClockType clockType, System.AsyncCallback callback, object object);
                        /*0xff2968*/ Grpc.Core.Internal.Timespec EndInvoke(System.IAsyncResult result);
                    }

                    class gprsharp_inf_future_delegate : System.MulticastDelegate
                    {
                        /*0xff1f30*/ gprsharp_inf_future_delegate(object object, nint method);
                        /*0xff1f90*/ Grpc.Core.Internal.Timespec Invoke(Grpc.Core.Internal.ClockType clockType);
                        /*0xff21f0*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.ClockType clockType, System.AsyncCallback callback, object object);
                        /*0xff2278*/ Grpc.Core.Internal.Timespec EndInvoke(System.IAsyncResult result);
                    }

                    class gprsharp_inf_past_delegate : System.MulticastDelegate
                    {
                        /*0xff22a8*/ gprsharp_inf_past_delegate(object object, nint method);
                        /*0xff2308*/ Grpc.Core.Internal.Timespec Invoke(Grpc.Core.Internal.ClockType clockType);
                        /*0xff2568*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.ClockType clockType, System.AsyncCallback callback, object object);
                        /*0xff25f0*/ Grpc.Core.Internal.Timespec EndInvoke(System.IAsyncResult result);
                    }

                    class gprsharp_convert_clock_type_delegate : System.MulticastDelegate
                    {
                        /*0xff183c*/ gprsharp_convert_clock_type_delegate(object object, nint method);
                        /*0xff189c*/ Grpc.Core.Internal.Timespec Invoke(Grpc.Core.Internal.Timespec t, Grpc.Core.Internal.ClockType targetClock);
                        /*0xff1b2c*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.Timespec t, Grpc.Core.Internal.ClockType targetClock, System.AsyncCallback callback, object object);
                        /*0xff1be0*/ Grpc.Core.Internal.Timespec EndInvoke(System.IAsyncResult result);
                    }

                    class gprsharp_sizeof_timespec_delegate : System.MulticastDelegate
                    {
                        /*0xff2998*/ gprsharp_sizeof_timespec_delegate(object object, nint method);
                        /*0xff29f8*/ int Invoke();
                        /*0xff2c0c*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                        /*0xff2c38*/ int EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_test_callback_delegate : System.MulticastDelegate
                    {
                        /*0x10095b8*/ grpcsharp_test_callback_delegate(object object, nint method);
                        /*0x1009618*/ Grpc.Core.Internal.CallError Invoke(Grpc.Core.Internal.NativeCallbackTestDelegate callback);
                        /*0x1009998*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.NativeCallbackTestDelegate callback, System.AsyncCallback __callback, object object);
                        /*0x10099bc*/ Grpc.Core.Internal.CallError EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_test_nop_delegate : System.MulticastDelegate
                    {
                        /*0x10099e8*/ grpcsharp_test_nop_delegate(object object, nint method);
                        /*0x1009a48*/ nint Invoke(nint ptr);
                        /*0x1009c7c*/ System.IAsyncResult BeginInvoke(nint ptr, System.AsyncCallback callback, object object);
                        /*0x1009d04*/ nint EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_test_override_method_delegate : System.MulticastDelegate
                    {
                        /*0x1009d30*/ grpcsharp_test_override_method_delegate(object object, nint method);
                        /*0x1009d90*/ void Invoke(string methodName, string variant);
                        /*0x100a124*/ System.IAsyncResult BeginInvoke(string methodName, string variant, System.AsyncCallback callback, object object);
                        /*0x100a154*/ void EndInvoke(System.IAsyncResult result);
                    }

                    class grpcsharp_test_call_start_unary_echo_delegate : System.MulticastDelegate
                    {
                        /*0x100903c*/ grpcsharp_test_call_start_unary_echo_delegate(object object, nint method);
                        /*0x100909c*/ Grpc.Core.Internal.CallError Invoke(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                        /*0x10094b4*/ System.IAsyncResult BeginInvoke(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags, System.AsyncCallback callback, object object);
                        /*0x100958c*/ Grpc.Core.Internal.CallError EndInvoke(System.IAsyncResult result);
                    }
                }

                class DllImportsFromStaticLib
                {
                    static /*0xfed6f8*/ void grpcsharp_init();
                    static /*0xfed6fc*/ void grpcsharp_shutdown();
                    static /*0xfed700*/ nint grpcsharp_version_string();
                    static /*0xfed704*/ Grpc.Core.Internal.BatchContextSafeHandle grpcsharp_batch_context_create();
                    static /*0xfed76c*/ nint grpcsharp_batch_context_recv_initial_metadata(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfed7dc*/ nint grpcsharp_batch_context_recv_message_length(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfed84c*/ int grpcsharp_batch_context_recv_message_next_slice_peek(Grpc.Core.Internal.BatchContextSafeHandle ctx, ref nuint sliceLen, ref nint sliceDataPtr);
                    static /*0xfed8cc*/ Grpc.Core.StatusCode grpcsharp_batch_context_recv_status_on_client_status(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfed93c*/ nint grpcsharp_batch_context_recv_status_on_client_details(Grpc.Core.Internal.BatchContextSafeHandle ctx, ref nuint detailsLength);
                    static /*0xfed9b4*/ nint grpcsharp_batch_context_recv_status_on_client_error_string(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfeda24*/ nint grpcsharp_batch_context_recv_status_on_client_trailing_metadata(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfeda94*/ int grpcsharp_batch_context_recv_close_on_server_cancelled(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfedb04*/ void grpcsharp_batch_context_reset(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfedb64*/ void grpcsharp_batch_context_destroy(nint ctx);
                    static /*0xfedb68*/ Grpc.Core.Internal.RequestCallContextSafeHandle grpcsharp_request_call_context_create();
                    static /*0xfedbd0*/ Grpc.Core.Internal.CallSafeHandle grpcsharp_request_call_context_call(Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xfedc88*/ nint grpcsharp_request_call_context_method(Grpc.Core.Internal.RequestCallContextSafeHandle ctx, ref nuint methodLength);
                    static /*0xfedd00*/ nint grpcsharp_request_call_context_host(Grpc.Core.Internal.RequestCallContextSafeHandle ctx, ref nuint hostLength);
                    static /*0xfedd78*/ Grpc.Core.Internal.Timespec grpcsharp_request_call_context_deadline(Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xfeddf0*/ nint grpcsharp_request_call_context_request_metadata(Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xfede60*/ void grpcsharp_request_call_context_reset(Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xfedec0*/ void grpcsharp_request_call_context_destroy(nint ctx);
                    static /*0xfedec4*/ Grpc.Core.Internal.CallCredentialsSafeHandle grpcsharp_composite_call_credentials_create(Grpc.Core.Internal.CallCredentialsSafeHandle creds1, Grpc.Core.Internal.CallCredentialsSafeHandle creds2);
                    static /*0xfedfc8*/ void grpcsharp_call_credentials_release(nint credentials);
                    static /*0xfedfcc*/ Grpc.Core.Internal.CallError grpcsharp_call_cancel(Grpc.Core.Internal.CallSafeHandle call);
                    static /*0xfee03c*/ Grpc.Core.Internal.CallError grpcsharp_call_cancel_with_status(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.StatusCode status, string description);
                    static /*0xfee0dc*/ Grpc.Core.Internal.CallError grpcsharp_call_start_unary(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    static /*0xfee248*/ Grpc.Core.Internal.CallError grpcsharp_call_start_client_streaming(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    static /*0xfee358*/ Grpc.Core.Internal.CallError grpcsharp_call_start_server_streaming(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    static /*0xfee4c4*/ Grpc.Core.Internal.CallError grpcsharp_call_start_duplex_streaming(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    static /*0xfee5d4*/ Grpc.Core.Internal.CallError grpcsharp_call_send_message(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, int sendEmptyInitialMetadata);
                    static /*0xfee6f4*/ Grpc.Core.Internal.CallError grpcsharp_call_send_close_from_client(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfee7a8*/ Grpc.Core.Internal.CallError grpcsharp_call_send_status_from_server(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.StatusCode statusCode, nint statusMessage, nuint statusMessageLen, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, int sendEmptyInitialMetadata, Grpc.Core.Internal.SliceBufferSafeHandle optionalSendBuffer, Grpc.Core.WriteFlags writeFlags);
                    static /*0xfee938*/ Grpc.Core.Internal.CallError grpcsharp_call_recv_message(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfee9ec*/ Grpc.Core.Internal.CallError grpcsharp_call_recv_initial_metadata(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfeeaa0*/ Grpc.Core.Internal.CallError grpcsharp_call_start_serverside(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfeeb54*/ Grpc.Core.Internal.CallError grpcsharp_call_send_initial_metadata(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray);
                    static /*0xfeec5c*/ Grpc.Core.Internal.CallError grpcsharp_call_set_credentials(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.CallCredentialsSafeHandle credentials);
                    static /*0xfeed10*/ Grpc.Core.Internal.CStringSafeHandle grpcsharp_call_get_peer(Grpc.Core.Internal.CallSafeHandle call);
                    static /*0xfeedc8*/ void grpcsharp_call_destroy(nint call);
                    static /*0xfeedcc*/ Grpc.Core.Internal.ChannelArgsSafeHandle grpcsharp_channel_args_create(nuint numArgs);
                    static /*0xfeee3c*/ void grpcsharp_channel_args_set_string(Grpc.Core.Internal.ChannelArgsSafeHandle args, nuint index, string key, string value);
                    static /*0xfeeef0*/ void grpcsharp_channel_args_set_integer(Grpc.Core.Internal.ChannelArgsSafeHandle args, nuint index, string key, int value);
                    static /*0xfeef90*/ void grpcsharp_channel_args_destroy(nint args);
                    static /*0xfeef94*/ void grpcsharp_override_default_ssl_roots(string pemRootCerts);
                    static /*0xfeefbc*/ Grpc.Core.Internal.ChannelCredentialsSafeHandle grpcsharp_ssl_credentials_create(string pemRootCerts, string keyCertPairCertChain, string keyCertPairPrivateKey, nint verifyPeerCallbackTag);
                    static /*0xfef090*/ Grpc.Core.Internal.ChannelCredentialsSafeHandle grpcsharp_composite_channel_credentials_create(Grpc.Core.Internal.ChannelCredentialsSafeHandle channelCreds, Grpc.Core.Internal.CallCredentialsSafeHandle callCreds);
                    static /*0xfef194*/ void grpcsharp_channel_credentials_release(nint credentials);
                    static /*0xfef198*/ Grpc.Core.Internal.ChannelSafeHandle grpcsharp_insecure_channel_create(string target, Grpc.Core.Internal.ChannelArgsSafeHandle channelArgs);
                    static /*0xfef274*/ Grpc.Core.Internal.ChannelSafeHandle grpcsharp_secure_channel_create(Grpc.Core.Internal.ChannelCredentialsSafeHandle credentials, string target, Grpc.Core.Internal.ChannelArgsSafeHandle channelArgs);
                    static /*0xfef394*/ Grpc.Core.Internal.CallSafeHandle grpcsharp_channel_create_call(Grpc.Core.Internal.ChannelSafeHandle channel, Grpc.Core.Internal.CallSafeHandle parentCall, Grpc.Core.Internal.ContextPropagationFlags propagationMask, Grpc.Core.Internal.CompletionQueueSafeHandle cq, string method, string host, Grpc.Core.Internal.Timespec deadline);
                    static /*0xfef54c*/ Grpc.Core.ChannelState grpcsharp_channel_check_connectivity_state(Grpc.Core.Internal.ChannelSafeHandle channel, int tryToConnect);
                    static /*0xfef5c4*/ void grpcsharp_channel_watch_connectivity_state(Grpc.Core.Internal.ChannelSafeHandle channel, Grpc.Core.ChannelState lastObservedState, Grpc.Core.Internal.Timespec deadline, Grpc.Core.Internal.CompletionQueueSafeHandle cq, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfef6e4*/ Grpc.Core.Internal.CStringSafeHandle grpcsharp_channel_get_target(Grpc.Core.Internal.ChannelSafeHandle call);
                    static /*0xfef79c*/ void grpcsharp_channel_destroy(nint channel);
                    static /*0xfef7a0*/ int grpcsharp_sizeof_grpc_event();
                    static /*0xfef7a4*/ Grpc.Core.Internal.CompletionQueueSafeHandle grpcsharp_completion_queue_create_async();
                    static /*0xfef80c*/ Grpc.Core.Internal.CompletionQueueSafeHandle grpcsharp_completion_queue_create_sync();
                    static /*0xfef874*/ void grpcsharp_completion_queue_shutdown(Grpc.Core.Internal.CompletionQueueSafeHandle cq);
                    static /*0xfef8d4*/ Grpc.Core.Internal.CompletionQueueEvent grpcsharp_completion_queue_next(Grpc.Core.Internal.CompletionQueueSafeHandle cq);
                    static /*0xfef94c*/ Grpc.Core.Internal.CompletionQueueEvent grpcsharp_completion_queue_pluck(Grpc.Core.Internal.CompletionQueueSafeHandle cq, nint tag);
                    static /*0xfef9cc*/ void grpcsharp_completion_queue_destroy(nint cq);
                    static /*0xfef9d0*/ void gprsharp_free(nint ptr);
                    static /*0xfef9d4*/ Grpc.Core.Internal.MetadataArraySafeHandle grpcsharp_metadata_array_create(nuint capacity);
                    static /*0xfefa44*/ void grpcsharp_metadata_array_add(Grpc.Core.Internal.MetadataArraySafeHandle array, string key, byte[] value, nuint valueLength);
                    static /*0xfefaec*/ nuint grpcsharp_metadata_array_count(nint metadataArray);
                    static /*0xfefaf0*/ nint grpcsharp_metadata_array_get_key(nint metadataArray, nuint index, ref nuint keyLength);
                    static /*0xfefaf4*/ nint grpcsharp_metadata_array_get_value(nint metadataArray, nuint index, ref nuint valueLength);
                    static /*0xfefaf8*/ void grpcsharp_metadata_array_destroy_full(nint array);
                    static /*0xfefafc*/ void grpcsharp_redirect_log(Grpc.Core.Internal.GprLogDelegate callback);
                    static /*0xfefb10*/ void grpcsharp_native_callback_dispatcher_init(Grpc.Core.Internal.NativeCallbackDispatcherCallback dispatcher);
                    static /*0xfefb24*/ Grpc.Core.Internal.CallCredentialsSafeHandle grpcsharp_metadata_credentials_create_from_plugin(nint nativeCallbackTag);
                    static /*0xfefb94*/ void grpcsharp_metadata_credentials_notify_from_plugin(nint callbackPtr, nint userData, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.StatusCode statusCode, string errorDetails);
                    static /*0xfefc48*/ Grpc.Core.Internal.ServerCredentialsSafeHandle grpcsharp_ssl_server_credentials_create(string pemRootCerts, string[] keyCertPairCertChainArray, string[] keyCertPairPrivateKeyArray, nuint numKeyCertPairs, Grpc.Core.SslClientCertificateRequestType clientCertificateRequest);
                    static /*0xfefe3c*/ void grpcsharp_server_credentials_release(nint credentials);
                    static /*0xfefe40*/ Grpc.Core.Internal.ServerSafeHandle grpcsharp_server_create(Grpc.Core.Internal.ChannelArgsSafeHandle args);
                    static /*0xfefef8*/ void grpcsharp_server_register_completion_queue(Grpc.Core.Internal.ServerSafeHandle server, Grpc.Core.Internal.CompletionQueueSafeHandle cq);
                    static /*0xfeffa4*/ int grpcsharp_server_add_insecure_http2_port(Grpc.Core.Internal.ServerSafeHandle server, string addr);
                    static /*0xff0034*/ int grpcsharp_server_add_secure_http2_port(Grpc.Core.Internal.ServerSafeHandle server, string addr, Grpc.Core.Internal.ServerCredentialsSafeHandle creds);
                    static /*0xff010c*/ void grpcsharp_server_start(Grpc.Core.Internal.ServerSafeHandle server);
                    static /*0xff016c*/ Grpc.Core.Internal.CallError grpcsharp_server_request_call(Grpc.Core.Internal.ServerSafeHandle server, Grpc.Core.Internal.CompletionQueueSafeHandle cq, Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xff0274*/ void grpcsharp_server_cancel_all_calls(Grpc.Core.Internal.ServerSafeHandle server);
                    static /*0xff02d4*/ void grpcsharp_server_shutdown_and_notify_callback(Grpc.Core.Internal.ServerSafeHandle server, Grpc.Core.Internal.CompletionQueueSafeHandle cq, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xff03d4*/ void grpcsharp_server_destroy(nint server);
                    static /*0xff03d8*/ Grpc.Core.Internal.AuthContextSafeHandle grpcsharp_call_auth_context(Grpc.Core.Internal.CallSafeHandle call);
                    static /*0xff0490*/ nint grpcsharp_auth_context_peer_identity_property_name(Grpc.Core.Internal.AuthContextSafeHandle authContext);
                    static /*0xff0500*/ Grpc.Core.Internal.AuthContextSafeHandle.NativeAuthPropertyIterator grpcsharp_auth_context_property_iterator(Grpc.Core.Internal.AuthContextSafeHandle authContext);
                    static /*0xff0570*/ nint grpcsharp_auth_property_iterator_next(ref Grpc.Core.Internal.AuthContextSafeHandle.NativeAuthPropertyIterator iterator);
                    static /*0xff0574*/ void grpcsharp_auth_context_release(nint authContext);
                    static /*0xff0578*/ Grpc.Core.Internal.SliceBufferSafeHandle grpcsharp_slice_buffer_create();
                    static /*0xff05e0*/ nint grpcsharp_slice_buffer_adjust_tail_space(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer, nuint availableTailSpace, nuint requestedTailSpace);
                    static /*0xff0660*/ nuint grpcsharp_slice_buffer_slice_count(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer);
                    static /*0xff06d0*/ void grpcsharp_slice_buffer_slice_peek(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer, nuint index, ref nuint sliceLen, ref nint sliceDataPtr);
                    static /*0xff0758*/ void grpcsharp_slice_buffer_reset_and_unref(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer);
                    static /*0xff07b8*/ void grpcsharp_slice_buffer_destroy(nint sliceBuffer);
                    static /*0xff07bc*/ Grpc.Core.Internal.Timespec gprsharp_now(Grpc.Core.Internal.ClockType clockType);
                    static /*0xff07c0*/ Grpc.Core.Internal.Timespec gprsharp_inf_future(Grpc.Core.Internal.ClockType clockType);
                    static /*0xff07c4*/ Grpc.Core.Internal.Timespec gprsharp_inf_past(Grpc.Core.Internal.ClockType clockType);
                    static /*0xff07c8*/ Grpc.Core.Internal.Timespec gprsharp_convert_clock_type(Grpc.Core.Internal.Timespec t, Grpc.Core.Internal.ClockType targetClock);
                    static /*0xff07cc*/ int gprsharp_sizeof_timespec();
                    static /*0xff07d0*/ Grpc.Core.Internal.CallError grpcsharp_test_callback(Grpc.Core.Internal.NativeCallbackTestDelegate callback);
                    static /*0xff07e4*/ nint grpcsharp_test_nop(nint ptr);
                    static /*0xff07e8*/ void grpcsharp_test_override_method(string methodName, string variant);
                    static /*0xff0830*/ Grpc.Core.Internal.CallError grpcsharp_test_call_start_unary_echo(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    /*0xff099c*/ DllImportsFromStaticLib();
                }

                class DllImportsFromSharedLib
                {
                    static /*0xfcaf1c*/ void grpcsharp_init();
                    static /*0xfcaf8c*/ void grpcsharp_shutdown();
                    static /*0xfcaffc*/ nint grpcsharp_version_string();
                    static /*0xfcb070*/ Grpc.Core.Internal.BatchContextSafeHandle grpcsharp_batch_context_create();
                    static /*0xfcb130*/ nint grpcsharp_batch_context_recv_initial_metadata(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfcb1f8*/ nint grpcsharp_batch_context_recv_message_length(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfcb2c0*/ int grpcsharp_batch_context_recv_message_next_slice_peek(Grpc.Core.Internal.BatchContextSafeHandle ctx, ref nuint sliceLen, ref nint sliceDataPtr);
                    static /*0xfcb3a0*/ Grpc.Core.StatusCode grpcsharp_batch_context_recv_status_on_client_status(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfcb468*/ nint grpcsharp_batch_context_recv_status_on_client_details(Grpc.Core.Internal.BatchContextSafeHandle ctx, ref nuint detailsLength);
                    static /*0xfcb540*/ nint grpcsharp_batch_context_recv_status_on_client_error_string(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfcb608*/ nint grpcsharp_batch_context_recv_status_on_client_trailing_metadata(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfcb6d0*/ int grpcsharp_batch_context_recv_close_on_server_cancelled(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfcb798*/ void grpcsharp_batch_context_reset(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfcb858*/ void grpcsharp_batch_context_destroy(nint ctx);
                    static /*0xfcb8d8*/ Grpc.Core.Internal.RequestCallContextSafeHandle grpcsharp_request_call_context_create();
                    static /*0xfcb998*/ Grpc.Core.Internal.CallSafeHandle grpcsharp_request_call_context_call(Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xfcbaac*/ nint grpcsharp_request_call_context_method(Grpc.Core.Internal.RequestCallContextSafeHandle ctx, ref nuint methodLength);
                    static /*0xfcbb84*/ nint grpcsharp_request_call_context_host(Grpc.Core.Internal.RequestCallContextSafeHandle ctx, ref nuint hostLength);
                    static /*0xfcbc5c*/ Grpc.Core.Internal.Timespec grpcsharp_request_call_context_deadline(Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xfcbd34*/ nint grpcsharp_request_call_context_request_metadata(Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xfcbdfc*/ void grpcsharp_request_call_context_reset(Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xfcbebc*/ void grpcsharp_request_call_context_destroy(nint ctx);
                    static /*0xfcbf3c*/ Grpc.Core.Internal.CallCredentialsSafeHandle grpcsharp_composite_call_credentials_create(Grpc.Core.Internal.CallCredentialsSafeHandle creds1, Grpc.Core.Internal.CallCredentialsSafeHandle creds2);
                    static /*0xfcc094*/ void grpcsharp_call_credentials_release(nint credentials);
                    static /*0xfcc114*/ Grpc.Core.Internal.CallError grpcsharp_call_cancel(Grpc.Core.Internal.CallSafeHandle call);
                    static /*0xfcc1dc*/ Grpc.Core.Internal.CallError grpcsharp_call_cancel_with_status(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.StatusCode status, string description);
                    static /*0xfcc2dc*/ Grpc.Core.Internal.CallError grpcsharp_call_start_unary(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    static /*0xfcc4a0*/ Grpc.Core.Internal.CallError grpcsharp_call_start_client_streaming(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    static /*0xfcc610*/ Grpc.Core.Internal.CallError grpcsharp_call_start_server_streaming(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    static /*0xfcc7d4*/ Grpc.Core.Internal.CallError grpcsharp_call_start_duplex_streaming(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    static /*0xfcc944*/ Grpc.Core.Internal.CallError grpcsharp_call_send_message(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, int sendEmptyInitialMetadata);
                    static /*0xfccabc*/ Grpc.Core.Internal.CallError grpcsharp_call_send_close_from_client(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfccbd0*/ Grpc.Core.Internal.CallError grpcsharp_call_send_status_from_server(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.StatusCode statusCode, nint statusMessage, nuint statusMessageLen, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, int sendEmptyInitialMetadata, Grpc.Core.Internal.SliceBufferSafeHandle optionalSendBuffer, Grpc.Core.WriteFlags writeFlags);
                    static /*0xfccdc4*/ Grpc.Core.Internal.CallError grpcsharp_call_recv_message(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfcced8*/ Grpc.Core.Internal.CallError grpcsharp_call_recv_initial_metadata(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfccfec*/ Grpc.Core.Internal.CallError grpcsharp_call_start_serverside(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfcd100*/ Grpc.Core.Internal.CallError grpcsharp_call_send_initial_metadata(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray);
                    static /*0xfcd260*/ Grpc.Core.Internal.CallError grpcsharp_call_set_credentials(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.CallCredentialsSafeHandle credentials);
                    static /*0xfcd374*/ Grpc.Core.Internal.CStringSafeHandle grpcsharp_call_get_peer(Grpc.Core.Internal.CallSafeHandle call);
                    static /*0xfcd488*/ void grpcsharp_call_destroy(nint call);
                    static /*0xfcd508*/ Grpc.Core.Internal.ChannelArgsSafeHandle grpcsharp_channel_args_create(nuint numArgs);
                    static /*0xfcd5d4*/ void grpcsharp_channel_args_set_string(Grpc.Core.Internal.ChannelArgsSafeHandle args, nuint index, string key, string value);
                    static /*0xfcd6e8*/ void grpcsharp_channel_args_set_integer(Grpc.Core.Internal.ChannelArgsSafeHandle args, nuint index, string key, int value);
                    static /*0xfcd7e8*/ void grpcsharp_channel_args_destroy(nint args);
                    static /*0xfcd868*/ void grpcsharp_override_default_ssl_roots(string pemRootCerts);
                    static /*0xfcd8f8*/ Grpc.Core.Internal.ChannelCredentialsSafeHandle grpcsharp_ssl_credentials_create(string pemRootCerts, string keyCertPairCertChain, string keyCertPairPrivateKey, nint verifyPeerCallbackTag);
                    static /*0xfcda24*/ Grpc.Core.Internal.ChannelCredentialsSafeHandle grpcsharp_composite_channel_credentials_create(Grpc.Core.Internal.ChannelCredentialsSafeHandle channelCreds, Grpc.Core.Internal.CallCredentialsSafeHandle callCreds);
                    static /*0xfcdb7c*/ void grpcsharp_channel_credentials_release(nint credentials);
                    static /*0xfcdbfc*/ Grpc.Core.Internal.ChannelSafeHandle grpcsharp_insecure_channel_create(string target, Grpc.Core.Internal.ChannelArgsSafeHandle channelArgs);
                    static /*0xfcdd2c*/ Grpc.Core.Internal.ChannelSafeHandle grpcsharp_secure_channel_create(Grpc.Core.Internal.ChannelCredentialsSafeHandle credentials, string target, Grpc.Core.Internal.ChannelArgsSafeHandle channelArgs);
                    static /*0xfcdea8*/ Grpc.Core.Internal.CallSafeHandle grpcsharp_channel_create_call(Grpc.Core.Internal.ChannelSafeHandle channel, Grpc.Core.Internal.CallSafeHandle parentCall, Grpc.Core.Internal.ContextPropagationFlags propagationMask, Grpc.Core.Internal.CompletionQueueSafeHandle cq, string method, string host, Grpc.Core.Internal.Timespec deadline);
                    static /*0xfce0bc*/ Grpc.Core.ChannelState grpcsharp_channel_check_connectivity_state(Grpc.Core.Internal.ChannelSafeHandle channel, int tryToConnect);
                    static /*0xfce194*/ void grpcsharp_channel_watch_connectivity_state(Grpc.Core.Internal.ChannelSafeHandle channel, Grpc.Core.ChannelState lastObservedState, Grpc.Core.Internal.Timespec deadline, Grpc.Core.Internal.CompletionQueueSafeHandle cq, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfce314*/ Grpc.Core.Internal.CStringSafeHandle grpcsharp_channel_get_target(Grpc.Core.Internal.ChannelSafeHandle call);
                    static /*0xfce428*/ void grpcsharp_channel_destroy(nint channel);
                    static /*0xfce4a8*/ int grpcsharp_sizeof_grpc_event();
                    static /*0xfce51c*/ Grpc.Core.Internal.CompletionQueueSafeHandle grpcsharp_completion_queue_create_async();
                    static /*0xfce5dc*/ Grpc.Core.Internal.CompletionQueueSafeHandle grpcsharp_completion_queue_create_sync();
                    static /*0xfce69c*/ void grpcsharp_completion_queue_shutdown(Grpc.Core.Internal.CompletionQueueSafeHandle cq);
                    static /*0xfce75c*/ Grpc.Core.Internal.CompletionQueueEvent grpcsharp_completion_queue_next(Grpc.Core.Internal.CompletionQueueSafeHandle cq);
                    static /*0xfce834*/ Grpc.Core.Internal.CompletionQueueEvent grpcsharp_completion_queue_pluck(Grpc.Core.Internal.CompletionQueueSafeHandle cq, nint tag);
                    static /*0xfce914*/ void grpcsharp_completion_queue_destroy(nint cq);
                    static /*0xfce994*/ void gprsharp_free(nint ptr);
                    static /*0xfcea14*/ Grpc.Core.Internal.MetadataArraySafeHandle grpcsharp_metadata_array_create(nuint capacity);
                    static /*0xfceae0*/ void grpcsharp_metadata_array_add(Grpc.Core.Internal.MetadataArraySafeHandle array, string key, byte[] value, nuint valueLength);
                    static /*0xfcebe8*/ nuint grpcsharp_metadata_array_count(nint metadataArray);
                    static /*0xfcec68*/ nint grpcsharp_metadata_array_get_key(nint metadataArray, nuint index, ref nuint keyLength);
                    static /*0xfced00*/ nint grpcsharp_metadata_array_get_value(nint metadataArray, nuint index, ref nuint valueLength);
                    static /*0xfced98*/ void grpcsharp_metadata_array_destroy_full(nint array);
                    static /*0xfcee18*/ void grpcsharp_redirect_log(Grpc.Core.Internal.GprLogDelegate callback);
                    static /*0xfcee9c*/ void grpcsharp_native_callback_dispatcher_init(Grpc.Core.Internal.NativeCallbackDispatcherCallback dispatcher);
                    static /*0xfcef20*/ Grpc.Core.Internal.CallCredentialsSafeHandle grpcsharp_metadata_credentials_create_from_plugin(nint nativeCallbackTag);
                    static /*0xfcefec*/ void grpcsharp_metadata_credentials_notify_from_plugin(nint callbackPtr, nint userData, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.StatusCode statusCode, string errorDetails);
                    static /*0xfcf0fc*/ Grpc.Core.Internal.ServerCredentialsSafeHandle grpcsharp_ssl_server_credentials_create(string pemRootCerts, string[] keyCertPairCertChainArray, string[] keyCertPairPrivateKeyArray, nuint numKeyCertPairs, Grpc.Core.SslClientCertificateRequestType clientCertificateRequest);
                    static /*0xfcf34c*/ void grpcsharp_server_credentials_release(nint credentials);
                    static /*0xfcf3cc*/ Grpc.Core.Internal.ServerSafeHandle grpcsharp_server_create(Grpc.Core.Internal.ChannelArgsSafeHandle args);
                    static /*0xfcf4e0*/ void grpcsharp_server_register_completion_queue(Grpc.Core.Internal.ServerSafeHandle server, Grpc.Core.Internal.CompletionQueueSafeHandle cq);
                    static /*0xfcf5ec*/ int grpcsharp_server_add_insecure_http2_port(Grpc.Core.Internal.ServerSafeHandle server, string addr);
                    static /*0xfcf6dc*/ int grpcsharp_server_add_secure_http2_port(Grpc.Core.Internal.ServerSafeHandle server, string addr, Grpc.Core.Internal.ServerCredentialsSafeHandle creds);
                    static /*0xfcf814*/ void grpcsharp_server_start(Grpc.Core.Internal.ServerSafeHandle server);
                    static /*0xfcf8d4*/ Grpc.Core.Internal.CallError grpcsharp_server_request_call(Grpc.Core.Internal.ServerSafeHandle server, Grpc.Core.Internal.CompletionQueueSafeHandle cq, Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xfcfa34*/ void grpcsharp_server_cancel_all_calls(Grpc.Core.Internal.ServerSafeHandle server);
                    static /*0xfcfaf4*/ void grpcsharp_server_shutdown_and_notify_callback(Grpc.Core.Internal.ServerSafeHandle server, Grpc.Core.Internal.CompletionQueueSafeHandle cq, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfcfc4c*/ void grpcsharp_server_destroy(nint server);
                    static /*0xfcfccc*/ Grpc.Core.Internal.AuthContextSafeHandle grpcsharp_call_auth_context(Grpc.Core.Internal.CallSafeHandle call);
                    static /*0xfcfde0*/ nint grpcsharp_auth_context_peer_identity_property_name(Grpc.Core.Internal.AuthContextSafeHandle authContext);
                    static /*0xfcfea8*/ Grpc.Core.Internal.AuthContextSafeHandle.NativeAuthPropertyIterator grpcsharp_auth_context_property_iterator(Grpc.Core.Internal.AuthContextSafeHandle authContext);
                    static /*0xfcff78*/ nint grpcsharp_auth_property_iterator_next(ref Grpc.Core.Internal.AuthContextSafeHandle.NativeAuthPropertyIterator iterator);
                    static /*0xfcfff8*/ void grpcsharp_auth_context_release(nint authContext);
                    static /*0xfd0078*/ Grpc.Core.Internal.SliceBufferSafeHandle grpcsharp_slice_buffer_create();
                    static /*0xfd0138*/ nint grpcsharp_slice_buffer_adjust_tail_space(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer, nuint availableTailSpace, nuint requestedTailSpace);
                    static /*0xfd0218*/ nuint grpcsharp_slice_buffer_slice_count(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer);
                    static /*0xfd02e0*/ void grpcsharp_slice_buffer_slice_peek(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer, nuint index, ref nuint sliceLen, ref nint sliceDataPtr);
                    static /*0xfd03c8*/ void grpcsharp_slice_buffer_reset_and_unref(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer);
                    static /*0xfd0488*/ void grpcsharp_slice_buffer_destroy(nint sliceBuffer);
                    static /*0xfd0508*/ Grpc.Core.Internal.Timespec gprsharp_now(Grpc.Core.Internal.ClockType clockType);
                    static /*0xfd0588*/ Grpc.Core.Internal.Timespec gprsharp_inf_future(Grpc.Core.Internal.ClockType clockType);
                    static /*0xfd0608*/ Grpc.Core.Internal.Timespec gprsharp_inf_past(Grpc.Core.Internal.ClockType clockType);
                    static /*0xfd0688*/ Grpc.Core.Internal.Timespec gprsharp_convert_clock_type(Grpc.Core.Internal.Timespec t, Grpc.Core.Internal.ClockType targetClock);
                    static /*0xfd0720*/ int gprsharp_sizeof_timespec();
                    static /*0xfd0794*/ Grpc.Core.Internal.CallError grpcsharp_test_callback(Grpc.Core.Internal.NativeCallbackTestDelegate callback);
                    static /*0xfd0818*/ nint grpcsharp_test_nop(nint ptr);
                    static /*0xfd0898*/ void grpcsharp_test_override_method(string methodName, string variant);
                    static /*0xfd0950*/ Grpc.Core.Internal.CallError grpcsharp_test_call_start_unary_echo(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    /*0xfd0b14*/ DllImportsFromSharedLib();
                }

                class DllImportsFromSharedLib_x86
                {
                    static /*0xfe1f08*/ void grpcsharp_init();
                    static /*0xfe1f78*/ void grpcsharp_shutdown();
                    static /*0xfe1fe8*/ nint grpcsharp_version_string();
                    static /*0xfe205c*/ Grpc.Core.Internal.BatchContextSafeHandle grpcsharp_batch_context_create();
                    static /*0xfe211c*/ nint grpcsharp_batch_context_recv_initial_metadata(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfe21e4*/ nint grpcsharp_batch_context_recv_message_length(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfe22ac*/ int grpcsharp_batch_context_recv_message_next_slice_peek(Grpc.Core.Internal.BatchContextSafeHandle ctx, ref nuint sliceLen, ref nint sliceDataPtr);
                    static /*0xfe238c*/ Grpc.Core.StatusCode grpcsharp_batch_context_recv_status_on_client_status(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfe2454*/ nint grpcsharp_batch_context_recv_status_on_client_details(Grpc.Core.Internal.BatchContextSafeHandle ctx, ref nuint detailsLength);
                    static /*0xfe252c*/ nint grpcsharp_batch_context_recv_status_on_client_error_string(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfe25f4*/ nint grpcsharp_batch_context_recv_status_on_client_trailing_metadata(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfe26bc*/ int grpcsharp_batch_context_recv_close_on_server_cancelled(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfe2784*/ void grpcsharp_batch_context_reset(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfe2844*/ void grpcsharp_batch_context_destroy(nint ctx);
                    static /*0xfe28c4*/ Grpc.Core.Internal.RequestCallContextSafeHandle grpcsharp_request_call_context_create();
                    static /*0xfe2984*/ Grpc.Core.Internal.CallSafeHandle grpcsharp_request_call_context_call(Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xfe2a98*/ nint grpcsharp_request_call_context_method(Grpc.Core.Internal.RequestCallContextSafeHandle ctx, ref nuint methodLength);
                    static /*0xfe2b70*/ nint grpcsharp_request_call_context_host(Grpc.Core.Internal.RequestCallContextSafeHandle ctx, ref nuint hostLength);
                    static /*0xfe2c48*/ Grpc.Core.Internal.Timespec grpcsharp_request_call_context_deadline(Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xfe2d20*/ nint grpcsharp_request_call_context_request_metadata(Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xfe2de8*/ void grpcsharp_request_call_context_reset(Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xfe2ea8*/ void grpcsharp_request_call_context_destroy(nint ctx);
                    static /*0xfe2f28*/ Grpc.Core.Internal.CallCredentialsSafeHandle grpcsharp_composite_call_credentials_create(Grpc.Core.Internal.CallCredentialsSafeHandle creds1, Grpc.Core.Internal.CallCredentialsSafeHandle creds2);
                    static /*0xfe3080*/ void grpcsharp_call_credentials_release(nint credentials);
                    static /*0xfe3100*/ Grpc.Core.Internal.CallError grpcsharp_call_cancel(Grpc.Core.Internal.CallSafeHandle call);
                    static /*0xfe31c8*/ Grpc.Core.Internal.CallError grpcsharp_call_cancel_with_status(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.StatusCode status, string description);
                    static /*0xfe32c8*/ Grpc.Core.Internal.CallError grpcsharp_call_start_unary(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    static /*0xfe348c*/ Grpc.Core.Internal.CallError grpcsharp_call_start_client_streaming(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    static /*0xfe35fc*/ Grpc.Core.Internal.CallError grpcsharp_call_start_server_streaming(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    static /*0xfe37c0*/ Grpc.Core.Internal.CallError grpcsharp_call_start_duplex_streaming(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    static /*0xfe3930*/ Grpc.Core.Internal.CallError grpcsharp_call_send_message(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, int sendEmptyInitialMetadata);
                    static /*0xfe3aa8*/ Grpc.Core.Internal.CallError grpcsharp_call_send_close_from_client(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfe3bbc*/ Grpc.Core.Internal.CallError grpcsharp_call_send_status_from_server(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.StatusCode statusCode, nint statusMessage, nuint statusMessageLen, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, int sendEmptyInitialMetadata, Grpc.Core.Internal.SliceBufferSafeHandle optionalSendBuffer, Grpc.Core.WriteFlags writeFlags);
                    static /*0xfe3db0*/ Grpc.Core.Internal.CallError grpcsharp_call_recv_message(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfe3ec4*/ Grpc.Core.Internal.CallError grpcsharp_call_recv_initial_metadata(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfe3fd8*/ Grpc.Core.Internal.CallError grpcsharp_call_start_serverside(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfe40ec*/ Grpc.Core.Internal.CallError grpcsharp_call_send_initial_metadata(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray);
                    static /*0xfe424c*/ Grpc.Core.Internal.CallError grpcsharp_call_set_credentials(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.CallCredentialsSafeHandle credentials);
                    static /*0xfe4360*/ Grpc.Core.Internal.CStringSafeHandle grpcsharp_call_get_peer(Grpc.Core.Internal.CallSafeHandle call);
                    static /*0xfe4474*/ void grpcsharp_call_destroy(nint call);
                    static /*0xfe44f4*/ Grpc.Core.Internal.ChannelArgsSafeHandle grpcsharp_channel_args_create(nuint numArgs);
                    static /*0xfe45c0*/ void grpcsharp_channel_args_set_string(Grpc.Core.Internal.ChannelArgsSafeHandle args, nuint index, string key, string value);
                    static /*0xfe46d4*/ void grpcsharp_channel_args_set_integer(Grpc.Core.Internal.ChannelArgsSafeHandle args, nuint index, string key, int value);
                    static /*0xfe47d4*/ void grpcsharp_channel_args_destroy(nint args);
                    static /*0xfe4854*/ void grpcsharp_override_default_ssl_roots(string pemRootCerts);
                    static /*0xfe48e4*/ Grpc.Core.Internal.ChannelCredentialsSafeHandle grpcsharp_ssl_credentials_create(string pemRootCerts, string keyCertPairCertChain, string keyCertPairPrivateKey, nint verifyPeerCallbackTag);
                    static /*0xfe4a10*/ Grpc.Core.Internal.ChannelCredentialsSafeHandle grpcsharp_composite_channel_credentials_create(Grpc.Core.Internal.ChannelCredentialsSafeHandle channelCreds, Grpc.Core.Internal.CallCredentialsSafeHandle callCreds);
                    static /*0xfe4b68*/ void grpcsharp_channel_credentials_release(nint credentials);
                    static /*0xfe4be8*/ Grpc.Core.Internal.ChannelSafeHandle grpcsharp_insecure_channel_create(string target, Grpc.Core.Internal.ChannelArgsSafeHandle channelArgs);
                    static /*0xfe4d18*/ Grpc.Core.Internal.ChannelSafeHandle grpcsharp_secure_channel_create(Grpc.Core.Internal.ChannelCredentialsSafeHandle credentials, string target, Grpc.Core.Internal.ChannelArgsSafeHandle channelArgs);
                    static /*0xfe4e94*/ Grpc.Core.Internal.CallSafeHandle grpcsharp_channel_create_call(Grpc.Core.Internal.ChannelSafeHandle channel, Grpc.Core.Internal.CallSafeHandle parentCall, Grpc.Core.Internal.ContextPropagationFlags propagationMask, Grpc.Core.Internal.CompletionQueueSafeHandle cq, string method, string host, Grpc.Core.Internal.Timespec deadline);
                    static /*0xfe50a8*/ Grpc.Core.ChannelState grpcsharp_channel_check_connectivity_state(Grpc.Core.Internal.ChannelSafeHandle channel, int tryToConnect);
                    static /*0xfe5180*/ void grpcsharp_channel_watch_connectivity_state(Grpc.Core.Internal.ChannelSafeHandle channel, Grpc.Core.ChannelState lastObservedState, Grpc.Core.Internal.Timespec deadline, Grpc.Core.Internal.CompletionQueueSafeHandle cq, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfe5300*/ Grpc.Core.Internal.CStringSafeHandle grpcsharp_channel_get_target(Grpc.Core.Internal.ChannelSafeHandle call);
                    static /*0xfe5414*/ void grpcsharp_channel_destroy(nint channel);
                    static /*0xfe5494*/ int grpcsharp_sizeof_grpc_event();
                    static /*0xfe5508*/ Grpc.Core.Internal.CompletionQueueSafeHandle grpcsharp_completion_queue_create_async();
                    static /*0xfe55c8*/ Grpc.Core.Internal.CompletionQueueSafeHandle grpcsharp_completion_queue_create_sync();
                    static /*0xfe5688*/ void grpcsharp_completion_queue_shutdown(Grpc.Core.Internal.CompletionQueueSafeHandle cq);
                    static /*0xfe5748*/ Grpc.Core.Internal.CompletionQueueEvent grpcsharp_completion_queue_next(Grpc.Core.Internal.CompletionQueueSafeHandle cq);
                    static /*0xfe5820*/ Grpc.Core.Internal.CompletionQueueEvent grpcsharp_completion_queue_pluck(Grpc.Core.Internal.CompletionQueueSafeHandle cq, nint tag);
                    static /*0xfe5900*/ void grpcsharp_completion_queue_destroy(nint cq);
                    static /*0xfe5980*/ void gprsharp_free(nint ptr);
                    static /*0xfe5a00*/ Grpc.Core.Internal.MetadataArraySafeHandle grpcsharp_metadata_array_create(nuint capacity);
                    static /*0xfe5acc*/ void grpcsharp_metadata_array_add(Grpc.Core.Internal.MetadataArraySafeHandle array, string key, byte[] value, nuint valueLength);
                    static /*0xfe5bd4*/ nuint grpcsharp_metadata_array_count(nint metadataArray);
                    static /*0xfe5c54*/ nint grpcsharp_metadata_array_get_key(nint metadataArray, nuint index, ref nuint keyLength);
                    static /*0xfe5cec*/ nint grpcsharp_metadata_array_get_value(nint metadataArray, nuint index, ref nuint valueLength);
                    static /*0xfe5d84*/ void grpcsharp_metadata_array_destroy_full(nint array);
                    static /*0xfe5e04*/ void grpcsharp_redirect_log(Grpc.Core.Internal.GprLogDelegate callback);
                    static /*0xfe5e88*/ void grpcsharp_native_callback_dispatcher_init(Grpc.Core.Internal.NativeCallbackDispatcherCallback dispatcher);
                    static /*0xfe5f0c*/ Grpc.Core.Internal.CallCredentialsSafeHandle grpcsharp_metadata_credentials_create_from_plugin(nint nativeCallbackTag);
                    static /*0xfe5fd8*/ void grpcsharp_metadata_credentials_notify_from_plugin(nint callbackPtr, nint userData, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.StatusCode statusCode, string errorDetails);
                    static /*0xfe60e8*/ Grpc.Core.Internal.ServerCredentialsSafeHandle grpcsharp_ssl_server_credentials_create(string pemRootCerts, string[] keyCertPairCertChainArray, string[] keyCertPairPrivateKeyArray, nuint numKeyCertPairs, Grpc.Core.SslClientCertificateRequestType clientCertificateRequest);
                    static /*0xfe6338*/ void grpcsharp_server_credentials_release(nint credentials);
                    static /*0xfe63b8*/ Grpc.Core.Internal.ServerSafeHandle grpcsharp_server_create(Grpc.Core.Internal.ChannelArgsSafeHandle args);
                    static /*0xfe64cc*/ void grpcsharp_server_register_completion_queue(Grpc.Core.Internal.ServerSafeHandle server, Grpc.Core.Internal.CompletionQueueSafeHandle cq);
                    static /*0xfe65d8*/ int grpcsharp_server_add_insecure_http2_port(Grpc.Core.Internal.ServerSafeHandle server, string addr);
                    static /*0xfe66c8*/ int grpcsharp_server_add_secure_http2_port(Grpc.Core.Internal.ServerSafeHandle server, string addr, Grpc.Core.Internal.ServerCredentialsSafeHandle creds);
                    static /*0xfe6800*/ void grpcsharp_server_start(Grpc.Core.Internal.ServerSafeHandle server);
                    static /*0xfe68c0*/ Grpc.Core.Internal.CallError grpcsharp_server_request_call(Grpc.Core.Internal.ServerSafeHandle server, Grpc.Core.Internal.CompletionQueueSafeHandle cq, Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xfe6a20*/ void grpcsharp_server_cancel_all_calls(Grpc.Core.Internal.ServerSafeHandle server);
                    static /*0xfe6ae0*/ void grpcsharp_server_shutdown_and_notify_callback(Grpc.Core.Internal.ServerSafeHandle server, Grpc.Core.Internal.CompletionQueueSafeHandle cq, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfe6c38*/ void grpcsharp_server_destroy(nint server);
                    static /*0xfe6cb8*/ Grpc.Core.Internal.AuthContextSafeHandle grpcsharp_call_auth_context(Grpc.Core.Internal.CallSafeHandle call);
                    static /*0xfe6dcc*/ nint grpcsharp_auth_context_peer_identity_property_name(Grpc.Core.Internal.AuthContextSafeHandle authContext);
                    static /*0xfe6e94*/ Grpc.Core.Internal.AuthContextSafeHandle.NativeAuthPropertyIterator grpcsharp_auth_context_property_iterator(Grpc.Core.Internal.AuthContextSafeHandle authContext);
                    static /*0xfe6f64*/ nint grpcsharp_auth_property_iterator_next(ref Grpc.Core.Internal.AuthContextSafeHandle.NativeAuthPropertyIterator iterator);
                    static /*0xfe6fe4*/ void grpcsharp_auth_context_release(nint authContext);
                    static /*0xfe7064*/ Grpc.Core.Internal.SliceBufferSafeHandle grpcsharp_slice_buffer_create();
                    static /*0xfe7124*/ nint grpcsharp_slice_buffer_adjust_tail_space(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer, nuint availableTailSpace, nuint requestedTailSpace);
                    static /*0xfe7204*/ nuint grpcsharp_slice_buffer_slice_count(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer);
                    static /*0xfe72cc*/ void grpcsharp_slice_buffer_slice_peek(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer, nuint index, ref nuint sliceLen, ref nint sliceDataPtr);
                    static /*0xfe73b4*/ void grpcsharp_slice_buffer_reset_and_unref(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer);
                    static /*0xfe7474*/ void grpcsharp_slice_buffer_destroy(nint sliceBuffer);
                    static /*0xfe74f4*/ Grpc.Core.Internal.Timespec gprsharp_now(Grpc.Core.Internal.ClockType clockType);
                    static /*0xfe7574*/ Grpc.Core.Internal.Timespec gprsharp_inf_future(Grpc.Core.Internal.ClockType clockType);
                    static /*0xfe75f0*/ Grpc.Core.Internal.Timespec gprsharp_inf_past(Grpc.Core.Internal.ClockType clockType);
                    static /*0xfe7670*/ Grpc.Core.Internal.Timespec gprsharp_convert_clock_type(Grpc.Core.Internal.Timespec t, Grpc.Core.Internal.ClockType targetClock);
                    static /*0xfe7708*/ int gprsharp_sizeof_timespec();
                    static /*0xfe777c*/ Grpc.Core.Internal.CallError grpcsharp_test_callback(Grpc.Core.Internal.NativeCallbackTestDelegate callback);
                    static /*0xfe7800*/ nint grpcsharp_test_nop(nint ptr);
                    static /*0xfe7880*/ void grpcsharp_test_override_method(string methodName, string variant);
                    static /*0xfe7938*/ Grpc.Core.Internal.CallError grpcsharp_test_call_start_unary_echo(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    /*0xfe7afc*/ DllImportsFromSharedLib_x86();
                }

                class DllImportsFromSharedLib_x64
                {
                    static /*0xfd6718*/ void grpcsharp_init();
                    static /*0xfd6788*/ void grpcsharp_shutdown();
                    static /*0xfd67f8*/ nint grpcsharp_version_string();
                    static /*0xfd686c*/ Grpc.Core.Internal.BatchContextSafeHandle grpcsharp_batch_context_create();
                    static /*0xfd692c*/ nint grpcsharp_batch_context_recv_initial_metadata(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfd69f4*/ nint grpcsharp_batch_context_recv_message_length(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfd6abc*/ int grpcsharp_batch_context_recv_message_next_slice_peek(Grpc.Core.Internal.BatchContextSafeHandle ctx, ref nuint sliceLen, ref nint sliceDataPtr);
                    static /*0xfd6b9c*/ Grpc.Core.StatusCode grpcsharp_batch_context_recv_status_on_client_status(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfd6c64*/ nint grpcsharp_batch_context_recv_status_on_client_details(Grpc.Core.Internal.BatchContextSafeHandle ctx, ref nuint detailsLength);
                    static /*0xfd6d3c*/ nint grpcsharp_batch_context_recv_status_on_client_error_string(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfd6e04*/ nint grpcsharp_batch_context_recv_status_on_client_trailing_metadata(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfd6ecc*/ int grpcsharp_batch_context_recv_close_on_server_cancelled(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfd6f94*/ void grpcsharp_batch_context_reset(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfd7054*/ void grpcsharp_batch_context_destroy(nint ctx);
                    static /*0xfd70d4*/ Grpc.Core.Internal.RequestCallContextSafeHandle grpcsharp_request_call_context_create();
                    static /*0xfd7194*/ Grpc.Core.Internal.CallSafeHandle grpcsharp_request_call_context_call(Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xfd72a8*/ nint grpcsharp_request_call_context_method(Grpc.Core.Internal.RequestCallContextSafeHandle ctx, ref nuint methodLength);
                    static /*0xfd7380*/ nint grpcsharp_request_call_context_host(Grpc.Core.Internal.RequestCallContextSafeHandle ctx, ref nuint hostLength);
                    static /*0xfd7458*/ Grpc.Core.Internal.Timespec grpcsharp_request_call_context_deadline(Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xfd7530*/ nint grpcsharp_request_call_context_request_metadata(Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xfd75f8*/ void grpcsharp_request_call_context_reset(Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xfd76b8*/ void grpcsharp_request_call_context_destroy(nint ctx);
                    static /*0xfd7738*/ Grpc.Core.Internal.CallCredentialsSafeHandle grpcsharp_composite_call_credentials_create(Grpc.Core.Internal.CallCredentialsSafeHandle creds1, Grpc.Core.Internal.CallCredentialsSafeHandle creds2);
                    static /*0xfd7890*/ void grpcsharp_call_credentials_release(nint credentials);
                    static /*0xfd7910*/ Grpc.Core.Internal.CallError grpcsharp_call_cancel(Grpc.Core.Internal.CallSafeHandle call);
                    static /*0xfd79d8*/ Grpc.Core.Internal.CallError grpcsharp_call_cancel_with_status(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.StatusCode status, string description);
                    static /*0xfd7ad8*/ Grpc.Core.Internal.CallError grpcsharp_call_start_unary(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    static /*0xfd7c9c*/ Grpc.Core.Internal.CallError grpcsharp_call_start_client_streaming(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    static /*0xfd7e0c*/ Grpc.Core.Internal.CallError grpcsharp_call_start_server_streaming(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    static /*0xfd7fd0*/ Grpc.Core.Internal.CallError grpcsharp_call_start_duplex_streaming(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    static /*0xfd8140*/ Grpc.Core.Internal.CallError grpcsharp_call_send_message(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, int sendEmptyInitialMetadata);
                    static /*0xfd82b8*/ Grpc.Core.Internal.CallError grpcsharp_call_send_close_from_client(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfd83cc*/ Grpc.Core.Internal.CallError grpcsharp_call_send_status_from_server(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.StatusCode statusCode, nint statusMessage, nuint statusMessageLen, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, int sendEmptyInitialMetadata, Grpc.Core.Internal.SliceBufferSafeHandle optionalSendBuffer, Grpc.Core.WriteFlags writeFlags);
                    static /*0xfd85c0*/ Grpc.Core.Internal.CallError grpcsharp_call_recv_message(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfd86d4*/ Grpc.Core.Internal.CallError grpcsharp_call_recv_initial_metadata(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfd87e8*/ Grpc.Core.Internal.CallError grpcsharp_call_start_serverside(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfd88fc*/ Grpc.Core.Internal.CallError grpcsharp_call_send_initial_metadata(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray);
                    static /*0xfd8a5c*/ Grpc.Core.Internal.CallError grpcsharp_call_set_credentials(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.CallCredentialsSafeHandle credentials);
                    static /*0xfd8b70*/ Grpc.Core.Internal.CStringSafeHandle grpcsharp_call_get_peer(Grpc.Core.Internal.CallSafeHandle call);
                    static /*0xfd8c84*/ void grpcsharp_call_destroy(nint call);
                    static /*0xfd8d04*/ Grpc.Core.Internal.ChannelArgsSafeHandle grpcsharp_channel_args_create(nuint numArgs);
                    static /*0xfd8dd0*/ void grpcsharp_channel_args_set_string(Grpc.Core.Internal.ChannelArgsSafeHandle args, nuint index, string key, string value);
                    static /*0xfd8ee4*/ void grpcsharp_channel_args_set_integer(Grpc.Core.Internal.ChannelArgsSafeHandle args, nuint index, string key, int value);
                    static /*0xfd8fe4*/ void grpcsharp_channel_args_destroy(nint args);
                    static /*0xfd9064*/ void grpcsharp_override_default_ssl_roots(string pemRootCerts);
                    static /*0xfd90f4*/ Grpc.Core.Internal.ChannelCredentialsSafeHandle grpcsharp_ssl_credentials_create(string pemRootCerts, string keyCertPairCertChain, string keyCertPairPrivateKey, nint verifyPeerCallbackTag);
                    static /*0xfd9220*/ Grpc.Core.Internal.ChannelCredentialsSafeHandle grpcsharp_composite_channel_credentials_create(Grpc.Core.Internal.ChannelCredentialsSafeHandle channelCreds, Grpc.Core.Internal.CallCredentialsSafeHandle callCreds);
                    static /*0xfd9378*/ void grpcsharp_channel_credentials_release(nint credentials);
                    static /*0xfd93f8*/ Grpc.Core.Internal.ChannelSafeHandle grpcsharp_insecure_channel_create(string target, Grpc.Core.Internal.ChannelArgsSafeHandle channelArgs);
                    static /*0xfd9528*/ Grpc.Core.Internal.ChannelSafeHandle grpcsharp_secure_channel_create(Grpc.Core.Internal.ChannelCredentialsSafeHandle credentials, string target, Grpc.Core.Internal.ChannelArgsSafeHandle channelArgs);
                    static /*0xfd96a4*/ Grpc.Core.Internal.CallSafeHandle grpcsharp_channel_create_call(Grpc.Core.Internal.ChannelSafeHandle channel, Grpc.Core.Internal.CallSafeHandle parentCall, Grpc.Core.Internal.ContextPropagationFlags propagationMask, Grpc.Core.Internal.CompletionQueueSafeHandle cq, string method, string host, Grpc.Core.Internal.Timespec deadline);
                    static /*0xfd98b8*/ Grpc.Core.ChannelState grpcsharp_channel_check_connectivity_state(Grpc.Core.Internal.ChannelSafeHandle channel, int tryToConnect);
                    static /*0xfd9990*/ void grpcsharp_channel_watch_connectivity_state(Grpc.Core.Internal.ChannelSafeHandle channel, Grpc.Core.ChannelState lastObservedState, Grpc.Core.Internal.Timespec deadline, Grpc.Core.Internal.CompletionQueueSafeHandle cq, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfd9b10*/ Grpc.Core.Internal.CStringSafeHandle grpcsharp_channel_get_target(Grpc.Core.Internal.ChannelSafeHandle call);
                    static /*0xfd9c24*/ void grpcsharp_channel_destroy(nint channel);
                    static /*0xfd9ca4*/ int grpcsharp_sizeof_grpc_event();
                    static /*0xfd9d18*/ Grpc.Core.Internal.CompletionQueueSafeHandle grpcsharp_completion_queue_create_async();
                    static /*0xfd9dd8*/ Grpc.Core.Internal.CompletionQueueSafeHandle grpcsharp_completion_queue_create_sync();
                    static /*0xfd9e98*/ void grpcsharp_completion_queue_shutdown(Grpc.Core.Internal.CompletionQueueSafeHandle cq);
                    static /*0xfd9f58*/ Grpc.Core.Internal.CompletionQueueEvent grpcsharp_completion_queue_next(Grpc.Core.Internal.CompletionQueueSafeHandle cq);
                    static /*0xfda030*/ Grpc.Core.Internal.CompletionQueueEvent grpcsharp_completion_queue_pluck(Grpc.Core.Internal.CompletionQueueSafeHandle cq, nint tag);
                    static /*0xfda110*/ void grpcsharp_completion_queue_destroy(nint cq);
                    static /*0xfda190*/ void gprsharp_free(nint ptr);
                    static /*0xfda210*/ Grpc.Core.Internal.MetadataArraySafeHandle grpcsharp_metadata_array_create(nuint capacity);
                    static /*0xfda2dc*/ void grpcsharp_metadata_array_add(Grpc.Core.Internal.MetadataArraySafeHandle array, string key, byte[] value, nuint valueLength);
                    static /*0xfda3e4*/ nuint grpcsharp_metadata_array_count(nint metadataArray);
                    static /*0xfda464*/ nint grpcsharp_metadata_array_get_key(nint metadataArray, nuint index, ref nuint keyLength);
                    static /*0xfda4fc*/ nint grpcsharp_metadata_array_get_value(nint metadataArray, nuint index, ref nuint valueLength);
                    static /*0xfda594*/ void grpcsharp_metadata_array_destroy_full(nint array);
                    static /*0xfda614*/ void grpcsharp_redirect_log(Grpc.Core.Internal.GprLogDelegate callback);
                    static /*0xfda698*/ void grpcsharp_native_callback_dispatcher_init(Grpc.Core.Internal.NativeCallbackDispatcherCallback dispatcher);
                    static /*0xfda71c*/ Grpc.Core.Internal.CallCredentialsSafeHandle grpcsharp_metadata_credentials_create_from_plugin(nint nativeCallbackTag);
                    static /*0xfda7e8*/ void grpcsharp_metadata_credentials_notify_from_plugin(nint callbackPtr, nint userData, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.StatusCode statusCode, string errorDetails);
                    static /*0xfda8f8*/ Grpc.Core.Internal.ServerCredentialsSafeHandle grpcsharp_ssl_server_credentials_create(string pemRootCerts, string[] keyCertPairCertChainArray, string[] keyCertPairPrivateKeyArray, nuint numKeyCertPairs, Grpc.Core.SslClientCertificateRequestType clientCertificateRequest);
                    static /*0xfdab48*/ void grpcsharp_server_credentials_release(nint credentials);
                    static /*0xfdabc8*/ Grpc.Core.Internal.ServerSafeHandle grpcsharp_server_create(Grpc.Core.Internal.ChannelArgsSafeHandle args);
                    static /*0xfdacdc*/ void grpcsharp_server_register_completion_queue(Grpc.Core.Internal.ServerSafeHandle server, Grpc.Core.Internal.CompletionQueueSafeHandle cq);
                    static /*0xfdade8*/ int grpcsharp_server_add_insecure_http2_port(Grpc.Core.Internal.ServerSafeHandle server, string addr);
                    static /*0xfdaed8*/ int grpcsharp_server_add_secure_http2_port(Grpc.Core.Internal.ServerSafeHandle server, string addr, Grpc.Core.Internal.ServerCredentialsSafeHandle creds);
                    static /*0xfdb010*/ void grpcsharp_server_start(Grpc.Core.Internal.ServerSafeHandle server);
                    static /*0xfdb0d0*/ Grpc.Core.Internal.CallError grpcsharp_server_request_call(Grpc.Core.Internal.ServerSafeHandle server, Grpc.Core.Internal.CompletionQueueSafeHandle cq, Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xfdb230*/ void grpcsharp_server_cancel_all_calls(Grpc.Core.Internal.ServerSafeHandle server);
                    static /*0xfdb2f0*/ void grpcsharp_server_shutdown_and_notify_callback(Grpc.Core.Internal.ServerSafeHandle server, Grpc.Core.Internal.CompletionQueueSafeHandle cq, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfdb448*/ void grpcsharp_server_destroy(nint server);
                    static /*0xfdb4c8*/ Grpc.Core.Internal.AuthContextSafeHandle grpcsharp_call_auth_context(Grpc.Core.Internal.CallSafeHandle call);
                    static /*0xfdb5dc*/ nint grpcsharp_auth_context_peer_identity_property_name(Grpc.Core.Internal.AuthContextSafeHandle authContext);
                    static /*0xfdb6a4*/ Grpc.Core.Internal.AuthContextSafeHandle.NativeAuthPropertyIterator grpcsharp_auth_context_property_iterator(Grpc.Core.Internal.AuthContextSafeHandle authContext);
                    static /*0xfdb774*/ nint grpcsharp_auth_property_iterator_next(ref Grpc.Core.Internal.AuthContextSafeHandle.NativeAuthPropertyIterator iterator);
                    static /*0xfdb7f4*/ void grpcsharp_auth_context_release(nint authContext);
                    static /*0xfdb874*/ Grpc.Core.Internal.SliceBufferSafeHandle grpcsharp_slice_buffer_create();
                    static /*0xfdb934*/ nint grpcsharp_slice_buffer_adjust_tail_space(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer, nuint availableTailSpace, nuint requestedTailSpace);
                    static /*0xfdba14*/ nuint grpcsharp_slice_buffer_slice_count(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer);
                    static /*0xfdbadc*/ void grpcsharp_slice_buffer_slice_peek(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer, nuint index, ref nuint sliceLen, ref nint sliceDataPtr);
                    static /*0xfdbbc4*/ void grpcsharp_slice_buffer_reset_and_unref(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer);
                    static /*0xfdbc84*/ void grpcsharp_slice_buffer_destroy(nint sliceBuffer);
                    static /*0xfdbd04*/ Grpc.Core.Internal.Timespec gprsharp_now(Grpc.Core.Internal.ClockType clockType);
                    static /*0xfdbd84*/ Grpc.Core.Internal.Timespec gprsharp_inf_future(Grpc.Core.Internal.ClockType clockType);
                    static /*0xfdbe00*/ Grpc.Core.Internal.Timespec gprsharp_inf_past(Grpc.Core.Internal.ClockType clockType);
                    static /*0xfdbe80*/ Grpc.Core.Internal.Timespec gprsharp_convert_clock_type(Grpc.Core.Internal.Timespec t, Grpc.Core.Internal.ClockType targetClock);
                    static /*0xfdbf18*/ int gprsharp_sizeof_timespec();
                    static /*0xfdbf8c*/ Grpc.Core.Internal.CallError grpcsharp_test_callback(Grpc.Core.Internal.NativeCallbackTestDelegate callback);
                    static /*0xfdc010*/ nint grpcsharp_test_nop(nint ptr);
                    static /*0xfdc090*/ void grpcsharp_test_override_method(string methodName, string variant);
                    static /*0xfdc148*/ Grpc.Core.Internal.CallError grpcsharp_test_call_start_unary_echo(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    /*0xfdc30c*/ DllImportsFromSharedLib_x64();
                }

                class DllImportsFromSharedLib_arm64
                {
                    static /*0xfd0b1c*/ void grpcsharp_init();
                    static /*0xfd0b8c*/ void grpcsharp_shutdown();
                    static /*0xfd0bfc*/ nint grpcsharp_version_string();
                    static /*0xfd0c70*/ Grpc.Core.Internal.BatchContextSafeHandle grpcsharp_batch_context_create();
                    static /*0xfd0d30*/ nint grpcsharp_batch_context_recv_initial_metadata(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfd0df8*/ nint grpcsharp_batch_context_recv_message_length(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfd0ec0*/ int grpcsharp_batch_context_recv_message_next_slice_peek(Grpc.Core.Internal.BatchContextSafeHandle ctx, ref nuint sliceLen, ref nint sliceDataPtr);
                    static /*0xfd0fa0*/ Grpc.Core.StatusCode grpcsharp_batch_context_recv_status_on_client_status(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfd1068*/ nint grpcsharp_batch_context_recv_status_on_client_details(Grpc.Core.Internal.BatchContextSafeHandle ctx, ref nuint detailsLength);
                    static /*0xfd1140*/ nint grpcsharp_batch_context_recv_status_on_client_error_string(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfd1208*/ nint grpcsharp_batch_context_recv_status_on_client_trailing_metadata(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfd12d0*/ int grpcsharp_batch_context_recv_close_on_server_cancelled(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfd1398*/ void grpcsharp_batch_context_reset(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfd1458*/ void grpcsharp_batch_context_destroy(nint ctx);
                    static /*0xfd14d8*/ Grpc.Core.Internal.RequestCallContextSafeHandle grpcsharp_request_call_context_create();
                    static /*0xfd1598*/ Grpc.Core.Internal.CallSafeHandle grpcsharp_request_call_context_call(Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xfd16ac*/ nint grpcsharp_request_call_context_method(Grpc.Core.Internal.RequestCallContextSafeHandle ctx, ref nuint methodLength);
                    static /*0xfd1784*/ nint grpcsharp_request_call_context_host(Grpc.Core.Internal.RequestCallContextSafeHandle ctx, ref nuint hostLength);
                    static /*0xfd185c*/ Grpc.Core.Internal.Timespec grpcsharp_request_call_context_deadline(Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xfd1934*/ nint grpcsharp_request_call_context_request_metadata(Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xfd19fc*/ void grpcsharp_request_call_context_reset(Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xfd1abc*/ void grpcsharp_request_call_context_destroy(nint ctx);
                    static /*0xfd1b3c*/ Grpc.Core.Internal.CallCredentialsSafeHandle grpcsharp_composite_call_credentials_create(Grpc.Core.Internal.CallCredentialsSafeHandle creds1, Grpc.Core.Internal.CallCredentialsSafeHandle creds2);
                    static /*0xfd1c94*/ void grpcsharp_call_credentials_release(nint credentials);
                    static /*0xfd1d14*/ Grpc.Core.Internal.CallError grpcsharp_call_cancel(Grpc.Core.Internal.CallSafeHandle call);
                    static /*0xfd1dd8*/ Grpc.Core.Internal.CallError grpcsharp_call_cancel_with_status(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.StatusCode status, string description);
                    static /*0xfd1ed8*/ Grpc.Core.Internal.CallError grpcsharp_call_start_unary(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    static /*0xfd209c*/ Grpc.Core.Internal.CallError grpcsharp_call_start_client_streaming(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    static /*0xfd220c*/ Grpc.Core.Internal.CallError grpcsharp_call_start_server_streaming(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    static /*0xfd23d0*/ Grpc.Core.Internal.CallError grpcsharp_call_start_duplex_streaming(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    static /*0xfd2540*/ Grpc.Core.Internal.CallError grpcsharp_call_send_message(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, int sendEmptyInitialMetadata);
                    static /*0xfd26b8*/ Grpc.Core.Internal.CallError grpcsharp_call_send_close_from_client(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfd27cc*/ Grpc.Core.Internal.CallError grpcsharp_call_send_status_from_server(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.StatusCode statusCode, nint statusMessage, nuint statusMessageLen, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, int sendEmptyInitialMetadata, Grpc.Core.Internal.SliceBufferSafeHandle optionalSendBuffer, Grpc.Core.WriteFlags writeFlags);
                    static /*0xfd29c0*/ Grpc.Core.Internal.CallError grpcsharp_call_recv_message(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfd2ad4*/ Grpc.Core.Internal.CallError grpcsharp_call_recv_initial_metadata(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfd2be8*/ Grpc.Core.Internal.CallError grpcsharp_call_start_serverside(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfd2cfc*/ Grpc.Core.Internal.CallError grpcsharp_call_send_initial_metadata(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray);
                    static /*0xfd2e5c*/ Grpc.Core.Internal.CallError grpcsharp_call_set_credentials(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.CallCredentialsSafeHandle credentials);
                    static /*0xfd2f70*/ Grpc.Core.Internal.CStringSafeHandle grpcsharp_call_get_peer(Grpc.Core.Internal.CallSafeHandle call);
                    static /*0xfd3084*/ void grpcsharp_call_destroy(nint call);
                    static /*0xfd3104*/ Grpc.Core.Internal.ChannelArgsSafeHandle grpcsharp_channel_args_create(nuint numArgs);
                    static /*0xfd31d0*/ void grpcsharp_channel_args_set_string(Grpc.Core.Internal.ChannelArgsSafeHandle args, nuint index, string key, string value);
                    static /*0xfd32e4*/ void grpcsharp_channel_args_set_integer(Grpc.Core.Internal.ChannelArgsSafeHandle args, nuint index, string key, int value);
                    static /*0xfd33e4*/ void grpcsharp_channel_args_destroy(nint args);
                    static /*0xfd3464*/ void grpcsharp_override_default_ssl_roots(string pemRootCerts);
                    static /*0xfd34f4*/ Grpc.Core.Internal.ChannelCredentialsSafeHandle grpcsharp_ssl_credentials_create(string pemRootCerts, string keyCertPairCertChain, string keyCertPairPrivateKey, nint verifyPeerCallbackTag);
                    static /*0xfd3620*/ Grpc.Core.Internal.ChannelCredentialsSafeHandle grpcsharp_composite_channel_credentials_create(Grpc.Core.Internal.ChannelCredentialsSafeHandle channelCreds, Grpc.Core.Internal.CallCredentialsSafeHandle callCreds);
                    static /*0xfd3778*/ void grpcsharp_channel_credentials_release(nint credentials);
                    static /*0xfd37f8*/ Grpc.Core.Internal.ChannelSafeHandle grpcsharp_insecure_channel_create(string target, Grpc.Core.Internal.ChannelArgsSafeHandle channelArgs);
                    static /*0xfd3928*/ Grpc.Core.Internal.ChannelSafeHandle grpcsharp_secure_channel_create(Grpc.Core.Internal.ChannelCredentialsSafeHandle credentials, string target, Grpc.Core.Internal.ChannelArgsSafeHandle channelArgs);
                    static /*0xfd3aa4*/ Grpc.Core.Internal.CallSafeHandle grpcsharp_channel_create_call(Grpc.Core.Internal.ChannelSafeHandle channel, Grpc.Core.Internal.CallSafeHandle parentCall, Grpc.Core.Internal.ContextPropagationFlags propagationMask, Grpc.Core.Internal.CompletionQueueSafeHandle cq, string method, string host, Grpc.Core.Internal.Timespec deadline);
                    static /*0xfd3cb8*/ Grpc.Core.ChannelState grpcsharp_channel_check_connectivity_state(Grpc.Core.Internal.ChannelSafeHandle channel, int tryToConnect);
                    static /*0xfd3d90*/ void grpcsharp_channel_watch_connectivity_state(Grpc.Core.Internal.ChannelSafeHandle channel, Grpc.Core.ChannelState lastObservedState, Grpc.Core.Internal.Timespec deadline, Grpc.Core.Internal.CompletionQueueSafeHandle cq, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfd3f10*/ Grpc.Core.Internal.CStringSafeHandle grpcsharp_channel_get_target(Grpc.Core.Internal.ChannelSafeHandle call);
                    static /*0xfd4024*/ void grpcsharp_channel_destroy(nint channel);
                    static /*0xfd40a4*/ int grpcsharp_sizeof_grpc_event();
                    static /*0xfd4118*/ Grpc.Core.Internal.CompletionQueueSafeHandle grpcsharp_completion_queue_create_async();
                    static /*0xfd41d8*/ Grpc.Core.Internal.CompletionQueueSafeHandle grpcsharp_completion_queue_create_sync();
                    static /*0xfd4298*/ void grpcsharp_completion_queue_shutdown(Grpc.Core.Internal.CompletionQueueSafeHandle cq);
                    static /*0xfd4358*/ Grpc.Core.Internal.CompletionQueueEvent grpcsharp_completion_queue_next(Grpc.Core.Internal.CompletionQueueSafeHandle cq);
                    static /*0xfd4430*/ Grpc.Core.Internal.CompletionQueueEvent grpcsharp_completion_queue_pluck(Grpc.Core.Internal.CompletionQueueSafeHandle cq, nint tag);
                    static /*0xfd4510*/ void grpcsharp_completion_queue_destroy(nint cq);
                    static /*0xfd4590*/ void gprsharp_free(nint ptr);
                    static /*0xfd4610*/ Grpc.Core.Internal.MetadataArraySafeHandle grpcsharp_metadata_array_create(nuint capacity);
                    static /*0xfd46dc*/ void grpcsharp_metadata_array_add(Grpc.Core.Internal.MetadataArraySafeHandle array, string key, byte[] value, nuint valueLength);
                    static /*0xfd47e4*/ nuint grpcsharp_metadata_array_count(nint metadataArray);
                    static /*0xfd4864*/ nint grpcsharp_metadata_array_get_key(nint metadataArray, nuint index, ref nuint keyLength);
                    static /*0xfd48fc*/ nint grpcsharp_metadata_array_get_value(nint metadataArray, nuint index, ref nuint valueLength);
                    static /*0xfd4994*/ void grpcsharp_metadata_array_destroy_full(nint array);
                    static /*0xfd4a14*/ void grpcsharp_redirect_log(Grpc.Core.Internal.GprLogDelegate callback);
                    static /*0xfd4a98*/ void grpcsharp_native_callback_dispatcher_init(Grpc.Core.Internal.NativeCallbackDispatcherCallback dispatcher);
                    static /*0xfd4b1c*/ Grpc.Core.Internal.CallCredentialsSafeHandle grpcsharp_metadata_credentials_create_from_plugin(nint nativeCallbackTag);
                    static /*0xfd4be8*/ void grpcsharp_metadata_credentials_notify_from_plugin(nint callbackPtr, nint userData, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.StatusCode statusCode, string errorDetails);
                    static /*0xfd4cf8*/ Grpc.Core.Internal.ServerCredentialsSafeHandle grpcsharp_ssl_server_credentials_create(string pemRootCerts, string[] keyCertPairCertChainArray, string[] keyCertPairPrivateKeyArray, nuint numKeyCertPairs, Grpc.Core.SslClientCertificateRequestType clientCertificateRequest);
                    static /*0xfd4f48*/ void grpcsharp_server_credentials_release(nint credentials);
                    static /*0xfd4fc8*/ Grpc.Core.Internal.ServerSafeHandle grpcsharp_server_create(Grpc.Core.Internal.ChannelArgsSafeHandle args);
                    static /*0xfd50dc*/ void grpcsharp_server_register_completion_queue(Grpc.Core.Internal.ServerSafeHandle server, Grpc.Core.Internal.CompletionQueueSafeHandle cq);
                    static /*0xfd51e8*/ int grpcsharp_server_add_insecure_http2_port(Grpc.Core.Internal.ServerSafeHandle server, string addr);
                    static /*0xfd52d8*/ int grpcsharp_server_add_secure_http2_port(Grpc.Core.Internal.ServerSafeHandle server, string addr, Grpc.Core.Internal.ServerCredentialsSafeHandle creds);
                    static /*0xfd5410*/ void grpcsharp_server_start(Grpc.Core.Internal.ServerSafeHandle server);
                    static /*0xfd54d0*/ Grpc.Core.Internal.CallError grpcsharp_server_request_call(Grpc.Core.Internal.ServerSafeHandle server, Grpc.Core.Internal.CompletionQueueSafeHandle cq, Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xfd5630*/ void grpcsharp_server_cancel_all_calls(Grpc.Core.Internal.ServerSafeHandle server);
                    static /*0xfd56f0*/ void grpcsharp_server_shutdown_and_notify_callback(Grpc.Core.Internal.ServerSafeHandle server, Grpc.Core.Internal.CompletionQueueSafeHandle cq, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfd5848*/ void grpcsharp_server_destroy(nint server);
                    static /*0xfd58c8*/ Grpc.Core.Internal.AuthContextSafeHandle grpcsharp_call_auth_context(Grpc.Core.Internal.CallSafeHandle call);
                    static /*0xfd59dc*/ nint grpcsharp_auth_context_peer_identity_property_name(Grpc.Core.Internal.AuthContextSafeHandle authContext);
                    static /*0xfd5aa4*/ Grpc.Core.Internal.AuthContextSafeHandle.NativeAuthPropertyIterator grpcsharp_auth_context_property_iterator(Grpc.Core.Internal.AuthContextSafeHandle authContext);
                    static /*0xfd5b74*/ nint grpcsharp_auth_property_iterator_next(ref Grpc.Core.Internal.AuthContextSafeHandle.NativeAuthPropertyIterator iterator);
                    static /*0xfd5bf4*/ void grpcsharp_auth_context_release(nint authContext);
                    static /*0xfd5c74*/ Grpc.Core.Internal.SliceBufferSafeHandle grpcsharp_slice_buffer_create();
                    static /*0xfd5d34*/ nint grpcsharp_slice_buffer_adjust_tail_space(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer, nuint availableTailSpace, nuint requestedTailSpace);
                    static /*0xfd5e14*/ nuint grpcsharp_slice_buffer_slice_count(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer);
                    static /*0xfd5edc*/ void grpcsharp_slice_buffer_slice_peek(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer, nuint index, ref nuint sliceLen, ref nint sliceDataPtr);
                    static /*0xfd5fc4*/ void grpcsharp_slice_buffer_reset_and_unref(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer);
                    static /*0xfd6084*/ void grpcsharp_slice_buffer_destroy(nint sliceBuffer);
                    static /*0xfd6104*/ Grpc.Core.Internal.Timespec gprsharp_now(Grpc.Core.Internal.ClockType clockType);
                    static /*0xfd6184*/ Grpc.Core.Internal.Timespec gprsharp_inf_future(Grpc.Core.Internal.ClockType clockType);
                    static /*0xfd6204*/ Grpc.Core.Internal.Timespec gprsharp_inf_past(Grpc.Core.Internal.ClockType clockType);
                    static /*0xfd6284*/ Grpc.Core.Internal.Timespec gprsharp_convert_clock_type(Grpc.Core.Internal.Timespec t, Grpc.Core.Internal.ClockType targetClock);
                    static /*0xfd631c*/ int gprsharp_sizeof_timespec();
                    static /*0xfd6390*/ Grpc.Core.Internal.CallError grpcsharp_test_callback(Grpc.Core.Internal.NativeCallbackTestDelegate callback);
                    static /*0xfd6414*/ nint grpcsharp_test_nop(nint ptr);
                    static /*0xfd6494*/ void grpcsharp_test_override_method(string methodName, string variant);
                    static /*0xfd654c*/ Grpc.Core.Internal.CallError grpcsharp_test_call_start_unary_echo(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    /*0xfd6710*/ DllImportsFromSharedLib_arm64();
                }

                class DllImportsFromSharedLib_x86_dll
                {
                    static /*0xfe7b04*/ void grpcsharp_init();
                    static /*0xfe7b74*/ void grpcsharp_shutdown();
                    static /*0xfe7be4*/ nint grpcsharp_version_string();
                    static /*0xfe7c58*/ Grpc.Core.Internal.BatchContextSafeHandle grpcsharp_batch_context_create();
                    static /*0xfe7d18*/ nint grpcsharp_batch_context_recv_initial_metadata(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfe7de0*/ nint grpcsharp_batch_context_recv_message_length(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfe7ea8*/ int grpcsharp_batch_context_recv_message_next_slice_peek(Grpc.Core.Internal.BatchContextSafeHandle ctx, ref nuint sliceLen, ref nint sliceDataPtr);
                    static /*0xfe7f88*/ Grpc.Core.StatusCode grpcsharp_batch_context_recv_status_on_client_status(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfe8050*/ nint grpcsharp_batch_context_recv_status_on_client_details(Grpc.Core.Internal.BatchContextSafeHandle ctx, ref nuint detailsLength);
                    static /*0xfe8128*/ nint grpcsharp_batch_context_recv_status_on_client_error_string(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfe81f0*/ nint grpcsharp_batch_context_recv_status_on_client_trailing_metadata(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfe82b8*/ int grpcsharp_batch_context_recv_close_on_server_cancelled(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfe8380*/ void grpcsharp_batch_context_reset(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfe8440*/ void grpcsharp_batch_context_destroy(nint ctx);
                    static /*0xfe84c0*/ Grpc.Core.Internal.RequestCallContextSafeHandle grpcsharp_request_call_context_create();
                    static /*0xfe8580*/ Grpc.Core.Internal.CallSafeHandle grpcsharp_request_call_context_call(Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xfe8694*/ nint grpcsharp_request_call_context_method(Grpc.Core.Internal.RequestCallContextSafeHandle ctx, ref nuint methodLength);
                    static /*0xfe876c*/ nint grpcsharp_request_call_context_host(Grpc.Core.Internal.RequestCallContextSafeHandle ctx, ref nuint hostLength);
                    static /*0xfe8844*/ Grpc.Core.Internal.Timespec grpcsharp_request_call_context_deadline(Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xfe891c*/ nint grpcsharp_request_call_context_request_metadata(Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xfe89e4*/ void grpcsharp_request_call_context_reset(Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xfe8aa4*/ void grpcsharp_request_call_context_destroy(nint ctx);
                    static /*0xfe8b24*/ Grpc.Core.Internal.CallCredentialsSafeHandle grpcsharp_composite_call_credentials_create(Grpc.Core.Internal.CallCredentialsSafeHandle creds1, Grpc.Core.Internal.CallCredentialsSafeHandle creds2);
                    static /*0xfe8c7c*/ void grpcsharp_call_credentials_release(nint credentials);
                    static /*0xfe8cfc*/ Grpc.Core.Internal.CallError grpcsharp_call_cancel(Grpc.Core.Internal.CallSafeHandle call);
                    static /*0xfe8dc4*/ Grpc.Core.Internal.CallError grpcsharp_call_cancel_with_status(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.StatusCode status, string description);
                    static /*0xfe8ec4*/ Grpc.Core.Internal.CallError grpcsharp_call_start_unary(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    static /*0xfe9088*/ Grpc.Core.Internal.CallError grpcsharp_call_start_client_streaming(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    static /*0xfe91f8*/ Grpc.Core.Internal.CallError grpcsharp_call_start_server_streaming(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    static /*0xfe93bc*/ Grpc.Core.Internal.CallError grpcsharp_call_start_duplex_streaming(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    static /*0xfe952c*/ Grpc.Core.Internal.CallError grpcsharp_call_send_message(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, int sendEmptyInitialMetadata);
                    static /*0xfe96a4*/ Grpc.Core.Internal.CallError grpcsharp_call_send_close_from_client(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfe97b8*/ Grpc.Core.Internal.CallError grpcsharp_call_send_status_from_server(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.StatusCode statusCode, nint statusMessage, nuint statusMessageLen, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, int sendEmptyInitialMetadata, Grpc.Core.Internal.SliceBufferSafeHandle optionalSendBuffer, Grpc.Core.WriteFlags writeFlags);
                    static /*0xfe99ac*/ Grpc.Core.Internal.CallError grpcsharp_call_recv_message(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfe9ac0*/ Grpc.Core.Internal.CallError grpcsharp_call_recv_initial_metadata(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfe9bd4*/ Grpc.Core.Internal.CallError grpcsharp_call_start_serverside(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfe9ce8*/ Grpc.Core.Internal.CallError grpcsharp_call_send_initial_metadata(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray);
                    static /*0xfe9e48*/ Grpc.Core.Internal.CallError grpcsharp_call_set_credentials(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.CallCredentialsSafeHandle credentials);
                    static /*0xfe9f5c*/ Grpc.Core.Internal.CStringSafeHandle grpcsharp_call_get_peer(Grpc.Core.Internal.CallSafeHandle call);
                    static /*0xfea06c*/ void grpcsharp_call_destroy(nint call);
                    static /*0xfea0ec*/ Grpc.Core.Internal.ChannelArgsSafeHandle grpcsharp_channel_args_create(nuint numArgs);
                    static /*0xfea1b8*/ void grpcsharp_channel_args_set_string(Grpc.Core.Internal.ChannelArgsSafeHandle args, nuint index, string key, string value);
                    static /*0xfea2cc*/ void grpcsharp_channel_args_set_integer(Grpc.Core.Internal.ChannelArgsSafeHandle args, nuint index, string key, int value);
                    static /*0xfea3cc*/ void grpcsharp_channel_args_destroy(nint args);
                    static /*0xfea44c*/ void grpcsharp_override_default_ssl_roots(string pemRootCerts);
                    static /*0xfea4dc*/ Grpc.Core.Internal.ChannelCredentialsSafeHandle grpcsharp_ssl_credentials_create(string pemRootCerts, string keyCertPairCertChain, string keyCertPairPrivateKey, nint verifyPeerCallbackTag);
                    static /*0xfea608*/ Grpc.Core.Internal.ChannelCredentialsSafeHandle grpcsharp_composite_channel_credentials_create(Grpc.Core.Internal.ChannelCredentialsSafeHandle channelCreds, Grpc.Core.Internal.CallCredentialsSafeHandle callCreds);
                    static /*0xfea760*/ void grpcsharp_channel_credentials_release(nint credentials);
                    static /*0xfea7e0*/ Grpc.Core.Internal.ChannelSafeHandle grpcsharp_insecure_channel_create(string target, Grpc.Core.Internal.ChannelArgsSafeHandle channelArgs);
                    static /*0xfea910*/ Grpc.Core.Internal.ChannelSafeHandle grpcsharp_secure_channel_create(Grpc.Core.Internal.ChannelCredentialsSafeHandle credentials, string target, Grpc.Core.Internal.ChannelArgsSafeHandle channelArgs);
                    static /*0xfeaa8c*/ Grpc.Core.Internal.CallSafeHandle grpcsharp_channel_create_call(Grpc.Core.Internal.ChannelSafeHandle channel, Grpc.Core.Internal.CallSafeHandle parentCall, Grpc.Core.Internal.ContextPropagationFlags propagationMask, Grpc.Core.Internal.CompletionQueueSafeHandle cq, string method, string host, Grpc.Core.Internal.Timespec deadline);
                    static /*0xfeaca0*/ Grpc.Core.ChannelState grpcsharp_channel_check_connectivity_state(Grpc.Core.Internal.ChannelSafeHandle channel, int tryToConnect);
                    static /*0xfead78*/ void grpcsharp_channel_watch_connectivity_state(Grpc.Core.Internal.ChannelSafeHandle channel, Grpc.Core.ChannelState lastObservedState, Grpc.Core.Internal.Timespec deadline, Grpc.Core.Internal.CompletionQueueSafeHandle cq, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfeaef8*/ Grpc.Core.Internal.CStringSafeHandle grpcsharp_channel_get_target(Grpc.Core.Internal.ChannelSafeHandle call);
                    static /*0xfeb00c*/ void grpcsharp_channel_destroy(nint channel);
                    static /*0xfeb08c*/ int grpcsharp_sizeof_grpc_event();
                    static /*0xfeb100*/ Grpc.Core.Internal.CompletionQueueSafeHandle grpcsharp_completion_queue_create_async();
                    static /*0xfeb1c0*/ Grpc.Core.Internal.CompletionQueueSafeHandle grpcsharp_completion_queue_create_sync();
                    static /*0xfeb280*/ void grpcsharp_completion_queue_shutdown(Grpc.Core.Internal.CompletionQueueSafeHandle cq);
                    static /*0xfeb340*/ Grpc.Core.Internal.CompletionQueueEvent grpcsharp_completion_queue_next(Grpc.Core.Internal.CompletionQueueSafeHandle cq);
                    static /*0xfeb418*/ Grpc.Core.Internal.CompletionQueueEvent grpcsharp_completion_queue_pluck(Grpc.Core.Internal.CompletionQueueSafeHandle cq, nint tag);
                    static /*0xfeb4f8*/ void grpcsharp_completion_queue_destroy(nint cq);
                    static /*0xfeb578*/ void gprsharp_free(nint ptr);
                    static /*0xfeb5f8*/ Grpc.Core.Internal.MetadataArraySafeHandle grpcsharp_metadata_array_create(nuint capacity);
                    static /*0xfeb6c4*/ void grpcsharp_metadata_array_add(Grpc.Core.Internal.MetadataArraySafeHandle array, string key, byte[] value, nuint valueLength);
                    static /*0xfeb7cc*/ nuint grpcsharp_metadata_array_count(nint metadataArray);
                    static /*0xfeb84c*/ nint grpcsharp_metadata_array_get_key(nint metadataArray, nuint index, ref nuint keyLength);
                    static /*0xfeb8e4*/ nint grpcsharp_metadata_array_get_value(nint metadataArray, nuint index, ref nuint valueLength);
                    static /*0xfeb97c*/ void grpcsharp_metadata_array_destroy_full(nint array);
                    static /*0xfeb9fc*/ void grpcsharp_redirect_log(Grpc.Core.Internal.GprLogDelegate callback);
                    static /*0xfeba80*/ void grpcsharp_native_callback_dispatcher_init(Grpc.Core.Internal.NativeCallbackDispatcherCallback dispatcher);
                    static /*0xfebb04*/ Grpc.Core.Internal.CallCredentialsSafeHandle grpcsharp_metadata_credentials_create_from_plugin(nint nativeCallbackTag);
                    static /*0xfebbd0*/ void grpcsharp_metadata_credentials_notify_from_plugin(nint callbackPtr, nint userData, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.StatusCode statusCode, string errorDetails);
                    static /*0xfebce0*/ Grpc.Core.Internal.ServerCredentialsSafeHandle grpcsharp_ssl_server_credentials_create(string pemRootCerts, string[] keyCertPairCertChainArray, string[] keyCertPairPrivateKeyArray, nuint numKeyCertPairs, Grpc.Core.SslClientCertificateRequestType clientCertificateRequest);
                    static /*0xfebf30*/ void grpcsharp_server_credentials_release(nint credentials);
                    static /*0xfebfb0*/ Grpc.Core.Internal.ServerSafeHandle grpcsharp_server_create(Grpc.Core.Internal.ChannelArgsSafeHandle args);
                    static /*0xfec0c0*/ void grpcsharp_server_register_completion_queue(Grpc.Core.Internal.ServerSafeHandle server, Grpc.Core.Internal.CompletionQueueSafeHandle cq);
                    static /*0xfec1cc*/ int grpcsharp_server_add_insecure_http2_port(Grpc.Core.Internal.ServerSafeHandle server, string addr);
                    static /*0xfec2bc*/ int grpcsharp_server_add_secure_http2_port(Grpc.Core.Internal.ServerSafeHandle server, string addr, Grpc.Core.Internal.ServerCredentialsSafeHandle creds);
                    static /*0xfec3f4*/ void grpcsharp_server_start(Grpc.Core.Internal.ServerSafeHandle server);
                    static /*0xfec4b4*/ Grpc.Core.Internal.CallError grpcsharp_server_request_call(Grpc.Core.Internal.ServerSafeHandle server, Grpc.Core.Internal.CompletionQueueSafeHandle cq, Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xfec614*/ void grpcsharp_server_cancel_all_calls(Grpc.Core.Internal.ServerSafeHandle server);
                    static /*0xfec6d4*/ void grpcsharp_server_shutdown_and_notify_callback(Grpc.Core.Internal.ServerSafeHandle server, Grpc.Core.Internal.CompletionQueueSafeHandle cq, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfec82c*/ void grpcsharp_server_destroy(nint server);
                    static /*0xfec8ac*/ Grpc.Core.Internal.AuthContextSafeHandle grpcsharp_call_auth_context(Grpc.Core.Internal.CallSafeHandle call);
                    static /*0xfec9c0*/ nint grpcsharp_auth_context_peer_identity_property_name(Grpc.Core.Internal.AuthContextSafeHandle authContext);
                    static /*0xfeca88*/ Grpc.Core.Internal.AuthContextSafeHandle.NativeAuthPropertyIterator grpcsharp_auth_context_property_iterator(Grpc.Core.Internal.AuthContextSafeHandle authContext);
                    static /*0xfecb58*/ nint grpcsharp_auth_property_iterator_next(ref Grpc.Core.Internal.AuthContextSafeHandle.NativeAuthPropertyIterator iterator);
                    static /*0xfecbd8*/ void grpcsharp_auth_context_release(nint authContext);
                    static /*0xfecc58*/ Grpc.Core.Internal.SliceBufferSafeHandle grpcsharp_slice_buffer_create();
                    static /*0xfecd18*/ nint grpcsharp_slice_buffer_adjust_tail_space(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer, nuint availableTailSpace, nuint requestedTailSpace);
                    static /*0xfecdf8*/ nuint grpcsharp_slice_buffer_slice_count(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer);
                    static /*0xfecec0*/ void grpcsharp_slice_buffer_slice_peek(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer, nuint index, ref nuint sliceLen, ref nint sliceDataPtr);
                    static /*0xfecfa8*/ void grpcsharp_slice_buffer_reset_and_unref(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer);
                    static /*0xfed068*/ void grpcsharp_slice_buffer_destroy(nint sliceBuffer);
                    static /*0xfed0e8*/ Grpc.Core.Internal.Timespec gprsharp_now(Grpc.Core.Internal.ClockType clockType);
                    static /*0xfed168*/ Grpc.Core.Internal.Timespec gprsharp_inf_future(Grpc.Core.Internal.ClockType clockType);
                    static /*0xfed1e8*/ Grpc.Core.Internal.Timespec gprsharp_inf_past(Grpc.Core.Internal.ClockType clockType);
                    static /*0xfed268*/ Grpc.Core.Internal.Timespec gprsharp_convert_clock_type(Grpc.Core.Internal.Timespec t, Grpc.Core.Internal.ClockType targetClock);
                    static /*0xfed300*/ int gprsharp_sizeof_timespec();
                    static /*0xfed374*/ Grpc.Core.Internal.CallError grpcsharp_test_callback(Grpc.Core.Internal.NativeCallbackTestDelegate callback);
                    static /*0xfed3f4*/ nint grpcsharp_test_nop(nint ptr);
                    static /*0xfed474*/ void grpcsharp_test_override_method(string methodName, string variant);
                    static /*0xfed52c*/ Grpc.Core.Internal.CallError grpcsharp_test_call_start_unary_echo(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    /*0xfed6f0*/ DllImportsFromSharedLib_x86_dll();
                }

                class DllImportsFromSharedLib_x64_dll
                {
                    static /*0xfdc314*/ void grpcsharp_init();
                    static /*0xfdc384*/ void grpcsharp_shutdown();
                    static /*0xfdc3f4*/ nint grpcsharp_version_string();
                    static /*0xfdc468*/ Grpc.Core.Internal.BatchContextSafeHandle grpcsharp_batch_context_create();
                    static /*0xfdc528*/ nint grpcsharp_batch_context_recv_initial_metadata(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfdc5f0*/ nint grpcsharp_batch_context_recv_message_length(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfdc6b8*/ int grpcsharp_batch_context_recv_message_next_slice_peek(Grpc.Core.Internal.BatchContextSafeHandle ctx, ref nuint sliceLen, ref nint sliceDataPtr);
                    static /*0xfdc798*/ Grpc.Core.StatusCode grpcsharp_batch_context_recv_status_on_client_status(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfdc860*/ nint grpcsharp_batch_context_recv_status_on_client_details(Grpc.Core.Internal.BatchContextSafeHandle ctx, ref nuint detailsLength);
                    static /*0xfdc938*/ nint grpcsharp_batch_context_recv_status_on_client_error_string(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfdca00*/ nint grpcsharp_batch_context_recv_status_on_client_trailing_metadata(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfdcac8*/ int grpcsharp_batch_context_recv_close_on_server_cancelled(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfdcb90*/ void grpcsharp_batch_context_reset(Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfdcc50*/ void grpcsharp_batch_context_destroy(nint ctx);
                    static /*0xfdccd0*/ Grpc.Core.Internal.RequestCallContextSafeHandle grpcsharp_request_call_context_create();
                    static /*0xfdcd90*/ Grpc.Core.Internal.CallSafeHandle grpcsharp_request_call_context_call(Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xfdcea4*/ nint grpcsharp_request_call_context_method(Grpc.Core.Internal.RequestCallContextSafeHandle ctx, ref nuint methodLength);
                    static /*0xfdcf7c*/ nint grpcsharp_request_call_context_host(Grpc.Core.Internal.RequestCallContextSafeHandle ctx, ref nuint hostLength);
                    static /*0xfdd054*/ Grpc.Core.Internal.Timespec grpcsharp_request_call_context_deadline(Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xfdd12c*/ nint grpcsharp_request_call_context_request_metadata(Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xfdd1f4*/ void grpcsharp_request_call_context_reset(Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xfdd2b4*/ void grpcsharp_request_call_context_destroy(nint ctx);
                    static /*0xfdd334*/ Grpc.Core.Internal.CallCredentialsSafeHandle grpcsharp_composite_call_credentials_create(Grpc.Core.Internal.CallCredentialsSafeHandle creds1, Grpc.Core.Internal.CallCredentialsSafeHandle creds2);
                    static /*0xfdd48c*/ void grpcsharp_call_credentials_release(nint credentials);
                    static /*0xfdd50c*/ Grpc.Core.Internal.CallError grpcsharp_call_cancel(Grpc.Core.Internal.CallSafeHandle call);
                    static /*0xfdd5d4*/ Grpc.Core.Internal.CallError grpcsharp_call_cancel_with_status(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.StatusCode status, string description);
                    static /*0xfdd6d4*/ Grpc.Core.Internal.CallError grpcsharp_call_start_unary(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    static /*0xfdd898*/ Grpc.Core.Internal.CallError grpcsharp_call_start_client_streaming(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    static /*0xfdda08*/ Grpc.Core.Internal.CallError grpcsharp_call_start_server_streaming(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    static /*0xfddbcc*/ Grpc.Core.Internal.CallError grpcsharp_call_start_duplex_streaming(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    static /*0xfddd3c*/ Grpc.Core.Internal.CallError grpcsharp_call_send_message(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, int sendEmptyInitialMetadata);
                    static /*0xfddeb4*/ Grpc.Core.Internal.CallError grpcsharp_call_send_close_from_client(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfddfc8*/ Grpc.Core.Internal.CallError grpcsharp_call_send_status_from_server(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.StatusCode statusCode, nint statusMessage, nuint statusMessageLen, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, int sendEmptyInitialMetadata, Grpc.Core.Internal.SliceBufferSafeHandle optionalSendBuffer, Grpc.Core.WriteFlags writeFlags);
                    static /*0xfde1bc*/ Grpc.Core.Internal.CallError grpcsharp_call_recv_message(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfde2d0*/ Grpc.Core.Internal.CallError grpcsharp_call_recv_initial_metadata(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfde3e4*/ Grpc.Core.Internal.CallError grpcsharp_call_start_serverside(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfde4f8*/ Grpc.Core.Internal.CallError grpcsharp_call_send_initial_metadata(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray);
                    static /*0xfde658*/ Grpc.Core.Internal.CallError grpcsharp_call_set_credentials(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.CallCredentialsSafeHandle credentials);
                    static /*0xfde76c*/ Grpc.Core.Internal.CStringSafeHandle grpcsharp_call_get_peer(Grpc.Core.Internal.CallSafeHandle call);
                    static /*0xfde87c*/ void grpcsharp_call_destroy(nint call);
                    static /*0xfde8fc*/ Grpc.Core.Internal.ChannelArgsSafeHandle grpcsharp_channel_args_create(nuint numArgs);
                    static /*0xfde9c8*/ void grpcsharp_channel_args_set_string(Grpc.Core.Internal.ChannelArgsSafeHandle args, nuint index, string key, string value);
                    static /*0xfdeadc*/ void grpcsharp_channel_args_set_integer(Grpc.Core.Internal.ChannelArgsSafeHandle args, nuint index, string key, int value);
                    static /*0xfdebdc*/ void grpcsharp_channel_args_destroy(nint args);
                    static /*0xfdec5c*/ void grpcsharp_override_default_ssl_roots(string pemRootCerts);
                    static /*0xfdecec*/ Grpc.Core.Internal.ChannelCredentialsSafeHandle grpcsharp_ssl_credentials_create(string pemRootCerts, string keyCertPairCertChain, string keyCertPairPrivateKey, nint verifyPeerCallbackTag);
                    static /*0xfdee18*/ Grpc.Core.Internal.ChannelCredentialsSafeHandle grpcsharp_composite_channel_credentials_create(Grpc.Core.Internal.ChannelCredentialsSafeHandle channelCreds, Grpc.Core.Internal.CallCredentialsSafeHandle callCreds);
                    static /*0xfdef70*/ void grpcsharp_channel_credentials_release(nint credentials);
                    static /*0xfdeff0*/ Grpc.Core.Internal.ChannelSafeHandle grpcsharp_insecure_channel_create(string target, Grpc.Core.Internal.ChannelArgsSafeHandle channelArgs);
                    static /*0xfdf120*/ Grpc.Core.Internal.ChannelSafeHandle grpcsharp_secure_channel_create(Grpc.Core.Internal.ChannelCredentialsSafeHandle credentials, string target, Grpc.Core.Internal.ChannelArgsSafeHandle channelArgs);
                    static /*0xfdf29c*/ Grpc.Core.Internal.CallSafeHandle grpcsharp_channel_create_call(Grpc.Core.Internal.ChannelSafeHandle channel, Grpc.Core.Internal.CallSafeHandle parentCall, Grpc.Core.Internal.ContextPropagationFlags propagationMask, Grpc.Core.Internal.CompletionQueueSafeHandle cq, string method, string host, Grpc.Core.Internal.Timespec deadline);
                    static /*0xfdf4b0*/ Grpc.Core.ChannelState grpcsharp_channel_check_connectivity_state(Grpc.Core.Internal.ChannelSafeHandle channel, int tryToConnect);
                    static /*0xfdf588*/ void grpcsharp_channel_watch_connectivity_state(Grpc.Core.Internal.ChannelSafeHandle channel, Grpc.Core.ChannelState lastObservedState, Grpc.Core.Internal.Timespec deadline, Grpc.Core.Internal.CompletionQueueSafeHandle cq, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfdf708*/ Grpc.Core.Internal.CStringSafeHandle grpcsharp_channel_get_target(Grpc.Core.Internal.ChannelSafeHandle call);
                    static /*0xfdf81c*/ void grpcsharp_channel_destroy(nint channel);
                    static /*0xfdf89c*/ int grpcsharp_sizeof_grpc_event();
                    static /*0xfdf910*/ Grpc.Core.Internal.CompletionQueueSafeHandle grpcsharp_completion_queue_create_async();
                    static /*0xfdf9d0*/ Grpc.Core.Internal.CompletionQueueSafeHandle grpcsharp_completion_queue_create_sync();
                    static /*0xfdfa90*/ void grpcsharp_completion_queue_shutdown(Grpc.Core.Internal.CompletionQueueSafeHandle cq);
                    static /*0xfdfb50*/ Grpc.Core.Internal.CompletionQueueEvent grpcsharp_completion_queue_next(Grpc.Core.Internal.CompletionQueueSafeHandle cq);
                    static /*0xfdfc28*/ Grpc.Core.Internal.CompletionQueueEvent grpcsharp_completion_queue_pluck(Grpc.Core.Internal.CompletionQueueSafeHandle cq, nint tag);
                    static /*0xfdfd08*/ void grpcsharp_completion_queue_destroy(nint cq);
                    static /*0xfdfd88*/ void gprsharp_free(nint ptr);
                    static /*0xfdfe08*/ Grpc.Core.Internal.MetadataArraySafeHandle grpcsharp_metadata_array_create(nuint capacity);
                    static /*0xfdfed4*/ void grpcsharp_metadata_array_add(Grpc.Core.Internal.MetadataArraySafeHandle array, string key, byte[] value, nuint valueLength);
                    static /*0xfdffdc*/ nuint grpcsharp_metadata_array_count(nint metadataArray);
                    static /*0xfe005c*/ nint grpcsharp_metadata_array_get_key(nint metadataArray, nuint index, ref nuint keyLength);
                    static /*0xfe00f4*/ nint grpcsharp_metadata_array_get_value(nint metadataArray, nuint index, ref nuint valueLength);
                    static /*0xfe018c*/ void grpcsharp_metadata_array_destroy_full(nint array);
                    static /*0xfe020c*/ void grpcsharp_redirect_log(Grpc.Core.Internal.GprLogDelegate callback);
                    static /*0xfe0290*/ void grpcsharp_native_callback_dispatcher_init(Grpc.Core.Internal.NativeCallbackDispatcherCallback dispatcher);
                    static /*0xfe0314*/ Grpc.Core.Internal.CallCredentialsSafeHandle grpcsharp_metadata_credentials_create_from_plugin(nint nativeCallbackTag);
                    static /*0xfe03e0*/ void grpcsharp_metadata_credentials_notify_from_plugin(nint callbackPtr, nint userData, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.StatusCode statusCode, string errorDetails);
                    static /*0xfe04f0*/ Grpc.Core.Internal.ServerCredentialsSafeHandle grpcsharp_ssl_server_credentials_create(string pemRootCerts, string[] keyCertPairCertChainArray, string[] keyCertPairPrivateKeyArray, nuint numKeyCertPairs, Grpc.Core.SslClientCertificateRequestType clientCertificateRequest);
                    static /*0xfe0740*/ void grpcsharp_server_credentials_release(nint credentials);
                    static /*0xfe07c0*/ Grpc.Core.Internal.ServerSafeHandle grpcsharp_server_create(Grpc.Core.Internal.ChannelArgsSafeHandle args);
                    static /*0xfe08d0*/ void grpcsharp_server_register_completion_queue(Grpc.Core.Internal.ServerSafeHandle server, Grpc.Core.Internal.CompletionQueueSafeHandle cq);
                    static /*0xfe09dc*/ int grpcsharp_server_add_insecure_http2_port(Grpc.Core.Internal.ServerSafeHandle server, string addr);
                    static /*0xfe0acc*/ int grpcsharp_server_add_secure_http2_port(Grpc.Core.Internal.ServerSafeHandle server, string addr, Grpc.Core.Internal.ServerCredentialsSafeHandle creds);
                    static /*0xfe0c04*/ void grpcsharp_server_start(Grpc.Core.Internal.ServerSafeHandle server);
                    static /*0xfe0cc4*/ Grpc.Core.Internal.CallError grpcsharp_server_request_call(Grpc.Core.Internal.ServerSafeHandle server, Grpc.Core.Internal.CompletionQueueSafeHandle cq, Grpc.Core.Internal.RequestCallContextSafeHandle ctx);
                    static /*0xfe0e24*/ void grpcsharp_server_cancel_all_calls(Grpc.Core.Internal.ServerSafeHandle server);
                    static /*0xfe0ee4*/ void grpcsharp_server_shutdown_and_notify_callback(Grpc.Core.Internal.ServerSafeHandle server, Grpc.Core.Internal.CompletionQueueSafeHandle cq, Grpc.Core.Internal.BatchContextSafeHandle ctx);
                    static /*0xfe103c*/ void grpcsharp_server_destroy(nint server);
                    static /*0xfe10bc*/ Grpc.Core.Internal.AuthContextSafeHandle grpcsharp_call_auth_context(Grpc.Core.Internal.CallSafeHandle call);
                    static /*0xfe11d0*/ nint grpcsharp_auth_context_peer_identity_property_name(Grpc.Core.Internal.AuthContextSafeHandle authContext);
                    static /*0xfe1298*/ Grpc.Core.Internal.AuthContextSafeHandle.NativeAuthPropertyIterator grpcsharp_auth_context_property_iterator(Grpc.Core.Internal.AuthContextSafeHandle authContext);
                    static /*0xfe1368*/ nint grpcsharp_auth_property_iterator_next(ref Grpc.Core.Internal.AuthContextSafeHandle.NativeAuthPropertyIterator iterator);
                    static /*0xfe13e8*/ void grpcsharp_auth_context_release(nint authContext);
                    static /*0xfe1468*/ Grpc.Core.Internal.SliceBufferSafeHandle grpcsharp_slice_buffer_create();
                    static /*0xfe1528*/ nint grpcsharp_slice_buffer_adjust_tail_space(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer, nuint availableTailSpace, nuint requestedTailSpace);
                    static /*0xfe1608*/ nuint grpcsharp_slice_buffer_slice_count(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer);
                    static /*0xfe16d0*/ void grpcsharp_slice_buffer_slice_peek(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer, nuint index, ref nuint sliceLen, ref nint sliceDataPtr);
                    static /*0xfe17b8*/ void grpcsharp_slice_buffer_reset_and_unref(Grpc.Core.Internal.SliceBufferSafeHandle sliceBuffer);
                    static /*0xfe1878*/ void grpcsharp_slice_buffer_destroy(nint sliceBuffer);
                    static /*0xfe18f8*/ Grpc.Core.Internal.Timespec gprsharp_now(Grpc.Core.Internal.ClockType clockType);
                    static /*0xfe1978*/ Grpc.Core.Internal.Timespec gprsharp_inf_future(Grpc.Core.Internal.ClockType clockType);
                    static /*0xfe19f8*/ Grpc.Core.Internal.Timespec gprsharp_inf_past(Grpc.Core.Internal.ClockType clockType);
                    static /*0xfe1a78*/ Grpc.Core.Internal.Timespec gprsharp_convert_clock_type(Grpc.Core.Internal.Timespec t, Grpc.Core.Internal.ClockType targetClock);
                    static /*0xfe1b10*/ int gprsharp_sizeof_timespec();
                    static /*0xfe1b84*/ Grpc.Core.Internal.CallError grpcsharp_test_callback(Grpc.Core.Internal.NativeCallbackTestDelegate callback);
                    static /*0xfe1c04*/ nint grpcsharp_test_nop(nint ptr);
                    static /*0xfe1c84*/ void grpcsharp_test_override_method(string methodName, string variant);
                    static /*0xfe1d3c*/ Grpc.Core.Internal.CallError grpcsharp_test_call_start_unary_echo(Grpc.Core.Internal.CallSafeHandle call, Grpc.Core.Internal.BatchContextSafeHandle ctx, Grpc.Core.Internal.SliceBufferSafeHandle sendBuffer, Grpc.Core.WriteFlags writeFlags, Grpc.Core.Internal.MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags metadataFlags);
                    /*0xfe1f00*/ DllImportsFromSharedLib_x64_dll();
                }
            }

            class PlatformApis
            {
                static /*0x0*/ bool isLinux;
                static /*0x1*/ bool isMacOSX;
                static /*0x2*/ bool isWindows;
                static /*0x3*/ bool isMono;
                static /*0x4*/ bool isNet5OrHigher;
                static /*0x5*/ bool isNetCore;
                static /*0x8*/ string frameworkDescription;
                static /*0x10*/ string clrVersion;
                static /*0x18*/ string unityApplicationPlatform;
                static /*0x20*/ bool isXamarin;
                static /*0x21*/ bool isXamarinIOS;
                static /*0x22*/ bool isXamarinAndroid;

                static /*0x156f30c*/ PlatformApis();
                static /*0x156f870*/ bool get_IsLinux();
                static /*0x156f8d4*/ bool get_IsMacOSX();
                static /*0x156f938*/ bool get_IsWindows();
                static /*0x156f99c*/ bool get_IsMono();
                static /*0x156aac8*/ bool get_IsUnity();
                static /*0x155c434*/ bool get_IsUnityIOS();
                static /*0x156fa00*/ bool get_IsXamarin();
                static /*0x156fa64*/ bool get_IsXamarinIOS();
                static /*0x156fac8*/ bool get_IsXamarinAndroid();
                static /*0x156fb2c*/ bool get_IsNet5OrHigher();
                static /*0x156fb90*/ string get_FrameworkDescription();
                static /*0x156fbf4*/ string get_ClrVersion();
                static /*0x156fc58*/ bool get_IsNetCore();
                static /*0x156fcbc*/ bool get_Is64Bit();
                static /*0x1561738*/ Grpc.Core.Internal.CommonPlatformDetection.CpuArchitecture get_ProcessArchitecture();
                static /*0x156f63c*/ string TryGetUnityApplicationPlatform();
                static /*0x156f50c*/ string TryGetFrameworkDescription();
                static /*0x156f614*/ string TryGetClrVersion();
                static /*0x156fcdc*/ string GetGrpcCoreTargetFrameworkMoniker();

                class <>c
                {
                    static /*0x0*/ Grpc.Core.Internal.PlatformApis.<> <>9;
                    static /*0x8*/ System.Func<System.Reflection.Assembly, bool> <>9__49_0;

                    static /*0xff09a4*/ <>c();
                    /*0xff0a04*/ <>c();
                    /*0xff0a0c*/ bool <TryGetUnityApplicationPlatform>b__49_0(System.Reflection.Assembly assembly);
                }
            }

            class RequestCallContextSafeHandle : Grpc.Core.Internal.SafeHandleZeroIsInvalid, Grpc.Core.Internal.IOpCompletionCallback, Grpc.Core.Internal.IPooledObject<Grpc.Core.Internal.RequestCallContextSafeHandle>, System.IDisposable
            {
                static /*0x0*/ Grpc.Core.Internal.NativeMethods Native;
                static /*0x8*/ Grpc.Core.Logging.ILogger Logger;
                /*0x20*/ System.Action<Grpc.Core.Internal.RequestCallContextSafeHandle> returnToPoolAction;
                /*0x28*/ Grpc.Core.Internal.RequestCallCompletionDelegate <CompletionCallback>k__BackingField;

                static /*0x15705f0*/ RequestCallContextSafeHandle();
                static /*0x15701d8*/ Grpc.Core.Internal.RequestCallContextSafeHandle Create();
                /*0x15701d4*/ RequestCallContextSafeHandle();
                /*0x1570250*/ void SetReturnToPoolAction(System.Action<Grpc.Core.Internal.RequestCallContextSafeHandle> returnAction);
                /*0x1570288*/ Grpc.Core.Internal.RequestCallCompletionDelegate get_CompletionCallback();
                /*0x1570290*/ void set_CompletionCallback(Grpc.Core.Internal.RequestCallCompletionDelegate value);
                /*0x1570298*/ void Recycle();
                /*0x1570360*/ bool ReleaseHandle();
                /*0x15703e8*/ void Grpc.Core.Internal.IOpCompletionCallback.OnComplete(bool success);
            }

            class ReusableSliceBuffer
            {
                /*0x10*/ Grpc.Core.Internal.ReusableSliceBuffer.SliceSegment[] cachedSegments;
                /*0x18*/ int populatedSegmentCount;

                /*0x1559910*/ ReusableSliceBuffer();
                /*0x1559b14*/ System.Buffers.ReadOnlySequence<byte> PopulateFrom(Grpc.Core.Internal.IBufferReader bufferReader);
                /*0x1559f00*/ void Invalidate();

                class SliceSegment : System.Buffers.ReadOnlySequenceSegment<byte>
                {
                    /*0x30*/ Grpc.Core.Internal.SliceMemoryManager pointerMemoryManager;

                    /*0xff0b74*/ SliceSegment();
                    /*0xff0a7c*/ void Reset(Grpc.Core.Internal.Slice slice, long runningIndex);
                    /*0xff0b28*/ void SetNext(System.Buffers.ReadOnlySequenceSegment<byte> next);
                }
            }

            class SafeHandleZeroIsInvalid : System.Runtime.InteropServices.SafeHandle
            {
                /*0x15524a0*/ SafeHandleZeroIsInvalid();
                /*0x1570758*/ bool get_IsInvalid();
            }

            class ServerCredentialsSafeHandle : Grpc.Core.Internal.SafeHandleZeroIsInvalid
            {
                static /*0x0*/ Grpc.Core.Internal.NativeMethods Native;

                static /*0xfc3908*/ ServerCredentialsSafeHandle();
                /*0xfc3650*/ ServerCredentialsSafeHandle();
                /*0xfc3658*/ bool ReleaseHandle();
            }

            class ServerSafeHandle : Grpc.Core.Internal.SafeHandleZeroIsInvalid
            {
                static /*0x0*/ Grpc.Core.Internal.NativeMethods Native;

                static /*0xfc4570*/ ServerSafeHandle();
                /*0xfc395c*/ ServerSafeHandle();
                /*0xfc3964*/ void ShutdownAndNotify(Grpc.Core.Internal.BatchCompletionDelegate callback, Grpc.Core.Internal.CompletionQueueSafeHandle completionQueue);
                /*0xfc3e98*/ bool ReleaseHandle();
                /*0xfc417c*/ void CancelAllCalls();
            }

            struct Slice
            {
                /*0x10*/ nint dataPtr;
                /*0x18*/ int length;

                /*0xa85620*/ Slice(nint dataPtr, int length);
                /*0xa8562c*/ int get_Length();
                /*0xa8573c*/ System.Span<byte> ToSpanUnsafe();
                /*0xa8577c*/ string ToString();
            }

            class SliceBufferSafeHandle : Grpc.Core.Internal.SafeHandleZeroIsInvalid, System.Buffers.IBufferWriter<byte>
            {
                static /*0x0*/ Grpc.Core.Internal.NativeMethods Native;
                static /*0x8*/ Grpc.Core.Logging.ILogger Logger;
                static /*0x10*/ Grpc.Core.Internal.SliceBufferSafeHandle NullInstance;
                /*0x20*/ nint tailSpacePtr;
                /*0x28*/ int tailSpaceLen;
                /*0x30*/ Grpc.Core.Internal.SliceMemoryManager memoryManagerLazy;

                static /*0xfc5810*/ SliceBufferSafeHandle();
                static /*0xfc470c*/ Grpc.Core.Internal.SliceBufferSafeHandle Create();
                /*0xfc4704*/ SliceBufferSafeHandle();
                /*0xfc4994*/ void Advance(int count);
                /*0xfc4ab4*/ System.Memory<byte> GetMemory(int sizeHint);
                /*0xfc4c04*/ System.Span<byte> GetSpan(int sizeHint);
                /*0xfc4c7c*/ void Complete();
                /*0xfc4d64*/ void Reset();
                /*0xfc4b50*/ void EnsureBufferSpace(int sizeHint);
                /*0xfc4c84*/ void AdjustTailSpace(int requestedSize);
                /*0xfc5560*/ bool ReleaseHandle();
            }

            class SliceMemoryManager : System.Buffers.MemoryManager<byte>
            {
                /*0x10*/ Grpc.Core.Internal.Slice slice;

                /*0xfc4bb8*/ SliceMemoryManager();
                /*0xfc599c*/ void Reset(Grpc.Core.Internal.Slice slice);
                /*0xfc4a74*/ void Reset();
                /*0xfc59a4*/ System.Span<byte> GetSpan();
                /*0xfc59e4*/ void Dispose(bool disposing);
            }

            struct Timespec : System.IEquatable<Grpc.Core.Internal.Timespec>
            {
                static /*0x0*/ Grpc.Core.Internal.NativeMethods Native;
                static /*0x8*/ System.DateTime UnixEpoch;
                /*0x10*/ long tv_sec;
                /*0x18*/ int tv_nsec;
                /*0x1c*/ Grpc.Core.Internal.ClockType clock_type;

                static /*0xfc6590*/ Timespec();
                static /*0xfc6210*/ Grpc.Core.Internal.Timespec get_InfFuture();
                static /*0xfc621c*/ Grpc.Core.Internal.Timespec get_InfPast();
                static /*0xfc6238*/ Grpc.Core.Internal.Timespec FromDateTime(System.DateTime dateTime);
                /*0xa85804*/ Timespec(long tv_sec, int tv_nsec);
                /*0xa85814*/ Timespec(long tv_sec, int tv_nsec, Grpc.Core.Internal.ClockType clock_type);
                /*0xa85784*/ bool Equals(object obj);
                /*0xa8578c*/ int GetHashCode();
                /*0xa857cc*/ string ToString();
                /*0xa857d0*/ bool Equals(Grpc.Core.Internal.Timespec other);
                /*0xa85820*/ long get_TimevalSeconds();
                /*0xa85828*/ int get_TimevalNanos();
            }

            class UnmanagedLibrary
            {
                static /*0x0*/ Grpc.Core.Logging.ILogger Logger;
                /*0x10*/ string libraryPath;
                /*0x18*/ nint handle;

                static /*0xfc7ac8*/ UnmanagedLibrary();
                static /*0xfc6d9c*/ nint PlatformSpecificLoadLibrary(string libraryPath, ref string errorMsg);
                static /*0xfc79bc*/ nint LoadLibraryPosix(System.Func<string, int, nint> dlopenFunc, System.Func<nint> dlerrorFunc, string libraryPath, ref string errorMsg);
                static /*0xfc6c6c*/ string FirstValidLibraryPath(string[] libraryPathAlternatives);
                /*0xfc6a40*/ UnmanagedLibrary(string[] libraryPathAlternatives);
                /*0xfc723c*/ nint LoadSymbol(string symbolName);
                T GetNativeMethodDelegate<T>(string methodName);

                class Windows
                {
                    static /*0xfc7924*/ nint LoadLibrary(string filename);
                    static /*0xfc7630*/ nint GetProcAddress(nint hModule, string procName);
                }

                class Linux
                {
                    static /*0xff14ac*/ nint dlopen(string filename, int flags);
                    static /*0xff1554*/ nint dlerror();
                    static /*0xfc77cc*/ nint dlsym(nint handle, string symbol);
                }

                class MacOSX
                {
                    static /*0xff15c8*/ nint dlopen(string filename, int flags);
                    static /*0xff1670*/ nint dlerror();
                    static /*0xfc7878*/ nint dlsym(nint handle, string symbol);
                }

                class Mono
                {
                    static /*0xff16e4*/ nint dlopen(string filename, int flags);
                    static /*0xff1720*/ nint dlerror();
                    static /*0xfc76dc*/ nint dlsym(nint handle, string symbol);
                }

                class CoreCLR
                {
                    static /*0xff1390*/ nint dlopen(string filename, int flags);
                    static /*0xff1438*/ nint dlerror();
                    static /*0xfc7720*/ nint dlsym(nint handle, string symbol);
                }
            }

            class UserAgentStringProvider
            {
                static /*0x0*/ Grpc.Core.Internal.UserAgentStringProvider defaultInstance;
                /*0x10*/ string userAgentString;

                static /*0xfc7c18*/ UserAgentStringProvider();
                static /*0xfc80ac*/ Grpc.Core.Internal.UserAgentStringProvider get_DefaultInstance();
                static /*0xfc8318*/ string TryGetArchitectureString(Grpc.Core.Internal.CommonPlatformDetection.CpuArchitecture arch);
                static /*0xfc8118*/ string SanitizeFrameworkDescription(string frameworkDescription);
                /*0xfc7d78*/ UserAgentStringProvider(string grpcCsharpVersion, string frameworkDescription, string clrVersion, string tfm, Grpc.Core.Internal.CommonPlatformDetection.CpuArchitecture arch);
                /*0xfc8110*/ string get_GrpcCsharpUserAgentString();
            }

            class WellKnownStrings
            {
                static /*0xfc83bc*/ ulong Coerce64(byte* value);
                static /*0xfc83c4*/ ushort Coerce16(byte* value);
                static /*0xfc83cc*/ string TryIdentify(nint source, int length);
                static /*0xfc83d0*/ string TryIdentify(byte* source, int length);
            }
        }
    }
}
