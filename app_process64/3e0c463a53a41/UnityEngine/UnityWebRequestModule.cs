class <Module>
{
}

namespace UnityEngineInternal
{
    class WebRequestUtils
    {
        static /*0x0*/ System.Text.RegularExpressions.Regex domainRegex;

        static /*0x81ca5b4*/ WebRequestUtils();
        static /*0x81c9c74*/ string RedirectTo(string baseUri, string redirectUri);
        static /*0x81c9d60*/ string MakeInitialUrl(string targetUrl, string localUrl);
        static /*0x81ca0d0*/ string MakeUriString(System.Uri targetUri, string targetUrl, bool prependProtocol);
        static /*0x81ca4ac*/ string URLDecode(string encoded);
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

        static /*0x81cb860*/ WWWForm();
        static /*0x81ca650*/ System.Text.Encoding get_DefaultEncoding();
        /*0x81ca658*/ System.Collections.Generic.Dictionary<string, string> get_headers();
        /*0x81ca7a4*/ byte[] get_data();
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

        static /*0x81cc440*/ WWWTranscoder();
        static /*0x81cbaf8*/ byte Hex2Byte(byte[] b, int offset);
        static /*0x81cbba4*/ void Byte2Hex(byte b, byte[] hexChars, ref byte byte0, ref byte byte1);
        static /*0x81cb7f8*/ byte[] DataEncode(byte[] toEncode);
        static /*0x81cb704*/ string QPEncode(string toEncode, System.Text.Encoding e);
        static /*0x81cbbf8*/ byte[] Encode(byte[] input, byte escapeChar, byte[] space, byte[] forbidden, bool uppercase);
        static /*0x81cbfd4*/ bool ByteArrayContains(byte[] array, byte b);
        static /*0x81ca550*/ byte[] URLDecode(byte[] toEncode);
        static /*0x81cc354*/ bool ByteSubArrayEquals(byte[] array, int index, byte[] comperand);
        static /*0x81cc03c*/ byte[] Decode(byte[] input, byte escapeChar, byte[] space);
        static /*0x81cb590*/ bool SevenBitClean(string s, System.Text.Encoding e);
        static /*0x81cc3e4*/ bool SevenBitClean(byte* input, int inputLength);
    }

    namespace Networking
    {
        class CertificateHandler
        {
            /*0x10*/ nint m_Ptr;

            static /*0x81cc710*/ void ReleaseFromScripting_Injected(nint _unity_self);
            /*0x81cc6c0*/ void ReleaseFromScripting();
            /*0x81cc74c*/ bool ValidateCertificate(byte[] certificateData);
            /*0x81cc754*/ bool ValidateCertificateNative(byte[] certificateData);
            /*0x81cc760*/ void Dispose();

            class BindingsMarshaller
            {
                static /*0x81cc780*/ nint ConvertToNative(UnityEngine.Networking.CertificateHandler handler);
            }
        }

        class DownloadHandler : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;

            static /*0x81ccf0c*/ byte* InternalGetByteArray(UnityEngine.Networking.DownloadHandler dh, ref int length);
            static /*0x81cca34*/ byte[] InternalGetByteArray(UnityEngine.Networking.DownloadHandler dh);
            static /*0x81ccfa0*/ Unity.Collections.NativeArray<byte> InternalGetNativeArray(UnityEngine.Networking.DownloadHandler dh, ref Unity.Collections.NativeArray<byte> nativeArray);
            static /*0x81cd080*/ void DisposeNativeArray(ref Unity.Collections.NativeArray<byte> data);
            static /*0x81cd0c4*/ void CreateNativeArrayForNativeData(ref Unity.Collections.NativeArray<byte> data, byte* bytes, int length);
            static /*0x81cc7e8*/ void ReleaseFromScripting_Injected(nint _unity_self);
            static /*0x81cc9c8*/ void GetErrorMsg_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x81ccea4*/ void GetContentType_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x81ccf5c*/ byte* InternalGetByteArray_Injected(nint dh, ref int length);
            /*0x81cc824*/ DownloadHandler();
            /*0x81cc798*/ void ReleaseFromScripting();
            /*0x81cc82c*/ void Finalize();
            /*0x81cc8c8*/ void Dispose();
            /*0x81cc8e8*/ string get_error();
            /*0x81cc8ec*/ string GetErrorMsg();
            /*0x81cca0c*/ byte[] get_data();
            /*0x81cca18*/ string get_text();
            /*0x81cca24*/ Unity.Collections.NativeArray<byte> GetNativeData();
            /*0x81cca30*/ byte[] GetData();
            /*0x81ccab8*/ string GetText();
            /*0x81ccb78*/ System.Text.Encoding GetTextEncoder();
            /*0x81ccdc8*/ string GetContentType();
            /*0x81ccee8*/ bool ReceiveData(byte[] data, int dataLength);
            /*0x81ccef0*/ void ReceiveContentLengthHeader(ulong contentLength);
            /*0x81ccefc*/ void ReceiveContentLength(int contentLength);
            /*0x81ccf00*/ void CompleteContent();
            /*0x81ccf04*/ float GetProgress();

