class <Module>
{
}

namespace UnityEngine
{
    namespace Networking
    {
        class UnityWebRequestAssetBundle
        {
            static /*0x2b38a84*/ UnityEngine.Networking.UnityWebRequest GetAssetBundle(string uri);
            static /*0x2b38a8c*/ UnityEngine.Networking.UnityWebRequest GetAssetBundle(string uri, uint crc);
        }

        class DownloadHandlerAssetBundle : UnityEngine.Networking.DownloadHandler
        {
            static /*0x2b387fc*/ nint Create(UnityEngine.Networking.DownloadHandlerAssetBundle obj, string url, uint crc);
            static /*0x2b38a04*/ UnityEngine.AssetBundle GetContent(UnityEngine.Networking.UnityWebRequest www);
            /*0x2b388b4*/ DownloadHandlerAssetBundle(string url, uint crc);
            /*0x2b38854*/ void InternalCreateAssetBundle(string url, uint crc);
            /*0x2b3891c*/ byte[] GetData();
            /*0x2b38970*/ string GetText();
            /*0x2b389c4*/ UnityEngine.AssetBundle get_assetBundle();
        }
    }
}
