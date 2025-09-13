class <Module>
{
}

namespace UnityEngine
{
    class ImageConversion
    {
        static /*0x2b3a65c*/ byte[] EncodeToPNG(UnityEngine.Texture2D tex);
        static /*0x2b3a69c*/ byte[] EncodeToJPG(UnityEngine.Texture2D tex, int quality);
        static /*0x2b3a6ec*/ byte[] EncodeToJPG(UnityEngine.Texture2D tex);
        static /*0x2b3a730*/ bool LoadImage(UnityEngine.Texture2D tex, byte[] data, bool markNonReadable);
        static /*0x2b3a788*/ bool LoadImage(UnityEngine.Texture2D tex, byte[] data);
    }
}
