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

        static /*0x81d0934*/ UnityEngine.WWW LoadFromCacheOrDownload(string url, int version);
        static /*0x81d093c*/ UnityEngine.WWW LoadFromCacheOrDownload(string url, int version, uint crc);
        static /*0x81d0a28*/ UnityEngine.WWW LoadFromCacheOrDownload(string url, UnityEngine.Hash128 hash);
        static /*0x81d0990*/ UnityEngine.WWW LoadFromCacheOrDownload(string url, UnityEngine.Hash128 hash, uint crc);
        /*0x81d0ae4*/ WWW(string url, UnityEngine.WWWForm form);
        /*0x81d0b50*/ WWW(string url, byte[] postData);
        /*0x81d0cc0*/ WWW(string url, byte[] postData, System.Collections.Generic.Dictionary<string, string> headers);
        /*0x81d0a30*/ WWW(string url, string name, UnityEngine.Hash128 hash, uint crc);
        /*0x81d0f8c*/ UnityEngine.AssetBundle get_assetBundle();
        /*0x81d1184*/ byte[] get_bytes();
        /*0x81d1218*/ string get_error();
        /*0x81d1328*/ bool get_isDone();
        /*0x81d1344*/ float get_progress();
        /*0x81d136c*/ System.Collections.Generic.Dictionary<string, string> get_responseHeaders();
        /*0x81d1528*/ string get_text();
        /*0x81d15b8*/ string get_url();
        /*0x81d15d4*/ bool get_keepWaiting();
        /*0x81d1600*/ void Dispose();
        /*0x81d10a0*/ bool WaitUntilDoneIfPossible();
    }
}
