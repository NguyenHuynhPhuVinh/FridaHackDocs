class <Module>
{
}

namespace Best
{
    namespace WebSockets
    {
        class WebSocket
        {
            static /*0x0*/ uint MaxFragmentSize;
            /*0x10*/ bool <SendPings>k__BackingField;
            /*0x18*/ System.TimeSpan <PingFrequency>k__BackingField;
            /*0x20*/ System.TimeSpan <CloseAfterNoMessage>k__BackingField;
            /*0x28*/ Best.WebSockets.Extensions.IExtension[] <Extensions>k__BackingField;
            /*0x30*/ System.Action<Best.WebSockets.WebSocket, Best.HTTP.HTTPRequest> OnInternalRequestCreated;
            /*0x38*/ Best.WebSockets.Implementations.OnWebSocketOpenDelegate OnOpen;
            /*0x40*/ Best.WebSockets.Implementations.OnWebSocketMessageDelegate OnMessage;
            /*0x48*/ Best.WebSockets.Implementations.OnWebSocketBinaryNoAllocDelegate OnBinary;
            /*0x50*/ Best.WebSockets.Implementations.OnWebSocketClosedDelegate OnClosed;
            /*0x58*/ Best.HTTP.Shared.Logger.LoggingContext <Context>k__BackingField;
            /*0x60*/ Best.WebSockets.Implementations.WebSocketBaseImplementation implementation;

            static /*0x3f6d6bc*/ WebSocket();
            static /*0x3f6be04*/ Best.WebSockets.Extensions.IExtension[] GetDefaultExtensions();
            static /*0x3f6d224*/ Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment EncodeCloseData(Best.WebSockets.WebSocketStatusCodes code, string message);
            static /*0x3f6d50c*/ string GetSecKey(object[] from);
            /*0x3f6bffc*/ WebSocket(System.Uri uri, string origin, string protocol, Best.WebSockets.Extensions.IExtension[] extensions);
            /*0x3f6bf34*/ Best.WebSockets.Implementations.WebSocketStates get_State();
            /*0x3f6bf54*/ bool get_IsOpen();
            /*0x3f6bfa8*/ bool get_SendPings();
            /*0x3f6bfb0*/ void set_SendPings(bool value);
            /*0x3f6bfbc*/ System.TimeSpan get_PingFrequency();
            /*0x3f6bfc4*/ void set_PingFrequency(System.TimeSpan value);
            /*0x3f6bfcc*/ System.TimeSpan get_CloseAfterNoMessage();
            /*0x3f6bfd4*/ void set_CloseAfterNoMessage(System.TimeSpan value);
            /*0x3f6bfdc*/ Best.WebSockets.Extensions.IExtension[] get_Extensions();
            /*0x3f6bfe4*/ void set_Extensions(Best.WebSockets.Extensions.IExtension[] value);
            /*0x3f6bfec*/ Best.HTTP.Shared.Logger.LoggingContext get_Context();
            /*0x3f6bff4*/ void set_Context(Best.HTTP.Shared.Logger.LoggingContext value);
            /*0x3f6c0e4*/ Best.WebSockets.Implementations.WebSocketBaseImplementation SelectImplementation(System.Uri uri, string origin, string protocol);
            /*0x3f6cc58*/ void FallbackToHTTP1();
            /*0x3f6cdf8*/ void Open();
            /*0x3f6ce18*/ void SendAsBinary(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data);
            /*0x3f6cef0*/ void Close();
            /*0x3f6c4fc*/ Best.HTTP.Request.Settings.ProxySettings GetProxy(System.Uri uri);
            /*0x3f6cf78*/ void DisposeExtensions();

            class <>c
            {
                static /*0x0*/ Best.WebSockets.WebSocket.<> <>9;
                static /*0x8*/ System.Predicate<Best.HTTP.Hosts.Connections.ConnectionBase> <>9__43_0;

                static /*0x3f6d708*/ <>c();
                /*0x3f6d770*/ <>c();
                /*0x3f6d778*/ bool <SelectImplementation>b__43_0(Best.HTTP.Hosts.Connections.ConnectionBase c);
            }
        }

