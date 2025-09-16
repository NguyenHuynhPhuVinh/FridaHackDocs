class <Module>
{
}

namespace Best
{
    namespace SignalR
    {
        enum TransportTypes
        {
            WebSocket = 0,
            LongPolling = 1,
        }

        enum TransferModes
        {
            Binary = 0,
            Text = 1,
        }

        enum TransportStates
        {
            Initial = 0,
            Connecting = 1,
            Connected = 2,
            Closing = 3,
            Failed = 4,
            Closed = 5,
        }

        enum ConnectionStates
        {
            Initial = 0,
            Authenticating = 1,
            Negotiating = 2,
            Redirected = 3,
            Reconnecting = 4,
            Connected = 5,
            CloseInitiated = 6,
            Closed = 7,
        }

        enum TransportEvents
        {
            SelectedToConnect = 0,
            FailedToConnect = 1,
            Connected = 2,
            Closed = 3,
            ClosedWithError = 4,
        }

        interface ITransport
        {
            /*0x3814574*/ Best.SignalR.TransportTypes get_TransportType();
            /*0x38148bc*/ string get_ErrorReason();
            /*0x3816710*/ void add_OnStateChanged(System.Action<Best.SignalR.TransportStates, Best.SignalR.TransportStates> value);
            /*0x3816710*/ void remove_OnStateChanged(System.Action<Best.SignalR.TransportStates, Best.SignalR.TransportStates> value);
            /*0x38159dc*/ void StartConnect();
            /*0x38159dc*/ void StartClose();
            /*0x3815c80*/ void Send(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment bufferSegment);
        }

        interface IEncoder
        {
        }

        struct CallbackDescriptor
        {
            /*0x10*/ System.Type[] ParamTypes;
            /*0x18*/ System.Action<System.Object[]> Callback;

            /*0x3f65574*/ CallbackDescriptor(System.Type[] paramTypes, System.Action<System.Object[]> callback);
        }

        struct FunctionCallbackDescriptor
        {
            /*0x10*/ System.Type ReturnType;
            /*0x18*/ System.Type[] ParamTypes;
            /*0x20*/ System.Func<System.Object[], object> Callback;

            /*0x3f655a4*/ FunctionCallbackDescriptor(System.Type returnType, System.Type[] paramTypes, System.Func<System.Object[], object> callback);
        }

        struct InvocationDefinition
        {
            /*0x10*/ System.Action<Best.SignalR.Messages.Message> callback;
            /*0x18*/ System.Type returnType;
        }

        class Subscription
        {
            /*0x10*/ System.Collections.Generic.List<Best.SignalR.CallbackDescriptor> callbacks;
            /*0x18*/ System.Collections.Generic.List<Best.SignalR.FunctionCallbackDescriptor> functionCallbacks;

            /*0x3f65840*/ Subscription();
            /*0x3f655e8*/ void Add(System.Type[] paramTypes, System.Action<System.Object[]> callback);
            /*0x3f656d4*/ void AddFunc(System.Type resultType, System.Type[] paramTypes, System.Func<System.Object[], object> callback);
        }

        class WebsocketOptions
        {
            /*0x10*/ System.Func<Best.WebSockets.Extensions.IExtension[]> <ExtensionsFactory>k__BackingField;
            /*0x18*/ System.Nullable<System.TimeSpan> <PingIntervalOverride>k__BackingField;
            /*0x28*/ System.Nullable<System.TimeSpan> <CloseAfterNoMessageOverride>k__BackingField;

            /*0x3f658ec*/ WebsocketOptions();
            /*0x3f658cc*/ System.Func<Best.WebSockets.Extensions.IExtension[]> get_ExtensionsFactory();
            /*0x3f658d4*/ System.Nullable<System.TimeSpan> get_PingIntervalOverride();
            /*0x3f658e0*/ System.Nullable<System.TimeSpan> get_CloseAfterNoMessageOverride();
        }

        class HubOptions
        {
            /*0x10*/ bool <SkipNegotiation>k__BackingField;
            /*0x14*/ Best.SignalR.TransportTypes <PreferedTransport>k__BackingField;
            /*0x18*/ System.TimeSpan <PingInterval>k__BackingField;
            /*0x20*/ System.TimeSpan <PingTimeoutInterval>k__BackingField;
            /*0x28*/ int <MaxRedirects>k__BackingField;
            /*0x30*/ System.TimeSpan <ConnectTimeout>k__BackingField;
            /*0x38*/ bool <UseStatefulReconnect>k__BackingField;
            /*0x40*/ Best.SignalR.WebsocketOptions <WebsocketOptions>k__BackingField;

