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

            static /*0x3f79390*/ WebSocket();
            static /*0x3f77ad8*/ Best.WebSockets.Extensions.IExtension[] GetDefaultExtensions();
            static /*0x3f78ef8*/ Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment EncodeCloseData(Best.WebSockets.WebSocketStatusCodes code, string message);
            static /*0x3f791e0*/ string GetSecKey(object[] from);
            /*0x3f77cd0*/ WebSocket(System.Uri uri, string origin, string protocol, Best.WebSockets.Extensions.IExtension[] extensions);
            /*0x3f77c08*/ Best.WebSockets.Implementations.WebSocketStates get_State();
            /*0x3f77c28*/ bool get_IsOpen();
            /*0x3f77c7c*/ bool get_SendPings();
            /*0x3f77c84*/ void set_SendPings(bool value);
            /*0x3f77c90*/ System.TimeSpan get_PingFrequency();
            /*0x3f77c98*/ void set_PingFrequency(System.TimeSpan value);
            /*0x3f77ca0*/ System.TimeSpan get_CloseAfterNoMessage();
            /*0x3f77ca8*/ void set_CloseAfterNoMessage(System.TimeSpan value);
            /*0x3f77cb0*/ Best.WebSockets.Extensions.IExtension[] get_Extensions();
            /*0x3f77cb8*/ void set_Extensions(Best.WebSockets.Extensions.IExtension[] value);
            /*0x3f77cc0*/ Best.HTTP.Shared.Logger.LoggingContext get_Context();
            /*0x3f77cc8*/ void set_Context(Best.HTTP.Shared.Logger.LoggingContext value);
            /*0x3f77db8*/ Best.WebSockets.Implementations.WebSocketBaseImplementation SelectImplementation(System.Uri uri, string origin, string protocol);
            /*0x3f7892c*/ void FallbackToHTTP1();
            /*0x3f78acc*/ void Open();
            /*0x3f78aec*/ void SendAsBinary(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data);
            /*0x3f78bc4*/ void Close();
            /*0x3f781d0*/ Best.HTTP.Request.Settings.ProxySettings GetProxy(System.Uri uri);
            /*0x3f78c4c*/ void DisposeExtensions();

            class <>c
            {
                static /*0x0*/ Best.WebSockets.WebSocket.<> <>9;
                static /*0x8*/ System.Predicate<Best.HTTP.Hosts.Connections.ConnectionBase> <>9__43_0;

                static /*0x3f793dc*/ <>c();
                /*0x3f79444*/ <>c();
                /*0x3f7944c*/ bool <SelectImplementation>b__43_0(Best.HTTP.Hosts.Connections.ConnectionBase c);
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

                /*0x3f79704*/ HTTP2WebSocketStream(uint id, Best.HTTP.Hosts.Connections.HTTP2.HTTP2ContentConsumer parentHandler, Best.HTTP.Hosts.Connections.HTTP2.HTTP2SettingsManager registry, Best.HTTP.Hosts.Connections.HTTP2.HPACKEncoder hpackEncoder);
                /*0x3f79504*/ bool get_HasFrameToSend();
                /*0x3f7960c*/ System.TimeSpan get_NextInteraction();
                /*0x3f797bc*/ void Assign(Best.HTTP.HTTPRequest request);
                /*0x3f79868*/ void ProcessIncomingDATAFrame(ref Best.HTTP.Hosts.Connections.HTTP2.HTTP2FrameHeaderAndPayload frame);
                /*0x3f7a284*/ void ProcessOpenState(System.Collections.Generic.List<Best.HTTP.Hosts.Connections.HTTP2.HTTP2FrameHeaderAndPayload> outgoingFrames);
                /*0x3f7b158*/ void <ProcessOpenState>b__9_0(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment header, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data);
            }

            class OverHTTP1 : Best.WebSockets.Implementations.WebSocketBaseImplementation, Best.HTTP.Shared.PlatformSupport.Network.Tcp.IContentConsumer, Best.HTTP.Shared.Extensions.IHeartbeat
            {
                /*0x90*/ Best.HTTP.Shared.Streams.PeekableContentProviderStream <ContentProvider>k__BackingField;
                /*0x98*/ bool requestSent;
                /*0x99*/ bool _closed;
                /*0xa0*/ System.Collections.Concurrent.ConcurrentQueue<Best.WebSockets.Implementations.Frames.WebSocketFrame> unsentFrames;
                /*0xa8*/ System.Threading.AutoResetEvent newFrameSignal;

                /*0x3f785b8*/ OverHTTP1(Best.WebSockets.WebSocket parent, System.Uri uri, string origin, string protocol);
                /*0x3f7b278*/ Best.HTTP.Shared.Streams.PeekableContentProviderStream get_ContentProvider();
                /*0x3f7b280*/ void set_ContentProvider(Best.HTTP.Shared.Streams.PeekableContentProviderStream value);
                /*0x3f7b584*/ void CreateInternalRequest();
                /*0x3f7bcfc*/ void OnCancellationRequested(Best.HTTP.HTTPRequest req);
                /*0x3f7bf00*/ bool InternalRequest_OnBeforeRedirection(Best.HTTP.HTTPRequest originalRequest, Best.HTTP.HTTPResponse response, System.Uri redirectUri);
                /*0x3f7c0c4*/ bool OnInternalRequestUpgraded(Best.HTTP.HTTPRequest req, Best.HTTP.HTTPResponse resp, Best.HTTP.Shared.Streams.PeekableContentProviderStream contentProvider);
                /*0x3f7c690*/ void OnInternalRequestCallback(Best.HTTP.HTTPRequest req, Best.HTTP.HTTPResponse resp);
                /*0x3f7ca90*/ void SendThread();
                /*0x3f7dd5c*/ void SendPing();
                /*0x3f7df54*/ void StartOpen();
                /*0x3f7e36c*/ void StartClose(Best.WebSockets.WebSocketStatusCodes code, string message);
                /*0x3f7e788*/ void Send(Best.WebSockets.Implementations.Frames.WebSocketFrameTypes type, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data);
                /*0x3f7e7fc*/ void SendAsBinary(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data);
                /*0x3f7e80c*/ void Send(Best.WebSockets.Implementations.Frames.WebSocketFrame frame);
                /*0x3f7e8d8*/ void SetBinding(Best.HTTP.Shared.Streams.PeekableContentProviderStream stream);
                /*0x3f7f014*/ void UnsetBinding();
                /*0x3f7e8f4*/ void OnContent();
                /*0x3f7ffdc*/ void OnConnectionClosed();
                /*0x3f800c8*/ void OnError(System.Exception ex);
                /*0x3f80174*/ void OnHeartbeatUpdate(System.DateTime now, System.TimeSpan dif);
                /*0x3f803e4*/ void HandleCompletedFrames();

                class <>c__DisplayClass14_0
                {
                    /*0x10*/ Best.HTTP.Shared.Streams.WriteOnlyBufferedStream bufferedStream;
                    /*0x18*/ System.Action<Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment> <>9__0;

                    /*0x3f7dd54*/ <>c__DisplayClass14_0();
                    /*0x3f81010*/ void <SendThread>b__0(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment header, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment chunk);
                }
            }

            class OverHTTP2 : Best.WebSockets.Implementations.WebSocketBaseImplementation, Best.HTTP.Shared.Extensions.IHeartbeat
            {
                /*0x90*/ Best.HTTP.Hosts.Connections.IThreadSignaler threadSignaler;

                /*0x3f78324*/ OverHTTP2(Best.WebSockets.WebSocket parent, System.Uri uri, string origin, string protocol);
                /*0x3f795bc*/ int get_BufferedFramesCount();
                /*0x3f8112c*/ void SetThreadSignaler(Best.HTTP.Hosts.Connections.IThreadSignaler signaler);
                /*0x3f81134*/ void CreateInternalRequest();
                /*0x3f81920*/ Best.WebSockets.Implementations.HTTP2WebSocketStream HTTP2WebSocketStreamFactory(Best.HTTP.HTTPRequest request, uint id, Best.HTTP.Hosts.Connections.HTTP2.HTTP2ContentConsumer parentHandler, Best.HTTP.Hosts.Connections.HTTP2.HTTP2SettingsManager registry, Best.HTTP.Hosts.Connections.HTTP2.HPACKEncoder hpackEncoder);
                /*0x3f819c0*/ void OnHeadersReceived(Best.HTTP.HTTPRequest req, Best.HTTP.HTTPResponse resp, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> newHeaders);
                /*0x3f79bd0*/ void OnReadThread(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment buffer);
                /*0x3f81f5c*/ void OnInternalRequestCallback(Best.HTTP.HTTPRequest req, Best.HTTP.HTTPResponse resp);
                /*0x3f82620*/ void StartOpen();
                /*0x3f829e0*/ void StartClose(Best.WebSockets.WebSocketStatusCodes code, string message);
                /*0x3f82c4c*/ void Send(Best.WebSockets.Implementations.Frames.WebSocketFrame frame);
                /*0x3f82d9c*/ void SendAsBinary(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data);
                /*0x3f82dac*/ void Send(Best.WebSockets.Implementations.Frames.WebSocketFrameTypes type, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data);
                /*0x3f7aa60*/ void PreReadCallback();
                /*0x3f8314c*/ void OnHeartbeatUpdate(System.DateTime now, System.TimeSpan dif);
                /*0x3f79624*/ System.TimeSpan GetNextInteraction();
                /*0x3f81d6c*/ void SendPing();
                /*0x3f82e1c*/ void CloseWithError(string message);
                /*0x3f7ae84*/ bool TryDequeueFrame(ref Best.WebSockets.Implementations.Frames.WebSocketFrame frame);
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
                /*0x3f83f20*/ OnWebSocketOpenDelegate(object object, nint method);
                /*0x3f83fd0*/ void Invoke(Best.WebSockets.WebSocket webSocket);
            }

            class OnWebSocketMessageDelegate : System.MulticastDelegate
            {
                /*0x3f83fe4*/ OnWebSocketMessageDelegate(object object, nint method);
                /*0x3f84098*/ void Invoke(Best.WebSockets.WebSocket webSocket, string message);
            }

            class OnWebSocketBinaryNoAllocDelegate : System.MulticastDelegate
            {
                /*0x3f840ac*/ OnWebSocketBinaryNoAllocDelegate(object object, nint method);
                /*0x3f84160*/ void Invoke(Best.WebSockets.WebSocket webSocket, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data);
            }

            class OnWebSocketClosedDelegate : System.MulticastDelegate
            {
                /*0x3f84174*/ OnWebSocketClosedDelegate(object object, nint method);
                /*0x3f84228*/ void Invoke(Best.WebSockets.WebSocket webSocket, Best.WebSockets.WebSocketStatusCodes code, string message);
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

                static /*0x3f843bc*/ WebSocketBaseImplementation();
                static /*0x3f7fd04*/ bool CanReadFullFrame(Best.HTTP.Shared.Streams.PeekableStream stream);
                /*0x3f7b288*/ WebSocketBaseImplementation(Best.WebSockets.WebSocket parent, System.Uri uri, string origin, string protocol);
                /*0x3f8423c*/ Best.WebSockets.Implementations.WebSocketStates get_State();
                /*0x3f84244*/ void set_State(Best.WebSockets.Implementations.WebSocketStates value);
                /*0x3f77c58*/ bool get_IsOpen();
                /*0x3f7bcd0*/ Best.HTTP.HTTPRequest get_InternalRequest();
                /*0x3f8424c*/ void set_Latency(int value);
                /*0x3f84254*/ System.DateTime get_LastMessageReceived();
                /*0x3f8425c*/ void set_LastMessageReceived(System.DateTime value);
                /*0x3f84264*/ Best.WebSockets.WebSocket get_Parent();
                /*0x3f8426c*/ System.Uri get_Uri();
                /*0x3f84274*/ void set_Uri(System.Uri value);
                /*0x3f8427c*/ string get_Origin();
                /*0x3f84284*/ string get_Protocol();
                /*0x38159dc*/ void StartOpen();
                /*0x38170c0*/ void StartClose(Best.WebSockets.WebSocketStatusCodes code, string message);
                /*0x3815c80*/ void SendAsBinary(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data);
                /*0x3f7c398*/ void ParseExtensionResponse(Best.HTTP.HTTPResponse resp);
                /*0x38159dc*/ void CreateInternalRequest();
                void Send(Best.WebSockets.Implementations.Frames.WebSocketFrame frame);
                /*0x3f8428c*/ void Cleanup();
                /*0x3f7fc4c*/ int CalculateLatency();
            }

            namespace Frames
            {
                struct WebSocketFrame
                {
                    /*0x10*/ Best.WebSockets.Implementations.Frames.WebSocketFrameTypes <Type>k__BackingField;
                    /*0x18*/ Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment <Data>k__BackingField;
                    /*0x28*/ Best.WebSockets.WebSocket <Websocket>k__BackingField;
                    /*0x30*/ byte Header;

                    static /*0x3f848d8*/ void WriteFragment(System.Action<Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment> callback, byte Header, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment Data, bool mask, Best.HTTP.Shared.Logger.LoggingContext context);
                    static /*0x3f84e24*/ void ApplyMask(byte* pData, int DataOffset, int DataCount, byte* pmask);
                    static /*0x3f84eec*/ void ApplyMask$BurstManaged(byte* pData, int DataOffset, int DataCount, byte* pmask);
                    /*0x3f7df4c*/ WebSocketFrame(Best.WebSockets.WebSocket webSocket, Best.WebSockets.Implementations.Frames.WebSocketFrameTypes type, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data);
                    /*0x3f7e62c*/ WebSocketFrame(Best.WebSockets.WebSocket webSocket, Best.WebSockets.Implementations.Frames.WebSocketFrameTypes type, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data, bool copyData);
                    /*0x3f84408*/ Best.WebSockets.Implementations.Frames.WebSocketFrameTypes get_Type();
                    /*0x3f84410*/ void set_Type(Best.WebSockets.Implementations.Frames.WebSocketFrameTypes value);
                    /*0x3f84418*/ Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment get_Data();
                    /*0x3f84424*/ void set_Data(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment value);
                    /*0x3f84434*/ Best.WebSockets.WebSocket get_Websocket();
                    /*0x3f8443c*/ void set_Websocket(Best.WebSockets.WebSocket value);
                    /*0x3f84444*/ string ToString();
                    /*0x3f7af04*/ void WriteTo(System.Action<Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment> callback, uint maxFragmentSize, bool mask, Best.HTTP.Shared.Logger.LoggingContext context);
                    /*0x3f84524*/ void DoExtensions();
                    /*0x3f84798*/ void FragmentAndSend(System.Action<Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment> callback, uint maxFragmentSize, bool mask, Best.HTTP.Shared.Logger.LoggingContext context);

                    class ApplyMask_000000A5$PostfixBurstDelegate : System.MulticastDelegate
                    {
                        /*0x3f85110*/ ApplyMask_000000A5$PostfixBurstDelegate(object , nint );
                        /*0x3f851c4*/ void Invoke(byte* pData, int DataOffset, int DataCount, byte* pmask);
                    }

                    class ApplyMask_000000A5$BurstDirectCall
                    {
                        static /*0x0*/ nint Pointer;

                        static /*0x3f851d8*/ void GetFunctionPointerDiscard(ref nint );
                        static /*0x3f852c8*/ nint GetFunctionPointer();
                        static /*0x3f84e28*/ void Invoke(byte* pData, int DataOffset, int DataCount, byte* pmask);
                    }
                }

                struct WebSocketFrameReader
                {
                    /*0x10*/ byte <Header>k__BackingField;
                    /*0x11*/ bool <IsFinal>k__BackingField;
                    /*0x12*/ Best.WebSockets.Implementations.Frames.WebSocketFrameTypes <Type>k__BackingField;
                    /*0x18*/ Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment <Data>k__BackingField;
                    /*0x28*/ string <DataAsText>k__BackingField;

                    static /*0x3f85344*/ byte ReadByte(System.IO.Stream stream);
                    /*0x3f852e4*/ byte get_Header();
                    /*0x3f852ec*/ void set_Header(byte value);
                    /*0x3f852f4*/ bool get_IsFinal();
                    /*0x3f852fc*/ void set_IsFinal(bool value);
                    /*0x3f85308*/ Best.WebSockets.Implementations.Frames.WebSocketFrameTypes get_Type();
                    /*0x3f85310*/ void set_Type(Best.WebSockets.Implementations.Frames.WebSocketFrameTypes value);
                    /*0x3f85318*/ Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment get_Data();
                    /*0x3f85324*/ void set_Data(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment value);
                    /*0x3f85334*/ string get_DataAsText();
                    /*0x3f8533c*/ void set_DataAsText(string value);
                    /*0x3f7f040*/ void Read(System.IO.Stream stream);
                    /*0x3f7f628*/ void Assemble(System.Collections.Generic.List<Best.WebSockets.Implementations.Frames.WebSocketFrameReader> fragments);
                    /*0x3f7f940*/ void DecodeWithExtensions(Best.WebSockets.WebSocket webSocket);
                    /*0x3f80f6c*/ void ReleaseData();
                    /*0x3f7f424*/ string ToString();
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
                /*0x3816710*/ void AddNegotiation(Best.HTTP.HTTPRequest request);
                /*0x38141c4*/ bool ParseNegotiation(Best.HTTP.HTTPResponse resp);
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

                static /*0x3f86104*/ PerMessageCompression();
                /*0x3f77ba8*/ PerMessageCompression(Best.HTTP.Shared.Compression.Zlib.CompressionLevel level, bool clientNoContextTakeover, bool serverNoContextTakeover, int desiredClientMaxWindowBits, int desiredServerMaxWindowBits, int minDatalengthToCompress);
                /*0x3f85390*/ bool get_ClientNoContextTakeover();
                /*0x3f85398*/ void set_ClientNoContextTakeover(bool value);
                /*0x3f853a4*/ bool get_ServerNoContextTakeover();
                /*0x3f853ac*/ void set_ServerNoContextTakeover(bool value);
                /*0x3f853b8*/ int get_ClientMaxWindowBits();
                /*0x3f853c0*/ void set_ClientMaxWindowBits(int value);
                /*0x3f853c8*/ int get_ServerMaxWindowBits();
                /*0x3f853d0*/ void set_ServerMaxWindowBits(int value);
                /*0x3f853d8*/ Best.HTTP.Shared.Compression.Zlib.CompressionLevel get_Level();
                /*0x3f853e0*/ void set_Level(Best.HTTP.Shared.Compression.Zlib.CompressionLevel value);
                /*0x3f853e8*/ int get_MinimumDataLegthToCompress();
                /*0x3f853f0*/ void set_MinimumDataLegthToCompress(int value);
                /*0x3f853f8*/ void AddNegotiation(Best.HTTP.HTTPRequest request);
                /*0x3f855a4*/ bool ParseNegotiation(Best.HTTP.HTTPResponse resp);
                /*0x3f8599c*/ byte GetFrameHeader(Best.WebSockets.Implementations.Frames.WebSocketFrame writer, byte inFlag);
                /*0x3f859cc*/ Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment Encode(Best.WebSockets.Implementations.Frames.WebSocketFrame writer);
                /*0x3f85cfc*/ Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment Decode(byte header, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data);
                /*0x3f859ec*/ Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment Compress(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data);
                /*0x3f85d18*/ Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment Decompress(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data);
                /*0x3f8603c*/ void CheckDisposed();
                /*0x3f86098*/ void System.IDisposable.Dispose();
            }
        }
    }
}

class $BurstDirectCallInitializer
{
    static /*0x3f861a4*/ void Initialize();
}
