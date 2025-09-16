class <Module>
{
}

namespace UnityEngineInternal
{
    class WebRequestUtils
    {
        static /*0x0*/ System.Text.RegularExpressions.Regex domainRegex;

        static /*0x81e19e4*/ WebRequestUtils();
        static /*0x81e10a4*/ string RedirectTo(string baseUri, string redirectUri);
        static /*0x81e1190*/ string MakeInitialUrl(string targetUrl, string localUrl);
        static /*0x81e1500*/ string MakeUriString(System.Uri targetUri, string targetUrl, bool prependProtocol);
        static /*0x81e18dc*/ string URLDecode(string encoded);
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

        static /*0x81e2c90*/ WWWForm();
        static /*0x81e1a80*/ System.Text.Encoding get_DefaultEncoding();
        /*0x81e1a88*/ System.Collections.Generic.Dictionary<string, string> get_headers();
        /*0x81e1bd4*/ byte[] get_data();
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

        static /*0x81e3870*/ WWWTranscoder();
        static /*0x81e2f28*/ byte Hex2Byte(byte[] b, int offset);
        static /*0x81e2fd4*/ void Byte2Hex(byte b, byte[] hexChars, ref byte byte0, ref byte byte1);
        static /*0x81e2c28*/ byte[] DataEncode(byte[] toEncode);
        static /*0x81e2b34*/ string QPEncode(string toEncode, System.Text.Encoding e);
        static /*0x81e3028*/ byte[] Encode(byte[] input, byte escapeChar, byte[] space, byte[] forbidden, bool uppercase);
        static /*0x81e3404*/ bool ByteArrayContains(byte[] array, byte b);
        static /*0x81e1980*/ byte[] URLDecode(byte[] toEncode);
        static /*0x81e3784*/ bool ByteSubArrayEquals(byte[] array, int index, byte[] comperand);
        static /*0x81e346c*/ byte[] Decode(byte[] input, byte escapeChar, byte[] space);
        static /*0x81e29c0*/ bool SevenBitClean(string s, System.Text.Encoding e);
        static /*0x81e3814*/ bool SevenBitClean(byte* input, int inputLength);
    }

    namespace Networking
    {
        class CertificateHandler
        {
            /*0x10*/ nint m_Ptr;

            static /*0x81e3b40*/ void ReleaseFromScripting_Injected(nint _unity_self);
            /*0x81e3af0*/ void ReleaseFromScripting();
            /*0x81e3b7c*/ bool ValidateCertificate(byte[] certificateData);
            /*0x81e3b84*/ bool ValidateCertificateNative(byte[] certificateData);
            /*0x81e3b90*/ void Dispose();

            class BindingsMarshaller
            {
                static /*0x81e3bb0*/ nint ConvertToNative(UnityEngine.Networking.CertificateHandler handler);
            }
        }

        class DownloadHandler : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;

            static /*0x81e433c*/ byte* InternalGetByteArray(UnityEngine.Networking.DownloadHandler dh, ref int length);
            static /*0x81e3e64*/ byte[] InternalGetByteArray(UnityEngine.Networking.DownloadHandler dh);
            static /*0x81e43d0*/ Unity.Collections.NativeArray<byte> InternalGetNativeArray(UnityEngine.Networking.DownloadHandler dh, ref Unity.Collections.NativeArray<byte> nativeArray);
            static /*0x81e44b0*/ void DisposeNativeArray(ref Unity.Collections.NativeArray<byte> data);
            static /*0x81e44f4*/ void CreateNativeArrayForNativeData(ref Unity.Collections.NativeArray<byte> data, byte* bytes, int length);
            static /*0x81e3c18*/ void ReleaseFromScripting_Injected(nint _unity_self);
            static /*0x81e3df8*/ void GetErrorMsg_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x81e42d4*/ void GetContentType_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x81e438c*/ byte* InternalGetByteArray_Injected(nint dh, ref int length);
            /*0x81e3c54*/ DownloadHandler();
            /*0x81e3bc8*/ void ReleaseFromScripting();
            /*0x81e3c5c*/ void Finalize();
            /*0x81e3cf8*/ void Dispose();
            /*0x81e3d18*/ string get_error();
            /*0x81e3d1c*/ string GetErrorMsg();
            /*0x81e3e3c*/ byte[] get_data();
            /*0x81e3e48*/ string get_text();
            /*0x81e3e54*/ Unity.Collections.NativeArray<byte> GetNativeData();
            /*0x81e3e60*/ byte[] GetData();
            /*0x81e3ee8*/ string GetText();
            /*0x81e3fa8*/ System.Text.Encoding GetTextEncoder();
            /*0x81e41f8*/ string GetContentType();
            /*0x81e4318*/ bool ReceiveData(byte[] data, int dataLength);
            /*0x81e4320*/ void ReceiveContentLengthHeader(ulong contentLength);
            /*0x81e432c*/ void ReceiveContentLength(int contentLength);
            /*0x81e4330*/ void CompleteContent();
            /*0x81e4334*/ float GetProgress();

