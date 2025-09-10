class <Module>
{
}

namespace WebSocketSharp
{
    class Ext
    {
        static string _tspecials = "()<>@,;:\"/[]?={} 	";
        static /*0x0*/ byte[] _last;
        static /*0x8*/ int _retry;

        static /*0xed1084*/ Ext();
        static /*0xecb6a4*/ byte[] compress(byte[] data);
        static /*0xecba34*/ System.IO.MemoryStream compress(System.IO.Stream stream);
        static /*0xecb86c*/ byte[] compressToArray(System.IO.Stream stream);
        static /*0xecbd94*/ byte[] decompress(byte[] data);
        static /*0xecc124*/ System.IO.MemoryStream decompress(System.IO.Stream stream);
        static /*0xecbf5c*/ byte[] decompressToArray(System.IO.Stream stream);
        static /*0xecc360*/ void times(ulong n, System.Action action);
        static /*0xecc3a0*/ byte[] Append(ushort code, string reason);
        static /*0xecc588*/ string CheckIfAvailable(WebSocketSharp.Server.ServerState state, bool ready, bool start, bool shutting);
        static /*0xecc664*/ string CheckIfAvailable(WebSocketSharp.WebSocketState state, bool connecting, bool open, bool closing, bool closed);
        static /*0xecc75c*/ string CheckIfValidProtocols(string[] protocols);
        static /*0xecc9a0*/ string CheckIfValidSessionID(string id);
        static /*0xecc9f8*/ bool CheckWaitTime(System.TimeSpan time, ref string message);
        static /*0xecca9c*/ void Close(WebSocketSharp.Net.HttpListenerResponse response, WebSocketSharp.Net.HttpStatusCode code);
        static /*0xeccad8*/ void CloseWithAuthChallenge(WebSocketSharp.Net.HttpListenerResponse response, string challenge);
        static /*0xeccb74*/ byte[] Compress(byte[] data, WebSocketSharp.CompressionMethod method);
        static /*0xeccbe8*/ System.IO.Stream Compress(System.IO.Stream stream, WebSocketSharp.CompressionMethod method);
        static /*0xeccc5c*/ byte[] CompressToArray(System.IO.Stream stream, WebSocketSharp.CompressionMethod method);
        static bool Contains<T>(System.Collections.Generic.IEnumerable<T> source, System.Func<T, bool> condition);
        static /*0xecc8d4*/ bool ContainsTwice(string[] values);
        static T[] Copy<T>(T[] source, int length);
        static T[] Copy<T>(T[] source, long length);
        static /*0xecbcb4*/ void CopyTo(System.IO.Stream source, System.IO.Stream destination, int bufferLength);
        static /*0xeccef0*/ void CopyToAsync(System.IO.Stream source, System.IO.Stream destination, int bufferLength, System.Action completed, System.Action<System.Exception> error);
        static /*0xecd0d4*/ byte[] Decompress(byte[] data, WebSocketSharp.CompressionMethod method);
        static /*0xecd148*/ System.IO.Stream Decompress(System.IO.Stream stream, WebSocketSharp.CompressionMethod method);
        static /*0xecd1bc*/ byte[] DecompressToArray(System.IO.Stream stream, WebSocketSharp.CompressionMethod method);
        static /*0xecd238*/ bool EqualsWith(int value, char c, System.Action<int> action);
        static /*0xecd278*/ string GetAbsolutePath(System.Uri uri);
        static /*0xecd380*/ string GetMessage(WebSocketSharp.CloseStatusCode code);
        static /*0xecd468*/ string GetName(string nameAndValue, char separator);
        static /*0xecd4b8*/ string GetValue(string nameAndValue, char separator);
        static /*0xecd510*/ string GetValue(string nameAndValue, char separator, bool unquote);
        static /*0xecd6c0*/ WebSocketSharp.Net.WebSockets.TcpListenerWebSocketContext GetWebSocketContext(System.Net.Sockets.TcpClient tcpClient, string protocol, bool secure, WebSocketSharp.Net.ServerSslConfiguration sslConfig, WebSocketSharp.Logger logger);
        static /*0xecc4d8*/ byte[] InternalToByteArray(ushort value, WebSocketSharp.ByteOrder order);
        static /*0xecd7c0*/ byte[] InternalToByteArray(ulong value, WebSocketSharp.ByteOrder order);
        static /*0xecd870*/ bool IsCompressionExtension(string value, WebSocketSharp.CompressionMethod method);
        static /*0xecda88*/ bool IsControl(byte opcode);
        static /*0xecda98*/ bool IsControl(WebSocketSharp.Opcode opcode);
        static /*0xecdaa8*/ bool IsData(byte opcode);
        static /*0xecdabc*/ bool IsData(WebSocketSharp.Opcode opcode);
        static /*0xecdad0*/ bool IsPortNumber(int value);
        static /*0xecdae4*/ bool IsReserved(ushort code);
        static /*0xecdb14*/ bool IsReserved(WebSocketSharp.CloseStatusCode code);
        static /*0xecdb44*/ bool IsSupported(byte opcode);
        static /*0xecdc28*/ bool IsText(string value);
        static /*0xecde10*/ bool IsToken(string value);
        static /*0xecdf24*/ string Quote(string value);
        static /*0xecdfb8*/ byte[] ReadBytes(System.IO.Stream stream, int length);
        static /*0xece120*/ byte[] ReadBytes(System.IO.Stream stream, long length, int bufferLength);
        static /*0xece3f8*/ void ReadBytesAsync(System.IO.Stream stream, int length, System.Action<System.Byte[]> completed, System.Action<System.Exception> error);
        static /*0xece5cc*/ void ReadBytesAsync(System.IO.Stream stream, long length, int bufferLength, System.Action<System.Byte[]> completed, System.Action<System.Exception> error);
        static /*0xece7c4*/ string RemovePrefix(string value, string[] prefixes);
        static T[] Reverse<T>(T[] array);
        static /*0xece870*/ System.Collections.Generic.IEnumerable<string> SplitHeaderValue(string value, char[] separators);
        static /*0xecccd8*/ byte[] ToByteArray(System.IO.Stream stream);
        static /*0xece928*/ WebSocketSharp.CompressionMethod ToCompressionMethod(string value);
        static /*0xecd914*/ string ToExtensionString(WebSocketSharp.CompressionMethod method, string[] parameters);
        static /*0xeced00*/ System.Net.IPAddress ToIPAddress(string value);
        static System.Collections.Generic.List<TSource> ToList<TSource>(System.Collections.Generic.IEnumerable<TSource> source);
        static /*0xecee1c*/ ushort ToUInt16(byte[] source, WebSocketSharp.ByteOrder sourceOrder);
        static /*0xecefb4*/ ulong ToUInt64(byte[] source, WebSocketSharp.ByteOrder sourceOrder);
        static /*0xecf054*/ string TrimSlashFromEnd(string value);
        static /*0xecf0f8*/ string TrimSlashOrBackslashFromEnd(string value);
        static /*0xecf1c0*/ bool TryCreateWebSocketUri(string uriString, ref System.Uri result, ref string message);
        static /*0xecf5f0*/ bool TryGetUTF8DecodedString(byte[] bytes, ref string s);
        static /*0xecf6b8*/ bool TryGetUTF8EncodedBytes(string s, ref byte[] bytes);
        static /*0xecf780*/ bool TryOpenRead(System.IO.FileInfo fileInfo, ref System.IO.FileStream fileStream);
        static /*0xecd5dc*/ string Unquote(string value);
        static /*0xecf824*/ string UTF8Decode(byte[] bytes);
        static /*0xecf8d4*/ byte[] UTF8Encode(string s);
        static /*0xecf904*/ void WriteBytes(System.IO.Stream stream, byte[] bytes, int bufferLength);
        static /*0xecfac8*/ void WriteBytesAsync(System.IO.Stream stream, byte[] bytes, int bufferLength, System.Action completed, System.Action<System.Exception> error);
        static /*0xecddcc*/ bool Contains(string value, char[] chars);
        static /*0xecfc50*/ bool Contains(System.Collections.Specialized.NameValueCollection collection, string name);
        static /*0xecfca8*/ bool Contains(System.Collections.Specialized.NameValueCollection collection, string name, string value);
        static /*0xecfdcc*/ void Emit(System.EventHandler eventHandler, object sender, System.EventArgs e);
        static void Emit<TEventArgs>(System.EventHandler<TEventArgs> eventHandler, object sender, TEventArgs e);
        static /*0xecfde8*/ WebSocketSharp.Net.CookieCollection GetCookies(System.Collections.Specialized.NameValueCollection headers, bool response);
        static /*0xecfee8*/ string GetDescription(WebSocketSharp.Net.HttpStatusCode code);
        static /*0xecff3c*/ string GetStatusDescription(int code);
        static /*0xed048c*/ bool IsCloseStatusCode(ushort value);
        static /*0xed04a0*/ bool IsEnclosedIn(string value, char c);
        static /*0xecd754*/ bool IsHostOrder(WebSocketSharp.ByteOrder order);
        static /*0xed0514*/ bool IsLocal(System.Net.IPAddress address);
        static /*0xed06cc*/ bool IsNullOrEmpty(string value);
        static /*0xed06e8*/ bool IsPredefinedScheme(string value);
        static /*0xed0914*/ bool IsUpgradeTo(WebSocketSharp.Net.HttpListenerRequest request, string protocol);
        static /*0xed0ad0*/ bool MaybeUri(string value);
        static T[] SubArray<T>(T[] array, int startIndex, int length);
        static T[] SubArray<T>(T[] array, long startIndex, long length);
        static /*0xed0b7c*/ void Times(int n, System.Action action);
        static /*0xed0bf0*/ void Times(long n, System.Action action);
        static /*0xed0c64*/ void Times(uint n, System.Action action);
        static /*0xed0cd4*/ void Times(ulong n, System.Action action);
        static /*0xed0d44*/ void Times(int n, System.Action<int> action);
        static /*0xed0d90*/ void Times(long n, System.Action<long> action);
        static /*0xed0ddc*/ void Times(uint n, System.Action<uint> action);
        static /*0xed0e24*/ void Times(ulong n, System.Action<ulong> action);
        static T To<T>(byte[] source, WebSocketSharp.ByteOrder sourceOrder);
        static byte[] ToByteArray<T>(T value, WebSocketSharp.ByteOrder order);
        static /*0xeceebc*/ byte[] ToHostOrder(byte[] source, WebSocketSharp.ByteOrder sourceOrder);
        static string ToString<T>(T[] array, string separator);
        static /*0xecf540*/ System.Uri ToUri(string value);
        static /*0xed0e6c*/ string UrlDecode(string value);
        static /*0xed0ee4*/ string UrlEncode(string value);
        static /*0xed0f5c*/ void WriteContent(WebSocketSharp.Net.HttpListenerResponse response, byte[] content);

        class <>c
        {
            static /*0x0*/ WebSocketSharp.Ext.<> <>9;
            static /*0x8*/ System.Func<string, bool> <>9__13_0;

            static /*0xed10fc*/ <>c();
            /*0xed1160*/ <>c();
            /*0xed1168*/ bool <CheckIfValidProtocols>b__13_0(string protocol);
        }

        class <>c__DisplayClass22_0
        {
            /*0x10*/ int len;
            /*0x18*/ string[] values;
            /*0x20*/ System.Func<int, bool> contains;

            /*0xeccee8*/ <>c__DisplayClass22_0();
            /*0xed11dc*/ bool <ContainsTwice>b__0(int idx);
        }

        class <>c__DisplayClass26_0
        {
            /*0x10*/ System.IO.Stream source;
            /*0x18*/ System.Action completed;
            /*0x20*/ System.IO.Stream destination;
            /*0x28*/ byte[] buff;
            /*0x30*/ int bufferLength;
            /*0x38*/ System.AsyncCallback callback;
            /*0x40*/ System.Action<System.Exception> error;

            /*0xecd0cc*/ <>c__DisplayClass26_0();
            /*0xed12c8*/ void <CopyToAsync>b__0(System.IAsyncResult ar);
        }

        class <>c__DisplayClass53_0
        {
            /*0x10*/ System.IO.Stream stream;
            /*0x18*/ int retry;
            /*0x20*/ byte[] buff;
            /*0x28*/ int offset;
            /*0x2c*/ int length;
            /*0x30*/ System.AsyncCallback callback;
            /*0x38*/ System.Action<System.Byte[]> completed;
            /*0x40*/ System.Action<System.Exception> error;

            /*0xece5c4*/ <>c__DisplayClass53_0();
            /*0xed1420*/ void <ReadBytesAsync>b__0(System.IAsyncResult ar);
        }

        class <>c__DisplayClass54_0
        {
            /*0x10*/ int bufferLength;
            /*0x18*/ System.IO.Stream stream;
            /*0x20*/ byte[] buff;
            /*0x28*/ System.IO.MemoryStream dest;
            /*0x30*/ int retry;
            /*0x38*/ System.Action<long> read;
            /*0x40*/ System.Action<System.Byte[]> completed;
            /*0x48*/ System.Action<System.Exception> error;

            /*0xece7bc*/ <>c__DisplayClass54_0();
            /*0xed1654*/ void <ReadBytesAsync>b__0(long len);
        }

        class <>c__DisplayClass54_1
        {
            /*0x10*/ long len;
            /*0x18*/ WebSocketSharp.Ext.<> CS$<>8__locals1;

            /*0xed1748*/ <>c__DisplayClass54_1();
            /*0xed1750*/ void <ReadBytesAsync>b__1(System.IAsyncResult ar);
        }

        class <SplitHeaderValue>d__57 : System.Collections.Generic.IEnumerable<string>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<string>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ string <>2__current;
            /*0x20*/ int <>l__initialThreadId;
            /*0x28*/ string value;
            /*0x30*/ string <>3__value;
            /*0x38*/ char[] separators;
            /*0x40*/ char[] <>3__separators;
            /*0x48*/ int <len>5__1;
            /*0x50*/ string <seps>5__2;
            /*0x58*/ System.Text.StringBuilder <buff>5__3;
            /*0x60*/ bool <escaped>5__4;
            /*0x61*/ bool <quoted>5__5;
            /*0x64*/ int <i>5__6;
            /*0x68*/ char <c>5__7;

            /*0xece8e4*/ <SplitHeaderValue>d__57(int <>1__state);
            /*0xed1a48*/ void System.IDisposable.Dispose();
            /*0xed1a4c*/ bool MoveNext();
            /*0xed1cc8*/ string System.Collections.Generic.IEnumerator<System.String>.get_Current();
            /*0xed1cd0*/ void System.Collections.IEnumerator.Reset();
            /*0xed1d10*/ object System.Collections.IEnumerator.get_Current();
            /*0xed1d18*/ System.Collections.Generic.IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator();
            /*0xed1dc0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class <>c__DisplayClass75_0
        {
            /*0x10*/ System.Action completed;
            /*0x18*/ System.IO.MemoryStream input;
            /*0x20*/ System.Action<System.Exception> error;

            /*0xecfc48*/ <>c__DisplayClass75_0();
            /*0xed1dc4*/ void <WriteBytesAsync>b__0();
            /*0xed1dfc*/ void <WriteBytesAsync>b__1(System.Exception ex);
        }

        class <>c__DisplayClass105_0<T>
        {
            /*0x0*/ System.Text.StringBuilder buff;
            /*0x0*/ T[] array;
            /*0x0*/ string separator;

