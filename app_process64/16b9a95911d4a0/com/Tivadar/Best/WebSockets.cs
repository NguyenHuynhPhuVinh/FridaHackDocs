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

            static /*0x2b618ec*/ WebSocket();
            static /*0x2b60018*/ Best.WebSockets.Extensions.IExtension[] GetDefaultExtensions();
            static /*0x2b6148c*/ Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment EncodeCloseData(Best.WebSockets.WebSocketStatusCodes code, string message);
            static /*0x2b61744*/ string GetSecKey(object[] from);
            /*0x2b60208*/ WebSocket(System.Uri uri);
            /*0x2b60298*/ WebSocket(System.Uri uri, string origin, string protocol);
            /*0x2b6032c*/ WebSocket(System.Uri uri, string origin, string protocol, Best.WebSockets.Extensions.IExtension[] extensions);
            /*0x2b60148*/ Best.WebSockets.Implementations.WebSocketStates get_State();
            /*0x2b60164*/ bool get_IsOpen();
            /*0x2b601b8*/ bool get_SendPings();
            /*0x2b601c0*/ void set_SendPings(bool value);
            /*0x2b601c8*/ System.TimeSpan get_PingFrequency();
            /*0x2b601d0*/ void set_PingFrequency(System.TimeSpan value);
            /*0x2b601d8*/ System.TimeSpan get_CloseAfterNoMessage();
            /*0x2b601e0*/ void set_CloseAfterNoMessage(System.TimeSpan value);
            /*0x2b601e8*/ Best.WebSockets.Extensions.IExtension[] get_Extensions();
            /*0x2b601f0*/ void set_Extensions(Best.WebSockets.Extensions.IExtension[] value);
            /*0x2b601f8*/ Best.HTTP.Shared.Logger.LoggingContext get_Context();
            /*0x2b60200*/ void set_Context(Best.HTTP.Shared.Logger.LoggingContext value);
            /*0x2b60414*/ Best.WebSockets.Implementations.WebSocketBaseImplementation SelectImplementation(System.Uri uri, string origin, string protocol);
            /*0x2b60f88*/ void FallbackToHTTP1();
            /*0x2b61128*/ void Open();
            /*0x2b61144*/ void Send(byte[] buffer);
            /*0x2b611a4*/ void Close();
            /*0x2b60824*/ Best.HTTP.Request.Settings.ProxySettings GetProxy(System.Uri uri);
            /*0x2b6122c*/ void DisposeExtensions();

            class <>c
            {
                static /*0x0*/ Best.WebSockets.WebSocket.<> <>9;
                static /*0x8*/ System.Predicate<Best.HTTP.Hosts.Connections.ConnectionBase> <>9__43_0;

                static /*0x2b61938*/ <>c();
                /*0x2b619a0*/ <>c();
                /*0x2b619a8*/ bool <SelectImplementation>b__43_0(Best.HTTP.Hosts.Connections.ConnectionBase c);
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

                /*0x2b61c54*/ HTTP2WebSocketStream(uint id, Best.HTTP.Hosts.Connections.HTTP2.HTTP2ContentConsumer parentHandler, Best.HTTP.Hosts.Connections.HTTP2.HTTP2SettingsManager registry, Best.HTTP.Hosts.Connections.HTTP2.HPACKEncoder hpackEncoder);
                /*0x2b61a58*/ bool get_HasFrameToSend();
                /*0x2b61b60*/ System.TimeSpan get_NextInteraction();
                /*0x2b61d0c*/ void Assign(Best.HTTP.HTTPRequest request);
                /*0x2b61dbc*/ void ProcessIncomingDATAFrame(ref Best.HTTP.Hosts.Connections.HTTP2.HTTP2FrameHeaderAndPayload frame);
                /*0x2b62760*/ void ProcessOpenState(System.Collections.Generic.List<Best.HTTP.Hosts.Connections.HTTP2.HTTP2FrameHeaderAndPayload> outgoingFrames);
                /*0x2b63618*/ void <ProcessOpenState>b__9_0(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment header, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data);
            }

            class OverHTTP1 : Best.WebSockets.Implementations.WebSocketBaseImplementation, Best.HTTP.Shared.PlatformSupport.Network.Tcp.IContentConsumer, Best.HTTP.Shared.Extensions.IHeartbeat
            {
                /*0x90*/ Best.HTTP.Shared.Streams.PeekableContentProviderStream <ContentProvider>k__BackingField;
                /*0x98*/ bool requestSent;
                /*0x99*/ bool _closed;
                /*0xa0*/ System.Collections.Concurrent.ConcurrentQueue<Best.WebSockets.Implementations.Frames.WebSocketFrame> unsentFrames;
                /*0xa8*/ System.Threading.AutoResetEvent newFrameSignal;

                /*0x2b60c0c*/ OverHTTP1(Best.WebSockets.WebSocket parent, System.Uri uri, string origin, string protocol);
                /*0x2b636dc*/ Best.HTTP.Shared.Streams.PeekableContentProviderStream get_ContentProvider();
                /*0x2b636e4*/ void set_ContentProvider(Best.HTTP.Shared.Streams.PeekableContentProviderStream value);
                /*0x2b639e0*/ void CreateInternalRequest();
                /*0x2b640fc*/ void OnCancellationRequested(Best.HTTP.HTTPRequest req);
                /*0x2b64300*/ bool InternalRequest_OnBeforeRedirection(Best.HTTP.HTTPRequest originalRequest, Best.HTTP.HTTPResponse response, System.Uri redirectUri);
                /*0x2b644c4*/ bool OnInternalRequestUpgraded(Best.HTTP.HTTPRequest req, Best.HTTP.HTTPResponse resp, Best.HTTP.Shared.Streams.PeekableContentProviderStream contentProvider);
                /*0x2b64a34*/ void OnInternalRequestCallback(Best.HTTP.HTTPRequest req, Best.HTTP.HTTPResponse resp);
                /*0x2b64e40*/ void SendThread();
                /*0x2b65fc8*/ void SendPing();
                /*0x2b661bc*/ void StartOpen();
                /*0x2b66584*/ void StartClose(Best.WebSockets.WebSocketStatusCodes code, string message);
                /*0x2b66994*/ void Send(byte[] data);
                /*0x2b66a68*/ void Send(Best.WebSockets.Implementations.Frames.WebSocketFrame frame);
                /*0x2b66b20*/ void SetBinding(Best.HTTP.Shared.Streams.PeekableContentProviderStream stream);
                /*0x2b67204*/ void UnsetBinding();
                /*0x2b66b3c*/ void OnContent();
                /*0x2b6813c*/ void OnConnectionClosed();
                /*0x2b68228*/ void OnError(System.Exception ex);
                /*0x2b682d4*/ void OnHeartbeatUpdate(System.DateTime now, System.TimeSpan dif);
                /*0x2b68608*/ void HandleCompletedFrames();

                class <>c__DisplayClass14_0
                {
                    /*0x10*/ Best.HTTP.Shared.Streams.WriteOnlyBufferedStream bufferedStream;
                    /*0x18*/ System.Action<Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment> <>9__0;

                    /*0x2b65fc0*/ <>c__DisplayClass14_0();
                    /*0x2b691d0*/ void <SendThread>b__0(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment header, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment chunk);
                }
            }

            class OverHTTP2 : Best.WebSockets.Implementations.WebSocketBaseImplementation, Best.HTTP.Shared.Extensions.IHeartbeat
            {
                /*0x90*/ Best.HTTP.Hosts.Connections.IThreadSignaler threadSignaler;

                /*0x2b60978*/ OverHTTP2(Best.WebSockets.WebSocket parent, System.Uri uri, string origin, string protocol);
                /*0x2b61b10*/ int get_BufferedFramesCount();
                /*0x2b692ec*/ void SetThreadSignaler(Best.HTTP.Hosts.Connections.IThreadSignaler signaler);
                /*0x2b692f4*/ void CreateInternalRequest();
                /*0x2b69a90*/ Best.WebSockets.Implementations.HTTP2WebSocketStream HTTP2WebSocketStreamFactory(Best.HTTP.HTTPRequest request, uint id, Best.HTTP.Hosts.Connections.HTTP2.HTTP2ContentConsumer parentHandler, Best.HTTP.Hosts.Connections.HTTP2.HTTP2SettingsManager registry, Best.HTTP.Hosts.Connections.HTTP2.HPACKEncoder hpackEncoder);
                /*0x2b69b30*/ void OnHeadersReceived(Best.HTTP.HTTPRequest req, Best.HTTP.HTTPResponse resp, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> newHeaders);
                /*0x2b620e4*/ void OnReadThread(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment buffer);
                /*0x2b6a09c*/ void OnInternalRequestCallback(Best.HTTP.HTTPRequest req, Best.HTTP.HTTPResponse resp);
                /*0x2b6a738*/ void StartOpen();
                /*0x2b6aaa8*/ void StartClose(Best.WebSockets.WebSocketStatusCodes code, string message);
                /*0x2b6ad0c*/ void Send(byte[] buffer);
                /*0x2b6ade0*/ void Send(Best.WebSockets.Implementations.Frames.WebSocketFrame frame);
                /*0x2b62fe4*/ void PreReadCallback();
                /*0x2b6b1f4*/ void OnHeartbeatUpdate(System.DateTime now, System.TimeSpan dif);
                /*0x2b61b74*/ System.TimeSpan GetNextInteraction();
                /*0x2b69eb0*/ void SendPing();
                /*0x2b6af1c*/ void CloseWithError(string message);
                /*0x2b63344*/ bool TryDequeueFrame(ref Best.WebSockets.Implementations.Frames.WebSocketFrame frame);
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
                /*0x2b6bf94*/ OnWebSocketOpenDelegate(object object, nint method);
                /*0x2b6c044*/ void Invoke(Best.WebSockets.WebSocket webSocket);
            }

            class OnWebSocketMessageDelegate : System.MulticastDelegate
            {
                /*0x2b6c058*/ OnWebSocketMessageDelegate(object object, nint method);
                /*0x2b6c10c*/ void Invoke(Best.WebSockets.WebSocket webSocket, string message);
            }

            class OnWebSocketBinaryNoAllocDelegate : System.MulticastDelegate
            {
                /*0x2b6c120*/ OnWebSocketBinaryNoAllocDelegate(object object, nint method);
                /*0x2b6c1d4*/ void Invoke(Best.WebSockets.WebSocket webSocket, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data);
            }

            class OnWebSocketClosedDelegate : System.MulticastDelegate
            {
                /*0x2b6c1e8*/ OnWebSocketClosedDelegate(object object, nint method);
                /*0x2b6c29c*/ void Invoke(Best.WebSockets.WebSocket webSocket, Best.WebSockets.WebSocketStatusCodes code, string message);
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

                static /*0x2b6c464*/ WebSocketBaseImplementation();
                static /*0x2b67e6c*/ bool CanReadFullFrame(Best.HTTP.Shared.Streams.PeekableStream stream);
                /*0x2b636ec*/ WebSocketBaseImplementation(Best.WebSockets.WebSocket parent, System.Uri uri, string origin, string protocol);
                /*0x2b6c2b0*/ Best.WebSockets.Implementations.WebSocketStates get_State();
                /*0x2b6c2b8*/ void set_State(Best.WebSockets.Implementations.WebSocketStates value);
                /*0x2b60194*/ bool get_IsOpen();
                /*0x2b640d0*/ Best.HTTP.HTTPRequest get_InternalRequest();
                /*0x2b6c2c0*/ void set_Latency(int value);
                /*0x2b6c2c8*/ System.DateTime get_LastMessageReceived();
                /*0x2b6c2d0*/ void set_LastMessageReceived(System.DateTime value);
                /*0x2b6c2d8*/ Best.WebSockets.WebSocket get_Parent();
                /*0x2b6c2e0*/ System.Uri get_Uri();
                /*0x2b6c2e8*/ void set_Uri(System.Uri value);
                /*0x2b6c2f0*/ string get_Origin();
                /*0x2b6c2f8*/ string get_Protocol();
                /*0x1f309e4*/ void StartOpen();
                /*0x1f31674*/ void StartClose(Best.WebSockets.WebSocketStatusCodes code, string message);
                /*0x1f30ebc*/ void Send(byte[] buffer);
                /*0x2b64798*/ void ParseExtensionResponse(Best.HTTP.HTTPResponse resp);
                /*0x1f309e4*/ void CreateInternalRequest();
                void Send(Best.WebSockets.Implementations.Frames.WebSocketFrame frame);
                /*0x2b6c300*/ void Cleanup();
                /*0x2b67dc0*/ int CalculateLatency();
            }

            namespace Frames
            {
                struct WebSocketFrame
                {
                    /*0x10*/ Best.WebSockets.Implementations.Frames.WebSocketFrameTypes <Type>k__BackingField;
                    /*0x18*/ Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment <Data>k__BackingField;
                    /*0x28*/ Best.WebSockets.WebSocket <Websocket>k__BackingField;
                    /*0x30*/ byte Header;

                    static /*0x2b6c968*/ void WriteFragment(System.Action<Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment> callback, byte Header, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment Data, bool mask, Best.HTTP.Shared.Logger.LoggingContext context);
                    static /*0x2b6ceac*/ void ApplyMask(byte* pData, int DataOffset, int DataCount, byte* pmask);
                    static /*0x2b6cf74*/ void ApplyMask$BurstManaged(byte* pData, int DataOffset, int DataCount, byte* pmask);
                    /*0x2b661b4*/ WebSocketFrame(Best.WebSockets.WebSocket webSocket, Best.WebSockets.Implementations.Frames.WebSocketFrameTypes type, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data);
                    /*0x2b6683c*/ WebSocketFrame(Best.WebSockets.WebSocket webSocket, Best.WebSockets.Implementations.Frames.WebSocketFrameTypes type, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data, bool copyData);
                    /*0x2b6c4b0*/ Best.WebSockets.Implementations.Frames.WebSocketFrameTypes get_Type();
                    /*0x2b6c4b8*/ void set_Type(Best.WebSockets.Implementations.Frames.WebSocketFrameTypes value);
                    /*0x2b6c4c0*/ Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment get_Data();
                    /*0x2b6c4cc*/ void set_Data(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment value);
                    /*0x2b6c4d8*/ Best.WebSockets.WebSocket get_Websocket();
                    /*0x2b6c4e0*/ void set_Websocket(Best.WebSockets.WebSocket value);
                    /*0x2b6c4e8*/ string ToString();
                    /*0x2b633c0*/ void WriteTo(System.Action<Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment> callback, uint maxFragmentSize, bool mask, Best.HTTP.Shared.Logger.LoggingContext context);
                    /*0x2b6c5c8*/ void DoExtensions();
                    /*0x2b6c830*/ void FragmentAndSend(System.Action<Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment> callback, uint maxFragmentSize, bool mask, Best.HTTP.Shared.Logger.LoggingContext context);

                    class ApplyMask_000000A5$PostfixBurstDelegate : System.MulticastDelegate
                    {
                        /*0x2b6d18c*/ ApplyMask_000000A5$PostfixBurstDelegate(object , nint );
                        /*0x2b6d240*/ void Invoke(byte* pData, int DataOffset, int DataCount, byte* pmask);
                    }

                    class ApplyMask_000000A5$BurstDirectCall
                    {
                        static /*0x0*/ nint Pointer;

                        static /*0x2b6d254*/ void GetFunctionPointerDiscard(ref nint );
                        static /*0x2b6d344*/ nint GetFunctionPointer();
                        static /*0x2b6ceb0*/ void Invoke(byte* pData, int DataOffset, int DataCount, byte* pmask);
                    }
                }

                struct WebSocketFrameReader
                {
                    /*0x10*/ byte <Header>k__BackingField;
                    /*0x11*/ bool <IsFinal>k__BackingField;
                    /*0x12*/ Best.WebSockets.Implementations.Frames.WebSocketFrameTypes <Type>k__BackingField;
                    /*0x18*/ Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment <Data>k__BackingField;
                    /*0x28*/ string <DataAsText>k__BackingField;

                    static /*0x2b6d3b4*/ byte ReadByte(System.IO.Stream stream);
                    /*0x2b6d35c*/ byte get_Header();
                    /*0x2b6d364*/ void set_Header(byte value);
                    /*0x2b6d36c*/ bool get_IsFinal();
                    /*0x2b6d374*/ void set_IsFinal(bool value);
                    /*0x2b6d37c*/ Best.WebSockets.Implementations.Frames.WebSocketFrameTypes get_Type();
                    /*0x2b6d384*/ void set_Type(Best.WebSockets.Implementations.Frames.WebSocketFrameTypes value);
                    /*0x2b6d38c*/ Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment get_Data();
                    /*0x2b6d398*/ void set_Data(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment value);
                    /*0x2b6d3a4*/ string get_DataAsText();
                    /*0x2b6d3ac*/ void set_DataAsText(string value);
                    /*0x2b67230*/ void Read(System.IO.Stream stream);
                    /*0x2b67814*/ void Assemble(System.Collections.Generic.List<Best.WebSockets.Implementations.Frames.WebSocketFrameReader> fragments);
                    /*0x2b67ac8*/ void DecodeWithExtensions(Best.WebSockets.WebSocket webSocket);
                    /*0x2b6912c*/ void ReleaseData();
                    /*0x2b67610*/ string ToString();
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
                /*0x1f30ebc*/ void AddNegotiation(Best.HTTP.HTTPRequest request);
                /*0x1f2fec8*/ bool ParseNegotiation(Best.HTTP.HTTPResponse resp);
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

                static /*0x2b6e158*/ PerMessageCompression();
                /*0x2b600f0*/ PerMessageCompression(Best.HTTP.Shared.Compression.Zlib.CompressionLevel level, bool clientNoContextTakeover, bool serverNoContextTakeover, int desiredClientMaxWindowBits, int desiredServerMaxWindowBits, int minDatalengthToCompress);
                /*0x2b6d400*/ bool get_ClientNoContextTakeover();
                /*0x2b6d408*/ void set_ClientNoContextTakeover(bool value);
                /*0x2b6d410*/ bool get_ServerNoContextTakeover();
                /*0x2b6d418*/ void set_ServerNoContextTakeover(bool value);
                /*0x2b6d420*/ int get_ClientMaxWindowBits();
                /*0x2b6d428*/ void set_ClientMaxWindowBits(int value);
                /*0x2b6d430*/ int get_ServerMaxWindowBits();
                /*0x2b6d438*/ void set_ServerMaxWindowBits(int value);
                /*0x2b6d440*/ Best.HTTP.Shared.Compression.Zlib.CompressionLevel get_Level();
                /*0x2b6d448*/ void set_Level(Best.HTTP.Shared.Compression.Zlib.CompressionLevel value);
                /*0x2b6d450*/ int get_MinimumDataLegthToCompress();
                /*0x2b6d458*/ void set_MinimumDataLegthToCompress(int value);
                /*0x2b6d460*/ void AddNegotiation(Best.HTTP.HTTPRequest request);
                /*0x2b6d60c*/ bool ParseNegotiation(Best.HTTP.HTTPResponse resp);
                /*0x2b6da04*/ byte GetFrameHeader(Best.WebSockets.Implementations.Frames.WebSocketFrame writer, byte inFlag);
                /*0x2b6da30*/ Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment Encode(Best.WebSockets.Implementations.Frames.WebSocketFrame writer);
                /*0x2b6dd54*/ Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment Decode(byte header, Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data);
                /*0x2b6da50*/ Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment Compress(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data);
                /*0x2b6dd70*/ Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment Decompress(Best.HTTP.Shared.PlatformSupport.Memory.BufferSegment data);
                /*0x2b6e094*/ void CheckDisposed();
                /*0x2b6e0ec*/ void System.IDisposable.Dispose();
            }
        }
    }
}

class $BurstDirectCallInitializer
{
    static /*0x2b6e1f8*/ void Initialize();
}