        enum WebSocketStatusCodes
        {
            NormalClosure = 1000,
            GoingAway = 1001,
            ProtocolError = 1002,
            WrongDataType = 1003,
            Reserved = 1004,
            NoStatusCode = 1005,
            ClosedAbnormally = 1006,
            DataError = 1007,
            PolicyError = 1008,
            TooBigMessage = 1009,
            ExtensionExpected = 1010,
            WrongRequest = 1011,
            TLSHandshakeError = 1015,
        }

        namespace Implementations
        {
            class HTTP2WebSocketStream : Best.HTTP.Hosts.Connections.HTTP2.HTTP2Stream
            {
                /*0xa8*/ Best.WebSockets.Implementations.OverHTTP2 websocketOverHTTP2;
                /*0xb0*/ System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment>> chunkQueue;

                /*0x3f6da30*/ HTTP2WebSocketStream(uint id, Best.HTTP.Hosts.Connections.HTTP2.HTTP2ContentConsumer parentHandler, Best.HTTP.Hosts.Connections.HTTP2.HTTP2SettingsManager registry, Best.HTTP.Hosts.Connections.HTTP2.HPACKEncoder hpackEncoder);
                /*0x3f6d830*/ bool get_HasFrameToSend();
                /*0x3f6d938*/ System.TimeSpan get_NextInteraction();
                /*0x3f6dae8*/ void Assign(Best.HTTP.HTTPRequest request);
                /*0x3f6db94*/ void ProcessIncomingDATAFrame(ref Best.HTTP.Hosts.Connections.HTTP2.HTTP2FrameHeaderAndPayload frame);
                /*0x3f6e5b0*/ void ProcessOpenState(System.Collections.Generic.List<Best.HTTP.Hosts.Connections.HTTP2.HTTP2FrameHeaderAndPayload> outgoingFrames);
                /*0x3f6f484*/ void <ProcessOpenState>b__9_0(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment header, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data);
            }

            class OverHTTP1 : Best.WebSockets.Implementations.WebSocketBaseImplementation, Best.HTTP.Shared.PlatformSupport.Network.Tcp.IContentConsumer, Best.HTTP.Shared.Extensions.IHeartbeat
            {
                /*0x90*/ Best.HTTP.Shared.Streams.PeekableContentProviderStream <ContentProvider>k__BackingField;
                /*0x98*/ bool requestSent;
                /*0x99*/ bool _closed;
                /*0xa0*/ System.Collections.Concurrent.ConcurrentQueue<Best.WebSockets.Implementations.Frames.WebSocketFrame> unsentFrames;
                /*0xa8*/ System.Threading.AutoResetEvent newFrameSignal;

                /*0x3f6c8e4*/ OverHTTP1(Best.WebSockets.WebSocket parent, System.Uri uri, string origin, string protocol);
                /*0x3f6f5a4*/ Best.HTTP.Shared.Streams.PeekableContentProviderStream get_ContentProvider();
                /*0x3f6f5ac*/ void set_ContentProvider(Best.HTTP.Shared.Streams.PeekableContentProviderStream value);
                /*0x3f6f8b0*/ void CreateInternalRequest();
                /*0x3f70028*/ void OnCancellationRequested(Best.HTTP.HTTPRequest req);
                /*0x3f7022c*/ bool InternalRequest_OnBeforeRedirection(Best.HTTP.HTTPRequest originalRequest, Best.HTTP.HTTPResponse response, System.Uri redirectUri);
                /*0x3f703f0*/ bool OnInternalRequestUpgraded(Best.HTTP.HTTPRequest req, Best.HTTP.HTTPResponse resp, Best.HTTP.Shared.Streams.PeekableContentProviderStream contentProvider);
                /*0x3f709bc*/ void OnInternalRequestCallback(Best.HTTP.HTTPRequest req, Best.HTTP.HTTPResponse resp);
                /*0x3f70dbc*/ void SendThread();
                /*0x3f72088*/ void SendPing();
                /*0x3f72280*/ void StartOpen();
                /*0x3f72698*/ void StartClose(Best.WebSockets.WebSocketStatusCodes code, string message);
                /*0x3f72ab4*/ void Send(Best.WebSockets.Implementations.Frames.WebSocketFrameTypes type, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data);
                /*0x3f72b28*/ void SendAsBinary(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data);
                /*0x3f72b38*/ void Send(Best.WebSockets.Implementations.Frames.WebSocketFrame frame);
                /*0x3f72c04*/ void SetBinding(Best.HTTP.Shared.Streams.PeekableContentProviderStream stream);
                /*0x3f73340*/ void UnsetBinding();
                /*0x3f72c20*/ void OnContent();
                /*0x3f74308*/ void OnConnectionClosed();
                /*0x3f743f4*/ void OnError(System.Exception ex);
                /*0x3f744a0*/ void OnHeartbeatUpdate(System.DateTime now, System.TimeSpan dif);
                /*0x3f74710*/ void HandleCompletedFrames();

