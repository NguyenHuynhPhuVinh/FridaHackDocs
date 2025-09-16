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

                /*0x7c1adf8*/ PixelPerfectCamera();
                /*0x7c19320*/ UnityEngine.Rendering.Universal.PixelPerfectCamera.CropFrame get_cropFrame();
                /*0x7c19328*/ void set_cropFrame(UnityEngine.Rendering.Universal.PixelPerfectCamera.CropFrame value);
                /*0x7c19330*/ UnityEngine.Rendering.Universal.PixelPerfectCamera.GridSnapping get_gridSnapping();
                /*0x7c19338*/ void set_gridSnapping(UnityEngine.Rendering.Universal.PixelPerfectCamera.GridSnapping value);
                /*0x7c19340*/ float get_orthographicSize();
                /*0x7c1935c*/ int get_assetsPPU();
                /*0x7c19364*/ void set_assetsPPU(int value);
                /*0x7c19384*/ int get_refResolutionX();
                /*0x7c1938c*/ void set_refResolutionX(int value);
                /*0x7c193ac*/ int get_refResolutionY();
                /*0x7c193b4*/ void set_refResolutionY(int value);
                /*0x7c193d4*/ bool get_upscaleRT();
                /*0x7c193e4*/ void set_upscaleRT(bool value);
                /*0x7c19408*/ bool get_pixelSnapping();
                /*0x7c19418*/ void set_pixelSnapping(bool value);
                /*0x7c19434*/ bool get_cropFrameX();
                /*0x7c19460*/ void set_cropFrameX(bool value);
                /*0x7c194ac*/ bool get_cropFrameY();
                /*0x7c194c0*/ void set_cropFrameY(bool value);
                /*0x7c1950c*/ bool get_stretchFill();
                /*0x7c1951c*/ void set_stretchFill(bool value);
                /*0x7c19530*/ int get_pixelRatio();
                /*0x7c1957c*/ bool get_requiresUpscalePass();
                /*0x7c19598*/ UnityEngine.Vector3 RoundToPixel(UnityEngine.Vector3 position);
                /*0x7c19750*/ float CorrectCinemachineOrthoSize(float targetOrthoSize);
                /*0x7c19b88*/ UnityEngine.FilterMode get_finalBlitFilterMode();
                /*0x7c19b98*/ UnityEngine.Vector2Int get_offscreenRTSize();
                /*0x7c19bb4*/ UnityEngine.Vector2Int get_cameraRTSize();
                /*0x7c19c80*/ void PixelSnap();
                /*0x7c19f20*/ void Awake();
                /*0x7c1a018*/ void UpdateCameraProperties();
                /*0x7c1aaa0*/ void OnBeginCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
                /*0x7c1ab6c*/ void OnEndCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
                /*0x7c1abf8*/ void OnEnable();
                /*0x7c1acdc*/ void OnDisable();
                /*0x7c1adf0*/ void OnBeforeSerialize();
                /*0x7c1adf4*/ void OnAfterDeserialize();

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
                /*0x3814574*/ int get_assetsPPU();
                /*0x3814574*/ int get_refResolutionX();
                /*0x3814574*/ int get_refResolutionY();
                /*0x3813ffc*/ bool get_upscaleRT();
                /*0x3813ffc*/ bool get_pixelSnapping();
                /*0x3813ffc*/ bool get_cropFrameX();
                /*0x3813ffc*/ bool get_cropFrameY();
                /*0x3813ffc*/ bool get_stretchFill();
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

                /*0x7c19fc0*/ PixelPerfectCameraInternal(UnityEngine.Rendering.Universal.IPixelPerfectCamera component);
                /*0x7c1ae14*/ void OnBeforeSerialize();
                /*0x7c1aed0*/ void OnAfterDeserialize();
                /*0x7c1a0ac*/ void CalculateCameraProperties(int screenWidth, int screenHeight);
                /*0x7c1a70c*/ UnityEngine.Rect CalculateFinalBlitPixelRect(int screenWidth, int screenHeight);
                /*0x7c1976c*/ float CorrectCinemachineOrthoSize(float targetOrthoSize);
            }
        }
    }
}

class $BurstDirectCallInitializer
{
    static /*0x7c1af50*/ void Initialize();
}