            class BindingsMarshaller
            {
                static /*0x81cd12c*/ nint ConvertToNative(UnityEngine.Networking.DownloadHandler handler);
            }
        }

        class DownloadHandlerBuffer : UnityEngine.Networking.DownloadHandler
        {
            /*0x18*/ Unity.Collections.NativeArray<byte> m_NativeData;

            static /*0x81cd144*/ nint Create(UnityEngine.Networking.DownloadHandlerBuffer obj);
            /*0x81cd1c4*/ DownloadHandlerBuffer();
            /*0x81cd180*/ void InternalCreateBuffer();
            /*0x81cd210*/ Unity.Collections.NativeArray<byte> GetNativeData();
            /*0x81cd218*/ void Dispose();
        }

        class UnityWebRequestAsyncOperation : UnityEngine.AsyncOperation
        {
            /*0x20*/ UnityEngine.Networking.UnityWebRequest <webRequest>k__BackingField;

            /*0x81cd274*/ UnityWebRequestAsyncOperation(nint ptr);
            /*0x81cd27c*/ UnityEngine.Networking.UnityWebRequest get_webRequest();
            /*0x81cd284*/ void set_webRequest(UnityEngine.Networking.UnityWebRequest value);

            class BindingsMarshaller
            {
                static /*0x81cd28c*/ UnityEngine.Networking.UnityWebRequestAsyncOperation ConvertToManaged(nint ptr);
            }
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

