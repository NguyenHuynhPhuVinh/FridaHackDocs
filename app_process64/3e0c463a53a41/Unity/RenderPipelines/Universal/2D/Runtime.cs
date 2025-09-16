class <Module>
{
}

namespace UnityEngine
{
    namespace Rendering
    {
        namespace Universal
        {
            class PixelPerfectCamera : UnityEngine.MonoBehaviour, UnityEngine.Rendering.Universal.IPixelPerfectCamera, UnityEngine.ISerializationCallbackReceiver
            {
                /*0x20*/ int m_AssetsPPU;
                /*0x24*/ int m_RefResolutionX;
                /*0x28*/ int m_RefResolutionY;
                /*0x2c*/ UnityEngine.Rendering.Universal.PixelPerfectCamera.CropFrame m_CropFrame;
                /*0x30*/ UnityEngine.Rendering.Universal.PixelPerfectCamera.GridSnapping m_GridSnapping;
                /*0x34*/ UnityEngine.Rendering.Universal.PixelPerfectCamera.PixelPerfectFilterMode m_FilterMode;
                /*0x38*/ UnityEngine.Camera m_Camera;
                /*0x40*/ UnityEngine.Rendering.Universal.PixelPerfectCameraInternal m_Internal;
                /*0x48*/ bool m_CinemachineCompatibilityMode;

                /*0x7c039c8*/ PixelPerfectCamera();
                /*0x7c01ef0*/ UnityEngine.Rendering.Universal.PixelPerfectCamera.CropFrame get_cropFrame();
                /*0x7c01ef8*/ void set_cropFrame(UnityEngine.Rendering.Universal.PixelPerfectCamera.CropFrame value);
                /*0x7c01f00*/ UnityEngine.Rendering.Universal.PixelPerfectCamera.GridSnapping get_gridSnapping();
                /*0x7c01f08*/ void set_gridSnapping(UnityEngine.Rendering.Universal.PixelPerfectCamera.GridSnapping value);
                /*0x7c01f10*/ float get_orthographicSize();
                /*0x7c01f2c*/ int get_assetsPPU();
                /*0x7c01f34*/ void set_assetsPPU(int value);
                /*0x7c01f54*/ int get_refResolutionX();
                /*0x7c01f5c*/ void set_refResolutionX(int value);
                /*0x7c01f7c*/ int get_refResolutionY();
                /*0x7c01f84*/ void set_refResolutionY(int value);
                /*0x7c01fa4*/ bool get_upscaleRT();
                /*0x7c01fb4*/ void set_upscaleRT(bool value);
                /*0x7c01fd8*/ bool get_pixelSnapping();
                /*0x7c01fe8*/ void set_pixelSnapping(bool value);
                /*0x7c02004*/ bool get_cropFrameX();
                /*0x7c02030*/ void set_cropFrameX(bool value);
                /*0x7c0207c*/ bool get_cropFrameY();
                /*0x7c02090*/ void set_cropFrameY(bool value);
                /*0x7c020dc*/ bool get_stretchFill();
                /*0x7c020ec*/ void set_stretchFill(bool value);
                /*0x7c02100*/ int get_pixelRatio();
                /*0x7c0214c*/ bool get_requiresUpscalePass();
                /*0x7c02168*/ UnityEngine.Vector3 RoundToPixel(UnityEngine.Vector3 position);
                /*0x7c02320*/ float CorrectCinemachineOrthoSize(float targetOrthoSize);
                /*0x7c02758*/ UnityEngine.FilterMode get_finalBlitFilterMode();
                /*0x7c02768*/ UnityEngine.Vector2Int get_offscreenRTSize();
                /*0x7c02784*/ UnityEngine.Vector2Int get_cameraRTSize();
                /*0x7c02850*/ void PixelSnap();
                /*0x7c02af0*/ void Awake();
                /*0x7c02be8*/ void UpdateCameraProperties();
                /*0x7c03670*/ void OnBeginCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
                /*0x7c0373c*/ void OnEndCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
                /*0x7c037c8*/ void OnEnable();
                /*0x7c038ac*/ void OnDisable();
                /*0x7c039c0*/ void OnBeforeSerialize();
                /*0x7c039c4*/ void OnAfterDeserialize();

                enum CropFrame
                {
                    None = 0,
                    Pillarbox = 1,
                    Letterbox = 2,
                    Windowbox = 3,
                    StretchFill = 4,
                }

                enum GridSnapping
                {
                    None = 0,
                    PixelSnapping = 1,
                    UpscaleRenderTexture = 2,
                }

                enum PixelPerfectFilterMode
                {
                    RetroAA = 0,
                    Point = 1,
                }
            }

            interface IPixelPerfectCamera
            {
                /*0x380b6a0*/ int get_assetsPPU();
                /*0x380b6a0*/ int get_refResolutionX();
                /*0x380b6a0*/ int get_refResolutionY();
                /*0x380b128*/ bool get_upscaleRT();
                /*0x380b128*/ bool get_pixelSnapping();
                /*0x380b128*/ bool get_cropFrameX();
                /*0x380b128*/ bool get_cropFrameY();
                /*0x380b128*/ bool get_stretchFill();
            }

            class PixelPerfectCameraInternal : UnityEngine.ISerializationCallbackReceiver
            {
                /*0x10*/ UnityEngine.Rendering.Universal.IPixelPerfectCamera m_Component;
                /*0x18*/ UnityEngine.Rendering.Universal.PixelPerfectCamera m_SerializableComponent;
                /*0x20*/ float originalOrthoSize;
                /*0x24*/ bool hasPostProcessLayer;
                /*0x25*/ bool cropFrameXAndY;
                /*0x26*/ bool cropFrameXOrY;
                /*0x27*/ bool useStretchFill;
                /*0x28*/ int zoom;
                /*0x2c*/ bool useOffscreenRT;
                /*0x30*/ int offscreenRTWidth;
                /*0x34*/ int offscreenRTHeight;
                /*0x38*/ UnityEngine.Rect pixelRect;
                /*0x48*/ float orthoSize;
                /*0x4c*/ float unitsPerPixel;
                /*0x50*/ int cinemachineVCamZoom;
                /*0x54*/ bool requiresUpscaling;

                /*0x7c02b90*/ PixelPerfectCameraInternal(UnityEngine.Rendering.Universal.IPixelPerfectCamera component);
                /*0x7c039e4*/ void OnBeforeSerialize();
                /*0x7c03aa0*/ void OnAfterDeserialize();
                /*0x7c02c7c*/ void CalculateCameraProperties(int screenWidth, int screenHeight);
                /*0x7c032dc*/ UnityEngine.Rect CalculateFinalBlitPixelRect(int screenWidth, int screenHeight);
                /*0x7c0233c*/ float CorrectCinemachineOrthoSize(float targetOrthoSize);
            }
        }
    }
}

class $BurstDirectCallInitializer
{
    static /*0x7c03b20*/ void Initialize();
}