                class <>c__DisplayClass14_0
                {
                    /*0x10*/ Best.HTTP.Shared.Streams.WriteOnlyBufferedStream bufferedStream;
                    /*0x18*/ System.Action<Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment> <>9__0;

                    /*0x3f72080*/ <>c__DisplayClass14_0();
                    /*0x3f7533c*/ void <SendThread>b__0(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment header, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment chunk);
                }
            }

            class OverHTTP2 : Best.WebSockets.Implementations.WebSocketBaseImplementation, Best.HTTP.Shared.Extensions.IHeartbeat
            {
                /*0x90*/ Best.HTTP.Hosts.Connections.IThreadSignaler threadSignaler;

                /*0x3f6c650*/ OverHTTP2(Best.WebSockets.WebSocket parent, System.Uri uri, string origin, string protocol);
                /*0x3f6d8e8*/ int get_BufferedFramesCount();
                /*0x3f75458*/ void SetThreadSignaler(Best.HTTP.Hosts.Connections.IThreadSignaler signaler);
                /*0x3f75460*/ void CreateInternalRequest();
                /*0x3f75c4c*/ Best.WebSockets.Implementations.HTTP2WebSocketStream HTTP2WebSocketStreamFactory(Best.HTTP.HTTPRequest request, uint id, Best.HTTP.Hosts.Connections.HTTP2.HTTP2ContentConsumer parentHandler, Best.HTTP.Hosts.Connections.HTTP2.HTTP2SettingsManager registry, Best.HTTP.Hosts.Connections.HTTP2.HPACKEncoder hpackEncoder);
                /*0x3f75cec*/ void OnHeadersReceived(Best.HTTP.HTTPRequest req, Best.HTTP.HTTPResponse resp, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> newHeaders);
                /*0x3f6defc*/ void OnReadThread(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment buffer);
                /*0x3f76288*/ void OnInternalRequestCallback(Best.HTTP.HTTPRequest req, Best.HTTP.HTTPResponse resp);
                /*0x3f7694c*/ void StartOpen();
                /*0x3f76d0c*/ void StartClose(Best.WebSockets.WebSocketStatusCodes code, string message);
                /*0x3f76f78*/ void Send(Best.WebSockets.Implementations.Frames.WebSocketFrame frame);
                /*0x3f770c8*/ void SendAsBinary(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data);
                /*0x3f770d8*/ void Send(Best.WebSockets.Implementations.Frames.WebSocketFrameTypes type, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data);
                /*0x3f6ed8c*/ void PreReadCallback();
                /*0x3f77478*/ void OnHeartbeatUpdate(System.DateTime now, System.TimeSpan dif);
                /*0x3f6d950*/ System.TimeSpan GetNextInteraction();
                /*0x3f76098*/ void SendPing();
                /*0x3f77148*/ void CloseWithError(string message);
                /*0x3f6f1b0*/ bool TryDequeueFrame(ref Best.WebSockets.Implementations.Frames.WebSocketFrame frame);
            }

            enum WebSocketStates
            {
                Connecting = 0,
                Open = 1,
                Closing = 2,
                Closed = 3,
                Unknown = 4,
            }

            class OnWebSocketOpenDelegate : System.MulticastDelegate
            {
                /*0x3f7824c*/ OnWebSocketOpenDelegate(object object, nint method);
                /*0x3f782fc*/ void Invoke(Best.WebSockets.WebSocket webSocket);
            }

            class OnWebSocketMessageDelegate : System.MulticastDelegate
            {
                /*0x3f78310*/ OnWebSocketMessageDelegate(object object, nint method);
                /*0x3f783c4*/ void Invoke(Best.WebSockets.WebSocket webSocket, string message);
            }

            class OnWebSocketBinaryNoAllocDelegate : System.MulticastDelegate
            {
                /*0x3f783d8*/ OnWebSocketBinaryNoAllocDelegate(object object, nint method);
                /*0x3f7848c*/ void Invoke(Best.WebSockets.WebSocket webSocket, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data);
            }

