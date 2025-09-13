class <Module>
{
}

namespace MagicOnion
{
    class ChannelExtensions
    {
        static /*0x2aca274*/ void RegisterStreamingSubscription(Grpc.Core.Channel channel, System.IDisposable subscription);

        class <>c__DisplayClass0_0
        {
            /*0x10*/ System.IDisposable subscription;

            /*0x2aca360*/ <>c__DisplayClass0_0();
            /*0x2acdb40*/ void <RegisterStreamingSubscription>b__0();
        }
    }

    class GrpcChannelx : Grpc.Core.ChannelBase, MagicOnion.Client.IMagicOnionAwareGrpcChannel, System.IDisposable
    {
        /*0x18*/ System.Action<MagicOnion.GrpcChannelx> _onDispose;
        /*0x20*/ System.Collections.Generic.Dictionary<MagicOnion.IStreamingHubMarker, System.ValueTuple<System.Func<System.Threading.Tasks.Task>, MagicOnion.Client.ManagedStreamingHubInfo>> _streamingHubs;
        /*0x28*/ Grpc.Core.Channel _channel;
        /*0x30*/ bool _disposed;
        /*0x38*/ System.Uri <TargetUri>k__BackingField;
        /*0x40*/ int <Id>k__BackingField;

        static /*0x2acb990*/ MagicOnion.GrpcChannelx FromTarget(MagicOnion.Unity.GrpcChannelTarget target);
        static /*0x2acb9d4*/ MagicOnion.GrpcChannelx FromAddress(System.Uri target);
        static /*0x2acbb24*/ MagicOnion.GrpcChannelx ForTarget(MagicOnion.Unity.GrpcChannelTarget target);
        static /*0x2acbb68*/ MagicOnion.GrpcChannelx ForAddress(string target);
        static /*0x2acbbc8*/ MagicOnion.GrpcChannelx ForAddress(System.Uri target);
        static /*0x2acc4bc*/ void Forget(System.Threading.Tasks.Task t);
        static /*0x2acc7d4*/ void <DisposeStreamingHubClient>g__Forget|24_0(System.Threading.Tasks.Task t);
        /*0x2acaa34*/ GrpcChannelx(int id, System.Action<MagicOnion.GrpcChannelx> onDispose, Grpc.Core.Channel channel, System.Uri targetUri, System.Collections.Generic.IReadOnlyList<Grpc.Core.ChannelOption> channelOptions);
        /*0x2acb964*/ System.Uri get_TargetUri();
        /*0x2acb96c*/ int get_Id();
        /*0x2acb974*/ Grpc.Core.ChannelState get_ChannelState();
        /*0x2acbd18*/ Grpc.Core.CallInvoker CreateCallInvoker();
        /*0x2acbdac*/ System.Threading.Tasks.Task ShutdownAsyncCore();
        /*0x2acbec8*/ System.Threading.Tasks.Task ConnectAsync(System.Nullable<System.DateTime> deadline);
        /*0x2acbfe0*/ System.Collections.Generic.IReadOnlyCollection<MagicOnion.Client.ManagedStreamingHubInfo> MagicOnion.Client.IMagicOnionAwareGrpcChannel.GetAllManagedStreamingHubs();
        /*0x2acc208*/ void MagicOnion.Client.IMagicOnionAwareGrpcChannel.ManageStreamingHubClient(System.Type streamingHubType, MagicOnion.IStreamingHubMarker streamingHub, System.Func<System.Threading.Tasks.Task> disposeAsync, System.Threading.Tasks.Task waitForDisconnect);
        /*0x2acc3a4*/ System.Threading.Tasks.Task WaitForDisconnectAndDisposeAsync(MagicOnion.IStreamingHubMarker streamingHub, System.Threading.Tasks.Task waitForDisconnect);
        /*0x2acc580*/ void DisposeStreamingHubClient(MagicOnion.IStreamingHubMarker streamingHub);
        /*0x2acc898*/ void DisposeAllManagedStreamingHubs();
        /*0x2acaf98*/ void Dispose();
        /*0x2accb3c*/ System.Threading.Tasks.Task DisposeAsync();
        /*0x2acca20*/ System.Threading.Tasks.Task ShutdownInternalAsync();
        /*0x2acbd4c*/ void ThrowIfDisposed();

