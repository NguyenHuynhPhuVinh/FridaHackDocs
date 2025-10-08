class <Module>
{
}

namespace UnityEngine
{
    class ImageConversion
    {
        static /*0x3e381d4*/ byte[] EncodeToPNG(UnityEngine.Texture2D tex);
        static /*0x3e3835c*/ bool LoadImage(UnityEngine.Texture2D tex, System.ReadOnlySpan<byte> data, bool markNonReadable);
        static /*0x3e384d8*/ bool LoadImage(UnityEngine.Texture2D tex, byte[] data, bool markNonReadable);
        static /*0x3e38540*/ bool LoadImage(UnityEngine.Texture2D tex, byte[] data);
        static /*0x3e38318*/ void EncodeToPNG_Injected(nint tex, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x3e38484*/ bool LoadImage_Injected(nint tex, ref UnityEngine.Bindings.ManagedSpanWrapper data, bool markNonReadable);
    }
}
