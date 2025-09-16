class <Module>
{
}

namespace UnityEngine
{
    namespace XR
    {
        class XRSettings
        {
            static /*0x81f1e00*/ bool get_enabled();
            static /*0x81f1e28*/ bool get_isDeviceActive();
            static /*0x81f1e50*/ int get_eyeTextureWidth();
            static /*0x81f1e78*/ int get_eyeTextureHeight();
            static /*0x81f1ea0*/ UnityEngine.RenderTextureDescriptor get_eyeTextureDesc();
            static /*0x81f1f4c*/ float get_renderViewportScale();
            static /*0x81f1f74*/ float get_renderViewportScaleInternal();
            static /*0x81f1f9c*/ string get_loadedDeviceName();
            static /*0x81f208c*/ string[] get_supportedDevices();
            static /*0x81f20b4*/ UnityEngine.XR.XRSettings.StereoRenderingMode get_stereoRenderingMode();
            static /*0x81f1f10*/ void get_eyeTextureDesc_Injected(ref UnityEngine.RenderTextureDescriptor ret);
            static /*0x81f2050*/ void get_loadedDeviceName_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);

            enum StereoRenderingMode
            {
                MultiPass = 0,
                SinglePass = 1,
                SinglePassInstanced = 2,
                SinglePassMultiview = 3,
            }
        }

        class XRDevice
        {
            static /*0x0*/ System.Action<string> deviceLoaded;

            static /*0x81f20dc*/ void DisableAutoXRCameraTracking(UnityEngine.Camera camera, bool disabled);
            static /*0x81f21d0*/ void InvokeDeviceLoaded(string loadedDeviceName);
            static /*0x81f218c*/ void DisableAutoXRCameraTracking_Injected(nint camera, bool disabled);
        }
    }
}