            /*0x3f65a58*/ HubOptions();
            /*0x3f659e4*/ bool get_SkipNegotiation();
            /*0x3f659ec*/ void set_SkipNegotiation(bool value);
            /*0x3f659f8*/ Best.SignalR.TransportTypes get_PreferedTransport();
            /*0x3f65a00*/ void set_PreferedTransport(Best.SignalR.TransportTypes value);
            /*0x3f65a08*/ System.TimeSpan get_PingInterval();
            /*0x3f65a10*/ void set_PingInterval(System.TimeSpan value);
            /*0x3f65a18*/ System.TimeSpan get_PingTimeoutInterval();
            /*0x3f65a20*/ void set_PingTimeoutInterval(System.TimeSpan value);
            /*0x3f65a28*/ int get_MaxRedirects();
            /*0x3f65a30*/ void set_MaxRedirects(int value);
            /*0x3f65a38*/ System.TimeSpan get_ConnectTimeout();
            /*0x3f65a40*/ void set_ConnectTimeout(System.TimeSpan value);
            /*0x3f65a48*/ bool get_UseStatefulReconnect();
            /*0x3f65a50*/ Best.SignalR.WebsocketOptions get_WebsocketOptions();
        }

        interface IRetryPolicy
        {
            System.Nullable<System.TimeSpan> GetNextRetryDelay(Best.SignalR.RetryContext context);
        }

        struct RetryContext
        {
            /*0x10*/ uint PreviousRetryCount;
            /*0x18*/ System.TimeSpan ElapsedTime;
            /*0x20*/ string RetryReason;
        }

        class DefaultRetryPolicy : Best.SignalR.IRetryPolicy
        {
            static /*0x0*/ System.Nullable<System.TimeSpan> DefaultBackoffTimes;
            /*0x10*/ System.Nullable<System.TimeSpan> backoffTimes;

            static /*0x3f65be8*/ DefaultRetryPolicy();
            /*0x3f65b34*/ DefaultRetryPolicy();
            /*0x3f65ba4*/ System.Nullable<System.TimeSpan> GetNextRetryDelay(Best.SignalR.RetryContext context);
        }

        class HubConnection : Best.HTTP.Shared.Extensions.IHeartbeat
        {
            static /*0x0*/ object[] EmptyArgs;
            /*0x10*/ System.Uri <Uri>k__BackingField;
            /*0x18*/ int _state;
            /*0x20*/ Best.SignalR.ITransport <Transport>k__BackingField;
            /*0x28*/ Best.SignalR.IProtocol <Protocol>k__BackingField;
            /*0x30*/ System.Action<Best.SignalR.HubConnection, System.Uri, System.Uri> OnRedirected;
            /*0x38*/ System.Action<Best.SignalR.HubConnection> OnConnected;
            /*0x40*/ System.Action<Best.SignalR.HubConnection, string> OnError;
            /*0x48*/ System.Action<Best.SignalR.HubConnection> OnClosed;
            /*0x50*/ System.Func<Best.SignalR.HubConnection, Best.SignalR.Messages.Message, bool> OnMessage;
            /*0x58*/ System.Action<Best.SignalR.HubConnection, string> OnReconnecting;
            /*0x60*/ System.Action<Best.SignalR.HubConnection> OnReconnected;
            /*0x68*/ System.Action<Best.SignalR.HubConnection, Best.SignalR.ITransport, Best.SignalR.TransportEvents> OnTransportEvent;
            /*0x70*/ Best.SignalR.IAuthenticationProvider <AuthenticationProvider>k__BackingField;
            /*0x78*/ Best.SignalR.Messages.NegotiationResult <NegotiationResult>k__BackingField;
            /*0x80*/ Best.SignalR.HubOptions <Options>k__BackingField;
            /*0x88*/ int <RedirectCount>k__BackingField;
            /*0x90*/ Best.SignalR.IRetryPolicy <ReconnectPolicy>k__BackingField;
            /*0x98*/ Best.HTTP.Shared.Logger.LoggingContext <Context>k__BackingField;
            /*0xa0*/ long lastInvocationId;
            /*0xa8*/ int lastStreamId;
            /*0xb0*/ System.Collections.Concurrent.ConcurrentDictionary<long, Best.SignalR.InvocationDefinition> invocations;
            /*0xb8*/ System.Collections.Concurrent.ConcurrentDictionary<string, Best.SignalR.Subscription> subscriptions;
            /*0xc0*/ System.DateTime lastMessageSentAt;
            /*0xc8*/ System.DateTime lastMessageReceivedAt;
            /*0xd0*/ long currentReceivingSequenceId;
            /*0xd8*/ long lastMessageReceivedSequenceId;
            /*0xe0*/ long lastMessageAckedSequenceId;
            /*0xe8*/ System.Collections.Generic.Queue<Best.SignalR.Messages.SentMessage> sentMessages;
            /*0xf0*/ long currentSendingSequenceId;
            /*0xf8*/ System.DateTime connectionStartedAt;
            /*0x100*/ Best.SignalR.RetryContext currentContext;
            /*0x118*/ System.DateTime reconnectStartTime;
            /*0x120*/ System.DateTime reconnectAt;
            /*0x128*/ System.Collections.Generic.List<Best.SignalR.TransportTypes> triedoutTransports;
            /*0x130*/ System.Threading.ReaderWriterLockSlim rwLock;
            /*0x138*/ bool pausedInLastFrame;
            /*0x140*/ Cysharp.Threading.Tasks.UniTaskCompletionSource<Best.SignalR.HubConnection> connectAsyncTaskCompletionSource;
            /*0x148*/ Cysharp.Threading.Tasks.UniTaskCompletionSource<Best.SignalR.HubConnection> closeAsyncTaskCompletionSource;
            /*0x150*/ System.Collections.Generic.List<Best.SignalR.Messages.Message> delayedMessages;
            /*0x158*/ bool defaultReconnect;