            class OnWebSocketClosedDelegate : System.MulticastDelegate
            {
                /*0x3f784a0*/ OnWebSocketClosedDelegate(object object, nint method);
                /*0x3f78554*/ void Invoke(Best.WebSockets.WebSocket webSocket, Best.WebSockets.WebSocketStatusCodes code, string message);
            }

            class WebSocketBaseImplementation
            {
                static /*0x0*/ int RTTBufferCapacity;
                /*0x10*/ Best.WebSockets.Implementations.WebSocketStates <State>k__BackingField;
                /*0x14*/ int _bufferedAmount;
                /*0x18*/ Best.HTTP.HTTPRequest _internalRequest;
                /*0x20*/ int <Latency>k__BackingField;
                /*0x28*/ System.DateTime <LastMessageReceived>k__BackingField;
                /*0x30*/ Best.HTTP.Shared.Extensions.CircularBuffer<int> rtts;
                /*0x38*/ System.DateTime lastPing;
                /*0x40*/ bool waitingForPong;
                /*0x48*/ System.Collections.Generic.List<Best.WebSockets.Implementations.Frames.WebSocketFrameReader> IncompleteFrames;
                /*0x50*/ Best.HTTP.Shared.Streams.PeekableIncomingSegmentStream incomingSegmentStream;
                /*0x58*/ System.Collections.Concurrent.ConcurrentQueue<Best.WebSockets.Implementations.Frames.WebSocketFrameReader> CompletedFrames;
                /*0x60*/ System.Collections.Concurrent.ConcurrentQueue<Best.WebSockets.Implementations.Frames.WebSocketFrame> frames;
                /*0x68*/ bool _closeSent;
                /*0x69*/ bool _closeReceived;
                /*0x70*/ Best.WebSockets.WebSocket <Parent>k__BackingField;
                /*0x78*/ System.Uri <Uri>k__BackingField;
                /*0x80*/ string <Origin>k__BackingField;
                /*0x88*/ string <Protocol>k__BackingField;

                static /*0x3f786e8*/ WebSocketBaseImplementation();
                static /*0x3f74030*/ bool CanReadFullFrame(Best.HTTP.Shared.Streams.PeekableStream stream);
                /*0x3f6f5b4*/ WebSocketBaseImplementation(Best.WebSockets.WebSocket parent, System.Uri uri, string origin, string protocol);
                /*0x3f78568*/ Best.WebSockets.Implementations.WebSocketStates get_State();
                /*0x3f78570*/ void set_State(Best.WebSockets.Implementations.WebSocketStates value);
                /*0x3f6bf84*/ bool get_IsOpen();
                /*0x3f6fffc*/ Best.HTTP.HTTPRequest get_InternalRequest();
                /*0x3f78578*/ void set_Latency(int value);
                /*0x3f78580*/ System.DateTime get_LastMessageReceived();
                /*0x3f78588*/ void set_LastMessageReceived(System.DateTime value);
                /*0x3f78590*/ Best.WebSockets.WebSocket get_Parent();
                /*0x3f78598*/ System.Uri get_Uri();
                /*0x3f785a0*/ void set_Uri(System.Uri value);
                /*0x3f785a8*/ string get_Origin();
                /*0x3f785b0*/ string get_Protocol();
                /*0x380cb08*/ void StartOpen();
                /*0x380e1ec*/ void StartClose(Best.WebSockets.WebSocketStatusCodes code, string message);
                /*0x380cdac*/ void SendAsBinary(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data);
                /*0x3f706c4*/ void ParseExtensionResponse(Best.HTTP.HTTPResponse resp);
                /*0x380cb08*/ void CreateInternalRequest();
                void Send(Best.WebSockets.Implementations.Frames.WebSocketFrame frame);
                /*0x3f785b8*/ void Cleanup();
                /*0x3f73f78*/ int CalculateLatency();
            }

            namespace Frames
            {
                struct WebSocketFrame
                {
                    /*0x10*/ Best.WebSockets.Implementations.Frames.WebSocketFrameTypes <Type>k__BackingField;
                    /*0x18*/ Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment <Data>k__BackingField;
                    /*0x28*/ Best.WebSockets.WebSocket <Websocket>k__BackingField;
                    /*0x30*/ byte Header;

