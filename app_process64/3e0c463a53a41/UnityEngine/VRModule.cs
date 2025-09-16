class <Module>
{
}

namespace UnityEngine
{
    namespace XR
    {
        class XRSettings
        {
            static /*0x81da9d0*/ bool get_enabled();
            static /*0x81da9f8*/ bool get_isDeviceActive();
            static /*0x81daa20*/ int get_eyeTextureWidth();
            static /*0x81daa48*/ int get_eyeTextureHeight();
            static /*0x81daa70*/ UnityEngine.RenderTextureDescriptor get_eyeTextureDesc();
            static /*0x81dab1c*/ float get_renderViewportScale();
            static /*0x81dab44*/ float get_renderViewportScaleInternal();
            static /*0x81dab6c*/ string get_loadedDeviceName();
            static /*0x81dac5c*/ string[] get_supportedDevices();
            static /*0x81dac84*/ UnityEngine.XR.XRSettings.StereoRenderingMode get_stereoRenderingMode();
            static /*0x81daae0*/ void get_eyeTextureDesc_Injected(ref UnityEngine.RenderTextureDescriptor ret);
            static /*0x81dac20*/ void get_loadedDeviceName_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);

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

            static /*0x81dacac*/ void DisableAutoXRCameraTracking(UnityEngine.Camera camera, bool disabled);
            static /*0x81dada0*/ void InvokeDeviceLoaded(string loadedDeviceName);
            static /*0x81dad5c*/ void DisableAutoXRCameraTracking_Injected(nint camera, bool disabled);
        }
    }
}