            static /*0x3f72314*/ HubConnection();
            /*0x3f66530*/ HubConnection(System.Uri hubUri, Best.SignalR.IProtocol protocol, Best.SignalR.HubOptions options);
            /*0x3f65d7c*/ System.Uri get_Uri();
            /*0x3f65d84*/ void set_Uri(System.Uri value);
            /*0x3f65d8c*/ Best.SignalR.ConnectionStates get_State();
            /*0x3f65da4*/ void set_State(Best.SignalR.ConnectionStates value);
            /*0x3f65dd0*/ Best.SignalR.ITransport get_Transport();
            /*0x3f65dd8*/ void set_Transport(Best.SignalR.ITransport value);
            /*0x3f65de0*/ Best.SignalR.IProtocol get_Protocol();
            /*0x3f65de8*/ void set_Protocol(Best.SignalR.IProtocol value);
            /*0x3f65df0*/ void add_OnConnected(System.Action<Best.SignalR.HubConnection> value);
            /*0x3f65ea0*/ void remove_OnConnected(System.Action<Best.SignalR.HubConnection> value);
            /*0x3f65f50*/ void add_OnError(System.Action<Best.SignalR.HubConnection, string> value);
            /*0x3f66000*/ void remove_OnError(System.Action<Best.SignalR.HubConnection, string> value);
            /*0x3f660b0*/ void add_OnClosed(System.Action<Best.SignalR.HubConnection> value);
            /*0x3f66160*/ void remove_OnClosed(System.Action<Best.SignalR.HubConnection> value);
            /*0x3f66210*/ void add_OnReconnecting(System.Action<Best.SignalR.HubConnection, string> value);
            /*0x3f662c0*/ void remove_OnReconnecting(System.Action<Best.SignalR.HubConnection, string> value);
            /*0x3f66370*/ void add_OnReconnected(System.Action<Best.SignalR.HubConnection> value);
            /*0x3f66420*/ void remove_OnReconnected(System.Action<Best.SignalR.HubConnection> value);
            /*0x3f664d0*/ Best.SignalR.IAuthenticationProvider get_AuthenticationProvider();
            /*0x3f664d8*/ void set_AuthenticationProvider(Best.SignalR.IAuthenticationProvider value);
            /*0x3f664e0*/ Best.SignalR.Messages.NegotiationResult get_NegotiationResult();
            /*0x3f664e8*/ void set_NegotiationResult(Best.SignalR.Messages.NegotiationResult value);
            /*0x3f664f0*/ Best.SignalR.HubOptions get_Options();
            /*0x3f664f8*/ void set_Options(Best.SignalR.HubOptions value);
            /*0x3f66500*/ int get_RedirectCount();
            /*0x3f66508*/ void set_RedirectCount(int value);
            /*0x3f66510*/ Best.SignalR.IRetryPolicy get_ReconnectPolicy();
            /*0x3f66518*/ void set_ReconnectPolicy(Best.SignalR.IRetryPolicy value);
            /*0x3f66520*/ Best.HTTP.Shared.Logger.LoggingContext get_Context();
            /*0x3f66528*/ void set_Context(Best.HTTP.Shared.Logger.LoggingContext value);
            /*0x3f66928*/ void StartConnect();
            /*0x3f69a68*/ Cysharp.Threading.Tasks.UniTask<Best.SignalR.HubConnection> ConnectAsync();
            /*0x3f69ce8*/ void StartClose();
            /*0x3f6a0e4*/ Cysharp.Threading.Tasks.UniTask<Best.SignalR.HubConnection> CloseAsync();
            /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<TResult> InvokeAsync<TResult>(string target, object[] args);
            /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<TResult> InvokeAsync<TResult>(string target, System.Threading.CancellationToken cancellationToken, object[] args);
            /*0x3816810*/ void On<T1>(string methodName, System.Action<T1> callback);
            /*0x3816810*/ void On<Result>(string methodName, System.Func<Result> callback);
            /*0x3f6a2b8*/ void OnAsyncConnectedCallback(Best.SignalR.HubConnection hub);
            /*0x3f6a3d0*/ void OnAsyncConnectFailedCallback(Best.SignalR.HubConnection hub, string error);
            /*0x3f6a524*/ void OnAuthenticationSucceded(Best.SignalR.IAuthenticationProvider provider);
            /*0x3f6a7b0*/ void OnAuthenticationFailed(Best.SignalR.IAuthenticationProvider provider, string reason);
            /*0x3f69554*/ void StartNegotiation();
            /*0x3f6aa68*/ void ConnectImpl(Best.SignalR.TransportTypes transport);
            /*0x3f6b058*/ bool IsTransportSupported(string transportName);
            /*0x3f6b1f0*/ void OnNegotiationRequestFinished(Best.HTTP.HTTPRequest req, Best.HTTP.HTTPResponse resp);
            /*0x3f6cd94*/ void OnClosedAsyncCallback(Best.SignalR.HubConnection hub);
            /*0x3f6ceac*/ void OnClosedAsyncErrorCallback(Best.SignalR.HubConnection hub, string error);
            /*0x3f6d000*/ long InvokeImp(string target, object[] args, System.Action<Best.SignalR.Messages.Message> callback, System.Type itemType, bool isStreamingInvocation);
            /*0x3f6d2ec*/ void SendMessage(Best.SignalR.Messages.Message message);
            /*0x3f6dfdc*/ void On(string methodName, System.Type[] paramTypes, System.Action<System.Object[]> callback);
            /*0x3816920*/ void OnFunc<Result>(string methodName, System.Type[] paramTypes, System.Func<System.Object[], object> callback);
            /*0x3f6e108*/ Best.SignalR.Subscription GetSubscription(string methodName);
            /*0x3f6e180*/ System.Type GetItemType(long invocationId);
            /*0x3f6e1f8*/ void OnMessages(System.Collections.Generic.List<Best.SignalR.Messages.Message> messages);
            /*0x3f6feac*/ void Transport_OnStateChanged(Best.SignalR.TransportStates oldState, Best.SignalR.TransportStates newState);
            /*0x3f70af8*/ System.Nullable<Best.SignalR.TransportTypes> GetNextTransportToTry();
            /*0x3f66f64*/ void SetState(Best.SignalR.ConnectionStates state, string errorReason, bool allowReconnect);
            /*0x3f70ee4*/ void OnApplicationForegroundStateChanged(bool isPaused);
            /*0x3f71064*/ void Best.HTTP.Shared.Extensions.IHeartbeat.OnHeartbeatUpdate(System.DateTime now, System.TimeSpan dif);
            /*0x3f7207c*/ void CleanUp();

