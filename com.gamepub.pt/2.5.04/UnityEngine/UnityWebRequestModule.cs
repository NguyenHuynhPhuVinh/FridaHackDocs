class <Module>
{
}

namespace UnityEngineInternal
{
    class WebRequestUtils
    {
        static /*0x0*/ System.Text.RegularExpressions.Regex domainRegex;

        static /*0x2adb374*/ WebRequestUtils();
        static /*0x2adb1c0*/ string RedirectTo(string baseUri, string redirectUri);
        static /*0x2ad739c*/ string MakeInitialUrl(string targetUrl, string localUrl);
        static /*0x2ad7858*/ string MakeUriString(System.Uri targetUri, string targetUrl, bool prependProtocol);
        static /*0x2adb2c4*/ string URLDecode(string encoded);
    }
}

namespace UnityEngine
{
    class WWWForm
    {
        /*0x10*/ System.Collections.Generic.List<System.Byte[]> formData;
        /*0x18*/ System.Collections.Generic.List<string> fieldNames;
        /*0x20*/ System.Collections.Generic.List<string> fileNames;
        /*0x28*/ System.Collections.Generic.List<string> types;
        /*0x30*/ byte[] boundary;
        /*0x38*/ bool containsFiles;

        static /*0x2ada038*/ System.Text.Encoding get_DefaultEncoding();
        /*0x2ada040*/ WWWForm();
        /*0x2ada1c0*/ void AddField(string fieldName, string value);
        /*0x2ada204*/ void AddField(string fieldName, string value, System.Text.Encoding e);
        /*0x2ad98b4*/ System.Collections.Generic.Dictionary<string, string> get_headers();
        /*0x2ad8684*/ byte[] get_data();
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

        static /*0x2adafac*/ WWWTranscoder();
        static /*0x2ada51c*/ byte Hex2Byte(byte[] b, int offset);
        static /*0x2ada5dc*/ byte[] Byte2Hex(byte b, byte[] hexChars);
        static /*0x2ad9e0c*/ string DataEncode(string toEncode);
        static /*0x2ada69c*/ string DataEncode(string toEncode, System.Text.Encoding e);
        static /*0x2ada4a8*/ byte[] DataEncode(byte[] toEncode);
        static /*0x2ada3d0*/ string QPEncode(string toEncode, System.Text.Encoding e);
        static /*0x2ada774*/ byte[] Encode(byte[] input, byte escapeChar, byte[] space, byte[] forbidden, bool uppercase);
        static /*0x2adab10*/ bool ByteArrayContains(byte[] array, byte b);
        static /*0x2adab5c*/ byte[] URLDecode(byte[] toEncode);
        static /*0x2adaebc*/ bool ByteSubArrayEquals(byte[] array, int index, byte[] comperand);
        static /*0x2adabcc*/ byte[] Decode(byte[] input, byte escapeChar, byte[] space);
        static /*0x2ada33c*/ bool SevenBitClean(string s, System.Text.Encoding e);
        static /*0x2adaf44*/ bool SevenBitClean(byte[] input);
    }

    namespace Networking
    {
        class UnityWebRequestAsyncOperation : UnityEngine.AsyncOperation
        {
            /*0x20*/ UnityEngine.Networking.UnityWebRequest <webRequest>k__BackingField;

            /*0x2ad9e90*/ UnityWebRequestAsyncOperation();
            /*0x2ad9e80*/ UnityEngine.Networking.UnityWebRequest get_webRequest();
            /*0x2ad9e88*/ void set_webRequest(UnityEngine.Networking.UnityWebRequest value);
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