                    static /*0x3f78c04*/ void WriteFragment(System.Action<Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment> callback, byte Header, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment Data, bool mask, Best.HTTP.Shared.Logger.LoggingContext context);
                    static /*0x3f79150*/ void ApplyMask(byte* pData, int DataOffset, int DataCount, byte* pmask);
                    static /*0x3f79218*/ void ApplyMask$BurstManaged(byte* pData, int DataOffset, int DataCount, byte* pmask);
                    /*0x3f72278*/ WebSocketFrame(Best.WebSockets.WebSocket webSocket, Best.WebSockets.Implementations.Frames.WebSocketFrameTypes type, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data);
                    /*0x3f72958*/ WebSocketFrame(Best.WebSockets.WebSocket webSocket, Best.WebSockets.Implementations.Frames.WebSocketFrameTypes type, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data, bool copyData);
                    /*0x3f78734*/ Best.WebSockets.Implementations.Frames.WebSocketFrameTypes get_Type();
                    /*0x3f7873c*/ void set_Type(Best.WebSockets.Implementations.Frames.WebSocketFrameTypes value);
                    /*0x3f78744*/ Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment get_Data();
                    /*0x3f78750*/ void set_Data(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment value);
                    /*0x3f78760*/ Best.WebSockets.WebSocket get_Websocket();
                    /*0x3f78768*/ void set_Websocket(Best.WebSockets.WebSocket value);
                    /*0x3f78770*/ string ToString();
                    /*0x3f6f230*/ void WriteTo(System.Action<Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment> callback, uint maxFragmentSize, bool mask, Best.HTTP.Shared.Logger.LoggingContext context);
                    /*0x3f78850*/ void DoExtensions();
                    /*0x3f78ac4*/ void FragmentAndSend(System.Action<Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment> callback, uint maxFragmentSize, bool mask, Best.HTTP.Shared.Logger.LoggingContext context);

                    class ApplyMask_000000A5$PostfixBurstDelegate : System.MulticastDelegate
                    {
                        /*0x3f7943c*/ ApplyMask_000000A5$PostfixBurstDelegate(object , nint );
                        /*0x3f794f0*/ void Invoke(byte* pData, int DataOffset, int DataCount, byte* pmask);
                    }

                    class ApplyMask_000000A5$BurstDirectCall
                    {
                        static /*0x0*/ nint Pointer;

                        static /*0x3f79504*/ void GetFunctionPointerDiscard(ref nint );
                        static /*0x3f795f4*/ nint GetFunctionPointer();
                        static /*0x3f79154*/ void Invoke(byte* pData, int DataOffset, int DataCount, byte* pmask);
                    }
                }

                struct WebSocketFrameReader
                {
                    /*0x10*/ byte <Header>k__BackingField;
                    /*0x11*/ bool <IsFinal>k__BackingField;
                    /*0x12*/ Best.WebSockets.Implementations.Frames.WebSocketFrameTypes <Type>k__BackingField;
                    /*0x18*/ Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment <Data>k__BackingField;
                    /*0x28*/ string <DataAsText>k__BackingField;

                    static /*0x3f79670*/ byte ReadByte(System.IO.Stream stream);
                    /*0x3f79610*/ byte get_Header();
                    /*0x3f79618*/ void set_Header(byte value);
                    /*0x3f79620*/ bool get_IsFinal();
                    /*0x3f79628*/ void set_IsFinal(bool value);
                    /*0x3f79634*/ Best.WebSockets.Implementations.Frames.WebSocketFrameTypes get_Type();
                    /*0x3f7963c*/ void set_Type(Best.WebSockets.Implementations.Frames.WebSocketFrameTypes value);
                    /*0x3f79644*/ Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment get_Data();
                    /*0x3f79650*/ void set_Data(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment value);
                    /*0x3f79660*/ string get_DataAsText();
                    /*0x3f79668*/ void set_DataAsText(string value);
                    /*0x3f7336c*/ void Read(System.IO.Stream stream);
                    /*0x3f73954*/ void Assemble(System.Collections.Generic.List<Best.WebSockets.Implementations.Frames.WebSocketFrameReader> fragments);
                    /*0x3f73c6c*/ void DecodeWithExtensions(Best.WebSockets.WebSocket webSocket);
                    /*0x3f75298*/ void ReleaseData();
                    /*0x3f73750*/ string ToString();
                }