            class <>c
            {
                static /*0x0*/ Best.SignalR.HubConnection.<> <>9;
                static /*0x8*/ System.Func<string, Best.SignalR.Subscription> <>9__123_0;
                static /*0x10*/ System.Predicate<Best.SignalR.Messages.Message> <>9__129_0;
                static /*0x18*/ System.Predicate<Best.SignalR.Messages.Message> <>9__133_0;

                static /*0x3f72388*/ <>c();
                /*0x3f723f0*/ <>c();
                /*0x3f723f8*/ Best.SignalR.Subscription <On>b__123_0(string _);
                /*0x3f72448*/ bool <Transport_OnStateChanged>b__129_0(Best.SignalR.Messages.Message dm);
                /*0x3f72458*/ bool <Best.HTTP.Shared.Extensions.IHeartbeat.OnHeartbeatUpdate>b__133_0(Best.SignalR.Messages.Message dm);
            }

            class <>c__124<Result>
            {
                static /*0x0*/ Best.SignalR.HubConnection.<>c__124<Result> <>9;
                static /*0x0*/ System.Func<string, Best.SignalR.Subscription> <>9__124_0;

                static /*0x383e7a0*/ <>c__124();
                /*0x38159dc*/ <>c__124();
                /*0x3814a3c*/ Best.SignalR.Subscription <OnFunc>b__124_0(string _);
            }