            static /*0x2ad61ac*/ string GetWebErrorString(UnityEngine.Networking.UnityWebRequest.UnityWebRequestError err);
            static /*0x2ad61ec*/ string GetHTTPStatusString(long responseCode);
            static /*0x2ad6268*/ nint Create();
            static /*0x2ad82dc*/ UnityEngine.Networking.UnityWebRequest Get(string uri);
            static /*0x2ad8384*/ UnityEngine.Networking.UnityWebRequest Get(System.Uri uri);
            static /*0x2ad842c*/ UnityEngine.Networking.UnityWebRequest Post(string uri, UnityEngine.WWWForm formData);
            static /*0x2ad84b8*/ void SetupPost(UnityEngine.Networking.UnityWebRequest request, UnityEngine.WWWForm formData);
            static /*0x2ad9a14*/ UnityEngine.Networking.UnityWebRequest Post(string uri, System.Collections.Generic.Dictionary<string, string> formFields);
            static /*0x2ad9aa0*/ void SetupPost(UnityEngine.Networking.UnityWebRequest request, System.Collections.Generic.Dictionary<string, string> formFields);
            static /*0x2ad9bac*/ byte[] SerializeSimpleForm(System.Collections.Generic.Dictionary<string, string> formFields);
            /*0x2ad63d4*/ UnityWebRequest(string url);
            /*0x2ad64d8*/ UnityWebRequest(string url, string method);
            /*0x2ad66ec*/ UnityWebRequest(string url, string method, UnityEngine.Networking.DownloadHandler downloadHandler, UnityEngine.Networking.UploadHandler uploadHandler);
            /*0x2ad69b4*/ UnityWebRequest(System.Uri uri, string method, UnityEngine.Networking.DownloadHandler downloadHandler, UnityEngine.Networking.UploadHandler uploadHandler);
            /*0x2ad622c*/ bool get_disposeCertificateHandlerOnDispose();
            /*0x2ad6234*/ void set_disposeCertificateHandlerOnDispose(bool value);
            /*0x2ad6240*/ bool get_disposeDownloadHandlerOnDispose();
            /*0x2ad6248*/ void set_disposeDownloadHandlerOnDispose(bool value);
            /*0x2ad6254*/ bool get_disposeUploadHandlerOnDispose();
            /*0x2ad625c*/ void set_disposeUploadHandlerOnDispose(bool value);
            /*0x2ad629c*/ void Release();
            /*0x2ad62dc*/ void InternalDestroy();
            /*0x2ad63c0*/ void InternalSetDefaults();
            /*0x2ad6b58*/ void Finalize();
            /*0x2ad6c28*/ void Dispose();
            /*0x2ad6bc8*/ void DisposeHandlers();
            /*0x2ad6d30*/ UnityEngine.Networking.UnityWebRequestAsyncOperation BeginWebRequest();
            /*0x2ad6d70*/ UnityEngine.Networking.UnityWebRequestAsyncOperation SendWebRequest();
            /*0x2ad6380*/ void Abort();
            /*0x2ad6dbc*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetMethod(UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod methodType);
            /*0x2ad6e0c*/ void InternalSetMethod(UnityEngine.Networking.UnityWebRequest.UnityWebRequestMethod methodType);
            /*0x2ad6f58*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetCustomMethod(string customMethodName);
            /*0x2ad6fa8*/ void InternalSetCustomMethod(string customMethodName);
            /*0x2ad6558*/ void set_method(string value);
            /*0x2ad70b4*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError GetError();
            /*0x2ad70f4*/ string get_error();
            /*0x2ad731c*/ string get_url();
            /*0x2ad6444*/ void set_url(string value);
            /*0x2ad6a5c*/ void set_uri(System.Uri value);
            /*0x2ad735c*/ string GetUrl();
            /*0x2ad7cf0*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetUrl(string url);
            /*0x2ad774c*/ void InternalSetUrl(string url);
            /*0x2ad72dc*/ long get_responseCode();
            /*0x2ad6f18*/ bool get_isModifiable();
            /*0x2ad7d40*/ bool get_isDone();
            /*0x2ad7d8c*/ bool get_isNetworkError();
            /*0x2ad7dd8*/ bool get_isHttpError();
            /*0x2ad729c*/ UnityEngine.Networking.UnityWebRequest.Result get_result();
            /*0x2ad7e24*/ ulong get_downloadedBytes();
            /*0x2ad7e64*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError InternalSetRequestHeader(string name, string value);
            /*0x2ad7ebc*/ void SetRequestHeader(string name, string value);
            /*0x2ad8038*/ string GetResponseHeader(string name);
            /*0x2ad8088*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetUploadHandler(UnityEngine.Networking.UploadHandler uh);
            /*0x2ad6ca4*/ UnityEngine.Networking.UploadHandler get_uploadHandler();
            /*0x2ad68a4*/ void set_uploadHandler(UnityEngine.Networking.UploadHandler value);
            /*0x2ad80d8*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetDownloadHandler(UnityEngine.Networking.DownloadHandler dh);
            /*0x2ad6c9c*/ UnityEngine.Networking.DownloadHandler get_downloadHandler();
            /*0x2ad6794*/ void set_downloadHandler(UnityEngine.Networking.DownloadHandler value);
            /*0x2ad6d28*/ UnityEngine.Networking.CertificateHandler get_certificateHandler();
            /*0x2ad8128*/ UnityEngine.Networking.UnityWebRequest.UnityWebRequestError SetTimeoutMsec(int timeout);
            /*0x2ad8178*/ void set_timeout(int value);

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