            class BindingsMarshaller
            {
                static /*0x81e455c*/ nint ConvertToNative(UnityEngine.Networking.DownloadHandler handler);
            }
        }

        class DownloadHandlerBuffer : UnityEngine.Networking.DownloadHandler
        {
            /*0x18*/ Unity.Collections.NativeArray<byte> m_NativeData;

            static /*0x81e4574*/ nint Create(UnityEngine.Networking.DownloadHandlerBuffer obj);
            /*0x81e45f4*/ DownloadHandlerBuffer();
            /*0x81e45b0*/ void InternalCreateBuffer();
            /*0x81e4640*/ Unity.Collections.NativeArray<byte> GetNativeData();
            /*0x81e4648*/ void Dispose();
        }

        class UnityWebRequestAsyncOperation : UnityEngine.AsyncOperation
        {
            /*0x20*/ UnityEngine.Networking.UnityWebRequest <webRequest>k__BackingField;

            /*0x81e46a4*/ UnityWebRequestAsyncOperation(nint ptr);
            /*0x81e46ac*/ UnityEngine.Networking.UnityWebRequest get_webRequest();
            /*0x81e46b4*/ void set_webRequest(UnityEngine.Networking.UnityWebRequest value);

            class BindingsMarshaller
            {
                static /*0x81e46bc*/ UnityEngine.Networking.UnityWebRequestAsyncOperation ConvertToManaged(nint ptr);
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

