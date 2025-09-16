class <Module>
{
}

namespace UnityEngine
{
    class WWW : UnityEngine.CustomYieldInstruction, System.IDisposable
    {
        /*0x10*/ UnityEngine.Networking.UnityWebRequest _uwr;
        /*0x18*/ UnityEngine.AssetBundle _assetBundle;
        /*0x20*/ System.Collections.Generic.Dictionary<string, string> _responseHeaders;

        static /*0x81e7d64*/ UnityEngine.WWW LoadFromCacheOrDownload(string url, int version);
        static /*0x81e7d6c*/ UnityEngine.WWW LoadFromCacheOrDownload(string url, int version, uint crc);
        static /*0x81e7e58*/ UnityEngine.WWW LoadFromCacheOrDownload(string url, UnityEngine.Hash128 hash);
        static /*0x81e7dc0*/ UnityEngine.WWW LoadFromCacheOrDownload(string url, UnityEngine.Hash128 hash, uint crc);
        /*0x81e7f14*/ WWW(string url, UnityEngine.WWWForm form);
        /*0x81e7f80*/ WWW(string url, byte[] postData);
        /*0x81e80f0*/ WWW(string url, byte[] postData, System.Collections.Generic.Dictionary<string, string> headers);
        /*0x81e7e60*/ WWW(string url, string name, UnityEngine.Hash128 hash, uint crc);
        /*0x81e83bc*/ UnityEngine.AssetBundle get_assetBundle();
        /*0x81e85b4*/ byte[] get_bytes();
        /*0x81e8648*/ string get_error();
        /*0x81e8758*/ bool get_isDone();
        /*0x81e8774*/ float get_progress();
        /*0x81e879c*/ System.Collections.Generic.Dictionary<string, string> get_responseHeaders();
        /*0x81e8958*/ string get_text();
        /*0x81e89e8*/ string get_url();
        /*0x81e8a04*/ bool get_keepWaiting();
        /*0x81e8a30*/ void Dispose();
        /*0x81e84d0*/ bool WaitUntilDoneIfPossible();
    }
}
