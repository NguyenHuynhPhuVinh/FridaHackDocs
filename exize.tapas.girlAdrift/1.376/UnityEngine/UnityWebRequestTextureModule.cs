class <Module>
{
}

namespace UnityEngine
{
    namespace Networking
    {
        class UnityWebRequestTexture
        {
            static /*0xcb9dd4*/ UnityEngine.Networking.UnityWebRequest GetTexture(string uri);
            static /*0xcb9ddc*/ UnityEngine.Networking.UnityWebRequest GetTexture(string uri, bool nonReadable);
        }

        class DownloadHandlerTexture : UnityEngine.Networking.DownloadHandler
        {
            /*0x18*/ Unity.Collections.NativeArray<byte> m_NativeData;
            /*0x28*/ UnityEngine.Texture2D mTexture;
            /*0x30*/ bool mHasTexture;
            /*0x31*/ bool mNonReadable;

            static /*0xcb9efc*/ nint Create(UnityEngine.Networking.DownloadHandlerTexture obj, bool readable);
            static /*0xcba10c*/ UnityEngine.Texture2D GetContent(UnityEngine.Networking.UnityWebRequest www);
            /*0xcb9e9c*/ DownloadHandlerTexture(bool readable);
            /*0xcb9f40*/ void InternalCreateTexture(bool readable);
            /*0xcb9f8c*/ Unity.Collections.NativeArray<byte> GetNativeData();
            /*0xcb9f98*/ void Dispose();
            /*0xcb9fbc*/ UnityEngine.Texture2D get_texture();
            /*0xcb9fc0*/ UnityEngine.Texture2D InternalGetTexture();
            /*0xcba0d0*/ UnityEngine.Texture2D InternalGetTextureNative();
        }
    }
}
