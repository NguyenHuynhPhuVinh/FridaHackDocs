class <Module>
{
}

namespace UnityEngineInternal
{
    class WebRequestUtils
    {
        static /*0x0*/ System.Text.RegularExpressions.Regex domainRegex;

        static /*0x1869970*/ WebRequestUtils();
        static /*0x1869870*/ string RedirectTo(string baseUri, string redirectUri);
    }
}

namespace UnityEngine
{
    namespace Networking
    {
        class CertificateHandler
        {
            /*0x10*/ nint m_Ptr;

            /*0x6a6020*/ bool ValidateCertificate(byte[] certificateData);
            /*0x1869820*/ bool ValidateCertificateNative(byte[] certificateData);
        }

        class DownloadHandler
        {
            /*0x10*/ nint m_Ptr;

            /*0x72f070*/ bool ReceiveData(byte[] data, int dataLength);
            /*0x1869850*/ void ReceiveContentLengthHeader(ulong contentLength);
            /*0x32d010*/ void ReceiveContentLength(int contentLength);
            /*0x32d010*/ void CompleteContent();
            /*0x1869840*/ float GetProgress();
        }
    }
}
