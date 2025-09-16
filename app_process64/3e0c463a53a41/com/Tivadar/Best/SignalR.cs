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
            /*0x380b6a0*/ Best.SignalR.TransportTypes get_TransportType();
            /*0x380b9e8*/ string get_ErrorReason();
            /*0x380d83c*/ void add_OnStateChanged(System.Action<Best.SignalR.TransportStates, Best.SignalR.TransportStates> value);
            /*0x380d83c*/ void remove_OnStateChanged(System.Action<Best.SignalR.TransportStates, Best.SignalR.TransportStates> value);
            /*0x380cb08*/ void StartConnect();
            /*0x380cb08*/ void StartClose();
            /*0x380cdac*/ void Send(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment bufferSegment);
        }

        interface IEncoder
        {
        }

        struct CallbackDescriptor
        {
            /*0x10*/ System.Type[] ParamTypes;
            /*0x18*/ System.Action<System.Object[]> Callback;

            /*0x3f598a0*/ CallbackDescriptor(System.Type[] paramTypes, System.Action<System.Object[]> callback);
        }

        struct FunctionCallbackDescriptor
        {
            /*0x10*/ System.Type ReturnType;
            /*0x18*/ System.Type[] ParamTypes;
            /*0x20*/ System.Func<System.Object[], object> Callback;

            /*0x3f598d0*/ FunctionCallbackDescriptor(System.Type returnType, System.Type[] paramTypes, System.Func<System.Object[], object> callback);
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

            /*0x3f59b6c*/ Subscription();
            /*0x3f59914*/ void Add(System.Type[] paramTypes, System.Action<System.Object[]> callback);
            /*0x3f59a00*/ void AddFunc(System.Type resultType, System.Type[] paramTypes, System.Func<System.Object[], object> callback);
        }

        class WebsocketOptions
        {
            /*0x10*/ System.Func<Best.WebSockets.Extensions.IExtension[]> <ExtensionsFactory>k__BackingField;
            /*0x18*/ System.Nullable<System.TimeSpan> <PingIntervalOverride>k__BackingField;
            /*0x28*/ System.Nullable<System.TimeSpan> <CloseAfterNoMessageOverride>k__BackingField;

            /*0x3f59c18*/ WebsocketOptions();
            /*0x3f59bf8*/ System.Func<Best.WebSockets.Extensions.IExtension[]> get_ExtensionsFactory();
            /*0x3f59c00*/ System.Nullable<System.TimeSpan> get_PingIntervalOverride();
            /*0x3f59c0c*/ System.Nullable<System.TimeSpan> get_CloseAfterNoMessageOverride();
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

            /*0x3f59d84*/ HubOptions();
            /*0x3f59d10*/ bool get_SkipNegotiation();
            /*0x3f59d18*/ void set_SkipNegotiation(bool value);
            /*0x3f59d24*/ Best.SignalR.TransportTypes get_PreferedTransport();
            /*0x3f59d2c*/ void set_PreferedTransport(Best.SignalR.TransportTypes value);
            /*0x3f59d34*/ System.TimeSpan get_PingInterval();
            /*0x3f59d3c*/ void set_PingInterval(System.TimeSpan value);
            /*0x3f59d44*/ System.TimeSpan get_PingTimeoutInterval();
            /*0x3f59d4c*/ void set_PingTimeoutInterval(System.TimeSpan value);
            /*0x3f59d54*/ int get_MaxRedirects();
            /*0x3f59d5c*/ void set_MaxRedirects(int value);
            /*0x3f59d64*/ System.TimeSpan get_ConnectTimeout();
            /*0x3f59d6c*/ void set_ConnectTimeout(System.TimeSpan value);
            /*0x3f59d74*/ bool get_UseStatefulReconnect();
            /*0x3f59d7c*/ Best.SignalR.WebsocketOptions get_WebsocketOptions();
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

            static /*0x3f59f14*/ DefaultRetryPolicy();
            /*0x3f59e60*/ DefaultRetryPolicy();
            /*0x3f59ed0*/ System.Nullable<System.TimeSpan> GetNextRetryDelay(Best.SignalR.RetryContext context);
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

            static /*0x3f66640*/ HubConnection();
            /*0x3f5a85c*/ HubConnection(System.Uri hubUri, Best.SignalR.IProtocol protocol, Best.SignalR.HubOptions options);
            /*0x3f5a0a8*/ System.Uri get_Uri();
            /*0x3f5a0b0*/ void set_Uri(System.Uri value);
            /*0x3f5a0b8*/ Best.SignalR.ConnectionStates get_State();
            /*0x3f5a0d0*/ void set_State(Best.SignalR.ConnectionStates value);
            /*0x3f5a0fc*/ Best.SignalR.ITransport get_Transport();
            /*0x3f5a104*/ void set_Transport(Best.SignalR.ITransport value);
            /*0x3f5a10c*/ Best.SignalR.IProtocol get_Protocol();
            /*0x3f5a114*/ void set_Protocol(Best.SignalR.IProtocol value);
            /*0x3f5a11c*/ void add_OnConnected(System.Action<Best.SignalR.HubConnection> value);
            /*0x3f5a1cc*/ void remove_OnConnected(System.Action<Best.SignalR.HubConnection> value);
            /*0x3f5a27c*/ void add_OnError(System.Action<Best.SignalR.HubConnection, string> value);
            /*0x3f5a32c*/ void remove_OnError(System.Action<Best.SignalR.HubConnection, string> value);
            /*0x3f5a3dc*/ void add_OnClosed(System.Action<Best.SignalR.HubConnection> value);
            /*0x3f5a48c*/ void remove_OnClosed(System.Action<Best.SignalR.HubConnection> value);
            /*0x3f5a53c*/ void add_OnReconnecting(System.Action<Best.SignalR.HubConnection, string> value);
            /*0x3f5a5ec*/ void remove_OnReconnecting(System.Action<Best.SignalR.HubConnection, string> value);
            /*0x3f5a69c*/ void add_OnReconnected(System.Action<Best.SignalR.HubConnection> value);
            /*0x3f5a74c*/ void remove_OnReconnected(System.Action<Best.SignalR.HubConnection> value);
            /*0x3f5a7fc*/ Best.SignalR.IAuthenticationProvider get_AuthenticationProvider();
            /*0x3f5a804*/ void set_AuthenticationProvider(Best.SignalR.IAuthenticationProvider value);
            /*0x3f5a80c*/ Best.SignalR.Messages.NegotiationResult get_NegotiationResult();
            /*0x3f5a814*/ void set_NegotiationResult(Best.SignalR.Messages.NegotiationResult value);
            /*0x3f5a81c*/ Best.SignalR.HubOptions get_Options();
            /*0x3f5a824*/ void set_Options(Best.SignalR.HubOptions value);
            /*0x3f5a82c*/ int get_RedirectCount();
            /*0x3f5a834*/ void set_RedirectCount(int value);
            /*0x3f5a83c*/ Best.SignalR.IRetryPolicy get_ReconnectPolicy();
            /*0x3f5a844*/ void set_ReconnectPolicy(Best.SignalR.IRetryPolicy value);
            /*0x3f5a84c*/ Best.HTTP.Shared.Logger.LoggingContext get_Context();
            /*0x3f5a854*/ void set_Context(Best.HTTP.Shared.Logger.LoggingContext value);
            /*0x3f5ac54*/ void StartConnect();
            /*0x3f5dd94*/ Cysharp.Threading.Tasks.UniTask<Best.SignalR.HubConnection> ConnectAsync();
            /*0x3f5e014*/ void StartClose();
            /*0x3f5e410*/ Cysharp.Threading.Tasks.UniTask<Best.SignalR.HubConnection> CloseAsync();
            /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<TResult> InvokeAsync<TResult>(string target, object[] args);
            /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<TResult> InvokeAsync<TResult>(string target, System.Threading.CancellationToken cancellationToken, object[] args);
            /*0x380d93c*/ void On<T1>(string methodName, System.Action<T1> callback);
            /*0x380d93c*/ void On<Result>(string methodName, System.Func<Result> callback);
            /*0x3f5e5e4*/ void OnAsyncConnectedCallback(Best.SignalR.HubConnection hub);
            /*0x3f5e6fc*/ void OnAsyncConnectFailedCallback(Best.SignalR.HubConnection hub, string error);
            /*0x3f5e850*/ void OnAuthenticationSucceded(Best.SignalR.IAuthenticationProvider provider);
            /*0x3f5eadc*/ void OnAuthenticationFailed(Best.SignalR.IAuthenticationProvider provider, string reason);
            /*0x3f5d880*/ void StartNegotiation();
            /*0x3f5ed94*/ void ConnectImpl(Best.SignalR.TransportTypes transport);
            /*0x3f5f384*/ bool IsTransportSupported(string transportName);
            /*0x3f5f51c*/ void OnNegotiationRequestFinished(Best.HTTP.HTTPRequest req, Best.HTTP.HTTPResponse resp);
            /*0x3f610c0*/ void OnClosedAsyncCallback(Best.SignalR.HubConnection hub);
            /*0x3f611d8*/ void OnClosedAsyncErrorCallback(Best.SignalR.HubConnection hub, string error);
            /*0x3f6132c*/ long InvokeImp(string target, object[] args, System.Action<Best.SignalR.Messages.Message> callback, System.Type itemType, bool isStreamingInvocation);
            /*0x3f61618*/ void SendMessage(Best.SignalR.Messages.Message message);
            /*0x3f62308*/ void On(string methodName, System.Type[] paramTypes, System.Action<System.Object[]> callback);
            /*0x380da4c*/ void OnFunc<Result>(string methodName, System.Type[] paramTypes, System.Func<System.Object[], object> callback);
            /*0x3f62434*/ Best.SignalR.Subscription GetSubscription(string methodName);
            /*0x3f624ac*/ System.Type GetItemType(long invocationId);
            /*0x3f62524*/ void OnMessages(System.Collections.Generic.List<Best.SignalR.Messages.Message> messages);
            /*0x3f641d8*/ void Transport_OnStateChanged(Best.SignalR.TransportStates oldState, Best.SignalR.TransportStates newState);
            /*0x3f64e24*/ System.Nullable<Best.SignalR.TransportTypes> GetNextTransportToTry();
            /*0x3f5b290*/ void SetState(Best.SignalR.ConnectionStates state, string errorReason, bool allowReconnect);
            /*0x3f65210*/ void OnApplicationForegroundStateChanged(bool isPaused);
            /*0x3f65390*/ void Best.HTTP.Shared.Extensions.IHeartbeat.OnHeartbeatUpdate(System.DateTime now, System.TimeSpan dif);
            /*0x3f663a8*/ void CleanUp();

            class <>c
            {
                static /*0x0*/ Best.SignalR.HubConnection.<> <>9;
                static /*0x8*/ System.Func<string, Best.SignalR.Subscription> <>9__123_0;
                static /*0x10*/ System.Predicate<Best.SignalR.Messages.Message> <>9__129_0;
                static /*0x18*/ System.Predicate<Best.SignalR.Messages.Message> <>9__133_0;

                static /*0x3f666b4*/ <>c();
                /*0x3f6671c*/ <>c();
                /*0x3f66724*/ Best.SignalR.Subscription <On>b__123_0(string _);
                /*0x3f66774*/ bool <Transport_OnStateChanged>b__129_0(Best.SignalR.Messages.Message dm);
                /*0x3f66784*/ bool <Best.HTTP.Shared.Extensions.IHeartbeat.OnHeartbeatUpdate>b__133_0(Best.SignalR.Messages.Message dm);
            }

            class <>c__124<Result>
            {
                static /*0x0*/ Best.SignalR.HubConnection.<>c__124<Result> <>9;
                static /*0x0*/ System.Func<string, Best.SignalR.Subscription> <>9__124_0;

                static /*0x38358cc*/ <>c__124();
                /*0x380cb08*/ <>c__124();
                /*0x380bb68*/ Best.SignalR.Subscription <OnFunc>b__124_0(string _);
            }

            class <>c__DisplayClass102_0<T1>
            {
                /*0x0*/ System.Action<T1> callback;

                /*0x380cb08*/ <>c__DisplayClass102_0();
                /*0x380d83c*/ void <On>b__0(object[] args);
            }

            class <>c__DisplayClass106_0<Result>
            {
                /*0x0*/ System.Func<Result> callback;

                /*0x380cb08*/ <>c__DisplayClass106_0();
                /*0x380bb68*/ object <On>b__0(object[] args);
            }

            class <>c__DisplayClass128_0
            {
                /*0x10*/ Best.SignalR.Messages.Message message;
                /*0x68*/ Best.SignalR.HubConnection <>4__this;

                /*0x3f641c8*/ <>c__DisplayClass128_0();
            }

            class <>c__DisplayClass128_1
            {
                /*0x10*/ System.Type taskType;
                /*0x18*/ Best.SignalR.HubConnection.<> CS$<>8__locals1;

                /*0x3f641d0*/ <>c__DisplayClass128_1();
                /*0x3f66794*/ void <OnMessages>b__0(System.Threading.Tasks.Task t);
            }

            class <>c__DisplayClass95_0<TResult>
            {
                /*0x0*/ System.Threading.CancellationToken cancellationToken;
                /*0x0*/ Cysharp.Threading.Tasks.UniTaskCompletionSource<TResult> tcs;
                /*0x0*/ Best.SignalR.HubConnection <>4__this;

                /*0x380cb08*/ <>c__DisplayClass95_0();
                void <InvokeAsync>b__0(Best.SignalR.Messages.Message message);
                /*0x380cb08*/ void <InvokeAsync>b__1();
            }
        }

        class OnAuthenticationSuccededDelegate : System.MulticastDelegate
        {
            /*0x3f5d66c*/ OnAuthenticationSuccededDelegate(object object, nint method);
            /*0x3f66a68*/ void Invoke(Best.SignalR.IAuthenticationProvider provider);
        }

        class OnAuthenticationFailedDelegate : System.MulticastDelegate
        {
            /*0x3f5d774*/ OnAuthenticationFailedDelegate(object object, nint method);
            /*0x3f66a7c*/ void Invoke(Best.SignalR.IAuthenticationProvider provider, string reason);
        }

        interface IAuthenticationProvider
        {
            /*0x380b128*/ bool get_IsPreAuthRequired();
            /*0x380d83c*/ void add_OnAuthenticationSucceded(Best.SignalR.OnAuthenticationSuccededDelegate value);
            /*0x380d83c*/ void remove_OnAuthenticationSucceded(Best.SignalR.OnAuthenticationSuccededDelegate value);
            /*0x380d83c*/ void add_OnAuthenticationFailed(Best.SignalR.OnAuthenticationFailedDelegate value);
            /*0x380d83c*/ void remove_OnAuthenticationFailed(Best.SignalR.OnAuthenticationFailedDelegate value);
            /*0x380cb08*/ void StartAuthentication();
            /*0x380d83c*/ void PrepareRequest(Best.HTTP.HTTPRequest request);
            /*0x380bb68*/ System.Uri PrepareUri(System.Uri uri);
            /*0x380cb08*/ void Cancel();
        }

        interface IProtocol
        {
            /*0x380b9e8*/ string get_Name();
            /*0x380d83c*/ void set_Connection(Best.SignalR.HubConnection value);
            void ParseMessages(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment segment, ref System.Collections.Generic.List<Best.SignalR.Messages.Message> messages);
            Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment EncodeMessage(Best.SignalR.Messages.Message message);
            /*0x380bcbc*/ object[] GetRealArguments(System.Type[] argTypes, object[] arguments);
            /*0x380bcbc*/ object ConvertTo(System.Type toType, object obj);
        }

        class JsonProtocol
        {
            static /*0x3f66a90*/ Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment WithSeparator(string str);
        }

        namespace Transports
        {
            class LongPollingTransport : Best.SignalR.Transports.TransportBase
            {
                /*0x40*/ System.Collections.Concurrent.ConcurrentQueue<Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment> outgoingMessages;
                /*0x48*/ int sendingInProgress;
                /*0x50*/ Best.HTTP.Shared.Streams.BufferSegmentStream stream;

                /*0x3f5f450*/ LongPollingTransport(Best.SignalR.HubConnection con);
                /*0x3f66ba8*/ Best.SignalR.TransportTypes get_TransportType();
                /*0x3f66d0c*/ void StartConnect();
                /*0x3f6731c*/ void Send(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment msg);
                /*0x3f67638*/ void StartClose();
                /*0x3f673a8*/ void SendMessages();
                /*0x3f67a58*/ void DoPoll();
                /*0x3f677a8*/ void SendConnectionCloseRequest(int retryCount);
                /*0x3f67d64*/ void OnHandshakeRequestFinished(Best.HTTP.HTTPRequest req, Best.HTTP.HTTPResponse resp);
                /*0x3f67fb4*/ void OnSendMessagesFinished(Best.HTTP.HTTPRequest req, Best.HTTP.HTTPResponse resp);
                /*0x3f68310*/ void OnPollRequestFinished(Best.HTTP.HTTPRequest req, Best.HTTP.HTTPResponse resp);
                /*0x3f68b14*/ void OnConnectionCloseRequestFinished(Best.HTTP.HTTPRequest req, Best.HTTP.HTTPResponse resp);
            }

            class TransportBase : Best.SignalR.ITransport
            {
                /*0x10*/ Best.SignalR.TransportStates _state;
                /*0x18*/ string <ErrorReason>k__BackingField;
                /*0x20*/ System.Action<Best.SignalR.TransportStates, Best.SignalR.TransportStates> OnStateChanged;
                /*0x28*/ Best.HTTP.Shared.Logger.LoggingContext <Context>k__BackingField;
                /*0x30*/ System.Collections.Generic.List<Best.SignalR.Messages.Message> messages;
                /*0x38*/ Best.SignalR.HubConnection connection;

                /*0x3f66bb0*/ TransportBase(Best.SignalR.HubConnection con);
                /*0x380b6a0*/ Best.SignalR.TransportTypes get_TransportType();
                /*0x3f69074*/ Best.SignalR.TransportStates get_State();
                /*0x3f670c0*/ void set_State(Best.SignalR.TransportStates value);
                /*0x3f6907c*/ string get_ErrorReason();
                /*0x3f69084*/ void set_ErrorReason(string value);
                /*0x3f6908c*/ void add_OnStateChanged(System.Action<Best.SignalR.TransportStates, Best.SignalR.TransportStates> value);
                /*0x3f6913c*/ void remove_OnStateChanged(System.Action<Best.SignalR.TransportStates, Best.SignalR.TransportStates> value);
                /*0x3f691ec*/ Best.HTTP.Shared.Logger.LoggingContext get_Context();
                /*0x3f691f4*/ void set_Context(Best.HTTP.Shared.Logger.LoggingContext value);
                /*0x380cb08*/ void StartConnect();
                /*0x380cdac*/ void Send(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment msg);
                /*0x380cb08*/ void StartClose();
                /*0x3f691fc*/ string ParseHandshakeResponse(string data);
                /*0x3f68a98*/ void HandleHandshakeResponse(string data);
                /*0x3f670f4*/ System.Uri BuildUri(System.Uri baseUri);
            }

            class WebSocketTransport : Best.SignalR.Transports.TransportBase
            {
                /*0x40*/ Best.WebSockets.WebSocket webSocket;

                /*0x3f5f44c*/ WebSocketTransport(Best.SignalR.HubConnection con);
                /*0x3f69300*/ Best.SignalR.TransportTypes get_TransportType();
                /*0x3f69308*/ void StartConnect();
                /*0x3f69cf4*/ void Send(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment msg);
                /*0x3f69f50*/ void OnOpen(Best.WebSockets.WebSocket webSocket);
                /*0x3f6a248*/ void OnMessage(Best.WebSockets.WebSocket webSocket, string data);
                /*0x3f6a928*/ void OnBinaryNoAlloc(Best.WebSockets.WebSocket webSocket, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data);
                /*0x3f6b06c*/ void OnClosed(Best.WebSockets.WebSocket webSocket, Best.WebSockets.WebSocketStatusCodes code, string message);
                /*0x3f6b2a0*/ void StartClose();
                /*0x3f6b458*/ void <StartConnect>b__4_0(Best.WebSockets.WebSocket ws, Best.HTTP.HTTPRequest internalRequest);

                class <>c
                {
                    static /*0x0*/ Best.SignalR.Transports.WebSocketTransport.<> <>9;
                    static /*0x8*/ System.Predicate<byte> <>9__8_0;

                    static /*0x3f6b50c*/ <>c();
                    /*0x3f6b574*/ <>c();
                    /*0x3f6b57c*/ bool <OnBinaryNoAlloc>b__8_0(byte b);
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

                /*0x3f6b58c*/ Best.SignalR.Messages.MessageTypes get_type();
            }

            struct PingMessage
            {
                /*0x3f6b594*/ Best.SignalR.Messages.MessageTypes get_type();
            }

            struct CloseMessage
            {
                /*0x3f6b59c*/ Best.SignalR.Messages.MessageTypes get_type();
            }

            struct CloseWithErrorMessage
            {
                /*0x10*/ string error;

                /*0x3f6b5a4*/ Best.SignalR.Messages.MessageTypes get_type();
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

                /*0x3f622c4*/ bool get_ShouldIncrementSequenceId();
                /*0x3f61e24*/ string ToString();
            }

            class SupportedTransport
            {
                /*0x10*/ string <Name>k__BackingField;
                /*0x18*/ System.Collections.Generic.List<string> <SupportedFormats>k__BackingField;

                /*0x3f6b5c4*/ SupportedTransport(string transportName, System.Collections.Generic.List<string> transferFormats);
                /*0x3f6b5ac*/ string get_Name();
                /*0x3f6b5b4*/ void set_Name(string value);
                /*0x3f6b5bc*/ void set_SupportedFormats(System.Collections.Generic.List<string> value);
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

                static /*0x3f60018*/ Best.SignalR.Messages.NegotiationResult Parse(Best.HTTP.HTTPResponse resp, ref string error, Best.SignalR.HubConnection hub);
                static /*0x3f6b67c*/ bool IsAbsolute(string url);
                /*0x3f610b8*/ NegotiationResult();
                /*0x3f6b608*/ void set_NegotiateVersion(int value);
                /*0x3f6b610*/ string get_ConnectionToken();
                /*0x3f6b618*/ void set_ConnectionToken(string value);
                /*0x3f6b620*/ string get_ConnectionId();
                /*0x3f6b628*/ void set_ConnectionId(string value);
                /*0x3f6b630*/ System.Collections.Generic.List<Best.SignalR.Messages.SupportedTransport> get_SupportedTransports();
                /*0x3f6b638*/ void set_SupportedTransports(System.Collections.Generic.List<Best.SignalR.Messages.SupportedTransport> value);
                /*0x3f6b640*/ System.Uri get_Url();
                /*0x3f6b648*/ void set_Url(System.Uri value);
                /*0x3f6b650*/ string get_AccessToken();
                /*0x3f6b658*/ void set_AccessToken(string value);
                /*0x3f6b660*/ bool get_UseStatefulReconnect();
                /*0x3f6b668*/ void set_UseStatefulReconnect(bool value);
                /*0x3f6b674*/ void set_NegotiationResponse(Best.HTTP.HTTPResponse value);
            }

            struct SentMessage
            {
                /*0x10*/ long SequenceId;
                /*0x18*/ Best.SignalR.Messages.Message Message;

                /*0x3f622d8*/ SentMessage(long sequenceId, Best.SignalR.Messages.Message message);
                /*0x3f6b710*/ string ToString();
            }
        }

        namespace Authentication
        {
            class DefaultAccessTokenAuthenticator : Best.SignalR.IAuthenticationProvider
            {
                /*0x10*/ Best.SignalR.OnAuthenticationSuccededDelegate OnAuthenticationSucceded;
                /*0x18*/ Best.SignalR.OnAuthenticationFailedDelegate OnAuthenticationFailed;
                /*0x20*/ Best.SignalR.HubConnection _connection;

                /*0x3f5ac24*/ DefaultAccessTokenAuthenticator(Best.SignalR.HubConnection connection);
                /*0x3f6b7c8*/ bool get_IsPreAuthRequired();
                /*0x3f6b7d0*/ void add_OnAuthenticationSucceded(Best.SignalR.OnAuthenticationSuccededDelegate value);
                /*0x3f6b86c*/ void remove_OnAuthenticationSucceded(Best.SignalR.OnAuthenticationSuccededDelegate value);
                /*0x3f6b908*/ void add_OnAuthenticationFailed(Best.SignalR.OnAuthenticationFailedDelegate value);
                /*0x3f6b9a4*/ void remove_OnAuthenticationFailed(Best.SignalR.OnAuthenticationFailedDelegate value);
                /*0x3f6ba40*/ void StartAuthentication();
                /*0x3f6ba44*/ void PrepareRequest(Best.HTTP.HTTPRequest request);
                /*0x3f6bcf0*/ System.Uri PrepareUri(System.Uri uri);
                /*0x3f6bb44*/ System.Uri PrepareUriImpl(System.Uri uri);
                /*0x3f6be00*/ void Cancel();
            }
        }
    }
}