        struct <ShutdownAsyncCore>d__19 : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
            /*0x30*/ MagicOnion.GrpcChannelx <>4__this;
            /*0x38*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

            /*0xb226ec*/ void MoveNext();
            /*0xb226f4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }

        struct <ConnectAsync>d__20 : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
            /*0x30*/ MagicOnion.GrpcChannelx <>4__this;
            /*0x38*/ System.Nullable<System.DateTime> deadline;
            /*0x48*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

            /*0xb226b0*/ void MoveNext();
            /*0xb226b8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }

        class <>c
        {
            static /*0x0*/ MagicOnion.GrpcChannelx.<> <>9;
            static /*0x8*/ System.Func<System.ValueTuple<System.Func<System.Threading.Tasks.Task>, MagicOnion.Client.ManagedStreamingHubInfo>, MagicOnion.Client.ManagedStreamingHubInfo> <>9__21_0;

            static /*0x2acde70*/ <>c();
            /*0x2acded0*/ <>c();
            /*0x2acded8*/ MagicOnion.Client.ManagedStreamingHubInfo <MagicOnion.Client.IMagicOnionAwareGrpcChannel.GetAllManagedStreamingHubs>b__21_0(System.ValueTuple<System.Func<System.Threading.Tasks.Task>, MagicOnion.Client.ManagedStreamingHubInfo> x);
        }

        struct <WaitForDisconnectAndDisposeAsync>d__23 : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
            /*0x30*/ System.Threading.Tasks.Task waitForDisconnect;
            /*0x38*/ MagicOnion.GrpcChannelx <>4__this;
            /*0x40*/ MagicOnion.IStreamingHubMarker streamingHub;
            /*0x48*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

            /*0xb22714*/ void MoveNext();
            /*0xb2271c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }

        struct <DisposeAsync>d__27 : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
            /*0x30*/ MagicOnion.GrpcChannelx <>4__this;
            /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

            /*0xb226c4*/ void MoveNext();
            /*0xb226cc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }

        struct <ShutdownInternalAsync>d__28 : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
            /*0x30*/ MagicOnion.GrpcChannelx <>4__this;
            /*0x38*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

            /*0xb22700*/ void MoveNext();
            /*0xb22708*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }

        struct <Forget>d__30 : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
            /*0x38*/ System.Threading.Tasks.Task t;
            /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

            /*0xb226d8*/ void MoveNext();
            /*0xb226e0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }

        struct <<DisposeStreamingHubClient>g__Forget|24_0>d : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
            /*0x38*/ System.Threading.Tasks.Task t;
            /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

            /*0xb2269c*/ void MoveNext();
            /*0xb226a4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    class UnityDebugLogger : Grpc.Core.Logging.ILogger
    {
        /*0x10*/ System.Type forType;
        /*0x18*/ string forTypeString;
        /*0x20*/ bool errorToWarn;

