class <Module>
{
}

namespace UnityEngine
{
    class WWW : UnityEngine.CustomYieldInstruction, System.IDisposable
    {
        /*0x10*/ UnityEngine.Networking.UnityWebRequest _uwr;

        /*0xf2d708*/ WWW(string url);
        /*0xf2d748*/ WWW(string url, UnityEngine.WWWForm form);
        /*0xf2d7a4*/ WWW(string url, byte[] postData, System.Collections.Generic.Dictionary<string, string> headers);
        /*0xf2da68*/ string get_error();
        /*0xf2db90*/ string get_text();
        /*0xf2dd04*/ UnityEngine.Texture2D CreateTextureFromDownloadedData(bool markNonReadable);
        /*0xf2de04*/ UnityEngine.Texture2D get_texture();
        /*0xf2de0c*/ string get_url();
        /*0xf2de28*/ bool get_keepWaiting();
        /*0xf2de54*/ void Dispose();
        /*0xf2dc20*/ bool WaitUntilDoneIfPossible();
    }
}