                enum WebSocketFrameTypes
                {
                    Continuation = 0,
                    Text = 1,
                    Binary = 2,
                    ConnectionClose = 8,
                    Ping = 9,
                    Pong = 10,
                }
            }
        }

        namespace Extensions
        {
            interface IExtension : System.IDisposable
            {
                /*0x380d83c*/ void AddNegotiation(Best.HTTP.HTTPRequest request);
                /*0x380b2f0*/ bool ParseNegotiation(Best.HTTP.HTTPResponse resp);
                byte GetFrameHeader(Best.WebSockets.Implementations.Frames.WebSocketFrame writer, byte inFlag);
                Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment Encode(Best.WebSockets.Implementations.Frames.WebSocketFrame writer);
                Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment Decode(byte header, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data);
            }

            class PerMessageCompression : Best.WebSockets.Extensions.IExtension, System.IDisposable
            {
                static /*0x0*/ byte[] Trailer;
                /*0x10*/ bool <ClientNoContextTakeover>k__BackingField;
                /*0x11*/ bool <ServerNoContextTakeover>k__BackingField;
                /*0x14*/ int <ClientMaxWindowBits>k__BackingField;
                /*0x18*/ int <ServerMaxWindowBits>k__BackingField;
                /*0x1c*/ Best.HTTP.Shared.Compression.Zlib.CompressionLevel <Level>k__BackingField;
                /*0x20*/ int <MinimumDataLegthToCompress>k__BackingField;
                /*0x28*/ Best.HTTP.Shared.Streams.BufferPoolMemoryStream compressorOutputStream;
                /*0x30*/ Best.HTTP.Shared.Compression.Zlib.DeflateStream compressorDeflateStream;
                /*0x38*/ Best.HTTP.Shared.Streams.BufferPoolMemoryStream decompressorInputStream;
                /*0x40*/ Best.HTTP.Shared.Streams.BufferPoolMemoryStream decompressorOutputStream;
                /*0x48*/ Best.HTTP.Shared.Compression.Zlib.DeflateStream decompressorDeflateStream;
                /*0x50*/ bool _disposed;

                static /*0x3f7a430*/ PerMessageCompression();
                /*0x3f6bed4*/ PerMessageCompression(Best.HTTP.Shared.Compression.Zlib.CompressionLevel level, bool clientNoContextTakeover, bool serverNoContextTakeover, int desiredClientMaxWindowBits, int desiredServerMaxWindowBits, int minDatalengthToCompress);
                /*0x3f796bc*/ bool get_ClientNoContextTakeover();
                /*0x3f796c4*/ void set_ClientNoContextTakeover(bool value);
                /*0x3f796d0*/ bool get_ServerNoContextTakeover();
                /*0x3f796d8*/ void set_ServerNoContextTakeover(bool value);
                /*0x3f796e4*/ int get_ClientMaxWindowBits();
                /*0x3f796ec*/ void set_ClientMaxWindowBits(int value);
                /*0x3f796f4*/ int get_ServerMaxWindowBits();
                /*0x3f796fc*/ void set_ServerMaxWindowBits(int value);
                /*0x3f79704*/ Best.HTTP.Shared.Compression.Zlib.CompressionLevel get_Level();
                /*0x3f7970c*/ void set_Level(Best.HTTP.Shared.Compression.Zlib.CompressionLevel value);
                /*0x3f79714*/ int get_MinimumDataLegthToCompress();
                /*0x3f7971c*/ void set_MinimumDataLegthToCompress(int value);
                /*0x3f79724*/ void AddNegotiation(Best.HTTP.HTTPRequest request);
                /*0x3f798d0*/ bool ParseNegotiation(Best.HTTP.HTTPResponse resp);
                /*0x3f79cc8*/ byte GetFrameHeader(Best.WebSockets.Implementations.Frames.WebSocketFrame writer, byte inFlag);
                /*0x3f79cf8*/ Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment Encode(Best.WebSockets.Implementations.Frames.WebSocketFrame writer);
                /*0x3f7a028*/ Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment Decode(byte header, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data);
                /*0x3f79d18*/ Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment Compress(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data);
                /*0x3f7a044*/ Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment Decompress(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data);
                /*0x3f7a368*/ void CheckDisposed();
                /*0x3f7a3c4*/ void System.IDisposable.Dispose();
            }
        }
    }
}

class $BurstDirectCallInitializer
{
    static /*0x3f7a4d0*/ void Initialize();
}