            <>c__DisplayClass105_0();
            void <ToString>b__0(int i);
        }
    }

    class MessageEventArgs : System.EventArgs
    {
        /*0x10*/ string _data;
        /*0x18*/ bool _dataSet;
        /*0x19*/ WebSocketSharp.Opcode _opcode;
        /*0x20*/ byte[] _rawData;

        /*0xed1e50*/ MessageEventArgs(WebSocketSharp.WebSocketFrame frame);
        /*0xed1f88*/ MessageEventArgs(WebSocketSharp.Opcode opcode, byte[] rawData);
        /*0xed2088*/ WebSocketSharp.Opcode get_Opcode();
        /*0xed2090*/ string get_Data();
        /*0xed2124*/ bool get_IsBinary();
        /*0xed2134*/ bool get_IsPing();
        /*0xed2144*/ bool get_IsText();
        /*0xed2154*/ byte[] get_RawData();
        /*0xed20a8*/ void setData();
    }

    class CloseEventArgs : System.EventArgs
    {
        /*0x10*/ bool _clean;
        /*0x18*/ WebSocketSharp.PayloadData _payloadData;

        /*0xed216c*/ CloseEventArgs();
        /*0xed21fc*/ CloseEventArgs(ushort code);
        /*0xed22a8*/ CloseEventArgs(WebSocketSharp.CloseStatusCode code);
        /*0xed22b0*/ CloseEventArgs(WebSocketSharp.PayloadData payloadData);
        /*0xed2204*/ CloseEventArgs(ushort code, string reason);
        /*0xed23e4*/ CloseEventArgs(WebSocketSharp.CloseStatusCode code, string reason);
        /*0xed23e8*/ WebSocketSharp.PayloadData get_PayloadData();
        /*0xed23f0*/ ushort get_Code();
        /*0xed24bc*/ string get_Reason();
        /*0xed25f0*/ bool get_WasClean();
        /*0xed25f8*/ void set_WasClean(bool value);
    }

    enum ByteOrder
    {
        Little = 0,
        Big = 1,
    }

    class ErrorEventArgs : System.EventArgs
    {
        /*0x10*/ System.Exception _exception;
        /*0x18*/ string _message;

        /*0xed2604*/ ErrorEventArgs(string message);
        /*0xed260c*/ ErrorEventArgs(string message, System.Exception exception);
        /*0xed267c*/ System.Exception get_Exception();
        /*0xed2684*/ string get_Message();
    }

    class WebSocket : System.IDisposable
    {
        static string _guid = "258EAFA5-E914-47DA-95CA-C5AB0DC85B11";
        static string _version = "13";
        static /*0x0*/ int _maxRetryCountForConnect;
        static /*0x8*/ byte[] EmptyBytes;
        static /*0x10*/ int FragmentLength;
        static /*0x18*/ System.Security.Cryptography.RandomNumberGenerator RandomNumber;
        /*0x10*/ WebSocketSharp.Net.AuthenticationChallenge _authChallenge;
        /*0x18*/ string _base64Key;
        /*0x20*/ bool _client;
        /*0x28*/ System.Action _closeContext;
        /*0x30*/ WebSocketSharp.CompressionMethod _compression;
        /*0x38*/ WebSocketSharp.Net.WebSockets.WebSocketContext _context;
        /*0x40*/ WebSocketSharp.Net.CookieCollection _cookies;
        /*0x48*/ WebSocketSharp.Net.NetworkCredential _credentials;
        /*0x50*/ bool _emitOnPing;
        /*0x51*/ bool _enableRedirection;
        /*0x58*/ string _extensions;
        /*0x60*/ bool _extensionsRequested;
        /*0x68*/ object _forMessageEventQueue;
        /*0x70*/ object _forPing;
        /*0x78*/ object _forSend;
        /*0x80*/ object _forState;
        /*0x88*/ System.IO.MemoryStream _fragmentsBuffer;
        /*0x90*/ bool _fragmentsCompressed;
        /*0x91*/ WebSocketSharp.Opcode _fragmentsOpcode;
        /*0x98*/ System.Func<WebSocketSharp.Net.WebSockets.WebSocketContext, string> _handshakeRequestChecker;
        /*0xa0*/ bool _ignoreExtensions;
        /*0xa1*/ bool _inContinuation;
        /*0xa2*/ bool _inMessage;
        /*0xa8*/ WebSocketSharp.Logger _logger;
        /*0xb0*/ System.Action<WebSocketSharp.MessageEventArgs> _message;
        /*0xb8*/ System.Collections.Generic.Queue<WebSocketSharp.MessageEventArgs> _messageEventQueue;
        /*0xc0*/ uint _nonceCount;
        /*0xc8*/ string _origin;
        /*0xd0*/ System.Threading.ManualResetEvent _pongReceived;
        /*0xd8*/ bool _preAuth;
        /*0xe0*/ string _protocol;
        /*0xe8*/ string[] _protocols;
        /*0xf0*/ bool _protocolsRequested;
        /*0xf8*/ WebSocketSharp.Net.NetworkCredential _proxyCredentials;
        /*0x100*/ System.Uri _proxyUri;
        /*0x108*/ WebSocketSharp.WebSocketState _readyState;
        /*0x110*/ System.Threading.ManualResetEvent _receivingExited;
        /*0x118*/ int _retryCountForConnect;
        /*0x11c*/ bool _secure;
        /*0x120*/ WebSocketSharp.Net.ClientSslConfiguration _sslConfig;
        /*0x128*/ System.IO.Stream _stream;
        /*0x130*/ System.Net.Sockets.TcpClient _tcpClient;
        /*0x138*/ System.Uri _uri;
        /*0x140*/ System.TimeSpan _waitTime;
        /*0x148*/ System.EventHandler<WebSocketSharp.CloseEventArgs> OnClose;
        /*0x150*/ System.EventHandler<WebSocketSharp.ErrorEventArgs> OnError;
        /*0x158*/ System.EventHandler<WebSocketSharp.MessageEventArgs> OnMessage;
        /*0x160*/ System.EventHandler OnOpen;

        static /*0xed268c*/ WebSocket();
        static /*0xed619c*/ bool checkParametersForSetCredentials(string username, string password, ref string message);
        static /*0xed6308*/ bool checkParametersForSetProxy(string url, string username, string password, ref string message);
        static /*0xedac3c*/ bool CheckParametersForClose(ushort code, string reason, bool client, ref string message);
        static /*0xedade0*/ bool CheckParametersForClose(WebSocketSharp.CloseStatusCode code, string reason, bool client, ref string message);
        static /*0xedaf44*/ string CheckPingParameter(string message, ref byte[] bytes);
        static /*0xedafd8*/ string CheckSendParameter(byte[] data);
        static /*0xedb024*/ string CheckSendParameter(System.IO.FileInfo file);
        static /*0xedb070*/ string CheckSendParameter(string data);
        static /*0xedb0bc*/ string CheckSendParameters(System.IO.Stream stream, int length);
        static /*0xed2ec4*/ string CreateBase64Key();
        static /*0xed7c68*/ string CreateResponseKey(string base64Key);
        /*0xed2750*/ WebSocket(WebSocketSharp.Net.WebSockets.HttpListenerWebSocketContext context, string protocol);
        /*0xed2a44*/ WebSocket(WebSocketSharp.Net.WebSockets.TcpListenerWebSocketContext context, string protocol);
        /*0xed2bac*/ WebSocket(string url, string[] protocols);
        /*0xed2f88*/ WebSocketSharp.Net.CookieCollection get_CookieCollection();
        /*0xed2f90*/ System.Func<WebSocketSharp.Net.WebSockets.WebSocketContext, string> get_CustomHandshakeRequestChecker();
        /*0xed2f98*/ void set_CustomHandshakeRequestChecker(System.Func<WebSocketSharp.Net.WebSockets.WebSocketContext, string> value);
        /*0xed2fa0*/ bool get_HasMessage();
        /*0xed3074*/ bool get_IgnoreExtensions();
        /*0xed307c*/ void set_IgnoreExtensions(bool value);
        /*0xed3088*/ bool get_IsConnected();
        /*0xed30c8*/ WebSocketSharp.CompressionMethod get_Compression();
        /*0xed30d0*/ void set_Compression(WebSocketSharp.CompressionMethod value);
        /*0xed35cc*/ System.Collections.Generic.IEnumerable<WebSocketSharp.Net.Cookie> get_Cookies();
        /*0xed3674*/ WebSocketSharp.Net.NetworkCredential get_Credentials();
        /*0xed367c*/ bool get_EmitOnPing();
        /*0xed3684*/ void set_EmitOnPing(bool value);
        /*0xed3690*/ bool get_EnableRedirection();
        /*0xed3698*/ void set_EnableRedirection(bool value);
        /*0xed37d4*/ string get_Extensions();
        /*0xed3828*/ bool get_IsAlive();
        /*0xed3a14*/ bool get_IsSecure();
        /*0xed3a1c*/ WebSocketSharp.Logger get_Log();
        /*0xed3a34*/ void set_Log(WebSocketSharp.Logger value);
        /*0xed3a58*/ string get_Origin();
        /*0xed3a60*/ void set_Origin(string value);
        /*0xed3cf8*/ string get_Protocol();
        /*0xed3d4c*/ void set_Protocol(string value);
        /*0xed3d54*/ WebSocketSharp.WebSocketState get_ReadyState();
        /*0xed3d6c*/ WebSocketSharp.Net.ClientSslConfiguration get_SslConfiguration();
        /*0xed3e04*/ void set_SslConfiguration(WebSocketSharp.Net.ClientSslConfiguration value);
        /*0xed3f3c*/ System.Uri get_Url();
        /*0xed3f74*/ System.TimeSpan get_WaitTime();
        /*0xed3f7c*/ void set_WaitTime(System.TimeSpan value);
        /*0xed40f0*/ void add_OnClose(System.EventHandler<WebSocketSharp.CloseEventArgs> value);
        /*0xed41a4*/ void remove_OnClose(System.EventHandler<WebSocketSharp.CloseEventArgs> value);
        /*0xed4258*/ void add_OnError(System.EventHandler<WebSocketSharp.ErrorEventArgs> value);
        /*0xed430c*/ void remove_OnError(System.EventHandler<WebSocketSharp.ErrorEventArgs> value);
        /*0xed43c0*/ void add_OnMessage(System.EventHandler<WebSocketSharp.MessageEventArgs> value);
        /*0xed4474*/ void remove_OnMessage(System.EventHandler<WebSocketSharp.MessageEventArgs> value);
        /*0xed4528*/ void add_OnOpen(System.EventHandler value);
        /*0xed45c8*/ void remove_OnOpen(System.EventHandler value);
        /*0xed4668*/ bool accept();
        /*0xed489c*/ bool acceptHandshake();
        /*0xed4b78*/ bool checkHandshakeRequest(WebSocketSharp.Net.WebSockets.WebSocketContext context, ref string message);
        /*0xed5758*/ bool checkHandshakeResponse(WebSocketSharp.HttpResponse response, ref string message);
        /*0xed34bc*/ bool checkIfAvailable(bool connecting, bool open, bool closing, bool closed, ref string message);
        /*0xed3264*/ bool checkIfAvailable(bool client, bool server, bool connecting, bool open, bool closing, bool closed, ref string message);
        /*0xed6548*/ bool checkReceivedFrame(WebSocketSharp.WebSocketFrame frame, ref string message);
        /*0xed66b8*/ void close(ushort code, string reason);
        /*0xed6844*/ void close(WebSocketSharp.PayloadData payloadData, bool send, bool receive, bool received);
        /*0xed6ea4*/ void closeAsync(ushort code, string reason);
        /*0xed7030*/ void closeAsync(WebSocketSharp.PayloadData payloadData, bool send, bool receive, bool received);
        /*0xed7170*/ bool closeHandshake(byte[] frameAsBytes, bool receive, bool received);
        /*0xed6ca0*/ bool closeHandshake(WebSocketSharp.PayloadData payloadData, bool send, bool receive, bool received);
        /*0xed73a8*/ bool connect();
        /*0xed77b4*/ string createExtensions();
        /*0xed4db0*/ WebSocketSharp.HttpResponse createHandshakeFailureResponse(WebSocketSharp.Net.HttpStatusCode code);
        /*0xed7974*/ WebSocketSharp.HttpRequest createHandshakeRequest();
        /*0xed556c*/ WebSocketSharp.HttpResponse createHandshakeResponse();
        /*0xed4ee8*/ bool customCheckHandshakeRequest(WebSocketSharp.Net.WebSockets.WebSocketContext context, ref string message);
        /*0xed7dac*/ WebSocketSharp.MessageEventArgs dequeueFromMessageEventQueue();
        /*0xed7670*/ void doHandshake();
        /*0xed86c4*/ void enqueueToMessageEventQueue(WebSocketSharp.MessageEventArgs e);
        /*0xed3348*/ void error(string message, System.Exception exception);
        /*0xed4ae4*/ void fatal(string message, System.Exception exception);
        /*0xed87b0*/ void fatal(string message, ushort code);
        /*0xed4ee4*/ void fatal(string message, WebSocketSharp.CloseStatusCode code);
        /*0xed28b8*/ void init();
        /*0xed8880*/ void message();
        /*0xed89f4*/ void messagec(WebSocketSharp.MessageEventArgs e);
        /*0xed8c70*/ void messages(WebSocketSharp.MessageEventArgs e);
        /*0xed8f44*/ void open();
        /*0xed3888*/ bool ping(byte[] data);
        /*0xed9530*/ bool processCloseFrame(WebSocketSharp.WebSocketFrame frame);
        /*0xed8674*/ void processCookies(WebSocketSharp.Net.CookieCollection cookies);
        /*0xed9628*/ bool processDataFrame(WebSocketSharp.WebSocketFrame frame);
        /*0xed9740*/ bool processFragmentFrame(WebSocketSharp.WebSocketFrame frame);
        /*0xed9a40*/ bool processPingFrame(WebSocketSharp.WebSocketFrame frame);
        /*0xed9c80*/ bool processPongFrame(WebSocketSharp.WebSocketFrame frame);
        /*0xed9d8c*/ bool processReceivedFrame(WebSocketSharp.WebSocketFrame frame);
        /*0xed4ffc*/ void processSecWebSocketExtensionsClientHeader(string value);
        /*0xed8660*/ void processSecWebSocketExtensionsServerHeader(string value);
        /*0xed4f28*/ void processSecWebSocketProtocolHeader(System.Collections.Generic.IEnumerable<string> values);
        /*0xed9ec4*/ bool processUnsupportedFrame(WebSocketSharp.WebSocketFrame frame);
        /*0xed9f80*/ void releaseClientResources();
        /*0xed9fb8*/ void releaseCommonResources();
        /*0xed6e58*/ void releaseResources();
        /*0xeda018*/ void releaseServerResources();
        /*0xeda04c*/ bool send(WebSocketSharp.Opcode opcode, System.IO.Stream stream);
        /*0xeda388*/ bool send(WebSocketSharp.Opcode opcode, System.IO.Stream stream, bool compressed);
        /*0xed9388*/ bool send(WebSocketSharp.Fin fin, WebSocketSharp.Opcode opcode, byte[] data, bool compressed);
        /*0xeda674*/ void sendAsync(WebSocketSharp.Opcode opcode, System.IO.Stream stream, System.Action<bool> completed);
        /*0xed72b4*/ bool sendBytes(byte[] bytes);
        /*0xed822c*/ WebSocketSharp.HttpResponse sendHandshakeRequest();
        /*0xeda7a4*/ WebSocketSharp.HttpResponse sendHttpRequest(WebSocketSharp.HttpRequest request, int millisecondsTimeout);
        /*0xed4e3c*/ bool sendHttpResponse(WebSocketSharp.HttpResponse response);
        /*0xeda8b0*/ void sendProxyConnectRequest();
        /*0xed7eb0*/ void setClientStream();
        /*0xed9234*/ void startReceiving();
        /*0xed5964*/ bool validateSecWebSocketAcceptHeader(string value);
        /*0xed573c*/ bool validateSecWebSocketExtensionsClientHeader(string value);
        /*0xed5b18*/ bool validateSecWebSocketExtensionsServerHeader(string value);
        /*0xed56a4*/ bool validateSecWebSocketKeyHeader(string value);
        /*0xed5720*/ bool validateSecWebSocketProtocolClientHeader(string value);
        /*0xed59e4*/ bool validateSecWebSocketProtocolServerHeader(string value);
        /*0xed56c0*/ bool validateSecWebSocketVersionClientHeader(string value);
        /*0xed613c*/ bool validateSecWebSocketVersionServerHeader(string value);
        /*0xedb158*/ void Close(WebSocketSharp.HttpResponse response);
        /*0xedb1bc*/ void Close(WebSocketSharp.Net.HttpStatusCode code);
        /*0xedb1d8*/ void Close(WebSocketSharp.PayloadData payloadData, byte[] frameAsBytes);
        /*0xedb60c*/ void InternalAccept();
        /*0xedb714*/ bool Ping(byte[] frameAsBytes, System.TimeSpan timeout);
        /*0xedb9b8*/ void Send(WebSocketSharp.Opcode opcode, byte[] data, System.Collections.Generic.Dictionary<WebSocketSharp.CompressionMethod, System.Byte[]> cache);
        /*0xedbd38*/ void Send(WebSocketSharp.Opcode opcode, System.IO.Stream stream, System.Collections.Generic.Dictionary<WebSocketSharp.CompressionMethod, System.IO.Stream> cache);
        /*0xedbfb0*/ void Accept();
        /*0xedc06c*/ void AcceptAsync();
        /*0xedc1fc*/ void Close();
        /*0xedc250*/ void Close(ushort code);
        /*0xedc344*/ void Close(WebSocketSharp.CloseStatusCode code);
        /*0xedc438*/ void Close(ushort code, string reason);
        /*0xedc51c*/ void Close(WebSocketSharp.CloseStatusCode code, string reason);
        /*0xedc600*/ void CloseAsync();
        /*0xedc654*/ void CloseAsync(ushort code);
        /*0xedc748*/ void CloseAsync(WebSocketSharp.CloseStatusCode code);
        /*0xedc83c*/ void CloseAsync(ushort code, string reason);
        /*0xedc920*/ void CloseAsync(WebSocketSharp.CloseStatusCode code, string reason);
        /*0xedca04*/ void Connect();
        /*0xedcac0*/ void ConnectAsync();
        /*0xedcc50*/ bool Ping();
        /*0xedccb0*/ bool Ping(string message);
        /*0xedce38*/ void Send(byte[] data);
        /*0xedcf58*/ void Send(System.IO.FileInfo fileInfo);
        /*0xedd108*/ void Send(string data);
        /*0xedd2b8*/ void Send(System.IO.Stream stream, int length);
        /*0xedd560*/ void SendAsync(byte[] data, System.Action<bool> completed);
        /*0xedd690*/ void SendAsync(System.IO.FileInfo fileInfo, System.Action<bool> completed);
        /*0xedd848*/ void SendAsync(string data, System.Action<bool> completed);
        /*0xedda00*/ void SendAsync(System.IO.Stream stream, int length, System.Action<bool> completed);
        /*0xeddcb8*/ void SetCookie(WebSocketSharp.Net.Cookie cookie);
        /*0xeddf30*/ void SetCredentials(string username, string password, bool preAuth);
        /*0xede224*/ void SetProxy(string url, string username, string password);
        /*0xede620*/ void System.IDisposable.Dispose();
        /*0xede674*/ void <open>b__148_0(System.IAsyncResult ar);
        /*0xede690*/ bool <processSecWebSocketProtocolHeader>b__159_0(string p);
        /*0xede6a4*/ void <startReceiving>b__175_2(System.Exception ex);

        class <get_Cookies>d__70 : System.Collections.Generic.IEnumerable<WebSocketSharp.Net.Cookie>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<WebSocketSharp.Net.Cookie>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ WebSocketSharp.Net.Cookie <>2__current;
            /*0x20*/ int <>l__initialThreadId;
            /*0x28*/ WebSocketSharp.WebSocket <>4__this;
            /*0x30*/ object <>s__1;
            /*0x38*/ System.Collections.IEnumerator <>s__2;
            /*0x40*/ WebSocketSharp.Net.Cookie <cookie>5__3;

            /*0xed3630*/ <get_Cookies>d__70(int <>1__state);
            /*0xede730*/ void System.IDisposable.Dispose();
            /*0xede7f8*/ bool MoveNext();
            /*0xedeb8c*/ void <>m__Finally1();
            /*0xedead0*/ void <>m__Finally2();
            /*0xedeba4*/ WebSocketSharp.Net.Cookie System.Collections.Generic.IEnumerator<WebSocketSharp.Net.Cookie>.get_Current();
            /*0xedebac*/ void System.Collections.IEnumerator.Reset();
            /*0xedebec*/ object System.Collections.IEnumerator.get_Current();
            /*0xedebf4*/ System.Collections.Generic.IEnumerator<WebSocketSharp.Net.Cookie> System.Collections.Generic.IEnumerable<WebSocketSharp.Net.Cookie>.GetEnumerator();
            /*0xedec94*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class <>c__DisplayClass128_0
        {
            /*0x10*/ System.Action<WebSocketSharp.PayloadData, bool, bool, bool> closer;

            /*0xed7168*/ <>c__DisplayClass128_0();
            /*0xedec98*/ void <closeAsync>b__0(System.IAsyncResult ar);
        }

        class <>c__DisplayClass147_0
        {
            /*0x10*/ WebSocketSharp.MessageEventArgs e;
            /*0x18*/ WebSocketSharp.WebSocket <>4__this;

            /*0xed8f3c*/ <>c__DisplayClass147_0();
            /*0xedecb4*/ void <messages>b__0(object state);
        }

        class <>c__DisplayClass168_0
        {
            /*0x10*/ System.Func<WebSocketSharp.Opcode, System.IO.Stream, bool> sender;
            /*0x18*/ System.Action<bool> completed;
            /*0x20*/ WebSocketSharp.WebSocket <>4__this;

            /*0xeda79c*/ <>c__DisplayClass168_0();
            /*0xedecd4*/ void <sendAsync>b__0(System.IAsyncResult ar);
        }

        class <>c__DisplayClass175_0
        {
            /*0x10*/ System.Action receive;
            /*0x18*/ WebSocketSharp.WebSocket <>4__this;
            /*0x20*/ System.Action<WebSocketSharp.WebSocketFrame> <>9__1;

            /*0xedac24*/ <>c__DisplayClass175_0();
            /*0xedee00*/ void <startReceiving>b__0();
            /*0xedef1c*/ void <startReceiving>b__1(WebSocketSharp.WebSocketFrame frame);
        }

        class <>c__DisplayClass178_0
        {
            /*0x10*/ string method;

            /*0xedac2c*/ <>c__DisplayClass178_0();
            /*0xedefe8*/ bool <validateSecWebSocketExtensionsServerHeader>b__0(string t);
        }

        class <>c__DisplayClass181_0
        {
            /*0x10*/ string value;

            /*0xedac34*/ <>c__DisplayClass181_0();
            /*0xedf098*/ bool <validateSecWebSocketProtocolServerHeader>b__0(string p);
        }

        class <>c__DisplayClass201_0
        {
            /*0x10*/ System.Func<bool> acceptor;
            /*0x18*/ WebSocketSharp.WebSocket <>4__this;

            /*0xedc1f4*/ <>c__DisplayClass201_0();
            /*0xedf0ac*/ void <AcceptAsync>b__0(System.IAsyncResult ar);
        }

        class <>c__DisplayClass213_0
        {
            /*0x10*/ System.Func<bool> connector;
            /*0x18*/ WebSocketSharp.WebSocket <>4__this;

            /*0xedcc48*/ <>c__DisplayClass213_0();
            /*0xedf0e4*/ void <ConnectAsync>b__0(System.IAsyncResult ar);
        }
    }

    enum CloseStatusCode
    {
        Normal = 1000,
        Away = 1001,
        ProtocolError = 1002,
        UnsupportedData = 1003,
        Undefined = 1004,
        NoStatus = 1005,
        Abnormal = 1006,
        InvalidData = 1007,
        PolicyViolation = 1008,
        TooBig = 1009,
        MandatoryExtension = 1010,
        ServerError = 1011,
        TlsHandshakeFailure = 1015,
    }

    enum Fin
    {
        More = 0,
        Final = 1,
    }

    enum Mask
    {
        Off = 0,
        On = 1,
    }

    enum Opcode
    {
        Cont = 0,
        Text = 1,
        Binary = 2,
        Close = 8,
        Ping = 9,
        Pong = 10,
    }

    class PayloadData : System.Collections.Generic.IEnumerable<byte>, System.Collections.IEnumerable
    {
        static /*0x0*/ WebSocketSharp.PayloadData Empty;
        static /*0x8*/ ulong MaxLength;
        /*0x10*/ ushort _code;
        /*0x12*/ bool _codeSet;
        /*0x18*/ byte[] _data;
        /*0x20*/ long _extDataLength;
        /*0x28*/ long _length;
        /*0x30*/ string _reason;
        /*0x38*/ bool _reasonSet;

        static /*0xedf11c*/ PayloadData();
        /*0xedf18c*/ PayloadData();
        /*0xedf238*/ PayloadData(byte[] data);
        /*0xedf270*/ PayloadData(byte[] data, long length);
        /*0xed231c*/ PayloadData(ushort code, string reason);
        /*0xed2408*/ ushort get_Code();
        /*0xedf2a0*/ long get_ExtensionDataLength();
        /*0xedf2a8*/ void set_ExtensionDataLength(long value);
        /*0xed9588*/ bool get_HasReservedCode();
        /*0xed251c*/ string get_Reason();
        /*0xed1ee8*/ byte[] get_ApplicationData();
        /*0xedf2b0*/ byte[] get_ExtensionData();
        /*0xedf370*/ ulong get_Length();
        /*0xedf378*/ void Mask(byte[] key);
        /*0xedf41c*/ System.Collections.Generic.IEnumerator<byte> GetEnumerator();
        /*0xedf4ac*/ byte[] ToArray();
        /*0xedf4b4*/ string ToString();
        /*0xedf510*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

        class <GetEnumerator>d__30 : System.Collections.Generic.IEnumerator<byte>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x14*/ byte <>2__current;
            /*0x18*/ WebSocketSharp.PayloadData <>4__this;
            /*0x20*/ byte[] <>s__1;
            /*0x28*/ int <>s__2;
            /*0x2c*/ byte <b>5__3;

            /*0xedf484*/ <GetEnumerator>d__30(int <>1__state);
            /*0xedf514*/ void System.IDisposable.Dispose();
            /*0xedf518*/ bool MoveNext();
            /*0xedf5c0*/ byte System.Collections.Generic.IEnumerator<System.Byte>.get_Current();
            /*0xedf5c8*/ void System.Collections.IEnumerator.Reset();
            /*0xedf608*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    enum Rsv
    {
        Off = 0,
        On = 1,
    }

    enum CompressionMethod
    {
        None = 0,
        Deflate = 1,
    }

    class WebSocketException : System.Exception
    {
        /*0x8c*/ WebSocketSharp.CloseStatusCode _code;

        /*0xedf664*/ WebSocketException();
        /*0xedf724*/ WebSocketException(System.Exception innerException);
        /*0xedac08*/ WebSocketException(string message);
        /*0xed207c*/ WebSocketException(WebSocketSharp.CloseStatusCode code);
        /*0xedf734*/ WebSocketException(string message, System.Exception innerException);
        /*0xedac18*/ WebSocketException(WebSocketSharp.CloseStatusCode code, System.Exception innerException);
        /*0xed8658*/ WebSocketException(WebSocketSharp.CloseStatusCode code, string message);
        /*0xedf674*/ WebSocketException(WebSocketSharp.CloseStatusCode code, string message, System.Exception innerException);
        /*0xed87a8*/ WebSocketSharp.CloseStatusCode get_Code();
    }

    class LogData
    {
        /*0x10*/ System.Diagnostics.StackFrame _caller;
        /*0x18*/ System.DateTime _date;
        /*0x20*/ WebSocketSharp.LogLevel _level;
        /*0x28*/ string _message;

        /*0xedf744*/ LogData(WebSocketSharp.LogLevel level, System.Diagnostics.StackFrame caller, string message);
        /*0xedf7f0*/ System.Diagnostics.StackFrame get_Caller();
        /*0xedf7f8*/ System.DateTime get_Date();
        /*0xedf800*/ WebSocketSharp.LogLevel get_Level();
        /*0xedf808*/ string get_Message();
        /*0xedf810*/ string ToString();
    }

    enum LogLevel
    {
        Trace = 0,
        Debug = 1,
        Info = 2,
        Warn = 3,
        Error = 4,
        Fatal = 5,
    }

    class Logger
    {
        /*0x10*/ string _file;
        /*0x18*/ WebSocketSharp.LogLevel _level;
        /*0x20*/ System.Action<WebSocketSharp.LogData, string> _output;
        /*0x28*/ object _sync;

        static /*0x18cb86c*/ void defaultOutput(WebSocketSharp.LogData data, string path);
        static /*0x18cb910*/ void writeToFile(string value, string path);
        /*0x18cb3a0*/ Logger();
        /*0x18cb490*/ Logger(WebSocketSharp.LogLevel level);
        /*0x18cb3b0*/ Logger(WebSocketSharp.LogLevel level, string file, System.Action<WebSocketSharp.LogData, string> output);
        /*0x18cb49c*/ string get_File();
        /*0x18cb4b4*/ void set_File(string value);
        /*0x18cb5f4*/ WebSocketSharp.LogLevel get_Level();
        /*0x18cb60c*/ void set_Level(WebSocketSharp.LogLevel value);
        /*0x18cb730*/ System.Action<WebSocketSharp.LogData, string> get_Output();
        /*0x18cb738*/ void set_Output(System.Action<WebSocketSharp.LogData, string> value);
        /*0x18cbc18*/ void output(string message, WebSocketSharp.LogLevel level);
        /*0x18cbf04*/ void Debug(string message);
        /*0x18cbf48*/ void Error(string message);
        /*0x18cbf8c*/ void Fatal(string message);
        /*0x18cbf94*/ void Info(string message);
        /*0x18cbfd8*/ void Trace(string message);
        /*0x18cb5b0*/ void Warn(string message);
    }

    enum WebSocketState
    {
        Connecting = 0,
        Open = 1,
        Closing = 2,
        Closed = 3,
    }

    class WebSocketFrame : System.Collections.Generic.IEnumerable<byte>, System.Collections.IEnumerable
    {
        static /*0x0*/ byte[] EmptyPingBytes;
        /*0x10*/ byte[] _extPayloadLength;
        /*0x18*/ WebSocketSharp.Fin _fin;
        /*0x19*/ WebSocketSharp.Mask _mask;
        /*0x20*/ byte[] _maskingKey;
        /*0x28*/ WebSocketSharp.Opcode _opcode;
        /*0x30*/ WebSocketSharp.PayloadData _payloadData;
        /*0x38*/ byte _payloadLength;
        /*0x39*/ WebSocketSharp.Rsv _rsv1;
        /*0x3a*/ WebSocketSharp.Rsv _rsv2;
        /*0x3b*/ WebSocketSharp.Rsv _rsv3;

        static /*0x18cc01c*/ WebSocketFrame();
        static /*0x18cc704*/ byte[] createMaskingKey();
        static /*0x18cc9c4*/ string dump(WebSocketSharp.WebSocketFrame frame);
        static /*0x18ccfd8*/ string print(WebSocketSharp.WebSocketFrame frame);
        static /*0x18cd46c*/ WebSocketSharp.WebSocketFrame processHeader(byte[] header);
        static /*0x18cd6d0*/ WebSocketSharp.WebSocketFrame readExtendedPayloadLength(System.IO.Stream stream, WebSocketSharp.WebSocketFrame frame);
        static /*0x18cd7f0*/ void readExtendedPayloadLengthAsync(System.IO.Stream stream, WebSocketSharp.WebSocketFrame frame, System.Action<WebSocketSharp.WebSocketFrame> completed, System.Action<System.Exception> error);
        static /*0x18cd97c*/ WebSocketSharp.WebSocketFrame readHeader(System.IO.Stream stream);
        static /*0x18cda0c*/ void readHeaderAsync(System.IO.Stream stream, System.Action<WebSocketSharp.WebSocketFrame> completed, System.Action<System.Exception> error);
        static /*0x18cdb04*/ WebSocketSharp.WebSocketFrame readMaskingKey(System.IO.Stream stream, WebSocketSharp.WebSocketFrame frame);
        static /*0x18cdc20*/ void readMaskingKeyAsync(System.IO.Stream stream, WebSocketSharp.WebSocketFrame frame, System.Action<WebSocketSharp.WebSocketFrame> completed, System.Action<System.Exception> error);
        static /*0x18cdda0*/ WebSocketSharp.WebSocketFrame readPayloadData(System.IO.Stream stream, WebSocketSharp.WebSocketFrame frame);
        static /*0x18cdf54*/ void readPayloadDataAsync(System.IO.Stream stream, WebSocketSharp.WebSocketFrame frame, System.Action<WebSocketSharp.WebSocketFrame> completed, System.Action<System.Exception> error);
        static /*0x18ce1a0*/ WebSocketSharp.WebSocketFrame CreateCloseFrame(WebSocketSharp.PayloadData payloadData, bool mask);
        static /*0x18cc070*/ WebSocketSharp.WebSocketFrame CreatePingFrame(bool mask);
        static /*0x18ce21c*/ WebSocketSharp.WebSocketFrame CreatePingFrame(byte[] data, bool mask);
        static /*0x18ce2c8*/ WebSocketSharp.WebSocketFrame CreatePongFrame(WebSocketSharp.PayloadData payloadData, bool mask);
        static /*0x18ce344*/ WebSocketSharp.WebSocketFrame ReadFrame(System.IO.Stream stream, bool unmask);
        static /*0x18ce46c*/ void ReadFrameAsync(System.IO.Stream stream, bool unmask, System.Action<WebSocketSharp.WebSocketFrame> completed, System.Action<System.Exception> error);
        /*0x18cc460*/ WebSocketFrame();
        /*0x18cc468*/ WebSocketFrame(WebSocketSharp.Opcode opcode, WebSocketSharp.PayloadData payloadData, bool mask);
        /*0x18cc660*/ WebSocketFrame(WebSocketSharp.Fin fin, WebSocketSharp.Opcode opcode, byte[] data, bool compressed, bool mask);
        /*0x18cc484*/ WebSocketFrame(WebSocketSharp.Fin fin, WebSocketSharp.Opcode opcode, WebSocketSharp.PayloadData payloadData, bool compressed, bool mask);
        /*0x18cc7a0*/ int get_ExtendedPayloadLengthCount();
        /*0x18cc7c4*/ ulong get_FullPayloadLength();
        /*0x18cc854*/ byte[] get_ExtendedPayloadLength();
        /*0x18cc85c*/ WebSocketSharp.Fin get_Fin();
        /*0x18cc864*/ bool get_IsBinary();
        /*0x18cc874*/ bool get_IsClose();
        /*0x18cc884*/ bool get_IsCompressed();
        /*0x18cc894*/ bool get_IsContinuation();
        /*0x18cc8a4*/ bool get_IsControl();
        /*0x18cc8b4*/ bool get_IsData();
        /*0x18cc8c8*/ bool get_IsFinal();
        /*0x18cc8d8*/ bool get_IsFragment();
        /*0x18cc8f8*/ bool get_IsMasked();
        /*0x18cc908*/ bool get_IsPing();
        /*0x18cc918*/ bool get_IsPong();
        /*0x18cc928*/ bool get_IsText();
        /*0x18cc938*/ ulong get_Length();
        /*0x18cc984*/ WebSocketSharp.Mask get_Mask();
        /*0x18cc98c*/ byte[] get_MaskingKey();
        /*0x18cc994*/ WebSocketSharp.Opcode get_Opcode();
        /*0x18cc99c*/ WebSocketSharp.PayloadData get_PayloadData();
        /*0x18cc9a4*/ byte get_PayloadLength();
        /*0x18cc9ac*/ WebSocketSharp.Rsv get_Rsv1();
        /*0x18cc9b4*/ WebSocketSharp.Rsv get_Rsv2();
        /*0x18cc9bc*/ WebSocketSharp.Rsv get_Rsv3();
        /*0x18ce3e8*/ void Unmask();
        /*0x18ce578*/ System.Collections.Generic.IEnumerator<byte> GetEnumerator();
        /*0x18ce608*/ void Print(bool dumped);
        /*0x18ce6a8*/ string PrintToString(bool dumped);
        /*0x18cc110*/ byte[] ToArray();
        /*0x18ce71c*/ string ToString();
        /*0x18ce784*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

        class <>c__DisplayClass67_0
        {
            /*0x10*/ System.Text.StringBuilder output;
            /*0x18*/ string lineFmt;

            /*0x18ccfd0*/ <>c__DisplayClass67_0();
            /*0x18ce788*/ System.Action<string, string, string, string> <dump>b__0();
        }

        class <>c__DisplayClass67_1
        {
            /*0x10*/ long lineCnt;
            /*0x18*/ WebSocketSharp.WebSocketFrame.<> CS$<>8__locals1;

            /*0x18ce834*/ <>c__DisplayClass67_1();
            /*0x18ce83c*/ void <dump>b__1(string arg1, string arg2, string arg3, string arg4);
        }

        class <>c__DisplayClass71_0
        {
            /*0x10*/ int len;
            /*0x18*/ WebSocketSharp.WebSocketFrame frame;
            /*0x20*/ System.Action<WebSocketSharp.WebSocketFrame> completed;

            /*0x18cd974*/ <>c__DisplayClass71_0();
            /*0x18ce9f0*/ void <readExtendedPayloadLengthAsync>b__0(byte[] bytes);
        }

        class <>c__DisplayClass73_0
        {
            /*0x10*/ System.Action<WebSocketSharp.WebSocketFrame> completed;

            /*0x18cdafc*/ <>c__DisplayClass73_0();
            /*0x18cea84*/ void <readHeaderAsync>b__0(byte[] bytes);
        }

        class <>c__DisplayClass75_0
        {
            /*0x10*/ int len;
            /*0x18*/ WebSocketSharp.WebSocketFrame frame;
            /*0x20*/ System.Action<WebSocketSharp.WebSocketFrame> completed;

            /*0x18cdd98*/ <>c__DisplayClass75_0();
            /*0x18ceb04*/ void <readMaskingKeyAsync>b__0(byte[] bytes);
        }

        class <>c__DisplayClass77_0
        {
            /*0x10*/ long llen;
            /*0x18*/ WebSocketSharp.WebSocketFrame frame;
            /*0x20*/ System.Action<WebSocketSharp.WebSocketFrame> completed;

            /*0x18ce198*/ <>c__DisplayClass77_0();
            /*0x18ceb98*/ void <readPayloadDataAsync>b__0(byte[] bytes);
        }

        class <>c__DisplayClass83_0
        {
            /*0x10*/ System.IO.Stream stream;
            /*0x18*/ bool unmask;
            /*0x20*/ System.Action<WebSocketSharp.WebSocketFrame> completed;
            /*0x28*/ System.Action<System.Exception> error;
            /*0x30*/ System.Action<WebSocketSharp.WebSocketFrame> <>9__3;
            /*0x38*/ System.Action<WebSocketSharp.WebSocketFrame> <>9__2;
            /*0x40*/ System.Action<WebSocketSharp.WebSocketFrame> <>9__1;

            /*0x18ce570*/ <>c__DisplayClass83_0();
            /*0x18cec8c*/ void <ReadFrameAsync>b__0(WebSocketSharp.WebSocketFrame frame);
            /*0x18ced58*/ void <ReadFrameAsync>b__1(WebSocketSharp.WebSocketFrame frame1);
            /*0x18cee24*/ void <ReadFrameAsync>b__2(WebSocketSharp.WebSocketFrame frame2);
            /*0x18ceef0*/ void <ReadFrameAsync>b__3(WebSocketSharp.WebSocketFrame frame3);
        }

        class <GetEnumerator>d__85 : System.Collections.Generic.IEnumerator<byte>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x14*/ byte <>2__current;
            /*0x18*/ WebSocketSharp.WebSocketFrame <>4__this;
            /*0x20*/ byte[] <>s__1;
            /*0x28*/ int <>s__2;
            /*0x2c*/ byte <b>5__3;

            /*0x18ce5e0*/ <GetEnumerator>d__85(int <>1__state);
            /*0x18cef3c*/ void System.IDisposable.Dispose();
            /*0x18cef40*/ bool MoveNext();
            /*0x18cefe8*/ byte System.Collections.Generic.IEnumerator<System.Byte>.get_Current();
            /*0x18ceff0*/ void System.Collections.IEnumerator.Reset();
            /*0x18cf030*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class HttpBase
    {
        static int _headersMaxLength = 8192;
        static string CrLf = "
";
        /*0x10*/ System.Collections.Specialized.NameValueCollection _headers;
        /*0x18*/ System.Version _version;
        /*0x20*/ byte[] EntityBodyData;

        static /*0x18cf1c0*/ byte[] readEntityBody(System.IO.Stream stream, string length);
        static /*0x18cf338*/ string[] readHeaders(System.IO.Stream stream, int maxLength);
        static T Read<T>(System.IO.Stream stream, System.Func<System.String[], T> parser, int millisecondsTimeout);
        /*0x18cf08c*/ HttpBase(System.Version version, System.Collections.Specialized.NameValueCollection headers);
        /*0x18cf0b8*/ string get_EntityBody();
        /*0x18cf1b0*/ System.Collections.Specialized.NameValueCollection get_Headers();
        /*0x18cf1b8*/ System.Version get_ProtocolVersion();
        /*0x18cf724*/ byte[] ToByteArray();

        class <>c__DisplayClass13_0
        {
            /*0x10*/ System.Collections.Generic.List<byte> buff;
            /*0x18*/ int cnt;

            /*0x18cf71c*/ <>c__DisplayClass13_0();
            /*0x18cf774*/ void <readHeaders>b__0(int i);
        }

        class <>c__DisplayClass14_0<T>
        {
            /*0x0*/ bool timeout;
            /*0x0*/ System.IO.Stream stream;

            <>c__DisplayClass14_0();
            void <Read>b__0(object state);
        }
    }

    class HttpRequest : WebSocketSharp.HttpBase
    {
        /*0x28*/ string _method;
        /*0x30*/ string _uri;
        /*0x38*/ bool _websocketRequest;
        /*0x39*/ bool _websocketRequestSet;

        static /*0x18cfc04*/ WebSocketSharp.HttpRequest CreateConnectRequest(System.Uri uri);
        static /*0x18cfd3c*/ WebSocketSharp.HttpRequest CreateWebSocketRequest(System.Uri uri);
        static /*0x18cffd4*/ WebSocketSharp.HttpRequest Parse(string[] headerParts);
        static /*0x18d0210*/ WebSocketSharp.HttpRequest Read(System.IO.Stream stream, int millisecondsTimeout);
        /*0x18cf878*/ HttpRequest(string method, string uri, System.Version version, System.Collections.Specialized.NameValueCollection headers);
        /*0x18cf8b8*/ HttpRequest(string method, string uri);
        /*0x18cf9a8*/ WebSocketSharp.Net.AuthenticationResponse get_AuthenticationResponse();
        /*0x18cfa24*/ WebSocketSharp.Net.CookieCollection get_Cookies();
        /*0x18cfa84*/ string get_HttpMethod();
        /*0x18cfa8c*/ bool get_IsWebSocketRequest();
        /*0x18cfbfc*/ string get_RequestUri();
        /*0x18cfef8*/ WebSocketSharp.HttpResponse GetResponse(System.IO.Stream stream, int millisecondsTimeout);
        /*0x18d02b8*/ void SetCookies(WebSocketSharp.Net.CookieCollection cookies);
        /*0x18d089c*/ string ToString();
    }

    class HttpResponse : WebSocketSharp.HttpBase
    {
        /*0x28*/ string _code;
        /*0x30*/ string _reason;

        static /*0x18d103c*/ WebSocketSharp.HttpResponse CreateCloseResponse(WebSocketSharp.Net.HttpStatusCode code);
        static /*0x18d10dc*/ WebSocketSharp.HttpResponse CreateUnauthorizedResponse(string challenge);
        static /*0x18d1168*/ WebSocketSharp.HttpResponse CreateWebSocketResponse();
        static /*0x18d1238*/ WebSocketSharp.HttpResponse Parse(string[] headerParts);
        static /*0x18d1470*/ WebSocketSharp.HttpResponse Read(System.IO.Stream stream, int millisecondsTimeout);
        /*0x18d0b10*/ HttpResponse(string code, string reason, System.Version version, System.Collections.Specialized.NameValueCollection headers);
        /*0x18d0b50*/ HttpResponse(WebSocketSharp.Net.HttpStatusCode code);
        /*0x18d0bc4*/ HttpResponse(WebSocketSharp.Net.HttpStatusCode code, string reason);
        /*0x18d0cd8*/ WebSocketSharp.Net.CookieCollection get_Cookies();
        /*0x18d0d38*/ bool get_HasConnectionClose();
        /*0x18d0dc4*/ bool get_IsProxyAuthenticationRequired();
        /*0x18d0e10*/ bool get_IsRedirect();
        /*0x18d0e94*/ bool get_IsUnauthorized();
        /*0x18d0ee0*/ bool get_IsWebSocketResponse();
        /*0x18d102c*/ string get_Reason();
        /*0x18d1034*/ string get_StatusCode();
        /*0x18d1518*/ void SetCookies(WebSocketSharp.Net.CookieCollection cookies);
        /*0x18d18e0*/ string ToString();
    }

    namespace Net
    {
        enum AuthenticationSchemes
        {
            None = 0,
            Digest = 1,
            Basic = 8,
            Anonymous = 32768,
        }

        class ChunkStream
        {
            /*0x10*/ int _chunkRead;
            /*0x14*/ int _chunkSize;
            /*0x18*/ System.Collections.Generic.List<WebSocketSharp.Net.Chunk> _chunks;
            /*0x20*/ bool _gotIt;
            /*0x28*/ WebSocketSharp.Net.WebHeaderCollection _headers;
            /*0x30*/ System.Text.StringBuilder _saved;
            /*0x38*/ bool _sawCr;
            /*0x3c*/ WebSocketSharp.Net.InputChunkState _state;
            /*0x40*/ int _trailerState;

            static /*0x18d1de8*/ string removeChunkExtension(string value);
            static /*0x18d1f2c*/ void throwProtocolViolation(string message);
            /*0x18d1b54*/ ChunkStream(WebSocketSharp.Net.WebHeaderCollection headers);
            /*0x18d1c1c*/ ChunkStream(byte[] buffer, int offset, int count, WebSocketSharp.Net.WebHeaderCollection headers);
            /*0x18d1c94*/ WebSocketSharp.Net.WebHeaderCollection get_Headers();
            /*0x18d1c9c*/ int get_ChunkLeft();
            /*0x18d1ca8*/ bool get_WantMore();
            /*0x18d1cb8*/ int read(byte[] buffer, int offset, int count);
            /*0x18d1e2c*/ WebSocketSharp.Net.InputChunkState seekCrLf(byte[] buffer, ref int offset, int length);
            /*0x18d1f84*/ WebSocketSharp.Net.InputChunkState setChunkSize(byte[] buffer, ref int offset, int length);
            /*0x18d21d4*/ WebSocketSharp.Net.InputChunkState setTrailer(byte[] buffer, ref int offset, int length);
            /*0x18d2490*/ void write(byte[] buffer, ref int offset, int length);
            /*0x18d2604*/ WebSocketSharp.Net.InputChunkState writeData(byte[] buffer, ref int offset, int length);
            /*0x18d2770*/ void ResetBuffer();
            /*0x18d27e8*/ int WriteAndReadBack(byte[] buffer, int offset, int writeCount, int readCount);
            /*0x18d2860*/ int Read(byte[] buffer, int offset, int count);
            /*0x18d1c70*/ void Write(byte[] buffer, int offset, int count);
        }

        class Cookie
        {
            static /*0x0*/ char[] _reservedCharsForName;
            static /*0x8*/ char[] _reservedCharsForValue;
            /*0x10*/ string _comment;
            /*0x18*/ System.Uri _commentUri;
            /*0x20*/ bool _discard;
            /*0x28*/ string _domain;
            /*0x30*/ System.DateTime _expires;
            /*0x38*/ bool _httpOnly;
            /*0x40*/ string _name;
            /*0x48*/ string _path;
            /*0x50*/ string _port;
            /*0x58*/ int[] _ports;
            /*0x60*/ bool _secure;
            /*0x68*/ System.DateTime _timestamp;
            /*0x70*/ string _value;
            /*0x78*/ int _version;
            /*0x7c*/ bool <ExactDomain>k__BackingField;

            static /*0x18d2874*/ Cookie();
            static /*0x18d3058*/ bool canSetName(string name, ref string message);
            static /*0x18d3580*/ bool canSetValue(string value, ref string message);
            static /*0x18d3730*/ int hash(int i, int j, int k, int l, int m);
            static /*0x18d3378*/ bool tryCreatePorts(string value, ref int[] result, ref string parseError);
            /*0x18d294c*/ Cookie();
            /*0x18d2a40*/ Cookie(string name, string value);
            /*0x18d2c10*/ Cookie(string name, string value, string path);
            /*0x18d2ca0*/ Cookie(string name, string value, string path, string domain);
            /*0x18d2d9c*/ bool get_ExactDomain();
            /*0x18d2da4*/ void set_ExactDomain(bool value);
            /*0x18d2db0*/ int get_MaxAge();
            /*0x18d2efc*/ int[] get_Ports();
            /*0x18d2f04*/ string get_Comment();
            /*0x18d2f0c*/ void set_Comment(string value);
            /*0x18d2f74*/ System.Uri get_CommentUri();
            /*0x18d2f7c*/ void set_CommentUri(System.Uri value);
            /*0x18d2f84*/ bool get_Discard();
            /*0x18d2f8c*/ void set_Discard(bool value);
            /*0x18d2f98*/ string get_Domain();
            /*0x18d2cd8*/ void set_Domain(string value);
            /*0x18d07f4*/ bool get_Expired();
            /*0x18d2fa0*/ void set_Expired(bool value);
            /*0x18d302c*/ System.DateTime get_Expires();
            /*0x18d3034*/ void set_Expires(System.DateTime value);
            /*0x18d303c*/ bool get_HttpOnly();
            /*0x18d3044*/ void set_HttpOnly(bool value);
            /*0x18d3050*/ string get_Name();
            /*0x18d2a78*/ void set_Name(string value);
            /*0x18d31a4*/ string get_Path();
            /*0x18d2c38*/ void set_Path(string value);
            /*0x18d31ac*/ string get_Port();
            /*0x18d31b4*/ void set_Port(string value);
            /*0x18d355c*/ bool get_Secure();
            /*0x18d3564*/ void set_Secure(bool value);
            /*0x18d3570*/ System.DateTime get_TimeStamp();
            /*0x18d3578*/ string get_Value();
            /*0x18d2b2c*/ void set_Value(string value);
            /*0x18d36a8*/ int get_Version();
            /*0x18d36b0*/ void set_Version(int value);
            /*0x18d3764*/ string toResponseStringVersion0();
            /*0x18d3a0c*/ string toResponseStringVersion1();
            /*0x18d3e48*/ string ToRequestString(System.Uri uri);
            /*0x18d1854*/ string ToResponseString();
            /*0x18d41b4*/ bool Equals(object comparand);
            /*0x18d42a0*/ int GetHashCode();
            /*0x18d443c*/ string ToString();
        }

        class CookieCollection : System.Collections.ICollection, System.Collections.IEnumerable
        {
            /*0x10*/ System.Collections.Generic.List<WebSocketSharp.Net.Cookie> _list;
            /*0x18*/ object _sync;

            static /*0x18d49e4*/ int compareCookieWithinSort(WebSocketSharp.Net.Cookie x, WebSocketSharp.Net.Cookie y);
            static /*0x18d4a38*/ int compareCookieWithinSorted(WebSocketSharp.Net.Cookie x, WebSocketSharp.Net.Cookie y);
            static /*0x18d4aa4*/ WebSocketSharp.Net.CookieCollection parseRequest(string value);
            static /*0x18d517c*/ WebSocketSharp.Net.CookieCollection parseResponse(string value);
            static /*0x18d4f24*/ string[] splitCookieHeaderValue(string value);
            static /*0x18d5bac*/ WebSocketSharp.Net.CookieCollection Parse(string value, bool response);
            /*0x18d4444*/ CookieCollection();
            /*0x18d44c4*/ System.Collections.Generic.IList<WebSocketSharp.Net.Cookie> get_List();
            /*0x18d06f4*/ System.Collections.Generic.IEnumerable<WebSocketSharp.Net.Cookie> get_Sorted();
            /*0x18d06ac*/ int get_Count();
            /*0x18d44cc*/ bool get_IsReadOnly();
            /*0x18d44d4*/ bool get_IsSynchronized();
            /*0x18d44dc*/ WebSocketSharp.Net.Cookie get_Item(int index);
            /*0x18d459c*/ WebSocketSharp.Net.Cookie get_Item(string name);
            /*0x18d4930*/ object get_SyncRoot();
            /*0x18d5a90*/ int searchCookie(WebSocketSharp.Net.Cookie cookie);
            /*0x18d5bb8*/ void SetOrRemove(WebSocketSharp.Net.Cookie cookie);
            /*0x18d5cec*/ void SetOrRemove(WebSocketSharp.Net.CookieCollection cookies);
            /*0x18d6034*/ void Sort();
            /*0x18d503c*/ void Add(WebSocketSharp.Net.Cookie cookie);
            /*0x18d60f8*/ void Add(WebSocketSharp.Net.CookieCollection cookies);
            /*0x18d63f8*/ void CopyTo(System.Array array, int index);
            /*0x18d66e0*/ void CopyTo(WebSocketSharp.Net.Cookie[] array, int index);
            /*0x18d5fa4*/ System.Collections.IEnumerator GetEnumerator();
        }

        class CookieException : System.FormatException, System.Runtime.Serialization.ISerializable
        {
            /*0x18d319c*/ CookieException(string message);
            /*0x18d6840*/ CookieException(string message, System.Exception innerException);
            /*0x18d6848*/ CookieException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x18d6850*/ CookieException();
            /*0x18d6858*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x18d6860*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
        }

        class EndPointListener
        {
            static /*0x0*/ string _defaultCertFolderPath;
            /*0x10*/ System.Collections.Generic.List<WebSocketSharp.Net.HttpListenerPrefix> _all;
            /*0x18*/ System.Net.IPEndPoint _endpoint;
            /*0x20*/ System.Collections.Generic.Dictionary<WebSocketSharp.Net.HttpListenerPrefix, WebSocketSharp.Net.HttpListener> _prefixes;
            /*0x28*/ bool _secure;
            /*0x30*/ System.Net.Sockets.Socket _socket;
            /*0x38*/ WebSocketSharp.Net.ServerSslConfiguration _sslConfig;
            /*0x40*/ System.Collections.Generic.List<WebSocketSharp.Net.HttpListenerPrefix> _unhandled;
            /*0x48*/ System.Collections.Generic.Dictionary<WebSocketSharp.Net.HttpConnection, WebSocketSharp.Net.HttpConnection> _unregistered;
            /*0x50*/ object _unregisteredSync;

            static /*0x18d6868*/ EndPointListener();
            static /*0x18d6ec8*/ void addSpecial(System.Collections.Generic.List<WebSocketSharp.Net.HttpListenerPrefix> prefixes, WebSocketSharp.Net.HttpListenerPrefix prefix);
            static /*0x18d7128*/ System.Security.Cryptography.RSACryptoServiceProvider createRSAFromFile(string filename);
            static /*0x18d6c14*/ System.Security.Cryptography.X509Certificates.X509Certificate2 getCertificate(int port, string folderPath, System.Security.Cryptography.X509Certificates.X509Certificate2 defaultCertificate);
            static /*0x18d7658*/ void onAccept(System.IAsyncResult asyncResult);
            static /*0x18d793c*/ void processAccepted(System.Net.Sockets.Socket socket, WebSocketSharp.Net.EndPointListener listener);
            static /*0x18d8120*/ bool removeSpecial(System.Collections.Generic.List<WebSocketSharp.Net.HttpListenerPrefix> prefixes, WebSocketSharp.Net.HttpListenerPrefix prefix);
            static /*0x18d8214*/ WebSocketSharp.Net.HttpListener searchHttpListenerFromSpecial(string path, System.Collections.Generic.List<WebSocketSharp.Net.HttpListenerPrefix> prefixes);
            static /*0x18d83e0*/ bool CertificateExists(int port, string folderPath);
            /*0x18d68bc*/ EndPointListener(System.Net.IPEndPoint endpoint, bool secure, string certificateFolderPath, WebSocketSharp.Net.ServerSslConfiguration sslConfig, bool reuseAddress);
            /*0x18d6e80*/ System.Net.IPAddress get_Address();
            /*0x18d6e9c*/ bool get_IsSecure();
            /*0x18d6ea4*/ int get_Port();
            /*0x18d6ec0*/ WebSocketSharp.Net.ServerSslConfiguration get_SslConfiguration();
            /*0x18d7368*/ void leaveIfNoPrefix();
            /*0x18d855c*/ void RemoveConnection(WebSocketSharp.Net.HttpConnection connection);
            /*0x18d8644*/ bool TrySearchHttpListener(System.Uri uri, ref WebSocketSharp.Net.HttpListener listener);
            /*0x18d8b7c*/ void AddPrefix(WebSocketSharp.Net.HttpListenerPrefix prefix, WebSocketSharp.Net.HttpListener listener);
            /*0x18d8ed4*/ void Close();
            /*0x18d911c*/ void RemovePrefix(WebSocketSharp.Net.HttpListenerPrefix prefix, WebSocketSharp.Net.HttpListener listener);
        }

        class EndPointManager
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<System.Net.IPEndPoint, WebSocketSharp.Net.EndPointListener> _endpoints;

            static /*0x18d9388*/ EndPointManager();
            static /*0x18d941c*/ void addPrefix(string uriPrefix, WebSocketSharp.Net.HttpListener listener);
            static /*0x18d97ec*/ System.Net.IPAddress convertToIPAddress(string hostname);
            static /*0x18d9964*/ void removePrefix(string uriPrefix, WebSocketSharp.Net.HttpListener listener);
            static /*0x18d7430*/ bool RemoveEndPoint(System.Net.IPEndPoint endpoint);
            static /*0x18d9ba8*/ void AddListener(WebSocketSharp.Net.HttpListener listener);
            static /*0x18da2b0*/ void AddPrefix(string uriPrefix, WebSocketSharp.Net.HttpListener listener);
            static /*0x18da434*/ void RemoveListener(WebSocketSharp.Net.HttpListener listener);
            static /*0x18da80c*/ void RemovePrefix(string uriPrefix, WebSocketSharp.Net.HttpListener listener);
            /*0x18d9414*/ EndPointManager();
        }

        class HttpConnection
        {
            static int _bufferLength = 8192;
            /*0x10*/ byte[] _buffer;
            /*0x18*/ WebSocketSharp.Net.HttpListenerContext _context;
            /*0x20*/ bool _contextRegistered;
            /*0x28*/ System.Text.StringBuilder _currentLine;
            /*0x30*/ WebSocketSharp.Net.InputState _inputState;
            /*0x38*/ WebSocketSharp.Net.RequestStream _inputStream;
            /*0x40*/ WebSocketSharp.Net.HttpListener _lastListener;
            /*0x48*/ WebSocketSharp.Net.LineState _lineState;
            /*0x50*/ WebSocketSharp.Net.EndPointListener _listener;
            /*0x58*/ WebSocketSharp.Net.ResponseStream _outputStream;
            /*0x60*/ int _position;
            /*0x68*/ System.IO.MemoryStream _requestBuffer;
            /*0x70*/ int _reuses;
            /*0x74*/ bool _secure;
            /*0x78*/ System.Net.Sockets.Socket _socket;
            /*0x80*/ System.IO.Stream _stream;
            /*0x88*/ object _sync;
            /*0x90*/ int _timeout;
            /*0x98*/ System.Collections.Generic.Dictionary<int, bool> _timeoutCanceled;
            /*0xa0*/ System.Threading.Timer _timer;

            static /*0x18daf34*/ void onRead(System.IAsyncResult asyncResult);
            static /*0x18dc26c*/ void onTimeout(object state);
            /*0x18d7b48*/ HttpConnection(System.Net.Sockets.Socket socket, WebSocketSharp.Net.EndPointListener listener);
            /*0x18daa20*/ bool get_IsClosed();
            /*0x18daa30*/ bool get_IsSecure();
            /*0x18daa38*/ System.Net.IPEndPoint get_LocalEndPoint();
            /*0x18daac0*/ System.Net.IPEndPoint get_RemoteEndPoint();
            /*0x18dab48*/ int get_Reuses();
            /*0x18dab50*/ System.IO.Stream get_Stream();
            /*0x18dab58*/ void close();
            /*0x18dad6c*/ void closeSocket();
            /*0x18dad1c*/ void disposeRequestBuffer();
            /*0x18dad40*/ void disposeStream();
            /*0x18dac64*/ void disposeTimer();
            /*0x18da97c*/ void init();
            /*0x18db808*/ bool processInput(byte[] data, int length);
            /*0x18dc9fc*/ string readLineFrom(byte[] buffer, int offset, int length, ref int read);
            /*0x18dae50*/ void removeConnection();
            /*0x18dae24*/ void unregisterContext();
            /*0x18d7f88*/ void Close(bool force);
            /*0x18d7db4*/ void BeginReadRequest();
            /*0x18dd044*/ void Close();
            /*0x18dd04c*/ WebSocketSharp.Net.RequestStream GetRequestStream(long contentLength, bool chunked);
            /*0x18dcc20*/ WebSocketSharp.Net.ResponseStream GetResponseStream();
            /*0x18dbe5c*/ void SendError();
            /*0x18db4b4*/ void SendError(string message, int status);
        }

        class HttpListener : System.IDisposable
        {
            static /*0x0*/ string _defaultRealm;
            /*0x10*/ WebSocketSharp.Net.AuthenticationSchemes _authSchemes;
            /*0x18*/ System.Func<WebSocketSharp.Net.HttpListenerRequest, WebSocketSharp.Net.AuthenticationSchemes> _authSchemeSelector;
            /*0x20*/ string _certFolderPath;
            /*0x28*/ System.Collections.Generic.Dictionary<WebSocketSharp.Net.HttpConnection, WebSocketSharp.Net.HttpConnection> _connections;
            /*0x30*/ object _connectionsSync;
            /*0x38*/ System.Collections.Generic.List<WebSocketSharp.Net.HttpListenerContext> _ctxQueue;
            /*0x40*/ object _ctxQueueSync;
            /*0x48*/ System.Collections.Generic.Dictionary<WebSocketSharp.Net.HttpListenerContext, WebSocketSharp.Net.HttpListenerContext> _ctxRegistry;
            /*0x50*/ object _ctxRegistrySync;
            /*0x58*/ bool _disposed;
            /*0x59*/ bool _ignoreWriteExceptions;
            /*0x5a*/ bool _listening;
            /*0x60*/ WebSocketSharp.Logger _logger;
            /*0x68*/ WebSocketSharp.Net.HttpListenerPrefixCollection _prefixes;
            /*0x70*/ string _realm;
            /*0x78*/ bool _reuseAddress;
            /*0x80*/ WebSocketSharp.Net.ServerSslConfiguration _sslConfig;
            /*0x88*/ System.Func<System.Security.Principal.IIdentity, WebSocketSharp.Net.NetworkCredential> _userCredFinder;
            /*0x90*/ System.Collections.Generic.List<WebSocketSharp.Net.HttpListenerAsyncResult> _waitQueue;
            /*0x98*/ object _waitQueueSync;

            static /*0x18dd2b8*/ HttpListener();
            static /*0x18dd86c*/ bool get_IsSupported();
            /*0x18dd318*/ HttpListener();
            /*0x18dd700*/ bool get_IsDisposed();
            /*0x18d995c*/ bool get_ReuseAddress();
            /*0x18dd708*/ void set_ReuseAddress(bool value);
            /*0x18dd714*/ WebSocketSharp.Net.AuthenticationSchemes get_AuthenticationSchemes();
            /*0x18dd7ac*/ void set_AuthenticationSchemes(WebSocketSharp.Net.AuthenticationSchemes value);
            /*0x18dd7d0*/ System.Func<WebSocketSharp.Net.HttpListenerRequest, WebSocketSharp.Net.AuthenticationSchemes> get_AuthenticationSchemeSelector();
            /*0x18dd7e8*/ void set_AuthenticationSchemeSelector(System.Func<WebSocketSharp.Net.HttpListenerRequest, WebSocketSharp.Net.AuthenticationSchemes> value);
            /*0x18d98d0*/ string get_CertificateFolderPath();
            /*0x18dd80c*/ void set_CertificateFolderPath(string value);
            /*0x18dd290*/ bool get_IgnoreWriteExceptions();
            /*0x18dd830*/ void set_IgnoreWriteExceptions(bool value);
            /*0x18dd854*/ bool get_IsListening();
            /*0x18dd874*/ WebSocketSharp.Logger get_Log();
            /*0x18da208*/ WebSocketSharp.Net.HttpListenerPrefixCollection get_Prefixes();
            /*0x18dd87c*/ string get_Realm();
            /*0x18dd894*/ void set_Realm(string value);
            /*0x18d98e8*/ WebSocketSharp.Net.ServerSslConfiguration get_SslConfiguration();
            /*0x18dd8b8*/ void set_SslConfiguration(WebSocketSharp.Net.ServerSslConfiguration value);
            /*0x18dd8dc*/ bool get_UnsafeConnectionNtlmAuthentication();
            /*0x18dd91c*/ void set_UnsafeConnectionNtlmAuthentication(bool value);
            /*0x18dd95c*/ System.Func<System.Security.Principal.IIdentity, WebSocketSharp.Net.NetworkCredential> get_UserCredentialsFinder();
            /*0x18dd974*/ void set_UserCredentialsFinder(System.Func<System.Security.Principal.IIdentity, WebSocketSharp.Net.NetworkCredential> value);
            /*0x18dd998*/ void cleanupConnections();
            /*0x18ddbd0*/ void cleanupContextQueue(bool sendServiceUnavailable);
            /*0x18ddd98*/ void cleanupContextRegistry();
            /*0x18ddfe0*/ void cleanupWaitQueue(System.Exception exception);
            /*0x18de18c*/ void close(bool force);
            /*0x18de310*/ WebSocketSharp.Net.HttpListenerAsyncResult getAsyncResultFromQueue();
            /*0x18de3b8*/ WebSocketSharp.Net.HttpListenerContext getContextFromQueue();
            /*0x18dbe84*/ bool AddConnection(WebSocketSharp.Net.HttpConnection connection);
            /*0x18de460*/ WebSocketSharp.Net.HttpListenerAsyncResult BeginGetContext(WebSocketSharp.Net.HttpListenerAsyncResult asyncResult);
            /*0x18dd72c*/ void CheckDisposed();
            /*0x18de62c*/ string GetRealm();
            /*0x18de69c*/ System.Func<System.Security.Principal.IIdentity, WebSocketSharp.Net.NetworkCredential> GetUserCredentialsFinder();
            /*0x18de6a4*/ bool RegisterContext(WebSocketSharp.Net.HttpListenerContext context);
            /*0x18dcb1c*/ void RemoveConnection(WebSocketSharp.Net.HttpConnection connection);
            /*0x18de860*/ WebSocketSharp.Net.AuthenticationSchemes SelectAuthenticationScheme(WebSocketSharp.Net.HttpListenerRequest request);
            /*0x18de900*/ void UnregisterContext(WebSocketSharp.Net.HttpListenerContext context);
            /*0x18de9e8*/ void Abort();
            /*0x18de9fc*/ System.IAsyncResult BeginGetContext(System.AsyncCallback callback, object state);
            /*0x18deb54*/ void Close();
            /*0x18deb68*/ WebSocketSharp.Net.HttpListenerContext EndGetContext(System.IAsyncResult asyncResult);
            /*0x18ded0c*/ WebSocketSharp.Net.HttpListenerContext GetContext();
            /*0x18dee2c*/ void Start();
            /*0x18deea4*/ void Stop();
            /*0x18df020*/ void System.IDisposable.Dispose();
        }

        class HttpListenerContext
        {
            /*0x10*/ WebSocketSharp.Net.HttpConnection _connection;
            /*0x18*/ string _error;
            /*0x20*/ int _errorStatus;
            /*0x28*/ WebSocketSharp.Net.HttpListener _listener;
            /*0x30*/ WebSocketSharp.Net.HttpListenerRequest _request;
            /*0x38*/ WebSocketSharp.Net.HttpListenerResponse _response;
            /*0x40*/ System.Security.Principal.IPrincipal _user;
            /*0x48*/ WebSocketSharp.Net.WebSockets.HttpListenerWebSocketContext _websocketContext;

            /*0x18dae7c*/ HttpListenerContext(WebSocketSharp.Net.HttpConnection connection);
            /*0x18ddfd8*/ WebSocketSharp.Net.HttpConnection get_Connection();
            /*0x18dd2a8*/ string get_ErrorMessage();
            /*0x18dc3b0*/ void set_ErrorMessage(string value);
            /*0x18dd2b0*/ int get_ErrorStatus();
            /*0x18df0c4*/ void set_ErrorStatus(int value);
            /*0x18dba44*/ bool get_HasError();
            /*0x18dd288*/ WebSocketSharp.Net.HttpListener get_Listener();
            /*0x18dbfa0*/ void set_Listener(WebSocketSharp.Net.HttpListener value);
            /*0x18dba54*/ WebSocketSharp.Net.HttpListenerRequest get_Request();
            /*0x18dcd9c*/ WebSocketSharp.Net.HttpListenerResponse get_Response();
            /*0x18df0cc*/ System.Security.Principal.IPrincipal get_User();
            /*0x18dbfa8*/ bool Authenticate();
            /*0x18dc250*/ bool Register();
            /*0x18dcc04*/ void Unregister();
            /*0x18df0e4*/ WebSocketSharp.Net.WebSockets.HttpListenerWebSocketContext AcceptWebSocket(string protocol);
        }

        class HttpListenerException : System.ComponentModel.Win32Exception
        {
            /*0x18df258*/ HttpListenerException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x18df260*/ HttpListenerException();
            /*0x18de624*/ HttpListenerException(int errorCode);
            /*0x18d7120*/ HttpListenerException(int errorCode, string message);
            /*0x18df268*/ int get_ErrorCode();
        }

        class HttpListenerPrefixCollection : System.Collections.Generic.ICollection<string>, System.Collections.Generic.IEnumerable<string>, System.Collections.IEnumerable
        {
            /*0x10*/ WebSocketSharp.Net.HttpListener _listener;
            /*0x18*/ System.Collections.Generic.List<string> _prefixes;

            /*0x18dd670*/ HttpListenerPrefixCollection(WebSocketSharp.Net.HttpListener listener);
            /*0x18deb0c*/ int get_Count();
            /*0x18df270*/ bool get_IsReadOnly();
            /*0x18df278*/ bool get_IsSynchronized();
            /*0x18df280*/ void Add(string uriPrefix);
            /*0x18df3b8*/ void Clear();
            /*0x18df478*/ bool Contains(string uriPrefix);
            /*0x18df52c*/ void CopyTo(System.Array array, int offset);
            /*0x18df5f0*/ void CopyTo(string[] array, int offset);
            /*0x18da220*/ System.Collections.Generic.IEnumerator<string> GetEnumerator();
            /*0x18df664*/ bool Remove(string uriPrefix);
            /*0x18df768*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class HttpListenerRequest
        {
            static /*0x0*/ byte[] _100continue;
            /*0x10*/ string[] _acceptTypes;
            /*0x18*/ bool _chunked;
            /*0x20*/ System.Text.Encoding _contentEncoding;
            /*0x28*/ long _contentLength;
            /*0x30*/ bool _contentLengthSet;
            /*0x38*/ WebSocketSharp.Net.HttpListenerContext _context;
            /*0x40*/ WebSocketSharp.Net.CookieCollection _cookies;
            /*0x48*/ WebSocketSharp.Net.WebHeaderCollection _headers;
            /*0x50*/ System.Guid _identifier;
            /*0x60*/ System.IO.Stream _inputStream;
            /*0x68*/ bool _keepAlive;
            /*0x69*/ bool _keepAliveSet;
            /*0x70*/ string _method;
            /*0x78*/ System.Collections.Specialized.NameValueCollection _queryString;
            /*0x80*/ System.Uri _referer;
            /*0x88*/ string _uri;
            /*0x90*/ System.Uri _url;
            /*0x98*/ string[] _userLanguages;
            /*0xa0*/ System.Version _version;
            /*0xa8*/ bool _websocketRequest;
            /*0xa9*/ bool _websocketRequestSet;

            static /*0x18df7f8*/ HttpListenerRequest();
            static /*0x18dffa0*/ bool tryCreateVersion(string version, ref System.Version result);
            /*0x18df034*/ HttpListenerRequest(WebSocketSharp.Net.HttpListenerContext context);
            /*0x18df870*/ string[] get_AcceptTypes();
            /*0x18df878*/ int get_ClientCertificateError();
            /*0x18df880*/ System.Text.Encoding get_ContentEncoding();
            /*0x18df8a0*/ long get_ContentLength64();
            /*0x18df8a8*/ string get_ContentType();
            /*0x18df8fc*/ WebSocketSharp.Net.CookieCollection get_Cookies();
            /*0x18df96c*/ bool get_HasEntityBody();
            /*0x18df0d4*/ System.Collections.Specialized.NameValueCollection get_Headers();
            /*0x18df0dc*/ string get_HttpMethod();
            /*0x18df990*/ System.IO.Stream get_InputStream();
            /*0x18dfa2c*/ bool get_IsAuthenticated();
            /*0x18dfa50*/ bool get_IsLocal();
            /*0x18dfae0*/ bool get_IsSecureConnection();
            /*0x18dfb04*/ bool get_IsWebSocketRequest();
            /*0x18dfc78*/ bool get_KeepAlive();
            /*0x18dfde4*/ System.Net.IPEndPoint get_LocalEndPoint();
            /*0x18dfe04*/ System.Version get_ProtocolVersion();
            /*0x18dfe0c*/ System.Collections.Specialized.NameValueCollection get_QueryString();
            /*0x18dfea0*/ string get_RawUrl();
            /*0x18dfac0*/ System.Net.IPEndPoint get_RemoteEndPoint();
            /*0x18dfebc*/ System.Guid get_RequestTraceIdentifier();
            /*0x18dbe7c*/ System.Uri get_Url();
            /*0x18dfec8*/ System.Uri get_UrlReferrer();
            /*0x18dfed0*/ string get_UserAgent();
            /*0x18dff24*/ string get_UserHostAddress();
            /*0x18dff44*/ string get_UserHostName();
            /*0x18dff98*/ string[] get_UserLanguages();
            /*0x18dc5b0*/ void AddHeader(string header);
            /*0x18dba5c*/ void FinishInitialization();
            /*0x18dcda4*/ bool FlushInput();
            /*0x18dc3b8*/ void SetRequestLine(string requestLine);
            /*0x18e0090*/ System.IAsyncResult BeginGetClientCertificate(System.AsyncCallback requestCallback, object state);
            /*0x18e00d0*/ System.Security.Cryptography.X509Certificates.X509Certificate2 EndGetClientCertificate(System.IAsyncResult asyncResult);
            /*0x18e0110*/ System.Security.Cryptography.X509Certificates.X509Certificate2 GetClientCertificate();
            /*0x18e0150*/ string ToString();
        }

        class HttpListenerResponse : System.IDisposable
        {
            /*0x10*/ bool _closeConnection;
            /*0x18*/ System.Text.Encoding _contentEncoding;
            /*0x20*/ long _contentLength;
            /*0x28*/ string _contentType;
            /*0x30*/ WebSocketSharp.Net.HttpListenerContext _context;
            /*0x38*/ WebSocketSharp.Net.CookieCollection _cookies;
            /*0x40*/ bool _disposed;
            /*0x48*/ WebSocketSharp.Net.WebHeaderCollection _headers;
            /*0x50*/ bool _headersSent;
            /*0x51*/ bool _keepAlive;
            /*0x58*/ string _location;
            /*0x60*/ WebSocketSharp.Net.ResponseStream _outputStream;
            /*0x68*/ bool _sendChunked;
            /*0x6c*/ int _statusCode;
            /*0x70*/ string _statusDescription;
            /*0x78*/ System.Version _version;

            /*0x17a8f88*/ HttpListenerResponse(WebSocketSharp.Net.HttpListenerContext context);
            /*0x17a9030*/ bool get_CloseConnection();
            /*0x17a9038*/ void set_CloseConnection(bool value);
            /*0x17a9044*/ bool get_HeadersSent();
            /*0x17a904c*/ void set_HeadersSent(bool value);
            /*0x17a9058*/ System.Text.Encoding get_ContentEncoding();
            /*0x17a9060*/ void set_ContentEncoding(System.Text.Encoding value);
            /*0x17a9104*/ long get_ContentLength64();
            /*0x17a910c*/ void set_ContentLength64(long value);
            /*0x17a9268*/ string get_ContentType();
            /*0x17a9270*/ void set_ContentType(string value);
            /*0x17a9300*/ WebSocketSharp.Net.CookieCollection get_Cookies();
            /*0x17a936c*/ void set_Cookies(WebSocketSharp.Net.CookieCollection value);
            /*0x17a9374*/ WebSocketSharp.Net.WebHeaderCollection get_Headers();
            /*0x17a941c*/ void set_Headers(WebSocketSharp.Net.WebHeaderCollection value);
            /*0x17a9490*/ bool get_KeepAlive();
            /*0x17a9498*/ void set_KeepAlive(bool value);
            /*0x17a94bc*/ System.IO.Stream get_OutputStream();
            /*0x17a94fc*/ System.Version get_ProtocolVersion();
            /*0x17a9504*/ void set_ProtocolVersion(System.Version value);
            /*0x17a95f4*/ string get_RedirectLocation();
            /*0x17a95fc*/ void set_RedirectLocation(string value);
            /*0x17a971c*/ bool get_SendChunked();
            /*0x17a9724*/ void set_SendChunked(bool value);
            /*0x17a9748*/ int get_StatusCode();
            /*0x17a9750*/ void set_StatusCode(int value);
            /*0x17a9818*/ string get_StatusDescription();
            /*0x17a9820*/ void set_StatusDescription(string value);
            /*0x17a9980*/ bool canAddOrUpdate(WebSocketSharp.Net.Cookie cookie);
            /*0x17a9084*/ void checkDisposed();
            /*0x17a9194*/ void checkDisposedOrHeadersSent();
            /*0x17a9bec*/ void close(bool force);
            /*0x17a9b7c*/ System.Collections.Generic.IEnumerable<WebSocketSharp.Net.Cookie> findCookie(WebSocketSharp.Net.Cookie cookie);
            /*0x17a9c6c*/ WebSocketSharp.Net.WebHeaderCollection WriteHeadersTo(System.IO.MemoryStream destination);
            /*0x17aa714*/ void Abort();
            /*0x17aa728*/ void AddHeader(string name, string value);
            /*0x17aa764*/ void AppendCookie(WebSocketSharp.Net.Cookie cookie);
            /*0x17aa788*/ void AppendHeader(string name, string value);
            /*0x17aa7c4*/ void Close();
            /*0x17aa7d8*/ void Close(byte[] responseEntity, bool willBlock);
            /*0x17aa978*/ void CopyFrom(WebSocketSharp.Net.HttpListenerResponse templateResponse);
            /*0x17aaa4c*/ void Redirect(string url);
            /*0x17aabc8*/ void SetCookie(WebSocketSharp.Net.Cookie cookie);
            /*0x17aaca0*/ void System.IDisposable.Dispose();

            class <findCookie>d__62 : System.Collections.Generic.IEnumerable<WebSocketSharp.Net.Cookie>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<WebSocketSharp.Net.Cookie>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ WebSocketSharp.Net.Cookie <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ WebSocketSharp.Net.Cookie cookie;
                /*0x30*/ WebSocketSharp.Net.Cookie <>3__cookie;
                /*0x38*/ WebSocketSharp.Net.HttpListenerResponse <>4__this;
                /*0x40*/ string <name>5__1;
                /*0x48*/ string <domain>5__2;
                /*0x50*/ string <path>5__3;
                /*0x58*/ System.Collections.IEnumerator <>s__4;
                /*0x60*/ WebSocketSharp.Net.Cookie <c>5__5;

                /*0x17a9c28*/ <findCookie>d__62(int <>1__state);
                /*0x17aacb4*/ void System.IDisposable.Dispose();
                /*0x17aacd0*/ bool MoveNext();
                /*0x17ab090*/ void <>m__Finally1();
                /*0x17ab14c*/ WebSocketSharp.Net.Cookie System.Collections.Generic.IEnumerator<WebSocketSharp.Net.Cookie>.get_Current();
                /*0x17ab154*/ void System.Collections.IEnumerator.Reset();
                /*0x17ab194*/ object System.Collections.IEnumerator.get_Current();
                /*0x17ab19c*/ System.Collections.Generic.IEnumerator<WebSocketSharp.Net.Cookie> System.Collections.Generic.IEnumerable<WebSocketSharp.Net.Cookie>.GetEnumerator();
                /*0x17ab244*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <>c__DisplayClass69_0
            {
                /*0x10*/ System.IO.Stream output;
                /*0x18*/ WebSocketSharp.Net.HttpListenerResponse <>4__this;

                /*0x17aa970*/ <>c__DisplayClass69_0();
                /*0x17ab248*/ void <Close>b__0(System.IAsyncResult ar);
            }
        }

        class HttpStreamAsyncResult : System.IAsyncResult
        {
            /*0x10*/ byte[] _buffer;
            /*0x18*/ System.AsyncCallback _callback;
            /*0x20*/ bool _completed;
            /*0x24*/ int _count;
            /*0x28*/ System.Exception _exception;
            /*0x30*/ int _offset;
            /*0x38*/ object _state;
            /*0x40*/ object _sync;
            /*0x48*/ int _syncRead;
            /*0x50*/ System.Threading.ManualResetEvent _waitHandle;

            /*0x17ab280*/ HttpStreamAsyncResult(System.AsyncCallback callback, object state);
            /*0x17ab304*/ byte[] get_Buffer();
            /*0x17ab30c*/ void set_Buffer(byte[] value);
            /*0x17ab314*/ int get_Count();
            /*0x17ab31c*/ void set_Count(int value);
            /*0x17ab324*/ System.Exception get_Exception();
            /*0x17ab32c*/ bool get_HasException();
            /*0x17ab33c*/ int get_Offset();
            /*0x17ab344*/ void set_Offset(int value);
            /*0x17ab34c*/ int get_SyncRead();
            /*0x17ab354*/ void set_SyncRead(int value);
            /*0x17ab35c*/ object get_AsyncState();
            /*0x17ab364*/ System.Threading.WaitHandle get_AsyncWaitHandle();
            /*0x17ab46c*/ bool get_CompletedSynchronously();
            /*0x17ab480*/ bool get_IsCompleted();
            /*0x17ab4bc*/ void Complete();
            /*0x17ab614*/ void Complete(System.Exception exception);
            /*0x17ab61c*/ void <Complete>b__35_0(System.IAsyncResult ar);
        }

        class HttpUtility
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<string, char> _entities;
            static /*0x8*/ char[] _hexChars;
            static /*0x10*/ object _sync;

            static /*0x17b3250*/ HttpUtility();
            static /*0x17ab638*/ int getChar(byte[] bytes, int offset, int length);
            static /*0x17ab78c*/ int getChar(string s, int offset, int length);
            static /*0x17ab8a0*/ char[] getChars(System.IO.MemoryStream buffer, System.Text.Encoding encoding);
            static /*0x17ab908*/ System.Collections.Generic.Dictionary<string, char> getEntities();
            static /*0x17ab73c*/ int getInt(byte b);
            static /*0x17aba3c*/ void initEntities();
            static /*0x17aee18*/ bool notEncoded(char c);
            static /*0x17aee5c*/ void urlEncode(char c, System.IO.Stream result, bool unicode);
            static /*0x17af144*/ void urlPathEncode(char c, System.IO.Stream result);
            static /*0x17af2f0*/ void writeCharBytes(char c, System.Collections.IList buffer, System.Text.Encoding encoding);
            static /*0x17af4ec*/ System.Uri CreateRequestUrl(string requestUri, string host, bool websocketRequest, bool secure);
            static /*0x17af844*/ System.Security.Principal.IPrincipal CreateUser(string response, WebSocketSharp.Net.AuthenticationSchemes scheme, string realm, string method, System.Func<System.Security.Principal.IIdentity, WebSocketSharp.Net.NetworkCredential> credentialsFinder);
            static /*0x17b0134*/ System.Text.Encoding GetEncoding(string contentType);
            static /*0x17b027c*/ System.Collections.Specialized.NameValueCollection InternalParseQueryString(string query, System.Text.Encoding encoding);
            static /*0x17b0854*/ string InternalUrlDecode(byte[] bytes, int offset, int count, System.Text.Encoding encoding);
            static /*0x17b0d44*/ byte[] InternalUrlDecodeToBytes(byte[] bytes, int offset, int count);
            static /*0x17b0fdc*/ byte[] InternalUrlEncodeToBytes(byte[] bytes, int offset, int count);
            static /*0x17b1230*/ byte[] InternalUrlEncodeUnicodeToBytes(string s);
            static /*0x17b1468*/ string HtmlAttributeEncode(string s);
            static /*0x17b166c*/ void HtmlAttributeEncode(string s, System.IO.TextWriter output);
            static /*0x17b172c*/ string HtmlDecode(string s);
            static /*0x17b1cfc*/ void HtmlDecode(string s, System.IO.TextWriter output);
            static /*0x17b1dbc*/ string HtmlEncode(string s);
            static /*0x17b204c*/ void HtmlEncode(string s, System.IO.TextWriter output);
            static /*0x17b210c*/ System.Collections.Specialized.NameValueCollection ParseQueryString(string query);
            static /*0x17b2174*/ System.Collections.Specialized.NameValueCollection ParseQueryString(string query, System.Text.Encoding encoding);
            static /*0x17b2230*/ string UrlDecode(string s);
            static /*0x17b0534*/ string UrlDecode(string s, System.Text.Encoding encoding);
            static /*0x17b2298*/ string UrlDecode(byte[] bytes, System.Text.Encoding encoding);
            static /*0x17b2358*/ string UrlDecode(byte[] bytes, int offset, int count, System.Text.Encoding encoding);
            static /*0x17b24ac*/ byte[] UrlDecodeToBytes(byte[] bytes);
            static /*0x17b2528*/ byte[] UrlDecodeToBytes(string s);
            static /*0x17b2590*/ byte[] UrlDecodeToBytes(string s, System.Text.Encoding encoding);
            static /*0x17b266c*/ byte[] UrlDecodeToBytes(byte[] bytes, int offset, int count);
            static /*0x17b27b0*/ string UrlEncode(byte[] bytes);
            static /*0x17b287c*/ string UrlEncode(string s);
            static /*0x17b28e4*/ string UrlEncode(string s, System.Text.Encoding encoding);
            static /*0x17b2ad0*/ string UrlEncode(byte[] bytes, int offset, int count);
            static /*0x17b2ce4*/ byte[] UrlEncodeToBytes(byte[] bytes);
            static /*0x17b2d60*/ byte[] UrlEncodeToBytes(string s);
            static /*0x17b2dc8*/ byte[] UrlEncodeToBytes(string s, System.Text.Encoding encoding);
            static /*0x17b2ba0*/ byte[] UrlEncodeToBytes(byte[] bytes, int offset, int count);
            static /*0x17b2ea4*/ string UrlEncodeUnicode(string s);
            static /*0x17b2f48*/ byte[] UrlEncodeUnicodeToBytes(string s);
            static /*0x17b2fe0*/ string UrlPathEncode(string s);
            /*0x17b3248*/ HttpUtility();
        }

        class RequestStream : System.IO.Stream
        {
            /*0x28*/ long _bodyLeft;
            /*0x30*/ byte[] _buffer;
            /*0x38*/ int _count;
            /*0x3c*/ bool _disposed;
            /*0x40*/ int _offset;
            /*0x48*/ System.IO.Stream _stream;

            /*0x17b32f8*/ RequestStream(System.IO.Stream stream, byte[] buffer, int offset, int count);
            /*0x17b3300*/ RequestStream(System.IO.Stream stream, byte[] buffer, int offset, int count, long contentLength);
            /*0x17b3398*/ bool get_CanRead();
            /*0x17b33a0*/ bool get_CanSeek();
            /*0x17b33a8*/ bool get_CanWrite();
            /*0x17b33b0*/ long get_Length();
            /*0x17b33f0*/ long get_Position();
            /*0x17b3430*/ void set_Position(long value);
            /*0x17b3470*/ int fillFromBuffer(byte[] buffer, int offset, int count);
            /*0x17b361c*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state);
            /*0x17b37a4*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state);
            /*0x17b37e4*/ void Close();
            /*0x17b37f0*/ int EndRead(System.IAsyncResult asyncResult);
            /*0x17b39a0*/ void EndWrite(System.IAsyncResult asyncResult);
            /*0x17b39e0*/ void Flush();
            /*0x17b39e4*/ int Read(byte[] buffer, int offset, int count);
            /*0x17b3ae4*/ long Seek(long offset, System.IO.SeekOrigin origin);
            /*0x17b3b24*/ void SetLength(long value);
            /*0x17b3b64*/ void Write(byte[] buffer, int offset, int count);
        }

        class ResponseStream : System.IO.Stream
        {
            static /*0x0*/ byte[] _crlf;
            /*0x28*/ System.IO.MemoryStream _body;
            /*0x30*/ bool _disposed;
            /*0x38*/ WebSocketSharp.Net.HttpListenerResponse _response;
            /*0x40*/ bool _sendChunked;
            /*0x48*/ System.IO.Stream _stream;
            /*0x50*/ System.Action<System.Byte[], int, int> _write;
            /*0x58*/ System.Action<System.Byte[], int, int> _writeBody;
            /*0x60*/ System.Action<System.Byte[], int, int> _writeChunked;

            static /*0x17b4cc0*/ ResponseStream();
            static /*0x17b4544*/ byte[] getChunkSizeBytes(int size, bool final);
            /*0x17b3ba4*/ ResponseStream(System.IO.Stream stream, WebSocketSharp.Net.HttpListenerResponse response, bool ignoreWriteExceptions);
            /*0x17b3d2c*/ bool get_CanRead();
            /*0x17b3d34*/ bool get_CanSeek();
            /*0x17b3d3c*/ bool get_CanWrite();
            /*0x17b3d4c*/ long get_Length();
            /*0x17b3d8c*/ long get_Position();
            /*0x17b3dcc*/ void set_Position(long value);
            /*0x17b3e0c*/ bool flush(bool closing);
            /*0x17b4234*/ void flushBody(bool closing);
            /*0x17b3f20*/ bool flushHeaders(bool closing);
            /*0x17b4638*/ void writeChunked(byte[] buffer, int offset, int count);
            /*0x17b4728*/ void writeChunkedWithoutThrowingException(byte[] buffer, int offset, int count);
            /*0x17b47a8*/ void writeWithoutThrowingException(byte[] buffer, int offset, int count);
            /*0x17b4840*/ void Close(bool force);
            /*0x17b4944*/ void InternalWrite(byte[] buffer, int offset, int count);
            /*0x17b4968*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state);
            /*0x17b49a8*/ System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state);
            /*0x17b4a40*/ void Close();
            /*0x17b4a48*/ void Dispose(bool disposing);
            /*0x17b4a54*/ int EndRead(System.IAsyncResult asyncResult);
            /*0x17b4a94*/ void EndWrite(System.IAsyncResult asyncResult);
            /*0x17b4b2c*/ void Flush();
            /*0x17b4b68*/ int Read(byte[] buffer, int offset, int count);
            /*0x17b4ba8*/ long Seek(long offset, System.IO.SeekOrigin origin);
            /*0x17b4be8*/ void SetLength(long value);
            /*0x17b4c28*/ void Write(byte[] buffer, int offset, int count);
        }

        class WebHeaderCollection : System.Collections.Specialized.NameValueCollection, System.Runtime.Serialization.ISerializable
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<string, WebSocketSharp.Net.HttpHeaderInfo> _headers;
            /*0x68*/ bool _internallyUsed;
            /*0x6c*/ WebSocketSharp.Net.HttpHeaderType _state;

            static /*0x17b4d54*/ WebHeaderCollection();
            static /*0x17b7080*/ int checkColonSeparated(string header);
            static /*0x17b7110*/ WebSocketSharp.Net.HttpHeaderType checkHeaderType(string name);
            static /*0x17b6b74*/ string checkName(string name);
            static /*0x17b6f24*/ string checkValue(string value);
            static /*0x17b75f4*/ string convert(string key);
            static /*0x17b7180*/ WebSocketSharp.Net.HttpHeaderInfo getHeaderInfo(string name);
            static /*0x17b747c*/ bool isRestricted(string name, bool response);
            static /*0x17b6724*/ string Convert(WebSocketSharp.Net.HttpRequestHeader header);
            static /*0x17b690c*/ string Convert(WebSocketSharp.Net.HttpResponseHeader header);
            static /*0x17b734c*/ bool IsHeaderName(string name);
            static /*0x17b759c*/ bool IsHeaderValue(string value);
            static /*0x17b78e0*/ bool IsMultiValue(string headerName, bool response);
            static /*0x17b7d24*/ bool IsRestricted(string headerName);
            static /*0x17b7d80*/ bool IsRestricted(string headerName, bool response);
            /*0x17a93ec*/ WebHeaderCollection(WebSocketSharp.Net.HttpHeaderType state, bool internallyUsed);
            /*0x17b640c*/ WebHeaderCollection(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x17b6694*/ WebHeaderCollection();
            /*0x17a9488*/ WebSocketSharp.Net.HttpHeaderType get_State();
            /*0x17b669c*/ string[] get_AllKeys();
            /*0x17b66a4*/ int get_Count();
            /*0x17b66ac*/ string get_Item(WebSocketSharp.Net.HttpRequestHeader header);
            /*0x17b67c4*/ void set_Item(WebSocketSharp.Net.HttpRequestHeader header, string value);
            /*0x17b6894*/ string get_Item(WebSocketSharp.Net.HttpResponseHeader header);
            /*0x17b69ac*/ void set_Item(WebSocketSharp.Net.HttpResponseHeader header, string value);
            /*0x17b6a7c*/ System.Collections.Specialized.NameObjectCollectionBase.KeysCollection get_Keys();
            /*0x17b6a84*/ void add(string name, string value, bool ignoreRestricted);
            /*0x17b6d78*/ void addWithoutCheckingName(string name, string value);
            /*0x17b6eac*/ void addWithoutCheckingNameAndRestricted(string name, string value);
            /*0x17b73c4*/ void checkRestricted(string name);
            /*0x17b7504*/ void checkState(bool response);
            /*0x17b6c8c*/ void doWithCheckingState(System.Action<string, string> action, string name, string value, bool setState);
            /*0x17b76c4*/ void doWithCheckingState(System.Action<string, string> action, string name, string value, bool response, bool setState);
            /*0x17b6e10*/ void doWithoutCheckingName(System.Action<string, string> action, string name, string value);
            /*0x17b7768*/ void removeWithoutCheckingName(string name, string unuse);
            /*0x17b7794*/ void setWithoutCheckingName(string name, string value);
            /*0x17b782c*/ void InternalRemove(string name);
            /*0x17b7834*/ void InternalSet(string header, bool response);
            /*0x17aa4e8*/ void InternalSet(string name, string value, bool response);
            /*0x17aa5a4*/ string ToStringMultiValue(bool response);
            /*0x17b79b8*/ void AddWithoutValidate(string headerName, string headerValue);
            /*0x17b79c0*/ void Add(string header);
            /*0x17b67c8*/ void Add(WebSocketSharp.Net.HttpRequestHeader header, string value);
            /*0x17b69b0*/ void Add(WebSocketSharp.Net.HttpResponseHeader header, string value);
            /*0x17b7ab8*/ void Add(string name, string value);
            /*0x17b7ac0*/ void Clear();
            /*0x17b7adc*/ string Get(int index);
            /*0x17b7ae4*/ string Get(string name);
            /*0x17b7aec*/ System.Collections.IEnumerator GetEnumerator();
            /*0x17b7af4*/ string GetKey(int index);
            /*0x17b7afc*/ string[] GetValues(int index);
            /*0x17b7b20*/ string[] GetValues(string header);
            /*0x17b7b44*/ void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);
            /*0x17b7de8*/ void OnDeserialization(object sender);
            /*0x17b7dec*/ void Remove(WebSocketSharp.Net.HttpRequestHeader header);
            /*0x17b7eb4*/ void Remove(WebSocketSharp.Net.HttpResponseHeader header);
            /*0x17b7f7c*/ void Remove(string name);
            /*0x17b8040*/ void Set(WebSocketSharp.Net.HttpRequestHeader header, string value);
            /*0x17b810c*/ void Set(WebSocketSharp.Net.HttpResponseHeader header, string value);
            /*0x17b81d8*/ void Set(string name, string value);
            /*0x17b82a0*/ byte[] ToByteArray();
            /*0x17b82f0*/ string ToString();
            /*0x17b845c*/ void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext);

            class <>c__DisplayClass46_0
            {
                /*0x10*/ bool response;
                /*0x18*/ System.Text.StringBuilder buff;
                /*0x20*/ WebSocketSharp.Net.WebHeaderCollection <>4__this;

                /*0x17b79b0*/ <>c__DisplayClass46_0();
                /*0x17b8468*/ void <ToStringMultiValue>b__0(int i);
            }

            class <>c__DisplayClass59_0
            {
                /*0x10*/ System.Runtime.Serialization.SerializationInfo serializationInfo;
                /*0x18*/ int cnt;
                /*0x20*/ WebSocketSharp.Net.WebHeaderCollection <>4__this;

                /*0x17b7d1c*/ <>c__DisplayClass59_0();
                /*0x17b85e0*/ void <GetObjectData>b__0(int i);
            }

            class <>c__DisplayClass70_0
            {
                /*0x10*/ System.Text.StringBuilder buff;
                /*0x18*/ WebSocketSharp.Net.WebHeaderCollection <>4__this;

                /*0x17b8454*/ <>c__DisplayClass70_0();
                /*0x17b86b0*/ void <ToString>b__0(int i);
            }
        }

        class HttpVersion
        {
            static /*0x0*/ System.Version Version10;
            static /*0x8*/ System.Version Version11;

            static /*0x17b875c*/ HttpVersion();
            /*0x17b8754*/ HttpVersion();
        }

        enum HttpStatusCode
        {
            Continue = 100,
            SwitchingProtocols = 101,
            OK = 200,
            Created = 201,
            Accepted = 202,
            NonAuthoritativeInformation = 203,
            NoContent = 204,
            ResetContent = 205,
            PartialContent = 206,
            MultipleChoices = 300,
            Ambiguous = 300,
            MovedPermanently = 301,
            Moved = 301,
            Found = 302,
            Redirect = 302,
            SeeOther = 303,
            RedirectMethod = 303,
            NotModified = 304,
            UseProxy = 305,
            Unused = 306,
            TemporaryRedirect = 307,
            RedirectKeepVerb = 307,
            BadRequest = 400,
            Unauthorized = 401,
            PaymentRequired = 402,
            Forbidden = 403,
            NotFound = 404,
            MethodNotAllowed = 405,
            NotAcceptable = 406,
            ProxyAuthenticationRequired = 407,
            RequestTimeout = 408,
            Conflict = 409,
            Gone = 410,
            LengthRequired = 411,
            PreconditionFailed = 412,
            RequestEntityTooLarge = 413,
            RequestUriTooLong = 414,
            UnsupportedMediaType = 415,
            RequestedRangeNotSatisfiable = 416,
            ExpectationFailed = 417,
            InternalServerError = 500,
            NotImplemented = 501,
            BadGateway = 502,
            ServiceUnavailable = 503,
            GatewayTimeout = 504,
            HttpVersionNotSupported = 505,
        }

        enum HttpHeaderType
        {
            Unspecified = 0,
            Request = 1,
            Response = 2,
            Restricted = 4,
            MultiValue = 8,
            MultiValueInRequest = 16,
            MultiValueInResponse = 32,
        }

        class HttpHeaderInfo
        {
            /*0x10*/ string _name;
            /*0x18*/ WebSocketSharp.Net.HttpHeaderType _type;

            /*0x17b63dc*/ HttpHeaderInfo(string name, WebSocketSharp.Net.HttpHeaderType type);
            /*0x17b8808*/ bool get_IsMultiValueInRequest();
            /*0x17b8814*/ bool get_IsMultiValueInResponse();
            /*0x17b7334*/ bool get_IsRequest();
            /*0x17b7340*/ bool get_IsResponse();
            /*0x17b76bc*/ string get_Name();
            /*0x17b8820*/ WebSocketSharp.Net.HttpHeaderType get_Type();
            /*0x17b7980*/ bool IsMultiValue(bool response);
            /*0x17b7744*/ bool IsRestricted(bool response);
        }

        class HttpBasicIdentity : System.Security.Principal.GenericIdentity
        {
            /*0x88*/ string _password;

            /*0x17b8828*/ HttpBasicIdentity(string username, string password);
            /*0x17b8890*/ string get_Password();
        }

        class HttpDigestIdentity : System.Security.Principal.GenericIdentity
        {
            /*0x88*/ System.Collections.Specialized.NameValueCollection _parameters;

            /*0x17b8898*/ HttpDigestIdentity(System.Collections.Specialized.NameValueCollection parameters);
            /*0x17b8920*/ string get_Algorithm();
            /*0x17b8974*/ string get_Cnonce();
            /*0x17b89c8*/ string get_Nc();
            /*0x17b8a1c*/ string get_Nonce();
            /*0x17b8a70*/ string get_Opaque();
            /*0x17b8ac4*/ string get_Qop();
            /*0x17b8b18*/ string get_Realm();
            /*0x17b8b6c*/ string get_Response();
            /*0x17b8bc0*/ string get_Uri();
            /*0x17aff5c*/ bool IsValid(string password, string realm, string method, string entity);
        }

        class NetworkCredential
        {
            static /*0x0*/ string[] _noRoles;
            /*0x10*/ string _domain;
            /*0x18*/ string _password;
            /*0x20*/ string[] _roles;
            /*0x28*/ string _username;

            static /*0x17b9074*/ NetworkCredential();
            /*0x17b90dc*/ NetworkCredential(string username, string password);
            /*0x17b90e8*/ NetworkCredential(string username, string password, string domain, string[] roles);
            /*0x17b91cc*/ string get_Domain();
            /*0x17b9220*/ void set_Domain(string value);
            /*0x17aff08*/ string get_Password();
            /*0x17b9228*/ void set_Password(string value);
            /*0x17b00d0*/ string[] get_Roles();
            /*0x17b9230*/ void set_Roles(string[] value);
            /*0x17b9238*/ string get_Username();
            /*0x17b9240*/ void set_Username(string value);
        }

        enum InputState
        {
            RequestLine = 0,
            Headers = 1,
        }

        enum LineState
        {
            None = 0,
            Cr = 1,
            Lf = 2,
        }

        class ReadBufferState
        {
            /*0x10*/ WebSocketSharp.Net.HttpStreamAsyncResult _asyncResult;
            /*0x18*/ byte[] _buffer;
            /*0x20*/ int _count;
            /*0x24*/ int _initialCount;
            /*0x28*/ int _offset;

            /*0x17b9248*/ ReadBufferState(byte[] buffer, int offset, int count, WebSocketSharp.Net.HttpStreamAsyncResult asyncResult);
            /*0x17b928c*/ WebSocketSharp.Net.HttpStreamAsyncResult get_AsyncResult();
            /*0x17b9294*/ void set_AsyncResult(WebSocketSharp.Net.HttpStreamAsyncResult value);
            /*0x17b929c*/ byte[] get_Buffer();
            /*0x17b92a4*/ void set_Buffer(byte[] value);
            /*0x17b92ac*/ int get_Count();
            /*0x17b92b4*/ void set_Count(int value);
            /*0x17b92bc*/ int get_InitialCount();
            /*0x17b92c4*/ void set_InitialCount(int value);
            /*0x17b92cc*/ int get_Offset();
            /*0x17b92d4*/ void set_Offset(int value);
        }

        class Chunk
        {
            /*0x10*/ byte[] _data;
            /*0x18*/ int _offset;

            /*0x17b92dc*/ Chunk(byte[] data);
            /*0x17b9304*/ int get_ReadLeft();
            /*0x17b9328*/ int Read(byte[] buffer, int offset, int count);
        }

        enum InputChunkState
        {
            None = 0,
            Data = 1,
            DataEnded = 2,
            Trailer = 3,
            End = 4,
        }

        class ChunkedRequestStream : WebSocketSharp.Net.RequestStream
        {
            static int _bufferLength = 8192;
            /*0x50*/ WebSocketSharp.Net.HttpListenerContext _context;
            /*0x58*/ WebSocketSharp.Net.ChunkStream _decoder;
            /*0x60*/ bool _disposed;
            /*0x61*/ bool _noMoreData;

            /*0x17b9394*/ ChunkedRequestStream(System.IO.Stream stream, byte[] buffer, int offset, int count, WebSocketSharp.Net.HttpListenerContext context);
            /*0x17b94b0*/ WebSocketSharp.Net.ChunkStream get_Decoder();
            /*0x17b94b8*/ void set_Decoder(WebSocketSharp.Net.ChunkStream value);
            /*0x17b94c0*/ void onRead(System.IAsyncResult asyncResult);
            /*0x17b9874*/ System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state);
            /*0x17b9bc0*/ void Close();
            /*0x17b9bdc*/ int EndRead(System.IAsyncResult asyncResult);
            /*0x17b9de0*/ int Read(byte[] buffer, int offset, int count);
        }

        class QueryStringCollection : System.Collections.Specialized.NameValueCollection
        {
            /*0x17b052c*/ QueryStringCollection();
            /*0x17b9e1c*/ string ToString();
        }

        class AuthenticationChallenge : WebSocketSharp.Net.AuthenticationBase
        {
            static /*0x17ba374*/ WebSocketSharp.Net.AuthenticationChallenge CreateBasicChallenge(string realm);
            static /*0x17ba3d8*/ WebSocketSharp.Net.AuthenticationChallenge CreateDigestChallenge(string realm);
            static /*0x17ba43c*/ WebSocketSharp.Net.AuthenticationChallenge Parse(string value);
            /*0x17b9fa0*/ AuthenticationChallenge(WebSocketSharp.Net.AuthenticationSchemes scheme, System.Collections.Specialized.NameValueCollection parameters);
            /*0x17ba000*/ AuthenticationChallenge(WebSocketSharp.Net.AuthenticationSchemes scheme, string realm);
            /*0x17ba2cc*/ string get_Domain();
            /*0x17ba320*/ string get_Stale();
            /*0x17baaf4*/ string ToBasicString();
            /*0x17bab70*/ string ToDigestString();
        }

        class AuthenticationResponse : WebSocketSharp.Net.AuthenticationBase
        {
            /*0x20*/ uint _nonceCount;

            static /*0x17bb5a4*/ string createA1(string username, string password, string realm);
            static /*0x17bb608*/ string createA1(string username, string password, string realm, string nonce, string cnonce);
            static /*0x17bb7d0*/ string createA2(string method, string uri);
            static /*0x17bb82c*/ string createA2(string method, string uri, string entity);
            static /*0x17bb694*/ string hash(string value);
            static /*0x17b8c14*/ string CreateRequestDigest(System.Collections.Specialized.NameValueCollection parameters);
            static /*0x17afba8*/ WebSocketSharp.Net.AuthenticationResponse Parse(string value);
            static /*0x17bb89c*/ System.Collections.Specialized.NameValueCollection ParseBasicCredentials(string value);
            /*0x17bae20*/ AuthenticationResponse(WebSocketSharp.Net.AuthenticationSchemes scheme, System.Collections.Specialized.NameValueCollection parameters);
            /*0x17bae50*/ AuthenticationResponse(WebSocketSharp.Net.NetworkCredential credentials);
            /*0x17bb04c*/ AuthenticationResponse(WebSocketSharp.Net.AuthenticationChallenge challenge, WebSocketSharp.Net.NetworkCredential credentials, uint nonceCount);
            /*0x17baecc*/ AuthenticationResponse(WebSocketSharp.Net.AuthenticationSchemes scheme, System.Collections.Specialized.NameValueCollection parameters, WebSocketSharp.Net.NetworkCredential credentials, uint nonceCount);
            /*0x17bb39c*/ uint get_NonceCount();
            /*0x17bb3ac*/ string get_Cnonce();
            /*0x17bb400*/ string get_Nc();
            /*0x17bb454*/ string get_Password();
            /*0x17bb4a8*/ string get_Response();
            /*0x17bb4fc*/ string get_Uri();
            /*0x17bb550*/ string get_UserName();
            /*0x17bb07c*/ void initAsDigest();
            /*0x17bba58*/ string ToBasicString();
            /*0x17bbb8c*/ string ToDigestString();
            /*0x17afdf4*/ System.Security.Principal.IIdentity ToIdentity();

            class <>c
            {
                static /*0x0*/ WebSocketSharp.Net.AuthenticationResponse.<> <>9;
                static /*0x8*/ System.Func<string, bool> <>9__24_0;

                static /*0x17bbf64*/ <>c();
                /*0x17bbfc8*/ <>c();
                /*0x17bbfd0*/ bool <initAsDigest>b__24_0(string qop);
            }
        }

        class AuthenticationBase
        {
            /*0x10*/ WebSocketSharp.Net.AuthenticationSchemes _scheme;
            /*0x18*/ System.Collections.Specialized.NameValueCollection Parameters;

            static /*0x17ba170*/ string CreateNonceValue();
            static /*0x17ba5d0*/ System.Collections.Specialized.NameValueCollection ParseParameters(string value);
            /*0x17b9fd0*/ AuthenticationBase(WebSocketSharp.Net.AuthenticationSchemes scheme, System.Collections.Specialized.NameValueCollection parameters);
            /*0x17bc038*/ string get_Algorithm();
            /*0x17bc08c*/ string get_Nonce();
            /*0x17bc0e0*/ string get_Opaque();
            /*0x17bc134*/ string get_Qop();
            /*0x17bc188*/ string get_Realm();
            /*0x17bb074*/ WebSocketSharp.Net.AuthenticationSchemes get_Scheme();
            string ToBasicString();
            string ToDigestString();
            /*0x17bc1dc*/ string ToString();
        }

        class HttpListenerPrefix
        {
            /*0x10*/ string _host;
            /*0x18*/ WebSocketSharp.Net.HttpListener _listener;
            /*0x20*/ string _original;
            /*0x28*/ string _path;
            /*0x30*/ string _port;
            /*0x38*/ string _prefix;
            /*0x40*/ bool _secure;

            static /*0x17bc5a4*/ void CheckPrefix(string uriPrefix);
            /*0x17bc260*/ HttpListenerPrefix(string uriPrefix);
            /*0x17bc56c*/ string get_Host();
            /*0x17bc574*/ bool get_IsSecure();
            /*0x17bc57c*/ WebSocketSharp.Net.HttpListener get_Listener();
            /*0x17bc584*/ void set_Listener(WebSocketSharp.Net.HttpListener value);
            /*0x17bc58c*/ string get_Original();
            /*0x17bc594*/ string get_Path();
            /*0x17bc59c*/ string get_Port();
            /*0x17bc290*/ void parse(string uriPrefix);
            /*0x17bc828*/ bool Equals(object obj);
            /*0x17bc8a8*/ int GetHashCode();
            /*0x17bc8c8*/ string ToString();
        }

        class ClientSslConfiguration
        {
            /*0x10*/ bool _checkCertRevocation;
            /*0x18*/ System.Net.Security.LocalCertificateSelectionCallback _clientCertSelectionCallback;
            /*0x20*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection _clientCerts;
            /*0x28*/ System.Security.Authentication.SslProtocols _enabledSslProtocols;
            /*0x30*/ System.Net.Security.RemoteCertificateValidationCallback _serverCertValidationCallback;
            /*0x38*/ string _targetHost;

            static /*0x16f871c*/ System.Security.Cryptography.X509Certificates.X509Certificate defaultSelectClientCertificate(object sender, string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, string[] acceptableIssuers);
            static /*0x16f8724*/ bool defaultValidateServerCertificate(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors);
            /*0x16f84d4*/ ClientSslConfiguration();
            /*0x16f84f4*/ ClientSslConfiguration(string targetHost);
            /*0x16f8524*/ ClientSslConfiguration(WebSocketSharp.Net.ClientSslConfiguration configuration);
            /*0x16f85b8*/ bool get_CheckCertificateRevocation();
            /*0x16f85c0*/ void set_CheckCertificateRevocation(bool value);
            /*0x16f85cc*/ System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates();
            /*0x16f85d4*/ void set_ClientCertificates(System.Security.Cryptography.X509Certificates.X509CertificateCollection value);
            /*0x16f85dc*/ System.Net.Security.LocalCertificateSelectionCallback get_ClientCertificateSelectionCallback();
            /*0x16f8664*/ void set_ClientCertificateSelectionCallback(System.Net.Security.LocalCertificateSelectionCallback value);
            /*0x16f866c*/ System.Security.Authentication.SslProtocols get_EnabledSslProtocols();
            /*0x16f8674*/ void set_EnabledSslProtocols(System.Security.Authentication.SslProtocols value);
            /*0x16f867c*/ System.Net.Security.RemoteCertificateValidationCallback get_ServerCertificateValidationCallback();
            /*0x16f8704*/ void set_ServerCertificateValidationCallback(System.Net.Security.RemoteCertificateValidationCallback value);
            /*0x16f870c*/ string get_TargetHost();
            /*0x16f8714*/ void set_TargetHost(string value);
        }

        class ServerSslConfiguration
        {
            /*0x10*/ bool _checkCertRevocation;
            /*0x11*/ bool _clientCertRequired;
            /*0x18*/ System.Net.Security.RemoteCertificateValidationCallback _clientCertValidationCallback;
            /*0x20*/ System.Security.Authentication.SslProtocols _enabledSslProtocols;
            /*0x28*/ System.Security.Cryptography.X509Certificates.X509Certificate2 _serverCert;

            static /*0x16f88f0*/ bool defaultValidateClientCertificate(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors);
            /*0x16f872c*/ ServerSslConfiguration();
            /*0x16f874c*/ ServerSslConfiguration(System.Security.Cryptography.X509Certificates.X509Certificate2 serverCertificate);
            /*0x16f877c*/ ServerSslConfiguration(WebSocketSharp.Net.ServerSslConfiguration configuration);
            /*0x16f8818*/ bool get_CheckCertificateRevocation();
            /*0x16f8820*/ void set_CheckCertificateRevocation(bool value);
            /*0x16f882c*/ bool get_ClientCertificateRequired();
            /*0x16f8834*/ void set_ClientCertificateRequired(bool value);
            /*0x16f8840*/ System.Net.Security.RemoteCertificateValidationCallback get_ClientCertificateValidationCallback();
            /*0x16f88c8*/ void set_ClientCertificateValidationCallback(System.Net.Security.RemoteCertificateValidationCallback value);
            /*0x16f88d0*/ System.Security.Authentication.SslProtocols get_EnabledSslProtocols();
            /*0x16f88d8*/ void set_EnabledSslProtocols(System.Security.Authentication.SslProtocols value);
            /*0x16f88e0*/ System.Security.Cryptography.X509Certificates.X509Certificate2 get_ServerCertificate();
            /*0x16f88e8*/ void set_ServerCertificate(System.Security.Cryptography.X509Certificates.X509Certificate2 value);
        }

        class HttpListenerAsyncResult : System.IAsyncResult
        {
            /*0x10*/ System.AsyncCallback _callback;
            /*0x18*/ bool _completed;
            /*0x20*/ WebSocketSharp.Net.HttpListenerContext _context;
            /*0x28*/ bool _endCalled;
            /*0x30*/ System.Exception _exception;
            /*0x38*/ bool _inGet;
            /*0x40*/ object _state;
            /*0x48*/ object _sync;
            /*0x50*/ bool _syncCompleted;
            /*0x58*/ System.Threading.ManualResetEvent _waitHandle;

            static /*0x16f8af8*/ void complete(WebSocketSharp.Net.HttpListenerAsyncResult asyncResult);
            /*0x16f88f8*/ HttpListenerAsyncResult(System.AsyncCallback callback, object state);
            /*0x16f897c*/ bool get_EndCalled();
            /*0x16f8984*/ void set_EndCalled(bool value);
            /*0x16f8990*/ bool get_InGet();
            /*0x16f8998*/ void set_InGet(bool value);
            /*0x16f89a4*/ object get_AsyncState();
            /*0x16f89ac*/ System.Threading.WaitHandle get_AsyncWaitHandle();
            /*0x16f8ab4*/ bool get_CompletedSynchronously();
            /*0x16f8abc*/ bool get_IsCompleted();
            /*0x16f8c8c*/ void Complete(System.Exception exception);
            /*0x16f8d5c*/ void Complete(WebSocketSharp.Net.HttpListenerContext context);
            /*0x16f8d68*/ void Complete(WebSocketSharp.Net.HttpListenerContext context, bool syncCompleted);
            /*0x16f8d78*/ WebSocketSharp.Net.HttpListenerContext GetContext();

            class <>c__DisplayClass25_0
            {
                /*0x10*/ System.AsyncCallback callback;
                /*0x18*/ WebSocketSharp.Net.HttpListenerAsyncResult asyncResult;

                /*0x16f8c84*/ <>c__DisplayClass25_0();
                /*0x16f8da8*/ void <complete>b__0(object state);
            }
        }

        enum HttpRequestHeader
        {
            CacheControl = 0,
            Connection = 1,
            Date = 2,
            KeepAlive = 3,
            Pragma = 4,
            Trailer = 5,
            TransferEncoding = 6,
            Upgrade = 7,
            Via = 8,
            Warning = 9,
            Allow = 10,
            ContentLength = 11,
            ContentType = 12,
            ContentEncoding = 13,
            ContentLanguage = 14,
            ContentLocation = 15,
            ContentMd5 = 16,
            ContentRange = 17,
            Expires = 18,
            LastModified = 19,
            Accept = 20,
            AcceptCharset = 21,
            AcceptEncoding = 22,
            AcceptLanguage = 23,
            Authorization = 24,
            Cookie = 25,
            Expect = 26,
            From = 27,
            Host = 28,
            IfMatch = 29,
            IfModifiedSince = 30,
            IfNoneMatch = 31,
            IfRange = 32,
            IfUnmodifiedSince = 33,
            MaxForwards = 34,
            ProxyAuthorization = 35,
            Referer = 36,
            Range = 37,
            Te = 38,
            Translate = 39,
            UserAgent = 40,
            SecWebSocketKey = 41,
            SecWebSocketExtensions = 42,
            SecWebSocketProtocol = 43,
            SecWebSocketVersion = 44,
        }

        enum HttpResponseHeader
        {
            CacheControl = 0,
            Connection = 1,
            Date = 2,
            KeepAlive = 3,
            Pragma = 4,
            Trailer = 5,
            TransferEncoding = 6,
            Upgrade = 7,
            Via = 8,
            Warning = 9,
            Allow = 10,
            ContentLength = 11,
            ContentType = 12,
            ContentEncoding = 13,
            ContentLanguage = 14,
            ContentLocation = 15,
            ContentMd5 = 16,
            ContentRange = 17,
            Expires = 18,
            LastModified = 19,
            AcceptRanges = 20,
            Age = 21,
            ETag = 22,
            Location = 23,
            ProxyAuthenticate = 24,
            RetryAfter = 25,
            Server = 26,
            SetCookie = 27,
            Vary = 28,
            WwwAuthenticate = 29,
            SecWebSocketExtensions = 30,
            SecWebSocketAccept = 31,
            SecWebSocketProtocol = 32,
            SecWebSocketVersion = 33,
        }

        namespace WebSockets
        {
            class HttpListenerWebSocketContext : WebSocketSharp.Net.WebSockets.WebSocketContext
            {
                /*0x10*/ WebSocketSharp.Net.HttpListenerContext _context;
                /*0x18*/ WebSocketSharp.WebSocket _websocket;

                /*0x16f8e44*/ HttpListenerWebSocketContext(WebSocketSharp.Net.HttpListenerContext context, string protocol);
                /*0x16f8ed4*/ WebSocketSharp.Logger get_Log();
                /*0x16f8efc*/ System.IO.Stream get_Stream();
                /*0x16f8f24*/ WebSocketSharp.Net.CookieCollection get_CookieCollection();
                /*0x16f8f4c*/ System.Collections.Specialized.NameValueCollection get_Headers();
                /*0x16f8f74*/ string get_Host();
                /*0x16f8fe0*/ bool get_IsAuthenticated();
                /*0x16f9008*/ bool get_IsLocal();
                /*0x16f9030*/ bool get_IsSecureConnection();
                /*0x16f9058*/ bool get_IsWebSocketRequest();
                /*0x16f9080*/ string get_Origin();
                /*0x16f90ec*/ System.Collections.Specialized.NameValueCollection get_QueryString();
                /*0x16f9114*/ System.Uri get_RequestUri();
                /*0x16f913c*/ string get_SecWebSocketKey();
                /*0x16f91a8*/ System.Collections.Generic.IEnumerable<string> get_SecWebSocketProtocols();
                /*0x16f9250*/ string get_SecWebSocketVersion();
                /*0x16f92bc*/ System.Net.IPEndPoint get_ServerEndPoint();
                /*0x16f92e4*/ System.Security.Principal.IPrincipal get_User();
                /*0x16f9300*/ System.Net.IPEndPoint get_UserEndPoint();
                /*0x16f9328*/ WebSocketSharp.WebSocket get_WebSocket();
                /*0x16f9330*/ void Close();
                /*0x16f935c*/ void Close(WebSocketSharp.Net.HttpStatusCode code);
                /*0x16f93d8*/ string ToString();

                class <get_SecWebSocketProtocols>d__30 : System.Collections.Generic.IEnumerable<string>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<string>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ string <>2__current;
                    /*0x20*/ int <>l__initialThreadId;
                    /*0x28*/ WebSocketSharp.Net.WebSockets.HttpListenerWebSocketContext <>4__this;
                    /*0x30*/ string <protocols>5__1;
                    /*0x38*/ string[] <>s__2;
                    /*0x40*/ int <>s__3;
                    /*0x48*/ string <protocol>5__4;

                    /*0x16f920c*/ <get_SecWebSocketProtocols>d__30(int <>1__state);
                    /*0x16f9404*/ void System.IDisposable.Dispose();
                    /*0x16f9408*/ bool MoveNext();
                    /*0x16f9568*/ string System.Collections.Generic.IEnumerator<System.String>.get_Current();
                    /*0x16f9570*/ void System.Collections.IEnumerator.Reset();
                    /*0x16f95b0*/ object System.Collections.IEnumerator.get_Current();
                    /*0x16f95b8*/ System.Collections.Generic.IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator();
                    /*0x16f9658*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            class TcpListenerWebSocketContext : WebSocketSharp.Net.WebSockets.WebSocketContext
            {
                /*0x10*/ WebSocketSharp.Net.CookieCollection _cookies;
                /*0x18*/ WebSocketSharp.Logger _logger;
                /*0x20*/ System.Collections.Specialized.NameValueCollection _queryString;
                /*0x28*/ WebSocketSharp.HttpRequest _request;
                /*0x30*/ bool _secure;
                /*0x38*/ System.IO.Stream _stream;
                /*0x40*/ System.Net.Sockets.TcpClient _tcpClient;
                /*0x48*/ System.Uri _uri;
                /*0x50*/ System.Security.Principal.IPrincipal _user;
                /*0x58*/ WebSocketSharp.WebSocket _websocket;

                /*0x16f965c*/ TcpListenerWebSocketContext(System.Net.Sockets.TcpClient tcpClient, string protocol, bool secure, WebSocketSharp.Net.ServerSslConfiguration sslConfig, WebSocketSharp.Logger logger);
                /*0x16f9864*/ WebSocketSharp.Logger get_Log();
                /*0x16f986c*/ System.IO.Stream get_Stream();
                /*0x16f9874*/ WebSocketSharp.Net.CookieCollection get_CookieCollection();
                /*0x16f98a4*/ System.Collections.Specialized.NameValueCollection get_Headers();
                /*0x16f98c0*/ string get_Host();
                /*0x16f9920*/ bool get_IsAuthenticated();
                /*0x16f9930*/ bool get_IsLocal();
                /*0x16f99ac*/ bool get_IsSecureConnection();
                /*0x16f99b4*/ bool get_IsWebSocketRequest();
                /*0x16f99d0*/ string get_Origin();
                /*0x16f9a30*/ System.Collections.Specialized.NameValueCollection get_QueryString();
                /*0x16f9b04*/ System.Uri get_RequestUri();
                /*0x16f9b0c*/ string get_SecWebSocketKey();
                /*0x16f9b6c*/ System.Collections.Generic.IEnumerable<string> get_SecWebSocketProtocols();
                /*0x16f9c14*/ string get_SecWebSocketVersion();
                /*0x16f9c74*/ System.Net.IPEndPoint get_ServerEndPoint();
                /*0x16f9d04*/ System.Security.Principal.IPrincipal get_User();
                /*0x16f9d0c*/ System.Net.IPEndPoint get_UserEndPoint();
                /*0x16f9d9c*/ WebSocketSharp.WebSocket get_WebSocket();
                /*0x16f9da4*/ bool Authenticate(WebSocketSharp.Net.AuthenticationSchemes scheme, string realm, System.Func<System.Security.Principal.IIdentity, WebSocketSharp.Net.NetworkCredential> credentialsFinder);
                /*0x16f9f40*/ void Close();
                /*0x16f9f10*/ void Close(WebSocketSharp.Net.HttpStatusCode code);
                /*0x16f9f78*/ void SendAuthenticationChallenge(string challenge);
                /*0x16f9fe0*/ string ToString();

                class <get_SecWebSocketProtocols>d__38 : System.Collections.Generic.IEnumerable<string>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<string>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ string <>2__current;
                    /*0x20*/ int <>l__initialThreadId;
                    /*0x28*/ WebSocketSharp.Net.WebSockets.TcpListenerWebSocketContext <>4__this;
                    /*0x30*/ string <protocols>5__1;
                    /*0x38*/ string[] <>s__2;
                    /*0x40*/ int <>s__3;
                    /*0x48*/ string <protocol>5__4;

                    /*0x16f9bd0*/ <get_SecWebSocketProtocols>d__38(int <>1__state);
                    /*0x16fa000*/ void System.IDisposable.Dispose();
                    /*0x16fa004*/ bool MoveNext();
                    /*0x16fa158*/ string System.Collections.Generic.IEnumerator<System.String>.get_Current();
                    /*0x16fa160*/ void System.Collections.IEnumerator.Reset();
                    /*0x16fa1a0*/ object System.Collections.IEnumerator.get_Current();
                    /*0x16fa1a8*/ System.Collections.Generic.IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator();
                    /*0x16fa248*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }

                class <>c__DisplayClass49_0
                {
                    /*0x10*/ int retry;
                    /*0x14*/ WebSocketSharp.Net.AuthenticationSchemes scheme;
                    /*0x18*/ string realm;
                    /*0x20*/ System.Func<System.Security.Principal.IIdentity, WebSocketSharp.Net.NetworkCredential> credentialsFinder;
                    /*0x28*/ string chal;
                    /*0x30*/ System.Func<bool> auth;
                    /*0x38*/ WebSocketSharp.Net.WebSockets.TcpListenerWebSocketContext <>4__this;

                    /*0x16f9f08*/ <>c__DisplayClass49_0();
                    /*0x16fa24c*/ bool <Authenticate>b__0();
                }
            }

            class WebSocketContext
            {
                /*0x16f8ecc*/ WebSocketContext();
                WebSocketSharp.Net.CookieCollection get_CookieCollection();
                System.Collections.Specialized.NameValueCollection get_Headers();
                string get_Host();
                bool get_IsAuthenticated();
                bool get_IsLocal();
                bool get_IsSecureConnection();
                bool get_IsWebSocketRequest();
                string get_Origin();
                System.Collections.Specialized.NameValueCollection get_QueryString();
                System.Uri get_RequestUri();
                string get_SecWebSocketKey();
                System.Collections.Generic.IEnumerable<string> get_SecWebSocketProtocols();
                string get_SecWebSocketVersion();
                System.Net.IPEndPoint get_ServerEndPoint();
                System.Security.Principal.IPrincipal get_User();
                System.Net.IPEndPoint get_UserEndPoint();
                WebSocketSharp.WebSocket get_WebSocket();
            }
        }
    }

    namespace Server
    {
        class WebSocketServer
        {
            static /*0x0*/ string _defaultRealm;
            /*0x10*/ System.Net.IPAddress _address;
            /*0x18*/ bool _allowForwardedRequest;
            /*0x1c*/ WebSocketSharp.Net.AuthenticationSchemes _authSchemes;
            /*0x20*/ bool _dnsStyle;
            /*0x28*/ string _hostname;
            /*0x30*/ System.Net.Sockets.TcpListener _listener;
            /*0x38*/ WebSocketSharp.Logger _log;
            /*0x40*/ int _port;
            /*0x48*/ string _realm;
            /*0x50*/ string _realmInUse;
            /*0x58*/ System.Threading.Thread _receiveThread;
            /*0x60*/ bool _reuseAddress;
            /*0x61*/ bool _secure;
            /*0x68*/ WebSocketSharp.Server.WebSocketServiceManager _services;
            /*0x70*/ WebSocketSharp.Net.ServerSslConfiguration _sslConfig;
            /*0x78*/ WebSocketSharp.Net.ServerSslConfiguration _sslConfigInUse;
            /*0x80*/ WebSocketSharp.Server.ServerState _state;
            /*0x88*/ object _sync;
            /*0x90*/ System.Func<System.Security.Principal.IIdentity, WebSocketSharp.Net.NetworkCredential> _userCredFinder;

            static /*0x16fa49c*/ WebSocketServer();
            static /*0x16faab8*/ bool tryCreateUri(string uriString, ref System.Uri result, ref string message);
            /*0x16fa4fc*/ WebSocketServer();
            /*0x16fa6fc*/ WebSocketServer(int port);
            /*0x16fa840*/ WebSocketServer(string url);
            /*0x16fa708*/ WebSocketServer(int port, bool secure);
            /*0x16fab9c*/ WebSocketServer(System.Net.IPAddress address, int port);
            /*0x16faba8*/ WebSocketServer(System.Net.IPAddress address, int port, bool secure);
            /*0x16fad68*/ System.Net.IPAddress get_Address();
            /*0x16fad70*/ bool get_AllowForwardedRequest();
            /*0x16fad78*/ void set_AllowForwardedRequest(bool value);
            /*0x16faf14*/ WebSocketSharp.Net.AuthenticationSchemes get_AuthenticationSchemes();
            /*0x16faf1c*/ void set_AuthenticationSchemes(WebSocketSharp.Net.AuthenticationSchemes value);
            /*0x16fb020*/ bool get_IsListening();
            /*0x16fb03c*/ bool get_IsSecure();
            /*0x16fb044*/ bool get_KeepClean();
            /*0x16fb080*/ void set_KeepClean(bool value);
            /*0x16fb3b4*/ WebSocketSharp.Logger get_Log();
            /*0x16fb3bc*/ int get_Port();
            /*0x16fb3c4*/ string get_Realm();
            /*0x16fb3cc*/ void set_Realm(string value);
            /*0x16fb4d0*/ bool get_ReuseAddress();
            /*0x16fb4d8*/ void set_ReuseAddress(bool value);
            /*0x16fb5e0*/ WebSocketSharp.Net.ServerSslConfiguration get_SslConfiguration();
            /*0x16fb654*/ System.Func<System.Security.Principal.IIdentity, WebSocketSharp.Net.NetworkCredential> get_UserCredentialsFinder();
            /*0x16fb65c*/ void set_UserCredentialsFinder(System.Func<System.Security.Principal.IIdentity, WebSocketSharp.Net.NetworkCredential> value);
            /*0x16fb760*/ System.TimeSpan get_WaitTime();
            /*0x16fb784*/ void set_WaitTime(System.TimeSpan value);
            /*0x16fbb4c*/ WebSocketSharp.Server.WebSocketServiceManager get_WebSocketServices();
            /*0x16fbb54*/ void abort();
            /*0x16fae80*/ bool canSet(ref string message);
            /*0x16fbd8c*/ bool checkHostNameForRequest(string name);
            /*0x16fbe18*/ bool checkSslConfiguration(WebSocketSharp.Net.ServerSslConfiguration configuration, ref string message);
            /*0x16fbeac*/ string getRealm();
            /*0x16fbf1c*/ WebSocketSharp.Net.ServerSslConfiguration getSslConfiguration();
            /*0x16fa590*/ void init(string hostname, System.Net.IPAddress address, int port, bool secure);
            /*0x16fc0e8*/ void processRequest(WebSocketSharp.Net.WebSockets.TcpListenerWebSocketContext context);
            /*0x16fc3c4*/ void receiveRequest();
            /*0x16fc670*/ void start(WebSocketSharp.Net.ServerSslConfiguration sslConfig);
            /*0x16fcb50*/ void startReceiving();
            /*0x16fce94*/ void stop(ushort code, string reason);
            /*0x16fd22c*/ void stopReceiving(int millisecondsTimeout);
            void AddWebSocketService<TBehavior>(string path, System.Func<TBehavior> creator);
            void AddWebSocketService<TBehaviorWithNew>(string path);
            void AddWebSocketService<TBehaviorWithNew>(string path, System.Action<TBehaviorWithNew> initializer);
            /*0x16fd26c*/ bool RemoveWebSocketService(string path);
            /*0x16fd62c*/ void Start();
            /*0x16fd6b0*/ void Stop();
            /*0x16fd704*/ void Stop(ushort code, string reason);
            /*0x16fd924*/ void Stop(WebSocketSharp.CloseStatusCode code, string reason);

            class <>c__DisplayClass70_0
            {
                /*0x10*/ System.Net.Sockets.TcpClient cl;
                /*0x18*/ WebSocketSharp.Server.WebSocketServer <>4__this;

                /*0x16fc668*/ <>c__DisplayClass70_0();
                /*0x16fdae8*/ void <receiveRequest>b__0(object state);
            }
        }

        class HttpServer
        {
            /*0x10*/ System.Net.IPAddress _address;
            /*0x18*/ string _hostname;
            /*0x20*/ WebSocketSharp.Net.HttpListener _listener;
            /*0x28*/ WebSocketSharp.Logger _log;
            /*0x30*/ int _port;
            /*0x38*/ System.Threading.Thread _receiveThread;
            /*0x40*/ string _rootPath;
            /*0x48*/ bool _secure;
            /*0x50*/ WebSocketSharp.Server.WebSocketServiceManager _services;
            /*0x58*/ WebSocketSharp.Server.ServerState _state;
            /*0x60*/ object _sync;
            /*0x68*/ System.EventHandler<WebSocketSharp.Server.HttpRequestEventArgs> OnConnect;
            /*0x70*/ System.EventHandler<WebSocketSharp.Server.HttpRequestEventArgs> OnDelete;
            /*0x78*/ System.EventHandler<WebSocketSharp.Server.HttpRequestEventArgs> OnGet;
            /*0x80*/ System.EventHandler<WebSocketSharp.Server.HttpRequestEventArgs> OnHead;
            /*0x88*/ System.EventHandler<WebSocketSharp.Server.HttpRequestEventArgs> OnOptions;
            /*0x90*/ System.EventHandler<WebSocketSharp.Server.HttpRequestEventArgs> OnPatch;
            /*0x98*/ System.EventHandler<WebSocketSharp.Server.HttpRequestEventArgs> OnPost;
            /*0xa0*/ System.EventHandler<WebSocketSharp.Server.HttpRequestEventArgs> OnPut;
            /*0xa8*/ System.EventHandler<WebSocketSharp.Server.HttpRequestEventArgs> OnTrace;

            static /*0x17001f4*/ string convertToString(System.Net.IPAddress address);
            static /*0x16fe514*/ string getHost(System.Uri uri);
            static /*0x16fe2ec*/ bool tryCreateUri(string uriString, ref System.Uri result, ref string message);
            /*0x16fdccc*/ HttpServer();
            /*0x16fdf4c*/ HttpServer(int port);
            /*0x16fe0b8*/ HttpServer(string url);
            /*0x16fdf58*/ HttpServer(int port, bool secure);
            /*0x16fe554*/ HttpServer(System.Net.IPAddress address, int port);
            /*0x16fe560*/ HttpServer(System.Net.IPAddress address, int port, bool secure);
            /*0x16fe74c*/ System.Net.IPAddress get_Address();
            /*0x16fe754*/ WebSocketSharp.Net.AuthenticationSchemes get_AuthenticationSchemes();
            /*0x16fe770*/ void set_AuthenticationSchemes(WebSocketSharp.Net.AuthenticationSchemes value);
            /*0x16fe920*/ bool get_IsListening();
            /*0x16fe93c*/ bool get_IsSecure();
            /*0x16fe944*/ bool get_KeepClean();
            /*0x16fe968*/ void set_KeepClean(bool value);
            /*0x16fea80*/ WebSocketSharp.Logger get_Log();
            /*0x16fea88*/ int get_Port();
            /*0x16fea90*/ string get_Realm();
            /*0x16feaac*/ void set_Realm(string value);
            /*0x16febc8*/ bool get_ReuseAddress();
            /*0x16febe4*/ void set_ReuseAddress(bool value);
            /*0x16fed00*/ string get_RootPath();
            /*0x16fed08*/ void set_RootPath(string value);
            /*0x16fef00*/ WebSocketSharp.Net.ServerSslConfiguration get_SslConfiguration();
            /*0x16fef1c*/ System.Func<System.Security.Principal.IIdentity, WebSocketSharp.Net.NetworkCredential> get_UserCredentialsFinder();
            /*0x16fef38*/ void set_UserCredentialsFinder(System.Func<System.Security.Principal.IIdentity, WebSocketSharp.Net.NetworkCredential> value);
            /*0x16ff054*/ System.TimeSpan get_WaitTime();
            /*0x16ff070*/ void set_WaitTime(System.TimeSpan value);
            /*0x16ff240*/ WebSocketSharp.Server.WebSocketServiceManager get_WebSocketServices();
            /*0x16ff248*/ void add_OnConnect(System.EventHandler<WebSocketSharp.Server.HttpRequestEventArgs> value);
            /*0x16ff2f8*/ void remove_OnConnect(System.EventHandler<WebSocketSharp.Server.HttpRequestEventArgs> value);
            /*0x16ff3a8*/ void add_OnDelete(System.EventHandler<WebSocketSharp.Server.HttpRequestEventArgs> value);
            /*0x16ff458*/ void remove_OnDelete(System.EventHandler<WebSocketSharp.Server.HttpRequestEventArgs> value);
            /*0x16ff508*/ void add_OnGet(System.EventHandler<WebSocketSharp.Server.HttpRequestEventArgs> value);
            /*0x16ff5b8*/ void remove_OnGet(System.EventHandler<WebSocketSharp.Server.HttpRequestEventArgs> value);
            /*0x16ff668*/ void add_OnHead(System.EventHandler<WebSocketSharp.Server.HttpRequestEventArgs> value);
            /*0x16ff718*/ void remove_OnHead(System.EventHandler<WebSocketSharp.Server.HttpRequestEventArgs> value);
            /*0x16ff7c8*/ void add_OnOptions(System.EventHandler<WebSocketSharp.Server.HttpRequestEventArgs> value);
            /*0x16ff878*/ void remove_OnOptions(System.EventHandler<WebSocketSharp.Server.HttpRequestEventArgs> value);
            /*0x16ff928*/ void add_OnPatch(System.EventHandler<WebSocketSharp.Server.HttpRequestEventArgs> value);
            /*0x16ff9d8*/ void remove_OnPatch(System.EventHandler<WebSocketSharp.Server.HttpRequestEventArgs> value);
            /*0x16ffa88*/ void add_OnPost(System.EventHandler<WebSocketSharp.Server.HttpRequestEventArgs> value);
            /*0x16ffb38*/ void remove_OnPost(System.EventHandler<WebSocketSharp.Server.HttpRequestEventArgs> value);
            /*0x16ffbe8*/ void add_OnPut(System.EventHandler<WebSocketSharp.Server.HttpRequestEventArgs> value);
            /*0x16ffc98*/ void remove_OnPut(System.EventHandler<WebSocketSharp.Server.HttpRequestEventArgs> value);
            /*0x16ffd48*/ void add_OnTrace(System.EventHandler<WebSocketSharp.Server.HttpRequestEventArgs> value);
            /*0x16ffdf8*/ void remove_OnTrace(System.EventHandler<WebSocketSharp.Server.HttpRequestEventArgs> value);
            /*0x16ffea8*/ void abort();
            /*0x16fe88c*/ bool canSet(ref string message);
            /*0x17000d4*/ bool checkCertificate(ref string message);
            /*0x1700280*/ string createFilePath(string path);
            /*0x16fdd58*/ void init(string hostname, System.Net.IPAddress address, int port, bool secure);
            /*0x1700404*/ void processRequest(WebSocketSharp.Net.HttpListenerContext context);
            /*0x1700700*/ void processRequest(WebSocketSharp.Net.WebSockets.HttpListenerWebSocketContext context);
            /*0x1700780*/ void receiveRequest();
            /*0x1700a3c*/ void start();
            /*0x1700cc8*/ void startReceiving();
            /*0x1700da0*/ void stop(ushort code, string reason);
            /*0x1701140*/ void stopReceiving(int millisecondsTimeout);
            void AddWebSocketService<TBehavior>(string path, System.Func<TBehavior> creator);
            void AddWebSocketService<TBehaviorWithNew>(string path);
            void AddWebSocketService<TBehaviorWithNew>(string path, System.Action<TBehaviorWithNew> initializer);
            /*0x1701180*/ byte[] GetFile(string path);
            /*0x17013a4*/ bool RemoveWebSocketService(string path);
            /*0x17013bc*/ void Start();
            /*0x170142c*/ void Stop();
            /*0x1701480*/ void Stop(ushort code, string reason);
            /*0x17016a0*/ void Stop(WebSocketSharp.CloseStatusCode code, string reason);

            class <>c__DisplayClass88_0
            {
                /*0x10*/ WebSocketSharp.Net.HttpListenerContext ctx;
                /*0x18*/ WebSocketSharp.Server.HttpServer <>4__this;

                /*0x1700a34*/ <>c__DisplayClass88_0();
                /*0x1701864*/ void <receiveRequest>b__0(object state);
            }
        }

        class WebSocketServiceHost
        {
            /*0x10*/ WebSocketSharp.Logger _log;
            /*0x18*/ string _path;
            /*0x20*/ WebSocketSharp.Server.WebSocketSessionManager _sessions;

            /*0x1701a4c*/ WebSocketServiceHost(string path, WebSocketSharp.Logger log);
            /*0x1701c5c*/ WebSocketSharp.Server.ServerState get_State();
            /*0x1701c98*/ WebSocketSharp.Logger get_Log();
            /*0x1701ca0*/ bool get_KeepClean();
            /*0x1701cdc*/ void set_KeepClean(bool value);
            /*0x1701e40*/ string get_Path();
            /*0x1701e48*/ WebSocketSharp.Server.WebSocketSessionManager get_Sessions();
            System.Type get_BehaviorType();
            /*0x1701e50*/ System.TimeSpan get_WaitTime();
            /*0x1701e74*/ void set_WaitTime(System.TimeSpan value);
            /*0x1701d34*/ bool canSet(ref string message);
            /*0x170234c*/ void Start();
            /*0x16fc388*/ void StartSession(WebSocketSharp.Net.WebSockets.WebSocketContext context);
            /*0x17027a4*/ void Stop(ushort code, string reason);
            WebSocketSharp.Server.WebSocketBehavior CreateSession();
        }

        class HttpRequestEventArgs : System.EventArgs
        {
            /*0x10*/ WebSocketSharp.Net.HttpListenerContext _context;
            /*0x18*/ string _docRootPath;

            static /*0x1702a78*/ bool tryReadFile(string path, ref byte[] contents);
            /*0x1700690*/ HttpRequestEventArgs(WebSocketSharp.Net.HttpListenerContext context, string documentRootPath);
            /*0x17028a0*/ WebSocketSharp.Net.HttpListenerRequest get_Request();
            /*0x17028bc*/ WebSocketSharp.Net.HttpListenerResponse get_Response();
            /*0x17028d8*/ System.Security.Principal.IPrincipal get_User();
            /*0x17028f4*/ string createFilePath(string childPath);
            /*0x1702b2c*/ byte[] ReadFile(string path);
            /*0x1702d40*/ bool TryReadFile(string path, ref byte[] contents);
        }

        interface IWebSocketSession
        {
            WebSocketSharp.Net.WebSockets.WebSocketContext get_Context();
            string get_ID();
            string get_Protocol();
            System.DateTime get_StartTime();
            WebSocketSharp.WebSocketState get_State();
        }

        class WebSocketSessionManager
        {
            /*0x10*/ bool _clean;
            /*0x18*/ object _forSweep;
            /*0x20*/ WebSocketSharp.Logger _logger;
            /*0x28*/ System.Collections.Generic.Dictionary<string, WebSocketSharp.Server.IWebSocketSession> _sessions;
            /*0x30*/ WebSocketSharp.Server.ServerState _state;
            /*0x34*/ bool _sweeping;
            /*0x38*/ System.Timers.Timer _sweepTimer;
            /*0x40*/ object _sync;
            /*0x48*/ System.TimeSpan _waitTime;

            static /*0x17043f0*/ string createID();
            /*0x1702f4c*/ WebSocketSessionManager();
            /*0x1701acc*/ WebSocketSessionManager(WebSocketSharp.Logger logger);
            /*0x1701c80*/ WebSocketSharp.Server.ServerState get_State();
            /*0x1703074*/ System.Collections.Generic.IEnumerable<string> get_ActiveIDs();
            /*0x170311c*/ int get_Count();
            /*0x1703204*/ System.Collections.Generic.IEnumerable<string> get_IDs();
            /*0x170336c*/ System.Collections.Generic.IEnumerable<string> get_InactiveIDs();
            /*0x1703414*/ WebSocketSharp.Server.IWebSocketSession get_Item(string id);
            /*0x1701cc4*/ bool get_KeepClean();
            /*0x1701dcc*/ void set_KeepClean(bool value);
            /*0x1703514*/ System.Collections.Generic.IEnumerable<WebSocketSharp.Server.IWebSocketSession> get_Sessions();
            /*0x1701e6c*/ System.TimeSpan get_WaitTime();
            /*0x1701f78*/ void set_WaitTime(System.TimeSpan value);
            /*0x170367c*/ void broadcast(WebSocketSharp.Opcode opcode, byte[] data, System.Action completed);
            /*0x1703c48*/ void broadcast(WebSocketSharp.Opcode opcode, System.IO.Stream stream, System.Action completed);
            /*0x1704238*/ void broadcastAsync(WebSocketSharp.Opcode opcode, byte[] data, System.Action completed);
            /*0x1704314*/ void broadcastAsync(WebSocketSharp.Opcode opcode, System.IO.Stream stream, System.Action completed);
            /*0x1702fb0*/ void setSweepTimer(double interval);
            /*0x1704454*/ void stop(WebSocketSharp.PayloadData payloadData, bool send);
            /*0x17047fc*/ bool tryGetSession(string id, ref WebSocketSharp.Server.IWebSocketSession session);
            /*0x1704940*/ string Add(WebSocketSharp.Server.IWebSocketSession session);
            /*0x1703880*/ void Broadcast(WebSocketSharp.Opcode opcode, byte[] data, System.Collections.Generic.Dictionary<WebSocketSharp.CompressionMethod, System.Byte[]> cache);
            /*0x1703e70*/ void Broadcast(WebSocketSharp.Opcode opcode, System.IO.Stream stream, System.Collections.Generic.Dictionary<WebSocketSharp.CompressionMethod, System.IO.Stream> cache);
            /*0x1704a58*/ System.Collections.Generic.Dictionary<string, bool> Broadping(byte[] frameAsBytes, System.TimeSpan timeout);
            /*0x1704ef0*/ bool Remove(string id);
            /*0x1702364*/ void Start();
            /*0x17027bc*/ void Stop(ushort code, string reason);
            /*0x1704fe0*/ void Broadcast(byte[] data);
            /*0x1705148*/ void Broadcast(string data);
            /*0x17052d0*/ void BroadcastAsync(byte[] data, System.Action completed);
            /*0x170543c*/ void BroadcastAsync(string data, System.Action completed);
            /*0x17055c8*/ void BroadcastAsync(System.IO.Stream stream, int length, System.Action completed);
            /*0x17057b4*/ System.Collections.Generic.Dictionary<string, bool> Broadping();
            /*0x1705888*/ System.Collections.Generic.Dictionary<string, bool> Broadping(string message);
            /*0x17059d8*/ void CloseSession(string id);
            /*0x1705ac0*/ void CloseSession(string id, ushort code, string reason);
            /*0x1705bc0*/ void CloseSession(string id, WebSocketSharp.CloseStatusCode code, string reason);
            /*0x1705cc0*/ bool PingTo(string id);
            /*0x1705db4*/ bool PingTo(string message, string id);
            /*0x1705eb0*/ void SendTo(byte[] data, string id);
            /*0x1705fa0*/ void SendTo(string data, string id);
            /*0x1706090*/ void SendToAsync(byte[] data, string id, System.Action<bool> completed);
            /*0x1706190*/ void SendToAsync(string data, string id, System.Action<bool> completed);
            /*0x1706290*/ void SendToAsync(System.IO.Stream stream, int length, string id, System.Action<bool> completed);
            /*0x1706398*/ void Sweep();
            /*0x1703430*/ bool TryGetSession(string id, ref WebSocketSharp.Server.IWebSocketSession session);
            /*0x1706a00*/ void <setSweepTimer>b__36_0(object sender, System.Timers.ElapsedEventArgs e);
            /*0x1706a04*/ void <BroadcastAsync>b__50_1(System.Exception ex);

            class <get_ActiveIDs>d__14 : System.Collections.Generic.IEnumerable<string>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<string>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ string <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ WebSocketSharp.Server.WebSocketSessionManager <>4__this;
                /*0x30*/ System.Collections.Generic.Dictionary.Enumerator<string, bool> <>s__1;
                /*0x58*/ System.Collections.Generic.KeyValuePair<string, bool> <res>5__2;

                /*0x17030d8*/ <get_ActiveIDs>d__14(int <>1__state);
                /*0x1706a40*/ void System.IDisposable.Dispose();
                /*0x1706a5c*/ bool MoveNext();
                /*0x1706c7c*/ void <>m__Finally1();
                /*0x1706ccc*/ string System.Collections.Generic.IEnumerator<System.String>.get_Current();
                /*0x1706cd4*/ void System.Collections.IEnumerator.Reset();
                /*0x1706d14*/ object System.Collections.IEnumerator.get_Current();
                /*0x1706d1c*/ System.Collections.Generic.IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator();
                /*0x1706dbc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <get_InactiveIDs>d__20 : System.Collections.Generic.IEnumerable<string>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<string>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ string <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ WebSocketSharp.Server.WebSocketSessionManager <>4__this;
                /*0x30*/ System.Collections.Generic.Dictionary.Enumerator<string, bool> <>s__1;
                /*0x58*/ System.Collections.Generic.KeyValuePair<string, bool> <res>5__2;

                /*0x17033d0*/ <get_InactiveIDs>d__20(int <>1__state);
                /*0x1706dc0*/ void System.IDisposable.Dispose();
                /*0x1706ddc*/ bool MoveNext();
                /*0x1706ffc*/ void <>m__Finally1();
                /*0x170704c*/ string System.Collections.Generic.IEnumerator<System.String>.get_Current();
                /*0x1707054*/ void System.Collections.IEnumerator.Reset();
                /*0x1707094*/ object System.Collections.IEnumerator.get_Current();
                /*0x170709c*/ System.Collections.Generic.IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator();
                /*0x170713c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <>c__DisplayClass33_0
            {
                /*0x10*/ WebSocketSharp.Opcode opcode;
                /*0x18*/ byte[] data;
                /*0x20*/ System.Action completed;
                /*0x28*/ WebSocketSharp.Server.WebSocketSessionManager <>4__this;

                /*0x170430c*/ <>c__DisplayClass33_0();
                /*0x1707140*/ void <broadcastAsync>b__0(object state);
            }

            class <>c__DisplayClass34_0
            {
                /*0x10*/ WebSocketSharp.Opcode opcode;
                /*0x18*/ System.IO.Stream stream;
                /*0x20*/ System.Action completed;
                /*0x28*/ WebSocketSharp.Server.WebSocketSessionManager <>4__this;

                /*0x17043e8*/ <>c__DisplayClass34_0();
                /*0x1707164*/ void <broadcastAsync>b__0(object state);
            }

            class <>c__DisplayClass50_0
            {
                /*0x10*/ int length;
                /*0x18*/ System.Action completed;
                /*0x20*/ WebSocketSharp.Server.WebSocketSessionManager <>4__this;

                /*0x17057ac*/ <>c__DisplayClass50_0();
                /*0x1707188*/ void <BroadcastAsync>b__0(byte[] data);
            }
        }

        enum ServerState
        {
            Ready = 0,
            Start = 1,
            ShuttingDown = 2,
            Stop = 3,
        }

        class WebSocketServiceManager
        {
            /*0x10*/ bool _clean;
            /*0x18*/ System.Collections.Generic.Dictionary<string, WebSocketSharp.Server.WebSocketServiceHost> _hosts;
            /*0x20*/ WebSocketSharp.Logger _log;
            /*0x28*/ WebSocketSharp.Server.ServerState _state;
            /*0x30*/ object _sync;
            /*0x38*/ System.TimeSpan _waitTime;

            /*0x16fbf94*/ WebSocketServiceManager(WebSocketSharp.Logger log);
            /*0x1707354*/ int get_Count();
            /*0x170743c*/ System.Collections.Generic.IEnumerable<WebSocketSharp.Server.WebSocketServiceHost> get_Hosts();
            /*0x170756c*/ WebSocketSharp.Server.WebSocketServiceHost get_Item(string path);
            /*0x16fb068*/ bool get_KeepClean();
            /*0x16fb198*/ void set_KeepClean(bool value);
            /*0x1707760*/ System.Collections.Generic.IEnumerable<string> get_Paths();
            /*0x1707890*/ int get_SessionCount();
            /*0x16fb77c*/ System.TimeSpan get_WaitTime();
            /*0x16fb940*/ void set_WaitTime(System.TimeSpan value);
            /*0x1707bbc*/ void broadcast(WebSocketSharp.Opcode opcode, byte[] data, System.Action completed);
            /*0x1708104*/ void broadcast(WebSocketSharp.Opcode opcode, System.IO.Stream stream, System.Action completed);
            /*0x1708658*/ void broadcastAsync(WebSocketSharp.Opcode opcode, byte[] data, System.Action completed);
            /*0x1708734*/ void broadcastAsync(WebSocketSharp.Opcode opcode, System.IO.Stream stream, System.Action completed);
            /*0x1708810*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, bool>> broadping(byte[] frameAsBytes, System.TimeSpan timeout);
            void Add<TBehavior>(string path, System.Func<TBehavior> creator);
            /*0x16fc21c*/ bool InternalTryGetServiceHost(string path, ref WebSocketSharp.Server.WebSocketServiceHost host);
            /*0x16fc92c*/ void Start();
            /*0x16fcc54*/ void Stop(ushort code, string reason);
            void AddService<TBehavior>(string path, System.Action<TBehavior> initializer);
            /*0x1708bb0*/ void Broadcast(byte[] data);
            /*0x1708d2c*/ void Broadcast(string data);
            /*0x1708f4c*/ void BroadcastAsync(byte[] data, System.Action completed);
            /*0x17090d8*/ void BroadcastAsync(string data, System.Action completed);
            /*0x17092fc*/ void BroadcastAsync(System.IO.Stream stream, int length, System.Action completed);
            /*0x1709624*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, bool>> Broadping();
            /*0x17096e8*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, bool>> Broadping(string message);
            /*0x170990c*/ void Clear();
            /*0x16fd284*/ bool RemoveService(string path);
            /*0x1709be4*/ bool TryGetServiceHost(string path, ref WebSocketSharp.Server.WebSocketServiceHost host);

            class <>c__DisplayClass25_0
            {
                /*0x10*/ WebSocketSharp.Opcode opcode;
                /*0x18*/ byte[] data;
                /*0x20*/ System.Action completed;
                /*0x28*/ WebSocketSharp.Server.WebSocketServiceManager <>4__this;

                /*0x170872c*/ <>c__DisplayClass25_0();
                /*0x1709dd0*/ void <broadcastAsync>b__0(object state);
            }

            class <>c__DisplayClass26_0
            {
                /*0x10*/ WebSocketSharp.Opcode opcode;
                /*0x18*/ System.IO.Stream stream;
                /*0x20*/ System.Action completed;
                /*0x28*/ WebSocketSharp.Server.WebSocketServiceManager <>4__this;

                /*0x1708808*/ <>c__DisplayClass26_0();
                /*0x1709df4*/ void <broadcastAsync>b__0(object state);
            }

            class <>c__32<TBehavior>
            {
                static /*0x0*/ WebSocketSharp.Server.WebSocketServiceManager.<>c__32<TBehavior> <>9;
                static /*0x0*/ System.Func<TBehavior> <>9__32_0;

                static <>c__32();
                <>c__32();
                TBehavior <AddService>b__32_0();
            }
        }

        class WebSocketBehavior : WebSocketSharp.Server.IWebSocketSession
        {
            /*0x10*/ WebSocketSharp.Net.WebSockets.WebSocketContext _context;
            /*0x18*/ System.Func<WebSocketSharp.Net.CookieCollection, WebSocketSharp.Net.CookieCollection, bool> _cookiesValidator;
            /*0x20*/ bool _emitOnPing;
            /*0x28*/ string _id;
            /*0x30*/ bool _ignoreExtensions;
            /*0x38*/ System.Func<string, bool> _originValidator;
            /*0x40*/ string _protocol;
            /*0x48*/ WebSocketSharp.Server.WebSocketSessionManager _sessions;
            /*0x50*/ System.DateTime _startTime;
            /*0x58*/ WebSocketSharp.WebSocket _websocket;

            /*0x1709e18*/ WebSocketBehavior();
            /*0x1709e84*/ WebSocketSharp.Logger get_Log();
            /*0x1709e98*/ WebSocketSharp.Server.WebSocketSessionManager get_Sessions();
            /*0x1709ea0*/ WebSocketSharp.Net.WebSockets.WebSocketContext get_Context();
            /*0x1709ea8*/ System.Func<WebSocketSharp.Net.CookieCollection, WebSocketSharp.Net.CookieCollection, bool> get_CookiesValidator();
            /*0x1709eb0*/ void set_CookiesValidator(System.Func<WebSocketSharp.Net.CookieCollection, WebSocketSharp.Net.CookieCollection, bool> value);
            /*0x1709eb8*/ bool get_EmitOnPing();
            /*0x1709ed4*/ void set_EmitOnPing(bool value);
            /*0x1709ef8*/ string get_ID();
            /*0x1709f00*/ bool get_IgnoreExtensions();
            /*0x1709f08*/ void set_IgnoreExtensions(bool value);
            /*0x1709f14*/ System.Func<string, bool> get_OriginValidator();
            /*0x1709f1c*/ void set_OriginValidator(System.Func<string, bool> value);
            /*0x1709f24*/ string get_Protocol();
            /*0x1709f90*/ void set_Protocol(string value);
            /*0x170a030*/ System.DateTime get_StartTime();
            /*0x170a01c*/ WebSocketSharp.WebSocketState get_State();
            /*0x170a038*/ string checkHandshakeRequest(WebSocketSharp.Net.WebSockets.WebSocketContext context);
            /*0x170a144*/ void onClose(object sender, WebSocketSharp.CloseEventArgs e);
            /*0x170a194*/ void onError(object sender, WebSocketSharp.ErrorEventArgs e);
            /*0x170a1a8*/ void onMessage(object sender, WebSocketSharp.MessageEventArgs e);
            /*0x170a1bc*/ void onOpen(object sender, System.EventArgs e);
            /*0x1702444*/ void Start(WebSocketSharp.Net.WebSockets.WebSocketContext context, WebSocketSharp.Server.WebSocketSessionManager sessions);
            /*0x170a25c*/ void Error(string message, System.Exception exception);
            /*0x170a300*/ void OnClose(WebSocketSharp.CloseEventArgs e);
            /*0x170a304*/ void OnError(WebSocketSharp.ErrorEventArgs e);
            /*0x170a308*/ void OnMessage(WebSocketSharp.MessageEventArgs e);
            /*0x170a30c*/ void OnOpen();
            /*0x170a310*/ void Send(byte[] data);
            /*0x170a324*/ void Send(System.IO.FileInfo file);
            /*0x170a338*/ void Send(string data);
            /*0x170a34c*/ void SendAsync(byte[] data, System.Action<bool> completed);
            /*0x170a360*/ void SendAsync(System.IO.FileInfo file, System.Action<bool> completed);
            /*0x170a374*/ void SendAsync(string data, System.Action<bool> completed);
            /*0x170a388*/ void SendAsync(System.IO.Stream stream, int length, System.Action<bool> completed);
        }

        class WebSocketServiceHost<TBehavior> : WebSocketSharp.Server.WebSocketServiceHost
        {
            /*0x0*/ System.Func<TBehavior> _creator;

            WebSocketServiceHost(string path, System.Func<TBehavior> creator, WebSocketSharp.Logger log);
            WebSocketServiceHost(string path, System.Func<TBehavior> creator, System.Action<TBehavior> initializer, WebSocketSharp.Logger log);
            System.Type get_BehaviorType();
            System.Func<TBehavior> createCreator(System.Func<TBehavior> creator, System.Action<TBehavior> initializer);
            WebSocketSharp.Server.WebSocketBehavior CreateSession();

            class <>c__DisplayClass5_0<TBehavior>
            {
                /*0x0*/ System.Func<TBehavior> creator;
                /*0x0*/ System.Action<TBehavior> initializer;

                <>c__DisplayClass5_0();
                TBehavior <createCreator>b__0();
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 49BE292FEFD2E3B7218C9123B9A016847C2A5C96;
    static /*0x10*/ long 6532575F81314AADD4BCFD96F1517D5BBFF2B60B;

    struct __StaticArrayInitTypeSize=14
    {
    }
}