            static /*0x81e4718*/ string GetWebErrorString(UnityEngine.Networking.UnityWebRequest.UnityWebRequestError err);
            static /*0x81e4818*/ string GetHTTPStatusString(long responseCode);
            static /*0x81e4954*/ nint Create();
            static /*0x81e715c*/ UnityEngine.Networking.UnityWebRequest Get(string uri);
            static /*0x81e7200*/ UnityEngine.Networking.UnityWebRequest Post(string uri, UnityEngine.WWWForm formData);
            static /*0x81e7288*/ void SetupPost(UnityEngine.Networking.UnityWebRequest request, UnityEngine.WWWForm formData);
            static /*0x81e47d4*/ void GetWebErrorString_Injected(UnityEngine.Networking.UnityWebRequest.UnityWebRequestError err, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x81e48d4*/ void GetHTTPStatusString_Injected(long responseCode, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x81e49cc*/ void Release_Injected(nint _unity_self);
            static /*0x81e5330*/ nint BeginWebRequest_Injected(nint _unity_self);
            static /*0x81e53a4*/ void Abort_Injected(nint _unity_self);
            static /*0x81e5438*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetMethod_Injected(nint _unity_self, UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod methodType);
            static /*0x81e5724*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetCustomMethod_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper customMethodName);
            static /*0x81e5874*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod GetMethod_Injected(nint _unity_self);
            static /*0x81e598c*/ void GetCustomMethod_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x81e5ae8*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError GetError_Injected(nint _unity_self);
            static /*0x81e5e20*/ void GetUrl_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x81e6000*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetUrl_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper url);
            static /*0x81e6044*/ long get_responseCode_Injected(nint _unity_self);
            static /*0x81e60d0*/ bool IsExecuting_Injected(nint _unity_self);
            static /*0x81e610c*/ bool get_isModifiable_Injected(nint _unity_self);
            static /*0x81e6160*/ UnityEngine.Networking.UnityWebRequest.Result get_result_Injected(nint _unity_self);
            static /*0x81e61ec*/ float GetDownloadProgress_Injected(nint _unity_self);
            static /*0x81e62ac*/ ulong get_downloadedBytes_Injected(nint _unity_self);
            static /*0x81e6340*/ void SetRedirectLimitFromScripting_Injected(nint _unity_self, int limit);
            static /*0x81e63e0*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetChunked_Injected(nint _unity_self, bool chunked);
            static /*0x81e674c*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError InternalSetRequestHeader_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.Bindings.ManagedSpanWrapper value);
            static /*0x81e6aa0*/ void GetResponseHeader_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x81e6b44*/ string[] GetResponseHeaderKeys_Injected(nint _unity_self);
            static /*0x81e6d60*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetUploadHandler_Injected(nint _unity_self, nint uh);
            static /*0x81e6e04*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetDownloadHandler_Injected(nint _unity_self, nint dh);
            static /*0x81e6ea8*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetCertificateHandler_Injected(nint _unity_self, nint ch);
            static /*0x81e700c*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetTimeoutMsec_Injected(nint _unity_self, int timeout);
            /*0x81e4a94*/ UnityWebRequest(string url);
            /*0x81e4b80*/ UnityWebRequest(string url, string method);
            /*0x81e4d7c*/ UnityWebRequest(string url, string method, UnityEngine.Networking.DownloadHandler downloadHandler, UnityEngine.Networking.UploadHandler uploadHandler);
            /*0x81e4fb0*/ UnityWebRequest(System.Uri uri, string method, UnityEngine.Networking.DownloadHandler downloadHandler, UnityEngine.Networking.UploadHandler uploadHandler);
            /*0x81e4918*/ bool get_disposeCertificateHandlerOnDispose();
            /*0x81e4920*/ void set_disposeCertificateHandlerOnDispose(bool value);
            /*0x81e492c*/ bool get_disposeDownloadHandlerOnDispose();
            /*0x81e4934*/ void set_disposeDownloadHandlerOnDispose(bool value);
            /*0x81e4940*/ bool get_disposeUploadHandlerOnDispose();
            /*0x81e4948*/ void set_disposeUploadHandlerOnDispose(bool value);
            /*0x81e497c*/ void Release();
            /*0x81e4a08*/ void InternalDestroy();
            /*0x81e4a80*/ void InternalSetDefaults();
            /*0x81e5144*/ void Finalize();
            /*0x81e524c*/ void Dispose();
            /*0x81e51e0*/ void DisposeHandlers();
            /*0x81e52cc*/ UnityEngine.Networking.UnityWebRequestAsyncOperation BeginWebRequest();
            /*0x81e536c*/ UnityEngine.Networking.UnityWebRequestAsyncOperation SendWebRequest();
            /*0x81e4a30*/ void Abort();
            /*0x81e53e0*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetMethod(UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod methodType);
            /*0x81e547c*/ void InternalSetMethod(UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod methodType);
            /*0x81e5588*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetCustomMethod(string customMethodName);
            /*0x81e5768*/ void InternalSetCustomMethod(string customMethodName);
            /*0x81e5824*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod GetMethod();
            /*0x81e58b0*/ string GetCustomMethod();
            /*0x81e59d0*/ string get_method();
            /*0x81e4bfc*/ void set_method(string value);
            /*0x81e5a98*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError GetError();
            /*0x81e5b24*/ string get_error();
            /*0x81e5c84*/ string get_url();
            /*0x81e4af8*/ void set_url(string value);
            /*0x81e5054*/ void set_uri(System.Uri value);
            /*0x81e5c88*/ string GetUrl();
            /*0x81e5e64*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetUrl(string url);
            /*0x81e5d64*/ void InternalSetUrl(string url);
            /*0x81e5c34*/ long get_responseCode();
            /*0x81e6080*/ bool IsExecuting();
            /*0x81e5538*/ bool get_isModifiable();
            /*0x81e6148*/ bool get_isDone();
            /*0x81e5be4*/ UnityEngine.Networking.UnityWebRequest.Result get_result();
            /*0x81e619c*/ float GetDownloadProgress();
            /*0x81e6228*/ float get_downloadProgress();
            /*0x81e625c*/ ulong get_downloadedBytes();
            /*0x81e62e8*/ void SetRedirectLimitFromScripting(int limit);
            /*0x81e6384*/ void set_redirectLimit(int value);
            /*0x81e6388*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetChunked(bool chunked);
            /*0x81e6424*/ void set_chunkedTransfer(bool value);
            /*0x81e64e0*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError InternalSetRequestHeader(string name, string value);
            /*0x81e67a0*/ void SetRequestHeader(string name, string value);
            /*0x81e68d0*/ string GetResponseHeader(string name);
            /*0x81e6af4*/ string[] GetResponseHeaderKeys();
            /*0x81e6b80*/ System.Collections.Generic.Dictionary<string, string> GetResponseHeaders();
            /*0x81e6d00*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetUploadHandler(UnityEngine.Networking.UploadHandler uh);
            /*0x81e52bc*/ UnityEngine.Networking.UploadHandler get_uploadHandler();
            /*0x81e4ee8*/ void set_uploadHandler(UnityEngine.Networking.UploadHandler value);
            /*0x81e6da4*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetDownloadHandler(UnityEngine.Networking.DownloadHandler dh);
            /*0x81e52b4*/ UnityEngine.Networking.DownloadHandler get_downloadHandler();
            /*0x81e4e20*/ void set_downloadHandler(UnityEngine.Networking.DownloadHandler value);
            /*0x81e6e48*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetCertificateHandler(UnityEngine.Networking.CertificateHandler ch);
            /*0x81e52c4*/ UnityEngine.Networking.CertificateHandler get_certificateHandler();
            /*0x81e6eec*/ void set_certificateHandler(UnityEngine.Networking.CertificateHandler value);
            /*0x81e6fb4*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetTimeoutMsec(int timeout);
            /*0x81e7050*/ void set_timeout(int value);

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
                static /*0x81e74f4*/ nint ConvertToNative(UnityEngine.Networking.UnityWebRequest unityWebRequest);
            }
        }