            class <>c__DisplayClass102_0<T1>
            {
                /*0x0*/ System.Action<T1> callback;

                /*0x38159dc*/ <>c__DisplayClass102_0();
                /*0x3816710*/ void <On>b__0(object[] args);
            }

            class <>c__DisplayClass106_0<Result>
            {
                /*0x0*/ System.Func<Result> callback;

                /*0x38159dc*/ <>c__DisplayClass106_0();
                /*0x3814a3c*/ object <On>b__0(object[] args);
            }

            class <>c__DisplayClass128_0
            {
                /*0x10*/ Best.SignalR.Messages.Message message;
                /*0x68*/ Best.SignalR.HubConnection <>4__this;

                /*0x3f6fe9c*/ <>c__DisplayClass128_0();
            }

            class <>c__DisplayClass128_1
            {
                /*0x10*/ System.Type taskType;
                /*0x18*/ Best.SignalR.HubConnection.<> CS$<>8__locals1;

                /*0x3f6fea4*/ <>c__DisplayClass128_1();
                /*0x3f72468*/ void <OnMessages>b__0(System.Threading.Tasks.Task t);
            }

            class <>c__DisplayClass95_0<TResult>
            {
                /*0x0*/ System.Threading.CancellationToken cancellationToken;
                /*0x0*/ Cysharp.Threading.Tasks.UniTaskCompletionSource<TResult> tcs;
                /*0x0*/ Best.SignalR.HubConnection <>4__this;

                /*0x38159dc*/ <>c__DisplayClass95_0();
                void <InvokeAsync>b__0(Best.SignalR.Messages.Message message);
                /*0x38159dc*/ void <InvokeAsync>b__1();
            }
        }

        class OnAuthenticationSuccededDelegate : System.MulticastDelegate
        {
            /*0x3f69340*/ OnAuthenticationSuccededDelegate(object object, nint method);
            /*0x3f7273c*/ void Invoke(Best.SignalR.IAuthenticationProvider provider);
        }

        class OnAuthenticationFailedDelegate : System.MulticastDelegate
        {
            /*0x3f69448*/ OnAuthenticationFailedDelegate(object object, nint method);
            /*0x3f72750*/ void Invoke(Best.SignalR.IAuthenticationProvider provider, string reason);
        }

        interface IAuthenticationProvider
        {
            /*0x3813ffc*/ bool get_IsPreAuthRequired();
            /*0x3816710*/ void add_OnAuthenticationSucceded(Best.SignalR.OnAuthenticationSuccededDelegate value);
            /*0x3816710*/ void remove_OnAuthenticationSucceded(Best.SignalR.OnAuthenticationSuccededDelegate value);
            /*0x3816710*/ void add_OnAuthenticationFailed(Best.SignalR.OnAuthenticationFailedDelegate value);
            /*0x3816710*/ void remove_OnAuthenticationFailed(Best.SignalR.OnAuthenticationFailedDelegate value);
            /*0x38159dc*/ void StartAuthentication();
            /*0x3816710*/ void PrepareRequest(Best.HTTP.HTTPRequest request);
            /*0x3814a3c*/ System.Uri PrepareUri(System.Uri uri);
            /*0x38159dc*/ void Cancel();
        }

