class <Module>
{
}

namespace UnityEngine
{
    namespace Networking
    {
        class DownloadHandlerTexture : UnityEngine.Networking.DownloadHandler
        {
            /*0x18*/ UnityEngine.Texture2D mTexture;
            /*0x20*/ bool mHasTexture;
            /*0x21*/ bool mNonReadable;

            static /*0x2b39df8*/ nint Create(UnityEngine.Networking.DownloadHandlerTexture obj, bool readable);
            /*0x2b39ea0*/ DownloadHandlerTexture();
            /*0x2b39e48*/ void InternalCreateTexture(bool readable);
            /*0x2b39ef4*/ byte[] GetData();
            /*0x2b39efc*/ UnityEngine.Texture2D get_texture();
            /*0x2b39f00*/ UnityEngine.Texture2D InternalGetTexture();
            /*0x2b3a034*/ UnityEngine.Texture2D InternalGetTextureNative();
        }
    }
}