        class UploadHandler : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;

            static /*0x81e755c*/ void ReleaseFromScripting_Injected(nint _unity_self);
            static /*0x81e77fc*/ void InternalSetContentType_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper newContentType);
            /*0x81e7598*/ UploadHandler();
            /*0x81e750c*/ void ReleaseFromScripting();
            /*0x81e75a0*/ void Finalize();
            /*0x81e763c*/ void Dispose();
            /*0x81e765c*/ void set_contentType(string value);
            /*0x81e7668*/ void SetContentType(string newContentType);
            /*0x81e766c*/ void InternalSetContentType(string newContentType);

            class BindingsMarshaller
            {
                static /*0x81e7840*/ nint ConvertToNative(UnityEngine.Networking.UploadHandler uploadHandler);
            }
        }

        class UploadHandlerRaw : UnityEngine.Networking.UploadHandler
        {
            /*0x18*/ Unity.Collections.NativeArray<byte> m_Payload;

            static /*0x81e7858*/ nint Create(UnityEngine.Networking.UploadHandlerRaw self, byte* data, int dataLength);
            /*0x81e7468*/ UploadHandlerRaw(byte[] data);
            /*0x81e78ac*/ UploadHandlerRaw(Unity.Collections.NativeArray<byte> data, bool transferOwnership);
            /*0x81e79a0*/ void Dispose();
        }
    }
}
