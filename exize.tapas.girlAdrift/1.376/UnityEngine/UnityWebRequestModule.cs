class <Module>
{
}

namespace UnityEngineInternal
{
    class WebRequestUtils
    {
        static /*0x0*/ System.Text.RegularExpressions.Regex domainRegex;

        static /*0x1c85ee0*/ WebRequestUtils();
        static /*0x1c85558*/ string RedirectTo(string baseUri, string redirectUri);
        static /*0x1c8564c*/ string MakeInitialUrl(string targetUrl, string localUrl);
        static /*0x1c859e4*/ string MakeUriString(System.Uri targetUri, string targetUrl, bool prependProtocol);
        static /*0x1c85dd8*/ string URLDecode(string encoded);
    }
}

namespace UnityEngine
{
    class WWWForm
    {
        static /*0x0*/ byte[] dDash;
        static /*0x8*/ byte[] crlf;
        static /*0x10*/ byte[] contentTypeHeader;
        static /*0x18*/ byte[] dispositionHeader;
        static /*0x20*/ byte[] endQuote;
        static /*0x28*/ byte[] fileNameField;
        static /*0x30*/ byte[] ampersand;
        static /*0x38*/ byte[] equal;
        /*0x10*/ System.Collections.Generic.List<System.Byte[]> formData;
        /*0x18*/ System.Collections.Generic.List<string> fieldNames;
        /*0x20*/ System.Collections.Generic.List<string> fileNames;
        /*0x28*/ System.Collections.Generic.List<string> types;
        /*0x30*/ byte[] boundary;
        /*0x38*/ bool containsFiles;

        static /*0x1c87768*/ WWWForm();
        static /*0x1c85f70*/ System.Text.Encoding get_DefaultEncoding();
        /*0x1c85f78*/ WWWForm();
        /*0x1c860fc*/ void AddField(string fieldName, string value);
        /*0x1c86134*/ void AddField(string fieldName, string value, System.Text.Encoding e);
        /*0x1c8639c*/ System.Collections.Generic.Dictionary<string, string> get_headers();
        /*0x1c864dc*/ byte[] get_data();
    }

    class WWWTranscoder
    {
        static /*0x0*/ byte[] ucHexChars;
        static /*0x8*/ byte[] lcHexChars;
        static /*0x10*/ byte urlEscapeChar;
        static /*0x18*/ byte[] urlSpace;
        static /*0x20*/ byte[] dataSpace;
        static /*0x28*/ byte[] urlForbidden;
        static /*0x30*/ byte qpEscapeChar;
        static /*0x38*/ byte[] qpSpace;
        static /*0x40*/ byte[] qpForbidden;

        static /*0x1c88228*/ WWWTranscoder();
        static /*0x1c879a0*/ byte Hex2Byte(byte[] b, int offset);
        static /*0x1c87a4c*/ void Byte2Hex(byte b, byte[] hexChars, ref byte byte0, ref byte byte1);
        static /*0x1c87700*/ byte[] DataEncode(byte[] toEncode);
        static /*0x1c8760c*/ string QPEncode(string toEncode, System.Text.Encoding e);
        static /*0x1c87aa0*/ byte[] Encode(byte[] input, byte escapeChar, byte[] space, byte[] forbidden, bool uppercase);
        static /*0x1c87e4c*/ bool ByteArrayContains(byte[] array, byte b);
        static /*0x1c85e7c*/ byte[] URLDecode(byte[] toEncode);
        static /*0x1c88178*/ bool ByteSubArrayEquals(byte[] array, int index, byte[] comperand);
        static /*0x1c87e98*/ byte[] Decode(byte[] input, byte escapeChar, byte[] space);
        static /*0x1c874dc*/ bool SevenBitClean(string s, System.Text.Encoding e);
        static /*0x1c881f0*/ bool SevenBitClean(byte* input, int inputLength);
    }

    namespace Networking
    {
        class UnityWebRequestAsyncOperation : UnityEngine.AsyncOperation
        {
            /*0x20*/ UnityEngine.Networking.UnityWebRequest <webRequest>k__BackingField;

            /*0x1c8845c*/ UnityWebRequestAsyncOperation();
            /*0x1c8844c*/ UnityEngine.Networking.UnityWebRequest get_webRequest();
            /*0x1c88454*/ void set_webRequest(UnityEngine.Networking.UnityWebRequest value);
        }

        class UnityWebRequest : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;
            /*0x18*/ UnityEngine.Networking.DownloadHandler m_DownloadHandler;
            /*0x20*/ UnityEngine.Networking.UploadHandler m_UploadHandler;
            /*0x28*/ UnityEngine.Networking.CertificateHandler m_CertificateHandler;
            /*0x30*/ System.Uri m_Uri;
            /*0x38*/ bool <disposeCertificateHandlerOnDispose>k__BackingField;
            /*0x39*/ bool <disposeDownloadHandlerOnDispose>k__BackingField;
            /*0x3a*/ bool <disposeUploadHandlerOnDispose>k__BackingField;

