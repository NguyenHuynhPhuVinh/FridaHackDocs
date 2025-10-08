class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x30cbd30*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x30cbe24*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace LeTai
{
    namespace Asset
    {
        namespace TranslucentImage
        {
            namespace Demo
            {
                class AutoMoveAndRotate : UnityEngine.MonoBehaviour
                {
                    /*0x20*/ LeTai.Asset.TranslucentImage.Demo.AutoMoveAndRotate.Vector3andSpace moveUnitsPerSecond;
                    /*0x28*/ LeTai.Asset.TranslucentImage.Demo.AutoMoveAndRotate.Vector3andSpace rotateDegreesPerSecond;
                    /*0x30*/ bool ignoreTimescale;
                    /*0x31*/ bool lateUpdate;
                    /*0x34*/ float m_LastRealTime;

                    /*0x30cbf2c*/ AutoMoveAndRotate();
                    /*0x30cbe2c*/ void Start();
                    /*0x30cbe48*/ void Update();
                    /*0x30cbf1c*/ void LateUpdate();
                    /*0x30cbe58*/ void DoWork();

                    class Vector3andSpace
                    {
                        /*0x10*/ UnityEngine.Vector3 value;
                        /*0x1c*/ UnityEngine.Space space;

                        /*0x30cbf34*/ Vector3andSpace();
                    }
                }

                class ColorSchemeManager : UnityEngine.MonoBehaviour
                {
                    /*0x20*/ UnityEngine.Color lightBackgroudColor;
                    /*0x30*/ UnityEngine.Color lightForegroudColor;
                    /*0x40*/ UnityEngine.Color lightTextColor;
                    /*0x50*/ UnityEngine.Color darkBackgroudColor;
                    /*0x60*/ UnityEngine.Color darkForegroudColor;
                    /*0x70*/ UnityEngine.Color darkTextColor;
                    /*0x80*/ float lightSpriteBlending;
                    /*0x84*/ float darkSpriteBlending;
                    /*0x88*/ LeTai.Asset.TranslucentImage.TranslucentImage[] foregroundGraphic;
                    /*0x90*/ UnityEngine.UI.Text[] texts;
                    /*0x98*/ UnityEngine.Camera cam;

                    /*0x30cc204*/ ColorSchemeManager();
                    /*0x30cbf44*/ void Start();
                    /*0x30cbfa0*/ void SetLightScheme(bool on);
                    /*0x30cbfb8*/ void SetColorScheme(LeTai.Asset.TranslucentImage.Demo.ColorSchemeManager.DemoColorScheme scheme);

                    enum DemoColorScheme
                    {
                        Light = 0,
                        Dark = 1,
                    }
                }

                class FPSCounter : UnityEngine.MonoBehaviour
                {
                    static float fpsMeasurePeriod = 0.5;
                    /*0x20*/ int m_FpsAccumulator;
                    /*0x24*/ float m_FpsNextPeriod;
                    /*0x28*/ int m_CurrentFps;
                    /*0x30*/ string display;
                    /*0x38*/ UnityEngine.UI.Text m_Text;

                    /*0x30cc398*/ FPSCounter();
                    /*0x30cc230*/ void Start();
                    /*0x30cc2dc*/ void Update();
                }

                class MainDemoViewController : UnityEngine.MonoBehaviour
                {
                    /*0x20*/ UnityEngine.UI.Toggle toggleLightMode;
                    /*0x28*/ UnityEngine.UI.Toggle toggleDarkMode;
                    /*0x30*/ UnityEngine.UI.Slider sliderBlurStrength;
                    /*0x38*/ UnityEngine.UI.Slider sliderVibrancy;
                    /*0x40*/ UnityEngine.UI.Slider sliderUpdateRate;
                    /*0x48*/ LeTai.Asset.TranslucentImage.TranslucentImage[] translucentImages;
                    /*0x50*/ LeTai.Asset.TranslucentImage.TranslucentImageSource source;
                    /*0x58*/ float backupBlurStrength;
                    /*0x60*/ float[] backupVibrancy;

                    /*0x30cc960*/ MainDemoViewController();
                    /*0x30cc3f0*/ void Start();
                    /*0x30cc704*/ void BackupValues();
                    /*0x30cc854*/ void OnDestroy();

                    class <>c__DisplayClass9_0
                    {
                        /*0x10*/ LeTai.Asset.TranslucentImage.Demo.ColorSchemeManager colorSchemeManager;
                        /*0x18*/ LeTai.Asset.TranslucentImage.Demo.MainDemoViewController <>4__this;

                        /*0x30cc6fc*/ <>c__DisplayClass9_0();
                        /*0x30cc968*/ void <Start>b__0(bool isOn);
                        /*0x30cc988*/ void <Start>b__1(bool isOn);
                        /*0x30cc9a8*/ void <Start>b__2(float value);
                        /*0x30cc9d8*/ void <Start>b__3(float value);
                        /*0x30ccab8*/ void <Start>b__4(float value);
                    }
                }

                class SimpleCameraController : UnityEngine.MonoBehaviour
                {
                    /*0x20*/ LeTai.Asset.TranslucentImage.Demo.SimpleCameraController.CameraState m_TargetCameraState;
                    /*0x28*/ LeTai.Asset.TranslucentImage.Demo.SimpleCameraController.CameraState m_InterpolatingCameraState;
                    /*0x30*/ float boost;
                    /*0x34*/ float positionLerpTime;
                    /*0x38*/ UnityEngine.AnimationCurve mouseSensitivityCurve;
                    /*0x40*/ float rotationLerpTime;
                    /*0x44*/ bool invertY;

                    /*0x30cd288*/ SimpleCameraController();
                    /*0x30ccb74*/ void OnEnable();
                    /*0x30ccc4c*/ UnityEngine.Vector3 GetInputTranslationDirection();
                    /*0x30cce78*/ void Update();

                    class CameraState
                    {
                        /*0x10*/ float yaw;
                        /*0x14*/ float pitch;
                        /*0x18*/ float roll;
                        /*0x1c*/ float x;
                        /*0x20*/ float y;
                        /*0x24*/ float z;

                        /*0x30cd448*/ CameraState();
                        /*0x30ccbc8*/ void SetFromTransform(UnityEngine.Transform t);
                        /*0x30cd150*/ void Translate(UnityEngine.Vector3 translation);
                        /*0x30cd1e0*/ void LerpTowards(LeTai.Asset.TranslucentImage.Demo.SimpleCameraController.CameraState target, float positionLerpPct, float rotationLerpPct);
                        /*0x30cd240*/ void UpdateTransform(UnityEngine.Transform t);
                    }
                }

                class SliderChangeOnStart : UnityEngine.MonoBehaviour
                {
                    /*0x20*/ UnityEngine.UI.Slider slider;

                    /*0x30cd52c*/ SliderChangeOnStart();
                    /*0x30cd450*/ void Start();
                }

                class UnrestrictFramerate : UnityEngine.MonoBehaviour
                {
                    /*0x30cd5b0*/ UnrestrictFramerate();
                    /*0x30cd534*/ void Start();
                }

                class WorldSpaceSetup : UnityEngine.MonoBehaviour
                {
                    /*0x20*/ UnityEngine.Camera sceneCamera;
                    /*0x28*/ UnityEngine.Camera uiCamera;

                    /*0x30cd6a4*/ WorldSpaceSetup();
                    /*0x30cd5b8*/ void SetUIAlwaysOnTop(bool isAlwaysOnTop);
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 2FBBDF98CCF09F545C55D5EFCDD5442641D37AF840970ACD4ADE9B96F78EC55E;
    static /*0x257*/ <PrivateImplementationDetails> 34897BC2FA408430F05ED61E543F2A16F3B35B97B0D7756ED189DD73082D57DA;

    struct __StaticArrayInitTypeSize=599
    {
    }

    struct __StaticArrayInitTypeSize=614
    {
    }
}
