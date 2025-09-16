class <Module>
{
}

namespace UnityEngine
{
    namespace Networking
    {
        enum DownloadedTextureFlags
        {
            None = 0,
            Readable = 1,
            MipmapChain = 2,
            LinearColorSpace = 4,
        }

        struct DownloadedTextureParams
        {
            /*0x10*/ UnityEngine.Networking.DownloadedTextureFlags flags;
            /*0x14*/ int mipmapCount;

            static /*0x81e7a14*/ UnityEngine.Networking.DownloadedTextureParams get_Default();
            /*0x81e7a1c*/ void set_readable(bool value);
            /*0x81e7a2c*/ void SetFlags(UnityEngine.Networking.DownloadedTextureFlags flgs, bool add);
        }

        class DownloadHandlerTexture : UnityEngine.Networking.DownloadHandler
        {
            /*0x18*/ Unity.Collections.NativeArray<byte> m_NativeData;

            static /*0x81e7a48*/ nint Create(UnityEngine.Networking.DownloadHandlerTexture obj, UnityEngine.Networking.DownloadedTextureParams parameters);
            static /*0x81e7a90*/ nint Create_Injected(UnityEngine.Networking.DownloadHandlerTexture obj, ref UnityEngine.Networking.DownloadedTextureParams parameters);
            static /*0x81e7c4c*/ nint InternalGetTextureNative_Injected(nint _unity_self);
            /*0x81e7b20*/ DownloadHandlerTexture(bool readable);
            /*0x81e7ad4*/ void InternalCreateTexture(UnityEngine.Networking.DownloadedTextureParams parameters);
            /*0x81e7b90*/ Unity.Collections.NativeArray<byte> GetNativeData();
            /*0x81e7b9c*/ void Dispose();
            /*0x81e7bc0*/ UnityEngine.Texture2D get_texture();
            /*0x81e7bc4*/ UnityEngine.Texture2D InternalGetTextureNative();

            class BindingsMarshaller
            {
                static /*0x81e7c88*/ nint ConvertToNative(UnityEngine.Networking.DownloadHandlerTexture handler);
            }
        }

        class UnityWebRequestTexture
        {
            static /*0x81e7ca0*/ UnityEngine.Networking.UnityWebRequest GetTexture(string uri);
            static /*0x81e7ca8*/ UnityEngine.Networking.UnityWebRequest GetTexture(string uri, bool nonReadable);
        }
    }
}
