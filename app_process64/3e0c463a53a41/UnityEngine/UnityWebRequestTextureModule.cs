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

            static /*0x81d05e4*/ UnityEngine.Networking.DownloadedTextureParams get_Default();
            /*0x81d05ec*/ void set_readable(bool value);
            /*0x81d05fc*/ void SetFlags(UnityEngine.Networking.DownloadedTextureFlags flgs, bool add);
        }

        class DownloadHandlerTexture : UnityEngine.Networking.DownloadHandler
        {
            /*0x18*/ Unity.Collections.NativeArray<byte> m_NativeData;

            static /*0x81d0618*/ nint Create(UnityEngine.Networking.DownloadHandlerTexture obj, UnityEngine.Networking.DownloadedTextureParams parameters);
            static /*0x81d0660*/ nint Create_Injected(UnityEngine.Networking.DownloadHandlerTexture obj, ref UnityEngine.Networking.DownloadedTextureParams parameters);
            static /*0x81d081c*/ nint InternalGetTextureNative_Injected(nint _unity_self);
            /*0x81d06f0*/ DownloadHandlerTexture(bool readable);
            /*0x81d06a4*/ void InternalCreateTexture(UnityEngine.Networking.DownloadedTextureParams parameters);
            /*0x81d0760*/ Unity.Collections.NativeArray<byte> GetNativeData();
            /*0x81d076c*/ void Dispose();
            /*0x81d0790*/ UnityEngine.Texture2D get_texture();
            /*0x81d0794*/ UnityEngine.Texture2D InternalGetTextureNative();

            class BindingsMarshaller
            {
                static /*0x81d0858*/ nint ConvertToNative(UnityEngine.Networking.DownloadHandlerTexture handler);
            }
        }

        class UnityWebRequestTexture
        {
            static /*0x81d0870*/ UnityEngine.Networking.UnityWebRequest GetTexture(string uri);
            static /*0x81d0878*/ UnityEngine.Networking.UnityWebRequest GetTexture(string uri, bool nonReadable);
        }
    }
}