            static /*0x1c88464*/ string GetWebErrorString(UnityEngine.Networking.UnityWebRequest.UnityWebRequestError err);
            static /*0x1c884a0*/ string GetHTTPStatusString(long responseCode);
            static /*0x1c88518*/ nint Create();
            static /*0x1c89b4c*/ UnityEngine.Networking.UnityWebRequest Get(string uri);
            static /*0x1c89c40*/ UnityEngine.Networking.UnityWebRequest Post(string uri, UnityEngine.WWWForm formData);
            static /*0x1c89cd0*/ void SetupPost(UnityEngine.Networking.UnityWebRequest request, UnityEngine.WWWForm formData);
            /*0x1c88688*/ UnityWebRequest(string url, string method);
            /*0x1c88910*/ UnityWebRequest(string url, string method, UnityEngine.Networking.DownloadHandler downloadHandler, UnityEngine.Networking.UploadHandler uploadHandler);
            /*0x1c884dc*/ bool get_disposeCertificateHandlerOnDispose();
            /*0x1c884e4*/ void set_disposeCertificateHandlerOnDispose(bool value);
            /*0x1c884f0*/ bool get_disposeDownloadHandlerOnDispose();
            /*0x1c884f8*/ void set_disposeDownloadHandlerOnDispose(bool value);
            /*0x1c88504*/ bool get_disposeUploadHandlerOnDispose();
            /*0x1c8850c*/ void set_disposeUploadHandlerOnDispose(bool value);
            /*0x1c88540*/ void Release();
            /*0x1c8857c*/ void InternalDestroy();
            /*0x1c88674*/ void InternalSetDefaults();
            /*0x1c88bd4*/ void Finalize();
            /*0x1c88cd0*/ void Dispose();
            /*0x1c88c70*/ void DisposeHandlers();
            /*0x1c88de4*/ UnityEngine.Networking.UnityWebRequestAsyncOperation BeginWebRequest();
            /*0x1c88e20*/ UnityEngine.Networking.UnityWebRequestAsyncOperation SendWebRequest();
            /*0x1c88638*/ void Abort();
            /*0x1c88e68*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetMethod(UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod methodType);
            /*0x1c88eac*/ void InternalSetMethod(UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod methodType);
            /*0x1c88ff4*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetCustomMethod(string customMethodName);
            /*0x1c89038*/ void InternalSetCustomMethod(string customMethodName);
            /*0x1c8878c*/ void set_method(string value);
            /*0x1c89144*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError GetError();
            /*0x1c89180*/ string get_error();
            /*0x1c8939c*/ string get_url();
            /*0x1c88704*/ void set_url(string value);
            /*0x1c893d8*/ string GetUrl();
            /*0x1c89520*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetUrl(string url);
            /*0x1c89414*/ void InternalSetUrl(string url);
            /*0x1c89360*/ long get_responseCode();
            /*0x1c88fb8*/ bool get_isModifiable();
            /*0x1c89564*/ bool get_isDone();
            /*0x1c895ac*/ bool get_isNetworkError();
            /*0x1c89324*/ UnityEngine.Networking.UnityWebRequest.Result get_result();
            /*0x1c895f4*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetChunked(bool chunked);
            /*0x1c89638*/ void set_chunkedTransfer(bool value);
            /*0x1c89744*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError InternalSetRequestHeader(string name, string value);
            /*0x1c89798*/ void SetRequestHeader(string name, string value);
            /*0x1c89924*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetUploadHandler(UnityEngine.Networking.UploadHandler uh);
            /*0x1c88d40*/ UnityEngine.Networking.UploadHandler get_uploadHandler();
            /*0x1c88ac4*/ void set_uploadHandler(UnityEngine.Networking.UploadHandler value);
            /*0x1c89968*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetDownloadHandler(UnityEngine.Networking.DownloadHandler dh);
            /*0x1c88d38*/ UnityEngine.Networking.DownloadHandler get_downloadHandler();
            /*0x1c889b4*/ void set_downloadHandler(UnityEngine.Networking.DownloadHandler value);
            /*0x1c88d48*/ UnityEngine.Networking.CertificateHandler get_certificateHandler();
            /*0x1c899ac*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetTimeoutMsec(int timeout);
            /*0x1c899f0*/ void set_timeout(int value);

            enum UnityWebRequestMethod
            {
                Get = 0,
                Post = 1,
                Put = 2,
                Head = 3,
                Custom = 4,
            }

