class <Module>
{
}

namespace UnityEngine
{
    namespace Networking
    {
        class UnityWebRequestAssetBundle
        {
            static /*0x81e046c*/ UnityEngine.Networking.UnityWebRequest GetAssetBundle(string uri);
            static /*0x81e0540*/ UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.Uri uri);
            static /*0x81e0474*/ UnityEngine.Networking.UnityWebRequest GetAssetBundle(string uri, uint crc);
            static /*0x81e0548*/ UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.Uri uri, uint crc);
            static /*0x81e066c*/ UnityEngine.Networking.UnityWebRequest GetAssetBundle(string uri, UnityEngine.CachedAssetBundle cachedAssetBundle, uint crc);
            static /*0x81e07b8*/ UnityEngine.Networking.UnityWebRequest GetAssetBundle(System.Uri uri, UnityEngine.CachedAssetBundle cachedAssetBundle, uint crc);
        }

        class DownloadHandlerAssetBundle : UnityEngine.Networking.DownloadHandler
        {
            static /*0x81e08ac*/ nint Create(UnityEngine.Networking.DownloadHandlerAssetBundle obj, string url, uint crc);
            static /*0x81e0a88*/ nint CreateCached(UnityEngine.Networking.DownloadHandlerAssetBundle obj, string url, string name, UnityEngine.Hash128 hash, uint crc);
            static /*0x81e0a34*/ nint Create_Injected(UnityEngine.Networking.DownloadHandlerAssetBundle obj, ref UnityEngine.Bindings.ManagedSpanWrapper url, uint crc);
            static /*0x81e0ce0*/ nint CreateCached_Injected(UnityEngine.Networking.DownloadHandlerAssetBundle obj, ref UnityEngine.Bindings.ManagedSpanWrapper url, ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.Hash128 hash, uint crc);
            static /*0x81e0e9c*/ nint get_assetBundle_Injected(nint _unity_self);
            static /*0x81e0f28*/ bool get_autoLoadAssetBundle_Injected(nint _unity_self);
            static /*0x81e0fbc*/ void set_autoLoadAssetBundle_Injected(nint _unity_self, bool value);
            static /*0x81e1050*/ bool get_isDownloadComplete_Injected(nint _unity_self);
            /*0x81e0630*/ DownloadHandlerAssetBundle(string url, uint crc);
            /*0x81e0748*/ DownloadHandlerAssetBundle(string url, UnityEngine.CachedAssetBundle cachedBundle, uint crc);
            /*0x81e0d4c*/ void InternalCreateAssetBundle(string url, uint crc);
            /*0x81e0d64*/ void InternalCreateAssetBundleCached(string url, string name, UnityEngine.Hash128 hash, uint crc);
            /*0x81e0d7c*/ byte[] GetData();
            /*0x81e0dc8*/ string GetText();
            /*0x81e0e14*/ UnityEngine.AssetBundle get_assetBundle();
            /*0x81e0ed8*/ bool get_autoLoadAssetBundle();
            /*0x81e0f64*/ void set_autoLoadAssetBundle(bool value);
            /*0x81e1000*/ bool get_isDownloadComplete();

            class BindingsMarshaller
            {
                static /*0x81e108c*/ nint ConvertToNative(UnityEngine.Networking.DownloadHandlerAssetBundle handler);
            }
        }
    }
}