            static /*0x81cd2e8*/ string GetWebErrorString(UnityEngine.Networking.UnityWebRequest.UnityWebRequestError err);
            static /*0x81cd3e8*/ string GetHTTPStatusString(long responseCode);
            static /*0x81cd524*/ nint Create();
            static /*0x81cfd2c*/ UnityEngine.Networking.UnityWebRequest Get(string uri);
            static /*0x81cfdd0*/ UnityEngine.Networking.UnityWebRequest Post(string uri, UnityEngine.WWWForm formData);
            static /*0x81cfe58*/ void SetupPost(UnityEngine.Networking.UnityWebRequest request, UnityEngine.WWWForm formData);
            static /*0x81cd3a4*/ void GetWebErrorString_Injected(UnityEngine.Networking.UnityWebRequest.UnityWebRequestError err, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x81cd4a4*/ void GetHTTPStatusString_Injected(long responseCode, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x81cd59c*/ void Release_Injected(nint _unity_self);
            static /*0x81cdf00*/ nint BeginWebRequest_Injected(nint _unity_self);
            static /*0x81cdf74*/ void Abort_Injected(nint _unity_self);
            static /*0x81ce008*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetMethod_Injected(nint _unity_self, UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod methodType);
            static /*0x81ce2f4*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetCustomMethod_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper customMethodName);
            static /*0x81ce444*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod GetMethod_Injected(nint _unity_self);
            static /*0x81ce55c*/ void GetCustomMethod_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x81ce6b8*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError GetError_Injected(nint _unity_self);
            static /*0x81ce9f0*/ void GetUrl_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x81cebd0*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetUrl_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper url);
            static /*0x81cec14*/ long get_responseCode_Injected(nint _unity_self);
            static /*0x81ceca0*/ bool IsExecuting_Injected(nint _unity_self);
            static /*0x81cecdc*/ bool get_isModifiable_Injected(nint _unity_self);
            static /*0x81ced30*/ UnityEngine.Networking.UnityWebRequest.Result get_result_Injected(nint _unity_self);
            static /*0x81cedbc*/ float GetDownloadProgress_Injected(nint _unity_self);
            static /*0x81cee7c*/ ulong get_downloadedBytes_Injected(nint _unity_self);
            static /*0x81cef10*/ void SetRedirectLimitFromScripting_Injected(nint _unity_self, int limit);
            static /*0x81cefb0*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetChunked_Injected(nint _unity_self, bool chunked);
            static /*0x81cf31c*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError InternalSetRequestHeader_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.Bindings.ManagedSpanWrapper value);
            static /*0x81cf670*/ void GetResponseHeader_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x81cf714*/ string[] GetResponseHeaderKeys_Injected(nint _unity_self);
            static /*0x81cf930*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetUploadHandler_Injected(nint _unity_self, nint uh);
            static /*0x81cf9d4*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetDownloadHandler_Injected(nint _unity_self, nint dh);
            static /*0x81cfa78*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetCertificateHandler_Injected(nint _unity_self, nint ch);
            static /*0x81cfbdc*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetTimeoutMsec_Injected(nint _unity_self, int timeout);
            /*0x81cd664*/ UnityWebRequest(string url);
            /*0x81cd750*/ UnityWebRequest(string url, string method);
            /*0x81cd94c*/ UnityWebRequest(string url, string method, UnityEngine.Networking.DownloadHandler downloadHandler, UnityEngine.Networking.UploadHandler uploadHandler);
            /*0x81cdb80*/ UnityWebRequest(System.Uri uri, string method, UnityEngine.Networking.DownloadHandler downloadHandler, UnityEngine.Networking.UploadHandler uploadHandler);
            /*0x81cd4e8*/ bool get_disposeCertificateHandlerOnDispose();
            /*0x81cd4f0*/ void set_disposeCertificateHandlerOnDispose(bool value);
            /*0x81cd4fc*/ bool get_disposeDownloadHandlerOnDispose();
            /*0x81cd504*/ void set_disposeDownloadHandlerOnDispose(bool value);
            /*0x81cd510*/ bool get_disposeUploadHandlerOnDispose();
            /*0x81cd518*/ void set_disposeUploadHandlerOnDispose(bool value);
            /*0x81cd54c*/ void Release();
            /*0x81cd5d8*/ void InternalDestroy();
            /*0x81cd650*/ void InternalSetDefaults();
            /*0x81cdd14*/ void Finalize();
            /*0x81cde1c*/ void Dispose();
            /*0x81cddb0*/ void DisposeHandlers();
            /*0x81cde9c*/ UnityEngine.Networking.UnityWebRequestAsyncOperation BeginWebRequest();
            /*0x81cdf3c*/ UnityEngine.Networking.UnityWebRequestAsyncOperation SendWebRequest();
            /*0x81cd600*/ void Abort();
            /*0x81cdfb0*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetMethod(UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod methodType);
            /*0x81ce04c*/ void InternalSetMethod(UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod methodType);
            /*0x81ce158*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetCustomMethod(string customMethodName);
            /*0x81ce338*/ void InternalSetCustomMethod(string customMethodName);
            /*0x81ce3f4*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod GetMethod();
            /*0x81ce480*/ string GetCustomMethod();
            /*0x81ce5a0*/ string get_method();
            /*0x81cd7cc*/ void set_method(string value);
            /*0x81ce668*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError GetError();
            /*0x81ce6f4*/ string get_error();
            /*0x81ce854*/ string get_url();
            /*0x81cd6c8*/ void set_url(string value);
            /*0x81cdc24*/ void set_uri(System.Uri value);
            /*0x81ce858*/ string GetUrl();
            /*0x81cea34*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetUrl(string url);
            /*0x81ce934*/ void InternalSetUrl(string url);
            /*0x81ce804*/ long get_responseCode();
            /*0x81cec50*/ bool IsExecuting();
            /*0x81ce108*/ bool get_isModifiable();
            /*0x81ced18*/ bool get_isDone();
            /*0x81ce7b4*/ UnityEngine.Networking.UnityWebRequest.Result get_result();
            /*0x81ced6c*/ float GetDownloadProgress();
            /*0x81cedf8*/ float get_downloadProgress();
            /*0x81cee2c*/ ulong get_downloadedBytes();
            /*0x81ceeb8*/ void SetRedirectLimitFromScripting(int limit);
            /*0x81cef54*/ void set_redirectLimit(int value);
            /*0x81cef58*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetChunked(bool chunked);
            /*0x81ceff4*/ void set_chunkedTransfer(bool value);
            /*0x81cf0b0*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError InternalSetRequestHeader(string name, string value);
            /*0x81cf370*/ void SetRequestHeader(string name, string value);
            /*0x81cf4a0*/ string GetResponseHeader(string name);
            /*0x81cf6c4*/ string[] GetResponseHeaderKeys();
            /*0x81cf750*/ System.Collections.Generic.Dictionary<string, string> GetResponseHeaders();
            /*0x81cf8d0*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetUploadHandler(UnityEngine.Networking.UploadHandler uh);
            /*0x81cde8c*/ UnityEngine.Networking.UploadHandler get_uploadHandler();
            /*0x81cdab8*/ void set_uploadHandler(UnityEngine.Networking.UploadHandler value);
            /*0x81cf974*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetDownloadHandler(UnityEngine.Networking.DownloadHandler dh);
            /*0x81cde84*/ UnityEngine.Networking.DownloadHandler get_downloadHandler();
            /*0x81cd9f0*/ void set_downloadHandler(UnityEngine.Networking.DownloadHandler value);
            /*0x81cfa18*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetCertificateHandler(UnityEngine.Networking.CertificateHandler ch);
            /*0x81cde94*/ UnityEngine.Networking.CertificateHandler get_certificateHandler();
            /*0x81cfabc*/ void set_certificateHandler(UnityEngine.Networking.CertificateHandler value);
            /*0x81cfb84*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetTimeoutMsec(int timeout);
            /*0x81cfc20*/ void set_timeout(int value);

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
                OKCached = 1,
                Unknown = 2,
                SDKError = 3,
                UnsupportedProtocol = 4,
                MalformattedUrl = 5,
                CannotResolveProxy = 6,
                CannotResolveHost = 7,
                CannotConnectToHost = 8,
                AccessDenied = 9,
                GenericHttpError = 10,
                WriteError = 11,
                ReadError = 12,
                OutOfMemory = 13,
                Timeout = 14,
                HTTPPostError = 15,
                SSLCannotConnect = 16,
                Aborted = 17,
                TooManyRedirects = 18,
                ReceivedNoData = 19,
                SSLNotSupported = 20,
                FailedToSendData = 21,
                FailedToReceiveData = 22,
                SSLCertificateError = 23,
                SSLCipherNotAvailable = 24,
                SSLCACertError = 25,
                UnrecognizedContentEncoding = 26,
                LoginFailed = 27,
                SSLShutdownFailed = 28,
                RedirectLimitInvalid = 29,
                InvalidRedirect = 30,
                CannotModifyRequest = 31,
                HeaderNameContainsInvalidCharacters = 32,
                HeaderValueContainsInvalidCharacters = 33,
                CannotOverrideSystemHeaders = 34,
                AlreadySent = 35,
                InvalidMethod = 36,
                NotImplemented = 37,
                NoInternetConnection = 38,
                DataProcessingError = 39,
                InsecureConnectionNotAllowed = 40,
            }