        interface IProtocol
        {
            /*0x38148bc*/ string get_Name();
            /*0x3816710*/ void set_Connection(Best.SignalR.HubConnection value);
            void ParseMessages(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment segment, ref System.Collections.Generic.List<Best.SignalR.Messages.Message> messages);
            Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment EncodeMessage(Best.SignalR.Messages.Message message);
            /*0x3814b90*/ object[] GetRealArguments(System.Type[] argTypes, object[] arguments);
            /*0x3814b90*/ object ConvertTo(System.Type toType, object obj);
        }

        class JsonProtocol
        {
            static /*0x3f72764*/ Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment WithSeparator(string str);
        }

        namespace Transports
        {
            class LongPollingTransport : Best.SignalR.Transports.TransportBase
            {
                /*0x40*/ System.Collections.Concurrent.ConcurrentQueue<Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment> outgoingMessages;
                /*0x48*/ int sendingInProgress;
                /*0x50*/ Best.HTTP.Shared.Streams.BufferSegmentStream stream;

                /*0x3f6b124*/ LongPollingTransport(Best.SignalR.HubConnection con);
                /*0x3f7287c*/ Best.SignalR.TransportTypes get_TransportType();
                /*0x3f729e0*/ void StartConnect();
                /*0x3f72ff0*/ void Send(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment msg);
                /*0x3f7330c*/ void StartClose();
                /*0x3f7307c*/ void SendMessages();
                /*0x3f7372c*/ void DoPoll();
                /*0x3f7347c*/ void SendConnectionCloseRequest(int retryCount);
                /*0x3f73a38*/ void OnHandshakeRequestFinished(Best.HTTP.HTTPRequest req, Best.HTTP.HTTPResponse resp);
                /*0x3f73c88*/ void OnSendMessagesFinished(Best.HTTP.HTTPRequest req, Best.HTTP.HTTPResponse resp);
                /*0x3f73fe4*/ void OnPollRequestFinished(Best.HTTP.HTTPRequest req, Best.HTTP.HTTPResponse resp);
                /*0x3f747e8*/ void OnConnectionCloseRequestFinished(Best.HTTP.HTTPRequest req, Best.HTTP.HTTPResponse resp);
            }

            class TransportBase : Best.SignalR.ITransport
            {
                /*0x10*/ Best.SignalR.TransportStates _state;
                /*0x18*/ string <ErrorReason>k__BackingField;
                /*0x20*/ System.Action<Best.SignalR.TransportStates, Best.SignalR.TransportStates> OnStateChanged;
                /*0x28*/ Best.HTTP.Shared.Logger.LoggingContext <Context>k__BackingField;
                /*0x30*/ System.Collections.Generic.List<Best.SignalR.Messages.Message> messages;
                /*0x38*/ Best.SignalR.HubConnection connection;

                /*0x3f72884*/ TransportBase(Best.SignalR.HubConnection con);
                /*0x3814574*/ Best.SignalR.TransportTypes get_TransportType();
                /*0x3f74d48*/ Best.SignalR.TransportStates get_State();
                /*0x3f72d94*/ void set_State(Best.SignalR.TransportStates value);
                /*0x3f74d50*/ string get_ErrorReason();
                /*0x3f74d58*/ void set_ErrorReason(string value);
                /*0x3f74d60*/ void add_OnStateChanged(System.Action<Best.SignalR.TransportStates, Best.SignalR.TransportStates> value);
                /*0x3f74e10*/ void remove_OnStateChanged(System.Action<Best.SignalR.TransportStates, Best.SignalR.TransportStates> value);
                /*0x3f74ec0*/ Best.HTTP.Shared.Logger.LoggingContext get_Context();
                /*0x3f74ec8*/ void set_Context(Best.HTTP.Shared.Logger.LoggingContext value);
                /*0x38159dc*/ void StartConnect();
                /*0x3815c80*/ void Send(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment msg);
                /*0x38159dc*/ void StartClose();
                /*0x3f74ed0*/ string ParseHandshakeResponse(string data);
                /*0x3f7476c*/ void HandleHandshakeResponse(string data);
                /*0x3f72dc8*/ System.Uri BuildUri(System.Uri baseUri);
            }

            class WebSocketTransport : Best.SignalR.Transports.TransportBase
            {
                /*0x40*/ Best.WebSockets.WebSocket webSocket;

