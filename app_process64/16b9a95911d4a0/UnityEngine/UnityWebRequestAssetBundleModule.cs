class <Module>
{
}

namespace UnityEngine
{
    namespace Networking
    {
        class UnityWebRequestAssetBundle
        {
            static /*0x40fad1c*/ UnityEngine.Networking.UnityWebRequest GetAssetBundle(string uri);
            static /*0x40fad24*/ UnityEngine.Networking.UnityWebRequest GetAssetBundle(string uri, uint crc);
            static /*0x40fae30*/ UnityEngine.Networking.UnityWebRequest GetAssetBundle(string uri, UnityEngine.CachedAssetBundle cachedAssetBundle, uint crc);
        }

        class DownloadHandlerAssetBundle : UnityEngine.Networking.DownloadHandler
        {
            static /*0x40faf7c*/ nint Create(UnityEngine.Networking.DownloadHandlerAssetBundle obj, string url, uint crc);
            static /*0x40fb158*/ nint CreateCached(UnityEngine.Networking.DownloadHandlerAssetBundle obj, string url, string name, UnityEngine.Hash128 hash, uint crc);
            static /*0x40fb5a8*/ UnityEngine.AssetBundle GetContent(UnityEngine.Networking.UnityWebRequest www);
            static /*0x40fb104*/ nint Create_Injected(UnityEngine.Networking.DownloadHandlerAssetBundle obj, ref UnityEngine.Bindings.ManagedSpanWrapper url, uint crc);
            static /*0x40fb3b0*/ nint CreateCached_Injected(UnityEngine.Networking.DownloadHandlerAssetBundle obj, ref UnityEngine.Bindings.ManagedSpanWrapper url, ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.Hash128 hash, uint crc);
            static /*0x40fb56c*/ nint get_assetBundle_Injected(nint _unity_self);
            /*0x40fadf4*/ DownloadHandlerAssetBundle(string url, uint crc);
            /*0x40faf0c*/ DownloadHandlerAssetBundle(string url, UnityEngine.CachedAssetBundle cachedBundle, uint crc);
            /*0x40fb41c*/ void InternalCreateAssetBundle(string url, uint crc);
            /*0x40fb434*/ void InternalCreateAssetBundleCached(string url, string name, UnityEngine.Hash128 hash, uint crc);
            /*0x40fb44c*/ byte[] GetData();
            /*0x40fb498*/ string GetText();
            /*0x40fb4e4*/ UnityEngine.AssetBundle get_assetBundle();

            class BindingsMarshaller
            {
                static /*0x40fb5fc*/ nint ConvertToNative(UnityEngine.Networking.DownloadHandlerAssetBundle handler);
            }
        }
    }
}
