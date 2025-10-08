class <Module>
{
}

namespace UnityEngineInternal
{
    class WebRequestUtils
    {
        static /*0x0*/ System.Text.RegularExpressions.Regex domainRegex;

        static /*0x40fbf54*/ WebRequestUtils();
        static /*0x40fb610*/ string RedirectTo(string baseUri, string redirectUri);
        static /*0x40fb6fc*/ string MakeInitialUrl(string targetUrl, string localUrl);
        static /*0x40fba6c*/ string MakeUriString(System.Uri targetUri, string targetUrl, bool prependProtocol);
        static /*0x40fbe4c*/ string URLDecode(string encoded);
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

        static /*0x40fbff8*/ WWWForm();
        static /*0x40fbff0*/ System.Text.Encoding get_DefaultEncoding();
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

        static /*0x40fcb70*/ WWWTranscoder();
        static /*0x40fc290*/ byte Hex2Byte(byte[] b, int offset);
        static /*0x40fc34c*/ void Byte2Hex(byte b, byte[] hexChars, ref byte byte0, ref byte byte1);
        static /*0x40fc3a0*/ byte[] URLEncode(byte[] toEncode);
        static /*0x40fc40c*/ byte[] Encode(byte[] input, byte escapeChar, byte[] space, byte[] forbidden, bool uppercase);
        static /*0x40fc7a8*/ bool ByteArrayContains(byte[] array, byte b);
        static /*0x40fbef0*/ byte[] URLDecode(byte[] toEncode);
        static /*0x40fcae8*/ bool ByteSubArrayEquals(byte[] array, int index, byte[] comperand);
        static /*0x40fc814*/ byte[] Decode(byte[] input, byte escapeChar, byte[] space);
    }

    namespace Networking
    {
        class CertificateHandler : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;

            static /*0x40fcdf0*/ nint Create(UnityEngine.Networking.CertificateHandler obj);
            static /*0x40fce7c*/ void ReleaseFromScripting_Injected(nint _unity_self);
            /*0x40fceb8*/ CertificateHandler();
            /*0x40fce2c*/ void ReleaseFromScripting();
            /*0x40fcf04*/ void Finalize();
            /*0x40fcfb8*/ bool ValidateCertificate(byte[] certificateData);
            /*0x40fcfc0*/ bool ValidateCertificateNative(byte[] certificateData);
            /*0x40fcf98*/ void Dispose();

            class BindingsMarshaller
            {
                static /*0x40fcfcc*/ nint ConvertToNative(UnityEngine.Networking.CertificateHandler handler);
            }
        }

        class DownloadHandler : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;

            static /*0x1ffc854*/ T GetCheckedDownloader<T>(UnityEngine.Networking.UnityWebRequest www);
            static /*0x40fd644*/ byte* InternalGetByteArray(UnityEngine.Networking.DownloadHandler dh, ref int length);
            static /*0x40fd148*/ byte[] InternalGetByteArray(UnityEngine.Networking.DownloadHandler dh);
            static /*0x40fd6d8*/ Unity.Collections.NativeArray<byte> InternalGetNativeArray(UnityEngine.Networking.DownloadHandler dh, ref Unity.Collections.NativeArray<byte> nativeArray);
            static /*0x40fd7c4*/ void DisposeNativeArray(ref Unity.Collections.NativeArray<byte> data);
            static /*0x40fd808*/ void CreateNativeArrayForNativeData(ref Unity.Collections.NativeArray<byte> data, byte* bytes, int length);
            static /*0x40fd030*/ void ReleaseFromScripting_Injected(nint _unity_self);
            static /*0x40fd5dc*/ void GetContentType_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x40fd694*/ byte* InternalGetByteArray_Injected(nint dh, ref int length);
            /*0x40fd06c*/ DownloadHandler();
            /*0x40fcfe0*/ void ReleaseFromScripting();
            /*0x40fd074*/ void Finalize();
            /*0x40fd100*/ void Dispose();
            /*0x40fd120*/ byte[] get_data();
            /*0x40fd12c*/ string get_text();
            /*0x40fd138*/ Unity.Collections.NativeArray<byte> GetNativeData();
            /*0x40fd144*/ byte[] GetData();
            /*0x40fd1cc*/ string GetText();
            /*0x40fd28c*/ System.Text.Encoding GetTextEncoder();
            /*0x40fd4dc*/ string GetContentType();
            /*0x40fd620*/ bool ReceiveData(byte[] data, int dataLength);
            /*0x40fd628*/ void ReceiveContentLengthHeader(ulong contentLength);
            /*0x40fd634*/ void ReceiveContentLength(int contentLength);
            /*0x40fd638*/ void CompleteContent();
            /*0x40fd63c*/ float GetProgress();