                /*0x3f6b120*/ WebSocketTransport(Best.SignalR.HubConnection con);
                /*0x3f74fd4*/ Best.SignalR.TransportTypes get_TransportType();
                /*0x3f74fdc*/ void StartConnect();
                /*0x3f759c8*/ void Send(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment msg);
                /*0x3f75c24*/ void OnOpen(Best.WebSockets.WebSocket webSocket);
                /*0x3f75f1c*/ void OnMessage(Best.WebSockets.WebSocket webSocket, string data);
                /*0x3f765fc*/ void OnBinaryNoAlloc(Best.WebSockets.WebSocket webSocket, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data);
                /*0x3f76d40*/ void OnClosed(Best.WebSockets.WebSocket webSocket, Best.WebSockets.WebSocketStatusCodes code, string message);
                /*0x3f76f74*/ void StartClose();
                /*0x3f7712c*/ void <StartConnect>b__4_0(Best.WebSockets.WebSocket ws, Best.HTTP.HTTPRequest internalRequest);

                class <>c
                {
                    static /*0x0*/ Best.SignalR.Transports.WebSocketTransport.<> <>9;
                    static /*0x8*/ System.Predicate<byte> <>9__8_0;

                    static /*0x3f771e0*/ <>c();
                    /*0x3f77248*/ <>c();
                    /*0x3f77250*/ bool <OnBinaryNoAlloc>b__8_0(byte b);
                }
            }
        }

        namespace Messages
        {
            struct Completion
            {
                /*0x10*/ Best.SignalR.Messages.MessageTypes type;
                /*0x18*/ string invocationId;
            }

            struct CompletionWithResult
            {
                /*0x10*/ Best.SignalR.Messages.MessageTypes type;
                /*0x18*/ string invocationId;
                /*0x20*/ object result;
            }

            struct CompletionWithError
            {
                /*0x10*/ Best.SignalR.Messages.MessageTypes type;
                /*0x18*/ string invocationId;
                /*0x20*/ string error;
            }

            struct StreamItemMessage
            {
                /*0x10*/ Best.SignalR.Messages.MessageTypes type;
                /*0x18*/ string invocationId;
                /*0x20*/ object item;
            }

            struct InvocationMessage
            {
                /*0x10*/ Best.SignalR.Messages.MessageTypes type;
                /*0x18*/ string invocationId;
                /*0x20*/ bool nonblocking;
                /*0x28*/ string target;
                /*0x30*/ object[] arguments;
            }

            struct UploadInvocationMessage
            {
                /*0x10*/ Best.SignalR.Messages.MessageTypes type;
                /*0x18*/ string invocationId;
                /*0x20*/ bool nonblocking;
                /*0x28*/ string target;
                /*0x30*/ object[] arguments;
                /*0x38*/ string[] streamIds;
            }

            struct CancelInvocationMessage
            {
                /*0x10*/ string invocationId;

                /*0x3f77260*/ Best.SignalR.Messages.MessageTypes get_type();
            }

            struct PingMessage
            {
                /*0x3f77268*/ Best.SignalR.Messages.MessageTypes get_type();
            }

            struct CloseMessage
            {
                /*0x3f77270*/ Best.SignalR.Messages.MessageTypes get_type();
            }

            struct CloseWithErrorMessage
            {
                /*0x10*/ string error;

                /*0x3f77278*/ Best.SignalR.Messages.MessageTypes get_type();
            }

            enum MessageTypes
            {
                Handshake = 0,
                Invocation = 1,
                StreamItem = 2,
                Completion = 3,
                StreamInvocation = 4,
                CancelInvocation = 5,
                Ping = 6,
                Close = 7,
                Ack = 8,
                Sequence = 9,
            }

            struct Message
            {
                /*0x10*/ Best.SignalR.Messages.MessageTypes type;
                /*0x18*/ long sequenceId;
                /*0x20*/ string invocationId;
                /*0x28*/ bool nonblocking;
                /*0x30*/ string target;
                /*0x38*/ object[] arguments;
                /*0x40*/ string[] streamIds;
                /*0x48*/ object item;
                /*0x50*/ object result;
                /*0x58*/ string error;
                /*0x60*/ bool allowReconnect;

                /*0x3f6df98*/ bool get_ShouldIncrementSequenceId();
                /*0x3f6daf8*/ string ToString();
            }

            class SupportedTransport
            {
                /*0x10*/ string <Name>k__BackingField;
                /*0x18*/ System.Collections.Generic.List<string> <SupportedFormats>k__BackingField;

