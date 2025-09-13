class <Module>
{
}

namespace UnityEngine
{
    class ScreenCapture
    {
        static /*0x2b3a918*/ UnityEngine.Texture2D CaptureScreenshotAsTexture();
        static /*0x2b3a958*/ UnityEngine.Texture2D CaptureScreenshotAsTexture(int superSize, UnityEngine.ScreenCapture.StereoScreenCaptureMode stereoScreenCaptureMode);

        enum StereoScreenCaptureMode
        {
            LeftEye = 1,
            RightEye = 2,
            BothEyes = 3,
        }
    }
}