        /*0x2acd270*/ UnityDebugLogger();
        /*0x2acd3d0*/ UnityDebugLogger(bool errorToWarn);
        /*0x2acd278*/ UnityDebugLogger(System.Type forType);
        Grpc.Core.Logging.ILogger ForType<T>();
        /*0x2acd400*/ void Debug(string message);
        /*0x2acd524*/ void Debug(string format, object[] formatArgs);
        /*0x2acd670*/ void Info(string message);
        /*0x2acd6f4*/ void Info(string format, object[] formatArgs);
        /*0x2acd780*/ void Warning(string message);
        /*0x2acd804*/ void Warning(string format, object[] formatArgs);
        /*0x2acd890*/ void Warning(System.Exception exception, string message);
        /*0x2acd928*/ void Error(string message);
        /*0x2acd9e0*/ void Error(string format, object[] formatArgs);
        /*0x2acdaa0*/ void Error(System.Exception exception, string message);
        /*0x2acdb38*/ System.Type get_AssociatedType();
        /*0x2acd484*/ string BuildMessage(string message);
        /*0x2acd5b0*/ string BuildMessage(string format, object[] args);
    }

    namespace Unity
    {
        class GrpcChannelProviderExtensions
        {
            static /*0x2acb174*/ MagicOnion.GrpcChannelx CreateChannel(MagicOnion.Unity.IGrpcChannelProvider provider, MagicOnion.Unity.GrpcChannelTarget target, Grpc.Core.ChannelOption[] channelOptions);
            static /*0x2acb384*/ MagicOnion.GrpcChannelx CreateChannel(MagicOnion.Unity.IGrpcChannelProvider provider, string host, int port, Grpc.Core.ChannelCredentials channelCredentials, Grpc.Core.ChannelOption[] channelOptions);
        }

        class GrpcChannelProvider
        {
            static /*0x0*/ MagicOnion.Unity.IGrpcChannelProvider _defaultProvider;

            static /*0x2acb08c*/ MagicOnion.Unity.IGrpcChannelProvider get_Default();
            static /*0x2acb124*/ void SetDefaultProvider(MagicOnion.Unity.IGrpcChannelProvider provider);
        }

        class LoggingGrpcChannelProvider : MagicOnion.Unity.IGrpcChannelProvider
        {
            /*0x10*/ MagicOnion.Unity.IGrpcChannelProvider _baseProvider;

            /*0x2accc40*/ LoggingGrpcChannelProvider(MagicOnion.Unity.IGrpcChannelProvider baseProvider);
            /*0x2acccc8*/ MagicOnion.GrpcChannelx CreateChannel(MagicOnion.Unity.CreateGrpcChannelContext context);
            /*0x2accf68*/ System.Collections.Generic.IReadOnlyCollection<MagicOnion.GrpcChannelx> GetAllChannels();
            /*0x2acd018*/ void UnregisterChannel(MagicOnion.GrpcChannelx channel);
            /*0x2acd1c0*/ void ShutdownAllChannels();
        }

        class DefaultGrpcChannelProvider : MagicOnion.Unity.IGrpcChannelProvider
        {
            /*0x10*/ System.Collections.Generic.List<MagicOnion.GrpcChannelx> _channels;
            /*0x18*/ Grpc.Core.ChannelOption[] _defaultChannelOptions;
            /*0x20*/ int _seq;

            /*0x2aca42c*/ DefaultGrpcChannelProvider();
            /*0x2aca500*/ DefaultGrpcChannelProvider(Grpc.Core.ChannelOption[] channelOptions);
            /*0x2aca5e8*/ MagicOnion.GrpcChannelx CreateChannel(MagicOnion.Unity.CreateGrpcChannelContext context);
            /*0x2aca9a4*/ Grpc.Core.ChannelOption[] CreateGrpcChannelOptions(Grpc.Core.ChannelOption[] channelOptions);
            /*0x2acab00*/ void UnregisterChannel(MagicOnion.GrpcChannelx channel);
            /*0x2acac08*/ System.Collections.Generic.IReadOnlyCollection<MagicOnion.GrpcChannelx> GetAllChannels();
            /*0x2acad14*/ void ShutdownAllChannels();
        }

        class GrpcChannelProviderHost : UnityEngine.MonoBehaviour
        {
            /*0x18*/ MagicOnion.Unity.IGrpcChannelProvider <Provider>k__BackingField;

            static /*0x2acb4b4*/ void Initialize(MagicOnion.Unity.IGrpcChannelProvider provider);
            /*0x2acb944*/ GrpcChannelProviderHost();
            /*0x2acb4a4*/ MagicOnion.Unity.IGrpcChannelProvider get_Provider();
            /*0x2acb4ac*/ void set_Provider(MagicOnion.Unity.IGrpcChannelProvider value);
            /*0x2acb69c*/ void InitializeCore(MagicOnion.Unity.IGrpcChannelProvider provider);
            /*0x2acb7e4*/ void OnDestroy();
            /*0x2acb894*/ void OnApplicationQuit();
        }

        struct GrpcChannelTarget
        {
            /*0x10*/ string <Host>k__BackingField;
            /*0x18*/ int <Port>k__BackingField;
            /*0x20*/ Grpc.Core.ChannelCredentials <ChannelCredentials>k__BackingField;

            /*0xb2268c*/ GrpcChannelTarget(string host, int port, Grpc.Core.ChannelCredentials channelCredentials);
            /*0xb22674*/ string get_Host();
            /*0xb2267c*/ int get_Port();
            /*0xb22684*/ Grpc.Core.ChannelCredentials get_ChannelCredentials();
        }

        interface IGrpcChannelProvider
        {
            MagicOnion.GrpcChannelx CreateChannel(MagicOnion.Unity.CreateGrpcChannelContext ctx);
            void UnregisterChannel(MagicOnion.GrpcChannelx channel);
            System.Collections.Generic.IReadOnlyCollection<MagicOnion.GrpcChannelx> GetAllChannels();
            void ShutdownAllChannels();
        }

        struct CreateGrpcChannelContext
        {
            /*0x10*/ MagicOnion.Unity.IGrpcChannelProvider <Provider>k__BackingField;
            /*0x18*/ MagicOnion.Unity.GrpcChannelTarget <Target>k__BackingField;
            /*0x30*/ Grpc.Core.ChannelOption[] <ChannelOptions>k__BackingField;

            /*0xb22604*/ CreateGrpcChannelContext(MagicOnion.Unity.IGrpcChannelProvider provider, MagicOnion.Unity.GrpcChannelTarget target, Grpc.Core.ChannelOption[] channelOptions);
            /*0xb225e0*/ MagicOnion.Unity.IGrpcChannelProvider get_Provider();
            /*0xb225e8*/ MagicOnion.Unity.GrpcChannelTarget get_Target();
            /*0xb225fc*/ Grpc.Core.ChannelOption[] get_ChannelOptions();
        }
    }
}