                /*0x3f77298*/ SupportedTransport(string transportName, System.Collections.Generic.List<string> transferFormats);
                /*0x3f77280*/ string get_Name();
                /*0x3f77288*/ void set_Name(string value);
                /*0x3f77290*/ void set_SupportedFormats(System.Collections.Generic.List<string> value);
            }

            class NegotiationResult
            {
                /*0x10*/ int <NegotiateVersion>k__BackingField;
                /*0x18*/ string <ConnectionToken>k__BackingField;
                /*0x20*/ string <ConnectionId>k__BackingField;
                /*0x28*/ System.Collections.Generic.List<Best.SignalR.Messages.SupportedTransport> <SupportedTransports>k__BackingField;
                /*0x30*/ System.Uri <Url>k__BackingField;
                /*0x38*/ string <AccessToken>k__BackingField;
                /*0x40*/ bool <UseStatefulReconnect>k__BackingField;
                /*0x48*/ Best.HTTP.HTTPResponse <NegotiationResponse>k__BackingField;

                static /*0x3f6bcec*/ Best.SignalR.Messages.NegotiationResult Parse(Best.HTTP.HTTPResponse resp, ref string error, Best.SignalR.HubConnection hub);
                static /*0x3f77350*/ bool IsAbsolute(string url);
                /*0x3f6cd8c*/ NegotiationResult();
                /*0x3f772dc*/ void set_NegotiateVersion(int value);
                /*0x3f772e4*/ string get_ConnectionToken();
                /*0x3f772ec*/ void set_ConnectionToken(string value);
                /*0x3f772f4*/ string get_ConnectionId();
                /*0x3f772fc*/ void set_ConnectionId(string value);
                /*0x3f77304*/ System.Collections.Generic.List<Best.SignalR.Messages.SupportedTransport> get_SupportedTransports();
                /*0x3f7730c*/ void set_SupportedTransports(System.Collections.Generic.List<Best.SignalR.Messages.SupportedTransport> value);
                /*0x3f77314*/ System.Uri get_Url();
                /*0x3f7731c*/ void set_Url(System.Uri value);
                /*0x3f77324*/ string get_AccessToken();
                /*0x3f7732c*/ void set_AccessToken(string value);
                /*0x3f77334*/ bool get_UseStatefulReconnect();
                /*0x3f7733c*/ void set_UseStatefulReconnect(bool value);
                /*0x3f77348*/ void set_NegotiationResponse(Best.HTTP.HTTPResponse value);
            }

            struct SentMessage
            {
                /*0x10*/ long SequenceId;
                /*0x18*/ Best.SignalR.Messages.Message Message;

                /*0x3f6dfac*/ SentMessage(long sequenceId, Best.SignalR.Messages.Message message);
                /*0x3f773e4*/ string ToString();
            }
        }

        namespace Authentication
        {
            class DefaultAccessTokenAuthenticator : Best.SignalR.IAuthenticationProvider
            {
                /*0x10*/ Best.SignalR.OnAuthenticationSuccededDelegate OnAuthenticationSucceded;
                /*0x18*/ Best.SignalR.OnAuthenticationFailedDelegate OnAuthenticationFailed;
                /*0x20*/ Best.SignalR.HubConnection _connection;

                /*0x3f668f8*/ DefaultAccessTokenAuthenticator(Best.SignalR.HubConnection connection);
                /*0x3f7749c*/ bool get_IsPreAuthRequired();
                /*0x3f774a4*/ void add_OnAuthenticationSucceded(Best.SignalR.OnAuthenticationSuccededDelegate value);
                /*0x3f77540*/ void remove_OnAuthenticationSucceded(Best.SignalR.OnAuthenticationSuccededDelegate value);
                /*0x3f775dc*/ void add_OnAuthenticationFailed(Best.SignalR.OnAuthenticationFailedDelegate value);
                /*0x3f77678*/ void remove_OnAuthenticationFailed(Best.SignalR.OnAuthenticationFailedDelegate value);
                /*0x3f77714*/ void StartAuthentication();
                /*0x3f77718*/ void PrepareRequest(Best.HTTP.HTTPRequest request);
                /*0x3f779c4*/ System.Uri PrepareUri(System.Uri uri);
                /*0x3f77818*/ System.Uri PrepareUriImpl(System.Uri uri);
                /*0x3f77ad4*/ void Cancel();
            }
        }
    }
}