            enum Result
            {
                InProgress = 0,
                Success = 1,
                ConnectionError = 2,
                ProtocolError = 3,
                DataProcessingError = 4,
            }

            class BindingsMarshaller
            {
                static /*0x81d00c4*/ nint ConvertToNative(UnityEngine.Networking.UnityWebRequest unityWebRequest);
            }
        }

        class UploadHandler : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;

            static /*0x81d012c*/ void ReleaseFromScripting_Injected(nint _unity_self);
            static /*0x81d03cc*/ void InternalSetContentType_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper newContentType);
            /*0x81d0168*/ UploadHandler();
            /*0x81d00dc*/ void ReleaseFromScripting();
            /*0x81d0170*/ void Finalize();
            /*0x81d020c*/ void Dispose();
            /*0x81d022c*/ void set_contentType(string value);
            /*0x81d0238*/ void SetContentType(string newContentType);
            /*0x81d023c*/ void InternalSetContentType(string newContentType);

            class BindingsMarshaller
            {
                static /*0x81d0410*/ nint ConvertToNative(UnityEngine.Networking.UploadHandler uploadHandler);
            }
        }

        class UploadHandlerRaw : UnityEngine.Networking.UploadHandler
        {
            /*0x18*/ Unity.Collections.NativeArray<byte> m_Payload;

            static /*0x81d0428*/ nint Create(UnityEngine.Networking.UploadHandlerRaw self, byte* data, int dataLength);
            /*0x81d0038*/ UploadHandlerRaw(byte[] data);
            /*0x81d047c*/ UploadHandlerRaw(Unity.Collections.NativeArray<byte> data, bool transferOwnership);
            /*0x81d0570*/ void Dispose();
        }
    }
}