            class BindingsMarshaller
            {
                static /*0x40fd870*/ nint ConvertToNative(UnityEngine.Networking.DownloadHandler handler);
            }
        }

        class DownloadHandlerBuffer : UnityEngine.Networking.DownloadHandler
        {
            /*0x18*/ Unity.Collections.NativeArray<byte> m_NativeData;

            static /*0x40fd884*/ nint Create(UnityEngine.Networking.DownloadHandlerBuffer obj);
            /*0x40fd904*/ DownloadHandlerBuffer();
            /*0x40fd8c0*/ void InternalCreateBuffer();
            /*0x40fd950*/ Unity.Collections.NativeArray<byte> GetNativeData();
            /*0x40fd958*/ void Dispose();
        }

        class UnityWebRequestAsyncOperation : UnityEngine.AsyncOperation
        {
            /*0x20*/ UnityEngine.Networking.UnityWebRequest <webRequest>k__BackingField;

            /*0x40fd9b0*/ UnityWebRequestAsyncOperation(nint ptr);
            /*0x40fd9b8*/ UnityEngine.Networking.UnityWebRequest get_webRequest();
            /*0x40fd9c0*/ void set_webRequest(UnityEngine.Networking.UnityWebRequest value);

            class BindingsMarshaller
            {
                static /*0x40fd9c8*/ UnityEngine.Networking.UnityWebRequestAsyncOperation ConvertToManaged(nint ptr);
            }
        }

        class UnityWebRequest : System.IDisposable
        {
            static string kHttpVerbGET = "GET";
            static string kHttpVerbHEAD = "HEAD";
            static string kHttpVerbPOST = "POST";
            static string kHttpVerbPUT = "PUT";
            static string kHttpVerbCREATE = "CREATE";
            static string kHttpVerbDELETE = "DELETE";
            /*0x10*/ nint m_Ptr;
            /*0x18*/ UnityEngine.Networking.DownloadHandler m_DownloadHandler;
            /*0x20*/ UnityEngine.Networking.UploadHandler m_UploadHandler;
            /*0x28*/ UnityEngine.Networking.CertificateHandler m_CertificateHandler;
            /*0x30*/ System.Uri m_Uri;
            /*0x38*/ bool <disposeCertificateHandlerOnDispose>k__BackingField;
            /*0x39*/ bool <disposeDownloadHandlerOnDispose>k__BackingField;
            /*0x3a*/ bool <disposeUploadHandlerOnDispose>k__BackingField;

            static /*0x40fda24*/ string GetWebErrorString(UnityEngine.Networking.UnityWebRequest.UnityWebRequestError err);
            static /*0x40fdb34*/ string GetHTTPStatusString(long responseCode);
            static /*0x40fdc74*/ nint Create();
            static /*0x40ff56c*/ UnityEngine.Networking.UnityWebRequest Get(string uri);
            static /*0x40ff610*/ string EscapeURL(string s);
            static /*0x40ff630*/ string EscapeURL(string s, System.Text.Encoding e);
            static /*0x40fdaf0*/ void GetWebErrorString_Injected(UnityEngine.Networking.UnityWebRequest.UnityWebRequestError err, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x40fdc00*/ void GetHTTPStatusString_Injected(long responseCode, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x40fdcec*/ void Release_Injected(nint _unity_self);
            static /*0x40fe424*/ nint BeginWebRequest_Injected(nint _unity_self);
            static /*0x40fe498*/ void Abort_Injected(nint _unity_self);
            static /*0x40fe52c*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetMethod_Injected(nint _unity_self, UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod methodType);
            static /*0x40fe818*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetCustomMethod_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper customMethodName);
            static /*0x40fe968*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError GetError_Injected(nint _unity_self);
            static /*0x40fecc4*/ void GetUrl_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x40feea4*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetUrl_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper url);
            static /*0x40feee8*/ long get_responseCode_Injected(nint _unity_self);
            static /*0x40fef24*/ bool get_isModifiable_Injected(nint _unity_self);
            static /*0x40fefa8*/ UnityEngine.Networking.UnityWebRequest.Result get_result_Injected(nint _unity_self);
            static /*0x40ff034*/ ulong get_downloadedBytes_Injected(nint _unity_self);
            static /*0x40ff0c8*/ void SetRedirectLimitFromScripting_Injected(nint _unity_self, int limit);
            static /*0x40ff170*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetUploadHandler_Injected(nint _unity_self, nint uh);
            static /*0x40ff214*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetDownloadHandler_Injected(nint _unity_self, nint dh);
            static /*0x40ff2b8*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetCertificateHandler_Injected(nint _unity_self, nint ch);
            static /*0x40ff41c*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetTimeoutMsec_Injected(nint _unity_self, int timeout);
            /*0x40fddb4*/ UnityWebRequest();
            /*0x40fde08*/ UnityWebRequest(string url, string method, UnityEngine.Networking.DownloadHandler downloadHandler, UnityEngine.Networking.UploadHandler uploadHandler);
            /*0x40fdc44*/ bool get_disposeCertificateHandlerOnDispose();
            /*0x40fdc4c*/ void set_disposeCertificateHandlerOnDispose(bool value);
            /*0x40fdc54*/ bool get_disposeDownloadHandlerOnDispose();
            /*0x40fdc5c*/ void set_disposeDownloadHandlerOnDispose(bool value);
            /*0x40fdc64*/ bool get_disposeUploadHandlerOnDispose();
            /*0x40fdc6c*/ void set_disposeUploadHandlerOnDispose(bool value);
            /*0x40fdc9c*/ void Release();
            /*0x40fdd28*/ void InternalDestroy();
            /*0x40fdda0*/ void InternalSetDefaults();
            /*0x40fe248*/ void Finalize();
            /*0x40fe340*/ void Dispose();
            /*0x40fe2d4*/ void DisposeHandlers();
            /*0x40fe3c0*/ UnityEngine.Networking.UnityWebRequestAsyncOperation BeginWebRequest();
            /*0x40fe460*/ UnityEngine.Networking.UnityWebRequestAsyncOperation SendWebRequest();
            /*0x40fdd50*/ void Abort();
            /*0x40fe4d4*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetMethod(UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod methodType);
            /*0x40fe570*/ void InternalSetMethod(UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod methodType);
            /*0x40fe67c*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetCustomMethod(string customMethodName);
            /*0x40fe85c*/ void InternalSetCustomMethod(string customMethodName);
            /*0x40fdf30*/ void set_method(string value);
            /*0x40fe918*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError GetError();
            /*0x40fe9a4*/ string get_error();
            /*0x40feb04*/ string get_url();
            /*0x40fdea8*/ void set_url(string value);
            /*0x40feb08*/ string GetUrl();
            /*0x40fed08*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetUrl(string url);
            /*0x40fec08*/ void InternalSetUrl(string url);
            /*0x40feab4*/ long get_responseCode();
            /*0x40fe62c*/ bool get_isModifiable();
            /*0x40fef60*/ bool get_isDone();
            /*0x40fef78*/ bool get_isNetworkError();
            /*0x40fef90*/ bool get_isHttpError();
            /*0x40fea64*/ UnityEngine.Networking.UnityWebRequest.Result get_result();
            /*0x40fefe4*/ ulong get_downloadedBytes();
            /*0x40ff070*/ void SetRedirectLimitFromScripting(int limit);
            /*0x40ff10c*/ void set_redirectLimit(int value);
            /*0x40ff110*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetUploadHandler(UnityEngine.Networking.UploadHandler uh);
            /*0x40fe3b0*/ UnityEngine.Networking.UploadHandler get_uploadHandler();
            /*0x40fe180*/ void set_uploadHandler(UnityEngine.Networking.UploadHandler value);
            /*0x40ff1b4*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetDownloadHandler(UnityEngine.Networking.DownloadHandler dh);
            /*0x40fe3a8*/ UnityEngine.Networking.DownloadHandler get_downloadHandler();
            /*0x40fe0b8*/ void set_downloadHandler(UnityEngine.Networking.DownloadHandler value);
            /*0x40ff258*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetCertificateHandler(UnityEngine.Networking.CertificateHandler ch);
            /*0x40fe3b8*/ UnityEngine.Networking.CertificateHandler get_certificateHandler();
            /*0x40ff2fc*/ void set_certificateHandler(UnityEngine.Networking.CertificateHandler value);
            /*0x40ff3c4*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetTimeoutMsec(int timeout);
            /*0x40ff460*/ void set_timeout(int value);

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
                static /*0x40ff708*/ nint ConvertToNative(UnityEngine.Networking.UnityWebRequest unityWebRequest);
            }
        }

        class UploadHandler : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;

            static /*0x40ff76c*/ void ReleaseFromScripting_Injected(nint _unity_self);
            /*0x40ff7a8*/ UploadHandler();
            /*0x40ff71c*/ void ReleaseFromScripting();
            /*0x40ff7b0*/ void Finalize();
            /*0x40ff83c*/ void Dispose();

            class BindingsMarshaller
            {
                static /*0x40ff85c*/ nint ConvertToNative(UnityEngine.Networking.UploadHandler uploadHandler);
            }
        }
    }
}
