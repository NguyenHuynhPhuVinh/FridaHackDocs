class <Module>
{
}

namespace UnityEngine
{
    namespace Networking
    {
        class UnityWebRequestAssetBundle
        {
            static /*0x81c903c*/ UnityEngine.Networking.UnityWebRequest GetAssetBundle(string uri);
            static /*0x81c9110*/ UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.Uri uri);
            static /*0x81c9044*/ UnityEngine.Networking.UnityWebRequest GetAssetBundle(string uri, uint crc);
            static /*0x81c9118*/ UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.Uri uri, uint crc);
            static /*0x81c923c*/ UnityEngine.Networking.UnityWebRequest GetAssetBundle(string uri, UnityEngine.CachedAssetBundle cachedAssetBundle, uint crc);
            static /*0x81c9388*/ UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.Uri uri, UnityEngine.CachedAssetBundle cachedAssetBundle, uint crc);
        }

        class DownloadHandlerAssetBundle : UnityEngine.Networking.DownloadHandler
        {
            static /*0x81c947c*/ nint Create(UnityEngine.Networking.DownloadHandlerAssetBundle obj, string url, uint crc);
            static /*0x81c9658*/ nint CreateCached(UnityEngine.Networking.DownloadHandlerAssetBundle obj, string url, string name, UnityEngine.Hash128 hash, uint crc);
            static /*0x81c9604*/ nint Create_Injected(UnityEngine.Networking.DownloadHandlerAssetBundle obj, ref UnityEngine.Bindings.ManagedSpanWrapper url, uint crc);
            static /*0x81c98b0*/ nint CreateCached_Injected(UnityEngine.Networking.DownloadHandlerAssetBundle obj, ref UnityEngine.Bindings.ManagedSpanWrapper url, ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.Hash128 hash, uint crc);
            static /*0x81c9a6c*/ nint get_assetBundle_Injected(nint _unity_self);
            static /*0x81c9af8*/ bool get_autoLoadAssetBundle_Injected(nint _unity_self);
            static /*0x81c9b8c*/ void set_autoLoadAssetBundle_Injected(nint _unity_self, bool value);
            static /*0x81c9c20*/ bool get_isDownloadComplete_Injected(nint _unity_self);
            /*0x81c9200*/ DownloadHandlerAssetBundle(string url, uint crc);
            /*0x81c9318*/ DownloadHandlerAssetBundle(string url, UnityEngine.CachedAssetBundle cachedBundle, uint crc);
            /*0x81c991c*/ void InternalCreateAssetBundle(string url, uint crc);
            /*0x81c9934*/ void InternalCreateAssetBundleCached(string url, string name, UnityEngine.Hash128 hash, uint crc);
            /*0x81c994c*/ byte[] GetData();
            /*0x81c9998*/ string GetText();
            /*0x81c99e4*/ UnityEngine.AssetBundle get_assetBundle();
            /*0x81c9aa8*/ bool get_autoLoadAssetBundle();
            /*0x81c9b34*/ void set_autoLoadAssetBundle(bool value);
            /*0x81c9bd0*/ bool get_isDownloadComplete();

            class BindingsMarshaller
            {
                static /*0x81c9c5c*/ nint ConvertToNative(UnityEngine.Networking.DownloadHandlerAssetBundle handler);
            }
        }
    }
}
