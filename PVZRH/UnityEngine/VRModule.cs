class <Module>
{
}

namespace UnityEngine
{
    namespace XR
    {
        class XRSettings
        {
            static /*0x186afd0*/ bool get_enabled();
            static /*0x186b120*/ bool get_isDeviceActive();
            static /*0x186b0c0*/ float get_eyeTextureResolutionScale();
            static /*0x186b210*/ void set_eyeTextureResolutionScale(float value);
            static /*0x186b0f0*/ int get_eyeTextureWidth();
            static /*0x186b090*/ int get_eyeTextureHeight();
            static /*0x186b040*/ UnityEngine.RenderTextureDescriptor get_eyeTextureDesc();
            static /*0x186b180*/ float get_renderViewportScale();
            static /*0x186b180*/ float get_renderViewportScaleInternal();
            static /*0x186b150*/ string get_loadedDeviceName();
            static /*0x186b1e0*/ string[] get_supportedDevices();
            static /*0x186b1b0*/ UnityEngine.XR.XRSettings.StereoRenderingMode get_stereoRenderingMode();
            static /*0x186b000*/ void get_eyeTextureDesc_Injected(ref UnityEngine.RenderTextureDescriptor ret);

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

            static /*0x186af70*/ void InvokeDeviceLoaded(string loadedDeviceName);
        }
    }
}