            enum UnityWebRequestError
            {
                OK = 0,
                Unknown = 1,
                SDKError = 2,
                UnsupportedProtocol = 3,
                MalformattedUrl = 4,
                CannotResolveProxy = 5,
                CannotResolveHost = 6,
                CannotConnectToHost = 7,
                AccessDenied = 8,
                GenericHttpError = 9,
                WriteError = 10,
                ReadError = 11,
                OutOfMemory = 12,
                Timeout = 13,
                HTTPPostError = 14,
                SSLCannotConnect = 15,
                Aborted = 16,
                TooManyRedirects = 17,
                ReceivedNoData = 18,
                SSLNotSupported = 19,
                FailedToSendData = 20,
                FailedToReceiveData = 21,
                SSLCertificateError = 22,
                SSLCipherNotAvailable = 23,
                SSLCACertError = 24,
                UnrecognizedContentEncoding = 25,
                LoginFailed = 26,
                SSLShutdownFailed = 27,
                NoInternetConnection = 28,
            }

            enum Result
            {
                InProgress = 0,
                Success = 1,
                ConnectionError = 2,
                ProtocolError = 3,
                DataProcessingError = 4,
            }
        }

        class DownloadHandler : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;

            static T GetCheckedDownloader<T>(UnityEngine.Networking.UnityWebRequest www);
            static /*0x1c8a52c*/ byte* InternalGetByteArray(UnityEngine.Networking.DownloadHandler dh, ref int length);
            static /*0x1c8a0e4*/ byte[] InternalGetByteArray(UnityEngine.Networking.DownloadHandler dh);
            static /*0x1c8a570*/ Unity.Collections.NativeArray<byte> InternalGetNativeArray(UnityEngine.Networking.DownloadHandler dh, ref Unity.Collections.NativeArray<byte> nativeArray);
            static /*0x1c8a62c*/ void DisposeNativeArray(ref Unity.Collections.NativeArray<byte> data);
            static /*0x1c8a680*/ void CreateNativeArrayForNativeData(ref Unity.Collections.NativeArray<byte> data, byte* bytes, int length);
            /*0x1c89f84*/ DownloadHandler();
            /*0x1c89f48*/ void Release();
            /*0x1c89f8c*/ void Finalize();
            /*0x1c8a028*/ void Dispose();
            /*0x1c8a0bc*/ byte[] get_data();
            /*0x1c8a0c8*/ string get_text();
            /*0x1c8a0d4*/ Unity.Collections.NativeArray<byte> GetNativeData();
            /*0x1c8a0e0*/ byte[] GetData();
            /*0x1c8a188*/ string GetText();
            /*0x1c8a270*/ System.Text.Encoding GetTextEncoder();
            /*0x1c8a4e0*/ string GetContentType();
            /*0x1c8a51c*/ void ReceiveContentLengthHeader(ulong contentLength);
            /*0x1c8a528*/ void ReceiveContentLength(int contentLength);
        }

        class DownloadHandlerBuffer : UnityEngine.Networking.DownloadHandler
        {
            /*0x18*/ Unity.Collections.NativeArray<byte> m_NativeData;

            static /*0x1c8a6e8*/ nint Create(UnityEngine.Networking.DownloadHandlerBuffer obj);
            /*0x1c89bf4*/ DownloadHandlerBuffer();
            /*0x1c8a724*/ void InternalCreateBuffer();
            /*0x1c8a768*/ Unity.Collections.NativeArray<byte> GetNativeData();
            /*0x1c8a770*/ void Dispose();
        }

        class UploadHandler : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;

            /*0x1c8a7c8*/ UploadHandler();
            /*0x1c8a78c*/ void Release();
            /*0x1c8a7d0*/ void Finalize();
            /*0x1c8a86c*/ void Dispose();
            /*0x1c8a900*/ void set_contentType(string value);
            /*0x1c8a90c*/ void SetContentType(string newContentType);
            /*0x1c8a950*/ void InternalSetContentType(string newContentType);
        }

        class UploadHandlerRaw : UnityEngine.Networking.UploadHandler
        {
            /*0x18*/ Unity.Collections.NativeArray<byte> m_Payload;

            static /*0x1c8a994*/ nint Create(UnityEngine.Networking.UploadHandlerRaw self, byte* data, int dataLength);
            /*0x1c89ebc*/ UploadHandlerRaw(byte[] data);
            /*0x1c8a9e8*/ UploadHandlerRaw(Unity.Collections.NativeArray<byte> data, bool transferOwnership);
            /*0x1c8aafc*/ void Dispose();
        }

        class CertificateHandler
        {
            /*0x10*/ nint m_Ptr;

            /*0x1c8ab74*/ void Release();
            /*0x1c8abb0*/ bool ValidateCertificate(byte[] certificateData);
            /*0x1c8abb8*/ bool ValidateCertificateNative(byte[] certificateData);
            /*0x1c88d50*/ void Dispose();
        }
    }
}
