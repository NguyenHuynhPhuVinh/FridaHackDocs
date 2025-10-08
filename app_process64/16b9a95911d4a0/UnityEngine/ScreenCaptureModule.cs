class <Module>
{
}

namespace UnityEngine
{
    class ScreenCapture
    {
        static /*0x3e951dc*/ UnityEngine.Texture2D CaptureScreenshotAsTexture();
        static /*0x3e951e8*/ UnityEngine.Texture2D CaptureScreenshotAsTexture(int superSize, UnityEngine.ScreenCapture.StereoScreenCaptureMode stereoScreenCaptureMode);
        static /*0x3e95264*/ nint CaptureScreenshotAsTexture_Injected(int superSize, UnityEngine.ScreenCapture.StereoScreenCaptureMode stereoScreenCaptureMode);

        enum StereoScreenCaptureMode
        {
            LeftEye = 1,
            RightEye = 2,
            BothEyes = 3,
            MotionVectors = 4,
        }
    }
}