        class CertificateHandler
        {
            /*0x10*/ nint m_Ptr;

            /*0x2ad5a58*/ void Release();
            /*0x2ad5a98*/ bool ValidateCertificate(byte[] certificateData);
            /*0x2ad5aa0*/ bool ValidateCertificateNative(byte[] certificateData);
            /*0x2ad5aac*/ void Dispose();
        }

        class DownloadHandler : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;

            static T GetCheckedDownloader<T>(UnityEngine.Networking.UnityWebRequest www);
            static /*0x2ad6014*/ byte[] InternalGetByteArray(UnityEngine.Networking.DownloadHandler dh);
            /*0x2ad5b68*/ DownloadHandler();
            /*0x2ad5b28*/ void Release();
            /*0x2ad5b70*/ void Finalize();
            /*0x2ad5bd8*/ void Dispose();
            /*0x2ad5c54*/ byte[] get_data();
            /*0x2ad5c60*/ string get_text();
            /*0x2ad5c6c*/ byte[] GetData();
            /*0x2ad5c74*/ string GetText();
            /*0x2ad5d10*/ System.Text.Encoding GetTextEncoder();
            /*0x2ad5fc4*/ string GetContentType();
            /*0x2ad6004*/ void ReceiveContentLengthHeader(ulong contentLength);
            /*0x2ad6010*/ void ReceiveContentLength(int contentLength);
        }

        class DownloadHandlerBuffer : UnityEngine.Networking.DownloadHandler
        {
            static /*0x2ad6054*/ nint Create(UnityEngine.Networking.DownloadHandlerBuffer obj);
            /*0x2ad60dc*/ DownloadHandlerBuffer();
            /*0x2ad6094*/ void InternalCreateBuffer();
            /*0x2ad612c*/ byte[] GetData();
            /*0x2ad616c*/ byte[] InternalGetData();
        }

        class UploadHandler : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;

            /*0x2ad9ed8*/ UploadHandler();
            /*0x2ad9e98*/ void Release();
            /*0x2ad9ee0*/ void Finalize();
            /*0x2ad6cac*/ void Dispose();
            /*0x2ad9e00*/ void set_contentType(string value);
            /*0x2ad9f48*/ void SetContentType(string newContentType);
            /*0x2ad9f98*/ void InternalSetContentType(string newContentType);
        }

        class UploadHandlerRaw : UnityEngine.Networking.UploadHandler
        {
            static /*0x2ad9fe8*/ nint Create(UnityEngine.Networking.UploadHandlerRaw self, byte[] data);
            /*0x2ad9800*/ UploadHandlerRaw(byte[] data);
        }
    }
}
